// Namespace: System.Xml.Schema
public enum XmlSchemaUse // TypeDefIndex: 12469
{
	// Fields
	public int value__; // 0x0
	[XmlIgnore]
	public const XmlSchemaUse None = 0;
	[XmlEnum("optional")]
	public const XmlSchemaUse Optional = 1;
	[XmlEnum("prohibited")]
	public const XmlSchemaUse Prohibited = 2;
	[XmlEnum("required")]
	public const XmlSchemaUse Required = 3;
}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaValidationException : XmlSchemaException // TypeDefIndex: 12470
{
	// Methods

	// RVA: 0x1F18460 Offset: 0x1F17660 VA: 0x181F18460
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1F18370 Offset: 0x1F17570 VA: 0x181F18370 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1F18480 Offset: 0x1F17680 VA: 0x181F18480
	public void .ctor() { }

	// RVA: 0x1F84760 Offset: 0x1F83960 VA: 0x181F84760
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1F846E0 Offset: 0x1F838E0 VA: 0x181F846E0
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1F84720 Offset: 0x1F83920 VA: 0x181F84720
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Schema
public sealed class XmlValueGetter : MulticastDelegate // TypeDefIndex: 12471
{
	// Methods

	// RVA: 0x1202980 Offset: 0x1201B80 VA: 0x181202980
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual object Invoke() { }
}

// Namespace: System.Xml.Schema
[Flags]
public enum XmlSchemaValidationFlags // TypeDefIndex: 12472
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaValidationFlags None = 0;
	public const XmlSchemaValidationFlags ProcessInlineSchema = 1;
	public const XmlSchemaValidationFlags ProcessSchemaLocation = 2;
	public const XmlSchemaValidationFlags ReportValidationWarnings = 4;
	public const XmlSchemaValidationFlags ProcessIdentityConstraints = 8;
	public const XmlSchemaValidationFlags AllowXmlAttributes = 16;
}

// Namespace: System.Xml.Schema
internal enum ValidatorState // TypeDefIndex: 12473
{
	// Fields
	public int value__; // 0x0
	public const ValidatorState None = 0;
	public const ValidatorState Start = 1;
	public const ValidatorState TopLevelAttribute = 2;
	public const ValidatorState TopLevelTextOrWS = 3;
	public const ValidatorState Element = 4;
	public const ValidatorState Attribute = 5;
	public const ValidatorState EndOfAttributes = 6;
	public const ValidatorState Text = 7;
	public const ValidatorState Whitespace = 8;
	public const ValidatorState EndElement = 9;
	public const ValidatorState SkipToEndElement = 10;
	public const ValidatorState Finish = 11;
}

// Namespace: System.Xml.Schema
internal class IdRefNode // TypeDefIndex: 12474
{
	// Fields
	internal string Id; // 0x10
	internal int LineNo; // 0x18
	internal int LinePos; // 0x1C
	internal IdRefNode Next; // 0x20

	// Methods

	// RVA: 0x1F72DF0 Offset: 0x1F71FF0 VA: 0x181F72DF0
	internal void .ctor(IdRefNode next, string id, int lineNo, int linePos) { }
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaValidator // TypeDefIndex: 12475
{
	// Fields
	private XmlSchemaSet schemaSet; // 0x10
	private XmlSchemaValidationFlags validationFlags; // 0x18
	private int startIDConstraint; // 0x1C
	private bool isRoot; // 0x20
	private bool rootHasSchema; // 0x21
	private bool attrValid; // 0x22
	private bool checkEntity; // 0x23
	private SchemaInfo compiledSchemaInfo; // 0x28
	private IDtdInfo dtdSchemaInfo; // 0x30
	private Hashtable validatedNamespaces; // 0x38
	private HWStack validationStack; // 0x40
	private ValidationState context; // 0x48
	private ValidatorState currentState; // 0x50
	private Hashtable attPresence; // 0x58
	private SchemaAttDef wildID; // 0x60
	private Hashtable IDs; // 0x68
	private IdRefNode idRefListHead; // 0x70
	private XmlQualifiedName contextQName; // 0x78
	private string NsXs; // 0x80
	private string NsXsi; // 0x88
	private string NsXmlNs; // 0x90
	private string NsXml; // 0x98
	private XmlSchemaObject partialValidationType; // 0xA0
	private StringBuilder textValue; // 0xA8
	private ValidationEventHandler eventHandler; // 0xB0
	private object validationEventSender; // 0xB8
	private XmlNameTable nameTable; // 0xC0
	private IXmlLineInfo positionInfo; // 0xC8
	private IXmlLineInfo dummyPositionInfo; // 0xD0
	private XmlResolver xmlResolver; // 0xD8
	private Uri sourceUri; // 0xE0
	private string sourceUriString; // 0xE8
	private IXmlNamespaceResolver nsResolver; // 0xF0
	private XmlSchemaContentProcessing processContents; // 0xF8
	private string xsiTypeString; // 0x100
	private string xsiNilString; // 0x108
	private string xsiSchemaLocationString; // 0x110
	private string xsiNoNamespaceSchemaLocationString; // 0x118
	private static readonly XmlSchemaDatatype dtQName; // 0x0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private static XmlSchemaParticle[] EmptyParticleArray; // 0x18
	private static XmlSchemaAttribute[] EmptyAttributeArray; // 0x20
	private XmlCharType xmlCharType; // 0x120
	internal static bool[,] ValidStates; // 0x28
	private static string[] MethodNames; // 0x30

	// Properties
	public XmlResolver XmlResolver { set; }
	public IXmlLineInfo LineInfoProvider { set; }
	public Uri SourceUri { set; }
	public object ValidationEventSender { set; }
	internal XmlSchemaSet SchemaSet { get; }
	internal XmlSchemaValidationFlags ValidationFlags { get; }
	internal XmlSchemaContentType CurrentContentType { get; }
	private bool StrictlyAssessed { get; }
	private bool HasSchema { get; }
	private bool HasIdentityConstraints { get; }
	internal bool ProcessIdentityConstraints { get; }
	internal bool ReportValidationWarnings { get; }
	internal bool ProcessSchemaHints { get; }

	// Methods

	// RVA: 0x1F904A0 Offset: 0x1F8F6A0 VA: 0x181F904A0
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0x1F8A1E0 Offset: 0x1F893E0 VA: 0x181F8A1E0
	private void Init() { }

	// RVA: 0x1F8CC50 Offset: 0x1F8BE50 VA: 0x181F8CC50
	private void Reset() { }

	// RVA: 0x599C70 Offset: 0x598E70 VA: 0x180599C70
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1F90A70 Offset: 0x1F8FC70 VA: 0x181F90A70
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0x1F90A90 Offset: 0x1F8FC90 VA: 0x181F90A90
	public void set_SourceUri(Uri value) { }

	// RVA: 0x146AE20 Offset: 0x146A020 VA: 0x18146AE20
	public void set_ValidationEventSender(object value) { }

	// RVA: 0x1F90800 Offset: 0x1F8FA00 VA: 0x181F90800
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1F909D0 Offset: 0x1F8FBD0 VA: 0x181F909D0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1F84D50 Offset: 0x1F83F50 VA: 0x181F84D50
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0x1F8A540 Offset: 0x1F89740 VA: 0x181F8A540
	public void Initialize() { }

	// RVA: 0x1F8A6A0 Offset: 0x1F898A0 VA: 0x181F8A6A0
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0x1F8F3A0 Offset: 0x1F8E5A0 VA: 0x181F8F3A0
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x1F8ED70 Offset: 0x1F8DF70 VA: 0x181F8ED70
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1F8E2F0 Offset: 0x1F8D4F0 VA: 0x181F8E2F0
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1F8F8B0 Offset: 0x1F8EAB0 VA: 0x181F8F8B0
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1F8F9E0 Offset: 0x1F8EBE0 VA: 0x181F8F9E0
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0x1F8FA50 Offset: 0x1F8EC50 VA: 0x181F8FA50
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x1F90100 Offset: 0x1F8F300 VA: 0x181F90100
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0x1F8FE90 Offset: 0x1F8F090 VA: 0x181F8FE90
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x1F8F8A0 Offset: 0x1F8EAA0 VA: 0x181F8F8A0
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1F8D7D0 Offset: 0x1F8C9D0 VA: 0x181F8D7D0
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1F88CC0 Offset: 0x1F87EC0 VA: 0x181F88CC0
	public void EndValidation() { }

	// RVA: 0x1F89B20 Offset: 0x1F88D20 VA: 0x181F89B20
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x1F908A0 Offset: 0x1F8FAA0 VA: 0x181F908A0
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0x1F8D7C0 Offset: 0x1F8C9C0 VA: 0x181F8D7C0
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0x1F90990 Offset: 0x1F8FB90 VA: 0x181F90990
	private bool get_StrictlyAssessed() { }

	// RVA: 0x1F90900 Offset: 0x1F8FB00 VA: 0x181F90900
	private bool get_HasSchema() { }

	// RVA: 0x1F89480 Offset: 0x1F88680 VA: 0x181F89480
	internal string GetConcatenatedValue() { }

	// RVA: 0x1F8A9B0 Offset: 0x1F89BB0 VA: 0x181F8A9B0
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0x1F8C3D0 Offset: 0x1F8B5D0 VA: 0x181F8C3D0
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x1F8EDF0 Offset: 0x1F8DFF0 VA: 0x181F8EDF0
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	// RVA: 0x1F898A0 Offset: 0x1F88AA0 VA: 0x181F898A0
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0x1F8E020 Offset: 0x1F8D220 VA: 0x181F8E020
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x1F8DC40 Offset: 0x1F8CE40 VA: 0x181F8DC40
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x1F89AB0 Offset: 0x1F88CB0 VA: 0x181F89AB0
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0x1F8CD00 Offset: 0x1F8BF00 VA: 0x181F8CD00
	private void SaveTextValue(object value) { }

	// RVA: 0x1F8C9B0 Offset: 0x1F8BBB0 VA: 0x181F8C9B0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1F8B470 Offset: 0x1F8A670 VA: 0x181F8B470
	private void Pop() { }

	// RVA: 0x1F89100 Offset: 0x1F88300 VA: 0x181F89100
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0x1F86750 Offset: 0x1F85950 VA: 0x181F86750
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	// RVA: 0x1F8DA00 Offset: 0x1F8CC00 VA: 0x181F8DA00
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0x1F859B0 Offset: 0x1F84BB0 VA: 0x181F859B0
	private void CheckElementProperties() { }

	// RVA: 0x1F8F980 Offset: 0x1F8EB80 VA: 0x181F8F980
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x1F85EB0 Offset: 0x1F850B0 VA: 0x181F85EB0
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0x1F85180 Offset: 0x1F84380 VA: 0x181F85180
	private void AddXmlNamespaceSchema() { }

	// RVA: 0x1F86040 Offset: 0x1F85240 VA: 0x181F86040
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0x1F8B030 Offset: 0x1F8A230 VA: 0x181F8B030
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x1F8CBE0 Offset: 0x1F8BDE0 VA: 0x181F8CBE0
	internal void RecompileSchemaSet() { }

	// RVA: 0x1F8C6B0 Offset: 0x1F8B8B0 VA: 0x181F8C6B0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0x1F85740 Offset: 0x1F84940 VA: 0x181F85740
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0x1F85AA0 Offset: 0x1F84CA0 VA: 0x181F85AA0
	private object CheckElementValue(string stringValue) { }

	// RVA: 0x1F865B0 Offset: 0x1F857B0 VA: 0x181F865B0
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0x1F89450 Offset: 0x1F88650 VA: 0x181F89450
	private object FindId(string name) { }

	// RVA: 0x1F85D90 Offset: 0x1F84F90 VA: 0x181F85D90
	private void CheckForwardRefs() { }

	// RVA: 0x1F908E0 Offset: 0x1F8FAE0 VA: 0x181F908E0
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x1F90950 Offset: 0x1F8FB50 VA: 0x181F90950
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0x1F90980 Offset: 0x1F8FB80 VA: 0x181F90980
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0x1F90960 Offset: 0x1F8FB60 VA: 0x181F90960
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0x1F86320 Offset: 0x1F85520 VA: 0x181F86320
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0x1F86DF0 Offset: 0x1F85FF0 VA: 0x181F86DF0
	private void ClearPSVI() { }

	// RVA: 0x1F86150 Offset: 0x1F85350 VA: 0x181F86150
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0x1F89750 Offset: 0x1F88950 VA: 0x181F89750
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0x1F894B0 Offset: 0x1F886B0 VA: 0x181F894B0
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0x1F84820 Offset: 0x1F83A20 VA: 0x181F84820
	private void AddIdentityConstraints() { }

	// RVA: 0x1F87460 Offset: 0x1F86660 VA: 0x181F87460
	private void ElementIdentityConstraints() { }

	// RVA: 0x1F85260 Offset: 0x1F84460 VA: 0x181F85260
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0x1F88130 Offset: 0x1F87330 VA: 0x181F88130
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0x1F877D0 Offset: 0x1F869D0 VA: 0x181F877D0
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x1F86E50 Offset: 0x1F86050 VA: 0x181F86E50
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x1F8B5D0 Offset: 0x1F8A7D0 VA: 0x181F8B5D0
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0x1F8C110 Offset: 0x1F8B310 VA: 0x181F8C110
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0x1F8BB60 Offset: 0x1F8AD60 VA: 0x181F8BB60
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0x1F88ED0 Offset: 0x1F880D0 VA: 0x181F88ED0
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0x1F8CB70 Offset: 0x1F8BD70 VA: 0x181F8CB70
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0x1F856D0 Offset: 0x1F848D0 VA: 0x181F856D0
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0x1F85570 Offset: 0x1F84770 VA: 0x181F85570
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0x1F8C2A0 Offset: 0x1F8B4A0 VA: 0x181F8C2A0
	private void ProcessEntity(string name) { }

	// RVA: 0x1F8D1E0 Offset: 0x1F8C3E0 VA: 0x181F8D1E0
	private void SendValidationEvent(string code) { }

	// RVA: 0x1F8D340 Offset: 0x1F8C540 VA: 0x181F8D340
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x1F8D240 Offset: 0x1F8C440 VA: 0x181F8D240
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0x1F8CE80 Offset: 0x1F8C080 VA: 0x181F8CE80
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0x1F8D550 Offset: 0x1F8C750 VA: 0x181F8D550
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0x1F8CD60 Offset: 0x1F8BF60 VA: 0x181F8CD60
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0x1F8CD50 Offset: 0x1F8BF50 VA: 0x181F8CD50
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0x1F8D460 Offset: 0x1F8C660 VA: 0x181F8D460
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1F8D6A0 Offset: 0x1F8C8A0 VA: 0x181F8D6A0
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x1F8CFE0 Offset: 0x1F8C1E0 VA: 0x181F8CFE0
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x1F8D120 Offset: 0x1F8C320 VA: 0x181F8D120
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x1F90170 Offset: 0x1F8F370 VA: 0x181F90170
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaValidity // TypeDefIndex: 12476
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaValidity NotKnown = 0;
	public const XmlSchemaValidity Valid = 1;
	public const XmlSchemaValidity Invalid = 2;
}

// Namespace: System.Xml.Schema
public enum XmlSeverityType // TypeDefIndex: 12477
{
	// Fields
	public int value__; // 0x0
	public const XmlSeverityType Error = 0;
	public const XmlSeverityType Warning = 1;
}

// Namespace: System.Xml.Schema
public enum XmlTypeCode // TypeDefIndex: 12478
{
	// Fields
	public int value__; // 0x0
	public const XmlTypeCode None = 0;
	public const XmlTypeCode Item = 1;
	public const XmlTypeCode Node = 2;
	public const XmlTypeCode Document = 3;
	public const XmlTypeCode Element = 4;
	public const XmlTypeCode Attribute = 5;
	public const XmlTypeCode Namespace = 6;
	public const XmlTypeCode ProcessingInstruction = 7;
	public const XmlTypeCode Comment = 8;
	public const XmlTypeCode Text = 9;
	public const XmlTypeCode AnyAtomicType = 10;
	public const XmlTypeCode UntypedAtomic = 11;
	public const XmlTypeCode String = 12;
	public const XmlTypeCode Boolean = 13;
	public const XmlTypeCode Decimal = 14;
	public const XmlTypeCode Float = 15;
	public const XmlTypeCode Double = 16;
	public const XmlTypeCode Duration = 17;
	public const XmlTypeCode DateTime = 18;
	public const XmlTypeCode Time = 19;
	public const XmlTypeCode Date = 20;
	public const XmlTypeCode GYearMonth = 21;
	public const XmlTypeCode GYear = 22;
	public const XmlTypeCode GMonthDay = 23;
	public const XmlTypeCode GDay = 24;
	public const XmlTypeCode GMonth = 25;
	public const XmlTypeCode HexBinary = 26;
	public const XmlTypeCode Base64Binary = 27;
	public const XmlTypeCode AnyUri = 28;
	public const XmlTypeCode QName = 29;
	public const XmlTypeCode Notation = 30;
	public const XmlTypeCode NormalizedString = 31;
	public const XmlTypeCode Token = 32;
	public const XmlTypeCode Language = 33;
	public const XmlTypeCode NmToken = 34;
	public const XmlTypeCode Name = 35;
	public const XmlTypeCode NCName = 36;
	public const XmlTypeCode Id = 37;
	public const XmlTypeCode Idref = 38;
	public const XmlTypeCode Entity = 39;
	public const XmlTypeCode Integer = 40;
	public const XmlTypeCode NonPositiveInteger = 41;
	public const XmlTypeCode NegativeInteger = 42;
	public const XmlTypeCode Long = 43;
	public const XmlTypeCode Int = 44;
	public const XmlTypeCode Short = 45;
	public const XmlTypeCode Byte = 46;
	public const XmlTypeCode NonNegativeInteger = 47;
	public const XmlTypeCode UnsignedLong = 48;
	public const XmlTypeCode UnsignedInt = 49;
	public const XmlTypeCode UnsignedShort = 50;
	public const XmlTypeCode UnsignedByte = 51;
	public const XmlTypeCode PositiveInteger = 52;
	public const XmlTypeCode YearMonthDuration = 53;
	public const XmlTypeCode DayTimeDuration = 54;
}

// Namespace: System.Xml.Schema
internal abstract class XmlValueConverter // TypeDefIndex: 12479
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ToBoolean(long value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool ToBoolean(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool ToBoolean(double value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ToBoolean(DateTime value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool ToBoolean(string value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool ToBoolean(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int ToInt32(bool value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int ToInt32(long value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int ToInt32(double value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int ToInt32(DateTime value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int ToInt32(string value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int ToInt32(object value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract long ToInt64(bool value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract long ToInt64(int value);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract long ToInt64(double value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract long ToInt64(DateTime value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract long ToInt64(string value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract long ToInt64(object value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Decimal ToDecimal(string value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract Decimal ToDecimal(object value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract double ToDouble(bool value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract double ToDouble(int value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract double ToDouble(long value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract double ToDouble(DateTime value);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract double ToDouble(string value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract double ToDouble(object value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract float ToSingle(double value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract float ToSingle(string value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract float ToSingle(object value);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract DateTime ToDateTime(bool value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract DateTime ToDateTime(int value);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract DateTime ToDateTime(long value);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract DateTime ToDateTime(double value);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract DateTime ToDateTime(DateTimeOffset value);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract DateTime ToDateTime(string value);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract DateTime ToDateTime(object value);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract DateTimeOffset ToDateTimeOffset(DateTime value);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract DateTimeOffset ToDateTimeOffset(string value);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract DateTimeOffset ToDateTimeOffset(object value);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract string ToString(bool value);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract string ToString(int value);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract string ToString(long value);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract string ToString(Decimal value);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract string ToString(float value);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract string ToString(double value);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract string ToString(DateTime value);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract string ToString(DateTimeOffset value);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract string ToString(object value);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract string ToString(object value, IXmlNamespaceResolver nsResolver);

	// RVA: -1 Offset: -1 Slot: 53
	public abstract object ChangeType(bool value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 54
	public abstract object ChangeType(int value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 55
	public abstract object ChangeType(long value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 56
	public abstract object ChangeType(Decimal value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract object ChangeType(double value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 58
	public abstract object ChangeType(DateTime value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 59
	public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver);

	// RVA: -1 Offset: -1 Slot: 60
	public abstract object ChangeType(object value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 61
	public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class XmlBaseConverter : XmlValueConverter // TypeDefIndex: 12480
{
	// Fields
	private XmlSchemaType schemaType; // 0x10
	private XmlTypeCode typeCode; // 0x18
	private Type clrTypeDefault; // 0x20
	protected static readonly Type ICollectionType; // 0x0
	protected static readonly Type IEnumerableType; // 0x8
	protected static readonly Type IListType; // 0x10
	protected static readonly Type ObjectArrayType; // 0x18
	protected static readonly Type StringArrayType; // 0x20
	protected static readonly Type XmlAtomicValueArrayType; // 0x28
	protected static readonly Type DecimalType; // 0x30
	protected static readonly Type Int32Type; // 0x38
	protected static readonly Type Int64Type; // 0x40
	protected static readonly Type StringType; // 0x48
	protected static readonly Type XmlAtomicValueType; // 0x50
	protected static readonly Type ObjectType; // 0x58
	protected static readonly Type ByteType; // 0x60
	protected static readonly Type Int16Type; // 0x68
	protected static readonly Type SByteType; // 0x70
	protected static readonly Type UInt16Type; // 0x78
	protected static readonly Type UInt32Type; // 0x80
	protected static readonly Type UInt64Type; // 0x88
	protected static readonly Type XPathItemType; // 0x90
	protected static readonly Type DoubleType; // 0x98
	protected static readonly Type SingleType; // 0xA0
	protected static readonly Type DateTimeType; // 0xA8
	protected static readonly Type DateTimeOffsetType; // 0xB0
	protected static readonly Type BooleanType; // 0xB8
	protected static readonly Type ByteArrayType; // 0xC0
	protected static readonly Type XmlQualifiedNameType; // 0xC8
	protected static readonly Type UriType; // 0xD0
	protected static readonly Type TimeSpanType; // 0xD8
	protected static readonly Type XPathNavigatorType; // 0xE0

	// Properties
	protected XmlSchemaType SchemaType { get; }
	protected XmlTypeCode TypeCode { get; }
	protected string XmlTypeName { get; }
	protected Type DefaultClrType { get; }

	// Methods

	// RVA: 0x1F799D0 Offset: 0x1F78BD0 VA: 0x181F799D0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1F798D0 Offset: 0x1F78AD0 VA: 0x181F798D0
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1F79BA0 Offset: 0x1F78DA0 VA: 0x181F79BA0
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x1F79880 Offset: 0x1F78A80 VA: 0x181F79880
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x1F76910 Offset: 0x1F75B10 VA: 0x181F76910 Slot: 7
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x1F76810 Offset: 0x1F75A10 VA: 0x181F76810 Slot: 6
	public override bool ToBoolean(double value) { }

	// RVA: 0x1F76650 Offset: 0x1F75850 VA: 0x181F76650 Slot: 5
	public override bool ToBoolean(int value) { }

	// RVA: 0x1F76AD0 Offset: 0x1F75CD0 VA: 0x181F76AD0 Slot: 4
	public override bool ToBoolean(long value) { }

	// RVA: 0x1F76740 Offset: 0x1F75940 VA: 0x181F76740 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1F76A00 Offset: 0x1F75C00 VA: 0x181F76A00 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1F77230 Offset: 0x1F76430 VA: 0x181F77230 Slot: 33
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x1F773F0 Offset: 0x1F765F0 VA: 0x181F773F0 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1F76E80 Offset: 0x1F76080 VA: 0x181F76E80 Slot: 36
	public override DateTime ToDateTime(double value) { }

	// RVA: 0x1F77140 Offset: 0x1F76340 VA: 0x181F77140 Slot: 34
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x1F76F80 Offset: 0x1F76180 VA: 0x181F76F80 Slot: 35
	public override DateTime ToDateTime(long value) { }

	// RVA: 0x1F77320 Offset: 0x1F76520 VA: 0x181F77320 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1F77070 Offset: 0x1F76270 VA: 0x181F77070 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1F76CA0 Offset: 0x1F75EA0 VA: 0x181F76CA0 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1F76BC0 Offset: 0x1F75DC0 VA: 0x181F76BC0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1F76DA0 Offset: 0x1F75FA0 VA: 0x181F76DA0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1F775C0 Offset: 0x1F767C0 VA: 0x181F775C0 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1F774E0 Offset: 0x1F766E0 VA: 0x181F774E0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1F77860 Offset: 0x1F76A60 VA: 0x181F77860 Slot: 24
	public override double ToDouble(bool value) { }

	// RVA: 0x1F77770 Offset: 0x1F76970 VA: 0x181F77770 Slot: 27
	public override double ToDouble(DateTime value) { }

	// RVA: 0x1F77A20 Offset: 0x1F76C20 VA: 0x181F77A20 Slot: 25
	public override double ToDouble(int value) { }

	// RVA: 0x1F77B10 Offset: 0x1F76D10 VA: 0x181F77B10 Slot: 26
	public override double ToDouble(long value) { }

	// RVA: 0x1F77950 Offset: 0x1F76B50 VA: 0x181F77950 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1F776A0 Offset: 0x1F768A0 VA: 0x181F776A0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1F78080 Offset: 0x1F77280 VA: 0x181F78080 Slot: 10
	public override int ToInt32(bool value) { }

	// RVA: 0x1F77CD0 Offset: 0x1F76ED0 VA: 0x181F77CD0 Slot: 13
	public override int ToInt32(DateTime value) { }

	// RVA: 0x1F77F80 Offset: 0x1F77180 VA: 0x181F77F80 Slot: 12
	public override int ToInt32(double value) { }

	// RVA: 0x1F77E90 Offset: 0x1F77090 VA: 0x181F77E90 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x1F77C00 Offset: 0x1F76E00 VA: 0x181F77C00 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1F77DC0 Offset: 0x1F76FC0 VA: 0x181F77DC0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1F785F0 Offset: 0x1F777F0 VA: 0x181F785F0 Slot: 16
	public override long ToInt64(bool value) { }

	// RVA: 0x1F78260 Offset: 0x1F77460 VA: 0x181F78260 Slot: 19
	public override long ToInt64(DateTime value) { }

	// RVA: 0x1F78420 Offset: 0x1F77620 VA: 0x181F78420 Slot: 18
	public override long ToInt64(double value) { }

	// RVA: 0x1F78170 Offset: 0x1F77370 VA: 0x181F78170 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1F78350 Offset: 0x1F77550 VA: 0x181F78350 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1F78520 Offset: 0x1F77720 VA: 0x181F78520 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1F787B0 Offset: 0x1F779B0 VA: 0x181F787B0 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1F786E0 Offset: 0x1F778E0 VA: 0x181F786E0 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1F788B0 Offset: 0x1F77AB0 VA: 0x181F788B0 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1F790A0 Offset: 0x1F782A0 VA: 0x181F790A0 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1F78CE0 Offset: 0x1F77EE0 VA: 0x181F78CE0 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1F78A60 Offset: 0x1F77C60 VA: 0x181F78A60 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1F78C00 Offset: 0x1F77E00 VA: 0x181F78C00 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1F78DC0 Offset: 0x1F77FC0 VA: 0x181F78DC0 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1F78980 Offset: 0x1F77B80 VA: 0x181F78980 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1F78FA0 Offset: 0x1F781A0 VA: 0x181F78FA0 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1F78EB0 Offset: 0x1F780B0 VA: 0x181F78EB0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1F78B40 Offset: 0x1F77D40 VA: 0x181F78B40 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F79080 Offset: 0x1F78280 VA: 0x181F79080 Slot: 51
	public override string ToString(object value) { }

	// RVA: 0x1F73AD0 Offset: 0x1F72CD0 VA: 0x181F73AD0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1F73C50 Offset: 0x1F72E50 VA: 0x181F73C50 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1F739C0 Offset: 0x1F72BC0 VA: 0x181F739C0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1F73BD0 Offset: 0x1F72DD0 VA: 0x181F73BD0 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1F73A50 Offset: 0x1F72C50 VA: 0x181F73A50 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1F73B50 Offset: 0x1F72D50 VA: 0x181F73B50 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1F739A0 Offset: 0x1F72BA0 VA: 0x181F739A0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F73970 Offset: 0x1F72B70 VA: 0x181F73970 Slot: 60
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x1F79C00 Offset: 0x1F78E00 VA: 0x181F79C00
	protected string get_XmlTypeName() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	protected Type get_DefaultClrType() { }

	// RVA: 0x1F753A0 Offset: 0x1F745A0 VA: 0x181F753A0
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x1F73CD0 Offset: 0x1F72ED0 VA: 0x181F73CD0
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x1F75460 Offset: 0x1F74660 VA: 0x181F75460
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x1F73910 Offset: 0x1F72B10 VA: 0x181F73910 Slot: 62
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F75760 Offset: 0x1F74960 VA: 0x181F75760
	protected static byte[] StringToBase64Binary(string value) { }

	// RVA: 0x1F75980 Offset: 0x1F74B80 VA: 0x181F75980
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x1F75900 Offset: 0x1F74B00 VA: 0x181F75900
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x1F75A00 Offset: 0x1F74C00 VA: 0x181F75A00
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x1F75A70 Offset: 0x1F74C70 VA: 0x181F75A70
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x1F75B60 Offset: 0x1F74D60 VA: 0x181F75B60
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x1F75D80 Offset: 0x1F74F80 VA: 0x181F75D80
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x1F75C70 Offset: 0x1F74E70 VA: 0x181F75C70
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x1F75FA0 Offset: 0x1F751A0 VA: 0x181F75FA0
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x1F75E90 Offset: 0x1F75090 VA: 0x181F75E90
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x1F757E0 Offset: 0x1F749E0 VA: 0x181F757E0
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x1F75870 Offset: 0x1F74A70 VA: 0x181F75870
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x1F75AD0 Offset: 0x1F74CD0 VA: 0x181F75AD0
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x1F75CF0 Offset: 0x1F74EF0 VA: 0x181F75CF0
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x1F75BE0 Offset: 0x1F74DE0 VA: 0x181F75BE0
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x1F75F10 Offset: 0x1F75110 VA: 0x181F75F10
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x1F75E00 Offset: 0x1F75000 VA: 0x181F75E00
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x1F76020 Offset: 0x1F75220 VA: 0x181F76020
	protected static byte[] StringToHexBinary(string value) { }

	// RVA: 0x1F760F0 Offset: 0x1F752F0 VA: 0x181F760F0
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F76460 Offset: 0x1F75660 VA: 0x181F76460
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x1F763D0 Offset: 0x1F755D0 VA: 0x181F763D0
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x1F764E0 Offset: 0x1F756E0 VA: 0x181F764E0
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x1F738A0 Offset: 0x1F72AA0 VA: 0x181F738A0
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x1F738C0 Offset: 0x1F72AC0 VA: 0x181F738C0
	protected static string Base64BinaryToString(byte[] value) { }

	// RVA: 0x1F74170 Offset: 0x1F73370 VA: 0x181F74170
	protected static string DateToString(DateTime value) { }

	// RVA: 0x1F740F0 Offset: 0x1F732F0 VA: 0x181F740F0
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x1F741F0 Offset: 0x1F733F0 VA: 0x181F741F0
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x1F74840 Offset: 0x1F73A40 VA: 0x181F74840
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x1F74920 Offset: 0x1F73B20 VA: 0x181F74920
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x1F74B20 Offset: 0x1F73D20 VA: 0x181F74B20
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x1F74A20 Offset: 0x1F73C20 VA: 0x181F74A20
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x1F74D20 Offset: 0x1F73F20 VA: 0x181F74D20
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x1F74C20 Offset: 0x1F73E20 VA: 0x181F74C20
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x1F73FA0 Offset: 0x1F731A0 VA: 0x181F73FA0
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1F74070 Offset: 0x1F73270 VA: 0x181F74070
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1F748A0 Offset: 0x1F73AA0 VA: 0x181F748A0
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1F74AA0 Offset: 0x1F73CA0 VA: 0x181F74AA0
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1F749A0 Offset: 0x1F73BA0 VA: 0x181F749A0
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1F74CA0 Offset: 0x1F73EA0 VA: 0x181F74CA0
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1F74BA0 Offset: 0x1F73DA0 VA: 0x181F74BA0
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1F75580 Offset: 0x1F74780 VA: 0x181F75580
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F765D0 Offset: 0x1F757D0 VA: 0x181F765D0
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x1F76550 Offset: 0x1F75750 VA: 0x181F76550
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1F79290 Offset: 0x1F78490 VA: 0x181F79290
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x1F74020 Offset: 0x1F73220 VA: 0x181F74020
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x1F74260 Offset: 0x1F73460 VA: 0x181F74260
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x1F74450 Offset: 0x1F73650 VA: 0x181F74450
	protected static long DecimalToInt64(Decimal value) { }

	// RVA: 0x1F74650 Offset: 0x1F73850 VA: 0x181F74650
	protected static ulong DecimalToUInt64(Decimal value) { }

	// RVA: 0x1F74DA0 Offset: 0x1F73FA0 VA: 0x181F74DA0
	protected static byte Int32ToByte(int value) { }

	// RVA: 0x1F74EA0 Offset: 0x1F740A0 VA: 0x181F74EA0
	protected static short Int32ToInt16(int value) { }

	// RVA: 0x1F74FA0 Offset: 0x1F741A0 VA: 0x181F74FA0
	protected static sbyte Int32ToSByte(int value) { }

	// RVA: 0x1F750A0 Offset: 0x1F742A0 VA: 0x181F750A0
	protected static ushort Int32ToUInt16(int value) { }

	// RVA: 0x1F751A0 Offset: 0x1F743A0 VA: 0x181F751A0
	protected static int Int64ToInt32(long value) { }

	// RVA: 0x1F752A0 Offset: 0x1F744A0 VA: 0x181F752A0
	protected static uint Int64ToUInt32(long value) { }

	// RVA: 0x1F79210 Offset: 0x1F78410 VA: 0x181F79210
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x1F79180 Offset: 0x1F78380 VA: 0x181F79180
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x1F79300 Offset: 0x1F78500 VA: 0x181F79300
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlNumeric10Converter : XmlBaseConverter // TypeDefIndex: 12481
{
	// Methods

	// RVA: 0x1FA0EE0 Offset: 0x1FA00E0 VA: 0x181FA0EE0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1F9F770 Offset: 0x1F9E970 VA: 0x181F9F770
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1F9FCD0 Offset: 0x1F9EED0 VA: 0x181F9FCD0 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1F9F800 Offset: 0x1F9EA00 VA: 0x181F9F800 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1F9FDC0 Offset: 0x1F9EFC0 VA: 0x181F9FDC0 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x1F9FE10 Offset: 0x1F9F010 VA: 0x181F9FE10 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1F9FF30 Offset: 0x1F9F130 VA: 0x181F9FF30 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1FA08F0 Offset: 0x1F9FAF0 VA: 0x181FA08F0 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1FA0390 Offset: 0x1F9F590 VA: 0x181FA0390 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1FA04B0 Offset: 0x1F9F6B0 VA: 0x181FA04B0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1FA0E00 Offset: 0x1FA0000 VA: 0x181FA0E00 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1FA0DB0 Offset: 0x1F9FFB0 VA: 0x181FA0DB0 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1FA0900 Offset: 0x1F9FB00 VA: 0x181FA0900 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1FA0950 Offset: 0x1F9FB50 VA: 0x181FA0950 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F9F2B0 Offset: 0x1F9E4B0 VA: 0x181F9F2B0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1F9EE70 Offset: 0x1F9E070 VA: 0x181F9EE70 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1F9E590 Offset: 0x1F9D790 VA: 0x181F9E590 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1F9E9F0 Offset: 0x1F9DBF0 VA: 0x181F9E9F0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F9D380 Offset: 0x1F9C580 VA: 0x181F9D380 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F9CA30 Offset: 0x1F9BC30 VA: 0x181F9CA30
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F9CEB0 Offset: 0x1F9C0B0 VA: 0x181F9CEB0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlNumeric2Converter : XmlBaseConverter // TypeDefIndex: 12482
{
	// Methods

	// RVA: 0x1FA2DD0 Offset: 0x1FA1FD0 VA: 0x181FA2DD0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1FA1F10 Offset: 0x1FA1110 VA: 0x181FA1F10
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1FA2340 Offset: 0x1FA1540 VA: 0x181FA2340 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1FA1FA0 Offset: 0x1FA11A0 VA: 0x181FA1FA0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1FA24E0 Offset: 0x1FA16E0 VA: 0x181FA24E0 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1FA2410 Offset: 0x1FA1610 VA: 0x181FA2410 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1FA24F0 Offset: 0x1FA16F0 VA: 0x181FA24F0 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1FA28F0 Offset: 0x1FA1AF0 VA: 0x181FA28F0 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1FA2D40 Offset: 0x1FA1F40 VA: 0x181FA2D40 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1FA29A0 Offset: 0x1FA1BA0 VA: 0x181FA29A0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1FA1B70 Offset: 0x1FA0D70 VA: 0x181FA1B70 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1FA0F40 Offset: 0x1FA0140 VA: 0x181FA0F40 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1FA1330 Offset: 0x1FA0530 VA: 0x181FA1330 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlDateTimeConverter : XmlBaseConverter // TypeDefIndex: 12483
{
	// Methods

	// RVA: 0x1F98900 Offset: 0x1F97B00 VA: 0x181F98900
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1F97470 Offset: 0x1F96670 VA: 0x181F97470
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1F97B50 Offset: 0x1F96D50 VA: 0x181F97B50 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1F97BB0 Offset: 0x1F96DB0 VA: 0x181F97BB0 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1F97DC0 Offset: 0x1F96FC0 VA: 0x181F97DC0 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1F978F0 Offset: 0x1F96AF0 VA: 0x181F978F0 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1F97920 Offset: 0x1F96B20 VA: 0x181F97920 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1F97500 Offset: 0x1F96700 VA: 0x181F97500 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1F98390 Offset: 0x1F97590 VA: 0x181F98390 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1F98180 Offset: 0x1F97380 VA: 0x181F98180 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1F98550 Offset: 0x1F97750 VA: 0x181F98550 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F970B0 Offset: 0x1F962B0 VA: 0x181F970B0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1F96400 Offset: 0x1F95600 VA: 0x181F96400 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F967F0 Offset: 0x1F959F0 VA: 0x181F967F0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlBooleanConverter : XmlBaseConverter // TypeDefIndex: 12484
{
	// Methods

	// RVA: 0x1F963A0 Offset: 0x1F955A0 VA: 0x181F963A0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1F95C00 Offset: 0x1F94E00 VA: 0x181F95C00
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1F95FA0 Offset: 0x1F951A0 VA: 0x181F95FA0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1F95C90 Offset: 0x1F94E90 VA: 0x181F95C90 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1F96350 Offset: 0x1F95550 VA: 0x181F96350 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1F96040 Offset: 0x1F95240 VA: 0x181F96040 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F94E80 Offset: 0x1F94080 VA: 0x181F94E80 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1F95890 Offset: 0x1F94A90 VA: 0x181F95890 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F951C0 Offset: 0x1F943C0 VA: 0x181F951C0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlMiscConverter : XmlBaseConverter // TypeDefIndex: 12485
{
	// Methods

	// RVA: 0x1F9C9D0 Offset: 0x1F9BBD0 VA: 0x181F9C9D0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1F9C300 Offset: 0x1F9B500 VA: 0x181F9C300
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1F9C390 Offset: 0x1F9B590 VA: 0x181F9C390 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F9AD70 Offset: 0x1F99F70 VA: 0x181F9AD70 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F9B3E0 Offset: 0x1F9A5E0 VA: 0x181F9B3E0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F9AA80 Offset: 0x1F99C80 VA: 0x181F9AA80
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F9ABD0 Offset: 0x1F99DD0 VA: 0x181F9ABD0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlStringConverter : XmlBaseConverter // TypeDefIndex: 12486
{
	// Methods

	// RVA: 0x1FA3900 Offset: 0x1FA2B00 VA: 0x181FA3900
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1FA3610 Offset: 0x1FA2810 VA: 0x181FA3610
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1FA36A0 Offset: 0x1FA28A0 VA: 0x181FA36A0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1FA2E30 Offset: 0x1FA2030 VA: 0x181FA2E30 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1FA3110 Offset: 0x1FA2310 VA: 0x181FA3110 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlUntypedConverter : XmlListConverter // TypeDefIndex: 12487
{
	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0x1FAAA80 Offset: 0x1FA9C80 VA: 0x181FAAA80
	protected void .ctor() { }

	// RVA: 0x1FAA990 Offset: 0x1FA9B90 VA: 0x181FAA990
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0x1FA8400 Offset: 0x1FA7600 VA: 0x181FA8400 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1FA8210 Offset: 0x1FA7410 VA: 0x181FA8210 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1FA8760 Offset: 0x1FA7960 VA: 0x181FA8760 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1FA8800 Offset: 0x1FA7A00 VA: 0x181FA8800 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1FA86A0 Offset: 0x1FA78A0 VA: 0x181FA86A0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1FA84A0 Offset: 0x1FA76A0 VA: 0x181FA84A0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1FA89E0 Offset: 0x1FA7BE0 VA: 0x181FA89E0 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1FA8AA0 Offset: 0x1FA7CA0 VA: 0x181FA8AA0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1FA8EA0 Offset: 0x1FA80A0 VA: 0x181FA8EA0 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1FA8CB0 Offset: 0x1FA7EB0 VA: 0x181FA8CB0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1FA8F40 Offset: 0x1FA8140 VA: 0x181FA8F40 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1FA8FE0 Offset: 0x1FA81E0 VA: 0x181FA8FE0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1FA93C0 Offset: 0x1FA85C0 VA: 0x181FA93C0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1FA91D0 Offset: 0x1FA83D0 VA: 0x181FA91D0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1FA9650 Offset: 0x1FA8850 VA: 0x181FA9650 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1FA9460 Offset: 0x1FA8660 VA: 0x181FA9460 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1FAA600 Offset: 0x1FA9800 VA: 0x181FAA600 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1FAA790 Offset: 0x1FA9990 VA: 0x181FAA790 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1FAA7E0 Offset: 0x1FA99E0 VA: 0x181FAA7E0 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1FA96F0 Offset: 0x1FA88F0 VA: 0x181FA96F0 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1FAA650 Offset: 0x1FA9850 VA: 0x181FAA650 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1FAA740 Offset: 0x1FA9940 VA: 0x181FAA740 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1FAA6F0 Offset: 0x1FA98F0 VA: 0x181FAA6F0 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1FAA6A0 Offset: 0x1FA98A0 VA: 0x181FAA6A0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1FA9750 Offset: 0x1FA8950 VA: 0x181FA9750 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1FA4BC0 Offset: 0x1FA3DC0 VA: 0x181FA4BC0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1FA5BD0 Offset: 0x1FA4DD0 VA: 0x181FA5BD0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1FA5FA0 Offset: 0x1FA51A0 VA: 0x181FA5FA0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1FA49D0 Offset: 0x1FA3BD0 VA: 0x181FA49D0 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1FA5DB0 Offset: 0x1FA4FB0 VA: 0x181FA5DB0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1FA47E0 Offset: 0x1FA39E0 VA: 0x181FA47E0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1FA4DB0 Offset: 0x1FA3FB0 VA: 0x181FA4DB0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1FA61A0 Offset: 0x1FA53A0 VA: 0x181FA61A0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1FA4500 Offset: 0x1FA3700 VA: 0x181FA4500
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1FA4650 Offset: 0x1FA3850 VA: 0x181FA4650
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1FA4190 Offset: 0x1FA3390 VA: 0x181FA4190 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1FA7BB0 Offset: 0x1FA6DB0 VA: 0x181FA7BB0
	private bool SupportsType(Type clrType) { }

	// RVA: 0x1FAA840 Offset: 0x1FA9A40 VA: 0x181FAA840
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlAnyConverter : XmlBaseConverter // TypeDefIndex: 12488
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x1F94900 Offset: 0x1F93B00 VA: 0x181F94900
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1F93730 Offset: 0x1F92930 VA: 0x181F93730 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1F93B60 Offset: 0x1F92D60 VA: 0x181F93B60 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1F93910 Offset: 0x1F92B10 VA: 0x181F93910 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1F93D40 Offset: 0x1F92F40 VA: 0x181F93D40 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1F93F90 Offset: 0x1F93190 VA: 0x181F93F90 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1F94170 Offset: 0x1F93370 VA: 0x181F94170 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1F94350 Offset: 0x1F93550 VA: 0x181F94350 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1F945D0 Offset: 0x1F937D0 VA: 0x181F945D0 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1F91410 Offset: 0x1F90610 VA: 0x181F91410 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1F91610 Offset: 0x1F90810 VA: 0x181F91610 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1F90DD0 Offset: 0x1F8FFD0 VA: 0x181F90DD0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1F93530 Offset: 0x1F92730 VA: 0x181F93530 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1F91810 Offset: 0x1F90A10 VA: 0x181F91810 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1F90FE0 Offset: 0x1F901E0 VA: 0x181F90FE0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1F911E0 Offset: 0x1F903E0 VA: 0x181F911E0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F91A10 Offset: 0x1F90C10 VA: 0x181F91A10 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F90AE0 Offset: 0x1F8FCE0 VA: 0x181F90AE0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F90C30 Offset: 0x1F8FE30 VA: 0x181F90C30
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F94530 Offset: 0x1F93730 VA: 0x181F94530
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x1F94810 Offset: 0x1F93A10 VA: 0x181F94810
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlAnyListConverter : XmlListConverter // TypeDefIndex: 12489
{
	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x1F94E20 Offset: 0x1F94020 VA: 0x181F94E20
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x1F94960 Offset: 0x1F93B60 VA: 0x181F94960 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F94C00 Offset: 0x1F93E00 VA: 0x181F94C00
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlListConverter : XmlBaseConverter // TypeDefIndex: 12490
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x1F94E20 Offset: 0x1F94020 VA: 0x181F94E20
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x1F9A9B0 Offset: 0x1F99BB0 VA: 0x181F9A9B0
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x1F9AA20 Offset: 0x1F99C20 VA: 0x181F9AA20
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1F99DF0 Offset: 0x1F98FF0 VA: 0x181F99DF0
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x1F999E0 Offset: 0x1F98BE0 VA: 0x181F999E0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F98960 Offset: 0x1F97B60 VA: 0x181F98960 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F99FD0 Offset: 0x1F991D0 VA: 0x181F99FD0
	private bool IsListType(Type type) { }

	// RVA: -1 Offset: -1
	private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA4DE0 Offset: 0xAA3FE0 VA: 0x180AA4DE0
	|-XmlListConverter.ToArray<bool>
	|-XmlListConverter.ToArray<byte>
	|-XmlListConverter.ToArray<sbyte>
	|
	|-RVA: 0xAA5920 Offset: 0xAA4B20 VA: 0x180AA5920
	|-XmlListConverter.ToArray<DateTime>
	|-XmlListConverter.ToArray<TimeSpan>
	|
	|-RVA: 0xAA5380 Offset: 0xAA4580 VA: 0x180AA5380
	|-XmlListConverter.ToArray<DateTimeOffset>
	|-XmlListConverter.ToArray<Decimal>
	|
	|-RVA: 0xAA5EC0 Offset: 0xAA50C0 VA: 0x180AA5EC0
	|-XmlListConverter.ToArray<double>
	|
	|-RVA: 0xAA6A00 Offset: 0xAA5C00 VA: 0x180AA6A00
	|-XmlListConverter.ToArray<short>
	|
	|-RVA: 0xAA6FA0 Offset: 0xAA61A0 VA: 0x180AA6FA0
	|-XmlListConverter.ToArray<int>
	|
	|-RVA: 0xAA7540 Offset: 0xAA6740 VA: 0x180AA7540
	|-XmlListConverter.ToArray<long>
	|-XmlListConverter.ToArray<ulong>
	|
	|-RVA: 0xAA7AE0 Offset: 0xAA6CE0 VA: 0x180AA7AE0
	|-XmlListConverter.ToArray<object>
	|
	|-RVA: 0xAA8090 Offset: 0xAA7290 VA: 0x180AA8090
	|-XmlListConverter.ToArray<float>
	|
	|-RVA: 0xAA8630 Offset: 0xAA7830 VA: 0x180AA8630
	|-XmlListConverter.ToArray<ushort>
	|
	|-RVA: 0xAA8BD0 Offset: 0xAA7DD0 VA: 0x180AA8BD0
	|-XmlListConverter.ToArray<uint>
	|
	|-RVA: 0xAA6460 Offset: 0xAA5660 VA: 0x180AA6460
	|-XmlListConverter.ToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1F9A4C0 Offset: 0x1F996C0 VA: 0x181F9A4C0
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F9A420 Offset: 0x1F99620 VA: 0x181F9A420
	private List<string> StringAsList(string value) { }

	// RVA: 0x1F9A180 Offset: 0x1F99380 VA: 0x181F9A180
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F99B20 Offset: 0x1F98D20 VA: 0x181F99B20
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }
}

// Namespace: System.Xml.Schema
internal class XmlUnionConverter : XmlBaseConverter // TypeDefIndex: 12491
{
	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0x1FA3E70 Offset: 0x1FA3070 VA: 0x181FA3E70
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1FA3E10 Offset: 0x1FA3010 VA: 0x181FA3E10
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1FA3960 Offset: 0x1FA2B60 VA: 0x181FA3960 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: 
private enum XsdBuilder.State // TypeDefIndex: 12492
{
	// Fields
	public int value__; // 0x0
	public const XsdBuilder.State Root = 0;
	public const XsdBuilder.State Schema = 1;
	public const XsdBuilder.State Annotation = 2;
	public const XsdBuilder.State Include = 3;
	public const XsdBuilder.State Import = 4;
	public const XsdBuilder.State Element = 5;
	public const XsdBuilder.State Attribute = 6;
	public const XsdBuilder.State AttributeGroup = 7;
	public const XsdBuilder.State AttributeGroupRef = 8;
	public const XsdBuilder.State AnyAttribute = 9;
	public const XsdBuilder.State Group = 10;
	public const XsdBuilder.State GroupRef = 11;
	public const XsdBuilder.State All = 12;
	public const XsdBuilder.State Choice = 13;
	public const XsdBuilder.State Sequence = 14;
	public const XsdBuilder.State Any = 15;
	public const XsdBuilder.State Notation = 16;
	public const XsdBuilder.State SimpleType = 17;
	public const XsdBuilder.State ComplexType = 18;
	public const XsdBuilder.State ComplexContent = 19;
	public const XsdBuilder.State ComplexContentRestriction = 20;
	public const XsdBuilder.State ComplexContentExtension = 21;
	public const XsdBuilder.State SimpleContent = 22;
	public const XsdBuilder.State SimpleContentExtension = 23;
	public const XsdBuilder.State SimpleContentRestriction = 24;
	public const XsdBuilder.State SimpleTypeUnion = 25;
	public const XsdBuilder.State SimpleTypeList = 26;
	public const XsdBuilder.State SimpleTypeRestriction = 27;
	public const XsdBuilder.State Unique = 28;
	public const XsdBuilder.State Key = 29;
	public const XsdBuilder.State KeyRef = 30;
	public const XsdBuilder.State Selector = 31;
	public const XsdBuilder.State Field = 32;
	public const XsdBuilder.State MinExclusive = 33;
	public const XsdBuilder.State MinInclusive = 34;
	public const XsdBuilder.State MaxExclusive = 35;
	public const XsdBuilder.State MaxInclusive = 36;
	public const XsdBuilder.State TotalDigits = 37;
	public const XsdBuilder.State FractionDigits = 38;
	public const XsdBuilder.State Length = 39;
	public const XsdBuilder.State MinLength = 40;
	public const XsdBuilder.State MaxLength = 41;
	public const XsdBuilder.State Enumeration = 42;
	public const XsdBuilder.State Pattern = 43;
	public const XsdBuilder.State WhiteSpace = 44;
	public const XsdBuilder.State AppInfo = 45;
	public const XsdBuilder.State Documentation = 46;
	public const XsdBuilder.State Redefine = 47;
}

// Namespace: 
private sealed class XsdBuilder.XsdBuildFunction : MulticastDelegate // TypeDefIndex: 12493
{
	// Methods

	// RVA: 0x1A446E0 Offset: 0x1A438E0 VA: 0x181A446E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(XsdBuilder builder, string value) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdInitFunction : MulticastDelegate // TypeDefIndex: 12494
{
	// Methods

	// RVA: 0x1A446E0 Offset: 0x1A438E0 VA: 0x181A446E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(XsdBuilder builder, string value) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdEndChildFunction : MulticastDelegate // TypeDefIndex: 12495
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(XsdBuilder builder) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdAttributeEntry // TypeDefIndex: 12496
{
	// Fields
	public SchemaNames.Token Attribute; // 0x10
	public XsdBuilder.XsdBuildFunction BuildFunc; // 0x18

	// Methods

	// RVA: 0x7B8500 Offset: 0x7B7700 VA: 0x1807B8500
	public void .ctor(SchemaNames.Token a, XsdBuilder.XsdBuildFunction build) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdEntry // TypeDefIndex: 12497
{
	// Fields
	public SchemaNames.Token Name; // 0x10
	public XsdBuilder.State CurrentState; // 0x14
	public XsdBuilder.State[] NextStates; // 0x18
	public XsdBuilder.XsdAttributeEntry[] Attributes; // 0x20
	public XsdBuilder.XsdInitFunction InitFunc; // 0x28
	public XsdBuilder.XsdEndChildFunction EndChildFunc; // 0x30
	public bool ParseContent; // 0x38

	// Methods

	// RVA: 0x1FCA3B0 Offset: 0x1FC95B0 VA: 0x181FCA3B0
	public void .ctor(SchemaNames.Token n, XsdBuilder.State state, XsdBuilder.State[] nextStates, XsdBuilder.XsdAttributeEntry[] attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent) { }
}

// Namespace: 
private class XsdBuilder.BuilderNamespaceManager : XmlNamespaceManager // TypeDefIndex: 12498
{
	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x1FB7CD0 Offset: 0x1FB6ED0 VA: 0x181FB7CD0
	public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x1FB7C60 Offset: 0x1FB6E60 VA: 0x181FB7C60 Slot: 16
	public override string LookupNamespace(string prefix) { }
}

// Namespace: System.Xml.Schema
internal sealed class XsdBuilder : SchemaBuilder // TypeDefIndex: 12499
{
	// Fields
	private static readonly XsdBuilder.State[] SchemaElement; // 0x0
	private static readonly XsdBuilder.State[] SchemaSubelements; // 0x8
	private static readonly XsdBuilder.State[] AttributeSubelements; // 0x10
	private static readonly XsdBuilder.State[] ElementSubelements; // 0x18
	private static readonly XsdBuilder.State[] ComplexTypeSubelements; // 0x20
	private static readonly XsdBuilder.State[] SimpleContentSubelements; // 0x28
	private static readonly XsdBuilder.State[] SimpleContentExtensionSubelements; // 0x30
	private static readonly XsdBuilder.State[] SimpleContentRestrictionSubelements; // 0x38
	private static readonly XsdBuilder.State[] ComplexContentSubelements; // 0x40
	private static readonly XsdBuilder.State[] ComplexContentExtensionSubelements; // 0x48
	private static readonly XsdBuilder.State[] ComplexContentRestrictionSubelements; // 0x50
	private static readonly XsdBuilder.State[] SimpleTypeSubelements; // 0x58
	private static readonly XsdBuilder.State[] SimpleTypeRestrictionSubelements; // 0x60
	private static readonly XsdBuilder.State[] SimpleTypeListSubelements; // 0x68
	private static readonly XsdBuilder.State[] SimpleTypeUnionSubelements; // 0x70
	private static readonly XsdBuilder.State[] RedefineSubelements; // 0x78
	private static readonly XsdBuilder.State[] AttributeGroupSubelements; // 0x80
	private static readonly XsdBuilder.State[] GroupSubelements; // 0x88
	private static readonly XsdBuilder.State[] AllSubelements; // 0x90
	private static readonly XsdBuilder.State[] ChoiceSequenceSubelements; // 0x98
	private static readonly XsdBuilder.State[] IdentityConstraintSubelements; // 0xA0
	private static readonly XsdBuilder.State[] AnnotationSubelements; // 0xA8
	private static readonly XsdBuilder.State[] AnnotatedSubelements; // 0xB0
	private static readonly XsdBuilder.XsdAttributeEntry[] SchemaAttributes; // 0xB8
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeAttributes; // 0xC0
	private static readonly XsdBuilder.XsdAttributeEntry[] ElementAttributes; // 0xC8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes; // 0xD0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes; // 0xD8
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes; // 0xE0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes; // 0xE8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes; // 0xF0
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes; // 0xF8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes; // 0x100
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes; // 0x108
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes; // 0x110
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes; // 0x118
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes; // 0x120
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes; // 0x128
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes; // 0x130
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupAttributes; // 0x138
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupRefAttributes; // 0x140
	private static readonly XsdBuilder.XsdAttributeEntry[] ParticleAttributes; // 0x148
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributes; // 0x150
	private static readonly XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes; // 0x158
	private static readonly XsdBuilder.XsdAttributeEntry[] SelectorAttributes; // 0x160
	private static readonly XsdBuilder.XsdAttributeEntry[] FieldAttributes; // 0x168
	private static readonly XsdBuilder.XsdAttributeEntry[] NotationAttributes; // 0x170
	private static readonly XsdBuilder.XsdAttributeEntry[] IncludeAttributes; // 0x178
	private static readonly XsdBuilder.XsdAttributeEntry[] ImportAttributes; // 0x180
	private static readonly XsdBuilder.XsdAttributeEntry[] FacetAttributes; // 0x188
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes; // 0x190
	private static readonly XsdBuilder.XsdAttributeEntry[] DocumentationAttributes; // 0x198
	private static readonly XsdBuilder.XsdAttributeEntry[] AppinfoAttributes; // 0x1A0
	private static readonly XsdBuilder.XsdAttributeEntry[] RedefineAttributes; // 0x1A8
	private static readonly XsdBuilder.XsdAttributeEntry[] AnnotationAttributes; // 0x1B0
	private static readonly XsdBuilder.XsdEntry[] SchemaEntries; // 0x1B8
	private static readonly int[] DerivationMethodValues; // 0x1C0
	private static readonly string[] DerivationMethodStrings; // 0x1C8
	private static readonly string[] FormStringValues; // 0x1D0
	private static readonly string[] UseStringValues; // 0x1D8
	private static readonly string[] ProcessContentsStringValues; // 0x1E0
	private XmlReader reader; // 0x10
	private PositionInfo positionInfo; // 0x18
	private XsdBuilder.XsdEntry currentEntry; // 0x20
	private XsdBuilder.XsdEntry nextEntry; // 0x28
	private bool hasChild; // 0x30
	private HWStack stateHistory; // 0x38
	private Stack containerStack; // 0x40
	private XmlNameTable nameTable; // 0x48
	private SchemaNames schemaNames; // 0x50
	private XmlNamespaceManager namespaceManager; // 0x58
	private bool canIncludeImport; // 0x60
	private XmlSchema schema; // 0x68
	private XmlSchemaObject xso; // 0x70
	private XmlSchemaElement element; // 0x78
	private XmlSchemaAny anyElement; // 0x80
	private XmlSchemaAttribute attribute; // 0x88
	private XmlSchemaAnyAttribute anyAttribute; // 0x90
	private XmlSchemaComplexType complexType; // 0x98
	private XmlSchemaSimpleType simpleType; // 0xA0
	private XmlSchemaComplexContent complexContent; // 0xA8
	private XmlSchemaComplexContentExtension complexContentExtension; // 0xB0
	private XmlSchemaComplexContentRestriction complexContentRestriction; // 0xB8
	private XmlSchemaSimpleContent simpleContent; // 0xC0
	private XmlSchemaSimpleContentExtension simpleContentExtension; // 0xC8
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; // 0xD0
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; // 0xD8
	private XmlSchemaSimpleTypeList simpleTypeList; // 0xE0
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; // 0xE8
	private XmlSchemaGroup group; // 0xF0
	private XmlSchemaGroupRef groupRef; // 0xF8
	private XmlSchemaAll all; // 0x100
	private XmlSchemaChoice choice; // 0x108
	private XmlSchemaSequence sequence; // 0x110
	private XmlSchemaParticle particle; // 0x118
	private XmlSchemaAttributeGroup attributeGroup; // 0x120
	private XmlSchemaAttributeGroupRef attributeGroupRef; // 0x128
	private XmlSchemaNotation notation; // 0x130
	private XmlSchemaIdentityConstraint identityConstraint; // 0x138
	private XmlSchemaXPath xpath; // 0x140
	private XmlSchemaInclude include; // 0x148
	private XmlSchemaImport import; // 0x150
	private XmlSchemaAnnotation annotation; // 0x158
	private XmlSchemaAppInfo appInfo; // 0x160
	private XmlSchemaDocumentation documentation; // 0x168
	private XmlSchemaFacet facet; // 0x170
	private XmlNode[] markup; // 0x178
	private XmlSchemaRedefine redefine; // 0x180
	private ValidationEventHandler validationEventHandler; // 0x188
	private ArrayList unhandledAttributes; // 0x190
	private Hashtable namespaces; // 0x198

	// Properties
	private SchemaNames.Token CurrentElement { get; }
	private SchemaNames.Token ParentElement { get; }
	private XmlSchemaObject ParentContainer { get; }

	// Methods

	// RVA: 0x1FB6600 Offset: 0x1FB5800 VA: 0x181FB6600
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x1FAFFC0 Offset: 0x1FAF1C0 VA: 0x181FAFFC0 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x1FAFAA0 Offset: 0x1FAECA0 VA: 0x181FAFAA0 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x1FAF450 Offset: 0x1FAE650 VA: 0x181FAF450 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x69D3C0 Offset: 0x69C5C0 VA: 0x18069D3C0 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x1FAFF70 Offset: 0x1FAF170 VA: 0x181FAFF70 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x1FB1340 Offset: 0x1FB0540 VA: 0x181FB1340 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x1FACE00 Offset: 0x1FAC000 VA: 0x181FACE00 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x1FB0190 Offset: 0x1FAF390 VA: 0x181FB0190
	private void Push() { }

	// RVA: 0x1FAF9C0 Offset: 0x1FAEBC0 VA: 0x181FAF9C0
	private void Pop() { }

	// RVA: 0x15B4C10 Offset: 0x15B3E10 VA: 0x1815B4C10
	private SchemaNames.Token get_CurrentElement() { }

	// RVA: 0x1FB6880 Offset: 0x1FB5A80 VA: 0x181FB6880
	private SchemaNames.Token get_ParentElement() { }

	// RVA: 0x1FB67D0 Offset: 0x1FB59D0 VA: 0x181FB67D0
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0x1FACF50 Offset: 0x1FAC150 VA: 0x181FACF50
	private XmlSchemaObject GetContainer(XsdBuilder.State state) { }

	// RVA: 0x1FB0A70 Offset: 0x1FAFC70 VA: 0x181FB0A70
	private void SetContainer(XsdBuilder.State state, object container) { }

	// RVA: 0x1FAB180 Offset: 0x1FAA380 VA: 0x181FAB180
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC6E0 Offset: 0x1FAB8E0 VA: 0x181FAC6E0
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC800 Offset: 0x1FABA00 VA: 0x181FAC800
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC920 Offset: 0x1FABB20 VA: 0x181FAC920
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC950 Offset: 0x1FABB50 VA: 0x181FAC950
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC8B0 Offset: 0x1FABAB0 VA: 0x181FAC8B0
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC790 Offset: 0x1FAB990 VA: 0x181FAC790
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1FAEA90 Offset: 0x1FADC90 VA: 0x181FAEA90
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0x1FAE8A0 Offset: 0x1FADAA0 VA: 0x181FAE8A0
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC590 Offset: 0x1FAB790 VA: 0x181FAC590
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x1FAE7F0 Offset: 0x1FAD9F0 VA: 0x181FAE7F0
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC530 Offset: 0x1FAB730 VA: 0x181FAC530
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC560 Offset: 0x1FAB760 VA: 0x181FAC560
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x1FAE9E0 Offset: 0x1FADBE0 VA: 0x181FAE9E0
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC6B0 Offset: 0x1FAB8B0 VA: 0x181FAC6B0
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x1FACF30 Offset: 0x1FAC130 VA: 0x181FACF30
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0x1FAD9F0 Offset: 0x1FACBF0 VA: 0x181FAD9F0
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB4A0 Offset: 0x1FAA6A0 VA: 0x181FAB4A0
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB4D0 Offset: 0x1FAA6D0 VA: 0x181FAB4D0
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB500 Offset: 0x1FAA700 VA: 0x181FAB500
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB6E0 Offset: 0x1FAA8E0 VA: 0x181FAB6E0
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB5E0 Offset: 0x1FAA7E0 VA: 0x181FAB5E0
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB5B0 Offset: 0x1FAA7B0 VA: 0x181FAB5B0
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB660 Offset: 0x1FAA860 VA: 0x181FAB660
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0x1FADFF0 Offset: 0x1FAD1F0 VA: 0x181FADFF0
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0x1FABCB0 Offset: 0x1FAAEB0 VA: 0x181FABCB0
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x1FABD30 Offset: 0x1FAAF30 VA: 0x181FABD30
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0x1FABDA0 Offset: 0x1FAAFA0 VA: 0x181FABDA0
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0x1FABE70 Offset: 0x1FAB070 VA: 0x181FABE70
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC0B0 Offset: 0x1FAB2B0 VA: 0x181FAC0B0
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1FABDD0 Offset: 0x1FAAFD0 VA: 0x181FABDD0
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1FABE40 Offset: 0x1FAB040 VA: 0x181FABE40
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1FABF20 Offset: 0x1FAB120 VA: 0x181FABF20
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1FABF50 Offset: 0x1FAB150 VA: 0x181FABF50
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1FABF80 Offset: 0x1FAB180 VA: 0x181FABF80
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1FABFB0 Offset: 0x1FAB1B0 VA: 0x181FABFB0
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC030 Offset: 0x1FAB230 VA: 0x181FAC030
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC130 Offset: 0x1FAB330 VA: 0x181FAC130
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0x1FAF0E0 Offset: 0x1FAE2E0 VA: 0x181FAF0E0
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0x1FACDA0 Offset: 0x1FABFA0 VA: 0x181FACDA0
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1FACD30 Offset: 0x1FABF30 VA: 0x181FACD30
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1FAF030 Offset: 0x1FAE230 VA: 0x181FAF030
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0x1FACB80 Offset: 0x1FABD80 VA: 0x181FACB80
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0x1FAEED0 Offset: 0x1FAE0D0 VA: 0x181FAEED0
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0x1FACA80 Offset: 0x1FABC80 VA: 0x181FACA80
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0x1FAEF80 Offset: 0x1FAE180 VA: 0x181FAEF80
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1FACB00 Offset: 0x1FABD00 VA: 0x181FACB00
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1FADDC0 Offset: 0x1FACFC0 VA: 0x181FADDC0
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB910 Offset: 0x1FAAB10 VA: 0x181FAB910
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB990 Offset: 0x1FAAB90 VA: 0x181FAB990
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0x1FABA10 Offset: 0x1FAAC10 VA: 0x181FABA10
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1FABA80 Offset: 0x1FAAC80 VA: 0x181FABA80
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x1FABB10 Offset: 0x1FAAD10 VA: 0x181FABB10
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1FADCB0 Offset: 0x1FACEB0 VA: 0x181FADCB0
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB890 Offset: 0x1FAAA90 VA: 0x181FAB890
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x1FADB30 Offset: 0x1FACD30 VA: 0x181FADB30
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB790 Offset: 0x1FAA990 VA: 0x181FAB790
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1FADC20 Offset: 0x1FACE20 VA: 0x181FADC20
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB810 Offset: 0x1FAAA10 VA: 0x181FAB810
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1FAEDC0 Offset: 0x1FADFC0 VA: 0x181FAEDC0
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0x1FAEBE0 Offset: 0x1FADDE0 VA: 0x181FAEBE0
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC980 Offset: 0x1FABB80 VA: 0x181FAC980
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1FAECD0 Offset: 0x1FADED0 VA: 0x181FAECD0
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1FACA00 Offset: 0x1FABC00 VA: 0x181FACA00
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1FAD930 Offset: 0x1FACB30 VA: 0x181FAD930
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB470 Offset: 0x1FAA670 VA: 0x181FAB470
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1FAD8C0 Offset: 0x1FACAC0 VA: 0x181FAD8C0
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB3F0 Offset: 0x1FAA5F0 VA: 0x181FAB3F0
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1FAD4C0 Offset: 0x1FAC6C0 VA: 0x181FAD4C0
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB1B0 Offset: 0x1FAA3B0 VA: 0x181FAB1B0
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB1E0 Offset: 0x1FAA3E0 VA: 0x181FAB1E0
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x1FAE5F0 Offset: 0x1FAD7F0 VA: 0x181FAE5F0
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC320 Offset: 0x1FAB520 VA: 0x181FAC320
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1FAE570 Offset: 0x1FAD770 VA: 0x181FAE570
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC650 Offset: 0x1FAB850 VA: 0x181FAC650
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC680 Offset: 0x1FAB880 VA: 0x181FAC680
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC2A0 Offset: 0x1FAB4A0 VA: 0x181FAC2A0
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1FAD360 Offset: 0x1FAC560 VA: 0x181FAD360
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0x1FADAB0 Offset: 0x1FACCB0 VA: 0x181FADAB0
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0x1FAEB60 Offset: 0x1FADD60 VA: 0x181FAEB60
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0x1FAD790 Offset: 0x1FAC990 VA: 0x181FAD790
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB290 Offset: 0x1FAA490 VA: 0x181FAB290
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB2C0 Offset: 0x1FAA4C0 VA: 0x181FAB2C0
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x1FAE950 Offset: 0x1FADB50 VA: 0x181FAE950
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC5C0 Offset: 0x1FAB7C0 VA: 0x181FAC5C0
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC5F0 Offset: 0x1FAB7F0 VA: 0x181FAC5F0
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC620 Offset: 0x1FAB820 VA: 0x181FAC620
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0x1FAE0F0 Offset: 0x1FAD2F0 VA: 0x181FAE0F0
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC1B0 Offset: 0x1FAB3B0 VA: 0x181FAC1B0
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC240 Offset: 0x1FAB440 VA: 0x181FAC240
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0x1FAE6A0 Offset: 0x1FAD8A0 VA: 0x181FAE6A0
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC350 Offset: 0x1FAB550 VA: 0x181FAC350
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC380 Offset: 0x1FAB580 VA: 0x181FAC380
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0x1FAEAB0 Offset: 0x1FADCB0 VA: 0x181FAEAB0
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC270 Offset: 0x1FAB470 VA: 0x181FAC270
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x1FAE4B0 Offset: 0x1FAD6B0 VA: 0x181FAE4B0
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0x1FAC270 Offset: 0x1FAB470 VA: 0x181FAC270
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x1FAD3E0 Offset: 0x1FAC5E0 VA: 0x181FAD3E0
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0x1FAD810 Offset: 0x1FACA10 VA: 0x181FAD810
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0x1FAB380 Offset: 0x1FAA580 VA: 0x181FAB380
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0x1FACDD0 Offset: 0x1FABFD0 VA: 0x181FACDD0
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0x1FADF40 Offset: 0x1FAD140 VA: 0x181FADF40
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0x1FABB40 Offset: 0x1FAAD40 VA: 0x181FABB40
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0x1FABBB0 Offset: 0x1FAADB0 VA: 0x181FABBB0
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0x1FACF00 Offset: 0x1FAC100 VA: 0x181FACF00
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0x1FAAB50 Offset: 0x1FA9D50 VA: 0x181FAAB50
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0x1FAADC0 Offset: 0x1FA9FC0 VA: 0x181FAADC0
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1FAD1A0 Offset: 0x1FAC3A0 VA: 0x181FAD1A0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x1FAF470 Offset: 0x1FAE670 VA: 0x181FAF470
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x1FB12E0 Offset: 0x1FB04E0 VA: 0x181FB12E0
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x1FB1280 Offset: 0x1FB0480 VA: 0x181FB1280
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x1FAF740 Offset: 0x1FAE940 VA: 0x181FAF740
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0x1FAF7D0 Offset: 0x1FAE9D0 VA: 0x181FAF7D0
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0x1FAF8C0 Offset: 0x1FAEAC0 VA: 0x181FAF8C0
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0x1FAF4A0 Offset: 0x1FAE6A0 VA: 0x181FAF4A0
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	private static string ParseUriReference(string s) { }

	// RVA: 0x1FB05F0 Offset: 0x1FAF7F0 VA: 0x181FB05F0
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0x1FB0760 Offset: 0x1FAF960 VA: 0x181FB0760
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x1FB0950 Offset: 0x1FAFB50 VA: 0x181FB0950
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1FB0870 Offset: 0x1FAFA70 VA: 0x181FB0870
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1FB0520 Offset: 0x1FAF720 VA: 0x181FB0520
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1FB0460 Offset: 0x1FAF660 VA: 0x181FB0460
	private void RecordPosition() { }

	// RVA: 0x1FB1510 Offset: 0x1FB0710 VA: 0x181FB1510
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
[Flags]
internal enum XsdDateTimeFlags // TypeDefIndex: 12500
{
	// Fields
	public int value__; // 0x0
	public const XsdDateTimeFlags DateTime = 1;
	public const XsdDateTimeFlags Time = 2;
	public const XsdDateTimeFlags Date = 4;
	public const XsdDateTimeFlags GYearMonth = 8;
	public const XsdDateTimeFlags GYear = 16;
	public const XsdDateTimeFlags GMonthDay = 32;
	public const XsdDateTimeFlags GDay = 64;
	public const XsdDateTimeFlags GMonth = 128;
	public const XsdDateTimeFlags XdrDateTimeNoTz = 256;
	public const XsdDateTimeFlags XdrDateTime = 512;
	public const XsdDateTimeFlags XdrTimeNoTz = 1024;
	public const XsdDateTimeFlags AllXsd = 255;
}

// Namespace: 
private enum XsdDateTime.DateTimeTypeCode // TypeDefIndex: 12501
{
	// Fields
	public int value__; // 0x0
	public const XsdDateTime.DateTimeTypeCode DateTime = 0;
	public const XsdDateTime.DateTimeTypeCode Time = 1;
	public const XsdDateTime.DateTimeTypeCode Date = 2;
	public const XsdDateTime.DateTimeTypeCode GYearMonth = 3;
	public const XsdDateTime.DateTimeTypeCode GYear = 4;
	public const XsdDateTime.DateTimeTypeCode GMonthDay = 5;
	public const XsdDateTime.DateTimeTypeCode GDay = 6;
	public const XsdDateTime.DateTimeTypeCode GMonth = 7;
	public const XsdDateTime.DateTimeTypeCode XdrDateTime = 8;
}

// Namespace: 
private enum XsdDateTime.XsdDateTimeKind // TypeDefIndex: 12502
{
	// Fields
	public int value__; // 0x0
	public const XsdDateTime.XsdDateTimeKind Unspecified = 0;
	public const XsdDateTime.XsdDateTimeKind Zulu = 1;
	public const XsdDateTime.XsdDateTimeKind LocalWestOfZulu = 2;
	public const XsdDateTime.XsdDateTimeKind LocalEastOfZulu = 3;
}

// Namespace: 
private struct XsdDateTime.Parser // TypeDefIndex: 12503
{
	// Fields
	public XsdDateTime.DateTimeTypeCode typeCode; // 0x0
	public int year; // 0x4
	public int month; // 0x8
	public int day; // 0xC
	public int hour; // 0x10
	public int minute; // 0x14
	public int second; // 0x18
	public int fraction; // 0x1C
	public XsdDateTime.XsdDateTimeKind kind; // 0x20
	public int zoneHour; // 0x24
	public int zoneMinute; // 0x28
	private string text; // 0x30
	private int length; // 0x38
	private static int[] Power10; // 0x0

	// Methods

	// RVA: 0x1FC3C50 Offset: 0x1FC2E50 VA: 0x181FC3C50
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1FC3210 Offset: 0x1FC2410 VA: 0x181FC3210
	private bool ParseDate(int start) { }

	// RVA: 0x1FC3540 Offset: 0x1FC2740 VA: 0x181FC3540
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x1FC34D0 Offset: 0x1FC26D0 VA: 0x181FC34D0
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x1FC35D0 Offset: 0x1FC27D0 VA: 0x181FC35D0
	private bool ParseTime(ref int start) { }

	// RVA: 0x1FC39B0 Offset: 0x1FC2BB0 VA: 0x181FC39B0
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x1FC30E0 Offset: 0x1FC22E0 VA: 0x181FC30E0
	private bool Parse4Dig(int start, ref int num) { }

	// RVA: 0x1FC3050 Offset: 0x1FC2250 VA: 0x181FC3050
	private bool Parse2Dig(int start, ref int num) { }

	// RVA: 0x1FC31D0 Offset: 0x1FC23D0 VA: 0x181FC31D0
	private bool ParseChar(int start, char ch) { }

	// RVA: 0x84A0D0 Offset: 0x8492D0 VA: 0x18084A0D0
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x1FC4C60 Offset: 0x1FC3E60 VA: 0x181FC4C60
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal struct XsdDateTime // TypeDefIndex: 12504
{
	// Fields
	private DateTime dt; // 0x0
	private uint extra; // 0x8
	private static readonly int Lzyyyy; // 0x0
	private static readonly int Lzyyyy_; // 0x4
	private static readonly int Lzyyyy_MM; // 0x8
	private static readonly int Lzyyyy_MM_; // 0xC
	private static readonly int Lzyyyy_MM_dd; // 0x10
	private static readonly int Lzyyyy_MM_ddT; // 0x14
	private static readonly int LzHH; // 0x18
	private static readonly int LzHH_; // 0x1C
	private static readonly int LzHH_mm; // 0x20
	private static readonly int LzHH_mm_; // 0x24
	private static readonly int LzHH_mm_ss; // 0x28
	private static readonly int Lz_; // 0x2C
	private static readonly int Lz_zz; // 0x30
	private static readonly int Lz_zz_; // 0x34
	private static readonly int Lz_zz_zz; // 0x38
	private static readonly int Lz__; // 0x3C
	private static readonly int Lz__mm; // 0x40
	private static readonly int Lz__mm_; // 0x44
	private static readonly int Lz__mm__; // 0x48
	private static readonly int Lz__mm_dd; // 0x4C
	private static readonly int Lz___; // 0x50
	private static readonly int Lz___dd; // 0x54
	private static readonly XmlTypeCode[] typeCodes; // 0x58

	// Properties
	private XsdDateTime.DateTimeTypeCode InternalTypeCode { get; }
	private XsdDateTime.XsdDateTimeKind InternalKind { get; }
	public int Year { get; }
	public int Month { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Minute { get; }
	public int Second { get; }
	public int Fraction { get; }
	public int ZoneHour { get; }
	public int ZoneMinute { get; }

	// Methods

	// RVA: 0x1FC73F0 Offset: 0x1FC65F0 VA: 0x181FC73F0
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1FC75E0 Offset: 0x1FC67E0 VA: 0x181FC75E0
	private void .ctor(XsdDateTime.Parser parser) { }

	// RVA: 0x1FC59B0 Offset: 0x1FC4BB0 VA: 0x181FC59B0
	private void InitiateXsdDateTime(XsdDateTime.Parser parser) { }

	// RVA: 0x1FC6CA0 Offset: 0x1FC5EA0 VA: 0x181FC6CA0
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0x1FC7670 Offset: 0x1FC6870 VA: 0x181FC7670
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x1FC7820 Offset: 0x1FC6A20 VA: 0x181FC7820
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x1FC7260 Offset: 0x1FC6460 VA: 0x181FC7260
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x1FC7A40 Offset: 0x1FC6C40 VA: 0x181FC7A40
	private XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x16ABF10 Offset: 0x16AB110 VA: 0x1816ABF10
	private XsdDateTime.XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x1FC7B40 Offset: 0x1FC6D40 VA: 0x181FC7B40
	public int get_Year() { }

	// RVA: 0x1FC7AA0 Offset: 0x1FC6CA0 VA: 0x181FC7AA0
	public int get_Month() { }

	// RVA: 0x1FC7890 Offset: 0x1FC6A90 VA: 0x181FC7890
	public int get_Day() { }

	// RVA: 0x1FC79F0 Offset: 0x1FC6BF0 VA: 0x181FC79F0
	public int get_Hour() { }

	// RVA: 0x1FC7A50 Offset: 0x1FC6C50 VA: 0x181FC7A50
	public int get_Minute() { }

	// RVA: 0x1FC7AF0 Offset: 0x1FC6CF0 VA: 0x181FC7AF0
	public int get_Second() { }

	// RVA: 0x1FC78E0 Offset: 0x1FC6AE0 VA: 0x181FC78E0
	public int get_Fraction() { }

	// RVA: 0x48F5B0 Offset: 0x48E7B0 VA: 0x18048F5B0
	public int get_ZoneHour() { }

	// RVA: 0x48F5C0 Offset: 0x48E7C0 VA: 0x18048F5C0
	public int get_ZoneMinute() { }

	// RVA: 0x1FC7B90 Offset: 0x1FC6D90 VA: 0x181FC7B90
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1FC81F0 Offset: 0x1FC73F0 VA: 0x181FC81F0
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1FC6690 Offset: 0x1FC5890 VA: 0x181FC6690 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FC5B90 Offset: 0x1FC4D90 VA: 0x181FC5B90
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x1FC5EA0 Offset: 0x1FC50A0 VA: 0x181FC5EA0
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x1FC62D0 Offset: 0x1FC54D0 VA: 0x181FC62D0
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x1FC5AE0 Offset: 0x1FC4CE0 VA: 0x181FC5AE0
	private void IntToCharArray(char[] text, int start, int value, int digits) { }

	// RVA: 0x1FC6610 Offset: 0x1FC5810 VA: 0x181FC6610
	private void ShortToCharArray(char[] text, int start, int value) { }

	// RVA: 0x1FC6DC0 Offset: 0x1FC5FC0 VA: 0x181FC6DC0
	private static void .cctor() { }
}

// Namespace: 
private enum XsdDuration.Parts // TypeDefIndex: 12505
{
	// Fields
	public int value__; // 0x0
	public const XsdDuration.Parts HasNone = 0;
	public const XsdDuration.Parts HasYears = 1;
	public const XsdDuration.Parts HasMonths = 2;
	public const XsdDuration.Parts HasDays = 4;
	public const XsdDuration.Parts HasHours = 8;
	public const XsdDuration.Parts HasMinutes = 16;
	public const XsdDuration.Parts HasSeconds = 32;
}

// Namespace: 
public enum XsdDuration.DurationType // TypeDefIndex: 12506
{
	// Fields
	public int value__; // 0x0
	public const XsdDuration.DurationType Duration = 0;
	public const XsdDuration.DurationType YearMonthDuration = 1;
	public const XsdDuration.DurationType DayTimeDuration = 2;
}

// Namespace: System.Xml.Schema
internal struct XsdDuration // TypeDefIndex: 12507
{
	// Fields
	private int years; // 0x0
	private int months; // 0x4
	private int days; // 0x8
	private int hours; // 0xC
	private int minutes; // 0x10
	private int seconds; // 0x14
	private uint nanoseconds; // 0x18

	// Properties
	public bool IsNegative { get; }
	public int Years { get; }
	public int Months { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public int Nanoseconds { get; }

	// Methods

	// RVA: 0x1FCA0F0 Offset: 0x1FC92F0 VA: 0x181FCA0F0
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x1FC9DC0 Offset: 0x1FC8FC0 VA: 0x181FC9DC0
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x1FC9DD0 Offset: 0x1FC8FD0 VA: 0x181FC9DD0
	public void .ctor(TimeSpan timeSpan, XsdDuration.DurationType durationType) { }

	// RVA: 0x1FCA380 Offset: 0x1FC9580 VA: 0x181FCA380
	public void .ctor(string s) { }

	// RVA: 0x1FCA040 Offset: 0x1FC9240 VA: 0x181FCA040
	public void .ctor(string s, XsdDuration.DurationType durationType) { }

	// RVA: 0x1FCA390 Offset: 0x1FC9590 VA: 0x181FCA390
	public bool get_IsNegative() { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_Years() { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_Months() { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_Days() { }

	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_Hours() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_Minutes() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_Seconds() { }

	// RVA: 0x1FCA3A0 Offset: 0x1FC95A0 VA: 0x181FCA3A0
	public int get_Nanoseconds() { }

	// RVA: 0x1FC8A10 Offset: 0x1FC7C10 VA: 0x181FC8A10
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x1FC8A60 Offset: 0x1FC7C60 VA: 0x181FC8A60
	public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType) { }

	// RVA: 0x1FC97A0 Offset: 0x1FC89A0 VA: 0x181FC97A0
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0x1FC97B0 Offset: 0x1FC89B0 VA: 0x181FC97B0
	internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result) { }

	// RVA: 0x1FC8610 Offset: 0x1FC7810 VA: 0x181FC8610 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FC8620 Offset: 0x1FC7820 VA: 0x181FC8620
	internal string ToString(XsdDuration.DurationType durationType) { }

	// RVA: 0x1FC8C00 Offset: 0x1FC7E00 VA: 0x181FC8C00
	internal static Exception TryParse(string s, out XsdDuration result) { }

	// RVA: 0x1FC8C10 Offset: 0x1FC7E10 VA: 0x181FC8C10
	internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result) { }

	// RVA: 0x1FC8AB0 Offset: 0x1FC7CB0 VA: 0x181FC8AB0
	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }
}

// Namespace: System.Xml.Schema
internal sealed class XsdValidator : BaseValidator // TypeDefIndex: 12508
{
	// Fields
	private int startIDConstraint; // 0x80
	private HWStack validationStack; // 0x88
	private Hashtable attPresence; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool bManageNamespaces; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8
	private XmlSchemaContentProcessing processContents; // 0xC0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x0
	private static readonly XmlSchemaDatatype dtQName; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsiSchemaLocation; // 0xF0
	private string XsiNoNamespaceSchemaLocation; // 0xF8
	private string XsdSchema; // 0x100

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }
	private bool HasIdentityConstraints { get; }

	// Methods

	// RVA: 0x1FCFDE0 Offset: 0x1FCEFE0 VA: 0x181FCFDE0
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1FCFDB0 Offset: 0x1FCEFB0 VA: 0x181FCFDB0
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1FCC3F0 Offset: 0x1FCB5F0 VA: 0x181FCC3F0
	private void Init() { }

	// RVA: 0x1FCFC30 Offset: 0x1FCEE30 VA: 0x181FCFC30 Slot: 5
	public override void Validate() { }

	// RVA: 0x1FCAD50 Offset: 0x1FC9F50 VA: 0x181FCAD50 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1F686E0 Offset: 0x1F678E0 VA: 0x181F686E0
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1FCD6F0 Offset: 0x1FCC8F0 VA: 0x181FCD6F0
	private void ProcessInlineSchema() { }

	// RVA: 0x1FCEC00 Offset: 0x1FCDE00 VA: 0x181FCEC00
	private void ValidateElement() { }

	// RVA: 0x1FCE990 Offset: 0x1FCDB90 VA: 0x181FCE990
	private object ValidateChildElement() { }

	// RVA: 0x1FCCF90 Offset: 0x1FCC190 VA: 0x181FCCF90
	private void ProcessElement(object particle) { }

	// RVA: 0x1FCDBC0 Offset: 0x1FCCDC0 VA: 0x181FCDBC0
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	// RVA: 0x1FCEDC0 Offset: 0x1FCDFC0 VA: 0x181FCEDC0
	private void ValidateEndElement() { }

	// RVA: 0x1FCC2E0 Offset: 0x1FCB4E0 VA: 0x181FCC2E0
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x1FCE4F0 Offset: 0x1FCD6F0 VA: 0x181FCE4F0
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x1FCF550 Offset: 0x1FCE750 VA: 0x181FCF550
	private void ValidateStartElement() { }

	// RVA: 0x1FCF0F0 Offset: 0x1FCE2F0 VA: 0x181FCF0F0
	private void ValidateEndStartElement() { }

	// RVA: 0x1FCC7B0 Offset: 0x1FCB9B0 VA: 0x181FCC7B0
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x1FCCCD0 Offset: 0x1FCBED0 VA: 0x181FCCCD0
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x1F686C0 Offset: 0x1F678C0 VA: 0x181F686C0
	private bool get_HasSchema() { }

	// RVA: 0x1F686F0 Offset: 0x1F678F0 VA: 0x181F686F0 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1FCD930 Offset: 0x1FCCB30 VA: 0x181FCD930
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1FCAE90 Offset: 0x1FCA090 VA: 0x181FCAE90
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1FCA420 Offset: 0x1FC9620 VA: 0x181FCA420
	internal void AddID(string name, object node) { }

	// RVA: 0x1F65CF0 Offset: 0x1F64EF0 VA: 0x181F65CF0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1FCC760 Offset: 0x1FCB960 VA: 0x181FCC760
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1FCE390 Offset: 0x1FCD590 VA: 0x181FCE390
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1FCCEA0 Offset: 0x1FCC0A0 VA: 0x181FCCEA0
	private void Pop() { }

	// RVA: 0x1FCAD50 Offset: 0x1FC9F50 VA: 0x181FCAD50
	private void CheckForwardRefs() { }

	// RVA: 0x1FCF4F0 Offset: 0x1FCE6F0 VA: 0x181FCF4F0
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x1FCFE10 Offset: 0x1FCF010 VA: 0x181FCFE10
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x1FCA4D0 Offset: 0x1FC96D0 VA: 0x181FCA4D0
	private void AddIdentityConstraints() { }

	// RVA: 0x1FCB300 Offset: 0x1FCA500 VA: 0x181FCB300
	private void ElementIdentityConstraints() { }

	// RVA: 0x1FCAA10 Offset: 0x1FC9C10 VA: 0x181FCAA10
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x1FCE910 Offset: 0x1FCDB10 VA: 0x181FCE910
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x1FCB6E0 Offset: 0x1FCA8E0 VA: 0x181FCB6E0
	private void EndElementIdentityConstraints() { }

	// RVA: 0x1FCFD10 Offset: 0x1FCEF10 VA: 0x181FCFD10
	private static void .cctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AbsoluteQuery : ContextQuery // TypeDefIndex: 12509
{
	// Methods

	// RVA: 0x1FB6A30 Offset: 0x1FB5C30 VA: 0x181FB6A30
	public void .ctor() { }

	// RVA: 0x1FB69F0 Offset: 0x1FB5BF0 VA: 0x181FB69F0
	private void .ctor(AbsoluteQuery other) { }

	// RVA: 0x1FB6970 Offset: 0x1FB5B70 VA: 0x181FB6970 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FB6900 Offset: 0x1FB5B00 VA: 0x181FB6900 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: 
public enum AstNode.AstType // TypeDefIndex: 12510
{
	// Fields
	public int value__; // 0x0
	public const AstNode.AstType Axis = 0;
	public const AstNode.AstType Operator = 1;
	public const AstNode.AstType Filter = 2;
	public const AstNode.AstType ConstantOperand = 3;
	public const AstNode.AstType Function = 4;
	public const AstNode.AstType Group = 5;
	public const AstNode.AstType Root = 6;
	public const AstNode.AstType Variable = 7;
	public const AstNode.AstType Error = 8;
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class AstNode // TypeDefIndex: 12511
{
	// Properties
	public abstract AstNode.AstType Type { get; }
	public abstract XPathResultType ReturnType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract AstNode.AstType get_Type();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XPathResultType get_ReturnType();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AttributeQuery : BaseAxisQuery // TypeDefIndex: 12512
{
	// Fields
	private bool _onAttribute; // 0x58

	// Methods

	// RVA: 0x1FB6CB0 Offset: 0x1FB5EB0 VA: 0x181FB6CB0
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1FB6C30 Offset: 0x1FB5E30 VA: 0x181FB6C30
	private void .ctor(AttributeQuery other) { }

	// RVA: 0x1FB6BF0 Offset: 0x1FB5DF0 VA: 0x181FB6BF0 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FB6A50 Offset: 0x1FB5C50 VA: 0x181FB6A50 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FB6B40 Offset: 0x1FB5D40 VA: 0x181FB6B40 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: 
public enum Axis.AxisType // TypeDefIndex: 12513
{
	// Fields
	public int value__; // 0x0
	public const Axis.AxisType Ancestor = 0;
	public const Axis.AxisType AncestorOrSelf = 1;
	public const Axis.AxisType Attribute = 2;
	public const Axis.AxisType Child = 3;
	public const Axis.AxisType Descendant = 4;
	public const Axis.AxisType DescendantOrSelf = 5;
	public const Axis.AxisType Following = 6;
	public const Axis.AxisType FollowingSibling = 7;
	public const Axis.AxisType Namespace = 8;
	public const Axis.AxisType Parent = 9;
	public const Axis.AxisType Preceding = 10;
	public const Axis.AxisType PrecedingSibling = 11;
	public const Axis.AxisType Self = 12;
	public const Axis.AxisType None = 13;
}

// Namespace: MS.Internal.Xml.XPath
internal class Axis : AstNode // TypeDefIndex: 12514
{
	// Fields
	private Axis.AxisType _axisType; // 0x10
	private AstNode _input; // 0x18
	private string _prefix; // 0x20
	private string _name; // 0x28
	private XPathNodeType _nodeType; // 0x30
	protected bool abbrAxis; // 0x34
	private string _urn; // 0x38

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; set; }
	public string Prefix { get; }
	public string Name { get; }
	public XPathNodeType NodeType { get; }
	public Axis.AxisType TypeOfAxis { get; }
	public bool AbbrAxis { get; }
	public string Urn { get; set; }

	// Methods

	// RVA: 0x1FB6D60 Offset: 0x1FB5F60 VA: 0x181FB6D60
	public void .ctor(Axis.AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x1FB6DF0 Offset: 0x1FB5FF0 VA: 0x181FB6DF0
	public void .ctor(Axis.AxisType axisType, AstNode input) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public AstNode get_Input() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Input(AstNode value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Prefix() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Name() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public XPathNodeType get_NodeType() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public Axis.AxisType get_TypeOfAxis() { }

	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	public bool get_AbbrAxis() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Urn() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Urn(string value) { }
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class BaseAxisQuery : Query // TypeDefIndex: 12515
{
	// Fields
	internal Query qyInput; // 0x18
	private bool _nameTest; // 0x20
	private string _name; // 0x28
	private string _prefix; // 0x30
	private string _nsUri; // 0x38
	private XPathNodeType _typeTest; // 0x40
	protected XPathNavigator currentNode; // 0x48
	protected int position; // 0x50

	// Properties
	protected string Name { get; }
	protected string Namespace { get; }
	protected bool NameTest { get; }
	protected XPathNodeType TypeTest { get; }
	public override int CurrentPosition { get; }
	public override XPathNavigator Current { get; }
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FB7040 Offset: 0x1FB6240 VA: 0x181FB7040
	protected void .ctor(Query qyInput) { }

	// RVA: 0x1FB6CB0 Offset: 0x1FB5EB0 VA: 0x181FB6CB0
	protected void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1FB6FD0 Offset: 0x1FB61D0 VA: 0x181FB6FD0
	protected void .ctor(BaseAxisQuery other) { }

	// RVA: 0x1FB6F20 Offset: 0x1FB6120 VA: 0x181FB6F20 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FB6F60 Offset: 0x1FB6160 VA: 0x181FB6F60 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	protected string get_Name() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	protected string get_Namespace() { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	protected bool get_NameTest() { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	protected XPathNodeType get_TypeTest() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x1FB70D0 Offset: 0x1FB62D0 VA: 0x181FB70D0 Slot: 18
	public virtual bool matches(XPathNavigator e) { }

	// RVA: 0x1FB6EC0 Offset: 0x1FB60C0 VA: 0x181FB6EC0 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 16
	public override XPathResultType get_StaticType() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class BooleanExpr : ValueQuery // TypeDefIndex: 12516
{
	// Fields
	private Query _opnd1; // 0x18
	private Query _opnd2; // 0x20
	private bool _isOr; // 0x28

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FB7430 Offset: 0x1FB6630 VA: 0x181FB7430
	public void .ctor(Operator.Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x1FB73D0 Offset: 0x1FB65D0 VA: 0x181FB73D0
	private void .ctor(BooleanExpr other) { }

	// RVA: 0x1FB7370 Offset: 0x1FB6570 VA: 0x181FB7370 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1FB72A0 Offset: 0x1FB64A0 VA: 0x181FB72A0 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FB7210 Offset: 0x1FB6410 VA: 0x181FB7210 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 16
	public override XPathResultType get_StaticType() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class BooleanFunctions : ValueQuery // TypeDefIndex: 12517
{
	// Fields
	private Query _arg; // 0x18
	private Function.FunctionType _funcType; // 0x20

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FB79D0 Offset: 0x1FB6BD0 VA: 0x181FB79D0
	public void .ctor(Function.FunctionType funcType, Query arg) { }

	// RVA: 0x1FB7980 Offset: 0x1FB6B80 VA: 0x181FB7980
	private void .ctor(BooleanFunctions other) { }

	// RVA: 0x1FB7960 Offset: 0x1FB6B60 VA: 0x181FB7960 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1FB75C0 Offset: 0x1FB67C0 VA: 0x181FB75C0 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FB7C20 Offset: 0x1FB6E20 VA: 0x181FB7C20
	internal static bool toBoolean(double number) { }

	// RVA: 0x1FB7A10 Offset: 0x1FB6C10 VA: 0x181FB7A10
	internal static bool toBoolean(string str) { }

	// RVA: 0x1FB7A30 Offset: 0x1FB6C30 VA: 0x181FB7A30
	internal bool toBoolean(XPathNodeIterator nodeIterator) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1FB78D0 Offset: 0x1FB6AD0 VA: 0x181FB78D0
	private bool Not(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FB77D0 Offset: 0x1FB69D0 VA: 0x181FB77D0
	private bool Lang(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FB7540 Offset: 0x1FB6740 VA: 0x181FB7540 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheAxisQuery : BaseAxisQuery // TypeDefIndex: 12518
{
	// Fields
	protected List<XPathNavigator> outputBuffer; // 0x58

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x1FB7F20 Offset: 0x1FB7120 VA: 0x181FB7F20
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1FB7E30 Offset: 0x1FB7030 VA: 0x181FB7E30
	protected void .ctor(CacheAxisQuery other) { }

	// RVA: 0x6CB260 Offset: 0x6CA460 VA: 0x1806CB260 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FB7D80 Offset: 0x1FB6F80 VA: 0x181FB7D80 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FB7D10 Offset: 0x1FB6F10 VA: 0x181FB7D10 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FB8060 Offset: 0x1FB7260 VA: 0x181FB8060 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x1FB8020 Offset: 0x1FB7220 VA: 0x181FB8020 Slot: 10
	public override int get_Count() { }

	// RVA: 0x1717A10 Offset: 0x1716C10 VA: 0x181717A10 Slot: 17
	public override QueryProps get_Properties() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class CacheChildrenQuery : ChildrenQuery // TypeDefIndex: 12519
{
	// Fields
	private XPathNavigator _nextInput; // 0x60
	private ClonableStack<XPathNavigator> _elementStk; // 0x68
	private ClonableStack<int> _positionStk; // 0x70
	private bool _needInput; // 0x78

	// Methods

	// RVA: 0x1FB8670 Offset: 0x1FB7870 VA: 0x181FB8670
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x1FB85C0 Offset: 0x1FB77C0 VA: 0x181FB85C0
	private void .ctor(CacheChildrenQuery other) { }

	// RVA: 0x1FB84C0 Offset: 0x1FB76C0 VA: 0x181FB84C0 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FB80C0 Offset: 0x1FB72C0 VA: 0x181FB80C0 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FB8330 Offset: 0x1FB7530 VA: 0x181FB8330
	private bool DecideNextNode() { }

	// RVA: 0x1FB8450 Offset: 0x1FB7650 VA: 0x181FB8450
	private XPathNavigator GetNextInput() { }

	// RVA: 0x1FB8260 Offset: 0x1FB7460 VA: 0x181FB8260 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheOutputQuery : Query // TypeDefIndex: 12520
{
	// Fields
	internal Query input; // 0x18
	protected List<XPathNavigator> outputBuffer; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override XPathResultType StaticType { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x1FB89A0 Offset: 0x1FB7BA0 VA: 0x181FB89A0
	public void .ctor(Query input) { }

	// RVA: 0x1FB88F0 Offset: 0x1FB7AF0 VA: 0x181FB88F0
	protected void .ctor(CacheOutputQuery other) { }

	// RVA: 0x6CB260 Offset: 0x6CA460 VA: 0x1806CB260 Slot: 12
	public override void Reset() { }

	// RVA: 0x16C5E30 Offset: 0x16C5030 VA: 0x1816C5E30 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1FB8860 Offset: 0x1FB7A60 VA: 0x181FB8860 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FB87F0 Offset: 0x1FB79F0 VA: 0x181FB87F0 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FB8A60 Offset: 0x1FB7C60 VA: 0x181FB8A60 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x1FB8A20 Offset: 0x1FB7C20 VA: 0x181FB8A20 Slot: 10
	public override int get_Count() { }

	// RVA: 0x1717A10 Offset: 0x1716C10 VA: 0x181717A10 Slot: 17
	public override QueryProps get_Properties() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class ChildrenQuery : BaseAxisQuery // TypeDefIndex: 12521
{
	// Fields
	private XPathNodeIterator _iterator; // 0x58

	// Methods

	// RVA: 0x1FB8E00 Offset: 0x1FB8000 VA: 0x181FB8E00
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x1FB8D30 Offset: 0x1FB7F30 VA: 0x181FB8D30
	protected void .ctor(ChildrenQuery other) { }

	// RVA: 0x1FB8CA0 Offset: 0x1FB7EA0 VA: 0x181FB8CA0 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FB8AC0 Offset: 0x1FB7CC0 VA: 0x181FB8AC0 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FB8C40 Offset: 0x1FB7E40 VA: 0x181FB8C40 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ClonableStack<T> : List<T> // TypeDefIndex: 12522
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07DA0 Offset: 0xF06FA0 VA: 0x180F07DA0
	|-ClonableStack<int>..ctor
	|-ClonableStack<object>..ctor
	|
	|-RVA: 0xF07E10 Offset: 0xF07010 VA: 0x180F07E10
	|-ClonableStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07D20 Offset: 0xF06F20 VA: 0x180F07D20
	|-ClonableStack<int>..ctor
	|
	|-RVA: 0xF07C20 Offset: 0xF06E20 VA: 0x180F07C20
	|-ClonableStack<object>..ctor
	|
	|-RVA: 0xF07CA0 Offset: 0xF06EA0 VA: 0x180F07CA0
	|-ClonableStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Push(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07BB0 Offset: 0xF06DB0 VA: 0x180F07BB0
	|-ClonableStack<int>.Push
	|
	|-RVA: 0xF07A60 Offset: 0xF06C60 VA: 0x180F07A60
	|-ClonableStack<object>.Push
	|
	|-RVA: 0xF07AD0 Offset: 0xF06CD0 VA: 0x180F07AD0
	|-ClonableStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF079E0 Offset: 0xF06BE0 VA: 0x180F079E0
	|-ClonableStack<int>.Pop
	|
	|-RVA: 0xF07850 Offset: 0xF06A50 VA: 0x180F07850
	|-ClonableStack<object>.Pop
	|
	|-RVA: 0xF078D0 Offset: 0xF06AD0 VA: 0x180F078D0
	|-ClonableStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07820 Offset: 0xF06A20 VA: 0x180F07820
	|-ClonableStack<int>.Peek
	|
	|-RVA: 0xF07700 Offset: 0xF06900 VA: 0x180F07700
	|-ClonableStack<object>.Peek
	|
	|-RVA: 0xF07730 Offset: 0xF06930 VA: 0x180F07730
	|-ClonableStack<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public ClonableStack<T> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07530 Offset: 0xF06730 VA: 0x180F07530
	|-ClonableStack<int>.Clone
	|
	|-RVA: 0xF075E0 Offset: 0xF067E0 VA: 0x180F075E0
	|-ClonableStack<object>.Clone
	|
	|-RVA: 0xF07690 Offset: 0xF06890 VA: 0x180F07690
	|-ClonableStack<__Il2CppFullySharedGenericType>.Clone
	*/
}

// Namespace: 
private class CompiledXpathExpr.UndefinedXsltContext : XsltContext // TypeDefIndex: 12523
{
	// Fields
	private IXmlNamespaceResolver _nsResolver; // 0x50

	// Properties
	public override string DefaultNamespace { get; }
	public override bool Whitespace { get; }

	// Methods

	// RVA: 0x1FC5940 Offset: 0x1FC4B40 VA: 0x181FC5940
	public void .ctor(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1FC5970 Offset: 0x1FC4B70 VA: 0x181FC5970 Slot: 9
	public override string get_DefaultNamespace() { }

	// RVA: 0x1FC5780 Offset: 0x1FC4980 VA: 0x181FC5780 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1FC5900 Offset: 0x1FC4B00 VA: 0x181FC5900 Slot: 18
	public override IXsltContextVariable ResolveVariable(string prefix, string name) { }

	// RVA: 0x1FC58C0 Offset: 0x1FC4AC0 VA: 0x181FC58C0 Slot: 19
	public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 20
	public override bool get_Whitespace() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 21
	public override bool PreserveWhitespace(XPathNavigator node) { }
}

// Namespace: MS.Internal.Xml.XPath
internal class CompiledXpathExpr : XPathExpression // TypeDefIndex: 12524
{
	// Fields
	private Query _query; // 0x10
	private string _expr; // 0x18
	private bool _needContext; // 0x20

	// Properties
	internal Query QueryTree { get; }

	// Methods

	// RVA: 0x833F00 Offset: 0x833100 VA: 0x180833F00
	internal void .ctor(Query query, string expression, bool needContext) { }

	// RVA: 0x1FB9050 Offset: 0x1FB8250 VA: 0x181FB9050
	internal Query get_QueryTree() { }

	// RVA: 0x1FB8F00 Offset: 0x1FB8100 VA: 0x181FB8F00 Slot: 4
	public override void SetContext(XmlNamespaceManager nsManager) { }

	// RVA: 0x1FB8F20 Offset: 0x1FB8120 VA: 0x181FB8F20 Slot: 5
	public override void SetContext(IXmlNamespaceResolver nsResolver) { }
}

// Namespace: MS.Internal.Xml.XPath
internal class ContextQuery : Query // TypeDefIndex: 12525
{
	// Fields
	protected XPathNavigator contextNode; // 0x18

	// Properties
	public override XPathNavigator Current { get; }
	public override XPathResultType StaticType { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x1FB6A30 Offset: 0x1FB5C30 VA: 0x181FB6A30
	public void .ctor() { }

	// RVA: 0x1FB69F0 Offset: 0x1FB5BF0 VA: 0x181FB69F0
	protected void .ctor(ContextQuery other) { }

	// RVA: 0x6CB260 Offset: 0x6CA460 VA: 0x1806CB260 Slot: 12
	public override void Reset() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x1FB9130 Offset: 0x1FB8330 VA: 0x181FB9130 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FB90A0 Offset: 0x1FB82A0 VA: 0x181FB90A0 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FB90C0 Offset: 0x1FB82C0 VA: 0x181FB90C0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 10
	public override int get_Count() { }

	// RVA: 0x1717A10 Offset: 0x1716C10 VA: 0x181717A10 Slot: 17
	public override QueryProps get_Properties() { }
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class DescendantBaseQuery : BaseAxisQuery // TypeDefIndex: 12526
{
	// Fields
	protected bool matchSelf; // 0x58
	protected bool abbrAxis; // 0x59

	// Methods

	// RVA: 0x1FB9180 Offset: 0x1FB8380 VA: 0x181FB9180
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x1FB9240 Offset: 0x1FB8440 VA: 0x181FB9240
	public void .ctor(DescendantBaseQuery other) { }
}

// Namespace: MS.Internal.Xml.XPath
internal class DescendantQuery : DescendantBaseQuery // TypeDefIndex: 12527
{
	// Fields
	private XPathNodeIterator _nodeIterator; // 0x60

	// Methods

	// RVA: 0x1FB9180 Offset: 0x1FB8380 VA: 0x181FB9180
	internal void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x1FB99D0 Offset: 0x1FB8BD0 VA: 0x181FB99D0
	public void .ctor(DescendantQuery other) { }

	// RVA: 0x1FB9990 Offset: 0x1FB8B90 VA: 0x181FB9990 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FB9740 Offset: 0x1FB8940 VA: 0x181FB9740 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FB98D0 Offset: 0x1FB8AD0 VA: 0x181FB98D0 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DescendantOverDescendantQuery : DescendantBaseQuery // TypeDefIndex: 12528
{
	// Fields
	private int _level; // 0x60

	// Methods

	// RVA: 0x1FB9680 Offset: 0x1FB8880 VA: 0x181FB9680
	public void .ctor(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis) { }

	// RVA: 0x1FB95F0 Offset: 0x1FB87F0 VA: 0x181FB95F0
	private void .ctor(DescendantOverDescendantQuery other) { }

	// RVA: 0x1FB95B0 Offset: 0x1FB87B0 VA: 0x181FB95B0 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FB92C0 Offset: 0x1FB84C0 VA: 0x181FB92C0 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FB9500 Offset: 0x1FB8700 VA: 0x181FB9500
	private bool MoveToFirstChild() { }

	// RVA: 0x1FB9540 Offset: 0x1FB8740 VA: 0x181FB9540
	private bool MoveUpUntilNext() { }

	// RVA: 0x1FB9440 Offset: 0x1FB8640 VA: 0x181FB9440 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DocumentOrderQuery : CacheOutputQuery // TypeDefIndex: 12529
{
	// Methods

	// RVA: 0x1FB9BB0 Offset: 0x1FB8DB0 VA: 0x181FB9BB0
	public void .ctor(Query qyParent) { }

	// RVA: 0x1FB88F0 Offset: 0x1FB7AF0 VA: 0x181FB88F0
	private void .ctor(DocumentOrderQuery other) { }

	// RVA: 0x1FB9B40 Offset: 0x1FB8D40 VA: 0x181FB9B40 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FB9A60 Offset: 0x1FB8C60 VA: 0x181FB9A60 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class EmptyQuery : Query // TypeDefIndex: 12530
{
	// Properties
	public override int CurrentPosition { get; }
	public override int Count { get; }
	public override QueryProps Properties { get; }
	public override XPathResultType StaticType { get; }
	public override XPathNavigator Current { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	public override int get_Count() { }

	// RVA: 0x1717A10 Offset: 0x1716C10 VA: 0x181717A10 Slot: 17
	public override QueryProps get_Properties() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public override void Reset() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x1FB9BC0 Offset: 0x1FB8DC0 VA: 0x181FB9BC0
	public void .ctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ExtensionQuery : Query // TypeDefIndex: 12531
{
	// Fields
	protected string prefix; // 0x18
	protected string name; // 0x20
	protected XsltContext xsltContext; // 0x28
	private ResetableIterator _queryIterator; // 0x30

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	protected string QName { get; }
	public override int Count { get; }
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FBA2B0 Offset: 0x1FB94B0 VA: 0x181FBA2B0
	public void .ctor(string prefix, string name) { }

	// RVA: 0x1FBA2F0 Offset: 0x1FB94F0 VA: 0x181FBA2F0
	protected void .ctor(ExtensionQuery other) { }

	// RVA: 0x1FBA290 Offset: 0x1FB9490 VA: 0x181FBA290 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FBA480 Offset: 0x1FB9680 VA: 0x181FBA480 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x1FB9BD0 Offset: 0x1FB8DD0 VA: 0x181FB9BD0 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FBA450 Offset: 0x1FB9650 VA: 0x181FBA450 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x1FB9C60 Offset: 0x1FB8E60 VA: 0x181FB9C60
	protected object ProcessResult(object value) { }

	// RVA: 0x1FBA520 Offset: 0x1FB9720 VA: 0x181FBA520
	protected string get_QName() { }

	// RVA: 0x1FBA420 Offset: 0x1FB9620 VA: 0x181FBA420 Slot: 10
	public override int get_Count() { }

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 16
	public override XPathResultType get_StaticType() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Filter : AstNode // TypeDefIndex: 12532
{
	// Fields
	private AstNode _input; // 0x10
	private AstNode _condition; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; }
	public AstNode Condition { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public AstNode get_Input() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public AstNode get_Condition() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FilterQuery : BaseAxisQuery // TypeDefIndex: 12533
{
	// Fields
	private Query _cond; // 0x58
	private bool _noPosition; // 0x60

	// Properties
	public Query Condition { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x1FBAA40 Offset: 0x1FB9C40 VA: 0x181FBAA40
	public void .ctor(Query qyParent, Query cond, bool noPosition) { }

	// RVA: 0x1FBAA80 Offset: 0x1FB9C80 VA: 0x181FBAA80
	private void .ctor(FilterQuery other) { }

	// RVA: 0x1FBA8C0 Offset: 0x1FB9AC0 VA: 0x181FBA8C0 Slot: 12
	public override void Reset() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Query get_Condition() { }

	// RVA: 0x1FBA920 Offset: 0x1FB9B20 VA: 0x181FBA920 Slot: 13
	public override void SetXsltContext(XsltContext input) { }

	// RVA: 0x1FBA580 Offset: 0x1FB9780 VA: 0x181FBA580 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FBA6A0 Offset: 0x1FB98A0 VA: 0x181FBA6A0
	internal bool EvaluatePredicate() { }

	// RVA: 0x1FBAB10 Offset: 0x1FB9D10 VA: 0x181FBAB10 Slot: 17
	public override QueryProps get_Properties() { }

	// RVA: 0x1FBA5E0 Offset: 0x1FB97E0 VA: 0x181FBA5E0 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FollSiblingQuery : BaseAxisQuery // TypeDefIndex: 12534
{
	// Fields
	private ClonableStack<XPathNavigator> _elementStk; // 0x58
	private List<XPathNavigator> _parentStk; // 0x60
	private XPathNavigator _nextInput; // 0x68

	// Methods

	// RVA: 0x1FBB320 Offset: 0x1FBA520 VA: 0x181FBB320
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x1FBB200 Offset: 0x1FBA400 VA: 0x181FBB200
	private void .ctor(FollSiblingQuery other) { }

	// RVA: 0x1FBAFD0 Offset: 0x1FBA1D0 VA: 0x181FBAFD0 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FBB080 Offset: 0x1FBA280 VA: 0x181FBB080
	private bool Visited(XPathNavigator nav) { }

	// RVA: 0x1FBAE40 Offset: 0x1FBA040 VA: 0x181FBAE40
	private XPathNavigator FetchInput() { }

	// RVA: 0x1FBAB50 Offset: 0x1FB9D50 VA: 0x181FBAB50 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FBAD00 Offset: 0x1FB9F00 VA: 0x181FBAD00 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FollowingQuery : BaseAxisQuery // TypeDefIndex: 12535
{
	// Fields
	private XPathNavigator _input; // 0x58
	private XPathNodeIterator _iterator; // 0x60

	// Methods

	// RVA: 0x1FB6CB0 Offset: 0x1FB5EB0 VA: 0x181FB6CB0
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1FBB7B0 Offset: 0x1FBA9B0 VA: 0x181FBB7B0
	private void .ctor(FollowingQuery other) { }

	// RVA: 0x1FB9990 Offset: 0x1FB8B90 VA: 0x181FB9990 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FBB460 Offset: 0x1FBA660 VA: 0x181FBB460 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FBB6F0 Offset: 0x1FBA8F0 VA: 0x181FBB6F0 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class ForwardPositionQuery : CacheOutputQuery // TypeDefIndex: 12536
{
	// Methods

	// RVA: 0x1FB9BB0 Offset: 0x1FB8DB0 VA: 0x181FB9BB0
	public void .ctor(Query input) { }

	// RVA: 0x1FB88F0 Offset: 0x1FB7AF0 VA: 0x181FB88F0
	protected void .ctor(ForwardPositionQuery other) { }

	// RVA: 0x1FBB920 Offset: 0x1FBAB20 VA: 0x181FBB920 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FBB840 Offset: 0x1FBAA40 VA: 0x181FBB840 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: 
public enum Function.FunctionType // TypeDefIndex: 12537
{
	// Fields
	public int value__; // 0x0
	public const Function.FunctionType FuncLast = 0;
	public const Function.FunctionType FuncPosition = 1;
	public const Function.FunctionType FuncCount = 2;
	public const Function.FunctionType FuncID = 3;
	public const Function.FunctionType FuncLocalName = 4;
	public const Function.FunctionType FuncNameSpaceUri = 5;
	public const Function.FunctionType FuncName = 6;
	public const Function.FunctionType FuncString = 7;
	public const Function.FunctionType FuncBoolean = 8;
	public const Function.FunctionType FuncNumber = 9;
	public const Function.FunctionType FuncTrue = 10;
	public const Function.FunctionType FuncFalse = 11;
	public const Function.FunctionType FuncNot = 12;
	public const Function.FunctionType FuncConcat = 13;
	public const Function.FunctionType FuncStartsWith = 14;
	public const Function.FunctionType FuncContains = 15;
	public const Function.FunctionType FuncSubstringBefore = 16;
	public const Function.FunctionType FuncSubstringAfter = 17;
	public const Function.FunctionType FuncSubstring = 18;
	public const Function.FunctionType FuncStringLength = 19;
	public const Function.FunctionType FuncNormalize = 20;
	public const Function.FunctionType FuncTranslate = 21;
	public const Function.FunctionType FuncLang = 22;
	public const Function.FunctionType FuncSum = 23;
	public const Function.FunctionType FuncFloor = 24;
	public const Function.FunctionType FuncCeiling = 25;
	public const Function.FunctionType FuncRound = 26;
	public const Function.FunctionType FuncUserDefined = 27;
}

// Namespace: MS.Internal.Xml.XPath
internal class Function : AstNode // TypeDefIndex: 12538
{
	// Fields
	private Function.FunctionType _functionType; // 0x10
	private List<AstNode> _argumentList; // 0x18
	private string _name; // 0x20
	private string _prefix; // 0x28
	internal static XPathResultType[] ReturnTypes; // 0x0

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public Function.FunctionType TypeOfFunction { get; }
	public List<AstNode> ArgumentList { get; }
	public string Prefix { get; }
	public string Name { get; }

	// Methods

	// RVA: 0x1FBC860 Offset: 0x1FBBA60 VA: 0x181FBC860
	public void .ctor(Function.FunctionType ftype, List<AstNode> argumentList) { }

	// RVA: 0x1FBC8F0 Offset: 0x1FBBAF0 VA: 0x181FBC8F0
	public void .ctor(string prefix, string name, List<AstNode> argumentList) { }

	// RVA: 0x1FBC770 Offset: 0x1FBB970 VA: 0x181FBC770
	public void .ctor(Function.FunctionType ftype, AstNode arg) { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1FBC990 Offset: 0x1FBBB90 VA: 0x181FBC990 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public Function.FunctionType get_TypeOfFunction() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public List<AstNode> get_ArgumentList() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Prefix() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Name() { }

	// RVA: 0x1FBC6F0 Offset: 0x1FBB8F0 VA: 0x181FBC6F0
	private static void .cctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FunctionQuery : ExtensionQuery // TypeDefIndex: 12539
{
	// Fields
	private IList<Query> _args; // 0x38
	private IXsltContextFunction _function; // 0x40

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FBC380 Offset: 0x1FBB580 VA: 0x181FBC380
	public void .ctor(string prefix, string name, List<Query> args) { }

	// RVA: 0x1FBC3D0 Offset: 0x1FBB5D0 VA: 0x181FBC3D0
	private void .ctor(FunctionQuery other) { }

	// RVA: 0x1FBBEF0 Offset: 0x1FBB0F0 VA: 0x181FBBEF0 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1FBBA80 Offset: 0x1FBAC80 VA: 0x181FBBA80 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FBC680 Offset: 0x1FBB880 VA: 0x181FBC680 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1FBBA20 Offset: 0x1FBAC20 VA: 0x181FBBA20 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Group : AstNode // TypeDefIndex: 12540
{
	// Fields
	private AstNode _groupNode; // 0x10

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode GroupNode { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(AstNode groupNode) { }

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public AstNode get_GroupNode() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class GroupQuery : BaseAxisQuery // TypeDefIndex: 12541
{
	// Properties
	public override XPathResultType StaticType { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x1FBCB00 Offset: 0x1FBBD00 VA: 0x181FBCB00
	public void .ctor(Query qy) { }

	// RVA: 0x1FB6FD0 Offset: 0x1FB61D0 VA: 0x181FB6FD0
	private void .ctor(GroupQuery other) { }

	// RVA: 0x1FBCA10 Offset: 0x1FBBC10 VA: 0x181FBCA10 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1E38600 Offset: 0x1E37800 VA: 0x181E38600 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FBCA50 Offset: 0x1FBBC50 VA: 0x181FBCA50 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x16C65A0 Offset: 0x16C57A0 VA: 0x1816C65A0 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 17
	public override QueryProps get_Properties() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class IDQuery : CacheOutputQuery // TypeDefIndex: 12542
{
	// Methods

	// RVA: 0x1FB9BB0 Offset: 0x1FB8DB0 VA: 0x181FB9BB0
	public void .ctor(Query arg) { }

	// RVA: 0x1FB88F0 Offset: 0x1FB7AF0 VA: 0x181FB88F0
	private void .ctor(IDQuery other) { }

	// RVA: 0x1FBCBF0 Offset: 0x1FBBDF0 VA: 0x181FBCBF0 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FBCFA0 Offset: 0x1FBC1A0 VA: 0x181FBCFA0
	private void ProcessIds(XPathNavigator contextNode, string val) { }

	// RVA: 0x1FBCB10 Offset: 0x1FBBD10 VA: 0x181FBCB10 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class IteratorFilter : XPathNodeIterator // TypeDefIndex: 12543
{
	// Fields
	private XPathNodeIterator _innerIterator; // 0x18
	private string _name; // 0x20
	private int _position; // 0x28

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }

	// Methods

	// RVA: 0x1FBD1B0 Offset: 0x1FBC3B0 VA: 0x181FBD1B0
	internal void .ctor(XPathNodeIterator innerIterator, string name) { }

	// RVA: 0x1FBD1F0 Offset: 0x1FBC3F0 VA: 0x181FBD1F0
	private void .ctor(IteratorFilter it) { }

	// RVA: 0x1FBD080 Offset: 0x1FBC280 VA: 0x181FBD080 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x16C38D0 Offset: 0x16C2AD0 VA: 0x1816C38D0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x1FBD110 Offset: 0x1FBC310 VA: 0x181FBD110 Slot: 7
	public override bool MoveNext() { }
}

// Namespace: 
private sealed class LogicalExpr.cmpXslt : MulticastDelegate // TypeDefIndex: 12544
{
	// Methods

	// RVA: 0x1FCFE20 Offset: 0x1FCF020 VA: 0x181FCFE20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual bool Invoke(Operator.Op op, object val1, object val2) { }
}

// Namespace: 
private struct LogicalExpr.NodeSet // TypeDefIndex: 12545
{
	// Fields
	private Query _opnd; // 0x0
	private XPathNavigator _current; // 0x8

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x1FC1EA0 Offset: 0x1FC10A0 VA: 0x181FC1EA0
	public void .ctor(object opnd) { }

	// RVA: 0x1FC1E30 Offset: 0x1FC1030 VA: 0x181FC1E30
	public bool MoveNext() { }

	// RVA: 0x1FC1E70 Offset: 0x1FC1070 VA: 0x181FC1E70
	public void Reset() { }

	// RVA: 0x1FC1F90 Offset: 0x1FC1190 VA: 0x181FC1F90
	public string get_Value() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class LogicalExpr : ValueQuery // TypeDefIndex: 12546
{
	// Fields
	private Operator.Op _op; // 0x18
	private Query _opnd1; // 0x20
	private Query _opnd2; // 0x28
	private static readonly LogicalExpr.cmpXslt[][] s_CompXsltE; // 0x0
	private static readonly LogicalExpr.cmpXslt[][] s_CompXsltO; // 0x8

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FBE9B0 Offset: 0x1FBDBB0 VA: 0x181FBE9B0
	public void .ctor(Operator.Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x1FBEA00 Offset: 0x1FBDC00 VA: 0x181FBEA00
	private void .ctor(LogicalExpr other) { }

	// RVA: 0x1FBD630 Offset: 0x1FBC830 VA: 0x181FBD630 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1FBD2E0 Offset: 0x1FBC4E0 VA: 0x181FBD2E0 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FBF9A0 Offset: 0x1FBEBA0 VA: 0x181FBF9A0
	private static bool cmpQueryQueryE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBFC40 Offset: 0x1FBEE40 VA: 0x181FBFC40
	private static bool cmpQueryQueryO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBF710 Offset: 0x1FBE910 VA: 0x181FBF710
	private static bool cmpQueryNumber(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC0020 Offset: 0x1FBF220 VA: 0x181FC0020
	private static bool cmpQueryStringE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC01E0 Offset: 0x1FBF3E0 VA: 0x181FC01E0
	private static bool cmpQueryStringO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC07F0 Offset: 0x1FBF9F0 VA: 0x181FC07F0
	private static bool cmpRtfQueryE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC09A0 Offset: 0x1FBFBA0 VA: 0x181FC09A0
	private static bool cmpRtfQueryO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBF360 Offset: 0x1FBE560 VA: 0x181FBF360
	private static bool cmpQueryBoolE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBF510 Offset: 0x1FBE710 VA: 0x181FBF510
	private static bool cmpQueryBoolO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBEA60 Offset: 0x1FBDC60 VA: 0x181FBEA60
	private static bool cmpBoolBoolE(Operator.Op op, bool n1, bool n2) { }

	// RVA: 0x1FBEA70 Offset: 0x1FBDC70 VA: 0x181FBEA70
	private static bool cmpBoolBoolE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBEB50 Offset: 0x1FBDD50 VA: 0x181FBEB50
	private static bool cmpBoolBoolO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBEC80 Offset: 0x1FBDE80 VA: 0x181FBEC80
	private static bool cmpBoolNumberE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBEDB0 Offset: 0x1FBDFB0 VA: 0x181FBEDB0
	private static bool cmpBoolNumberO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBEEF0 Offset: 0x1FBE0F0 VA: 0x181FBEEF0
	private static bool cmpBoolStringE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC0470 Offset: 0x1FBF670 VA: 0x181FC0470
	private static bool cmpRtfBoolE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBEFE0 Offset: 0x1FBE1E0 VA: 0x181FBEFE0
	private static bool cmpBoolStringO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC0540 Offset: 0x1FBF740 VA: 0x181FC0540
	private static bool cmpRtfBoolO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBF2F0 Offset: 0x1FBE4F0 VA: 0x181FBF2F0
	private static bool cmpNumberNumber(Operator.Op op, double n1, double n2) { }

	// RVA: 0x1FBF150 Offset: 0x1FBE350 VA: 0x181FBF150
	private static bool cmpNumberNumberO(Operator.Op op, double n1, double n2) { }

	// RVA: 0x1FBF190 Offset: 0x1FBE390 VA: 0x181FBF190
	private static bool cmpNumberNumber(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC0FD0 Offset: 0x1FC01D0 VA: 0x181FC0FD0
	private static bool cmpStringNumber(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC0680 Offset: 0x1FBF880 VA: 0x181FC0680
	private static bool cmpRtfNumber(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC1170 Offset: 0x1FC0370 VA: 0x181FC1170
	private static bool cmpStringStringE(Operator.Op op, string n1, string n2) { }

	// RVA: 0x1FC11A0 Offset: 0x1FC03A0 VA: 0x181FC11A0
	private static bool cmpStringStringE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC0DC0 Offset: 0x1FBFFC0 VA: 0x181FC0DC0
	private static bool cmpRtfStringE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC0C00 Offset: 0x1FBFE00 VA: 0x181FC0C00
	private static bool cmpRtfRtfE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC1280 Offset: 0x1FC0480 VA: 0x181FC1280
	private static bool cmpStringStringO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC0E70 Offset: 0x1FC0070 VA: 0x181FC0E70
	private static bool cmpRtfStringO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FC0C90 Offset: 0x1FBFE90 VA: 0x181FC0C90
	private static bool cmpRtfRtfO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x1FBD250 Offset: 0x1FBC450 VA: 0x181FBD250 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FBD550 Offset: 0x1FBC750 VA: 0x181FBD550
	private static string Rtf(object o) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1FBD690 Offset: 0x1FBC890 VA: 0x181FBD690
	private static void .cctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class MergeFilterQuery : CacheOutputQuery // TypeDefIndex: 12547
{
	// Fields
	private Query _child; // 0x28

	// Methods

	// RVA: 0x1FC1620 Offset: 0x1FC0820 VA: 0x181FC1620
	public void .ctor(Query input, Query child) { }

	// RVA: 0x1FC1650 Offset: 0x1FC0850 VA: 0x181FC1650
	private void .ctor(MergeFilterQuery other) { }

	// RVA: 0x1FC15C0 Offset: 0x1FC07C0 VA: 0x181FC15C0 Slot: 13
	public override void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x1FC1510 Offset: 0x1FC0710 VA: 0x181FC1510 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FC1420 Offset: 0x1FC0620 VA: 0x181FC1420 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NamespaceQuery : BaseAxisQuery // TypeDefIndex: 12548
{
	// Fields
	private bool _onNamespace; // 0x58

	// Methods

	// RVA: 0x1FB6CB0 Offset: 0x1FB5EB0 VA: 0x181FB6CB0
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1FB6C30 Offset: 0x1FB5E30 VA: 0x181FB6C30
	private void .ctor(NamespaceQuery other) { }

	// RVA: 0x1FB6BF0 Offset: 0x1FB5DF0 VA: 0x181FB6BF0 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FC1710 Offset: 0x1FC0910 VA: 0x181FC1710 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FC1890 Offset: 0x1FC0A90 VA: 0x181FC1890 Slot: 18
	public override bool matches(XPathNavigator e) { }

	// RVA: 0x1FC17E0 Offset: 0x1FC09E0 VA: 0x181FC17E0 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NodeFunctions : ValueQuery // TypeDefIndex: 12549
{
	// Fields
	private Query _arg; // 0x18
	private Function.FunctionType _funcType; // 0x20
	private XsltContext _xsltContext; // 0x28

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FC1D70 Offset: 0x1FC0F70 VA: 0x181FC1D70
	public void .ctor(Function.FunctionType funcType, Query arg) { }

	// RVA: 0x1FC1D00 Offset: 0x1FC0F00 VA: 0x181FC1D00 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1FC19C0 Offset: 0x1FC0BC0 VA: 0x181FC19C0
	private XPathNavigator EvaluateArg(XPathNodeIterator context) { }

	// RVA: 0x1FC1A40 Offset: 0x1FC0C40 VA: 0x181FC1A40 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FC1DB0 Offset: 0x1FC0FB0 VA: 0x181FC1DB0 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1FC1930 Offset: 0x1FC0B30 VA: 0x181FC1930 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NumberFunctions : ValueQuery // TypeDefIndex: 12550
{
	// Fields
	private Query _arg; // 0x18
	private Function.FunctionType _ftype; // 0x20

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FB79D0 Offset: 0x1FB6BD0 VA: 0x181FB79D0
	public void .ctor(Function.FunctionType ftype, Query arg) { }

	// RVA: 0x1FB7980 Offset: 0x1FB6B80 VA: 0x181FB7980
	private void .ctor(NumberFunctions other) { }

	// RVA: 0x1FB7960 Offset: 0x1FB6B60 VA: 0x181FB7960 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1FC2500 Offset: 0x1FC1700 VA: 0x181FC2500
	internal static double Number(bool arg) { }

	// RVA: 0x1FC2520 Offset: 0x1FC1720 VA: 0x181FC2520
	internal static double Number(string arg) { }

	// RVA: 0x1FC2100 Offset: 0x1FC1300 VA: 0x181FC2100 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FC2570 Offset: 0x1FC1770 VA: 0x181FC2570
	private double Number(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FC2910 Offset: 0x1FC1B10 VA: 0x181FC2910
	private double Sum(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FC2440 Offset: 0x1FC1640 VA: 0x181FC2440
	private double Floor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FC1FC0 Offset: 0x1FC11C0 VA: 0x181FC1FC0
	private double Ceiling(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FC2880 Offset: 0x1FC1A80 VA: 0x181FC2880
	private double Round(XPathNodeIterator nodeIterator) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1FC2080 Offset: 0x1FC1280 VA: 0x181FC2080 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NumericExpr : ValueQuery // TypeDefIndex: 12551
{
	// Fields
	private Operator.Op _op; // 0x18
	private Query _opnd1; // 0x20
	private Query _opnd2; // 0x28

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FC2C00 Offset: 0x1FC1E00 VA: 0x181FC2C00
	public void .ctor(Operator.Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x1FBEA00 Offset: 0x1FBDC00 VA: 0x181FBEA00
	private void .ctor(NumericExpr other) { }

	// RVA: 0x1FBD630 Offset: 0x1FBC830 VA: 0x181FBD630 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1FC2A80 Offset: 0x1FC1C80 VA: 0x181FC2A80 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FC2BC0 Offset: 0x1FC1DC0 VA: 0x181FC2BC0
	private static double GetValue(Operator.Op op, double n1, double n2) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1FC29F0 Offset: 0x1FC1BF0 VA: 0x181FC29F0 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Operand : AstNode // TypeDefIndex: 12552
{
	// Fields
	private XPathResultType _type; // 0x10
	private object _val; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public object OperandValue { get; }

	// Methods

	// RVA: 0x1FC2D50 Offset: 0x1FC1F50 VA: 0x181FC2D50
	public void .ctor(string val) { }

	// RVA: 0x1FC2D80 Offset: 0x1FC1F80 VA: 0x181FC2D80
	public void .ctor(double val) { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public object get_OperandValue() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class OperandQuery : ValueQuery // TypeDefIndex: 12553
{
	// Fields
	internal object val; // 0x18

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FC2D10 Offset: 0x1FC1F10 VA: 0x181FC2D10
	public void .ctor(object val) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FC2D40 Offset: 0x1FC1F40 VA: 0x181FC2D40 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: 
public enum Operator.Op // TypeDefIndex: 12554
{
	// Fields
	public int value__; // 0x0
	public const Operator.Op INVALID = 0;
	public const Operator.Op OR = 1;
	public const Operator.Op AND = 2;
	public const Operator.Op EQ = 3;
	public const Operator.Op NE = 4;
	public const Operator.Op LT = 5;
	public const Operator.Op LE = 6;
	public const Operator.Op GT = 7;
	public const Operator.Op GE = 8;
	public const Operator.Op PLUS = 9;
	public const Operator.Op MINUS = 10;
	public const Operator.Op MUL = 11;
	public const Operator.Op DIV = 12;
	public const Operator.Op MOD = 13;
	public const Operator.Op UNION = 14;
}

// Namespace: MS.Internal.Xml.XPath
internal class Operator : AstNode // TypeDefIndex: 12555
{
	// Fields
	private static Operator.Op[] s_invertOp; // 0x0
	private Operator.Op _opType; // 0x10
	private AstNode _opnd1; // 0x18
	private AstNode _opnd2; // 0x20

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public Operator.Op OperatorType { get; }
	public AstNode Operand1 { get; }
	public AstNode Operand2 { get; }

	// Methods

	// RVA: 0x1FC2DF0 Offset: 0x1FC1FF0 VA: 0x181FC2DF0
	public static Operator.Op InvertOperator(Operator.Op op) { }

	// RVA: 0x10DDCC0 Offset: 0x10DCEC0 VA: 0x1810DDCC0
	public void .ctor(Operator.Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1FC2EE0 Offset: 0x1FC20E0 VA: 0x181FC2EE0 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public Operator.Op get_OperatorType() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public AstNode get_Operand1() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public AstNode get_Operand2() { }

	// RVA: 0x1FC2E60 Offset: 0x1FC2060 VA: 0x181FC2E60
	private static void .cctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ParentQuery : CacheAxisQuery // TypeDefIndex: 12556
{
	// Methods

	// RVA: 0x1FC3030 Offset: 0x1FC2230 VA: 0x181FC3030
	public void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1FC3040 Offset: 0x1FC2240 VA: 0x181FC3040
	private void .ctor(ParentQuery other) { }

	// RVA: 0x1FC2F60 Offset: 0x1FC2160 VA: 0x181FC2F60 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FC2F00 Offset: 0x1FC2100 VA: 0x181FC2F00 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class PreSiblingQuery : CacheAxisQuery // TypeDefIndex: 12557
{
	// Properties
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x1FC3030 Offset: 0x1FC2230 VA: 0x181FC3030
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1FC3040 Offset: 0x1FC2240 VA: 0x181FC3040
	protected void .ctor(PreSiblingQuery other) { }

	// RVA: 0x1FC4FE0 Offset: 0x1FC41E0 VA: 0x181FC4FE0
	private static bool NotVisited(XPathNavigator nav, List<XPathNavigator> parentStk) { }

	// RVA: 0x1FC4D40 Offset: 0x1FC3F40 VA: 0x181FC4D40 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FC4CE0 Offset: 0x1FC3EE0 VA: 0x181FC4CE0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1975F80 Offset: 0x1975180 VA: 0x181975F80 Slot: 17
	public override QueryProps get_Properties() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class PrecedingQuery : BaseAxisQuery // TypeDefIndex: 12558
{
	// Fields
	private XPathNodeIterator _workIterator; // 0x58
	private ClonableStack<XPathNavigator> _ancestorStk; // 0x60

	// Properties
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x1FC55A0 Offset: 0x1FC47A0 VA: 0x181FC55A0
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1FC56A0 Offset: 0x1FC48A0 VA: 0x181FC56A0
	private void .ctor(PrecedingQuery other) { }

	// RVA: 0x1FC5510 Offset: 0x1FC4710 VA: 0x181FC5510 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FC5140 Offset: 0x1FC4340 VA: 0x181FC5140 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FC5420 Offset: 0x1FC4620 VA: 0x181FC5420 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FC5760 Offset: 0x1FC4960 VA: 0x181FC5760 Slot: 17
	public override QueryProps get_Properties() { }
}

// Namespace: MS.Internal.Xml.XPath
internal enum QueryProps // TypeDefIndex: 12559
{
	// Fields
	public int value__; // 0x0
	public const QueryProps None = 0;
	public const QueryProps Position = 1;
	public const QueryProps Count = 2;
	public const QueryProps Cached = 4;
	public const QueryProps Reverse = 8;
	public const QueryProps Merge = 16;
}

// Namespace: MS.Internal.Xml.XPath
[DebuggerDisplay("{ToString()}")]
internal abstract class Query : ResetableIterator // TypeDefIndex: 12560
{
	// Properties
	public override int Count { get; }
	public abstract XPathResultType StaticType { get; }
	public virtual QueryProps Properties { get; }

	// Methods

	// RVA: 0x1FD2360 Offset: 0x1FD1560 VA: 0x181FD2360
	public void .ctor() { }

	// RVA: 0x1FD2380 Offset: 0x1FD1580 VA: 0x181FD2380
	protected void .ctor(Query other) { }

	// RVA: 0x1FD2330 Offset: 0x1FD1530 VA: 0x181FD2330 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x1FD23C0 Offset: 0x1FD15C0 VA: 0x181FD23C0 Slot: 10
	public override int get_Count() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	public virtual void SetXsltContext(XsltContext context) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object Evaluate(XPathNodeIterator nodeIterator);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract XPathNavigator Advance();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract XPathResultType get_StaticType();

	// RVA: 0x6F8DD0 Offset: 0x6F7FD0 VA: 0x1806F8DD0 Slot: 17
	public virtual QueryProps get_Properties() { }

	// RVA: 0x1FD1E10 Offset: 0x1FD1010 VA: 0x181FD1E10
	public static Query Clone(Query input) { }

	// RVA: 0x1FD1EC0 Offset: 0x1FD10C0 VA: 0x181FD1EC0
	protected static XPathNodeIterator Clone(XPathNodeIterator input) { }

	// RVA: 0x1FD1EE0 Offset: 0x1FD10E0 VA: 0x181FD1EE0
	protected static XPathNavigator Clone(XPathNavigator input) { }

	// RVA: 0x1FD2170 Offset: 0x1FD1370 VA: 0x181FD2170
	public static bool Insert(List<XPathNavigator> buffer, XPathNavigator nav) { }

	// RVA: 0x1FD2050 Offset: 0x1FD1250 VA: 0x181FD2050
	private static int GetMedian(int l, int r) { }

	// RVA: 0x1FD1F00 Offset: 0x1FD1100 VA: 0x181FD1F00
	public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r) { }

	// RVA: 0x1FD2060 Offset: 0x1FD1260 VA: 0x181FD2060
	protected XPathResultType GetXPathType(object value) { }
}

// Namespace: 
private enum QueryBuilder.Flags // TypeDefIndex: 12561
{
	// Fields
	public int value__; // 0x0
	public const QueryBuilder.Flags None = 0;
	public const QueryBuilder.Flags SmartDesc = 1;
	public const QueryBuilder.Flags PosFilter = 2;
	public const QueryBuilder.Flags Filter = 4;
}

// Namespace: 
private enum QueryBuilder.Props // TypeDefIndex: 12562
{
	// Fields
	public int value__; // 0x0
	public const QueryBuilder.Props None = 0;
	public const QueryBuilder.Props PosFilter = 1;
	public const QueryBuilder.Props HasPosition = 2;
	public const QueryBuilder.Props HasLast = 4;
	public const QueryBuilder.Props NonFlat = 8;
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class QueryBuilder // TypeDefIndex: 12563
{
	// Fields
	private string _query; // 0x10
	private bool _allowVar; // 0x18
	private bool _allowKey; // 0x19
	private bool _allowCurrent; // 0x1A
	private bool _needContext; // 0x1B
	private BaseAxisQuery _firstInput; // 0x20
	private int _parseDepth; // 0x28

	// Methods

	// RVA: 0x1FD1E00 Offset: 0x1FD1000 VA: 0x181FD1E00
	private void Reset() { }

	// RVA: 0x1FD0360 Offset: 0x1FCF560 VA: 0x181FD0360
	private Query ProcessAxis(Axis root, QueryBuilder.Flags flags, out QueryBuilder.Props props) { }

	// RVA: 0x1FD0190 Offset: 0x1FCF390 VA: 0x181FD0190
	private static bool CanBeNumber(Query q) { }

	// RVA: 0x1FD0B60 Offset: 0x1FCFD60 VA: 0x181FD0B60
	private Query ProcessFilter(Filter root, QueryBuilder.Flags flags, out QueryBuilder.Props props) { }

	// RVA: 0x1FD1B50 Offset: 0x1FD0D50 VA: 0x181FD1B50
	private Query ProcessOperator(Operator root, out QueryBuilder.Props props) { }

	// RVA: 0x1FD1D40 Offset: 0x1FD0F40 VA: 0x181FD1D40
	private Query ProcessVariable(Variable root) { }

	// RVA: 0x1FD1090 Offset: 0x1FD0290 VA: 0x181FD1090
	private Query ProcessFunction(Function root, out QueryBuilder.Props props) { }

	// RVA: 0x1FD01F0 Offset: 0x1FCF3F0 VA: 0x181FD01F0
	private List<Query> ProcessArguments(List<AstNode> args, out QueryBuilder.Props props) { }

	// RVA: 0x1FD1610 Offset: 0x1FD0810 VA: 0x181FD1610
	private Query ProcessNode(AstNode root, QueryBuilder.Flags flags, out QueryBuilder.Props props) { }

	// RVA: 0x1FD0120 Offset: 0x1FCF320 VA: 0x181FD0120
	private Query Build(AstNode root, string query) { }

	// RVA: 0x1FCFF10 Offset: 0x1FCF110 VA: 0x181FCFF10
	internal Query Build(string query, bool allowVar, bool allowKey) { }

	// RVA: 0x1FD0150 Offset: 0x1FCF350 VA: 0x181FD0150
	internal Query Build(string query, out bool needContext) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ResetableIterator : XPathNodeIterator // TypeDefIndex: 12564
{
	// Properties
	public abstract override int CurrentPosition { get; }

	// Methods

	// RVA: 0x1FD2360 Offset: 0x1FD1560 VA: 0x181FD2360
	public void .ctor() { }

	// RVA: 0x1FD2380 Offset: 0x1FD1580 VA: 0x181FD2380
	protected void .ctor(ResetableIterator other) { }

	// RVA: 0x10E8670 Offset: 0x10E7870 VA: 0x1810E8670
	protected void ResetCount() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract override int get_CurrentPosition();
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ReversePositionQuery : ForwardPositionQuery // TypeDefIndex: 12565
{
	// Properties
	public override int CurrentPosition { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x1FD2520 Offset: 0x1FD1720 VA: 0x181FD2520
	public void .ctor(Query input) { }

	// RVA: 0x1FD2530 Offset: 0x1FD1730 VA: 0x181FD2530
	private void .ctor(ReversePositionQuery other) { }

	// RVA: 0x1FD24C0 Offset: 0x1FD16C0 VA: 0x181FD24C0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FD2540 Offset: 0x1FD1740 VA: 0x181FD2540 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x1FD2590 Offset: 0x1FD1790 VA: 0x181FD2590 Slot: 17
	public override QueryProps get_Properties() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Root : AstNode // TypeDefIndex: 12566
{
	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x16F8530 Offset: 0x16F7730 VA: 0x1816F8530 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class StringFunctions : ValueQuery // TypeDefIndex: 12567
{
	// Fields
	private Function.FunctionType _funcType; // 0x18
	private IList<Query> _argList; // 0x20
	private static readonly CompareInfo s_compareInfo; // 0x0

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FD3F10 Offset: 0x1FD3110 VA: 0x181FD3F10
	public void .ctor(Function.FunctionType funcType, IList<Query> argList) { }

	// RVA: 0x1FD3F50 Offset: 0x1FD3150 VA: 0x181FD3F50
	private void .ctor(StringFunctions other) { }

	// RVA: 0x1FD3150 Offset: 0x1FD2350 VA: 0x181FD3150 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1FD29D0 Offset: 0x1FD1BD0 VA: 0x181FD29D0 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD45C0 Offset: 0x1FD37C0 VA: 0x181FD45C0
	internal static string toString(double num) { }

	// RVA: 0x1FD41D0 Offset: 0x1FD33D0 VA: 0x181FD41D0
	internal static string toString(bool b) { }

	// RVA: 0x1FD4220 Offset: 0x1FD3420 VA: 0x181FD4220
	private string toString(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD41A0 Offset: 0x1FD33A0 VA: 0x181FD41A0 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1FD2610 Offset: 0x1FD1810 VA: 0x181FD2610
	private string Concat(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD3310 Offset: 0x1FD2510 VA: 0x181FD3310
	private bool StartsWith(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD2860 Offset: 0x1FD1A60 VA: 0x181FD2860
	private bool Contains(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD3760 Offset: 0x1FD2960 VA: 0x181FD3760
	private string SubstringBefore(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD3580 Offset: 0x1FD2780 VA: 0x181FD3580
	private string SubstringAfter(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD3930 Offset: 0x1FD2B30 VA: 0x181FD3930
	private string Substring(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD3470 Offset: 0x1FD2670 VA: 0x181FD3470
	private double StringLength(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD2F20 Offset: 0x1FD2120 VA: 0x181FD2F20
	private string Normalize(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD3BF0 Offset: 0x1FD2DF0 VA: 0x181FD3BF0
	private string Translate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD25B0 Offset: 0x1FD17B0 VA: 0x181FD25B0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FD3E90 Offset: 0x1FD3090 VA: 0x181FD3E90
	private static void .cctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class UnionExpr : Query // TypeDefIndex: 12568
{
	// Fields
	internal Query qy1; // 0x18
	internal Query qy2; // 0x20
	private bool _advance1; // 0x28
	private bool _advance2; // 0x29
	private XPathNavigator _currentNode; // 0x30
	private XPathNavigator _nextNode; // 0x38

	// Properties
	public override XPathResultType StaticType { get; }
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }

	// Methods

	// RVA: 0x1FD4A00 Offset: 0x1FD3C00 VA: 0x181FD4A00
	public void .ctor(Query query1, Query query2) { }

	// RVA: 0x1FD4940 Offset: 0x1FD3B40 VA: 0x181FD4940
	private void .ctor(UnionExpr other) { }

	// RVA: 0x1FD48E0 Offset: 0x1FD3AE0 VA: 0x181FD48E0 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FB7370 Offset: 0x1FB6570 VA: 0x181FB7370 Slot: 13
	public override void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x1FD4810 Offset: 0x1FD3A10 VA: 0x181FD4810 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FD48D0 Offset: 0x1FD3AD0 VA: 0x181FD48D0
	private XPathNavigator ProcessSamePosition(XPathNavigator result) { }

	// RVA: 0x1FD48B0 Offset: 0x1FD3AB0 VA: 0x181FD48B0
	private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x1FD4890 Offset: 0x1FD3A90 VA: 0x181FD4890
	private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x1FD4610 Offset: 0x1FD3810 VA: 0x181FD4610 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1FD4720 Offset: 0x1FD3920 VA: 0x181FD4720 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x1FD4A50 Offset: 0x1FD3C50 VA: 0x181FD4A50 Slot: 9
	public override int get_CurrentPosition() { }
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ValueQuery : Query // TypeDefIndex: 12569
{
	// Properties
	public sealed override XPathNavigator Current { get; }
	public sealed override int CurrentPosition { get; }
	public sealed override int Count { get; }

	// Methods

	// RVA: 0x1FD2360 Offset: 0x1FD1560 VA: 0x181FD2360
	public void .ctor() { }

	// RVA: 0x1FD2380 Offset: 0x1FD1580 VA: 0x181FD2380
	protected void .ctor(ValueQuery other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public sealed override void Reset() { }

	// RVA: 0x1FD4B50 Offset: 0x1FD3D50 VA: 0x181FD4B50 Slot: 8
	public sealed override XPathNavigator get_Current() { }

	// RVA: 0x1FD4B10 Offset: 0x1FD3D10 VA: 0x181FD4B10 Slot: 9
	public sealed override int get_CurrentPosition() { }

	// RVA: 0x1FD4AD0 Offset: 0x1FD3CD0 VA: 0x181FD4AD0 Slot: 10
	public sealed override int get_Count() { }

	// RVA: 0x1FD4A90 Offset: 0x1FD3C90 VA: 0x181FD4A90 Slot: 15
	public sealed override XPathNavigator Advance() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Variable : AstNode // TypeDefIndex: 12570
{
	// Fields
	private string _localname; // 0x10
	private string _prefix; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public string Localname { get; }
	public string Prefix { get; }

	// Methods

	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	public void .ctor(string name, string prefix) { }

	// RVA: 0x68EEF0 Offset: 0x68E0F0 VA: 0x18068EEF0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Localname() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Prefix() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class VariableQuery : ExtensionQuery // TypeDefIndex: 12571
{
	// Fields
	private IXsltContextVariable _variable; // 0x38

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x1FD4DE0 Offset: 0x1FD3FE0 VA: 0x181FD4DE0
	public void .ctor(string name, string prefix) { }

	// RVA: 0x1FD4E00 Offset: 0x1FD4000 VA: 0x181FD4E00
	private void .ctor(VariableQuery other) { }

	// RVA: 0x1FD4D20 Offset: 0x1FD3F20 VA: 0x181FD4D20 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1FD4C00 Offset: 0x1FD3E00 VA: 0x181FD4C00 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD4E40 Offset: 0x1FD4040 VA: 0x181FD4E40 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1FD4B90 Offset: 0x1FD3D90 VA: 0x181FD4B90 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathAncestorQuery : CacheAxisQuery // TypeDefIndex: 12572
{
	// Fields
	private bool _matchSelf; // 0x60

	// Properties
	public override int CurrentPosition { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x1FD5060 Offset: 0x1FD4260 VA: 0x181FD5060
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf) { }

	// RVA: 0x1FD5090 Offset: 0x1FD4290 VA: 0x181FD5090
	private void .ctor(XPathAncestorQuery other) { }

	// RVA: 0x1FD4F20 Offset: 0x1FD4120 VA: 0x181FD4F20 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1FD4EB0 Offset: 0x1FD40B0 VA: 0x181FD4EB0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FD50D0 Offset: 0x1FD42D0 VA: 0x181FD50D0 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x1FD2590 Offset: 0x1FD1790 VA: 0x181FD2590 Slot: 17
	public override QueryProps get_Properties() { }
}

// Namespace: MS.Internal.Xml.XPath
[DebuggerDisplay("Position={CurrentPosition}, Current={debuggerDisplayProxy, nq}")]
internal class XPathArrayIterator : ResetableIterator // TypeDefIndex: 12573
{
	// Fields
	protected IList list; // 0x18
	protected int index; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x1FD52D0 Offset: 0x1FD44D0 VA: 0x181FD52D0
	public void .ctor(XPathArrayIterator it) { }

	// RVA: 0x1FD5320 Offset: 0x1FD4520 VA: 0x181FD5320
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1FD5120 Offset: 0x1FD4320 VA: 0x181FD5120 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FD5500 Offset: 0x1FD4700 VA: 0x181FD5500 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x1FD54B0 Offset: 0x1FD46B0 VA: 0x181FD54B0 Slot: 10
	public override int get_Count() { }

	// RVA: 0x1FD5250 Offset: 0x1FD4450 VA: 0x181FD5250 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x1FD52C0 Offset: 0x1FD44C0 VA: 0x181FD52C0 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FD5190 Offset: 0x1FD4390 VA: 0x181FD5190 Slot: 11
	public override IEnumerator GetEnumerator() { }
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class XPathAxisIterator : XPathNodeIterator // TypeDefIndex: 12574
{
	// Fields
	internal XPathNavigator nav; // 0x18
	internal XPathNodeType type; // 0x20
	internal string name; // 0x28
	internal string uri; // 0x30
	internal int position; // 0x38
	internal bool matchSelf; // 0x3C
	internal bool first; // 0x3D

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	protected virtual bool Matches { get; }

	// Methods

	// RVA: 0x1FD56B0 Offset: 0x1FD48B0 VA: 0x181FD56B0
	public void .ctor(XPathNavigator nav, bool matchSelf) { }

	// RVA: 0x1FD56F0 Offset: 0x1FD48F0 VA: 0x181FD56F0
	public void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x1FD57C0 Offset: 0x1FD49C0 VA: 0x181FD57C0
	public void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x1FD5740 Offset: 0x1FD4940 VA: 0x181FD5740
	public void .ctor(XPathAxisIterator it) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x1FD58B0 Offset: 0x1FD4AB0 VA: 0x181FD58B0 Slot: 12
	protected virtual bool get_Matches() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class XPathChildIterator : XPathAxisIterator // TypeDefIndex: 12575
{
	// Methods

	// RVA: 0x1FD5B60 Offset: 0x1FD4D60 VA: 0x181FD5B60
	public void .ctor(XPathNavigator nav, XPathNodeType type) { }

	// RVA: 0x1FD5BA0 Offset: 0x1FD4DA0 VA: 0x181FD5BA0
	public void .ctor(XPathNavigator nav, string name, string namespaceURI) { }

	// RVA: 0x1FD5740 Offset: 0x1FD4940 VA: 0x181FD5740
	public void .ctor(XPathChildIterator it) { }

	// RVA: 0x1FD5A20 Offset: 0x1FD4C20 VA: 0x181FD5A20 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FD5AD0 Offset: 0x1FD4CD0 VA: 0x181FD5AD0 Slot: 7
	public override bool MoveNext() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class XPathDescendantIterator : XPathAxisIterator // TypeDefIndex: 12576
{
	// Fields
	private int _level; // 0x40

	// Methods

	// RVA: 0x1FD56F0 Offset: 0x1FD48F0 VA: 0x181FD56F0
	public void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x1FD57C0 Offset: 0x1FD49C0 VA: 0x181FD57C0
	public void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x1FD5E30 Offset: 0x1FD5030 VA: 0x181FD5E30
	public void .ctor(XPathDescendantIterator it) { }

	// RVA: 0x1FD5C90 Offset: 0x1FD4E90 VA: 0x181FD5C90 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FD5D40 Offset: 0x1FD4F40 VA: 0x181FD5D40 Slot: 7
	public override bool MoveNext() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathEmptyIterator : ResetableIterator // TypeDefIndex: 12577
{
	// Fields
	public static XPathEmptyIterator Instance; // 0x0

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x1FD2360 Offset: 0x1FD1560 VA: 0x181FD2360
	private void .ctor() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	public override int get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FD94A0 Offset: 0x1FD86A0 VA: 0x181FD94A0
	private static void .cctor() { }
}

// Namespace: 
private class XPathParser.ParamInfo // TypeDefIndex: 12578
{
	// Fields
	private Function.FunctionType _ftype; // 0x10
	private int _minargs; // 0x14
	private int _maxargs; // 0x18
	private XPathResultType[] _argTypes; // 0x20

	// Properties
	public Function.FunctionType FType { get; }
	public int Minargs { get; }
	public int Maxargs { get; }
	public XPathResultType[] ArgTypes { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public Function.FunctionType get_FType() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_Minargs() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Maxargs() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public XPathResultType[] get_ArgTypes() { }

	// RVA: 0x1FCFEC0 Offset: 0x1FCF0C0 VA: 0x181FCFEC0
	internal void .ctor(Function.FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes) { }
}

// Namespace: MS.Internal.Xml.XPath
internal class XPathParser // TypeDefIndex: 12579
{
	// Fields
	private XPathScanner _scanner; // 0x10
	private int _parseDepth; // 0x18
	private static readonly XPathResultType[] s_temparray1; // 0x0
	private static readonly XPathResultType[] s_temparray2; // 0x8
	private static readonly XPathResultType[] s_temparray3; // 0x10
	private static readonly XPathResultType[] s_temparray4; // 0x18
	private static readonly XPathResultType[] s_temparray5; // 0x20
	private static readonly XPathResultType[] s_temparray6; // 0x28
	private static readonly XPathResultType[] s_temparray7; // 0x30
	private static readonly XPathResultType[] s_temparray8; // 0x38
	private static readonly XPathResultType[] s_temparray9; // 0x40
	private static Dictionary<string, XPathParser.ParamInfo> s_functionTable; // 0x48
	private static Dictionary<string, Axis.AxisType> s_AxesTable; // 0x50

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x1FDE0C0 Offset: 0x1FDD2C0 VA: 0x181FDE0C0
	public static AstNode ParseXPathExpression(string xpathExpression) { }

	// RVA: 0x1FDBFA0 Offset: 0x1FDB1A0 VA: 0x181FDBFA0
	private AstNode ParseExpression(AstNode qyInput) { }

	// RVA: 0x1FDD0F0 Offset: 0x1FDC2F0 VA: 0x181FDD0F0
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x1FDBD60 Offset: 0x1FDAF60 VA: 0x181FDBD60
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x1FDBEA0 Offset: 0x1FDB0A0 VA: 0x181FDBEA0
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x1FDD970 Offset: 0x1FDCB70 VA: 0x181FDD970
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x1FDBC60 Offset: 0x1FDAE60 VA: 0x181FDBC60
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x1FDCB50 Offset: 0x1FDBD50 VA: 0x181FDCB50
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x1FDDDE0 Offset: 0x1FDCFE0 VA: 0x181FDDDE0
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x1FDDEE0 Offset: 0x1FDD0E0 VA: 0x181FDDEE0
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x1FDBAB0 Offset: 0x1FDACB0 VA: 0x181FDBAB0
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x1FDD230 Offset: 0x1FDC430 VA: 0x181FDD230
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x1FDC130 Offset: 0x1FDB330 VA: 0x181FDC130
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x1FDD530 Offset: 0x1FDC730 VA: 0x181FDD530
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x1FDC1F0 Offset: 0x1FDB3F0 VA: 0x181FDC1F0
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x1FDDA90 Offset: 0x1FDCC90 VA: 0x181FDDA90
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x1FDBC10 Offset: 0x1FDAE10 VA: 0x181FDBC10
	private static bool IsStep(XPathScanner.LexKind lexKind) { }

	// RVA: 0x1FDDB70 Offset: 0x1FDCD70 VA: 0x181FDDB70
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x1FDCD00 Offset: 0x1FDBF00 VA: 0x181FDCD00
	private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x1FDBB80 Offset: 0x1FDAD80 VA: 0x181FDBB80
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x1FDD6C0 Offset: 0x1FDC8C0 VA: 0x181FDD6C0
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x1FDC350 Offset: 0x1FDB550 VA: 0x181FDC350
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x1FDAB30 Offset: 0x1FD9D30 VA: 0x181FDAB30
	private void CheckToken(XPathScanner.LexKind t) { }

	// RVA: 0x1FDE240 Offset: 0x1FDD440 VA: 0x181FDE240
	private void PassToken(XPathScanner.LexKind t) { }

	// RVA: 0x1FDBC40 Offset: 0x1FDAE40 VA: 0x181FDBC40
	private void NextLex() { }

	// RVA: 0x1FDE270 Offset: 0x1FDD470 VA: 0x181FDE270
	private bool TestOp(string op) { }

	// RVA: 0x1FDAAC0 Offset: 0x1FD9CC0 VA: 0x181FDAAC0
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x1FDAE30 Offset: 0x1FDA030 VA: 0x181FDAE30
	private static Dictionary<string, XPathParser.ParamInfo> CreateFunctionTable() { }

	// RVA: 0x1FDABB0 Offset: 0x1FD9DB0 VA: 0x181FDABB0
	private static Dictionary<string, Axis.AxisType> CreateAxesTable() { }

	// RVA: 0x1FDB9C0 Offset: 0x1FDABC0 VA: 0x181FDB9C0
	private Axis.AxisType GetAxis() { }

	// RVA: 0x1FDE2C0 Offset: 0x1FDD4C0 VA: 0x181FDE2C0
	private static void .cctor() { }
}

// Namespace: 
public enum XPathScanner.LexKind // TypeDefIndex: 12580
{
	// Fields
	public int value__; // 0x0
	public const XPathScanner.LexKind Comma = 44;
	public const XPathScanner.LexKind Slash = 47;
	public const XPathScanner.LexKind At = 64;
	public const XPathScanner.LexKind Dot = 46;
	public const XPathScanner.LexKind LParens = 40;
	public const XPathScanner.LexKind RParens = 41;
	public const XPathScanner.LexKind LBracket = 91;
	public const XPathScanner.LexKind RBracket = 93;
	public const XPathScanner.LexKind Star = 42;
	public const XPathScanner.LexKind Plus = 43;
	public const XPathScanner.LexKind Minus = 45;
	public const XPathScanner.LexKind Eq = 61;
	public const XPathScanner.LexKind Lt = 60;
	public const XPathScanner.LexKind Gt = 62;
	public const XPathScanner.LexKind Bang = 33;
	public const XPathScanner.LexKind Dollar = 36;
	public const XPathScanner.LexKind Apos = 39;
	public const XPathScanner.LexKind Quote = 34;
	public const XPathScanner.LexKind Union = 124;
	public const XPathScanner.LexKind Ne = 78;
	public const XPathScanner.LexKind Le = 76;
	public const XPathScanner.LexKind Ge = 71;
	public const XPathScanner.LexKind And = 65;
	public const XPathScanner.LexKind Or = 79;
	public const XPathScanner.LexKind DotDot = 68;
	public const XPathScanner.LexKind SlashSlash = 83;
	public const XPathScanner.LexKind Name = 110;
	public const XPathScanner.LexKind String = 115;
	public const XPathScanner.LexKind Number = 100;
	public const XPathScanner.LexKind Axe = 97;
	public const XPathScanner.LexKind Eof = 69;
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathScanner // TypeDefIndex: 12581
{
	// Fields
	private string _xpathExpr; // 0x10
	private int _xpathExprIndex; // 0x18
	private XPathScanner.LexKind _kind; // 0x1C
	private char _currentChar; // 0x20
	private string _name; // 0x28
	private string _prefix; // 0x30
	private string _stringValue; // 0x38
	private double _numberValue; // 0x40
	private bool _canBeFunction; // 0x48
	private XmlCharType _xmlCharType; // 0x50

	// Properties
	public string SourceText { get; }
	private char CurrentChar { get; }
	public XPathScanner.LexKind Kind { get; }
	public string Name { get; }
	public string Prefix { get; }
	public string StringValue { get; }
	public double NumberValue { get; }
	public bool CanBeFunction { get; }

	// Methods

	// RVA: 0x1FDF1B0 Offset: 0x1FDE3B0 VA: 0x181FDF1B0
	public void .ctor(string xpathExpr) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_SourceText() { }

	// RVA: 0x8CA2C0 Offset: 0x8C94C0 VA: 0x1808CA2C0
	private char get_CurrentChar() { }

	// RVA: 0x1FDE590 Offset: 0x1FDD790 VA: 0x181FDE590
	private bool NextChar() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public XPathScanner.LexKind get_Kind() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Name() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Prefix() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_StringValue() { }

	// RVA: 0x52F530 Offset: 0x52E730 VA: 0x18052F530
	public double get_NumberValue() { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_CanBeFunction() { }

	// RVA: 0x1FDF120 Offset: 0x1FDE320 VA: 0x181FDF120
	private void SkipSpace() { }

	// RVA: 0x1FDE5F0 Offset: 0x1FDD7F0 VA: 0x181FDE5F0
	public bool NextLex() { }

	// RVA: 0x1FDEE60 Offset: 0x1FDE060 VA: 0x181FDEE60
	private double ScanNumber() { }

	// RVA: 0x1FDECB0 Offset: 0x1FDDEB0 VA: 0x181FDECB0
	private double ScanFraction() { }

	// RVA: 0x1FDEFE0 Offset: 0x1FDE1E0 VA: 0x181FDEFE0
	private string ScanString() { }

	// RVA: 0x1FDEDA0 Offset: 0x1FDDFA0 VA: 0x181FDEDA0
	private string ScanName() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class XPathSelectionIterator : ResetableIterator // TypeDefIndex: 12582
{
	// Fields
	private XPathNavigator _nav; // 0x18
	private Query _query; // 0x20
	private int _position; // 0x28

	// Properties
	public override int Count { get; }
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }

	// Methods

	// RVA: 0x1FDF480 Offset: 0x1FDE680 VA: 0x181FDF480
	internal void .ctor(XPathNavigator nav, Query query) { }

	// RVA: 0x1FDF4E0 Offset: 0x1FDE6E0 VA: 0x181FDF4E0
	protected void .ctor(XPathSelectionIterator it) { }

	// RVA: 0x1E18670 Offset: 0x1E17870 VA: 0x181E18670 Slot: 12
	public override void Reset() { }

	// RVA: 0x1FDF3F0 Offset: 0x1FDE5F0 VA: 0x181FDF3F0 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x1E186D0 Offset: 0x1E178D0 VA: 0x181E186D0 Slot: 10
	public override int get_Count() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x1FDF270 Offset: 0x1FDE470 VA: 0x181FDF270 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathSelfQuery : BaseAxisQuery // TypeDefIndex: 12583
{
	// Methods

	// RVA: 0x1FDF710 Offset: 0x1FDE910 VA: 0x181FDF710
	public void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1FDF700 Offset: 0x1FDE900 VA: 0x181FDF700
	private void .ctor(XPathSelfQuery other) { }

	// RVA: 0x1FDF630 Offset: 0x1FDE830 VA: 0x181FDF630 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x1FDF6A0 Offset: 0x1FDE8A0 VA: 0x181FDF6A0 Slot: 6
	public override XPathNodeIterator Clone() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class XPathSingletonIterator : ResetableIterator // TypeDefIndex: 12584
{
	// Fields
	private XPathNavigator _nav; // 0x18
	private int _position; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x1FDF880 Offset: 0x1FDEA80 VA: 0x181FDF880
	public void .ctor(XPathNavigator nav) { }

	// RVA: 0x1FDF830 Offset: 0x1FDEA30 VA: 0x181FDF830
	public void .ctor(XPathNavigator nav, bool moved) { }

	// RVA: 0x1FDF7D0 Offset: 0x1FDE9D0 VA: 0x181FDF7D0
	public void .ctor(XPathSingletonIterator it) { }

	// RVA: 0x1FDF720 Offset: 0x1FDE920 VA: 0x181FDF720 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 10
	public override int get_Count() { }

	// RVA: 0x1FDF7B0 Offset: 0x1FDE9B0 VA: 0x181FDF7B0 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x1FD52C0 Offset: 0x1FD44C0 VA: 0x181FD52C0 Slot: 12
	public override void Reset() { }
}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathDocumentBaseIterator : XPathNodeIterator // TypeDefIndex: 12585
{
	// Fields
	protected XPathDocumentNavigator ctxt; // 0x18
	protected int pos; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }

	// Methods

	// RVA: 0x1FD5EC0 Offset: 0x1FD50C0 VA: 0x181FD5EC0
	protected void .ctor(XPathDocumentNavigator ctxt) { }

	// RVA: 0x1FD5F60 Offset: 0x1FD5160 VA: 0x181FD5F60
	protected void .ctor(XPathDocumentBaseIterator iter) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 9
	public override int get_CurrentPosition() { }
}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentElementChildIterator : XPathDocumentBaseIterator // TypeDefIndex: 12586
{
	// Fields
	private string _localName; // 0x28
	private string _namespaceUri; // 0x30

	// Methods

	// RVA: 0x1FD6130 Offset: 0x1FD5330 VA: 0x181FD6130
	public void .ctor(XPathDocumentNavigator parent, string name, string namespaceURI) { }

	// RVA: 0x1FD60F0 Offset: 0x1FD52F0 VA: 0x181FD60F0
	public void .ctor(XPathDocumentElementChildIterator iter) { }

	// RVA: 0x1FD6010 Offset: 0x1FD5210 VA: 0x181FD6010 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FD6080 Offset: 0x1FD5280 VA: 0x181FD6080 Slot: 7
	public override bool MoveNext() { }
}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentKindChildIterator : XPathDocumentBaseIterator // TypeDefIndex: 12587
{
	// Fields
	private XPathNodeType _typ; // 0x28

	// Methods

	// RVA: 0x1FD6730 Offset: 0x1FD5930 VA: 0x181FD6730
	public void .ctor(XPathDocumentNavigator parent, XPathNodeType typ) { }

	// RVA: 0x1FD67E0 Offset: 0x1FD59E0 VA: 0x181FD67E0
	public void .ctor(XPathDocumentKindChildIterator iter) { }

	// RVA: 0x1FD6650 Offset: 0x1FD5850 VA: 0x181FD6650 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FD66C0 Offset: 0x1FD58C0 VA: 0x181FD66C0 Slot: 7
	public override bool MoveNext() { }
}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentElementDescendantIterator : XPathDocumentBaseIterator // TypeDefIndex: 12588
{
	// Fields
	private XPathDocumentNavigator _end; // 0x28
	private string _localName; // 0x30
	private string _namespaceUri; // 0x38
	private bool _matchSelf; // 0x40

	// Methods

	// RVA: 0x1FD6430 Offset: 0x1FD5630 VA: 0x181FD6430
	public void .ctor(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x1FD6600 Offset: 0x1FD5800 VA: 0x181FD6600
	public void .ctor(XPathDocumentElementDescendantIterator iter) { }

	// RVA: 0x1FD6270 Offset: 0x1FD5470 VA: 0x181FD6270 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FD62F0 Offset: 0x1FD54F0 VA: 0x181FD62F0 Slot: 7
	public override bool MoveNext() { }
}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentKindDescendantIterator : XPathDocumentBaseIterator // TypeDefIndex: 12589
{
	// Fields
	private XPathDocumentNavigator _end; // 0x28
	private XPathNodeType _typ; // 0x30
	private bool _matchSelf; // 0x34

	// Methods

	// RVA: 0x1FD69A0 Offset: 0x1FD5BA0 VA: 0x181FD69A0
	public void .ctor(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf) { }

	// RVA: 0x1FD6AE0 Offset: 0x1FD5CE0 VA: 0x181FD6AE0
	public void .ctor(XPathDocumentKindDescendantIterator iter) { }

	// RVA: 0x1FD6820 Offset: 0x1FD5A20 VA: 0x181FD6820 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1FD68A0 Offset: 0x1FD5AA0 VA: 0x181FD68A0 Slot: 7
	public override bool MoveNext() { }
}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 12590
{
	// Fields
	private XPathNode[] _pageCurrent; // 0x10
	private XPathNode[] _pageParent; // 0x18
	private int _idxCurrent; // 0x20
	private int _idxParent; // 0x24
	private string _atomizedLocalName; // 0x28

	// Properties
	public override string Value { get; }
	public override XPathNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Name { get; }
	public override string Prefix { get; }
	public override string BaseURI { get; }
	public override XmlNameTable NameTable { get; }
	public override object UnderlyingObject { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x1FD8D50 Offset: 0x1FD7F50 VA: 0x181FD8D50
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x1FD8DE0 Offset: 0x1FD7FE0 VA: 0x181FD8DE0
	public void .ctor(XPathDocumentNavigator nav) { }

	// RVA: 0x1FD9220 Offset: 0x1FD8420 VA: 0x181FD9220 Slot: 5
	public override string get_Value() { }

	// RVA: 0x1FD6B30 Offset: 0x1FD5D30 VA: 0x181FD6B30 Slot: 25
	public override XPathNavigator Clone() { }

	// RVA: 0x1FD91A0 Offset: 0x1FD83A0 VA: 0x181FD91A0 Slot: 26
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x1FD9040 Offset: 0x1FD8240 VA: 0x181FD9040 Slot: 27
	public override string get_LocalName() { }

	// RVA: 0x1FD9160 Offset: 0x1FD8360 VA: 0x181FD9160 Slot: 29
	public override string get_NamespaceURI() { }

	// RVA: 0x1FD90D0 Offset: 0x1FD82D0 VA: 0x181FD90D0 Slot: 28
	public override string get_Name() { }

	// RVA: 0x1FD91E0 Offset: 0x1FD83E0 VA: 0x181FD91E0 Slot: 30
	public override string get_Prefix() { }

	// RVA: 0x1FD8E30 Offset: 0x1FD8030 VA: 0x181FD8E30 Slot: 31
	public override string get_BaseURI() { }

	// RVA: 0x1FD9080 Offset: 0x1FD8280 VA: 0x181FD9080 Slot: 21
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1FD7740 Offset: 0x1FD6940 VA: 0x181FD7740 Slot: 35
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1FD80F0 Offset: 0x1FD72F0 VA: 0x181FD80F0 Slot: 36
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1FD7240 Offset: 0x1FD6440 VA: 0x181FD7240 Slot: 34
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1FD7910 Offset: 0x1FD6B10 VA: 0x181FD7910 Slot: 38
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x1FD8170 Offset: 0x1FD7370 VA: 0x181FD8170 Slot: 39
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x1FD8440 Offset: 0x1FD7640 VA: 0x181FD8440 Slot: 40
	public override bool MoveToNext() { }

	// RVA: 0x1FD77D0 Offset: 0x1FD69D0 VA: 0x181FD77D0 Slot: 41
	public override bool MoveToFirstChild() { }

	// RVA: 0x1FD85B0 Offset: 0x1FD77B0 VA: 0x181FD85B0 Slot: 42
	public override bool MoveToParent() { }

	// RVA: 0x1FD86A0 Offset: 0x1FD78A0 VA: 0x181FD86A0 Slot: 44
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x1FD8060 Offset: 0x1FD7260 VA: 0x181FD8060 Slot: 45
	public override bool MoveToId(string id) { }

	// RVA: 0x1FD71B0 Offset: 0x1FD63B0 VA: 0x181FD71B0 Slot: 52
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x1FD8630 Offset: 0x1FD7830 VA: 0x181FD8630 Slot: 43
	public override void MoveToRoot() { }

	// RVA: 0x1FD75C0 Offset: 0x1FD67C0 VA: 0x181FD75C0 Slot: 46
	public override bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x1FD82F0 Offset: 0x1FD74F0 VA: 0x181FD82F0 Slot: 50
	public override bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x1FD7400 Offset: 0x1FD6600 VA: 0x181FD7400 Slot: 47
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x1FD84B0 Offset: 0x1FD76B0 VA: 0x181FD84B0 Slot: 51
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x1FD7B20 Offset: 0x1FD6D20 VA: 0x181FD7B20 Slot: 48
	public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x1FD7CE0 Offset: 0x1FD6EE0 VA: 0x181FD7CE0 Slot: 49
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x1FD88D0 Offset: 0x1FD7AD0 VA: 0x181FD88D0 Slot: 60
	public override XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x1FD8720 Offset: 0x1FD7920 VA: 0x181FD8720 Slot: 61
	public override XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x1FD8BE0 Offset: 0x1FD7DE0 VA: 0x181FD8BE0 Slot: 62
	public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x1FD89A0 Offset: 0x1FD7BA0 VA: 0x181FD89A0 Slot: 63
	public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x1FD6BD0 Offset: 0x1FD5DD0 VA: 0x181FD6BD0 Slot: 54
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x1FD6F30 Offset: 0x1FD6130 VA: 0x181FD6F30 Slot: 53
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x1FD6DC0 Offset: 0x1FD5FC0 VA: 0x181FD6DC0
	private int GetPrimaryLocation() { }

	// RVA: 0x1FD6E20 Offset: 0x1FD6020 VA: 0x181FD6E20
	private int GetSecondaryLocation() { }

	// RVA: 0x1720320 Offset: 0x171F520 VA: 0x181720320 Slot: 33
	public override object get_UnderlyingObject() { }

	// RVA: 0x1FD6EE0 Offset: 0x1FD60E0 VA: 0x181FD6EE0 Slot: 64
	public bool HasLineInfo() { }

	// RVA: 0x1FD8F20 Offset: 0x1FD8120 VA: 0x181FD8F20 Slot: 65
	public int get_LineNumber() { }

	// RVA: 0x1FD8FA0 Offset: 0x1FD81A0 VA: 0x181FD8FA0 Slot: 66
	public int get_LinePosition() { }

	// RVA: 0x1FD6DB0 Offset: 0x1FD5FB0 VA: 0x181FD6DB0
	public int GetPositionHashCode() { }

	// RVA: 0x1FD7040 Offset: 0x1FD6240 VA: 0x181FD7040
	public bool IsElementMatch(string localName, string namespaceURI) { }

	// RVA: 0x1FD7120 Offset: 0x1FD6320 VA: 0x181FD7120
	public bool IsKindMatch(XPathNodeType typ) { }

	// RVA: 0x1FD6D00 Offset: 0x1FD5F00 VA: 0x181FD6D00
	private int GetFollowingEnd(XPathDocumentNavigator end, bool useParentOfVirtual, out XPathNode[] pageEnd) { }
}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNode // TypeDefIndex: 12591
{
	// Fields
	private XPathNodeInfoAtom _info; // 0x0
	private ushort _idxSibling; // 0x8
	private ushort _idxParent; // 0xA
	private ushort _idxSimilar; // 0xC
	private ushort _posOffset; // 0xE
	private uint _props; // 0x10
	private string _value; // 0x18

	// Properties
	public XPathNodeType NodeType { get; }
	public string Prefix { get; }
	public string LocalName { get; }
	public string Name { get; }
	public string NamespaceUri { get; }
	public XPathDocument Document { get; }
	public string BaseUri { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public int CollapsedLinePosition { get; }
	public XPathNodePageInfo PageInfo { get; }
	public bool IsXmlNamespaceNode { get; }
	public bool HasSibling { get; }
	public bool HasCollapsedText { get; }
	public bool HasAttribute { get; }
	public bool HasContentChild { get; }
	public bool HasElementChild { get; }
	public bool IsAttrNmsp { get; }
	public bool IsText { get; }
	public bool HasNamespaceDecls { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1FDAA70 Offset: 0x1FD9C70 VA: 0x181FDAA70
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1FDAAA0 Offset: 0x1FD9CA0 VA: 0x181FDAAA0
	public string get_Prefix() { }

	// RVA: 0x1576260 Offset: 0x1575460 VA: 0x181576260
	public string get_LocalName() { }

	// RVA: 0x1FDA9E0 Offset: 0x1FD9BE0 VA: 0x181FDA9E0
	public string get_Name() { }

	// RVA: 0x1FDAA50 Offset: 0x1FD9C50 VA: 0x181FDAA50
	public string get_NamespaceUri() { }

	// RVA: 0x1FDA840 Offset: 0x1FD9A40 VA: 0x181FDA840
	public XPathDocument get_Document() { }

	// RVA: 0x1FDA7F0 Offset: 0x1FD99F0 VA: 0x181FDA7F0
	public string get_BaseUri() { }

	// RVA: 0x1FDA990 Offset: 0x1FD9B90 VA: 0x181FDA990
	public int get_LineNumber() { }

	// RVA: 0x1FDA9C0 Offset: 0x1FD9BC0 VA: 0x181FDA9C0
	public int get_LinePosition() { }

	// RVA: 0x1FDA810 Offset: 0x1FD9A10 VA: 0x181FDA810
	public int get_CollapsedLinePosition() { }

	// RVA: 0x1FDAA80 Offset: 0x1FD9C80 VA: 0x181FDAA80
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x1FDA720 Offset: 0x1FD9920 VA: 0x181FDA720
	public int GetRoot(out XPathNode[] pageNode) { }

	// RVA: 0x1FDA6F0 Offset: 0x1FD98F0 VA: 0x181FDA6F0
	public int GetParent(out XPathNode[] pageNode) { }

	// RVA: 0x1FDA750 Offset: 0x1FD9950 VA: 0x181FDA750
	public int GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0x1FDA780 Offset: 0x1FD9980 VA: 0x181FDA780
	public int GetSimilarElement(out XPathNode[] pageNode) { }

	// RVA: 0x1FDA7B0 Offset: 0x1FD99B0 VA: 0x181FDA7B0
	public bool NameMatch(string localName, string namespaceName) { }

	// RVA: 0x1FDA6B0 Offset: 0x1FD98B0 VA: 0x181FDA6B0
	public bool ElementMatch(string localName, string namespaceName) { }

	// RVA: 0x1FDA920 Offset: 0x1FD9B20 VA: 0x181FDA920
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x1FDA8A0 Offset: 0x1FD9AA0 VA: 0x181FDA8A0
	public bool get_HasSibling() { }

	// RVA: 0x1FDA860 Offset: 0x1FD9A60 VA: 0x181FDA860
	public bool get_HasCollapsedText() { }

	// RVA: 0x160A7C0 Offset: 0x16099C0 VA: 0x18160A7C0
	public bool get_HasAttribute() { }

	// RVA: 0x1FDA870 Offset: 0x1FD9A70 VA: 0x181FDA870
	public bool get_HasContentChild() { }

	// RVA: 0x1FDA880 Offset: 0x1FD9A80 VA: 0x181FDA880
	public bool get_HasElementChild() { }

	// RVA: 0x1FDA8B0 Offset: 0x1FD9AB0 VA: 0x181FDA8B0
	public bool get_IsAttrNmsp() { }

	// RVA: 0x1FDA8D0 Offset: 0x1FD9AD0 VA: 0x181FDA8D0
	public bool get_IsText() { }

	// RVA: 0x1FDA890 Offset: 0x1FD9A90 VA: 0x181FDA890
	public bool get_HasNamespaceDecls() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Value() { }
}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNodeRef // TypeDefIndex: 12592
{
	// Fields
	private XPathNode[] _page; // 0x0
	private int _idx; // 0x8

	// Properties
	public XPathNode[] Page { get; }
	public int Index { get; }

	// Methods

	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public XPathNode[] get_Page() { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_Index() { }

	// RVA: 0x1FDA670 Offset: 0x1FD9870 VA: 0x181FDA670 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathNodeHelper // TypeDefIndex: 12593
{
	// Methods

	// RVA: 0x1FDA230 Offset: 0x1FD9430 VA: 0x181FDA230
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x1FDA140 Offset: 0x1FD9340 VA: 0x181FDA140
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x1FDA0C0 Offset: 0x1FD92C0 VA: 0x181FDA0C0
	public static bool GetFirstAttribute(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x1FDA2F0 Offset: 0x1FD94F0 VA: 0x181FDA2F0
	public static bool GetNextAttribute(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x1FD97E0 Offset: 0x1FD89E0 VA: 0x181FD97E0
	public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x1FD9B10 Offset: 0x1FD8D10 VA: 0x181FD9B10
	public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x1FDA410 Offset: 0x1FD9610 VA: 0x181FDA410
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x1FDA2B0 Offset: 0x1FD94B0 VA: 0x181FDA2B0
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1FD9B80 Offset: 0x1FD8D80 VA: 0x181FD9B80
	public static bool GetElementChild(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	// RVA: 0x1FD9FC0 Offset: 0x1FD91C0 VA: 0x181FD9FC0
	public static bool GetElementSibling(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	// RVA: 0x1FD96A0 Offset: 0x1FD88A0 VA: 0x181FD96A0
	public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) { }

	// RVA: 0x1FD9A00 Offset: 0x1FD8C00 VA: 0x181FD9A00
	public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) { }

	// RVA: 0x1FD9500 Offset: 0x1FD8700 VA: 0x181FD9500
	public static bool GetAttribute(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	// RVA: 0x1FD9CB0 Offset: 0x1FD8EB0 VA: 0x181FD9CB0
	public static bool GetElementFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName) { }

	// RVA: 0x1FD98B0 Offset: 0x1FD8AB0 VA: 0x181FD98B0
	public static bool GetContentFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ) { }

	// RVA: 0x1FDA470 Offset: 0x1FD9670 VA: 0x181FDA470
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x1FDA370 Offset: 0x1FD9570 VA: 0x181FDA370
	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x1FD9650 Offset: 0x1FD8850 VA: 0x181FD9650
	private static void GetChild(ref XPathNode[] pageNode, ref int idxNode) { }
}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodePageInfo // TypeDefIndex: 12594
{
	// Fields
	private int _pageNum; // 0x10
	private int _nodeCount; // 0x14
	private XPathNode[] _pageNext; // 0x18

	// Properties
	public int PageNumber { get; }
	public int NodeCount { get; }
	public XPathNode[] NextPage { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_PageNumber() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_NodeCount() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public XPathNode[] get_NextPage() { }
}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodeInfoAtom // TypeDefIndex: 12595
{
	// Fields
	private string _localName; // 0x10
	private string _namespaceUri; // 0x18
	private string _prefix; // 0x20
	private string _baseUri; // 0x28
	private XPathNode[] _pageParent; // 0x30
	private XPathNode[] _pageSibling; // 0x38
	private XPathNode[] _pageSimilar; // 0x40
	private XPathDocument _doc; // 0x48
	private int _lineNumBase; // 0x50
	private int _linePosBase; // 0x54
	private XPathNodePageInfo _pageInfo; // 0x58

	// Properties
	public XPathNodePageInfo PageInfo { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public string Prefix { get; }
	public string BaseUri { get; }
	public XPathNode[] SiblingPage { get; }
	public XPathNode[] SimilarElementPage { get; }
	public XPathNode[] ParentPage { get; }
	public XPathDocument Document { get; }
	public int LineNumberBase { get; }
	public int LinePositionBase { get; }

	// Methods

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_LocalName() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_NamespaceUri() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Prefix() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_BaseUri() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public XPathNode[] get_SimilarElementPage() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public XPathDocument get_Document() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public int get_LineNumberBase() { }

	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	public int get_LinePositionBase() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 // TypeDefIndex: 12596
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 12597
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 // TypeDefIndex: 12598
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 12599
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 // TypeDefIndex: 12600
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 // TypeDefIndex: 12601
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 12602
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 // TypeDefIndex: 12603
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 // TypeDefIndex: 12604
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 // TypeDefIndex: 12605
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 // TypeDefIndex: 12606
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 // TypeDefIndex: 12607
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 12608
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 // TypeDefIndex: 12609
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 // TypeDefIndex: 12610
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 // TypeDefIndex: 12611
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 // TypeDefIndex: 12612
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=664 // TypeDefIndex: 12613
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 // TypeDefIndex: 12614
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1212 // TypeDefIndex: 12615
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 12616
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 0C682AB2EF0F1E326972C95528BBDE965F5D2DA9232E7A946F6E8A978A2871B5 /*Metadata offset 0x8DC170*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 11047585FE102FBB5CADB42446612A578D88C6EF5ED076BB7AC360C4F9E4373D /*Metadata offset 0x8DC1B8*/; // 0x44
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 21AFB7EF8B4B88C006C54601484BC15AE5A8DBD2C0DD8C6622109208F8511B82 /*Metadata offset 0x8DC1C8*/; // 0x50
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 24F70FC64555D9B7646AD4C0EEB8DF5286779F0E39C15ACA61305BC4A5E40BE6 /*Metadata offset 0x8DC590*/; // 0x410
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 28045F5AB2D9A9593F1D95B0FCB77E7F5F5435DD654BAFEF68972344B51C71BD /*Metadata offset 0x8DC5C0*/; // 0x438
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 28057B619BAF672A05E1585ED28F174E67FE946D81BDAA0691F07AB772057B02 /*Metadata offset 0x8DC658*/; // 0x4C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1212 2809A17B374DF1926EA539548F5B3750AA8ADB2BD59F5066AD6F9D439A231122 /*Metadata offset 0x8DC6D0*/; // 0x538
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 2AE470BFECE0EB971895252403237B3B989F74AD83E2B858E9CEA0482E776123 /*Metadata offset 0x8DCB90*/; // 0x9F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 2BA62518D59E3AF30E09E458218C4A05E5DFA2949B8B8F9B5E68CC793DBFA882 /*Metadata offset 0x8DCBA8*/; // 0xA08
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 2D902EC9D8EA71E1193C1C8315B1553D5154744F651BD366F1E1F437F6594A94 /*Metadata offset 0x8DCBD8*/; // 0xA30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3B3045573362001FA1CDA1F381A331DB2A88DD59FDD9C497404D59995AA377EA /*Metadata offset 0x8DCC00*/; // 0xA54
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 3EB9B3AB77D567D5CEBF38C4C91CDF79845F0691D47A516CE6981BF091025179 /*Metadata offset 0x8DCC10*/; // 0xA60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 499E4F5C84E20C7347E10100E0EC90C1945EA21C7C80809E4F7F474179B39DF6 /*Metadata offset 0x8DCC30*/; // 0xA78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 540CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D /*Metadata offset 0x8DCC50*/; // 0xA94
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 58E18897FE5FF048E82310FB4F57ADB2D53AEE59CB49B1E7094439808A1EF3F6 /*Metadata offset 0x8DCC78*/; // 0xABA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 5B7F03A977BE72EBD5C1702238238AEB01DFFB019B05EFAAC147EF886732EDC7 /*Metadata offset 0x8DCCC0*/; // 0xAFE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 652CA39E9310E001C2C4AF271610032A5638C58598F727066CCF4E666D424CD4 /*Metadata offset 0x8DCCD0*/; // 0xB0A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 6536D9B2447DFCF9BA37F9E5A7FAB08CB5552C5AD5B20E019AEC4872283A542A /*Metadata offset 0x8DCCF8*/; // 0xB2A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 77186ED8B389D5640B5AFAC4A22526ABA2422DCBE2986D0032E3B035D175758D /*Metadata offset 0x8DCD20*/; // 0xB4E
	internal static readonly long 8A36CBC1D17EC6E1CCFE7D67F79FA9C8B2D7A41B04DD58A76970CEDC8189210D = 361700859878507267; // 0xF10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 8D4DC488705859D6A837A660BDBA9E88D1BD229BC39DB97734072D04BD513ECD /*Metadata offset 0x8DD0F8*/; // 0xF18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 92E9BC30656BF079FC6B0A200B019FF46941857D786F4C391470394CFDC95F0B /*Metadata offset 0x8DD120*/; // 0xF3C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 9DA6B2C4638D1DC7611B7F458BBFE7FD49FE1B36B67239B00B8A051F4E49558F /*Metadata offset 0x8DD148*/; // 0xF5C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 AD6E77E234021D825C77689D82D414CDA3ABAE1ACC346D4BA2D6B1876CFC5FBC /*Metadata offset 0x8DD170*/; // 0xF7C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 B21FC5E8DB69C99CDEFB2C460E7C26D2D29A5ADC302365C59766D13688236919 /*Metadata offset 0x8DD1B8*/; // 0xFBC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 B6E5AC1B0927F4259775820D36453E7BD957F110874896C133234263D312D88E /*Metadata offset 0x8DD1D0*/; // 0xFD0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C332DD23F2CF4DE6107A93045ACACD787E2D9EB18B213298B98F23357F4FEA41 /*Metadata offset 0x8DD200*/; // 0xFFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 C3B2BED2599F3C79640DE44BA4EC7AEBB4856DBF74059DF382CF1D3026D272DA /*Metadata offset 0x8DD218*/; // 0x100C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 D1D9AF18AFC4E3074AF5E4C44B81B73889D033D7AF6DFEB387BBCC76B36FE8B9 /*Metadata offset 0x8DD228*/; // 0x1018
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 DA285BBFE8FD0AA22C7CB92A1E911A4206CEDB14132FE3B6EE4DB32A42CAA41D /*Metadata offset 0x8DD3D0*/; // 0x11B8
	internal static readonly long DACC0E6568D9B10337A1A693F10D42C3175E80C378154406C6FBFA989F919F51 = 3659217647501344; // 0x11D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DB047CC748613CCCB120DE7385E37D542A79C3BF8F0E64FE6DAD349B4D26E5D7 /*Metadata offset 0x8DD400*/; // 0x11D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 DB7DD2341DB9D4574E432AAAFF03FB0A3E8FF2F645A337077EDF0C6FE902E660 /*Metadata offset 0x8DD440*/; // 0x1210
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 DBBF94CCF4250B303976041627BB8FC302CE57D55373C469F41F97318412037D /*Metadata offset 0x8DD5E8*/; // 0x13B0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=664 DD4E9C7C140CABCA5A25F4DA1F6F5BAC5D74E4568F954BF728471E711A35163E /*Metadata offset 0x8DD5F0*/; // 0x13B6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 EC3DA4AD81BE65581D24158F5E1FCDA45D908C27EC29FDFA744995062C501501 /*Metadata offset 0x8DD890*/; // 0x164E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 EE2DCBE09BA7FF21BF36DD7FC218E094C9B3EF228148D28D21D77A0FE51553C6 /*Metadata offset 0x8DD8A8*/; // 0x165E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 F1A5C5E949D525C31B086947AF16513F4999646B513457629847081D039048ED /*Metadata offset 0x8DD8C8*/; // 0x1676
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 FFF813C50ED1BEC943E2CA58860CC34E0A14A5C0E858B97C7670A384005CC064 /*Metadata offset 0x8DD8E0*/; // 0x1686

	// Methods

	// RVA: 0x840E00 Offset: 0x840000 VA: 0x180840E00
	internal static uint ComputeStringHash(string s) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 12617
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 12618
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 12619
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1DD4160 Offset: 0x1DD3360 VA: 0x181DD4160
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 12620
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(byte ) { }
}

// Namespace: 
internal static class SR // TypeDefIndex: 12621
{
	// Methods

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	internal static string GetString(string name) { }

	// RVA: 0x1DD4400 Offset: 0x1DD3600 VA: 0x181DD4400
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x1DD4380 Offset: 0x1DD3580 VA: 0x181DD4380
	internal static string Format(string resourceFormat, object p1, object p2) { }

	// RVA: 0x1DD42F0 Offset: 0x1DD34F0 VA: 0x181DD42F0
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }
}

// Namespace: System
internal static class LocalAppContextSwitches // TypeDefIndex: 12622
{
	// Fields
	private static int s_allowArbitraryTypeInstantiation; // 0x0

	// Properties
	public static bool AllowArbitraryTypeInstantiation { get; }

	// Methods

	// RVA: 0x1DD3D60 Offset: 0x1DD2F60 VA: 0x181DD3D60
	public static bool get_AllowArbitraryTypeInstantiation() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LocalAppContext.<>c // TypeDefIndex: 12623
{
	// Fields
	public static readonly LocalAppContext.<>c <>9; // 0x0
	public static Func<bool> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x1DD44E0 Offset: 0x1DD36E0 VA: 0x181DD44E0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1DD4470 Offset: 0x1DD3670 VA: 0x181DD4470
	internal bool <get_DisableCaching>b__6_0() { }
}

// Namespace: System
internal class LocalAppContext // TypeDefIndex: 12624
{
	// Fields
	private static bool s_isDisableCachingInitialized; // 0x0
	private static bool s_disableCaching; // 0x1
	private static object s_syncObject; // 0x8

	// Properties
	private static bool DisableCaching { get; }

	// Methods

	// RVA: 0x1DD3F80 Offset: 0x1DD3180 VA: 0x181DD3F80
	internal static bool GetCachedSwitchValue(string switchName, ref int switchValue) { }

	// RVA: 0x1DD3DD0 Offset: 0x1DD2FD0 VA: 0x181DD3DD0
	private static bool GetCachedSwitchValueInternal(string switchName, ref int switchValue) { }

	// RVA: 0x1DD3FA0 Offset: 0x1DD31A0 VA: 0x181DD3FA0
	private static bool get_DisableCaching() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
[ToolboxItem(False)]
[DefaultProperty("ColumnName")]
[DesignTimeVisible(False)]
public class DataColumn : MarshalByValueComponent // TypeDefIndex: 12625
{
	// Fields
	private bool _allowNull; // 0x20
	private string _caption; // 0x28
	private string _columnName; // 0x30
	private Type _dataType; // 0x38
	private StorageType _storageType; // 0x40
	internal object _defaultValue; // 0x48
	private DataSetDateTime _dateTimeMode; // 0x50
	private DataExpression _expression; // 0x58
	private int _maxLength; // 0x60
	private int _ordinal; // 0x64
	private bool _readOnly; // 0x68
	internal Index _sortIndex; // 0x70
	internal DataTable _table; // 0x78
	private bool _unique; // 0x80
	internal MappingType _columnMapping; // 0x84
	internal int _hashCode; // 0x88
	internal int _errors; // 0x8C
	private bool _isSqlType; // 0x90
	private bool _implementsINullable; // 0x91
	private bool _implementsIChangeTracking; // 0x92
	private bool _implementsIRevertibleChangeTracking; // 0x93
	private bool _implementsIXMLSerializable; // 0x94
	private bool _defaultValueIsNull; // 0x95
	internal List<DataColumn> _dependentColumns; // 0x98
	internal PropertyCollection _extendedProperties; // 0xA0
	private DataStorage _storage; // 0xA8
	private AutoIncrementValue _autoInc; // 0xB0
	internal string _columnUri; // 0xB8
	private string _columnPrefix; // 0xC0
	internal string _encodedColumnName; // 0xC8
	internal SimpleType _simpleType; // 0xD0
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0xD8
	[CompilerGenerated]
	private string <XmlDataType>k__BackingField; // 0xE0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0xE8

	// Properties
	[DefaultValue(True)]
	public bool AllowDBNull { get; set; }
	[RefreshProperties(1)]
	[DefaultValue(False)]
	public bool AutoIncrement { get; set; }
	internal object AutoIncrementCurrent { get; set; }
	internal AutoIncrementValue AutoInc { get; }
	[DefaultValue(0)]
	public long AutoIncrementSeed { get; set; }
	[DefaultValue(1)]
	public long AutoIncrementStep { get; set; }
	public string Caption { get; set; }
	[RefreshProperties(1)]
	[DefaultValue("")]
	public string ColumnName { get; set; }
	internal string EncodedColumnName { get; }
	internal IFormatProvider FormatProvider { get; }
	internal CultureInfo Locale { get; }
	internal int ObjectID { get; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal bool Computed { get; }
	internal DataExpression DataExpression { get; }
	[DefaultValue(typeof(string))]
	[RefreshProperties(1)]
	[TypeConverter(typeof(ColumnTypeConverter))]
	public Type DataType { get; set; }
	[RefreshProperties(1)]
	[DefaultValue(3)]
	public DataSetDateTime DateTimeMode { get; set; }
	[TypeConverter(typeof(DefaultValueTypeConverter))]
	public object DefaultValue { get; set; }
	internal bool DefaultValueIsNull { get; }
	[RefreshProperties(1)]
	[DefaultValue("")]
	public string Expression { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool HasData { get; }
	internal bool ImplementsINullable { get; }
	internal bool ImplementsIChangeTracking { get; }
	internal bool ImplementsIRevertibleChangeTracking { get; }
	internal bool IsValueType { get; }
	internal bool IsSqlType { get; }
	[DefaultValue(-1)]
	public int MaxLength { get; set; }
	public string Namespace { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public int Ordinal { get; }
	[DefaultValue(False)]
	public bool ReadOnly { get; set; }
	[DebuggerBrowsable(0)]
	private Index SortIndex { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataTable Table { get; }
	internal object Item { get; set; }
	[DesignerSerializationVisibility(0)]
	[DefaultValue(False)]
	public bool Unique { get; set; }
	internal string XmlDataType { get; set; }
	internal SimpleType SimpleType { get; set; }
	[DefaultValue(1)]
	public virtual MappingType ColumnMapping { get; set; }
	internal bool IsCustomType { get; }
	internal bool ImplementsIXMLSerializable { get; }

	// Methods

	// RVA: 0x1DB4530 Offset: 0x1DB3730 VA: 0x181DB4530
	public void .ctor() { }

	// RVA: 0x1DB4500 Offset: 0x1DB3700 VA: 0x181DB4500
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0x1DB45C0 Offset: 0x1DB37C0 VA: 0x181DB45C0
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0x1DB4400 Offset: 0x1DB3600 VA: 0x181DB4400
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_AllowDBNull() { }

	// RVA: 0x1DB50B0 Offset: 0x1DB42B0 VA: 0x181DB50B0
	public void set_AllowDBNull(bool value) { }

	// RVA: 0x1DB4AE0 Offset: 0x1DB3CE0 VA: 0x181DB4AE0
	public bool get_AutoIncrement() { }

	// RVA: 0x1DB55C0 Offset: 0x1DB47C0 VA: 0x181DB55C0
	public void set_AutoIncrement(bool value) { }

	// RVA: 0x1DB4A10 Offset: 0x1DB3C10 VA: 0x181DB4A10
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0x1DB5200 Offset: 0x1DB4400 VA: 0x181DB5200
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0x1DB4910 Offset: 0x1DB3B10 VA: 0x181DB4910
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0x1DB4A80 Offset: 0x1DB3C80 VA: 0x181DB4A80
	public long get_AutoIncrementSeed() { }

	// RVA: 0x1DB53B0 Offset: 0x1DB45B0 VA: 0x181DB53B0
	public void set_AutoIncrementSeed(long value) { }

	// RVA: 0x1DB4AB0 Offset: 0x1DB3CB0 VA: 0x181DB4AB0
	public long get_AutoIncrementStep() { }

	// RVA: 0x1DB54B0 Offset: 0x1DB46B0 VA: 0x181DB54B0
	public void set_AutoIncrementStep(long value) { }

	// RVA: 0x1DB4B00 Offset: 0x1DB3D00 VA: 0x181DB4B00
	public string get_Caption() { }

	// RVA: 0x1DB57C0 Offset: 0x1DB49C0 VA: 0x181DB57C0
	public void set_Caption(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_ColumnName() { }

	// RVA: 0x1DB5B40 Offset: 0x1DB4D40 VA: 0x181DB5B40
	public void set_ColumnName(string value) { }

	// RVA: 0x1DB4C70 Offset: 0x1DB3E70 VA: 0x181DB4C70
	internal string get_EncodedColumnName() { }

	// RVA: 0x1DB4DA0 Offset: 0x1DB3FA0 VA: 0x181DB4DA0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1DB4F00 Offset: 0x1DB4100 VA: 0x181DB4F00
	internal CultureInfo get_Locale() { }

	// RVA: 0x190DC20 Offset: 0x190CE20 VA: 0x18190DC20
	internal int get_ObjectID() { }

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0
	public string get_Prefix() { }

	// RVA: 0x1DB7DC0 Offset: 0x1DB6FC0 VA: 0x181DB7DC0
	public void set_Prefix(string value) { }

	// RVA: 0x1DB2D20 Offset: 0x1DB1F20 VA: 0x181DB2D20
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0x780880 Offset: 0x77FA80 VA: 0x180780880
	internal bool get_Computed() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal DataExpression get_DataExpression() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Type get_DataType() { }

	// RVA: 0x1DB5F20 Offset: 0x1DB5120 VA: 0x181DB5F20
	public void set_DataType(Type value) { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1DB6A70 Offset: 0x1DB5C70 VA: 0x181DB6A70
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0x1DB4B30 Offset: 0x1DB3D30 VA: 0x181DB4B30
	public object get_DefaultValue() { }

	// RVA: 0x1DB6BF0 Offset: 0x1DB5DF0 VA: 0x181DB6BF0
	public void set_DefaultValue(object value) { }

	// RVA: 0x1DB4B20 Offset: 0x1DB3D20 VA: 0x181DB4B20
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0x1DB1900 Offset: 0x1DB0B00 VA: 0x181DB1900
	internal void BindExpression() { }

	// RVA: 0x1DB4CE0 Offset: 0x1DB3EE0 VA: 0x181DB4CE0
	public string get_Expression() { }

	// RVA: 0x1DB6EF0 Offset: 0x1DB60F0 VA: 0x181DB6EF0
	public void set_Expression(string value) { }

	// RVA: 0x1DB4D30 Offset: 0x1DB3F30 VA: 0x181DB4D30
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1DB4E00 Offset: 0x1DB4000 VA: 0x181DB4E00
	internal bool get_HasData() { }

	// RVA: 0x8663E0 Offset: 0x8655E0 VA: 0x1808663E0
	internal bool get_ImplementsINullable() { }

	// RVA: 0x1DB4E10 Offset: 0x1DB4010 VA: 0x181DB4E10
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0x1DB4E20 Offset: 0x1DB4020 VA: 0x181DB4E20
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0x1DB4EB0 Offset: 0x1DB40B0 VA: 0x181DB4EB0
	internal bool get_IsValueType() { }

	// RVA: 0x5C4DE0 Offset: 0x5C3FE0 VA: 0x1805C4DE0
	internal bool get_IsSqlType() { }

	// RVA: 0x1DB3F60 Offset: 0x1DB3160 VA: 0x181DB3F60
	private void SetMaxLengthSimpleType() { }

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public int get_MaxLength() { }

	// RVA: 0x1DB7850 Offset: 0x1DB6A50 VA: 0x181DB7850
	public void set_MaxLength(int value) { }

	// RVA: 0x1DB4F60 Offset: 0x1DB4160 VA: 0x181DB4F60
	public string get_Namespace() { }

	// RVA: 0x1DB7C20 Offset: 0x1DB6E20 VA: 0x181DB7C20
	public void set_Namespace(string value) { }

	// RVA: 0x6772F0 Offset: 0x6764F0 VA: 0x1806772F0
	public int get_Ordinal() { }

	// RVA: 0x1DB4030 Offset: 0x1DB3230 VA: 0x181DB4030
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	public bool get_ReadOnly() { }

	// RVA: 0x1DB7F30 Offset: 0x1DB7130 VA: 0x181DB7F30
	public void set_ReadOnly(bool value) { }

	// RVA: 0x1DB4FE0 Offset: 0x1DB41E0 VA: 0x181DB4FE0
	private Index get_SortIndex() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public DataTable get_Table() { }

	// RVA: 0x1DB41B0 Offset: 0x1DB33B0 VA: 0x181DB41B0
	internal void SetTable(DataTable table) { }

	// RVA: 0x1DB2E10 Offset: 0x1DB2010 VA: 0x181DB2E10
	private DataRow GetDataRow(int index) { }

	// RVA: 0x1DB4ED0 Offset: 0x1DB40D0 VA: 0x181DB4ED0
	internal object get_Item(int record) { }

	// RVA: 0x1DB76B0 Offset: 0x1DB68B0 VA: 0x181DB76B0
	internal void set_Item(int record, object value) { }

	// RVA: 0x1DB3230 Offset: 0x1DB2430 VA: 0x181DB3230
	internal void InitializeRecord(int record) { }

	// RVA: 0x1DB4270 Offset: 0x1DB3470 VA: 0x181DB4270
	internal void SetValue(int record, object value) { }

	// RVA: 0x1DB2BF0 Offset: 0x1DB1DF0 VA: 0x181DB2BF0
	internal void FreeRecord(int record) { }

	// RVA: 0x67AA00 Offset: 0x679C00 VA: 0x18067AA00
	public bool get_Unique() { }

	// RVA: 0x1DB8060 Offset: 0x1DB7260 VA: 0x181DB8060
	public void set_Unique(bool value) { }

	// RVA: 0x67AD80 Offset: 0x679F80 VA: 0x18067AD80
	internal void InternalUnique(bool value) { }

	[CompilerGenerated]
	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	internal string get_XmlDataType() { }

	[CompilerGenerated]
	// RVA: 0x8A5A60 Offset: 0x8A4C60 VA: 0x1808A5A60
	internal void set_XmlDataType(string value) { }

	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	internal SimpleType get_SimpleType() { }

	// RVA: 0x1DB8010 Offset: 0x1DB7210 VA: 0x181DB8010
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0x772260 Offset: 0x771460 VA: 0x180772260 Slot: 16
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0x1DB5890 Offset: 0x1DB4A90 VA: 0x181DB5890 Slot: 17
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0x1DB1930 Offset: 0x1DB0B30 VA: 0x181DB1930
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x1DB1AF0 Offset: 0x1DB0CF0 VA: 0x181DB1AF0
	internal bool CheckMaxLength() { }

	// RVA: 0x1DB1A60 Offset: 0x1DB0C60 VA: 0x181DB1A60
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0x1DB1D60 Offset: 0x1DB0F60 VA: 0x181DB1D60
	protected internal void CheckNotAllowNull() { }

	// RVA: 0x1DB2090 Offset: 0x1DB1290 VA: 0x181DB2090
	internal void CheckNullable(DataRow row) { }

	// RVA: 0x1DB2120 Offset: 0x1DB1320 VA: 0x181DB2120
	protected void CheckUnique() { }

	// RVA: 0x1DB29A0 Offset: 0x1DB1BA0 VA: 0x181DB29A0
	internal int Compare(int record1, int record2) { }

	// RVA: 0x1DB2760 Offset: 0x1DB1960 VA: 0x181DB2760
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0x1DB2970 Offset: 0x1DB1B70 VA: 0x181DB2970
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0x1DB2A90 Offset: 0x1DB1C90 VA: 0x181DB2A90
	internal object ConvertValue(object value) { }

	// RVA: 0x1DB2BA0 Offset: 0x1DB1DA0 VA: 0x181DB2BA0
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0x1DB2180 Offset: 0x1DB1380 VA: 0x181DB2180
	internal DataColumn Clone() { }

	// RVA: 0x1DB2C30 Offset: 0x1DB1E30 VA: 0x181DB2C30
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0x1DB2E80 Offset: 0x1DB2080 VA: 0x181DB2E80
	private int GetStringLength(int record) { }

	// RVA: 0x1DB3160 Offset: 0x1DB2360 VA: 0x181DB3160
	internal void Init(int record) { }

	// RVA: 0x1DB3300 Offset: 0x1DB2500 VA: 0x181DB3300
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0x1DB4E40 Offset: 0x1DB4040 VA: 0x181DB4E40
	internal bool get_IsCustomType() { }

	// RVA: 0x1DB3CF0 Offset: 0x1DB2EF0 VA: 0x181DB3CF0
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0x1DB4E30 Offset: 0x1DB4030 VA: 0x181DB4E30
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0x1DB35C0 Offset: 0x1DB27C0 VA: 0x181DB35C0
	internal bool IsInRelation() { }

	// RVA: 0x1DB3710 Offset: 0x1DB2910 VA: 0x181DB3710
	internal bool IsMaxLengthViolated() { }

	// RVA: 0x1DB3B40 Offset: 0x1DB2D40 VA: 0x181DB3B40
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0x1DB2BD0 Offset: 0x1DB1DD0 VA: 0x181DB2BD0
	internal void FinishInitInProgress() { }

	// RVA: 0x1DB3DC0 Offset: 0x1DB2FC0 VA: 0x181DB3DC0 Slot: 18
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1DB3DF0 Offset: 0x1DB2FF0 VA: 0x181DB3DF0
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1DB3280 Offset: 0x1DB2480 VA: 0x181DB3280
	private void InsureStorage() { }

	// RVA: 0x1DB3F10 Offset: 0x1DB3110 VA: 0x181DB3F10
	internal void SetCapacity(int capacity) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void OnSetDataSet() { }

	// RVA: 0x1DB4360 Offset: 0x1DB3560 VA: 0x181DB4360 Slot: 3
	public override string ToString() { }

	// RVA: 0x1DB2AC0 Offset: 0x1DB1CC0 VA: 0x181DB2AC0
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0x1DB2B10 Offset: 0x1DB1D10 VA: 0x181DB2B10
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1DB29D0 Offset: 0x1DB1BD0 VA: 0x181DB29D0
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0x1DB2A20 Offset: 0x1DB1C20 VA: 0x181DB2A20
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1DB2E40 Offset: 0x1DB2040 VA: 0x181DB2E40
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0x1DB2B70 Offset: 0x1DB1D70 VA: 0x181DB2B70
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1DB4160 Offset: 0x1DB3360 VA: 0x181DB4160
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1DB1800 Offset: 0x1DB0A00 VA: 0x181DB1800
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1DB3E70 Offset: 0x1DB3070 VA: 0x181DB3E70
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1DB2EB0 Offset: 0x1DB20B0 VA: 0x181DB2EB0
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }
}

// Namespace: System.Data
internal abstract class AutoIncrementValue // TypeDefIndex: 12626
{
	// Fields
	[CompilerGenerated]
	private bool <Auto>k__BackingField; // 0x10

	// Properties
	internal bool Auto { get; set; }
	internal abstract object Current { get; set; }
	internal abstract long Seed { get; set; }
	internal abstract long Step { get; set; }
	internal abstract Type DataType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	internal bool get_Auto() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void set_Auto(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void set_Current(object value);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract long get_Seed();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void set_Seed(long value);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract long get_Step();

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void set_Step(long value);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract Type get_DataType();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract void SetCurrent(object value, IFormatProvider formatProvider);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract void SetCurrentAndIncrement(object value);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void MoveAfter();

	// RVA: 0x1DB1580 Offset: 0x1DB0780 VA: 0x181DB1580
	internal AutoIncrementValue Clone() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Data
internal sealed class AutoIncrementInt64 : AutoIncrementValue // TypeDefIndex: 12627
{
	// Fields
	private long _current; // 0x18
	private long _seed; // 0x20
	private long _step; // 0x28

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x1DB1340 Offset: 0x1DB0540 VA: 0x181DB1340 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1DB13F0 Offset: 0x1DB05F0 VA: 0x181DB13F0 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x1DB1390 Offset: 0x1DB0590 VA: 0x181DB1390 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1DB1460 Offset: 0x1DB0660 VA: 0x181DB1460 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1DB14F0 Offset: 0x1DB06F0 VA: 0x181DB14F0 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1DB1150 Offset: 0x1DB0350 VA: 0x181DB1150 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x1DB12C0 Offset: 0x1DB04C0 VA: 0x181DB12C0 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1DB1160 Offset: 0x1DB0360 VA: 0x181DB1160 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1DB1080 Offset: 0x1DB0280 VA: 0x181DB1080
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x1DB1330 Offset: 0x1DB0530 VA: 0x181DB1330
	public void .ctor() { }
}

// Namespace: System.Data
internal sealed class AutoIncrementBigInteger : AutoIncrementValue // TypeDefIndex: 12628
{
	// Fields
	private BigInteger _current; // 0x18
	private long _seed; // 0x28
	private BigInteger _step; // 0x30

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x1DB0C40 Offset: 0x1DAFE40 VA: 0x181DB0C40 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1DB0D50 Offset: 0x1DAFF50 VA: 0x181DB0D50 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x1DB0C90 Offset: 0x1DAFE90 VA: 0x181DB0C90 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1DB0DC0 Offset: 0x1DAFFC0 VA: 0x181DB0DC0 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x1DB0CF0 Offset: 0x1DAFEF0 VA: 0x181DB0CF0 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1DB0EC0 Offset: 0x1DB00C0 VA: 0x181DB0EC0 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1DB0A20 Offset: 0x1DAFC20 VA: 0x181DB0A20 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x1DB0BA0 Offset: 0x1DAFDA0 VA: 0x181DB0BA0 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1DB0AB0 Offset: 0x1DAFCB0 VA: 0x181DB0AB0 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1DB08E0 Offset: 0x1DAFAE0 VA: 0x181DB08E0
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x1DB0BD0 Offset: 0x1DAFDD0 VA: 0x181DB0BD0
	public void .ctor() { }
}

// Namespace: System.Data
[Serializable]
public class DataException : SystemException // TypeDefIndex: 12629
{
	// Methods

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DB84A0 Offset: 0x1DB76A0 VA: 0x181DB84A0
	public void .ctor() { }

	// RVA: 0x1DB8480 Offset: 0x1DB7680 VA: 0x181DB8480
	public void .ctor(string s) { }

	// RVA: 0x1633A30 Offset: 0x1632C30 VA: 0x181633A30
	public void .ctor(string s, Exception innerException) { }
}

// Namespace: System.Data
[Serializable]
public class ConstraintException : DataException // TypeDefIndex: 12630
{
	// Methods

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DB1700 Offset: 0x1DB0900 VA: 0x181DB1700
	public void .ctor() { }

	// RVA: 0x1DB1750 Offset: 0x1DB0950 VA: 0x181DB1750
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class DeletedRowInaccessibleException : DataException // TypeDefIndex: 12631
{
	// Methods

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DC4890 Offset: 0x1DC3A90 VA: 0x181DC4890
	public void .ctor() { }

	// RVA: 0x1DC48E0 Offset: 0x1DC3AE0 VA: 0x181DC48E0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class DuplicateNameException : DataException // TypeDefIndex: 12632
{
	// Methods

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DC4920 Offset: 0x1DC3B20 VA: 0x181DC4920
	public void .ctor() { }

	// RVA: 0x1DC4900 Offset: 0x1DC3B00 VA: 0x181DC4900
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class InRowChangingEventException : DataException // TypeDefIndex: 12633
{
	// Methods

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DD3C80 Offset: 0x1DD2E80 VA: 0x181DD3C80
	public void .ctor() { }

	// RVA: 0x1DD3CD0 Offset: 0x1DD2ED0 VA: 0x181DD3CD0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class InvalidConstraintException : DataException // TypeDefIndex: 12634
{
	// Methods

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DD3D10 Offset: 0x1DD2F10 VA: 0x181DD3D10
	public void .ctor() { }

	// RVA: 0x1DD3CF0 Offset: 0x1DD2EF0 VA: 0x181DD3CF0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class NoNullAllowedException : DataException // TypeDefIndex: 12635
{
	// Methods

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DD4110 Offset: 0x1DD3310 VA: 0x181DD4110
	public void .ctor() { }

	// RVA: 0x1DD40F0 Offset: 0x1DD32F0 VA: 0x181DD40F0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class ReadOnlyException : DataException // TypeDefIndex: 12636
{
	// Methods

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DD41E0 Offset: 0x1DD33E0 VA: 0x181DD41E0
	public void .ctor() { }

	// RVA: 0x1DD4230 Offset: 0x1DD3430 VA: 0x181DD4230
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class RowNotInTableException : DataException // TypeDefIndex: 12637
{
	// Methods

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DD4280 Offset: 0x1DD3480 VA: 0x181DD4280
	public void .ctor() { }

	// RVA: 0x1DD42D0 Offset: 0x1DD34D0 VA: 0x181DD42D0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class VersionNotFoundException : DataException // TypeDefIndex: 12638
{
	// Methods

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DD4540 Offset: 0x1DD3740 VA: 0x181DD4540
	public void .ctor() { }

	// RVA: 0x1DD4590 Offset: 0x1DD3790 VA: 0x181DD4590
	public void .ctor(string s) { }
}

// Namespace: System.Data
internal static class ExceptionBuilder // TypeDefIndex: 12639
{
	// Methods

	// RVA: 0x1DCE960 Offset: 0x1DCDB60 VA: 0x181DCE960
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x1DCE720 Offset: 0x1DCD920 VA: 0x181DCE720
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x1DCE7E0 Offset: 0x1DCD9E0 VA: 0x181DCE7E0
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0x1DCE8A0 Offset: 0x1DCDAA0 VA: 0x181DCE8A0
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x1DCF1B0 Offset: 0x1DCE3B0 VA: 0x181DCF1B0
	internal static Exception _Argument(string error) { }

	// RVA: 0x1DCF0E0 Offset: 0x1DCE2E0 VA: 0x181DCF0E0
	internal static Exception _Argument(string paramName, string error) { }

	// RVA: 0x1DCF140 Offset: 0x1DCE340 VA: 0x181DCF140
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0x1DCF000 Offset: 0x1DCE200 VA: 0x181DCF000
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0x1DCF070 Offset: 0x1DCE270 VA: 0x181DCF070
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0x1DCF3D0 Offset: 0x1DCE5D0 VA: 0x181DCF3D0
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0x1DCF500 Offset: 0x1DCE700 VA: 0x181DCF500
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0x1DCF4A0 Offset: 0x1DCE6A0 VA: 0x181DCF4A0
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: -1 Offset: -1
	private static Exception _InvalidEnumArgumentException<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A1290 Offset: 0x9A0490 VA: 0x1809A1290
	|-ExceptionBuilder._InvalidEnumArgumentException<Int32Enum>
	|
	|-RVA: 0x9A1130 Offset: 0x9A0330 VA: 0x1809A1130
	|-ExceptionBuilder._InvalidEnumArgumentException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1DCE5D0 Offset: 0x1DCD7D0 VA: 0x181DCE5D0
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0x1DCAC90 Offset: 0x1DC9E90 VA: 0x181DCAC90
	private static Exception _Data(string error) { }

	// RVA: 0x1DCF210 Offset: 0x1DCE410 VA: 0x181DCF210
	private static Exception _Constraint(string error) { }

	// RVA: 0x1DCF430 Offset: 0x1DCE630 VA: 0x181DCF430
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0x1DCF280 Offset: 0x1DCE480 VA: 0x181DCF280
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0x1DCF2F0 Offset: 0x1DCE4F0 VA: 0x181DCF2F0
	private static Exception _DuplicateName(string error) { }

	// RVA: 0x1DCF360 Offset: 0x1DCE560 VA: 0x181DCF360
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0x1DCF560 Offset: 0x1DCE760 VA: 0x181DCF560
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0x1DCF5D0 Offset: 0x1DCE7D0 VA: 0x181DCF5D0
	private static Exception _ReadOnly(string error) { }

	// RVA: 0x1DCF640 Offset: 0x1DCE840 VA: 0x181DCF640
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0x1DCF6B0 Offset: 0x1DCE8B0 VA: 0x181DCF6B0
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0x1DC4CD0 Offset: 0x1DC3ED0 VA: 0x181DC4CD0
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0x1DC4DB0 Offset: 0x1DC3FB0 VA: 0x181DC4DB0
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x1DC5190 Offset: 0x1DC4390 VA: 0x181DC5190
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0x1DC4C00 Offset: 0x1DC3E00 VA: 0x181DC4C00
	public static Exception ArgumentContainsNull(string paramName) { }

	// RVA: 0x1DCE9F0 Offset: 0x1DCDBF0 VA: 0x181DCE9F0
	public static Exception TypeNotAllowed(Type type) { }

	// RVA: 0x1DC6190 Offset: 0x1DC5390 VA: 0x181DC6190
	public static Exception CannotModifyCollection() { }

	// RVA: 0x1DC6BC0 Offset: 0x1DC5DC0 VA: 0x181DC6BC0
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0x1DCB270 Offset: 0x1DCA470 VA: 0x181DCB270
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0x1DC9DB0 Offset: 0x1DC8FB0 VA: 0x181DC9DB0
	public static Exception InvalidOffsetLength() { }

	// RVA: 0x1DC6F60 Offset: 0x1DC6160 VA: 0x181DC6F60
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0x1DC6EE0 Offset: 0x1DC60E0 VA: 0x181DC6EE0
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0x1DC7000 Offset: 0x1DC6200 VA: 0x181DC7000
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0x1DC7110 Offset: 0x1DC6310 VA: 0x181DC7110
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0x1DC5950 Offset: 0x1DC4B50 VA: 0x181DC5950
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0x1DC5A20 Offset: 0x1DC4C20 VA: 0x181DC5A20
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0x1DC5AF0 Offset: 0x1DC4CF0 VA: 0x181DC5AF0
	public static Exception CannotAddColumn3() { }

	// RVA: 0x1DC5B70 Offset: 0x1DC4D70 VA: 0x181DC5B70
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0x1DC5DE0 Offset: 0x1DC4FE0 VA: 0x181DC5DE0
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0x1DC5C40 Offset: 0x1DC4E40 VA: 0x181DC5C40
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0x1DC5D10 Offset: 0x1DC4F10 VA: 0x181DC5D10
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0x1DC62E0 Offset: 0x1DC54E0 VA: 0x181DC62E0
	public static Exception CannotRemoveColumn() { }

	// RVA: 0x1DC64A0 Offset: 0x1DC56A0 VA: 0x181DC64A0
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0x1DC6210 Offset: 0x1DC5410 VA: 0x181DC6210
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0x1DC6360 Offset: 0x1DC5560 VA: 0x181DC6360
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0x1DC6400 Offset: 0x1DC5600 VA: 0x181DC6400
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0x1DC4A80 Offset: 0x1DC3C80 VA: 0x181DC4A80
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0x1DCB570 Offset: 0x1DCA770 VA: 0x181DCB570
	public static Exception NoConstraintName() { }

	// RVA: 0x1DC7860 Offset: 0x1DC6A60 VA: 0x181DC7860
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0x1DCA930 Offset: 0x1DC9B30 VA: 0x181DCA930
	public static string KeysToString(object[] keys) { }

	// RVA: 0x1DCED10 Offset: 0x1DCDF10 VA: 0x181DCED10
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0x1DC77F0 Offset: 0x1DC69F0 VA: 0x181DC77F0
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0x1DC75E0 Offset: 0x1DC67E0 VA: 0x181DC75E0
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0x1DC8400 Offset: 0x1DC7600 VA: 0x181DC8400
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0x1DC8260 Offset: 0x1DC7460 VA: 0x181DC8260
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0x1DCB340 Offset: 0x1DCA540 VA: 0x181DCB340
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0x1DCEF00 Offset: 0x1DCE100 VA: 0x181DCEF00
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0x1DC7560 Offset: 0x1DC6760 VA: 0x181DC7560
	public static Exception ConstraintForeignTable() { }

	// RVA: 0x1DC76F0 Offset: 0x1DC68F0 VA: 0x181DC76F0
	public static Exception ConstraintParentValues() { }

	// RVA: 0x1DC7470 Offset: 0x1DC6670 VA: 0x181DC7470
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0x1DC7770 Offset: 0x1DC6970 VA: 0x181DC7770
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0x1DC8E00 Offset: 0x1DC8000 VA: 0x181DC8E00
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0x1DC8ED0 Offset: 0x1DC80D0 VA: 0x181DC8ED0
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0x1DC8FA0 Offset: 0x1DC81A0 VA: 0x181DC8FA0
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0x1DC9050 Offset: 0x1DC8250 VA: 0x181DC9050
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0x1DCCDF0 Offset: 0x1DCBFF0 VA: 0x181DCCDF0
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0x1DCAC00 Offset: 0x1DC9E00 VA: 0x181DCAC00
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0x1DCB8F0 Offset: 0x1DCAAF0 VA: 0x181DCB8F0
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0x1DC6980 Offset: 0x1DC5B80 VA: 0x181DC6980
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0x1DC4FC0 Offset: 0x1DC41C0 VA: 0x181DC4FC0
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0x1DC4F40 Offset: 0x1DC4140 VA: 0x181DC4F40
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0x1DC5110 Offset: 0x1DC4310 VA: 0x181DC5110
	public static Exception AutoIncrementSeed() { }

	// RVA: 0x1DC6A50 Offset: 0x1DC5C50 VA: 0x181DC6A50
	public static Exception CantChangeDataType() { }

	// RVA: 0x1DCBA10 Offset: 0x1DCAC10 VA: 0x181DCBA10
	public static Exception NullDataType() { }

	// RVA: 0x1DC6E60 Offset: 0x1DC6060 VA: 0x181DC6E60
	public static Exception ColumnNameRequired() { }

	// RVA: 0x1DC7D40 Offset: 0x1DC6F40 VA: 0x181DC7D40
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0x1DC7EC0 Offset: 0x1DC70C0 VA: 0x181DC7EC0
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x1DC7DC0 Offset: 0x1DC6FC0 VA: 0x181DC7DC0
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x1DC8C20 Offset: 0x1DC7E20 VA: 0x181DC8C20
	public static Exception ExpressionAndUnique() { }

	// RVA: 0x1DC8BA0 Offset: 0x1DC7DA0 VA: 0x181DC8BA0
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0x1DC8AE0 Offset: 0x1DC7CE0 VA: 0x181DC8AE0
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0x1DC8D20 Offset: 0x1DC7F20 VA: 0x181DC8D20
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0x1DC8CA0 Offset: 0x1DC7EA0 VA: 0x181DC8CA0
	public static Exception ExpressionCircular() { }

	// RVA: 0x1DCB820 Offset: 0x1DCAA20 VA: 0x181DCB820
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0x1DCBA90 Offset: 0x1DCAC90 VA: 0x181DCBA90
	public static Exception NullKeyValues(string column) { }

	// RVA: 0x1DCBBF0 Offset: 0x1DCADF0 VA: 0x181DCBBF0
	public static Exception NullValues(string column) { }

	// RVA: 0x1DCC0D0 Offset: 0x1DCB2D0 VA: 0x181DCC0D0
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0x1DCC160 Offset: 0x1DCB360 VA: 0x181DCC160
	public static Exception ReadOnly(string column) { }

	// RVA: 0x1DCEC90 Offset: 0x1DCDE90 VA: 0x181DCEC90
	public static Exception UniqueAndExpression() { }

	// RVA: 0x1DCD910 Offset: 0x1DCCB10 VA: 0x181DCD910
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0x1DC68A0 Offset: 0x1DC5AA0 VA: 0x181DC68A0
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0x1DCAA50 Offset: 0x1DC9C50 VA: 0x181DCAA50
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0x1DC6680 Offset: 0x1DC5880 VA: 0x181DC6680
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0x1DC65A0 Offset: 0x1DC57A0 VA: 0x181DC65A0
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0x1DC6760 Offset: 0x1DC5960 VA: 0x181DC6760
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0x1DC6800 Offset: 0x1DC5A00 VA: 0x181DC6800
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0x1DC5F50 Offset: 0x1DC5150 VA: 0x181DC5F50
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0x1DC93C0 Offset: 0x1DC85C0 VA: 0x181DC93C0
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0x1DC5040 Offset: 0x1DC4240 VA: 0x181DC5040
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0x1DC9570 Offset: 0x1DC8770 VA: 0x181DC9570
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0x1DC94A0 Offset: 0x1DC86A0 VA: 0x181DC94A0
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0x1DCEAF0 Offset: 0x1DCDCF0 VA: 0x181DCEAF0
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0x1DC9A30 Offset: 0x1DC8C30 VA: 0x181DC9A30
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0x1DC6520 Offset: 0x1DC5720 VA: 0x181DC6520
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0x1DC9B30 Offset: 0x1DC8D30 VA: 0x181DC9B30
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0x1DC6AD0 Offset: 0x1DC5CD0 VA: 0x181DC6AD0
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0x1DC7380 Offset: 0x1DC6580 VA: 0x181DC7380
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0x1DCDA60 Offset: 0x1DCCC60 VA: 0x181DCDA60
	public static Exception SetFailed(string name) { }

	// RVA: 0x1DCDC50 Offset: 0x1DCCE50 VA: 0x181DCDC50
	public static Exception SetRowStateFilter() { }

	// RVA: 0x1DC57A0 Offset: 0x1DC49A0 VA: 0x181DC57A0
	public static Exception CanNotUseDataViewManager() { }

	// RVA: 0x1DC5710 Offset: 0x1DC4910 VA: 0x181DC5710
	public static Exception CanNotSetTable() { }

	// RVA: 0x1DC5830 Offset: 0x1DC4A30 VA: 0x181DC5830
	public static Exception CanNotUse() { }

	// RVA: 0x1DC52F0 Offset: 0x1DC44F0 VA: 0x181DC52F0
	public static Exception CanNotBindTable() { }

	// RVA: 0x1DCDCE0 Offset: 0x1DCCEE0 VA: 0x181DCDCE0
	public static Exception SetTable() { }

	// RVA: 0x1DCDB30 Offset: 0x1DCCD30 VA: 0x181DCDB30
	public static Exception SetIListObject() { }

	// RVA: 0x1DC49F0 Offset: 0x1DC3BF0 VA: 0x181DC49F0
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0x1DCB980 Offset: 0x1DCAB80 VA: 0x181DCB980
	public static Exception NotOpen() { }

	// RVA: 0x1DC7A10 Offset: 0x1DC6C10 VA: 0x181DC7A10
	public static Exception CreateChildView() { }

	// RVA: 0x1DC5400 Offset: 0x1DC4600 VA: 0x181DC5400
	public static Exception CanNotDelete() { }

	// RVA: 0x1DC9210 Offset: 0x1DC8410 VA: 0x181DC9210
	public static Exception GetElementIndex(int index) { }

	// RVA: 0x1DC4970 Offset: 0x1DC3B70 VA: 0x181DC4970
	public static Exception AddExternalObject() { }

	// RVA: 0x1DC5380 Offset: 0x1DC4580 VA: 0x181DC5380
	public static Exception CanNotClear() { }

	// RVA: 0x1DC9820 Offset: 0x1DC8A20 VA: 0x181DC9820
	public static Exception InsertExternalObject() { }

	// RVA: 0x1DCCD70 Offset: 0x1DCBF70 VA: 0x181DCCD70
	public static Exception RemoveExternalObject() { }

	// RVA: 0x1DC71E0 Offset: 0x1DC63E0 VA: 0x181DC71E0
	public static Exception ColumnToSortIsOutOfRange(string column) { }

	// RVA: 0x1DCA790 Offset: 0x1DC9990 VA: 0x181DCA790
	public static Exception KeyTableMismatch() { }

	// RVA: 0x1DCA700 Offset: 0x1DC9900 VA: 0x181DCA700
	public static Exception KeyNoColumns() { }

	// RVA: 0x1DCA820 Offset: 0x1DC9A20 VA: 0x181DCA820
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0x1DCA530 Offset: 0x1DC9730 VA: 0x181DCA530
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0x1DCC5D0 Offset: 0x1DCB7D0 VA: 0x181DCC5D0
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0x1DC73E0 Offset: 0x1DC65E0 VA: 0x181DC73E0
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0x1DCA600 Offset: 0x1DC9800 VA: 0x181DCA600
	public static Exception KeyLengthMismatch() { }

	// RVA: 0x1DCA680 Offset: 0x1DC9880 VA: 0x181DCA680
	public static Exception KeyLengthZero() { }

	// RVA: 0x1DC9100 Offset: 0x1DC8300 VA: 0x181DC9100
	public static Exception ForeignRelation() { }

	// RVA: 0x1DCA4A0 Offset: 0x1DC96A0 VA: 0x181DCA4A0
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0x1DCC7E0 Offset: 0x1DCB9E0 VA: 0x181DCC7E0
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0x1DC9320 Offset: 0x1DC8520 VA: 0x181DC9320
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x1DCDBB0 Offset: 0x1DCCDB0 VA: 0x181DCDBB0
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x1DCC760 Offset: 0x1DCB960 VA: 0x181DCC760
	public static Exception RelationForeignRow() { }

	// RVA: 0x1DCC880 Offset: 0x1DCBA80 VA: 0x181DCC880
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0x1DCE000 Offset: 0x1DCD200 VA: 0x181DCE000
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0x1DCAB30 Offset: 0x1DC9D30 VA: 0x181DCAB30
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0x1DCC6E0 Offset: 0x1DCB8E0 VA: 0x181DCC6E0
	public static Exception RelationDoesNotExist() { }

	// RVA: 0x1DCBCC0 Offset: 0x1DCAEC0 VA: 0x181DCBCC0
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0x1DC9640 Offset: 0x1DC8840 VA: 0x181DC9640
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0x1DC9E30 Offset: 0x1DC9030 VA: 0x181DC9E30
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0x1DCD440 Offset: 0x1DCC640 VA: 0x181DCD440
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0x1DCD4C0 Offset: 0x1DCC6C0 VA: 0x181DCD4C0
	public static Exception RowNotInTheTable() { }

	// RVA: 0x1DC87E0 Offset: 0x1DC79E0 VA: 0x181DC87E0
	public static Exception EditInRowChanging() { }

	// RVA: 0x1DC8940 Offset: 0x1DC7B40 VA: 0x181DC8940
	public static Exception EndEditInRowChanging() { }

	// RVA: 0x1DC5260 Offset: 0x1DC4460 VA: 0x181DC5260
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0x1DC58C0 Offset: 0x1DC4AC0 VA: 0x181DC58C0
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0x1DC7FE0 Offset: 0x1DC71E0 VA: 0x181DC7FE0
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0x1DCEF80 Offset: 0x1DCE180 VA: 0x181DCEF80
	public static Exception ValueArrayLength() { }

	// RVA: 0x1DCB5F0 Offset: 0x1DCA7F0 VA: 0x181DCB5F0
	public static Exception NoCurrentData() { }

	// RVA: 0x1DCB680 Offset: 0x1DCA880 VA: 0x181DCB680
	public static Exception NoOriginalData() { }

	// RVA: 0x1DCB710 Offset: 0x1DCA910 VA: 0x181DCB710
	public static Exception NoProposedData() { }

	// RVA: 0x1DCD660 Offset: 0x1DCC860 VA: 0x181DCD660
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0x1DC8070 Offset: 0x1DC7270 VA: 0x181DC8070
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0x1DCD000 Offset: 0x1DCC200 VA: 0x181DCD000
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0x1DCD220 Offset: 0x1DCC420 VA: 0x181DCD220
	public static Exception RowEmpty() { }

	// RVA: 0x1DCA0D0 Offset: 0x1DC92D0 VA: 0x181DCA0D0
	public static Exception InvalidRowVersion() { }

	// RVA: 0x1DCD550 Offset: 0x1DCC750 VA: 0x181DCD550
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0x1DCD370 Offset: 0x1DCC570 VA: 0x181DCD370
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0x1DCD2A0 Offset: 0x1DCC4A0 VA: 0x181DCD2A0
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0x1DCD190 Offset: 0x1DCC390 VA: 0x181DCD190
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0x1DCB160 Offset: 0x1DCA360 VA: 0x181DCB160
	public static Exception MultipleParents() { }

	// RVA: 0x1DCA090 Offset: 0x1DC9290 VA: 0x181DCA090
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0x1DCA010 Offset: 0x1DC9210 VA: 0x181DCA010
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0x1DCD890 Offset: 0x1DCCA90 VA: 0x181DCD890
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0x1DCD7C0 Offset: 0x1DCC9C0 VA: 0x181DCD7C0
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0x1DC7A90 Offset: 0x1DC6C90 VA: 0x181DC7A90
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0x1DCAD00 Offset: 0x1DC9F00 VA: 0x181DCAD00
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0x1DCE550 Offset: 0x1DCD750 VA: 0x181DCE550
	public static Exception TablesInDifferentSets() { }

	// RVA: 0x1DCC2B0 Offset: 0x1DCB4B0 VA: 0x181DCC2B0
	public static Exception RelationAlreadyExists() { }

	// RVA: 0x1DCD090 Offset: 0x1DCC290 VA: 0x181DCD090
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0x1DCD110 Offset: 0x1DCC310 VA: 0x181DCD110
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0x1DCC230 Offset: 0x1DCB430 VA: 0x181DCC230
	public static Exception RecordStateRange() { }

	// RVA: 0x1DC9710 Offset: 0x1DC8910 VA: 0x181DC9710
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0x1DCCEF0 Offset: 0x1DCC0F0 VA: 0x181DCCEF0
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0x1DCC330 Offset: 0x1DCB530 VA: 0x181DCC330
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0x1DCC3B0 Offset: 0x1DCB5B0 VA: 0x181DCC3B0
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0x1DCC900 Offset: 0x1DCBB00 VA: 0x181DCC900
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0x1DCC9D0 Offset: 0x1DCBBD0 VA: 0x181DCC9D0
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0x1DC85A0 Offset: 0x1DC77A0 VA: 0x181DC85A0
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0x1DCCC70 Offset: 0x1DCBE70 VA: 0x181DCCC70
	public static Exception RelationTableNull() { }

	// RVA: 0x1DCC660 Offset: 0x1DCB860 VA: 0x181DCC660
	public static Exception RelationDataSetNull() { }

	// RVA: 0x1DCCCF0 Offset: 0x1DCBEF0 VA: 0x181DCCCF0
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0x1DCBD50 Offset: 0x1DCAF50 VA: 0x181DCBD50
	public static Exception ParentTableMismatch() { }

	// RVA: 0x1DC6D10 Offset: 0x1DC5F10 VA: 0x181DC6D10
	public static Exception ChildTableMismatch() { }

	// RVA: 0x1DC89D0 Offset: 0x1DC7BD0 VA: 0x181DC89D0
	public static Exception EnforceConstraint() { }

	// RVA: 0x1DC6C90 Offset: 0x1DC5E90 VA: 0x181DC6C90
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0x1DC5EB0 Offset: 0x1DC50B0 VA: 0x181DC5EB0
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0x1DC5EC0 Offset: 0x1DC50C0 VA: 0x181DC5EC0
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0x1DC9FD0 Offset: 0x1DC91D0 VA: 0x181DC9FD0
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0x1DCE0D0 Offset: 0x1DCD2D0 VA: 0x181DCE0D0
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0x1DCDF80 Offset: 0x1DCD180 VA: 0x181DCDF80
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0x1DCB7A0 Offset: 0x1DCA9A0 VA: 0x181DCB7A0
	public static Exception NoTableName() { }

	// RVA: 0x1DCB1F0 Offset: 0x1DCA3F0 VA: 0x181DCB1F0
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0x1DCA230 Offset: 0x1DC9430 VA: 0x181DCA230
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0x1DC8710 Offset: 0x1DC7910 VA: 0x181DC8710
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0x1DC8670 Offset: 0x1DC7870 VA: 0x181DC8670
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0x1DCD6F0 Offset: 0x1DCC8F0 VA: 0x181DCD6F0
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0x1DC7BE0 Offset: 0x1DC6DE0 VA: 0x181DC7BE0
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0x1DCDE80 Offset: 0x1DCD080 VA: 0x181DCDE80
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0x1DCDF00 Offset: 0x1DCD100 VA: 0x181DCDF00
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0x1DCE440 Offset: 0x1DCD640 VA: 0x181DCE440
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0x1DCE370 Offset: 0x1DCD570 VA: 0x181DCE370
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0x1DCE220 Offset: 0x1DCD420 VA: 0x181DCE220
	public static Exception TableInRelation() { }

	// RVA: 0x1DCE150 Offset: 0x1DCD350 VA: 0x181DCE150
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0x1DC5590 Offset: 0x1DC4790 VA: 0x181DC5590
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0x1DC5510 Offset: 0x1DC4710 VA: 0x181DC5510
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0x1DC5690 Offset: 0x1DC4890 VA: 0x181DC5690
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0x1DC5610 Offset: 0x1DC4810 VA: 0x181DC5610
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0x1DCE2A0 Offset: 0x1DCD4A0 VA: 0x181DCE2A0
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0x1DC4B00 Offset: 0x1DC3D00 VA: 0x181DC4B00
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0x1DCA300 Offset: 0x1DC9500 VA: 0x181DCA300
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0x1DCBFE0 Offset: 0x1DCB1E0 VA: 0x181DCBFE0
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0x1DCBB60 Offset: 0x1DCAD60 VA: 0x181DCBB60
	public static Exception NullRange() { }

	// RVA: 0x1DCB420 Offset: 0x1DCA620 VA: 0x181DCB420
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0x1DCBEA0 Offset: 0x1DCB0A0 VA: 0x181DCBEA0
	public static Exception ProblematicChars(char charValue) { }

	// RVA: 0x1DCDE00 Offset: 0x1DCD000 VA: 0x181DCDE00
	public static Exception StorageSetFailed() { }

	// RVA: 0x1DCDD70 Offset: 0x1DCCF70 VA: 0x181DCDD70
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0x1DCAF00 Offset: 0x1DCA100 VA: 0x181DCAF00
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0x1DCAE60 Offset: 0x1DCA060 VA: 0x181DCAE60
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0x1DC9990 Offset: 0x1DC8B90 VA: 0x181DC9990
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0x1DC4E90 Offset: 0x1DC4090 VA: 0x181DC4E90
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0x1DC8870 Offset: 0x1DC7A70 VA: 0x181DC8870
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0x1DCCAD0 Offset: 0x1DCBCD0 VA: 0x181DCCAD0
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0x1DCC500 Offset: 0x1DCB700 VA: 0x181DCC500
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0x1DCCBA0 Offset: 0x1DCBDA0 VA: 0x181DCCBA0
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0x1DCC430 Offset: 0x1DCB630 VA: 0x181DCC430
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0x1DCEBC0 Offset: 0x1DCDDC0 VA: 0x181DCEBC0
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0x1DC7CB0 Offset: 0x1DC6EB0 VA: 0x181DC7CB0
	public static Exception DatatypeNotDefined() { }

	// RVA: 0x1DCADD0 Offset: 0x1DC9FD0 VA: 0x181DCADD0
	public static Exception MismatchKeyLength() { }

	// RVA: 0x1DC9C10 Offset: 0x1DC8E10 VA: 0x181DC9C10
	public static Exception InvalidField(string name) { }

	// RVA: 0x1DCA160 Offset: 0x1DC9360 VA: 0x181DCA160
	public static Exception InvalidSelector(string name) { }

	// RVA: 0x1DC6D90 Offset: 0x1DC5F90 VA: 0x181DC6D90
	public static Exception CircularComplexType(string name) { }

	// RVA: 0x1DC60C0 Offset: 0x1DC52C0 VA: 0x181DC60C0
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0x1DC9CE0 Offset: 0x1DC8EE0 VA: 0x181DC9CE0
	public static Exception InvalidKey(string name) { }

	// RVA: 0x1DC8190 Offset: 0x1DC7390 VA: 0x181DC8190
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0x1DC8100 Offset: 0x1DC7300 VA: 0x181DC8100
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0x1DC8330 Offset: 0x1DC7530 VA: 0x181DC8330
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0x1DC72B0 Offset: 0x1DC64B0 VA: 0x181DC72B0
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0x1DC6020 Offset: 0x1DC5220 VA: 0x181DC6020
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0x1DCAFD0 Offset: 0x1DCA1D0 VA: 0x181DCAFD0
	public static Exception MissingRefer(string name) { }

	// RVA: 0x1DC9F00 Offset: 0x1DC9100 VA: 0x181DC9F00
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0x1DC5490 Offset: 0x1DC4690 VA: 0x181DC5490
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0x1DCA410 Offset: 0x1DC9610 VA: 0x181DCA410
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0x1DCE690 Offset: 0x1DCD890 VA: 0x181DCE690
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0x1DCB4A0 Offset: 0x1DCA6A0 VA: 0x181DCB4A0
	public static Exception NestedCircular(string name) { }

	// RVA: 0x1DCB090 Offset: 0x1DCA290 VA: 0x181DCB090
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0x1DCBDD0 Offset: 0x1DCAFD0 VA: 0x181DCBDD0
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0x1DC7B60 Offset: 0x1DC6D60 VA: 0x181DC7B60
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0x1DCE640 Offset: 0x1DCD840 VA: 0x181DCE640
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0x1DC84D0 Offset: 0x1DC76D0 VA: 0x181DC84D0
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0x1DC9180 Offset: 0x1DC8380 VA: 0x181DC9180
	public static Exception FoundEntity() { }

	// RVA: 0x1DCAC90 Offset: 0x1DC9E90 VA: 0x181DCAC90
	public static Exception MergeFailed(string name) { }

	// RVA: 0x1DC7930 Offset: 0x1DC6B30 VA: 0x181DC7930
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0x1DC9B70 Offset: 0x1DC8D70 VA: 0x181DC9B70
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0x1DC98A0 Offset: 0x1DC8AA0 VA: 0x181DC98A0
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0x1DC8A60 Offset: 0x1DC7C60 VA: 0x181DC8A60
	public static Exception EnumeratorModified() { }
}

// Namespace: System.Data
[XmlRoot("DataSet")]
[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[XmlSchemaProvider("GetDataSetSchema")]
[DefaultProperty("DataSetName")]
[Serializable]
public class DataSet : MarshalByValueComponent, IListSource, IXmlSerializable, ISupportInitializeNotification, ISupportInitialize, ISerializable // TypeDefIndex: 12640
{
	// Fields
	private DataViewManager _defaultViewManager; // 0x20
	private readonly DataTableCollection _tableCollection; // 0x28
	private readonly DataRelationCollection _relationCollection; // 0x30
	internal PropertyCollection _extendedProperties; // 0x38
	private string _dataSetName; // 0x40
	private string _datasetPrefix; // 0x48
	internal string _namespaceURI; // 0x50
	private bool _enforceConstraints; // 0x58
	private bool _caseSensitive; // 0x59
	private CultureInfo _culture; // 0x60
	private bool _cultureUserSet; // 0x68
	internal bool _fInReadXml; // 0x69
	internal bool _fInLoadDiffgram; // 0x6A
	internal bool _fTopLevelTable; // 0x6B
	internal bool _fInitInProgress; // 0x6C
	internal bool _fEnableCascading; // 0x6D
	internal bool _fIsSchemaLoading; // 0x6E
	internal string _mainTableName; // 0x70
	private SerializationFormat _remotingFormat; // 0x78
	private object _defaultViewManagerLock; // 0x80
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x88
	private static XmlSchemaComplexType s_schemaTypeForWSDL; // 0x8
	internal bool _useDataSetSchemaOnly; // 0x8C
	internal bool _udtIsWrapped; // 0x8D
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x90
	[CompilerGenerated]
	private MergeFailedEventHandler MergeFailed; // 0x98
	[CompilerGenerated]
	private DataRowCreatedEventHandler DataRowCreated; // 0xA0
	[CompilerGenerated]
	private DataSetClearEventhandler ClearFunctionCalled; // 0xA8
	[CompilerGenerated]
	private EventHandler Initialized; // 0xB0

	// Properties
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual SchemaSerializationMode SchemaSerializationMode { get; }
	[DefaultValue(False)]
	public bool CaseSensitive { get; set; }
	private bool System.ComponentModel.IListSource.ContainsListCollection { get; }
	[Browsable(False)]
	public DataViewManager DefaultViewManager { get; }
	[DefaultValue(True)]
	public bool EnforceConstraints { get; set; }
	[DefaultValue("")]
	public string DataSetName { get; set; }
	[DefaultValue("")]
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	[Browsable(False)]
	public bool IsInitialized { get; }
	public CultureInfo Locale { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public override ISite Site { get; set; }
	[DesignerSerializationVisibility(2)]
	public DataRelationCollection Relations { get; }
	[DesignerSerializationVisibility(2)]
	public DataTableCollection Tables { get; }
	internal string MainTableName { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1DC3360 Offset: 0x1DC2560 VA: 0x181DC3360
	public void .ctor() { }

	// RVA: 0x1DC37E0 Offset: 0x1DC29E0 VA: 0x181DC37E0
	public void .ctor(string dataSetName) { }

	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x1DC4670 Offset: 0x1DC3870 VA: 0x181DC4670
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 27
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0x1DC37B0 Offset: 0x1DC29B0 VA: 0x181DC37B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DC35A0 Offset: 0x1DC27A0 VA: 0x181DC35A0
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0x1DBB4B0 Offset: 0x1DBA6B0 VA: 0x181DBB4B0 Slot: 28
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 29
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0x1DC0CF0 Offset: 0x1DBFEF0 VA: 0x181DC0CF0
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x1DB9F90 Offset: 0x1DB9190 VA: 0x181DB9F90
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x1DB9A80 Offset: 0x1DB8C80 VA: 0x181DB9A80
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x1DB95F0 Offset: 0x1DB87F0 VA: 0x181DB95F0
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x1DC0B50 Offset: 0x1DBFD50 VA: 0x181DC0B50
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DB97C0 Offset: 0x1DB89C0 VA: 0x181DB97C0
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DC14C0 Offset: 0x1DC06C0 VA: 0x181DC14C0
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DBA010 Offset: 0x1DB9210 VA: 0x181DBA010
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DBB060 Offset: 0x1DBA260 VA: 0x181DBB060
	internal void FailedEnableConstraints() { }

	// RVA: 0x7725E0 Offset: 0x7717E0 VA: 0x1807725E0
	public bool get_CaseSensitive() { }

	// RVA: 0x1DC3AD0 Offset: 0x1DC2CD0 VA: 0x181DC3AD0
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 16
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0x1DC38C0 Offset: 0x1DC2AC0 VA: 0x181DC38C0
	public DataViewManager get_DefaultViewManager() { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30
	public bool get_EnforceConstraints() { }

	// RVA: 0x1DC3EF0 Offset: 0x1DC30F0 VA: 0x181DC3EF0
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0x4D1A70 Offset: 0x4D0C70 VA: 0x1804D1A70
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0x1DBA750 Offset: 0x1DB9950 VA: 0x181DBA750
	internal void EnableConstraints() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_DataSetName() { }

	// RVA: 0x1DC3D90 Offset: 0x1DC2F90 VA: 0x181DC3D90
	public void set_DataSetName(string value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Namespace() { }

	// RVA: 0x1DC4190 Offset: 0x1DC3390 VA: 0x181DC4190
	public void set_Namespace(string value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_Prefix() { }

	// RVA: 0x1DC4550 Offset: 0x1DC3750 VA: 0x181DC4550
	public void set_Prefix(string value) { }

	// RVA: 0x1DC39B0 Offset: 0x1DC2BB0 VA: 0x181DC39B0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1DC3A10 Offset: 0x1DC2C10 VA: 0x181DC3A10 Slot: 21
	public bool get_IsInitialized() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public CultureInfo get_Locale() { }

	// RVA: 0x1DC4030 Offset: 0x1DC3230 VA: 0x181DC4030
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x1DC1A20 Offset: 0x1DC0C20 VA: 0x181DC1A20
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 10
	public override ISite get_Site() { }

	// RVA: 0x1DC4730 Offset: 0x1DC3930 VA: 0x181DC4730 Slot: 11
	public override void set_Site(ISite value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public DataRelationCollection get_Relations() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public DataTableCollection get_Tables() { }

	[CompilerGenerated]
	// RVA: 0x1DC3810 Offset: 0x1DC2A10 VA: 0x181DC3810 Slot: 22
	public void add_Initialized(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1DC3A20 Offset: 0x1DC2C20 VA: 0x181DC3A20 Slot: 23
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0x1DB84F0 Offset: 0x1DB76F0 VA: 0x181DB84F0 Slot: 24
	public void BeginInit() { }

	// RVA: 0x1DBAD10 Offset: 0x1DB9F10 VA: 0x181DBAD10 Slot: 25
	public void EndInit() { }

	// RVA: 0x1DB8500 Offset: 0x1DB7700 VA: 0x181DB8500
	public void Clear() { }

	// RVA: 0x1DB86D0 Offset: 0x1DB78D0 VA: 0x181DB86D0 Slot: 30
	public virtual DataSet Clone() { }

	// RVA: 0x1DBAF00 Offset: 0x1DBA100 VA: 0x181DBAF00
	internal int EstimatedXmlStringSize() { }

	// RVA: 0x1DC20F0 Offset: 0x1DC12F0 VA: 0x181DC20F0 Slot: 17
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0x1DBB4E0 Offset: 0x1DBA6E0 VA: 0x181DBB4E0
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0x1DBB620 Offset: 0x1DBA820 VA: 0x181DBB620
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0x1DBD9B0 Offset: 0x1DBCBB0 VA: 0x181DBD9B0
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0x1DBD9C0 Offset: 0x1DBCBC0 VA: 0x181DBD9C0
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1DA35C0 Offset: 0x1DA27C0 VA: 0x181DA35C0
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x1DBC080 Offset: 0x1DBB280 VA: 0x181DBC080
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0x1DA51E0 Offset: 0x1DA43E0 VA: 0x181DA51E0
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x1DBC5E0 Offset: 0x1DBB7E0 VA: 0x181DBC5E0
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1DBC460 Offset: 0x1DBB660 VA: 0x181DBC460
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x1DC2F20 Offset: 0x1DC2120 VA: 0x181DC2F20
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x1DC08B0 Offset: 0x1DBFAB0 VA: 0x181DC08B0
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0x1DBF5F0 Offset: 0x1DBE7F0 VA: 0x181DBF5F0
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1DBB7D0 Offset: 0x1DBA9D0 VA: 0x181DBB7D0
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0x1DBBAE0 Offset: 0x1DBACE0 VA: 0x181DBBAE0
	private bool IsEmpty() { }

	// RVA: 0x1DBC8A0 Offset: 0x1DBBAA0 VA: 0x181DBC8A0
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x1DBE740 Offset: 0x1DBD940 VA: 0x181DBE740
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0x1DBE760 Offset: 0x1DBD960 VA: 0x181DBE760
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x1DC3130 Offset: 0x1DC2330 VA: 0x181DC3130
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0x1DBBD00 Offset: 0x1DBAF00 VA: 0x181DBBD00
	public void Merge(DataSet dataSet) { }

	// RVA: 0x1DBBE50 Offset: 0x1DBB050 VA: 0x181DBBE50
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1DBC270 Offset: 0x1DBB470 VA: 0x181DBC270 Slot: 31
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1DBC1F0 Offset: 0x1DBB3F0 VA: 0x181DBC1F0
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0x1DBC2D0 Offset: 0x1DBB4D0 VA: 0x181DBC2D0
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1DBC140 Offset: 0x1DBB340 VA: 0x181DBC140
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0x1DBC110 Offset: 0x1DBB310 VA: 0x181DBC110
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0x1DBC170 Offset: 0x1DBB370 VA: 0x181DBC170
	private void OnInitialized() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 32
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0x1DBC2A0 Offset: 0x1DBB4A0 VA: 0x181DBC2A0
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 33
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0x1D00190 Offset: 0x1CFF390 VA: 0x181D00190
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0x1DBC3E0 Offset: 0x1DBB5E0 VA: 0x181DBC3E0
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1DC2480 Offset: 0x1DC1680 VA: 0x181DC2480
	internal DataTable[] TopLevelTables() { }

	// RVA: 0x1DC2490 Offset: 0x1DC1690 VA: 0x181DC2490
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0x1DC08C0 Offset: 0x1DBFAC0 VA: 0x181DC08C0 Slot: 34
	public virtual void Reset() { }

	// RVA: 0x1DC26C0 Offset: 0x1DC18C0 VA: 0x181DC26C0
	internal bool ValidateCaseConstraint() { }

	// RVA: 0x1DC2AA0 Offset: 0x1DC1CA0 VA: 0x181DC2AA0
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0x1DBB0A0 Offset: 0x1DBA2A0 VA: 0x181DBB0A0
	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	// RVA: 0x1DBE3F0 Offset: 0x1DBD5F0 VA: 0x181DBE3F0 Slot: 35
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x1DBB220 Offset: 0x1DBA420 VA: 0x181DBB220
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0x1DC2100 Offset: 0x1DC1300 VA: 0x181DC2100 Slot: 18
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1DC22D0 Offset: 0x1DC14D0 VA: 0x181DC22D0 Slot: 19
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1DC2430 Offset: 0x1DC1630 VA: 0x181DC2430 Slot: 20
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	internal string get_MainTableName() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	internal void set_MainTableName(string value) { }

	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950
	internal int get_ObjectID() { }
}

// Namespace: 
internal struct DataTable.RowDiffIdUsageSection // TypeDefIndex: 12641
{
	// Fields
	private DataTable _targetTable; // 0x0

	// Methods

	// RVA: 0x1DD4250 Offset: 0x1DD3450 VA: 0x181DD4250
	internal void Prepare(DataTable table) { }
}

// Namespace: 
internal struct DataTable.DSRowDiffIdUsageSection // TypeDefIndex: 12642
{
	// Fields
	private DataSet _targetDS; // 0x0

	// Methods

	// RVA: 0x1DB1770 Offset: 0x1DB0970 VA: 0x181DB1770
	internal void Prepare(DataSet ds) { }
}

// Namespace: System.Data
[DesignTimeVisible(False)]
[ToolboxItem(False)]
[XmlSchemaProvider("GetDataTableSchema")]
[DefaultEvent("RowChanging")]
[DefaultProperty("TableName")]
[Serializable]
public class DataTable : MarshalByValueComponent, IListSource, ISupportInitializeNotification, ISupportInitialize, ISerializable, IXmlSerializable // TypeDefIndex: 12643
{
	// Fields
	private DataSet _dataSet; // 0x20
	private DataView _defaultView; // 0x28
	internal long _nextRowID; // 0x30
	internal readonly DataRowCollection _rowCollection; // 0x38
	internal readonly DataColumnCollection _columnCollection; // 0x40
	private readonly ConstraintCollection _constraintCollection; // 0x48
	private int _elementColumnCount; // 0x50
	internal DataRelationCollection _parentRelationsCollection; // 0x58
	internal DataRelationCollection _childRelationsCollection; // 0x60
	internal readonly RecordManager _recordManager; // 0x68
	internal readonly List<Index> _indexes; // 0x70
	private List<Index> _shadowIndexes; // 0x78
	private int _shadowCount; // 0x80
	internal PropertyCollection _extendedProperties; // 0x88
	private string _tableName; // 0x90
	internal string _tableNamespace; // 0x98
	private string _tablePrefix; // 0xA0
	internal DataExpression _displayExpression; // 0xA8
	internal bool _fNestedInDataset; // 0xB0
	private CultureInfo _culture; // 0xB8
	private bool _cultureUserSet; // 0xC0
	private CompareInfo _compareInfo; // 0xC8
	private CompareOptions _compareFlags; // 0xD0
	private IFormatProvider _formatProvider; // 0xD8
	private StringComparer _hashCodeProvider; // 0xE0
	private bool _caseSensitive; // 0xE8
	private bool _caseSensitiveUserSet; // 0xE9
	internal string _encodedTableName; // 0xF0
	internal DataColumn _xmlText; // 0xF8
	internal DataColumn _colUnique; // 0x100
	internal Decimal _minOccurs; // 0x108
	internal Decimal _maxOccurs; // 0x118
	internal bool _repeatableElement; // 0x128
	private object _typeName; // 0x130
	internal UniqueConstraint _primaryKey; // 0x138
	internal IndexField[] _primaryIndex; // 0x140
	private DataColumn[] _delayedSetPrimaryKey; // 0x148
	private Index _loadIndex; // 0x150
	private Index _loadIndexwithOriginalAdded; // 0x158
	private Index _loadIndexwithCurrentDeleted; // 0x160
	private int _suspendIndexEvents; // 0x168
	private bool _inDataLoad; // 0x16C
	private bool _schemaLoading; // 0x16D
	private bool _enforceConstraints; // 0x16E
	internal bool _suspendEnforceConstraints; // 0x16F
	protected internal bool fInitInProgress; // 0x170
	private bool _inLoad; // 0x171
	internal bool _fInLoadDiffgram; // 0x172
	private byte _isTypedDataTable; // 0x173
	private DataRow[] _emptyDataRowArray; // 0x178
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; // 0x180
	private DataRelation[] _nestedParentRelations; // 0x188
	internal List<DataColumn> _dependentColumns; // 0x190
	private bool _mergingData; // 0x198
	private DataRowChangeEventHandler _onRowChangedDelegate; // 0x1A0
	private DataRowChangeEventHandler _onRowChangingDelegate; // 0x1A8
	private DataRowChangeEventHandler _onRowDeletingDelegate; // 0x1B0
	private DataRowChangeEventHandler _onRowDeletedDelegate; // 0x1B8
	private DataColumnChangeEventHandler _onColumnChangedDelegate; // 0x1C0
	private DataColumnChangeEventHandler _onColumnChangingDelegate; // 0x1C8
	private DataTableClearEventHandler _onTableClearingDelegate; // 0x1D0
	private DataTableClearEventHandler _onTableClearedDelegate; // 0x1D8
	private DataTableNewRowEventHandler _onTableNewRowDelegate; // 0x1E0
	private PropertyChangedEventHandler _onPropertyChangingDelegate; // 0x1E8
	private EventHandler _onInitialized; // 0x1F0
	private readonly DataRowBuilder _rowBuilder; // 0x1F8
	internal readonly List<DataView> _delayedViews; // 0x200
	private readonly List<DataViewListener> _dataViewListeners; // 0x208
	internal Hashtable _rowDiffId; // 0x210
	internal readonly ReaderWriterLockSlim _indexesLock; // 0x218
	internal int _ukColumnPositionForInference; // 0x220
	private SerializationFormat _remotingFormat; // 0x224
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x228

	// Properties
	public bool CaseSensitive { get; set; }
	internal bool AreIndexEventsSuspended { get; }
	[Browsable(False)]
	public bool IsInitialized { get; }
	private bool IsTypedDataTable { get; }
	internal bool SelfNested { get; }
	[DebuggerBrowsable(0)]
	internal List<Index> LiveIndexes { get; }
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	internal int UKColumnPositionForInference { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ChildRelations { get; }
	[DesignerSerializationVisibility(2)]
	public DataColumnCollection Columns { get; }
	private CompareInfo CompareInfo { get; }
	[DesignerSerializationVisibility(2)]
	public ConstraintCollection Constraints { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public DataSet DataSet { get; }
	[Browsable(False)]
	public DataView DefaultView { get; }
	internal string DisplayExpressionInternal { get; }
	internal bool EnforceConstraints { get; set; }
	internal bool SuspendEnforceConstraints { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal IFormatProvider FormatProvider { get; }
	public CultureInfo Locale { get; set; }
	[DefaultValue(50)]
	public int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; }
	internal int ElementColumnCount { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ParentRelations { get; }
	internal bool MergingData { get; set; }
	internal DataRelation[] NestedParentRelations { get; }
	internal bool SchemaLoading { get; }
	internal int NestedParentsCount { get; }
	[TypeConverter(typeof(PrimaryKeyTypeConverter))]
	public DataColumn[] PrimaryKey { get; set; }
	[Browsable(False)]
	public DataRowCollection Rows { get; }
	[DefaultValue("")]
	[RefreshProperties(1)]
	public string TableName { get; set; }
	internal string EncodedTableName { get; }
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal DataColumn XmlText { get; set; }
	internal Decimal MaxOccurs { get; set; }
	internal Decimal MinOccurs { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public override ISite Site { get; set; }
	private bool System.ComponentModel.IListSource.ContainsListCollection { get; }
	internal bool NeedColumnChangeEvents { get; }
	internal XmlQualifiedName TypeName { get; set; }
	internal Hashtable RowDiffId { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1DADA50 Offset: 0x1DACC50 VA: 0x181DADA50
	public void .ctor() { }

	// RVA: 0x1DADE70 Offset: 0x1DAD070 VA: 0x181DADE70
	public void .ctor(string tableName) { }

	// RVA: 0x1DADED0 Offset: 0x1DAD0D0 VA: 0x181DADED0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DA12D0 Offset: 0x1DA04D0 VA: 0x181DA12D0 Slot: 27
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DA9B80 Offset: 0x1DA8D80 VA: 0x181DA9B80
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x1D9C3C0 Offset: 0x1D9B5C0 VA: 0x181D9C3C0
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x1DAA610 Offset: 0x1DA9810 VA: 0x181DAA610
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x1D9D310 Offset: 0x1D9C510 VA: 0x181D9D310
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x1DA9390 Offset: 0x1DA8590 VA: 0x181DA9390
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x1D9B8F0 Offset: 0x1D9AAF0 VA: 0x181D9B8F0
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x1DA9E30 Offset: 0x1DA9030 VA: 0x181DA9E30
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1D9C710 Offset: 0x1D9B910 VA: 0x181D9C710
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1DA9FC0 Offset: 0x1DA91C0 VA: 0x181DA9FC0
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1D9C8A0 Offset: 0x1D9BAA0 VA: 0x181D9C8A0
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1D9AD30 Offset: 0x1D99F30 VA: 0x181D9AD30
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0x1DA1700 Offset: 0x1DA0900 VA: 0x181DA1700
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x1D9AA10 Offset: 0x1D99C10 VA: 0x181D9AA10
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x7381B0 Offset: 0x7373B0 VA: 0x1807381B0
	public bool get_CaseSensitive() { }

	// RVA: 0x1DAEE40 Offset: 0x1DAE040 VA: 0x181DAEE40
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x1DAE100 Offset: 0x1DAD300 VA: 0x181DAE100
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0x1DA8F50 Offset: 0x1DA8150 VA: 0x181DA8F50
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0x1DACEE0 Offset: 0x1DAC0E0 VA: 0x181DACEE0
	internal void SuspendIndexEvents() { }

	// RVA: 0x1DAE3E0 Offset: 0x1DAD5E0 VA: 0x181DAE3E0 Slot: 18
	public bool get_IsInitialized() { }

	// RVA: 0x1DAE3F0 Offset: 0x1DAD5F0 VA: 0x181DAE3F0
	private bool get_IsTypedDataTable() { }

	// RVA: 0x1DAB3F0 Offset: 0x1DAA5F0 VA: 0x181DAB3F0
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0x7381A0 Offset: 0x7373A0 VA: 0x1807381A0
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0x1DAEA80 Offset: 0x1DADC80 VA: 0x181DAEA80
	internal bool get_SelfNested() { }

	// RVA: 0x1DAE4A0 Offset: 0x1DAD6A0 VA: 0x181DAE4A0
	internal List<Index> get_LiveIndexes() { }

	// RVA: 0x1DAEA00 Offset: 0x1DADC00 VA: 0x181DAEA00
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x1DAFBD0 Offset: 0x1DAEDD0 VA: 0x181DAFBD0
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x1DAED90 Offset: 0x1DADF90 VA: 0x181DAED90
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0x1DB0300 Offset: 0x1DAF500 VA: 0x181DB0300
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0x1DAE110 Offset: 0x1DAD310 VA: 0x181DAE110
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public DataColumnCollection get_Columns() { }

	// RVA: 0x1DAE180 Offset: 0x1DAD380 VA: 0x181DAE180
	private CompareInfo get_CompareInfo() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public ConstraintCollection get_Constraints() { }

	// RVA: 0x1DA8A60 Offset: 0x1DA7C60 VA: 0x181DA8A60
	private void ResetConstraints() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public DataSet get_DataSet() { }

	// RVA: 0x1DAB6C0 Offset: 0x1DAA8C0 VA: 0x181DAB6C0
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x1DACF90 Offset: 0x1DAC190 VA: 0x181DACF90
	public DataView get_DefaultView() { }

	// RVA: 0x1DAE1D0 Offset: 0x1DAD3D0 VA: 0x181DAE1D0
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0x1DAE2A0 Offset: 0x1DAD4A0 VA: 0x181DAE2A0
	internal bool get_EnforceConstraints() { }

	// RVA: 0x1DAEF50 Offset: 0x1DAE150 VA: 0x181DAEF50
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0x1DAECC0 Offset: 0x1DADEC0 VA: 0x181DAECC0
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0x1DAFDB0 Offset: 0x1DAEFB0 VA: 0x181DAFDB0
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0x1D9E6A0 Offset: 0x1D9D8A0 VA: 0x181D9E6A0
	internal void EnableConstraints() { }

	// RVA: 0x1DAE2D0 Offset: 0x1DAD4D0 VA: 0x181DAE2D0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1DAE340 Offset: 0x1DAD540 VA: 0x181DAE340
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080
	public CultureInfo get_Locale() { }

	// RVA: 0x1DAEF90 Offset: 0x1DAE190 VA: 0x181DAEF90
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x1DAB810 Offset: 0x1DAAA10 VA: 0x181DAB810
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0x5C6220 Offset: 0x5C5420 VA: 0x1805C6220
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x1DAE560 Offset: 0x1DAD760 VA: 0x181DAE560
	public int get_MinimumCapacity() { }

	// RVA: 0x1DAF380 Offset: 0x1DAE580 VA: 0x181DAF380
	public void set_MinimumCapacity(int value) { }

	// RVA: 0x1DAE9E0 Offset: 0x1DADBE0 VA: 0x181DAE9E0
	internal int get_RecordCapacity() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	internal int get_ElementColumnCount() { }

	// RVA: 0x1DAEF00 Offset: 0x1DAE100 VA: 0x181DAEF00
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0x1DAE910 Offset: 0x1DADB10 VA: 0x181DAE910
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0x1C61250 Offset: 0x1C60450 VA: 0x181C61250
	internal bool get_MergingData() { }

	// RVA: 0x1C61C80 Offset: 0x1C60E80 VA: 0x181C61C80
	internal void set_MergingData(bool value) { }

	// RVA: 0x72F730 Offset: 0x72E930 VA: 0x18072F730
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0x19AD0B0 Offset: 0x19AC2B0 VA: 0x1819AD0B0
	internal bool get_SchemaLoading() { }

	// RVA: 0x1D97C10 Offset: 0x1D96E10 VA: 0x181D97C10
	internal void CacheNestedParent() { }

	// RVA: 0x1DA0700 Offset: 0x1D9F900 VA: 0x181DA0700
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0x1DAE640 Offset: 0x1DAD840 VA: 0x181DAE640
	internal int get_NestedParentsCount() { }

	// RVA: 0x1DAE980 Offset: 0x1DADB80 VA: 0x181DAE980
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0x1DAF790 Offset: 0x1DAE990 VA: 0x181DAF790
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public DataRowCollection get_Rows() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public string get_TableName() { }

	// RVA: 0x1DAFDC0 Offset: 0x1DAEFC0 VA: 0x181DAFDC0
	public void set_TableName(string value) { }

	// RVA: 0x1DAE230 Offset: 0x1DAD430 VA: 0x181DAE230
	internal string get_EncodedTableName() { }

	// RVA: 0x1DA1030 Offset: 0x1DA0230 VA: 0x181DA1030
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	// RVA: 0x1DAE580 Offset: 0x1DAD780 VA: 0x181DAE580
	public string get_Namespace() { }

	// RVA: 0x1DAF3B0 Offset: 0x1DAE5B0 VA: 0x181DAF3B0
	public void set_Namespace(string value) { }

	// RVA: 0x1DA2C30 Offset: 0x1DA1E30 VA: 0x181DA2C30
	internal bool IsNamespaceInherited() { }

	// RVA: 0x1D97D00 Offset: 0x1D96F00 VA: 0x181D97D00
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0x1D98700 Offset: 0x1D97900 VA: 0x181D98700
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0x1D98440 Offset: 0x1D97640 VA: 0x181D98440
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0x1D9E150 Offset: 0x1D9D350 VA: 0x181D9E150
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0x1D97C00 Offset: 0x1D96E00 VA: 0x181D97C00 Slot: 28
	public virtual void BeginInit() { }

	// RVA: 0x1D9EC10 Offset: 0x1D9DE10 VA: 0x181D9EC10 Slot: 29
	public virtual void EndInit() { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public string get_Prefix() { }

	// RVA: 0x1DAF620 Offset: 0x1DAE820 VA: 0x181DAF620
	public void set_Prefix(string value) { }

	// RVA: 0x794CD0 Offset: 0x793ED0 VA: 0x180794CD0
	internal DataColumn get_XmlText() { }

	// RVA: 0x1DB0310 Offset: 0x1DAF510 VA: 0x181DB0310
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0x1DAE540 Offset: 0x1DAD740 VA: 0x181DAE540
	internal Decimal get_MaxOccurs() { }

	// RVA: 0x1DAF360 Offset: 0x1DAE560 VA: 0x181DAF360
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0x1DAE550 Offset: 0x1DAD750 VA: 0x181DAE550
	internal Decimal get_MinOccurs() { }

	// RVA: 0x1DAF370 Offset: 0x1DAE570 VA: 0x181DAF370
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0x1DAB780 Offset: 0x1DAA980 VA: 0x181DAB780
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0x1DA0560 Offset: 0x1D9F760 VA: 0x181DA0560
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0x1DA0600 Offset: 0x1D9F800 VA: 0x181DA0600
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0x1DABE10 Offset: 0x1DAB010 VA: 0x181DABE10
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0x1DA2CD0 Offset: 0x1DA1ED0 VA: 0x181DA2CD0
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0x1D9B130 Offset: 0x1D9A330 VA: 0x181D9B130 Slot: 30
	protected virtual DataTable CreateInstance() { }

	// RVA: 0x1D9A5C0 Offset: 0x1D997C0 VA: 0x181D9A5C0 Slot: 31
	public virtual DataTable Clone() { }

	// RVA: 0x1D9A3E0 Offset: 0x1D995E0 VA: 0x181D9A3E0
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0x1DA1CB0 Offset: 0x1DA0EB0 VA: 0x181DA1CB0
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0x1D99280 Offset: 0x1D98480 VA: 0x181D99280
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0x1D99700 Offset: 0x1D98900 VA: 0x181D99700
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0x1DAE060 Offset: 0x1DAD260 VA: 0x181DAE060 Slot: 19
	public void add_Initialized(EventHandler value) { }

	// RVA: 0x1DAEDA0 Offset: 0x1DADFA0 VA: 0x181DAEDA0 Slot: 20
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 10
	public override ISite get_Site() { }

	// RVA: 0x1DAFC50 Offset: 0x1DAEE50 VA: 0x181DAFC50 Slot: 11
	public override void set_Site(ISite value) { }

	// RVA: 0x1D978C0 Offset: 0x1D96AC0 VA: 0x181D978C0
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0x1DA29F0 Offset: 0x1DA1BF0 VA: 0x181DA29F0
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0x1DA2610 Offset: 0x1DA1810 VA: 0x181DA2610
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	// RVA: 0x1D98A90 Offset: 0x1D97C90 VA: 0x181D98A90
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0x1D98AC0 Offset: 0x1D97CC0 VA: 0x181D98AC0
	public void Clear() { }

	// RVA: 0x1D98AD0 Offset: 0x1D97CD0 VA: 0x181D98AD0
	internal void Clear(bool clearAll) { }

	// RVA: 0x1D97C30 Offset: 0x1D96E30 VA: 0x181D97C30
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0x1D9A5D0 Offset: 0x1D997D0 VA: 0x181D9A5D0
	internal void CommitRow(DataRow row) { }

	// RVA: 0x1D9A8B0 Offset: 0x1D99AB0 VA: 0x181D9A8B0
	internal int Compare(string s1, string s2) { }

	// RVA: 0x1D9A720 Offset: 0x1D99920 VA: 0x181D9A720
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0x1DA1F50 Offset: 0x1DA1150 VA: 0x181DA1F50
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0x1DA2C40 Offset: 0x1DA1E40 VA: 0x181DA2C40
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 16
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0x1D9B840 Offset: 0x1D9AA40 VA: 0x181D9B840
	internal void DeleteRow(DataRow row) { }

	// RVA: 0x1DA0A50 Offset: 0x1D9FC50 VA: 0x181DA0A50
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0x1DA0B90 Offset: 0x1D9FD90 VA: 0x181DA0B90
	internal void FreeRecord(ref int record) { }

	// RVA: 0x1DA0FE0 Offset: 0x1DA01E0 VA: 0x181DA0FE0
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1DA0DF0 Offset: 0x1D9FFF0 VA: 0x181DA0DF0
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1DACF90 Offset: 0x1DAC190 VA: 0x181DACF90 Slot: 17
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0x1DA12C0 Offset: 0x1DA04C0 VA: 0x181DA12C0
	internal List<DataViewListener> GetListeners() { }

	// RVA: 0x1DA1BB0 Offset: 0x1DA0DB0 VA: 0x181DA1BB0
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0x1DA2200 Offset: 0x1DA1400 VA: 0x181DA2200
	internal void InsertRow(DataRow row, long proposedID) { }

	// RVA: 0x1DA3710 Offset: 0x1DA2910 VA: 0x181DA3710
	internal int NewRecord() { }

	// RVA: 0x1DA3C20 Offset: 0x1DA2E20 VA: 0x181DA3C20
	internal int NewUninitializedRecord() { }

	// RVA: 0x1DA3720 Offset: 0x1DA2920 VA: 0x181DA3720
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0x1DA36A0 Offset: 0x1DA28A0 VA: 0x181DA36A0
	internal DataRow NewEmptyRow() { }

	// RVA: 0x1DA3C40 Offset: 0x1DA2E40 VA: 0x181DA3C40
	private DataRow NewUninitializedRow() { }

	// RVA: 0x1DA3B20 Offset: 0x1DA2D20 VA: 0x181DA3B20
	public DataRow NewRow() { }

	// RVA: 0x1D9AE10 Offset: 0x1D9A010 VA: 0x181D9AE10
	internal DataRow CreateEmptyRow() { }

	// RVA: 0x1DA3990 Offset: 0x1DA2B90 VA: 0x181DA3990
	private void NewRowCreated(DataRow row) { }

	// RVA: 0x1DA3A80 Offset: 0x1DA2C80 VA: 0x181DA3A80
	internal DataRow NewRow(int record) { }

	// RVA: 0x1DA3A20 Offset: 0x1DA2C20 VA: 0x181DA3A20 Slot: 32
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0x1DA1980 Offset: 0x1DA0B80 VA: 0x181DA1980 Slot: 33
	protected virtual Type GetRowType() { }

	// RVA: 0x1DA3810 Offset: 0x1DA2A10 VA: 0x181DA3810
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0x1DAE600 Offset: 0x1DAD800 VA: 0x181DAE600
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0x1DA3D50 Offset: 0x1DA2F50 VA: 0x181DA3D50 Slot: 34
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0x1DA3C80 Offset: 0x1DA2E80 VA: 0x181DA3C80 Slot: 35
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0x1DA3F20 Offset: 0x1DA3120 VA: 0x181DA3F20 Slot: 36
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1DA3FF0 Offset: 0x1DA31F0 VA: 0x181DA3FF0
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 37
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0x1DA4010 Offset: 0x1DA3210 VA: 0x181DA4010
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1DA4190 Offset: 0x1DA3390 VA: 0x181DA4190
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1DA40C0 Offset: 0x1DA32C0 VA: 0x181DA40C0 Slot: 38
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0x1DA4240 Offset: 0x1DA3440 VA: 0x181DA4240 Slot: 39
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0x1DA43E0 Offset: 0x1DA35E0 VA: 0x181DA43E0 Slot: 40
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0x1DA4310 Offset: 0x1DA3510 VA: 0x181DA4310 Slot: 41
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0x1DA44B0 Offset: 0x1DA36B0 VA: 0x181DA44B0 Slot: 42
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0x1DA4580 Offset: 0x1DA3780 VA: 0x181DA4580 Slot: 43
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0x1DA4650 Offset: 0x1DA3850 VA: 0x181DA4650 Slot: 44
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0x1DA3E20 Offset: 0x1DA3020 VA: 0x181DA3E20
	private void OnInitialized() { }

	// RVA: 0x1DA4720 Offset: 0x1DA3920 VA: 0x181DA4720
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0x1DA4A90 Offset: 0x1DA3C90 VA: 0x181DA4A90
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1DA7F20 Offset: 0x1DA7120 VA: 0x181DA7F20
	internal void RecordChanged(int record) { }

	// RVA: 0x1DA8080 Offset: 0x1DA7280 VA: 0x181DA8080
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0x1DA8420 Offset: 0x1DA7620 VA: 0x181DA8420
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x1DA8220 Offset: 0x1DA7420 VA: 0x181DA8220
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0x1DA8630 Offset: 0x1DA7830 VA: 0x181DA8630
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x1DA1FE0 Offset: 0x1DA11E0 VA: 0x181DA1FE0
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x1DACD40 Offset: 0x1DABF40 VA: 0x181DACD40
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0x1DA88A0 Offset: 0x1DA7AA0 VA: 0x181DA88A0
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0x1DA8C40 Offset: 0x1DA7E40 VA: 0x181DA8C40 Slot: 45
	public virtual void Reset() { }

	// RVA: 0x1DA8A80 Offset: 0x1DA7C80 VA: 0x181DA8A80
	internal void ResetIndexes() { }

	// RVA: 0x1DA8A90 Offset: 0x1DA7C90 VA: 0x181DA8A90
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0x1DA92F0 Offset: 0x1DA84F0 VA: 0x181DA92F0
	internal void RollbackRow(DataRow row) { }

	// RVA: 0x1DA4B10 Offset: 0x1DA3D10 VA: 0x181DA4B10
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1DA4F50 Offset: 0x1DA4150 VA: 0x181DA4F50
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1DA4D80 Offset: 0x1DA3F80 VA: 0x181DA4D80
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0x1DAC930 Offset: 0x1DABB30 VA: 0x181DAC930
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = False, bool fireEvent = True, bool suppressEnsurePropertyChanged = False) { }

	// RVA: 0x1DABF40 Offset: 0x1DAB140 VA: 0x181DABF40
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	// RVA: 0x1DAC9B0 Offset: 0x1DABBB0 VA: 0x181DAC9B0
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0x1DA92D0 Offset: 0x1DA84D0 VA: 0x181DA92D0
	private void RestoreShadowIndexes() { }

	// RVA: 0x1DACC80 Offset: 0x1DABE80 VA: 0x181DACC80
	private void SetShadowIndexes() { }

	// RVA: 0x1DACCC0 Offset: 0x1DABEC0 VA: 0x181DACCC0
	internal void ShadowIndexCopy() { }

	// RVA: 0x1DAD1A0 Offset: 0x1DAC3A0 VA: 0x181DAD1A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1DAD260 Offset: 0x1DAC460 VA: 0x181DAD260
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0x1D97900 Offset: 0x1D96B00 VA: 0x181D97900
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0x1D978F0 Offset: 0x1D96AF0 VA: 0x181D978F0
	internal DataColumn AddUniqueKey() { }

	// RVA: 0x1D97800 Offset: 0x1D96A00 VA: 0x181D97800
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0x1DAD250 Offset: 0x1DAC450 VA: 0x181DAD250
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0x1DA13C0 Offset: 0x1DA05C0 VA: 0x181DA13C0
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0x1DAECD0 Offset: 0x1DADED0 VA: 0x181DAECD0
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0x1C75790 Offset: 0x1C74990 VA: 0x181C75790
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0x1DA3370 Offset: 0x1DA2570 VA: 0x181DA3370
	public void Merge(DataTable table) { }

	// RVA: 0x1DA3390 Offset: 0x1DA2590 VA: 0x181DA3390
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1DAD660 Offset: 0x1DAC860 VA: 0x181DAD660
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0x1D98330 Offset: 0x1D97530 VA: 0x181D98330
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1D98020 Offset: 0x1D97220 VA: 0x181D98020
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	// RVA: 0x1DAD290 Offset: 0x1DAC490 VA: 0x181DAD290
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0x1DA8EF0 Offset: 0x1DA80F0 VA: 0x181DA8EF0
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0x1DA2A10 Offset: 0x1DA1C10 VA: 0x181DA2A10
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0x1DA6ED0 Offset: 0x1DA60D0 VA: 0x181DA6ED0
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x1DA51E0 Offset: 0x1DA43E0 VA: 0x181DA51E0
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x1DA52A0 Offset: 0x1DA44A0 VA: 0x181DA52A0
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x1DA35C0 Offset: 0x1DA27C0 VA: 0x181DA35C0
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x1DA5530 Offset: 0x1DA4730 VA: 0x181DA5530
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x1DA5320 Offset: 0x1DA4520 VA: 0x181DA5320
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1DA5EB0 Offset: 0x1DA50B0 VA: 0x181DA5EB0
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1D9B510 Offset: 0x1D9A710 VA: 0x181D9B510
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	// RVA: 0x1D9B1D0 Offset: 0x1D9A3D0 VA: 0x181D9B1D0
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	// RVA: 0x1DA0BB0 Offset: 0x1D9FDB0 VA: 0x181DA0BB0
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0x17C88F0 Offset: 0x17C7AF0 VA: 0x1817C88F0 Slot: 24
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1DA19E0 Offset: 0x1DA0BE0 VA: 0x181DA19E0 Slot: 46
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0x1DAD080 Offset: 0x1DAC280 VA: 0x181DAD080 Slot: 25
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1DAD150 Offset: 0x1DAC350 VA: 0x181DAD150 Slot: 26
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1DA6EB0 Offset: 0x1DA60B0 VA: 0x181DA6EB0 Slot: 47
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x1DAEA10 Offset: 0x1DADC10 VA: 0x181DAEA10
	internal Hashtable get_RowDiffId() { }

	// RVA: 0x1C61450 Offset: 0x1C60650 VA: 0x181C61450
	internal int get_ObjectID() { }

	// RVA: 0x1D976E0 Offset: 0x1D968E0 VA: 0x181D976E0
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1DA85A0 Offset: 0x1DA77A0 VA: 0x181DA85A0
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1D9FD00 Offset: 0x1D9EF00 VA: 0x181D9FD00
	internal void EvaluateExpressions() { }

	// RVA: 0x1D9FFC0 Offset: 0x1D9F1C0 VA: 0x181D9FFC0
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	// RVA: 0x1D9FA90 Offset: 0x1D9EC90 VA: 0x181D9FA90
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0x1D9F950 Offset: 0x1D9EB50 VA: 0x181D9F950
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0x1D9F0F0 Offset: 0x1D9E2F0 VA: 0x181D9F0F0
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }
}

// Namespace: System.Data
internal sealed class FunctionNode : ExpressionNode // TypeDefIndex: 12644
{
	// Fields
	internal readonly string _name; // 0x18
	internal readonly int _info; // 0x20
	internal int _argumentCount; // 0x24
	internal ExpressionNode[] _arguments; // 0x28
	[Nullable(2)]
	private readonly TypeLimiter _capturedLimiter; // 0x30
	private static readonly Function[] s_funcs; // 0x0

	// Properties
	internal FunctionId Aggregate { get; }
	internal bool IsAggregate { get; }

	// Methods

	// RVA: 0x1DD3840 Offset: 0x1DD2A40 VA: 0x181DD3840
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x1DCF720 Offset: 0x1DCE920 VA: 0x181DCF720
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0x1DCF900 Offset: 0x1DCEB00 VA: 0x181DCF900 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1DD2750 Offset: 0x1DD1950 VA: 0x181DD2750 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1DD1C20 Offset: 0x1DD0E20 VA: 0x181DD1C20 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1DD2710 Offset: 0x1DD1910 VA: 0x181DD2710 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1DD2B70 Offset: 0x1DD1D70 VA: 0x181DD2B70 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1DD2C00 Offset: 0x1DD1E00 VA: 0x181DD2C00 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1DD2A50 Offset: 0x1DD1C50 VA: 0x181DD2A50 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1DD2AE0 Offset: 0x1DD1CE0 VA: 0x181DD2AE0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1DCFE70 Offset: 0x1DCF070 VA: 0x181DCFE70 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1DD2C90 Offset: 0x1DD1E90 VA: 0x181DD2C90 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1DD2770 Offset: 0x1DD1970 VA: 0x181DD2770
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0x1DCFF00 Offset: 0x1DCF100 VA: 0x181DCFF00
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0x1DD3990 Offset: 0x1DD2B90 VA: 0x181DD3990
	internal FunctionId get_Aggregate() { }

	// RVA: 0x1DD3A30 Offset: 0x1DD2C30 VA: 0x181DD3A30
	internal bool get_IsAggregate() { }

	// RVA: 0x1DCFC10 Offset: 0x1DCEE10 VA: 0x181DCFC10
	internal void Check() { }

	// RVA: 0x1DD2E80 Offset: 0x1DD2080 VA: 0x181DD2E80
	private static void .cctor() { }
}

// Namespace: System.Data
internal enum FunctionId // TypeDefIndex: 12645
{
	// Fields
	public int value__; // 0x0
	public const FunctionId none = -1;
	public const FunctionId Ascii = 0;
	public const FunctionId Char = 1;
	public const FunctionId Charindex = 2;
	public const FunctionId Difference = 3;
	public const FunctionId Len = 4;
	public const FunctionId Lower = 5;
	public const FunctionId LTrim = 6;
	public const FunctionId Patindex = 7;
	public const FunctionId Replicate = 8;
	public const FunctionId Reverse = 9;
	public const FunctionId Right = 10;
	public const FunctionId RTrim = 11;
	public const FunctionId Soundex = 12;
	public const FunctionId Space = 13;
	public const FunctionId Str = 14;
	public const FunctionId Stuff = 15;
	public const FunctionId Substring = 16;
	public const FunctionId Upper = 17;
	public const FunctionId IsNull = 18;
	public const FunctionId Iif = 19;
	public const FunctionId Convert = 20;
	public const FunctionId cInt = 21;
	public const FunctionId cBool = 22;
	public const FunctionId cDate = 23;
	public const FunctionId cDbl = 24;
	public const FunctionId cStr = 25;
	public const FunctionId Abs = 26;
	public const FunctionId Acos = 27;
	public const FunctionId In = 28;
	public const FunctionId Trim = 29;
	public const FunctionId Sum = 30;
	public const FunctionId Avg = 31;
	public const FunctionId Min = 32;
	public const FunctionId Max = 33;
	public const FunctionId Count = 34;
	public const FunctionId StDev = 35;
	public const FunctionId Var = 37;
	public const FunctionId DateTimeOffset = 38;
}

// Namespace: System.Data
internal sealed class Function // TypeDefIndex: 12646
{
	// Fields
	internal readonly string _name; // 0x10
	internal readonly FunctionId _id; // 0x18
	internal readonly Type _result; // 0x20
	internal readonly bool _isValidateArguments; // 0x28
	internal readonly bool _isVariantArgumentList; // 0x29
	internal readonly int _argumentCount; // 0x2C
	internal readonly Type[] _parameters; // 0x30
	internal static string[] s_functionName; // 0x0

	// Methods

	// RVA: 0x1DEF150 Offset: 0x1DEE350 VA: 0x181DEF150
	internal void .ctor(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

	// RVA: 0x1DEEB90 Offset: 0x1DEDD90 VA: 0x181DEEB90
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeLimiter.Scope.<>c // TypeDefIndex: 12647
{
	// Fields
	public static readonly TypeLimiter.Scope.<>c <>9; // 0x0
	public static Func<Type, bool> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1DF0E40 Offset: 0x1DF0040 VA: 0x181DF0E40
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1DF0D90 Offset: 0x1DEFF90 VA: 0x181DF0D90
	internal bool <.ctor>b__3_0(Type type) { }
}

// Namespace: 
private sealed class TypeLimiter.Scope : IDisposable // TypeDefIndex: 12648
{
	// Fields
	private static readonly HashSet<Type> s_allowedTypes; // 0x0
	private HashSet<Type> m_allowedTypes; // 0x10
	[Nullable(2)]
	private readonly TypeLimiter.Scope m_previousScope; // 0x18

	// Methods

	// RVA: 0x1DF0380 Offset: 0x1DEF580 VA: 0x181DF0380
	internal void .ctor(TypeLimiter.Scope previousScope, IEnumerable<Type> allowedTypes) { }

	// RVA: 0x1DEF6D0 Offset: 0x1DEE8D0 VA: 0x181DEF6D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1DEF7A0 Offset: 0x1DEE9A0 VA: 0x181DEF7A0
	public bool IsAllowedType(Type type) { }

	// RVA: 0x1DEF940 Offset: 0x1DEEB40 VA: 0x181DEF940
	private static bool IsTypeUnconditionallyAllowed(Type type) { }

	// RVA: 0x1DEFB30 Offset: 0x1DEED30 VA: 0x181DEFB30
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeLimiter.<>c // TypeDefIndex: 12649
{
	// Fields
	public static readonly TypeLimiter.<>c <>9; // 0x0
	public static Func<DataColumn, Type> <>9__10_0; // 0x8
	public static Func<DataTable, IEnumerable<Type>> <>9__11_0; // 0x10

	// Methods

	// RVA: 0x1DF0DE0 Offset: 0x1DEFFE0 VA: 0x181DF0DE0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1DF0D60 Offset: 0x1DEFF60 VA: 0x181DF0D60
	internal Type <GetPreviouslyDeclaredDataTypes>b__10_0(DataColumn column) { }

	// RVA: 0x1DF0D80 Offset: 0x1DEFF80 VA: 0x181DF0D80
	internal IEnumerable<Type> <GetPreviouslyDeclaredDataTypes>b__11_0(DataTable table) { }
}

// Namespace: System.Data
internal sealed class TypeLimiter // TypeDefIndex: 12650
{
	// Fields
	[ThreadStatic]
	[Nullable(2)]
	private static TypeLimiter.Scope s_activeScope; // 0x80000000
	private TypeLimiter.Scope m_instanceScope; // 0x10

	// Properties
	private static bool IsTypeLimitingDisabled { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	private void .ctor(TypeLimiter.Scope scope) { }

	// RVA: 0x1DF0CF0 Offset: 0x1DEFEF0 VA: 0x181DF0CF0
	private static bool get_IsTypeLimitingDisabled() { }

	[NullableContext(2)]
	// RVA: 0x1DF04E0 Offset: 0x1DEF6E0 VA: 0x181DF04E0
	public static TypeLimiter Capture() { }

	[NullableContext(2)]
	// RVA: 0x1DF0550 Offset: 0x1DEF750 VA: 0x181DF0550
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter) { }

	// RVA: 0x1DF0750 Offset: 0x1DEF950 VA: 0x181DF0750
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	// RVA: 0x1DF0970 Offset: 0x1DEFB70 VA: 0x181DF0970
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	// RVA: 0x1DF0BB0 Offset: 0x1DEFDB0 VA: 0x181DF0BB0
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	// RVA: 0x1DF0A70 Offset: 0x1DEFC70 VA: 0x181DF0A70
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet) { }
}

// Namespace: System.Data
public enum AcceptRejectRule // TypeDefIndex: 12651
{
	// Fields
	public int value__; // 0x0
	public const AcceptRejectRule None = 0;
	public const AcceptRejectRule Cascade = 1;
}

// Namespace: System.Data
internal enum AggregateType // TypeDefIndex: 12652
{
	// Fields
	public int value__; // 0x0
	public const AggregateType None = 0;
	public const AggregateType Sum = 4;
	public const AggregateType Mean = 5;
	public const AggregateType Min = 6;
	public const AggregateType Max = 7;
	public const AggregateType First = 8;
	public const AggregateType Count = 9;
	public const AggregateType Var = 10;
	public const AggregateType StDev = 11;
}

// Namespace: System.Data
public class InternalDataCollectionBase : ICollection, IEnumerable // TypeDefIndex: 12653
{
	// Fields
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x0

	// Properties
	[Browsable(False)]
	public virtual int Count { get; }
	[Browsable(False)]
	public bool IsSynchronized { get; }
	[Browsable(False)]
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }

	// Methods

	// RVA: 0x1DEF560 Offset: 0x1DEE760 VA: 0x181DEF560 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x1DEF350 Offset: 0x1DEE550 VA: 0x181DEF350 Slot: 10
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0x1DEF3B0 Offset: 0x1DEE5B0 VA: 0x181DEF3B0 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1DEF3F0 Offset: 0x1DEE5F0 VA: 0x181DEF3F0
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	protected virtual ArrayList get_List() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1DEF4F0 Offset: 0x1DEE6F0 VA: 0x181DEF4F0
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class ColumnTypeConverter : TypeConverter // TypeDefIndex: 12654
{
	// Fields
	private static readonly Type[] s_types; // 0x0
	private TypeConverter.StandardValuesCollection _values; // 0x10

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x1DD4860 Offset: 0x1DD3A60 VA: 0x181DD4860 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1DD4B30 Offset: 0x1DD3D30 VA: 0x181DD4B30 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1DD47B0 Offset: 0x1DD39B0 VA: 0x181DD47B0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1DD4910 Offset: 0x1DD3B10 VA: 0x181DD4910 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1DD5100 Offset: 0x1DD4300 VA: 0x181DD5100 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1DD5230 Offset: 0x1DD4430 VA: 0x181DD5230
	private static void .cctor() { }
}

// Namespace: System.Data
[EventSource(Name = "System.Data.DataCommonEventSource")]
internal class DataCommonEventSource : EventSource // TypeDefIndex: 12655
{
	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static long s_nextScopeId; // 0x8

	// Methods

	[Event(1, Level = 4)]
	// RVA: 0x1DDE1B0 Offset: 0x1DDD3B0 VA: 0x181DDE1B0
	internal void Trace(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9557A0 Offset: 0x9549A0 VA: 0x1809557A0
	|-DataCommonEventSource.Trace<int>
	|
	|-RVA: 0x955870 Offset: 0x954A70 VA: 0x180955870
	|-DataCommonEventSource.Trace<object>
	|
	|-RVA: 0x9543B0 Offset: 0x9535B0 VA: 0x1809543B0
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9544D0 Offset: 0x9536D0 VA: 0x1809544D0
	|-DataCommonEventSource.Trace<int, bool>
	|
	|-RVA: 0x9545D0 Offset: 0x9537D0 VA: 0x1809545D0
	|-DataCommonEventSource.Trace<int, int>
	|-DataCommonEventSource.Trace<int, Int32Enum>
	|
	|-RVA: 0x954EF0 Offset: 0x9540F0 VA: 0x180954EF0
	|-DataCommonEventSource.Trace<int, long>
	|
	|-RVA: 0x9556C0 Offset: 0x9548C0 VA: 0x1809556C0
	|-DataCommonEventSource.Trace<int, object>
	|
	|-RVA: 0x954220 Offset: 0x953420 VA: 0x180954220
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9546D0 Offset: 0x9538D0 VA: 0x1809546D0
	|-DataCommonEventSource.Trace<int, int, bool>
	|
	|-RVA: 0x954DD0 Offset: 0x953FD0 VA: 0x180954DD0
	|-DataCommonEventSource.Trace<int, int, int>
	|-DataCommonEventSource.Trace<int, int, Int32Enum>
	|
	|-RVA: 0x954FF0 Offset: 0x9541F0 VA: 0x180954FF0
	|-DataCommonEventSource.Trace<int, object, Int32Enum>
	|
	|-RVA: 0x9555D0 Offset: 0x9547D0 VA: 0x1809555D0
	|-DataCommonEventSource.Trace<int, object, object>
	|
	|-RVA: 0x954010 Offset: 0x953210 VA: 0x180954010
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x954B70 Offset: 0x953D70 VA: 0x180954B70
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0x9553A0 Offset: 0x9545A0 VA: 0x1809553A0
	|-DataCommonEventSource.Trace<int, object, object, Int32Enum>
	|
	|-RVA: 0x953C80 Offset: 0x952E80 VA: 0x180953C80
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x955100 Offset: 0x954300 VA: 0x180955100
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|
	|-RVA: 0x953840 Offset: 0x952A40 VA: 0x180953840
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9547F0 Offset: 0x9539F0 VA: 0x1809547F0
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0x9532B0 Offset: 0x9524B0 VA: 0x1809532B0
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(2, Level = 5)]
	// RVA: 0x1DDE0D0 Offset: 0x1DDD2D0 VA: 0x181DDE0D0
	internal long EnterScope(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9531E0 Offset: 0x9523E0 VA: 0x1809531E0
	|-DataCommonEventSource.EnterScope<int>
	|
	|-RVA: 0x952830 Offset: 0x951A30 VA: 0x180952830
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x952950 Offset: 0x951B50 VA: 0x180952950
	|-DataCommonEventSource.EnterScope<int, bool>
	|
	|-RVA: 0x952B80 Offset: 0x951D80 VA: 0x180952B80
	|-DataCommonEventSource.EnterScope<int, int>
	|-DataCommonEventSource.EnterScope<int, Int32Enum>
	|
	|-RVA: 0x953100 Offset: 0x952300 VA: 0x180953100
	|-DataCommonEventSource.EnterScope<int, object>
	|
	|-RVA: 0x9526A0 Offset: 0x9518A0 VA: 0x1809526A0
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x952A50 Offset: 0x951C50 VA: 0x180952A50
	|-DataCommonEventSource.EnterScope<int, int, bool>
	|-DataCommonEventSource.EnterScope<int, Int32Enum, bool>
	|
	|-RVA: 0x952EE0 Offset: 0x9520E0 VA: 0x180952EE0
	|-DataCommonEventSource.EnterScope<int, int, object>
	|
	|-RVA: 0x952FF0 Offset: 0x9521F0 VA: 0x180952FF0
	|-DataCommonEventSource.EnterScope<int, object, bool>
	|
	|-RVA: 0x952490 Offset: 0x951690 VA: 0x180952490
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x952C80 Offset: 0x951E80 VA: 0x180952C80
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-RVA: 0x952100 Offset: 0x951300 VA: 0x180952100
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(3, Level = 5)]
	// RVA: 0x1DDE1A0 Offset: 0x1DDD3A0 VA: 0x181DDE1A0
	internal void ExitScope(long scopeId) { }

	// RVA: 0x172F990 Offset: 0x172EB90 VA: 0x18172F990
	public void .ctor() { }

	// RVA: 0x1DDE1C0 Offset: 0x1DDD3C0 VA: 0x181DDE1C0
	private static void .cctor() { }
}

// Namespace: System.Data
[TypeConverter(typeof(ConstraintConverter))]
[DefaultProperty("ConstraintName")]
public abstract class Constraint // TypeDefIndex: 12656
{
	// Fields
	private string _schemaName; // 0x10
	private bool _inCollection; // 0x18
	private DataSet _dataSet; // 0x20
	internal string _name; // 0x28
	internal PropertyCollection _extendedProperties; // 0x30

	// Properties
	[DefaultValue("")]
	public virtual string ConstraintName { get; set; }
	internal string SchemaName { get; set; }
	internal virtual bool InCollection { get; set; }
	public abstract DataTable Table { get; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	[CLSCompliant(False)]
	protected virtual DataSet _DataSet { get; }

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 4
	public virtual string get_ConstraintName() { }

	// RVA: 0x1DDA220 Offset: 0x1DD9420 VA: 0x181DDA220 Slot: 5
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0x1DDA1E0 Offset: 0x1DD93E0 VA: 0x181DDA1E0
	internal string get_SchemaName() { }

	// RVA: 0x1DDA4A0 Offset: 0x1DD96A0 VA: 0x181DDA4A0
	internal void set_SchemaName(string value) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20 Slot: 6
	internal virtual bool get_InCollection() { }

	// RVA: 0x1DDA450 Offset: 0x1DD9650 VA: 0x181DDA450 Slot: 7
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DataTable get_Table();

	// RVA: 0x1DDA180 Offset: 0x1DD9380 VA: 0x181DDA180
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool ContainsColumn(DataColumn column);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool CanEnableConstraint();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract Constraint Clone(DataSet destination);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

	// RVA: 0x1DD9FA0 Offset: 0x1DD91A0 VA: 0x181DD9FA0
	internal void CheckConstraint() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void CheckConstraint(DataRow row, DataRowAction action);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void CheckState();

	// RVA: 0x1DDA000 Offset: 0x1DD9200 VA: 0x181DDA000
	protected void CheckStateForProperty() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 17
	protected virtual DataSet get__DataSet() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract bool IsConstraintViolated();

	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170 Slot: 3
	public override string ToString() { }

	// RVA: 0x1DDA120 Offset: 0x1DD9320 VA: 0x181DDA120
	protected void .ctor() { }
}

// Namespace: System.Data
[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
public sealed class ConstraintCollection : InternalDataCollectionBase // TypeDefIndex: 12657
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private CollectionChangeEventHandler _onCollectionChanged; // 0x28
	private Constraint[] _delayLoadingConstraints; // 0x30
	private bool _fLoadForeignKeyConstraintsOnly; // 0x38

	// Properties
	protected override ArrayList List { get; }
	public Constraint Item { get; }
	internal DataTable Table { get; }
	public Constraint Item { get; }

	// Methods

	// RVA: 0x1DD8E80 Offset: 0x1DD8080 VA: 0x181DD8E80
	internal void .ctor(DataTable table) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x1DD8F20 Offset: 0x1DD8120 VA: 0x181DD8F20
	public Constraint get_Item(int index) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal DataTable get_Table() { }

	// RVA: 0x1DD9060 Offset: 0x1DD8260 VA: 0x181DD9060
	public Constraint get_Item(string name) { }

	// RVA: 0x1DD60A0 Offset: 0x1DD52A0 VA: 0x181DD60A0
	public void Add(Constraint constraint) { }

	// RVA: 0x1DD6170 Offset: 0x1DD5370 VA: 0x181DD6170
	internal void Add(Constraint constraint, bool addUniqueWhenAddingForeign) { }

	// RVA: 0x1DD60B0 Offset: 0x1DD52B0 VA: 0x181DD60B0
	public Constraint Add(string name, DataColumn[] columns, bool primaryKey) { }

	// RVA: 0x1DD5FA0 Offset: 0x1DD51A0 VA: 0x181DD5FA0
	private void AddUniqueConstraint(UniqueConstraint constraint) { }

	// RVA: 0x1DD5F20 Offset: 0x1DD5120 VA: 0x181DD5F20
	private void AddForeignKeyConstraint(ForeignKeyConstraint constraint) { }

	// RVA: 0x1DD6A00 Offset: 0x1DD5C00 VA: 0x181DD6A00
	private bool AutoGenerated(Constraint constraint) { }

	// RVA: 0x1DD6940 Offset: 0x1DD5B40 VA: 0x181DD6940
	private void ArrayAdd(Constraint constraint) { }

	// RVA: 0x1DD6990 Offset: 0x1DD5B90 VA: 0x181DD6990
	private void ArrayRemove(Constraint constraint) { }

	// RVA: 0x1DD69E0 Offset: 0x1DD5BE0 VA: 0x181DD69E0
	internal string AssignName() { }

	// RVA: 0x1DD6AE0 Offset: 0x1DD5CE0 VA: 0x181DD6AE0
	private void BaseAdd(Constraint constraint) { }

	// RVA: 0x1DD6BD0 Offset: 0x1DD5DD0 VA: 0x181DD6BD0
	private void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength) { }

	// RVA: 0x1DD6DF0 Offset: 0x1DD5FF0 VA: 0x181DD6DF0
	private void BaseRemove(Constraint constraint) { }

	// RVA: 0x1DD71B0 Offset: 0x1DD63B0 VA: 0x181DD71B0
	internal bool CanRemove(Constraint constraint, bool fThrowException) { }

	// RVA: 0x1DD71E0 Offset: 0x1DD63E0 VA: 0x181DD71E0
	public void Clear() { }

	// RVA: 0x1DD77B0 Offset: 0x1DD69B0 VA: 0x181DD77B0
	public bool Contains(string name) { }

	// RVA: 0x1DD77D0 Offset: 0x1DD69D0 VA: 0x181DD77D0
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x1DD7960 Offset: 0x1DD6B60 VA: 0x181DD7960
	internal Constraint FindConstraint(Constraint constraint) { }

	// RVA: 0x1DD7CC0 Offset: 0x1DD6EC0 VA: 0x181DD7CC0
	internal UniqueConstraint FindKeyConstraint(DataColumn[] columns) { }

	// RVA: 0x1DD7E10 Offset: 0x1DD7010 VA: 0x181DD7E10
	internal UniqueConstraint FindKeyConstraint(DataColumn column) { }

	// RVA: 0x1DD7B50 Offset: 0x1DD6D50 VA: 0x181DD7B50
	internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1DD7710 Offset: 0x1DD6910 VA: 0x181DD7710
	private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2) { }

	// RVA: 0x1DD8650 Offset: 0x1DD7850 VA: 0x181DD8650
	internal int InternalIndexOf(string constraintName) { }

	// RVA: 0x1DD8870 Offset: 0x1DD7A70 VA: 0x181DD8870
	private string MakeName(int index) { }

	// RVA: 0x1DD8910 Offset: 0x1DD7B10 VA: 0x181DD8910
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1DD8930 Offset: 0x1DD7B30 VA: 0x181DD8930
	internal void RegisterName(string name) { }

	// RVA: 0x1DD8BC0 Offset: 0x1DD7DC0 VA: 0x181DD8BC0
	public void Remove(Constraint constraint) { }

	// RVA: 0x1DD8DF0 Offset: 0x1DD7FF0 VA: 0x181DD8DF0
	internal void UnregisterName(string name) { }

	// RVA: 0x1DD7F60 Offset: 0x1DD7160 VA: 0x181DD7F60
	internal void FinishInitConstraints() { }
}

// Namespace: System.Data
internal sealed class ConstraintConverter : ExpandableObjectConverter // TypeDefIndex: 12658
{
	// Methods

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }

	// RVA: 0x1DD9190 Offset: 0x1DD8390 VA: 0x181DD9190 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1DD9240 Offset: 0x1DD8440 VA: 0x181DD9240 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
internal class ConstraintEnumerator // TypeDefIndex: 12659
{
	// Fields
	private IEnumerator _tables; // 0x10
	private IEnumerator _constraints; // 0x18
	private Constraint _currentObject; // 0x20

	// Properties
	protected Constraint CurrentObject { get; }

	// Methods

	// RVA: 0x1DD9F40 Offset: 0x1DD9140 VA: 0x181DD9F40
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x1DD9D90 Offset: 0x1DD8F90 VA: 0x181DD9D90
	public bool GetNext() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Constraint GetConstraint() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 4
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	protected Constraint get_CurrentObject() { }
}

// Namespace: System.Data
internal class ForeignKeyConstraintEnumerator : ConstraintEnumerator // TypeDefIndex: 12660
{
	// Methods

	// RVA: 0x1DD9F40 Offset: 0x1DD9140 VA: 0x181DD9F40
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x1DEEB10 Offset: 0x1DEDD10 VA: 0x181DEEB10 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x1DEEA80 Offset: 0x1DEDC80 VA: 0x181DEEA80
	public ForeignKeyConstraint GetForeignKeyConstraint() { }
}

// Namespace: System.Data
internal sealed class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator // TypeDefIndex: 12661
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0x1DD4740 Offset: 0x1DD3940 VA: 0x181DD4740
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0x1DD4610 Offset: 0x1DD3810 VA: 0x181DD4610 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }
}

// Namespace: System.Data
internal sealed class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator // TypeDefIndex: 12662
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0x1DD4740 Offset: 0x1DD3940 VA: 0x181DD4740
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0x1DEF5A0 Offset: 0x1DEE7A0 VA: 0x181DEF5A0 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }
}

// Namespace: System.Data
public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 12663
{
	// Fields
	private DataColumn _column; // 0x10
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x18
	[CompilerGenerated]
	private object <ProposedValue>k__BackingField; // 0x20

	// Properties
	public object ProposedValue { get; set; }

	// Methods

	// RVA: 0x1DDA4E0 Offset: 0x1DD96E0 VA: 0x181DDA4E0
	internal void .ctor(DataRow row) { }

	// RVA: 0x1DDA540 Offset: 0x1DD9740 VA: 0x181DDA540
	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public object get_ProposedValue() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ProposedValue(object value) { }

	// RVA: 0x1DDA4D0 Offset: 0x1DD96D0 VA: 0x181DDA4D0
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }
}

// Namespace: System.Data
public sealed class DataColumnChangeEventHandler : MulticastDelegate // TypeDefIndex: 12664
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DataColumnChangeEventArgs e) { }
}

// Namespace: System.Data
[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
public sealed class DataColumnCollection : InternalDataCollectionBase // TypeDefIndex: 12665
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataColumn[] _delayedAddRangeColumns; // 0x28
	private readonly Dictionary<string, DataColumn> _columnFromName; // 0x30
	private bool _fInClear; // 0x38
	private DataColumn[] _columnsImplementingIChangeTracking; // 0x40
	private int _nColumnsImplementingIChangeTracking; // 0x48
	private int _nColumnsImplementingIRevertibleChangeTracking; // 0x4C
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanged; // 0x50
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanging; // 0x58
	[CompilerGenerated]
	private CollectionChangeEventHandler ColumnPropertyChanged; // 0x60

	// Properties
	protected override ArrayList List { get; }
	internal DataColumn[] ColumnsImplementingIChangeTracking { get; }
	internal int ColumnsImplementingIChangeTrackingCount { get; }
	internal int ColumnsImplementingIRevertibleChangeTrackingCount { get; }
	public DataColumn Item { get; }
	public DataColumn Item { get; }
	internal DataColumn Item { get; }

	// Methods

	// RVA: 0x1DDD1C0 Offset: 0x1DDC3C0 VA: 0x181DDD1C0
	internal void .ctor(DataTable table) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0x547AA0 Offset: 0x546CA0 VA: 0x180547AA0
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0x1DDD4A0 Offset: 0x1DDC6A0 VA: 0x181DDD4A0
	public DataColumn get_Item(int index) { }

	// RVA: 0x1DDD590 Offset: 0x1DDC790 VA: 0x181DDD590
	public DataColumn get_Item(string name) { }

	// RVA: 0x1DDD3F0 Offset: 0x1DDC5F0 VA: 0x181DDD3F0
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0x1DDA9B0 Offset: 0x1DD9BB0 VA: 0x181DDA9B0
	public void Add(DataColumn column) { }

	// RVA: 0x1DDA5C0 Offset: 0x1DD97C0 VA: 0x181DDA5C0
	internal void AddAt(int index, DataColumn column) { }

	[CompilerGenerated]
	// RVA: 0x1DDD2B0 Offset: 0x1DDC4B0 VA: 0x181DDD2B0
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1DDD720 Offset: 0x1DDC920 VA: 0x181DDD720
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1DDD350 Offset: 0x1DDC550 VA: 0x181DDD350
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1DDD7C0 Offset: 0x1DDC9C0 VA: 0x181DDD7C0
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1DDAA10 Offset: 0x1DD9C10 VA: 0x181DDAA10
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0x1DDA9C0 Offset: 0x1DD9BC0 VA: 0x181DDA9C0
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0x1DDAA90 Offset: 0x1DD9C90 VA: 0x181DDAA90
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0x1DDAD30 Offset: 0x1DD9F30 VA: 0x181DDAD30
	internal string AssignName() { }

	// RVA: 0x1DDAE50 Offset: 0x1DDA050 VA: 0x181DDAE50
	private void BaseAdd(DataColumn column) { }

	// RVA: 0x1DDB290 Offset: 0x1DDA490 VA: 0x181DDB290
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0x1DDB4B0 Offset: 0x1DDA6B0 VA: 0x181DDB4B0
	private void BaseRemove(DataColumn column) { }

	// RVA: 0x1DDB720 Offset: 0x1DDA920 VA: 0x181DDB720
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0x1DDC0A0 Offset: 0x1DDB2A0 VA: 0x181DDC0A0
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0x1DDC220 Offset: 0x1DDB420 VA: 0x181DDC220
	public void Clear() { }

	// RVA: 0x1DDC6F0 Offset: 0x1DDB8F0 VA: 0x181DDC6F0
	public bool Contains(string name) { }

	// RVA: 0x1DDC630 Offset: 0x1DDB830 VA: 0x181DDC630
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x1DDC9F0 Offset: 0x1DDBBF0 VA: 0x181DDC9F0
	public int IndexOf(string columnName) { }

	// RVA: 0x1DDC840 Offset: 0x1DDBA40 VA: 0x181DDC840
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0x1DDC780 Offset: 0x1DDB980 VA: 0x181DDC780
	internal void FinishInitCollection() { }

	// RVA: 0x1DDCB00 Offset: 0x1DDBD00 VA: 0x181DDCB00
	private string MakeName(int index) { }

	// RVA: 0x1DDCBA0 Offset: 0x1DDBDA0 VA: 0x181DDCBA0
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1DDCC40 Offset: 0x1DDBE40 VA: 0x181DDCC40
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1DDCC60 Offset: 0x1DDBE60 VA: 0x181DDCC60
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1DDCCB0 Offset: 0x1DDBEB0 VA: 0x181DDCCB0
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0x1DDB6C0 Offset: 0x1DDA8C0 VA: 0x181DDB6C0
	internal bool CanRegisterName(string name) { }

	// RVA: 0x1DDCF80 Offset: 0x1DDC180 VA: 0x181DDCF80
	public void Remove(DataColumn column) { }

	// RVA: 0x1DDD090 Offset: 0x1DDC290 VA: 0x181DDD090
	internal void UnregisterName(string name) { }

	// RVA: 0x1DDA8E0 Offset: 0x1DD9AE0 VA: 0x181DDA8E0
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0x1DDCE50 Offset: 0x1DDC050 VA: 0x181DDCE50
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }
}

// Namespace: System.Data
internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 12666
{
	// Fields
	[CompilerGenerated]
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Properties
	public override AttributeCollection Attributes { get; }
	internal DataColumn Column { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	public override bool IsBrowsable { get; }

	// Methods

	// RVA: 0x1DDDDD0 Offset: 0x1DDCFD0 VA: 0x181DDDDD0
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0x1DDDE10 Offset: 0x1DDD010 VA: 0x181DDDE10 Slot: 6
	public override AttributeCollection get_Attributes() { }

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	internal DataColumn get_Column() { }

	// RVA: 0x1DDDFE0 Offset: 0x1DDD1E0 VA: 0x181DDDFE0 Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x1DDE090 Offset: 0x1DDD290 VA: 0x181DDE090 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x1DDE0B0 Offset: 0x1DDD2B0 VA: 0x181DDE0B0 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x1DDD9A0 Offset: 0x1DDCBA0 VA: 0x181DDD9A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1DDDA40 Offset: 0x1DDCC40 VA: 0x181DDDA40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1DDD860 Offset: 0x1DDCA60 VA: 0x181DDD860 Slot: 23
	public override bool CanResetValue(object component) { }

	// RVA: 0x1DDDA70 Offset: 0x1DDCC70 VA: 0x181DDDA70 Slot: 26
	public override object GetValue(object component) { }

	// RVA: 0x1DDDB60 Offset: 0x1DDCD60 VA: 0x181DDDB60 Slot: 29
	public override void ResetValue(object component) { }

	// RVA: 0x1DDDC80 Offset: 0x1DDCE80 VA: 0x181DDDC80 Slot: 30
	public override void SetValue(object component, object value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 31
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x1DDE040 Offset: 0x1DDD240 VA: 0x181DDE040 Slot: 9
	public override bool get_IsBrowsable() { }
}

// Namespace: 
internal struct DataError.ColumnError // TypeDefIndex: 12667
{
	// Fields
	internal DataColumn _column; // 0x0
	internal string _error; // 0x8
}

// Namespace: System.Data
internal sealed class DataError // TypeDefIndex: 12668
{
	// Fields
	private string _rowError; // 0x10
	private int _count; // 0x18
	private DataError.ColumnError[] _errorList; // 0x20

	// Properties
	internal string Text { get; set; }
	internal bool HasErrors { get; }

	// Methods

	// RVA: 0x1DDE9C0 Offset: 0x1DDDBC0 VA: 0x181DDE9C0
	internal void .ctor() { }

	// RVA: 0x1DDE920 Offset: 0x1DDDB20 VA: 0x181DDE920
	internal void .ctor(string rowError) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal string get_Text() { }

	// RVA: 0x1DDEA40 Offset: 0x1DDDC40 VA: 0x181DDEA40
	internal void set_Text(string value) { }

	// RVA: 0x1DDEA10 Offset: 0x1DDDC10 VA: 0x181DDEA10
	internal bool get_HasErrors() { }

	// RVA: 0x1DDE640 Offset: 0x1DDD840 VA: 0x181DDE640
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x1DDE370 Offset: 0x1DDD570 VA: 0x181DDE370
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0x1DDE230 Offset: 0x1DDD430 VA: 0x181DDE230
	internal void Clear(DataColumn column) { }

	// RVA: 0x1DDE2E0 Offset: 0x1DDD4E0 VA: 0x181DDE2E0
	internal void Clear() { }

	// RVA: 0x1DDE410 Offset: 0x1DDD610 VA: 0x181DDE410
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0x1DDE8C0 Offset: 0x1DDDAC0 VA: 0x181DDE8C0
	private void SetText(string errorText) { }

	// RVA: 0x1DDE4F0 Offset: 0x1DDD6F0 VA: 0x181DDE4F0
	internal int IndexOf(DataColumn column) { }
}

// Namespace: System.Data
[IsReadOnly]
internal struct DataKey // TypeDefIndex: 12669
{
	// Fields
	private readonly DataColumn[] _columns; // 0x0

	// Properties
	internal DataColumn[] ColumnsReference { get; }
	internal bool HasValue { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x1DDF460 Offset: 0x1DDE660 VA: 0x181DDF460
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x180B7A0 Offset: 0x180A9A0 VA: 0x18180B7A0
	internal bool get_HasValue() { }

	// RVA: 0x1DDF700 Offset: 0x1DDE900 VA: 0x181DDF700
	internal DataTable get_Table() { }

	// RVA: 0x1DDEAA0 Offset: 0x1DDDCA0 VA: 0x181DDEAA0
	internal void CheckState() { }

	// RVA: 0x1DDEC60 Offset: 0x1DDDE60 VA: 0x181DDEC60
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0x1DDEBA0 Offset: 0x1DDDDA0 VA: 0x181DDEBA0
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0x1DDED20 Offset: 0x1DDDF20 VA: 0x181DDED20
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1DDEF70 Offset: 0x1DDE170 VA: 0x181DDEF70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1DDEE40 Offset: 0x1DDE040 VA: 0x181DDEE40 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1DDED80 Offset: 0x1DDDF80 VA: 0x181DDED80
	internal bool Equals(DataKey value) { }

	// RVA: 0x1DDEEC0 Offset: 0x1DDE0C0 VA: 0x181DDEEC0
	internal string[] GetColumnNames() { }

	// RVA: 0x1DDEFC0 Offset: 0x1DDE1C0 VA: 0x181DDEFC0
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0x1DDF0C0 Offset: 0x1DDE2C0 VA: 0x181DDF0C0
	internal object[] GetKeyValues(int record) { }

	// RVA: 0x1DDF250 Offset: 0x1DDE450 VA: 0x181DDF250
	internal Index GetSortIndex() { }

	// RVA: 0x1DDF1E0 Offset: 0x1DDE3E0 VA: 0x181DDF1E0
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0x1DDF2B0 Offset: 0x1DDE4B0 VA: 0x181DDF2B0
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0x1DDF360 Offset: 0x1DDE560 VA: 0x181DDF360
	internal DataColumn[] ToArray() { }
}

// Namespace: System.Data
[DefaultProperty("RelationName")]
[TypeConverter(typeof(RelationshipConverter))]
public class DataRelation // TypeDefIndex: 12670
{
	// Fields
	private DataSet _dataSet; // 0x10
	internal PropertyCollection _extendedProperties; // 0x18
	internal string _relationName; // 0x20
	private DataKey _childKey; // 0x28
	private DataKey _parentKey; // 0x30
	private UniqueConstraint _parentKeyConstraint; // 0x38
	private ForeignKeyConstraint _childKeyConstraint; // 0x40
	internal string[] _parentColumnNames; // 0x48
	internal string[] _childColumnNames; // 0x50
	internal string _parentTableName; // 0x58
	internal string _childTableName; // 0x60
	internal string _parentTableNamespace; // 0x68
	internal string _childTableNamespace; // 0x70
	internal bool _nested; // 0x78
	internal bool _createConstraints; // 0x79
	private bool _checkMultipleNested; // 0x7A
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x7C
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x80

	// Properties
	public virtual DataColumn[] ChildColumns { get; }
	internal DataColumn[] ChildColumnsReference { get; }
	internal DataKey ChildKey { get; }
	public virtual DataTable ChildTable { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public virtual DataSet DataSet { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	public virtual DataColumn[] ParentColumns { get; }
	internal DataColumn[] ParentColumnsReference { get; }
	internal DataKey ParentKey { get; }
	public virtual DataTable ParentTable { get; }
	[DefaultValue("")]
	public virtual string RelationName { get; }
	[DefaultValue(False)]
	public virtual bool Nested { get; set; }
	public virtual UniqueConstraint ParentKeyConstraint { get; }
	public virtual ForeignKeyConstraint ChildKeyConstraint { get; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool CheckMultipleNested { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1DE32D0 Offset: 0x1DE24D0 VA: 0x181DE32D0
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0x1DE35C0 Offset: 0x1DE27C0 VA: 0x181DE35C0
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1DE3500 Offset: 0x1DE2700 VA: 0x181DE3500
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	[Browsable(False)]
	// RVA: 0x1DE36B0 Offset: 0x1DE28B0 VA: 0x181DE36B0
	public void .ctor(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	[Browsable(False)]
	// RVA: 0x1DE35E0 Offset: 0x1DE27E0 VA: 0x181DE35E0
	public void .ctor(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0x1DE37A0 Offset: 0x1DE29A0 VA: 0x181DE37A0 Slot: 4
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0x1DE3780 Offset: 0x1DE2980 VA: 0x181DE3780
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0x1DE3780 Offset: 0x1DE2980 VA: 0x181DE3780
	internal DataKey get_ChildKey() { }

	// RVA: 0x1DE37E0 Offset: 0x1DE29E0 VA: 0x181DE37E0 Slot: 5
	public virtual DataTable get_ChildTable() { }

	// RVA: 0x1DE3820 Offset: 0x1DE2A20 VA: 0x181DE3820 Slot: 6
	public virtual DataSet get_DataSet() { }

	// RVA: 0x1DE38C0 Offset: 0x1DE2AC0 VA: 0x181DE38C0
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x1DE3770 Offset: 0x1DE2970 VA: 0x181DE3770
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x1DE2C00 Offset: 0x1DE1E00 VA: 0x181DE2C00
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0x1DE2500 Offset: 0x1DE1700 VA: 0x181DE2500
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0x1DE28A0 Offset: 0x1DE1AA0 VA: 0x181DE28A0
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x1DE2690 Offset: 0x1DE1890 VA: 0x181DE2690
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x1DE2E90 Offset: 0x1DE2090 VA: 0x181DE2E90
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x1DE38D0 Offset: 0x1DE2AD0 VA: 0x181DE38D0 Slot: 7
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0x1DE3910 Offset: 0x1DE2B10 VA: 0x181DE3910
	internal DataKey get_ParentKey() { }

	// RVA: 0x1DE3930 Offset: 0x1DE2B30 VA: 0x181DE3930 Slot: 8
	public virtual DataTable get_ParentTable() { }

	// RVA: 0x1DE3970 Offset: 0x1DE2B70 VA: 0x181DE3970 Slot: 9
	public virtual string get_RelationName() { }

	// RVA: 0x1DE1030 Offset: 0x1DE0230 VA: 0x181DE1030
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0x1DE12D0 Offset: 0x1DE04D0 VA: 0x181DE12D0
	internal void CheckNestedRelations() { }

	// RVA: 0x1DE38A0 Offset: 0x1DE2AA0 VA: 0x181DE38A0 Slot: 10
	public virtual bool get_Nested() { }

	// RVA: 0x1DE39A0 Offset: 0x1DE2BA0 VA: 0x181DE39A0 Slot: 11
	public virtual void set_Nested(bool value) { }

	// RVA: 0x1DE38F0 Offset: 0x1DE2AF0 VA: 0x181DE38F0 Slot: 12
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0x1DE37C0 Offset: 0x1DE29C0 VA: 0x181DE37C0 Slot: 13
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0x1DE3840 Offset: 0x1DE2A40 VA: 0x181DE3840
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1C16520 Offset: 0x1C15720 VA: 0x181C16520
	internal bool get_CheckMultipleNested() { }

	// RVA: 0x1DE3990 Offset: 0x1DE2B90 VA: 0x181DE3990
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0x1DE1860 Offset: 0x1DE0A60 VA: 0x181DE1860
	internal void CheckState() { }

	// RVA: 0x1DE1750 Offset: 0x1DE0950 VA: 0x181DE1750
	protected void CheckStateForProperty() { }

	// RVA: 0x1DE2220 Offset: 0x1DE1420 VA: 0x181DE2220
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x1DE1B50 Offset: 0x1DE0D50 VA: 0x181DE1B50
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0x1DE2CB0 Offset: 0x1DE1EB0 VA: 0x181DE2CB0
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1DE2D80 Offset: 0x1DE1F80 VA: 0x181DE2D80
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x75AB00 Offset: 0x759D00 VA: 0x18075AB00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1DE2EA0 Offset: 0x1DE20A0 VA: 0x181DE2EA0
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0x1DE2A30 Offset: 0x1DE1C30 VA: 0x181DE2A30
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0x1C44BB0 Offset: 0x1C43DB0 VA: 0x181C44BB0
	internal int get_ObjectID() { }
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class DataRelationCollection.DataTableRelationCollection : DataRelationCollection // TypeDefIndex: 12671
{
	// Fields
	private readonly DataTable _table; // 0x38
	private readonly ArrayList _relations; // 0x40
	private readonly bool _fParentCollection; // 0x48
	[CompilerGenerated]
	private CollectionChangeEventHandler RelationPropertyChanged; // 0x50

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0x1DEE640 Offset: 0x1DED840 VA: 0x181DEE640
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x1DEE2F0 Offset: 0x1DED4F0 VA: 0x181DEE2F0
	private void EnsureDataSet() { }

	// RVA: 0x1DEE340 Offset: 0x1DED540 VA: 0x181DEE340 Slot: 18
	protected override DataSet GetDataSet() { }

	// RVA: 0x1DEE8B0 Offset: 0x1DEDAB0 VA: 0x181DEE8B0 Slot: 13
	public override DataRelation get_Item(int index) { }

	// RVA: 0x1DEE780 Offset: 0x1DED980 VA: 0x181DEE780 Slot: 14
	public override DataRelation get_Item(string name) { }

	[CompilerGenerated]
	// RVA: 0x1DEE6E0 Offset: 0x1DED8E0 VA: 0x181DEE6E0
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1DEE9E0 Offset: 0x1DEDBE0 VA: 0x181DEE9E0
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1DEE180 Offset: 0x1DED380 VA: 0x181DEE180
	private void AddCache(DataRelation relation) { }

	// RVA: 0x1DEE1D0 Offset: 0x1DED3D0 VA: 0x181DEE1D0 Slot: 15
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0x1DEE390 Offset: 0x1DED590 VA: 0x181DEE390
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0x1DEE480 Offset: 0x1DED680 VA: 0x181DEE480 Slot: 21
	protected override void RemoveCore(DataRelation relation) { }
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class DataRelationCollection.DataSetRelationCollection : DataRelationCollection // TypeDefIndex: 12672
{
	// Fields
	private readonly DataSet _dataSet; // 0x38
	private readonly ArrayList _relations; // 0x40
	private DataRelation[] _delayLoadingRelations; // 0x48

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0x1DEAF70 Offset: 0x1DEA170 VA: 0x181DEAF70
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x1DEA770 Offset: 0x1DE9970 VA: 0x181DEA770 Slot: 16
	public override void Clear() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 18
	protected override DataSet GetDataSet() { }

	// RVA: 0x1DEB130 Offset: 0x1DEA330 VA: 0x181DEB130 Slot: 13
	public override DataRelation get_Item(int index) { }

	// RVA: 0x1DEB000 Offset: 0x1DEA200 VA: 0x181DEB000 Slot: 14
	public override DataRelation get_Item(string name) { }

	// RVA: 0x1DEA020 Offset: 0x1DE9220 VA: 0x181DEA020 Slot: 15
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0x1DEAC30 Offset: 0x1DE9E30 VA: 0x181DEAC30 Slot: 21
	protected override void RemoveCore(DataRelation relation) { }

	// RVA: 0x1DEA7B0 Offset: 0x1DE99B0 VA: 0x181DEA7B0
	internal void FinishInitRelations() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
[DefaultEvent("CollectionChanged")]
[DefaultProperty("Table")]
public abstract class DataRelationCollection : InternalDataCollectionBase // TypeDefIndex: 12673
{
	// Fields
	private DataRelation _inTransition; // 0x10
	private int _defaultNameIndex; // 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x30

	// Properties
	internal int ObjectID { get; }
	public abstract DataRelation Item { get; }
	public abstract DataRelation Item { get; }

	// Methods

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	internal int get_ObjectID() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract DataRelation get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract DataRelation get_Item(string name);

	// RVA: 0x1DDFA50 Offset: 0x1DDEC50 VA: 0x181DDFA50
	public void Add(DataRelation relation) { }

	// RVA: 0x1DDF730 Offset: 0x1DDE930 VA: 0x181DDF730 Slot: 15
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0x1DE0B60 Offset: 0x1DDFD60 VA: 0x181DE0B60
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1DE0C70 Offset: 0x1DDFE70 VA: 0x181DE0C70
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1DDFCD0 Offset: 0x1DDEED0 VA: 0x181DDFCD0
	internal string AssignName() { }

	// RVA: 0x1DDFCF0 Offset: 0x1DDEEF0 VA: 0x181DDFCF0 Slot: 16
	public virtual void Clear() { }

	// RVA: 0x1DDFF00 Offset: 0x1DDF100 VA: 0x181DDFF00 Slot: 17
	public virtual bool Contains(string name) { }

	// RVA: 0x1DDFF20 Offset: 0x1DDF120 VA: 0x181DDFF20
	internal int InternalIndexOf(string name) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract DataSet GetDataSet();

	// RVA: 0x1DE0160 Offset: 0x1DDF360 VA: 0x181DE0160
	private string MakeName(int index) { }

	// RVA: 0x1DE0200 Offset: 0x1DDF400 VA: 0x181DE0200 Slot: 19
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1DE02C0 Offset: 0x1DDF4C0 VA: 0x181DE02C0 Slot: 20
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1DE0380 Offset: 0x1DDF580 VA: 0x181DE0380
	internal void RegisterName(string name) { }

	// RVA: 0x1DE07F0 Offset: 0x1DDF9F0 VA: 0x181DE07F0
	public void Remove(DataRelation relation) { }

	// RVA: 0x1DE0560 Offset: 0x1DDF760 VA: 0x181DE0560
	public void RemoveAt(int index) { }

	// RVA: 0x1DE05F0 Offset: 0x1DDF7F0 VA: 0x181DE05F0 Slot: 21
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0x1DE09A0 Offset: 0x1DDFBA0 VA: 0x181DE09A0
	internal void UnregisterName(string name) { }

	// RVA: 0x1DE0AE0 Offset: 0x1DDFCE0 VA: 0x181DE0AE0
	protected void .ctor() { }
}

// Namespace: System.Data
internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 12674
{
	// Fields
	[CompilerGenerated]
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Properties
	internal DataRelation Relation { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x1DE0F10 Offset: 0x1DE0110 VA: 0x181DE0F10
	internal void .ctor(DataRelation dataRelation) { }

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	internal DataRelation get_Relation() { }

	// RVA: 0x1DE0F70 Offset: 0x1DE0170 VA: 0x181DE0F70 Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x1DE0FD0 Offset: 0x1DE01D0 VA: 0x181DE0FD0 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x1DE0D80 Offset: 0x1DDFF80 VA: 0x181DE0D80 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1DDDA40 Offset: 0x1DDCC40 VA: 0x181DDDA40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 23
	public override bool CanResetValue(object component) { }

	// RVA: 0x1DE0E20 Offset: 0x1DE0020 VA: 0x181DE0E20 Slot: 26
	public override object GetValue(object component) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 29
	public override void ResetValue(object component) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 30
	public override void SetValue(object component, object value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 31
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataRow // TypeDefIndex: 12675
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataColumnCollection _columns; // 0x18
	internal int _oldRecord; // 0x20
	internal int _newRecord; // 0x24
	internal int _tempRecord; // 0x28
	internal long _rowID; // 0x30
	internal DataRowAction _action; // 0x38
	internal bool _inChangingEvent; // 0x3C
	internal bool _inDeletingEvent; // 0x3D
	internal bool _inCascade; // 0x3E
	private DataColumn _lastChangedColumn; // 0x40
	private int _countColumnChange; // 0x48
	private DataError _error; // 0x50
	private int _rbTreeNodeId; // 0x58
	private static int s_objectTypeCount; // 0x0
	internal readonly int _objectID; // 0x5C

	// Properties
	internal DataColumn LastChangedColumn { get; set; }
	internal bool HasPropertyChanged { get; }
	internal int RBTreeNodeId { get; set; }
	public string RowError { get; set; }
	internal long rowID { get; set; }
	public DataRowState RowState { get; }
	public DataTable Table { get; }
	public string Item { set; }
	public object Item { get; set; }
	public object Item { get; }
	public object[] ItemArray { set; }
	public bool HasErrors { get; }

	// Methods

	// RVA: 0x1DE8EE0 Offset: 0x1DE80E0 VA: 0x181DE8EE0
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0x1DE91B0 Offset: 0x1DE83B0 VA: 0x181DE91B0
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0x1DE9D50 Offset: 0x1DE8F50 VA: 0x181DE9D50
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0x1DE8FB0 Offset: 0x1DE81B0 VA: 0x181DE8FB0
	internal bool get_HasPropertyChanged() { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	internal int get_RBTreeNodeId() { }

	// RVA: 0x1DE9D60 Offset: 0x1DE8F60 VA: 0x181DE9D60
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0x1DE91C0 Offset: 0x1DE83C0 VA: 0x181DE91C0
	public string get_RowError() { }

	// RVA: 0x1DE9E10 Offset: 0x1DE9010 VA: 0x181DE9E10
	public void set_RowError(string value) { }

	// RVA: 0x1DE82E0 Offset: 0x1DE74E0 VA: 0x181DE82E0
	private void RowErrorChanged() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal long get_rowID() { }

	// RVA: 0x1DEA010 Offset: 0x1DE9210 VA: 0x181DEA010
	internal void set_rowID(long value) { }

	// RVA: 0x1DE9220 Offset: 0x1DE8420 VA: 0x181DE9220
	public DataRowState get_RowState() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public DataTable get_Table() { }

	// RVA: 0x1DE62E0 Offset: 0x1DE54E0 VA: 0x181DE62E0
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0x1DE7380 Offset: 0x1DE6580 VA: 0x181DE7380
	internal int GetNestedParentCount() { }

	// RVA: 0x1DE9880 Offset: 0x1DE8A80 VA: 0x181DE9880
	public void set_Item(string columnName, object value) { }

	// RVA: 0x1DE90A0 Offset: 0x1DE82A0 VA: 0x181DE90A0
	public object get_Item(DataColumn column) { }

	// RVA: 0x1DE98C0 Offset: 0x1DE8AC0 VA: 0x181DE98C0
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0x1DE8FC0 Offset: 0x1DE81C0 VA: 0x181DE8FC0
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0x1DE93D0 Offset: 0x1DE85D0 VA: 0x181DE93D0
	public void set_ItemArray(object[] value) { }

	// RVA: 0x1DE5E50 Offset: 0x1DE5050 VA: 0x181DE5E50
	public void AcceptChanges() { }

	[EditorBrowsable(2)]
	// RVA: 0x1DE61B0 Offset: 0x1DE53B0 VA: 0x181DE61B0
	public void BeginEdit() { }

	// RVA: 0x1DE60E0 Offset: 0x1DE52E0 VA: 0x181DE60E0
	private bool BeginEditInternal() { }

	[EditorBrowsable(2)]
	// RVA: 0x1DE61C0 Offset: 0x1DE53C0 VA: 0x181DE61C0
	public void CancelEdit() { }

	// RVA: 0x1DE6220 Offset: 0x1DE5420 VA: 0x181DE6220
	private void CheckColumn(DataColumn column) { }

	// RVA: 0x1DE63E0 Offset: 0x1DE55E0 VA: 0x181DE63E0
	internal void CheckInTable() { }

	// RVA: 0x1DE69B0 Offset: 0x1DE5BB0 VA: 0x181DE69B0
	public void Delete() { }

	[EditorBrowsable(2)]
	// RVA: 0x1DE6A20 Offset: 0x1DE5C20 VA: 0x181DE6A20
	public void EndEdit() { }

	// RVA: 0x1DE8600 Offset: 0x1DE7800 VA: 0x181DE8600
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0x1DE8330 Offset: 0x1DE7530 VA: 0x181DE8330
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x1DE6DA0 Offset: 0x1DE5FA0 VA: 0x181DE6DA0
	public string GetColumnError(string columnName) { }

	// RVA: 0x1DE6DD0 Offset: 0x1DE5FD0 VA: 0x181DE6DD0
	public string GetColumnError(DataColumn column) { }

	// RVA: 0x1DE6530 Offset: 0x1DE5730 VA: 0x181DE6530
	public void ClearErrors() { }

	// RVA: 0x1DE6420 Offset: 0x1DE5620 VA: 0x181DE6420
	internal void ClearError(DataColumn column) { }

	// RVA: 0x1DE8F70 Offset: 0x1DE8170 VA: 0x181DE8F70
	public bool get_HasErrors() { }

	// RVA: 0x1DE7050 Offset: 0x1DE6250 VA: 0x181DE7050
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0x1DE6AE0 Offset: 0x1DE5CE0 VA: 0x181DE6AE0
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0x1DE6AF0 Offset: 0x1DE5CF0 VA: 0x181DE6AF0
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x1DE71C0 Offset: 0x1DE63C0 VA: 0x181DE71C0
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0x1DE76E0 Offset: 0x1DE68E0 VA: 0x181DE76E0
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0x1DE7560 Offset: 0x1DE6760 VA: 0x181DE7560
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x1DE7450 Offset: 0x1DE6650 VA: 0x181DE7450
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0x1DE79A0 Offset: 0x1DE6BA0 VA: 0x181DE79A0
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0x1DE76F0 Offset: 0x1DE68F0 VA: 0x181DE76F0
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x1DE7000 Offset: 0x1DE6200 VA: 0x181DE7000
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0x1DE6FA0 Offset: 0x1DE61A0 VA: 0x181DE6FA0
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0x1DE72D0 Offset: 0x1DE64D0 VA: 0x181DE72D0
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0x1DE7350 Offset: 0x1DE6550 VA: 0x181DE7350
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0x1DE7180 Offset: 0x1DE6380 VA: 0x181DE7180
	internal int GetCurrentRecordNo() { }

	// RVA: 0x1DE7240 Offset: 0x1DE6440 VA: 0x181DE7240
	internal int GetDefaultRecord() { }

	// RVA: 0x1DE7520 Offset: 0x1DE6720 VA: 0x181DE7520
	internal int GetOriginalRecordNo() { }

	// RVA: 0x1DE79B0 Offset: 0x1DE6BB0 VA: 0x181DE79B0
	private int GetProposedRecordNo() { }

	// RVA: 0x1DE79F0 Offset: 0x1DE6BF0 VA: 0x181DE79F0
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0x1DE72A0 Offset: 0x1DE64A0 VA: 0x181DE72A0
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0x1DE7AE0 Offset: 0x1DE6CE0 VA: 0x181DE7AE0
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0x1DE7B30 Offset: 0x1DE6D30 VA: 0x181DE7B30
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0x1DE7B60 Offset: 0x1DE6D60 VA: 0x181DE7B60
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x1DE7BF0 Offset: 0x1DE6DF0 VA: 0x181DE7BF0
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0x1DE7C80 Offset: 0x1DE6E80 VA: 0x181DE7C80
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0x1DE7CB0 Offset: 0x1DE6EB0 VA: 0x181DE7CB0
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x1DE7E30 Offset: 0x1DE7030 VA: 0x181DE7E30
	public void RejectChanges() { }

	// RVA: 0x1DE82D0 Offset: 0x1DE74D0 VA: 0x181DE82D0
	internal void ResetLastChangedColumn() { }

	// RVA: 0x1DE8680 Offset: 0x1DE7880 VA: 0x181DE8680
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0x1DE87A0 Offset: 0x1DE79A0 VA: 0x181DE87A0
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0x1DE8AF0 Offset: 0x1DE7CF0 VA: 0x181DE8AF0
	internal void SetParentRowToDBNull() { }

	// RVA: 0x1DE8D20 Offset: 0x1DE7F20 VA: 0x181DE8D20
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0x1DE6610 Offset: 0x1DE5810 VA: 0x181DE6610
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }
}

// Namespace: System.Data
public sealed class DataRowBuilder // TypeDefIndex: 12676
{
	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	internal void .ctor(DataTable table, int record) { }
}

// Namespace: System.Data
[Flags]
public enum DataRowAction // TypeDefIndex: 12677
{
	// Fields
	public int value__; // 0x0
	public const DataRowAction Nothing = 0;
	public const DataRowAction Delete = 1;
	public const DataRowAction Change = 2;
	public const DataRowAction Rollback = 4;
	public const DataRowAction Commit = 8;
	public const DataRowAction Add = 16;
	public const DataRowAction ChangeOriginal = 32;
	public const DataRowAction ChangeCurrentAndOriginal = 64;
}

// Namespace: System.Data
public class DataRowChangeEventArgs : EventArgs // TypeDefIndex: 12678
{
	// Fields
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly DataRowAction <Action>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1DE4950 Offset: 0x1DE3B50 VA: 0x181DE4950
	public void .ctor(DataRow row, DataRowAction action) { }
}

// Namespace: System.Data
public sealed class DataRowChangeEventHandler : MulticastDelegate // TypeDefIndex: 12679
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }
}

// Namespace: 
private sealed class DataRowCollection.DataRowTree : RBTree<DataRow> // TypeDefIndex: 12680
{
	// Methods

	// RVA: 0x1DE5230 Offset: 0x1DE4430 VA: 0x181DE5230
	internal void .ctor() { }

	// RVA: 0x1DE51D0 Offset: 0x1DE43D0 VA: 0x181DE51D0 Slot: 5
	protected override int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0x1DE5200 Offset: 0x1DE4400 VA: 0x181DE5200 Slot: 6
	protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public sealed class DataRowCollection : InternalDataCollectionBase // TypeDefIndex: 12681
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataRowCollection.DataRowTree _list; // 0x18
	internal int _nullInList; // 0x20

	// Properties
	public override int Count { get; }
	public DataRow Item { get; }

	// Methods

	// RVA: 0x1DE5060 Offset: 0x1DE4260 VA: 0x181DE5060
	internal void .ctor(DataTable table) { }

	// RVA: 0x1DE5120 Offset: 0x1DE4320 VA: 0x181DE5120 Slot: 9
	public override int get_Count() { }

	// RVA: 0x1DE5170 Offset: 0x1DE4370 VA: 0x181DE5170
	public DataRow get_Item(int index) { }

	// RVA: 0x1DE4A40 Offset: 0x1DE3C40 VA: 0x181DE4A40
	public void Add(DataRow row) { }

	// RVA: 0x1DE4D30 Offset: 0x1DE3F30 VA: 0x181DE4D30
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0x1DE4FD0 Offset: 0x1DE41D0 VA: 0x181DE4FD0
	public int IndexOf(DataRow row) { }

	// RVA: 0x1DE49C0 Offset: 0x1DE3BC0 VA: 0x181DE49C0
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0x1DE4A70 Offset: 0x1DE3C70 VA: 0x181DE4A70
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0x1DE4B30 Offset: 0x1DE3D30 VA: 0x181DE4B30
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0x1DE4AE0 Offset: 0x1DE3CE0 VA: 0x181DE4AE0
	internal void ArrayClear() { }

	// RVA: 0x1DE4BB0 Offset: 0x1DE3DB0 VA: 0x181DE4BB0
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0x1DE4CC0 Offset: 0x1DE3EC0 VA: 0x181DE4CC0 Slot: 10
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0x1DE4C50 Offset: 0x1DE3E50 VA: 0x181DE4C50
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0x1DE4F80 Offset: 0x1DE4180 VA: 0x181DE4F80 Slot: 11
	public override IEnumerator GetEnumerator() { }
}

// Namespace: System.Data
internal sealed class DataRowCreatedEventHandler : MulticastDelegate // TypeDefIndex: 12682
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DataRow r) { }
}

// Namespace: System.Data
internal sealed class DataSetClearEventhandler : MulticastDelegate // TypeDefIndex: 12683
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DataTable table) { }
}

// Namespace: System.Data
[Flags]
public enum DataRowState // TypeDefIndex: 12684
{
	// Fields
	public int value__; // 0x0
	public const DataRowState Detached = 1;
	public const DataRowState Unchanged = 2;
	public const DataRowState Added = 4;
	public const DataRowState Deleted = 8;
	public const DataRowState Modified = 16;
}

// Namespace: System.Data
public enum DataRowVersion // TypeDefIndex: 12685
{
	// Fields
	public int value__; // 0x0
	public const DataRowVersion Original = 256;
	public const DataRowVersion Current = 512;
	public const DataRowVersion Proposed = 1024;
	public const DataRowVersion Default = 1536;
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataRowView : ICustomTypeDescriptor, IEditableObject, IDataErrorInfo, INotifyPropertyChanged // TypeDefIndex: 12686
{
	// Fields
	private readonly DataView _dataView; // 0x10
	private readonly DataRow _row; // 0x18
	private bool _delayBeginEdit; // 0x20
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; // 0x0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x28

	// Properties
	public DataView DataView { get; }
	private string System.ComponentModel.IDataErrorInfo.Item { get; }
	private string System.ComponentModel.IDataErrorInfo.Error { get; }
	private DataRowVersion RowVersionDefault { get; }
	public DataRow Row { get; }
	public bool IsNew { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x5C6320 Offset: 0x5C5520 VA: 0x1805C6320 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public DataView get_DataView() { }

	// RVA: 0x1DE5BD0 Offset: 0x1DE4DD0 VA: 0x181DE5BD0 Slot: 19
	private string System.ComponentModel.IDataErrorInfo.get_Item(string colName) { }

	// RVA: 0x1DE5B70 Offset: 0x1DE4D70 VA: 0x181DE5B70 Slot: 20
	private string System.ComponentModel.IDataErrorInfo.get_Error() { }

	// RVA: 0x1DE5D50 Offset: 0x1DE4F50 VA: 0x181DE5D50
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0x1DE56F0 Offset: 0x1DE48F0 VA: 0x181DE56F0
	internal int GetRecord() { }

	// RVA: 0x1DE5770 Offset: 0x1DE4970 VA: 0x181DE5770
	internal bool HasRecord() { }

	// RVA: 0x1DE55D0 Offset: 0x1DE47D0 VA: 0x181DE55D0
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0x1DE5880 Offset: 0x1DE4A80 VA: 0x181DE5880
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0x1DE5330 Offset: 0x1DE4530 VA: 0x181DE5330
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0x1DE5560 Offset: 0x1DE4760 VA: 0x181DE5560
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public DataRow get_Row() { }

	// RVA: 0x1DE5270 Offset: 0x1DE4470 VA: 0x181DE5270 Slot: 16
	public void BeginEdit() { }

	// RVA: 0x1DE5280 Offset: 0x1DE4480 VA: 0x181DE5280 Slot: 18
	public void CancelEdit() { }

	// RVA: 0x1DE5570 Offset: 0x1DE4770 VA: 0x181DE5570 Slot: 17
	public void EndEdit() { }

	// RVA: 0x1DE5D20 Offset: 0x1DE4F20 VA: 0x181DE5D20
	public bool get_IsNew() { }

	[CompilerGenerated]
	// RVA: 0x1DE5C80 Offset: 0x1DE4E80 VA: 0x181DE5C80 Slot: 21
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1DE5DB0 Offset: 0x1DE4FB0 VA: 0x181DE5DB0 Slot: 22
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x1DE57F0 Offset: 0x1DE49F0 VA: 0x181DE57F0
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0x1DE5940 Offset: 0x1DE4B40 VA: 0x181DE5940 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1DE5990 Offset: 0x1DE4B90 VA: 0x181DE5990 Slot: 11
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1DE59E0 Offset: 0x1DE4BE0 VA: 0x181DE59E0 Slot: 12
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1DE5AC0 Offset: 0x1DE4CC0 VA: 0x181DE5AC0 Slot: 13
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1DE5A30 Offset: 0x1DE4C30 VA: 0x181DE5A30 Slot: 14
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 15
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0x1DE5C10 Offset: 0x1DE4E10 VA: 0x181DE5C10
	private static void .cctor() { }
}

// Namespace: System.Data
public enum SerializationFormat // TypeDefIndex: 12687
{
	// Fields
	public int value__; // 0x0
	public const SerializationFormat Xml = 0;
	public const SerializationFormat Binary = 1;
}

// Namespace: System.Data
public enum DataSetDateTime // TypeDefIndex: 12688
{
	// Fields
	public int value__; // 0x0
	public const DataSetDateTime Local = 1;
	public const DataSetDateTime Unspecified = 2;
	public const DataSetDateTime UnspecifiedLocal = 3;
	public const DataSetDateTime Utc = 4;
}

// Namespace: System.Data
public sealed class DataTableClearEventArgs : EventArgs // TypeDefIndex: 12689
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1DEB260 Offset: 0x1DEA460 VA: 0x181DEB260
	public void .ctor(DataTable dataTable) { }
}

// Namespace: System.Data
public sealed class DataTableClearEventHandler : MulticastDelegate // TypeDefIndex: 12690
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DataTableClearEventArgs e) { }
}

// Namespace: System.Data
[ListBindable(False)]
[DefaultMember("Item")]
[DefaultEvent("CollectionChanged")]
public sealed class DataTableCollection : InternalDataCollectionBase // TypeDefIndex: 12691
{
	// Fields
	private readonly DataSet _dataSet; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataTable[] _delayedAddRangeTables; // 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x40

	// Properties
	protected override ArrayList List { get; }
	internal int ObjectID { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }

	// Methods

	// RVA: 0x1DEDA90 Offset: 0x1DECC90 VA: 0x181DEDA90
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	internal int get_ObjectID() { }

	// RVA: 0x1DEDE20 Offset: 0x1DED020 VA: 0x181DEDE20
	public DataTable get_Item(int index) { }

	// RVA: 0x1DEDCE0 Offset: 0x1DECEE0 VA: 0x181DEDCE0
	public DataTable get_Item(string name) { }

	// RVA: 0x1DEDF10 Offset: 0x1DED110 VA: 0x181DEDF10
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0x1DECB00 Offset: 0x1DEBD00 VA: 0x181DECB00
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0x1DEC980 Offset: 0x1DEBB80 VA: 0x181DEC980
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0x1DEB2C0 Offset: 0x1DEA4C0 VA: 0x181DEB2C0
	public void Add(DataTable table) { }

	// RVA: 0x1DEDBD0 Offset: 0x1DECDD0 VA: 0x181DEDBD0
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1DEE070 Offset: 0x1DED270 VA: 0x181DEE070
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1DEB520 Offset: 0x1DEA720 VA: 0x181DEB520
	private void ArrayAdd(DataTable table) { }

	// RVA: 0x1DEB550 Offset: 0x1DEA750 VA: 0x181DEB550
	internal string AssignName() { }

	// RVA: 0x1DEB620 Offset: 0x1DEA820 VA: 0x181DEB620
	private void BaseAdd(DataTable table) { }

	// RVA: 0x1DEB870 Offset: 0x1DEAA70 VA: 0x181DEB870
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0x1DEBA30 Offset: 0x1DEAC30 VA: 0x181DEBA30
	private void BaseRemove(DataTable table) { }

	// RVA: 0x1DEBBB0 Offset: 0x1DEADB0 VA: 0x181DEBBB0
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0x1DEC2A0 Offset: 0x1DEB4A0 VA: 0x181DEC2A0
	public void Clear() { }

	// RVA: 0x1DEC710 Offset: 0x1DEB910 VA: 0x181DEC710
	public bool Contains(string name) { }

	// RVA: 0x1DEC730 Offset: 0x1DEB930 VA: 0x181DEC730
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0x1DEC590 Offset: 0x1DEB790 VA: 0x181DEC590
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x1DECD10 Offset: 0x1DEBF10 VA: 0x181DECD10
	public int IndexOf(DataTable table) { }

	// RVA: 0x1DECC60 Offset: 0x1DEBE60 VA: 0x181DECC60
	public int IndexOf(string tableName) { }

	// RVA: 0x1DECC80 Offset: 0x1DEBE80 VA: 0x181DECC80
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0x1DED920 Offset: 0x1DECB20 VA: 0x181DED920
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	// RVA: 0x1DECE20 Offset: 0x1DEC020 VA: 0x181DECE20
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0x1DED080 Offset: 0x1DEC280 VA: 0x181DED080
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0x1DEC900 Offset: 0x1DEBB00 VA: 0x181DEC900
	internal void FinishInitCollection() { }

	// RVA: 0x1DED2A0 Offset: 0x1DEC4A0 VA: 0x181DED2A0
	private string MakeName(int index) { }

	// RVA: 0x1DED340 Offset: 0x1DEC540 VA: 0x181DED340
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1DED400 Offset: 0x1DEC600 VA: 0x181DED400
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1DED4C0 Offset: 0x1DEC6C0 VA: 0x181DED4C0
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0x1DED760 Offset: 0x1DEC960 VA: 0x181DED760
	public void Remove(DataTable table) { }

	// RVA: 0x1DED980 Offset: 0x1DECB80 VA: 0x181DED980
	internal void UnregisterName(string name) { }
}

// Namespace: System.Data
public sealed class DataTableNewRowEventArgs : EventArgs // TypeDefIndex: 12692
{
	// Fields
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1DFA0C0 Offset: 0x1DF92C0 VA: 0x181DFA0C0
	public void .ctor(DataRow dataRow) { }
}

// Namespace: System.Data
public sealed class DataTableNewRowEventHandler : MulticastDelegate // TypeDefIndex: 12693
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }
}

// Namespace: System.Data
internal sealed class DataTablePropertyDescriptor : PropertyDescriptor // TypeDefIndex: 12694
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x88

	// Properties
	public DataTable Table { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public DataTable get_Table() { }

	// RVA: 0x1DFA2E0 Offset: 0x1DF94E0 VA: 0x181DFA2E0
	internal void .ctor(DataTable dataTable) { }

	// RVA: 0x1DFA320 Offset: 0x1DF9520 VA: 0x181DFA320 Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x1DFA380 Offset: 0x1DF9580 VA: 0x181DFA380 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x1DFA120 Offset: 0x1DF9320 VA: 0x181DFA120 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1DDDA40 Offset: 0x1DDCC40 VA: 0x181DDDA40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 23
	public override bool CanResetValue(object component) { }

	// RVA: 0x1DFA1C0 Offset: 0x1DF93C0 VA: 0x181DFA1C0 Slot: 26
	public override object GetValue(object component) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 29
	public override void ResetValue(object component) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 30
	public override void SetValue(object component, object value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 31
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: System.Data
internal sealed class DataTableTypeConverter : ReferenceConverter // TypeDefIndex: 12695
{
	// Methods

	// RVA: 0x1DFA3E0 Offset: 0x1DF95E0 VA: 0x181DFA3E0
	public void .ctor() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }
}

// Namespace: 
private sealed class DataView.DataRowReferenceComparer : IEqualityComparer<DataRow> // TypeDefIndex: 12696
{
	// Fields
	internal static readonly DataView.DataRowReferenceComparer s_default; // 0x0

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x67F820 Offset: 0x67EA20 VA: 0x18067F820 Slot: 4
	public bool Equals(DataRow x, DataRow y) { }

	// RVA: 0x1DFA040 Offset: 0x1DF9240 VA: 0x181DFA040 Slot: 5
	public int GetHashCode(DataRow obj) { }

	// RVA: 0x1DFA060 Offset: 0x1DF9260 VA: 0x181DFA060
	private static void .cctor() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
[DefaultEvent("PositionChanged")]
[DefaultProperty("Table")]
public class DataView : MarshalByValueComponent, IBindingListView, IBindingList, IList, ICollection, IEnumerable, ITypedList, ISupportInitializeNotification, ISupportInitialize // TypeDefIndex: 12697
{
	// Fields
	private DataViewManager _dataViewManager; // 0x20
	private DataTable _table; // 0x28
	private bool _locked; // 0x30
	private Index _index; // 0x38
	private Dictionary<string, Index> _findIndexes; // 0x40
	private string _sort; // 0x48
	private Comparison<DataRow> _comparison; // 0x50
	private IFilter _rowFilter; // 0x58
	private DataViewRowState _recordStates; // 0x60
	private bool _shouldOpen; // 0x64
	private bool _open; // 0x65
	private bool _allowNew; // 0x66
	private bool _allowEdit; // 0x67
	private bool _allowDelete; // 0x68
	private bool _applyDefaultSort; // 0x69
	internal DataRow _addNewRow; // 0x70
	private ListChangedEventArgs _addNewMoved; // 0x78
	private ListChangedEventHandler _onListChanged; // 0x80
	internal static ListChangedEventArgs s_resetEventArgs; // 0x0
	private DataTable _delayedTable; // 0x88
	private string _delayedRowFilter; // 0x90
	private string _delayedSort; // 0x98
	private DataViewRowState _delayedRecordStates; // 0xA0
	private bool _fInitInProgress; // 0xA4
	private bool _fEndInitInProgress; // 0xA5
	private Dictionary<DataRow, DataRowView> _rowViewCache; // 0xA8
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; // 0xB0
	private DataViewListener _dvListener; // 0xB8
	private static int s_objectTypeCount; // 0x8
	private readonly int _objectID; // 0xC0
	[CompilerGenerated]
	private EventHandler Initialized; // 0xC8

	// Properties
	[DefaultValue(True)]
	public bool AllowDelete { get; }
	[DefaultValue(True)]
	public bool AllowEdit { get; }
	[DefaultValue(True)]
	public bool AllowNew { get; }
	[Browsable(False)]
	public int Count { get; }
	private int CountFromIndex { get; }
	[Browsable(False)]
	public DataViewManager DataViewManager { get; }
	[Browsable(False)]
	public bool IsInitialized { get; }
	[Browsable(False)]
	protected bool IsOpen { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	[DefaultValue("")]
	public virtual string RowFilter { get; set; }
	[DefaultValue(22)]
	public DataViewRowState RowStateFilter { get; set; }
	[DefaultValue("")]
	public string Sort { get; set; }
	internal Comparison<DataRow> SortComparison { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	[DefaultValue(null)]
	[RefreshProperties(1)]
	[TypeConverter(typeof(DataTableTypeConverter))]
	public DataTable Table { get; set; }
	private object System.Collections.IList.Item { get; set; }
	public DataRowView Item { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.ComponentModel.IBindingList.AllowNew { get; }
	private bool System.ComponentModel.IBindingList.AllowEdit { get; }
	private bool System.ComponentModel.IBindingList.AllowRemove { get; }
	private bool System.ComponentModel.IBindingList.SupportsChangeNotification { get; }
	private bool System.ComponentModel.IBindingList.SupportsSearching { get; }
	private bool System.ComponentModel.IBindingList.SupportsSorting { get; }
	private bool System.ComponentModel.IBindingList.IsSorted { get; }
	private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get; }
	private ListSortDirection System.ComponentModel.IBindingList.SortDirection { get; }
	private string System.ComponentModel.IBindingListView.Filter { get; set; }
	private ListSortDescriptionCollection System.ComponentModel.IBindingListView.SortDescriptions { get; }
	private bool System.ComponentModel.IBindingListView.SupportsAdvancedSorting { get; }
	private bool System.ComponentModel.IBindingListView.SupportsFiltering { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1E01600 Offset: 0x1E00800 VA: 0x181E01600
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0x1E018F0 Offset: 0x1E00AF0 VA: 0x181E018F0
	public void .ctor(DataTable table) { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	public bool get_AllowDelete() { }

	// RVA: 0x1E00F30 Offset: 0x1E00130 VA: 0x181E00F30
	public bool get_AllowEdit() { }

	// RVA: 0x1E00F40 Offset: 0x1E00140 VA: 0x181E00F40
	public bool get_AllowNew() { }

	// RVA: 0x1E01B50 Offset: 0x1E00D50 VA: 0x181E01B50 Slot: 52
	public int get_Count() { }

	// RVA: 0x1E01B20 Offset: 0x1E00D20 VA: 0x181E01B20
	private int get_CountFromIndex() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public DataViewManager get_DataViewManager() { }

	// RVA: 0x1E01BA0 Offset: 0x1E00DA0 VA: 0x181E01BA0 Slot: 58
	public bool get_IsInitialized() { }

	// RVA: 0x1E01BB0 Offset: 0x1E00DB0 VA: 0x181E01BB0
	protected bool get_IsOpen() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 54
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1E01BC0 Offset: 0x1E00DC0 VA: 0x181E01BC0 Slot: 63
	public virtual string get_RowFilter() { }

	// RVA: 0x1E01E70 Offset: 0x1E01070 VA: 0x181E01E70 Slot: 64
	public virtual void set_RowFilter(string value) { }

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x1E02050 Offset: 0x1E01250 VA: 0x181E02050
	public void set_RowStateFilter(DataViewRowState value) { }

	// RVA: 0x1E01C50 Offset: 0x1E00E50 VA: 0x181E01C50
	public string get_Sort() { }

	// RVA: 0x1E02190 Offset: 0x1E01390 VA: 0x181E02190
	public void set_Sort(string value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal Comparison<DataRow> get_SortComparison() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 53
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public DataTable get_Table() { }

	// RVA: 0x1E02350 Offset: 0x1E01550 VA: 0x181E02350
	public void set_Table(DataTable value) { }

	// RVA: 0x1E005A0 Offset: 0x1DFF7A0 VA: 0x181E005A0 Slot: 40
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0x1E00600 Offset: 0x1DFF800 VA: 0x181E00600 Slot: 41
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0x1E005A0 Offset: 0x1DFF7A0 VA: 0x181E005A0
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0x1DFD1B0 Offset: 0x1DFC3B0 VA: 0x181DFD1B0 Slot: 65
	public virtual DataRowView AddNew() { }

	// RVA: 0x1DFD460 Offset: 0x1DFC660 VA: 0x181DFD460 Slot: 61
	public void BeginInit() { }

	// RVA: 0x1DFE130 Offset: 0x1DFD330 VA: 0x181DFE130 Slot: 62
	public void EndInit() { }

	// RVA: 0x1DFD470 Offset: 0x1DFC670 VA: 0x181DFD470
	private void CheckOpen() { }

	// RVA: 0x1DFD4B0 Offset: 0x1DFC6B0 VA: 0x181DFD4B0
	private void CheckSort(string sort) { }

	// RVA: 0x1DFD780 Offset: 0x1DFC980 VA: 0x181DFD780
	protected void Close() { }

	// RVA: 0x1DFDA60 Offset: 0x1DFCC60 VA: 0x181DFDA60 Slot: 51
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1DFDBC0 Offset: 0x1DFCDC0 VA: 0x181DFDBC0
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0x1DFE090 Offset: 0x1DFD290 VA: 0x181DFE090
	public void Delete(int index) { }

	// RVA: 0x1DFDEA0 Offset: 0x1DFD0A0 VA: 0x181DFDEA0
	internal void Delete(DataRow row) { }

	// RVA: 0x1DFE0C0 Offset: 0x1DFD2C0 VA: 0x181DFE0C0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1DFE4A0 Offset: 0x1DFD6A0 VA: 0x181DFE4A0
	internal void FinishAddNew(bool success) { }

	// RVA: 0x1DFE680 Offset: 0x1DFD880 VA: 0x181DFE680 Slot: 55
	public IEnumerator GetEnumerator() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 45
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 46
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1E00250 Offset: 0x1DFF450 VA: 0x181E00250 Slot: 42
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1E002E0 Offset: 0x1DFF4E0 VA: 0x181E002E0 Slot: 44
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1E00310 Offset: 0x1DFF510 VA: 0x181E00310 Slot: 43
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1E003A0 Offset: 0x1DFF5A0 VA: 0x181E003A0 Slot: 47
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1DFF0A0 Offset: 0x1DFE2A0 VA: 0x181DFF0A0
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0x1DFF040 Offset: 0x1DFE240 VA: 0x181DFF040
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0x1E00430 Offset: 0x1DFF630 VA: 0x181E00430 Slot: 48
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1E00460 Offset: 0x1DFF660 VA: 0x181E00460 Slot: 49
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1DFE090 Offset: 0x1DFD290 VA: 0x181DFE090 Slot: 50
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1DFE720 Offset: 0x1DFD920 VA: 0x181DFE720
	internal Index GetFindIndex(string column, bool keepIndex) { }

	// RVA: 0x1E00F40 Offset: 0x1E00140 VA: 0x181E00F40 Slot: 23
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xEE5EF0 Offset: 0xEE50F0 VA: 0x180EE5EF0 Slot: 24
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x1E00F30 Offset: 0x1E00130 VA: 0x181E00F30 Slot: 25
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40 Slot: 26
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 27
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 28
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 29
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x1E00F50 Offset: 0x1E00150 VA: 0x181E00F50 Slot: 30
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x1E00FF0 Offset: 0x1E001F0 VA: 0x181E00FF0 Slot: 31
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x1DFEE60 Offset: 0x1DFE060 VA: 0x181DFEE60
	internal PropertyDescriptor GetSortProperty() { }

	// RVA: 0x1E00FB0 Offset: 0x1E001B0 VA: 0x181E00FB0 Slot: 32
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0x1E01A10 Offset: 0x1E00C10 VA: 0x181E01A10 Slot: 33
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x1E01D60 Offset: 0x1E00F60 VA: 0x181E01D60 Slot: 34
	public void remove_ListChanged(ListChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E01960 Offset: 0x1E00B60 VA: 0x181E01960 Slot: 59
	public void add_Initialized(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E01CB0 Offset: 0x1E00EB0 VA: 0x181E01CB0 Slot: 60
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0x1E00B20 Offset: 0x1DFFD20 VA: 0x181E00B20 Slot: 35
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0x1E00B70 Offset: 0x1DFFD70 VA: 0x181E00B70 Slot: 36
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x1E00BA0 Offset: 0x1DFFDA0 VA: 0x181E00BA0 Slot: 37
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0x1E00E20 Offset: 0x1E00020 VA: 0x181E00E20 Slot: 38
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0x1E00E70 Offset: 0x1E00070 VA: 0x181E00E70 Slot: 39
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x1E00630 Offset: 0x1DFF830 VA: 0x181E00630 Slot: 16
	private void System.ComponentModel.IBindingListView.ApplySort(ListSortDescriptionCollection sorts) { }

	// RVA: 0x1DFDDB0 Offset: 0x1DFCFB0 VA: 0x181DFDDB0
	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x1E00A00 Offset: 0x1DFFC00 VA: 0x181E00A00 Slot: 20
	private void System.ComponentModel.IBindingListView.RemoveFilter() { }

	// RVA: 0x1E00AD0 Offset: 0x1DFFCD0 VA: 0x181E00AD0 Slot: 17
	private string System.ComponentModel.IBindingListView.get_Filter() { }

	// RVA: 0x1E00B00 Offset: 0x1DFFD00 VA: 0x181E00B00 Slot: 18
	private void System.ComponentModel.IBindingListView.set_Filter(string value) { }

	// RVA: 0x1E00AF0 Offset: 0x1DFFCF0 VA: 0x181E00AF0 Slot: 19
	private ListSortDescriptionCollection System.ComponentModel.IBindingListView.get_SortDescriptions() { }

	// RVA: 0x1DFEBD0 Offset: 0x1DFDDD0 VA: 0x181DFEBD0
	internal ListSortDescriptionCollection GetSortDescriptions() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 21
	private bool System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 22
	private bool System.ComponentModel.IBindingListView.get_SupportsFiltering() { }

	// RVA: 0x1E01150 Offset: 0x1E00350 VA: 0x181E01150 Slot: 56
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x1E01080 Offset: 0x1E00280 VA: 0x181E01080 Slot: 57
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 66
	internal virtual IFilter GetFilter() { }

	// RVA: 0x1DFE8D0 Offset: 0x1DFDAD0 VA: 0x181DFE8D0
	private int GetRecord(int recordIndex) { }

	// RVA: 0x1DFEA70 Offset: 0x1DFDC70 VA: 0x181DFEA70
	internal DataRow GetRow(int index) { }

	// RVA: 0x1DFE9F0 Offset: 0x1DFDBF0 VA: 0x181DFE9F0
	private DataRowView GetRowView(int record) { }

	// RVA: 0x1DFE990 Offset: 0x1DFDB90 VA: 0x181DFE990
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0x1DFEFB0 Offset: 0x1DFE1B0 VA: 0x181DFEFB0 Slot: 67
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0x1DFEEF0 Offset: 0x1DFE0F0 VA: 0x181DFEEF0
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0x1DFF1F0 Offset: 0x1DFE3F0 VA: 0x181DFF1F0
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x1DFF540 Offset: 0x1DFE740 VA: 0x181DFF540 Slot: 68
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1DFF4C0 Offset: 0x1DFE6C0 VA: 0x181DFF4C0
	private void OnInitialized() { }

	// RVA: 0x1DFFDB0 Offset: 0x1DFEFB0 VA: 0x181DFFDB0
	protected void Reset() { }

	// RVA: 0x1DFFB40 Offset: 0x1DFED40 VA: 0x181DFFB40
	internal void ResetRowViewCache() { }

	// RVA: 0x1DFFDE0 Offset: 0x1DFEFE0 VA: 0x181DFFDE0
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x1E00230 Offset: 0x1DFF430 VA: 0x181E00230 Slot: 69
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0x1E00020 Offset: 0x1DFF220 VA: 0x181E00020
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0x1E01560 Offset: 0x1E00760 VA: 0x181E01560
	protected void UpdateIndex() { }

	// RVA: 0x1E01580 Offset: 0x1E00780 VA: 0x181E01580 Slot: 70
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0x1E01200 Offset: 0x1E00400 VA: 0x181E01200
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0x1DFD510 Offset: 0x1DFC710 VA: 0x181DFD510
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1DFF8D0 Offset: 0x1DFEAD0 VA: 0x181DFF8D0
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1DFD7F0 Offset: 0x1DFC9F0 VA: 0x181DFD7F0 Slot: 71
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1DFD7D0 Offset: 0x1DFC9D0 VA: 0x181DFD7D0
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x5B5FB0 Offset: 0x5B51B0 VA: 0x1805B5FB0
	internal int get_ObjectID() { }

	// RVA: 0x1E01590 Offset: 0x1E00790 VA: 0x181E01590
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class DataViewListener // TypeDefIndex: 12698
{
	// Fields
	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28

	// Methods

	// RVA: 0x1DFB250 Offset: 0x1DFA450 VA: 0x181DFB250
	internal void .ctor(DataView dv) { }

	// RVA: 0x1DFA480 Offset: 0x1DF9680 VA: 0x181DFA480
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1DFA920 Offset: 0x1DF9B20 VA: 0x181DFA920
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1DFA5A0 Offset: 0x1DF97A0 VA: 0x181DFA5A0
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1DFA820 Offset: 0x1DF9A20 VA: 0x181DFA820
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x1DFA6A0 Offset: 0x1DF98A0 VA: 0x181DFA6A0
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1DFACC0 Offset: 0x1DF9EC0 VA: 0x181DFACC0
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0x1DFB240 Offset: 0x1DFA440 VA: 0x181DFB240
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0x1DFAF90 Offset: 0x1DFA190 VA: 0x181DFAF90
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0x1DFAA20 Offset: 0x1DF9C20 VA: 0x181DFAA20
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0x1DFAED0 Offset: 0x1DFA0D0 VA: 0x181DFAED0
	internal void UnregisterListChangedEvent() { }

	// RVA: 0x1DFA580 Offset: 0x1DF9780 VA: 0x181DFA580
	private void CleanUp(bool updateListeners) { }

	// RVA: 0x1DFAAD0 Offset: 0x1DF9CD0 VA: 0x181DFAAD0
	private void RegisterListener(DataTable table) { }
}

// Namespace: System.Data
public class DataViewManager : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList // TypeDefIndex: 12699
{
	// Fields
	private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
	private DataSet _dataSet; // 0x28
	private DataViewManagerListItemTypeDescriptor _item; // 0x30
	private bool _locked; // 0x38
	internal int _nViews; // 0x3C
	private static NotSupportedException s_notSupported; // 0x0
	[CompilerGenerated]
	private ListChangedEventHandler ListChanged; // 0x40

	// Properties
	[DefaultValue(null)]
	public DataSet DataSet { get; }
	[DesignerSerializationVisibility(2)]
	public DataViewSettingCollection DataViewSettings { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.ComponentModel.IBindingList.AllowNew { get; }
	private bool System.ComponentModel.IBindingList.AllowEdit { get; }
	private bool System.ComponentModel.IBindingList.AllowRemove { get; }
	private bool System.ComponentModel.IBindingList.SupportsChangeNotification { get; }
	private bool System.ComponentModel.IBindingList.SupportsSearching { get; }
	private bool System.ComponentModel.IBindingList.SupportsSorting { get; }
	private bool System.ComponentModel.IBindingList.IsSorted { get; }
	private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get; }
	private ListSortDirection System.ComponentModel.IBindingList.SortDirection { get; }

	// Methods

	// RVA: 0x1DFC560 Offset: 0x1DFB760 VA: 0x181DFC560
	internal void .ctor(DataSet dataSet, bool locked) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public DataSet get_DataSet() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0x1DFBBB0 Offset: 0x1DFADB0 VA: 0x181DFBBB0 Slot: 48
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 45
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 46
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 47
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 38
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 39
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1DFBB20 Offset: 0x1DFAD20 VA: 0x181DFBB20 Slot: 44
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 33
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1DFBDB0 Offset: 0x1DFAFB0 VA: 0x181DFBDB0 Slot: 34
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1DFBC90 Offset: 0x1DFAE90 VA: 0x181DFBC90 Slot: 35
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1DFBCC0 Offset: 0x1DFAEC0 VA: 0x181DFBCC0 Slot: 37
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1DFBCF0 Offset: 0x1DFAEF0 VA: 0x181DFBCF0 Slot: 36
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1DFBD00 Offset: 0x1DFAF00 VA: 0x181DFBD00 Slot: 40
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1DFBD20 Offset: 0x1DFAF20 VA: 0x181DFBD20 Slot: 41
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1DFBD80 Offset: 0x1DFAF80 VA: 0x181DFBD80 Slot: 42
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1DFBD50 Offset: 0x1DFAF50 VA: 0x181DFBD50 Slot: 43
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 16
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x1DFBDE0 Offset: 0x1DFAFE0 VA: 0x181DFBDE0 Slot: 17
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 18
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 19
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 20
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 21
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 22
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x1DFBF20 Offset: 0x1DFB120 VA: 0x181DFBF20 Slot: 23
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x1DFBFC0 Offset: 0x1DFB1C0 VA: 0x181DFBFC0 Slot: 24
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x1DFBF70 Offset: 0x1DFB170 VA: 0x181DFBF70 Slot: 25
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	[CompilerGenerated]
	// RVA: 0x1DFC740 Offset: 0x1DFB940 VA: 0x181DFC740 Slot: 26
	public void add_ListChanged(ListChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1DFC7E0 Offset: 0x1DFB9E0 VA: 0x181DFC7E0 Slot: 27
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 28
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0x1DFBE30 Offset: 0x1DFB030 VA: 0x181DFBE30 Slot: 29
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x1DFBE80 Offset: 0x1DFB080 VA: 0x181DFBE80 Slot: 30
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 31
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0x1DFBED0 Offset: 0x1DFB0D0 VA: 0x181DFBED0 Slot: 32
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x1DFC1A0 Offset: 0x1DFB3A0 VA: 0x181DFC1A0 Slot: 49
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x1DFC010 Offset: 0x1DFB210 VA: 0x181DFC010 Slot: 50
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x1DFB700 Offset: 0x1DFA900 VA: 0x181DFB700
	public DataView CreateDataView(DataTable table) { }

	// RVA: 0x1DFB7B0 Offset: 0x1DFA9B0 VA: 0x181DFB7B0 Slot: 51
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1DFC260 Offset: 0x1DFB460 VA: 0x181DFC260 Slot: 52
	protected virtual void TableCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1DFB8B0 Offset: 0x1DFAAB0 VA: 0x181DFB8B0 Slot: 53
	protected virtual void RelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1DFC500 Offset: 0x1DFB700 VA: 0x181DFC500
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class DataViewManagerListItemTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 12700
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private PropertyDescriptorCollection _propsCollection; // 0x18

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0x1DFB2D0 Offset: 0x1DFA4D0 VA: 0x181DFB2D0
	internal DataView GetDataView(DataTable table) { }

	// RVA: 0x1DFB390 Offset: 0x1DFA590 VA: 0x181DFB390 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1DFB3E0 Offset: 0x1DFA5E0 VA: 0x181DFB3E0 Slot: 11
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1DFB430 Offset: 0x1DFA630 VA: 0x181DFB430 Slot: 12
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1DFB650 Offset: 0x1DFA850 VA: 0x181DFB650 Slot: 13
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1DFB480 Offset: 0x1DFA680 VA: 0x181DFB480 Slot: 14
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 15
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: System.Data
[Flags]
public enum DataViewRowState // TypeDefIndex: 12701
{
	// Fields
	public int value__; // 0x0
	public const DataViewRowState None = 0;
	public const DataViewRowState Unchanged = 2;
	public const DataViewRowState Added = 4;
	public const DataViewRowState Deleted = 8;
	public const DataViewRowState ModifiedCurrent = 16;
	public const DataViewRowState ModifiedOriginal = 32;
	public const DataViewRowState OriginalRows = 42;
	public const DataViewRowState CurrentRows = 22;
}

// Namespace: System.Data
[TypeConverter(typeof(ExpandableObjectConverter))]
public class DataViewSetting // TypeDefIndex: 12702
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private DataTable _table; // 0x18
	private string _sort; // 0x20
	private string _rowFilter; // 0x28
	private DataViewRowState _rowStateFilter; // 0x30
	private bool _applyDefaultSort; // 0x34

	// Properties
	public bool ApplyDefaultSort { get; }
	public string RowFilter { get; }
	public DataViewRowState RowStateFilter { get; }
	public string Sort { get; }

	// Methods

	// RVA: 0x1DFCF10 Offset: 0x1DFC110 VA: 0x181DFCF10
	internal void .ctor() { }

	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	public bool get_ApplyDefaultSort() { }

	// RVA: 0x1DE2E90 Offset: 0x1DE2090 VA: 0x181DE2E90
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x1DFCF00 Offset: 0x1DFC100 VA: 0x181DFCF00
	internal void SetDataTable(DataTable table) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_RowFilter() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Sort() { }
}

// Namespace: 
private sealed class DataViewSettingCollection.DataViewSettingsEnumerator : IEnumerator // TypeDefIndex: 12703
{
	// Fields
	private DataViewSettingCollection _dataViewSettings; // 0x10
	private IEnumerator _tableEnumerator; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1DFD020 Offset: 0x1DFC220 VA: 0x181DFD020
	public void .ctor(DataViewManager dvm) { }

	// RVA: 0x1DFCF80 Offset: 0x1DFC180 VA: 0x181DFCF80 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1DFCFD0 Offset: 0x1DFC1D0 VA: 0x181DFCFD0 Slot: 6
	public void Reset() { }

	// RVA: 0x1DFD0E0 Offset: 0x1DFC2E0 VA: 0x181DFD0E0 Slot: 5
	public object get_Current() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataViewSettingCollection : ICollection, IEnumerable // TypeDefIndex: 12704
{
	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Properties
	public virtual DataViewSetting Item { get; set; }
	[Browsable(False)]
	public virtual int Count { get; }
	[Browsable(False)]
	public bool IsSynchronized { get; }
	[Browsable(False)]
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1DFCBF0 Offset: 0x1DFBDF0 VA: 0x181DFCBF0
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0x1DFCCF0 Offset: 0x1DFBEF0 VA: 0x181DFCCF0 Slot: 9
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0x1DFCE70 Offset: 0x1DFC070 VA: 0x181DFCE70 Slot: 10
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0x1DFC880 Offset: 0x1DFBA80 VA: 0x181DFC880 Slot: 4
	public void CopyTo(Array ar, int index) { }

	// RVA: 0x1DFCCA0 Offset: 0x1DFBEA0 VA: 0x181DFCCA0 Slot: 11
	public virtual int get_Count() { }

	// RVA: 0x1DFCAD0 Offset: 0x1DFBCD0 VA: 0x181DFCAD0 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1DFCBC0 Offset: 0x1DFBDC0 VA: 0x181DFCBC0
	internal void Remove(DataTable table) { }
}

// Namespace: System.Data
internal sealed class DefaultValueTypeConverter : StringConverter // TypeDefIndex: 12705
{
	// Methods

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }

	// RVA: 0x1E027B0 Offset: 0x1E019B0 VA: 0x181E027B0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1E02620 Offset: 0x1E01820 VA: 0x181E02620 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }
}

// Namespace: System.Data
internal enum Aggregate // TypeDefIndex: 12706
{
	// Fields
	public int value__; // 0x0
	public const Aggregate None = -1;
	public const Aggregate Sum = 30;
	public const Aggregate Avg = 31;
	public const Aggregate Min = 32;
	public const Aggregate Max = 33;
	public const Aggregate Count = 34;
	public const Aggregate StDev = 35;
	public const Aggregate Var = 37;
}

// Namespace: System.Data
internal sealed class AggregateNode : ExpressionNode // TypeDefIndex: 12707
{
	// Fields
	private readonly AggregateType _type; // 0x18
	private readonly Aggregate _aggregate; // 0x1C
	private readonly bool _local; // 0x20
	private readonly string _relationName; // 0x28
	private readonly string _columnName; // 0x30
	private DataTable _childTable; // 0x38
	private DataColumn _column; // 0x40
	private DataRelation _relation; // 0x48

	// Methods

	// RVA: 0x1DF1970 Offset: 0x1DF0B70 VA: 0x181DF1970
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0x1DF1850 Offset: 0x1DF0A50 VA: 0x181DF1850
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0x1DF0EF0 Offset: 0x1DF00F0 VA: 0x181DF0EF0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1DF12A0 Offset: 0x1DF04A0 VA: 0x181DF12A0
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	// RVA: 0x1DD2750 Offset: 0x1DD1950 VA: 0x181DD2750 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1DF1530 Offset: 0x1DF0730 VA: 0x181DF1530 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1DF1490 Offset: 0x1DF0690 VA: 0x181DF1490 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1DF1840 Offset: 0x1DF0A40 VA: 0x181DF1840 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1DF1400 Offset: 0x1DF0600 VA: 0x181DF1400 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: 
private enum BinaryNode.DataTypePrecedence // TypeDefIndex: 12708
{
	// Fields
	public int value__; // 0x0
	public const BinaryNode.DataTypePrecedence SqlDateTime = 25;
	public const BinaryNode.DataTypePrecedence DateTimeOffset = 24;
	public const BinaryNode.DataTypePrecedence DateTime = 23;
	public const BinaryNode.DataTypePrecedence TimeSpan = 20;
	public const BinaryNode.DataTypePrecedence SqlDouble = 19;
	public const BinaryNode.DataTypePrecedence Double = 18;
	public const BinaryNode.DataTypePrecedence SqlSingle = 17;
	public const BinaryNode.DataTypePrecedence Single = 16;
	public const BinaryNode.DataTypePrecedence SqlDecimal = 15;
	public const BinaryNode.DataTypePrecedence Decimal = 14;
	public const BinaryNode.DataTypePrecedence SqlMoney = 13;
	public const BinaryNode.DataTypePrecedence UInt64 = 12;
	public const BinaryNode.DataTypePrecedence SqlInt64 = 11;
	public const BinaryNode.DataTypePrecedence Int64 = 10;
	public const BinaryNode.DataTypePrecedence UInt32 = 9;
	public const BinaryNode.DataTypePrecedence SqlInt32 = 8;
	public const BinaryNode.DataTypePrecedence Int32 = 7;
	public const BinaryNode.DataTypePrecedence UInt16 = 6;
	public const BinaryNode.DataTypePrecedence SqlInt16 = 5;
	public const BinaryNode.DataTypePrecedence Int16 = 4;
	public const BinaryNode.DataTypePrecedence Byte = 3;
	public const BinaryNode.DataTypePrecedence SqlByte = 2;
	public const BinaryNode.DataTypePrecedence SByte = 1;
	public const BinaryNode.DataTypePrecedence Error = 0;
	public const BinaryNode.DataTypePrecedence SqlBoolean = -1;
	public const BinaryNode.DataTypePrecedence Boolean = -2;
	public const BinaryNode.DataTypePrecedence SqlGuid = -3;
	public const BinaryNode.DataTypePrecedence SqlString = -4;
	public const BinaryNode.DataTypePrecedence String = -5;
	public const BinaryNode.DataTypePrecedence SqlXml = -6;
	public const BinaryNode.DataTypePrecedence SqlChars = -7;
	public const BinaryNode.DataTypePrecedence Char = -8;
	public const BinaryNode.DataTypePrecedence SqlBytes = -9;
	public const BinaryNode.DataTypePrecedence SqlBinary = -10;
}

// Namespace: System.Data
internal class BinaryNode : ExpressionNode // TypeDefIndex: 12709
{
	// Fields
	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28

	// Methods

	// RVA: 0x1DF8B30 Offset: 0x1DF7D30 VA: 0x181DF8B30
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x1DF28C0 Offset: 0x1DF1AC0 VA: 0x181DF28C0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1DD2750 Offset: 0x1DD1950 VA: 0x181DD2750 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1DF7890 Offset: 0x1DF6A90 VA: 0x181DF7890 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1DF7800 Offset: 0x1DF6A00 VA: 0x181DF7800 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1DF7C80 Offset: 0x1DF6E80 VA: 0x181DF7C80 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1DF7DE0 Offset: 0x1DF6FE0 VA: 0x181DF7DE0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1DF7BC0 Offset: 0x1DF6DC0 VA: 0x181DF7BC0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1DF7C20 Offset: 0x1DF6E20 VA: 0x181DF7C20 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1DF2930 Offset: 0x1DF1B30 VA: 0x181DF2930 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1DF7E40 Offset: 0x1DF7040 VA: 0x181DF7E40 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1DF8A00 Offset: 0x1DF7C00 VA: 0x181DF8A00
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0x1DF7840 Offset: 0x1DF6A40 VA: 0x181DF7840
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x1DF1990 Offset: 0x1DF0B90 VA: 0x181DF1990
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0x1DF19C0 Offset: 0x1DF0BC0 VA: 0x181DF19C0
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0x1DF29A0 Offset: 0x1DF1BA0 VA: 0x181DF29A0
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x1DF7A30 Offset: 0x1DF6C30 VA: 0x181DF7A30
	private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0x1DF78C0 Offset: 0x1DF6AC0 VA: 0x181DF78C0
	private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code) { }

	// RVA: 0x1DF7D70 Offset: 0x1DF6F70 VA: 0x181DF7D70
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0x1DF7CE0 Offset: 0x1DF6EE0 VA: 0x181DF7CE0
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0x1DF8690 Offset: 0x1DF7890 VA: 0x181DF8690
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1DF81D0 Offset: 0x1DF73D0 VA: 0x181DF81D0
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1DF8A40 Offset: 0x1DF7C40 VA: 0x181DF8A40
	private int SqlResultType(int typeCode) { }
}

// Namespace: System.Data
internal sealed class LikeNode : BinaryNode // TypeDefIndex: 12710
{
	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0x1DF8B30 Offset: 0x1DF7D30 VA: 0x181DF8B30
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x1E06320 Offset: 0x1E05520 VA: 0x181E06320 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1E05FD0 Offset: 0x1E051D0 VA: 0x181E05FD0
	internal string AnalyzePattern(string pat) { }
}

// Namespace: System.Data
internal sealed class ConstNode : ExpressionNode // TypeDefIndex: 12711
{
	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0x1DF94A0 Offset: 0x1DF86A0 VA: 0x181DF94A0
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0x1DF9130 Offset: 0x1DF8330 VA: 0x181DF9130
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	internal override object Eval() { }

	// RVA: 0x6E6600 Offset: 0x6E5800 VA: 0x1806E6600 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x6E6600 Offset: 0x6E5800 VA: 0x1806E6600 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1DF8B80 Offset: 0x1DF7D80 VA: 0x181DF8B80
	private object SmallestDecimal(object constant) { }

	// RVA: 0x1DF8E10 Offset: 0x1DF8010 VA: 0x181DF8E10
	private object SmallestNumeric(object constant) { }
}

// Namespace: System.Data
internal sealed class DataExpression : IFilter // TypeDefIndex: 12712
{
	// Fields
	internal string _originalExpression; // 0x10
	private bool _parsed; // 0x18
	private bool _bound; // 0x19
	private ExpressionNode _expr; // 0x20
	private DataTable _table; // 0x28
	private readonly StorageType _storageType; // 0x30
	private readonly Type _dataType; // 0x38
	private DataColumn[] _dependency; // 0x40

	// Properties
	internal string Expression { get; }
	internal bool HasValue { get; }

	// Methods

	// RVA: 0x1DF9CC0 Offset: 0x1DF8EC0 VA: 0x181DF9CC0
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0x1DF9CE0 Offset: 0x1DF8EE0 VA: 0x181DF9CE0
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0x1DF9FF0 Offset: 0x1DF91F0 VA: 0x181DF9FF0
	internal string get_Expression() { }

	// RVA: 0x1D39AE0 Offset: 0x1D38CE0 VA: 0x181D39AE0
	internal bool get_HasValue() { }

	// RVA: 0x1DF94C0 Offset: 0x1DF86C0 VA: 0x181DF94C0
	internal void Bind(DataTable table) { }

	// RVA: 0x1DF95C0 Offset: 0x1DF87C0 VA: 0x181DF95C0
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0x1DF9800 Offset: 0x1DF8A00 VA: 0x181DF9800
	internal object Evaluate() { }

	// RVA: 0x1DF95F0 Offset: 0x1DF87F0 VA: 0x181DF95F0
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0x1DF9870 Offset: 0x1DF8A70 VA: 0x181DF9870 Slot: 4
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal DataColumn[] GetDependency() { }

	// RVA: 0x1DF9920 Offset: 0x1DF8B20 VA: 0x181DF9920
	internal bool IsTableAggregate() { }

	// RVA: 0x1DF9950 Offset: 0x1DF8B50 VA: 0x181DF9950
	internal static bool IsUnknown(object value) { }

	// RVA: 0x1DF9810 Offset: 0x1DF8A10 VA: 0x181DF9810
	internal bool HasLocalAggregate() { }

	// RVA: 0x1DF9840 Offset: 0x1DF8A40 VA: 0x181DF9840
	internal bool HasRemoteAggregate() { }

	// RVA: 0x1DF99A0 Offset: 0x1DF8BA0 VA: 0x181DF99A0
	internal static bool ToBoolean(object value) { }
}

// Namespace: System.Data
internal abstract class ExpressionNode // TypeDefIndex: 12713
{
	// Fields
	private DataTable _table; // 0x10

	// Properties
	internal IFormatProvider FormatProvider { get; }
	internal virtual bool IsSqlColumn { get; }
	protected DataTable table { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	protected void .ctor(DataTable table) { }

	// RVA: 0x1E02AE0 Offset: 0x1E01CE0 VA: 0x181E02AE0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	protected DataTable get_table() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	protected void BindTable(DataTable table) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void Bind(DataTable table, List<DataColumn> list);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract object Eval();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract object Eval(DataRow row, DataRowVersion version);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract object Eval(int[] recordNos);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool IsConstant();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool IsTableConstant();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool HasLocalAggregate();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool HasRemoteAggregate();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract ExpressionNode Optimize();

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 14
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0x1E029B0 Offset: 0x1E01BB0 VA: 0x181E029B0
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0x1E02990 Offset: 0x1E01B90 VA: 0x181E02990
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0x1E02A80 Offset: 0x1E01C80 VA: 0x181E02A80
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0x1E02A40 Offset: 0x1E01C40 VA: 0x181E02A40
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0x1E02AC0 Offset: 0x1E01CC0 VA: 0x181E02AC0
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0x1E02AA0 Offset: 0x1E01CA0 VA: 0x181E02AA0
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0x1E02A10 Offset: 0x1E01C10 VA: 0x181E02A10
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0x1E029D0 Offset: 0x1E01BD0 VA: 0x181E029D0
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0x1E02970 Offset: 0x1E01B70 VA: 0x181E02970
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0x1E02950 Offset: 0x1E01B50 VA: 0x181E02950
	internal static bool IsFloatSql(StorageType type) { }
}

// Namespace: System.Data
internal enum ValueType // TypeDefIndex: 12714
{
	// Fields
	public int value__; // 0x0
	public const ValueType Unknown = -1;
	public const ValueType Null = 0;
	public const ValueType Bool = 1;
	public const ValueType Numeric = 2;
	public const ValueType Str = 3;
	public const ValueType Float = 4;
	public const ValueType Decimal = 5;
	public const ValueType Object = 6;
	public const ValueType Date = 7;
}

// Namespace: System.Data
internal enum Nodes // TypeDefIndex: 12715
{
	// Fields
	public int value__; // 0x0
	public const Nodes Noop = 0;
	public const Nodes Unop = 1;
	public const Nodes UnopSpec = 2;
	public const Nodes Binop = 3;
	public const Nodes BinopSpec = 4;
	public const Nodes Zop = 5;
	public const Nodes Call = 6;
	public const Nodes Const = 7;
	public const Nodes Name = 8;
	public const Nodes Paren = 9;
	public const Nodes Conv = 10;
}

// Namespace: 
[IsReadOnly]
private struct ExpressionParser.ReservedWords // TypeDefIndex: 12716
{
	// Fields
	internal readonly string _word; // 0x0
	internal readonly Tokens _token; // 0x8
	internal readonly int _op; // 0xC

	// Methods

	// RVA: 0xBD29B0 Offset: 0xBD1BB0 VA: 0x180BD29B0
	internal void .ctor(string word, Tokens token, int op) { }
}

// Namespace: System.Data
internal sealed class ExpressionParser // TypeDefIndex: 12717
{
	// Fields
	private static readonly ExpressionParser.ReservedWords[] s_reservedwords; // 0x0
	private char _escape; // 0x10
	private char _decimalSeparator; // 0x12
	private char _listSeparator; // 0x14
	private char _exponentL; // 0x16
	private char _exponentU; // 0x18
	internal char[] _text; // 0x20
	internal int _pos; // 0x28
	internal int _start; // 0x2C
	internal Tokens _token; // 0x30
	internal int _op; // 0x34
	internal OperatorInfo[] _ops; // 0x38
	internal int _topOperator; // 0x40
	internal int _topNode; // 0x44
	private readonly DataTable _table; // 0x48
	internal ExpressionNode[] _nodeStack; // 0x50
	internal int _prevOperand; // 0x58
	internal ExpressionNode _expression; // 0x60

	// Methods

	// RVA: 0x1E05F40 Offset: 0x1E05140 VA: 0x181E05F40
	internal void .ctor(DataTable table) { }

	// RVA: 0x1E03070 Offset: 0x1E02270 VA: 0x181E03070
	internal void LoadExpression(string data) { }

	// RVA: 0x1E05AD0 Offset: 0x1E04CD0 VA: 0x181E05AD0
	internal void StartScan() { }

	// RVA: 0x1E03650 Offset: 0x1E02850 VA: 0x181E03650
	internal ExpressionNode Parse() { }

	// RVA: 0x1E03260 Offset: 0x1E02460 VA: 0x181E03260
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0x1E03180 Offset: 0x1E02380 VA: 0x181E03180
	private ExpressionNode NodePop() { }

	// RVA: 0x1E03140 Offset: 0x1E02340 VA: 0x181E03140
	private ExpressionNode NodePeek() { }

	// RVA: 0x1E031C0 Offset: 0x1E023C0 VA: 0x181E031C0
	private void NodePush(ExpressionNode node) { }

	// RVA: 0x1E02B40 Offset: 0x1E01D40 VA: 0x181E02B40
	private void BuildExpression(int pri) { }

	// RVA: 0x1E02E90 Offset: 0x1E02090 VA: 0x181E02E90
	internal void CheckToken(Tokens token) { }

	// RVA: 0x1E053B0 Offset: 0x1E045B0 VA: 0x181E053B0
	internal Tokens Scan() { }

	// RVA: 0x1E04D70 Offset: 0x1E03F70 VA: 0x181E04D70
	private void ScanNumeric() { }

	// RVA: 0x1E04B60 Offset: 0x1E03D60 VA: 0x181E04B60
	private void ScanName() { }

	// RVA: 0x1E04C40 Offset: 0x1E03E40 VA: 0x181E04C40
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	// RVA: 0x1E04A50 Offset: 0x1E03C50 VA: 0x181E04A50
	private void ScanDate() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void ScanBinaryConstant() { }

	// RVA: 0x1E04F70 Offset: 0x1E04170 VA: 0x181E04F70
	private void ScanReserved() { }

	// RVA: 0x1E05220 Offset: 0x1E04420 VA: 0x181E05220
	private void ScanString(char escape) { }

	// RVA: 0x1E05300 Offset: 0x1E04500 VA: 0x181E05300
	internal void ScanToken(Tokens token) { }

	// RVA: 0x1E05360 Offset: 0x1E04560 VA: 0x181E05360
	private void ScanWhite() { }

	// RVA: 0x1E03060 Offset: 0x1E02260 VA: 0x181E03060
	private bool IsWhiteSpace(char ch) { }

	// RVA: 0x1E02EE0 Offset: 0x1E020E0 VA: 0x181E02EE0
	private bool IsAlphaNumeric(char ch) { }

	// RVA: 0x1E03000 Offset: 0x1E02200 VA: 0x181E03000
	private bool IsDigit(char ch) { }

	// RVA: 0x1E02F80 Offset: 0x1E02180 VA: 0x181E02F80
	private bool IsAlpha(char ch) { }

	// RVA: 0x1E05B60 Offset: 0x1E04D60 VA: 0x181E05B60
	private static void .cctor() { }
}

// Namespace: System.Data
internal enum Tokens // TypeDefIndex: 12718
{
	// Fields
	public int value__; // 0x0
	public const Tokens None = 0;
	public const Tokens Name = 1;
	public const Tokens Numeric = 2;
	public const Tokens Decimal = 3;
	public const Tokens Float = 4;
	public const Tokens BinaryConst = 5;
	public const Tokens StringConst = 6;
	public const Tokens Date = 7;
	public const Tokens ListSeparator = 8;
	public const Tokens LeftParen = 9;
	public const Tokens RightParen = 10;
	public const Tokens ZeroOp = 11;
	public const Tokens UnaryOp = 12;
	public const Tokens BinaryOp = 13;
	public const Tokens Child = 14;
	public const Tokens Parent = 15;
	public const Tokens Dot = 16;
	public const Tokens Unknown = 17;
	public const Tokens EOS = 18;
}

// Namespace: System.Data
internal sealed class OperatorInfo // TypeDefIndex: 12719
{
	// Fields
	internal Nodes _type; // 0x10
	internal int _op; // 0x14
	internal int _priority; // 0x18

	// Methods

	// RVA: 0x15E5C40 Offset: 0x15E4E40 VA: 0x1815E5C40
	internal void .ctor(Nodes type, int op, int pri) { }
}

// Namespace: System.Data
[Serializable]
public class InvalidExpressionException : DataException // TypeDefIndex: 12720
{
	// Methods

	// RVA: 0x15A17F0 Offset: 0x15A09F0 VA: 0x1815A17F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E06960 Offset: 0x1E05B60 VA: 0x181E06960
	public void .ctor() { }

	// RVA: 0x1E06970 Offset: 0x1E05B70 VA: 0x181E06970
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class EvaluateException : InvalidExpressionException // TypeDefIndex: 12721
{
	// Methods

	// RVA: 0x15A17F0 Offset: 0x15A09F0 VA: 0x1815A17F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E06960 Offset: 0x1E05B60 VA: 0x181E06960
	public void .ctor() { }

	// RVA: 0x1E06970 Offset: 0x1E05B70 VA: 0x181E06970
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class SyntaxErrorException : InvalidExpressionException // TypeDefIndex: 12722
{
	// Methods

	// RVA: 0x15A17F0 Offset: 0x15A09F0 VA: 0x1815A17F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E06960 Offset: 0x1E05B60 VA: 0x181E06960
	public void .ctor() { }

	// RVA: 0x1E06970 Offset: 0x1E05B70 VA: 0x181E06970
	public void .ctor(string s) { }
}

// Namespace: System.Data
internal sealed class ExprException // TypeDefIndex: 12723
{
	// Methods

	// RVA: 0x1E08830 Offset: 0x1E07A30 VA: 0x181E08830
	private static OverflowException _Overflow(string error) { }

	// RVA: 0x1E087D0 Offset: 0x1E079D0 VA: 0x181E087D0
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0x1E08890 Offset: 0x1E07A90 VA: 0x181E08890
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0x1E08770 Offset: 0x1E07970 VA: 0x181E08770
	private static EvaluateException _Eval(string error) { }

	// RVA: 0x1E08710 Offset: 0x1E07910 VA: 0x181E08710
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0x1E079E0 Offset: 0x1E06BE0 VA: 0x181E079E0
	public static Exception InvokeArgument() { }

	// RVA: 0x1E07D90 Offset: 0x1E06F90 VA: 0x181E07D90
	public static Exception NYI(string moreinfo) { }

	// RVA: 0x1E07BB0 Offset: 0x1E06DB0 VA: 0x181E07BB0
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0x1E07C80 Offset: 0x1E06E80 VA: 0x181E07C80
	public static Exception MissingOperator(string token) { }

	// RVA: 0x1E08180 Offset: 0x1E07380 VA: 0x181E08180
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0x1E07320 Offset: 0x1E06520 VA: 0x181E07320
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0x1E070F0 Offset: 0x1E062F0 VA: 0x181E070F0
	public static Exception ExpressionTooComplex() { }

	// RVA: 0x1E08210 Offset: 0x1E07410 VA: 0x181E08210
	public static Exception UnboundName(string name) { }

	// RVA: 0x1E07840 Offset: 0x1E06A40 VA: 0x181E07840
	public static Exception InvalidString(string str) { }

	// RVA: 0x1E082A0 Offset: 0x1E074A0 VA: 0x181E082A0
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0x1E07F60 Offset: 0x1E07160 VA: 0x181E07F60
	public static Exception SyntaxError() { }

	// RVA: 0x1E07290 Offset: 0x1E06490 VA: 0x181E07290
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0x1E07D10 Offset: 0x1E06F10 VA: 0x181E07D10
	public static Exception MissingRightParen() { }

	// RVA: 0x1E08470 Offset: 0x1E07670 VA: 0x181E08470
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0x1E08330 Offset: 0x1E07530 VA: 0x181E08330
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0x1E06EB0 Offset: 0x1E060B0 VA: 0x181E06EB0
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0x1E06F90 Offset: 0x1E06190 VA: 0x181E06F90
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0x1E07720 Offset: 0x1E06920 VA: 0x181E07720
	public static Exception InvalidName(string name) { }

	// RVA: 0x1E07480 Offset: 0x1E06680 VA: 0x181E07480
	public static Exception InvalidDate(string date) { }

	// RVA: 0x1E07E20 Offset: 0x1E07020 VA: 0x181E07E20
	public static Exception NonConstantArgument() { }

	// RVA: 0x1E077B0 Offset: 0x1E069B0 VA: 0x181E077B0
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0x1E07400 Offset: 0x1E06600 VA: 0x181E07400
	public static Exception InWithoutParentheses() { }

	// RVA: 0x1E07380 Offset: 0x1E06580 VA: 0x181E07380
	public static Exception InWithoutList() { }

	// RVA: 0x1E07590 Offset: 0x1E06790 VA: 0x181E07590
	public static Exception InvalidIsSyntax() { }

	// RVA: 0x1E07EA0 Offset: 0x1E070A0 VA: 0x181E07EA0
	public static Exception Overflow(Type type) { }

	// RVA: 0x1E06C80 Offset: 0x1E05E80 VA: 0x181E06C80
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0x1E06BB0 Offset: 0x1E05DB0 VA: 0x181E06BB0
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0x1E08060 Offset: 0x1E07260 VA: 0x181E08060
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0x1E06A90 Offset: 0x1E05C90 VA: 0x181E06A90
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0x1E08650 Offset: 0x1E07850 VA: 0x181E08650
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0x1E07690 Offset: 0x1E06890 VA: 0x181E07690
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0x1E07B20 Offset: 0x1E06D20 VA: 0x181E07B20
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0x1E07FE0 Offset: 0x1E071E0 VA: 0x181E07FE0
	public static Exception TooManyRightParentheses() { }

	// RVA: 0x1E08540 Offset: 0x1E07740 VA: 0x181E08540
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0x1E06D90 Offset: 0x1E05F90 VA: 0x181E06D90
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0x1E06980 Offset: 0x1E05B80 VA: 0x181E06980
	public static Exception AggregateArgument() { }

	// RVA: 0x1E06A00 Offset: 0x1E05C00 VA: 0x181E06A00
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0x1E07070 Offset: 0x1E06270 VA: 0x181E07070
	public static Exception EvalNoContext() { }

	// RVA: 0x1E07170 Offset: 0x1E06370 VA: 0x181E07170
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0x1E06E20 Offset: 0x1E06020 VA: 0x181E06E20
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0x1E07200 Offset: 0x1E06400 VA: 0x181E07200
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0x1E07A20 Offset: 0x1E06C20 VA: 0x181E07A20
	public static Exception LookupArgument() { }

	// RVA: 0x1E07950 Offset: 0x1E06B50 VA: 0x181E07950
	public static Exception InvalidType(string typeName) { }

	// RVA: 0x1E07510 Offset: 0x1E06710 VA: 0x181E07510
	public static Exception InvalidHoursArgument() { }

	// RVA: 0x1E07610 Offset: 0x1E06810 VA: 0x181E07610
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0x1E078D0 Offset: 0x1E06AD0 VA: 0x181E078D0
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0x1E07AA0 Offset: 0x1E06CA0 VA: 0x181E07AA0
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0x1E085E0 Offset: 0x1E077E0 VA: 0x181E085E0
	public static Exception UnsupportedDataType(Type type) { }
}

// Namespace: System.Data
internal interface IFilter // TypeDefIndex: 12724
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Invoke(DataRow row, DataRowVersion version);
}

// Namespace: System.Data
internal sealed class LookupNode : ExpressionNode // TypeDefIndex: 12725
{
	// Fields
	private readonly string _relationName; // 0x18
	private readonly string _columnName; // 0x20
	private DataColumn _column; // 0x28
	private DataRelation _relation; // 0x30

	// Methods

	// RVA: 0x1E0FEE0 Offset: 0x1E0F0E0 VA: 0x181E0FEE0
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0x1E0FAC0 Offset: 0x1E0ECC0 VA: 0x181E0FAC0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1E0FD50 Offset: 0x1E0EF50 VA: 0x181E0FD50 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1E0FDC0 Offset: 0x1E0EFC0 VA: 0x181E0FDC0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1E0FD80 Offset: 0x1E0EF80 VA: 0x181E0FD80 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1E0FD40 Offset: 0x1E0EF40 VA: 0x181E0FD40 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
internal sealed class NameNode : ExpressionNode // TypeDefIndex: 12726
{
	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Properties
	internal override bool IsSqlColumn { get; }

	// Methods

	// RVA: 0x1E13500 Offset: 0x1E12700 VA: 0x181E13500
	internal void .ctor(DataTable table, char[] text, int start, int pos) { }

	// RVA: 0x1E13550 Offset: 0x1E12750 VA: 0x181E13550
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x1E13580 Offset: 0x1E12780 VA: 0x181E13580 Slot: 4
	internal override bool get_IsSqlColumn() { }

	// RVA: 0x1E12DC0 Offset: 0x1E11FC0 VA: 0x181E12DC0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1E13100 Offset: 0x1E12300 VA: 0x181E13100 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1E12FF0 Offset: 0x1E121F0 VA: 0x181E12FF0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1E130C0 Offset: 0x1E122C0 VA: 0x181E130C0 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1E131D0 Offset: 0x1E123D0 VA: 0x181E131D0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1E13130 Offset: 0x1E12330 VA: 0x181E13130 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1E13180 Offset: 0x1E12380 VA: 0x181E13180 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1E12F80 Offset: 0x1E12180 VA: 0x181E12F80 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1E13220 Offset: 0x1E12420 VA: 0x181E13220
	internal static string ParseName(char[] text, int start, int pos) { }
}

// Namespace: System.Data
internal sealed class Operators // TypeDefIndex: 12727
{
	// Fields
	private static readonly int[] s_priority; // 0x0
	private static readonly string[] s_looks; // 0x8

	// Methods

	// RVA: 0x1E13610 Offset: 0x1E12810 VA: 0x181E13610
	internal static bool IsArithmetical(int op) { }

	// RVA: 0x1E13630 Offset: 0x1E12830 VA: 0x181E13630
	internal static bool IsLogical(int op) { }

	// RVA: 0x1E13650 Offset: 0x1E12850 VA: 0x181E13650
	internal static bool IsRelational(int op) { }

	// RVA: 0x1E13660 Offset: 0x1E12860 VA: 0x181E13660
	internal static int Priority(int op) { }

	// RVA: 0x1E13700 Offset: 0x1E12900 VA: 0x181E13700
	internal static string ToString(int op) { }

	// RVA: 0x1E137B0 Offset: 0x1E129B0 VA: 0x181E137B0
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 12728
{
	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0x1E187E0 Offset: 0x1E179E0 VA: 0x181E187E0
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0x1E17BA0 Offset: 0x1E16DA0 VA: 0x181E17BA0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1DD2750 Offset: 0x1DD1950 VA: 0x181DD2750 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1E185F0 Offset: 0x1E177F0 VA: 0x181E185F0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1E185C0 Offset: 0x1E177C0 VA: 0x181E185C0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1E17C00 Offset: 0x1E16E00 VA: 0x181E17C00
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0x1E186A0 Offset: 0x1E178A0 VA: 0x181E186A0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1E186D0 Offset: 0x1E178D0 VA: 0x181E186D0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1E18640 Offset: 0x1E17840 VA: 0x181E18640 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1E18670 Offset: 0x1E17870 VA: 0x181E18670 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1E17BD0 Offset: 0x1E16DD0 VA: 0x181E17BD0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1E18700 Offset: 0x1E17900 VA: 0x181E18700 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 12729
{
	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0x1E1FF30 Offset: 0x1E1F130 VA: 0x181E1FF30
	internal void .ctor(int op) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1E1FE90 Offset: 0x1E1F090 VA: 0x181E1FE90 Slot: 6
	internal override object Eval() { }

	// RVA: 0x6E6600 Offset: 0x6E5800 VA: 0x1806E6600 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x6E6600 Offset: 0x6E5800 VA: 0x1806E6600 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
[DefaultProperty("ConstraintName")]
public class ForeignKeyConstraint : Constraint // TypeDefIndex: 12730
{
	// Fields
	internal Rule _deleteRule; // 0x38
	internal Rule _updateRule; // 0x3C
	internal AcceptRejectRule _acceptRejectRule; // 0x40
	private DataKey _childKey; // 0x48
	private DataKey _parentKey; // 0x50
	internal string _constraintName; // 0x58
	internal string[] _parentColumnNames; // 0x60
	internal string[] _childColumnNames; // 0x68
	internal string _parentTableName; // 0x70
	internal string _parentTableNamespace; // 0x78

	// Properties
	internal DataKey ChildKey { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	[DefaultValue(0)]
	public virtual AcceptRejectRule AcceptRejectRule { get; set; }
	[DefaultValue(1)]
	public virtual Rule DeleteRule { get; set; }
	[ReadOnly(True)]
	public virtual DataColumn[] RelatedColumns { get; }
	internal DataColumn[] RelatedColumnsReference { get; }
	internal DataKey ParentKey { get; }
	[ReadOnly(True)]
	public virtual DataTable RelatedTable { get; }
	[DefaultValue(1)]
	public virtual Rule UpdateRule { get; set; }

	// Methods

	// RVA: 0x1E0BA70 Offset: 0x1E0AC70 VA: 0x181E0BA70
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1E0BAD0 Offset: 0x1E0ACD0 VA: 0x181E0BAD0
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Browsable(False)]
	// RVA: 0x1E0B9F0 Offset: 0x1E0ABF0 VA: 0x181E0B9F0
	public void .ctor(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	// RVA: 0x1E0BB70 Offset: 0x1E0AD70 VA: 0x181E0BB70
	internal DataKey get_ChildKey() { }

	// RVA: 0x1E0BB90 Offset: 0x1E0AD90 VA: 0x181E0BB90 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x1E0BC40 Offset: 0x1E0AE40 VA: 0x181E0BC40 Slot: 8
	public override DataTable get_Table() { }

	// RVA: 0x1E0BBD0 Offset: 0x1E0ADD0 VA: 0x181E0BBD0
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x1E0BB60 Offset: 0x1E0AD60 VA: 0x181E0BB60
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x1E099A0 Offset: 0x1E08BA0 VA: 0x181E099A0 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x1E0B680 Offset: 0x1E0A880 VA: 0x181E0B680
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0x1E0B3E0 Offset: 0x1E0A5E0 VA: 0x181E0B3E0 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x1E088F0 Offset: 0x1E07AF0 VA: 0x181E088F0 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x1E08AF0 Offset: 0x1E07CF0 VA: 0x181E08AF0
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0x1E08C70 Offset: 0x1E07E70 VA: 0x181E08C70
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0x1E091E0 Offset: 0x1E083E0 VA: 0x181E091E0
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0x1E09440 Offset: 0x1E08640 VA: 0x181E09440
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0x1E09B20 Offset: 0x1E08D20 VA: 0x181E09B20
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0x1E09C30 Offset: 0x1E08E30 VA: 0x181E09C30
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0x1E09CF0 Offset: 0x1E08EF0 VA: 0x181E09CF0
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0x1E09FF0 Offset: 0x1E091F0 VA: 0x181E09FF0 Slot: 15
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0x1E0B730 Offset: 0x1E0A930 VA: 0x181E0B730
	private void NonVirtualCheckState() { }

	// RVA: 0x1E0A2E0 Offset: 0x1E094E0 VA: 0x181E0A2E0 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x1E0BB40 Offset: 0x1E0AD40 VA: 0x181E0BB40 Slot: 20
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0x1E0BC80 Offset: 0x1E0AE80 VA: 0x181E0BC80 Slot: 21
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x1E0AF40 Offset: 0x1E0A140 VA: 0x181E0AF40 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1E0AF20 Offset: 0x1E0A120 VA: 0x181E0AF20 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x1E0A2F0 Offset: 0x1E094F0 VA: 0x181E0A2F0 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x1E0A990 Offset: 0x1E09B90 VA: 0x181E0A990
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0x1E0AF90 Offset: 0x1E0A190 VA: 0x181E0AF90
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1E0BBB0 Offset: 0x1E0ADB0 VA: 0x181E0BBB0 Slot: 22
	public virtual Rule get_DeleteRule() { }

	// RVA: 0x1E0BCD0 Offset: 0x1E0AED0 VA: 0x181E0BCD0 Slot: 23
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0x1E0B1A0 Offset: 0x1E0A3A0 VA: 0x181E0B1A0 Slot: 0
	public override bool Equals(object key) { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E0BC00 Offset: 0x1E0AE00 VA: 0x181E0BC00 Slot: 24
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0x1E0BBE0 Offset: 0x1E0ADE0 VA: 0x181E0BBE0
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0x1E0BBE0 Offset: 0x1E0ADE0 VA: 0x181E0BBE0
	internal DataKey get_ParentKey() { }

	// RVA: 0x1E0B2F0 Offset: 0x1E0A4F0 VA: 0x181E0B2F0
	internal DataRelation FindParentRelation() { }

	// RVA: 0x1E0BC20 Offset: 0x1E0AE20 VA: 0x181E0BC20 Slot: 25
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0x1E0BC60 Offset: 0x1E0AE60 VA: 0x181E0BC60 Slot: 26
	public virtual Rule get_UpdateRule() { }

	// RVA: 0x1E0BD20 Offset: 0x1E0AF20 VA: 0x181E0BD20 Slot: 27
	public virtual void set_UpdateRule(Rule value) { }
}

// Namespace: System.Data
public enum MappingType // TypeDefIndex: 12731
{
	// Fields
	public int value__; // 0x0
	public const MappingType Element = 1;
	public const MappingType Attribute = 2;
	public const MappingType SimpleContent = 3;
	public const MappingType Hidden = 4;
}

// Namespace: System.Data
public class MergeFailedEventArgs : EventArgs // TypeDefIndex: 12732
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Conflict>k__BackingField; // 0x18

	// Properties
	public string Conflict { get; }

	// Methods

	// RVA: 0x1E0FF20 Offset: 0x1E0F120 VA: 0x181E0FF20
	public void .ctor(DataTable table, string conflict) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Conflict() { }
}

// Namespace: System.Data
public sealed class MergeFailedEventHandler : MulticastDelegate // TypeDefIndex: 12733
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, MergeFailedEventArgs e) { }
}

// Namespace: System.Data
internal sealed class Merger // TypeDefIndex: 12734
{
	// Fields
	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29

	// Methods

	// RVA: 0x1E12D60 Offset: 0x1E11F60 VA: 0x181E12D60
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1E12D00 Offset: 0x1E11F00 VA: 0x181E12D00
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1E10460 Offset: 0x1E0F660 VA: 0x181E10460
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0x1E124F0 Offset: 0x1E116F0 VA: 0x181E124F0
	internal void MergeTable(DataTable src) { }

	// RVA: 0x1E12760 Offset: 0x1E11960 VA: 0x181E12760
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0x1E11BA0 Offset: 0x1E10DA0 VA: 0x181E11BA0
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0x1E12450 Offset: 0x1E11650 VA: 0x181E12450
	private void MergeTableData(DataTable src) { }

	// RVA: 0x1E10110 Offset: 0x1E0F310 VA: 0x181E10110
	private void MergeConstraints(DataSet source) { }

	// RVA: 0x1E101A0 Offset: 0x1E0F3A0 VA: 0x181E101A0
	private void MergeConstraints(DataTable table) { }

	// RVA: 0x1E112C0 Offset: 0x1E104C0 VA: 0x181E112C0
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0x1E11100 Offset: 0x1E10300 VA: 0x181E11100
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0x1E0FF90 Offset: 0x1E0F190 VA: 0x181E0FF90
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }
}

// Namespace: System.Data
public enum MissingSchemaAction // TypeDefIndex: 12735
{
	// Fields
	public int value__; // 0x0
	public const MissingSchemaAction Add = 1;
	public const MissingSchemaAction Ignore = 2;
	public const MissingSchemaAction Error = 3;
	public const MissingSchemaAction AddWithKey = 4;
}

// Namespace: System.Data
internal sealed class PrimaryKeyTypeConverter : ReferenceConverter // TypeDefIndex: 12736
{
	// Methods

	// RVA: 0x1E14000 Offset: 0x1E13200 VA: 0x181E14000
	public void .ctor() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1E13DC0 Offset: 0x1E12FC0 VA: 0x181E13DC0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1E13E70 Offset: 0x1E13070 VA: 0x181E13E70 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
[Serializable]
public class PropertyCollection : Hashtable, ICloneable // TypeDefIndex: 12737
{
	// Methods

	// RVA: 0x1E142F0 Offset: 0x1E134F0 VA: 0x181E142F0
	public void .ctor() { }

	// RVA: 0x1E14300 Offset: 0x1E13500 VA: 0x181E14300
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E140A0 Offset: 0x1E132A0 VA: 0x181E140A0 Slot: 25
	public override object Clone() { }
}

// Namespace: System.Data
internal struct Range // TypeDefIndex: 12738
{
	// Fields
	private int _min; // 0x0
	private int _max; // 0x4
	private bool _isNotNull; // 0x8

	// Properties
	public int Count { get; }
	public bool IsNull { get; }
	public int Min { get; }

	// Methods

	// RVA: 0x1E14360 Offset: 0x1E13560 VA: 0x181E14360
	public void .ctor(int min, int max) { }

	// RVA: 0x1E143B0 Offset: 0x1E135B0 VA: 0x181E143B0
	public int get_Count() { }

	// RVA: 0x1E143D0 Offset: 0x1E135D0 VA: 0x181E143D0
	public bool get_IsNull() { }

	// RVA: 0x1E143E0 Offset: 0x1E135E0 VA: 0x181E143E0
	public int get_Min() { }

	// RVA: 0x1E14320 Offset: 0x1E13520 VA: 0x181E14320
	internal void CheckNull() { }
}

// Namespace: System.Data
internal enum RBTreeError // TypeDefIndex: 12739
{
	// Fields
	public int value__; // 0x0
	public const RBTreeError InvalidPageSize = 1;
	public const RBTreeError PagePositionInSlotInUse = 3;
	public const RBTreeError NoFreeSlots = 4;
	public const RBTreeError InvalidStateinInsert = 5;
	public const RBTreeError InvalidNextSizeInDelete = 7;
	public const RBTreeError InvalidStateinDelete = 8;
	public const RBTreeError InvalidNodeSizeinDelete = 9;
	public const RBTreeError InvalidStateinEndDelete = 10;
	public const RBTreeError CannotRotateInvalidsuccessorNodeinDelete = 11;
	public const RBTreeError IndexOutOFRangeinGetNodeByIndex = 13;
	public const RBTreeError RBDeleteFixup = 14;
	public const RBTreeError UnsupportedAccessMethod1 = 15;
	public const RBTreeError UnsupportedAccessMethod2 = 16;
	public const RBTreeError UnsupportedAccessMethodInNonNillRootSubtree = 17;
	public const RBTreeError AttachedNodeWithZerorbTreeNodeId = 18;
	public const RBTreeError CompareNodeInDataRowTree = 19;
	public const RBTreeError CompareSateliteTreeNodeInDataRowTree = 20;
	public const RBTreeError NestedSatelliteTreeEnumerator = 21;
}

// Namespace: System.Data
internal enum TreeAccessMethod // TypeDefIndex: 12740
{
	// Fields
	public int value__; // 0x0
	public const TreeAccessMethod KEY_SEARCH_AND_INDEX = 1;
	public const TreeAccessMethod INDEX_ONLY = 2;
}

// Namespace: 
private enum RBTree.NodeColor<K> // TypeDefIndex: 12741
{
	// Fields
	public int value__; // 0x0
	public const RBTree.NodeColor<K> red = 0;
	public const RBTree.NodeColor<K> black = 1;
}

// Namespace: 
private struct RBTree.Node<K> // TypeDefIndex: 12742
{
	// Fields
	internal int _selfId; // 0x0
	internal int _leftId; // 0x0
	internal int _rightId; // 0x0
	internal int _parentId; // 0x0
	internal int _nextId; // 0x0
	internal int _subTreeSize; // 0x0
	internal K _keyOfNode; // 0x0
	internal RBTree.NodeColor<K> _nodeColor; // 0x0
}

// Namespace: 
[IsReadOnly]
private struct RBTree.NodePath<K> // TypeDefIndex: 12743
{
	// Fields
	internal readonly int _nodeID; // 0x0
	internal readonly int _mainTreeNodeID; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int nodeID, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	|-RBTree.NodePath<int>..ctor
	|-RBTree.NodePath<object>..ctor
	|-RBTree.NodePath<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private sealed class RBTree.TreePage<K> // TypeDefIndex: 12744
{
	// Fields
	internal readonly RBTree.Node<K>[] _slots; // 0x0
	internal readonly int[] _slotMap; // 0x0
	private int _inUseCount; // 0x0
	private int _pageId; // 0x0
	private int _nextFreeSlotLine; // 0x0

	// Properties
	internal int InUseCount { get; set; }
	internal int PageId { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCBF340 Offset: 0xCBE540 VA: 0x180CBF340
	|-RBTree.TreePage<int>..ctor
	|
	|-RVA: 0xCBF400 Offset: 0xCBE600 VA: 0x180CBF400
	|-RBTree.TreePage<object>..ctor
	|
	|-RVA: 0xCBF4C0 Offset: 0xCBE6C0 VA: 0x180CBF4C0
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int AllocSlot(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCBF1E0 Offset: 0xCBE3E0 VA: 0x180CBF1E0
	|-RBTree.TreePage<int>.AllocSlot
	|-RBTree.TreePage<object>.AllocSlot
	|
	|-RVA: 0xCBF070 Offset: 0xCBE270 VA: 0x180CBF070
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.AllocSlot
	*/

	// RVA: -1 Offset: -1
	internal int get_InUseCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	|-RBTree.TreePage<int>.get_InUseCount
	|-RBTree.TreePage<object>.get_InUseCount
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.get_InUseCount
	*/

	// RVA: -1 Offset: -1
	internal void set_InUseCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	|-RBTree.TreePage<int>.set_InUseCount
	|-RBTree.TreePage<object>.set_InUseCount
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.set_InUseCount
	*/

	// RVA: -1 Offset: -1
	internal int get_PageId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	|-RBTree.TreePage<int>.get_PageId
	|-RBTree.TreePage<object>.get_PageId
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.get_PageId
	*/

	// RVA: -1 Offset: -1
	internal void set_PageId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	|-RBTree.TreePage<int>.set_PageId
	|-RBTree.TreePage<object>.set_PageId
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.set_PageId
	*/
}

// Namespace: 
internal struct RBTree.RBTreeEnumerator<K> : IEnumerator<K>, IDisposable, IEnumerator // TypeDefIndex: 12745
{
	// Fields
	private readonly RBTree<K> _tree; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private int _mainTreeNodeId; // 0x0
	private K _current; // 0x0

	// Properties
	public K Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB98000 Offset: 0xB97200 VA: 0x180B98000
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0xB98030 Offset: 0xB97230 VA: 0x180B98030
	|-RBTree.RBTreeEnumerator<object>..ctor
	|
	|-RVA: 0xB98110 Offset: 0xB97310 VA: 0x180B98110
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree, int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB98060 Offset: 0xB97260 VA: 0x180B98060
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0xB982E0 Offset: 0xB974E0 VA: 0x180B982E0
	|-RBTree.RBTreeEnumerator<object>..ctor
	|
	|-RVA: 0xB983A0 Offset: 0xB975A0 VA: 0x180B983A0
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-RBTree.RBTreeEnumerator<int>.Dispose
	|-RBTree.RBTreeEnumerator<object>.Dispose
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB97660 Offset: 0xB96860 VA: 0x180B97660
	|-RBTree.RBTreeEnumerator<int>.MoveNext
	|
	|-RVA: 0xB97430 Offset: 0xB96630 VA: 0x180B97430
	|-RBTree.RBTreeEnumerator<object>.MoveNext
	|
	|-RVA: 0xB97880 Offset: 0xB96A80 VA: 0x180B97880
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public K get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	|-RBTree.RBTreeEnumerator<int>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-RBTree.RBTreeEnumerator<object>.get_Current
	|
	|-RVA: 0xB986A0 Offset: 0xB978A0 VA: 0x180B986A0
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB97E70 Offset: 0xB97070 VA: 0x180B97E70
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB97FD0 Offset: 0xB971D0 VA: 0x180B97FD0
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB97ED0 Offset: 0xB970D0 VA: 0x180B97ED0
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB97DB0 Offset: 0xB96FB0 VA: 0x180B97DB0
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0xB97E10 Offset: 0xB97010 VA: 0x180B97E10
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0xB97BB0 Offset: 0xB96DB0 VA: 0x180B97BB0
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: System.Data
[DefaultMember("Item")]
internal abstract class RBTree<K> : IEnumerable // TypeDefIndex: 12746
{
	// Fields
	private RBTree.TreePage<K>[] _pageTable; // 0x0
	private int[] _pageTableMap; // 0x0
	private int _inUsePageCount; // 0x0
	private int _nextFreePageLine; // 0x0
	public int root; // 0x0
	private int _version; // 0x0
	private int _inUseNodeCount; // 0x0
	private int _inUseSatelliteTreeCount; // 0x0
	private readonly TreeAccessMethod _accessMethod; // 0x0

	// Properties
	public int Count { get; }
	public bool HasDuplicates { get; }
	public K Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract int CompareNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareNode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract int CompareSateliteTreeNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareSateliteTreeNode
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(TreeAccessMethod accessMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAE290 Offset: 0xBAD490 VA: 0x180BAE290
	|-RBTree<int>..ctor
	|
	|-RVA: 0xBAE330 Offset: 0xBAD530 VA: 0x180BAE330
	|-RBTree<object>..ctor
	|
	|-RVA: 0xBAE2E0 Offset: 0xBAD4E0 VA: 0x180BAE2E0
	|-RBTree<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitTree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9E690 Offset: 0xB9D890 VA: 0x180B9E690
	|-RBTree<int>.InitTree
	|
	|-RVA: 0xB9E7F0 Offset: 0xB9D9F0 VA: 0x180B9E7F0
	|-RBTree<object>.InitTree
	|
	|-RVA: 0xB9E4C0 Offset: 0xB9D6C0 VA: 0x180B9E4C0
	|-RBTree<__Il2CppFullySharedGenericType>.InitTree
	*/

	// RVA: -1 Offset: -1
	private void FreePage(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B9C0 Offset: 0xB9ABC0 VA: 0x180B9B9C0
	|-RBTree<int>.FreePage
	|-RBTree<object>.FreePage
	|
	|-RVA: 0xB9B930 Offset: 0xB9AB30 VA: 0x180B9B930
	|-RBTree<__Il2CppFullySharedGenericType>.FreePage
	*/

	// RVA: -1 Offset: -1
	private RBTree.TreePage<K> AllocPage(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB98C00 Offset: 0xB97E00 VA: 0x180B98C00
	|-RBTree<int>.AllocPage
	|
	|-RVA: 0xB989A0 Offset: 0xB97BA0 VA: 0x180B989A0
	|-RBTree<object>.AllocPage
	|
	|-RVA: 0xB98E60 Offset: 0xB98060 VA: 0x180B98E60
	|-RBTree<__Il2CppFullySharedGenericType>.AllocPage
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFull(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA0AD0 Offset: 0xB9FCD0 VA: 0x180BA0AD0
	|-RBTree<int>.MarkPageFull
	|-RBTree<object>.MarkPageFull
	|
	|-RVA: 0xBA0A10 Offset: 0xB9FC10 VA: 0x180BA0A10
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFull
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFree(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA08F0 Offset: 0xB9FAF0 VA: 0x180BA08F0
	|-RBTree<int>.MarkPageFree
	|-RBTree<object>.MarkPageFree
	|
	|-RVA: 0xBA0950 Offset: 0xB9FB50 VA: 0x180BA0950
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFree
	*/

	// RVA: -1 Offset: -1
	private static int GetIntValueFromBitMap(uint bitMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9CA70 Offset: 0xB9BC70 VA: 0x180B9CA70
	|-RBTree<int>.GetIntValueFromBitMap
	|-RBTree<object>.GetIntValueFromBitMap
	|-RBTree<__Il2CppFullySharedGenericType>.GetIntValueFromBitMap
	*/

	// RVA: -1 Offset: -1
	private void FreeNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B4D0 Offset: 0xB9A6D0 VA: 0x180B9B4D0
	|-RBTree<int>.FreeNode
	|
	|-RVA: 0xB9B630 Offset: 0xB9A830 VA: 0x180B9B630
	|-RBTree<object>.FreeNode
	|
	|-RVA: 0xB9B790 Offset: 0xB9A990 VA: 0x180B9B790
	|-RBTree<__Il2CppFullySharedGenericType>.FreeNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9C8D0 Offset: 0xB9BAD0 VA: 0x180B9C8D0
	|-RBTree<int>.GetIndexOfPageWithFreeSlot
	|-RBTree<object>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0xB9C720 Offset: 0xB9B920 VA: 0x180B9C720
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexOfPageWithFreeSlot
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAE4D0 Offset: 0xBAD6D0 VA: 0x180BAE4D0
	|-RBTree<int>.get_Count
	|-RBTree<object>.get_Count
	|-RBTree<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_HasDuplicates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAE4E0 Offset: 0xBAD6E0 VA: 0x180BAE4E0
	|-RBTree<int>.get_HasDuplicates
	|-RBTree<object>.get_HasDuplicates
	|-RBTree<__Il2CppFullySharedGenericType>.get_HasDuplicates
	*/

	// RVA: -1 Offset: -1
	private int GetNewNode(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9D0C0 Offset: 0xB9C2C0 VA: 0x180B9D0C0
	|-RBTree<int>.GetNewNode
	|
	|-RVA: 0xB9CEA0 Offset: 0xB9C0A0 VA: 0x180B9CEA0
	|-RBTree<object>.GetNewNode
	|
	|-RVA: 0xB9CAE0 Offset: 0xB9BCE0 VA: 0x180B9CAE0
	|-RBTree<__Il2CppFullySharedGenericType>.GetNewNode
	*/

	// RVA: -1 Offset: -1
	private int Successor(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBADCE0 Offset: 0xBACEE0 VA: 0x180BADCE0
	|-RBTree<int>.Successor
	|
	|-RVA: 0xBAD930 Offset: 0xBACB30 VA: 0x180BAD930
	|-RBTree<object>.Successor
	|
	|-RVA: 0xBAD810 Offset: 0xBACA10 VA: 0x180BAD810
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBADA60 Offset: 0xBACC60 VA: 0x180BADA60
	|-RBTree<int>.Successor
	|
	|-RVA: 0xBAD6C0 Offset: 0xBAC8C0 VA: 0x180BAD6C0
	|-RBTree<object>.Successor
	|
	|-RVA: 0xBADBB0 Offset: 0xBACDB0 VA: 0x180BADBB0
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private int Minimum(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA0C60 Offset: 0xB9FE60 VA: 0x180BA0C60
	|-RBTree<int>.Minimum
	|
	|-RVA: 0xBA0B30 Offset: 0xB9FD30 VA: 0x180BA0B30
	|-RBTree<object>.Minimum
	|
	|-RVA: 0xBA0BC0 Offset: 0xB9FDC0 VA: 0x180BA0BC0
	|-RBTree<__Il2CppFullySharedGenericType>.Minimum
	*/

	// RVA: -1 Offset: -1
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9F830 Offset: 0xB9EA30 VA: 0x180B9F830
	|-RBTree<int>.LeftRotate
	|
	|-RVA: 0xB9EFE0 Offset: 0xB9E1E0 VA: 0x180B9EFE0
	|-RBTree<object>.LeftRotate
	|
	|-RVA: 0xBA00B0 Offset: 0xB9F2B0 VA: 0x180BA00B0
	|-RBTree<__Il2CppFullySharedGenericType>.LeftRotate
	*/

	// RVA: -1 Offset: -1
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAAD40 Offset: 0xBA9F40 VA: 0x180BAAD40
	|-RBTree<int>.RightRotate
	|
	|-RVA: 0xBAB5C0 Offset: 0xBAA7C0 VA: 0x180BAB5C0
	|-RBTree<object>.RightRotate
	|
	|-RVA: 0xBABE10 Offset: 0xBAB010 VA: 0x180BABE10
	|-RBTree<__Il2CppFullySharedGenericType>.RightRotate
	*/

	// RVA: -1 Offset: -1
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA6660 Offset: 0xBA5860 VA: 0x180BA6660
	|-RBTree<int>.RBInsert
	|
	|-RVA: 0xBA9210 Offset: 0xBA8410 VA: 0x180BA9210
	|-RBTree<object>.RBInsert
	|
	|-RVA: 0xBA7A20 Offset: 0xBA6C20 VA: 0x180BA7A20
	|-RBTree<__Il2CppFullySharedGenericType>.RBInsert
	*/

	// RVA: -1 Offset: -1
	public void UpdateNodeKey(K currentKey, K newKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAE180 Offset: 0xBAD380 VA: 0x180BAE180
	|-RBTree<int>.UpdateNodeKey
	|
	|-RVA: 0xBADE10 Offset: 0xBAD010 VA: 0x180BADE10
	|-RBTree<object>.UpdateNodeKey
	|
	|-RVA: 0xBADF30 Offset: 0xBAD130 VA: 0x180BADF30
	|-RBTree<__Il2CppFullySharedGenericType>.UpdateNodeKey
	*/

	// RVA: -1 Offset: -1
	public K DeleteByIndex(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B220 Offset: 0xB9A420 VA: 0x180B9B220
	|-RBTree<int>.DeleteByIndex
	|
	|-RVA: 0xB9B410 Offset: 0xB9A610 VA: 0x180B9B410
	|-RBTree<object>.DeleteByIndex
	|
	|-RVA: 0xB9B2E0 Offset: 0xB9A4E0 VA: 0x180B9B2E0
	|-RBTree<__Il2CppFullySharedGenericType>.DeleteByIndex
	*/

	// RVA: -1 Offset: -1
	public int RBDelete(int z_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA6630 Offset: 0xBA5830 VA: 0x180BA6630
	|-RBTree<int>.RBDelete
	|
	|-RVA: 0xBA6600 Offset: 0xBA5800 VA: 0x180BA6600
	|-RBTree<object>.RBDelete
	|
	|-RVA: 0xBA65D0 Offset: 0xBA57D0 VA: 0x180BA65D0
	|-RBTree<__Il2CppFullySharedGenericType>.RBDelete
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA40C0 Offset: 0xBA32C0 VA: 0x180BA40C0
	|-RBTree<int>.RBDeleteX
	|
	|-RVA: 0xBA2D80 Offset: 0xBA1F80 VA: 0x180BA2D80
	|-RBTree<object>.RBDeleteX
	|
	|-RVA: 0xBA5410 Offset: 0xBA4610 VA: 0x180BA5410
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteX
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA0F80 Offset: 0xBA0180 VA: 0x180BA0F80
	|-RBTree<int>.RBDeleteFixup
	|
	|-RVA: 0xBA2470 Offset: 0xBA1670 VA: 0x180BA2470
	|-RBTree<object>.RBDeleteFixup
	|
	|-RVA: 0xBA1890 Offset: 0xBA0A90 VA: 0x180BA1890
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteFixup
	*/

	// RVA: -1 Offset: -1
	private int SearchSubTree(int root_id, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAC8F0 Offset: 0xBABAF0 VA: 0x180BAC8F0
	|-RBTree<int>.SearchSubTree
	|
	|-RVA: 0xBACA00 Offset: 0xBABC00 VA: 0x180BACA00
	|-RBTree<object>.SearchSubTree
	|
	|-RVA: 0xBAC650 Offset: 0xBAB850 VA: 0x180BAC650
	|-RBTree<__Il2CppFullySharedGenericType>.SearchSubTree
	*/

	// RVA: -1 Offset: -1
	public K get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAE560 Offset: 0xBAD760 VA: 0x180BAE560
	|-RBTree<int>.get_Item
	|
	|-RVA: 0xBAE4F0 Offset: 0xBAD6F0 VA: 0x180BAE4F0
	|-RBTree<object>.get_Item
	|
	|-RVA: 0xBAE5D0 Offset: 0xBAD7D0 VA: 0x180BAE5D0
	|-RBTree<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9DB70 Offset: 0xB9CD70 VA: 0x180B9DB70
	|-RBTree<int>.GetNodeByKey
	|
	|-RVA: 0xB9D960 Offset: 0xB9CB60 VA: 0x180B9D960
	|-RBTree<object>.GetNodeByKey
	|
	|-RVA: 0xB9D580 Offset: 0xB9C780 VA: 0x180B9D580
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9BCF0 Offset: 0xB9AEF0 VA: 0x180B9BCF0
	|-RBTree<int>.GetIndexByKey
	|
	|-RVA: 0xB9BBD0 Offset: 0xB9ADD0 VA: 0x180B9BBD0
	|-RBTree<object>.GetIndexByKey
	|
	|-RVA: 0xB9BE10 Offset: 0xB9B010 VA: 0x180B9BE10
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByNode(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9C540 Offset: 0xB9B740 VA: 0x180B9C540
	|-RBTree<int>.GetIndexByNode
	|
	|-RVA: 0xB9C180 Offset: 0xB9B380 VA: 0x180B9C180
	|-RBTree<object>.GetIndexByNode
	|
	|-RVA: 0xB9C360 Offset: 0xB9B560 VA: 0x180B9C360
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexByNodePath(RBTree.NodePath<K> path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9C0C0 Offset: 0xB9B2C0 VA: 0x180B9C0C0
	|-RBTree<int>.GetIndexByNodePath
	|
	|-RVA: 0xB9BF30 Offset: 0xB9B130 VA: 0x180B9BF30
	|-RBTree<object>.GetIndexByNodePath
	|
	|-RVA: 0xB9BFF0 Offset: 0xB9B1F0 VA: 0x180B9BFF0
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNodePath
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB99450 Offset: 0xB98650 VA: 0x180B99450
	|-RBTree<int>.ComputeIndexByNode
	|
	|-RVA: 0xB992A0 Offset: 0xB984A0 VA: 0x180B992A0
	|-RBTree<object>.ComputeIndexByNode
	|
	|-RVA: 0xB99160 Offset: 0xB98360 VA: 0x180B99160
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB99840 Offset: 0xB98A40 VA: 0x180B99840
	|-RBTree<int>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0xB99610 Offset: 0xB98810 VA: 0x180B99610
	|-RBTree<object>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0xB99A70 Offset: 0xB98C70 VA: 0x180B99A70
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexWithSatelliteByNode
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByIndex(int userIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9D2E0 Offset: 0xB9C4E0 VA: 0x180B9D2E0
	|-RBTree<int>.GetNodeByIndex
	|
	|-RVA: 0xB9D4A0 Offset: 0xB9C6A0 VA: 0x180B9D4A0
	|-RBTree<object>.GetNodeByIndex
	|
	|-RVA: 0xB9D3C0 Offset: 0xB9C5C0 VA: 0x180B9D3C0
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9A300 Offset: 0xB99500 VA: 0x180B9A300
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0xB9A090 Offset: 0xB99290 VA: 0x180B9A090
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0xB99E40 Offset: 0xB99040 VA: 0x180B99E40
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int x_id, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB99D30 Offset: 0xB98F30 VA: 0x180B99D30
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0xB99C20 Offset: 0xB98E20 VA: 0x180B99C20
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0xB9A570 Offset: 0xB99770 VA: 0x180B9A570
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	public int Insert(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB98780 Offset: 0xB97980 VA: 0x180B98780
	|-RBTree<int>.Insert
	|
	|-RVA: 0xB98920 Offset: 0xB97B20 VA: 0x180B98920
	|-RBTree<object>.Insert
	|
	|-RVA: 0xB98800 Offset: 0xB97A00 VA: 0x180B98800
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int Add(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB98780 Offset: 0xB97980 VA: 0x180B98780
	|-RBTree<int>.Add
	|
	|-RVA: 0xB98920 Offset: 0xB97B20 VA: 0x180B98920
	|-RBTree<object>.Add
	|
	|-RVA: 0xB98800 Offset: 0xB97A00 VA: 0x180B98800
	|-RBTree<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9BAB0 Offset: 0xB9ACB0 VA: 0x180B9BAB0
	|-RBTree<int>.GetEnumerator
	|
	|-RVA: 0xB9BA40 Offset: 0xB9AC40 VA: 0x180B9BA40
	|-RBTree<object>.GetEnumerator
	|
	|-RVA: 0xB9BB20 Offset: 0xB9AD20 VA: 0x180B9BB20
	|-RBTree<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(int nodeId, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9DF10 Offset: 0xB9D110 VA: 0x180B9DF10
	|-RBTree<int>.IndexOf
	|
	|-RVA: 0xB9E390 Offset: 0xB9D590 VA: 0x180B9E390
	|-RBTree<object>.IndexOf
	|
	|-RVA: 0xB9E090 Offset: 0xB9D290 VA: 0x180B9E090
	|-RBTree<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int Insert(int position, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9EBC0 Offset: 0xB9DDC0 VA: 0x180B9EBC0
	|-RBTree<int>.Insert
	|
	|-RVA: 0xB9EC60 Offset: 0xB9DE60 VA: 0x180B9EC60
	|-RBTree<object>.Insert
	|
	|-RVA: 0xB9ED00 Offset: 0xB9DF00 VA: 0x180B9ED00
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int InsertAt(int position, K item, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9EB20 Offset: 0xB9DD20 VA: 0x180B9EB20
	|-RBTree<int>.InsertAt
	|
	|-RVA: 0xB9EA80 Offset: 0xB9DC80 VA: 0x180B9EA80
	|-RBTree<object>.InsertAt
	|
	|-RVA: 0xB9E950 Offset: 0xB9DB50 VA: 0x180B9E950
	|-RBTree<__Il2CppFullySharedGenericType>.InsertAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAAB20 Offset: 0xBA9D20 VA: 0x180BAAB20
	|-RBTree<int>.RemoveAt
	|
	|-RVA: 0xBAAC90 Offset: 0xBA9E90 VA: 0x180BAAC90
	|-RBTree<object>.RemoveAt
	|
	|-RVA: 0xBAABD0 Offset: 0xBA9DD0 VA: 0x180BAABD0
	|-RBTree<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB99130 Offset: 0xB98330 VA: 0x180B99130
	|-RBTree<int>.Clear
	|
	|-RVA: 0xB990D0 Offset: 0xB982D0 VA: 0x180B990D0
	|-RBTree<object>.Clear
	|
	|-RVA: 0xB99100 Offset: 0xB98300 VA: 0x180B99100
	|-RBTree<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9AB70 Offset: 0xB99D70 VA: 0x180B9AB70
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0xB9A650 Offset: 0xB99850 VA: 0x180B9A650
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0xB9A960 Offset: 0xB99B60 VA: 0x180B9A960
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(K[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9AF60 Offset: 0xB9A160 VA: 0x180B9AF60
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0xB9A7D0 Offset: 0xB999D0 VA: 0x180B9A7D0
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0xB9AD20 Offset: 0xB99F20 VA: 0x180B9AD20
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void SetRight(int nodeId, int rightNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAD3A0 Offset: 0xBAC5A0 VA: 0x180BAD3A0
	|-RBTree<int>.SetRight
	|
	|-RVA: 0xBAD2A0 Offset: 0xBAC4A0 VA: 0x180BAD2A0
	|-RBTree<object>.SetRight
	|
	|-RVA: 0xBAD2F0 Offset: 0xBAC4F0 VA: 0x180BAD2F0
	|-RBTree<__Il2CppFullySharedGenericType>.SetRight
	*/

	// RVA: -1 Offset: -1
	private void SetLeft(int nodeId, int leftNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBACF70 Offset: 0xBAC170 VA: 0x180BACF70
	|-RBTree<int>.SetLeft
	|
	|-RVA: 0xBACF20 Offset: 0xBAC120 VA: 0x180BACF20
	|-RBTree<object>.SetLeft
	|
	|-RVA: 0xBACE70 Offset: 0xBAC070 VA: 0x180BACE70
	|-RBTree<__Il2CppFullySharedGenericType>.SetLeft
	*/

	// RVA: -1 Offset: -1
	private void SetParent(int nodeId, int parentNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAD140 Offset: 0xBAC340 VA: 0x180BAD140
	|-RBTree<int>.SetParent
	|
	|-RVA: 0xBAD1A0 Offset: 0xBAC3A0 VA: 0x180BAD1A0
	|-RBTree<object>.SetParent
	|
	|-RVA: 0xBAD1F0 Offset: 0xBAC3F0 VA: 0x180BAD1F0
	|-RBTree<__Il2CppFullySharedGenericType>.SetParent
	*/

	// RVA: -1 Offset: -1
	private void SetColor(int nodeId, RBTree.NodeColor<K> color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBACBD0 Offset: 0xBABDD0 VA: 0x180BACBD0
	|-RBTree<int>.SetColor
	|
	|-RVA: 0xBACC30 Offset: 0xBABE30 VA: 0x180BACC30
	|-RBTree<object>.SetColor
	|
	|-RVA: 0xBACB10 Offset: 0xBABD10 VA: 0x180BACB10
	|-RBTree<__Il2CppFullySharedGenericType>.SetColor
	*/

	// RVA: -1 Offset: -1
	private void SetKey(int nodeId, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBACC80 Offset: 0xBABE80 VA: 0x180BACC80
	|-RBTree<int>.SetKey
	|
	|-RVA: 0xBACE10 Offset: 0xBAC010 VA: 0x180BACE10
	|-RBTree<object>.SetKey
	|
	|-RVA: 0xBACCE0 Offset: 0xBABEE0 VA: 0x180BACCE0
	|-RBTree<__Il2CppFullySharedGenericType>.SetKey
	*/

	// RVA: -1 Offset: -1
	private void SetNext(int nodeId, int nextNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBACFD0 Offset: 0xBAC1D0 VA: 0x180BACFD0
	|-RBTree<int>.SetNext
	|
	|-RVA: 0xBAD030 Offset: 0xBAC230 VA: 0x180BAD030
	|-RBTree<object>.SetNext
	|
	|-RVA: 0xBAD080 Offset: 0xBAC280 VA: 0x180BAD080
	|-RBTree<__Il2CppFullySharedGenericType>.SetNext
	*/

	// RVA: -1 Offset: -1
	private void SetSubTreeSize(int nodeId, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAD510 Offset: 0xBAC710 VA: 0x180BAD510
	|-RBTree<int>.SetSubTreeSize
	|
	|-RVA: 0xBAD400 Offset: 0xBAC600 VA: 0x180BAD400
	|-RBTree<object>.SetSubTreeSize
	|
	|-RVA: 0xBAD450 Offset: 0xBAC650 VA: 0x180BAD450
	|-RBTree<__Il2CppFullySharedGenericType>.SetSubTreeSize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9DE60 Offset: 0xB9D060 VA: 0x180B9DE60
	|-RBTree<int>.IncreaseSize
	|
	|-RVA: 0xB9DEC0 Offset: 0xB9D0C0 VA: 0x180B9DEC0
	|-RBTree<object>.IncreaseSize
	|
	|-RVA: 0xB9DDD0 Offset: 0xB9CFD0 VA: 0x180B9DDD0
	|-RBTree<__Il2CppFullySharedGenericType>.IncreaseSize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAA960 Offset: 0xBA9B60 VA: 0x180BAA960
	|-RBTree<int>.RecomputeSize
	|
	|-RVA: 0xBAA5E0 Offset: 0xBA97E0 VA: 0x180BAA5E0
	|-RBTree<object>.RecomputeSize
	|
	|-RVA: 0xBAA7A0 Offset: 0xBA99A0 VA: 0x180BAA7A0
	|-RBTree<__Il2CppFullySharedGenericType>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void DecreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B0E0 Offset: 0xB9A2E0 VA: 0x180B9B0E0
	|-RBTree<int>.DecreaseSize
	|
	|-RVA: 0xB9B140 Offset: 0xB9A340 VA: 0x180B9B140
	|-RBTree<object>.DecreaseSize
	|
	|-RVA: 0xB9B190 Offset: 0xB9A390 VA: 0x180B9B190
	|-RBTree<__Il2CppFullySharedGenericType>.DecreaseSize
	*/

	// RVA: -1 Offset: -1
	public int Right(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAC510 Offset: 0xBAB710 VA: 0x180BAC510
	|-RBTree<int>.Right
	|
	|-RVA: 0xBAC5F0 Offset: 0xBAB7F0 VA: 0x180BAC5F0
	|-RBTree<object>.Right
	|
	|-RVA: 0xBAC570 Offset: 0xBAB770 VA: 0x180BAC570
	|-RBTree<__Il2CppFullySharedGenericType>.Right
	*/

	// RVA: -1 Offset: -1
	public int Left(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA0830 Offset: 0xB9FA30 VA: 0x180BA0830
	|-RBTree<int>.Left
	|
	|-RVA: 0xBA0890 Offset: 0xB9FA90 VA: 0x180BA0890
	|-RBTree<object>.Left
	|
	|-RVA: 0xBA07B0 Offset: 0xB9F9B0 VA: 0x180BA07B0
	|-RBTree<__Il2CppFullySharedGenericType>.Left
	*/

	// RVA: -1 Offset: -1
	public int Parent(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA0EC0 Offset: 0xBA00C0 VA: 0x180BA0EC0
	|-RBTree<int>.Parent
	|
	|-RVA: 0xBA0F20 Offset: 0xBA0120 VA: 0x180BA0F20
	|-RBTree<object>.Parent
	|
	|-RVA: 0xBA0E40 Offset: 0xBA0040 VA: 0x180BA0E40
	|-RBTree<__Il2CppFullySharedGenericType>.Parent
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodeColor<K> color(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAE410 Offset: 0xBAD610 VA: 0x180BAE410
	|-RBTree<int>.color
	|
	|-RVA: 0xBAE470 Offset: 0xBAD670 VA: 0x180BAE470
	|-RBTree<object>.color
	|
	|-RVA: 0xBAE380 Offset: 0xBAD580 VA: 0x180BAE380
	|-RBTree<__Il2CppFullySharedGenericType>.color
	*/

	// RVA: -1 Offset: -1
	public int Next(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA0D50 Offset: 0xB9FF50 VA: 0x180BA0D50
	|-RBTree<int>.Next
	|
	|-RVA: 0xBA0CF0 Offset: 0xB9FEF0 VA: 0x180BA0CF0
	|-RBTree<object>.Next
	|
	|-RVA: 0xBA0DB0 Offset: 0xB9FFB0 VA: 0x180BA0DB0
	|-RBTree<__Il2CppFullySharedGenericType>.Next
	*/

	// RVA: -1 Offset: -1
	public int SubTreeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAD570 Offset: 0xBAC770 VA: 0x180BAD570
	|-RBTree<int>.SubTreeSize
	|
	|-RVA: 0xBAD5D0 Offset: 0xBAC7D0 VA: 0x180BAD5D0
	|-RBTree<object>.SubTreeSize
	|
	|-RVA: 0xBAD630 Offset: 0xBAC830 VA: 0x180BAD630
	|-RBTree<__Il2CppFullySharedGenericType>.SubTreeSize
	*/

	// RVA: -1 Offset: -1
	public K Key(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9EF80 Offset: 0xB9E180 VA: 0x180B9EF80
	|-RBTree<int>.Key
	|
	|-RVA: 0xB9EF20 Offset: 0xB9E120 VA: 0x180B9EF20
	|-RBTree<object>.Key
	|
	|-RVA: 0xB9EE10 Offset: 0xB9E010 VA: 0x180B9EE10
	|-RBTree<__Il2CppFullySharedGenericType>.Key
	*/
}

// Namespace: System.Data
[DefaultMember("Item")]
internal sealed class RecordManager // TypeDefIndex: 12747
{
	// Fields
	private readonly DataTable _table; // 0x10
	private int _lastFreeRecord; // 0x18
	private int _minimumCapacity; // 0x1C
	private int _recordCapacity; // 0x20
	private readonly List<int> _freeRecordList; // 0x28
	private DataRow[] _rows; // 0x30

	// Properties
	internal int LastFreeRecord { get; }
	internal int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; set; }
	internal DataRow Item { get; set; }

	// Methods

	// RVA: 0x1E14DE0 Offset: 0x1E13FE0 VA: 0x181E14DE0
	internal void .ctor(DataTable table) { }

	// RVA: 0x1E14A70 Offset: 0x1E13C70 VA: 0x181E14A70
	private void GrowRecordCapacity() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	internal int get_LastFreeRecord() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	internal int get_MinimumCapacity() { }

	// RVA: 0x1E14F40 Offset: 0x1E14140 VA: 0x181E14F40
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal int get_RecordCapacity() { }

	// RVA: 0x1E14F80 Offset: 0x1E14180 VA: 0x181E14F80
	internal void set_RecordCapacity(int value) { }

	// RVA: 0x1E14C90 Offset: 0x1E13E90 VA: 0x181E14C90
	internal static int NewCapacity(int capacity) { }

	// RVA: 0x1E14D70 Offset: 0x1E13F70 VA: 0x181E14D70
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0x1E14CA0 Offset: 0x1E13EA0 VA: 0x181E14CA0
	internal int NewRecordBase() { }

	// RVA: 0x1E14910 Offset: 0x1E13B10 VA: 0x181E14910
	internal void FreeRecord(ref int record) { }

	// RVA: 0x1E14420 Offset: 0x1E13620 VA: 0x181E14420
	internal void Clear(bool clearAll) { }

	// RVA: 0x1E14EA0 Offset: 0x1E140A0 VA: 0x181E14EA0
	internal DataRow get_Item(int record) { }

	// RVA: 0x1E14ED0 Offset: 0x1E140D0 VA: 0x181E14ED0
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0x1E14C70 Offset: 0x1E13E70 VA: 0x181E14C70
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0x1E14620 Offset: 0x1E13820 VA: 0x181E14620
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0x1E14DB0 Offset: 0x1E13FB0 VA: 0x181E14DB0
	internal void SetRowCache(DataRow[] newRows) { }
}

// Namespace: System.Data
internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 12748
{
	// Fields
	private readonly Nullable<DataKey> _parentKey; // 0xD0
	private readonly DataKey _childKey; // 0xE0
	private readonly DataRowView _parentRowView; // 0xE8
	private readonly object[] _filterValues; // 0xF0

	// Methods

	// RVA: 0x1E152F0 Offset: 0x1E144F0 VA: 0x181E152F0
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0x1E15430 Offset: 0x1E14630 VA: 0x181E15430
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0x1E150A0 Offset: 0x1E142A0 VA: 0x181E150A0
	private object[] GetParentValues() { }

	// RVA: 0x1E15150 Offset: 0x1E14350 VA: 0x181E15150 Slot: 72
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 66
	internal override IFilter GetFilter() { }

	// RVA: 0x1E15030 Offset: 0x1E14230 VA: 0x181E15030 Slot: 65
	public override DataRowView AddNew() { }

	// RVA: 0x1E152C0 Offset: 0x1E144C0 VA: 0x181E152C0 Slot: 69
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }
}

// Namespace: System.Data
internal sealed class RelationshipConverter : ExpandableObjectConverter // TypeDefIndex: 12749
{
	// Methods

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }

	// RVA: 0x1E15550 Offset: 0x1E14750 VA: 0x181E15550 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1E15600 Offset: 0x1E14800 VA: 0x181E15600 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
public enum Rule // TypeDefIndex: 12750
{
	// Fields
	public int value__; // 0x0
	public const Rule None = 0;
	public const Rule Cascade = 1;
	public const Rule SetNull = 2;
	public const Rule SetDefault = 3;
}

// Namespace: System.Data
public enum SchemaSerializationMode // TypeDefIndex: 12751
{
	// Fields
	public int value__; // 0x0
	public const SchemaSerializationMode IncludeSchema = 1;
	public const SchemaSerializationMode ExcludeSchema = 2;
}

// Namespace: System.Data
[IsReadOnly]
internal struct IndexField // TypeDefIndex: 12752
{
	// Fields
	public readonly DataColumn Column; // 0x0
	public readonly bool IsDescending; // 0x8

	// Methods

	// RVA: 0xD3BB10 Offset: 0xD3AD10 VA: 0x180D3BB10
	internal void .ctor(DataColumn column, bool isDescending) { }

	// RVA: 0x1E0BEA0 Offset: 0x1E0B0A0 VA: 0x181E0BEA0
	public static bool op_Equality(IndexField if1, IndexField if2) { }

	// RVA: 0x1E0BD70 Offset: 0x1E0AF70 VA: 0x181E0BD70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E0BE20 Offset: 0x1E0B020 VA: 0x181E0BE20 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private sealed class Index.IndexTree : RBTree<int> // TypeDefIndex: 12753
{
	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0x1E0BF00 Offset: 0x1E0B100 VA: 0x181E0BF00
	internal void .ctor(Index index) { }

	// RVA: 0x1E0BEC0 Offset: 0x1E0B0C0 VA: 0x181E0BEC0 Slot: 5
	protected override int CompareNode(int record1, int record2) { }

	// RVA: 0x1E0BEE0 Offset: 0x1E0B0E0 VA: 0x181E0BEE0 Slot: 6
	protected override int CompareSateliteTreeNode(int record1, int record2) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Index.<>c // TypeDefIndex: 12754
{
	// Fields
	public static readonly Index.<>c <>9; // 0x0
	public static Listeners.Func<DataViewListener, DataViewListener, bool> <>9__22_0; // 0x8
	public static Listeners.Action<DataViewListener, DataViewListener, ListChangedEventArgs, bool, bool> <>9__85_0; // 0x10

	// Methods

	// RVA: 0x1E17B40 Offset: 0x1E16D40 VA: 0x181E17B40
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0xB09CD0 Offset: 0xB08ED0 VA: 0x180B09CD0
	internal bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0x1E17AD0 Offset: 0x1E16CD0 VA: 0x181E17AD0
	internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Index.<>c__DisplayClass86_0 // TypeDefIndex: 12755
{
	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1E17B00 Offset: 0x1E16D00 VA: 0x181E17B00
	internal void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }
}

// Namespace: System.Data
internal sealed class Index // TypeDefIndex: 12756
{
	// Fields
	private readonly DataTable _table; // 0x10
	internal readonly IndexField[] _indexFields; // 0x18
	private readonly Comparison<DataRow> _comparison; // 0x20
	private readonly DataViewRowState _recordStates; // 0x28
	private WeakReference _rowFilter; // 0x30
	private Index.IndexTree _records; // 0x38
	private int _recordCount; // 0x40
	private int _refCount; // 0x44
	private Listeners<DataViewListener> _listeners; // 0x48
	private bool _suspendEvents; // 0x50
	private readonly bool _isSharable; // 0x51
	private readonly bool _hasRemoteAggregate; // 0x52
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x54

	// Properties
	internal bool HasRemoteAggregate { get; }
	internal int ObjectID { get; }
	public DataViewRowState RecordStates { get; }
	public IFilter RowFilter { get; }
	public bool HasDuplicates { get; }
	public int RecordCount { get; }
	public int RefCount { get; }
	private bool DoListChanged { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x1E0F920 Offset: 0x1E0EB20 VA: 0x181E0F920
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1E0F510 Offset: 0x1E0E710 VA: 0x181E0F510
	public void .ctor(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1E0D300 Offset: 0x1E0C500 VA: 0x181E0D300
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0x1E0F640 Offset: 0x1E0E840 VA: 0x181E0F640
	private void .ctor(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1E0CA80 Offset: 0x1E0BC80 VA: 0x181E0CA80
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1E0FA10 Offset: 0x1E0EC10 VA: 0x181E0FA10
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	internal int get_ObjectID() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public DataViewRowState get_RecordStates() { }

	// RVA: 0x1E0FA20 Offset: 0x1E0EC20 VA: 0x181E0FA20
	public IFilter get_RowFilter() { }

	// RVA: 0x1E0D7F0 Offset: 0x1E0C9F0 VA: 0x181E0D7F0
	public int GetRecord(int recordIndex) { }

	// RVA: 0x1E0F9C0 Offset: 0x1E0EBC0 VA: 0x181E0F9C0
	public bool get_HasDuplicates() { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public int get_RecordCount() { }

	// RVA: 0x1E0C0A0 Offset: 0x1E0B2A0 VA: 0x181E0C0A0
	private bool AcceptRecord(int record) { }

	// RVA: 0x1E0BF50 Offset: 0x1E0B150 VA: 0x181E0BF50
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0x1E0E530 Offset: 0x1E0D730 VA: 0x181E0E530
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0x1E0E590 Offset: 0x1E0D790 VA: 0x181E0E590
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public int get_RefCount() { }

	// RVA: 0x1E0C0D0 Offset: 0x1E0B2D0 VA: 0x181E0C0D0
	public void AddRef() { }

	// RVA: 0x1E0F180 Offset: 0x1E0E380 VA: 0x181E0F180
	public int RemoveRef() { }

	// RVA: 0x1E0C2C0 Offset: 0x1E0B4C0 VA: 0x181E0C2C0
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0x1E0C390 Offset: 0x1E0B590 VA: 0x181E0C390
	public bool CheckUnique() { }

	// RVA: 0x1E0C740 Offset: 0x1E0B940 VA: 0x181E0C740
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0x1E0C3E0 Offset: 0x1E0B5E0 VA: 0x181E0C3E0
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0x1E0C460 Offset: 0x1E0B660 VA: 0x181E0C460
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0x1E0C650 Offset: 0x1E0B850 VA: 0x181E0C650
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0x1E0C940 Offset: 0x1E0BB40 VA: 0x181E0C940
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0x1E0CA70 Offset: 0x1E0BC70 VA: 0x181E0CA70
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0x1E0C950 Offset: 0x1E0BB50 VA: 0x181E0C950
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0x1E0D400 Offset: 0x1E0C600 VA: 0x181E0D400
	public RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex) { }

	// RVA: 0x1E0D470 Offset: 0x1E0C670 VA: 0x181E0D470
	public int GetIndex(int record) { }

	// RVA: 0x1E0D4D0 Offset: 0x1E0C6D0 VA: 0x181E0D4D0
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0x1E0DB10 Offset: 0x1E0CD10 VA: 0x181E0DB10
	public object[] GetUniqueKeyValues() { }

	// RVA: 0x1E0CC30 Offset: 0x1E0BE30 VA: 0x181E0CC30
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0x1E0CE30 Offset: 0x1E0C030 VA: 0x181E0CE30
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0x1E0CB50 Offset: 0x1E0BD50 VA: 0x181E0CB50
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0x1E0D670 Offset: 0x1E0C870 VA: 0x181E0D670
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0x1E0D180 Offset: 0x1E0C380 VA: 0x181E0D180
	public Range FindRecords(object key) { }

	// RVA: 0x1E0D130 Offset: 0x1E0C330 VA: 0x181E0D130
	public Range FindRecords(object[] key) { }

	// RVA: 0x1E0D1D0 Offset: 0x1E0C3D0 VA: 0x181E0D1D0
	internal void FireResetEvent() { }

	// RVA: 0x1E0D3E0 Offset: 0x1E0C5E0 VA: 0x181E0D3E0
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x1E0D850 Offset: 0x1E0CA50 VA: 0x181E0D850
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0x1E0D870 Offset: 0x1E0CA70 VA: 0x181E0D870
	public DataRow GetRow(int i) { }

	// RVA: 0x1E0DAC0 Offset: 0x1E0CCC0 VA: 0x181E0DAC0
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0x1E0D900 Offset: 0x1E0CB00 VA: 0x181E0D900
	public DataRow[] GetRows(Range range) { }

	// RVA: 0x1E0DE10 Offset: 0x1E0D010 VA: 0x181E0DE10
	private void InitRecords(IFilter filter) { }

	// RVA: 0x1E0E170 Offset: 0x1E0D370 VA: 0x181E0E170
	public int InsertRecordToIndex(int record) { }

	// RVA: 0x1E0E1D0 Offset: 0x1E0D3D0 VA: 0x181E0E1D0
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0x1E0E410 Offset: 0x1E0D610 VA: 0x181E0E410
	public bool IsKeyInIndex(object key) { }

	// RVA: 0x1E0E430 Offset: 0x1E0D630 VA: 0x181E0E430
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0x1E0E450 Offset: 0x1E0D650 VA: 0x181E0E450
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0x1E0F950 Offset: 0x1E0EB50 VA: 0x181E0F950
	private bool get_DoListChanged() { }

	// RVA: 0x1E0E7F0 Offset: 0x1E0D9F0 VA: 0x181E0E7F0
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0x1E0E720 Offset: 0x1E0D920 VA: 0x181E0E720
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0x1E0E8E0 Offset: 0x1E0DAE0 VA: 0x181E0E8E0
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1E0E5F0 Offset: 0x1E0D7F0 VA: 0x181E0E5F0
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0x1E0F330 Offset: 0x1E0E530 VA: 0x181E0F330
	public void Reset() { }

	// RVA: 0x1E0EBB0 Offset: 0x1E0DDB0 VA: 0x181E0EBB0
	public void RecordChanged(int record) { }

	// RVA: 0x1E0EA70 Offset: 0x1E0DC70 VA: 0x181E0EA70
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0x1E0F070 Offset: 0x1E0E270 VA: 0x181E0F070
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x1E0ECF0 Offset: 0x1E0DEF0 VA: 0x181E0ECF0
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal DataTable get_Table() { }

	// RVA: 0x1E0DBE0 Offset: 0x1E0CDE0 VA: 0x181E0DBE0
	private void GetUniqueKeyValues(List<object[]> list, int curNodeId) { }

	// RVA: -1 Offset: -1
	internal static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA24200 Offset: 0xA23400 VA: 0x180A24200
	|-Index.IndexOfReference<object>
	*/
}

// Namespace: 
internal sealed class Listeners.Action<TElem, T1, T2, T3, T4> : MulticastDelegate // TypeDefIndex: 12757
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BBE70 Offset: 0x11BB070 VA: 0x1811BBE70
	|-Listeners.Action<object, object, Int32Enum, object, bool>..ctor
	|
	|-RVA: 0x11BBCB0 Offset: 0x11BAEB0 VA: 0x1811BBCB0
	|-Listeners.Action<object, object, object, bool, bool>..ctor
	|
	|-RVA: 0x11BBB00 Offset: 0x11BAD00 VA: 0x1811BBB00
	|-Listeners.Action<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x464E30 Offset: 0x464030 VA: 0x180464E30
	|-Listeners.Action<object, object, Int32Enum, object, bool>.Invoke
	|-Listeners.Action<object, object, object, bool, bool>.Invoke
	|
	|-RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0
	|-Listeners.Action<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
internal sealed class Listeners.Func<TElem, T1, TResult> : MulticastDelegate // TypeDefIndex: 12758
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB86840 Offset: 0xB85A40 VA: 0x180B86840
	|-Listeners.Func<object, object, bool>..ctor
	|
	|-RVA: 0xFBAF40 Offset: 0xFBA140 VA: 0x180FBAF40
	|-Listeners.Func<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-Listeners.Func<object, object, bool>.Invoke
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-Listeners.Func<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System.Data
internal sealed class Listeners<TElem> // TypeDefIndex: 12759
{
	// Fields
	private readonly List<TElem> _listeners; // 0x0
	private readonly Listeners.Func<TElem, TElem, bool> _filter; // 0x0
	private readonly int _objectID; // 0x0
	private int _listenerReaderCount; // 0x0

	// Properties
	internal bool HasListeners { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int ObjectID, Listeners.Func<TElem, TElem, bool> notifyFilter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1459FF0 Offset: 0x14591F0 VA: 0x181459FF0
	|-Listeners<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool get_HasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1210 Offset: 0xBF0410 VA: 0x180BF1210
	|-Listeners<object>.get_HasListeners
	*/

	// RVA: -1 Offset: -1
	internal void Add(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1459E10 Offset: 0x1459010 VA: 0x181459E10
	|-Listeners<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal int IndexOfReference(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1459E90 Offset: 0x1459090 VA: 0x181459E90
	|-Listeners<object>.IndexOfReference
	*/

	// RVA: -1 Offset: -1
	internal void Remove(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1459F30 Offset: 0x1459130 VA: 0x181459F30
	|-Listeners<object>.Remove
	*/

	// RVA: -1 Offset: -1
	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners.Action<TElem, TElem, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8ECF50 Offset: 0x8EC150 VA: 0x1808ECF50
	|-Listeners<object>.Notify<Int32Enum, object, bool>
	|
	|-RVA: 0x8ED140 Offset: 0x8EC340 VA: 0x1808ED140
	|-Listeners<object>.Notify<object, bool, bool>
	|
	|-RVA: 0x8ECC00 Offset: 0x8EBE00 VA: 0x1808ECC00
	|-Listeners<object>.Notify<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void RemoveNullListeners(int nullIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1459EB0 Offset: 0x14590B0 VA: 0x181459EB0
	|-Listeners<object>.RemoveNullListeners
	*/
}

// Namespace: System.Data
[Serializable]
internal sealed class SimpleType : ISerializable // TypeDefIndex: 12760
{
	// Fields
	private string _baseType; // 0x10
	private SimpleType _baseSimpleType; // 0x18
	private XmlQualifiedName _xmlBaseType; // 0x20
	private string _name; // 0x28
	private int _length; // 0x30
	private int _minLength; // 0x34
	private int _maxLength; // 0x38
	private string _pattern; // 0x40
	private string _ns; // 0x48
	private string _maxExclusive; // 0x50
	private string _maxInclusive; // 0x58
	private string _minExclusive; // 0x60
	private string _minInclusive; // 0x68
	internal string _enumeration; // 0x70

	// Properties
	internal string BaseType { get; }
	internal XmlQualifiedName XmlBaseType { get; }
	internal string Name { get; }
	internal string Namespace { get; }
	internal int Length { get; }
	internal int MaxLength { get; set; }
	internal SimpleType BaseSimpleType { get; }
	public string SimpleTypeQualifiedName { get; }

	// Methods

	// RVA: 0x1E177E0 Offset: 0x1E169E0 VA: 0x181E177E0
	internal void .ctor(string baseType) { }

	// RVA: 0x1E178E0 Offset: 0x1E16AE0 VA: 0x181E178E0
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0x1E17240 Offset: 0x1E16440 VA: 0x181E17240 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E168D0 Offset: 0x1E15AD0 VA: 0x181E168D0
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0x1E167C0 Offset: 0x1E159C0 VA: 0x181E167C0
	internal bool IsPlainString() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal string get_BaseType() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal string get_Name() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal string get_Namespace() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	internal int get_Length() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	internal int get_MaxLength() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	internal void set_MaxLength(int value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0x1E17A70 Offset: 0x1E16C70 VA: 0x181E17A70
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0x1E171D0 Offset: 0x1E163D0 VA: 0x181E171D0
	internal string QualifiedName(string name) { }

	// RVA: 0x1E17280 Offset: 0x1E16480 VA: 0x181E17280
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0x1E164C0 Offset: 0x1E156C0 VA: 0x181E164C0
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0x1E16460 Offset: 0x1E15660 VA: 0x181E16460
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0x1E16540 Offset: 0x1E15740 VA: 0x181E16540
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0x1E165C0 Offset: 0x1E157C0 VA: 0x181E165C0
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0x1E166A0 Offset: 0x1E158A0 VA: 0x181E166A0
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0x1E16350 Offset: 0x1E15550 VA: 0x181E16350
	internal bool CanHaveMaxLength() { }

	// RVA: 0x1E163D0 Offset: 0x1E155D0 VA: 0x181E163D0
	internal void ConvertToAnnonymousSimpleType() { }
}

// Namespace: System.Data
[DefaultProperty("ConstraintName")]
public class UniqueConstraint : Constraint // TypeDefIndex: 12761
{
	// Fields
	private DataKey _key; // 0x38
	private Index _constraintIndex; // 0x40
	internal bool _bPrimaryKey; // 0x48
	internal string _constraintName; // 0x50
	internal string[] _columnNames; // 0x58

	// Properties
	internal string[] ColumnNames { get; }
	internal Index ConstraintIndex { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	internal DataColumn[] ColumnsReference { get; }
	public bool IsPrimaryKey { get; }
	internal override bool InCollection { set; }
	internal DataKey Key { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }

	// Methods

	// RVA: 0x1E19B00 Offset: 0x1E18D00 VA: 0x181E19B00
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E19BC0 Offset: 0x1E18DC0 VA: 0x181E19BC0
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0x1E19AC0 Offset: 0x1E18CC0 VA: 0x181E19AC0
	public void .ctor(DataColumn[] columns) { }

	[Browsable(False)]
	// RVA: 0x1E19C50 Offset: 0x1E18E50 VA: 0x181E19C50
	public void .ctor(string name, string[] columnNames, bool isPrimaryKey) { }

	// RVA: 0x1E19C00 Offset: 0x1E18E00 VA: 0x181E19C00
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0x1E19CA0 Offset: 0x1E18EA0 VA: 0x181E19CA0
	internal string[] get_ColumnNames() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal Index get_ConstraintIndex() { }

	// RVA: 0x1E19530 Offset: 0x1E18730 VA: 0x181E19530
	internal void ConstraintIndexClear() { }

	// RVA: 0x1E19560 Offset: 0x1E18760 VA: 0x181E19560
	internal void ConstraintIndexInitialize() { }

	// RVA: 0x1E18C40 Offset: 0x1E17E40 VA: 0x181E18C40 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x1E18C40 Offset: 0x1E17E40 VA: 0x181E18C40
	private void NonVirtualCheckState() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x1E18820 Offset: 0x1E17A20 VA: 0x181E18820 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x1E189E0 Offset: 0x1E17BE0 VA: 0x181E189E0 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x1E197E0 Offset: 0x1E189E0 VA: 0x181E197E0 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x1E18A60 Offset: 0x1E17C60 VA: 0x181E18A60 Slot: 15
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x1E195A0 Offset: 0x1E187A0 VA: 0x181E195A0 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1E0AF20 Offset: 0x1E0A120 VA: 0x181E0AF20 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x1E19060 Offset: 0x1E18260 VA: 0x181E19060 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x1E18C50 Offset: 0x1E17E50 VA: 0x181E18C50
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0x1E19CB0 Offset: 0x1E18EB0 VA: 0x181E19CB0 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x1E19CC0 Offset: 0x1E18EC0 VA: 0x181E19CC0
	public bool get_IsPrimaryKey() { }

	// RVA: 0x1E195B0 Offset: 0x1E187B0 VA: 0x181E195B0
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0x1E196B0 Offset: 0x1E188B0 VA: 0x181E196B0 Slot: 0
	public override bool Equals(object key2) { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E19D50 Offset: 0x1E18F50 VA: 0x181E19D50 Slot: 7
	internal override void set_InCollection(bool value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal DataKey get_Key() { }

	// RVA: 0x1E19D20 Offset: 0x1E18F20 VA: 0x181E19D20 Slot: 8
	public override DataTable get_Table() { }
}

// Namespace: 
private sealed class XDRSchema.NameType : IComparable // TypeDefIndex: 12762
{
	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string n, Type t) { }

	// RVA: 0x1E135A0 Offset: 0x1E127A0 VA: 0x181E135A0 Slot: 4
	public int CompareTo(object obj) { }
}

// Namespace: System.Data
internal sealed class XDRSchema : XMLSchema // TypeDefIndex: 12763
{
	// Fields
	internal string _schemaName; // 0x10
	internal string _schemaUri; // 0x18
	internal XmlElement _schemaRoot; // 0x20
	internal DataSet _ds; // 0x28
	private static readonly char[] s_colonArray; // 0x0
	private static XDRSchema.NameType[] s_mapNameTypeXdr; // 0x8
	private static XDRSchema.NameType s_enumerationNameType; // 0x10

	// Methods

	// RVA: 0x1E1D510 Offset: 0x1E1C710 VA: 0x181E1D510
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0x1E1C3A0 Offset: 0x1E1B5A0 VA: 0x181E1C3A0
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0x1E19E80 Offset: 0x1E19080 VA: 0x181E19E80
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0x1E1BEE0 Offset: 0x1E1B0E0 VA: 0x181E1BEE0
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0x1E1C0A0 Offset: 0x1E1B2A0 VA: 0x181E1C0A0
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0x1E1B2E0 Offset: 0x1E1A4E0 VA: 0x181E1B2E0
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0x1E19DA0 Offset: 0x1E18FA0 VA: 0x181E19DA0
	private static XDRSchema.NameType FindNameType(string name) { }

	// RVA: 0x1E1C5D0 Offset: 0x1E1B7D0 VA: 0x181E1C5D0
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0x1E1A240 Offset: 0x1E19440 VA: 0x181E1A240
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0x1E1A7E0 Offset: 0x1E199E0 VA: 0x181E1A7E0
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0x1E1A7B0 Offset: 0x1E199B0 VA: 0x181E1A7B0
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x1E1A3D0 Offset: 0x1E195D0 VA: 0x181E1A3D0
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x1E1B4A0 Offset: 0x1E1A6A0 VA: 0x181E1B4A0
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0x1E1B910 Offset: 0x1E1AB10 VA: 0x181E1B910
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0x1E1B6B0 Offset: 0x1E1A8B0 VA: 0x181E1B6B0
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0x1E1C720 Offset: 0x1E1B920 VA: 0x181E1C720
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class XMLDiffLoader // TypeDefIndex: 12764
{
	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0x1E1DAC0 Offset: 0x1E1CCC0 VA: 0x181E1DAC0
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0x1E1D590 Offset: 0x1E1C790 VA: 0x181E1D590
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1E1DC60 Offset: 0x1E1CE60 VA: 0x181E1DC60
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0x1E1DE60 Offset: 0x1E1D060 VA: 0x181E1DE60
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0x1E1E240 Offset: 0x1E1D440 VA: 0x181E1E240
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0x1E1EAA0 Offset: 0x1E1DCA0 VA: 0x181E1EAA0
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0x1E1E5E0 Offset: 0x1E1D7E0 VA: 0x181E1E5E0
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0x1E1D880 Offset: 0x1E1CA80 VA: 0x181E1D880
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0x1E1EE90 Offset: 0x1E1E090 VA: 0x181E1EE90
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	// RVA: 0x1E1FE20 Offset: 0x1E1F020 VA: 0x181E1FE20
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Data
internal class XMLSchema // TypeDefIndex: 12765
{
	// Methods

	// RVA: 0x1E202D0 Offset: 0x1E1F4D0 VA: 0x181E202D0
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0x1E20320 Offset: 0x1E1F520 VA: 0x181E20320
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0x1E1FFD0 Offset: 0x1E1F1D0 VA: 0x181E1FFD0
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0x1E20190 Offset: 0x1E1F390 VA: 0x181E20190
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0x1E20060 Offset: 0x1E1F260 VA: 0x181E20060
	internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Data
internal sealed class ConstraintTable // TypeDefIndex: 12766
{
	// Fields
	public DataTable table; // 0x10
	public XmlSchemaIdentityConstraint constraint; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(DataTable t, XmlSchemaIdentityConstraint c) { }
}

// Namespace: 
private sealed class XSDSchema.NameType : IComparable // TypeDefIndex: 12767
{
	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string n, Type t) { }

	// RVA: 0x1E1FF60 Offset: 0x1E1F160 VA: 0x181E1FF60 Slot: 4
	public int CompareTo(object obj) { }
}

// Namespace: System.Data
internal sealed class XSDSchema : XMLSchema // TypeDefIndex: 12768
{
	// Fields
	private XmlSchemaSet _schemaSet; // 0x10
	private XmlSchemaElement _dsElement; // 0x18
	private DataSet _ds; // 0x20
	private string _schemaName; // 0x28
	private ArrayList _columnExpressions; // 0x30
	private Hashtable _constraintNodes; // 0x38
	private ArrayList _refTables; // 0x40
	private ArrayList _complexTypes; // 0x48
	private XmlSchemaObjectCollection _annotations; // 0x50
	private XmlSchemaObjectCollection _elements; // 0x58
	private Hashtable _attributes; // 0x60
	private Hashtable _elementsTable; // 0x68
	private Hashtable _attributeGroups; // 0x70
	private Hashtable _schemaTypes; // 0x78
	private Hashtable _expressions; // 0x80
	private Dictionary<DataTable, List<DataTable>> _tableDictionary; // 0x88
	private Hashtable _udSimpleTypes; // 0x90
	private Hashtable _existingSimpleTypeMap; // 0x98
	private bool _fromInference; // 0xA0
	private static readonly XSDSchema.NameType[] s_mapNameTypeXsd; // 0x0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x1200DC0 Offset: 0x11FFFC0 VA: 0x181200DC0
	internal bool get_FromInference() { }

	// RVA: 0x1200DD0 Offset: 0x11FFFD0 VA: 0x181200DD0
	internal void set_FromInference(bool value) { }

	// RVA: 0x1E21510 Offset: 0x1E20710 VA: 0x181E21510
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0x1E20BB0 Offset: 0x1E1FDB0 VA: 0x181E20BB0
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0x1E2E980 Offset: 0x1E2DB80 VA: 0x181E2E980
	internal static string QualifiedName(string name) { }

	// RVA: 0x1E2EFD0 Offset: 0x1E2E1D0 VA: 0x181E2EFD0
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x1E2EC20 Offset: 0x1E2DE20 VA: 0x181E2EC20
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x1E24810 Offset: 0x1E23A10 VA: 0x181E24810
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x1E225B0 Offset: 0x1E217B0 VA: 0x181E225B0
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0x1E2E9F0 Offset: 0x1E2DBF0 VA: 0x181E2E9F0
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0x1E28C60 Offset: 0x1E27E60 VA: 0x181E28C60
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0x1E28D60 Offset: 0x1E27F60 VA: 0x181E28D60
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0x1E2ACC0 Offset: 0x1E29EC0 VA: 0x181E2ACC0
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1E2C830 Offset: 0x1E2BA30 VA: 0x181E2C830
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0x1E215A0 Offset: 0x1E207A0 VA: 0x181E215A0
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0x1E21780 Offset: 0x1E20980 VA: 0x181E21780
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0x1E2E690 Offset: 0x1E2D890 VA: 0x181E2E690
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0x1E2D1E0 Offset: 0x1E2C3E0 VA: 0x181E2D1E0
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0x1E29730 Offset: 0x1E28930 VA: 0x181E29730
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0x1E229B0 Offset: 0x1E21BB0 VA: 0x181E229B0
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0x1E28440 Offset: 0x1E27640 VA: 0x181E28440
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0x1E24560 Offset: 0x1E23760 VA: 0x181E24560
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0x1E24270 Offset: 0x1E23470 VA: 0x181E24270
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0x1E24A20 Offset: 0x1E23C20 VA: 0x181E24A20
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0x1E22E20 Offset: 0x1E22020 VA: 0x181E22E20
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0x1E21CE0 Offset: 0x1E20EE0 VA: 0x181E21CE0
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0x1E20930 Offset: 0x1E1FB30 VA: 0x181E20930
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0x1E222C0 Offset: 0x1E214C0 VA: 0x181E222C0
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0x1E233B0 Offset: 0x1E225B0 VA: 0x181E233B0
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0x1E2F530 Offset: 0x1E2E730 VA: 0x181E2F530
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0x1E2F5A0 Offset: 0x1E2E7A0 VA: 0x181E2F5A0
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0x1E27AB0 Offset: 0x1E26CB0 VA: 0x181E27AB0
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0x1E25320 Offset: 0x1E24520 VA: 0x181E25320
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0x1E2AEF0 Offset: 0x1E2A0F0 VA: 0x181E2AEF0
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0x1E22420 Offset: 0x1E21620 VA: 0x181E22420
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0x1E2B660 Offset: 0x1E2A860 VA: 0x181E2B660
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0x1E2F670 Offset: 0x1E2E870 VA: 0x181E2F670
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0x1E21EA0 Offset: 0x1E210A0 VA: 0x181E21EA0
	private static XSDSchema.NameType FindNameType(string name) { }

	// RVA: 0x1E2E6C0 Offset: 0x1E2D8C0 VA: 0x181E2E6C0
	private Type ParseDataType(string dt) { }

	// RVA: 0x1E2D170 Offset: 0x1E2C370 VA: 0x181E2D170
	internal static bool IsXsdType(string name) { }

	// RVA: 0x1E21F80 Offset: 0x1E21180 VA: 0x181E21F80
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0x1E2A110 Offset: 0x1E29310 VA: 0x181E2A110
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x1E29990 Offset: 0x1E28B90 VA: 0x181E29990
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x1E236F0 Offset: 0x1E228F0 VA: 0x181E236F0
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0x1E269C0 Offset: 0x1E25BC0 VA: 0x181E269C0
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0x1E257D0 Offset: 0x1E249D0 VA: 0x181E257D0
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0x1E20760 Offset: 0x1E1F960 VA: 0x181E20760
	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	// RVA: 0x1E230F0 Offset: 0x1E222F0 VA: 0x181E230F0
	private string GetPrefix(string ns) { }

	// RVA: 0x1E226E0 Offset: 0x1E218E0 VA: 0x181E226E0
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0x1E23550 Offset: 0x1E22750 VA: 0x181E23550
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x1E23430 Offset: 0x1E22630 VA: 0x181E23430
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x1E2CE70 Offset: 0x1E2C070 VA: 0x181E2CE70
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0x1E2AAF0 Offset: 0x1E29CF0 VA: 0x181E2AAF0
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1E2F750 Offset: 0x1E2E950 VA: 0x181E2F750
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader // TypeDefIndex: 12769
{
	// Fields
	private List<string> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0x1E35B70 Offset: 0x1E34D70 VA: 0x181E35B70
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0x1E35930 Offset: 0x1E34B30 VA: 0x181E35930 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1E35A50 Offset: 0x1E34C50 VA: 0x181E35A50 Slot: 30
	public override bool MoveToNextAttribute() { }
}

// Namespace: System.Data
internal sealed class XmlDataLoader // TypeDefIndex: 12770
{
	// Fields
	private DataSet _dataSet; // 0x10
	private XmlToDatasetMap _nodeToSchemaMap; // 0x18
	private Hashtable _nodeToRowMap; // 0x20
	private Stack _childRowsStack; // 0x28
	private Hashtable _htableExcludedNS; // 0x30
	private bool _fIsXdr; // 0x38
	internal bool _isDiffgram; // 0x39
	private XmlElement _topMostNode; // 0x40
	private bool _ignoreSchema; // 0x48
	private DataTable _dataTable; // 0x50
	private bool _isTableLevel; // 0x58
	private bool _fromInference; // 0x59
	private XmlReader _dataReader; // 0x60
	private object _XSD_XMLNS_NS; // 0x68
	private object _XDR_SCHEMA; // 0x70
	private object _XDRNS; // 0x78
	private object _SQL_SYNC; // 0x80
	private object _UPDGNS; // 0x88
	private object _XSD_SCHEMA; // 0x90
	private object _XSDNS; // 0x98
	private object _DFFNS; // 0xA0
	private object _MSDNS; // 0xA8
	private object _DIFFID; // 0xB0
	private object _HASCHANGES; // 0xB8
	private object _ROWORDER; // 0xC0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x1E35670 Offset: 0x1E34870 VA: 0x181E35670
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1E35870 Offset: 0x1E34A70 VA: 0x181E35870
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x1E35700 Offset: 0x1E34900 VA: 0x181E35700
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1E357A0 Offset: 0x1E349A0 VA: 0x181E357A0
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x7725E0 Offset: 0x7717E0 VA: 0x1807725E0
	internal bool get_FromInference() { }

	// RVA: 0xE5B9A0 Offset: 0xE5ABA0 VA: 0x180E5B9A0
	internal void set_FromInference(bool value) { }

	// RVA: 0x1E30790 Offset: 0x1E2F990 VA: 0x181E30790
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1E308F0 Offset: 0x1E2FAF0 VA: 0x181E308F0
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0x1E312D0 Offset: 0x1E304D0 VA: 0x181E312D0
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0x1E30E80 Offset: 0x1E30080 VA: 0x181E30E80
	private string GetInitialTextFromNodes(ref XmlNode n) { }

	// RVA: 0x1E31220 Offset: 0x1E30420 VA: 0x181E31220
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0x1E31160 Offset: 0x1E30360 VA: 0x181E31160
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0x1E30A90 Offset: 0x1E2FC90 VA: 0x181E30A90
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0x1E30BC0 Offset: 0x1E2FDC0 VA: 0x181E30BC0
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0x1E30CF0 Offset: 0x1E2FEF0 VA: 0x181E30CF0
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0x1E30C60 Offset: 0x1E2FE60 VA: 0x181E30C60
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0x1E31840 Offset: 0x1E30A40 VA: 0x181E31840
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0x1E318A0 Offset: 0x1E30AA0 VA: 0x181E318A0
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0x1E32370 Offset: 0x1E31570 VA: 0x181E32370
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0x1E32A40 Offset: 0x1E31C40 VA: 0x181E32A40
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0x1E33710 Offset: 0x1E32910 VA: 0x181E33710
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1E35620 Offset: 0x1E34820 VA: 0x181E35620
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0x1E315A0 Offset: 0x1E307A0 VA: 0x181E315A0
	private void InitNameTable() { }

	// RVA: 0x1E32660 Offset: 0x1E31860 VA: 0x181E32660
	internal void LoadData(XmlReader reader) { }

	// RVA: 0x1E34A40 Offset: 0x1E33C40 VA: 0x181E34A40
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0x1E33AD0 Offset: 0x1E32CD0 VA: 0x181E33AD0
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0x1E318E0 Offset: 0x1E30AE0 VA: 0x181E318E0
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0x1E353D0 Offset: 0x1E345D0 VA: 0x181E353D0
	private bool ProcessXsdSchema() { }
}

// Namespace: System.Data
public enum XmlReadMode // TypeDefIndex: 12771
{
	// Fields
	public int value__; // 0x0
	public const XmlReadMode Auto = 0;
	public const XmlReadMode ReadSchema = 1;
	public const XmlReadMode IgnoreSchema = 2;
	public const XmlReadMode InferSchema = 3;
	public const XmlReadMode DiffGram = 4;
	public const XmlReadMode Fragment = 5;
	public const XmlReadMode InferTypedSchema = 6;
}

// Namespace: 
private sealed class XmlToDatasetMap.XmlNodeIdentety // TypeDefIndex: 12772
{
	// Fields
	public string LocalName; // 0x10
	public string NamespaceURI; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string localName, string namespaceURI) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E40C40 Offset: 0x1E3FE40 VA: 0x181E40C40 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class XmlToDatasetMap.XmlNodeIdHashtable : Hashtable // TypeDefIndex: 12773
{
	// Fields
	private XmlToDatasetMap.XmlNodeIdentety _id; // 0x50

	// Properties
	public object Item { get; }
	public object Item { get; }
	public object Item { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x1E40960 Offset: 0x1E3FB60 VA: 0x181E40960
	public void .ctor(int capacity) { }

	// RVA: 0x1E40B20 Offset: 0x1E3FD20 VA: 0x181E40B20
	public object get_Item(XmlNode node) { }

	// RVA: 0x1E40BB0 Offset: 0x1E3FDB0 VA: 0x181E40BB0
	public object get_Item(XmlReader dataReader) { }

	// RVA: 0x1E40AA0 Offset: 0x1E3FCA0 VA: 0x181E40AA0
	public object get_Item(DataTable table) { }

	// RVA: 0x1E40A10 Offset: 0x1E3FC10 VA: 0x181E40A10
	public object get_Item(string name) { }
}

// Namespace: 
private sealed class XmlToDatasetMap.TableSchemaInfo // TypeDefIndex: 12774
{
	// Fields
	public DataTable TableSchema; // 0x10
	public XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0x1E3D680 Offset: 0x1E3C880 VA: 0x181E3D680
	public void .ctor(DataTable tableSchema) { }
}

// Namespace: System.Data
internal sealed class XmlToDatasetMap // TypeDefIndex: 12775
{
	// Fields
	private XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0x1E38120 Offset: 0x1E37320 VA: 0x181E38120
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1E380A0 Offset: 0x1E372A0 VA: 0x181E380A0
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1E38160 Offset: 0x1E37360 VA: 0x181E38160
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1E380E0 Offset: 0x1E372E0 VA: 0x181E380E0
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1E38070 Offset: 0x1E37270 VA: 0x181E38070
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0x1E35F50 Offset: 0x1E35150 VA: 0x181E35F50
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0x1E36090 Offset: 0x1E35290 VA: 0x181E36090
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0x1E35C00 Offset: 0x1E34E00 VA: 0x181E35C00
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1E35D60 Offset: 0x1E34F60 VA: 0x181E35D60
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1E36230 Offset: 0x1E35430 VA: 0x181E36230
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1E36880 Offset: 0x1E35A80 VA: 0x181E36880
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1E365C0 Offset: 0x1E357C0 VA: 0x181E365C0
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1E36F70 Offset: 0x1E36170 VA: 0x181E36F70
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1E37B00 Offset: 0x1E36D00 VA: 0x181E37B00
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0x1E37620 Offset: 0x1E36820 VA: 0x181E37620
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1E37880 Offset: 0x1E36A80 VA: 0x181E37880
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0x1E379F0 Offset: 0x1E36BF0 VA: 0x181E379F0
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1E37E10 Offset: 0x1E37010 VA: 0x181E37E10
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0x1E37EE0 Offset: 0x1E370E0 VA: 0x181E37EE0
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }
}

// Namespace: System.Data
public enum XmlWriteMode // TypeDefIndex: 12776
{
	// Fields
	public int value__; // 0x0
	public const XmlWriteMode WriteSchema = 0;
	public const XmlWriteMode IgnoreSchema = 1;
	public const XmlWriteMode DiffGram = 2;
}

// Namespace: System.Data
internal enum SchemaFormat // TypeDefIndex: 12777
{
	// Fields
	public int value__; // 0x0
	public const SchemaFormat Public = 1;
	public const SchemaFormat Remoting = 2;
	public const SchemaFormat WebService = 3;
	public const SchemaFormat RemotingSkipSchema = 4;
	public const SchemaFormat WebServiceSkipSchema = 5;
}

// Namespace: System.Data
internal sealed class XmlTreeGen // TypeDefIndex: 12778
{
	// Fields
	private ArrayList _constraintNames; // 0x10
	private Hashtable _namespaces; // 0x18
	private Hashtable _autogenerated; // 0x20
	private Hashtable _prefixes; // 0x28
	private DataSet _ds; // 0x30
	private ArrayList _tables; // 0x38
	private ArrayList _relations; // 0x40
	private XmlDocument _dc; // 0x48
	private XmlElement _sRoot; // 0x50
	private int _prefixCount; // 0x58
	private SchemaFormat _schFormat; // 0x5C
	private string _filePath; // 0x60
	private string _fileName; // 0x68
	private string _fileExt; // 0x70
	private XmlElement _dsElement; // 0x78
	private XmlElement _constraintSeparator; // 0x80
	private Converter<Type, string> _targetConverter; // 0x88

	// Methods

	// RVA: 0x1E4E450 Offset: 0x1E4D650 VA: 0x181E4E450
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0x1E41370 Offset: 0x1E40570 VA: 0x181E41370
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0x1E41380 Offset: 0x1E40580 VA: 0x181E41380
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0x1E41980 Offset: 0x1E40B80 VA: 0x181E41980
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1E41BA0 Offset: 0x1E40DA0 VA: 0x181E41BA0
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1E4D6D0 Offset: 0x1E4C8D0 VA: 0x181E4D6D0
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0x1E446F0 Offset: 0x1E438F0 VA: 0x181E446F0
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0x1E443D0 Offset: 0x1E435D0 VA: 0x181E443D0
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0x1E444D0 Offset: 0x1E436D0 VA: 0x181E444D0
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0x1E4E420 Offset: 0x1E4D620 VA: 0x181E4E420
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0x1E49120 Offset: 0x1E48320 VA: 0x181E49120
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0x1E4D4A0 Offset: 0x1E4C6A0 VA: 0x181E4D4A0
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0x1E4D420 Offset: 0x1E4C620 VA: 0x181E4D420
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0x1E4C690 Offset: 0x1E4B890 VA: 0x181E4C690
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0x1E4D210 Offset: 0x1E4C410 VA: 0x181E4D210
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0x1E4C8B0 Offset: 0x1E4BAB0 VA: 0x181E4C8B0
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0x1E431F0 Offset: 0x1E423F0 VA: 0x181E431F0
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1E42F40 Offset: 0x1E42140 VA: 0x181E42F40
	private void CreateRelations(DataTable dt) { }

	// RVA: 0x1E434E0 Offset: 0x1E426E0 VA: 0x181E434E0
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1E49BE0 Offset: 0x1E48DE0 VA: 0x181E49BE0
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1E49720 Offset: 0x1E48920 VA: 0x181E49720
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0x1E437F0 Offset: 0x1E429F0 VA: 0x181E437F0
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0x1E4C3D0 Offset: 0x1E4B5D0 VA: 0x181E4C3D0
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0x1E49620 Offset: 0x1E48820 VA: 0x181E49620
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0x1E49650 Offset: 0x1E48850 VA: 0x181E49650
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0x1E494A0 Offset: 0x1E486A0 VA: 0x181E494A0
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0x1E49350 Offset: 0x1E48550 VA: 0x181E49350
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0x1E494C0 Offset: 0x1E486C0 VA: 0x181E494C0
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x1E45E30 Offset: 0x1E45030 VA: 0x181E45E30
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0x1E43F20 Offset: 0x1E43120 VA: 0x181E43F20
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0x1E44B50 Offset: 0x1E43D50 VA: 0x181E44B50
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0x1E44E10 Offset: 0x1E44010 VA: 0x181E44E10
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0x1E40CF0 Offset: 0x1E3FEF0 VA: 0x181E40CF0
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0x1E44090 Offset: 0x1E43290 VA: 0x181E44090
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0x1E452D0 Offset: 0x1E444D0 VA: 0x181E452D0
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0x1E4D320 Offset: 0x1E4C520 VA: 0x181E4D320
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0x1E4D380 Offset: 0x1E4C580 VA: 0x181E4D380
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0x1E425E0 Offset: 0x1E417E0 VA: 0x181E425E0
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0x1E441B0 Offset: 0x1E433B0 VA: 0x181E441B0
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0x1E48EA0 Offset: 0x1E480A0 VA: 0x181E48EA0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0x1E48EC0 Offset: 0x1E480C0 VA: 0x181E48EC0
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0x1E42B00 Offset: 0x1E41D00 VA: 0x181E42B00
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0x1E429E0 Offset: 0x1E41BE0 VA: 0x181E429E0
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0x1E426A0 Offset: 0x1E418A0 VA: 0x181E426A0
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0x1E42780 Offset: 0x1E41980 VA: 0x181E42780
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0x1E42790 Offset: 0x1E41990 VA: 0x181E42790
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0x1E49310 Offset: 0x1E48510 VA: 0x181E49310
	private bool IsAutoGenerated(object o) { }

	// RVA: 0x1E46450 Offset: 0x1E45650 VA: 0x181E46450
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0x1E4C1F0 Offset: 0x1E4B3F0 VA: 0x181E4C1F0
	private void SetMSDataAttribute(XmlElement root, Type type) { }
}

// Namespace: System.Data
internal sealed class NewDiffgramGen // TypeDefIndex: 12779
{
	// Fields
	internal XmlDocument _doc; // 0x10
	internal DataSet _ds; // 0x18
	internal DataTable _dt; // 0x20
	internal XmlWriter _xmlw; // 0x28
	private bool _fBefore; // 0x30
	private bool _fErrors; // 0x31
	internal Hashtable _rowsOrder; // 0x38
	private ArrayList _tables; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x1E3B020 Offset: 0x1E3A220 VA: 0x181E3B020
	internal void .ctor(DataSet ds) { }

	// RVA: 0x1E3AF20 Offset: 0x1E3A120 VA: 0x181E3AF20
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1E38990 Offset: 0x1E37B90 VA: 0x181E38990
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0x1E38C80 Offset: 0x1E37E80 VA: 0x181E38C80
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0x1E38FB0 Offset: 0x1E381B0 VA: 0x181E38FB0
	private bool EmptyData() { }

	// RVA: 0x1E3AF10 Offset: 0x1E3A110 VA: 0x181E3AF10
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0x1E3A810 Offset: 0x1E39A10 VA: 0x181E3A810
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0x1E3A720 Offset: 0x1E39920 VA: 0x181E3A720
	private void GenerateTable(DataTable table) { }

	// RVA: 0x1E3A140 Offset: 0x1E39340 VA: 0x181E3A140
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0x1E39AC0 Offset: 0x1E38CC0 VA: 0x181E39AC0
	private void GenerateRow(DataRow row) { }

	// RVA: 0x1E39130 Offset: 0x1E38330 VA: 0x181E39130
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0x1E3A7B0 Offset: 0x1E399B0 VA: 0x181E3A7B0
	internal static string QualifiedName(string prefix, string name) { }
}

// Namespace: System.Data
internal sealed class XmlDataTreeWriter // TypeDefIndex: 12780
{
	// Fields
	private XmlWriter _xmlw; // 0x10
	private DataSet _ds; // 0x18
	private DataTable _dt; // 0x20
	private ArrayList _dTables; // 0x28
	private DataTable[] _topLevelTables; // 0x30
	private bool _fFromTable; // 0x38
	private bool _isDiffgram; // 0x39
	private Hashtable _rowsOrder; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x1E406E0 Offset: 0x1E3F8E0 VA: 0x181E406E0
	internal void .ctor(DataSet ds) { }

	// RVA: 0x1E40520 Offset: 0x1E3F720 VA: 0x181E40520
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1E3DA90 Offset: 0x1E3CC90 VA: 0x181E3DA90
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1E3D7A0 Offset: 0x1E3C9A0 VA: 0x181E3D7A0
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1E3E100 Offset: 0x1E3D300 VA: 0x181E3E100
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0x1E3E1E0 Offset: 0x1E3D3E0 VA: 0x181E3E1E0
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0x1E3E740 Offset: 0x1E3D940 VA: 0x181E3E740
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0x1E3DDA0 Offset: 0x1E3CFA0 VA: 0x181E3DDA0
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0x1E3EFE0 Offset: 0x1E3E1E0 VA: 0x181E3EFE0
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0x1E3E050 Offset: 0x1E3D250 VA: 0x181E3E050
	internal static bool PreserveSpace(object value) { }
}

// Namespace: System.Data
internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 12781
{
	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Properties
	internal Stream BaseStream { get; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x1E38510 Offset: 0x1E37710 VA: 0x181E38510
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0x159E350 Offset: 0x159D550 VA: 0x18159E350
	private void .ctor(XmlWriter w) { }

	// RVA: 0x1E38900 Offset: 0x1E37B00 VA: 0x181E38900
	internal Stream get_BaseStream() { }

	// RVA: 0x1B57FC0 Offset: 0x1B571C0 VA: 0x181B57FC0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1E38810 Offset: 0x1E37A10 VA: 0x181E38810 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1755220 Offset: 0x1754420 VA: 0x181755220 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1E386C0 Offset: 0x1E378C0 VA: 0x181E386C0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1E38840 Offset: 0x1E37A40 VA: 0x181E38840 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1607D40 Offset: 0x1606F40 VA: 0x181607D40 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1E38720 Offset: 0x1E37920 VA: 0x181E38720 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1E387E0 Offset: 0x1E379E0 VA: 0x181E387E0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1607E30 Offset: 0x1607030 VA: 0x181607E30 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1E38600 Offset: 0x1E37800 VA: 0x181E38600 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1E38690 Offset: 0x1E37890 VA: 0x181E38690 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1E38750 Offset: 0x1E37950 VA: 0x181E38750 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1E386F0 Offset: 0x1E378F0 VA: 0x181E386F0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1E38630 Offset: 0x1E37830 VA: 0x181E38630 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1E388D0 Offset: 0x1E37AD0 VA: 0x181E388D0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1E38870 Offset: 0x1E37A70 VA: 0x181E38870 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1E388A0 Offset: 0x1E37AA0 VA: 0x181E388A0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1E38660 Offset: 0x1E37860 VA: 0x181E38660 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1E38780 Offset: 0x1E37980 VA: 0x181E38780 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1E387B0 Offset: 0x1E379B0 VA: 0x181E387B0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1E385A0 Offset: 0x1E377A0 VA: 0x181E385A0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1E385D0 Offset: 0x1E377D0 VA: 0x181E385D0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x16C6470 Offset: 0x16C5670 VA: 0x1816C6470 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x16C6410 Offset: 0x16C5610 VA: 0x1816C6410 Slot: 28
	public override void Close() { }

	// RVA: 0x16C65D0 Offset: 0x16C57D0 VA: 0x1816C65D0 Slot: 29
	public override void Flush() { }

	// RVA: 0x1E38570 Offset: 0x1E37770 VA: 0x181E38570 Slot: 30
	public override string LookupPrefix(string ns) { }
}

// Namespace: System.Data
internal sealed class DataTextReader : XmlReader // TypeDefIndex: 12782
{
	// Fields
	private XmlReader _xmlreader; // 0x10

	// Properties
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
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }

	// Methods

	// RVA: 0x1E381E0 Offset: 0x1E373E0 VA: 0x181E381E0
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0x1E383F0 Offset: 0x1E375F0 VA: 0x181E383F0
	private void .ctor(XmlReader input) { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1917E80 Offset: 0x1917080 VA: 0x181917E80 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1917E30 Offset: 0x1917030 VA: 0x181917E30 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x16570C0 Offset: 0x16562C0 VA: 0x1816570C0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x16571B0 Offset: 0x16563B0 VA: 0x1816571B0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1657180 Offset: 0x1656380 VA: 0x181657180 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x1CFECC0 Offset: 0x1CFDEC0 VA: 0x181CFECC0 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1CFD600 Offset: 0x1CFC800 VA: 0x181CFD600 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1CFD730 Offset: 0x1CFC930 VA: 0x181CFD730 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x1CFD7B0 Offset: 0x1CFC9B0 VA: 0x181CFD7B0 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1657150 Offset: 0x1656350 VA: 0x181657150 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x1657090 Offset: 0x1656290 VA: 0x181657090 Slot: 17
	public override char get_QuoteChar() { }

	// RVA: 0x1657120 Offset: 0x1656320 VA: 0x181657120 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1E384E0 Offset: 0x1E376E0 VA: 0x181E384E0 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x17192C0 Offset: 0x17184C0 VA: 0x1817192C0 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1E382A0 Offset: 0x1E374A0 VA: 0x181E382A0 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1E38270 Offset: 0x1E37470 VA: 0x181E38270 Slot: 25
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1E382D0 Offset: 0x1E374D0 VA: 0x181E382D0 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1E38300 Offset: 0x1E37500 VA: 0x181E38300 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xB10540 Offset: 0xB0F740 VA: 0x180B10540 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x17384E0 Offset: 0x17376E0 VA: 0x1817384E0 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1E38330 Offset: 0x1E37530 VA: 0x181E38330 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x159D610 Offset: 0x159C810 VA: 0x18159D610 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1E38360 Offset: 0x1E37560 VA: 0x181E38360 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x1E383C0 Offset: 0x1E375C0 VA: 0x181E383C0 Slot: 33
	public override bool Read() { }

	// RVA: 0x1E384B0 Offset: 0x1E376B0 VA: 0x181E384B0 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x18AF010 Offset: 0x18AE210 VA: 0x1818AF010 Slot: 35
	public override void Close() { }

	// RVA: 0x1738040 Offset: 0x1737240 VA: 0x181738040 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x154B250 Offset: 0x154A450 VA: 0x18154B250 Slot: 37
	public override void Skip() { }

	// RVA: 0x18AEFE0 Offset: 0x18AE1E0 VA: 0x1818AEFE0 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x17457D0 Offset: 0x17449D0 VA: 0x1817457D0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1E38480 Offset: 0x1E37680 VA: 0x181E38480 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x8D0650 Offset: 0x8CF850 VA: 0x1808D0650 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1E38450 Offset: 0x1E37650 VA: 0x181E38450 Slot: 42
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1E38390 Offset: 0x1E37590 VA: 0x181E38390 Slot: 44
	public override string ReadString() { }
}

// Namespace: System.Data.SqlTypes
internal static class SQLResource // TypeDefIndex: 12783
{
	// Properties
	internal static string NullString { get; }
	internal static string ArithOverflowMessage { get; }
	internal static string DivideByZeroMessage { get; }
	internal static string NullValueMessage { get; }
	internal static string TruncationMessage { get; }
	internal static string DateTimeOverflowMessage { get; }
	internal static string ConcatDiffCollationMessage { get; }
	internal static string CompareDiffCollationMessage { get; }
	internal static string ConversionOverflowMessage { get; }
	internal static string TimeZoneSpecifiedMessage { get; }
	internal static string InvalidPrecScaleMessage { get; }
	internal static string FormatMessage { get; }

	// Methods

	// RVA: 0x1E3B3D0 Offset: 0x1E3A5D0 VA: 0x181E3B3D0
	internal static string get_NullString() { }

	// RVA: 0x1E3B250 Offset: 0x1E3A450 VA: 0x181E3B250
	internal static string get_ArithOverflowMessage() { }

	// RVA: 0x1E3B340 Offset: 0x1E3A540 VA: 0x181E3B340
	internal static string get_DivideByZeroMessage() { }

	// RVA: 0x1E3B400 Offset: 0x1E3A600 VA: 0x181E3B400
	internal static string get_NullValueMessage() { }

	// RVA: 0x1E3B460 Offset: 0x1E3A660 VA: 0x181E3B460
	internal static string get_TruncationMessage() { }

	// RVA: 0x1E3B310 Offset: 0x1E3A510 VA: 0x181E3B310
	internal static string get_DateTimeOverflowMessage() { }

	// RVA: 0x1E3B2B0 Offset: 0x1E3A4B0 VA: 0x181E3B2B0
	internal static string get_ConcatDiffCollationMessage() { }

	// RVA: 0x1E3B280 Offset: 0x1E3A480 VA: 0x181E3B280
	internal static string get_CompareDiffCollationMessage() { }

	// RVA: 0x1E3B2E0 Offset: 0x1E3A4E0 VA: 0x181E3B2E0
	internal static string get_ConversionOverflowMessage() { }

	// RVA: 0x1E3B430 Offset: 0x1E3A630 VA: 0x181E3B430
	internal static string get_TimeZoneSpecifiedMessage() { }

	// RVA: 0x1E3B3A0 Offset: 0x1E3A5A0 VA: 0x181E3B3A0
	internal static string get_InvalidPrecScaleMessage() { }

	// RVA: 0x1E3B370 Offset: 0x1E3A570 VA: 0x181E3B370
	internal static string get_FormatMessage() { }

	// RVA: 0x1E3B150 Offset: 0x1E3A350 VA: 0x181E3B150
	internal static string InvalidOpStreamClosed(string method) { }

	// RVA: 0x1E3B210 Offset: 0x1E3A410 VA: 0x181E3B210
	internal static string InvalidOpStreamNonWritable(string method) { }

	// RVA: 0x1E3B190 Offset: 0x1E3A390 VA: 0x181E3B190
	internal static string InvalidOpStreamNonReadable(string method) { }

	// RVA: 0x1E3B1D0 Offset: 0x1E3A3D0 VA: 0x181E3B1D0
	internal static string InvalidOpStreamNonSeekable(string method) { }
}

// Namespace: System.Data.SqlTypes
public interface INullable // TypeDefIndex: 12784
{
	// Properties
	public abstract bool IsNull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsNull();
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[DefaultMember("Item")]
[Serializable]
public struct SqlBinary : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12785
{
	// Fields
	private byte[] _value; // 0x0
	public static readonly SqlBinary Null; // 0x0

	// Properties
	public bool IsNull { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x169ECB0 Offset: 0x169DEB0 VA: 0x18169ECB0
	private void .ctor(bool fNull) { }

	// RVA: 0x1E3C1D0 Offset: 0x1E3B3D0 VA: 0x181E3C1D0
	public void .ctor(byte[] value) { }

	// RVA: 0x12175A0 Offset: 0x12167A0 VA: 0x1812175A0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E3C240 Offset: 0x1E3B440 VA: 0x181E3C240
	public byte[] get_Value() { }

	// RVA: 0x1E3C510 Offset: 0x1E3B710 VA: 0x181E3C510
	public static SqlBinary op_Implicit(byte[] x) { }

	// RVA: 0x1E3C0A0 Offset: 0x1E3B2A0 VA: 0x181E3C0A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E3BCE0 Offset: 0x1E3AEE0 VA: 0x181E3BCE0
	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	// RVA: 0x1E3C310 Offset: 0x1E3B510 VA: 0x181E3C310
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1E3C580 Offset: 0x1E3B780 VA: 0x181E3C580
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1E3C410 Offset: 0x1E3B610 VA: 0x181E3C410
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1E3B7D0 Offset: 0x1E3A9D0 VA: 0x181E3B7D0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E3B490 Offset: 0x1E3A690 VA: 0x181E3B490
	public int CompareTo(SqlBinary value) { }

	// RVA: 0x1E3B8F0 Offset: 0x1E3AAF0 VA: 0x181E3B8F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E3BC80 Offset: 0x1E3AE80 VA: 0x181E3BC80
	internal static int HashByteArray(byte[] rgbValue, int length) { }

	// RVA: 0x1E3BB20 Offset: 0x1E3AD20 VA: 0x181E3BB20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E3BE10 Offset: 0x1E3B010 VA: 0x181E3BE10 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E3BF80 Offset: 0x1E3B180 VA: 0x181E3BF80 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E3BC10 Offset: 0x1E3AE10 VA: 0x181E3BC10
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E3C190 Offset: 0x1E3B390 VA: 0x181E3C190
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlBoolean : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12786
{
	// Fields
	private byte m_value; // 0x0
	public static readonly SqlBoolean True; // 0x0
	public static readonly SqlBoolean False; // 0x1
	public static readonly SqlBoolean Null; // 0x2
	public static readonly SqlBoolean Zero; // 0x3
	public static readonly SqlBoolean One; // 0x4

	// Properties
	public bool IsNull { get; }
	public bool Value { get; }
	public bool IsTrue { get; }
	public bool IsFalse { get; }
	public byte ByteValue { get; }

	// Methods

	// RVA: 0x1E3D280 Offset: 0x1E3C480 VA: 0x181E3D280
	public void .ctor(bool value) { }

	// RVA: 0x1E3D200 Offset: 0x1E3C400 VA: 0x181E3D200
	public void .ctor(int value) { }

	// RVA: 0x1E3D260 Offset: 0x1E3C460 VA: 0x181E3D260
	private void .ctor(int value, bool fNull) { }

	// RVA: 0x1E3D330 Offset: 0x1E3C530 VA: 0x181E3D330 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E3D350 Offset: 0x1E3C550 VA: 0x181E3D350
	public bool get_Value() { }

	// RVA: 0x1E3D340 Offset: 0x1E3C540 VA: 0x181E3D340
	public bool get_IsTrue() { }

	// RVA: 0x1E3D320 Offset: 0x1E3C520 VA: 0x181E3D320
	public bool get_IsFalse() { }

	// RVA: 0x1E3D620 Offset: 0x1E3C820 VA: 0x181E3D620
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0x1E3D630 Offset: 0x1E3C830 VA: 0x181E3D630
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0x1E3D3B0 Offset: 0x1E3C5B0 VA: 0x181E3D3B0
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1E3D490 Offset: 0x1E3C690 VA: 0x181E3D490
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1E3D290 Offset: 0x1E3C490 VA: 0x181E3D290
	public byte get_ByteValue() { }

	// RVA: 0x1E3D010 Offset: 0x1E3C210 VA: 0x181E3D010 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E3D570 Offset: 0x1E3C770 VA: 0x181E3D570
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1E3C680 Offset: 0x1E3B880 VA: 0x181E3C680
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1E3CCD0 Offset: 0x1E3BED0 VA: 0x181E3CCD0
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1E3C8B0 Offset: 0x1E3BAB0 VA: 0x181E3C8B0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E3C790 Offset: 0x1E3B990 VA: 0x181E3C790
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0x1E3C9D0 Offset: 0x1E3BBD0 VA: 0x181E3C9D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E3CB80 Offset: 0x1E3BD80 VA: 0x181E3CB80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E3CDE0 Offset: 0x1E3BFE0 VA: 0x181E3CDE0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E3CF00 Offset: 0x1E3C100 VA: 0x181E3CF00 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E3CC60 Offset: 0x1E3BE60 VA: 0x181E3CC60
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E3D110 Offset: 0x1E3C310 VA: 0x181E3D110
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlByte : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12787
{
	// Fields
	private bool m_fNotNull; // 0x0
	private byte m_value; // 0x1
	private static readonly int s_iBitNotByteMax; // 0x0
	public static readonly SqlByte Null; // 0x4
	public static readonly SqlByte Zero; // 0x6
	public static readonly SqlByte MinValue; // 0x8
	public static readonly SqlByte MaxValue; // 0xA

	// Properties
	public bool IsNull { get; }
	public byte Value { get; }

	// Methods

	// RVA: 0x1E527B0 Offset: 0x1E519B0 VA: 0x181E527B0
	private void .ctor(bool fNull) { }

	// RVA: 0x149BD80 Offset: 0x149AF80 VA: 0x18149BD80
	public void .ctor(byte value) { }

	// RVA: 0x1E3D330 Offset: 0x1E3C530 VA: 0x181E3D330 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E527C0 Offset: 0x1E519C0 VA: 0x181E527C0
	public byte get_Value() { }

	// RVA: 0x1E52E20 Offset: 0x1E52020 VA: 0x181E52E20
	public static SqlByte op_Implicit(byte x) { }

	// RVA: 0x1E52690 Offset: 0x1E51890 VA: 0x181E52690 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E52820 Offset: 0x1E51A20 VA: 0x181E52820
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0x1E53040 Offset: 0x1E52240 VA: 0x181E53040
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0x1E52F10 Offset: 0x1E52110 VA: 0x181E52F10
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0x1E52950 Offset: 0x1E51B50 VA: 0x181E52950
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0x1E52B50 Offset: 0x1E51D50 VA: 0x181E52B50
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0x1E52A70 Offset: 0x1E51C70 VA: 0x181E52A70
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0x1E52E30 Offset: 0x1E52030 VA: 0x181E52E30
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1E52D40 Offset: 0x1E51F40 VA: 0x181E52D40
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1E52160 Offset: 0x1E51360 VA: 0x181E52160
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1E52100 Offset: 0x1E51300 VA: 0x181E52100
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1E52400 Offset: 0x1E51600 VA: 0x181E52400
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1E52580 Offset: 0x1E51780 VA: 0x181E52580
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1E51CB0 Offset: 0x1E50EB0 VA: 0x181E51CB0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E51B40 Offset: 0x1E50D40 VA: 0x181E51B40
	public int CompareTo(SqlByte value) { }

	// RVA: 0x1E51DD0 Offset: 0x1E50FD0 VA: 0x181E51DD0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E51FD0 Offset: 0x1E511D0 VA: 0x181E51FD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E521C0 Offset: 0x1E513C0 VA: 0x181E521C0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E522E0 Offset: 0x1E514E0 VA: 0x181E522E0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E52090 Offset: 0x1E51290 VA: 0x181E52090
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E526F0 Offset: 0x1E518F0 VA: 0x181E526F0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal enum SqlBytesCharsState // TypeDefIndex: 12788
{
	// Fields
	public int value__; // 0x0
	public const SqlBytesCharsState Null = 0;
	public const SqlBytesCharsState Buffer = 1;
	public const SqlBytesCharsState Stream = 3;
}

// Namespace: System.Data.SqlTypes
[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 12789
{
	// Fields
	internal byte[] _rgbBuf; // 0x10
	private long _lCurLen; // 0x18
	internal Stream _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private byte[] _rgbWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public byte[] Buffer { get; }
	public long Length { get; }
	public byte[] Value { get; }
	public static SqlBytes Null { get; }

	// Methods

	// RVA: 0x1E53860 Offset: 0x1E52A60 VA: 0x181E53860
	public void .ctor() { }

	// RVA: 0x1E53960 Offset: 0x1E52B60 VA: 0x181E53960
	public void .ctor(byte[] buffer) { }

	// RVA: 0x1E53890 Offset: 0x1E52A90 VA: 0x181E53890
	public void .ctor(SqlBinary value) { }

	// RVA: 0x1E53B40 Offset: 0x1E52D40 VA: 0x181E53B40 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E539C0 Offset: 0x1E52BC0 VA: 0x181E539C0
	public byte[] get_Buffer() { }

	// RVA: 0x1E53B50 Offset: 0x1E52D50 VA: 0x181E53B50
	public long get_Length() { }

	// RVA: 0x1E53C40 Offset: 0x1E52E40 VA: 0x181E53C40
	public byte[] get_Value() { }

	// RVA: 0x1E53390 Offset: 0x1E52590 VA: 0x181E53390
	public void SetNull() { }

	// RVA: 0x1E53170 Offset: 0x1E52370 VA: 0x181E53170
	private void CopyStreamToBuffer() { }

	// RVA: 0x1E532E0 Offset: 0x1E524E0 VA: 0x181E532E0
	internal bool FStream() { }

	// RVA: 0x1E53360 Offset: 0x1E52560 VA: 0x181E53360
	private void SetBuffer(byte[] buffer) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E533F0 Offset: 0x1E525F0 VA: 0x181E533F0 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x1E53580 Offset: 0x1E52780 VA: 0x181E53580 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E532F0 Offset: 0x1E524F0 VA: 0x181E532F0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E533B0 Offset: 0x1E525B0 VA: 0x181E533B0 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E53BE0 Offset: 0x1E52DE0 VA: 0x181E53BE0
	public static SqlBytes get_Null() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[DefaultMember("Item")]
[Serializable]
public sealed class SqlChars : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 12790
{
	// Fields
	internal char[] _rgchBuf; // 0x10
	private long _lCurLen; // 0x18
	internal SqlStreamChars _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private char[] _rgchWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public char[] Buffer { get; }
	public long Length { get; }
	public char[] Value { get; }
	public static SqlChars Null { get; }

	// Methods

	// RVA: 0x1E53860 Offset: 0x1E52A60 VA: 0x181E53860
	public void .ctor() { }

	// RVA: 0x1E53960 Offset: 0x1E52B60 VA: 0x181E53960
	public void .ctor(char[] buffer) { }

	// RVA: 0x1E544B0 Offset: 0x1E536B0 VA: 0x181E544B0
	public void .ctor(SqlString value) { }

	// RVA: 0x1E53B40 Offset: 0x1E52D40 VA: 0x181E53B40 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E54580 Offset: 0x1E53780 VA: 0x181E54580
	public char[] get_Buffer() { }

	// RVA: 0x1E54700 Offset: 0x1E53900 VA: 0x181E54700
	public long get_Length() { }

	// RVA: 0x1E547F0 Offset: 0x1E539F0 VA: 0x181E547F0
	public char[] get_Value() { }

	// RVA: 0x1E53390 Offset: 0x1E52590 VA: 0x181E53390
	public void SetNull() { }

	// RVA: 0x1E532E0 Offset: 0x1E524E0 VA: 0x181E532E0
	internal bool FStream() { }

	// RVA: 0x1E53E80 Offset: 0x1E53080 VA: 0x181E53E80
	private void CopyStreamToBuffer() { }

	// RVA: 0x1E53360 Offset: 0x1E52560 VA: 0x181E53360
	private void SetBuffer(char[] buffer) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E540A0 Offset: 0x1E532A0 VA: 0x181E540A0 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x1E541E0 Offset: 0x1E533E0 VA: 0x181E541E0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E53FF0 Offset: 0x1E531F0 VA: 0x181E53FF0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E54060 Offset: 0x1E53260 VA: 0x181E54060 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E54790 Offset: 0x1E53990 VA: 0x181E54790
	public static SqlChars get_Null() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDateTime : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12791
{
	// Fields
	private bool m_fNotNull; // 0x0
	private int m_day; // 0x4
	private int m_time; // 0x8
	private static readonly double s_SQLTicksPerMillisecond; // 0x0
	public static readonly int SQLTicksPerSecond; // 0x8
	public static readonly int SQLTicksPerMinute; // 0xC
	public static readonly int SQLTicksPerHour; // 0x10
	private static readonly int s_SQLTicksPerDay; // 0x14
	private static readonly long s_ticksPerSecond; // 0x18
	private static readonly DateTime s_SQLBaseDate; // 0x20
	private static readonly long s_SQLBaseDateTicks; // 0x28
	private static readonly int s_minYear; // 0x30
	private static readonly int s_maxYear; // 0x34
	private static readonly int s_minDay; // 0x38
	private static readonly int s_maxDay; // 0x3C
	private static readonly int s_minTime; // 0x40
	private static readonly int s_maxTime; // 0x44
	private static readonly int s_dayBase; // 0x48
	private static readonly int[] s_daysToMonth365; // 0x50
	private static readonly int[] s_daysToMonth366; // 0x58
	private static readonly DateTime s_minDateTime; // 0x60
	private static readonly DateTime s_maxDateTime; // 0x68
	private static readonly TimeSpan s_minTimeSpan; // 0x70
	private static readonly TimeSpan s_maxTimeSpan; // 0x78
	private static readonly string s_ISO8601_DateTimeFormat; // 0x80
	private static readonly string[] s_dateTimeFormats; // 0x88
	public static readonly SqlDateTime MinValue; // 0x90
	public static readonly SqlDateTime MaxValue; // 0x9C
	public static readonly SqlDateTime Null; // 0xA8

	// Properties
	public bool IsNull { get; }
	public DateTime Value { get; }
	public int DayTicks { get; }
	public int TimeTicks { get; }

	// Methods

	// RVA: 0x1E562A0 Offset: 0x1E554A0 VA: 0x181E562A0
	private void .ctor(bool fNull) { }

	// RVA: 0x1E56230 Offset: 0x1E55430 VA: 0x181E56230
	public void .ctor(DateTime value) { }

	// RVA: 0x1E562B0 Offset: 0x1E554B0 VA: 0x181E562B0
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0x1E3D330 Offset: 0x1E3C530 VA: 0x181E3D330 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E55C40 Offset: 0x1E54E40 VA: 0x181E55C40
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0x1E55A60 Offset: 0x1E54C60 VA: 0x181E55A60
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0x1E550B0 Offset: 0x1E542B0 VA: 0x181E550B0
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0x1E54F80 Offset: 0x1E54180 VA: 0x181E54F80
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0x1E564A0 Offset: 0x1E556A0 VA: 0x181E564A0
	public DateTime get_Value() { }

	// RVA: 0x1E563E0 Offset: 0x1E555E0 VA: 0x181E563E0
	public int get_DayTicks() { }

	// RVA: 0x1E56440 Offset: 0x1E55640 VA: 0x181E56440
	public int get_TimeTicks() { }

	// RVA: 0x1E56720 Offset: 0x1E55920 VA: 0x181E56720
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0x1E55B70 Offset: 0x1E54D70 VA: 0x181E55B70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E56550 Offset: 0x1E55750 VA: 0x181E56550
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1E567A0 Offset: 0x1E559A0 VA: 0x181E567A0
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1E56630 Offset: 0x1E55830 VA: 0x181E56630
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1E55550 Offset: 0x1E54750 VA: 0x181E55550
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1E553D0 Offset: 0x1E545D0 VA: 0x181E553D0
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1E54A30 Offset: 0x1E53C30 VA: 0x181E54A30 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E54B70 Offset: 0x1E53D70 VA: 0x181E54B70
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0x1E54D40 Offset: 0x1E53F40 VA: 0x181E54D40 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E552C0 Offset: 0x1E544C0 VA: 0x181E552C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E556D0 Offset: 0x1E548D0 VA: 0x181E556D0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E55900 Offset: 0x1E54B00 VA: 0x181E55900 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E55360 Offset: 0x1E54560 VA: 0x181E55360
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E55CC0 Offset: 0x1E54EC0 VA: 0x181E55CC0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDecimal : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12792
{
	// Fields
	internal byte _bStatus; // 0x0
	internal byte _bLen; // 0x1
	internal byte _bPrec; // 0x2
	internal byte _bScale; // 0x3
	internal uint _data1; // 0x4
	internal uint _data2; // 0x8
	internal uint _data3; // 0xC
	internal uint _data4; // 0x10
	private static readonly byte s_NUMERIC_MAX_PRECISION; // 0x0
	public static readonly byte MaxPrecision; // 0x1
	public static readonly byte MaxScale; // 0x2
	private static readonly byte s_bNullMask; // 0x3
	private static readonly byte s_bIsNull; // 0x4
	private static readonly byte s_bNotNull; // 0x5
	private static readonly byte s_bReverseNullMask; // 0x6
	private static readonly byte s_bSignMask; // 0x7
	private static readonly byte s_bPositive; // 0x8
	private static readonly byte s_bNegative; // 0x9
	private static readonly byte s_bReverseSignMask; // 0xA
	private static readonly uint s_uiZero; // 0xC
	private static readonly int s_cNumeMax; // 0x10
	private static readonly long s_lInt32Base; // 0x18
	private static readonly ulong s_ulInt32Base; // 0x20
	private static readonly ulong s_ulInt32BaseForMod; // 0x28
	internal static readonly ulong s_llMax; // 0x30
	private static readonly uint s_ulBase10; // 0x38
	private static readonly double s_DUINT_BASE; // 0x40
	private static readonly double s_DUINT_BASE2; // 0x48
	private static readonly double s_DUINT_BASE3; // 0x50
	private static readonly double s_DMAX_NUME; // 0x58
	private static readonly uint s_DBL_DIG; // 0x60
	private static readonly byte s_cNumeDivScaleMin; // 0x64
	private static readonly uint[] s_rgulShiftBase; // 0x68
	private static readonly uint[] s_decimalHelpersLo; // 0x70
	private static readonly uint[] s_decimalHelpersMid; // 0x78
	private static readonly uint[] s_decimalHelpersHi; // 0x80
	private static readonly uint[] s_decimalHelpersHiHi; // 0x88
	private static readonly byte[] s_rgCLenFromPrec; // 0x90
	private static readonly uint s_ulT1; // 0x98
	private static readonly uint s_ulT2; // 0x9C
	private static readonly uint s_ulT3; // 0xA0
	private static readonly uint s_ulT4; // 0xA4
	private static readonly uint s_ulT5; // 0xA8
	private static readonly uint s_ulT6; // 0xAC
	private static readonly uint s_ulT7; // 0xB0
	private static readonly uint s_ulT8; // 0xB4
	private static readonly uint s_ulT9; // 0xB8
	private static readonly ulong s_dwlT10; // 0xC0
	private static readonly ulong s_dwlT11; // 0xC8
	private static readonly ulong s_dwlT12; // 0xD0
	private static readonly ulong s_dwlT13; // 0xD8
	private static readonly ulong s_dwlT14; // 0xE0
	private static readonly ulong s_dwlT15; // 0xE8
	private static readonly ulong s_dwlT16; // 0xF0
	private static readonly ulong s_dwlT17; // 0xF8
	private static readonly ulong s_dwlT18; // 0x100
	private static readonly ulong s_dwlT19; // 0x108
	public static readonly SqlDecimal Null; // 0x110
	public static readonly SqlDecimal MinValue; // 0x124
	public static readonly SqlDecimal MaxValue; // 0x138

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }
	public bool IsPositive { get; }
	public byte Scale { get; }
	public int[] Data { get; }

	// Methods

	// RVA: 0x1E57410 Offset: 0x1E56610 VA: 0x181E57410
	private byte CalculatePrecision() { }

	// RVA: 0x1E5B3B0 Offset: 0x1E5A5B0 VA: 0x181E5B3B0
	private bool VerifyPrecision(byte precision) { }

	// RVA: 0x1E5BFE0 Offset: 0x1E5B1E0 VA: 0x181E5BFE0
	private void .ctor(bool fNull) { }

	// RVA: 0x1E5C3C0 Offset: 0x1E5B5C0 VA: 0x181E5C3C0
	public void .ctor(Decimal value) { }

	// RVA: 0x1E5BD60 Offset: 0x1E5AF60 VA: 0x181E5BD60
	public void .ctor(int value) { }

	// RVA: 0x1E5C050 Offset: 0x1E5B250 VA: 0x181E5C050
	public void .ctor(long value) { }

	// RVA: 0x1E5C150 Offset: 0x1E5B350 VA: 0x181E5C150
	private void .ctor(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	// RVA: 0x1E5C680 Offset: 0x1E5B880 VA: 0x181E5C680 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E5C8E0 Offset: 0x1E5BAE0 VA: 0x181E5C8E0
	public Decimal get_Value() { }

	// RVA: 0x1E5C6E0 Offset: 0x1E5B8E0 VA: 0x181E5C6E0
	public bool get_IsPositive() { }

	// RVA: 0x1E5A2D0 Offset: 0x1E594D0 VA: 0x181E5A2D0
	private void SetPositive() { }

	// RVA: 0x1E5A340 Offset: 0x1E59540 VA: 0x181E5A340
	private void SetSignBit(bool fPositive) { }

	// RVA: 0x1E5C7F0 Offset: 0x1E5B9F0 VA: 0x181E5C7F0
	public byte get_Scale() { }

	// RVA: 0x1E5C540 Offset: 0x1E5B740 VA: 0x181E5C540
	public int[] get_Data() { }

	// RVA: 0x1E5AF80 Offset: 0x1E5A180 VA: 0x181E5AF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E59B70 Offset: 0x1E58D70 VA: 0x181E59B70
	public static SqlDecimal Parse(string s) { }

	// RVA: 0x1E5A980 Offset: 0x1E59B80 VA: 0x181E5A980
	public double ToDouble() { }

	// RVA: 0x1E5A7C0 Offset: 0x1E599C0 VA: 0x181E5A7C0
	private Decimal ToDecimal() { }

	// RVA: 0x1E5DB40 Offset: 0x1E5CD40 VA: 0x181E5DB40
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0x1E5DB80 Offset: 0x1E5CD80 VA: 0x181E5DB80
	public static SqlDecimal op_Implicit(long x) { }

	// RVA: 0x1E5F220 Offset: 0x1E5E420 VA: 0x181E5F220
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0x1E5C950 Offset: 0x1E5BB50 VA: 0x181E5C950
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1E5EFB0 Offset: 0x1E5E1B0 VA: 0x181E5EFB0
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1E5E250 Offset: 0x1E5D450 VA: 0x181E5E250
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1E5D180 Offset: 0x1E5C380 VA: 0x181E5D180
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1E5DDD0 Offset: 0x1E5CFD0 VA: 0x181E5DDD0
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0x1E5DBD0 Offset: 0x1E5CDD0 VA: 0x181E5DBD0
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0x1E5DFA0 Offset: 0x1E5D1A0 VA: 0x181E5DFA0
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0x1E5DCB0 Offset: 0x1E5CEB0 VA: 0x181E5DCB0
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0x1E5DEB0 Offset: 0x1E5D0B0 VA: 0x181E5DEB0
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0x1E5B5F0 Offset: 0x1E5A7F0 VA: 0x181E5B5F0
	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) { }

	// RVA: 0x1E583C0 Offset: 0x1E575C0 VA: 0x181E583C0
	private bool FZero() { }

	// RVA: 0x1E58330 Offset: 0x1E57530 VA: 0x181E58330
	private bool FGt10_38() { }

	// RVA: 0x1E58370 Offset: 0x1E57570 VA: 0x181E58370
	private bool FGt10_38(uint[] rglData) { }

	// RVA: 0x1E56EE0 Offset: 0x1E560E0 VA: 0x181E56EE0
	private static byte BGetPrecUI4(uint value) { }

	// RVA: 0x1E57080 Offset: 0x1E56280 VA: 0x181E57080
	private static byte BGetPrecUI8(ulong dwlVal) { }

	// RVA: 0x1E56890 Offset: 0x1E55A90 VA: 0x181E56890
	private void AddULong(uint ulAdd) { }

	// RVA: 0x1E598A0 Offset: 0x1E58AA0 VA: 0x181E598A0
	private void MultByULong(uint uiMultiplier) { }

	// RVA: 0x1E57D50 Offset: 0x1E56F50 VA: 0x181E57D50
	private uint DivByULong(uint iDivisor) { }

	// RVA: 0x1E56B10 Offset: 0x1E55D10 VA: 0x181E56B10
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0x1E58640 Offset: 0x1E57840 VA: 0x181E58640
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0x1E596F0 Offset: 0x1E588F0 VA: 0x181E596F0
	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) { }

	// RVA: 0x1E59870 Offset: 0x1E58A70 VA: 0x181E59870
	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) { }

	// RVA: 0x1E59830 Offset: 0x1E58A30 VA: 0x181E59830
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0x1E59760 Offset: 0x1E58960 VA: 0x181E59760
	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) { }

	// RVA: 0x1E58880 Offset: 0x1E57A80 VA: 0x181E58880
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0x1E57D40 Offset: 0x1E56F40 VA: 0x181E57D40
	internal static ulong DWL(uint lo, uint hi) { }

	// RVA: 0x17A52A0 Offset: 0x17A44A0 VA: 0x1817A52A0
	private static uint HI(ulong x) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	private static uint LO(ulong x) { }

	// RVA: 0x1E58980 Offset: 0x1E57B80 VA: 0x181E58980
	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) { }

	// RVA: 0x1E57770 Offset: 0x1E56970 VA: 0x181E57770
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0x1E57690 Offset: 0x1E56890 VA: 0x181E57690
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	// RVA: 0x1E5D800 Offset: 0x1E5CA00 VA: 0x181E5D800
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1E5E0B0 Offset: 0x1E5D2B0 VA: 0x181E5E0B0
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1E5D9A0 Offset: 0x1E5CBA0 VA: 0x181E5D9A0
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1E58800 Offset: 0x1E57A00 VA: 0x181E58800
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1E585C0 Offset: 0x1E577C0 VA: 0x181E585C0
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1E5AB60 Offset: 0x1E59D60 VA: 0x181E5AB60
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1E5AD30 Offset: 0x1E59F30 VA: 0x181E5AD30
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1E5ADB0 Offset: 0x1E59FB0 VA: 0x181E5ADB0
	public SqlMoney ToSqlMoney() { }

	// RVA: 0x1E57680 Offset: 0x1E56880 VA: 0x181E57680
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x1E5A460 Offset: 0x1E59660 VA: 0x181E5A460
	private void StoreFromWorkingArray(uint[] rguiData) { }

	// RVA: 0x1E5A3F0 Offset: 0x1E595F0 VA: 0x181E5A3F0
	private void SetToZero() { }

	// RVA: 0x1E57C10 Offset: 0x1E56E10 VA: 0x181E57C10 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E57950 Offset: 0x1E56B50 VA: 0x181E57950
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0x1E57F40 Offset: 0x1E57140 VA: 0x181E57F40 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E583E0 Offset: 0x1E575E0 VA: 0x181E583E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E5A4B0 Offset: 0x1E596B0 VA: 0x181E5A4B0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E5A660 Offset: 0x1E59860 VA: 0x181E5A660 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E58550 Offset: 0x1E57750 VA: 0x181E58550
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E5B670 Offset: 0x1E5A870 VA: 0x181E5B670
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDouble : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12793
{
	// Fields
	private bool m_fNotNull; // 0x0
	private double m_value; // 0x8
	public static readonly SqlDouble Null; // 0x0
	public static readonly SqlDouble Zero; // 0x10
	public static readonly SqlDouble MinValue; // 0x20
	public static readonly SqlDouble MaxValue; // 0x30

	// Properties
	public bool IsNull { get; }
	public double Value { get; }

	// Methods

	// RVA: 0x1E60410 Offset: 0x1E5F610 VA: 0x181E60410
	private void .ctor(bool fNull) { }

	// RVA: 0x1E60380 Offset: 0x1E5F580 VA: 0x181E60380
	public void .ctor(double value) { }

	// RVA: 0x1E3D330 Offset: 0x1E3C530 VA: 0x181E3D330 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E60420 Offset: 0x1E5F620 VA: 0x181E60420
	public double get_Value() { }

	// RVA: 0x1E60C50 Offset: 0x1E5FE50 VA: 0x181E60C50
	public static SqlDouble op_Implicit(double x) { }

	// RVA: 0x1E60110 Offset: 0x1E5F310 VA: 0x181E60110 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E61360 Offset: 0x1E60560 VA: 0x181E61360
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0x1E60480 Offset: 0x1E5F680 VA: 0x181E60480
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1E61210 Offset: 0x1E60410 VA: 0x181E61210
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1E610C0 Offset: 0x1E602C0 VA: 0x181E610C0
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1E605D0 Offset: 0x1E5F7D0 VA: 0x181E605D0
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1E60F10 Offset: 0x1E60110 VA: 0x181E60F10
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0x1E60E40 Offset: 0x1E60040 VA: 0x181E60E40
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0x1E60C70 Offset: 0x1E5FE70 VA: 0x181E60C70
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0x1E60950 Offset: 0x1E5FB50 VA: 0x181E60950
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0x1E60D70 Offset: 0x1E5FF70 VA: 0x181E60D70
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0x1E60B80 Offset: 0x1E5FD80 VA: 0x181E60B80
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0x1E60A60 Offset: 0x1E5FC60 VA: 0x181E60A60
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0x1E60780 Offset: 0x1E5F980 VA: 0x181E60780
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1E60FF0 Offset: 0x1E601F0 VA: 0x181E60FF0
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1E60880 Offset: 0x1E5FA80 VA: 0x181E60880
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1E5FC10 Offset: 0x1E5EE10 VA: 0x181E5FC10
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1E5FAF0 Offset: 0x1E5ECF0 VA: 0x181E5FAF0
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1E5FF80 Offset: 0x1E5F180 VA: 0x181E5FF80
	public SqlSingle ToSqlSingle() { }

	// RVA: 0x1E5F420 Offset: 0x1E5E620 VA: 0x181E5F420 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E5F550 Offset: 0x1E5E750 VA: 0x181E5F550
	public int CompareTo(SqlDouble value) { }

	// RVA: 0x1E5F780 Offset: 0x1E5E980 VA: 0x181E5F780 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E5F9B0 Offset: 0x1E5EBB0 VA: 0x181E5F9B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E5FD30 Offset: 0x1E5EF30 VA: 0x181E5FD30 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E5FE50 Offset: 0x1E5F050 VA: 0x181E5FE50 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E5FA80 Offset: 0x1E5EC80 VA: 0x181E5FA80
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E60170 Offset: 0x1E5F370 VA: 0x181E60170
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlGuid : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12794
{
	// Fields
	private static readonly int s_sizeOfGuid; // 0x0
	private static readonly int[] s_rgiGuidOrder; // 0x8
	private byte[] m_value; // 0x0
	public static readonly SqlGuid Null; // 0x10

	// Properties
	public bool IsNull { get; }
	public Guid Value { get; }

	// Methods

	// RVA: 0x169ECB0 Offset: 0x169DEB0 VA: 0x18169ECB0
	private void .ctor(bool fNull) { }

	// RVA: 0x1E62020 Offset: 0x1E61220 VA: 0x181E62020
	public void .ctor(Guid g) { }

	// RVA: 0x12175A0 Offset: 0x12167A0 VA: 0x1812175A0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E62040 Offset: 0x1E61240 VA: 0x181E62040
	public Guid get_Value() { }

	// RVA: 0x1E622D0 Offset: 0x1E614D0 VA: 0x181E622D0
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0x1E61EF0 Offset: 0x1E610F0 VA: 0x181E61EF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E61810 Offset: 0x1E60A10 VA: 0x181E61810
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1E620F0 Offset: 0x1E612F0 VA: 0x181E620F0
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1E622F0 Offset: 0x1E614F0 VA: 0x181E622F0
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1E621E0 Offset: 0x1E613E0 VA: 0x181E621E0
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1E61410 Offset: 0x1E60610 VA: 0x181E61410 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E61530 Offset: 0x1E60730 VA: 0x181E61530
	public int CompareTo(SqlGuid value) { }

	// RVA: 0x1E61920 Offset: 0x1E60B20 VA: 0x181E61920 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E61B00 Offset: 0x1E60D00 VA: 0x181E61B00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E61C80 Offset: 0x1E60E80 VA: 0x181E61C80 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E61DB0 Offset: 0x1E60FB0 VA: 0x181E61DB0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E61C10 Offset: 0x1E60E10 VA: 0x181E61C10
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E61F70 Offset: 0x1E61170 VA: 0x181E61F70
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt16 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12795
{
	// Fields
	private bool m_fNotNull; // 0x0
	private short m_value; // 0x2
	private static readonly int s_MASKI2; // 0x0
	public static readonly SqlInt16 Null; // 0x4
	public static readonly SqlInt16 Zero; // 0x8
	public static readonly SqlInt16 MinValue; // 0xC
	public static readonly SqlInt16 MaxValue; // 0x10

	// Properties
	public bool IsNull { get; }
	public short Value { get; }

	// Methods

	// RVA: 0x1E63040 Offset: 0x1E62240 VA: 0x181E63040
	private void .ctor(bool fNull) { }

	// RVA: 0x14AC280 Offset: 0x14AB480 VA: 0x1814AC280
	public void .ctor(short value) { }

	// RVA: 0x1E3D330 Offset: 0x1E3C530 VA: 0x181E3D330 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E63050 Offset: 0x1E62250 VA: 0x181E63050
	public short get_Value() { }

	// RVA: 0x1E63720 Offset: 0x1E62920 VA: 0x181E63720
	public static SqlInt16 op_Implicit(short x) { }

	// RVA: 0x1E62F20 Offset: 0x1E62120 VA: 0x181E62F20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E63AA0 Offset: 0x1E62CA0 VA: 0x181E63AA0
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0x1E630B0 Offset: 0x1E622B0 VA: 0x181E630B0
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1E63980 Offset: 0x1E62B80 VA: 0x181E63980
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1E63820 Offset: 0x1E62A20 VA: 0x181E63820
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1E631D0 Offset: 0x1E623D0 VA: 0x181E631D0
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1E63660 Offset: 0x1E62860 VA: 0x181E63660
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0x1E63430 Offset: 0x1E62630 VA: 0x181E63430
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0x1E63350 Offset: 0x1E62550 VA: 0x181E63350
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1E63740 Offset: 0x1E62940 VA: 0x181E63740
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1E63580 Offset: 0x1E62780 VA: 0x181E63580
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1E62A00 Offset: 0x1E61C00 VA: 0x181E62A00
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1E629A0 Offset: 0x1E61BA0 VA: 0x181E629A0
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1E62CA0 Offset: 0x1E61EA0 VA: 0x181E62CA0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1E62E10 Offset: 0x1E62010 VA: 0x181E62E10
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1E623E0 Offset: 0x1E615E0 VA: 0x181E623E0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E62500 Offset: 0x1E61700 VA: 0x181E62500
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0x1E62670 Offset: 0x1E61870 VA: 0x181E62670 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E62870 Offset: 0x1E61A70 VA: 0x181E62870 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E62A60 Offset: 0x1E61C60 VA: 0x181E62A60 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E62B80 Offset: 0x1E61D80 VA: 0x181E62B80 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E62930 Offset: 0x1E61B30 VA: 0x181E62930
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E62F80 Offset: 0x1E62180 VA: 0x181E62F80
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt32 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12796
{
	// Fields
	private bool m_fNotNull; // 0x0
	private int m_value; // 0x4
	private static readonly long s_iIntMin; // 0x0
	private static readonly long s_lBitNotIntMax; // 0x8
	public static readonly SqlInt32 Null; // 0x10
	public static readonly SqlInt32 Zero; // 0x18
	public static readonly SqlInt32 MinValue; // 0x20
	public static readonly SqlInt32 MaxValue; // 0x28

	// Properties
	public bool IsNull { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x1E647F0 Offset: 0x1E639F0 VA: 0x181E647F0
	private void .ctor(bool fNull) { }

	// RVA: 0xB54A50 Offset: 0xB53C50 VA: 0x180B54A50
	public void .ctor(int value) { }

	// RVA: 0x1E3D330 Offset: 0x1E3C530 VA: 0x181E3D330 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E64800 Offset: 0x1E63A00 VA: 0x181E64800
	public int get_Value() { }

	// RVA: 0x1E64F70 Offset: 0x1E64170 VA: 0x181E64F70
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0x1E646B0 Offset: 0x1E638B0 VA: 0x181E646B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E653D0 Offset: 0x1E645D0 VA: 0x181E653D0
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0x1E64890 Offset: 0x1E63A90 VA: 0x181E64890
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1E65290 Offset: 0x1E64490 VA: 0x181E65290
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1E65130 Offset: 0x1E64330 VA: 0x181E65130
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1E649F0 Offset: 0x1E63BF0 VA: 0x181E649F0
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1E64EB0 Offset: 0x1E640B0 VA: 0x181E64EB0
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0x1E64F90 Offset: 0x1E64190 VA: 0x181E64F90
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0x1E64C70 Offset: 0x1E63E70 VA: 0x181E64C70
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0x1E64180 Offset: 0x1E63380 VA: 0x181E64180
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0x1E64B90 Offset: 0x1E63D90 VA: 0x181E64B90
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1E65050 Offset: 0x1E64250 VA: 0x181E65050
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1E64DD0 Offset: 0x1E63FD0 VA: 0x181E64DD0
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1E64120 Offset: 0x1E63320 VA: 0x181E64120
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1E640C0 Offset: 0x1E632C0 VA: 0x181E640C0
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1E643D0 Offset: 0x1E635D0 VA: 0x181E643D0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1E64570 Offset: 0x1E63770 VA: 0x181E64570
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1E63CB0 Offset: 0x1E62EB0 VA: 0x181E63CB0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E63B40 Offset: 0x1E62D40 VA: 0x181E63B40
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0x1E63DD0 Offset: 0x1E62FD0 VA: 0x181E63DD0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E63FD0 Offset: 0x1E631D0 VA: 0x181E63FD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E64190 Offset: 0x1E63390 VA: 0x181E64190 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E642B0 Offset: 0x1E634B0 VA: 0x181E642B0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E64050 Offset: 0x1E63250 VA: 0x181E64050
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E64710 Offset: 0x1E63910 VA: 0x181E64710
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt64 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12797
{
	// Fields
	private bool m_fNotNull; // 0x0
	private long m_value; // 0x8
	private static readonly long s_lLowIntMask; // 0x0
	private static readonly long s_lHighIntMask; // 0x8
	public static readonly SqlInt64 Null; // 0x10
	public static readonly SqlInt64 Zero; // 0x20
	public static readonly SqlInt64 MinValue; // 0x30
	public static readonly SqlInt64 MaxValue; // 0x40

	// Properties
	public bool IsNull { get; }
	public long Value { get; }

	// Methods

	// RVA: 0x1E60410 Offset: 0x1E5F610 VA: 0x181E60410
	private void .ctor(bool fNull) { }

	// RVA: 0xB54900 Offset: 0xB53B00 VA: 0x180B54900
	public void .ctor(long value) { }

	// RVA: 0x1E3D330 Offset: 0x1E3C530 VA: 0x181E3D330 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E666A0 Offset: 0x1E658A0 VA: 0x181E666A0
	public long get_Value() { }

	// RVA: 0x1E670F0 Offset: 0x1E662F0 VA: 0x181E670F0
	public static SqlInt64 op_Implicit(long x) { }

	// RVA: 0x1E66550 Offset: 0x1E65750 VA: 0x181E66550 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E67820 Offset: 0x1E66A20 VA: 0x181E67820
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0x1E66700 Offset: 0x1E65900 VA: 0x181E66700
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1E676A0 Offset: 0x1E668A0 VA: 0x181E676A0
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1E67370 Offset: 0x1E66570 VA: 0x181E67370
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1E66870 Offset: 0x1E65A70 VA: 0x181E66870
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1E671E0 Offset: 0x1E663E0 VA: 0x181E671E0
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1E67020 Offset: 0x1E66220 VA: 0x181E67020
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0x1E66F50 Offset: 0x1E66150 VA: 0x181E66F50
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0x1E66E50 Offset: 0x1E66050 VA: 0x181E66E50
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0x1E66AD0 Offset: 0x1E65CD0 VA: 0x181E66AD0
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0x1E65D30 Offset: 0x1E64F30 VA: 0x181E65D30
	private static bool SameSignLong(long x, long y) { }

	// RVA: 0x1E66A00 Offset: 0x1E65C00 VA: 0x181E66A00
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1E67110 Offset: 0x1E66310 VA: 0x181E67110
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1E66D80 Offset: 0x1E65F80 VA: 0x181E66D80
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1E65C30 Offset: 0x1E64E30 VA: 0x181E65C30
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1E65B30 Offset: 0x1E64D30 VA: 0x181E65B30
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1E65F90 Offset: 0x1E65190 VA: 0x181E65F90
	public SqlByte ToSqlByte() { }

	// RVA: 0x1E66110 Offset: 0x1E65310 VA: 0x181E66110
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1E66290 Offset: 0x1E65490 VA: 0x181E66290
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0x1E663F0 Offset: 0x1E655F0 VA: 0x181E663F0
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0x1E65FF0 Offset: 0x1E651F0 VA: 0x181E65FF0
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x1E656A0 Offset: 0x1E648A0 VA: 0x181E656A0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E65470 Offset: 0x1E64670 VA: 0x181E65470
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0x1E657D0 Offset: 0x1E649D0 VA: 0x181E657D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E65A00 Offset: 0x1E64C00 VA: 0x181E65A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E65D50 Offset: 0x1E64F50 VA: 0x181E65D50 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E65E70 Offset: 0x1E65070 VA: 0x181E65E70 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E65AC0 Offset: 0x1E64CC0 VA: 0x181E65AC0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E665B0 Offset: 0x1E657B0 VA: 0x181E665B0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlMoney : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12798
{
	// Fields
	private bool _fNotNull; // 0x0
	private long _value; // 0x8
	internal static readonly int s_iMoneyScale; // 0x0
	private static readonly long s_lTickBase; // 0x8
	private static readonly double s_dTickBase; // 0x10
	private static readonly long s_minLong; // 0x18
	private static readonly long s_maxLong; // 0x20
	public static readonly SqlMoney Null; // 0x28
	public static readonly SqlMoney Zero; // 0x38
	public static readonly SqlMoney MinValue; // 0x48
	public static readonly SqlMoney MaxValue; // 0x58

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }

	// Methods

	// RVA: 0x1E60410 Offset: 0x1E5F610 VA: 0x181E60410
	private void .ctor(bool fNull) { }

	// RVA: 0xB54900 Offset: 0xB53B00 VA: 0x180B54900
	internal void .ctor(long value, int ignored) { }

	// RVA: 0x1E68C20 Offset: 0x1E67E20 VA: 0x181E68C20
	public void .ctor(int value) { }

	// RVA: 0x1E68B20 Offset: 0x1E67D20 VA: 0x181E68B20
	public void .ctor(long value) { }

	// RVA: 0x1E68C90 Offset: 0x1E67E90 VA: 0x181E68C90
	public void .ctor(Decimal value) { }

	// RVA: 0x1E3D330 Offset: 0x1E3C530 VA: 0x181E3D330 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E68E80 Offset: 0x1E68080 VA: 0x181E68E80
	public Decimal get_Value() { }

	// RVA: 0x1E68400 Offset: 0x1E67600 VA: 0x181E68400
	public Decimal ToDecimal() { }

	// RVA: 0x1E68510 Offset: 0x1E67710 VA: 0x181E68510
	public double ToDouble() { }

	// RVA: 0x1E69610 Offset: 0x1E68810 VA: 0x181E69610
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0x1E69810 Offset: 0x1E68A10 VA: 0x181E69810
	public static SqlMoney op_Implicit(long x) { }

	// RVA: 0x1E688D0 Offset: 0x1E67AD0 VA: 0x181E688D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E69D40 Offset: 0x1E68F40 VA: 0x181E69D40
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0x1E68F30 Offset: 0x1E68130 VA: 0x181E68F30
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1E69BB0 Offset: 0x1E68DB0 VA: 0x181E69BB0
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1E69A40 Offset: 0x1E68C40 VA: 0x181E69A40
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1E690C0 Offset: 0x1E682C0 VA: 0x181E690C0
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1E69740 Offset: 0x1E68940 VA: 0x181E69740
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0x1E69540 Offset: 0x1E68740 VA: 0x181E69540
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0x1E69640 Offset: 0x1E68840 VA: 0x181E69640
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0x1E69860 Offset: 0x1E68A60 VA: 0x181E69860
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0x1E69300 Offset: 0x1E68500 VA: 0x181E69300
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0x1E69230 Offset: 0x1E68430 VA: 0x181E69230
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1E69970 Offset: 0x1E68B70 VA: 0x181E69970
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1E69470 Offset: 0x1E68670 VA: 0x181E69470
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1E68030 Offset: 0x1E67230 VA: 0x181E68030
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1E67F30 Offset: 0x1E67130 VA: 0x181E67F30
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1E686E0 Offset: 0x1E678E0 VA: 0x181E686E0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1E685A0 Offset: 0x1E677A0 VA: 0x181E685A0
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x1E67B00 Offset: 0x1E66D00 VA: 0x181E67B00 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E678D0 Offset: 0x1E66AD0 VA: 0x181E678D0
	public int CompareTo(SqlMoney value) { }

	// RVA: 0x1E67C30 Offset: 0x1E66E30 VA: 0x181E67C30 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E67E60 Offset: 0x1E67060 VA: 0x181E67E60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E68130 Offset: 0x1E67330 VA: 0x181E68130 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E682B0 Offset: 0x1E674B0 VA: 0x181E682B0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E67EC0 Offset: 0x1E670C0 VA: 0x181E67EC0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E689A0 Offset: 0x1E67BA0 VA: 0x181E689A0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlSingle : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12799
{
	// Fields
	private bool _fNotNull; // 0x0
	private float _value; // 0x4
	public static readonly SqlSingle Null; // 0x0
	public static readonly SqlSingle Zero; // 0x8
	public static readonly SqlSingle MinValue; // 0x10
	public static readonly SqlSingle MaxValue; // 0x18

	// Properties
	public bool IsNull { get; }
	public float Value { get; }

	// Methods

	// RVA: 0x1E647F0 Offset: 0x1E639F0 VA: 0x181E647F0
	private void .ctor(bool fNull) { }

	// RVA: 0x1E6ADC0 Offset: 0x1E69FC0 VA: 0x181E6ADC0
	public void .ctor(float value) { }

	// RVA: 0x1E6AD60 Offset: 0x1E69F60 VA: 0x181E6AD60
	public void .ctor(double value) { }

	// RVA: 0x1E3D330 Offset: 0x1E3C530 VA: 0x181E3D330 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E6AE40 Offset: 0x1E6A040 VA: 0x181E6AE40
	public float get_Value() { }

	// RVA: 0x1E6BBE0 Offset: 0x1E6ADE0 VA: 0x181E6BBE0
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x1E6AB10 Offset: 0x1E69D10 VA: 0x181E6AB10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E6C1C0 Offset: 0x1E6B3C0 VA: 0x181E6C1C0
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0x1E6AEA0 Offset: 0x1E6A0A0 VA: 0x181E6AEA0
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1E6C030 Offset: 0x1E6B230 VA: 0x181E6C030
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1E6BEA0 Offset: 0x1E6B0A0 VA: 0x181E6BEA0
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1E6B030 Offset: 0x1E6A230 VA: 0x181E6B030
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1E6BAC0 Offset: 0x1E6ACC0 VA: 0x181E6BAC0
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0x1E6B9A0 Offset: 0x1E6ABA0 VA: 0x181E6B9A0
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0x1E6BC70 Offset: 0x1E6AE70 VA: 0x181E6BC70
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0x1E6B840 Offset: 0x1E6AA40 VA: 0x181E6B840
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0x1E6B530 Offset: 0x1E6A730 VA: 0x181E6B530
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0x1E6B690 Offset: 0x1E6A890 VA: 0x181E6B690
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0x1E6B2C0 Offset: 0x1E6A4C0 VA: 0x181E6B2C0
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0x1E6B1C0 Offset: 0x1E6A3C0 VA: 0x181E6B1C0
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1E6BDC0 Offset: 0x1E6AFC0 VA: 0x181E6BDC0
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1E6B450 Offset: 0x1E6A650 VA: 0x181E6B450
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1E6A6F0 Offset: 0x1E698F0 VA: 0x181E6A6F0
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1E6A690 Offset: 0x1E69890 VA: 0x181E6A690
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1E6A9A0 Offset: 0x1E69BA0 VA: 0x181E6A9A0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1E6A230 Offset: 0x1E69430 VA: 0x181E6A230 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E6A0C0 Offset: 0x1E692C0 VA: 0x181E6A0C0
	public int CompareTo(SqlSingle value) { }

	// RVA: 0x1E6A350 Offset: 0x1E69550 VA: 0x181E6A350 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E6A560 Offset: 0x1E69760 VA: 0x181E6A560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E6A750 Offset: 0x1E69950 VA: 0x181E6A750 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E6A870 Offset: 0x1E69A70 VA: 0x181E6A870 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E6A620 Offset: 0x1E69820 VA: 0x181E6A620
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E6AB70 Offset: 0x1E69D70 VA: 0x181E6AB70
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[Flags]
public enum SqlCompareOptions // TypeDefIndex: 12800
{
	// Fields
	public int value__; // 0x0
	public const SqlCompareOptions None = 0;
	public const SqlCompareOptions IgnoreCase = 1;
	public const SqlCompareOptions IgnoreNonSpace = 2;
	public const SqlCompareOptions IgnoreKanaType = 8;
	public const SqlCompareOptions IgnoreWidth = 16;
	public const SqlCompareOptions BinarySort = 32768;
	public const SqlCompareOptions BinarySort2 = 16384;
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlString : INullable, IComparable, IXmlSerializable // TypeDefIndex: 12801
{
	// Fields
	private string m_value; // 0x0
	private CompareInfo m_cmpInfo; // 0x8
	private int m_lcid; // 0x10
	private SqlCompareOptions m_flag; // 0x14
	private bool m_fNotNull; // 0x18
	public static readonly SqlString Null; // 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; // 0x20
	public static readonly int IgnoreCase; // 0x28
	public static readonly int IgnoreWidth; // 0x2C
	public static readonly int IgnoreNonSpace; // 0x30
	public static readonly int IgnoreKanaType; // 0x34
	public static readonly int BinarySort; // 0x38
	public static readonly int BinarySort2; // 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; // 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; // 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; // 0x48
	internal static readonly int s_lcidUSEnglish; // 0x4C
	private static readonly int s_lcidBinary; // 0x50

	// Properties
	public bool IsNull { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1E6DC70 Offset: 0x1E6CE70 VA: 0x181E6DC70
	private void .ctor(bool fNull) { }

	// RVA: 0x1E6DA20 Offset: 0x1E6CC20 VA: 0x181E6DA20
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0x1E6DAB0 Offset: 0x1E6CCB0 VA: 0x181E6DAB0
	public void .ctor(string data) { }

	// RVA: 0x1E6DBE0 Offset: 0x1E6CDE0 VA: 0x181E6DBE0
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0x195C130 Offset: 0x195B330 VA: 0x18195C130 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E6DC90 Offset: 0x1E6CE90 VA: 0x181E6DC90
	public string get_Value() { }

	// RVA: 0x1E6D110 Offset: 0x1E6C310 VA: 0x181E6D110
	private void SetCompareInfo() { }

	// RVA: 0x1E6E090 Offset: 0x1E6D290 VA: 0x181E6E090
	public static SqlString op_Implicit(string x) { }

	// RVA: 0x1E6D790 Offset: 0x1E6C990 VA: 0x181E6D790 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E6DD20 Offset: 0x1E6CF20 VA: 0x181E6DD20
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0x1E6D1A0 Offset: 0x1E6C3A0 VA: 0x181E6D1A0
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0x1E6C980 Offset: 0x1E6BB80 VA: 0x181E6C980
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0x1E6DF30 Offset: 0x1E6D130 VA: 0x181E6DF30
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0x1E6D7F0 Offset: 0x1E6C9F0 VA: 0x181E6D7F0
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x1E6C650 Offset: 0x1E6B850 VA: 0x181E6C650
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x1E6CE00 Offset: 0x1E6C000 VA: 0x181E6CE00
	private bool FBinarySort() { }

	// RVA: 0x1E6C420 Offset: 0x1E6B620 VA: 0x181E6C420
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0x1E6C2C0 Offset: 0x1E6B4C0 VA: 0x181E6C2C0
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0x1E6C710 Offset: 0x1E6B910 VA: 0x181E6C710 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1E6C850 Offset: 0x1E6BA50 VA: 0x181E6C850
	public int CompareTo(SqlString value) { }

	// RVA: 0x1E6CAF0 Offset: 0x1E6BCF0 VA: 0x181E6CAF0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E6CE60 Offset: 0x1E6C060 VA: 0x181E6CE60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E6D5B0 Offset: 0x1E6C7B0 VA: 0x181E6D5B0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1E6D6B0 Offset: 0x1E6C8B0 VA: 0x181E6D6B0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E6D0A0 Offset: 0x1E6C2A0 VA: 0x181E6D0A0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E6D8A0 Offset: 0x1E6CAA0 VA: 0x181E6D8A0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal enum EComparison // TypeDefIndex: 12802
{
	// Fields
	public int value__; // 0x0
	public const EComparison LT = 0;
	public const EComparison LE = 1;
	public const EComparison EQ = 2;
	public const EComparison GE = 3;
	public const EComparison GT = 4;
	public const EComparison NE = 5;
}

// Namespace: System.Data.SqlTypes
[Serializable]
public class SqlTypeException : SystemException // TypeDefIndex: 12803
{
	// Methods

	// RVA: 0x1E6E450 Offset: 0x1E6D650 VA: 0x181E6E450
	public void .ctor() { }

	// RVA: 0x1E6E420 Offset: 0x1E6D620 VA: 0x181E6E420
	public void .ctor(string message) { }

	// RVA: 0x1E6E400 Offset: 0x1E6D600 VA: 0x181E6E400
	public void .ctor(string message, Exception e) { }

	// RVA: 0x1E6E4A0 Offset: 0x1E6D6A0 VA: 0x181E6E4A0
	protected void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x1E6E320 Offset: 0x1E6D520 VA: 0x181E6E320
	private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlNullValueException : SqlTypeException // TypeDefIndex: 12804
{
	// Methods

	// RVA: 0x1E69F40 Offset: 0x1E69140 VA: 0x181E69F40
	public void .ctor() { }

	// RVA: 0x1E6A090 Offset: 0x1E69290 VA: 0x181E6A090
	public void .ctor(string message) { }

	// RVA: 0x1E69F70 Offset: 0x1E69170 VA: 0x181E69F70
	public void .ctor(string message, Exception e) { }

	// RVA: 0x1E69F90 Offset: 0x1E69190 VA: 0x181E69F90
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x1E69E60 Offset: 0x1E69060 VA: 0x181E69E60
	private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlTruncateException : SqlTypeException // TypeDefIndex: 12805
{
	// Methods

	// RVA: 0x1E6E1C0 Offset: 0x1E6D3C0 VA: 0x181E6E1C0
	public void .ctor() { }

	// RVA: 0x1E6E2F0 Offset: 0x1E6D4F0 VA: 0x181E6E2F0
	public void .ctor(string message) { }

	// RVA: 0x1E6E1A0 Offset: 0x1E6D3A0 VA: 0x181E6E1A0
	public void .ctor(string message, Exception e) { }

	// RVA: 0x1E6E1F0 Offset: 0x1E6D3F0 VA: 0x181E6E1F0
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x1E6E0C0 Offset: 0x1E6D2C0 VA: 0x181E6E0C0
	private static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
internal abstract class SqlStreamChars // TypeDefIndex: 12806
{
	// Properties
	public abstract long Length { get; }
	public abstract long Position { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int Read(char[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long Seek(long offset, SeekOrigin origin);
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public sealed class SqlXml : INullable, IXmlSerializable // TypeDefIndex: 12807
{
	// Fields
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; // 0x0
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; // 0x8
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; // 0x10
	private static MethodInfo s_createSqlReaderMethodInfo; // 0x18
	private MethodInfo _createSqlReaderMethodInfo; // 0x10
	private bool _fNotNull; // 0x18
	private Stream _stream; // 0x20
	private bool _firstCreateReader; // 0x28

	// Properties
	private static MethodInfo CreateSqlReaderMethodInfo { get; }
	public bool IsNull { get; }

	// Methods

	// RVA: 0x1E70250 Offset: 0x1E6F450 VA: 0x181E70250
	public void .ctor() { }

	// RVA: 0x1E6F8A0 Offset: 0x1E6EAA0 VA: 0x181E6F8A0
	public XmlReader CreateReader() { }

	// RVA: 0x1E6FB50 Offset: 0x1E6ED50 VA: 0x181E6FB50
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = False, bool throwTargetInvocationExceptions = False) { }

	// RVA: 0x1E6FA60 Offset: 0x1E6EC60 VA: 0x181E6FA60
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0x1E70280 Offset: 0x1E6F480 VA: 0x181E70280
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0x195C130 Offset: 0x195B330 VA: 0x18195C130 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1E6FD40 Offset: 0x1E6EF40 VA: 0x181E6FD40
	private void SetNull() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1E6FD60 Offset: 0x1E6EF60 VA: 0x181E6FD60 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x1E6FF40 Offset: 0x1E6F140 VA: 0x181E6FF40 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1E6FCD0 Offset: 0x1E6EED0 VA: 0x181E6FCD0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1E70090 Offset: 0x1E6F290 VA: 0x181E70090
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal sealed class SqlXmlStreamWrapper : Stream // TypeDefIndex: 12808
{
	// Fields
	private Stream _stream; // 0x28
	private long _lPosition; // 0x30
	private bool _isClosed; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E6F490 Offset: 0x1E6E690 VA: 0x181E6F490
	internal void .ctor(Stream stream) { }

	// RVA: 0x1E6F500 Offset: 0x1E6E700 VA: 0x181E6F500 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1E6F550 Offset: 0x1E6E750 VA: 0x181E6F550 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E6F5A0 Offset: 0x1E6E7A0 VA: 0x181E6F5A0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E6F5F0 Offset: 0x1E6E7F0 VA: 0x181E6F5F0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E6F6C0 Offset: 0x1E6E8C0 VA: 0x181E6F6C0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E6F770 Offset: 0x1E6E970 VA: 0x181E6F770 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E6EAC0 Offset: 0x1E6DCC0 VA: 0x181E6EAC0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E6E840 Offset: 0x1E6DA40 VA: 0x181E6E840 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E6F200 Offset: 0x1E6E400 VA: 0x181E6F200 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E6E6A0 Offset: 0x1E6D8A0 VA: 0x181E6E6A0 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x1E6F0A0 Offset: 0x1E6E2A0 VA: 0x181E6F0A0 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x1E6ED90 Offset: 0x1E6DF90 VA: 0x181E6ED90 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1E6E5F0 Offset: 0x1E6D7F0 VA: 0x181E6E5F0 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E6E5A0 Offset: 0x1E6D7A0 VA: 0x181E6E5A0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E6EF10 Offset: 0x1E6E110 VA: 0x181E6EF10
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0x1E6EE80 Offset: 0x1E6E080 VA: 0x181E6EE80
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0x1E6EFA0 Offset: 0x1E6E1A0 VA: 0x181E6EFA0
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0x1E6F030 Offset: 0x1E6E230 VA: 0x181E6F030
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0x1E6E610 Offset: 0x1E6D810 VA: 0x181E6E610
	private bool IsStreamClosed() { }
}

// Namespace: 
private enum ObjectStorage.Families // TypeDefIndex: 12809
{
	// Fields
	public int value__; // 0x0
	public const ObjectStorage.Families DATETIME = 0;
	public const ObjectStorage.Families NUMBER = 1;
	public const ObjectStorage.Families STRING = 2;
	public const ObjectStorage.Families BOOLEAN = 3;
	public const ObjectStorage.Families ARRAY = 4;
}

// Namespace: 
private class ObjectStorage.TempAssemblyComparer : IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> // TypeDefIndex: 12810
{
	// Fields
	internal static readonly IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default; // 0x0

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1E904B0 Offset: 0x1E8F6B0 VA: 0x181E904B0 Slot: 4
	public bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y) { }

	// RVA: 0x1E90640 Offset: 0x1E8F840 VA: 0x181E90640 Slot: 5
	public int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj) { }

	// RVA: 0x1E906E0 Offset: 0x1E8F8E0 VA: 0x181E906E0
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 12811
{
	// Fields
	private static readonly object s_defaultValue; // 0x0
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private static readonly object s_tempAssemblyCacheLock; // 0x8
	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; // 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; // 0x18

	// Methods

	// RVA: 0x1E51990 Offset: 0x1E50B90 VA: 0x181E51990
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0x1E4E4E0 Offset: 0x1E4D6E0 VA: 0x181E4E4E0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E4EBD0 Offset: 0x1E4DDD0 VA: 0x181E4EBD0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E4E660 Offset: 0x1E4D860 VA: 0x181E4E660 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x1E4E520 Offset: 0x1E4D720 VA: 0x181E4E520
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0x1E4E7F0 Offset: 0x1E4D9F0 VA: 0x181E4E7F0
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0x1E50090 Offset: 0x1E4F290 VA: 0x181E50090 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E50920 Offset: 0x1E4FB20 VA: 0x181E50920 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x1E50150 Offset: 0x1E4F350 VA: 0x181E50150
	private ObjectStorage.Families GetFamily(Type dataType) { }

	// RVA: 0x1E50960 Offset: 0x1E4FB60 VA: 0x181E50960 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E50C90 Offset: 0x1E4FE90 VA: 0x181E50C90 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x1E50990 Offset: 0x1E4FB90 VA: 0x181E50990 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E4F380 Offset: 0x1E4E580 VA: 0x181E4F380 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E4F7D0 Offset: 0x1E4E9D0 VA: 0x181E4F7D0 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1E4EE20 Offset: 0x1E4E020 VA: 0x181E4EE20 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E4ECF0 Offset: 0x1E4DEF0 VA: 0x181E4ECF0 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1E50110 Offset: 0x1E4F310 VA: 0x181E50110 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E4FE40 Offset: 0x1E4F040 VA: 0x181E4FE40 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E50A50 Offset: 0x1E4FC50 VA: 0x181E50A50 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1E517B0 Offset: 0x1E509B0 VA: 0x181E517B0
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0x1E502A0 Offset: 0x1E4F4A0 VA: 0x181E502A0
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0x1E50320 Offset: 0x1E4F520 VA: 0x181E50320
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0x1E518E0 Offset: 0x1E50AE0 VA: 0x181E518E0
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal static class ADP // TypeDefIndex: 12812
{
	// Fields
	private static readonly Type s_stackOverflowType; // 0x0
	private static readonly Type s_outOfMemoryType; // 0x8
	private static readonly Type s_threadAbortType; // 0x10
	private static readonly Type s_nullReferenceType; // 0x18
	private static readonly Type s_accessViolationType; // 0x20
	private static readonly Type s_securityType; // 0x28
	internal static readonly string StrEmpty; // 0x30
	internal static readonly string[] AzureSqlServerEndpoints; // 0x38
	internal static readonly IntPtr PtrZero; // 0x40
	internal static readonly int PtrSize; // 0x48

	// Methods

	// RVA: 0x1E71020 Offset: 0x1E70220 VA: 0x181E71020
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x1E70E80 Offset: 0x1E70080 VA: 0x181E70E80
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x1E70F50 Offset: 0x1E70150 VA: 0x181E70F50
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x1E70550 Offset: 0x1E6F750 VA: 0x181E70550
	internal static ArgumentException Argument(string error) { }

	// RVA: 0x1E70440 Offset: 0x1E6F640 VA: 0x181E70440
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0x1E704C0 Offset: 0x1E6F6C0 VA: 0x181E704C0
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0x1E70810 Offset: 0x1E6FA10 VA: 0x181E70810
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0x1E70E00 Offset: 0x1E70000 VA: 0x181E70E00
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0x1E70990 Offset: 0x1E6FB90 VA: 0x181E70990
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0x1E70BF0 Offset: 0x1E6FDF0 VA: 0x181E70BF0
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0x1E70670 Offset: 0x1E6F870 VA: 0x181E70670
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0x1E70930 Offset: 0x1E6FB30 VA: 0x181E70930
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0x1E705D0 Offset: 0x1E6F7D0 VA: 0x181E705D0
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x1E70770 Offset: 0x1E6F970 VA: 0x181E70770
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0x1E70890 Offset: 0x1E6FA90 VA: 0x181E70890
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0x1E710B0 Offset: 0x1E702B0 VA: 0x181E710B0
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0x1E711D0 Offset: 0x1E703D0 VA: 0x181E711D0
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 12813
{
	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0x1E72F10 Offset: 0x1E72110 VA: 0x181E72F10
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1E71480 Offset: 0x1E70680 VA: 0x181E71480 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E71630 Offset: 0x1E70830 VA: 0x181E71630 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E714C0 Offset: 0x1E706C0 VA: 0x181E714C0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E72020 Offset: 0x1E71220 VA: 0x181E72020
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1E71780 Offset: 0x1E70980 VA: 0x181E71780
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1E727C0 Offset: 0x1E719C0 VA: 0x181E727C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E72A30 Offset: 0x1E71C30 VA: 0x181E72A30 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E72B00 Offset: 0x1E71D00 VA: 0x181E72B00 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E72DC0 Offset: 0x1E71FC0 VA: 0x181E72DC0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E72BF0 Offset: 0x1E71DF0 VA: 0x181E72BF0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E72860 Offset: 0x1E71A60 VA: 0x181E72860 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E71F50 Offset: 0x1E71150 VA: 0x181E71F50 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E72AC0 Offset: 0x1E71CC0 VA: 0x181E72AC0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E72900 Offset: 0x1E71B00 VA: 0x181E72900 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E72D10 Offset: 0x1E71F10 VA: 0x181E72D10 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class BooleanStorage : DataStorage // TypeDefIndex: 12814
{
	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0x1E73CE0 Offset: 0x1E72EE0 VA: 0x181E73CE0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1E73050 Offset: 0x1E72250 VA: 0x181E73050 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E73460 Offset: 0x1E72660 VA: 0x181E73460 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E73320 Offset: 0x1E72520 VA: 0x181E73320 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E735D0 Offset: 0x1E727D0 VA: 0x181E735D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E73860 Offset: 0x1E72A60 VA: 0x181E73860 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E73930 Offset: 0x1E72B30 VA: 0x181E73930 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E73BB0 Offset: 0x1E72DB0 VA: 0x181E73BB0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E739E0 Offset: 0x1E72BE0 VA: 0x181E739E0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E736D0 Offset: 0x1E728D0 VA: 0x181E736D0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E73540 Offset: 0x1E72740 VA: 0x181E73540 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E738F0 Offset: 0x1E72AF0 VA: 0x181E738F0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E73740 Offset: 0x1E72940 VA: 0x181E73740 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E73B00 Offset: 0x1E72D00 VA: 0x181E73B00 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class ByteStorage : DataStorage // TypeDefIndex: 12815
{
	// Fields
	private byte[] _values; // 0x50

	// Methods

	// RVA: 0x1E74E60 Offset: 0x1E74060 VA: 0x181E74E60
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1E73DD0 Offset: 0x1E72FD0 VA: 0x181E73DD0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E74650 Offset: 0x1E73850 VA: 0x181E74650 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E74530 Offset: 0x1E73730 VA: 0x181E74530 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E74760 Offset: 0x1E73960 VA: 0x181E74760 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E749E0 Offset: 0x1E73BE0 VA: 0x181E749E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E74AB0 Offset: 0x1E73CB0 VA: 0x181E74AB0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E74D30 Offset: 0x1E73F30 VA: 0x181E74D30 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E74B60 Offset: 0x1E73D60 VA: 0x181E74B60 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E74860 Offset: 0x1E73A60 VA: 0x181E74860 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E746D0 Offset: 0x1E738D0 VA: 0x181E746D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E74A70 Offset: 0x1E73C70 VA: 0x181E74A70 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E748D0 Offset: 0x1E73AD0 VA: 0x181E748D0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E74C80 Offset: 0x1E73E80 VA: 0x181E74C80 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class CharStorage : DataStorage // TypeDefIndex: 12816
{
	// Fields
	private char[] _values; // 0x50

	// Methods

	// RVA: 0x1E75C70 Offset: 0x1E74E70 VA: 0x181E75C70
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1E74F50 Offset: 0x1E74150 VA: 0x181E74F50 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E753A0 Offset: 0x1E745A0 VA: 0x181E753A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E75270 Offset: 0x1E74470 VA: 0x181E75270 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E75500 Offset: 0x1E74700 VA: 0x181E75500 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E75780 Offset: 0x1E74980 VA: 0x181E75780 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E75850 Offset: 0x1E74A50 VA: 0x181E75850 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E75AD0 Offset: 0x1E74CD0 VA: 0x181E75AD0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E75900 Offset: 0x1E74B00 VA: 0x181E75900 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E75600 Offset: 0x1E74800 VA: 0x181E75600 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E75470 Offset: 0x1E74670 VA: 0x181E75470 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E75810 Offset: 0x1E74A10 VA: 0x181E75810 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E75670 Offset: 0x1E74870 VA: 0x181E75670 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E75A20 Offset: 0x1E74C20 VA: 0x181E75A20 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal enum StorageType // TypeDefIndex: 12817
{
	// Fields
	public int value__; // 0x0
	public const StorageType Empty = 0;
	public const StorageType Object = 1;
	public const StorageType DBNull = 2;
	public const StorageType Boolean = 3;
	public const StorageType Char = 4;
	public const StorageType SByte = 5;
	public const StorageType Byte = 6;
	public const StorageType Int16 = 7;
	public const StorageType UInt16 = 8;
	public const StorageType Int32 = 9;
	public const StorageType UInt32 = 10;
	public const StorageType Int64 = 11;
	public const StorageType UInt64 = 12;
	public const StorageType Single = 13;
	public const StorageType Double = 14;
	public const StorageType Decimal = 15;
	public const StorageType DateTime = 16;
	public const StorageType TimeSpan = 17;
	public const StorageType String = 18;
	public const StorageType Guid = 19;
	public const StorageType ByteArray = 20;
	public const StorageType CharArray = 21;
	public const StorageType Type = 22;
	public const StorageType DateTimeOffset = 23;
	public const StorageType BigInteger = 24;
	public const StorageType Uri = 25;
	public const StorageType SqlBinary = 26;
	public const StorageType SqlBoolean = 27;
	public const StorageType SqlByte = 28;
	public const StorageType SqlBytes = 29;
	public const StorageType SqlChars = 30;
	public const StorageType SqlDateTime = 31;
	public const StorageType SqlDecimal = 32;
	public const StorageType SqlDouble = 33;
	public const StorageType SqlGuid = 34;
	public const StorageType SqlInt16 = 35;
	public const StorageType SqlInt32 = 36;
	public const StorageType SqlInt64 = 37;
	public const StorageType SqlMoney = 38;
	public const StorageType SqlSingle = 39;
	public const StorageType SqlString = 40;
}

// Namespace: System.Data.Common
internal abstract class DataStorage // TypeDefIndex: 12818
{
	// Fields
	private static readonly Type[] s_storageClassType; // 0x0
	internal readonly DataColumn _column; // 0x10
	internal readonly DataTable _table; // 0x18
	internal readonly Type _dataType; // 0x20
	internal readonly StorageType _storageTypeCode; // 0x28
	private BitArray _dbNullBits; // 0x30
	private readonly object _defaultValue; // 0x38
	internal readonly object _nullValue; // 0x40
	internal readonly bool _isCloneable; // 0x48
	internal readonly bool _isCustomDefinedType; // 0x49
	internal readonly bool _isStringType; // 0x4A
	internal readonly bool _isValueType; // 0x4B
	private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces; // 0x8
	private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface; // 0x10

	// Properties
	internal DataSetDateTime DateTimeMode { get; }
	internal IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x1E797D0 Offset: 0x1E789D0 VA: 0x181E797D0
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0x1E79640 Offset: 0x1E78840 VA: 0x181E79640
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0x1E79670 Offset: 0x1E78870 VA: 0x181E79670
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0x1E79880 Offset: 0x1E78A80 VA: 0x181E79880
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1E798A0 Offset: 0x1E78AA0 VA: 0x181E798A0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1E75E10 Offset: 0x1E75010 VA: 0x181E75E10 Slot: 4
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1E75D60 Offset: 0x1E74F60 VA: 0x181E75D60
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0x1E75ED0 Offset: 0x1E750D0 VA: 0x181E75ED0
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int CompareValueTo(int recordNo1, object value);

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 7
	public virtual object ConvertValue(object value) { }

	// RVA: 0x1E75FF0 Offset: 0x1E751F0 VA: 0x181E75FF0
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Copy(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object Get(int recordNo);

	// RVA: 0x1E77A90 Offset: 0x1E76C90 VA: 0x181E77A90
	protected object GetBits(int recordNo) { }

	// RVA: 0x1E77CB0 Offset: 0x1E76EB0 VA: 0x181E77CB0 Slot: 10
	public virtual int GetStringLength(int record) { }

	// RVA: 0x1E77E40 Offset: 0x1E77040 VA: 0x181E77E40
	protected bool HasValue(int recordNo) { }

	// RVA: 0x1E78270 Offset: 0x1E77470 VA: 0x181E78270 Slot: 11
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Set(int recordNo, object value);

	// RVA: 0x1E786B0 Offset: 0x1E778B0 VA: 0x181E786B0
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0x1E78630 Offset: 0x1E77830 VA: 0x181E78630 Slot: 13
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ConvertXmlToObject(string s);

	// RVA: 0x1E75FA0 Offset: 0x1E751A0 VA: 0x181E75FA0 Slot: 15
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string ConvertObjectToXml(object value);

	// RVA: 0x1E75F50 Offset: 0x1E75150 VA: 0x181E75F50 Slot: 17
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1E76060 Offset: 0x1E75260 VA: 0x181E76060
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0x1E77B60 Offset: 0x1E76D60 VA: 0x181E77B60
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0x1E77CC0 Offset: 0x1E76EC0 VA: 0x181E77CC0
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0x1E785D0 Offset: 0x1E777D0 VA: 0x181E785D0
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0x1E785C0 Offset: 0x1E777C0 VA: 0x181E785C0
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0x1E785B0 Offset: 0x1E777B0 VA: 0x181E785B0
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0x1E784A0 Offset: 0x1E776A0 VA: 0x181E784A0
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0x1E77A00 Offset: 0x1E76C00 VA: 0x181E77A00
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0x1E77F40 Offset: 0x1E77140 VA: 0x181E77F40
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	// RVA: 0x1E780B0 Offset: 0x1E772B0 VA: 0x181E780B0
	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0x1E77E70 Offset: 0x1E77070 VA: 0x181E77E70
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0x1E78290 Offset: 0x1E77490 VA: 0x181E78290
	public static bool IsObjectNull(object value) { }

	// RVA: 0x1E783E0 Offset: 0x1E775E0 VA: 0x181E783E0
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0x1E77AD0 Offset: 0x1E76CD0 VA: 0x181E77AD0
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0x1E76040 Offset: 0x1E75240 VA: 0x181E76040
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E786D0 Offset: 0x1E778D0 VA: 0x181E786D0
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract object GetEmptyStorage(int recordCount);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void SetStorage(object store, BitArray nullbits);

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0x1E77D30 Offset: 0x1E76F30 VA: 0x181E77D30
	internal static Type GetType(string value) { }

	// RVA: 0x1E77AF0 Offset: 0x1E76CF0 VA: 0x181E77AF0
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0x1E786F0 Offset: 0x1E778F0 VA: 0x181E786F0
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 12819
{
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0x1E7A880 Offset: 0x1E79A80 VA: 0x181E7A880
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1E798C0 Offset: 0x1E78AC0 VA: 0x181E798C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E79EE0 Offset: 0x1E790E0 VA: 0x181E79EE0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E79D40 Offset: 0x1E78F40 VA: 0x181E79D40 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E7A150 Offset: 0x1E79350 VA: 0x181E7A150 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E72A30 Offset: 0x1E71C30 VA: 0x181E72A30 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E7A3D0 Offset: 0x1E795D0 VA: 0x181E7A3D0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E7A6E0 Offset: 0x1E798E0 VA: 0x181E7A6E0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E7A510 Offset: 0x1E79710 VA: 0x181E7A510 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E7A1E0 Offset: 0x1E793E0 VA: 0x181E7A1E0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E7A0C0 Offset: 0x1E792C0 VA: 0x181E7A0C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E7A390 Offset: 0x1E79590 VA: 0x181E7A390 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E7A260 Offset: 0x1E79460 VA: 0x181E7A260 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E7A630 Offset: 0x1E79830 VA: 0x181E7A630 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1E7A810 Offset: 0x1E79A10 VA: 0x181E7A810
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 12820
{
	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0x1E7BDC0 Offset: 0x1E7AFC0 VA: 0x181E7BDC0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1E7A9A0 Offset: 0x1E79BA0 VA: 0x181E7A9A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E7AF60 Offset: 0x1E7A160 VA: 0x181E7AF60 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E7ADE0 Offset: 0x1E79FE0 VA: 0x181E7ADE0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E7B1C0 Offset: 0x1E7A3C0 VA: 0x181E7B1C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E7B4E0 Offset: 0x1E7A6E0 VA: 0x181E7B4E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E7B5B0 Offset: 0x1E7A7B0 VA: 0x181E7B5B0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E7BA10 Offset: 0x1E7AC10 VA: 0x181E7BA10 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E7B6C0 Offset: 0x1E7A8C0 VA: 0x181E7B6C0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E7B2C0 Offset: 0x1E7A4C0 VA: 0x181E7B2C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E7B0D0 Offset: 0x1E7A2D0 VA: 0x181E7B0D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E7B570 Offset: 0x1E7A770 VA: 0x181E7B570 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E7B370 Offset: 0x1E7A570 VA: 0x181E7B370 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E7B7E0 Offset: 0x1E7A9E0 VA: 0x181E7B7E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1E7BD50 Offset: 0x1E7AF50 VA: 0x181E7BD50
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DecimalStorage : DataStorage // TypeDefIndex: 12821
{
	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0x1E7D360 Offset: 0x1E7C560 VA: 0x181E7D360
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1E7BEE0 Offset: 0x1E7B0E0 VA: 0x181E7BEE0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E7CA40 Offset: 0x1E7BC40 VA: 0x181E7CA40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E7C8A0 Offset: 0x1E7BAA0 VA: 0x181E7C8A0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E7CC80 Offset: 0x1E7BE80 VA: 0x181E7CC80 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E72A30 Offset: 0x1E71C30 VA: 0x181E72A30 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E7CF80 Offset: 0x1E7C180 VA: 0x181E7CF80 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E7D1F0 Offset: 0x1E7C3F0 VA: 0x181E7D1F0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E7D020 Offset: 0x1E7C220 VA: 0x181E7D020 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E7CD90 Offset: 0x1E7BF90 VA: 0x181E7CD90 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E7CBF0 Offset: 0x1E7BDF0 VA: 0x181E7CBF0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E7CF40 Offset: 0x1E7C140 VA: 0x181E7CF40 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E7CE10 Offset: 0x1E7C010 VA: 0x181E7CE10 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E7D140 Offset: 0x1E7C340 VA: 0x181E7D140 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class DoubleStorage : DataStorage // TypeDefIndex: 12822
{
	// Fields
	private double[] _values; // 0x50

	// Methods

	// RVA: 0x1E7E480 Offset: 0x1E7D680 VA: 0x181E7E480
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1E7D470 Offset: 0x1E7C670 VA: 0x181E7D470 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E7DC40 Offset: 0x1E7CE40 VA: 0x181E7DC40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E7DB10 Offset: 0x1E7CD10 VA: 0x181E7DB10 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E7DD60 Offset: 0x1E7CF60 VA: 0x181E7DD60 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E7DFF0 Offset: 0x1E7D1F0 VA: 0x181E7DFF0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E7E0C0 Offset: 0x1E7D2C0 VA: 0x181E7E0C0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E7E340 Offset: 0x1E7D540 VA: 0x181E7E340 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E7E170 Offset: 0x1E7D370 VA: 0x181E7E170 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E7DE60 Offset: 0x1E7D060 VA: 0x181E7DE60 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E7DCD0 Offset: 0x1E7CED0 VA: 0x181E7DCD0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E7E080 Offset: 0x1E7D280 VA: 0x181E7E080 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E7DED0 Offset: 0x1E7D0D0 VA: 0x181E7DED0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E7E290 Offset: 0x1E7D490 VA: 0x181E7E290 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int16Storage : DataStorage // TypeDefIndex: 12823
{
	// Fields
	private short[] _values; // 0x50

	// Methods

	// RVA: 0x1E7F5E0 Offset: 0x1E7E7E0 VA: 0x181E7F5E0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1E7E570 Offset: 0x1E7D770 VA: 0x181E7E570 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E7EE80 Offset: 0x1E7E080 VA: 0x181E7EE80 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E7ED60 Offset: 0x1E7DF60 VA: 0x181E7ED60 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E7EF80 Offset: 0x1E7E180 VA: 0x181E7EF80 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E75780 Offset: 0x1E74980 VA: 0x181E75780 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E7F230 Offset: 0x1E7E430 VA: 0x181E7F230 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E7F4B0 Offset: 0x1E7E6B0 VA: 0x181E7F4B0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E7F2E0 Offset: 0x1E7E4E0 VA: 0x181E7F2E0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E7F080 Offset: 0x1E7E280 VA: 0x181E7F080 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E7EEF0 Offset: 0x1E7E0F0 VA: 0x181E7EEF0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E7F1F0 Offset: 0x1E7E3F0 VA: 0x181E7F1F0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E7F0F0 Offset: 0x1E7E2F0 VA: 0x181E7F0F0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E7F400 Offset: 0x1E7E600 VA: 0x181E7F400 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int32Storage : DataStorage // TypeDefIndex: 12824
{
	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0x1E807B0 Offset: 0x1E7F9B0 VA: 0x181E807B0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1E7F6D0 Offset: 0x1E7E8D0 VA: 0x181E7F6D0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E7FFB0 Offset: 0x1E7F1B0 VA: 0x181E7FFB0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E7FEA0 Offset: 0x1E7F0A0 VA: 0x181E7FEA0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E800C0 Offset: 0x1E7F2C0 VA: 0x181E800C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E80330 Offset: 0x1E7F530 VA: 0x181E80330 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E80400 Offset: 0x1E7F600 VA: 0x181E80400 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E80680 Offset: 0x1E7F880 VA: 0x181E80680 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E804B0 Offset: 0x1E7F6B0 VA: 0x181E804B0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E801C0 Offset: 0x1E7F3C0 VA: 0x181E801C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E80030 Offset: 0x1E7F230 VA: 0x181E80030 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E803C0 Offset: 0x1E7F5C0 VA: 0x181E803C0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E80230 Offset: 0x1E7F430 VA: 0x181E80230 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E805D0 Offset: 0x1E7F7D0 VA: 0x181E805D0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int64Storage : DataStorage // TypeDefIndex: 12825
{
	// Fields
	private long[] _values; // 0x50

	// Methods

	// RVA: 0x1E81990 Offset: 0x1E80B90 VA: 0x181E81990
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1E808A0 Offset: 0x1E7FAA0 VA: 0x181E808A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E81180 Offset: 0x1E80380 VA: 0x181E81180 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E81060 Offset: 0x1E80260 VA: 0x181E81060 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E81290 Offset: 0x1E80490 VA: 0x181E81290 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E81500 Offset: 0x1E80700 VA: 0x181E81500 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E815D0 Offset: 0x1E807D0 VA: 0x181E815D0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E81850 Offset: 0x1E80A50 VA: 0x181E81850 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E81680 Offset: 0x1E80880 VA: 0x181E81680 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E81390 Offset: 0x1E80590 VA: 0x181E81390 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E81200 Offset: 0x1E80400 VA: 0x181E81200 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E81590 Offset: 0x1E80790 VA: 0x181E81590 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E81400 Offset: 0x1E80600 VA: 0x181E81400 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E817A0 Offset: 0x1E809A0 VA: 0x181E817A0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SByteStorage : DataStorage // TypeDefIndex: 12826
{
	// Fields
	private sbyte[] _values; // 0x50

	// Methods

	// RVA: 0x1E82AD0 Offset: 0x1E81CD0 VA: 0x181E82AD0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E81A80 Offset: 0x1E80C80 VA: 0x181E81A80 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E82300 Offset: 0x1E81500 VA: 0x181E82300 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E821E0 Offset: 0x1E813E0 VA: 0x181E821E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E82450 Offset: 0x1E81650 VA: 0x181E82450 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E749E0 Offset: 0x1E73BE0 VA: 0x181E749E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E82710 Offset: 0x1E81910 VA: 0x181E82710 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E829A0 Offset: 0x1E81BA0 VA: 0x181E829A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E827D0 Offset: 0x1E819D0 VA: 0x181E827D0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E82550 Offset: 0x1E81750 VA: 0x181E82550 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E823C0 Offset: 0x1E815C0 VA: 0x181E823C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E826D0 Offset: 0x1E818D0 VA: 0x181E826D0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E825C0 Offset: 0x1E817C0 VA: 0x181E825C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E828F0 Offset: 0x1E81AF0 VA: 0x181E828F0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal static class SqlConvert // TypeDefIndex: 12827
{
	// Methods

	// RVA: 0x1E8A680 Offset: 0x1E89880 VA: 0x181E8A680
	public static SqlByte ConvertToSqlByte(object value) { }

	// RVA: 0x1E8BD80 Offset: 0x1E8AF80 VA: 0x181E8BD80
	public static SqlInt16 ConvertToSqlInt16(object value) { }

	// RVA: 0x1E8C020 Offset: 0x1E8B220 VA: 0x181E8C020
	public static SqlInt32 ConvertToSqlInt32(object value) { }

	// RVA: 0x1E8C3F0 Offset: 0x1E8B5F0 VA: 0x181E8C3F0
	public static SqlInt64 ConvertToSqlInt64(object value) { }

	// RVA: 0x1E8B3C0 Offset: 0x1E8A5C0 VA: 0x181E8B3C0
	public static SqlDouble ConvertToSqlDouble(object value) { }

	// RVA: 0x1E8ACD0 Offset: 0x1E89ED0 VA: 0x181E8ACD0
	public static SqlDecimal ConvertToSqlDecimal(object value) { }

	// RVA: 0x1E8CF40 Offset: 0x1E8C140 VA: 0x181E8CF40
	public static SqlSingle ConvertToSqlSingle(object value) { }

	// RVA: 0x1E8C8E0 Offset: 0x1E8BAE0 VA: 0x181E8C8E0
	public static SqlMoney ConvertToSqlMoney(object value) { }

	// RVA: 0x1E8AAD0 Offset: 0x1E89CD0 VA: 0x181E8AAD0
	public static SqlDateTime ConvertToSqlDateTime(object value) { }

	// RVA: 0x1E8A4B0 Offset: 0x1E896B0 VA: 0x181E8A4B0
	public static SqlBoolean ConvertToSqlBoolean(object value) { }

	// RVA: 0x1E8BBA0 Offset: 0x1E8ADA0 VA: 0x181E8BBA0
	public static SqlGuid ConvertToSqlGuid(object value) { }

	// RVA: 0x1E8A2E0 Offset: 0x1E894E0 VA: 0x181E8A2E0
	public static SqlBinary ConvertToSqlBinary(object value) { }

	// RVA: 0x1E8D6B0 Offset: 0x1E8C8B0 VA: 0x181E8D6B0
	public static SqlString ConvertToSqlString(object value) { }

	// RVA: 0x1E8A990 Offset: 0x1E89B90 VA: 0x181E8A990
	public static SqlChars ConvertToSqlChars(object value) { }

	// RVA: 0x1E8A850 Offset: 0x1E89A50 VA: 0x181E8A850
	public static SqlBytes ConvertToSqlBytes(object value) { }

	// RVA: 0x1E8A260 Offset: 0x1E89460 VA: 0x181E8A260
	public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) { }

	// RVA: 0x1E880B0 Offset: 0x1E872B0 VA: 0x181E880B0
	public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1E86850 Offset: 0x1E85A50 VA: 0x181E86850
	public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1E88280 Offset: 0x1E87480 VA: 0x181E88280
	public static object ChangeTypeForXML(object value, Type type) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBinaryStorage : DataStorage // TypeDefIndex: 12828
{
	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0x1E83700 Offset: 0x1E82900 VA: 0x181E83700
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E82BC0 Offset: 0x1E81DC0 VA: 0x181E82BC0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E82E40 Offset: 0x1E82040 VA: 0x181E82E40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E82D90 Offset: 0x1E81F90 VA: 0x181E82D90 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E83090 Offset: 0x1E82290 VA: 0x181E83090 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E833E0 Offset: 0x1E825E0 VA: 0x181E833E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E83460 Offset: 0x1E82660 VA: 0x181E83460 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E834D0 Offset: 0x1E826D0 VA: 0x181E834D0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E836B0 Offset: 0x1E828B0 VA: 0x181E836B0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E83550 Offset: 0x1E82750 VA: 0x181E83550 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E83100 Offset: 0x1E82300 VA: 0x181E83100 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E82EE0 Offset: 0x1E820E0 VA: 0x181E82EE0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E83420 Offset: 0x1E82620 VA: 0x181E83420 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E832D0 Offset: 0x1E824D0 VA: 0x181E832D0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E83610 Offset: 0x1E82810 VA: 0x181E83610 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlByteStorage : DataStorage // TypeDefIndex: 12829
{
	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0x1E84FD0 Offset: 0x1E841D0 VA: 0x181E84FD0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E83920 Offset: 0x1E82B20 VA: 0x181E83920 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E84710 Offset: 0x1E83910 VA: 0x181E84710 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E84660 Offset: 0x1E83860 VA: 0x181E84660 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E84960 Offset: 0x1E83B60 VA: 0x181E84960 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E84CB0 Offset: 0x1E83EB0 VA: 0x181E84CB0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E84D30 Offset: 0x1E83F30 VA: 0x181E84D30 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E84DA0 Offset: 0x1E83FA0 VA: 0x181E84DA0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E84F80 Offset: 0x1E84180 VA: 0x181E84F80 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E84E20 Offset: 0x1E84020 VA: 0x181E84E20 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E849D0 Offset: 0x1E83BD0 VA: 0x181E849D0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E847B0 Offset: 0x1E839B0 VA: 0x181E847B0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E84CF0 Offset: 0x1E83EF0 VA: 0x181E84CF0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E84BA0 Offset: 0x1E83DA0 VA: 0x181E84BA0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E84EE0 Offset: 0x1E840E0 VA: 0x181E84EE0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBytesStorage : DataStorage // TypeDefIndex: 12830
{
	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0x1E85B90 Offset: 0x1E84D90 VA: 0x181E85B90
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E85200 Offset: 0x1E84400 VA: 0x181E85200 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E85850 Offset: 0x1E84A50 VA: 0x181E85850 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E858D0 Offset: 0x1E84AD0 VA: 0x181E858D0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E85900 Offset: 0x1E84B00 VA: 0x181E85900 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E85AA0 Offset: 0x1E84CA0 VA: 0x181E85AA0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E85940 Offset: 0x1E84B40 VA: 0x181E85940 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E85550 Offset: 0x1E84750 VA: 0x181E85550 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E853A0 Offset: 0x1E845A0 VA: 0x181E853A0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E85890 Offset: 0x1E84A90 VA: 0x181E85890 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E85740 Offset: 0x1E84940 VA: 0x181E85740 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E85A00 Offset: 0x1E84C00 VA: 0x181E85A00 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlCharsStorage : DataStorage // TypeDefIndex: 12831
{
	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0x1E86670 Offset: 0x1E85870 VA: 0x181E86670
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E85D70 Offset: 0x1E84F70 VA: 0x181E85D70 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E85850 Offset: 0x1E84A50 VA: 0x181E85850 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E858D0 Offset: 0x1E84AD0 VA: 0x181E858D0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E85900 Offset: 0x1E84B00 VA: 0x181E85900 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E86580 Offset: 0x1E85780 VA: 0x181E86580 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E86420 Offset: 0x1E85620 VA: 0x181E86420 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E860C0 Offset: 0x1E852C0 VA: 0x181E860C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E85F10 Offset: 0x1E85110 VA: 0x181E85F10 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E863E0 Offset: 0x1E855E0 VA: 0x181E863E0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E862D0 Offset: 0x1E854D0 VA: 0x181E862D0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E864E0 Offset: 0x1E856E0 VA: 0x181E864E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDateTimeStorage : DataStorage // TypeDefIndex: 12832
{
	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0x1E8E850 Offset: 0x1E8DA50 VA: 0x181E8E850
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E8D8A0 Offset: 0x1E8CAA0 VA: 0x181E8D8A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E8DEE0 Offset: 0x1E8D0E0 VA: 0x181E8DEE0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E8DE10 Offset: 0x1E8D010 VA: 0x181E8DE10 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E8E160 Offset: 0x1E8D360 VA: 0x181E8E160 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E8E500 Offset: 0x1E8D700 VA: 0x181E8E500 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E8E590 Offset: 0x1E8D790 VA: 0x181E8E590 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E8E610 Offset: 0x1E8D810 VA: 0x181E8E610 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E8E7F0 Offset: 0x1E8D9F0 VA: 0x181E8E7F0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E8E690 Offset: 0x1E8D890 VA: 0x181E8E690 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E8E1E0 Offset: 0x1E8D3E0 VA: 0x181E8E1E0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E8DFB0 Offset: 0x1E8D1B0 VA: 0x181E8DFB0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E8E550 Offset: 0x1E8D750 VA: 0x181E8E550 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E8E3D0 Offset: 0x1E8D5D0 VA: 0x181E8E3D0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E8E750 Offset: 0x1E8D950 VA: 0x181E8E750 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDecimalStorage : DataStorage // TypeDefIndex: 12833
{
	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0x1E90260 Offset: 0x1E8F460 VA: 0x181E90260
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E8EAA0 Offset: 0x1E8DCA0 VA: 0x181E8EAA0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E8F900 Offset: 0x1E8EB00 VA: 0x181E8F900 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E8F830 Offset: 0x1E8EA30 VA: 0x181E8F830 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E8FB70 Offset: 0x1E8ED70 VA: 0x181E8FB70 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E8FF10 Offset: 0x1E8F110 VA: 0x181E8FF10 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E8FFA0 Offset: 0x1E8F1A0 VA: 0x181E8FFA0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E90020 Offset: 0x1E8F220 VA: 0x181E90020 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E90200 Offset: 0x1E8F400 VA: 0x181E90200 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E900A0 Offset: 0x1E8F2A0 VA: 0x181E900A0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E8FBF0 Offset: 0x1E8EDF0 VA: 0x181E8FBF0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E8F9C0 Offset: 0x1E8EBC0 VA: 0x181E8F9C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E8FF60 Offset: 0x1E8F160 VA: 0x181E8FF60 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E8FDE0 Offset: 0x1E8EFE0 VA: 0x181E8FDE0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E90160 Offset: 0x1E8F360 VA: 0x181E90160 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDoubleStorage : DataStorage // TypeDefIndex: 12834
{
	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x1E93CA0 Offset: 0x1E92EA0 VA: 0x181E93CA0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E925F0 Offset: 0x1E917F0 VA: 0x181E925F0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E93350 Offset: 0x1E92550 VA: 0x181E93350 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E93290 Offset: 0x1E92490 VA: 0x181E93290 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E935C0 Offset: 0x1E927C0 VA: 0x181E935C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E93950 Offset: 0x1E92B50 VA: 0x181E93950 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E939E0 Offset: 0x1E92BE0 VA: 0x181E939E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E93A60 Offset: 0x1E92C60 VA: 0x181E93A60 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E93C40 Offset: 0x1E92E40 VA: 0x181E93C40 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E93AE0 Offset: 0x1E92CE0 VA: 0x181E93AE0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E93640 Offset: 0x1E92840 VA: 0x181E93640 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E93410 Offset: 0x1E92610 VA: 0x181E93410 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E939A0 Offset: 0x1E92BA0 VA: 0x181E939A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E93820 Offset: 0x1E92A20 VA: 0x181E93820 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E93BA0 Offset: 0x1E92DA0 VA: 0x181E93BA0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlGuidStorage : DataStorage // TypeDefIndex: 12835
{
	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x1E948F0 Offset: 0x1E93AF0 VA: 0x181E948F0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E93DF0 Offset: 0x1E92FF0 VA: 0x181E93DF0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E94070 Offset: 0x1E93270 VA: 0x181E94070 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E93FC0 Offset: 0x1E931C0 VA: 0x181E93FC0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E942C0 Offset: 0x1E934C0 VA: 0x181E942C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E833E0 Offset: 0x1E825E0 VA: 0x181E833E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E94650 Offset: 0x1E93850 VA: 0x181E94650 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E946C0 Offset: 0x1E938C0 VA: 0x181E946C0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E948A0 Offset: 0x1E93AA0 VA: 0x181E948A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E94740 Offset: 0x1E93940 VA: 0x181E94740 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E94330 Offset: 0x1E93530 VA: 0x181E94330 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E94110 Offset: 0x1E93310 VA: 0x181E94110 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E94610 Offset: 0x1E93810 VA: 0x181E94610 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E94500 Offset: 0x1E93700 VA: 0x181E94500 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E94800 Offset: 0x1E93A00 VA: 0x181E94800 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt16Storage : DataStorage // TypeDefIndex: 12836
{
	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x1E960A0 Offset: 0x1E952A0 VA: 0x181E960A0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E94A30 Offset: 0x1E93C30 VA: 0x181E94A30 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E957F0 Offset: 0x1E949F0 VA: 0x181E957F0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E95740 Offset: 0x1E94940 VA: 0x181E95740 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E95A40 Offset: 0x1E94C40 VA: 0x181E95A40 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E95D90 Offset: 0x1E94F90 VA: 0x181E95D90 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E95E10 Offset: 0x1E95010 VA: 0x181E95E10 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E95E80 Offset: 0x1E95080 VA: 0x181E95E80 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E96060 Offset: 0x1E95260 VA: 0x181E96060 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E95F00 Offset: 0x1E95100 VA: 0x181E95F00 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E95AB0 Offset: 0x1E94CB0 VA: 0x181E95AB0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E95890 Offset: 0x1E94A90 VA: 0x181E95890 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E95DD0 Offset: 0x1E94FD0 VA: 0x181E95DD0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E95C80 Offset: 0x1E94E80 VA: 0x181E95C80 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E95FC0 Offset: 0x1E951C0 VA: 0x181E95FC0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt32Storage : DataStorage // TypeDefIndex: 12837
{
	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x1E97830 Offset: 0x1E96A30 VA: 0x181E97830
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E961E0 Offset: 0x1E953E0 VA: 0x181E961E0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E96FB0 Offset: 0x1E961B0 VA: 0x181E96FB0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E96F00 Offset: 0x1E96100 VA: 0x181E96F00 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E97200 Offset: 0x1E96400 VA: 0x181E97200 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E833E0 Offset: 0x1E825E0 VA: 0x181E833E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E97590 Offset: 0x1E96790 VA: 0x181E97590 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E97600 Offset: 0x1E96800 VA: 0x181E97600 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E977E0 Offset: 0x1E969E0 VA: 0x181E977E0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E97680 Offset: 0x1E96880 VA: 0x181E97680 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E97270 Offset: 0x1E96470 VA: 0x181E97270 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E97050 Offset: 0x1E96250 VA: 0x181E97050 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E97550 Offset: 0x1E96750 VA: 0x181E97550 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E97440 Offset: 0x1E96640 VA: 0x181E97440 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E97740 Offset: 0x1E96940 VA: 0x181E97740 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt64Storage : DataStorage // TypeDefIndex: 12838
{
	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x1E990E0 Offset: 0x1E982E0 VA: 0x181E990E0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E97970 Offset: 0x1E96B70 VA: 0x181E97970 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E987E0 Offset: 0x1E979E0 VA: 0x181E987E0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E98720 Offset: 0x1E97920 VA: 0x181E98720 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E98A50 Offset: 0x1E97C50 VA: 0x181E98A50 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E93950 Offset: 0x1E92B50 VA: 0x181E93950 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E98E20 Offset: 0x1E98020 VA: 0x181E98E20 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E98EA0 Offset: 0x1E980A0 VA: 0x181E98EA0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E99080 Offset: 0x1E98280 VA: 0x181E99080 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E98F20 Offset: 0x1E98120 VA: 0x181E98F20 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E98AD0 Offset: 0x1E97CD0 VA: 0x181E98AD0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E988A0 Offset: 0x1E97AA0 VA: 0x181E988A0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E98DE0 Offset: 0x1E97FE0 VA: 0x181E98DE0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E98CB0 Offset: 0x1E97EB0 VA: 0x181E98CB0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E98FE0 Offset: 0x1E981E0 VA: 0x181E98FE0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlMoneyStorage : DataStorage // TypeDefIndex: 12839
{
	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x1E9A9E0 Offset: 0x1E99BE0 VA: 0x181E9A9E0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E99230 Offset: 0x1E98430 VA: 0x181E99230 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E9A0E0 Offset: 0x1E992E0 VA: 0x181E9A0E0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E9A020 Offset: 0x1E99220 VA: 0x181E9A020 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E9A350 Offset: 0x1E99550 VA: 0x181E9A350 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E93950 Offset: 0x1E92B50 VA: 0x181E93950 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E9A720 Offset: 0x1E99920 VA: 0x181E9A720 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E9A7A0 Offset: 0x1E999A0 VA: 0x181E9A7A0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E9A980 Offset: 0x1E99B80 VA: 0x181E9A980 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E9A820 Offset: 0x1E99A20 VA: 0x181E9A820 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E9A3D0 Offset: 0x1E995D0 VA: 0x181E9A3D0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E9A1A0 Offset: 0x1E993A0 VA: 0x181E9A1A0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E9A6E0 Offset: 0x1E998E0 VA: 0x181E9A6E0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E9A5B0 Offset: 0x1E997B0 VA: 0x181E9A5B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E9A8E0 Offset: 0x1E99AE0 VA: 0x181E9A8E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlSingleStorage : DataStorage // TypeDefIndex: 12840
{
	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x1E9C150 Offset: 0x1E9B350 VA: 0x181E9C150
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E9AB30 Offset: 0x1E99D30 VA: 0x181E9AB30 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E9B8D0 Offset: 0x1E9AAD0 VA: 0x181E9B8D0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E9B820 Offset: 0x1E9AA20 VA: 0x181E9B820 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E9BB20 Offset: 0x1E9AD20 VA: 0x181E9BB20 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E833E0 Offset: 0x1E825E0 VA: 0x181E833E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E9BEB0 Offset: 0x1E9B0B0 VA: 0x181E9BEB0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E9BF20 Offset: 0x1E9B120 VA: 0x181E9BF20 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E9C100 Offset: 0x1E9B300 VA: 0x181E9C100 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E9BFA0 Offset: 0x1E9B1A0 VA: 0x181E9BFA0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E9BB90 Offset: 0x1E9AD90 VA: 0x181E9BB90 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E9B970 Offset: 0x1E9AB70 VA: 0x181E9B970 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E9BE70 Offset: 0x1E9B070 VA: 0x181E9BE70 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E9BD60 Offset: 0x1E9AF60 VA: 0x181E9BD60 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E9C060 Offset: 0x1E9B260 VA: 0x181E9C060 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlStringStorage : DataStorage // TypeDefIndex: 12841
{
	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x1E9D270 Offset: 0x1E9C470 VA: 0x181E9D270
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E9C290 Offset: 0x1E9B490 VA: 0x181E9C290 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1E9C6F0 Offset: 0x1E9B8F0 VA: 0x181E9C6F0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E9C770 Offset: 0x1E9B970 VA: 0x181E9C770
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x1E9C5F0 Offset: 0x1E9B7F0 VA: 0x181E9C5F0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E9CA80 Offset: 0x1E9BC80 VA: 0x181E9CA80 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E9CE30 Offset: 0x1E9C030 VA: 0x181E9CE30 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E9CFB0 Offset: 0x1E9C1B0 VA: 0x181E9CFB0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E9CED0 Offset: 0x1E9C0D0 VA: 0x181E9CED0 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x1E9D030 Offset: 0x1E9C230 VA: 0x181E9D030 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E9D210 Offset: 0x1E9C410 VA: 0x181E9D210 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E9D0B0 Offset: 0x1E9C2B0 VA: 0x181E9D0B0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E9CB00 Offset: 0x1E9BD00 VA: 0x181E9CB00 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E9C8D0 Offset: 0x1E9BAD0 VA: 0x181E9C8D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E9CE90 Offset: 0x1E9C090 VA: 0x181E9CE90 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E9CCF0 Offset: 0x1E9BEF0 VA: 0x181E9CCF0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E9D170 Offset: 0x1E9C370 VA: 0x181E9D170 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBooleanStorage : DataStorage // TypeDefIndex: 12842
{
	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x1E924B0 Offset: 0x1E916B0 VA: 0x181E924B0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E917A0 Offset: 0x1E909A0 VA: 0x181E917A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E91C00 Offset: 0x1E90E00 VA: 0x181E91C00 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E91B50 Offset: 0x1E90D50 VA: 0x181E91B50 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E91E50 Offset: 0x1E91050 VA: 0x181E91E50 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E921A0 Offset: 0x1E913A0 VA: 0x181E921A0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E92220 Offset: 0x1E91420 VA: 0x181E92220 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E92290 Offset: 0x1E91490 VA: 0x181E92290 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E92470 Offset: 0x1E91670 VA: 0x181E92470 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E92310 Offset: 0x1E91510 VA: 0x181E92310 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E91EC0 Offset: 0x1E910C0 VA: 0x181E91EC0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E91CA0 Offset: 0x1E90EA0 VA: 0x181E91CA0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E921E0 Offset: 0x1E913E0 VA: 0x181E921E0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E92090 Offset: 0x1E91290 VA: 0x181E92090 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E923D0 Offset: 0x1E915D0 VA: 0x181E923D0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SingleStorage : DataStorage // TypeDefIndex: 12843
{
	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x1E916B0 Offset: 0x1E908B0 VA: 0x181E916B0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E90740 Offset: 0x1E8F940 VA: 0x181E90740 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E90F30 Offset: 0x1E90130 VA: 0x181E90F30 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E90E10 Offset: 0x1E90010 VA: 0x181E90E10 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E91050 Offset: 0x1E90250 VA: 0x181E91050 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E912D0 Offset: 0x1E904D0 VA: 0x181E912D0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E91370 Offset: 0x1E90570 VA: 0x181E91370 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1E91590 Offset: 0x1E90790 VA: 0x181E91590 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E91410 Offset: 0x1E90610 VA: 0x181E91410 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E91140 Offset: 0x1E90340 VA: 0x181E91140 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E90FC0 Offset: 0x1E901C0 VA: 0x181E90FC0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E91330 Offset: 0x1E90530 VA: 0x181E91330 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E911B0 Offset: 0x1E903B0 VA: 0x181E911B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E914E0 Offset: 0x1E906E0 VA: 0x181E914E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SqlUdtStorage.<>c__DisplayClass6_0 // TypeDefIndex: 12844
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1EA0C60 Offset: 0x1E9FE60 VA: 0x181EA0C60
	internal object <GetStaticNullForUdtType>b__0(Type t) { }
}

// Namespace: System.Data.Common
internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 12845
{
	// Fields
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private readonly bool _implementsIComparable; // 0x59
	private static readonly ConcurrentDictionary<Type, object> s_typeToNull; // 0x0

	// Methods

	// RVA: 0x1E9E800 Offset: 0x1E9DA00 VA: 0x181E9E800
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x1E9E670 Offset: 0x1E9D870 VA: 0x181E9E670
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x1E9E0E0 Offset: 0x1E9D2E0 VA: 0x181E9E0E0
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x1E9E1F0 Offset: 0x1E9D3F0 VA: 0x181E9E1F0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E9D3D0 Offset: 0x1E9C5D0 VA: 0x181E9D3D0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1E9D690 Offset: 0x1E9C890 VA: 0x181E9D690 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E9D410 Offset: 0x1E9C610 VA: 0x181E9D410 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x1E9E000 Offset: 0x1E9D200 VA: 0x181E9E000 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E858D0 Offset: 0x1E84AD0 VA: 0x181E858D0 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x1E9E410 Offset: 0x1E9D610 VA: 0x181E9E410 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x1E9E2A0 Offset: 0x1E9D4A0 VA: 0x181E9E2A0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1E9DC50 Offset: 0x1E9CE50 VA: 0x181E9DC50 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E9DA00 Offset: 0x1E9CC00 VA: 0x181E9DA00 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1E9D7E0 Offset: 0x1E9C9E0 VA: 0x181E9D7E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E9D6D0 Offset: 0x1E9C8D0 VA: 0x181E9D6D0 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1E9E0A0 Offset: 0x1E9D2A0 VA: 0x181E9E0A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E9DE90 Offset: 0x1E9D090 VA: 0x181E9DE90 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E9E370 Offset: 0x1E9D570 VA: 0x181E9E370 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1E9E600 Offset: 0x1E9D800 VA: 0x181E9E600
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class StringStorage : DataStorage // TypeDefIndex: 12846
{
	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x1E9F2B0 Offset: 0x1E9E4B0 VA: 0x181E9F2B0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E9EAA0 Offset: 0x1E9DCA0 VA: 0x181E9EAA0 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1E9EE40 Offset: 0x1E9E040 VA: 0x181E9EE40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E9ED60 Offset: 0x1E9DF60 VA: 0x181E9ED60 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1E9EF10 Offset: 0x1E9E110 VA: 0x181E9EF10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1E85850 Offset: 0x1E84A50 VA: 0x181E85850 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1E50920 Offset: 0x1E4FB20 VA: 0x181E50920 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x1E9F090 Offset: 0x1E9E290 VA: 0x181E9F090 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x1E50960 Offset: 0x1E4FB60 VA: 0x181E50960 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1E9F230 Offset: 0x1E9E430 VA: 0x181E9F230 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1E9F0D0 Offset: 0x1E9E2D0 VA: 0x181E9F0D0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1E9EEC0 Offset: 0x1E9E0C0 VA: 0x181E9EEC0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1E9F050 Offset: 0x1E9E250 VA: 0x181E9F050 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1E9EF40 Offset: 0x1E9E140 VA: 0x181E9EF40 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1E9F190 Offset: 0x1E9E390 VA: 0x181E9F190 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class TimeSpanStorage : DataStorage // TypeDefIndex: 12847
{
	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x1EA0B40 Offset: 0x1E9FD40 VA: 0x181EA0B40
	public void .ctor(DataColumn column) { }

	// RVA: 0x1E9F390 Offset: 0x1E9E590 VA: 0x181E9F390 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1EA0070 Offset: 0x1E9F270 VA: 0x181EA0070 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1E9FEE0 Offset: 0x1E9F0E0 VA: 0x181E9FEE0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1EA0270 Offset: 0x1E9F470 VA: 0x181EA0270
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x1EA04A0 Offset: 0x1E9F6A0 VA: 0x181EA04A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1EA06C0 Offset: 0x1E9F8C0 VA: 0x181EA06C0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1EA0760 Offset: 0x1E9F960 VA: 0x181EA0760 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1EA09E0 Offset: 0x1E9FBE0 VA: 0x181EA09E0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1EA0860 Offset: 0x1E9FA60 VA: 0x181EA0860 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1EA0540 Offset: 0x1E9F740 VA: 0x181EA0540 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1EA01E0 Offset: 0x1E9F3E0 VA: 0x181EA01E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1EA0720 Offset: 0x1E9F920 VA: 0x181EA0720 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1EA05B0 Offset: 0x1E9F7B0 VA: 0x181EA05B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1EA0930 Offset: 0x1E9FB30 VA: 0x181EA0930 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1EA0AD0 Offset: 0x1E9FCD0 VA: 0x181EA0AD0
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class UInt16Storage : DataStorage // TypeDefIndex: 12848
{
	// Fields
	private static readonly ushort s_defaultValue; // 0x0
	private ushort[] _values; // 0x50

	// Methods

	// RVA: 0x1EA1E40 Offset: 0x1EA1040 VA: 0x181EA1E40
	public void .ctor(DataColumn column) { }

	// RVA: 0x1EA0DA0 Offset: 0x1E9FFA0 VA: 0x181EA0DA0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1EA1670 Offset: 0x1EA0870 VA: 0x181EA1670 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1EA1550 Offset: 0x1EA0750 VA: 0x181EA1550 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1EA17C0 Offset: 0x1EA09C0 VA: 0x181EA17C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1EA1A20 Offset: 0x1EA0C20 VA: 0x181EA1A20 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1EA1AC0 Offset: 0x1EA0CC0 VA: 0x181EA1AC0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1EA1D00 Offset: 0x1EA0F00 VA: 0x181EA1D00 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1EA1B80 Offset: 0x1EA0D80 VA: 0x181EA1B80 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1EA18B0 Offset: 0x1EA0AB0 VA: 0x181EA18B0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1EA1730 Offset: 0x1EA0930 VA: 0x181EA1730 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1EA1A80 Offset: 0x1EA0C80 VA: 0x181EA1A80 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1EA1920 Offset: 0x1EA0B20 VA: 0x181EA1920 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1EA1C50 Offset: 0x1EA0E50 VA: 0x181EA1C50 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class UInt32Storage : DataStorage // TypeDefIndex: 12849
{
	// Fields
	private static readonly uint s_defaultValue; // 0x0
	private uint[] _values; // 0x50

	// Methods

	// RVA: 0x1EA2FE0 Offset: 0x1EA21E0 VA: 0x181EA2FE0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1EA1F50 Offset: 0x1EA1150 VA: 0x181EA1F50 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1EA2810 Offset: 0x1EA1A10 VA: 0x181EA2810 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1EA26F0 Offset: 0x1EA18F0 VA: 0x181EA26F0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1EA2970 Offset: 0x1EA1B70 VA: 0x181EA2970 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1EA2BD0 Offset: 0x1EA1DD0 VA: 0x181EA2BD0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1EA2C70 Offset: 0x1EA1E70 VA: 0x181EA2C70 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1EA2EB0 Offset: 0x1EA20B0 VA: 0x181EA2EB0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1EA2D30 Offset: 0x1EA1F30 VA: 0x181EA2D30 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1EA2A60 Offset: 0x1EA1C60 VA: 0x181EA2A60 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1EA28E0 Offset: 0x1EA1AE0 VA: 0x181EA28E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1EA2C30 Offset: 0x1EA1E30 VA: 0x181EA2C30 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1EA2AD0 Offset: 0x1EA1CD0 VA: 0x181EA2AD0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1EA2E00 Offset: 0x1EA2000 VA: 0x181EA2E00 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class UInt64Storage : DataStorage // TypeDefIndex: 12850
{
	// Fields
	private static readonly ulong s_defaultValue; // 0x0
	private ulong[] _values; // 0x50

	// Methods

	// RVA: 0x1EA4260 Offset: 0x1EA3460 VA: 0x181EA4260
	public void .ctor(DataColumn column) { }

	// RVA: 0x1EA30F0 Offset: 0x1EA22F0 VA: 0x181EA30F0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1EA3A30 Offset: 0x1EA2C30 VA: 0x181EA3A30 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1EA3910 Offset: 0x1EA2B10 VA: 0x181EA3910 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1EA3BE0 Offset: 0x1EA2DE0 VA: 0x181EA3BE0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1EA3E40 Offset: 0x1EA3040 VA: 0x181EA3E40 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1EA3EE0 Offset: 0x1EA30E0 VA: 0x181EA3EE0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1EA4120 Offset: 0x1EA3320 VA: 0x181EA4120 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1EA3FA0 Offset: 0x1EA31A0 VA: 0x181EA3FA0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1EA3CD0 Offset: 0x1EA2ED0 VA: 0x181EA3CD0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1EA3B50 Offset: 0x1EA2D50 VA: 0x181EA3B50 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1EA3EA0 Offset: 0x1EA30A0 VA: 0x181EA3EA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1EA3D40 Offset: 0x1EA2F40 VA: 0x181EA3D40 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1EA4070 Offset: 0x1EA3270 VA: 0x181EA4070 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 // TypeDefIndex: 12851
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 // TypeDefIndex: 12852
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 // TypeDefIndex: 12853
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 12854
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 // TypeDefIndex: 12855
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 // TypeDefIndex: 12856
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 12857
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 39A47A6A540EB845B37C85CE8C346359A0DB937D4AAF7A74A6C207205E0BC61E /*Metadata offset 0x8DDA20*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 540CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D /*Metadata offset 0x8DDAC0*/; // 0x98
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA /*Metadata offset 0x8DDAE8*/; // 0xBE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 8D4DC488705859D6A837A660BDBA9E88D1BD229BC39DB97734072D04BD513ECD /*Metadata offset 0x8DDB20*/; // 0xF2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 BA1E68F004F9EFDE72987E33682A8A5C579C4A609FBECE4F6EDBB844431D9226 /*Metadata offset 0x8DDB48*/; // 0x116
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 C44E90B8C219817ECD3C403823D4770C0F744358EBF32A4282B3CE0338D4602E /*Metadata offset 0x8DDBE8*/; // 0x1AE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 D44900CF81FC3D53E7F8D2FCB6EF3B50B39ED1A857628FA737F5B4B7E0382939 /*Metadata offset 0x8DDC88*/; // 0x246
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 E29424929B12EB1FDF4FD2E4911E09644CB58261C6033211F88022DDED785AE6 /*Metadata offset 0x8DDD28*/; // 0x2DE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 F327BBE8D18E0318C5295B25F9A8BA9B3AFE1F44C3C244BB3921AFEB578F1591 /*Metadata offset 0x8DDDE0*/; // 0x38E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315 /*Metadata offset 0x8DDE28*/; // 0x3CE
}

// Namespace: 
internal class <Module> // TypeDefIndex: 12858
{}

// Namespace: 
internal static class VCubrPMlycfiNxxjhIeRdlGtXaTtA // TypeDefIndex: 12859
{
	// Fields
	private static int WVwPqisTTkexaSssEzliwMOmeErK; // 0x0
	private static ThreadHelper LWJmZSlbIdvVostmAeFDQciWOoXF; // 0x8
	private static ThreadHelper llkJbfCKMELEBDeZEepqqhejaVxn; // 0x10

	// Properties
	public static int CpqDIQECsGFWTpYytbrUDUuCXSYgB { get; }
	public static ThreadHelper EqIjQuYlMDMoRKPjTHKljuNwmQSxA { get; }
	public static ThreadHelper zjTXiCeQXuJETXElteLKuWZwlTin { get; }

	// Methods

	// RVA: 0x1AFDC90 Offset: 0x1AFCE90 VA: 0x181AFDC90
	public static int hXAfuYAiscevoHnQijEhwdcmaAfGA() { }

	// RVA: 0x1AFDC50 Offset: 0x1AFCE50 VA: 0x181AFDC50
	public static ThreadHelper fgaBNgCYVKYbZEAMAinBDDmKEOARb() { }

	// RVA: 0x1AFDCD0 Offset: 0x1AFCED0 VA: 0x181AFDCD0
	public static ThreadHelper lTcLOBhsAcVEMAzdNUxyXBJyvvMs() { }

	// RVA: 0x1AFDE50 Offset: 0x1AFD050 VA: 0x181AFDE50
	public static void vojemuchleMDIhMiqQDKEyRAihxW(bool ) { }

	// RVA: 0x1AFDB60 Offset: 0x1AFCD60 VA: 0x181AFDB60
	private static void RfbhKIJtRSRXzhRjwQQgRBHnQABHA(UpdateLoopType ) { }

	// RVA: 0x1AFDD10 Offset: 0x1AFCF10 VA: 0x181AFDD10
	public static void mVrnEUyZIqoeCODwGZpTwLyPKBgN() { }
}

// Namespace: 
internal sealed class DJMEuoQHppWnpblLxDCXIgXGPGGh : IElementIdentifierTool // TypeDefIndex: 12860
{
	// Fields
	private GUIText UGAZdnfqaImXzrzhpDlAayqEekRd; // 0x10
	private string qMIqlgwmukomxwAtoUCKznVXLZqV; // 0x18
	private int fjACRAqyfONXsJofBqEcjjpCayReA; // 0x20
	private RmknDvrpRFsnwNOPRSeRFcQlQSzG AYIIJGvKjYQHADZRvWyHwouVAxqH; // 0x28
	private KRaUSsFBBHJDPgcjZWrEYoMMPWwn gEHOCsxsZmIzPJOhkLyBYoQtjRcx; // 0x30
	private Guid SEwOqLLcDACgLbGPtYVwjZMmWeAy; // 0x38
	private IList<QhuSAobzCkqTzlMZWIYycNYLbWUd> sbzNlvzOXCQkjdVEexrgMmaTHIDN; // 0x48
	private IList<QhuSAobzCkqTzlMZWIYycNYLbWUd> uUygjniuAHIgUoxIDzHHhjMpemUh; // 0x50
	private bool cHOxJytHRKeAZLWtDbZXucnmDJAGA; // 0x58
	private bool cQhcYSzDascARKtSgdvRcMYztKNsA; // 0x59
	private bool NbjycINyfjNrWVmKOAPUGZBUlbpJ; // 0x5A
	private int qdqBmWFLFDVkygbLQdWRGDHHnVtAA; // 0x5C
	private TimerRealTime yUKkneLZWOJTKgfkTsIvlUppkIBA; // 0x60

	// Methods

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 4
	public void Initialize(GUIText text) { }

	// RVA: 0x1AF8D40 Offset: 0x1AF7F40 VA: 0x181AF8D40 Slot: 5
	public void Start() { }

	// RVA: 0x1AF9090 Offset: 0x1AF8290 VA: 0x181AF9090 Slot: 6
	public void Update() { }

	// RVA: 0x1AF8C30 Offset: 0x1AF7E30 VA: 0x181AF8C30
	private void MSNzhaARKWdCvdmUgbToXgsVvNvnA() { }

	// RVA: 0x1AFA6E0 Offset: 0x1AF98E0 VA: 0x181AFA6E0
	private void euIXvwbKZyzmVxuHdVKkOkoQHZRw() { }

	// RVA: 0x1AFA6E0 Offset: 0x1AF98E0 VA: 0x181AFA6E0
	private void uHvJyUzJLlwnhBgnXuNMVdHuYGSx() { }

	// RVA: 0x1AFA6E0 Offset: 0x1AF98E0 VA: 0x181AFA6E0
	private void oEXbFFUYZiUyfnAqbtKJchHqWTIU() { }

	// RVA: 0x1AF8CE0 Offset: 0x1AF7EE0 VA: 0x181AF8CE0
	private void OsrQkkPSXhWWDTajSjZqhcSeEwcj() { }

	// RVA: 0x1AFAA80 Offset: 0x1AF9C80 VA: 0x181AFAA80
	private void zfNpaFFLXXvHZvjVeezKlwFwkLsm(string , object ) { }

	// RVA: 0x1AFA740 Offset: 0x1AF9940 VA: 0x181AFA740
	private int vnCvKvBouGzkuuAXKItHRJiObMoL(DirectInputAxis , ykZUMGNAQyZSwLzzZpTqJiPtVyMF ) { }

	// RVA: 0x1AF8BC0 Offset: 0x1AF7DC0 VA: 0x181AF8BC0
	private float ICCKEREgwEBEXNIRvYzHUVaTkTgp(int ) { }

	// RVA: 0x1AF8CC0 Offset: 0x1AF7EC0 VA: 0x181AF8CC0 Slot: 7
	public void OnDestroy() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal sealed class rmsjSuElFhwKAXUotLupIRfZNBhD : IElementIdentifierTool // TypeDefIndex: 12861
{
	// Fields
	private GUIText UGAZdnfqaImXzrzhpDlAayqEekRd; // 0x10
	private string qMIqlgwmukomxwAtoUCKznVXLZqV; // 0x18
	private int fjACRAqyfONXsJofBqEcjjpCayReA; // 0x20
	private IMIKpXqjqFXciFiwraohRJYwLECW ZkbDFztAoyruJtJVYXRHPgdiTBKW; // 0x28
	private HQXUOjGBtcCBEbCXgDocfmauonxdA gEHOCsxsZmIzPJOhkLyBYoQtjRcx; // 0x30
	private Guid SEwOqLLcDACgLbGPtYVwjZMmWeAy; // 0x38
	private IList<HQXUOjGBtcCBEbCXgDocfmauonxdA> sbzNlvzOXCQkjdVEexrgMmaTHIDN; // 0x48
	private bool cHOxJytHRKeAZLWtDbZXucnmDJAGA; // 0x50
	private bool cQhcYSzDascARKtSgdvRcMYztKNsA; // 0x51
	private bool NbjycINyfjNrWVmKOAPUGZBUlbpJ; // 0x52
	private string[] juwQafpSDjfBcOtlvOfoBEcjDveHA; // 0x58
	private int[] KXMdfdABrQVYfDjwMJVFBeYPMjiOA; // 0x60

	// Methods

	// RVA: 0x1B0E940 Offset: 0x1B0DB40 VA: 0x181B0E940 Slot: 4
	public void Initialize(GUIText text) { }

	// RVA: 0x1B0EB70 Offset: 0x1B0DD70 VA: 0x181B0EB70 Slot: 5
	public void Start() { }

	// RVA: 0x1B0EE80 Offset: 0x1B0E080 VA: 0x181B0EE80 Slot: 6
	public void Update() { }

	// RVA: 0x1B0EAC0 Offset: 0x1B0DCC0 VA: 0x181B0EAC0 Slot: 7
	public void OnDestroy() { }

	// RVA: 0x1B0EA70 Offset: 0x1B0DC70 VA: 0x181B0EA70
	private void MSNzhaARKWdCvdmUgbToXgsVvNvnA() { }

	// RVA: 0x1B10E70 Offset: 0x1B10070 VA: 0x181B10E70
	private void euIXvwbKZyzmVxuHdVKkOkoQHZRw() { }

	// RVA: 0x1B10E70 Offset: 0x1B10070 VA: 0x181B10E70
	private void uHvJyUzJLlwnhBgnXuNMVdHuYGSx() { }

	// RVA: 0x1B10E70 Offset: 0x1B10070 VA: 0x181B10E70
	private void oEXbFFUYZiUyfnAqbtKJchHqWTIU() { }

	// RVA: 0x1B0EB10 Offset: 0x1B0DD10 VA: 0x181B0EB10
	private void OsrQkkPSXhWWDTajSjZqhcSeEwcj() { }

	// RVA: 0x1B11000 Offset: 0x1B10200 VA: 0x181B11000
	private void zfNpaFFLXXvHZvjVeezKlwFwkLsm(string , object ) { }

	// RVA: 0x1B10ED0 Offset: 0x1B100D0 VA: 0x181B10ED0
	private void nIsagDFvicjkIvCazEfoKjCSWSJi(string , object ) { }

	// RVA: 0x1B10FD0 Offset: 0x1B101D0 VA: 0x181B10FD0
	private int vnCvKvBouGzkuuAXKItHRJiObMoL(RawInputAxis , int , qrCBzRwVIczQBQmQIaHiwZATkziK ) { }

	// RVA: 0x1AF8BC0 Offset: 0x1AF7DC0 VA: 0x181AF8BC0
	private float ICCKEREgwEBEXNIRvYzHUVaTkTgp(int ) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.InputManagers
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class Initializer : PlatformInitializer // TypeDefIndex: 12862
{
	// Fields
	private static PlatformInitializer YNDATIHbaUwwRGswrLAitbYzImpIA; // 0x0

	// Methods

	// RVA: 0x1AFAC30 Offset: 0x1AF9E30 VA: 0x181AFAC30
	public static PlatformInitializer GetPlatformInitializer() { }

	// RVA: 0x1AFACB0 Offset: 0x1AF9EB0 VA: 0x181AFACB0 Slot: 4
	public override object Initialize(IConfigVars_Internal configVars) { }

	// RVA: 0x1AFAB80 Offset: 0x1AF9D80 VA: 0x181AFAB80 Slot: 5
	public override IElementIdentifierTool CreateTool(string inputSourceString) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private abstract class MtRjUhpXuLnjGhlzwhWxZYToKTSt.yGWiprqzJABiTdaddgWOxKLQTmmg : IDisposable, IPoolableObject, IPoolableObject_Internal // TypeDefIndex: 12863
{
	// Fields
	[CompilerGenerated]
	private IObjectPool XdQqWNpPVwDnOwxlQvHTFoLfXMzQ; // 0x10

	// Properties
	private IObjectPool Rewired.Utils.Classes.Utility.IPoolableObject_Internal.pool { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void Clear();

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 6
	private IObjectPool Rewired.Utils.Classes.Utility.IPoolableObject_Internal.get_pool() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 7
	private void Rewired.Utils.Classes.Utility.IPoolableObject_Internal.set_pool(IObjectPool value) { }

	// RVA: 0x75AB00 Offset: 0x759D00 VA: 0x18075AB00 Slot: 8
	private void Rewired.Utils.Classes.Utility.IPoolableObject_Internal.Clear() { }

	// RVA: 0x1B11520 Offset: 0x1B10720 VA: 0x181B11520 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B11450 Offset: 0x1B10650 VA: 0x181B11450 Slot: 5
	public void Return() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
private class MtRjUhpXuLnjGhlzwhWxZYToKTSt.cZiAjnIcqnnIkXHUSNeyfqqpiKESA : MtRjUhpXuLnjGhlzwhWxZYToKTSt.yGWiprqzJABiTdaddgWOxKLQTmmg // TypeDefIndex: 12864
{
	// Fields
	public ZMahQVthSLKqbJpEnQafVTggvNXP GwkbKyytlkcbaaJASEpilQpPPpkzA; // 0x18
	public uZcaMyJgsoPIfjthKfCwZZBbPoFR mEHglUZNqrYinUHJFeePpKKaZhGA; // 0x20
	public double RqrEsuenCcDsHBRjsdHFWojVLODhA; // 0x60

	// Methods

	// RVA: 0x1B02F80 Offset: 0x1B02180 VA: 0x181B02F80 Slot: 9
	protected override void OsrQkkPSXhWWDTajSjZqhcSeEwcj() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class MtRjUhpXuLnjGhlzwhWxZYToKTSt.uXSwMKkbNTPJNcJPUqOiiPxXWplQ : MtRjUhpXuLnjGhlzwhWxZYToKTSt.yGWiprqzJABiTdaddgWOxKLQTmmg // TypeDefIndex: 12865
{
	// Fields
	public ZMahQVthSLKqbJpEnQafVTggvNXP GwkbKyytlkcbaaJASEpilQpPPpkzA; // 0x18
	public tpBEkSPbhGFZAskthAKVELrwzbhGA eKLiAaqouWExLaNHotTBcUpPxvEi; // 0x20

	// Methods

	// RVA: 0x1B11210 Offset: 0x1B10410 VA: 0x181B11210 Slot: 9
	protected override void OsrQkkPSXhWWDTajSjZqhcSeEwcj() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MtRjUhpXuLnjGhlzwhWxZYToKTSt.yctGvuqSAoHfyclhFqZqmdzdTSZM // TypeDefIndex: 12866
{
	// Fields
	public static readonly MtRjUhpXuLnjGhlzwhWxZYToKTSt.yctGvuqSAoHfyclhFqZqmdzdTSZM <>9; // 0x0
	public static Func<MtRjUhpXuLnjGhlzwhWxZYToKTSt.cZiAjnIcqnnIkXHUSNeyfqqpiKESA> <>9__19_0; // 0x8
	public static Func<MtRjUhpXuLnjGhlzwhWxZYToKTSt.uXSwMKkbNTPJNcJPUqOiiPxXWplQ> <>9__19_1; // 0x10

	// Methods

	// RVA: 0x1B115D0 Offset: 0x1B107D0 VA: 0x181B115D0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1B11580 Offset: 0x1B10780 VA: 0x181B11580
	internal MtRjUhpXuLnjGhlzwhWxZYToKTSt.cZiAjnIcqnnIkXHUSNeyfqqpiKESA WaUjpAavdKRzFXjenIhAasQoKkXK() { }

	// RVA: 0x1B11530 Offset: 0x1B10730 VA: 0x181B11530
	internal MtRjUhpXuLnjGhlzwhWxZYToKTSt.uXSwMKkbNTPJNcJPUqOiiPxXWplQ CRlkxlPXBABIIMEtaAePttsswLOF() { }
}

// Namespace: 
internal class MtRjUhpXuLnjGhlzwhWxZYToKTSt : IDisposable // TypeDefIndex: 12867
{
	// Fields
	private readonly List<cpbgLLGeKtWCuDBFXOJwgfLGWmKdB> dTiHCpdlltnGUoODihqyoyPKSBDm; // 0x10
	private readonly ReadOnlyCollection<cpbgLLGeKtWCuDBFXOJwgfLGWmKdB> rTRBsQpqUWlZXDapPZGrmtGlrumw; // 0x18
	private readonly List<ZMahQVthSLKqbJpEnQafVTggvNXP> jVYOVSrQoFtplXXNekupKLUgjYqD; // 0x20
	private readonly Func<int> PLIDxhQMjjbYGKzkKnXulbWjrDbn; // 0x28
	private readonly SpinLock HrdzeSJFtrQKDDrmsSufTXETrdeL; // 0x30
	private readonly SpinLock kryodTCtVdCdYyLrXQhbFXoMcVrn; // 0x38
	private RingBuffer<MtRjUhpXuLnjGhlzwhWxZYToKTSt.cZiAjnIcqnnIkXHUSNeyfqqpiKESA> dMtGeCMuRiWNBNheLTAfSppBLtfI; // 0x40
	private RingBuffer<MtRjUhpXuLnjGhlzwhWxZYToKTSt.uXSwMKkbNTPJNcJPUqOiiPxXWplQ> apfpsVMCeDPZrnBpUXtWiLcYLecn; // 0x48
	private bool crldvJhuzLPMrcBbtxoKBixMwyid; // 0x50
	private readonly ThreadSafeObjectPool<MtRjUhpXuLnjGhlzwhWxZYToKTSt.cZiAjnIcqnnIkXHUSNeyfqqpiKESA> ZFblCcefUvuxeMobiniymEAhUFc; // 0x58
	private readonly ThreadSafeObjectPool<MtRjUhpXuLnjGhlzwhWxZYToKTSt.uXSwMKkbNTPJNcJPUqOiiPxXWplQ> hWqXZKYrhuedxsKQAWMauMksNSAn; // 0x60
	private readonly List<cpbgLLGeKtWCuDBFXOJwgfLGWmKdB> DSuWsmgBhflgvSTOSUPVwOtLBupeA; // 0x68
	private RingBuffer<MtRjUhpXuLnjGhlzwhWxZYToKTSt.cZiAjnIcqnnIkXHUSNeyfqqpiKESA> PZipoHmrfiAGCzEifjsxHdalGSvS; // 0x70
	private RingBuffer<MtRjUhpXuLnjGhlzwhWxZYToKTSt.uXSwMKkbNTPJNcJPUqOiiPxXWplQ> QFFvdCFMHVOfCgfCVHeRIDZOfcqt; // 0x78
	private bool QsMmSSkpKFwKLpjJTijNVyQPdNio; // 0x80
	private Action<ZMahQVthSLKqbJpEnQafVTggvNXP, tpBEkSPbhGFZAskthAKVELrwzbhGA> AheniEsggJyivAxkoCrWpfpFgFBeA; // 0x88
	[CompilerGenerated]
	private Action nBwfPVYWrafEPMSglfHfSiribojBA; // 0x90
	private bool KbxbxdFRwCxlESZSXPtZDThmvMJq; // 0x98
	private static Guid[] ZfAlJwMtgbDZJZrYJuBTZgZeVeYs; // 0x0
	private static string[] laMBbhiJJxhTEGsXuqamAjbDkminb; // 0x8
	private static string[] bjORBAziMkcIXwwAYeFQJDCKkLEjb; // 0x10

	// Methods

	[CompilerGenerated]
	// RVA: 0x1AFC920 Offset: 0x1AFBB20 VA: 0x181AFC920
	public void boCMTYCIJIaDhJuycqfmgDFIgCscc(Action ) { }

	[CompilerGenerated]
	// RVA: 0x1AFCC90 Offset: 0x1AFBE90 VA: 0x181AFCC90
	public void mQgvfynuLKpZlCvjYUlXwSEdiLbI(Action ) { }

	// RVA: 0x1AFC0A0 Offset: 0x1AFB2A0 VA: 0x181AFC0A0
	public void .ctor(Func<int> ) { }

	// RVA: 0x1AFD390 Offset: 0x1AFC590 VA: 0x181AFD390
	public void tTXyaaeEzjIaNmrQLfIUdXCtvFXS() { }

	// RVA: 0x1AFBC80 Offset: 0x1AFAE80 VA: 0x181AFBC80
	public void XWqRdbSzLRWNHUZeBJnJRpHJnILg() { }

	// RVA: 0x1AFBB40 Offset: 0x1AFAD40 VA: 0x181AFBB40
	private void TBNOzPRZWVArMPAIJwLuIvpNnFQd(ZMahQVthSLKqbJpEnQafVTggvNXP , tpBEkSPbhGFZAskthAKVELrwzbhGA ) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IList<cpbgLLGeKtWCuDBFXOJwgfLGWmKdB> EyjQucCokhemloWXaKmvvBkySMHu() { }

	// RVA: 0x1AFB460 Offset: 0x1AFA660 VA: 0x181AFB460
	private void GyfliEfXcFknkIekycxBerBWQIMd() { }

	// RVA: 0x1AFD790 Offset: 0x1AFC990 VA: 0x181AFD790
	private void xikGZJHBGGtFqGGfzlnUbZaZXycKA(bool ) { }

	// RVA: 0x1AFD890 Offset: 0x1AFCA90 VA: 0x181AFD890
	private void yrpHlMSwdvFDeCykFDrPgKbsMdgM() { }

	// RVA: 0x1AFB2A0 Offset: 0x1AFA4A0 VA: 0x181AFB2A0
	private void FGsnlLwudAeWyNimxEQRQJGFIGQfA() { }

	// RVA: 0x1AFCBC0 Offset: 0x1AFBDC0 VA: 0x181AFCBC0
	private void hvoanUizITJRazLCBVujJpmTJwqV(ZMahQVthSLKqbJpEnQafVTggvNXP ) { }

	// RVA: 0x1AFBE90 Offset: 0x1AFB090 VA: 0x181AFBE90
	private void XcxhsknfnBrAMiozCKtqULPBvZhM(ZMahQVthSLKqbJpEnQafVTggvNXP ) { }

	// RVA: 0x1AFB230 Offset: 0x1AFA430 VA: 0x181AFB230 Slot: 4
	public void Dispose() { }

	// RVA: 0x152EE40 Offset: 0x152E040 VA: 0x18152EE40 Slot: 1
	protected override void kONViQuzxwhRMrNRqosajBxGDJsI() { }

	// RVA: 0x1AFCD40 Offset: 0x1AFBF40 VA: 0x181AFCD40 Slot: 6
	protected virtual void mVrnEUyZIqoeCODwGZpTwLyPKBgN(bool ) { }

	// RVA: 0x1AFC9D0 Offset: 0x1AFBBD0 VA: 0x181AFC9D0
	private static bool fvqRwykmweRjJUTZUCwyRQYwZYsA(IList<ZMahQVthSLKqbJpEnQafVTggvNXP> , ZMahQVthSLKqbJpEnQafVTggvNXP ) { }

	// RVA: 0x1AFD630 Offset: 0x1AFC830 VA: 0x181AFD630
	private static int xPlbrsmiUAcjuGCMvjrhoFfLcIjjb(IList<cpbgLLGeKtWCuDBFXOJwgfLGWmKdB> , ZMahQVthSLKqbJpEnQafVTggvNXP ) { }

	// RVA: 0x1AFD470 Offset: 0x1AFC670 VA: 0x181AFD470
	private static int xPlbrsmiUAcjuGCMvjrhoFfLcIjjb(IList<ZMahQVthSLKqbJpEnQafVTggvNXP> , ZMahQVthSLKqbJpEnQafVTggvNXP ) { }

	// RVA: 0x1AFBF60 Offset: 0x1AFB160 VA: 0x181AFBF60
	private static void .cctor() { }
}

// Namespace: 
internal interface MIOJgYPafWOQIwfaIjCaCewaCqYab : IDisposable // TypeDefIndex: 12868
{
	// Properties
	public abstract InputSource ZVeDPUhiefDMuFjbkWlGBlKWdAnWb { get; }
	public abstract int CjKelrkZOuDaTxxLNnoeQkdTDuncb { get; }
	public abstract string OPdSqjOmnCHzIITineycGMlNKVFg { get; }
	public abstract Guid XMiRoEPOmoGILiiBGhjmyxZvvFQt { get; }
	public abstract PidVid IwOGGWmqGFjrPewNqpKKmVMcZrVM { get; }
	public abstract ushort xCFMXdrgZHxTjLjcbdRcddRgioee { get; }
	public abstract ushort piJVzPYaMPVrdEDFlcKYFHMboDGtA { get; }
	public abstract Guid CaZDKKOWPGgYVreaQxvuHptDnjpR { get; }
	public abstract int SydSFHyODpRAUczGYmRIZqbqfYpZ { get; }
	public abstract int VgQDEtcgltQWAuTsTNqqxePkbYv { get; }
	public abstract int yHnCBeXIXvICHdkUKBvRSfURSRwi { get; }
	public abstract int hhuKplWmtLIzpenWEcucNgAVXyeK { get; }
	public abstract bool RYdyzgRUZKgWhkWGabsJQlXyxWzD { get; }
	public abstract WGIDeviceType vjNaXJxRDCWTAJsFEWYVTnEwhTHO { get; }
	public abstract bool vzwujMHSYeoGzQqmPGfvvLGDuPjo { get; }
	public abstract Controller.Extension XUzVDFIyoXgHKkMJqGEjofuMCnxp { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract InputSource bJkwhkRUHYfftGJCNMxkKboqQXUC();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int mXPjcVhMhhYPXImbtyzSJYQtUaxe();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string FgYOfsJXSNcdTZzeDwllumnSeYGCA();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Guid CePtiZWWtPGmfXpwqCoKiNpbUVmi();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract PidVid BMTxhFbnhHLtsIcPxRfwvCIvKamG();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ushort NYYkZyuFECoXbppvvwjPaTOghiUC();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ushort OmjRDZZDRhjixGNLbUqfLeJQplDB();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Guid UriZCaMgsYGuPRUOuZxRPCjKyiLB();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int gEcCmOtubNeJIMvpttUOORXikljP();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int ahEawMUNBsFyZVoLOCvPGBqGWHqjA();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int NNcFvuFpFKSkfAiYwnTYgVjSxVqiA();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_VibrationMotorCount();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_SupportsVibration();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract WGIDeviceType cBfnyPclnfQmNkeEOPADUQnkryLU();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool gsbjtifHuIFLTLhudmzaKPmbIKKe();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Controller.Extension xEOOXtuGNppvhhEGsxKvYTHRmtmK();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void SetVibration(int motorIndex, float amount, bool stopOtherMotors);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void StopVibration();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool JGDQHEtIojOrseFMsraOcCyeFxrcA(int );

	// RVA: -1 Offset: -1 Slot: 19
	public abstract float vnCvKvBouGzkuuAXKItHRJiObMoL(int );

	// RVA: -1 Offset: -1 Slot: 20
	public abstract int cAuZpwUovfBCzEutWWHbMRuRhwqlA(int );

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void PpYQpJQBxqOFeLBgXEfpbgskzwmH(MIOJgYPafWOQIwfaIjCaCewaCqYab );

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void tTXyaaeEzjIaNmrQLfIUdXCtvFXS(UpdateLoopType );

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void ZiaSbEmYMXYlvvANYzEPXNViWPXH();
}

// Namespace: 
[UnmanagedFunctionPointer(3)]
public sealed class iHiOPCIZSIjZWKAsVmzLkJvKpWIo.QTemluCUnyVDpsasNCFbggsZRyIlA : MulticastDelegate // TypeDefIndex: 12869
{
	// Methods

	// RVA: 0x1106640 Offset: 0x1105840 VA: 0x181106640
	public void .ctor(object , IntPtr ) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(RLJlxMomDVTaRvNWGBQuFpwNTFfrA pGamepad) { }
}

// Namespace: 
[UnmanagedFunctionPointer(3)]
public sealed class iHiOPCIZSIjZWKAsVmzLkJvKpWIo.hYcCZCLmUxANQGitPcQLxCxfTZyG : MulticastDelegate // TypeDefIndex: 12870
{
	// Methods

	// RVA: 0x1106640 Offset: 0x1105840 VA: 0x181106640
	public void .ctor(object , IntPtr ) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(RLJlxMomDVTaRvNWGBQuFpwNTFfrA pGamepad) { }
}

// Namespace: 
internal static class iHiOPCIZSIjZWKAsVmzLkJvKpWIo // TypeDefIndex: 12871
{
	// Methods

	// RVA: 0x1B08580 Offset: 0x1B07780 VA: 0x181B08580
	private static extern ulong WPlCZAIqFRqsTYCrPpiDudwzVJDD(IntPtr ) { }

	// RVA: 0x1B084F0 Offset: 0x1B076F0 VA: 0x181B084F0
	public static ulong TsRFGpeDHxCOyEzmbZobiduqgcAqB(IntPtr ) { }

	// RVA: 0x1B082D0 Offset: 0x1B074D0 VA: 0x181B082D0
	private static extern ulong MnhQCXmKeDXvnQgOzgZWHwJkdnXM(IntPtr ) { }

	// RVA: 0x1B07F90 Offset: 0x1B07190 VA: 0x181B07F90
	public static ulong IaMWQNJOeSsfvwINtbJVXCEdcDdq(IntPtr ) { }

	// RVA: 0x1B08B40 Offset: 0x1B07D40 VA: 0x181B08B40
	public static extern bool xLBwUAjrMrfSMIalKodGGMVlOxMOA() { }

	// RVA: 0x1B083F0 Offset: 0x1B075F0 VA: 0x181B083F0
	private static extern IntPtr PdePSSEieDPlKSLKbeKcgCuADWJJ() { }

	// RVA: 0x1B08200 Offset: 0x1B07400 VA: 0x181B08200
	public static string MQVvXTAtHrhFHCHfZAPwwZJNGfDj() { }

	// RVA: 0x1B08940 Offset: 0x1B07B40 VA: 0x181B08940
	public static extern RLJlxMomDVTaRvNWGBQuFpwNTFfrA fOursXkoYXnoXedIRrOlIdxGkSWI() { }

	// RVA: 0x1B08700 Offset: 0x1B07900 VA: 0x181B08700
	public static extern uint YfCqTwffNcNPEIvfrzpYDdBKvXdF(IntPtr ) { }

	// RVA: 0x1B08460 Offset: 0x1B07660 VA: 0x181B08460
	public static extern RLJlxMomDVTaRvNWGBQuFpwNTFfrA PfQxToaCaetcmtxeFucKyeOnWlqT(IntPtr , uint ) { }

	// RVA: 0x1B07D90 Offset: 0x1B06F90 VA: 0x181B07D90
	public static extern bool CdYfjQenriGZYRsMAGmvfzchpNtQb(IntPtr , ref uZcaMyJgsoPIfjthKfCwZZBbPoFR ) { }

	// RVA: 0x1B08350 Offset: 0x1B07550 VA: 0x181B08350
	public static extern void OQSCoZikgLJDoDVmqlwWInrpZYUo(IntPtr , [In] tpBEkSPbhGFZAskthAKVELrwzbhGA ) { }

	// RVA: 0x1B07EA0 Offset: 0x1B070A0 VA: 0x181B07EA0
	public static extern void DjXtNWlKMZVpgiUEYlouioGcDVjY() { }

	// RVA: 0x1B08850 Offset: 0x1B07A50 VA: 0x181B08850
	public static extern void ZeMgCnDEBBDLoQrMpefkCeiGhXFW() { }

	// RVA: 0x1B08170 Offset: 0x1B07370 VA: 0x181B08170
	public static extern void KbqgBqNYPrRladqlFtPGcOzzLNzK(iHiOPCIZSIjZWKAsVmzLkJvKpWIo.QTemluCUnyVDpsasNCFbggsZRyIlA ) { }

	// RVA: 0x1B089B0 Offset: 0x1B07BB0 VA: 0x181B089B0
	public static extern void nAAgtSMdAGhQmdGeDTABzqiWafXp(iHiOPCIZSIjZWKAsVmzLkJvKpWIo.hYcCZCLmUxANQGitPcQLxCxfTZyG ) { }

	// RVA: 0x1B08680 Offset: 0x1B07880 VA: 0x181B08680
	public static extern bool WzCVQavsvJiIhHaHBYJSkbOxJkte(IntPtr ) { }

	// RVA: 0x1B08A40 Offset: 0x1B07C40 VA: 0x181B08A40
	public static extern int oVmrDdCEbQfeFNYfFPjctHWyKgjT(IntPtr ) { }

	// RVA: 0x1B07E20 Offset: 0x1B07020 VA: 0x181B07E20
	public static extern int DVTQFBOKfFJoGSdqibPblWpdkBNS(IntPtr ) { }

	// RVA: 0x1B088C0 Offset: 0x1B07AC0 VA: 0x181B088C0
	public static extern int bybBgbgAAxDEnbHWkzczdljNrfPqc(IntPtr ) { }

	// RVA: 0x1B08600 Offset: 0x1B07800 VA: 0x181B08600
	private static extern IntPtr WaJMQEYnmGSCbcoMUAAWACtsOKdiA(IntPtr ) { }

	// RVA: 0x1B08020 Offset: 0x1B07220 VA: 0x181B08020
	public static string IiBHIkZzfoGqugvAbqqDdbOMWpqn(IntPtr ) { }

	// RVA: 0x1B07F10 Offset: 0x1B07110 VA: 0x181B07F10
	public static extern ushort GDHfHznWgHJvNZyCYgrFXGjsoxKr(IntPtr ) { }

	// RVA: 0x1B08BB0 Offset: 0x1B07DB0 VA: 0x181B08BB0
	public static extern ushort ypdDpVKSHHfIJLMlvbxzJpnhBXGF(IntPtr ) { }

	// RVA: 0x1B080F0 Offset: 0x1B072F0 VA: 0x181B080F0
	public static extern IntPtr JFCYjDfOnHFlZcZbyYcdYvvXjLmr(IntPtr ) { }

	// RVA: 0x1B08780 Offset: 0x1B07980 VA: 0x181B08780
	public static string YfktYPBklyhegfWjlcdhPnFyYjXu(IntPtr ) { }

	// RVA: 0x1B08AC0 Offset: 0x1B07CC0 VA: 0x181B08AC0
	public static extern RLJlxMomDVTaRvNWGBQuFpwNTFfrA qohUEJQevRgihTaZTHksOiPbWVMr(IntPtr ) { }
}

// Namespace: 
internal struct RLJlxMomDVTaRvNWGBQuFpwNTFfrA // TypeDefIndex: 12872
{
	// Fields
	private IntPtr jQMsHCKIDmYKxHgJFDqFCyvCmbaJ; // 0x0

	// Properties
	public IntPtr TuSqVJakVCDLEQejibAajfFxEtcTA { get; }
	public bool GKgfNnJbkGcVVcdzdLcfsIEWzycTb { get; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr PXEfEOhCMyNyWckoMhJComKnGaCZA() { }

	// RVA: 0x167A080 Offset: 0x1679280 VA: 0x18167A080
	public bool TJoXjzEnrkbvBgocdLmRUiCvDuSFA() { }
}

// Namespace: 
internal struct aRtvfjIkdxLYMsoTTeHvFSNygSzJ : IEquatable<aRtvfjIkdxLYMsoTTeHvFSNygSzJ> // TypeDefIndex: 12873
{
	// Fields
	public IntPtr bJfMUzQKWYcdliDtvhoxVhbOBmtdb; // 0x0

	// Properties
	public bool GKgfNnJbkGcVVcdzdLcfsIEWzycTb { get; }

	// Methods

	// RVA: 0x167A080 Offset: 0x1679280 VA: 0x18167A080
	public bool TJoXjzEnrkbvBgocdLmRUiCvDuSFA() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(RLJlxMomDVTaRvNWGBQuFpwNTFfrA ) { }

	// RVA: 0x1B02EC0 Offset: 0x1B020C0 VA: 0x181B02EC0
	public void mEDGKkHEacJFGaOhqOVgcljJPWhz() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static IntPtr qKFsOXhSAMTPoCAirhEHDiyLhJFEA(aRtvfjIkdxLYMsoTTeHvFSNygSzJ ) { }

	// RVA: 0x1B02DD0 Offset: 0x1B01FD0 VA: 0x181B02DD0 Slot: 0
	public override bool CyXDMrBLXtCsOiZFcTBytzvLGZzD(object ) { }

	// RVA: 0x1B02E70 Offset: 0x1B02070 VA: 0x181B02E70 Slot: 2
	public override int eTMQGbIbZFqfUKANgYNRwRsjmzQV() { }

	// RVA: 0x1B02E60 Offset: 0x1B02060 VA: 0x181B02E60 Slot: 4
	public bool Equals(aRtvfjIkdxLYMsoTTeHvFSNygSzJ other) { }

	// RVA: 0x1676F20 Offset: 0x1676120 VA: 0x181676F20
	public static bool FLtXVczRrXFerCcddSZUjurbyGeY(aRtvfjIkdxLYMsoTTeHvFSNygSzJ , aRtvfjIkdxLYMsoTTeHvFSNygSzJ ) { }
}

// Namespace: Rewired.Platforms.Microsoft.WindowsGamingInput
[CustomObfuscation(rename = False)]
internal enum WGIDeviceType // TypeDefIndex: 12874
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const WGIDeviceType None = 0;
	[CustomObfuscation(rename = False)]
	public const WGIDeviceType Gamepad = 1;
}

// Namespace: 
internal sealed class cpbgLLGeKtWCuDBFXOJwgfLGWmKdB : AvHABkrdMYcWqgwMnuzvHFDRpDYo // TypeDefIndex: 12875
{
	// Fields
	private ZMahQVthSLKqbJpEnQafVTggvNXP zhCOnrIMSynxyBGhzprjBWGyMUoM; // 0x90
	private tpBEkSPbhGFZAskthAKVELrwzbhGA rVGIYXRcuDbuYAGxdaQOCuypujsfA; // 0x98
	private tpBEkSPbhGFZAskthAKVELrwzbhGA UPAbUPeqQibpCPfvXjURFgRoSnsZA; // 0xB8
	private double lJtZErMbNoROmCmBuNqOSHJObUWfA; // 0xD8
	private bool rgsENNToIqcaOmdGaFCtDnVFBPQfA; // 0xE0
	private double rrZOMGSlAHnbTnuNrlSnzagbJdacA; // 0xE8
	private Action<ZMahQVthSLKqbJpEnQafVTggvNXP, tpBEkSPbhGFZAskthAKVELrwzbhGA> UfIzZvNSqNXaRtchpBlnnxNkcsUy; // 0xF0

	// Properties
	public ZMahQVthSLKqbJpEnQafVTggvNXP GwkbKyytlkcbaaJASEpilQpPPpkzA { get; }
	public override bool RYdyzgRUZKgWhkWGabsJQlXyxWzD { get; }
	public override int hhuKplWmtLIzpenWEcucNgAVXyeK { get; }

	// Methods

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public ZMahQVthSLKqbJpEnQafVTggvNXP qrWdxqMqieitmgaczHisfjzeMOiaB() { }

	// RVA: 0x1B05E90 Offset: 0x1B05090 VA: 0x181B05E90
	public void .ctor(ZMahQVthSLKqbJpEnQafVTggvNXP , int , Action<ZMahQVthSLKqbJpEnQafVTggvNXP, tpBEkSPbhGFZAskthAKVELrwzbhGA> ) { }

	// RVA: 0x1B065A0 Offset: 0x1B057A0 VA: 0x181B065A0
	public void yfburgnLZBFyHZMWTRvnOcHDDCchA(uZcaMyJgsoPIfjthKfCwZZBbPoFR , double ) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 29
	public override bool obOWeohAyyeQrfcvADTxVkHuxcJDA() { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 30
	public override int oAkAczedJqFcnDmVJBPbjoymAXSKb() { }

	// RVA: 0x1B06370 Offset: 0x1B05570 VA: 0x181B06370 Slot: 34
	public override void tTXyaaeEzjIaNmrQLfIUdXCtvFXS(UpdateLoopType ) { }

	// RVA: 0x1B05C50 Offset: 0x1B04E50 VA: 0x181B05C50 Slot: 33
	public override void PpYQpJQBxqOFeLBgXEfpbgskzwmH(MIOJgYPafWOQIwfaIjCaCewaCqYab ) { }

	// RVA: 0x1B05B70 Offset: 0x1B04D70 VA: 0x181B05B70 Slot: 31
	public override void PEicuEonCjzDzeoYSXCrKEPohmVh(int , float , bool ) { }

	// RVA: 0x1B05D20 Offset: 0x1B04F20 VA: 0x181B05D20 Slot: 32
	public override void UFEOYSLYwlQJxPlWMFjKhKGgjVNJ() { }

	// RVA: 0x1B05D60 Offset: 0x1B04F60 VA: 0x181B05D60
	private void WjqJCxOgBipuKCnmgLKICttsFIdJ() { }

	// RVA: 0x1B064E0 Offset: 0x1B056E0 VA: 0x181B064E0
	private void xrKVkfJjmDaYwMJTFSjrArTrqqis() { }

	// RVA: 0x1B05B30 Offset: 0x1B04D30 VA: 0x181B05B30
	private void DFXiqcZmljauimojeXPsGYobXIxc(bool ) { }

	// RVA: 0x1B06020 Offset: 0x1B05220 VA: 0x181B06020
	private void bzIQFPqjvjFWSsGFXBoUfMjOJJGv() { }

	// RVA: 0x1B060B0 Offset: 0x1B052B0 VA: 0x181B060B0
	private void jtEGqQeRiXWjDVHCUcTbgRwDcAgRc() { }

	// RVA: 0x1B06330 Offset: 0x1B05530 VA: 0x181B06330
	private bool sgfawqfzADvztaQcSRlHZGsQNvbVA(ref tpBEkSPbhGFZAskthAKVELrwzbhGA ) { }

	// RVA: 0x1B05B50 Offset: 0x1B04D50 VA: 0x181B05B50
	private void HKLGjyffHJtbqGpLkZPKhQbjIMHFA(ref tpBEkSPbhGFZAskthAKVELrwzbhGA ) { }

	// RVA: 0x1B05C30 Offset: 0x1B04E30 VA: 0x181B05C30
	private void PcaGWvRtBbiWxNeSYKHuTiUNroBU(ref tpBEkSPbhGFZAskthAKVELrwzbhGA , ref tpBEkSPbhGFZAskthAKVELrwzbhGA ) { }

	// RVA: 0x1B06230 Offset: 0x1B05430 VA: 0x181B06230 Slot: 37
	protected override bool mVrnEUyZIqoeCODwGZpTwLyPKBgN(bool ) { }
}

// Namespace: 
private class pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL : IDisposable, IInputManagerJoystick, IInputManagerJoystickPublic // TypeDefIndex: 12876
{
	// Fields
	private int elLFJteTiCVpSogeBWPkFnTrudWE; // 0x10
	private int fVuPgJSlpPIfSeOgsNtYBMDtpgunA; // 0x14
	public Guid ksQXSyCMArgpTQjQVaPCEGSVXoOp; // 0x18
	public string kJOmFeUAgkDdNXyTSilWpUlXspNF; // 0x28
	public MIOJgYPafWOQIwfaIjCaCewaCqYab gEHOCsxsZmIzPJOhkLyBYoQtjRcx; // 0x30
	public string DioGwKdMhhhHNmPiSEvXwIPEHgeH; // 0x38
	public string lufcugDzGrkmtafbpDqMLPXSlCRNA; // 0x40
	public Guid JyzEdkAbNbxABgJyWcyFlkkleEdEb; // 0x48
	public PidVid wJJzsyFeFcbrSkeOTEqDpBeVNXACA; // 0x58
	public Guid rSsgiQBLwBxXOQgdSZXDaFKJpYUHA; // 0x5C
	public int HtJjzJNFnoRSOEdOsBCWuXjdSOUI; // 0x6C
	public int FUtJHSvyySJCEQpkrduZIvvRPOOA; // 0x70
	public int AgoGitaCJZRYBFvgZZssrUYswHJAA; // 0x74
	public int SrORvcQcSYELPJTyDirjrtpZoNfKA; // 0x78
	public int LmpluWWlOaMRxzVuDRghRTlVHtlj; // 0x7C
	public int acdSMFTSUSdLCcyHplSQOiRKoZSn; // 0x80
	public bool XJrptZuDMzJgsxBRxAwoplGIlEST; // 0x84
	public int CytlqlXAkwffzJefTcoaJwirMQhD; // 0x88
	private float[] wsHpigDPzQcVMoNRfBDQAlRyqROgb; // 0x90
	private float[] SMjvFtmVJPKHDGGnPQKpepfMESLb; // 0x98
	private bool[] TXaIKdbNzQLxBLaAwYXoGhjcfRum; // 0xA0
	private HardwareJoystickMap_InputManager cNQOBilDgUZmDotqcVREDrrooBLe; // 0xA8
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> CxbDKKUcFsXkVOyjAXODyEMHBOYo; // 0xB0
	private bool HwWSDNGAiFPLpbJYXqmSjaEDhwTm; // 0xB8
	private bool eIQDQfZkSYmdtUBeiFMzQFUZeUMU; // 0xB9
	[CompilerGenerated]
	private Controller.Extension fNsOWDGGBEJzQdSEJbTBbjYjYuNo; // 0xC0
	private bool KbxbxdFRwCxlESZSXPtZDThmvMJq; // 0xC8

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
	public int unityId { get; }
	[CustomObfuscation(rename = False)]
	public Guid instanceGuid { get; }
	[CustomObfuscation(rename = False)]
	public Guid persistentGuid { get; }
	[CustomObfuscation(rename = False)]
	public Controller.Extension extension { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 9
	public int get_rewiredId() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_rewiredId(int value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public int get_inputManagerId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_inputManagerId(int value) { }

	// RVA: 0x1B01AB0 Offset: 0x1B00CB0 VA: 0x181B01AB0 Slot: 11
	public string get_name() { }

	// RVA: 0x1B01C00 Offset: 0x1B00E00 VA: 0x181B01C00 Slot: 12
	public Nullable<long> get_systemId() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 13
	public int get_unityId() { }

	// RVA: 0x528FE0 Offset: 0x5281E0 VA: 0x180528FE0 Slot: 15
	public Guid get_instanceGuid() { }

	// RVA: 0x1B01B00 Offset: 0x1B00D00 VA: 0x181B01B00 Slot: 16
	public Guid get_persistentGuid() { }

	[CompilerGenerated]
	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0 Slot: 14
	public Controller.Extension get_extension() { }

	[CompilerGenerated]
	// RVA: 0x718950 Offset: 0x717B50 VA: 0x180718950
	public void set_extension(Controller.Extension value) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B00C30 Offset: 0x1AFFE30 VA: 0x181B00C30 Slot: 17
	public void SetVibration(float amount, int motorIndex) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B00D20 Offset: 0x1AFFF20 VA: 0x181B00D20 Slot: 18
	public void StopVibration() { }

	// RVA: 0x1B01700 Offset: 0x1B00900 VA: 0x181B01700
	public void .ctor(Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> ) { }

	// RVA: 0x1B00D80 Offset: 0x1AFFF80 VA: 0x181B00D80
	public void TOfaVcdcUxBZvMNMLarYOrIbspsl() { }

	// RVA: 0x1B014E0 Offset: 0x1B006E0 VA: 0x181B014E0
	public void ZmNayyZnLotCnltAfPptPDSFfNbgA(pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B01290 Offset: 0x1B00490 VA: 0x181B01290 Slot: 5
	public void Update() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B00690 Offset: 0x1AFF890 VA: 0x181B00690 Slot: 6
	public void FillData(ControllerDataUpdater dataUpdater) { }

	// RVA: 0x1B02990 Offset: 0x1B01B90 VA: 0x181B02990
	public int tpevtaPONvCbOPLLHaJdyPWHGzZx(pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL ) { }

	// RVA: 0x1B01A50 Offset: 0x1B00C50 VA: 0x181B01A50
	private BridgedControllerHWInfo eoNUQUHMlXQrwOfObYLDIXlpHRmJ() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B01100 Offset: 0x1B00300 VA: 0x181B01100 Slot: 7
	public BridgedController ToBridgedController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B01230 Offset: 0x1B00430 VA: 0x181B01230 Slot: 8
	public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs() { }

	// RVA: 0x1B01820 Offset: 0x1B00A20 VA: 0x181B01820
	private void bqZsUfrwXrMerppiHuLJWqqIVlrD() { }

	// RVA: 0x1B012B0 Offset: 0x1B004B0 VA: 0x181B012B0
	private void WIpskiOWInYZQmpjrkbqBXWXXrsg() { }

	// RVA: 0x1B01740 Offset: 0x1B00940 VA: 0x181B01740
	private void arXVdPKEuSyfzlgBBBIVpVZUxias(HardwareJoystickMap.Platform_WindowsWGI_Base.Axis , int ) { }

	// RVA: 0x1B02840 Offset: 0x1B01A40 VA: 0x181B02840
	private void mLIlzcHptbCUMKbxcpuvztErfMuM(HardwareJoystickMap.Platform_WindowsWGI_Base.Button , int ) { }

	// RVA: 0x1B02BB0 Offset: 0x1B01DB0 VA: 0x181B02BB0
	private float vnCvKvBouGzkuuAXKItHRJiObMoL(HardwareJoystickMap.Platform_WindowsWGI_Base.Axis ) { }

	// RVA: 0x1B02AA0 Offset: 0x1B01CA0 VA: 0x181B02AA0
	private float vnCvKvBouGzkuuAXKItHRJiObMoL(int ) { }

	// RVA: 0x1B00830 Offset: 0x1AFFA30 VA: 0x181B00830
	private float JGDQHEtIojOrseFMsraOcCyeFxrcA(HardwareJoystickMap.Platform_WindowsWGI_Base.Button ) { }

	// RVA: 0x1B01040 Offset: 0x1B00240 VA: 0x181B01040
	private float TjUSjWnSzlMKBMGNZaxRAiNROxaZ(int , int , HatType ) { }

	// RVA: 0x1B003A0 Offset: 0x1AFF5A0 VA: 0x181B003A0
	private float CyECkGYxbhqjARYFYRKcxRWKrrYo(int , AxisDirection ) { }

	// RVA: 0x1B01F50 Offset: 0x1B01150 VA: 0x181B01F50
	private void kEIKNRuflotJMGPZCZrjbNEpOWZA() { }

	// RVA: 0x1B01C70 Offset: 0x1B00E70 VA: 0x181B01C70
	private string ivJwMqcgQnAEQDgLumDHXCkgoImoA() { }

	// RVA: 0x1B00460 Offset: 0x1AFF660 VA: 0x181B00460
	private void FUpEnRfZKusAxqfkFZYzdRVRUyzkA(BridgedControllerHWInfo ) { }

	// RVA: 0x1B00590 Offset: 0x1AFF790 VA: 0x181B00590
	private void FUpEnRfZKusAxqfkFZYzdRVRUyzkA(BridgedController ) { }

	// RVA: 0x1B025D0 Offset: 0x1B017D0 VA: 0x181B025D0
	private UnknownControllerHat[] kODywkpNeirqKIWAOhDSThtXSQZd() { }

	// RVA: 0x1B003F0 Offset: 0x1AFF5F0 VA: 0x181B003F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B027D0 Offset: 0x1B019D0 VA: 0x181B027D0 Slot: 1
	protected override void kONViQuzxwhRMrNRqosajBxGDJsI() { }

	// RVA: 0x1B02920 Offset: 0x1B01B20 VA: 0x181B02920 Slot: 20
	protected virtual void mVrnEUyZIqoeCODwGZpTwLyPKBgN(bool ) { }

	// RVA: 0x1A67B20 Offset: 0x1A66D20 VA: 0x181A67B20
	public static int rfLHjamfrvjAnxvnjhnGjJsToSdk(pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL , pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL ) { }

	// RVA: 0x1B02A60 Offset: 0x1B01C60 VA: 0x181B02A60
	public static int vHbfdITdtZyWDoGZidCsFpxOBeOiA(pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL , pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL ) { }
}

// Namespace: 
public enum pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.LHiODxmbgBeHojmHGZnjCQTPkJvz // TypeDefIndex: 12877
{
	// Fields
	public int value__; // 0x0
	public const pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.LHiODxmbgBeHojmHGZnjCQTPkJvz Exact = 0;
	public const pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.LHiODxmbgBeHojmHGZnjCQTPkJvz Approximate = 1;
}

// Namespace: 
public class pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.hOKmnAuIQPcgJPkgpFfOAnEEgZaF // TypeDefIndex: 12878
{
	// Fields
	public int bjPdYScThyPydDNbkCRNjpFZeFsGb; // 0x10
	public Guid tUdTykDxgBCqGCixYpFbieosflKS; // 0x14
	public Guid rSsgiQBLwBxXOQgdSZXDaFKJpYUHA; // 0x24
	public int nFfBcraymUoVTfAIgQbmWpDqKGIM; // 0x34
	public int SrORvcQcSYELPJTyDirjrtpZoNfKA; // 0x38
	public int LmpluWWlOaMRxzVuDRghRTlVHtlj; // 0x3C
	public int acdSMFTSUSdLCcyHplSQOiRKoZSn; // 0x40
	public int AgoGitaCJZRYBFvgZZssrUYswHJAA; // 0x44
	public int FUtJHSvyySJCEQpkrduZIvvRPOOA; // 0x48

	// Methods

	// RVA: 0x1B07C90 Offset: 0x1B06E90 VA: 0x181B07C90
	public bool tpevtaPONvCbOPLLHaJdyPWHGzZx(pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL , pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.LHiODxmbgBeHojmHGZnjCQTPkJvz ) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.JijGSSZFqvCGNcxOXdRXPMOVJxgDA : IEnumerable<pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.hOKmnAuIQPcgJPkgpFfOAnEEgZaF>, IEnumerator<pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.hOKmnAuIQPcgJPkgpFfOAnEEgZaF>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 12879
{
	// Fields
	private int PzjprMxCXAatbcFoQLwWchScQdOiB; // 0x10
	private pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.hOKmnAuIQPcgJPkgpFfOAnEEgZaF NNvfWzvhxcxmZKAypGizxQopABRu; // 0x18
	private int uNgAgWMqxgEhSIWZzDxbBdYwhzxOA; // 0x20
	public pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn DVHetTpHpnzNgMUPnOqwsvgnpDrk; // 0x28
	private pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL dnBCiYlEGEuGKQYWPkdrORDnPzsM; // 0x30
	public pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL DsBHpBLXSPwZZIgjcVUBMDativbH; // 0x38
	private pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.LHiODxmbgBeHojmHGZnjCQTPkJvz UnADLXXhcSVnFnLZTjAMcBAWdTox; // 0x40
	public pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.LHiODxmbgBeHojmHGZnjCQTPkJvz cIVRqibKAdjnbCnbLVpTtyCaliKuA; // 0x44
	private int CkHqQHNHyPLBeUTtGulMKybSjtiT; // 0x48
	private int pKpwtOQStnbtOWlRlFoQFXjycbxN; // 0x4C

	// Properties
	private pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.hOKmnAuIQPcgJPkgpFfOAnEEgZaF System.Collections.Generic.IEnumerator<Rewired.Platforms.Microsoft.WindowsGamingInput.WGIInputManager.JoystickRecords.Record>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AFAF70 Offset: 0x1AFA170 VA: 0x181AFAF70 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.hOKmnAuIQPcgJPkgpFfOAnEEgZaF System.Collections.Generic.IEnumerator<Rewired.Platforms.Microsoft.WindowsGamingInput.WGIInputManager.JoystickRecords.Record>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AFB140 Offset: 0x1AFA340 VA: 0x181AFB140 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AFB070 Offset: 0x1AFA270 VA: 0x181AFB070 Slot: 4
	private IEnumerator<pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.hOKmnAuIQPcgJPkgpFfOAnEEgZaF> System.Collections.Generic.IEnumerable<Rewired.Platforms.Microsoft.WindowsGamingInput.WGIInputManager.JoystickRecords.Record>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AFB070 Offset: 0x1AFA270 VA: 0x181AFB070 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
private class pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn // TypeDefIndex: 12880
{
	// Fields
	private List<pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.hOKmnAuIQPcgJPkgpFfOAnEEgZaF> SulmidkruIEagtCCOTFXkhNtncaX; // 0x10

	// Methods

	// RVA: 0x1B0C500 Offset: 0x1B0B700 VA: 0x181B0C500
	public void .ctor() { }

	// RVA: 0x1B0C140 Offset: 0x1B0B340 VA: 0x181B0C140
	public void QSlpmrDqCyaQIWNmbdvfspAPDmZD(pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL ) { }

	// RVA: 0x1B0C0A0 Offset: 0x1B0B2A0 VA: 0x181B0C0A0
	public IEnumerable<pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.hOKmnAuIQPcgJPkgpFfOAnEEgZaF> NJnmrqwCIDQmvpFIoQclRHHGHsHf(pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL , pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.LHiODxmbgBeHojmHGZnjCQTPkJvz ) { }

	// RVA: 0x1B0C570 Offset: 0x1B0B770 VA: 0x181B0C570
	private void mbBqGDtvDnzRgCyJofIHgtMdhhRB(int , Guid , int ) { }
}

// Namespace: 
internal class pEkQmspfxhEFJdVnmKrxFByYSOih : PlatformInputManager // TypeDefIndex: 12881
{
	// Fields
	private encotVnpPeJXsxfLeEaGCyOYdiHy IDERXQEGVtWxvHNJSBcjYUGgchKG; // 0x38
	private List<pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL> tCXEFXzLlwBvVoFClwTnodulSSsN; // 0x40
	private int kOnfhrfhmJYmvqmABdTgFHhVtTtCA; // 0x48
	private pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn DlievOCucnmojhhdcXyKVQTdrTJdB; // 0x50
	private bool dFPrcFfqbRRaAJqVxHfYvwEmLqkv; // 0x58
	private ConfigVars IBIMlvpPouiATbIdVdRSprliffReb; // 0x60
	private Action<int, ControllerDataUpdater> fHMGMxQkISQsfppdqvuoyBFLgHVhA; // 0x68
	private PlatformInputManager nILBYXWuTFiuiPKLAaGCCrmAZTMi; // 0x70
	private readonly Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> PVjsWtiCHHzdlFdTJDxGWSjPufLE; // 0x78
	private readonly Func<int> QealEOQnSUaSsIDENbjPVwwhDbFM; // 0x80
	private Func<PidVid, bool> sFUjQLILmuaPxPXRsYKSJJuSsVag; // 0x88

	// Properties
	[CustomObfuscation(rename = False)]
	public override int deviceCount { get; }
	[CustomObfuscation(rename = False)]
	public override PlatformInputManager primaryInputManager { get; }
	[CustomObfuscation(rename = False)]
	public override IInputSource inputSource { get; }
	[CustomObfuscation(rename = False)]
	public override InputSource inputSourceType { get; }
	protected encotVnpPeJXsxfLeEaGCyOYdiHy XMMRdbbyOWkzQtAlQTTNZviUUWNE { get; }

	// Methods

	// RVA: 0x1B0D550 Offset: 0x1B0C750 VA: 0x181B0D550
	public void .ctor(ConfigVars , Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> , Func<int> , Func<PidVid, bool> ) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0 Slot: 4
	public override int get_deviceCount() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 5
	public override PlatformInputManager get_primaryInputManager() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 6
	public override IInputSource get_inputSource() { }

	// RVA: 0x1971670 Offset: 0x1970870 VA: 0x181971670 Slot: 7
	public override InputSource get_inputSourceType() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0CAB0 Offset: 0x1B0BCB0 VA: 0x181B0CAB0 Slot: 8
	public override void Initialize() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0D110 Offset: 0x1B0C310 VA: 0x181B0D110 Slot: 9
	public override void Update(UpdateLoopType updateLoop) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0CDF0 Offset: 0x1B0BFF0 VA: 0x181B0CDF0 Slot: 10
	public override void OnDestroy() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 14
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0CFF0 Offset: 0x1B0C1F0 VA: 0x181B0CFF0 Slot: 13
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0CFB0 Offset: 0x1B0C1B0 VA: 0x181B0CFB0 Slot: 11
	public override void SystemDeviceConnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0CFD0 Offset: 0x1B0C1D0 VA: 0x181B0CFD0 Slot: 12
	public override void SystemDeviceDisconnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0C8C0 Offset: 0x1B0BAC0 VA: 0x181B0C8C0 Slot: 16
	public override IUnifiedMouseSource GetUnifiedMouseSource() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0C8C0 Offset: 0x1B0BAC0 VA: 0x181B0C8C0 Slot: 17
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource() { }

	// RVA: 0x1B0C6A0 Offset: 0x1B0B8A0 VA: 0x181B0C6A0
	protected bool BKTmiVXMVnmQULKIsjDPvauEuBCb(PidVid ) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	protected encotVnpPeJXsxfLeEaGCyOYdiHy TYdipyekyFqTFuESFVXvBDFuJSdD() { }

	// RVA: 0x1B0E180 Offset: 0x1B0D380 VA: 0x181B0E180
	private void vrXcjsobGRPOQkcqoJyxghnKxiDc() { }

	// RVA: 0x1B0E1E0 Offset: 0x1B0D3E0 VA: 0x181B0E1E0
	private void vrXcjsobGRPOQkcqoJyxghnKxiDc(IList<MIOJgYPafWOQIwfaIjCaCewaCqYab> ) { }

	// RVA: 0x1B0C6D0 Offset: 0x1B0B8D0 VA: 0x181B0C6D0
	private void EDqiRihAgeikiyyizEaieoPwMpfN() { }

	// RVA: 0x1B0D8F0 Offset: 0x1B0CAF0 VA: 0x181B0D8F0
	private IList<MIOJgYPafWOQIwfaIjCaCewaCqYab> gYTtiwdIOcerTYXymZgtbTcRnEGG() { }

	// RVA: 0x1B0DA50 Offset: 0x1B0CC50 VA: 0x181B0DA50
	private void lvGFmxhcstGMVoMECCYcTSqWkmYEA(int , int , List<pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL> , List<pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL> ) { }

	// RVA: 0x1B0C760 Offset: 0x1B0B960 VA: 0x181B0C760
	private bool EmIbcihNKcfahEdPNkNvyKTqbFSBA(List<pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL> , int ) { }

	// RVA: 0x1B0C810 Offset: 0x1B0BA10 VA: 0x181B0C810
	private int GXswpAmwYGnaOEscIWbCFcwtPYlc(List<pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL> ) { }

	// RVA: 0x1B0CF10 Offset: 0x1B0C110 VA: 0x181B0CF10
	private bool QQDvYEixELbTassiWcXbcaGsoOnJA(List<pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL> , int ) { }

	// RVA: 0x1B0D720 Offset: 0x1B0C920 VA: 0x181B0D720
	private void bUIRusHJNhaUnzuTByaGnEBIdrcP(int , List<pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL> , int , List<pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL> , pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.LHiODxmbgBeHojmHGZnjCQTPkJvz ) { }

	// RVA: 0x1B0DEE0 Offset: 0x1B0D0E0 VA: 0x181B0DEE0
	private void vCCQvFbXkGNioBRbuhhCBUHFoapO(int , List<pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL> , pEkQmspfxhEFJdVnmKrxFByYSOih.nJbUNLbLxupHfNiAQBjKMWiQFjOn.LHiODxmbgBeHojmHGZnjCQTPkJvz ) { }

	// RVA: 0x1B0CBB0 Offset: 0x1B0BDB0 VA: 0x181B0CBB0
	private void LSKfZQhPjWUsfsDkadTZxwURBiQR() { }

	// RVA: 0x1B0CC40 Offset: 0x1B0BE40 VA: 0x181B0CC40
	private bool OiQuLVMfoMdtRTKzFCATkEziYcxjA(IList<MIOJgYPafWOQIwfaIjCaCewaCqYab> ) { }

	// RVA: 0x1B0D460 Offset: 0x1B0C660 VA: 0x181B0D460
	private bool VXdPTQcGnoEYdcLsMFuDYSqFUyOrA(Guid ) { }

	// RVA: 0x1B0D940 Offset: 0x1B0CB40 VA: 0x181B0D940
	private bool iItckfiRNWWZDfxJhoUrQHIbGwdfA(IList<MIOJgYPafWOQIwfaIjCaCewaCqYab> , Guid ) { }

	// RVA: 0x1B0E7F0 Offset: 0x1B0D9F0 VA: 0x181B0E7F0
	private void yxRHBgNggDUCxchuqMlGZcjMdPpx(List<pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL> , List<pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL> , bool ) { }

	// RVA: 0x1B0C8E0 Offset: 0x1B0BAE0 VA: 0x181B0C8E0
	private void IVzNGUHBSVASmBXPBtbBQztlCatXA(pEkQmspfxhEFJdVnmKrxFByYSOih.ZnHtxKtexzEVJSPRpwiTIAytfnZL , bool ) { }
}

// Namespace: 
internal class encotVnpPeJXsxfLeEaGCyOYdiHy : IDisposable, IInputSource // TypeDefIndex: 12882
{
	// Fields
	private static MtRjUhpXuLnjGhlzwhWxZYToKTSt muUSzTugBqoTfOknbVBaytzfROHE; // 0x0
	private List<MIOJgYPafWOQIwfaIjCaCewaCqYab> hHKSGUNDSWHMybqMWNytDRaOPDfL; // 0x10
	private ReadOnlyCollection<MIOJgYPafWOQIwfaIjCaCewaCqYab> KArnbKzjqEElxdXYviJjLwMWZzwm; // 0x18
	private ConfigVars tlDrmKanylERUGZkBiXspbbjtcxx; // 0x20
	private readonly bool UnVpPKqKfHDDcHbUMMuzjjrTcyPm; // 0x28
	private readonly bool sBBrAaWNzOOUTcvkkLTDtsAVdXIJ; // 0x29
	private readonly bool TXqfyuTRAvVjKlECXdyvBtffBwxtA; // 0x2A
	private bool VKCBSrVwrGCegBInhiXjizxojyIF; // 0x2B
	[CompilerGenerated]
	private Action FBAjeSTsQcBmauVgGpZaxptSoWtG; // 0x30
	private readonly bool KujDOomewYdJHPuJjZLlszvpoxSL; // 0x38
	private readonly bool dDhvfxcqanAmguPkeerbKwwwaRpc; // 0x39
	private readonly bool lVOyokGzwPJOTScVACMLYFNmkqFO; // 0x3A
	private int dtxchDiKwErSIfAJetIjRBMXWbuZ; // 0x3C
	private bool tWrHppWIAOgsmebPZMvOqKHfoYRAb; // 0x40
	private static readonly string tgrvmGTYXsmqOPErLEwucnZgeHwXA; // 0x8
	private bool KbxbxdFRwCxlESZSXPtZDThmvMJq; // 0x41

	// Properties
	public IUnifiedKeyboardSource fnfswkwUZESXwhxCRuvuPNubEAsg { get; }
	public IUnifiedMouseSource XDxviRLNrxtWHxPfzFRbHXlGwMHg { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B07260 Offset: 0x1B06460 VA: 0x181B07260
	private void qmGDKPyKAUAVGGnckAInGCdtZrfs(Action ) { }

	[CompilerGenerated]
	// RVA: 0x1B07590 Offset: 0x1B06790 VA: 0x181B07590
	private void ujgbeEghFllSHrZbjxkpOUApXqsI(Action ) { }

	// RVA: 0x1B06C60 Offset: 0x1B05E60 VA: 0x181B06C60
	public void .ctor(ConfigVars , bool , bool , bool ) { }

	// RVA: 0x1B06970 Offset: 0x1B05B70 VA: 0x181B06970
	public void HVhIKLsfnSRkiJXspKUAXaaWkkuC() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public IUnifiedKeyboardSource cMGrAfrWOBatXpidpvIvYFRYFIcbA() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public IUnifiedMouseSource woiUWWQKlHkuXpFErjTtlPKRAxil() { }

	// RVA: 0x1B07C00 Offset: 0x1B06E00 VA: 0x181B07C00
	public bool vtNRgcBPJnzufvYljDjMSEBTOWiv(PidVid ) { }

	// RVA: 0x1B07260 Offset: 0x1B06460 VA: 0x181B07260 Slot: 5
	public void add_DeviceChangedEvent(Action value) { }

	// RVA: 0x1B07590 Offset: 0x1B06790 VA: 0x181B07590 Slot: 6
	public void remove_DeviceChangedEvent(Action value) { }

	// RVA: 0x1B06980 Offset: 0x1B05B80 VA: 0x181B06980 Slot: 8
	public void SystemDeviceDisconnected() { }

	// RVA: 0x1B06980 Offset: 0x1B05B80 VA: 0x181B06980 Slot: 7
	public void SystemDeviceConnected() { }

	// RVA: 0x1B06B70 Offset: 0x1B05D70 VA: 0x181B06B70 Slot: 9
	public void Update() { }

	// RVA: 0x1B069B0 Offset: 0x1B05BB0 VA: 0x181B069B0 Slot: 10
	public void UpdateDevices(UpdateLoopType updateLoop) { }

	// RVA: 0x1B06AC0 Offset: 0x1B05CC0 VA: 0x181B06AC0 Slot: 11
	public void UpdateFinished() { }

	// RVA: -1 Offset: -1 Slot: 12
	public IList<T> GetJoysticks<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD7100 Offset: 0xAD6300 VA: 0x180AD7100
	|-encotVnpPeJXsxfLeEaGCyOYdiHy.GetJoysticks<object>
	*/

	// RVA: 0x1B07630 Offset: 0x1B06830 VA: 0x181B07630
	private void vrXcjsobGRPOQkcqoJyxghnKxiDc(bool ) { }

	// RVA: 0x1B06980 Offset: 0x1B05B80 VA: 0x181B06980
	private void oXeadnIKtyJataZfCQSGTXNhZGtiB() { }

	// RVA: 0x1B07570 Offset: 0x1B06770 VA: 0x181B07570
	private int qVTeZYBRbjBfKXPxHbNVDERiiANcB() { }

	// RVA: 0x1B07C80 Offset: 0x1B06E80 VA: 0x181B07C80
	private void xikGZJHBGGtFqGGfzlnUbZaZXycKA(bool ) { }

	// RVA: 0x1B06900 Offset: 0x1B05B00 VA: 0x181B06900 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B07300 Offset: 0x1B06500 VA: 0x181B07300 Slot: 1
	protected override void kONViQuzxwhRMrNRqosajBxGDJsI() { }

	// RVA: 0x1B07370 Offset: 0x1B06570 VA: 0x181B07370 Slot: 14
	protected virtual void mVrnEUyZIqoeCODwGZpTwLyPKBgN(bool ) { }

	// RVA: 0x1B06C10 Offset: 0x1B05E10 VA: 0x181B06C10
	private static void .cctor() { }
}

// Namespace: 
protected abstract class AvHABkrdMYcWqgwMnuzvHFDRpDYo.jrbFNcACIVmohbbVBeUaELsyJwOUA<> // TypeDefIndex: 12883
{
	// Fields
	public  gBhZiBjgMbgcPfoNhnAFhKfjMHmLB; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AvHABkrdMYcWqgwMnuzvHFDRpDYo.jrbFNcACIVmohbbVBeUaELsyJwOUA<float>..ctor
	|-AvHABkrdMYcWqgwMnuzvHFDRpDYo.jrbFNcACIVmohbbVBeUaELsyJwOUA<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
protected class AvHABkrdMYcWqgwMnuzvHFDRpDYo.aOoCocRffVtFurOtOPrYabKhovuV : AvHABkrdMYcWqgwMnuzvHFDRpDYo.jrbFNcACIVmohbbVBeUaELsyJwOUA<float> // TypeDefIndex: 12884
{
	// Methods

	// RVA: 0x1B02D90 Offset: 0x1B01F90 VA: 0x181B02D90
	public void .ctor() { }
}

// Namespace: 
internal abstract class AvHABkrdMYcWqgwMnuzvHFDRpDYo : MIOJgYPafWOQIwfaIjCaCewaCqYab, IDisposable // TypeDefIndex: 12885
{
	// Fields
	protected readonly WGIDeviceType xzMTQwmhWkISsGWIQbtBcnQllDRM; // 0x10
	private int GaGoYrvPNRlyHsLxfalBohNcosig; // 0x14
	protected readonly Guid JyzEdkAbNbxABgJyWcyFlkkleEdEb; // 0x18
	protected readonly Guid KgyqzdlyrFHwhfFsudpHWLuYqTst; // 0x28
	protected readonly PidVid vnXfAICxEsGfSKFbsrkqOAEWXGFjA; // 0x38
	protected readonly ushort LLUdXbgFotCNsTnwoFQihTztifjI; // 0x3C
	protected readonly ushort AuisvqpkqSwkXPGpJwqKukFQXdDP; // 0x3E
	protected readonly string piZNsgURPWYMfMWhuBMeLpnrLDqK; // 0x40
	protected readonly string QsQQkYOYKcFOIRSsfCpDVBXtDiSy; // 0x48
	protected readonly bool pRTuYSHekDNwhoWWdeAiHUdVFtKE; // 0x50
	private kRJkzPIXuVPklLlPsilzkLvDDwgP gzajuCOWgOJxYYxNLCeBbVuYimNV; // 0x58
	private Controller.Extension fRjOjkSVXuMBNygRUkRCRIKVKoLn; // 0x60
	protected readonly ButtonLoopSet CAyWKjmrbXBRjRKfiAjWymZSQsHL; // 0x68
	protected readonly AvHABkrdMYcWqgwMnuzvHFDRpDYo.aOoCocRffVtFurOtOPrYabKhovuV[] wOOnAJQqKYfnsXCyFfllltuvJSVQ; // 0x70
	protected readonly int UhYnfQOGNDrKxAuLtyetnAJeNZxc; // 0x78
	protected readonly int aqlmSPGvhAAbSdNkbFCvPmncVimU; // 0x7C
	protected readonly int dJQawyeZexAJBqOemekTeiNjzdswb; // 0x80
	private readonly bool WkXKeJpFVdmqjarpACzXeqACxCKp; // 0x84
	private readonly PidVid ceFGLkDChRCheMxemVQlBrsKeqsDA; // 0x86
	private bool KbxbxdFRwCxlESZSXPtZDThmvMJq; // 0x8A

	// Properties
	public InputSource ZVeDPUhiefDMuFjbkWlGBlKWdAnWb { get; }
	public int CjKelrkZOuDaTxxLNnoeQkdTDuncb { get; }
	public string OPdSqjOmnCHzIITineycGMlNKVFg { get; }
	public Guid XMiRoEPOmoGILiiBGhjmyxZvvFQt { get; }
	public PidVid IwOGGWmqGFjrPewNqpKKmVMcZrVM { get; }
	public ushort xCFMXdrgZHxTjLjcbdRcddRgioee { get; }
	public ushort piJVzPYaMPVrdEDFlcKYFHMboDGtA { get; }
	public Guid CaZDKKOWPGgYVreaQxvuHptDnjpR { get; }
	public int SydSFHyODpRAUczGYmRIZqbqfYpZ { get; }
	public int VgQDEtcgltQWAuTsTNqqxePkbYv { get; }
	public int yHnCBeXIXvICHdkUKBvRSfURSRwi { get; }
	public abstract bool RYdyzgRUZKgWhkWGabsJQlXyxWzD { get; }
	public abstract int hhuKplWmtLIzpenWEcucNgAVXyeK { get; }
	public WGIDeviceType vjNaXJxRDCWTAJsFEWYVTnEwhTHO { get; }
	public bool vzwujMHSYeoGzQqmPGfvvLGDuPjo { get; }
	public Controller.Extension XUzVDFIyoXgHKkMJqGEjofuMCnxp { get; }

	// Methods

	// RVA: 0x1AF8110 Offset: 0x1AF7310 VA: 0x181AF8110
	public void .ctor(WGIDeviceType , kRJkzPIXuVPklLlPsilzkLvDDwgP , int , int , int , int ) { }

	// RVA: 0x1971670 Offset: 0x1970870 VA: 0x181971670 Slot: 4
	public InputSource bJkwhkRUHYfftGJCNMxkKboqQXUC() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 5
	public int mXPjcVhMhhYPXImbtyzSJYQtUaxe() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 6
	public string FgYOfsJXSNcdTZzeDwllumnSeYGCA() { }

	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820 Slot: 7
	public Guid CePtiZWWtPGmfXpwqCoKiNpbUVmi() { }

	// RVA: 0x1AF7EE0 Offset: 0x1AF70E0 VA: 0x181AF7EE0 Slot: 8
	public PidVid BMTxhFbnhHLtsIcPxRfwvCIvKamG() { }

	// RVA: 0x1AF8000 Offset: 0x1AF7200 VA: 0x181AF8000 Slot: 9
	public ushort NYYkZyuFECoXbppvvwjPaTOghiUC() { }

	// RVA: 0x1AF8010 Offset: 0x1AF7210 VA: 0x181AF8010 Slot: 10
	public ushort OmjRDZZDRhjixGNLbUqfLeJQplDB() { }

	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80 Slot: 11
	public Guid UriZCaMgsYGuPRUOuZxRPCjKyiLB() { }

	// RVA: 0x1AF8A50 Offset: 0x1AF7C50 VA: 0x181AF8A50 Slot: 12
	public int gEcCmOtubNeJIMvpttUOORXikljP() { }

	// RVA: 0x1AF8A30 Offset: 0x1AF7C30 VA: 0x181AF8A30 Slot: 13
	public int ahEawMUNBsFyZVoLOCvPGBqGWHqjA() { }

	// RVA: 0x1A6BA60 Offset: 0x1A6AC60 VA: 0x181A6BA60 Slot: 14
	public int NNcFvuFpFKSkfAiYwnTYgVjSxVqiA() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool get_SupportsVibration();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract int get_VibrationMotorCount();

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 17
	public WGIDeviceType cBfnyPclnfQmNkeEOPADUQnkryLU() { }

	// RVA: 0x1AF8A70 Offset: 0x1AF7C70 VA: 0x181AF8A70 Slot: 18
	public bool gsbjtifHuIFLTLhudmzaKPmbIKKe() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 19
	public Controller.Extension xEOOXtuGNppvhhEGsxKvYTHRmtmK() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void SetVibration(int motorIndex, float amount, bool stopOtherMotors);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void StopVibration();

	// RVA: 0x1AF7F70 Offset: 0x1AF7170 VA: 0x181AF7F70 Slot: 22
	public bool JGDQHEtIojOrseFMsraOcCyeFxrcA(int ) { }

	// RVA: 0x1AF8B70 Offset: 0x1AF7D70 VA: 0x181AF8B70 Slot: 23
	public float vnCvKvBouGzkuuAXKItHRJiObMoL(int ) { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380 Slot: 24
	public int cAuZpwUovfBCzEutWWHbMRuRhwqlA(int ) { }

	// RVA: 0x1AF8020 Offset: 0x1AF7220 VA: 0x181AF8020 Slot: 33
	public virtual void PpYQpJQBxqOFeLBgXEfpbgskzwmH(MIOJgYPafWOQIwfaIjCaCewaCqYab ) { }

	// RVA: 0x1AF8B10 Offset: 0x1AF7D10 VA: 0x181AF8B10 Slot: 34
	public virtual void tTXyaaeEzjIaNmrQLfIUdXCtvFXS(UpdateLoopType ) { }

	// RVA: 0x1AF80B0 Offset: 0x1AF72B0 VA: 0x181AF80B0 Slot: 35
	public virtual void ZiaSbEmYMXYlvvANYzEPXNViWPXH() { }

	// RVA: 0x1AF7F00 Offset: 0x1AF7100 VA: 0x181AF7F00 Slot: 28
	public void Dispose() { }

	// RVA: 0x1AF8A80 Offset: 0x1AF7C80 VA: 0x181AF8A80 Slot: 1
	protected override void kONViQuzxwhRMrNRqosajBxGDJsI() { }

	// RVA: 0x1AF8AF0 Offset: 0x1AF7CF0 VA: 0x181AF8AF0 Slot: 37
	protected virtual bool mVrnEUyZIqoeCODwGZpTwLyPKBgN(bool ) { }
}

// Namespace: 
private class WindowsGamingInputControllerExtension.xKAyyzjLYTQiTTjOJhyyFztRATiB : IControllerExtensionSource // TypeDefIndex: 12886
{
	// Fields
	private MIOJgYPafWOQIwfaIjCaCewaCqYab fvGczAbUTnOsQZxEkKBZAlIqpKqdb; // 0x10

	// Properties
	public MIOJgYPafWOQIwfaIjCaCewaCqYab vayYsDlWmJSjVsiIyldRuudAbgTO { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public MIOJgYPafWOQIwfaIjCaCewaCqYab DOWDVbnDLGOMYPDHWRfOnPIDFVzy() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(MIOJgYPafWOQIwfaIjCaCewaCqYab ) { }
}

// Namespace: Rewired.Platforms.Microsoft.WindowsGamingInput
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class WindowsGamingInputControllerExtension : Controller.Extension, IHIDControllerExtension // TypeDefIndex: 12887
{
	// Fields
	private WindowsGamingInputControllerExtension.xKAyyzjLYTQiTTjOJhyyFztRATiB wvNCxsivovgYNctGzUySbEcWiXuG; // 0x28
	private bool UcXaTfhPEwsGenCoMrbNdgEcYnpcA; // 0x30

	// Properties
	public string productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	public ushort vendorId { get; }
	public ushort productId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x1AFE330 Offset: 0x1AFD530 VA: 0x181AFE330
	internal void .ctor(MIOJgYPafWOQIwfaIjCaCewaCqYab ) { }

	// RVA: 0x197EC50 Offset: 0x197DE50 VA: 0x18197EC50
	private void .ctor(WindowsGamingInputControllerExtension ) { }

	// RVA: 0x1AFE470 Offset: 0x1AFD670 VA: 0x181AFE470 Slot: 10
	public string get_productName() { }

	// RVA: 0x1AFE0B0 Offset: 0x1AFD2B0 VA: 0x181AFE0B0 Slot: 11
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x1AFE560 Offset: 0x1AFD760 VA: 0x181AFE560 Slot: 8
	public ushort get_vendorId() { }

	// RVA: 0x1AFE3A0 Offset: 0x1AFD5A0 VA: 0x181AFE3A0 Slot: 9
	public ushort get_productId() { }

	// RVA: 0x1AFE0F0 Offset: 0x1AFD2F0 VA: 0x181AFE0F0 Slot: 12
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x1AFE1C0 Offset: 0x1AFD3C0 VA: 0x181AFE1C0 Slot: 13
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x1AFE320 Offset: 0x1AFD520 VA: 0x181AFE320 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1AFE290 Offset: 0x1AFD490 VA: 0x181AFE290 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x1AFE050 Offset: 0x1AFD250 VA: 0x181AFE050 Slot: 7
	internal override Controller.Extension Clone() { }
}

// Namespace: 
internal abstract class kRJkzPIXuVPklLlPsilzkLvDDwgP : KvzQgbgabeomEgHUAEBrUeMfHBzJ // TypeDefIndex: 12888
{
	// Methods

	// RVA: 0x19B4B90 Offset: 0x19B3D90 VA: 0x1819B4B90
	protected void .ctor(aRtvfjIkdxLYMsoTTeHvFSNygSzJ ) { }
}

// Namespace: 
internal class ZMahQVthSLKqbJpEnQafVTggvNXP : kRJkzPIXuVPklLlPsilzkLvDDwgP // TypeDefIndex: 12889
{
	// Fields
	private static bool GmEBAXAhWGmbJipQFidnPDxnGWEQc; // 0x0
	private static PidVid[] zAHBfDfMOBfAZWomjBPiHoaZFMJHA; // 0x8
	[CompilerGenerated]
	private static Action<ZMahQVthSLKqbJpEnQafVTggvNXP> RYyaUbBCLkqJiUAYIddoHXwvSWBjA; // 0x10
	[CompilerGenerated]
	private static Action<ZMahQVthSLKqbJpEnQafVTggvNXP> aRbGfvUYMDpthBNLzIeMwBzcATRd; // 0x18

	// Properties
	public tpBEkSPbhGFZAskthAKVELrwzbhGA gKasJUeWVPWDrNfkCEuuOyOQYSJD { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1AFFF70 Offset: 0x1AFF170 VA: 0x181AFFF70
	public static void vkpFIsQrDimnJlxVHonrBVOzJMIG(Action<ZMahQVthSLKqbJpEnQafVTggvNXP> ) { }

	[CompilerGenerated]
	// RVA: 0x1AFFB90 Offset: 0x1AFED90 VA: 0x181AFFB90
	public static void qDReaeBCSrEXlNhfHbZdOYMPUOdMA(Action<ZMahQVthSLKqbJpEnQafVTggvNXP> ) { }

	[CompilerGenerated]
	// RVA: 0x1AFF5D0 Offset: 0x1AFE7D0 VA: 0x181AFF5D0
	public static void TpPjiAjwfjFANpcYbajFiYCkdbgI(Action<ZMahQVthSLKqbJpEnQafVTggvNXP> ) { }

	[CompilerGenerated]
	// RVA: 0x1AFFA80 Offset: 0x1AFEC80 VA: 0x181AFFA80
	public static void pBayvPuuVRdIHVZtngrVNhPJNHeJ(Action<ZMahQVthSLKqbJpEnQafVTggvNXP> ) { }

	// RVA: 0x1B00080 Offset: 0x1AFF280 VA: 0x181B00080
	public static void vojemuchleMDIhMiqQDKEyRAihxW() { }

	// RVA: 0x1AFF7A0 Offset: 0x1AFE9A0 VA: 0x181AFF7A0
	public static void WGQxqfCajLkkwfaIpGIZIRZUySpM() { }

	// RVA: 0x1AFEE70 Offset: 0x1AFE070 VA: 0x181AFEE70
	public static void AqyNTIfkhCgkkaNbHkYPcktJEPWCc(List<ZMahQVthSLKqbJpEnQafVTggvNXP> ) { }

	// RVA: 0x1AFFD60 Offset: 0x1AFEF60 VA: 0x181AFFD60
	public static bool tQalKxhnqOXExpocuWklhFMYmCWg(ushort , ushort ) { }

	// RVA: 0x1AFF410 Offset: 0x1AFE610 VA: 0x181AFF410
	private static bool GFUGHXjAXnKpcdqgbaVSRrYgTtZDc(ushort , ushort , XjMAPkGEmrzaOjIwaiEUGGkgTuqgc ) { }

	// RVA: 0x1AFF330 Offset: 0x1AFE530 VA: 0x181AFF330
	private static bool EhnSdSpNjuuqRlwIynxjlAYTPOwp(ushort , ushort , ushort , ushort ) { }

	[MonoPInvokeCallback(typeof(iHiOPCIZSIjZWKAsVmzLkJvKpWIo.QTemluCUnyVDpsasNCFbggsZRyIlA))]
	// RVA: 0x1AFF6E0 Offset: 0x1AFE8E0 VA: 0x181AFF6E0
	private static void UZyvzJEUfeQjvGZWjBeJIVsAMtRB(RLJlxMomDVTaRvNWGBQuFpwNTFfrA ) { }

	[MonoPInvokeCallback(typeof(iHiOPCIZSIjZWKAsVmzLkJvKpWIo.hYcCZCLmUxANQGitPcQLxCxfTZyG))]
	// RVA: 0x1AFF510 Offset: 0x1AFE710 VA: 0x181AFF510
	private static void LJOknjhTjESpjUpwfKvnWfyjwmoA(RLJlxMomDVTaRvNWGBQuFpwNTFfrA ) { }

	// RVA: 0x19B4B90 Offset: 0x19B3D90 VA: 0x1819B4B90
	public void .ctor(aRtvfjIkdxLYMsoTTeHvFSNygSzJ ) { }

	// RVA: 0x1AFF870 Offset: 0x1AFEA70 VA: 0x181AFF870
	public void YulAvljXgGhXLEcHTHpFxLonoKkT(tpBEkSPbhGFZAskthAKVELrwzbhGA ) { }

	// RVA: 0x1AFFCA0 Offset: 0x1AFEEA0 VA: 0x181AFFCA0
	public uZcaMyJgsoPIfjthKfCwZZBbPoFR rPEdiYYxHfDGhJvHQyQISqFzrPwUA() { }

	// RVA: 0x1AFF190 Offset: 0x1AFE390 VA: 0x181AFF190 Slot: 0
	public override bool CyXDMrBLXtCsOiZFcTBytzvLGZzD(object ) { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int eTMQGbIbZFqfUKANgYNRwRsjmzQV() { }

	// RVA: 0x1AFF2A0 Offset: 0x1AFE4A0 VA: 0x181AFF2A0
	public bool CyXDMrBLXtCsOiZFcTBytzvLGZzD(ZMahQVthSLKqbJpEnQafVTggvNXP ) { }

	// RVA: 0x1AFF360 Offset: 0x1AFE560 VA: 0x181AFF360
	public static bool FLtXVczRrXFerCcddSZUjurbyGeY(ZMahQVthSLKqbJpEnQafVTggvNXP , ZMahQVthSLKqbJpEnQafVTggvNXP ) { }

	// RVA: 0x1AFF9D0 Offset: 0x1AFEBD0 VA: 0x181AFF9D0
	public static bool htNXOnahiDPRRQIOUzvZasJyFhPl(ZMahQVthSLKqbJpEnQafVTggvNXP , ZMahQVthSLKqbJpEnQafVTggvNXP ) { }

	// RVA: 0x1AFF930 Offset: 0x1AFEB30 VA: 0x181AFF930
	private static void .cctor() { }
}

// Namespace: 
internal class XjMAPkGEmrzaOjIwaiEUGGkgTuqgc : kRJkzPIXuVPklLlPsilzkLvDDwgP, kBEhpxljPMAbboCmNbKsjaTEdEdib // TypeDefIndex: 12890
{
	// Properties
	public bool fEXrmPHYtmRbubckIdCqhggfqlexA { get; }
	public int VgQDEtcgltQWAuTsTNqqxePkbYv { get; }
	public int SydSFHyODpRAUczGYmRIZqbqfYpZ { get; }
	public ushort wqOljtbJjmVXzalgMFMXuEAfGjmV { get; }
	public ushort hhpCnQOgTFKaUbedOtTZeQXwlXkE { get; }
	public int fpbmvRjoqgILlSpKWjBtvDXsRnbQ { get; }
	public string vAVqcEdaNNobtnYKPFRVNeBgCTOg { get; }
	public string PDgEZvolZlHnMhUZMybIfRXUFauF { get; }

	// Methods

	// RVA: 0x1AFE630 Offset: 0x1AFD830 VA: 0x181AFE630
	public static XjMAPkGEmrzaOjIwaiEUGGkgTuqgc JMDCDsHLsHRuPFYPGSBJwIcZEzNEA(kRJkzPIXuVPklLlPsilzkLvDDwgP ) { }

	// RVA: 0x19B4B90 Offset: 0x19B3D90 VA: 0x1819B4B90
	public void .ctor(aRtvfjIkdxLYMsoTTeHvFSNygSzJ ) { }

	// RVA: 0x1AFEAA0 Offset: 0x1AFDCA0 VA: 0x181AFEAA0 Slot: 11
	public bool YbrdrjDkVDTLhwdQpczQgIoIJnoSA() { }

	// RVA: 0x1AFEB40 Offset: 0x1AFDD40 VA: 0x181AFEB40
	public int ahEawMUNBsFyZVoLOCvPGBqGWHqjA() { }

	// RVA: 0x1AFEC80 Offset: 0x1AFDE80 VA: 0x181AFEC80
	public int gEcCmOtubNeJIMvpttUOORXikljP() { }

	// RVA: 0x1AFE7C0 Offset: 0x1AFD9C0 VA: 0x181AFE7C0
	public ushort KbvCeDbvhxsBEoOahXOSWIPGsgic() { }

	// RVA: 0x1AFE720 Offset: 0x1AFD920 VA: 0x181AFE720
	public ushort JmbczSLChVqlpIGdNMQVjcKlgxhj() { }

	// RVA: 0x1AFEBE0 Offset: 0x1AFDDE0 VA: 0x181AFEBE0
	public int eXHbnPoHnytAphmLCMSBWxMxAaqU() { }

	// RVA: 0x1AFE860 Offset: 0x1AFDA60 VA: 0x181AFE860
	public string NhFRdYrAJGTDWsKbSPikmyOOMdir() { }

	// RVA: 0x1AFE980 Offset: 0x1AFDB80 VA: 0x181AFE980
	public string SqlBXWBzXebYSrTvzrboykioBzMw() { }

	// RVA: 0x1AFED20 Offset: 0x1AFDF20 VA: 0x181AFED20
	public bool vzwujMHSYeoGzQqmPGfvvLGDuPjo(out PidVid ) { }
}

// Namespace: 
internal struct tpBEkSPbhGFZAskthAKVELrwzbhGA // TypeDefIndex: 12891
{
	// Fields
	public double RyiFZdJRrgmMYamSffigiiysRKueA; // 0x0
	public double fSgHcTAaPrtmERuzocyZRhpDnVAh; // 0x8
	public double zJykumWcxgGHeSqBNnLjQFDVXzfl; // 0x10
	public double PqeAkPAFQrzkGMWUTBafhpoJWWfvB; // 0x18

	// Methods

	// RVA: 0x1B11100 Offset: 0x1B10300 VA: 0x181B11100 Slot: 3
	public override string TvflVDjhhkpoXcrLeFSYrPyVNckm() { }
}

// Namespace: 
internal struct uZcaMyJgsoPIfjthKfCwZZBbPoFR // TypeDefIndex: 12892
{
	// Fields
	public GamepadButtons hsLAgdGUocOMIIqpNEddcDwrOjDNA; // 0x0
	public double YnakaOLSyLBQsbbNUckkWnajVNSA; // 0x8
	public double MkUnPCrIRsfwofqDDijqFlCJBAudb; // 0x10
	public double fSgHcTAaPrtmERuzocyZRhpDnVAh; // 0x18
	public double kROkWtZbUOzXPZBWWQGlJHuNCondA; // 0x20
	public double dgDrHlNXGmrDODhseJBRtUBQVvki; // 0x28
	public double PqeAkPAFQrzkGMWUTBafhpoJWWfvB; // 0x30
	public ulong KKGKLzeymdyEaqgowzrKrqdoUjsk; // 0x38

	// Methods

	// RVA: 0x1B11230 Offset: 0x1B10430 VA: 0x181B11230 Slot: 3
	public override string TvflVDjhhkpoXcrLeFSYrPyVNckm() { }
}

// Namespace: Rewired.Platforms.Microsoft.WindowsGamingInput
[Flags]
internal enum GamepadButtons // TypeDefIndex: 12893
{
	// Fields
	public uint value__; // 0x0
	public const GamepadButtons None = 0;
	public const GamepadButtons Menu = 1;
	public const GamepadButtons View = 2;
	public const GamepadButtons A = 4;
	public const GamepadButtons B = 8;
	public const GamepadButtons X = 16;
	public const GamepadButtons Y = 32;
	public const GamepadButtons DPadUp = 64;
	public const GamepadButtons DPadDown = 128;
	public const GamepadButtons DPadLeft = 256;
	public const GamepadButtons DPadRight = 512;
	public const GamepadButtons LeftShoulder = 1024;
	public const GamepadButtons RightShoulder = 2048;
	public const GamepadButtons LeftThumbstick = 4096;
	public const GamepadButtons RightThumbstick = 8192;
}

// Namespace: 
internal interface kBEhpxljPMAbboCmNbKsjaTEdEdib // TypeDefIndex: 12894
{
	// Properties
	public abstract bool fEXrmPHYtmRbubckIdCqhggfqlexA { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool YbrdrjDkVDTLhwdQpczQgIoIJnoSA();
}

// Namespace: 
internal interface VGOPqbLavzuXjtDkcslalsBFmiiV // TypeDefIndex: 12895
{
	// Properties
	public abstract bool GKgfNnJbkGcVVcdzdLcfsIEWzycTb { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TJoXjzEnrkbvBgocdLmRUiCvDuSFA();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void mEDGKkHEacJFGaOhqOVgcljJPWhz();
}

// Namespace: 
internal abstract class KvzQgbgabeomEgHUAEBrUeMfHBzJ : IDisposable, VGOPqbLavzuXjtDkcslalsBFmiiV // TypeDefIndex: 12896
{
	// Fields
	protected aRtvfjIkdxLYMsoTTeHvFSNygSzJ tcUvDDrILAcXlMsPNhYSDjtxyhVr; // 0x10
	private bool KbxbxdFRwCxlESZSXPtZDThmvMJq; // 0x18

	// Properties
	public bool GKgfNnJbkGcVVcdzdLcfsIEWzycTb { get; }
	public IntPtr PBMPGsrocCGfqiWmxuRYkPXcPqMl { get; }

	// Methods

	// RVA: 0x1A2D6D0 Offset: 0x1A2C8D0 VA: 0x181A2D6D0 Slot: 5
	public bool TJoXjzEnrkbvBgocdLmRUiCvDuSFA() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr sWdYSMbFHygiJbzgpSXOaeEuiXefA() { }

	// RVA: 0x19B4B90 Offset: 0x19B3D90 VA: 0x1819B4B90
	protected void .ctor(aRtvfjIkdxLYMsoTTeHvFSNygSzJ ) { }

	// RVA: 0x1AFB1F0 Offset: 0x1AFA3F0 VA: 0x181AFB1F0 Slot: 7
	public virtual void mEDGKkHEacJFGaOhqOVgcljJPWhz() { }

	// RVA: 0x1AFB180 Offset: 0x1AFA380 VA: 0x181AFB180 Slot: 8
	public virtual void Dispose() { }

	// RVA: 0x1595E50 Offset: 0x1595050 VA: 0x181595E50 Slot: 1
	protected override void kONViQuzxwhRMrNRqosajBxGDJsI() { }

	// RVA: 0x1AFB200 Offset: 0x1AFA400 VA: 0x181AFB200 Slot: 10
	protected virtual void mVrnEUyZIqoeCODwGZpTwLyPKBgN(bool ) { }
}

// Namespace: 
internal enum vbQWyQJPWwGDLbAFQLywhGZZMVUT // TypeDefIndex: 12897
{
	// Fields
	public int value__; // 0x0
	public const vbQWyQJPWwGDLbAFQLywhGZZMVUT None = 0;
	public const vbQWyQJPWwGDLbAFQLywhGZZMVUT LostFocus = 1;
	public const vbQWyQJPWwGDLbAFQLywhGZZMVUT GainedFocus = 2;
}

// Namespace: 
internal enum vpfmyClKEZtnVUOTXhXLnUnCOhDB // TypeDefIndex: 12898
{
	// Fields
	public int value__; // 0x0
	public const vpfmyClKEZtnVUOTXhXLnUnCOhDB None = 0;
	public const vpfmyClKEZtnVUOTXhXLnUnCOhDB RawInput = 1;
	public const vpfmyClKEZtnVUOTXhXLnUnCOhDB DirectInput = 2;
	public const vpfmyClKEZtnVUOTXhXLnUnCOhDB XInput = 3;
	public const vpfmyClKEZtnVUOTXhXLnUnCOhDB ManualHID = 4;
}

// Namespace: 
private class kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA : IInputManagerJoystick, IInputManagerJoystickPublic // TypeDefIndex: 12899
{
	// Fields
	private int elLFJteTiCVpSogeBWPkFnTrudWE; // 0x10
	private int fVuPgJSlpPIfSeOgsNtYBMDtpgunA; // 0x14
	public Guid ksQXSyCMArgpTQjQVaPCEGSVXoOp; // 0x18
	public string kJOmFeUAgkDdNXyTSilWpUlXspNF; // 0x28
	public readonly kfaUicXMnhcpxgTsBbcmGbCvFksfA.VbZZnYUrePFeaKkwelsmmtksPOUH ZnHDWvnHDNkaSGPplXLszqSKwueN; // 0x30
	public QhuSAobzCkqTzlMZWIYycNYLbWUd HoEEmkengTEjtjoVVsAHXLDjqKDeA; // 0x38
	public kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV HeyicogHCqKhAcHzjJVjMbPaJIFFE; // 0x40
	public string DioGwKdMhhhHNmPiSEvXwIPEHgeH; // 0x48
	public string lufcugDzGrkmtafbpDqMLPXSlCRNA; // 0x50
	public int OiMBHSbtNIhmneXPdLUborVNtHHK; // 0x58
	public Guid JyzEdkAbNbxABgJyWcyFlkkleEdEb; // 0x5C
	public Guid XfzUpElzwnbTwUFrhLwQNARHvqlW; // 0x6C
	public Guid rSsgiQBLwBxXOQgdSZXDaFKJpYUHA; // 0x7C
	public int HtJjzJNFnoRSOEdOsBCWuXjdSOUI; // 0x8C
	public bool igPGuYGgxsWGxSMkCxYbJcSJgnzO; // 0x90
	public string kwjAQknTWoswtqPxMhmqSkVKGTuL; // 0x98
	public string RGVGzdRbQBQbLxnZmcsdmlBnkgfV; // 0xA0
	public int FUtJHSvyySJCEQpkrduZIvvRPOOA; // 0xA8
	public int AgoGitaCJZRYBFvgZZssrUYswHJAA; // 0xAC
	public int SrORvcQcSYELPJTyDirjrtpZoNfKA; // 0xB0
	public int LmpluWWlOaMRxzVuDRghRTlVHtlj; // 0xB4
	public int acdSMFTSUSdLCcyHplSQOiRKoZSn; // 0xB8
	public bool SgNUcmLqANIPiqsBVJjlmXEGCdiH; // 0xBC
	public Controller.Extension dDGoAStqzcKZvnDtYfdbnRrFdRsiA; // 0xC0
	private float[] wsHpigDPzQcVMoNRfBDQAlRyqROgb; // 0xC8
	private bool[] SMjvFtmVJPKHDGGnPQKpepfMESLb; // 0xD0
	private HardwareJoystickMap_InputManager cNQOBilDgUZmDotqcVREDrrooBLe; // 0xD8
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> CxbDKKUcFsXkVOyjAXODyEMHBOYo; // 0xE0
	private bool HwWSDNGAiFPLpbJYXqmSjaEDhwTm; // 0xE8
	private bool eIQDQfZkSYmdtUBeiFMzQFUZeUMU; // 0xE9
	private bool KbxbxdFRwCxlESZSXPtZDThmvMJq; // 0xEA

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
	public int unityId { get; }
	[CustomObfuscation(rename = False)]
	public Controller.Extension extension { get; }
	[CustomObfuscation(rename = False)]
	public Guid instanceGuid { get; }
	[CustomObfuscation(rename = False)]
	public Guid persistentGuid { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 8
	public int get_rewiredId() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_rewiredId(int value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 9
	public int get_inputManagerId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_inputManagerId(int value) { }

	// RVA: 0x1B04700 Offset: 0x1B03900 VA: 0x181B04700 Slot: 10
	public string get_name() { }

	// RVA: 0x1B04780 Offset: 0x1B03980 VA: 0x181B04780 Slot: 11
	public Nullable<long> get_systemId() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	public int get_unityId() { }

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0 Slot: 13
	public Controller.Extension get_extension() { }

	// RVA: 0x77EC20 Offset: 0x77DE20 VA: 0x18077EC20 Slot: 14
	public Guid get_instanceGuid() { }

	// RVA: 0x77EC20 Offset: 0x77DE20 VA: 0x18077EC20 Slot: 15
	public Guid get_persistentGuid() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	public void SetVibration(float amount, int motorIndex) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 17
	public void StopVibration() { }

	// RVA: 0x1B04260 Offset: 0x1B03460 VA: 0x181B04260
	public void .ctor(kfaUicXMnhcpxgTsBbcmGbCvFksfA.VbZZnYUrePFeaKkwelsmmtksPOUH , Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> ) { }

	// RVA: 0x1B038D0 Offset: 0x1B02AD0 VA: 0x181B038D0
	public void TOfaVcdcUxBZvMNMLarYOrIbspsl() { }

	// RVA: 0x1B040C0 Offset: 0x1B032C0 VA: 0x181B040C0
	public void ZmNayyZnLotCnltAfPptPDSFfNbgA(kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B03D10 Offset: 0x1B02F10 VA: 0x181B03D10 Slot: 4
	public void Update() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B031B0 Offset: 0x1B023B0 VA: 0x181B031B0 Slot: 5
	public void FillData(ControllerDataUpdater dataUpdater) { }

	// RVA: 0x1B051D0 Offset: 0x1B043D0 VA: 0x181B051D0
	public int tpevtaPONvCbOPLLHaJdyPWHGzZx(kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA ) { }

	// RVA: 0x1B046A0 Offset: 0x1B038A0 VA: 0x181B046A0
	private BridgedControllerHWInfo eoNUQUHMlXQrwOfObYLDIXlpHRmJ() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B03BB0 Offset: 0x1B02DB0 VA: 0x181B03BB0 Slot: 6
	public BridgedController ToBridgedController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B03CB0 Offset: 0x1B02EB0 VA: 0x181B03CB0 Slot: 7
	public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs() { }

	// RVA: 0x1B043A0 Offset: 0x1B035A0 VA: 0x181B043A0
	public bool bAzbObCejluPbruZuTFTybRHDAPl() { }

	// RVA: 0x1B051A0 Offset: 0x1B043A0 VA: 0x181B051A0
	public void qzTAvbcUunBqbnfvaoGGAIEvAtiYA() { }

	// RVA: 0x1B043E0 Offset: 0x1B035E0 VA: 0x181B043E0
	private void bqZsUfrwXrMerppiHuLJWqqIVlrD(bool[] , int[] ) { }

	// RVA: 0x1B03DB0 Offset: 0x1B02FB0 VA: 0x181B03DB0
	private void WIpskiOWInYZQmpjrkbqBXWXXrsg(bool[] , int[] ) { }

	// RVA: 0x1B042B0 Offset: 0x1B034B0 VA: 0x181B042B0
	private void arXVdPKEuSyfzlgBBBIVpVZUxias(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base , int , bool[] , int[] ) { }

	// RVA: 0x1B04FC0 Offset: 0x1B041C0 VA: 0x181B04FC0
	private void mLIlzcHptbCUMKbxcpuvztErfMuM(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base , int , bool[] , int[] ) { }

	// RVA: 0x1B052B0 Offset: 0x1B044B0 VA: 0x181B052B0
	private float vnCvKvBouGzkuuAXKItHRJiObMoL(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base , bool[] , int[] ) { }

	// RVA: 0x1B055B0 Offset: 0x1B047B0 VA: 0x181B055B0
	private float vnCvKvBouGzkuuAXKItHRJiObMoL(DirectInputAxis ) { }

	// RVA: 0x1B03310 Offset: 0x1B02510 VA: 0x181B03310
	private bool JGDQHEtIojOrseFMsraOcCyeFxrcA(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base , bool[] , int[] ) { }

	// RVA: 0x1B03B00 Offset: 0x1B02D00 VA: 0x181B03B00
	private bool TjUSjWnSzlMKBMGNZaxRAiNROxaZ(int , int , HatType ) { }

	// RVA: 0x1B003A0 Offset: 0x1AFF5A0 VA: 0x181B003A0
	private float CyECkGYxbhqjARYFYRKcxRWKrrYo(int , AxisDirection ) { }

	// RVA: 0x1B03870 Offset: 0x1B02A70 VA: 0x181B03870
	private bool MyUsDxtkHqpkPPXHaljVideJpCIc(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData , bool[] , out bool ) { }

	// RVA: 0x1B04B10 Offset: 0x1B03D10 VA: 0x181B04B10
	private bool jZRGmOMQDCrtcxJbDdhuAINHpuxLA(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData , out float ) { }

	// RVA: 0x1B04070 Offset: 0x1B03270 VA: 0x181B04070
	private ControlDeviceType YRzkJwoitfGYlcdBECRyxMIcNpjAA(kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV ) { }

	// RVA: 0x1B04C70 Offset: 0x1B03E70 VA: 0x181B04C70
	private void kEIKNRuflotJMGPZCZrjbNEpOWZA() { }

	// RVA: 0x1B047F0 Offset: 0x1B039F0 VA: 0x181B047F0
	private string ivJwMqcgQnAEQDgLumDHXCkgoImoA() { }

	// RVA: 0x1B03060 Offset: 0x1B02260 VA: 0x181B03060
	private void FUpEnRfZKusAxqfkFZYzdRVRUyzkA(BridgedControllerHWInfo ) { }

	// RVA: 0x1B02FA0 Offset: 0x1B021A0 VA: 0x181B02FA0
	private void FUpEnRfZKusAxqfkFZYzdRVRUyzkA(BridgedController ) { }

	// RVA: 0x1B04D50 Offset: 0x1B03F50 VA: 0x181B04D50
	private UnknownControllerHat[] kODywkpNeirqKIWAOhDSThtXSQZd() { }

	// RVA: 0x1B050E0 Offset: 0x1B042E0 VA: 0x181B050E0
	public void mVrnEUyZIqoeCODwGZpTwLyPKBgN() { }

	// RVA: 0x1B04F50 Offset: 0x1B04150 VA: 0x181B04F50 Slot: 1
	protected override void kONViQuzxwhRMrNRqosajBxGDJsI() { }

	// RVA: 0x1B050A0 Offset: 0x1B042A0 VA: 0x181B050A0 Slot: 19
	protected virtual void mVrnEUyZIqoeCODwGZpTwLyPKBgN(bool ) { }

	// RVA: 0x1A67B20 Offset: 0x1A66D20 VA: 0x181A67B20
	public static int FJgHIfMCvflfNlQNRlWvXmCehpqJ(kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA , kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA ) { }

	// RVA: 0x1B05150 Offset: 0x1B04350 VA: 0x181B05150
	public static int oRkJadqKuUpDfmelYwmKmPlOndad(kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA , kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA ) { }
}

// Namespace: 
public class kfaUicXMnhcpxgTsBbcmGbCvFksfA.VbZZnYUrePFeaKkwelsmmtksPOUH.KwRYvXOfzOguyBxuTigDjmpTBvBw // TypeDefIndex: 12900
{
	// Fields
	public float KHiajpiRXfTibpigVIJyNrsoVtviA; // 0x10
	public float owMiciAlPtfYhcKHNjbcFzapmAR; // 0x14
	public float gswnykcxSNLessArcupJGmEtZfcn; // 0x18
	public float hrzXeHonNpJzHlsHnBEaRpoixBkh; // 0x1C
	public float qqbMlXsRmfCAiNIwXfskrGXrCLX; // 0x20
	public float jZvimoWmavApoBozAGwFkwjqMRymA; // 0x24
	public float[] TVzxCcMUNevRvqOpLUTwnBcyOYnQ; // 0x28
	public readonly int[] VaomcYTAaWdOMgzCiaBmGAAKhIPXA; // 0x30
	public readonly bool[] hsLAgdGUocOMIIqpNEddcDwrOjDNA; // 0x38
	public float BCgbXOkVoABjZbasaMAYpSPgelpwA; // 0x40
	public float QbAdeMkexRIiofRIIwOGkBeCbfRhb; // 0x44
	public float dXBsprbmQXKHnROCHNJWhHhbpvae; // 0x48
	public float FPDCgAXVrqyLgRPMsPjSNnRXBLNV; // 0x4C
	public float zqzrSyzCDOldOwteGijYluIWfbyH; // 0x50
	public float IOFbkhGUSJBrUmsGsoiEWqrFkynCb; // 0x54
	public readonly float[] yxtMsOFoeTfByXTibmQLYvemhSLR; // 0x58
	public float pcOKRYmJsMPEJJhXslAfXShmSDiR; // 0x60
	public float FSRTlbqsyHxyOkxTZvOMzKgTmqBg; // 0x64
	public float iOFqNUVXISqtNFlHQWwmaWftmges; // 0x68
	public float neNpnhEwvxyHCVvYLfeiqcvLrwQH; // 0x6C
	public float HYqtycvjNosgPwodaFydMtAwSjdk; // 0x70
	public float mCvMtVJHUmcAomgGpmPzaUdiENUs; // 0x74
	public readonly float[] mEGlmivxuidSpmQhCitLoddgeNYN; // 0x78
	public float qNOoYwYTOledtzgDEMMXpeSquWHl; // 0x80
	public float cxjCysgBuasmeJioYQFoNMezQlMeb; // 0x84
	public float rkImvgstIvuXgSLgcszcTglnsKyE; // 0x88
	public float oxlbSCmqAFSdywQRFxnwnnzDciqeA; // 0x8C
	public float gdGxouIuJKEAGjnvQDQkuOAIXcqF; // 0x90
	public float DwMlKjqOzGCHpKXhAtjtqZMJdbdK; // 0x94
	public readonly float[] wMZLbWjZygJneousMWqTeMQemImk; // 0x98

	// Methods

	// RVA: 0x1B17000 Offset: 0x1B16200 VA: 0x181B17000
	public void .ctor() { }

	// RVA: 0x1B16DD0 Offset: 0x1B15FD0 VA: 0x181B16DD0
	public void OsrQkkPSXhWWDTajSjZqhcSeEwcj() { }

	// RVA: 0x1B17370 Offset: 0x1B16570 VA: 0x181B17370
	public void eiwfAiHePqHigTJKZIEcijyklAltb(kfaUicXMnhcpxgTsBbcmGbCvFksfA.VbZZnYUrePFeaKkwelsmmtksPOUH.KwRYvXOfzOguyBxuTigDjmpTBvBw ) { }

	// RVA: 0x1B170D0 Offset: 0x1B162D0 VA: 0x181B170D0
	public void eiwfAiHePqHigTJKZIEcijyklAltb(ref LowLevelInputEvent ) { }

	// RVA: 0x1B162D0 Offset: 0x1B154D0 VA: 0x181B162D0
	public static void BDmEwpJwNwbhrNENmYNZCtGLCCeo(ykZUMGNAQyZSwLzzZpTqJiPtVyMF , double , LowLevelInputEvent ) { }
}

// Namespace: 
private class kfaUicXMnhcpxgTsBbcmGbCvFksfA.VbZZnYUrePFeaKkwelsmmtksPOUH : IDisposable // TypeDefIndex: 12901
{
	// Fields
	private readonly int UhYnfQOGNDrKxAuLtyetnAJeNZxc; // 0x10
	private readonly ButtonLoopSet CAyWKjmrbXBRjRKfiAjWymZSQsHL; // 0x18
	private readonly DualThreadLowLevelInputEventQueue UclGjzhWaZdLnQhuiMmwfRjfkEnFA; // 0x20
	private kfaUicXMnhcpxgTsBbcmGbCvFksfA.yvGOqfNGIpGLTFSxwoMAvDaoPdHOA EYtOLroCEdIqEXhCPmAeGhvcrZku; // 0x28
	private readonly ykZUMGNAQyZSwLzzZpTqJiPtVyMF tnXCqdNNNOwdLPRZSuXINxUzGkIF; // 0x30
	private readonly ykZUMGNAQyZSwLzzZpTqJiPtVyMF cPESpAfRbDRzryWGluKoWrtTtmnq; // 0x38
	private readonly object GIBOEJQosYydSIDjVKLDxzrPTWIp; // 0x40
	private bool GMJBZnbBPZJxjiGVOzUIPVMdcGYab; // 0x48
	public readonly KRaUSsFBBHJDPgcjZWrEYoMMPWwn bJfMUzQKWYcdliDtvhoxVhbOBmtdb; // 0x50
	private readonly kfaUicXMnhcpxgTsBbcmGbCvFksfA.VbZZnYUrePFeaKkwelsmmtksPOUH.KwRYvXOfzOguyBxuTigDjmpTBvBw crwGDpDiSquSCCOMhNqpveFBXGCuA; // 0x58
	private bool KbxbxdFRwCxlESZSXPtZDThmvMJq; // 0x60

	// Properties
	public bool[] efuqCgjcYhwEemtjVjCZIYeMQRNH { get; }
	public kfaUicXMnhcpxgTsBbcmGbCvFksfA.VbZZnYUrePFeaKkwelsmmtksPOUH.KwRYvXOfzOguyBxuTigDjmpTBvBw NStvBckSdDcfOIUgGvEEnLePbZsnA { get; }

	// Methods

	// RVA: 0x1B18AD0 Offset: 0x1B17CD0 VA: 0x181B18AD0
	public bool[] FwMfCTkRBhEjbBwggYIfPAbzIYyO() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public kfaUicXMnhcpxgTsBbcmGbCvFksfA.VbZZnYUrePFeaKkwelsmmtksPOUH.KwRYvXOfzOguyBxuTigDjmpTBvBw LYxDcTWPIBLlVlhKhQayXgFGkNTg() { }

	// RVA: 0x1B18F10 Offset: 0x1B18110 VA: 0x181B18F10
	public void .ctor(KRaUSsFBBHJDPgcjZWrEYoMMPWwn , UpdateLoopSetting ) { }

	// RVA: 0x1B19910 Offset: 0x1B18B10 VA: 0x181B19910
	public void tHLtHpvXbqWGqYWeQPtBXdFJRcfb() { }

	// RVA: 0x1B18BB0 Offset: 0x1B17DB0 VA: 0x181B18BB0
	public void ZiaSbEmYMXYlvvANYzEPXNViWPXH() { }

	// RVA: 0x1B19AD0 Offset: 0x1B18CD0 VA: 0x181B19AD0
	public void tKfaPyhfwglcTeSkGhQfBnoZGazhB() { }

	// RVA: 0x1B18BA0 Offset: 0x1B17DA0 VA: 0x181B18BA0
	public void OiiIAtmafaEqgFYDqrHOnqRKVLBP() { }

	// RVA: 0x1B18C10 Offset: 0x1B17E10 VA: 0x181B18C10
	public void ZmNayyZnLotCnltAfPptPDSFfNbgA(kfaUicXMnhcpxgTsBbcmGbCvFksfA.VbZZnYUrePFeaKkwelsmmtksPOUH ) { }

	// RVA: 0x1B19500 Offset: 0x1B18700 VA: 0x181B19500
	public void gyVlOQUQkhdPokNVCxGKqDgJahbv(int , int , int , float ) { }

	// RVA: 0x1B19240 Offset: 0x1B18440 VA: 0x181B19240
	private void ePNBXBBZxZrIqYSFrmznUOMdQAsC() { }

	// RVA: 0x1B19600 Offset: 0x1B18800 VA: 0x181B19600
	private void imEdsFDfpBAGnPVDysIiDxvenhofb() { }

	// RVA: 0x1B19830 Offset: 0x1B18A30 VA: 0x181B19830
	private void rvMcBlClJpFtzNBkDLOagxRfrOjJA() { }

	// RVA: 0x1B18A60 Offset: 0x1B17C60 VA: 0x181B18A60 Slot: 4
	public void Dispose() { }

	// RVA: 0x152EE40 Offset: 0x152E040 VA: 0x18152EE40 Slot: 1
	protected override void kONViQuzxwhRMrNRqosajBxGDJsI() { }

	// RVA: 0x1B19710 Offset: 0x1B18910 VA: 0x181B19710 Slot: 6
	protected virtual void mVrnEUyZIqoeCODwGZpTwLyPKBgN(bool ) { }

	// RVA: 0x1B18B30 Offset: 0x1B17D30 VA: 0x181B18B30
	private static float ICCKEREgwEBEXNIRvYzHUVaTkTgp(int ) { }
}

// Namespace: 
private class kfaUicXMnhcpxgTsBbcmGbCvFksfA.yvGOqfNGIpGLTFSxwoMAvDaoPdHOA // TypeDefIndex: 12902
{
	// Fields
	private ykZUMGNAQyZSwLzzZpTqJiPtVyMF rUCdnIpnmxeeQwOlfdZkBAjSMNEUA; // 0x10
	private kfaUicXMnhcpxgTsBbcmGbCvFksfA.wcbhCQGjtttpRnGlfNeithYgWEVGA XkpKXDrAGdXKZWEUWGbGCsqjzdkl; // 0x18
	private int zOAZLySNnIdSKJEEOGLoTeolxLhjA; // 0x20
	private int wBDadqDUaNyekTXILauEgoBFTcLhb; // 0x24
	private int swWTQbnoYVPcLrQxyGnzTFijHYaP; // 0x28
	private float qQjmLvGTfPbWVAkhDCBuWBVjARdBA; // 0x2C

	// Methods

	// RVA: 0x1B26920 Offset: 0x1B25B20 VA: 0x181B26920
	public static kfaUicXMnhcpxgTsBbcmGbCvFksfA.yvGOqfNGIpGLTFSxwoMAvDaoPdHOA cHmKORprwOajJLEkBjvYzzCGHJyo(kfaUicXMnhcpxgTsBbcmGbCvFksfA.yvGOqfNGIpGLTFSxwoMAvDaoPdHOA , ykZUMGNAQyZSwLzzZpTqJiPtVyMF ) { }

	// RVA: 0x1B26800 Offset: 0x1B25A00 VA: 0x181B26800
	public void .ctor(ykZUMGNAQyZSwLzzZpTqJiPtVyMF , int , int , int , float ) { }

	// RVA: 0x1B266D0 Offset: 0x1B258D0 VA: 0x181B266D0
	private void .ctor(kfaUicXMnhcpxgTsBbcmGbCvFksfA.yvGOqfNGIpGLTFSxwoMAvDaoPdHOA , ykZUMGNAQyZSwLzzZpTqJiPtVyMF ) { }

	// RVA: 0x1B267B0 Offset: 0x1B259B0 VA: 0x181B267B0
	private void .ctor(int , int , int , float ) { }

	// RVA: 0x1B26B30 Offset: 0x1B25D30 VA: 0x181B26B30
	public void tTXyaaeEzjIaNmrQLfIUdXCtvFXS(double ) { }

	// RVA: 0x1B26A50 Offset: 0x1B25C50 VA: 0x181B26A50
	public void eiwfAiHePqHigTJKZIEcijyklAltb(kfaUicXMnhcpxgTsBbcmGbCvFksfA.yvGOqfNGIpGLTFSxwoMAvDaoPdHOA ) { }

	// RVA: 0x1B26B00 Offset: 0x1B25D00 VA: 0x181B26B00
	private int kWOgmvcCPayBafduhoDwEPbHvjWDB(int ) { }
}

// Namespace: 
private class kfaUicXMnhcpxgTsBbcmGbCvFksfA.wcbhCQGjtttpRnGlfNeithYgWEVGA // TypeDefIndex: 12903
{
	// Fields
	private double HIhdDviFLstXaTObhppYVfMwGwwW; // 0x10
	private ykZUMGNAQyZSwLzzZpTqJiPtVyMF oSjunijGNdBcPtNtEnHIRvrzKwiU; // 0x18
	private ykZUMGNAQyZSwLzzZpTqJiPtVyMF bGllONjhuOoYmFufRLqCJePiyTCr; // 0x20
	private ykZUMGNAQyZSwLzzZpTqJiPtVyMF fRFuaIbGcdvSwKWzijfwLGDdTfiW; // 0x28
	private bool EbAEwwMyYWhIwHFmrAixrcrEicSS; // 0x30
	private double SaZrnieiYjBrNKXOAlowHNhQkpuiA; // 0x38

	// Properties
	public ykZUMGNAQyZSwLzzZpTqJiPtVyMF YiUafnkdgxEwwAwPajIdFyCDYJVac { get; }
	public ykZUMGNAQyZSwLzzZpTqJiPtVyMF mVGUKybQhpppMeROHGjvSZIiUBhw { get; }
	public bool PUlxUHZEIoiZbAblSABsdmsbzCdvb { get; }
	public double zfVTRLhqSgqiYvFazZPsBAqFVLfC { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ykZUMGNAQyZSwLzzZpTqJiPtVyMF DmZvsTSegMdkoKtFPPRRDUgdDEaDB() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ykZUMGNAQyZSwLzzZpTqJiPtVyMF tOwdssBVEdMGIncGtBPNZDYvSzYEA() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool uZWimXUYKUbcRcRXKjqNzMZUcjJt() { }

	// RVA: 0x11FB180 Offset: 0x11FA380 VA: 0x1811FB180
	public double RukkqkspMJfbtOPLdzewqAjFFdOeA() { }

	// RVA: 0x1B258D0 Offset: 0x1B24AD0 VA: 0x181B258D0
	public void .ctor(ykZUMGNAQyZSwLzzZpTqJiPtVyMF ) { }

	// RVA: 0x1B25D30 Offset: 0x1B24F30 VA: 0x181B25D30
	public void tTXyaaeEzjIaNmrQLfIUdXCtvFXS(double ) { }

	// RVA: 0x1B25950 Offset: 0x1B24B50 VA: 0x181B25950
	public void eiwfAiHePqHigTJKZIEcijyklAltb(kfaUicXMnhcpxgTsBbcmGbCvFksfA.wcbhCQGjtttpRnGlfNeithYgWEVGA ) { }

	// RVA: 0x1B259B0 Offset: 0x1B24BB0 VA: 0x181B259B0
	private bool sEuGuvGRdqbPYwubaCemEMeFAtImc() { }
}

// Namespace: 
public enum kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.rtyiWLWiWokYSNRldwQrAaInGpUU // TypeDefIndex: 12904
{
	// Fields
	public int value__; // 0x0
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.rtyiWLWiWokYSNRldwQrAaInGpUU Exact = 0;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.rtyiWLWiWokYSNRldwQrAaInGpUU Approximate = 1;
}

// Namespace: 
public class kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.SpowInQwkJNftGdVEdqRiyWrOOEUA // TypeDefIndex: 12905
{
	// Fields
	public int bjPdYScThyPydDNbkCRNjpFZeFsGb; // 0x10
	public Guid tUdTykDxgBCqGCixYpFbieosflKS; // 0x14
	public Guid rSsgiQBLwBxXOQgdSZXDaFKJpYUHA; // 0x24
	public int nFfBcraymUoVTfAIgQbmWpDqKGIM; // 0x34
	public int SrORvcQcSYELPJTyDirjrtpZoNfKA; // 0x38
	public int LmpluWWlOaMRxzVuDRghRTlVHtlj; // 0x3C
	public int acdSMFTSUSdLCcyHplSQOiRKoZSn; // 0x40

	// Methods

	// RVA: 0x1B188B0 Offset: 0x1B17AB0 VA: 0x181B188B0
	public bool tpevtaPONvCbOPLLHaJdyPWHGzZx(kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA , kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.rtyiWLWiWokYSNRldwQrAaInGpUU ) { }

	// RVA: 0x1B186B0 Offset: 0x1B178B0 VA: 0x181B186B0 Slot: 3
	public override string TvflVDjhhkpoXcrLeFSYrPyVNckm() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.npGQpoIiYvMYNNlgsjxzGgkXpYJi : IEnumerable<kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.SpowInQwkJNftGdVEdqRiyWrOOEUA>, IEnumerator<kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.SpowInQwkJNftGdVEdqRiyWrOOEUA>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 12906
{
	// Fields
	private int PzjprMxCXAatbcFoQLwWchScQdOiB; // 0x10
	private kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.SpowInQwkJNftGdVEdqRiyWrOOEUA NNvfWzvhxcxmZKAypGizxQopABRu; // 0x18
	private int uNgAgWMqxgEhSIWZzDxbBdYwhzxOA; // 0x20
	public kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde DVHetTpHpnzNgMUPnOqwsvgnpDrk; // 0x28
	private kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA dnBCiYlEGEuGKQYWPkdrORDnPzsM; // 0x30
	public kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA DsBHpBLXSPwZZIgjcVUBMDativbH; // 0x38
	private kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.rtyiWLWiWokYSNRldwQrAaInGpUU UnADLXXhcSVnFnLZTjAMcBAWdTox; // 0x40
	public kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.rtyiWLWiWokYSNRldwQrAaInGpUU cIVRqibKAdjnbCnbLVpTtyCaliKuA; // 0x44
	private int CkHqQHNHyPLBeUTtGulMKybSjtiT; // 0x48
	private int pKpwtOQStnbtOWlRlFoQFXjycbxN; // 0x4C

	// Properties
	private kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.SpowInQwkJNftGdVEdqRiyWrOOEUA System.Collections.Generic.IEnumerator<Rewired.Platforms.Windows.DirectInputManager.JoystickRecords.Record>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B1F270 Offset: 0x1B1E470 VA: 0x181B1F270 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.SpowInQwkJNftGdVEdqRiyWrOOEUA System.Collections.Generic.IEnumerator<Rewired.Platforms.Windows.DirectInputManager.JoystickRecords.Record>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1B1F440 Offset: 0x1B1E640 VA: 0x181B1F440 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1B1F370 Offset: 0x1B1E570 VA: 0x181B1F370 Slot: 4
	private IEnumerator<kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.SpowInQwkJNftGdVEdqRiyWrOOEUA> System.Collections.Generic.IEnumerable<Rewired.Platforms.Windows.DirectInputManager.JoystickRecords.Record>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1B1F370 Offset: 0x1B1E570 VA: 0x181B1F370 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
private class kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde // TypeDefIndex: 12907
{
	// Fields
	private List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.SpowInQwkJNftGdVEdqRiyWrOOEUA> SulmidkruIEagtCCOTFXkhNtncaX; // 0x10

	// Methods

	// RVA: 0x1B18510 Offset: 0x1B17710 VA: 0x181B18510
	public void .ctor() { }

	// RVA: 0x1B18010 Offset: 0x1B17210 VA: 0x181B18010
	public void QSlpmrDqCyaQIWNmbdvfspAPDmZD(kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA ) { }

	// RVA: 0x1B17F70 Offset: 0x1B17170 VA: 0x181B17F70
	public IEnumerable<kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.SpowInQwkJNftGdVEdqRiyWrOOEUA> NJnmrqwCIDQmvpFIoQclRHHGHsHf(kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA , kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.rtyiWLWiWokYSNRldwQrAaInGpUU ) { }

	// RVA: 0x1B18580 Offset: 0x1B17780 VA: 0x181B18580
	private void mbBqGDtvDnzRgCyJofIHgtMdhhRB(int , Guid , int ) { }

	// RVA: 0x1B18370 Offset: 0x1B17570 VA: 0x181B18370 Slot: 3
	public override string TvflVDjhhkpoXcrLeFSYrPyVNckm() { }
}

// Namespace: 
private class kfaUicXMnhcpxgTsBbcmGbCvFksfA.nHwFJPxsOXjDpYRNdecyCXgdHrkP // TypeDefIndex: 12908
{
	// Fields
	public kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA gEHOCsxsZmIzPJOhkLyBYoQtjRcx; // 0x10
	public QhuSAobzCkqTzlMZWIYycNYLbWUd HoEEmkengTEjtjoVVsAHXLDjqKDeA; // 0x18

	// Properties
	public bool GKgfNnJbkGcVVcdzdLcfsIEWzycTb { get; }

	// Methods

	// RVA: 0x1B1F120 Offset: 0x1B1E320 VA: 0x181B1F120
	public bool TJoXjzEnrkbvBgocdLmRUiCvDuSFA() { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA , QhuSAobzCkqTzlMZWIYycNYLbWUd ) { }

	// RVA: 0x1B1F140 Offset: 0x1B1E340 VA: 0x181B1F140
	public static List<QhuSAobzCkqTzlMZWIYycNYLbWUd> pLmwMMhHDrVEoHxlSJyWPESoqlGo(List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.nHwFJPxsOXjDpYRNdecyCXgdHrkP> ) { }
}

// Namespace: 
private class kfaUicXMnhcpxgTsBbcmGbCvFksfA.WkDczqShWvJbsWLAIZAiTQAymCej // TypeDefIndex: 12909
{
	// Fields
	private OJnRgZHIezjfzCKBKLkpeGLbZxOP.spCTdghFqtAkHkprSKzgKVsyUjZf LDUPmpglWOETJgujbmZOWDBxCMCIA; // 0x10
	private OJnRgZHIezjfzCKBKLkpeGLbZxOP.BpnZPyzNHkjiSNOqHgveFqDpiNbpA HZhUvfpLGxXbehnnNswncPgitRDT; // 0x28
	private NativeBuffer rVsKLNsooyXrWlHIHUBoFPHXWZAP; // 0x68
	private int kOnfhrfhmJYmvqmABdTgFHhVtTtCA; // 0x70

	// Methods

	// RVA: 0x1B19AF0 Offset: 0x1B18CF0 VA: 0x181B19AF0
	public void .ctor() { }

	// RVA: 0x1B19C40 Offset: 0x1B18E40 VA: 0x181B19C40
	public bool fQiwdTuRUQZkdaneJYyafXvMiXWA() { }

	// RVA: 0x526DC0 Offset: 0x525FC0 VA: 0x180526DC0
	public void FXEpyUzquRDZyweRpSfAaFKRPjut(int ) { }

	// RVA: 0x1B19C70 Offset: 0x1B18E70 VA: 0x181B19C70
	private int naWfaxJBFyAVwLmAmoraJOQgQCepA() { }
}

// Namespace: 
private enum kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV // TypeDefIndex: 12910
{
	// Fields
	public int value__; // 0x0
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV Device = 17;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV Mouse = 18;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV Keyboard = 19;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV Joystick = 20;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV Gamepad = 21;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV Driving = 22;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV Flight = 23;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV FirstPerson = 24;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV ControlDevice = 25;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV ScreenPointer = 26;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV Remote = 27;
	public const kfaUicXMnhcpxgTsBbcmGbCvFksfA.DEkIaVPMrEQemoBZSUfdRwimurRV Supplemental = 28;
}

// Namespace: 
internal class kfaUicXMnhcpxgTsBbcmGbCvFksfA : PlatformInputManager, VoggOxGsBRaReawVMOtzzswXdwzW // TypeDefIndex: 12911
{
	// Fields
	private IntPtr LFvzAvlhWfpByBFvEkwUINlUSZeF; // 0x38
	private RmknDvrpRFsnwNOPRSeRFcQlQSzG AYIIJGvKjYQHADZRvWyHwouVAxqH; // 0x40
	private List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> hHKSGUNDSWHMybqMWNytDRaOPDfL; // 0x48
	private int IcVGIBPpzhMISwKWulhXZdUTApmGA; // 0x50
	private kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde gRJFadYgFKdvCyfqInubAqqODPgEA; // 0x58
	private bool olBFrQUNmxOPyTRFONuXxmyUDCpg; // 0x60
	private XzAaAaHmPXADIEZpgeCGKAYakrcec OytcDzJNULTfDSJflNvcMcvKjkscb; // 0x68
	private UpdateLoopSetting iMjDWkGrvSjYQiCzMnCgcnUciceqA; // 0x70
	private Action<int, ControllerDataUpdater> hvzrnsrfBfDuACXhiYdkuRFlcuVv; // 0x78
	private PlatformInputManager nILBYXWuTFiuiPKLAaGCCrmAZTMi; // 0x80
	private TimerRealTime yUKkneLZWOJTKgfkTsIvlUppkIBA; // 0x88
	private qiothMBxpzcRmDYCBlVfKlBDwMei<bool> cMAEKxqboILYQlnJclTSpNOUGpTBA; // 0x90
	private kfaUicXMnhcpxgTsBbcmGbCvFksfA.WkDczqShWvJbsWLAIZAiTQAymCej ZXvgJesqXNJJMrULYZoOlDCwFeDK; // 0x98
	private int nQCiSTraDPhmQGMbVyRbDQEBSQybA; // 0xA0
	private int rHhjQpYCoDLzMUVWxEoeWRZWFyko; // 0xA4
	private qiothMBxpzcRmDYCBlVfKlBDwMei<List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.nHwFJPxsOXjDpYRNdecyCXgdHrkP>> JquRgWdUnRBoXVaecqiNrPNgBeLeA; // 0xA8
	private readonly object xerClufGPKOQeEXtfygnAfNcmfbsD; // 0xB0
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> CxbDKKUcFsXkVOyjAXODyEMHBOYo; // 0xB8
	private Func<int> BDOenjDqSYOtWQFPDsDfAShQkrwYA; // 0xC0

	// Properties
	public XzAaAaHmPXADIEZpgeCGKAYakrcec vkBiWeJcfpFCCDVgXUhRgrQpVhar { get; set; }
	[CustomObfuscation(rename = False)]
	public override int deviceCount { get; }
	[CustomObfuscation(rename = False)]
	public override PlatformInputManager primaryInputManager { get; }
	[CustomObfuscation(rename = False)]
	public override IInputSource inputSource { get; }
	[CustomObfuscation(rename = False)]
	public override InputSource inputSourceType { get; }

	// Methods

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 18
	public XzAaAaHmPXADIEZpgeCGKAYakrcec QyhMxlbIVcsrSAjHkblUJTGaAfdlA() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80 Slot: 19
	public void TUMalqQWdtvRzCXIsGLqoTlfvymU(XzAaAaHmPXADIEZpgeCGKAYakrcec ) { }

	// RVA: 0x1B0AA50 Offset: 0x1B09C50 VA: 0x181B0AA50
	public void .ctor(UpdateLoopSetting , XzAaAaHmPXADIEZpgeCGKAYakrcec , IntPtr , Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> , Func<int> ) { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410 Slot: 4
	public override int get_deviceCount() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830 Slot: 5
	public override PlatformInputManager get_primaryInputManager() { }

	// RVA: 0x1B0B080 Offset: 0x1B0A280 VA: 0x181B0B080 Slot: 6
	public override IInputSource get_inputSource() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 7
	public override InputSource get_inputSourceType() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B09100 Offset: 0x1B08300 VA: 0x181B09100 Slot: 8
	public override void Initialize() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0A670 Offset: 0x1B09870 VA: 0x181B0A670 Slot: 9
	public override void Update(UpdateLoopType updateLoop) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0A0D0 Offset: 0x1B092D0 VA: 0x181B0A0D0 Slot: 10
	public override void OnDestroy() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 14
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0A510 Offset: 0x1B09710 VA: 0x181B0A510 Slot: 13
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0A470 Offset: 0x1B09670 VA: 0x181B0A470 Slot: 11
	public override void SystemDeviceConnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B0A4C0 Offset: 0x1B096C0 VA: 0x181B0A4C0 Slot: 12
	public override void SystemDeviceDisconnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IUnifiedMouseSource GetUnifiedMouseSource() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 17
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource() { }

	// RVA: 0x1B0BE00 Offset: 0x1B0B000 VA: 0x181B0BE00
	private void vyQzVrabgsgAPAiBqfVWdFxnkMHA() { }

	// RVA: 0x1B09360 Offset: 0x1B08560 VA: 0x181B09360
	private List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.nHwFJPxsOXjDpYRNdecyCXgdHrkP> NDDbUhlOyfuIMnOKNpTIueQHCWTEA() { }

	// RVA: 0x1B09EA0 Offset: 0x1B090A0 VA: 0x181B09EA0
	private void NWuEnUanbtjRnDeUoxFMZgTWoslG() { }

	// RVA: 0x1B0B1F0 Offset: 0x1B0A3F0 VA: 0x181B0B1F0
	private void iKJRDZnqoHfhRcQIqgIhBypftilXB(List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.nHwFJPxsOXjDpYRNdecyCXgdHrkP> ) { }

	// RVA: 0x1B091C0 Offset: 0x1B083C0 VA: 0x181B091C0
	private void JbklannEmKBiPKmRdVrjjamDsQMm(kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA , vrNwUgOabhUpSLZbVkxSBBHXDeFR , out string ) { }

	// RVA: 0x1B08CF0 Offset: 0x1B07EF0 VA: 0x181B08CF0
	private void EDqiRihAgeikiyyizEaieoPwMpfN() { }

	// RVA: 0x1B08C30 Offset: 0x1B07E30 VA: 0x181B08C30
	private IList<QhuSAobzCkqTzlMZWIYycNYLbWUd> ArwCHhNEiCqOypMnpKRjuUhpviym() { }

	// RVA: 0x1B0A310 Offset: 0x1B09510 VA: 0x181B0A310
	private void QnLQXMdKzIDiXEMkYHKIzhYhLnFi() { }

	// RVA: 0x1B0B830 Offset: 0x1B0AA30 VA: 0x181B0B830
	private void lvGFmxhcstGMVoMECCYcTSqWkmYEA(int , int , List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> , List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> ) { }

	// RVA: 0x1B08E00 Offset: 0x1B08000 VA: 0x181B08E00
	private bool EmIbcihNKcfahEdPNkNvyKTqbFSBA(List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> , int ) { }

	// RVA: 0x1B08EB0 Offset: 0x1B080B0 VA: 0x181B08EB0
	private int GXswpAmwYGnaOEscIWbCFcwtPYlc(List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> ) { }

	// RVA: 0x1B0A270 Offset: 0x1B09470 VA: 0x181B0A270
	private bool QQDvYEixELbTassiWcXbcaGsoOnJA(List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> , int ) { }

	// RVA: 0x1B0ACD0 Offset: 0x1B09ED0 VA: 0x181B0ACD0
	private void bUIRusHJNhaUnzuTByaGnEBIdrcP(int , List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> , int , List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> , kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.rtyiWLWiWokYSNRldwQrAaInGpUU ) { }

	// RVA: 0x1B0BB60 Offset: 0x1B0AD60 VA: 0x181B0BB60
	private void vCCQvFbXkGNioBRbuhhCBUHFoapO(int , List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> , kfaUicXMnhcpxgTsBbcmGbCvFksfA.SgUCPqNxjtibbOUuwqhbrfDvpJde.rtyiWLWiWokYSNRldwQrAaInGpUU ) { }

	// RVA: 0x1B0A330 Offset: 0x1B09530 VA: 0x181B0A330
	private void SuFxXSVrRLpLAcQWZVnXFPkjHXJHA() { }

	// RVA: 0x1B0B000 Offset: 0x1B0A200 VA: 0x181B0B000
	private void gXvExfVDWLrlqTEkYzLWARwMbjxs() { }

	// RVA: 0x1B0B7E0 Offset: 0x1B0A9E0 VA: 0x181B0B7E0
	private void jZJbsymJjAqcUfhoDgSYiJFxetEP(List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.nHwFJPxsOXjDpYRNdecyCXgdHrkP> ) { }

	// RVA: 0x1B09ED0 Offset: 0x1B090D0 VA: 0x181B09ED0
	private bool OiQuLVMfoMdtRTKzFCATkEziYcxjA(IList<QhuSAobzCkqTzlMZWIYycNYLbWUd> ) { }

	// RVA: 0x1B0A8F0 Offset: 0x1B09AF0 VA: 0x181B0A8F0
	private bool VXdPTQcGnoEYdcLsMFuDYSqFUyOrA(Guid ) { }

	// RVA: 0x1B0B0F0 Offset: 0x1B0A2F0 VA: 0x181B0B0F0
	private bool iItckfiRNWWZDfxJhoUrQHIbGwdfA(IList<QhuSAobzCkqTzlMZWIYycNYLbWUd> , Guid ) { }

	// RVA: 0x1B0BF50 Offset: 0x1B0B150 VA: 0x181B0BF50
	private void yxRHBgNggDUCxchuqMlGZcjMdPpx(List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> , List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> , bool ) { }

	// RVA: 0x1B08F60 Offset: 0x1B08160 VA: 0x181B08F60
	private void IVzNGUHBSVASmBXPBtbBQztlCatXA(kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA , bool ) { }

	// RVA: 0x1B0AEA0 Offset: 0x1B0A0A0 VA: 0x181B0AEA0
	private bool eMiOGhmXpEcePTelhwcDyLWuZZWu() { }

	// RVA: 0x1B0AF10 Offset: 0x1B0A110 VA: 0x181B0AF10
	private void eeCZbOiJzuFqKbHBkmFpDqNiZSwUb(List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> , List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.cfAzsCXthtQsRToiCylEDDhGCYoiA> ) { }

	[CompilerGenerated]
	// RVA: 0x1B0AFF0 Offset: 0x1B0A1F0 VA: 0x181B0AFF0
	private List<kfaUicXMnhcpxgTsBbcmGbCvFksfA.nHwFJPxsOXjDpYRNdecyCXgdHrkP> fXdclabLtPrFpMzrtbgfywQVoluBA() { }
}

// Namespace: 
internal interface VoggOxGsBRaReawVMOtzzswXdwzW // TypeDefIndex: 12912
{
	// Properties
	public abstract XzAaAaHmPXADIEZpgeCGKAYakrcec vkBiWeJcfpFCCDVgXUhRgrQpVhar { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XzAaAaHmPXADIEZpgeCGKAYakrcec QyhMxlbIVcsrSAjHkblUJTGaAfdlA();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void TUMalqQWdtvRzCXIsGLqoTlfvymU(XzAaAaHmPXADIEZpgeCGKAYakrcec );
}

// Namespace: 
private class uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx : IInputManagerJoystick, IInputManagerJoystickPublic // TypeDefIndex: 12913
{
	// Fields
	private int elLFJteTiCVpSogeBWPkFnTrudWE; // 0x10
	private int fVuPgJSlpPIfSeOgsNtYBMDtpgunA; // 0x14
	public Guid ksQXSyCMArgpTQjQVaPCEGSVXoOp; // 0x18
	public string kJOmFeUAgkDdNXyTSilWpUlXspNF; // 0x28
	private readonly HQXUOjGBtcCBEbCXgDocfmauonxdA gEHOCsxsZmIzPJOhkLyBYoQtjRcx; // 0x30
	private readonly DeviceType wESkGlEdqXcSzjDjJdrtskAoZQnJA; // 0x38
	public string DioGwKdMhhhHNmPiSEvXwIPEHgeH; // 0x40
	public string lufcugDzGrkmtafbpDqMLPXSlCRNA; // 0x48
	public string kwjAQknTWoswtqPxMhmqSkVKGTuL; // 0x50
	public int OiMBHSbtNIhmneXPdLUborVNtHHK; // 0x58
	public int oxmYhrFxNIRcDzWJfWJQUaoxqhhJ; // 0x5C
	public Guid JyzEdkAbNbxABgJyWcyFlkkleEdEb; // 0x60
	public Guid XfzUpElzwnbTwUFrhLwQNARHvqlW; // 0x70
	public Guid rSsgiQBLwBxXOQgdSZXDaFKJpYUHA; // 0x80
	public int HtJjzJNFnoRSOEdOsBCWuXjdSOUI; // 0x90
	public int FUtJHSvyySJCEQpkrduZIvvRPOOA; // 0x94
	public int AgoGitaCJZRYBFvgZZssrUYswHJAA; // 0x98
	public int SrORvcQcSYELPJTyDirjrtpZoNfKA; // 0x9C
	public int LmpluWWlOaMRxzVuDRghRTlVHtlj; // 0xA0
	public int acdSMFTSUSdLCcyHplSQOiRKoZSn; // 0xA4
	public bool SgNUcmLqANIPiqsBVJjlmXEGCdiH; // 0xA8
	public bool igPGuYGgxsWGxSMkCxYbJcSJgnzO; // 0xA9
	public bool XJrptZuDMzJgsxBRxAwoplGIlEST; // 0xAA
	public int CytlqlXAkwffzJefTcoaJwirMQhD; // 0xAC
	private float[] wsHpigDPzQcVMoNRfBDQAlRyqROgb; // 0xB0
	private float[] SMjvFtmVJPKHDGGnPQKpepfMESLb; // 0xB8
	private bool[] TXaIKdbNzQLxBLaAwYXoGhjcfRum; // 0xC0
	private HardwareJoystickMap_InputManager cNQOBilDgUZmDotqcVREDrrooBLe; // 0xC8
	private NiLErEUlFlYkVutuiWimtGzgYFoF ieHYzwouSjuclTUSmIPiyoUPpfIq; // 0xD0
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> CxbDKKUcFsXkVOyjAXODyEMHBOYo; // 0xD8
	private bool HwWSDNGAiFPLpbJYXqmSjaEDhwTm; // 0xE0
	private bool eIQDQfZkSYmdtUBeiFMzQFUZeUMU; // 0xE1
	[CompilerGenerated]
	private Controller.Extension fNsOWDGGBEJzQdSEJbTBbjYjYuNo; // 0xE8
	private bool KbxbxdFRwCxlESZSXPtZDThmvMJq; // 0xF0

	// Properties
	public bool tnGCWIXVmzVLbMtzznEbnteiRkXK { get; }
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
	public Controller.Extension extension { get; set; }
	[CustomObfuscation(rename = False)]
	public Guid instanceGuid { get; }
	[CustomObfuscation(rename = False)]
	public Guid persistentGuid { get; }
	public bool GKgfNnJbkGcVVcdzdLcfsIEWzycTb { get; }

	// Methods

	// RVA: 0x1B21930 Offset: 0x1B20B30 VA: 0x181B21930
	public bool ctSGPhLyPMiqpyqPQZMnVucYOOvv() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 8
	public int get_rewiredId() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_rewiredId(int value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 9
	public int get_inputManagerId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_inputManagerId(int value) { }

	// RVA: 0x1B21D10 Offset: 0x1B20F10 VA: 0x181B21D10 Slot: 10
	public string get_name() { }

	// RVA: 0x1B21D90 Offset: 0x1B20F90 VA: 0x181B21D90 Slot: 11
	public Nullable<long> get_systemId() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	public int get_unityId() { }

	[CompilerGenerated]
	// RVA: 0x796090 Offset: 0x795290 VA: 0x180796090 Slot: 13
	public Controller.Extension get_extension() { }

	[CompilerGenerated]
	// RVA: 0x7960E0 Offset: 0x7952E0 VA: 0x1807960E0
	public void set_extension(Controller.Extension value) { }

	// RVA: 0x12DC690 Offset: 0x12DB890 VA: 0x1812DC690 Slot: 14
	public Guid get_instanceGuid() { }

	// RVA: 0x12DC690 Offset: 0x12DB890 VA: 0x1812DC690 Slot: 15
	public Guid get_persistentGuid() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B20100 Offset: 0x1B1F300 VA: 0x181B20100 Slot: 16
	public void SetVibration(float amount, int motorIndex) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B20100 Offset: 0x1B1F300 VA: 0x181B20100 Slot: 17
	public void StopVibration() { }

	// RVA: 0x1B20150 Offset: 0x1B1F350 VA: 0x181B20150
	public bool TJoXjzEnrkbvBgocdLmRUiCvDuSFA() { }

	// RVA: 0x1B21380 Offset: 0x1B20580 VA: 0x181B21380
	public void .ctor(HQXUOjGBtcCBEbCXgDocfmauonxdA , DeviceType , Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> ) { }

	// RVA: 0x1B201B0 Offset: 0x1B1F3B0 VA: 0x181B201B0
	public void TOfaVcdcUxBZvMNMLarYOrIbspsl() { }

	// RVA: 0x1B21110 Offset: 0x1B20310 VA: 0x181B21110
	public void ZmNayyZnLotCnltAfPptPDSFfNbgA(uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B209D0 Offset: 0x1B1FBD0 VA: 0x181B209D0 Slot: 4
	public void Update() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B1F710 Offset: 0x1B1E910 VA: 0x181B1F710 Slot: 5
	public void FillData(ControllerDataUpdater dataUpdater) { }

	// RVA: 0x1B227C0 Offset: 0x1B219C0 VA: 0x181B227C0
	public int tpevtaPONvCbOPLLHaJdyPWHGzZx(uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx ) { }

	// RVA: 0x1B21CB0 Offset: 0x1B20EB0 VA: 0x181B21CB0
	private BridgedControllerHWInfo eoNUQUHMlXQrwOfObYLDIXlpHRmJ() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B207D0 Offset: 0x1B1F9D0 VA: 0x181B207D0 Slot: 6
	public BridgedController ToBridgedController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B20970 Offset: 0x1B1FB70 VA: 0x181B20970 Slot: 7
	public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs() { }

	// RVA: 0x1B214D0 Offset: 0x1B206D0 VA: 0x181B214D0
	private void bqZsUfrwXrMerppiHuLJWqqIVlrD(bool[] , int[] ) { }

	// RVA: 0x1B20CB0 Offset: 0x1B1FEB0 VA: 0x181B20CB0
	private void WIpskiOWInYZQmpjrkbqBXWXXrsg(bool[] , int[] ) { }

	// RVA: 0x1B213E0 Offset: 0x1B205E0 VA: 0x181B213E0
	private void arXVdPKEuSyfzlgBBBIVpVZUxias(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base , int , bool[] , int[] ) { }

	// RVA: 0x1B22240 Offset: 0x1B21440 VA: 0x181B22240
	private void mLIlzcHptbCUMKbxcpuvztErfMuM(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base , int , bool[] , int[] ) { }

	// RVA: 0x1B22AB0 Offset: 0x1B21CB0 VA: 0x181B22AB0
	private float vnCvKvBouGzkuuAXKItHRJiObMoL(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base , bool[] , int[] ) { }

	// RVA: 0x1B22970 Offset: 0x1B21B70 VA: 0x181B22970
	private float vnCvKvBouGzkuuAXKItHRJiObMoL(RawInputAxis , int ) { }

	// RVA: 0x1B1F910 Offset: 0x1B1EB10 VA: 0x181B1F910
	private float JGDQHEtIojOrseFMsraOcCyeFxrcA(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base , bool[] , int[] ) { }

	// RVA: 0x1AF8BC0 Offset: 0x1AF7DC0 VA: 0x181AF8BC0
	private float ICCKEREgwEBEXNIRvYzHUVaTkTgp(int ) { }

	// RVA: 0x1B206D0 Offset: 0x1B1F8D0 VA: 0x181B206D0
	private float TjUSjWnSzlMKBMGNZaxRAiNROxaZ(int , int , HatType ) { }

	// RVA: 0x1B003A0 Offset: 0x1AFF5A0 VA: 0x181B003A0
	private float CyECkGYxbhqjARYFYRKcxRWKrrYo(int , AxisDirection ) { }

	// RVA: 0x1B1FE60 Offset: 0x1B1F060 VA: 0x181B1FE60
	private bool MyUsDxtkHqpkPPXHaljVideJpCIc(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData , bool[] , out bool ) { }

	// RVA: 0x1B21E00 Offset: 0x1B21000 VA: 0x181B21E00
	private bool jZRGmOMQDCrtcxJbDdhuAINHpuxLA(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData , out float ) { }

	// RVA: 0x1B20790 Offset: 0x1B1F990 VA: 0x181B20790
	private ControlDeviceType TmpqXqzgxwlTkwbrCcYpfZXfdYdfA(DeviceType ) { }

	// RVA: 0x1B226D0 Offset: 0x1B218D0 VA: 0x181B226D0
	private void qrerdopMRhpXZWNZTgPdGroJDMyd(HardwareJoystickMap.Platform_InternalDriver_Base.Axis , int , bool[] , int[] ) { }

	// RVA: 0x1B20BC0 Offset: 0x1B1FDC0 VA: 0x181B20BC0
	private void VHABiChzMnqRnugjqhCmNvdSDsOT(HardwareJoystickMap.Platform_InternalDriver_Base.Button , int , bool[] , int[] ) { }

	// RVA: 0x1B1FEC0 Offset: 0x1B1F0C0 VA: 0x181B1FEC0
	private float NgkggvenXDbdxnLqTOyxAToGnUNN(HardwareJoystickMap.Platform_InternalDriver_Base.Axis , bool[] , int[] ) { }

	// RVA: 0x1B20030 Offset: 0x1B1F230 VA: 0x181B20030
	private float NgkggvenXDbdxnLqTOyxAToGnUNN(int ) { }

	// RVA: 0x1B21A00 Offset: 0x1B20C00 VA: 0x181B21A00
	private float dCDUvBxqxVzTnehJVhBiFdskACXmA(HardwareJoystickMap.Platform_InternalDriver_Base.Button , bool[] , int[] ) { }

	// RVA: 0x1B21F60 Offset: 0x1B21160 VA: 0x181B21F60
	private void kEIKNRuflotJMGPZCZrjbNEpOWZA() { }

	// RVA: 0x1B223C0 Offset: 0x1B215C0 VA: 0x181B223C0
	private string qDBpeKNVqqirGADiDFwTGFAdVzRLA() { }

	// RVA: 0x1B1F590 Offset: 0x1B1E790 VA: 0x181B1F590
	private void FUpEnRfZKusAxqfkFZYzdRVRUyzkA(BridgedControllerHWInfo ) { }

	// RVA: 0x1B1F480 Offset: 0x1B1E680 VA: 0x181B1F480
	private void FUpEnRfZKusAxqfkFZYzdRVRUyzkA(BridgedController ) { }

	// RVA: 0x1B22040 Offset: 0x1B21240 VA: 0x181B22040
	private UnknownControllerHat[] kODywkpNeirqKIWAOhDSThtXSQZd() { }

	// RVA: 0x1B22350 Offset: 0x1B21550 VA: 0x181B22350
	public void mVrnEUyZIqoeCODwGZpTwLyPKBgN() { }

	// RVA: 0x1B04F50 Offset: 0x1B04150 VA: 0x181B04F50 Slot: 1
	protected override void kONViQuzxwhRMrNRqosajBxGDJsI() { }

	// RVA: 0x1B22330 Offset: 0x1B21530 VA: 0x181B22330 Slot: 19
	protected virtual void mVrnEUyZIqoeCODwGZpTwLyPKBgN(bool ) { }

	// RVA: 0x1A67B20 Offset: 0x1A66D20 VA: 0x181A67B20
	public static int rfLHjamfrvjAnxvnjhnGjJsToSdk(uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx , uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx ) { }

	// RVA: 0x1B22920 Offset: 0x1B21B20 VA: 0x181B22920
	public static int vHbfdITdtZyWDoGZidCsFpxOBeOiA(uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx , uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx ) { }
}

// Namespace: 
public enum uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.oHXYxqmGQZUAUHdCYicruwCgZDFb // TypeDefIndex: 12914
{
	// Fields
	public int value__; // 0x0
	public const uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.oHXYxqmGQZUAUHdCYicruwCgZDFb Exact = 0;
	public const uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.oHXYxqmGQZUAUHdCYicruwCgZDFb Approximate = 1;
}

// Namespace: 
public class uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.IsUbCvZFGrdImzCwdNKjzWFgYhqe // TypeDefIndex: 12915
{
	// Fields
	public int bjPdYScThyPydDNbkCRNjpFZeFsGb; // 0x10
	public Guid tUdTykDxgBCqGCixYpFbieosflKS; // 0x14
	public Guid rSsgiQBLwBxXOQgdSZXDaFKJpYUHA; // 0x24
	public int nFfBcraymUoVTfAIgQbmWpDqKGIM; // 0x34
	public int SrORvcQcSYELPJTyDirjrtpZoNfKA; // 0x38
	public int LmpluWWlOaMRxzVuDRghRTlVHtlj; // 0x3C
	public int acdSMFTSUSdLCcyHplSQOiRKoZSn; // 0x40
	public int AgoGitaCJZRYBFvgZZssrUYswHJAA; // 0x44
	public int FUtJHSvyySJCEQpkrduZIvvRPOOA; // 0x48
	public bool tnGCWIXVmzVLbMtzznEbnteiRkXK; // 0x4C

	// Methods

	// RVA: 0x1B13940 Offset: 0x1B12B40 VA: 0x181B13940
	public bool tpevtaPONvCbOPLLHaJdyPWHGzZx(uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx , uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.oHXYxqmGQZUAUHdCYicruwCgZDFb ) { }

	// RVA: 0x1B13680 Offset: 0x1B12880 VA: 0x181B13680 Slot: 3
	public override string TvflVDjhhkpoXcrLeFSYrPyVNckm() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.hFhmViwSaXsaApiXvTZlyxkmccbj : IEnumerable<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.IsUbCvZFGrdImzCwdNKjzWFgYhqe>, IDisposable, IEnumerator<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.IsUbCvZFGrdImzCwdNKjzWFgYhqe>, IEnumerable, IEnumerator // TypeDefIndex: 12916
{
	// Fields
	private int PzjprMxCXAatbcFoQLwWchScQdOiB; // 0x10
	private uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.IsUbCvZFGrdImzCwdNKjzWFgYhqe NNvfWzvhxcxmZKAypGizxQopABRu; // 0x18
	private int uNgAgWMqxgEhSIWZzDxbBdYwhzxOA; // 0x20
	public uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup DVHetTpHpnzNgMUPnOqwsvgnpDrk; // 0x28
	private uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx dnBCiYlEGEuGKQYWPkdrORDnPzsM; // 0x30
	public uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx DsBHpBLXSPwZZIgjcVUBMDativbH; // 0x38
	private uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.oHXYxqmGQZUAUHdCYicruwCgZDFb UnADLXXhcSVnFnLZTjAMcBAWdTox; // 0x40
	public uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.oHXYxqmGQZUAUHdCYicruwCgZDFb cIVRqibKAdjnbCnbLVpTtyCaliKuA; // 0x44
	private int CkHqQHNHyPLBeUTtGulMKybSjtiT; // 0x48
	private int pKpwtOQStnbtOWlRlFoQFXjycbxN; // 0x4C

	// Properties
	private uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.IsUbCvZFGrdImzCwdNKjzWFgYhqe System.Collections.Generic.IEnumerator<Rewired.Platforms.Windows.RawInputManager.JoystickRecords.Record>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B1C150 Offset: 0x1B1B350 VA: 0x181B1C150 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.IsUbCvZFGrdImzCwdNKjzWFgYhqe System.Collections.Generic.IEnumerator<Rewired.Platforms.Windows.RawInputManager.JoystickRecords.Record>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1B1C320 Offset: 0x1B1B520 VA: 0x181B1C320 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1B1C250 Offset: 0x1B1B450 VA: 0x181B1C250 Slot: 4
	private IEnumerator<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.IsUbCvZFGrdImzCwdNKjzWFgYhqe> System.Collections.Generic.IEnumerable<Rewired.Platforms.Windows.RawInputManager.JoystickRecords.Record>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1B1C250 Offset: 0x1B1B450 VA: 0x181B1C250 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
private class uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup // TypeDefIndex: 12917
{
	// Fields
	private List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.IsUbCvZFGrdImzCwdNKjzWFgYhqe> SulmidkruIEagtCCOTFXkhNtncaX; // 0x10

	// Methods

	// RVA: 0x1B17D70 Offset: 0x1B16F70 VA: 0x181B17D70
	public void .ctor() { }

	// RVA: 0x1B17770 Offset: 0x1B16970 VA: 0x181B17770
	public void QSlpmrDqCyaQIWNmbdvfspAPDmZD(uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx ) { }

	// RVA: 0x1B176D0 Offset: 0x1B168D0 VA: 0x181B176D0
	public IEnumerable<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.IsUbCvZFGrdImzCwdNKjzWFgYhqe> NJnmrqwCIDQmvpFIoQclRHHGHsHf(uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx , uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.oHXYxqmGQZUAUHdCYicruwCgZDFb ) { }

	// RVA: 0x1B17DE0 Offset: 0x1B16FE0 VA: 0x181B17DE0
	private void mbBqGDtvDnzRgCyJofIHgtMdhhRB(int , Guid , int ) { }

	// RVA: 0x1B17BD0 Offset: 0x1B16DD0 VA: 0x181B17BD0 Slot: 3
	public override string TvflVDjhhkpoXcrLeFSYrPyVNckm() { }
}

// Namespace: 
internal class uLLiqTFrtaGNXKwJrafiOKIcEGkgA : PlatformInputManager, VoggOxGsBRaReawVMOtzzswXdwzW // TypeDefIndex: 12918
{
	// Fields
	private IMIKpXqjqFXciFiwraohRJYwLECW DAuGmyGWsgRcIsMQIUzTAGXWhjyZ; // 0x38
	private List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx> tCXEFXzLlwBvVoFClwTnodulSSsN; // 0x40
	private int kOnfhrfhmJYmvqmABdTgFHhVtTtCA; // 0x48
	private uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup DlievOCucnmojhhdcXyKVQTdrTJdB; // 0x50
	private bool WfGPezKgieGVinxNbgCIHAVQNDagb; // 0x58
	private TimerRealTime MsNxRHixjmrWYOZByABtxKwCVPVT; // 0x60
	private qiothMBxpzcRmDYCBlVfKlBDwMei<bool> zvtajLKOGNxXwNlsFNMRETuSIxcz; // 0x68
	private qiothMBxpzcRmDYCBlVfKlBDwMei<bool> RknXVnSMbuiCEAaGBsLQnoyXPAFP; // 0x70
	private int LXtbdeBCLGwptsGlzwYMPKEVsYlab; // 0x78
	private int ZZFxHfhtKheIKPdWSBlrKeyCzNuT; // 0x7C
	private ConfigVars IBIMlvpPouiATbIdVdRSprliffReb; // 0x80
	private XzAaAaHmPXADIEZpgeCGKAYakrcec OytcDzJNULTfDSJflNvcMcvKjkscb; // 0x88
	private Action<int, ControllerDataUpdater> fHMGMxQkISQsfppdqvuoyBFLgHVhA; // 0x90
	private PlatformInputManager nILBYXWuTFiuiPKLAaGCCrmAZTMi; // 0x98
	private readonly xfWxcsgyOHlRVBWPlFBnzTNfOWyh xsYRpoVadOKYEVJytTXQGCTEDaDz; // 0xA0
	private readonly dkyczeXVOVhirbIvuJIrMMbpwQgb OQrDnfzrIhMtmCxpLMuwKnHDgXqCA; // 0xA8
	private readonly bool MDYoNCsmbkCeMChkjDkSIWbDmvqGb; // 0xB0
	private readonly bool NewbBEVIvTprPGNYhpAMXTmBQyPe; // 0xB1
	private readonly bool XYhEuvbFBCBuEqEpHHPVETlxvRTP; // 0xB2
	private readonly Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> PVjsWtiCHHzdlFdTJDxGWSjPufLE; // 0xB8
	private readonly Func<int> QealEOQnSUaSsIDENbjPVwwhDbFM; // 0xC0

	// Properties
	public XzAaAaHmPXADIEZpgeCGKAYakrcec vkBiWeJcfpFCCDVgXUhRgrQpVhar { get; set; }
	[CustomObfuscation(rename = False)]
	public override int deviceCount { get; }
	[CustomObfuscation(rename = False)]
	public override PlatformInputManager primaryInputManager { get; }
	[CustomObfuscation(rename = False)]
	public override IInputSource inputSource { get; }
	[CustomObfuscation(rename = False)]
	public override InputSource inputSourceType { get; }

	// Methods

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 18
	public XzAaAaHmPXADIEZpgeCGKAYakrcec QyhMxlbIVcsrSAjHkblUJTGaAfdlA() { }

	// RVA: 0x1B238F0 Offset: 0x1B22AF0 VA: 0x181B238F0 Slot: 19
	public void TUMalqQWdtvRzCXIsGLqoTlfvymU(XzAaAaHmPXADIEZpgeCGKAYakrcec ) { }

	// RVA: 0x1B23FC0 Offset: 0x1B231C0 VA: 0x181B23FC0
	public void .ctor(ConfigVars , XzAaAaHmPXADIEZpgeCGKAYakrcec , Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> , Func<int> , bool , bool , bool , bool ) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0 Slot: 4
	public override int get_deviceCount() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50 Slot: 5
	public override PlatformInputManager get_primaryInputManager() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 6
	public override IInputSource get_inputSource() { }

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 7
	public override InputSource get_inputSourceType() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B23240 Offset: 0x1B22440 VA: 0x181B23240 Slot: 8
	public override void Initialize() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B23AE0 Offset: 0x1B22CE0 VA: 0x181B23AE0 Slot: 9
	public override void Update(UpdateLoopType updateLoop) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B235B0 Offset: 0x1B227B0 VA: 0x181B235B0 Slot: 10
	public override void OnDestroy() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560 Slot: 14
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B239C0 Offset: 0x1B22BC0 VA: 0x181B239C0 Slot: 13
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B23790 Offset: 0x1B22990 VA: 0x181B23790 Slot: 11
	public override void SystemDeviceConnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B23840 Offset: 0x1B22A40 VA: 0x181B23840 Slot: 12
	public override void SystemDeviceDisconnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0 Slot: 16
	public override IUnifiedMouseSource GetUnifiedMouseSource() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0 Slot: 17
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void suoVlzbtNQwtessvqwtEYHraBnvJA(DRzFGNwLfBtrVDIrmmUwQRiiTbRh , vbQWyQJPWwGDLbAFQLywhGZZMVUT ) { }

	// RVA: 0x1B25660 Offset: 0x1B24860 VA: 0x181B25660
	private void vyQzVrabgsgAPAiBqfVWdFxnkMHA() { }

	// RVA: 0x1B24DB0 Offset: 0x1B23FB0 VA: 0x181B24DB0
	private void vrXcjsobGRPOQkcqoJyxghnKxiDc() { }

	// RVA: 0x1B24E10 Offset: 0x1B24010 VA: 0x181B24E10
	private void vrXcjsobGRPOQkcqoJyxghnKxiDc(IList<HQXUOjGBtcCBEbCXgDocfmauonxdA> ) { }

	// RVA: 0x1B22E10 Offset: 0x1B22010 VA: 0x181B22E10
	private void EDqiRihAgeikiyyizEaieoPwMpfN() { }

	// RVA: 0x1B24560 Offset: 0x1B23760 VA: 0x181B24560
	private IList<HQXUOjGBtcCBEbCXgDocfmauonxdA> gYTtiwdIOcerTYXymZgtbTcRnEGG() { }

	// RVA: 0x1B247E0 Offset: 0x1B239E0 VA: 0x181B247E0
	private void lvGFmxhcstGMVoMECCYcTSqWkmYEA(int , int , List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx> , List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx> ) { }

	// RVA: 0x1B22EA0 Offset: 0x1B220A0 VA: 0x181B22EA0
	private bool EmIbcihNKcfahEdPNkNvyKTqbFSBA(List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx> , int ) { }

	// RVA: 0x1B22F50 Offset: 0x1B22150 VA: 0x181B22F50
	private int GXswpAmwYGnaOEscIWbCFcwtPYlc(List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx> ) { }

	// RVA: 0x1B236F0 Offset: 0x1B228F0 VA: 0x181B236F0
	private bool QQDvYEixELbTassiWcXbcaGsoOnJA(List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx> , int ) { }

	// RVA: 0x1B24290 Offset: 0x1B23490 VA: 0x181B24290
	private void bUIRusHJNhaUnzuTByaGnEBIdrcP(int , List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx> , int , List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx> , uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.oHXYxqmGQZUAUHdCYicruwCgZDFb ) { }

	// RVA: 0x1B24B10 Offset: 0x1B23D10 VA: 0x181B24B10
	private void vCCQvFbXkGNioBRbuhhCBUHFoapO(int , List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx> , uLLiqTFrtaGNXKwJrafiOKIcEGkgA.NSSVwOnMyBZxJNgtrwcEpbRiIJup.oHXYxqmGQZUAUHdCYicruwCgZDFb ) { }

	// RVA: 0x1B23E20 Offset: 0x1B23020 VA: 0x181B23E20
	private void WdDWMCEaqBXPUxCosbPcxeMbiTEm() { }

	// RVA: 0x1B23930 Offset: 0x1B22B30 VA: 0x181B23930
	private void UGIjchjzVqDRBcsytRDtkoblGkLn() { }

	// RVA: 0x1B24750 Offset: 0x1B23950 VA: 0x181B24750
	private void jZJbsymJjAqcUfhoDgSYiJFxetEP() { }

	// RVA: 0x1B23380 Offset: 0x1B22580 VA: 0x181B23380
	private bool OiQuLVMfoMdtRTKzFCATkEziYcxjA(IList<HQXUOjGBtcCBEbCXgDocfmauonxdA> ) { }

	// RVA: 0x1B23D30 Offset: 0x1B22F30 VA: 0x181B23D30
	private bool VXdPTQcGnoEYdcLsMFuDYSqFUyOrA(Guid ) { }

	// RVA: 0x1B245B0 Offset: 0x1B237B0 VA: 0x181B245B0
	private bool iItckfiRNWWZDfxJhoUrQHIbGwdfA(IList<HQXUOjGBtcCBEbCXgDocfmauonxdA> , Guid ) { }

	// RVA: 0x1B25780 Offset: 0x1B24980 VA: 0x181B25780
	private void yxRHBgNggDUCxchuqMlGZcjMdPpx(List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx> , List<uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx> , bool ) { }

	// RVA: 0x1B23000 Offset: 0x1B22200 VA: 0x181B23000
	private void IVzNGUHBSVASmBXPBtbBQztlCatXA(uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx , bool ) { }

	// RVA: 0x1B24460 Offset: 0x1B23660 VA: 0x181B24460
	private bool eMiOGhmXpEcePTelhwcDyLWuZZWu() { }

	[CompilerGenerated]
	// RVA: 0x1B246C0 Offset: 0x1B238C0 VA: 0x181B246C0
	private void jXTSomFmFNJHxQAgymksrlynxenm(uLLiqTFrtaGNXKwJrafiOKIcEGkgA.szkyollSPEkdFqXuVKiOZunVJHqx ) { }
}

// Namespace: 
private struct gHZDHgevXTVHbfgrciETWtQJsNDZ.eEldpOvTNyadTebpPboJqKFUfeZO.spjNpoQDQewQPNgjHmzXXLFcWofT // TypeDefIndex: 12919
{
	// Fields
	internal int nJpkYBrSGLgLgdkhDYrhrYFcPjHu; // 0x0
	internal int RIjmfyQpsSUVtCFNXKIZprkxsOYI; // 0x4
	internal int MTlPzekIngOwwQLqsMYcKJZqWtzf; // 0x8
	internal Guid xVxwxtqVYHMLvDXKDEjAOTzFBocy; // 0xC
	internal short OPdSqjOmnCHzIITineycGMlNKVFg; // 0x1C
}

// Namespace: 
private static class gHZDHgevXTVHbfgrciETWtQJsNDZ.eEldpOvTNyadTebpPboJqKFUfeZO // TypeDefIndex: 12920
{
	// Fields
	private static readonly Guid sLpfRQfozDvqdOuNONBJdaeocHNJA; // 0x0
	private static IntPtr VllFSAiiBLmGBDYyArSYknXpaahNB; // 0x10
	private static bool hNWzkZTsigjbSaiHWMjUNfZDUlqS; // 0x18

	// Methods

	// RVA: 0x1B19CE0 Offset: 0x1B18EE0 VA: 0x181B19CE0
	public static void JXNAqfAFBMHEgRMJuNIVfSYTNuIK(IntPtr ) { }

	// RVA: 0x1B19FB0 Offset: 0x1B191B0 VA: 0x181B19FB0
	public static void pvvPFTnjYBPWMJqyqIcmKmJiiCRE() { }

	// RVA: 0x1B19EA0 Offset: 0x1B190A0 VA: 0x181B19EA0
	private static extern IntPtr VQPhomDYDgSrJQeJMOVjeFfpYVGx(IntPtr , IntPtr , int ) { }

	// RVA: 0x1B1A0C0 Offset: 0x1B192C0 VA: 0x181B1A0C0
	private static extern bool vRZqkBptbRddYLFzuTKeJvrABbBs(IntPtr ) { }

	// RVA: 0x1B19F40 Offset: 0x1B19140 VA: 0x181B19F40
	private static void .cctor() { }
}

// Namespace: 
internal class gHZDHgevXTVHbfgrciETWtQJsNDZ : IDisposable, dXpCtWmDcyGjlEXtgAFIONdtfjwGb // TypeDefIndex: 12921
{
	// Fields
	private Action<EventArgs> DauLSRygUizpWDDpIgFUQxJEFUGE; // 0x10
	private Action<EventArgs> hCoGAqnrRcwljMBVAbJJowktchMAA; // 0x18
	private Action<EventArgs> pvNAzUaJhpxhTeBaJOTrpsHdVHHb; // 0x20
	private Action<DRzFGNwLfBtrVDIrmmUwQRiiTbRh, vbQWyQJPWwGDLbAFQLywhGZZMVUT> SwCpIwCdbkmOHsawFsVBhJLilywk; // 0x28
	private IntPtr tytFrjeevCGcnQdCKELJciyMyZTOA; // 0x30
	private CsZpJUGeSLDAURbojOkPliIJVcWo cKgVocdSOxfgOTUuCgGSiRmbJNtvA; // 0x38
	private readonly bool svQFfQMFoxkdgvHvTcOCPEKtiym; // 0x40
	private static hlVzimnqOojRtdGwoockICfaDvTg bsBpWBqnvNNFbfgTBWxNaZYFcxKA; // 0x0
	private CsZpJUGeSLDAURbojOkPliIJVcWo pOuddZhIFIBhwzbYipkvoPyNUiThA; // 0x48
	private bool KbxbxdFRwCxlESZSXPtZDThmvMJq; // 0x50

	// Properties
	public IntPtr LFvzAvlhWfpByBFvEkwUINlUSZeF { get; }

	// Methods

	// RVA: 0x1B1B510 Offset: 0x1B1A710 VA: 0x181B1B510 Slot: 5
	public void NEkwheUAeIYYzmExDEvrzmohwVLN(Action<EventArgs> ) { }

	// RVA: 0x1B1B870 Offset: 0x1B1AA70 VA: 0x181B1B870 Slot: 6
	public void dqiEyLFtrxaMAViXyIYnJfYBEHVNA(Action<EventArgs> ) { }

	// RVA: 0x1B1BE00 Offset: 0x1B1B000 VA: 0x181B1BE00 Slot: 7
	public void urHtoHYIOgvvIyfywXzZFcEZdpSf(Action<EventArgs> ) { }

	// RVA: 0x1B1BD50 Offset: 0x1B1AF50 VA: 0x181B1BD50 Slot: 8
	public void rUGXrjxwTYkImnhynXoiZjzVOmwO(Action<EventArgs> ) { }

	// RVA: 0x1B1B6F0 Offset: 0x1B1A8F0 VA: 0x181B1B6F0
	public void QoAuiCPQSzerBoyEseQZxfEGKlDW(Action<DRzFGNwLfBtrVDIrmmUwQRiiTbRh, vbQWyQJPWwGDLbAFQLywhGZZMVUT> ) { }

	// RVA: 0x1B1AFD0 Offset: 0x1B1A1D0 VA: 0x181B1AFD0
	public void BNlgHuFZHgRbTloPuXtGdsLSiARyA(Action<DRzFGNwLfBtrVDIrmmUwQRiiTbRh, vbQWyQJPWwGDLbAFQLywhGZZMVUT> ) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public IntPtr GoMgDzpLXKdyRepYnUhdNmLPYvel() { }

	// RVA: 0x1B1B7A0 Offset: 0x1B1A9A0 VA: 0x181B1B7A0
	public void .ctor() { }

	// RVA: 0x1B1B2B0 Offset: 0x1B1A4B0 VA: 0x181B1B2B0 Slot: 9
	public void FZnQmtLqqYZHwOXAIdzoAAwjoDcn() { }

	// RVA: 0x1B1BEB0 Offset: 0x1B1B0B0 VA: 0x181B1BEB0
	private void vojemuchleMDIhMiqQDKEyRAihxW() { }

	// RVA: 0x1B1B2B0 Offset: 0x1B1A4B0 VA: 0x181B1B2B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B1B970 Offset: 0x1B1AB70 VA: 0x181B1B970 Slot: 1
	protected override void kONViQuzxwhRMrNRqosajBxGDJsI() { }

	// RVA: 0x1B1B9D0 Offset: 0x1B1ABD0 VA: 0x181B1B9D0
	private void mVrnEUyZIqoeCODwGZpTwLyPKBgN(bool ) { }

	// RVA: 0x1B1B310 Offset: 0x1B1A510 VA: 0x181B1B310
	private void JXNAqfAFBMHEgRMJuNIVfSYTNuIK() { }

	// RVA: 0x1B1BC10 Offset: 0x1B1AE10 VA: 0x181B1BC10
	private void pvvPFTnjYBPWMJqyqIcmKmJiiCRE() { }

	// RVA: 0x1B1B5C0 Offset: 0x1B1A7C0 VA: 0x181B1B5C0
	private void OCnouCdpELMuweqzywnPXqQTfpzO(CkhlcIPlVvypBSVaFOCHkKzsiiww , DRzFGNwLfBtrVDIrmmUwQRiiTbRh , uint , IntPtr ) { }

	// RVA: 0x1B1B920 Offset: 0x1B1AB20 VA: 0x181B1B920
	private void eXnBViMvOTBqZvEPPCryevVgrccUA(CkhlcIPlVvypBSVaFOCHkKzsiiww , DRzFGNwLfBtrVDIrmmUwQRiiTbRh , uint , IntPtr ) { }

	// RVA: 0x1B1B080 Offset: 0x1B1A280 VA: 0x181B1B080
	private void CXIXDwCJsdekBYBvZxRgBMZpdsQIA() { }

	// RVA: 0x1B1BA80 Offset: 0x1B1AC80 VA: 0x181B1BA80
	private IntPtr oIPbEZritwJzetesVPKWlxaiSNCt(IntPtr , uint , IntPtr , IntPtr ) { }
}

// Namespace: 
internal enum befTcAqKkqGIzEghwGTSSHdTEfLP // TypeDefIndex: 12922
{
	// Fields
	public int value__; // 0x0
	public const befTcAqKkqGIzEghwGTSSHdTEfLP None = 0;
	public const befTcAqKkqGIzEghwGTSSHdTEfLP XInput = 1;
	public const befTcAqKkqGIzEghwGTSSHdTEfLP WindowsGamingInput = 2;
}

// Namespace: 
private class kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.SGoVoUWkkIkbCreZtkycnermItHm // TypeDefIndex: 12923
{
	// Fields
	public int dzxapEZUluUxwTANDcCNCAaqnxFjA; // 0x10
	public int HvysoHpCxlyLkYpdTVilgTwNpnTX; // 0x14
	public int YvoMPlBNLutjKjcmeYGEUxnoCBhr; // 0x18
	public InputSource bJfMUzQKWYcdliDtvhoxVhbOBmtdb; // 0x1C

	// Methods

	// RVA: 0x18BA040 Offset: 0x18B9240 VA: 0x1818BA040
	public void .ctor(int , int , int , InputSource ) { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void tTXyaaeEzjIaNmrQLfIUdXCtvFXS(int ) { }

	// RVA: 0x1B17F50 Offset: 0x1B17150 VA: 0x181B17F50
	public kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.tKxZsTNbEiaulSWENemArWirwFaE hpCSJLVDCSYXyQarziwfdWYrpHhM() { }

	// RVA: 0x1B17F10 Offset: 0x1B17110 VA: 0x181B17F10
	public static int FJdogcShagtEXHwLTKSxMHDLdwUf(kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.SGoVoUWkkIkbCreZtkycnermItHm , kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.SGoVoUWkkIkbCreZtkycnermItHm ) { }
}

// Namespace: 
public struct kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.tKxZsTNbEiaulSWENemArWirwFaE // TypeDefIndex: 12924
{
	// Fields
	public int dzxapEZUluUxwTANDcCNCAaqnxFjA; // 0x0
	public int HvysoHpCxlyLkYpdTVilgTwNpnTX; // 0x4
	public InputSource bJfMUzQKWYcdliDtvhoxVhbOBmtdb; // 0x8

	// Methods

	// RVA: 0xD45600 Offset: 0xD44800 VA: 0x180D45600
	public void .ctor(int , int , InputSource ) { }
}

// Namespace: 
public enum kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.sZmwXqOcVRCxtjOEmLVlzoHQXTfC // TypeDefIndex: 12925
{
	// Fields
	public int value__; // 0x0
	public const kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.sZmwXqOcVRCxtjOEmLVlzoHQXTfC Connected = 0;
	public const kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.sZmwXqOcVRCxtjOEmLVlzoHQXTfC Disconnected = 1;
}

// Namespace: 
private class kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH // TypeDefIndex: 12926
{
	// Fields
	private List<kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.SGoVoUWkkIkbCreZtkycnermItHm> jWWdJwihURLejchaRETkfKgsUFvVA; // 0x10
	private List<kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.SGoVoUWkkIkbCreZtkycnermItHm> JfqSSQmOzWgRUEbPNvQBgaNHOLCp; // 0x18

	// Properties
	public int bWNaSRBQHsONPtmfRLKSSeEOaAtC { get; }

	// Methods

	// RVA: 0x1B1AF90 Offset: 0x1B1A190 VA: 0x181B1AF90
	public int zwBhLvCtDnsKtYgZPGxPeePUMiLaA() { }

	// RVA: 0x1B1A460 Offset: 0x1B19660 VA: 0x181B1A460
	public void .ctor() { }

	// RVA: 0x1B1A660 Offset: 0x1B19860 VA: 0x181B1A660
	public void gKtNAWdrgtHdcpvUAtkFHtOgqPTm(BridgedController ) { }

	// RVA: 0x1B1A310 Offset: 0x1B19510 VA: 0x181B1A310
	public void VygondFHUWEozbxOOumhlEHbseGPA(ControllerDisconnectedEventArgs ) { }

	// RVA: 0x1B1A4F0 Offset: 0x1B196F0 VA: 0x181B1A4F0
	public void bNTqWSsrqgUxKOMHCTofYLLOetNIA(int , int ) { }

	// RVA: 0x1B1AD40 Offset: 0x1B19F40 VA: 0x181B1AD40
	public int xPlbrsmiUAcjuGCMvjrhoFfLcIjjb(int , kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.sZmwXqOcVRCxtjOEmLVlzoHQXTfC ) { }

	// RVA: 0x1B1AE30 Offset: 0x1B1A030 VA: 0x181B1AE30
	public int xPlbrsmiUAcjuGCMvjrhoFfLcIjjb(int , InputSource , kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.sZmwXqOcVRCxtjOEmLVlzoHQXTfC ) { }

	// RVA: 0x1B1AAA0 Offset: 0x1B19CA0 VA: 0x181B1AAA0
	public kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.tKxZsTNbEiaulSWENemArWirwFaE hpCSJLVDCSYXyQarziwfdWYrpHhM(int , kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.sZmwXqOcVRCxtjOEmLVlzoHQXTfC ) { }

	// RVA: 0x1B1A150 Offset: 0x1B19350 VA: 0x181B1A150
	public int OYsuBWBNKKmxqDeDEVPsczyyFqaK(int , InputSource , kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH.sZmwXqOcVRCxtjOEmLVlzoHQXTfC ) { }

	// RVA: 0x1B1AC90 Offset: 0x1B19E90 VA: 0x181B1AC90
	private int uSeSeWPClIpqZBfBKahFdaXFLySx(int ) { }

	// RVA: 0x1B1ABF0 Offset: 0x1B19DF0 VA: 0x181B1ABF0
	private int uSeSeWPClIpqZBfBKahFdaXFLySx() { }
}

// Namespace: 
private class kzAUdGaqEUCWmDXTdGPJAnVKILlfb.mZxsRVEkXBfFtiqTCdBJLjHgalsoA : IInputManagerJoystickPublic, ITryGetLocalizedName // TypeDefIndex: 12927
{
	// Fields
	private IInputManagerJoystickPublic ZnHDWvnHDNkaSGPplXLszqSKwueN; // 0x10
	private int LXThJHSmCgafgiSrlmixGqDrdDxu; // 0x18

	// Properties
	public int rewiredId { get; }
	public int inputManagerId { get; }
	public string name { get; }
	public Nullable<long> systemId { get; }
	public int unityId { get; }
	public Guid instanceGuid { get; }
	public Guid persistentGuid { get; }
	public Controller.Extension extension { get; }

	// Methods

	// RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	public void .ctor(IInputManagerJoystickPublic , int ) { }

	// RVA: 0x1B1EFB0 Offset: 0x1B1E1B0 VA: 0x181B1EFB0 Slot: 4
	public int get_rewiredId() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 5
	public int get_inputManagerId() { }

	// RVA: 0x1B1EF60 Offset: 0x1B1E160 VA: 0x181B1EF60 Slot: 6
	public string get_name() { }

	// RVA: 0x1B1F000 Offset: 0x1B1E200 VA: 0x181B1F000 Slot: 7
	public Nullable<long> get_systemId() { }

	// RVA: 0x1B1F0D0 Offset: 0x1B1E2D0 VA: 0x181B1F0D0 Slot: 8
	public int get_unityId() { }

	// RVA: 0x1B1EE90 Offset: 0x1B1E090 VA: 0x181B1EE90 Slot: 10
	public Guid get_instanceGuid() { }

	// RVA: 0x1B1EE90 Offset: 0x1B1E090 VA: 0x181B1EE90 Slot: 11
	public Guid get_persistentGuid() { }

	// RVA: 0x1B1EE40 Offset: 0x1B1E040 VA: 0x181B1EE40 Slot: 9
	public Controller.Extension get_extension() { }

	// RVA: 0x1B1ED20 Offset: 0x1B1DF20 VA: 0x181B1ED20 Slot: 12
	public void SetVibration(float amount, int motorIndex) { }

	// RVA: 0x1B1EDF0 Offset: 0x1B1DFF0 VA: 0x181B1EDF0 Slot: 13
	public void StopVibration() { }

	// RVA: 0x1B1EC50 Offset: 0x1B1DE50 VA: 0x181B1EC50 Slot: 14
	private bool Rewired.Internal.Localization.ITryGetLocalizedName.TryGetLocalizedName(out string value) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class kzAUdGaqEUCWmDXTdGPJAnVKILlfb.TrBsLvKTKYwRbPNhtTJtlVrjPgMu // TypeDefIndex: 12928
{
	// Fields
	public static readonly kzAUdGaqEUCWmDXTdGPJAnVKILlfb.TrBsLvKTKYwRbPNhtTJtlVrjPgMu <>9; // 0x0
	public static Func<PidVid, bool> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x1B189A0 Offset: 0x1B17BA0 VA: 0x181B189A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal bool DnQxVrpixUOoWQLZwByoZVlwgihCA(PidVid ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class kzAUdGaqEUCWmDXTdGPJAnVKILlfb.eRXQcNbeEPsdBobiYHmodAstaEPR // TypeDefIndex: 12929
{
	// Fields
	public int vMMnNdpkueRiLFlZguBcHzbZGgNh; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1B1A140 Offset: 0x1B19340 VA: 0x181B1A140
	internal int EcdTyybTAhKEFombmGdtOiqfElxbA() { }
}

// Namespace: 
internal class kzAUdGaqEUCWmDXTdGPJAnVKILlfb : PlatformInputManager, INativePlatformHelper // TypeDefIndex: 12930
{
	// Fields
	private bool qzKvByPVEWOHjCWMCtXTMelXKQgv; // 0x38
	private gHZDHgevXTVHbfgrciETWtQJsNDZ rNFCfDxEBiPPRArxFUDxsenZbXYO; // 0x40
	private IndexedDictionary<int, PlatformInputManager> XqpBIgyklmhlbVQjkGPScjdWhskp; // 0x48
	private kzAUdGaqEUCWmDXTdGPJAnVKILlfb.feSmqPhqnFvudihGxsglRNnuOPwH wfeEISDTsKiArFByQCqfgmEhhHWiB; // 0x50
	private Action<int, ControllerDataUpdater> fHMGMxQkISQsfppdqvuoyBFLgHVhA; // 0x58
	private WindowsStandalonePrimaryInputSource ZNiJsdXuchFtgOcPWAwXakhwPCMM; // 0x60
	private PlatformInputManager nILBYXWuTFiuiPKLAaGCCrmAZTMi; // 0x68
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> PVjsWtiCHHzdlFdTJDxGWSjPufLE; // 0x70
	private Func<int> QealEOQnSUaSsIDENbjPVwwhDbFM; // 0x78
	private Func<PidVid, bool> sFUjQLILmuaPxPXRsYKSJJuSsVag; // 0x80

	// Properties
	private bool Rewired.Interfaces.INativePlatformHelper.isApplicationFocused { get; }
	[CustomObfuscation(rename = False)]
	public override int deviceCount { get; }
	[CustomObfuscation(rename = False)]
	public override PlatformInputManager primaryInputManager { get; }
	[CustomObfuscation(rename = False)]
	public override IInputSource inputSource { get; }
	[CustomObfuscation(rename = False)]
	public override InputSource inputSourceType { get; }

	// Methods

	// RVA: 0x1B1D310 Offset: 0x1B1C510 VA: 0x181B1D310
	public void .ctor(ConfigVars , Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> , Func<int> ) { }

	// RVA: 0x1B1D100 Offset: 0x1B1C300 VA: 0x181B1D100 Slot: 18
	private bool Rewired.Interfaces.INativePlatformHelper.get_isApplicationFocused() { }

	// RVA: 0x1B1C360 Offset: 0x1B1B560 VA: 0x181B1C360
	private bool CsHMfSIritklisWuOfttWQMmLOMR(ConfigVars , gHZDHgevXTVHbfgrciETWtQJsNDZ , XzAaAaHmPXADIEZpgeCGKAYakrcec ) { }

	// RVA: 0x1B1E990 Offset: 0x1B1DB90 VA: 0x181B1E990
	private bool utuKVAFYqoAxprlDASabijTMQxoE(ConfigVars , gHZDHgevXTVHbfgrciETWtQJsNDZ , XzAaAaHmPXADIEZpgeCGKAYakrcec ) { }

	// RVA: 0x1B1E610 Offset: 0x1B1D810 VA: 0x181B1E610
	private bool nOnPXscZiPgsiiaSAuOyjgqtRymq(ConfigVars , gHZDHgevXTVHbfgrciETWtQJsNDZ ) { }

	// RVA: 0x1B1E1F0 Offset: 0x1B1D3F0 VA: 0x181B1E1F0
	private bool kbbhEwGyprAXihZUzadRHSfblkNAA(ConfigVars , bool , out PlatformInputManager ) { }

	// RVA: 0x1B1DD80 Offset: 0x1B1CF80 VA: 0x181B1DD80
	private bool dCHprafcUdqtaCFjopKimtwfoHCp(ConfigVars , bool , out PlatformInputManager ) { }

	// RVA: 0x1B1E140 Offset: 0x1B1D340 VA: 0x181B1E140 Slot: 4
	public override int get_deviceCount() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 5
	public override PlatformInputManager get_primaryInputManager() { }

	// RVA: 0x1B1E1C0 Offset: 0x1B1D3C0 VA: 0x181B1E1C0 Slot: 6
	public override IInputSource get_inputSource() { }

	// RVA: 0x1B1E190 Offset: 0x1B1D390 VA: 0x181B1E190 Slot: 7
	public override InputSource get_inputSourceType() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B1C900 Offset: 0x1B1BB00 VA: 0x181B1C900 Slot: 8
	public override void Initialize() { }

	// RVA: 0x1B1E8C0 Offset: 0x1B1DAC0 VA: 0x181B1E8C0 Slot: 9
	public override void tTXyaaeEzjIaNmrQLfIUdXCtvFXS(UpdateLoopType ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B1CD00 Offset: 0x1B1BF00 VA: 0x181B1CD00 Slot: 10
	public override void OnDestroy() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 14
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B1D190 Offset: 0x1B1C390 VA: 0x181B1D190 Slot: 13
	public override void UpdateControllerData(int controllerId, ControllerDataUpdater data) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	public override void SystemDeviceConnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public override void SystemDeviceDisconnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B1C830 Offset: 0x1B1BA30 VA: 0x181B1C830 Slot: 16
	public override IUnifiedMouseSource GetUnifiedMouseSource() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B1C760 Offset: 0x1B1B960 VA: 0x181B1C760 Slot: 17
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource() { }

	// RVA: 0x1B1CA50 Offset: 0x1B1BC50 VA: 0x181B1CA50
	private void JdrCTXFUhLbDLSMQppHQmztjpXTiA(BridgedController ) { }

	// RVA: 0x1B1CB70 Offset: 0x1B1BD70 VA: 0x181B1CB70
	private void MWgWxOhbeZylsIGdngRLwmaCIOWHA(ControllerDisconnectedEventArgs ) { }

	// RVA: 0x1B1D250 Offset: 0x1B1C450 VA: 0x181B1D250
	private void ZsHEzVEiAZSnflMmrzWiafCipnwZ(EventArgs ) { }

	// RVA: 0x1B1CAB0 Offset: 0x1B1BCB0 VA: 0x181B1CAB0
	private void KykZrrneFrQgnSQtteLSGLuZANHIA(EventArgs ) { }

	// RVA: 0x1B1CE30 Offset: 0x1B1C030 VA: 0x181B1CE30
	private void RMZnIKVHKVkbAobcuPrhcbtmsVLC(UpdateControllerInfoEventArgs ) { }
}

// Namespace: 
internal class VHavnfpARoEKXeMAmiwYwxrOmcTN : pEkQmspfxhEFJdVnmKrxFByYSOih, XzAaAaHmPXADIEZpgeCGKAYakrcec // TypeDefIndex: 12931
{
	// Properties
	private befTcAqKkqGIzEghwGTSSHdTEfLP jvXzhjYtknsRTrLibLDtSrerOyrd { get; }

	// Methods

	// RVA: 0x1B18A00 Offset: 0x1B17C00 VA: 0x181B18A00
	public void .ctor(ConfigVars , Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> , Func<int> , Func<PidVid, bool> ) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 18
	private befTcAqKkqGIzEghwGTSSHdTEfLP PpxIlwPEKEcYaGREwEOclMdnQsfaA() { }

	// RVA: 0x1B18A10 Offset: 0x1B17C10 VA: 0x181B18A10 Slot: 19
	private bool lWIMUDuhWNezDEEnqZbdfYBhBYZZ(string , string , string , PidVid ) { }
}

// Namespace: 
private class HhkGLvFNGKVTlcLMLhQOSBTsmioq.KYrSGmDcXoMgKjWTreuPWcYQYRxq : IDisposable, IInputManagerJoystick, IInputManagerJoystickPublic, ITryGetLocalizedName // TypeDefIndex: 12932
{
	// Fields
	private bool RKrfLOyAYENBEutEOGQtiChmYGkg; // 0x10
	private int elLFJteTiCVpSogeBWPkFnTrudWE; // 0x14
	private readonly int qpxfGScmZFnJjJHHEMwgNsilPSNU; // 0x18
	public Guid ksQXSyCMArgpTQjQVaPCEGSVXoOp; // 0x1C
	public string bPRlrOkFkxMeTRPpkLsCwFxiAjff; // 0x30
	public string kJOmFeUAgkDdNXyTSilWpUlXspNF; // 0x38
	public Guid JyzEdkAbNbxABgJyWcyFlkkleEdEb; // 0x40
	public DeviceType vjNaXJxRDCWTAJsFEWYVTnEwhTHO; // 0x50
	public XInputDeviceSubType JxCymebXPwTiSAMyhHyaUgykzEXE; // 0x54
	public bool XJrptZuDMzJgsxBRxAwoplGIlEST; // 0x58
	public bool UBrtEsGmbRAWSrptOcrGkNRvXlBrA; // 0x59
	public bool LkAQVWpLMWbxWMUYIGgyAsjUCVBXA; // 0x5A
	public bool lWqppMKzzHIPnHfYbDXGuvOOIIlS; // 0x5B
	private int sJgnLOILuWsAJykwgKKCdvsqukrt; // 0x5C
	private int rmZOugMHptxjrqNTWuhSbMHSgMrR; // 0x60
	private int SrORvcQcSYELPJTyDirjrtpZoNfKA; // 0x64
	private int LmpluWWlOaMRxzVuDRghRTlVHtlj; // 0x68
	private readonly float[] wsHpigDPzQcVMoNRfBDQAlRyqROgb; // 0x70
	private readonly bool[] SMjvFtmVJPKHDGGnPQKpepfMESLb; // 0x78
	private HardwareJoystickMap_InputManager cNQOBilDgUZmDotqcVREDrrooBLe; // 0x80
	public readonly HhkGLvFNGKVTlcLMLhQOSBTsmioq.UUVUUvRowHYCnbidpptwhovMOjJA ZnHDWvnHDNkaSGPplXLszqSKwueN; // 0x88
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> CxbDKKUcFsXkVOyjAXODyEMHBOYo; // 0x90
	private Action YcwUCMkeBzxvZtnfpOUXimEyUsVk; // 0x98
	private readonly LocalizedString TnZQHEGYkXszUMsBnuvpKaQOxhsA; // 0xA0
	private bool GMJBZnbBPZJxjiGVOzUIPVMdcGYab; // 0xA8
	private bool eIQDQfZkSYmdtUBeiFMzQFUZeUMU; // 0xA9
	private bool KbxbxdFRwCxlESZSXPtZDThmvMJq; // 0xAA

	// Properties
	public string DioGwKdMhhhHNmPiSEvXwIPEHgeH { get; }
	public string lufcugDzGrkmtafbpDqMLPXSlCRNA { get; }
	public bool CqNfXmwsCramcKlbPNnqbQaWLOIxA { get; }
	[CustomObfuscation(rename = False)]
	public int rewiredId { get; set; }
	[CustomObfuscation(rename = False)]
	public int inputManagerId { get; }
	[CustomObfuscation(rename = False)]
	public string name { get; }
	[CustomObfuscation(rename = False)]
	public Nullable<long> systemId { get; }
	[CustomObfuscation(rename = False)]
	public int unityId { get; }
	[CustomObfuscation(rename = False)]
	public Controller.Extension extension { get; }
	[CustomObfuscation(rename = False)]
	public Guid instanceGuid { get; }
	[CustomObfuscation(rename = False)]
	public Guid persistentGuid { get; }

	// Methods

	// RVA: 0x1B15570 Offset: 0x1B14770 VA: 0x181B15570
	public string mVCyKVleFmsnkwdqkAWdRmzdLVTX() { }

	// RVA: 0x1B15F10 Offset: 0x1B15110 VA: 0x181B15F10
	public string tKqanQSpUrlCjRnUaGLbfEhyZrUeA() { }

	// RVA: 0x1B156A0 Offset: 0x1B148A0 VA: 0x181B156A0
	public bool qBBcTBoaNxJtFPAAudCkOTzaeUoq() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 9
	public int get_rewiredId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_rewiredId(int value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 10
	public int get_inputManagerId() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 11
	public string get_name() { }

	// RVA: 0x1B15340 Offset: 0x1B14540 VA: 0x181B15340 Slot: 12
	public Nullable<long> get_systemId() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 13
	public int get_unityId() { }

	// RVA: 0x1B15320 Offset: 0x1B14520 VA: 0x181B15320 Slot: 14
	public Controller.Extension get_extension() { }

	// RVA: 0x4D1A20 Offset: 0x4D0C20 VA: 0x1804D1A20 Slot: 15
	public Guid get_instanceGuid() { }

	// RVA: 0x4D1A20 Offset: 0x4D0C20 VA: 0x1804D1A20 Slot: 16
	public Guid get_persistentGuid() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B145F0 Offset: 0x1B137F0 VA: 0x181B145F0 Slot: 17
	public void SetVibration(float amount, int motorIndex) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B14620 Offset: 0x1B13820 VA: 0x181B14620 Slot: 18
	public void StopVibration() { }

	// RVA: 0x1B14500 Offset: 0x1B13700 VA: 0x181B14500 Slot: 19
	private bool Rewired.Internal.Localization.ITryGetLocalizedName.TryGetLocalizedName(out string value) { }

	// RVA: 0x1B14CC0 Offset: 0x1B13EC0 VA: 0x181B14CC0
	public void .ctor(int , bool , HhkGLvFNGKVTlcLMLhQOSBTsmioq.UUVUUvRowHYCnbidpptwhovMOjJA , Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> , Action ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1B14710 Offset: 0x1B13910 VA: 0x181B14710 Slot: 5
	public void Update() { }

	// RVA: 0x1B15690 Offset: 0x1B14890 VA: 0x181B15690
	public void oEXbFFUYZiUyfnAqbtKJchHqWTIU(bool ) { }

	// RVA: 0x1B159F0 Offset: 0x1B14BF0 VA: 0x181B159F0
	public bool rZRHnwaPmpSLAQnfWTvjKGQyXmrR(HhkGLvFNGKVTlcLMLhQOSBTsmioq.HnqDfgbiuaNmakIcDhOlWSVPmqsyA ) { }

