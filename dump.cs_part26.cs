	// RVA: 0x1FE2760 Offset: 0x1FE1960 VA: 0x181FE2760 Slot: 66
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1FE23C0 Offset: 0x1FE15C0 VA: 0x181FE23C0 Slot: 67
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1FE2410 Offset: 0x1FE1610 VA: 0x181FE2410 Slot: 68
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x1FE2460 Offset: 0x1FE1660 VA: 0x181FE2460 Slot: 69
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x1FE26A0 Offset: 0x1FE18A0 VA: 0x181FE26A0 Slot: 70
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x1FE25E0 Offset: 0x1FE17E0 VA: 0x181FE25E0 Slot: 71
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x1FE2520 Offset: 0x1FE1720 VA: 0x181FE2520 Slot: 72
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckWriter : XmlWriter // TypeDefIndex: 11935
{
	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Properties
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x1FE4EB0 Offset: 0x1FE40B0 VA: 0x181FE4EB0
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x1FE41F0 Offset: 0x1FE33F0 VA: 0x181FE41F0
	private void CheckAsync() { }

	// RVA: 0x1FE4A20 Offset: 0x1FE3C20 VA: 0x181FE4A20 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1FE49D0 Offset: 0x1FE3BD0 VA: 0x181FE49D0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1FE46D0 Offset: 0x1FE38D0 VA: 0x181FE46D0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1FE4620 Offset: 0x1FE3820 VA: 0x181FE4620 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1FE4A60 Offset: 0x1FE3C60 VA: 0x181FE4A60 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE4710 Offset: 0x1FE3910 VA: 0x181FE4710 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1FE47A0 Offset: 0x1FE39A0 VA: 0x181FE47A0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1FE4960 Offset: 0x1FE3B60 VA: 0x181FE4960 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FE4690 Offset: 0x1FE3890 VA: 0x181FE4690 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1FE44C0 Offset: 0x1FE36C0 VA: 0x181FE44C0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1FE45D0 Offset: 0x1FE37D0 VA: 0x181FE45D0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1FE4840 Offset: 0x1FE3A40 VA: 0x181FE4840 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1FE4750 Offset: 0x1FE3950 VA: 0x181FE4750 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1FE4510 Offset: 0x1FE3710 VA: 0x181FE4510 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1FE4E60 Offset: 0x1FE4060 VA: 0x181FE4E60 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FE4AD0 Offset: 0x1FE3CD0 VA: 0x181FE4AD0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1FE4B20 Offset: 0x1FE3D20 VA: 0x181FE4B20 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1FE4560 Offset: 0x1FE3760 VA: 0x181FE4560 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FE48A0 Offset: 0x1FE3AA0 VA: 0x181FE48A0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1FE4910 Offset: 0x1FE3B10 VA: 0x181FE4910 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1FE43E0 Offset: 0x1FE35E0 VA: 0x181FE43E0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1FE4450 Offset: 0x1FE3650 VA: 0x181FE4450 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1FE4F30 Offset: 0x1FE4130 VA: 0x181FE4F30 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1FE4280 Offset: 0x1FE3480 VA: 0x181FE4280 Slot: 28
	public override void Close() { }

	// RVA: 0x1FE42F0 Offset: 0x1FE34F0 VA: 0x181FE42F0 Slot: 29
	public override void Flush() { }

	// RVA: 0x1FE4330 Offset: 0x1FE3530 VA: 0x181FE4330 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1FE4E10 Offset: 0x1FE4010 VA: 0x181FE4E10 Slot: 31
	public override void WriteValue(object value) { }

	// RVA: 0x1FE4D70 Offset: 0x1FE3F70 VA: 0x181FE4D70 Slot: 32
	public override void WriteValue(string value) { }

	// RVA: 0x1FE4BE0 Offset: 0x1FE3DE0 VA: 0x181FE4BE0 Slot: 33
	public override void WriteValue(bool value) { }

	// RVA: 0x1FE4C80 Offset: 0x1FE3E80 VA: 0x181FE4C80 Slot: 34
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1FE4D20 Offset: 0x1FE3F20 VA: 0x181FE4D20 Slot: 35
	public override void WriteValue(double value) { }

	// RVA: 0x1FE4C30 Offset: 0x1FE3E30 VA: 0x181FE4C30 Slot: 36
	public override void WriteValue(float value) { }

	// RVA: 0x1FE4B80 Offset: 0x1FE3D80 VA: 0x181FE4B80 Slot: 37
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1FE4CD0 Offset: 0x1FE3ED0 VA: 0x181FE4CD0 Slot: 38
	public override void WriteValue(int value) { }

	// RVA: 0x1FE4DC0 Offset: 0x1FE3FC0 VA: 0x181FE4DC0 Slot: 39
	public override void WriteValue(long value) { }

	// RVA: 0x1FE4380 Offset: 0x1FE3580 VA: 0x181FE4380 Slot: 40
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1FE47E0 Offset: 0x1FE39E0 VA: 0x181FE47E0 Slot: 41
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1FE42C0 Offset: 0x1FE34C0 VA: 0x181FE42C0 Slot: 42
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Xml
internal class XmlAutoDetectWriter : XmlRawWriter // TypeDefIndex: 11936
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private OnRemoveWriter onRemove; // 0x30
	private XmlWriterSettings writerSettings; // 0x38
	private XmlEventCache eventCache; // 0x40
	private TextWriter textWriter; // 0x48
	private Stream strm; // 0x50

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1FE60F0 Offset: 0x1FE52F0 VA: 0x181FE60F0
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0x1FE60C0 Offset: 0x1FE52C0 VA: 0x181FE60C0
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0x1FE6090 Offset: 0x1FE5290 VA: 0x181FE6090
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0x1FE5640 Offset: 0x1FE4840 VA: 0x181FE5640 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1FE59A0 Offset: 0x1FE4BA0 VA: 0x181FE59A0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE5920 Offset: 0x1FE4B20 VA: 0x181FE5920 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FE56C0 Offset: 0x1FE48C0 VA: 0x181FE56C0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1FE54E0 Offset: 0x1FE46E0 VA: 0x181FE54E0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1FE5600 Offset: 0x1FE4800 VA: 0x181FE5600 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1FE5820 Offset: 0x1FE4A20 VA: 0x181FE5820 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1FE5FA0 Offset: 0x1FE51A0 VA: 0x181FE5FA0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FE5B60 Offset: 0x1FE4D60 VA: 0x181FE5B60 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1FE55C0 Offset: 0x1FE47C0 VA: 0x181FE55C0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FE5860 Offset: 0x1FE4A60 VA: 0x181FE5860 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1FE58A0 Offset: 0x1FE4AA0 VA: 0x181FE58A0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1FE5720 Offset: 0x1FE4920 VA: 0x181FE5720 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1FE5560 Offset: 0x1FE4760 VA: 0x181FE5560 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1FE5BE0 Offset: 0x1FE4DE0 VA: 0x181FE5BE0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1FE53E0 Offset: 0x1FE45E0 VA: 0x181FE53E0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1FE5460 Offset: 0x1FE4660 VA: 0x181FE5460 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1FE4F70 Offset: 0x1FE4170 VA: 0x181FE4F70 Slot: 28
	public override void Close() { }

	// RVA: 0x1FE5250 Offset: 0x1FE4450 VA: 0x181FE5250 Slot: 29
	public override void Flush() { }

	// RVA: 0x1FE5E80 Offset: 0x1FE5080 VA: 0x181FE5E80 Slot: 31
	public override void WriteValue(object value) { }

	// RVA: 0x1FE5CB0 Offset: 0x1FE4EB0 VA: 0x181FE5CB0 Slot: 32
	public override void WriteValue(string value) { }

	// RVA: 0x1FE5DC0 Offset: 0x1FE4FC0 VA: 0x181FE5DC0 Slot: 33
	public override void WriteValue(bool value) { }

	// RVA: 0x1FE5D60 Offset: 0x1FE4F60 VA: 0x181FE5D60 Slot: 34
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1FE5E20 Offset: 0x1FE5020 VA: 0x181FE5E20 Slot: 35
	public override void WriteValue(double value) { }

	// RVA: 0x1FE5EE0 Offset: 0x1FE50E0 VA: 0x181FE5EE0 Slot: 36
	public override void WriteValue(float value) { }

	// RVA: 0x1FE5C50 Offset: 0x1FE4E50 VA: 0x181FE5C50 Slot: 37
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1FE5D10 Offset: 0x1FE4F10 VA: 0x181FE5D10 Slot: 38
	public override void WriteValue(int value) { }

	// RVA: 0x1FE5F40 Offset: 0x1FE5140 VA: 0x181FE5F40 Slot: 39
	public override void WriteValue(long value) { }

	// RVA: 0x1FE61B0 Offset: 0x1FE53B0 VA: 0x181FE61B0 Slot: 43
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1FE5FE0 Offset: 0x1FE51E0 VA: 0x181FE5FE0 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1FE6030 Offset: 0x1FE5230 VA: 0x181FE6030 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x173D350 Offset: 0x173C550 VA: 0x18173D350 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1FE56F0 Offset: 0x1FE48F0 VA: 0x181FE56F0 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE5780 Offset: 0x1FE4980 VA: 0x181FE5780 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE57B0 Offset: 0x1FE49B0 VA: 0x181FE57B0 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1FE1570 Offset: 0x1FE0770 VA: 0x181FE1570 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1FE5B00 Offset: 0x1FE4D00 VA: 0x181FE5B00 Slot: 52
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1FE0C40 Offset: 0x1FDFE40 VA: 0x181FE0C40 Slot: 53
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1FE52A0 Offset: 0x1FE44A0 VA: 0x181FE52A0
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0x1FE5240 Offset: 0x1FE4440 VA: 0x181FE5240
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0x1FE5380 Offset: 0x1FE4580 VA: 0x181FE5380
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0x1FE4FC0 Offset: 0x1FE41C0 VA: 0x181FE4FC0
	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }
}

// Namespace: System.Xml
internal class XmlEncodedRawTextWriter : XmlRawWriter // TypeDefIndex: 11937
{
	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected int bufBytesUsed; // 0x6C
	protected char[] bufChars; // 0x70
	protected Encoder encoder; // 0x78
	protected TextWriter writer; // 0x80
	protected bool trackTextContent; // 0x88
	protected bool inTextContent; // 0x89
	private int lastMarkPos; // 0x8C
	private int[] textContentMarks; // 0x90
	private CharEntityEncoderFallback charEntityFallback; // 0x98
	protected NewLineHandling newLineHandling; // 0xA0
	protected bool closeOutput; // 0xA4
	protected bool omitXmlDeclaration; // 0xA5
	protected string newLineChars; // 0xA8
	protected bool checkCharacters; // 0xB0
	protected XmlStandalone standalone; // 0xB4
	protected XmlOutputMethod outputMethod; // 0xB8
	protected bool autoXmlDeclaration; // 0xBC
	protected bool mergeCDataSections; // 0xBD

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1FEACC0 Offset: 0x1FE9EC0 VA: 0x181FEACC0
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x1FE1FA0 Offset: 0x1FE11A0 VA: 0x181FE1FA0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1FEADB0 Offset: 0x1FE9FB0 VA: 0x181FEADB0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1FEAA00 Offset: 0x1FE9C00 VA: 0x181FEAA00 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1FEAC50 Offset: 0x1FE9E50 VA: 0x181FEAC50 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1FE9400 Offset: 0x1FE8600 VA: 0x181FE9400 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1FEA530 Offset: 0x1FE9730 VA: 0x181FEA530 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE7FB0 Offset: 0x1FE71B0 VA: 0x181FE7FB0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1FE9A80 Offset: 0x1FE8C80 VA: 0x181FE9A80 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE9D40 Offset: 0x1FE8F40 VA: 0x181FE9D40 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FEA3F0 Offset: 0x1FE95F0 VA: 0x181FEA3F0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FE9A20 Offset: 0x1FE8C20 VA: 0x181FE9A20 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1FE9E70 Offset: 0x1FE9070 VA: 0x181FE9E70 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1FEA620 Offset: 0x1FE9820 VA: 0x181FEA620 Slot: 52
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1FE9C00 Offset: 0x1FE8E00 VA: 0x181FE9C00 Slot: 53
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1FE8AA0 Offset: 0x1FE7CA0 VA: 0x181FE8AA0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1FE92A0 Offset: 0x1FE84A0 VA: 0x181FE92A0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1FE9F60 Offset: 0x1FE9160 VA: 0x181FE9F60 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1FE9C60 Offset: 0x1FE8E60 VA: 0x181FE9C60 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1FE8CE0 Offset: 0x1FE7EE0 VA: 0x181FE8CE0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1FEA980 Offset: 0x1FE9B80 VA: 0x181FEA980 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FEA7A0 Offset: 0x1FE99A0 VA: 0x181FEA7A0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1FEA820 Offset: 0x1FE9A20 VA: 0x181FEA820 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1EDA260 Offset: 0x1ED9460 VA: 0x181EDA260 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FEA360 Offset: 0x1FE9560 VA: 0x181FEA360 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1FE1E10 Offset: 0x1FE1010 VA: 0x181FE1E10 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1FE71B0 Offset: 0x1FE63B0 VA: 0x181FE71B0 Slot: 28
	public override void Close() { }

	// RVA: 0x1FE7AB0 Offset: 0x1FE6CB0 VA: 0x181FE7AB0 Slot: 29
	public override void Flush() { }

	// RVA: 0x1FE75F0 Offset: 0x1FE67F0 VA: 0x181FE75F0 Slot: 56
	protected virtual void FlushBuffer() { }

	// RVA: 0x1FE7300 Offset: 0x1FE6500 VA: 0x181FE7300
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x1FE79D0 Offset: 0x1FE6BD0 VA: 0x181FE79D0
	private void FlushEncoder() { }

	// RVA: 0x1FE83A0 Offset: 0x1FE75A0 VA: 0x181FE83A0
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1FE96D0 Offset: 0x1FE88D0 VA: 0x181FE96D0
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1FE7F60 Offset: 0x1FE7160 VA: 0x181FE7F60
	protected void RawText(string s) { }

	// RVA: 0x1FE7DB0 Offset: 0x1FE6FB0 VA: 0x181FE7DB0
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1FEA0B0 Offset: 0x1FE92B0 VA: 0x181FEA0B0
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1FE8EC0 Offset: 0x1FE80C0 VA: 0x181FE8EC0
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1FE86C0 Offset: 0x1FE78C0 VA: 0x181FE86C0
	protected void WriteCDataSection(string text) { }

	// RVA: 0x1FE7480 Offset: 0x1FE6680 VA: 0x181FE7480
	private static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst) { }

	// RVA: 0x1FE7BF0 Offset: 0x1FE6DF0 VA: 0x181FE7BF0
	private char* InvalidXmlChar(int ch, char* pDst, bool entitize) { }

	// RVA: 0x1FE7220 Offset: 0x1FE6420 VA: 0x181FE7220
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst) { }

	// RVA: 0x1FE7020 Offset: 0x1FE6220 VA: 0x181FE7020
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x1FE7B40 Offset: 0x1FE6D40 VA: 0x181FE7B40
	private void GrowTextContentMarks() { }

	// RVA: 0x1FE9ED0 Offset: 0x1FE90D0 VA: 0x181FE9ED0
	protected char* WriteNewLine(char* pDst) { }

	// RVA: 0x1FE7D20 Offset: 0x1FE6F20 VA: 0x181FE7D20
	protected static char* LtEntity(char* pDst) { }

	// RVA: 0x1FE7BD0 Offset: 0x1FE6DD0 VA: 0x181FE7BD0
	protected static char* GtEntity(char* pDst) { }

	// RVA: 0x1FE6FE0 Offset: 0x1FE61E0 VA: 0x181FE6FE0
	protected static char* AmpEntity(char* pDst) { }

	// RVA: 0x1FE7D40 Offset: 0x1FE6F40 VA: 0x181FE7D40
	protected static char* QuoteEntity(char* pDst) { }

	// RVA: 0x1FE7FF0 Offset: 0x1FE71F0 VA: 0x181FE7FF0
	protected static char* TabEntity(char* pDst) { }

	// RVA: 0x1FE7D00 Offset: 0x1FE6F00 VA: 0x181FE7D00
	protected static char* LineFeedEntity(char* pDst) { }

	// RVA: 0x1FE7000 Offset: 0x1FE6200 VA: 0x181FE7000
	protected static char* CarriageReturnEntity(char* pDst) { }

	// RVA: 0x1FE7100 Offset: 0x1FE6300 VA: 0x181FE7100
	private static char* CharEntity(char* pDst, char ch) { }

	// RVA: 0x1FE7D80 Offset: 0x1FE6F80 VA: 0x181FE7D80
	protected static char* RawStartCData(char* pDst) { }

	// RVA: 0x1FE7D60 Offset: 0x1FE6F60 VA: 0x181FE7D60
	protected static char* RawEndCData(char* pDst) { }

	// RVA: 0x1FE8010 Offset: 0x1FE7210 VA: 0x181FE8010
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }
}

// Namespace: System.Xml
internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter // TypeDefIndex: 11938
{
	// Fields
	protected int indentLevel; // 0xC0
	protected bool newLineOnAttributes; // 0xC4
	protected string indentChars; // 0xC8
	protected bool mixedContent; // 0xD0
	private BitStack mixedContentStack; // 0xD8
	protected ConformanceLevel conformanceLevel; // 0xE0

	// Methods

	// RVA: 0x1FE6EC0 Offset: 0x1FE60C0 VA: 0x181FE6EC0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1FE6FB0 Offset: 0x1FE61B0 VA: 0x181FE6FB0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1FE65F0 Offset: 0x1FE57F0 VA: 0x181FE65F0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1FE6C80 Offset: 0x1FE5E80 VA: 0x181FE6C80 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE63C0 Offset: 0x1FE55C0 VA: 0x181FE63C0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x190DCC0 Offset: 0x190CEC0 VA: 0x18190DCC0 Slot: 47
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x1FE6660 Offset: 0x1FE5860 VA: 0x181FE6660 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE67D0 Offset: 0x1FE59D0 VA: 0x181FE67D0 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE6B30 Offset: 0x1FE5D30 VA: 0x181FE6B30 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FE64F0 Offset: 0x1FE56F0 VA: 0x181FE64F0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1FE65B0 Offset: 0x1FE57B0 VA: 0x181FE65B0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1FE69E0 Offset: 0x1FE5BE0 VA: 0x181FE69E0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1FE66F0 Offset: 0x1FE58F0 VA: 0x181FE66F0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1FE6500 Offset: 0x1FE5700 VA: 0x181FE6500 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1FE6E30 Offset: 0x1FE6030 VA: 0x181FE6E30 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1FE6E40 Offset: 0x1FE6040 VA: 0x181FE6E40 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FE6DB0 Offset: 0x1FE5FB0 VA: 0x181FE6DB0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1FE6510 Offset: 0x1FE5710 VA: 0x181FE6510 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FE6A30 Offset: 0x1FE5C30 VA: 0x181FE6A30 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1FE6AC0 Offset: 0x1FE5CC0 VA: 0x181FE6AC0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1FE6430 Offset: 0x1FE5630 VA: 0x181FE6430 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1FE62B0 Offset: 0x1FE54B0 VA: 0x181FE62B0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1FE6940 Offset: 0x1FE5B40 VA: 0x181FE6940
	private void WriteIndent() { }
}

// Namespace: 
private enum XmlEventCache.XmlEventType // TypeDefIndex: 11939
{
	// Fields
	public int value__; // 0x0
	public const XmlEventCache.XmlEventType Unknown = 0;
	public const XmlEventCache.XmlEventType DocType = 1;
	public const XmlEventCache.XmlEventType StartElem = 2;
	public const XmlEventCache.XmlEventType StartAttr = 3;
	public const XmlEventCache.XmlEventType EndAttr = 4;
	public const XmlEventCache.XmlEventType CData = 5;
	public const XmlEventCache.XmlEventType Comment = 6;
	public const XmlEventCache.XmlEventType PI = 7;
	public const XmlEventCache.XmlEventType Whitespace = 8;
	public const XmlEventCache.XmlEventType String = 9;
	public const XmlEventCache.XmlEventType Raw = 10;
	public const XmlEventCache.XmlEventType EntRef = 11;
	public const XmlEventCache.XmlEventType CharEnt = 12;
	public const XmlEventCache.XmlEventType SurrCharEnt = 13;
	public const XmlEventCache.XmlEventType Base64 = 14;
	public const XmlEventCache.XmlEventType BinHex = 15;
	public const XmlEventCache.XmlEventType XmlDecl1 = 16;
	public const XmlEventCache.XmlEventType XmlDecl2 = 17;
	public const XmlEventCache.XmlEventType StartContent = 18;
	public const XmlEventCache.XmlEventType EndElem = 19;
	public const XmlEventCache.XmlEventType FullEndElem = 20;
	public const XmlEventCache.XmlEventType Nmsp = 21;
	public const XmlEventCache.XmlEventType EndBase64 = 22;
	public const XmlEventCache.XmlEventType Close = 23;
	public const XmlEventCache.XmlEventType Flush = 24;
	public const XmlEventCache.XmlEventType Dispose = 25;
}

// Namespace: 
private struct XmlEventCache.XmlEvent // TypeDefIndex: 11940
{
	// Fields
	private XmlEventCache.XmlEventType eventType; // 0x0
	private string s1; // 0x8
	private string s2; // 0x10
	private string s3; // 0x18
	private object o; // 0x20

	// Properties
	public XmlEventCache.XmlEventType EventType { get; }
	public string String1 { get; }
	public string String2 { get; }
	public string String3 { get; }
	public object Object { get; }

	// Methods

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void InitEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0xBB0D00 Offset: 0xBAFF00 VA: 0x180BB0D00
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x1FECCC0 Offset: 0x1FEBEC0 VA: 0x181FECCC0
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x1FECD00 Offset: 0x1FEBF00 VA: 0x181FECD00
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x1FECCE0 Offset: 0x1FEBEE0 VA: 0x181FECCE0
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1FECCD0 Offset: 0x1FEBED0 VA: 0x181FECCD0
	public void InitEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public XmlEventCache.XmlEventType get_EventType() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public string get_String1() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_String2() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_String3() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public object get_Object() { }
}

// Namespace: System.Xml
internal sealed class XmlEventCache : XmlRawWriter // TypeDefIndex: 11941
{
	// Fields
	private List<XmlEventCache.XmlEvent[]> pages; // 0x28
	private XmlEventCache.XmlEvent[] pageCurr; // 0x30
	private int pageSize; // 0x38
	private bool hasRootNode; // 0x3C
	private StringConcat singleText; // 0x40
	private string baseUri; // 0x78

	// Methods

	// RVA: 0x1FECC80 Offset: 0x1FEBE80 VA: 0x181FECC80
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x1FEB450 Offset: 0x1FEA650 VA: 0x181FEB450
	public void EndEvents() { }

	// RVA: 0x1FEB4A0 Offset: 0x1FEA6A0 VA: 0x181FEB4A0
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x1FEC4C0 Offset: 0x1FEB6C0 VA: 0x181FEC4C0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1FEC8E0 Offset: 0x1FEBAE0 VA: 0x181FEC8E0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FEC860 Offset: 0x1FEBA60 VA: 0x181FEC860 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FEC540 Offset: 0x1FEB740 VA: 0x181FEC540 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1FEC370 Offset: 0x1FEB570 VA: 0x181FEC370 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1FEC460 Offset: 0x1FEB660 VA: 0x181FEC460 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1FEC790 Offset: 0x1FEB990 VA: 0x181FEC790 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1FECB30 Offset: 0x1FEBD30 VA: 0x181FECB30 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FEC960 Offset: 0x1FEBB60 VA: 0x181FEC960 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1FE55C0 Offset: 0x1FE47C0 VA: 0x181FE55C0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FE5860 Offset: 0x1FE4A60 VA: 0x181FE5860 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1FEC800 Offset: 0x1FEBA00 VA: 0x181FEC800 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1FEC640 Offset: 0x1FEB840 VA: 0x181FEC640 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1FEC3D0 Offset: 0x1FEB5D0 VA: 0x181FEC3D0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1FEC9D0 Offset: 0x1FEBBD0 VA: 0x181FEC9D0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1FEC190 Offset: 0x1FEB390 VA: 0x181FEC190 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1FEC280 Offset: 0x1FEB480 VA: 0x181FEC280 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1FEB360 Offset: 0x1FEA560 VA: 0x181FEB360 Slot: 28
	public override void Close() { }

	// RVA: 0x1FEBEB0 Offset: 0x1FEB0B0 VA: 0x181FEBEB0 Slot: 29
	public override void Flush() { }

	// RVA: 0x1FECA90 Offset: 0x1FEBC90 VA: 0x181FECA90 Slot: 31
	public override void WriteValue(object value) { }

	// RVA: 0x188A050 Offset: 0x1889250 VA: 0x18188A050 Slot: 32
	public override void WriteValue(string value) { }

	// RVA: 0x1FEB3A0 Offset: 0x1FEA5A0 VA: 0x181FEB3A0 Slot: 42
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1FECB90 Offset: 0x1FEBD90 VA: 0x181FECB90 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1FECC20 Offset: 0x1FEBE20 VA: 0x181FECC20 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1FEC090 Offset: 0x1FEB290 VA: 0x181FEC090 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1FEC5C0 Offset: 0x1FEB7C0 VA: 0x181FEC5C0 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FEC6A0 Offset: 0x1FEB8A0 VA: 0x181FEC6A0 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FEC720 Offset: 0x1FEB920 VA: 0x181FEC720 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1FEC580 Offset: 0x1FEB780 VA: 0x181FEC580 Slot: 54
	internal override void WriteEndBase64() { }

	// RVA: 0x1FEB160 Offset: 0x1FEA360 VA: 0x181FEB160
	private void AddEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0x1FEB290 Offset: 0x1FEA490 VA: 0x181FEB290
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x1FEB2F0 Offset: 0x1FEA4F0 VA: 0x181FEB2F0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x1FEB0E0 Offset: 0x1FEA2E0 VA: 0x181FEB0E0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x1FEB210 Offset: 0x1FEA410 VA: 0x181FEB210
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1FEB1B0 Offset: 0x1FEA3B0 VA: 0x181FEB1B0
	private void AddEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0x1FEBEF0 Offset: 0x1FEB0F0 VA: 0x181FEBEF0
	private int NewEvent() { }

	// RVA: 0x1FEC0D0 Offset: 0x1FEB2D0 VA: 0x181FEC0D0
	private static byte[] ToBytes(byte[] buffer, int index, int count) { }
}

// Namespace: System.Xml
public class XmlParserContext // TypeDefIndex: 11942
{
	// Fields
	private XmlNameTable _nt; // 0x10
	private XmlNamespaceManager _nsMgr; // 0x18
	private string _docTypeName; // 0x20
	private string _pubId; // 0x28
	private string _sysId; // 0x30
	private string _internalSubset; // 0x38
	private string _xmlLang; // 0x40
	private XmlSpace _xmlSpace; // 0x48
	private string _baseURI; // 0x50
	private Encoding _encoding; // 0x58

	// Properties
	public XmlNameTable NameTable { get; }
	public XmlNamespaceManager NamespaceManager { get; }
	public string DocTypeName { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string BaseURI { get; }
	public string InternalSubset { get; }
	public string XmlLang { get; }
	public XmlSpace XmlSpace { get; }
	public Encoding Encoding { get; }
	internal bool HasDtdInfo { get; }

	// Methods

	// RVA: 0x1FECD20 Offset: 0x1FEBF20 VA: 0x181FECD20
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x1FECF70 Offset: 0x1FEC170 VA: 0x181FECF70
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x1FED1B0 Offset: 0x1FEC3B0 VA: 0x181FED1B0
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_DocTypeName() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_PublicId() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_SystemId() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_BaseURI() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_InternalSubset() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_XmlLang() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Encoding get_Encoding() { }

	// RVA: 0x1FED3F0 Offset: 0x1FEC5F0 VA: 0x181FED3F0
	internal bool get_HasDtdInfo() { }
}

// Namespace: System.Xml
internal abstract class XmlRawWriter : XmlWriter // TypeDefIndex: 11943
{
	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal virtual IXmlNamespaceResolver NamespaceResolver { set; }
	internal virtual bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1FED8B0 Offset: 0x1FECAB0 VA: 0x181FED8B0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1FED910 Offset: 0x1FECB10 VA: 0x181FED910 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1FED6D0 Offset: 0x1FEC8D0 VA: 0x181FED6D0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1FED730 Offset: 0x1FEC930 VA: 0x181FED730 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1FED7D0 Offset: 0x1FEC9D0 VA: 0x181FED7D0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1FED570 Offset: 0x1FEC770 VA: 0x181FED570 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1FED4B0 Offset: 0x1FEC6B0 VA: 0x181FED4B0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1FEDB50 Offset: 0x1FECD50 VA: 0x181FEDB50 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x188A050 Offset: 0x1889250 VA: 0x18188A050 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1FED620 Offset: 0x1FEC820 VA: 0x181FED620 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1FED9B0 Offset: 0x1FECBB0 VA: 0x181FED9B0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x188A050 Offset: 0x1889250 VA: 0x18188A050 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FE55C0 Offset: 0x1FE47C0 VA: 0x181FE55C0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FE55C0 Offset: 0x1FE47C0 VA: 0x181FE55C0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x188A050 Offset: 0x1889250 VA: 0x18188A050 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1FEDA60 Offset: 0x1FECC60 VA: 0x181FEDA60 Slot: 31
	public override void WriteValue(object value) { }

	// RVA: 0x188A050 Offset: 0x1889250 VA: 0x18188A050 Slot: 32
	public override void WriteValue(string value) { }

	// RVA: 0x1FED510 Offset: 0x1FEC710 VA: 0x181FED510 Slot: 40
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1FED850 Offset: 0x1FECA50 VA: 0x181FED850 Slot: 41
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0 Slot: 43
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 44
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 45
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	// RVA: -1 Offset: -1 Slot: 46
	internal abstract void StartElementContent();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 47
	internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: -1 Offset: -1 Slot: 48
	internal abstract void WriteEndElement(string prefix, string localName, string ns);

	// RVA: 0x1FED830 Offset: 0x1FECA30 VA: 0x181FED830 Slot: 49
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 50
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 51
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1FED970 Offset: 0x1FECB70 VA: 0x181FED970 Slot: 52
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1FED790 Offset: 0x1FEC990 VA: 0x181FED790 Slot: 53
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1FED6B0 Offset: 0x1FEC8B0 VA: 0x181FED6B0 Slot: 54
	internal virtual void WriteEndBase64() { }

	// RVA: 0x1FED490 Offset: 0x1FEC690 VA: 0x181FED490 Slot: 55
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: System.Xml
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
public abstract class XmlReader : IDisposable // TypeDefIndex: 11944
{
	// Fields
	private static uint IsTextualNodeBitmap; // 0x0
	private static uint CanReadContentAsBitmap; // 0x4
	private static uint HasValueBitmap; // 0x8

	// Properties
	public virtual XmlReaderSettings Settings { get; }
	public abstract XmlNodeType NodeType { get; }
	public virtual string Name { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public virtual bool HasValue { get; }
	public abstract string Value { get; }
	public abstract int Depth { get; }
	public abstract string BaseURI { get; }
	public abstract bool IsEmptyElement { get; }
	public virtual bool IsDefault { get; }
	public virtual char QuoteChar { get; }
	public virtual XmlSpace XmlSpace { get; }
	public virtual string XmlLang { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual Type ValueType { get; }
	public abstract int AttributeCount { get; }
	public abstract bool EOF { get; }
	public abstract ReadState ReadState { get; }
	public abstract XmlNameTable NameTable { get; }
	public virtual bool CanResolveEntity { get; }
	public virtual bool CanReadValueChunk { get; }
	public virtual bool HasAttributes { get; }
	internal virtual XmlNamespaceManager NamespaceManager { get; }
	internal bool IsDefaultInternal { get; }
	internal virtual IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x1FF1CE0 Offset: 0x1FF0EE0 VA: 0x181FF1CE0 Slot: 7
	public virtual string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_Prefix();

	// RVA: 0x1FF1BA0 Offset: 0x1FF0DA0 VA: 0x181FF1BA0 Slot: 11
	public virtual bool get_HasValue() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int get_Depth();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract string get_BaseURI();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsEmptyElement();

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 16
	public virtual bool get_IsDefault() { }

	// RVA: 0x1FF1DF0 Offset: 0x1FF0FF0 VA: 0x181FF1DF0 Slot: 17
	public virtual char get_QuoteChar() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 18
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x1FF1EA0 Offset: 0x1FF10A0 VA: 0x181FF1EA0 Slot: 19
	public virtual string get_XmlLang() { }

	// RVA: 0x1FF1E00 Offset: 0x1FF1000 VA: 0x181FF1E00 Slot: 20
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1FF1E40 Offset: 0x1FF1040 VA: 0x181FF1E40 Slot: 21
	public virtual Type get_ValueType() { }

	// RVA: 0x1FF0250 Offset: 0x1FEF450 VA: 0x181FF0250 Slot: 22
	public virtual string ReadContentAsString() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int get_AttributeCount();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string GetAttribute(string name);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string GetAttribute(string name, string namespaceURI);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string GetAttribute(int i);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool MoveToAttribute(string name);

	// RVA: 0x1FF00E0 Offset: 0x1FEF2E0 VA: 0x181FF00E0 Slot: 28
	public virtual void MoveToAttribute(int i) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool MoveToFirstAttribute();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool MoveToNextAttribute();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool MoveToElement();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool ReadAttributeValue();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool Read();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract bool get_EOF();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 35
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract ReadState get_ReadState();

	// RVA: 0x1FF1390 Offset: 0x1FF0590 VA: 0x181FF1390 Slot: 37
	public virtual void Skip() { }

	// RVA: -1 Offset: -1 Slot: 38
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract string LookupNamespace(string prefix);

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 40
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1 Offset: -1 Slot: 41
	public abstract void ResolveEntity();

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 42
	public virtual bool get_CanReadValueChunk() { }

	// RVA: 0x1FF1120 Offset: 0x1FF0320 VA: 0x181FF1120 Slot: 43
	public virtual int ReadValueChunk(char[] buffer, int index, int count) { }

	[EditorBrowsable(1)]
	// RVA: 0x1FF0EC0 Offset: 0x1FF00C0 VA: 0x181FF0EC0 Slot: 44
	public virtual string ReadString() { }

	// RVA: 0x1FF01B0 Offset: 0x1FEF3B0 VA: 0x181FF01B0 Slot: 45
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0x1FF0C20 Offset: 0x1FEFE20 VA: 0x181FF0C20 Slot: 46
	public virtual void ReadStartElement() { }

	// RVA: 0x1FF0D20 Offset: 0x1FEFF20 VA: 0x181FF0D20 Slot: 47
	public virtual void ReadStartElement(string name) { }

	[EditorBrowsable(1)]
	// RVA: 0x1FF0350 Offset: 0x1FEF550 VA: 0x181FF0350 Slot: 48
	public virtual string ReadElementString() { }

	// RVA: 0x1FF0600 Offset: 0x1FEF800 VA: 0x181FF0600 Slot: 49
	public virtual void ReadEndElement() { }

	// RVA: 0x1FEFFA0 Offset: 0x1FEF1A0 VA: 0x181FEFFA0 Slot: 50
	public virtual bool IsStartElement() { }

	// RVA: 0x1FEFFD0 Offset: 0x1FEF1D0 VA: 0x181FEFFD0 Slot: 51
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0x1FF0700 Offset: 0x1FEF900 VA: 0x181FF0700 Slot: 52
	public virtual string ReadInnerXml() { }

	// RVA: 0x1FF15C0 Offset: 0x1FF07C0 VA: 0x181FF15C0
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0x1FF14A0 Offset: 0x1FF06A0 VA: 0x181FF14A0
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0x1FEF660 Offset: 0x1FEE860 VA: 0x181FEF660
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0x1FF1180 Offset: 0x1FF0380 VA: 0x181FF1180
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0x1FF1B70 Offset: 0x1FF0D70 VA: 0x181FF1B70 Slot: 53
	public virtual bool get_HasAttributes() { }

	// RVA: 0x1FEFCA0 Offset: 0x1FEEEA0 VA: 0x181FEFCA0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1FEFCC0 Offset: 0x1FEEEC0 VA: 0x181FEFCC0 Slot: 54
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 55
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1FF0070 Offset: 0x1FEF270 VA: 0x181FF0070
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0x1FEEEB0 Offset: 0x1FEE0B0 VA: 0x181FEEEB0
	internal static bool CanReadContentAs(XmlNodeType nodeType) { }

	// RVA: 0x1FEFD00 Offset: 0x1FEEF00 VA: 0x181FEFD00
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0x1FF12A0 Offset: 0x1FF04A0 VA: 0x181FF12A0
	private bool SkipSubtree() { }

	// RVA: 0x1FEEFD0 Offset: 0x1FEE1D0 VA: 0x181FEEFD0
	internal Exception CreateReadContentAsException(string methodName) { }

	// RVA: 0x1FEEF20 Offset: 0x1FEE120 VA: 0x181FEEF20
	internal bool CanReadContentAs() { }

	// RVA: 0x1FEF070 Offset: 0x1FEE270 VA: 0x181FEF070
	internal static Exception CreateReadContentAsException(string methodName, XmlNodeType nodeType, IXmlLineInfo lineInfo) { }

	// RVA: 0x1FEECB0 Offset: 0x1FEDEB0 VA: 0x181FEECB0
	private static string AddLineInfo(string message, IXmlLineInfo lineInfo) { }

	// RVA: 0x1FEFD70 Offset: 0x1FEEF70 VA: 0x181FEFD70
	internal string InternalReadContentAsString() { }

	// RVA: 0x1FF1C50 Offset: 0x1FF0E50 VA: 0x181FF1C50
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 56
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0x1FEF7B0 Offset: 0x1FEE9B0 VA: 0x181FEF7B0
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1FEFAF0 Offset: 0x1FEECF0 VA: 0x181FEFAF0
	public static XmlReader Create(TextReader input) { }

	// RVA: 0x1FEF980 Offset: 0x1FEEB80 VA: 0x181FEF980
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1FEF2E0 Offset: 0x1FEE4E0 VA: 0x181FEF2E0
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0x1FEEE10 Offset: 0x1FEE010 VA: 0x181FEEE10
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x1FF1B00 Offset: 0x1FF0D00 VA: 0x181FF1B00
	private static void .cctor() { }
}

// Namespace: System.Xml
public sealed class XmlReaderSettings // TypeDefIndex: 11945
{
	// Fields
	private bool useAsync; // 0x10
	private XmlNameTable nameTable; // 0x18
	private XmlResolver xmlResolver; // 0x20
	private int lineNumberOffset; // 0x28
	private int linePositionOffset; // 0x2C
	private ConformanceLevel conformanceLevel; // 0x30
	private bool checkCharacters; // 0x34
	private long maxCharactersInDocument; // 0x38
	private long maxCharactersFromEntities; // 0x40
	private bool ignoreWhitespace; // 0x48
	private bool ignorePIs; // 0x49
	private bool ignoreComments; // 0x4A
	private DtdProcessing dtdProcessing; // 0x4C
	private ValidationType validationType; // 0x50
	private XmlSchemaValidationFlags validationFlags; // 0x54
	private XmlSchemaSet schemas; // 0x58
	private ValidationEventHandler valEventHandler; // 0x60
	private bool closeInput; // 0x68
	private bool isReadOnly; // 0x69
	[CompilerGenerated]
	private bool <IsXmlResolverSet>k__BackingField; // 0x6A
	private static Nullable<bool> s_enableLegacyXmlSettings; // 0x0

	// Properties
	public bool Async { get; set; }
	public XmlNameTable NameTable { get; set; }
	internal bool IsXmlResolverSet { get; set; }
	public XmlResolver XmlResolver { set; }
	public int LineNumberOffset { get; set; }
	public int LinePositionOffset { get; set; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; set; }
	public long MaxCharactersInDocument { get; set; }
	public long MaxCharactersFromEntities { get; set; }
	public bool IgnoreWhitespace { get; set; }
	public bool IgnoreProcessingInstructions { get; set; }
	public bool IgnoreComments { get; set; }
	public DtdProcessing DtdProcessing { get; set; }
	public bool CloseInput { get; set; }
	public ValidationType ValidationType { get; set; }
	public XmlSchemaValidationFlags ValidationFlags { get; set; }
	public XmlSchemaSet Schemas { get; set; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x1FEE440 Offset: 0x1FED640 VA: 0x181FEE440
	public void .ctor() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Async() { }

	// RVA: 0x1FEE570 Offset: 0x1FED770 VA: 0x181FEE570
	public void set_Async(bool value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1FEEA70 Offset: 0x1FEDC70 VA: 0x181FEEA70
	public void set_NameTable(XmlNameTable value) { }

	[CompilerGenerated]
	// RVA: 0x1C13490 Offset: 0x1C12690 VA: 0x181C13490
	internal bool get_IsXmlResolverSet() { }

	[CompilerGenerated]
	// RVA: 0x1C13500 Offset: 0x1C12700 VA: 0x181C13500
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0x1FEEC50 Offset: 0x1FEDE50 VA: 0x181FEEC50
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0x1FEE290 Offset: 0x1FED490 VA: 0x181FEE290
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_LineNumberOffset() { }

	// RVA: 0x1FEE890 Offset: 0x1FEDA90 VA: 0x181FEE890
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public int get_LinePositionOffset() { }

	// RVA: 0x1FEE8E0 Offset: 0x1FEDAE0 VA: 0x181FEE8E0
	public void set_LinePositionOffset(int value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x1FEE660 Offset: 0x1FED860 VA: 0x181FEE660
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	public bool get_CheckCharacters() { }

	// RVA: 0x1FEE5C0 Offset: 0x1FED7C0 VA: 0x181FEE5C0
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public long get_MaxCharactersInDocument() { }

	// RVA: 0x1FEE9D0 Offset: 0x1FEDBD0 VA: 0x181FEE9D0
	public void set_MaxCharactersInDocument(long value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public long get_MaxCharactersFromEntities() { }

	// RVA: 0x1FEE930 Offset: 0x1FEDB30 VA: 0x181FEE930
	public void set_MaxCharactersFromEntities(long value) { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_IgnoreWhitespace() { }

	// RVA: 0x1FEE840 Offset: 0x1FEDA40 VA: 0x181FEE840
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0x563E30 Offset: 0x563030 VA: 0x180563E30
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0x1FEE7F0 Offset: 0x1FED9F0 VA: 0x181FEE7F0
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0x190DBC0 Offset: 0x190CDC0 VA: 0x18190DBC0
	public bool get_IgnoreComments() { }

	// RVA: 0x1FEE7A0 Offset: 0x1FED9A0 VA: 0x181FEE7A0
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x547AA0 Offset: 0x546CA0 VA: 0x180547AA0
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0x1FEE700 Offset: 0x1FED900 VA: 0x181FEE700
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	public bool get_CloseInput() { }

	// RVA: 0x1FEE610 Offset: 0x1FED810 VA: 0x181FEE610
	public void set_CloseInput(bool value) { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public ValidationType get_ValidationType() { }

	// RVA: 0x1FEEBB0 Offset: 0x1FEDDB0 VA: 0x181FEEBB0
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x1FEEB10 Offset: 0x1FEDD10 VA: 0x181FEEB10
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0x1FEE500 Offset: 0x1FED700 VA: 0x181FEE500
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0x1FEEAC0 Offset: 0x1FEDCC0 VA: 0x181FEEAC0
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x1FEDDA0 Offset: 0x1FECFA0 VA: 0x181FEDDA0
	public XmlReaderSettings Clone() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1FEE010 Offset: 0x1FED210 VA: 0x181FEE010
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x1FEDEE0 Offset: 0x1FED0E0 VA: 0x181FEDEE0
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x1C13530 Offset: 0x1C12730 VA: 0x181C13530
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x1FEDCF0 Offset: 0x1FECEF0 VA: 0x181FEDCF0
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x1FEE380 Offset: 0x1FED580 VA: 0x181FEE380
	private void Initialize() { }

	// RVA: 0x1FEE2C0 Offset: 0x1FED4C0 VA: 0x181FEE2C0
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0x1FEDE00 Offset: 0x1FED000 VA: 0x181FEDE00
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x1FEDBB0 Offset: 0x1FECDB0 VA: 0x181FEDBB0
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0x1FEDE50 Offset: 0x1FED050 VA: 0x181FEDE50
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0x1FEE1C0 Offset: 0x1FED3C0 VA: 0x181FEE1C0
	internal static bool EnableLegacyXmlSettings() { }
}

// Namespace: System.Xml
public enum XmlSpace // TypeDefIndex: 11946
{
	// Fields
	public int value__; // 0x0
	public const XmlSpace None = 0;
	public const XmlSpace Default = 1;
	public const XmlSpace Preserve = 2;
}

// Namespace: System.Xml
internal class XmlTextEncoder // TypeDefIndex: 11947
{
	// Fields
	private TextWriter textWriter; // 0x10
	private bool inAttribute; // 0x18
	private char quoteChar; // 0x1A
	private StringBuilder attrValue; // 0x20
	private bool cacheAttrValue; // 0x28
	private XmlCharType xmlCharType; // 0x30

	// Properties
	internal char QuoteChar { set; }
	internal string AttributeValue { get; }

	// Methods

	// RVA: 0x1FF3530 Offset: 0x1FF2730 VA: 0x181FF3530
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0x1B4D470 Offset: 0x1B4C670 VA: 0x181B4D470
	internal void set_QuoteChar(char value) { }

	// RVA: 0x1FF1F20 Offset: 0x1FF1120 VA: 0x181FF1F20
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0x1FF1EE0 Offset: 0x1FF10E0 VA: 0x181FF1EE0
	internal void EndAttribute() { }

	// RVA: 0x1FF3570 Offset: 0x1FF2770 VA: 0x181FF3570
	internal string get_AttributeValue() { }

	// RVA: 0x1FF2920 Offset: 0x1FF1B20 VA: 0x181FF2920
	internal void WriteSurrogateChar(char lowChar, char highChar) { }

	// RVA: 0x1FF2F40 Offset: 0x1FF2140 VA: 0x181FF2F40
	internal void Write(char[] array, int offset, int count) { }

	// RVA: 0x1FF2790 Offset: 0x1FF1990 VA: 0x181FF2790
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1FF29F0 Offset: 0x1FF1BF0 VA: 0x181FF29F0
	internal void Write(string text) { }

	// RVA: 0x1FF2300 Offset: 0x1FF1500 VA: 0x181FF2300
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0x1FF2520 Offset: 0x1FF1720 VA: 0x181FF2520
	internal void WriteRaw(char[] array, int offset, int count) { }

	// RVA: 0x1FF20B0 Offset: 0x1FF12B0 VA: 0x181FF20B0
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x1FF2280 Offset: 0x1FF1480 VA: 0x181FF2280
	internal void WriteEntityRef(string name) { }

	// RVA: 0x1FF26E0 Offset: 0x1FF18E0 VA: 0x181FF26E0
	private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer) { }

	// RVA: 0x1FF1FA0 Offset: 0x1FF11A0 VA: 0x181FF1FA0
	private void WriteCharEntityImpl(char ch) { }

	// RVA: 0x1FF2010 Offset: 0x1FF1210 VA: 0x181FF2010
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0x1FF21F0 Offset: 0x1FF13F0 VA: 0x181FF21F0
	private void WriteEntityRefImpl(string name) { }
}

// Namespace: System.Xml
[EditorBrowsable(1)]
public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 11948
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Properties
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
	public int LineNumber { get; }
	public int LinePosition { get; }
	public bool Namespaces { get; }
	public bool Normalization { get; set; }
	public WhitespaceHandling WhitespaceHandling { set; }
	public EntityHandling EntityHandling { set; }
	public XmlResolver XmlResolver { set; }
	internal XmlTextReaderImpl Impl { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1FF3690 Offset: 0x1FF2890 VA: 0x181FF3690
	public void .ctor(Stream input) { }

	// RVA: 0x1FF3880 Offset: 0x1FF2A80 VA: 0x181FF3880
	public void .ctor(Stream input, XmlNameTable nt) { }

	// RVA: 0x1FF3930 Offset: 0x1FF2B30 VA: 0x181FF3930
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1FF37E0 Offset: 0x1FF29E0 VA: 0x181FF37E0
	public void .ctor(TextReader input) { }

	// RVA: 0x1FF3730 Offset: 0x1FF2930 VA: 0x181FF3730
	public void .ctor(TextReader input, XmlNameTable nt) { }

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

	// RVA: 0x1FF35E0 Offset: 0x1FF27E0 VA: 0x181FF35E0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x8D0650 Offset: 0x8CF850 VA: 0x1808D0650 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 42
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1FF3620 Offset: 0x1FF2820 VA: 0x181FF3620 Slot: 44
	public override string ReadString() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 57
	public bool HasLineInfo() { }

	// RVA: 0x1FF3A30 Offset: 0x1FF2C30 VA: 0x181FF3A30 Slot: 58
	public int get_LineNumber() { }

	// RVA: 0x1FF3A50 Offset: 0x1FF2C50 VA: 0x181FF3A50 Slot: 59
	public int get_LinePosition() { }

	// RVA: 0x1FF3650 Offset: 0x1FF2850 VA: 0x181FF3650 Slot: 60
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x17457D0 Offset: 0x17449D0 VA: 0x1817457D0 Slot: 61
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1FF3670 Offset: 0x1FF2870 VA: 0x181FF3670 Slot: 62
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1FDFC00 Offset: 0x1FDEE00 VA: 0x181FDFC00
	public bool get_Namespaces() { }

	// RVA: 0x1FDFC20 Offset: 0x1FDEE20 VA: 0x181FDFC20
	public bool get_Normalization() { }

	// RVA: 0x1FF3AC0 Offset: 0x1FF2CC0 VA: 0x181FF3AC0
	public void set_Normalization(bool value) { }

	// RVA: 0x1FF3AE0 Offset: 0x1FF2CE0 VA: 0x181FF3AE0
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1FF3AA0 Offset: 0x1FF2CA0 VA: 0x181FF3AA0
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1FF3B00 Offset: 0x1FF2D00 VA: 0x181FF3B00
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0x1FF3A70 Offset: 0x1FF2C70 VA: 0x181FF3A70 Slot: 55
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1FF3B20 Offset: 0x1FF2D20 VA: 0x181FF3B20
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x1FF3A00 Offset: 0x1FF2C00 VA: 0x181FF3A00 Slot: 56
	internal override IDtdInfo get_DtdInfo() { }
}

// Namespace: 
private enum XmlTextReaderImpl.ParsingFunction // TypeDefIndex: 11949
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.ParsingFunction ElementContent = 0;
	public const XmlTextReaderImpl.ParsingFunction NoData = 1;
	public const XmlTextReaderImpl.ParsingFunction OpenUrl = 2;
	public const XmlTextReaderImpl.ParsingFunction SwitchToInteractive = 3;
	public const XmlTextReaderImpl.ParsingFunction SwitchToInteractiveXmlDecl = 4;
	public const XmlTextReaderImpl.ParsingFunction DocumentContent = 5;
	public const XmlTextReaderImpl.ParsingFunction MoveToElementContent = 6;
	public const XmlTextReaderImpl.ParsingFunction PopElementContext = 7;
	public const XmlTextReaderImpl.ParsingFunction PopEmptyElementContext = 8;
	public const XmlTextReaderImpl.ParsingFunction ResetAttributesRootLevel = 9;
	public const XmlTextReaderImpl.ParsingFunction Error = 10;
	public const XmlTextReaderImpl.ParsingFunction Eof = 11;
	public const XmlTextReaderImpl.ParsingFunction ReaderClosed = 12;
	public const XmlTextReaderImpl.ParsingFunction EntityReference = 13;
	public const XmlTextReaderImpl.ParsingFunction InIncrementalRead = 14;
	public const XmlTextReaderImpl.ParsingFunction FragmentAttribute = 15;
	public const XmlTextReaderImpl.ParsingFunction ReportEndEntity = 16;
	public const XmlTextReaderImpl.ParsingFunction AfterResolveEntityInContent = 17;
	public const XmlTextReaderImpl.ParsingFunction AfterResolveEmptyEntityInContent = 18;
	public const XmlTextReaderImpl.ParsingFunction XmlDeclarationFragment = 19;
	public const XmlTextReaderImpl.ParsingFunction GoToEof = 20;
	public const XmlTextReaderImpl.ParsingFunction PartialTextValue = 21;
	public const XmlTextReaderImpl.ParsingFunction InReadAttributeValue = 22;
	public const XmlTextReaderImpl.ParsingFunction InReadValueChunk = 23;
	public const XmlTextReaderImpl.ParsingFunction InReadContentAsBinary = 24;
	public const XmlTextReaderImpl.ParsingFunction InReadElementContentAsBinary = 25;
}

// Namespace: 
private enum XmlTextReaderImpl.ParsingMode // TypeDefIndex: 11950
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.ParsingMode Full = 0;
	public const XmlTextReaderImpl.ParsingMode SkipNode = 1;
	public const XmlTextReaderImpl.ParsingMode SkipContent = 2;
}

// Namespace: 
private enum XmlTextReaderImpl.EntityType // TypeDefIndex: 11951
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.EntityType CharacterDec = 0;
	public const XmlTextReaderImpl.EntityType CharacterHex = 1;
	public const XmlTextReaderImpl.EntityType CharacterNamed = 2;
	public const XmlTextReaderImpl.EntityType Expanded = 3;
	public const XmlTextReaderImpl.EntityType Skipped = 4;
	public const XmlTextReaderImpl.EntityType FakeExpanded = 5;
	public const XmlTextReaderImpl.EntityType Unexpanded = 6;
	public const XmlTextReaderImpl.EntityType ExpandedInAttribute = 7;
}

// Namespace: 
private enum XmlTextReaderImpl.EntityExpandType // TypeDefIndex: 11952
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.EntityExpandType All = 0;
	public const XmlTextReaderImpl.EntityExpandType OnlyGeneral = 1;
	public const XmlTextReaderImpl.EntityExpandType OnlyCharacter = 2;
}

// Namespace: 
private enum XmlTextReaderImpl.IncrementalReadState // TypeDefIndex: 11953
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.IncrementalReadState Text = 0;
	public const XmlTextReaderImpl.IncrementalReadState StartTag = 1;
	public const XmlTextReaderImpl.IncrementalReadState PI = 2;
	public const XmlTextReaderImpl.IncrementalReadState CDATA = 3;
	public const XmlTextReaderImpl.IncrementalReadState Comment = 4;
	public const XmlTextReaderImpl.IncrementalReadState Attributes = 5;
	public const XmlTextReaderImpl.IncrementalReadState AttributeValue = 6;
	public const XmlTextReaderImpl.IncrementalReadState ReadData = 7;
	public const XmlTextReaderImpl.IncrementalReadState EndElement = 8;
	public const XmlTextReaderImpl.IncrementalReadState End = 9;
	public const XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnCachedValue = 10;
	public const XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnPartialValue = 11;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnCachedValue = 12;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnPartialValue = 13;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_End = 14;
}

// Namespace: 
private class XmlTextReaderImpl.LaterInitParam // TypeDefIndex: 11954
{
	// Fields
	public bool useAsync; // 0x10
	public Stream inputStream; // 0x18
	public byte[] inputBytes; // 0x20
	public int inputByteCount; // 0x28
	public Uri inputbaseUri; // 0x30
	public string inputUriStr; // 0x38
	public XmlResolver inputUriResolver; // 0x40
	public XmlParserContext inputContext; // 0x48
	public TextReader inputTextReader; // 0x50
	public XmlTextReaderImpl.InitInputType initType; // 0x58

	// Methods

	// RVA: 0x1FE0750 Offset: 0x1FDF950 VA: 0x181FE0750
	public void .ctor() { }
}

// Namespace: 
private enum XmlTextReaderImpl.InitInputType // TypeDefIndex: 11955
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.InitInputType UriString = 0;
	public const XmlTextReaderImpl.InitInputType Stream = 1;
	public const XmlTextReaderImpl.InitInputType TextReader = 2;
	public const XmlTextReaderImpl.InitInputType Invalid = 3;
}

// Namespace: 
private struct XmlTextReaderImpl.ParsingState // TypeDefIndex: 11956
{
	// Fields
	internal char[] chars; // 0x0
	internal int charPos; // 0x8
	internal int charsUsed; // 0xC
	internal Encoding encoding; // 0x10
	internal bool appendMode; // 0x18
	internal Stream stream; // 0x20
	internal Decoder decoder; // 0x28
	internal byte[] bytes; // 0x30
	internal int bytePos; // 0x38
	internal int bytesUsed; // 0x3C
	internal TextReader textReader; // 0x40
	internal int lineNo; // 0x48
	internal int lineStartPos; // 0x4C
	internal string baseUriStr; // 0x50
	internal Uri baseUri; // 0x58
	internal bool isEof; // 0x60
	internal bool isStreamEof; // 0x61
	internal IDtdEntityInfo entity; // 0x68
	internal int entityId; // 0x70
	internal bool eolNormalized; // 0x74
	internal bool entityResolvedManually; // 0x75

	// Properties
	internal int LineNo { get; }
	internal int LinePos { get; }

	// Methods

	// RVA: 0x1FE07E0 Offset: 0x1FDF9E0 VA: 0x181FE07E0
	internal void Clear() { }

	// RVA: 0x1FE0860 Offset: 0x1FDFA60 VA: 0x181FE0860
	internal void Close(bool closeInput) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	internal int get_LineNo() { }

	// RVA: 0x1FE08C0 Offset: 0x1FDFAC0 VA: 0x181FE08C0
	internal int get_LinePos() { }
}

// Namespace: 
private class XmlTextReaderImpl.XmlContext // TypeDefIndex: 11957
{
	// Fields
	internal XmlSpace xmlSpace; // 0x10
	internal string xmlLang; // 0x18
	internal string defaultNamespace; // 0x20
	internal XmlTextReaderImpl.XmlContext previousContext; // 0x28

	// Methods

	// RVA: 0x1FE61F0 Offset: 0x1FE53F0 VA: 0x181FE61F0
	internal void .ctor() { }

	// RVA: 0x1FE6260 Offset: 0x1FE5460 VA: 0x181FE6260
	internal void .ctor(XmlTextReaderImpl.XmlContext previousContext) { }
}

// Namespace: 
private class XmlTextReaderImpl.NoNamespaceManager : XmlNamespaceManager // TypeDefIndex: 11958
{
	// Properties
	public override string DefaultNamespace { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x1FE07A0 Offset: 0x1FDF9A0 VA: 0x181FE07A0 Slot: 9
	public override string get_DefaultNamespace() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	public override void PushScope() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public override bool PopScope() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public override void AddNamespace(string prefix, string uri) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	public override void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 14
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 15
	public override IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1FE0760 Offset: 0x1FDF960 VA: 0x181FE0760 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 17
	public override string LookupPrefix(string uri) { }
}

// Namespace: 
internal class XmlTextReaderImpl.DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 11959
{
	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Properties
	private XmlNameTable System.Xml.IDtdParserAdapter.NameTable { get; }
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver { get; }
	private Uri System.Xml.IDtdParserAdapter.BaseUri { get; }
	private bool System.Xml.IDtdParserAdapter.IsEof { get; }
	private char[] System.Xml.IDtdParserAdapter.ParsingBuffer { get; }
	private int System.Xml.IDtdParserAdapter.ParsingBufferLength { get; }
	private int System.Xml.IDtdParserAdapter.CurrentPosition { get; set; }
	private int System.Xml.IDtdParserAdapter.EntityStackLength { get; }
	private bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized { get; }
	private int System.Xml.IDtdParserAdapter.LineNo { get; }
	private int System.Xml.IDtdParserAdapter.LineStartPosition { get; }
	private bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation { get; }
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling { get; }
	private bool System.Xml.IDtdParserAdapterV1.Normalization { get; }
	private bool System.Xml.IDtdParserAdapterV1.Namespaces { get; }
	private bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x1FDFF40 Offset: 0x1FDF140 VA: 0x181FDFF40 Slot: 9
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x1FDFF60 Offset: 0x1FDF160 VA: 0x181FDFF60 Slot: 10
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x1FDFE60 Offset: 0x1FDF060 VA: 0x181FDFE60 Slot: 11
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x1FDFEE0 Offset: 0x1FDF0E0 VA: 0x181FDFEE0 Slot: 18
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x1FDFFA0 Offset: 0x1FDF1A0 VA: 0x181FDFFA0 Slot: 12
	private char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x1FDFF80 Offset: 0x1FDF180 VA: 0x181FDFF80 Slot: 13
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x1FDFE80 Offset: 0x1FDF080 VA: 0x181FDFE80 Slot: 14
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x1FDFFC0 Offset: 0x1FDF1C0 VA: 0x181FDFFC0 Slot: 15
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x1FDFEA0 Offset: 0x1FDF0A0 VA: 0x181FDFEA0 Slot: 19
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x1FDFEC0 Offset: 0x1FDF0C0 VA: 0x181FDFEC0 Slot: 20
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x1FDFCA0 Offset: 0x1FDEEA0 VA: 0x181FDFCA0 Slot: 22
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x1FDFF00 Offset: 0x1FDF100 VA: 0x181FDFF00 Slot: 16
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x1FDFF20 Offset: 0x1FDF120 VA: 0x181FDFF20 Slot: 17
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x1FDFE20 Offset: 0x1FDF020 VA: 0x181FDFE20 Slot: 21
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x1FDFD60 Offset: 0x1FDEF60 VA: 0x181FDFD60 Slot: 23
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1FDFD40 Offset: 0x1FDEF40 VA: 0x181FDFD40 Slot: 24
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1FDFD80 Offset: 0x1FDEF80 VA: 0x181FDFD80 Slot: 25
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x1FDFD20 Offset: 0x1FDEF20 VA: 0x181FDFD20 Slot: 26
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x1FDFDC0 Offset: 0x1FDEFC0 VA: 0x181FDFDC0 Slot: 27
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x1FDFDA0 Offset: 0x1FDEFA0 VA: 0x181FDFDA0 Slot: 28
	private bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x1FDFDE0 Offset: 0x1FDEFE0 VA: 0x181FDFDE0 Slot: 29
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1FDFE00 Offset: 0x1FDF000 VA: 0x181FDFE00 Slot: 30
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1FDFE40 Offset: 0x1FDF040 VA: 0x181FDFE40 Slot: 33
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x1FDFCF0 Offset: 0x1FDEEF0 VA: 0x181FDFCF0 Slot: 31
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1FDFCC0 Offset: 0x1FDEEC0 VA: 0x181FDFCC0 Slot: 32
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x1FDFC60 Offset: 0x1FDEE60 VA: 0x181FDFC60 Slot: 7
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x1FDFC80 Offset: 0x1FDEE80 VA: 0x181FDFC80 Slot: 8
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0x1FDFC20 Offset: 0x1FDEE20 VA: 0x181FDFC20 Slot: 5
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0x1FDFC00 Offset: 0x1FDEE00 VA: 0x181FDFC00 Slot: 6
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x1FDFC40 Offset: 0x1FDEE40 VA: 0x181FDFC40 Slot: 4
	private bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }
}

// Namespace: 
private class XmlTextReaderImpl.NodeData : IComparable // TypeDefIndex: 11960
{
	// Fields
	private static XmlTextReaderImpl.NodeData s_None; // 0x0
	internal XmlNodeType type; // 0x10
	internal string localName; // 0x18
	internal string prefix; // 0x20
	internal string ns; // 0x28
	internal string nameWPrefix; // 0x30
	private string value; // 0x38
	private char[] chars; // 0x40
	private int valueStartPos; // 0x48
	private int valueLength; // 0x4C
	internal LineInfo lineInfo; // 0x50
	internal LineInfo lineInfo2; // 0x58
	internal char quoteChar; // 0x60
	internal int depth; // 0x64
	private bool isEmptyOrDefault; // 0x68
	internal int entityId; // 0x6C
	internal bool xmlContextPushed; // 0x70
	internal XmlTextReaderImpl.NodeData nextAttrValueChunk; // 0x78
	internal object schemaType; // 0x80
	internal object typedValue; // 0x88

	// Properties
	internal static XmlTextReaderImpl.NodeData None { get; }
	internal int LineNo { get; }
	internal int LinePos { get; }
	internal bool IsEmptyElement { get; set; }
	internal bool IsDefaultAttribute { get; set; }
	internal bool ValueBuffered { get; }
	internal string StringValue { get; }

	// Methods

	// RVA: 0x1FF4A90 Offset: 0x1FF3C90 VA: 0x181FF4A90
	internal static XmlTextReaderImpl.NodeData get_None() { }

	// RVA: 0x1FF49E0 Offset: 0x1FF3BE0 VA: 0x181FF49E0
	internal void .ctor() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	internal int get_LineNo() { }

	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	internal int get_LinePos() { }

	// RVA: 0x1FF4A80 Offset: 0x1FF3C80 VA: 0x181FF4A80
	internal bool get_IsEmptyElement() { }

	// RVA: 0x563E60 Offset: 0x563060 VA: 0x180563E60
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x1FF4A70 Offset: 0x1FF3C70 VA: 0x181FF4A70
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0x563E60 Offset: 0x563060 VA: 0x180563E60
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0xBFD9D0 Offset: 0xBFCBD0 VA: 0x180BFD9D0
	internal bool get_ValueBuffered() { }

	// RVA: 0x1FF4BA0 Offset: 0x1FF3DA0 VA: 0x181FF4BA0
	internal string get_StringValue() { }

	// RVA: 0x1FF49A0 Offset: 0x1FF3BA0 VA: 0x181FF49A0
	internal void TrimSpacesInValue() { }

	// RVA: 0x1FF4350 Offset: 0x1FF3550 VA: 0x181FF4350
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x1FF42D0 Offset: 0x1FF34D0 VA: 0x181FF42D0
	internal void ClearName() { }

	// RVA: 0x1FF4670 Offset: 0x1FF3870 VA: 0x181FF4670
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1FF4660 Offset: 0x1FF3860 VA: 0x181FF4660
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x1FF47E0 Offset: 0x1FF39E0 VA: 0x181FF47E0
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x1FF4810 Offset: 0x1FF3A10 VA: 0x181FF4810
	internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len) { }

	// RVA: 0x1FF4680 Offset: 0x1FF3880 VA: 0x181FF4680
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x1FF4740 Offset: 0x1FF3940 VA: 0x181FF4740
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1FF4860 Offset: 0x1FF3A60 VA: 0x181FF4860
	internal void SetValue(string value) { }

	// RVA: 0x1FF4870 Offset: 0x1FF3A70 VA: 0x181FF4870
	internal void SetValue(char[] chars, int startPos, int len) { }

	// RVA: 0x1FF4610 Offset: 0x1FF3810 VA: 0x181FF4610
	internal void OnBufferInvalidated() { }

	// RVA: 0x1FF4450 Offset: 0x1FF3650 VA: 0x181FF4450
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x1FF43E0 Offset: 0x1FF35E0 VA: 0x181FF43E0
	internal int CopyTo(int valueOffset, char[] buffer, int offset, int length) { }

	// RVA: 0x1FF4570 Offset: 0x1FF3770 VA: 0x181FF4570
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1FF44E0 Offset: 0x1FF36E0 VA: 0x181FF44E0
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1FF4890 Offset: 0x1FF3A90 VA: 0x181FF4890 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }
}

// Namespace: 
private class XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object> // TypeDefIndex: 11961
{
	// Fields
	private static IComparer<object> s_instance; // 0x0

	// Properties
	internal static IComparer<object> Instance { get; }

	// Methods

	// RVA: 0x1FF4260 Offset: 0x1FF3460 VA: 0x181FF4260
	internal static IComparer<object> get_Instance() { }

	// RVA: 0x1FF3F50 Offset: 0x1FF3150 VA: 0x181FF3F50 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1FF4200 Offset: 0x1FF3400 VA: 0x181FF4200
	private static void .cctor() { }
}

// Namespace: 
internal sealed class XmlTextReaderImpl.OnDefaultAttributeUseDelegate : MulticastDelegate // TypeDefIndex: 11962
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }
}

// Namespace: System.Xml
internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 11963
{
	// Fields
	private readonly bool useAsync; // 0x10
	private XmlTextReaderImpl.LaterInitParam laterInitParam; // 0x18
	private XmlCharType xmlCharType; // 0x20
	private XmlTextReaderImpl.ParsingState ps; // 0x28
	private XmlTextReaderImpl.ParsingFunction parsingFunction; // 0xA0
	private XmlTextReaderImpl.ParsingFunction nextParsingFunction; // 0xA4
	private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction; // 0xA8
	private XmlTextReaderImpl.NodeData[] nodes; // 0xB0
	private XmlTextReaderImpl.NodeData curNode; // 0xB8
	private int index; // 0xC0
	private int curAttrIndex; // 0xC4
	private int attrCount; // 0xC8
	private int attrHashtable; // 0xCC
	private int attrDuplWalkCount; // 0xD0
	private bool attrNeedNamespaceLookup; // 0xD4
	private bool fullAttrCleanup; // 0xD5
	private XmlTextReaderImpl.NodeData[] attrDuplSortingArray; // 0xD8
	private XmlNameTable nameTable; // 0xE0
	private bool nameTableFromSettings; // 0xE8
	private XmlResolver xmlResolver; // 0xF0
	private string url; // 0xF8
	private bool normalize; // 0x100
	private bool supportNamespaces; // 0x101
	private WhitespaceHandling whitespaceHandling; // 0x104
	private DtdProcessing dtdProcessing; // 0x108
	private EntityHandling entityHandling; // 0x10C
	private bool ignorePIs; // 0x110
	private bool ignoreComments; // 0x111
	private bool checkCharacters; // 0x112
	private int lineNumberOffset; // 0x114
	private int linePositionOffset; // 0x118
	private bool closeInput; // 0x11C
	private long maxCharactersInDocument; // 0x120
	private long maxCharactersFromEntities; // 0x128
	private bool v1Compat; // 0x130
	private XmlNamespaceManager namespaceManager; // 0x138
	private string lastPrefix; // 0x140
	private XmlTextReaderImpl.XmlContext xmlContext; // 0x148
	private XmlTextReaderImpl.ParsingState[] parsingStatesStack; // 0x150
	private int parsingStatesStackTop; // 0x158
	private string reportedBaseUri; // 0x160
	private Encoding reportedEncoding; // 0x168
	private IDtdInfo dtdInfo; // 0x170
	private XmlNodeType fragmentType; // 0x178
	private XmlParserContext fragmentParserContext; // 0x180
	private bool fragment; // 0x188
	private IncrementalReadDecoder incReadDecoder; // 0x190
	private XmlTextReaderImpl.IncrementalReadState incReadState; // 0x198
	private LineInfo incReadLineInfo; // 0x19C
	private int incReadDepth; // 0x1A4
	private int incReadLeftStartPos; // 0x1A8
	private int incReadLeftEndPos; // 0x1AC
	private int attributeValueBaseEntityId; // 0x1B0
	private bool emptyEntityInAttributeResolved; // 0x1B4
	private IValidationEventHandling validationEventHandling; // 0x1B8
	private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse; // 0x1C0
	private bool validatingReaderCompatFlag; // 0x1C8
	private bool addDefaultAttributesAndNormalize; // 0x1C9
	private StringBuilder stringBuilder; // 0x1D0
	private bool rootElementParsed; // 0x1D8
	private bool standalone; // 0x1D9
	private int nextEntityId; // 0x1DC
	private XmlTextReaderImpl.ParsingMode parsingMode; // 0x1E0
	private ReadState readState; // 0x1E4
	private IDtdEntityInfo lastEntity; // 0x1E8
	private bool afterResetState; // 0x1F0
	private int documentStartBytePos; // 0x1F4
	private int readValueOffset; // 0x1F8
	private long charactersInDocument; // 0x200
	private long charactersFromEntities; // 0x208
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; // 0x210
	private bool disableUndeclaredEntityCheck; // 0x218
	private XmlReader outerReader; // 0x220
	private bool xmlResolverIsSet; // 0x228
	private string Xml; // 0x230
	private string XmlNs; // 0x238
	private Task<Tuple<int, int, int, bool>> parseText_dummyTask; // 0x240

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override int AttributeCount { get; }
	internal XmlReader OuterReader { set; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal bool Namespaces { get; set; }
	internal bool Normalization { get; set; }
	internal WhitespaceHandling WhitespaceHandling { set; }
	internal EntityHandling EntityHandling { set; }
	internal bool IsResolverSet { get; }
	internal XmlResolver XmlResolver { set; }
	internal XmlNameTable DtdParserProxy_NameTable { get; }
	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver { get; }
	internal bool DtdParserProxy_DtdValidation { get; }
	internal bool DtdParserProxy_Normalization { get; }
	internal bool DtdParserProxy_Namespaces { get; }
	internal bool DtdParserProxy_V1CompatibilityMode { get; }
	internal Uri DtdParserProxy_BaseUri { get; }
	internal bool DtdParserProxy_IsEof { get; }
	internal char[] DtdParserProxy_ParsingBuffer { get; }
	internal int DtdParserProxy_ParsingBufferLength { get; }
	internal int DtdParserProxy_CurrentPosition { get; set; }
	internal int DtdParserProxy_EntityStackLength { get; }
	internal bool DtdParserProxy_IsEntityEolNormalized { get; }
	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling { get; }
	internal int DtdParserProxy_LineNo { get; }
	internal int DtdParserProxy_LineStartPosition { get; }
	private bool IsResolverNull { get; }
	private bool InAttributeValueIterator { get; }
	private bool DtdValidation { get; }
	private bool InEntity { get; }
	internal override IDtdInfo DtdInfo { get; }
	internal IValidationEventHandling ValidationEventHandling { set; }
	internal XmlTextReaderImpl.OnDefaultAttributeUseDelegate OnDefaultAttributeUse { set; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal XmlNodeType FragmentType { get; }
	internal object InternalSchemaType { set; }
	internal object InternalTypedValue { get; set; }
	internal bool StandAlone { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool V1Compat { get; }
	internal bool DisableUndeclaredEntityCheck { set; }

	// Methods

	// RVA: 0x1F07D70 Offset: 0x1F06F70 VA: 0x181F07D70
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0x1F082F0 Offset: 0x1F074F0 VA: 0x181F082F0
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0x1F07AE0 Offset: 0x1F06CE0 VA: 0x181F07AE0
	internal void .ctor(Stream input) { }

	// RVA: 0x1F08140 Offset: 0x1F07340 VA: 0x181F08140
	internal void .ctor(Stream input, XmlNameTable nt) { }

	// RVA: 0x1F08910 Offset: 0x1F07B10 VA: 0x181F08910
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1F087E0 Offset: 0x1F079E0 VA: 0x181F087E0
	internal void .ctor(TextReader input) { }

	// RVA: 0x1F07B80 Offset: 0x1F06D80 VA: 0x181F07B80
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x1F07C90 Offset: 0x1F06E90 VA: 0x181F07C90
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0x1F078B0 Offset: 0x1F06AB0 VA: 0x181F078B0
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0x1F081B0 Offset: 0x1F073B0 VA: 0x181F081B0
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0x1EF7790 Offset: 0x1EF6990 VA: 0x181EF7790
	private void FinishInitUriString() { }

	// RVA: 0x1F08AE0 Offset: 0x1F07CE0 VA: 0x181F08AE0
	internal void .ctor(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0x1EF7640 Offset: 0x1EF6840 VA: 0x181EF7640
	private void FinishInitStream() { }

	// RVA: 0x1F079D0 Offset: 0x1F06BD0 VA: 0x181F079D0
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0x1EF7700 Offset: 0x1EF6900 VA: 0x181EF7700
	private void FinishInitTextReader() { }

	// RVA: 0x1F08A20 Offset: 0x1F07C20 VA: 0x181F08A20
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x1F09100 Offset: 0x1F08300 VA: 0x181F09100 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1F09080 Offset: 0x1F08280 VA: 0x181F09080 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1F09030 Offset: 0x1F08230 VA: 0x181F09030 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1F09010 Offset: 0x1F08210 VA: 0x181F09010 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1F09060 Offset: 0x1F08260 VA: 0x181F09060 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1F090A0 Offset: 0x1F082A0 VA: 0x181F090A0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1F092A0 Offset: 0x1F084A0 VA: 0x181F092A0 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1F08D90 Offset: 0x1F07F90 VA: 0x181F08D90 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x794CE0 Offset: 0x793EE0 VA: 0x180794CE0 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x1F08F30 Offset: 0x1F08130 VA: 0x181F08F30 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1F08F00 Offset: 0x1F08100 VA: 0x181F08F00 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x1F090C0 Offset: 0x1F082C0 VA: 0x181F090C0 Slot: 17
	public override char get_QuoteChar() { }

	// RVA: 0x1F09430 Offset: 0x1F08630 VA: 0x181F09430 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1F09410 Offset: 0x1F08610 VA: 0x181F09410 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x1F090F0 Offset: 0x1F082F0 VA: 0x181F090F0 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1F08E90 Offset: 0x1F08090 VA: 0x181F08E90 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x170E920 Offset: 0x170DB20 VA: 0x18170E920 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1EF81C0 Offset: 0x1EF73C0 VA: 0x181EF81C0 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1EF8250 Offset: 0x1EF7450 VA: 0x181EF8250 Slot: 25
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1EF8110 Offset: 0x1EF7310 VA: 0x181EF8110 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1EFA6D0 Offset: 0x1EF98D0 VA: 0x181EFA6D0 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1EFA790 Offset: 0x1EF9990 VA: 0x181EFA790 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1EFA8E0 Offset: 0x1EF9AE0 VA: 0x181EFA8E0 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1EFA960 Offset: 0x1EF9B60 VA: 0x181EFA960 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1EFA860 Offset: 0x1EF9A60 VA: 0x181EFA860 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1EF7B40 Offset: 0x1EF6D40 VA: 0x181EF7B40
	private void FinishInit() { }

	// RVA: 0x1F042C0 Offset: 0x1F034C0 VA: 0x181F042C0 Slot: 33
	public override bool Read() { }

	// RVA: 0x1EF64A0 Offset: 0x1EF56A0 VA: 0x181EF64A0 Slot: 35
	public override void Close() { }

	// RVA: 0x1F061A0 Offset: 0x1F053A0 VA: 0x181F061A0 Slot: 37
	public override void Skip() { }

	// RVA: 0x1EFA4B0 Offset: 0x1EF96B0 VA: 0x181EFA4B0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1F03510 Offset: 0x1F02710 VA: 0x181F03510 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x1F04D40 Offset: 0x1F03F40 VA: 0x181F04D40 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1C61D90 Offset: 0x1C60F90 VA: 0x181C61D90
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0x1EFA600 Offset: 0x1EF9800 VA: 0x181EFA600
	internal void MoveOffEntityReference() { }

	// RVA: 0x1F03CC0 Offset: 0x1F02EC0 VA: 0x181F03CC0 Slot: 44
	public override string ReadString() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 42
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1F03D90 Offset: 0x1F02F90 VA: 0x181F03D90 Slot: 43
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 57
	public bool HasLineInfo() { }

	// RVA: 0x1F08FB0 Offset: 0x1F081B0 VA: 0x181F08FB0 Slot: 58
	public int get_LineNumber() { }

	// RVA: 0x1F08FE0 Offset: 0x1F081E0 VA: 0x181F08FE0 Slot: 59
	public int get_LinePosition() { }

	// RVA: 0x1EF86F0 Offset: 0x1EF78F0 VA: 0x181EF86F0 Slot: 60
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBD4BE0 Offset: 0xBD3DE0 VA: 0x180BD4BE0 Slot: 61
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1EFA5D0 Offset: 0x1EF97D0 VA: 0x181EFA5D0 Slot: 62
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1EF86F0 Offset: 0x1EF78F0 VA: 0x181EF86F0
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1EFA5D0 Offset: 0x1EF97D0 VA: 0x181EFA5D0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1F08E80 Offset: 0x1F08080 VA: 0x181F08E80
	internal bool get_Namespaces() { }

	// RVA: 0x1F09540 Offset: 0x1F08740 VA: 0x181F09540
	internal void set_Namespaces(bool value) { }

	// RVA: 0x1864140 Offset: 0x1863340 VA: 0x181864140
	internal bool get_Normalization() { }

	// RVA: 0x1F097A0 Offset: 0x1F089A0 VA: 0x181F097A0
	internal void set_Normalization(bool value) { }

	// RVA: 0x1F09880 Offset: 0x1F08A80 VA: 0x181F09880
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1F09450 Offset: 0x1F08650 VA: 0x181F09450
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1F08FA0 Offset: 0x1F081A0 VA: 0x181F08FA0
	internal bool get_IsResolverSet() { }

	// RVA: 0x1F09970 Offset: 0x1F08B70 VA: 0x181F09970
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0x794CA0 Offset: 0x793EA0 VA: 0x180794CA0
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0x1F08E60 Offset: 0x1F08060 VA: 0x181F08E60
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0x1864140 Offset: 0x1863340 VA: 0x181864140
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0x1F08E80 Offset: 0x1F08080 VA: 0x181F08E80
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0x19BF270 Offset: 0x19BE470 VA: 0x1819BF270
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0x1F08DB0 Offset: 0x1F07FB0 VA: 0x181F08DB0
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x5C3440 Offset: 0x5C2640 VA: 0x1805C3440
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0x1F08E70 Offset: 0x1F08070 VA: 0x181F08E70
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0x1B33AF0 Offset: 0x1B32CF0 VA: 0x181B33AF0
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x6ED540 Offset: 0x6EC740 VA: 0x1806ED540
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0x1EF6780 Offset: 0x1EF5980 VA: 0x181EF6780
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0x1EF71B0 Offset: 0x1EF63B0 VA: 0x181EF71B0
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0x1EF6D10 Offset: 0x1EF5F10 VA: 0x181EF6D10
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1EF6D00 Offset: 0x1EF5F00 VA: 0x181EF6D00
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1EF6DC0 Offset: 0x1EF5FC0 VA: 0x181EF6DC0
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0x1EF6970 Offset: 0x1EF5B70 VA: 0x181EF6970
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0x1F08F60 Offset: 0x1F08160 VA: 0x181F08F60
	private bool get_IsResolverNull() { }

	// RVA: 0x1EF8760 Offset: 0x1EF7960 VA: 0x181EF8760
	private XmlResolver GetTempResolver() { }

	// RVA: 0x1EF6E70 Offset: 0x1EF6070 VA: 0x181EF6E70
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x1EF6E10 Offset: 0x1EF6010 VA: 0x181EF6E10
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x1EF6F40 Offset: 0x1EF6140 VA: 0x181EF6F40
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1EF70A0 Offset: 0x1EF62A0 VA: 0x181EF70A0
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1EF71C0 Offset: 0x1EF63C0 VA: 0x181EF71C0
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0x1EF6880 Offset: 0x1EF5A80 VA: 0x181EF6880
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1EF6790 Offset: 0x1EF5990 VA: 0x181EF6790
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x1F07470 Offset: 0x1F06670 VA: 0x181F07470
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0x1F07570 Offset: 0x1F06770 VA: 0x181F07570
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0x1F072B0 Offset: 0x1F064B0 VA: 0x181F072B0
	private void Throw(int pos, string res) { }

	// RVA: 0x1F07490 Offset: 0x1F06690 VA: 0x181F07490
	private void Throw(string res) { }

	// RVA: 0x1F07200 Offset: 0x1F06400 VA: 0x181F07200
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0x1F07310 Offset: 0x1F06510 VA: 0x181F07310
	private void Throw(string res, string arg) { }

	// RVA: 0x1F074E0 Offset: 0x1F066E0 VA: 0x181F074E0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x1F07150 Offset: 0x1F06350 VA: 0x181F07150
	private void Throw(string res, string[] args) { }

	// RVA: 0x1F070C0 Offset: 0x1F062C0 VA: 0x181F070C0
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0x1F07590 Offset: 0x1F06790 VA: 0x181F07590
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0x1F073C0 Offset: 0x1F065C0 VA: 0x181F073C0
	private void Throw(Exception e) { }

	// RVA: 0x1F03470 Offset: 0x1F02670 VA: 0x181F03470
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0x1F07020 Offset: 0x1F06220 VA: 0x181F07020
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0x1F06F10 Offset: 0x1F06110 VA: 0x181F06F10
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0x1F06F90 Offset: 0x1F06190 VA: 0x181F06F90
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0x1F06950 Offset: 0x1F05B50 VA: 0x181F06950
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x1F052D0 Offset: 0x1F044D0 VA: 0x181F052D0
	private void SetErrorState() { }

	// RVA: 0x1F050E0 Offset: 0x1F042E0 VA: 0x181F050E0
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0x1F05000 Offset: 0x1F04200 VA: 0x181F05000
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0x1F08EA0 Offset: 0x1F080A0 VA: 0x181F08EA0
	private bool get_InAttributeValueIterator() { }

	// RVA: 0x1EF7480 Offset: 0x1EF6680 VA: 0x181EF7480
	private void FinishAttributeValueIterator() { }

	// RVA: 0x1F08E60 Offset: 0x1F08060 VA: 0x181F08E60
	private bool get_DtdValidation() { }

	// RVA: 0x1EFA010 Offset: 0x1EF9210 VA: 0x181EFA010
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0x1EFA110 Offset: 0x1EF9310 VA: 0x181EFA110
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1EFA090 Offset: 0x1EF9290 VA: 0x181EFA090
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0x1EFA140 Offset: 0x1EF9340 VA: 0x181EFA140
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1EF9DB0 Offset: 0x1EF8FB0 VA: 0x181EF9DB0
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x1EFA260 Offset: 0x1EF9460 VA: 0x181EFA260
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0x1EFA280 Offset: 0x1EF9480 VA: 0x181EFA280
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0x1EFA170 Offset: 0x1EF9370 VA: 0x181EFA170
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0x1EF9B60 Offset: 0x1EF8D60 VA: 0x181EF9B60
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0x1F02B50 Offset: 0x1F01D50 VA: 0x181F02B50
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0x1EFB490 Offset: 0x1EFA690 VA: 0x181EFB490
	private void OpenUrl() { }

	// RVA: 0x1EFB2D0 Offset: 0x1EFA4D0 VA: 0x181EFB2D0
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0x1EF6580 Offset: 0x1EF5780 VA: 0x181EF6580
	private Encoding DetectEncoding() { }

	// RVA: 0x1F052F0 Offset: 0x1F044F0 VA: 0x181F052F0
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0x1F06720 Offset: 0x1F05920 VA: 0x181F06720
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0x1EF6070 Offset: 0x1EF5270 VA: 0x181EF6070
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0x1F07640 Offset: 0x1F06840 VA: 0x181F07640
	private void UnDecodeChars() { }

	// RVA: 0x1F066B0 Offset: 0x1F058B0 VA: 0x181F066B0
	private void SwitchEncodingToUTF8() { }

	// RVA: 0x1F03850 Offset: 0x1F02A50 VA: 0x181F03850
	private int ReadData() { }

	// RVA: 0x1EF8410 Offset: 0x1EF7610 VA: 0x181EF8410
	private int GetChars(int maxCharsCount) { }

	// RVA: 0x1EFA340 Offset: 0x1EF9540 VA: 0x181EFA340
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	// RVA: 0x1EF63C0 Offset: 0x1EF55C0 VA: 0x181EF63C0
	internal void Close(bool closeInput) { }

	// RVA: 0x1F05850 Offset: 0x1F04A50 VA: 0x181F05850
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0x1F01840 Offset: 0x1F00A40 VA: 0x181F01840
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0x1EFD940 Offset: 0x1EFCB40 VA: 0x181EFD940
	private bool ParseDocumentContent() { }

	// RVA: 0x1EFE370 Offset: 0x1EFD570 VA: 0x181EFE370
	private bool ParseElementContent() { }

	// RVA: 0x1F06B90 Offset: 0x1F05D90 VA: 0x181F06B90
	private void ThrowUnclosedElements() { }

	// RVA: 0x1EFE6F0 Offset: 0x1EFD8F0 VA: 0x181EFE6F0
	private void ParseElement() { }

	// RVA: 0x1EF4FE0 Offset: 0x1EF41E0 VA: 0x181EF4FE0
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0x1EFEC60 Offset: 0x1EFDE60 VA: 0x181EFEC60
	private void ParseEndElement() { }

	// RVA: 0x1F069C0 Offset: 0x1F05BC0 VA: 0x181F069C0
	private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag) { }

	// RVA: 0x1EFC760 Offset: 0x1EFB960 VA: 0x181EFC760
	private void ParseAttributes() { }

	// RVA: 0x1EF7410 Offset: 0x1EF6610 VA: 0x181EF7410
	private void ElementNamespaceLookup() { }

	// RVA: 0x1EF5F80 Offset: 0x1EF5180 VA: 0x181EF5F80
	private void AttributeNamespaceLookup() { }

	// RVA: 0x1EF5B70 Offset: 0x1EF4D70 VA: 0x181EF5B70
	private void AttributeDuplCheck() { }

	// RVA: 0x1EFAB00 Offset: 0x1EF9D00 VA: 0x181EFAB00
	private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1EFACE0 Offset: 0x1EF9EE0 VA: 0x181EFACE0
	private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1EFADD0 Offset: 0x1EF9FD0 VA: 0x181EFADD0
	private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1EFBD90 Offset: 0x1EFAF90 VA: 0x181EFBD90
	private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1EF4100 Offset: 0x1EF3300 VA: 0x181EF4100
	private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk) { }

	// RVA: 0x1F00B20 Offset: 0x1EFFD20 VA: 0x181F00B20
	private bool ParseText() { }

	// RVA: 0x1F00FB0 Offset: 0x1F001B0 VA: 0x181F00FB0
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	// RVA: 0x1EF7CD0 Offset: 0x1EF6ED0 VA: 0x181EF7CD0
	private void FinishPartialValue() { }

	// RVA: 0x1EF7B90 Offset: 0x1EF6D90 VA: 0x181EF7B90
	private void FinishOtherValueIterator() { }

	// RVA: 0x1F05C20 Offset: 0x1F04E20 VA: 0x181F05C20
	private void SkipPartialTextValue() { }

	// RVA: 0x1EF8040 Offset: 0x1EF7240 VA: 0x181EF8040
	private void FinishReadValueChunk() { }

	// RVA: 0x1EF7E10 Offset: 0x1EF7010 VA: 0x181EF7E10
	private void FinishReadContentAsBinary() { }

	// RVA: 0x1EF7F70 Offset: 0x1EF7170 VA: 0x181EF7F70
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0x1F008D0 Offset: 0x1EFFAD0 VA: 0x181F008D0
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0x1EFF140 Offset: 0x1EFE340 VA: 0x181EFF140
	private void ParseEntityReference() { }

	// RVA: 0x1EF89E0 Offset: 0x1EF7BE0 VA: 0x181EF89E0
	private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos) { }

	// RVA: 0x1EF8C50 Offset: 0x1EF7E50 VA: 0x181EF8C50
	private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0x1F08EC0 Offset: 0x1F080C0 VA: 0x181F08EC0
	private bool get_InEntity() { }

	// RVA: 0x1EF8870 Offset: 0x1EF7A70 VA: 0x181EF8870
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0x1F054B0 Offset: 0x1F046B0 VA: 0x181F054B0
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0x1F05440 Offset: 0x1F04640 VA: 0x181F05440
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0x1F00620 Offset: 0x1EFF820 VA: 0x181F00620
	private bool ParsePI() { }

	// RVA: 0x1F00220 Offset: 0x1EFF420 VA: 0x181F00220
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0x1EFFEA0 Offset: 0x1EFF0A0 VA: 0x181EFFEA0
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	// RVA: 0x1EFD440 Offset: 0x1EFC640 VA: 0x181EFD440
	private bool ParseComment() { }

	// RVA: 0x1EFD3B0 Offset: 0x1EFC5B0 VA: 0x181EFD3B0
	private void ParseCData() { }

	// RVA: 0x1EFD1F0 Offset: 0x1EFC3F0 VA: 0x181EFD1F0
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0x1EFCDC0 Offset: 0x1EFBFC0 VA: 0x181EFCDC0
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	// RVA: 0x1EFD670 Offset: 0x1EFC870 VA: 0x181EFD670
	private bool ParseDoctypeDecl() { }

	// RVA: 0x1EFE0C0 Offset: 0x1EFD2C0 VA: 0x181EFE0C0
	private void ParseDtd() { }

	// RVA: 0x1F05880 Offset: 0x1F04A80 VA: 0x181F05880
	private void SkipDtd() { }

	// RVA: 0x1F05C80 Offset: 0x1F04E80 VA: 0x181F05C80
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0x1F05D10 Offset: 0x1F04F10 VA: 0x181F05D10
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	// RVA: 0x1EF71D0 Offset: 0x1EF63D0 VA: 0x181EF71D0
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0x1EFD3C0 Offset: 0x1EFC5C0 VA: 0x181EFD3C0
	private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1EFFDD0 Offset: 0x1EFEFD0 VA: 0x181EFFDD0
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1EFF620 Offset: 0x1EFE820 VA: 0x181EFF620
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1EFF5A0 Offset: 0x1EFE7A0 VA: 0x181EFF5A0
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1EFF290 Offset: 0x1EFE490 VA: 0x181EFF290
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1EFF260 Offset: 0x1EFE460 VA: 0x181EFF260
	private int ParseName() { }

	// RVA: 0x1F008B0 Offset: 0x1EFFAB0 VA: 0x181F008B0
	private int ParseQName(out int colonPos) { }

	// RVA: 0x1F00630 Offset: 0x1EFF830 VA: 0x181F00630
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	// RVA: 0x1F03810 Offset: 0x1F02A10 VA: 0x181F03810
	private bool ReadDataInName(ref int pos) { }

	// RVA: 0x1EFF050 Offset: 0x1EFE250 VA: 0x181EFF050
	private string ParseEntityName() { }

	// RVA: 0x1EF5880 Offset: 0x1EF4A80 VA: 0x181EF5880
	private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1EF5A10 Offset: 0x1EF4C10 VA: 0x181EF5A10
	private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1EF4130 Offset: 0x1EF3330 VA: 0x181EF4130
	private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0x1EF41C0 Offset: 0x1EF33C0 VA: 0x181EF41C0
	private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0x1EF43D0 Offset: 0x1EF35D0 VA: 0x181EF43D0
	private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1F02940 Offset: 0x1F01B40 VA: 0x181F02940
	private void PopElementContext() { }

	// RVA: 0x1EF6780 Offset: 0x1EF5980 VA: 0x181EF6780
	private void OnNewLine(int pos) { }

	// RVA: 0x1EFAC30 Offset: 0x1EF9E30 VA: 0x181EFAC30
	private void OnEof() { }

	// RVA: 0x1EFA4F0 Offset: 0x1EF96F0 VA: 0x181EFA4F0
	private string LookupNamespace(XmlTextReaderImpl.NodeData node) { }

	// RVA: 0x1EF5610 Offset: 0x1EF4810 VA: 0x181EF5610
	private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1F04C90 Offset: 0x1F03E90 VA: 0x181F04C90
	private void ResetAttributes() { }

	// RVA: 0x1EF8080 Offset: 0x1EF7280 VA: 0x181EF8080
	private void FullAttributeCleanup() { }

	// RVA: 0x1F033F0 Offset: 0x1F025F0 VA: 0x181F033F0
	private void PushXmlContext() { }

	// RVA: 0x1F02B10 Offset: 0x1F01D10 VA: 0x181F02B10
	private void PopXmlContext() { }

	// RVA: 0x1EF8820 Offset: 0x1EF7A20 VA: 0x181EF8820
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0x1EF87C0 Offset: 0x1EF79C0 VA: 0x181EF87C0
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0x1F02BC0 Offset: 0x1F01DC0 VA: 0x181F02BC0
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0x1EFAFF0 Offset: 0x1EFA1F0 VA: 0x181EFAFF0
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0x1F02F00 Offset: 0x1F02100 VA: 0x181F02F00
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1F03110 Offset: 0x1F02310 VA: 0x181F03110
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1F029B0 Offset: 0x1F01BB0 VA: 0x181F029B0
	private void PopEntity() { }

	// RVA: 0x1F04A80 Offset: 0x1F03C80 VA: 0x181F04A80
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1F076F0 Offset: 0x1F068F0 VA: 0x181F076F0
	private void UnregisterEntity() { }

	// RVA: 0x1F03280 Offset: 0x1F02480 VA: 0x181F03280
	private void PushParsingState() { }

	// RVA: 0x1F02A50 Offset: 0x1F01C50 VA: 0x181F02A50
	private void PopParsingState() { }

	// RVA: 0x1EF90F0 Offset: 0x1EF82F0 VA: 0x181EF90F0
	private int IncrementalRead() { }

	// RVA: 0x1EF75D0 Offset: 0x1EF67D0 VA: 0x181EF75D0
	private void FinishIncrementalRead() { }

	// RVA: 0x1EFF1C0 Offset: 0x1EFE3C0 VA: 0x181EFF1C0
	private bool ParseFragmentAttribute() { }

	// RVA: 0x1EFB7D0 Offset: 0x1EFA9D0 VA: 0x181EFB7D0
	private bool ParseAttributeValueChunk() { }

	// RVA: 0x1F017B0 Offset: 0x1F009B0 VA: 0x181F017B0
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0x1F06DA0 Offset: 0x1F05FA0 VA: 0x181F06DA0
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x1F06D90 Offset: 0x1F05F90 VA: 0x181F06D90
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0x1F06D70 Offset: 0x1F05F70 VA: 0x181F06D70
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x1F06DC0 Offset: 0x1F05FC0 VA: 0x181F06DC0
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0x1F016B0 Offset: 0x1F008B0 VA: 0x181F016B0
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0x1F016C0 Offset: 0x1F008C0 VA: 0x181F016C0
	private string ParseUnexpectedToken() { }

	// RVA: 0x1F068D0 Offset: 0x1F05AD0 VA: 0x181F068D0
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0x1EF85E0 Offset: 0x1EF77E0 VA: 0x181EF85E0
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0x1EF84F0 Offset: 0x1EF76F0 VA: 0x181EF84F0
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0x1F07840 Offset: 0x1F06A40 VA: 0x181F07840
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0x1EFDED0 Offset: 0x1EFD0D0 VA: 0x181EFDED0
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1EFA9F0 Offset: 0x1EF9BF0 VA: 0x181EFA9F0
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0x1F055C0 Offset: 0x1F047C0 VA: 0x181F055C0
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x794D60 Offset: 0x793F60 VA: 0x180794D60 Slot: 56
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1F05230 Offset: 0x1F04430 VA: 0x181F05230
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0x6ED6E0 Offset: 0x6EC8E0 VA: 0x1806ED6E0
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0x1F09870 Offset: 0x1F08A70 VA: 0x181F09870
	internal void set_OnDefaultAttributeUse(XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }

	// RVA: 0x1F099E0 Offset: 0x1F08BE0 VA: 0x181F099E0
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x18E12B0 Offset: 0x18E04B0 VA: 0x1818E12B0
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0x1EF6050 Offset: 0x1EF5250 VA: 0x181EF6050
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0x1EF8720 Offset: 0x1EF7920 VA: 0x181EF8720
	internal XmlResolver GetResolver() { }

	// RVA: 0x1F094E0 Offset: 0x1F086E0 VA: 0x181F094E0
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0x1F08ED0 Offset: 0x1F080D0 VA: 0x181F08ED0
	internal object get_InternalTypedValue() { }

	// RVA: 0x1F09510 Offset: 0x1F08710 VA: 0x181F09510
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0x1F09290 Offset: 0x1F08490 VA: 0x181F09290
	internal bool get_StandAlone() { }

	// RVA: 0x794CA0 Offset: 0x793EA0 VA: 0x180794CA0 Slot: 55
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x19BF270 Offset: 0x19BE470 VA: 0x1819BF270
	internal bool get_V1Compat() { }

	// RVA: 0x1EF4540 Offset: 0x1EF3740 VA: 0x181EF4540
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }

	// RVA: 0x1EF4D50 Offset: 0x1EF3F50 VA: 0x181EF4D50
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0x1EF4AA0 Offset: 0x1EF3CA0 VA: 0x181EF4AA0
	private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0x1C61A30 Offset: 0x1C60C30 VA: 0x181C61A30
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0x1F07750 Offset: 0x1F06950 VA: 0x181F07750
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0x1F04950 Offset: 0x1F03B50 VA: 0x181F04950
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	// RVA: 0x1F06360 Offset: 0x1F05560 VA: 0x181F06360
	internal static string StripSpaces(string value) { }

	// RVA: 0x1F06550 Offset: 0x1F05750 VA: 0x181F06550
	internal static void StripSpaces(char[] value, int index, ref int len) { }

	// RVA: 0x182AA20 Offset: 0x1829C20 VA: 0x18182AA20
	internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0x1EF6040 Offset: 0x1EF5240 VA: 0x181EF6040
	internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count) { }
}

// Namespace: System.Xml
public enum Formatting // TypeDefIndex: 11964
{
	// Fields
	public int value__; // 0x0
	public const Formatting None = 0;
	public const Formatting Indented = 1;
}

// Namespace: 
private enum XmlTextWriter.NamespaceState // TypeDefIndex: 11965
{
	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.NamespaceState Uninitialized = 0;
	public const XmlTextWriter.NamespaceState NotDeclaredButInScope = 1;
	public const XmlTextWriter.NamespaceState DeclaredButNotWrittenOut = 2;
	public const XmlTextWriter.NamespaceState DeclaredAndWrittenOut = 3;
}

// Namespace: 
private struct XmlTextWriter.TagInfo // TypeDefIndex: 11966
{
	// Fields
	internal string name; // 0x0
	internal string prefix; // 0x8
	internal string defaultNs; // 0x10
	internal XmlTextWriter.NamespaceState defaultNsState; // 0x18
	internal XmlSpace xmlSpace; // 0x1C
	internal string xmlLang; // 0x20
	internal int prevNsTop; // 0x28
	internal int prefixCount; // 0x2C
	internal bool mixed; // 0x30

	// Methods

	// RVA: 0x1FF4BE0 Offset: 0x1FF3DE0 VA: 0x181FF4BE0
	internal void Init(int nsTop) { }
}

// Namespace: 
private struct XmlTextWriter.Namespace // TypeDefIndex: 11967
{
	// Fields
	internal string prefix; // 0x0
	internal string ns; // 0x8
	internal bool declared; // 0x10
	internal int prevNsIndex; // 0x14

	// Methods

	// RVA: 0x1FF42B0 Offset: 0x1FF34B0 VA: 0x181FF42B0
	internal void Set(string prefix, string ns, bool declared) { }
}

// Namespace: 
private enum XmlTextWriter.SpecialAttr // TypeDefIndex: 11968
{
	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.SpecialAttr None = 0;
	public const XmlTextWriter.SpecialAttr XmlSpace = 1;
	public const XmlTextWriter.SpecialAttr XmlLang = 2;
	public const XmlTextWriter.SpecialAttr XmlNs = 3;
}

// Namespace: 
private enum XmlTextWriter.State // TypeDefIndex: 11969
{
	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.State Start = 0;
	public const XmlTextWriter.State Prolog = 1;
	public const XmlTextWriter.State PostDTD = 2;
	public const XmlTextWriter.State Element = 3;
	public const XmlTextWriter.State Attribute = 4;
	public const XmlTextWriter.State Content = 5;
	public const XmlTextWriter.State AttrOnly = 6;
	public const XmlTextWriter.State Epilog = 7;
	public const XmlTextWriter.State Error = 8;
	public const XmlTextWriter.State Closed = 9;
}

// Namespace: 
private enum XmlTextWriter.Token // TypeDefIndex: 11970
{
	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.Token PI = 0;
	public const XmlTextWriter.Token Doctype = 1;
	public const XmlTextWriter.Token Comment = 2;
	public const XmlTextWriter.Token CData = 3;
	public const XmlTextWriter.Token StartElement = 4;
	public const XmlTextWriter.Token EndElement = 5;
	public const XmlTextWriter.Token LongEndElement = 6;
	public const XmlTextWriter.Token StartAttribute = 7;
	public const XmlTextWriter.Token EndAttribute = 8;
	public const XmlTextWriter.Token Content = 9;
	public const XmlTextWriter.Token Base64 = 10;
	public const XmlTextWriter.Token RawData = 11;
	public const XmlTextWriter.Token Whitespace = 12;
	public const XmlTextWriter.Token Empty = 13;
}

// Namespace: System.Xml
[EditorBrowsable(1)]
public class XmlTextWriter : XmlWriter // TypeDefIndex: 11971
{
	// Fields
	private TextWriter textWriter; // 0x18
	private XmlTextEncoder xmlEncoder; // 0x20
	private Encoding encoding; // 0x28
	private Formatting formatting; // 0x30
	private bool indented; // 0x34
	private int indentation; // 0x38
	private char indentChar; // 0x3C
	private XmlTextWriter.TagInfo[] stack; // 0x40
	private int top; // 0x48
	private XmlTextWriter.State[] stateTable; // 0x50
	private XmlTextWriter.State currentState; // 0x58
	private XmlTextWriter.Token lastToken; // 0x5C
	private XmlTextWriterBase64Encoder base64Encoder; // 0x60
	private char quoteChar; // 0x68
	private char curQuoteChar; // 0x6A
	private bool namespaces; // 0x6C
	private XmlTextWriter.SpecialAttr specialAttr; // 0x70
	private string prefixForXmlNs; // 0x78
	private bool flush; // 0x80
	private XmlTextWriter.Namespace[] nsStack; // 0x88
	private int nsTop; // 0x90
	private Dictionary<string, int> nsHashtable; // 0x98
	private bool useNsHashtable; // 0xA0
	private XmlCharType xmlCharType; // 0xA8
	private static string[] stateName; // 0x0
	private static string[] tokenName; // 0x8
	private static readonly XmlTextWriter.State[] stateTableDefault; // 0x10
	private static readonly XmlTextWriter.State[] stateTableDocument; // 0x18

	// Properties
	public Stream BaseStream { get; }
	public bool Namespaces { set; }
	public Formatting Formatting { set; }
	public char QuoteChar { set; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x1FF9950 Offset: 0x1FF8B50 VA: 0x181FF9950
	internal void .ctor() { }

	// RVA: 0x1FF9C90 Offset: 0x1FF8E90 VA: 0x181FF9C90
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x1FF9B70 Offset: 0x1FF8D70 VA: 0x181FF9B70
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x1FF9AC0 Offset: 0x1FF8CC0 VA: 0x181FF9AC0
	public void .ctor(TextWriter w) { }

	// RVA: 0x1FF9D60 Offset: 0x1FF8F60 VA: 0x181FF9D60
	public Stream get_BaseStream() { }

	// RVA: 0x1FF9E80 Offset: 0x1FF9080 VA: 0x181FF9E80
	public void set_Namespaces(bool value) { }

	// RVA: 0x1FF9E70 Offset: 0x1FF9070 VA: 0x181FF9E70
	public void set_Formatting(Formatting value) { }

	// RVA: 0x1FF9F00 Offset: 0x1FF9100 VA: 0x181FF9F00
	public void set_QuoteChar(char value) { }

	// RVA: 0x1FF8D70 Offset: 0x1FF7F70 VA: 0x181FF8D70 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1FF8D50 Offset: 0x1FF7F50 VA: 0x181FF8D50 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1FF7C50 Offset: 0x1FF6E50 VA: 0x181FF7C50 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1FF77B0 Offset: 0x1FF69B0 VA: 0x181FF77B0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1FF8D80 Offset: 0x1FF7F80 VA: 0x181FF8D80 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FF7DE0 Offset: 0x1FF6FE0 VA: 0x181FF7DE0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1FF8260 Offset: 0x1FF7460 VA: 0x181FF8260 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1FF8560 Offset: 0x1FF7760 VA: 0x181FF8560 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FF7C00 Offset: 0x1FF6E00 VA: 0x181FF7C00 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1FF7390 Offset: 0x1FF6590 VA: 0x181FF7390 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1FF7610 Offset: 0x1FF6810 VA: 0x181FF7610 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1FF8270 Offset: 0x1FF7470 VA: 0x181FF8270 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1FF81E0 Offset: 0x1FF73E0 VA: 0x181FF81E0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1FF7500 Offset: 0x1FF6700 VA: 0x181FF7500 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1FF93F0 Offset: 0x1FF85F0 VA: 0x181FF93F0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FF92E0 Offset: 0x1FF84E0 VA: 0x181FF92E0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1FF9360 Offset: 0x1FF8560 VA: 0x181FF9360 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1FF7570 Offset: 0x1FF6770 VA: 0x181FF7570 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FF8450 Offset: 0x1FF7650 VA: 0x181FF8450 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1FF84F0 Offset: 0x1FF76F0 VA: 0x181FF84F0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1FF7200 Offset: 0x1FF6400 VA: 0x181FF7200 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1FF7300 Offset: 0x1FF6500 VA: 0x181FF7300 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1FF9E00 Offset: 0x1FF9000 VA: 0x181FF9E00 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1FF5720 Offset: 0x1FF4920 VA: 0x181FF5720 Slot: 28
	public override void Close() { }

	// RVA: 0x1607D40 Offset: 0x1606F40 VA: 0x181607D40 Slot: 29
	public override void Flush() { }

	// RVA: 0x1FF6480 Offset: 0x1FF5680 VA: 0x181FF6480 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1FF6BB0 Offset: 0x1FF5DB0 VA: 0x181FF6BB0
	private void StartDocument(int standalone) { }

	// RVA: 0x1FF5110 Offset: 0x1FF4310 VA: 0x181FF5110
	private void AutoComplete(XmlTextWriter.Token token) { }

	// RVA: 0x1FF50B0 Offset: 0x1FF42B0 VA: 0x181FF50B0
	private void AutoCompleteAll() { }

	// RVA: 0x1FF5D40 Offset: 0x1FF4F40 VA: 0x181FF5D40
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x1FF7DF0 Offset: 0x1FF6FF0 VA: 0x181FF7DF0
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x1FF7BA0 Offset: 0x1FF6DA0 VA: 0x181FF7BA0
	private void WriteEndAttributeQuote() { }

	// RVA: 0x1FF5C50 Offset: 0x1FF4E50 VA: 0x181FF5C50
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x1FF6690 Offset: 0x1FF5890 VA: 0x181FF6690
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1FF4E30 Offset: 0x1FF4030 VA: 0x181FF4E30
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1FF4FC0 Offset: 0x1FF41C0 VA: 0x181FF4FC0
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1FF6590 Offset: 0x1FF5790 VA: 0x181FF6590
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1FF5920 Offset: 0x1FF4B20 VA: 0x181FF5920
	private string GeneratePrefix() { }

	// RVA: 0x1FF6140 Offset: 0x1FF5340 VA: 0x181FF6140
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1FF6390 Offset: 0x1FF5590 VA: 0x181FF6390
	private int LookupNamespace(string prefix) { }

	// RVA: 0x1FF6250 Offset: 0x1FF5450 VA: 0x181FF6250
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x1FF57F0 Offset: 0x1FF49F0 VA: 0x181FF57F0
	private string FindPrefix(string ns) { }

	// RVA: 0x1FF6EA0 Offset: 0x1FF60A0 VA: 0x181FF6EA0
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x1FF5A20 Offset: 0x1FF4C20 VA: 0x181FF5A20
	private void HandleSpecialAttribute() { }

	// RVA: 0x1FF70C0 Offset: 0x1FF62C0 VA: 0x181FF70C0
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x1FF6AA0 Offset: 0x1FF5CA0 VA: 0x181FF6AA0
	private void PushStack() { }

	// RVA: 0x1FF58E0 Offset: 0x1FF4AE0 VA: 0x181FF58E0
	private void FlushEncoders() { }

	// RVA: 0x1FF9500 Offset: 0x1FF8700 VA: 0x181FF9500
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class XmlUtf8RawTextWriter : XmlRawWriter // TypeDefIndex: 11972
{
	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected NewLineHandling newLineHandling; // 0x6C
	protected bool closeOutput; // 0x70
	protected bool omitXmlDeclaration; // 0x71
	protected string newLineChars; // 0x78
	protected bool checkCharacters; // 0x80
	protected XmlStandalone standalone; // 0x84
	protected XmlOutputMethod outputMethod; // 0x88
	protected bool autoXmlDeclaration; // 0x8C
	protected bool mergeCDataSections; // 0x8D

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1FFE320 Offset: 0x1FFD520 VA: 0x181FFE320
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x1FFE110 Offset: 0x1FFD310 VA: 0x181FFE110
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1FFDE80 Offset: 0x1FFD080 VA: 0x181FFDE80 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1FFE0A0 Offset: 0x1FFD2A0 VA: 0x181FFE0A0 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1FFCAF0 Offset: 0x1FFBCF0 VA: 0x181FFCAF0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1FFDAE0 Offset: 0x1FFCCE0 VA: 0x181FFDAE0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FFB790 Offset: 0x1FFA990 VA: 0x181FFB790 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1FFD0E0 Offset: 0x1FFC2E0 VA: 0x181FFD0E0 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FFD330 Offset: 0x1FFC530 VA: 0x181FFD330 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FFD9D0 Offset: 0x1FFCBD0 VA: 0x181FFD9D0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FFD0A0 Offset: 0x1FFC2A0 VA: 0x181FFD0A0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1FE9E70 Offset: 0x1FE9070 VA: 0x181FE9E70 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1FFDBB0 Offset: 0x1FFCDB0 VA: 0x181FFDBB0 Slot: 52
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1FFD240 Offset: 0x1FFC440 VA: 0x181FFD240 Slot: 53
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1FFC220 Offset: 0x1FFB420 VA: 0x181FFC220 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1FFC9D0 Offset: 0x1FFBBD0 VA: 0x181FFC9D0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1FFD4C0 Offset: 0x1FFC6C0 VA: 0x181FFD4C0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1FFD280 Offset: 0x1FFC480 VA: 0x181FFD280 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1FFC410 Offset: 0x1FFB610 VA: 0x181FFC410 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1FFDCE0 Offset: 0x1FFCEE0 VA: 0x181FFDCE0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FFDCE0 Offset: 0x1FFCEE0 VA: 0x181FFDCE0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1FFDD40 Offset: 0x1FFCF40 VA: 0x181FFDD40 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1EDBAB0 Offset: 0x1EDACB0 VA: 0x181EDBAB0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FFD930 Offset: 0x1FFCB30 VA: 0x181FFD930 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1FFD980 Offset: 0x1FFCB80 VA: 0x181FFD980 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1FFAE00 Offset: 0x1FFA000 VA: 0x181FFAE00 Slot: 28
	public override void Close() { }

	// RVA: 0x1FFB2C0 Offset: 0x1FFA4C0 VA: 0x181FFB2C0 Slot: 29
	public override void Flush() { }

	// RVA: 0x1FFB140 Offset: 0x1FFA340 VA: 0x181FFB140 Slot: 56
	protected virtual void FlushBuffer() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void FlushEncoder() { }

	// RVA: 0x1FFBB70 Offset: 0x1FFAD70 VA: 0x181FFBB70
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1FFCDA0 Offset: 0x1FFBFA0 VA: 0x181FFCDA0
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1FFB520 Offset: 0x1FFA720 VA: 0x181FFB520
	protected void RawText(string s) { }

	// RVA: 0x1FFB570 Offset: 0x1FFA770 VA: 0x181FFB570
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1FFD5F0 Offset: 0x1FFC7F0 VA: 0x181FFD5F0
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1FFC5D0 Offset: 0x1FFB7D0 VA: 0x181FFC5D0
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1FFBE40 Offset: 0x1FFB040 VA: 0x181FFBE40
	protected void WriteCDataSection(string text) { }

	// RVA: 0x1FFB4A0 Offset: 0x1FFA6A0 VA: 0x181FFB4A0
	private static bool IsSurrogateByte(byte b) { }

	// RVA: 0x1FFAF90 Offset: 0x1FFA190 VA: 0x181FFAF90
	private static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst) { }

	// RVA: 0x1FFB320 Offset: 0x1FFA520 VA: 0x181FFB320
	private byte* InvalidXmlChar(int ch, byte* pDst, bool entitize) { }

	// RVA: 0x1FFAE60 Offset: 0x1FFA060 VA: 0x181FFAE60
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x1FFAF40 Offset: 0x1FFA140 VA: 0x181FFAF40
	internal static byte* EncodeMultibyteUTF8(int ch, byte* pDst) { }

	// RVA: 0x1FFAD50 Offset: 0x1FF9F50 VA: 0x181FFAD50
	internal static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x1FFD440 Offset: 0x1FFC640 VA: 0x181FFD440
	protected byte* WriteNewLine(byte* pDst) { }

	// RVA: 0x1FFB4C0 Offset: 0x1FFA6C0 VA: 0x181FFB4C0
	protected static byte* LtEntity(byte* pDst) { }

	// RVA: 0x1FFB310 Offset: 0x1FFA510 VA: 0x181FFB310
	protected static byte* GtEntity(byte* pDst) { }

	// RVA: 0x1FFAC90 Offset: 0x1FF9E90 VA: 0x181FFAC90
	protected static byte* AmpEntity(byte* pDst) { }

	// RVA: 0x1FFB4D0 Offset: 0x1FFA6D0 VA: 0x181FFB4D0
	protected static byte* QuoteEntity(byte* pDst) { }

	// RVA: 0x1FFB7D0 Offset: 0x1FFA9D0 VA: 0x181FFB7D0
	protected static byte* TabEntity(byte* pDst) { }

	// RVA: 0x1FFB4B0 Offset: 0x1FFA6B0 VA: 0x181FFB4B0
	protected static byte* LineFeedEntity(byte* pDst) { }

	// RVA: 0x1FFACA0 Offset: 0x1FF9EA0 VA: 0x181FFACA0
	protected static byte* CarriageReturnEntity(byte* pDst) { }

	// RVA: 0x1FFACB0 Offset: 0x1FF9EB0 VA: 0x181FFACB0
	private static byte* CharEntity(byte* pDst, char ch) { }

	// RVA: 0x1FFB500 Offset: 0x1FFA700 VA: 0x181FFB500
	protected static byte* RawStartCData(byte* pDst) { }

	// RVA: 0x1FFB4F0 Offset: 0x1FFA6F0 VA: 0x181FFB4F0
	protected static byte* RawEndCData(byte* pDst) { }

	// RVA: 0x1FFB7E0 Offset: 0x1FFA9E0 VA: 0x181FFB7E0
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }
}

// Namespace: System.Xml
internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter // TypeDefIndex: 11973
{
	// Fields
	protected int indentLevel; // 0x90
	protected bool newLineOnAttributes; // 0x94
	protected string indentChars; // 0x98
	protected bool mixedContent; // 0xA0
	private BitStack mixedContentStack; // 0xA8
	protected ConformanceLevel conformanceLevel; // 0xB0

	// Methods

	// RVA: 0x1FFAB80 Offset: 0x1FF9D80 VA: 0x181FFAB80
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1FFA200 Offset: 0x1FF9400 VA: 0x181FFA200 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1FFA8C0 Offset: 0x1FF9AC0 VA: 0x181FFA8C0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FFA0C0 Offset: 0x1FF92C0 VA: 0x181FFA0C0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1FFA0B0 Offset: 0x1FF92B0 VA: 0x181FFA0B0 Slot: 47
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x1FFA270 Offset: 0x1FF9470 VA: 0x181FFA270 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FFA3C0 Offset: 0x1FF95C0 VA: 0x181FFA3C0 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FFA7A0 Offset: 0x1FF99A0 VA: 0x181FFA7A0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FFA150 Offset: 0x1FF9350 VA: 0x181FFA150 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1FFA1C0 Offset: 0x1FF93C0 VA: 0x181FFA1C0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1FFA5B0 Offset: 0x1FF97B0 VA: 0x181FFA5B0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1FFA300 Offset: 0x1FF9500 VA: 0x181FFA300 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1FFA160 Offset: 0x1FF9360 VA: 0x181FFA160 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1FFAA40 Offset: 0x1FF9C40 VA: 0x181FFAA40 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1FFA9D0 Offset: 0x1FF9BD0 VA: 0x181FFA9D0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FFA9D0 Offset: 0x1FF9BD0 VA: 0x181FFA9D0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1FFA170 Offset: 0x1FF9370 VA: 0x181FFA170 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FFA750 Offset: 0x1FF9950 VA: 0x181FFA750 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1FFA6F0 Offset: 0x1FF98F0 VA: 0x181FFA6F0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1FFA130 Offset: 0x1FF9330 VA: 0x181FFA130 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1FF9FA0 Offset: 0x1FF91A0 VA: 0x181FF9FA0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1FFA510 Offset: 0x1FF9710 VA: 0x181FFA510
	private void WriteIndent() { }
}

// Namespace: System.Xml
[Obsolete("Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. https://go.microsoft.com/fwlink/?linkid=14202")]
public class XmlValidatingReader : XmlReader // TypeDefIndex: 11974
{
	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public bool Namespaces { get; }

	// Methods

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1917E30 Offset: 0x1917030 VA: 0x181917E30 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x16570C0 Offset: 0x16562C0 VA: 0x1816570C0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x16571B0 Offset: 0x16563B0 VA: 0x1816571B0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1CFECC0 Offset: 0x1CFDEC0 VA: 0x181CFECC0 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1CFD600 Offset: 0x1CFC800 VA: 0x181CFD600 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1CFD730 Offset: 0x1CFC930 VA: 0x181CFD730 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x1CFD7B0 Offset: 0x1CFC9B0 VA: 0x181CFD7B0 Slot: 15
	public override bool get_IsEmptyElement() { }

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

	// RVA: 0x1738040 Offset: 0x1737240 VA: 0x181738040 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x18AEFE0 Offset: 0x18AE1E0 VA: 0x1818AEFE0 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1FF35E0 Offset: 0x1FF27E0 VA: 0x181FF35E0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x8D0650 Offset: 0x8CF850 VA: 0x1808D0650 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1FFFAE0 Offset: 0x1FFECE0 VA: 0x181FFFAE0
	public bool get_Namespaces() { }
}

// Namespace: 
private enum XmlValidatingReaderImpl.ParsingFunction // TypeDefIndex: 11975
{
	// Fields
	public int value__; // 0x0
	public const XmlValidatingReaderImpl.ParsingFunction Read = 0;
	public const XmlValidatingReaderImpl.ParsingFunction Init = 1;
	public const XmlValidatingReaderImpl.ParsingFunction ParseDtdFromContext = 2;
	public const XmlValidatingReaderImpl.ParsingFunction ResolveEntityInternally = 3;
	public const XmlValidatingReaderImpl.ParsingFunction InReadBinaryContent = 4;
	public const XmlValidatingReaderImpl.ParsingFunction ReaderClosed = 5;
	public const XmlValidatingReaderImpl.ParsingFunction Error = 6;
	public const XmlValidatingReaderImpl.ParsingFunction None = 7;
}

// Namespace: 
internal class XmlValidatingReaderImpl.ValidationEventHandling : IValidationEventHandling // TypeDefIndex: 11976
{
	// Fields
	private XmlValidatingReaderImpl reader; // 0x10
	private ValidationEventHandler eventHandler; // 0x18

	// Properties
	private object System.Xml.IValidationEventHandling.EventHandler { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x1FF4CF0 Offset: 0x1FF3EF0 VA: 0x181FF4CF0 Slot: 5
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x1FF4C50 Offset: 0x1FF3E50 VA: 0x181FF4C50
	internal void AddHandler(ValidationEventHandler handler) { }
}

// Namespace: System.Xml
internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 11977
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlTextReaderImpl coreReaderImpl; // 0x18
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x20
	private ValidationType validationType; // 0x28
	private BaseValidator validator; // 0x30
	private XmlSchemaCollection schemaCollection; // 0x38
	private bool processIdentityConstraints; // 0x40
	private XmlValidatingReaderImpl.ParsingFunction parsingFunction; // 0x44
	private XmlValidatingReaderImpl.ValidationEventHandling eventHandling; // 0x48
	private XmlParserContext parserContext; // 0x50
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x58
	private XmlReader outerReader; // 0x60
	private static XmlResolver s_tempResolver; // 0x0

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
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override int AttributeCount { get; }
	public override bool CanResolveEntity { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal ValidationType ValidationType { get; }
	internal XmlSchemaCollection Schemas { get; }
	internal bool Namespaces { get; }
	internal BaseValidator Validator { get; set; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool StandAlone { get; }
	internal object SchemaTypeObject { set; }
	internal object TypedValueObject { get; set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1FFF2F0 Offset: 0x1FFE4F0 VA: 0x181FFF2F0
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x1FFF990 Offset: 0x1FFEB90 VA: 0x181FFF990 Slot: 5
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

	// RVA: 0x1FFF950 Offset: 0x1FFEB50 VA: 0x181FFF950 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1E384B0 Offset: 0x1E376B0 VA: 0x181E384B0 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x18AEFE0 Offset: 0x18AE1E0 VA: 0x1818AEFE0 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x17192C0 Offset: 0x17184C0 VA: 0x1817192C0 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1E382A0 Offset: 0x1E374A0 VA: 0x181E382A0 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1E38270 Offset: 0x1E37470 VA: 0x181E38270 Slot: 25
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1E382D0 Offset: 0x1E374D0 VA: 0x181E382D0 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1FFE780 Offset: 0x1FFD980 VA: 0x181FFE780 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1FFE740 Offset: 0x1FFD940 VA: 0x181FFE740 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1FFE820 Offset: 0x1FFDA20 VA: 0x181FFE820 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1FFE870 Offset: 0x1FFDA70 VA: 0x181FFE870 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1FFE7D0 Offset: 0x1FFD9D0 VA: 0x181FFE7D0 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1FFECF0 Offset: 0x1FFDEF0 VA: 0x181FFECF0 Slot: 33
	public override bool Read() { }

	// RVA: 0x1FFE420 Offset: 0x1FFD620 VA: 0x181FFE420 Slot: 35
	public override void Close() { }

	// RVA: 0x1FFE5F0 Offset: 0x1FFD7F0 VA: 0x181FFE5F0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1FFEBB0 Offset: 0x1FFDDB0 VA: 0x181FFEBB0 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1FFEF50 Offset: 0x1FFE150 VA: 0x181FFEF50 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1FFE680 Offset: 0x1FFD880 VA: 0x181FFE680
	internal void MoveOffEntityReference() { }

	// RVA: 0x1FFEC20 Offset: 0x1FFDE20 VA: 0x181FFEC20 Slot: 44
	public override string ReadString() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 57
	public bool HasLineInfo() { }

	// RVA: 0x1FFF7C0 Offset: 0x1FFE9C0 VA: 0x181FFF7C0 Slot: 58
	public int get_LineNumber() { }

	// RVA: 0x1FFF860 Offset: 0x1FFEA60 VA: 0x181FFF860 Slot: 59
	public int get_LinePosition() { }

	// RVA: 0x1FFE460 Offset: 0x1FFD660 VA: 0x181FFE460 Slot: 60
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBD4BE0 Offset: 0xBD3DE0 VA: 0x180BD4BE0 Slot: 61
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1FFE620 Offset: 0x1FFD820 VA: 0x181FFE620 Slot: 62
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1FFE460 Offset: 0x1FFD660 VA: 0x181FFE460
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1FFE620 Offset: 0x1FFD820 VA: 0x181FFE620
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	internal ValidationType get_ValidationType() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x1FFF930 Offset: 0x1FFEB30 VA: 0x181FFF930
	internal bool get_Namespaces() { }

	// RVA: 0x1FFE8C0 Offset: 0x1FFDAC0 VA: 0x181FFE8C0
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1FFF260 Offset: 0x1FFE460 VA: 0x181FFF260
	private void ValidateDtd() { }

	// RVA: 0x1FFEEA0 Offset: 0x1FFE0A0 VA: 0x181FFEEA0
	private void ResolveEntityInternally() { }

	// RVA: 0x1FFEF90 Offset: 0x1FFE190 VA: 0x181FFEF90
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x1FFE510 Offset: 0x1FFD710 VA: 0x181FFE510
	private XmlResolver GetResolver() { }

	// RVA: 0x1FFEA90 Offset: 0x1FFDC90 VA: 0x181FFEA90
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal BaseValidator get_Validator() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x1FFF900 Offset: 0x1FFEB00 VA: 0x181FFF900 Slot: 55
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1FFFA60 Offset: 0x1FFEC60 VA: 0x181FFFA60
	internal bool get_StandAlone() { }

	// RVA: 0x1FFFAA0 Offset: 0x1FFECA0 VA: 0x181FFFAA0
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x1FFFA80 Offset: 0x1FFEC80 VA: 0x181FFFA80
	internal object get_TypedValueObject() { }

	// RVA: 0x1FFFAC0 Offset: 0x1FFECC0 VA: 0x181FFFAC0
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x1FFE400 Offset: 0x1FFD600 VA: 0x181FFE400
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x1FFF790 Offset: 0x1FFE990 VA: 0x181FFF790 Slot: 56
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1FFF110 Offset: 0x1FFE310 VA: 0x181FFF110
	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }
}

// Namespace: 
private enum XmlWellFormedWriter.State // TypeDefIndex: 11978
{
	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.State Start = 0;
	public const XmlWellFormedWriter.State TopLevel = 1;
	public const XmlWellFormedWriter.State Document = 2;
	public const XmlWellFormedWriter.State Element = 3;
	public const XmlWellFormedWriter.State Content = 4;
	public const XmlWellFormedWriter.State B64Content = 5;
	public const XmlWellFormedWriter.State B64Attribute = 6;
	public const XmlWellFormedWriter.State AfterRootEle = 7;
	public const XmlWellFormedWriter.State Attribute = 8;
	public const XmlWellFormedWriter.State SpecialAttr = 9;
	public const XmlWellFormedWriter.State EndDocument = 10;
	public const XmlWellFormedWriter.State RootLevelAttr = 11;
	public const XmlWellFormedWriter.State RootLevelSpecAttr = 12;
	public const XmlWellFormedWriter.State RootLevelB64Attr = 13;
	public const XmlWellFormedWriter.State AfterRootLevelAttr = 14;
	public const XmlWellFormedWriter.State Closed = 15;
	public const XmlWellFormedWriter.State Error = 16;
	public const XmlWellFormedWriter.State StartContent = 101;
	public const XmlWellFormedWriter.State StartContentEle = 102;
	public const XmlWellFormedWriter.State StartContentB64 = 103;
	public const XmlWellFormedWriter.State StartDoc = 104;
	public const XmlWellFormedWriter.State StartDocEle = 106;
	public const XmlWellFormedWriter.State EndAttrSEle = 107;
	public const XmlWellFormedWriter.State EndAttrEEle = 108;
	public const XmlWellFormedWriter.State EndAttrSCont = 109;
	public const XmlWellFormedWriter.State EndAttrSAttr = 111;
	public const XmlWellFormedWriter.State PostB64Cont = 112;
	public const XmlWellFormedWriter.State PostB64Attr = 113;
	public const XmlWellFormedWriter.State PostB64RootAttr = 114;
	public const XmlWellFormedWriter.State StartFragEle = 115;
	public const XmlWellFormedWriter.State StartFragCont = 116;
	public const XmlWellFormedWriter.State StartFragB64 = 117;
	public const XmlWellFormedWriter.State StartRootLevelAttr = 118;
}

// Namespace: 
private enum XmlWellFormedWriter.Token // TypeDefIndex: 11979
{
	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.Token StartDocument = 0;
	public const XmlWellFormedWriter.Token EndDocument = 1;
	public const XmlWellFormedWriter.Token PI = 2;
	public const XmlWellFormedWriter.Token Comment = 3;
	public const XmlWellFormedWriter.Token Dtd = 4;
	public const XmlWellFormedWriter.Token StartElement = 5;
	public const XmlWellFormedWriter.Token EndElement = 6;
	public const XmlWellFormedWriter.Token StartAttribute = 7;
	public const XmlWellFormedWriter.Token EndAttribute = 8;
	public const XmlWellFormedWriter.Token Text = 9;
	public const XmlWellFormedWriter.Token CData = 10;
	public const XmlWellFormedWriter.Token AtomicValue = 11;
	public const XmlWellFormedWriter.Token Base64 = 12;
	public const XmlWellFormedWriter.Token RawData = 13;
	public const XmlWellFormedWriter.Token Whitespace = 14;
}

// Namespace: 
private class XmlWellFormedWriter.NamespaceResolverProxy : IXmlNamespaceResolver // TypeDefIndex: 11980
{
	// Fields
	private XmlWellFormedWriter wfWriter; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(XmlWellFormedWriter wfWriter) { }

	// RVA: 0x200D340 Offset: 0x200C540 VA: 0x18200D340 Slot: 4
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x200D380 Offset: 0x200C580 VA: 0x18200D380 Slot: 5
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x200D3A0 Offset: 0x200C5A0 VA: 0x18200D3A0 Slot: 6
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}

// Namespace: 
private struct XmlWellFormedWriter.ElementScope // TypeDefIndex: 11981
{
	// Fields
	internal int prevNSTop; // 0x0
	internal string prefix; // 0x8
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal XmlSpace xmlSpace; // 0x20
	internal string xmlLang; // 0x28

	// Methods

	// RVA: 0x200D290 Offset: 0x200C490 VA: 0x18200D290
	internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x200D2C0 Offset: 0x200C4C0 VA: 0x18200D2C0
	internal void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x200D300 Offset: 0x200C500 VA: 0x18200D300
	internal void WriteFullEndElement(XmlRawWriter rawWriter) { }
}

// Namespace: 
private enum XmlWellFormedWriter.NamespaceKind // TypeDefIndex: 11982
{
	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.NamespaceKind Written = 0;
	public const XmlWellFormedWriter.NamespaceKind NeedToWrite = 1;
	public const XmlWellFormedWriter.NamespaceKind Implied = 2;
	public const XmlWellFormedWriter.NamespaceKind Special = 3;
}

// Namespace: 
private struct XmlWellFormedWriter.Namespace // TypeDefIndex: 11983
{
	// Fields
	internal string prefix; // 0x0
	internal string namespaceUri; // 0x8
	internal XmlWellFormedWriter.NamespaceKind kind; // 0x10
	internal int prevNsIndex; // 0x14

	// Methods

	// RVA: 0x200D3D0 Offset: 0x200C5D0 VA: 0x18200D3D0
	internal void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x200D3F0 Offset: 0x200C5F0 VA: 0x18200D3F0
	internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }
}

// Namespace: 
private struct XmlWellFormedWriter.AttrName // TypeDefIndex: 11984
{
	// Fields
	internal string prefix; // 0x0
	internal string namespaceUri; // 0x8
	internal string localName; // 0x10
	internal int prev; // 0x18

	// Methods

	// RVA: 0x2005DB0 Offset: 0x2004FB0 VA: 0x182005DB0
	internal void Set(string prefix, string localName, string namespaceUri) { }

	// RVA: 0x2005D30 Offset: 0x2004F30 VA: 0x182005D30
	internal bool IsDuplicate(string prefix, string localName, string namespaceUri) { }
}

// Namespace: 
private enum XmlWellFormedWriter.SpecialAttribute // TypeDefIndex: 11985
{
	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.SpecialAttribute No = 0;
	public const XmlWellFormedWriter.SpecialAttribute DefaultXmlns = 1;
	public const XmlWellFormedWriter.SpecialAttribute PrefixedXmlns = 2;
	public const XmlWellFormedWriter.SpecialAttribute XmlSpace = 3;
	public const XmlWellFormedWriter.SpecialAttribute XmlLang = 4;
}

// Namespace: 
private enum XmlWellFormedWriter.AttributeValueCache.ItemType // TypeDefIndex: 11986
{
	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.AttributeValueCache.ItemType EntityRef = 0;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType CharEntity = 1;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType SurrogateCharEntity = 2;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType Whitespace = 3;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType String = 4;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType StringChars = 5;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType Raw = 6;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType RawChars = 7;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType ValueString = 8;
}

// Namespace: 
private class XmlWellFormedWriter.AttributeValueCache.Item // TypeDefIndex: 11987
{
	// Fields
	internal XmlWellFormedWriter.AttributeValueCache.ItemType type; // 0x10
	internal object data; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x163D790 Offset: 0x163C990 VA: 0x18163D790
	internal void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }
}

// Namespace: 
private class XmlWellFormedWriter.AttributeValueCache.BufferChunk // TypeDefIndex: 11988
{
	// Fields
	internal char[] buffer; // 0x10
	internal int index; // 0x18
	internal int count; // 0x1C

	// Methods

	// RVA: 0x6BFA00 Offset: 0x6BEC00 VA: 0x1806BFA00
	internal void .ctor(char[] buffer, int index, int count) { }
}

// Namespace: 
private class XmlWellFormedWriter.AttributeValueCache // TypeDefIndex: 11989
{
	// Fields
	private StringBuilder stringValue; // 0x10
	private string singleStringValue; // 0x18
	private XmlWellFormedWriter.AttributeValueCache.Item[] items; // 0x20
	private int firstItem; // 0x28
	private int lastItem; // 0x2C

	// Properties
	internal string StringValue { get; }

	// Methods

	// RVA: 0x20070A0 Offset: 0x20062A0 VA: 0x1820070A0
	internal string get_StringValue() { }

	// RVA: 0x2006A60 Offset: 0x2005C60 VA: 0x182006A60
	internal void WriteEntityRef(string name) { }

	// RVA: 0x20068B0 Offset: 0x2005AB0 VA: 0x1820068B0
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x2006E30 Offset: 0x2006030 VA: 0x182006E30
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x2006FB0 Offset: 0x20061B0 VA: 0x182006FB0
	internal void WriteWhitespace(string ws) { }

	// RVA: 0x2006D90 Offset: 0x2005F90 VA: 0x182006D90
	internal void WriteString(string text) { }

	// RVA: 0x2006970 Offset: 0x2005B70 VA: 0x182006970
	internal void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x2006CA0 Offset: 0x2005EA0 VA: 0x182006CA0
	internal void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x2006C20 Offset: 0x2005E20 VA: 0x182006C20
	internal void WriteRaw(string data) { }

	// RVA: 0x2006F30 Offset: 0x2006130 VA: 0x182006F30
	internal void WriteValue(string value) { }

	// RVA: 0x2006050 Offset: 0x2005250 VA: 0x182006050
	internal void Replay(XmlWriter writer) { }

	// RVA: 0x2006470 Offset: 0x2005670 VA: 0x182006470
	internal void Trim() { }

	// RVA: 0x2006010 Offset: 0x2005210 VA: 0x182006010
	internal void Clear() { }

	// RVA: 0x2006420 Offset: 0x2005620 VA: 0x182006420
	private void StartComplexValue() { }

	// RVA: 0x2005EB0 Offset: 0x20050B0 VA: 0x182005EB0
	private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

	// RVA: 0x2007030 Offset: 0x2006230 VA: 0x182007030
	public void .ctor() { }
}

// Namespace: System.Xml
internal class XmlWellFormedWriter : XmlWriter // TypeDefIndex: 11990
{
	// Fields
	private XmlWriter writer; // 0x18
	private XmlRawWriter rawWriter; // 0x20
	private IXmlNamespaceResolver predefinedNamespaces; // 0x28
	private XmlWellFormedWriter.Namespace[] nsStack; // 0x30
	private int nsTop; // 0x38
	private Dictionary<string, int> nsHashtable; // 0x40
	private bool useNsHashtable; // 0x48
	private XmlWellFormedWriter.ElementScope[] elemScopeStack; // 0x50
	private int elemTop; // 0x58
	private XmlWellFormedWriter.AttrName[] attrStack; // 0x60
	private int attrCount; // 0x68
	private Dictionary<string, int> attrHashTable; // 0x70
	private XmlWellFormedWriter.SpecialAttribute specAttr; // 0x78
	private XmlWellFormedWriter.AttributeValueCache attrValueCache; // 0x80
	private string curDeclPrefix; // 0x88
	private XmlWellFormedWriter.State[] stateTable; // 0x90
	private XmlWellFormedWriter.State currentState; // 0x98
	private bool checkCharacters; // 0x9C
	private bool omitDuplNamespaces; // 0x9D
	private bool writeEndDocumentOnClose; // 0x9E
	private ConformanceLevel conformanceLevel; // 0xA0
	private bool dtdWritten; // 0xA4
	private bool xmlDeclFollows; // 0xA5
	private XmlCharType xmlCharType; // 0xA8
	private SecureStringHasher hasher; // 0xB0
	internal static readonly string[] stateName; // 0x0
	internal static readonly string[] tokenName; // 0x8
	private static WriteState[] state2WriteState; // 0x10
	private static readonly XmlWellFormedWriter.State[] StateTableDocument; // 0x18
	private static readonly XmlWellFormedWriter.State[] StateTableAuto; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal XmlRawWriter RawWriter { get; }
	private bool SaveAttrValue { get; }
	private bool InBase64 { get; }
	private bool IsClosedOrErrorState { get; }

	// Methods

	// RVA: 0x2005820 Offset: 0x2004A20 VA: 0x182005820
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x2005C90 Offset: 0x2004E90 VA: 0x182005C90 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x2004650 Offset: 0x2003850 VA: 0x182004650 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x2004620 Offset: 0x2003820 VA: 0x182004620 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x2003370 Offset: 0x2002570 VA: 0x182003370 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x20026B0 Offset: 0x20018B0 VA: 0x1820026B0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x2004660 Offset: 0x2003860 VA: 0x182004660 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x2003480 Offset: 0x2002680 VA: 0x182003480 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x2003730 Offset: 0x2002930 VA: 0x182003730 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x2003DF0 Offset: 0x2002FF0 VA: 0x182003DF0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x2002B10 Offset: 0x2001D10 VA: 0x182002B10 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x20021E0 Offset: 0x20013E0 VA: 0x1820021E0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x20025F0 Offset: 0x20017F0 VA: 0x1820025F0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x20038D0 Offset: 0x2002AD0 VA: 0x1820038D0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x2003620 Offset: 0x2002820 VA: 0x182003620 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x20022A0 Offset: 0x20014A0 VA: 0x1820022A0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x2004A70 Offset: 0x2003C70 VA: 0x182004A70 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x2005110 Offset: 0x2004310 VA: 0x182005110 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x20049C0 Offset: 0x2003BC0 VA: 0x1820049C0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x20023E0 Offset: 0x20015E0 VA: 0x1820023E0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x2003BE0 Offset: 0x2002DE0 VA: 0x182003BE0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x2003B30 Offset: 0x2002D30 VA: 0x182003B30 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x2001F10 Offset: 0x2001110 VA: 0x182001F10 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x20006F0 Offset: 0x1FFF8F0 VA: 0x1820006F0 Slot: 28
	public override void Close() { }

	// RVA: 0x2000940 Offset: 0x1FFFB40 VA: 0x182000940 Slot: 29
	public override void Flush() { }

	// RVA: 0x2000F00 Offset: 0x2000100 VA: 0x182000F00 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x2004CB0 Offset: 0x2003EB0 VA: 0x182004CB0 Slot: 33
	public override void WriteValue(bool value) { }

	// RVA: 0x2005090 Offset: 0x2004290 VA: 0x182005090 Slot: 34
	public override void WriteValue(DateTime value) { }

	// RVA: 0x2004E70 Offset: 0x2004070 VA: 0x182004E70 Slot: 35
	public override void WriteValue(double value) { }

	// RVA: 0x2004BB0 Offset: 0x2003DB0 VA: 0x182004BB0 Slot: 36
	public override void WriteValue(float value) { }

	// RVA: 0x2004EF0 Offset: 0x20040F0 VA: 0x182004EF0 Slot: 37
	public override void WriteValue(Decimal value) { }

	// RVA: 0x2004C30 Offset: 0x2003E30 VA: 0x182004C30 Slot: 38
	public override void WriteValue(int value) { }

	// RVA: 0x2004D30 Offset: 0x2003F30 VA: 0x182004D30 Slot: 39
	public override void WriteValue(long value) { }

	// RVA: 0x2004DB0 Offset: 0x2003FB0 VA: 0x182004DB0 Slot: 32
	public override void WriteValue(string value) { }

	// RVA: 0x2004F80 Offset: 0x2004180 VA: 0x182004F80 Slot: 31
	public override void WriteValue(object value) { }

	// RVA: 0x20020F0 Offset: 0x20012F0 VA: 0x1820020F0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0x1F22970 Offset: 0x1F21B70 VA: 0x181F22970
	private bool get_SaveAttrValue() { }

	// RVA: 0x2005C60 Offset: 0x2004E60 VA: 0x182005C60
	private bool get_InBase64() { }

	// RVA: 0x2001B80 Offset: 0x2000D80 VA: 0x182001B80
	private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special) { }

	// RVA: 0x20044A0 Offset: 0x20036A0 VA: 0x1820044A0
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x2001D00 Offset: 0x2000F00 VA: 0x182001D00
	private void StartFragment() { }

	// RVA: 0x2001720 Offset: 0x2000920 VA: 0x182001720
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x20011B0 Offset: 0x20003B0 VA: 0x1820011B0
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x1FFFDD0 Offset: 0x1FFEFD0 VA: 0x181FFFDD0
	private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x2000090 Offset: 0x1FFF290 VA: 0x182000090
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x2000D20 Offset: 0x1FFFF20 VA: 0x182000D20
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x20010C0 Offset: 0x20002C0 VA: 0x1820010C0
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x2000830 Offset: 0x1FFFA30 VA: 0x182000830
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x2000170 Offset: 0x1FFF370 VA: 0x182000170
	private void AdvanceState(XmlWellFormedWriter.Token token) { }

	// RVA: 0x2001C10 Offset: 0x2000E10 VA: 0x182001C10
	private void StartElementContent() { }

	// RVA: 0x2000AE0 Offset: 0x1FFFCE0 VA: 0x182000AE0
	private static string GetStateName(XmlWellFormedWriter.State state) { }

	// RVA: 0x2000E10 Offset: 0x2000010 VA: 0x182000E10
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x2000C60 Offset: 0x1FFFE60 VA: 0x182000C60
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x20009A0 Offset: 0x1FFFBA0 VA: 0x1820009A0
	private string GeneratePrefix() { }

	// RVA: 0x20005A0 Offset: 0x1FFF7A0 VA: 0x1820005A0
	private void CheckNCName(string ncname) { }

	// RVA: 0x2000B70 Offset: 0x1FFFD70 VA: 0x182000B70
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x2001D10 Offset: 0x2000F10 VA: 0x182001D10
	private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState) { }

	// RVA: 0x2005C80 Offset: 0x2004E80 VA: 0x182005C80
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x1FFFB10 Offset: 0x1FFED10 VA: 0x181FFFB10
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1FFFF40 Offset: 0x1FFF140 VA: 0x181FFFF40
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x2005260 Offset: 0x2004460 VA: 0x182005260
	private static void .cctor() { }
}

// Namespace: System.Xml
public enum WriteState // TypeDefIndex: 11991
{
	// Fields
	public int value__; // 0x0
	public const WriteState Start = 0;
	public const WriteState Prolog = 1;
	public const WriteState Element = 2;
	public const WriteState Attribute = 3;
	public const WriteState Content = 4;
	public const WriteState Closed = 5;
	public const WriteState Error = 6;
}

// Namespace: System.Xml
public abstract class XmlWriter : IDisposable // TypeDefIndex: 11992
{
	// Fields
	private char[] writeNodeBuffer; // 0x10

	// Properties
	public abstract WriteState WriteState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WriteStartDocument();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void WriteStartDocument(bool standalone);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void WriteEndDocument();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

	// RVA: 0x2018630 Offset: 0x2017830 VA: 0x182018630
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void WriteStartElement(string prefix, string localName, string ns);

	// RVA: 0x2018600 Offset: 0x2017800 VA: 0x182018600
	public void WriteStartElement(string localName) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void WriteEndElement();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void WriteFullEndElement();

	// RVA: 0x2017B80 Offset: 0x2016D80 VA: 0x182017B80
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x2017BF0 Offset: 0x2016DF0 VA: 0x182017BF0
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x2017C60 Offset: 0x2016E60 VA: 0x182017C60
	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteStartAttribute(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void WriteEndAttribute();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void WriteCData(string text);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void WriteComment(string text);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void WriteProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteEntityRef(string name);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void WriteCharEntity(char ch);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void WriteWhitespace(string ws);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void WriteString(string text);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void WriteChars(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void WriteRaw(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void WriteRaw(string data);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void WriteBase64(byte[] buffer, int index, int count);

	// RVA: 0x2017FD0 Offset: 0x20171D0 VA: 0x182017FD0 Slot: 26
	public virtual void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract WriteState get_WriteState();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 28
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string LookupPrefix(string ns);

	// RVA: 0x2018860 Offset: 0x2017A60 VA: 0x182018860 Slot: 31
	public virtual void WriteValue(object value) { }

	// RVA: 0x2018660 Offset: 0x2017860 VA: 0x182018660 Slot: 32
	public virtual void WriteValue(string value) { }

	// RVA: 0x2018A30 Offset: 0x2017C30 VA: 0x182018A30 Slot: 33
	public virtual void WriteValue(bool value) { }

	// RVA: 0x20187E0 Offset: 0x20179E0 VA: 0x1820187E0 Slot: 34
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0x20189C0 Offset: 0x2017BC0 VA: 0x1820189C0 Slot: 35
	public virtual void WriteValue(double value) { }

	// RVA: 0x2018950 Offset: 0x2017B50 VA: 0x182018950 Slot: 36
	public virtual void WriteValue(float value) { }

	// RVA: 0x20186F0 Offset: 0x20178F0 VA: 0x1820186F0 Slot: 37
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0x2018680 Offset: 0x2017880 VA: 0x182018680 Slot: 38
	public virtual void WriteValue(int value) { }

	// RVA: 0x2018770 Offset: 0x2017970 VA: 0x182018770 Slot: 39
	public virtual void WriteValue(long value) { }

	// RVA: 0x2017CC0 Offset: 0x2016EC0 VA: 0x182017CC0 Slot: 40
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x2018080 Offset: 0x2017280 VA: 0x182018080 Slot: 41
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x2018000 Offset: 0x2017200 VA: 0x182018000
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x16BC5E0 Offset: 0x16BB7E0 VA: 0x1816BC5E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2017B40 Offset: 0x2016D40 VA: 0x182017B40 Slot: 42
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2017A60 Offset: 0x2016C60 VA: 0x182017A60
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x20179F0 Offset: 0x2016BF0 VA: 0x1820179F0
	public static XmlWriter Create(TextWriter output) { }

	// RVA: 0x2017AD0 Offset: 0x2016CD0 VA: 0x182017AD0
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml
public enum XmlOutputMethod // TypeDefIndex: 11993
{
	// Fields
	public int value__; // 0x0
	public const XmlOutputMethod Xml = 0;
	public const XmlOutputMethod Html = 1;
	public const XmlOutputMethod Text = 2;
	public const XmlOutputMethod AutoDetect = 3;
}

// Namespace: System.Xml
internal enum TriState // TypeDefIndex: 11994
{
	// Fields
	public int value__; // 0x0
	public const TriState Unknown = -1;
	public const TriState False = 0;
	public const TriState True = 1;
}

// Namespace: System.Xml
internal enum XmlStandalone // TypeDefIndex: 11995
{
	// Fields
	public int value__; // 0x0
	public const XmlStandalone Omit = 0;
	public const XmlStandalone Yes = 1;
	public const XmlStandalone No = 2;
}

// Namespace: System.Xml
public sealed class XmlWriterSettings // TypeDefIndex: 11996
{
	// Fields
	private bool useAsync; // 0x10
	private Encoding encoding; // 0x18
	private bool omitXmlDecl; // 0x20
	private NewLineHandling newLineHandling; // 0x24
	private string newLineChars; // 0x28
	private TriState indent; // 0x30
	private string indentChars; // 0x38
	private bool newLineOnAttributes; // 0x40
	private bool closeOutput; // 0x41
	private NamespaceHandling namespaceHandling; // 0x44
	private ConformanceLevel conformanceLevel; // 0x48
	private bool checkCharacters; // 0x4C
	private bool writeEndDocumentOnClose; // 0x4D
	private XmlOutputMethod outputMethod; // 0x50
	private List<XmlQualifiedName> cdataSections; // 0x58
	private bool doNotEscapeUriAttributes; // 0x60
	private bool mergeCDataSections; // 0x61
	private string mediaType; // 0x68
	private string docTypeSystem; // 0x70
	private string docTypePublic; // 0x78
	private XmlStandalone standalone; // 0x80
	private bool autoXmlDecl; // 0x84
	private bool isReadOnly; // 0x85

	// Properties
	public bool Async { get; }
	public Encoding Encoding { get; }
	public bool OmitXmlDeclaration { get; set; }
	public NewLineHandling NewLineHandling { get; }
	public string NewLineChars { get; }
	public bool Indent { get; set; }
	public string IndentChars { get; }
	public bool NewLineOnAttributes { get; }
	public bool CloseOutput { get; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; }
	public NamespaceHandling NamespaceHandling { get; set; }
	public bool WriteEndDocumentOnClose { get; }
	public XmlOutputMethod OutputMethod { get; set; }
	internal List<XmlQualifiedName> CDataSectionElements { get; }
	public bool DoNotEscapeUriAttributes { get; }
	internal bool MergeCDataSections { get; }
	internal string MediaType { get; }
	internal string DocTypeSystem { get; }
	internal string DocTypePublic { get; }
	internal XmlStandalone Standalone { get; }
	internal bool AutoXmlDeclaration { get; }
	internal TriState IndentInternal { get; }
	internal bool IsQuerySpecific { get; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x2017660 Offset: 0x2016860 VA: 0x182017660
	public void .ctor() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Async() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Encoding get_Encoding() { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x20179A0 Offset: 0x2016BA0 VA: 0x1820179A0
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_NewLineChars() { }

	// RVA: 0x2017790 Offset: 0x2016990 VA: 0x182017790
	public bool get_Indent() { }

	// RVA: 0x20178A0 Offset: 0x2016AA0 VA: 0x1820178A0
	public void set_Indent(bool value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_IndentChars() { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_NewLineOnAttributes() { }

	// RVA: 0x7724A0 Offset: 0x7716A0 VA: 0x1807724A0
	public bool get_CloseOutput() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x2017800 Offset: 0x2016A00 VA: 0x182017800
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x4EDA10 Offset: 0x4ECC10 VA: 0x1804EDA10
	public bool get_CheckCharacters() { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x2017900 Offset: 0x2016B00 VA: 0x182017900
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x190DC00 Offset: 0x190CE00 VA: 0x18190DC00
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x2016D90 Offset: 0x2015F90 VA: 0x182016D90
	public XmlWriterSettings Clone() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0xE5B220 Offset: 0xE5A420 VA: 0x180E5B220
	internal bool get_MergeCDataSections() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	internal string get_MediaType() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	internal string get_DocTypeSystem() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	internal string get_DocTypePublic() { }

	// RVA: 0x1A6BA60 Offset: 0x1A6AC60 VA: 0x181A6BA60
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x1AF8A70 Offset: 0x1AF7C70 VA: 0x181AF8A70
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	internal TriState get_IndentInternal() { }

	// RVA: 0x20177A0 Offset: 0x20169A0 VA: 0x1820177A0
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x2016E50 Offset: 0x2016050 VA: 0x182016E50
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x20172A0 Offset: 0x20164A0 VA: 0x1820172A0
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x1C44CE0 Offset: 0x1C43EE0 VA: 0x181C44CE0
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x2016CE0 Offset: 0x2015EE0 VA: 0x182016CE0
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x2017580 Offset: 0x2016780 VA: 0x182017580
	private void Initialize() { }
}

// Namespace: 
private enum XsdCachingReader.CachingReaderState // TypeDefIndex: 11997
{
	// Fields
	public int value__; // 0x0
	public const XsdCachingReader.CachingReaderState None = 0;
	public const XsdCachingReader.CachingReaderState Init = 1;
	public const XsdCachingReader.CachingReaderState Record = 2;
	public const XsdCachingReader.CachingReaderState Replay = 3;
	public const XsdCachingReader.CachingReaderState ReaderClosed = 4;
	public const XsdCachingReader.CachingReaderState Error = 5;
}

// Namespace: System.Xml
[DefaultMember("Item")]
internal class XsdCachingReader : XmlReader, IXmlLineInfo // TypeDefIndex: 11998
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlNameTable coreReaderNameTable; // 0x18
	private ValidatingReaderNodeData[] contentEvents; // 0x20
	private ValidatingReaderNodeData[] attributeEvents; // 0x28
	private ValidatingReaderNodeData cachedNode; // 0x30
	private XsdCachingReader.CachingReaderState cacheState; // 0x38
	private int contentIndex; // 0x3C
	private int attributeCount; // 0x40
	private bool returnOriginalStringValues; // 0x44
	private CachingEventHandler cacheHandler; // 0x48
	private int currentAttrIndex; // 0x50
	private int currentContentIndex; // 0x54
	private bool readAhead; // 0x58
	private IXmlLineInfo lineInfo; // 0x60
	private ValidatingReaderNodeData textNode; // 0x68

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
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x201A2A0 Offset: 0x20194A0 VA: 0x18201A2A0
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x2019260 Offset: 0x2018460 VA: 0x182019260
	private void Init() { }

	// RVA: 0x2019F50 Offset: 0x2019150 VA: 0x182019F50
	internal void Reset(XmlReader reader) { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x201A470 Offset: 0x2019670 VA: 0x18201A470 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x201A440 Offset: 0x2019640 VA: 0x18201A440 Slot: 7
	public override string get_Name() { }

	// RVA: 0x201A420 Offset: 0x2019620 VA: 0x18201A420 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x5C80B0 Offset: 0x5C72B0 VA: 0x1805C80B0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x201A490 Offset: 0x2019690 VA: 0x18201A490 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x201A3C0 Offset: 0x20195C0 VA: 0x18201A3C0 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x201A4B0 Offset: 0x20196B0 VA: 0x18201A4B0 Slot: 12
	public override string get_Value() { }

	// RVA: 0x201A360 Offset: 0x2019560 VA: 0x18201A360 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1CFD730 Offset: 0x1CFC930 VA: 0x181CFD730 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x1657090 Offset: 0x1656290 VA: 0x181657090 Slot: 17
	public override char get_QuoteChar() { }

	// RVA: 0x1657120 Offset: 0x1656320 VA: 0x181657120 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1E384E0 Offset: 0x1E376E0 VA: 0x181E384E0 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x20191D0 Offset: 0x20183D0 VA: 0x1820191D0 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x20190A0 Offset: 0x20182A0 VA: 0x1820190A0 Slot: 25
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x2019010 Offset: 0x2018210 VA: 0x182019010 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x2019490 Offset: 0x2018690 VA: 0x182019490 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x2019400 Offset: 0x2018600 VA: 0x182019400 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x2019570 Offset: 0x2018770 VA: 0x182019570 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x20195C0 Offset: 0x20187C0 VA: 0x1820195C0 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x2019520 Offset: 0x2018720 VA: 0x182019520 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x2019700 Offset: 0x2018900 VA: 0x182019700 Slot: 33
	public override bool Read() { }

	// RVA: 0x2019ED0 Offset: 0x20190D0 VA: 0x182019ED0
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x201A110 Offset: 0x2019310 VA: 0x18201A110
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x2019D70 Offset: 0x2018F70 VA: 0x182019D70
	internal void RecordEndElementNode() { }

	// RVA: 0x20196E0 Offset: 0x20188E0 VA: 0x1820196E0
	internal string ReadOriginalContentAsString() { }

	// RVA: 0x201A380 Offset: 0x2019580 VA: 0x18201A380 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x2018DA0 Offset: 0x2017FA0 VA: 0x182018DA0 Slot: 35
	public override void Close() { }

	// RVA: 0x1738040 Offset: 0x1737240 VA: 0x181738040 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x2019FD0 Offset: 0x20191D0 VA: 0x182019FD0 Slot: 37
	public override void Skip() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x17457D0 Offset: 0x17449D0 VA: 0x1817457D0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x2019F60 Offset: 0x2019160 VA: 0x182019F60 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x2019610 Offset: 0x2018810 VA: 0x182019610 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 57
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x201A260 Offset: 0x2019460 VA: 0x18201A260 Slot: 58
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x201A280 Offset: 0x2019480 VA: 0x18201A280 Slot: 59
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x2019FA0 Offset: 0x20191A0 VA: 0x182019FA0
	internal void SetToReplayMode() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal XmlReader GetCoreReader() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x2018D90 Offset: 0x2017F90 VA: 0x182018D90
	private void ClearAttributesInfo() { }

	// RVA: 0x2018AA0 Offset: 0x2017CA0 VA: 0x182018AA0
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x2018C10 Offset: 0x2017E10 VA: 0x182018C10
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x2019A70 Offset: 0x2018C70 VA: 0x182019A70
	private void RecordAttributes() { }

	// RVA: 0x2018F40 Offset: 0x2018140 VA: 0x182018F40
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x2018E80 Offset: 0x2018080 VA: 0x182018E80
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x2018DE0 Offset: 0x2017FE0 VA: 0x182018DE0
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }
}

// Namespace: System.Xml
internal sealed class CachingEventHandler : MulticastDelegate // TypeDefIndex: 11999
{
	// Methods

	// RVA: 0x3FD260 Offset: 0x3FC460 VA: 0x1803FD260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(XsdCachingReader cachingReader) { }
}

// Namespace: System.Xml
internal class AttributePSVIInfo // TypeDefIndex: 12000
{
	// Fields
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal object typedAttributeValue; // 0x20
	internal XmlSchemaInfo attributeSchemaInfo; // 0x28

	// Methods

	// RVA: 0x2005E50 Offset: 0x2005050 VA: 0x182005E50
	internal void .ctor() { }

	// RVA: 0x2005DD0 Offset: 0x2004FD0 VA: 0x182005DD0
	internal void Reset() { }
}

// Namespace: 
private enum XsdValidatingReader.ValidatingReaderState // TypeDefIndex: 12001
{
	// Fields
	public int value__; // 0x0
	public const XsdValidatingReader.ValidatingReaderState None = 0;
	public const XsdValidatingReader.ValidatingReaderState Init = 1;
	public const XsdValidatingReader.ValidatingReaderState Read = 2;
	public const XsdValidatingReader.ValidatingReaderState OnDefaultAttribute = -1;
	public const XsdValidatingReader.ValidatingReaderState OnReadAttributeValue = -2;
	public const XsdValidatingReader.ValidatingReaderState OnAttribute = 3;
	public const XsdValidatingReader.ValidatingReaderState ClearAttributes = 4;
	public const XsdValidatingReader.ValidatingReaderState ParseInlineSchema = 5;
	public const XsdValidatingReader.ValidatingReaderState ReadAhead = 6;
	public const XsdValidatingReader.ValidatingReaderState OnReadBinaryContent = 7;
	public const XsdValidatingReader.ValidatingReaderState ReaderClosed = 8;
	public const XsdValidatingReader.ValidatingReaderState EOF = 9;
	public const XsdValidatingReader.ValidatingReaderState Error = 10;
}

// Namespace: System.Xml
internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 12002
{
	// Fields
	private XmlReader coreReader; // 0x10
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x18
	private IXmlNamespaceResolver thisNSResolver; // 0x20
	private XmlSchemaValidator validator; // 0x28
	private XmlResolver xmlResolver; // 0x30
	private ValidationEventHandler validationEvent; // 0x38
	private XsdValidatingReader.ValidatingReaderState validationState; // 0x40
	private XmlValueGetter valueGetter; // 0x48
	private XmlNamespaceManager nsManager; // 0x50
	private bool manageNamespaces; // 0x58
	private bool processInlineSchema; // 0x59
	private bool replayCache; // 0x5A
	private ValidatingReaderNodeData cachedNode; // 0x60
	private AttributePSVIInfo attributePSVI; // 0x68
	private int attributeCount; // 0x70
	private int coreReaderAttributeCount; // 0x74
	private int currentAttrIndex; // 0x78
	private AttributePSVIInfo[] attributePSVINodes; // 0x80
	private ArrayList defaultAttributes; // 0x88
	private Parser inlineSchemaParser; // 0x90
	private object atomicValue; // 0x98
	private XmlSchemaInfo xmlSchemaInfo; // 0xA0
	private string originalAtomicValueString; // 0xA8
	private XmlNameTable coreReaderNameTable; // 0xB0
	private XsdCachingReader cachingReader; // 0xB8
	private ValidatingReaderNodeData textNode; // 0xC0
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsdSchema; // 0xF0
	private string XsiSchemaLocation; // 0xF8
	private string XsiNoNamespaceSchemaLocation; // 0x100
	private XmlCharType xmlCharType; // 0x108
	private IXmlLineInfo lineInfo; // 0x110
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x118
	private XsdValidatingReader.ValidatingReaderState savedState; // 0x120
	private static Type TypeOfString; // 0x0

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
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	private XmlSchemaType ElementXmlType { get; }
	private XmlSchemaType AttributeXmlType { get; }
	private XmlSchemaInfo AttributeSchemaInfo { get; }

	// Methods

	// RVA: 0x201ED70 Offset: 0x201DF70 VA: 0x18201ED70
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x201EF10 Offset: 0x201E110 VA: 0x18201EF10
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x201B810 Offset: 0x201AA10 VA: 0x18201B810
	private void Init() { }

	// RVA: 0x201E0A0 Offset: 0x201D2A0 VA: 0x18201E0A0
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x201F5C0 Offset: 0x201E7C0 VA: 0x18201F5C0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x201F490 Offset: 0x201E690 VA: 0x18201F490 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x201F310 Offset: 0x201E510 VA: 0x18201F310 Slot: 7
	public override string get_Name() { }

	// RVA: 0x201F2C0 Offset: 0x201E4C0 VA: 0x18201F2C0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x201F440 Offset: 0x201E640 VA: 0x18201F440 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x201F530 Offset: 0x201E730 VA: 0x18201F530 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x201F180 Offset: 0x201E380 VA: 0x18201F180 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x201F780 Offset: 0x201E980 VA: 0x18201F780 Slot: 12
	public override string get_Value() { }

	// RVA: 0x201F100 Offset: 0x201E300 VA: 0x18201F100 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1CFD730 Offset: 0x1CFC930 VA: 0x181CFD730 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x1CFD7B0 Offset: 0x1CFC9B0 VA: 0x181CFD7B0 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x201F1C0 Offset: 0x201E3C0 VA: 0x18201F1C0 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x1657090 Offset: 0x1656290 VA: 0x181657090 Slot: 17
	public override char get_QuoteChar() { }

	// RVA: 0x1657120 Offset: 0x1656320 VA: 0x181657120 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1E384E0 Offset: 0x1E376E0 VA: 0x181E384E0 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 20
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x201F6A0 Offset: 0x201E8A0 VA: 0x18201F6A0 Slot: 21
	public override Type get_ValueType() { }

	// RVA: 0x201D600 Offset: 0x201C800 VA: 0x18201D600 Slot: 22
	public override string ReadContentAsString() { }

	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x201AC60 Offset: 0x2019E60 VA: 0x18201AC60 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x201ACE0 Offset: 0x2019EE0 VA: 0x18201ACE0 Slot: 25
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x201AB00 Offset: 0x2019D00 VA: 0x18201AB00 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x201BED0 Offset: 0x201B0D0 VA: 0x18201BED0 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x201BF90 Offset: 0x201B190 VA: 0x18201BF90 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x201C220 Offset: 0x201B420 VA: 0x18201C220 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x201C410 Offset: 0x201B610 VA: 0x18201C410 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x201C1C0 Offset: 0x201B3C0 VA: 0x18201C1C0 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x201DBB0 Offset: 0x201CDB0 VA: 0x18201DBB0 Slot: 33
	public override bool Read() { }

	// RVA: 0x1E384B0 Offset: 0x1E376B0 VA: 0x181E384B0 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x201A770 Offset: 0x2019970 VA: 0x18201A770 Slot: 35
	public override void Close() { }

	// RVA: 0x201F580 Offset: 0x201E780 VA: 0x18201F580 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x201E2D0 Offset: 0x201D4D0 VA: 0x18201E2D0 Slot: 37
	public override void Skip() { }

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x201BE70 Offset: 0x201B070 VA: 0x18201BE70 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x201DEA0 Offset: 0x201D0A0 VA: 0x18201DEA0 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x201D4B0 Offset: 0x201C6B0 VA: 0x18201D4B0 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x201E700 Offset: 0x201D900 VA: 0x18201E700 Slot: 58
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x201E790 Offset: 0x201D990 VA: 0x18201E790 Slot: 59
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x201EAB0 Offset: 0x201DCB0 VA: 0x18201EAB0 Slot: 57
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x201E7E0 Offset: 0x201D9E0 VA: 0x18201E7E0 Slot: 60
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x201EA50 Offset: 0x201DC50 VA: 0x18201EA50 Slot: 61
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x201E9F0 Offset: 0x201DBF0 VA: 0x18201E9F0 Slot: 62
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x201E9A0 Offset: 0x201DBA0 VA: 0x18201E9A0 Slot: 63
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 64
	public bool HasLineInfo() { }

	// RVA: 0x201F200 Offset: 0x201E400 VA: 0x18201F200 Slot: 65
	public int get_LineNumber() { }

	// RVA: 0x201F260 Offset: 0x201E460 VA: 0x18201F260 Slot: 66
	public int get_LinePosition() { }

	// RVA: 0x201E4F0 Offset: 0x201D6F0 VA: 0x18201E4F0 Slot: 67
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x201E5E0 Offset: 0x201D7E0 VA: 0x18201E5E0 Slot: 68
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x201E670 Offset: 0x201D870 VA: 0x18201E670 Slot: 69
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1CFECC0 Offset: 0x1CFDEC0 VA: 0x181CFECC0
	private object GetStringValue() { }

	// RVA: 0x201F150 Offset: 0x201E350 VA: 0x18201F150
	private XmlSchemaType get_ElementXmlType() { }

	// RVA: 0x201F0D0 Offset: 0x201E2D0 VA: 0x18201F0D0
	private XmlSchemaType get_AttributeXmlType() { }

	// RVA: 0x201F0B0 Offset: 0x201E2B0 VA: 0x18201F0B0
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x201D050 Offset: 0x201C250 VA: 0x18201D050
	private void ProcessReaderEvent() { }

	// RVA: 0x201C600 Offset: 0x201B800 VA: 0x18201C600
	private void ProcessElementEvent() { }

	// RVA: 0x201CC40 Offset: 0x201BE40 VA: 0x18201CC40
	private void ProcessEndElementEvent() { }

	// RVA: 0x201EB60 Offset: 0x201DD60 VA: 0x18201EB60
	private void ValidateAttributes() { }

	// RVA: 0x201A720 Offset: 0x2019920 VA: 0x18201A720
	private void ClearAttributesInfo() { }

	// RVA: 0x201A910 Offset: 0x2019B10 VA: 0x18201A910
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x201A860 Offset: 0x2019A60 VA: 0x18201A860
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x201B1C0 Offset: 0x201A3C0 VA: 0x18201B1C0
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x201B040 Offset: 0x201A240 VA: 0x18201B040
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x201A4E0 Offset: 0x20196E0 VA: 0x18201A4E0
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x201BE20 Offset: 0x201B020 VA: 0x18201BE20
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x201CF40 Offset: 0x201C140 VA: 0x18201CF40
	private void ProcessInlineSchema() { }

	// RVA: 0x201BDF0 Offset: 0x201AFF0 VA: 0x18201BDF0
	private object InternalReadContentAsObject() { }

	// RVA: 0x201BB50 Offset: 0x201AD50 VA: 0x18201BB50
	private object InternalReadContentAsObject(bool unwrapTypedValue) { }

	// RVA: 0x201BB70 Offset: 0x201AD70 VA: 0x18201BB70
	private object InternalReadContentAsObject(bool unwrapTypedValue, out string originalStringValue) { }

	// RVA: 0x201D900 Offset: 0x201CB00 VA: 0x18201D900
	private object ReadTillEndElement() { }

	// RVA: 0x201E470 Offset: 0x201D670 VA: 0x18201E470
	private void SwitchReader() { }

	// RVA: 0x201D260 Offset: 0x201C460 VA: 0x18201D260
	private void ReadAheadForMemberType() { }

	// RVA: 0x201B320 Offset: 0x201A520 VA: 0x18201B320
	private void GetIsDefault() { }

	// RVA: 0x201B650 Offset: 0x201A850 VA: 0x18201B650
	private void GetMemberType() { }

	// RVA: 0x201DEE0 Offset: 0x201D0E0 VA: 0x18201DEE0
	private object ReturnBoxedValue(object typedValue, XmlSchemaType xmlType, bool unWrap) { }

	// RVA: 0x201AE10 Offset: 0x201A010 VA: 0x18201AE10
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x201A7B0 Offset: 0x20199B0 VA: 0x18201A7B0
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x201A6F0 Offset: 0x20198F0 VA: 0x18201A6F0
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x201B770 Offset: 0x201A970 VA: 0x18201B770
	private string GetOriginalAtomicValueStringOfElement() { }
}

// Namespace: System.Xml
internal sealed class DocumentXPathNavigator : XPathNavigator, IHasXmlNode // TypeDefIndex: 12003
{
	// Fields
	private XmlDocument document; // 0x10
	private XmlNode source; // 0x18
	private int attributeIndex; // 0x20
	private XmlElement namespaceParent; // 0x28

	// Properties
	public override XmlNameTable NameTable { get; }
	public override XPathNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Name { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	private string ValueDocument { get; }
	private string ValueText { get; }
	public override string BaseURI { get; }
	public override string XmlLang { get; }
	public override object UnderlyingObject { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0x200B3D0 Offset: 0x200A5D0 VA: 0x18200B3D0
	public void .ctor(XmlDocument document, XmlNode node) { }

	// RVA: 0x200B450 Offset: 0x200A650 VA: 0x18200B450
	public void .ctor(DocumentXPathNavigator other) { }

	// RVA: 0x20071F0 Offset: 0x20063F0 VA: 0x1820071F0 Slot: 25
	public override XPathNavigator Clone() { }

	// RVA: 0x200B530 Offset: 0x200A730 VA: 0x18200B530 Slot: 21
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x200B830 Offset: 0x200AA30 VA: 0x18200B830 Slot: 26
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x200B500 Offset: 0x200A700 VA: 0x18200B500 Slot: 27
	public override string get_LocalName() { }

	// RVA: 0x200B740 Offset: 0x200A940 VA: 0x18200B740 Slot: 29
	public override string get_NamespaceURI() { }

	// RVA: 0x200B560 Offset: 0x200A760 VA: 0x18200B560 Slot: 28
	public override string get_Name() { }

	// RVA: 0x200B8B0 Offset: 0x200AAB0 VA: 0x18200B8B0 Slot: 30
	public override string get_Prefix() { }

	// RVA: 0x200BC00 Offset: 0x200AE00 VA: 0x18200BC00 Slot: 5
	public override string get_Value() { }

	// RVA: 0x200BA00 Offset: 0x200AC00 VA: 0x18200BA00
	private string get_ValueDocument() { }

	// RVA: 0x200BA80 Offset: 0x200AC80 VA: 0x18200BA80
	private string get_ValueText() { }

	// RVA: 0x200B4D0 Offset: 0x200A6D0 VA: 0x18200B4D0 Slot: 31
	public override string get_BaseURI() { }

	// RVA: 0x1FFF790 Offset: 0x1FFE990 VA: 0x181FFF790 Slot: 32
	public override string get_XmlLang() { }

	// RVA: 0x200B9A0 Offset: 0x200ABA0 VA: 0x18200B9A0 Slot: 33
	public override object get_UnderlyingObject() { }

	// RVA: 0x2007DA0 Offset: 0x2006FA0 VA: 0x182007DA0 Slot: 34
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x2008180 Offset: 0x2007380 VA: 0x182008180 Slot: 35
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x20092B0 Offset: 0x20084B0 VA: 0x1820092B0 Slot: 36
	public override bool MoveToNextAttribute() { }

	// RVA: 0x2008FE0 Offset: 0x20081E0 VA: 0x182008FE0 Slot: 37
	public override bool MoveToNamespace(string name) { }

	// RVA: 0x20086D0 Offset: 0x20078D0 VA: 0x1820086D0 Slot: 38
	public override bool MoveToFirstNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x2008620 Offset: 0x2007820 VA: 0x182008620
	private static bool MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x2008470 Offset: 0x2007670 VA: 0x182008470
	private static bool MoveToFirstNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x2009790 Offset: 0x2008990 VA: 0x182009790 Slot: 39
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x20096F0 Offset: 0x20088F0 VA: 0x1820096F0
	private static bool MoveToNextNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x2009500 Offset: 0x2008700 VA: 0x182009500
	private static bool MoveToNextNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x200AA70 Offset: 0x2009C70 VA: 0x18200AA70
	private bool PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, string localName) { }

	// RVA: 0x2007D30 Offset: 0x2006F30 VA: 0x182007D30 Slot: 22
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x2009FE0 Offset: 0x20091E0 VA: 0x182009FE0 Slot: 40
	public override bool MoveToNext() { }

	// RVA: 0x20082E0 Offset: 0x20074E0 VA: 0x1820082E0 Slot: 41
	public override bool MoveToFirstChild() { }

	// RVA: 0x200A3C0 Offset: 0x20095C0 VA: 0x18200A3C0 Slot: 42
	public override bool MoveToParent() { }

	// RVA: 0x200A4E0 Offset: 0x20096E0 VA: 0x18200A4E0 Slot: 43
	public override void MoveToRoot() { }

	// RVA: 0x200A600 Offset: 0x2009800 VA: 0x18200A600 Slot: 44
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x2008F90 Offset: 0x2008190 VA: 0x182008F90 Slot: 45
	public override bool MoveToId(string id) { }

	// RVA: 0x2007F60 Offset: 0x2007160 VA: 0x182007F60 Slot: 46
	public override bool MoveToChild(string localName, string namespaceUri) { }

	// RVA: 0x2008080 Offset: 0x2007280 VA: 0x182008080 Slot: 47
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x2008990 Offset: 0x2007B90 VA: 0x182008990 Slot: 48
	public override bool MoveToFollowing(string localName, string namespaceUri, XPathNavigator end) { }

	// RVA: 0x2008C90 Offset: 0x2007E90 VA: 0x182008C90 Slot: 49
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x200A190 Offset: 0x2009390 VA: 0x18200A190 Slot: 50
	public override bool MoveToNext(string localName, string namespaceUri) { }

	// RVA: 0x200A280 Offset: 0x2009480 VA: 0x18200A280 Slot: 51
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x2007B30 Offset: 0x2006D30 VA: 0x182007B30 Slot: 52
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x2007920 Offset: 0x2006B20 VA: 0x182007920 Slot: 53
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x16C6570 Offset: 0x16C5770 VA: 0x1816C6570 Slot: 55
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x200A8A0 Offset: 0x2009AA0 VA: 0x18200A8A0
	private static XmlNode OwnerNode(XmlNode node) { }

	// RVA: 0x2007850 Offset: 0x2006A50 VA: 0x182007850
	private static int GetDepth(XmlNode node) { }

	// RVA: 0x2007500 Offset: 0x2006700 VA: 0x182007500
	private XmlNodeOrder Compare(XmlNode node1, XmlNode node2) { }

	// RVA: 0x20072A0 Offset: 0x20064A0 VA: 0x1820072A0 Slot: 54
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 64
	private XmlNode System.Xml.IHasXmlNode.GetNode() { }

	// RVA: 0x200B170 Offset: 0x200A370 VA: 0x18200B170 Slot: 63
	public override XPathNodeIterator SelectDescendants(string localName, string namespaceURI, bool matchSelf) { }

	// RVA: 0x200B040 Offset: 0x200A240 VA: 0x18200B040 Slot: 62
	public override XPathNodeIterator SelectDescendants(XPathNodeType nt, bool includeSelf) { }

	// RVA: 0x200AED0 Offset: 0x200A0D0 VA: 0x18200AED0
	internal void ResetPosition(XmlNode node) { }

	// RVA: 0x200AE40 Offset: 0x200A040 VA: 0x18200AE40
	private static bool ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, out int index) { }

	// RVA: 0x2007130 Offset: 0x2006330 VA: 0x182007130
	private static bool CheckAttributePosition(XmlAttribute attribute, out XmlAttributeCollection attributes, int index) { }

	// RVA: 0x20070E0 Offset: 0x20062E0 VA: 0x1820070E0
	private void CalibrateText() { }

	// RVA: 0x200A9D0 Offset: 0x2009BD0 VA: 0x18200A9D0
	private XmlNode ParentNode(XmlNode node) { }

	// RVA: 0x200A960 Offset: 0x2009B60 VA: 0x18200A960
	private XmlNode ParentNodeTail(XmlNode parent) { }

	// RVA: 0x20077B0 Offset: 0x20069B0 VA: 0x1820077B0
	private XmlNode FirstChild(XmlNode node) { }

	// RVA: 0x2007740 Offset: 0x2006940 VA: 0x182007740
	private XmlNode FirstChildTail(XmlNode child) { }

	// RVA: 0x200A770 Offset: 0x2009970 VA: 0x18200A770
	private XmlNode NextSibling(XmlNode node) { }

	// RVA: 0x200A690 Offset: 0x2009890 VA: 0x18200A690
	private XmlNode NextSiblingTail(XmlNode node, XmlNode sibling) { }

	// RVA: 0x200ACD0 Offset: 0x2009ED0 VA: 0x18200ACD0
	private XmlNode PreviousText(XmlNode node) { }

	// RVA: 0x200AB90 Offset: 0x2009D90 VA: 0x18200AB90
	private XmlNode PreviousTextTail(XmlNode node, XmlNode text) { }

	// RVA: 0x2007A50 Offset: 0x2006C50 VA: 0x182007A50
	private static bool IsDescendant(XmlNode top, XmlNode bottom) { }

	// RVA: 0x2007C40 Offset: 0x2006E40 VA: 0x182007C40
	private static bool IsValidChild(XmlNode parent, XmlNode child) { }

	// RVA: 0x200B360 Offset: 0x200A560 VA: 0x18200B360
	private XmlNode TextEnd(XmlNode node) { }
}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_Empty : XPathNodeIterator // TypeDefIndex: 12004
{
	// Fields
	private XPathNavigator nav; // 0x18

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x200CB30 Offset: 0x200BD30 VA: 0x18200CB30
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x200CB80 Offset: 0x200BD80 VA: 0x18200CB80
	internal void .ctor(DocumentXPathNodeIterator_Empty other) { }

	// RVA: 0x200CAB0 Offset: 0x200BCB0 VA: 0x18200CAB0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	public override int get_Count() { }
}

// Namespace: System.Xml
internal abstract class DocumentXPathNodeIterator_ElemDescendants : XPathNodeIterator // TypeDefIndex: 12005
{
	// Fields
	private DocumentXPathNavigator nav; // 0x18
	private int level; // 0x20
	private int position; // 0x24

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }

	// Methods

	// RVA: 0x200C920 Offset: 0x200BB20 VA: 0x18200C920
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x200C9E0 Offset: 0x200BBE0 VA: 0x18200C9E0
	internal void .ctor(DocumentXPathNodeIterator_ElemDescendants other) { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract bool Match(XmlNode node);

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	protected void SetPosition(int pos) { }

	// RVA: 0x200C780 Offset: 0x200B980 VA: 0x18200C780 Slot: 7
	public override bool MoveNext() { }
}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_AllElemChildren : DocumentXPathNodeIterator_ElemDescendants // TypeDefIndex: 12006
{
	// Methods

	// RVA: 0x200C060 Offset: 0x200B260 VA: 0x18200C060
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x200C070 Offset: 0x200B270 VA: 0x18200C070
	internal void .ctor(DocumentXPathNodeIterator_AllElemChildren other) { }

	// RVA: 0x200C080 Offset: 0x200B280 VA: 0x18200C080 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x200C0E0 Offset: 0x200B2E0 VA: 0x18200C0E0 Slot: 12
	protected override bool Match(XmlNode node) { }
}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_AllElemChildren_AndSelf : DocumentXPathNodeIterator_AllElemChildren // TypeDefIndex: 12007
{
	// Methods

	// RVA: 0x200C060 Offset: 0x200B260 VA: 0x18200C060
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x200C070 Offset: 0x200B270 VA: 0x18200C070
	internal void .ctor(DocumentXPathNodeIterator_AllElemChildren_AndSelf other) { }

	// RVA: 0x200BE90 Offset: 0x200B090 VA: 0x18200BE90 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x200BEF0 Offset: 0x200B0F0 VA: 0x18200BEF0 Slot: 7
	public override bool MoveNext() { }
}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren_NoLocalName : DocumentXPathNodeIterator_ElemDescendants // TypeDefIndex: 12008
{
	// Fields
	private string nsAtom; // 0x28

	// Methods

	// RVA: 0x200C520 Offset: 0x200B720 VA: 0x18200C520
	internal void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x200C4E0 Offset: 0x200B6E0 VA: 0x18200C4E0
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_NoLocalName other) { }

	// RVA: 0x200C6C0 Offset: 0x200B8C0 VA: 0x18200C6C0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x200C730 Offset: 0x200B930 VA: 0x18200C730 Slot: 12
	protected override bool Match(XmlNode node) { }
}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName : DocumentXPathNodeIterator_ElemChildren_NoLocalName // TypeDefIndex: 12009
{
	// Methods

	// RVA: 0x200C520 Offset: 0x200B720 VA: 0x18200C520
	internal void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x200C4E0 Offset: 0x200B6E0 VA: 0x18200C4E0
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName other) { }

	// RVA: 0x200C300 Offset: 0x200B500 VA: 0x18200C300 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x200C370 Offset: 0x200B570 VA: 0x18200C370 Slot: 7
	public override bool MoveNext() { }
}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren : DocumentXPathNodeIterator_ElemDescendants // TypeDefIndex: 12010
{
	// Fields
	protected string localNameAtom; // 0x28
	protected string nsAtom; // 0x30

	// Methods

	// RVA: 0x200C550 Offset: 0x200B750 VA: 0x18200C550
	internal void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x200C590 Offset: 0x200B790 VA: 0x18200C590
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren other) { }

	// RVA: 0x200C5D0 Offset: 0x200B7D0 VA: 0x18200C5D0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x200C640 Offset: 0x200B840 VA: 0x18200C640 Slot: 12
	protected override bool Match(XmlNode node) { }
}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf : DocumentXPathNodeIterator_ElemChildren // TypeDefIndex: 12011
{
	// Methods

	// RVA: 0x200C550 Offset: 0x200B750 VA: 0x18200C550
	internal void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x200C590 Offset: 0x200B790 VA: 0x18200C590
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf other) { }

	// RVA: 0x200C120 Offset: 0x200B320 VA: 0x18200C120 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x200C190 Offset: 0x200B390 VA: 0x18200C190 Slot: 7
	public override bool MoveNext() { }
}

// Namespace: System.Xml
internal class DomNameTable // TypeDefIndex: 12012
{
	// Fields
	private XmlName[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28

	// Methods

	// RVA: 0x200D210 Offset: 0x200C410 VA: 0x18200D210
	public void .ctor(XmlDocument document) { }

	// RVA: 0x200CF80 Offset: 0x200C180 VA: 0x18200CF80
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x200CBD0 Offset: 0x200BDD0 VA: 0x18200CBD0
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x200D0E0 Offset: 0x200C2E0 VA: 0x18200D0E0
	private void Grow() { }
}

// Namespace: System.Xml
internal class XPathNodeList : XmlNodeList // TypeDefIndex: 12013
{
	// Fields
	private List<XmlNode> list; // 0x10
	private XPathNodeIterator nodeIterator; // 0x18
	private bool done; // 0x20
	private static readonly object[] nullparams; // 0x0

	// Properties
	public override int Count { get; }

	// Methods

	// RVA: 0x200D890 Offset: 0x200CA90 VA: 0x18200D890
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x200D910 Offset: 0x200CB10 VA: 0x18200D910 Slot: 7
	public override int get_Count() { }

	// RVA: 0x200D590 Offset: 0x200C790 VA: 0x18200D590
	private XmlNode GetNode(XPathNavigator n) { }

	// RVA: 0x200D740 Offset: 0x200C940 VA: 0x18200D740
	internal int ReadUntil(int index) { }

	// RVA: 0x200D6A0 Offset: 0x200C8A0 VA: 0x18200D6A0 Slot: 6
	public override XmlNode Item(int index) { }

	// RVA: 0x200D530 Offset: 0x200C730 VA: 0x18200D530 Slot: 8
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x200D840 Offset: 0x200CA40 VA: 0x18200D840
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class XmlNodeListEnumerator : IEnumerator // TypeDefIndex: 12014
{
	// Fields
	private XPathNodeList list; // 0x10
	private int index; // 0x18
	private bool valid; // 0x1C

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x2016C60 Offset: 0x2015E60 VA: 0x182016C60
	public void .ctor(XPathNodeList list) { }

	// RVA: 0x112DE90 Offset: 0x112D090 VA: 0x18112DE90 Slot: 6
	public void Reset() { }

	// RVA: 0x2016BF0 Offset: 0x2015DF0 VA: 0x182016BF0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2016CA0 Offset: 0x2015EA0 VA: 0x182016CA0 Slot: 5
	public object get_Current() { }
}

// Namespace: System.Xml
public class XmlAttribute : XmlNode // TypeDefIndex: 12015
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Properties
	internal int LocalNameHash { get; }
	internal XmlName XmlName { get; set; }
	public override XmlNode ParentNode { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string Value { get; set; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerText { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public virtual bool Specified { get; }
	public virtual XmlElement OwnerElement { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }
	internal override XmlSpace XmlSpace { get; }
	internal override string XmlLang { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal override string XPLocalName { get; }
	internal bool IsNamespace { get; }

	// Methods

	// RVA: 0x200FCE0 Offset: 0x200EEE0 VA: 0x18200FCE0
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0x200FED0 Offset: 0x200F0D0 VA: 0x18200FED0
	internal int get_LocalNameHash() { }

	// RVA: 0x200FC90 Offset: 0x200EE90 VA: 0x18200FC90
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal XmlName get_XmlName() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x200F510 Offset: 0x200E710 VA: 0x18200F510 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x200FEF0 Offset: 0x200F0F0 VA: 0x18200FEF0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x886090 Offset: 0x885290 VA: 0x180886090 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x8860D0 Offset: 0x8852D0 VA: 0x1808860D0 Slot: 35
	public override string get_NamespaceURI() { }

	// RVA: 0x18A59A0 Offset: 0x18A4BA0 VA: 0x1818A59A0 Slot: 36
	public override string get_Prefix() { }

	// RVA: 0x2010270 Offset: 0x200F470 VA: 0x182010270 Slot: 37
	public override void set_Prefix(string value) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x8860B0 Offset: 0x8852B0 VA: 0x1808860B0 Slot: 17
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1728820 Offset: 0x1727A20 VA: 0x181728820 Slot: 9
	public override string get_Value() { }

	// RVA: 0x19A6F50 Offset: 0x19A6150 VA: 0x1819A6F50 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 43
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x2010170 Offset: 0x200F370 VA: 0x182010170 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x200F750 Offset: 0x200E950 VA: 0x18200F750
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0x200F9F0 Offset: 0x200EBF0 VA: 0x18200F9F0
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x200F2F0 Offset: 0x200E4F0 VA: 0x18200F2F0 Slot: 28
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x200F740 Offset: 0x200E940 VA: 0x18200F740 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 61
	public virtual bool get_Specified() { }

	// RVA: 0x200F6A0 Offset: 0x200E8A0 VA: 0x18200F6A0 Slot: 23
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x200F600 Offset: 0x200E800 VA: 0x18200F600 Slot: 24
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x200F970 Offset: 0x200EB70 VA: 0x18200F970 Slot: 25
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x200F8F0 Offset: 0x200EAF0 VA: 0x18200F8F0 Slot: 26
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x200F490 Offset: 0x200E690 VA: 0x18200F490 Slot: 27
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x200FF10 Offset: 0x200F110 VA: 0x18200FF10 Slot: 62
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0x20101E0 Offset: 0x200F3E0 VA: 0x1820101E0 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x200FBB0 Offset: 0x200EDB0 VA: 0x18200FBB0 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x200FB30 Offset: 0x200ED30 VA: 0x18200FB30 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x200FDF0 Offset: 0x200EFF0 VA: 0x18200FDF0 Slot: 44
	public override string get_BaseURI() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 49
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x2010100 Offset: 0x200F300 VA: 0x182010100 Slot: 55
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0x2010060 Offset: 0x200F260 VA: 0x182010060 Slot: 56
	internal override string get_XmlLang() { }

	// RVA: 0x2010020 Offset: 0x200F220 VA: 0x182010020 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x200FF90 Offset: 0x200F190 VA: 0x18200FF90 Slot: 58
	internal override string get_XPLocalName() { }

	// RVA: 0x200FE90 Offset: 0x200F090 VA: 0x18200FE90
	internal bool get_IsNamespace() { }
}

// Namespace: System.Xml
[DefaultMember("ItemOf")]
public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable // TypeDefIndex: 12016
{
	// Properties
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x200F0B0 Offset: 0x200E2B0 VA: 0x18200F0B0
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0x200F1B0 Offset: 0x200E3B0 VA: 0x18200F1B0
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0x200EF40 Offset: 0x200E140 VA: 0x18200EF40
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0x200DE50 Offset: 0x200D050 VA: 0x18200DE50
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0x200EC50 Offset: 0x200DE50 VA: 0x18200EC50 Slot: 6
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x200DB80 Offset: 0x200CD80 VA: 0x18200DB80
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0x200EAD0 Offset: 0x200DCD0 VA: 0x18200EAD0
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0x200E530 Offset: 0x200D730 VA: 0x18200E530
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0x200E440 Offset: 0x200D640 VA: 0x18200E440
	public void RemoveAll() { }

	// RVA: 0x200EEA0 Offset: 0x200E0A0 VA: 0x18200EEA0 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x200EF30 Offset: 0x200E130 VA: 0x18200EF30 Slot: 14
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x200D970 Offset: 0x200CB70 VA: 0x18200D970 Slot: 9
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0x200E000 Offset: 0x200D200 VA: 0x18200E000 Slot: 12
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0x200E730 Offset: 0x200D930 VA: 0x18200E730 Slot: 11
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x200DD70 Offset: 0x200CF70 VA: 0x18200DD70
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0x200E0C0 Offset: 0x200D2C0 VA: 0x18200E0C0
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x200E930 Offset: 0x200DB30 VA: 0x18200E930
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x200E610 Offset: 0x200D810 VA: 0x18200E610
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0x200E320 Offset: 0x200D520 VA: 0x18200E320
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0x200EB70 Offset: 0x200DD70 VA: 0x18200EB70
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0x200E260 Offset: 0x200D460 VA: 0x18200E260
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }
}

// Namespace: System.Xml
public class XmlCDataSection : XmlCharacterData // TypeDefIndex: 12017
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal override bool IsText { get; }
	public override XmlNode PreviousText { get; }

	// Methods

	// RVA: 0x2010400 Offset: 0x200F600 VA: 0x182010400
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x2010430 Offset: 0x200F630 VA: 0x182010430 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2010430 Offset: 0x200F630 VA: 0x182010430 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2010460 Offset: 0x200F660 VA: 0x182010460 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x2010340 Offset: 0x200F540 VA: 0x182010340 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x20103B0 Offset: 0x200F5B0 VA: 0x1820103B0 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 59
	internal override bool get_IsText() { }

	// RVA: 0x2010500 Offset: 0x200F700 VA: 0x182010500 Slot: 60
	public override XmlNode get_PreviousText() { }
}

// Namespace: System.Xml
public abstract class XmlCharacterData : XmlLinkedNode // TypeDefIndex: 12018
{
	// Fields
	private string data; // 0x20

	// Properties
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public virtual string Data { get; set; }

	// Methods

	// RVA: 0x2010400 Offset: 0x200F600 VA: 0x182010400
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x20106B0 Offset: 0x200F8B0 VA: 0x1820106B0 Slot: 9
	public override string get_Value() { }

	// RVA: 0x20107B0 Offset: 0x200F9B0 VA: 0x1820107B0 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x75AB00 Offset: 0x759D00 VA: 0x18075AB00 Slot: 40
	public override string get_InnerText() { }

	// RVA: 0x2010790 Offset: 0x200F990 VA: 0x182010790 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x2010660 Offset: 0x200F860 VA: 0x182010660 Slot: 61
	public virtual string get_Data() { }

	// RVA: 0x20106D0 Offset: 0x200F8D0 VA: 0x1820106D0 Slot: 62
	public virtual void set_Data(string value) { }

	// RVA: 0x2010550 Offset: 0x200F750 VA: 0x182010550
	internal bool CheckOnData(string data) { }

	// RVA: 0x2010580 Offset: 0x200F780 VA: 0x182010580
	internal bool DecideXPNodeTypeForTextNodes(XmlNode node, ref XPathNodeType xnt) { }
}

// Namespace: System.Xml
internal sealed class XmlChildEnumerator : IEnumerator // TypeDefIndex: 12019
{
	// Fields
	internal XmlNode container; // 0x10
	internal XmlNode child; // 0x18
	internal bool isFirst; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	internal XmlNode Current { get; }

	// Methods

	// RVA: 0x2010920 Offset: 0x200FB20 VA: 0x182010920
	internal void .ctor(XmlNode container) { }

	// RVA: 0x20107D0 Offset: 0x200F9D0 VA: 0x1820107D0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x20107D0 Offset: 0x200F9D0 VA: 0x1820107D0
	internal bool MoveNext() { }

	// RVA: 0x2010850 Offset: 0x200FA50 VA: 0x182010850 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2010890 Offset: 0x200FA90 VA: 0x182010890 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2010890 Offset: 0x200FA90 VA: 0x182010890
	internal XmlNode get_Current() { }
}

// Namespace: System.Xml
internal class XmlChildNodes : XmlNodeList // TypeDefIndex: 12020
{
	// Fields
	private XmlNode container; // 0x10

	// Properties
	public override int Count { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(XmlNode container) { }

	// RVA: 0x2010A60 Offset: 0x200FC60 VA: 0x182010A60 Slot: 6
	public override XmlNode Item(int i) { }

	// RVA: 0x2010AD0 Offset: 0x200FCD0 VA: 0x182010AD0 Slot: 7
	public override int get_Count() { }

	// RVA: 0x2010970 Offset: 0x200FB70 VA: 0x182010970 Slot: 8
	public override IEnumerator GetEnumerator() { }
}

// Namespace: System.Xml
public class XmlComment : XmlCharacterData // TypeDefIndex: 12021
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	internal override XPathNodeType XPNodeType { get; }

	// Methods

	// RVA: 0x2010400 Offset: 0x200F600 VA: 0x182010400
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0x2010BF0 Offset: 0x200FDF0 VA: 0x182010BF0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2010BF0 Offset: 0x200FDF0 VA: 0x182010BF0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2010B30 Offset: 0x200FD30 VA: 0x182010B30 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x2010BA0 Offset: 0x200FDA0 VA: 0x182010BA0 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }
}

// Namespace: System.Xml
public class XmlDeclaration : XmlLinkedNode // TypeDefIndex: 12022
{
	// Fields
	private string version; // 0x20
	private string encoding; // 0x28
	private string standalone; // 0x30

	// Properties
	public string Version { get; set; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x2010D70 Offset: 0x200FF70 VA: 0x182010D70
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Version() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_Version(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Encoding() { }

	// RVA: 0x2011150 Offset: 0x2010350 VA: 0x182011150
	public void set_Encoding(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Standalone() { }

	// RVA: 0x20114A0 Offset: 0x20106A0 VA: 0x1820114A0
	public void set_Standalone(string value) { }

	// RVA: 0x1728820 Offset: 0x1727A20 VA: 0x181728820 Slot: 9
	public override string get_Value() { }

	// RVA: 0x19A6F50 Offset: 0x19A6150 VA: 0x1819A6F50 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x2010FC0 Offset: 0x20101C0 VA: 0x182010FC0 Slot: 40
	public override string get_InnerText() { }

	// RVA: 0x20111B0 Offset: 0x20103B0 VA: 0x1820111B0 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x2011120 Offset: 0x2010320 VA: 0x182011120 Slot: 8
	public override string get_Name() { }

	// RVA: 0x6D85F0 Offset: 0x6D77F0 VA: 0x1806D85F0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x18A5990 Offset: 0x18A4B90 VA: 0x1818A5990 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2010C20 Offset: 0x200FE20 VA: 0x182010C20 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x2010CF0 Offset: 0x200FEF0 VA: 0x182010CF0 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x2010C80 Offset: 0x200FE80 VA: 0x182010C80
	private bool IsValidXmlVersion(string ver) { }
}

// Namespace: System.Xml
public class XmlDocument : XmlNode // TypeDefIndex: 12023
{
	// Fields
	private XmlImplementation implementation; // 0x18
	private DomNameTable domNameTable; // 0x20
	private XmlLinkedNode lastChild; // 0x28
	private XmlNamedNodeMap entities; // 0x30
	private Hashtable htElementIdMap; // 0x38
	private Hashtable htElementIDAttrDecl; // 0x40
	private SchemaInfo schemaInfo; // 0x48
	private XmlSchemaSet schemas; // 0x50
	private bool reportValidity; // 0x58
	private bool actualLoadingStatus; // 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; // 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; // 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; // 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; // 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; // 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; // 0x88
	internal bool fEntRefNodesPresent; // 0x90
	internal bool fCDataNodesPresent; // 0x91
	private bool preserveWhitespace; // 0x92
	private bool isLoading; // 0x93
	internal string strDocumentName; // 0x98
	internal string strDocumentFragmentName; // 0xA0
	internal string strCommentName; // 0xA8
	internal string strTextName; // 0xB0
	internal string strCDataSectionName; // 0xB8
	internal string strEntityName; // 0xC0
	internal string strID; // 0xC8
	internal string strXmlns; // 0xD0
	internal string strXml; // 0xD8
	internal string strSpace; // 0xE0
	internal string strLang; // 0xE8
	internal string strEmpty; // 0xF0
	internal string strNonSignificantWhitespaceName; // 0xF8
	internal string strSignificantWhitespaceName; // 0x100
	internal string strReservedXmlns; // 0x108
	internal string strReservedXml; // 0x110
	internal string baseURI; // 0x118
	private XmlResolver resolver; // 0x120
	internal bool bSetResolver; // 0x128
	internal object objLock; // 0x130
	private XmlAttribute namespaceXml; // 0x138
	internal static EmptyEnumerator EmptyEnumerator; // 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; // 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; // 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; // 0x18

	// Properties
	internal SchemaInfo DtdSchemaInfo { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public virtual XmlDocumentType DocumentType { get; }
	internal virtual XmlDeclaration Declaration { get; }
	public XmlImplementation Implementation { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public XmlElement DocumentElement { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlDocument OwnerDocument { get; }
	public XmlSchemaSet Schemas { set; }
	internal bool CanReportValidity { get; }
	internal bool HasSetResolver { get; }
	public virtual XmlResolver XmlResolver { set; }
	public XmlNameTable NameTable { get; }
	public override bool IsReadOnly { get; }
	internal XmlNamedNodeMap Entities { get; set; }
	internal bool IsLoading { get; set; }
	internal bool ActualLoadingStatus { get; }
	public override string InnerText { set; }
	public override string InnerXml { set; }
	internal string Version { get; }
	internal string Encoding { get; }
	internal string Standalone { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string BaseURI { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal bool HasEntityReferences { get; }
	internal XmlAttribute NamespaceXml { get; }

	// Methods

	// RVA: 0x2016020 Offset: 0x2015220 VA: 0x182016020
	public void .ctor() { }

	// RVA: 0x2016080 Offset: 0x2015280 VA: 0x182016080
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x20160F0 Offset: 0x20152F0 VA: 0x1820160F0
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0x20123E0 Offset: 0x20115E0 VA: 0x1820123E0
	internal static void CheckName(string name) { }

	// RVA: 0x2011D40 Offset: 0x2010F40 VA: 0x182011D40
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x20141B0 Offset: 0x20133B0 VA: 0x1820141B0
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x20115E0 Offset: 0x20107E0 VA: 0x1820115E0
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x2011C60 Offset: 0x2010E60 VA: 0x182011C60
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0x2013D70 Offset: 0x2012F70 VA: 0x182013D70
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0x2013FA0 Offset: 0x20131A0 VA: 0x182013FA0
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0x2013710 Offset: 0x2012910 VA: 0x182013710
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0x2011A50 Offset: 0x2010C50 VA: 0x182011A50
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0x20157C0 Offset: 0x20149C0 VA: 0x1820157C0
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0x20124B0 Offset: 0x20116B0 VA: 0x1820124B0 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x563540 Offset: 0x562740 VA: 0x180563540 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x20166A0 Offset: 0x20158A0 VA: 0x1820166A0 Slot: 61
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0x2016540 Offset: 0x2015740 VA: 0x182016540 Slot: 62
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public XmlImplementation get_Implementation() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50 Slot: 8
	public override string get_Name() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x20165F0 Offset: 0x20157F0 VA: 0x1820165F0
	public XmlElement get_DocumentElement() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 17
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30
	internal bool get_CanReportValidity() { }

	// RVA: 0x7897F0 Offset: 0x7889F0 VA: 0x1807897F0
	internal bool get_HasSetResolver() { }

	// RVA: 0x53DA70 Offset: 0x53CC70 VA: 0x18053DA70
	internal XmlResolver GetResolver() { }

	// RVA: 0x2016AB0 Offset: 0x2015CB0 VA: 0x182016AB0 Slot: 63
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x2014DD0 Offset: 0x2013FD0 VA: 0x182014DD0 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x20143A0 Offset: 0x20135A0 VA: 0x1820143A0
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x2014320 Offset: 0x2013520 VA: 0x182014320
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x2012220 Offset: 0x2011420 VA: 0x182012220 Slot: 30
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x20120D0 Offset: 0x20112D0 VA: 0x1820120D0 Slot: 31
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x2012630 Offset: 0x2011830 VA: 0x182012630
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0x2015BA0 Offset: 0x2014DA0 VA: 0x182015BA0
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	// RVA: 0x2012800 Offset: 0x2011A00 VA: 0x182012800 Slot: 64
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0x2012870 Offset: 0x2011A70 VA: 0x182012870 Slot: 65
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0x20129D0 Offset: 0x2011BD0 VA: 0x1820129D0 Slot: 66
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x2012970 Offset: 0x2011B70 VA: 0x182012970 Slot: 67
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0x2012B20 Offset: 0x2011D20 VA: 0x182012B20
	public XmlElement CreateElement(string name) { }

	// RVA: 0x2011720 Offset: 0x2010920 VA: 0x182011720
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0x2014090 Offset: 0x2013290 VA: 0x182014090
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0x2015590 Offset: 0x2014790 VA: 0x182015590
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x2012CA0 Offset: 0x2011EA0 VA: 0x182012CA0 Slot: 68
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0x2012F50 Offset: 0x2012150 VA: 0x182012F50 Slot: 69
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x2013120 Offset: 0x2012320 VA: 0x182013120 Slot: 70
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x2013040 Offset: 0x2012240 VA: 0x182013040 Slot: 71
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0x2012FD0 Offset: 0x20121D0 VA: 0x182012FD0 Slot: 72
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0x2012F30 Offset: 0x2012130 VA: 0x182012F30 Slot: 7
	public override XPathNavigator CreateNavigator() { }

	// RVA: 0x2012D10 Offset: 0x2011F10 VA: 0x182012D10 Slot: 73
	protected internal virtual XPathNavigator CreateNavigator(XmlNode node) { }

	// RVA: 0x2014DB0 Offset: 0x2013FB0 VA: 0x182014DB0
	internal static bool IsTextNode(XmlNodeType nt) { }

	// RVA: 0x20153A0 Offset: 0x20145A0 VA: 0x1820153A0
	private XmlNode NormalizeText(XmlNode n) { }

	// RVA: 0x20130B0 Offset: 0x20122B0 VA: 0x1820130B0 Slot: 74
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0x2012750 Offset: 0x2011950 VA: 0x182012750
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0x2012A70 Offset: 0x2011C70 VA: 0x182012A70
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0x2013400 Offset: 0x2012600 VA: 0x182013400 Slot: 75
	public virtual XmlElement GetElementById(string elementId) { }

	// RVA: 0x20146C0 Offset: 0x20138C0 VA: 0x1820146C0
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0x2014490 Offset: 0x2013690 VA: 0x182014490
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0x2014600 Offset: 0x2013800 VA: 0x182014600
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0x18A59A0 Offset: 0x18A4BA0 VA: 0x1818A59A0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x2012590 Offset: 0x2011790 VA: 0x182012590 Slot: 76
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x20128E0 Offset: 0x2011AE0 VA: 0x1820128E0 Slot: 77
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x2012BD0 Offset: 0x2011DD0 VA: 0x182012BD0 Slot: 78
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 39
	public override bool get_IsReadOnly() { }

	// RVA: 0x2016770 Offset: 0x2015970 VA: 0x182016770
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0x1DB4E20 Offset: 0x1DB4020 VA: 0x181DB4E20
	internal bool get_IsLoading() { }

	// RVA: 0x2005D20 Offset: 0x2004F20 VA: 0x182005D20
	internal void set_IsLoading(bool value) { }

	// RVA: 0x7725E0 Offset: 0x7717E0 VA: 0x1807725E0
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0x20156F0 Offset: 0x20148F0 VA: 0x1820156F0 Slot: 79
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0x2015C40 Offset: 0x2014E40 VA: 0x182015C40
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0x2015120 Offset: 0x2014320 VA: 0x182015120 Slot: 80
	public virtual void Load(Stream inStream) { }

	// RVA: 0x2015270 Offset: 0x2014470 VA: 0x182015270 Slot: 81
	public virtual void Load(XmlReader reader) { }

	// RVA: 0x2014FA0 Offset: 0x20141A0 VA: 0x182014FA0 Slot: 82
	public virtual void LoadXml(string xml) { }

	// RVA: 0x2016A30 Offset: 0x2015C30 VA: 0x182016A30 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x2016A90 Offset: 0x2015C90 VA: 0x182016A90 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x2015930 Offset: 0x2014B30 VA: 0x182015930 Slot: 83
	public virtual void Save(XmlWriter w) { }

	// RVA: 0x2015F00 Offset: 0x2015100 VA: 0x182015F00 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x2015CB0 Offset: 0x2014EB0 VA: 0x182015CB0 Slot: 46
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0x2013C70 Offset: 0x2012E70 VA: 0x182013C70 Slot: 52
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x2013FC0 Offset: 0x20131C0 VA: 0x182013FC0
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0x2012050 Offset: 0x2011250 VA: 0x182012050 Slot: 53
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x2011D70 Offset: 0x2010F70 VA: 0x182011D70 Slot: 54
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x20131B0 Offset: 0x20123B0 VA: 0x1820131B0
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x2016A00 Offset: 0x2015C00 VA: 0x182016A00
	internal string get_Version() { }

	// RVA: 0x2016740 Offset: 0x2015940 VA: 0x182016740
	internal string get_Encoding() { }

	// RVA: 0x20169D0 Offset: 0x2015BD0 VA: 0x1820169D0
	internal string get_Standalone() { }

	// RVA: 0x2013B60 Offset: 0x2012D60 VA: 0x182013B60
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0x20168B0 Offset: 0x2015AB0 VA: 0x1820168B0 Slot: 43
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x6ED510 Offset: 0x6EC710 VA: 0x1806ED510 Slot: 44
	public override string get_BaseURI() { }

	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0x2011DF0 Offset: 0x2010FF0 VA: 0x182011DF0 Slot: 28
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x5C4DE0 Offset: 0x5C3FE0 VA: 0x1805C4DE0
	internal bool get_HasEntityReferences() { }

	// RVA: 0x20167E0 Offset: 0x20159E0 VA: 0x1820167E0
	internal XmlAttribute get_NamespaceXml() { }

	// RVA: 0x2015F20 Offset: 0x2015120 VA: 0x182015F20
	private static void .cctor() { }
}

// Namespace: System.Xml
public class XmlDocumentFragment : XmlNode // TypeDefIndex: 12024
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string InnerXml { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	internal override XPathNodeType XPNodeType { get; }

	// Methods

	// RVA: 0x202CEF0 Offset: 0x202C0F0 VA: 0x18202CEF0
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x202CF80 Offset: 0x202C180 VA: 0x18202CF80 Slot: 8
	public override string get_Name() { }

	// RVA: 0x202CF80 Offset: 0x202C180 VA: 0x18202CF80 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x179EBA0 Offset: 0x179DDA0 VA: 0x18179EBA0 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x202CFB0 Offset: 0x202C1B0 VA: 0x18202CFB0 Slot: 17
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x202D040 Offset: 0x202C240 VA: 0x18202D040 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x202CB00 Offset: 0x202BD00 VA: 0x18202CB00 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x202CBA0 Offset: 0x202BDA0 VA: 0x18202CBA0 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x202CA00 Offset: 0x202BC00 VA: 0x18202CA00 Slot: 31
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x202CA80 Offset: 0x202BC80 VA: 0x18202CA80 Slot: 30
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x2015F00 Offset: 0x2015100 VA: 0x182015F00 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x202CC60 Offset: 0x202BE60 VA: 0x18202CC60 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }
}

// Namespace: System.Xml
public class XmlDocumentType : XmlLinkedNode // TypeDefIndex: 12025
{
	// Fields
	private string name; // 0x20
	private string publicId; // 0x28
	private string systemId; // 0x30
	private string internalSubset; // 0x38
	private bool namespaces; // 0x40
	private XmlNamedNodeMap entities; // 0x48
	private XmlNamedNodeMap notations; // 0x50
	private SchemaInfo schemaInfo; // 0x58

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public XmlNamedNodeMap Entities { get; }
	public XmlNamedNodeMap Notations { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string InternalSubset { get; }
	internal bool ParseWithNamespaces { get; }
	internal SchemaInfo DtdSchemaInfo { get; set; }

	// Methods

	// RVA: 0x202D190 Offset: 0x202C390 VA: 0x18202D190
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 8
	public override string get_Name() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x202D0E0 Offset: 0x202C2E0 VA: 0x18202D0E0 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 39
	public override bool get_IsReadOnly() { }

	// RVA: 0x202D320 Offset: 0x202C520 VA: 0x18202D320
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x202D390 Offset: 0x202C590 VA: 0x18202D390
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_PublicId() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_SystemId() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_InternalSubset() { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x202D140 Offset: 0x202C340 VA: 0x18202D140 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	internal void set_DtdSchemaInfo(SchemaInfo value) { }
}

// Namespace: System.Xml
public class XmlElement : XmlLinkedNode // TypeDefIndex: 12026
{
	// Fields
	private XmlName name; // 0x20
	private XmlAttributeCollection attributes; // 0x28
	private XmlLinkedNode lastChild; // 0x30

	// Properties
	internal XmlName XmlName { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	internal override bool IsContainer { get; }
	public bool IsEmpty { get; set; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlAttributeCollection Attributes { get; }
	public virtual bool HasAttributes { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerXml { set; }
	public override string InnerText { get; set; }
	public override XmlNode NextSibling { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal override string XPLocalName { get; }

	// Methods

	// RVA: 0x202E850 Offset: 0x202DA50 VA: 0x18202E850
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x202E710 Offset: 0x202D910 VA: 0x18202E710
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal XmlName get_XmlName() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x202D5A0 Offset: 0x202C7A0 VA: 0x18202D5A0 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x202EB70 Offset: 0x202DD70 VA: 0x18202EB70 Slot: 8
	public override string get_Name() { }

	// RVA: 0x3D99F0 Offset: 0x3D8BF0 VA: 0x1803D99F0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x1B643F0 Offset: 0x1B635F0 VA: 0x181B643F0 Slot: 35
	public override string get_NamespaceURI() { }

	// RVA: 0x3D9A10 Offset: 0x3D8C10 VA: 0x1803D9A10 Slot: 36
	public override string get_Prefix() { }

	// RVA: 0x202EE10 Offset: 0x202E010 VA: 0x18202EE10 Slot: 37
	public override void set_Prefix(string value) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x86DB10 Offset: 0x86CD10 VA: 0x18086DB10 Slot: 17
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x202D400 Offset: 0x202C600 VA: 0x18202D400 Slot: 28
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x202EB50 Offset: 0x202DD50 VA: 0x18202EB50
	public bool get_IsEmpty() { }

	// RVA: 0x202EDD0 Offset: 0x202DFD0 VA: 0x18202EDD0
	public void set_IsEmpty(bool value) { }

	// RVA: 0x202EB60 Offset: 0x202DD60 VA: 0x18202EB60 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x202DD00 Offset: 0x202CF00 VA: 0x18202DD00 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x202E9E0 Offset: 0x202DBE0 VA: 0x18202E9E0 Slot: 16
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x202EB00 Offset: 0x202DD00 VA: 0x18202EB00 Slot: 61
	public virtual bool get_HasAttributes() { }

	// RVA: 0x202DBA0 Offset: 0x202CDA0 VA: 0x18202DBA0 Slot: 62
	public virtual string GetAttribute(string name) { }

	// RVA: 0x202E040 Offset: 0x202D240 VA: 0x18202E040 Slot: 63
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x202DAA0 Offset: 0x202CCA0 VA: 0x18202DAA0 Slot: 64
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x202DEF0 Offset: 0x202D0F0 VA: 0x18202DEF0 Slot: 65
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x202DC30 Offset: 0x202CE30 VA: 0x18202DC30 Slot: 66
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x202E130 Offset: 0x202D330 VA: 0x18202E130 Slot: 67
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x202DB10 Offset: 0x202CD10 VA: 0x18202DB10 Slot: 68
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x202DDF0 Offset: 0x202CFF0 VA: 0x18202DDF0 Slot: 69
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x202DCD0 Offset: 0x202CED0 VA: 0x18202DCD0 Slot: 70
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x202E5F0 Offset: 0x202D7F0 VA: 0x18202E5F0 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x202E270 Offset: 0x202D470 VA: 0x18202E270
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x202E4B0 Offset: 0x202D6B0 VA: 0x18202E4B0
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0x200FB30 Offset: 0x200ED30 VA: 0x18200FB30 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x202DD60 Offset: 0x202CF60 VA: 0x18202DD60 Slot: 71
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x202DDC0 Offset: 0x202CFC0 VA: 0x18202DDC0 Slot: 47
	public override void RemoveAll() { }

	// RVA: 0x202DDB0 Offset: 0x202CFB0 VA: 0x18202DDB0
	internal void RemoveAllChildren() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 43
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x202ECE0 Offset: 0x202DEE0 VA: 0x18202ECE0 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x202EB40 Offset: 0x202DD40 VA: 0x18202EB40 Slot: 40
	public override string get_InnerText() { }

	// RVA: 0x202EBF0 Offset: 0x202DDF0 VA: 0x18202EBF0 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x202EB90 Offset: 0x202DD90 VA: 0x18202EB90 Slot: 15
	public override XmlNode get_NextSibling() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 49
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x202EBD0 Offset: 0x202DDD0 VA: 0x18202EBD0 Slot: 58
	internal override string get_XPLocalName() { }
}

// Namespace: System.Xml
public class XmlEntity : XmlNode // TypeDefIndex: 12027
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string notationName; // 0x28
	private string name; // 0x30
	private string unparsedReplacementStr; // 0x38
	private string baseURI; // 0x40
	private XmlLinkedNode lastChild; // 0x48
	private bool childrenFoliating; // 0x50

	// Properties
	public override bool IsReadOnly { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string InnerText { get; set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlNodeType NodeType { get; }
	public string SystemId { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x202F7B0 Offset: 0x202E9B0 VA: 0x18202F7B0
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x202F730 Offset: 0x202E930 VA: 0x18202F730 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 39
	public override bool get_IsReadOnly() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 8
	public override string get_Name() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x202EB40 Offset: 0x202DD40 VA: 0x18202EB40 Slot: 40
	public override string get_InnerText() { }

	// RVA: 0x202F9B0 Offset: 0x202EBB0 VA: 0x18202F9B0 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x202F8B0 Offset: 0x202EAB0 VA: 0x18202F8B0 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x202F790 Offset: 0x202E990 VA: 0x18202F790 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x16F8530 Offset: 0x16F7730 VA: 0x1816F8530 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_SystemId() { }

	// RVA: 0x202FA10 Offset: 0x202EC10 VA: 0x18202FA10 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 44
	public override string get_BaseURI() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void SetBaseURI(string inBaseURI) { }
}

// Namespace: System.Xml
public class XmlEntityReference : XmlLinkedNode // TypeDefIndex: 12028
{
	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override string BaseURI { get; }
	internal string ChildBaseURI { get; }

	// Methods

	// RVA: 0x202F3B0 Offset: 0x202E5B0 VA: 0x18202F3B0
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 8
	public override string get_Name() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public override string get_Value() { }

	// RVA: 0x202F6D0 Offset: 0x202E8D0 VA: 0x18202F6D0 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x202EEE0 Offset: 0x202E0E0 VA: 0x18202EEE0 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 39
	public override bool get_IsReadOnly() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x202F010 Offset: 0x202E210 VA: 0x18202F010 Slot: 49
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x202EFF0 Offset: 0x202E1F0 VA: 0x18202EFF0 Slot: 50
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x202DD00 Offset: 0x202CF00 VA: 0x18202DD00 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x202F370 Offset: 0x202E570 VA: 0x18202F370 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x202F0E0 Offset: 0x202E2E0 VA: 0x18202F0E0 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x202F510 Offset: 0x202E710 VA: 0x18202F510 Slot: 44
	public override string get_BaseURI() { }

	// RVA: 0x202EF30 Offset: 0x202E130 VA: 0x18202EF30
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x202F550 Offset: 0x202E750 VA: 0x18202F550
	internal string get_ChildBaseURI() { }
}

// Namespace: System.Xml
public enum XmlNodeChangedAction // TypeDefIndex: 12029
{
	// Fields
	public int value__; // 0x0
	public const XmlNodeChangedAction Insert = 0;
	public const XmlNodeChangedAction Remove = 1;
	public const XmlNodeChangedAction Change = 2;
}

// Namespace: System.Xml
public class XmlImplementation // TypeDefIndex: 12030
{
	// Fields
	private XmlNameTable nameTable; // 0x10

	// Properties
	internal XmlNameTable NameTable { get; }

	// Methods

	// RVA: 0x202FAD0 Offset: 0x202ECD0 VA: 0x18202FAD0
	public void .ctor() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x202FA70 Offset: 0x202EC70 VA: 0x18202FA70 Slot: 4
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal XmlNameTable get_NameTable() { }
}

// Namespace: System.Xml
public abstract class XmlLinkedNode : XmlNode // TypeDefIndex: 12031
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Properties
	public override XmlNode PreviousSibling { get; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x202FB70 Offset: 0x202ED70 VA: 0x18202FB70
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x202FC60 Offset: 0x202EE60 VA: 0x18202FC60 Slot: 14
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x202FC00 Offset: 0x202EE00 VA: 0x18202FC00 Slot: 15
	public override XmlNode get_NextSibling() { }
}

// Namespace: System.Xml
internal class XmlLoader // TypeDefIndex: 12032
{
	// Fields
	private XmlDocument doc; // 0x10
	private XmlReader reader; // 0x18
	private bool preserveWhitespace; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2033D40 Offset: 0x2032F40 VA: 0x182033D40
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x2031B30 Offset: 0x2030D30 VA: 0x182031B30
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x2034820 Offset: 0x2033A20 VA: 0x182034820
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x2033620 Offset: 0x2032820 VA: 0x182033620
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x2031050 Offset: 0x2030250 VA: 0x182031050
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x2031940 Offset: 0x2030B40 VA: 0x182031940
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x20313F0 Offset: 0x20305F0 VA: 0x1820313F0
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x2032AE0 Offset: 0x2031CE0 VA: 0x182032AE0
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x2031730 Offset: 0x2030930 VA: 0x182031730
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x2031BB0 Offset: 0x2030DB0 VA: 0x182031BB0
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x2032E00 Offset: 0x2032000 VA: 0x182032E00
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x2030E90 Offset: 0x2030090 VA: 0x182030E90
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x20342F0 Offset: 0x20334F0 VA: 0x1820342F0
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x2034040 Offset: 0x2033240 VA: 0x182034040
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x2031E00 Offset: 0x2031000 VA: 0x182031E00
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x20305F0 Offset: 0x202F7F0 VA: 0x1820305F0
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x2034370 Offset: 0x2033570 VA: 0x182034370
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x2032D60 Offset: 0x2031F60 VA: 0x182032D60
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x2032D40 Offset: 0x2031F40 VA: 0x182032D40
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x20349C0 Offset: 0x2033BC0 VA: 0x1820349C0
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x202FF50 Offset: 0x202F150 VA: 0x18202FF50
	private string EntitizeName(string name) { }

	// RVA: 0x2030540 Offset: 0x202F740 VA: 0x182030540
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x202FFA0 Offset: 0x202F1A0 VA: 0x18202FFA0
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x202FCF0 Offset: 0x202EEF0 VA: 0x18202FCF0
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x20345D0 Offset: 0x20337D0 VA: 0x1820345D0
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	// RVA: 0x2034D10 Offset: 0x2033F10 VA: 0x182034D10
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }
}

// Namespace: System.Xml
internal class XmlName : IXmlSchemaInfo // TypeDefIndex: 12033
{
	// Fields
	private string prefix; // 0x10
	private string localName; // 0x18
	private string ns; // 0x20
	private string name; // 0x28
	private int hashCode; // 0x30
	internal XmlDocument ownerDoc; // 0x38
	internal XmlName next; // 0x40

	// Properties
	public string LocalName { get; }
	public string NamespaceURI { get; }
	public string Prefix { get; }
	public int HashCode { get; }
	public XmlDocument OwnerDocument { get; }
	public string Name { get; }
	public virtual XmlSchemaValidity Validity { get; }
	public virtual bool IsDefault { get; }
	public virtual bool IsNil { get; }
	public virtual XmlSchemaSimpleType MemberType { get; }
	public virtual XmlSchemaType SchemaType { get; }
	public virtual XmlSchemaElement SchemaElement { get; }
	public virtual XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x2035330 Offset: 0x2034530 VA: 0x182035330
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x20355C0 Offset: 0x20347C0 VA: 0x1820355C0
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_LocalName() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_NamespaceURI() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Prefix() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int get_HashCode() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x2035630 Offset: 0x2034830 VA: 0x182035630
	public string get_Name() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 11
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 12
	public virtual bool get_IsDefault() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 13
	public virtual bool get_IsNil() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 14
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 15
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 17
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x8D0790 Offset: 0x8CF990 VA: 0x1808D0790 Slot: 18
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x2035550 Offset: 0x2034750 VA: 0x182035550
	public static int GetHashCode(string name) { }
}

// Namespace: System.Xml
internal sealed class XmlNameEx : XmlName // TypeDefIndex: 12034
{
	// Fields
	private byte flags; // 0x48
	private XmlSchemaSimpleType memberType; // 0x50
	private XmlSchemaType schemaType; // 0x58
	private object decl; // 0x60

	// Properties
	public override XmlSchemaValidity Validity { get; }
	public override bool IsDefault { get; }
	public override bool IsNil { get; }
	public override XmlSchemaSimpleType MemberType { get; }
	public override XmlSchemaType SchemaType { get; }
	public override XmlSchemaElement SchemaElement { get; }
	public override XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x2035050 Offset: 0x2034250 VA: 0x182035050
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x2035300 Offset: 0x2034500 VA: 0x182035300 Slot: 11
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x20351E0 Offset: 0x20343E0 VA: 0x1820351E0 Slot: 12
	public override bool get_IsDefault() { }

	// RVA: 0x20351F0 Offset: 0x20343F0 VA: 0x1820351F0 Slot: 13
	public override bool get_IsNil() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 14
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 15
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x2035280 Offset: 0x2034480 VA: 0x182035280 Slot: 16
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x2035200 Offset: 0x2034400 VA: 0x182035200 Slot: 17
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x2035040 Offset: 0x2034240 VA: 0x182035040
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x2034FE0 Offset: 0x20341E0 VA: 0x182034FE0
	public void SetIsDefault(bool value) { }

	// RVA: 0x2035010 Offset: 0x2034210 VA: 0x182035010
	public void SetIsNil(bool value) { }

	// RVA: 0x2034E00 Offset: 0x2034000 VA: 0x182034E00 Slot: 18
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }
}

// Namespace: 
private class XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator : IEnumerator // TypeDefIndex: 12035
{
	// Fields
	private object loneValue; // 0x10
	private int position; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1600D80 Offset: 0x15FFF80 VA: 0x181600D80
	public void .ctor(object value) { }

	// RVA: 0x202C1D0 Offset: 0x202B3D0 VA: 0x18202C1D0 Slot: 5
	public object get_Current() { }

	// RVA: 0x202C1B0 Offset: 0x202B3B0 VA: 0x18202C1B0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x112DE90 Offset: 0x112D090 VA: 0x18112DE90 Slot: 6
	public void Reset() { }
}

// Namespace: 
[DefaultMember("Item")]
internal struct XmlNamedNodeMap.SmallXmlNodeList // TypeDefIndex: 12036
{
	// Fields
	private object field; // 0x0

	// Properties
	public int Count { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x202C820 Offset: 0x202BA20 VA: 0x18202C820
	public int get_Count() { }

	// RVA: 0x202C8C0 Offset: 0x202BAC0 VA: 0x18202C8C0
	public object get_Item(int index) { }

	// RVA: 0x202C230 Offset: 0x202B430 VA: 0x18202C230
	public void Add(object value) { }

	// RVA: 0x202C6E0 Offset: 0x202B8E0 VA: 0x18202C6E0
	public void RemoveAt(int index) { }

	// RVA: 0x202C4B0 Offset: 0x202B6B0 VA: 0x18202C4B0
	public void Insert(int index, object value) { }

	// RVA: 0x202C3A0 Offset: 0x202B5A0 VA: 0x18202C3A0
	public IEnumerator GetEnumerator() { }
}

// Namespace: System.Xml
public class XmlNamedNodeMap : IEnumerable // TypeDefIndex: 12037
{
	// Fields
	internal XmlNode parent; // 0x10
	internal XmlNamedNodeMap.SmallXmlNodeList nodes; // 0x18

	// Properties
	public virtual int Count { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x2035CF0 Offset: 0x2034EF0 VA: 0x182035CF0 Slot: 5
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x20362B0 Offset: 0x20354B0 VA: 0x1820362B0 Slot: 6
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x20364C0 Offset: 0x20356C0 VA: 0x1820364C0 Slot: 7
	public virtual int get_Count() { }

	// RVA: 0x2035CE0 Offset: 0x2034EE0 VA: 0x182035CE0 Slot: 8
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2035A70 Offset: 0x2034C70 VA: 0x182035A70
	internal int FindNodeOffset(string name) { }

	// RVA: 0x2035B90 Offset: 0x2034D90 VA: 0x182035B90
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x2035870 Offset: 0x2034A70 VA: 0x182035870 Slot: 9
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x20357A0 Offset: 0x20349A0 VA: 0x1820357A0 Slot: 10
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x20360B0 Offset: 0x20352B0 VA: 0x1820360B0 Slot: 11
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x2036240 Offset: 0x2035440 VA: 0x182036240
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x2035EA0 Offset: 0x20350A0 VA: 0x182035EA0 Slot: 12
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }
}

// Namespace: System.Xml
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
public abstract class XmlNode : ICloneable, IEnumerable, IXPathNavigable // TypeDefIndex: 12038
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Properties
	public abstract string Name { get; }
	public virtual string Value { get; set; }
	public abstract XmlNodeType NodeType { get; }
	public virtual XmlNode ParentNode { get; }
	public virtual XmlNodeList ChildNodes { get; }
	public virtual XmlNode PreviousSibling { get; }
	public virtual XmlNode NextSibling { get; }
	public virtual XmlAttributeCollection Attributes { get; }
	public virtual XmlDocument OwnerDocument { get; }
	public virtual XmlNode FirstChild { get; }
	public virtual XmlNode LastChild { get; }
	internal virtual bool IsContainer { get; }
	internal virtual XmlLinkedNode LastNode { get; set; }
	public virtual bool HasChildNodes { get; }
	public virtual string NamespaceURI { get; }
	public virtual string Prefix { get; set; }
	public abstract string LocalName { get; }
	public virtual bool IsReadOnly { get; }
	public virtual string InnerText { get; set; }
	public virtual string InnerXml { set; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual string BaseURI { get; }
	internal XmlDocument Document { get; }
	internal virtual XmlSpace XmlSpace { get; }
	internal virtual string XmlLang { get; }
	internal virtual XPathNodeType XPNodeType { get; }
	internal virtual string XPLocalName { get; }
	internal virtual bool IsText { get; }
	public virtual XmlNode PreviousText { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x203E400 Offset: 0x203D600 VA: 0x18203E400
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x203C4F0 Offset: 0x203B6F0 VA: 0x18203C4F0 Slot: 7
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: 0x203E120 Offset: 0x203D320 VA: 0x18203E120
	public XmlNode SelectSingleNode(string xpath, XmlNamespaceManager nsmgr) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public virtual string get_Value() { }

	// RVA: 0x203F030 Offset: 0x203E230 VA: 0x18203F030 Slot: 10
	public virtual void set_Value(string value) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x203EA40 Offset: 0x203DC40 VA: 0x18203EA40 Slot: 12
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x203E5A0 Offset: 0x203D7A0 VA: 0x18203E5A0 Slot: 13
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 14
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 15
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x203E970 Offset: 0x203DB70 VA: 0x18203E970 Slot: 17
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x203E6C0 Offset: 0x203D8C0 VA: 0x18203E6C0 Slot: 18
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x7F7910 Offset: 0x7F6B10 VA: 0x1807F7910 Slot: 19
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 20
	internal virtual bool get_IsContainer() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 21
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x203BA50 Offset: 0x203AC50 VA: 0x18203BA50
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x203DBA0 Offset: 0x203CDA0 VA: 0x18203DBA0
	internal bool IsConnected() { }

	// RVA: 0x203D470 Offset: 0x203C670 VA: 0x18203D470 Slot: 23
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x203CD20 Offset: 0x203BF20 VA: 0x18203CD20 Slot: 24
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x203DD00 Offset: 0x203CF00 VA: 0x18203DD00 Slot: 25
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x203DC30 Offset: 0x203CE30 VA: 0x18203DC30 Slot: 26
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x203BDC0 Offset: 0x203AFC0 VA: 0x18203BDC0 Slot: 27
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x203BAD0 Offset: 0x203ACD0 VA: 0x18203BAD0 Slot: 28
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 29
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 30
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 31
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x203E6F0 Offset: 0x203D8F0 VA: 0x18203E6F0 Slot: 32
	public virtual bool get_HasChildNodes() { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract XmlNode CloneNode(bool deep);

	// RVA: 0x203C430 Offset: 0x203B630 VA: 0x18203C430 Slot: 34
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x203E930 Offset: 0x203DB30 VA: 0x18203E930 Slot: 35
	public virtual string get_NamespaceURI() { }

	// RVA: 0x203EB40 Offset: 0x203DD40 VA: 0x18203EB40 Slot: 36
	public virtual string get_Prefix() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 37
	public virtual void set_Prefix(string value) { }

	// RVA: -1 Offset: -1 Slot: 38
	public abstract string get_LocalName();

	// RVA: 0x203E850 Offset: 0x203DA50 VA: 0x18203E850 Slot: 39
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x203CC50 Offset: 0x203BE50 VA: 0x18203CC50
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x203E3A0 Offset: 0x203D5A0 VA: 0x18203E3A0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x203E340 Offset: 0x203D540 VA: 0x18203E340 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x203C650 Offset: 0x203B850 VA: 0x18203C650
	public IEnumerator GetEnumerator() { }

	// RVA: 0x203BC90 Offset: 0x203AE90 VA: 0x18203BC90
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x203E720 Offset: 0x203D920 VA: 0x18203E720 Slot: 40
	public virtual string get_InnerText() { }

	// RVA: 0x203EEC0 Offset: 0x203E0C0 VA: 0x18203EEC0 Slot: 41
	public virtual void set_InnerText(string value) { }

	// RVA: 0x203EFD0 Offset: 0x203E1D0 VA: 0x18203EFD0 Slot: 42
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x203EB80 Offset: 0x203DD80 VA: 0x18203EB80 Slot: 43
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x203E490 Offset: 0x203D690 VA: 0x18203E490 Slot: 44
	public virtual string get_BaseURI() { }

	// RVA: -1 Offset: -1 Slot: 45
	public abstract void WriteTo(XmlWriter w);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract void WriteContentTo(XmlWriter w);

	// RVA: 0x203DC80 Offset: 0x203CE80 VA: 0x18203DC80 Slot: 47
	public virtual void RemoveAll() { }

	// RVA: 0x203E600 Offset: 0x203D800 VA: 0x18203E600
	internal XmlDocument get_Document() { }

	// RVA: 0x203CBF0 Offset: 0x203BDF0 VA: 0x18203CBF0 Slot: 48
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x203C7F0 Offset: 0x203B9F0 VA: 0x18203C7F0
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x203E240 Offset: 0x203D440 VA: 0x18203E240 Slot: 49
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 50
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x203E280 Offset: 0x203D480 VA: 0x18203E280
	internal static void SplitName(string name, out string prefix, out string localName) { }

	// RVA: 0x203C5C0 Offset: 0x203B7C0 VA: 0x18203C5C0 Slot: 51
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x203C6B0 Offset: 0x203B8B0 VA: 0x18203C6B0 Slot: 52
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x203C3E0 Offset: 0x203B5E0 VA: 0x18203C3E0 Slot: 53
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x203BA00 Offset: 0x203AC00 VA: 0x18203BA00 Slot: 54
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x203ED30 Offset: 0x203DF30 VA: 0x18203ED30 Slot: 55
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x203EC10 Offset: 0x203DE10 VA: 0x18203EC10 Slot: 56
	internal virtual string get_XmlLang() { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380 Slot: 57
	internal virtual XPathNodeType get_XPNodeType() { }

	// RVA: 0x203EBD0 Offset: 0x203DDD0 VA: 0x18203EBD0 Slot: 58
	internal virtual string get_XPLocalName() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 59
	internal virtual bool get_IsText() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 60
	public virtual XmlNode get_PreviousText() { }

	// RVA: 0x203DC10 Offset: 0x203CE10 VA: 0x18203DC10
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x203E3C0 Offset: 0x203D5C0 VA: 0x18203E3C0
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }
}

// Namespace: System.Xml
public class XmlNodeChangedEventArgs : EventArgs // TypeDefIndex: 12039
{
	// Fields
	private XmlNodeChangedAction action; // 0x10
	private XmlNode node; // 0x18
	private XmlNode oldParent; // 0x20
	private XmlNode newParent; // 0x28
	private string oldValue; // 0x30
	private string newValue; // 0x38

	// Properties
	public XmlNodeChangedAction Action { get; }

	// Methods

	// RVA: 0x20364D0 Offset: 0x20356D0 VA: 0x1820364D0
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public XmlNodeChangedAction get_Action() { }
}

// Namespace: System.Xml
public sealed class XmlNodeChangedEventHandler : MulticastDelegate // TypeDefIndex: 12040
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, XmlNodeChangedEventArgs e) { }
}

// Namespace: System.Xml
[DefaultMember("ItemOf")]
public abstract class XmlNodeList : IEnumerable, IDisposable // TypeDefIndex: 12041
{
	// Properties
	public abstract int Count { get; }
	public virtual XmlNode ItemOf { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNode Item(int index);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IEnumerator GetEnumerator();

	// RVA: 0x17F3DA0 Offset: 0x17F2FA0 VA: 0x1817F3DA0 Slot: 9
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0x577700 Offset: 0x576900 VA: 0x180577700 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
internal struct XmlNodeReaderNavigator.VirtualAttribute // TypeDefIndex: 12042
{
	// Fields
	internal string name; // 0x0
	internal string value; // 0x8

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	internal void .ctor(string name, string value) { }
}

// Namespace: System.Xml
internal class XmlNodeReaderNavigator // TypeDefIndex: 12043
{
	// Fields
	private XmlNode curNode; // 0x10
	private XmlNode elemNode; // 0x18
	private XmlNode logNode; // 0x20
	private int attrIndex; // 0x28
	private int logAttrIndex; // 0x2C
	private XmlNameTable nameTable; // 0x30
	private XmlDocument doc; // 0x38
	private int nAttrInd; // 0x40
	private int nDeclarationAttrCount; // 0x44
	private int nDocTypeAttrCount; // 0x48
	private int nLogLevel; // 0x4C
	private int nLogAttrInd; // 0x50
	private bool bLogOnAttrVal; // 0x54
	private bool bCreatedOnAttribute; // 0x55
	internal XmlNodeReaderNavigator.VirtualAttribute[] decNodeAttributes; // 0x58
	internal XmlNodeReaderNavigator.VirtualAttribute[] docTypeNodeAttributes; // 0x60
	private bool bOnAttrVal; // 0x68

	// Properties
	public XmlNodeType NodeType { get; }
	public string NamespaceURI { get; }
	public string Name { get; }
	public string LocalName { get; }
	internal bool CreatedOnAttribute { get; }
	public string Prefix { get; }
	public bool HasValue { get; }
	public string Value { get; }
	public string BaseURI { get; }
	public XmlSpace XmlSpace { get; }
	public string XmlLang { get; }
	public bool IsEmptyElement { get; }
	public bool IsDefault { get; }
	public IXmlSchemaInfo SchemaInfo { get; }
	public XmlNameTable NameTable { get; }
	public int AttributeCount { get; }
	private bool IsOnDeclOrDocType { get; }
	public XmlDocument Document { get; }

	// Methods

	// RVA: 0x20391D0 Offset: 0x20383D0 VA: 0x1820391D0
	public void .ctor(XmlNode node) { }

	// RVA: 0x2039AA0 Offset: 0x2038CA0 VA: 0x182039AA0
	public XmlNodeType get_NodeType() { }

	// RVA: 0x18AF010 Offset: 0x18AE210 VA: 0x1818AF010
	public string get_NamespaceURI() { }

	// RVA: 0x2039960 Offset: 0x2038B60 VA: 0x182039960
	public string get_Name() { }

	// RVA: 0x2039880 Offset: 0x2038A80 VA: 0x182039880
	public string get_LocalName() { }

	// RVA: 0x20395B0 Offset: 0x20387B0 VA: 0x1820395B0
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0x2037B50 Offset: 0x2036D50 VA: 0x182037B50
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0x1738040 Offset: 0x1737240 VA: 0x181738040
	public string get_Prefix() { }

	// RVA: 0x20395C0 Offset: 0x20387C0 VA: 0x1820395C0
	public bool get_HasValue() { }

	// RVA: 0x2039B20 Offset: 0x2038D20 VA: 0x182039B20
	public string get_Value() { }

	// RVA: 0x1E38390 Offset: 0x1E37590 VA: 0x181E38390
	public string get_BaseURI() { }

	// RVA: 0x1FF3A70 Offset: 0x1FF2C70 VA: 0x181FF3A70
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x1FF3A00 Offset: 0x1FF2C00 VA: 0x181FF3A00
	public string get_XmlLang() { }

	// RVA: 0x2039740 Offset: 0x2038940 VA: 0x182039740
	public bool get_IsEmptyElement() { }

	// RVA: 0x2039630 Offset: 0x2038830 VA: 0x182039630
	public bool get_IsDefault() { }

	// RVA: 0x2039AF0 Offset: 0x2038CF0 VA: 0x182039AF0
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public XmlNameTable get_NameTable() { }

	// RVA: 0x2039410 Offset: 0x2038610 VA: 0x182039410
	public int get_AttributeCount() { }

	// RVA: 0x2036570 Offset: 0x2035770 VA: 0x182036570
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0x20378A0 Offset: 0x2036AA0 VA: 0x1820378A0
	private void InitDecAttr() { }

	// RVA: 0x2037140 Offset: 0x2036340 VA: 0x182037140
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0x20370F0 Offset: 0x20362F0 VA: 0x1820370F0
	public string GetDeclarationAttr(int i) { }

	// RVA: 0x2037060 Offset: 0x2036260 VA: 0x182037060
	public int GetDecAttrInd(string name) { }

	// RVA: 0x2037A40 Offset: 0x2036C40 VA: 0x182037A40
	private void InitDocTypeAttr() { }

	// RVA: 0x2037300 Offset: 0x2036500 VA: 0x182037300
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0x20372B0 Offset: 0x20364B0 VA: 0x1820372B0
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0x2037220 Offset: 0x2036420 VA: 0x182037220
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0x20367B0 Offset: 0x20359B0 VA: 0x1820367B0
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0x2036810 Offset: 0x2035A10 VA: 0x182036810
	public string GetAttribute(string name) { }

	// RVA: 0x2036750 Offset: 0x2035950 VA: 0x182036750
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x2036AE0 Offset: 0x2035CE0 VA: 0x182036AE0
	public string GetAttribute(string name, string ns) { }

	// RVA: 0x2036DA0 Offset: 0x2035FA0 VA: 0x182036DA0
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0x2037BA0 Offset: 0x2036DA0 VA: 0x182037BA0
	public void LogMove(int level) { }

	// RVA: 0x20391A0 Offset: 0x20383A0 VA: 0x1820391A0
	public void RollBackMove(ref int level) { }

	// RVA: 0x2039840 Offset: 0x2038A40 VA: 0x182039840
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0x20390D0 Offset: 0x20382D0 VA: 0x1820390D0
	public void ResetToAttribute(ref int level) { }

	// RVA: 0x2038E10 Offset: 0x2038010 VA: 0x182038E10
	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	// RVA: 0x20387D0 Offset: 0x20379D0 VA: 0x1820387D0
	public bool MoveToAttribute(string name) { }

	// RVA: 0x2038270 Offset: 0x2037470 VA: 0x182038270
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x2038560 Offset: 0x2037760 VA: 0x182038560
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0x2038350 Offset: 0x2037550 VA: 0x182038350
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x2038900 Offset: 0x2037B00 VA: 0x182038900
	public bool MoveToNextAttribute(ref int level) { }

	// RVA: 0x2038BC0 Offset: 0x2037DC0 VA: 0x182038BC0
	public bool MoveToParent() { }

	// RVA: 0x20388B0 Offset: 0x2037AB0 VA: 0x1820388B0
	public bool MoveToFirstChild() { }

	// RVA: 0x2038AE0 Offset: 0x2037CE0 VA: 0x182038AE0
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0x2038B40 Offset: 0x2037D40 VA: 0x182038B40
	public bool MoveToNext() { }

	// RVA: 0x2038830 Offset: 0x2037A30 VA: 0x182038830
	public bool MoveToElement() { }

	// RVA: 0x2037BC0 Offset: 0x2036DC0 VA: 0x182037BC0
	public string LookupNamespace(string prefix) { }

	// RVA: 0x20365E0 Offset: 0x20357E0 VA: 0x1820365E0
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0x2037E70 Offset: 0x2037070 VA: 0x182037E70
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x20373A0 Offset: 0x20365A0 VA: 0x1820373A0
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x2038C10 Offset: 0x2037E10 VA: 0x182038C10
	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public XmlDocument get_Document() { }
}

// Namespace: System.Xml
public class XmlNodeReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 12044
{
	// Fields
	private XmlNodeReaderNavigator readerNav; // 0x10
	private XmlNodeType nodeType; // 0x18
	private int curDepth; // 0x1C
	private ReadState readState; // 0x20
	private bool fEOF; // 0x24
	private bool bResolveEntity; // 0x25
	private bool bStartFromDocument; // 0x26
	private bool bInReadBinary; // 0x27
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override bool HasValue { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool CanResolveEntity { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override bool HasAttributes { get; }
	public override XmlNameTable NameTable { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x203B230 Offset: 0x203A430 VA: 0x18203B230
	public void .ctor(XmlNode node) { }

	// RVA: 0x2039F90 Offset: 0x2039190 VA: 0x182039F90
	internal bool IsInReadingStates() { }

	// RVA: 0x203B7F0 Offset: 0x203A9F0 VA: 0x18203B7F0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x203B710 Offset: 0x203A910 VA: 0x18203B710 Slot: 7
	public override string get_Name() { }

	// RVA: 0x203B5E0 Offset: 0x203A7E0 VA: 0x18203B5E0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x203B770 Offset: 0x203A970 VA: 0x18203B770 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x203B800 Offset: 0x203AA00 VA: 0x18203B800 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x203B3E0 Offset: 0x203A5E0 VA: 0x18203B3E0 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x203B8D0 Offset: 0x203AAD0 VA: 0x18203B8D0 Slot: 12
	public override string get_Value() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x203B360 Offset: 0x203A560 VA: 0x18203B360 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x203B5B0 Offset: 0x203A7B0 VA: 0x18203B5B0 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x203B470 Offset: 0x203A670 VA: 0x18203B470 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x203B9B0 Offset: 0x203ABB0 VA: 0x18203B9B0 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x203B930 Offset: 0x203AB30 VA: 0x18203B930 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x203B880 Offset: 0x203AA80 VA: 0x18203B880 Slot: 20
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x203B320 Offset: 0x203A520 VA: 0x18203B320 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x2039ED0 Offset: 0x20390D0 VA: 0x182039ED0 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x2039F00 Offset: 0x2039100 VA: 0x182039F00 Slot: 25
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x2039E50 Offset: 0x2039050 VA: 0x182039E50 Slot: 26
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x203A1A0 Offset: 0x20393A0 VA: 0x18203A1A0 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x2039FE0 Offset: 0x20391E0 VA: 0x182039FE0 Slot: 28
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x203A460 Offset: 0x2039660 VA: 0x18203A460 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x203A570 Offset: 0x2039770 VA: 0x18203A570 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x203A2E0 Offset: 0x20394E0 VA: 0x18203A2E0 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x203AD60 Offset: 0x2039F60 VA: 0x18203AD60 Slot: 33
	public override bool Read() { }

	// RVA: 0x203AD70 Offset: 0x2039F70 VA: 0x18203AD70
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x203A9C0 Offset: 0x2039BC0 VA: 0x18203A9C0
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x203AFD0 Offset: 0x203A1D0 VA: 0x18203AFD0
	private void SetEndOfFile() { }

	// RVA: 0x203A6D0 Offset: 0x20398D0 VA: 0x18203A6D0
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x203A7C0 Offset: 0x20399C0 VA: 0x18203A7C0
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x203A6A0 Offset: 0x20398A0 VA: 0x18203A6A0
	private void ReSetReadingMarks() { }

	// RVA: 0x203B3D0 Offset: 0x203A5D0 VA: 0x18203B3D0 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x2039E10 Offset: 0x2039010 VA: 0x182039E10 Slot: 35
	public override void Close() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x203AFF0 Offset: 0x203A1F0 VA: 0x18203AFF0 Slot: 37
	public override void Skip() { }

	// RVA: 0x203ACB0 Offset: 0x2039EB0 VA: 0x18203ACB0 Slot: 44
	public override string ReadString() { }

	// RVA: 0x1FF1B70 Offset: 0x1FF0D70 VA: 0x181FF1B70 Slot: 53
	public override bool get_HasAttributes() { }

	// RVA: 0x1D16D20 Offset: 0x1D15F20 VA: 0x181D16D20 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x2039FA0 Offset: 0x20391A0 VA: 0x182039FA0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x203AF40 Offset: 0x203A140 VA: 0x18203AF40 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x203A770 Offset: 0x2039970 VA: 0x18203A770 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x2039E20 Offset: 0x2039020 VA: 0x182039E20
	private void FinishReadBinary() { }

	// RVA: 0x203B000 Offset: 0x203A200 VA: 0x18203B000 Slot: 57
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x203B210 Offset: 0x203A410 VA: 0x18203B210 Slot: 59
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x203B020 Offset: 0x203A220 VA: 0x18203B020 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x203B3A0 Offset: 0x203A5A0 VA: 0x18203B3A0 Slot: 56
	internal override IDtdInfo get_DtdInfo() { }
}

// Namespace: System.Xml
public class XmlNotation : XmlNode // TypeDefIndex: 12045
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string name; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public override string InnerXml { set; }

	// Methods

	// RVA: 0x203F170 Offset: 0x203E370 VA: 0x18203F170
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0xAA0160 Offset: 0xA9F360 VA: 0x180AA0160 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x203F110 Offset: 0x203E310 VA: 0x18203F110 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 39
	public override bool get_IsReadOnly() { }

	// RVA: 0x203F250 Offset: 0x203E450 VA: 0x18203F250 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }
}

// Namespace: System.Xml
public class XmlProcessingInstruction : XmlLinkedNode // TypeDefIndex: 12046
{
	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public string Data { set; }
	public override string InnerText { get; set; }
	public override XmlNodeType NodeType { get; }
	internal override string XPLocalName { get; }
	internal override XPathNodeType XPNodeType { get; }

	// Methods

	// RVA: 0x203F340 Offset: 0x203E540 VA: 0x18203F340
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0x203F3F0 Offset: 0x203E5F0 VA: 0x18203F3F0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x6D85F0 Offset: 0x6D77F0 VA: 0x1806D85F0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 9
	public override string get_Value() { }

	// RVA: 0x203F500 Offset: 0x203E700 VA: 0x18203F500 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x203F440 Offset: 0x203E640 VA: 0x18203F440
	public void set_Data(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 40
	public override string get_InnerText() { }

	// RVA: 0x203F500 Offset: 0x203E700 VA: 0x18203F500 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x68EEF0 Offset: 0x68E0F0 VA: 0x18068EEF0 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x203F2B0 Offset: 0x203E4B0 VA: 0x18203F2B0 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x203F300 Offset: 0x203E500 VA: 0x18203F300 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x6D85F0 Offset: 0x6D77F0 VA: 0x1806D85F0 Slot: 58
	internal override string get_XPLocalName() { }

	// RVA: 0x68EEF0 Offset: 0x68E0F0 VA: 0x18068EEF0 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }
}

// Namespace: System.Xml
public class XmlSignificantWhitespace : XmlCharacterData // TypeDefIndex: 12047
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override XPathNodeType XPNodeType { get; }
	internal override bool IsText { get; }
	public override XmlNode PreviousText { get; }

	// Methods

	// RVA: 0x203F5D0 Offset: 0x203E7D0 VA: 0x18203F5D0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x203F680 Offset: 0x203E880 VA: 0x18203F680 Slot: 8
	public override string get_Name() { }

	// RVA: 0x203F680 Offset: 0x203E880 VA: 0x18203F680 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x16FB640 Offset: 0x16FA840 VA: 0x1816FB640 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x203F6B0 Offset: 0x203E8B0 VA: 0x18203F6B0 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x203F510 Offset: 0x203E710 VA: 0x18203F510 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x20106B0 Offset: 0x200F8B0 VA: 0x1820106B0 Slot: 9
	public override string get_Value() { }

	// RVA: 0x203F790 Offset: 0x203E990 VA: 0x18203F790 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x203F580 Offset: 0x203E780 VA: 0x18203F580 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x203F760 Offset: 0x203E960 VA: 0x18203F760 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 59
	internal override bool get_IsText() { }

	// RVA: 0x2010500 Offset: 0x200F700 VA: 0x182010500 Slot: 60
	public override XmlNode get_PreviousText() { }
}

// Namespace: System.Xml
public class XmlText : XmlCharacterData // TypeDefIndex: 12048
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override XPathNodeType XPNodeType { get; }
	internal override bool IsText { get; }
	public override XmlNode PreviousText { get; }

	// Methods

	// RVA: 0x203F8B0 Offset: 0x203EAB0 VA: 0x18203F8B0
	internal void .ctor(string strData) { }

	// RVA: 0x203F8A0 Offset: 0x203EAA0 VA: 0x18203F8A0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x203F8C0 Offset: 0x203EAC0 VA: 0x18203F8C0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x203F8C0 Offset: 0x203EAC0 VA: 0x18203F8C0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2010460 Offset: 0x200F660 VA: 0x182010460 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x203F830 Offset: 0x203EA30 VA: 0x18203F830 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x20106B0 Offset: 0x200F8B0 VA: 0x1820106B0 Slot: 9
	public override string get_Value() { }

	// RVA: 0x203F8F0 Offset: 0x203EAF0 VA: 0x18203F8F0 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x203F580 Offset: 0x203E780 VA: 0x18203F580 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 59
	internal override bool get_IsText() { }

	// RVA: 0x2010500 Offset: 0x200F700 VA: 0x182010500 Slot: 60
	public override XmlNode get_PreviousText() { }
}

// Namespace: System.Xml
internal class XmlUnspecifiedAttribute : XmlAttribute // TypeDefIndex: 12049
{
	// Fields
	private bool fSpecified; // 0x28

	// Properties
	public override bool Specified { get; }
	public override string InnerText { set; }

	// Methods

	// RVA: 0x203FBC0 Offset: 0x203EDC0 VA: 0x18203FBC0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840 Slot: 61
	public override bool get_Specified() { }

	// RVA: 0x203F9F0 Offset: 0x203EBF0 VA: 0x18203F9F0 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x203FBD0 Offset: 0x203EDD0 VA: 0x18203FBD0 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x203FB70 Offset: 0x203ED70 VA: 0x18203FB70 Slot: 23
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x203FB50 Offset: 0x203ED50 VA: 0x18203FB50 Slot: 24
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x203FB90 Offset: 0x203ED90 VA: 0x18203FB90 Slot: 25
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x203F9D0 Offset: 0x203EBD0 VA: 0x18203F9D0 Slot: 27
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x203FBB0 Offset: 0x203EDB0 VA: 0x18203FBB0 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	internal void SetSpecified(bool f) { }
}

// Namespace: System.Xml
public class XmlWhitespace : XmlCharacterData // TypeDefIndex: 12050
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override XPathNodeType XPNodeType { get; }
	internal override bool IsText { get; }
	public override XmlNode PreviousText { get; }

	// Methods

	// RVA: 0x203FCB0 Offset: 0x203EEB0 VA: 0x18203FCB0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x203FD60 Offset: 0x203EF60 VA: 0x18203FD60 Slot: 8
	public override string get_Name() { }

	// RVA: 0x203FD60 Offset: 0x203EF60 VA: 0x18203FD60 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x170C2E0 Offset: 0x170B4E0 VA: 0x18170C2E0 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x203F6B0 Offset: 0x203E8B0 VA: 0x18203F6B0 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x20106B0 Offset: 0x200F8B0 VA: 0x1820106B0 Slot: 9
	public override string get_Value() { }

	// RVA: 0x203FDC0 Offset: 0x203EFC0 VA: 0x18203FDC0 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x203FBF0 Offset: 0x203EDF0 VA: 0x18203FBF0 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x203FC60 Offset: 0x203EE60 VA: 0x18203FC60 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x203FD90 Offset: 0x203EF90 VA: 0x18203FD90 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 59
	internal override bool get_IsText() { }

	// RVA: 0x2010500 Offset: 0x200F700 VA: 0x182010500 Slot: 60
	public override XmlNode get_PreviousText() { }
}

// Namespace: System.Xml
internal sealed class EmptyEnumerator : IEnumerator // TypeDefIndex: 12051
{
	// Properties
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x202B170 Offset: 0x202A370 VA: 0x18202B170 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml
[DefaultMember("Item")]
internal class HWStack : ICloneable // TypeDefIndex: 12052
{
	// Fields
	private object[] stack; // 0x10
	private int growthRate; // 0x18
	private int used; // 0x1C
	private int size; // 0x20
	private int limit; // 0x24

	// Properties
	internal object Item { get; set; }
	internal int Length { get; }

	// Methods

	// RVA: 0x202B5B0 Offset: 0x202A7B0 VA: 0x18202B5B0
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x202B540 Offset: 0x202A740 VA: 0x18202B540
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x202B3D0 Offset: 0x202A5D0 VA: 0x18202B3D0
	internal object Push() { }

	// RVA: 0x202B390 Offset: 0x202A590 VA: 0x18202B390
	internal object Pop() { }

	// RVA: 0x202B350 Offset: 0x202A550 VA: 0x18202B350
	internal object Peek() { }

	// RVA: 0x202B1D0 Offset: 0x202A3D0 VA: 0x18202B1D0
	internal void AddToTop(object o) { }

	// RVA: 0x202B620 Offset: 0x202A820 VA: 0x18202B620
	internal object get_Item(int index) { }

	// RVA: 0x202B6A0 Offset: 0x202A8A0 VA: 0x18202B6A0
	internal void set_Item(int index, object value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	internal int get_Length() { }

	// RVA: 0x202B4F0 Offset: 0x202A6F0 VA: 0x18202B4F0
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x202B250 Offset: 0x202A450 VA: 0x18202B250 Slot: 4
	public object Clone() { }
}

// Namespace: System.Xml
public interface IHasXmlNode // TypeDefIndex: 12053
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNode GetNode();
}

// Namespace: System.Xml
public interface IXmlLineInfo // TypeDefIndex: 12054
{
	// Properties
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasLineInfo();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LinePosition();
}

// Namespace: System.Xml
internal class PositionInfo : IXmlLineInfo // TypeDefIndex: 12055
{
	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public virtual bool HasLineInfo() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public virtual int get_LineNumber() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public virtual int get_LinePosition() { }

	// RVA: 0x202C010 Offset: 0x202B210 VA: 0x18202C010
	public static PositionInfo GetPositionInfo(object o) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml
internal class ReaderPositionInfo : PositionInfo // TypeDefIndex: 12056
{
	// Fields
	private IXmlLineInfo lineInfo; // 0x10

	// Properties
	public override int LineNumber { get; }
	public override int LinePosition { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IXmlLineInfo lineInfo) { }

	// RVA: 0x202C0C0 Offset: 0x202B2C0 VA: 0x18202C0C0 Slot: 7
	public override bool HasLineInfo() { }

	// RVA: 0x202C110 Offset: 0x202B310 VA: 0x18202C110 Slot: 8
	public override int get_LineNumber() { }

	// RVA: 0x202C160 Offset: 0x202B360 VA: 0x18202C160 Slot: 9
	public override int get_LinePosition() { }
}

// Namespace: System.Xml
public interface IXmlNamespaceResolver // TypeDefIndex: 12057
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string LookupNamespace(string prefix);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string LookupPrefix(string namespaceName);
}

// Namespace: System.Xml
internal struct LineInfo // TypeDefIndex: 12058
{
	// Fields
	internal int lineNo; // 0x0
	internal int linePos; // 0x4

	// Methods

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void .ctor(int lineNo, int linePos) { }

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void Set(int lineNo, int linePos) { }
}

// Namespace: 
private class NameTable.Entry // TypeDefIndex: 12059
{
	// Fields
	internal string str; // 0x10
	internal int hashCode; // 0x18
	internal NameTable.Entry next; // 0x20

	// Methods

	// RVA: 0x17E1FC0 Offset: 0x17E11C0 VA: 0x1817E1FC0
	internal void .ctor(string str, int hashCode, NameTable.Entry next) { }
}

// Namespace: System.Xml
public class NameTable : XmlNameTable // TypeDefIndex: 12060
{
	// Fields
	private NameTable.Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0x202BFB0 Offset: 0x202B1B0 VA: 0x18202BFB0
	public void .ctor() { }

	// RVA: 0x202B970 Offset: 0x202AB70 VA: 0x18202B970 Slot: 6
	public override string Add(string key) { }

	// RVA: 0x202BAF0 Offset: 0x202ACF0 VA: 0x18202BAF0 Slot: 5
	public override string Add(char[] key, int start, int len) { }

	// RVA: 0x202BD00 Offset: 0x202AF00 VA: 0x18202BD00 Slot: 4
	public override string Get(string value) { }

	// RVA: 0x202B760 Offset: 0x202A960 VA: 0x18202B760
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x202BE80 Offset: 0x202B080 VA: 0x18202BE80
	private void Grow() { }

	// RVA: 0x181FCF0 Offset: 0x181EEF0 VA: 0x18181FCF0
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }
}

// Namespace: System.Xml
internal static class Ref // TypeDefIndex: 12061
{
	// Methods

	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0
	public static bool Equal(string strA, string strB) { }
}

// Namespace: 
private enum DtdParser.Token // TypeDefIndex: 12062
{
	// Fields
	public int value__; // 0x0
	public const DtdParser.Token CDATA = 0;
	public const DtdParser.Token ID = 1;
	public const DtdParser.Token IDREF = 2;
	public const DtdParser.Token IDREFS = 3;
	public const DtdParser.Token ENTITY = 4;
	public const DtdParser.Token ENTITIES = 5;
	public const DtdParser.Token NMTOKEN = 6;
	public const DtdParser.Token NMTOKENS = 7;
	public const DtdParser.Token NOTATION = 8;
	public const DtdParser.Token None = 9;
	public const DtdParser.Token PERef = 10;
	public const DtdParser.Token AttlistDecl = 11;
	public const DtdParser.Token ElementDecl = 12;
	public const DtdParser.Token EntityDecl = 13;
	public const DtdParser.Token NotationDecl = 14;
	public const DtdParser.Token Comment = 15;
	public const DtdParser.Token PI = 16;
	public const DtdParser.Token CondSectionStart = 17;
	public const DtdParser.Token CondSectionEnd = 18;
	public const DtdParser.Token Eof = 19;
	public const DtdParser.Token REQUIRED = 20;
	public const DtdParser.Token IMPLIED = 21;
	public const DtdParser.Token FIXED = 22;
	public const DtdParser.Token QName = 23;
	public const DtdParser.Token Name = 24;
	public const DtdParser.Token Nmtoken = 25;
	public const DtdParser.Token Quote = 26;
	public const DtdParser.Token LeftParen = 27;
	public const DtdParser.Token RightParen = 28;
	public const DtdParser.Token GreaterThan = 29;
	public const DtdParser.Token Or = 30;
	public const DtdParser.Token LeftBracket = 31;
	public const DtdParser.Token RightBracket = 32;
	public const DtdParser.Token PUBLIC = 33;
	public const DtdParser.Token SYSTEM = 34;
	public const DtdParser.Token Literal = 35;
	public const DtdParser.Token DOCTYPE = 36;
	public const DtdParser.Token NData = 37;
	public const DtdParser.Token Percent = 38;
	public const DtdParser.Token Star = 39;
	public const DtdParser.Token QMark = 40;
	public const DtdParser.Token Plus = 41;
	public const DtdParser.Token PCDATA = 42;
	public const DtdParser.Token Comma = 43;
	public const DtdParser.Token ANY = 44;
	public const DtdParser.Token EMPTY = 45;
	public const DtdParser.Token IGNORE = 46;
	public const DtdParser.Token INCLUDE = 47;
}

// Namespace: 
private enum DtdParser.ScanningFunction // TypeDefIndex: 12063
{
	// Fields
	public int value__; // 0x0
	public const DtdParser.ScanningFunction SubsetContent = 0;
	public const DtdParser.ScanningFunction Name = 1;
	public const DtdParser.ScanningFunction QName = 2;
	public const DtdParser.ScanningFunction Nmtoken = 3;
	public const DtdParser.ScanningFunction Doctype1 = 4;
	public const DtdParser.ScanningFunction Doctype2 = 5;
	public const DtdParser.ScanningFunction Element1 = 6;
	public const DtdParser.ScanningFunction Element2 = 7;
	public const DtdParser.ScanningFunction Element3 = 8;
	public const DtdParser.ScanningFunction Element4 = 9;
	public const DtdParser.ScanningFunction Element5 = 10;
	public const DtdParser.ScanningFunction Element6 = 11;
	public const DtdParser.ScanningFunction Element7 = 12;
	public const DtdParser.ScanningFunction Attlist1 = 13;
	public const DtdParser.ScanningFunction Attlist2 = 14;
	public const DtdParser.ScanningFunction Attlist3 = 15;
	public const DtdParser.ScanningFunction Attlist4 = 16;
	public const DtdParser.ScanningFunction Attlist5 = 17;
	public const DtdParser.ScanningFunction Attlist6 = 18;
	public const DtdParser.ScanningFunction Attlist7 = 19;
	public const DtdParser.ScanningFunction Entity1 = 20;
	public const DtdParser.ScanningFunction Entity2 = 21;
	public const DtdParser.ScanningFunction Entity3 = 22;
	public const DtdParser.ScanningFunction Notation1 = 23;
	public const DtdParser.ScanningFunction CondSection1 = 24;
	public const DtdParser.ScanningFunction CondSection2 = 25;
	public const DtdParser.ScanningFunction CondSection3 = 26;
	public const DtdParser.ScanningFunction Literal = 27;
	public const DtdParser.ScanningFunction SystemId = 28;
	public const DtdParser.ScanningFunction PublicId1 = 29;
	public const DtdParser.ScanningFunction PublicId2 = 30;
	public const DtdParser.ScanningFunction ClosingTag = 31;
	public const DtdParser.ScanningFunction ParamEntitySpace = 32;
	public const DtdParser.ScanningFunction None = 33;
}

// Namespace: 
private enum DtdParser.LiteralType // TypeDefIndex: 12064
{
	// Fields
	public int value__; // 0x0
	public const DtdParser.LiteralType AttributeValue = 0;
	public const DtdParser.LiteralType EntityReplText = 1;
	public const DtdParser.LiteralType SystemOrPublicID = 2;
}

// Namespace: 
private class DtdParser.UndeclaredNotation // TypeDefIndex: 12065
{
	// Fields
	internal string name; // 0x10
	internal int lineNo; // 0x18
	internal int linePos; // 0x1C
	internal DtdParser.UndeclaredNotation next; // 0x20

	// Methods

	// RVA: 0x204A210 Offset: 0x2049410 VA: 0x18204A210
	internal void .ctor(string name, int lineNo, int linePos) { }
}

// Namespace: 
private class DtdParser.ParseElementOnlyContent_LocalFrame // TypeDefIndex: 12066
{
	// Fields
	public int startParenEntityId; // 0x10
	public DtdParser.Token parsingSchema; // 0x14

	// Methods

	// RVA: 0x2040B70 Offset: 0x203FD70 VA: 0x182040B70
	public void .ctor(int startParentEntityIdParam) { }
}

// Namespace: System.Xml
internal class DtdParser : IDtdParser // TypeDefIndex: 12067
{
	// Fields
	private IDtdParserAdapter readerAdapter; // 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaInfo schemaInfo; // 0x28
	private XmlCharType xmlCharType; // 0x30
	private string systemId; // 0x38
	private string publicId; // 0x40
	private bool normalize; // 0x48
	private bool validate; // 0x49
	private bool supportNamespaces; // 0x4A
	private bool v1Compat; // 0x4B
	private char[] chars; // 0x50
	private int charsUsed; // 0x58
	private int curPos; // 0x5C
	private DtdParser.ScanningFunction scanningFunction; // 0x60
	private DtdParser.ScanningFunction nextScaningFunction; // 0x64
	private DtdParser.ScanningFunction savedScanningFunction; // 0x68
	private bool whitespaceSeen; // 0x6C
	private int tokenStartPos; // 0x70
	private int colonPos; // 0x74
	private StringBuilder internalSubsetValueSb; // 0x78
	private int externalEntitiesDepth; // 0x80
	private int currentEntityId; // 0x84
	private bool freeFloatingDtd; // 0x88
	private bool hasFreeFloatingInternalSubset; // 0x89
	private StringBuilder stringBuilder; // 0x90
	private int condSectionDepth; // 0x98
	private LineInfo literalLineInfo; // 0x9C
	private char literalQuoteChar; // 0xA4
	private string documentBaseUri; // 0xA8
	private string externalDtdBaseUri; // 0xB0
	private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations; // 0xB8
	private int[] condSectionEntityIds; // 0xC0

	// Properties
	private bool ParsingInternalSubset { get; }
	private bool IgnoreEntityReferences { get; }
	private bool SaveInternalSubsetValue { get; }
	private bool ParsingTopLevelMarkup { get; }
	private bool SupportNamespaces { get; }
	private bool Normalize { get; }
	private int LineNo { get; }
	private int LinePos { get; }
	private string BaseUriStr { get; }

	// Methods

	// RVA: 0x202AEA0 Offset: 0x202A0A0 VA: 0x18202AEA0
	private void .ctor() { }

	// RVA: 0x201F9C0 Offset: 0x201EBC0 VA: 0x18201F9C0
	internal static IDtdParser Create() { }

	// RVA: 0x2021A30 Offset: 0x2020C30 VA: 0x182021A30
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x2021670 Offset: 0x2020870 VA: 0x182021670
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x202A4A0 Offset: 0x20296A0 VA: 0x18202A4A0 Slot: 4
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x202A450 Offset: 0x2029650 VA: 0x18202A450 Slot: 5
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x202B0E0 Offset: 0x202A2E0 VA: 0x18202B0E0
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x202B020 Offset: 0x202A220 VA: 0x18202B020
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x202B110 Offset: 0x202A310 VA: 0x18202B110
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x202B0F0 Offset: 0x202A2F0 VA: 0x18202B0F0
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0x190DBC0 Offset: 0x190CDC0 VA: 0x18190DBC0
	private bool get_SupportNamespaces() { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	private bool get_Normalize() { }

	// RVA: 0x2025340 Offset: 0x2024540 VA: 0x182025340
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x2024710 Offset: 0x2023910 VA: 0x182024710
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x2024640 Offset: 0x2023840 VA: 0x182024640
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x2024870 Offset: 0x2023A70 VA: 0x182024870
	private void ParseInternalSubset() { }

	// RVA: 0x20244B0 Offset: 0x20236B0 VA: 0x1820244B0
	private void ParseExternalSubset() { }

	// RVA: 0x2024BA0 Offset: 0x2023DA0 VA: 0x182024BA0
	private void ParseSubset() { }

	// RVA: 0x2021E30 Offset: 0x2021030 VA: 0x182021E30
	private void ParseAttlistDecl() { }

	// RVA: 0x2022660 Offset: 0x2021860 VA: 0x182022660
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x2022420 Offset: 0x2021620 VA: 0x182022420
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x2023140 Offset: 0x2022340 VA: 0x182023140
	private void ParseElementDecl() { }

	// RVA: 0x2023870 Offset: 0x2022A70 VA: 0x182023870
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x20246A0 Offset: 0x20238A0 VA: 0x1820246A0
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x2023560 Offset: 0x2022760 VA: 0x182023560
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x2023CF0 Offset: 0x2022EF0 VA: 0x182023CF0
	private void ParseEntityDecl() { }

	// RVA: 0x2024880 Offset: 0x2023A80 VA: 0x182024880
	private void ParseNotationDecl() { }

	// RVA: 0x201F7D0 Offset: 0x201E9D0 VA: 0x18201F7D0
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x2022D30 Offset: 0x2021F30 VA: 0x182022D30
	private void ParseComment() { }

	// RVA: 0x2024AB0 Offset: 0x2023CB0 VA: 0x182024AB0
	private void ParsePI() { }

	// RVA: 0x2022ED0 Offset: 0x20220D0 VA: 0x182022ED0
	private void ParseCondSection() { }

	// RVA: 0x2024070 Offset: 0x2023270 VA: 0x182024070
	private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId) { }

	// RVA: 0x201FE10 Offset: 0x201F010 VA: 0x18201FE10
	private DtdParser.Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x2029610 Offset: 0x2028810 VA: 0x182029610
	private DtdParser.Token ScanSubsetContent() { }

	// RVA: 0x2028EF0 Offset: 0x20280F0 VA: 0x182028EF0
	private DtdParser.Token ScanNameExpected() { }

	// RVA: 0x2029350 Offset: 0x2028550 VA: 0x182029350
	private DtdParser.Token ScanQNameExpected() { }

	// RVA: 0x2028F30 Offset: 0x2028130 VA: 0x182028F30
	private DtdParser.Token ScanNmtokenExpected() { }

	// RVA: 0x20272C0 Offset: 0x20264C0 VA: 0x1820272C0
	private DtdParser.Token ScanDoctype1() { }

	// RVA: 0x20273F0 Offset: 0x20265F0 VA: 0x1820273F0
	private DtdParser.Token ScanDoctype2() { }

	// RVA: 0x20267F0 Offset: 0x20259F0 VA: 0x1820267F0
	private DtdParser.Token ScanClosingTag() { }

	// RVA: 0x20274A0 Offset: 0x20266A0 VA: 0x1820274A0
	private DtdParser.Token ScanElement1() { }

	// RVA: 0x2027750 Offset: 0x2026950 VA: 0x182027750
	private DtdParser.Token ScanElement2() { }

	// RVA: 0x2027970 Offset: 0x2026B70 VA: 0x182027970
	private DtdParser.Token ScanElement3() { }

	// RVA: 0x20279F0 Offset: 0x2026BF0 VA: 0x1820279F0
	private DtdParser.Token ScanElement4() { }

	// RVA: 0x2027B00 Offset: 0x2026D00 VA: 0x182027B00
	private DtdParser.Token ScanElement5() { }

	// RVA: 0x2027BF0 Offset: 0x2026DF0 VA: 0x182027BF0
	private DtdParser.Token ScanElement6() { }

	// RVA: 0x2027CC0 Offset: 0x2026EC0 VA: 0x182027CC0
	private DtdParser.Token ScanElement7() { }

	// RVA: 0x2025870 Offset: 0x2024A70 VA: 0x182025870
	private DtdParser.Token ScanAttlist1() { }

	// RVA: 0x2025940 Offset: 0x2024B40 VA: 0x182025940
	private DtdParser.Token ScanAttlist2() { }

	// RVA: 0x2026090 Offset: 0x2025290 VA: 0x182026090
	private DtdParser.Token ScanAttlist3() { }

	// RVA: 0x2026130 Offset: 0x2025330 VA: 0x182026130
	private DtdParser.Token ScanAttlist4() { }

	// RVA: 0x2026200 Offset: 0x2025400 VA: 0x182026200
	private DtdParser.Token ScanAttlist5() { }

	// RVA: 0x20262D0 Offset: 0x20254D0 VA: 0x1820262D0
	private DtdParser.Token ScanAttlist6() { }

	// RVA: 0x2026740 Offset: 0x2025940 VA: 0x182026740
	private DtdParser.Token ScanAttlist7() { }

	// RVA: 0x20280D0 Offset: 0x20272D0 VA: 0x1820280D0
	private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType) { }

	// RVA: 0x2027FC0 Offset: 0x20271C0 VA: 0x182027FC0
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x2029130 Offset: 0x2028330 VA: 0x182029130
	private DtdParser.Token ScanNotation1() { }

	// RVA: 0x2029E10 Offset: 0x2029010 VA: 0x182029E10
	private DtdParser.Token ScanSystemId() { }

	// RVA: 0x2027D10 Offset: 0x2026F10 VA: 0x182027D10
	private DtdParser.Token ScanEntity1() { }

	// RVA: 0x2027D80 Offset: 0x2026F80 VA: 0x182027D80
	private DtdParser.Token ScanEntity2() { }

	// RVA: 0x2027EC0 Offset: 0x20270C0 VA: 0x182027EC0
	private DtdParser.Token ScanEntity3() { }

	// RVA: 0x2029230 Offset: 0x2028430 VA: 0x182029230
	private DtdParser.Token ScanPublicId1() { }

	// RVA: 0x20292E0 Offset: 0x20284E0 VA: 0x1820292E0
	private DtdParser.Token ScanPublicId2() { }

	// RVA: 0x2026870 Offset: 0x2025A70 VA: 0x182026870
	private DtdParser.Token ScanCondSection1() { }

	// RVA: 0x2026C20 Offset: 0x2025E20 VA: 0x182026C20
	private DtdParser.Token ScanCondSection2() { }

	// RVA: 0x2026CA0 Offset: 0x2025EA0 VA: 0x182026CA0
	private DtdParser.Token ScanCondSection3() { }

	// RVA: 0x2028F20 Offset: 0x2028120 VA: 0x182028F20
	private void ScanName() { }

	// RVA: 0x2029600 Offset: 0x2028800 VA: 0x182029600
	private void ScanQName() { }

	// RVA: 0x2029380 Offset: 0x2028580 VA: 0x182029380
	private void ScanQName(bool isQName) { }

	// RVA: 0x20256B0 Offset: 0x20248B0 VA: 0x1820256B0
	private bool ReadDataInName() { }

	// RVA: 0x2028F60 Offset: 0x2028160 VA: 0x182028F60
	private void ScanNmtoken() { }

	// RVA: 0x201FAB0 Offset: 0x201ECB0 VA: 0x18201FAB0
	private bool EatPublicKeyword() { }

	// RVA: 0x201FB70 Offset: 0x201ED70 VA: 0x18201FB70
	private bool EatSystemKeyword() { }

	// RVA: 0x201FC30 Offset: 0x201EE30 VA: 0x18201FC30
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x201FDE0 Offset: 0x201EFE0 VA: 0x18201FDE0
	private string GetNameString() { }

	// RVA: 0x201FDE0 Offset: 0x201EFE0 VA: 0x18201FDE0
	private string GetNmtokenString() { }

	// RVA: 0x2021150 Offset: 0x2020350 VA: 0x182021150
	private string GetValue() { }

	// RVA: 0x20210C0 Offset: 0x20202C0 VA: 0x1820210C0
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x20256F0 Offset: 0x20248F0 VA: 0x1820256F0
	private int ReadData() { }

	// RVA: 0x2021CA0 Offset: 0x2020EA0 VA: 0x182021CA0
	private void LoadParsingBuffer() { }

	// RVA: 0x2025860 Offset: 0x2024A60 VA: 0x182025860
	private void SaveParsingBuffer() { }

	// RVA: 0x2025770 Offset: 0x2024970 VA: 0x182025770
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x2021600 Offset: 0x2020800 VA: 0x182021600
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x2021330 Offset: 0x2020530 VA: 0x182021330
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x20211D0 Offset: 0x20203D0 VA: 0x1820211D0
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x202AC60 Offset: 0x2029E60 VA: 0x18202AC60
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x2029EC0 Offset: 0x20290C0 VA: 0x182029EC0
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x202A020 Offset: 0x2029220 VA: 0x18202A020
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x202A160 Offset: 0x2029360 VA: 0x18202A160
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x2021C90 Offset: 0x2020E90 VA: 0x182021C90
	private bool IsAttributeValueType(DtdParser.Token token) { }

	// RVA: 0x202B030 Offset: 0x202A230 VA: 0x18202B030
	private int get_LineNo() { }

	// RVA: 0x202B080 Offset: 0x202A280 VA: 0x18202B080
	private int get_LinePos() { }

	// RVA: 0x202AF60 Offset: 0x202A160 VA: 0x18202AF60
	private string get_BaseUriStr() { }

	// RVA: 0x2021DA0 Offset: 0x2020FA0 VA: 0x182021DA0
	private void OnUnexpectedError() { }

	// RVA: 0x202A730 Offset: 0x2029930 VA: 0x18202A730
	private void Throw(int curPos, string res) { }

	// RVA: 0x202A7A0 Offset: 0x20299A0 VA: 0x18202A7A0
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x202AAA0 Offset: 0x2029CA0 VA: 0x18202AAA0
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x202A960 Offset: 0x2029B60 VA: 0x18202A960
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x202A560 Offset: 0x2029760 VA: 0x18202A560
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x202A4E0 Offset: 0x20296E0 VA: 0x18202A4E0
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x202A5E0 Offset: 0x20297E0 VA: 0x18202A5E0
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x202A600 Offset: 0x2029800 VA: 0x18202A600
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x2025250 Offset: 0x2024450 VA: 0x182025250
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x202A260 Offset: 0x2029460 VA: 0x18202A260
	internal static string StripSpaces(string value) { }
}

// Namespace: System.Xml
public enum XmlTokenizedType // TypeDefIndex: 12068
{
	// Fields
	public int value__; // 0x0
	public const XmlTokenizedType CDATA = 0;
	public const XmlTokenizedType ID = 1;
	public const XmlTokenizedType IDREF = 2;
	public const XmlTokenizedType IDREFS = 3;
	public const XmlTokenizedType ENTITY = 4;
	public const XmlTokenizedType ENTITIES = 5;
	public const XmlTokenizedType NMTOKEN = 6;
	public const XmlTokenizedType NMTOKENS = 7;
	public const XmlTokenizedType NOTATION = 8;
	public const XmlTokenizedType ENUMERATION = 9;
	public const XmlTokenizedType QName = 10;
	public const XmlTokenizedType NCName = 11;
	public const XmlTokenizedType None = 12;
}

// Namespace: System.Xml
internal static class ValidateNames // TypeDefIndex: 12069
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0

	// Methods

	// RVA: 0x204A920 Offset: 0x2049B20 VA: 0x18204A920
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0x204A850 Offset: 0x2049A50 VA: 0x18204A850
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0x204A700 Offset: 0x2049900 VA: 0x18204A700
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0x204A520 Offset: 0x2049720 VA: 0x18204A520
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0x204A5E0 Offset: 0x20497E0 VA: 0x18204A5E0
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0x204A590 Offset: 0x2049790 VA: 0x18204A590
	internal static int ParseNCName(string s) { }

	// RVA: 0x204AB60 Offset: 0x2049D60 VA: 0x18204AB60
	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	// RVA: 0x204A9E0 Offset: 0x2049BE0 VA: 0x18204A9E0
	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	// RVA: 0x204AD90 Offset: 0x2049F90 VA: 0x18204AD90
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x204A2D0 Offset: 0x20494D0 VA: 0x18204A2D0
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x204AC40 Offset: 0x2049E40 VA: 0x18204AC40
	internal static void SplitQName(string name, out string prefix, out string lname) { }

	// RVA: 0x204AF80 Offset: 0x204A180 VA: 0x18204AF80
	private static void .cctor() { }
}

// Namespace: System.Xml
internal struct XmlCharType // TypeDefIndex: 12070
{
	// Fields
	private static object s_Lock; // 0x0
	private static byte[] s_CharProperties; // 0x8
	internal byte[] charProperties; // 0x0

	// Properties
	private static object StaticLock { get; }
	public static XmlCharType Instance { get; }

	// Methods

	// RVA: 0x2050160 Offset: 0x204F360 VA: 0x182050160
	private static object get_StaticLock() { }

	// RVA: 0x204F480 Offset: 0x204E680 VA: 0x18204F480
	private static void InitInstance() { }

	// RVA: 0x204FFF0 Offset: 0x204F1F0 VA: 0x18204FFF0
	private static void SetProperties(byte[] chProps, string ranges, byte value) { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	private void .ctor(byte[] charProperties) { }

	// RVA: 0x20500F0 Offset: 0x204F2F0 VA: 0x1820500F0
	public static XmlCharType get_Instance() { }

	// RVA: 0x204FFB0 Offset: 0x204F1B0 VA: 0x18204FFB0
	public bool IsWhiteSpace(char ch) { }

	// RVA: 0x204FAF0 Offset: 0x204ECF0 VA: 0x18204FAF0
	public bool IsNCNameSingleChar(char ch) { }

	// RVA: 0x204FF30 Offset: 0x204F130 VA: 0x18204FF30
	public bool IsStartNCNameSingleChar(char ch) { }

	// RVA: 0x204FB70 Offset: 0x204ED70 VA: 0x18204FB70
	public bool IsNameSingleChar(char ch) { }

	// RVA: 0x204FA30 Offset: 0x204EC30 VA: 0x18204FA30
	public bool IsCharData(char ch) { }

	// RVA: 0x204FE00 Offset: 0x204F000 VA: 0x18204FE00
	public bool IsPubidChar(char ch) { }

	// RVA: 0x204FF70 Offset: 0x204F170 VA: 0x18204FF70
	internal bool IsTextChar(char ch) { }

	// RVA: 0x204FA70 Offset: 0x204EC70 VA: 0x18204FA70
	public bool IsLetter(char ch) { }

	// RVA: 0x204FAB0 Offset: 0x204ECB0 VA: 0x18204FAB0
	public bool IsNCNameCharXml4e(char ch) { }

	// RVA: 0x204FEF0 Offset: 0x204F0F0 VA: 0x18204FEF0
	public bool IsStartNCNameCharXml4e(char ch) { }

	// RVA: 0x204FB30 Offset: 0x204ED30 VA: 0x18204FB30
	public bool IsNameCharXml4e(char ch) { }

	// RVA: 0x178D780 Offset: 0x178C980 VA: 0x18178D780
	public static bool IsDigit(char ch) { }

	// RVA: 0x1BDD990 Offset: 0x1BDCB90 VA: 0x181BDD990
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0x1BDD9A0 Offset: 0x1BDCBA0 VA: 0x181BDD9A0
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0x1BDD9B0 Offset: 0x1BDCBB0 VA: 0x181BDD9B0
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0x204F460 Offset: 0x204E660 VA: 0x18204F460
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0x20500B0 Offset: 0x204F2B0 VA: 0x1820500B0
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

	// RVA: 0x204FD70 Offset: 0x204EF70 VA: 0x18204FD70
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x204FCF0 Offset: 0x204EEF0 VA: 0x18204FCF0
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x204FBB0 Offset: 0x204EDB0 VA: 0x18204FBB0
	internal int IsOnlyCharData(string str) { }

	// RVA: 0x204FC80 Offset: 0x204EE80 VA: 0x18204FC80
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x204FE80 Offset: 0x204F080 VA: 0x18204FE80
	internal int IsPublicId(string str) { }

	// RVA: 0x10DD040 Offset: 0x10DC240 VA: 0x1810DD040
	private static bool InRange(int value, int start, int end) { }
}

// Namespace: System.Xml
internal static class XmlComplianceUtil // TypeDefIndex: 12071
{
	// Methods

	// RVA: 0x20503E0 Offset: 0x204F5E0 VA: 0x1820503E0
	public static string NonCDataNormalize(string value) { }

	// RVA: 0x2050200 Offset: 0x204F400 VA: 0x182050200
	public static string CDataNormalize(string value) { }
}

// Namespace: System.Xml
internal enum ExceptionType // TypeDefIndex: 12072
{
	// Fields
	public int value__; // 0x0
	public const ExceptionType ArgumentException = 0;
	public const ExceptionType XmlException = 1;
}

// Namespace: System.Xml
public enum XmlDateTimeSerializationMode // TypeDefIndex: 12073
{
	// Fields
	public int value__; // 0x0
	public const XmlDateTimeSerializationMode Local = 0;
	public const XmlDateTimeSerializationMode Utc = 1;
	public const XmlDateTimeSerializationMode Unspecified = 2;
	public const XmlDateTimeSerializationMode RoundtripKind = 3;
}

// Namespace: System.Xml
public class XmlConvert // TypeDefIndex: 12074
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0
	internal static char[] crt; // 0x8
	private static readonly int c_EncodedCharLength; // 0x10
	private static Regex c_EncodeCharPattern; // 0x18
	private static Regex c_DecodeCharPattern; // 0x20
	private static string[] s_allDateTimeFormats; // 0x28
	internal static readonly char[] WhitespaceChars; // 0x30

	// Properties
	private static string[] AllDateTimeFormats { get; }

	// Methods

	// RVA: 0x2052210 Offset: 0x2051410 VA: 0x182052210
	public static string EncodeName(string name) { }

	// RVA: 0x20521B0 Offset: 0x20513B0 VA: 0x1820521B0
	public static string EncodeLocalName(string name) { }

	// RVA: 0x2051980 Offset: 0x2050B80 VA: 0x182051980
	public static string DecodeName(string name) { }

	// RVA: 0x2052260 Offset: 0x2051460 VA: 0x182052260
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0x2052C20 Offset: 0x2051E20 VA: 0x182052C20
	private static int FromHex(char digit) { }

	// RVA: 0x2052AF0 Offset: 0x2051CF0 VA: 0x182052AF0
	internal static byte[] FromBinHexString(string s) { }

	// RVA: 0x2052BA0 Offset: 0x2051DA0 VA: 0x182052BA0
	internal static byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0x2052F80 Offset: 0x2052180 VA: 0x182052F80
	internal static string ToBinHexString(byte[] inArray) { }

	// RVA: 0x2057730 Offset: 0x2056930 VA: 0x182057730
	public static string VerifyName(string name) { }

	// RVA: 0x2056E30 Offset: 0x2056030 VA: 0x182056E30
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0x2057890 Offset: 0x2056A90 VA: 0x182057890
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0x2057420 Offset: 0x2056620 VA: 0x182057420
	public static string VerifyNCName(string name) { }

	// RVA: 0x20575C0 Offset: 0x20567C0 VA: 0x1820575C0
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0x2056B70 Offset: 0x2055D70 VA: 0x182056B70
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0x2057A60 Offset: 0x2056C60 VA: 0x182057A60
	public static string VerifyTOKEN(string token) { }

	// RVA: 0x2057080 Offset: 0x2056280 VA: 0x182057080
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0x2056C40 Offset: 0x2055E40 VA: 0x182056C40
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0x2056FB0 Offset: 0x20561B0 VA: 0x182056FB0
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0x20543E0 Offset: 0x20535E0 VA: 0x1820543E0
	public static string ToString(bool value) { }

	// RVA: 0x2054080 Offset: 0x2053280 VA: 0x182054080
	public static string ToString(char value) { }

	// RVA: 0x2054010 Offset: 0x2053210 VA: 0x182054010
	public static string ToString(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x2054520 Offset: 0x2053720 VA: 0x182054520
	public static string ToString(sbyte value) { }

	// RVA: 0x2053F70 Offset: 0x2053170 VA: 0x182053F70
	public static string ToString(short value) { }

	// RVA: 0x2053FA0 Offset: 0x20531A0 VA: 0x182053FA0
	public static string ToString(int value) { }

	// RVA: 0x2054550 Offset: 0x2053750 VA: 0x182054550
	public static string ToString(long value) { }

	// RVA: 0x2053FE0 Offset: 0x20531E0 VA: 0x182053FE0
	public static string ToString(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x2053F40 Offset: 0x2053140 VA: 0x182053F40
	public static string ToString(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x20540D0 Offset: 0x20532D0 VA: 0x1820540D0
	public static string ToString(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x2054170 Offset: 0x2053370 VA: 0x182054170
	public static string ToString(ulong value) { }

	// RVA: 0x2053E40 Offset: 0x2053040 VA: 0x182053E40
	public static string ToString(float value) { }

	// RVA: 0x2053D40 Offset: 0x2052F40 VA: 0x182053D40
	public static string ToString(double value) { }

	// RVA: 0x2054430 Offset: 0x2053630 VA: 0x182054430
	public static string ToString(TimeSpan value) { }

	// RVA: 0x2054490 Offset: 0x2053690 VA: 0x182054490
	public static string ToString(DateTime value, string format) { }

	// RVA: 0x20541A0 Offset: 0x20533A0 VA: 0x1820541A0
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x2054100 Offset: 0x2053300 VA: 0x182054100
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x2053FD0 Offset: 0x20531D0 VA: 0x182053FD0
	public static string ToString(Guid value) { }

	// RVA: 0x2052FF0 Offset: 0x20521F0 VA: 0x182052FF0
	public static bool ToBoolean(string s) { }

	// RVA: 0x2054DD0 Offset: 0x2053FD0 VA: 0x182054DD0
	internal static Exception TryToBoolean(string s, out bool result) { }

	// RVA: 0x2053240 Offset: 0x2052440 VA: 0x182053240
	public static char ToChar(string s) { }

	// RVA: 0x20551C0 Offset: 0x20543C0 VA: 0x1820551C0
	internal static Exception TryToChar(string s, out char result) { }

	// RVA: 0x2053860 Offset: 0x2052A60 VA: 0x182053860
	public static Decimal ToDecimal(string s) { }

	// RVA: 0x2055340 Offset: 0x2054540 VA: 0x182055340
	internal static Exception TryToDecimal(string s, out Decimal result) { }

	// RVA: 0x2053B10 Offset: 0x2052D10 VA: 0x182053B10
	internal static Decimal ToInteger(string s) { }

	// RVA: 0x2055E00 Offset: 0x2055000 VA: 0x182055E00
	internal static Exception TryToInteger(string s, out Decimal result) { }

	[CLSCompliant(False)]
	// RVA: 0x2053BA0 Offset: 0x2052DA0 VA: 0x182053BA0
	public static sbyte ToSByte(string s) { }

	// RVA: 0x2055FA0 Offset: 0x20551A0 VA: 0x182055FA0
	internal static Exception TryToSByte(string s, out sbyte result) { }

	// RVA: 0x2053A80 Offset: 0x2052C80 VA: 0x182053A80
	public static short ToInt16(string s) { }

	// RVA: 0x20559B0 Offset: 0x2054BB0 VA: 0x1820559B0
	internal static Exception TryToInt16(string s, out short result) { }

	// RVA: 0x2053AB0 Offset: 0x2052CB0 VA: 0x182053AB0
	public static int ToInt32(string s) { }

	// RVA: 0x2055B20 Offset: 0x2054D20 VA: 0x182055B20
	internal static Exception TryToInt32(string s, out int result) { }

	// RVA: 0x2053AE0 Offset: 0x2052CE0 VA: 0x182053AE0
	public static long ToInt64(string s) { }

	// RVA: 0x2055C90 Offset: 0x2054E90 VA: 0x182055C90
	internal static Exception TryToInt64(string s, out long result) { }

	// RVA: 0x2053210 Offset: 0x2052410 VA: 0x182053210
	public static byte ToByte(string s) { }

	// RVA: 0x2055050 Offset: 0x2054250 VA: 0x182055050
	internal static Exception TryToByte(string s, out byte result) { }

	[CLSCompliant(False)]
	// RVA: 0x20546E0 Offset: 0x20538E0 VA: 0x1820546E0
	public static ushort ToUInt16(string s) { }

	// RVA: 0x2056450 Offset: 0x2055650 VA: 0x182056450
	internal static Exception TryToUInt16(string s, out ushort result) { }

	[CLSCompliant(False)]
	// RVA: 0x2054710 Offset: 0x2053910 VA: 0x182054710
	public static uint ToUInt32(string s) { }

	// RVA: 0x20565C0 Offset: 0x20557C0 VA: 0x1820565C0
	internal static Exception TryToUInt32(string s, out uint result) { }

	[CLSCompliant(False)]
	// RVA: 0x2054740 Offset: 0x2053940 VA: 0x182054740
	public static ulong ToUInt64(string s) { }

	// RVA: 0x2056730 Offset: 0x2055930 VA: 0x182056730
	internal static Exception TryToUInt64(string s, out ulong result) { }

	// RVA: 0x2053BD0 Offset: 0x2052DD0 VA: 0x182053BD0
	public static float ToSingle(string s) { }

	// RVA: 0x2056110 Offset: 0x2055310 VA: 0x182056110
	internal static Exception TryToSingle(string s, out float result) { }

	// RVA: 0x20538F0 Offset: 0x2052AF0 VA: 0x1820538F0
	public static double ToDouble(string s) { }

	// RVA: 0x20554E0 Offset: 0x20546E0 VA: 0x1820554E0
	internal static Exception TryToDouble(string s, out double result) { }

	// RVA: 0x2054A50 Offset: 0x2053C50 VA: 0x182054A50
	internal static double ToXPathDouble(object o) { }

	// RVA: 0x2057B90 Offset: 0x2056D90 VA: 0x182057B90
	internal static double XPathRound(double value) { }

	// RVA: 0x2054580 Offset: 0x2053780 VA: 0x182054580
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0x20563A0 Offset: 0x20555A0 VA: 0x1820563A0
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	// RVA: 0x2057DC0 Offset: 0x2056FC0 VA: 0x182057DC0
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0x20506C0 Offset: 0x204F8C0 VA: 0x1820506C0
	private static void CreateAllDateTimeFormats() { }

	[Obsolete("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
	// RVA: 0x2053650 Offset: 0x2052850 VA: 0x182053650
	public static DateTime ToDateTime(string s) { }

	// RVA: 0x20537C0 Offset: 0x20529C0 VA: 0x1820537C0
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0x20533F0 Offset: 0x20525F0 VA: 0x1820533F0
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x2053310 Offset: 0x2052510 VA: 0x182053310
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0x2053A60 Offset: 0x2052C60 VA: 0x182053A60
	public static Guid ToGuid(string s) { }

	// RVA: 0x2055780 Offset: 0x2054980 VA: 0x182055780
	internal static Exception TryToGuid(string s, out Guid result) { }

	// RVA: 0x2052DE0 Offset: 0x2051FE0 VA: 0x182052DE0
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x2052EB0 Offset: 0x20520B0 VA: 0x182052EB0
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x2054770 Offset: 0x2053970 VA: 0x182054770
	internal static Uri ToUri(string s) { }

	// RVA: 0x20568A0 Offset: 0x2055AA0 VA: 0x1820568A0
	internal static Exception TryToUri(string s, out Uri result) { }

	// RVA: 0x2052D30 Offset: 0x2051F30 VA: 0x182052D30
	internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0x2054D60 Offset: 0x2053F60 VA: 0x182054D60
	internal static string TrimString(string value) { }

	// RVA: 0x2054CF0 Offset: 0x2053EF0 VA: 0x182054CF0
	internal static string TrimStringStart(string value) { }

	// RVA: 0x2054C80 Offset: 0x2053E80 VA: 0x182054C80
	internal static string TrimStringEnd(string value) { }

	// RVA: 0x2052CC0 Offset: 0x2051EC0 VA: 0x182052CC0
	internal static string[] SplitString(string value) { }

	// RVA: 0x2052C50 Offset: 0x2051E50 VA: 0x182052C50
	internal static bool IsNegativeZero(double value) { }

	// RVA: 0x176B280 Offset: 0x176A480 VA: 0x18176B280
	private static long DoubleToInt64Bits(double value) { }

	// RVA: 0x20571A0 Offset: 0x20563A0 VA: 0x1820571A0
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0x2050CE0 Offset: 0x204FEE0 VA: 0x182050CE0
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x2050AC0 Offset: 0x204FCC0 VA: 0x182050AC0
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x2050DC0 Offset: 0x204FFC0 VA: 0x182050DC0
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0x2050C00 Offset: 0x204FE00 VA: 0x182050C00
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x2051700 Offset: 0x2050900 VA: 0x182051700
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	// RVA: 0x20517A0 Offset: 0x20509A0 VA: 0x1820517A0
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	// RVA: 0x2051820 Offset: 0x2050A20 VA: 0x182051820
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x20514E0 Offset: 0x20506E0 VA: 0x1820514E0
	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	// RVA: 0x2051120 Offset: 0x2050320 VA: 0x182051120
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	// RVA: 0x2051310 Offset: 0x2050510 VA: 0x182051310
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x2050F10 Offset: 0x2050110 VA: 0x182050F10
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0x2050FF0 Offset: 0x20501F0 VA: 0x182050FF0
	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	// RVA: 0x2050E40 Offset: 0x2050040 VA: 0x182050E40
	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	// RVA: 0x20515F0 Offset: 0x20507F0 VA: 0x1820515F0
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0x2051530 Offset: 0x2050730 VA: 0x182051530
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0x2057C80 Offset: 0x2056E80 VA: 0x182057C80
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class XmlDownloadManager.<>c__DisplayClass4_0 // TypeDefIndex: 12075
{
	// Fields
	public Uri uri; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2048340 Offset: 0x2047540 VA: 0x182048340
	internal Stream <GetStreamAsync>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private struct XmlDownloadManager.<GetNonFileStreamAsync>d__5 : IAsyncStateMachine // TypeDefIndex: 12076
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public Uri uri; // 0x20
	public ICredentials credentials; // 0x28
	public IWebProxy proxy; // 0x30
	public RequestCachePolicy cachePolicy; // 0x38
	public XmlDownloadManager <>4__this; // 0x40
	private WebRequest <req>5__2; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse> <>u__1; // 0x50

	// Methods

	// RVA: 0x2047B20 Offset: 0x2046D20 VA: 0x182047B20 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x20482D0 Offset: 0x20474D0 VA: 0x1820482D0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Xml
internal class XmlDownloadManager // TypeDefIndex: 12077
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x2058680 Offset: 0x2057880 VA: 0x182058680
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x2057FA0 Offset: 0x20571A0 VA: 0x182057FA0
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x2058790 Offset: 0x2057990 VA: 0x182058790
	internal void Remove(string host) { }

	// RVA: 0x2058450 Offset: 0x2057650 VA: 0x182058450
	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachine(typeof(XmlDownloadManager.<GetNonFileStreamAsync>d__5))]
	// RVA: 0x2057E70 Offset: 0x2057070 VA: 0x182057E70
	private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml
internal class OpenedHost // TypeDefIndex: 12078
{
	// Fields
	internal int nonCachedConnectionsCount; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml
internal class XmlRegisteredNonCachedStream : Stream // TypeDefIndex: 12079
{
	// Fields
	protected Stream stream; // 0x28
	private XmlDownloadManager downloadManager; // 0x30
	private string host; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x205C2C0 Offset: 0x205B4C0 VA: 0x18205C2C0
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0x205C150 Offset: 0x205B350 VA: 0x18205C150 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x205BFE0 Offset: 0x205B1E0 VA: 0x18205BFE0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x205BF60 Offset: 0x205B160 VA: 0x18205BF60 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x205BFA0 Offset: 0x205B1A0 VA: 0x18205BFA0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x205C0F0 Offset: 0x205B2F0 VA: 0x18205C0F0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x205C120 Offset: 0x205B320 VA: 0x18205C120 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x173D3E0 Offset: 0x173C5E0 VA: 0x18173D3E0 Slot: 22
	public override void Flush() { }

	// RVA: 0x205C200 Offset: 0x205B400 VA: 0x18205C200 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x205C1D0 Offset: 0x205B3D0 VA: 0x18205C1D0 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x205C230 Offset: 0x205B430 VA: 0x18205C230 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x173D050 Offset: 0x173C250 VA: 0x18173D050 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x205C290 Offset: 0x205B490 VA: 0x18205C290 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x205C260 Offset: 0x205B460 VA: 0x18205C260 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x1C954E0 Offset: 0x1C946E0 VA: 0x181C954E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x557000 Offset: 0x556200 VA: 0x180557000 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x205C340 Offset: 0x205B540 VA: 0x18205C340 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x8008F0 Offset: 0x7FFAF0 VA: 0x1808008F0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1D8AE70 Offset: 0x1D8A070 VA: 0x181D8AE70 Slot: 12
	public override long get_Position() { }

	// RVA: 0x205C370 Offset: 0x205B570 VA: 0x18205C370 Slot: 13
	public override void set_Position(long value) { }
}

// Namespace: System.Xml
internal class XmlCachedStream : MemoryStream // TypeDefIndex: 12080
{
	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0x204F310 Offset: 0x204E510 VA: 0x18204F310
	internal void .ctor(Uri uri, Stream stream) { }
}

// Namespace: System.Xml
internal class UTF16Decoder : Decoder // TypeDefIndex: 12081
{
	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0x2048990 Offset: 0x2047B90 VA: 0x182048990
	public void .ctor(bool bigEndian) { }

	// RVA: 0x15B4300 Offset: 0x15B3500 VA: 0x1815B4300 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2048670 Offset: 0x2047870 VA: 0x182048670 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x2048770 Offset: 0x2047970 VA: 0x182048770 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x20483E0 Offset: 0x20475E0 VA: 0x1820483E0 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}

// Namespace: System.Xml
internal class SafeAsciiDecoder : Decoder // TypeDefIndex: 12082
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x1FE0740 Offset: 0x1FDF940 VA: 0x181FE0740 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2041580 Offset: 0x2040780 VA: 0x182041580 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x20414A0 Offset: 0x20406A0 VA: 0x1820414A0 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}

// Namespace: System.Xml
internal class Ucs4Encoding : Encoding // TypeDefIndex: 12083
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Properties
	public override string WebName { get; }
	public override int CodePage { get; }
	internal static Encoding UCS4_Littleendian { get; }
	internal static Encoding UCS4_Bigendian { get; }
	internal static Encoding UCS4_2143 { get; }
	internal static Encoding UCS4_3412 { get; }

	// Methods

	// RVA: 0x75AB00 Offset: 0x759D00 VA: 0x18075AB00 Slot: 11
	public override string get_WebName() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x2049E10 Offset: 0x2049010 VA: 0x182049E10 Slot: 14
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 20
	public override byte[] GetBytes(string s) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 19
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x2049E80 Offset: 0x2049080 VA: 0x182049E80 Slot: 24
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2049EB0 Offset: 0x20490B0 VA: 0x182049EB0 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2049EF0 Offset: 0x20490F0 VA: 0x182049EF0 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 31
	public override int get_CodePage() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x204A150 Offset: 0x2049350 VA: 0x18204A150
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0x204A090 Offset: 0x2049290 VA: 0x18204A090
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0x2049F10 Offset: 0x2049110 VA: 0x182049F10
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0x2049FD0 Offset: 0x20491D0 VA: 0x182049FD0
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0x2049F00 Offset: 0x2049100 VA: 0x182049F00
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding1234 : Ucs4Encoding // TypeDefIndex: 12084
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x20499F0 Offset: 0x2048BF0 VA: 0x1820499F0
	public void .ctor() { }

	// RVA: 0x2049A80 Offset: 0x2048C80 VA: 0x182049A80 Slot: 9
	public override string get_EncodingName() { }

	// RVA: 0x2049990 Offset: 0x2048B90 VA: 0x182049990 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding4321 : Ucs4Encoding // TypeDefIndex: 12085
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2049D50 Offset: 0x2048F50 VA: 0x182049D50
	public void .ctor() { }

	// RVA: 0x2049DE0 Offset: 0x2048FE0 VA: 0x182049DE0 Slot: 9
	public override string get_EncodingName() { }

	// RVA: 0x2049CF0 Offset: 0x2048EF0 VA: 0x182049CF0 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding2143 : Ucs4Encoding // TypeDefIndex: 12086
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2049B10 Offset: 0x2048D10 VA: 0x182049B10
	public void .ctor() { }

	// RVA: 0x2049BA0 Offset: 0x2048DA0 VA: 0x182049BA0 Slot: 9
	public override string get_EncodingName() { }

	// RVA: 0x2049AB0 Offset: 0x2048CB0 VA: 0x182049AB0 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding3412 : Ucs4Encoding // TypeDefIndex: 12087
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2049C30 Offset: 0x2048E30 VA: 0x182049C30
	public void .ctor() { }

	// RVA: 0x2049CC0 Offset: 0x2048EC0 VA: 0x182049CC0 Slot: 9
	public override string get_EncodingName() { }

	// RVA: 0x2049BD0 Offset: 0x2048DD0 VA: 0x182049BD0 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal abstract class Ucs4Decoder : Decoder // TypeDefIndex: 12088
{
	// Fields
	internal byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0x2049750 Offset: 0x2048950 VA: 0x182049750 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x2049760 Offset: 0x2048960 VA: 0x182049760 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2049510 Offset: 0x2048710 VA: 0x182049510 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x2049920 Offset: 0x2048B20 VA: 0x182049920
	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

	// RVA: 0x2048C80 Offset: 0x2047E80 VA: 0x182048C80
	protected void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder4321 : Ucs4Decoder // TypeDefIndex: 12089
{
	// Methods

	// RVA: 0x2049250 Offset: 0x2048450 VA: 0x182049250 Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2048C80 Offset: 0x2047E80 VA: 0x182048C80
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder1234 : Ucs4Decoder // TypeDefIndex: 12090
{
	// Methods

	// RVA: 0x20489C0 Offset: 0x2047BC0 VA: 0x1820489C0 Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2048C80 Offset: 0x2047E80 VA: 0x182048C80
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder2143 : Ucs4Decoder // TypeDefIndex: 12091
{
	// Methods

	// RVA: 0x2048CD0 Offset: 0x2047ED0 VA: 0x182048CD0 Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2048C80 Offset: 0x2047E80 VA: 0x182048C80
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder3412 : Ucs4Decoder // TypeDefIndex: 12092
{
	// Methods

	// RVA: 0x2048F90 Offset: 0x2048190 VA: 0x182048F90 Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2048C80 Offset: 0x2047E80 VA: 0x182048C80
	public void .ctor() { }
}

// Namespace: System.Xml
[Serializable]
public class XmlException : SystemException // TypeDefIndex: 12093
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private int lineNumber; // 0xA0
	private int linePosition; // 0xA4
	[OptionalField]
	private string sourceUri; // 0xA8
	private string message; // 0xB0

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	public override string Message { get; }
	internal string ResString { get; }

	// Methods

	// RVA: 0x2059320 Offset: 0x2058520 VA: 0x182059320
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2058F30 Offset: 0x2058130 VA: 0x182058F30 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20597A0 Offset: 0x20589A0 VA: 0x1820597A0
	public void .ctor() { }

	// RVA: 0x2059780 Offset: 0x2058980 VA: 0x182059780
	public void .ctor(string message) { }

	// RVA: 0x2059300 Offset: 0x2058500 VA: 0x182059300
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x2059080 Offset: 0x2058280 VA: 0x182059080
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x2059B80 Offset: 0x2058D80 VA: 0x182059B80
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x2059D10 Offset: 0x2058F10 VA: 0x182059D10
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x2059FE0 Offset: 0x20591E0 VA: 0x182059FE0
	internal void .ctor(string res, string arg) { }

	// RVA: 0x2059F00 Offset: 0x2059100 VA: 0x182059F00
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x2059A30 Offset: 0x2058C30 VA: 0x182059A30
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x2059920 Offset: 0x2058B20 VA: 0x182059920
	internal void .ctor(string res, string arg, Exception innerException, IXmlLineInfo lineInfo) { }

	// RVA: 0x2059E40 Offset: 0x2059040 VA: 0x182059E40
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x205A0B0 Offset: 0x20592B0 VA: 0x18205A0B0
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x2059210 Offset: 0x2058410 VA: 0x182059210
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x2059800 Offset: 0x2058A00 VA: 0x182059800
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x20598F0 Offset: 0x2058AF0 VA: 0x1820598F0
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x2059B40 Offset: 0x2058D40 VA: 0x182059B40
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x20597D0 Offset: 0x20589D0 VA: 0x1820597D0
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x2059D90 Offset: 0x2058F90 VA: 0x182059D90
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x2058E60 Offset: 0x2058060 VA: 0x182058E60
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x2058CD0 Offset: 0x2057ED0 VA: 0x182058CD0
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x2058980 Offset: 0x2057B80 VA: 0x182058980
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x2058C70 Offset: 0x2057E70 VA: 0x182058C70
	internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex) { }

	// RVA: 0x20589F0 Offset: 0x2057BF0 VA: 0x1820589F0
	internal static string[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	// RVA: 0x5E7ED0 Offset: 0x5E70D0 VA: 0x1805E7ED0
	public int get_LineNumber() { }

	// RVA: 0x6DCF10 Offset: 0x6DC110 VA: 0x1806DCF10
	public int get_LinePosition() { }

	// RVA: 0x205A170 Offset: 0x2059370 VA: 0x18205A170 Slot: 5
	public override string get_Message() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	internal string get_ResString() { }
}

// Namespace: System.Xml
public abstract class XmlNameTable // TypeDefIndex: 12094
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string Get(string array);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string Add(char[] array, int offset, int length);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string Add(string array);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml
public enum XmlNamespaceScope // TypeDefIndex: 12095
{
	// Fields
	public int value__; // 0x0
	public const XmlNamespaceScope All = 0;
	public const XmlNamespaceScope ExcludeXml = 1;
	public const XmlNamespaceScope Local = 2;
}

// Namespace: 
private struct XmlNamespaceManager.NamespaceDeclaration // TypeDefIndex: 12096
{
	// Fields
	public string prefix; // 0x0
	public string uri; // 0x8
	public int scopeId; // 0x10
	public int previousNsIndex; // 0x14

	// Methods

	// RVA: 0x2040B50 Offset: 0x203FD50 VA: 0x182040B50
	public void Set(string prefix, string uri, int scopeId, int previousNsIndex) { }
}

// Namespace: System.Xml
public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable // TypeDefIndex: 12097
{
	// Fields
	private XmlNamespaceManager.NamespaceDeclaration[] nsdecls; // 0x10
	private int lastDecl; // 0x18
	private XmlNameTable nameTable; // 0x20
	private int scopeId; // 0x28
	private Dictionary<string, int> hashTable; // 0x30
	private bool useHashtable; // 0x38
	private string xml; // 0x40
	private string xmlNs; // 0x48

	// Properties
	public virtual XmlNameTable NameTable { get; }
	public virtual string DefaultNamespace { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x205AE30 Offset: 0x205A030 VA: 0x18205AE30
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 8
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x205B020 Offset: 0x205A220 VA: 0x18205B020 Slot: 9
	public virtual string get_DefaultNamespace() { }

	// RVA: 0xCB8260 Offset: 0xCB7460 VA: 0x180CB8260 Slot: 10
	public virtual void PushScope() { }

	// RVA: 0x205ABB0 Offset: 0x2059DB0 VA: 0x18205ABB0 Slot: 11
	public virtual bool PopScope() { }

	// RVA: 0x205A190 Offset: 0x2059390 VA: 0x18205A190 Slot: 12
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x205ACA0 Offset: 0x2059EA0 VA: 0x18205ACA0 Slot: 13
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x205A5B0 Offset: 0x20597B0 VA: 0x18205A5B0 Slot: 14
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x205A720 Offset: 0x2059920 VA: 0x18205A720 Slot: 15
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x205AA80 Offset: 0x2059C80 VA: 0x18205AA80 Slot: 16
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x205A8D0 Offset: 0x2059AD0 VA: 0x18205A8D0
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x205AAD0 Offset: 0x2059CD0 VA: 0x18205AAD0 Slot: 17
	public virtual string LookupPrefix(string uri) { }
}

// Namespace: System.Xml
public enum XmlNodeOrder // TypeDefIndex: 12098
{
	// Fields
	public int value__; // 0x0
	public const XmlNodeOrder Before = 0;
	public const XmlNodeOrder After = 1;
	public const XmlNodeOrder Same = 2;
	public const XmlNodeOrder Unknown = 3;
}

// Namespace: System.Xml
public enum XmlNodeType // TypeDefIndex: 12099
{
	// Fields
	public int value__; // 0x0
	public const XmlNodeType None = 0;
	public const XmlNodeType Element = 1;
	public const XmlNodeType Attribute = 2;
	public const XmlNodeType Text = 3;
	public const XmlNodeType CDATA = 4;
	public const XmlNodeType EntityReference = 5;
	public const XmlNodeType Entity = 6;
	public const XmlNodeType ProcessingInstruction = 7;
	public const XmlNodeType Comment = 8;
	public const XmlNodeType Document = 9;
	public const XmlNodeType DocumentType = 10;
	public const XmlNodeType DocumentFragment = 11;
	public const XmlNodeType Notation = 12;
	public const XmlNodeType Whitespace = 13;
	public const XmlNodeType SignificantWhitespace = 14;
	public const XmlNodeType EndElement = 15;
	public const XmlNodeType EndEntity = 16;
	public const XmlNodeType XmlDeclaration = 17;
}

// Namespace: 
private sealed class XmlQualifiedName.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 12100
{
	// Methods

	// RVA: 0x1FDFFE0 Offset: 0x1FDF1E0 VA: 0x181FDFFE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }
}

// Namespace: System.Xml
[Serializable]
public class XmlQualifiedName // TypeDefIndex: 12101
{
	// Fields
	private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private string name; // 0x10
	private string ns; // 0x18
	private int hash; // 0x20
	public static readonly XmlQualifiedName Empty; // 0x8

	// Properties
	public string Namespace { get; }
	public string Name { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x205BD50 Offset: 0x205AF50 VA: 0x18205BD50
	public void .ctor() { }

	// RVA: 0x205BC00 Offset: 0x205AE00 VA: 0x18205BC00
	public void .ctor(string name) { }

	// RVA: 0x205BCC0 Offset: 0x205AEC0 VA: 0x18205BCC0
	public void .ctor(string name, string ns) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Namespace() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x205B530 Offset: 0x205A730 VA: 0x18205B530 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x205BE10 Offset: 0x205B010 VA: 0x18205BE10
	public bool get_IsEmpty() { }

	// RVA: 0x205B980 Offset: 0x205AB80 VA: 0x18205B980 Slot: 3
	public override string ToString() { }

	// RVA: 0x205B220 Offset: 0x205A420 VA: 0x18205B220 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x205BE50 Offset: 0x205B050 VA: 0x18205BE50
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x205BEC0 Offset: 0x205B0C0 VA: 0x18205BEC0
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x205B9E0 Offset: 0x205ABE0 VA: 0x18205B9E0
	public static string ToString(string name, string ns) { }

	// RVA: 0x205B340 Offset: 0x205A540 VA: 0x18205B340
	private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0xCB0640 Offset: 0xCAF840 VA: 0x180CB0640
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	// RVA: 0x205B620 Offset: 0x205A820 VA: 0x18205B620
	internal void Init(string name, string ns) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void SetNamespace(string ns) { }

	// RVA: 0x205BA50 Offset: 0x205AC50 VA: 0x18205BA50
	internal void Verify() { }

	// RVA: 0x205B120 Offset: 0x205A320 VA: 0x18205B120
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0x205B630 Offset: 0x205A830 VA: 0x18205B630
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	// RVA: 0x205B190 Offset: 0x205A390 VA: 0x18205B190
	internal XmlQualifiedName Clone() { }

	// RVA: 0x205BAE0 Offset: 0x205ACE0 VA: 0x18205BAE0
	private static void .cctor() { }
}

// Namespace: System.Xml
public abstract class XmlResolver // TypeDefIndex: 12102
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

	// RVA: 0x205C3E0 Offset: 0x205B5E0 VA: 0x18205C3E0 Slot: 5
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x205C5D0 Offset: 0x205B7D0 VA: 0x18205C5D0 Slot: 6
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0x205C3A0 Offset: 0x205B5A0 VA: 0x18205C3A0 Slot: 7
	public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct XmlUrlResolver.<GetEntityAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 12103
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<object> <>t__builder; // 0x8
	public Type ofObjectToReturn; // 0x20
	public Uri absoluteUri; // 0x28
	public XmlUrlResolver <>4__this; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x38

	// Methods

	// RVA: 0x2047570 Offset: 0x2046770 VA: 0x182047570 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2047AB0 Offset: 0x2046CB0 VA: 0x182047AB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Xml
public class XmlUrlResolver : XmlResolver // TypeDefIndex: 12104
{
	// Fields
	private static object s_DownloadManager; // 0x0
	private ICredentials _credentials; // 0x10
	private IWebProxy _proxy; // 0x18
	private RequestCachePolicy _cachePolicy; // 0x20

	// Properties
	private static XmlDownloadManager DownloadManager { get; }

	// Methods

	// RVA: 0x205D500 Offset: 0x205C700 VA: 0x18205D500
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x205D290 Offset: 0x205C490 VA: 0x18205D290 Slot: 4
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x205D4F0 Offset: 0x205C6F0 VA: 0x18205D4F0 Slot: 5
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[AsyncStateMachine(typeof(XmlUrlResolver.<GetEntityAsync>d__15))]
	// RVA: 0x205D190 Offset: 0x205C390 VA: 0x18205D190 Slot: 7
	public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }
}

// Namespace: System.Xml
internal static class BinaryCompatibility // TypeDefIndex: 12105
{
	// Properties
	public static bool TargetsAtLeast_Desktop_V4_5_2 { get; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public static bool get_TargetsAtLeast_Desktop_V4_5_2() { }
}

// Namespace: System.Xml
internal static class Res // TypeDefIndex: 12106
{
	// Methods

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static string GetString(string name) { }

	// RVA: 0x2041480 Offset: 0x2040680 VA: 0x182041480
	public static string GetString(string name, object[] args) { }
}

// Namespace: System.Xml.XPath
public interface IXPathNavigable // TypeDefIndex: 12107
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XPathNavigator CreateNavigator();
}

// Namespace: System.Xml.XPath
public class XPathDocument // TypeDefIndex: 12108
{
	// Fields
	private XPathNode[] pageText; // 0x10
	private XPathNode[] pageRoot; // 0x18
	private XPathNode[] pageXmlNmsp; // 0x20
	private int idxText; // 0x28
	private int idxRoot; // 0x2C
	private int idxXmlNmsp; // 0x30
	private XmlNameTable nameTable; // 0x38
	private bool hasLineInfo; // 0x40
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; // 0x48
	private Dictionary<string, XPathNodeRef> idValueMap; // 0x50

	// Properties
	internal XmlNameTable NameTable { get; }
	internal bool HasLineInfo { get; }

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	internal bool get_HasLineInfo() { }

	// RVA: 0x204B010 Offset: 0x204A210 VA: 0x18204B010
	internal int GetCollapsedTextNode(out XPathNode[] pageText) { }

	// RVA: 0x204B020 Offset: 0x204A220 VA: 0x18204B020
	internal int GetRootNode(out XPathNode[] pageRoot) { }

	// RVA: 0x204B030 Offset: 0x204A230 VA: 0x18204B030
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0x204B100 Offset: 0x204A300 VA: 0x18204B100
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x204B040 Offset: 0x204A240 VA: 0x18204B040
	internal int LookupIdElement(string id, out XPathNode[] pageElem) { }
}

// Namespace: System.Xml.XPath
[Serializable]
public class XPathException : SystemException // TypeDefIndex: 12109
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string message; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x204B8A0 Offset: 0x204AAA0 VA: 0x18204B8A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x204B5A0 Offset: 0x204A7A0 VA: 0x18204B5A0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x204B7B0 Offset: 0x204A9B0 VA: 0x18204B7B0
	public void .ctor() { }

	// RVA: 0x204B6E0 Offset: 0x204A8E0 VA: 0x18204B6E0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x204B2A0 Offset: 0x204A4A0 VA: 0x18204B2A0
	internal static XPathException Create(string res) { }

	// RVA: 0x204B320 Offset: 0x204A520 VA: 0x18204B320
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0x204B3F0 Offset: 0x204A5F0 VA: 0x18204B3F0
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0x204B4D0 Offset: 0x204A6D0 VA: 0x18204B4D0
	internal static XPathException Create(string res, string arg, Exception innerException) { }

	// RVA: 0x204B680 Offset: 0x204A880 VA: 0x18204B680
	private void .ctor(string res, string[] args) { }

	// RVA: 0x204BB50 Offset: 0x204AD50 VA: 0x18204BB50
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0x204B1F0 Offset: 0x204A3F0 VA: 0x18204B1F0
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0x204BBC0 Offset: 0x204ADC0 VA: 0x18204BBC0 Slot: 5
	public override string get_Message() { }
}

// Namespace: System.Xml.XPath
public enum XPathResultType // TypeDefIndex: 12110
{
	// Fields
	public int value__; // 0x0
	public const XPathResultType Number = 0;
	public const XPathResultType String = 1;
	public const XPathResultType Boolean = 2;
	public const XPathResultType NodeSet = 3;
	public const XPathResultType Navigator = 1;
	public const XPathResultType Any = 5;
	public const XPathResultType Error = 6;
}

// Namespace: System.Xml.XPath
public abstract class XPathExpression // TypeDefIndex: 12111
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetContext(XmlNamespaceManager nsManager);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetContext(IXmlNamespaceResolver nsResolver);

	// RVA: 0x204BBE0 Offset: 0x204ADE0 VA: 0x18204BBE0
	public static XPathExpression Compile(string xpath) { }

	// RVA: 0x204BCB0 Offset: 0x204AEB0 VA: 0x18204BCB0
	public static XPathExpression Compile(string xpath, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.XPath
public abstract class XPathItem // TypeDefIndex: 12112
{
	// Properties
	public abstract XmlSchemaType XmlType { get; }
	public abstract string Value { get; }
	public abstract object TypedValue { get; }
	public abstract Type ValueType { get; }
	public abstract bool ValueAsBoolean { get; }
	public abstract DateTime ValueAsDateTime { get; }
	public abstract double ValueAsDouble { get; }
	public abstract int ValueAsInt { get; }
	public abstract long ValueAsLong { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_XmlType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object get_TypedValue();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_ValueAsBoolean();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DateTime get_ValueAsDateTime();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract double get_ValueAsDouble();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_ValueAsInt();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_ValueAsLong();

	// RVA: 0x204BDA0 Offset: 0x204AFA0 VA: 0x18204BDA0 Slot: 13
	public virtual object ValueAs(Type returnType) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.XPath
public enum XPathNamespaceScope // TypeDefIndex: 12113
{
	// Fields
	public int value__; // 0x0
	public const XPathNamespaceScope All = 0;
	public const XPathNamespaceScope ExcludeXml = 1;
	public const XPathNamespaceScope Local = 2;
}

// Namespace: System.Xml.XPath
[DebuggerDisplay("{debuggerDisplayProxy}")]
public abstract class XPathNavigator : XPathItem, ICloneable, IXPathNavigable, IXmlNamespaceResolver // TypeDefIndex: 12114
{
	// Fields
	internal static readonly XPathNavigatorKeyComparer comparer; // 0x0
	internal static readonly char[] NodeTypeLetter; // 0x8
	internal static readonly char[] UniqueIdTbl; // 0x10
	internal static readonly int[] ContentKindMasks; // 0x18

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override object TypedValue { get; }
	public override Type ValueType { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public abstract XmlNameTable NameTable { get; }
	public abstract XPathNodeType NodeType { get; }
	public abstract string LocalName { get; }
	public abstract string Name { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public abstract string BaseURI { get; }
	public virtual string XmlLang { get; }
	public virtual object UnderlyingObject { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0x19B4EC0 Offset: 0x19B40C0 VA: 0x1819B4EC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x204F0E0 Offset: 0x204E2E0 VA: 0x18204F0E0 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x204E370 Offset: 0x204D570 VA: 0x18204E370 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x204EF10 Offset: 0x204E110 VA: 0x18204EF10 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x204E560 Offset: 0x204D760 VA: 0x18204E560 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x204E750 Offset: 0x204D950 VA: 0x18204E750 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x204E940 Offset: 0x204DB40 VA: 0x18204E940 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x204EB30 Offset: 0x204DD30 VA: 0x18204EB30 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x204ED20 Offset: 0x204DF20 VA: 0x18204ED20 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x204DFB0 Offset: 0x204D1B0 VA: 0x18204DFB0 Slot: 14
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1720320 Offset: 0x171F520 VA: 0x181720320 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0x1720320 Offset: 0x171F520 VA: 0x181720320 Slot: 20
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract XmlNameTable get_NameTable();

	// RVA: 0x204CC80 Offset: 0x204BE80 VA: 0x18204CC80 Slot: 22
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x204CE50 Offset: 0x204C050 VA: 0x18204CE50 Slot: 23
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0x204C9C0 Offset: 0x204BBC0 VA: 0x18204C9C0 Slot: 24
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract XPathNavigator Clone();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract XPathNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract string get_BaseURI();

	// RVA: 0x204F010 Offset: 0x204E210 VA: 0x18204F010 Slot: 32
	public virtual string get_XmlLang() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 33
	public virtual object get_UnderlyingObject() { }

	// RVA: 0x204D0A0 Offset: 0x204C2A0 VA: 0x18204D0A0 Slot: 34
	public virtual bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: -1 Offset: -1 Slot: 35
	public abstract bool MoveToFirstAttribute();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract bool MoveToNextAttribute();

	// RVA: 0x204D820 Offset: 0x204CA20 VA: 0x18204D820 Slot: 37
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1 Offset: -1 Slot: 38
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

	// RVA: 0x204D360 Offset: 0x204C560 VA: 0x18204D360
	public bool MoveToFirstNamespace() { }

	// RVA: 0x204D8D0 Offset: 0x204CAD0 VA: 0x18204D8D0
	public bool MoveToNextNamespace() { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract bool MoveToNext();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract bool MoveToFirstChild();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract bool MoveToParent();

	// RVA: 0x204DC40 Offset: 0x204CE40 VA: 0x18204DC40 Slot: 43
	public virtual void MoveToRoot() { }

	// RVA: -1 Offset: -1 Slot: 44
	public abstract bool MoveTo(XPathNavigator other);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract bool MoveToId(string id);

	// RVA: 0x204D180 Offset: 0x204C380 VA: 0x18204D180 Slot: 46
	public virtual bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x204D280 Offset: 0x204C480 VA: 0x18204D280 Slot: 47
	public virtual bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x204D5E0 Offset: 0x204C7E0 VA: 0x18204D5E0 Slot: 48
	public virtual bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x204D380 Offset: 0x204C580 VA: 0x18204D380 Slot: 49
	public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x204DA20 Offset: 0x204CC20 VA: 0x18204DA20 Slot: 50
	public virtual bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x204D8F0 Offset: 0x204CAF0 VA: 0x18204D8F0 Slot: 51
	public virtual bool MoveToNext(XPathNodeType type) { }

	// RVA: -1 Offset: -1 Slot: 52
	public abstract bool IsSamePosition(XPathNavigator other);

	// RVA: 0x204CBE0 Offset: 0x204BDE0 VA: 0x18204CBE0 Slot: 53
	public virtual bool IsDescendant(XPathNavigator nav) { }

	// RVA: 0x204C100 Offset: 0x204B300 VA: 0x18204C100 Slot: 54
	public virtual XmlNodeOrder ComparePosition(XPathNavigator nav) { }

	// RVA: 0x204E330 Offset: 0x204D530 VA: 0x18204E330 Slot: 55
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x204C5D0 Offset: 0x204B7D0 VA: 0x18204C5D0 Slot: 56
	public virtual XPathExpression Compile(string xpath) { }

	// RVA: 0x204DEE0 Offset: 0x204D0E0 VA: 0x18204DEE0 Slot: 57
	public virtual XPathNodeIterator Select(XPathExpression expr) { }

	// RVA: 0x204C6A0 Offset: 0x204B8A0 VA: 0x18204C6A0 Slot: 58
	public virtual object Evaluate(XPathExpression expr) { }

	// RVA: 0x204C6C0 Offset: 0x204B8C0 VA: 0x18204C6C0 Slot: 59
	public virtual object Evaluate(XPathExpression expr, XPathNodeIterator context) { }

	// RVA: 0x204DD10 Offset: 0x204CF10 VA: 0x18204DD10 Slot: 60
	public virtual XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x204DC70 Offset: 0x204CE70 VA: 0x18204DC70 Slot: 61
	public virtual XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x204DD90 Offset: 0x204CF90 VA: 0x18204DD90 Slot: 62
	public virtual XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x204DE30 Offset: 0x204D030 VA: 0x18204DE30 Slot: 63
	public virtual XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x204DB10 Offset: 0x204CD10 VA: 0x18204DB10
	internal bool MoveToNonDescendant() { }

	// RVA: 0x204C940 Offset: 0x204BB40 VA: 0x18204C940
	private static int GetDepth(XPathNavigator nav) { }

	// RVA: 0x204C450 Offset: 0x204B650 VA: 0x18204C450
	private XmlNodeOrder CompareSiblings(XPathNavigator n1, XPathNavigator n2) { }

	// RVA: 0x204C8D0 Offset: 0x204BAD0 VA: 0x18204C8D0
	internal static int GetContentKindMask(XPathNodeType type) { }

	// RVA: 0x204C9A0 Offset: 0x204BBA0 VA: 0x18204C9A0
	internal static int GetKindMask(XPathNodeType type) { }

	// RVA: 0x204CC70 Offset: 0x204BE70 VA: 0x18204CC70
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x204E1E0 Offset: 0x204D3E0 VA: 0x18204E1E0
	private static void .cctor() { }
}

// Namespace: System.Xml.XPath
internal class XPathNavigatorKeyComparer : IEqualityComparer // TypeDefIndex: 12115
{
	// Methods

	// RVA: 0x204BDC0 Offset: 0x204AFC0 VA: 0x18204BDC0 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0x204BEB0 Offset: 0x204B0B0 VA: 0x18204BEB0 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class XPathNodeIterator.Enumerator : IEnumerator // TypeDefIndex: 12116
{
	// Fields
	private XPathNodeIterator original; // 0x10
	private XPathNodeIterator current; // 0x18
	private bool iterationStarted; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x2040580 Offset: 0x203F780 VA: 0x182040580
	public void .ctor(XPathNodeIterator original) { }

	// RVA: 0x20405D0 Offset: 0x203F7D0 VA: 0x1820405D0 Slot: 7
	public virtual object get_Current() { }

	// RVA: 0x2040500 Offset: 0x203F700 VA: 0x182040500 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x1B8E590 Offset: 0x1B8D790 VA: 0x181B8E590 Slot: 9
	public virtual void Reset() { }
}

// Namespace: System.Xml.XPath
[DebuggerDisplay("Position={CurrentPosition}, Current={debuggerDisplayProxy}")]
public abstract class XPathNodeIterator : ICloneable, IEnumerable // TypeDefIndex: 12117
{
	// Fields
	internal int count; // 0x10

	// Properties
	public abstract XPathNavigator Current { get; }
	public abstract int CurrentPosition { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x6E6600 Offset: 0x6E5800 VA: 0x1806E6600 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XPathNodeIterator Clone();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MoveNext();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract XPathNavigator get_Current();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_CurrentPosition();

	// RVA: 0x204F200 Offset: 0x204E400 VA: 0x18204F200 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x204F180 Offset: 0x204E380 VA: 0x18204F180 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x198F9A0 Offset: 0x198EBA0 VA: 0x18198F9A0
	protected void .ctor() { }
}

// Namespace: System.Xml.XPath
public enum XPathNodeType // TypeDefIndex: 12118
{
	// Fields
	public int value__; // 0x0
	public const XPathNodeType Root = 0;
	public const XPathNodeType Element = 1;
	public const XPathNodeType Attribute = 2;
	public const XPathNodeType Namespace = 3;
	public const XPathNodeType Text = 4;
	public const XPathNodeType SignificantWhitespace = 5;
	public const XPathNodeType Whitespace = 6;
	public const XPathNodeType ProcessingInstruction = 7;
	public const XPathNodeType Comment = 8;
	public const XPathNodeType All = 9;
}

// Namespace: System.Xml.Serialization
public class CodeIdentifier // TypeDefIndex: 12119
{
	// Fields
	internal static CodeDomProvider csharp; // 0x0

	// Methods

	// RVA: 0x203FF50 Offset: 0x203F150 VA: 0x18203FF50
	public static string MakePascal(string identifier) { }

	// RVA: 0x20402A0 Offset: 0x203F4A0 VA: 0x1820402A0
	public static string MakeValid(string identifier) { }

	// RVA: 0x203FE60 Offset: 0x203F060 VA: 0x18203FE60
	private static bool IsValidStart(char c) { }

	// RVA: 0x203FEB0 Offset: 0x203F0B0 VA: 0x18203FEB0
	private static bool IsValid(char c) { }

	// RVA: 0x20404A0 Offset: 0x203F6A0 VA: 0x1820404A0
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public class XmlSerializerNamespaces // TypeDefIndex: 12120
{
	// Fields
	private Hashtable namespaces; // 0x10

	// Properties
	public int Count { get; }
	internal ArrayList NamespaceList { get; }
	internal Hashtable Namespaces { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x205C7A0 Offset: 0x205B9A0 VA: 0x18205C7A0
	public void Add(string prefix, string ns) { }

	// RVA: 0x205C700 Offset: 0x205B900 VA: 0x18205C700
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0x205C8B0 Offset: 0x205BAB0 VA: 0x18205C8B0
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0x205C9B0 Offset: 0x205BBB0 VA: 0x18205C9B0
	public int get_Count() { }

	// RVA: 0x205CA40 Offset: 0x205BC40 VA: 0x18205CA40
	internal ArrayList get_NamespaceList() { }

	// RVA: 0x205CE30 Offset: 0x205C030 VA: 0x18205CE30
	internal Hashtable get_Namespaces() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_Namespaces(Hashtable value) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlAttributeEventHandler : MulticastDelegate // TypeDefIndex: 12121
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, XmlAttributeEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class XmlAttributeEventArgs : EventArgs // TypeDefIndex: 12122
{
	// Fields
	private object o; // 0x10
	private XmlAttribute attr; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x204F280 Offset: 0x204E480 VA: 0x18204F280
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlElementEventHandler : MulticastDelegate // TypeDefIndex: 12123
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, XmlElementEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class XmlElementEventArgs : EventArgs // TypeDefIndex: 12124
{
	// Fields
	private object o; // 0x10
	private XmlElement elem; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x20588F0 Offset: 0x2057AF0 VA: 0x1820588F0
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlNodeEventHandler : MulticastDelegate // TypeDefIndex: 12125
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, XmlNodeEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class XmlNodeEventArgs : EventArgs // TypeDefIndex: 12126
{
	// Fields
	private object o; // 0x10
	private XmlNode xmlNode; // 0x18
	private int lineNumber; // 0x20
	private int linePosition; // 0x24

	// Methods

	// RVA: 0x205B090 Offset: 0x205A290 VA: 0x18205B090
	internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }
}

// Namespace: System.Xml.Serialization
public sealed class UnreferencedObjectEventHandler : MulticastDelegate // TypeDefIndex: 12127
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, UnreferencedObjectEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class UnreferencedObjectEventArgs : EventArgs // TypeDefIndex: 12128
{
	// Fields
	private object o; // 0x10
	private string id; // 0x18

	// Methods

	// RVA: 0x204A260 Offset: 0x2049460 VA: 0x18204A260
	public void .ctor(object o, string id) { }
}

// Namespace: System.Xml.Serialization
public interface IXmlSerializable // TypeDefIndex: 12129
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchema GetSchema();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReadXml(XmlReader reader);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void WriteXml(XmlWriter writer);
}

// Namespace: System.Xml.Serialization
public interface IXmlTextParser // TypeDefIndex: 12130
{
	// Properties
	public abstract bool Normalized { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Normalized();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Normalized(bool value);
}

// Namespace: System.Xml.Serialization
internal class KeyHelper // TypeDefIndex: 12131
{
	// Methods

	// RVA: 0x2040870 Offset: 0x203FA70 VA: 0x182040870
	public static void AddField(StringBuilder sb, int n, string val) { }

	// RVA: 0x2040A30 Offset: 0x203FC30 VA: 0x182040A30
	public static void AddField(StringBuilder sb, int n, string val, string def) { }

	// RVA: 0x2040B10 Offset: 0x203FD10 VA: 0x182040B10
	public static void AddField(StringBuilder sb, int n, bool val) { }

	// RVA: 0x2040940 Offset: 0x203FB40 VA: 0x182040940
	public static void AddField(StringBuilder sb, int n, bool val, bool def) { }

	// RVA: 0x2040980 Offset: 0x203FB80 VA: 0x182040980
	public static void AddField(StringBuilder sb, int n, int val, int def) { }

	// RVA: 0x2040790 Offset: 0x203F990 VA: 0x182040790
	public static void AddField(StringBuilder sb, int n, Type val) { }
}

// Namespace: System.Xml.Serialization
internal class ReflectionHelper // TypeDefIndex: 12132
{
	// Fields
	private Hashtable _clrTypes; // 0x10
	private Hashtable _schemaTypes; // 0x18
	private static readonly ParameterModifier[] empty_modifiers; // 0x0

	// Methods

	// RVA: 0x20412F0 Offset: 0x20404F0 VA: 0x1820412F0
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x20410C0 Offset: 0x20402C0 VA: 0x1820410C0
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x20411A0 Offset: 0x20403A0 VA: 0x1820411A0
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x2040F60 Offset: 0x2040160 VA: 0x182040F60
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x2040BA0 Offset: 0x203FDA0 VA: 0x182040BA0
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x2041400 Offset: 0x2040600 VA: 0x182041400
	public void .ctor() { }

	// RVA: 0x20413B0 Offset: 0x20405B0 VA: 0x1820413B0
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
internal enum SchemaTypes // TypeDefIndex: 12133
{
	// Fields
	public int value__; // 0x0
	public const SchemaTypes NotSet = 0;
	public const SchemaTypes Primitive = 1;
	public const SchemaTypes Enum = 2;
	public const SchemaTypes Array = 3;
	public const SchemaTypes Class = 4;
	public const SchemaTypes XmlSerializable = 5;
	public const SchemaTypes XmlNode = 6;
	public const SchemaTypes Void = 7;
}

// Namespace: System.Xml.Serialization
internal abstract class SerializationSource // TypeDefIndex: 12134
{
	// Fields
	private Type[] includedTypes; // 0x10
	private string namspace; // 0x18
	private bool canBeGenerated; // 0x20

	// Methods

	// RVA: 0x2041740 Offset: 0x2040940 VA: 0x182041740
	public void .ctor(string namspace, Type[] includedTypes) { }

	// RVA: 0x2041630 Offset: 0x2040830 VA: 0x182041630
	protected bool BaseEquals(SerializationSource other) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeSerializationSource : SerializationSource // TypeDefIndex: 12135
{
	// Fields
	private string attributeOverridesHash; // 0x28
	private Type type; // 0x30
	private string rootHash; // 0x38

	// Methods

	// RVA: 0x205D060 Offset: 0x205C260 VA: 0x18205D060
	public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0x205CEA0 Offset: 0x205C0A0 VA: 0x18205CEA0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1713320 Offset: 0x1712520 VA: 0x181713320 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Xml.Serialization
[Usage(4, AllowMultiple = False)]
internal class XmlTypeConvertorAttribute : Attribute // TypeDefIndex: 12136
{
	// Fields
	[CompilerGenerated]
	private string <Method>k__BackingField; // 0x10

	// Properties
	public string Method { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Method() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_Method(string value) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string method) { }
}

// Namespace: System.Xml.Serialization
internal class TypeData // TypeDefIndex: 12137
{
	// Fields
	private Type type; // 0x10
	private string elementName; // 0x18
	private SchemaTypes sType; // 0x20
	private Type listItemType; // 0x28
	private string typeName; // 0x30
	private string fullTypeName; // 0x38
	private TypeData listItemTypeData; // 0x40
	private TypeData mappedType; // 0x48
	private XmlSchemaPatternFacet facet; // 0x50
	private MethodInfo typeConvertor; // 0x58
	private bool hasPublicConstructor; // 0x60
	private bool nullableOverride; // 0x61
	private static string[] keywords; // 0x0

	// Properties
	public string TypeName { get; }
	public string XmlType { get; }
	public Type Type { get; }
	public string FullTypeName { get; }
	public SchemaTypes SchemaType { get; }
	public bool IsListType { get; }
	public bool IsComplexType { get; }
	public bool IsValueType { get; }
	public bool IsNullable { get; set; }
	public TypeData ListItemTypeData { get; }
	public Type ListItemType { get; }
	public bool IsXsdType { get; }
	public bool HasPublicConstructor { get; }

	// Methods

	// RVA: 0x2042E00 Offset: 0x2042000 VA: 0x182042E00
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x20428F0 Offset: 0x2041AF0 VA: 0x1820428F0
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x2041CD0 Offset: 0x2040ED0 VA: 0x182041CD0
	private void LookupTypeConvertor() { }

	// RVA: 0x2041780 Offset: 0x2040980 VA: 0x182041780
	internal void ConvertForAssignment(ref object value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_TypeName() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_XmlType() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Type get_Type() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_FullTypeName() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x2042E50 Offset: 0x2042050 VA: 0x182042E50
	public bool get_IsListType() { }

	// RVA: 0x2042E20 Offset: 0x2042020 VA: 0x182042E20
	public bool get_IsComplexType() { }

	// RVA: 0x2042FF0 Offset: 0x20421F0 VA: 0x182042FF0
	public bool get_IsValueType() { }

	// RVA: 0x2042E60 Offset: 0x2042060 VA: 0x182042E60
	public bool get_IsNullable() { }

	// RVA: 0xE5B990 Offset: 0xE5AB90 VA: 0x180E5B990
	public void set_IsNullable(bool value) { }

	// RVA: 0x20430A0 Offset: 0x20422A0 VA: 0x1820430A0
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x2043190 Offset: 0x2042390 VA: 0x182043190
	public Type get_ListItemType() { }

	// RVA: 0x2043090 Offset: 0x2042290 VA: 0x182043090
	public bool get_IsXsdType() { }

	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290
	public bool get_HasPublicConstructor() { }

	// RVA: 0x2041B70 Offset: 0x2040D70 VA: 0x182041B70
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x2041860 Offset: 0x2040A60 VA: 0x182041860
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x2041970 Offset: 0x2040B70 VA: 0x182041970
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x2041D70 Offset: 0x2040F70 VA: 0x182041D70
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
internal sealed class TypeMember // TypeDefIndex: 12138
{
	// Fields
	private Type type; // 0x10
	private string member; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(Type type, string member) { }

	// RVA: 0x2043C80 Offset: 0x2042E80 VA: 0x182043C80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2043AC0 Offset: 0x2042CC0 VA: 0x182043AC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2043BD0 Offset: 0x2042DD0 VA: 0x182043BD0
	public static bool Equals(TypeMember tm1, TypeMember tm2) { }

	// RVA: 0x2043CE0 Offset: 0x2042EE0 VA: 0x182043CE0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml.Serialization
internal class TypeTranslator // TypeDefIndex: 12139
{
	// Fields
	private static Hashtable nameCache; // 0x0
	private static Hashtable primitiveTypes; // 0x8
	private static Hashtable primitiveArrayTypes; // 0x10
	private static Hashtable nullableTypes; // 0x18

	// Methods

	// RVA: 0x2044F20 Offset: 0x2044120 VA: 0x182044F20
	private static void .cctor() { }

	// RVA: 0x2044D70 Offset: 0x2043F70 VA: 0x182044D70
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x20441F0 Offset: 0x20433F0 VA: 0x1820441F0
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = False) { }

	// RVA: 0x20441A0 Offset: 0x20433A0 VA: 0x1820441A0
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x2043F30 Offset: 0x2043130 VA: 0x182043F30
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x2043D50 Offset: 0x2042F50 VA: 0x182043D50
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x2043E30 Offset: 0x2043030 VA: 0x182043E30
	public static string GetArrayName(string elemName) { }

	// RVA: 0x2044DC0 Offset: 0x2043FC0 VA: 0x182044DC0
	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlAnyAttributeAttribute : Attribute // TypeDefIndex: 12140
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlAnyElementAttribute : Attribute // TypeDefIndex: 12141
{
	// Fields
	private string elementName; // 0x10
	private string ns; // 0x18
	private int order; // 0x20

	// Properties
	public string Name { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x205D910 Offset: 0x205CB10 VA: 0x18205D910
	public void .ctor() { }

	// RVA: 0x205D920 Offset: 0x205CB20 VA: 0x18205D920
	public string get_Name() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Namespace() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_Order() { }

	// RVA: 0x205D880 Offset: 0x205CA80 VA: 0x18205D880
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlAnyElementAttributes : CollectionBase // TypeDefIndex: 12142
{
	// Properties
	public XmlAnyElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x205DBB0 Offset: 0x205CDB0 VA: 0x18205DBB0
	public XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x205DB40 Offset: 0x205CD40 VA: 0x18205DB40
	public int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x205D970 Offset: 0x205CB70 VA: 0x18205D970
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x205DC80 Offset: 0x205CE80 VA: 0x18205DC80
	internal int get_Order() { }

	// RVA: 0x154B280 Offset: 0x154A480 VA: 0x18154B280
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = False)]
public class XmlArrayAttribute : Attribute // TypeDefIndex: 12143
{
	// Fields
	private string elementName; // 0x10
	private XmlSchemaForm form; // 0x18
	private bool isNullable; // 0x1C
	private string ns; // 0x20
	private int order; // 0x28

	// Properties
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public bool IsNullable { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x205DF60 Offset: 0x205D160 VA: 0x18205DF60
	public string get_ElementName() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public XmlSchemaForm get_Form() { }

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_IsNullable() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Namespace() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_Order() { }

	// RVA: 0x205DE30 Offset: 0x205D030 VA: 0x18205DE30
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlArrayItemAttribute : Attribute // TypeDefIndex: 12144
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private bool isNullableSpecified; // 0x31
	private int nestingLevel; // 0x34
	private Type type; // 0x38

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	internal bool IsNullableSpecified { get; }
	public Type Type { get; }
	public int NestingLevel { get; }

	// Methods

	// RVA: 0x205E130 Offset: 0x205D330 VA: 0x18205E130
	public string get_DataType() { }

	// RVA: 0x205E180 Offset: 0x205D380 VA: 0x18205E180
	public string get_ElementName() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public XmlSchemaForm get_Form() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Namespace() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_IsNullable() { }

	// RVA: 0x577B10 Offset: 0x576D10 VA: 0x180577B10
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Type get_Type() { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public int get_NestingLevel() { }

	// RVA: 0x205DFB0 Offset: 0x205D1B0 VA: 0x18205DFB0
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlArrayItemAttributes : CollectionBase // TypeDefIndex: 12145
{
	// Properties
	public XmlArrayItemAttribute Item { get; }

	// Methods

	// RVA: 0x205E500 Offset: 0x205D700 VA: 0x18205E500
	public XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x205E490 Offset: 0x205D690 VA: 0x18205E490
	public int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x205E1D0 Offset: 0x205D3D0 VA: 0x18205E1D0
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x154B280 Offset: 0x154A480 VA: 0x18154B280
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlAttributeAttribute : Attribute // TypeDefIndex: 12146
{
	// Fields
	private string attributeName; // 0x10
	private string dataType; // 0x18
	private Type type; // 0x20
	private XmlSchemaForm form; // 0x28
	private string ns; // 0x30

	// Properties
	public string AttributeName { get; }
	public string DataType { get; set; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string attributeName) { }

	// RVA: 0x205E710 Offset: 0x205D910 VA: 0x18205E710
	public string get_AttributeName() { }

	// RVA: 0x205E760 Offset: 0x205D960 VA: 0x18205E760
	public string get_DataType() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_DataType(string value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public XmlSchemaForm get_Form() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Namespace() { }

	// RVA: 0x205E5D0 Offset: 0x205D7D0 VA: 0x18205E5D0
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlAttributeOverrides // TypeDefIndex: 12147
{
	// Fields
	private Hashtable overrides; // 0x10

	// Properties
	public XmlAttributes Item { get; }
	public XmlAttributes Item { get; }

	// Methods

	// RVA: 0x205EB90 Offset: 0x205DD90 VA: 0x18205EB90
	public void .ctor() { }

	// RVA: 0x205EBF0 Offset: 0x205DDF0 VA: 0x18205EBF0
	public XmlAttributes get_Item(Type type) { }

	// RVA: 0x205EC50 Offset: 0x205DE50 VA: 0x18205EC50
	public XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x205EB20 Offset: 0x205DD20 VA: 0x18205EB20
	private TypeMember GetKey(Type type, string member) { }

	// RVA: 0x205E7B0 Offset: 0x205D9B0 VA: 0x18205E7B0
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
public class XmlAttributes // TypeDefIndex: 12148
{
	// Fields
	private XmlAnyAttributeAttribute xmlAnyAttribute; // 0x10
	private XmlAnyElementAttributes xmlAnyElements; // 0x18
	private XmlArrayAttribute xmlArray; // 0x20
	private XmlArrayItemAttributes xmlArrayItems; // 0x28
	private XmlAttributeAttribute xmlAttribute; // 0x30
	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier; // 0x38
	private object xmlDefaultValue; // 0x40
	private XmlElementAttributes xmlElements; // 0x48
	private XmlEnumAttribute xmlEnum; // 0x50
	private bool xmlIgnore; // 0x58
	private bool xmlns; // 0x59
	private XmlRootAttribute xmlRoot; // 0x60
	private XmlTextAttribute xmlText; // 0x68
	private XmlTypeAttribute xmlType; // 0x70

	// Properties
	public XmlAnyAttributeAttribute XmlAnyAttribute { get; }
	public XmlAnyElementAttributes XmlAnyElements { get; }
	public XmlArrayAttribute XmlArray { get; }
	public XmlArrayItemAttributes XmlArrayItems { get; }
	public XmlAttributeAttribute XmlAttribute { get; }
	public XmlChoiceIdentifierAttribute XmlChoiceIdentifier { get; }
	public object XmlDefaultValue { get; }
	public XmlElementAttributes XmlElements { get; }
	public bool XmlIgnore { get; }
	public bool Xmlns { get; }
	public XmlRootAttribute XmlRoot { get; }
	public XmlTextAttribute XmlText { get; }
	public XmlTypeAttribute XmlType { get; }
	internal Nullable<int> Order { get; }
	internal int SortableOrder { get; }

	// Methods

	// RVA: 0x205F300 Offset: 0x205E500 VA: 0x18205F300
	public void .ctor() { }

	// RVA: 0x205F3F0 Offset: 0x205E5F0 VA: 0x18205F3F0
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public object get_XmlDefaultValue() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public XmlElementAttributes get_XmlElements() { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30
	public bool get_XmlIgnore() { }

	// RVA: 0x7725E0 Offset: 0x7717E0 VA: 0x1807725E0
	public bool get_Xmlns() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x205ED60 Offset: 0x205DF60 VA: 0x18205ED60
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x205FFE0 Offset: 0x205F1E0 VA: 0x18205FFE0
	internal Nullable<int> get_Order() { }

	// RVA: 0x20600A0 Offset: 0x205F2A0 VA: 0x1820600A0
	internal int get_SortableOrder() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = False)]
public class XmlChoiceIdentifierAttribute : Attribute // TypeDefIndex: 12149
{
	// Fields
	private string memberName; // 0x10

	// Properties
	public string MemberName { get; }

	// Methods

	// RVA: 0x20601A0 Offset: 0x205F3A0 VA: 0x1820601A0
	public string get_MemberName() { }

	// RVA: 0x2060120 Offset: 0x205F320 VA: 0x182060120
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
internal class XmlCustomFormatter // TypeDefIndex: 12150
{
	// Fields
	private static string[] allTimeFormats; // 0x0

	// Methods

	// RVA: 0x20601F0 Offset: 0x205F3F0 VA: 0x1820601F0
	internal static string FromEnum(long value, string[] values, long[] ids, string typeName) { }

	// RVA: 0x2060560 Offset: 0x205F760 VA: 0x182060560
	internal static string FromXmlName(string name) { }

	// RVA: 0x2060510 Offset: 0x205F710 VA: 0x182060510
	internal static string FromXmlNCName(string ncName) { }

	// RVA: 0x2060FC0 Offset: 0x20601C0 VA: 0x182060FC0
	internal static string ToXmlString(TypeData type, object value) { }

	// RVA: 0x20605B0 Offset: 0x205F7B0 VA: 0x1820605B0
	internal static object FromXmlString(TypeData type, string value) { }

	// RVA: 0x2061CC0 Offset: 0x2060EC0 VA: 0x182061CC0
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlElementAttribute : Attribute // TypeDefIndex: 12151
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private Type type; // 0x38
	private int order; // 0x40

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	public int Order { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x2062200 Offset: 0x2061400 VA: 0x182062200
	public void .ctor(string elementName) { }

	// RVA: 0x20621C0 Offset: 0x20613C0 VA: 0x1820621C0
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x2062230 Offset: 0x2061430 VA: 0x182062230
	public string get_DataType() { }

	// RVA: 0x2062280 Offset: 0x2061480 VA: 0x182062280
	public string get_ElementName() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public XmlSchemaForm get_Form() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Namespace() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_IsNullable() { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public int get_Order() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Type get_Type() { }

	// RVA: 0x2062060 Offset: 0x2061260 VA: 0x182062060
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlElementAttributes : CollectionBase // TypeDefIndex: 12152
{
	// Properties
	public XmlElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x2062560 Offset: 0x2061760 VA: 0x182062560
	public XmlElementAttribute get_Item(int index) { }

	// RVA: 0x20624F0 Offset: 0x20616F0 VA: 0x1820624F0
	public int Add(XmlElementAttribute attribute) { }

	// RVA: 0x20622D0 Offset: 0x20614D0 VA: 0x1820622D0
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x2062630 Offset: 0x2061830 VA: 0x182062630
	internal int get_Order() { }

	// RVA: 0x154B280 Offset: 0x154A480 VA: 0x18154B280
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(256)]
public class XmlEnumAttribute : Attribute // TypeDefIndex: 12153
{
	// Fields
	private string name; // 0x10

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string name) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x20627E0 Offset: 0x20619E0 VA: 0x1820627E0
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlIgnoreAttribute : Attribute // TypeDefIndex: 12154
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(1100, AllowMultiple = True)]
public class XmlIncludeAttribute : Attribute // TypeDefIndex: 12155
{
	// Fields
	private Type type; // 0x10

	// Properties
	public Type Type { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Type get_Type() { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlMapping // TypeDefIndex: 12156
{
	// Fields
	private ObjectMap map; // 0x10
	private ArrayList relatedMaps; // 0x18
	private SerializationFormat format; // 0x20
	private SerializationSource source; // 0x28
	internal string _elementName; // 0x30
	internal string _namespace; // 0x38
	private string key; // 0x40

	// Properties
	public string ElementName { get; }
	public string Namespace { get; }
	internal ObjectMap ObjectMap { get; set; }
	internal ArrayList RelatedMaps { get; set; }
	internal SerializationFormat Format { get; set; }
	internal SerializationSource Source { get; }

	// Methods

	// RVA: 0x2062860 Offset: 0x2061A60 VA: 0x182062860
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_ElementName() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Namespace() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void SetKey(string key) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal SerializationFormat get_Format() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal SerializationSource get_Source() { }
}

// Namespace: System.Xml.Serialization
internal class ObjectMap // TypeDefIndex: 12157
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal enum SerializationFormat // TypeDefIndex: 12158
{
	// Fields
	public int value__; // 0x0
	public const SerializationFormat Encoded = 0;
	public const SerializationFormat Literal = 1;
}

// Namespace: System.Xml.Serialization
public class XmlMemberMapping // TypeDefIndex: 12159
{}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlMembersMapping : XmlMapping // TypeDefIndex: 12160
{
	// Fields
	private bool _hasWrapperElement; // 0x48
	private XmlMemberMapping[] _mapping; // 0x50

	// Properties
	public int Count { get; }
	internal bool HasWrapperElement { get; }

	// Methods

	// RVA: 0x20628A0 Offset: 0x2061AA0 VA: 0x1820628A0
	public int get_Count() { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	internal bool get_HasWrapperElement() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlNamespaceDeclarationsAttribute : Attribute // TypeDefIndex: 12161
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class XmlReflectionImporter.<>c // TypeDefIndex: 12162
{
	// Fields
	public static readonly XmlReflectionImporter.<>c <>9; // 0x0
	public static Comparison<XmlReflectionMember> <>9__28_0; // 0x8

	// Methods

	// RVA: 0x205D820 Offset: 0x205CA20 VA: 0x18205D820
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x205D740 Offset: 0x205C940 VA: 0x18205D740
	internal int <ImportClassMapping>b__28_0(XmlReflectionMember m1, XmlReflectionMember m2) { }
}

// Namespace: System.Xml.Serialization
public class XmlReflectionImporter // TypeDefIndex: 12163
{
	// Fields
	private string initialDefaultNamespace; // 0x10
	private XmlAttributeOverrides attributeOverrides; // 0x18
	private ArrayList includedTypes; // 0x20
	private ReflectionHelper helper; // 0x28
	private int arrayChoiceCount; // 0x30
	private ArrayList relatedMaps; // 0x38
	private bool allowPrivateTypes; // 0x40
	private static readonly string errSimple; // 0x0
	private static readonly string errSimple2; // 0x8

	// Methods

	// RVA: 0x2069B40 Offset: 0x2068D40 VA: 0x182069B40
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x2068EA0 Offset: 0x20680A0 VA: 0x182068EA0
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x2068EC0 Offset: 0x20680C0 VA: 0x182068EC0
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x2068EE0 Offset: 0x20680E0 VA: 0x182068EE0
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x20688F0 Offset: 0x2067AF0 VA: 0x1820688F0
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x2063580 Offset: 0x2062780 VA: 0x182063580
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x2064F10 Offset: 0x2064110 VA: 0x182064F10
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x2064FB0 Offset: 0x20641B0 VA: 0x182064FB0
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x2069990 Offset: 0x2068B90 VA: 0x182069990
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x2064890 Offset: 0x2063A90 VA: 0x182064890
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x20676F0 Offset: 0x20668F0 VA: 0x1820676F0
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x2067780 Offset: 0x2066980 VA: 0x182067780
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x20690C0 Offset: 0x20682C0 VA: 0x1820690C0
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x2068490 Offset: 0x2067690 VA: 0x182068490
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x2066FD0 Offset: 0x20661D0 VA: 0x182066FD0
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x20693B0 Offset: 0x20685B0 VA: 0x1820693B0
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x20675A0 Offset: 0x20667A0 VA: 0x1820675A0
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x2063C30 Offset: 0x2062E30 VA: 0x182063C30
	private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x2062900 Offset: 0x2061B00 VA: 0x182062900
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x20660A0 Offset: 0x20652A0 VA: 0x1820660A0
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x20649F0 Offset: 0x2063BF0 VA: 0x1820649F0
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x2068570 Offset: 0x2067770 VA: 0x182068570
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x20628C0 Offset: 0x2061AC0 VA: 0x1820628C0
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x20694E0 Offset: 0x20686E0 VA: 0x1820694E0
	public void IncludeType(Type type) { }

	// RVA: 0x2063A60 Offset: 0x2062C60 VA: 0x182063A60
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x2069AD0 Offset: 0x2068CD0 VA: 0x182069AD0
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public class XmlReflectionMember // TypeDefIndex: 12164
{
	// Fields
	private bool isReturnValue; // 0x10
	private string memberName; // 0x18
	private Type memberType; // 0x20
	private XmlAttributes xmlAttributes; // 0x28
	private Type declaringType; // 0x30

	// Properties
	public bool IsReturnValue { get; }
	public string MemberName { get; }
	public Type MemberType { get; }
	public XmlAttributes XmlAttributes { get; }
	internal Type DeclaringType { get; set; }

	// Methods

	// RVA: 0x2069C80 Offset: 0x2068E80 VA: 0x182069C80
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsReturnValue() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_MemberName() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Type get_MemberType() { }

	// RVA: 0x2069CD0 Offset: 0x2068ED0 VA: 0x182069CD0
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal Type get_DeclaringType() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_DeclaringType(Type value) { }
}

// Namespace: System.Xml.Serialization
[Usage(9244)]
public class XmlRootAttribute : Attribute // TypeDefIndex: 12165
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private bool isNullable; // 0x20
	private string ns; // 0x28

	// Properties
	public string DataType { get; set; }
	public string ElementName { get; set; }
	public bool IsNullable { get; set; }
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x2069E00 Offset: 0x2069000 VA: 0x182069E00
	public void .ctor() { }

	// RVA: 0x2069E10 Offset: 0x2069010 VA: 0x182069E10
	public void .ctor(string elementName) { }

	// RVA: 0x2069E40 Offset: 0x2069040 VA: 0x182069E40
	public string get_DataType() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_DataType(string value) { }

	// RVA: 0x2069E90 Offset: 0x2069090 VA: 0x182069E90
	public string get_ElementName() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ElementName(string value) { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IsNullable() { }

	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_IsNullable(bool value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Namespace() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Namespace(string value) { }

	// RVA: 0x2069D40 Offset: 0x2068F40 VA: 0x182069D40
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(1036)]
public sealed class XmlSchemaProviderAttribute : Attribute // TypeDefIndex: 12166
{
	// Fields
	private string _methodName; // 0x10
	private bool _isAny; // 0x18

	// Properties
	public string MethodName { get; }
	public bool IsAny { get; set; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string methodName) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_MethodName() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_IsAny() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_IsAny(bool value) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationCollectionFixupCallback : MulticastDelegate // TypeDefIndex: 12167
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object collection, object collectionItems) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationFixupCallback : MulticastDelegate // TypeDefIndex: 12168
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(object fixup) { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationGeneratedCode // TypeDefIndex: 12169
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationReadCallback : MulticastDelegate // TypeDefIndex: 12170
{
	// Methods

	// RVA: 0x1202980 Offset: 0x1201B80 VA: 0x181202980
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual object Invoke() { }
}

// Namespace: 
private class XmlSerializationReader.WriteCallbackInfo // TypeDefIndex: 12171
{
	// Fields
	public Type Type; // 0x10
	public string TypeName; // 0x18
	public string TypeNs; // 0x20
	public XmlSerializationReadCallback Callback; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
protected class XmlSerializationReader.CollectionFixup // TypeDefIndex: 12172
{
	// Fields
	private XmlSerializationCollectionFixupCallback callback; // 0x10
	private object collection; // 0x18
	private object collectionItems; // 0x20
	private string id; // 0x28

	// Properties
	public XmlSerializationCollectionFixupCallback Callback { get; }
	public object Collection { get; }
	internal object Id { get; }
	public object CollectionItems { get; set; }

	// Methods

	// RVA: 0x205D5F0 Offset: 0x205C7F0 VA: 0x18205D5F0
	internal void .ctor(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public XmlSerializationCollectionFixupCallback get_Callback() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public object get_Collection() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal object get_Id() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public object get_CollectionItems() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_CollectionItems(object value) { }
}

// Namespace: 
protected class XmlSerializationReader.Fixup // TypeDefIndex: 12173
{
	// Fields
	private object source; // 0x10
	private string[] ids; // 0x18
	private XmlSerializationFixupCallback callback; // 0x20

	// Properties
	public XmlSerializationFixupCallback Callback { get; }
	public string[] Ids { get; }
	public object Source { get; }

	// Methods

	// RVA: 0x205D680 Offset: 0x205C880 VA: 0x18205D680
	public void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public XmlSerializationFixupCallback get_Callback() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string[] get_Ids() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public object get_Source() { }
}

// Namespace: 
private class XmlSerializationReader.CollectionItemFixup // TypeDefIndex: 12174
{
	// Fields
	private Array list; // 0x10
	private int index; // 0x18
	private string id; // 0x20

	// Properties
	public Array Collection { get; }
	public int Index { get; }
	public string Id { get; }

	// Methods

	// RVA: 0x17E1FC0 Offset: 0x17E11C0 VA: 0x1817E1FC0
	public void .ctor(Array list, int index, string id) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Array get_Collection() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Index() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Id() { }
}

// Namespace: System.Xml.Serialization
[MonoTODO]
public abstract class XmlSerializationReader : XmlSerializationGeneratedCode // TypeDefIndex: 12175
{
	// Fields
	private XmlDocument document; // 0x10
	private XmlReader reader; // 0x18
	private ArrayList fixups; // 0x20
	private Hashtable collFixups; // 0x28
	private ArrayList collItemFixups; // 0x30
	private Hashtable typesCallbacks; // 0x38
	private ArrayList noIDTargets; // 0x40
	private Hashtable targets; // 0x48
	private Hashtable delayedListFixups; // 0x50
	private XmlSerializer eventSource; // 0x58
	private int delayedFixupId; // 0x60
	private Hashtable referencedObjects; // 0x68
	private int readCount; // 0x70
	private int whileIterationCount; // 0x74
	private string w3SchemaNS; // 0x78
	private string w3InstanceNS; // 0x80
	private string w3InstanceNS2000; // 0x88
	private string w3InstanceNS1999; // 0x90
	private string soapNS; // 0x98
	private string wsdlNS; // 0xA0
	private string nullX; // 0xA8
	private string nil; // 0xB0
	private string typeX; // 0xB8
	private string arrayType; // 0xC0
	private XmlQualifiedName arrayQName; // 0xC8

	// Properties
	protected XmlDocument Document { get; }
	protected XmlReader Reader { get; }

	// Methods

	// RVA: 0x2071100 Offset: 0x2070300 VA: 0x182071100
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x2070B70 Offset: 0x206FD70 VA: 0x182070B70
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x2070BC0 Offset: 0x206FDC0 VA: 0x182070BC0
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x20750D0 Offset: 0x20742D0 VA: 0x1820750D0
	protected XmlDocument get_Document() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	protected XmlReader get_Reader() { }

	// RVA: 0x20701D0 Offset: 0x206F3D0 VA: 0x1820701D0
	protected void AddFixup(XmlSerializationReader.CollectionFixup fixup) { }

	// RVA: 0x2070370 Offset: 0x206F570 VA: 0x182070370
	protected void AddFixup(XmlSerializationReader.Fixup fixup) { }

	// RVA: 0x20702E0 Offset: 0x206F4E0 VA: 0x1820702E0
	private void AddFixup(XmlSerializationReader.CollectionItemFixup fixup) { }

	// RVA: 0x2070400 Offset: 0x206F600 VA: 0x182070400
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x2070530 Offset: 0x206F730 VA: 0x182070530
	protected void AddTarget(string id, object o) { }

	// RVA: 0x2070920 Offset: 0x206FB20 VA: 0x182070920
	private string CurrentTag() { }

	// RVA: 0x2070660 Offset: 0x206F860 VA: 0x182070660
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x20706E0 Offset: 0x206F8E0 VA: 0x1820706E0
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x2070760 Offset: 0x206F960 VA: 0x182070760
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x20707E0 Offset: 0x206F9E0 VA: 0x1820707E0
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x2070AE0 Offset: 0x206FCE0 VA: 0x182070AE0
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x2070D20 Offset: 0x206FF20 VA: 0x182070D20
	protected bool GetNullAttr() { }

	// RVA: 0x2070E00 Offset: 0x2070000 VA: 0x182070E00
	protected object GetTarget(string id) { }

	// RVA: 0x2074860 Offset: 0x2073A60 VA: 0x182074860
	private bool TargetReady(string id) { }

	// RVA: 0x2070ED0 Offset: 0x20700D0 VA: 0x182070ED0
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void InitIDs();

	// RVA: 0x20714D0 Offset: 0x20706D0 VA: 0x1820714D0
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x2071960 Offset: 0x2070B60 VA: 0x182071960
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x2071B20 Offset: 0x2070D20 VA: 0x182071B20
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x2071C40 Offset: 0x2070E40 VA: 0x182071C40
	protected void ReadEndElement() { }

	// RVA: 0x2072240 Offset: 0x2071440 VA: 0x182072240
	protected bool ReadNull() { }

	// RVA: 0x2072430 Offset: 0x2071630 VA: 0x182072430
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x2072460 Offset: 0x2071660 VA: 0x182072460
	protected string ReadNullableString() { }

	// RVA: 0x20727A0 Offset: 0x20719A0 VA: 0x1820727A0
	protected object ReadReferencedElement() { }

	// RVA: 0x2070C10 Offset: 0x206FE10 VA: 0x182070C10
	private XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x20724B0 Offset: 0x20716B0 VA: 0x1820724B0
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x2071D10 Offset: 0x2070F10 VA: 0x182071D10
	private bool ReadList(out object resultList) { }

	// RVA: 0x2072810 Offset: 0x2071A10 VA: 0x182072810
	protected void ReadReferencedElements() { }

	// RVA: 0x20736F0 Offset: 0x20728F0 VA: 0x1820736F0
	protected object ReadReferencingElement(out string fixupReference) { }

	// RVA: 0x20736D0 Offset: 0x20728D0 VA: 0x1820736D0
	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	// RVA: 0x2073780 Offset: 0x2072980 VA: 0x182073780
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	// RVA: 0x2073AF0 Offset: 0x2072CF0 VA: 0x182073AF0
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x20745E0 Offset: 0x20737E0 VA: 0x1820745E0
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x2073CF0 Offset: 0x2072EF0 VA: 0x182073CF0
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x2074730 Offset: 0x2073930 VA: 0x182074730
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x20745F0 Offset: 0x20737F0 VA: 0x1820745F0
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x20747A0 Offset: 0x20739A0 VA: 0x1820747A0
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x2074890 Offset: 0x2073A90 VA: 0x182074890
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x2074AF0 Offset: 0x2073CF0 VA: 0x182074AF0
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x2074D50 Offset: 0x2073F50 VA: 0x182074D50
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x206B220 Offset: 0x206A420 VA: 0x18206B220
	protected void UnknownNode(object o) { }

	// RVA: 0x2074FB0 Offset: 0x20741B0 VA: 0x182074FB0
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x2071550 Offset: 0x2070750 VA: 0x182071550
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x2075030 Offset: 0x2074230 VA: 0x182075030
	protected void UnreferencedObject(string id, object o) { }
}

// Namespace: 
private class XmlSerializationReaderInterpreter.FixupCallbackInfo // TypeDefIndex: 12176
{
	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private ClassMap _map; // 0x18
	private bool _isValueList; // 0x20

	// Methods

	// RVA: 0x15A45E0 Offset: 0x15A37E0 VA: 0x1815A45E0
	public void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

	// RVA: 0x205D640 Offset: 0x205C840 VA: 0x18205D640
	public void FixupMembers(object fixup) { }
}

// Namespace: 
private class XmlSerializationReaderInterpreter.ReaderCallbackInfo // TypeDefIndex: 12177
{
	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

	// RVA: 0x205D700 Offset: 0x205C900 VA: 0x18205D700
	internal object ReadObject() { }
}

// Namespace: System.Xml.Serialization
internal class XmlSerializationReaderInterpreter : XmlSerializationReader // TypeDefIndex: 12178
{
	// Fields
	private XmlMapping _typeMap; // 0xD0
	private SerializationFormat _format; // 0xD8
	private static readonly XmlQualifiedName AnyType; // 0x0
	private static readonly object[] empty_array; // 0x8

	// Methods

	// RVA: 0x2070190 Offset: 0x206F390 VA: 0x182070190
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x206AE10 Offset: 0x206A010 VA: 0x18206AE10 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected override void InitIDs() { }

	// RVA: 0x206F5A0 Offset: 0x206E7A0 VA: 0x18206F5A0
	public object ReadRoot() { }

	// RVA: 0x206BBA0 Offset: 0x206ADA0 VA: 0x18206BBA0
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x206E890 Offset: 0x206DA90 VA: 0x18206E890 Slot: 6
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x206F490 Offset: 0x206E690 VA: 0x18206F490
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x206EFF0 Offset: 0x206E1F0 VA: 0x18206EFF0 Slot: 7
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x206B890 Offset: 0x206AA90 VA: 0x18206B890 Slot: 8
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x206B7C0 Offset: 0x206A9C0 VA: 0x18206B7C0 Slot: 9
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x206B290 Offset: 0x206A490 VA: 0x18206B290
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x206C550 Offset: 0x206B750 VA: 0x18206C550
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x206FC60 Offset: 0x206EE60 VA: 0x18206FC60
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x206A700 Offset: 0x2069900 VA: 0x18206A700
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x206B220 Offset: 0x206A420 VA: 0x18206B220 Slot: 10
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x206B220 Offset: 0x206A420 VA: 0x18206B220 Slot: 11
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x206B1A0 Offset: 0x206A3A0 VA: 0x18206B1A0
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x206FF20 Offset: 0x206F120 VA: 0x18206FF20
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x206FE20 Offset: 0x206F020 VA: 0x18206FE20
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x206AC10 Offset: 0x2069E10 VA: 0x18206AC10
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x206EE10 Offset: 0x206E010 VA: 0x18206EE10
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x206F300 Offset: 0x206E500 VA: 0x18206F300
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x206ACE0 Offset: 0x2069EE0 VA: 0x18206ACE0
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x206BD90 Offset: 0x206AF90 VA: 0x18206BD90
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x206C2C0 Offset: 0x206B4C0 VA: 0x18206C2C0
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x2069EE0 Offset: 0x20690E0 VA: 0x182069EE0
	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x206A5D0 Offset: 0x20697D0 VA: 0x18206A5D0
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x206A5E0 Offset: 0x20697E0 VA: 0x18206A5E0
	private object CreateInstance(Type type) { }

	// RVA: 0x206A640 Offset: 0x2069840 VA: 0x18206A640
	private object CreateList(Type listType) { }

	// RVA: 0x206B120 Offset: 0x206A320 VA: 0x18206B120
	private object InitializeList(TypeData listType) { }

	// RVA: 0x206A6E0 Offset: 0x20698E0 VA: 0x18206A6E0
	private void FillList(object list, object items) { }

	// RVA: 0x206A290 Offset: 0x2069490 VA: 0x18206A290
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x206F870 Offset: 0x206EA70 VA: 0x18206F870
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x206F8A0 Offset: 0x206EAA0 VA: 0x18206F8A0
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x206F230 Offset: 0x206E430 VA: 0x18206F230
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x206BD10 Offset: 0x206AF10 VA: 0x18206BD10
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x206AA30 Offset: 0x2069C30 VA: 0x18206AA30
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x206FA60 Offset: 0x206EC60 VA: 0x18206FA60
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x20700D0 Offset: 0x206F2D0 VA: 0x1820700D0
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationWriteCallback : MulticastDelegate // TypeDefIndex: 12179
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(object o) { }
}

// Namespace: 
private class XmlSerializationWriter.WriteCallbackInfo // TypeDefIndex: 12180
{
	// Fields
	public Type Type; // 0x10
	public string TypeName; // 0x18
	public string TypeNs; // 0x20
	public XmlSerializationWriteCallback Callback; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode // TypeDefIndex: 12181
{
	// Fields
	private ObjectIDGenerator idGenerator; // 0x10
	private int qnameCount; // 0x18
	private bool topLevelElement; // 0x1C
	private ArrayList namespaces; // 0x20
	private XmlWriter writer; // 0x28
	private Queue referencedElements; // 0x30
	private Hashtable callbacks; // 0x38
	private Hashtable serializedObjects; // 0x40

	// Properties
	protected XmlWriter Writer { get; }

	// Methods

	// RVA: 0x2078870 Offset: 0x2077A70 VA: 0x182078870
	protected void .ctor() { }

	// RVA: 0x2075960 Offset: 0x2074B60 VA: 0x182075960
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	protected XmlWriter get_Writer() { }

	// RVA: 0x2075160 Offset: 0x2074360 VA: 0x182075160
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x2075300 Offset: 0x2074500 VA: 0x182075300
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x2075380 Offset: 0x2074580 VA: 0x182075380
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x2075420 Offset: 0x2074620 VA: 0x182075420
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x20754A0 Offset: 0x20746A0 VA: 0x1820754A0
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x2075560 Offset: 0x2074760 VA: 0x182075560
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x2075250 Offset: 0x2074450 VA: 0x182075250
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x2075670 Offset: 0x2074870 VA: 0x182075670
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x20757A0 Offset: 0x20749A0 VA: 0x1820757A0
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: 0x2075B90 Offset: 0x2074D90 VA: 0x182075B90
	protected void TopLevelElement() { }

	// RVA: 0x2075F00 Offset: 0x2075100 VA: 0x182075F00
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x2075EC0 Offset: 0x20750C0 VA: 0x182075EC0
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x2078640 Offset: 0x2077840 VA: 0x182078640
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x2075F40 Offset: 0x2075140 VA: 0x182075F40
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x2076030 Offset: 0x2075230 VA: 0x182076030
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x2076320 Offset: 0x2075520 VA: 0x182076320
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x2076120 Offset: 0x2075320 VA: 0x182076120
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x2076340 Offset: 0x2075540 VA: 0x182076340
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x2076360 Offset: 0x2075560 VA: 0x182076360
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x205C340 Offset: 0x205B540 VA: 0x18205C340
	protected void WriteEndElement() { }

	// RVA: 0x2076500 Offset: 0x2075700 VA: 0x182076500
	protected void WriteEndElement(object o) { }

	// RVA: 0x2076560 Offset: 0x2075760 VA: 0x182076560
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x2076AB0 Offset: 0x2075CB0 VA: 0x182076AB0
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x2076B60 Offset: 0x2075D60 VA: 0x182076B60
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x2076C00 Offset: 0x2075E00 VA: 0x182076C00
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x2076C20 Offset: 0x2075E20 VA: 0x182076C20
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x2076900 Offset: 0x2075B00 VA: 0x182076900
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x20769D0 Offset: 0x2075BD0 VA: 0x1820769D0
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x2076C50 Offset: 0x2075E50 VA: 0x182076C50
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x2077120 Offset: 0x2076320 VA: 0x182077120
	protected void WriteReferencedElements() { }

	// RVA: 0x2075A90 Offset: 0x2074C90 VA: 0x182075A90
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x2075BA0 Offset: 0x2074DA0 VA: 0x182075BA0
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x20773A0 Offset: 0x20765A0 VA: 0x1820773A0
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x2075290 Offset: 0x2074490 VA: 0x182075290
	private void CheckReferenceQueue() { }

	// RVA: 0x2077660 Offset: 0x2076860 VA: 0x182077660
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x2077510 Offset: 0x2076710 VA: 0x182077510
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x20777A0 Offset: 0x20769A0 VA: 0x1820777A0
	protected void WriteStartDocument() { }

	// RVA: 0x2077830 Offset: 0x2076A30 VA: 0x182077830
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x2077800 Offset: 0x2076A00 VA: 0x182077800
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x2077F20 Offset: 0x2077120 VA: 0x182077F20
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x2077EF0 Offset: 0x20770F0 VA: 0x182077EF0
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x2077860 Offset: 0x2076A60 VA: 0x182077860
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x2077F50 Offset: 0x2077150 VA: 0x182077F50
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x2078300 Offset: 0x2077500 VA: 0x182078300
	protected void WriteValue(string value) { }

	// RVA: 0x2078340 Offset: 0x2077540 VA: 0x182078340
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x2078780 Offset: 0x2077980 VA: 0x182078780
	protected void WriteXsiType(string name, string ns) { }
}

// Namespace: 
private class XmlSerializationWriterInterpreter.CallbackInfo // TypeDefIndex: 12182
{
	// Fields
	private XmlSerializationWriterInterpreter _swi; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

	// RVA: 0x207DFB0 Offset: 0x207D1B0 VA: 0x18207DFB0
	internal void WriteObject(object ob) { }

	// RVA: 0x207DF50 Offset: 0x207D150 VA: 0x18207DF50
	internal void WriteEnum(object ob) { }
}

// Namespace: System.Xml.Serialization
internal class XmlSerializationWriterInterpreter : XmlSerializationWriter // TypeDefIndex: 12183
{
	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x208F5F0 Offset: 0x208E7F0 VA: 0x18208F5F0
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x208BCE0 Offset: 0x208AEE0 VA: 0x18208BCE0 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x208F340 Offset: 0x208E540 VA: 0x18208F340
	public void WriteRoot(object ob) { }

	// RVA: 0x208E680 Offset: 0x208D880 VA: 0x18208E680 Slot: 5
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x208E160 Offset: 0x208D360 VA: 0x18208E160 Slot: 6
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x208E500 Offset: 0x208D700 VA: 0x18208E500 Slot: 7
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x208E380 Offset: 0x208D580 VA: 0x18208E380 Slot: 8
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x208E440 Offset: 0x208D640 VA: 0x18208E440 Slot: 9
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x208E100 Offset: 0x208D300 VA: 0x18208E100
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x208C7A0 Offset: 0x208B9A0 VA: 0x18208C7A0
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x208CCB0 Offset: 0x208BEB0 VA: 0x18208CCB0
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x208B630 Offset: 0x208A830 VA: 0x18208B630
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x208C020 Offset: 0x208B220 VA: 0x18208C020
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x208DBC0 Offset: 0x208CDC0 VA: 0x18208DBC0
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x208B980 Offset: 0x208AB80 VA: 0x18208B980
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x208F0A0 Offset: 0x208E2A0 VA: 0x18208F0A0
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x208EDD0 Offset: 0x208DFD0 VA: 0x18208EDD0
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x208D940 Offset: 0x208CB40 VA: 0x18208D940 Slot: 10
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x208D220 Offset: 0x208C420 VA: 0x18208D220
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x208B490 Offset: 0x208A690 VA: 0x18208B490
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x208C270 Offset: 0x208B470 VA: 0x18208C270
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x208ED80 Offset: 0x208DF80 VA: 0x18208ED80 Slot: 11
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x208D1E0 Offset: 0x208C3E0 VA: 0x18208D1E0 Slot: 12
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x208B700 Offset: 0x208A900 VA: 0x18208B700
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x208B370 Offset: 0x208A570 VA: 0x18208B370
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }
}

// Namespace: 
internal class XmlSerializer.SerializerData // TypeDefIndex: 12184
{
	// Fields
	public MethodInfo ReaderMethod; // 0x10
	public Type WriterType; // 0x18
	public MethodInfo WriterMethod; // 0x20
	public XmlSerializerImplementation Implementation; // 0x28

	// Methods

	// RVA: 0x2088940 Offset: 0x2087B40 VA: 0x182088940
	public XmlSerializationWriter CreateWriter() { }
}

// Namespace: System.Xml.Serialization
public class XmlSerializer // TypeDefIndex: 12185
{
	// Fields
	private static int generationThreshold; // 0x0
	private static bool backgroundGeneration; // 0x4
	private static bool deleteTempFiles; // 0x5
	private static bool generatorFallback; // 0x6
	private bool customSerializer; // 0x10
	private XmlMapping typeMapping; // 0x18
	private XmlSerializer.SerializerData serializerData; // 0x20
	private static Hashtable serializerTypes; // 0x8
	private UnreferencedObjectEventHandler onUnreferencedObject; // 0x28
	private XmlAttributeEventHandler onUnknownAttribute; // 0x30
	private XmlElementEventHandler onUnknownElement; // 0x38
	private XmlNodeEventHandler onUnknownNode; // 0x40

	// Properties
	internal XmlMapping Mapping { get; }

	// Methods

	// RVA: 0x20908E0 Offset: 0x208FAE0 VA: 0x1820908E0
	private static void .cctor() { }

	// RVA: 0x2090B40 Offset: 0x208FD40 VA: 0x182090B40
	public void .ctor(Type type) { }

	// RVA: 0x20909C0 Offset: 0x208FBC0 VA: 0x1820909C0
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal XmlMapping get_Mapping() { }

	// RVA: 0x2090270 Offset: 0x208F470 VA: 0x182090270 Slot: 4
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0x20902A0 Offset: 0x208F4A0 VA: 0x1820902A0 Slot: 5
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0x20902D0 Offset: 0x208F4D0 VA: 0x1820902D0 Slot: 6
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0xBD4BB0 Offset: 0xBD3DB0 VA: 0x180BD4BB0 Slot: 7
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0x208FA40 Offset: 0x208EC40 VA: 0x18208FA40 Slot: 8
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0x208FD30 Offset: 0x208EF30 VA: 0x18208FD30 Slot: 9
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0x208FE30 Offset: 0x208F030 VA: 0x18208FE30
	public object Deserialize(TextReader textReader) { }

	// RVA: 0x208FD70 Offset: 0x208EF70 VA: 0x18208FD70
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0x208FF60 Offset: 0x208F160 VA: 0x18208FF60 Slot: 10
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0x20903A0 Offset: 0x208F5A0 VA: 0x1820903A0 Slot: 11
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0x2090300 Offset: 0x208F500 VA: 0x182090300
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0x20908C0 Offset: 0x208FAC0 VA: 0x1820908C0
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0x2090600 Offset: 0x208F800 VA: 0x182090600
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0x208FA80 Offset: 0x208EC80 VA: 0x18208FA80
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0x208F9E0 Offset: 0x208EBE0 VA: 0x18208F9E0
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }
}

// Namespace: System.Xml.Serialization
public class XmlSerializerFactory // TypeDefIndex: 12186
{
	// Fields
	private static Hashtable serializersBySource; // 0x0

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x208F8E0 Offset: 0x208EAE0 VA: 0x18208F8E0
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0x208F910 Offset: 0x208EB10 VA: 0x18208F910
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0x208F630 Offset: 0x208E830 VA: 0x18208F630
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x208F940 Offset: 0x208EB40 VA: 0x18208F940
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializerImplementation // TypeDefIndex: 12187
{
	// Properties
	public virtual XmlSerializationWriter Writer { get; }

	// Methods

	// RVA: 0x208F9A0 Offset: 0x208EBA0 VA: 0x18208F9A0 Slot: 4
	public virtual XmlSerializationWriter get_Writer() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlTextAttribute : Attribute // TypeDefIndex: 12188
{
	// Fields
	private string dataType; // 0x10
	private Type type; // 0x18

	// Properties
	public string DataType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x2090C00 Offset: 0x208FE00 VA: 0x182090C00
	public string get_DataType() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Type get_Type() { }

	// RVA: 0x2090B70 Offset: 0x208FD70 VA: 0x182090B70
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(1052)]
public class XmlTypeAttribute : Attribute // TypeDefIndex: 12189
{
	// Fields
	private bool includeInSchema; // 0x10
	private string ns; // 0x18
	private string typeName; // 0x20

	// Properties
	public bool IncludeInSchema { get; }
	public string Namespace { get; }
	public string TypeName { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IncludeInSchema() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Namespace() { }

	// RVA: 0x2090CF0 Offset: 0x208FEF0 VA: 0x182090CF0
	public string get_TypeName() { }

	// RVA: 0x2090C50 Offset: 0x208FE50 VA: 0x182090C50
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfo // TypeDefIndex: 12190
{
	// Fields
	private string _elementName; // 0x10
	private string _namespace; // 0x18
	private XmlSchemaForm _form; // 0x20
	private XmlTypeMapMember _member; // 0x28
	private object _choiceValue; // 0x30
	private bool _isNullable; // 0x38
	private int _nestingLevel; // 0x3C
	private XmlTypeMapping _mappedType; // 0x40
	private TypeData _type; // 0x48
	private bool _wrappedElement; // 0x50
	private int _explicitOrder; // 0x54

	// Properties
	public TypeData TypeData { get; }
	public object ChoiceValue { get; set; }
	public string ElementName { get; set; }
	public string Namespace { get; set; }
	public string DataTypeNamespace { get; }
	public string DataTypeName { get; }
	public XmlSchemaForm Form { get; set; }
	public XmlTypeMapping MappedType { get; set; }
	public bool IsNullable { get; set; }
	public XmlTypeMapMember Member { get; }
	public int NestingLevel { set; }
	public bool MultiReferenceType { get; }
	public bool WrappedElement { get; set; }
	public bool IsTextElement { get; set; }
	public bool IsUnnamedAnyElement { get; set; }
	public int ExplicitOrder { get; set; }

	// Methods

	// RVA: 0x2090EB0 Offset: 0x20900B0 VA: 0x182090EB0
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public TypeData get_TypeData() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public object get_ChoiceValue() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_ChoiceValue(object value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ElementName() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ElementName(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Namespace() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Namespace(string value) { }

	// RVA: 0x2090F80 Offset: 0x2090180 VA: 0x182090F80
	public string get_DataTypeNamespace() { }

	// RVA: 0x2090F50 Offset: 0x2090150 VA: 0x182090F50
	public string get_DataTypeName() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public XmlSchemaForm get_Form() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_IsNullable() { }

	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_IsNullable(bool value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70
	public void set_NestingLevel(int value) { }

	// RVA: 0x2091090 Offset: 0x2090290 VA: 0x182091090
	public bool get_MultiReferenceType() { }

	// RVA: 0x4D1A10 Offset: 0x4D0C10 VA: 0x1804D1A10
	public bool get_WrappedElement() { }

	// RVA: 0x4D1A50 Offset: 0x4D0C50 VA: 0x1804D1A50
	public void set_WrappedElement(bool value) { }

	// RVA: 0x2091000 Offset: 0x2090200 VA: 0x182091000
	public bool get_IsTextElement() { }

	// RVA: 0x20910B0 Offset: 0x20902B0 VA: 0x1820910B0
	public void set_IsTextElement(bool value) { }

	// RVA: 0x2091040 Offset: 0x2090240 VA: 0x182091040
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0x2091170 Offset: 0x2090370 VA: 0x182091170
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	public int get_ExplicitOrder() { }

	// RVA: 0x4D1A80 Offset: 0x4D0C80 VA: 0x1804D1A80
	public void set_ExplicitOrder(int value) { }

	// RVA: 0x2090D50 Offset: 0x208FF50 VA: 0x182090D50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfoList : ArrayList // TypeDefIndex: 12191
{
	// Methods

	// RVA: 0x2090D40 Offset: 0x208FF40 VA: 0x182090D40
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMember // TypeDefIndex: 12192
{
	// Fields
	private string _name; // 0x10
	private int _index; // 0x18
	private int _globalIndex; // 0x1C
	private int _specifiedGlobalIndex; // 0x20
	private TypeData _typeData; // 0x28
	private MemberInfo _member; // 0x30
	private MemberInfo _specifiedMember; // 0x38
	private MethodInfo _shouldSerialize; // 0x40
	private object _defaultValue; // 0x48
	private int _flags; // 0x50

	// Properties
	public string Name { get; set; }
	public object DefaultValue { get; set; }
	public TypeData TypeData { get; set; }
	public int Index { get; set; }
	public int GlobalIndex { get; set; }
	public bool IsOptionalValueType { get; set; }
	public bool IsReturnValue { get; set; }

	// Methods

	// RVA: 0x2091220 Offset: 0x2090420 VA: 0x182091220
	public void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Name(string value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public object get_DefaultValue() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_DefaultValue(object value) { }

	// RVA: 0x20929E0 Offset: 0x2091BE0 VA: 0x1820929E0
	public bool IsReadOnly(Type type) { }

	// RVA: 0x2092480 Offset: 0x2091680 VA: 0x182092480
	public static object GetValue(object ob, string name) { }

	// RVA: 0x2092250 Offset: 0x2091450 VA: 0x182092250
	public object GetValue(object ob) { }

	// RVA: 0x2092F70 Offset: 0x2092170 VA: 0x182092F70
	public void SetValue(object ob, object value) { }

	// RVA: 0x20931D0 Offset: 0x20923D0 VA: 0x1820931D0
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0x20926E0 Offset: 0x20918E0 VA: 0x1820926E0
	private void InitMember(Type type) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public TypeData get_TypeData() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_TypeData(TypeData value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Index() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Index(int value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_GlobalIndex() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_GlobalIndex(int value) { }

	// RVA: 0x160E000 Offset: 0x160D200 VA: 0x18160E000
	public bool get_IsOptionalValueType() { }

	// RVA: 0x2093440 Offset: 0x2092640 VA: 0x182093440
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0x160DFF0 Offset: 0x160D1F0 VA: 0x18160DFF0
	public bool get_IsReturnValue() { }

	// RVA: 0x2093470 Offset: 0x2092670 VA: 0x182093470
	public void set_IsReturnValue(bool value) { }

	// RVA: 0x2091E20 Offset: 0x2091020 VA: 0x182091E20
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0x2091EA0 Offset: 0x20910A0 VA: 0x182091EA0
	public bool GetValueSpecified(object ob) { }

	// RVA: 0x2092B30 Offset: 0x2091D30 VA: 0x182092B30
	public void SetValueSpecified(object ob, bool value) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAttribute : XmlTypeMapMember // TypeDefIndex: 12193
{
	// Fields
	private string _attributeName; // 0x58
	private string _namespace; // 0x60
	private XmlSchemaForm _form; // 0x68
	private XmlTypeMapping _mappedType; // 0x70

	// Properties
	public string AttributeName { get; set; }
	public string Namespace { get; set; }
	public XmlSchemaForm Form { set; }
	public XmlTypeMapping MappedType { get; set; }

	// Methods

	// RVA: 0x2091790 Offset: 0x2090990 VA: 0x182091790
	public void .ctor() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_AttributeName() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_AttributeName(string value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_Namespace() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_Namespace(string value) { }

	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_MappedType(XmlTypeMapping value) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberElement : XmlTypeMapMember // TypeDefIndex: 12194
{
	// Fields
	private XmlTypeMapElementInfoList _elementInfo; // 0x58
	private string _choiceMember; // 0x60
	private bool _isTextCollector; // 0x68
	private TypeData _choiceTypeData; // 0x70

	// Properties
	public XmlTypeMapElementInfoList ElementInfo { get; set; }
	public string ChoiceMember { get; set; }
	public TypeData ChoiceTypeData { get; set; }
	public bool IsXmlTextCollector { get; set; }

	// Methods

	// RVA: 0x2091220 Offset: 0x2090420 VA: 0x182091220
	public void .ctor() { }

	// RVA: 0x2091DB0 Offset: 0x2090FB0 VA: 0x182091DB0
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_ChoiceMember() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_ChoiceMember(string value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0x2091820 Offset: 0x2090A20 VA: 0x182091820
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0x2091D90 Offset: 0x2090F90 VA: 0x182091D90
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	public bool get_IsXmlTextCollector() { }

	// RVA: 0x563E60 Offset: 0x563060 VA: 0x180563E60
	public void set_IsXmlTextCollector(bool value) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberList : XmlTypeMapMemberElement // TypeDefIndex: 12195
{
	// Methods

	// RVA: 0x2091220 Offset: 0x2090420 VA: 0x182091220
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement // TypeDefIndex: 12196
{
	// Fields
	private int _flatArrayIndex; // 0x78

	// Properties
	public int FlatArrayIndex { get; set; }

	// Methods

	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990
	public int get_FlatArrayIndex() { }

	// RVA: 0x4EDD40 Offset: 0x4ECF40 VA: 0x1804EDD40
	public void set_FlatArrayIndex(int value) { }

	// RVA: 0x2091220 Offset: 0x2090420 VA: 0x182091220
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable // TypeDefIndex: 12197
{
	// Fields
	private ListMap _listMap; // 0x80

	// Properties
	public ListMap ListMap { get; set; }

	// Methods

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public ListMap get_ListMap() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_ListMap(ListMap value) { }

	// RVA: 0x2091220 Offset: 0x2090420 VA: 0x182091220
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable // TypeDefIndex: 12198
{
	// Properties
	public bool IsDefaultAny { get; }

	// Methods

	// RVA: 0x2091290 Offset: 0x2090490 VA: 0x182091290
	public bool IsElementDefined(string name, string ns) { }

	// RVA: 0x2091510 Offset: 0x2090710 VA: 0x182091510
	public bool get_IsDefaultAny() { }

	// RVA: 0x2091220 Offset: 0x2090420 VA: 0x182091220
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember // TypeDefIndex: 12199
{
	// Methods

	// RVA: 0x2091220 Offset: 0x2090420 VA: 0x182091220
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberNamespaces : XmlTypeMapMember // TypeDefIndex: 12200
{
	// Methods

	// RVA: 0x2091220 Offset: 0x2090420 VA: 0x182091220
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
public class XmlTypeMapping : XmlMapping // TypeDefIndex: 12201
{
	// Fields
	private string xmlType; // 0x48
	private string xmlTypeNamespace; // 0x50
	private TypeData type; // 0x58
	private XmlTypeMapping baseMap; // 0x60
	private bool multiReferenceType; // 0x68
	private bool includeInSchema; // 0x69
	private bool isNullable; // 0x6A
	private bool isAny; // 0x6B
	private ArrayList _derivedTypes; // 0x70

	// Properties
	public string TypeFullName { get; }
	internal TypeData TypeData { get; }
	internal string XmlType { get; set; }
	internal string XmlTypeNamespace { get; set; }
	internal bool HasXmlTypeNamespace { get; }
	internal ArrayList DerivedTypes { get; }
	internal bool MultiReferenceType { get; }
	internal XmlTypeMapping BaseMap { get; set; }
	internal bool IncludeInSchema { set; }
	internal bool IsNullable { get; set; }
	internal bool IsAny { get; set; }

	// Methods

	// RVA: 0x2093930 Offset: 0x2092B30 VA: 0x182093930
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0x2093A00 Offset: 0x2092C00 VA: 0x182093A00
	public string get_TypeFullName() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal TypeData get_TypeData() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal string get_XmlType() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	internal void set_XmlType(string value) { }

	// RVA: 0x2093A20 Offset: 0x2092C20 VA: 0x182093A20
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0x20939E0 Offset: 0x2092BE0 VA: 0x1820939E0
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	internal bool get_MultiReferenceType() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0x1C13530 Offset: 0x1C12730 VA: 0x181C13530
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0x1C13490 Offset: 0x1C12690 VA: 0x181C13490
	internal bool get_IsNullable() { }

	// RVA: 0x1C13500 Offset: 0x1C12700 VA: 0x181C13500
	internal void set_IsNullable(bool value) { }

	// RVA: 0x20939F0 Offset: 0x2092BF0 VA: 0x1820939F0
	internal bool get_IsAny() { }

	// RVA: 0x2093A70 Offset: 0x2092C70 VA: 0x182093A70
	internal void set_IsAny(bool value) { }

	// RVA: 0x2093700 Offset: 0x2092900 VA: 0x182093700
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0x20934A0 Offset: 0x20926A0 VA: 0x1820934A0
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0x20938B0 Offset: 0x2092AB0 VA: 0x1820938B0
	internal void UpdateRoot(XmlQualifiedName qname) { }
}

// Namespace: System.Xml.Serialization
internal class XmlSerializableMapping : XmlTypeMapping // TypeDefIndex: 12202
{
	// Fields
	private XmlSchema _schema; // 0x78
	private XmlSchemaComplexType _schemaType; // 0x80
	private XmlQualifiedName _schemaTypeName; // 0x88

	// Methods

	// RVA: 0x208AA20 Offset: 0x2089C20 VA: 0x18208AA20
	internal void .ctor(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }
}

// Namespace: System.Xml.Serialization
internal class ClassMap : ObjectMap // TypeDefIndex: 12203
{
	// Fields
	private Hashtable _elements; // 0x10
	private ArrayList _elementMembers; // 0x18
	private Hashtable _attributeMembers; // 0x20
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; // 0x28
	private ArrayList _flatLists; // 0x30
	private ArrayList _allMembers; // 0x38
	private ArrayList _membersWithDefault; // 0x40
	private ArrayList _listMembers; // 0x48
	private XmlTypeMapMemberAnyElement _defaultAnyElement; // 0x50
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; // 0x58
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; // 0x60
	private XmlTypeMapMember _xmlTextCollector; // 0x68
	private XmlTypeMapMember _returnMember; // 0x70
	private bool _ignoreMemberNamespace; // 0x78
	private bool _canBeSimpleType; // 0x79
	private Nullable<bool> _isOrderDependentMap; // 0x7A

	// Properties
	public bool IsOrderDependentMap { get; }
	public XmlTypeMapMemberAnyElement DefaultAnyElementMember { get; }
	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember { get; }
	public XmlTypeMapMemberNamespaces NamespaceDeclarations { get; }
	public ICollection AttributeMembers { get; }
	public ICollection ElementMembers { get; }
	public ArrayList AllMembers { get; }
	public ArrayList FlatLists { get; }
	public ArrayList ListMembers { get; }
	public XmlTypeMapMember XmlTextCollector { get; }
	public XmlTypeMapMember ReturnMember { get; }
	public XmlQualifiedName SimpleContentBaseType { get; }
	public bool HasSimpleContent { get; }

	// Methods

	// RVA: 0x207E710 Offset: 0x207D910 VA: 0x18207E710
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x207FB70 Offset: 0x207ED70 VA: 0x18207FB70
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x207F530 Offset: 0x207E730 VA: 0x18207F530
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x207F690 Offset: 0x207E890 VA: 0x18207F690
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x207F950 Offset: 0x207EB50 VA: 0x18207F950
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x207F460 Offset: 0x207E660 VA: 0x18207F460
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x2080020 Offset: 0x207F220 VA: 0x182080020
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x207FCB0 Offset: 0x207EEB0 VA: 0x18207FCB0
	public ICollection get_AttributeMembers() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ICollection get_ElementMembers() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public ArrayList get_AllMembers() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ArrayList get_FlatLists() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public ArrayList get_ListMembers() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x20802F0 Offset: 0x207F4F0 VA: 0x1820802F0
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x646CE0 Offset: 0x645EE0 VA: 0x180646CE0
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x207FFC0 Offset: 0x207F1C0 VA: 0x18207FFC0
	public bool get_HasSimpleContent() { }

	// RVA: 0x207FC20 Offset: 0x207EE20 VA: 0x18207FC20
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class ListMap : ObjectMap // TypeDefIndex: 12204
{
	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Properties
	public string ChoiceMember { set; }
	public XmlTypeMapElementInfoList ItemInfo { get; set; }

	// Methods

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ChoiceMember(string value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x20832D0 Offset: 0x20824D0 VA: 0x1820832D0
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x2083930 Offset: 0x2082B30 VA: 0x182083930
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x2083B20 Offset: 0x2082D20 VA: 0x182083B20
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x2083D20 Offset: 0x2082F20 VA: 0x182083D20
	public void GetArrayType(int itemCount, out string localName, out string ns) { }

	// RVA: 0x2083130 Offset: 0x2082330 VA: 0x182083130 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
public class EnumMap.EnumMapMember // TypeDefIndex: 12205
{
	// Fields
	private readonly string _xmlName; // 0x10
	private readonly string _enumName; // 0x18
	private readonly long _value; // 0x20

	// Properties
	public string XmlName { get; }
	public string EnumName { get; }
	public long Value { get; }

	// Methods

	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	public void .ctor(string xmlName, string enumName, long value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_XmlName() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_EnumName() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public long get_Value() { }
}

// Namespace: System.Xml.Serialization
internal class EnumMap : ObjectMap // TypeDefIndex: 12206
{
	// Fields
	private readonly EnumMap.EnumMapMember[] _members; // 0x10
	private readonly bool _isFlags; // 0x18
	private readonly string[] _enumNames; // 0x20
	private readonly string[] _xmlNames; // 0x28
	private readonly long[] _values; // 0x30

	// Properties
	public bool IsFlags { get; }
	public string[] EnumNames { get; }
	public string[] XmlNames { get; }
	public long[] Values { get; }

	// Methods

	// RVA: 0x20820C0 Offset: 0x20812C0 VA: 0x1820820C0
	public void .ctor(EnumMap.EnumMapMember[] members, bool isFlags) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_IsFlags() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string[] get_EnumNames() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string[] get_XmlNames() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public long[] get_Values() { }

	// RVA: 0x2081D10 Offset: 0x2080F10 VA: 0x182081D10
	public string GetXmlName(string typeName, object enumValue) { }

	// RVA: 0x2081A10 Offset: 0x2080C10 VA: 0x182081A10
	public string GetEnumName(string typeName, string xmlName) { }
}

// Namespace: System.Xml.XmlConfiguration
[EditorBrowsable(1)]
public sealed class XmlReaderSection // TypeDefIndex: 12207
{
	// Properties
	internal static bool ProhibitDefaultUrlResolver { get; }
	internal static bool CollapseWhiteSpaceIntoEmptyString { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool get_ProhibitDefaultUrlResolver() { }

	// RVA: 0x208A9D0 Offset: 0x2089BD0 VA: 0x18208A9D0
	internal static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool get_CollapseWhiteSpaceIntoEmptyString() { }
}

// Namespace: System.Xml.Xsl
public interface IXsltContextFunction // TypeDefIndex: 12208
{
	// Properties
	public abstract XPathResultType ReturnType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XPathResultType get_ReturnType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object Invoke(XsltContext xsltContext, object[] args, XPathNavigator docContext);
}

// Namespace: System.Xml.Xsl
public interface IXsltContextVariable // TypeDefIndex: 12209
{
	// Properties
	public abstract XPathResultType VariableType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XPathResultType get_VariableType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object Evaluate(XsltContext xsltContext);
}

// Namespace: System.Xml.Xsl
public abstract class XsltContext : XmlNamespaceManager // TypeDefIndex: 12210
{
	// Properties
	public abstract bool Whitespace { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	internal void .ctor(bool dummy) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IXsltContextVariable ResolveVariable(string prefix, string name);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool get_Whitespace();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool PreserveWhitespace(XPathNavigator node);
}

// Namespace: System.Xml.Xsl.Runtime
[EditorBrowsable(1)]
public struct StringConcat // TypeDefIndex: 12211
{
	// Fields
	private string s1; // 0x0
	private string s2; // 0x8
	private string s3; // 0x10
	private string s4; // 0x18
	private string delimiter; // 0x20
	private List<string> strList; // 0x28
	private int idxStr; // 0x30

	// Properties
	internal int Count { get; }

	// Methods

	// RVA: 0x2088A50 Offset: 0x2087C50 VA: 0x182088A50
	public void Clear() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	internal int get_Count() { }

	// RVA: 0x2088C60 Offset: 0x2087E60 VA: 0x182088C60
	public string GetResult() { }

	// RVA: 0x2088A60 Offset: 0x2087C60 VA: 0x182088A60
	internal void ConcatNoDelimiter(string s) { }
}

// Namespace: System.Xml.Schema
internal class AxisElement // TypeDefIndex: 12212
{
	// Fields
	internal DoubleLinkAxis curNode; // 0x10
	internal int rootDepth; // 0x18
	internal int curDepth; // 0x1C
	internal bool isMatch; // 0x20

	// Properties
	internal DoubleLinkAxis CurNode { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0x207A290 Offset: 0x2079490 VA: 0x18207A290
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0x207A280 Offset: 0x2079480 VA: 0x18207A280
	internal void SetDepth(int depth) { }

	// RVA: 0x207A120 Offset: 0x2079320 VA: 0x18207A120
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0x2079F80 Offset: 0x2079180 VA: 0x182079F80
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }
}

// Namespace: System.Xml.Schema
internal class AxisStack // TypeDefIndex: 12213
{
	// Fields
	private ArrayList _stack; // 0x10
	private ForwardAxis _subtree; // 0x18
	private ActiveAxis _parent; // 0x20

	// Properties
	internal ForwardAxis Subtree { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal ForwardAxis get_Subtree() { }

	// RVA: 0x1719620 Offset: 0x1718820 VA: 0x181719620
	internal int get_Length() { }

	// RVA: 0x207AC10 Offset: 0x2079E10 VA: 0x18207AC10
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0x207AB60 Offset: 0x2079D60 VA: 0x18207AB60
	internal void Push(int depth) { }

	// RVA: 0x207AB10 Offset: 0x2079D10 VA: 0x18207AB10
	internal void Pop() { }

	// RVA: 0x207A2D0 Offset: 0x20794D0 VA: 0x18207A2D0
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0x207A790 Offset: 0x2079990 VA: 0x18207A790
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0x207A560 Offset: 0x2079760 VA: 0x18207A560
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0x207A350 Offset: 0x2079550 VA: 0x18207A350
	internal bool MoveToAttribute(string name, string URN, int depth) { }
}

// Namespace: System.Xml.Schema
internal class ActiveAxis // TypeDefIndex: 12214
{
	// Fields
	private int _currentDepth; // 0x10
	private bool _isActive; // 0x14
	private Asttree _axisTree; // 0x18
	private ArrayList _axisStack; // 0x20

	// Properties
	public int CurrentDepth { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_CurrentDepth() { }

	// RVA: 0x2078DF0 Offset: 0x2077FF0 VA: 0x182078DF0
	internal void Reactivate() { }

	// RVA: 0x2078E00 Offset: 0x2078000 VA: 0x182078E00
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0x2078C50 Offset: 0x2077E50 VA: 0x182078C50
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0x20788E0 Offset: 0x2077AE0 VA: 0x1820788E0 Slot: 4
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0x2078A90 Offset: 0x2077C90 VA: 0x182078A90
	public bool MoveToAttribute(string localname, string URN) { }
}

// Namespace: System.Xml.Schema
internal class DoubleLinkAxis : Axis // TypeDefIndex: 12215
{
	// Fields
	internal Axis next; // 0x40

	// Properties
	internal Axis Next { get; set; }

	// Methods

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal Axis get_Next() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_Next(Axis value) { }

	// RVA: 0x2081990 Offset: 0x2080B90 VA: 0x182081990
	internal void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x2081870 Offset: 0x2080A70 VA: 0x182081870
	internal static DoubleLinkAxis ConvertTree(Axis axis) { }
}

// Namespace: System.Xml.Schema
internal class ForwardAxis // TypeDefIndex: 12216
{
	// Fields
	private DoubleLinkAxis _topNode; // 0x10
	private DoubleLinkAxis _rootNode; // 0x18
	private bool _isAttribute; // 0x20
	private bool _isDss; // 0x21
	private bool _isSelfAxis; // 0x22

	// Properties
	internal DoubleLinkAxis RootNode { get; }
	internal DoubleLinkAxis TopNode { get; }
	internal bool IsAttribute { get; }
	internal bool IsDss { get; }
	internal bool IsSelfAxis { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	internal bool get_IsAttribute() { }

	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	internal bool get_IsDss() { }

	// RVA: 0x742460 Offset: 0x741660 VA: 0x180742460
	internal bool get_IsSelfAxis() { }

	// RVA: 0x2082220 Offset: 0x2081420 VA: 0x182082220
	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }
}

// Namespace: System.Xml.Schema
internal class Asttree // TypeDefIndex: 12217
{
	// Fields
	private ArrayList _fAxisArray; // 0x10
	private string _xpathexpr; // 0x18
	private bool _isField; // 0x20
	private XmlNamespaceManager _nsmgr; // 0x28

	// Properties
	internal ArrayList SubtreeArray { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0x2079990 Offset: 0x2078B90 VA: 0x182079990
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x2079830 Offset: 0x2078A30 VA: 0x182079830
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0x20797D0 Offset: 0x20789D0 VA: 0x1820797D0
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0x2079800 Offset: 0x2078A00 VA: 0x182079800
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0x2079860 Offset: 0x2078A60 VA: 0x182079860
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0x2079030 Offset: 0x2078230 VA: 0x182079030
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x2079890 Offset: 0x2078A90 VA: 0x182079890
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }
}

// Namespace: System.Xml.Schema
internal class AutoValidator : BaseValidator // TypeDefIndex: 12218
{
	// Properties
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x2079EF0 Offset: 0x20790F0 VA: 0x182079EF0
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x2079E00 Offset: 0x2079000 VA: 0x182079E00 Slot: 5
	public override void Validate() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x2079A00 Offset: 0x2078C00 VA: 0x182079A00
	private ValidationType DetectValidationType() { }
}

// Namespace: System.Xml.Schema
internal class BaseProcessor // TypeDefIndex: 12219
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private ValidationEventHandler eventHandler; // 0x20
	private XmlSchemaCompilationSettings compilationSettings; // 0x28
	private int errorCount; // 0x30
	private string NsXml; // 0x38

	// Properties
	protected XmlNameTable NameTable { get; }
	protected SchemaNames SchemaNames { get; }
	protected ValidationEventHandler EventHandler { get; }
	protected XmlSchemaCompilationSettings CompilationSettings { get; }
	protected bool HasErrors { get; }

	// Methods

	// RVA: 0x207C0F0 Offset: 0x207B2F0 VA: 0x18207C0F0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x207C1D0 Offset: 0x207B3D0 VA: 0x18207C1D0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	protected XmlNameTable get_NameTable() { }

	// RVA: 0x207C270 Offset: 0x207B470 VA: 0x18207C270
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x15DBAD0 Offset: 0x15DACD0 VA: 0x1815DBAD0
	protected bool get_HasErrors() { }

	// RVA: 0x207ACB0 Offset: 0x2079EB0 VA: 0x18207ACB0
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x207B3F0 Offset: 0x207A5F0 VA: 0x18207B3F0
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x207B520 Offset: 0x207A720 VA: 0x18207B520
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x207B650 Offset: 0x207A850 VA: 0x18207B650
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x207BDF0 Offset: 0x207AFF0 VA: 0x18207BDF0
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0x207BA10 Offset: 0x207AC10 VA: 0x18207BA10
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0x207BEE0 Offset: 0x207B0E0 VA: 0x18207BEE0
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0x207BC90 Offset: 0x207AE90 VA: 0x18207BC90
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0x207BB20 Offset: 0x207AD20 VA: 0x18207BB20
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x207B8E0 Offset: 0x207AAE0 VA: 0x18207B8E0
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x207C040 Offset: 0x207B240 VA: 0x18207C040
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x207B970 Offset: 0x207AB70 VA: 0x18207B970
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x207B820 Offset: 0x207AA20 VA: 0x18207B820
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x207B780 Offset: 0x207A980 VA: 0x18207B780
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }
}

// Namespace: System.Xml.Schema
internal class BaseValidator // TypeDefIndex: 12220
{
	// Fields
	private XmlSchemaCollection schemaCollection; // 0x10
	private IValidationEventHandling eventHandling; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaNames schemaNames; // 0x28
	private PositionInfo positionInfo; // 0x30
	private XmlResolver xmlResolver; // 0x38
	private Uri baseUri; // 0x40
	protected SchemaInfo schemaInfo; // 0x48
	protected XmlValidatingReaderImpl reader; // 0x50
	protected XmlQualifiedName elementName; // 0x58
	protected ValidationState context; // 0x60
	protected StringBuilder textValue; // 0x68
	protected string textString; // 0x70
	protected bool hasSibling; // 0x78
	protected bool checkDatatype; // 0x79

	// Properties
	public XmlValidatingReaderImpl Reader { get; }
	public XmlSchemaCollection SchemaCollection { get; }
	public XmlNameTable NameTable { get; }
	public SchemaNames SchemaNames { get; }
	public PositionInfo PositionInfo { get; }
	public XmlResolver XmlResolver { get; set; }
	public Uri BaseUri { get; set; }
	public ValidationEventHandler EventHandler { get; }
	public SchemaInfo SchemaInfo { get; }
	public IDtdInfo DtdInfo { set; }
	public virtual bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x207D490 Offset: 0x207C690 VA: 0x18207D490
	public void .ctor(BaseValidator other) { }

	// RVA: 0x207D3D0 Offset: 0x207C5D0 VA: 0x18207D3D0
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public XmlNameTable get_NameTable() { }

	// RVA: 0x207D590 Offset: 0x207C790 VA: 0x18207D590
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Uri get_BaseUri() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_BaseUri(Uri value) { }

	// RVA: 0x207D510 Offset: 0x207C710 VA: 0x18207D510
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0x207D630 Offset: 0x207C830 VA: 0x18207D630
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public virtual void Validate() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public virtual void CompleteValidation() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public virtual object FindId(string name) { }

	// RVA: 0x207CF00 Offset: 0x207C100 VA: 0x18207CF00
	public void ValidateText() { }

	// RVA: 0x207D270 Offset: 0x207C470 VA: 0x18207D270
	public void ValidateWhitespace() { }

	// RVA: 0x207C8B0 Offset: 0x207BAB0 VA: 0x18207C8B0
	private void SaveTextValue(string value) { }

	// RVA: 0x207CA40 Offset: 0x207BC40 VA: 0x18207CA40
	protected void SendValidationEvent(string code) { }

	// RVA: 0x207CDF0 Offset: 0x207BFF0 VA: 0x18207CDF0
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x207CC50 Offset: 0x207BE50 VA: 0x18207CC50
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0x207CBC0 Offset: 0x207BDC0 VA: 0x18207CBC0
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x207CAA0 Offset: 0x207BCA0 VA: 0x18207CAA0
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x207C920 Offset: 0x207BB20 VA: 0x18207C920
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x207CD60 Offset: 0x207BF60 VA: 0x18207CD60
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x207C530 Offset: 0x207B730 VA: 0x18207C530
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0x207C700 Offset: 0x207B900 VA: 0x18207C700
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0x207C2F0 Offset: 0x207B4F0 VA: 0x18207C2F0
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal sealed class BitSet // TypeDefIndex: 12221
{
	// Fields
	private int count; // 0x10
	private uint[] bits; // 0x18

	// Properties
	public int Count { get; }
	public bool Item { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x207DE90 Offset: 0x207D090 VA: 0x18207DE90
	public void .ctor(int count) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_Count() { }

	// RVA: 0x207DBA0 Offset: 0x207CDA0 VA: 0x18207DBA0
	public bool get_Item(int index) { }

	// RVA: 0x207D800 Offset: 0x207CA00 VA: 0x18207D800
	public void Clear() { }

	// RVA: 0x207DE10 Offset: 0x207D010 VA: 0x18207DE10
	public void Set(int index) { }

	// RVA: 0x207DBA0 Offset: 0x207CDA0 VA: 0x18207DBA0
	public bool Get(int index) { }

	// RVA: 0x207DCD0 Offset: 0x207CED0 VA: 0x18207DCD0
	public int NextSet(int startFrom) { }

	// RVA: 0x207D720 Offset: 0x207C920 VA: 0x18207D720
	public void And(BitSet other) { }

	// RVA: 0x207DD70 Offset: 0x207CF70 VA: 0x18207DD70
	public void Or(BitSet other) { }

	// RVA: 0x207DB60 Offset: 0x207CD60 VA: 0x18207DB60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x207D9D0 Offset: 0x207CBD0 VA: 0x18207D9D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x207D860 Offset: 0x207CA60 VA: 0x18207D860
	public BitSet Clone() { }

	// RVA: 0x207DEF0 Offset: 0x207D0F0 VA: 0x18207DEF0
	public bool get_IsEmpty() { }

	// RVA: 0x207DBF0 Offset: 0x207CDF0 VA: 0x18207DBF0
	public bool Intersects(BitSet other) { }

	// RVA: 0x207DE80 Offset: 0x207D080 VA: 0x18207DE80
	private int Subscript(int bitIndex) { }

	// RVA: 0x207D940 Offset: 0x207CB40 VA: 0x18207D940
	private void EnsureLength(int nRequiredLength) { }
}

// Namespace: System.Xml.Schema
internal class ChameleonKey // TypeDefIndex: 12222
{
	// Fields
	internal string targetNS; // 0x10
	internal Uri chameleonLocation; // 0x18
	internal XmlSchema originalSchema; // 0x20
	private int hashCode; // 0x28

	// Methods

	// RVA: 0x207E1B0 Offset: 0x207D3B0 VA: 0x18207E1B0
	public void .ctor(string ns, XmlSchema originalSchema) { }

	// RVA: 0x207E110 Offset: 0x207D310 VA: 0x18207E110 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x207E010 Offset: 0x207D210 VA: 0x18207E010 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: 
public enum CompiledIdentityConstraint.ConstraintRole // TypeDefIndex: 12223
{
	// Fields
	public int value__; // 0x0
	public const CompiledIdentityConstraint.ConstraintRole Unique = 0;
	public const CompiledIdentityConstraint.ConstraintRole Key = 1;
	public const CompiledIdentityConstraint.ConstraintRole Keyref = 2;
}

// Namespace: System.Xml.Schema
internal class CompiledIdentityConstraint // TypeDefIndex: 12224
{
	// Fields
	internal XmlQualifiedName name; // 0x10
	private CompiledIdentityConstraint.ConstraintRole role; // 0x18
	private Asttree selector; // 0x20
	private Asttree[] fields; // 0x28
	internal XmlQualifiedName refer; // 0x30
	public static readonly CompiledIdentityConstraint Empty; // 0x0

	// Properties
	public CompiledIdentityConstraint.ConstraintRole Role { get; }
	public Asttree Selector { get; }
	public Asttree[] Fields { get; }

	// Methods

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public CompiledIdentityConstraint.ConstraintRole get_Role() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Asttree get_Selector() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Asttree[] get_Fields() { }

	// RVA: 0x20805B0 Offset: 0x207F7B0 VA: 0x1820805B0
	private void .ctor() { }

	// RVA: 0x2080630 Offset: 0x207F830 VA: 0x182080630
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0x20804F0 Offset: 0x207F6F0 VA: 0x1820804F0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class ConstraintStruct // TypeDefIndex: 12225
{
	// Fields
	internal CompiledIdentityConstraint constraint; // 0x10
	internal SelectorActiveAxis axisSelector; // 0x18
	internal ArrayList axisFields; // 0x20
	internal Hashtable qualifiedTable; // 0x28
	internal Hashtable keyrefTable; // 0x30
	private int tableDim; // 0x38

	// Properties
	internal int TableDim { get; }

	// Methods

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	internal int get_TableDim() { }

	// RVA: 0x2080AE0 Offset: 0x207FCE0 VA: 0x182080AE0
	internal void .ctor(CompiledIdentityConstraint constraint) { }
}

// Namespace: System.Xml.Schema
internal class LocatedActiveAxis : ActiveAxis // TypeDefIndex: 12226
{
	// Fields
	private int column; // 0x28
	internal bool isMatched; // 0x2C
	internal KeySequence Ks; // 0x30

	// Properties
	internal int Column { get; }

	// Methods

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	internal int get_Column() { }

	// RVA: 0x2083FC0 Offset: 0x20831C0 VA: 0x182083FC0
	internal void .ctor(Asttree astfield, KeySequence ks, int column) { }

	// RVA: 0x2083FB0 Offset: 0x20831B0 VA: 0x182083FB0
	internal void Reactivate(KeySequence ks) { }
}

// Namespace: System.Xml.Schema
internal class SelectorActiveAxis : ActiveAxis // TypeDefIndex: 12227
{
	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Properties
	public int lastDepth { get; }

	// Methods

	// RVA: 0x2087F40 Offset: 0x2087140 VA: 0x182087F40
	public int get_lastDepth() { }

	// RVA: 0x2087EC0 Offset: 0x20870C0 VA: 0x182087EC0
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0x20878C0 Offset: 0x2086AC0 VA: 0x1820878C0 Slot: 4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0x2087B00 Offset: 0x2086D00 VA: 0x182087B00
	public int PushKS(int errline, int errcol) { }

	// RVA: 0x2087A00 Offset: 0x2086C00 VA: 0x182087A00
	public KeySequence PopKS() { }
}

// Namespace: System.Xml.Schema
internal class KSStruct // TypeDefIndex: 12228
{
	// Fields
	public int depth; // 0x10
	public KeySequence ks; // 0x18
	public LocatedActiveAxis[] fields; // 0x20

	// Methods

	// RVA: 0x2082660 Offset: 0x2081860 VA: 0x182082660
	public void .ctor(KeySequence ks, int dim) { }
}

// Namespace: 
private class TypedObject.DecimalStruct // TypeDefIndex: 12229
{
	// Fields
	private bool isDecimal; // 0x10
	private Decimal[] dvalue; // 0x18

	// Properties
	public bool IsDecimal { get; set; }
	public Decimal[] Dvalue { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsDecimal() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_IsDecimal(bool value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Decimal[] get_Dvalue() { }

	// RVA: 0x20811E0 Offset: 0x20803E0 VA: 0x1820811E0
	public void .ctor() { }

	// RVA: 0x2081180 Offset: 0x2080380 VA: 0x182081180
	public void .ctor(int dim) { }
}

// Namespace: System.Xml.Schema
internal class TypedObject // TypeDefIndex: 12230
{
	// Fields
	private TypedObject.DecimalStruct dstruct; // 0x10
	private object ovalue; // 0x18
	private string svalue; // 0x20
	private XmlSchemaDatatype xsdtype; // 0x28
	private int dim; // 0x30
	private bool isList; // 0x34

	// Properties
	public int Dim { get; }
	public bool IsList { get; }
	public bool IsDecimal { get; }
	public Decimal[] Dvalue { get; }
	public object Value { get; }
	public XmlSchemaDatatype Type { get; }

	// Methods

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int get_Dim() { }

	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	public bool get_IsList() { }

	// RVA: 0x160F380 Offset: 0x160E580 VA: 0x18160F380
	public bool get_IsDecimal() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Decimal[] get_Dvalue() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public object get_Value() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0x208A770 Offset: 0x2089970 VA: 0x18208A770
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 3
	public override string ToString() { }

	// RVA: 0x208A410 Offset: 0x2089610 VA: 0x18208A410
	public void SetDecimal() { }

	// RVA: 0x208A2F0 Offset: 0x20894F0 VA: 0x18208A2F0
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0x2089F50 Offset: 0x2089150 VA: 0x182089F50
	public bool Equals(TypedObject other) { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal class KeySequence // TypeDefIndex: 12231
{
	// Fields
	private TypedObject[] ks; // 0x10
	private int dim; // 0x18
	private int hashcode; // 0x1C
	private int posline; // 0x20
	private int poscol; // 0x24

	// Properties
	public int PosLine { get; }
	public int PosCol { get; }
	public object Item { get; set; }

	// Methods

	// RVA: 0x2082DB0 Offset: 0x2081FB0 VA: 0x182082DB0
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_PosLine() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_PosCol() { }

	// RVA: 0x74A700 Offset: 0x749900 VA: 0x18074A700
	public object get_Item(int index) { }

	// RVA: 0x2082E30 Offset: 0x2082030 VA: 0x182082E30
	public void set_Item(int index, object value) { }

	// RVA: 0x2082BE0 Offset: 0x2081DE0 VA: 0x182082BE0
	internal bool IsQualified() { }

	// RVA: 0x20827F0 Offset: 0x20819F0 VA: 0x1820827F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20826D0 Offset: 0x20818D0 VA: 0x1820826D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2082C50 Offset: 0x2081E50 VA: 0x182082C50 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml.Schema
internal class UpaException : Exception // TypeDefIndex: 12232
{
	// Fields
	private object particle1; // 0x90
	private object particle2; // 0x98

	// Properties
	public object Particle1 { get; }
	public object Particle2 { get; }

	// Methods

	// RVA: 0x208A950 Offset: 0x2089B50 VA: 0x18208A950
	public void .ctor(object particle1, object particle2) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public object get_Particle1() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public object get_Particle2() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal class SymbolsDictionary // TypeDefIndex: 12233
{
	// Fields
	private int last; // 0x10
	private Hashtable names; // 0x18
	private Hashtable wildcards; // 0x20
	private ArrayList particles; // 0x28
	private object particleLast; // 0x30
	private bool isUpaEnforced; // 0x38

	// Properties
	public int Count { get; }
	public bool IsUpaEnforced { get; set; }
	public int Item { get; }

	// Methods

	// RVA: 0x2089DC0 Offset: 0x2088FC0 VA: 0x182089DC0
	public void .ctor() { }

	// RVA: 0x2089E50 Offset: 0x2089050 VA: 0x182089E50
	public int get_Count() { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_IsUpaEnforced() { }

	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_IsUpaEnforced(bool value) { }

	// RVA: 0x2088D60 Offset: 0x2087F60 VA: 0x182088D60
	public int AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x2088EB0 Offset: 0x20880B0 VA: 0x182088EB0
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	// RVA: 0x2089130 Offset: 0x2088330 VA: 0x182089130
	private void AddWildcard(string wildcard, object particle) { }

	// RVA: 0x20892E0 Offset: 0x20884E0 VA: 0x1820892E0
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0x2089E60 Offset: 0x2089060 VA: 0x182089E60
	public int get_Item(XmlQualifiedName name) { }

	// RVA: 0x20892A0 Offset: 0x20884A0 VA: 0x1820892A0
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x2089950 Offset: 0x2088B50 VA: 0x182089950
	public object GetParticle(int symbol) { }

	// RVA: 0x2089990 Offset: 0x2088B90 VA: 0x182089990
	public string NameOf(int symbol) { }
}

// Namespace: System.Xml.Schema
internal struct Position // TypeDefIndex: 12234
{
	// Fields
	public int symbol; // 0x0
	public object particle; // 0x8

	// Methods

	// RVA: 0xBB0D00 Offset: 0xBAFF00 VA: 0x180BB0D00
	public void .ctor(int symbol, object particle) { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal class Positions // TypeDefIndex: 12235
{
	// Fields
	private ArrayList positions; // 0x10

	// Properties
	public Position Item { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x20876F0 Offset: 0x20868F0 VA: 0x1820876F0
	public int Add(int symbol, object particle) { }

	// RVA: 0x20877F0 Offset: 0x20869F0 VA: 0x1820877F0
	public Position get_Item(int pos) { }

	// RVA: 0x1719620 Offset: 0x1718820 VA: 0x181719620
	public int get_Count() { }

	// RVA: 0x2087790 Offset: 0x2086990 VA: 0x182087790
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class SyntaxTreeNode // TypeDefIndex: 12236
{
	// Properties
	public abstract bool IsNullable { get; }
	public virtual bool IsRangeNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsNullable();

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public virtual bool get_IsRangeNode() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class LeafNode : SyntaxTreeNode // TypeDefIndex: 12237
{
	// Fields
	private int pos; // 0x10

	// Properties
	public int Pos { get; set; }
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int pos) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_Pos() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Pos(int value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x2082F70 Offset: 0x2082170 VA: 0x182082F70 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	public override bool get_IsNullable() { }
}

// Namespace: System.Xml.Schema
internal class NamespaceListNode : SyntaxTreeNode // TypeDefIndex: 12238
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0x20843A0 Offset: 0x20835A0 VA: 0x1820843A0 Slot: 8
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0x2084040 Offset: 0x2083240 VA: 0x182084040 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x2084000 Offset: 0x2083200 VA: 0x182084000 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x20843D0 Offset: 0x20835D0 VA: 0x1820843D0 Slot: 6
	public override bool get_IsNullable() { }
}

// Namespace: System.Xml.Schema
internal abstract class InteriorNode : SyntaxTreeNode // TypeDefIndex: 12239
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Properties
	public SyntaxTreeNode LeftChild { get; set; }
	public SyntaxTreeNode RightChild { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0x20823A0 Offset: 0x20815A0 VA: 0x1820823A0
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x20825E0 Offset: 0x20817E0 VA: 0x1820825E0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
private struct SequenceNode.SequenceConstructPosContext // TypeDefIndex: 12240
{
	// Fields
	public SequenceNode this_; // 0x0
	public BitSet firstpos; // 0x8
	public BitSet lastpos; // 0x10
	public BitSet lastposLeft; // 0x18
	public BitSet firstposRight; // 0x20

	// Methods

	// RVA: 0x2088050 Offset: 0x2087250 VA: 0x182088050
	public void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }
}

// Namespace: System.Xml.Schema
internal sealed class SequenceNode : InteriorNode // TypeDefIndex: 12241
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x2088070 Offset: 0x2087270 VA: 0x182088070 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x2088790 Offset: 0x2087990 VA: 0x182088790 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x207E660 Offset: 0x207D860 VA: 0x18207E660 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class ChoiceNode : InteriorNode // TypeDefIndex: 12242
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x207E220 Offset: 0x207D420 VA: 0x18207E220
	private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x207E390 Offset: 0x207D590 VA: 0x18207E390 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x207E670 Offset: 0x207D870 VA: 0x18207E670 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x207E660 Offset: 0x207D860 VA: 0x18207E660 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class PlusNode : InteriorNode // TypeDefIndex: 12243
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x2087530 Offset: 0x2086730 VA: 0x182087530 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class QmarkNode : InteriorNode // TypeDefIndex: 12244
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x2087890 Offset: 0x2086A90 VA: 0x182087890 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class StarNode : InteriorNode // TypeDefIndex: 12245
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x2087530 Offset: 0x2086730 VA: 0x182087530 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class LeafRangeNode : LeafNode // TypeDefIndex: 12246
{
	// Fields
	private Decimal min; // 0x18
	private Decimal max; // 0x28
	private BitSet nextIteration; // 0x38

	// Properties
	public Decimal Max { get; }
	public Decimal Min { get; }
	public BitSet NextIteration { get; set; }
	public override bool IsRangeNode { get; }

	// Methods

	// RVA: 0x2083090 Offset: 0x2082290 VA: 0x182083090
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0x20830E0 Offset: 0x20822E0 VA: 0x1820830E0
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80
	public Decimal get_Max() { }

	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public Decimal get_Min() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public BitSet get_NextIteration() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public override bool get_IsRangeNode() { }

	// RVA: 0x2083040 Offset: 0x2082240 VA: 0x182083040 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }
}

// Namespace: System.Xml.Schema
internal class ContentValidator // TypeDefIndex: 12247
{
	// Fields
	private XmlSchemaContentType contentType; // 0x10
	private bool isOpen; // 0x14
	private bool isEmptiable; // 0x15
	public static readonly ContentValidator Empty; // 0x0
	public static readonly ContentValidator TextOnly; // 0x8
	public static readonly ContentValidator Mixed; // 0x10
	public static readonly ContentValidator Any; // 0x18

	// Properties
	public XmlSchemaContentType ContentType { get; }
	public bool PreserveWhitespace { get; }
	public virtual bool IsEmptiable { get; }
	public bool IsOpen { get; set; }

	// Methods

	// RVA: 0x20810C0 Offset: 0x20802C0 VA: 0x1820810C0
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x20810F0 Offset: 0x20802F0 VA: 0x1820810F0
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x2081160 Offset: 0x2080360 VA: 0x182081160
	public bool get_PreserveWhitespace() { }

	// RVA: 0x41AC40 Offset: 0x419E40 VA: 0x18041AC40 Slot: 4
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x2081140 Offset: 0x2080340 VA: 0x182081140
	public bool get_IsOpen() { }

	// RVA: 0x41AC60 Offset: 0x419E60 VA: 0x18041AC60
	public void set_IsOpen(bool value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x2080F80 Offset: 0x2080180 VA: 0x182080F80 Slot: 6
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x2080F00 Offset: 0x2080100 VA: 0x182080F00
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x2080C20 Offset: 0x207FE20 VA: 0x182080C20
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x2080FB0 Offset: 0x20801B0 VA: 0x182080FB0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class ParticleContentValidator : ContentValidator // TypeDefIndex: 12248
{
	// Fields
	private SymbolsDictionary symbols; // 0x18
	private Positions positions; // 0x20
	private Stack stack; // 0x28
	private SyntaxTreeNode contentNode; // 0x30
	private bool isPartial; // 0x38
	private int minMaxNodesCount; // 0x3C
	private bool enableUpaCheck; // 0x40

	// Methods

	// RVA: 0x2087460 Offset: 0x2086660 VA: 0x182087460
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x20874C0 Offset: 0x20866C0 VA: 0x1820874C0
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0x2087260 Offset: 0x2086460 VA: 0x182087260 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x2087420 Offset: 0x2086620 VA: 0x182087420 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x2085E00 Offset: 0x2085000 VA: 0x182085E00 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x20872D0 Offset: 0x20864D0 VA: 0x1820872D0
	public void Start() { }

	// RVA: 0x20872A0 Offset: 0x20864A0 VA: 0x1820872A0
	public void OpenGroup() { }

	// RVA: 0x2085AA0 Offset: 0x2084CA0 VA: 0x182085AA0
	public void CloseGroup() { }

	// RVA: 0x2085E40 Offset: 0x2085040 VA: 0x182085E40
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x2084700 Offset: 0x2083900 VA: 0x182084700
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x20847B0 Offset: 0x20839B0 VA: 0x1820847B0
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0x2084520 Offset: 0x2083720 VA: 0x182084520
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0x2084410 Offset: 0x2083610 VA: 0x182084410
	public void AddChoice() { }

	// RVA: 0x2084920 Offset: 0x2083B20 VA: 0x182084920
	public void AddSequence() { }

	// RVA: 0x2084A30 Offset: 0x2083C30 VA: 0x182084A30
	public void AddStar() { }

	// RVA: 0x2084860 Offset: 0x2083A60 VA: 0x182084860
	public void AddPlus() { }

	// RVA: 0x20848C0 Offset: 0x2083AC0 VA: 0x1820848C0
	public void AddQMark() { }

	// RVA: 0x2084620 Offset: 0x2083820 VA: 0x182084620
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0x2085C50 Offset: 0x2084E50 VA: 0x182085C50
	private void Closure(InteriorNode node) { }

	// RVA: 0x2085E80 Offset: 0x2085080 VA: 0x182085E80
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0x2085140 Offset: 0x2084340 VA: 0x182085140
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0x2085550 Offset: 0x2084750 VA: 0x182085550
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0x2086E40 Offset: 0x2086040 VA: 0x182086E40
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0x20859E0 Offset: 0x2084BE0 VA: 0x1820859E0
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0x2085760 Offset: 0x2084960 VA: 0x182085760
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0x2084A90 Offset: 0x2083C90 VA: 0x182084A90
	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }
}

// Namespace: System.Xml.Schema
internal sealed class DfaContentValidator : ContentValidator // TypeDefIndex: 12249
{
	// Fields
	private int[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x20817E0 Offset: 0x20809E0 VA: 0x1820817E0
	internal void .ctor(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x2081570 Offset: 0x2080770 VA: 0x182081570 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x20815D0 Offset: 0x20807D0 VA: 0x1820815D0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x2081230 Offset: 0x2080430 VA: 0x182081230 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x2081250 Offset: 0x2080450 VA: 0x182081250 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x2081420 Offset: 0x2080620 VA: 0x182081420 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
internal sealed class NfaContentValidator : ContentValidator // TypeDefIndex: 12250
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private int endMarkerPos; // 0x38

	// Methods

	// RVA: 0x20AF950 Offset: 0x20AEB50 VA: 0x1820AF950
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x20AF6C0 Offset: 0x20AE8C0 VA: 0x1820AF6C0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x20AF790 Offset: 0x20AE990 VA: 0x1820AF790 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x20AF2F0 Offset: 0x20AE4F0 VA: 0x1820AF2F0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x20AF340 Offset: 0x20AE540 VA: 0x1820AF340 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x20AF520 Offset: 0x20AE720 VA: 0x1820AF520 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
internal struct RangePositionInfo // TypeDefIndex: 12251
{
	// Fields
	public BitSet curpos; // 0x0
	public Decimal[] rangeCounters; // 0x8
}

// Namespace: System.Xml.Schema
internal sealed class RangeContentValidator : ContentValidator // TypeDefIndex: 12252
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private BitSet positionsWithRangeTerminals; // 0x28
	private SymbolsDictionary symbols; // 0x30
	private Positions positions; // 0x38
	private int minMaxNodesCount; // 0x40
	private int endMarkerPos; // 0x44

	// Methods

	// RVA: 0x20B20C0 Offset: 0x20B12C0 VA: 0x1820B20C0
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0x20B15C0 Offset: 0x20B07C0 VA: 0x1820B15C0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x20B1780 Offset: 0x20B0980 VA: 0x1820B1780 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x20B10A0 Offset: 0x20B02A0 VA: 0x1820B10A0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x20B10C0 Offset: 0x20B02C0 VA: 0x1820B10C0 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x20B1380 Offset: 0x20B0580 VA: 0x1820B1380 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
internal sealed class AllElementsContentValidator : ContentValidator // TypeDefIndex: 12253
{
	// Fields
	private Hashtable elements; // 0x18
	private object[] particles; // 0x20
	private BitSet isRequired; // 0x28
	private int countRequired; // 0x30

	// Properties
	public override bool IsEmptiable { get; }

	// Methods

	// RVA: 0x2094580 Offset: 0x2093780 VA: 0x182094580
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0x2093A80 Offset: 0x2092C80 VA: 0x182093A80
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0x2094680 Offset: 0x2093880 VA: 0x182094680 Slot: 4
	public override bool get_IsEmptiable() { }

	// RVA: 0x2094390 Offset: 0x2093590 VA: 0x182094390 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x2094430 Offset: 0x2093630 VA: 0x182094430 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x2093BE0 Offset: 0x2092DE0 VA: 0x182093BE0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x2093C30 Offset: 0x2092E30 VA: 0x182093C30 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x2093F90 Offset: 0x2093190 VA: 0x182093F90 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaDatatypeVariety // TypeDefIndex: 12254
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaDatatypeVariety Atomic = 0;
	public const XmlSchemaDatatypeVariety List = 1;
	public const XmlSchemaDatatypeVariety Union = 2;
}

// Namespace: System.Xml.Schema
internal class XsdSimpleValue // TypeDefIndex: 12255
{
	// Fields
	private XmlSchemaSimpleType xmlType; // 0x10
	private object typedValue; // 0x18

	// Properties
	public XmlSchemaSimpleType XmlType { get; }
	public object TypedValue { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(XmlSchemaSimpleType st, object value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public XmlSchemaSimpleType get_XmlType() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public object get_TypedValue() { }
}

// Namespace: System.Xml.Schema
[Flags]
internal enum RestrictionFlags // TypeDefIndex: 12256
{
	// Fields
	public int value__; // 0x0
	public const RestrictionFlags Length = 1;
	public const RestrictionFlags MinLength = 2;
	public const RestrictionFlags MaxLength = 4;
	public const RestrictionFlags Pattern = 8;
	public const RestrictionFlags Enumeration = 16;
	public const RestrictionFlags WhiteSpace = 32;
	public const RestrictionFlags MaxInclusive = 64;
	public const RestrictionFlags MaxExclusive = 128;
	public const RestrictionFlags MinInclusive = 256;
	public const RestrictionFlags MinExclusive = 512;
	public const RestrictionFlags TotalDigits = 1024;
	public const RestrictionFlags FractionDigits = 2048;
}

// Namespace: System.Xml.Schema
internal enum XmlSchemaWhiteSpace // TypeDefIndex: 12257
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaWhiteSpace Preserve = 0;
	public const XmlSchemaWhiteSpace Replace = 1;
	public const XmlSchemaWhiteSpace Collapse = 2;
}

// Namespace: System.Xml.Schema
internal class RestrictionFacets // TypeDefIndex: 12258
{
	// Fields
	internal int Length; // 0x10
	internal int MinLength; // 0x14
	internal int MaxLength; // 0x18
	internal ArrayList Patterns; // 0x20
	internal ArrayList Enumeration; // 0x28
	internal XmlSchemaWhiteSpace WhiteSpace; // 0x30
	internal object MaxInclusive; // 0x38
	internal object MaxExclusive; // 0x40
	internal object MinInclusive; // 0x48
	internal object MinExclusive; // 0x50
	internal int TotalDigits; // 0x58
	internal int FractionDigits; // 0x5C
	internal RestrictionFlags Flags; // 0x60
	internal RestrictionFlags FixedFlags; // 0x64

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class DatatypeImplementation.SchemaDatatypeMap : IComparable // TypeDefIndex: 12259
{
	// Fields
	private string name; // 0x10
	private DatatypeImplementation type; // 0x18
	private int parentIndex; // 0x20

	// Properties
	public string Name { get; }
	public int ParentIndex { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0xB18200 Offset: 0xB17400 VA: 0x180B18200
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x408300 Offset: 0x407500 VA: 0x180408300
	public static DatatypeImplementation op_Explicit(DatatypeImplementation.SchemaDatatypeMap sdm) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_ParentIndex() { }

	// RVA: 0x20B2180 Offset: 0x20B1380 VA: 0x1820B2180 Slot: 4
	public int CompareTo(object obj) { }
}

// Namespace: System.Xml.Schema
internal abstract class DatatypeImplementation : XmlSchemaDatatype // TypeDefIndex: 12260
{
	// Fields
	private XmlSchemaDatatypeVariety variety; // 0x10
	private RestrictionFacets restriction; // 0x18
	private DatatypeImplementation baseType; // 0x20
	private XmlValueConverter valueConverter; // 0x28
	private XmlSchemaType parentSchemaType; // 0x30
	private static Hashtable builtinTypes; // 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; // 0x8
	private static XmlSchemaSimpleType anySimpleType; // 0x10
	private static XmlSchemaSimpleType anyAtomicType; // 0x18
	private static XmlSchemaSimpleType untypedAtomicType; // 0x20
	private static XmlSchemaSimpleType yearMonthDurationType; // 0x28
	private static XmlSchemaSimpleType dayTimeDurationType; // 0x30
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; // 0x38
	private static XmlSchemaSimpleType tokenTypeV1Compat; // 0x40
	internal static XmlQualifiedName QnAnySimpleType; // 0x48
	internal static XmlQualifiedName QnAnyType; // 0x50
	internal static FacetsChecker stringFacetsChecker; // 0x58
	internal static FacetsChecker miscFacetsChecker; // 0x60
	internal static FacetsChecker numeric2FacetsChecker; // 0x68
	internal static FacetsChecker binaryFacetsChecker; // 0x70
	internal static FacetsChecker dateTimeFacetsChecker; // 0x78
	internal static FacetsChecker durationFacetsChecker; // 0x80
	internal static FacetsChecker listFacetsChecker; // 0x88
	internal static FacetsChecker qnameFacetsChecker; // 0x90
	internal static FacetsChecker unionFacetsChecker; // 0x98
	private static readonly DatatypeImplementation c_anySimpleType; // 0xA0
	private static readonly DatatypeImplementation c_anyURI; // 0xA8
	private static readonly DatatypeImplementation c_base64Binary; // 0xB0
	private static readonly DatatypeImplementation c_boolean; // 0xB8
	private static readonly DatatypeImplementation c_byte; // 0xC0
	private static readonly DatatypeImplementation c_char; // 0xC8
	private static readonly DatatypeImplementation c_date; // 0xD0
	private static readonly DatatypeImplementation c_dateTime; // 0xD8
	private static readonly DatatypeImplementation c_dateTimeNoTz; // 0xE0
	private static readonly DatatypeImplementation c_dateTimeTz; // 0xE8
	private static readonly DatatypeImplementation c_day; // 0xF0
	private static readonly DatatypeImplementation c_decimal; // 0xF8
	private static readonly DatatypeImplementation c_double; // 0x100
	private static readonly DatatypeImplementation c_doubleXdr; // 0x108
	private static readonly DatatypeImplementation c_duration; // 0x110
	private static readonly DatatypeImplementation c_ENTITY; // 0x118
	private static readonly DatatypeImplementation c_ENTITIES; // 0x120
	private static readonly DatatypeImplementation c_ENUMERATION; // 0x128
	private static readonly DatatypeImplementation c_fixed; // 0x130
	private static readonly DatatypeImplementation c_float; // 0x138
	private static readonly DatatypeImplementation c_floatXdr; // 0x140
	private static readonly DatatypeImplementation c_hexBinary; // 0x148
	private static readonly DatatypeImplementation c_ID; // 0x150
	private static readonly DatatypeImplementation c_IDREF; // 0x158
	private static readonly DatatypeImplementation c_IDREFS; // 0x160
	private static readonly DatatypeImplementation c_int; // 0x168
	private static readonly DatatypeImplementation c_integer; // 0x170
	private static readonly DatatypeImplementation c_language; // 0x178
	private static readonly DatatypeImplementation c_long; // 0x180
	private static readonly DatatypeImplementation c_month; // 0x188
	private static readonly DatatypeImplementation c_monthDay; // 0x190
	private static readonly DatatypeImplementation c_Name; // 0x198
	private static readonly DatatypeImplementation c_NCName; // 0x1A0
	private static readonly DatatypeImplementation c_negativeInteger; // 0x1A8
	private static readonly DatatypeImplementation c_NMTOKEN; // 0x1B0
	private static readonly DatatypeImplementation c_NMTOKENS; // 0x1B8
	private static readonly DatatypeImplementation c_nonNegativeInteger; // 0x1C0
	private static readonly DatatypeImplementation c_nonPositiveInteger; // 0x1C8
	private static readonly DatatypeImplementation c_normalizedString; // 0x1D0
	private static readonly DatatypeImplementation c_NOTATION; // 0x1D8
	private static readonly DatatypeImplementation c_positiveInteger; // 0x1E0
	private static readonly DatatypeImplementation c_QName; // 0x1E8
	private static readonly DatatypeImplementation c_QNameXdr; // 0x1F0
	private static readonly DatatypeImplementation c_short; // 0x1F8
	private static readonly DatatypeImplementation c_string; // 0x200
	private static readonly DatatypeImplementation c_time; // 0x208
	private static readonly DatatypeImplementation c_timeNoTz; // 0x210
	private static readonly DatatypeImplementation c_timeTz; // 0x218
	private static readonly DatatypeImplementation c_token; // 0x220
	private static readonly DatatypeImplementation c_unsignedByte; // 0x228
	private static readonly DatatypeImplementation c_unsignedInt; // 0x230
	private static readonly DatatypeImplementation c_unsignedLong; // 0x238
	private static readonly DatatypeImplementation c_unsignedShort; // 0x240
	private static readonly DatatypeImplementation c_uuid; // 0x248
	private static readonly DatatypeImplementation c_year; // 0x250
	private static readonly DatatypeImplementation c_yearMonth; // 0x258
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; // 0x260
	internal static readonly DatatypeImplementation c_tokenV1Compat; // 0x268
	private static readonly DatatypeImplementation c_anyAtomicType; // 0x270
	private static readonly DatatypeImplementation c_dayTimeDuration; // 0x278
	private static readonly DatatypeImplementation c_untypedAtomicType; // 0x280
	private static readonly DatatypeImplementation c_yearMonthDuration; // 0x288
	private static readonly DatatypeImplementation[] c_tokenizedTypes; // 0x290
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; // 0x298
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes; // 0x2A0
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes; // 0x2A8

	// Properties
	internal static XmlSchemaSimpleType AnySimpleType { get; }
	internal static XmlSchemaSimpleType UntypedAtomicType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override XmlValueConverter ValueConverter { get; }
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	public override XmlSchemaDatatypeVariety Variety { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFacets Restriction { get; }
	internal override bool HasLexicalFacets { get; }
	internal override bool HasValueFacets { get; }
	protected DatatypeImplementation Base { get; }
	internal abstract Type ListValueType { get; }
	internal abstract RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x2096F90 Offset: 0x2096190 VA: 0x182096F90
	private static void .cctor() { }

	// RVA: 0x209BFB0 Offset: 0x209B1B0 VA: 0x18209BFB0
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x209C090 Offset: 0x209B290 VA: 0x18209C090
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x2095BB0 Offset: 0x2094DB0 VA: 0x182095BB0
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x2095B30 Offset: 0x2094D30 VA: 0x182095B30
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x2095A60 Offset: 0x2094C60 VA: 0x182095A60
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x2095990 Offset: 0x2094B90 VA: 0x182095990
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x2096B70 Offset: 0x2095D70 VA: 0x182096B70
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x2095750 Offset: 0x2094950 VA: 0x182095750
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x2094730 Offset: 0x2093930 VA: 0x182094730
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x2095FC0 Offset: 0x20951C0 VA: 0x182095FC0
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x2096030 Offset: 0x2095230 VA: 0x182096030
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x2095C80 Offset: 0x2094E80 VA: 0x182095C80
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x2096110 Offset: 0x2095310 VA: 0x182096110
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x2095C30 Offset: 0x2094E30 VA: 0x182095C30
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x2095E60 Offset: 0x2095060 VA: 0x182095E60
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x2095520 Offset: 0x2094720 VA: 0x182095520 Slot: 20
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x20951D0 Offset: 0x20943D0 VA: 0x1820951D0 Slot: 21
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x20951E0 Offset: 0x20943E0 VA: 0x1820951E0
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x2095640 Offset: 0x2094840 VA: 0x182095640
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x2096470 Offset: 0x2095670 VA: 0x182096470 Slot: 9
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x2096770 Offset: 0x2095970 VA: 0x182096770 Slot: 23
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x2096370 Offset: 0x2095570 VA: 0x182096370 Slot: 24
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 25
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x209C000 Offset: 0x209B200 VA: 0x18209C000 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x209C0E0 Offset: 0x209B2E0 VA: 0x18209C0E0 Slot: 12
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0xAA0160 Offset: 0xA9F360 VA: 0x180AA0160 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x209C120 Offset: 0x209B320 VA: 0x18209C120 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 7
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 13
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x209C050 Offset: 0x209B250 VA: 0x18209C050 Slot: 10
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x209C070 Offset: 0x209B270 VA: 0x18209C070 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	protected DatatypeImplementation get_Base() { }

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract Type get_ListValueType();

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract RestrictionFlags get_ValidRestrictionFlags();

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x2096940 Offset: 0x2095B40 VA: 0x182096940 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x20967A0 Offset: 0x20959A0 VA: 0x1820967A0 Slot: 15
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x2096C40 Offset: 0x2095E40 VA: 0x182096C40 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x20962F0 Offset: 0x20954F0 VA: 0x1820962F0
	internal string GetTypeName() { }

	// RVA: 0x20946A0 Offset: 0x20938A0 VA: 0x1820946A0
	protected int Compare(byte[] value1, byte[] value2) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_List : Datatype_anySimpleType // TypeDefIndex: 12261
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Properties
	public override Type ValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override Type ListValueType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal DatatypeImplementation ItemType { get; }

	// Methods

	// RVA: 0x209C4B0 Offset: 0x209B6B0 VA: 0x18209C4B0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x209D2F0 Offset: 0x209C4F0 VA: 0x18209D2F0
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x209C1A0 Offset: 0x209B3A0 VA: 0x18209C1A0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x209D490 Offset: 0x209C690 VA: 0x18209D490 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x209D420 Offset: 0x209C620 VA: 0x18209D420 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x209D3F0 Offset: 0x209C5F0 VA: 0x18209D3F0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x209D390 Offset: 0x209C590 VA: 0x18209D390 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x209D450 Offset: 0x209C650 VA: 0x18209D450 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x209D480 Offset: 0x209C680 VA: 0x18209D480 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal DatatypeImplementation get_ItemType() { }

	// RVA: 0x209C850 Offset: 0x209BA50 VA: 0x18209C850 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x209CE00 Offset: 0x209C000 VA: 0x18209CE00 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }
}

// Namespace: System.Xml.Schema
internal class Datatype_union : Datatype_anySimpleType // TypeDefIndex: 12262
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

	// Properties
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x20A4220 Offset: 0x20A3420 VA: 0x1820A4220 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x20A4AE0 Offset: 0x20A3CE0 VA: 0x1820A4AE0
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x20A4110 Offset: 0x20A3310 VA: 0x1820A4110 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A4C20 Offset: 0x20A3E20 VA: 0x1820A4C20 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A4B70 Offset: 0x20A3D70 VA: 0x1820A4B70 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x20A4BD0 Offset: 0x20A3DD0 VA: 0x1820A4BD0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0xAA00D0 Offset: 0xA9F2D0 VA: 0x180AA00D0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x20A4230 Offset: 0x20A3430 VA: 0x1820A4230
	internal bool HasAtomicMembers() { }

	// RVA: 0x20A42E0 Offset: 0x20A34E0 VA: 0x1820A42E0
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x20A4390 Offset: 0x20A3590 VA: 0x1820A4390 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A45E0 Offset: 0x20A37E0 VA: 0x1820A45E0 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A4A30 Offset: 0x20A3C30 VA: 0x1820A4A30
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anySimpleType : DatatypeImplementation // TypeDefIndex: 12263
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override Type ListValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x209E550 Offset: 0x209D750 VA: 0x18209E550 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x209E6C0 Offset: 0x209D8C0 VA: 0x18209E6C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x209E760 Offset: 0x209D960 VA: 0x18209E760 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x209E710 Offset: 0x209D910 VA: 0x18209E710 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0xAA0160 Offset: 0xA9F360 VA: 0x180AA0160 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x209E4E0 Offset: 0x209D6E0 VA: 0x18209E4E0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x209E5A0 Offset: 0x209D7A0 VA: 0x18209E5A0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x209E670 Offset: 0x209D870 VA: 0x18209E670
	public void .ctor() { }

	// RVA: 0x209E5C0 Offset: 0x209D7C0 VA: 0x18209E5C0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anyAtomicType : Datatype_anySimpleType // TypeDefIndex: 12264
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x209E410 Offset: 0x209D610 VA: 0x18209E410 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x209E460 Offset: 0x209D660 VA: 0x18209E460
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_untypedAtomicType : Datatype_anyAtomicType // TypeDefIndex: 12265
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x20A5F10 Offset: 0x20A5110 VA: 0x1820A5F10 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x179EBA0 Offset: 0x179DDA0 VA: 0x18179EBA0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A5F60 Offset: 0x20A5160 VA: 0x1820A5F60
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_string : Datatype_anySimpleType // TypeDefIndex: 12266
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x20A3E40 Offset: 0x20A3040 VA: 0x1820A3E40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x20A3FD0 Offset: 0x20A31D0 VA: 0x1820A3FD0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xAA0160 Offset: 0xA9F360 VA: 0x180AA0160 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x209D480 Offset: 0x209C680 VA: 0x18209D480 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x20A3E50 Offset: 0x20A3050 VA: 0x1820A3E50 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A3F50 Offset: 0x20A3150 VA: 0x1820A3F50
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_boolean : Datatype_anySimpleType // TypeDefIndex: 12267
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x209F250 Offset: 0x209E450 VA: 0x18209F250 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x209F4A0 Offset: 0x209E6A0 VA: 0x18209F4A0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x170C2E0 Offset: 0x170B4E0 VA: 0x18170C2E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x209F540 Offset: 0x209E740 VA: 0x18209F540 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x209F4F0 Offset: 0x209E6F0 VA: 0x18209F4F0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xAA01A0 Offset: 0xA9F3A0 VA: 0x180AA01A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x209F1C0 Offset: 0x209E3C0 VA: 0x18209F1C0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x209F260 Offset: 0x209E460 VA: 0x18209F260 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x209F420 Offset: 0x209E620 VA: 0x18209F420
	public void .ctor() { }

	// RVA: 0x209F370 Offset: 0x209E570 VA: 0x18209F370
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_float : Datatype_anySimpleType // TypeDefIndex: 12268
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x20A1110 Offset: 0x20A0310 VA: 0x1820A1110 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x20A2310 Offset: 0x20A1510 VA: 0x1820A2310 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x16EC490 Offset: 0x16EB690 VA: 0x1816EC490 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A23B0 Offset: 0x20A15B0 VA: 0x1820A23B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A2360 Offset: 0x20A1560 VA: 0x1820A2360 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x20A0510 Offset: 0x209F710 VA: 0x1820A0510 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x20A1FF0 Offset: 0x20A11F0 VA: 0x1820A1FF0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A2070 Offset: 0x20A1270 VA: 0x1820A2070 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A2290 Offset: 0x20A1490 VA: 0x1820A2290
	public void .ctor() { }

	// RVA: 0x20A21E0 Offset: 0x20A13E0 VA: 0x1820A21E0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_double : Datatype_anySimpleType // TypeDefIndex: 12269
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x20A1110 Offset: 0x20A0310 VA: 0x1820A1110 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x20A13C0 Offset: 0x20A05C0 VA: 0x1820A13C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x6F8DD0 Offset: 0x6F7FD0 VA: 0x1806F8DD0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A1460 Offset: 0x20A0660 VA: 0x1820A1460 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A1410 Offset: 0x20A0610 VA: 0x1820A1410 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x20A0510 Offset: 0x209F710 VA: 0x1820A0510 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x20A1090 Offset: 0x20A0290 VA: 0x1820A1090 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A1120 Offset: 0x20A0320 VA: 0x1820A1120 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A1340 Offset: 0x20A0540 VA: 0x1820A1340
	public void .ctor() { }

	// RVA: 0x20A1290 Offset: 0x20A0490 VA: 0x1820A1290
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_decimal : Datatype_anySimpleType // TypeDefIndex: 12270
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x20A0A10 Offset: 0x209FC10 VA: 0x1820A0A10 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x20A0D80 Offset: 0x209FF80 VA: 0x1820A0D80 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x16FB640 Offset: 0x16FA840 VA: 0x1816FB640 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A0E30 Offset: 0x20A0030 VA: 0x1820A0E30 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A0DD0 Offset: 0x209FFD0 VA: 0x1820A0DD0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x20A0E20 Offset: 0x20A0020 VA: 0x1820A0E20 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x20A0970 Offset: 0x209FB70 VA: 0x1820A0970 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A0A20 Offset: 0x209FC20 VA: 0x1820A0A20 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A0D00 Offset: 0x209FF00 VA: 0x1820A0D00
	public void .ctor() { }

	// RVA: 0x20A0BA0 Offset: 0x209FDA0 VA: 0x1820A0BA0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_duration : Datatype_anySimpleType // TypeDefIndex: 12271
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x209D5E0 Offset: 0x209C7E0 VA: 0x18209D5E0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x20A1880 Offset: 0x20A0A80 VA: 0x1820A1880 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x18A5990 Offset: 0x18A4B90 VA: 0x1818A5990 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A1930 Offset: 0x20A0B30 VA: 0x1820A1930 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A18E0 Offset: 0x20A0AE0 VA: 0x1820A18E0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x20A0510 Offset: 0x209F710 VA: 0x1820A0510 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x20A14B0 Offset: 0x20A06B0 VA: 0x1820A14B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A1550 Offset: 0x20A0750 VA: 0x1820A1550 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A1800 Offset: 0x20A0A00 VA: 0x1820A1800
	public void .ctor() { }

	// RVA: 0x20A1750 Offset: 0x20A0950 VA: 0x1820A1750
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonthDuration : Datatype_duration // TypeDefIndex: 12272
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x20A63E0 Offset: 0x20A55E0 VA: 0x1820A63E0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D12D30 Offset: 0x1D11F30 VA: 0x181D12D30 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A65F0 Offset: 0x20A57F0 VA: 0x1820A65F0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dayTimeDuration : Datatype_duration // TypeDefIndex: 12273
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x20A06B0 Offset: 0x209F8B0 VA: 0x1820A06B0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A0910 Offset: 0x209FB10 VA: 0x1820A0910 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A08C0 Offset: 0x209FAC0 VA: 0x1820A08C0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeBase : Datatype_anySimpleType // TypeDefIndex: 12274
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x20A0000 Offset: 0x209F200 VA: 0x1820A0000 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x20A0470 Offset: 0x209F670 VA: 0x1820A0470 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1698190 Offset: 0x1697390 VA: 0x181698190 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A03E0 Offset: 0x209F5E0 VA: 0x1820A03E0
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x20A0520 Offset: 0x209F720 VA: 0x1820A0520 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A04C0 Offset: 0x209F6C0 VA: 0x1820A04C0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x20A0510 Offset: 0x209F710 VA: 0x1820A0510 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x209FEA0 Offset: 0x209F0A0 VA: 0x18209FEA0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A0010 Offset: 0x209F210 VA: 0x1820A0010 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A0330 Offset: 0x209F530 VA: 0x1820A0330
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 12275
{
	// Methods

	// RVA: 0x20A0570 Offset: 0x209F770 VA: 0x1820A0570
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 12276
{
	// Methods

	// RVA: 0x20A05C0 Offset: 0x209F7C0 VA: 0x1820A05C0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTime : Datatype_dateTimeBase // TypeDefIndex: 12277
{
	// Methods

	// RVA: 0x20A0610 Offset: 0x209F810 VA: 0x1820A0610
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_timeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 12278
{
	// Methods

	// RVA: 0x20A4020 Offset: 0x20A3220 VA: 0x1820A4020
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_timeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 12279
{
	// Methods

	// RVA: 0x20A4070 Offset: 0x20A3270 VA: 0x1820A4070
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_time : Datatype_dateTimeBase // TypeDefIndex: 12280
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1B64A50 Offset: 0x1B63C50 VA: 0x181B64A50 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A40C0 Offset: 0x20A32C0 VA: 0x1820A40C0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_date : Datatype_dateTimeBase // TypeDefIndex: 12281
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xAA00C0 Offset: 0xA9F2C0 VA: 0x180AA00C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A0660 Offset: 0x209F860 VA: 0x1820A0660
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonth : Datatype_dateTimeBase // TypeDefIndex: 12282
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1712550 Offset: 0x1711750 VA: 0x181712550 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A6640 Offset: 0x20A5840 VA: 0x1820A6640
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_year : Datatype_dateTimeBase // TypeDefIndex: 12283
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x16FD490 Offset: 0x16FC690 VA: 0x1816FD490 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A6690 Offset: 0x20A5890 VA: 0x1820A6690
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_monthDay : Datatype_dateTimeBase // TypeDefIndex: 12284
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1717A10 Offset: 0x1716C10 VA: 0x181717A10 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A3310 Offset: 0x20A2510 VA: 0x1820A3310
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_day : Datatype_dateTimeBase // TypeDefIndex: 12285
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xAA00D0 Offset: 0xA9F2D0 VA: 0x180AA00D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A0920 Offset: 0x209FB20 VA: 0x1820A0920
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_month : Datatype_dateTimeBase // TypeDefIndex: 12286
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x20A33B0 Offset: 0x20A25B0 VA: 0x1820A33B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A3360 Offset: 0x20A2560 VA: 0x1820A3360
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_hexBinary : Datatype_anySimpleType // TypeDefIndex: 12287
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x209D5E0 Offset: 0x209C7E0 VA: 0x18209D5E0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x20A27B0 Offset: 0x20A19B0 VA: 0x1820A27B0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x20A2850 Offset: 0x20A1A50 VA: 0x1820A2850 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A2860 Offset: 0x20A1A60 VA: 0x1820A2860 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A2800 Offset: 0x20A1A00 VA: 0x1820A2800 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x209D480 Offset: 0x209C680 VA: 0x18209D480 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x20A2400 Offset: 0x20A1600 VA: 0x1820A2400 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A2530 Offset: 0x20A1730 VA: 0x1820A2530 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A2730 Offset: 0x20A1930 VA: 0x1820A2730
	public void .ctor() { }

	// RVA: 0x20A2680 Offset: 0x20A1880 VA: 0x1820A2680
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_base64Binary : Datatype_anySimpleType // TypeDefIndex: 12288
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x209D5E0 Offset: 0x209C7E0 VA: 0x18209D5E0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x209F0D0 Offset: 0x209E2D0 VA: 0x18209F0D0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x19600D0 Offset: 0x195F2D0 VA: 0x1819600D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x209F170 Offset: 0x209E370 VA: 0x18209F170 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x209F120 Offset: 0x209E320 VA: 0x18209F120 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x209D480 Offset: 0x209C680 VA: 0x18209D480 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x209ED30 Offset: 0x209DF30 VA: 0x18209ED30 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x209EE60 Offset: 0x209E060 VA: 0x18209EE60 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x209F050 Offset: 0x209E250 VA: 0x18209F050
	public void .ctor() { }

	// RVA: 0x209EFA0 Offset: 0x209E1A0 VA: 0x18209EFA0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anyURI : Datatype_anySimpleType // TypeDefIndex: 12289
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override bool HasValueFacets { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x209D5E0 Offset: 0x209C7E0 VA: 0x18209D5E0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x209EC30 Offset: 0x209DE30 VA: 0x18209EC30 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x209ECD0 Offset: 0x209DED0 VA: 0x18209ECD0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x209ECE0 Offset: 0x209DEE0 VA: 0x18209ECE0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x209EC80 Offset: 0x209DE80 VA: 0x18209EC80 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x209D480 Offset: 0x209C680 VA: 0x18209D480 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x209E7B0 Offset: 0x209D9B0 VA: 0x18209E7B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x209E900 Offset: 0x209DB00 VA: 0x18209E900 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x209EBB0 Offset: 0x209DDB0 VA: 0x18209EBB0
	public void .ctor() { }

	// RVA: 0x209EB00 Offset: 0x209DD00 VA: 0x18209EB00
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_QName : Datatype_anySimpleType // TypeDefIndex: 12290
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x209D5E0 Offset: 0x209C7E0 VA: 0x18209D5E0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x209E310 Offset: 0x209D510 VA: 0x18209E310 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x197B8E0 Offset: 0x197AAE0 VA: 0x18197B8E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x209D480 Offset: 0x209C680 VA: 0x18209D480 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x209E3C0 Offset: 0x209D5C0 VA: 0x18209E3C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x209E370 Offset: 0x209D570 VA: 0x18209E370 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x209E010 Offset: 0x209D210 VA: 0x18209E010 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x209E290 Offset: 0x209D490 VA: 0x18209E290
	public void .ctor() { }

	// RVA: 0x209E1E0 Offset: 0x209D3E0 VA: 0x18209E1E0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedString : Datatype_string // TypeDefIndex: 12291
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1975F80 Offset: 0x1975180 VA: 0x181975F80 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedStringV1Compat : Datatype_string // TypeDefIndex: 12292
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1975F80 Offset: 0x1975180 VA: 0x181975F80 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_token : Datatype_normalizedString // TypeDefIndex: 12293
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1533C40 Offset: 0x1532E40 VA: 0x181533C40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat // TypeDefIndex: 12294
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1533C40 Offset: 0x1532E40 VA: 0x181533C40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_language : Datatype_token // TypeDefIndex: 12295
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1974960 Offset: 0x1973B60 VA: 0x181974960 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NMTOKEN : Datatype_token // TypeDefIndex: 12296
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1FF1DF0 Offset: 0x1FF0FF0 VA: 0x181FF1DF0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x16F8530 Offset: 0x16F7730 VA: 0x1816F8530 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_Name : Datatype_token // TypeDefIndex: 12297
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x19188A0 Offset: 0x1917AA0 VA: 0x1819188A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NCName : Datatype_Name // TypeDefIndex: 12298
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1973210 Offset: 0x1972410 VA: 0x181973210 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x209D4B0 Offset: 0x209C6B0 VA: 0x18209D4B0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ID : Datatype_NCName // TypeDefIndex: 12299
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x19788F0 Offset: 0x1977AF0 VA: 0x1819788F0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_IDREF : Datatype_NCName // TypeDefIndex: 12300
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1D2F490 Offset: 0x1D2E690 VA: 0x181D2F490 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ENTITY : Datatype_NCName // TypeDefIndex: 12301
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x209C190 Offset: 0x209B390 VA: 0x18209C190 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NOTATION : Datatype_anySimpleType // TypeDefIndex: 12302
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x209D5E0 Offset: 0x209C7E0 VA: 0x18209D5E0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x209DB20 Offset: 0x209CD20 VA: 0x18209DB20 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1971670 Offset: 0x1970870 VA: 0x181971670 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x209D480 Offset: 0x209C680 VA: 0x18209D480 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x209DBD0 Offset: 0x209CDD0 VA: 0x18209DBD0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x209DB80 Offset: 0x209CD80 VA: 0x18209DB80 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x209D5F0 Offset: 0x209C7F0 VA: 0x18209D5F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x209D7C0 Offset: 0x209C9C0 VA: 0x18209D7C0 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x209DAA0 Offset: 0x209CCA0 VA: 0x18209DAA0
	public void .ctor() { }

	// RVA: 0x209D9F0 Offset: 0x209CBF0 VA: 0x18209D9F0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_integer : Datatype_decimal // TypeDefIndex: 12303
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xAA01A0 Offset: 0xA9F3A0 VA: 0x180AA01A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A2D50 Offset: 0x20A1F50 VA: 0x1820A2D50 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A2EA0 Offset: 0x20A20A0 VA: 0x1820A2EA0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_nonPositiveInteger : Datatype_integer // TypeDefIndex: 12304
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x20A37B0 Offset: 0x20A29B0 VA: 0x1820A37B0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1978EB0 Offset: 0x19780B0 VA: 0x181978EB0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x20A2EA0 Offset: 0x20A20A0 VA: 0x1820A2EA0
	public void .ctor() { }

	// RVA: 0x20A36C0 Offset: 0x20A28C0 VA: 0x1820A36C0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_negativeInteger : Datatype_nonPositiveInteger // TypeDefIndex: 12305
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x20A3530 Offset: 0x20A2730 VA: 0x1820A3530 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x197A4B0 Offset: 0x19796B0 VA: 0x18197A4B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A34B0 Offset: 0x20A26B0 VA: 0x1820A34B0
	public void .ctor() { }

	// RVA: 0x20A33C0 Offset: 0x20A25C0 VA: 0x1820A33C0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_long : Datatype_integer // TypeDefIndex: 12306
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	internal override bool HasValueFacets { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x20A3220 Offset: 0x20A2420 VA: 0x1820A3220 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x198D360 Offset: 0x198C560 VA: 0x18198D360 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A2EF0 Offset: 0x20A20F0 VA: 0x1820A2EF0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A32C0 Offset: 0x20A24C0 VA: 0x1820A32C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A3270 Offset: 0x20A2470 VA: 0x1820A3270 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x20A2F70 Offset: 0x20A2170 VA: 0x1820A2F70 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A2EA0 Offset: 0x20A20A0 VA: 0x1820A2EA0
	public void .ctor() { }

	// RVA: 0x20A30E0 Offset: 0x20A22E0 VA: 0x1820A30E0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_int : Datatype_long // TypeDefIndex: 12307
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x20A2C50 Offset: 0x20A1E50 VA: 0x1820A2C50 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x20A2CF0 Offset: 0x20A1EF0 VA: 0x1820A2CF0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A28B0 Offset: 0x20A1AB0 VA: 0x1820A28B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A2D00 Offset: 0x20A1F00 VA: 0x1820A2D00 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A2CA0 Offset: 0x20A1EA0 VA: 0x1820A2CA0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x20A2930 Offset: 0x20A1B30 VA: 0x1820A2930 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A2BD0 Offset: 0x20A1DD0 VA: 0x1820A2BD0
	public void .ctor() { }

	// RVA: 0x20A2A90 Offset: 0x20A1C90 VA: 0x1820A2A90
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_short : Datatype_int // TypeDefIndex: 12308
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x20A3D40 Offset: 0x20A2F40 VA: 0x1820A3D40 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x20A3DE0 Offset: 0x20A2FE0 VA: 0x1820A3DE0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A39C0 Offset: 0x20A2BC0 VA: 0x1820A39C0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A3DF0 Offset: 0x20A2FF0 VA: 0x1820A3DF0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A3D90 Offset: 0x20A2F90 VA: 0x1820A3D90 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x20A3A40 Offset: 0x20A2C40 VA: 0x1820A3A40 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A3CF0 Offset: 0x20A2EF0 VA: 0x1820A3CF0
	public void .ctor() { }

	// RVA: 0x20A3BB0 Offset: 0x20A2DB0 VA: 0x1820A3BB0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_byte : Datatype_short // TypeDefIndex: 12309
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x209F940 Offset: 0x209EB40 VA: 0x18209F940 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CD0440 Offset: 0x1CCF640 VA: 0x181CD0440 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x209F590 Offset: 0x209E790 VA: 0x18209F590 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x209F9E0 Offset: 0x209EBE0 VA: 0x18209F9E0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x209F990 Offset: 0x209EB90 VA: 0x18209F990 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x209F610 Offset: 0x209E810 VA: 0x18209F610 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x209F8C0 Offset: 0x209EAC0 VA: 0x18209F8C0
	public void .ctor() { }

	// RVA: 0x209F780 Offset: 0x209E980 VA: 0x18209F780
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_nonNegativeInteger : Datatype_integer // TypeDefIndex: 12310
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x20A3670 Offset: 0x20A2870 VA: 0x1820A3670 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CFDCE0 Offset: 0x1CFCEE0 VA: 0x181CFDCE0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x20A2EA0 Offset: 0x20A20A0 VA: 0x1820A2EA0
	public void .ctor() { }

	// RVA: 0x20A3580 Offset: 0x20A2780 VA: 0x1820A3580
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedLong : Datatype_nonNegativeInteger // TypeDefIndex: 12311
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x20A5970 Offset: 0x20A4B70 VA: 0x1820A5970 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xAA0100 Offset: 0xA9F300 VA: 0x180AA0100 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A5560 Offset: 0x20A4760 VA: 0x1820A5560 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A5A10 Offset: 0x20A4C10 VA: 0x1820A5A10 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A59C0 Offset: 0x20A4BC0 VA: 0x1820A59C0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x20A55E0 Offset: 0x20A47E0 VA: 0x1820A55E0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A58F0 Offset: 0x20A4AF0 VA: 0x1820A58F0
	public void .ctor() { }

	// RVA: 0x20A57A0 Offset: 0x20A49A0 VA: 0x1820A57A0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedInt : Datatype_unsignedLong // TypeDefIndex: 12312
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x20A5470 Offset: 0x20A4670 VA: 0x1820A5470 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1B29E50 Offset: 0x1B29050 VA: 0x181B29E50 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A50F0 Offset: 0x20A42F0 VA: 0x1820A50F0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A5510 Offset: 0x20A4710 VA: 0x1820A5510 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A54C0 Offset: 0x20A46C0 VA: 0x1820A54C0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x20A5170 Offset: 0x20A4370 VA: 0x1820A5170 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A5420 Offset: 0x20A4620 VA: 0x1820A5420
	public void .ctor() { }

	// RVA: 0x20A52D0 Offset: 0x20A44D0 VA: 0x1820A52D0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedShort : Datatype_unsignedInt // TypeDefIndex: 12313
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x20A5E20 Offset: 0x20A5020 VA: 0x1820A5E20 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1A47C60 Offset: 0x1A46E60 VA: 0x181A47C60 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A5A60 Offset: 0x20A4C60 VA: 0x1820A5A60 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A5EC0 Offset: 0x20A50C0 VA: 0x1820A5EC0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A5E70 Offset: 0x20A5070 VA: 0x1820A5E70 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x20A5AE0 Offset: 0x20A4CE0 VA: 0x1820A5AE0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A5DA0 Offset: 0x20A4FA0 VA: 0x1820A5DA0
	public void .ctor() { }

	// RVA: 0x20A5C50 Offset: 0x20A4E50 VA: 0x1820A5C50
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedByte : Datatype_unsignedShort // TypeDefIndex: 12314
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x20A5000 Offset: 0x20A4200 VA: 0x1820A5000 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1D04030 Offset: 0x1D03230 VA: 0x181D04030 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A4C70 Offset: 0x20A3E70 VA: 0x1820A4C70 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A50A0 Offset: 0x20A42A0 VA: 0x1820A50A0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A5050 Offset: 0x20A4250 VA: 0x1820A5050 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x20A4CF0 Offset: 0x20A3EF0 VA: 0x1820A4CF0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A4FB0 Offset: 0x20A41B0 VA: 0x1820A4FB0
	public void .ctor() { }

	// RVA: 0x20A4E60 Offset: 0x20A4060 VA: 0x1820A4E60
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_positiveInteger : Datatype_nonNegativeInteger // TypeDefIndex: 12315
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x20A3970 Offset: 0x20A2B70 VA: 0x1820A3970 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xAA0120 Offset: 0xA9F320 VA: 0x180AA0120 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x20A38F0 Offset: 0x20A2AF0 VA: 0x1820A38F0
	public void .ctor() { }

	// RVA: 0x20A3800 Offset: 0x20A2A00 VA: 0x1820A3800
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_doubleXdr : Datatype_double // TypeDefIndex: 12316
{
	// Methods

	// RVA: 0x20A0E80 Offset: 0x20A0080 VA: 0x1820A0E80 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x20A1040 Offset: 0x20A0240 VA: 0x1820A1040
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_floatXdr : Datatype_float // TypeDefIndex: 12317
{
	// Methods

	// RVA: 0x20A1DF0 Offset: 0x20A0FF0 VA: 0x1820A1DF0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x20A1FA0 Offset: 0x20A11A0 VA: 0x1820A1FA0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_QNameXdr : Datatype_anySimpleType // TypeDefIndex: 12318
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x209DC20 Offset: 0x209CE20 VA: 0x18209DC20 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x209DFC0 Offset: 0x209D1C0 VA: 0x18209DFC0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x209DF70 Offset: 0x209D170 VA: 0x18209DF70 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x209DEF0 Offset: 0x209D0F0 VA: 0x18209DEF0
	public void .ctor() { }

	// RVA: 0x209DE40 Offset: 0x209D040 VA: 0x18209DE40
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ENUMERATION : Datatype_NMTOKEN // TypeDefIndex: 12319
{
	// Properties
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x563540 Offset: 0x562740 VA: 0x180563540 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x209C180 Offset: 0x209B380 VA: 0x18209C180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_char : Datatype_anySimpleType // TypeDefIndex: 12320
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x209FE50 Offset: 0x209F050 VA: 0x18209FE50 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x209FE00 Offset: 0x209F000 VA: 0x18209FE00 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x209FA30 Offset: 0x209EC30 VA: 0x18209FA30 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x209FAD0 Offset: 0x209ECD0 VA: 0x18209FAD0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x209FC30 Offset: 0x209EE30 VA: 0x18209FC30 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x209FD80 Offset: 0x209EF80 VA: 0x18209FD80
	public void .ctor() { }

	// RVA: 0x209FCD0 Offset: 0x209EED0 VA: 0x18209FCD0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_fixed : Datatype_decimal // TypeDefIndex: 12321
{
	// Methods

	// RVA: 0x20A1980 Offset: 0x20A0B80 VA: 0x1820A1980 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x20A1C00 Offset: 0x20A0E00 VA: 0x1820A1C00 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A1DA0 Offset: 0x20A0FA0 VA: 0x1820A1DA0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_uuid : Datatype_anySimpleType // TypeDefIndex: 12322
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x20A6390 Offset: 0x20A5590 VA: 0x1820A6390 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x20A6340 Offset: 0x20A5540 VA: 0x1820A6340 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x20A5F70 Offset: 0x20A5170 VA: 0x1820A5F70 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x20A6000 Offset: 0x20A5200 VA: 0x1820A6000 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x20A6170 Offset: 0x20A5370 VA: 0x1820A6170 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x20A62C0 Offset: 0x20A54C0 VA: 0x1820A62C0
	public void .ctor() { }

	// RVA: 0x20A6210 Offset: 0x20A5410 VA: 0x1820A6210
	private static void .cctor() { }
}

// Namespace: 
private class DtdValidator.NamespaceManager : XmlNamespaceManager // TypeDefIndex: 12323
{
	// Methods

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class DtdValidator : BaseValidator // TypeDefIndex: 12324
{
	// Fields
	private static DtdValidator.NamespaceManager namespaceManager; // 0x0
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private Hashtable IDs; // 0x98
	private IdRefNode idRefListHead; // 0xA0
	private bool processIdentityConstraints; // 0xA8

	// Properties
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x20A98E0 Offset: 0x20A8AE0 VA: 0x1820A98E0
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x20A7C20 Offset: 0x20A6E20 VA: 0x1820A7C20
	private void Init() { }

	// RVA: 0x20A9500 Offset: 0x20A8700 VA: 0x1820A9500 Slot: 5
	public override void Validate() { }

	// RVA: 0x20A7D50 Offset: 0x20A6F50 VA: 0x1820A7D50
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x20A8FF0 Offset: 0x20A81F0 VA: 0x1820A8FF0
	private void ValidatePIComment() { }

	// RVA: 0x20A8850 Offset: 0x20A7A50 VA: 0x1820A8850
	private void ValidateElement() { }

	// RVA: 0x20A8680 Offset: 0x20A7880 VA: 0x1820A8680
	private void ValidateChildElement() { }

	// RVA: 0x20A90A0 Offset: 0x20A82A0 VA: 0x1820A90A0
	private void ValidateStartElement() { }

	// RVA: 0x20A8E40 Offset: 0x20A8040 VA: 0x1820A8E40
	private void ValidateEndStartElement() { }

	// RVA: 0x20A7EA0 Offset: 0x20A70A0 VA: 0x1820A7EA0
	private void ProcessElement() { }

	// RVA: 0x20A77F0 Offset: 0x20A69F0 VA: 0x1820A77F0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x20A8C40 Offset: 0x20A7E40 VA: 0x1820A8C40
	private void ValidateEndElement() { }

	// RVA: 0x1F686F0 Offset: 0x1F678F0 VA: 0x181F686F0 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x20A7FE0 Offset: 0x20A71E0 VA: 0x1820A7FE0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x20A7300 Offset: 0x20A6500 VA: 0x1820A7300
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x20A6DD0 Offset: 0x20A5FD0 VA: 0x1820A6DD0
	internal void AddID(string name, object node) { }

	// RVA: 0x20A7950 Offset: 0x20A6B50 VA: 0x1820A7950 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x20A7980 Offset: 0x20A6B80 VA: 0x1820A7980
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x20A7B70 Offset: 0x20A6D70 VA: 0x1820A7B70
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x20A71C0 Offset: 0x20A63C0 VA: 0x1820A71C0
	private void CheckForwardRefs() { }

	// RVA: 0x20A8290 Offset: 0x20A7490 VA: 0x1820A8290
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x20A7DE0 Offset: 0x20A6FE0 VA: 0x1820A7DE0
	private bool Pop() { }

	// RVA: 0x20A83D0 Offset: 0x20A75D0 VA: 0x1820A83D0
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x20A6E80 Offset: 0x20A6080 VA: 0x1820A6E80
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x20A9880 Offset: 0x20A8A80 VA: 0x1820A9880
	private static void .cctor() { }
}

// Namespace: 
private struct FacetsChecker.FacetsCompiler.Map // TypeDefIndex: 12325
{
	// Fields
	internal char match; // 0x0
	internal string replacement; // 0x8

	// Methods

	// RVA: 0x1314450 Offset: 0x1313650 VA: 0x181314450
	internal void .ctor(char m, string r) { }
}

// Namespace: 
private struct FacetsChecker.FacetsCompiler // TypeDefIndex: 12326
{
	// Fields
	private DatatypeImplementation datatype; // 0x0
	private RestrictionFacets derivedRestriction; // 0x8
	private RestrictionFlags baseFlags; // 0x10
	private RestrictionFlags baseFixedFlags; // 0x14
	private RestrictionFlags validRestrictionFlags; // 0x18
	private XmlSchemaDatatype nonNegativeInt; // 0x20
	private XmlSchemaDatatype builtInType; // 0x28
	private XmlTypeCode builtInEnum; // 0x30
	private bool firstPattern; // 0x34
	private StringBuilder regStr; // 0x38
	private XmlSchemaPatternFacet pattern_facet; // 0x40
	private static readonly FacetsChecker.FacetsCompiler.Map[] c_map; // 0x0

	// Methods

	// RVA: 0x20AF030 Offset: 0x20AE230 VA: 0x1820AF030
	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x20ABEC0 Offset: 0x20AB0C0 VA: 0x1820ABEC0
	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x20AD140 Offset: 0x20AC340 VA: 0x1820AD140
	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x20AC840 Offset: 0x20ABA40 VA: 0x1820AC840
	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x20AD560 Offset: 0x20AC760 VA: 0x1820AD560
	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x20AB400 Offset: 0x20AA600 VA: 0x1820AB400
	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x20ADB40 Offset: 0x20ACD40 VA: 0x1820ADB40
	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x20AC5E0 Offset: 0x20AB7E0 VA: 0x1820AC5E0
	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x20AC370 Offset: 0x20AB570 VA: 0x1820AC370
	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x20ACED0 Offset: 0x20AC0D0 VA: 0x1820ACED0
	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x20ACC60 Offset: 0x20ABE60 VA: 0x1820ACC60
	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x20AD700 Offset: 0x20AC900 VA: 0x1820AD700
	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x20ABB60 Offset: 0x20AAD60 VA: 0x1820ABB60
	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x20AE560 Offset: 0x20AD760 VA: 0x1820AE560
	internal void FinishFacetCompile() { }

	// RVA: 0x20AAD00 Offset: 0x20A9F00 VA: 0x1820AAD00
	private void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x20AB5A0 Offset: 0x20AA7A0 VA: 0x1820AB5A0
	internal void CompileFacetCombinations() { }

	// RVA: 0x20ADFB0 Offset: 0x20AD1B0 VA: 0x1820ADFB0
	private void CopyFacetsFromBaseType() { }

	// RVA: 0x20AE8A0 Offset: 0x20ADAA0 VA: 0x1820AE8A0
	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x20AEA60 Offset: 0x20ADC60 VA: 0x1820AEA60
	private static string Preprocess(string pattern) { }

	// RVA: 0x20AAC60 Offset: 0x20A9E60 VA: 0x1820AAC60
	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x20AABE0 Offset: 0x20A9DE0 VA: 0x1820AABE0
	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x20AEDA0 Offset: 0x20ADFA0 VA: 0x1820AEDA0
	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x20AED70 Offset: 0x20ADF70 VA: 0x1820AED70
	private void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x20AEE00 Offset: 0x20AE000 VA: 0x1820AEE00
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class FacetsChecker // TypeDefIndex: 12327
{
	// Methods

	// RVA: 0x20AA150 Offset: 0x20A9350 VA: 0x1820AA150 Slot: 4
	internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 11
	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 13
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 14
	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 15
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20AA440 Offset: 0x20A9640 VA: 0x1820AA440
	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x20AA270 Offset: 0x20A9470 VA: 0x1820AA270
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 17
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x20AA550 Offset: 0x20A9750 VA: 0x1820AA550 Slot: 18
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x20AAAB0 Offset: 0x20A9CB0 VA: 0x1820AAAB0
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Numeric10FacetsChecker : FacetsChecker // TypeDefIndex: 12328
{
	// Fields
	private static readonly char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0x20B0A70 Offset: 0x20AFC70 VA: 0x1820B0A70
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0x20AFE40 Offset: 0x20AF040 VA: 0x1820AFE40 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20AFEE0 Offset: 0x20AF0E0 VA: 0x1820AFEE0 Slot: 6
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B06A0 Offset: 0x20AF8A0 VA: 0x1820B06A0 Slot: 7
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B0610 Offset: 0x20AF810 VA: 0x1820B0610 Slot: 8
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20AFDB0 Offset: 0x20AEFB0 VA: 0x1820AFDB0 Slot: 9
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B0730 Offset: 0x20AF930 VA: 0x1820B0730 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B08C0 Offset: 0x20AFAC0 VA: 0x1820B08C0
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x20AFA00 Offset: 0x20AEC00 VA: 0x1820AFA00
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0x20B09F0 Offset: 0x20AFBF0 VA: 0x1820B09F0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Numeric2FacetsChecker : FacetsChecker // TypeDefIndex: 12329
{
	// Methods

	// RVA: 0x20B0E30 Offset: 0x20B0030 VA: 0x1820B0E30 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B0AB0 Offset: 0x20AFCB0 VA: 0x1820B0AB0 Slot: 11
	internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B0E10 Offset: 0x20B0010 VA: 0x1820B0E10 Slot: 12
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B0F80 Offset: 0x20B0180 VA: 0x1820B0F80 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B0EC0 Offset: 0x20B00C0 VA: 0x1820B0EC0
	private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class DurationFacetsChecker : FacetsChecker // TypeDefIndex: 12330
{
	// Methods

	// RVA: 0x20A9E80 Offset: 0x20A9080 VA: 0x1820A9E80 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20A9AA0 Offset: 0x20A8CA0 VA: 0x1820A9AA0 Slot: 15
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20A9FB0 Offset: 0x20A91B0 VA: 0x1820A9FB0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x20AA040 Offset: 0x20A9240 VA: 0x1820AA040
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class DateTimeFacetsChecker : FacetsChecker // TypeDefIndex: 12331
{
	// Methods

	// RVA: 0x20A6B70 Offset: 0x20A5D70 VA: 0x1820A6B70 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20A66E0 Offset: 0x20A58E0 VA: 0x1820A66E0 Slot: 10
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20A6C00 Offset: 0x20A5E00 VA: 0x1820A6C00 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x20A6C90 Offset: 0x20A5E90 VA: 0x1820A6C90
	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class StringFacetsChecker : FacetsChecker // TypeDefIndex: 12332
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Properties
	private static Regex LanguagePattern { get; }

	// Methods

	// RVA: 0x20B2AC0 Offset: 0x20B1CC0 VA: 0x1820B2AC0
	private static Regex get_LanguagePattern() { }

	// RVA: 0x20B2510 Offset: 0x20B1710 VA: 0x1820B2510 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B24F0 Offset: 0x20B16F0 VA: 0x1820B24F0 Slot: 13
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B25A0 Offset: 0x20B17A0 VA: 0x1820B25A0
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0x20B2A30 Offset: 0x20B1C30 VA: 0x1820B2A30 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B2800 Offset: 0x20B1A00 VA: 0x1820B2800
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x20B21F0 Offset: 0x20B13F0 VA: 0x1820B21F0
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class QNameFacetsChecker : FacetsChecker // TypeDefIndex: 12333
{
	// Methods

	// RVA: 0x1F17E80 Offset: 0x1F17080 VA: 0x181F17E80 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1F17C80 Offset: 0x1F16E80 VA: 0x181F17C80 Slot: 16
	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1F18110 Offset: 0x1F17310 VA: 0x181F18110 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1F17FE0 Offset: 0x1F171E0 VA: 0x181F17FE0
	private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class MiscFacetsChecker : FacetsChecker // TypeDefIndex: 12334
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class BinaryFacetsChecker : FacetsChecker // TypeDefIndex: 12335
{
	// Methods

	// RVA: 0x1F09C90 Offset: 0x1F08E90 VA: 0x181F09C90 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1F09D30 Offset: 0x1F08F30 VA: 0x181F09D30 Slot: 14
	internal override Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1F09F20 Offset: 0x1F09120 VA: 0x181F09F20 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1F0A080 Offset: 0x1F09280 VA: 0x181F0A080
	private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class ListFacetsChecker : FacetsChecker // TypeDefIndex: 12336
{
	// Methods

	// RVA: 0x1F0A190 Offset: 0x1F09390 VA: 0x181F0A190 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1F0A410 Offset: 0x1F09610 VA: 0x181F0A410 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class UnionFacetsChecker : FacetsChecker // TypeDefIndex: 12337
{
	// Methods

	// RVA: 0x1F18260 Offset: 0x1F17460 VA: 0x181F18260 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1F0A410 Offset: 0x1F09610 VA: 0x181F0A410 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public interface IXmlSchemaInfo // TypeDefIndex: 12338
{
	// Properties
	public abstract XmlSchemaValidity Validity { get; }
	public abstract bool IsDefault { get; }
	public abstract bool IsNil { get; }
	public abstract XmlSchemaSimpleType MemberType { get; }
	public abstract XmlSchemaType SchemaType { get; }
	public abstract XmlSchemaElement SchemaElement { get; }
	public abstract XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchemaValidity get_Validity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsDefault();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsNil();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract XmlSchemaSimpleType get_MemberType();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_SchemaType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlSchemaElement get_SchemaElement();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlSchemaAttribute get_SchemaAttribute();
}

// Namespace: 
public enum XmlSchemaInference.InferenceOption // TypeDefIndex: 12339
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaInference.InferenceOption Restricted = 0;
	public const XmlSchemaInference.InferenceOption Relaxed = 1;
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaInference // TypeDefIndex: 12340
{
	// Fields
	internal static XmlQualifiedName ST_boolean; // 0x0
	internal static XmlQualifiedName ST_byte; // 0x8
	internal static XmlQualifiedName ST_unsignedByte; // 0x10
	internal static XmlQualifiedName ST_short; // 0x18
	internal static XmlQualifiedName ST_unsignedShort; // 0x20
	internal static XmlQualifiedName ST_int; // 0x28
	internal static XmlQualifiedName ST_unsignedInt; // 0x30
	internal static XmlQualifiedName ST_long; // 0x38
	internal static XmlQualifiedName ST_unsignedLong; // 0x40
	internal static XmlQualifiedName ST_integer; // 0x48
	internal static XmlQualifiedName ST_decimal; // 0x50
	internal static XmlQualifiedName ST_float; // 0x58
	internal static XmlQualifiedName ST_double; // 0x60
	internal static XmlQualifiedName ST_duration; // 0x68
	internal static XmlQualifiedName ST_dateTime; // 0x70
	internal static XmlQualifiedName ST_time; // 0x78
	internal static XmlQualifiedName ST_date; // 0x80
	internal static XmlQualifiedName ST_gYearMonth; // 0x88
	internal static XmlQualifiedName ST_string; // 0x90
	internal static XmlQualifiedName ST_anySimpleType; // 0x98
	internal static XmlQualifiedName[] SimpleTypes; // 0xA0
	private XmlSchema rootSchema; // 0x10
	private XmlSchemaSet schemaSet; // 0x18
	private XmlReader xtr; // 0x20
	private NameTable nametable; // 0x28
	private string TargetNamespace; // 0x30
	private XmlNamespaceManager NamespaceManager; // 0x38
	private ArrayList schemaList; // 0x40
	private XmlSchemaInference.InferenceOption occurrence; // 0x48
	private XmlSchemaInference.InferenceOption typeInference; // 0x4C

	// Properties
	public XmlSchemaInference.InferenceOption Occurrence { get; set; }
	public XmlSchemaInference.InferenceOption TypeInference { set; }

	// Methods

	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_Occurrence(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public XmlSchemaInference.InferenceOption get_Occurrence() { }

	// RVA: 0x547AB0 Offset: 0x546CB0 VA: 0x180547AB0
	public void set_TypeInference(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x1F223E0 Offset: 0x1F215E0 VA: 0x181F223E0
	public void .ctor() { }

	// RVA: 0x1F1EA40 Offset: 0x1F1DC40 VA: 0x181F1EA40
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x1F1E240 Offset: 0x1F1D440 VA: 0x181F1E240
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x1F18490 Offset: 0x1F17690 VA: 0x181F18490
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x1F19880 Offset: 0x1F18A80 VA: 0x181F19880
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x1F18D90 Offset: 0x1F17F90 VA: 0x181F18D90
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x1F1C5F0 Offset: 0x1F1B7F0 VA: 0x181F1C5F0
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1F19490 Offset: 0x1F18690 VA: 0x181F19490
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x1F1B9F0 Offset: 0x1F1ABF0 VA: 0x181F1B9F0
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x1F1A340 Offset: 0x1F19540 VA: 0x181F1A340
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x1F1FFE0 Offset: 0x1F1F1E0 VA: 0x181F1FFE0
	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1F1FC50 Offset: 0x1F1EE50 VA: 0x181F1FC50
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x1F1FCF0 Offset: 0x1F1EEF0 VA: 0x181F1FCF0
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x1F19C40 Offset: 0x1F18E40 VA: 0x181F19C40
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x1F1A130 Offset: 0x1F19330 VA: 0x181F1A130
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	// RVA: 0x1F19FE0 Offset: 0x1F191E0 VA: 0x181F19FE0
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x1F199E0 Offset: 0x1F18BE0 VA: 0x181F199E0
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x1F19E70 Offset: 0x1F19070 VA: 0x181F19E70
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x1F1FB80 Offset: 0x1F1ED80 VA: 0x181F1FB80
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x1F216A0 Offset: 0x1F208A0 VA: 0x181F216A0
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x1F207E0 Offset: 0x1F1F9E0 VA: 0x181F207E0
	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	// RVA: 0x1F1EAC0 Offset: 0x1F1DCC0 VA: 0x181F1EAC0
	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	// RVA: 0x1F19910 Offset: 0x1F18B10 VA: 0x181F19910
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x1F19630 Offset: 0x1F18830 VA: 0x181F19630
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x1F1BB80 Offset: 0x1F1AD80 VA: 0x181F1BB80
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x1F214C0 Offset: 0x1F206C0 VA: 0x181F214C0
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x1F217F0 Offset: 0x1F209F0 VA: 0x181F217F0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaInferenceException : XmlSchemaException // TypeDefIndex: 12341
{
	// Methods

	// RVA: 0x1F18460 Offset: 0x1F17660 VA: 0x181F18460
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1F18370 Offset: 0x1F17570 VA: 0x181F18370 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1F18480 Offset: 0x1F17680 VA: 0x181F18480
	public void .ctor() { }

	// RVA: 0x1F183C0 Offset: 0x1F175C0 VA: 0x181F183C0
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1F18390 Offset: 0x1F17590 VA: 0x181F18390
	internal void .ctor(string res, int lineNumber, int linePosition) { }
}

// Namespace: 
public enum NamespaceList.ListType // TypeDefIndex: 12342
{
	// Fields
	public int value__; // 0x0
	public const NamespaceList.ListType Any = 0;
	public const NamespaceList.ListType Other = 1;
	public const NamespaceList.ListType Set = 2;
}

// Namespace: System.Xml.Schema
internal class NamespaceList // TypeDefIndex: 12343
{
	// Fields
	private NamespaceList.ListType type; // 0x10
	private Hashtable set; // 0x18
	private string targetNamespace; // 0x20

	// Properties
	public NamespaceList.ListType Type { get; }
	public string Excluded { get; }
	public ICollection Enumerate { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1F0B8D0 Offset: 0x1F0AAD0 VA: 0x181F0B8D0
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x1F0A640 Offset: 0x1F09840 VA: 0x181F0A640
	public NamespaceList Clone() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public NamespaceList.ListType get_Type() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Excluded() { }

	// RVA: 0x1F0BB30 Offset: 0x1F0AD30 VA: 0x181F0BB30
	public ICollection get_Enumerate() { }

	// RVA: 0x1F0A580 Offset: 0x1F09780 VA: 0x181F0A580 Slot: 4
	public virtual bool Allows(string ns) { }

	// RVA: 0x1F0A610 Offset: 0x1F09810 VA: 0x181F0A610
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1F0B090 Offset: 0x1F0A290 VA: 0x181F0B090 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F0ADA0 Offset: 0x1F09FA0 VA: 0x181F0ADA0
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0x1F0B470 Offset: 0x1F0A670 VA: 0x181F0B470
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x1F0A7E0 Offset: 0x1F099E0 VA: 0x181F0A7E0
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0x1F0A950 Offset: 0x1F09B50 VA: 0x181F0A950
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x1F0B020 Offset: 0x1F0A220 VA: 0x181F0B020
	private void RemoveNamespace(string tns) { }
}

// Namespace: System.Xml.Schema
internal class NamespaceListV1Compat : NamespaceList // TypeDefIndex: 12344
{
	// Methods

	// RVA: 0x1F0A570 Offset: 0x1F09770 VA: 0x181F0A570
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x1F0A4D0 Offset: 0x1F096D0 VA: 0x181F0A4D0 Slot: 4
	public override bool Allows(string ns) { }
}

// Namespace: System.Xml.Schema
internal sealed class Parser // TypeDefIndex: 12345
{
	// Fields
	private SchemaType schemaType; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ValidationEventHandler eventHandler; // 0x28
	private XmlNamespaceManager namespaceManager; // 0x30
	private XmlReader reader; // 0x38
	private PositionInfo positionInfo; // 0x40
	private bool isProcessNamespaces; // 0x48
	private int schemaXmlDepth; // 0x4C
	private int markupDepth; // 0x50
	private SchemaBuilder builder; // 0x58
	private XmlSchema schema; // 0x60
	private SchemaInfo xdrSchema; // 0x68
	private XmlResolver xmlResolver; // 0x70
	private XmlDocument dummyDocument; // 0x78
	private bool processMarkup; // 0x80
	private XmlNode parentNode; // 0x88
	private XmlNamespaceManager annotationNSManager; // 0x90
	private string xmlns; // 0x98
	private XmlCharType xmlCharType; // 0xA0

	// Properties
	public XmlSchema XmlSchema { get; }
	internal XmlResolver XmlResolver { set; }
	public SchemaInfo XdrSchema { get; }

	// Methods

	// RVA: 0x1F0D840 Offset: 0x1F0CA40 VA: 0x181F0D840
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1F0CFF0 Offset: 0x1F0C1F0 VA: 0x181F0CFF0
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0x1F0D390 Offset: 0x1F0C590 VA: 0x181F0D390
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0x1F0BBB0 Offset: 0x1F0ADB0 VA: 0x181F0BBB0
	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public SchemaType FinishParsing() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0x1F0C700 Offset: 0x1F0B900 VA: 0x181F0C700
	public bool ParseReaderNode() { }

	// RVA: 0x1F0D060 Offset: 0x1F0C260 VA: 0x181F0D060
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0x1F0BF90 Offset: 0x1F0B190 VA: 0x181F0BF90
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0x1F0BC90 Offset: 0x1F0AE90 VA: 0x181F0BC90
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0x1F0BDD0 Offset: 0x1F0AFD0 VA: 0x181F0BDD0
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x1F0C470 Offset: 0x1F0B670 VA: 0x181F0C470
	private XmlEntityReference LoadEntityReferenceInAttribute() { }
}

// Namespace: System.Xml.Schema
internal enum Compositor // TypeDefIndex: 12346
{
	// Fields
	public int value__; // 0x0
	public const Compositor Root = 0;
	public const Compositor Include = 1;
	public const Compositor Import = 2;
	public const Compositor Redefine = 3;
}

// Namespace: System.Xml.Schema
internal class RedefineEntry // TypeDefIndex: 12347
{
	// Fields
	internal XmlSchemaRedefine redefine; // 0x10
	internal XmlSchema schemaToUpdate; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(XmlSchemaRedefine external, XmlSchema schema) { }
}

// Namespace: System.Xml.Schema
internal sealed class Preprocessor : BaseProcessor // TypeDefIndex: 12348
{
	// Fields
	private string Xmlns; // 0x40
	private string NsXsi; // 0x48
	private string targetNamespace; // 0x50
	private XmlSchema rootSchema; // 0x58
	private XmlSchema currentSchema; // 0x60
	private XmlSchemaForm elementFormDefault; // 0x68
	private XmlSchemaForm attributeFormDefault; // 0x6C
	private XmlSchemaDerivationMethod blockDefault; // 0x70
	private XmlSchemaDerivationMethod finalDefault; // 0x74
	private Hashtable schemaLocations; // 0x78
	private Hashtable chameleonSchemas; // 0x80
	private Hashtable referenceNamespaces; // 0x88
	private Hashtable processedExternals; // 0x90
	private SortedList lockList; // 0x98
	private XmlReaderSettings readerSettings; // 0xA0
	private XmlSchema rootSchemaForRedefine; // 0xA8
	private ArrayList redefinedList; // 0xB0
	private static XmlSchema builtInSchemaForXmlNS; // 0x0
	private XmlResolver xmlResolver; // 0xB8

	// Properties
	internal XmlResolver XmlResolver { set; }
	internal XmlReaderSettings ReaderSettings { set; }
	internal Hashtable SchemaLocations { set; }
	internal Hashtable ChameleonSchemas { set; }
	internal XmlSchema RootSchema { get; }

	// Methods

	// RVA: 0x1F17B90 Offset: 0x1F16D90 VA: 0x181F17B90
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1F0FB20 Offset: 0x1F0ED20 VA: 0x181F0FB20
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0x1F0E7F0 Offset: 0x1F0D9F0 VA: 0x181F0E7F0
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x1F0E730 Offset: 0x1F0D930 VA: 0x181F0E730
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x146AE20 Offset: 0x146A020 VA: 0x18146AE20
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal XmlSchema get_RootSchema() { }

	// RVA: 0x1F0DC00 Offset: 0x1F0CE00 VA: 0x181F0DC00
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0x1F10B00 Offset: 0x1F0FD00 VA: 0x181F10B00
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0x1F10140 Offset: 0x1F0F340 VA: 0x181F10140
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0x1F0D8F0 Offset: 0x1F0CAF0 VA: 0x181F0D8F0
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x1F11750 Offset: 0x1F10950 VA: 0x181F11750
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0x1F15F10 Offset: 0x1F15110 VA: 0x181F15F10
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0x1F0E8F0 Offset: 0x1F0DAF0 VA: 0x181F0E8F0
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0x1F14A50 Offset: 0x1F13C50 VA: 0x181F14A50
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0x1F108B0 Offset: 0x1F0FAB0 VA: 0x181F108B0
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0x1F10A30 Offset: 0x1F0FC30 VA: 0x181F10A30
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0x1F17370 Offset: 0x1F16570 VA: 0x181F17370
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0x1F0F810 Offset: 0x1F0EA10 VA: 0x181F0F810
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0x1F0E4D0 Offset: 0x1F0D6D0 VA: 0x181F0E4D0
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x1F0DDD0 Offset: 0x1F0CFD0 VA: 0x181F0DDD0
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1F0E580 Offset: 0x1F0D780 VA: 0x181F0E580
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x1F0DF30 Offset: 0x1F0D130 VA: 0x181F0DF30
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x1F11D50 Offset: 0x1F10F50 VA: 0x181F11D50
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1F13770 Offset: 0x1F12970 VA: 0x181F13770
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1F11A10 Offset: 0x1F10C10 VA: 0x181F11A10
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x1F11C30 Offset: 0x1F10E30 VA: 0x181F11C30
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1F12F80 Offset: 0x1F12180 VA: 0x181F12F80
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x1F13920 Offset: 0x1F12B20 VA: 0x181F13920
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x1F12B70 Offset: 0x1F11D70 VA: 0x181F12B70
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x1F133C0 Offset: 0x1F125C0 VA: 0x181F133C0
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1F15820 Offset: 0x1F14A20 VA: 0x181F15820
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1F121B0 Offset: 0x1F113B0 VA: 0x181F121B0
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x1F131E0 Offset: 0x1F123E0 VA: 0x181F131E0
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1F13CE0 Offset: 0x1F12EE0 VA: 0x181F13CE0
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x1F13EF0 Offset: 0x1F130F0 VA: 0x181F13EF0
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1F11ED0 Offset: 0x1F110D0 VA: 0x181F11ED0
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x1F17480 Offset: 0x1F16680 VA: 0x181F17480
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1F176F0 Offset: 0x1F168F0 VA: 0x181F176F0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1F179E0 Offset: 0x1F16BE0 VA: 0x181F179E0
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x1F17300 Offset: 0x1F16500 VA: 0x181F17300
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x1F10AC0 Offset: 0x1F0FCC0 VA: 0x181F10AC0
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0x1F10750 Offset: 0x1F0F950 VA: 0x181F10750
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x1F17350 Offset: 0x1F16550 VA: 0x181F17350
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x1F11820 Offset: 0x1F10A20 VA: 0x181F11820
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x1F11990 Offset: 0x1F10B90 VA: 0x181F11990
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: 
internal enum SchemaAttDef.Reserve // TypeDefIndex: 12349
{
	// Fields
	public int value__; // 0x0
	public const SchemaAttDef.Reserve None = 0;
	public const SchemaAttDef.Reserve XmlSpace = 1;
	public const SchemaAttDef.Reserve XmlLang = 2;
}

// Namespace: System.Xml.Schema
internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo // TypeDefIndex: 12350
{
	// Fields
	private string defExpanded; // 0x60
	private int lineNum; // 0x68
	private int linePos; // 0x6C
	private int valueLineNum; // 0x70
	private int valueLinePos; // 0x74
	private SchemaAttDef.Reserve reserved; // 0x78
	private bool defaultValueChecked; // 0x7C
	private XmlSchemaAttribute schemaAttribute; // 0x80
	public static readonly SchemaAttDef Empty; // 0x0

	// Properties
	private string System.Xml.IDtdAttributeInfo.Prefix { get; }
	private string System.Xml.IDtdAttributeInfo.LocalName { get; }
	private int System.Xml.IDtdAttributeInfo.LineNumber { get; }
	private int System.Xml.IDtdAttributeInfo.LinePosition { get; }
	private bool System.Xml.IDtdAttributeInfo.IsNonCDataType { get; }
	private bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdAttributeInfo.IsXmlAttribute { get; }
	private string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded { get; }
	private object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition { get; }
	internal int LinePosition { get; set; }
	internal int LineNumber { get; set; }
	internal int ValueLinePosition { get; set; }
	internal int ValueLineNumber { get; set; }
	internal string DefaultValueExpanded { get; set; }
	internal XmlTokenizedType TokenizedType { get; set; }
	internal SchemaAttDef.Reserve Reserved { get; set; }
	internal bool DefaultValueChecked { get; }
	internal XmlSchemaAttribute SchemaAttribute { get; set; }

	// Methods

	// RVA: 0x1F22A50 Offset: 0x1F21C50 VA: 0x181F22A50
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1F22A40 Offset: 0x1F21C40 VA: 0x181F22A40
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0x1F22A60 Offset: 0x1F21C60 VA: 0x181F22A60
	private void .ctor() { }

	// RVA: 0x1F22980 Offset: 0x1F21B80 VA: 0x181F22980 Slot: 8
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0 Slot: 9
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80 Slot: 10
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x526CA0 Offset: 0x525EA0 VA: 0x180526CA0 Slot: 11
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0x1F22940 Offset: 0x1F21B40 VA: 0x181F22940 Slot: 12
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0 Slot: 13
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x1F22970 Offset: 0x1F21B70 VA: 0x181F22970 Slot: 14
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0x1F22990 Offset: 0x1F21B90 VA: 0x181F22990 Slot: 4
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 5
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0 Slot: 6
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90 Slot: 7
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x526CA0 Offset: 0x525EA0 VA: 0x180526CA0
	internal int get_LinePosition() { }

	// RVA: 0x526DA0 Offset: 0x525FA0 VA: 0x180526DA0
	internal void set_LinePosition(int value) { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80
	internal int get_LineNumber() { }

	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	internal void set_LineNumber(int value) { }

	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90
	internal int get_ValueLinePosition() { }

	// RVA: 0x526D90 Offset: 0x525F90 VA: 0x180526D90
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	internal int get_ValueLineNumber() { }

	// RVA: 0x526DC0 Offset: 0x525FC0 VA: 0x180526DC0
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0x1F22A70 Offset: 0x1F21C70 VA: 0x181F22A70
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0x1F22AC0 Offset: 0x1F21CC0 VA: 0x181F22AC0
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1F22AF0 Offset: 0x1F21CF0 VA: 0x181F22AF0
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990
	internal SchemaAttDef.Reserve get_Reserved() { }

	// RVA: 0x4EDD40 Offset: 0x4ECF40 VA: 0x1804EDD40
	internal void set_Reserved(SchemaAttDef.Reserve value) { }

	// RVA: 0x1701E00 Offset: 0x1701000 VA: 0x181701E00
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x1F22620 Offset: 0x1F21820 VA: 0x181F22620
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0x1F228E0 Offset: 0x1F21AE0 VA: 0x181F228E0
	internal SchemaAttDef Clone() { }

	// RVA: 0x1F229E0 Offset: 0x1F21BE0 VA: 0x181F229E0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class SchemaBuilder // TypeDefIndex: 12351
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool ProcessElement(string prefix, string name, string ns);

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void ProcessAttribute(string prefix, string name, string ns, string value);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool IsContentParsed();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void ProcessMarkup(XmlNode[] markup);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void ProcessCData(string value);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void StartChildren();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract void EndChildren();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionCompiler : BaseProcessor // TypeDefIndex: 12352
{
	// Fields
	private bool compileContentModel; // 0x40
	private XmlSchemaObjectTable examplars; // 0x48
	private Stack complexTypeStack; // 0x50
	private XmlSchema schema; // 0x58

	// Methods

	// RVA: 0x1F34F60 Offset: 0x1F34160 VA: 0x181F34F60
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0x1F317A0 Offset: 0x1F309A0 VA: 0x181F317A0
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0x1F34BF0 Offset: 0x1F33DF0 VA: 0x181F34BF0
	private void Prepare() { }

	// RVA: 0x1F26FB0 Offset: 0x1F261B0 VA: 0x181F26FB0
	private void Cleanup() { }

	// RVA: 0x1F27C60 Offset: 0x1F26E60 VA: 0x181F27C60
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0x1F2FB40 Offset: 0x1F2ED40 VA: 0x181F2FB40
	private void Compile() { }

	// RVA: 0x1F33F00 Offset: 0x1F33100 VA: 0x181F33F00
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x1F263F0 Offset: 0x1F255F0 VA: 0x181F263F0
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1F263A0 Offset: 0x1F255A0 VA: 0x181F263A0
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1F26530 Offset: 0x1F25730 VA: 0x181F26530
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F26F90 Offset: 0x1F26190 VA: 0x181F26F90
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1F26A90 Offset: 0x1F25C90 VA: 0x181F26A90
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x1F26430 Offset: 0x1F25630 VA: 0x181F26430
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1F26CD0 Offset: 0x1F25ED0 VA: 0x181F26CD0
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x1F26D00 Offset: 0x1F25F00 VA: 0x181F26D00
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1F2F590 Offset: 0x1F2E790 VA: 0x181F2F590
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0x1F25FF0 Offset: 0x1F251F0 VA: 0x181F25FF0
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x1F2CA50 Offset: 0x1F2BC50 VA: 0x181F2CA50
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1F2EC70 Offset: 0x1F2DE70 VA: 0x181F2EC70
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1F297B0 Offset: 0x1F289B0 VA: 0x181F297B0
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1F26250 Offset: 0x1F25450 VA: 0x181F26250
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x1F2AEE0 Offset: 0x1F2A0E0 VA: 0x181F2AEE0
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F2E5B0 Offset: 0x1F2D7B0 VA: 0x181F2E5B0
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1F2E850 Offset: 0x1F2DA50 VA: 0x181F2E850
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1F29C90 Offset: 0x1F28E90 VA: 0x181F29C90
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x1F2A160 Offset: 0x1F29360 VA: 0x181F2A160
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1F25EA0 Offset: 0x1F250A0 VA: 0x181F25EA0
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F2B9C0 Offset: 0x1F2ABC0 VA: 0x181F2B9C0
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0x1F254D0 Offset: 0x1F246D0 VA: 0x181F254D0
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0x1F24C00 Offset: 0x1F23E00 VA: 0x181F24C00
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0x1F24DC0 Offset: 0x1F23FC0 VA: 0x181F24DC0
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0x1F23FE0 Offset: 0x1F231E0 VA: 0x181F23FE0
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0x1F245C0 Offset: 0x1F237C0 VA: 0x181F245C0
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0x1F258D0 Offset: 0x1F24AD0 VA: 0x181F258D0
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0x1F331B0 Offset: 0x1F323B0 VA: 0x181F331B0
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1F31EB0 Offset: 0x1F310B0 VA: 0x181F31EB0
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x1F31E40 Offset: 0x1F31040 VA: 0x181F31E40
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x1F31DE0 Offset: 0x1F30FE0 VA: 0x181F31DE0
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x1F32390 Offset: 0x1F31590 VA: 0x181F32390
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x1F31FF0 Offset: 0x1F311F0 VA: 0x181F31FF0
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1F32660 Offset: 0x1F31860 VA: 0x181F32660
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1F329C0 Offset: 0x1F31BC0 VA: 0x181F329C0
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x1F32D00 Offset: 0x1F31F00 VA: 0x181F32D00
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1F23BA0 Offset: 0x1F22DA0 VA: 0x181F23BA0
	private void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1F330A0 Offset: 0x1F322A0 VA: 0x181F330A0
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1F32FD0 Offset: 0x1F321D0 VA: 0x181F32FD0
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x1F31AD0 Offset: 0x1F30CD0 VA: 0x181F31AD0
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x1F32910 Offset: 0x1F31B10 VA: 0x181F32910
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x1F23260 Offset: 0x1F22460 VA: 0x181F23260
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1F34F30 Offset: 0x1F34130 VA: 0x181F34F30
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F31BF0 Offset: 0x1F30DF0 VA: 0x181F31BF0
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1F28660 Offset: 0x1F27860 VA: 0x181F28660
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1F2D220 Offset: 0x1F2C420 VA: 0x181F2D220
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x1F285B0 Offset: 0x1F277B0 VA: 0x181F285B0
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1F28500 Offset: 0x1F27700 VA: 0x181F28500
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1F28C70 Offset: 0x1F27E70 VA: 0x181F28C70
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x1F2CB30 Offset: 0x1F2BD30 VA: 0x181F2CB30
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x1F2BB90 Offset: 0x1F2AD90 VA: 0x181F2BB90
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x1F2A4C0 Offset: 0x1F296C0 VA: 0x181F2A4C0
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F22B10 Offset: 0x1F21D10 VA: 0x181F22B10
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x1F2E1C0 Offset: 0x1F2D3C0 VA: 0x181F2E1C0
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x1F29BC0 Offset: 0x1F28DC0 VA: 0x181F29BC0
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F31C70 Offset: 0x1F30E70 VA: 0x181F31C70
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x1F31A10 Offset: 0x1F30C10 VA: 0x181F31A10
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x1F31810 Offset: 0x1F30A10 VA: 0x181F31810
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }
}

// Namespace: 
private enum SchemaCollectionPreprocessor.Compositor // TypeDefIndex: 12353
{
	// Fields
	public int value__; // 0x0
	public const SchemaCollectionPreprocessor.Compositor Root = 0;
	public const SchemaCollectionPreprocessor.Compositor Include = 1;
	public const SchemaCollectionPreprocessor.Compositor Import = 2;
}

// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionPreprocessor : BaseProcessor // TypeDefIndex: 12354
{
	// Fields
	private XmlSchema schema; // 0x40
	private string targetNamespace; // 0x48
	private bool buildinIncluded; // 0x50
	private XmlSchemaForm elementFormDefault; // 0x54
	private XmlSchemaForm attributeFormDefault; // 0x58
	private XmlSchemaDerivationMethod blockDefault; // 0x5C
	private XmlSchemaDerivationMethod finalDefault; // 0x60
	private Hashtable schemaLocations; // 0x68
	private Hashtable referenceNamespaces; // 0x70
	private string Xmlns; // 0x78
	private XmlResolver xmlResolver; // 0x80

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x1F3D8B0 Offset: 0x1F3CAB0 VA: 0x181F3D8B0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1F36150 Offset: 0x1F35350 VA: 0x181F36150
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0x1F35B90 Offset: 0x1F34D90 VA: 0x181F35B90
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1F36490 Offset: 0x1F35690 VA: 0x181F36490
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0x1F35010 Offset: 0x1F34210 VA: 0x181F35010
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x1F3B810 Offset: 0x1F3AA10 VA: 0x181F3B810
	private void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor) { }

	// RVA: 0x1F39FB0 Offset: 0x1F391B0 VA: 0x181F39FB0
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0x1F35E60 Offset: 0x1F35060 VA: 0x181F35E60
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0x1F35950 Offset: 0x1F34B50 VA: 0x181F35950
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x1F35250 Offset: 0x1F34450 VA: 0x181F35250
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1F359E0 Offset: 0x1F34BE0 VA: 0x181F359E0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x1F353B0 Offset: 0x1F345B0 VA: 0x181F353B0
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x1F37460 Offset: 0x1F36660 VA: 0x181F37460
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1F38E60 Offset: 0x1F38060 VA: 0x181F38E60
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1F37110 Offset: 0x1F36310 VA: 0x181F37110
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x1F37340 Offset: 0x1F36540 VA: 0x181F37340
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1F38670 Offset: 0x1F37870 VA: 0x181F38670
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x1F39010 Offset: 0x1F38210 VA: 0x181F39010
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x1F38220 Offset: 0x1F37420 VA: 0x181F38220
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x1F38AB0 Offset: 0x1F37CB0 VA: 0x181F38AB0
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1F3B100 Offset: 0x1F3A300 VA: 0x181F3B100
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1F37860 Offset: 0x1F36A60 VA: 0x181F37860
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x1F388D0 Offset: 0x1F37AD0 VA: 0x181F388D0
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1F393D0 Offset: 0x1F385D0 VA: 0x181F393D0
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x1F395C0 Offset: 0x1F387C0 VA: 0x181F395C0
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1F375E0 Offset: 0x1F367E0 VA: 0x181F375E0
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x1F3D280 Offset: 0x1F3C480 VA: 0x181F3D280
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1F3D4A0 Offset: 0x1F3C6A0 VA: 0x181F3D4A0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1F3D790 Offset: 0x1F3C990 VA: 0x181F3D790
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x1F17350 Offset: 0x1F16550 VA: 0x181F17350
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x1F37010 Offset: 0x1F36210 VA: 0x181F37010
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x1F3D230 Offset: 0x1F3C430 VA: 0x181F3D230
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x1F363C0 Offset: 0x1F355C0 VA: 0x181F363C0
	private Stream GetSchemaEntity(Uri ruri) { }
}

// Namespace: 
internal enum SchemaDeclBase.Use // TypeDefIndex: 12355
{
	// Fields
	public int value__; // 0x0
	public const SchemaDeclBase.Use Default = 0;
	public const SchemaDeclBase.Use Required = 1;
	public const SchemaDeclBase.Use Implied = 2;
	public const SchemaDeclBase.Use Fixed = 3;
	public const SchemaDeclBase.Use RequiredFixed = 4;
}

// Namespace: System.Xml.Schema
internal abstract class SchemaDeclBase // TypeDefIndex: 12356
{
	// Fields
	protected XmlQualifiedName name; // 0x10
	protected string prefix; // 0x18
	protected bool isDeclaredInExternal; // 0x20
	protected SchemaDeclBase.Use presence; // 0x24
	protected XmlSchemaType schemaType; // 0x28
	protected XmlSchemaDatatype datatype; // 0x30
	protected string defaultValueRaw; // 0x38
	protected object defaultValueTyped; // 0x40
	protected long maxLength; // 0x48
	protected long minLength; // 0x50
	protected List<string> values; // 0x58

	// Properties
	internal XmlQualifiedName Name { get; set; }
	internal string Prefix { get; set; }
	internal bool IsDeclaredInExternal { get; set; }
	internal SchemaDeclBase.Use Presence { get; set; }
	internal long MaxLength { get; set; }
	internal long MinLength { get; set; }
	internal XmlSchemaType SchemaType { get; set; }
	internal XmlSchemaDatatype Datatype { get; set; }
	internal List<string> Values { get; set; }
	internal string DefaultValueRaw { get; set; }
	internal object DefaultValueTyped { get; set; }

	// Methods

	// RVA: 0x1F52C10 Offset: 0x1F51E10 VA: 0x181F52C10
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1F52CB0 Offset: 0x1F51EB0 VA: 0x181F52CB0
	protected void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0x1F52D70 Offset: 0x1F51F70 VA: 0x181F52D70
	internal string get_Prefix() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_Prefix(string value) { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	internal SchemaDeclBase.Use get_Presence() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	internal void set_Presence(SchemaDeclBase.Use value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal long get_MaxLength() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	internal void set_MaxLength(long value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal long get_MinLength() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	internal void set_MinLength(long value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0x1F529F0 Offset: 0x1F51BF0 VA: 0x181F529F0
	internal void AddValue(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal List<string> get_Values() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	internal void set_Values(List<string> value) { }

	// RVA: 0x1F52D20 Offset: 0x1F51F20 VA: 0x181F52D20
	internal string get_DefaultValueRaw() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal object get_DefaultValueTyped() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0x1F52AE0 Offset: 0x1F51CE0 VA: 0x181F52AE0
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0x1F52BB0 Offset: 0x1F51DB0 VA: 0x181F52BB0
	internal bool CheckValue(object pVal) { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo // TypeDefIndex: 12357
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; // 0x60
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; // 0x68
	private bool isIdDeclared; // 0x70
	private bool hasNonCDataAttribute; // 0x71
	private bool isAbstract; // 0x72
	private bool isNillable; // 0x73
	private bool hasRequiredAttribute; // 0x74
	private bool isNotationDeclared; // 0x75
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; // 0x78
	private ContentValidator contentValidator; // 0x80
	private XmlSchemaAnyAttribute anyAttribute; // 0x88
	private XmlSchemaDerivationMethod block; // 0x90
	private CompiledIdentityConstraint[] constraints; // 0x98
	private XmlSchemaElement schemaElement; // 0xA0
	internal static readonly SchemaElementDecl Empty; // 0x0

	// Properties
	private bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes { get; }
	internal bool IsIdDeclared { get; set; }
	internal bool HasNonCDataAttribute { get; set; }
	internal bool IsAbstract { get; set; }
	internal bool IsNillable { get; set; }
	internal XmlSchemaDerivationMethod Block { get; set; }
	internal bool IsNotationDeclared { get; set; }
	internal bool HasDefaultAttribute { get; }
	internal bool HasRequiredAttribute { get; }
	internal ContentValidator ContentValidator { get; set; }
	internal XmlSchemaAnyAttribute AnyAttribute { get; set; }
	internal CompiledIdentityConstraint[] Constraints { get; set; }
	internal XmlSchemaElement SchemaElement { get; set; }
	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs { get; }
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes { get; }

	// Methods

	// RVA: 0x1F536A0 Offset: 0x1F528A0 VA: 0x181F536A0
	internal void .ctor() { }

	// RVA: 0x1F53430 Offset: 0x1F52630 VA: 0x181F53430
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0x1F53570 Offset: 0x1F52770 VA: 0x181F53570
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1F531E0 Offset: 0x1F523E0 VA: 0x181F531E0
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0x53DC80 Offset: 0x53CE80 VA: 0x18053DC80 Slot: 4
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x1F53320 Offset: 0x1F52520 VA: 0x181F53320 Slot: 5
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 6
	private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0x6167C0 Offset: 0x6159C0 VA: 0x1806167C0
	internal bool get_IsIdDeclared() { }

	// RVA: 0x1826DA0 Offset: 0x1825FA0 VA: 0x181826DA0
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0x53DC80 Offset: 0x53CE80 VA: 0x18053DC80
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0x1826FC0 Offset: 0x18261C0 VA: 0x181826FC0
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0x1F53180 Offset: 0x1F52380 VA: 0x181F53180
	internal SchemaElementDecl Clone() { }

	// RVA: 0x8CA2B0 Offset: 0x8C94B0 VA: 0x1808CA2B0
	internal bool get_IsAbstract() { }

	// RVA: 0x1F537A0 Offset: 0x1F529A0 VA: 0x181F537A0
	internal void set_IsAbstract(bool value) { }

	// RVA: 0x8CA300 Offset: 0x8C9500 VA: 0x1808CA300
	internal bool get_IsNillable() { }

	// RVA: 0x1F537B0 Offset: 0x1F529B0 VA: 0x181F537B0
	internal void set_IsNillable(bool value) { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0xB80190 Offset: 0xB7F390 VA: 0x180B80190
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x8CA280 Offset: 0x8C9480 VA: 0x1808CA280
	internal bool get_IsNotationDeclared() { }

	// RVA: 0x1C44C50 Offset: 0x1C43E50 VA: 0x181C44C50
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0x1F53790 Offset: 0x1F52990 VA: 0x181F53790
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0x8CA2F0 Offset: 0x8C94F0 VA: 0x1808CA2F0
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x1F52DC0 Offset: 0x1F51FC0 VA: 0x181F52DC0
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0x1F532A0 Offset: 0x1F524A0 VA: 0x181F532A0
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0x1F52F00 Offset: 0x1F52100 VA: 0x181F52F00
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0x1F533D0 Offset: 0x1F525D0 VA: 0x181F533D0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaEntity : IDtdEntityInfo // TypeDefIndex: 12358
{
	// Fields
	private XmlQualifiedName qname; // 0x10
	private string url; // 0x18
	private string pubid; // 0x20
	private string text; // 0x28
	private XmlQualifiedName ndata; // 0x30
	private int lineNumber; // 0x38
	private int linePosition; // 0x3C
	private bool isParameter; // 0x40
	private bool isExternal; // 0x41
	private bool parsingInProgress; // 0x42
	private bool isDeclaredInExternal; // 0x43
	private string baseURI; // 0x48
	private string declaredURI; // 0x50

	// Properties
	private string System.Xml.IDtdEntityInfo.Name { get; }
	private bool System.Xml.IDtdEntityInfo.IsExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsUnparsedEntity { get; }
	private bool System.Xml.IDtdEntityInfo.IsParameterEntity { get; }
	private string System.Xml.IDtdEntityInfo.BaseUriString { get; }
	private string System.Xml.IDtdEntityInfo.DeclaredUriString { get; }
	private string System.Xml.IDtdEntityInfo.SystemId { get; }
	private string System.Xml.IDtdEntityInfo.PublicId { get; }
	private string System.Xml.IDtdEntityInfo.Text { get; }
	private int System.Xml.IDtdEntityInfo.LineNumber { get; }
	private int System.Xml.IDtdEntityInfo.LinePosition { get; }
	internal XmlQualifiedName Name { get; }
	internal string Url { get; set; }
	internal string Pubid { get; set; }
	internal bool IsExternal { get; set; }
	internal bool DeclaredInExternal { get; set; }
	internal XmlQualifiedName NData { get; set; }
	internal string Text { get; set; }
	internal int Line { get; set; }
	internal int Pos { get; set; }
	internal string BaseURI { get; set; }
	internal bool ParsingInProgress { get; set; }
	internal string DeclaredURI { get; set; }

	// Methods

	// RVA: 0x1F53960 Offset: 0x1F52B60 VA: 0x181F53960
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0 Slot: 4
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0x7724A0 Offset: 0x7716A0 VA: 0x1807724A0 Slot: 5
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0x772500 Offset: 0x771700 VA: 0x180772500 Slot: 6
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x1F53930 Offset: 0x1F52B30 VA: 0x181F53930 Slot: 7
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0 Slot: 8
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0x1F53890 Offset: 0x1F52A90 VA: 0x181F53890 Slot: 9
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0x1F538E0 Offset: 0x1F52AE0 VA: 0x181F538E0 Slot: 10
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 11
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 12
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 13
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 14
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 15
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0x1F537C0 Offset: 0x1F529C0 VA: 0x181F537C0
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string get_Url() { }

	// RVA: 0x1F53AA0 Offset: 0x1F52CA0 VA: 0x181F53AA0
	internal void set_Url(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal string get_Pubid() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_Pubid(string value) { }

	// RVA: 0x7724A0 Offset: 0x7716A0 VA: 0x1807724A0
	internal bool get_IsExternal() { }

	// RVA: 0x1C44C10 Offset: 0x1C43E10 VA: 0x181C44C10
	internal void set_IsExternal(bool value) { }

	// RVA: 0x772500 Offset: 0x771700 VA: 0x180772500
	internal bool get_DeclaredInExternal() { }

	// RVA: 0x1C44C20 Offset: 0x1C43E20 VA: 0x181C44C20
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal string get_Text() { }

	// RVA: 0x1F53A90 Offset: 0x1F52C90 VA: 0x181F53A90
	internal void set_Text(string value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	internal int get_Line() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	internal void set_Line(int value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	internal int get_Pos() { }

	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70
	internal void set_Pos(int value) { }

	// RVA: 0x1F539F0 Offset: 0x1F52BF0 VA: 0x181F539F0
	internal string get_BaseURI() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	internal void set_BaseURI(string value) { }

	// RVA: 0x6F90C0 Offset: 0x6F82C0 VA: 0x1806F90C0
	internal bool get_ParsingInProgress() { }

	// RVA: 0x1C44C00 Offset: 0x1C43E00 VA: 0x181C44C00
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0x1F53A40 Offset: 0x1F52C40 VA: 0x181F53A40
	internal string get_DeclaredURI() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	internal void set_DeclaredURI(string value) { }
}

// Namespace: System.Xml.Schema
internal enum AttributeMatchState // TypeDefIndex: 12359
{
	// Fields
	public int value__; // 0x0
	public const AttributeMatchState AttributeFound = 0;
	public const AttributeMatchState AnyIdAttributeFound = 1;
	public const AttributeMatchState UndeclaredElementAndAttribute = 2;
	public const AttributeMatchState UndeclaredAttribute = 3;
	public const AttributeMatchState AnyAttributeLax = 4;
	public const AttributeMatchState AnyAttributeSkip = 5;
	public const AttributeMatchState ProhibitedAnyAttribute = 6;
	public const AttributeMatchState ProhibitedAttribute = 7;
	public const AttributeMatchState AttributeNameMismatch = 8;
	public const AttributeMatchState ValidateAttributeInvalidCall = 9;
}

// Namespace: System.Xml.Schema
internal class SchemaInfo : IDtdInfo // TypeDefIndex: 12360
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; // 0x10
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; // 0x18
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; // 0x20
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; // 0x28
	private XmlQualifiedName docTypeName; // 0x30
	private string internalDtdSubset; // 0x38
	private bool hasNonCDataAttributes; // 0x40
	private bool hasDefaultAttributes; // 0x41
	private Dictionary<string, bool> targetNamespaces; // 0x48
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; // 0x50
	private int errorCount; // 0x58
	private SchemaType schemaType; // 0x5C
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; // 0x60
	private Dictionary<string, SchemaNotation> notations; // 0x68

	// Properties
	public XmlQualifiedName DocTypeName { get; set; }
	internal string InternalDtdSubset { set; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities { get; }
	internal SchemaType SchemaType { get; set; }
	internal Dictionary<string, bool> TargetNamespaces { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls { get; }
	internal Dictionary<string, SchemaNotation> Notations { get; }
	internal int ErrorCount { get; set; }
	private bool System.Xml.IDtdInfo.HasDefaultAttributes { get; }
	private bool System.Xml.IDtdInfo.HasNonCDataAttributes { get; }
	private XmlQualifiedName System.Xml.IDtdInfo.Name { get; }
	private string System.Xml.IDtdInfo.InternalDtdSubset { get; }

	// Methods

	// RVA: 0x1F54F10 Offset: 0x1F54110 VA: 0x181F54F10
	internal void .ctor() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0x1F550A0 Offset: 0x1F542A0 VA: 0x181F550A0
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	// RVA: 0x1F551A0 Offset: 0x1F543A0 VA: 0x181F551A0
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10
	internal SchemaType get_SchemaType() { }

	// RVA: 0x4EDE90 Offset: 0x4ED090 VA: 0x1804EDE90
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal Dictionary<string, bool> get_TargetNamespaces() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0x1F55120 Offset: 0x1F54320 VA: 0x181F55120
	internal Dictionary<string, SchemaNotation> get_Notations() { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	internal int get_ErrorCount() { }

	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	internal void set_ErrorCount(int value) { }

	// RVA: 0x1F54B80 Offset: 0x1F53D80 VA: 0x181F54B80
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0x1F54C90 Offset: 0x1F53E90 VA: 0x181F54C90
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0x1F54C00 Offset: 0x1F53E00 VA: 0x181F54C00
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0x1F54D10 Offset: 0x1F53F10 VA: 0x181F54D10
	internal bool HasSchema(string ns) { }

	// RVA: 0x1F543F0 Offset: 0x1F535F0 VA: 0x181F543F0
	internal bool Contains(string ns) { }

	// RVA: 0x1F545E0 Offset: 0x1F537E0 VA: 0x181F545E0
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0x1F548F0 Offset: 0x1F53AF0 VA: 0x181F548F0
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	// RVA: 0x1F547A0 Offset: 0x1F539A0 VA: 0x181F547A0
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	// RVA: 0x1F53AB0 Offset: 0x1F52CB0 VA: 0x181F53AB0
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0x1F54450 Offset: 0x1F53650 VA: 0x181F54450
	internal void Finish() { }

	// RVA: 0x7724A0 Offset: 0x7716A0 VA: 0x1807724A0 Slot: 6
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0 Slot: 7
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x1F54D70 Offset: 0x1F53F70 VA: 0x181F54D70 Slot: 8
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x1F54E40 Offset: 0x1F54040 VA: 0x181F54E40 Slot: 9
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 4
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 5
	private string System.Xml.IDtdInfo.get_InternalDtdSubset() { }
}

// Namespace: 
public enum SchemaNames.Token // TypeDefIndex: 12361
{
	// Fields
	public int value__; // 0x0
	public const SchemaNames.Token Empty = 0;
	public const SchemaNames.Token SchemaName = 1;
	public const SchemaNames.Token SchemaType = 2;
	public const SchemaNames.Token SchemaMaxOccurs = 3;
	public const SchemaNames.Token SchemaMinOccurs = 4;
	public const SchemaNames.Token SchemaInfinite = 5;
	public const SchemaNames.Token SchemaModel = 6;
	public const SchemaNames.Token SchemaOpen = 7;
	public const SchemaNames.Token SchemaClosed = 8;
	public const SchemaNames.Token SchemaContent = 9;
	public const SchemaNames.Token SchemaMixed = 10;
	public const SchemaNames.Token SchemaEmpty = 11;
	public const SchemaNames.Token SchemaElementOnly = 12;
	public const SchemaNames.Token SchemaTextOnly = 13;
	public const SchemaNames.Token SchemaOrder = 14;
	public const SchemaNames.Token SchemaSeq = 15;
	public const SchemaNames.Token SchemaOne = 16;
	public const SchemaNames.Token SchemaMany = 17;
	public const SchemaNames.Token SchemaRequired = 18;
	public const SchemaNames.Token SchemaYes = 19;
	public const SchemaNames.Token SchemaNo = 20;
	public const SchemaNames.Token SchemaString = 21;
	public const SchemaNames.Token SchemaId = 22;
	public const SchemaNames.Token SchemaIdref = 23;
	public const SchemaNames.Token SchemaIdrefs = 24;
	public const SchemaNames.Token SchemaEntity = 25;
	public const SchemaNames.Token SchemaEntities = 26;
	public const SchemaNames.Token SchemaNmtoken = 27;
	public const SchemaNames.Token SchemaNmtokens = 28;
	public const SchemaNames.Token SchemaEnumeration = 29;
	public const SchemaNames.Token SchemaDefault = 30;
	public const SchemaNames.Token XdrRoot = 31;
	public const SchemaNames.Token XdrElementType = 32;
	public const SchemaNames.Token XdrElement = 33;
	public const SchemaNames.Token XdrGroup = 34;
	public const SchemaNames.Token XdrAttributeType = 35;
	public const SchemaNames.Token XdrAttribute = 36;
	public const SchemaNames.Token XdrDatatype = 37;
	public const SchemaNames.Token XdrDescription = 38;
	public const SchemaNames.Token XdrExtends = 39;
	public const SchemaNames.Token SchemaXdrRootAlias = 40;
	public const SchemaNames.Token SchemaDtType = 41;
	public const SchemaNames.Token SchemaDtValues = 42;
	public const SchemaNames.Token SchemaDtMaxLength = 43;
	public const SchemaNames.Token SchemaDtMinLength = 44;
	public const SchemaNames.Token SchemaDtMax = 45;
	public const SchemaNames.Token SchemaDtMin = 46;
	public const SchemaNames.Token SchemaDtMinExclusive = 47;
	public const SchemaNames.Token SchemaDtMaxExclusive = 48;
	public const SchemaNames.Token SchemaTargetNamespace = 49;
	public const SchemaNames.Token SchemaVersion = 50;
	public const SchemaNames.Token SchemaFinalDefault = 51;
	public const SchemaNames.Token SchemaBlockDefault = 52;
	public const SchemaNames.Token SchemaFixed = 53;
	public const SchemaNames.Token SchemaAbstract = 54;
	public const SchemaNames.Token SchemaBlock = 55;
	public const SchemaNames.Token SchemaSubstitutionGroup = 56;
	public const SchemaNames.Token SchemaFinal = 57;
	public const SchemaNames.Token SchemaNillable = 58;
	public const SchemaNames.Token SchemaRef = 59;
	public const SchemaNames.Token SchemaBase = 60;
	public const SchemaNames.Token SchemaDerivedBy = 61;
	public const SchemaNames.Token SchemaNamespace = 62;
	public const SchemaNames.Token SchemaProcessContents = 63;
	public const SchemaNames.Token SchemaRefer = 64;
	public const SchemaNames.Token SchemaPublic = 65;
	public const SchemaNames.Token SchemaSystem = 66;
	public const SchemaNames.Token SchemaSchemaLocation = 67;
	public const SchemaNames.Token SchemaValue = 68;
	public const SchemaNames.Token SchemaSource = 69;
	public const SchemaNames.Token SchemaAttributeFormDefault = 70;
	public const SchemaNames.Token SchemaElementFormDefault = 71;
	public const SchemaNames.Token SchemaUse = 72;
	public const SchemaNames.Token SchemaForm = 73;
	public const SchemaNames.Token XsdSchema = 74;
	public const SchemaNames.Token XsdAnnotation = 75;
	public const SchemaNames.Token XsdInclude = 76;
	public const SchemaNames.Token XsdImport = 77;
	public const SchemaNames.Token XsdElement = 78;
	public const SchemaNames.Token XsdAttribute = 79;
	public const SchemaNames.Token xsdAttributeGroup = 80;
	public const SchemaNames.Token XsdAnyAttribute = 81;
	public const SchemaNames.Token XsdGroup = 82;
	public const SchemaNames.Token XsdAll = 83;
	public const SchemaNames.Token XsdChoice = 84;
	public const SchemaNames.Token XsdSequence = 85;
	public const SchemaNames.Token XsdAny = 86;
	public const SchemaNames.Token XsdNotation = 87;
	public const SchemaNames.Token XsdSimpleType = 88;
	public const SchemaNames.Token XsdComplexType = 89;
	public const SchemaNames.Token XsdUnique = 90;
	public const SchemaNames.Token XsdKey = 91;
	public const SchemaNames.Token XsdKeyref = 92;
	public const SchemaNames.Token XsdSelector = 93;
	public const SchemaNames.Token XsdField = 94;
	public const SchemaNames.Token XsdMinExclusive = 95;
	public const SchemaNames.Token XsdMinInclusive = 96;
	public const SchemaNames.Token XsdMaxExclusive = 97;
	public const SchemaNames.Token XsdMaxInclusive = 98;
	public const SchemaNames.Token XsdTotalDigits = 99;
	public const SchemaNames.Token XsdFractionDigits = 100;
	public const SchemaNames.Token XsdLength = 101;
	public const SchemaNames.Token XsdMinLength = 102;
	public const SchemaNames.Token XsdMaxLength = 103;
	public const SchemaNames.Token XsdEnumeration = 104;
	public const SchemaNames.Token XsdPattern = 105;
	public const SchemaNames.Token XsdDocumentation = 106;
	public const SchemaNames.Token XsdAppInfo = 107;
	public const SchemaNames.Token XsdComplexContent = 108;
	public const SchemaNames.Token XsdComplexContentExtension = 109;
	public const SchemaNames.Token XsdComplexContentRestriction = 110;
	public const SchemaNames.Token XsdSimpleContent = 111;
	public const SchemaNames.Token XsdSimpleContentExtension = 112;
	public const SchemaNames.Token XsdSimpleContentRestriction = 113;
	public const SchemaNames.Token XsdSimpleTypeList = 114;
	public const SchemaNames.Token XsdSimpleTypeRestriction = 115;
	public const SchemaNames.Token XsdSimpleTypeUnion = 116;
	public const SchemaNames.Token XsdWhitespace = 117;
	public const SchemaNames.Token XsdRedefine = 118;
	public const SchemaNames.Token SchemaItemType = 119;
	public const SchemaNames.Token SchemaMemberTypes = 120;
	public const SchemaNames.Token SchemaXPath = 121;
	public const SchemaNames.Token XmlLang = 122;
}

// Namespace: System.Xml.Schema
internal sealed class SchemaNames // TypeDefIndex: 12362
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	public string NsDataType; // 0x18
	public string NsDataTypeAlias; // 0x20
	public string NsDataTypeOld; // 0x28
	public string NsXml; // 0x30
	public string NsXmlNs; // 0x38
	public string NsXdr; // 0x40
	public string NsXdrAlias; // 0x48
	public string NsXs; // 0x50
	public string NsXsi; // 0x58
	public string XsiType; // 0x60
	public string XsiNil; // 0x68
	public string XsiSchemaLocation; // 0x70
	public string XsiNoNamespaceSchemaLocation; // 0x78
	public string XsdSchema; // 0x80
	public string XdrSchema; // 0x88
	public XmlQualifiedName QnPCData; // 0x90
	public XmlQualifiedName QnXml; // 0x98
	public XmlQualifiedName QnXmlNs; // 0xA0
	public XmlQualifiedName QnDtDt; // 0xA8
	public XmlQualifiedName QnXmlLang; // 0xB0
	public XmlQualifiedName QnName; // 0xB8
	public XmlQualifiedName QnType; // 0xC0
	public XmlQualifiedName QnMaxOccurs; // 0xC8
	public XmlQualifiedName QnMinOccurs; // 0xD0
	public XmlQualifiedName QnInfinite; // 0xD8
	public XmlQualifiedName QnModel; // 0xE0
	public XmlQualifiedName QnOpen; // 0xE8
	public XmlQualifiedName QnClosed; // 0xF0
	public XmlQualifiedName QnContent; // 0xF8
	public XmlQualifiedName QnMixed; // 0x100
	public XmlQualifiedName QnEmpty; // 0x108
	public XmlQualifiedName QnEltOnly; // 0x110
	public XmlQualifiedName QnTextOnly; // 0x118
	public XmlQualifiedName QnOrder; // 0x120
	public XmlQualifiedName QnSeq; // 0x128
	public XmlQualifiedName QnOne; // 0x130
	public XmlQualifiedName QnMany; // 0x138
	public XmlQualifiedName QnRequired; // 0x140
	public XmlQualifiedName QnYes; // 0x148
	public XmlQualifiedName QnNo; // 0x150
	public XmlQualifiedName QnString; // 0x158
	public XmlQualifiedName QnID; // 0x160
	public XmlQualifiedName QnIDRef; // 0x168
	public XmlQualifiedName QnIDRefs; // 0x170
	public XmlQualifiedName QnEntity; // 0x178
	public XmlQualifiedName QnEntities; // 0x180
	public XmlQualifiedName QnNmToken; // 0x188
	public XmlQualifiedName QnNmTokens; // 0x190
	public XmlQualifiedName QnEnumeration; // 0x198
	public XmlQualifiedName QnDefault; // 0x1A0
	public XmlQualifiedName QnXdrSchema; // 0x1A8
	public XmlQualifiedName QnXdrElementType; // 0x1B0
	public XmlQualifiedName QnXdrElement; // 0x1B8
	public XmlQualifiedName QnXdrGroup; // 0x1C0
	public XmlQualifiedName QnXdrAttributeType; // 0x1C8
	public XmlQualifiedName QnXdrAttribute; // 0x1D0
	public XmlQualifiedName QnXdrDataType; // 0x1D8
	public XmlQualifiedName QnXdrDescription; // 0x1E0
	public XmlQualifiedName QnXdrExtends; // 0x1E8
	public XmlQualifiedName QnXdrAliasSchema; // 0x1F0
	public XmlQualifiedName QnDtType; // 0x1F8
	public XmlQualifiedName QnDtValues; // 0x200
	public XmlQualifiedName QnDtMaxLength; // 0x208
	public XmlQualifiedName QnDtMinLength; // 0x210
	public XmlQualifiedName QnDtMax; // 0x218
	public XmlQualifiedName QnDtMin; // 0x220
	public XmlQualifiedName QnDtMinExclusive; // 0x228
	public XmlQualifiedName QnDtMaxExclusive; // 0x230
	public XmlQualifiedName QnTargetNamespace; // 0x238
	public XmlQualifiedName QnVersion; // 0x240
	public XmlQualifiedName QnFinalDefault; // 0x248
	public XmlQualifiedName QnBlockDefault; // 0x250
	public XmlQualifiedName QnFixed; // 0x258
	public XmlQualifiedName QnAbstract; // 0x260
	public XmlQualifiedName QnBlock; // 0x268
	public XmlQualifiedName QnSubstitutionGroup; // 0x270
	public XmlQualifiedName QnFinal; // 0x278
	public XmlQualifiedName QnNillable; // 0x280
	public XmlQualifiedName QnRef; // 0x288
	public XmlQualifiedName QnBase; // 0x290
	public XmlQualifiedName QnDerivedBy; // 0x298
	public XmlQualifiedName QnNamespace; // 0x2A0
	public XmlQualifiedName QnProcessContents; // 0x2A8
	public XmlQualifiedName QnRefer; // 0x2B0
	public XmlQualifiedName QnPublic; // 0x2B8
	public XmlQualifiedName QnSystem; // 0x2C0
	public XmlQualifiedName QnSchemaLocation; // 0x2C8
	public XmlQualifiedName QnValue; // 0x2D0
	public XmlQualifiedName QnUse; // 0x2D8
	public XmlQualifiedName QnForm; // 0x2E0
	public XmlQualifiedName QnElementFormDefault; // 0x2E8
	public XmlQualifiedName QnAttributeFormDefault; // 0x2F0
	public XmlQualifiedName QnItemType; // 0x2F8
	public XmlQualifiedName QnMemberTypes; // 0x300
	public XmlQualifiedName QnXPath; // 0x308
	public XmlQualifiedName QnXsdSchema; // 0x310
	public XmlQualifiedName QnXsdAnnotation; // 0x318
	public XmlQualifiedName QnXsdInclude; // 0x320
	public XmlQualifiedName QnXsdImport; // 0x328
	public XmlQualifiedName QnXsdElement; // 0x330
	public XmlQualifiedName QnXsdAttribute; // 0x338
	public XmlQualifiedName QnXsdAttributeGroup; // 0x340
	public XmlQualifiedName QnXsdAnyAttribute; // 0x348
	public XmlQualifiedName QnXsdGroup; // 0x350
	public XmlQualifiedName QnXsdAll; // 0x358
	public XmlQualifiedName QnXsdChoice; // 0x360
	public XmlQualifiedName QnXsdSequence; // 0x368
	public XmlQualifiedName QnXsdAny; // 0x370
	public XmlQualifiedName QnXsdNotation; // 0x378
	public XmlQualifiedName QnXsdSimpleType; // 0x380
	public XmlQualifiedName QnXsdComplexType; // 0x388
	public XmlQualifiedName QnXsdUnique; // 0x390
	public XmlQualifiedName QnXsdKey; // 0x398
	public XmlQualifiedName QnXsdKeyRef; // 0x3A0
	public XmlQualifiedName QnXsdSelector; // 0x3A8
	public XmlQualifiedName QnXsdField; // 0x3B0
	public XmlQualifiedName QnXsdMinExclusive; // 0x3B8
	public XmlQualifiedName QnXsdMinInclusive; // 0x3C0
	public XmlQualifiedName QnXsdMaxInclusive; // 0x3C8
	public XmlQualifiedName QnXsdMaxExclusive; // 0x3D0
	public XmlQualifiedName QnXsdTotalDigits; // 0x3D8
	public XmlQualifiedName QnXsdFractionDigits; // 0x3E0
	public XmlQualifiedName QnXsdLength; // 0x3E8
	public XmlQualifiedName QnXsdMinLength; // 0x3F0
	public XmlQualifiedName QnXsdMaxLength; // 0x3F8
	public XmlQualifiedName QnXsdEnumeration; // 0x400
	public XmlQualifiedName QnXsdPattern; // 0x408
	public XmlQualifiedName QnXsdDocumentation; // 0x410
	public XmlQualifiedName QnXsdAppinfo; // 0x418
	public XmlQualifiedName QnSource; // 0x420
	public XmlQualifiedName QnXsdComplexContent; // 0x428
	public XmlQualifiedName QnXsdSimpleContent; // 0x430
	public XmlQualifiedName QnXsdRestriction; // 0x438
	public XmlQualifiedName QnXsdExtension; // 0x440
	public XmlQualifiedName QnXsdUnion; // 0x448
	public XmlQualifiedName QnXsdList; // 0x450
	public XmlQualifiedName QnXsdWhiteSpace; // 0x458
	public XmlQualifiedName QnXsdRedefine; // 0x460
	public XmlQualifiedName QnXsdAnyType; // 0x468
	internal XmlQualifiedName[] TokenToQName; // 0x470

	// Methods

	// RVA: 0x1F57CA0 Offset: 0x1F56EA0 VA: 0x181F57CA0
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1F55220 Offset: 0x1F54420 VA: 0x181F55220
	public void CreateTokenToQNameTable() { }

	// RVA: 0x1F57BE0 Offset: 0x1F56DE0 VA: 0x181F57BE0
	public SchemaType SchemaTypeFromRoot(string localName, string ns) { }

	// RVA: 0x1F57B90 Offset: 0x1F56D90 VA: 0x181F57B90
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1F57B40 Offset: 0x1F56D40 VA: 0x181F57B40
	public bool IsXDRRoot(string localName, string ns) { }
}

// Namespace: System.Xml.Schema
internal class SchemaNamespaceManager : XmlNamespaceManager // TypeDefIndex: 12363
{
	// Fields
	private XmlSchemaObject node; // 0x50

	// Methods

	// RVA: 0x1F5AB90 Offset: 0x1F59D90 VA: 0x181F5AB90
	public void .ctor(XmlSchemaObject node) { }

	// RVA: 0x1F5A7A0 Offset: 0x1F599A0 VA: 0x181F5A7A0 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1F5A900 Offset: 0x1F59B00 VA: 0x181F5A900 Slot: 17
	public override string LookupPrefix(string ns) { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaNotation // TypeDefIndex: 12364
{
	// Fields
	private XmlQualifiedName name; // 0x10
	private string systemLiteral; // 0x18
	private string pubid; // 0x20

	// Properties
	internal XmlQualifiedName Name { get; }
	internal string SystemLiteral { get; set; }
	internal string Pubid { get; set; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string get_SystemLiteral() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal string get_Pubid() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_Pubid(string value) { }
}

// Namespace: System.Xml.Schema
internal sealed class Compiler : BaseProcessor // TypeDefIndex: 12365
{
	// Fields
	private string restrictionErrorMsg; // 0x40
	private XmlSchemaObjectTable attributes; // 0x48
	private XmlSchemaObjectTable attributeGroups; // 0x50
	private XmlSchemaObjectTable elements; // 0x58
	private XmlSchemaObjectTable schemaTypes; // 0x60
	private XmlSchemaObjectTable groups; // 0x68
	private XmlSchemaObjectTable notations; // 0x70
	private XmlSchemaObjectTable examplars; // 0x78
	private XmlSchemaObjectTable identityConstraints; // 0x80
	private Stack complexTypeStack; // 0x88
	private Hashtable schemasToCompile; // 0x90
	private Hashtable importedSchemas; // 0x98
	private XmlSchema schemaForSchema; // 0xA0

	// Methods

	// RVA: 0x1F52800 Offset: 0x1F51A00 VA: 0x181F52800
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1F4BC40 Offset: 0x1F4AE40 VA: 0x181F4BC40
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0x1F50940 Offset: 0x1F4FB40 VA: 0x181F50940
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0x1F52680 Offset: 0x1F51880 VA: 0x181F52680
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0x1F4FAD0 Offset: 0x1F4ECD0 VA: 0x181F4FAD0
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x1F4C190 Offset: 0x1F4B390 VA: 0x181F4C190
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0x1F49EB0 Offset: 0x1F490B0 VA: 0x181F49EB0
	internal bool Compile() { }

	// RVA: 0x1F41980 Offset: 0x1F40B80 VA: 0x181F41980
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1F41900 Offset: 0x1F40B00 VA: 0x181F41900
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1F41B60 Offset: 0x1F40D60 VA: 0x181F41B60
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F42570 Offset: 0x1F41770 VA: 0x181F42570
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1F42040 Offset: 0x1F41240 VA: 0x181F42040
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x1F41A70 Offset: 0x1F40C70 VA: 0x181F41A70
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1F42310 Offset: 0x1F41510 VA: 0x181F42310
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x1F42370 Offset: 0x1F41570 VA: 0x181F42370
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1F51BB0 Offset: 0x1F50DB0 VA: 0x181F51BB0
	private void ProcessSubstitutionGroups() { }

	// RVA: 0x1F498B0 Offset: 0x1F48AB0 VA: 0x181F498B0
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x1F52330 Offset: 0x1F51530 VA: 0x181F52330
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0x1F522A0 Offset: 0x1F514A0 VA: 0x181F522A0
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0x1F46A30 Offset: 0x1F45C30 VA: 0x181F46A30
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1F48F60 Offset: 0x1F48160 VA: 0x181F48F60
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1F43800 Offset: 0x1F42A00 VA: 0x181F43800
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1F417B0 Offset: 0x1F409B0 VA: 0x181F417B0
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x1F44E80 Offset: 0x1F44080 VA: 0x181F44E80
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F488A0 Offset: 0x1F47AA0 VA: 0x181F488A0
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1F48B40 Offset: 0x1F47D40 VA: 0x181F48B40
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1F43C10 Offset: 0x1F42E10 VA: 0x181F43C10
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x1F44020 Offset: 0x1F43220 VA: 0x181F44020
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1F411A0 Offset: 0x1F403A0 VA: 0x181F411A0
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F416D0 Offset: 0x1F408D0 VA: 0x181F416D0
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1F458F0 Offset: 0x1F44AF0 VA: 0x181F458F0
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1F3FC90 Offset: 0x1F3EE90 VA: 0x181F3FC90
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0x1F3F270 Offset: 0x1F3E470 VA: 0x181F3F270
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0x1F3F540 Offset: 0x1F3E740 VA: 0x181F3F540
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0x1F3E8E0 Offset: 0x1F3DAE0 VA: 0x181F3E8E0
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0x1F3EBE0 Offset: 0x1F3DDE0 VA: 0x181F3EBE0
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0x1F403D0 Offset: 0x1F3F5D0 VA: 0x181F403D0
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0x1F40040 Offset: 0x1F3F240 VA: 0x181F40040
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0x1F4E810 Offset: 0x1F4DA10 VA: 0x181F4E810
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1F4C750 Offset: 0x1F4B950 VA: 0x181F4C750
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x1F4C570 Offset: 0x1F4B770 VA: 0x181F4C570
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x1F4C2B0 Offset: 0x1F4B4B0 VA: 0x181F4C2B0
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x1F4D530 Offset: 0x1F4C730 VA: 0x181F4D530
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x1F4C9A0 Offset: 0x1F4BBA0 VA: 0x181F4C9A0
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0x1F4C3B0 Offset: 0x1F4B5B0 VA: 0x181F4C3B0
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1F4D9D0 Offset: 0x1F4CBD0 VA: 0x181F4D9D0
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1F4DE80 Offset: 0x1F4D080 VA: 0x181F4DE80
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x1F4E1C0 Offset: 0x1F4D3C0 VA: 0x181F4E1C0
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1F4E700 Offset: 0x1F4D900 VA: 0x181F4E700
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1F4E630 Offset: 0x1F4D830 VA: 0x181F4E630
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x1F4BF70 Offset: 0x1F4B170 VA: 0x181F4BF70
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x1F4DCF0 Offset: 0x1F4CEF0 VA: 0x181F4DCF0
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x1F3E010 Offset: 0x1F3D210 VA: 0x181F3E010
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1F52270 Offset: 0x1F51470 VA: 0x181F52270
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F31BF0 Offset: 0x1F30DF0 VA: 0x181F31BF0
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1F427A0 Offset: 0x1F419A0 VA: 0x181F427A0
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1F471E0 Offset: 0x1F463E0 VA: 0x181F471E0
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x1F409B0 Offset: 0x1F3FBB0 VA: 0x181F409B0
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0x1F4DDA0 Offset: 0x1F4CFA0 VA: 0x181F4DDA0
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0x1F426F0 Offset: 0x1F418F0 VA: 0x181F426F0
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1F42640 Offset: 0x1F41840 VA: 0x181F42640
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1F42F10 Offset: 0x1F42110 VA: 0x181F42F10
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x1F524A0 Offset: 0x1F516A0 VA: 0x181F524A0
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0x1F46B00 Offset: 0x1F45D00 VA: 0x181F46B00
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x1F45AB0 Offset: 0x1F44CB0 VA: 0x181F45AB0
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x1F44370 Offset: 0x1F43570 VA: 0x181F44370
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F3D8C0 Offset: 0x1F3CAC0 VA: 0x181F3D8C0
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x1F484B0 Offset: 0x1F476B0 VA: 0x181F484B0
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x1F48200 Offset: 0x1F47400 VA: 0x181F48200
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0x1F44D50 Offset: 0x1F43F50 VA: 0x181F44D50
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x1F4C090 Offset: 0x1F4B290 VA: 0x181F4C090
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x1F4BEC0 Offset: 0x1F4B0C0 VA: 0x181F4BEC0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x1F4BCD0 Offset: 0x1F4AED0 VA: 0x181F4BCD0
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0x1F4BBC0 Offset: 0x1F4ADC0 VA: 0x181F4BBC0
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0x1F4D3A0 Offset: 0x1F4C5A0 VA: 0x181F4D3A0
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }
}

// Namespace: System.Xml.Schema
internal enum SchemaType // TypeDefIndex: 12366
{
	// Fields
	public int value__; // 0x0
	public const SchemaType None = 0;
	public const SchemaType DTD = 1;
	public const SchemaType XDR = 2;
	public const SchemaType XSD = 3;
}

// Namespace: System.Xml.Schema
public class ValidationEventArgs : EventArgs // TypeDefIndex: 12367
{
	// Fields
	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	// Properties
	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }

	// Methods

	// RVA: 0x1F5AE80 Offset: 0x1F5A080 VA: 0x181F5AE80
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0x1F5AEF0 Offset: 0x1F5A0F0 VA: 0x181F5AEF0
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public XmlSeverityType get_Severity() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public XmlSchemaException get_Exception() { }
}

// Namespace: System.Xml.Schema
public sealed class ValidationEventHandler : MulticastDelegate // TypeDefIndex: 12368
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, ValidationEventArgs e) { }
}

// Namespace: System.Xml.Schema
internal struct StateUnion // TypeDefIndex: 12369
{
	// Fields
	public int State; // 0x0
	public int AllElementsRequired; // 0x0
	public int CurPosIndex; // 0x0
	public int NumberOfRunningPos; // 0x0
}

// Namespace: System.Xml.Schema
internal sealed class ValidationState // TypeDefIndex: 12370
{
	// Fields
	public bool IsNill; // 0x10
	public bool IsDefault; // 0x11
	public bool NeedValidateChildren; // 0x12
	public bool CheckRequiredAttribute; // 0x13
	public bool ValidationSkipped; // 0x14
	public XmlSchemaContentProcessing ProcessContents; // 0x18
	public XmlSchemaValidity Validity; // 0x1C
	public SchemaElementDecl ElementDecl; // 0x20
	public SchemaElementDecl ElementDeclBeforeXsi; // 0x28
	public string LocalName; // 0x30
	public string Namespace; // 0x38
	public ConstraintStruct[] Constr; // 0x40
	public StateUnion CurrentState; // 0x48
	public bool HasMatched; // 0x4C
	public BitSet[] CurPos; // 0x50
	public BitSet AllElementsSet; // 0x58
	public List<RangePositionInfo> RunningPositions; // 0x60
	public bool TooComplex; // 0x68

	// Methods

	// RVA: 0x1F5AF60 Offset: 0x1F5A160 VA: 0x181F5AF60
	public void .ctor() { }
}

// Namespace: 
private sealed class XdrBuilder.DeclBaseInfo // TypeDefIndex: 12371
{
	// Fields
	internal XmlQualifiedName _Name; // 0x10
	internal string _Prefix; // 0x18
	internal XmlQualifiedName _TypeName; // 0x20
	internal string _TypePrefix; // 0x28
	internal object _Default; // 0x30
	internal object _Revises; // 0x38
	internal uint _MaxOccurs; // 0x40
	internal uint _MinOccurs; // 0x44
	internal bool _Checking; // 0x48
	internal SchemaElementDecl _ElementDecl; // 0x50
	internal SchemaAttDef _Attdef; // 0x58
	internal XdrBuilder.DeclBaseInfo _Next; // 0x60

	// Methods

	// RVA: 0x1F5AC60 Offset: 0x1F59E60 VA: 0x181F5AC60
	internal void .ctor() { }

	// RVA: 0x1F5ABC0 Offset: 0x1F59DC0 VA: 0x181F5ABC0
	internal void Reset() { }
}

// Namespace: 
private sealed class XdrBuilder.GroupContent // TypeDefIndex: 12372
{
	// Fields
	internal uint _MinVal; // 0x10
	internal uint _MaxVal; // 0x14
	internal bool _HasMaxAttr; // 0x18
	internal bool _HasMinAttr; // 0x19
	internal int _Order; // 0x1C

	// Methods

	// RVA: 0x1F5AC80 Offset: 0x1F59E80 VA: 0x181F5AC80
	internal static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to) { }

	// RVA: 0x1F5ACB0 Offset: 0x1F59EB0 VA: 0x181F5ACB0
	internal static XdrBuilder.GroupContent Copy(XdrBuilder.GroupContent other) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class XdrBuilder.ElementContent // TypeDefIndex: 12373
{
	// Fields
	internal SchemaElementDecl _ElementDecl; // 0x10
	internal int _ContentAttr; // 0x18
	internal int _OrderAttr; // 0x1C
	internal bool _MasterGroupRequired; // 0x20
	internal bool _ExistTerminal; // 0x21
	internal bool _AllowDataType; // 0x22
	internal bool _HasDataType; // 0x23
	internal bool _HasType; // 0x24
	internal bool _EnumerationRequired; // 0x25
	internal uint _MinVal; // 0x28
	internal uint _MaxVal; // 0x2C
	internal uint _MaxLength; // 0x30
	internal uint _MinLength; // 0x34
	internal Hashtable _AttDefList; // 0x38

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class XdrBuilder.AttributeContent // TypeDefIndex: 12374
{
	// Fields
	internal SchemaAttDef _AttDef; // 0x10
	internal XmlQualifiedName _Name; // 0x18
	internal string _Prefix; // 0x20
	internal bool _Required; // 0x28
	internal uint _MinVal; // 0x2C
	internal uint _MaxVal; // 0x30
	internal uint _MaxLength; // 0x34
	internal uint _MinLength; // 0x38
	internal bool _EnumerationRequired; // 0x3C
	internal bool _HasDataType; // 0x3D
	internal bool _Global; // 0x3E
	internal object _Default; // 0x40

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class XdrBuilder.XdrBuildFunction : MulticastDelegate // TypeDefIndex: 12375
{
	// Methods

	// RVA: 0x1D95F30 Offset: 0x1D95130 VA: 0x181D95F30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrInitFunction : MulticastDelegate // TypeDefIndex: 12376
{
	// Methods

	// RVA: 0x1A446E0 Offset: 0x1A438E0 VA: 0x181A446E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(XdrBuilder builder, object obj) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrBeginChildFunction : MulticastDelegate // TypeDefIndex: 12377
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(XdrBuilder builder) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrEndChildFunction : MulticastDelegate // TypeDefIndex: 12378
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(XdrBuilder builder) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrAttributeEntry // TypeDefIndex: 12379
{
	// Fields
	internal SchemaNames.Token _Attribute; // 0x10
	internal int _SchemaFlags; // 0x14
	internal XmlSchemaDatatype _Datatype; // 0x18
	internal XdrBuilder.XdrBuildFunction _BuildFunc; // 0x20

	// Methods

	// RVA: 0x1F5B040 Offset: 0x1F5A240 VA: 0x181F5B040
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build) { }

	// RVA: 0x1F5AFB0 Offset: 0x1F5A1B0 VA: 0x181F5AFB0
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuilder.XdrBuildFunction build) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrEntry // TypeDefIndex: 12380
{
	// Fields
	internal SchemaNames.Token _Name; // 0x10
	internal int[] _NextStates; // 0x18
	internal XdrBuilder.XdrAttributeEntry[] _Attributes; // 0x20
	internal XdrBuilder.XdrInitFunction _InitFunc; // 0x28
	internal XdrBuilder.XdrBeginChildFunction _BeginChildFunc; // 0x30
	internal XdrBuilder.XdrEndChildFunction _EndChildFunc; // 0x38
	internal bool _AllowText; // 0x40

	// Methods

	// RVA: 0x1F64E50 Offset: 0x1F64050 VA: 0x181F64E50
	internal void .ctor(SchemaNames.Token n, int[] states, XdrBuilder.XdrAttributeEntry[] attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText) { }
}

// Namespace: System.Xml.Schema
internal sealed class XdrBuilder : SchemaBuilder // TypeDefIndex: 12381
{
	// Fields
	private static readonly int[] S_XDR_Root_Element; // 0x0
	private static readonly int[] S_XDR_Root_SubElements; // 0x8
	private static readonly int[] S_XDR_ElementType_SubElements; // 0x10
	private static readonly int[] S_XDR_AttributeType_SubElements; // 0x18
	private static readonly int[] S_XDR_Group_SubElements; // 0x20
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes; // 0x28
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes; // 0x30
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes; // 0x38
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes; // 0x40
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes; // 0x48
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes; // 0x50
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; // 0x58
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; // 0x60
	private static readonly XdrBuilder.XdrEntry[] S_SchemaEntries; // 0x68
	private SchemaInfo _SchemaInfo; // 0x10
	private string _TargetNamespace; // 0x18
	private XmlReader _reader; // 0x20
	private PositionInfo positionInfo; // 0x28
	private ParticleContentValidator _contentValidator; // 0x30
	private XdrBuilder.XdrEntry _CurState; // 0x38
	private XdrBuilder.XdrEntry _NextState; // 0x40
	private HWStack _StateHistory; // 0x48
	private HWStack _GroupStack; // 0x50
	private string _XdrName; // 0x58
	private string _XdrPrefix; // 0x60
	private XdrBuilder.ElementContent _ElementDef; // 0x68
	private XdrBuilder.GroupContent _GroupDef; // 0x70
	private XdrBuilder.AttributeContent _AttributeDef; // 0x78
	private XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes; // 0x80
	private XdrBuilder.DeclBaseInfo _BaseDecl; // 0x88
	private XmlNameTable _NameTable; // 0x90
	private SchemaNames _SchemaNames; // 0x98
	private XmlNamespaceManager _CurNsMgr; // 0xA0
	private string _Text; // 0xA8
	private ValidationEventHandler validationEventHandler; // 0xB0
	private Hashtable _UndeclaredElements; // 0xB8
	private XmlResolver xmlResolver; // 0xC0

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x1F64C40 Offset: 0x1F63E40 VA: 0x181F64C40
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x1F5D180 Offset: 0x1F5C380 VA: 0x181F5D180 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x1F5CCE0 Offset: 0x1F5BEE0 VA: 0x181F5CCE0 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x718950 Offset: 0x717B50 VA: 0x180718950
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1F5C170 Offset: 0x1F5B370 VA: 0x181F5C170
	private bool LoadSchema(string uri) { }

	// RVA: 0x1F5BF70 Offset: 0x1F5B170 VA: 0x181F5BF70
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x1F5D3D0 Offset: 0x1F5C5D0 VA: 0x181F5D3D0 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x1F5D100 Offset: 0x1F5C300 VA: 0x181F5D100 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x1F5D960 Offset: 0x1F5CB60 VA: 0x181F5D960 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x1F5B4E0 Offset: 0x1F5A6E0 VA: 0x181F5B4E0 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x1F5D4F0 Offset: 0x1F5C6F0 VA: 0x181F5D4F0
	private void Push() { }

	// RVA: 0x1F5CC50 Offset: 0x1F5BE50 VA: 0x181F5CC50
	private void Pop() { }

	// RVA: 0x1F5D430 Offset: 0x1F5C630 VA: 0x181F5D430
	private void PushGroupInfo() { }

	// RVA: 0x1F5CBC0 Offset: 0x1F5BDC0 VA: 0x181F5CBC0
	private void PopGroupInfo() { }

	// RVA: 0x1F61600 Offset: 0x1F60800 VA: 0x181F61600
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0x1F5F9E0 Offset: 0x1F5EBE0 VA: 0x181F5F9E0
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5E1B0 Offset: 0x1F5D3B0 VA: 0x181F5E1B0
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0x1F60980 Offset: 0x1F5FB80 VA: 0x181F60980
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0x1F611E0 Offset: 0x1F603E0 VA: 0x181F611E0
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0x1F5F1E0 Offset: 0x1F5E3E0 VA: 0x181F5F1E0
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5EC10 Offset: 0x1F5DE10 VA: 0x181F5EC10
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5F050 Offset: 0x1F5E250 VA: 0x181F5F050
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5F3E0 Offset: 0x1F5E5E0 VA: 0x181F5F3E0
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5EDD0 Offset: 0x1F5DFD0 VA: 0x181F5EDD0
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5EF60 Offset: 0x1F5E160 VA: 0x181F5EF60
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5ECD0 Offset: 0x1F5DED0 VA: 0x181F5ECD0
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5ED50 Offset: 0x1F5DF50 VA: 0x181F5ED50
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5DE70 Offset: 0x1F5D070 VA: 0x181F5DE70
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0x1F60120 Offset: 0x1F5F320 VA: 0x181F60120
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0x1F60F50 Offset: 0x1F60150 VA: 0x181F60F50
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0x1F5E700 Offset: 0x1F5D900 VA: 0x181F5E700
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5E9C0 Offset: 0x1F5DBC0 VA: 0x181F5E9C0
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5E290 Offset: 0x1F5D490 VA: 0x181F5E290
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5E3C0 Offset: 0x1F5D5C0 VA: 0x181F5E3C0
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5E610 Offset: 0x1F5D810 VA: 0x181F5E610
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5E2C0 Offset: 0x1F5D4C0 VA: 0x181F5E2C0
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5E340 Offset: 0x1F5D540 VA: 0x181F5E340
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5D9A0 Offset: 0x1F5CBA0 VA: 0x181F5D9A0
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0x1F5FCA0 Offset: 0x1F5EEA0 VA: 0x181F5FCA0
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0x1F61350 Offset: 0x1F60550 VA: 0x181F61350
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0x1F5F5B0 Offset: 0x1F5E7B0 VA: 0x181F5F5B0
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5F530 Offset: 0x1F5E730 VA: 0x181F5F530
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5F4B0 Offset: 0x1F5E6B0 VA: 0x181F5F4B0
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F60640 Offset: 0x1F5F840 VA: 0x181F60640
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0x1F61050 Offset: 0x1F60250 VA: 0x181F61050
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0x1F5EAF0 Offset: 0x1F5DCF0 VA: 0x181F5EAF0
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5EA70 Offset: 0x1F5DC70 VA: 0x181F5EA70
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5EA40 Offset: 0x1F5DC40 VA: 0x181F5EA40
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5DA40 Offset: 0x1F5CC40 VA: 0x181F5DA40
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0x1F5FFE0 Offset: 0x1F5F1E0 VA: 0x181F5FFE0
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0x1F61430 Offset: 0x1F60630 VA: 0x181F61430
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0x1F5F8B0 Offset: 0x1F5EAB0 VA: 0x181F5F8B0
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5F820 Offset: 0x1F5EA20 VA: 0x181F5F820
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F5F790 Offset: 0x1F5E990 VA: 0x181F5F790
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1F60770 Offset: 0x1F5F970 VA: 0x181F60770
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0x1F610E0 Offset: 0x1F602E0 VA: 0x181F610E0
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x1F60010 Offset: 0x1F5F210 VA: 0x181F60010
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0x1F60EB0 Offset: 0x1F600B0 VA: 0x181F60EB0
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x1F5FB80 Offset: 0x1F5ED80 VA: 0x181F5FB80
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0x1F5B8D0 Offset: 0x1F5AAD0 VA: 0x181F5B8D0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x1F5BE70 Offset: 0x1F5B070 VA: 0x181F5BE70
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x1F5BCB0 Offset: 0x1F5AEB0 VA: 0x181F5BCB0
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0x1F5BAB0 Offset: 0x1F5ACB0 VA: 0x181F5BAB0
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0x1F5B0D0 Offset: 0x1F5A2D0 VA: 0x181F5B0D0
	private void AddOrder() { }

	// RVA: 0x1F5C010 Offset: 0x1F5B210 VA: 0x181F5C010
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0x1F5CA90 Offset: 0x1F5BC90 VA: 0x181F5CA90
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x1F5C940 Offset: 0x1F5BB40 VA: 0x181F5C940
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x1F5BC70 Offset: 0x1F5AE70 VA: 0x181F5BC70
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	// RVA: 0x1F5C640 Offset: 0x1F5B840 VA: 0x181F5C640
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x1F5C7A0 Offset: 0x1F5B9A0 VA: 0x181F5C7A0
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x1F5B470 Offset: 0x1F5A670 VA: 0x181F5B470
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	// RVA: 0x1F5C900 Offset: 0x1F5BB00 VA: 0x181F5C900
	private static bool ParseInteger(string str, ref uint n) { }

	// RVA: 0x1F5FA80 Offset: 0x1F5EC80 VA: 0x181F5FA80
	private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0x1F5D910 Offset: 0x1F5CB10 VA: 0x181F5D910
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0x1F5B5A0 Offset: 0x1F5A7A0 VA: 0x181F5B5A0
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0x1F5B7B0 Offset: 0x1F5A9B0 VA: 0x181F5B7B0
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0x1F5B190 Offset: 0x1F5A390 VA: 0x181F5B190
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0x1F5B340 Offset: 0x1F5A540 VA: 0x181F5B340
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0x1F5BCA0 Offset: 0x1F5AEA0 VA: 0x181F5BCA0
	private bool IsGlobal(int flags) { }

	// RVA: 0x1F5D540 Offset: 0x1F5C740 VA: 0x181F5D540
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1F5D8B0 Offset: 0x1F5CAB0 VA: 0x181F5D8B0
	private void SendValidationEvent(string code) { }

	// RVA: 0x1F5D7A0 Offset: 0x1F5C9A0 VA: 0x181F5D7A0
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x1F5D690 Offset: 0x1F5C890 VA: 0x181F5D690
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1F61650 Offset: 0x1F60850 VA: 0x181F61650
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class XdrValidator : BaseValidator // TypeDefIndex: 12382
{
	// Fields
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool isProcessContents; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1F68640 Offset: 0x1F67840 VA: 0x181F68640
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1F68590 Offset: 0x1F67790 VA: 0x181F68590
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1F65D20 Offset: 0x1F64F20 VA: 0x181F65D20
	private void Init() { }

	// RVA: 0x1F684B0 Offset: 0x1F676B0 VA: 0x181F684B0 Slot: 5
	public override void Validate() { }

	// RVA: 0x1F675F0 Offset: 0x1F667F0 VA: 0x181F675F0
	private void ValidateElement() { }

	// RVA: 0x1F67420 Offset: 0x1F66620 VA: 0x181F67420
	private void ValidateChildElement() { }

	// RVA: 0x1F686E0 Offset: 0x1F678E0 VA: 0x181F686E0
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1F66930 Offset: 0x1F65B30 VA: 0x181F66930
	private void ProcessInlineSchema() { }

	// RVA: 0x1F66850 Offset: 0x1F65A50 VA: 0x181F66850
	private void ProcessElement() { }

	// RVA: 0x1F67A10 Offset: 0x1F66C10 VA: 0x181F67A10
	private void ValidateEndElement() { }

	// RVA: 0x1F67000 Offset: 0x1F66200 VA: 0x181F67000
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x1F68020 Offset: 0x1F67220 VA: 0x181F68020
	private void ValidateStartElement() { }

	// RVA: 0x1F67CE0 Offset: 0x1F66EE0 VA: 0x181F67CE0
	private void ValidateEndStartElement() { }

	// RVA: 0x1F65ED0 Offset: 0x1F650D0 VA: 0x181F65ED0
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x1F66570 Offset: 0x1F65770 VA: 0x181F66570
	private void LoadSchema(string uri) { }

	// RVA: 0x1F686C0 Offset: 0x1F678C0 VA: 0x181F686C0
	private bool get_HasSchema() { }

	// RVA: 0x1F686F0 Offset: 0x1F678F0 VA: 0x181F686F0 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1F66B60 Offset: 0x1F65D60 VA: 0x181F66B60
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1F65A80 Offset: 0x1F64C80 VA: 0x181F65A80 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1F65530 Offset: 0x1F64730 VA: 0x181F65530
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1F64F70 Offset: 0x1F64170 VA: 0x181F64F70
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x1F64EC0 Offset: 0x1F640C0 VA: 0x181F64EC0
	internal void AddID(string name, object node) { }

	// RVA: 0x1F65CF0 Offset: 0x1F64EF0 VA: 0x181F65CF0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1F66DF0 Offset: 0x1F65FF0 VA: 0x181F66DF0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1F667A0 Offset: 0x1F659A0 VA: 0x181F667A0
	private void Pop() { }

	// RVA: 0x1F653F0 Offset: 0x1F645F0 VA: 0x181F653F0
	private void CheckForwardRefs() { }

	// RVA: 0x1F66F60 Offset: 0x1F66160 VA: 0x181F66F60
	private XmlQualifiedName QualifiedName(string name, string ns) { }
}

// Namespace: 
private struct XmlAtomicValue.Union // TypeDefIndex: 12383
{
	// Fields
	public bool boolVal; // 0x0
	public double dblVal; // 0x0
	public long i64Val; // 0x0
	public int i32Val; // 0x0
	public DateTime dtVal; // 0x0
}

// Namespace: 
private class XmlAtomicValue.NamespacePrefixForQName : IXmlNamespaceResolver // TypeDefIndex: 12384
{
	// Fields
	public string prefix; // 0x10
	public string ns; // 0x18

	// Methods

	// RVA: 0x1F5AE40 Offset: 0x1F5A040 VA: 0x181F5AE40
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x1F5ADD0 Offset: 0x1F59FD0 VA: 0x181F5ADD0 Slot: 5
	public string LookupNamespace(string prefix) { }

	// RVA: 0x1F5AE10 Offset: 0x1F5A010 VA: 0x181F5AE10 Slot: 6
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x1F5AD30 Offset: 0x1F59F30 VA: 0x181F5AD30 Slot: 4
	public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }
}

// Namespace: System.Xml.Schema
public sealed class XmlAtomicValue : XPathItem, ICloneable // TypeDefIndex: 12385
{
	// Fields
	private XmlSchemaType xmlType; // 0x10
	private object objVal; // 0x18
	private TypeCode clrType; // 0x20
	private XmlAtomicValue.Union unionVal; // 0x28
	private XmlAtomicValue.NamespacePrefixForQName nsPrefix; // 0x30

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override Type ValueType { get; }
	public override object TypedValue { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0x1F68A10 Offset: 0x1F67C10 VA: 0x181F68A10
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x1F691D0 Offset: 0x1F683D0 VA: 0x181F691D0
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x1F69260 Offset: 0x1F68460 VA: 0x181F69260
	internal void .ctor(XmlSchemaType xmlType, double value) { }

	// RVA: 0x1F68E30 Offset: 0x1F68030 VA: 0x181F68E30
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x1F68DA0 Offset: 0x1F67FA0 VA: 0x181F68DA0
	internal void .ctor(XmlSchemaType xmlType, long value) { }

	// RVA: 0x1F690F0 Offset: 0x1F682F0 VA: 0x181F690F0
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x1F68B80 Offset: 0x1F67D80 VA: 0x181F68B80
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F68AA0 Offset: 0x1F67CA0 VA: 0x181F68AA0
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x1F68EC0 Offset: 0x1F680C0 VA: 0x181F68EC0
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x1F69A50 Offset: 0x1F68C50 VA: 0x181F69A50 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x1F692F0 Offset: 0x1F684F0 VA: 0x181F692F0 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x1F69500 Offset: 0x1F68700 VA: 0x181F69500 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x1F69610 Offset: 0x1F68810 VA: 0x181F69610 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x1F69720 Offset: 0x1F68920 VA: 0x181F69720 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x1F69830 Offset: 0x1F68A30 VA: 0x181F69830 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x1F69940 Offset: 0x1F68B40 VA: 0x181F69940 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x1F687E0 Offset: 0x1F679E0 VA: 0x181F687E0 Slot: 14
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1F69A90 Offset: 0x1F68C90 VA: 0x181F69A90 Slot: 5
	public override string get_Value() { }

	// RVA: 0x19B4EC0 Offset: 0x19B40C0 VA: 0x1819B4EC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F68730 Offset: 0x1F67930 VA: 0x181F68730
	private string GetPrefixFromQName(string value) { }
}

// Namespace: System.Xml.Schema
[XmlRoot("schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
public class XmlSchema : XmlSchemaObject // TypeDefIndex: 12386
{
	// Fields
	private XmlSchemaForm attributeFormDefault; // 0x38
	private XmlSchemaForm elementFormDefault; // 0x3C
	private XmlSchemaDerivationMethod blockDefault; // 0x40
	private XmlSchemaDerivationMethod finalDefault; // 0x44
	private string targetNs; // 0x48
	private string version; // 0x50
	private XmlSchemaObjectCollection includes; // 0x58
	private XmlSchemaObjectCollection items; // 0x60
	private string id; // 0x68
	private XmlAttribute[] moreAttributes; // 0x70
	private bool isCompiled; // 0x78
	private bool isCompiledBySet; // 0x79
	private bool isPreprocessed; // 0x7A
	private bool isRedefined; // 0x7B
	private int errorCount; // 0x7C
	private XmlSchemaObjectTable attributes; // 0x80
	private XmlSchemaObjectTable attributeGroups; // 0x88
	private XmlSchemaObjectTable elements; // 0x90
	private XmlSchemaObjectTable types; // 0x98
	private XmlSchemaObjectTable groups; // 0xA0
	private XmlSchemaObjectTable notations; // 0xA8
	private XmlSchemaObjectTable identityConstraints; // 0xB0
	private static int globalIdCounter; // 0x0
	private ArrayList importedSchemas; // 0xB8
	private ArrayList importedNamespaces; // 0xC0
	private int schemaId; // 0xC8
	private Uri baseUri; // 0xD0
	private bool isChameleon; // 0xD8
	private Hashtable ids; // 0xE0
	private XmlDocument document; // 0xE8

	// Properties
	[DefaultValue(0)]
	[Xml("attributeFormDefault")]
	public XmlSchemaForm AttributeFormDefault { get; set; }
	[DefaultValue(256)]
	[Xml("blockDefault")]
	public XmlSchemaDerivationMethod BlockDefault { get; set; }
	[DefaultValue(256)]
	[Xml("finalDefault")]
	public XmlSchemaDerivationMethod FinalDefault { get; set; }
	[Xml("elementFormDefault")]
	[DefaultValue(0)]
	public XmlSchemaForm ElementFormDefault { get; set; }
	[Xml("targetNamespace", DataType = "anyURI")]
	public string TargetNamespace { get; set; }
	[Xml("version", DataType = "token")]
	public string Version { get; set; }
	[XmlElement("redefine", typeof(XmlSchemaRedefine))]
	[XmlElement("include", typeof(XmlSchemaInclude))]
	[XmlElement("import", typeof(XmlSchemaImport))]
	public XmlSchemaObjectCollection Includes { get; }
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("notation", typeof(XmlSchemaNotation))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	internal bool IsCompiledBySet { get; set; }
	[XmlIgnore]
	internal bool IsPreprocessed { get; set; }
	[XmlIgnore]
	internal bool IsRedefined { get; set; }
	[XmlIgnore]
	public XmlSchemaObjectTable Attributes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Elements { get; }
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlIgnore]
	public XmlSchemaObjectTable Groups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Notations { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable IdentityConstraints { get; }
	[XmlIgnore]
	internal Uri BaseUri { get; set; }
	[XmlIgnore]
	internal int SchemaId { get; }
	[XmlIgnore]
	internal bool IsChameleon { get; set; }
	[XmlIgnore]
	internal Hashtable Ids { get; }
	[XmlIgnore]
	internal XmlDocument Document { get; }
	[XmlIgnore]
	internal int ErrorCount { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }
	internal ArrayList ImportedSchemas { get; }
	internal ArrayList ImportedNamespaces { get; }

	// Methods

	// RVA: 0x1F72620 Offset: 0x1F71820 VA: 0x181F72620
	public void .ctor() { }

	// RVA: 0x1F72480 Offset: 0x1F71680 VA: 0x181F72480
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x1F71C40 Offset: 0x1F70E40 VA: 0x181F71C40
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x1F71B80 Offset: 0x1F70D80 VA: 0x181F71B80
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_TargetNamespace() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_TargetNamespace(string value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Version() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Version(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x646CD0 Offset: 0x645ED0 VA: 0x180646CD0
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x646CE0 Offset: 0x645EE0 VA: 0x180646CE0
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x1C16520 Offset: 0x1C15720 VA: 0x181C16520
	internal bool get_IsPreprocessed() { }

	// RVA: 0x1DE3990 Offset: 0x1DE2B90 VA: 0x181DE3990
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x1C16530 Offset: 0x1C15730 VA: 0x181C16530
	internal bool get_IsRedefined() { }

	// RVA: 0x1F72B30 Offset: 0x1F71D30 VA: 0x181F72B30
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x1F72820 Offset: 0x1F71A20 VA: 0x181F72820
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x1F727B0 Offset: 0x1F719B0 VA: 0x181F727B0
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x1F72AC0 Offset: 0x1F71CC0 VA: 0x181F72AC0
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x1F72900 Offset: 0x1F71B00 VA: 0x181F72900
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public string get_Id() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_Id(string value) { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	internal Uri get_BaseUri() { }

	// RVA: 0x599C80 Offset: 0x598E80 VA: 0x180599C80
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x1F72A50 Offset: 0x1F71C50 VA: 0x181F72A50
	internal int get_SchemaId() { }

	// RVA: 0x1C61220 Offset: 0x1C60420 VA: 0x181C61220
	internal bool get_IsChameleon() { }

	// RVA: 0x1C61A10 Offset: 0x1C60C10 VA: 0x181C61A10
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	internal Hashtable get_Ids() { }

	// RVA: 0x1F72890 Offset: 0x1F71A90 VA: 0x181F72890
	internal XmlDocument get_Document() { }

	// RVA: 0x1C44BB0 Offset: 0x1C43DB0 VA: 0x181C44BB0
	internal int get_ErrorCount() { }

	// RVA: 0x1C44D00 Offset: 0x1C43F00 VA: 0x181C44D00
	internal void set_ErrorCount(int value) { }

	// RVA: 0x1F71A70 Offset: 0x1F70C70 VA: 0x181F71A70
	internal XmlSchema Clone() { }

	// RVA: 0x1F71E20 Offset: 0x1F71020 VA: 0x181F71E20
	internal XmlSchema DeepClone() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x1B30BA0 Offset: 0x1B2FDA0 VA: 0x181B30BA0
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1F71A00 Offset: 0x1F70C00 VA: 0x181F71A00 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x1F729E0 Offset: 0x1F71BE0 VA: 0x181F729E0
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x1F72970 Offset: 0x1F71B70 VA: 0x181F72970
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x1F72290 Offset: 0x1F71490 VA: 0x181F72290
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x1F725E0 Offset: 0x1F717E0 VA: 0x181F725E0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAll : XmlSchemaGroupBase // TypeDefIndex: 12387
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1F69C60 Offset: 0x1F68E60 VA: 0x181F69C60 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1F69BD0 Offset: 0x1F68DD0 VA: 0x181F69BD0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotated : XmlSchemaObject // TypeDefIndex: 12388
{
	// Fields
	private string id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	public XmlSchemaAnnotation Annotation { get; set; }
	[XmlAny]
	public XmlAttribute[] UnhandledAttributes { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Id() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Id(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotation : XmlSchemaObject // TypeDefIndex: 12389
{
	// Fields
	private string id; // 0x38
	private XmlSchemaObjectCollection items; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlElement("appinfo", typeof(XmlSchemaAppInfo))]
	[XmlElement("documentation", typeof(XmlSchemaDocumentation))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Id() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Id(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1F69CA0 Offset: 0x1F68EA0 VA: 0x181F69CA0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAny : XmlSchemaParticle // TypeDefIndex: 12390
{
	// Fields
	private string ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Properties
	[Xml("namespace")]
	public string Namespace { get; set; }
	[DefaultValue(0)]
	[Xml("processContents")]
	public XmlSchemaContentProcessing ProcessContents { set; }
	[XmlIgnore]
	internal NamespaceList NamespaceList { get; }
	[XmlIgnore]
	internal string ResolvedNamespace { get; }
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }
	internal override string NameString { get; }

	// Methods

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public string get_Namespace() { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	public void set_Namespace(string value) { }

	// RVA: 0x1A6BA80 Offset: 0x1A6AC80 VA: 0x181A6BA80
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x1F6A690 Offset: 0x1F69890 VA: 0x181F6A690
	internal string get_ResolvedNamespace() { }

	// RVA: 0x1F6A670 Offset: 0x1F69870 VA: 0x181F6A670
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x1F6A260 Offset: 0x1F69460 VA: 0x181F6A260 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x1F6A160 Offset: 0x1F69360 VA: 0x181F6A160
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x1F6A0A0 Offset: 0x1F692A0 VA: 0x181F6A0A0
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x1F6A060 Offset: 0x1F69260 VA: 0x181F6A060
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1F6A210 Offset: 0x1F69410 VA: 0x181F6A210
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAnyAttribute : XmlSchemaAnnotated // TypeDefIndex: 12391
{
	// Fields
	private string ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Properties
	[Xml("namespace")]
	public string Namespace { set; }
	[Xml("processContents")]
	[DefaultValue(0)]
	public XmlSchemaContentProcessing ProcessContents { get; set; }
	[XmlIgnore]
	internal NamespaceList NamespaceList { get; }
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }

	// Methods

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Namespace(string value) { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x1F6A050 Offset: 0x1F69250 VA: 0x181F6A050
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x1F69E00 Offset: 0x1F69000 VA: 0x181F69E00
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x1F69D40 Offset: 0x1F68F40 VA: 0x181F69D40
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x1F69D00 Offset: 0x1F68F00 VA: 0x181F69D00
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1F69F60 Offset: 0x1F69160 VA: 0x181F69F60
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x1F69EA0 Offset: 0x1F690A0 VA: 0x181F69EA0
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x1F69F90 Offset: 0x1F69190 VA: 0x181F69F90
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAppInfo : XmlSchemaObject // TypeDefIndex: 12392
{
	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Properties
	[Xml("source", DataType = "anyURI")]
	public string Source { set; }
	[XmlText]
	[XmlAnyElement]
	public XmlNode[] Markup { get; set; }

	// Methods

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Source(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public XmlNode[] get_Markup() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAttribute : XmlSchemaAnnotated // TypeDefIndex: 12393
{
	// Fields
	private string defaultValue; // 0x50
	private string fixedValue; // 0x58
	private string name; // 0x60
	private XmlSchemaForm form; // 0x68
	private XmlSchemaUse use; // 0x6C
	private XmlQualifiedName refName; // 0x70
	private XmlQualifiedName typeName; // 0x78
	private XmlQualifiedName qualifiedName; // 0x80
	private XmlSchemaSimpleType type; // 0x88
	private XmlSchemaSimpleType attributeType; // 0x90
	private SchemaAttDef attDef; // 0x98

	// Properties
	[Xml("default")]
	[DefaultValue(null)]
	public string DefaultValue { get; set; }
	[Xml("fixed")]
	[DefaultValue(null)]
	public string FixedValue { get; set; }
	[Xml("form")]
	[DefaultValue(0)]
	public XmlSchemaForm Form { get; set; }
	[Xml("name")]
	public string Name { get; set; }
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[Xml("type")]
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElement("simpleType")]
	public XmlSchemaSimpleType SchemaType { get; set; }
	[Xml("use")]
	[DefaultValue(0)]
	public XmlSchemaUse Use { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaSimpleType AttributeSchemaType { get; }
	[XmlIgnore]
	internal XmlSchemaDatatype Datatype { get; }
	internal SchemaAttDef AttDef { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_DefaultValue() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_DefaultValue(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_FixedValue() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_FixedValue(string value) { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80
	public XmlSchemaForm get_Form() { }

	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_Name() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_Name(string value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1F6ABB0 Offset: 0x1F69DB0 VA: 0x181F6ABB0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x1F6AC50 Offset: 0x1F69E50 VA: 0x181F6AC50
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x526CA0 Offset: 0x525EA0 VA: 0x180526CA0
	public XmlSchemaUse get_Use() { }

	// RVA: 0x526DA0 Offset: 0x525FA0 VA: 0x180526DA0
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x1F6AB90 Offset: 0x1F69D90 VA: 0x181F6AB90
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x43B590 Offset: 0x43A790 VA: 0x18043B590
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1F6AA10 Offset: 0x1F69C10 VA: 0x181F6AA10 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1F6AAF0 Offset: 0x1F69CF0 VA: 0x181F6AAF0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroup : XmlSchemaAnnotated // TypeDefIndex: 12394
{
	// Fields
	private string name; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaAttributeGroup redefined; // 0x70
	private XmlSchemaObjectTable attributeUses; // 0x78
	private XmlSchemaAnyAttribute attributeWildcard; // 0x80
	private int selfReferenceCount; // 0x88

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnore]
	internal XmlSchemaAnyAttribute AttributeWildcard { get; set; }
	[XmlIgnore]
	public XmlSchemaAttributeGroup RedefinedAttributeGroup { get; }
	[XmlIgnore]
	internal XmlSchemaAttributeGroup Redefined { get; set; }
	[XmlIgnore]
	internal int SelfReferenceCount { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Name() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Name(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1F6A9A0 Offset: 0x1F69BA0 VA: 0x181F6A9A0
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950
	internal int get_SelfReferenceCount() { }

	// RVA: 0x73BA10 Offset: 0x73AC10 VA: 0x18073BA10
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1F6A7F0 Offset: 0x1F699F0 VA: 0x181F6A7F0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1F6A900 Offset: 0x1F69B00 VA: 0x181F6A900
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated // TypeDefIndex: 12395
{
	// Fields
	private XmlQualifiedName refName; // 0x50

	// Properties
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1F6A750 Offset: 0x1F69950 VA: 0x181F6A750
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1F6A6E0 Offset: 0x1F698E0 VA: 0x181F6A6E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaChoice : XmlSchemaGroupBase // TypeDefIndex: 12396
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1F6AD80 Offset: 0x1F69F80 VA: 0x181F6AD80 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1F6ACF0 Offset: 0x1F69EF0 VA: 0x181F6ACF0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
[Obsolete("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
public sealed class XmlSchemaCollection : ICollection, IEnumerable // TypeDefIndex: 12397
{
	// Fields
	private Hashtable collection; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ReaderWriterLock wLock; // 0x28
	private int timeout; // 0x30
	private bool isThreadSafe; // 0x34
	private ValidationEventHandler validationEventHandler; // 0x38
	private XmlResolver xmlResolver; // 0x40

	// Properties
	public int Count { get; }
	public XmlNameTable NameTable { get; }
	internal XmlResolver XmlResolver { set; }
	public XmlSchema Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	internal ValidationEventHandler EventHandler { get; set; }

	// Methods

	// RVA: 0x1F6B870 Offset: 0x1F6AA70 VA: 0x181F6B870
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x1E38450 Offset: 0x1E37650 VA: 0x181E38450
	public int get_Count() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1F6B970 Offset: 0x1F6AB70 VA: 0x181F6B970
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x1F6B7F0 Offset: 0x1F6A9F0 VA: 0x181F6B7F0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1F6B410 Offset: 0x1F6A610 VA: 0x181F6B410
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x1F6B5F0 Offset: 0x1F6A7F0 VA: 0x181F6B5F0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1E38450 Offset: 0x1E37650 VA: 0x181E38450 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1F6B490 Offset: 0x1F6A690 VA: 0x181F6B490
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x1F6B540 Offset: 0x1F6A740 VA: 0x181F6B540
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x1F6B130 Offset: 0x1F6A330 VA: 0x181F6B130
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x1F6B2A0 Offset: 0x1F6A4A0 VA: 0x181F6B2A0
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x1F6AFF0 Offset: 0x1F6A1F0 VA: 0x181F6AFF0
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void set_EventHandler(ValidationEventHandler value) { }
}

// Namespace: System.Xml.Schema
internal sealed class XmlSchemaCollectionNode // TypeDefIndex: 12398
{
	// Fields
	private string namespaceUri; // 0x10
	private SchemaInfo schemaInfo; // 0x18
	private XmlSchema schema; // 0x20

	// Properties
	internal string NamespaceURI { set; }
	internal SchemaInfo SchemaInfo { get; set; }
	internal XmlSchema Schema { get; set; }

	// Methods

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_NamespaceURI(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal SchemaInfo get_SchemaInfo() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_SchemaInfo(SchemaInfo value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal XmlSchema get_Schema() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_Schema(XmlSchema value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCollectionEnumerator : IEnumerator // TypeDefIndex: 12399
{
	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public XmlSchema Current { get; }
	internal XmlSchemaCollectionNode CurrentNode { get; }

	// Methods

	// RVA: 0x1F6AE90 Offset: 0x1F6A090 VA: 0x181F6AE90
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x1F6AE30 Offset: 0x1F6A030 VA: 0x181F6AE30 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1F6ADE0 Offset: 0x1F69FE0 VA: 0x181F6ADE0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1F6AD90 Offset: 0x1F69F90 VA: 0x181F6AD90
	public bool MoveNext() { }

	// RVA: 0x1F6AE80 Offset: 0x1F6A080 VA: 0x181F6AE80 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1F6AF60 Offset: 0x1F6A160 VA: 0x181F6AF60
	public XmlSchema get_Current() { }

	// RVA: 0x1F6AEE0 Offset: 0x1F6A0E0 VA: 0x181F6AEE0
	internal XmlSchemaCollectionNode get_CurrentNode() { }
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCompilationSettings // TypeDefIndex: 12400
{
	// Fields
	private bool enableUpaCheck; // 0x10

	// Properties
	public bool EnableUpaCheck { get; }

	// Methods

	// RVA: 0x1896720 Offset: 0x1895920 VA: 0x181896720
	public void .ctor() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_EnableUpaCheck() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContent : XmlSchemaContentModel // TypeDefIndex: 12401
{
	// Fields
	private XmlSchemaContent content; // 0x50
	private bool isMixed; // 0x58
	private bool hasMixedAttribute; // 0x59

	// Properties
	[Xml("mixed")]
	public bool IsMixed { get; set; }
	[XmlElement("extension", typeof(XmlSchemaComplexContentExtension))]
	[XmlElement("restriction", typeof(XmlSchemaComplexContentRestriction))]
	public override XmlSchemaContent Content { get; set; }
	[XmlIgnore]
	internal bool HasMixedAttribute { get; }

	// Methods

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30
	public bool get_IsMixed() { }

	// RVA: 0x1F6BCA0 Offset: 0x1F6AEA0 VA: 0x181F6BCA0
	public void set_IsMixed(bool value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x7725E0 Offset: 0x7717E0 VA: 0x1807725E0
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentExtension : XmlSchemaContent // TypeDefIndex: 12402
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1F6BAC0 Offset: 0x1F6ACC0 VA: 0x181F6BAC0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1F6BA20 Offset: 0x1F6AC20 VA: 0x181F6BA20
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentRestriction : XmlSchemaContent // TypeDefIndex: 12403
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1F6BC00 Offset: 0x1F6AE00 VA: 0x181F6BC00
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1F6BB60 Offset: 0x1F6AD60 VA: 0x181F6BB60
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexType : XmlSchemaType // TypeDefIndex: 12404
{
	// Fields
	private XmlSchemaDerivationMethod block; // 0x98
	private XmlSchemaContentModel contentModel; // 0xA0
	private XmlSchemaParticle particle; // 0xA8
	private XmlSchemaObjectCollection attributes; // 0xB0
	private XmlSchemaAnyAttribute anyAttribute; // 0xB8
	private XmlSchemaParticle contentTypeParticle; // 0xC0
	private XmlSchemaDerivationMethod blockResolved; // 0xC8
	private XmlSchemaObjectTable localElements; // 0xD0
	private XmlSchemaObjectTable attributeUses; // 0xD8
	private XmlSchemaAnyAttribute attributeWildcard; // 0xE0
	private static XmlSchemaComplexType anyTypeLax; // 0x0
	private static XmlSchemaComplexType anyTypeSkip; // 0x8
	private static XmlSchemaComplexType untypedAnyType; // 0x10
	private byte pvFlags; // 0xE8

	// Properties
	[XmlIgnore]
	internal static XmlSchemaComplexType AnyType { get; }
	[XmlIgnore]
	internal static XmlSchemaComplexType UntypedAnyType { get; }
	internal static ContentValidator AnyTypeContentValidator { get; }
	[Xml("abstract")]
	[DefaultValue(False)]
	public bool IsAbstract { get; set; }
	[DefaultValue(256)]
	[Xml("block")]
	public XmlSchemaDerivationMethod Block { get; set; }
	[DefaultValue(False)]
	[Xml("mixed")]
	public override bool IsMixed { get; set; }
	[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
	[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
	public XmlSchemaContentModel ContentModel { get; set; }
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnore]
	public XmlSchemaContentType ContentType { get; }
	[XmlIgnore]
	public XmlSchemaParticle ContentTypeParticle { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnore]
	public XmlSchemaAnyAttribute AttributeWildcard { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable LocalElements { get; }
	internal bool HasWildCard { set; }

	// Methods

	// RVA: 0x1F6DC30 Offset: 0x1F6CE30 VA: 0x181F6DC30
	private static void .cctor() { }

	// RVA: 0x1F6D290 Offset: 0x1F6C490 VA: 0x181F6D290
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x1F6DF40 Offset: 0x1F6D140 VA: 0x181F6DF40
	public void .ctor() { }

	// RVA: 0x1F6E020 Offset: 0x1F6D220 VA: 0x181F6E020
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x1F6E1E0 Offset: 0x1F6D3E0 VA: 0x181F6E1E0
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x1F6DFB0 Offset: 0x1F6D1B0 VA: 0x181F6DFB0
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x1F6E150 Offset: 0x1F6D350 VA: 0x181F6E150
	public bool get_IsAbstract() { }

	// RVA: 0x1F6E260 Offset: 0x1F6D460 VA: 0x181F6E260
	public void set_IsAbstract(bool value) { }

	// RVA: 0x838410 Offset: 0x837610 VA: 0x180838410
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x838420 Offset: 0x837620 VA: 0x180838420
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1F6E160 Offset: 0x1F6D360 VA: 0x181F6E160 Slot: 14
	public override bool get_IsMixed() { }

	// RVA: 0x1F6E290 Offset: 0x1F6D490 VA: 0x181F6E290 Slot: 15
	public override void set_IsMixed(bool value) { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0xB83400 Offset: 0xB82600 VA: 0x180B83400
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x1F6E0E0 Offset: 0x1F6D2E0 VA: 0x181F6E0E0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x146AE20 Offset: 0x146A020 VA: 0x18146AE20
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0x170E920 Offset: 0x170DB20 VA: 0x18170E920
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1F6E070 Offset: 0x1F6D270 VA: 0x181F6E070
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x1F6E170 Offset: 0x1F6D370 VA: 0x181F6E170
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x718950 Offset: 0x717B50 VA: 0x180718950
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x1C83160 Offset: 0x1C82360 VA: 0x181C83160
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x8A5A60 Offset: 0x8A4C60 VA: 0x1808A5A60
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1F6E230 Offset: 0x1F6D430 VA: 0x181F6E230
	internal void set_HasWildCard(bool value) { }

	// RVA: 0x88DF00 Offset: 0x88D100 VA: 0x18088DF00
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1F6D000 Offset: 0x1F6C200 VA: 0x181F6D000
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x1F6CFF0 Offset: 0x1F6C1F0 VA: 0x181F6CFF0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1F6C5F0 Offset: 0x1F6B7F0 VA: 0x181F6C5F0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1F6BCB0 Offset: 0x1F6AEB0 VA: 0x181F6BCB0
	private void ClearCompiledState() { }

	// RVA: 0x1F6BD30 Offset: 0x1F6AF30 VA: 0x181F6BD30
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1F6BFA0 Offset: 0x1F6B1A0 VA: 0x181F6BFA0
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x1F6C100 Offset: 0x1F6B300 VA: 0x181F6C100
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x1F6D740 Offset: 0x1F6C940 VA: 0x181F6D740
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x1F6D900 Offset: 0x1F6CB00 VA: 0x181F6D900
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x1F6D770 Offset: 0x1F6C970 VA: 0x181F6D770
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContent : XmlSchemaAnnotated // TypeDefIndex: 12405
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContentModel : XmlSchemaAnnotated // TypeDefIndex: 12406
{
	// Properties
	[XmlIgnore]
	public abstract XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	public abstract XmlSchemaContent get_Content();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_Content(XmlSchemaContent value);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaContentProcessing // TypeDefIndex: 12407
{
	// Fields
	public int value__; // 0x0
	[XmlIgnore]
	public const XmlSchemaContentProcessing None = 0;
	[XmlEnum("skip")]
	public const XmlSchemaContentProcessing Skip = 1;
	[XmlEnum("lax")]
	public const XmlSchemaContentProcessing Lax = 2;
	[XmlEnum("strict")]
	public const XmlSchemaContentProcessing Strict = 3;
}

// Namespace: System.Xml.Schema
public enum XmlSchemaContentType // TypeDefIndex: 12408
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaContentType TextOnly = 0;
	public const XmlSchemaContentType Empty = 1;
	public const XmlSchemaContentType ElementOnly = 2;
	public const XmlSchemaContentType Mixed = 3;
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaDatatype // TypeDefIndex: 12409
{
	// Properties
	public abstract Type ValueType { get; }
	public abstract XmlTokenizedType TokenizedType { get; }
	public virtual XmlSchemaDatatypeVariety Variety { get; }
	public virtual XmlTypeCode TypeCode { get; }
	internal abstract bool HasLexicalFacets { get; }
	internal abstract bool HasValueFacets { get; }
	internal abstract XmlValueConverter ValueConverter { get; }
	internal abstract RestrictionFacets Restriction { get; }
	internal abstract FacetsChecker FacetsChecker { get; }
	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal string TypeCodeString { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlTokenizedType get_TokenizedType();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 9
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool get_HasLexicalFacets();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool get_HasValueFacets();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract XmlValueConverter get_ValueConverter();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract RestrictionFacets get_Restriction();

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int Compare(object value1, object value2);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract FacetsChecker get_FacetsChecker();

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 22
	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

	// RVA: -1 Offset: -1 Slot: 23
	internal abstract bool IsEqual(object o1, object o2);

	// RVA: -1 Offset: -1 Slot: 24
	internal abstract bool IsComparable(XmlSchemaDatatype dtype);

	// RVA: 0x1F6F170 Offset: 0x1F6E370 VA: 0x181F6F170
	internal string get_TypeCodeString() { }

	// RVA: 0x1F6EA20 Offset: 0x1F6DC20 VA: 0x181F6EA20
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x1F6E2C0 Offset: 0x1F6D4C0 VA: 0x181F6E2C0
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x1F6E9D0 Offset: 0x1F6DBD0 VA: 0x181F6E9D0
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x1F6E980 Offset: 0x1F6DB80 VA: 0x181F6E980
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x1F6E930 Offset: 0x1F6DB30 VA: 0x181F6E930
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x1F6E8D0 Offset: 0x1F6DAD0 VA: 0x181F6E8D0
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x1F6EFB0 Offset: 0x1F6E1B0 VA: 0x181F6EFB0
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
[Flags]
public enum XmlSchemaDerivationMethod // TypeDefIndex: 12410
{
	// Fields
	public int value__; // 0x0
	[XmlEnum("")]
	public const XmlSchemaDerivationMethod Empty = 0;
	[XmlEnum("substitution")]
	public const XmlSchemaDerivationMethod Substitution = 1;
	[XmlEnum("extension")]
	public const XmlSchemaDerivationMethod Extension = 2;
	[XmlEnum("restriction")]
	public const XmlSchemaDerivationMethod Restriction = 4;
	[XmlEnum("list")]
	public const XmlSchemaDerivationMethod List = 8;
	[XmlEnum("union")]
	public const XmlSchemaDerivationMethod Union = 16;
	[XmlEnum("#all")]
	public const XmlSchemaDerivationMethod All = 255;
	[XmlIgnore]
	public const XmlSchemaDerivationMethod None = 256;
}

// Namespace: System.Xml.Schema
public class XmlSchemaDocumentation : XmlSchemaObject // TypeDefIndex: 12411
{
	// Fields
	private string source; // 0x38
	private string language; // 0x40
	private XmlNode[] markup; // 0x48
	private static XmlSchemaSimpleType languageType; // 0x0

	// Properties
	[Xml("source", DataType = "anyURI")]
	public string Source { set; }
	[Xml("xml:lang")]
	public string Language { set; }
	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup { set; }

	// Methods

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Source(string value) { }

	// RVA: 0x1F6F380 Offset: 0x1F6E580 VA: 0x181F6F380
	public void set_Language(string value) { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1F6F2D0 Offset: 0x1F6E4D0 VA: 0x181F6F2D0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaElement : XmlSchemaParticle // TypeDefIndex: 12412
{
	// Fields
	private bool isAbstract; // 0x78
	private bool hasAbstractAttribute; // 0x79
	private bool isNillable; // 0x7A
	private bool hasNillableAttribute; // 0x7B
	private bool isLocalTypeDerivationChecked; // 0x7C
	private XmlSchemaDerivationMethod block; // 0x80
	private XmlSchemaDerivationMethod final; // 0x84
	private XmlSchemaForm form; // 0x88
	private string defaultValue; // 0x90
	private string fixedValue; // 0x98
	private string name; // 0xA0
	private XmlQualifiedName refName; // 0xA8
	private XmlQualifiedName substitutionGroup; // 0xB0
	private XmlQualifiedName typeName; // 0xB8
	private XmlSchemaType type; // 0xC0
	private XmlQualifiedName qualifiedName; // 0xC8
	private XmlSchemaType elementType; // 0xD0
	private XmlSchemaDerivationMethod blockResolved; // 0xD8
	private XmlSchemaDerivationMethod finalResolved; // 0xDC
	private XmlSchemaObjectCollection constraints; // 0xE0
	private SchemaElementDecl elementDecl; // 0xE8

	// Properties
	[Xml("abstract")]
	[DefaultValue(False)]
	public bool IsAbstract { get; set; }
	[DefaultValue(256)]
	[Xml("block")]
	public XmlSchemaDerivationMethod Block { get; set; }
	[Xml("default")]
	[DefaultValue(null)]
	public string DefaultValue { get; set; }
	[Xml("final")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod Final { get; set; }
	[DefaultValue(null)]
	[Xml("fixed")]
	public string FixedValue { get; set; }
	[DefaultValue(0)]
	[Xml("form")]
	public XmlSchemaForm Form { get; set; }
	[Xml("name")]
	[DefaultValue("")]
	public string Name { get; set; }
	[DefaultValue(False)]
	[Xml("nillable")]
	public bool IsNillable { get; set; }
	[XmlIgnore]
	internal bool HasNillableAttribute { get; }
	[XmlIgnore]
	internal bool HasAbstractAttribute { get; }
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[Xml("substitutionGroup")]
	public XmlQualifiedName SubstitutionGroup { get; set; }
	[Xml("type")]
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	public XmlSchemaType SchemaType { get; set; }
	[XmlElement("key", typeof(XmlSchemaKey))]
	[XmlElement("keyref", typeof(XmlSchemaKeyref))]
	[XmlElement("unique", typeof(XmlSchemaUnique))]
	public XmlSchemaObjectCollection Constraints { get; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaType ElementSchemaType { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved { get; }
	internal bool HasConstraints { get; }
	internal bool IsLocalTypeDerivationChecked { get; set; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }
	[XmlIgnore]
	internal override string NameString { get; }

	// Methods

	// RVA: 0x61CC40 Offset: 0x61BE40 VA: 0x18061CC40
	public bool get_IsAbstract() { }

	// RVA: 0x1F6F8E0 Offset: 0x1F6EAE0 VA: 0x181F6F8E0
	public void set_IsAbstract(bool value) { }

	// RVA: 0x1A6BA60 Offset: 0x1A6AC60 VA: 0x181A6BA60
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x1A6BA80 Offset: 0x1A6AC80 VA: 0x181A6BA80
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public string get_DefaultValue() { }

	// RVA: 0x43B590 Offset: 0x43A790 VA: 0x18043B590
	public void set_DefaultValue(string value) { }

	// RVA: 0x772260 Offset: 0x771460 VA: 0x180772260
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x1B5E570 Offset: 0x1B5D770 VA: 0x181B5E570
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public string get_FixedValue() { }

	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	public void set_FixedValue(string value) { }

	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950
	public XmlSchemaForm get_Form() { }

	// RVA: 0x73BA10 Offset: 0x73AC10 VA: 0x18073BA10
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public string get_Name() { }

	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20
	public void set_Name(string value) { }

	// RVA: 0x1C16520 Offset: 0x1C15720 VA: 0x181C16520
	public bool get_IsNillable() { }

	// RVA: 0x1F6F900 Offset: 0x1F6EB00 VA: 0x181F6F900
	public void set_IsNillable(bool value) { }

	// RVA: 0x1C16530 Offset: 0x1C15730 VA: 0x181C16530
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x646CD0 Offset: 0x645ED0 VA: 0x180646CD0
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1F6F910 Offset: 0x1F6EB10 VA: 0x181F6F910
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x1F6FA50 Offset: 0x1F6EC50 VA: 0x181F6FA50
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x1F6F9B0 Offset: 0x1F6EBB0 VA: 0x181F6F9B0
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x718950 Offset: 0x717B50 VA: 0x180718950
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x1F6F810 Offset: 0x1F6EA10 VA: 0x181F6F810
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0x738340 Offset: 0x737540 VA: 0x180738340
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x190DC20 Offset: 0x190CE20 VA: 0x18190DC20
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1C61740 Offset: 0x1C60940 VA: 0x181C61740
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x1532B30 Offset: 0x1531D30 VA: 0x181532B30
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x599C80 Offset: 0x598E80 VA: 0x180599C80
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x190DC30 Offset: 0x190CE30 VA: 0x18190DC30
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1C62140 Offset: 0x1C61340 VA: 0x181C62140
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1F6F880 Offset: 0x1F6EA80 VA: 0x181F6F880
	internal bool get_HasConstraints() { }

	// RVA: 0x1701E00 Offset: 0x1701000 VA: 0x181701E00
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x1F6F8F0 Offset: 0x1F6EAF0 VA: 0x181F6F8F0
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x796090 Offset: 0x795290 VA: 0x180796090
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x7960E0 Offset: 0x7952E0 VA: 0x1807960E0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1F6F8B0 Offset: 0x1F6EAB0 VA: 0x181F6F8B0 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x1F6F710 Offset: 0x1F6E910 VA: 0x181F6F710 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1F6F480 Offset: 0x1F6E680 VA: 0x181F6F480
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1F6F720 Offset: 0x1F6E920 VA: 0x181F6F720
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaException : SystemException // TypeDefIndex: 12413
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string sourceUri; // 0xA0
	private int lineNumber; // 0xA8
	private int linePosition; // 0xAC
	private XmlSchemaObject sourceSchemaObject; // 0xB0
	private string message; // 0xB8

	// Properties
	internal string GetRes { get; }
	internal string[] Args { get; }
	public string SourceUri { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public XmlSchemaObject SourceSchemaObject { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1F6FEE0 Offset: 0x1F6F0E0 VA: 0x181F6FEE0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1F6FB60 Offset: 0x1F6ED60 VA: 0x181F6FB60 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1F703E0 Offset: 0x1F6F5E0 VA: 0x181F703E0
	public void .ctor() { }

	// RVA: 0x1F705A0 Offset: 0x1F6F7A0 VA: 0x181F705A0
	public void .ctor(string message) { }

	// RVA: 0x1F70410 Offset: 0x1F6F610 VA: 0x181F70410
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1F70680 Offset: 0x1F6F880 VA: 0x181F70680
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1F70790 Offset: 0x1F6F990 VA: 0x181F70790
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x1F70430 Offset: 0x1F6F630 VA: 0x181F70430
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1F702F0 Offset: 0x1F6F4F0 VA: 0x181F702F0
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1F6FDA0 Offset: 0x1F6EFA0 VA: 0x181F6FDA0
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1F6FD10 Offset: 0x1F6EF10 VA: 0x181F6FD10
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1F6FE30 Offset: 0x1F6F030 VA: 0x181F6FE30
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x1F70810 Offset: 0x1F6FA10 VA: 0x181F70810
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x1F705C0 Offset: 0x1F6F7C0 VA: 0x181F705C0
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x1F70500 Offset: 0x1F6F700 VA: 0x181F70500
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x1F6FB10 Offset: 0x1F6ED10 VA: 0x181F6FB10
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	internal string get_GetRes() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	internal string[] get_Args() { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public string get_SourceUri() { }

	// RVA: 0x146AEB0 Offset: 0x146A0B0 VA: 0x18146AEB0
	public int get_LineNumber() { }

	// RVA: 0x738040 Offset: 0x737240 VA: 0x180738040
	public int get_LinePosition() { }

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x1F6FCB0 Offset: 0x1F6EEB0 VA: 0x181F6FCB0
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x88DF00 Offset: 0x88D100 VA: 0x18088DF00
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x1F6FCD0 Offset: 0x1F6EED0 VA: 0x181F6FCD0
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x1F70920 Offset: 0x1F6FB20 VA: 0x181F70920 Slot: 5
	public override string get_Message() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaExternal : XmlSchemaObject // TypeDefIndex: 12414
{
	// Fields
	private string location; // 0x38
	private Uri baseUri; // 0x40
	private XmlSchema schema; // 0x48
	private string id; // 0x50
	private XmlAttribute[] moreAttributes; // 0x58
	private Compositor compositor; // 0x60

	// Properties
	[Xml("schemaLocation", DataType = "anyURI")]
	public string SchemaLocation { get; set; }
	[XmlIgnore]
	public XmlSchema Schema { get; set; }
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlIgnore]
	internal Uri BaseUri { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }
	internal Compositor Compositor { get; set; }

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_SchemaLocation() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_SchemaLocation(string value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public XmlSchema get_Schema() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Id() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Id(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal Uri get_BaseUri() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	internal Compositor get_Compositor() { }

	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal enum FacetType // TypeDefIndex: 12415
{
	// Fields
	public int value__; // 0x0
	public const FacetType None = 0;
	public const FacetType Length = 1;
	public const FacetType MinLength = 2;
	public const FacetType MaxLength = 3;
	public const FacetType Pattern = 4;
	public const FacetType Whitespace = 5;
	public const FacetType Enumeration = 6;
	public const FacetType MinExclusive = 7;
	public const FacetType MinInclusive = 8;
	public const FacetType MaxExclusive = 9;
	public const FacetType MaxInclusive = 10;
	public const FacetType TotalDigits = 11;
	public const FacetType FractionDigits = 12;
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaFacet : XmlSchemaAnnotated // TypeDefIndex: 12416
{
	// Fields
	private string value; // 0x50
	private bool isFixed; // 0x58
	private FacetType facetType; // 0x5C

	// Properties
	[Xml("value")]
	public string Value { get; set; }
	[DefaultValue(False)]
	[Xml("fixed")]
	public virtual bool IsFixed { get; set; }
	internal FacetType FacetType { get; set; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Value() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Value(string value) { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30 Slot: 14
	public virtual bool get_IsFixed() { }

	// RVA: 0x1F70940 Offset: 0x1F6FB40 VA: 0x181F70940 Slot: 15
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10
	internal FacetType get_FacetType() { }

	// RVA: 0x4EDE90 Offset: 0x4ED090 VA: 0x1804EDE90
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaNumericFacet : XmlSchemaFacet // TypeDefIndex: 12417
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 12418
{
	// Methods

	// RVA: 0x1F71210 Offset: 0x1F70410 VA: 0x181F71210
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 12419
{
	// Methods

	// RVA: 0x1F712D0 Offset: 0x1F704D0 VA: 0x181F712D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 12420
{
	// Methods

	// RVA: 0x1F71270 Offset: 0x1F70470 VA: 0x181F71270
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaPatternFacet : XmlSchemaFacet // TypeDefIndex: 12421
{
	// Methods

	// RVA: 0x1F719A0 Offset: 0x1F70BA0 VA: 0x181F719A0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaEnumerationFacet : XmlSchemaFacet // TypeDefIndex: 12422
{
	// Methods

	// RVA: 0x1F6FAF0 Offset: 0x1F6ECF0 VA: 0x181F6FAF0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 12423
{
	// Methods

	// RVA: 0x1F71290 Offset: 0x1F70490 VA: 0x181F71290
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 12424
{
	// Methods

	// RVA: 0x1F712B0 Offset: 0x1F704B0 VA: 0x181F712B0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 12425
{
	// Methods

	// RVA: 0x1F71230 Offset: 0x1F70430 VA: 0x181F71230
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 12426
{
	// Methods

	// RVA: 0x1F71250 Offset: 0x1F70450 VA: 0x181F71250
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 12427
{
	// Methods

	// RVA: 0x1F719C0 Offset: 0x1F70BC0 VA: 0x181F719C0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 12428
{
	// Methods

	// RVA: 0x1F70A10 Offset: 0x1F6FC10 VA: 0x181F70A10
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet // TypeDefIndex: 12429
{
	// Methods

	// RVA: 0x1F719E0 Offset: 0x1F70BE0 VA: 0x181F719E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaForm // TypeDefIndex: 12430
{
	// Fields
	public int value__; // 0x0
	[XmlIgnore]
	public const XmlSchemaForm None = 0;
	[XmlEnum("qualified")]
	public const XmlSchemaForm Qualified = 1;
	[XmlEnum("unqualified")]
	public const XmlSchemaForm Unqualified = 2;
}

// Namespace: System.Xml.Schema
public class XmlSchemaGroup : XmlSchemaAnnotated // TypeDefIndex: 12431
{
	// Fields
	private string name; // 0x50
	private XmlSchemaGroupBase particle; // 0x58
	private XmlSchemaParticle canonicalParticle; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaGroup redefined; // 0x70
	private int selfReferenceCount; // 0x78

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaGroupBase Particle { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal XmlSchemaParticle CanonicalParticle { get; set; }
	[XmlIgnore]
	internal XmlSchemaGroup Redefined { get; set; }
	[XmlIgnore]
	internal int SelfReferenceCount { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Name() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Name(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990
	internal int get_SelfReferenceCount() { }

	// RVA: 0x4EDD40 Offset: 0x4ECF40 VA: 0x1804EDD40
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1F70D60 Offset: 0x1F6FF60 VA: 0x181F70D60 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1F70BB0 Offset: 0x1F6FDB0 VA: 0x181F70BB0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1F70D70 Offset: 0x1F6FF70 VA: 0x181F70D70
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaGroupBase : XmlSchemaParticle // TypeDefIndex: 12432
{
	// Properties
	[XmlIgnore]
	public abstract XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract XmlSchemaObjectCollection get_Items();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void SetItems(XmlSchemaObjectCollection newItems);

	// RVA: 0x1F70A30 Offset: 0x1F6FC30 VA: 0x181F70A30
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaGroupRef : XmlSchemaParticle // TypeDefIndex: 12433
{
	// Fields
	private XmlQualifiedName refName; // 0x78
	private XmlSchemaGroupBase particle; // 0x80
	private XmlSchemaGroup refined; // 0x88

	// Properties
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[XmlIgnore]
	public XmlSchemaGroupBase Particle { get; }
	[XmlIgnore]
	internal XmlSchemaGroup Redefined { get; set; }

	// Methods

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1F70B10 Offset: 0x1F6FD10 VA: 0x181F70B10
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1F70A80 Offset: 0x1F6FC80 VA: 0x181F70A80
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated // TypeDefIndex: 12434
{
	// Fields
	private string name; // 0x50
	private XmlSchemaXPath selector; // 0x58
	private XmlSchemaObjectCollection fields; // 0x60
	private XmlQualifiedName qualifiedName; // 0x68
	private CompiledIdentityConstraint compiledConstraint; // 0x70

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("selector", typeof(XmlSchemaXPath))]
	public XmlSchemaXPath Selector { get; set; }
	[XmlElement("field", typeof(XmlSchemaXPath))]
	public XmlSchemaObjectCollection Fields { get; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal CompiledIdentityConstraint CompiledConstraint { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Name() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Name(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1F70DE0 Offset: 0x1F6FFE0 VA: 0x181F70DE0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaXPath : XmlSchemaAnnotated // TypeDefIndex: 12435
{
	// Fields
	private string xpath; // 0x50

	// Properties
	[Xml("xpath")]
	[DefaultValue("")]
	public string XPath { get; set; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_XPath() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_XPath(string value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaUnique : XmlSchemaIdentityConstraint // TypeDefIndex: 12436
{
	// Methods

	// RVA: 0x1F71080 Offset: 0x1F70280 VA: 0x181F71080
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaKey : XmlSchemaIdentityConstraint // TypeDefIndex: 12437
{
	// Methods

	// RVA: 0x1F71080 Offset: 0x1F70280 VA: 0x181F71080
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaKeyref : XmlSchemaIdentityConstraint // TypeDefIndex: 12438
{
	// Fields
	private XmlQualifiedName refer; // 0x78

	// Properties
	[Xml("refer")]
	public XmlQualifiedName Refer { get; set; }

	// Methods

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public XmlQualifiedName get_Refer() { }

	// RVA: 0x1F71170 Offset: 0x1F70370 VA: 0x181F71170
	public void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x1F71090 Offset: 0x1F70290 VA: 0x181F71090
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaImport : XmlSchemaExternal // TypeDefIndex: 12439
{
	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Properties
	[Xml("namespace", DataType = "anyURI")]
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x1F70E80 Offset: 0x1F70080 VA: 0x181F70E80
	public void .ctor() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public string get_Namespace() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_Namespace(string value) { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaInclude : XmlSchemaExternal // TypeDefIndex: 12440
{
	// Fields
	private XmlSchemaAnnotation annotation; // 0x68

	// Methods

	// RVA: 0x1F70EA0 Offset: 0x1F700A0 VA: 0x181F70EA0
	public void .ctor() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaInfo : IXmlSchemaInfo // TypeDefIndex: 12441
{
	// Fields
	private bool isDefault; // 0x10
	private bool isNil; // 0x11
	private XmlSchemaElement schemaElement; // 0x18
	private XmlSchemaAttribute schemaAttribute; // 0x20
	private XmlSchemaType schemaType; // 0x28
	private XmlSchemaSimpleType memberType; // 0x30
	private XmlSchemaValidity validity; // 0x38
	private XmlSchemaContentType contentType; // 0x3C

	// Properties
	public XmlSchemaValidity Validity { get; set; }
	public bool IsDefault { get; set; }
	public bool IsNil { get; set; }
	public XmlSchemaSimpleType MemberType { get; set; }
	public XmlSchemaType SchemaType { get; set; }
	public XmlSchemaElement SchemaElement { get; set; }
	public XmlSchemaAttribute SchemaAttribute { get; set; }
	public XmlSchemaContentType ContentType { get; }
	internal XmlSchemaType XmlType { get; }
	internal bool HasDefaultValue { get; }
	internal bool IsUnionType { get; }

	// Methods

	// RVA: 0x1F70F40 Offset: 0x1F70140 VA: 0x181F70F40
	public void .ctor() { }

	// RVA: 0x1F70EF0 Offset: 0x1F700F0 VA: 0x181F70EF0
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 4
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 5
	public bool get_IsDefault() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_IsDefault(bool value) { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0 Slot: 6
	public bool get_IsNil() { }

	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_IsNil(bool value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 7
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x1F71060 Offset: 0x1F70260 VA: 0x181F71060
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1F71040 Offset: 0x1F70240 VA: 0x181F71040
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 10
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1F71020 Offset: 0x1F70220 VA: 0x181F71020
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1F71000 Offset: 0x1F70200 VA: 0x181F71000
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x1F70F80 Offset: 0x1F70180 VA: 0x181F70F80
	internal bool get_HasDefaultValue() { }

	// RVA: 0x1F70FC0 Offset: 0x1F701C0 VA: 0x181F70FC0
	internal bool get_IsUnionType() { }

	// RVA: 0x1F70EC0 Offset: 0x1F700C0 VA: 0x181F70EC0
	internal void Clear() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaNotation : XmlSchemaAnnotated // TypeDefIndex: 12442
{
	// Fields
	private string name; // 0x50
	private string publicId; // 0x58
	private string systemId; // 0x60
	private XmlQualifiedName qname; // 0x68

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[Xml("public")]
	public string Public { get; set; }
	[Xml("system")]
	public string System { get; set; }
	[XmlIgnore]
	internal XmlQualifiedName QualifiedName { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Name() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Name(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_Public() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Public(string value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_System() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_System(string value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1F712F0 Offset: 0x1F704F0 VA: 0x181F712F0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaObject // TypeDefIndex: 12443
{
	// Fields
	private int lineNum; // 0x10
	private int linePos; // 0x14
	private string sourceUri; // 0x18
	private XmlSerializerNamespaces namespaces; // 0x20
	private XmlSchemaObject parent; // 0x28
	private bool isProcessing; // 0x30

	// Properties
	[XmlIgnore]
	public int LineNumber { get; set; }
	[XmlIgnore]
	public int LinePosition { get; set; }
	[XmlIgnore]
	public string SourceUri { get; set; }
	[XmlIgnore]
	public XmlSchemaObject Parent { get; set; }
	[XmlNamespaceDeclarations]
	public XmlSerializerNamespaces Namespaces { get; set; }
	[XmlIgnore]
	internal virtual string IdAttribute { get; set; }
	[XmlIgnore]
	internal virtual string NameAttribute { get; set; }
	[XmlIgnore]
	internal bool IsProcessing { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_LineNumber() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_LineNumber(int value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_LinePosition() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_LinePosition(int value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_SourceUri() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_SourceUri(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x1F71930 Offset: 0x1F70B30 VA: 0x181F71930
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	internal virtual string get_IdAttribute() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 11
	internal virtual string get_NameAttribute() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	internal bool get_IsProcessing() { }

	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x1F718A0 Offset: 0x1F70AA0 VA: 0x181F718A0 Slot: 13
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
public class XmlSchemaObjectCollection : CollectionBase // TypeDefIndex: 12444
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Properties
	public virtual XmlSchemaObject Item { get; set; }

	// Methods

	// RVA: 0x154B280 Offset: 0x154A480 VA: 0x18154B280
	public void .ctor() { }

	// RVA: 0x1F71750 Offset: 0x1F70950 VA: 0x181F71750 Slot: 29
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x1F71820 Offset: 0x1F70A20 VA: 0x181F71820 Slot: 30
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x1F71480 Offset: 0x1F70680 VA: 0x181F71480
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x1F71390 Offset: 0x1F70590 VA: 0x181F71390
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x1F71500 Offset: 0x1F70700 VA: 0x181F71500
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x1F71680 Offset: 0x1F70880 VA: 0x181F71680
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x1F715B0 Offset: 0x1F707B0 VA: 0x181F715B0 Slot: 21
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x1F71610 Offset: 0x1F70810 VA: 0x181F71610 Slot: 20
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x1F71580 Offset: 0x1F70780 VA: 0x181F71580 Slot: 22
	protected override void OnClear() { }

	// RVA: 0x1F715E0 Offset: 0x1F707E0 VA: 0x181F715E0 Slot: 23
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x1F71400 Offset: 0x1F70600 VA: 0x181F71400
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x1F71360 Offset: 0x1F70560 VA: 0x181F71360
	private void Add(XmlSchemaObjectCollection collToAdd) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectEnumerator : IEnumerator // TypeDefIndex: 12445
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public XmlSchemaObject Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(IEnumerator enumerator) { }

	// RVA: 0x1F79E10 Offset: 0x1F79010 VA: 0x181F79E10
	public bool MoveNext() { }

	// RVA: 0x1F79F50 Offset: 0x1F79150 VA: 0x181F79F50
	public XmlSchemaObject get_Current() { }

	// RVA: 0x1F79EB0 Offset: 0x1F790B0 VA: 0x181F79EB0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1F79E60 Offset: 0x1F79060 VA: 0x181F79E60 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1F79F00 Offset: 0x1F79100 VA: 0x181F79F00 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
internal enum XmlSchemaObjectTable.EnumeratorType // TypeDefIndex: 12446
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaObjectTable.EnumeratorType Keys = 0;
	public const XmlSchemaObjectTable.EnumeratorType Values = 1;
	public const XmlSchemaObjectTable.EnumeratorType DictionaryEntry = 2;
}

// Namespace: 
internal struct XmlSchemaObjectTable.XmlSchemaObjectEntry // TypeDefIndex: 12447
{
	// Fields
	internal XmlQualifiedName qname; // 0x0
	internal XmlSchemaObject xso; // 0x8

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(XmlQualifiedName name, XmlSchemaObject value) { }
}

// Namespace: 
internal class XmlSchemaObjectTable.ValuesCollection : ICollection, IEnumerable // TypeDefIndex: 12448
{
	// Fields
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private int size; // 0x18

	// Properties
	public int Count { get; }
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }

	// Methods

	// RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 5
	public int get_Count() { }

	// RVA: 0x1F73050 Offset: 0x1F72250 VA: 0x181F73050 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1F73000 Offset: 0x1F72200 VA: 0x181F73000 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1F72E40 Offset: 0x1F72040 VA: 0x181F72E40 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1F72F80 Offset: 0x1F72180 VA: 0x181F72F80 Slot: 8
	public IEnumerator GetEnumerator() { }
}

// Namespace: 
internal class XmlSchemaObjectTable.XSOEnumerator : IEnumerator // TypeDefIndex: 12449
{
	// Fields
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private XmlSchemaObjectTable.EnumeratorType enumType; // 0x18
	protected int currentIndex; // 0x1C
	protected int size; // 0x20
	protected XmlQualifiedName currentKey; // 0x28
	protected XmlSchemaObject currentValue; // 0x30

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1F730A0 Offset: 0x1F722A0 VA: 0x181F730A0
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x1F73680 Offset: 0x1F72880 VA: 0x181F73680 Slot: 5
	public object get_Current() { }

	// RVA: 0x1F735B0 Offset: 0x1F727B0 VA: 0x181F735B0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1F73660 Offset: 0x1F72860 VA: 0x181F73660 Slot: 6
	public void Reset() { }
}

// Namespace: 
internal class XmlSchemaObjectTable.XSODictionaryEnumerator : XmlSchemaObjectTable.XSOEnumerator, IDictionaryEnumerator, IEnumerator // TypeDefIndex: 12450
{
	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1F730A0 Offset: 0x1F722A0 VA: 0x181F730A0
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x1F730F0 Offset: 0x1F722F0 VA: 0x181F730F0 Slot: 9
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1F73290 Offset: 0x1F72490 VA: 0x181F73290 Slot: 7
	public object get_Key() { }

	// RVA: 0x1F73420 Offset: 0x1F72620 VA: 0x181F73420 Slot: 8
	public object get_Value() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
public class XmlSchemaObjectTable // TypeDefIndex: 12451
{
	// Fields
	private Dictionary<XmlQualifiedName, XmlSchemaObject> table; // 0x10
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Properties
	public int Count { get; }
	public XmlSchemaObject Item { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x1F7A620 Offset: 0x1F79820 VA: 0x181F7A620
	internal void .ctor() { }

	// RVA: 0x1F7A000 Offset: 0x1F79200 VA: 0x181F7A000
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1F7A360 Offset: 0x1F79560 VA: 0x181F7A360
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1F7A530 Offset: 0x1F79730 VA: 0x181F7A530
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1F7A110 Offset: 0x1F79310 VA: 0x181F7A110
	internal void Clear() { }

	// RVA: 0x1F7A470 Offset: 0x1F79670 VA: 0x181F7A470
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x1F7A200 Offset: 0x1F79400 VA: 0x181F7A200
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x1F7A6D0 Offset: 0x1F798D0 VA: 0x181F7A6D0
	public int get_Count() { }

	// RVA: 0x1F7A1A0 Offset: 0x1F793A0 VA: 0x181F7A1A0
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x1F7A720 Offset: 0x1F79920 VA: 0x181F7A720
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x1F7A7A0 Offset: 0x1F799A0 VA: 0x181F7A7A0
	public ICollection get_Values() { }

	// RVA: 0x1F7A2C0 Offset: 0x1F794C0 VA: 0x181F7A2C0
	public IDictionaryEnumerator GetEnumerator() { }
}

// Namespace: 
[Flags]
private enum XmlSchemaParticle.Occurs // TypeDefIndex: 12452
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaParticle.Occurs None = 0;
	public const XmlSchemaParticle.Occurs Min = 1;
	public const XmlSchemaParticle.Occurs Max = 2;
}

// Namespace: 
private class XmlSchemaParticle.EmptyParticle : XmlSchemaParticle // TypeDefIndex: 12453
{
	// Properties
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x1F72D40 Offset: 0x1F71F40 VA: 0x181F72D40
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaParticle : XmlSchemaAnnotated // TypeDefIndex: 12454
{
	// Fields
	private Decimal minOccurs; // 0x50
	private Decimal maxOccurs; // 0x60
	private XmlSchemaParticle.Occurs flags; // 0x70
	internal static readonly XmlSchemaParticle Empty; // 0x0

	// Properties
	[Xml("minOccurs")]
	public string MinOccursString { get; set; }
	[Xml("maxOccurs")]
	public string MaxOccursString { get; set; }
	[XmlIgnore]
	public Decimal MinOccurs { get; set; }
	[XmlIgnore]
	public Decimal MaxOccurs { get; set; }
	internal virtual bool IsEmpty { get; }
	internal virtual string NameString { get; }

	// Methods

	// RVA: 0x1F7AD00 Offset: 0x1F79F00 VA: 0x181F7AD00
	public string get_MinOccursString() { }

	// RVA: 0x1F7B1A0 Offset: 0x1F7A3A0 VA: 0x181F7B1A0
	public void set_MinOccursString(string value) { }

	// RVA: 0x1F7ABE0 Offset: 0x1F79DE0 VA: 0x181F7ABE0
	public string get_MaxOccursString() { }

	// RVA: 0x1F7ADB0 Offset: 0x1F79FB0 VA: 0x181F7ADB0
	public void set_MaxOccursString(string value) { }

	// RVA: 0xC5DC80 Offset: 0xC5CE80 VA: 0x180C5DC80
	public Decimal get_MinOccurs() { }

	// RVA: 0x1F7B310 Offset: 0x1F7A510 VA: 0x181F7B310
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0x12DC690 Offset: 0x12DB890 VA: 0x1812DC690
	public Decimal get_MaxOccurs() { }

	// RVA: 0x1F7AFF0 Offset: 0x1F7A1F0 VA: 0x181F7AFF0
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x1F7AB60 Offset: 0x1F79D60 VA: 0x181F7AB60 Slot: 14
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x1F7AD70 Offset: 0x1F79F70 VA: 0x181F7AD70 Slot: 15
	internal virtual string get_NameString() { }

	// RVA: 0x1F7A830 Offset: 0x1F79A30 VA: 0x181F7A830
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x1F7AAE0 Offset: 0x1F79CE0 VA: 0x181F7AAE0
	protected void .ctor() { }

	// RVA: 0x1F7A9F0 Offset: 0x1F79BF0 VA: 0x181F7A9F0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaRedefine : XmlSchemaExternal // TypeDefIndex: 12455
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x68
	private XmlSchemaObjectTable attributeGroups; // 0x70
	private XmlSchemaObjectTable types; // 0x78
	private XmlSchemaObjectTable groups; // 0x80

	// Properties
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Groups { get; }

	// Methods

	// RVA: 0x1F7B480 Offset: 0x1F7A680 VA: 0x181F7B480
	public void .ctor() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x1F7B460 Offset: 0x1F7A660 VA: 0x181F7B460 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSequence : XmlSchemaGroupBase // TypeDefIndex: 12456
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1F7B740 Offset: 0x1F7A940 VA: 0x181F7B740 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1F7B6E0 Offset: 0x1F7A8E0 VA: 0x181F7B6E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSet // TypeDefIndex: 12457
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private SortedList schemas; // 0x20
	private ValidationEventHandler internalEventHandler; // 0x28
	private ValidationEventHandler eventHandler; // 0x30
	private bool isCompiled; // 0x38
	private Hashtable schemaLocations; // 0x40
	private Hashtable chameleonSchemas; // 0x48
	private Hashtable targetNamespaces; // 0x50
	private bool compileAll; // 0x58
	private SchemaInfo cachedCompiledInfo; // 0x60
	private XmlReaderSettings readerSettings; // 0x68
	private XmlSchema schemaForSchema; // 0x70
	private XmlSchemaCompilationSettings compilationSettings; // 0x78
	internal XmlSchemaObjectTable elements; // 0x80
	internal XmlSchemaObjectTable attributes; // 0x88
	internal XmlSchemaObjectTable schemaTypes; // 0x90
	internal XmlSchemaObjectTable substitutionGroups; // 0x98
	private XmlSchemaObjectTable typeExtensions; // 0xA0
	private object internalSyncObject; // 0xA8

	// Properties
	internal object InternalSyncObject { get; }
	public bool IsCompiled { get; }
	public XmlResolver XmlResolver { set; }
	public XmlSchemaCompilationSettings CompilationSettings { get; set; }
	public int Count { get; }
	public XmlSchemaObjectTable GlobalElements { get; }
	public XmlSchemaObjectTable GlobalAttributes { get; }
	public XmlSchemaObjectTable GlobalTypes { get; }
	internal XmlSchemaObjectTable SubstitutionGroups { get; }
	internal Hashtable SchemaLocations { get; }
	internal XmlSchemaObjectTable TypeExtensions { get; }
	internal SchemaInfo CompiledInfo { get; }
	internal XmlReaderSettings ReaderSettings { get; }
	internal SortedList SortedSchemas { get; }

	// Methods

	// RVA: 0x1F83040 Offset: 0x1F82240 VA: 0x181F83040
	internal object get_InternalSyncObject() { }

	// RVA: 0x1F82AD0 Offset: 0x1F81CD0 VA: 0x181F82AD0
	public void .ctor() { }

	// RVA: 0x1F82B30 Offset: 0x1F81D30 VA: 0x181F82B30
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1F82DB0 Offset: 0x1F81FB0 VA: 0x181F82DB0
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1F831A0 Offset: 0x1F823A0 VA: 0x181F831A0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_IsCompiled() { }

	// RVA: 0x1F83250 Offset: 0x1F82450 VA: 0x181F83250
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x1F82EC0 Offset: 0x1F820C0 VA: 0x181F82EC0
	public int get_Count() { }

	// RVA: 0x1F82F60 Offset: 0x1F82160 VA: 0x181F82F60
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x1F82EF0 Offset: 0x1F820F0 VA: 0x181F82EF0
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x1F82FD0 Offset: 0x1F821D0 VA: 0x181F82FD0
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x1F830C0 Offset: 0x1F822C0 VA: 0x181F830C0
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x1F83130 Offset: 0x1F82330 VA: 0x181F83130
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x1F7C070 Offset: 0x1F7B270 VA: 0x181F7C070
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x1F7CC60 Offset: 0x1F7BE60 VA: 0x181F7CC60
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x1F80150 Offset: 0x1F7F350 VA: 0x181F80150
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x1F7D540 Offset: 0x1F7C740 VA: 0x181F7D540
	public bool Contains(string targetNamespace) { }

	// RVA: 0x1F7D020 Offset: 0x1F7C220 VA: 0x181F7D020
	public void Compile() { }

	// RVA: 0x1F81C10 Offset: 0x1F80E10 VA: 0x181F81C10
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x1F7E860 Offset: 0x1F7DA60 VA: 0x181F7E860
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x1F82900 Offset: 0x1F81B00 VA: 0x181F82900
	public ICollection Schemas() { }

	// RVA: 0x1F82730 Offset: 0x1F81930 VA: 0x181F82730
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x1F7C010 Offset: 0x1F7B210 VA: 0x181F7C010
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x1F7C7E0 Offset: 0x1F7B9E0 VA: 0x181F7C7E0
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x1F7EA00 Offset: 0x1F7DC00 VA: 0x181F7EA00
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x1F7B7F0 Offset: 0x1F7A9F0 VA: 0x181F7B7F0
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x1F7FE00 Offset: 0x1F7F000 VA: 0x181F7FE00
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x1F82350 Offset: 0x1F81550 VA: 0x181F82350
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x1F81900 Offset: 0x1F80B00 VA: 0x181F81900
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x1F7CE30 Offset: 0x1F7C030 VA: 0x181F7CE30
	private void ClearTables() { }

	// RVA: 0x1F7FCF0 Offset: 0x1F7EEF0 VA: 0x181F7FCF0
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	// RVA: 0x1F7FBD0 Offset: 0x1F7EDD0 VA: 0x181F7FBD0
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x1F7D5C0 Offset: 0x1F7C7C0 VA: 0x181F7D5C0
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x1F7EC90 Offset: 0x1F7DE90 VA: 0x181F7EC90
	internal XmlResolver GetResolver() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1F7EE40 Offset: 0x1F7E040 VA: 0x181F7EE40
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x1F7EFA0 Offset: 0x1F7E1A0 VA: 0x181F7EFA0
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	// RVA: 0x1F7ECB0 Offset: 0x1F7DEB0 VA: 0x181F7ECB0
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	// RVA: 0x1F7EEF0 Offset: 0x1F7E0F0 VA: 0x181F7EEF0
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x1F80A10 Offset: 0x1F7FC10 VA: 0x181F80A10
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x1F80E70 Offset: 0x1F80070 VA: 0x181F80E70
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x1F7BC10 Offset: 0x1F7AE10 VA: 0x181F7BC10
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1F829F0 Offset: 0x1F81BF0 VA: 0x181F829F0
	private void VerifyTables() { }

	// RVA: 0x1F7EF50 Offset: 0x1F7E150 VA: 0x181F7EF50
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x1F82930 Offset: 0x1F81B30 VA: 0x181F82930
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContent : XmlSchemaContentModel // TypeDefIndex: 12458
{
	// Fields
	private XmlSchemaContent content; // 0x50

	// Properties
	[XmlElement("extension", typeof(XmlSchemaSimpleContentExtension))]
	[XmlElement("restriction", typeof(XmlSchemaSimpleContentRestriction))]
	public override XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentExtension : XmlSchemaContent // TypeDefIndex: 12459
{
	// Fields
	private XmlSchemaObjectCollection attributes; // 0x50
	private XmlSchemaAnyAttribute anyAttribute; // 0x58
	private XmlQualifiedName baseTypeName; // 0x60

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1F83310 Offset: 0x1F82510 VA: 0x181F83310
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1F83270 Offset: 0x1F82470 VA: 0x181F83270
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentRestriction : XmlSchemaContent // TypeDefIndex: 12460
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60
	private XmlSchemaObjectCollection attributes; // 0x68
	private XmlSchemaAnyAttribute anyAttribute; // 0x70

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	public XmlSchemaObjectCollection Facets { get; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1F83470 Offset: 0x1F82670 VA: 0x181F83470
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1F833B0 Offset: 0x1F825B0 VA: 0x181F833B0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleType : XmlSchemaType // TypeDefIndex: 12461
{
	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Properties
	[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
	[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
	[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
	public XmlSchemaSimpleTypeContent Content { get; set; }

	// Methods

	// RVA: 0x1F83D20 Offset: 0x1F82F20 VA: 0x181F83D20
	public void .ctor() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0x1F83BE0 Offset: 0x1F82DE0 VA: 0x181F83BE0 Slot: 13
	internal override XmlSchemaObject Clone() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated // TypeDefIndex: 12462
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent // TypeDefIndex: 12463
{
	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Properties
	[Xml("itemType")]
	public XmlQualifiedName ItemTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType ItemType { get; set; }
	[XmlIgnore]
	public XmlSchemaSimpleType BaseItemType { get; set; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0x1F836B0 Offset: 0x1F828B0 VA: 0x181F836B0
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x1F83510 Offset: 0x1F82710 VA: 0x181F83510 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1F83640 Offset: 0x1F82840 VA: 0x181F83640
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent // TypeDefIndex: 12464
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	public XmlSchemaObjectCollection Facets { get; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1F83920 Offset: 0x1F82B20 VA: 0x181F83920
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x1F83750 Offset: 0x1F82950 VA: 0x181F83750 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1F83880 Offset: 0x1F82A80 VA: 0x181F83880
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent // TypeDefIndex: 12465
{
	// Fields
	private XmlSchemaObjectCollection baseTypes; // 0x50
	private XmlQualifiedName[] memberTypes; // 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; // 0x60

	// Properties
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection BaseTypes { get; }
	[Xml("memberTypes")]
	public XmlQualifiedName[] MemberTypes { get; set; }
	[XmlIgnore]
	public XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0x1F839C0 Offset: 0x1F82BC0 VA: 0x181F839C0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1F83B80 Offset: 0x1F82D80 VA: 0x181F83B80
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroup : XmlSchemaObject // TypeDefIndex: 12466
{
	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Properties
	[XmlIgnore]
	internal ArrayList Members { get; }
	[XmlIgnore]
	internal XmlQualifiedName Examplar { get; set; }

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal ArrayList get_Members() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0x1F83E70 Offset: 0x1F83070 VA: 0x181F83E70
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup // TypeDefIndex: 12467
{
	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Properties
	[XmlIgnore]
	internal XmlSchemaChoice Choice { get; }

	// Methods

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal XmlSchemaChoice get_Choice() { }

	// RVA: 0x1F83DA0 Offset: 0x1F82FA0 VA: 0x181F83DA0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaType : XmlSchemaAnnotated // TypeDefIndex: 12468
{
	// Fields
	private string name; // 0x50
	private XmlSchemaDerivationMethod final; // 0x58
	private XmlSchemaDerivationMethod derivedBy; // 0x5C
	private XmlSchemaType baseSchemaType; // 0x60
	private XmlSchemaDatatype datatype; // 0x68
	private XmlSchemaDerivationMethod finalResolved; // 0x70
	private SchemaElementDecl elementDecl; // 0x78
	private XmlQualifiedName qname; // 0x80
	private XmlSchemaType redefined; // 0x88
	private XmlSchemaContentType contentType; // 0x90

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[Xml("final")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod Final { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved { get; }
	[XmlIgnore]
	public XmlSchemaType BaseXmlSchemaType { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod DerivedBy { get; }
	[XmlIgnore]
	public XmlSchemaDatatype Datatype { get; }
	[XmlIgnore]
	public virtual bool IsMixed { get; set; }
	[XmlIgnore]
	public XmlTypeCode TypeCode { get; }
	[XmlIgnore]
	internal XmlValueConverter ValueConverter { get; }
	internal XmlSchemaContentType SchemaContentType { get; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnore]
	internal XmlSchemaType Redefined { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x1F84170 Offset: 0x1F83370 VA: 0x181F84170
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x1F84240 Offset: 0x1F83440 VA: 0x181F84240
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0x1F83F10 Offset: 0x1F83110 VA: 0x181F83F10
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Name() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Name(string value) { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1F84550 Offset: 0x1F83750 VA: 0x181F84550
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 14
	public virtual bool get_IsMixed() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0x1F84570 Offset: 0x1F83770 VA: 0x181F84570
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0x1F84630 Offset: 0x1F83830 VA: 0x181F84630
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0x1F84500 Offset: 0x1F83700 VA: 0x181F84500
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x526DC0 Offset: 0x525FC0 VA: 0x180526DC0
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x4EDE90 Offset: 0x4ED090 VA: 0x1804EDE90
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0x1F84530 Offset: 0x1F83730 VA: 0x181F84530
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x1F846B0 Offset: 0x1F838B0 VA: 0x181F846B0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0xB80190 Offset: 0xB7F390 VA: 0x180B80190
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0x1F84360 Offset: 0x1F83560 VA: 0x181F84360
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x1F84290 Offset: 0x1F83490 VA: 0x181F84290
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1F83D20 Offset: 0x1F82F20 VA: 0x181F83D20
	public void .ctor() { }
}

