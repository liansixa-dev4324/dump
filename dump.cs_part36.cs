	// RVA: 0x1EEF7E0 Offset: 0x1EEE9E0 VA: 0x181EEF7E0 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x1EEF790 Offset: 0x1EEE990 VA: 0x181EEF790 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1EEF830 Offset: 0x1EEEA30 VA: 0x181EEF830 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: -1 Offset: -1
	private T GetFirstNode<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA4B10 Offset: 0xAA3D10 VA: 0x180AA4B10
	|-XDocument.GetFirstNode<object>
	*/

	// RVA: 0x1EEF900 Offset: 0x1EEEB00 VA: 0x181EEF900
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x1EEFAC0 Offset: 0x1EEECC0 VA: 0x181EEFAC0 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x1EEF980 Offset: 0x1EEEB80 VA: 0x181EEF980
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x1EEFD50 Offset: 0x1EEEF50 VA: 0x181EEFD50 Slot: 14
	internal override void ValidateString(string s) { }
}

// Namespace: System.Xml.Linq
public class XDocumentType : XNode // TypeDefIndex: 17622
{
	// Fields
	private string _name; // 0x28
	private string _publicId; // 0x30
	private string _systemId; // 0x38
	private string _internalSubset; // 0x40

	// Properties
	public string InternalSubset { get; }
	public string Name { get; }
	public override XmlNodeType NodeType { get; }
	public string PublicId { get; }
	public string SystemId { get; }

	// Methods

	// RVA: 0x1EEF700 Offset: 0x1EEE900 VA: 0x181EEF700
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1EEF670 Offset: 0x1EEE870 VA: 0x181EEF670
	public void .ctor(XDocumentType other) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_InternalSubset() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Name() { }

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_PublicId() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_SystemId() { }

	// RVA: 0x1EEF5D0 Offset: 0x1EEE7D0 VA: 0x181EEF5D0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1EEF510 Offset: 0x1EEE710 VA: 0x181EEF510 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class XElement.<GetAttributes>d__116 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator // TypeDefIndex: 17623
{
	// Fields
	private int <>1__state; // 0x10
	private XAttribute <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XElement <>4__this; // 0x28
	private XName name; // 0x30
	public XName <>3__name; // 0x38
	private XAttribute <a>5__2; // 0x40

	// Properties
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1EEBDF0 Offset: 0x1EEAFF0 VA: 0x181EEBDF0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1EEBF30 Offset: 0x1EEB130 VA: 0x181EEBF30 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1EEBE90 Offset: 0x1EEB090 VA: 0x181EEBE90 Slot: 4
	private IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1EEBE90 Offset: 0x1EEB090 VA: 0x181EEBE90 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Xml.Linq
[XmlSchemaProvider(null, IsAny = True)]
[XmlTypeConvertor("ConvertForAssignment")]
public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 17624
{
	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Properties
	public bool HasAttributes { get; }
	public bool IsEmpty { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1EF1960 Offset: 0x1EF0B60 VA: 0x181EF1960
	public void .ctor(XName name) { }

	// RVA: 0x1EF17A0 Offset: 0x1EF09A0 VA: 0x181EF17A0
	public void .ctor(XElement other) { }

	// RVA: 0x1EF18D0 Offset: 0x1EF0AD0 VA: 0x181EF18D0
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x7C5010 Offset: 0x7C4210 VA: 0x1807C5010
	public bool get_HasAttributes() { }

	// RVA: 0x1489FC0 Offset: 0x14891C0 VA: 0x181489FC0
	public bool get_IsEmpty() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public XName get_Name() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1EF19E0 Offset: 0x1EF0BE0 VA: 0x181EF19E0
	public string get_Value() { }

	// RVA: 0x1EF0530 Offset: 0x1EEF730 VA: 0x181EF0530
	public XAttribute Attribute(XName name) { }

	// RVA: 0x1EF0570 Offset: 0x1EEF770 VA: 0x181EF0570
	public IEnumerable<XAttribute> Attributes() { }

	// RVA: 0x1EF08E0 Offset: 0x1EEFAE0 VA: 0x181EF08E0
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1EF16F0 Offset: 0x1EF08F0 VA: 0x181EF16F0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 15
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1EF1300 Offset: 0x1EF0500 VA: 0x181EF1300 Slot: 16
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x19C2080 Offset: 0x19C1280 VA: 0x1819C2080 Slot: 17
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1EF0180 Offset: 0x1EEF380 VA: 0x181EF0180 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x1EF0040 Offset: 0x1EEF240 VA: 0x181EF0040 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1EF03F0 Offset: 0x1EEF5F0 VA: 0x181EF03F0
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x1EF03A0 Offset: 0x1EEF5A0 VA: 0x181EF03A0
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1EF05E0 Offset: 0x1EEF7E0 VA: 0x181EF05E0 Slot: 10
	internal override XNode CloneNode() { }

	[IteratorStateMachine(typeof(XElement.<GetAttributes>d__116))]
	// RVA: 0x1EF0740 Offset: 0x1EEF940 VA: 0x181EF0740
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	// RVA: 0x1EF07C0 Offset: 0x1EEF9C0 VA: 0x181EF07C0
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x1EF11E0 Offset: 0x1EF03E0 VA: 0x181EF11E0
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1EF0BB0 Offset: 0x1EEFDB0 VA: 0x181EF0BB0
	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	// RVA: 0x1EF1280 Offset: 0x1EF0480 VA: 0x181EF1280
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x1EF1520 Offset: 0x1EF0720 VA: 0x181EF1520 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }
}

// Namespace: 
public sealed class XHashtable.ExtractKeyDelegate<TValue> : MulticastDelegate // TypeDefIndex: 17625
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2F10 Offset: 0x11F2110 VA: 0x1811F2F10
	|-XHashtable.ExtractKeyDelegate<object>..ctor
	|
	|-RVA: 0x11F2E00 Offset: 0x11F2000 VA: 0x1811F2E00
	|-XHashtable.ExtractKeyDelegate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual string Invoke(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-XHashtable.ExtractKeyDelegate<object>.Invoke
	|-XHashtable.ExtractKeyDelegate<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private struct XHashtable.XHashtableState.Entry<TValue> // TypeDefIndex: 17626
{
	// Fields
	public TValue Value; // 0x0
	public int HashCode; // 0x0
	public int Next; // 0x0
}

// Namespace: 
private sealed class XHashtable.XHashtableState<TValue> // TypeDefIndex: 17627
{
	// Fields
	private int[] _buckets; // 0x0
	private XHashtable.XHashtableState.Entry<TValue>[] _entries; // 0x0
	private int _numEntries; // 0x0
	private XHashtable.ExtractKeyDelegate<TValue> _extractKey; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE67FB0 Offset: 0xE671B0 VA: 0x180E67FB0
	|-XHashtable.XHashtableState<object>..ctor
	|
	|-RVA: 0xE68050 Offset: 0xE67250 VA: 0x180E68050
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public XHashtable.XHashtableState<TValue> Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE67340 Offset: 0xE66540 VA: 0x180E67340
	|-XHashtable.XHashtableState<object>.Resize
	|
	|-RVA: 0xE66DE0 Offset: 0xE65FE0 VA: 0x180E66DE0
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE67CF0 Offset: 0xE66EF0 VA: 0x180E67CF0
	|-XHashtable.XHashtableState<object>.TryGetValue
	|
	|-RVA: 0xE67E20 Offset: 0xE67020 VA: 0x180E67E20
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TValue value, out TValue newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE67AC0 Offset: 0xE66CC0 VA: 0x180E67AC0
	|-XHashtable.XHashtableState<object>.TryAdd
	|
	|-RVA: 0xE67690 Offset: 0xE66890 VA: 0x180E67690
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE66800 Offset: 0xE65A00 VA: 0x180E66800
	|-XHashtable.XHashtableState<object>.FindEntry
	|
	|-RVA: 0xE669D0 Offset: 0xE65BD0 VA: 0x180E669D0
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.FindEntry
	*/

	// RVA: -1 Offset: -1
	private static int ComputeHashCode(string key, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE66780 Offset: 0xE65980 VA: 0x180E66780
	|-XHashtable.XHashtableState<object>.ComputeHashCode
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.ComputeHashCode
	*/
}

// Namespace: System.Xml.Linq
internal sealed class XHashtable<TValue> // TypeDefIndex: 17628
{
	// Fields
	private XHashtable.XHashtableState<TValue> _state; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE68560 Offset: 0xE67760 VA: 0x180E68560
	|-XHashtable<object>..ctor
	|
	|-RVA: 0xE684C0 Offset: 0xE676C0 VA: 0x180E684C0
	|-XHashtable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE68480 Offset: 0xE67680 VA: 0x180E68480
	|-XHashtable<object>.TryGetValue
	|
	|-RVA: 0xE68440 Offset: 0xE67640 VA: 0x180E68440
	|-XHashtable<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue Add(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE68120 Offset: 0xE67320 VA: 0x180E68120
	|-XHashtable<object>.Add
	|
	|-RVA: 0xE68230 Offset: 0xE67430 VA: 0x180E68230
	|-XHashtable<__Il2CppFullySharedGenericType>.Add
	*/
}

// Namespace: System.Xml.Linq
internal struct NamespaceCache // TypeDefIndex: 17629
{
	// Fields
	private XNamespace _ns; // 0x0
	private string _namespaceName; // 0x8

	// Methods

	// RVA: 0x1EEB790 Offset: 0x1EEA990 VA: 0x181EEB790
	public XNamespace Get(string namespaceName) { }
}

// Namespace: System.Xml.Linq
internal struct ElementWriter // TypeDefIndex: 17630
{
	// Fields
	private XmlWriter _writer; // 0x0
	private NamespaceResolver _resolver; // 0x8

	// Methods

	// RVA: 0x1EEB770 Offset: 0x1EEA970 VA: 0x181EEB770
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x1EEB050 Offset: 0x1EEA250 VA: 0x181EEB050
	public void WriteElement(XElement e) { }

	// RVA: 0x1EEAB90 Offset: 0x1EE9D90 VA: 0x181EEAB90
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x1EEAC80 Offset: 0x1EE9E80 VA: 0x181EEAC80
	private void PushAncestors(XElement e) { }

	// RVA: 0x1EEAEA0 Offset: 0x1EEA0A0 VA: 0x181EEAEA0
	private void PushElement(XElement e) { }

	// RVA: 0x1EEB360 Offset: 0x1EEA560 VA: 0x181EEB360
	private void WriteEndElement() { }

	// RVA: 0x1EEB3E0 Offset: 0x1EEA5E0 VA: 0x181EEB3E0
	private void WriteFullEndElement() { }

	// RVA: 0x1EEB460 Offset: 0x1EEA660 VA: 0x181EEB460
	private void WriteStartElement(XElement e) { }
}

// Namespace: 
private class NamespaceResolver.NamespaceDeclaration // TypeDefIndex: 17631
{
	// Fields
	public string prefix; // 0x10
	public XNamespace ns; // 0x18
	public int scope; // 0x20
	public NamespaceResolver.NamespaceDeclaration prev; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml.Linq
internal struct NamespaceResolver // TypeDefIndex: 17632
{
	// Fields
	private int _scope; // 0x0
	private NamespaceResolver.NamespaceDeclaration _declaration; // 0x8
	private NamespaceResolver.NamespaceDeclaration _rover; // 0x10

	// Methods

	// RVA: 0x1EEBAF0 Offset: 0x1EEACF0 VA: 0x181EEBAF0
	public void PushScope() { }

	// RVA: 0x1EEBA90 Offset: 0x1EEAC90 VA: 0x181EEBA90
	public void PopScope() { }

	// RVA: 0x1EEB8E0 Offset: 0x1EEAAE0 VA: 0x181EEB8E0
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x1EEB820 Offset: 0x1EEAA20 VA: 0x181EEB820
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x1EEB990 Offset: 0x1EEAB90 VA: 0x181EEB990
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }
}

// Namespace: System.Xml.Linq
public enum XObjectChange // TypeDefIndex: 17633
{
	// Fields
	public int value__; // 0x0
	public const XObjectChange Add = 0;
	public const XObjectChange Remove = 1;
	public const XObjectChange Name = 2;
	public const XObjectChange Value = 3;
}

// Namespace: System.Xml.Linq
[Flags]
public enum LoadOptions // TypeDefIndex: 17634
{
	// Fields
	public int value__; // 0x0
	public const LoadOptions None = 0;
	public const LoadOptions PreserveWhitespace = 1;
	public const LoadOptions SetBaseUri = 2;
	public const LoadOptions SetLineInfo = 4;
}

// Namespace: System.Xml.Linq
[Flags]
public enum SaveOptions // TypeDefIndex: 17635
{
	// Fields
	public int value__; // 0x0
	public const SaveOptions None = 0;
	public const SaveOptions DisableFormatting = 1;
	public const SaveOptions OmitDuplicateNamespaces = 2;
}

// Namespace: System.Xml.Linq
[Serializable]
public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 17636
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _localName; // 0x18
	private int _hashCode; // 0x20

	// Properties
	public string LocalName { get; }
	public XNamespace Namespace { get; }
	public string NamespaceName { get; }

	// Methods

	// RVA: 0x1EF1E90 Offset: 0x1EF1090 VA: 0x181EF1E90
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_LocalName() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public XNamespace get_Namespace() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public string get_NamespaceName() { }

	// RVA: 0x1EF1E00 Offset: 0x1EF1000 VA: 0x181EF1E00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EF1B00 Offset: 0x1EF0D00 VA: 0x181EF1B00
	public static XName Get(string expandedName) { }

	// RVA: 0x1EF1CD0 Offset: 0x1EF0ED0 VA: 0x181EF1CD0
	public static XName Get(string localName, string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x1EF1F80 Offset: 0x1EF1180 VA: 0x181EF1F80
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0 Slot: 4
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x1EF1DC0 Offset: 0x1EF0FC0 VA: 0x181EF1DC0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1EF1F50 Offset: 0x1EF1150 VA: 0x181EF1F50
	internal void .ctor() { }
}

// Namespace: System.Xml.Linq
public sealed class XNamespace // TypeDefIndex: 17637
{
	// Fields
	private static XHashtable<WeakReference> s_namespaces; // 0x0
	private static WeakReference s_refNone; // 0x8
	private static WeakReference s_refXml; // 0x10
	private static WeakReference s_refXmlns; // 0x18
	private string _namespaceName; // 0x10
	private int _hashCode; // 0x18
	private XHashtable<XName> _names; // 0x20

	// Properties
	public string NamespaceName { get; }
	public static XNamespace None { get; }
	public static XNamespace Xml { get; }
	public static XNamespace Xmlns { get; }

	// Methods

	// RVA: 0x1EF2790 Offset: 0x1EF1990 VA: 0x181EF2790
	internal void .ctor(string namespaceName) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_NamespaceName() { }

	// RVA: 0x1EF22B0 Offset: 0x1EF14B0 VA: 0x181EF22B0
	public XName GetName(string localName) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EF2880 Offset: 0x1EF1A80 VA: 0x181EF2880
	public static XNamespace get_None() { }

	// RVA: 0x1EF28E0 Offset: 0x1EF1AE0 VA: 0x181EF28E0
	public static XNamespace get_Xml() { }

	// RVA: 0x1EF2940 Offset: 0x1EF1B40 VA: 0x181EF2940
	public static XNamespace get_Xmlns() { }

	// RVA: 0x1EF2720 Offset: 0x1EF1920 VA: 0x181EF2720
	public static XNamespace Get(string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x1EF29A0 Offset: 0x1EF1BA0 VA: 0x181EF29A0
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x17C3590 Offset: 0x17C2790 VA: 0x1817C3590
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x1EF2120 Offset: 0x1EF1320 VA: 0x181EF2120
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x1EF2330 Offset: 0x1EF1530 VA: 0x181EF2330
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x408300 Offset: 0x407500 VA: 0x180408300
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x1EF20A0 Offset: 0x1EF12A0 VA: 0x181EF20A0
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x1EF1F90 Offset: 0x1EF1190 VA: 0x181EF1F90
	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }
}

// Namespace: System.Xml.Linq
public abstract class XNode : XObject // TypeDefIndex: 17638
{
	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x1EF2CE0 Offset: 0x1EF1EE0 VA: 0x181EF2CE0
	public void Remove() { }

	// RVA: 0x1EF2D50 Offset: 0x1EF1F50 VA: 0x181EF2D50 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteTo(XmlWriter writer);

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract XNode CloneNode();

	// RVA: 0x1EF29C0 Offset: 0x1EF1BC0 VA: 0x181EF29C0
	private string GetXmlString(SaveOptions o) { }
}

// Namespace: System.Xml.Linq
public abstract class XObject : IXmlLineInfo // TypeDefIndex: 17639
{
	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Properties
	public string BaseUri { get; }
	public abstract XmlNodeType NodeType { get; }
	public XElement Parent { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }
	internal bool HasBaseUri { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x1EF38E0 Offset: 0x1EF2AE0 VA: 0x181EF38E0
	public string get_BaseUri() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x1EF39A0 Offset: 0x1EF2BA0 VA: 0x181EF39A0
	public XElement get_Parent() { }

	// RVA: 0x1EF2FA0 Offset: 0x1EF21A0 VA: 0x181EF2FA0
	public void AddAnnotation(object annotation) { }

	// RVA: 0x1EF3210 Offset: 0x1EF2410 VA: 0x181EF3210
	private object AnnotationForSealedType(Type type) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA4C40 Offset: 0xAA3E40 VA: 0x180AA4C40
	|-XObject.Annotation<object>
	*/

	// RVA: 0x1EF3800 Offset: 0x1EF2A00 VA: 0x181EF3800 Slot: 4
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x1EF3840 Offset: 0x1EF2A40 VA: 0x181EF3840 Slot: 5
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x1EF3890 Offset: 0x1EF2A90 VA: 0x181EF3890 Slot: 6
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x1EF3960 Offset: 0x1EF2B60 VA: 0x181EF3960
	internal bool get_HasBaseUri() { }

	// RVA: 0x1EF3540 Offset: 0x1EF2740 VA: 0x181EF3540
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x1EF35F0 Offset: 0x1EF27F0 VA: 0x181EF35F0
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x1EF36A0 Offset: 0x1EF28A0 VA: 0x181EF36A0
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x1EF3710 Offset: 0x1EF2910 VA: 0x181EF3710
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x1EF3790 Offset: 0x1EF2990 VA: 0x181EF3790
	internal bool SkipNotify() { }

	// RVA: 0x1EF3350 Offset: 0x1EF2550 VA: 0x181EF3350
	internal SaveOptions GetSaveOptionsFromAnnotations() { }
}

// Namespace: System.Xml.Linq
internal class XObjectChangeAnnotation // TypeDefIndex: 17640
{
	// Fields
	internal EventHandler<XObjectChangeEventArgs> changing; // 0x10
	internal EventHandler<XObjectChangeEventArgs> changed; // 0x18
}

// Namespace: System.Xml.Linq
public class XObjectChangeEventArgs : EventArgs // TypeDefIndex: 17641
{
	// Fields
	private XObjectChange _objectChange; // 0x10
	public static readonly XObjectChangeEventArgs Add; // 0x0
	public static readonly XObjectChangeEventArgs Remove; // 0x8
	public static readonly XObjectChangeEventArgs Name; // 0x10
	public static readonly XObjectChangeEventArgs Value; // 0x18

	// Methods

	// RVA: 0x1EF2F40 Offset: 0x1EF2140 VA: 0x181EF2F40
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x1EF2D80 Offset: 0x1EF1F80 VA: 0x181EF2D80
	private static void .cctor() { }
}

// Namespace: System.Xml.Linq
public class XProcessingInstruction : XNode // TypeDefIndex: 17642
{
	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Properties
	public string Data { get; }
	public override XmlNodeType NodeType { get; }
	public string Target { get; }

	// Methods

	// RVA: 0x1EF3C40 Offset: 0x1EF2E40 VA: 0x181EF3C40
	public void .ctor(string target, string data) { }

	// RVA: 0x1EF3D90 Offset: 0x1EF2F90 VA: 0x181EF3D90
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Data() { }

	// RVA: 0x68EEF0 Offset: 0x68E0F0 VA: 0x18068EEF0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Target() { }

	// RVA: 0x1EF3BB0 Offset: 0x1EF2DB0 VA: 0x181EF3BB0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1EF3A20 Offset: 0x1EF2C20 VA: 0x181EF3A20 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: 0x1EF3AD0 Offset: 0x1EF2CD0 VA: 0x181EF3AD0
	private static void ValidateName(string name) { }
}

// Namespace: System.Xml.Linq
public class XStreamingElement // TypeDefIndex: 17643
{
	// Fields
	internal XName name; // 0x10
	internal object content; // 0x18
}

// Namespace: System.Xml.Linq
public class XText : XNode // TypeDefIndex: 17644
{
	// Fields
	internal string text; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x1EECEA0 Offset: 0x1EEC0A0 VA: 0x181EECEA0
	public void .ctor(string value) { }

	// RVA: 0x1EECF20 Offset: 0x1EEC120 VA: 0x181EECF20
	public void .ctor(XText other) { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Value() { }

	// RVA: 0x1EF3FF0 Offset: 0x1EF31F0 VA: 0x181EF3FF0
	public void set_Value(string value) { }

	// RVA: 0x1EF3EF0 Offset: 0x1EF30F0 VA: 0x181EF3EF0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1EF3E10 Offset: 0x1EF3010 VA: 0x181EF3E10 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x1EF3E40 Offset: 0x1EF3040 VA: 0x181EF3E40 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: System.Text
internal static class StringBuilderCache // TypeDefIndex: 17645
{
	// Fields
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; // 0x80000000

	// Methods

	// RVA: 0x1EEBBF0 Offset: 0x1EEADF0 VA: 0x181EEBBF0
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x1EEBD40 Offset: 0x1EEAF40 VA: 0x181EEBD40
	public static void Release(StringBuilder sb) { }

	// RVA: 0x1EEBCB0 Offset: 0x1EEAEB0 VA: 0x181EEBCB0
	public static string GetStringAndRelease(StringBuilder sb) { }
}

// Namespace: Unity
internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 17646
{
	// Methods

	// RVA: 0x1EEBDB0 Offset: 0x1EEAFB0 VA: 0x181EEBDB0
	public static void ThrowNotSupportedException() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17647
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <>f__AnonymousType0<<pair>j__TPar, <index>j__TPar> // TypeDefIndex: 17648
{
	// Fields
	[DebuggerBrowsable(0)]
	private readonly <pair>j__TPar <pair>i__Field; // 0x0
	[DebuggerBrowsable(0)]
	private readonly <index>j__TPar <index>i__Field; // 0x0

	// Properties
	public <pair>j__TPar pair { get; }
	public <index>j__TPar index { get; }

	// Methods

	// RVA: -1 Offset: -1
	public <pair>j__TPar get_pair() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	|-<>f__AnonymousType0<KeyValuePair<object, object>, int>.get_pair
	|
	|-RVA: 0xB16E40 Offset: 0xB16040 VA: 0x180B16E40
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_pair
	*/

	// RVA: -1 Offset: -1
	public <index>j__TPar get_index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	|-<>f__AnonymousType0<KeyValuePair<object, object>, int>.get_index
	|
	|-RVA: 0xB03E40 Offset: 0xB03040 VA: 0x180B03E40
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_index
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(<pair>j__TPar pair, <index>j__TPar index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB16C60 Offset: 0xB15E60 VA: 0x180B16C60
	|-<>f__AnonymousType0<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0xB16CE0 Offset: 0xB15EE0 VA: 0x180B16CE0
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB14350 Offset: 0xB13550 VA: 0x180B14350
	|-<>f__AnonymousType0<KeyValuePair<object, object>, int>.Equals
	|
	|-RVA: 0xB14640 Offset: 0xB13840 VA: 0x180B14640
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB153C0 Offset: 0xB145C0 VA: 0x180B153C0
	|-<>f__AnonymousType0<KeyValuePair<object, object>, int>.GetHashCode
	|
	|-RVA: 0xB14C90 Offset: 0xB13E90 VA: 0x180B14C90
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB169C0 Offset: 0xB15BC0 VA: 0x180B169C0
	|-<>f__AnonymousType0<KeyValuePair<object, object>, int>.ToString
	|
	|-RVA: 0xB15470 Offset: 0xB14670 VA: 0x180B15470
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: System.Reflection
[Extension]
internal static class TypeExtensions // TypeDefIndex: 17649
{
	// Methods

	[Extension]
	// RVA: 0x8D05B0 Offset: 0x8CF7B0 VA: 0x1808D05B0
	public static TypeInfo GetTypeInfo(Type type) { }
}

// Namespace: System.Reflection
internal class TypeInfo // TypeDefIndex: 17650
{
	// Fields
	private readonly Type type; // 0x10

	// Properties
	public bool IsGenericType { get; }

	// Methods

	// RVA: 0x8D0650 Offset: 0x8CF850 VA: 0x1808D0650
	public bool get_IsGenericType() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Type type) { }

	// RVA: 0x8D0610 Offset: 0x8CF810 VA: 0x1808D0610
	public bool IsAssignableFrom(TypeInfo typeInfo) { }
}

// Namespace: CsvHelper
[Serializable]
public class CsvBadDataException : CsvHelperException // TypeDefIndex: 17651
{
	// Methods

	// RVA: 0x8C9F80 Offset: 0x8C9180 VA: 0x1808C9F80
	public void .ctor() { }

	// RVA: 0x8C9F20 Offset: 0x8C9120 VA: 0x1808C9F20
	public void .ctor(string message) { }

	// RVA: 0x8C9EA0 Offset: 0x8C90A0 VA: 0x1808C9EA0
	public void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: CsvHelper
[Serializable]
public class CsvHelperException : Exception // TypeDefIndex: 17652
{
	// Methods

	// RVA: 0x8C9F80 Offset: 0x8C9180 VA: 0x1808C9F80
	public void .ctor() { }

	// RVA: 0x8C9F20 Offset: 0x8C9120 VA: 0x1808C9F20
	public void .ctor(string message) { }

	// RVA: 0x8C9EA0 Offset: 0x8C90A0 VA: 0x1808C9EA0
	public void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: CsvHelper
[Serializable]
public class CsvMissingFieldException : CsvReaderException // TypeDefIndex: 17653
{
	// Methods

	// RVA: 0x8C9F80 Offset: 0x8C9180 VA: 0x1808C9F80
	public void .ctor() { }

	// RVA: 0x8C9F20 Offset: 0x8C9120 VA: 0x1808C9F20
	public void .ctor(string message) { }

	// RVA: 0x8C9EA0 Offset: 0x8C90A0 VA: 0x1808C9EA0
	public void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CsvParser.<>c // TypeDefIndex: 17654
{
	// Fields
	public static readonly CsvParser.<>c <>9; // 0x0
	public static Func<string, bool> <>9__37_0; // 0x8

	// Methods

	// RVA: 0x8D0820 Offset: 0x8CFA20 VA: 0x1808D0820
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x8D0790 Offset: 0x8CF990 VA: 0x1808D0790
	internal bool <Read>b__37_0(string field) { }
}

// Namespace: CsvHelper
public class CsvParser : ICsvParser, IDisposable // TypeDefIndex: 17655
{
	// Fields
	private bool disposed; // 0x10
	private TextReader reader; // 0x18
	private readonly char[] readerBuffer; // 0x20
	private int readerBufferPosition; // 0x28
	private int charsRead; // 0x2C
	private string[] record; // 0x30
	private int currentRow; // 0x38
	private int currentRawRow; // 0x3C
	private readonly CsvConfiguration configuration; // 0x40
	private Nullable<char> cPrev; // 0x48
	private char c; // 0x4C
	private bool read; // 0x4E
	private bool hasExcelSeparatorBeenRead; // 0x4F
	[CompilerGenerated]
	private int <FieldCount>k__BackingField; // 0x50
	[CompilerGenerated]
	private long <CharPosition>k__BackingField; // 0x58
	[CompilerGenerated]
	private long <BytePosition>k__BackingField; // 0x60
	[CompilerGenerated]
	private string <RawRecord>k__BackingField; // 0x68

	// Properties
	public virtual int FieldCount { get; set; }
	public virtual long CharPosition { get; set; }
	public virtual long BytePosition { get; set; }
	public virtual int Row { get; }
	public virtual string RawRecord { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410 Slot: 7
	public virtual int get_FieldCount() { }

	[CompilerGenerated]
	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630 Slot: 8
	protected virtual void set_FieldCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 9
	public virtual long get_CharPosition() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0 Slot: 10
	protected virtual void set_CharPosition(long value) { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 11
	public virtual long get_BytePosition() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0 Slot: 12
	protected virtual void set_BytePosition(long value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 13
	public virtual int get_Row() { }

	[CompilerGenerated]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 14
	public virtual string get_RawRecord() { }

	[CompilerGenerated]
	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	private void set_RawRecord(string value) { }

	// RVA: 0x8CC070 Offset: 0x8CB270 VA: 0x1808CC070
	public void .ctor(TextReader reader, CsvConfiguration configuration) { }

	// RVA: 0x8CBCF0 Offset: 0x8CAEF0 VA: 0x1808CBCF0 Slot: 15
	public virtual string[] Read() { }

	// RVA: 0x8CA7D0 Offset: 0x8C99D0 VA: 0x1808CA7D0 Slot: 6
	public void Dispose() { }

	// RVA: 0x8CA840 Offset: 0x8C9A40 VA: 0x1808CA840 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x8CA740 Offset: 0x8C9940 VA: 0x1808CA740 Slot: 17
	protected virtual void CheckDisposed() { }

	// RVA: 0x8CA540 Offset: 0x8C9740 VA: 0x1808CA540 Slot: 18
	protected virtual void AddFieldToRecord(ref int recordPosition, string field, ref bool fieldIsBad) { }

	// RVA: 0x8CA700 Offset: 0x8C9900 VA: 0x1808CA700 Slot: 19
	protected virtual void AppendField(ref string field, int fieldStartPosition, int length) { }

	// RVA: 0x8CBF90 Offset: 0x8CB190 VA: 0x1808CBF90 Slot: 20
	protected virtual void UpdateBytePosition(int fieldStartPosition, int length) { }

	// RVA: 0x8CAB30 Offset: 0x8C9D30 VA: 0x1808CAB30 Slot: 21
	protected virtual string[] ReadLine() { }

	// RVA: 0x8CA880 Offset: 0x8C9A80 VA: 0x1808CA880
	protected bool GetChar(out char ch, ref int fieldStartPosition, ref int rawFieldStartPosition, ref string field, ref bool fieldIsBad, bool prevCharWasDelimiter, ref int recordPosition, ref int fieldLength, bool inComment, bool inDelimiter, bool inQuotes, bool isPeek) { }

	// RVA: 0x8CAAB0 Offset: 0x8C9CB0 VA: 0x1808CAAB0 Slot: 22
	protected virtual void ReadExcelSeparator() { }
}

// Namespace: CsvHelper
[DefaultMember("Item")]
public class CsvReader : IDisposable // TypeDefIndex: 17656
{
	// Fields
	private bool disposed; // 0x10
	private bool hasBeenRead; // 0x11
	private string[] currentRecord; // 0x18
	private string[] headerRecord; // 0x20
	private ICsvParser parser; // 0x28
	private int currentIndex; // 0x30
	private bool doneReading; // 0x34
	private readonly Dictionary<string, List<int>> namedIndexes; // 0x38
	private readonly Dictionary<Type, Delegate> recordFuncs; // 0x40
	private readonly CsvConfiguration configuration; // 0x48

	// Properties
	public virtual CsvConfiguration Configuration { get; }
	public virtual ICsvParser Parser { get; }

	// Methods

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 5
	public virtual CsvConfiguration get_Configuration() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 6
	public virtual ICsvParser get_Parser() { }

	// RVA: 0x8CD5D0 Offset: 0x8CC7D0 VA: 0x1808CD5D0
	public void .ctor(TextReader reader) { }

	// RVA: 0x8CD930 Offset: 0x8CCB30 VA: 0x1808CD930
	public void .ctor(TextReader reader, CsvConfiguration configuration) { }

	// RVA: 0x8CD100 Offset: 0x8CC300 VA: 0x1808CD100 Slot: 7
	public virtual bool ReadHeader() { }

	// RVA: 0x8CD350 Offset: 0x8CC550 VA: 0x1808CD350 Slot: 8
	public virtual bool Read() { }

	// RVA: 0x8CCC10 Offset: 0x8CBE10 VA: 0x1808CCC10 Slot: 9
	public virtual string GetField(int index) { }

	// RVA: 0x8CCAF0 Offset: 0x8CBCF0 VA: 0x1808CCAF0 Slot: 10
	public virtual object GetField(Type type, int index, ITypeConverter converter) { }

	// RVA: -1 Offset: -1 Slot: 11
	public virtual T GetField<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x950A70 Offset: 0x94FC70 VA: 0x180950A70
	|-CsvReader.GetField<object>
	|
	|-RVA: 0x9507E0 Offset: 0x94F9E0 VA: 0x1809507E0
	|-CsvReader.GetField<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual T GetField<T>(int index, ITypeConverter converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x950C20 Offset: 0x94FE20 VA: 0x180950C20
	|-CsvReader.GetField<object>
	|
	|-RVA: 0x950500 Offset: 0x94F700 VA: 0x180950500
	|-CsvReader.GetField<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual T GetField<T>(string name, ITypeConverter converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x950B50 Offset: 0x94FD50 VA: 0x180950B50
	|-CsvReader.GetField<object>
	|
	|-RVA: 0x950930 Offset: 0x94FB30 VA: 0x180950930
	|-CsvReader.GetField<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8CC290 Offset: 0x8CB490 VA: 0x1808CC290 Slot: 4
	public void Dispose() { }

	// RVA: 0x8CC300 Offset: 0x8CB500 VA: 0x1808CC300 Slot: 14
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x8CC190 Offset: 0x8CB390 VA: 0x1808CC190 Slot: 15
	protected virtual void CheckDisposed() { }

	// RVA: 0x8CC220 Offset: 0x8CB420 VA: 0x1808CC220 Slot: 16
	protected virtual void CheckHasBeenRead() { }

	// RVA: 0x8CCE10 Offset: 0x8CC010 VA: 0x1808CCE10 Slot: 17
	protected virtual bool IsRecordEmpty(bool checkHasBeenRead) { }

	// RVA: 0x8CC3E0 Offset: 0x8CB5E0 VA: 0x1808CC3E0 Slot: 18
	protected virtual Func<string, bool> GetEmtpyStringMethod() { }

	// RVA: 0x8CCA40 Offset: 0x8CBC40 VA: 0x1808CCA40 Slot: 19
	protected virtual int GetFieldIndex(string name, int index = 0, bool isTryGet = False) { }

	// RVA: 0x8CC4A0 Offset: 0x8CB6A0 VA: 0x1808CC4A0 Slot: 20
	protected virtual int GetFieldIndex(string[] names, int index = 0, bool isTryGet = False) { }

	// RVA: 0x8CCEC0 Offset: 0x8CC0C0 VA: 0x1808CCEC0 Slot: 21
	protected virtual void ParseNamedIndexes() { }

	// RVA: 0x8CD500 Offset: 0x8CC700 VA: 0x1808CD500 Slot: 22
	protected virtual bool ShouldSkipRecord() { }
}

// Namespace: CsvHelper
[Serializable]
public class CsvReaderException : CsvHelperException // TypeDefIndex: 17657
{
	// Methods

	// RVA: 0x8C9F80 Offset: 0x8C9180 VA: 0x1808C9F80
	public void .ctor() { }

	// RVA: 0x8C9F20 Offset: 0x8C9120 VA: 0x1808C9F20
	public void .ctor(string message) { }

	// RVA: 0x8C9EA0 Offset: 0x8C90A0 VA: 0x1808C9EA0
	public void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExceptionHelper.<>c__DisplayClass1_0 // TypeDefIndex: 17658
{
	// Fields
	public Nullable<int> currentIndex; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x8D07A0 Offset: 0x8CF9A0 VA: 0x1808D07A0
	internal bool <GetErrorMessage>b__2(<>f__AnonymousType0<KeyValuePair<string, List<int>>, int> <>h__TransparentIdentifier0) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ExceptionHelper.<>c // TypeDefIndex: 17659
{
	// Fields
	public static readonly ExceptionHelper.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, List<int>>, IEnumerable<int>> <>9__1_0; // 0x8
	public static Func<KeyValuePair<string, List<int>>, int, <>f__AnonymousType0<KeyValuePair<string, List<int>>, int>> <>9__1_1; // 0x10
	public static Func<<>f__AnonymousType0<KeyValuePair<string, List<int>>, int>, string> <>9__1_3; // 0x18

	// Methods

	// RVA: 0x8D0880 Offset: 0x8CFA80 VA: 0x1808D0880
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x8D0680 Offset: 0x8CF880 VA: 0x1808D0680
	internal IEnumerable<int> <GetErrorMessage>b__1_0(KeyValuePair<string, List<int>> pair) { }

	// RVA: 0x8D06C0 Offset: 0x8CF8C0 VA: 0x1808D06C0
	internal <>f__AnonymousType0<KeyValuePair<string, List<int>>, int> <GetErrorMessage>b__1_1(KeyValuePair<string, List<int>> pair, int index) { }

	// RVA: 0x8D0740 Offset: 0x8CF940 VA: 0x1808D0740
	internal string <GetErrorMessage>b__1_3(<>f__AnonymousType0<KeyValuePair<string, List<int>>, int> <>h__TransparentIdentifier0) { }
}

// Namespace: CsvHelper
internal static class ExceptionHelper // TypeDefIndex: 17660
{
	// Methods

	// RVA: 0x8CE480 Offset: 0x8CD680 VA: 0x1808CE480
	public static void AddExceptionDataMessage(Exception exception, ICsvParser parser, Type type, Dictionary<string, List<int>> namedIndexes, Nullable<int> currentIndex, string[] currentRecord) { }

	// RVA: 0x8CE670 Offset: 0x8CD870 VA: 0x1808CE670
	public static string GetErrorMessage(ICsvParser parser, Type type, Dictionary<string, List<int>> namedIndexes, Nullable<int> currentIndex, string[] currentRecord) { }
}

// Namespace: CsvHelper
public interface ICsvParser : IDisposable // TypeDefIndex: 17661
{
	// Properties
	public abstract int Row { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Row();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string[] Read();
}

// Namespace: CsvHelper
internal static class StringHelper // TypeDefIndex: 17662
{
	// Methods

	// RVA: 0x8CF2F0 Offset: 0x8CE4F0 VA: 0x1808CF2F0
	public static bool IsNullOrWhiteSpace(string s) { }
}

// Namespace: CsvHelper.TypeConversion
public class BooleanConverter : DefaultTypeConverter // TypeDefIndex: 17663
{
	// Methods

	// RVA: 0x8C9920 Offset: 0x8C8B20 VA: 0x1808C9920 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class ByteConverter : DefaultTypeConverter // TypeDefIndex: 17664
{
	// Methods

	// RVA: 0x8C9D10 Offset: 0x8C8F10 VA: 0x1808C9D10 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class CharConverter : DefaultTypeConverter // TypeDefIndex: 17665
{
	// Methods

	// RVA: 0x8C9DE0 Offset: 0x8C8FE0 VA: 0x1808C9DE0 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class CsvTypeConverterException : CsvHelperException // TypeDefIndex: 17666
{
	// Methods

	// RVA: 0x8C9F20 Offset: 0x8C9120 VA: 0x1808C9F20
	public void .ctor(string message) { }
}

// Namespace: CsvHelper.TypeConversion
public class DateTimeConverter : DefaultTypeConverter // TypeDefIndex: 17667
{
	// Methods

	// RVA: 0x8CDB20 Offset: 0x8CCD20 VA: 0x1808CDB20 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class DateTimeOffsetConverter : DefaultTypeConverter // TypeDefIndex: 17668
{
	// Methods

	// RVA: 0x8CDD50 Offset: 0x8CCF50 VA: 0x1808CDD50 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class DecimalConverter : DefaultTypeConverter // TypeDefIndex: 17669
{
	// Methods

	// RVA: 0x8CDF90 Offset: 0x8CD190 VA: 0x1808CDF90 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class DefaultTypeConverter : ITypeConverter // TypeDefIndex: 17670
{
	// Methods

	// RVA: 0x8CE0A0 Offset: 0x8CD2A0 VA: 0x1808CE0A0 Slot: 5
	public virtual object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class DoubleConverter : DefaultTypeConverter // TypeDefIndex: 17671
{
	// Methods

	// RVA: 0x8CE0F0 Offset: 0x8CD2F0 VA: 0x1808CE0F0 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class EnumConverter : DefaultTypeConverter // TypeDefIndex: 17672
{
	// Fields
	private readonly Type type; // 0x10

	// Methods

	// RVA: 0x8CE260 Offset: 0x8CD460 VA: 0x1808CE260
	public void .ctor(Type type) { }

	// RVA: 0x8CE1C0 Offset: 0x8CD3C0 VA: 0x1808CE1C0 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }
}

// Namespace: CsvHelper.TypeConversion
public class EnumerableConverter : DefaultTypeConverter // TypeDefIndex: 17673
{
	// Methods

	// RVA: 0x8CE430 Offset: 0x8CD630 VA: 0x1808CE430 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class GuidConverter : DefaultTypeConverter // TypeDefIndex: 17674
{
	// Methods

	// RVA: 0x8CECA0 Offset: 0x8CDEA0 VA: 0x1808CECA0 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class Int16Converter : DefaultTypeConverter // TypeDefIndex: 17675
{
	// Methods

	// RVA: 0x8CED30 Offset: 0x8CDF30 VA: 0x1808CED30 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class Int32Converter : DefaultTypeConverter // TypeDefIndex: 17676
{
	// Methods

	// RVA: 0x8CEE00 Offset: 0x8CE000 VA: 0x1808CEE00 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class Int64Converter : DefaultTypeConverter // TypeDefIndex: 17677
{
	// Methods

	// RVA: 0x8CEED0 Offset: 0x8CE0D0 VA: 0x1808CEED0 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public interface ITypeConverter // TypeDefIndex: 17678
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object ConvertFromString(TypeConverterOptions options, string text);
}

// Namespace: CsvHelper.TypeConversion
public class NullableConverter : DefaultTypeConverter // TypeDefIndex: 17679
{
	// Fields
	[CompilerGenerated]
	private Type <NullableType>k__BackingField; // 0x10
	[CompilerGenerated]
	private Type <UnderlyingType>k__BackingField; // 0x18
	[CompilerGenerated]
	private ITypeConverter <UnderlyingTypeConverter>k__BackingField; // 0x20

	// Properties
	private Type NullableType { set; }
	public Type UnderlyingType { get; set; }
	public ITypeConverter UnderlyingTypeConverter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_NullableType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Type get_UnderlyingType() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_UnderlyingType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ITypeConverter get_UnderlyingTypeConverter() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_UnderlyingTypeConverter(ITypeConverter value) { }

	// RVA: 0x8CF030 Offset: 0x8CE230 VA: 0x1808CF030
	public void .ctor(Type type) { }

	// RVA: 0x8CEFA0 Offset: 0x8CE1A0 VA: 0x1808CEFA0 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }
}

// Namespace: CsvHelper.TypeConversion
public class SByteConverter : DefaultTypeConverter // TypeDefIndex: 17680
{
	// Methods

	// RVA: 0x8CF100 Offset: 0x8CE300 VA: 0x1808CF100 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class SingleConverter : DefaultTypeConverter // TypeDefIndex: 17681
{
	// Methods

	// RVA: 0x8CF1D0 Offset: 0x8CE3D0 VA: 0x1808CF1D0 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class StringConverter : DefaultTypeConverter // TypeDefIndex: 17682
{
	// Methods

	// RVA: 0x8CF2A0 Offset: 0x8CE4A0 VA: 0x1808CF2A0 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class TimeSpanConverter : DefaultTypeConverter // TypeDefIndex: 17683
{
	// Methods

	// RVA: 0x8CF390 Offset: 0x8CE590 VA: 0x1808CF390 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public static class TypeConverterFactory // TypeDefIndex: 17684
{
	// Fields
	private static readonly Dictionary<Type, ITypeConverter> typeConverters; // 0x0
	private static readonly object locker; // 0x8

	// Methods

	// RVA: 0x8D0020 Offset: 0x8CF220 VA: 0x1808D0020
	private static void .cctor() { }

	// RVA: 0x8CF440 Offset: 0x8CE640 VA: 0x1808CF440
	public static void AddConverter(Type type, ITypeConverter typeConverter) { }

	// RVA: 0x8CFC50 Offset: 0x8CEE50 VA: 0x1808CFC50
	public static ITypeConverter GetConverter(Type type) { }

	// RVA: -1 Offset: -1
	public static ITypeConverter GetConverter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA883B0 Offset: 0xA875B0 VA: 0x180A883B0
	|-TypeConverterFactory.GetConverter<object>
	|-TypeConverterFactory.GetConverter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8CF5F0 Offset: 0x8CE7F0 VA: 0x1808CF5F0
	private static void CreateDefaultConverters() { }
}

// Namespace: CsvHelper.TypeConversion
public class TypeConverterOptions // TypeDefIndex: 17685
{
	// Fields
	private readonly List<string> booleanTrueValues; // 0x10
	private readonly List<string> booleanFalseValues; // 0x18
	[CompilerGenerated]
	private CultureInfo <CultureInfo>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<DateTimeStyles> <DateTimeStyle>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<NumberStyles> <NumberStyle>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Format>k__BackingField; // 0x38

	// Properties
	public CultureInfo CultureInfo { get; set; }
	public Nullable<DateTimeStyles> DateTimeStyle { get; }
	public Nullable<NumberStyles> NumberStyle { get; }
	public List<string> BooleanTrueValues { get; }
	public List<string> BooleanFalseValues { get; }
	public string Format { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public CultureInfo get_CultureInfo() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_CultureInfo(CultureInfo value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Nullable<DateTimeStyles> get_DateTimeStyle() { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Nullable<NumberStyles> get_NumberStyle() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public List<string> get_BooleanTrueValues() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public List<string> get_BooleanFalseValues() { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Format() { }

	// RVA: 0x8D0370 Offset: 0x8CF570 VA: 0x1808D0370
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public static class TypeConverterOptionsFactory // TypeDefIndex: 17686
{
	// Fields
	private static readonly Dictionary<Type, TypeConverterOptions> typeConverterOptions; // 0x0
	private static readonly object locker; // 0x8

	// Methods

	// RVA: 0x8D00D0 Offset: 0x8CF2D0 VA: 0x1808D00D0
	public static TypeConverterOptions GetOptions(Type type) { }

	// RVA: 0x8D02C0 Offset: 0x8CF4C0 VA: 0x1808D02C0
	private static void .cctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class UInt16Converter : DefaultTypeConverter // TypeDefIndex: 17687
{
	// Methods

	// RVA: 0x8D08E0 Offset: 0x8CFAE0 VA: 0x1808D08E0 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class UInt32Converter : DefaultTypeConverter // TypeDefIndex: 17688
{
	// Methods

	// RVA: 0x8D09B0 Offset: 0x8CFBB0 VA: 0x1808D09B0 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.TypeConversion
public class UInt64Converter : DefaultTypeConverter // TypeDefIndex: 17689
{
	// Methods

	// RVA: 0x8D0A80 Offset: 0x8CFC80 VA: 0x1808D0A80 Slot: 5
	public override object ConvertFromString(TypeConverterOptions options, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: CsvHelper.Configuration
public abstract class CsvClassMap // TypeDefIndex: 17690
{}

// Namespace: CsvHelper.Configuration
[DefaultMember("Item")]
public class CsvClassMapCollection // TypeDefIndex: 17691
{
	// Fields
	private readonly Dictionary<Type, CsvClassMap> data; // 0x10

	// Methods

	// RVA: 0x8C9FD0 Offset: 0x8C91D0 VA: 0x1808C9FD0
	public void .ctor() { }
}

// Namespace: CsvHelper.Configuration
public class CsvConfiguration // TypeDefIndex: 17692
{
	// Fields
	private BindingFlags propertyBindingFlags; // 0x10
	private bool hasHeaderRecord; // 0x14
	private bool willThrowOnMissingField; // 0x15
	private string delimiter; // 0x18
	private char quote; // 0x20
	private string quoteString; // 0x28
	private string doubleQuoteString; // 0x30
	private char[] quoteRequiredChars; // 0x38
	private char comment; // 0x40
	private int bufferSize; // 0x44
	private bool isHeaderCaseSensitive; // 0x48
	private Encoding encoding; // 0x50
	private CultureInfo cultureInfo; // 0x58
	private bool ignoreBlankLines; // 0x60
	private bool useNewObjectForNullReferenceProperties; // 0x61
	private readonly CsvClassMapCollection maps; // 0x68
	[CompilerGenerated]
	private bool <HasExcelSeparator>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <DetectColumnCountChanges>k__BackingField; // 0x71
	[CompilerGenerated]
	private bool <IgnoreHeaderWhiteSpace>k__BackingField; // 0x72
	[CompilerGenerated]
	private bool <TrimHeaders>k__BackingField; // 0x73
	[CompilerGenerated]
	private bool <TrimFields>k__BackingField; // 0x74
	[CompilerGenerated]
	private bool <AllowComments>k__BackingField; // 0x75
	[CompilerGenerated]
	private bool <CountBytes>k__BackingField; // 0x76
	[CompilerGenerated]
	private bool <SkipEmptyRecords>k__BackingField; // 0x77
	[CompilerGenerated]
	private Func<string[], bool> <ShouldSkipRecord>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <IgnoreQuotes>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <UseExcelLeadingZerosFormatForNumerics>k__BackingField; // 0x81
	[CompilerGenerated]
	private bool <ThrowOnBadData>k__BackingField; // 0x82
	[CompilerGenerated]
	private Action<string> <BadDataCallback>k__BackingField; // 0x88

	// Properties
	public virtual bool HasHeaderRecord { get; }
	public virtual bool HasExcelSeparator { get; }
	public virtual bool WillThrowOnMissingField { get; }
	public virtual bool DetectColumnCountChanges { get; }
	public virtual bool IsHeaderCaseSensitive { get; }
	public virtual bool IgnoreHeaderWhiteSpace { get; }
	public virtual bool TrimHeaders { get; }
	public virtual bool TrimFields { get; }
	public virtual string Delimiter { get; set; }
	public virtual char Quote { get; }
	public virtual char Comment { get; }
	public virtual bool AllowComments { get; }
	public virtual int BufferSize { get; }
	public virtual bool CountBytes { get; }
	public virtual Encoding Encoding { get; }
	public virtual CultureInfo CultureInfo { get; }
	public virtual bool SkipEmptyRecords { get; }
	public virtual Func<string[], bool> ShouldSkipRecord { get; }
	public virtual bool IgnoreQuotes { get; }
	public virtual bool IgnoreBlankLines { get; }
	public virtual bool UseExcelLeadingZerosFormatForNumerics { get; }
	public virtual bool ThrowOnBadData { get; }
	public virtual Action<string> BadDataCallback { get; }

	// Methods

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30 Slot: 4
	public virtual bool get_HasHeaderRecord() { }

	[CompilerGenerated]
	// RVA: 0x6167C0 Offset: 0x6159C0 VA: 0x1806167C0 Slot: 5
	public virtual bool get_HasExcelSeparator() { }

	// RVA: 0x41AC40 Offset: 0x419E40 VA: 0x18041AC40 Slot: 6
	public virtual bool get_WillThrowOnMissingField() { }

	[CompilerGenerated]
	// RVA: 0x53DC80 Offset: 0x53CE80 VA: 0x18053DC80 Slot: 7
	public virtual bool get_DetectColumnCountChanges() { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70 Slot: 8
	public virtual bool get_IsHeaderCaseSensitive() { }

	[CompilerGenerated]
	// RVA: 0x8CA2B0 Offset: 0x8C94B0 VA: 0x1808CA2B0 Slot: 9
	public virtual bool get_IgnoreHeaderWhiteSpace() { }

	[CompilerGenerated]
	// RVA: 0x8CA300 Offset: 0x8C9500 VA: 0x1808CA300 Slot: 10
	public virtual bool get_TrimHeaders() { }

	[CompilerGenerated]
	// RVA: 0x8CA2F0 Offset: 0x8C94F0 VA: 0x1808CA2F0 Slot: 11
	public virtual bool get_TrimFields() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 12
	public virtual string get_Delimiter() { }

	// RVA: 0x8CA320 Offset: 0x8C9520 VA: 0x1808CA320 Slot: 13
	public virtual void set_Delimiter(string value) { }

	// RVA: 0x8CA2C0 Offset: 0x8C94C0 VA: 0x1808CA2C0 Slot: 14
	public virtual char get_Quote() { }

	// RVA: 0x8CA290 Offset: 0x8C9490 VA: 0x1808CA290 Slot: 15
	public virtual char get_Comment() { }

	[CompilerGenerated]
	// RVA: 0x8CA280 Offset: 0x8C9480 VA: 0x1808CA280 Slot: 16
	public virtual bool get_AllowComments() { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0 Slot: 17
	public virtual int get_BufferSize() { }

	[CompilerGenerated]
	// RVA: 0x8CA2A0 Offset: 0x8C94A0 VA: 0x1808CA2A0 Slot: 18
	public virtual bool get_CountBytes() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 19
	public virtual Encoding get_Encoding() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 20
	public virtual CultureInfo get_CultureInfo() { }

	[CompilerGenerated]
	// RVA: 0x8CA2D0 Offset: 0x8C94D0 VA: 0x1808CA2D0 Slot: 21
	public virtual bool get_SkipEmptyRecords() { }

	[CompilerGenerated]
	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 22
	public virtual Func<string[], bool> get_ShouldSkipRecord() { }

	[CompilerGenerated]
	// RVA: 0x67AA00 Offset: 0x679C00 VA: 0x18067AA00 Slot: 23
	public virtual bool get_IgnoreQuotes() { }

	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290 Slot: 24
	public virtual bool get_IgnoreBlankLines() { }

	[CompilerGenerated]
	// RVA: 0x8CA310 Offset: 0x8C9510 VA: 0x1808CA310 Slot: 25
	public virtual bool get_UseExcelLeadingZerosFormatForNumerics() { }

	[CompilerGenerated]
	// RVA: 0x8CA2E0 Offset: 0x8C94E0 VA: 0x1808CA2E0 Slot: 26
	public virtual bool get_ThrowOnBadData() { }

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 27
	public virtual Action<string> get_BadDataCallback() { }

	// RVA: 0x8CA120 Offset: 0x8C9320 VA: 0x1808CA120
	public void .ctor() { }

	// RVA: 0x8CA040 Offset: 0x8C9240 VA: 0x1808CA040
	private void BuildRequiredQuoteChars() { }
}

// Namespace: CsvHelper.Configuration
public class CsvConfigurationException : CsvHelperException // TypeDefIndex: 17693
{
	// Methods

	// RVA: 0x8C9F20 Offset: 0x8C9120 VA: 0x1808C9F20
	public void .ctor(string message) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17694
{}

// Namespace: FxResources.System.Numerics.Vectors
internal static class SR // TypeDefIndex: 17695
{}

// Namespace: System
internal static class SR // TypeDefIndex: 17696
{
	// Fields
	private static ResourceManager s_resourceManager; // 0x0
	[CompilerGenerated]
	private static readonly Type <ResourceType>k__BackingField; // 0x8

	// Properties
	private static ResourceManager ResourceManager { get; }
	internal static Type ResourceType { get; }
	internal static string Arg_ArgumentOutOfRangeException { get; }
	internal static string Arg_TypeNotSupported { get; }

	// Methods

	// RVA: 0x1BC2BE0 Offset: 0x1BC1DE0 VA: 0x181BC2BE0
	private static ResourceManager get_ResourceManager() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	private static bool UsingResourceKeys() { }

	// RVA: 0x1BC28D0 Offset: 0x1BC1AD0 VA: 0x181BC28D0
	internal static string GetResourceString(string resourceKey, string defaultString) { }

	// RVA: 0x1BC27A0 Offset: 0x1BC19A0 VA: 0x181BC27A0
	internal static string Format(string resourceFormat, object p1) { }

	[CompilerGenerated]
	// RVA: 0x1BC2CE0 Offset: 0x1BC1EE0 VA: 0x181BC2CE0
	internal static Type get_ResourceType() { }

	// RVA: 0x1BC2B20 Offset: 0x1BC1D20 VA: 0x181BC2B20
	internal static string get_Arg_ArgumentOutOfRangeException() { }

	// RVA: 0x1BC2B80 Offset: 0x1BC1D80 VA: 0x181BC2B80
	internal static string get_Arg_TypeNotSupported() { }

	// RVA: 0x1BC2AA0 Offset: 0x1BC1CA0 VA: 0x181BC2AA0
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(364, Inherited = False)]
internal sealed class IntrinsicAttribute : Attribute // TypeDefIndex: 17697
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Numerics
internal class ConstantHelper // TypeDefIndex: 17698
{
	// Methods

	// RVA: 0x16CEF20 Offset: 0x16CE120 VA: 0x1816CEF20
	public static byte GetByteWithAllBitsSet() { }

	// RVA: 0x16CEF20 Offset: 0x16CE120 VA: 0x1816CEF20
	public static sbyte GetSByteWithAllBitsSet() { }

	// RVA: 0x16CEF60 Offset: 0x16CE160 VA: 0x1816CEF60
	public static ushort GetUInt16WithAllBitsSet() { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380
	public static short GetInt16WithAllBitsSet() { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380
	public static uint GetUInt32WithAllBitsSet() { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380
	public static int GetInt32WithAllBitsSet() { }

	// RVA: 0x16CEF40 Offset: 0x16CE140 VA: 0x1816CEF40
	public static ulong GetUInt64WithAllBitsSet() { }

	// RVA: 0x16CEF40 Offset: 0x16CE140 VA: 0x1816CEF40
	public static long GetInt64WithAllBitsSet() { }

	// RVA: 0x16CEF50 Offset: 0x16CE150 VA: 0x1816CEF50
	public static float GetSingleWithAllBitsSet() { }

	// RVA: 0x16CEF30 Offset: 0x16CE130 VA: 0x1816CEF30
	public static double GetDoubleWithAllBitsSet() { }
}

// Namespace: System.Numerics
internal struct Register // TypeDefIndex: 17699
{
	// Fields
	internal byte byte_0; // 0x0
	internal byte byte_1; // 0x1
	internal byte byte_2; // 0x2
	internal byte byte_3; // 0x3
	internal byte byte_4; // 0x4
	internal byte byte_5; // 0x5
	internal byte byte_6; // 0x6
	internal byte byte_7; // 0x7
	internal byte byte_8; // 0x8
	internal byte byte_9; // 0x9
	internal byte byte_10; // 0xA
	internal byte byte_11; // 0xB
	internal byte byte_12; // 0xC
	internal byte byte_13; // 0xD
	internal byte byte_14; // 0xE
	internal byte byte_15; // 0xF
	internal sbyte sbyte_0; // 0x0
	internal sbyte sbyte_1; // 0x1
	internal sbyte sbyte_2; // 0x2
	internal sbyte sbyte_3; // 0x3
	internal sbyte sbyte_4; // 0x4
	internal sbyte sbyte_5; // 0x5
	internal sbyte sbyte_6; // 0x6
	internal sbyte sbyte_7; // 0x7
	internal sbyte sbyte_8; // 0x8
	internal sbyte sbyte_9; // 0x9
	internal sbyte sbyte_10; // 0xA
	internal sbyte sbyte_11; // 0xB
	internal sbyte sbyte_12; // 0xC
	internal sbyte sbyte_13; // 0xD
	internal sbyte sbyte_14; // 0xE
	internal sbyte sbyte_15; // 0xF
	internal ushort uint16_0; // 0x0
	internal ushort uint16_1; // 0x2
	internal ushort uint16_2; // 0x4
	internal ushort uint16_3; // 0x6
	internal ushort uint16_4; // 0x8
	internal ushort uint16_5; // 0xA
	internal ushort uint16_6; // 0xC
	internal ushort uint16_7; // 0xE
	internal short int16_0; // 0x0
	internal short int16_1; // 0x2
	internal short int16_2; // 0x4
	internal short int16_3; // 0x6
	internal short int16_4; // 0x8
	internal short int16_5; // 0xA
	internal short int16_6; // 0xC
	internal short int16_7; // 0xE
	internal uint uint32_0; // 0x0
	internal uint uint32_1; // 0x4
	internal uint uint32_2; // 0x8
	internal uint uint32_3; // 0xC
	internal int int32_0; // 0x0
	internal int int32_1; // 0x4
	internal int int32_2; // 0x8
	internal int int32_3; // 0xC
	internal ulong uint64_0; // 0x0
	internal ulong uint64_1; // 0x8
	internal long int64_0; // 0x0
	internal long int64_1; // 0x8
	internal float single_0; // 0x0
	internal float single_1; // 0x4
	internal float single_2; // 0x8
	internal float single_3; // 0xC
	internal double double_0; // 0x0
	internal double double_1; // 0x8
}

// Namespace: 
private struct Vector.VectorSizeHelper<T> // TypeDefIndex: 17700
{
	// Fields
	internal Vector<T> _placeholder; // 0x0
	internal byte _byte; // 0x0
}

// Namespace: System.Numerics
[Intrinsic]
[DefaultMember("Item")]
internal struct Vector<T> : IEquatable<Vector<T>>, IFormattable // TypeDefIndex: 17701
{
	// Fields
	private Register register; // 0x0
	private static readonly int s_count; // 0x0
	private static readonly Vector<T> s_zero; // 0x0
	private static readonly Vector<T> s_one; // 0x0
	private static readonly Vector<T> s_allOnes; // 0x0

	// Properties
	public static int Count { get; }
	public static Vector<T> Zero { get; }
	public T Item { get; }

	// Methods

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBFF50 Offset: 0xDBF150 VA: 0x180DBFF50
	|-Vector<byte>.get_Count
	|-Vector<long>.get_Count
	|-Vector<ushort>.get_Count
	|-Vector<uint>.get_Count
	|-Vector<ulong>.get_Count
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static Vector<T> get_Zero() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC16D0 Offset: 0xDC08D0 VA: 0x180DC16D0
	|-Vector<byte>.get_Zero
	|-Vector<long>.get_Zero
	|-Vector<ushort>.get_Zero
	|-Vector<uint>.get_Zero
	|-Vector<ulong>.get_Zero
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Zero
	*/

	// RVA: -1 Offset: -1
	private static int InitializeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDAF6D0 Offset: 0xDAE8D0 VA: 0x180DAF6D0
	|-Vector<byte>.InitializeCount
	|
	|-RVA: 0xDAF190 Offset: 0xDAE390 VA: 0x180DAF190
	|-Vector<long>.InitializeCount
	|
	|-RVA: 0xDD22E0 Offset: 0xDD14E0 VA: 0x180DD22E0
	|-Vector<ushort>.InitializeCount
	|
	|-RVA: 0xDF3E30 Offset: 0xDF3030 VA: 0x180DF3E30
	|-Vector<uint>.InitializeCount
	|
	|-RVA: 0xDF4370 Offset: 0xDF3570 VA: 0x180DF4370
	|-Vector<ulong>.InitializeCount
	|
	|-RVA: 0xE165F0 Offset: 0xE157F0 VA: 0x180E165F0
	|-Vector<__Il2CppFullySharedGenericStructType>.InitializeCount
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBC580 Offset: 0xDBB780 VA: 0x180DBC580
	|-Vector<byte>..ctor
	|
	|-RVA: 0xDB97D0 Offset: 0xDB89D0 VA: 0x180DB97D0
	|-Vector<long>..ctor
	|
	|-RVA: 0xDDCB50 Offset: 0xDDBD50 VA: 0x180DDCB50
	|-Vector<ushort>..ctor
	|
	|-RVA: 0xDFD6A0 Offset: 0xDFC8A0 VA: 0x180DFD6A0
	|-Vector<uint>..ctor
	|
	|-RVA: 0xE01DD0 Offset: 0xE00FD0 VA: 0x180E01DD0
	|-Vector<ulong>..ctor
	|
	|-RVA: 0xE21B20 Offset: 0xE20D20 VA: 0x180E21B20
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDB8A70 Offset: 0xDB7C70 VA: 0x180DB8A70
	|-Vector<byte>..ctor
	|
	|-RVA: 0xDB8B10 Offset: 0xDB7D10 VA: 0x180DB8B10
	|-Vector<long>..ctor
	|
	|-RVA: 0xDD9CC0 Offset: 0xDD8EC0 VA: 0x180DD9CC0
	|-Vector<ushort>..ctor
	|
	|-RVA: 0xE01D30 Offset: 0xE00F30 VA: 0x180E01D30
	|-Vector<uint>..ctor
	|
	|-RVA: 0xE00450 Offset: 0xDFF650 VA: 0x180E00450
	|-Vector<ulong>..ctor
	|
	|-RVA: 0xE24EC0 Offset: 0xE240C0 VA: 0x180E24EC0
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer, int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDB8BB0 Offset: 0xDB7DB0 VA: 0x180DB8BB0
	|-Vector<byte>..ctor
	|
	|-RVA: 0xDBF330 Offset: 0xDBE530 VA: 0x180DBF330
	|-Vector<long>..ctor
	|
	|-RVA: 0xDD90A0 Offset: 0xDD82A0 VA: 0x180DD90A0
	|-Vector<ushort>..ctor
	|
	|-RVA: 0xE004F0 Offset: 0xDFF6F0 VA: 0x180E004F0
	|-Vector<uint>..ctor
	|
	|-RVA: 0xE01110 Offset: 0xE00310 VA: 0x180E01110
	|-Vector<ulong>..ctor
	|
	|-RVA: 0xE20260 Offset: 0xE1F460 VA: 0x180E20260
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(ref Register existingRegister) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	|-Vector<byte>..ctor
	|-Vector<long>..ctor
	|-Vector<ushort>..ctor
	|-Vector<uint>..ctor
	|-Vector<ulong>..ctor
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC0B60 Offset: 0xDBFD60 VA: 0x180DC0B60
	|-Vector<byte>.get_Item
	|
	|-RVA: 0xDBFFF0 Offset: 0xDBF1F0 VA: 0x180DBFFF0
	|-Vector<long>.get_Item
	|
	|-RVA: 0xDE0490 Offset: 0xDDF690 VA: 0x180DE0490
	|-Vector<ushort>.get_Item
	|
	|-RVA: 0xE056F0 Offset: 0xE048F0 VA: 0x180E056F0
	|-Vector<uint>.get_Item
	|
	|-RVA: 0xE04B80 Offset: 0xE03D80 VA: 0x180E04B80
	|-Vector<ulong>.get_Item
	|
	|-RVA: 0xE25AE0 Offset: 0xE24CE0 VA: 0x180E25AE0
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD9AF20 Offset: 0xD9A120 VA: 0x180D9AF20
	|-Vector<byte>.Equals
	|
	|-RVA: 0xD9ADC0 Offset: 0xD99FC0 VA: 0x180D9ADC0
	|-Vector<long>.Equals
	|
	|-RVA: 0xDC1ED0 Offset: 0xDC10D0 VA: 0x180DC1ED0
	|-Vector<ushort>.Equals
	|
	|-RVA: 0xDE1740 Offset: 0xDE0940 VA: 0x180DE1740
	|-Vector<uint>.Equals
	|
	|-RVA: 0xDE15E0 Offset: 0xDE07E0 VA: 0x180DE15E0
	|-Vector<ulong>.Equals
	|
	|-RVA: 0xE069C0 Offset: 0xE05BC0 VA: 0x180E069C0
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Vector<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDA7B90 Offset: 0xDA6D90 VA: 0x180DA7B90
	|-Vector<byte>.Equals
	|
	|-RVA: 0xDA7350 Offset: 0xDA6550 VA: 0x180DA7350
	|-Vector<long>.Equals
	|
	|-RVA: 0xDCA810 Offset: 0xDC9A10 VA: 0x180DCA810
	|-Vector<ushort>.Equals
	|
	|-RVA: 0xDE9C90 Offset: 0xDE8E90 VA: 0x180DE9C90
	|-Vector<uint>.Equals
	|
	|-RVA: 0xDEC830 Offset: 0xDEBA30 VA: 0x180DEC830
	|-Vector<ulong>.Equals
	|
	|-RVA: 0xE0E670 Offset: 0xE0D870 VA: 0x180E0E670
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDA98D0 Offset: 0xDA8AD0 VA: 0x180DA98D0
	|-Vector<byte>.GetHashCode
	|
	|-RVA: 0xDABAC0 Offset: 0xDAACC0 VA: 0x180DABAC0
	|-Vector<long>.GetHashCode
	|
	|-RVA: 0xDCE700 Offset: 0xDCD900 VA: 0x180DCE700
	|-Vector<ushort>.GetHashCode
	|
	|-RVA: 0xDEE570 Offset: 0xDED770 VA: 0x180DEE570
	|-Vector<uint>.GetHashCode
	|
	|-RVA: 0xDF0760 Offset: 0xDEF960 VA: 0x180DF0760
	|-Vector<ulong>.GetHashCode
	|
	|-RVA: 0xE10510 Offset: 0xE0F710 VA: 0x180E10510
	|-Vector<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDB7CA0 Offset: 0xDB6EA0 VA: 0x180DB7CA0
	|-Vector<byte>.ToString
	|
	|-RVA: 0xDB7D80 Offset: 0xDB6F80 VA: 0x180DB7D80
	|-Vector<long>.ToString
	|
	|-RVA: 0xDD7F10 Offset: 0xDD7110 VA: 0x180DD7F10
	|-Vector<ushort>.ToString
	|
	|-RVA: 0xDFC8E0 Offset: 0xDFBAE0 VA: 0x180DFC8E0
	|-Vector<uint>.ToString
	|
	|-RVA: 0xDFCDC0 Offset: 0xDFBFC0 VA: 0x180DFCDC0
	|-Vector<ulong>.ToString
	|
	|-RVA: 0xE1C8D0 Offset: 0xE1BAD0 VA: 0x180E1C8D0
	|-Vector<__Il2CppFullySharedGenericStructType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDB8260 Offset: 0xDB7460 VA: 0x180DB8260
	|-Vector<byte>.ToString
	|
	|-RVA: 0xDB7E60 Offset: 0xDB7060 VA: 0x180DB7E60
	|-Vector<long>.ToString
	|
	|-RVA: 0xDD7710 Offset: 0xDD6910 VA: 0x180DD7710
	|-Vector<ushort>.ToString
	|
	|-RVA: 0xDFCEA0 Offset: 0xDFC0A0 VA: 0x180DFCEA0
	|-Vector<uint>.ToString
	|
	|-RVA: 0xDFC9C0 Offset: 0xDFBBC0 VA: 0x180DFC9C0
	|-Vector<ulong>.ToString
	|
	|-RVA: 0xE1C9E0 Offset: 0xE1BBE0 VA: 0x180E1C9E0
	|-Vector<__Il2CppFullySharedGenericStructType>.ToString
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static Vector<T> op_BitwiseOr(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC1770 Offset: 0xDC0970 VA: 0x180DC1770
	|-Vector<byte>.op_BitwiseOr
	|
	|-RVA: 0xDC18D0 Offset: 0xDC0AD0 VA: 0x180DC18D0
	|-Vector<long>.op_BitwiseOr
	|
	|-RVA: 0xDE1000 Offset: 0xDE0200 VA: 0x180DE1000
	|-Vector<ushort>.op_BitwiseOr
	|
	|-RVA: 0xE06260 Offset: 0xE05460 VA: 0x180E06260
	|-Vector<uint>.op_BitwiseOr
	|
	|-RVA: 0xE063C0 Offset: 0xE055C0 VA: 0x180E063C0
	|-Vector<ulong>.op_BitwiseOr
	|
	|-RVA: 0xE266B0 Offset: 0xE258B0 VA: 0x180E266B0
	|-Vector<__Il2CppFullySharedGenericStructType>.op_BitwiseOr
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC1AD0 Offset: 0xDC0CD0 VA: 0x180DC1AD0
	|-Vector<byte>.op_Equality
	|
	|-RVA: 0xDC1A30 Offset: 0xDC0C30 VA: 0x180DC1A30
	|-Vector<long>.op_Equality
	|
	|-RVA: 0xDE1160 Offset: 0xDE0360 VA: 0x180DE1160
	|-Vector<ushort>.op_Equality
	|
	|-RVA: 0xE06520 Offset: 0xE05720 VA: 0x180E06520
	|-Vector<uint>.op_Equality
	|
	|-RVA: 0xE065C0 Offset: 0xE057C0 VA: 0x180E065C0
	|-Vector<ulong>.op_Equality
	|
	|-RVA: 0xE26810 Offset: 0xE25A10 VA: 0x180E26810
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC1CB0 Offset: 0xDC0EB0 VA: 0x180DC1CB0
	|-Vector<byte>.op_Inequality
	|
	|-RVA: 0xDC1DC0 Offset: 0xDC0FC0 VA: 0x180DC1DC0
	|-Vector<long>.op_Inequality
	|
	|-RVA: 0xDE13C0 Offset: 0xDE05C0 VA: 0x180DE13C0
	|-Vector<ushort>.op_Inequality
	|
	|-RVA: 0xE067A0 Offset: 0xE059A0 VA: 0x180E067A0
	|-Vector<uint>.op_Inequality
	|
	|-RVA: 0xE068B0 Offset: 0xE05AB0 VA: 0x180E068B0
	|-Vector<ulong>.op_Inequality
	|
	|-RVA: 0xE26B90 Offset: 0xE25D90 VA: 0x180E26B90
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static Vector<byte> op_Explicit(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC1B70 Offset: 0xDC0D70 VA: 0x180DC1B70
	|-Vector<byte>.op_Explicit
	|
	|-RVA: 0xDC1C10 Offset: 0xDC0E10 VA: 0x180DC1C10
	|-Vector<long>.op_Explicit
	|
	|-RVA: 0xDE1360 Offset: 0xDE0560 VA: 0x180DE1360
	|-Vector<ushort>.op_Explicit
	|
	|-RVA: 0xE066A0 Offset: 0xE058A0 VA: 0x180E066A0
	|-Vector<uint>.op_Explicit
	|
	|-RVA: 0xE06740 Offset: 0xE05940 VA: 0x180E06740
	|-Vector<ulong>.op_Explicit
	|
	|-RVA: 0xE26980 Offset: 0xE25B80 VA: 0x180E26980
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Explicit
	*/

	[Intrinsic]
	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public static Vector<ulong> op_Explicit(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC1BB0 Offset: 0xDC0DB0 VA: 0x180DC1BB0
	|-Vector<byte>.op_Explicit
	|
	|-RVA: 0xDC1C50 Offset: 0xDC0E50 VA: 0x180DC1C50
	|-Vector<long>.op_Explicit
	|
	|-RVA: 0xDE1300 Offset: 0xDE0500 VA: 0x180DE1300
	|-Vector<ushort>.op_Explicit
	|
	|-RVA: 0xE06700 Offset: 0xE05900 VA: 0x180E06700
	|-Vector<uint>.op_Explicit
	|
	|-RVA: 0xE06660 Offset: 0xE05860 VA: 0x180E06660
	|-Vector<ulong>.op_Explicit
	|
	|-RVA: 0xE269E0 Offset: 0xE25BE0 VA: 0x180E269E0
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Explicit
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	internal static Vector<T> Equals(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDA2C50 Offset: 0xDA1E50 VA: 0x180DA2C50
	|-Vector<byte>.Equals
	|
	|-RVA: 0xDA4FE0 Offset: 0xDA41E0 VA: 0x180DA4FE0
	|-Vector<long>.Equals
	|
	|-RVA: 0xDC8490 Offset: 0xDC7690 VA: 0x180DC8490
	|-Vector<ushort>.Equals
	|
	|-RVA: 0xDEA4D0 Offset: 0xDE96D0 VA: 0x180DEA4D0
	|-Vector<uint>.Equals
	|
	|-RVA: 0xDE7920 Offset: 0xDE6B20 VA: 0x180DE7920
	|-Vector<ulong>.Equals
	|
	|-RVA: 0xE0B240 Offset: 0xE0A440 VA: 0x180E0B240
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	internal static Vector<T> LessThan(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDAFC10 Offset: 0xDAEE10 VA: 0x180DAFC10
	|-Vector<byte>.LessThan
	|
	|-RVA: 0xDB2110 Offset: 0xDB1310 VA: 0x180DB2110
	|-Vector<long>.LessThan
	|
	|-RVA: 0xDD2820 Offset: 0xDD1A20 VA: 0x180DD2820
	|-Vector<ushort>.LessThan
	|
	|-RVA: 0xDF48B0 Offset: 0xDF3AB0 VA: 0x180DF48B0
	|-Vector<uint>.LessThan
	|
	|-RVA: 0xDF6D70 Offset: 0xDF5F70 VA: 0x180DF6D70
	|-Vector<ulong>.LessThan
	|
	|-RVA: 0xE16B30 Offset: 0xE15D30 VA: 0x180E16B30
	|-Vector<__Il2CppFullySharedGenericStructType>.LessThan
	*/

	// RVA: -1 Offset: -1
	private static bool ScalarEquals(T left, T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDB45E0 Offset: 0xDB37E0 VA: 0x180DB45E0
	|-Vector<byte>.ScalarEquals
	|
	|-RVA: 0xDB5380 Offset: 0xDB4580 VA: 0x180DB5380
	|-Vector<long>.ScalarEquals
	|
	|-RVA: 0xDD5AB0 Offset: 0xDD4CB0 VA: 0x180DD5AB0
	|-Vector<ushort>.ScalarEquals
	|
	|-RVA: 0xDF9240 Offset: 0xDF8440 VA: 0x180DF9240
	|-Vector<uint>.ScalarEquals
	|
	|-RVA: 0xDF9FD0 Offset: 0xDF91D0 VA: 0x180DF9FD0
	|-Vector<ulong>.ScalarEquals
	|
	|-RVA: 0xE198D0 Offset: 0xE18AD0 VA: 0x180E198D0
	|-Vector<__Il2CppFullySharedGenericStructType>.ScalarEquals
	*/

	// RVA: -1 Offset: -1
	private static bool ScalarLessThan(T left, T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDB6120 Offset: 0xDB5320 VA: 0x180DB6120
	|-Vector<byte>.ScalarLessThan
	|
	|-RVA: 0xDB6EE0 Offset: 0xDB60E0 VA: 0x180DB6EE0
	|-Vector<long>.ScalarLessThan
	|
	|-RVA: 0xDD6860 Offset: 0xDD5A60 VA: 0x180DD6860
	|-Vector<ushort>.ScalarLessThan
	|
	|-RVA: 0xDFBB30 Offset: 0xDFAD30 VA: 0x180DFBB30
	|-Vector<uint>.ScalarLessThan
	|
	|-RVA: 0xDFAD70 Offset: 0xDF9F70 VA: 0x180DFAD70
	|-Vector<ulong>.ScalarLessThan
	|
	|-RVA: 0xE1B520 Offset: 0xE1A720 VA: 0x180E1B520
	|-Vector<__Il2CppFullySharedGenericStructType>.ScalarLessThan
	*/

	// RVA: -1 Offset: -1
	private static T GetOneValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDADCB0 Offset: 0xDACEB0 VA: 0x180DADCB0
	|-Vector<byte>.GetOneValue
	|
	|-RVA: 0xDAE720 Offset: 0xDAD920 VA: 0x180DAE720
	|-Vector<long>.GetOneValue
	|
	|-RVA: 0xDD1350 Offset: 0xDD0550 VA: 0x180DD1350
	|-Vector<ushort>.GetOneValue
	|
	|-RVA: 0xDF2950 Offset: 0xDF1B50 VA: 0x180DF2950
	|-Vector<uint>.GetOneValue
	|
	|-RVA: 0xDF33C0 Offset: 0xDF25C0 VA: 0x180DF33C0
	|-Vector<ulong>.GetOneValue
	|
	|-RVA: 0xE14BC0 Offset: 0xE13DC0 VA: 0x180E14BC0
	|-Vector<__Il2CppFullySharedGenericStructType>.GetOneValue
	*/

	// RVA: -1 Offset: -1
	private static T GetAllBitsSetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDA8E50 Offset: 0xDA8050 VA: 0x180DA8E50
	|-Vector<byte>.GetAllBitsSetValue
	|
	|-RVA: 0xDA83D0 Offset: 0xDA75D0 VA: 0x180DA83D0
	|-Vector<long>.GetAllBitsSetValue
	|
	|-RVA: 0xDCBAB0 Offset: 0xDCACB0 VA: 0x180DCBAB0
	|-Vector<ushort>.GetAllBitsSetValue
	|
	|-RVA: 0xDED070 Offset: 0xDEC270 VA: 0x180DED070
	|-Vector<uint>.GetAllBitsSetValue
	|
	|-RVA: 0xDEDAF0 Offset: 0xDECCF0 VA: 0x180DEDAF0
	|-Vector<ulong>.GetAllBitsSetValue
	|
	|-RVA: 0xE0FA50 Offset: 0xE0EC50 VA: 0x180E0FA50
	|-Vector<__Il2CppFullySharedGenericStructType>.GetAllBitsSetValue
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDB8860 Offset: 0xDB7A60 VA: 0x180DB8860
	|-Vector<byte>..cctor
	|
	|-RVA: 0xDB8660 Offset: 0xDB7860 VA: 0x180DB8660
	|-Vector<long>..cctor
	|
	|-RVA: 0xDD81F0 Offset: 0xDD73F0 VA: 0x180DD81F0
	|-Vector<ushort>..cctor
	|
	|-RVA: 0xDFD4A0 Offset: 0xDFC6A0 VA: 0x180DFD4A0
	|-Vector<uint>..cctor
	|
	|-RVA: 0xDFD2A0 Offset: 0xDFC4A0 VA: 0x180DFD2A0
	|-Vector<ulong>..cctor
	|
	|-RVA: 0xE1D130 Offset: 0xE1C330 VA: 0x180E1D130
	|-Vector<__Il2CppFullySharedGenericStructType>..cctor
	*/
}

// Namespace: System.Numerics
[Intrinsic]
internal static class Vector // TypeDefIndex: 17702
{
	// Properties
	public static bool IsHardwareAccelerated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA2BA0 Offset: 0xAA1DA0 VA: 0x180AA2BA0
	|-Vector.Equals<byte>
	|
	|-RVA: 0xAA2D00 Offset: 0xAA1F00 VA: 0x180AA2D00
	|-Vector.Equals<ushort>
	|
	|-RVA: 0xAA2AF0 Offset: 0xAA1CF0 VA: 0x180AA2AF0
	|-Vector.Equals<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static Vector<T> LessThan<T>(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA2DB0 Offset: 0xAA1FB0 VA: 0x180AA2DB0
	|-Vector.LessThan<byte>
	|
	|-RVA: 0xAA2AF0 Offset: 0xAA1CF0 VA: 0x180AA2AF0
	|-Vector.LessThan<__Il2CppFullySharedGenericStructType>
	*/

	[Intrinsic]
	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public static bool get_IsHardwareAccelerated() { }

	// RVA: -1 Offset: -1
	public static Vector<T> BitwiseOr<T>(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA2A40 Offset: 0xAA1C40 VA: 0x180AA2A40
	|-Vector.BitwiseOr<byte>
	|
	|-RVA: 0xAA2AF0 Offset: 0xAA1CF0 VA: 0x180AA2AF0
	|-Vector.BitwiseOr<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static Vector<byte> AsVectorByte<T>(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA2800 Offset: 0xAA1A00 VA: 0x180AA2800
	|-Vector.AsVectorByte<uint>
	|
	|-RVA: 0xAA2770 Offset: 0xAA1970 VA: 0x180AA2770
	|-Vector.AsVectorByte<__Il2CppFullySharedGenericStructType>
	*/

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA2890 Offset: 0xAA1A90 VA: 0x180AA2890
	|-Vector.AsVectorUInt64<byte>
	|
	|-RVA: 0xAA29B0 Offset: 0xAA1BB0 VA: 0x180AA29B0
	|-Vector.AsVectorUInt64<ushort>
	|
	|-RVA: 0xAA2770 Offset: 0xAA1970 VA: 0x180AA2770
	|-Vector.AsVectorUInt64<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: System.Numerics.Hashing
internal static class HashHelpers // TypeDefIndex: 17703
{
	// Fields
	public static readonly int RandomSeed; // 0x0

	// Methods

	// RVA: 0x16DB5B0 Offset: 0x16DA7B0 VA: 0x1816DB5B0
	public static int Combine(int h1, int h2) { }

	// RVA: 0x1BC2740 Offset: 0x1BC1940 VA: 0x181BC2740
	private static void .cctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17704
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 17705
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Usage(27524, AllowMultiple = False, Inherited = False)]
[Embedded]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 17706
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x24FEFB0 Offset: 0x24FE1B0 VA: 0x1824FEFB0
	public void .ctor(byte ) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 17707
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(byte ) { }
}

// Namespace: UnityEngine.Purchasing
internal class AnalyticsClient : IAnalyticsClient // TypeDefIndex: 17708
{
	// Fields
	private readonly IAnalyticsAdapter m_Analytics; // 0x10
	private readonly IAnalyticsAdapter m_LegacyAnalytics; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(IAnalyticsAdapter analytics, IAnalyticsAdapter legacyAnalytics) { }

	// RVA: 0x24FCBC0 Offset: 0x24FBDC0 VA: 0x1824FCBC0 Slot: 4
	public void OnPurchaseSucceeded(Product product) { }

	// RVA: 0x24FCB30 Offset: 0x24FBD30 VA: 0x1824FCB30 Slot: 5
	public void OnPurchaseFailed(Product product, PurchaseFailureDescription description) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class CoreAnalyticsAdapter : IAnalyticsAdapter // TypeDefIndex: 17709
{
	// Fields
	private readonly IAnalyticsService m_Analytics; // 0x10
	private readonly ILogger m_Logger; // 0x18
	[Nullable(2)]
	private IAnalyticsStandardEventComponent m_CoreAnalytics; // 0x20

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(IAnalyticsService analytics, ILogger logger) { }

	// RVA: 0x24FE1B0 Offset: 0x24FD3B0 VA: 0x1824FE1B0 Slot: 4
	public void SendTransactionEvent(Product product) { }

	// RVA: 0x24FD420 Offset: 0x24FC620 VA: 0x1824FD420
	private Dictionary<string, object> BuildTransactionParameters(Product product) { }

	// RVA: 0x24FE260 Offset: 0x24FD460 VA: 0x1824FE260 Slot: 5
	public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }

	[NullableContext(2)]
	// RVA: 0x24FD7F0 Offset: 0x24FC9F0 VA: 0x1824FD7F0
	private IAnalyticsStandardEventComponent CoreAnalytics() { }

	// RVA: 0x24FD1F0 Offset: 0x24FC3F0 VA: 0x1824FD1F0
	private Dictionary<string, object> BuildTransactionFailedParameters(Product product, PurchaseFailureReason reason) { }

	// RVA: 0x24FE160 Offset: 0x24FD360 VA: 0x1824FE160
	private static string GetTransactionName(Product product) { }

	// RVA: 0x24FDC50 Offset: 0x24FCE50 VA: 0x1824FDC50
	private static Dictionary<string, object> GenerateItemReceivedForPurchase(Product product) { }

	// RVA: 0x24FDF00 Offset: 0x24FD100 VA: 0x1824FDF00
	private Dictionary<string, object> GenerateRealCurrencySpentOnPurchase(Product product) { }

	// RVA: 0x24FD870 Offset: 0x24FCA70 VA: 0x1824FD870
	private Dictionary<string, object> CreateRealCurrencyFromProduct(Product product) { }

	// RVA: 0x24FD6F0 Offset: 0x24FC8F0 VA: 0x1824FD6F0
	private long CheckCurrencyCodeAndExtractRealCurrencyAmount(Product product) { }

	// RVA: 0x24FDA50 Offset: 0x24FCC50 VA: 0x1824FDA50
	private long ExtractRealCurrencyAmount(Product product) { }
}

// Namespace: UnityEngine.Purchasing
internal class EmptyAnalyticsAdapter : IAnalyticsAdapter // TypeDefIndex: 17710
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public void SendTransactionEvent(Product product) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription reason) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
internal interface IAnalyticsAdapter // TypeDefIndex: 17711
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendTransactionEvent(Product product);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description);
}

// Namespace: UnityEngine.Purchasing
internal interface IAnalyticsClient // TypeDefIndex: 17712
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPurchaseSucceeded(Product product);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnPurchaseFailed(Product product, PurchaseFailureDescription purchaseFailureDescription);
}

// Namespace: UnityEngine.Purchasing
internal interface ILegacyUnityAnalytics // TypeDefIndex: 17713
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendTransactionEvent(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendCustomEvent(string name, Dictionary<string, object> data);
}

// Namespace: UnityEngine.Purchasing
internal class LegacyAnalyticsAdapter : IAnalyticsAdapter // TypeDefIndex: 17714
{
	// Fields
	private readonly ILegacyUnityAnalytics m_LegacyAnalytics; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(ILegacyUnityAnalytics legacyAnalytics) { }

	// RVA: 0x24FE7D0 Offset: 0x24FD9D0 VA: 0x1824FE7D0 Slot: 4
	public void SendTransactionEvent(Product product) { }

	// RVA: 0x24FE920 Offset: 0x24FDB20 VA: 0x1824FE920 Slot: 5
	public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }
}

// Namespace: UnityEngine.Purchasing
internal class LegacyAnalyticsWrapper : IAnalyticsAdapter, ICoreServicesEnvironmentObserver // TypeDefIndex: 17715
{
	// Fields
	private bool m_Enabled; // 0x10
	private IAnalyticsAdapter m_LegacyAdapter; // 0x18
	private IAnalyticsAdapter m_EmptyAdapter; // 0x20

	// Properties
	private IAnalyticsAdapter m_AnalyticsAdapter { get; }

	// Methods

	// RVA: 0x24FECD0 Offset: 0x24FDED0 VA: 0x1824FECD0
	internal void .ctor(IAnalyticsAdapter legacyAdapter, IAnalyticsAdapter emptyAdapter) { }

	// RVA: 0x24FEBE0 Offset: 0x24FDDE0 VA: 0x1824FEBE0 Slot: 4
	public void SendTransactionEvent(Product product) { }

	// RVA: 0x24FEC50 Offset: 0x24FDE50 VA: 0x1824FEC50 Slot: 5
	public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }

	// RVA: 0x24FEB80 Offset: 0x24FDD80 VA: 0x1824FEB80 Slot: 6
	public void OnUpdatedCoreServicesEnvironment(string currentEnvironment) { }

	// RVA: 0x24FEE60 Offset: 0x24FE060 VA: 0x1824FEE60
	private IAnalyticsAdapter get_m_AnalyticsAdapter() { }
}

// Namespace: UnityEngine.Purchasing
internal class LegacyUnityAnalytics : ILegacyUnityAnalytics // TypeDefIndex: 17716
{
	// Methods

	// RVA: 0x24FEE90 Offset: 0x24FE090 VA: 0x1824FEE90 Slot: 4
	public void SendTransactionEvent(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature) { }

	// RVA: 0x24FEE70 Offset: 0x24FE070 VA: 0x1824FEE70 Slot: 5
	public void SendCustomEvent(string name, Dictionary<string, object> data) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
internal class AnalyticsTransactionReceipt // TypeDefIndex: 17717
{
	// Fields
	[CompilerGenerated]
	private string <transactionReceipt>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <transactionReceiptSignature>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<TransactionServer> <transactionServer>k__BackingField; // 0x20

	// Properties
	public string transactionReceipt { get; set; }
	public string transactionReceiptSignature { get; set; }
	public Nullable<TransactionServer> transactionServer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_transactionReceipt() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_transactionReceipt(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_transactionReceiptSignature() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_transactionReceiptSignature(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Nullable<TransactionServer> get_transactionServer() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_transactionServer(Nullable<TransactionServer> value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
internal class GoogleReceipt // TypeDefIndex: 17718
{
	// Fields
	public string json; // 0x10
	public string signature; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
public class IDs : IEnumerable<KeyValuePair<string, string>>, IEnumerable // TypeDefIndex: 17719
{
	// Fields
	private readonly Dictionary<string, string> m_Dic; // 0x10

	// Methods

	// RVA: 0x24FE740 Offset: 0x24FD940 VA: 0x1824FE740 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x24FE6A0 Offset: 0x24FD8A0 VA: 0x1824FE6A0
	internal string SpecificIDForStore(string store, string defaultValue) { }

	// RVA: 0x24FE610 Offset: 0x24FD810 VA: 0x1824FE610 Slot: 4
	public IEnumerator<KeyValuePair<string, string>> GetEnumerator() { }
}

// Namespace: UnityEngine.Purchasing
public class ConfigurationBuilder // TypeDefIndex: 17720
{
	// Fields
	[CompilerGenerated]
	private bool <useCatalogProvider>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <logUnavailableProducts>k__BackingField; // 0x11
	[CompilerGenerated]
	private readonly HashSet<ProductDefinition> <products>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly PurchasingFactory <factory>k__BackingField; // 0x20

	// Properties
	public bool useCatalogProvider { get; }
	public bool logUnavailableProducts { get; }
	public HashSet<ProductDefinition> products { get; }
	internal PurchasingFactory factory { get; }

	// Methods

	// RVA: 0x24FD160 Offset: 0x24FC360 VA: 0x1824FD160
	internal void .ctor(PurchasingFactory factory) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_useCatalogProvider() { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_logUnavailableProducts() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public HashSet<ProductDefinition> get_products() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal PurchasingFactory get_factory() { }

	// RVA: 0x24FCF10 Offset: 0x24FC110 VA: 0x1824FCF10
	public static ConfigurationBuilder Instance(IPurchasingModule first, IPurchasingModule[] rest) { }

	// RVA: 0x24FCC50 Offset: 0x24FBE50 VA: 0x1824FCC50
	public ConfigurationBuilder AddProduct(string id, ProductType type) { }

	// RVA: 0x24FCEF0 Offset: 0x24FC0F0 VA: 0x1824FCEF0
	public ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs) { }

	// RVA: 0x24FCD30 Offset: 0x24FBF30 VA: 0x1824FCD30
	public ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs, IEnumerable<PayoutDefinition> payouts) { }
}

// Namespace: UnityEngine.Purchasing
internal class CoreServicesEnvironmentSubject // TypeDefIndex: 17721
{
	// Fields
	private static CoreServicesEnvironmentSubject s_Instance; // 0x0
	private string m_LastKnownEnvironment; // 0x10
	private List<ICoreServicesEnvironmentObserver> m_Observers; // 0x18

	// Methods

	// RVA: 0x24FE330 Offset: 0x24FD530 VA: 0x1824FE330
	internal static CoreServicesEnvironmentSubject Instance() { }

	// RVA: 0x24FE440 Offset: 0x24FD640 VA: 0x1824FE440
	public void SubscribeToUpdatesAndGetCurrent(ICoreServicesEnvironmentObserver newObserver) { }

	// RVA: 0x24FE400 Offset: 0x24FD600 VA: 0x1824FE400
	internal bool IsDefaultLiveEnvironment(string environment) { }

	// RVA: 0x24FE5A0 Offset: 0x24FD7A0 VA: 0x1824FE5A0
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
internal interface ICoreServicesEnvironmentObserver // TypeDefIndex: 17722
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnUpdatedCoreServicesEnvironment(string currentEnvironment);
}

// Namespace: UnityEngine.Purchasing
internal interface IUnityServicesInitializationChecker // TypeDefIndex: 17723
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CheckAndLogWarning();
}

// Namespace: UnityEngine.Purchasing
internal class UnityServicesInitializationChecker : IUnityServicesInitializationChecker // TypeDefIndex: 17724
{
	// Fields
	private readonly ILogger m_Logger; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(ILogger logger) { }

	// RVA: 0x2503200 Offset: 0x2502400 VA: 0x182503200 Slot: 4
	public void CheckAndLogWarning() { }

	// RVA: 0x25032A0 Offset: 0x25024A0 VA: 0x1825032A0
	private bool IsUninitialized() { }

	// RVA: 0x25033A0 Offset: 0x25025A0 VA: 0x1825033A0
	private void LogWarning() { }
}

// Namespace: UnityEngine.Purchasing
public interface IStoreExtension // TypeDefIndex: 17725
{}

// Namespace: UnityEngine.Purchasing
public interface IDetailedStoreListener : IStoreListener // TypeDefIndex: 17726
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription);
}

// Namespace: UnityEngine.Purchasing
public interface IExtensionProvider // TypeDefIndex: 17727
{}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IInternalStoreListener // TypeDefIndex: 17728
{
	// Methods

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInitializeFailed(InitializationFailureReason error, string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPurchaseFailed(Product i, PurchaseFailureDescription p);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnInitialized(IStoreController controller);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SendTransactionEvent(Product product);
}

// Namespace: UnityEngine.Purchasing
public enum InitializationFailureReason // TypeDefIndex: 17729
{
	// Fields
	public int value__; // 0x0
	public const InitializationFailureReason PurchasingUnavailable = 0;
	public const InitializationFailureReason NoProductsAvailable = 1;
	public const InitializationFailureReason AppNotKnown = 2;
}

// Namespace: UnityEngine.Purchasing
public interface IStoreController // TypeDefIndex: 17730
{
	// Properties
	public abstract ProductCollection products { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ProductCollection get_products();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void InitiatePurchase(string productId);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ConfirmPendingPurchase(Product product);
}

// Namespace: UnityEngine.Purchasing
public interface IStoreListener // TypeDefIndex: 17731
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInitializeFailed(InitializationFailureReason error, string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent);

	[Obsolete("Use IDetailedStoreListener.OnPurchaseFailed for more detailed callback.", False)]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnInitialized(IStoreController controller, IExtensionProvider extensions);
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class PayoutDefinition // TypeDefIndex: 17732
{
	// Fields
	[SerializeField]
	private PayoutType m_Type; // 0x10
	[SerializeField]
	private string m_Subtype; // 0x18
	[SerializeField]
	private double m_Quantity; // 0x20
	[SerializeField]
	private string m_Data; // 0x28
	public const int MaxSubtypeLength = 64;
	public const int MaxDataLength = 1024;

	// Methods

	// RVA: 0x24FF030 Offset: 0x24FE230 VA: 0x1824FF030
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
public enum PayoutType // TypeDefIndex: 17733
{
	// Fields
	public int value__; // 0x0
	public const PayoutType Other = 0;
	public const PayoutType Currency = 1;
	public const PayoutType Item = 2;
	public const PayoutType Resource = 3;
}

// Namespace: UnityEngine.Purchasing
public class Product // TypeDefIndex: 17734
{
	// Fields
	[CompilerGenerated]
	private ProductDefinition <definition>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductMetadata <metadata>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <availableToPurchase>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <transactionID>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <appleOriginalTransactionID>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <appleProductIsRestored>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <receipt>k__BackingField; // 0x40

	// Properties
	public ProductDefinition definition { get; set; }
	public ProductMetadata metadata { get; set; }
	public bool availableToPurchase { get; set; }
	public string transactionID { get; set; }
	public string appleOriginalTransactionID { get; set; }
	public bool appleProductIsRestored { get; set; }
	public bool hasReceipt { get; }
	public string receipt { get; set; }

	// Methods

	// RVA: 0x24FF990 Offset: 0x24FEB90 VA: 0x1824FF990
	internal void .ctor(ProductDefinition definition, ProductMetadata metadata, string receipt) { }

	// RVA: 0x24FF9E0 Offset: 0x24FEBE0 VA: 0x1824FF9E0
	internal void .ctor(ProductDefinition definition, ProductMetadata metadata) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductDefinition get_definition() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_definition(ProductDefinition value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductMetadata get_metadata() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_metadata(ProductMetadata value) { }

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_availableToPurchase() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	internal void set_availableToPurchase(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_transactionID() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_transactionID(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_appleOriginalTransactionID() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_appleOriginalTransactionID(string value) { }

	[CompilerGenerated]
	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_appleProductIsRestored() { }

	[CompilerGenerated]
	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	internal void set_appleProductIsRestored(bool value) { }

	// RVA: 0x24FFA20 Offset: 0x24FEC20 VA: 0x1824FFA20
	public bool get_hasReceipt() { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_receipt() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_receipt(string value) { }

	// RVA: 0x24FF8E0 Offset: 0x24FEAE0 VA: 0x1824FF8E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ProductCollection.<>c // TypeDefIndex: 17735
{
	// Fields
	public static readonly ProductCollection.<>c <>9; // 0x0
	public static Func<Product, string> <>9__3_0; // 0x8
	public static Func<Product, string> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x2502370 Offset: 0x2501570 VA: 0x182502370
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2502080 Offset: 0x2501280 VA: 0x182502080
	internal string <AddProducts>b__3_0(Product x) { }

	// RVA: 0x25020B0 Offset: 0x25012B0 VA: 0x1825020B0
	internal string <AddProducts>b__3_1(Product x) { }
}

// Namespace: UnityEngine.Purchasing
public class ProductCollection // TypeDefIndex: 17736
{
	// Fields
	private Dictionary<string, Product> m_IdToProduct; // 0x10
	private Dictionary<string, Product> m_StoreSpecificIdToProduct; // 0x18
	[CompilerGenerated]
	private readonly HashSet<Product> <set>k__BackingField; // 0x20
	[CompilerGenerated]
	private Product[] <all>k__BackingField; // 0x28

	// Properties
	public HashSet<Product> set { get; }
	public Product[] all { get; set; }

	// Methods

	// RVA: 0x24FF370 Offset: 0x24FE570 VA: 0x1824FF370
	internal void .ctor(Product[] products) { }

	// RVA: 0x24FF090 Offset: 0x24FE290 VA: 0x1824FF090
	internal void AddProducts(IEnumerable<Product> products) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public HashSet<Product> get_set() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Product[] get_all() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_all(Product[] value) { }

	// RVA: 0x24FF290 Offset: 0x24FE490 VA: 0x1824FF290
	public Product WithID(string id) { }

	// RVA: 0x24FF300 Offset: 0x24FE500 VA: 0x1824FF300
	public Product WithStoreSpecificID(string id) { }
}

// Namespace: UnityEngine.Purchasing
public class ProductDefinition // TypeDefIndex: 17737
{
	// Fields
	[CompilerGenerated]
	private string <id>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <storeSpecificId>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductType <type>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <enabled>k__BackingField; // 0x24
	private readonly List<PayoutDefinition> m_Payouts; // 0x28

	// Properties
	public string id { get; set; }
	public string storeSpecificId { get; set; }
	public ProductType type { get; set; }
	private bool enabled { set; }

	// Methods

	// RVA: 0x24FF530 Offset: 0x24FE730 VA: 0x1824FF530
	public void .ctor(string id, string storeSpecificId, ProductType type) { }

	// RVA: 0x24FF750 Offset: 0x24FE950 VA: 0x1824FF750
	public void .ctor(string id, string storeSpecificId, ProductType type, bool enabled) { }

	// RVA: 0x24FF620 Offset: 0x24FE820 VA: 0x1824FF620
	public void .ctor(string id, string storeSpecificId, ProductType type, bool enabled, IEnumerable<PayoutDefinition> payouts) { }

	// RVA: 0x24FF600 Offset: 0x24FE800 VA: 0x1824FF600
	public void .ctor(string id, ProductType type) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_id() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_id(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_storeSpecificId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_storeSpecificId(string value) { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public ProductType get_type() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	private void set_type(ProductType value) { }

	[CompilerGenerated]
	// RVA: 0x7428E0 Offset: 0x741AE0 VA: 0x1807428E0
	private void set_enabled(bool value) { }

	// RVA: 0x24FF400 Offset: 0x24FE600 VA: 0x1824FF400 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24FF4A0 Offset: 0x24FE6A0 VA: 0x1824FF4A0
	internal void SetPayouts(IEnumerable<PayoutDefinition> newPayouts) { }
}

// Namespace: UnityEngine.Purchasing
public class ProductMetadata // TypeDefIndex: 17738
{
	// Fields
	[CompilerGenerated]
	private string <localizedPriceString>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <localizedTitle>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <localizedDescription>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <isoCurrencyCode>k__BackingField; // 0x28
	[CompilerGenerated]
	private Decimal <localizedPrice>k__BackingField; // 0x30

	// Properties
	internal string localizedPriceString { set; }
	public string localizedTitle { get; set; }
	internal string localizedDescription { set; }
	public string isoCurrencyCode { get; set; }
	public Decimal localizedPrice { get; set; }

	// Methods

	// RVA: 0x24FF880 Offset: 0x24FEA80 VA: 0x1824FF880
	public void .ctor(string priceString, string title, string description, string currencyCode, Decimal localizedPrice) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_localizedPriceString(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_localizedTitle() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_localizedTitle(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_localizedDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_isoCurrencyCode() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_isoCurrencyCode(string value) { }

	[CompilerGenerated]
	// RVA: 0x160E010 Offset: 0x160D210 VA: 0x18160E010
	public Decimal get_localizedPrice() { }

	[CompilerGenerated]
	// RVA: 0x160E020 Offset: 0x160D220 VA: 0x18160E020
	internal void set_localizedPrice(Decimal value) { }
}

// Namespace: UnityEngine.Purchasing
public enum ProductType // TypeDefIndex: 17739
{
	// Fields
	public int value__; // 0x0
	public const ProductType Consumable = 0;
	public const ProductType NonConsumable = 1;
	public const ProductType Subscription = 2;
}

// Namespace: UnityEngine.Purchasing
public class PurchaseEventArgs // TypeDefIndex: 17740
{
	// Fields
	[CompilerGenerated]
	private Product <purchasedProduct>k__BackingField; // 0x10

	// Properties
	public Product purchasedProduct { get; set; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(Product purchasedProduct) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Product get_purchasedProduct() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_purchasedProduct(Product value) { }
}

// Namespace: UnityEngine.Purchasing
public enum PurchaseFailureReason // TypeDefIndex: 17741
{
	// Fields
	public int value__; // 0x0
	public const PurchaseFailureReason PurchasingUnavailable = 0;
	public const PurchaseFailureReason ExistingPurchasePending = 1;
	public const PurchaseFailureReason ProductUnavailable = 2;
	public const PurchaseFailureReason SignatureInvalid = 3;
	public const PurchaseFailureReason UserCancelled = 4;
	public const PurchaseFailureReason PaymentDeclined = 5;
	public const PurchaseFailureReason DuplicateTransaction = 6;
	public const PurchaseFailureReason Unknown = 7;
}

// Namespace: UnityEngine.Purchasing
public enum PurchaseProcessingResult // TypeDefIndex: 17742
{
	// Fields
	public int value__; // 0x0
	public const PurchaseProcessingResult Complete = 0;
	public const PurchaseProcessingResult Pending = 1;
}

// Namespace: UnityEngine.Purchasing
internal class PurchasingFactory : IPurchasingBinder, IExtensionProvider // TypeDefIndex: 17743
{
	// Fields
	private readonly Dictionary<Type, IStoreConfiguration> m_ConfigMap; // 0x10
	private readonly Dictionary<Type, IStoreExtension> m_ExtensionMap; // 0x18
	private IStore m_Store; // 0x20
	private ICatalogProvider m_CatalogProvider; // 0x28
	[CompilerGenerated]
	private string <storeName>k__BackingField; // 0x30

	// Properties
	public string storeName { get; set; }
	public IStore service { get; set; }

	// Methods

	// RVA: 0x24FFA60 Offset: 0x24FEC60 VA: 0x1824FFA60
	public void .ctor(IPurchasingModule first, IPurchasingModule[] remainingModules) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_storeName() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_storeName(string value) { }

	// RVA: 0x24FFC10 Offset: 0x24FEE10 VA: 0x1824FFC10
	public IStore get_service() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_service(IStore value) { }

	// RVA: 0x24FFA40 Offset: 0x24FEC40 VA: 0x1824FFA40 Slot: 4
	public void RegisterStore(string name, IStore s) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal ICatalogProvider GetCatalogProvider() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PurchasingManager.<>c // TypeDefIndex: 17744
{
	// Fields
	[Nullable(0)]
	public static readonly PurchasingManager.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<ProductDefinition, Product> <>9__45_0; // 0x8

	// Methods

	// RVA: 0x25023D0 Offset: 0x25015D0 VA: 0x1825023D0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x25020E0 Offset: 0x25012E0 VA: 0x1825020E0
	internal Product <Initialize>b__45_0(ProductDefinition x) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class PurchasingManager : IStoreCallback, IStoreController // TypeDefIndex: 17745
{
	// Fields
	private readonly IStore m_Store; // 0x10
	[Nullable(2)]
	private IInternalStoreListener m_Listener; // 0x18
	private readonly ILogger m_Logger; // 0x20
	private readonly TransactionLog m_TransactionLog; // 0x28
	private readonly string m_StoreName; // 0x30
	private readonly bool m_logUnavailableProducts; // 0x38
	private readonly IUnityServicesInitializationChecker m_UnityServicesInitializationChecker; // 0x40
	[Nullable(2)]
	private Action m_AdditionalProductsCallback; // 0x48
	private readonly HashSet<string> purchasesProcessedInSession; // 0x50
	[CompilerGenerated]
	private bool <useTransactionLog>k__BackingField; // 0x58
	[CompilerGenerated]
	private ProductCollection <products>k__BackingField; // 0x60
	private bool initialized; // 0x68

	// Properties
	public bool useTransactionLog { get; set; }
	public ProductCollection products { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30 Slot: 10
	public bool get_useTransactionLog() { }

	[CompilerGenerated]
	// RVA: 0x4D1A70 Offset: 0x4D0C70 VA: 0x1804D1A70 Slot: 11
	public void set_useTransactionLog(bool value) { }

	// RVA: 0x2501750 Offset: 0x2500950 VA: 0x182501750
	internal void .ctor(TransactionLog tDb, ILogger logger, IStore store, string storeName, IUnityServicesInitializationChecker unityServicesInitializationChecker, bool logUnavailableProducts) { }

	[NullableContext(2)]
	// RVA: 0x25009E0 Offset: 0x24FFBE0 VA: 0x1825009E0 Slot: 8
	public void InitiatePurchase(string productId) { }

	// RVA: 0x2500820 Offset: 0x24FFA20 VA: 0x182500820 Slot: 12
	public void InitiatePurchase(Product product, string developerPayload) { }

	// RVA: 0x2500540 Offset: 0x24FF740 VA: 0x182500540 Slot: 13
	public void InitiatePurchase(string purchasableId, string developerPayload) { }

	// RVA: 0x24FFD70 Offset: 0x24FEF70 VA: 0x1824FFD70 Slot: 9
	public void ConfirmPendingPurchase(Product product) { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 7
	public ProductCollection get_products() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	private void set_products(ProductCollection value) { }

	// RVA: 0x25011B0 Offset: 0x25003B0 VA: 0x1825011B0 Slot: 5
	public void OnPurchaseSucceeded(string id, string receipt, string transactionId) { }

	// RVA: 0x2501710 Offset: 0x2500910 VA: 0x182501710
	private void UpdateProductReceiptAndTransactionID(Product product, string receipt, string transactionId) { }

	// RVA: 0x2500E30 Offset: 0x2500030 VA: 0x182500E30 Slot: 6
	public void OnPurchaseFailed(PurchaseFailureDescription description) { }

	// RVA: 0x2500A40 Offset: 0x24FFC40 VA: 0x182500A40 Slot: 4
	public void OnProductsRetrieved(List<ProductDescription> products) { }

	// RVA: 0x24FFED0 Offset: 0x24FF0D0 VA: 0x1824FFED0
	private string CreateUnifiedReceipt(string rawReceipt, string transactionId) { }

	// RVA: 0x25015C0 Offset: 0x25007C0 VA: 0x1825015C0
	private void ProcessPurchaseOnStart() { }

	// RVA: 0x2501320 Offset: 0x2500520 VA: 0x182501320
	private void ProcessPurchaseIfNew(Product product) { }

	// RVA: 0x2500200 Offset: 0x24FF400 VA: 0x182500200
	private bool HasRecordedTransaction(string transactionId) { }

	// RVA: 0x24FFC80 Offset: 0x24FEE80 VA: 0x1824FFC80
	private void CheckForInitialization(int productCount) { }

	// RVA: 0x24FFF60 Offset: 0x24FF160 VA: 0x1824FFF60
	private bool HasAvailableProductsToPurchase() { }

	// RVA: 0x2500280 Offset: 0x24FF480 VA: 0x182500280
	public void Initialize(IInternalStoreListener listener, HashSet<ProductDefinition> products) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class StoreListenerProxy : IInternalStoreListener // TypeDefIndex: 17746
{
	// Fields
	private readonly IAnalyticsClient m_Analytics; // 0x10
	private readonly IStoreListener m_ForwardTo; // 0x18
	private readonly IExtensionProvider m_Extensions; // 0x20

	// Methods

	// RVA: 0x2501B70 Offset: 0x2500D70 VA: 0x182501B70
	public void .ctor(IStoreListener forwardTo, IAnalyticsClient analytics, IExtensionProvider extensions) { }

	// RVA: 0x2501880 Offset: 0x2500A80 VA: 0x182501880 Slot: 7
	public void OnInitialized(IStoreController controller) { }

	[NullableContext(2)]
	// RVA: 0x2501810 Offset: 0x2500A10 VA: 0x182501810 Slot: 4
	public void OnInitializeFailed(InitializationFailureReason error, string message) { }

	// RVA: 0x2501AB0 Offset: 0x2500CB0 VA: 0x182501AB0 Slot: 5
	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e) { }

	// RVA: 0x2501950 Offset: 0x2500B50 VA: 0x182501950 Slot: 6
	public void OnPurchaseFailed(Product i, PurchaseFailureDescription p) { }

	// RVA: 0x2501B10 Offset: 0x2500D10 VA: 0x182501B10 Slot: 8
	public void SendTransactionEvent(Product product) { }
}

// Namespace: UnityEngine.Purchasing
internal class TransactionLog // TypeDefIndex: 17747
{
	// Fields
	private readonly ILogger logger; // 0x10
	private readonly string persistentDataPath; // 0x18

	// Methods

	// RVA: 0x2501FC0 Offset: 0x25011C0 VA: 0x182501FC0
	public void .ctor(ILogger logger, string persistentDataPath) { }

	// RVA: 0x2501ED0 Offset: 0x25010D0 VA: 0x182501ED0
	public bool HasRecordOf(string transactionID) { }

	// RVA: 0x2501F30 Offset: 0x2501130 VA: 0x182501F30
	public void Record(string transactionID) { }

	// RVA: 0x2501D20 Offset: 0x2500F20 VA: 0x182501D20
	private string GetRecordPath(string transactionID) { }

	// RVA: 0x2501BC0 Offset: 0x2500DC0 VA: 0x182501BC0
	internal static string ComputeHash(string transactionID) { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class UnifiedReceipt // TypeDefIndex: 17748
{
	// Fields
	public string Payload; // 0x10
	public string Store; // 0x18
	public string TransactionID; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[Extension]
internal static class UnifiedReceiptExtensions // TypeDefIndex: 17749
{
	// Methods

	[Extension]
	// RVA: 0x2502430 Offset: 0x2501630 VA: 0x182502430
	public static AnalyticsTransactionReceipt ToReceiptAndSignature(UnifiedReceipt receipt) { }

	[Extension]
	// RVA: 0x2502660 Offset: 0x2501860 VA: 0x182502660
	private static Nullable<TransactionServer> ToTransactionServer(UnifiedReceipt receipt) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityPurchasing.<>c__DisplayClass5_0 // TypeDefIndex: 17750
{
	// Fields
	public PurchasingManager manager; // 0x10
	public StoreListenerProxy proxy; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2502170 Offset: 0x2501370 VA: 0x182502170
	internal void <Initialize>b__0(HashSet<ProductDefinition> response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityPurchasing.<>c__DisplayClass6_0 // TypeDefIndex: 17751
{
	// Fields
	public HashSet<ProductDefinition> localProductSet; // 0x10
	public Action<HashSet<ProductDefinition>> callback; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25021A0 Offset: 0x25013A0 VA: 0x1825021A0
	internal void <FetchAndMergeProducts>b__0(HashSet<ProductDefinition> cloudProducts) { }
}

// Namespace: UnityEngine.Purchasing
public abstract class UnityPurchasing // TypeDefIndex: 17752
{
	// Methods

	[Obsolete("Use Initialize(IDetailedStoreListener, ConfigurationBuilder)", False)]
	// RVA: 0x2502FF0 Offset: 0x25021F0 VA: 0x182502FF0
	public static void Initialize(IStoreListener listener, ConfigurationBuilder builder) { }

	// RVA: 0x2502A60 Offset: 0x2501C60 VA: 0x182502A60
	private static IAnalyticsAdapter GenerateUnityAnalytics(ILogger logger) { }

	// RVA: 0x25029E0 Offset: 0x2501BE0 VA: 0x1825029E0
	private static IAnalyticsAdapter GenerateLegacyUnityAnalytics() { }

	// RVA: 0x2502B80 Offset: 0x2501D80 VA: 0x182502B80
	internal static void Initialize(IStoreListener listener, ConfigurationBuilder builder, ILogger logger, string persistentDatapath, IAnalyticsAdapter ugsAnalytics, IAnalyticsAdapter legacyAnalytics, ICatalogProvider catalog, IUnityServicesInitializationChecker unityServicesInitializationChecker) { }

	// RVA: 0x2502860 Offset: 0x2501A60 VA: 0x182502860
	internal static void FetchAndMergeProducts(bool useCatalog, HashSet<ProductDefinition> localProductSet, ICatalogProvider catalog, Action<HashSet<ProductDefinition>> callback) { }
}

// Namespace: UnityEngine.Purchasing
[Extension]
internal static class LoggerExtensions // TypeDefIndex: 17753
{
	// Methods

	[Extension]
	// RVA: 0x24FEF40 Offset: 0x24FE140 VA: 0x1824FEF40
	public static void LogIAPWarning(ILogger logger, string message) { }

	[Extension]
	// RVA: 0x24FEED0 Offset: 0x24FE0D0 VA: 0x1824FEED0
	public static void LogIAPError(ILogger logger, string message) { }
}

// Namespace: UnityEngine.Purchasing
internal static class UnifiedReceiptFormatter // TypeDefIndex: 17754
{
	// Methods

	// RVA: 0x25027D0 Offset: 0x25019D0 VA: 0x1825027D0
	internal static string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName) { }
}

// Namespace: UnityEngine.Purchasing.Extension
public interface ICatalogProvider // TypeDefIndex: 17755
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FetchProducts(Action<HashSet<ProductDefinition>> callback);
}

// Namespace: UnityEngine.Purchasing.Extension
public interface IPurchasingBinder // TypeDefIndex: 17756
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RegisterStore(string name, IStore store);
}

// Namespace: UnityEngine.Purchasing.Extension
public interface IPurchasingModule // TypeDefIndex: 17757
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Configure(IPurchasingBinder binder);
}

// Namespace: UnityEngine.Purchasing.Extension
public interface IStore // TypeDefIndex: 17758
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize(IStoreCallback callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Purchase(ProductDefinition product, string developerPayload);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void FinishTransaction(ProductDefinition product, string transactionId);
}

// Namespace: UnityEngine.Purchasing.Extension
public interface IStoreCallback // TypeDefIndex: 17759
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnProductsRetrieved(List<ProductDescription> products);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnPurchaseSucceeded(string storeSpecificId, string receipt, string transactionIdentifier);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPurchaseFailed(PurchaseFailureDescription desc);
}

// Namespace: UnityEngine.Purchasing.Extension
public interface IStoreConfiguration // TypeDefIndex: 17760
{}

// Namespace: UnityEngine.Purchasing.Extension
public class ProductDescription // TypeDefIndex: 17761
{
	// Fields
	[CompilerGenerated]
	private string <storeSpecificId>k__BackingField; // 0x10
	public ProductType type; // 0x18
	[CompilerGenerated]
	private ProductMetadata <metadata>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <receipt>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <transactionId>k__BackingField; // 0x30

	// Properties
	public string storeSpecificId { get; set; }
	public ProductMetadata metadata { get; set; }
	public string receipt { get; set; }
	public string transactionId { get; set; }

	// Methods

	// RVA: 0x24FF820 Offset: 0x24FEA20 VA: 0x1824FF820
	public void .ctor(string id, ProductMetadata metadata, string receipt, string transactionId) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_storeSpecificId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_storeSpecificId(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ProductMetadata get_metadata() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_metadata(ProductMetadata value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_receipt() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_receipt(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_transactionId() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_transactionId(string value) { }
}

// Namespace: UnityEngine.Purchasing.Extension
public class PurchaseFailureDescription // TypeDefIndex: 17762
{
	// Fields
	[CompilerGenerated]
	private string <productId>k__BackingField; // 0x10
	[CompilerGenerated]
	private PurchaseFailureReason <reason>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <message>k__BackingField; // 0x20

	// Properties
	public string productId { get; set; }
	public PurchaseFailureReason reason { get; set; }
	public string message { get; set; }

	// Methods

	// RVA: 0x17E1FC0 Offset: 0x17E11C0 VA: 0x1817E1FC0
	public void .ctor(string productId, PurchaseFailureReason reason, string message) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_productId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_productId(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public PurchaseFailureReason get_reason() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	private void set_reason(PurchaseFailureReason value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_message() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_message(string value) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17763
{}

// Namespace: Unity.Services.Authentication.Internal
public interface IPlayerId : IServiceComponent // TypeDefIndex: 17764
{
	// Properties
	public abstract string PlayerId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_PlayerId();
}

// Namespace: Unity.Services.Core.Threading.Internal
public interface IUnityThreadUtils : IServiceComponent // TypeDefIndex: 17765
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal interface IDiagnosticsComponentProvider // TypeDefIndex: 17766
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IDiagnosticsFactory : IServiceComponent // TypeDefIndex: 17767
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IMetrics // TypeDefIndex: 17768
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IMetricsFactory : IServiceComponent // TypeDefIndex: 17769
{}

// Namespace: Unity.Services.Core.Scheduler.Internal
public interface IActionScheduler : IServiceComponent // TypeDefIndex: 17770
{}

// Namespace: Unity.Services.Core.Environments.Internal
public interface IEnvironments : IServiceComponent // TypeDefIndex: 17771
{
	// Properties
	public abstract string Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Current();
}

// Namespace: Unity.Services.Core.Device.Internal
public interface IInstallationId : IServiceComponent // TypeDefIndex: 17772
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetOrCreateIdentifier();
}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface ICloudProjectId : IServiceComponent // TypeDefIndex: 17773
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetCloudProjectId();
}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface IExternalUserId : IServiceComponent // TypeDefIndex: 17774
{
	// Properties
	public abstract string UserId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_UserId();
}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface IProjectConfiguration : IServiceComponent // TypeDefIndex: 17775
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetString(string key, string defaultValue);
}

// Namespace: Unity.Services.Core.Analytics.Internal
public interface IAnalyticsStandardEventComponent : IServiceComponent // TypeDefIndex: 17776
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Record(string eventName, IDictionary<string, object> eventParameters, int eventVersion, string packageName);
}

// Namespace: Unity.Services.Core.Analytics.Internal
public interface IAnalyticsUserId : IServiceComponent // TypeDefIndex: 17777
{}

// Namespace: Unity.Services.Core.Internal
internal abstract class AsyncOperationBase : CustomYieldInstruction // TypeDefIndex: 17778
{
	// Properties
	public override bool keepWaiting { get; }
	public abstract bool IsCompleted { get; }

	// Methods

	// RVA: 0x23A0540 Offset: 0x239F740 VA: 0x1823A0540 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsCompleted();
}

// Namespace: Unity.Services.Core.Internal
internal class TaskAsyncOperation : AsyncOperationBase // TypeDefIndex: 17779
{
	// Fields
	internal static TaskScheduler Scheduler; // 0x0
	private Task m_Task; // 0x10

	// Properties
	public override bool IsCompleted { get; }

	// Methods

	// RVA: 0x23A3B50 Offset: 0x23A2D50 VA: 0x1823A3B50 Slot: 9
	public override bool get_IsCompleted() { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x23A3AF0 Offset: 0x23A2CF0 VA: 0x1823A3AF0
	internal static void SetScheduler() { }
}

// Namespace: Unity.Services.Core.Internal
internal static class CoreLogger // TypeDefIndex: 17780
{
	// Methods

	// RVA: 0x23A0A50 Offset: 0x239FC50 VA: 0x1823A0A50
	public static void LogWarning(object message) { }

	// RVA: 0x23A0830 Offset: 0x239FA30 VA: 0x1823A0830
	public static void LogError(object message) { }

	// RVA: 0x23A0900 Offset: 0x239FB00 VA: 0x1823A0900
	public static void LogException(Exception exception) { }
}

// Namespace: Unity.Services.Core.Internal
public class CircularDependencyException : ServicesInitializationException // TypeDefIndex: 17781
{
	// Methods

	// RVA: 0x23A0570 Offset: 0x239F770 VA: 0x1823A0570
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Internal
internal class ComponentRegistry : IComponentRegistry // TypeDefIndex: 17782
{
	// Fields
	[CompilerGenerated]
	private readonly Dictionary<int, IServiceComponent> <ComponentTypeHashToInstance>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal Dictionary<int, IServiceComponent> ComponentTypeHashToInstance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal Dictionary<int, IServiceComponent> get_ComponentTypeHashToInstance() { }

	// RVA: 0x23A06D0 Offset: 0x239F8D0 VA: 0x1823A06D0
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D480 Offset: 0x94C680 VA: 0x18094D480
	|-ComponentRegistry.RegisterServiceComponent<object>
	|
	|-RVA: 0x94D1C0 Offset: 0x94C3C0 VA: 0x18094D1C0
	|-ComponentRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94CFD0 Offset: 0x94C1D0 VA: 0x18094CFD0
	|-ComponentRegistry.GetServiceComponent<object>
	|
	|-RVA: 0x94CDB0 Offset: 0x94BFB0 VA: 0x18094CDB0
	|-ComponentRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23A0580 Offset: 0x239F780 VA: 0x1823A0580
	private bool IsComponentTypeRegistered(int componentTypeHash) { }

	// RVA: 0x23A0660 Offset: 0x239F860 VA: 0x1823A0660 Slot: 6
	public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance) { }
}

// Namespace: Unity.Services.Core.Internal
internal interface IComponentRegistry // TypeDefIndex: 17783
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RegisterServiceComponent<TComponent>(TComponent component);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComponentRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TComponent GetServiceComponent<TComponent>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComponentRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance);
}

// Namespace: Unity.Services.Core.Internal
internal class LockedComponentRegistry : IComponentRegistry // TypeDefIndex: 17784
{
	// Fields
	[CompilerGenerated]
	private readonly IComponentRegistry <Registry>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal IComponentRegistry Registry { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal IComponentRegistry get_Registry() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IComponentRegistry registryToLock) { }

	// RVA: -1 Offset: -1 Slot: 4
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA44AD0 Offset: 0xA43CD0 VA: 0x180A44AD0
	|-LockedComponentRegistry.RegisterServiceComponent<object>
	|-LockedComponentRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA44A00 Offset: 0xA43C00 VA: 0x180A44A00
	|-LockedComponentRegistry.GetServiceComponent<object>
	|
	|-RVA: 0xA448C0 Offset: 0xA43AC0 VA: 0x180A448C0
	|-LockedComponentRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23A38A0 Offset: 0x23A2AA0 VA: 0x1823A38A0 Slot: 6
	public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance) { }
}

// Namespace: Unity.Services.Core.Internal
public sealed class CorePackageRegistry // TypeDefIndex: 17785
{
	// Fields
	[CompilerGenerated]
	private static CorePackageRegistry <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private IPackageRegistry <Registry>k__BackingField; // 0x10

	// Properties
	public static CorePackageRegistry Instance { get; set; }
	internal IPackageRegistry Registry { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23A0E20 Offset: 0x23A0020 VA: 0x1823A0E20
	public static CorePackageRegistry get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x23A0E60 Offset: 0x23A0060 VA: 0x1823A0E60
	internal static void set_Instance(CorePackageRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal IPackageRegistry get_Registry() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_Registry(IPackageRegistry value) { }

	// RVA: 0x23A0C80 Offset: 0x239FE80 VA: 0x1823A0C80
	internal void .ctor() { }

	// RVA: -1 Offset: -1
	public CoreRegistration Register<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94FD40 Offset: 0x94EF40 VA: 0x18094FD40
	|-CorePackageRegistry.Register<object>
	|
	|-RVA: 0x94FC50 Offset: 0x94EE50 VA: 0x18094FC50
	|-CorePackageRegistry.Register<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23A0BD0 Offset: 0x239FDD0 VA: 0x1823A0BD0
	internal void Lock() { }
}

// Namespace: Unity.Services.Core.Internal
[IsReadOnly]
public struct CoreRegistration // TypeDefIndex: 17786
{
	// Fields
	private readonly IPackageRegistry m_Registry; // 0x0
	private readonly int m_PackageHash; // 0x8

	// Methods

	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	internal void .ctor(IPackageRegistry registry, int packageHash) { }

	// RVA: -1 Offset: -1
	public CoreRegistration DependsOn<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94FDC0 Offset: 0x94EFC0 VA: 0x18094FDC0
	|-CoreRegistration.DependsOn<object>
	|-CoreRegistration.DependsOn<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public CoreRegistration OptionallyDependsOn<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94FDC0 Offset: 0x94EFC0 VA: 0x18094FDC0
	|-CoreRegistration.OptionallyDependsOn<object>
	|-CoreRegistration.OptionallyDependsOn<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public CoreRegistration ProvidesComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94FDC0 Offset: 0x94EFC0 VA: 0x18094FDC0
	|-CoreRegistration.ProvidesComponent<object>
	|-CoreRegistration.ProvidesComponent<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Services.Core.Internal
public sealed class CoreRegistry // TypeDefIndex: 17787
{
	// Fields
	[CompilerGenerated]
	private static CoreRegistry <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly string <InstanceId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ServicesType <Type>k__BackingField; // 0x18
	[CompilerGenerated]
	private InitializationOptions <Options>k__BackingField; // 0x20
	[CompilerGenerated]
	private IPackageRegistry <PackageRegistry>k__BackingField; // 0x28
	[CompilerGenerated]
	private IComponentRegistry <ComponentRegistry>k__BackingField; // 0x30
	[CompilerGenerated]
	private IServiceRegistry <ServiceRegistry>k__BackingField; // 0x38

	// Properties
	public static CoreRegistry Instance { get; set; }
	internal ServicesType Type { get; set; }
	internal InitializationOptions Options { get; }
	[NotNull]
	internal IPackageRegistry PackageRegistry { get; set; }
	[NotNull]
	internal IComponentRegistry ComponentRegistry { get; set; }
	[NotNull]
	private IServiceRegistry ServiceRegistry { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23A1170 Offset: 0x23A0370 VA: 0x1823A1170
	public static CoreRegistry get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x23A11B0 Offset: 0x23A03B0 VA: 0x1823A11B0
	internal static void set_Instance(CoreRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	internal ServicesType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	private void set_Type(ServicesType value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal InitializationOptions get_Options() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal IPackageRegistry get_PackageRegistry() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_PackageRegistry(IPackageRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal IComponentRegistry get_ComponentRegistry() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_ComponentRegistry(IComponentRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_ServiceRegistry(IServiceRegistry value) { }

	// RVA: 0x23A1030 Offset: 0x23A0230 VA: 0x1823A1030
	internal void .ctor(IPackageRegistry packageRegistry, ServicesType type = 0, string instanceId) { }

	// RVA: -1 Offset: -1
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x950120 Offset: 0x94F320 VA: 0x180950120
	|-CoreRegistry.RegisterPackage<object>
	|
	|-RVA: 0x950030 Offset: 0x94F230 VA: 0x180950030
	|-CoreRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9502F0 Offset: 0x94F4F0 VA: 0x1809502F0
	|-CoreRegistry.RegisterServiceComponent<object>
	|
	|-RVA: 0x9501A0 Offset: 0x94F3A0 VA: 0x1809501A0
	|-CoreRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94FF60 Offset: 0x94F160 VA: 0x18094FF60
	|-CoreRegistry.GetServiceComponent<object>
	|
	|-RVA: 0x94FE20 Offset: 0x94F020 VA: 0x18094FE20
	|-CoreRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23A0F80 Offset: 0x23A0180 VA: 0x1823A0F80
	internal void LockComponentRegistration() { }
}

// Namespace: 
private struct CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d : IAsyncStateMachine // TypeDefIndex: 17788
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CoreRegistryInitializer.<>c__DisplayClass3_0 <>4__this; // 0x20
	public IInitializablePackage package; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x23A4FB0 Offset: 0x23A41B0 VA: 0x1823A4FB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x23A52B0 Offset: 0x23A44B0 VA: 0x1823A52B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
private struct CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d : IAsyncStateMachine // TypeDefIndex: 17789
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CoreRegistryInitializer.<>c__DisplayClass3_0 <>4__this; // 0x20
	public IInitializablePackage package; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x23A5310 Offset: 0x23A4510 VA: 0x1823A5310 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x23A5730 Offset: 0x23A4930 VA: 0x1823A5730 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CoreRegistryInitializer.<>c__DisplayClass3_0 // TypeDefIndex: 17790
{
	// Fields
	public Stopwatch stopwatch; // 0x10
	public List<PackageInitializationInfo> packagesInitInfos; // 0x18
	public List<Exception> failureReasons; // 0x20
	public CoreRegistryInitializer <>4__this; // 0x28
	public DependencyTree dependencyTree; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[AsyncStateMachine(typeof(CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d))]
	// RVA: 0x23A5F60 Offset: 0x23A5160 VA: 0x1823A5F60
	internal Task <InitializeRegistryAsync>g__TryInitializePackageAsync|0(IInitializablePackage package) { }

	// RVA: 0x23A5E00 Offset: 0x23A5000 VA: 0x1823A5E00
	internal IInitializablePackage <InitializeRegistryAsync>g__GetPackageAt|1(int index) { }

	[AsyncStateMachine(typeof(CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d))]
	// RVA: 0x23A5E90 Offset: 0x23A5090 VA: 0x1823A5E90
	internal Task <InitializeRegistryAsync>g__InitializePackageAsync|2(IInitializablePackage package) { }

	// RVA: 0x23A5D80 Offset: 0x23A4F80 VA: 0x1823A5D80
	internal void <InitializeRegistryAsync>g__Fail|3() { }
}

// Namespace: 
[CompilerGenerated]
private struct CoreRegistryInitializer.<InitializeRegistryAsync>d__3 : IAsyncStateMachine // TypeDefIndex: 17791
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<List<PackageInitializationInfo>> <>t__builder; // 0x8
	public CoreRegistryInitializer <>4__this; // 0x20
	private CoreRegistryInitializer.<>c__DisplayClass3_0 <>8__1; // 0x28
	private int <i>5__2; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x23A41B0 Offset: 0x23A33B0 VA: 0x1823A41B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x23A48B0 Offset: 0x23A3AB0 VA: 0x1823A48B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Unity.Services.Core.Internal
internal class CoreRegistryInitializer // TypeDefIndex: 17792
{
	// Fields
	[NotNull]
	private readonly CoreRegistry m_Registry; // 0x10
	[NotNull]
	private readonly List<int> m_SortedPackageTypeHashes; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(CoreRegistry registry, List<int> sortedPackageTypeHashes) { }

	[AsyncStateMachine(typeof(CoreRegistryInitializer.<InitializeRegistryAsync>d__3))]
	// RVA: 0x23A0EA0 Offset: 0x23A00A0 VA: 0x1823A0EA0
	public Task<List<PackageInitializationInfo>> InitializeRegistryAsync() { }
}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTree // TypeDefIndex: 17793
{
	// Fields
	public readonly Dictionary<int, IInitializablePackage> PackageTypeHashToInstance; // 0x10
	public readonly Dictionary<int, int> ComponentTypeHashToPackageTypeHash; // 0x18
	public readonly Dictionary<int, List<int>> PackageTypeHashToComponentTypeHashDependencies; // 0x20
	public readonly Dictionary<int, IServiceComponent> ComponentTypeHashToInstance; // 0x28

	// Methods

	// RVA: 0x23A3760 Offset: 0x23A2960 VA: 0x1823A3760
	internal void .ctor() { }

	// RVA: 0x1808FD0 Offset: 0x18081D0 VA: 0x181808FD0
	internal void .ctor(Dictionary<int, IInitializablePackage> packageToInstance, Dictionary<int, int> componentToPackage, Dictionary<int, List<int>> packageToComponentDependencies, Dictionary<int, IServiceComponent> componentToInstance) { }
}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreeSortFailedException : Exception // TypeDefIndex: 17794
{
	// Methods

	// RVA: 0x23A3640 Offset: 0x23A2840 VA: 0x1823A3640
	public void .ctor(DependencyTree tree, ICollection<int> target, Exception inner) { }

	// RVA: 0x23A3570 Offset: 0x23A2770 VA: 0x1823A3570
	private static string CreateExceptionMessage(DependencyTree tree, ICollection<int> target, Exception inner) { }
}

// Namespace: Unity.Services.Core.Internal
[Extension]
internal static class DependencyTreeExtensions // TypeDefIndex: 17795
{
	// Methods

	[Extension]
	// RVA: 0x23A20A0 Offset: 0x23A12A0 VA: 0x1823A20A0
	internal static string ToJson(DependencyTree tree, ICollection<int> order) { }

	[Extension]
	// RVA: 0x23A1FC0 Offset: 0x23A11C0 VA: 0x1823A1FC0
	internal static bool IsOptional(DependencyTree tree, int componentTypeHash) { }

	[Extension]
	// RVA: 0x23A2040 Offset: 0x23A1240 VA: 0x1823A2040
	internal static bool IsProvided(DependencyTree tree, int componentTypeHash) { }

	// RVA: 0x23A1790 Offset: 0x23A0990 VA: 0x1823A1790
	private static JObject GetPackageJObject(DependencyTree tree, int packageHash) { }

	// RVA: 0x23A1330 Offset: 0x23A0530 VA: 0x1823A1330
	private static JObject GetComponentJObject(DependencyTree tree, int componentHash) { }

	// RVA: 0x23A1250 Offset: 0x23A0450 VA: 0x1823A1250
	private static string GetComponentIdentifier(IServiceComponent component) { }
}

// Namespace: 
private enum DependencyTreeInitializeOrderSorter.ExplorationMark // TypeDefIndex: 17796
{
	// Fields
	public int value__; // 0x0
	public const DependencyTreeInitializeOrderSorter.ExplorationMark None = 0;
	public const DependencyTreeInitializeOrderSorter.ExplorationMark Viewed = 1;
	public const DependencyTreeInitializeOrderSorter.ExplorationMark Sorted = 2;
}

// Namespace: Unity.Services.Core.Internal
internal struct DependencyTreeInitializeOrderSorter // TypeDefIndex: 17797
{
	// Fields
	public readonly DependencyTree Tree; // 0x0
	public readonly ICollection<int> Target; // 0x8
	private Dictionary<int, DependencyTreeInitializeOrderSorter.ExplorationMark> m_PackageTypeHashExplorationHistory; // 0x10

	// Methods

	// RVA: 0x23A34E0 Offset: 0x23A26E0 VA: 0x1823A34E0
	public void .ctor(DependencyTree tree, ICollection<int> target) { }

	// RVA: 0x23A2D30 Offset: 0x23A1F30 VA: 0x1823A2D30
	public void SortRegisteredPackagesIntoTarget() { }

	// RVA: 0x23A2A20 Offset: 0x23A1C20 VA: 0x1823A2A20
	private void RemoveUnprovidedOptionalDependenciesFromTree() { }

	// RVA: 0x23A2B50 Offset: 0x23A1D50 VA: 0x1823A2B50
	private void RemoveUnprovidedOptionalDependencies(IList<int> dependencyTypeHashes) { }

	// RVA: 0x23A3210 Offset: 0x23A2410 VA: 0x1823A3210
	private void SortTreeThrough(int packageTypeHash) { }

	// RVA: 0x23A3040 Offset: 0x23A2240 VA: 0x1823A3040
	private void SortTreeThrough(IEnumerable<int> dependencyTypeHashes) { }

	// RVA: 0x23A29B0 Offset: 0x23A1BB0 VA: 0x1823A29B0
	private void MarkPackage(int packageTypeHash, DependencyTreeInitializeOrderSorter.ExplorationMark mark) { }

	// RVA: 0x23A2960 Offset: 0x23A1B60 VA: 0x1823A2960
	private IReadOnlyCollection<int> GetPackageTypeHashes() { }

	// RVA: 0x23A2860 Offset: 0x23A1A60 VA: 0x1823A2860
	private int GetPackageTypeHashFor(int componentTypeHash) { }

	// RVA: 0x23A2760 Offset: 0x23A1960 VA: 0x1823A2760
	private IEnumerable<int> GetDependencyTypeHashesFor(int packageTypeHash) { }
}

// Namespace: Unity.Services.Core.Internal
internal class HashException : Exception // TypeDefIndex: 17798
{
	// Fields
	[CompilerGenerated]
	private readonly int <Hash>k__BackingField; // 0x90

	// Properties
	public int Hash { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210
	public int get_Hash() { }

	// RVA: 0x23A11F0 Offset: 0x23A03F0 VA: 0x1823A11F0
	public void .ctor(int hash, string message) { }

	// RVA: 0x23A34F0 Offset: 0x23A26F0 VA: 0x1823A34F0
	public void .ctor(int hash, string message, Exception inner) { }
}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreePackageHashException : HashException // TypeDefIndex: 17799
{
	// Methods

	// RVA: 0x23A11F0 Offset: 0x23A03F0 VA: 0x1823A11F0
	public void .ctor(int hash, string message) { }

	// RVA: 0x23A34F0 Offset: 0x23A26F0 VA: 0x1823A34F0
	public void .ctor(int hash, string message, Exception inner) { }
}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreeComponentHashException : HashException // TypeDefIndex: 17800
{
	// Methods

	// RVA: 0x23A11F0 Offset: 0x23A03F0 VA: 0x1823A11F0
	public void .ctor(int hash, string message) { }
}

// Namespace: Unity.Services.Core.Internal
public interface IInitializablePackage // TypeDefIndex: 17801
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task Initialize(CoreRegistry registry);
}

// Namespace: Unity.Services.Core.Internal
public interface IInitializablePackageV2 : IInitializablePackage // TypeDefIndex: 17802
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task InitializeInstanceAsync(CoreRegistry registry);
}

// Namespace: Unity.Services.Core.Internal
public interface IServiceComponent // TypeDefIndex: 17803
{}

// Namespace: Unity.Services.Core.Internal
internal class MissingComponent : IServiceComponent // TypeDefIndex: 17804
{
	// Fields
	[CompilerGenerated]
	private readonly Type <IntendedType>k__BackingField; // 0x10

	// Properties
	public Type IntendedType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Type get_IntendedType() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(Type intendedType) { }
}

// Namespace: Unity.Services.Core.Internal
internal class PackageInitializationInfo // TypeDefIndex: 17805
{
	// Fields
	public Type PackageType; // 0x10
	public double InitializationTimeInSeconds; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Internal
internal interface IPackageRegistry // TypeDefIndex: 17806
{
	// Properties
	[CanBeNull]
	public abstract DependencyTree Tree { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DependencyTree get_Tree();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract CoreRegistration RegisterPackage<TPackage>(TPackage package);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RegisterDependency<TComponent>(int packageTypeHash);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void RegisterOptionalDependency<TComponent>(int packageTypeHash);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterOptionalDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RegisterProvision<TComponent>(int packageTypeHash);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterProvision<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Services.Core.Internal
internal class LockedPackageRegistry : IPackageRegistry // TypeDefIndex: 17807
{
	// Fields
	[CompilerGenerated]
	private readonly IPackageRegistry <Registry>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal IPackageRegistry Registry { get; }
	public DependencyTree Tree { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal IPackageRegistry get_Registry() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IPackageRegistry registryToLock) { }

	// RVA: 0x23A38F0 Offset: 0x23A2AF0 VA: 0x1823A38F0 Slot: 4
	public DependencyTree get_Tree() { }

	// RVA: -1 Offset: -1 Slot: 5
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA44B70 Offset: 0xA43D70 VA: 0x180A44B70
	|-LockedPackageRegistry.RegisterPackage<object>
	|-LockedPackageRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void RegisterDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA44B20 Offset: 0xA43D20 VA: 0x180A44B20
	|-LockedPackageRegistry.RegisterDependency<object>
	|-LockedPackageRegistry.RegisterDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void RegisterOptionalDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA44B20 Offset: 0xA43D20 VA: 0x180A44B20
	|-LockedPackageRegistry.RegisterOptionalDependency<object>
	|-LockedPackageRegistry.RegisterOptionalDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RegisterProvision<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA44B20 Offset: 0xA43D20 VA: 0x180A44B20
	|-LockedPackageRegistry.RegisterProvision<object>
	|-LockedPackageRegistry.RegisterProvision<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Services.Core.Internal
internal class PackageRegistry : IPackageRegistry // TypeDefIndex: 17808
{
	// Fields
	[CompilerGenerated]
	private DependencyTree <Tree>k__BackingField; // 0x10

	// Properties
	public DependencyTree Tree { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public DependencyTree get_Tree() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 9
	public void set_Tree(DependencyTree value) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(DependencyTree tree) { }

	// RVA: -1 Offset: -1 Slot: 5
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59AA0 Offset: 0xA58CA0 VA: 0x180A59AA0
	|-PackageRegistry.RegisterPackage<object>
	|
	|-RVA: 0xA598C0 Offset: 0xA58AC0 VA: 0x180A598C0
	|-PackageRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void RegisterDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59690 Offset: 0xA58890 VA: 0x180A59690
	|-PackageRegistry.RegisterDependency<object>
	|-PackageRegistry.RegisterDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void RegisterOptionalDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA597B0 Offset: 0xA589B0 VA: 0x180A597B0
	|-PackageRegistry.RegisterOptionalDependency<object>
	|-PackageRegistry.RegisterOptionalDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RegisterProvision<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59C10 Offset: 0xA58E10 VA: 0x180A59C10
	|-PackageRegistry.RegisterProvision<object>
	|-PackageRegistry.RegisterProvision<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23A3980 Offset: 0x23A2B80 VA: 0x1823A3980
	private void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash) { }
}

// Namespace: Unity.Services.Core.Internal
internal interface IServiceRegistry // TypeDefIndex: 17809
{}

// Namespace: Unity.Services.Core.Internal
internal class ServiceRegistry : IServiceRegistry // TypeDefIndex: 17810
{
	// Fields
	[CompilerGenerated]
	private readonly Dictionary<int, object> <ServiceTypeHashToInstance>k__BackingField; // 0x10

	// Methods

	// RVA: 0x23A3A80 Offset: 0x23A2C80 VA: 0x1823A3A80
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Internal
internal class CoreDiagnostics // TypeDefIndex: 17811
{
	// Fields
	[CompilerGenerated]
	private static CoreDiagnostics <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly IDictionary<string, string> <CoreTags>k__BackingField; // 0x10
	[CompilerGenerated]
	private IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField; // 0x18

	// Properties
	public static CoreDiagnostics Instance { get; set; }
	internal IDiagnosticsComponentProvider DiagnosticsComponentProvider { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23A07B0 Offset: 0x239F9B0 VA: 0x1823A07B0
	public static CoreDiagnostics get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x23A07F0 Offset: 0x239F9F0 VA: 0x1823A07F0
	internal static void set_Instance(CoreDiagnostics value) { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_DiagnosticsComponentProvider(IDiagnosticsComponentProvider value) { }

	// RVA: 0x23A0740 Offset: 0x239F940 VA: 0x1823A0740
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Internal
internal class CoreMetrics // TypeDefIndex: 17812
{
	// Fields
	[CompilerGenerated]
	private static CoreMetrics <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly IDictionary<Type, IMetrics> <AllPackageMetrics>k__BackingField; // 0x10

	// Properties
	internal static CoreMetrics Instance { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23A0B90 Offset: 0x239FD90 VA: 0x1823A0B90
	internal static void set_Instance(CoreMetrics value) { }

	// RVA: 0x23A0B20 Offset: 0x239FD20 VA: 0x1823A0B20
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct UnityServicesInitializer.<EnableServicesInitializationAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 17813
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x23A3EE0 Offset: 0x23A30E0 VA: 0x1823A3EE0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x71F7C0 Offset: 0x71E9C0 VA: 0x18071F7C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Unity.Services.Core.Internal
internal static class UnityServicesInitializer // TypeDefIndex: 17814
{
	// Methods

	[RuntimeInitializeOnLoadMethod(2)]
	// RVA: 0x23A6030 Offset: 0x23A5230 VA: 0x1823A6030
	private static void CreateStaticInstance() { }

	[AsyncStateMachine(typeof(UnityServicesInitializer.<EnableServicesInitializationAsync>d__1))]
	[RuntimeInitializeOnLoadMethod(0)]
	// RVA: 0x23A65B0 Offset: 0x23A57B0 VA: 0x1823A65B0
	private static void EnableServicesInitializationAsync() { }
}

// Namespace: 
private struct UnityServicesInternal.<>c__DisplayClass22_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d : IAsyncStateMachine // TypeDefIndex: 17815
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public UnityServicesInternal.<>c__DisplayClass22_0 <>4__this; // 0x20
	private TaskAwaiter<List<PackageInitializationInfo>> <>u__1; // 0x28

	// Methods

	// RVA: 0x23A5790 Offset: 0x23A4990 VA: 0x1823A5790 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x23A5A70 Offset: 0x23A4C70 VA: 0x1823A5A70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityServicesInternal.<>c__DisplayClass22_0 // TypeDefIndex: 17816
{
	// Fields
	public DependencyTree dependencyTree; // 0x10
	public List<int> sortedPackageTypeHashes; // 0x18
	public UnityServicesInternal <>4__this; // 0x20
	public Stopwatch initStopwatch; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23A5C10 Offset: 0x23A4E10 VA: 0x1823A5C10
	internal void <InitializeServicesAsync>g__SortPackages|0() { }

	[AsyncStateMachine(typeof(UnityServicesInternal.<>c__DisplayClass22_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d))]
	// RVA: 0x23A5B50 Offset: 0x23A4D50 VA: 0x1823A5B50
	internal Task <InitializeServicesAsync>g__InitializePackagesAsync|1() { }

	// RVA: 0x23A5AD0 Offset: 0x23A4CD0 VA: 0x1823A5AD0
	internal void <InitializeServicesAsync>g__FailServicesInitialization|2(Exception reason) { }

	// RVA: 0x23A5C40 Offset: 0x23A4E40 VA: 0x1823A5C40
	internal void <InitializeServicesAsync>g__SucceedServicesInitialization|3() { }
}

// Namespace: 
[CompilerGenerated]
private struct UnityServicesInternal.<EnableInitializationAsync>d__25 : IAsyncStateMachine // TypeDefIndex: 17817
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public UnityServicesInternal <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x23A3B70 Offset: 0x23A2D70 VA: 0x1823A3B70 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x23A3E80 Offset: 0x23A3080 VA: 0x1823A3E80 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct UnityServicesInternal.<InitializeServicesAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 17818
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public UnityServicesInternal <>4__this; // 0x20
	private UnityServicesInternal.<>c__DisplayClass22_0 <>8__1; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x23A4920 Offset: 0x23A3B20 VA: 0x1823A4920 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x23A4F50 Offset: 0x23A4150 VA: 0x1823A4F50 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Unity.Services.Core.Internal
internal class UnityServicesInternal : IUnityServices // TypeDefIndex: 17819
{
	// Fields
	[CompilerGenerated]
	private ServicesInitializationState <State>k__BackingField; // 0x10
	internal bool CanInitialize; // 0x14
	private TaskCompletionSource<object> m_Initialization; // 0x18
	[CompilerGenerated]
	private readonly CoreRegistry <Registry>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly CoreMetrics <Metrics>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly CoreDiagnostics <Diagnostics>k__BackingField; // 0x30

	// Properties
	public ServicesInitializationState State { get; set; }
	[NotNull]
	internal CoreRegistry Registry { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 4
	public ServicesInitializationState get_State() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	private void set_State(ServicesInitializationState value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal CoreRegistry get_Registry() { }

	// RVA: 0x23A67C0 Offset: 0x23A59C0 VA: 0x1823A67C0
	public void .ctor(CoreRegistry registry, CoreMetrics coreMetrics, CoreDiagnostics coreDiagnostics) { }

	// RVA: 0x23A66F0 Offset: 0x23A58F0 VA: 0x1823A66F0
	private bool HasRequestedInitialization() { }

	[AsyncStateMachine(typeof(UnityServicesInternal.<InitializeServicesAsync>d__22))]
	// RVA: 0x23A6700 Offset: 0x23A5900 VA: 0x1823A6700
	private Task InitializeServicesAsync() { }

	[AsyncStateMachine(typeof(UnityServicesInternal.<EnableInitializationAsync>d__25))]
	// RVA: 0x23A6630 Offset: 0x23A5830 VA: 0x1823A6630
	internal Task EnableInitializationAsync() { }
}

// Namespace: Unity.Services.Core.Internal
[Extension]
internal static class DictionaryExtensions // TypeDefIndex: 17820
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(TDictionary self, IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x964890 Offset: 0x963A90 VA: 0x180964890
	|-DictionaryExtensions.MergeAllowOverride<object, int, object>
	|
	|-RVA: 0x964410 Offset: 0x963610 VA: 0x180964410
	|-DictionaryExtensions.MergeAllowOverride<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ValueEquals<TKey, TValue>(IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9653F0 Offset: 0x9645F0 VA: 0x1809653F0
	|-DictionaryExtensions.ValueEquals<object, object>
	|
	|-RVA: 0x965000 Offset: 0x964200 VA: 0x180965000
	|-DictionaryExtensions.ValueEquals<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ValueEquals<TKey, TValue, TComparer>(IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y, TComparer valueComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x965080 Offset: 0x964280 VA: 0x180965080
	|-DictionaryExtensions.ValueEquals<object, object, object>
	|
	|-RVA: 0x964B30 Offset: 0x963D30 VA: 0x180964B30
	|-DictionaryExtensions.ValueEquals<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Services.Core.Internal.Serialization
internal interface IJsonSerializer // TypeDefIndex: 17821
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T DeserializeObject<T>(string value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IJsonSerializer.DeserializeObject<__Il2CppFullySharedGenericType>
	|-IJsonSerializer.DeserializeObject<SerializableProjectConfiguration>
	*/
}

// Namespace: Unity.Services.Core.Internal.Serialization
internal class NewtonsoftSerializer : IJsonSerializer // TypeDefIndex: 17822
{
	// Fields
	private readonly JsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x23A3940 Offset: 0x23A2B40 VA: 0x1823A3940
	public void .ctor(JsonSerializerSettings settings) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(JsonSerializer serializer) { }

	// RVA: -1 Offset: -1 Slot: 4
	public T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA55C40 Offset: 0xA54E40 VA: 0x180A55C40
	|-NewtonsoftSerializer.DeserializeObject<SerializableProjectConfiguration>
	|
	|-RVA: 0xA559E0 Offset: 0xA54BE0 VA: 0x180A559E0
	|-NewtonsoftSerializer.DeserializeObject<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17823
{}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public struct FaceInfo // TypeDefIndex: 17824
{
	// Fields
	[SerializeField]
	[NativeName("faceIndex")]
	private int m_FaceIndex; // 0x0
	[SerializeField]
	[NativeName("familyName")]
	private string m_FamilyName; // 0x8
	[SerializeField]
	[NativeName("styleName")]
	private string m_StyleName; // 0x10
	[SerializeField]
	[NativeName("pointSize")]
	private int m_PointSize; // 0x18
	[NativeName("scale")]
	[SerializeField]
	private float m_Scale; // 0x1C
	[SerializeField]
	[NativeName("unitsPerEM")]
	private int m_UnitsPerEM; // 0x20
	[NativeName("lineHeight")]
	[SerializeField]
	private float m_LineHeight; // 0x24
	[NativeName("ascentLine")]
	[SerializeField]
	private float m_AscentLine; // 0x28
	[NativeName("capLine")]
	[SerializeField]
	private float m_CapLine; // 0x2C
	[SerializeField]
	[NativeName("meanLine")]
	private float m_MeanLine; // 0x30
	[NativeName("baseline")]
	[SerializeField]
	private float m_Baseline; // 0x34
	[SerializeField]
	[NativeName("descentLine")]
	private float m_DescentLine; // 0x38
	[NativeName("superscriptOffset")]
	[SerializeField]
	private float m_SuperscriptOffset; // 0x3C
	[SerializeField]
	[NativeName("superscriptSize")]
	private float m_SuperscriptSize; // 0x40
	[NativeName("subscriptOffset")]
	[SerializeField]
	private float m_SubscriptOffset; // 0x44
	[SerializeField]
	[NativeName("subscriptSize")]
	private float m_SubscriptSize; // 0x48
	[NativeName("underlineOffset")]
	[SerializeField]
	private float m_UnderlineOffset; // 0x4C
	[SerializeField]
	[NativeName("underlineThickness")]
	private float m_UnderlineThickness; // 0x50
	[SerializeField]
	[NativeName("strikethroughOffset")]
	private float m_StrikethroughOffset; // 0x54
	[NativeName("strikethroughThickness")]
	[SerializeField]
	private float m_StrikethroughThickness; // 0x58
	[NativeName("tabWidth")]
	[SerializeField]
	private float m_TabWidth; // 0x5C

	// Properties
	internal int faceIndex { get; }
	public string familyName { get; set; }
	public string styleName { get; set; }
	public int pointSize { get; set; }
	public float scale { get; set; }
	public float lineHeight { get; set; }
	public float ascentLine { get; set; }
	public float capLine { get; set; }
	public float meanLine { get; set; }
	public float baseline { get; set; }
	public float descentLine { get; set; }
	public float superscriptOffset { get; set; }
	public float superscriptSize { get; set; }
	public float subscriptOffset { get; set; }
	public float subscriptSize { get; set; }
	public float underlineOffset { get; set; }
	public float underlineThickness { get; set; }
	public float strikethroughOffset { get; set; }
	public float strikethroughThickness { set; }
	public float tabWidth { get; set; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	internal int get_faceIndex() { }

	// RVA: 0x1808BB0 Offset: 0x1807DB0 VA: 0x181808BB0
	public string get_familyName() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_familyName(string value) { }

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	public string get_styleName() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_styleName(string value) { }

	// RVA: 0xB78A40 Offset: 0xB77C40 VA: 0x180B78A40
	public int get_pointSize() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_pointSize(int value) { }

	// RVA: 0x24E28C0 Offset: 0x24E1AC0 VA: 0x1824E28C0
	public float get_scale() { }

	// RVA: 0x498F80 Offset: 0x498180 VA: 0x180498F80
	public void set_scale(float value) { }

	// RVA: 0x248C1F0 Offset: 0x248B3F0 VA: 0x18248C1F0
	public float get_lineHeight() { }

	// RVA: 0x499000 Offset: 0x498200 VA: 0x180499000
	public void set_lineHeight(float value) { }

	// RVA: 0x2507510 Offset: 0x2506710 VA: 0x182507510
	public float get_ascentLine() { }

	// RVA: 0x484EB0 Offset: 0x4840B0 VA: 0x180484EB0
	public void set_ascentLine(float value) { }

	// RVA: 0x24E2910 Offset: 0x24E1B10 VA: 0x1824E2910
	public float get_capLine() { }

	// RVA: 0x498F90 Offset: 0x498190 VA: 0x180498F90
	public void set_capLine(float value) { }

	// RVA: 0x24E28D0 Offset: 0x24E1AD0 VA: 0x1824E28D0
	public float get_meanLine() { }

	// RVA: 0x499010 Offset: 0x498210 VA: 0x180499010
	public void set_meanLine(float value) { }

	// RVA: 0x24E2920 Offset: 0x24E1B20 VA: 0x1824E2920
	public float get_baseline() { }

	// RVA: 0x11FB200 Offset: 0x11FA400 VA: 0x1811FB200
	public void set_baseline(float value) { }

	// RVA: 0x23C4420 Offset: 0x23C3620 VA: 0x1823C4420
	public float get_descentLine() { }

	// RVA: 0x2507580 Offset: 0x2506780 VA: 0x182507580
	public void set_descentLine(float value) { }

	// RVA: 0x23C42B0 Offset: 0x23C34B0 VA: 0x1823C42B0
	public float get_superscriptOffset() { }

	// RVA: 0x5D0200 Offset: 0x5CF400 VA: 0x1805D0200
	public void set_superscriptOffset(float value) { }

	// RVA: 0x24E2890 Offset: 0x24E1A90 VA: 0x1824E2890
	public float get_superscriptSize() { }

	// RVA: 0xCDEA70 Offset: 0xCDDC70 VA: 0x180CDEA70
	public void set_superscriptSize(float value) { }

	// RVA: 0x2507530 Offset: 0x2506730 VA: 0x182507530
	public float get_subscriptOffset() { }

	// RVA: 0x25075A0 Offset: 0x25067A0 VA: 0x1825075A0
	public void set_subscriptOffset(float value) { }

	// RVA: 0x2507540 Offset: 0x2506740 VA: 0x182507540
	public float get_subscriptSize() { }

	// RVA: 0x5269B0 Offset: 0x525BB0 VA: 0x1805269B0
	public void set_subscriptSize(float value) { }

	// RVA: 0x2507560 Offset: 0x2506760 VA: 0x182507560
	public float get_underlineOffset() { }

	// RVA: 0x526A20 Offset: 0x525C20 VA: 0x180526A20
	public void set_underlineOffset(float value) { }

	// RVA: 0x2507570 Offset: 0x2506770 VA: 0x182507570
	public float get_underlineThickness() { }

	// RVA: 0x646080 Offset: 0x645280 VA: 0x180646080
	public void set_underlineThickness(float value) { }

	// RVA: 0x2507520 Offset: 0x2506720 VA: 0x182507520
	public float get_strikethroughOffset() { }

	// RVA: 0x24258C0 Offset: 0x2424AC0 VA: 0x1824258C0
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x2507590 Offset: 0x2506790 VA: 0x182507590
	public void set_strikethroughThickness(float value) { }

	// RVA: 0x2507550 Offset: 0x2506750 VA: 0x182507550
	public float get_tabWidth() { }

	// RVA: 0x25075B0 Offset: 0x25067B0 VA: 0x1825075B0
	public void set_tabWidth(float value) { }
}

// Namespace: UnityEngine.TextCore
public enum GlyphClassDefinitionType // TypeDefIndex: 17825
{
	// Fields
	public int value__; // 0x0
	public const GlyphClassDefinitionType Undefined = 0;
	public const GlyphClassDefinitionType Base = 1;
	public const GlyphClassDefinitionType Ligature = 2;
	public const GlyphClassDefinitionType Mark = 3;
	public const GlyphClassDefinitionType Component = 4;
}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 17826
{
	// Fields
	[SerializeField]
	[NativeName("x")]
	private int m_X; // 0x0
	[SerializeField]
	[NativeName("y")]
	private int m_Y; // 0x4
	[NativeName("width")]
	[SerializeField]
	private int m_Width; // 0x8
	[SerializeField]
	[NativeName("height")]
	private int m_Height; // 0xC
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int width { get; set; }
	public int height { get; set; }
	public static GlyphRect zero { get; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public int get_x() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_x(int value) { }

	// RVA: 0xC45280 Offset: 0xC44480 VA: 0x180C45280
	public int get_y() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_y(int value) { }

	// RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000
	public int get_width() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_width(int value) { }

	// RVA: 0x1483110 Offset: 0x1482310 VA: 0x181483110
	public int get_height() { }

	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_height(int value) { }

	// RVA: 0x2509C10 Offset: 0x2508E10 VA: 0x182509C10
	public static GlyphRect get_zero() { }

	// RVA: 0xD4CCD0 Offset: 0xD4BED0 VA: 0x180D4CCD0
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x2509B80 Offset: 0x2508D80 VA: 0x182509B80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2509B20 Offset: 0x2508D20 VA: 0x182509B20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2509AA0 Offset: 0x2508CA0 VA: 0x182509AA0 Slot: 4
	public bool Equals(GlyphRect other) { }

	// RVA: 0x2509BD0 Offset: 0x2508DD0 VA: 0x182509BD0
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 17827
{
	// Fields
	[SerializeField]
	[NativeName("width")]
	private float m_Width; // 0x0
	[NativeName("height")]
	[SerializeField]
	private float m_Height; // 0x4
	[NativeName("horizontalBearingX")]
	[SerializeField]
	private float m_HorizontalBearingX; // 0x8
	[SerializeField]
	[NativeName("horizontalBearingY")]
	private float m_HorizontalBearingY; // 0xC
	[SerializeField]
	[NativeName("horizontalAdvance")]
	private float m_HorizontalAdvance; // 0x10

	// Properties
	public float width { get; set; }
	public float height { get; set; }
	public float horizontalBearingX { get; set; }
	public float horizontalBearingY { get; set; }
	public float horizontalAdvance { get; set; }

	// Methods

	// RVA: 0x758EB0 Offset: 0x7580B0 VA: 0x180758EB0
	public float get_width() { }

	// RVA: 0x439FD0 Offset: 0x4391D0 VA: 0x180439FD0
	public void set_width(float value) { }

	// RVA: 0x758EC0 Offset: 0x7580C0 VA: 0x180758EC0
	public float get_height() { }

	// RVA: 0x439FE0 Offset: 0x4391E0 VA: 0x180439FE0
	public void set_height(float value) { }

	// RVA: 0x576F00 Offset: 0x576100 VA: 0x180576F00
	public float get_horizontalBearingX() { }

	// RVA: 0x439FF0 Offset: 0x4391F0 VA: 0x180439FF0
	public void set_horizontalBearingX(float value) { }

	// RVA: 0x576EF0 Offset: 0x5760F0 VA: 0x180576EF0
	public float get_horizontalBearingY() { }

	// RVA: 0x52C5B0 Offset: 0x52B7B0 VA: 0x18052C5B0
	public void set_horizontalBearingY(float value) { }

	// RVA: 0x25098B0 Offset: 0x2508AB0 VA: 0x1825098B0
	public float get_horizontalAdvance() { }

	// RVA: 0x482DD0 Offset: 0x481FD0 VA: 0x180482DD0
	public void set_horizontalAdvance(float value) { }

	// RVA: 0x2509880 Offset: 0x2508A80 VA: 0x182509880
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x2509820 Offset: 0x2508A20 VA: 0x182509820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x25097B0 Offset: 0x25089B0 VA: 0x1825097B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2509720 Offset: 0x2508920 VA: 0x182509720 Slot: 4
	public bool Equals(GlyphMetrics other) { }
}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public class Glyph // TypeDefIndex: 17828
{
	// Fields
	[SerializeField]
	[NativeName("index")]
	private uint m_Index; // 0x10
	[NativeName("metrics")]
	[SerializeField]
	private GlyphMetrics m_Metrics; // 0x14
	[NativeName("glyphRect")]
	[SerializeField]
	private GlyphRect m_GlyphRect; // 0x28
	[SerializeField]
	[NativeName("scale")]
	private float m_Scale; // 0x38
	[NativeName("atlasIndex")]
	[SerializeField]
	private int m_AtlasIndex; // 0x3C
	[SerializeField]
	[NativeName("type")]
	private GlyphClassDefinitionType m_ClassDefinitionType; // 0x40

	// Properties
	public uint index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public float scale { get; set; }
	public int atlasIndex { get; set; }

	// Methods

	// RVA: 0x24765D0 Offset: 0x24757D0 VA: 0x1824765D0
	public uint get_index() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_index(uint value) { }

	// RVA: 0x2509A80 Offset: 0x2508C80 VA: 0x182509A80
	public GlyphMetrics get_metrics() { }

	// RVA: 0x2509ED0 Offset: 0x25090D0 VA: 0x182509ED0
	public void set_metrics(GlyphMetrics value) { }

	// RVA: 0x24E3DC0 Offset: 0x24E2FC0 VA: 0x1824E3DC0
	public GlyphRect get_glyphRect() { }

	// RVA: 0x3F6CA0 Offset: 0x3F5EA0 VA: 0x1803F6CA0
	public void set_glyphRect(GlyphRect value) { }

	// RVA: 0x23C4420 Offset: 0x23C3620 VA: 0x1823C4420
	public float get_scale() { }

	// RVA: 0x2507580 Offset: 0x2506780 VA: 0x182507580
	public void set_scale(float value) { }

	// RVA: 0x2509EC0 Offset: 0x25090C0 VA: 0x182509EC0
	public int get_atlasIndex() { }

	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70
	public void set_atlasIndex(int value) { }

	// RVA: 0x2509E80 Offset: 0x2509080 VA: 0x182509E80
	public void .ctor() { }

	// RVA: 0x2509DC0 Offset: 0x2508FC0 VA: 0x182509DC0
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x2509E10 Offset: 0x2509010 VA: 0x182509E10
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Flags]
public enum GlyphLoadFlags // TypeDefIndex: 17829
{
	// Fields
	public int value__; // 0x0
	public const GlyphLoadFlags LOAD_DEFAULT = 0;
	public const GlyphLoadFlags LOAD_NO_SCALE = 1;
	public const GlyphLoadFlags LOAD_NO_HINTING = 2;
	public const GlyphLoadFlags LOAD_RENDER = 4;
	public const GlyphLoadFlags LOAD_NO_BITMAP = 8;
	public const GlyphLoadFlags LOAD_FORCE_AUTOHINT = 32;
	public const GlyphLoadFlags LOAD_MONOCHROME = 4096;
	public const GlyphLoadFlags LOAD_NO_AUTOHINT = 32768;
	public const GlyphLoadFlags LOAD_COLOR = 1048576;
	public const GlyphLoadFlags LOAD_COMPUTE_METRICS = 2097152;
	public const GlyphLoadFlags LOAD_BITMAP_METRICS_ONLY = 4194304;
}

// Namespace: UnityEngine.TextCore.LowLevel
public enum FontEngineError // TypeDefIndex: 17830
{
	// Fields
	public int value__; // 0x0
	public const FontEngineError Success = 0;
	public const FontEngineError Invalid_File_Path = 1;
	public const FontEngineError Invalid_File_Format = 2;
	public const FontEngineError Invalid_File_Structure = 3;
	public const FontEngineError Invalid_File = 4;
	public const FontEngineError Invalid_Table = 8;
	public const FontEngineError Invalid_Glyph_Index = 16;
	public const FontEngineError Invalid_Character_Code = 17;
	public const FontEngineError Invalid_Pixel_Size = 23;
	public const FontEngineError Invalid_Library = 33;
	public const FontEngineError Invalid_Face = 35;
	public const FontEngineError Invalid_Library_or_Face = 41;
	public const FontEngineError Atlas_Generation_Cancelled = 100;
	public const FontEngineError Invalid_SharedTextureData = 101;
	public const FontEngineError OpenTypeLayoutLookup_Mismatch = 116;
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
public enum GlyphRenderMode // TypeDefIndex: 17831
{
	// Fields
	public int value__; // 0x0
	public const GlyphRenderMode SMOOTH_HINTED = 4121;
	public const GlyphRenderMode SMOOTH = 4117;
	public const GlyphRenderMode COLOR_HINTED = 69656;
	public const GlyphRenderMode COLOR = 69652;
	public const GlyphRenderMode RASTER_HINTED = 4122;
	public const GlyphRenderMode RASTER = 4118;
	public const GlyphRenderMode SDF = 4134;
	public const GlyphRenderMode SDF8 = 8230;
	public const GlyphRenderMode SDF16 = 16422;
	public const GlyphRenderMode SDF32 = 32806;
	public const GlyphRenderMode SDFAA_HINTED = 4169;
	public const GlyphRenderMode SDFAA = 4165;
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
public enum GlyphPackingMode // TypeDefIndex: 17832
{
	// Fields
	public int value__; // 0x0
	public const GlyphPackingMode BestShortSideFit = 0;
	public const GlyphPackingMode BestLongSideFit = 1;
	public const GlyphPackingMode BestAreaFit = 2;
	public const GlyphPackingMode BottomLeftRule = 3;
	public const GlyphPackingMode ContactPointRule = 4;
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[DebuggerDisplay("{familyName} - {styleName}")]
internal struct FontReference // TypeDefIndex: 17833
{
	// Fields
	public string familyName; // 0x0
	public string styleName; // 0x8
	public int faceIndex; // 0x10
	public string filePath; // 0x18
}

// Namespace: UnityEngine.TextCore.LowLevel
[NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
public sealed class FontEngine // TypeDefIndex: 17834
{
	// Fields
	private static Glyph[] s_Glyphs; // 0x0
	private static uint[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
	private static Dictionary<uint, Glyph> s_GlyphLookupDictionary; // 0x38

	// Methods

	// RVA: 0x2507AB0 Offset: 0x2506CB0 VA: 0x182507AB0
	public static FontEngineError InitializeFontEngine() { }

	[NativeMethod(Name = "TextCore::FontEngine::InitFontEngine", IsFreeFunction = True)]
	// RVA: 0x2507A80 Offset: 0x2506C80 VA: 0x182507A80
	private static int InitializeFontEngine_Internal() { }

	// RVA: 0x2507D60 Offset: 0x2506F60 VA: 0x182507D60
	public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x2507B10 Offset: 0x2506D10 VA: 0x182507B10
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x2507CE0 Offset: 0x2506EE0 VA: 0x182507CE0
	public static FontEngineError LoadFontFace(Font font, int pointSize) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x2507B60 Offset: 0x2506D60 VA: 0x182507B60
	private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize) { }

	// RVA: 0x2507C50 Offset: 0x2506E50 VA: 0x182507C50
	public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x2507BA0 Offset: 0x2506DA0 VA: 0x182507BA0
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x2507DF0 Offset: 0x2506FF0 VA: 0x182507DF0
	public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x2507BF0 Offset: 0x2506DF0 VA: 0x182507BF0
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	// RVA: 0x25093D0 Offset: 0x25085D0 VA: 0x1825093D0
	internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2509370 Offset: 0x2508570 VA: 0x182509370
	private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef) { }

	// RVA: 0x2507620 Offset: 0x2506820 VA: 0x182507620
	public static FaceInfo GetFaceInfo() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x25075E0 Offset: 0x25067E0 VA: 0x1825075E0
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2507700 Offset: 0x2506900 VA: 0x182507700
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x25091F0 Offset: 0x25083F0 VA: 0x1825091F0
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x25091A0 Offset: 0x25083A0 VA: 0x1825091A0
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x2509020 Offset: 0x2508220 VA: 0x182509020
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2508FD0 Offset: 0x25081D0 VA: 0x182508FD0
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	[NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2507F10 Offset: 0x2507110 VA: 0x182507F10
	internal static void SetTextureUploadMode(bool shouldUploadImmediately) { }

	// RVA: 0x2507FC0 Offset: 0x25071C0 VA: 0x182507FC0
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2507F50 Offset: 0x2507150 VA: 0x182507F50
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x2508620 Offset: 0x2507820 VA: 0x182508620
	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x25085B0 Offset: 0x25077B0 VA: 0x1825085B0
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	// RVA: 0x25078E0 Offset: 0x2506AE0 VA: 0x1825078E0
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	// RVA: 0x2507740 Offset: 0x2506940 VA: 0x182507740
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(List<uint> glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = True)]
	// RVA: 0x2507E80 Offset: 0x2507080 VA: 0x182507E80
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x2507A40 Offset: 0x2506C40 VA: 0x182507A40
	private static int GetPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	// RVA: -1 Offset: -1
	private static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AD970 Offset: 0x9ACB70 VA: 0x1809AD970
	|-FontEngine.GenericListToMarshallingArray<uint>
	|
	|-RVA: 0x9AD720 Offset: 0x9AC920 VA: 0x1809AD720
	|-FontEngine.GenericListToMarshallingArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9ADAB0 Offset: 0x9ACCB0 VA: 0x1809ADAB0
	|-FontEngine.SetMarshallingArraySize<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x9ADB50 Offset: 0x9ACD50 VA: 0x1809ADB50
	|-FontEngine.SetMarshallingArraySize<__Il2CppFullySharedGenericType>
	*/

	[NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = True)]
	// RVA: 0x2507ED0 Offset: 0x25070D0 VA: 0x182507ED0
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x2509460 Offset: 0x2508660 VA: 0x182509460
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct FontEngineUtilities // TypeDefIndex: 17835
{
	// Methods

	// RVA: 0x25075C0 Offset: 0x25067C0 VA: 0x1825075C0
	internal static int MaxValue(int a, int b, int c) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
internal struct GlyphMarshallingStruct // TypeDefIndex: 17836
{
	// Fields
	public uint index; // 0x0
	public GlyphMetrics metrics; // 0x4
	public GlyphRect glyphRect; // 0x18
	public float scale; // 0x28
	public int atlasIndex; // 0x2C
	public GlyphClassDefinitionType classDefinitionType; // 0x30
}

// Namespace: UnityEngine.TextCore.LowLevel
[Flags]
public enum FontFeatureLookupFlags // TypeDefIndex: 17837
{
	// Fields
	public int value__; // 0x0
	public const FontFeatureLookupFlags None = 0;
	public const FontFeatureLookupFlags IgnoreLigatures = 4;
	public const FontFeatureLookupFlags IgnoreSpacingAdjustments = 256;
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
public struct GlyphValueRecord : IEquatable<GlyphValueRecord> // TypeDefIndex: 17838
{
	// Fields
	[NativeName("xPlacement")]
	[SerializeField]
	private float m_XPlacement; // 0x0
	[SerializeField]
	[NativeName("yPlacement")]
	private float m_YPlacement; // 0x4
	[SerializeField]
	[NativeName("xAdvance")]
	private float m_XAdvance; // 0x8
	[SerializeField]
	[NativeName("yAdvance")]
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; }
	public float yAdvance { get; }

	// Methods

	// RVA: 0x758EB0 Offset: 0x7580B0 VA: 0x180758EB0
	public float get_xPlacement() { }

	// RVA: 0x439FD0 Offset: 0x4391D0 VA: 0x180439FD0
	public void set_xPlacement(float value) { }

	// RVA: 0x758EC0 Offset: 0x7580C0 VA: 0x180758EC0
	public float get_yPlacement() { }

	// RVA: 0x439FE0 Offset: 0x4391E0 VA: 0x180439FE0
	public void set_yPlacement(float value) { }

	// RVA: 0x576F00 Offset: 0x576100 VA: 0x180576F00
	public float get_xAdvance() { }

	// RVA: 0x576EF0 Offset: 0x5760F0 VA: 0x180576EF0
	public float get_yAdvance() { }

	// RVA: 0x2509DA0 Offset: 0x2508FA0 VA: 0x182509DA0
	public static GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	// RVA: 0x2509D50 Offset: 0x2508F50 VA: 0x182509D50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2509C70 Offset: 0x2508E70 VA: 0x182509C70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2509CD0 Offset: 0x2508ED0 VA: 0x182509CD0 Slot: 4
	public bool Equals(GlyphValueRecord other) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord> // TypeDefIndex: 17839
{
	// Fields
	[SerializeField]
	[NativeName("glyphIndex")]
	private uint m_GlyphIndex; // 0x0
	[NativeName("glyphValueRecord")]
	[SerializeField]
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public uint get_glyphIndex() { }

	// RVA: 0x2509710 Offset: 0x2508910 VA: 0x182509710
	public GlyphValueRecord get_glyphValueRecord() { }

	[ExcludeFromDocs]
	// RVA: 0x25096B0 Offset: 0x25088B0 VA: 0x1825096B0 Slot: 2
	public override int GetHashCode() { }

	[ExcludeFromDocs]
	// RVA: 0x2509640 Offset: 0x2508840 VA: 0x182509640 Slot: 0
	public override bool Equals(object obj) { }

	[ExcludeFromDocs]
	// RVA: 0x25095B0 Offset: 0x25087B0 VA: 0x1825095B0 Slot: 4
	public bool Equals(GlyphAdjustmentRecord other) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[DebuggerDisplay("First glyphIndex = {m_FirstAdjustmentRecord.m_GlyphIndex},  Second glyphIndex = {m_SecondAdjustmentRecord.m_GlyphIndex}")]
[Serializable]
public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord> // TypeDefIndex: 17840
{
	// Fields
	[NativeName("firstAdjustmentRecord")]
	[SerializeField]
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x0
	[NativeName("secondAdjustmentRecord")]
	[SerializeField]
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14
	[SerializeField]
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x28

	// Properties
	public GlyphAdjustmentRecord firstAdjustmentRecord { get; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }
	public FontFeatureLookupFlags featureLookupFlags { get; }

	// Methods

	// RVA: 0x2509A70 Offset: 0x2508C70 VA: 0x182509A70
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x2509A80 Offset: 0x2508C80 VA: 0x182509A80
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0xC9F3C0 Offset: 0xC9E5C0 VA: 0x180C9F3C0
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	[ExcludeFromDocs]
	// RVA: 0x2509A00 Offset: 0x2508C00 VA: 0x182509A00 Slot: 2
	public override int GetHashCode() { }

	[ExcludeFromDocs]
	// RVA: 0x25098C0 Offset: 0x2508AC0 VA: 0x1825098C0 Slot: 0
	public override bool Equals(object obj) { }

	[ExcludeFromDocs]
	// RVA: 0x2509940 Offset: 0x2508B40 VA: 0x182509940 Slot: 4
	public bool Equals(GlyphPairAdjustmentRecord other) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
internal struct GlyphAnchorPoint // TypeDefIndex: 17841
{
	// Fields
	[NativeName("xPositionAdjustment")]
	[SerializeField]
	private float m_XCoordinate; // 0x0
	[NativeName("yPositionAdjustment")]
	[SerializeField]
	private float m_YCoordinate; // 0x4

	// Properties
	public float xCoordinate { get; }
	public float yCoordinate { get; }

	// Methods

	// RVA: 0x758EB0 Offset: 0x7580B0 VA: 0x180758EB0
	public float get_xCoordinate() { }

	// RVA: 0x758EC0 Offset: 0x7580C0 VA: 0x180758EC0
	public float get_yCoordinate() { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
internal struct MarkPositionAdjustment // TypeDefIndex: 17842
{
	// Fields
	[SerializeField]
	[NativeName("xCoordinate")]
	private float m_XPositionAdjustment; // 0x0
	[NativeName("yCoordinate")]
	[SerializeField]
	private float m_YPositionAdjustment; // 0x4

	// Properties
	public float xPositionAdjustment { get; }
	public float yPositionAdjustment { get; }

	// Methods

	// RVA: 0x758EB0 Offset: 0x7580B0 VA: 0x180758EB0
	public float get_xPositionAdjustment() { }

	// RVA: 0x758EC0 Offset: 0x7580C0 VA: 0x180758EC0
	public float get_yPositionAdjustment() { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
internal struct MarkToBaseAdjustmentRecord // TypeDefIndex: 17843
{
	// Fields
	[SerializeField]
	[NativeName("baseGlyphID")]
	private uint m_BaseGlyphID; // 0x0
	[NativeName("baseAnchor")]
	[SerializeField]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; // 0x4
	[SerializeField]
	[NativeName("markGlyphID")]
	private uint m_MarkGlyphID; // 0xC
	[NativeName("markPositionAdjustment")]
	[SerializeField]
	private MarkPositionAdjustment m_MarkPositionAdjustment; // 0x10

	// Properties
	public uint baseGlyphID { get; }
	public GlyphAnchorPoint baseGlyphAnchorPoint { get; }
	public uint markGlyphID { get; }
	public MarkPositionAdjustment markPositionAdjustment { get; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public uint get_baseGlyphID() { }

	// RVA: 0x24E28F0 Offset: 0x24E1AF0 VA: 0x1824E28F0
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	// RVA: 0x1483110 Offset: 0x1482310 VA: 0x181483110
	public uint get_markGlyphID() { }

	// RVA: 0x24EE720 Offset: 0x24ED920 VA: 0x1824EE720
	public MarkPositionAdjustment get_markPositionAdjustment() { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
internal struct MarkToMarkAdjustmentRecord // TypeDefIndex: 17844
{
	// Fields
	[NativeName("baseMarkGlyphID")]
	[SerializeField]
	private uint m_BaseMarkGlyphID; // 0x0
	[SerializeField]
	[NativeName("baseMarkAnchor")]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; // 0x4
	[NativeName("combiningMarkGlyphID")]
	[SerializeField]
	private uint m_CombiningMarkGlyphID; // 0xC
	[NativeName("combiningMarkPositionAdjustment")]
	[SerializeField]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; // 0x10

	// Properties
	public uint baseMarkGlyphID { get; }
	public GlyphAnchorPoint baseMarkGlyphAnchorPoint { get; }
	public uint combiningMarkGlyphID { get; }
	public MarkPositionAdjustment combiningMarkPositionAdjustment { get; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public uint get_baseMarkGlyphID() { }

	// RVA: 0x24E28F0 Offset: 0x24E1AF0 VA: 0x1824E28F0
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	// RVA: 0x1483110 Offset: 0x1482310 VA: 0x181483110
	public uint get_combiningMarkGlyphID() { }

	// RVA: 0x24EE720 Offset: 0x24ED920 VA: 0x1824EE720
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
internal struct MultipleSubstitutionRecord // TypeDefIndex: 17845
{
	// Fields
	[NativeName("targetGlyphID")]
	[SerializeField]
	private uint m_TargetGlyphID; // 0x0
	[NativeName("substituteGlyphIDs")]
	[SerializeField]
	private uint[] m_SubstituteGlyphIDs; // 0x8
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
internal struct LigatureSubstitutionRecord // TypeDefIndex: 17846
{
	// Fields
	[SerializeField]
	[NativeName("componentGlyphs")]
	private uint[] m_ComponentGlyphIDs; // 0x0
	[SerializeField]
	[NativeName("ligatureGlyph")]
	private uint m_LigatureGlyphID; // 0x8

	// Properties
	public uint[] componentGlyphIDs { get; }
	public uint ligatureGlyphID { get; }

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	public uint[] get_componentGlyphIDs() { }

	// RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000
	public uint get_ligatureGlyphID() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17847
{}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
public class ITilemap // TypeDefIndex: 17848
{
	// Fields
	internal static ITilemap s_Instance; // 0x0
	internal Tilemap m_Tilemap; // 0x10
	internal bool m_AddToList; // 0x18
	internal int m_RefreshCount; // 0x1C
	internal NativeArray<Vector3Int> m_RefreshPos; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x2549EB0 Offset: 0x25490B0 VA: 0x182549EB0
	public void RefreshTile(Vector3Int position) { }

	[RequiredByNativeCode]
	// RVA: 0x25498B0 Offset: 0x2548AB0 VA: 0x1825498B0
	private static ITilemap CreateInstance() { }

	[RequiredByNativeCode]
	// RVA: 0x2549920 Offset: 0x2548B20 VA: 0x182549920
	private static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2549C50 Offset: 0x2548E50 VA: 0x182549C50
	private static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr) { }
}

// Namespace: 
public enum Tile.ColliderType // TypeDefIndex: 17849
{
	// Fields
	public int value__; // 0x0
	public const Tile.ColliderType None = 0;
	public const Tile.ColliderType Sprite = 1;
	public const Tile.ColliderType Grid = 2;
}

// Namespace: UnityEngine.Tilemaps
[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
[RequiredByNativeCode]
[Serializable]
public class Tile : TileBase // TypeDefIndex: 17850
{
	// Fields
	[SerializeField]
	private Sprite m_Sprite; // 0x18
	[SerializeField]
	private Color m_Color; // 0x20
	[SerializeField]
	private Matrix4x4 m_Transform; // 0x30
	[SerializeField]
	private GameObject m_InstancedGameObject; // 0x70
	[SerializeField]
	private TileFlags m_Flags; // 0x78
	[SerializeField]
	private Tile.ColliderType m_ColliderType; // 0x7C

	// Properties
	public Sprite sprite { get; set; }
	public Color color { get; set; }
	public Matrix4x4 transform { get; set; }
	public GameObject gameObject { get; set; }
	public TileFlags flags { get; set; }
	public Tile.ColliderType colliderType { get; set; }

	// Methods

	// RVA: 0x248C210 Offset: 0x248B410 VA: 0x18248C210
	public Sprite get_sprite() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_sprite(Sprite value) { }

	// RVA: 0x254A970 Offset: 0x2549B70 VA: 0x18254A970
	public Color get_color() { }

	// RVA: 0x416940 Offset: 0x415B40 VA: 0x180416940
	public void set_color(Color value) { }

	// RVA: 0x254A990 Offset: 0x2549B90 VA: 0x18254A990
	public Matrix4x4 get_transform() { }

	// RVA: 0x453A50 Offset: 0x452C50 VA: 0x180453A50
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x24CAE40 Offset: 0x24CA040 VA: 0x1824CAE40
	public GameObject get_gameObject() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_gameObject(GameObject value) { }

	// RVA: 0x254A980 Offset: 0x2549B80 VA: 0x18254A980
	public TileFlags get_flags() { }

	// RVA: 0x4EDD40 Offset: 0x4ECF40 VA: 0x1804EDD40
	public void set_flags(TileFlags value) { }

	// RVA: 0x254A960 Offset: 0x2549B60 VA: 0x18254A960
	public Tile.ColliderType get_colliderType() { }

	// RVA: 0x1C44D00 Offset: 0x1C43F00 VA: 0x181C44D00
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x254A780 Offset: 0x2549980 VA: 0x18254A780 Slot: 5
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x254A8E0 Offset: 0x2549AE0 VA: 0x18254A8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
public abstract class TileBase : ScriptableObject // TypeDefIndex: 17851
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x254A1F0 Offset: 0x25493F0 VA: 0x18254A1F0 Slot: 4
	public virtual void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x254A110 Offset: 0x2549310 VA: 0x18254A110
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0xA641B0 Offset: 0xA633B0 VA: 0x180A641B0 Slot: 6
	public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	// RVA: 0x254A040 Offset: 0x2549240 VA: 0x18254A040
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0x254A0D0 Offset: 0x25492D0 VA: 0x18254A0D0
	private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation) { }

	[RequiredByNativeCode]
	// RVA: 0xA641B0 Offset: 0xA633B0 VA: 0x180A641B0 Slot: 7
	public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	[RequiredByNativeCode]
	// RVA: 0x254A390 Offset: 0x2549590 VA: 0x18254A390
	private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: 
public enum Tilemap.Orientation // TypeDefIndex: 17852
{
	// Fields
	public int value__; // 0x0
	public const Tilemap.Orientation XY = 0;
	public const Tilemap.Orientation XZ = 1;
	public const Tilemap.Orientation YX = 2;
	public const Tilemap.Orientation YZ = 3;
	public const Tilemap.Orientation ZX = 4;
	public const Tilemap.Orientation ZY = 5;
	public const Tilemap.Orientation Custom = 6;
}

// Namespace: 
[RequiredByNativeCode]
public struct Tilemap.SyncTile // TypeDefIndex: 17853
{
	// Fields
	internal Vector3Int m_Position; // 0x0
	internal TileBase m_Tile; // 0x10
	internal TileData m_TileData; // 0x18
}

// Namespace: 
internal struct Tilemap.SyncTileCallbackSettings // TypeDefIndex: 17854
{
	// Fields
	internal bool hasSyncTileCallback; // 0x0
	internal bool hasPositionsChangedCallback; // 0x1
	internal bool isBufferSyncTile; // 0x2
}

// Namespace: UnityEngine.Tilemaps
[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/Grid/Public/Grid.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
public sealed class Tilemap : GridLayout // TypeDefIndex: 17855
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Tilemap, Tilemap.SyncTile[]> tilemapTileChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Tilemap, NativeArray<Vector3Int>> tilemapPositionsChanged; // 0x8
	private bool m_BufferSyncTile; // 0x18

	// Properties
	internal bool bufferSyncTile { get; set; }
	public Grid layoutGrid { get; }
	public BoundsInt cellBounds { get; }
	[NativeProperty("TilemapBoundsScripting")]
	public Bounds localBounds { get; }
	[NativeProperty("TilemapFrameBoundsScripting")]
	internal Bounds localFrameBounds { get; }
	public float animationFrameRate { get; set; }
	public Color color { get; set; }
	public Vector3Int origin { get; set; }
	public Vector3Int size { get; set; }
	[NativeProperty(Name = "TileAnchorScripting")]
	public Vector3 tileAnchor { get; set; }
	public Tilemap.Orientation orientation { get; set; }
	public Matrix4x4 orientationMatrix { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x254D6A0 Offset: 0x254C8A0 VA: 0x18254D6A0
	public static void add_tilemapTileChanged(Action<Tilemap, Tilemap.SyncTile[]> value) { }

	[CompilerGenerated]
	// RVA: 0x254CF70 Offset: 0x254C170 VA: 0x18254CF70
	public static void remove_tilemapTileChanged(Action<Tilemap, Tilemap.SyncTile[]> value) { }

	[CompilerGenerated]
	// RVA: 0x254DD50 Offset: 0x254CF50 VA: 0x18254DD50
	public static void add_tilemapPositionsChanged(Action<Tilemap, NativeArray<Vector3Int>> value) { }

	[CompilerGenerated]
	// RVA: 0x254E460 Offset: 0x254D660 VA: 0x18254E460
	public static void remove_tilemapPositionsChanged(Action<Tilemap, NativeArray<Vector3Int>> value) { }

	// RVA: 0x254DE70 Offset: 0x254D070 VA: 0x18254DE70
	internal bool get_bufferSyncTile() { }

	// RVA: 0x254E590 Offset: 0x254D790 VA: 0x18254E590
	internal void set_bufferSyncTile(bool value) { }

	// RVA: 0x254CB10 Offset: 0x254BD10 VA: 0x18254CB10
	internal static bool HasSyncTileCallback() { }

	// RVA: 0x254CAD0 Offset: 0x254BCD0 VA: 0x18254CAD0
	internal static bool HasPositionsChangedCallback() { }

	// RVA: 0x254B640 Offset: 0x254A840 VA: 0x18254B640
	private void HandleSyncTileCallback(Tilemap.SyncTile[] syncTiles) { }

	// RVA: 0x254B5A0 Offset: 0x254A7A0 VA: 0x18254B5A0
	private void HandlePositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	// RVA: 0x254D300 Offset: 0x254C500 VA: 0x18254D300
	private void SendTilemapTileChangedCallback(Tilemap.SyncTile[] syncTiles) { }

	// RVA: 0x254D250 Offset: 0x254C450 VA: 0x18254D250
	private void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions) { }

	// RVA: 0x254D6A0 Offset: 0x254C8A0 VA: 0x18254D6A0
	internal static void SetSyncTileCallback(Action<Tilemap, Tilemap.SyncTile[]> callback) { }

	// RVA: 0x254CF70 Offset: 0x254C170 VA: 0x18254CF70
	internal static void RemoveSyncTileCallback(Action<Tilemap, Tilemap.SyncTile[]> callback) { }

	[NativeMethod(Name = "GetAttachedGrid")]
	// RVA: 0x254DFF0 Offset: 0x254D1F0 VA: 0x18254DFF0
	public Grid get_layoutGrid() { }

	// RVA: 0x254B9A0 Offset: 0x254ABA0 VA: 0x18254B9A0
	public Vector3 GetCellCenterLocal(Vector3Int position) { }

	// RVA: 0x254BAC0 Offset: 0x254ACC0 VA: 0x18254BAC0
	public Vector3 GetCellCenterWorld(Vector3Int position) { }

	// RVA: 0x254DE80 Offset: 0x254D080 VA: 0x18254DE80
	public BoundsInt get_cellBounds() { }

	// RVA: 0x254E080 Offset: 0x254D280 VA: 0x18254E080
	public Bounds get_localBounds() { }

	// RVA: 0x254E130 Offset: 0x254D330 VA: 0x18254E130
	internal Bounds get_localFrameBounds() { }

	// RVA: 0x254DE30 Offset: 0x254D030 VA: 0x18254DE30
	public float get_animationFrameRate() { }

	// RVA: 0x254E540 Offset: 0x254D740 VA: 0x18254E540
	public void set_animationFrameRate(float value) { }

	// RVA: 0x254DFA0 Offset: 0x254D1A0 VA: 0x18254DFA0
	public Color get_color() { }

	// RVA: 0x254E670 Offset: 0x254D870 VA: 0x18254E670
	public void set_color(Color value) { }

	// RVA: 0x254E2D0 Offset: 0x254D4D0 VA: 0x18254E2D0
	public Vector3Int get_origin() { }

	// RVA: 0x254E7F0 Offset: 0x254D9F0 VA: 0x18254E7F0
	public void set_origin(Vector3Int value) { }

	// RVA: 0x254E370 Offset: 0x254D570 VA: 0x18254E370
	public Vector3Int get_size() { }

	// RVA: 0x254E890 Offset: 0x254DA90 VA: 0x18254E890
	public void set_size(Vector3Int value) { }

	// RVA: 0x254E410 Offset: 0x254D610 VA: 0x18254E410
	public Vector3 get_tileAnchor() { }

	// RVA: 0x254E930 Offset: 0x254DB30 VA: 0x18254E930
	public void set_tileAnchor(Vector3 value) { }

	// RVA: 0x254E240 Offset: 0x254D440 VA: 0x18254E240
	public Tilemap.Orientation get_orientation() { }

	// RVA: 0x254E760 Offset: 0x254D960 VA: 0x18254E760
	public void set_orientation(Tilemap.Orientation value) { }

	[NativeMethod(Name = "GetTileOrientationMatrix")]
	// RVA: 0x254E1E0 Offset: 0x254D3E0 VA: 0x18254E1E0
	public Matrix4x4 get_orientationMatrix() { }

	[NativeMethod(Name = "SetOrientationMatrix")]
	// RVA: 0x254E710 Offset: 0x254D910 VA: 0x18254E710
	public void set_orientationMatrix(Matrix4x4 value) { }

	// RVA: 0x254C0C0 Offset: 0x254B2C0 VA: 0x18254C0C0
	internal Object GetTileAsset(Vector3Int position) { }

	// RVA: 0x254C430 Offset: 0x254B630 VA: 0x18254C430
	public TileBase GetTile(Vector3Int position) { }

	// RVA: -1 Offset: -1
	public T GetTile<T>(Vector3Int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA87BB0 Offset: 0xA86DB0 VA: 0x180A87BB0
	|-Tilemap.GetTile<object>
	*/

	// RVA: 0x254C250 Offset: 0x254B450 VA: 0x18254C250
	internal Object[] GetTileAssetsBlock(Vector3Int position, Vector3Int blockDimensions) { }

	// RVA: 0x254C580 Offset: 0x254B780 VA: 0x18254C580
	public TileBase[] GetTilesBlock(BoundsInt bounds) { }

	[FreeFunction(Name = "TilemapBindings::GetTileAssetsBlockNonAlloc", HasExplicitThis = True)]
	// RVA: 0x254C180 Offset: 0x254B380 VA: 0x18254C180
	internal int GetTileAssetsBlockNonAlloc(Vector3Int startPosition, Vector3Int endPosition, Object[] tiles) { }

	// RVA: 0x254C4F0 Offset: 0x254B6F0 VA: 0x18254C4F0
	public int GetTilesBlockNonAlloc(BoundsInt bounds, TileBase[] tiles) { }

	// RVA: 0x254C800 Offset: 0x254BA00 VA: 0x18254C800
	public int GetTilesRangeCount(Vector3Int startPosition, Vector3Int endPosition) { }

	[FreeFunction(Name = "TilemapBindings::GetTileAssetsRangeNonAlloc", HasExplicitThis = True)]
	// RVA: 0x254C320 Offset: 0x254B520 VA: 0x18254C320
	internal int GetTileAssetsRangeNonAlloc(Vector3Int startPosition, Vector3Int endPosition, Vector3Int[] positions, Object[] tiles) { }

	// RVA: 0x254C860 Offset: 0x254BA60 VA: 0x18254C860
	public int GetTilesRangeNonAlloc(Vector3Int startPosition, Vector3Int endPosition, Vector3Int[] positions, TileBase[] tiles) { }

	// RVA: 0x254D8A0 Offset: 0x254CAA0 VA: 0x18254D8A0
	internal void SetTileAsset(Vector3Int position, Object tile) { }

	// RVA: 0x254DA80 Offset: 0x254CC80 VA: 0x18254DA80
	public void SetTile(Vector3Int position, TileBase tile) { }

	// RVA: 0x254D900 Offset: 0x254CB00 VA: 0x18254D900
	internal void SetTileAssets(Vector3Int[] positionArray, Object[] tileArray) { }

	// RVA: 0x254D900 Offset: 0x254CB00 VA: 0x18254D900
	public void SetTiles(Vector3Int[] positionArray, TileBase[] tileArray) { }

	[NativeMethod(Name = "SetTileAssetsBlock")]
	// RVA: 0x254CC60 Offset: 0x254BE60 VA: 0x18254CC60
	private void INTERNAL_CALL_SetTileAssetsBlock(Vector3Int position, Vector3Int blockDimensions, Object[] tileArray) { }

	// RVA: 0x254DB40 Offset: 0x254CD40 VA: 0x18254DB40
	public void SetTilesBlock(BoundsInt position, TileBase[] tileArray) { }

	[NativeMethod(Name = "SetTileChangeData")]
	// RVA: 0x254DAE0 Offset: 0x254CCE0 VA: 0x18254DAE0
	public void SetTile(TileChangeData tileChangeData, bool ignoreLockFlags) { }

	[NativeMethod(Name = "SetTileChangeDataArray")]
	// RVA: 0x254DBD0 Offset: 0x254CDD0 VA: 0x18254DBD0
	public void SetTiles(TileChangeData[] tileChangeDataArray, bool ignoreLockFlags) { }

	// RVA: 0x254CB50 Offset: 0x254BD50 VA: 0x18254CB50
	public bool HasTile(Vector3Int position) { }

	[NativeMethod(Name = "RefreshTileAsset")]
	// RVA: 0x254CEC0 Offset: 0x254C0C0 VA: 0x18254CEC0
	public void RefreshTile(Vector3Int position) { }

	[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = True)]
	// RVA: 0x254CF10 Offset: 0x254C110 VA: 0x18254CF10
	internal void RefreshTilesNative(void* positions, int count) { }

	[NativeMethod(Name = "RefreshAllTileAssets")]
	// RVA: 0x254CE30 Offset: 0x254C030 VA: 0x18254CE30
	public void RefreshAllTiles() { }

	// RVA: 0x254DCF0 Offset: 0x254CEF0 VA: 0x18254DCF0
	internal void SwapTileAsset(Object changeTile, Object newTile) { }

	// RVA: 0x254DCF0 Offset: 0x254CEF0 VA: 0x18254DCF0
	public void SwapTile(TileBase changeTile, TileBase newTile) { }

	// RVA: 0x254B3F0 Offset: 0x254A5F0 VA: 0x18254B3F0
	internal bool ContainsTileAsset(Object tileAsset) { }

	// RVA: 0x254B3F0 Offset: 0x254A5F0 VA: 0x18254B3F0
	public bool ContainsTile(TileBase tileAsset) { }

	// RVA: 0x254CA40 Offset: 0x254BC40 VA: 0x18254CA40
	public int GetUsedTilesCount() { }

	// RVA: 0x254C9B0 Offset: 0x254BBB0 VA: 0x18254C9B0
	public int GetUsedSpritesCount() { }

	// RVA: 0x254CA80 Offset: 0x254BC80 VA: 0x18254CA80
	public int GetUsedTilesNonAlloc(TileBase[] usedTiles) { }

	// RVA: 0x254C9F0 Offset: 0x254BBF0 VA: 0x18254C9F0
	public int GetUsedSpritesNonAlloc(Sprite[] usedSprites) { }

	[FreeFunction(Name = "TilemapBindings::GetUsedTilesNonAlloc", HasExplicitThis = True)]
	// RVA: 0x254CA80 Offset: 0x254BC80 VA: 0x18254CA80
	internal int Internal_GetUsedTilesNonAlloc(Object[] usedTiles) { }

	[FreeFunction(Name = "TilemapBindings::GetUsedSpritesNonAlloc", HasExplicitThis = True)]
	// RVA: 0x254C9F0 Offset: 0x254BBF0 VA: 0x18254C9F0
	internal int Internal_GetUsedSpritesNonAlloc(Object[] usedSprites) { }

	// RVA: 0x254BEF0 Offset: 0x254B0F0 VA: 0x18254BEF0
	public Sprite GetSprite(Vector3Int position) { }

	// RVA: 0x254C940 Offset: 0x254BB40 VA: 0x18254C940
	public Matrix4x4 GetTransformMatrix(Vector3Int position) { }

	// RVA: 0x254DC90 Offset: 0x254CE90 VA: 0x18254DC90
	public void SetTransformMatrix(Vector3Int position, Matrix4x4 transform) { }

	[NativeMethod(Name = "GetTileColor")]
	// RVA: 0x254BD00 Offset: 0x254AF00 VA: 0x18254BD00
	public Color GetColor(Vector3Int position) { }

	[NativeMethod(Name = "SetTileColor")]
	// RVA: 0x254D640 Offset: 0x254C840 VA: 0x18254D640
	public void SetColor(Vector3Int position, Color color) { }

	// RVA: 0x254C3E0 Offset: 0x254B5E0 VA: 0x18254C3E0
	public TileFlags GetTileFlags(Vector3Int position) { }

	// RVA: 0x254D9C0 Offset: 0x254CBC0 VA: 0x18254D9C0
	public void SetTileFlags(Vector3Int position, TileFlags flags) { }

	// RVA: 0x254B190 Offset: 0x254A390 VA: 0x18254B190
	public void AddTileFlags(Vector3Int position, TileFlags flags) { }

	// RVA: 0x254D170 Offset: 0x254C370 VA: 0x18254D170
	public void RemoveTileFlags(Vector3Int position, TileFlags flags) { }

	[NativeMethod(Name = "GetTileInstantiatedObject")]
	// RVA: 0x254BDB0 Offset: 0x254AFB0 VA: 0x18254BDB0
	public GameObject GetInstantiatedObject(Vector3Int position) { }

	[NativeMethod(Name = "GetTileObjectToInstantiate")]
	// RVA: 0x254BE50 Offset: 0x254B050 VA: 0x18254BE50
	public GameObject GetObjectToInstantiate(Vector3Int position) { }

	[NativeMethod(Name = "SetTileColliderType")]
	// RVA: 0x254D580 Offset: 0x254C780 VA: 0x18254D580
	public void SetColliderType(Vector3Int position, Tile.ColliderType colliderType) { }

	[NativeMethod(Name = "GetTileColliderType")]
	// RVA: 0x254BC50 Offset: 0x254AE50 VA: 0x18254BC50
	public Tile.ColliderType GetColliderType(Vector3Int position) { }

	[NativeMethod(Name = "GetTileAnimationFrameCount")]
	// RVA: 0x254B810 Offset: 0x254AA10 VA: 0x18254B810
	public int GetAnimationFrameCount(Vector3Int position) { }

	[NativeMethod(Name = "GetTileAnimationFrame")]
	// RVA: 0x254B8B0 Offset: 0x254AAB0 VA: 0x18254B8B0
	public int GetAnimationFrame(Vector3Int position) { }

	[NativeMethod(Name = "SetTileAnimationFrame")]
	// RVA: 0x254D400 Offset: 0x254C600 VA: 0x18254D400
	public void SetAnimationFrame(Vector3Int position, int frame) { }

	[NativeMethod(Name = "GetTileAnimationTime")]
	// RVA: 0x254B950 Offset: 0x254AB50 VA: 0x18254B950
	public float GetAnimationTime(Vector3Int position) { }

	[NativeMethod(Name = "SetTileAnimationTime")]
	// RVA: 0x254D4C0 Offset: 0x254C6C0 VA: 0x18254D4C0
	public void SetAnimationTime(Vector3Int position, float time) { }

	// RVA: 0x254C020 Offset: 0x254B220 VA: 0x18254C020
	public TileAnimationFlags GetTileAnimationFlags(Vector3Int position) { }

	// RVA: 0x254D7E0 Offset: 0x254C9E0 VA: 0x18254D7E0
	public void SetTileAnimationFlags(Vector3Int position, TileAnimationFlags flags) { }

	// RVA: 0x254B0D0 Offset: 0x254A2D0 VA: 0x18254B0D0
	public void AddTileAnimationFlags(Vector3Int position, TileAnimationFlags flags) { }

	// RVA: 0x254D0B0 Offset: 0x254C2B0 VA: 0x18254D0B0
	public void RemoveTileAnimationFlags(Vector3Int position, TileAnimationFlags flags) { }

	// RVA: 0x254B760 Offset: 0x254A960 VA: 0x18254B760
	public void FloodFill(Vector3Int position, TileBase tile) { }

	[NativeMethod(Name = "FloodFill")]
	// RVA: 0x254B700 Offset: 0x254A900 VA: 0x18254B700
	private void FloodFillTileAsset(Vector3Int position, Object tile) { }

	// RVA: 0x254B2E0 Offset: 0x254A4E0 VA: 0x18254B2E0
	public void BoxFill(Vector3Int position, TileBase tile, int startX, int startY, int endX, int endY) { }

	[NativeMethod(Name = "BoxFill")]
	// RVA: 0x254B260 Offset: 0x254A460 VA: 0x18254B260
	private void BoxFillTileAsset(Vector3Int position, Object tile, int startX, int startY, int endX, int endY) { }

	// RVA: 0x254CD40 Offset: 0x254BF40 VA: 0x18254CD40
	public void InsertCells(Vector3Int position, Vector3Int insertCells) { }

	// RVA: 0x254CDC0 Offset: 0x254BFC0 VA: 0x18254CDC0
	public void InsertCells(Vector3Int position, int numColumns, int numRows, int numLayers) { }

	// RVA: 0x254B4B0 Offset: 0x254A6B0 VA: 0x18254B4B0
	public void DeleteCells(Vector3Int position, Vector3Int deleteCells) { }

	// RVA: 0x254B530 Offset: 0x254A730 VA: 0x18254B530
	public void DeleteCells(Vector3Int position, int numColumns, int numRows, int numLayers) { }

	// RVA: 0x254B370 Offset: 0x254A570 VA: 0x18254B370
	public void ClearAllTiles() { }

	// RVA: 0x254D1D0 Offset: 0x254C3D0 VA: 0x18254D1D0
	public void ResizeBounds() { }

	// RVA: 0x254B3B0 Offset: 0x254A5B0 VA: 0x18254B3B0
	public void CompressBounds() { }

	[RequiredByNativeCode]
	// RVA: 0x254BF40 Offset: 0x254B140 VA: 0x18254BF40
	internal void GetSyncTileCallbackSettings(ref Tilemap.SyncTileCallbackSettings settings) { }

	// RVA: 0x254D210 Offset: 0x254C410 VA: 0x18254D210
	internal void SendAndClearSyncTileBuffer() { }

	[RequiredByNativeCode]
	// RVA: 0x254B640 Offset: 0x254A840 VA: 0x18254B640
	private void DoSyncTileCallback(Tilemap.SyncTile[] syncTiles) { }

	[RequiredByNativeCode]
	// RVA: 0x254B5A0 Offset: 0x254A7A0 VA: 0x18254B5A0
	private void DoPositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }

	// RVA: 0x254E030 Offset: 0x254D230 VA: 0x18254E030
	private void get_localBounds_Injected(out Bounds ret) { }

	// RVA: 0x254E0E0 Offset: 0x254D2E0 VA: 0x18254E0E0
	private void get_localFrameBounds_Injected(out Bounds ret) { }

	// RVA: 0x254DF50 Offset: 0x254D150 VA: 0x18254DF50
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x254E620 Offset: 0x254D820 VA: 0x18254E620
	private void set_color_Injected(ref Color value) { }

	// RVA: 0x254E280 Offset: 0x254D480 VA: 0x18254E280
	private void get_origin_Injected(out Vector3Int ret) { }

	// RVA: 0x254E7A0 Offset: 0x254D9A0 VA: 0x18254E7A0
	private void set_origin_Injected(ref Vector3Int value) { }

	// RVA: 0x254E320 Offset: 0x254D520 VA: 0x18254E320
	private void get_size_Injected(out Vector3Int ret) { }

	// RVA: 0x254E840 Offset: 0x254DA40 VA: 0x18254E840
	private void set_size_Injected(ref Vector3Int value) { }

	// RVA: 0x254E3C0 Offset: 0x254D5C0 VA: 0x18254E3C0
	private void get_tileAnchor_Injected(out Vector3 ret) { }

	// RVA: 0x254E8E0 Offset: 0x254DAE0 VA: 0x18254E8E0
	private void set_tileAnchor_Injected(ref Vector3 value) { }

	// RVA: 0x254E190 Offset: 0x254D390 VA: 0x18254E190
	private void get_orientationMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x254E6C0 Offset: 0x254D8C0 VA: 0x18254E6C0
	private void set_orientationMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x254C070 Offset: 0x254B270 VA: 0x18254C070
	private Object GetTileAsset_Injected(ref Vector3Int position) { }

	// RVA: 0x254C1F0 Offset: 0x254B3F0 VA: 0x18254C1F0
	private Object[] GetTileAssetsBlock_Injected(ref Vector3Int position, ref Vector3Int blockDimensions) { }

	// RVA: 0x254C110 Offset: 0x254B310 VA: 0x18254C110
	private int GetTileAssetsBlockNonAlloc_Injected(ref Vector3Int startPosition, ref Vector3Int endPosition, Object[] tiles) { }

	// RVA: 0x254C7A0 Offset: 0x254B9A0 VA: 0x18254C7A0
	private int GetTilesRangeCount_Injected(ref Vector3Int startPosition, ref Vector3Int endPosition) { }

	// RVA: 0x254C2B0 Offset: 0x254B4B0 VA: 0x18254C2B0
	private int GetTileAssetsRangeNonAlloc_Injected(ref Vector3Int startPosition, ref Vector3Int endPosition, Vector3Int[] positions, Object[] tiles) { }

	// RVA: 0x254D840 Offset: 0x254CA40 VA: 0x18254D840
	private void SetTileAsset_Injected(ref Vector3Int position, Object tile) { }

	// RVA: 0x254CBF0 Offset: 0x254BDF0 VA: 0x18254CBF0
	private void INTERNAL_CALL_SetTileAssetsBlock_Injected(ref Vector3Int position, ref Vector3Int blockDimensions, Object[] tileArray) { }

	// RVA: 0x254DA20 Offset: 0x254CC20 VA: 0x18254DA20
	private void SetTile_Injected(ref TileChangeData tileChangeData, bool ignoreLockFlags) { }

	// RVA: 0x254CE70 Offset: 0x254C070 VA: 0x18254CE70
	private void RefreshTile_Injected(ref Vector3Int position) { }

	// RVA: 0x254BEA0 Offset: 0x254B0A0 VA: 0x18254BEA0
	private Sprite GetSprite_Injected(ref Vector3Int position) { }

	// RVA: 0x254C8E0 Offset: 0x254BAE0 VA: 0x18254C8E0
	private void GetTransformMatrix_Injected(ref Vector3Int position, out Matrix4x4 ret) { }

	// RVA: 0x254DC30 Offset: 0x254CE30 VA: 0x18254DC30
	private void SetTransformMatrix_Injected(ref Vector3Int position, ref Matrix4x4 transform) { }

	// RVA: 0x254BCA0 Offset: 0x254AEA0 VA: 0x18254BCA0
	private void GetColor_Injected(ref Vector3Int position, out Color ret) { }

	// RVA: 0x254D5E0 Offset: 0x254C7E0 VA: 0x18254D5E0
	private void SetColor_Injected(ref Vector3Int position, ref Color color) { }

	// RVA: 0x254C390 Offset: 0x254B590 VA: 0x18254C390
	private TileFlags GetTileFlags_Injected(ref Vector3Int position) { }

	// RVA: 0x254D960 Offset: 0x254CB60 VA: 0x18254D960
	private void SetTileFlags_Injected(ref Vector3Int position, TileFlags flags) { }

	// RVA: 0x254B130 Offset: 0x254A330 VA: 0x18254B130
	private void AddTileFlags_Injected(ref Vector3Int position, TileFlags flags) { }

	// RVA: 0x254D110 Offset: 0x254C310 VA: 0x18254D110
	private void RemoveTileFlags_Injected(ref Vector3Int position, TileFlags flags) { }

	// RVA: 0x254BD60 Offset: 0x254AF60 VA: 0x18254BD60
	private GameObject GetInstantiatedObject_Injected(ref Vector3Int position) { }

	// RVA: 0x254BE00 Offset: 0x254B000 VA: 0x18254BE00
	private GameObject GetObjectToInstantiate_Injected(ref Vector3Int position) { }

	// RVA: 0x254D520 Offset: 0x254C720 VA: 0x18254D520
	private void SetColliderType_Injected(ref Vector3Int position, Tile.ColliderType colliderType) { }

	// RVA: 0x254BC00 Offset: 0x254AE00 VA: 0x18254BC00
	private Tile.ColliderType GetColliderType_Injected(ref Vector3Int position) { }

	// RVA: 0x254B7C0 Offset: 0x254A9C0 VA: 0x18254B7C0
	private int GetAnimationFrameCount_Injected(ref Vector3Int position) { }

	// RVA: 0x254B860 Offset: 0x254AA60 VA: 0x18254B860
	private int GetAnimationFrame_Injected(ref Vector3Int position) { }

	// RVA: 0x254D3A0 Offset: 0x254C5A0 VA: 0x18254D3A0
	private void SetAnimationFrame_Injected(ref Vector3Int position, int frame) { }

	// RVA: 0x254B900 Offset: 0x254AB00 VA: 0x18254B900
	private float GetAnimationTime_Injected(ref Vector3Int position) { }

	// RVA: 0x254D460 Offset: 0x254C660 VA: 0x18254D460
	private void SetAnimationTime_Injected(ref Vector3Int position, float time) { }

	// RVA: 0x254BFD0 Offset: 0x254B1D0 VA: 0x18254BFD0
	private TileAnimationFlags GetTileAnimationFlags_Injected(ref Vector3Int position) { }

	// RVA: 0x254D780 Offset: 0x254C980 VA: 0x18254D780
	private void SetTileAnimationFlags_Injected(ref Vector3Int position, TileAnimationFlags flags) { }

	// RVA: 0x254B070 Offset: 0x254A270 VA: 0x18254B070
	private void AddTileAnimationFlags_Injected(ref Vector3Int position, TileAnimationFlags flags) { }

	// RVA: 0x254D050 Offset: 0x254C250 VA: 0x18254D050
	private void RemoveTileAnimationFlags_Injected(ref Vector3Int position, TileAnimationFlags flags) { }

	// RVA: 0x254B6A0 Offset: 0x254A8A0 VA: 0x18254B6A0
	private void FloodFillTileAsset_Injected(ref Vector3Int position, Object tile) { }

	// RVA: 0x254B1F0 Offset: 0x254A3F0 VA: 0x18254B1F0
	private void BoxFillTileAsset_Injected(ref Vector3Int position, Object tile, int startX, int startY, int endX, int endY) { }

	// RVA: 0x254CCD0 Offset: 0x254BED0 VA: 0x18254CCD0
	private void InsertCells_Injected(ref Vector3Int position, int numColumns, int numRows, int numLayers) { }

	// RVA: 0x254B440 Offset: 0x254A640 VA: 0x18254B440
	private void DeleteCells_Injected(ref Vector3Int position, int numColumns, int numRows, int numLayers) { }
}

// Namespace: UnityEngine.Tilemaps
[Flags]
public enum TileFlags // TypeDefIndex: 17856
{
	// Fields
	public int value__; // 0x0
	public const TileFlags None = 0;
	public const TileFlags LockColor = 1;
	public const TileFlags LockTransform = 2;
	public const TileFlags InstantiateGameObjectRuntimeOnly = 4;
	public const TileFlags KeepGameObjectRuntimeOnly = 8;
	public const TileFlags LockAll = 3;
}

// Namespace: UnityEngine.Tilemaps
[Flags]
public enum TileAnimationFlags // TypeDefIndex: 17857
{
	// Fields
	public int value__; // 0x0
	public const TileAnimationFlags None = 0;
	public const TileAnimationFlags LoopOnce = 1;
	public const TileAnimationFlags PauseAnimation = 2;
	public const TileAnimationFlags UpdatePhysics = 4;
}

// Namespace: 
public enum TilemapRenderer.SortOrder // TypeDefIndex: 17858
{
	// Fields
	public int value__; // 0x0
	public const TilemapRenderer.SortOrder BottomLeft = 0;
	public const TilemapRenderer.SortOrder BottomRight = 1;
	public const TilemapRenderer.SortOrder TopLeft = 2;
	public const TilemapRenderer.SortOrder TopRight = 3;
}

// Namespace: 
public enum TilemapRenderer.Mode // TypeDefIndex: 17859
{
	// Fields
	public int value__; // 0x0
	public const TilemapRenderer.Mode Chunk = 0;
	public const TilemapRenderer.Mode Individual = 1;
}

// Namespace: 
public enum TilemapRenderer.DetectChunkCullingBounds // TypeDefIndex: 17860
{
	// Fields
	public int value__; // 0x0
	public const TilemapRenderer.DetectChunkCullingBounds Auto = 0;
	public const TilemapRenderer.DetectChunkCullingBounds Manual = 1;
}

// Namespace: UnityEngine.Tilemaps
[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[RequireComponent(typeof(Tilemap))]
[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
public sealed class TilemapRenderer : Renderer // TypeDefIndex: 17861
{
	// Properties
	public Vector3Int chunkSize { get; set; }
	public Vector3 chunkCullingBounds { get; set; }
	public int maxChunkCount { get; set; }
	public int maxFrameAge { get; set; }
	public TilemapRenderer.SortOrder sortOrder { get; set; }
	[NativeProperty("RenderMode")]
	public TilemapRenderer.Mode mode { get; set; }
	public TilemapRenderer.DetectChunkCullingBounds detectChunkCullingBounds { get; set; }
	public SpriteMaskInteraction maskInteraction { get; set; }

	// Methods

	// RVA: 0x254ABE0 Offset: 0x2549DE0 VA: 0x18254ABE0
	public Vector3Int get_chunkSize() { }

	// RVA: 0x254AEA0 Offset: 0x254A0A0 VA: 0x18254AEA0
	public void set_chunkSize(Vector3Int value) { }

	[FreeFunction("TilemapRendererBindings::GetChunkCullingBounds", HasExplicitThis = True)]
	// RVA: 0x254AB40 Offset: 0x2549D40 VA: 0x18254AB40
	public Vector3 get_chunkCullingBounds() { }

	[FreeFunction("TilemapRendererBindings::SetChunkCullingBounds", HasExplicitThis = True)]
	// RVA: 0x254AE00 Offset: 0x254A000 VA: 0x18254AE00
	public void set_chunkCullingBounds(Vector3 value) { }

	// RVA: 0x254ACB0 Offset: 0x2549EB0 VA: 0x18254ACB0
	public int get_maxChunkCount() { }

	// RVA: 0x254AF70 Offset: 0x254A170 VA: 0x18254AF70
	public void set_maxChunkCount(int value) { }

	// RVA: 0x254ACF0 Offset: 0x2549EF0 VA: 0x18254ACF0
	public int get_maxFrameAge() { }

	// RVA: 0x254AFB0 Offset: 0x254A1B0 VA: 0x18254AFB0
	public void set_maxFrameAge(int value) { }

	// RVA: 0x254AD70 Offset: 0x2549F70 VA: 0x18254AD70
	public TilemapRenderer.SortOrder get_sortOrder() { }

	// RVA: 0x254B030 Offset: 0x254A230 VA: 0x18254B030
	public void set_sortOrder(TilemapRenderer.SortOrder value) { }

	// RVA: 0x254AD30 Offset: 0x2549F30 VA: 0x18254AD30
	public TilemapRenderer.Mode get_mode() { }

	// RVA: 0x254AFF0 Offset: 0x254A1F0 VA: 0x18254AFF0
	public void set_mode(TilemapRenderer.Mode value) { }

	// RVA: 0x254AC30 Offset: 0x2549E30 VA: 0x18254AC30
	public TilemapRenderer.DetectChunkCullingBounds get_detectChunkCullingBounds() { }

	// RVA: 0x254AEF0 Offset: 0x254A0F0 VA: 0x18254AEF0
	public void set_detectChunkCullingBounds(TilemapRenderer.DetectChunkCullingBounds value) { }

	// RVA: 0x254AC70 Offset: 0x2549E70 VA: 0x18254AC70
	public SpriteMaskInteraction get_maskInteraction() { }

	// RVA: 0x254AF30 Offset: 0x254A130 VA: 0x18254AF30
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	[RequiredByNativeCode]
	// RVA: 0x254AA10 Offset: 0x2549C10 VA: 0x18254AA10
	internal void RegisterSpriteAtlasRegistered() { }

	[RequiredByNativeCode]
	// RVA: 0x254AA80 Offset: 0x2549C80 VA: 0x18254AA80
	internal void UnregisterSpriteAtlasRegistered() { }

	// RVA: 0x254A9C0 Offset: 0x2549BC0 VA: 0x18254A9C0
	internal void OnSpriteAtlasRegistered(SpriteAtlas atlas) { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }

	// RVA: 0x254AB90 Offset: 0x2549D90 VA: 0x18254AB90
	private void get_chunkSize_Injected(out Vector3Int ret) { }

	// RVA: 0x254AE50 Offset: 0x254A050 VA: 0x18254AE50
	private void set_chunkSize_Injected(ref Vector3Int value) { }

	// RVA: 0x254AAF0 Offset: 0x2549CF0 VA: 0x18254AAF0
	private void get_chunkCullingBounds_Injected(out Vector3 ret) { }

	// RVA: 0x254ADB0 Offset: 0x2549FB0 VA: 0x18254ADB0
	private void set_chunkCullingBounds_Injected(ref Vector3 value) { }
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
public struct TileData // TypeDefIndex: 17862
{
	// Fields
	private int m_Sprite; // 0x0
	private Color m_Color; // 0x4
	private Matrix4x4 m_Transform; // 0x14
	private int m_GameObject; // 0x54
	private TileFlags m_Flags; // 0x58
	private Tile.ColliderType m_ColliderType; // 0x5C
	internal static readonly TileData Default; // 0x0

	// Properties
	public Sprite sprite { set; }
	public Color color { set; }
	public Matrix4x4 transform { set; }
	public GameObject gameObject { set; }
	public TileFlags flags { set; }
	public Tile.ColliderType colliderType { set; }

	// Methods

	// RVA: 0x254A6D0 Offset: 0x25498D0 VA: 0x18254A6D0
	public void set_sprite(Sprite value) { }

	// RVA: 0x789B10 Offset: 0x788D10 VA: 0x180789B10
	public void set_color(Color value) { }

	// RVA: 0x254A760 Offset: 0x2549960 VA: 0x18254A760
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x254A640 Offset: 0x2549840 VA: 0x18254A640
	public void set_gameObject(GameObject value) { }

	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	public void set_flags(TileFlags value) { }

	// RVA: 0x4EDE90 Offset: 0x4ED090 VA: 0x1804EDE90
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x254A3D0 Offset: 0x25495D0 VA: 0x18254A3D0
	private static TileData CreateDefault() { }

	// RVA: 0x254A500 Offset: 0x2549700 VA: 0x18254A500
	private static void .cctor() { }
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
internal struct TileDataNative // TypeDefIndex: 17863
{
	// Fields
	private int m_Sprite; // 0x0
	private Color m_Color; // 0x4
	private Matrix4x4 m_Transform; // 0x14
	private int m_GameObject; // 0x54
	private TileFlags m_Flags; // 0x58
	private Tile.ColliderType m_ColliderType; // 0x5C
}

// Namespace: UnityEngine.Tilemaps
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
public struct TileChangeData // TypeDefIndex: 17864
{
	// Fields
	private Vector3Int m_Position; // 0x0
	private Object m_TileAsset; // 0x10
	private Color m_Color; // 0x18
	private Matrix4x4 m_Transform; // 0x28
}

// Namespace: UnityEngine.Tilemaps
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
public struct TileAnimationData // TypeDefIndex: 17865
{
	// Fields
	private Sprite[] m_AnimatedSprites; // 0x0
	private float m_AnimationSpeed; // 0x8
	private float m_AnimationStartTime; // 0xC
	private TileAnimationFlags m_Flags; // 0x10
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17866
{}

// Namespace: UnityEngineInternal
internal static class WebRequestUtils // TypeDefIndex: 17867
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2715C80 Offset: 0x2714E80 VA: 0x182715C80
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x27155D0 Offset: 0x27147D0 VA: 0x1827155D0
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x27158C0 Offset: 0x2714AC0 VA: 0x1827158C0
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x2715D80 Offset: 0x2714F80 VA: 0x182715D80
	private static string URLDecode(string encoded) { }

	// RVA: 0x2715E80 Offset: 0x2715080 VA: 0x182715E80
	private static void .cctor() { }
}

// Namespace: UnityEngine
public class WWWForm // TypeDefIndex: 17868
{
	// Fields
	private static byte[] dDash; // 0x0
	private static byte[] crlf; // 0x8
	private static byte[] contentTypeHeader; // 0x10
	private static byte[] dispositionHeader; // 0x18
	private static byte[] endQuote; // 0x20
	private static byte[] fileNameField; // 0x28
	private static byte[] ampersand; // 0x30
	private static byte[] equal; // 0x38

	// Properties
	internal static Encoding DefaultEncoding { get; }

	// Methods

	// RVA: 0x27148B0 Offset: 0x2713AB0 VA: 0x1827148B0
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x2714620 Offset: 0x2713820 VA: 0x182714620
	private static void .cctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UnityWebRequestWWWModule" })]
internal class WWWTranscoder // TypeDefIndex: 17869
{
	// Fields
	private static byte[] ucHexChars; // 0x0
	private static byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static byte[] urlSpace; // 0x18
	private static byte[] dataSpace; // 0x20
	private static byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static byte[] qpSpace; // 0x38
	private static byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x2715260 Offset: 0x2714460 VA: 0x182715260
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x27148C0 Offset: 0x2713AC0 VA: 0x1827148C0
	private static void Byte2Hex(byte b, byte[] hexChars, out byte byte0, out byte byte1) { }

	// RVA: 0x27149F0 Offset: 0x2713BF0 VA: 0x1827149F0
	public static string DataEncode(string toEncode, Encoding e) { }

	// RVA: 0x2714E40 Offset: 0x2714040 VA: 0x182714E40
	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	// RVA: 0x2714900 Offset: 0x2713B00 VA: 0x182714900
	private static bool ByteArrayContains(byte[] array, byte b) { }

	// RVA: 0x27152F0 Offset: 0x27144F0 VA: 0x1827152F0
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x2714950 Offset: 0x2713B50 VA: 0x182714950
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x2714B00 Offset: 0x2713D00 VA: 0x182714B00
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x2715360 Offset: 0x2714560 VA: 0x182715360
	private static void .cctor() { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
public class CertificateHandler // TypeDefIndex: 17870
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2711550 Offset: 0x2710750 VA: 0x182711550
	private void Release() { }

	// RVA: 0xA641B0 Offset: 0xA633B0 VA: 0x180A641B0 Slot: 4
	protected virtual bool ValidateCertificate(byte[] certificateData) { }

	[RequiredByNativeCode]
	// RVA: 0x2711590 Offset: 0x2710790 VA: 0x182711590
	internal bool ValidateCertificateNative(byte[] certificateData) { }

	// RVA: 0x2711500 Offset: 0x2710700 VA: 0x182711500 Slot: 5
	public void Dispose() { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
public class DownloadHandler : IDisposable // TypeDefIndex: 17871
{
	// Fields
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string error { get; }
	public string text { get; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2711E80 Offset: 0x2711080 VA: 0x182711E80
	private void Release() { }

	[VisibleToOtherModules]
	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x2711910 Offset: 0x2710B10 VA: 0x182711910 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x27118C0 Offset: 0x2710AC0 VA: 0x1827118C0 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x27119C0 Offset: 0x2710BC0 VA: 0x1827119C0
	public string get_error() { }

	// RVA: 0x27119C0 Offset: 0x2710BC0 VA: 0x1827119C0
	private string GetErrorMsg() { }

	// RVA: 0x82EEC0 Offset: 0x82E0C0 VA: 0x18082EEC0
	public string get_text() { }

	// RVA: 0xB88010 Offset: 0xB87210 VA: 0x180B88010 Slot: 6
	protected virtual NativeArray<byte> GetNativeData() { }

	// RVA: 0x2711C20 Offset: 0x2710E20 VA: 0x182711C20 Slot: 7
	protected virtual string GetText() { }

	// RVA: 0x2711A00 Offset: 0x2710C00 VA: 0x182711A00
	private Encoding GetTextEncoder() { }

	// RVA: 0x2711980 Offset: 0x2710B80 VA: 0x182711980
	private string GetContentType() { }

	[RequiredByNativeCode]
	// RVA: 0xD72460 Offset: 0xD71660 VA: 0x180D72460 Slot: 8
	protected virtual bool ReceiveData(byte[] data, int dataLength) { }

	[RequiredByNativeCode]
	// RVA: 0x2010790 Offset: 0x200F990 VA: 0x182010790 Slot: 9
	protected virtual void ReceiveContentLengthHeader(ulong contentLength) { }

	[Obsolete("Use ReceiveContentLengthHeader")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	protected virtual void ReceiveContentLength(int contentLength) { }

	[RequiredByNativeCode]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	protected virtual void CompleteContent() { }

	[RequiredByNativeCode]
	// RVA: 0x24F2820 Offset: 0x24F1A20 VA: 0x1824F2820 Slot: 12
	protected virtual float GetProgress() { }

	[NativeThrows]
	[VisibleToOtherModules]
	// RVA: 0x2711D10 Offset: 0x2710F10 VA: 0x182711D10
	internal static byte* InternalGetByteArray(DownloadHandler dh, out int length) { }

	// RVA: 0x2711D60 Offset: 0x2710F60 VA: 0x182711D60
	internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray) { }

	// RVA: 0x2711880 Offset: 0x2710A80 VA: 0x182711880
	internal static void DisposeNativeArray(ref NativeArray<byte> data) { }

	// RVA: 0x2711810 Offset: 0x2710A10 VA: 0x182711810
	internal static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
public sealed class DownloadHandlerBuffer : DownloadHandler // TypeDefIndex: 17872
{
	// Fields
	private NativeArray<byte> m_NativeData; // 0x18

	// Methods

	// RVA: 0x27115B0 Offset: 0x27107B0 VA: 0x1827115B0
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0x2711790 Offset: 0x2710990 VA: 0x182711790
	private void InternalCreateBuffer() { }

	// RVA: 0x27117D0 Offset: 0x27109D0 VA: 0x1827117D0
	public void .ctor() { }

	// RVA: 0x2711670 Offset: 0x2710870 VA: 0x182711670 Slot: 6
	protected override NativeArray<byte> GetNativeData() { }

	// RVA: 0x27115F0 Offset: 0x27107F0 VA: 0x1827115F0 Slot: 5
	public override void Dispose() { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
[NativeHeader("UnityWebRequestScriptingClasses.h")]
[UsedByNativeCode]
public class UnityWebRequestAsyncOperation : AsyncOperation // TypeDefIndex: 17873
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Properties
	public UnityWebRequest webRequest { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public UnityWebRequest get_webRequest() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_webRequest(UnityWebRequest value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
internal enum UnityWebRequest.UnityWebRequestMethod // TypeDefIndex: 17874
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestMethod Get = 0;
	public const UnityWebRequest.UnityWebRequestMethod Post = 1;
	public const UnityWebRequest.UnityWebRequestMethod Put = 2;
	public const UnityWebRequest.UnityWebRequestMethod Head = 3;
	public const UnityWebRequest.UnityWebRequestMethod Custom = 4;
}

// Namespace: 
internal enum UnityWebRequest.UnityWebRequestError // TypeDefIndex: 17875
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestError OK = 0;
	public const UnityWebRequest.UnityWebRequestError OKCached = 1;
	public const UnityWebRequest.UnityWebRequestError Unknown = 2;
	public const UnityWebRequest.UnityWebRequestError SDKError = 3;
	public const UnityWebRequest.UnityWebRequestError UnsupportedProtocol = 4;
	public const UnityWebRequest.UnityWebRequestError MalformattedUrl = 5;
	public const UnityWebRequest.UnityWebRequestError CannotResolveProxy = 6;
	public const UnityWebRequest.UnityWebRequestError CannotResolveHost = 7;
	public const UnityWebRequest.UnityWebRequestError CannotConnectToHost = 8;
	public const UnityWebRequest.UnityWebRequestError AccessDenied = 9;
	public const UnityWebRequest.UnityWebRequestError GenericHttpError = 10;
	public const UnityWebRequest.UnityWebRequestError WriteError = 11;
	public const UnityWebRequest.UnityWebRequestError ReadError = 12;
	public const UnityWebRequest.UnityWebRequestError OutOfMemory = 13;
	public const UnityWebRequest.UnityWebRequestError Timeout = 14;
	public const UnityWebRequest.UnityWebRequestError HTTPPostError = 15;
	public const UnityWebRequest.UnityWebRequestError SSLCannotConnect = 16;
	public const UnityWebRequest.UnityWebRequestError Aborted = 17;
	public const UnityWebRequest.UnityWebRequestError TooManyRedirects = 18;
	public const UnityWebRequest.UnityWebRequestError ReceivedNoData = 19;
	public const UnityWebRequest.UnityWebRequestError SSLNotSupported = 20;
	public const UnityWebRequest.UnityWebRequestError FailedToSendData = 21;
	public const UnityWebRequest.UnityWebRequestError FailedToReceiveData = 22;
	public const UnityWebRequest.UnityWebRequestError SSLCertificateError = 23;
	public const UnityWebRequest.UnityWebRequestError SSLCipherNotAvailable = 24;
	public const UnityWebRequest.UnityWebRequestError SSLCACertError = 25;
	public const UnityWebRequest.UnityWebRequestError UnrecognizedContentEncoding = 26;
	public const UnityWebRequest.UnityWebRequestError LoginFailed = 27;
	public const UnityWebRequest.UnityWebRequestError SSLShutdownFailed = 28;
	public const UnityWebRequest.UnityWebRequestError RedirectLimitInvalid = 29;
	public const UnityWebRequest.UnityWebRequestError InvalidRedirect = 30;
	public const UnityWebRequest.UnityWebRequestError CannotModifyRequest = 31;
	public const UnityWebRequest.UnityWebRequestError HeaderNameContainsInvalidCharacters = 32;
	public const UnityWebRequest.UnityWebRequestError HeaderValueContainsInvalidCharacters = 33;
	public const UnityWebRequest.UnityWebRequestError CannotOverrideSystemHeaders = 34;
	public const UnityWebRequest.UnityWebRequestError AlreadySent = 35;
	public const UnityWebRequest.UnityWebRequestError InvalidMethod = 36;
	public const UnityWebRequest.UnityWebRequestError NotImplemented = 37;
	public const UnityWebRequest.UnityWebRequestError NoInternetConnection = 38;
	public const UnityWebRequest.UnityWebRequestError DataProcessingError = 39;
	public const UnityWebRequest.UnityWebRequestError InsecureConnectionNotAllowed = 40;
}

// Namespace: 
public enum UnityWebRequest.Result // TypeDefIndex: 17876
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.Result InProgress = 0;
	public const UnityWebRequest.Result Success = 1;
	public const UnityWebRequest.Result ConnectionError = 2;
	public const UnityWebRequest.Result ProtocolError = 3;
	public const UnityWebRequest.Result DataProcessingError = 4;
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
public class UnityWebRequest : IDisposable // TypeDefIndex: 17877
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	public const string kHttpVerbGET = "GET";
	public const string kHttpVerbHEAD = "HEAD";
	public const string kHttpVerbPOST = "POST";
	public const string kHttpVerbPUT = "PUT";
	public const string kHttpVerbCREATE = "CREATE";
	public const string kHttpVerbDELETE = "DELETE";
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { get; set; }
	public string error { get; }
	private bool use100Continue { set; }
	public bool useHttpContinue { set; }
	public string url { get; set; }
	public long responseCode { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	[Obsolete("UnityWebRequest.isNetworkError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ConnectionError) instead.", False)]
	public bool isNetworkError { get; }
	public UnityWebRequest.Result result { get; }
	public ulong downloadedBytes { get; }
	public int redirectLimit { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; set; }
	public int timeout { set; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	// RVA: 0x27124D0 Offset: 0x27116D0 VA: 0x1827124D0
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModules]
	// RVA: 0x27121D0 Offset: 0x27113D0 VA: 0x1827121D0
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGenerated]
	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4BD740 Offset: 0x4BC940 VA: 0x1804BD740
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x4BD790 Offset: 0x4BC990 VA: 0x1804BD790
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x161DE50 Offset: 0x161D050 VA: 0x18161DE50
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x161DE60 Offset: 0x161D060 VA: 0x18161DE60
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	[NativeThrows]
	// RVA: 0x2711F40 Offset: 0x2711140 VA: 0x182711F40
	internal static IntPtr Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2712AC0 Offset: 0x2711CC0 VA: 0x182712AC0
	private void Release() { }

	// RVA: 0x2712640 Offset: 0x2711840 VA: 0x182712640
	internal void InternalDestroy() { }

	// RVA: 0x27127C0 Offset: 0x27119C0 VA: 0x1827127C0
	private void InternalSetDefaults() { }

	// RVA: 0x2713390 Offset: 0x2712590 VA: 0x182713390
	public void .ctor() { }

	// RVA: 0x27133E0 Offset: 0x27125E0 VA: 0x1827133E0
	public void .ctor(string url, string method) { }

	// RVA: 0x27132E0 Offset: 0x27124E0 VA: 0x1827132E0
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x27120E0 Offset: 0x27112E0 VA: 0x1827120E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2712080 Offset: 0x2711280 VA: 0x182712080 Slot: 4
	public void Dispose() { }

	// RVA: 0x2711FE0 Offset: 0x27111E0 VA: 0x182711FE0
	private void DisposeHandlers() { }

	[NativeThrows]
	// RVA: 0x2711F00 Offset: 0x2711100 VA: 0x182711F00
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x2712B00 Offset: 0x2711D00 VA: 0x182712B00
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2711EC0 Offset: 0x27110C0 VA: 0x182711EC0
	public void Abort() { }

	// RVA: 0x2712C30 Offset: 0x2711E30 VA: 0x182712C30
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x27127D0 Offset: 0x27119D0 VA: 0x1827127D0
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x2712B90 Offset: 0x2711D90 VA: 0x182712B90
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x27126C0 Offset: 0x27118C0 VA: 0x1827126C0
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x2712210 Offset: 0x2711410 VA: 0x182712210
	internal UnityWebRequest.UnityWebRequestMethod GetMethod() { }

	// RVA: 0x2712150 Offset: 0x2711350 VA: 0x182712150
	internal string GetCustomMethod() { }

	// RVA: 0x27136D0 Offset: 0x27128D0 VA: 0x1827136D0
	public string get_method() { }

	// RVA: 0x2713A50 Offset: 0x2712C50 VA: 0x182713A50
	public void set_method(string value) { }

	// RVA: 0x2712190 Offset: 0x2711390 VA: 0x182712190
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x27134A0 Offset: 0x27126A0 VA: 0x1827134A0
	public string get_error() { }

	// RVA: 0x2714080 Offset: 0x2713280 VA: 0x182714080
	private void set_use100Continue(bool value) { }

	// RVA: 0x27140D0 Offset: 0x27132D0 VA: 0x1827140D0
	public void set_useHttpContinue(bool value) { }

	// RVA: 0x2712490 Offset: 0x2711690 VA: 0x182712490
	public string get_url() { }

	// RVA: 0x2713F10 Offset: 0x2713110 VA: 0x182713F10
	public void set_url(string value) { }

	// RVA: 0x2712490 Offset: 0x2711690 VA: 0x182712490
	private string GetUrl() { }

	// RVA: 0x2712F10 Offset: 0x2712110 VA: 0x182712F10
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x2712930 Offset: 0x2711B30 VA: 0x182712930
	private void InternalSetUrl(string url) { }

	// RVA: 0x27137B0 Offset: 0x27129B0 VA: 0x1827137B0
	public long get_responseCode() { }

	[NativeMethod("IsModifiable")]
	// RVA: 0x2713650 Offset: 0x2712850 VA: 0x182713650
	public bool get_isModifiable() { }

	// RVA: 0x2713610 Offset: 0x2712810 VA: 0x182713610
	public bool get_isDone() { }

	// RVA: 0x2713690 Offset: 0x2712890 VA: 0x182713690
	public bool get_isNetworkError() { }

	[NativeMethod("GetResult")]
	// RVA: 0x27137F0 Offset: 0x27129F0 VA: 0x1827137F0
	public UnityWebRequest.Result get_result() { }

	// RVA: 0x2713460 Offset: 0x2712660 VA: 0x182713460
	public ulong get_downloadedBytes() { }

	[NativeThrows]
	// RVA: 0x2712C70 Offset: 0x2711E70 VA: 0x182712C70
	private void SetRedirectLimitFromScripting(int limit) { }

	// RVA: 0x2712C70 Offset: 0x2711E70 VA: 0x182712C70
	public void set_redirectLimit(int value) { }

	[NativeMethod("SetRequestHeader")]
	// RVA: 0x27128D0 Offset: 0x2711AD0 VA: 0x1827128D0
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x2712CB0 Offset: 0x2711EB0 VA: 0x182712CB0
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x2712290 Offset: 0x2711490 VA: 0x182712290
	public string GetResponseHeader(string name) { }

	// RVA: 0x2712250 Offset: 0x2711450 VA: 0x182712250
	internal string[] GetResponseHeaderKeys() { }

	// RVA: 0x27122E0 Offset: 0x27114E0 VA: 0x1827122E0
	public Dictionary<string, string> GetResponseHeaders() { }

	// RVA: 0x2712EC0 Offset: 0x27120C0 VA: 0x182712EC0
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x2497C30 Offset: 0x2496E30 VA: 0x182497C30
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x2713E00 Offset: 0x2713000 VA: 0x182713E00
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x2712BE0 Offset: 0x2711DE0 VA: 0x182712BE0
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x248C210 Offset: 0x248B410 VA: 0x18248C210
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x2713940 Offset: 0x2712B40 VA: 0x182713940
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x2712B40 Offset: 0x2711D40 VA: 0x182712B40
	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	// RVA: 0x248C200 Offset: 0x248B400 VA: 0x18248C200
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x2713830 Offset: 0x2712A30 VA: 0x182713830
	public void set_certificateHandler(CertificateHandler value) { }

	// RVA: 0x2712E80 Offset: 0x2712080 VA: 0x182712E80
	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x2713CB0 Offset: 0x2712EB0 VA: 0x182713CB0
	public void set_timeout(int value) { }

	// RVA: 0x2712510 Offset: 0x2711710 VA: 0x182712510
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x2711F70 Offset: 0x2711170 VA: 0x182711F70
	public static UnityWebRequest Delete(string uri) { }

	// RVA: 0x2712A30 Offset: 0x2711C30 VA: 0x182712A30
	public static UnityWebRequest PostWwwForm(string uri, string form) { }

	// RVA: 0x2712F60 Offset: 0x2712160 VA: 0x182712F60
	private static void SetupPostWwwForm(UnityWebRequest request, string postData) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
public class UploadHandler : IDisposable // TypeDefIndex: 17878
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public byte[] data { get; }
	public string contentType { set; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x27145E0 Offset: 0x27137E0 VA: 0x1827145E0
	private void Release() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x2711910 Offset: 0x2710B10 VA: 0x182711910 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2714540 Offset: 0x2713740 VA: 0x182714540 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x6E6600 Offset: 0x6E5800 VA: 0x1806E6600
	public byte[] get_data() { }

	// RVA: 0x18DBE50 Offset: 0x18DB050 VA: 0x1818DBE50
	public void set_contentType(string value) { }

	// RVA: 0xB88020 Offset: 0xB87220 VA: 0x180B88020 Slot: 6
	internal virtual byte[] GetData() { }

	// RVA: 0x2714590 Offset: 0x2713790 VA: 0x182714590 Slot: 7
	internal virtual void SetContentType(string newContentType) { }

	[NativeMethod("SetContentType")]
	// RVA: 0x2714590 Offset: 0x2713790 VA: 0x182714590
	private void InternalSetContentType(string newContentType) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandlerRaw.h")]
public sealed class UploadHandlerRaw : UploadHandler // TypeDefIndex: 17879
{
	// Fields
	private NativeArray<byte> m_Payload; // 0x18

	// Methods

	// RVA: 0x2714190 Offset: 0x2713390 VA: 0x182714190
	private static IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength) { }

	// RVA: 0x27142E0 Offset: 0x27134E0 VA: 0x1827142E0
	public void .ctor(byte[] data) { }

	// RVA: 0x2714450 Offset: 0x2713650 VA: 0x182714450
	public void .ctor(NativeArray<byte> data, bool transferOwnership) { }

	// RVA: 0x2714280 Offset: 0x2713480 VA: 0x182714280 Slot: 6
	internal override byte[] GetData() { }

	// RVA: 0x27141F0 Offset: 0x27133F0 VA: 0x1827141F0 Slot: 5
	public override void Dispose() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17880
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 17881
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 17882
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(27524, AllowMultiple = False, Inherited = False)]
[Embedded]
[CompilerGenerated]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 17883
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1BDB7C0 Offset: 0x1BDA9C0 VA: 0x181BDB7C0
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(5196, AllowMultiple = False, Inherited = False)]
[Embedded]
[CompilerGenerated]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 17884
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(2, AllowMultiple = False, Inherited = False)]
[Embedded]
[CompilerGenerated]
internal sealed class NullablePublicOnlyAttribute : Attribute // TypeDefIndex: 17885
{
	// Fields
	public readonly bool IncludesInternals; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool ) { }
}

// Namespace: System
internal static class HexConverter // TypeDefIndex: 17886
{
	// Methods

	// RVA: 0x1BDB440 Offset: 0x1BDA640 VA: 0x181BDB440
	public static char ToCharUpper(int value) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(10624, Inherited = False)]
internal sealed class NotNullAttribute : Attribute // TypeDefIndex: 17887
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Text
internal static class UnicodeUtility // TypeDefIndex: 17888
{
	// Methods

	// RVA: 0x1BDD960 Offset: 0x1BDCB60 VA: 0x181BDD960
	public static uint GetScalarFromUtf16SurrogatePair(uint highSurrogateCodePoint, uint lowSurrogateCodePoint) { }

	// RVA: 0x1BDD970 Offset: 0x1BDCB70 VA: 0x181BDD970
	public static int GetUtf16SequenceLength(uint value) { }

	// RVA: 0x1BDD980 Offset: 0x1BDCB80 VA: 0x181BDD980
	public static bool IsAsciiCodePoint(uint value) { }

	// RVA: 0x1BDD990 Offset: 0x1BDCB90 VA: 0x181BDD990
	public static bool IsHighSurrogateCodePoint(uint value) { }

	// RVA: 0x10DD040 Offset: 0x10DC240 VA: 0x1810DD040
	public static bool IsInRangeInclusive(uint value, uint lowerBound, uint upperBound) { }

	// RVA: 0x1BDD9A0 Offset: 0x1BDCBA0 VA: 0x181BDD9A0
	public static bool IsLowSurrogateCodePoint(uint value) { }

	// RVA: 0x1BDD9B0 Offset: 0x1BDCBB0 VA: 0x181BDD9B0
	public static bool IsSurrogateCodePoint(uint value) { }
}

// Namespace: System.Text.Unicode
internal static class UnicodeHelpers // TypeDefIndex: 17889
{
	// Fields
	private static readonly uint[] _definedCharacterBitmapBigEndian; // 0x0

	// Properties
	private static ReadOnlySpan<byte> DefinedCharsBitmapSpan { get; }

	// Methods

	// RVA: 0x1BDCED0 Offset: 0x1BDC0D0 VA: 0x181BDCED0
	private static uint[] CreateDefinedCharacterBitmapMachineEndian() { }

	// RVA: 0x1BDD230 Offset: 0x1BDC430 VA: 0x181BDD230
	public static OperationStatus DecodeScalarValueFromUtf8(ReadOnlySpan<byte> source, out uint result, out int bytesConsumed) { }

	// RVA: 0x1BDD3D0 Offset: 0x1BDC5D0 VA: 0x181BDD3D0
	internal static ReadOnlySpan<uint> GetDefinedCharacterBitmap() { }

	// RVA: 0x1BDD4C0 Offset: 0x1BDC6C0 VA: 0x181BDD4C0
	internal static void GetUtf16SurrogatePairFromAstralScalarValue(int scalar, out char highSurrogate, out char lowSurrogate) { }

	// RVA: 0x1BDD500 Offset: 0x1BDC700 VA: 0x181BDD500
	internal static bool IsSupplementaryCodePoint(int scalar) { }

	// RVA: 0x1BDD550 Offset: 0x1BDC750 VA: 0x181BDD550
	private static ReadOnlySpan<byte> get_DefinedCharsBitmapSpan() { }

	// RVA: 0x1BDD510 Offset: 0x1BDC710 VA: 0x181BDD510
	private static void .cctor() { }
}

// Namespace: System.Text.Unicode
internal sealed class UnicodeRange // TypeDefIndex: 17890
{
	// Fields
	[CompilerGenerated]
	private int <FirstCodePoint>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Length>k__BackingField; // 0x14

	// Properties
	public int FirstCodePoint { get; set; }
	public int Length { get; set; }

	// Methods

	// RVA: 0x1BDD6E0 Offset: 0x1BDC8E0 VA: 0x181BDD6E0
	public void .ctor(int firstCodePoint, int length) { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_FirstCodePoint() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	private void set_FirstCodePoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_Length() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	private void set_Length(int value) { }

	[NullableContext(1)]
	// RVA: 0x1BDD5C0 Offset: 0x1BDC7C0 VA: 0x181BDD5C0
	public static UnicodeRange Create(char firstCharacter, char lastCharacter) { }
}

// Namespace: System.Text.Unicode
[NullableContext(1)]
[Nullable(0)]
internal static class UnicodeRanges // TypeDefIndex: 17891
{
	// Fields
	private static UnicodeRange _u0000; // 0x0

	// Properties
	public static UnicodeRange BasicLatin { get; }

	// Methods

	// RVA: 0x1BDD7C0 Offset: 0x1BDC9C0 VA: 0x181BDD7C0
	private static UnicodeRange CreateRange(ref UnicodeRange range, char first, char last) { }

	// RVA: 0x1BDD900 Offset: 0x1BDCB00 VA: 0x181BDD900
	public static UnicodeRange get_BasicLatin() { }
}

// Namespace: System.Text.Internal
[IsReadOnly]
internal struct AllowedCharactersBitmap // TypeDefIndex: 17892
{
	// Fields
	private readonly uint[] _allowedCharacters; // 0x0

	// Methods

	// RVA: 0x1BD9630 Offset: 0x1BD8830 VA: 0x181BD9630
	public static AllowedCharactersBitmap CreateNew() { }

	// RVA: 0x1BD9BF0 Offset: 0x1BD8DF0 VA: 0x181BD9BF0
	private void .ctor(uint[] allowedCharacters) { }

	// RVA: 0x1BD9520 Offset: 0x1BD8720 VA: 0x181BD9520
	public void AllowCharacter(char character) { }

	// RVA: 0x1BD9910 Offset: 0x1BD8B10 VA: 0x181BD9910
	public void ForbidCharacter(char character) { }

	// RVA: 0x1BD9950 Offset: 0x1BD8B50 VA: 0x181BD9950
	public void ForbidUndefinedCharacters() { }

	// RVA: 0x1BD9560 Offset: 0x1BD8760 VA: 0x181BD9560
	public AllowedCharactersBitmap Clone() { }

	// RVA: 0x1BD9B50 Offset: 0x1BD8D50 VA: 0x181BD9B50
	public bool IsCharacterAllowed(char character) { }

	// RVA: 0x1BD9BA0 Offset: 0x1BD8DA0 VA: 0x181BD9BA0
	public bool IsUnicodeScalarAllowed(int unicodeScalar) { }

	// RVA: 0x1BD96C0 Offset: 0x1BD88C0 VA: 0x181BD96C0
	public int FindFirstCharacterToEncode(char* text, int textLength) { }
}

// Namespace: System.Text.Encodings.Web
internal sealed class DefaultJavaScriptEncoderBasicLatin : JavaScriptEncoder // TypeDefIndex: 17893
{
	// Fields
	internal static readonly DefaultJavaScriptEncoderBasicLatin s_singleton; // 0x0
	private static readonly char[] s_b; // 0x8
	private static readonly char[] s_t; // 0x10
	private static readonly char[] s_n; // 0x18
	private static readonly char[] s_f; // 0x20
	private static readonly char[] s_r; // 0x28
	private static readonly char[] s_back; // 0x30

	// Properties
	private static ReadOnlySpan<byte> AllowList { get; }

	// Methods

	// RVA: 0x1BDB110 Offset: 0x1BDA310 VA: 0x181BDB110
	private void .ctor() { }

	// RVA: 0x1BDADA0 Offset: 0x1BD9FA0 VA: 0x181BDADA0 Slot: 6
	public override bool WillEncode(int unicodeScalar) { }

	// RVA: 0x1BDA840 Offset: 0x1BD9A40 VA: 0x181BDA840 Slot: 5
	public override int FindFirstCharacterToEncode(char* text, int textLength) { }

	// RVA: 0x1BDA6E0 Offset: 0x1BD98E0 VA: 0x181BDA6E0 Slot: 9
	public override int FindFirstCharacterToEncodeUtf8(ReadOnlySpan<byte> utf8Text) { }

	// RVA: 0x1BDAAB0 Offset: 0x1BD9CB0 VA: 0x181BDAAB0 Slot: 4
	public override bool TryEncodeUnicodeScalar(int unicodeScalar, char* buffer, int bufferLength, out int numberOfCharactersWritten) { }

	// RVA: 0x1BDB3D0 Offset: 0x1BDA5D0 VA: 0x181BDB3D0
	private static ReadOnlySpan<byte> get_AllowList() { }

	// RVA: 0x1BDA9D0 Offset: 0x1BD9BD0 VA: 0x181BDA9D0
	private static bool NeedsEscaping(char value) { }

	// RVA: 0x1BDAEE0 Offset: 0x1BDA0E0 VA: 0x181BDAEE0
	private static void .cctor() { }
}

// Namespace: System.Text.Encodings.Web
[NullableContext(1)]
[Nullable(0)]
internal abstract class HtmlEncoder : TextEncoder // TypeDefIndex: 17894
{
	// Methods

	// RVA: 0x1BDB460 Offset: 0x1BDA660 VA: 0x181BDB460
	protected void .ctor() { }
}

// Namespace: System.Text.Encodings.Web
internal sealed class DefaultHtmlEncoder : HtmlEncoder // TypeDefIndex: 17895
{
	// Fields
	private readonly AllowedCharactersBitmap _allowedCharacters; // 0xA0
	internal static readonly DefaultHtmlEncoder Singleton; // 0x0
	private static readonly char[] s_quote; // 0x8
	private static readonly char[] s_ampersand; // 0x10
	private static readonly char[] s_lessthan; // 0x18
	private static readonly char[] s_greaterthan; // 0x20

	// Methods

	// RVA: 0x1BDA5A0 Offset: 0x1BD97A0 VA: 0x181BDA5A0
	public void .ctor(TextEncoderSettings settings) { }

	// RVA: 0x1BD9C70 Offset: 0x1BD8E70 VA: 0x181BD9C70
	internal static void ForbidHtmlCharacters(AllowedCharactersBitmap allowedCharacters) { }

	// RVA: 0x1BDA170 Offset: 0x1BD9370 VA: 0x181BDA170 Slot: 6
	public override bool WillEncode(int unicodeScalar) { }

	// RVA: 0x1BD9C60 Offset: 0x1BD8E60 VA: 0x181BD9C60 Slot: 5
	public override int FindFirstCharacterToEncode(char* text, int textLength) { }

	// RVA: 0x1BD9CE0 Offset: 0x1BD8EE0 VA: 0x181BD9CE0 Slot: 4
	public override bool TryEncodeUnicodeScalar(int unicodeScalar, char* buffer, int bufferLength, out int numberOfCharactersWritten) { }

	// RVA: 0x1BDA0D0 Offset: 0x1BD92D0 VA: 0x181BDA0D0
	private static bool TryWriteEncodedScalarAsNumericEntity(int unicodeScalar, char* buffer, int bufferLength, out int numberOfCharactersWritten) { }

	// RVA: 0x1BDA210 Offset: 0x1BD9410 VA: 0x181BDA210
	private static void .cctor() { }
}

// Namespace: System.Text.Encodings.Web
[NullableContext(1)]
[Nullable(0)]
internal abstract class JavaScriptEncoder : TextEncoder // TypeDefIndex: 17896
{
	// Properties
	public static JavaScriptEncoder Default { get; }

	// Methods

	// RVA: 0x1BDB770 Offset: 0x1BDA970 VA: 0x181BDB770
	public static JavaScriptEncoder get_Default() { }

	// RVA: 0x1BDB6F0 Offset: 0x1BDA8F0 VA: 0x181BDB6F0
	protected void .ctor() { }
}

// Namespace: System.Text.Encodings.Web
internal static class JavaScriptEncoderHelper // TypeDefIndex: 17897
{
	// Methods

	// RVA: 0x1BDB4E0 Offset: 0x1BDA6E0 VA: 0x181BDB4E0
	public static bool TryWriteEncodedScalarAsNumericEntity(int unicodeScalar, char* buffer, int length, out int numberOfCharactersWritten) { }

	// RVA: 0x1BDB660 Offset: 0x1BDA860 VA: 0x181BDB660
	private static bool TryWriteEncodedSingleCharacter(int unicodeScalar, char* buffer, int length, out int numberOfCharactersWritten) { }
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct TextEncoder.AsciiNeedsEscapingData.<Data>e__FixedBuffer // TypeDefIndex: 17898
{
	// Fields
	public bool FixedElementField; // 0x0
}

// Namespace: 
private struct TextEncoder.AsciiNeedsEscapingData // TypeDefIndex: 17899
{
	// Fields
	[FixedBuffer(typeof(bool), 128)]
	public TextEncoder.AsciiNeedsEscapingData.<Data>e__FixedBuffer Data; // 0x0
}

// Namespace: System.Text.Encodings.Web
internal abstract class TextEncoder // TypeDefIndex: 17900
{
	// Fields
	private readonly byte[][] _asciiEscape; // 0x10
	private bool _isAsciiCacheInitialized; // 0x18
	private TextEncoder.AsciiNeedsEscapingData _asciiNeedsEscaping; // 0x19
	private static readonly byte[] s_noEscape; // 0x0

	// Methods

	[CLSCompliant(False)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool TryEncodeUnicodeScalar(int unicodeScalar, char* buffer, int bufferLength, out int numberOfCharactersWritten);

	[CLSCompliant(False)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract int FindFirstCharacterToEncode(char* text, int textLength);

	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool WillEncode(int unicodeScalar);

	// RVA: 0x1BDBAF0 Offset: 0x1BDACF0 VA: 0x181BDBAF0 Slot: 7
	public virtual OperationStatus EncodeUtf8(ReadOnlySpan<byte> utf8Source, Span<byte> utf8Destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = True) { }

	// RVA: 0x1BDC240 Offset: 0x1BDB440 VA: 0x181BDC240 Slot: 8
	public virtual OperationStatus Encode(ReadOnlySpan<char> source, Span<char> destination, out int charsConsumed, out int charsWritten, bool isFinalBlock = True) { }

	// RVA: 0x1BDC760 Offset: 0x1BDB960 VA: 0x181BDC760
	private int FindFirstCharacterToEncode(ReadOnlySpan<char> text) { }

	[EditorBrowsable(1)]
	// RVA: 0x1BDC5C0 Offset: 0x1BDB7C0 VA: 0x181BDC5C0 Slot: 9
	public virtual int FindFirstCharacterToEncodeUtf8(ReadOnlySpan<byte> utf8Text) { }

	// RVA: 0x1BDC920 Offset: 0x1BDBB20 VA: 0x181BDC920
	internal static bool TryCopyCharacters(char[] source, char* destination, int destinationLength, out int numberOfCharactersWritten) { }

	// RVA: 0x1BDC990 Offset: 0x1BDBB90 VA: 0x181BDC990
	internal static bool TryWriteScalarAsChar(int unicodeScalar, char* destination, int destinationLength, out int numberOfCharactersWritten) { }

	// RVA: 0x1BDC7F0 Offset: 0x1BDB9F0 VA: 0x181BDC7F0
	private byte[] GetAsciiEncoding(byte value) { }

	// RVA: 0x1BDC8B0 Offset: 0x1BDBAB0 VA: 0x181BDC8B0
	private void InitializeAsciiCache() { }

	// RVA: 0x1BDBAE0 Offset: 0x1BDACE0 VA: 0x181BDBAE0
	private bool DoesAsciiNeedEncoding(uint value) { }

	// RVA: 0x1BDCE80 Offset: 0x1BDC080 VA: 0x181BDCE80
	protected void .ctor() { }

	// RVA: 0x1BDCDD0 Offset: 0x1BDBFD0 VA: 0x181BDCDD0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1BDC9B0 Offset: 0x1BDBBB0 VA: 0x181BDC9B0
	private OperationStatus <Encode>g__EncodeCore|15_0(ReadOnlySpan<char> source, Span<char> destination, out int charsConsumed, out int charsWritten, bool isFinalBlock) { }
}

// Namespace: System.Text.Encodings.Web
[Nullable(0)]
[NullableContext(1)]
internal class TextEncoderSettings // TypeDefIndex: 17901
{
	// Fields
	private readonly AllowedCharactersBitmap _allowedCharactersBitmap; // 0x10

	// Methods

	// RVA: 0x1BDB9D0 Offset: 0x1BDABD0 VA: 0x181BDB9D0
	public void .ctor(UnicodeRange[] allowedRanges) { }

	// RVA: 0x1BDB840 Offset: 0x1BDAA40 VA: 0x181BDB840 Slot: 4
	public virtual void AllowRange(UnicodeRange range) { }

	// RVA: 0x1BDB900 Offset: 0x1BDAB00 VA: 0x181BDB900 Slot: 5
	public virtual void AllowRanges(UnicodeRange[] ranges) { }

	// RVA: 0x1BDB9C0 Offset: 0x1BDABC0 VA: 0x181BDB9C0
	internal AllowedCharactersBitmap GetAllowedCharacters() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 17902
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8192 // TypeDefIndex: 17903
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 17904
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8192 8B30AFDCF07C4ABDFE0FAF65F79FC40A2E9AC497C42B1BA5C996BDFB3F6EC2F6 /*Metadata offset 0x8FF520*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 EFE627BE173681E4F55F4133AB4C1782E26D1080CB80CDB6BFAAC81416A2714E /*Metadata offset 0x901528*/; // 0x2000
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17905
{}

// Namespace: UnityEngine
public enum ForceMode // TypeDefIndex: 17906
{
	// Fields
	public int value__; // 0x0
	public const ForceMode Force = 0;
	public const ForceMode Acceleration = 5;
	public const ForceMode Impulse = 1;
	public const ForceMode VelocityChange = 2;
}

// Namespace: UnityEngine
[Flags]
public enum MeshColliderCookingOptions // TypeDefIndex: 17907
{
	// Fields
	public int value__; // 0x0
	public const MeshColliderCookingOptions None = 0;
	[Obsolete("No longer used because the problem this was trying to solve is gone since Unity 2018.3", True)]
	public const MeshColliderCookingOptions InflateConvexMesh = 1;
	public const MeshColliderCookingOptions CookForFasterSimulation = 2;
	public const MeshColliderCookingOptions EnableMeshCleaning = 4;
	public const MeshColliderCookingOptions WeldColocatedVertices = 8;
	public const MeshColliderCookingOptions UseFastMidphase = 16;
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public class ControllerColliderHit // TypeDefIndex: 17908
{
	// Fields
	internal CharacterController m_Controller; // 0x10
	internal Collider m_Collider; // 0x18
	internal Vector3 m_Point; // 0x20
	internal Vector3 m_Normal; // 0x2C
	internal Vector3 m_MoveDirection; // 0x38
	internal float m_MoveLength; // 0x44
	internal int m_Push; // 0x48
}

// Namespace: UnityEngine
public class Collision // TypeDefIndex: 17909
{
	// Fields
	private ContactPairHeader m_Header; // 0x10
	private ContactPair m_Pair; // 0x38
	private bool m_Flipped; // 0x60
	private ContactPoint[] m_LegacyContacts; // 0x68

	// Properties
	internal bool Flipped { set; }

	// Methods

	// RVA: 0x4EE2A0 Offset: 0x4ED4A0 VA: 0x1804EE2A0
	internal void set_Flipped(bool value) { }

	// RVA: 0x24F23F0 Offset: 0x24F15F0 VA: 0x1824F23F0
	public void .ctor() { }

	// RVA: 0x24F2300 Offset: 0x24F1500 VA: 0x1824F2300
	internal void .ctor(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x24F22B0 Offset: 0x24F14B0 VA: 0x1824F22B0
	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }
}

// Namespace: UnityEngine
public enum CollisionFlags // TypeDefIndex: 17910
{
	// Fields
	public int value__; // 0x0
	public const CollisionFlags None = 0;
	public const CollisionFlags Sides = 1;
	public const CollisionFlags Above = 2;
	public const CollisionFlags Below = 4;
	public const CollisionFlags CollidedSides = 1;
	public const CollisionFlags CollidedAbove = 2;
	public const CollisionFlags CollidedBelow = 4;
}

// Namespace: UnityEngine
public enum QueryTriggerInteraction // TypeDefIndex: 17911
{
	// Fields
	public int value__; // 0x0
	public const QueryTriggerInteraction UseGlobal = 0;
	public const QueryTriggerInteraction Ignore = 1;
	public const QueryTriggerInteraction Collide = 2;
}

// Namespace: 
public sealed class Physics.ContactEventDelegate : MulticastDelegate // TypeDefIndex: 17912
{
	// Methods

	// RVA: 0x11BAFB0 Offset: 0x11BA1B0 VA: 0x1811BAFB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x44A010 Offset: 0x449210 VA: 0x18044A010 Slot: 13
	public virtual void Invoke(PhysicsScene scene, NativeArray.ReadOnly<ContactPairHeader> headerArray) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/PhysicsManager.h")]
[StaticAccessor("GetPhysicsManager()", 0)]
public class Physics // TypeDefIndex: 17913
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Physics.ContactEventDelegate ContactEvent; // 0x10
	private static readonly Collision s_ReusableCollision; // 0x18

	// Properties
	public static bool invokeCollisionCallbacks { get; }
	[NativeProperty("DefaultPhysicsSceneHandle", True, 0, True)]
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool reuseCollisionCallbacks { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24F34A0 Offset: 0x24F26A0 VA: 0x1824F34A0
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	// RVA: 0x24F6190 Offset: 0x24F5390 VA: 0x1824F6190
	public static bool get_invokeCollisionCallbacks() { }

	// RVA: 0x24F6120 Offset: 0x24F5320 VA: 0x1824F6120
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x24F4E10 Offset: 0x24F4010 VA: 0x1824F4E10
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x24F4AA0 Offset: 0x24F3CA0 VA: 0x1824F4AA0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24F5860 Offset: 0x24F4A60 VA: 0x1824F5860
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x24F5540 Offset: 0x24F4740 VA: 0x1824F5540
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x24F5460 Offset: 0x24F4660 VA: 0x1824F5460
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x24F4EE0 Offset: 0x24F40E0 VA: 0x1824F4EE0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24F49D0 Offset: 0x24F3BD0 VA: 0x1824F49D0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x24F4C40 Offset: 0x24F3E40 VA: 0x1824F4C40
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x24F5390 Offset: 0x24F4590 VA: 0x1824F5390
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x24F4FB0 Offset: 0x24F41B0 VA: 0x1824F4FB0
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24F5140 Offset: 0x24F4340 VA: 0x1824F5140
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x24F59F0 Offset: 0x24F4BF0 VA: 0x1824F59F0
	public static bool Raycast(Ray ray) { }

	// RVA: 0x24F5780 Offset: 0x24F4980 VA: 0x1824F5780
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x24F4D10 Offset: 0x24F3F10 VA: 0x1824F4D10
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24F52D0 Offset: 0x24F44D0 VA: 0x1824F52D0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x24F56C0 Offset: 0x24F48C0 VA: 0x1824F56C0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("RaycastAll")]
	// RVA: 0x24F3400 Offset: 0x24F2600 VA: 0x1824F3400
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x24F3930 Offset: 0x24F2B30 VA: 0x1824F3930
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x24F3880 Offset: 0x24F2A80 VA: 0x1824F3880
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24F3BA0 Offset: 0x24F2DA0 VA: 0x1824F3BA0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x24F3C40 Offset: 0x24F2E40 VA: 0x1824F3C40
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x24F3AF0 Offset: 0x24F2CF0 VA: 0x1824F3AF0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x24F37E0 Offset: 0x24F29E0 VA: 0x1824F37E0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24F3740 Offset: 0x24F2940 VA: 0x1824F3740
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x24F3CE0 Offset: 0x24F2EE0 VA: 0x1824F3CE0
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x24F4520 Offset: 0x24F3720 VA: 0x1824F4520
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x24F4070 Offset: 0x24F3270 VA: 0x1824F4070
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24F3D70 Offset: 0x24F2F70 VA: 0x1824F3D70
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x24F3EF0 Offset: 0x24F30F0 VA: 0x1824F3EF0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x24F46B0 Offset: 0x24F38B0 VA: 0x1824F46B0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x24F4390 Offset: 0x24F3590 VA: 0x1824F4390
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24F4200 Offset: 0x24F3400 VA: 0x1824F4200
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x24F4840 Offset: 0x24F3A40 VA: 0x1824F4840
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	// RVA: 0x24F61C0 Offset: 0x24F53C0 VA: 0x1824F61C0
	public static bool get_reuseCollisionCallbacks() { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x24F3140 Offset: 0x24F2340 VA: 0x1824F3140
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x24F3100 Offset: 0x24F2300 VA: 0x1824F3100
	internal static Component GetBodyByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x24F5F60 Offset: 0x24F5160 VA: 0x1824F5F60
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x24F6000 Offset: 0x24F5200 VA: 0x1824F6000
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x24F5FB0 Offset: 0x24F51B0 VA: 0x1824F5FB0
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	[RequiredByNativeCode]
	// RVA: 0x24F35A0 Offset: 0x24F27A0 VA: 0x1824F35A0
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	// RVA: 0x24F5B80 Offset: 0x24F4D80 VA: 0x1824F5B80
	private static void ReportContacts(NativeArray.ReadOnly<ContactPairHeader> array) { }

	// RVA: 0x24F3180 Offset: 0x24F2380 VA: 0x1824F3180
	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x24F6050 Offset: 0x24F5250 VA: 0x1824F6050
	private static void .cctor() { }

	// RVA: 0x24F60E0 Offset: 0x24F52E0 VA: 0x1824F60E0
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x24F3390 Offset: 0x24F2590 VA: 0x1824F3390
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }
}

// Namespace: UnityEngine
public struct ModifiableContactPair // TypeDefIndex: 17914
{
	// Fields
	private IntPtr actor; // 0x0
	private IntPtr otherActor; // 0x8
	private IntPtr shape; // 0x10
	private IntPtr otherShape; // 0x18
	public Quaternion rotation; // 0x20
	public Vector3 position; // 0x30
	public Quaternion otherRotation; // 0x3C
	public Vector3 otherPosition; // 0x4C
	private int numContacts; // 0x58
	private IntPtr contacts; // 0x60
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("PhysicsScriptingClasses.h")]
[NativeHeader("Modules/Physics/RaycastHit.h")]
[NativeHeader("Runtime/Interfaces/IRaycast.h")]
public struct RaycastHit // TypeDefIndex: 17915
{
	// Fields
	[NativeName("point")]
	internal Vector3 m_Point; // 0x0
	[NativeName("normal")]
	internal Vector3 m_Normal; // 0xC
	[NativeName("faceID")]
	internal uint m_FaceID; // 0x18
	[NativeName("distance")]
	internal float m_Distance; // 0x1C
	[NativeName("uv")]
	internal Vector2 m_UV; // 0x20
	[NativeName("collider")]
	internal int m_Collider; // 0x28

	// Properties
	public Collider collider { get; }
	public Vector3 point { get; }
	public Vector3 normal { get; }
	public float distance { get; }

	// Methods

	// RVA: 0x24F61F0 Offset: 0x24F53F0 VA: 0x1824F61F0
	public Collider get_collider() { }

	// RVA: 0x244D260 Offset: 0x244C460 VA: 0x18244D260
	public Vector3 get_point() { }

	// RVA: 0x244D280 Offset: 0x244C480 VA: 0x18244D280
	public Vector3 get_normal() { }

	// RVA: 0x24E28C0 Offset: 0x24E1AC0 VA: 0x1824E28C0
	public float get_distance() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component // TypeDefIndex: 17916
{
	// Properties
	public Vector3 velocity { set; }

	// Methods

	// RVA: 0x24F63A0 Offset: 0x24F55A0 VA: 0x1824F63A0
	public void set_velocity(Vector3 value) { }

	// RVA: 0x24F62F0 Offset: 0x24F54F0 VA: 0x1824F62F0
	public void AddForce(Vector3 force, ForceMode mode) { }

	// RVA: 0x24F6350 Offset: 0x24F5550 VA: 0x1824F6350
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x24F6290 Offset: 0x24F5490 VA: 0x1824F6290
	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/Collider.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode]
public class Collider : Component // TypeDefIndex: 17917
{
	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/CharacterController.h")]
public class CharacterController : Collider // TypeDefIndex: 17918
{
	// Methods

	// RVA: 0x24F2260 Offset: 0x24F1460 VA: 0x1824F2260
	public CollisionFlags Move(Vector3 motion) { }

	// RVA: 0x24F2210 Offset: 0x24F1410 VA: 0x1824F2210
	private CollisionFlags Move_Injected(ref Vector3 motion) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
[NativeHeader("Modules/Physics/MeshCollider.h")]
[RequiredByNativeCode]
public class MeshCollider : Collider // TypeDefIndex: 17919
{
	// Properties
	public Mesh sharedMesh { get; set; }
	public bool convex { get; set; }
	public MeshColliderCookingOptions cookingOptions { get; set; }
	[Obsolete("Configuring smooth sphere collisions is no longer needed.", True)]
	[EditorBrowsable(1)]
	public bool smoothSphereCollisions { get; set; }
	[Obsolete("MeshCollider.skinWidth is no longer used.")]
	public float skinWidth { get; set; }
	[Obsolete("MeshCollider.inflateMesh is no longer supported. The new cooking algorithm doesn't need inflation to be used.")]
	public bool inflateMesh { get; set; }

	// Methods

	// RVA: 0x24F27E0 Offset: 0x24F19E0 VA: 0x1824F27E0
	public Mesh get_sharedMesh() { }

	// RVA: 0x24F28C0 Offset: 0x24F1AC0 VA: 0x1824F28C0
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x24F2760 Offset: 0x24F1960 VA: 0x1824F2760
	public bool get_convex() { }

	// RVA: 0x24F2830 Offset: 0x24F1A30 VA: 0x1824F2830
	public void set_convex(bool value) { }

	// RVA: 0x24F27A0 Offset: 0x24F19A0 VA: 0x1824F27A0
	public MeshColliderCookingOptions get_cookingOptions() { }

	// RVA: 0x24F2880 Offset: 0x24F1A80 VA: 0x1824F2880
	public void set_cookingOptions(MeshColliderCookingOptions value) { }

	// RVA: 0xD72460 Offset: 0xD71660 VA: 0x180D72460
	public bool get_smoothSphereCollisions() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_smoothSphereCollisions(bool value) { }

	// RVA: 0x24F2820 Offset: 0x24F1A20 VA: 0x1824F2820
	public float get_skinWidth() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_skinWidth(float value) { }

	// RVA: 0xA641B0 Offset: 0xA633B0 VA: 0x180A641B0
	public bool get_inflateMesh() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_inflateMesh(bool value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/CapsuleCollider.h")]
[RequiredByNativeCode]
public class CapsuleCollider : Collider // TypeDefIndex: 17920
{}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/BoxCollider.h")]
[RequiredByNativeCode]
public class BoxCollider : Collider // TypeDefIndex: 17921
{
	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	[Obsolete("Use BoxCollider.size instead. (UnityUpgradable) -> size")]
	public Vector3 extents { get; set; }

	// Methods

	// RVA: 0x24F1EE0 Offset: 0x24F10E0 VA: 0x1824F1EE0
	public Vector3 get_center() { }

	// RVA: 0x24F20B0 Offset: 0x24F12B0 VA: 0x1824F20B0
	public void set_center(Vector3 value) { }

	// RVA: 0x24F2010 Offset: 0x24F1210 VA: 0x1824F2010
	public Vector3 get_size() { }

	// RVA: 0x24F21C0 Offset: 0x24F13C0 VA: 0x1824F21C0
	public void set_size(Vector3 value) { }

	// RVA: 0x24F1F30 Offset: 0x24F1130 VA: 0x1824F1F30
	public Vector3 get_extents() { }

	// RVA: 0x24F2100 Offset: 0x24F1300 VA: 0x1824F2100
	public void set_extents(Vector3 value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x24F1E90 Offset: 0x24F1090 VA: 0x1824F1E90
	private void get_center_Injected(out Vector3 ret) { }

	// RVA: 0x24F2060 Offset: 0x24F1260 VA: 0x1824F2060
	private void set_center_Injected(ref Vector3 value) { }

	// RVA: 0x24F1FC0 Offset: 0x24F11C0 VA: 0x1824F1FC0
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x24F2170 Offset: 0x24F1370 VA: 0x1824F2170
	private void set_size_Injected(ref Vector3 value) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/Physics/SphereCollider.h")]
public class SphereCollider : Collider // TypeDefIndex: 17922
{}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/MessageParameters.h")]
[UsedByNativeCode]
public struct ContactPoint // TypeDefIndex: 17923
{
	// Fields
	internal Vector3 m_Point; // 0x0
	internal Vector3 m_Normal; // 0xC
	internal Vector3 m_Impulse; // 0x18
	internal int m_ThisColliderInstanceID; // 0x24
	internal int m_OtherColliderInstanceID; // 0x28
	internal float m_Separation; // 0x2C
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 17924
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x24F3030 Offset: 0x24F2230 VA: 0x1824F3030 Slot: 3
	public override string ToString() { }

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24F2910 Offset: 0x24F1B10 VA: 0x1824F2910 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x244E010 Offset: 0x244D210 VA: 0x18244E010 Slot: 4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x24F2D70 Offset: 0x24F1F70 VA: 0x1824F2D70
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("RaycastTest")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x24F2AE0 Offset: 0x24F1CE0 VA: 0x1824F2AE0
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x24F2EC0 Offset: 0x24F20C0 VA: 0x1824F2EC0
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("Raycast")]
	// RVA: 0x24F2BC0 Offset: 0x24F1DC0 VA: 0x1824F2BC0
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x24F2C30 Offset: 0x24F1E30 VA: 0x1824F2C30
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("RaycastNonAlloc")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x24F2A00 Offset: 0x24F1C00 VA: 0x1824F2A00
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x24F2A70 Offset: 0x24F1C70 VA: 0x1824F2A70
	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x24F2B50 Offset: 0x24F1D50 VA: 0x1824F2B50
	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x24F2990 Offset: 0x24F1B90 VA: 0x1824F2990
	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }
}

// Namespace: UnityEngine
[IsReadOnly]
public struct ContactPairHeader // TypeDefIndex: 17925
{
	// Fields
	internal readonly int m_BodyID; // 0x0
	internal readonly int m_OtherBodyID; // 0x4
	internal readonly IntPtr m_StartPtr; // 0x8
	internal readonly uint m_NbPairs; // 0x10
	internal readonly CollisionPairHeaderFlags m_Flags; // 0x14
	internal readonly Vector3 m_RelativeVelocity; // 0x18

	// Properties
	public Component Body { get; }
	public Component OtherBody { get; }
	internal bool HasRemovedBody { get; }

	// Methods

	// RVA: 0x24F24D0 Offset: 0x24F16D0 VA: 0x1824F24D0
	public Component get_Body() { }

	// RVA: 0x24F2560 Offset: 0x24F1760 VA: 0x1824F2560
	public Component get_OtherBody() { }

	// RVA: 0x24F2540 Offset: 0x24F1740 VA: 0x1824F2540
	internal bool get_HasRemovedBody() { }

	// RVA: 0x24F24C0 Offset: 0x24F16C0 VA: 0x1824F24C0
	public ref ContactPair GetContactPair(int index) { }

	// RVA: 0x24F2440 Offset: 0x24F1640 VA: 0x1824F2440
	internal ContactPair* GetContactPair_Internal(int index) { }
}

// Namespace: UnityEngine
[IsReadOnly]
[UsedByNativeCode]
public struct ContactPair // TypeDefIndex: 17926
{
	// Fields
	internal readonly int m_ColliderID; // 0x0
	internal readonly int m_OtherColliderID; // 0x4
	internal readonly IntPtr m_StartPtr; // 0x8
	internal readonly uint m_NbPoints; // 0x10
	internal readonly CollisionPairFlags m_Flags; // 0x14
	internal readonly CollisionPairEventFlags m_Events; // 0x16
	internal readonly Vector3 m_ImpulseSum; // 0x18

	// Properties
	public Collider Collider { get; }
	public Collider OtherCollider { get; }
	public bool IsCollisionEnter { get; }
	public bool IsCollisionExit { get; }
	public bool IsCollisionStay { get; }
	internal bool HasRemovedCollider { get; }

	// Methods

	// RVA: 0x24F2630 Offset: 0x24F1830 VA: 0x1824F2630
	public Collider get_Collider() { }

	// RVA: 0x24F26E0 Offset: 0x24F18E0 VA: 0x1824F26E0
	public Collider get_OtherCollider() { }

	// RVA: 0x24F26B0 Offset: 0x24F18B0 VA: 0x1824F26B0
	public bool get_IsCollisionEnter() { }

	// RVA: 0x24F26C0 Offset: 0x24F18C0 VA: 0x1824F26C0
	public bool get_IsCollisionExit() { }

	// RVA: 0x24F26D0 Offset: 0x24F18D0 VA: 0x1824F26D0
	public bool get_IsCollisionStay() { }

	// RVA: 0x24F2540 Offset: 0x24F1740 VA: 0x1824F2540
	internal bool get_HasRemovedCollider() { }

	// RVA: 0x24F25D0 Offset: 0x24F17D0 VA: 0x1824F25D0
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	// RVA: 0x24F25D0 Offset: 0x24F17D0 VA: 0x1824F25D0
	private static int ExtractContactsArray_Injected(ref ContactPair _unity_self, ContactPoint[] managedContainer, bool flipped) { }
}

// Namespace: UnityEngine
internal enum CollisionPairHeaderFlags // TypeDefIndex: 17927
{
	// Fields
	public ushort value__; // 0x0
	public const CollisionPairHeaderFlags RemovedActor = 1;
	public const CollisionPairHeaderFlags RemovedOtherActor = 2;
}

// Namespace: UnityEngine
internal enum CollisionPairFlags // TypeDefIndex: 17928
{
	// Fields
	public ushort value__; // 0x0
	public const CollisionPairFlags RemovedShape = 1;
	public const CollisionPairFlags RemovedOtherShape = 2;
	public const CollisionPairFlags ActorPairHasFirstTouch = 4;
	public const CollisionPairFlags ActorPairLostTouch = 8;
	public const CollisionPairFlags InternalHasImpulses = 16;
	public const CollisionPairFlags InternalContactsAreFlipped = 32;
}

// Namespace: UnityEngine
internal enum CollisionPairEventFlags // TypeDefIndex: 17929
{
	// Fields
	public ushort value__; // 0x0
	public const CollisionPairEventFlags SolveContacts = 1;
	public const CollisionPairEventFlags ModifyContacts = 2;
	public const CollisionPairEventFlags NotifyTouchFound = 4;
	public const CollisionPairEventFlags NotifyTouchPersists = 8;
	public const CollisionPairEventFlags NotifyTouchLost = 16;
	public const CollisionPairEventFlags NotifyTouchCCD = 32;
	public const CollisionPairEventFlags NotifyThresholdForceFound = 64;
	public const CollisionPairEventFlags NotifyThresholdForcePersists = 128;
	public const CollisionPairEventFlags NotifyThresholdForceLost = 256;
	public const CollisionPairEventFlags NotifyContactPoint = 512;
	public const CollisionPairEventFlags DetectDiscreteContact = 1024;
	public const CollisionPairEventFlags DetectCCDContact = 2048;
	public const CollisionPairEventFlags PreSolverVelocity = 4096;
	public const CollisionPairEventFlags PostSolverVelocity = 8192;
	public const CollisionPairEventFlags ContactEventPose = 16384;
	public const CollisionPairEventFlags NextFree = 32768;
	public const CollisionPairEventFlags ContactDefault = 1025;
	public const CollisionPairEventFlags TriggerDefault = 1044;
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17930
{}

// Namespace: UnityEngine
public enum AudioDataLoadState // TypeDefIndex: 17931
{
	// Fields
	public int value__; // 0x0
	public const AudioDataLoadState Unloaded = 0;
	public const AudioDataLoadState Loading = 1;
	public const AudioDataLoadState Loaded = 2;
	public const AudioDataLoadState Failed = 3;
}

// Namespace: UnityEngine
public enum AudioClipLoadType // TypeDefIndex: 17932
{
	// Fields
	public int value__; // 0x0
	public const AudioClipLoadType DecompressOnLoad = 0;
	public const AudioClipLoadType CompressedInMemory = 1;
	public const AudioClipLoadType Streaming = 2;
}

// Namespace: UnityEngine
public enum AudioVelocityUpdateMode // TypeDefIndex: 17933
{
	// Fields
	public int value__; // 0x0
	public const AudioVelocityUpdateMode Auto = 0;
	public const AudioVelocityUpdateMode Fixed = 1;
	public const AudioVelocityUpdateMode Dynamic = 2;
}

// Namespace: UnityEngine
public enum FFTWindow // TypeDefIndex: 17934
{
	// Fields
	public int value__; // 0x0
	public const FFTWindow Rectangular = 0;
	public const FFTWindow Triangle = 1;
	public const FFTWindow Hamming = 2;
	public const FFTWindow Hanning = 3;
	public const FFTWindow Blackman = 4;
	public const FFTWindow BlackmanHarris = 5;
}

// Namespace: UnityEngine
public enum AudioRolloffMode // TypeDefIndex: 17935
{
	// Fields
	public int value__; // 0x0
	public const AudioRolloffMode Logarithmic = 0;
	public const AudioRolloffMode Linear = 1;
	public const AudioRolloffMode Custom = 2;
}

// Namespace: UnityEngine
public enum AudioSourceCurveType // TypeDefIndex: 17936
{
	// Fields
	public int value__; // 0x0
	public const AudioSourceCurveType CustomRolloff = 0;
	public const AudioSourceCurveType SpatialBlend = 1;
	public const AudioSourceCurveType ReverbZoneMix = 2;
	public const AudioSourceCurveType Spread = 3;
}

// Namespace: 
public sealed class AudioSettings.AudioConfigurationChangeHandler : MulticastDelegate // TypeDefIndex: 17937
{
	// Methods

	// RVA: 0x46C600 Offset: 0x46B800 VA: 0x18046C600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(bool deviceWasChanged) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("GetAudioManager()", 0)]
public sealed class AudioSettings // TypeDefIndex: 17938
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action OnAudioSystemShuttingDown; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action OnAudioSystemStartedUp; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2447D20 Offset: 0x2446F20 VA: 0x182447D20
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x2447D80 Offset: 0x2446F80 VA: 0x182447D80
	internal static void InvokeOnAudioSystemShuttingDown() { }

	[RequiredByNativeCode]
	// RVA: 0x2447DD0 Offset: 0x2446FD0 VA: 0x182447DD0
	internal static void InvokeOnAudioSystemStartedUp() { }
}

// Namespace: 
public sealed class AudioClip.PCMReaderCallback : MulticastDelegate // TypeDefIndex: 17939
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(float[] data) { }
}

// Namespace: 
public sealed class AudioClip.PCMSetPositionCallback : MulticastDelegate // TypeDefIndex: 17940
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(int position) { }
}

// Namespace: UnityEngine
[StaticAccessor("AudioClipBindings", 2)]
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
public sealed class AudioClip : Object // TypeDefIndex: 17941
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Properties
	[NativeProperty("LengthSec")]
	public float length { get; }
	[NativeProperty("SampleCount")]
	public int samples { get; }
	[NativeProperty("ChannelCount")]
	public int channels { get; }
	public int frequency { get; }
	[Obsolete("Use AudioClip.loadState instead to get more detailed information about the loading process.")]
	public bool isReadyToPlay { get; }
	public AudioClipLoadType loadType { get; }
	public bool preloadAudioData { get; }
	public bool ambisonic { get; }
	public bool loadInBackground { get; }
	public AudioDataLoadState loadState { get; }

	// Methods

	// RVA: 0x2447630 Offset: 0x2446830 VA: 0x182447630
	private void .ctor() { }

	// RVA: 0x2447210 Offset: 0x2446410 VA: 0x182447210
	private static bool GetData(AudioClip clip, [Out] float[] data, int numSamples, int samplesOffset) { }

	// RVA: 0x2447580 Offset: 0x2446780 VA: 0x182447580
	private static bool SetData(AudioClip clip, float[] data, int numsamples, int samplesOffset) { }

	// RVA: 0x2446BE0 Offset: 0x2445DE0 VA: 0x182446BE0
	private static AudioClip Construct_Internal() { }

	// RVA: 0x2447280 Offset: 0x2446480 VA: 0x182447280
	private string GetName() { }

	// RVA: 0x2446C10 Offset: 0x2445E10 VA: 0x182446C10
	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x24478D0 Offset: 0x2446AD0 VA: 0x1824478D0
	public float get_length() { }

	// RVA: 0x2447A10 Offset: 0x2446C10 VA: 0x182447A10
	public int get_samples() { }

	// RVA: 0x2447810 Offset: 0x2446A10 VA: 0x182447810
	public int get_channels() { }

	// RVA: 0x2447850 Offset: 0x2446A50 VA: 0x182447850
	public int get_frequency() { }

	[NativeName("ReadyToPlay")]
	// RVA: 0x2447890 Offset: 0x2446A90 VA: 0x182447890
	public bool get_isReadyToPlay() { }

	// RVA: 0x2447990 Offset: 0x2446B90 VA: 0x182447990
	public AudioClipLoadType get_loadType() { }

	// RVA: 0x2447300 Offset: 0x2446500 VA: 0x182447300
	public bool LoadAudioData() { }

	// RVA: 0x24475F0 Offset: 0x24467F0 VA: 0x1824475F0
	public bool UnloadAudioData() { }

	// RVA: 0x24479D0 Offset: 0x2446BD0 VA: 0x1824479D0
	public bool get_preloadAudioData() { }

	// RVA: 0x24477D0 Offset: 0x24469D0 VA: 0x1824477D0
	public bool get_ambisonic() { }

	// RVA: 0x2447910 Offset: 0x2446B10 VA: 0x182447910
	public bool get_loadInBackground() { }

	[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
	// RVA: 0x2447950 Offset: 0x2446B50 VA: 0x182447950
	public AudioDataLoadState get_loadState() { }

	// RVA: 0x24470A0 Offset: 0x24462A0 VA: 0x1824470A0
	public bool GetData(float[] data, int offsetSamples) { }

	// RVA: 0x2447340 Offset: 0x2446540 VA: 0x182447340
	public bool SetData(float[] data, int offsetSamples) { }

	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	// RVA: 0x2447070 Offset: 0x2446270 VA: 0x182447070
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream) { }

	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	// RVA: 0x2446C80 Offset: 0x2445E80 VA: 0x182446C80
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	// RVA: 0x2446CE0 Offset: 0x2445EE0 VA: 0x182446CE0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	// RVA: 0x2447040 Offset: 0x2446240 VA: 0x182447040
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x2446CB0 Offset: 0x2445EB0 VA: 0x182446CB0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	// RVA: 0x2446D20 Offset: 0x2445F20 VA: 0x182446D20
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	[CompilerGenerated]
	// RVA: 0x2447690 Offset: 0x2446890 VA: 0x182447690
	private void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGenerated]
	// RVA: 0x2447A50 Offset: 0x2446C50 VA: 0x182447A50
	private void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGenerated]
	// RVA: 0x2447730 Offset: 0x2446930 VA: 0x182447730
	private void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[CompilerGenerated]
	// RVA: 0x2447AF0 Offset: 0x2446CF0 VA: 0x182447AF0
	private void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[RequiredByNativeCode]
	// RVA: 0x24472C0 Offset: 0x24464C0 VA: 0x1824472C0
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCode]
	// RVA: 0x24472E0 Offset: 0x24464E0 VA: 0x1824472E0
	private void InvokePCMSetPositionCallback_Internal(int position) { }
}

// Namespace: UnityEngine
public class AudioBehaviour : Behaviour // TypeDefIndex: 17942
{
	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioListenerBindings", 2)]
public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 17943
{}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", 2)]
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 17944
{
	// Properties
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativeProperty("SecPosition")]
	public float time { get; set; }
	[NativeProperty("SamplePosition")]
	public int timeSamples { get; set; }
	[NativeProperty("AudioClip")]
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool isVirtual { get; }
	public bool loop { get; set; }
	public bool ignoreListenerVolume { get; set; }
	public bool playOnAwake { get; set; }
	public bool ignoreListenerPause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
	[NativeProperty("StereoPan")]
	public float panStereo { get; set; }
	[NativeProperty("SpatialBlendMix")]
	public float spatialBlend { get; set; }
	public bool spatialize { get; set; }
	public bool spatializePostEffects { get; set; }
	public float reverbZoneMix { get; set; }
	public bool bypassEffects { get; set; }
	public bool bypassListenerEffects { get; set; }
	public bool bypassReverbZones { get; set; }
	public float dopplerLevel { get; set; }
	public float spread { get; set; }
	public int priority { get; set; }
	public bool mute { get; set; }
	public float minDistance { get; set; }
	public float maxDistance { get; set; }
	public AudioRolloffMode rolloffMode { get; set; }
	[Obsolete("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float minVolume { get; set; }
	[Obsolete("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float maxVolume { get; set; }
	[Obsolete("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float rolloffFactor { get; set; }

	// Methods

	// RVA: 0x2447FA0 Offset: 0x24471A0 VA: 0x182447FA0
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x2448890 Offset: 0x2447A90 VA: 0x182448890
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x2448490 Offset: 0x2447690 VA: 0x182448490
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x2448760 Offset: 0x2447960 VA: 0x182448760
	private void Play(double delay) { }

	// RVA: 0x24484E0 Offset: 0x24476E0 VA: 0x1824484E0
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x2448A10 Offset: 0x2447C10 VA: 0x182448A10
	private void Stop(bool stopOneShots) { }

	[NativeThrows]
	// RVA: 0x2448840 Offset: 0x2447A40 VA: 0x182448840
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x2447E70 Offset: 0x2447070 VA: 0x182447E70
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x2447EB0 Offset: 0x24470B0 VA: 0x182447EB0
	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrows]
	// RVA: 0x2448030 Offset: 0x2447230 VA: 0x182448030
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x2449240 Offset: 0x2448440 VA: 0x182449240
	public float get_volume() { }

	// RVA: 0x2449AE0 Offset: 0x2448CE0 VA: 0x182449AE0
	public void set_volume(float value) { }

	// RVA: 0x2447FA0 Offset: 0x24471A0 VA: 0x182447FA0
	public float get_pitch() { }

	// RVA: 0x2448890 Offset: 0x2447A90 VA: 0x182448890
	public void set_pitch(float value) { }

	// RVA: 0x24491C0 Offset: 0x24483C0 VA: 0x1824491C0
	public float get_time() { }

	// RVA: 0x2449A50 Offset: 0x2448C50 VA: 0x182449A50
	public void set_time(float value) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2449180 Offset: 0x2448380 VA: 0x182449180
	public int get_timeSamples() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2449A10 Offset: 0x2448C10 VA: 0x182449A10
	public void set_timeSamples(int value) { }

	// RVA: 0x2448B60 Offset: 0x2447D60 VA: 0x182448B60
	public AudioClip get_clip() { }

	// RVA: 0x2449370 Offset: 0x2448570 VA: 0x182449370
	public void set_clip(AudioClip value) { }

	// RVA: 0x2448EA0 Offset: 0x24480A0 VA: 0x182448EA0
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x24496B0 Offset: 0x24488B0 VA: 0x1824496B0
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocs]
	// RVA: 0x24487B0 Offset: 0x24479B0 VA: 0x1824487B0
	public void Play() { }

	// RVA: 0x2448490 Offset: 0x2447690 VA: 0x182448490
	public void Play(ulong delay) { }

	// RVA: 0x2448420 Offset: 0x2447620 VA: 0x182448420
	public void PlayDelayed(float delay) { }

	// RVA: 0x2448700 Offset: 0x2447900 VA: 0x182448700
	public void PlayScheduled(double time) { }

	[ExcludeFromDocs]
	// RVA: 0x2448540 Offset: 0x2447740 VA: 0x182448540
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x2448620 Offset: 0x2447820 VA: 0x182448620
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x2448930 Offset: 0x2447B30 VA: 0x182448930
	public void SetScheduledStartTime(double time) { }

	// RVA: 0x24488E0 Offset: 0x2447AE0 VA: 0x1824488E0
	public void SetScheduledEndTime(double time) { }

	// RVA: 0x24489D0 Offset: 0x2447BD0 VA: 0x1824489D0
	public void Stop() { }

	// RVA: 0x2448140 Offset: 0x2447340 VA: 0x182448140
	public void Pause() { }

	// RVA: 0x2448A60 Offset: 0x2447C60 VA: 0x182448A60
	public void UnPause() { }

	[NativeName("IsPlayingScripting")]
	// RVA: 0x2448C60 Offset: 0x2447E60 VA: 0x182448C60
	public bool get_isPlaying() { }

	[NativeName("GetLastVirtualState")]
	// RVA: 0x2448CA0 Offset: 0x2447EA0 VA: 0x182448CA0
	public bool get_isVirtual() { }

	[ExcludeFromDocs]
	// RVA: 0x2448180 Offset: 0x2447380 VA: 0x182448180
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x24481B0 Offset: 0x24473B0 VA: 0x1824481B0
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x2448CE0 Offset: 0x2447EE0 VA: 0x182448CE0
	public bool get_loop() { }

	// RVA: 0x24494B0 Offset: 0x24486B0 VA: 0x1824494B0
	public void set_loop(bool value) { }

	// RVA: 0x2448C20 Offset: 0x2447E20 VA: 0x182448C20
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x2449460 Offset: 0x2448660 VA: 0x182449460
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x2448F20 Offset: 0x2448120 VA: 0x182448F20
	public bool get_playOnAwake() { }

	// RVA: 0x2449750 Offset: 0x2448950 VA: 0x182449750
	public void set_playOnAwake(bool value) { }

	// RVA: 0x2448BE0 Offset: 0x2447DE0 VA: 0x182448BE0
	public bool get_ignoreListenerPause() { }

	// RVA: 0x2449410 Offset: 0x2448610 VA: 0x182449410
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x2449200 Offset: 0x2448400 VA: 0x182449200
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x2449AA0 Offset: 0x2448CA0 VA: 0x182449AA0
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x2448EE0 Offset: 0x24480E0 VA: 0x182448EE0
	public float get_panStereo() { }

	// RVA: 0x2449700 Offset: 0x2448900 VA: 0x182449700
	public void set_panStereo(float value) { }

	// RVA: 0x2449080 Offset: 0x2448280 VA: 0x182449080
	public float get_spatialBlend() { }

	// RVA: 0x24498D0 Offset: 0x2448AD0 VA: 0x1824498D0
	public void set_spatialBlend(float value) { }

	// RVA: 0x2449100 Offset: 0x2448300 VA: 0x182449100
	public bool get_spatialize() { }

	// RVA: 0x2449970 Offset: 0x2448B70 VA: 0x182449970
	public void set_spatialize(bool value) { }

	// RVA: 0x24490C0 Offset: 0x24482C0 VA: 0x1824490C0
	public bool get_spatializePostEffects() { }

	// RVA: 0x2449920 Offset: 0x2448B20 VA: 0x182449920
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x2448840 Offset: 0x2447A40 VA: 0x182448840
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x2447E70 Offset: 0x2447070 VA: 0x182447E70
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x2448FA0 Offset: 0x24481A0 VA: 0x182448FA0
	public float get_reverbZoneMix() { }

	// RVA: 0x24497E0 Offset: 0x24489E0 VA: 0x1824497E0
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x2448AA0 Offset: 0x2447CA0 VA: 0x182448AA0
	public bool get_bypassEffects() { }

	// RVA: 0x2449280 Offset: 0x2448480 VA: 0x182449280
	public void set_bypassEffects(bool value) { }

	// RVA: 0x2448AE0 Offset: 0x2447CE0 VA: 0x182448AE0
	public bool get_bypassListenerEffects() { }

	// RVA: 0x24492D0 Offset: 0x24484D0 VA: 0x1824492D0
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x2448B20 Offset: 0x2447D20 VA: 0x182448B20
	public bool get_bypassReverbZones() { }

	// RVA: 0x2449320 Offset: 0x2448520 VA: 0x182449320
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x2448BA0 Offset: 0x2447DA0 VA: 0x182448BA0
	public float get_dopplerLevel() { }

	// RVA: 0x24493C0 Offset: 0x24485C0 VA: 0x1824493C0
	public void set_dopplerLevel(float value) { }

	// RVA: 0x2449140 Offset: 0x2448340 VA: 0x182449140
	public float get_spread() { }

	// RVA: 0x24499C0 Offset: 0x2448BC0 VA: 0x1824499C0
	public void set_spread(float value) { }

	// RVA: 0x2448F60 Offset: 0x2448160 VA: 0x182448F60
	public int get_priority() { }

	// RVA: 0x24497A0 Offset: 0x24489A0 VA: 0x1824497A0
	public void set_priority(int value) { }

	// RVA: 0x2448E60 Offset: 0x2448060 VA: 0x182448E60
	public bool get_mute() { }

	// RVA: 0x2449660 Offset: 0x2448860 VA: 0x182449660
	public void set_mute(bool value) { }

	// RVA: 0x2448DC0 Offset: 0x2447FC0 VA: 0x182448DC0
	public float get_minDistance() { }

	// RVA: 0x24495B0 Offset: 0x24487B0 VA: 0x1824495B0
	public void set_minDistance(float value) { }

	// RVA: 0x2448D20 Offset: 0x2447F20 VA: 0x182448D20
	public float get_maxDistance() { }

	// RVA: 0x2449500 Offset: 0x2448700 VA: 0x182449500
	public void set_maxDistance(float value) { }

	// RVA: 0x2449040 Offset: 0x2448240 VA: 0x182449040
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x2449890 Offset: 0x2448A90 VA: 0x182449890
	public void set_rolloffMode(AudioRolloffMode value) { }

	[Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
	// RVA: 0x2447F10 Offset: 0x2447110 VA: 0x182447F10
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x2447EB0 Offset: 0x24470B0 VA: 0x182447EB0
	public void GetOutputData(float[] samples, int channel) { }

	[Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData and pass a pre allocated array instead.")]
	// RVA: 0x24480A0 Offset: 0x24472A0 VA: 0x1824480A0
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x2448030 Offset: 0x2447230 VA: 0x182448030
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x2448E00 Offset: 0x2448000 VA: 0x182448E00
	public float get_minVolume() { }

	// RVA: 0x2449600 Offset: 0x2448800 VA: 0x182449600
	public void set_minVolume(float value) { }

	// RVA: 0x2448D60 Offset: 0x2447F60 VA: 0x182448D60
	public float get_maxVolume() { }

	// RVA: 0x2449550 Offset: 0x2448750 VA: 0x182449550
	public void set_maxVolume(float value) { }

	// RVA: 0x2448FE0 Offset: 0x24481E0 VA: 0x182448FE0
	public float get_rolloffFactor() { }

	// RVA: 0x2449830 Offset: 0x2448A30 VA: 0x182449830
	public void set_rolloffFactor(float value) { }

	// RVA: 0x2448980 Offset: 0x2447B80 VA: 0x182448980
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x2447FE0 Offset: 0x24471E0 VA: 0x182447FE0
	public bool GetSpatializerFloat(int index, out float value) { }

	// RVA: 0x2447E20 Offset: 0x2447020 VA: 0x182447E20
	public bool GetAmbisonicDecoderFloat(int index, out float value) { }

	// RVA: 0x24487F0 Offset: 0x24479F0 VA: 0x1824487F0
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public sealed class AudioSampleProvider.SampleFramesHandler : MulticastDelegate // TypeDefIndex: 17945
{
	// Methods

	// RVA: 0x11BB050 Offset: 0x11BA250 VA: 0x1811BB050
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }
}

// Namespace: UnityEngine.Experimental.Audio
[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
[StaticAccessor("AudioSampleProviderBindings", 2)]
public class AudioSampleProvider // TypeDefIndex: 17946
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2447CC0 Offset: 0x2446EC0 VA: 0x182447CC0
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCode]
	// RVA: 0x2447CF0 Offset: 0x2446EF0 VA: 0x182447CF0
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }
}

// Namespace: UnityEngine.Audio
[RequiredByNativeCode]
[StaticAccessor("AudioClipPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
public struct AudioClipPlayable : IEquatable<AudioClipPlayable> // TypeDefIndex: 17947
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x2446B60 Offset: 0x2445D60 VA: 0x182446B60 Slot: 4
	public bool Equals(AudioClipPlayable other) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
public class AudioMixer : Object // TypeDefIndex: 17948
{
	// Methods

	[NativeMethod]
	// RVA: 0x2447C60 Offset: 0x2446E60 VA: 0x182447C60
	public bool SetFloat(string name, float value) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
public class AudioMixerGroup : Object // TypeDefIndex: 17949
{
	// Methods

	// RVA: 0x2447B90 Offset: 0x2446D90 VA: 0x182447B90
	internal void .ctor() { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
[StaticAccessor("AudioMixerPlayableBindings", 2)]
[RequiredByNativeCode]
public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable> // TypeDefIndex: 17950
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x2447BE0 Offset: 0x2446DE0 VA: 0x182447BE0 Slot: 4
	public bool Equals(AudioMixerPlayable other) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
public class AudioMixerSnapshot : Object // TypeDefIndex: 17951
{}

// Namespace: UnityEngine.Audio
[RequiredByNativeCode]
[StaticAccessor("AudioPlayableOutputBindings", 2)]
[NativeHeader("Modules/Audio/Public/AudioSource.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
public struct AudioPlayableOutput // TypeDefIndex: 17952
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17953
{}

// Namespace: UnityEngine
public enum FontStyle // TypeDefIndex: 17954
{
	// Fields
	public int value__; // 0x0
	public const FontStyle Normal = 0;
	public const FontStyle Bold = 1;
	public const FontStyle Italic = 2;
	public const FontStyle BoldAndItalic = 3;
}

// Namespace: UnityEngine
[Flags]
internal enum TextGenerationError // TypeDefIndex: 17955
{
	// Fields
	public int value__; // 0x0
	public const TextGenerationError None = 0;
	public const TextGenerationError CustomSizeOnNonDynamicFont = 1;
	public const TextGenerationError CustomStyleOnNonDynamicFont = 2;
	public const TextGenerationError NoFont = 4;
}

// Namespace: UnityEngine
public struct TextGenerationSettings // TypeDefIndex: 17956
{
	// Fields
	public Font font; // 0x0
	public Color color; // 0x8
	public int fontSize; // 0x18
	public float lineSpacing; // 0x1C
	public bool richText; // 0x20
	public float scaleFactor; // 0x24
	public FontStyle fontStyle; // 0x28
	public TextAnchor textAnchor; // 0x2C
	public bool alignByGeometry; // 0x30
	public bool resizeTextForBestFit; // 0x31
	public int resizeTextMinSize; // 0x34
	public int resizeTextMaxSize; // 0x38
	public bool updateBounds; // 0x3C
	public VerticalWrapMode verticalOverflow; // 0x40
	public HorizontalWrapMode horizontalOverflow; // 0x44
	public Vector2 generationExtents; // 0x48
	public Vector2 pivot; // 0x50
	public bool generateOutOfBounds; // 0x58

	// Methods

	// RVA: 0x2547900 Offset: 0x2546B00 VA: 0x182547900
	private bool CompareColors(Color left, Color right) { }

	// RVA: 0x2547980 Offset: 0x2546B80 VA: 0x182547980
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x25479D0 Offset: 0x2546BD0 VA: 0x1825479D0
	public bool Equals(TextGenerationSettings other) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/TextRendering/TextGenerator.h")]
[UsedByNativeCode]
public sealed class TextGenerator : IDisposable // TypeDefIndex: 17957
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List<UIVertex> m_Verts; // 0x88
	private readonly List<UICharInfo> m_Characters; // 0x90
	private readonly List<UILineInfo> m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Properties
	public int characterCountVisible { get; }
	public IList<UIVertex> verts { get; }
	public IList<UICharInfo> characters { get; }
	public IList<UILineInfo> lines { get; }
	public Rect rectExtents { get; }
	public int characterCount { get; }
	public int lineCount { get; }

	// Methods

	// RVA: 0x25492B0 Offset: 0x25484B0 VA: 0x1825492B0
	public void .ctor() { }

	// RVA: 0x2549180 Offset: 0x2548380 VA: 0x182549180
	public void .ctor(int initialCapacity) { }

	// RVA: 0x2547C50 Offset: 0x2546E50 VA: 0x182547C50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2548E10 Offset: 0x2548010 VA: 0x182548E10 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x25493D0 Offset: 0x25485D0 VA: 0x1825493D0
	public int get_characterCountVisible() { }

	// RVA: 0x2548E70 Offset: 0x2548070 VA: 0x182548E70
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x2547FE0 Offset: 0x25471E0 VA: 0x182547FE0
	public void Invalidate() { }

	// RVA: 0x2547D30 Offset: 0x2546F30 VA: 0x182547D30
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x2547D80 Offset: 0x2546F80 VA: 0x182547D80
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x2547F20 Offset: 0x2547120 VA: 0x182547F20
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x2547E70 Offset: 0x2547070 VA: 0x182547E70
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x2547DD0 Offset: 0x2546FD0 VA: 0x182547DD0
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x2548760 Offset: 0x2547960 VA: 0x182548760
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x2548DB0 Offset: 0x2547FB0 VA: 0x182548DB0
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x2548360 Offset: 0x2547560 VA: 0x182548360
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x2547FF0 Offset: 0x25471F0 VA: 0x182547FF0
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x2549610 Offset: 0x2548810 VA: 0x182549610
	public IList<UIVertex> get_verts() { }

	// RVA: 0x2549450 Offset: 0x2548650 VA: 0x182549450
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x2549500 Offset: 0x2548700 VA: 0x182549500
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x25495C0 Offset: 0x25487C0 VA: 0x1825495C0
	public Rect get_rectExtents() { }

	// RVA: 0x2549410 Offset: 0x2548610 VA: 0x182549410
	public int get_characterCount() { }

	// RVA: 0x25494C0 Offset: 0x25486C0 VA: 0x1825494C0
	public int get_lineCount() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2547F70 Offset: 0x2547170 VA: 0x182547F70
	private static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2547FA0 Offset: 0x25471A0 VA: 0x182547FA0
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x2548C30 Offset: 0x2547E30 VA: 0x182548C30
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x2548A30 Offset: 0x2547C30 VA: 0x182548A30
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrows]
	// RVA: 0x2547F20 Offset: 0x2547120 VA: 0x182547F20
	private void GetVerticesInternal(object vertices) { }

	[NativeThrows]
	// RVA: 0x2547D30 Offset: 0x2546F30 VA: 0x182547D30
	private void GetCharactersInternal(object characters) { }

	[NativeThrows]
	// RVA: 0x2547D80 Offset: 0x2546F80 VA: 0x182547D80
	private void GetLinesInternal(object lines) { }

	// RVA: 0x2549570 Offset: 0x2548770 VA: 0x182549570
	private void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0x2548970 Offset: 0x2547B70 VA: 0x182548970
	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }
}

// Namespace: UnityEngine
public enum TextAlignment // TypeDefIndex: 17958
{
	// Fields
	public int value__; // 0x0
	public const TextAlignment Left = 0;
	public const TextAlignment Center = 1;
	public const TextAlignment Right = 2;
}

// Namespace: UnityEngine
public enum TextAnchor // TypeDefIndex: 17959
{
	// Fields
	public int value__; // 0x0
	public const TextAnchor UpperLeft = 0;
	public const TextAnchor UpperCenter = 1;
	public const TextAnchor UpperRight = 2;
	public const TextAnchor MiddleLeft = 3;
	public const TextAnchor MiddleCenter = 4;
	public const TextAnchor MiddleRight = 5;
	public const TextAnchor LowerLeft = 6;
	public const TextAnchor LowerCenter = 7;
	public const TextAnchor LowerRight = 8;
}

// Namespace: UnityEngine
public enum HorizontalWrapMode // TypeDefIndex: 17960
{
	// Fields
	public int value__; // 0x0
	public const HorizontalWrapMode Wrap = 0;
	public const HorizontalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
public enum VerticalWrapMode // TypeDefIndex: 17961
{
	// Fields
	public int value__; // 0x0
	public const VerticalWrapMode Truncate = 0;
	public const VerticalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct CharacterInfo // TypeDefIndex: 17962
{
	// Fields
	public int index; // 0x0
	[Obsolete("CharacterInfo.uv is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead.")]
	public Rect uv; // 0x4
	[Obsolete("CharacterInfo.vert is deprecated. Use minX, maxX, minY, maxY instead.")]
	public Rect vert; // 0x14
	[NativeName("advance")]
	[Obsolete("CharacterInfo.width is deprecated. Use advance instead.")]
	public float width; // 0x24
	public int size; // 0x28
	public FontStyle style; // 0x2C
	[Obsolete("CharacterInfo.flipped is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead, which will be correct regardless of orientation.")]
	public bool flipped; // 0x30
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UICharInfo // TypeDefIndex: 17963
{
	// Fields
	public Vector2 cursorPos; // 0x0
	public float charWidth; // 0x8
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UILineInfo // TypeDefIndex: 17964
{
	// Fields
	public int startCharIdx; // 0x0
	public int height; // 0x4
	public float topY; // 0x8
	public float leading; // 0xC
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UIVertex // TypeDefIndex: 17965
{
	// Fields
	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector4 tangent; // 0x18
	public Color32 color; // 0x28
	public Vector4 uv0; // 0x2C
	public Vector4 uv1; // 0x3C
	public Vector4 uv2; // 0x4C
	public Vector4 uv3; // 0x5C
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector4 s_DefaultTangent; // 0x4
	public static UIVertex simpleVert; // 0x14

	// Methods

	// RVA: 0x2549680 Offset: 0x2548880 VA: 0x182549680
	private static void .cctor() { }
}

// Namespace: 
public sealed class Font.FontTextureRebuildCallback : MulticastDelegate // TypeDefIndex: 17966
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[StaticAccessor("TextRenderingPrivate", 2)]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[NativeClass("TextRendering::Font")]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
public sealed class Font : Object // TypeDefIndex: 17967
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Font> textureRebuilt; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; set; }
	public string[] fontNames { get; set; }
	public bool dynamic { get; }
	public int ascent { get; }
	public int fontSize { get; }
	public CharacterInfo[] characterInfo { get; set; }
	[NativeProperty("LineSpacing", False, 0)]
	public int lineHeight { get; }
	[Obsolete("Font.textureRebuildCallback has been deprecated. Use Font.textureRebuilt instead.")]
	public Font.FontTextureRebuildCallback textureRebuildCallback { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x25473F0 Offset: 0x25465F0 VA: 0x1825473F0
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGenerated]
	// RVA: 0x2547730 Offset: 0x2546930 VA: 0x182547730
	public static void remove_textureRebuilt(Action<Font> value) { }

	[CompilerGenerated]
	// RVA: 0x2547350 Offset: 0x2546550 VA: 0x182547350
	private void add_m_FontTextureRebuildCallback(Font.FontTextureRebuildCallback value) { }

	[CompilerGenerated]
	// RVA: 0x2547690 Offset: 0x2546890 VA: 0x182547690
	private void remove_m_FontTextureRebuildCallback(Font.FontTextureRebuildCallback value) { }

	// RVA: 0x2547650 Offset: 0x2546850 VA: 0x182547650
	public Material get_material() { }

	// RVA: 0x25478B0 Offset: 0x2546AB0 VA: 0x1825478B0
	public void set_material(Material value) { }

	// RVA: 0x2547590 Offset: 0x2546790 VA: 0x182547590
	public string[] get_fontNames() { }

	// RVA: 0x2547860 Offset: 0x2546A60 VA: 0x182547860
	public void set_fontNames(string[] value) { }

	// RVA: 0x2547550 Offset: 0x2546750 VA: 0x182547550
	public bool get_dynamic() { }

	// RVA: 0x25474D0 Offset: 0x25466D0 VA: 0x1825474D0
	public int get_ascent() { }

	// RVA: 0x25475D0 Offset: 0x25467D0 VA: 0x1825475D0
	public int get_fontSize() { }

	[FreeFunction("TextRenderingPrivate::GetFontCharacterInfo", HasExplicitThis = True)]
	// RVA: 0x2547510 Offset: 0x2546710 VA: 0x182547510
	public CharacterInfo[] get_characterInfo() { }

	[FreeFunction("TextRenderingPrivate::SetFontCharacterInfo", HasExplicitThis = True)]
	// RVA: 0x2547810 Offset: 0x2546A10 VA: 0x182547810
	public void set_characterInfo(CharacterInfo[] value) { }

	// RVA: 0x2547610 Offset: 0x2546810 VA: 0x182547610
	public int get_lineHeight() { }

	// RVA: 0x248C210 Offset: 0x248B410 VA: 0x18248C210
	public Font.FontTextureRebuildCallback get_textureRebuildCallback() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_textureRebuildCallback(Font.FontTextureRebuildCallback value) { }

	// RVA: 0x2547140 Offset: 0x2546340 VA: 0x182547140
	public void .ctor() { }

	// RVA: 0x2547240 Offset: 0x2546440 VA: 0x182547240
	public void .ctor(string name) { }

	// RVA: 0x25471B0 Offset: 0x25463B0 VA: 0x1825471B0
	private void .ctor(string[] names, int size) { }

	// RVA: 0x2546B80 Offset: 0x2545D80 VA: 0x182546B80
	public static Font CreateDynamicFontFromOSFont(string fontname, int size) { }

	// RVA: 0x2546B10 Offset: 0x2545D10 VA: 0x182546B10
	public static Font CreateDynamicFontFromOSFont(string[] fontnames, int size) { }

	[RequiredByNativeCode]
	// RVA: 0x2546FA0 Offset: 0x25461A0 VA: 0x182546FA0
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x2546D90 Offset: 0x2545F90 VA: 0x182546D90
	public static int GetMaxVertsForString(string str) { }

	// RVA: 0x2546D60 Offset: 0x2545F60 VA: 0x182546D60
	internal static Font GetDefault() { }

	// RVA: 0x2546E10 Offset: 0x2546010 VA: 0x182546E10
	public bool HasCharacter(char c) { }

	// RVA: 0x2546E60 Offset: 0x2546060 VA: 0x182546E60
	private bool HasCharacter(int c) { }

	// RVA: 0x2546DB0 Offset: 0x2545FB0 VA: 0x182546DB0
	public static string[] GetOSInstalledFontNames() { }

	// RVA: 0x2546DE0 Offset: 0x2545FE0 VA: 0x182546DE0
	public static string[] GetPathsToOSFonts() { }

	// RVA: 0x2546F50 Offset: 0x2546150 VA: 0x182546F50
	private static void Internal_CreateFont(Font self, string name) { }

	// RVA: 0x2546F00 Offset: 0x2546100 VA: 0x182546F00
	private static void Internal_CreateFontFromPath(Font self, string fontPath) { }

	// RVA: 0x2546EA0 Offset: 0x25460A0 VA: 0x182546EA0
	private static void Internal_CreateDynamicFont(Font self, string[] _names, int size) { }

	[FreeFunction("TextRenderingPrivate::GetCharacterInfo", HasExplicitThis = True)]
	// RVA: 0x2546C90 Offset: 0x2545E90 VA: 0x182546C90
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { }

	[ExcludeFromDocs]
	// RVA: 0x2546C20 Offset: 0x2545E20 VA: 0x182546C20
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size) { }

	[ExcludeFromDocs]
	// RVA: 0x2546D00 Offset: 0x2545F00 VA: 0x182546D00
	public bool GetCharacterInfo(char ch, out CharacterInfo info) { }

	// RVA: 0x2547020 Offset: 0x2546220 VA: 0x182547020
	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	[ExcludeFromDocs]
	// RVA: 0x25470E0 Offset: 0x25462E0 VA: 0x1825470E0
	public void RequestCharactersInTexture(string characters, int size) { }

	[ExcludeFromDocs]
	// RVA: 0x2547090 Offset: 0x2546290 VA: 0x182547090
	public void RequestCharactersInTexture(string characters) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17968
{}

// Namespace: 
private enum InputTracking.TrackingStateEventType // TypeDefIndex: 17969
{
	// Fields
	public int value__; // 0x0
	public const InputTracking.TrackingStateEventType NodeAdded = 0;
	public const InputTracking.TrackingStateEventType NodeRemoved = 1;
	public const InputTracking.TrackingStateEventType TrackingAcquired = 2;
	public const InputTracking.TrackingStateEventType TrackingLost = 3;
}

// Namespace: UnityEngine.XR
[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
[NativeConditional("ENABLE_VR")]
[StaticAccessor("XRInputTrackingFacade::Get()", 0)]
public static class InputTracking // TypeDefIndex: 17970
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<XRNodeState> trackingAcquired; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<XRNodeState> trackingLost; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<XRNodeState> nodeAdded; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<XRNodeState> nodeRemoved; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2717780 Offset: 0x2716980 VA: 0x182717780
	private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }
}

// Namespace: UnityEngine.XR
public enum XRNode // TypeDefIndex: 17971
{
	// Fields
	public int value__; // 0x0
	public const XRNode LeftEye = 0;
	public const XRNode RightEye = 1;
	public const XRNode CenterEye = 2;
	public const XRNode Head = 3;
	public const XRNode LeftHand = 4;
	public const XRNode RightHand = 5;
	public const XRNode GameController = 6;
	public const XRNode TrackingReference = 7;
	public const XRNode HardwareTracker = 8;
}

// Namespace: UnityEngine.XR
[Flags]
internal enum AvailableTrackingData // TypeDefIndex: 17972
{
	// Fields
	public int value__; // 0x0
	public const AvailableTrackingData None = 0;
	public const AvailableTrackingData PositionAvailable = 1;
	public const AvailableTrackingData RotationAvailable = 2;
	public const AvailableTrackingData VelocityAvailable = 4;
	public const AvailableTrackingData AngularVelocityAvailable = 8;
	public const AvailableTrackingData AccelerationAvailable = 16;
	public const AvailableTrackingData AngularAccelerationAvailable = 32;
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
public struct XRNodeState // TypeDefIndex: 17973
{
	// Fields
	private XRNode m_Type; // 0x0
	private AvailableTrackingData m_AvailableFields; // 0x4
	private Vector3 m_Position; // 0x8
	private Quaternion m_Rotation; // 0x14
	private Vector3 m_Velocity; // 0x24
	private Vector3 m_AngularVelocity; // 0x30
	private Vector3 m_Acceleration; // 0x3C
	private Vector3 m_AngularAcceleration; // 0x48
	private int m_Tracked; // 0x54
	private ulong m_UniqueID; // 0x58

	// Properties
	public ulong uniqueID { set; }
	public XRNode nodeType { set; }
	public bool tracked { set; }

	// Methods

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_uniqueID(ulong value) { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_nodeType(XRNode value) { }

	// RVA: 0x2718450 Offset: 0x2717650 VA: 0x182718450
	public void set_tracked(bool value) { }
}

// Namespace: UnityEngine.XR
internal enum InputFeatureType // TypeDefIndex: 17974
{
	// Fields
	public uint value__; // 0x0
	public const InputFeatureType Custom = 0;
	public const InputFeatureType Binary = 1;
	public const InputFeatureType DiscreteStates = 2;
	public const InputFeatureType Axis1D = 3;
	public const InputFeatureType Axis2D = 4;
	public const InputFeatureType Axis3D = 5;
	public const InputFeatureType Rotation = 6;
	public const InputFeatureType Hand = 7;
	public const InputFeatureType Bone = 8;
	public const InputFeatureType Eyes = 9;
	public const InputFeatureType kUnityXRInputFeatureTypeInvalid = 4294967295;
}

// Namespace: UnityEngine.XR
internal enum ConnectionChangeType // TypeDefIndex: 17975
{
	// Fields
	public uint value__; // 0x0
	public const ConnectionChangeType Connected = 0;
	public const ConnectionChangeType Disconnected = 1;
	public const ConnectionChangeType ConfigChange = 2;
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 17976
{
	// Fields
	internal string m_Name; // 0x0
	[NativeName("m_FeatureType")]
	internal InputFeatureType m_InternalType; // 0x8

	// Properties
	public string name { get; }
	internal InputFeatureType internalType { get; }

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	public string get_name() { }

	// RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000
	internal InputFeatureType get_internalType() { }

	// RVA: 0x2717610 Offset: 0x2716810 VA: 0x182717610 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x27176D0 Offset: 0x27168D0 VA: 0x1827176D0 Slot: 4
	public bool Equals(InputFeatureUsage other) { }

	// RVA: 0x2717720 Offset: 0x2716920 VA: 0x182717720 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
[UsedByNativeCode]
public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 17977
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private bool m_Initialized; // 0x8

	// Properties
	private ulong deviceId { get; }

	// Methods

	// RVA: 0x2717510 Offset: 0x2716710 VA: 0x182717510
	internal void .ctor(ulong deviceId) { }

	// RVA: 0x2717520 Offset: 0x2716720 VA: 0x182717520
	private ulong get_deviceId() { }

	// RVA: 0x2717400 Offset: 0x2716600 VA: 0x182717400 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x27174B0 Offset: 0x27166B0 VA: 0x1827174B0 Slot: 4
	public bool Equals(InputDevice other) { }

	// RVA: 0x27174E0 Offset: 0x27166E0 VA: 0x1827174E0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/XRPrefix.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputDevices::Get()", 0)]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeHeader("XRScriptingClasses.h")]
[NativeConditional("ENABLE_VR")]
public struct Hand : IEquatable<Hand> // TypeDefIndex: 17978
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	internal ulong get_deviceId() { }

	// RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000
	internal uint get_featureIndex() { }

	// RVA: 0x2717200 Offset: 0x2716400 VA: 0x182717200 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2717030 Offset: 0x2716230 VA: 0x182717030 Slot: 4
	public bool Equals(Hand other) { }

	// RVA: 0x2717100 Offset: 0x2716300 VA: 0x182717100 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[StaticAccessor("XRInputDevices::Get()", 0)]
[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeConditional("ENABLE_VR")]
[NativeHeader("XRScriptingClasses.h")]
public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 17979
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	internal ulong get_deviceId() { }

	// RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000
	internal uint get_featureIndex() { }

	// RVA: 0x2717150 Offset: 0x2716350 VA: 0x182717150 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2717030 Offset: 0x2716230 VA: 0x182717030 Slot: 4
	public bool Equals(Eyes other) { }

	// RVA: 0x2717100 Offset: 0x2716300 VA: 0x182717100 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[RequiredByNativeCode]
[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[StaticAccessor("XRInputDevices::Get()", 0)]
public struct Bone : IEquatable<Bone> // TypeDefIndex: 17980
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	internal ulong get_deviceId() { }

	// RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000
	internal uint get_featureIndex() { }

	// RVA: 0x2717050 Offset: 0x2716250 VA: 0x182717050 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2717030 Offset: 0x2716230 VA: 0x182717030 Slot: 4
	public bool Equals(Bone other) { }

	// RVA: 0x2717100 Offset: 0x2716300 VA: 0x182717100 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[StaticAccessor("XRInputDevices::Get()", 0)]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeConditional("ENABLE_VR")]
[UsedByNativeCode]
public class InputDevices // TypeDefIndex: 17981
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceConnected; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceDisconnected; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<InputDevice> deviceConfigChanged; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2717540 Offset: 0x2716740 VA: 0x182717540
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }
}

// Namespace: 
[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
public struct XRDisplaySubsystem.XRRenderPass // TypeDefIndex: 17982
{
	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public int renderPassIndex; // 0x8
	public RenderTargetIdentifier renderTarget; // 0x10
	public RenderTextureDescriptor renderTargetDesc; // 0x38
	public bool hasMotionVectorPass; // 0x6C
	public RenderTargetIdentifier motionVectorRenderTarget; // 0x70
	public RenderTextureDescriptor motionVectorRenderTargetDesc; // 0x98
	public bool shouldFillOutDepth; // 0xCC
	public int cullingPassIndex; // 0xD0
	public IntPtr foveatedRenderingInfo; // 0xD8
}

// Namespace: 
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
public struct XRDisplaySubsystem.XRBlitParams // TypeDefIndex: 17983
{
	// Fields
	public RenderTexture srcTex; // 0x0
	public int srcTexArraySlice; // 0x8
	public Rect srcRect; // 0xC
	public Rect destRect; // 0x1C
	public IntPtr foveatedRenderingInfo; // 0x30
	public bool srcHdrEncoded; // 0x38
	public ColorGamut srcHdrColorGamut; // 0x3C
	public int srcHdrMaxLuminance; // 0x40
}

// Namespace: 
[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
public struct XRDisplaySubsystem.XRMirrorViewBlitDesc // TypeDefIndex: 17984
{
	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public bool nativeBlitAvailable; // 0x8
	public bool nativeBlitInvalidStates; // 0x9
	public int blitParamsCount; // 0xC
}

// Namespace: UnityEngine.XR
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
[UsedByNativeCode]
[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 17985
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<bool> displayFocusChanged; // 0x20

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24472E0 Offset: 0x24464E0 VA: 0x1824472E0
	private void InvokeDisplayFocusChanged(bool focus) { }

	// RVA: 0x2718100 Offset: 0x2717300 VA: 0x182718100
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystemDescriptor.h")]
[UsedByNativeCode]
public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem> // TypeDefIndex: 17986
{
	// Methods

	// RVA: 0x27180C0 Offset: 0x27172C0 VA: 0x1827180C0
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
[NativeConditional("ENABLE_XR")]
[UsedByNativeCode]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 17987
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<XRInputSubsystem> boundaryChanged; // 0x28

	// Methods

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x2718250 Offset: 0x2717450 VA: 0x182718250
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x2718180 Offset: 0x2717380 VA: 0x182718180
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0x2718320 Offset: 0x2717520 VA: 0x182718320
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
[UsedByNativeCode]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeConditional("ENABLE_XR")]
public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 17988
{
	// Methods

	// RVA: 0x2718140 Offset: 0x2717340 VA: 0x182718140
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[UsedByNativeCode]
public struct MeshId : IEquatable<MeshId> // TypeDefIndex: 17989
{
	// Fields
	private static MeshId s_InvalidId; // 0x0
	private ulong m_SubId1; // 0x0
	private ulong m_SubId2; // 0x8

	// Methods

	// RVA: 0x2717F80 Offset: 0x2717180 VA: 0x182717F80 Slot: 3
	public override string ToString() { }

	// RVA: 0x2479830 Offset: 0x2478A30 VA: 0x182479830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2717ED0 Offset: 0x27170D0 VA: 0x182717ED0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24799E0 Offset: 0x2478BE0 VA: 0x1824799E0 Slot: 4
	public bool Equals(MeshId other) { }

	// RVA: 0x2718000 Offset: 0x2717200 VA: 0x182718000
	private static void .cctor() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[RequiredByNativeCode]
public enum MeshGenerationStatus // TypeDefIndex: 17990
{
	// Fields
	public int value__; // 0x0
	public const MeshGenerationStatus Success = 0;
	public const MeshGenerationStatus InvalidMeshId = 1;
	public const MeshGenerationStatus GenerationAlreadyInProgress = 2;
	public const MeshGenerationStatus Canceled = 3;
	public const MeshGenerationStatus UnknownError = 4;
}

// Namespace: UnityEngine.XR
internal static class HashCodeHelper // TypeDefIndex: 17991
{
	// Methods

	// RVA: 0x27172F0 Offset: 0x27164F0 VA: 0x1827172F0
	public static int Combine(int hash1, int hash2) { }

	// RVA: 0x27173C0 Offset: 0x27165C0 VA: 0x1827173C0
	public static int Combine(int hash1, int hash2, int hash3) { }

	// RVA: 0x27173E0 Offset: 0x27165E0 VA: 0x1827173E0
	public static int Combine(int hash1, int hash2, int hash3, int hash4) { }

	// RVA: 0x2717340 Offset: 0x2716540 VA: 0x182717340
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5) { }

	// RVA: 0x2717300 Offset: 0x2716500 VA: 0x182717300
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6) { }

	// RVA: 0x27172B0 Offset: 0x27164B0 VA: 0x1827172B0
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7) { }

	// RVA: 0x2717370 Offset: 0x2716570 VA: 0x182717370
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8) { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[RequiredByNativeCode]
public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 17992
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly MeshId <MeshId>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshCollider <MeshCollider>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshGenerationStatus <Status>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshVertexAttributes <Attributes>k__BackingField; // 0x24
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ulong <Timestamp>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Vector3 <Position>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Quaternion <Rotation>k__BackingField; // 0x3C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Vector3 <Scale>k__BackingField; // 0x4C

	// Properties
	public MeshId MeshId { get; }
	public Mesh Mesh { get; }
	public MeshCollider MeshCollider { get; }
	public MeshGenerationStatus Status { get; }
	public MeshVertexAttributes Attributes { get; }
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Vector3 Scale { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public MeshId get_MeshId() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Mesh get_Mesh() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public MeshCollider get_MeshCollider() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public MeshGenerationStatus get_Status() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public MeshVertexAttributes get_Attributes() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x2717E90 Offset: 0x2717090 VA: 0x182717E90
	public Vector3 get_Position() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x2560450 Offset: 0x255F650 VA: 0x182560450
	public Quaternion get_Rotation() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x2717EB0 Offset: 0x27170B0 VA: 0x182717EB0
	public Vector3 get_Scale() { }

	// RVA: 0x2717940 Offset: 0x2716B40 VA: 0x182717940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2717A20 Offset: 0x2716C20 VA: 0x182717A20 Slot: 4
	public bool Equals(MeshGenerationResult other) { }

	// RVA: 0x2717C30 Offset: 0x2716E30 VA: 0x182717C30 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[Flags]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[UsedByNativeCode]
public enum MeshVertexAttributes // TypeDefIndex: 17993
{
	// Fields
	public int value__; // 0x0
	public const MeshVertexAttributes None = 0;
	public const MeshVertexAttributes Normals = 1;
	public const MeshVertexAttributes Tangents = 2;
	public const MeshVertexAttributes UVs = 4;
	public const MeshVertexAttributes Colors = 8;
}

// Namespace: 
[IsReadOnly]
[NativeConditional("ENABLE_XR")]
private struct XRMeshSubsystem.MeshTransformList : IDisposable // TypeDefIndex: 17994
{
	// Fields
	private readonly IntPtr m_Self; // 0x0

	// Methods

	// RVA: 0x2718040 Offset: 0x2717240 VA: 0x182718040 Slot: 4
	public void Dispose() { }

	[FreeFunction("UnityXRMeshTransformList_Dispose")]
	// RVA: 0x2718080 Offset: 0x2717280 VA: 0x182718080
	private static void Dispose(IntPtr self) { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/XRPrefix.h")]
[UsedByNativeCode]
[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 17995
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x27183A0 Offset: 0x27175A0 VA: 0x1827183A0
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

	// RVA: 0x2718410 Offset: 0x2717610 VA: 0x182718410
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Planes/XRMeshSubsystemDescriptor.h")]
public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 17996
{
	// Methods

	// RVA: 0x2718360 Offset: 0x2717560 VA: 0x182718360
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17997
{}

// Namespace: UnityEngine
public interface ICanvasRaycastFilter // TypeDefIndex: 17998
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
}

// Namespace: UnityEngine
[NativeClass("UI::CanvasGroup")]
[NativeHeader("Modules/UI/CanvasGroup.h")]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 17999
{
	// Properties
	[NativeProperty("Alpha", False, 0)]
	public float alpha { get; set; }
	[NativeProperty("Interactable", False, 0)]
	public bool interactable { get; set; }
	[NativeProperty("BlocksRaycasts", False, 0)]
	public bool blocksRaycasts { get; }
	[NativeProperty("IgnoreParentGroups", False, 0)]
	public bool ignoreParentGroups { get; set; }

	// Methods

	// RVA: 0x26CD6D0 Offset: 0x26CC8D0 VA: 0x1826CD6D0
	public float get_alpha() { }

	// RVA: 0x26CD790 Offset: 0x26CC990 VA: 0x1826CD790
	public void set_alpha(float value) { }

	// RVA: 0x26CD750 Offset: 0x26CC950 VA: 0x1826CD750
	public bool get_interactable() { }

	// RVA: 0x26CD830 Offset: 0x26CCA30 VA: 0x1826CD830
	public void set_interactable(bool value) { }

	// RVA: 0x26CD690 Offset: 0x26CC890 VA: 0x1826CD690
	public bool get_blocksRaycasts() { }

	// RVA: 0x26CD710 Offset: 0x26CC910 VA: 0x1826CD710
	public bool get_ignoreParentGroups() { }

	// RVA: 0x26CD7E0 Offset: 0x26CC9E0 VA: 0x1826CD7E0
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x26CD690 Offset: 0x26CC890 VA: 0x1826CD690 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }
}

// Namespace: UnityEngine
[NativeClass("UI::CanvasRenderer")]
[NativeHeader("Modules/UI/CanvasRenderer.h")]
public sealed class CanvasRenderer : Component // TypeDefIndex: 18000
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isMask>k__BackingField; // 0x18

	// Properties
	public bool hasPopInstruction { set; }
	public int materialCount { get; set; }
	public int popMaterialCount { set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	public bool cullTransparentMesh { get; set; }
	[NativeProperty("ShouldCull", False, 0)]
	public bool cull { get; set; }
	public Vector2 clippingSoftness { set; }

	// Methods

	// RVA: 0x26CE2A0 Offset: 0x26CD4A0 VA: 0x1826CE2A0
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x26CE130 Offset: 0x26CD330 VA: 0x1826CE130
	public int get_materialCount() { }

	// RVA: 0x26CE2F0 Offset: 0x26CD4F0 VA: 0x1826CE2F0
	public void set_materialCount(int value) { }

	// RVA: 0x26CE330 Offset: 0x26CD530 VA: 0x1826CE330
	public void set_popMaterialCount(int value) { }

	// RVA: 0x26CE030 Offset: 0x26CD230 VA: 0x1826CE030
	public int get_absoluteDepth() { }

	// RVA: 0x26CE0F0 Offset: 0x26CD2F0 VA: 0x1826CE0F0
	public bool get_hasMoved() { }

	// RVA: 0x26CE070 Offset: 0x26CD270 VA: 0x1826CE070
	public bool get_cullTransparentMesh() { }

	// RVA: 0x26CE200 Offset: 0x26CD400 VA: 0x1826CE200
	public void set_cullTransparentMesh(bool value) { }

	// RVA: 0x26CE0B0 Offset: 0x26CD2B0 VA: 0x1826CE0B0
	public bool get_cull() { }

	// RVA: 0x26CE250 Offset: 0x26CD450 VA: 0x1826CE250
	public void set_cull(bool value) { }

	// RVA: 0x26CDC40 Offset: 0x26CCE40 VA: 0x1826CDC40
	public void SetColor(Color color) { }

	// RVA: 0x26CDAD0 Offset: 0x26CCCD0 VA: 0x1826CDAD0
	public Color GetColor() { }

	// RVA: 0x26CDA30 Offset: 0x26CCC30 VA: 0x1826CDA30
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x26CE1C0 Offset: 0x26CD3C0 VA: 0x1826CE1C0
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x26CD9A0 Offset: 0x26CCBA0 VA: 0x1826CD9A0
	public void DisableRectClipping() { }

	// RVA: 0x26CDDB0 Offset: 0x26CCFB0 VA: 0x1826CDDB0
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x26CDB60 Offset: 0x26CCD60 VA: 0x1826CDB60
	public Material GetMaterial(int index) { }

	// RVA: 0x26CDE60 Offset: 0x26CD060 VA: 0x1826CDE60
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x26CDEC0 Offset: 0x26CD0C0 VA: 0x1826CDEC0
	public void SetTexture(Texture texture) { }

	// RVA: 0x26CDBA0 Offset: 0x26CCDA0 VA: 0x1826CDBA0
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x26CDE10 Offset: 0x26CD010 VA: 0x1826CDE10
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x26CD8F0 Offset: 0x26CCAF0 VA: 0x1826CD8F0
	public void Clear() { }

	// RVA: 0x26CDC90 Offset: 0x26CCE90 VA: 0x1826CDC90
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x26CDB20 Offset: 0x26CCD20 VA: 0x1826CDB20
	public Material GetMaterial() { }

	// RVA: 0x26CDF60 Offset: 0x26CD160 VA: 0x1826CDF60
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x26CD930 Offset: 0x26CCB30 VA: 0x1826CD930
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x26CD880 Offset: 0x26CCA80 VA: 0x1826CD880
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x26CDF10 Offset: 0x26CD110 VA: 0x1826CDF10
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x26CD880 Offset: 0x26CCA80 VA: 0x1826CD880
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x26CD930 Offset: 0x26CCB30 VA: 0x1826CD930
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x26CDBF0 Offset: 0x26CCDF0 VA: 0x1826CDBF0
	private void SetColor_Injected(ref Color color) { }

	// RVA: 0x26CDA80 Offset: 0x26CCC80 VA: 0x1826CDA80
	private void GetColor_Injected(out Color ret) { }

	// RVA: 0x26CD9E0 Offset: 0x26CCBE0 VA: 0x1826CD9E0
	private void EnableRectClipping_Injected(ref Rect rect) { }

	// RVA: 0x26CE170 Offset: 0x26CD370 VA: 0x1826CE170
	private void set_clippingSoftness_Injected(ref Vector2 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/RectTransformUtil.h")]
[NativeHeader("Runtime/Transform/RectTransform.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[StaticAccessor("UI", 2)]
public sealed class RectTransformUtility // TypeDefIndex: 18001
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x26CF930 Offset: 0x26CEB30 VA: 0x1826CF930
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x26CFA20 Offset: 0x26CEC20 VA: 0x1826CFA20
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x26CFB20 Offset: 0x26CED20 VA: 0x1826CFB20
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x26CFC90 Offset: 0x26CEE90 VA: 0x1826CFC90
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x26CFBB0 Offset: 0x26CEDB0 VA: 0x1826CFBB0
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x26D0070 Offset: 0x26CF270 VA: 0x1826D0070
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x26CFDD0 Offset: 0x26CEFD0 VA: 0x1826CFDD0
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x26CFEF0 Offset: 0x26CF0F0 VA: 0x1826CFEF0
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x26D0500 Offset: 0x26CF700 VA: 0x1826D0500
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x26CF310 Offset: 0x26CE510 VA: 0x1826CF310
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x26CF0B0 Offset: 0x26CE2B0 VA: 0x1826CF0B0
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x26CF8A0 Offset: 0x26CEAA0 VA: 0x1826CF8A0
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x26D05C0 Offset: 0x26CF7C0 VA: 0x1826D05C0
	private static void .cctor() { }

	// RVA: 0x26CF8C0 Offset: 0x26CEAC0 VA: 0x1826CF8C0
	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0x26CF9C0 Offset: 0x26CEBC0 VA: 0x1826CF9C0
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0x26CFAB0 Offset: 0x26CECB0 VA: 0x1826CFAB0
	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset) { }
}

// Namespace: UnityEngine
public enum RenderMode // TypeDefIndex: 18002
{
	// Fields
	public int value__; // 0x0
	public const RenderMode ScreenSpaceOverlay = 0;
	public const RenderMode ScreenSpaceCamera = 1;
	public const RenderMode WorldSpace = 2;
}

// Namespace: UnityEngine
[Flags]
public enum AdditionalCanvasShaderChannels // TypeDefIndex: 18003
{
	// Fields
	public int value__; // 0x0
	public const AdditionalCanvasShaderChannels None = 0;
	public const AdditionalCanvasShaderChannels TexCoord1 = 1;
	public const AdditionalCanvasShaderChannels TexCoord2 = 2;
	public const AdditionalCanvasShaderChannels TexCoord3 = 4;
	public const AdditionalCanvasShaderChannels Normal = 8;
	public const AdditionalCanvasShaderChannels Tangent = 16;
}

// Namespace: 
public sealed class Canvas.WillRenderCanvases : MulticastDelegate // TypeDefIndex: 18004
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[RequireComponent(typeof(RectTransform))]
[NativeHeader("Modules/UI/UIStructs.h")]
[NativeClass("UI::Canvas")]
public sealed class Canvas : Behaviour // TypeDefIndex: 18005
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases preWillRenderCanvases; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<int> <externBeginRenderOverlays>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<int, int> <externRenderOverlaysBefore>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int> <externEndRenderOverlays>k__BackingField; // 0x20

	// Properties
	public RenderMode renderMode { get; set; }
	public bool isRootCanvas { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool pixelPerfect { get; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; }
	public int sortingLayerID { get; set; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public Canvas rootCanvas { get; }
	public Vector2 renderingDisplaySize { get; }
	internal static Action<int> externBeginRenderOverlays { get; set; }
	internal static Action<int, int> externRenderOverlaysBefore { get; set; }
	internal static Action<int> externEndRenderOverlays { get; set; }
	[NativeProperty("Camera", False, 0)]
	public Camera worldCamera { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x26CE660 Offset: 0x26CD860 VA: 0x1826CE660
	public static void add_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x26CEC80 Offset: 0x26CDE80 VA: 0x1826CEC80
	public static void remove_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x26CE720 Offset: 0x26CD920 VA: 0x1826CE720
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x26CED40 Offset: 0x26CDF40 VA: 0x1826CED40
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x26CE9E0 Offset: 0x26CDBE0 VA: 0x1826CE9E0
	public RenderMode get_renderMode() { }

	// RVA: 0x26CEFA0 Offset: 0x26CE1A0 VA: 0x1826CEFA0
	public void set_renderMode(RenderMode value) { }

	// RVA: 0x26CE8E0 Offset: 0x26CDAE0 VA: 0x1826CE8E0
	public bool get_isRootCanvas() { }

	// RVA: 0x26CEB40 Offset: 0x26CDD40 VA: 0x1826CEB40
	public float get_scaleFactor() { }

	// RVA: 0x26CEFE0 Offset: 0x26CE1E0 VA: 0x1826CEFE0
	public void set_scaleFactor(float value) { }

	// RVA: 0x26CE9A0 Offset: 0x26CDBA0 VA: 0x1826CE9A0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x26CEF50 Offset: 0x26CE150 VA: 0x1826CEF50
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x26CE960 Offset: 0x26CDB60 VA: 0x1826CE960
	public bool get_pixelPerfect() { }

	// RVA: 0x26CEA20 Offset: 0x26CDC20 VA: 0x1826CEA20
	public int get_renderOrder() { }

	// RVA: 0x26CE920 Offset: 0x26CDB20 VA: 0x1826CE920
	public bool get_overrideSorting() { }

	// RVA: 0x26CEF00 Offset: 0x26CE100 VA: 0x1826CEF00
	public void set_overrideSorting(bool value) { }

	// RVA: 0x26CEBC0 Offset: 0x26CDDC0 VA: 0x1826CEBC0
	public int get_sortingOrder() { }

	// RVA: 0x26CF070 Offset: 0x26CE270 VA: 0x1826CF070
	public void set_sortingOrder(int value) { }

	// RVA: 0x26CEC00 Offset: 0x26CDE00 VA: 0x1826CEC00
	public int get_targetDisplay() { }

	// RVA: 0x26CEB80 Offset: 0x26CDD80 VA: 0x1826CEB80
	public int get_sortingLayerID() { }

	// RVA: 0x26CF030 Offset: 0x26CE230 VA: 0x1826CF030
	public void set_sortingLayerID(int value) { }

	// RVA: 0x26CE7E0 Offset: 0x26CD9E0 VA: 0x1826CE7E0
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x26CEE00 Offset: 0x26CE000 VA: 0x1826CEE00
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x26CEB00 Offset: 0x26CDD00 VA: 0x1826CEB00
	public Canvas get_rootCanvas() { }

	// RVA: 0x26CEAB0 Offset: 0x26CDCB0 VA: 0x1826CEAB0
	public Vector2 get_renderingDisplaySize() { }

	[CompilerGenerated]
	// RVA: 0x26CE820 Offset: 0x26CDA20 VA: 0x1826CE820
	internal static Action<int> get_externBeginRenderOverlays() { }

	[CompilerGenerated]
	// RVA: 0x26CEE40 Offset: 0x26CE040 VA: 0x1826CEE40
	internal static void set_externBeginRenderOverlays(Action<int> value) { }

	[CompilerGenerated]
	// RVA: 0x26CE8A0 Offset: 0x26CDAA0 VA: 0x1826CE8A0
	internal static Action<int, int> get_externRenderOverlaysBefore() { }

	[CompilerGenerated]
	// RVA: 0x26CEEC0 Offset: 0x26CE0C0 VA: 0x1826CEEC0
	internal static void set_externRenderOverlaysBefore(Action<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x26CE860 Offset: 0x26CDA60 VA: 0x1826CE860
	internal static Action<int> get_externEndRenderOverlays() { }

	[CompilerGenerated]
	// RVA: 0x26CEE80 Offset: 0x26CE080 VA: 0x1826CEE80
	internal static void set_externEndRenderOverlays(Action<int> value) { }

	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	// RVA: 0x26CE620 Offset: 0x26CD820 VA: 0x1826CE620
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	// RVA: 0x26CEC40 Offset: 0x26CDE40 VA: 0x1826CEC40
	public Camera get_worldCamera() { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	// RVA: 0x26CE4C0 Offset: 0x26CD6C0 VA: 0x1826CE4C0
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	// RVA: 0x26CE4F0 Offset: 0x26CD6F0 VA: 0x1826CE4F0
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x26CE430 Offset: 0x26CD630 VA: 0x1826CE430
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x26CE580 Offset: 0x26CD780 VA: 0x1826CE580
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x26CE5D0 Offset: 0x26CD7D0 VA: 0x1826CE5D0
	private static void SendWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x26CE370 Offset: 0x26CD570 VA: 0x1826CE370
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[RequiredByNativeCode]
	// RVA: 0x26CE520 Offset: 0x26CD720 VA: 0x1826CE520
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[RequiredByNativeCode]
	// RVA: 0x26CE3D0 Offset: 0x26CD5D0 VA: 0x1826CE3D0
	private static void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x26CEA60 Offset: 0x26CDC60 VA: 0x1826CEA60
	private void get_renderingDisplaySize_Injected(out Vector2 ret) { }
}

// Namespace: 
public enum UISystemProfilerApi.SampleType // TypeDefIndex: 18006
{
	// Fields
	public int value__; // 0x0
	public const UISystemProfilerApi.SampleType Layout = 0;
	public const UISystemProfilerApi.SampleType Render = 1;
}

// Namespace: UnityEngine
[StaticAccessor("UI::SystemProfilerApi", 2)]
[IgnoredByDeepProfiler]
[NativeHeader("Modules/UI/Canvas.h")]
public static class UISystemProfilerApi // TypeDefIndex: 18007
{
	// Methods

	// RVA: 0x26D0670 Offset: 0x26CF870 VA: 0x1826D0670
	public static void BeginSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x26D06B0 Offset: 0x26CF8B0 VA: 0x1826D06B0
	public static void EndSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x26D0620 Offset: 0x26CF820 VA: 0x1826D0620
	public static void AddMarker(string name, Object obj) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18008
{}

// Namespace: UnityEngine
public enum TouchPhase // TypeDefIndex: 18009
{
	// Fields
	public int value__; // 0x0
	public const TouchPhase Began = 0;
	public const TouchPhase Moved = 1;
	public const TouchPhase Stationary = 2;
	public const TouchPhase Ended = 3;
	public const TouchPhase Canceled = 4;
}

// Namespace: UnityEngine
public enum IMECompositionMode // TypeDefIndex: 18010
{
	// Fields
	public int value__; // 0x0
	public const IMECompositionMode Auto = 0;
	public const IMECompositionMode On = 1;
	public const IMECompositionMode Off = 2;
}

// Namespace: UnityEngine
public enum TouchType // TypeDefIndex: 18011
{
	// Fields
	public int value__; // 0x0
	public const TouchType Direct = 0;
	public const TouchType Indirect = 1;
	public const TouchType Stylus = 2;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public struct Touch // TypeDefIndex: 18012
{
	// Fields
	private int m_FingerId; // 0x0
	private Vector2 m_Position; // 0x4
	private Vector2 m_RawPosition; // 0xC
	private Vector2 m_PositionDelta; // 0x14
	private float m_TimeDelta; // 0x1C
	private int m_TapCount; // 0x20
	private TouchPhase m_Phase; // 0x24
	private TouchType m_Type; // 0x28
	private float m_Pressure; // 0x2C
	private float m_maximumPossiblePressure; // 0x30
	private float m_Radius; // 0x34
	private float m_RadiusVariance; // 0x38
	private float m_AltitudeAngle; // 0x3C
	private float m_AzimuthAngle; // 0x40

	// Properties
	public int fingerId { get; }
	public Vector2 position { get; set; }
	public Vector2 rawPosition { get; set; }
	public Vector2 deltaPosition { get; set; }
	public float deltaTime { get; }
	public int tapCount { get; }
	public TouchPhase phase { get; }
	public float pressure { get; }
	public float maximumPossiblePressure { get; }
	public TouchType type { get; }
	public float altitudeAngle { get; }
	public float azimuthAngle { get; }
	public float radius { get; }
	public float radiusVariance { get; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public int get_fingerId() { }

	// RVA: 0x24E28F0 Offset: 0x24E1AF0 VA: 0x1824E28F0
	public Vector2 get_position() { }

	// RVA: 0x775120 Offset: 0x774320 VA: 0x180775120
	public void set_position(Vector2 value) { }

	// RVA: 0x24E2930 Offset: 0x24E1B30 VA: 0x1824E2930
	public Vector2 get_rawPosition() { }

	// RVA: 0x775110 Offset: 0x774310 VA: 0x180775110
	public void set_rawPosition(Vector2 value) { }

	// RVA: 0x24E28A0 Offset: 0x24E1AA0 VA: 0x1824E28A0
	public Vector2 get_deltaPosition() { }

	// RVA: 0x24E2950 Offset: 0x24E1B50 VA: 0x1824E2950
	public void set_deltaPosition(Vector2 value) { }

	// RVA: 0x24E28C0 Offset: 0x24E1AC0 VA: 0x1824E28C0
	public float get_deltaTime() { }

	// RVA: 0xC9F3A0 Offset: 0xC9E5A0 VA: 0x180C9F3A0
	public int get_tapCount() { }

	// RVA: 0x24E28E0 Offset: 0x24E1AE0 VA: 0x1824E28E0
	public TouchPhase get_phase() { }

	// RVA: 0x24E2910 Offset: 0x24E1B10 VA: 0x1824E2910
	public float get_pressure() { }

	// RVA: 0x24E28D0 Offset: 0x24E1AD0 VA: 0x1824E28D0
	public float get_maximumPossiblePressure() { }

	// RVA: 0xC9F3C0 Offset: 0xC9E5C0 VA: 0x180C9F3C0
	public TouchType get_type() { }

	// RVA: 0x23C42B0 Offset: 0x23C34B0 VA: 0x1823C42B0
	public float get_altitudeAngle() { }

	// RVA: 0x24E2890 Offset: 0x24E1A90 VA: 0x1824E2890
	public float get_azimuthAngle() { }

	// RVA: 0x24E2920 Offset: 0x24E1B20 VA: 0x1824E2920
	public float get_radius() { }

	// RVA: 0x23C4420 Offset: 0x23C3620 VA: 0x1823C4420
	public float get_radiusVariance() { }
}

// Namespace: UnityEngine
[Flags]
public enum PenStatus // TypeDefIndex: 18013
{
	// Fields
	public int value__; // 0x0
	public const PenStatus None = 0;
	public const PenStatus Contact = 1;
	public const PenStatus Barrel = 2;
	public const PenStatus Inverted = 4;
	public const PenStatus Eraser = 8;
}

// Namespace: UnityEngine
public enum PenEventType // TypeDefIndex: 18014
{
	// Fields
	public int value__; // 0x0
	public const PenEventType NoContact = 0;
	public const PenEventType PenDown = 1;
	public const PenEventType PenUp = 2;
}

// Namespace: UnityEngine
public struct PenData // TypeDefIndex: 18015
{
	// Fields
	public Vector2 position; // 0x0
	public Vector2 tilt; // 0x8
	public PenStatus penStatus; // 0x10
	public float twist; // 0x14
	public float pressure; // 0x18
	public PenEventType contactType; // 0x1C
	public Vector2 deltaPos; // 0x20
}

// Namespace: UnityEngine
public enum DeviceOrientation // TypeDefIndex: 18016
{
	// Fields
	public int value__; // 0x0
	public const DeviceOrientation Unknown = 0;
	public const DeviceOrientation Portrait = 1;
	public const DeviceOrientation PortraitUpsideDown = 2;
	public const DeviceOrientation LandscapeLeft = 3;
	public const DeviceOrientation LandscapeRight = 4;
	public const DeviceOrientation FaceUp = 5;
	public const DeviceOrientation FaceDown = 6;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/Camera.h")]
internal class CameraRaycastHelper // TypeDefIndex: 18017
{
	// Methods

	[FreeFunction("CameraScripting::RaycastTry")]
	// RVA: 0x24E01C0 Offset: 0x24DF3C0 VA: 0x1824E01C0
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunction("CameraScripting::RaycastTry2D")]
	// RVA: 0x24E00E0 Offset: 0x24DF2E0 VA: 0x1824E00E0
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x24E0150 Offset: 0x24DF350 VA: 0x1824E0150
	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	// RVA: 0x24E0070 Offset: 0x24DF270 VA: 0x1824E0070
	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public class Input // TypeDefIndex: 18018
{
	// Properties
	public static bool simulateMouseWithTouches { get; set; }
	[NativeThrows]
	public static bool anyKey { get; }
	[NativeThrows]
	public static bool anyKeyDown { get; }
	[NativeThrows]
	public static string inputString { get; }
	[NativeThrows]
	public static Vector3 mousePosition { get; }
	[NativeThrows]
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	public static bool mousePresent { get; }
	public static int touchCount { get; }
	public static bool touchPressureSupported { get; }
	public static bool touchSupported { get; }
	public static bool multiTouchEnabled { get; set; }
	public static DeviceOrientation deviceOrientation { get; }
	public static Vector3 acceleration { get; }
	public static Touch[] touches { get; }

	// Methods

	// RVA: 0x24E0430 Offset: 0x24DF630 VA: 0x1824E0430
	public static float GetAxis(string axisName) { }

	// RVA: 0x24E03B0 Offset: 0x24DF5B0 VA: 0x1824E03B0
	public static float GetAxisRaw(string axisName) { }

	// RVA: 0x24E05B0 Offset: 0x24DF7B0 VA: 0x1824E05B0
	public static bool GetButton(string buttonName) { }

	// RVA: 0x24E04B0 Offset: 0x24DF6B0 VA: 0x1824E04B0
	public static bool GetButtonDown(string buttonName) { }

	// RVA: 0x24E0530 Offset: 0x24DF730 VA: 0x1824E0530
	public static bool GetButtonUp(string buttonName) { }

	[NativeThrows]
	// RVA: 0x24E0780 Offset: 0x24DF980 VA: 0x1824E0780
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x24E07C0 Offset: 0x24DF9C0 VA: 0x1824E07C0
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x24E0740 Offset: 0x24DF940 VA: 0x1824E0740
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x24E0910 Offset: 0x24DFB10 VA: 0x1824E0910
	public static bool GetMouseButton(int button) { }

	[NativeThrows]
	// RVA: 0x24E0890 Offset: 0x24DFA90 VA: 0x1824E0890
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrows]
	// RVA: 0x24E08D0 Offset: 0x24DFAD0 VA: 0x1824E08D0
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrows]
	// RVA: 0x24E0710 Offset: 0x24DF910 VA: 0x1824E0710
	public static string[] GetJoystickNames() { }

	[NativeThrows]
	// RVA: 0x24E0990 Offset: 0x24DFB90 VA: 0x1824E0990
	public static Touch GetTouch(int index) { }

	[NativeThrows]
	// RVA: 0x24E0840 Offset: 0x24DFA40 VA: 0x1824E0840
	public static PenData GetLastPenContactEvent() { }

	[NativeThrows]
	// RVA: 0x24E06E0 Offset: 0x24DF8E0 VA: 0x1824E06E0
	public static void ClearLastPenContactEvent() { }

	// RVA: 0x24E0780 Offset: 0x24DF980 VA: 0x1824E0780
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x24E07C0 Offset: 0x24DF9C0 VA: 0x1824E07C0
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x24E0740 Offset: 0x24DF940 VA: 0x1824E0740
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x24E0D70 Offset: 0x24DFF70 VA: 0x1824E0D70
	public static bool get_simulateMouseWithTouches() { }

	// RVA: 0x24E1080 Offset: 0x24E0280 VA: 0x1824E1080
	public static void set_simulateMouseWithTouches(bool value) { }

	// RVA: 0x24E0AA0 Offset: 0x24DFCA0 VA: 0x1824E0AA0
	public static bool get_anyKey() { }

	// RVA: 0x24E0A70 Offset: 0x24DFC70 VA: 0x1824E0A70
	public static bool get_anyKeyDown() { }

	// RVA: 0x24E0BE0 Offset: 0x24DFDE0 VA: 0x1824E0BE0
	public static string get_inputString() { }

	// RVA: 0x24E0C50 Offset: 0x24DFE50 VA: 0x1824E0C50
	public static Vector3 get_mousePosition() { }

	// RVA: 0x24E0D00 Offset: 0x24DFF00 VA: 0x1824E0D00
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x24E0BB0 Offset: 0x24DFDB0 VA: 0x1824E0BB0
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x24E1000 Offset: 0x24E0200 VA: 0x1824E1000
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x24E0B50 Offset: 0x24DFD50 VA: 0x1824E0B50
	public static string get_compositionString() { }

	// RVA: 0x24E0B10 Offset: 0x24DFD10 VA: 0x1824E0B10
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x24E0FC0 Offset: 0x24E01C0 VA: 0x1824E0FC0
	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunction("GetMousePresent")]
	// RVA: 0x24E0C90 Offset: 0x24DFE90 VA: 0x1824E0C90
	public static bool get_mousePresent() { }

	[FreeFunction("GetTouchCount")]
	// RVA: 0x24E0DA0 Offset: 0x24DFFA0 VA: 0x1824E0DA0
	public static int get_touchCount() { }

	[FreeFunction("IsTouchPressureSupported")]
	// RVA: 0x24E0DD0 Offset: 0x24DFFD0 VA: 0x1824E0DD0
	public static bool get_touchPressureSupported() { }

	[FreeFunction("IsTouchSupported")]
	// RVA: 0x24E0E00 Offset: 0x24E0000 VA: 0x1824E0E00
	public static bool get_touchSupported() { }

	[FreeFunction("IsMultiTouchEnabled")]
	// RVA: 0x24E0D40 Offset: 0x24DFF40 VA: 0x1824E0D40
	public static bool get_multiTouchEnabled() { }

	[FreeFunction("SetMultiTouchEnabled")]
	// RVA: 0x24E1040 Offset: 0x24E0240 VA: 0x1824E1040
	public static void set_multiTouchEnabled(bool value) { }

	[FreeFunction("GetDeviceOrientation")]
	// RVA: 0x24E0B80 Offset: 0x24DFD80 VA: 0x1824E0B80
	public static DeviceOrientation get_deviceOrientation() { }

	[FreeFunction("GetAcceleration")]
	// RVA: 0x24E0A30 Offset: 0x24DFC30 VA: 0x1824E0A30
	public static Vector3 get_acceleration() { }

	// RVA: 0x24E0E30 Offset: 0x24E0030 VA: 0x1824E0E30
	public static Touch[] get_touches() { }

	// RVA: 0x24E06B0 Offset: 0x24DF8B0 VA: 0x1824E06B0
	internal static bool CheckDisabled() { }

	// RVA: 0x24E0950 Offset: 0x24DFB50 VA: 0x1824E0950
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x24E0800 Offset: 0x24DFA00 VA: 0x1824E0800
	private static void GetLastPenContactEvent_Injected(out PenData ret) { }

	// RVA: 0x24E0C10 Offset: 0x24DFE10 VA: 0x1824E0C10
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x24E0CC0 Offset: 0x24DFEC0 VA: 0x1824E0CC0
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x24E0AD0 Offset: 0x24DFCD0 VA: 0x1824E0AD0
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x24E0F80 Offset: 0x24E0180 VA: 0x1824E0F80
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	// RVA: 0x24E09F0 Offset: 0x24DFBF0 VA: 0x1824E09F0
	private static void get_acceleration_Injected(out Vector3 ret) { }
}

// Namespace: 
private struct SendMouseEvents.HitInfo // TypeDefIndex: 18019
{
	// Fields
	public GameObject target; // 0x0
	public Camera camera; // 0x8

	// Methods

	// RVA: 0x24E02C0 Offset: 0x24DF4C0 VA: 0x1824E02C0
	public void SendMessage(string name) { }

	// RVA: 0x24E02F0 Offset: 0x24DF4F0 VA: 0x1824E02F0
	public static bool op_Implicit(SendMouseEvents.HitInfo exists) { }

	// RVA: 0x24E0230 Offset: 0x24DF430 VA: 0x1824E0230
	public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs) { }
}

// Namespace: UnityEngine
internal class SendMouseEvents // TypeDefIndex: 18020
{
	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20
	public static Func<KeyValuePair<int, Vector2>> s_GetMouseState; // 0x28
	private static Vector2 s_MousePosition; // 0x30
	private static bool s_MouseButtonPressedThisFrame; // 0x38
	private static bool s_MouseButtonIsPressed; // 0x39

	// Methods

	// RVA: 0x24E2570 Offset: 0x24E1770 VA: 0x1824E2570
	private static void UpdateMouse() { }

	[RequiredByNativeCode]
	// RVA: 0x24E2520 Offset: 0x24E1720 VA: 0x1824E2520
	private static void SetMouseMoved() { }

	[RequiredByNativeCode]
	// RVA: 0x24E10C0 Offset: 0x24E02C0 VA: 0x1824E10C0
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x24E1BA0 Offset: 0x24E0DA0 VA: 0x1824E1BA0
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x24E27E0 Offset: 0x24E19E0 VA: 0x1824E27E0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Internal
[NativeHeader("Runtime/Input/InputBindings.h")]
internal static class InputUnsafeUtility // TypeDefIndex: 18021
{
	// Methods

	[NativeThrows]
	// RVA: 0x24E0630 Offset: 0x24DF830 VA: 0x1824E0630
	internal static bool GetKeyString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x24E0670 Offset: 0x24DF870 VA: 0x1824E0670
	internal static bool GetKeyUpString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x24E05F0 Offset: 0x24DF7F0 VA: 0x1824E05F0
	internal static bool GetKeyDownString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x24E0430 Offset: 0x24DF630 VA: 0x1824E0430
	internal static float GetAxis(string axisName) { }

	[NativeThrows]
	// RVA: 0x24E03F0 Offset: 0x24DF5F0 VA: 0x1824E03F0
	internal static float GetAxis__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x24E03B0 Offset: 0x24DF5B0 VA: 0x1824E03B0
	internal static float GetAxisRaw(string axisName) { }

	[NativeThrows]
	// RVA: 0x24E0370 Offset: 0x24DF570 VA: 0x1824E0370
	internal static float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x24E05B0 Offset: 0x24DF7B0 VA: 0x1824E05B0
	internal static bool GetButton(string buttonName) { }

	[NativeThrows]
	// RVA: 0x24E0570 Offset: 0x24DF770 VA: 0x1824E0570
	internal static bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x24E04B0 Offset: 0x24DF6B0 VA: 0x1824E04B0
	internal static bool GetButtonDown(string buttonName) { }

	[NativeThrows]
	// RVA: 0x24E0470 Offset: 0x24DF670 VA: 0x1824E0470
	internal static byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x24E0530 Offset: 0x24DF730 VA: 0x1824E0530
	internal static bool GetButtonUp(string buttonName) { }

	[NativeThrows]
	// RVA: 0x24E04F0 Offset: 0x24DF6F0 VA: 0x1824E04F0
	internal static bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18022
{}

// Namespace: UnityEngine
[UsedByNativeCode]
[StaticAccessor("GetITerrainManager()", 1)]
[NativeHeader("TerrainScriptingClasses.h")]
[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
[NativeHeader("Modules/Terrain/Public/Terrain.h")]
public sealed class Terrain : Behaviour // TypeDefIndex: 18023
{
	// Properties
	public TerrainData terrainData { get; }
	public bool allowAutoConnect { get; }
	public int groupingID { get; }
	[NativeProperty("ActiveTerrainsScriptingArray")]
	public static Terrain[] activeTerrains { get; }

	// Methods

	// RVA: 0x25072B0 Offset: 0x25064B0 VA: 0x1825072B0
	public TerrainData get_terrainData() { }

	// RVA: 0x2507230 Offset: 0x2506430 VA: 0x182507230
	public bool get_allowAutoConnect() { }

	// RVA: 0x2507270 Offset: 0x2506470 VA: 0x182507270
	public int get_groupingID() { }

	// RVA: 0x2507190 Offset: 0x2506390 VA: 0x182507190
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x2507200 Offset: 0x2506400 VA: 0x182507200
	public static Terrain[] get_activeTerrains() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public sealed class TerrainCallbacks.HeightmapChangedCallback : MulticastDelegate // TypeDefIndex: 18024
{
	// Methods

	// RVA: 0x2504FA0 Offset: 0x25041A0 VA: 0x182504FA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x442090 Offset: 0x441290 VA: 0x180442090 Slot: 13
	public virtual void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }
}

// Namespace: 
public sealed class TerrainCallbacks.TextureChangedCallback : MulticastDelegate // TypeDefIndex: 18025
{
	// Methods

	// RVA: 0x2507330 Offset: 0x2506530 VA: 0x182507330
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x25072F0 Offset: 0x25064F0 VA: 0x1825072F0 Slot: 13
	public virtual void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }
}

// Namespace: UnityEngine
[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainCallbacks // TypeDefIndex: 18026
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static TerrainCallbacks.HeightmapChangedCallback heightmapChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static TerrainCallbacks.TextureChangedCallback textureChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2505050 Offset: 0x2504250 VA: 0x182505050
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCode]
	// RVA: 0x2505160 Offset: 0x2504360 VA: 0x182505160
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }
}

// Namespace: 
private enum TerrainData.BoundaryValueType // TypeDefIndex: 18027
{
	// Fields
	public int value__; // 0x0
	public const TerrainData.BoundaryValueType MaxHeightmapRes = 0;
	public const TerrainData.BoundaryValueType MinDetailResPerPatch = 1;
	public const TerrainData.BoundaryValueType MaxDetailResPerPatch = 2;
	public const TerrainData.BoundaryValueType MaxDetailPatchCount = 3;
	public const TerrainData.BoundaryValueType MaxCoveragePerRes = 4;
	public const TerrainData.BoundaryValueType MinAlphamapRes = 5;
	public const TerrainData.BoundaryValueType MaxAlphamapRes = 6;
	public const TerrainData.BoundaryValueType MinBaseMapRes = 7;
	public const TerrainData.BoundaryValueType MaxBaseMapRes = 8;
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
[NativeHeader("TerrainScriptingClasses.h")]
public sealed class TerrainData : Object // TypeDefIndex: 18028
{
	// Fields
	internal static readonly int k_MaximumResolution; // 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x8
	internal static readonly int k_MaximumDetailPatchCount; // 0xC
	internal static readonly int k_MinimumAlphamapResolution; // 0x10
	internal static readonly int k_MaximumAlphamapResolution; // 0x14
	internal static readonly int k_MinimumBaseMapResolution; // 0x18
	internal static readonly int k_MaximumBaseMapResolution; // 0x1C

	// Properties
	public Vector3 size { get; }
	internal Terrain[] users { get; }

	// Methods

	[StaticAccessor("TerrainDataScriptingInterface", 2)]
	[ThreadSafe]
	// RVA: 0x25052C0 Offset: 0x25044C0 VA: 0x1825052C0
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	// RVA: 0x2505520 Offset: 0x2504720 VA: 0x182505520
	public void .ctor() { }

	[FreeFunction("TerrainDataScriptingInterface::Create")]
	// RVA: 0x2505300 Offset: 0x2504500 VA: 0x182505300
	private static void Internal_Create(TerrainData terrainData) { }

	[NativeName("GetHeightmap().GetSize")]
	// RVA: 0x2505600 Offset: 0x2504800 VA: 0x182505600
	public Vector3 get_size() { }

	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	[RequiredByNativeCode]
	// RVA: 0x2505280 Offset: 0x2504480 VA: 0x182505280
	internal float GetAlphamapResolutionInternal() { }

	// RVA: 0x2505650 Offset: 0x2504850 VA: 0x182505650
	internal Terrain[] get_users() { }

	// RVA: 0x2505340 Offset: 0x2504540 VA: 0x182505340
	private static void .cctor() { }

	// RVA: 0x25055B0 Offset: 0x25047B0 VA: 0x1825055B0
	private void get_size_Injected(out Vector3 ret) { }
}

// Namespace: UnityEngine.TerrainUtils
internal enum TerrainMapStatusCode // TypeDefIndex: 18029
{
	// Fields
	public int value__; // 0x0
	public const TerrainMapStatusCode OK = 0;
	public const TerrainMapStatusCode Overlapping = 1;
	public const TerrainMapStatusCode SizeMismatch = 4;
	public const TerrainMapStatusCode EdgeAlignmentMismatch = 8;
}

// Namespace: UnityEngine.TerrainUtils
[IsReadOnly]
public struct TerrainTileCoord // TypeDefIndex: 18030
{
	// Fields
	public readonly int tileX; // 0x0
	public readonly int tileZ; // 0x4

	// Methods

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void .ctor(int tileX, int tileZ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TerrainMap.<>c__DisplayClass3_0 // TypeDefIndex: 18031
{
	// Fields
	public int groupID; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25074C0 Offset: 0x25066C0 VA: 0x1825074C0
	internal bool <CreateFromPlacement>b__0(Terrain x) { }
}

// Namespace: UnityEngine.TerrainUtils
public class TerrainMap // TypeDefIndex: 18032
{
	// Fields
	private Vector3 m_patchSize; // 0x10
	private TerrainMapStatusCode m_errorCode; // 0x1C
	private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles; // 0x20

	// Properties
	public Dictionary<TerrainTileCoord, Terrain> terrainTiles { get; }

	// Methods

	// RVA: 0x2505F30 Offset: 0x2505130 VA: 0x182505F30
	public Terrain GetTerrain(int tileX, int tileZ) { }

	// RVA: 0x2505BF0 Offset: 0x2504DF0 VA: 0x182505BF0
	public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter, bool fullValidation = True) { }

	// RVA: 0x2505870 Offset: 0x2504A70 VA: 0x182505870
	public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter, bool fullValidation = True) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Dictionary<TerrainTileCoord, Terrain> get_terrainTiles() { }

	// RVA: 0x25068A0 Offset: 0x2505AA0 VA: 0x1825068A0
	public void .ctor() { }

	// RVA: 0x2505690 Offset: 0x2504890 VA: 0x182505690
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	// RVA: 0x2505FB0 Offset: 0x25051B0 VA: 0x182505FB0
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	// RVA: 0x25060C0 Offset: 0x25052C0 VA: 0x1825060C0
	private void ValidateTerrain(int tileX, int tileZ) { }

	// RVA: 0x2506760 Offset: 0x2505960 VA: 0x182506760
	private TerrainMapStatusCode Validate() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TerrainUtility.<>c__DisplayClass2_0 // TypeDefIndex: 18033
{
	// Fields
	public bool onlyAutoConnectedTerrains; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TerrainUtility.<>c__DisplayClass2_1 // TypeDefIndex: 18034
{
	// Fields
	public Terrain t; // 0x10
	public TerrainUtility.<>c__DisplayClass2_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25073E0 Offset: 0x25065E0 VA: 0x1825073E0
	internal bool <CollectTerrains>b__0(Terrain x) { }
}

// Namespace: UnityEngine.TerrainUtils
[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainUtility // TypeDefIndex: 18035
{
	// Methods

	// RVA: 0x2507120 Offset: 0x2506320 VA: 0x182507120
	internal static bool ValidTerrainsExist() { }

	// RVA: 0x2506D30 Offset: 0x2505F30 VA: 0x182506D30
	internal static void ClearConnectivity() { }

	// RVA: 0x2506E30 Offset: 0x2506030 VA: 0x182506E30
	internal static Dictionary<int, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = True) { }

	[RequiredByNativeCode]
	// RVA: 0x2506920 Offset: 0x2505B20 VA: 0x182506920
	public static void AutoConnect() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18036
{}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(4, Inherited = False)]
internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 18037
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <preferredExtension>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	public void .ctor(string preferredExtension, string[] otherExtensions) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(64)]
internal class ThreadAndSerializationSafeAttribute : Attribute // TypeDefIndex: 18038
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(2048, AllowMultiple = False)]
[VisibleToOtherModules]
internal class WritableAttribute : Attribute // TypeDefIndex: 18039
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(4)]
internal class RejectDragAndDropMaterial : Attribute // TypeDefIndex: 18040
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(1)]
internal class UnityEngineModuleAssembly : Attribute // TypeDefIndex: 18041
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(12, Inherited = False)]
[VisibleToOtherModules]
internal sealed class NativeClassAttribute : Attribute // TypeDefIndex: 18042
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <QualifiedNativeName>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Declaration>k__BackingField; // 0x18

	// Properties
	private string QualifiedNativeName { set; }
	private string Declaration { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_QualifiedNativeName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_Declaration(string value) { }

	// RVA: 0x2503600 Offset: 0x2502800 VA: 0x182503600
	public void .ctor(string qualifiedCppName) { }

	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	public void .ctor(string qualifiedCppName, string declaration) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
internal sealed class UnityString // TypeDefIndex: 18043
{
	// Methods

	// RVA: 0x2503CC0 Offset: 0x2502EC0 VA: 0x182503CC0
	public static string Format(string fmt, object[] args) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(5628, Inherited = False)]
internal class VisibleToOtherModulesAttribute : Attribute // TypeDefIndex: 18044
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor(string[] modules) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(204)]
internal class NativeConditionalAttribute : Attribute // TypeDefIndex: 18045
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Condition>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <Enabled>k__BackingField; // 0x18

	// Properties
	public string Condition { set; }
	public bool Enabled { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Condition(string value) { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_Enabled(bool value) { }

	// RVA: 0x2503660 Offset: 0x2502860 VA: 0x182503660
	public void .ctor(string condition) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(10716, AllowMultiple = True)]
internal class NativeHeaderAttribute : Attribute // TypeDefIndex: 18046
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Header>k__BackingField; // 0x10

	// Properties
	public string Header { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 7
	public void set_Header(string value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x2503690 Offset: 0x2502890 VA: 0x182503690
	public void .ctor(string header) { }
}

// Namespace: UnityEngine.Bindings
[Usage(448)]
[VisibleToOtherModules]
internal class NativeNameAttribute : Attribute // TypeDefIndex: 18047
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 7
	public void set_Name(string value) { }

	// RVA: 0x2503920 Offset: 0x2502B20 VA: 0x182503920
	public void .ctor(string name) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(64)]
internal sealed class NativeWritableSelfAttribute : Attribute // TypeDefIndex: 18048
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <WritableSelf>k__BackingField; // 0x10

	// Properties
	public bool WritableSelf { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0 Slot: 7
	public void set_WritableSelf(bool value) { }

	// RVA: 0x2315470 Offset: 0x2314670 VA: 0x182315470
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(192)]
internal class NativeMethodAttribute : Attribute // TypeDefIndex: 18049
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsThreadSafe>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsFreeFunction>k__BackingField; // 0x19
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <ThrowsException>k__BackingField; // 0x1A
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <HasExplicitThis>k__BackingField; // 0x1B

	// Properties
	public string Name { set; }
	public bool IsThreadSafe { set; }
	public bool IsFreeFunction { set; }
	public bool ThrowsException { set; }
	public bool HasExplicitThis { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 7
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30 Slot: 8
	public void set_IsThreadSafe(bool value) { }

	[CompilerGenerated]
	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50 Slot: 9
	public void set_IsFreeFunction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x18AE3F0 Offset: 0x18AD5F0 VA: 0x1818AE3F0 Slot: 10
	public void set_ThrowsException(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1AAD8C0 Offset: 0x1AACAC0 VA: 0x181AAD8C0 Slot: 11
	public void set_HasExplicitThis(bool value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x25037E0 Offset: 0x25029E0 VA: 0x1825037E0
	public void .ctor(string name) { }

	// RVA: 0x25038F0 Offset: 0x2502AF0 VA: 0x1825038F0
	public void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x25037A0 Offset: 0x25029A0 VA: 0x1825037A0
	public void .ctor(string name, bool isFreeFunction, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum TargetType // TypeDefIndex: 18050
{
	// Fields
	public int value__; // 0x0
	public const TargetType Function = 0;
	public const TargetType Field = 1;
}

// Namespace: UnityEngine.Bindings
[Usage(128)]
[VisibleToOtherModules]
internal class NativePropertyAttribute : NativeMethodAttribute // TypeDefIndex: 18051
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private TargetType <TargetType>k__BackingField; // 0x20

	// Properties
	public TargetType TargetType { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_TargetType(TargetType value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x2503A30 Offset: 0x2502C30 VA: 0x182503A30
	public void .ctor(string name) { }

	// RVA: 0x2503A40 Offset: 0x2502C40 VA: 0x182503A40
	public void .ctor(string name, bool isFree, TargetType targetType) { }

	// RVA: 0x2503A80 Offset: 0x2502C80 VA: 0x182503A80
	public void .ctor(string name, bool isFree, TargetType targetType, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum CodegenOptions // TypeDefIndex: 18052
{
	// Fields
	public int value__; // 0x0
	public const CodegenOptions Auto = 0;
	public const CodegenOptions Custom = 1;
	public const CodegenOptions Force = 2;
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(4)]
internal class NativeAsStructAttribute : Attribute // TypeDefIndex: 18053
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[Usage(28)]
[VisibleToOtherModules]
internal class NativeTypeAttribute : Attribute // TypeDefIndex: 18054
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Header>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <IntermediateScriptingStructName>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Properties
	public string Header { set; }
	public string IntermediateScriptingStructName { set; }
	public CodegenOptions CodegenOptions { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 7
	public void set_Header(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_IntermediateScriptingStructName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420 Slot: 8
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x2503C40 Offset: 0x2502E40 VA: 0x182503C40
	public void .ctor() { }

	// RVA: 0x2503BD0 Offset: 0x2502DD0 VA: 0x182503BD0
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x2503AC0 Offset: 0x2502CC0 VA: 0x182503AC0
	public void .ctor(string header) { }

	// RVA: 0x2503C00 Offset: 0x2502E00 VA: 0x182503C00
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(2048)]
internal class NotNullAttribute : Attribute // TypeDefIndex: 18055
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Exception>k__BackingField; // 0x10

	// Properties
	public string Exception { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Exception(string value) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string exception = "ArgumentNullException") { }
}

// Namespace: UnityEngine.Bindings
[Usage(2048)]
[VisibleToOtherModules]
internal class UnmarshalledAttribute : Attribute // TypeDefIndex: 18056
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[Usage(64)]
[VisibleToOtherModules]
internal class FreeFunctionAttribute : NativeMethodAttribute // TypeDefIndex: 18057
{
	// Methods

	// RVA: 0x2503590 Offset: 0x2502790 VA: 0x182503590
	public void .ctor() { }

	// RVA: 0x25035B0 Offset: 0x25027B0 VA: 0x1825035B0
	public void .ctor(string name) { }

	// RVA: 0x25035D0 Offset: 0x25027D0 VA: 0x1825035D0
	public void .ctor(string name, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[Usage(64)]
[VisibleToOtherModules]
internal class ThreadSafeAttribute : NativeMethodAttribute // TypeDefIndex: 18058
{
	// Methods

	// RVA: 0x2503CA0 Offset: 0x2502EA0 VA: 0x182503CA0
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum StaticAccessorType // TypeDefIndex: 18059
{
	// Fields
	public int value__; // 0x0
	public const StaticAccessorType Dot = 0;
	public const StaticAccessorType Arrow = 1;
	public const StaticAccessorType DoubleColon = 2;
	public const StaticAccessorType ArrowWithDefaultReturnIfNull = 3;
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(204)]
internal class StaticAccessorAttribute : Attribute // TypeDefIndex: 18060
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private StaticAccessorType <Type>k__BackingField; // 0x18

	// Properties
	public string Name { set; }
	public StaticAccessorType Type { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Type(StaticAccessorType value) { }

	[VisibleToOtherModules]
	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	internal void .ctor(string name) { }

	// RVA: 0x16774B0 Offset: 0x16766B0 VA: 0x1816774B0
	public void .ctor(string name, StaticAccessorType type) { }
}

// Namespace: UnityEngine.Bindings
[Usage(192)]
[VisibleToOtherModules]
internal class NativeThrowsAttribute : Attribute // TypeDefIndex: 18061
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <ThrowsException>k__BackingField; // 0x10

	// Properties
	public bool ThrowsException { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0 Slot: 7
	public void set_ThrowsException(bool value) { }

	// RVA: 0x2315470 Offset: 0x2314670 VA: 0x182315470
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[Usage(256)]
[VisibleToOtherModules]
internal class IgnoreAttribute : Attribute // TypeDefIndex: 18062
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <DoesNotContributeToSize>k__BackingField; // 0x10

	// Properties
	public bool DoesNotContributeToSize { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_DoesNotContributeToSize(bool value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[Usage(4, AllowMultiple = False, Inherited = False)]
[VisibleToOtherModules]
internal class PreventReadOnlyInstanceModificationAttribute : Attribute // TypeDefIndex: 18063
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[Usage(2048, AllowMultiple = False, Inherited = False)]
[VisibleToOtherModules]
internal class SpanAttribute : Attribute // TypeDefIndex: 18064
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <IsReadOnly>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <SizeParameter>k__BackingField; // 0x18

	// Methods

	// RVA: 0x2503C60 Offset: 0x2502E60 VA: 0x182503C60
	public void .ctor(string sizeParameter, bool isReadOnly = False) { }
}

// Namespace: UnityEngine.Scripting
[VisibleToOtherModules]
[Usage(1532, Inherited = False)]
internal class UsedByNativeCodeAttribute : Attribute // TypeDefIndex: 18065
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { set; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Name(string value) { }
}

// Namespace: UnityEngine.Scripting
[VisibleToOtherModules]
[Usage(1532, Inherited = False)]
internal class RequiredByNativeCodeAttribute : Attribute // TypeDefIndex: 18066
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <Optional>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <GenerateProxy>k__BackingField; // 0x19

	// Properties
	public string Name { set; }
	public bool Optional { set; }
	public bool GenerateProxy { set; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_Optional(bool value) { }

	[CompilerGenerated]
	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50
	public void set_GenerateProxy(bool value) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18067
{}

// Namespace: 
public sealed class RemoteSettings.UpdatedEventHandler : MulticastDelegate // TypeDefIndex: 18068
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
public static class RemoteSettings // TypeDefIndex: 18069
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static RemoteSettings.UpdatedEventHandler Updated; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action BeforeFetchFromServer; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<bool, bool, int> Completed; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2710D00 Offset: 0x270FF00 VA: 0x182710D00
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	[RequiredByNativeCode]
	// RVA: 0x2710C30 Offset: 0x270FE30 VA: 0x182710C30
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[RequiredByNativeCode]
	// RVA: 0x2710C80 Offset: 0x270FE80 VA: 0x182710C80
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[ExcludeFromDocs]
public class RemoteConfigSettings // TypeDefIndex: 18070
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<bool> Updated; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2710C00 Offset: 0x270FE00 VA: 0x182710C00
	internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer) { }
}

// Namespace: 
[RequiredByNativeCode]
internal enum RemoteConfigSettingsHelper.Tag // TypeDefIndex: 18071
{
	// Fields
	public int value__; // 0x0
	public const RemoteConfigSettingsHelper.Tag kUnknown = 0;
	public const RemoteConfigSettingsHelper.Tag kIntVal = 1;
	public const RemoteConfigSettingsHelper.Tag kInt64Val = 2;
	public const RemoteConfigSettingsHelper.Tag kUInt64Val = 3;
	public const RemoteConfigSettingsHelper.Tag kDoubleVal = 4;
	public const RemoteConfigSettingsHelper.Tag kBoolVal = 5;
	public const RemoteConfigSettingsHelper.Tag kStringVal = 6;
	public const RemoteConfigSettingsHelper.Tag kArrayVal = 7;
	public const RemoteConfigSettingsHelper.Tag kMixedArrayVal = 8;
	public const RemoteConfigSettingsHelper.Tag kMapVal = 9;
	public const RemoteConfigSettingsHelper.Tag kMaxTags = 10;
}

// Namespace: UnityEngine
internal static class RemoteConfigSettingsHelper // TypeDefIndex: 18072
{}

// Namespace: UnityEngine.Analytics
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
[ExcludeFromDocs]
[NativeHeader("Modules/UnityAnalytics/ContinuousEvent/Manager.h")]
[RequiredByNativeCode]
public class ContinuousEvent // TypeDefIndex: 18073
{}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode]
public enum AnalyticsSessionState // TypeDefIndex: 18074
{
	// Fields
	public int value__; // 0x0
	public const AnalyticsSessionState kSessionStopped = 0;
	public const AnalyticsSessionState kSessionStarted = 1;
	public const AnalyticsSessionState kSessionPaused = 2;
	public const AnalyticsSessionState kSessionResumed = 3;
}

// Namespace: 
public sealed class AnalyticsSessionInfo.SessionStateChanged : MulticastDelegate // TypeDefIndex: 18075
{
	// Methods

	// RVA: 0x2710D50 Offset: 0x270FF50 VA: 0x182710D50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x464E30 Offset: 0x464030 VA: 0x180464E30 Slot: 13
	public virtual void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }
}

// Namespace: 
public sealed class AnalyticsSessionInfo.IdentityTokenChanged : MulticastDelegate // TypeDefIndex: 18076
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(string token) { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
public static class AnalyticsSessionInfo // TypeDefIndex: 18077
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged; // 0x8

	// Properties
	public static long sessionId { get; }
	public static string userId { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x270F210 Offset: 0x270E410 VA: 0x18270F210
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	[NativeMethod("GetPlayerSessionId")]
	// RVA: 0x270F2A0 Offset: 0x270E4A0 VA: 0x18270F2A0
	public static long get_sessionId() { }

	[NativeMethod("GetUserId")]
	// RVA: 0x270F2D0 Offset: 0x270E4D0 VA: 0x18270F2D0
	public static string get_userId() { }

	[RequiredByNativeCode]
	// RVA: 0x270F1B0 Offset: 0x270E3B0 VA: 0x18270F1B0
	internal static void CallIdentityTokenChanged(string token) { }
}

// Namespace: UnityEngine.Analytics
[NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
internal class CustomEventData : IDisposable // TypeDefIndex: 18078
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x2710BB0 Offset: 0x270FDB0 VA: 0x182710BB0
	public void .ctor(string name) { }

	// RVA: 0x2710A80 Offset: 0x270FC80 VA: 0x182710A80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2710980 Offset: 0x270FB80 VA: 0x182710980
	private void Destroy() { }

	// RVA: 0x27109E0 Offset: 0x270FBE0 VA: 0x1827109E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2710B20 Offset: 0x270FD20 VA: 0x182710B20
	internal static IntPtr Internal_Create(CustomEventData ced, string name) { }

	[ThreadSafe]
	// RVA: 0x2710B70 Offset: 0x270FD70 VA: 0x182710B70
	internal static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x2710860 Offset: 0x270FA60 VA: 0x182710860
	public bool AddString(string key, string value) { }

	// RVA: 0x27107A0 Offset: 0x270F9A0 VA: 0x1827107A0
	public bool AddInt32(string key, int value) { }

	// RVA: 0x27108C0 Offset: 0x270FAC0 VA: 0x1827108C0
	public bool AddUInt32(string key, uint value) { }

	// RVA: 0x2710800 Offset: 0x270FA00 VA: 0x182710800
	public bool AddInt64(string key, long value) { }

	// RVA: 0x2710920 Offset: 0x270FB20 VA: 0x182710920
	public bool AddUInt64(string key, ulong value) { }

	// RVA: 0x270FAD0 Offset: 0x270ECD0 VA: 0x18270FAD0
	public bool AddBool(string key, bool value) { }

	// RVA: 0x2710740 Offset: 0x270F940 VA: 0x182710740
	public bool AddDouble(string key, double value) { }

	// RVA: 0x270FB30 Offset: 0x270ED30 VA: 0x18270FB30
	public bool AddDictionary(IDictionary<string, object> eventData) { }
}

// Namespace: UnityEngine.Analytics
[NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
[NativeHeader("Modules/UnityConnect/UnityConnectSettings.h")]
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
public static class Analytics // TypeDefIndex: 18079
{
	// Methods

	[ThreadSafe]
	// RVA: 0x270F5C0 Offset: 0x270E7C0 VA: 0x18270F5C0
	internal static bool IsInitialized() { }

	[StaticAccessor("GetUnityAnalytics()", 0)]
	// RVA: 0x270F870 Offset: 0x270EA70 VA: 0x18270F870
	private static AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

	[StaticAccessor("GetUnityAnalytics()", 0)]
	// RVA: 0x270F5F0 Offset: 0x270E7F0 VA: 0x18270F5F0
	private static AnalyticsResult SendCustomEventName(string customEventName) { }

	[StaticAccessor("GetUnityAnalytics()", 0)]
	// RVA: 0x270F630 Offset: 0x270E830 VA: 0x18270F630
	private static AnalyticsResult SendCustomEvent(CustomEventData eventData) { }

	// RVA: 0x270F8E0 Offset: 0x270EAE0 VA: 0x18270F8E0
	public static AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature) { }

	// RVA: 0x270F670 Offset: 0x270E870 VA: 0x18270F670
	public static AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

	// RVA: 0x270F500 Offset: 0x270E700 VA: 0x18270F500
	public static AnalyticsResult CustomEvent(string customEventName) { }

	// RVA: 0x270F300 Offset: 0x270E500 VA: 0x18270F300
	public static AnalyticsResult CustomEvent(string customEventName, IDictionary<string, object> eventData) { }
}

// Namespace: UnityEngine.Analytics
public enum AnalyticsResult // TypeDefIndex: 18080
{
	// Fields
	public int value__; // 0x0
	public const AnalyticsResult Ok = 0;
	public const AnalyticsResult NotInitialized = 1;
	public const AnalyticsResult AnalyticsDisabled = 2;
	public const AnalyticsResult TooManyItems = 3;
	public const AnalyticsResult SizeLimitReached = 4;
	public const AnalyticsResult TooManyRequests = 5;
	public const AnalyticsResult InvalidData = 6;
	public const AnalyticsResult UnsupportedPlatform = 7;
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18081
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 18082
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 18083
{
	// Methods

	// RVA: 0x3D85D0 Offset: 0x3D77D0 VA: 0x1803D85D0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ButtonInteraction.<Instantiate>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 18084
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ButtonInteraction <>4__this; // 0x20
	private AsyncOperationHandle<GameObject> <handle>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3D8410 Offset: 0x3D7610 VA: 0x1803D8410 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x3D8550 Offset: 0x3D7750 VA: 0x1803D8550 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: AddressablesPlayAssetDelivery
public class ButtonInteraction : MonoBehaviour // TypeDefIndex: 18085
{
	// Fields
	public AssetReference reference; // 0x20
	public Transform parent; // 0x28
	private bool isLoading; // 0x30
	private GameObject obj; // 0x38

	// Methods

	// RVA: 0x3D6060 Offset: 0x3D5260 VA: 0x1803D6060
	public void OnButtonClicked() { }

	[IteratorStateMachine(typeof(ButtonInteraction.<Instantiate>d__5))]
	// RVA: 0x3D6000 Offset: 0x3D5200 VA: 0x1803D6000
	private IEnumerator Instantiate() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: AddressablesPlayAssetDelivery
[Serializable]
public class CustomAssetPackDataEntry // TypeDefIndex: 18086
{
	// Fields
	public string AssetPackName; // 0x10
	public DeliveryType DeliveryType; // 0x18
	public List<string> AssetBundles; // 0x20

	// Methods

	// RVA: 0x3D61B0 Offset: 0x3D53B0 VA: 0x1803D61B0
	public void .ctor(string assetPackName, DeliveryType deliveryType, IEnumerable<string> assetBundles) { }
}

// Namespace: AddressablesPlayAssetDelivery
[Serializable]
public class CustomAssetPackData // TypeDefIndex: 18087
{
	// Fields
	public List<CustomAssetPackDataEntry> Entries; // 0x10

	// Methods

	// RVA: 0x3D6250 Offset: 0x3D5450 VA: 0x1803D6250
	public void .ctor(List<CustomAssetPackDataEntry> entries) { }
}

// Namespace: AddressablesPlayAssetDelivery
public enum DeliveryType // TypeDefIndex: 18088
{
	// Fields
	public int value__; // 0x0
	public const DeliveryType None = 0;
	public const DeliveryType InstallTime = 1;
	public const DeliveryType FastFollow = 2;
	public const DeliveryType OnDemand = 3;
}

// Namespace: AddressablesPlayAssetDelivery
public class CustomAssetPackUtility // TypeDefIndex: 18089
{
	// Fields
	public const string kBuildFolderName = "Build";
	public const string kPackContentFolderName = "CustomAssetPackContent";
	public const string kBuildProcessorDataFilename = "BuildProcessorData.json";
	public const string kCustomAssetPackDataFilename = "CustomAssetPacksData.json";

	// Properties
	public static string RootDirectory { get; }
	public static string BuildRootDirectory { get; }
	public static string PackContentRootDirectory { get; }
	public static string BuildProcessorDataPath { get; }
	public static string CustomAssetPacksDataEditorPath { get; }
	public static string CustomAssetPacksDataRuntimePath { get; }

	// Methods

	// RVA: 0x3D65C0 Offset: 0x3D57C0 VA: 0x1803D65C0
	public static string get_RootDirectory() { }

	// RVA: 0x3D6390 Offset: 0x3D5590 VA: 0x1803D6390
	public static string get_BuildRootDirectory() { }

	// RVA: 0x3D6530 Offset: 0x3D5730 VA: 0x1803D6530
	public static string get_PackContentRootDirectory() { }

	// RVA: 0x3D62E0 Offset: 0x3D54E0 VA: 0x1803D62E0
	public static string get_BuildProcessorDataPath() { }

	// RVA: 0x3D63F0 Offset: 0x3D55F0 VA: 0x1803D63F0
	public static string get_CustomAssetPacksDataEditorPath() { }

	// RVA: 0x3D64A0 Offset: 0x3D56A0 VA: 0x1803D64A0
	public static string get_CustomAssetPacksDataRuntimePath() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AddressablesPlayAssetDelivery
[DisplayName("Play Asset Delivery Provider")]
public class PlayAssetDeliveryAssetBundleProvider : AssetBundleProvider // TypeDefIndex: 18090
{
	// Fields
	private ProvideHandle m_ProviderInterface; // 0x20

	// Methods

	// RVA: 0x3D6CE0 Offset: 0x3D5EE0 VA: 0x1803D6CE0 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }

	// RVA: 0x3D6A40 Offset: 0x3D5C40 VA: 0x1803D6A40
	private void LoadFromAssetPack(ProvideHandle providerInterface) { }

	// RVA: 0x3D6D10 Offset: 0x3D5F10 VA: 0x1803D6D10 Slot: 15
	public override void Release(IResourceLocation location, object asset) { }

	// RVA: 0x3D6890 Offset: 0x3D5A90 VA: 0x1803D6890
	private void DownloadRemoteAssetPack(string assetPackName) { }

	// RVA: 0x3D65F0 Offset: 0x3D57F0 VA: 0x1803D65F0
	private void CheckDownloadStatus(AndroidAssetPackInfo info) { }

	// RVA: 0x3D6C00 Offset: 0x3D5E00 VA: 0x1803D6C00
	private void OnRequestToUseMobileDataComplete(AndroidAssetPackUseMobileDataRequestResult result) { }

	// RVA: 0x3D6D40 Offset: 0x3D5F40 VA: 0x1803D6D40
	public void .ctor() { }
}

// Namespace: AddressablesPlayAssetDelivery
[Serializable]
public class PlayAssetDeliveryInitialization : IInitializableObject // TypeDefIndex: 18091
{
	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 4
	public bool Initialize(string id, string data) { }

	// RVA: 0x3D6F30 Offset: 0x3D6130 VA: 0x1803D6F30
	public bool LogWarnings(string data) { }

	// RVA: 0x3D6DC0 Offset: 0x3D5FC0 VA: 0x1803D6DC0 Slot: 6
	public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AddressablesPlayAssetDelivery
public class PlayAssetDeliveryInitializeOperation : AsyncOperationBase<bool> // TypeDefIndex: 18092
{
	// Fields
	private ResourceManager m_RM; // 0x88
	private bool m_LogWarnings; // 0x90
	private bool m_IsDone; // 0x91
	private bool m_HasExecuted; // 0x92

	// Methods

	// RVA: 0x3D7E80 Offset: 0x3D7080 VA: 0x1803D7E80
	public AsyncOperationHandle<bool> Start(ResourceManager rm, bool logWarnings) { }

	// RVA: 0x3D7BF0 Offset: 0x3D6DF0 VA: 0x1803D7BF0 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x3D7370 Offset: 0x3D6570 VA: 0x1803D7370
	private void CompleteOverride(string warningMsg) { }

	// RVA: 0x3D77A0 Offset: 0x3D69A0 VA: 0x1803D77A0 Slot: 28
	protected override void Execute() { }

	// RVA: 0x3D7C30 Offset: 0x3D6E30 VA: 0x1803D7C30
	private void LoadFromAssetPacksIfAvailable() { }

	// RVA: 0x3D7D10 Offset: 0x3D6F10 VA: 0x1803D7D10
	private void LoadFromEditorData() { }

	// RVA: 0x3D7440 Offset: 0x3D6640 VA: 0x1803D7440
	private void DownloadCustomAssetPacksData() { }

	// RVA: 0x3D7970 Offset: 0x3D6B70 VA: 0x1803D7970
	private void InitializeBundleToAssetPackMap(string contents) { }

	// RVA: 0x3D71D0 Offset: 0x3D63D0 VA: 0x1803D71D0
	private void CheckDownloadStatus(AndroidAssetPackInfo info) { }

	// RVA: 0x3D6F80 Offset: 0x3D6180 VA: 0x1803D6F80
	private string AppBundleTransformFunc(IResourceLocation location) { }

	// RVA: 0x3D74F0 Offset: 0x3D66F0 VA: 0x1803D74F0
	private string EditorTransformFunc(IResourceLocation location) { }

	// RVA: 0x3D81F0 Offset: 0x3D73F0 VA: 0x1803D81F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D7FA0 Offset: 0x3D71A0 VA: 0x1803D7FA0
	private void <DownloadCustomAssetPacksData>b__10_0(AsyncOperation op) { }

	[CompilerGenerated]
	// RVA: 0x3D7F40 Offset: 0x3D7140 VA: 0x1803D7F40
	private void <CheckDownloadStatus>b__12_0(AndroidAssetPackUseMobileDataRequestResult result) { }
}

// Namespace: AddressablesPlayAssetDelivery
[Serializable]
public class PlayAssetDeliveryInitializationData // TypeDefIndex: 18093
{
	// Fields
	[SerializeField]
	private bool m_LogWarnings; // 0x10

	// Properties
	public bool LogWarnings { get; set; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_LogWarnings() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_LogWarnings(bool value) { }

	// RVA: 0x3D6D90 Offset: 0x3D5F90 VA: 0x1803D6D90
	public void .ctor() { }
}

// Namespace: AddressablesPlayAssetDelivery
public class PlayAssetDeliveryRuntimeData // TypeDefIndex: 18094
{
	// Fields
	private Dictionary<string, string> m_AssetPackNameToDownloadPath; // 0x10
	private Dictionary<string, CustomAssetPackDataEntry> m_BundleNameToAssetPack; // 0x18
	private static PlayAssetDeliveryRuntimeData s_Instance; // 0x0

	// Properties
	public static PlayAssetDeliveryRuntimeData Instance { get; }
	public Dictionary<string, CustomAssetPackDataEntry> BundleNameToAssetPack { get; }
	public Dictionary<string, string> AssetPackNameToDownloadPath { get; }

	// Methods

	// RVA: 0x3D8300 Offset: 0x3D7500 VA: 0x1803D8300
	public static PlayAssetDeliveryRuntimeData get_Instance() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Dictionary<string, CustomAssetPackDataEntry> get_BundleNameToAssetPack() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Dictionary<string, string> get_AssetPackNameToDownloadPath() { }

	// RVA: 0x3D8230 Offset: 0x3D7430 VA: 0x1803D8230
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=423 // TypeDefIndex: 18095
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=563 // TypeDefIndex: 18096
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 18097
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=423 B32D5981AA913977541D4C5F37AE7D0F29C697DC6032DDC0634A77BFFD94D9D0 /*Metadata offset 0x9017A0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=563 F113F6982A177AEE6D2E987C107DA49EB8502F5565BBDC240D134A25B6452C92 /*Metadata offset 0x901948*/; // 0x1A7
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18098
{}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
[NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
public sealed class VFXEventAttribute : IDisposable // TypeDefIndex: 18099
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private bool m_Owner; // 0x18
	private VisualEffectAsset m_VfxAsset; // 0x20

	// Methods

	// RVA: 0x27162A0 Offset: 0x27154A0 VA: 0x1827162A0
	private void .ctor(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset) { }

	// RVA: 0x2715F00 Offset: 0x2715100 VA: 0x182715F00
	internal static VFXEventAttribute CreateEventAttributeWrapper() { }

	// RVA: 0x2716230 Offset: 0x2715430 VA: 0x182716230
	internal void SetWrapValue(IntPtr ptrToEventAttribute) { }

	// RVA: 0x2716020 Offset: 0x2715220 VA: 0x182716020
	internal static IntPtr Internal_Create() { }

	// RVA: 0x27160E0 Offset: 0x27152E0 VA: 0x1827160E0
	internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset) { }

	// RVA: 0x2716090 Offset: 0x2715290 VA: 0x182716090
	internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset) { }

	// RVA: 0x27161A0 Offset: 0x27153A0 VA: 0x1827161A0
	private void Release() { }

	// RVA: 0x2715FC0 Offset: 0x27151C0 VA: 0x182715FC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2715F60 Offset: 0x2715160 VA: 0x182715F60 Slot: 4
	public void Dispose() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2716050 Offset: 0x2715250 VA: 0x182716050
	internal static void Internal_Destroy(IntPtr ptr) { }
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
[NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
public class VFXExpressionValues // TypeDefIndex: 18100
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x27162F0 Offset: 0x27154F0 VA: 0x1827162F0
	internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr) { }
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
public struct VFXCameraXRSettings // TypeDefIndex: 18101
{
	// Fields
	public uint viewTotal; // 0x0
	public uint viewCount; // 0x4
	public uint viewOffset; // 0x8
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
public struct VFXBatchedEffectInfo // TypeDefIndex: 18102
{
	// Fields
	public VisualEffectAsset vfxAsset; // 0x0
	public uint activeBatchCount; // 0x8
	public uint inactiveBatchCount; // 0xC
	public uint activeInstanceCount; // 0x10
	public uint unbatchedInstanceCount; // 0x14
	public uint totalInstanceCapacity; // 0x18
	public uint maxInstancePerBatchCapacity; // 0x1C
	public ulong totalGPUSizeInBytes; // 0x20
	public ulong totalCPUSizeInBytes; // 0x28
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
internal struct VFXBatchInfo // TypeDefIndex: 18103
{
	// Fields
	public uint capacity; // 0x0
	public uint activeInstanceCount; // 0x4
}

// Namespace: UnityEngine.VFX
[StaticAccessor("GetVFXManager()", 0)]
[NativeHeader("Modules/VFX/Public/ScriptBindings/VFXManagerBindings.h")]
[NativeHeader("Modules/VFX/Public/VFXManager.h")]
[RequiredByNativeCode]
public static class VFXManager // TypeDefIndex: 18104
{
	// Fields
	private static readonly VFXCameraXRSettings kDefaultCameraXRSettings; // 0x0

	// Methods

	// RVA: 0x2716350 Offset: 0x2715550 VA: 0x182716350
	private static void .cctor() { }
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
[Serializable]
public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 18105
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: UnityEngine.VFX
[NativeType(Header = "Modules/VFX/Public/VFXSpawnerState.h")]
[RequiredByNativeCode]
public sealed class VFXSpawnerState : IDisposable // TypeDefIndex: 18106
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private bool m_Owner; // 0x18
	private VFXEventAttribute m_WrapEventAttribute; // 0x20

	// Methods

	// RVA: 0x11FF670 Offset: 0x11FE870 VA: 0x1811FF670
	internal void .ctor(IntPtr ptr, bool owner) { }

	[RequiredByNativeCode]
	// RVA: 0x27163B0 Offset: 0x27155B0 VA: 0x1827163B0
	internal static VFXSpawnerState CreateSpawnerStateWrapper() { }

	// RVA: 0x2716640 Offset: 0x2715840 VA: 0x182716640
	private void PrepareWrapper() { }

	[RequiredByNativeCode]
	// RVA: 0x27167C0 Offset: 0x27159C0 VA: 0x1827167C0
	internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute) { }

	// RVA: 0x2716750 Offset: 0x2715950 VA: 0x182716750
	private void Release() { }

	// RVA: 0x2716550 Offset: 0x2715750 VA: 0x182716550 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x27164B0 Offset: 0x27156B0 VA: 0x1827164B0 Slot: 4
	public void Dispose() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2716600 Offset: 0x2715800 VA: 0x182716600
	private static void Internal_Destroy(IntPtr ptr) { }
}

// Namespace: UnityEngine.VFX
[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
[NativeHeader("VFXScriptingClasses.h")]
[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectAssetBindings.h")]
[UsedByNativeCode]
public abstract class VisualEffectObject : Object // TypeDefIndex: 18107
{
	// Methods

	// RVA: 0x2716960 Offset: 0x2715B60 VA: 0x182716960
	protected void .ctor() { }
}

// Namespace: UnityEngine.VFX
[UsedByNativeCode]
[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
[NativeHeader("VFXScriptingClasses.h")]
public class VisualEffectAsset : VisualEffectObject // TypeDefIndex: 18108
{
	// Fields
	public static readonly int PlayEventID; // 0x0
	public static readonly int StopEventID; // 0x4

	// Methods

	// RVA: 0x2716960 Offset: 0x2715B60 VA: 0x182716960
	public void .ctor() { }

	// RVA: 0x27168E0 Offset: 0x2715AE0 VA: 0x1827168E0
	private static void .cctor() { }
}

// Namespace: UnityEngine.VFX
public struct VFXOutputEventArgs // TypeDefIndex: 18109
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly int <nameId>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly VFXEventAttribute <eventAttribute>k__BackingField; // 0x8

	// Methods

	// RVA: 0xBB0D00 Offset: 0xBAFF00 VA: 0x180BB0D00
	public void .ctor(int nameId, VFXEventAttribute eventAttribute) { }
}

// Namespace: UnityEngine.VFX
[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
public class VisualEffect : Behaviour // TypeDefIndex: 18110
{
	// Fields
	private VFXEventAttribute m_cachedEventAttribute; // 0x18
	public Action<VFXOutputEventArgs> outputEventReceived; // 0x20

	// Properties
	public VisualEffectAsset visualEffectAsset { get; }

	// Methods

	// RVA: 0x2716D10 Offset: 0x2715F10 VA: 0x182716D10
	public VisualEffectAsset get_visualEffectAsset() { }

	// RVA: 0x27169B0 Offset: 0x2715BB0 VA: 0x1827169B0
	public VFXEventAttribute CreateVFXEventAttribute() { }

	[RequiredByNativeCode]
	// RVA: 0x2716B10 Offset: 0x2715D10 VA: 0x182716B10
	private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source) { }

	[RequiredByNativeCode]
	// RVA: 0x2716CC0 Offset: 0x2715EC0 VA: 0x182716CC0
	private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18111
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 18112
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(27524, AllowMultiple = False, Inherited = False)]
[Embedded]
[CompilerGenerated]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 18113
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1C533F0 Offset: 0x1C525F0 VA: 0x181C533F0
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 18114
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(byte ) { }
}

// Namespace: Sentry.Unity.Native
internal class NativeContextWriter : ContextWriter // TypeDefIndex: 18115
{
	// Methods

	[NullableContext(2)]
	// RVA: 0x1C52D50 Offset: 0x1C51F50 VA: 0x181C52D50 Slot: 4
	protected override void WriteScope(string AppStartTime, string AppBuildType, string OperatingSystemRawDescription, Nullable<int> DeviceProcessorCount, string DeviceCpuDescription, string DeviceTimezone, Nullable<bool> DeviceSupportsVibration, string DeviceName, Nullable<bool> DeviceSimulator, string DeviceDeviceUniqueIdentifier, string DeviceDeviceType, string DeviceModel, Nullable<long> DeviceMemorySize, Nullable<int> GpuId, string GpuName, string GpuVendorName, Nullable<int> GpuMemorySize, string GpuNpotSupport, string GpuVersion, string GpuApiType, Nullable<int> GpuMaxTextureSize, Nullable<bool> GpuSupportsDrawCallInstancing, Nullable<bool> GpuSupportsRayTracing, Nullable<bool> GpuSupportsComputeShaders, Nullable<bool> GpuSupportsGeometryShaders, string GpuVendorId, Nullable<bool> GpuMultiThreadedRendering, string GpuGraphicsShaderLevel, string EditorVersion, string UnityInstallMode, string UnityTargetFrameRate, string UnityCopyTextureSupport, string UnityRenderingThreadingMode) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Sentry.Unity.Native
[Nullable(0)]
[NullableContext(1)]
public class NativeScopeObserver : ScopeObserver // TypeDefIndex: 18116
{
	// Methods

	// RVA: 0x1C533A0 Offset: 0x1C525A0 VA: 0x181C533A0
	public void .ctor(SentryOptions options) { }

	// RVA: 0x1C52F10 Offset: 0x1C52110 VA: 0x181C52F10 Slot: 9
	public override void AddBreadcrumbImpl(Breadcrumb breadcrumb) { }

	// RVA: 0x1C53120 Offset: 0x1C52320 VA: 0x181C53120 Slot: 10
	public override void SetExtraImpl(string key, string value) { }

	// RVA: 0x1C531C0 Offset: 0x1C523C0 VA: 0x181C531C0 Slot: 11
	public override void SetTagImpl(string key, string value) { }

	// RVA: 0x1C53310 Offset: 0x1C52510 VA: 0x181C53310 Slot: 12
	public override void UnsetTagImpl(string key) { }

	// RVA: 0x1C53220 Offset: 0x1C52420 VA: 0x181C53220 Slot: 13
	public override void SetUserImpl(User user) { }

	// RVA: 0x1C53360 Offset: 0x1C52560 VA: 0x181C53360 Slot: 14
	public override void UnsetUserImpl() { }

	// RVA: 0x1C530C0 Offset: 0x1C522C0 VA: 0x181C530C0
	private static string GetTimestamp(DateTimeOffset timestamp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SentryNative.<>c__DisplayClass1_0 // TypeDefIndex: 18117
{
	// Fields
	[Nullable(0)]
	public SentryUnityOptions options; // 0x10
	public bool crashedLastRun; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C55A40 Offset: 0x1C54C40 VA: 0x181C55A40
	internal void <Configure>b__0() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	internal bool <Configure>b__1() { }
}

// Namespace: Sentry.Unity.Native
[NullableContext(1)]
[Nullable(0)]
public static class SentryNative // TypeDefIndex: 18118
{
	// Fields
	private static readonly Dictionary<string, bool> PerDirectoryCrashInfo; // 0x0

	// Methods

	// RVA: 0x1C54F80 Offset: 0x1C54180 VA: 0x181C54F80
	public static void Configure(SentryUnityOptions options, ISentryUnityInfo sentryUnityInfo) { }

	// RVA: 0x1C55720 Offset: 0x1C54920 VA: 0x181C55720
	private static void .cctor() { }
}

// Namespace: 
[NullableContext(0)]
[UnmanagedFunctionPointer(2, SetLastError = True)]
private sealed class SentryNativeBridge.sentry_logger_function_t : MulticastDelegate // TypeDefIndex: 18119
{
	// Methods

	// RVA: 0x1C55B00 Offset: 0x1C54D00 VA: 0x181C55B00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(int level, IntPtr message, IntPtr argsAddress, IntPtr userData) { }
}

// Namespace: 
[NullableContext(0)]
private struct SentryNativeBridge.VaListLinux64 // TypeDefIndex: 18120
{
	// Fields
	private uint gp_offset; // 0x0
	private uint fp_offset; // 0x4
	private IntPtr overflow_arg_area; // 0x8
	private IntPtr reg_save_area; // 0x10
}

// Namespace: 
[CompilerGenerated]
private sealed class SentryNativeBridge.<>c__DisplayClass19_0 // TypeDefIndex: 18121
{
	// Fields
	public IntPtr format; // 0x10
	[Nullable(0)]
	public string message; // 0x18
	public IntPtr args; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SentryNativeBridge.<>c__DisplayClass19_1 // TypeDefIndex: 18122
{
	// Fields
	public int formattedLength; // 0x10
	public SentryNativeBridge.VaListLinux64 argsStruct; // 0x14
	[Nullable(0)]
	public SentryNativeBridge.<>c__DisplayClass19_0 CS$<>8__locals1; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C55790 Offset: 0x1C54990 VA: 0x181C55790
	internal void <nativeLogImpl>b__0(IntPtr argsPtr) { }

	// RVA: 0x1C557D0 Offset: 0x1C549D0 VA: 0x181C557D0
	internal void <nativeLogImpl>b__1(IntPtr buffer) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SentryNativeBridge.<>c__DisplayClass19_2 // TypeDefIndex: 18123
{
	// Fields
	public IntPtr buffer; // 0x10
	[Nullable(0)]
	public SentryNativeBridge.<>c__DisplayClass19_1 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C558D0 Offset: 0x1C54AD0 VA: 0x181C558D0
	internal void <nativeLogImpl>b__2(IntPtr argsPtr) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SentryNativeBridge.<>c__DisplayClass19_3 // TypeDefIndex: 18124
{
	// Fields
	public int formattedLength; // 0x10
	[Nullable(0)]
	public SentryNativeBridge.<>c__DisplayClass19_0 CS$<>8__locals3; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C559A0 Offset: 0x1C54BA0 VA: 0x181C559A0
	internal void <nativeLogImpl>b__3(IntPtr buffer) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SentryNativeBridge.<>c__DisplayClass24_0<T> // TypeDefIndex: 18125
{
	// Fields
	[Nullable(0)]
	public T structure; // 0x0
	[Nullable(0)]
	public Action<IntPtr> action; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SentryNativeBridge.<>c__DisplayClass24_0<__Il2CppFullySharedGenericType>..ctor
	|-SentryNativeBridge.<>c__DisplayClass24_0<SentryNativeBridge.VaListLinux64>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <WithMarshalledStruct>b__0(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0A770 Offset: 0xB09970 VA: 0x180B0A770
	|-SentryNativeBridge.<>c__DisplayClass24_0<__Il2CppFullySharedGenericType>.<WithMarshalledStruct>b__0
	|
	|-RVA: 0xB0A8F0 Offset: 0xB09AF0 VA: 0x180B0A8F0
	|-SentryNativeBridge.<>c__DisplayClass24_0<SentryNativeBridge.VaListLinux64>.<WithMarshalledStruct>b__0
	*/
}

// Namespace: Sentry.Unity.Native
[Nullable(0)]
[NullableContext(1)]
public static class SentryNativeBridge // TypeDefIndex: 18126
{
	// Fields
	[Nullable(2)]
	private static IDiagnosticLogger _logger; // 0x0
	private static bool _isLinux; // 0x8

	// Methods

	// RVA: 0x1C53680 Offset: 0x1C52880 VA: 0x181C53680
	public static bool Init(SentryUnityOptions options, ISentryUnityInfo sentryUnityInfo) { }

	// RVA: 0x1C53470 Offset: 0x1C52670 VA: 0x181C53470
	public static void Close() { }

	// RVA: 0x1C535A0 Offset: 0x1C527A0 VA: 0x181C535A0
	internal static bool HandleCrashedLastRun(SentryUnityOptions options) { }

	// RVA: 0x1C534E0 Offset: 0x1C526E0 VA: 0x181C534E0
	internal static string GetCacheDirectory(SentryUnityOptions options) { }

	// RVA: 0x1C54840 Offset: 0x1C53A40 VA: 0x181C54840
	private static extern IntPtr sentry_options_new() { }

	// RVA: 0x1C54B10 Offset: 0x1C53D10 VA: 0x181C54B10
	private static extern void sentry_options_set_dsn(IntPtr options, string dsn) { }

	// RVA: 0x1C54CF0 Offset: 0x1C53EF0 VA: 0x181C54CF0
	private static extern void sentry_options_set_release(IntPtr options, string release) { }

	// RVA: 0x1C54A80 Offset: 0x1C53C80 VA: 0x181C54A80
	private static extern void sentry_options_set_debug(IntPtr options, int debug) { }

	// RVA: 0x1C54BB0 Offset: 0x1C53DB0 VA: 0x181C54BB0
	private static extern void sentry_options_set_environment(IntPtr options, string environment) { }

	// RVA: 0x1C54D90 Offset: 0x1C53F90 VA: 0x181C54D90
	private static extern void sentry_options_set_sample_rate(IntPtr options, double rate) { }

	// RVA: 0x1C54940 Offset: 0x1C53B40 VA: 0x181C54940
	private static extern void sentry_options_set_database_path(IntPtr options, string path) { }

	// RVA: 0x1C549E0 Offset: 0x1C53BE0 VA: 0x181C549E0
	private static extern void sentry_options_set_database_pathw(IntPtr options, string path) { }

	// RVA: 0x1C548B0 Offset: 0x1C53AB0 VA: 0x181C548B0
	private static extern void sentry_options_set_auto_session_tracking(IntPtr options, int debug) { }

	// RVA: 0x1C54C50 Offset: 0x1C53E50 VA: 0x181C54C50
	private static extern void sentry_options_set_logger(IntPtr options, SentryNativeBridge.sentry_logger_function_t logger, IntPtr userData) { }

	[MonoPInvokeCallback(typeof(SentryNativeBridge.sentry_logger_function_t))]
	// RVA: 0x1C546C0 Offset: 0x1C538C0 VA: 0x181C546C0
	private static void nativeLog(int cLevel, IntPtr format, IntPtr args, IntPtr userData) { }

	// RVA: 0x1C54120 Offset: 0x1C53320 VA: 0x181C54120
	private static void nativeLogImpl(int cLevel, IntPtr format, IntPtr args, IntPtr userData) { }

	// RVA: 0x1C54ED0 Offset: 0x1C540D0 VA: 0x181C54ED0
	private static extern int vsnprintf_windows(IntPtr buffer, UIntPtr bufferSize, IntPtr format, IntPtr args) { }

	// RVA: 0x1C54E20 Offset: 0x1C54020 VA: 0x181C54E20
	private static extern int vsnprintf_linux(IntPtr buffer, UIntPtr bufferSize, IntPtr format, IntPtr args) { }

	// RVA: 0x1C54030 Offset: 0x1C53230 VA: 0x181C54030
	private static void WithAllocatedPtr(int size, Action<IntPtr> action) { }

	// RVA: -1 Offset: -1
	private static void WithMarshalledStruct<T>(T structure, Action<IntPtr> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6A540 Offset: 0xA69740 VA: 0x180A6A540
	|-SentryNativeBridge.WithMarshalledStruct<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xA6A750 Offset: 0xA69950 VA: 0x180A6A750
	|-SentryNativeBridge.WithMarshalledStruct<SentryNativeBridge.VaListLinux64>
	*/

	// RVA: 0x1C547C0 Offset: 0x1C539C0 VA: 0x181C547C0
	private static extern int sentry_init(IntPtr options) { }

	// RVA: 0x1C53470 Offset: 0x1C52670 VA: 0x181C53470
	private static extern int sentry_close() { }

	// RVA: 0x1C54750 Offset: 0x1C53950 VA: 0x181C54750
	private static extern int sentry_get_crashed_last_run() { }

	// RVA: 0x1C546E0 Offset: 0x1C538E0 VA: 0x181C546E0
	private static extern int sentry_clear_crashed_last_run() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18127
{}

// Namespace: 
[CompilerGenerated]
private struct CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53 : IAsyncStateMachine // TypeDefIndex: 18128
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<ProjectConfiguration> <>t__builder; // 0x8
	public InitializationOptions options; // 0x20
	public CorePackageInitializer <>4__this; // 0x28
	private TaskAwaiter<SerializableProjectConfiguration> <>u__1; // 0x30

	// Methods

	// RVA: 0x23A7690 Offset: 0x23A6890 VA: 0x1823A7690 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x23A7A10 Offset: 0x23A6C10 VA: 0x1823A7A10 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54 : IAsyncStateMachine // TypeDefIndex: 18129
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<SerializableProjectConfiguration> <>t__builder; // 0x8
	private TaskAwaiter<SerializableProjectConfiguration> <>u__1; // 0x20

	// Methods

	// RVA: 0x23A7A80 Offset: 0x23A6C80 VA: 0x1823A7A80 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x23A7E20 Offset: 0x23A7020 VA: 0x1823A7E20 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CorePackageInitializer.<InitializeComponents>d__47 : IAsyncStateMachine // TypeDefIndex: 18130
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CorePackageInitializer <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x23A7E90 Offset: 0x23A7090 VA: 0x1823A7E90 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x23A8790 Offset: 0x23A7990 VA: 0x1823A8790 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CorePackageInitializer.<InitializeProjectConfigAsync>d__52 : IAsyncStateMachine // TypeDefIndex: 18131
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CorePackageInitializer <>4__this; // 0x20
	public InitializationOptions options; // 0x28
	private TaskAwaiter<ProjectConfiguration> <>u__1; // 0x30

	// Methods

	// RVA: 0x23A87F0 Offset: 0x23A79F0 VA: 0x1823A87F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x23A8AC0 Offset: 0x23A7CC0 VA: 0x1823A8AC0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Unity.Services.Core.Registration
internal class CorePackageInitializer : IInitializablePackageV2, IInitializablePackage, IDiagnosticsComponentProvider // TypeDefIndex: 18132
{
	// Fields
	[CompilerGenerated]
	private ActionScheduler <ActionScheduler>k__BackingField; // 0x10
	[CompilerGenerated]
	private InstallationId <InstallationId>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProjectConfiguration <ProjectConfig>k__BackingField; // 0x20
	[CompilerGenerated]
	private Environments <Environments>k__BackingField; // 0x28
	[CompilerGenerated]
	private ExternalUserId <ExternalUserId>k__BackingField; // 0x30
	[CompilerGenerated]
	private ICloudProjectId <CloudProjectId>k__BackingField; // 0x38
	[CompilerGenerated]
	private IDiagnosticsFactory <DiagnosticsFactory>k__BackingField; // 0x40
	[CompilerGenerated]
	private IMetricsFactory <MetricsFactory>k__BackingField; // 0x48
	[CompilerGenerated]
	private UnityThreadUtilsInternal <UnityThreadUtils>k__BackingField; // 0x50
	private CoreRegistry m_Registry; // 0x58
	private readonly IJsonSerializer m_Serializer; // 0x60
	private InitializationOptions m_CurrentInitializationOptions; // 0x68

	// Properties
	internal ActionScheduler ActionScheduler { get; set; }
	internal InstallationId InstallationId { get; set; }
	internal ProjectConfiguration ProjectConfig { get; set; }
	internal Environments Environments { get; set; }
	internal ExternalUserId ExternalUserId { get; set; }
	internal ICloudProjectId CloudProjectId { get; set; }
	internal IDiagnosticsFactory DiagnosticsFactory { get; set; }
	internal IMetricsFactory MetricsFactory { get; set; }
	internal UnityThreadUtilsInternal UnityThreadUtils { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal ActionScheduler get_ActionScheduler() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_ActionScheduler(ActionScheduler value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal InstallationId get_InstallationId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_InstallationId(InstallationId value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal ProjectConfiguration get_ProjectConfig() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_ProjectConfig(ProjectConfiguration value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal Environments get_Environments() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_Environments(Environments value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal ExternalUserId get_ExternalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_ExternalUserId(ExternalUserId value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal ICloudProjectId get_CloudProjectId() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_CloudProjectId(ICloudProjectId value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal IDiagnosticsFactory get_DiagnosticsFactory() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	private void set_DiagnosticsFactory(IDiagnosticsFactory value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal IMetricsFactory get_MetricsFactory() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	private void set_MetricsFactory(IMetricsFactory value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal UnityThreadUtilsInternal get_UnityThreadUtils() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	private void set_UnityThreadUtils(UnityThreadUtilsInternal value) { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x23A6EE0 Offset: 0x23A60E0 VA: 0x1823A6EE0
	private static void InitializeOnLoad() { }

	// RVA: 0x23A72B0 Offset: 0x23A64B0 VA: 0x1823A72B0 Slot: 6
	public void Register(CorePackageRegistry registry) { }

	// RVA: 0x23A7660 Offset: 0x23A6860 VA: 0x1823A7660
	public void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x23A6E70 Offset: 0x23A6070 VA: 0x1823A6E70 Slot: 5
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x23A6E70 Offset: 0x23A6070 VA: 0x1823A6E70 Slot: 4
	public Task InitializeInstanceAsync(CoreRegistry registry) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<InitializeComponents>d__47))]
	// RVA: 0x23A6B10 Offset: 0x23A5D10 VA: 0x1823A6B10
	private Task InitializeComponents() { }

	// RVA: 0x23A69D0 Offset: 0x23A5BD0 VA: 0x1823A69D0
	private bool HaveInitOptionsChanged() { }

	// RVA: 0x23A6810 Offset: 0x23A5A10 VA: 0x1823A6810
	private void FreeOptionsDependantComponents() { }

	// RVA: 0x23A6E00 Offset: 0x23A6000 VA: 0x1823A6E00
	internal void InitializeInstallationId() { }

	// RVA: 0x23A6A40 Offset: 0x23A5C40 VA: 0x1823A6A40
	internal void InitializeActionScheduler() { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<InitializeProjectConfigAsync>d__52))]
	// RVA: 0x23A7180 Offset: 0x23A6380 VA: 0x1823A7180
	internal Task InitializeProjectConfigAsync(InitializationOptions options) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53))]
	// RVA: 0x23A6830 Offset: 0x23A5A30 VA: 0x1823A6830
	internal Task<ProjectConfiguration> GenerateProjectConfigurationAsync(InitializationOptions options) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54))]
	// RVA: 0x23A6910 Offset: 0x23A5B10 VA: 0x1823A6910
	internal static Task<SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync() { }

	// RVA: 0x23A6D00 Offset: 0x23A5F00 VA: 0x1823A6D00
	internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x23A6C30 Offset: 0x23A5E30 VA: 0x1823A6C30
	internal void InitializeEnvironments(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x23A6E80 Offset: 0x23A6080 VA: 0x1823A6E80
	internal void InitializeMetrics() { }

	// RVA: 0x23A6BD0 Offset: 0x23A5DD0 VA: 0x1823A6BD0
	internal void InitializeDiagnostics() { }

	// RVA: 0x23A6AB0 Offset: 0x23A5CB0 VA: 0x1823A6AB0
	internal void InitializeCloudProjectId(ICloudProjectId cloudProjectId) { }

	// RVA: 0x23A7250 Offset: 0x23A6450 VA: 0x1823A7250
	internal void InitializeUnityThreadUtils() { }

	[CompilerGenerated]
	// RVA: 0x23A74D0 Offset: 0x23A66D0 VA: 0x1823A74D0
	private void <InitializeComponents>g__RegisterProvidedComponents|47_0() { }

	[CompilerGenerated]
	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(Exception reason) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18133
{}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Subsystems/Subsystem.h")]
public class IntegratedSubsystem // TypeDefIndex: 18134
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal ISubsystemDescriptor m_SubsystemDescriptor; // 0x18

	// Methods

	// RVA: 0x2504270 Offset: 0x2503470 VA: 0x182504270
	internal void SetHandle(IntegratedSubsystem subsystem) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode("Subsystem_TSubsystemDescriptor")]
public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem // TypeDefIndex: 18135
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	|-IntegratedSubsystem<object>..ctor
	|-IntegratedSubsystem<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine
[UsedByNativeCode("SubsystemDescriptorBase")]
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 18136
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string id { get; }

	// Methods

	// RVA: 0x2504230 Offset: 0x2503430 VA: 0x182504230 Slot: 4
	public string get_id() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Subsystems/SubsystemDescriptor.h")]
[UsedByNativeCode("SubsystemDescriptor")]
public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 18137
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	|-IntegratedSubsystemDescriptor<object>..ctor
	*/
}

// Namespace: UnityEngine
internal static class SubsystemDescriptorBindings // TypeDefIndex: 18138
{
	// Methods

	// RVA: 0x2504360 Offset: 0x2503560 VA: 0x182504360
	public static string GetId(IntPtr descriptorPtr) { }
}

// Namespace: UnityEngine
public interface ISubsystemDescriptor // TypeDefIndex: 18139
{
	// Properties
	public abstract string id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_id();
}

// Namespace: UnityEngine
public abstract class Subsystem // TypeDefIndex: 18140
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine
public abstract class SubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 18141
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <id>k__BackingField; // 0x10

	// Properties
	public string id { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string get_id() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine
internal static class Internal_SubsystemDescriptors // TypeDefIndex: 18142
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x25042C0 Offset: 0x25034C0 VA: 0x1825042C0
	internal static void Internal_AddDescriptor(SubsystemDescriptor descriptor) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemManager // TypeDefIndex: 18143
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action beforeReloadSubsystems; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action afterReloadSubsystems; // 0x8
	private static List<IntegratedSubsystem> s_IntegratedSubsystems; // 0x10
	private static List<SubsystemWithProvider> s_StandaloneSubsystems; // 0x18
	private static List<Subsystem> s_DeprecatedSubsystems; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action reloadSubsytemsStarted; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action reloadSubsytemsCompleted; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2504D50 Offset: 0x2503F50 VA: 0x182504D50
	private static void ReloadSubsystemsStarted() { }

	[RequiredByNativeCode]
	// RVA: 0x2504C60 Offset: 0x2503E60 VA: 0x182504C60
	private static void ReloadSubsystemsCompleted() { }

	[RequiredByNativeCode]
	// RVA: 0x2504B50 Offset: 0x2503D50 VA: 0x182504B50
	private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem) { }

	[RequiredByNativeCode]
	// RVA: 0x25047C0 Offset: 0x25039C0 VA: 0x1825047C0
	private static void ClearSubsystems() { }

	// RVA: 0x2504E40 Offset: 0x2504040 VA: 0x182504E40
	private static void StaticConstructScriptingClassMap() { }

	// RVA: 0x2504E70 Offset: 0x2504070 VA: 0x182504E70
	private static void .cctor() { }

	// RVA: 0x25049E0 Offset: 0x2503BE0 VA: 0x1825049E0
	internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr) { }
}

// Namespace: UnityEngine.SubsystemsImplementation
[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemDescriptorStore // TypeDefIndex: 18144
{
	// Fields
	private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; // 0x0
	private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; // 0x8
	private static List<SubsystemDescriptor> s_DeprecatedDescriptors; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2504530 Offset: 0x2503730 VA: 0x182504530
	internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc) { }

	[RequiredByNativeCode]
	// RVA: 0x25043A0 Offset: 0x25035A0 VA: 0x1825043A0
	internal static void ClearManagedDescriptors() { }

	// RVA: 0x2504680 Offset: 0x2503880 VA: 0x182504680
	private static void ReportSingleSubsystemAnalytics(string id) { }

	// RVA: -1 Offset: -1
	internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA81FC0 Offset: 0xA811C0 VA: 0x180A81FC0
	|-SubsystemDescriptorStore.RegisterDescriptor<object, object>
	|
	|-RVA: 0xA819E0 Offset: 0xA80BE0 VA: 0x180A819E0
	|-SubsystemDescriptorStore.RegisterDescriptor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2504610 Offset: 0x2503810 VA: 0x182504610
	internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor) { }

	// RVA: 0x25046C0 Offset: 0x25038C0 VA: 0x1825046C0
	private static void .cctor() { }
}

// Namespace: UnityEngine.SubsystemsImplementation
public abstract class SubsystemDescriptorWithProvider : ISubsystemDescriptor // TypeDefIndex: 18145
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <id>k__BackingField; // 0x10

	// Properties
	public string id { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string get_id() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine.SubsystemsImplementation
public abstract class SubsystemWithProvider // TypeDefIndex: 18146
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18147
{}

// Namespace: UnityEngine.Experimental.Video
[NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
[NativeHeader("Modules/Video/Public/VideoClip.h")]
[StaticAccessor("VideoClipPlayableBindings", 2)]
public struct VideoClipPlayable : IEquatable<VideoClipPlayable> // TypeDefIndex: 18148
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x2716D50 Offset: 0x2715F50 VA: 0x182716D50 Slot: 4
	public bool Equals(VideoClipPlayable other) { }
}

// Namespace: UnityEngine.Video
[NativeHeader("Modules/Video/Public/VideoClip.h")]
[RequiredByNativeCode]
public sealed class VideoClip : Object // TypeDefIndex: 18149
{}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoRenderMode // TypeDefIndex: 18150
{
	// Fields
	public int value__; // 0x0
	public const VideoRenderMode CameraFarPlane = 0;
	public const VideoRenderMode CameraNearPlane = 1;
	public const VideoRenderMode RenderTexture = 2;
	public const VideoRenderMode MaterialOverride = 3;
	public const VideoRenderMode APIOnly = 4;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum Video3DLayout // TypeDefIndex: 18151
{
	// Fields
	public int value__; // 0x0
	public const Video3DLayout No3D = 0;
	public const Video3DLayout SideBySide3D = 1;
	public const Video3DLayout OverUnder3D = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoAspectRatio // TypeDefIndex: 18152
{
	// Fields
	public int value__; // 0x0
	public const VideoAspectRatio NoScaling = 0;
	public const VideoAspectRatio FitVertically = 1;
	public const VideoAspectRatio FitHorizontally = 2;
	public const VideoAspectRatio FitInside = 3;
	public const VideoAspectRatio FitOutside = 4;
	public const VideoAspectRatio Stretch = 5;
}

// Namespace: UnityEngine.Video
[Obsolete("VideoTimeSource is deprecated. Use TimeUpdateMode instead. (UnityUpgradable) -> VideoTimeUpdateMode")]
[RequiredByNativeCode]
public enum VideoTimeSource // TypeDefIndex: 18153
{
	// Fields
	public int value__; // 0x0
	[Obsolete("AudioDSPTimeSource is deprecated. Use DSPTime instead. (UnityUpgradable) -> DSPTime")]
	public const VideoTimeSource AudioDSPTimeSource = 0;
	[Obsolete("GameTimeSource is deprecated. Use GameTime instead. (UnityUpgradable) -> GameTime")]
	public const VideoTimeSource GameTimeSource = 1;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoTimeReference // TypeDefIndex: 18154
{
	// Fields
	public int value__; // 0x0
	public const VideoTimeReference Freerun = 0;
	public const VideoTimeReference InternalTime = 1;
	public const VideoTimeReference ExternalTime = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoSource // TypeDefIndex: 18155
{
	// Fields
	public int value__; // 0x0
	public const VideoSource VideoClip = 0;
	public const VideoSource Url = 1;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoTimeUpdateMode // TypeDefIndex: 18156
{
	// Fields
	public int value__; // 0x0
	public const VideoTimeUpdateMode DSPTime = 0;
	public const VideoTimeUpdateMode GameTime = 1;
	public const VideoTimeUpdateMode UnscaledGameTime = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoAudioOutputMode // TypeDefIndex: 18157
{
	// Fields
	public int value__; // 0x0
	public const VideoAudioOutputMode None = 0;
	public const VideoAudioOutputMode AudioSource = 1;
	public const VideoAudioOutputMode Direct = 2;
	public const VideoAudioOutputMode APIOnly = 3;
}

// Namespace: 
public sealed class VideoPlayer.EventHandler : MulticastDelegate // TypeDefIndex: 18158
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(VideoPlayer source) { }
}

// Namespace: 
public sealed class VideoPlayer.ErrorEventHandler : MulticastDelegate // TypeDefIndex: 18159
{
	// Methods

	// RVA: 0x1A446E0 Offset: 0x1A438E0 VA: 0x181A446E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(VideoPlayer source, string message) { }
}

// Namespace: 
public sealed class VideoPlayer.FrameReadyEventHandler : MulticastDelegate // TypeDefIndex: 18160
{
	// Methods

	// RVA: 0x1A446E0 Offset: 0x1A438E0 VA: 0x181A446E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(VideoPlayer source, long frameIdx) { }
}

// Namespace: 
public sealed class VideoPlayer.TimeEventHandler : MulticastDelegate // TypeDefIndex: 18161
{
	// Methods

	// RVA: 0x6E1D30 Offset: 0x6E0F30 VA: 0x1806E1D30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(VideoPlayer source, double seconds) { }
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
[RequireComponent(typeof(Transform))]
public sealed class VideoPlayer : Behaviour // TypeDefIndex: 18162
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler prepareCompleted; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler loopPointReached; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler started; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler frameDropped; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.ErrorEventHandler errorReceived; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler seekCompleted; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VideoPlayer.TimeEventHandler clockResyncOccurred; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VideoPlayer.FrameReadyEventHandler frameReady; // 0x50

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2716F10 Offset: 0x2716110 VA: 0x182716F10
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2716E90 Offset: 0x2716090 VA: 0x182716E90
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCode]
	// RVA: 0x2716ED0 Offset: 0x27160D0 VA: 0x182716ED0
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2716F90 Offset: 0x2716190 VA: 0x182716F90
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2716E50 Offset: 0x2716050 VA: 0x182716E50
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2716E10 Offset: 0x2716010 VA: 0x182716E10
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCode]
	// RVA: 0x2716F50 Offset: 0x2716150 VA: 0x182716F50
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2716DD0 Offset: 0x2715FD0 VA: 0x182716DD0
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18163
{}

// Namespace: UnityEngine
[NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
[NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
[NativeHeader("AssetBundleScriptingClasses.h")]
[NativeHeader("Runtime/Scripting/ScriptingObjectWithIntPtrField.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[ExcludeFromPreset]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
public class AssetBundle : Object // TypeDefIndex: 18164
{
	// Methods

	// RVA: 0x2446B10 Offset: 0x2445D10 VA: 0x182446B10
	private void .ctor() { }

	[FreeFunction("GetAllAssetBundles")]
	// RVA: 0x24462F0 Offset: 0x24454F0 VA: 0x1824462F0
	internal static AssetBundle[] GetAllLoadedAssetBundles_Native() { }

	// RVA: 0x24462F0 Offset: 0x24454F0 VA: 0x1824462F0
	public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles() { }

	[FreeFunction("LoadFromFileAsync")]
	// RVA: 0x2446910 Offset: 0x2445B10 VA: 0x182446910
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x24469B0 Offset: 0x2445BB0 VA: 0x1824469B0
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	// RVA: 0x2446960 Offset: 0x2445B60 VA: 0x182446960
	public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc) { }

	[FreeFunction("LoadFromMemory")]
	// RVA: 0x24469F0 Offset: 0x2445BF0 VA: 0x1824469F0
	internal static AssetBundle LoadFromMemory_Internal(byte[] binary, uint crc) { }

	// RVA: 0x2446A30 Offset: 0x2445C30 VA: 0x182446A30
	public static AssetBundle LoadFromMemory(byte[] binary) { }

	// RVA: 0x24465B0 Offset: 0x24457B0 VA: 0x1824465B0
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: 0x24467A0 Offset: 0x24459A0 VA: 0x1824467A0
	public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type) { }

	// RVA: 0x2446320 Offset: 0x2445520 VA: 0x182446320
	public AssetBundleRequest LoadAllAssetsAsync() { }

	// RVA: -1 Offset: -1
	public AssetBundleRequest LoadAllAssetsAsync<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93B880 Offset: 0x93AA80 VA: 0x18093B880
	|-AssetBundle.LoadAllAssetsAsync<object>
	|-AssetBundle.LoadAllAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2446460 Offset: 0x2445660 VA: 0x182446460
	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	[NativeThrows]
	[NativeMethod("LoadAssetAsync_Internal")]
	// RVA: 0x2446550 Offset: 0x2445750 VA: 0x182446550
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeThrows]
	[NativeMethod("Unload")]
	// RVA: 0x2446AC0 Offset: 0x2445CC0 VA: 0x182446AC0
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeThrows]
	[NativeMethod("UnloadAsync")]
	// RVA: 0x2446A70 Offset: 0x2445C70 VA: 0x182446A70
	public AssetBundleUnloadOperation UnloadAsync(bool unloadAllLoadedObjects) { }

	[NativeMethod("LoadAssetWithSubAssetsAsync_Internal")]
	[NativeThrows]
	// RVA: 0x2446740 Offset: 0x2445940 VA: 0x182446740
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
[RequiredByNativeCode]
public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 18165
{
	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	[NativeMethod("GetAssetBundleBlocking")]
	// RVA: 0x24461F0 Offset: 0x24453F0 VA: 0x1824461F0
	public AssetBundle get_assetBundle() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleRecompressOperation.h")]
[RequiredByNativeCode]
public class AssetBundleRecompressOperation : AsyncOperation // TypeDefIndex: 18166
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
public class AssetBundleRequest : ResourceRequest // TypeDefIndex: 18167
{
	// Properties
	public Object asset { get; }
	public Object[] allAssets { get; }

	// Methods

	[NativeMethod("GetLoadedAsset")]
	// RVA: 0x2446230 Offset: 0x2445430 VA: 0x182446230 Slot: 4
	protected override Object GetResult() { }

	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170
	public Object get_asset() { }

	[NativeMethod("GetAllLoadedAssets")]
	// RVA: 0x2446270 Offset: 0x2445470 VA: 0x182446270
	public Object[] get_allAssets() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUnloadOperation.h")]
[RequiredByNativeCode]
public class AssetBundleUnloadOperation : AsyncOperation // TypeDefIndex: 18168
{
	// Methods

	[NativeMethod("WaitForCompletion")]
	// RVA: 0x24462B0 Offset: 0x24454B0 VA: 0x1824462B0
	public void WaitForCompletion() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18169
{}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[NativeType(Header = "Modules/Grid/Public/Grid.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
public sealed class Grid : GridLayout // TypeDefIndex: 18170
{
	// Properties
	public Vector3 cellSize { get; set; }
	public Vector3 cellGap { get; set; }
	public GridLayout.CellLayout cellLayout { get; set; }
	public GridLayout.CellSwizzle cellSwizzle { get; set; }

	// Methods

	// RVA: 0x24BB720 Offset: 0x24BA920 VA: 0x1824BB720
	public Vector3 GetCellCenterLocal(Vector3Int position) { }

	// RVA: 0x24BB850 Offset: 0x24BAA50 VA: 0x1824BB850
	public Vector3 GetCellCenterWorld(Vector3Int position) { }

	[FreeFunction("GridBindings::GetCellSize", HasExplicitThis = True)]
	// RVA: 0x24BBC50 Offset: 0x24BAE50 VA: 0x1824BBC50
	public Vector3 get_cellSize() { }

	[FreeFunction("GridBindings::SetCellSize", HasExplicitThis = True)]
	// RVA: 0x24BBE10 Offset: 0x24BB010 VA: 0x1824BBE10
	public void set_cellSize(Vector3 value) { }

	[FreeFunction("GridBindings::GetCellGap", HasExplicitThis = True)]
	// RVA: 0x24BBB70 Offset: 0x24BAD70 VA: 0x1824BBB70
	public Vector3 get_cellGap() { }

	[FreeFunction("GridBindings::SetCellGap", HasExplicitThis = True)]
	// RVA: 0x24BBD30 Offset: 0x24BAF30 VA: 0x1824BBD30
	public void set_cellGap(Vector3 value) { }

	// RVA: 0x24BBBC0 Offset: 0x24BADC0 VA: 0x1824BBBC0
	public GridLayout.CellLayout get_cellLayout() { }

	// RVA: 0x24BBD80 Offset: 0x24BAF80 VA: 0x1824BBD80
	public void set_cellLayout(GridLayout.CellLayout value) { }

	// RVA: 0x24BBCA0 Offset: 0x24BAEA0 VA: 0x1824BBCA0
	public GridLayout.CellSwizzle get_cellSwizzle() { }

	// RVA: 0x24BBE60 Offset: 0x24BB060 VA: 0x1824BBE60
	public void set_cellSwizzle(GridLayout.CellSwizzle value) { }

	[FreeFunction("GridBindings::CellSwizzle")]
	// RVA: 0x24BBAC0 Offset: 0x24BACC0 VA: 0x1824BBAC0
	public static Vector3 Swizzle(GridLayout.CellSwizzle swizzle, Vector3 position) { }

	[FreeFunction("GridBindings::InverseCellSwizzle")]
	// RVA: 0x24BBA10 Offset: 0x24BAC10 VA: 0x1824BBA10
	public static Vector3 InverseSwizzle(GridLayout.CellSwizzle swizzle, Vector3 position) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x24BBC00 Offset: 0x24BAE00 VA: 0x1824BBC00
	private void get_cellSize_Injected(out Vector3 ret) { }

	// RVA: 0x24BBDC0 Offset: 0x24BAFC0 VA: 0x1824BBDC0
	private void set_cellSize_Injected(ref Vector3 value) { }

	// RVA: 0x24BBB20 Offset: 0x24BAD20 VA: 0x1824BBB20
	private void get_cellGap_Injected(out Vector3 ret) { }

	// RVA: 0x24BBCE0 Offset: 0x24BAEE0 VA: 0x1824BBCE0
	private void set_cellGap_Injected(ref Vector3 value) { }

	// RVA: 0x24BBA70 Offset: 0x24BAC70 VA: 0x1824BBA70
	private static void Swizzle_Injected(GridLayout.CellSwizzle swizzle, ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x24BB9C0 Offset: 0x24BABC0 VA: 0x1824BB9C0
	private static void InverseSwizzle_Injected(GridLayout.CellSwizzle swizzle, ref Vector3 position, out Vector3 ret) { }
}

// Namespace: 
public enum GridLayout.CellLayout // TypeDefIndex: 18171
{
	// Fields
	public int value__; // 0x0
	public const GridLayout.CellLayout Rectangle = 0;
	public const GridLayout.CellLayout Hexagon = 1;
	public const GridLayout.CellLayout Isometric = 2;
	public const GridLayout.CellLayout IsometricZAsY = 3;
}

// Namespace: 
public enum GridLayout.CellSwizzle // TypeDefIndex: 18172
{
	// Fields
	public int value__; // 0x0
	public const GridLayout.CellSwizzle XYZ = 0;
	public const GridLayout.CellSwizzle XZY = 1;
	public const GridLayout.CellSwizzle YXZ = 2;
	public const GridLayout.CellSwizzle YZX = 3;
	public const GridLayout.CellSwizzle ZXY = 4;
	public const GridLayout.CellSwizzle ZYX = 5;
}

// Namespace: UnityEngine
[NativeType(Header = "Modules/Grid/Public/Grid.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
public class GridLayout : Behaviour // TypeDefIndex: 18173
{
	// Methods

	[FreeFunction("GridLayoutBindings::CellToLocalInterpolated", HasExplicitThis = True)]
	// RVA: 0x24BB3E0 Offset: 0x24BA5E0 VA: 0x1824BB3E0
	public Vector3 CellToLocalInterpolated(Vector3 cellPosition) { }

	[FreeFunction("GridLayoutBindings::CellToWorld", HasExplicitThis = True)]
	// RVA: 0x24BB4A0 Offset: 0x24BA6A0 VA: 0x1824BB4A0
	public Vector3 CellToWorld(Vector3Int cellPosition) { }

	[FreeFunction("GridLayoutBindings::WorldToCell", HasExplicitThis = True)]
	// RVA: 0x24BB6C0 Offset: 0x24BA8C0 VA: 0x1824BB6C0
	public Vector3Int WorldToCell(Vector3 worldPosition) { }

	[FreeFunction("GridLayoutBindings::LocalToWorld", HasExplicitThis = True)]
	// RVA: 0x24BB600 Offset: 0x24BA800 VA: 0x1824BB600
	public Vector3 LocalToWorld(Vector3 localPosition) { }

	[FreeFunction("GridLayoutBindings::GetLayoutCellCenter", HasExplicitThis = True)]
	// RVA: 0x24BB550 Offset: 0x24BA750 VA: 0x1824BB550
	public Vector3 GetLayoutCellCenter() { }

	[RequiredByNativeCode]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void DoNothing() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x24BB380 Offset: 0x24BA580 VA: 0x1824BB380
	private void CellToLocalInterpolated_Injected(ref Vector3 cellPosition, out Vector3 ret) { }

	// RVA: 0x24BB440 Offset: 0x24BA640 VA: 0x1824BB440
	private void CellToWorld_Injected(ref Vector3Int cellPosition, out Vector3 ret) { }

	// RVA: 0x24BB660 Offset: 0x24BA860 VA: 0x1824BB660
	private void WorldToCell_Injected(ref Vector3 worldPosition, out Vector3Int ret) { }

	// RVA: 0x24BB5A0 Offset: 0x24BA7A0 VA: 0x1824BB5A0
	private void LocalToWorld_Injected(ref Vector3 localPosition, out Vector3 ret) { }

	// RVA: 0x24BB500 Offset: 0x24BA700 VA: 0x1824BB500
	private void GetLayoutCellCenter_Injected(out Vector3 ret) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18174
{}

// Namespace: Microsoft.CodeAnalysis
[Embedded]
[CompilerGenerated]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 18175
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 18176
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System
internal static class ThrowHelper // TypeDefIndex: 18177
{
	// Methods

	// RVA: 0x1C3BFE0 Offset: 0x1C3B1E0 VA: 0x181C3BFE0
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1C3C010 Offset: 0x1C3B210 VA: 0x181C3C010
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x1C3BF20 Offset: 0x1C3B120 VA: 0x181C3BF20
	private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1C3BF80 Offset: 0x1C3B180 VA: 0x181C3BF80
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x1C3BED0 Offset: 0x1C3B0D0 VA: 0x181C3BED0
	private static string GetArgumentName(ExceptionArgument argument) { }
}

// Namespace: System
internal enum ExceptionArgument // TypeDefIndex: 18178
{
	// Fields
	public int value__; // 0x0
	public const ExceptionArgument task = 0;
	public const ExceptionArgument source = 1;
	public const ExceptionArgument state = 2;
}

// Namespace: System.Threading.Tasks
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
[IsReadOnly]
internal struct ValueTask : IEquatable<ValueTask> // TypeDefIndex: 18179
{
	// Fields
	private static readonly Task s_canceledTask; // 0x0
	[CompilerGenerated]
	private static readonly Task <CompletedTask>k__BackingField; // 0x8
	internal readonly object _obj; // 0x0
	internal readonly short _token; // 0x8
	internal readonly bool _continueOnCapturedContext; // 0xA

	// Properties
	internal static Task CompletedTask { get; }
	public bool IsCompleted { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C3C640 Offset: 0x1C3B840 VA: 0x181C3C640
	internal static Task get_CompletedTask() { }

	// RVA: 0x1C3C610 Offset: 0x1C3B810 VA: 0x181C3C610
	public void .ctor(Task task) { }

	// RVA: 0x15B15E0 Offset: 0x15B07E0 VA: 0x1815B15E0
	private void .ctor(object obj, short token, bool continueOnCapturedContext) { }

	// RVA: 0x15B1100 Offset: 0x15B0300 VA: 0x1815B1100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C3C400 Offset: 0x1C3B600 VA: 0x181C3C400 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15B10E0 Offset: 0x15B02E0 VA: 0x1815B10E0 Slot: 4
	public bool Equals(ValueTask other) { }

	// RVA: 0x1C3C690 Offset: 0x1C3B890 VA: 0x181C3C690
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x1C3C4B0 Offset: 0x1C3B6B0 VA: 0x181C3C4B0
	internal void ThrowIfCompletedUnsuccessfully() { }

	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public ValueTaskAwaiter GetAwaiter() { }

	// RVA: 0x15B1000 Offset: 0x15B0200 VA: 0x1815B1000
	public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x1C3C570 Offset: 0x1C3B770 VA: 0x181C3C570
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder<TResult>))]
[IsReadOnly]
internal struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> // TypeDefIndex: 18180
{
	// Fields
	internal readonly object _obj; // 0x0
	internal readonly TResult _result; // 0x0
	internal readonly short _token; // 0x0
	internal readonly bool _continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompletedSuccessfully { get; }
	public TResult Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD16620 Offset: 0xD15820 VA: 0x180D16620
	|-ValueTask<int>..ctor
	|
	|-RVA: 0xD28B10 Offset: 0xD27D10 VA: 0x180D28B10
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15DD0 Offset: 0xD14FD0 VA: 0x180D15DD0
	|-ValueTask<int>.GetHashCode
	|
	|-RVA: 0xD2BB10 Offset: 0xD2AD10 VA: 0x180D2BB10
	|-ValueTask<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15AB0 Offset: 0xD14CB0 VA: 0x180D15AB0
	|-ValueTask<int>.Equals
	|
	|-RVA: 0xD2B510 Offset: 0xD2A710 VA: 0x180D2B510
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15BD0 Offset: 0xD14DD0 VA: 0x180D15BD0
	|-ValueTask<int>.Equals
	|
	|-RVA: 0xD2A6F0 Offset: 0xD298F0 VA: 0x180D2A6F0
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD16780 Offset: 0xD15980 VA: 0x180D16780
	|-ValueTask<int>.get_IsCompletedSuccessfully
	|
	|-RVA: 0xD29360 Offset: 0xD28560 VA: 0x180D29360
	|-ValueTask<__Il2CppFullySharedGenericType>.get_IsCompletedSuccessfully
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04530 Offset: 0xD03730 VA: 0x180D04530
	|-ValueTask<int>.get_Result
	|
	|-RVA: 0xD29A60 Offset: 0xD28C60 VA: 0x180D29A60
	|-ValueTask<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD16470 Offset: 0xD15670 VA: 0x180D16470
	|-ValueTask<int>.ToString
	|
	|-RVA: 0xD2CD10 Offset: 0xD2BF10 VA: 0x180D2CD10
	|-ValueTask<__Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: System.Threading.Tasks.Sources
[Flags]
internal enum ValueTaskSourceOnCompletedFlags // TypeDefIndex: 18181
{
	// Fields
	public int value__; // 0x0
	public const ValueTaskSourceOnCompletedFlags None = 0;
	public const ValueTaskSourceOnCompletedFlags UseSchedulingContext = 1;
	public const ValueTaskSourceOnCompletedFlags FlowExecutionContext = 2;
}

// Namespace: System.Threading.Tasks.Sources
internal enum ValueTaskSourceStatus // TypeDefIndex: 18182
{
	// Fields
	public int value__; // 0x0
	public const ValueTaskSourceStatus Pending = 0;
	public const ValueTaskSourceStatus Succeeded = 1;
	public const ValueTaskSourceStatus Faulted = 2;
	public const ValueTaskSourceStatus Canceled = 3;
}

// Namespace: System.Threading.Tasks.Sources
internal interface IValueTaskSource // TypeDefIndex: 18183
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetResult(short token);
}

// Namespace: System.Threading.Tasks.Sources
internal interface IValueTaskSource<TResult> // TypeDefIndex: 18184
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.GetStatus
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TResult GetResult(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.GetResult
	*/
}

// Namespace: System.Runtime.CompilerServices
[Usage(5148, Inherited = False, AllowMultiple = False)]
internal sealed class AsyncMethodBuilderAttribute : Attribute // TypeDefIndex: 18185
{
	// Fields
	[CompilerGenerated]
	private readonly Type <BuilderType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type builderType) { }
}

// Namespace: System.Runtime.CompilerServices
internal struct AsyncValueTaskMethodBuilder // TypeDefIndex: 18186
{
	// Fields
	private AsyncTaskMethodBuilder _methodBuilder; // 0x0
	private bool _haveResult; // 0x18
	private bool _useBuilder; // 0x19

	// Properties
	public ValueTask Task { get; }

	// Methods

	// RVA: 0x9E9120 Offset: 0x9E8320 VA: 0x1809E9120
	public static AsyncValueTaskMethodBuilder Create() { }

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x941B80 Offset: 0x940D80 VA: 0x180941B80
	|-AsyncValueTaskMethodBuilder.Start<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x941C00 Offset: 0x940E00 VA: 0x180941C00
	|-AsyncValueTaskMethodBuilder.Start<CachingTransport.<DisposeAsync>d__33>
	|
	|-RVA: 0x941C80 Offset: 0x940E80 VA: 0x180941C80
	|-AsyncValueTaskMethodBuilder.Start<Utf8JsonWriter.<DisposeAsync>d__35>
	*/

	// RVA: 0x1C3BB60 Offset: 0x1C3AD60 VA: 0x181C3BB60
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x1C3BB00 Offset: 0x1C3AD00 VA: 0x181C3BB00
	public void SetResult() { }

	// RVA: 0x1C3BAA0 Offset: 0x1C3ACA0 VA: 0x181C3BAA0
	public void SetException(Exception exception) { }

	// RVA: 0x1C3BBC0 Offset: 0x1C3ADC0 VA: 0x181C3BBC0
	public ValueTask get_Task() { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x941AF0 Offset: 0x940CF0 VA: 0x180941AF0
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x941A60 Offset: 0x940C60 VA: 0x180941A60
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<DisposeAsync>d__33>
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Utf8JsonWriter.<DisposeAsync>d__35>
	*/
}

// Namespace: System.Runtime.CompilerServices
internal struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 18187
{
	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0
}

// Namespace: 
[IsReadOnly]
public struct ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 18188
{
	// Fields
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	internal void .ctor(ValueTask value) { }

	// RVA: 0x1C3BE80 Offset: 0x1C3B080 VA: 0x181C3BE80
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x1C3BC70 Offset: 0x1C3AE70 VA: 0x181C3BC70
	public void GetResult() { }

	// RVA: 0x1C3BCC0 Offset: 0x1C3AEC0 VA: 0x181C3BCC0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
internal struct ConfiguredValueTaskAwaitable // TypeDefIndex: 18189
{
	// Fields
	private readonly ValueTask _value; // 0x0

	// Methods

	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	internal void .ctor(ValueTask value) { }

	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter GetAwaiter() { }
}

// Namespace: 
[IsReadOnly]
public struct ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 18190
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB7D40 Offset: 0xFB6F40 VA: 0x180FB7D40
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
internal struct ConfiguredValueTaskAwaitable<TResult> // TypeDefIndex: 18191
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ValueTaskAwaiter.<>c // TypeDefIndex: 18192
{
	// Fields
	public static readonly ValueTaskAwaiter.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1C3C0A0 Offset: 0x1C3B2A0 VA: 0x181C3C0A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C3C040 Offset: 0x1C3B240 VA: 0x181C3C040
	internal void <.cctor>b__9_0(object state) { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
internal struct ValueTaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 18193
{
	// Fields
	internal static readonly Action<object> s_invokeActionDelegate; // 0x0
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	internal void .ctor(ValueTask value) { }

	// RVA: 0x1C3C3B0 Offset: 0x1C3B5B0 VA: 0x181C3C3B0
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x1C3C100 Offset: 0x1C3B300 VA: 0x181C3C100
	public void GetResult() { }

	// RVA: 0x1C3C150 Offset: 0x1C3B350 VA: 0x181C3C150 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x1C3C2F0 Offset: 0x1C3B4F0 VA: 0x181C3C2F0
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
internal struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 18194
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD14870 Offset: 0xD13A70 VA: 0x180D14870
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/
}

// Namespace: System.Diagnostics
[Usage(108, Inherited = False)]
internal sealed class StackTraceHiddenAttribute : Attribute // TypeDefIndex: 18195
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18196
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 18197
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 18198
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 18199
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(byte ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SentryInitialization.<>c__DisplayClass5_0 // TypeDefIndex: 18200
{
	// Fields
	public ITransaction runtimeStartTransaction; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x1538860 Offset: 0x1537A60 VA: 0x181538860
	internal void <Init>b__0(Scope scope) { }
}

// Namespace: Sentry.Unity
public static class SentryInitialization // TypeDefIndex: 18201
{
	// Fields
	public static ISpan InitSpan; // 0x0
	public static ISpan SubSystemRegistrationSpan; // 0x8

	// Methods

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x15375D0 Offset: 0x15367D0 VA: 0x1815375D0
	public static void Init() { }
}

// Namespace: Sentry.Unity
public class SentryUnityInfo : ISentryUnityInfo // TypeDefIndex: 18202
{
	// Fields
	private Il2CppMethods _il2CppMethods; // 0x10

	// Properties
	public bool IL2CPP { get; }
	public Il2CppMethods Il2CppMethods { get; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 4
	public bool get_IL2CPP() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	public Il2CppMethods get_Il2CppMethods() { }

	[NullableContext(2)]
	// RVA: 0x1537FC0 Offset: 0x15371C0 VA: 0x181537FC0
	private static string SanitizeDebugId(IntPtr debugIdPtr) { }

	// RVA: 0x1537CB0 Offset: 0x1536EB0 VA: 0x181537CB0
	private static IntPtr Il2CppGcHandleGetTargetShim(IntPtr gchandle) { }

	// RVA: 0x1538180 Offset: 0x1537380 VA: 0x181538180
	private static extern IntPtr il2cpp_gchandle_get_target(int gchandle) { }

	// RVA: 0x1538170 Offset: 0x1537370 VA: 0x181538170
	private static extern void il2cpp_free(IntPtr ptr) { }

	[NullableContext(2)]
	// RVA: 0x1537CE0 Offset: 0x1536EE0 VA: 0x181537CE0
	private static void Il2CppNativeStackTraceShim(IntPtr exc, out IntPtr addresses, out int numFrames, out string imageUUID, out string imageName) { }

	// RVA: 0x1538190 Offset: 0x1537390 VA: 0x181538190
	private static extern void il2cpp_native_stack_trace(IntPtr exc, out IntPtr addresses, out int numFrames, out IntPtr imageUUID, out IntPtr imageName) { }

	// RVA: 0x1537E50 Offset: 0x1537050 VA: 0x181537E50 Slot: 6
	public bool IsKnownPlatform() { }

	// RVA: 0x1537EC0 Offset: 0x15370C0 VA: 0x181537EC0 Slot: 7
	public bool IsLinux() { }

	// RVA: 0x1537F20 Offset: 0x1537120 VA: 0x181537F20 Slot: 8
	public bool IsNativeSupportEnabled(SentryUnityOptions options, RuntimePlatform platform) { }

	// RVA: 0x1538030 Offset: 0x1537230 VA: 0x181538030
	public void .ctor() { }
}

// Namespace: Sentry.Unity
public static class SentryIntegrations // TypeDefIndex: 18203
{
	// Methods

	// RVA: 0x1537B90 Offset: 0x1536D90 VA: 0x181537B90
	public static void Configure(SentryUnityOptions options) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StartupTracingIntegration.<>c // TypeDefIndex: 18204
{
	// Fields
	public static readonly StartupTracingIntegration.<>c <>9; // 0x0
	[Nullable(new[] { 0, 1 })]
	public static Action<Scope> <>9__13_0; // 0x8

	// Methods

	// RVA: 0x1538950 Offset: 0x1537B50 VA: 0x181538950
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x1538800 Offset: 0x1537A00 VA: 0x181538800
	internal void <AfterSceneLoad>b__13_0(Scope s) { }
}

// Namespace: Sentry.Unity
public class StartupTracingIntegration : ISdkIntegration // TypeDefIndex: 18205
{
	// Fields
	private static ISpan AfterAssembliesSpan; // 0x0
	private static ISpan SplashScreenSpan; // 0x8
	private static ISpan FirstSceneLoadSpan; // 0x10
	private static bool StartupAlreadyCaptured; // 0x18
	private static bool IntegrationRegistered; // 0x19
	private static IDiagnosticLogger Logger; // 0x20

	// Methods

	// RVA: 0x1538790 Offset: 0x1537990 VA: 0x181538790 Slot: 4
	public void Register(IHub hub, SentryOptions options) { }

	[RuntimeInitializeOnLoadMethod(2)]
	// RVA: 0x15381A0 Offset: 0x15373A0 VA: 0x1815381A0
	public static void AfterAssembliesLoaded() { }

	[RuntimeInitializeOnLoadMethod(3)]
	// RVA: 0x1538650 Offset: 0x1537850 VA: 0x181538650
	public static void BeforeSplashScreen() { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x1538510 Offset: 0x1537710 VA: 0x181538510
	public static void BeforeSceneLoad() { }

	[RuntimeInitializeOnLoadMethod(0)]
	// RVA: 0x15382F0 Offset: 0x15374F0 VA: 0x1815382F0
	public static void AfterSceneLoad() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Unity
public class SceneManagerTracingIntegration : ISdkIntegration // TypeDefIndex: 18206
{
	// Fields
	private static IDiagnosticLogger Logger; // 0x0

	// Methods

	// RVA: 0x1537410 Offset: 0x1536610 VA: 0x181537410 Slot: 4
	public void Register(IHub hub, SentryOptions options) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SceneManagerTracingAPI.<>c__DisplayClass4_0 // TypeDefIndex: 18207
{
	// Fields
	public ITransaction transaction; // 0x10
	public SceneManagerTracingAPI <>4__this; // 0x18
	public string sceneName; // 0x20
	public ISpan span; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x1538860 Offset: 0x1537A60 VA: 0x181538860
	internal void <LoadSceneAsyncByNameOrIndex>b__0(Scope scope) { }

	// RVA: 0x1538880 Offset: 0x1537A80 VA: 0x181538880
	internal void <LoadSceneAsyncByNameOrIndex>b__1(AsyncOperation _) { }
}

// Namespace: Sentry.Unity
public class SceneManagerTracingAPI : SceneManagerAPI // TypeDefIndex: 18208
{
	// Fields
	private readonly IDiagnosticLogger _logger; // 0x10

	// Methods

	// RVA: 0x15373B0 Offset: 0x15365B0 VA: 0x1815373B0
	public void .ctor(IDiagnosticLogger logger) { }

	// RVA: 0x1537100 Offset: 0x1536300 VA: 0x181537100 Slot: 4
	protected override AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18209
{}

// Namespace: UnityEngineInternal.Input
internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 18210
{
	// Methods

	// RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }
}

// Namespace: UnityEngineInternal.Input
internal struct NativeInputEventBuffer // TypeDefIndex: 18211
{
	// Fields
	public void* eventBuffer; // 0x0
	public int eventCount; // 0x8
	public int sizeInBytes; // 0xC
	public int capacityInBytes; // 0x10
}

// Namespace: UnityEngineInternal.Input
[Flags]
internal enum NativeInputUpdateType // TypeDefIndex: 18212
{
	// Fields
	public int value__; // 0x0
	public const NativeInputUpdateType Dynamic = 1;
	public const NativeInputUpdateType Fixed = 2;
	public const NativeInputUpdateType BeforeRender = 4;
	public const NativeInputUpdateType Editor = 8;
	public const NativeInputUpdateType IgnoreFocus = -2147483648;
}

// Namespace: UnityEngineInternal.Input
[NativeHeader("Modules/Input/Private/InputInternal.h")]
[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
internal class NativeInputSystem // TypeDefIndex: 18213
{
	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x8
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
	private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18

	// Properties
	internal static bool hasDeviceDiscoveredCallback { set; }

	// Methods

	// RVA: 0x24E2B80 Offset: 0x24E1D80 VA: 0x1824E2B80
	private static void .cctor() { }

	[RequiredByNativeCode]
	// RVA: 0x24E2960 Offset: 0x24E1B60 VA: 0x1824E2960
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCode]
	// RVA: 0x24E2A50 Offset: 0x24E1C50 VA: 0x1824E2A50
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[RequiredByNativeCode]
	// RVA: 0x24E29D0 Offset: 0x24E1BD0 VA: 0x1824E29D0
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCode]
	// RVA: 0x24E2AF0 Offset: 0x24E1CF0 VA: 0x1824E2AF0
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	// RVA: 0x24E2BB0 Offset: 0x24E1DB0 VA: 0x1824E2BB0
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18214
{}

// Namespace: UnityEngine
[NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
public static class JsonUtility // TypeDefIndex: 18215
{
	// Methods

	[FreeFunction("ToJsonInternal", True)]
	[ThreadSafe]
	// RVA: 0x24E2E50 Offset: 0x24E2050 VA: 0x1824E2E50
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

	[ThreadSafe]
	[FreeFunction("FromJsonInternal", True, ThrowsException = True)]
	// RVA: 0x24E2BF0 Offset: 0x24E1DF0 VA: 0x1824E2BF0
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: 0x24E2EA0 Offset: 0x24E20A0 VA: 0x1824E2EA0
	public static string ToJson(object obj) { }

	// RVA: 0x24E3040 Offset: 0x24E2240 VA: 0x1824E3040
	public static string ToJson(object obj, bool prettyPrint) { }

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2F020 Offset: 0xA2E220 VA: 0x180A2F020
	|-JsonUtility.FromJson<DiagnosticEvent>
	|
	|-RVA: 0xA2F270 Offset: 0xA2E470 VA: 0x180A2F270
	|-JsonUtility.FromJson<object>
	|
	|-RVA: 0xA2F120 Offset: 0xA2E320 VA: 0x180A2F120
	|-JsonUtility.FromJson<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xA2F330 Offset: 0xA2E530 VA: 0x180A2F330
	|-JsonUtility.FromJson<DataPrivacy.TokenData>
	*/

	// RVA: 0x24E2C50 Offset: 0x24E1E50 VA: 0x1824E2C50
	public static object FromJson(string json, Type type) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18216
{}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestAssetBundle // TypeDefIndex: 18217
{
	// Methods

	// RVA: 0x2711430 Offset: 0x2710630 VA: 0x182711430
	public static UnityWebRequest GetAssetBundle(string uri) { }

	// RVA: 0x2711220 Offset: 0x2710420 VA: 0x182711220
	public static UnityWebRequest GetAssetBundle(string uri, uint crc) { }

	// RVA: 0x2711300 Offset: 0x2710500 VA: 0x182711300
	public static UnityWebRequest GetAssetBundle(string uri, CachedAssetBundle cachedAssetBundle, uint crc = 0) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequestAssetBundle/Public/DownloadHandlerAssetBundle.h")]
public sealed class DownloadHandlerAssetBundle : DownloadHandler // TypeDefIndex: 18218
{
	// Properties
	public AssetBundle assetBundle { get; }
	public bool autoLoadAssetBundle { get; }
	public bool isDownloadComplete { get; }

	// Methods

	// RVA: 0x2710ED0 Offset: 0x27100D0 VA: 0x182710ED0
	private static IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc) { }

	// RVA: 0x2710E60 Offset: 0x2710060 VA: 0x182710E60
	private static IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x2710FF0 Offset: 0x27101F0 VA: 0x182710FF0
	private void InternalCreateAssetBundle(string url, uint crc) { }

	// RVA: 0x2710F80 Offset: 0x2710180 VA: 0x182710F80
	private void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x2711050 Offset: 0x2710250 VA: 0x182711050
	public void .ctor(string url, uint crc) { }

	// RVA: 0x27110B0 Offset: 0x27102B0 VA: 0x1827110B0
	public void .ctor(string url, CachedAssetBundle cachedBundle, uint crc) { }

	// RVA: 0x2710F30 Offset: 0x2710130 VA: 0x182710F30 Slot: 7
	protected override string GetText() { }

	// RVA: 0x2711160 Offset: 0x2710360 VA: 0x182711160
	public AssetBundle get_assetBundle() { }

	// RVA: 0x27111A0 Offset: 0x27103A0 VA: 0x1827111A0
	public bool get_autoLoadAssetBundle() { }

	// RVA: 0x27111E0 Offset: 0x27103E0 VA: 0x1827111E0
	public bool get_isDownloadComplete() { }

	// RVA: 0x2710DF0 Offset: 0x270FFF0 VA: 0x182710DF0
	private static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, string url, string name, ref Hash128 hash, uint crc) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18219
{}

// Namespace: FxResources.System.Buffers
internal static class SR // TypeDefIndex: 18220
{}

// Namespace: System
internal static class SR // TypeDefIndex: 18221
{
	// Fields
	private static ResourceManager s_resourceManager; // 0x0
	[CompilerGenerated]
	private static readonly Type <ResourceType>k__BackingField; // 0x8

	// Properties
	private static ResourceManager ResourceManager { get; }
	internal static Type ResourceType { get; }
	internal static string ArgumentException_BufferNotFromPool { get; }

	// Methods

	// RVA: 0x1BAD0C0 Offset: 0x1BAC2C0 VA: 0x181BAD0C0
	private static ResourceManager get_ResourceManager() { }

	// RVA: 0x1BACE10 Offset: 0x1BAC010 VA: 0x181BACE10
	internal static string GetResourceString(string resourceKey, string defaultString) { }

	[CompilerGenerated]
	// RVA: 0x1BAD1C0 Offset: 0x1BAC3C0 VA: 0x181BAD1C0
	internal static Type get_ResourceType() { }

	// RVA: 0x1BAD060 Offset: 0x1BAC260 VA: 0x181BAD060
	internal static string get_ArgumentException_BufferNotFromPool() { }

	// RVA: 0x1BACFE0 Offset: 0x1BAC1E0 VA: 0x181BACFE0
	private static void .cctor() { }
}

// Namespace: System.Buffers
internal abstract class ArrayPool<T> // TypeDefIndex: 18222
{
	// Fields
	private static ArrayPool<T> s_sharedInstance; // 0x0

	// Properties
	public static ArrayPool<T> Shared { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArrayPool<T> get_Shared() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9B20 Offset: 0x12A8D20 VA: 0x1812A9B20
	|-ArrayPool<ValueTuple<object, object, object>>.get_Shared
	|
	|-RVA: 0x12A9970 Offset: 0x12A8B70 VA: 0x1812A9970
	|-ArrayPool<ValueTuple<object, JsonReaderState, long, object, object>>.get_Shared
	|
	|-RVA: 0x12A9A90 Offset: 0x12A8C90 VA: 0x1812A9A90
	|-ArrayPool<byte>.get_Shared
	|
	|-RVA: 0x12A9A00 Offset: 0x12A8C00 VA: 0x1812A9A00
	|-ArrayPool<char>.get_Shared
	|
	|-RVA: 0x12A9830 Offset: 0x12A8A30 VA: 0x1812A9830
	|-ArrayPool<object>.get_Shared
	|
	|-RVA: 0x12A98C0 Offset: 0x12A8AC0 VA: 0x1812A98C0
	|-ArrayPool<__Il2CppFullySharedGenericType>.get_Shared
	*/

	// RVA: -1 Offset: -1
	private static ArrayPool<T> EnsureSharedCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8DC0 Offset: 0x12A7FC0 VA: 0x1812A8DC0
	|-ArrayPool<ValueTuple<object, object, object>>.EnsureSharedCreated
	|
	|-RVA: 0x12A8C80 Offset: 0x12A7E80 VA: 0x1812A8C80
	|-ArrayPool<ValueTuple<object, JsonReaderState, long, object, object>>.EnsureSharedCreated
	|
	|-RVA: 0x12A9270 Offset: 0x12A8470 VA: 0x1812A9270
	|-ArrayPool<byte>.EnsureSharedCreated
	|
	|-RVA: 0x12A9130 Offset: 0x12A8330 VA: 0x1812A9130
	|-ArrayPool<char>.EnsureSharedCreated
	|
	|-RVA: 0x12A8F00 Offset: 0x12A8100 VA: 0x1812A8F00
	|-ArrayPool<object>.EnsureSharedCreated
	|
	|-RVA: 0x12A9040 Offset: 0x12A8240 VA: 0x1812A9040
	|-ArrayPool<__Il2CppFullySharedGenericType>.EnsureSharedCreated
	*/

	// RVA: -1 Offset: -1
	public static ArrayPool<T> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8B00 Offset: 0x12A7D00 VA: 0x1812A8B00
	|-ArrayPool<ValueTuple<object, object, object>>.Create
	|
	|-RVA: 0x12A8C00 Offset: 0x12A7E00 VA: 0x1812A8C00
	|-ArrayPool<ValueTuple<object, JsonReaderState, long, object, object>>.Create
	|
	|-RVA: 0x12A8B80 Offset: 0x12A7D80 VA: 0x1812A8B80
	|-ArrayPool<byte>.Create
	|
	|-RVA: 0x12A8950 Offset: 0x12A7B50 VA: 0x1812A8950
	|-ArrayPool<char>.Create
	|
	|-RVA: 0x12A89D0 Offset: 0x12A7BD0 VA: 0x1812A89D0
	|-ArrayPool<object>.Create
	|
	|-RVA: 0x12A8A50 Offset: 0x12A7C50 VA: 0x1812A8A50
	|-ArrayPool<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T[] Rent(int minimumLength);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Return(T[] array, bool clearArray = False);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<__Il2CppFullySharedGenericType>.Return
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ArrayPool<ValueTuple<object, object, object>>..ctor
	|-ArrayPool<ValueTuple<object, JsonReaderState, long, object, object>>..ctor
	|-ArrayPool<byte>..ctor
	|-ArrayPool<char>..ctor
	|-ArrayPool<object>..ctor
	|-ArrayPool<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
internal enum ArrayPoolEventSource.BufferAllocatedReason // TypeDefIndex: 18223
{
	// Fields
	public int value__; // 0x0
	public const ArrayPoolEventSource.BufferAllocatedReason Pooled = 0;
	public const ArrayPoolEventSource.BufferAllocatedReason OverMaximumSize = 1;
	public const ArrayPoolEventSource.BufferAllocatedReason PoolExhausted = 2;
}

// Namespace: System.Buffers
[EventSource(Name = "System.Buffers.ArrayPoolEventSource")]
internal sealed class ArrayPoolEventSource : EventSource // TypeDefIndex: 18224
{
	// Fields
	internal static readonly ArrayPoolEventSource Log; // 0x0

	// Methods

	[Event(1, Level = 5)]
	// RVA: 0x1BACCB0 Offset: 0x1BABEB0 VA: 0x181BACCB0
	internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId) { }

	[Event(2, Level = 4)]
	// RVA: 0x1BACBA0 Offset: 0x1BABDA0 VA: 0x181BACBA0
	internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason) { }

	[Event(3, Level = 5)]
	// RVA: 0x172DD30 Offset: 0x172CF30 VA: 0x18172DD30
	internal void BufferReturned(int bufferId, int bufferSize, int poolId) { }

	// RVA: 0x172F990 Offset: 0x172EB90 VA: 0x18172F990
	public void .ctor() { }

	// RVA: 0x1BACDB0 Offset: 0x1BABFB0 VA: 0x181BACDB0
	private static void .cctor() { }
}

// Namespace: 
private sealed class DefaultArrayPool.Bucket<T> // TypeDefIndex: 18225
{
	// Fields
	internal readonly int _bufferLength; // 0x0
	private readonly T[][] _buffers; // 0x0
	private readonly int _poolId; // 0x0
	private SpinLock _lock; // 0x0
	private int _index; // 0x0

	// Properties
	internal int Id { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int bufferLength, int numberOfBuffers, int poolId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEED420 Offset: 0xEEC620 VA: 0x180EED420
	|-DefaultArrayPool.Bucket<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0xEED690 Offset: 0xEEC890 VA: 0x180EED690
	|-DefaultArrayPool.Bucket<ValueTuple<object, JsonReaderState, long, object, object>>..ctor
	|
	|-RVA: 0xEED760 Offset: 0xEEC960 VA: 0x180EED760
	|-DefaultArrayPool.Bucket<byte>..ctor
	|
	|-RVA: 0xEED5C0 Offset: 0xEEC7C0 VA: 0x180EED5C0
	|-DefaultArrayPool.Bucket<char>..ctor
	|
	|-RVA: 0xEED830 Offset: 0xEECA30 VA: 0x180EED830
	|-DefaultArrayPool.Bucket<object>..ctor
	|
	|-RVA: 0xEED4F0 Offset: 0xEEC6F0 VA: 0x180EED4F0
	|-DefaultArrayPool.Bucket<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCB0640 Offset: 0xCAF840 VA: 0x180CB0640
	|-DefaultArrayPool.Bucket<ValueTuple<object, object, object>>.get_Id
	|-DefaultArrayPool.Bucket<ValueTuple<object, JsonReaderState, long, object, object>>.get_Id
	|-DefaultArrayPool.Bucket<byte>.get_Id
	|-DefaultArrayPool.Bucket<char>.get_Id
	|-DefaultArrayPool.Bucket<object>.get_Id
	|-DefaultArrayPool.Bucket<__Il2CppFullySharedGenericType>.get_Id
	*/

	// RVA: -1 Offset: -1
	internal T[] Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEC260 Offset: 0xEEB460 VA: 0x180EEC260
	|-DefaultArrayPool.Bucket<ValueTuple<object, object, object>>.Rent
	|
	|-RVA: 0xEEC790 Offset: 0xEEB990 VA: 0x180EEC790
	|-DefaultArrayPool.Bucket<ValueTuple<object, JsonReaderState, long, object, object>>.Rent
	|
	|-RVA: 0xEEBAB0 Offset: 0xEEACB0 VA: 0x180EEBAB0
	|-DefaultArrayPool.Bucket<byte>.Rent
	|
	|-RVA: 0xEEBD40 Offset: 0xEEAF40 VA: 0x180EEBD40
	|-DefaultArrayPool.Bucket<char>.Rent
	|
	|-RVA: 0xEEBFD0 Offset: 0xEEB1D0 VA: 0x180EEBFD0
	|-DefaultArrayPool.Bucket<object>.Rent
	|
	|-RVA: 0xEEC4F0 Offset: 0xEEB6F0 VA: 0x180EEC4F0
	|-DefaultArrayPool.Bucket<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1
	internal void Return(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEECD80 Offset: 0xEEBF80 VA: 0x180EECD80
	|-DefaultArrayPool.Bucket<ValueTuple<object, object, object>>.Return
	|
	|-RVA: 0xEECBE0 Offset: 0xEEBDE0 VA: 0x180EECBE0
	|-DefaultArrayPool.Bucket<ValueTuple<object, JsonReaderState, long, object, object>>.Return
	|
	|-RVA: 0xEECF20 Offset: 0xEEC120 VA: 0x180EECF20
	|-DefaultArrayPool.Bucket<byte>.Return
	|
	|-RVA: 0xEED280 Offset: 0xEEC480 VA: 0x180EED280
	|-DefaultArrayPool.Bucket<char>.Return
	|
	|-RVA: 0xEECA20 Offset: 0xEEBC20 VA: 0x180EECA20
	|-DefaultArrayPool.Bucket<object>.Return
	|
	|-RVA: 0xEED0C0 Offset: 0xEEC2C0 VA: 0x180EED0C0
	|-DefaultArrayPool.Bucket<__Il2CppFullySharedGenericType>.Return
	*/
}

// Namespace: System.Buffers
internal sealed class DefaultArrayPool<T> : ArrayPool<T> // TypeDefIndex: 18226
{
	// Fields
	private static T[] s_emptyArray; // 0x0
	private readonly DefaultArrayPool.Bucket<T>[] _buckets; // 0x0

	// Properties
	private int Id { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC2310 Offset: 0xFC1510 VA: 0x180FC2310
	|-DefaultArrayPool<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0xFC20F0 Offset: 0xFC12F0 VA: 0x180FC20F0
	|-DefaultArrayPool<ValueTuple<object, JsonReaderState, long, object, object>>..ctor
	|
	|-RVA: 0xFC1CA0 Offset: 0xFC0EA0 VA: 0x180FC1CA0
	|-DefaultArrayPool<byte>..ctor
	|
	|-RVA: 0xFC20D0 Offset: 0xFC12D0 VA: 0x180FC20D0
	|-DefaultArrayPool<char>..ctor
	|
	|-RVA: 0xFC1CC0 Offset: 0xFC0EC0 VA: 0x180FC1CC0
	|-DefaultArrayPool<object>..ctor
	|
	|-RVA: 0xFC1C80 Offset: 0xFC0E80 VA: 0x180FC1C80
	|-DefaultArrayPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int maxArrayLength, int maxArraysPerBucket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC2530 Offset: 0xFC1730 VA: 0x180FC2530
	|-DefaultArrayPool<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0xFC1CE0 Offset: 0xFC0EE0 VA: 0x180FC1CE0
	|-DefaultArrayPool<ValueTuple<object, JsonReaderState, long, object, object>>..ctor
	|
	|-RVA: 0xFC2110 Offset: 0xFC1310 VA: 0x180FC2110
	|-DefaultArrayPool<byte>..ctor
	|
	|-RVA: 0xFC1A80 Offset: 0xFC0C80 VA: 0x180FC1A80
	|-DefaultArrayPool<char>..ctor
	|
	|-RVA: 0xFC2330 Offset: 0xFC1530 VA: 0x180FC2330
	|-DefaultArrayPool<object>..ctor
	|
	|-RVA: 0xFC1EE0 Offset: 0xFC10E0 VA: 0x180FC1EE0
	|-DefaultArrayPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCB0640 Offset: 0xCAF840 VA: 0x180CB0640
	|-DefaultArrayPool<ValueTuple<object, object, object>>.get_Id
	|-DefaultArrayPool<ValueTuple<object, JsonReaderState, long, object, object>>.get_Id
	|-DefaultArrayPool<byte>.get_Id
	|-DefaultArrayPool<char>.get_Id
	|-DefaultArrayPool<object>.get_Id
	|-DefaultArrayPool<__Il2CppFullySharedGenericType>.get_Id
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBFBD0 Offset: 0xFBEDD0 VA: 0x180FBFBD0
	|-DefaultArrayPool<ValueTuple<object, object, object>>.Rent
	|
	|-RVA: 0xFC03F0 Offset: 0xFBF5F0 VA: 0x180FC03F0
	|-DefaultArrayPool<ValueTuple<object, JsonReaderState, long, object, object>>.Rent
	|
	|-RVA: 0xFBF7D0 Offset: 0xFBE9D0 VA: 0x180FBF7D0
	|-DefaultArrayPool<byte>.Rent
	|
	|-RVA: 0xFC0BF0 Offset: 0xFBFDF0 VA: 0x180FC0BF0
	|-DefaultArrayPool<char>.Rent
	|
	|-RVA: 0xFC07F0 Offset: 0xFBF9F0 VA: 0x180FC07F0
	|-DefaultArrayPool<object>.Rent
	|
	|-RVA: 0xFBFFD0 Offset: 0xFBF1D0 VA: 0x180FBFFD0
	|-DefaultArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC18C0 Offset: 0xFC0AC0 VA: 0x180FC18C0
	|-DefaultArrayPool<ValueTuple<object, object, object>>.Return
	|
	|-RVA: 0xFC1540 Offset: 0xFC0740 VA: 0x180FC1540
	|-DefaultArrayPool<ValueTuple<object, JsonReaderState, long, object, object>>.Return
	|
	|-RVA: 0xFC11B0 Offset: 0xFC03B0 VA: 0x180FC11B0
	|-DefaultArrayPool<byte>.Return
	|
	|-RVA: 0xFC0FF0 Offset: 0xFC01F0 VA: 0x180FC0FF0
	|-DefaultArrayPool<char>.Return
	|
	|-RVA: 0xFC1700 Offset: 0xFC0900 VA: 0x180FC1700
	|-DefaultArrayPool<object>.Return
	|
	|-RVA: 0xFC1370 Offset: 0xFC0570 VA: 0x180FC1370
	|-DefaultArrayPool<__Il2CppFullySharedGenericType>.Return
	*/
}

// Namespace: System.Buffers
internal static class Utilities // TypeDefIndex: 18227
{
	// Methods

	// RVA: 0xC95740 Offset: 0xC94940 VA: 0x180C95740
	internal static int SelectBucketIndex(int bufferSize) { }

	// RVA: 0x1742250 Offset: 0x1741450 VA: 0x181742250
	internal static int GetMaxSizeForBucket(int binIndex) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18228
{}

// Namespace: UnityEngine
[RejectDragAndDropMaterial]
[NativeType(Header = "Modules/SpriteMask/Public/SpriteMask.h")]
public sealed class SpriteMask : Renderer // TypeDefIndex: 18229
{
	// Properties
	public int frontSortingLayerID { get; set; }
	public int frontSortingOrder { get; set; }
	public int backSortingLayerID { get; set; }
	public int backSortingOrder { get; set; }
	public float alphaCutoff { get; set; }
	public Sprite sprite { get; set; }
	public bool isCustomRangeActive { get; set; }
	public SpriteSortPoint spriteSortPoint { get; set; }

	// Methods

	// RVA: 0x2503EC0 Offset: 0x25030C0 VA: 0x182503EC0
	public int get_frontSortingLayerID() { }

	// RVA: 0x25040D0 Offset: 0x25032D0 VA: 0x1825040D0
	public void set_frontSortingLayerID(int value) { }

	// RVA: 0x2503F00 Offset: 0x2503100 VA: 0x182503F00
	public int get_frontSortingOrder() { }

	// RVA: 0x2504110 Offset: 0x2503310 VA: 0x182504110
	public void set_frontSortingOrder(int value) { }

	// RVA: 0x2503E40 Offset: 0x2503040 VA: 0x182503E40
	public int get_backSortingLayerID() { }

	// RVA: 0x2504050 Offset: 0x2503250 VA: 0x182504050
	public void set_backSortingLayerID(int value) { }

	// RVA: 0x2503E80 Offset: 0x2503080 VA: 0x182503E80
	public int get_backSortingOrder() { }

	// RVA: 0x2504090 Offset: 0x2503290 VA: 0x182504090
	public void set_backSortingOrder(int value) { }

	// RVA: 0x2503E00 Offset: 0x2503000 VA: 0x182503E00
	public float get_alphaCutoff() { }

	// RVA: 0x2504000 Offset: 0x2503200 VA: 0x182504000
	public void set_alphaCutoff(float value) { }

	// RVA: 0x2503FC0 Offset: 0x25031C0 VA: 0x182503FC0
	public Sprite get_sprite() { }

	// RVA: 0x25041E0 Offset: 0x25033E0 VA: 0x1825041E0
	public void set_sprite(Sprite value) { }

	[NativeMethod("IsCustomRangeActive")]
	// RVA: 0x2503F40 Offset: 0x2503140 VA: 0x182503F40
	public bool get_isCustomRangeActive() { }

	[NativeMethod("SetCustomRangeActive")]
	// RVA: 0x2504150 Offset: 0x2503350 VA: 0x182504150
	public void set_isCustomRangeActive(bool value) { }

	// RVA: 0x2503F80 Offset: 0x2503180 VA: 0x182503F80
	public SpriteSortPoint get_spriteSortPoint() { }

	// RVA: 0x25041A0 Offset: 0x25033A0 VA: 0x1825041A0
	public void set_spriteSortPoint(SpriteSortPoint value) { }

	// RVA: 0x2503DA0 Offset: 0x2502FA0 VA: 0x182503DA0
	internal Bounds GetSpriteBounds() { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }

	// RVA: 0x2503D50 Offset: 0x2502F50 VA: 0x182503D50
	private void GetSpriteBounds_Injected(out Bounds ret) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18230
{}

// Namespace: 
public sealed class NavMesh.OnNavMeshPreUpdate : MulticastDelegate // TypeDefIndex: 18231
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine.AI
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[StaticAccessor("NavMeshBindings", 2)]
[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/NavMeshManager.h")]
public static class NavMesh // TypeDefIndex: 18232
{
	// Fields
	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x242FED0 Offset: 0x242F0D0 VA: 0x18242FED0
	private static void Internal_CallOnNavMeshPreUpdate() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18233
{}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[NativeHeader("Modules/Director/PlayableDirector.h")]
public class PlayableDirector : Behaviour // TypeDefIndex: 18234
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<PlayableDirector> played; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<PlayableDirector> paused; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<PlayableDirector> stopped; // 0x28

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24BB340 Offset: 0x24BA540 VA: 0x1824BB340
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCode]
	// RVA: 0x24BB320 Offset: 0x24BA520 VA: 0x1824BB320
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCode]
	// RVA: 0x24BB360 Offset: 0x24BA560 VA: 0x1824BB360
	private void SendOnPlayableDirectorStop() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18235
{}

// Namespace: UnityEngine
[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
[Extension]
public static class ImageConversion // TypeDefIndex: 18236
{
	// Methods

	[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = True, ThrowsException = True)]
	[Extension]
	// RVA: 0x24BBF20 Offset: 0x24BB120 VA: 0x1824BBF20
	public static byte[] EncodeToPNG(Texture2D tex) { }

	[NativeMethod(Name = "ImageConversionBindings::EncodeToJPG", IsFreeFunction = True, ThrowsException = True)]
	[Extension]
	// RVA: 0x24BBEA0 Offset: 0x24BB0A0 VA: 0x1824BBEA0
	public static byte[] EncodeToJPG(Texture2D tex, int quality) { }

	[Extension]
	// RVA: 0x24BBEE0 Offset: 0x24BB0E0 VA: 0x1824BBEE0
	public static byte[] EncodeToJPG(Texture2D tex) { }

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
	// RVA: 0x24BBFB0 Offset: 0x24BB1B0 VA: 0x1824BBFB0
	public static bool LoadImage(Texture2D tex, byte[] data, bool markNonReadable) { }

	[Extension]
	// RVA: 0x24BBF60 Offset: 0x24BB160 VA: 0x1824BBF60
	public static bool LoadImage(Texture2D tex, byte[] data) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18237
{}

// Namespace: 
public enum ScreenCapture.StereoScreenCaptureMode // TypeDefIndex: 18238
{
	// Fields
	public int value__; // 0x0
	public const ScreenCapture.StereoScreenCaptureMode LeftEye = 1;
	public const ScreenCapture.StereoScreenCaptureMode RightEye = 2;
	public const ScreenCapture.StereoScreenCaptureMode BothEyes = 3;
}

// Namespace: UnityEngine
[NativeHeader("Modules/ScreenCapture/Public/CaptureScreenshot.h")]
public static class ScreenCapture // TypeDefIndex: 18239
{
	// Methods

	// RVA: 0x2503550 Offset: 0x2502750 VA: 0x182503550
	public static void CaptureScreenshot(string filename) { }

	// RVA: 0x2503440 Offset: 0x2502640 VA: 0x182503440
	public static Texture2D CaptureScreenshotAsTexture() { }

	// RVA: 0x25034C0 Offset: 0x25026C0 VA: 0x1825034C0
	public static void CaptureScreenshotIntoRenderTexture(RenderTexture renderTexture) { }

	// RVA: 0x2503500 Offset: 0x2502700 VA: 0x182503500
	private static void CaptureScreenshot(string filename, int superSize, ScreenCapture.StereoScreenCaptureMode CaptureMode) { }

	// RVA: 0x2503480 Offset: 0x2502680 VA: 0x182503480
	private static Texture2D CaptureScreenshotAsTexture(int superSize, ScreenCapture.StereoScreenCaptureMode stereoScreenCaptureMode) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18240
{}

// Namespace: UnityEngine.Analytics
[NativeHeader("Modules/UnityAnalyticsCommon/Public/UnityAnalyticsCommon.h")]
public static class AnalyticsCommon // TypeDefIndex: 18241
{
	// Properties
	[StaticAccessor("GetUnityAnalyticsCommon()", 0)]
	private static bool ugsAnalyticsEnabledInternal { set; }
	public static bool ugsAnalyticsEnabled { set; }

	// Methods

	[NativeMethod("SetUGSAnalyticsUserOptStatus")]
	// RVA: 0x270F0C0 Offset: 0x270E2C0 VA: 0x18270F0C0
	private static void set_ugsAnalyticsEnabledInternal(bool value) { }

	// RVA: 0x270F0C0 Offset: 0x270E2C0 VA: 0x18270F0C0
	public static void set_ugsAnalyticsEnabled(bool value) { }
}

// Namespace: UnityEngine.Analytics
public interface UGSAnalyticsInternalTools // TypeDefIndex: 18242
{
	// Methods

	// RVA: 0x270F0C0 Offset: 0x270E2C0 VA: 0x18270F0C0
	public static void SetPrivacyStatus(bool status) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18243
{}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
public static class XRDevice // TypeDefIndex: 18244
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string> deviceLoaded; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2716FD0 Offset: 0x27161D0 VA: 0x182716FD0
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18245
{}

// Namespace: UnityEngine.U2D
[NativeType(Header = "Modules/SpriteShape/Public/SpriteShapeRenderer.h")]
[MovedFrom("UnityEngine.Experimental.U2D")]
public class SpriteShapeRenderer : Renderer // TypeDefIndex: 18246
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 18247
{}

// Namespace: Unity.Services.Core.Configuration
internal class CloudProjectId : ICloudProjectId, IServiceComponent // TypeDefIndex: 18248
{
	// Methods

	// RVA: 0x239EA80 Offset: 0x239DC80 VA: 0x18239EA80 Slot: 4
	public string GetCloudProjectId() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Configuration
[Extension]
internal static class ConfigurationCollectionHelper // TypeDefIndex: 18249
{
	// Methods

	[Extension]
	// RVA: 0x239EAC0 Offset: 0x239DCC0 VA: 0x18239EAC0
	public static void FillWith(IDictionary<string, ConfigurationEntry> self, SerializableProjectConfiguration config) { }

	[Extension]
	// RVA: 0x239EB50 Offset: 0x239DD50 VA: 0x18239EB50
	public static void FillWith(IDictionary<string, ConfigurationEntry> self, InitializationOptions options) { }

	[Extension]
	// RVA: 0x239EEB0 Offset: 0x239E0B0 VA: 0x18239EEB0
	private static void SetOrCreateEntry(IDictionary<string, ConfigurationEntry> self, string key, ConfigurationEntry entry) { }
}

// Namespace: Unity.Services.Core.Configuration
[Serializable]
internal class ConfigurationEntry // TypeDefIndex: 18250
{
	// Fields
	[JsonRequired]
	[SerializeField]
	private string m_Value; // 0x10
	[JsonRequired]
	[SerializeField]
	private bool m_IsReadOnly; // 0x18

	// Properties
	[JsonIgnore]
	public string Value { get; }
	[JsonIgnore]
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Value() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_IsReadOnly() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x11FF670 Offset: 0x11FE870 VA: 0x1811FF670
	public void .ctor(string value, bool isReadOnly = False) { }

	// RVA: 0x239F080 Offset: 0x239E280 VA: 0x18239F080
	public bool TrySetValue(string value) { }

	// RVA: 0x239F090 Offset: 0x239E290 VA: 0x18239F090
	public static string op_Implicit(ConfigurationEntry entry) { }

	// RVA: 0x239F0B0 Offset: 0x239E2B0 VA: 0x18239F0B0
	public static ConfigurationEntry op_Implicit(string value) { }
}

// Namespace: Unity.Services.Core.Configuration
internal static class ConfigurationUtils // TypeDefIndex: 18251
{
	// Fields
	[CompilerGenerated]
	private static IConfigurationLoader <ConfigurationLoader>k__BackingField; // 0x0

	// Properties
	public static IConfigurationLoader ConfigurationLoader { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x239F1B0 Offset: 0x239E3B0 VA: 0x18239F1B0
	public static IConfigurationLoader get_ConfigurationLoader() { }

	// RVA: 0x239F110 Offset: 0x239E310 VA: 0x18239F110
	private static void .cctor() { }
}

// Namespace: Unity.Services.Core.Configuration
internal class ExternalUserId : IExternalUserId, IServiceComponent // TypeDefIndex: 18252
{
	// Properties
	public string UserId { get; }

	// Methods

	// RVA: 0x239F200 Offset: 0x239E400 VA: 0x18239F200 Slot: 4
	public string get_UserId() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Configuration
internal interface IConfigurationLoader // TypeDefIndex: 18253
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<SerializableProjectConfiguration> GetConfigAsync();
}

// Namespace: Unity.Services.Core.Configuration
internal class ProjectConfiguration : IProjectConfiguration, IServiceComponent // TypeDefIndex: 18254
{
	// Fields
	private readonly IReadOnlyDictionary<string, ConfigurationEntry> m_ConfigValues; // 0x10
	[CompilerGenerated]
	private readonly IJsonSerializer <Serializer>k__BackingField; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(IReadOnlyDictionary<string, ConfigurationEntry> configValues, IJsonSerializer serializer) { }

	// RVA: 0x239F260 Offset: 0x239E460 VA: 0x18239F260 Slot: 4
	public string GetString(string key, string defaultValue) { }
}

// Namespace: Unity.Services.Core.Configuration
[Serializable]
internal struct SerializableProjectConfiguration // TypeDefIndex: 18255
{
	// Fields
	[SerializeField]
	[JsonRequired]
	internal string[] Keys; // 0x0
	[JsonRequired]
	[SerializeField]
	internal ConfigurationEntry[] Values; // 0x8

	// Properties
	public static SerializableProjectConfiguration Empty { get; }

	// Methods

	// RVA: 0x239F370 Offset: 0x239E570 VA: 0x18239F370
	public static SerializableProjectConfiguration get_Empty() { }
}

// Namespace: 
[CompilerGenerated]
private struct StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 18256
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<SerializableProjectConfiguration> <>t__builder; // 0x8
	public StreamingAssetsConfigurationLoader <>4__this; // 0x20
	private TaskAwaiter<string> <>u__1; // 0x28

	// Methods

	// RVA: 0x239F5E0 Offset: 0x239E7E0 VA: 0x18239F5E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x239F8A0 Offset: 0x239EAA0 VA: 0x18239F8A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Unity.Services.Core.Configuration
internal class StreamingAssetsConfigurationLoader : IConfigurationLoader // TypeDefIndex: 18257
{
	// Fields
	private readonly IJsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IJsonSerializer serializer) { }

	[AsyncStateMachine(typeof(StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2))]
	// RVA: 0x239F3D0 Offset: 0x239E5D0 VA: 0x18239F3D0 Slot: 4
	public Task<SerializableProjectConfiguration> GetConfigAsync() { }
}

// Namespace: Unity.Services.Core.Configuration
internal static class StreamingAssetsUtils // TypeDefIndex: 18258
{
	// Methods

	// RVA: 0x239F4A0 Offset: 0x239E6A0 VA: 0x18239F4A0
	public static Task<string> GetFileTextFromStreamingAssetsAsync(string path) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18259
{}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class ActionScheduler : IActionScheduler, IServiceComponent // TypeDefIndex: 18260
{
	// Fields
	internal readonly PlayerLoopSystem SchedulerLoopSystem; // 0x10
	private readonly ITimeProvider m_TimeProvider; // 0x38
	private readonly object m_Lock; // 0x40
	private readonly MinimumBinaryHeap<ScheduledInvocation> m_ScheduledActions; // 0x48
	private readonly Dictionary<long, ScheduledInvocation> m_IdScheduledInvocationMap; // 0x50
	private readonly List<ScheduledInvocation> m_ExpiredActions; // 0x58
	private long m_NextId; // 0x60

	// Methods

	// RVA: 0x23A94C0 Offset: 0x23A86C0 VA: 0x1823A94C0
	public void .ctor() { }

	// RVA: 0x23A92A0 Offset: 0x23A84A0 VA: 0x1823A92A0
	public void .ctor(ITimeProvider timeProvider) { }

	// RVA: 0x23A8B20 Offset: 0x23A7D20 VA: 0x1823A8B20
	internal void ExecuteExpiredActions() { }

	// RVA: 0x23A9220 Offset: 0x23A8420 VA: 0x1823A9220
	internal static void UpdateCurrentPlayerLoopWith(List<PlayerLoopSystem> subSystemList, PlayerLoopSystem currentPlayerLoop) { }

	// RVA: 0x23A9000 Offset: 0x23A8200 VA: 0x1823A9000
	public void JoinPlayerLoopSystem() { }
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal abstract class MinimumBinaryHeap // TypeDefIndex: 18261
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct MinimumBinaryHeap.<>c__DisplayClass21_0<T> // TypeDefIndex: 18262
{
	// Fields
	public int smallest; // 0x0
	public int currentIndex; // 0x0
	public MinimumBinaryHeap<T> <>4__this; // 0x0
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class MinimumBinaryHeap<T> : MinimumBinaryHeap // TypeDefIndex: 18263
{
	// Fields
	private readonly object m_Lock; // 0x0
	private readonly IComparer<T> m_Comparer; // 0x0
	private readonly int m_MinimumCapacity; // 0x0
	private T[] m_HeapArray; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	public int Count { get; set; }
	public T Min { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	|-MinimumBinaryHeap<object>.get_Count
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	|-MinimumBinaryHeap<object>.set_Count
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.set_Count
	*/

	// RVA: -1 Offset: -1
	public T get_Min() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1469B60 Offset: 0x1468D60 VA: 0x181469B60
	|-MinimumBinaryHeap<object>.get_Min
	|
	|-RVA: 0x1469B90 Offset: 0x1468D90 VA: 0x181469B90
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.get_Min
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<T> comparer, int minimumCapacity = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1469760 Offset: 0x1468960 VA: 0x181469760
	|-MinimumBinaryHeap<object>..ctor
	|
	|-RVA: 0x1469730 Offset: 0x1468930 VA: 0x181469730
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(ICollection<T> collection, IComparer<T> comparer, int minimumCapacity = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1469790 Offset: 0x1468990 VA: 0x181469790
	|-MinimumBinaryHeap<object>..ctor
	|
	|-RVA: 0x1469210 Offset: 0x1468410 VA: 0x181469210
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Insert(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14682D0 Offset: 0x14674D0 VA: 0x1814682D0
	|-MinimumBinaryHeap<object>.Insert
	|
	|-RVA: 0x1467DD0 Offset: 0x1466FD0 VA: 0x181467DD0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	private void IncreaseHeapCapacityWhenFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467A60 Offset: 0x1466C60 VA: 0x181467A60
	|-MinimumBinaryHeap<object>.IncreaseHeapCapacityWhenFull
	|
	|-RVA: 0x1467920 Offset: 0x1466B20 VA: 0x181467920
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.IncreaseHeapCapacityWhenFull
	*/

	// RVA: -1 Offset: -1
	public void Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14687B0 Offset: 0x14679B0 VA: 0x1814687B0
	|-MinimumBinaryHeap<object>.Remove
	|
	|-RVA: 0x1468960 Offset: 0x1467B60 VA: 0x181468960
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	private int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467B40 Offset: 0x1466D40 VA: 0x181467B40
	|-MinimumBinaryHeap<object>.IndexOf
	|
	|-RVA: 0x1467BD0 Offset: 0x1466DD0 VA: 0x181467BD0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public T ExtractMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467550 Offset: 0x1466750 VA: 0x181467550
	|-MinimumBinaryHeap<object>.ExtractMin
	|
	|-RVA: 0x1466FC0 Offset: 0x14661C0 VA: 0x181466FC0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.ExtractMin
	*/

	// RVA: -1 Offset: -1
	private void DecreaseHeapCapacityWhenSpare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1466EE0 Offset: 0x14660E0 VA: 0x181466EE0
	|-MinimumBinaryHeap<object>.DecreaseHeapCapacityWhenSpare
	|
	|-RVA: 0x1466D80 Offset: 0x1465F80 VA: 0x181466D80
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.DecreaseHeapCapacityWhenSpare
	*/

	// RVA: -1 Offset: -1
	private void MinHeapify() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14685F0 Offset: 0x14677F0 VA: 0x1814685F0
	|-MinimumBinaryHeap<object>.MinHeapify
	|
	|-RVA: 0x14686E0 Offset: 0x14678E0 VA: 0x1814686E0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.MinHeapify
	*/

	// RVA: -1 Offset: -1
	private static void Swap(ref T lhs, ref T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA531F0 Offset: 0xA523F0 VA: 0x180A531F0
	|-MinimumBinaryHeap<object>.Swap
	|
	|-RVA: 0x1468C10 Offset: 0x1467E10 VA: 0x181468C10
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1
	private static int GetParentIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467900 Offset: 0x1466B00 VA: 0x181467900
	|-MinimumBinaryHeap<object>.GetParentIndex
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetParentIndex
	*/

	// RVA: -1 Offset: -1
	private static int GetLeftChildIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14678F0 Offset: 0x1466AF0 VA: 0x1814678F0
	|-MinimumBinaryHeap<object>.GetLeftChildIndex
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetLeftChildIndex
	*/

	// RVA: -1 Offset: -1
	private static int GetRightChildIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467910 Offset: 0x1466B10 VA: 0x181467910
	|-MinimumBinaryHeap<object>.GetRightChildIndex
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetRightChildIndex
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <MinHeapify>g__UpdateSmallestIndex|21_0(ref MinimumBinaryHeap.<>c__DisplayClass21_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1469190 Offset: 0x1468390 VA: 0x181469190
	|-MinimumBinaryHeap<object>.<MinHeapify>g__UpdateSmallestIndex|21_0
	|
	|-RVA: 0x14690B0 Offset: 0x14682B0 VA: 0x1814690B0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.<MinHeapify>g__UpdateSmallestIndex|21_0
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(int candidate, ref MinimumBinaryHeap.<>c__DisplayClass21_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1468E20 Offset: 0x1468020 VA: 0x181468E20
	|-MinimumBinaryHeap<object>.<MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1
	|
	|-RVA: 0x1468EE0 Offset: 0x14680E0 VA: 0x181468EE0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.<MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1
	*/
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class ScheduledInvocation // TypeDefIndex: 18264
{
	// Fields
	public Action Action; // 0x10
	public DateTime InvocationTime; // 0x18
	public long ActionId; // 0x20
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class ScheduledInvocationComparer : IComparer<ScheduledInvocation> // TypeDefIndex: 18265
{
	// Methods

	// RVA: 0x23A9710 Offset: 0x23A8910 VA: 0x1823A9710 Slot: 4
	public int Compare(ScheduledInvocation x, ScheduledInvocation y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal interface ITimeProvider // TypeDefIndex: 18266
{
	// Properties
	public abstract DateTime Now { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DateTime get_Now();
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class UtcTimeProvider : ITimeProvider // TypeDefIndex: 18267
{
	// Properties
	public DateTime Now { get; }

	// Methods

	// RVA: 0x23A97D0 Offset: 0x23A89D0 VA: 0x1823A97D0 Slot: 4
	public DateTime get_Now() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18268
{}

// Namespace: System.Runtime.CompilerServices
internal static class Unsafe // TypeDefIndex: 18269
{
	// Methods

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static T Read<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	|-Unsafe.Read<Vector<ushort>>
	|
	|-RVA: 0xAA0C20 Offset: 0xA9FE20 VA: 0x180AA0C20
	|-Unsafe.Read<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static T ReadUnaligned<T>(ref byte source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	|-Unsafe.ReadUnaligned<Vector<byte>>
	|
	|-RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	|-Unsafe.ReadUnaligned<int>
	|-Unsafe.ReadUnaligned<uint>
	|
	|-RVA: 0x4D1BF0 Offset: 0x4D0DF0 VA: 0x1804D1BF0
	|-Unsafe.ReadUnaligned<ushort>
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-Unsafe.ReadUnaligned<ulong>
	|-Unsafe.ReadUnaligned<UIntPtr>
	|-Unsafe.ReadUnaligned<JsonDocument.StackRow>
	|
	|-RVA: 0xAA0C20 Offset: 0xA9FE20 VA: 0x180AA0C20
	|-Unsafe.ReadUnaligned<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xAA0C00 Offset: 0xA9FE00 VA: 0x180AA0C00
	|-Unsafe.ReadUnaligned<JsonDocument.DbRow>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static void WriteUnaligned<T>(ref byte destination, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	|-Unsafe.WriteUnaligned<int>
	|-Unsafe.WriteUnaligned<uint>
	|
	|-RVA: 0xAA0CD0 Offset: 0xA9FED0 VA: 0x180AA0CD0
	|-Unsafe.WriteUnaligned<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xAA0CC0 Offset: 0xA9FEC0 VA: 0x180AA0CC0
	|-Unsafe.WriteUnaligned<JsonDocument.DbRow>
	|
	|-RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	|-Unsafe.WriteUnaligned<JsonDocument.StackRow>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static void* AsPointer<T>(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-Unsafe.AsPointer<byte>
	|-Unsafe.AsPointer<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F8DD0 Offset: 0x6F7FD0 VA: 0x1806F8DD0
	|-Unsafe.SizeOf<Vector<ushort>>
	|
	|-RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	|-Unsafe.SizeOf<byte>
	|
	|-RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920
	|-Unsafe.SizeOf<char>
	|
	|-RVA: 0xAA00D0 Offset: 0xA9F2D0 VA: 0x180AA00D0
	|-Unsafe.SizeOf<DebugDirectoryEntry>
	|
	|-RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0
	|-Unsafe.SizeOf<int>
	|-Unsafe.SizeOf<uint>
	|
	|-RVA: 0xAA01A0 Offset: 0xA9F3A0 VA: 0x180AA01A0
	|-Unsafe.SizeOf<SectionHeader>
	|
	|-RVA: 0xAA01D0 Offset: 0xA9F3D0 VA: 0x180AA01D0
	|-Unsafe.SizeOf<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xAA0160 Offset: 0xA9F360 VA: 0x180AA0160
	|-Unsafe.SizeOf<JsonDocument.DbRow>
	|
	|-RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0
	|-Unsafe.SizeOf<JsonDocument.StackRow>
	*/

	[NonVersionable]
	// RVA: 0x1BD9450 Offset: 0x1BD8650 VA: 0x181BD9450
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionable]
	// RVA: 0x168EF80 Offset: 0x168E180 VA: 0x18168EF80
	public static void InitBlockUnaligned(void* startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	// RVA: 0x168EF80 Offset: 0x168E180 VA: 0x18168EF80
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-Unsafe.As<object>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<DebugDirectoryEntry>
	|-Unsafe.AsRef<int>
	|-Unsafe.AsRef<SectionHeader>
	|-Unsafe.AsRef<uint>
	|-Unsafe.AsRef<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-Unsafe.As<Memory<byte>, ReadOnlyMemory<byte>>
	|-Unsafe.As<Memory<char>, ReadOnlyMemory<char>>
	|-Unsafe.As<ReadOnlySequence<byte>, ReadOnlySequence<char>>
	|-Unsafe.As<ReadOnlySequence<char>, ReadOnlySequence<char>>
	|-Unsafe.As<byte, byte>
	|-Unsafe.As<byte, char>
	|-Unsafe.As<byte, int>
	|-Unsafe.As<byte, long>
	|-Unsafe.As<byte, IntPtr>
	|-Unsafe.As<byte, SpanHelpers.Reg16>
	|-Unsafe.As<byte, SpanHelpers.Reg32>
	|-Unsafe.As<byte, SpanHelpers.Reg64>
	|-Unsafe.As<char, byte>
	|-Unsafe.As<char, char>
	|-Unsafe.As<char, IntPtr>
	|-Unsafe.As<DebugDirectoryEntry, byte>
	|-Unsafe.As<DebugDirectoryEntry, char>
	|-Unsafe.As<DebugDirectoryEntry, IntPtr>
	|-Unsafe.As<Decimal, MutableDecimal>
	|-Unsafe.As<short, ushort>
	|-Unsafe.As<int, byte>
	|-Unsafe.As<int, char>
	|-Unsafe.As<int, IntPtr>
	|-Unsafe.As<int, uint>
	|-Unsafe.As<long, ulong>
	|-Unsafe.As<MutableDecimal, Decimal>
	|-Unsafe.As<sbyte, byte>
	|-Unsafe.As<SectionHeader, byte>
	|-Unsafe.As<SectionHeader, char>
	|-Unsafe.As<SectionHeader, IntPtr>
	|-Unsafe.As<uint, byte>
	|-Unsafe.As<uint, char>
	|-Unsafe.As<uint, IntPtr>
	|-Unsafe.As<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA09D0 Offset: 0xA9FBD0 VA: 0x180AA09D0
	|-Unsafe.Add<byte>
	|-Unsafe.Add<sbyte>
	|
	|-RVA: 0xAA0A00 Offset: 0xA9FC00 VA: 0x180AA0A00
	|-Unsafe.Add<char>
	|
	|-RVA: 0xAA09B0 Offset: 0xA9FBB0 VA: 0x180AA09B0
	|-Unsafe.Add<DebugDirectoryEntry>
	|
	|-RVA: 0xAA0A30 Offset: 0xA9FC30 VA: 0x180AA0A30
	|-Unsafe.Add<int>
	|-Unsafe.Add<uint>
	|
	|-RVA: 0xAA0960 Offset: 0xA9FB60 VA: 0x180AA0960
	|-Unsafe.Add<SectionHeader>
	|
	|-RVA: 0xAA0AA0 Offset: 0xA9FCA0 VA: 0x180AA0AA0
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA08C0 Offset: 0xA9FAC0 VA: 0x180AA08C0
	|-Unsafe.Add<byte>
	|
	|-RVA: 0xAA0A10 Offset: 0xA9FC10 VA: 0x180AA0A10
	|-Unsafe.Add<char>
	|
	|-RVA: 0xAA0B40 Offset: 0xA9FD40 VA: 0x180AA0B40
	|-Unsafe.Add<IntPtr>
	|
	|-RVA: 0xAA0AF0 Offset: 0xA9FCF0 VA: 0x180AA0AF0
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA08C0 Offset: 0xA9FAC0 VA: 0x180AA08C0
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<char>
	|-Unsafe.AddByteOffset<DebugDirectoryEntry>
	|-Unsafe.AddByteOffset<int>
	|-Unsafe.AddByteOffset<SectionHeader>
	|-Unsafe.AddByteOffset<uint>
	|-Unsafe.AddByteOffset<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA0BE0 Offset: 0xA9FDE0 VA: 0x180AA0BE0
	|-Unsafe.ByteOffset<byte>
	|-Unsafe.ByteOffset<char>
	|-Unsafe.ByteOffset<DebugDirectoryEntry>
	|-Unsafe.ByteOffset<int>
	|-Unsafe.ByteOffset<SectionHeader>
	|-Unsafe.ByteOffset<uint>
	|-Unsafe.ByteOffset<__Il2CppFullySharedGenericType>
	|-Unsafe.ByteOffset<JsonDocument.DbRow>
	|-Unsafe.ByteOffset<JsonDocument.StackRow>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static bool AreSame<T>(ref T left, ref T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0
	|-Unsafe.AreSame<byte>
	|-Unsafe.AreSame<char>
	|-Unsafe.AreSame<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Runtime.Versioning
[Usage(108, AllowMultiple = False, Inherited = False)]
internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 18270
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18271
{}

// Namespace: Unity.Services.Core
internal class ExternalUserIdProperty // TypeDefIndex: 18272
{
	// Fields
	[CompilerGenerated]
	private Action<string> UserIdChanged; // 0x10
	private string m_UserId; // 0x18

	// Properties
	public string UserId { get; set; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_UserId() { }

	// RVA: 0x239F910 Offset: 0x239EB10 VA: 0x18239F910
	public void set_UserId(string value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Core
public class InitializationOptions // TypeDefIndex: 18273
{
	// Fields
	[CompilerGenerated]
	private readonly IDictionary<string, object> <Values>k__BackingField; // 0x10

	// Properties
	internal IDictionary<string, object> Values { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal IDictionary<string, object> get_Values() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(IDictionary<string, object> values) { }

	// RVA: 0x239F930 Offset: 0x239EB30 VA: 0x18239F930
	internal void .ctor(InitializationOptions source) { }
}

// Namespace: Unity.Services.Core
public class ServicesInitializationException : Exception // TypeDefIndex: 18274
{
	// Methods

	// RVA: 0x239FAA0 Offset: 0x239ECA0 VA: 0x18239FAA0
	public void .ctor() { }

	// RVA: 0x239FA40 Offset: 0x239EC40 VA: 0x18239FA40
	public void .ctor(string message) { }

	// RVA: 0x239FAF0 Offset: 0x239ECF0 VA: 0x18239FAF0
	public void .ctor(string message, Exception innerException) { }
}

// Namespace: Unity.Services.Core
public enum ServicesInitializationState // TypeDefIndex: 18275
{
	// Fields
	public int value__; // 0x0
	public const ServicesInitializationState Uninitialized = 0;
	public const ServicesInitializationState Initializing = 1;
	public const ServicesInitializationState Initialized = 2;
}

// Namespace: Unity.Services.Core
internal class UnityProjectNotLinkedException : ServicesInitializationException // TypeDefIndex: 18276
{
	// Methods

	// RVA: 0x239FA40 Offset: 0x239EC40 VA: 0x18239FA40
	public void .ctor(string message) { }
}

// Namespace: Unity.Services.Core
public interface IUnityServices // TypeDefIndex: 18277
{
	// Properties
	public abstract ServicesInitializationState State { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ServicesInitializationState get_State();
}

// Namespace: Unity.Services.Core
public class RequestFailedException : Exception // TypeDefIndex: 18278
{
	// Fields
	[CompilerGenerated]
	private readonly int <ErrorCode>k__BackingField; // 0x90

	// Methods

	// RVA: 0x239F9C0 Offset: 0x239EBC0 VA: 0x18239F9C0
	public void .ctor(int errorCode, string message, Exception innerException) { }
}

// Namespace: Unity.Services.Core
internal enum ServicesType // TypeDefIndex: 18279
{
	// Fields
	public int value__; // 0x0
	public const ServicesType Default = 0;
	public const ServicesType Instance = 1;
}

// Namespace: Unity.Services.Core
public static class UnityServices // TypeDefIndex: 18280
{
	// Fields
	[CompilerGenerated]
	private static IUnityServices <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private static TaskCompletionSource<object> <InstantiationCompletion>k__BackingField; // 0x8
	internal static ExternalUserIdProperty ExternalUserIdProperty; // 0x10

	// Properties
	internal static IUnityServices Instance { get; set; }
	internal static TaskCompletionSource<object> InstantiationCompletion { get; }
	public static ServicesInitializationState State { get; }
	public static string ExternalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x239FC20 Offset: 0x239EE20 VA: 0x18239FC20
	internal static IUnityServices get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x239FFF0 Offset: 0x239F1F0 VA: 0x18239FFF0
	internal static void set_Instance(IUnityServices value) { }

	[CompilerGenerated]
	// RVA: 0x239FC70 Offset: 0x239EE70 VA: 0x18239FC70
	internal static TaskCompletionSource<object> get_InstantiationCompletion() { }

	// RVA: 0x239FCC0 Offset: 0x239EEC0 VA: 0x18239FCC0
	public static ServicesInitializationState get_State() { }

	// RVA: 0x239FBC0 Offset: 0x239EDC0 VA: 0x18239FBC0
	public static string get_ExternalUserId() { }

	// RVA: 0x239FF60 Offset: 0x239F160 VA: 0x18239FF60
	public static void set_ExternalUserId(string value) { }

	// RVA: 0x239FB60 Offset: 0x239ED60 VA: 0x18239FB60
	private static void .cctor() { }
}

// Namespace: Unity.Services.Core
internal static class UnityThreadUtils // TypeDefIndex: 18281
{
	// Fields
	private static int s_UnityThreadId; // 0x0
	[CompilerGenerated]
	private static TaskScheduler <UnityThreadScheduler>k__BackingField; // 0x8

	// Properties
	private static TaskScheduler UnityThreadScheduler { set; }
	public static bool IsRunningOnUnityThread { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23A0170 Offset: 0x239F370 VA: 0x1823A0170
	private static void set_UnityThreadScheduler(TaskScheduler value) { }

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x23A0050 Offset: 0x239F250 VA: 0x1823A0050
	private static void CaptureUnityThreadInfo() { }

	// RVA: 0x23A0110 Offset: 0x239F310 VA: 0x1823A0110
	public static bool get_IsRunningOnUnityThread() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18282
{}

// Namespace: Microsoft.CodeAnalysis
[Embedded]
[CompilerGenerated]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 18283
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 18284
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System
internal interface IAsyncDisposable // TypeDefIndex: 18285
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTask DisposeAsync();
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
internal struct ConfiguredAsyncDisposable // TypeDefIndex: 18286
{
	// Fields
	private readonly IAsyncDisposable _source; // 0x0
	private readonly bool _continueOnCapturedContext; // 0x8

	// Methods

	// RVA: 0xD3BB10 Offset: 0xD3AD10 VA: 0x180D3BB10
	internal void .ctor(IAsyncDisposable source, bool continueOnCapturedContext) { }

	// RVA: 0x1BACA50 Offset: 0x1BABC50 VA: 0x181BACA50
	public ConfiguredValueTaskAwaitable DisposeAsync() { }
}

// Namespace: System.Threading.Tasks
[Extension]
internal static class TaskAsyncEnumerableExtensions // TypeDefIndex: 18287
{
	// Methods

	[Extension]
	// RVA: 0x1BACB80 Offset: 0x1BABD80 VA: 0x181BACB80
	public static ConfiguredAsyncDisposable ConfigureAwait(IAsyncDisposable source, bool continueOnCapturedContext) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18288
{}

// Namespace: System.Configuration.Provider
public abstract class ProviderBase // TypeDefIndex: 18289
{
	// Methods

	// RVA: 0x1CC8E00 Offset: 0x1CC8000 VA: 0x181CC8E00 Slot: 4
	public virtual void Initialize(string name, NameValueCollection config) { }
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public abstract class ConfigurationElement // TypeDefIndex: 18290
{
	// Properties
	protected internal virtual ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CC8BC0 Offset: 0x1CC7DC0 VA: 0x181CC8BC0 Slot: 4
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x1CC8A40 Offset: 0x1CC7C40 VA: 0x181CC8A40 Slot: 5
	protected internal virtual void DeserializeElement(XmlReader reader, bool serializeCollectionKey) { }

	// RVA: 0x1CC8A70 Offset: 0x1CC7C70 VA: 0x181CC8A70 Slot: 6
	protected internal virtual void InitializeDefault() { }

	// RVA: 0x1CC8AA0 Offset: 0x1CC7CA0 VA: 0x181CC8AA0 Slot: 7
	protected internal virtual bool IsModified() { }

	// RVA: 0x1CC8AD0 Offset: 0x1CC7CD0 VA: 0x181CC8AD0 Slot: 8
	protected virtual void PostDeserialize() { }

	// RVA: 0x1CC8B30 Offset: 0x1CC7D30 VA: 0x181CC8B30 Slot: 9
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0x1CC8B00 Offset: 0x1CC7D00 VA: 0x181CC8B00 Slot: 10
	protected internal virtual void ResetModified() { }

	// RVA: 0x1CC8B60 Offset: 0x1CC7D60 VA: 0x181CC8B60 Slot: 11
	protected internal virtual bool SerializeToXmlElement(XmlWriter writer, string elementName) { }

	// RVA: 0x1CC8B90 Offset: 0x1CC7D90 VA: 0x181CC8B90 Slot: 12
	protected internal virtual void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode) { }
}

// Namespace: System.Configuration
public sealed class Configuration // TypeDefIndex: 18291
{}

// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 18292
{
	// Methods

	// RVA: 0x1CC8BF0 Offset: 0x1CC7DF0 VA: 0x181CC8BF0 Slot: 13
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x1CC8C20 Offset: 0x1CC7E20 VA: 0x181CC8C20 Slot: 7
	protected internal override bool IsModified() { }

	// RVA: 0x1CC8C50 Offset: 0x1CC7E50 VA: 0x181CC8C50 Slot: 10
	protected internal override void ResetModified() { }

	// RVA: 0x1CC8C80 Offset: 0x1CC7E80 VA: 0x181CC8C80 Slot: 14
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }
}

// Namespace: System.Configuration
public enum ConfigurationSaveMode // TypeDefIndex: 18293
{
	// Fields
	public int value__; // 0x0
	public const ConfigurationSaveMode Full = 2;
	public const ConfigurationSaveMode Minimal = 1;
	public const ConfigurationSaveMode Modified = 0;
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public class ConfigurationPropertyCollection // TypeDefIndex: 18294
{}

// Namespace: System.Configuration
[DebuggerDisplay("Count = {Count}")]
public abstract class ConfigurationElementCollection : ConfigurationElement // TypeDefIndex: 18295
{
	// Properties
	public virtual ConfigurationElementCollectionType CollectionType { get; }
	protected virtual string ElementName { get; }
	protected virtual bool ThrowOnDuplicate { get; }

	// Methods

	// RVA: 0x1CC89B0 Offset: 0x1CC7BB0 VA: 0x181CC89B0 Slot: 13
	public virtual ConfigurationElementCollectionType get_CollectionType() { }

	// RVA: 0x1CC89E0 Offset: 0x1CC7BE0 VA: 0x181CC89E0 Slot: 14
	protected virtual string get_ElementName() { }

	// RVA: 0x1CC8A10 Offset: 0x1CC7C10 VA: 0x181CC8A10 Slot: 15
	protected virtual bool get_ThrowOnDuplicate() { }

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract ConfigurationElement CreateNewElement();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract object GetElementKey(ConfigurationElement element);
}

// Namespace: System.Configuration
public enum ConfigurationElementCollectionType // TypeDefIndex: 18296
{
	// Fields
	public int value__; // 0x0
	public const ConfigurationElementCollectionType AddRemoveClearMap = 1;
	public const ConfigurationElementCollectionType AddRemoveClearMapAlternate = 3;
	public const ConfigurationElementCollectionType BasicMap = 0;
	public const ConfigurationElementCollectionType BasicMapAlternate = 2;
}

// Namespace: System.Configuration
[Usage(132)]
public sealed class ConfigurationCollectionAttribute : Attribute // TypeDefIndex: 18297
{
	// Properties
	public string AddItemName { set; }
	public string ClearItemsName { set; }
	public ConfigurationElementCollectionType CollectionType { set; }
	public string RemoveItemName { set; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(Type itemType) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_AddItemName(string value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_ClearItemsName(string value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_CollectionType(ConfigurationElementCollectionType value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_RemoveItemName(string value) { }
}

// Namespace: System.Configuration
public class ConfigurationSectionGroup // TypeDefIndex: 18298
{}

// Namespace: System.Configuration.Provider
[DefaultMember("Item")]
public class ProviderCollection // TypeDefIndex: 18299
{
	// Methods

	// RVA: 0x1CC8E30 Offset: 0x1CC8030 VA: 0x181CC8E30 Slot: 4
	public virtual void Add(ProviderBase provider) { }
}

// Namespace: System.Configuration
public sealed class IgnoreSection : ConfigurationSection // TypeDefIndex: 18300
{
	// Properties
	protected internal override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CC8DA0 Offset: 0x1CC7FA0 VA: 0x181CC8DA0
	public void .ctor() { }

	// RVA: 0x1CC8DD0 Offset: 0x1CC7FD0 VA: 0x181CC8DD0 Slot: 4
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x1CC8CB0 Offset: 0x1CC7EB0 VA: 0x181CC8CB0 Slot: 13
	protected internal override void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0x1CC8CE0 Offset: 0x1CC7EE0 VA: 0x181CC8CE0 Slot: 7
	protected internal override bool IsModified() { }

	// RVA: 0x1CC8D40 Offset: 0x1CC7F40 VA: 0x181CC8D40 Slot: 9
	protected internal override void Reset(ConfigurationElement parentSection) { }

	// RVA: 0x1CC8D10 Offset: 0x1CC7F10 VA: 0x181CC8D10 Slot: 10
	protected internal override void ResetModified() { }

	// RVA: 0x1CC8D70 Offset: 0x1CC7F70 VA: 0x181CC8D70 Slot: 14
	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }
}

// Namespace: System.Configuration.Internal
public interface IConfigErrorInfo // TypeDefIndex: 18301
{
	// Properties
	public abstract string Filename { get; }
	public abstract int LineNumber { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Filename();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LineNumber();
}

// Namespace: Unity
internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 18302
{
	// Methods

	// RVA: 0x1CC8E60 Offset: 0x1CC8060 VA: 0x181CC8E60
	public static void ThrowNotSupportedException() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18303
{}

// Namespace: System.Runtime.Serialization
[Usage(28, Inherited = False, AllowMultiple = False)]
public sealed class DataContractAttribute : Attribute // TypeDefIndex: 18304
{
	// Fields
	private bool isReference; // 0x10

	// Properties
	public bool IsReference { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsReference() { }
}

// Namespace: System.Runtime.Serialization
[Usage(384, Inherited = False, AllowMultiple = False)]
public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 18305
{
	// Fields
	private string name; // 0x10
	private int order; // 0x18
	private bool isRequired; // 0x1C
	private bool emitDefaultValue; // 0x1D

	// Properties
	public string Name { get; }
	public int Order { get; }
	public bool IsRequired { get; }
	public bool EmitDefaultValue { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Order() { }

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_IsRequired() { }

	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0
	public bool get_EmitDefaultValue() { }
}

// Namespace: System.Runtime.Serialization
[Usage(256, Inherited = False, AllowMultiple = False)]
public sealed class EnumMemberAttribute : Attribute // TypeDefIndex: 18306
{
	// Fields
	private string value; // 0x10
	private bool isValueSetExplicitly; // 0x18

	// Properties
	public string Value { get; set; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Value() { }

	// RVA: 0x1ED3910 Offset: 0x1ED2B10 VA: 0x181ED3910
	public void set_Value(string value) { }
}

// Namespace: System.Runtime.Serialization
[Usage(384, Inherited = False, AllowMultiple = False)]
public sealed class IgnoreDataMemberAttribute : Attribute // TypeDefIndex: 18307
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 18308
{}

// Namespace: 
[Serializable]
internal struct DataPrivacy.UserPostData // TypeDefIndex: 18309
{
	// Fields
	public string appid; // 0x0
	public string userid; // 0x8
	public long sessionid; // 0x10
	public string platform; // 0x18
	public uint platformid; // 0x20
	public string sdk_ver; // 0x28
	public bool debug_device; // 0x30
	public string deviceid; // 0x38
	public string plugin_ver; // 0x40
}

// Namespace: 
[Serializable]
internal struct DataPrivacy.TokenData // TypeDefIndex: 18310
{
	// Fields
	public string url; // 0x0
	public string token; // 0x8
}

// Namespace: 
[CompilerGenerated]
private sealed class DataPrivacy.<>c__DisplayClass9_0 // TypeDefIndex: 18311
{
	// Fields
	public UnityWebRequest www; // 0x10
	public Action<string> failure; // 0x18
	public Action<string> success; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2364E60 Offset: 0x2364060 VA: 0x182364E60
	internal void <FetchPrivacyUrl>b__0(AsyncOperation async2) { }
}

// Namespace: UnityEngine.Analytics
public class DataPrivacy // TypeDefIndex: 18312
{
	// Methods

	// RVA: 0x2364C80 Offset: 0x2363E80 VA: 0x182364C80
	internal static DataPrivacy.UserPostData GetUserData() { }

	// RVA: 0x23649D0 Offset: 0x2363BD0 VA: 0x1823649D0
	private static string GetUserAgent() { }

	// RVA: 0x2364DA0 Offset: 0x2363FA0 VA: 0x182364DA0
	private static string getErrorString(UnityWebRequest www) { }

	// RVA: 0x2364650 Offset: 0x2363850 VA: 0x182364650
	public static void FetchPrivacyUrl(Action<string> success, Action<string> failure) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18313
{}

// Namespace: 
public interface IPlatformCDNCache // TypeDefIndex: 18314
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void InitCache(string cacheDir);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SaveCatalog(string json, string localDataPath, string remoteHashValue);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RemoveCatalog(string path);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract UnityWebRequest BundleDownload(string url, CachedAssetBundle cachedAssetBundle);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SaveBundleCache(byte[] data);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void LoadBundleFromCache(Action<AssetBundle> callback, byte[] data);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool CheckLocalCatalog(string path);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string LoadLocalCatalog(string path);
}

// Namespace: 
public static class AmongUsCDNCache // TypeDefIndex: 18315
{
	// Fields
	private static IPlatformCDNCache platform; // 0x0
	private static readonly string cacheDirectory; // 0x8

	// Methods

	// RVA: 0x3D8920 Offset: 0x3D7B20 VA: 0x1803D8920
	public static void InitCache(IPlatformCDNCache currentPlatform) { }

	// RVA: 0x3D8C90 Offset: 0x3D7E90 VA: 0x1803D8C90
	public static void WriteCatalog(string json, string localDataPath, string remoteHashValue) { }

	// RVA: 0x3D8780 Offset: 0x3D7980 VA: 0x1803D8780
	public static void DeleteCatalog(string path) { }

	// RVA: 0x3D8800 Offset: 0x3D7A00 VA: 0x1803D8800
	public static UnityWebRequest DownloadBundle(string url, CachedAssetBundle cachedAssetBundle) { }

	// RVA: 0x3D8BA0 Offset: 0x3D7DA0 VA: 0x1803D8BA0
	public static void SaveAssetBundleCache(byte[] data) { }

	// RVA: 0x3D89B0 Offset: 0x3D7BB0 VA: 0x1803D89B0
	public static void LoadBundleFromCache(Action<AssetBundle> callback, byte[] data) { }

	// RVA: 0x3D8690 Offset: 0x3D7890 VA: 0x1803D8690
	public static bool CheckLocalCatalog(string path) { }

	// RVA: 0x3D8AB0 Offset: 0x3D7CB0 VA: 0x1803D8AB0
	public static string LoadLocalCatalog(string path) { }

	// RVA: 0x3D8DB0 Offset: 0x3D7FB0 VA: 0x1803D8DB0
	private static void .cctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 18316
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
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 18317
{
	// Methods

	// RVA: 0x3D8E00 Offset: 0x3D8000 VA: 0x1803D8E00
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 // TypeDefIndex: 18318
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=46 // TypeDefIndex: 18319
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 18320
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=46 09DC7A896932C3009837A2C32C3D8E600215FA8ADD1936164A8CD1989A6C3403 /*Metadata offset 0x901BD0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 4C8A7BDC8EC3A6E4ACD95898EFFF1E880B8954B5346B18519A6062AD1174A09B /*Metadata offset 0x901C00*/; // 0x2E
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18321
{}

// Namespace: Unity.Services.Core.Device
internal class InstallationId : IInstallationId, IServiceComponent // TypeDefIndex: 18322
{
	// Fields
	internal string Identifier; // 0x10
	internal IUserIdentifierProvider UnityAdsIdentifierProvider; // 0x18
	internal IUserIdentifierProvider UnityAnalyticsIdentifierProvider; // 0x20

	// Methods

	// RVA: 0x23A0420 Offset: 0x239F620 VA: 0x1823A0420
	public void .ctor() { }

	// RVA: 0x23A0360 Offset: 0x239F560 VA: 0x1823A0360 Slot: 4
	public string GetOrCreateIdentifier() { }

	// RVA: 0x23A01B0 Offset: 0x239F3B0 VA: 0x1823A01B0
	public void CreateIdentifier() { }

	// RVA: 0x23A0390 Offset: 0x239F590 VA: 0x1823A0390
	private static string ReadIdentifierFromFile() { }

	// RVA: 0x23A03D0 Offset: 0x239F5D0 VA: 0x1823A03D0
	private static void WriteIdentifierToFile(string identifier) { }

	// RVA: 0x2397170 Offset: 0x2396370 VA: 0x182397170
	private static string GenerateGuid() { }
}

// Namespace: Unity.Services.Core.Device
internal interface IUserIdentifierProvider // TypeDefIndex: 18323
{
	// Properties
	public abstract string UserId { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_UserId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_UserId(string value);
}

// Namespace: Unity.Services.Core.Device
internal class UnityAdsIdentifier : IUserIdentifierProvider // TypeDefIndex: 18324
{
	// Properties
	public string UserId { get; set; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 4
	public string get_UserId() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void set_UserId(string value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Device
internal class UnityAnalyticsIdentifier : IUserIdentifierProvider // TypeDefIndex: 18325
{
	// Properties
	public string UserId { get; set; }

	// Methods

	// RVA: 0x23A04B0 Offset: 0x239F6B0 VA: 0x1823A04B0 Slot: 4
	public string get_UserId() { }

	// RVA: 0x23A04F0 Offset: 0x239F6F0 VA: 0x1823A04F0 Slot: 5
	public void set_UserId(string value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18326
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 18327
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
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 18328
{
	// Methods

	// RVA: 0x1B116A0 Offset: 0x1B108A0 VA: 0x181B116A0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.Internal.Windows
public static class Functions // TypeDefIndex: 18329
{
	// Methods

	// RVA: 0x1B11630 Offset: 0x1B10830 VA: 0x181B11630
	public static void ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=39 // TypeDefIndex: 18330
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=81 // TypeDefIndex: 18331
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 18332
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=39 9B143E82C97D794AC1B2087EB6317E3C45E3C1F8D801A83A658B974135BC5213 /*Metadata offset 0x901C30*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=81 D14607D4F3A715332B430882959084AE205B98BE9B082325165462AA4C12E81A /*Metadata offset 0x901C58*/; // 0x27
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18333
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class DiagnosticsFactory : IDiagnosticsFactory, IServiceComponent // TypeDefIndex: 18334
{
	// Fields
	[CompilerGenerated]
	private readonly IReadOnlyDictionary<string, string> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x23A9810 Offset: 0x23A8A10 VA: 0x1823A9810
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class MetricsFactory : IMetricsFactory, IServiceComponent // TypeDefIndex: 18335
{
	// Fields
	[CompilerGenerated]
	private readonly IReadOnlyDictionary<string, string> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x23A9880 Offset: 0x23A8A80 VA: 0x1823A9880
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18336
{}

// Namespace: Unity.Services.Core.Environments.Internal
internal class Environments : IEnvironments, IServiceComponent // TypeDefIndex: 18337
{
	// Fields
	[CompilerGenerated]
	private string <Current>k__BackingField; // 0x10

	// Properties
	public string Current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string get_Current() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_Current(string value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18338
{}

// Namespace: Unity.Services.Core.Threading.Internal
internal class UnityThreadUtilsInternal : IUnityThreadUtils, IServiceComponent // TypeDefIndex: 18339
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 18340
{}

// Namespace: UnityEngine.Purchasing.Security
public class IAPSecurityException : Exception // TypeDefIndex: 18341
{}

// Namespace: 
internal interface IActivationFactory // TypeDefIndex: 18342
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public override object ActivateInstance() { }
}

// Namespace: System
internal class __Il2CppComObject // TypeDefIndex: 18343
{
	// Methods

	// RVA: 0x2718460 Offset: 0x2717660 VA: 0x182718460 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System
internal sealed class __Il2CppComDelegate : __Il2CppComObject // TypeDefIndex: 18344
{
	// Methods

	// RVA: 0x2718460 Offset: 0x2717660 VA: 0x182718460 Slot: 1
	protected override void Finalize() { }
}

// Namespace: Unity.IL2CPP.Metadata
internal abstract class __Il2CppFullySharedGenericType : ValueType // TypeDefIndex: 18345
{}

// Namespace: Unity.IL2CPP.Metadata
internal abstract struct __Il2CppFullySharedGenericStructType // TypeDefIndex: 18346
{}
