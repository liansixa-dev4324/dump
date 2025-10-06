	// RVA: 0x173D380 Offset: 0x173C580 VA: 0x18173D380
	internal void .ctor(ArrayList l) { }

	// RVA: 0x173D3E0 Offset: 0x173C5E0 VA: 0x18173D3E0 Slot: 22
	public override int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 24
	public override bool get_IsReadOnly() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 23
	public override bool get_IsFixedSize() { }

	// RVA: 0x173D410 Offset: 0x173C610 VA: 0x18173D410 Slot: 25
	public override bool get_IsSynchronized() { }

	// RVA: 0x173D440 Offset: 0x173C640 VA: 0x18173D440 Slot: 27
	public override object get_Item(int index) { }

	// RVA: 0x173D4F0 Offset: 0x173C6F0 VA: 0x18173D4F0 Slot: 28
	public override void set_Item(int index, object value) { }

	// RVA: 0x173D470 Offset: 0x173C670 VA: 0x18173D470 Slot: 26
	public override object get_SyncRoot() { }

	// RVA: 0x173CE40 Offset: 0x173C040 VA: 0x18173CE40 Slot: 29
	public override int Add(object obj) { }

	// RVA: 0x173CDF0 Offset: 0x173BFF0 VA: 0x18173CDF0 Slot: 30
	public override void AddRange(ICollection c) { }

	// RVA: 0x173D4A0 Offset: 0x173C6A0 VA: 0x18173D4A0 Slot: 21
	public override void set_Capacity(int value) { }

	// RVA: 0x173CE90 Offset: 0x173C090 VA: 0x18173CE90 Slot: 31
	public override void Clear() { }

	// RVA: 0x173CEE0 Offset: 0x173C0E0 VA: 0x18173CEE0 Slot: 32
	public override object Clone() { }

	// RVA: 0x173D050 Offset: 0x173C250 VA: 0x18173D050 Slot: 33
	public override bool Contains(object obj) { }

	// RVA: 0x173D0B0 Offset: 0x173C2B0 VA: 0x18173D0B0 Slot: 35
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x173D080 Offset: 0x173C280 VA: 0x18173D080 Slot: 36
	public override void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x173D0E0 Offset: 0x173C2E0 VA: 0x18173D0E0 Slot: 37
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x173D110 Offset: 0x173C310 VA: 0x18173D110 Slot: 38
	public override int IndexOf(object value) { }

	// RVA: 0x173D190 Offset: 0x173C390 VA: 0x18173D190 Slot: 39
	public override void Insert(int index, object obj) { }

	// RVA: 0x173D140 Offset: 0x173C340 VA: 0x18173D140 Slot: 40
	public override void InsertRange(int index, ICollection c) { }

	// RVA: 0x173D280 Offset: 0x173C480 VA: 0x18173D280 Slot: 41
	public override void Remove(object value) { }

	// RVA: 0x173D1E0 Offset: 0x173C3E0 VA: 0x18173D1E0 Slot: 42
	public override void RemoveAt(int index) { }

	// RVA: 0x173D230 Offset: 0x173C430 VA: 0x18173D230 Slot: 43
	public override void RemoveRange(int index, int count) { }

	// RVA: 0x173D2D0 Offset: 0x173C4D0 VA: 0x18173D2D0 Slot: 45
	public override void Sort(int index, int count, IComparer comparer) { }

	// RVA: 0x173D350 Offset: 0x173C550 VA: 0x18173D350 Slot: 46
	public override object[] ToArray() { }

	// RVA: 0x173D320 Offset: 0x173C520 VA: 0x18173D320 Slot: 47
	public override Array ToArray(Type type) { }
}

// Namespace: 
[Serializable]
private sealed class ArrayList.ArrayListEnumeratorSimple : IEnumerator, ICloneable // TypeDefIndex: 4391
{
	// Fields
	private ArrayList _list; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object _currentElement; // 0x20
	private bool _isArrayList; // 0x28
	private static object s_dummyObject; // 0x0

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x172C1D0 Offset: 0x172B3D0 VA: 0x18172C1D0
	internal void .ctor(ArrayList list) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 7
	public object Clone() { }

	// RVA: 0x172BED0 Offset: 0x172B0D0 VA: 0x18172BED0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x172C2D0 Offset: 0x172B4D0 VA: 0x18172C2D0 Slot: 5
	public object get_Current() { }

	// RVA: 0x172C0B0 Offset: 0x172B2B0 VA: 0x18172C0B0 Slot: 6
	public void Reset() { }

	// RVA: 0x172C170 Offset: 0x172B370 VA: 0x18172C170
	private static void .cctor() { }
}

// Namespace: 
internal class ArrayList.ArrayListDebugView // TypeDefIndex: 4392
{}

// Namespace: System.Collections
[DebuggerTypeProxy(typeof(ArrayList.ArrayListDebugView))]
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[Serializable]
public class ArrayList : IList, ICollection, IEnumerable, ICloneable // TypeDefIndex: 4393
{
	// Fields
	private object[] _items; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private const int _defaultCapacity = 4;
	internal const int MaxArrayLength = 2146435071;

	// Properties
	public virtual int Capacity { set; }
	public virtual int Count { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x172D5A0 Offset: 0x172C7A0 VA: 0x18172D5A0
	public void .ctor() { }

	// RVA: 0x172D5F0 Offset: 0x172C7F0 VA: 0x18172D5F0
	public void .ctor(int capacity) { }

	// RVA: 0x172D6F0 Offset: 0x172C8F0 VA: 0x18172D6F0
	public void .ctor(ICollection c) { }

	// RVA: 0x172D930 Offset: 0x172CB30 VA: 0x18172D930 Slot: 21
	public virtual void set_Capacity(int value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 22
	public virtual int get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 23
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 24
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 25
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x172D8C0 Offset: 0x172CAC0 VA: 0x18172D8C0 Slot: 26
	public virtual object get_SyncRoot() { }

	// RVA: 0x172D810 Offset: 0x172CA10 VA: 0x18172D810 Slot: 27
	public virtual object get_Item(int index) { }

	// RVA: 0x172DA40 Offset: 0x172CC40 VA: 0x18172DA40 Slot: 28
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x172C3D0 Offset: 0x172B5D0 VA: 0x18172C3D0
	public static ArrayList Adapter(IList list) { }

	// RVA: 0x172C4D0 Offset: 0x172B6D0 VA: 0x18172C4D0 Slot: 29
	public virtual int Add(object value) { }

	// RVA: 0x172C4B0 Offset: 0x172B6B0 VA: 0x18172C4B0 Slot: 30
	public virtual void AddRange(ICollection c) { }

	// RVA: 0xBB1750 Offset: 0xBB0950 VA: 0x180BB1750 Slot: 31
	public virtual void Clear() { }

	// RVA: 0x172C5C0 Offset: 0x172B7C0 VA: 0x18172C5C0 Slot: 32
	public virtual object Clone() { }

	// RVA: 0x172C720 Offset: 0x172B920 VA: 0x18172C720 Slot: 33
	public virtual bool Contains(object item) { }

	// RVA: 0x172C9E0 Offset: 0x172BBE0 VA: 0x18172C9E0 Slot: 34
	public virtual void CopyTo(Array array) { }

	// RVA: 0x172C920 Offset: 0x172BB20 VA: 0x18172C920 Slot: 35
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x172C7F0 Offset: 0x172B9F0 VA: 0x18172C7F0 Slot: 36
	public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x172CA00 Offset: 0x172BC00 VA: 0x18172CA00
	private void EnsureCapacity(int min) { }

	// RVA: 0x172CA60 Offset: 0x172BC60 VA: 0x18172CA60 Slot: 37
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x172CB80 Offset: 0x172BD80 VA: 0x18172CB80 Slot: 38
	public virtual int IndexOf(object value) { }

	// RVA: 0x172CD90 Offset: 0x172BF90 VA: 0x18172CD90 Slot: 39
	public virtual void Insert(int index, object value) { }

	// RVA: 0x172CBB0 Offset: 0x172BDB0 VA: 0x18172CBB0 Slot: 40
	public virtual void InsertRange(int index, ICollection c) { }

	// RVA: 0x172CEE0 Offset: 0x172C0E0 VA: 0x18172CEE0
	public static ArrayList ReadOnly(ArrayList list) { }

	// RVA: 0x172D230 Offset: 0x172C430 VA: 0x18172D230 Slot: 41
	public virtual void Remove(object obj) { }

	// RVA: 0x172CFB0 Offset: 0x172C1B0 VA: 0x18172CFB0 Slot: 42
	public virtual void RemoveAt(int index) { }

	// RVA: 0x172D080 Offset: 0x172C280 VA: 0x18172D080 Slot: 43
	public virtual void RemoveRange(int index, int count) { }

	// RVA: 0x172D280 Offset: 0x172C480 VA: 0x18172D280 Slot: 44
	public virtual void Sort(IComparer comparer) { }

	// RVA: 0x172D2E0 Offset: 0x172C4E0 VA: 0x18172D2E0 Slot: 45
	public virtual void Sort(int index, int count, IComparer comparer) { }

	// RVA: 0x172D430 Offset: 0x172C630 VA: 0x18172D430 Slot: 46
	public virtual object[] ToArray() { }

	// RVA: 0x172D4C0 Offset: 0x172C6C0 VA: 0x18172D4C0 Slot: 47
	public virtual Array ToArray(Type type) { }
}

// Namespace: 
private struct Hashtable.bucket // TypeDefIndex: 4394
{
	// Fields
	public object key; // 0x0
	public object val; // 0x8
	public int hash_coll; // 0x10
}

// Namespace: 
[Serializable]
private class Hashtable.KeyCollection : ICollection, IEnumerable // TypeDefIndex: 4395
{
	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x1737D80 Offset: 0x1736F80 VA: 0x181737D80 Slot: 9
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1737FB0 Offset: 0x17371B0 VA: 0x181737FB0 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1738040 Offset: 0x1737240 VA: 0x181738040 Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x8D0650 Offset: 0x8CF850 VA: 0x1808D0650 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20 Slot: 13
	public virtual int get_Count() { }
}

// Namespace: 
[Serializable]
private class Hashtable.ValueCollection : ICollection, IEnumerable // TypeDefIndex: 4396
{
	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x1742260 Offset: 0x1741460 VA: 0x181742260 Slot: 9
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x17424A0 Offset: 0x17416A0 VA: 0x1817424A0 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1738040 Offset: 0x1737240 VA: 0x181738040 Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x8D0650 Offset: 0x8CF850 VA: 0x1808D0650 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20 Slot: 13
	public virtual int get_Count() { }
}

// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class Hashtable.SyncHashtable : Hashtable, IEnumerable // TypeDefIndex: 4397
{
	// Fields
	protected Hashtable _table; // 0x50

	// Properties
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override bool IsFixedSize { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override ICollection Keys { get; }
	public override ICollection Values { get; }

	// Methods

	// RVA: 0x1741DF0 Offset: 0x1740FF0 VA: 0x181741DF0
	internal void .ctor(Hashtable table) { }

	// RVA: 0x1741D90 Offset: 0x1740F90 VA: 0x181741D90
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1741C70 Offset: 0x1740E70 VA: 0x181741C70 Slot: 43
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1741E20 Offset: 0x1741020 VA: 0x181741E20 Slot: 42
	public override int get_Count() { }

	// RVA: 0x1741E80 Offset: 0x1741080 VA: 0x181741E80 Slot: 34
	public override bool get_IsReadOnly() { }

	// RVA: 0x1741E50 Offset: 0x1741050 VA: 0x181741E50 Slot: 35
	public override bool get_IsFixedSize() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 36
	public override bool get_IsSynchronized() { }

	// RVA: 0x1741EB0 Offset: 0x17410B0 VA: 0x181741EB0 Slot: 30
	public override object get_Item(object key) { }

	// RVA: 0x17420F0 Offset: 0x17412F0 VA: 0x1817420F0 Slot: 31
	public override void set_Item(object key, object value) { }

	// RVA: 0x1741FD0 Offset: 0x17411D0 VA: 0x181741FD0 Slot: 41
	public override object get_SyncRoot() { }

	// RVA: 0x17415E0 Offset: 0x17407E0 VA: 0x1817415E0 Slot: 23
	public override void Add(object key, object value) { }

	// RVA: 0x17416D0 Offset: 0x17408D0 VA: 0x1817416D0 Slot: 24
	public override void Clear() { }

	// RVA: 0x1741B20 Offset: 0x1740D20 VA: 0x181741B20 Slot: 26
	public override bool Contains(object key) { }

	// RVA: 0x1741980 Offset: 0x1740B80 VA: 0x181741980 Slot: 27
	public override bool ContainsKey(object key) { }

	// RVA: 0x1741A30 Offset: 0x1740C30 VA: 0x181741A30 Slot: 28
	public override bool ContainsValue(object key) { }

	// RVA: 0x1741B50 Offset: 0x1740D50 VA: 0x181741B50 Slot: 29
	public override void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x17417A0 Offset: 0x17409A0 VA: 0x1817417A0 Slot: 25
	public override object Clone() { }

	// RVA: 0x1741C40 Offset: 0x1740E40 VA: 0x181741C40 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1741C40 Offset: 0x1740E40 VA: 0x181741C40 Slot: 32
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1741EE0 Offset: 0x17410E0 VA: 0x181741EE0 Slot: 38
	public override ICollection get_Keys() { }

	// RVA: 0x1742000 Offset: 0x1741200 VA: 0x181742000 Slot: 39
	public override ICollection get_Values() { }

	// RVA: 0x1741CB0 Offset: 0x1740EB0 VA: 0x181741CB0 Slot: 40
	public override void Remove(object key) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 44
	public override void OnDeserialization(object sender) { }
}

// Namespace: 
[Serializable]
private class Hashtable.HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 4398
{
	// Fields
	private Hashtable _hashtable; // 0x10
	private int _bucket; // 0x18
	private int _version; // 0x1C
	private bool _current; // 0x20
	private int _getObjectRetType; // 0x24
	private object _currentKey; // 0x28
	private object _currentValue; // 0x30

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x1733020 Offset: 0x1732220 VA: 0x181733020
	internal void .ctor(Hashtable hashtable, int getObjRetType) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 10
	public object Clone() { }

	// RVA: 0x17331D0 Offset: 0x17323D0 VA: 0x1817331D0 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x1732E50 Offset: 0x1732050 VA: 0x181732E50 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x1733150 Offset: 0x1732350 VA: 0x181733150 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x1733080 Offset: 0x1732280 VA: 0x181733080 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x1733240 Offset: 0x1732440 VA: 0x181733240 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x1732F70 Offset: 0x1732170 VA: 0x181732F70 Slot: 16
	public virtual void Reset() { }
}

// Namespace: 
internal class Hashtable.HashtableDebugView // TypeDefIndex: 4399
{}

// Namespace: System.Collections
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(Hashtable.HashtableDebugView))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 4400
{
	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] _buckets; // 0x10
	private int _count; // 0x18
	private int _occupancy; // 0x1C
	private int _loadsize; // 0x20
	private float _loadFactor; // 0x24
	private int _version; // 0x28
	private bool _isWriterInProgress; // 0x2C
	private ICollection _keys; // 0x30
	private ICollection _values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48
	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable; // 0x0

	// Properties
	private static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }
	public virtual object Item { get; set; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsSynchronized { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x1736250 Offset: 0x1735450 VA: 0x181736250
	private static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor(bool trash) { }

	// RVA: 0x1735C10 Offset: 0x1734E10 VA: 0x181735C10
	public void .ctor() { }

	// RVA: 0x1735B20 Offset: 0x1734D20 VA: 0x181735B20
	public void .ctor(int capacity) { }

	// RVA: 0x1735C90 Offset: 0x1734E90 VA: 0x181735C90
	public void .ctor(int capacity, float loadFactor) { }

	// RVA: 0x1735C30 Offset: 0x1734E30 VA: 0x181735C30
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
	// RVA: 0x17356D0 Offset: 0x17348D0 VA: 0x1817356D0
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1735690 Offset: 0x1734890 VA: 0x181735690
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1735C60 Offset: 0x1734E60 VA: 0x181735C60
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1735B30 Offset: 0x1734D30 VA: 0x181735B30
	public void .ctor(IDictionary d) { }

	// RVA: 0x1735F10 Offset: 0x1735110 VA: 0x181735F10
	public void .ctor(IDictionary d, float loadFactor) { }

	// RVA: 0x1735A50 Offset: 0x1734C50 VA: 0x181735A50
	public void .ctor(IDictionary d, IEqualityComparer equalityComparer) { }

	[Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
	// RVA: 0x1735A80 Offset: 0x1734C80 VA: 0x181735A80
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1735770 Offset: 0x1734970 VA: 0x181735770
	public void .ctor(IDictionary d, float loadFactor, IEqualityComparer equalityComparer) { }

	// RVA: 0x1735B60 Offset: 0x1734D60 VA: 0x181735B60
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1734300 Offset: 0x1733500 VA: 0x181734300
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x17332B0 Offset: 0x17324B0 VA: 0x1817332B0 Slot: 23
	public virtual void Add(object key, object value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17332D0 Offset: 0x17324D0 VA: 0x1817332D0 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x17333B0 Offset: 0x17325B0 VA: 0x1817333B0 Slot: 25
	public virtual object Clone() { }

	// RVA: 0x1733750 Offset: 0x1732950 VA: 0x181733750 Slot: 26
	public virtual bool Contains(object key) { }

	// RVA: 0x17334D0 Offset: 0x17326D0 VA: 0x1817334D0 Slot: 27
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1733660 Offset: 0x1732860 VA: 0x181733660 Slot: 28
	public virtual bool ContainsValue(object value) { }

	// RVA: 0x1733880 Offset: 0x1732A80 VA: 0x181733880
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x1733770 Offset: 0x1732970 VA: 0x181733770
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x1733920 Offset: 0x1732B20 VA: 0x181733920 Slot: 29
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1733BC0 Offset: 0x1732DC0 VA: 0x181733BC0
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x1735FA0 Offset: 0x17351A0 VA: 0x181735FA0 Slot: 30
	public virtual object get_Item(object key) { }

	// RVA: 0x1736630 Offset: 0x1735830 VA: 0x181736630 Slot: 31
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1735F30 Offset: 0x1735130 VA: 0x181735F30
	private void expand() { }

	// RVA: 0x1736600 Offset: 0x1735800 VA: 0x181736600
	private void rehash() { }

	// RVA: 0x1735660 Offset: 0x1734860 VA: 0x181735660
	private void UpdateVersion() { }

	// RVA: 0x1736490 Offset: 0x1735690 VA: 0x181736490
	private void rehash(int newsize) { }

	// RVA: 0x17355D0 Offset: 0x17347D0 VA: 0x1817355D0 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1733C60 Offset: 0x1732E60 VA: 0x181733C60 Slot: 32
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1733CF0 Offset: 0x1732EF0 VA: 0x181733CF0 Slot: 33
	protected virtual int GetHash(object key) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 34
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 35
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 36
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1734800 Offset: 0x1733A00 VA: 0x181734800 Slot: 37
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x17361E0 Offset: 0x17353E0 VA: 0x1817361E0 Slot: 38
	public virtual ICollection get_Keys() { }

	// RVA: 0x1736310 Offset: 0x1735510 VA: 0x181736310 Slot: 39
	public virtual ICollection get_Values() { }

	// RVA: 0x1734350 Offset: 0x1733550 VA: 0x181734350
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x1736380 Offset: 0x1735580 VA: 0x181736380
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1735290 Offset: 0x1734490 VA: 0x181735290 Slot: 40
	public virtual void Remove(object key) { }

	// RVA: 0x17362A0 Offset: 0x17354A0 VA: 0x1817362A0 Slot: 41
	public virtual object get_SyncRoot() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 42
	public virtual int get_Count() { }

	// RVA: 0x1735520 Offset: 0x1734720 VA: 0x181735520
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x1733D80 Offset: 0x1732F80 VA: 0x181733D80 Slot: 43
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1734940 Offset: 0x1733B40 VA: 0x181734940 Slot: 44
	public virtual void OnDeserialization(object sender) { }
}

// Namespace: System.Collections
[Obsolete("Please use IEqualityComparer instead.")]
public interface IHashCodeProvider // TypeDefIndex: 4401
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetHashCode(object obj);
}

// Namespace: 
[DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
internal struct ConcurrentQueue.Segment.Slot<T> // TypeDefIndex: 4402
{
	// Fields
	public T Item; // 0x0
	public int SequenceNumber; // 0x0
}

// Namespace: 
[DebuggerDisplay("Capacity = {Capacity}")]
internal sealed class ConcurrentQueue.Segment<T> // TypeDefIndex: 4403
{
	// Fields
	internal readonly ConcurrentQueue.Segment.Slot<T>[] _slots; // 0x0
	internal readonly int _slotsMask; // 0x0
	internal PaddedHeadAndTail _headAndTail; // 0x0
	internal bool _preservedForObservation; // 0x0
	internal bool _frozenForEnqueues; // 0x0
	internal ConcurrentQueue.Segment<T> _nextSegment; // 0x0

	// Properties
	internal int Capacity { get; }
	internal int FreezeOffset { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int boundedLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF06A0 Offset: 0xBEF8A0 VA: 0x180BF06A0
	|-ConcurrentQueue.Segment<object>..ctor
	|
	|-RVA: 0xBF05A0 Offset: 0xBEF7A0 VA: 0x180BF05A0
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	|-ConcurrentQueue.Segment<object>.get_Capacity
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	internal int get_FreezeOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0750 Offset: 0xBEF950 VA: 0x180BF0750
	|-ConcurrentQueue.Segment<object>.get_FreezeOffset
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.get_FreezeOffset
	*/

	// RVA: -1 Offset: -1
	internal void EnsureFrozenForEnqueues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF6F0 Offset: 0xBEE8F0 VA: 0x180BEF6F0
	|-ConcurrentQueue.Segment<object>.EnsureFrozenForEnqueues
	|
	|-RVA: 0xBEF7C0 Offset: 0xBEE9C0 VA: 0x180BEF7C0
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.EnsureFrozenForEnqueues
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF8E0 Offset: 0xBEEAE0 VA: 0x180BEF8E0
	|-ConcurrentQueue.Segment<object>.TryDequeue
	|
	|-RVA: 0xBEFAA0 Offset: 0xBEECA0 VA: 0x180BEFAA0
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.TryDequeue
	*/

	// RVA: -1 Offset: -1
	public bool TryPeek(out T result, bool resultUsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0150 Offset: 0xBEF350 VA: 0x180BF0150
	|-ConcurrentQueue.Segment<object>.TryPeek
	|
	|-RVA: 0xBF02C0 Offset: 0xBEF4C0 VA: 0x180BF02C0
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.TryPeek
	*/

	// RVA: -1 Offset: -1
	public bool TryEnqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0000 Offset: 0xBEF200 VA: 0x180BF0000
	|-ConcurrentQueue.Segment<object>.TryEnqueue
	|
	|-RVA: 0xBEFDC0 Offset: 0xBEEFC0 VA: 0x180BEFDC0
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.TryEnqueue
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ConcurrentQueue.<Enumerate>d__28<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 4404
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public ConcurrentQueue.Segment<T> head; // 0x0
	public ConcurrentQueue.Segment<T> tail; // 0x0
	public int tailTail; // 0x0
	public int headHead; // 0x0
	public ConcurrentQueue<T> <>4__this; // 0x0
	private int <headTail>5__2; // 0x0
	private int <i>5__3; // 0x0
	private ConcurrentQueue.Segment<T> <s>5__4; // 0x0
	private int <i>5__5; // 0x0

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
	|-ConcurrentQueue.<Enumerate>d__28<object>..ctor
	|
	|-RVA: 0xB1E9D0 Offset: 0xB1DBD0 VA: 0x180B1E9D0
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.IDisposable.Dispose
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1D5C0 Offset: 0xB1C7C0 VA: 0x180B1D5C0
	|-ConcurrentQueue.<Enumerate>d__28<object>.MoveNext
	|
	|-RVA: 0xB1D920 Offset: 0xB1CB20 VA: 0x180B1D920
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0xB1E870 Offset: 0xB1DA70 VA: 0x180B1E870
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.Collections.IEnumerator.Reset
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB1E920 Offset: 0xB1DB20 VA: 0x180B1E920
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Collections.Concurrent
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<T>))]
[Serializable]
public class ConcurrentQueue<T> : IProducerConsumerCollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 4405
{
	// Fields
	private object _crossSegmentLock; // 0x0
	private ConcurrentQueue.Segment<T> _tail; // 0x0
	private ConcurrentQueue.Segment<T> _head; // 0x0

	// Properties
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public bool IsEmpty { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB3620 Offset: 0xFB2820 VA: 0x180FB3620
	|-ConcurrentQueue<object>..ctor
	|
	|-RVA: 0xFB36F0 Offset: 0xFB28F0 VA: 0x180FB36F0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB27B0 Offset: 0xFB19B0 VA: 0x180FB27B0
	|-ConcurrentQueue<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xFB26B0 Offset: 0xFB18B0 VA: 0x180FB26B0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ConcurrentQueue<object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE79F0 Offset: 0xEE6BF0 VA: 0x180EE79F0
	|-ConcurrentQueue<object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB28B0 Offset: 0xFB1AB0 VA: 0x180FB28B0
	|-ConcurrentQueue<object>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB2550 Offset: 0xFB1750 VA: 0x180FB2550
	|-ConcurrentQueue<object>.System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd
	|
	|-RVA: 0xFB2470 Offset: 0xFB1670 VA: 0x180FB2470
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB2610 Offset: 0xFB1810 VA: 0x180FB2610
	|-ConcurrentQueue<object>.System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake
	|
	|-RVA: 0xFB25F0 Offset: 0xFB17F0 VA: 0x180FB25F0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB3E20 Offset: 0xFB3020 VA: 0x180FB3E20
	|-ConcurrentQueue<object>.get_IsEmpty
	|
	|-RVA: 0xFB3E50 Offset: 0xFB3050 VA: 0x180FB3E50
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB2C70 Offset: 0xFB1E70 VA: 0x180FB2C70
	|-ConcurrentQueue<object>.ToArray
	|
	|-RVA: 0xFB2900 Offset: 0xFB1B00 VA: 0x180FB2900
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB3B20 Offset: 0xFB2D20 VA: 0x180FB3B20
	|-ConcurrentQueue<object>.get_Count
	|
	|-RVA: 0xFB37C0 Offset: 0xFB29C0 VA: 0x180FB37C0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private static int GetCount(ConcurrentQueue.Segment<T> s, int head, int tail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB1B20 Offset: 0xFB0D20 VA: 0x180FB1B20
	|-ConcurrentQueue<object>.GetCount
	|
	|-RVA: 0xFB1860 Offset: 0xFB0A60 VA: 0x180FB1860
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetCount
	*/

	// RVA: -1 Offset: -1
	private static long GetCount(ConcurrentQueue.Segment<T> head, int headHead, ConcurrentQueue.Segment<T> tail, int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB1BD0 Offset: 0xFB0DD0 VA: 0x180FB1BD0
	|-ConcurrentQueue<object>.GetCount
	|
	|-RVA: 0xFB1940 Offset: 0xFB0B40 VA: 0x180FB1940
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetCount
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB0AE0 Offset: 0xFAFCE0 VA: 0x180FB0AE0
	|-ConcurrentQueue<object>.CopyTo
	|
	|-RVA: 0xFB0760 Offset: 0xFAF960 VA: 0x180FB0760
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB1DE0 Offset: 0xFB0FE0 VA: 0x180FB1DE0
	|-ConcurrentQueue<object>.GetEnumerator
	|
	|-RVA: 0xFB1D50 Offset: 0xFB0F50 VA: 0x180FB1D50
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void SnapForObservation(out ConcurrentQueue.Segment<T> head, out int headHead, out ConcurrentQueue.Segment<T> tail, out int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB2300 Offset: 0xFB1500 VA: 0x180FB2300
	|-ConcurrentQueue<object>.SnapForObservation
	|
	|-RVA: 0xFB2190 Offset: 0xFB1390 VA: 0x180FB2190
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.SnapForObservation
	*/

	// RVA: -1 Offset: -1
	private T GetItemWhenAvailable(ConcurrentQueue.Segment<T> segment, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB2090 Offset: 0xFB1290 VA: 0x180FB2090
	|-ConcurrentQueue<object>.GetItemWhenAvailable
	|
	|-RVA: 0xFB1E80 Offset: 0xFB1080 VA: 0x180FB1E80
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetItemWhenAvailable
	*/

	[IteratorStateMachine(typeof(ConcurrentQueue.<Enumerate>d__28<T>))]
	// RVA: -1 Offset: -1
	private IEnumerator<T> Enumerate(ConcurrentQueue.Segment<T> head, int headHead, ConcurrentQueue.Segment<T> tail, int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB17B0 Offset: 0xFB09B0 VA: 0x180FB17B0
	|-ConcurrentQueue<object>.Enumerate
	|
	|-RVA: 0xFB15E0 Offset: 0xFB07E0 VA: 0x180FB15E0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.Enumerate
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB1550 Offset: 0xFB0750 VA: 0x180FB1550
	|-ConcurrentQueue<object>.Enqueue
	|
	|-RVA: 0xFB13E0 Offset: 0xFB05E0 VA: 0x180FB13E0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	private void EnqueueSlow(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB0F30 Offset: 0xFB0130 VA: 0x180FB0F30
	|-ConcurrentQueue<object>.EnqueueSlow
	|
	|-RVA: 0xFB1130 Offset: 0xFB0330 VA: 0x180FB1130
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.EnqueueSlow
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB3320 Offset: 0xFB2520 VA: 0x180FB3320
	|-ConcurrentQueue<object>.TryDequeue
	|
	|-RVA: 0xFB33B0 Offset: 0xFB25B0 VA: 0x180FB33B0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.TryDequeue
	*/

	// RVA: -1 Offset: -1
	private bool TryDequeueSlow(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB3070 Offset: 0xFB2270 VA: 0x180FB3070
	|-ConcurrentQueue<object>.TryDequeueSlow
	|
	|-RVA: 0xFB31B0 Offset: 0xFB23B0 VA: 0x180FB31B0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.TryDequeueSlow
	*/

	// RVA: -1 Offset: -1
	public bool TryPeek(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB3520 Offset: 0xFB2720 VA: 0x180FB3520
	|-ConcurrentQueue<object>.TryPeek
	|
	|-RVA: 0xFB3600 Offset: 0xFB2800 VA: 0x180FB3600
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.TryPeek
	*/

	// RVA: -1 Offset: -1
	private bool TryPeek(out T result, bool resultUsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB3540 Offset: 0xFB2740 VA: 0x180FB3540
	|-ConcurrentQueue<object>.TryPeek
	|
	|-RVA: 0xFB3440 Offset: 0xFB2640 VA: 0x180FB3440
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.TryPeek
	*/
}

// Namespace: System.Collections.Concurrent
[DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
internal struct PaddedHeadAndTail // TypeDefIndex: 4406
{
	// Fields
	public int Head; // 0x80
	public int Tail; // 0x100
}

// Namespace: System.Collections.Concurrent
[EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
internal sealed class CDSCollectionETWBCLProvider : EventSource // TypeDefIndex: 4407
{
	// Fields
	public static CDSCollectionETWBCLProvider Log; // 0x0

	// Methods

	// RVA: 0x172F990 Offset: 0x172EB90 VA: 0x18172F990
	private void .ctor() { }

	[Event(1, Level = 3)]
	// RVA: 0x172F8E0 Offset: 0x172EAE0 VA: 0x18172F8E0
	public void ConcurrentStack_FastPushFailed(int spinCount) { }

	[Event(2, Level = 3)]
	// RVA: 0x172F890 Offset: 0x172EA90 VA: 0x18172F890
	public void ConcurrentStack_FastPopFailed(int spinCount) { }

	[Event(3, Level = 3)]
	// RVA: 0x172F840 Offset: 0x172EA40 VA: 0x18172F840
	public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets) { }

	// RVA: 0x172F930 Offset: 0x172EB30 VA: 0x18172F930
	private static void .cctor() { }
}

// Namespace: 
private sealed class ConcurrentDictionary.Tables<TKey, TValue> // TypeDefIndex: 4408
{
	// Fields
	internal readonly ConcurrentDictionary.Node<TKey, TValue>[] _buckets; // 0x0
	internal readonly object[] _locks; // 0x0
	internal int[] _countPerLock; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary.Node<TKey, TValue>[] buckets, object[] locks, int[] countPerLock) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4C5E0 Offset: 0xC4B7E0 VA: 0x180C4C5E0
	|-ConcurrentDictionary.Tables<StructMultiKey<object, object>, object>..ctor
	|-ConcurrentDictionary.Tables<DiscardReasonWithCategory, object>..ctor
	|-ConcurrentDictionary.Tables<object, bool>..ctor
	|-ConcurrentDictionary.Tables<object, DateTimeOffset>..ctor
	|-ConcurrentDictionary.Tables<object, object>..ctor
	|-ConcurrentDictionary.Tables<ushort, object>..ctor
	|-ConcurrentDictionary.Tables<ulong, JsonEncodedText>..ctor
	|-ConcurrentDictionary.Tables<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[Serializable]
private sealed class ConcurrentDictionary.Node<TKey, TValue> // TypeDefIndex: 4409
{
	// Fields
	internal readonly TKey _key; // 0x0
	internal TValue _value; // 0x0
	internal ConcurrentDictionary.Node<TKey, TValue> _next; // 0x0
	internal readonly int _hashcode; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TKey key, TValue value, int hashcode, ConcurrentDictionary.Node<TKey, TValue> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489AB0 Offset: 0x1488CB0 VA: 0x181489AB0
	|-ConcurrentDictionary.Node<StructMultiKey<object, object>, object>..ctor
	|-ConcurrentDictionary.Node<DiscardReasonWithCategory, object>..ctor
	|
	|-RVA: 0x1489870 Offset: 0x1488A70 VA: 0x181489870
	|-ConcurrentDictionary.Node<object, bool>..ctor
	|
	|-RVA: 0x14897F0 Offset: 0x14889F0 VA: 0x1814897F0
	|-ConcurrentDictionary.Node<object, DateTimeOffset>..ctor
	|-ConcurrentDictionary.Node<ulong, JsonEncodedText>..ctor
	|
	|-RVA: 0x14898D0 Offset: 0x1488AD0 VA: 0x1814898D0
	|-ConcurrentDictionary.Node<object, object>..ctor
	|
	|-RVA: 0x148BCF0 Offset: 0x148AEF0 VA: 0x18148BCF0
	|-ConcurrentDictionary.Node<ushort, object>..ctor
	|
	|-RVA: 0x148BD50 Offset: 0x148AF50 VA: 0x18148BD50
	|-ConcurrentDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[Serializable]
private sealed class ConcurrentDictionary.DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 4410
{
	// Fields
	private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCA150 Offset: 0xFC9350 VA: 0x180FCA150
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>..ctor
	|-ConcurrentDictionary.DictionaryEnumerator<DiscardReasonWithCategory, object>..ctor
	|-ConcurrentDictionary.DictionaryEnumerator<object, DateTimeOffset>..ctor
	|-ConcurrentDictionary.DictionaryEnumerator<ulong, JsonEncodedText>..ctor
	|
	|-RVA: 0xFCA0F0 Offset: 0xFC92F0 VA: 0x180FCA0F0
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>..ctor
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>..ctor
	|-ConcurrentDictionary.DictionaryEnumerator<ushort, object>..ctor
	|
	|-RVA: 0xFCA220 Offset: 0xFC9420 VA: 0x180FCA220
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCB500 Offset: 0xFCA700 VA: 0x180FCB500
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Entry
	|-ConcurrentDictionary.DictionaryEnumerator<DiscardReasonWithCategory, object>.get_Entry
	|
	|-RVA: 0xFCBB10 Offset: 0xFCAD10 VA: 0x180FCBB10
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.get_Entry
	|
	|-RVA: 0xFCB9F0 Offset: 0xFCABF0 VA: 0x180FCB9F0
	|-ConcurrentDictionary.DictionaryEnumerator<object, DateTimeOffset>.get_Entry
	|
	|-RVA: 0xFCB0E0 Offset: 0xFCA2E0 VA: 0x180FCB0E0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Entry
	|
	|-RVA: 0xFCB820 Offset: 0xFCAA20 VA: 0x180FCB820
	|-ConcurrentDictionary.DictionaryEnumerator<ushort, object>.get_Entry
	|
	|-RVA: 0xFCBCD0 Offset: 0xFCAED0 VA: 0x180FCBCD0
	|-ConcurrentDictionary.DictionaryEnumerator<ulong, JsonEncodedText>.get_Entry
	|
	|-RVA: 0xFCB290 Offset: 0xFCA490 VA: 0x180FCB290
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCC1B0 Offset: 0xFCB3B0 VA: 0x180FCC1B0
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Key
	|-ConcurrentDictionary.DictionaryEnumerator<DiscardReasonWithCategory, object>.get_Key
	|
	|-RVA: 0xFCC370 Offset: 0xFCB570 VA: 0x180FCC370
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.get_Key
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Key
	|
	|-RVA: 0xFCC700 Offset: 0xFCB900 VA: 0x180FCC700
	|-ConcurrentDictionary.DictionaryEnumerator<object, DateTimeOffset>.get_Key
	|
	|-RVA: 0xFCC750 Offset: 0xFCB950 VA: 0x180FCC750
	|-ConcurrentDictionary.DictionaryEnumerator<ushort, object>.get_Key
	|
	|-RVA: 0xFCC2F0 Offset: 0xFCB4F0 VA: 0x180FCC2F0
	|-ConcurrentDictionary.DictionaryEnumerator<ulong, JsonEncodedText>.get_Key
	|
	|-RVA: 0xFCC050 Offset: 0xFCB250 VA: 0x180FCC050
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCC830 Offset: 0xFCBA30 VA: 0x180FCC830
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Value
	|-ConcurrentDictionary.DictionaryEnumerator<DiscardReasonWithCategory, object>.get_Value
	|
	|-RVA: 0xFCCF40 Offset: 0xFCC140 VA: 0x180FCCF40
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.get_Value
	|
	|-RVA: 0xFCCA70 Offset: 0xFCBC70 VA: 0x180FCCA70
	|-ConcurrentDictionary.DictionaryEnumerator<object, DateTimeOffset>.get_Value
	|-ConcurrentDictionary.DictionaryEnumerator<ulong, JsonEncodedText>.get_Value
	|
	|-RVA: 0xFCCB00 Offset: 0xFCBD00 VA: 0x180FCCB00
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Value
	|-ConcurrentDictionary.DictionaryEnumerator<ushort, object>.get_Value
	|
	|-RVA: 0xFCCBB0 Offset: 0xFCBDB0 VA: 0x180FCCBB0
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCA450 Offset: 0xFC9650 VA: 0x180FCA450
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Current
	|
	|-RVA: 0xFCA9B0 Offset: 0xFC9BB0 VA: 0x180FCA9B0
	|-ConcurrentDictionary.DictionaryEnumerator<DiscardReasonWithCategory, object>.get_Current
	|
	|-RVA: 0xFCAB00 Offset: 0xFC9D00 VA: 0x180FCAB00
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.get_Current
	|
	|-RVA: 0xFCA2F0 Offset: 0xFC94F0 VA: 0x180FCA2F0
	|-ConcurrentDictionary.DictionaryEnumerator<object, DateTimeOffset>.get_Current
	|
	|-RVA: 0xFCA6D0 Offset: 0xFC98D0 VA: 0x180FCA6D0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Current
	|
	|-RVA: 0xFCA280 Offset: 0xFC9480 VA: 0x180FCA280
	|-ConcurrentDictionary.DictionaryEnumerator<ushort, object>.get_Current
	|
	|-RVA: 0xFCA830 Offset: 0xFC9A30 VA: 0x180FCA830
	|-ConcurrentDictionary.DictionaryEnumerator<ulong, JsonEncodedText>.get_Current
	|
	|-RVA: 0xFCA740 Offset: 0xFC9940 VA: 0x180FCA740
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC9B50 Offset: 0xFC8D50 VA: 0x180FC9B50
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.MoveNext
	|
	|-RVA: 0xFC9A60 Offset: 0xFC8C60 VA: 0x180FC9A60
	|-ConcurrentDictionary.DictionaryEnumerator<DiscardReasonWithCategory, object>.MoveNext
	|
	|-RVA: 0xFC99C0 Offset: 0xFC8BC0 VA: 0x180FC99C0
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.MoveNext
	|
	|-RVA: 0xFC9AB0 Offset: 0xFC8CB0 VA: 0x180FC9AB0
	|-ConcurrentDictionary.DictionaryEnumerator<object, DateTimeOffset>.MoveNext
	|
	|-RVA: 0xFC9BA0 Offset: 0xFC8DA0 VA: 0x180FC9BA0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.MoveNext
	|
	|-RVA: 0xFC9A10 Offset: 0xFC8C10 VA: 0x180FC9A10
	|-ConcurrentDictionary.DictionaryEnumerator<ushort, object>.MoveNext
	|
	|-RVA: 0xFC9B00 Offset: 0xFC8D00 VA: 0x180FC9B00
	|-ConcurrentDictionary.DictionaryEnumerator<ulong, JsonEncodedText>.MoveNext
	|
	|-RVA: 0xFC9C40 Offset: 0xFC8E40 VA: 0x180FC9C40
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC9DD0 Offset: 0xFC8FD0 VA: 0x180FC9DD0
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.Reset
	|
	|-RVA: 0xFC9F60 Offset: 0xFC9160 VA: 0x180FC9F60
	|-ConcurrentDictionary.DictionaryEnumerator<DiscardReasonWithCategory, object>.Reset
	|
	|-RVA: 0xFC9F10 Offset: 0xFC9110 VA: 0x180FC9F10
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.Reset
	|
	|-RVA: 0xFC9FB0 Offset: 0xFC91B0 VA: 0x180FC9FB0
	|-ConcurrentDictionary.DictionaryEnumerator<object, DateTimeOffset>.Reset
	|
	|-RVA: 0xFCA050 Offset: 0xFC9250 VA: 0x180FCA050
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.Reset
	|
	|-RVA: 0xFC9D80 Offset: 0xFC8F80 VA: 0x180FC9D80
	|-ConcurrentDictionary.DictionaryEnumerator<ushort, object>.Reset
	|
	|-RVA: 0xFC9E20 Offset: 0xFC9020 VA: 0x180FC9E20
	|-ConcurrentDictionary.DictionaryEnumerator<ulong, JsonEncodedText>.Reset
	|
	|-RVA: 0xFCA0A0 Offset: 0xFC92A0 VA: 0x180FCA0A0
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ConcurrentDictionary.<GetEnumerator>d__35<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 4411
{
	// Fields
	private int <>1__state; // 0x0
	private KeyValuePair<TKey, TValue> <>2__current; // 0x0
	public ConcurrentDictionary<TKey, TValue> <>4__this; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue>[] <buckets>5__2; // 0x0
	private int <i>5__3; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue> <current>5__4; // 0x0

	// Properties
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>..ctor
	|-ConcurrentDictionary.<GetEnumerator>d__35<DiscardReasonWithCategory, object>..ctor
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>..ctor
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, DateTimeOffset>..ctor
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>..ctor
	|-ConcurrentDictionary.<GetEnumerator>d__35<ushort, object>..ctor
	|-ConcurrentDictionary.<GetEnumerator>d__35<ulong, JsonEncodedText>..ctor
	|
	|-RVA: 0xB1E9D0 Offset: 0xB1DBD0 VA: 0x180B1E9D0
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.IDisposable.Dispose
	|-ConcurrentDictionary.<GetEnumerator>d__35<DiscardReasonWithCategory, object>.System.IDisposable.Dispose
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>.System.IDisposable.Dispose
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, DateTimeOffset>.System.IDisposable.Dispose
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.IDisposable.Dispose
	|-ConcurrentDictionary.<GetEnumerator>d__35<ushort, object>.System.IDisposable.Dispose
	|-ConcurrentDictionary.<GetEnumerator>d__35<ulong, JsonEncodedText>.System.IDisposable.Dispose
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB22A40 Offset: 0xB21C40 VA: 0x180B22A40
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.MoveNext
	|-ConcurrentDictionary.<GetEnumerator>d__35<DiscardReasonWithCategory, object>.MoveNext
	|
	|-RVA: 0xB23460 Offset: 0xB22660 VA: 0x180B23460
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>.MoveNext
	|
	|-RVA: 0xB23310 Offset: 0xB22510 VA: 0x180B23310
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, DateTimeOffset>.MoveNext
	|-ConcurrentDictionary.<GetEnumerator>d__35<ulong, JsonEncodedText>.MoveNext
	|
	|-RVA: 0xB231E0 Offset: 0xB223E0 VA: 0x180B231E0
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.MoveNext
	|
	|-RVA: 0xB23590 Offset: 0xB22790 VA: 0x180B23590
	|-ConcurrentDictionary.<GetEnumerator>d__35<ushort, object>.MoveNext
	|
	|-RVA: 0xB22B90 Offset: 0xB21D90 VA: 0x180B22B90
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|-ConcurrentDictionary.<GetEnumerator>d__35<DiscardReasonWithCategory, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, DateTimeOffset>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|-ConcurrentDictionary.<GetEnumerator>d__35<ulong, JsonEncodedText>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|-ConcurrentDictionary.<GetEnumerator>d__35<ushort, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0xB236C0 Offset: 0xB228C0 VA: 0x180B236C0
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.IEnumerator.Reset
	|-ConcurrentDictionary.<GetEnumerator>d__35<DiscardReasonWithCategory, object>.System.Collections.IEnumerator.Reset
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>.System.Collections.IEnumerator.Reset
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, DateTimeOffset>.System.Collections.IEnumerator.Reset
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.IEnumerator.Reset
	|-ConcurrentDictionary.<GetEnumerator>d__35<ushort, object>.System.Collections.IEnumerator.Reset
	|-ConcurrentDictionary.<GetEnumerator>d__35<ulong, JsonEncodedText>.System.Collections.IEnumerator.Reset
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB23850 Offset: 0xB22A50 VA: 0x180B23850
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.IEnumerator.get_Current
	|-ConcurrentDictionary.<GetEnumerator>d__35<DiscardReasonWithCategory, object>.System.Collections.IEnumerator.get_Current
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, DateTimeOffset>.System.Collections.IEnumerator.get_Current
	|-ConcurrentDictionary.<GetEnumerator>d__35<ulong, JsonEncodedText>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB23770 Offset: 0xB22970 VA: 0x180B23770
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>.System.Collections.IEnumerator.get_Current
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.IEnumerator.get_Current
	|-ConcurrentDictionary.<GetEnumerator>d__35<ushort, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB237A0 Offset: 0xB229A0 VA: 0x180B237A0
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Collections.Concurrent
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView<K, V>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 4412
{
	// Fields
	private ConcurrentDictionary.Tables<TKey, TValue> _tables; // 0x0
	private IEqualityComparer<TKey> _comparer; // 0x0
	private readonly bool _growLockArray; // 0x0
	private int _budget; // 0x0
	private KeyValuePair<TKey, TValue>[] _serializationArray; // 0x0
	private int _serializationConcurrencyLevel; // 0x0
	private int _serializationCapacity; // 0x0
	private const int DefaultCapacity = 31;
	private const int MaxLockNumber = 1024;
	private static readonly bool s_isValueWriteAtomic; // 0x0

	// Properties
	public TValue Item { get; set; }
	public int Count { get; }
	public bool IsEmpty { get; }
	public ICollection<TKey> Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public ICollection<TValue> Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private static int DefaultConcurrencyLevel { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static bool IsValueWriteAtomic() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF86CA0 Offset: 0xF85EA0 VA: 0x180F86CA0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.IsValueWriteAtomic
	|
	|-RVA: 0xF86DB0 Offset: 0xF85FB0 VA: 0x180F86DB0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.IsValueWriteAtomic
	|
	|-RVA: 0xF86B90 Offset: 0xF85D90 VA: 0x180F86B90
	|-ConcurrentDictionary<object, bool>.IsValueWriteAtomic
	|
	|-RVA: 0xF9C6A0 Offset: 0xF9B8A0 VA: 0x180F9C6A0
	|-ConcurrentDictionary<object, DateTimeOffset>.IsValueWriteAtomic
	|
	|-RVA: 0xF9C7B0 Offset: 0xF9B9B0 VA: 0x180F9C7B0
	|-ConcurrentDictionary<object, object>.IsValueWriteAtomic
	|
	|-RVA: 0xF9C8C0 Offset: 0xF9BAC0 VA: 0x180F9C8C0
	|-ConcurrentDictionary<ushort, object>.IsValueWriteAtomic
	|
	|-RVA: 0xF9C9D0 Offset: 0xF9BBD0 VA: 0x180F9C9D0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.IsValueWriteAtomic
	|
	|-RVA: 0xF9C590 Offset: 0xF9B790 VA: 0x180F9C590
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsValueWriteAtomic
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8FAB0 Offset: 0xF8ECB0 VA: 0x180F8FAB0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0xF8F9C0 Offset: 0xF8EBC0 VA: 0x180F8F9C0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>..ctor
	|
	|-RVA: 0xF8F810 Offset: 0xF8EA10 VA: 0x180F8F810
	|-ConcurrentDictionary<object, bool>..ctor
	|
	|-RVA: 0xFAD620 Offset: 0xFAC820 VA: 0x180FAD620
	|-ConcurrentDictionary<object, DateTimeOffset>..ctor
	|
	|-RVA: 0xFAD100 Offset: 0xFAC300 VA: 0x180FAD100
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0xFAE550 Offset: 0xFAD750 VA: 0x180FAE550
	|-ConcurrentDictionary<ushort, object>..ctor
	|
	|-RVA: 0xFAE610 Offset: 0xFAD810 VA: 0x180FAE610
	|-ConcurrentDictionary<ulong, JsonEncodedText>..ctor
	|
	|-RVA: 0xFAE020 Offset: 0xFAD220 VA: 0x180FAE020
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int concurrencyLevel, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8FA80 Offset: 0xF8EC80 VA: 0x180F8FA80
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0xF8F8D0 Offset: 0xF8EAD0 VA: 0x180F8F8D0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>..ctor
	|
	|-RVA: 0xF8F170 Offset: 0xF8E370 VA: 0x180F8F170
	|-ConcurrentDictionary<object, bool>..ctor
	|
	|-RVA: 0xFAE7F0 Offset: 0xFAD9F0 VA: 0x180FAE7F0
	|-ConcurrentDictionary<object, DateTimeOffset>..ctor
	|
	|-RVA: 0xFAE6D0 Offset: 0xFAD8D0 VA: 0x180FAE6D0
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0xFAD1C0 Offset: 0xFAC3C0 VA: 0x180FAD1C0
	|-ConcurrentDictionary<ushort, object>..ctor
	|
	|-RVA: 0xFAE7C0 Offset: 0xFAD9C0 VA: 0x180FAE7C0
	|-ConcurrentDictionary<ulong, JsonEncodedText>..ctor
	|
	|-RVA: 0xFAE460 Offset: 0xFAD660 VA: 0x180FAE460
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8FFD0 Offset: 0xF8F1D0 VA: 0x180F8FFD0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0xF8F900 Offset: 0xF8EB00 VA: 0x180F8F900
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>..ctor
	|
	|-RVA: 0xF8FF10 Offset: 0xF8F110 VA: 0x180F8FF10
	|-ConcurrentDictionary<object, bool>..ctor
	|
	|-RVA: 0xFAE820 Offset: 0xFADA20 VA: 0x180FAE820
	|-ConcurrentDictionary<object, DateTimeOffset>..ctor
	|
	|-RVA: 0xFAD560 Offset: 0xFAC760 VA: 0x180FAD560
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0xFAE700 Offset: 0xFAD900 VA: 0x180FAE700
	|-ConcurrentDictionary<ushort, object>..ctor
	|
	|-RVA: 0xFAE490 Offset: 0xFAD690 VA: 0x180FAE490
	|-ConcurrentDictionary<ulong, JsonEncodedText>..ctor
	|
	|-RVA: 0xFAD4C0 Offset: 0xFAC6C0 VA: 0x180FAD4C0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF861D0 Offset: 0xF853D0 VA: 0x180F861D0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.InitializeFromCollection
	|
	|-RVA: 0xF86860 Offset: 0xF85A60 VA: 0x180F86860
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.InitializeFromCollection
	|
	|-RVA: 0xF86500 Offset: 0xF85700 VA: 0x180F86500
	|-ConcurrentDictionary<object, bool>.InitializeFromCollection
	|
	|-RVA: 0xF9B610 Offset: 0xF9A810 VA: 0x180F9B610
	|-ConcurrentDictionary<object, DateTimeOffset>.InitializeFromCollection
	|
	|-RVA: 0xF9B980 Offset: 0xF9AB80 VA: 0x180F9B980
	|-ConcurrentDictionary<object, object>.InitializeFromCollection
	|
	|-RVA: 0xF9B2F0 Offset: 0xF9A4F0 VA: 0x180F9B2F0
	|-ConcurrentDictionary<ushort, object>.InitializeFromCollection
	|
	|-RVA: 0xF9C260 Offset: 0xF9B460 VA: 0x180F9C260
	|-ConcurrentDictionary<ulong, JsonEncodedText>.InitializeFromCollection
	|
	|-RVA: 0xF9BCC0 Offset: 0xF9AEC0 VA: 0x180F9BCC0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InitializeFromCollection
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8FB70 Offset: 0xF8ED70 VA: 0x180F8FB70
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0xF8F1A0 Offset: 0xF8E3A0 VA: 0x180F8F1A0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>..ctor
	|
	|-RVA: 0xF8F540 Offset: 0xF8E740 VA: 0x180F8F540
	|-ConcurrentDictionary<object, bool>..ctor
	|
	|-RVA: 0xFAD1F0 Offset: 0xFAC3F0 VA: 0x180FAD1F0
	|-ConcurrentDictionary<object, DateTimeOffset>..ctor
	|
	|-RVA: 0xFAD9B0 Offset: 0xFACBB0 VA: 0x180FAD9B0
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0xFADC80 Offset: 0xFACE80 VA: 0x180FADC80
	|-ConcurrentDictionary<ushort, object>..ctor
	|
	|-RVA: 0xFAE0C0 Offset: 0xFAD2C0 VA: 0x180FAE0C0
	|-ConcurrentDictionary<ulong, JsonEncodedText>..ctor
	|
	|-RVA: 0xFAD6E0 Offset: 0xFAC8E0 VA: 0x180FAD6E0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8D130 Offset: 0xF8C330 VA: 0x180F8D130
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryAdd
	|
	|-RVA: 0xF8D280 Offset: 0xF8C480 VA: 0x180F8D280
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.TryAdd
	|
	|-RVA: 0xF8D3D0 Offset: 0xF8C5D0 VA: 0x180F8D3D0
	|-ConcurrentDictionary<object, bool>.TryAdd
	|
	|-RVA: 0xFA7FB0 Offset: 0xFA71B0 VA: 0x180FA7FB0
	|-ConcurrentDictionary<object, DateTimeOffset>.TryAdd
	|
	|-RVA: 0xFA80D0 Offset: 0xFA72D0 VA: 0x180FA80D0
	|-ConcurrentDictionary<object, object>.TryAdd
	|
	|-RVA: 0xFA8510 Offset: 0xFA7710 VA: 0x180FA8510
	|-ConcurrentDictionary<ushort, object>.TryAdd
	|
	|-RVA: 0xFA85D0 Offset: 0xFA77D0 VA: 0x180FA85D0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.TryAdd
	|
	|-RVA: 0xFA81D0 Offset: 0xFA73D0 VA: 0x180FA81D0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF82290 Offset: 0xF81490 VA: 0x180F82290
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ContainsKey
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.ContainsKey
	|
	|-RVA: 0xF822D0 Offset: 0xF814D0 VA: 0x180F822D0
	|-ConcurrentDictionary<object, bool>.ContainsKey
	|
	|-RVA: 0xF93D30 Offset: 0xF92F30 VA: 0x180F93D30
	|-ConcurrentDictionary<object, DateTimeOffset>.ContainsKey
	|
	|-RVA: 0xF93B70 Offset: 0xF92D70 VA: 0x180F93B70
	|-ConcurrentDictionary<object, object>.ContainsKey
	|
	|-RVA: 0xF938F0 Offset: 0xF92AF0 VA: 0x180F938F0
	|-ConcurrentDictionary<ushort, object>.ContainsKey
	|
	|-RVA: 0xF93C70 Offset: 0xF92E70 VA: 0x180F93C70
	|-ConcurrentDictionary<ulong, JsonEncodedText>.ContainsKey
	|
	|-RVA: 0xF939B0 Offset: 0xF92BB0 VA: 0x180F939B0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool TryRemove(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8E320 Offset: 0xF8D520 VA: 0x180F8E320
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryRemove
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.TryRemove
	|
	|-RVA: 0xF8E360 Offset: 0xF8D560 VA: 0x180F8E360
	|-ConcurrentDictionary<object, bool>.TryRemove
	|
	|-RVA: 0xFAAF00 Offset: 0xFAA100 VA: 0x180FAAF00
	|-ConcurrentDictionary<object, DateTimeOffset>.TryRemove
	|
	|-RVA: 0xFAAC00 Offset: 0xFA9E00 VA: 0x180FAAC00
	|-ConcurrentDictionary<object, object>.TryRemove
	|
	|-RVA: 0xFAAC80 Offset: 0xFA9E80 VA: 0x180FAAC80
	|-ConcurrentDictionary<ushort, object>.TryRemove
	|
	|-RVA: 0xFAABC0 Offset: 0xFA9DC0 VA: 0x180FAABC0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.TryRemove
	|
	|-RVA: 0xFAACC0 Offset: 0xFA9EC0 VA: 0x180FAACC0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRemove
	*/

	// RVA: -1 Offset: -1
	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8DA30 Offset: 0xF8CC30 VA: 0x180F8DA30
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryRemoveInternal
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.TryRemoveInternal
	|
	|-RVA: 0xF8DF30 Offset: 0xF8D130 VA: 0x180F8DF30
	|-ConcurrentDictionary<object, bool>.TryRemoveInternal
	|
	|-RVA: 0xFA93E0 Offset: 0xFA85E0 VA: 0x180FA93E0
	|-ConcurrentDictionary<object, DateTimeOffset>.TryRemoveInternal
	|
	|-RVA: 0xFAA7D0 Offset: 0xFA99D0 VA: 0x180FAA7D0
	|-ConcurrentDictionary<object, object>.TryRemoveInternal
	|
	|-RVA: 0xFA9800 Offset: 0xFA8A00 VA: 0x180FA9800
	|-ConcurrentDictionary<ushort, object>.TryRemoveInternal
	|
	|-RVA: 0xFAA3B0 Offset: 0xFA95B0 VA: 0x180FAA3B0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.TryRemoveInternal
	|
	|-RVA: 0xFA9C00 Offset: 0xFA8E00 VA: 0x180FA9C00
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRemoveInternal
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8D800 Offset: 0xF8CA00 VA: 0x180F8D800
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryGetValue
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.TryGetValue
	|
	|-RVA: 0xF8D930 Offset: 0xF8CB30 VA: 0x180F8D930
	|-ConcurrentDictionary<object, bool>.TryGetValue
	|
	|-RVA: 0xFA9080 Offset: 0xFA8280 VA: 0x180FA9080
	|-ConcurrentDictionary<object, DateTimeOffset>.TryGetValue
	|
	|-RVA: 0xFA92E0 Offset: 0xFA84E0 VA: 0x180FA92E0
	|-ConcurrentDictionary<object, object>.TryGetValue
	|
	|-RVA: 0xFA9230 Offset: 0xFA8430 VA: 0x180FA9230
	|-ConcurrentDictionary<ushort, object>.TryGetValue
	|
	|-RVA: 0xFA9180 Offset: 0xFA8380 VA: 0x180FA9180
	|-ConcurrentDictionary<ulong, JsonEncodedText>.TryGetValue
	|
	|-RVA: 0xFA8E30 Offset: 0xFA8030 VA: 0x180FA8E30
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8D4D0 Offset: 0xF8C6D0 VA: 0x180F8D4D0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryGetValueInternal
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.TryGetValueInternal
	|
	|-RVA: 0xF8D6B0 Offset: 0xF8C8B0 VA: 0x180F8D6B0
	|-ConcurrentDictionary<object, bool>.TryGetValueInternal
	|
	|-RVA: 0xFA86B0 Offset: 0xFA78B0 VA: 0x180FA86B0
	|-ConcurrentDictionary<object, DateTimeOffset>.TryGetValueInternal
	|-ConcurrentDictionary<ulong, JsonEncodedText>.TryGetValueInternal
	|
	|-RVA: 0xFA8800 Offset: 0xFA7A00 VA: 0x180FA8800
	|-ConcurrentDictionary<object, object>.TryGetValueInternal
	|
	|-RVA: 0xFA8950 Offset: 0xFA7B50 VA: 0x180FA8950
	|-ConcurrentDictionary<ushort, object>.TryGetValueInternal
	|
	|-RVA: 0xFA8AA0 Offset: 0xFA7CA0 VA: 0x180FA8AA0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValueInternal
	*/

	// RVA: -1 Offset: -1
	private bool TryUpdateInternal(TKey key, int hashcode, TValue newValue, TValue comparisonValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8E840 Offset: 0xF8DA40 VA: 0x180F8E840
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryUpdateInternal
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.TryUpdateInternal
	|
	|-RVA: 0xF8E3E0 Offset: 0xF8D5E0 VA: 0x180F8E3E0
	|-ConcurrentDictionary<object, bool>.TryUpdateInternal
	|
	|-RVA: 0xFAC590 Offset: 0xFAB790 VA: 0x180FAC590
	|-ConcurrentDictionary<object, DateTimeOffset>.TryUpdateInternal
	|
	|-RVA: 0xFABCD0 Offset: 0xFAAED0 VA: 0x180FABCD0
	|-ConcurrentDictionary<object, object>.TryUpdateInternal
	|
	|-RVA: 0xFAC130 Offset: 0xFAB330 VA: 0x180FAC130
	|-ConcurrentDictionary<ushort, object>.TryUpdateInternal
	|
	|-RVA: 0xFAB7E0 Offset: 0xFAA9E0 VA: 0x180FAB7E0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.TryUpdateInternal
	|
	|-RVA: 0xFAAF90 Offset: 0xFAA190 VA: 0x180FAAF90
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryUpdateInternal
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF81D30 Offset: 0xF80F30 VA: 0x180F81D30
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.Clear
	|
	|-RVA: 0xF81FE0 Offset: 0xF811E0 VA: 0x180F81FE0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.Clear
	|
	|-RVA: 0xF81A80 Offset: 0xF80C80 VA: 0x180F81A80
	|-ConcurrentDictionary<object, bool>.Clear
	|
	|-RVA: 0xF92E20 Offset: 0xF92020 VA: 0x180F92E20
	|-ConcurrentDictionary<object, DateTimeOffset>.Clear
	|
	|-RVA: 0xF92B70 Offset: 0xF91D70 VA: 0x180F92B70
	|-ConcurrentDictionary<object, object>.Clear
	|
	|-RVA: 0xF93390 Offset: 0xF92590 VA: 0x180F93390
	|-ConcurrentDictionary<ushort, object>.Clear
	|
	|-RVA: 0xF93640 Offset: 0xF92840 VA: 0x180F93640
	|-ConcurrentDictionary<ulong, JsonEncodedText>.Clear
	|
	|-RVA: 0xF930D0 Offset: 0xF922D0 VA: 0x180F930D0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF879A0 Offset: 0xF86BA0 VA: 0x180F879A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0xF87F00 Offset: 0xF87100 VA: 0x180F87F00
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0xF87C50 Offset: 0xF86E50 VA: 0x180F87C50
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0xF9EC20 Offset: 0xF9DE20 VA: 0x180F9EC20
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0xF9E160 Offset: 0xF9D360 VA: 0x180F9E160
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0xF9E410 Offset: 0xF9D610 VA: 0x180F9E410
	|-ConcurrentDictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0xF9E970 Offset: 0xF9DB70 VA: 0x180F9E970
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0xF9E6C0 Offset: 0xF9D8C0 VA: 0x180F9E6C0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<TKey, TValue>[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8B4A0 Offset: 0xF8A6A0 VA: 0x180F8B4A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ToArray
	|
	|-RVA: 0xF8B790 Offset: 0xF8A990 VA: 0x180F8B790
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.ToArray
	|
	|-RVA: 0xF8BA80 Offset: 0xF8AC80 VA: 0x180F8BA80
	|-ConcurrentDictionary<object, bool>.ToArray
	|
	|-RVA: 0xFA5800 Offset: 0xFA4A00 VA: 0x180FA5800
	|-ConcurrentDictionary<object, DateTimeOffset>.ToArray
	|
	|-RVA: 0xFA4F60 Offset: 0xFA4160 VA: 0x180FA4F60
	|-ConcurrentDictionary<object, object>.ToArray
	|
	|-RVA: 0xFA5250 Offset: 0xFA4450 VA: 0x180FA5250
	|-ConcurrentDictionary<ushort, object>.ToArray
	|
	|-RVA: 0xFA4C70 Offset: 0xFA3E70 VA: 0x180FA4C70
	|-ConcurrentDictionary<ulong, JsonEncodedText>.ToArray
	|
	|-RVA: 0xFA5540 Offset: 0xFA4740 VA: 0x180FA5540
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF829C0 Offset: 0xF81BC0 VA: 0x180F829C0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToPairs
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.CopyToPairs
	|
	|-RVA: 0xF82B20 Offset: 0xF81D20 VA: 0x180F82B20
	|-ConcurrentDictionary<object, bool>.CopyToPairs
	|
	|-RVA: 0xF94E60 Offset: 0xF94060 VA: 0x180F94E60
	|-ConcurrentDictionary<object, DateTimeOffset>.CopyToPairs
	|-ConcurrentDictionary<ulong, JsonEncodedText>.CopyToPairs
	|
	|-RVA: 0xF95450 Offset: 0xF94650 VA: 0x180F95450
	|-ConcurrentDictionary<object, object>.CopyToPairs
	|
	|-RVA: 0xF95330 Offset: 0xF94530 VA: 0x180F95330
	|-ConcurrentDictionary<ushort, object>.CopyToPairs
	|
	|-RVA: 0xF94FC0 Offset: 0xF941C0 VA: 0x180F94FC0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToPairs
	*/

	// RVA: -1 Offset: -1
	private void CopyToEntries(DictionaryEntry[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF823D0 Offset: 0xF815D0 VA: 0x180F823D0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToEntries
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.CopyToEntries
	|
	|-RVA: 0xF82520 Offset: 0xF81720 VA: 0x180F82520
	|-ConcurrentDictionary<object, bool>.CopyToEntries
	|
	|-RVA: 0xF94100 Offset: 0xF93300 VA: 0x180F94100
	|-ConcurrentDictionary<object, DateTimeOffset>.CopyToEntries
	|
	|-RVA: 0xF94260 Offset: 0xF93460 VA: 0x180F94260
	|-ConcurrentDictionary<object, object>.CopyToEntries
	|
	|-RVA: 0xF93FC0 Offset: 0xF931C0 VA: 0x180F93FC0
	|-ConcurrentDictionary<ushort, object>.CopyToEntries
	|
	|-RVA: 0xF93E30 Offset: 0xF93030 VA: 0x180F93E30
	|-ConcurrentDictionary<ulong, JsonEncodedText>.CopyToEntries
	|
	|-RVA: 0xF94370 Offset: 0xF93570 VA: 0x180F94370
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToEntries
	*/

	// RVA: -1 Offset: -1
	private void CopyToObjects(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF82810 Offset: 0xF81A10 VA: 0x180F82810
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToObjects
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.CopyToObjects
	|
	|-RVA: 0xF82680 Offset: 0xF81880 VA: 0x180F82680
	|-ConcurrentDictionary<object, bool>.CopyToObjects
	|
	|-RVA: 0xF94780 Offset: 0xF93980 VA: 0x180F94780
	|-ConcurrentDictionary<object, DateTimeOffset>.CopyToObjects
	|-ConcurrentDictionary<ulong, JsonEncodedText>.CopyToObjects
	|
	|-RVA: 0xF94930 Offset: 0xF93B30 VA: 0x180F94930
	|-ConcurrentDictionary<object, object>.CopyToObjects
	|
	|-RVA: 0xF945F0 Offset: 0xF937F0 VA: 0x180F945F0
	|-ConcurrentDictionary<ushort, object>.CopyToObjects
	|
	|-RVA: 0xF94AC0 Offset: 0xF93CC0 VA: 0x180F94AC0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToObjects
	*/

	[IteratorStateMachine(typeof(ConcurrentDictionary.<GetEnumerator>d__35<TKey, TValue>))]
	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF82DB0 Offset: 0xF81FB0 VA: 0x180F82DB0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetEnumerator
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.GetEnumerator
	|-ConcurrentDictionary<object, DateTimeOffset>.GetEnumerator
	|-ConcurrentDictionary<ulong, JsonEncodedText>.GetEnumerator
	|
	|-RVA: 0xF82D20 Offset: 0xF81F20 VA: 0x180F82D20
	|-ConcurrentDictionary<object, bool>.GetEnumerator
	|-ConcurrentDictionary<object, object>.GetEnumerator
	|-ConcurrentDictionary<ushort, object>.GetEnumerator
	|
	|-RVA: 0xF95570 Offset: 0xF94770 VA: 0x180F95570
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8C3B0 Offset: 0xF8B5B0 VA: 0x180F8C3B0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryAddInternal
	|
	|-RVA: 0xF8CA70 Offset: 0xF8BC70 VA: 0x180F8CA70
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.TryAddInternal
	|
	|-RVA: 0xF8BD70 Offset: 0xF8AF70 VA: 0x180F8BD70
	|-ConcurrentDictionary<object, bool>.TryAddInternal
	|
	|-RVA: 0xFA6130 Offset: 0xFA5330 VA: 0x180FA6130
	|-ConcurrentDictionary<object, DateTimeOffset>.TryAddInternal
	|
	|-RVA: 0xFA6790 Offset: 0xFA5990 VA: 0x180FA6790
	|-ConcurrentDictionary<object, object>.TryAddInternal
	|
	|-RVA: 0xFA5AF0 Offset: 0xFA4CF0 VA: 0x180FA5AF0
	|-ConcurrentDictionary<ushort, object>.TryAddInternal
	|
	|-RVA: 0xFA7950 Offset: 0xFA6B50 VA: 0x180FA7950
	|-ConcurrentDictionary<ulong, JsonEncodedText>.TryAddInternal
	|
	|-RVA: 0xFA6DD0 Offset: 0xFA5FD0 VA: 0x180FA6DD0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAddInternal
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF90900 Offset: 0xF8FB00 VA: 0x180F90900
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Item
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.get_Item
	|
	|-RVA: 0xF909D0 Offset: 0xF8FBD0 VA: 0x180F909D0
	|-ConcurrentDictionary<object, bool>.get_Item
	|
	|-RVA: 0xFAFA60 Offset: 0xFAEC60 VA: 0x180FAFA60
	|-ConcurrentDictionary<object, DateTimeOffset>.get_Item
	|
	|-RVA: 0xFAF700 Offset: 0xFAE900 VA: 0x180FAF700
	|-ConcurrentDictionary<object, object>.get_Item
	|
	|-RVA: 0xFAFBC0 Offset: 0xFAEDC0 VA: 0x180FAFBC0
	|-ConcurrentDictionary<ushort, object>.get_Item
	|
	|-RVA: 0xFAFB00 Offset: 0xFAED00 VA: 0x180FAFB00
	|-ConcurrentDictionary<ulong, JsonEncodedText>.get_Item
	|
	|-RVA: 0xFAF850 Offset: 0xFAEA50 VA: 0x180FAF850
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF90D60 Offset: 0xF8FF60 VA: 0x180F90D60
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.set_Item
	|
	|-RVA: 0xF90B10 Offset: 0xF8FD10 VA: 0x180F90B10
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.set_Item
	|
	|-RVA: 0xF90C60 Offset: 0xF8FE60 VA: 0x180F90C60
	|-ConcurrentDictionary<object, bool>.set_Item
	|
	|-RVA: 0xFAFDF0 Offset: 0xFAEFF0 VA: 0x180FAFDF0
	|-ConcurrentDictionary<object, DateTimeOffset>.set_Item
	|
	|-RVA: 0xFAFCF0 Offset: 0xFAEEF0 VA: 0x180FAFCF0
	|-ConcurrentDictionary<object, object>.set_Item
	|
	|-RVA: 0xFB0250 Offset: 0xFAF450 VA: 0x180FB0250
	|-ConcurrentDictionary<ushort, object>.set_Item
	|
	|-RVA: 0xFB0310 Offset: 0xFAF510 VA: 0x180FB0310
	|-ConcurrentDictionary<ulong, JsonEncodedText>.set_Item
	|
	|-RVA: 0xFAFF10 Offset: 0xFAF110 VA: 0x180FAFF10
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNotFoundException(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8B3D0 Offset: 0xF8A5D0 VA: 0x180F8B3D0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ThrowKeyNotFoundException
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.ThrowKeyNotFoundException
	|-ConcurrentDictionary<object, bool>.ThrowKeyNotFoundException
	|-ConcurrentDictionary<object, DateTimeOffset>.ThrowKeyNotFoundException
	|-ConcurrentDictionary<object, object>.ThrowKeyNotFoundException
	|-ConcurrentDictionary<ushort, object>.ThrowKeyNotFoundException
	|-ConcurrentDictionary<ulong, JsonEncodedText>.ThrowKeyNotFoundException
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowKeyNotFoundException
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNullException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8B450 Offset: 0xF8A650 VA: 0x180F8B450
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ThrowKeyNullException
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.ThrowKeyNullException
	|-ConcurrentDictionary<object, bool>.ThrowKeyNullException
	|-ConcurrentDictionary<object, DateTimeOffset>.ThrowKeyNullException
	|-ConcurrentDictionary<object, object>.ThrowKeyNullException
	|-ConcurrentDictionary<ushort, object>.ThrowKeyNullException
	|-ConcurrentDictionary<ulong, JsonEncodedText>.ThrowKeyNullException
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowKeyNullException
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF90180 Offset: 0xF8F380 VA: 0x180F90180
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Count
	|
	|-RVA: 0xF90270 Offset: 0xF8F470 VA: 0x180F90270
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.get_Count
	|
	|-RVA: 0xF90090 Offset: 0xF8F290 VA: 0x180F90090
	|-ConcurrentDictionary<object, bool>.get_Count
	|
	|-RVA: 0xFAE9D0 Offset: 0xFADBD0 VA: 0x180FAE9D0
	|-ConcurrentDictionary<object, DateTimeOffset>.get_Count
	|
	|-RVA: 0xFAE8E0 Offset: 0xFADAE0 VA: 0x180FAE8E0
	|-ConcurrentDictionary<object, object>.get_Count
	|
	|-RVA: 0xFAEAC0 Offset: 0xFADCC0 VA: 0x180FAEAC0
	|-ConcurrentDictionary<ushort, object>.get_Count
	|
	|-RVA: 0xFAEBB0 Offset: 0xFADDB0 VA: 0x180FAEBB0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.get_Count
	|
	|-RVA: 0xFAECA0 Offset: 0xFADEA0 VA: 0x180FAECA0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private int GetCountInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF82C70 Offset: 0xF81E70 VA: 0x180F82C70
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetCountInternal
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.GetCountInternal
	|-ConcurrentDictionary<object, bool>.GetCountInternal
	|-ConcurrentDictionary<object, DateTimeOffset>.GetCountInternal
	|-ConcurrentDictionary<object, object>.GetCountInternal
	|-ConcurrentDictionary<ushort, object>.GetCountInternal
	|-ConcurrentDictionary<ulong, JsonEncodedText>.GetCountInternal
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetCountInternal
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF83A60 Offset: 0xF82C60 VA: 0x180F83A60
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetOrAdd
	|
	|-RVA: 0xF83F70 Offset: 0xF83170 VA: 0x180F83F70
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.GetOrAdd
	|
	|-RVA: 0xF83DE0 Offset: 0xF82FE0 VA: 0x180F83DE0
	|-ConcurrentDictionary<object, bool>.GetOrAdd
	|
	|-RVA: 0xF96A00 Offset: 0xF95C00 VA: 0x180F96A00
	|-ConcurrentDictionary<object, DateTimeOffset>.GetOrAdd
	|
	|-RVA: 0xF97770 Offset: 0xF96970 VA: 0x180F97770
	|-ConcurrentDictionary<object, object>.GetOrAdd
	|
	|-RVA: 0xF96D20 Offset: 0xF95F20 VA: 0x180F96D20
	|-ConcurrentDictionary<ushort, object>.GetOrAdd
	|
	|-RVA: 0xF96890 Offset: 0xF95A90 VA: 0x180F96890
	|-ConcurrentDictionary<ulong, JsonEncodedText>.GetOrAdd
	|
	|-RVA: 0xF96E70 Offset: 0xF96070 VA: 0x180F96E70
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetOrAdd
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF83C50 Offset: 0xF82E50 VA: 0x180F83C50
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetOrAdd
	|
	|-RVA: 0xF83790 Offset: 0xF82990 VA: 0x180F83790
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.GetOrAdd
	|
	|-RVA: 0xF83920 Offset: 0xF82B20 VA: 0x180F83920
	|-ConcurrentDictionary<object, bool>.GetOrAdd
	|
	|-RVA: 0xF96BC0 Offset: 0xF95DC0 VA: 0x180F96BC0
	|-ConcurrentDictionary<object, DateTimeOffset>.GetOrAdd
	|
	|-RVA: 0xF96540 Offset: 0xF95740 VA: 0x180F96540
	|-ConcurrentDictionary<object, object>.GetOrAdd
	|
	|-RVA: 0xF96790 Offset: 0xF95990 VA: 0x180F96790
	|-ConcurrentDictionary<ushort, object>.GetOrAdd
	|
	|-RVA: 0xF96680 Offset: 0xF95880 VA: 0x180F96680
	|-ConcurrentDictionary<ulong, JsonEncodedText>.GetOrAdd
	|
	|-RVA: 0xF97340 Offset: 0xF96540 VA: 0x180F97340
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetOrAdd
	*/

	// RVA: -1 Offset: -1
	public TValue AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF81180 Offset: 0xF80380 VA: 0x180F81180
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.AddOrUpdate
	|
	|-RVA: 0xF817A0 Offset: 0xF809A0 VA: 0x180F817A0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.AddOrUpdate
	|
	|-RVA: 0xF81460 Offset: 0xF80660 VA: 0x180F81460
	|-ConcurrentDictionary<object, bool>.AddOrUpdate
	|
	|-RVA: 0xF91930 Offset: 0xF90B30 VA: 0x180F91930
	|-ConcurrentDictionary<object, DateTimeOffset>.AddOrUpdate
	|
	|-RVA: 0xF915E0 Offset: 0xF907E0 VA: 0x180F915E0
	|-ConcurrentDictionary<object, object>.AddOrUpdate
	|
	|-RVA: 0xF924E0 Offset: 0xF916E0 VA: 0x180F924E0
	|-ConcurrentDictionary<ushort, object>.AddOrUpdate
	|
	|-RVA: 0xF927E0 Offset: 0xF919E0 VA: 0x180F927E0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.AddOrUpdate
	|
	|-RVA: 0xF91D00 Offset: 0xF90F00 VA: 0x180F91D00
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddOrUpdate
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF90420 Offset: 0xF8F620 VA: 0x180F90420
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_IsEmpty
	|
	|-RVA: 0xF90760 Offset: 0xF8F960 VA: 0x180F90760
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.get_IsEmpty
	|
	|-RVA: 0xF905C0 Offset: 0xF8F7C0 VA: 0x180F905C0
	|-ConcurrentDictionary<object, bool>.get_IsEmpty
	|
	|-RVA: 0xFAF220 Offset: 0xFAE420 VA: 0x180FAF220
	|-ConcurrentDictionary<object, DateTimeOffset>.get_IsEmpty
	|
	|-RVA: 0xFAF080 Offset: 0xFAE280 VA: 0x180FAF080
	|-ConcurrentDictionary<object, object>.get_IsEmpty
	|
	|-RVA: 0xFAF3C0 Offset: 0xFAE5C0 VA: 0x180FAF3C0
	|-ConcurrentDictionary<ushort, object>.get_IsEmpty
	|
	|-RVA: 0xFAF560 Offset: 0xFAE760 VA: 0x180FAF560
	|-ConcurrentDictionary<ulong, JsonEncodedText>.get_IsEmpty
	|
	|-RVA: 0xFAEEE0 Offset: 0xFAE0E0 VA: 0x180FAEEE0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF88450 Offset: 0xF87650 VA: 0x180F88450
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0xF882B0 Offset: 0xF874B0 VA: 0x180F882B0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0xF885F0 Offset: 0xF877F0 VA: 0x180F885F0
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0xF9F740 Offset: 0xF9E940 VA: 0x180F9F740
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0xF9F8C0 Offset: 0xF9EAC0 VA: 0x180F9F8C0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0xF9F4F0 Offset: 0xF9E6F0 VA: 0x180F9F4F0
	|-ConcurrentDictionary<ushort, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0xF9F610 Offset: 0xF9E810 VA: 0x180F9F610
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0xF9F330 Offset: 0xF9E530 VA: 0x180F9F330
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF887E0 Offset: 0xF879E0 VA: 0x180F887E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0xF88750 Offset: 0xF87950 VA: 0x180F88750
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0xF9FB20 Offset: 0xF9ED20 VA: 0x180F9FB20
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0xF9FA80 Offset: 0xF9EC80 VA: 0x180F9FA80
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0xF9FD00 Offset: 0xF9EF00 VA: 0x180F9FD00
	|-ConcurrentDictionary<ushort, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0xF9FA20 Offset: 0xF9EC20 VA: 0x180F9FA20
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0xF9FBC0 Offset: 0xF9EDC0 VA: 0x180F9FBC0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF88880 Offset: 0xF87A80 VA: 0x180F88880
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Keys
	|
	|-RVA: 0xF88860 Offset: 0xF87A60 VA: 0x180F88860
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.get_Keys
	|
	|-RVA: 0xF88840 Offset: 0xF87A40 VA: 0x180F88840
	|-ConcurrentDictionary<object, bool>.get_Keys
	|
	|-RVA: 0xF9FD50 Offset: 0xF9EF50 VA: 0x180F9FD50
	|-ConcurrentDictionary<object, DateTimeOffset>.get_Keys
	|
	|-RVA: 0xF9FD70 Offset: 0xF9EF70 VA: 0x180F9FD70
	|-ConcurrentDictionary<object, object>.get_Keys
	|
	|-RVA: 0xF9FDD0 Offset: 0xF9EFD0 VA: 0x180F9FDD0
	|-ConcurrentDictionary<ushort, object>.get_Keys
	|
	|-RVA: 0xF9FD90 Offset: 0xF9EF90 VA: 0x180F9FD90
	|-ConcurrentDictionary<ulong, JsonEncodedText>.get_Keys
	|
	|-RVA: 0xF9FDB0 Offset: 0xF9EFB0 VA: 0x180F9FDB0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF88880 Offset: 0xF87A80 VA: 0x180F88880
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xF88860 Offset: 0xF87A60 VA: 0x180F88860
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xF88840 Offset: 0xF87A40 VA: 0x180F88840
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xF9FD50 Offset: 0xF9EF50 VA: 0x180F9FD50
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xF9FD70 Offset: 0xF9EF70 VA: 0x180F9FD70
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xF9FDD0 Offset: 0xF9EFD0 VA: 0x180F9FDD0
	|-ConcurrentDictionary<ushort, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xF9FD90 Offset: 0xF9EF90 VA: 0x180F9FD90
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xF9FDB0 Offset: 0xF9EFB0 VA: 0x180F9FDB0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF888E0 Offset: 0xF87AE0 VA: 0x180F888E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Values
	|
	|-RVA: 0xF888C0 Offset: 0xF87AC0 VA: 0x180F888C0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.get_Values
	|
	|-RVA: 0xF888A0 Offset: 0xF87AA0 VA: 0x180F888A0
	|-ConcurrentDictionary<object, bool>.get_Values
	|
	|-RVA: 0xF9FE10 Offset: 0xF9F010 VA: 0x180F9FE10
	|-ConcurrentDictionary<object, DateTimeOffset>.get_Values
	|
	|-RVA: 0xF9FE50 Offset: 0xF9F050 VA: 0x180F9FE50
	|-ConcurrentDictionary<object, object>.get_Values
	|
	|-RVA: 0xF9FE70 Offset: 0xF9F070 VA: 0x180F9FE70
	|-ConcurrentDictionary<ushort, object>.get_Values
	|
	|-RVA: 0xF9FDF0 Offset: 0xF9EFF0 VA: 0x180F9FDF0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.get_Values
	|
	|-RVA: 0xF9FE30 Offset: 0xF9F030 VA: 0x180F9FE30
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF888E0 Offset: 0xF87AE0 VA: 0x180F888E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xF888C0 Offset: 0xF87AC0 VA: 0x180F888C0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xF888A0 Offset: 0xF87AA0 VA: 0x180F888A0
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xF9FE10 Offset: 0xF9F010 VA: 0x180F9FE10
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xF9FE50 Offset: 0xF9F050 VA: 0x180F9FE50
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xF9FE70 Offset: 0xF9F070 VA: 0x180F9FE70
	|-ConcurrentDictionary<ushort, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xF9FDF0 Offset: 0xF9EFF0 VA: 0x180F9FDF0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xF9FE30 Offset: 0xF9F030 VA: 0x180F9FE30
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF876E0 Offset: 0xF868E0 VA: 0x180F876E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xF87670 Offset: 0xF86870 VA: 0x180F87670
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xF9D6C0 Offset: 0xF9C8C0 VA: 0x180F9D6C0
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xF9D7A0 Offset: 0xF9C9A0 VA: 0x180F9D7A0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xF9D9A0 Offset: 0xF9CBA0 VA: 0x180F9D9A0
	|-ConcurrentDictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xF9D810 Offset: 0xF9CA10 VA: 0x180F9D810
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF877C0 Offset: 0xF869C0 VA: 0x180F877C0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xF87860 Offset: 0xF86A60 VA: 0x180F87860
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xF9DEA0 Offset: 0xF9D0A0 VA: 0x180F9DEA0
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xF9E010 Offset: 0xF9D210 VA: 0x180F9E010
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xF9DD90 Offset: 0xF9CF90 VA: 0x180F9DD90
	|-ConcurrentDictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xF9DC70 Offset: 0xF9CE70 VA: 0x180F9DC70
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xF9DA10 Offset: 0xF9CC10 VA: 0x180F9DA10
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ConcurrentDictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF881B0 Offset: 0xF873B0 VA: 0x180F881B0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xF88200 Offset: 0xF87400 VA: 0x180F88200
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xF9EED0 Offset: 0xF9E0D0 VA: 0x180F9EED0
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xF9EFE0 Offset: 0xF9E1E0 VA: 0x180F9EFE0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xF9EF90 Offset: 0xF9E190 VA: 0x180F9EF90
	|-ConcurrentDictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xF9F2E0 Offset: 0xF9E4E0 VA: 0x180F9F2E0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xF9F090 Offset: 0xF9E290 VA: 0x180F9F090
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8B2B0 Offset: 0xF8A4B0 VA: 0x180F8B2B0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xF8B340 Offset: 0xF8A540 VA: 0x180F8B340
	|-ConcurrentDictionary<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentDictionary<ushort, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xFA4C50 Offset: 0xFA3E50 VA: 0x180FA4C50
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF89C10 Offset: 0xF88E10 VA: 0x180F89C10
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Add
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xF89EA0 Offset: 0xF890A0 VA: 0x180F89EA0
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xFA21D0 Offset: 0xFA13D0 VA: 0x180FA21D0
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xFA2680 Offset: 0xFA1880 VA: 0x180FA2680
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xFA2460 Offset: 0xFA1660 VA: 0x180FA2460
	|-ConcurrentDictionary<ushort, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xFA1C60 Offset: 0xFA0E60 VA: 0x180FA1C60
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xFA1EE0 Offset: 0xFA10E0 VA: 0x180FA1EE0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8A0D0 Offset: 0xF892D0 VA: 0x180F8A0D0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Contains
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xF8A200 Offset: 0xF89400 VA: 0x180F8A200
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xFA2A40 Offset: 0xFA1C40 VA: 0x180FA2A40
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xFA2D60 Offset: 0xFA1F60 VA: 0x180FA2D60
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xFA2BE0 Offset: 0xFA1DE0 VA: 0x180FA2BE0
	|-ConcurrentDictionary<ushort, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xFA28A0 Offset: 0xFA1AA0 VA: 0x180FA28A0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xFA2EE0 Offset: 0xFA20E0 VA: 0x180FA2EE0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8A380 Offset: 0xF89580 VA: 0x180F8A380
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.GetEnumerator
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.IDictionary.GetEnumerator
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.IDictionary.GetEnumerator
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xF8A400 Offset: 0xF89600 VA: 0x180F8A400
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.GetEnumerator
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|-ConcurrentDictionary<ushort, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xFA3060 Offset: 0xFA2260 VA: 0x180FA3060
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.get_IsFixedSize
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.IDictionary.get_IsFixedSize
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ConcurrentDictionary<ushort, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.IDictionary.get_IsFixedSize
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.get_IsReadOnly
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.IDictionary.get_IsReadOnly
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ConcurrentDictionary<ushort, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.IDictionary.get_IsReadOnly
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF88880 Offset: 0xF87A80 VA: 0x180F88880
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xF88860 Offset: 0xF87A60 VA: 0x180F88860
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xF88840 Offset: 0xF87A40 VA: 0x180F88840
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xF9FD50 Offset: 0xF9EF50 VA: 0x180F9FD50
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xF9FD70 Offset: 0xF9EF70 VA: 0x180F9FD70
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xF9FDD0 Offset: 0xF9EFD0 VA: 0x180F9FDD0
	|-ConcurrentDictionary<ushort, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xF9FD90 Offset: 0xF9EF90 VA: 0x180F9FD90
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xF9FDB0 Offset: 0xF9EFB0 VA: 0x180F9FDB0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8A480 Offset: 0xF89680 VA: 0x180F8A480
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Remove
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xF8A5C0 Offset: 0xF897C0 VA: 0x180F8A5C0
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xFA3640 Offset: 0xFA2840 VA: 0x180FA3640
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xFA3210 Offset: 0xFA2410 VA: 0x180FA3210
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xFA30E0 Offset: 0xFA22E0 VA: 0x180FA30E0
	|-ConcurrentDictionary<ushort, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xFA3340 Offset: 0xFA2540 VA: 0x180FA3340
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xFA3480 Offset: 0xFA2680 VA: 0x180FA3480
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF888E0 Offset: 0xF87AE0 VA: 0x180F888E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xF888C0 Offset: 0xF87AC0 VA: 0x180F888C0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xF888A0 Offset: 0xF87AA0 VA: 0x180F888A0
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xF9FE10 Offset: 0xF9F010 VA: 0x180F9FE10
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xF9FE50 Offset: 0xF9F050 VA: 0x180F9FE50
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xF9FE70 Offset: 0xF9F070 VA: 0x180F9FE70
	|-ConcurrentDictionary<ushort, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xF9FDF0 Offset: 0xF9EFF0 VA: 0x180F9FDF0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xF9FE30 Offset: 0xF9F030 VA: 0x180F9FE30
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8A880 Offset: 0xF89A80 VA: 0x180F8A880
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Item
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xF8A6E0 Offset: 0xF898E0 VA: 0x180F8A6E0
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xFA3780 Offset: 0xFA2980 VA: 0x180FA3780
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xFA3C50 Offset: 0xFA2E50 VA: 0x180FA3C50
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xFA3B40 Offset: 0xFA2D40 VA: 0x180FA3B40
	|-ConcurrentDictionary<ushort, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xFA3DD0 Offset: 0xFA2FD0 VA: 0x180FA3DD0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xFA3930 Offset: 0xFA2B30 VA: 0x180FA3930
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8A9A0 Offset: 0xF89BA0 VA: 0x180F8A9A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xF8AF70 Offset: 0xF8A170 VA: 0x180F8AF70
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xF8ACE0 Offset: 0xF89EE0 VA: 0x180F8ACE0
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xFA3F10 Offset: 0xFA3110 VA: 0x180FA3F10
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xFA41B0 Offset: 0xFA33B0 VA: 0x180FA41B0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xFA46F0 Offset: 0xFA38F0 VA: 0x180FA46F0
	|-ConcurrentDictionary<ushort, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xFA4450 Offset: 0xFA3650 VA: 0x180FA4450
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xFA4990 Offset: 0xFA3B90 VA: 0x180FA4990
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF88900 Offset: 0xF87B00 VA: 0x180F88900
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xF895A0 Offset: 0xF887A0 VA: 0x180F895A0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xF88F70 Offset: 0xF88170 VA: 0x180F88F70
	|-ConcurrentDictionary<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xFA04C0 Offset: 0xF9F6C0 VA: 0x180FA04C0
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xFA1660 Offset: 0xFA0860 VA: 0x180FA1660
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xF9FE90 Offset: 0xF9F090 VA: 0x180F9FE90
	|-ConcurrentDictionary<ushort, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xFA0FC0 Offset: 0xFA01C0 VA: 0x180FA0FC0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xFA0B40 Offset: 0xF9FD40 VA: 0x180FA0B40
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentDictionary<object, bool>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentDictionary<ushort, object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE79F0 Offset: 0xEE6BF0 VA: 0x180EE79F0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentDictionary<object, bool>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentDictionary<object, DateTimeOffset>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentDictionary<ushort, object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentDictionary<ulong, JsonEncodedText>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	private void GrowTable(ConcurrentDictionary.Tables<TKey, TValue> tables) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF851E0 Offset: 0xF843E0 VA: 0x180F851E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GrowTable
	|
	|-RVA: 0xF849D0 Offset: 0xF83BD0 VA: 0x180F849D0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.GrowTable
	|
	|-RVA: 0xF859F0 Offset: 0xF84BF0 VA: 0x180F859F0
	|-ConcurrentDictionary<object, bool>.GrowTable
	|
	|-RVA: 0xF99900 Offset: 0xF98B00 VA: 0x180F99900
	|-ConcurrentDictionary<object, DateTimeOffset>.GrowTable
	|
	|-RVA: 0xF9A110 Offset: 0xF99310 VA: 0x180F9A110
	|-ConcurrentDictionary<object, object>.GrowTable
	|
	|-RVA: 0xF99120 Offset: 0xF98320 VA: 0x180F99120
	|-ConcurrentDictionary<ushort, object>.GrowTable
	|
	|-RVA: 0xF98910 Offset: 0xF97B10 VA: 0x180F98910
	|-ConcurrentDictionary<ulong, JsonEncodedText>.GrowTable
	|
	|-RVA: 0xF9A910 Offset: 0xF99B10 VA: 0x180F9A910
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GrowTable
	*/

	// RVA: -1 Offset: -1
	private static int GetBucket(int hashcode, int bucketCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF82C60 Offset: 0xF81E60 VA: 0x180F82C60
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetBucket
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.GetBucket
	|-ConcurrentDictionary<object, bool>.GetBucket
	|-ConcurrentDictionary<object, DateTimeOffset>.GetBucket
	|-ConcurrentDictionary<object, object>.GetBucket
	|-ConcurrentDictionary<ushort, object>.GetBucket
	|-ConcurrentDictionary<ulong, JsonEncodedText>.GetBucket
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucket
	*/

	// RVA: -1 Offset: -1
	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF82C40 Offset: 0xF81E40 VA: 0x180F82C40
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetBucketAndLockNo
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.GetBucketAndLockNo
	|-ConcurrentDictionary<object, bool>.GetBucketAndLockNo
	|-ConcurrentDictionary<object, DateTimeOffset>.GetBucketAndLockNo
	|-ConcurrentDictionary<object, object>.GetBucketAndLockNo
	|-ConcurrentDictionary<ushort, object>.GetBucketAndLockNo
	|-ConcurrentDictionary<ulong, JsonEncodedText>.GetBucketAndLockNo
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucketAndLockNo
	*/

	// RVA: -1 Offset: -1
	private static int get_DefaultConcurrencyLevel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF903A0 Offset: 0xF8F5A0 VA: 0x180F903A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0xF90360 Offset: 0xF8F560 VA: 0x180F90360
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0xF903E0 Offset: 0xF8F5E0 VA: 0x180F903E0
	|-ConcurrentDictionary<object, bool>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0xFAEDA0 Offset: 0xFADFA0 VA: 0x180FAEDA0
	|-ConcurrentDictionary<object, DateTimeOffset>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0xFAEE20 Offset: 0xFAE020 VA: 0x180FAEE20
	|-ConcurrentDictionary<object, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0xFAEEA0 Offset: 0xFAE0A0 VA: 0x180FAEEA0
	|-ConcurrentDictionary<ushort, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0xFAEDE0 Offset: 0xFADFE0 VA: 0x180FAEDE0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0xFAEE60 Offset: 0xFAE060 VA: 0x180FAEE60
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_DefaultConcurrencyLevel
	*/

	// RVA: -1 Offset: -1
	private void AcquireAllLocks(ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF80DA0 Offset: 0xF7FFA0 VA: 0x180F80DA0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.AcquireAllLocks
	|
	|-RVA: 0xF80F10 Offset: 0xF80110 VA: 0x180F80F10
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.AcquireAllLocks
	|
	|-RVA: 0xF80C30 Offset: 0xF7FE30 VA: 0x180F80C30
	|-ConcurrentDictionary<object, bool>.AcquireAllLocks
	|
	|-RVA: 0xF91300 Offset: 0xF90500 VA: 0x180F91300
	|-ConcurrentDictionary<object, DateTimeOffset>.AcquireAllLocks
	|
	|-RVA: 0xF91470 Offset: 0xF90670 VA: 0x180F91470
	|-ConcurrentDictionary<object, object>.AcquireAllLocks
	|
	|-RVA: 0xF91190 Offset: 0xF90390 VA: 0x180F91190
	|-ConcurrentDictionary<ushort, object>.AcquireAllLocks
	|
	|-RVA: 0xF90EB0 Offset: 0xF900B0 VA: 0x180F90EB0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.AcquireAllLocks
	|
	|-RVA: 0xF91020 Offset: 0xF90220 VA: 0x180F91020
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AcquireAllLocks
	*/

	// RVA: -1 Offset: -1
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF81080 Offset: 0xF80280 VA: 0x180F81080
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.AcquireLocks
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.AcquireLocks
	|-ConcurrentDictionary<object, bool>.AcquireLocks
	|-ConcurrentDictionary<object, DateTimeOffset>.AcquireLocks
	|-ConcurrentDictionary<object, object>.AcquireLocks
	|-ConcurrentDictionary<ushort, object>.AcquireLocks
	|-ConcurrentDictionary<ulong, JsonEncodedText>.AcquireLocks
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AcquireLocks
	*/

	// RVA: -1 Offset: -1
	private void ReleaseLocks(int fromInclusive, int toExclusive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF875E0 Offset: 0xF867E0 VA: 0x180F875E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ReleaseLocks
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.ReleaseLocks
	|-ConcurrentDictionary<object, bool>.ReleaseLocks
	|-ConcurrentDictionary<object, DateTimeOffset>.ReleaseLocks
	|-ConcurrentDictionary<object, object>.ReleaseLocks
	|-ConcurrentDictionary<ushort, object>.ReleaseLocks
	|-ConcurrentDictionary<ulong, JsonEncodedText>.ReleaseLocks
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReleaseLocks
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TKey> GetKeys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF82E40 Offset: 0xF82040 VA: 0x180F82E40
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetKeys
	|
	|-RVA: 0xF83180 Offset: 0xF82380 VA: 0x180F83180
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.GetKeys
	|
	|-RVA: 0xF834C0 Offset: 0xF826C0 VA: 0x180F834C0
	|-ConcurrentDictionary<object, bool>.GetKeys
	|
	|-RVA: 0xF96270 Offset: 0xF95470 VA: 0x180F96270
	|-ConcurrentDictionary<object, DateTimeOffset>.GetKeys
	|
	|-RVA: 0xF95CD0 Offset: 0xF94ED0 VA: 0x180F95CD0
	|-ConcurrentDictionary<object, object>.GetKeys
	|
	|-RVA: 0xF95FA0 Offset: 0xF951A0 VA: 0x180F95FA0
	|-ConcurrentDictionary<ushort, object>.GetKeys
	|
	|-RVA: 0xF95A00 Offset: 0xF94C00 VA: 0x180F95A00
	|-ConcurrentDictionary<ulong, JsonEncodedText>.GetKeys
	|
	|-RVA: 0xF95630 Offset: 0xF94830 VA: 0x180F95630
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeys
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TValue> GetValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF84700 Offset: 0xF83900 VA: 0x180F84700
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetValues
	|
	|-RVA: 0xF84160 Offset: 0xF83360 VA: 0x180F84160
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.GetValues
	|
	|-RVA: 0xF84430 Offset: 0xF83630 VA: 0x180F84430
	|-ConcurrentDictionary<object, bool>.GetValues
	|
	|-RVA: 0xF97F10 Offset: 0xF97110 VA: 0x180F97F10
	|-ConcurrentDictionary<object, DateTimeOffset>.GetValues
	|
	|-RVA: 0xF97900 Offset: 0xF96B00 VA: 0x180F97900
	|-ConcurrentDictionary<object, object>.GetValues
	|
	|-RVA: 0xF98640 Offset: 0xF97840 VA: 0x180F98640
	|-ConcurrentDictionary<ushort, object>.GetValues
	|
	|-RVA: 0xF97BD0 Offset: 0xF96DD0 VA: 0x180F97BD0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.GetValues
	|
	|-RVA: 0xF98250 Offset: 0xF97450 VA: 0x180F98250
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValues
	*/

	[OnSerializing]
	// RVA: -1 Offset: -1
	private void OnSerializing(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF87460 Offset: 0xF86660 VA: 0x180F87460
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnSerializing
	|
	|-RVA: 0xF874E0 Offset: 0xF866E0 VA: 0x180F874E0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.OnSerializing
	|
	|-RVA: 0xF87560 Offset: 0xF86760 VA: 0x180F87560
	|-ConcurrentDictionary<object, bool>.OnSerializing
	|
	|-RVA: 0xF9D4C0 Offset: 0xF9C6C0 VA: 0x180F9D4C0
	|-ConcurrentDictionary<object, DateTimeOffset>.OnSerializing
	|
	|-RVA: 0xF9D440 Offset: 0xF9C640 VA: 0x180F9D440
	|-ConcurrentDictionary<object, object>.OnSerializing
	|
	|-RVA: 0xF9D640 Offset: 0xF9C840 VA: 0x180F9D640
	|-ConcurrentDictionary<ushort, object>.OnSerializing
	|
	|-RVA: 0xF9D540 Offset: 0xF9C740 VA: 0x180F9D540
	|-ConcurrentDictionary<ulong, JsonEncodedText>.OnSerializing
	|
	|-RVA: 0xF9D5C0 Offset: 0xF9C7C0 VA: 0x180F9D5C0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnSerializing
	*/

	[OnSerialized]
	// RVA: -1 Offset: -1
	private void OnSerialized(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D670 Offset: 0x56C870 VA: 0x18056D670
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnSerialized
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.OnSerialized
	|-ConcurrentDictionary<object, bool>.OnSerialized
	|-ConcurrentDictionary<object, DateTimeOffset>.OnSerialized
	|-ConcurrentDictionary<object, object>.OnSerialized
	|-ConcurrentDictionary<ushort, object>.OnSerialized
	|-ConcurrentDictionary<ulong, JsonEncodedText>.OnSerialized
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnSerialized
	*/

	[OnDeserialized]
	// RVA: -1 Offset: -1
	private void OnDeserialized(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF87280 Offset: 0xF86480 VA: 0x180F87280
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnDeserialized
	|
	|-RVA: 0xF86EC0 Offset: 0xF860C0 VA: 0x180F86EC0
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>.OnDeserialized
	|
	|-RVA: 0xF870A0 Offset: 0xF862A0 VA: 0x180F870A0
	|-ConcurrentDictionary<object, bool>.OnDeserialized
	|
	|-RVA: 0xF9D080 Offset: 0xF9C280 VA: 0x180F9D080
	|-ConcurrentDictionary<object, DateTimeOffset>.OnDeserialized
	|
	|-RVA: 0xF9CAE0 Offset: 0xF9BCE0 VA: 0x180F9CAE0
	|-ConcurrentDictionary<object, object>.OnDeserialized
	|
	|-RVA: 0xF9CCC0 Offset: 0xF9BEC0 VA: 0x180F9CCC0
	|-ConcurrentDictionary<ushort, object>.OnDeserialized
	|
	|-RVA: 0xF9CEA0 Offset: 0xF9C0A0 VA: 0x180F9CEA0
	|-ConcurrentDictionary<ulong, JsonEncodedText>.OnDeserialized
	|
	|-RVA: 0xF9D260 Offset: 0xF9C460 VA: 0x180F9D260
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnDeserialized
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8ED20 Offset: 0xF8DF20 VA: 0x180F8ED20
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..cctor
	|
	|-RVA: 0xF8F000 Offset: 0xF8E200 VA: 0x180F8F000
	|-ConcurrentDictionary<DiscardReasonWithCategory, object>..cctor
	|
	|-RVA: 0xF8EE90 Offset: 0xF8E090 VA: 0x180F8EE90
	|-ConcurrentDictionary<object, bool>..cctor
	|
	|-RVA: 0xFACF90 Offset: 0xFAC190 VA: 0x180FACF90
	|-ConcurrentDictionary<object, DateTimeOffset>..cctor
	|
	|-RVA: 0xFACA80 Offset: 0xFABC80 VA: 0x180FACA80
	|-ConcurrentDictionary<object, object>..cctor
	|
	|-RVA: 0xFACD60 Offset: 0xFABF60 VA: 0x180FACD60
	|-ConcurrentDictionary<ushort, object>..cctor
	|
	|-RVA: 0xFACBF0 Offset: 0xFABDF0 VA: 0x180FACBF0
	|-ConcurrentDictionary<ulong, JsonEncodedText>..cctor
	|
	|-RVA: 0xFACED0 Offset: 0xFAC0D0 VA: 0x180FACED0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Concurrent
internal sealed class IDictionaryDebugView<K, V> // TypeDefIndex: 4413
{}

// Namespace: 
[Serializable]
private class ConcurrentStack.Node<T> // TypeDefIndex: 4414
{
	// Fields
	internal readonly T _value; // 0x0
	internal ConcurrentStack.Node<T> _next; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14899B0 Offset: 0x1488BB0 VA: 0x1814899B0
	|-ConcurrentStack.Node<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ConcurrentStack.<GetEnumerator>d__35<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 4415
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public ConcurrentStack.Node<T> head; // 0x0
	private ConcurrentStack.Node<T> <current>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1E9D0 Offset: 0xB1DBD0 VA: 0x180B1E9D0
	|-ConcurrentStack.<GetEnumerator>d__35<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ConcurrentStack.<GetEnumerator>d__35<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB227C0 Offset: 0xB219C0 VA: 0x180B227C0
	|-ConcurrentStack.<GetEnumerator>d__35<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03E40 Offset: 0xB03040 VA: 0x180B03E40
	|-ConcurrentStack.<GetEnumerator>d__35<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ConcurrentStack.<GetEnumerator>d__35<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB042C0 Offset: 0xB034C0 VA: 0x180B042C0
	|-ConcurrentStack.<GetEnumerator>d__35<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Collections.Concurrent
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class ConcurrentStack<T> : IProducerConsumerCollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 4416
{
	// Fields
	private ConcurrentStack.Node<T> _head; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ConcurrentStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB5330 Offset: 0xFB4530 VA: 0x180FB5330
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE79F0 Offset: 0xEE6BF0 VA: 0x180EE79F0
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB4980 Offset: 0xFB3B80 VA: 0x180FB4980
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB46C0 Offset: 0xFB38C0 VA: 0x180FB46C0
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	private void PushCore(ConcurrentStack.Node<T> head, ConcurrentStack.Node<T> tail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB44E0 Offset: 0xFB36E0 VA: 0x180FB44E0
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.PushCore
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB48A0 Offset: 0xFB3AA0 VA: 0x180FB48A0
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryPop(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB51E0 Offset: 0xFB43E0 VA: 0x180FB51E0
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.TryPop
	*/

	// RVA: -1 Offset: -1
	private bool TryPopCore(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB50D0 Offset: 0xFB42D0 VA: 0x180FB50D0
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.TryPopCore
	*/

	// RVA: -1 Offset: -1
	private int TryPopCore(int count, out ConcurrentStack.Node<T> poppedHead) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB4D80 Offset: 0xFB3F80 VA: 0x180FB4D80
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.TryPopCore
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB25F0 Offset: 0xFB17F0 VA: 0x180FB25F0
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB4B10 Offset: 0xFB3D10 VA: 0x180FB4B10
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	private List<T> ToList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB4D30 Offset: 0xFB3F30 VA: 0x180FB4D30
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.ToList
	*/

	// RVA: -1 Offset: -1
	private List<T> ToList(ConcurrentStack.Node<T> curr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB4BB0 Offset: 0xFB3DB0 VA: 0x180FB4BB0
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.ToList
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB4490 Offset: 0xFB3690 VA: 0x180FB4490
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[IteratorStateMachine(typeof(ConcurrentStack.<GetEnumerator>d__35<T>))]
	// RVA: -1 Offset: -1
	private IEnumerator<T> GetEnumerator(ConcurrentStack.Node<T> head) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB43D0 Offset: 0xFB35D0 VA: 0x180FB43D0
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB4AC0 Offset: 0xFB3CC0 VA: 0x180FB4AC0
	|-ConcurrentStack<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Collections.Concurrent
public interface IProducerConsumerCollection<T> : IEnumerable<T>, IEnumerable, ICollection // TypeDefIndex: 4417
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryAdd(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProducerConsumerCollection<__Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TryTake(out T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProducerConsumerCollection<__Il2CppFullySharedGenericType>.TryTake
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract T[] ToArray();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProducerConsumerCollection<__Il2CppFullySharedGenericType>.ToArray
	*/
}

// Namespace: System.Collections.Concurrent
internal sealed class IProducerConsumerCollectionDebugView<T> // TypeDefIndex: 4418
{}

// Namespace: System.Collections.ObjectModel
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 4419
{
	// Fields
	private IList<T> items; // 0x0

	// Properties
	public int Count { get; }
	protected IList<T> Items { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CF40 Offset: 0xF0C140 VA: 0x180F0CF40
	|-Collection<object>..ctor
	|
	|-RVA: 0xC4F800 Offset: 0xC4EA00 VA: 0x180C4F800
	|-Collection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC3B50 Offset: 0xBC2D50 VA: 0x180BC3B50
	|-Collection<object>..ctor
	|-Collection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CFC0 Offset: 0xF0C1C0 VA: 0x180F0CFC0
	|-Collection<object>.get_Count
	|-Collection<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	protected IList<T> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-Collection<object>.get_Items
	|-Collection<__Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CAD0 Offset: 0xF0BCD0 VA: 0x180F0CAD0
	|-Collection<object>.get_Item
	|
	|-RVA: 0xF0D010 Offset: 0xF0C210 VA: 0x180F0D010
	|-Collection<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0D270 Offset: 0xF0C470 VA: 0x180F0D270
	|-Collection<object>.set_Item
	|
	|-RVA: 0xF0D0E0 Offset: 0xF0C2E0 VA: 0x180F0D0E0
	|-Collection<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09E10 Offset: 0xF09010 VA: 0x180F09E10
	|-Collection<object>.Add
	|
	|-RVA: 0xF09EF0 Offset: 0xF090F0 VA: 0x180F09EF0
	|-Collection<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A0C0 Offset: 0xF092C0 VA: 0x180F0A0C0
	|-Collection<object>.Clear
	|-Collection<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A290 Offset: 0xF09490 VA: 0x180F0A290
	|-Collection<object>.CopyTo
	|-Collection<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A230 Offset: 0xF09430 VA: 0x180F0A230
	|-Collection<object>.Contains
	|
	|-RVA: 0xF0A140 Offset: 0xF09340 VA: 0x180F0A140
	|-Collection<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A300 Offset: 0xF09500 VA: 0x180F0A300
	|-Collection<object>.GetEnumerator
	|-Collection<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A350 Offset: 0xF09550 VA: 0x180F0A350
	|-Collection<object>.IndexOf
	|
	|-RVA: 0xF0A3B0 Offset: 0xF095B0 VA: 0x180F0A3B0
	|-Collection<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A610 Offset: 0xF09810 VA: 0x180F0A610
	|-Collection<object>.Insert
	|
	|-RVA: 0xF0A700 Offset: 0xF09900 VA: 0x180F0A700
	|-Collection<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AB70 Offset: 0xF09D70 VA: 0x180F0AB70
	|-Collection<object>.Remove
	|
	|-RVA: 0xF0AC60 Offset: 0xF09E60 VA: 0x180F0AC60
	|-Collection<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AA30 Offset: 0xF09C30 VA: 0x180F0AA30
	|-Collection<object>.RemoveAt
	|-Collection<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected virtual void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A070 Offset: 0xF09270 VA: 0x180F0A070
	|-Collection<object>.ClearItems
	|-Collection<__Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A5A0 Offset: 0xF097A0 VA: 0x180F0A5A0
	|-Collection<object>.InsertItem
	|
	|-RVA: 0xF0A4A0 Offset: 0xF096A0 VA: 0x180F0A4A0
	|-Collection<__Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AB10 Offset: 0xF09D10 VA: 0x180F0AB10
	|-Collection<object>.RemoveItem
	|-Collection<__Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AED0 Offset: 0xF0A0D0 VA: 0x180F0AED0
	|-Collection<object>.SetItem
	|
	|-RVA: 0xF0ADD0 Offset: 0xF09FD0 VA: 0x180F0ADD0
	|-Collection<__Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AF40 Offset: 0xF0A140 VA: 0x180F0AF40
	|-Collection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0B8F0 Offset: 0xF0AAF0 VA: 0x180F0B8F0
	|-Collection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xF0B8A0 Offset: 0xF0AAA0 VA: 0x180F0B8A0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-Collection<object>.System.Collections.ICollection.get_IsSynchronized
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0B840 Offset: 0xF0AA40 VA: 0x180F0B840
	|-Collection<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xF0B7E0 Offset: 0xF0A9E0 VA: 0x180F0B7E0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AF90 Offset: 0xF0A190 VA: 0x180F0AF90
	|-Collection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xF0B390 Offset: 0xF0A590 VA: 0x180F0B390
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CAD0 Offset: 0xF0BCD0 VA: 0x180F0CAD0
	|-Collection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0xF0CB30 Offset: 0xF0BD30 VA: 0x180F0CB30
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CD80 Offset: 0xF0BF80 VA: 0x180F0CD80
	|-Collection<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0xF0CC00 Offset: 0xF0BE00 VA: 0x180F0CC00
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AF40 Offset: 0xF0A140 VA: 0x180F0AF40
	|-Collection<object>.System.Collections.IList.get_IsReadOnly
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0C970 Offset: 0xF0BB70 VA: 0x180F0C970
	|-Collection<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0xF0CA20 Offset: 0xF0BC20 VA: 0x180F0CA20
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0B940 Offset: 0xF0AB40 VA: 0x180F0B940
	|-Collection<object>.System.Collections.IList.Add
	|
	|-RVA: 0xF0BBA0 Offset: 0xF0ADA0 VA: 0x180F0BBA0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0BEA0 Offset: 0xF0B0A0 VA: 0x180F0BEA0
	|-Collection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0xF0BD80 Offset: 0xF0AF80 VA: 0x180F0BD80
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0BFE0 Offset: 0xF0B1E0 VA: 0x180F0BFE0
	|-Collection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xF0C120 Offset: 0xF0B320 VA: 0x180F0C120
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0C410 Offset: 0xF0B610 VA: 0x180F0C410
	|-Collection<object>.System.Collections.IList.Insert
	|
	|-RVA: 0xF0C240 Offset: 0xF0B440 VA: 0x180F0C240
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0C780 Offset: 0xF0B980 VA: 0x180F0C780
	|-Collection<object>.System.Collections.IList.Remove
	|
	|-RVA: 0xF0C620 Offset: 0xF0B820 VA: 0x180F0C620
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A9D0 Offset: 0xF09BD0 VA: 0x180F0A9D0
	|-Collection<object>.IsCompatibleObject
	|
	|-RVA: 0xF0A890 Offset: 0xF09A90 VA: 0x180F0A890
	|-Collection<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/
}

// Namespace: System.Collections.ObjectModel
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[Serializable]
public class ReadOnlyCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 4420
{
	// Fields
	private IList<T> list; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; }
	protected IList<T> Items { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC3B50 Offset: 0xBC2D50 VA: 0x180BC3B50
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>..ctor
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>..ctor
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>..ctor
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>..ctor
	|-ReadOnlyCollection<StructMultiKey<object, object>>..ctor
	|-ReadOnlyCollection<bool>..ctor
	|-ReadOnlyCollection<byte>..ctor
	|-ReadOnlyCollection<Color>..ctor
	|-ReadOnlyCollection<ControllerPollingInfo>..ctor
	|-ReadOnlyCollection<CustomAttributeNamedArgument>..ctor
	|-ReadOnlyCollection<CustomAttributeTypedArgument>..ctor
	|-ReadOnlyCollection<DateTimeOffset>..ctor
	|-ReadOnlyCollection<DiscardReasonWithCategory>..ctor
	|-ReadOnlyCollection<Edge>..ctor
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>..ctor
	|-ReadOnlyCollection<Guid>..ctor
	|-ReadOnlyCollection<InputActionSourceData>..ctor
	|-ReadOnlyCollection<int>..ctor
	|-ReadOnlyCollection<Int32Enum>..ctor
	|-ReadOnlyCollection<JsonEncodedText>..ctor
	|-ReadOnlyCollection<object>..ctor
	|-ReadOnlyCollection<PidVid>..ctor
	|-ReadOnlyCollection<ushort>..ctor
	|-ReadOnlyCollection<ulong>..ctor
	|-ReadOnlyCollection<Vector2>..ctor
	|-ReadOnlyCollection<Vector3>..ctor
	|-ReadOnlyCollection<Vector4>..ctor
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>..ctor
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC3B90 Offset: 0xBC2D90 VA: 0x180BC3B90
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.get_Count
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.get_Count
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.get_Count
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.get_Count
	|-ReadOnlyCollection<StructMultiKey<object, object>>.get_Count
	|-ReadOnlyCollection<bool>.get_Count
	|-ReadOnlyCollection<byte>.get_Count
	|-ReadOnlyCollection<Color>.get_Count
	|-ReadOnlyCollection<ControllerPollingInfo>.get_Count
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Count
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Count
	|-ReadOnlyCollection<DateTimeOffset>.get_Count
	|-ReadOnlyCollection<DiscardReasonWithCategory>.get_Count
	|-ReadOnlyCollection<Edge>.get_Count
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.get_Count
	|-ReadOnlyCollection<Guid>.get_Count
	|-ReadOnlyCollection<InputActionSourceData>.get_Count
	|-ReadOnlyCollection<int>.get_Count
	|-ReadOnlyCollection<Int32Enum>.get_Count
	|-ReadOnlyCollection<JsonEncodedText>.get_Count
	|-ReadOnlyCollection<object>.get_Count
	|-ReadOnlyCollection<PidVid>.get_Count
	|-ReadOnlyCollection<ushort>.get_Count
	|-ReadOnlyCollection<ulong>.get_Count
	|-ReadOnlyCollection<Vector2>.get_Count
	|-ReadOnlyCollection<Vector3>.get_Count
	|-ReadOnlyCollection<Vector4>.get_Count
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.get_Count
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB64C0 Offset: 0xBB56C0 VA: 0x180BB64C0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.get_Item
	|
	|-RVA: 0xBB6390 Offset: 0xBB5590 VA: 0x180BB6390
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.get_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.get_Item
	|-ReadOnlyCollection<Color>.get_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Item
	|-ReadOnlyCollection<DateTimeOffset>.get_Item
	|-ReadOnlyCollection<DiscardReasonWithCategory>.get_Item
	|-ReadOnlyCollection<Guid>.get_Item
	|-ReadOnlyCollection<JsonEncodedText>.get_Item
	|-ReadOnlyCollection<Vector4>.get_Item
	|
	|-RVA: 0xBB6460 Offset: 0xBB5660 VA: 0x180BB6460
	|-ReadOnlyCollection<bool>.get_Item
	|-ReadOnlyCollection<byte>.get_Item
	|-ReadOnlyCollection<Edge>.get_Item
	|-ReadOnlyCollection<int>.get_Item
	|-ReadOnlyCollection<Int32Enum>.get_Item
	|-ReadOnlyCollection<object>.get_Item
	|-ReadOnlyCollection<PidVid>.get_Item
	|-ReadOnlyCollection<ushort>.get_Item
	|-ReadOnlyCollection<ulong>.get_Item
	|-ReadOnlyCollection<Vector2>.get_Item
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.get_Item
	|
	|-RVA: 0xBB6650 Offset: 0xBB5850 VA: 0x180BB6650
	|-ReadOnlyCollection<ControllerPollingInfo>.get_Item
	|
	|-RVA: 0xBB65C0 Offset: 0xBB57C0 VA: 0x180BB65C0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Item
	|
	|-RVA: 0xBB66E0 Offset: 0xBB58E0 VA: 0x180BB66E0
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.get_Item
	|
	|-RVA: 0xBB6770 Offset: 0xBB5970 VA: 0x180BB6770
	|-ReadOnlyCollection<InputActionSourceData>.get_Item
	|
	|-RVA: 0xBB6540 Offset: 0xBB5740 VA: 0x180BB6540
	|-ReadOnlyCollection<Vector3>.get_Item
	|
	|-RVA: 0xBB67F0 Offset: 0xBB59F0 VA: 0x180BB67F0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB46E0 Offset: 0xBB38E0 VA: 0x180BB46E0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.Contains
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.Contains
	|
	|-RVA: 0xBB48F0 Offset: 0xBB3AF0 VA: 0x180BB48F0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.Contains
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.Contains
	|-ReadOnlyCollection<StructMultiKey<object, object>>.Contains
	|-ReadOnlyCollection<Color>.Contains
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.Contains
	|-ReadOnlyCollection<DateTimeOffset>.Contains
	|-ReadOnlyCollection<DiscardReasonWithCategory>.Contains
	|-ReadOnlyCollection<Guid>.Contains
	|-ReadOnlyCollection<JsonEncodedText>.Contains
	|-ReadOnlyCollection<Vector4>.Contains
	|
	|-RVA: 0xBB4F60 Offset: 0xBB4160 VA: 0x180BB4F60
	|-ReadOnlyCollection<bool>.Contains
	|-ReadOnlyCollection<byte>.Contains
	|
	|-RVA: 0xBB5120 Offset: 0xBB4320 VA: 0x180BB5120
	|-ReadOnlyCollection<ControllerPollingInfo>.Contains
	|
	|-RVA: 0xBB4C00 Offset: 0xBB3E00 VA: 0x180BB4C00
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.Contains
	|
	|-RVA: 0xBB4CE0 Offset: 0xBB3EE0 VA: 0x180BB4CE0
	|-ReadOnlyCollection<Edge>.Contains
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.Contains
	|
	|-RVA: 0xBB5030 Offset: 0xBB4230 VA: 0x180BB5030
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.Contains
	|
	|-RVA: 0xBB52E0 Offset: 0xBB44E0 VA: 0x180BB52E0
	|-ReadOnlyCollection<InputActionSourceData>.Contains
	|
	|-RVA: 0xBB47C0 Offset: 0xBB39C0 VA: 0x180BB47C0
	|-ReadOnlyCollection<int>.Contains
	|-ReadOnlyCollection<Int32Enum>.Contains
	|
	|-RVA: 0xBB4E90 Offset: 0xBB4090 VA: 0x180BB4E90
	|-ReadOnlyCollection<object>.Contains
	|-ReadOnlyCollection<ulong>.Contains
	|
	|-RVA: 0xBB4820 Offset: 0xBB3A20 VA: 0x180BB4820
	|-ReadOnlyCollection<PidVid>.Contains
	|
	|-RVA: 0xBB4B30 Offset: 0xBB3D30 VA: 0x180BB4B30
	|-ReadOnlyCollection<ushort>.Contains
	|
	|-RVA: 0xBB5210 Offset: 0xBB4410 VA: 0x180BB5210
	|-ReadOnlyCollection<Vector2>.Contains
	|
	|-RVA: 0xBB4DB0 Offset: 0xBB3FB0 VA: 0x180BB4DB0
	|-ReadOnlyCollection<Vector3>.Contains
	|
	|-RVA: 0xBB49C0 Offset: 0xBB3BC0 VA: 0x180BB49C0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB53C0 Offset: 0xBB45C0 VA: 0x180BB53C0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.CopyTo
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.CopyTo
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.CopyTo
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.CopyTo
	|-ReadOnlyCollection<StructMultiKey<object, object>>.CopyTo
	|-ReadOnlyCollection<bool>.CopyTo
	|-ReadOnlyCollection<byte>.CopyTo
	|-ReadOnlyCollection<Color>.CopyTo
	|-ReadOnlyCollection<ControllerPollingInfo>.CopyTo
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.CopyTo
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.CopyTo
	|-ReadOnlyCollection<DateTimeOffset>.CopyTo
	|-ReadOnlyCollection<DiscardReasonWithCategory>.CopyTo
	|-ReadOnlyCollection<Edge>.CopyTo
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.CopyTo
	|-ReadOnlyCollection<Guid>.CopyTo
	|-ReadOnlyCollection<InputActionSourceData>.CopyTo
	|-ReadOnlyCollection<int>.CopyTo
	|-ReadOnlyCollection<Int32Enum>.CopyTo
	|-ReadOnlyCollection<JsonEncodedText>.CopyTo
	|-ReadOnlyCollection<object>.CopyTo
	|-ReadOnlyCollection<PidVid>.CopyTo
	|-ReadOnlyCollection<ushort>.CopyTo
	|-ReadOnlyCollection<ulong>.CopyTo
	|-ReadOnlyCollection<Vector2>.CopyTo
	|-ReadOnlyCollection<Vector3>.CopyTo
	|-ReadOnlyCollection<Vector4>.CopyTo
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.CopyTo
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB5430 Offset: 0xBB4630 VA: 0x180BB5430
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.GetEnumerator
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.GetEnumerator
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.GetEnumerator
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.GetEnumerator
	|-ReadOnlyCollection<StructMultiKey<object, object>>.GetEnumerator
	|-ReadOnlyCollection<bool>.GetEnumerator
	|-ReadOnlyCollection<byte>.GetEnumerator
	|-ReadOnlyCollection<Color>.GetEnumerator
	|-ReadOnlyCollection<ControllerPollingInfo>.GetEnumerator
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.GetEnumerator
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.GetEnumerator
	|-ReadOnlyCollection<DateTimeOffset>.GetEnumerator
	|-ReadOnlyCollection<DiscardReasonWithCategory>.GetEnumerator
	|-ReadOnlyCollection<Edge>.GetEnumerator
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.GetEnumerator
	|-ReadOnlyCollection<Guid>.GetEnumerator
	|-ReadOnlyCollection<InputActionSourceData>.GetEnumerator
	|-ReadOnlyCollection<int>.GetEnumerator
	|-ReadOnlyCollection<Int32Enum>.GetEnumerator
	|-ReadOnlyCollection<JsonEncodedText>.GetEnumerator
	|-ReadOnlyCollection<object>.GetEnumerator
	|-ReadOnlyCollection<PidVid>.GetEnumerator
	|-ReadOnlyCollection<ushort>.GetEnumerator
	|-ReadOnlyCollection<ulong>.GetEnumerator
	|-ReadOnlyCollection<Vector2>.GetEnumerator
	|-ReadOnlyCollection<Vector3>.GetEnumerator
	|-ReadOnlyCollection<Vector4>.GetEnumerator
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.GetEnumerator
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB5550 Offset: 0xBB4750 VA: 0x180BB5550
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.IndexOf
	|
	|-RVA: 0xBB5630 Offset: 0xBB4830 VA: 0x180BB5630
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.IndexOf
	|-ReadOnlyCollection<StructMultiKey<object, object>>.IndexOf
	|-ReadOnlyCollection<Color>.IndexOf
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IndexOf
	|-ReadOnlyCollection<DateTimeOffset>.IndexOf
	|-ReadOnlyCollection<DiscardReasonWithCategory>.IndexOf
	|-ReadOnlyCollection<Guid>.IndexOf
	|-ReadOnlyCollection<JsonEncodedText>.IndexOf
	|-ReadOnlyCollection<Vector4>.IndexOf
	|
	|-RVA: 0xBB5700 Offset: 0xBB4900 VA: 0x180BB5700
	|-ReadOnlyCollection<bool>.IndexOf
	|-ReadOnlyCollection<byte>.IndexOf
	|
	|-RVA: 0xBB58A0 Offset: 0xBB4AA0 VA: 0x180BB58A0
	|-ReadOnlyCollection<ControllerPollingInfo>.IndexOf
	|
	|-RVA: 0xBB5D60 Offset: 0xBB4F60 VA: 0x180BB5D60
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IndexOf
	|
	|-RVA: 0xBB5AC0 Offset: 0xBB4CC0 VA: 0x180BB5AC0
	|-ReadOnlyCollection<Edge>.IndexOf
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.IndexOf
	|
	|-RVA: 0xBB5C70 Offset: 0xBB4E70 VA: 0x180BB5C70
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.IndexOf
	|
	|-RVA: 0xBB6080 Offset: 0xBB5280 VA: 0x180BB6080
	|-ReadOnlyCollection<InputActionSourceData>.IndexOf
	|
	|-RVA: 0xBB5A60 Offset: 0xBB4C60 VA: 0x180BB5A60
	|-ReadOnlyCollection<int>.IndexOf
	|-ReadOnlyCollection<Int32Enum>.IndexOf
	|
	|-RVA: 0xBB5990 Offset: 0xBB4B90 VA: 0x180BB5990
	|-ReadOnlyCollection<object>.IndexOf
	|-ReadOnlyCollection<ulong>.IndexOf
	|
	|-RVA: 0xBB5480 Offset: 0xBB4680 VA: 0x180BB5480
	|-ReadOnlyCollection<PidVid>.IndexOf
	|
	|-RVA: 0xBB5FB0 Offset: 0xBB51B0 VA: 0x180BB5FB0
	|-ReadOnlyCollection<ushort>.IndexOf
	|
	|-RVA: 0xBB57D0 Offset: 0xBB49D0 VA: 0x180BB57D0
	|-ReadOnlyCollection<Vector2>.IndexOf
	|
	|-RVA: 0xBB5B90 Offset: 0xBB4D90 VA: 0x180BB5B90
	|-ReadOnlyCollection<Vector3>.IndexOf
	|
	|-RVA: 0xBB5E40 Offset: 0xBB5040 VA: 0x180BB5E40
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	protected IList<T> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.get_Items
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.get_Items
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.get_Items
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.get_Items
	|-ReadOnlyCollection<StructMultiKey<object, object>>.get_Items
	|-ReadOnlyCollection<bool>.get_Items
	|-ReadOnlyCollection<byte>.get_Items
	|-ReadOnlyCollection<Color>.get_Items
	|-ReadOnlyCollection<ControllerPollingInfo>.get_Items
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Items
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Items
	|-ReadOnlyCollection<DateTimeOffset>.get_Items
	|-ReadOnlyCollection<DiscardReasonWithCategory>.get_Items
	|-ReadOnlyCollection<Edge>.get_Items
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.get_Items
	|-ReadOnlyCollection<Guid>.get_Items
	|-ReadOnlyCollection<InputActionSourceData>.get_Items
	|-ReadOnlyCollection<int>.get_Items
	|-ReadOnlyCollection<Int32Enum>.get_Items
	|-ReadOnlyCollection<JsonEncodedText>.get_Items
	|-ReadOnlyCollection<object>.get_Items
	|-ReadOnlyCollection<PidVid>.get_Items
	|-ReadOnlyCollection<ushort>.get_Items
	|-ReadOnlyCollection<ulong>.get_Items
	|-ReadOnlyCollection<Vector2>.get_Items
	|-ReadOnlyCollection<Vector3>.get_Items
	|-ReadOnlyCollection<Vector4>.get_Items
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.get_Items
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.get_Items
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB64C0 Offset: 0xBB56C0 VA: 0x180BB64C0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0xBB6390 Offset: 0xBB5590 VA: 0x180BB6390
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0xBB6460 Offset: 0xBB5660 VA: 0x180BB6460
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0xBB6650 Offset: 0xBB5850 VA: 0x180BB6650
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0xBB65C0 Offset: 0xBB57C0 VA: 0x180BB65C0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0xBB66E0 Offset: 0xBB58E0 VA: 0x180BB66E0
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0xBB6770 Offset: 0xBB5970 VA: 0x180BB6770
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0xBB6540 Offset: 0xBB5740 VA: 0x180BB6540
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0xBB67F0 Offset: 0xBB59F0 VA: 0x180BB67F0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6360 Offset: 0xBB5560 VA: 0x180BB6360
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6360 Offset: 0xBB5560 VA: 0x180BB6360
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6360 Offset: 0xBB5560 VA: 0x180BB6360
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6360 Offset: 0xBB5560 VA: 0x180BB6360
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6370 Offset: 0xBB5570 VA: 0x180BB6370
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6360 Offset: 0xBB5560 VA: 0x180BB6360
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBBFD10 Offset: 0xBBEF10 VA: 0x180BBFD10
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF9A0 Offset: 0xBBEBA0 VA: 0x180BBF9A0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF900 Offset: 0xBBEB00 VA: 0x180BBF900
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFA40 Offset: 0xBBEC40 VA: 0x180BBFA40
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF6D0 Offset: 0xBBE8D0 VA: 0x180BBF6D0
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF630 Offset: 0xBBE830 VA: 0x180BBF630
	|-ReadOnlyCollection<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFB30 Offset: 0xBBED30 VA: 0x180BBFB30
	|-ReadOnlyCollection<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF680 Offset: 0xBBE880 VA: 0x180BBF680
	|-ReadOnlyCollection<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFDB0 Offset: 0xBBEFB0 VA: 0x180BBFDB0
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFE00 Offset: 0xBBF000 VA: 0x180BBFE00
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFEA0 Offset: 0xBBF0A0 VA: 0x180BBFEA0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFB80 Offset: 0xBBED80 VA: 0x180BBFB80
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFA90 Offset: 0xBBEC90 VA: 0x180BBFA90
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF950 Offset: 0xBBEB50 VA: 0x180BBF950
	|-ReadOnlyCollection<Edge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFE50 Offset: 0xBBF050 VA: 0x180BBFE50
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF720 Offset: 0xBBE920 VA: 0x180BBF720
	|-ReadOnlyCollection<Guid>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFAE0 Offset: 0xBBECE0 VA: 0x180BBFAE0
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF7C0 Offset: 0xBBE9C0 VA: 0x180BBF7C0
	|-ReadOnlyCollection<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF860 Offset: 0xBBEA60 VA: 0x180BBF860
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF770 Offset: 0xBBE970 VA: 0x180BBF770
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFD60 Offset: 0xBBEF60 VA: 0x180BBFD60
	|-ReadOnlyCollection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFCC0 Offset: 0xBBEEC0 VA: 0x180BBFCC0
	|-ReadOnlyCollection<PidVid>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF9F0 Offset: 0xBBEBF0 VA: 0x180BBF9F0
	|-ReadOnlyCollection<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFC70 Offset: 0xBBEE70 VA: 0x180BBFC70
	|-ReadOnlyCollection<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFEF0 Offset: 0xBBF0F0 VA: 0x180BBFEF0
	|-ReadOnlyCollection<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF810 Offset: 0xBBEA10 VA: 0x180BBF810
	|-ReadOnlyCollection<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFBD0 Offset: 0xBBEDD0 VA: 0x180BBFBD0
	|-ReadOnlyCollection<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBFC20 Offset: 0xBBEE20 VA: 0x180BBFC20
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBBF8B0 Offset: 0xBBEAB0 VA: 0x180BBF8B0
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Edge>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Guid>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<int>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<PidVid>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBBE4F0 Offset: 0xBBD6F0 VA: 0x180BBE4F0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE730 Offset: 0xBBD930 VA: 0x180BBE730
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBEC70 Offset: 0xBBDE70 VA: 0x180BBEC70
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBF0F0 Offset: 0xBBE2F0 VA: 0x180BBF0F0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBF270 Offset: 0xBBE470 VA: 0x180BBF270
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBF3F0 Offset: 0xBBE5F0 VA: 0x180BBF3F0
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBED30 Offset: 0xBBDF30 VA: 0x180BBED30
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE970 Offset: 0xBBDB70 VA: 0x180BBE970
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBF570 Offset: 0xBBE770 VA: 0x180BBF570
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBEEB0 Offset: 0xBBE0B0 VA: 0x180BBEEB0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBEAF0 Offset: 0xBBDCF0 VA: 0x180BBEAF0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBEDF0 Offset: 0xBBDFF0 VA: 0x180BBEDF0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE1F0 Offset: 0xBBD3F0 VA: 0x180BBE1F0
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBEBB0 Offset: 0xBBDDB0 VA: 0x180BBEBB0
	|-ReadOnlyCollection<Edge>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE430 Offset: 0xBBD630 VA: 0x180BBE430
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE2B0 Offset: 0xBBD4B0 VA: 0x180BBE2B0
	|-ReadOnlyCollection<Guid>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE7F0 Offset: 0xBBD9F0 VA: 0x180BBE7F0
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBF1B0 Offset: 0xBBE3B0 VA: 0x180BBF1B0
	|-ReadOnlyCollection<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBEA30 Offset: 0xBBDC30 VA: 0x180BBEA30
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE370 Offset: 0xBBD570 VA: 0x180BBE370
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBF030 Offset: 0xBBE230 VA: 0x180BBF030
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBEF70 Offset: 0xBBE170 VA: 0x180BBEF70
	|-ReadOnlyCollection<PidVid>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE5B0 Offset: 0xBBD7B0 VA: 0x180BBE5B0
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE670 Offset: 0xBBD870 VA: 0x180BBE670
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBF330 Offset: 0xBBE530 VA: 0x180BBF330
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE130 Offset: 0xBBD330 VA: 0x180BBE130
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE070 Offset: 0xBBD270 VA: 0x180BBE070
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBF4B0 Offset: 0xBBE6B0 VA: 0x180BBF4B0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBBE8B0 Offset: 0xBBDAB0 VA: 0x180BBE8B0
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB74D0 Offset: 0xBB66D0 VA: 0x180BB74D0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB8130 Offset: 0xBB7330 VA: 0x180BB8130
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBB6E0 Offset: 0xBBA8E0 VA: 0x180BBB6E0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB9590 Offset: 0xBB8790 VA: 0x180BB9590
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB68B0 Offset: 0xBB5AB0 VA: 0x180BB68B0
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB6CD0 Offset: 0xBB5ED0 VA: 0x180BB6CD0
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB7D20 Offset: 0xBB6F20 VA: 0x180BB7D20
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBDC50 Offset: 0xBBCE50 VA: 0x180BBDC50
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBCBA0 Offset: 0xBBBDA0 VA: 0x180BBCBA0
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBA200 Offset: 0xBB9400 VA: 0x180BBA200
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBC780 Offset: 0xBBB980 VA: 0x180BBC780
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBBF40 Offset: 0xBBB140 VA: 0x180BBBF40
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBBB20 Offset: 0xBBAD20 VA: 0x180BBBB20
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB99B0 Offset: 0xBB8BB0 VA: 0x180BB99B0
	|-ReadOnlyCollection<Edge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBA650 Offset: 0xBB9850 VA: 0x180BBA650
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBC360 Offset: 0xBBB560 VA: 0x180BBC360
	|-ReadOnlyCollection<Guid>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBD410 Offset: 0xBBC610 VA: 0x180BBD410
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB8D70 Offset: 0xBB7F70 VA: 0x180BB8D70
	|-ReadOnlyCollection<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB7910 Offset: 0xBB6B10 VA: 0x180BB7910
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBAEA0 Offset: 0xBBA0A0 VA: 0x180BBAEA0
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB70E0 Offset: 0xBB62E0 VA: 0x180BB70E0
	|-ReadOnlyCollection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBD840 Offset: 0xBBCA40 VA: 0x180BBD840
	|-ReadOnlyCollection<PidVid>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBAA90 Offset: 0xBB9C90 VA: 0x180BBAA90
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB8960 Offset: 0xBB7B60 VA: 0x180BB8960
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB8550 Offset: 0xBB7750 VA: 0x180BB8550
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBCFE0 Offset: 0xBBC1E0 VA: 0x180BBCFE0
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBBB2C0 Offset: 0xBBA4C0 VA: 0x180BBB2C0
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB9DC0 Offset: 0xBB8FC0 VA: 0x180BB9DC0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBB9180 Offset: 0xBB8380 VA: 0x180BB9180
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Edge>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Guid>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<int>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Edge>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Guid>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<int>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC3520 Offset: 0xBC2720 VA: 0x180BC3520
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBC3390 Offset: 0xBC2590 VA: 0x180BC3390
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Guid>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBC3640 Offset: 0xBC2840 VA: 0x180BC3640
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBC39F0 Offset: 0xBC2BF0 VA: 0x180BC39F0
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBC3940 Offset: 0xBC2B40 VA: 0x180BC3940
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBC35C0 Offset: 0xBC27C0 VA: 0x180BC35C0
	|-ReadOnlyCollection<Edge>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBC3810 Offset: 0xBC2A10 VA: 0x180BC3810
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBC3480 Offset: 0xBC2680 VA: 0x180BC3480
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBC38C0 Offset: 0xBC2AC0 VA: 0x180BC38C0
	|-ReadOnlyCollection<int>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBB6460 Offset: 0xBB5660 VA: 0x180BB6460
	|-ReadOnlyCollection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBC36C0 Offset: 0xBC28C0 VA: 0x180BC36C0
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBC3AB0 Offset: 0xBC2CB0 VA: 0x180BC3AB0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBC3740 Offset: 0xBC2940 VA: 0x180BC3740
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6360 Offset: 0xBB5560 VA: 0x180BB6360
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<bool>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<byte>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Color>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Edge>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Guid>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<int>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<object>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ushort>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ulong>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBBFF40 Offset: 0xBBF140 VA: 0x180BBFF40
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IList.Add
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<bool>.System.Collections.IList.Add
	|-ReadOnlyCollection<byte>.System.Collections.IList.Add
	|-ReadOnlyCollection<Color>.System.Collections.IList.Add
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Add
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Add
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Add
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IList.Add
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Add
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Add
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.Add
	|-ReadOnlyCollection<int>.System.Collections.IList.Add
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Add
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IList.Add
	|-ReadOnlyCollection<object>.System.Collections.IList.Add
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.Add
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Add
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Add
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Add
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Add
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Add
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6360 Offset: 0xBB5560 VA: 0x180BB6360
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<bool>.System.Collections.IList.Clear
	|-ReadOnlyCollection<byte>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Color>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<int>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Clear
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IList.Clear
	|-ReadOnlyCollection<object>.System.Collections.IList.Clear
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Clear
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Clear
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6160 Offset: 0xBB5360 VA: 0x180BB6160
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.IsCompatibleObject
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.IsCompatibleObject
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.IsCompatibleObject
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.IsCompatibleObject
	|-ReadOnlyCollection<StructMultiKey<object, object>>.IsCompatibleObject
	|-ReadOnlyCollection<bool>.IsCompatibleObject
	|-ReadOnlyCollection<byte>.IsCompatibleObject
	|-ReadOnlyCollection<Color>.IsCompatibleObject
	|-ReadOnlyCollection<ControllerPollingInfo>.IsCompatibleObject
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IsCompatibleObject
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IsCompatibleObject
	|-ReadOnlyCollection<DateTimeOffset>.IsCompatibleObject
	|-ReadOnlyCollection<DiscardReasonWithCategory>.IsCompatibleObject
	|-ReadOnlyCollection<Edge>.IsCompatibleObject
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.IsCompatibleObject
	|-ReadOnlyCollection<Guid>.IsCompatibleObject
	|-ReadOnlyCollection<InputActionSourceData>.IsCompatibleObject
	|-ReadOnlyCollection<int>.IsCompatibleObject
	|-ReadOnlyCollection<Int32Enum>.IsCompatibleObject
	|-ReadOnlyCollection<JsonEncodedText>.IsCompatibleObject
	|-ReadOnlyCollection<PidVid>.IsCompatibleObject
	|-ReadOnlyCollection<ushort>.IsCompatibleObject
	|-ReadOnlyCollection<ulong>.IsCompatibleObject
	|-ReadOnlyCollection<Vector2>.IsCompatibleObject
	|-ReadOnlyCollection<Vector3>.IsCompatibleObject
	|-ReadOnlyCollection<Vector4>.IsCompatibleObject
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.IsCompatibleObject
	|
	|-RVA: 0xBB61C0 Offset: 0xBB53C0 VA: 0x180BB61C0
	|-ReadOnlyCollection<object>.IsCompatibleObject
	|
	|-RVA: 0xBB6220 Offset: 0xBB5420 VA: 0x180BB6220
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC0AF0 Offset: 0xBBFCF0 VA: 0x180BC0AF0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC0490 Offset: 0xBBF690 VA: 0x180BC0490
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Color>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Contains
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC07D0 Offset: 0xBBF9D0 VA: 0x180BC07D0
	|-ReadOnlyCollection<bool>.System.Collections.IList.Contains
	|-ReadOnlyCollection<byte>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC10E0 Offset: 0xBC02E0 VA: 0x180BC10E0
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC12D0 Offset: 0xBC04D0 VA: 0x180BC12D0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC0640 Offset: 0xBBF840 VA: 0x180BC0640
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Contains
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC00F0 Offset: 0xBBF2F0 VA: 0x180BC00F0
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC14A0 Offset: 0xBC06A0 VA: 0x180BC14A0
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC0CA0 Offset: 0xBBFEA0 VA: 0x180BC0CA0
	|-ReadOnlyCollection<int>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC0DC0 Offset: 0xBBFFC0 VA: 0x180BC0DC0
	|-ReadOnlyCollection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0xBBFF60 Offset: 0xBBF160 VA: 0x180BBFF60
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC0F50 Offset: 0xBC0150 VA: 0x180BC0F50
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC0960 Offset: 0xBBFB60 VA: 0x180BC0960
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC1780 Offset: 0xBC0980 VA: 0x180BC1780
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC02E0 Offset: 0xBBF4E0 VA: 0x180BC02E0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Contains
	|
	|-RVA: 0xBC1660 Offset: 0xBC0860 VA: 0x180BC1660
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC29E0 Offset: 0xBC1BE0 VA: 0x180BC29E0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC1CC0 Offset: 0xBC0EC0 VA: 0x180BC1CC0
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Color>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Guid>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC2BA0 Offset: 0xBC1DA0 VA: 0x180BC2BA0
	|-ReadOnlyCollection<bool>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<byte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC3000 Offset: 0xBC2200 VA: 0x180BC3000
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC21D0 Offset: 0xBC13D0 VA: 0x180BC21D0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC1930 Offset: 0xBC0B30 VA: 0x180BC1930
	|-ReadOnlyCollection<Edge>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC1AD0 Offset: 0xBC0CD0 VA: 0x180BC1AD0
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC1E70 Offset: 0xBC1070 VA: 0x180BC1E70
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC23A0 Offset: 0xBC15A0 VA: 0x180BC23A0
	|-ReadOnlyCollection<int>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC2E60 Offset: 0xBC2060 VA: 0x180BC2E60
	|-ReadOnlyCollection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC31F0 Offset: 0xBC23F0 VA: 0x180BC31F0
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC2030 Offset: 0xBC1230 VA: 0x180BC2030
	|-ReadOnlyCollection<ushort>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC24D0 Offset: 0xBC16D0 VA: 0x180BC24D0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC2670 Offset: 0xBC1870 VA: 0x180BC2670
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC2830 Offset: 0xBC1A30 VA: 0x180BC2830
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBC2D40 Offset: 0xBC1F40 VA: 0x180BC2D40
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6360 Offset: 0xBB5560 VA: 0x180BB6360
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<bool>.System.Collections.IList.Insert
	|-ReadOnlyCollection<byte>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Color>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<int>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Insert
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IList.Insert
	|-ReadOnlyCollection<object>.System.Collections.IList.Insert
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Insert
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6360 Offset: 0xBB5560 VA: 0x180BB6360
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<bool>.System.Collections.IList.Remove
	|-ReadOnlyCollection<byte>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Color>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<int>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Remove
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IList.Remove
	|-ReadOnlyCollection<object>.System.Collections.IList.Remove
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Remove
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB6360 Offset: 0xBB5560 VA: 0x180BB6360
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<bool>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<byte>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Color>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DiscardReasonWithCategory>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Edge>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Guid>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<int>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<JsonEncodedText>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<object>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ushort>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ulong>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.System.Collections.IList.RemoveAt
	*/
}

// Namespace: System.Collections.ObjectModel
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[Serializable]
public abstract class KeyedCollection<TKey, TItem> : Collection<TItem> // TypeDefIndex: 4421
{
	// Fields
	private readonly IEqualityComparer<TKey> comparer; // 0x0
	private Dictionary<TKey, TItem> dict; // 0x0
	private int keyCount; // 0x0
	private readonly int threshold; // 0x0

	// Properties
	private List<TItem> Items { get; }
	public TItem Item { get; }
	protected IDictionary<TKey, TItem> Dictionary { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317FA0 Offset: 0x13171A0 VA: 0x181317FA0
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x10CBBE0 Offset: 0x10CADE0 VA: 0x1810CBBE0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317BF0 Offset: 0x1316DF0 VA: 0x181317BF0
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x10CCB00 Offset: 0x10CBD00 VA: 0x1810CCB00
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317DA0 Offset: 0x1316FA0 VA: 0x181317DA0
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x1317FC0 Offset: 0x13171C0 VA: 0x181317FC0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private List<TItem> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13184E0 Offset: 0x13176E0 VA: 0x1813184E0
	|-KeyedCollection<object, object>.get_Items
	|
	|-RVA: 0x1318430 Offset: 0x1317630 VA: 0x181318430
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1
	public TItem get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1318370 Offset: 0x1317570 VA: 0x181318370
	|-KeyedCollection<object, object>.get_Item
	|
	|-RVA: 0x13180F0 Offset: 0x13172F0 VA: 0x1813180F0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1315760 Offset: 0x1314960 VA: 0x181315760
	|-KeyedCollection<object, object>.Contains
	|
	|-RVA: 0x13151B0 Offset: 0x13143B0 VA: 0x1813151B0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13172C0 Offset: 0x13164C0 VA: 0x1813172C0
	|-KeyedCollection<object, object>.TryGetValue
	|
	|-RVA: 0x1317550 Offset: 0x1316750 VA: 0x181317550
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	protected IDictionary<TKey, TItem> get_Dictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-KeyedCollection<object, object>.get_Dictionary
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Dictionary
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected override void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1315140 Offset: 0x1314340 VA: 0x181315140
	|-KeyedCollection<object, object>.ClearItems
	|
	|-RVA: 0x13150D0 Offset: 0x13142D0 VA: 0x1813150D0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract TKey GetKeyForItem(TItem item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeyForItem
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected override void InsertItem(int index, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1316140 Offset: 0x1315340 VA: 0x181316140
	|-KeyedCollection<object, object>.InsertItem
	|
	|-RVA: 0x13161D0 Offset: 0x13153D0 VA: 0x1813161D0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected override void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13164C0 Offset: 0x13156C0 VA: 0x1813164C0
	|-KeyedCollection<object, object>.RemoveItem
	|
	|-RVA: 0x1316630 Offset: 0x1315830 VA: 0x181316630
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected override void SetItem(int index, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13169C0 Offset: 0x1315BC0 VA: 0x1813169C0
	|-KeyedCollection<object, object>.SetItem
	|
	|-RVA: 0x1316BF0 Offset: 0x1315DF0 VA: 0x181316BF0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1
	private void AddKey(TKey key, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1314FB0 Offset: 0x13141B0 VA: 0x181314FB0
	|-KeyedCollection<object, object>.AddKey
	|
	|-RVA: 0x1314CB0 Offset: 0x1313EB0 VA: 0x181314CB0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddKey
	*/

	// RVA: -1 Offset: -1
	private void CreateDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13159D0 Offset: 0x1314BD0 VA: 0x1813159D0
	|-KeyedCollection<object, object>.CreateDictionary
	|
	|-RVA: 0x1315C30 Offset: 0x1314E30 VA: 0x181315C30
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDictionary
	*/

	// RVA: -1 Offset: -1
	private void RemoveKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1316890 Offset: 0x1315A90 VA: 0x181316890
	|-KeyedCollection<object, object>.RemoveKey
	|
	|-RVA: 0x13168D0 Offset: 0x1315AD0 VA: 0x1813168D0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveKey
	*/
}

// Namespace: 
[Serializable]
private struct ReadOnlyDictionary.DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 4422
{
	// Fields
	private readonly IDictionary<TKey, TValue> _dictionary; // 0x0
	private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCA1B0 Offset: 0xFC93B0 VA: 0x180FCA1B0
	|-ReadOnlyDictionary.DictionaryEnumerator<DiscardReasonWithCategory, int>..ctor
	|-ReadOnlyDictionary.DictionaryEnumerator<object, int>..ctor
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>..ctor
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCAF40 Offset: 0xFCA140 VA: 0x180FCAF40
	|-ReadOnlyDictionary.DictionaryEnumerator<DiscardReasonWithCategory, int>.get_Entry
	|
	|-RVA: 0xFCBE10 Offset: 0xFCB010 VA: 0x180FCBE10
	|-ReadOnlyDictionary.DictionaryEnumerator<object, int>.get_Entry
	|
	|-RVA: 0xFCB610 Offset: 0xFCA810 VA: 0x180FCB610
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Entry
	|
	|-RVA: 0xFCABF0 Offset: 0xFC9DF0 VA: 0x180FCABF0
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCC230 Offset: 0xFCB430 VA: 0x180FCC230
	|-ReadOnlyDictionary.DictionaryEnumerator<DiscardReasonWithCategory, int>.get_Key
	|
	|-RVA: 0xFCC420 Offset: 0xFCB620 VA: 0x180FCC420
	|-ReadOnlyDictionary.DictionaryEnumerator<object, int>.get_Key
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Key
	|
	|-RVA: 0xFCC520 Offset: 0xFCB720 VA: 0x180FCC520
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCD020 Offset: 0xFCC220 VA: 0x180FCD020
	|-ReadOnlyDictionary.DictionaryEnumerator<DiscardReasonWithCategory, int>.get_Value
	|
	|-RVA: 0xFCCE10 Offset: 0xFCC010 VA: 0x180FCCE10
	|-ReadOnlyDictionary.DictionaryEnumerator<object, int>.get_Value
	|
	|-RVA: 0xFCCD10 Offset: 0xFCBF10 VA: 0x180FCCD10
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Value
	|
	|-RVA: 0xFCC890 Offset: 0xFCBA90 VA: 0x180FCC890
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCA5A0 Offset: 0xFC97A0 VA: 0x180FCA5A0
	|-ReadOnlyDictionary.DictionaryEnumerator<DiscardReasonWithCategory, int>.get_Current
	|
	|-RVA: 0xFCAB70 Offset: 0xFC9D70 VA: 0x180FCAB70
	|-ReadOnlyDictionary.DictionaryEnumerator<object, int>.get_Current
	|
	|-RVA: 0xFCA7B0 Offset: 0xFC99B0 VA: 0x180FCA7B0
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Current
	|
	|-RVA: 0xFCA620 Offset: 0xFC9820 VA: 0x180FCA620
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC9C90 Offset: 0xFC8E90 VA: 0x180FC9C90
	|-ReadOnlyDictionary.DictionaryEnumerator<DiscardReasonWithCategory, int>.MoveNext
	|
	|-RVA: 0xFC9970 Offset: 0xFC8B70 VA: 0x180FC9970
	|-ReadOnlyDictionary.DictionaryEnumerator<object, int>.MoveNext
	|
	|-RVA: 0xFC9BF0 Offset: 0xFC8DF0 VA: 0x180FC9BF0
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.MoveNext
	|
	|-RVA: 0xFC9CE0 Offset: 0xFC8EE0 VA: 0x180FC9CE0
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC9EC0 Offset: 0xFC90C0 VA: 0x180FC9EC0
	|-ReadOnlyDictionary.DictionaryEnumerator<DiscardReasonWithCategory, int>.Reset
	|
	|-RVA: 0xFCA000 Offset: 0xFC9200 VA: 0x180FCA000
	|-ReadOnlyDictionary.DictionaryEnumerator<object, int>.Reset
	|
	|-RVA: 0xFC9E70 Offset: 0xFC9070 VA: 0x180FC9E70
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.Reset
	|
	|-RVA: 0xFC9D30 Offset: 0xFC8F30 VA: 0x180FC9D30
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/
}

// Namespace: 
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[Serializable]
public sealed class ReadOnlyDictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 4423
{
	// Fields
	private readonly ICollection<TKey> _collection; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ICollection<TKey> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04180 Offset: 0xD03380 VA: 0x180D04180
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>..ctor
	|-ReadOnlyDictionary.KeyCollection<object, int>..ctor
	|-ReadOnlyDictionary.KeyCollection<object, object>..ctor
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF30 Offset: 0xBCA130 VA: 0x180BCAF30
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TKey>.Add
	|-ReadOnlyDictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Add
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF80 Offset: 0xBCA180 VA: 0x180BCAF80
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|-ReadOnlyDictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAC80 Offset: 0xBC9E80 VA: 0x180BCAC80
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0xBCAC20 Offset: 0xBC9E20 VA: 0x180BCAC20
	|-ReadOnlyDictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0xD06540 Offset: 0xD05740 VA: 0x180D06540
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7550 Offset: 0xCF6750 VA: 0x180CF7550
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.CopyTo
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x12F9B60 Offset: 0x12F8D60 VA: 0x1812F9B60
	|-ReadOnlyDictionary.KeyCollection<object, int>.CopyTo
	|-ReadOnlyDictionary.KeyCollection<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD12140 Offset: 0xD11340 VA: 0x180D12140
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.get_Count
	|-ReadOnlyDictionary.KeyCollection<object, int>.get_Count
	|-ReadOnlyDictionary.KeyCollection<object, object>.get_Count
	|
	|-RVA: 0xD04290 Offset: 0xD03490 VA: 0x180D04290
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-ReadOnlyDictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF30 Offset: 0xBCA130 VA: 0x180BCAF30
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|-ReadOnlyDictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7DD0 Offset: 0xCF6FD0 VA: 0x180CF7DD0
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.GetEnumerator
	|-ReadOnlyDictionary.KeyCollection<object, int>.GetEnumerator
	|-ReadOnlyDictionary.KeyCollection<object, object>.GetEnumerator
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1307710 Offset: 0x1306910 VA: 0x181307710
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1307760 Offset: 0x1306960 VA: 0x181307760
	|-ReadOnlyDictionary.KeyCollection<object, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13076C0 Offset: 0x13068C0 VA: 0x1813076C0
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13109B0 Offset: 0x130FBB0 VA: 0x1813109B0
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12FF710 Offset: 0x12FE910 VA: 0x1812FF710
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD09700 Offset: 0xD08900 VA: 0x180D09700
	|-ReadOnlyDictionary.KeyCollection<object, int>.System.Collections.ICollection.CopyTo
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0D1A0 Offset: 0xD0C3A0 VA: 0x180D0D1A0
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyDictionary.KeyCollection<object, int>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1306CD0 Offset: 0x1305ED0 VA: 0x181306CD0
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306F20 Offset: 0x1306120 VA: 0x181306F20
	|-ReadOnlyDictionary.KeyCollection<object, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13069E0 Offset: 0x1305BE0 VA: 0x1813069E0
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13103F0 Offset: 0x130F5F0 VA: 0x1813103F0
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04170 Offset: 0xD03370 VA: 0x180D04170
	|-ReadOnlyDictionary.KeyCollection<DiscardReasonWithCategory, int>..ctor
	|-ReadOnlyDictionary.KeyCollection<object, int>..ctor
	|-ReadOnlyDictionary.KeyCollection<object, object>..ctor
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[Serializable]
public sealed class ReadOnlyDictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 4424
{
	// Fields
	private readonly ICollection<TValue> _collection; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ICollection<TValue> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04180 Offset: 0xD03380 VA: 0x180D04180
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>..ctor
	|-ReadOnlyDictionary.ValueCollection<object, int>..ctor
	|-ReadOnlyDictionary.ValueCollection<object, object>..ctor
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF30 Offset: 0xBCA130 VA: 0x180BCAF30
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-ReadOnlyDictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF80 Offset: 0xBCA180 VA: 0x180BCAF80
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-ReadOnlyDictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF8180 Offset: 0xCF7380 VA: 0x180CF8180
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|-ReadOnlyDictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06720 Offset: 0xD05920 VA: 0x180D06720
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06540 Offset: 0xD05740 VA: 0x180D06540
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7550 Offset: 0xCF6750 VA: 0x180CF7550
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.CopyTo
	|-ReadOnlyDictionary.ValueCollection<object, int>.CopyTo
	|-ReadOnlyDictionary.ValueCollection<object, object>.CopyTo
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04290 Offset: 0xD03490 VA: 0x180D04290
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.get_Count
	|
	|-RVA: 0xD12140 Offset: 0xD11340 VA: 0x180D12140
	|-ReadOnlyDictionary.ValueCollection<object, int>.get_Count
	|-ReadOnlyDictionary.ValueCollection<object, object>.get_Count
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-ReadOnlyDictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF30 Offset: 0xBCA130 VA: 0x180BCAF30
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-ReadOnlyDictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7DD0 Offset: 0xCF6FD0 VA: 0x180CF7DD0
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.GetEnumerator
	|-ReadOnlyDictionary.ValueCollection<object, int>.GetEnumerator
	|-ReadOnlyDictionary.ValueCollection<object, object>.GetEnumerator
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD040E0 Offset: 0xD032E0 VA: 0x180D040E0
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD11FB0 Offset: 0xD111B0 VA: 0x180D11FB0
	|-ReadOnlyDictionary.ValueCollection<object, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD12000 Offset: 0xD11200 VA: 0x180D12000
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD12050 Offset: 0xD11250 VA: 0x180D12050
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFFA80 Offset: 0xCFEC80 VA: 0x180CFFA80
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.CopyTo
	|-ReadOnlyDictionary.ValueCollection<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD09700 Offset: 0xD08900 VA: 0x180D09700
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0D1A0 Offset: 0xD0C3A0 VA: 0x180D0D1A0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyDictionary.ValueCollection<object, int>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD03B70 Offset: 0xD02D70 VA: 0x180D03B70
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD10F10 Offset: 0xD10110 VA: 0x180D10F10
	|-ReadOnlyDictionary.ValueCollection<object, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11160 Offset: 0xD10360 VA: 0x180D11160
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD113B0 Offset: 0xD105B0 VA: 0x180D113B0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04170 Offset: 0xD03370 VA: 0x180D04170
	|-ReadOnlyDictionary.ValueCollection<DiscardReasonWithCategory, int>..ctor
	|-ReadOnlyDictionary.ValueCollection<object, int>..ctor
	|-ReadOnlyDictionary.ValueCollection<object, object>..ctor
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Collections.ObjectModel
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(DictionaryDebugView<K, V>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 4425
{
	// Fields
	private readonly IDictionary<TKey, TValue> m_dictionary; // 0x0
	private object _syncRoot; // 0x0
	private ReadOnlyDictionary.KeyCollection<TKey, TValue> _keys; // 0x0
	private ReadOnlyDictionary.ValueCollection<TKey, TValue> _values; // 0x0

	// Properties
	public ReadOnlyDictionary.KeyCollection<TKey, TValue> Keys { get; }
	public ReadOnlyDictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	public TValue Item { get; }
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item { get; set; }
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCECF0 Offset: 0xBCDEF0 VA: 0x180BCECF0
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>..ctor
	|-ReadOnlyDictionary<object, int>..ctor
	|-ReadOnlyDictionary<object, object>..ctor
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyDictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCEE90 Offset: 0xBCE090 VA: 0x180BCEE90
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.get_Keys
	|-ReadOnlyDictionary<object, int>.get_Keys
	|-ReadOnlyDictionary<object, object>.get_Keys
	|
	|-RVA: 0xBCEDC0 Offset: 0xBCDFC0 VA: 0x180BCEDC0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyDictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCEF60 Offset: 0xBCE160 VA: 0x180BCEF60
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.get_Values
	|-ReadOnlyDictionary<object, int>.get_Values
	|-ReadOnlyDictionary<object, object>.get_Values
	|
	|-RVA: 0xBCF030 Offset: 0xBCE230 VA: 0x180BCF030
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAC80 Offset: 0xBC9E80 VA: 0x180BCAC80
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.ContainsKey
	|
	|-RVA: 0xBCAC20 Offset: 0xBC9E20 VA: 0x180BCAC20
	|-ReadOnlyDictionary<object, int>.ContainsKey
	|-ReadOnlyDictionary<object, object>.ContainsKey
	|
	|-RVA: 0xBCAD50 Offset: 0xBC9F50 VA: 0x180BCAD50
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB570 Offset: 0xBCA770 VA: 0x180BCB570
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xBCB590 Offset: 0xBCA790 VA: 0x180BCB590
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCEC10 Offset: 0xBCDE10 VA: 0x180BCEC10
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.TryGetValue
	|
	|-RVA: 0xBCEB40 Offset: 0xBCDD40 VA: 0x180BCEB40
	|-ReadOnlyDictionary<object, int>.TryGetValue
	|-ReadOnlyDictionary<object, object>.TryGetValue
	|
	|-RVA: 0xBCE9C0 Offset: 0xBCDBC0 VA: 0x180BCE9C0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB5B0 Offset: 0xBCA7B0 VA: 0x180BCB5B0
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xBCB5D0 Offset: 0xBCA7D0 VA: 0x180BCB5D0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB360 Offset: 0xBCA560 VA: 0x180BCB360
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.get_Item
	|
	|-RVA: 0xBCB300 Offset: 0xBCA500 VA: 0x180BCB300
	|-ReadOnlyDictionary<object, int>.get_Item
	|-ReadOnlyDictionary<object, object>.get_Item
	|
	|-RVA: 0xBCB430 Offset: 0xBCA630 VA: 0x180BCB430
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB2B0 Offset: 0xBCA4B0 VA: 0x180BCB2B0
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF30 Offset: 0xBCA130 VA: 0x180BCAF30
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB360 Offset: 0xBCA560 VA: 0x180BCB360
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|
	|-RVA: 0xBCB300 Offset: 0xBCA500 VA: 0x180BCB300
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|
	|-RVA: 0xBCB430 Offset: 0xBCA630 VA: 0x180BCB430
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB2B0 Offset: 0xBCA4B0 VA: 0x180BCB2B0
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCED70 Offset: 0xBCDF70 VA: 0x180BCED70
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.get_Count
	|-ReadOnlyDictionary<object, int>.get_Count
	|-ReadOnlyDictionary<object, object>.get_Count
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB160 Offset: 0xBCA360 VA: 0x180BCB160
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xBCAFD0 Offset: 0xBCA1D0 VA: 0x180BCAFD0
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xBCB0A0 Offset: 0xBCA2A0 VA: 0x180BCB0A0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB240 Offset: 0xBCA440 VA: 0x180BCB240
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF30 Offset: 0xBCA130 VA: 0x180BCAF30
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF80 Offset: 0xBCA180 VA: 0x180BCAF80
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF30 Offset: 0xBCA130 VA: 0x180BCAF30
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAE40 Offset: 0xBCA040 VA: 0x180BCAE40
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.GetEnumerator
	|-ReadOnlyDictionary<object, int>.GetEnumerator
	|-ReadOnlyDictionary<object, object>.GetEnumerator
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCE8D0 Offset: 0xBCDAD0 VA: 0x180BCE8D0
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBCE970 Offset: 0xBCDB70 VA: 0x180BCE970
	|-ReadOnlyDictionary<object, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBCE880 Offset: 0xBCDA80 VA: 0x180BCE880
	|-ReadOnlyDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBCE920 Offset: 0xBCDB20 VA: 0x180BCE920
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAE90 Offset: 0xBCA090 VA: 0x180BCAE90
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.IsCompatibleKey
	|-ReadOnlyDictionary<object, int>.IsCompatibleKey
	|-ReadOnlyDictionary<object, object>.IsCompatibleKey
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB2B0 Offset: 0xBCA4B0 VA: 0x180BCB2B0
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IDictionary.Add
	|-ReadOnlyDictionary<object, int>.System.Collections.IDictionary.Add
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.Add
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IDictionary.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF80 Offset: 0xBCA180 VA: 0x180BCAF80
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IDictionary.Clear
	|-ReadOnlyDictionary<object, int>.System.Collections.IDictionary.Clear
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.Clear
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCDD50 Offset: 0xBCCF50 VA: 0x180BCDD50
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xBCDBE0 Offset: 0xBCCDE0 VA: 0x180BCDBE0
	|-ReadOnlyDictionary<object, int>.System.Collections.IDictionary.Contains
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xBCDAC0 Offset: 0xBCCCC0 VA: 0x180BCDAC0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCE160 Offset: 0xBCD360 VA: 0x180BCE160
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xBCE0A0 Offset: 0xBCD2A0 VA: 0x180BCE0A0
	|-ReadOnlyDictionary<object, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xBCDFE0 Offset: 0xBCD1E0 VA: 0x180BCDFE0
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xBCDF20 Offset: 0xBCD120 VA: 0x180BCDF20
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IDictionary.get_IsFixedSize
	|-ReadOnlyDictionary<object, int>.System.Collections.IDictionary.get_IsFixedSize
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IDictionary.get_IsReadOnly
	|-ReadOnlyDictionary<object, int>.System.Collections.IDictionary.get_IsReadOnly
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB570 Offset: 0xBCA770 VA: 0x180BCB570
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IDictionary.get_Keys
	|-ReadOnlyDictionary<object, int>.System.Collections.IDictionary.get_Keys
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xBCB590 Offset: 0xBCA790 VA: 0x180BCB590
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCAF30 Offset: 0xBCA130 VA: 0x180BCAF30
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IDictionary.Remove
	|-ReadOnlyDictionary<object, int>.System.Collections.IDictionary.Remove
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.Remove
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB5B0 Offset: 0xBCA7B0 VA: 0x180BCB5B0
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IDictionary.get_Values
	|-ReadOnlyDictionary<object, int>.System.Collections.IDictionary.get_Values
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xBCB5D0 Offset: 0xBCA7D0 VA: 0x180BCB5D0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCE690 Offset: 0xBCD890 VA: 0x180BCE690
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xBCE390 Offset: 0xBCD590 VA: 0x180BCE390
	|-ReadOnlyDictionary<object, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xBCE220 Offset: 0xBCD420 VA: 0x180BCE220
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xBCE520 Offset: 0xBCD720 VA: 0x180BCE520
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB2B0 Offset: 0xBCA4B0 VA: 0x180BCB2B0
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.IDictionary.set_Item
	|-ReadOnlyDictionary<object, int>.System.Collections.IDictionary.set_Item
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.set_Item
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCD020 Offset: 0xBCC220 VA: 0x180BCD020
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBCBDF0 Offset: 0xBCAFF0 VA: 0x180BCBDF0
	|-ReadOnlyDictionary<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBCB5F0 Offset: 0xBCA7F0 VA: 0x180BCB5F0
	|-ReadOnlyDictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBCC620 Offset: 0xBCB820 VA: 0x180BCC620
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyDictionary<object, int>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCD940 Offset: 0xBCCB40 VA: 0x180BCD940
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBCD880 Offset: 0xBCCA80 VA: 0x180BCD880
	|-ReadOnlyDictionary<object, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBCD7C0 Offset: 0xBCC9C0 VA: 0x180BCD7C0
	|-ReadOnlyDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBCDA00 Offset: 0xBCCC00 VA: 0x180BCDA00
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB570 Offset: 0xBCA770 VA: 0x180BCB570
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xBCB590 Offset: 0xBCA790 VA: 0x180BCB590
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB5B0 Offset: 0xBCA7B0 VA: 0x180BCB5B0
	|-ReadOnlyDictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-ReadOnlyDictionary<object, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xBCB5D0 Offset: 0xBCA7D0 VA: 0x180BCB5D0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/
}

// Namespace: System.Collections.ObjectModel
internal static class ReadOnlyDictionaryHelpers // TypeDefIndex: 4426
{
	// Methods

	// RVA: -1 Offset: -1
	internal static void CopyToNonGenericICollectionHelper<T>(ICollection<T> collection, Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5D5F0 Offset: 0xA5C7F0 VA: 0x180A5D5F0
	|-ReadOnlyDictionaryHelpers.CopyToNonGenericICollectionHelper<DiscardReasonWithCategory>
	|
	|-RVA: 0xA5E230 Offset: 0xA5D430 VA: 0x180A5E230
	|-ReadOnlyDictionaryHelpers.CopyToNonGenericICollectionHelper<int>
	|
	|-RVA: 0xA5E780 Offset: 0xA5D980 VA: 0x180A5E780
	|-ReadOnlyDictionaryHelpers.CopyToNonGenericICollectionHelper<object>
	|
	|-RVA: 0xA5DBB0 Offset: 0xA5CDB0 VA: 0x180A5DBB0
	|-ReadOnlyDictionaryHelpers.CopyToNonGenericICollectionHelper<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Collections.Generic
internal enum InsertionBehavior // TypeDefIndex: 4427
{
	// Fields
	public byte value__; // 0x0
	public const InsertionBehavior None = 0;
	public const InsertionBehavior OverwriteExisting = 1;
	public const InsertionBehavior ThrowOnExisting = 2;
}

// Namespace: 
private struct Dictionary.Entry<TKey, TValue> // TypeDefIndex: 4428
{
	// Fields
	public int hashCode; // 0x0
	public int next; // 0x0
	public TKey key; // 0x0
	public TValue value; // 0x0
}

// Namespace: 
[Serializable]
public struct Dictionary.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 4429
{
	// Fields
	private Dictionary<TKey, TValue> _dictionary; // 0x0
	private int _version; // 0x0
	private int _index; // 0x0
	private KeyValuePair<TKey, TValue> _current; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1116BF0 Offset: 0x1115DF0 VA: 0x181116BF0
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>..ctor
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>..ctor
	|-Dictionary.Enumerator<Color, object>..ctor
	|-Dictionary.Enumerator<DiscardReasonWithCategory, int>..ctor
	|-Dictionary.Enumerator<Guid, object>..ctor
	|-Dictionary.Enumerator<int, TreeItem>..ctor
	|-Dictionary.Enumerator<IntVec3, object>..ctor
	|-Dictionary.Enumerator<object, ResourceLocator>..ctor
	|-Dictionary.Enumerator<object, StylePropertyValue>..ctor
	|-Dictionary.Enumerator<object, XPathNodeRef>..ctor
	|-Dictionary.Enumerator<uint, VirtualHeap.PinnedBlob>..ctor
	|-Dictionary.Enumerator<ulong, Helper.PinnedBuffer>..ctor
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x1116AA0 Offset: 0x1115CA0 VA: 0x181116AA0
	|-Dictionary.Enumerator<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0x1116AE0 Offset: 0x1115CE0 VA: 0x181116AE0
	|-Dictionary.Enumerator<byte, bool>..ctor
	|-Dictionary.Enumerator<byte, byte>..ctor
	|
	|-RVA: 0x1116B10 Offset: 0x1115D10 VA: 0x181116B10
	|-Dictionary.Enumerator<byte, int>..ctor
	|-Dictionary.Enumerator<ByteEnum, Int32Enum>..ctor
	|-Dictionary.Enumerator<ByteEnum, float>..ctor
	|-Dictionary.Enumerator<char, int>..ctor
	|-Dictionary.Enumerator<int, bool>..ctor
	|-Dictionary.Enumerator<int, char>..ctor
	|-Dictionary.Enumerator<int, int>..ctor
	|-Dictionary.Enumerator<int, Int32Enum>..ctor
	|-Dictionary.Enumerator<int, float>..ctor
	|-Dictionary.Enumerator<Int32Enum, bool>..ctor
	|-Dictionary.Enumerator<Int32Enum, HatOptions>..ctor
	|-Dictionary.Enumerator<Int32Enum, int>..ctor
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>..ctor
	|-Dictionary.Enumerator<Int32Enum, SkinOptions>..ctor
	|-Dictionary.Enumerator<Int32Enum, uint>..ctor
	|-Dictionary.Enumerator<Int32Enum, VisorOptions>..ctor
	|-Dictionary.Enumerator<UInt16Enum, uint>..ctor
	|-Dictionary.Enumerator<uint, int>..ctor
	|
	|-RVA: 0x1116CF0 Offset: 0x1115EF0 VA: 0x181116CF0
	|-Dictionary.Enumerator<byte, object>..ctor
	|-Dictionary.Enumerator<ByteEnum, object>..ctor
	|-Dictionary.Enumerator<DateTime, object>..ctor
	|-Dictionary.Enumerator<int, long>..ctor
	|-Dictionary.Enumerator<int, object>..ctor
	|-Dictionary.Enumerator<Int32Enum, object>..ctor
	|-Dictionary.Enumerator<long, Int32Enum>..ctor
	|-Dictionary.Enumerator<long, object>..ctor
	|-Dictionary.Enumerator<IntPtr, object>..ctor
	|-Dictionary.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|-Dictionary.Enumerator<object, bool>..ctor
	|-Dictionary.Enumerator<object, Color32>..ctor
	|-Dictionary.Enumerator<object, int>..ctor
	|-Dictionary.Enumerator<object, Int32Enum>..ctor
	|-Dictionary.Enumerator<object, object>..ctor
	|-Dictionary.Enumerator<object, float>..ctor
	|-Dictionary.Enumerator<object, TextureId>..ctor
	|-Dictionary.Enumerator<object, TimeSpan>..ctor
	|-Dictionary.Enumerator<object, uint>..ctor
	|-Dictionary.Enumerator<object, ulong>..ctor
	|-Dictionary.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-Dictionary.Enumerator<object, StyleComplexSelector.PseudoStateData>..ctor
	|-Dictionary.Enumerator<TerrainTileCoord, object>..ctor
	|-Dictionary.Enumerator<UInt16Enum, object>..ctor
	|-Dictionary.Enumerator<uint, object>..ctor
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x1116CC0 Offset: 0x1115EC0 VA: 0x181116CC0
	|-Dictionary.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|
	|-RVA: 0x1120060 Offset: 0x111F260 VA: 0x181120060
	|-Dictionary.Enumerator<Guid, int>..ctor
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>..ctor
	|-Dictionary.Enumerator<Int32Enum, Color>..ctor
	|
	|-RVA: 0x11200D0 Offset: 0x111F2D0 VA: 0x1811200D0
	|-Dictionary.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-Dictionary.Enumerator<UInt16Enum, RoleRate>..ctor
	|-Dictionary.Enumerator<Vector2, Int32Enum>..ctor
	|
	|-RVA: 0x1120020 Offset: 0x111F220 VA: 0x181120020
	|-Dictionary.Enumerator<int, TreeViewItemData<object>>..ctor
	|-Dictionary.Enumerator<object, AsyncOperationHandle>..ctor
	|-Dictionary.Enumerator<ulong, Helper.Allocation>..ctor
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>..ctor
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x11201E0 Offset: 0x111F3E0 VA: 0x1811201E0
	|-Dictionary.Enumerator<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x1126860 Offset: 0x1125A60 VA: 0x181126860
	|-Dictionary.Enumerator<int, TextResourceManager.FontAssetRef>..ctor
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x1126720 Offset: 0x1125920 VA: 0x181126720
	|-Dictionary.Enumerator<long, ComputedStyle>..ctor
	|
	|-RVA: 0x112CEF0 Offset: 0x112C0F0 VA: 0x18112CEF0
	|-Dictionary.Enumerator<uint, GlyphPairAdjustmentRecord>..ctor
	|-Dictionary.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|
	|-RVA: 0x112D480 Offset: 0x112C680 VA: 0x18112D480
	|-Dictionary.Enumerator<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary.Enumerator<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x113E2A0 Offset: 0x113D4A0 VA: 0x18113E2A0
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11130A0 Offset: 0x11122A0 VA: 0x1811130A0
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.MoveNext
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.MoveNext
	|-Dictionary.Enumerator<Color, object>.MoveNext
	|-Dictionary.Enumerator<Guid, object>.MoveNext
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.MoveNext
	|
	|-RVA: 0x11133C0 Offset: 0x11125C0 VA: 0x1811133C0
	|-Dictionary.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.MoveNext
	|
	|-RVA: 0x1112AC0 Offset: 0x1111CC0 VA: 0x181112AC0
	|-Dictionary.Enumerator<byte, bool>.MoveNext
	|-Dictionary.Enumerator<byte, byte>.MoveNext
	|
	|-RVA: 0x11136C0 Offset: 0x11128C0 VA: 0x1811136C0
	|-Dictionary.Enumerator<byte, int>.MoveNext
	|-Dictionary.Enumerator<ByteEnum, Int32Enum>.MoveNext
	|
	|-RVA: 0x1112BD0 Offset: 0x1111DD0 VA: 0x181112BD0
	|-Dictionary.Enumerator<byte, object>.MoveNext
	|-Dictionary.Enumerator<ByteEnum, object>.MoveNext
	|
	|-RVA: 0x1112990 Offset: 0x1111B90 VA: 0x181112990
	|-Dictionary.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.MoveNext
	|
	|-RVA: 0x1113BE0 Offset: 0x1112DE0 VA: 0x181113BE0
	|-Dictionary.Enumerator<ByteEnum, float>.MoveNext
	|
	|-RVA: 0x1118C20 Offset: 0x1117E20 VA: 0x181118C20
	|-Dictionary.Enumerator<char, int>.MoveNext
	|-Dictionary.Enumerator<UInt16Enum, uint>.MoveNext
	|
	|-RVA: 0x1119A10 Offset: 0x1118C10 VA: 0x181119A10
	|-Dictionary.Enumerator<DateTime, object>.MoveNext
	|-Dictionary.Enumerator<TerrainTileCoord, object>.MoveNext
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.MoveNext
	|
	|-RVA: 0x1118E40 Offset: 0x1118040 VA: 0x181118E40
	|-Dictionary.Enumerator<DiscardReasonWithCategory, int>.MoveNext
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.MoveNext
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.MoveNext
	|
	|-RVA: 0x1119440 Offset: 0x1118640 VA: 0x181119440
	|-Dictionary.Enumerator<Guid, int>.MoveNext
	|
	|-RVA: 0x1118B00 Offset: 0x1117D00 VA: 0x181118B00
	|-Dictionary.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.MoveNext
	|
	|-RVA: 0x1119B20 Offset: 0x1118D20 VA: 0x181119B20
	|-Dictionary.Enumerator<int, TreeViewItemData<object>>.MoveNext
	|
	|-RVA: 0x11190A0 Offset: 0x11182A0 VA: 0x1811190A0
	|-Dictionary.Enumerator<int, bool>.MoveNext
	|-Dictionary.Enumerator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x1117980 Offset: 0x1116B80 VA: 0x181117980
	|-Dictionary.Enumerator<int, char>.MoveNext
	|
	|-RVA: 0x11177E0 Offset: 0x11169E0 VA: 0x1811177E0
	|-Dictionary.Enumerator<int, DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x1118D30 Offset: 0x1117F30 VA: 0x181118D30
	|-Dictionary.Enumerator<int, int>.MoveNext
	|-Dictionary.Enumerator<int, Int32Enum>.MoveNext
	|-Dictionary.Enumerator<Int32Enum, int>.MoveNext
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|-Dictionary.Enumerator<Int32Enum, uint>.MoveNext
	|-Dictionary.Enumerator<uint, int>.MoveNext
	|
	|-RVA: 0x1117E50 Offset: 0x1117050 VA: 0x181117E50
	|-Dictionary.Enumerator<int, long>.MoveNext
	|-Dictionary.Enumerator<int, object>.MoveNext
	|-Dictionary.Enumerator<Int32Enum, object>.MoveNext
	|-Dictionary.Enumerator<uint, object>.MoveNext
	|
	|-RVA: 0x11185F0 Offset: 0x11177F0 VA: 0x1811185F0
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.MoveNext
	|-Dictionary.Enumerator<Int32Enum, Color>.MoveNext
	|
	|-RVA: 0x11183F0 Offset: 0x11175F0 VA: 0x1811183F0
	|-Dictionary.Enumerator<int, float>.MoveNext
	|
	|-RVA: 0x1118F70 Offset: 0x1118170 VA: 0x181118F70
	|-Dictionary.Enumerator<int, TreeItem>.MoveNext
	|-Dictionary.Enumerator<uint, VirtualHeap.PinnedBlob>.MoveNext
	|
	|-RVA: 0x11209F0 Offset: 0x111FBF0 VA: 0x1811209F0
	|-Dictionary.Enumerator<int, TextResourceManager.FontAssetRef>.MoveNext
	|
	|-RVA: 0x11208E0 Offset: 0x111FAE0 VA: 0x1811208E0
	|-Dictionary.Enumerator<Int32Enum, HatOptions>.MoveNext
	|
	|-RVA: 0x1121C80 Offset: 0x1120E80 VA: 0x181121C80
	|-Dictionary.Enumerator<Int32Enum, SkinOptions>.MoveNext
	|
	|-RVA: 0x1121550 Offset: 0x1120750 VA: 0x181121550
	|-Dictionary.Enumerator<Int32Enum, VisorOptions>.MoveNext
	|
	|-RVA: 0x1121320 Offset: 0x1120520 VA: 0x181121320
	|-Dictionary.Enumerator<long, ComputedStyle>.MoveNext
	|
	|-RVA: 0x1120D80 Offset: 0x111FF80 VA: 0x181120D80
	|-Dictionary.Enumerator<long, Int32Enum>.MoveNext
	|-Dictionary.Enumerator<object, int>.MoveNext
	|-Dictionary.Enumerator<object, Int32Enum>.MoveNext
	|-Dictionary.Enumerator<object, uint>.MoveNext
	|
	|-RVA: 0x1121660 Offset: 0x1120860 VA: 0x181121660
	|-Dictionary.Enumerator<long, object>.MoveNext
	|-Dictionary.Enumerator<IntPtr, object>.MoveNext
	|-Dictionary.Enumerator<object, object>.MoveNext
	|-Dictionary.Enumerator<object, ulong>.MoveNext
	|
	|-RVA: 0x1121FC0 Offset: 0x11211C0 VA: 0x181121FC0
	|-Dictionary.Enumerator<IntVec3, object>.MoveNext
	|
	|-RVA: 0x1121EB0 Offset: 0x11210B0 VA: 0x181121EB0
	|-Dictionary.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.MoveNext
	|
	|-RVA: 0x1120B60 Offset: 0x111FD60 VA: 0x181120B60
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x1120790 Offset: 0x111F990 VA: 0x181120790
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.MoveNext
	|-Dictionary.Enumerator<ulong, Helper.Allocation>.MoveNext
	|
	|-RVA: 0x11205F0 Offset: 0x111F7F0 VA: 0x1811205F0
	|-Dictionary.Enumerator<object, bool>.MoveNext
	|
	|-RVA: 0x1120E90 Offset: 0x1120090 VA: 0x181120E90
	|-Dictionary.Enumerator<object, Color32>.MoveNext
	|-Dictionary.Enumerator<object, TextureId>.MoveNext
	|
	|-RVA: 0x11284B0 Offset: 0x11276B0 VA: 0x1811284B0
	|-Dictionary.Enumerator<object, ResourceLocator>.MoveNext
	|-Dictionary.Enumerator<object, StylePropertyValue>.MoveNext
	|-Dictionary.Enumerator<object, XPathNodeRef>.MoveNext
	|-Dictionary.Enumerator<ulong, Helper.PinnedBuffer>.MoveNext
	|
	|-RVA: 0x11287F0 Offset: 0x11279F0 VA: 0x1811287F0
	|-Dictionary.Enumerator<object, float>.MoveNext
	|
	|-RVA: 0x11270C0 Offset: 0x11262C0 VA: 0x1811270C0
	|-Dictionary.Enumerator<object, TimeSpan>.MoveNext
	|-Dictionary.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.MoveNext
	|-Dictionary.Enumerator<object, StyleComplexSelector.PseudoStateData>.MoveNext
	|
	|-RVA: 0x1128B20 Offset: 0x1127D20 VA: 0x181128B20
	|-Dictionary.Enumerator<UInt16Enum, object>.MoveNext
	|
	|-RVA: 0x1127CC0 Offset: 0x1126EC0 VA: 0x181127CC0
	|-Dictionary.Enumerator<UInt16Enum, RoleRate>.MoveNext
	|
	|-RVA: 0x11276B0 Offset: 0x11268B0 VA: 0x1811276B0
	|-Dictionary.Enumerator<uint, GlyphPairAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x1128350 Offset: 0x1127550 VA: 0x181128350
	|-Dictionary.Enumerator<uint, MarkToBaseAdjustmentRecord>.MoveNext
	|-Dictionary.Enumerator<uint, MarkToMarkAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x112EF70 Offset: 0x112E170 VA: 0x18112EF70
	|-Dictionary.Enumerator<Vector2, Int32Enum>.MoveNext
	|
	|-RVA: 0x1132A30 Offset: 0x1131C30 VA: 0x181132A30
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.MoveNext
	|
	|-RVA: 0x1132390 Offset: 0x1131590 VA: 0x181132390
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x1133200 Offset: 0x1132400 VA: 0x181133200
	|-Dictionary.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.MoveNext
	|
	|-RVA: 0x1132190 Offset: 0x1131390 VA: 0x181132190
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.get_Current
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.get_Current
	|-Dictionary.Enumerator<Color, object>.get_Current
	|-Dictionary.Enumerator<DiscardReasonWithCategory, int>.get_Current
	|-Dictionary.Enumerator<Guid, object>.get_Current
	|-Dictionary.Enumerator<int, TreeItem>.get_Current
	|-Dictionary.Enumerator<IntVec3, object>.get_Current
	|-Dictionary.Enumerator<object, ResourceLocator>.get_Current
	|-Dictionary.Enumerator<object, StylePropertyValue>.get_Current
	|-Dictionary.Enumerator<object, XPathNodeRef>.get_Current
	|-Dictionary.Enumerator<uint, VirtualHeap.PinnedBlob>.get_Current
	|-Dictionary.Enumerator<ulong, Helper.PinnedBuffer>.get_Current
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Current
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Current
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Current
	|
	|-RVA: 0x10F0D80 Offset: 0x10EFF80 VA: 0x1810F0D80
	|-Dictionary.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.get_Current
	|
	|-RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020
	|-Dictionary.Enumerator<byte, bool>.get_Current
	|-Dictionary.Enumerator<byte, byte>.get_Current
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-Dictionary.Enumerator<byte, int>.get_Current
	|-Dictionary.Enumerator<ByteEnum, Int32Enum>.get_Current
	|-Dictionary.Enumerator<ByteEnum, float>.get_Current
	|-Dictionary.Enumerator<char, int>.get_Current
	|-Dictionary.Enumerator<int, bool>.get_Current
	|-Dictionary.Enumerator<int, char>.get_Current
	|-Dictionary.Enumerator<int, int>.get_Current
	|-Dictionary.Enumerator<int, Int32Enum>.get_Current
	|-Dictionary.Enumerator<int, float>.get_Current
	|-Dictionary.Enumerator<Int32Enum, bool>.get_Current
	|-Dictionary.Enumerator<Int32Enum, HatOptions>.get_Current
	|-Dictionary.Enumerator<Int32Enum, int>.get_Current
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.get_Current
	|-Dictionary.Enumerator<Int32Enum, SkinOptions>.get_Current
	|-Dictionary.Enumerator<Int32Enum, uint>.get_Current
	|-Dictionary.Enumerator<Int32Enum, VisorOptions>.get_Current
	|-Dictionary.Enumerator<UInt16Enum, uint>.get_Current
	|-Dictionary.Enumerator<uint, int>.get_Current
	|
	|-RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	|-Dictionary.Enumerator<byte, object>.get_Current
	|-Dictionary.Enumerator<ByteEnum, object>.get_Current
	|-Dictionary.Enumerator<DateTime, object>.get_Current
	|-Dictionary.Enumerator<int, long>.get_Current
	|-Dictionary.Enumerator<int, object>.get_Current
	|-Dictionary.Enumerator<Int32Enum, object>.get_Current
	|-Dictionary.Enumerator<long, Int32Enum>.get_Current
	|-Dictionary.Enumerator<long, object>.get_Current
	|-Dictionary.Enumerator<IntPtr, object>.get_Current
	|-Dictionary.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.get_Current
	|-Dictionary.Enumerator<object, bool>.get_Current
	|-Dictionary.Enumerator<object, Color32>.get_Current
	|-Dictionary.Enumerator<object, int>.get_Current
	|-Dictionary.Enumerator<object, Int32Enum>.get_Current
	|-Dictionary.Enumerator<object, object>.get_Current
	|-Dictionary.Enumerator<object, float>.get_Current
	|-Dictionary.Enumerator<object, TextureId>.get_Current
	|-Dictionary.Enumerator<object, TimeSpan>.get_Current
	|-Dictionary.Enumerator<object, uint>.get_Current
	|-Dictionary.Enumerator<object, ulong>.get_Current
	|-Dictionary.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Current
	|-Dictionary.Enumerator<object, StyleComplexSelector.PseudoStateData>.get_Current
	|-Dictionary.Enumerator<TerrainTileCoord, object>.get_Current
	|-Dictionary.Enumerator<UInt16Enum, object>.get_Current
	|-Dictionary.Enumerator<uint, object>.get_Current
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.get_Current
	|
	|-RVA: 0x1116EC0 Offset: 0x11160C0 VA: 0x181116EC0
	|-Dictionary.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.get_Current
	|
	|-RVA: 0x1120500 Offset: 0x111F700 VA: 0x181120500
	|-Dictionary.Enumerator<Guid, int>.get_Current
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.get_Current
	|-Dictionary.Enumerator<Int32Enum, Color>.get_Current
	|
	|-RVA: 0x10EBEF0 Offset: 0x10EB0F0 VA: 0x1810EBEF0
	|-Dictionary.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Current
	|-Dictionary.Enumerator<UInt16Enum, RoleRate>.get_Current
	|-Dictionary.Enumerator<Vector2, Int32Enum>.get_Current
	|
	|-RVA: 0x4FE170 Offset: 0x4FD370 VA: 0x1804FE170
	|-Dictionary.Enumerator<int, TreeViewItemData<object>>.get_Current
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.get_Current
	|-Dictionary.Enumerator<ulong, Helper.Allocation>.get_Current
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.get_Current
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.get_Current
	|
	|-RVA: 0x10EBE70 Offset: 0x10EB070 VA: 0x1810EBE70
	|-Dictionary.Enumerator<int, DiagnosticEvent>.get_Current
	|
	|-RVA: 0x4A1870 Offset: 0x4A0A70 VA: 0x1804A1870
	|-Dictionary.Enumerator<int, TextResourceManager.FontAssetRef>.get_Current
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.get_Current
	|
	|-RVA: 0x1117080 Offset: 0x1116280 VA: 0x181117080
	|-Dictionary.Enumerator<long, ComputedStyle>.get_Current
	|
	|-RVA: 0x10F0C50 Offset: 0x10EFE50 VA: 0x1810F0C50
	|-Dictionary.Enumerator<uint, GlyphPairAdjustmentRecord>.get_Current
	|-Dictionary.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.get_Current
	|
	|-RVA: 0x112D830 Offset: 0x112CA30 VA: 0x18112D830
	|-Dictionary.Enumerator<uint, MarkToBaseAdjustmentRecord>.get_Current
	|-Dictionary.Enumerator<uint, MarkToMarkAdjustmentRecord>.get_Current
	|
	|-RVA: 0xE69B10 Offset: 0xE68D10 VA: 0x180E69B10
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.Dispose
	|-Dictionary.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.Dispose
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.Dispose
	|-Dictionary.Enumerator<byte, bool>.Dispose
	|-Dictionary.Enumerator<byte, byte>.Dispose
	|-Dictionary.Enumerator<byte, int>.Dispose
	|-Dictionary.Enumerator<byte, object>.Dispose
	|-Dictionary.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.Dispose
	|-Dictionary.Enumerator<ByteEnum, Int32Enum>.Dispose
	|-Dictionary.Enumerator<ByteEnum, object>.Dispose
	|-Dictionary.Enumerator<ByteEnum, float>.Dispose
	|-Dictionary.Enumerator<char, int>.Dispose
	|-Dictionary.Enumerator<Color, object>.Dispose
	|-Dictionary.Enumerator<DateTime, object>.Dispose
	|-Dictionary.Enumerator<DiscardReasonWithCategory, int>.Dispose
	|-Dictionary.Enumerator<Guid, int>.Dispose
	|-Dictionary.Enumerator<Guid, object>.Dispose
	|-Dictionary.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.Dispose
	|-Dictionary.Enumerator<int, TreeViewItemData<object>>.Dispose
	|-Dictionary.Enumerator<int, bool>.Dispose
	|-Dictionary.Enumerator<int, char>.Dispose
	|-Dictionary.Enumerator<int, DiagnosticEvent>.Dispose
	|-Dictionary.Enumerator<int, int>.Dispose
	|-Dictionary.Enumerator<int, Int32Enum>.Dispose
	|-Dictionary.Enumerator<int, long>.Dispose
	|-Dictionary.Enumerator<int, object>.Dispose
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.Dispose
	|-Dictionary.Enumerator<int, float>.Dispose
	|-Dictionary.Enumerator<int, TreeItem>.Dispose
	|-Dictionary.Enumerator<int, TextResourceManager.FontAssetRef>.Dispose
	|-Dictionary.Enumerator<Int32Enum, bool>.Dispose
	|-Dictionary.Enumerator<Int32Enum, Color>.Dispose
	|-Dictionary.Enumerator<Int32Enum, HatOptions>.Dispose
	|-Dictionary.Enumerator<Int32Enum, int>.Dispose
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.Dispose
	|-Dictionary.Enumerator<Int32Enum, object>.Dispose
	|-Dictionary.Enumerator<Int32Enum, SkinOptions>.Dispose
	|-Dictionary.Enumerator<Int32Enum, uint>.Dispose
	|-Dictionary.Enumerator<Int32Enum, VisorOptions>.Dispose
	|-Dictionary.Enumerator<long, ComputedStyle>.Dispose
	|-Dictionary.Enumerator<long, Int32Enum>.Dispose
	|-Dictionary.Enumerator<long, object>.Dispose
	|-Dictionary.Enumerator<IntPtr, object>.Dispose
	|-Dictionary.Enumerator<IntVec3, object>.Dispose
	|-Dictionary.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.Dispose
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.Dispose
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.Dispose
	|-Dictionary.Enumerator<object, bool>.Dispose
	|-Dictionary.Enumerator<object, Color32>.Dispose
	|-Dictionary.Enumerator<object, int>.Dispose
	|-Dictionary.Enumerator<object, Int32Enum>.Dispose
	|-Dictionary.Enumerator<object, object>.Dispose
	|-Dictionary.Enumerator<object, ResourceLocator>.Dispose
	|-Dictionary.Enumerator<object, float>.Dispose
	|-Dictionary.Enumerator<object, StylePropertyValue>.Dispose
	|-Dictionary.Enumerator<object, TextureId>.Dispose
	|-Dictionary.Enumerator<object, TimeSpan>.Dispose
	|-Dictionary.Enumerator<object, uint>.Dispose
	|-Dictionary.Enumerator<object, ulong>.Dispose
	|-Dictionary.Enumerator<object, XPathNodeRef>.Dispose
	|-Dictionary.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.Dispose
	|-Dictionary.Enumerator<object, StyleComplexSelector.PseudoStateData>.Dispose
	|-Dictionary.Enumerator<TerrainTileCoord, object>.Dispose
	|-Dictionary.Enumerator<UInt16Enum, object>.Dispose
	|-Dictionary.Enumerator<UInt16Enum, RoleRate>.Dispose
	|-Dictionary.Enumerator<UInt16Enum, uint>.Dispose
	|-Dictionary.Enumerator<uint, GlyphPairAdjustmentRecord>.Dispose
	|-Dictionary.Enumerator<uint, int>.Dispose
	|-Dictionary.Enumerator<uint, MarkToBaseAdjustmentRecord>.Dispose
	|-Dictionary.Enumerator<uint, MarkToMarkAdjustmentRecord>.Dispose
	|-Dictionary.Enumerator<uint, object>.Dispose
	|-Dictionary.Enumerator<uint, VirtualHeap.PinnedBlob>.Dispose
	|-Dictionary.Enumerator<ulong, Helper.Allocation>.Dispose
	|-Dictionary.Enumerator<ulong, Helper.PinnedBuffer>.Dispose
	|-Dictionary.Enumerator<Vector2, Int32Enum>.Dispose
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.Dispose
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	|-Dictionary.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.Dispose
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.Dispose
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.Dispose
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.Dispose
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.Dispose
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1115F20 Offset: 0x1115120 VA: 0x181115F20
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1116100 Offset: 0x1115300 VA: 0x181116100
	|-Dictionary.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11151D0 Offset: 0x11143D0 VA: 0x1811151D0
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1116560 Offset: 0x1115760 VA: 0x181116560
	|-Dictionary.Enumerator<byte, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1115C90 Offset: 0x1114E90 VA: 0x181115C90
	|-Dictionary.Enumerator<byte, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1115A30 Offset: 0x1114C30 VA: 0x181115A30
	|-Dictionary.Enumerator<byte, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1114F90 Offset: 0x1114190 VA: 0x181114F90
	|-Dictionary.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11168A0 Offset: 0x1115AA0 VA: 0x1811168A0
	|-Dictionary.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1115790 Offset: 0x1114990 VA: 0x181115790
	|-Dictionary.Enumerator<ByteEnum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11163C0 Offset: 0x11155C0 VA: 0x1811163C0
	|-Dictionary.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11153B0 Offset: 0x11145B0 VA: 0x1811153B0
	|-Dictionary.Enumerator<ByteEnum, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111F9D0 Offset: 0x111EBD0 VA: 0x18111F9D0
	|-Dictionary.Enumerator<char, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111D8A0 Offset: 0x111CAA0 VA: 0x18111D8A0
	|-Dictionary.Enumerator<Color, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111CE30 Offset: 0x111C030 VA: 0x18111CE30
	|-Dictionary.Enumerator<DateTime, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111CC10 Offset: 0x111BE10 VA: 0x18111CC10
	|-Dictionary.Enumerator<DiscardReasonWithCategory, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111D360 Offset: 0x111C560 VA: 0x18111D360
	|-Dictionary.Enumerator<Guid, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111EC20 Offset: 0x111DE20 VA: 0x18111EC20
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111E220 Offset: 0x111D420 VA: 0x18111E220
	|-Dictionary.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111C9E0 Offset: 0x111BBE0 VA: 0x18111C9E0
	|-Dictionary.Enumerator<int, TreeViewItemData<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111E050 Offset: 0x111D250 VA: 0x18111E050
	|-Dictionary.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111EE00 Offset: 0x111E000 VA: 0x18111EE00
	|-Dictionary.Enumerator<int, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111E7E0 Offset: 0x111D9E0 VA: 0x18111E7E0
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111F070 Offset: 0x111E270 VA: 0x18111F070
	|-Dictionary.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111F3B0 Offset: 0x111E5B0 VA: 0x18111F3B0
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111DE80 Offset: 0x111D080 VA: 0x18111DE80
	|-Dictionary.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111D700 Offset: 0x111C900 VA: 0x18111D700
	|-Dictionary.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111FDA0 Offset: 0x111EFA0 VA: 0x18111FDA0
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111F580 Offset: 0x111E780 VA: 0x18111F580
	|-Dictionary.Enumerator<int, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111D060 Offset: 0x111C260 VA: 0x18111D060
	|-Dictionary.Enumerator<int, TreeItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1123AD0 Offset: 0x1122CD0 VA: 0x181123AD0
	|-Dictionary.Enumerator<int, TextResourceManager.FontAssetRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1124D90 Offset: 0x1123F90 VA: 0x181124D90
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1124080 Offset: 0x1123280 VA: 0x181124080
	|-Dictionary.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1123900 Offset: 0x1122B00 VA: 0x181123900
	|-Dictionary.Enumerator<Int32Enum, HatOptions>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1125C20 Offset: 0x1124E20 VA: 0x181125C20
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1125680 Offset: 0x1124880 VA: 0x181125680
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1124BF0 Offset: 0x1123DF0 VA: 0x181124BF0
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1124A20 Offset: 0x1123C20 VA: 0x181124A20
	|-Dictionary.Enumerator<Int32Enum, SkinOptions>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1125DF0 Offset: 0x1124FF0 VA: 0x181125DF0
	|-Dictionary.Enumerator<Int32Enum, uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11262C0 Offset: 0x11254C0 VA: 0x1811262C0
	|-Dictionary.Enumerator<Int32Enum, VisorOptions>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1125FC0 Offset: 0x11251C0 VA: 0x181125FC0
	|-Dictionary.Enumerator<long, ComputedStyle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1125850 Offset: 0x1124A50 VA: 0x181125850
	|-Dictionary.Enumerator<long, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1124880 Offset: 0x1123A80 VA: 0x181124880
	|-Dictionary.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1124F60 Offset: 0x1124160 VA: 0x181124F60
	|-Dictionary.Enumerator<IntPtr, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1123EA0 Offset: 0x11230A0 VA: 0x181123EA0
	|-Dictionary.Enumerator<IntVec3, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1123760 Offset: 0x1122960 VA: 0x181123760
	|-Dictionary.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11243B0 Offset: 0x11235B0 VA: 0x1811243B0
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1125A20 Offset: 0x1124C20 VA: 0x181125A20
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11235C0 Offset: 0x11227C0 VA: 0x1811235C0
	|-Dictionary.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1123420 Offset: 0x1122620 VA: 0x181123420
	|-Dictionary.Enumerator<object, Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11254E0 Offset: 0x11246E0 VA: 0x1811254E0
	|-Dictionary.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1123D00 Offset: 0x1122F00 VA: 0x181123D00
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112B340 Offset: 0x112A540 VA: 0x18112B340
	|-Dictionary.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112C880 Offset: 0x112BA80 VA: 0x18112C880
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112AFC0 Offset: 0x112A1C0 VA: 0x18112AFC0
	|-Dictionary.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112B4B0 Offset: 0x112A6B0 VA: 0x18112B4B0
	|-Dictionary.Enumerator<object, StylePropertyValue>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112C4B0 Offset: 0x112B6B0 VA: 0x18112C4B0
	|-Dictionary.Enumerator<object, TextureId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112B680 Offset: 0x112A880 VA: 0x18112B680
	|-Dictionary.Enumerator<object, TimeSpan>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112C310 Offset: 0x112B510 VA: 0x18112C310
	|-Dictionary.Enumerator<object, uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112C170 Offset: 0x112B370 VA: 0x18112C170
	|-Dictionary.Enumerator<object, ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112B170 Offset: 0x112A370 VA: 0x18112B170
	|-Dictionary.Enumerator<object, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112BC20 Offset: 0x112AE20 VA: 0x18112BC20
	|-Dictionary.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112AE20 Offset: 0x112A020 VA: 0x18112AE20
	|-Dictionary.Enumerator<object, StyleComplexSelector.PseudoStateData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112A6A0 Offset: 0x11298A0 VA: 0x18112A6A0
	|-Dictionary.Enumerator<TerrainTileCoord, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112B820 Offset: 0x112AA20 VA: 0x18112B820
	|-Dictionary.Enumerator<UInt16Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112A840 Offset: 0x1129A40 VA: 0x18112A840
	|-Dictionary.Enumerator<UInt16Enum, RoleRate>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112A4D0 Offset: 0x11296D0 VA: 0x18112A4D0
	|-Dictionary.Enumerator<UInt16Enum, uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112B9C0 Offset: 0x112ABC0 VA: 0x18112B9C0
	|-Dictionary.Enumerator<uint, GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112AA20 Offset: 0x1129C20 VA: 0x18112AA20
	|-Dictionary.Enumerator<uint, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112C650 Offset: 0x112B850 VA: 0x18112C650
	|-Dictionary.Enumerator<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113B270 Offset: 0x113A470 VA: 0x18113B270
	|-Dictionary.Enumerator<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113C0E0 Offset: 0x113B2E0 VA: 0x18113C0E0
	|-Dictionary.Enumerator<uint, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113A160 Offset: 0x1139360 VA: 0x18113A160
	|-Dictionary.Enumerator<uint, VirtualHeap.PinnedBlob>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113C900 Offset: 0x113BB00 VA: 0x18113C900
	|-Dictionary.Enumerator<ulong, Helper.Allocation>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113AC30 Offset: 0x1139E30 VA: 0x18113AC30
	|-Dictionary.Enumerator<ulong, Helper.PinnedBuffer>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1138BB0 Offset: 0x1137DB0 VA: 0x181138BB0
	|-Dictionary.Enumerator<Vector2, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113A370 Offset: 0x1139570 VA: 0x18113A370
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1138DC0 Offset: 0x1137FC0 VA: 0x181138DC0
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113AE40 Offset: 0x113A040 VA: 0x18113AE40
	|-Dictionary.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11385E0 Offset: 0x11377E0 VA: 0x1811385E0
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1139B90 Offset: 0x1138D90 VA: 0x181139B90
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113B4A0 Offset: 0x113A6A0 VA: 0x18113B4A0
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1139DB0 Offset: 0x1138FB0 VA: 0x181139DB0
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113BEC0 Offset: 0x113B0C0 VA: 0x18113BEC0
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114C20 Offset: 0x1113E20 VA: 0x181114C20
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Color, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<DiscardReasonWithCategory, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<int, TreeItem>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<IntVec3, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, StylePropertyValue>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<uint, VirtualHeap.PinnedBlob>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<ulong, Helper.PinnedBuffer>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114B40 Offset: 0x1113D40 VA: 0x181114B40
	|-Dictionary.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11148C0 Offset: 0x1113AC0 VA: 0x1811148C0
	|-Dictionary.Enumerator<byte, bool>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<byte, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114C60 Offset: 0x1113E60 VA: 0x181114C60
	|-Dictionary.Enumerator<byte, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<ByteEnum, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<ByteEnum, float>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<char, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<int, char>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<int, float>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Int32Enum, HatOptions>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Int32Enum, SkinOptions>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Int32Enum, uint>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Int32Enum, VisorOptions>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<UInt16Enum, uint>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<uint, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114900 Offset: 0x1113B00 VA: 0x181114900
	|-Dictionary.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<DateTime, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<long, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<IntPtr, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, Color32>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, TextureId>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, TimeSpan>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, uint>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, ulong>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, StyleComplexSelector.PseudoStateData>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<TerrainTileCoord, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<UInt16Enum, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<uint, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114B00 Offset: 0x1113D00 VA: 0x181114B00
	|-Dictionary.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x111C570 Offset: 0x111B770 VA: 0x18111C570
	|-Dictionary.Enumerator<Guid, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x111C810 Offset: 0x111BA10 VA: 0x18111C810
	|-Dictionary.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<UInt16Enum, RoleRate>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Vector2, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x111C950 Offset: 0x111BB50 VA: 0x18111C950
	|-Dictionary.Enumerator<int, TreeViewItemData<object>>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<ulong, Helper.Allocation>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x111C990 Offset: 0x111BB90 VA: 0x18111C990
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1123270 Offset: 0x1122470 VA: 0x181123270
	|-Dictionary.Enumerator<int, TextResourceManager.FontAssetRef>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1123340 Offset: 0x1122540 VA: 0x181123340
	|-Dictionary.Enumerator<long, ComputedStyle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1129F40 Offset: 0x1129140 VA: 0x181129F40
	|-Dictionary.Enumerator<uint, GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1129F90 Offset: 0x1129190 VA: 0x181129F90
	|-Dictionary.Enumerator<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-Dictionary.Enumerator<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1138480 Offset: 0x1137680 VA: 0x181138480
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113D00 Offset: 0x1112F00 VA: 0x181113D00
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Color, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1114090 Offset: 0x1113290 VA: 0x181114090
	|-Dictionary.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1113DD0 Offset: 0x1112FD0 VA: 0x181113DD0
	|-Dictionary.Enumerator<byte, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<byte, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1113FA0 Offset: 0x11131A0 VA: 0x181113FA0
	|-Dictionary.Enumerator<byte, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<ByteEnum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1113ED0 Offset: 0x11130D0 VA: 0x181113ED0
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<ByteEnum, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x11142C0 Offset: 0x11134C0 VA: 0x1811142C0
	|-Dictionary.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x11141C0 Offset: 0x11133C0 VA: 0x1811141C0
	|-Dictionary.Enumerator<ByteEnum, float>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111AD10 Offset: 0x1119F10 VA: 0x18111AD10
	|-Dictionary.Enumerator<char, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<UInt16Enum, uint>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111A860 Offset: 0x1119A60 VA: 0x18111A860
	|-Dictionary.Enumerator<DateTime, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<IntPtr, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<TerrainTileCoord, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111AE10 Offset: 0x111A010 VA: 0x18111AE10
	|-Dictionary.Enumerator<DiscardReasonWithCategory, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Guid, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111B150 Offset: 0x111A350 VA: 0x18111B150
	|-Dictionary.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111AA30 Offset: 0x1119C30 VA: 0x18111AA30
	|-Dictionary.Enumerator<int, TreeViewItemData<object>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111A770 Offset: 0x1119970 VA: 0x18111A770
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Int32Enum, SkinOptions>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111AB40 Offset: 0x1119D40 VA: 0x18111AB40
	|-Dictionary.Enumerator<int, char>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Int32Enum, VisorOptions>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111A140 Offset: 0x1119340 VA: 0x18111A140
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111A050 Offset: 0x1119250 VA: 0x18111A050
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Int32Enum, HatOptions>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Int32Enum, uint>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<uint, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111A470 Offset: 0x1119670 VA: 0x18111A470
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111AC40 Offset: 0x1119E40 VA: 0x18111AC40
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<uint, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111B250 Offset: 0x111A450 VA: 0x18111B250
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<Int32Enum, Color>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111A670 Offset: 0x1119870 VA: 0x18111A670
	|-Dictionary.Enumerator<int, float>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x111A570 Offset: 0x1119770 VA: 0x18111A570
	|-Dictionary.Enumerator<int, TreeItem>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<uint, VirtualHeap.PinnedBlob>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1122280 Offset: 0x1121480 VA: 0x181122280
	|-Dictionary.Enumerator<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1122610 Offset: 0x1121810 VA: 0x181122610
	|-Dictionary.Enumerator<long, ComputedStyle>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1122760 Offset: 0x1121960 VA: 0x181122760
	|-Dictionary.Enumerator<long, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1122960 Offset: 0x1121B60 VA: 0x181122960
	|-Dictionary.Enumerator<IntVec3, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x11221A0 Offset: 0x11213A0 VA: 0x1811221A0
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1122460 Offset: 0x1121660 VA: 0x181122460
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1122390 Offset: 0x1121590 VA: 0x181122390
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1122540 Offset: 0x1121740 VA: 0x181122540
	|-Dictionary.Enumerator<object, Color32>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<object, TextureId>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<object, uint>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x11292D0 Offset: 0x11284D0 VA: 0x1811292D0
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1129370 Offset: 0x1128570 VA: 0x181129370
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<object, StylePropertyValue>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<object, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1129800 Offset: 0x1128A00 VA: 0x181129800
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1129540 Offset: 0x1128740 VA: 0x181129540
	|-Dictionary.Enumerator<object, TimeSpan>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<object, ulong>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1129730 Offset: 0x1128930 VA: 0x181129730
	|-Dictionary.Enumerator<UInt16Enum, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1129440 Offset: 0x1128640 VA: 0x181129440
	|-Dictionary.Enumerator<UInt16Enum, RoleRate>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x11291B0 Offset: 0x11283B0 VA: 0x1811291B0
	|-Dictionary.Enumerator<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x11298E0 Offset: 0x1128AE0 VA: 0x1811298E0
	|-Dictionary.Enumerator<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionaryEnumerator.get_Entry
	|-Dictionary.Enumerator<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1135BA0 Offset: 0x1134DA0 VA: 0x181135BA0
	|-Dictionary.Enumerator<ulong, Helper.Allocation>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1134EA0 Offset: 0x11340A0 VA: 0x181134EA0
	|-Dictionary.Enumerator<ulong, Helper.PinnedBuffer>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1134DA0 Offset: 0x1133FA0 VA: 0x181134DA0
	|-Dictionary.Enumerator<Vector2, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1135A90 Offset: 0x1134C90 VA: 0x181135A90
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1134FB0 Offset: 0x11341B0 VA: 0x181134FB0
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1135970 Offset: 0x1134B70 VA: 0x181135970
	|-Dictionary.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1134960 Offset: 0x1133B60 VA: 0x181134960
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114450 Offset: 0x1113650 VA: 0x181114450
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Color, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<DiscardReasonWithCategory, int>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Guid, int>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x11143C0 Offset: 0x11135C0 VA: 0x1811143C0
	|-Dictionary.Enumerator<byte, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<byte, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<byte, int>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<ByteEnum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<ByteEnum, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<ByteEnum, float>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x111B750 Offset: 0x111A950 VA: 0x18111B750
	|-Dictionary.Enumerator<char, int>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<UInt16Enum, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<UInt16Enum, RoleRate>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<UInt16Enum, uint>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x111B3E0 Offset: 0x111A5E0 VA: 0x18111B3E0
	|-Dictionary.Enumerator<DateTime, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<long, ComputedStyle>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<long, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<IntPtr, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<TerrainTileCoord, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<ulong, Helper.Allocation>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<ulong, Helper.PinnedBuffer>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x111B350 Offset: 0x111A550 VA: 0x18111B350
	|-Dictionary.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, TreeViewItemData<object>>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, char>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, float>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, TreeItem>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Int32Enum, Color>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Int32Enum, HatOptions>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Int32Enum, SkinOptions>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Int32Enum, uint>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Int32Enum, VisorOptions>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<uint, int>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<uint, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<uint, VirtualHeap.PinnedBlob>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x1122CC0 Offset: 0x1121EC0 VA: 0x181122CC0
	|-Dictionary.Enumerator<IntVec3, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x1122BE0 Offset: 0x1121DE0 VA: 0x181122BE0
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, Color32>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, StylePropertyValue>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, TextureId>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, TimeSpan>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, uint>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, ulong>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x1136A70 Offset: 0x1135C70 VA: 0x181136A70
	|-Dictionary.Enumerator<Vector2, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x1136B00 Offset: 0x1135D00 VA: 0x181136B00
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x1136520 Offset: 0x1135720 VA: 0x181136520
	|-Dictionary.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.IDictionaryEnumerator.get_Key
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11145D0 Offset: 0x11137D0 VA: 0x1811145D0
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Color, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<IntVec3, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x11147E0 Offset: 0x11139E0 VA: 0x1811147E0
	|-Dictionary.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x11144E0 Offset: 0x11136E0 VA: 0x1811144E0
	|-Dictionary.Enumerator<byte, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<byte, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x11146C0 Offset: 0x11138C0 VA: 0x1811146C0
	|-Dictionary.Enumerator<byte, int>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<ByteEnum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<char, int>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Int32Enum, HatOptions>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Int32Enum, uint>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<UInt16Enum, uint>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<uint, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1114570 Offset: 0x1113770 VA: 0x181114570
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<ByteEnum, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<DateTime, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<IntPtr, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<TerrainTileCoord, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<UInt16Enum, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<uint, object>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1114630 Offset: 0x1113830 VA: 0x181114630
	|-Dictionary.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1114750 Offset: 0x1113950 VA: 0x181114750
	|-Dictionary.Enumerator<ByteEnum, float>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<int, float>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x111B8B0 Offset: 0x111AAB0 VA: 0x18111B8B0
	|-Dictionary.Enumerator<DiscardReasonWithCategory, int>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Guid, int>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x111C0C0 Offset: 0x111B2C0 VA: 0x18111C0C0
	|-Dictionary.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<UInt16Enum, RoleRate>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x111BF80 Offset: 0x111B180 VA: 0x18111BF80
	|-Dictionary.Enumerator<int, TreeViewItemData<object>>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<ulong, Helper.Allocation>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x111BB80 Offset: 0x111AD80 VA: 0x18111BB80
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Int32Enum, SkinOptions>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x111BA50 Offset: 0x111AC50 VA: 0x18111BA50
	|-Dictionary.Enumerator<int, char>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Int32Enum, VisorOptions>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x111BAE0 Offset: 0x111ACE0 VA: 0x18111BAE0
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x111BDB0 Offset: 0x111AFB0 VA: 0x18111BDB0
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, TimeSpan>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, ulong>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x111BD20 Offset: 0x111AF20 VA: 0x18111BD20
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Int32Enum, Color>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x111BEF0 Offset: 0x111B0F0 VA: 0x18111BEF0
	|-Dictionary.Enumerator<int, TreeItem>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, StylePropertyValue>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<uint, VirtualHeap.PinnedBlob>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<ulong, Helper.PinnedBuffer>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1123150 Offset: 0x1122350 VA: 0x181123150
	|-Dictionary.Enumerator<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1122FD0 Offset: 0x11221D0 VA: 0x181122FD0
	|-Dictionary.Enumerator<long, ComputedStyle>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1122F40 Offset: 0x1122140 VA: 0x181122F40
	|-Dictionary.Enumerator<long, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, Color32>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, TextureId>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<object, uint>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<Vector2, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x11231E0 Offset: 0x11223E0 VA: 0x1811231E0
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1129D40 Offset: 0x1128F40 VA: 0x181129D40
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1129EA0 Offset: 0x11290A0 VA: 0x181129EA0
	|-Dictionary.Enumerator<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1129CB0 Offset: 0x1128EB0 VA: 0x181129CB0
	|-Dictionary.Enumerator<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionaryEnumerator.get_Value
	|-Dictionary.Enumerator<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1136D00 Offset: 0x1135F00 VA: 0x181136D00
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1136D90 Offset: 0x1135F90 VA: 0x181136D90
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x11376F0 Offset: 0x11368F0 VA: 0x1811376F0
	|-Dictionary.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1136F90 Offset: 0x1136190 VA: 0x181136F90
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/
}

// Namespace: 
[Serializable]
public struct Dictionary.KeyCollection.Enumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 4430
{
	// Fields
	private Dictionary<TKey, TValue> _dictionary; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TKey _currentKey; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1116C90 Offset: 0x1115E90 VA: 0x181116C90
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<Color, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<DiscardReasonWithCategory, int>..ctor
	|-Dictionary.KeyCollection.Enumerator<Guid, int>..ctor
	|-Dictionary.KeyCollection.Enumerator<Guid, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>..ctor
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x1116C30 Offset: 0x1115E30 VA: 0x181116C30
	|-Dictionary.KeyCollection.Enumerator<byte, bool>..ctor
	|-Dictionary.KeyCollection.Enumerator<byte, byte>..ctor
	|-Dictionary.KeyCollection.Enumerator<byte, int>..ctor
	|-Dictionary.KeyCollection.Enumerator<byte, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, Int32Enum>..ctor
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, float>..ctor
	|
	|-RVA: 0x11200A0 Offset: 0x111F2A0 VA: 0x1811200A0
	|-Dictionary.KeyCollection.Enumerator<char, int>..ctor
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, RoleRate>..ctor
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, uint>..ctor
	|
	|-RVA: 0x1116B80 Offset: 0x1115D80 VA: 0x181116B80
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<long, ComputedStyle>..ctor
	|-Dictionary.KeyCollection.Enumerator<long, Int32Enum>..ctor
	|-Dictionary.KeyCollection.Enumerator<long, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, bool>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, Color32>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, int>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, float>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, StylePropertyValue>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, TextureId>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, TimeSpan>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, uint>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, ulong>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, XPathNodeRef>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-Dictionary.KeyCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>..ctor
	|-Dictionary.KeyCollection.Enumerator<TerrainTileCoord, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.Allocation>..ctor
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.PinnedBuffer>..ctor
	|-Dictionary.KeyCollection.Enumerator<Vector2, Int32Enum>..ctor
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x1116C60 Offset: 0x1115E60 VA: 0x181116C60
	|-Dictionary.KeyCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, TreeViewItemData<object>>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, bool>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, char>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, int>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, long>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, float>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, TreeItem>..ctor
	|-Dictionary.KeyCollection.Enumerator<int, TextResourceManager.FontAssetRef>..ctor
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>..ctor
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>..ctor
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, HatOptions>..ctor
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>..ctor
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>..ctor
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, SkinOptions>..ctor
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, uint>..ctor
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, VisorOptions>..ctor
	|-Dictionary.KeyCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<uint, GlyphPairAdjustmentRecord>..ctor
	|-Dictionary.KeyCollection.Enumerator<uint, int>..ctor
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary.KeyCollection.Enumerator<uint, object>..ctor
	|-Dictionary.KeyCollection.Enumerator<uint, VirtualHeap.PinnedBlob>..ctor
	|
	|-RVA: 0x1126830 Offset: 0x1125A30 VA: 0x181126830
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>..ctor
	|
	|-RVA: 0x113D500 Offset: 0x113C700 VA: 0x18113D500
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x111FFE0 Offset: 0x111F1E0 VA: 0x18111FFE0
	|-Dictionary.KeyCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<byte, bool>.Dispose
	|-Dictionary.KeyCollection.Enumerator<byte, byte>.Dispose
	|-Dictionary.KeyCollection.Enumerator<byte, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<byte, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, Int32Enum>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, float>.Dispose
	|-Dictionary.KeyCollection.Enumerator<char, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Color, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<DiscardReasonWithCategory, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Guid, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, TreeViewItemData<object>>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, bool>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, char>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, long>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, float>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, TreeItem>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, TextResourceManager.FontAssetRef>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, HatOptions>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, SkinOptions>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, uint>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, VisorOptions>.Dispose
	|-Dictionary.KeyCollection.Enumerator<long, ComputedStyle>.Dispose
	|-Dictionary.KeyCollection.Enumerator<long, Int32Enum>.Dispose
	|-Dictionary.KeyCollection.Enumerator<long, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, bool>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, Color32>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, float>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, StylePropertyValue>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, TextureId>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, TimeSpan>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, uint>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, ulong>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, XPathNodeRef>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>.Dispose
	|-Dictionary.KeyCollection.Enumerator<TerrainTileCoord, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, RoleRate>.Dispose
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, uint>.Dispose
	|-Dictionary.KeyCollection.Enumerator<uint, GlyphPairAdjustmentRecord>.Dispose
	|-Dictionary.KeyCollection.Enumerator<uint, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>.Dispose
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>.Dispose
	|-Dictionary.KeyCollection.Enumerator<uint, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<uint, VirtualHeap.PinnedBlob>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.Allocation>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.PinnedBuffer>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Vector2, Int32Enum>.Dispose
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.Dispose
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	|-Dictionary.KeyCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.Dispose
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113260 Offset: 0x1112460 VA: 0x181113260
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Color, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<DiscardReasonWithCategory, int>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.MoveNext
	|
	|-RVA: 0x1113B50 Offset: 0x1112D50 VA: 0x181113B50
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.MoveNext
	|
	|-RVA: 0x1112CE0 Offset: 0x1111EE0 VA: 0x181112CE0
	|-Dictionary.KeyCollection.Enumerator<byte, bool>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<byte, byte>.MoveNext
	|
	|-RVA: 0x1112870 Offset: 0x1111A70 VA: 0x181112870
	|-Dictionary.KeyCollection.Enumerator<byte, int>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, Int32Enum>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, float>.MoveNext
	|
	|-RVA: 0x1112900 Offset: 0x1111B00 VA: 0x181112900
	|-Dictionary.KeyCollection.Enumerator<byte, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>.MoveNext
	|
	|-RVA: 0x1117510 Offset: 0x1116710 VA: 0x181117510
	|-Dictionary.KeyCollection.Enumerator<char, int>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, uint>.MoveNext
	|
	|-RVA: 0x1118910 Offset: 0x1117B10 VA: 0x181118910
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<long, Int32Enum>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<long, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, bool>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, Color32>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, int>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, float>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, TextureId>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, TimeSpan>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, uint>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, ulong>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<TerrainTileCoord, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.MoveNext
	|
	|-RVA: 0x1118880 Offset: 0x1117A80 VA: 0x181118880
	|-Dictionary.KeyCollection.Enumerator<Guid, int>.MoveNext
	|
	|-RVA: 0x1117270 Offset: 0x1116470 VA: 0x181117270
	|-Dictionary.KeyCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.MoveNext
	|
	|-RVA: 0x1119980 Offset: 0x1118B80 VA: 0x181119980
	|-Dictionary.KeyCollection.Enumerator<int, TreeViewItemData<object>>.MoveNext
	|
	|-RVA: 0x1117300 Offset: 0x1116500 VA: 0x181117300
	|-Dictionary.KeyCollection.Enumerator<int, bool>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<int, char>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<int, int>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<int, float>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, HatOptions>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, SkinOptions>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, uint>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, VisorOptions>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<uint, int>.MoveNext
	|
	|-RVA: 0x1119840 Offset: 0x1118A40 VA: 0x181119840
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x1117390 Offset: 0x1116590 VA: 0x181117390
	|-Dictionary.KeyCollection.Enumerator<int, long>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<int, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<uint, object>.MoveNext
	|
	|-RVA: 0x1117F60 Offset: 0x1117160 VA: 0x181117F60
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>.MoveNext
	|
	|-RVA: 0x1121D90 Offset: 0x1120F90 VA: 0x181121D90
	|-Dictionary.KeyCollection.Enumerator<int, TreeItem>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<uint, VirtualHeap.PinnedBlob>.MoveNext
	|
	|-RVA: 0x1121940 Offset: 0x1120B40 VA: 0x181121940
	|-Dictionary.KeyCollection.Enumerator<int, TextResourceManager.FontAssetRef>.MoveNext
	|
	|-RVA: 0x1121B00 Offset: 0x1120D00 VA: 0x181121B00
	|-Dictionary.KeyCollection.Enumerator<long, ComputedStyle>.MoveNext
	|
	|-RVA: 0x1121770 Offset: 0x1120970 VA: 0x181121770
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>.MoveNext
	|
	|-RVA: 0x11219D0 Offset: 0x1120BD0 VA: 0x1811219D0
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x11218B0 Offset: 0x1120AB0 VA: 0x1811218B0
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.Allocation>.MoveNext
	|
	|-RVA: 0x1127860 Offset: 0x1126A60 VA: 0x181127860
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, StylePropertyValue>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, XPathNodeRef>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.PinnedBuffer>.MoveNext
	|
	|-RVA: 0x1127030 Offset: 0x1126230 VA: 0x181127030
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, object>.MoveNext
	|
	|-RVA: 0x1127C30 Offset: 0x1126E30 VA: 0x181127C30
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, RoleRate>.MoveNext
	|
	|-RVA: 0x11278F0 Offset: 0x1126AF0 VA: 0x1811278F0
	|-Dictionary.KeyCollection.Enumerator<uint, GlyphPairAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x1128200 Offset: 0x1127400 VA: 0x181128200
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x11318B0 Offset: 0x1130AB0 VA: 0x1811318B0
	|-Dictionary.KeyCollection.Enumerator<Vector2, Int32Enum>.MoveNext
	|
	|-RVA: 0x1133160 Offset: 0x1132360 VA: 0x181133160
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.MoveNext
	|
	|-RVA: 0x112F750 Offset: 0x112E950 VA: 0x18112F750
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x11322E0 Offset: 0x11314E0 VA: 0x1811322E0
	|-Dictionary.KeyCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.MoveNext
	|
	|-RVA: 0x11330B0 Offset: 0x11322B0 VA: 0x1811330B0
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Color, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<DiscardReasonWithCategory, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Guid, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.get_Current
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Current
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Current
	|
	|-RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	|-Dictionary.KeyCollection.Enumerator<byte, bool>.get_Current
	|-Dictionary.KeyCollection.Enumerator<byte, byte>.get_Current
	|-Dictionary.KeyCollection.Enumerator<byte, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<byte, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, Int32Enum>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, float>.get_Current
	|
	|-RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020
	|-Dictionary.KeyCollection.Enumerator<char, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, RoleRate>.get_Current
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, uint>.get_Current
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<long, ComputedStyle>.get_Current
	|-Dictionary.KeyCollection.Enumerator<long, Int32Enum>.get_Current
	|-Dictionary.KeyCollection.Enumerator<long, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, bool>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, Color32>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, float>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, StylePropertyValue>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, TextureId>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, TimeSpan>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, uint>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, ulong>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, XPathNodeRef>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>.get_Current
	|-Dictionary.KeyCollection.Enumerator<TerrainTileCoord, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.Allocation>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.PinnedBuffer>.get_Current
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.get_Current
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-Dictionary.KeyCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, TreeViewItemData<object>>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, bool>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, char>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, long>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, float>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, TreeItem>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, TextResourceManager.FontAssetRef>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, HatOptions>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, SkinOptions>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, uint>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, VisorOptions>.get_Current
	|-Dictionary.KeyCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, GlyphPairAdjustmentRecord>.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, VirtualHeap.PinnedBlob>.get_Current
	|
	|-RVA: 0x10EBEF0 Offset: 0x10EB0F0 VA: 0x1810EBEF0
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>.get_Current
	|
	|-RVA: 0x11116F0 Offset: 0x11108F0 VA: 0x1811116F0
	|-Dictionary.KeyCollection.Enumerator<Vector2, Int32Enum>.get_Current
	|
	|-RVA: 0xE69B10 Offset: 0xE68D10 VA: 0x180E69B10
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	|-Dictionary.KeyCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1115710 Offset: 0x1114910 VA: 0x181115710
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Color, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<DiscardReasonWithCategory, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Guid, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1114E60 Offset: 0x1114060 VA: 0x181114E60
	|-Dictionary.KeyCollection.Enumerator<byte, bool>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<byte, byte>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<byte, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111DB30 Offset: 0x111CD30 VA: 0x18111DB30
	|-Dictionary.KeyCollection.Enumerator<char, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, RoleRate>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111DBB0 Offset: 0x111CDB0 VA: 0x18111DBB0
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<long, ComputedStyle>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<long, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<TerrainTileCoord, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.Allocation>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.PinnedBuffer>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1114DA0 Offset: 0x1113FA0 VA: 0x181114DA0
	|-Dictionary.KeyCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, TreeViewItemData<object>>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, char>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, float>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, TreeItem>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, TextResourceManager.FontAssetRef>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, HatOptions>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, SkinOptions>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, uint>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, VisorOptions>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, VirtualHeap.PinnedBlob>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1124280 Offset: 0x1123480 VA: 0x181124280
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1114E20 Offset: 0x1114020 VA: 0x181114E20
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, Color32>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, StylePropertyValue>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, TextureId>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, TimeSpan>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, uint>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, ulong>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113C060 Offset: 0x113B260 VA: 0x18113C060
	|-Dictionary.KeyCollection.Enumerator<Vector2, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113B0C0 Offset: 0x113A2C0 VA: 0x18113B0C0
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111D2E0 Offset: 0x111C4E0 VA: 0x18111D2E0
	|-Dictionary.KeyCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.IEnumerator.get_Current
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114AC0 Offset: 0x1113CC0 VA: 0x181114AC0
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Color, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<DiscardReasonWithCategory, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Guid, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114880 Offset: 0x1113A80 VA: 0x181114880
	|-Dictionary.KeyCollection.Enumerator<byte, bool>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<byte, byte>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<byte, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x111C230 Offset: 0x111B430 VA: 0x18111C230
	|-Dictionary.KeyCollection.Enumerator<char, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, RoleRate>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<UInt16Enum, uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114A30 Offset: 0x1113C30 VA: 0x181114A30
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<long, ComputedStyle>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<long, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, Color32>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, StylePropertyValue>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, TextureId>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, TimeSpan>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, uint>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, ulong>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<TerrainTileCoord, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.Allocation>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<ulong, Helper.PinnedBuffer>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Vector2, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114980 Offset: 0x1113B80 VA: 0x181114980
	|-Dictionary.KeyCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, TreeViewItemData<object>>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, char>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, float>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, TreeItem>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<int, TextResourceManager.FontAssetRef>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, HatOptions>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, SkinOptions>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, uint>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, VisorOptions>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<uint, GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<uint, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<uint, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<uint, VirtualHeap.PinnedBlob>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11233E0 Offset: 0x11225E0 VA: 0x1811233E0
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1137C20 Offset: 0x1136E20 VA: 0x181137C20
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x111C910 Offset: 0x111BB10 VA: 0x18111C910
	|-Dictionary.KeyCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.IEnumerator.Reset
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<TKey, TValue>))]
[Serializable]
public sealed class Dictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 4431
{
	// Fields
	private Dictionary<TKey, TValue> _dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04130 Offset: 0xD03330 VA: 0x180D04130
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>..ctor
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>..ctor
	|-Dictionary.KeyCollection<byte, bool>..ctor
	|-Dictionary.KeyCollection<byte, byte>..ctor
	|-Dictionary.KeyCollection<byte, int>..ctor
	|-Dictionary.KeyCollection<byte, object>..ctor
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>..ctor
	|-Dictionary.KeyCollection<ByteEnum, object>..ctor
	|-Dictionary.KeyCollection<ByteEnum, float>..ctor
	|-Dictionary.KeyCollection<char, int>..ctor
	|-Dictionary.KeyCollection<Color, object>..ctor
	|-Dictionary.KeyCollection<DateTime, object>..ctor
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>..ctor
	|-Dictionary.KeyCollection<Guid, int>..ctor
	|-Dictionary.KeyCollection<Guid, object>..ctor
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>..ctor
	|-Dictionary.KeyCollection<int, bool>..ctor
	|-Dictionary.KeyCollection<int, char>..ctor
	|-Dictionary.KeyCollection<int, DiagnosticEvent>..ctor
	|-Dictionary.KeyCollection<int, int>..ctor
	|-Dictionary.KeyCollection<int, Int32Enum>..ctor
	|-Dictionary.KeyCollection<int, long>..ctor
	|-Dictionary.KeyCollection<int, object>..ctor
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>..ctor
	|-Dictionary.KeyCollection<int, float>..ctor
	|-Dictionary.KeyCollection<int, TreeItem>..ctor
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>..ctor
	|-Dictionary.KeyCollection<Int32Enum, bool>..ctor
	|-Dictionary.KeyCollection<Int32Enum, Color>..ctor
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>..ctor
	|-Dictionary.KeyCollection<Int32Enum, int>..ctor
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>..ctor
	|-Dictionary.KeyCollection<Int32Enum, object>..ctor
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>..ctor
	|-Dictionary.KeyCollection<Int32Enum, uint>..ctor
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>..ctor
	|-Dictionary.KeyCollection<long, ComputedStyle>..ctor
	|-Dictionary.KeyCollection<long, Int32Enum>..ctor
	|-Dictionary.KeyCollection<long, object>..ctor
	|-Dictionary.KeyCollection<IntPtr, object>..ctor
	|-Dictionary.KeyCollection<IntVec3, object>..ctor
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>..ctor
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>..ctor
	|-Dictionary.KeyCollection<object, bool>..ctor
	|-Dictionary.KeyCollection<object, Color32>..ctor
	|-Dictionary.KeyCollection<object, int>..ctor
	|-Dictionary.KeyCollection<object, Int32Enum>..ctor
	|-Dictionary.KeyCollection<object, object>..ctor
	|-Dictionary.KeyCollection<object, ResourceLocator>..ctor
	|-Dictionary.KeyCollection<object, float>..ctor
	|-Dictionary.KeyCollection<object, StylePropertyValue>..ctor
	|-Dictionary.KeyCollection<object, TextureId>..ctor
	|-Dictionary.KeyCollection<object, TimeSpan>..ctor
	|-Dictionary.KeyCollection<object, uint>..ctor
	|-Dictionary.KeyCollection<object, ulong>..ctor
	|-Dictionary.KeyCollection<object, XPathNodeRef>..ctor
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>..ctor
	|-Dictionary.KeyCollection<TerrainTileCoord, object>..ctor
	|-Dictionary.KeyCollection<UInt16Enum, object>..ctor
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>..ctor
	|-Dictionary.KeyCollection<UInt16Enum, uint>..ctor
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>..ctor
	|-Dictionary.KeyCollection<uint, int>..ctor
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary.KeyCollection<uint, object>..ctor
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>..ctor
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>..ctor
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>..ctor
	|-Dictionary.KeyCollection<Vector2, Int32Enum>..ctor
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>..ctor
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>..ctor
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7EA0 Offset: 0xCF70A0 VA: 0x180CF7EA0
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.GetEnumerator
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.GetEnumerator
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.GetEnumerator
	|-Dictionary.KeyCollection<Color, object>.GetEnumerator
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.GetEnumerator
	|-Dictionary.KeyCollection<Guid, int>.GetEnumerator
	|-Dictionary.KeyCollection<Guid, object>.GetEnumerator
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.GetEnumerator
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.GetEnumerator
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.GetEnumerator
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.GetEnumerator
	|
	|-RVA: 0xCF7CD0 Offset: 0xCF6ED0 VA: 0x180CF7CD0
	|-Dictionary.KeyCollection<byte, bool>.GetEnumerator
	|-Dictionary.KeyCollection<byte, byte>.GetEnumerator
	|-Dictionary.KeyCollection<byte, int>.GetEnumerator
	|-Dictionary.KeyCollection<byte, object>.GetEnumerator
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.GetEnumerator
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.GetEnumerator
	|-Dictionary.KeyCollection<ByteEnum, object>.GetEnumerator
	|-Dictionary.KeyCollection<ByteEnum, float>.GetEnumerator
	|
	|-RVA: 0xCF7D50 Offset: 0xCF6F50 VA: 0x180CF7D50
	|-Dictionary.KeyCollection<char, int>.GetEnumerator
	|-Dictionary.KeyCollection<UInt16Enum, object>.GetEnumerator
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.GetEnumerator
	|-Dictionary.KeyCollection<UInt16Enum, uint>.GetEnumerator
	|
	|-RVA: 0xCF7C90 Offset: 0xCF6E90 VA: 0x180CF7C90
	|-Dictionary.KeyCollection<DateTime, object>.GetEnumerator
	|-Dictionary.KeyCollection<long, ComputedStyle>.GetEnumerator
	|-Dictionary.KeyCollection<long, Int32Enum>.GetEnumerator
	|-Dictionary.KeyCollection<long, object>.GetEnumerator
	|-Dictionary.KeyCollection<IntPtr, object>.GetEnumerator
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.GetEnumerator
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.GetEnumerator
	|-Dictionary.KeyCollection<object, bool>.GetEnumerator
	|-Dictionary.KeyCollection<object, Color32>.GetEnumerator
	|-Dictionary.KeyCollection<object, int>.GetEnumerator
	|-Dictionary.KeyCollection<object, Int32Enum>.GetEnumerator
	|-Dictionary.KeyCollection<object, object>.GetEnumerator
	|-Dictionary.KeyCollection<object, ResourceLocator>.GetEnumerator
	|-Dictionary.KeyCollection<object, float>.GetEnumerator
	|-Dictionary.KeyCollection<object, StylePropertyValue>.GetEnumerator
	|-Dictionary.KeyCollection<object, TextureId>.GetEnumerator
	|-Dictionary.KeyCollection<object, TimeSpan>.GetEnumerator
	|-Dictionary.KeyCollection<object, uint>.GetEnumerator
	|-Dictionary.KeyCollection<object, ulong>.GetEnumerator
	|-Dictionary.KeyCollection<object, XPathNodeRef>.GetEnumerator
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.GetEnumerator
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.GetEnumerator
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.GetEnumerator
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.GetEnumerator
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.GetEnumerator
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.GetEnumerator
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.GetEnumerator
	|
	|-RVA: 0xCF7C50 Offset: 0xCF6E50 VA: 0x180CF7C50
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.GetEnumerator
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.GetEnumerator
	|-Dictionary.KeyCollection<int, bool>.GetEnumerator
	|-Dictionary.KeyCollection<int, char>.GetEnumerator
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.GetEnumerator
	|-Dictionary.KeyCollection<int, int>.GetEnumerator
	|-Dictionary.KeyCollection<int, Int32Enum>.GetEnumerator
	|-Dictionary.KeyCollection<int, long>.GetEnumerator
	|-Dictionary.KeyCollection<int, object>.GetEnumerator
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.GetEnumerator
	|-Dictionary.KeyCollection<int, float>.GetEnumerator
	|-Dictionary.KeyCollection<int, TreeItem>.GetEnumerator
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, bool>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, Color>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, int>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, object>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, uint>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.GetEnumerator
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.GetEnumerator
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.GetEnumerator
	|-Dictionary.KeyCollection<uint, int>.GetEnumerator
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.GetEnumerator
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.GetEnumerator
	|-Dictionary.KeyCollection<uint, object>.GetEnumerator
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.GetEnumerator
	|
	|-RVA: 0x12FA990 Offset: 0x12F9B90 VA: 0x1812FA990
	|-Dictionary.KeyCollection<IntVec3, object>.GetEnumerator
	|
	|-RVA: 0xD05D60 Offset: 0xD04F60 VA: 0x180D05D60
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0xCF7D10 Offset: 0xCF6F10 VA: 0x180CF7D10
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.GetEnumerator
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F6850 Offset: 0x12F5A50 VA: 0x1812F6850
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.CopyTo
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.CopyTo
	|-Dictionary.KeyCollection<Color, object>.CopyTo
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.CopyTo
	|-Dictionary.KeyCollection<Guid, object>.CopyTo
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.CopyTo
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.CopyTo
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.CopyTo
	|
	|-RVA: 0x12F6740 Offset: 0x12F5940 VA: 0x1812F6740
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.CopyTo
	|
	|-RVA: 0x12F6960 Offset: 0x12F5B60 VA: 0x1812F6960
	|-Dictionary.KeyCollection<byte, bool>.CopyTo
	|-Dictionary.KeyCollection<byte, byte>.CopyTo
	|
	|-RVA: 0x12F6630 Offset: 0x12F5830 VA: 0x1812F6630
	|-Dictionary.KeyCollection<byte, int>.CopyTo
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.CopyTo
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.CopyTo
	|-Dictionary.KeyCollection<ByteEnum, float>.CopyTo
	|
	|-RVA: 0x12F6A70 Offset: 0x12F5C70 VA: 0x1812F6A70
	|-Dictionary.KeyCollection<byte, object>.CopyTo
	|-Dictionary.KeyCollection<ByteEnum, object>.CopyTo
	|
	|-RVA: 0x12F9690 Offset: 0x12F8890 VA: 0x1812F9690
	|-Dictionary.KeyCollection<char, int>.CopyTo
	|-Dictionary.KeyCollection<UInt16Enum, uint>.CopyTo
	|
	|-RVA: 0x12F9030 Offset: 0x12F8230 VA: 0x1812F9030
	|-Dictionary.KeyCollection<DateTime, object>.CopyTo
	|-Dictionary.KeyCollection<long, Int32Enum>.CopyTo
	|-Dictionary.KeyCollection<long, object>.CopyTo
	|-Dictionary.KeyCollection<IntPtr, object>.CopyTo
	|-Dictionary.KeyCollection<object, bool>.CopyTo
	|-Dictionary.KeyCollection<object, Color32>.CopyTo
	|-Dictionary.KeyCollection<object, int>.CopyTo
	|-Dictionary.KeyCollection<object, Int32Enum>.CopyTo
	|-Dictionary.KeyCollection<object, object>.CopyTo
	|-Dictionary.KeyCollection<object, float>.CopyTo
	|-Dictionary.KeyCollection<object, TextureId>.CopyTo
	|-Dictionary.KeyCollection<object, TimeSpan>.CopyTo
	|-Dictionary.KeyCollection<object, uint>.CopyTo
	|-Dictionary.KeyCollection<object, ulong>.CopyTo
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.CopyTo
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.CopyTo
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.CopyTo
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.CopyTo
	|
	|-RVA: 0x12F9E80 Offset: 0x12F9080 VA: 0x1812F9E80
	|-Dictionary.KeyCollection<Guid, int>.CopyTo
	|
	|-RVA: 0x12F9140 Offset: 0x12F8340 VA: 0x1812F9140
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.CopyTo
	|
	|-RVA: 0x12F9470 Offset: 0x12F8670 VA: 0x1812F9470
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.CopyTo
	|
	|-RVA: 0x12F9250 Offset: 0x12F8450 VA: 0x1812F9250
	|-Dictionary.KeyCollection<int, bool>.CopyTo
	|-Dictionary.KeyCollection<int, char>.CopyTo
	|-Dictionary.KeyCollection<int, int>.CopyTo
	|-Dictionary.KeyCollection<int, Int32Enum>.CopyTo
	|-Dictionary.KeyCollection<int, float>.CopyTo
	|-Dictionary.KeyCollection<Int32Enum, bool>.CopyTo
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.CopyTo
	|-Dictionary.KeyCollection<Int32Enum, int>.CopyTo
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.CopyTo
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.CopyTo
	|-Dictionary.KeyCollection<Int32Enum, uint>.CopyTo
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.CopyTo
	|-Dictionary.KeyCollection<uint, int>.CopyTo
	|
	|-RVA: 0x12F9580 Offset: 0x12F8780 VA: 0x1812F9580
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x12F98B0 Offset: 0x12F8AB0 VA: 0x1812F98B0
	|-Dictionary.KeyCollection<int, long>.CopyTo
	|-Dictionary.KeyCollection<int, object>.CopyTo
	|-Dictionary.KeyCollection<Int32Enum, object>.CopyTo
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.CopyTo
	|-Dictionary.KeyCollection<uint, object>.CopyTo
	|
	|-RVA: 0x12F8F20 Offset: 0x12F8120 VA: 0x1812F8F20
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.CopyTo
	|-Dictionary.KeyCollection<Int32Enum, Color>.CopyTo
	|
	|-RVA: 0x12F9D70 Offset: 0x12F8F70 VA: 0x1812F9D70
	|-Dictionary.KeyCollection<int, TreeItem>.CopyTo
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.CopyTo
	|
	|-RVA: 0x12FA6A0 Offset: 0x12F98A0 VA: 0x1812FA6A0
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.CopyTo
	|
	|-RVA: 0x12FA590 Offset: 0x12F9790 VA: 0x1812FA590
	|-Dictionary.KeyCollection<long, ComputedStyle>.CopyTo
	|
	|-RVA: 0x12F8E00 Offset: 0x12F8000 VA: 0x1812F8E00
	|-Dictionary.KeyCollection<IntVec3, object>.CopyTo
	|
	|-RVA: 0x12F97A0 Offset: 0x12F89A0 VA: 0x1812F97A0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.CopyTo
	|
	|-RVA: 0x12FA130 Offset: 0x12F9330 VA: 0x1812FA130
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.CopyTo
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.CopyTo
	|
	|-RVA: 0x12F9360 Offset: 0x12F8560 VA: 0x1812F9360
	|-Dictionary.KeyCollection<object, ResourceLocator>.CopyTo
	|-Dictionary.KeyCollection<object, StylePropertyValue>.CopyTo
	|-Dictionary.KeyCollection<object, XPathNodeRef>.CopyTo
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.CopyTo
	|
	|-RVA: 0x1308460 Offset: 0x1307660 VA: 0x181308460
	|-Dictionary.KeyCollection<UInt16Enum, object>.CopyTo
	|
	|-RVA: 0x1308130 Offset: 0x1307330 VA: 0x181308130
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.CopyTo
	|
	|-RVA: 0x1308690 Offset: 0x1307890 VA: 0x181308690
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.CopyTo
	|
	|-RVA: 0x1307D70 Offset: 0x1306F70 VA: 0x181307D70
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.CopyTo
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.CopyTo
	|
	|-RVA: 0x13088B0 Offset: 0x1307AB0 VA: 0x1813088B0
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.CopyTo
	|
	|-RVA: 0x13087A0 Offset: 0x13079A0 VA: 0x1813087A0
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.CopyTo
	|
	|-RVA: 0x1308240 Offset: 0x1307440 VA: 0x181308240
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x1308570 Offset: 0x1307770 VA: 0x181308570
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.CopyTo
	|
	|-RVA: 0x1307C50 Offset: 0x1306E50 VA: 0x181307C50
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04200 Offset: 0xD03400 VA: 0x180D04200
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.get_Count
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.get_Count
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.get_Count
	|-Dictionary.KeyCollection<byte, bool>.get_Count
	|-Dictionary.KeyCollection<byte, byte>.get_Count
	|-Dictionary.KeyCollection<byte, int>.get_Count
	|-Dictionary.KeyCollection<byte, object>.get_Count
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.get_Count
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.get_Count
	|-Dictionary.KeyCollection<ByteEnum, object>.get_Count
	|-Dictionary.KeyCollection<ByteEnum, float>.get_Count
	|-Dictionary.KeyCollection<char, int>.get_Count
	|-Dictionary.KeyCollection<Color, object>.get_Count
	|-Dictionary.KeyCollection<DateTime, object>.get_Count
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.get_Count
	|-Dictionary.KeyCollection<Guid, int>.get_Count
	|-Dictionary.KeyCollection<Guid, object>.get_Count
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Count
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.get_Count
	|-Dictionary.KeyCollection<int, bool>.get_Count
	|-Dictionary.KeyCollection<int, char>.get_Count
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.get_Count
	|-Dictionary.KeyCollection<int, int>.get_Count
	|-Dictionary.KeyCollection<int, Int32Enum>.get_Count
	|-Dictionary.KeyCollection<int, long>.get_Count
	|-Dictionary.KeyCollection<int, object>.get_Count
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.get_Count
	|-Dictionary.KeyCollection<int, float>.get_Count
	|-Dictionary.KeyCollection<int, TreeItem>.get_Count
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.get_Count
	|-Dictionary.KeyCollection<Int32Enum, bool>.get_Count
	|-Dictionary.KeyCollection<Int32Enum, Color>.get_Count
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.get_Count
	|-Dictionary.KeyCollection<Int32Enum, int>.get_Count
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.get_Count
	|-Dictionary.KeyCollection<Int32Enum, object>.get_Count
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.get_Count
	|-Dictionary.KeyCollection<Int32Enum, uint>.get_Count
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.get_Count
	|-Dictionary.KeyCollection<long, ComputedStyle>.get_Count
	|-Dictionary.KeyCollection<long, Int32Enum>.get_Count
	|-Dictionary.KeyCollection<long, object>.get_Count
	|-Dictionary.KeyCollection<IntPtr, object>.get_Count
	|-Dictionary.KeyCollection<IntVec3, object>.get_Count
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.get_Count
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.get_Count
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.get_Count
	|-Dictionary.KeyCollection<object, bool>.get_Count
	|-Dictionary.KeyCollection<object, Color32>.get_Count
	|-Dictionary.KeyCollection<object, int>.get_Count
	|-Dictionary.KeyCollection<object, Int32Enum>.get_Count
	|-Dictionary.KeyCollection<object, object>.get_Count
	|-Dictionary.KeyCollection<object, ResourceLocator>.get_Count
	|-Dictionary.KeyCollection<object, float>.get_Count
	|-Dictionary.KeyCollection<object, StylePropertyValue>.get_Count
	|-Dictionary.KeyCollection<object, TextureId>.get_Count
	|-Dictionary.KeyCollection<object, TimeSpan>.get_Count
	|-Dictionary.KeyCollection<object, uint>.get_Count
	|-Dictionary.KeyCollection<object, ulong>.get_Count
	|-Dictionary.KeyCollection<object, XPathNodeRef>.get_Count
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Count
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.get_Count
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.get_Count
	|-Dictionary.KeyCollection<UInt16Enum, object>.get_Count
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.get_Count
	|-Dictionary.KeyCollection<UInt16Enum, uint>.get_Count
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.get_Count
	|-Dictionary.KeyCollection<uint, int>.get_Count
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.get_Count
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.get_Count
	|-Dictionary.KeyCollection<uint, object>.get_Count
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.get_Count
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.get_Count
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.get_Count
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.get_Count
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.get_Count
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.get_Count
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.get_Count
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Count
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Count
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Count
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.get_Count
	|
	|-RVA: 0xD120E0 Offset: 0xD112E0 VA: 0x180D120E0
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<byte, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<ByteEnum, float>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<char, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Guid, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, TreeItem>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Int32Enum, uint>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<long, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, TextureId>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, TimeSpan>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<UInt16Enum, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<UInt16Enum, uint>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F6B80 Offset: 0x12F5D80 VA: 0x1812F6B80
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<byte, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<ByteEnum, float>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<char, int>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Guid, int>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, TreeItem>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Int32Enum, uint>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<long, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, TextureId>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, TimeSpan>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<UInt16Enum, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<UInt16Enum, uint>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TKey>.Add
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F6B80 Offset: 0x12F5D80 VA: 0x1812F6B80
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<byte, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<ByteEnum, float>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<char, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Guid, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, TreeItem>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Int32Enum, uint>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<long, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, TextureId>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, TimeSpan>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<UInt16Enum, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<UInt16Enum, uint>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F6C90 Offset: 0x12F5E90 VA: 0x1812F6C90
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12F6C50 Offset: 0x12F5E50 VA: 0x1812F6C50
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12F6CD0 Offset: 0x12F5ED0 VA: 0x1812F6CD0
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12F6C20 Offset: 0x12F5E20 VA: 0x1812F6C20
	|-Dictionary.KeyCollection<byte, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12F6B90 Offset: 0x12F5D90 VA: 0x1812F6B90
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12F6BC0 Offset: 0x12F5DC0 VA: 0x1812F6BC0
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12F6BF0 Offset: 0x12F5DF0 VA: 0x1812F6BF0
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<ByteEnum, float>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAF80 Offset: 0x12FA180 VA: 0x1812FAF80
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAF10 Offset: 0x12FA110 VA: 0x1812FAF10
	|-Dictionary.KeyCollection<char, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FB0A0 Offset: 0x12FA2A0 VA: 0x1812FB0A0
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FB000 Offset: 0x12FA200 VA: 0x1812FB000
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FB060 Offset: 0x12FA260 VA: 0x1812FB060
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAC60 Offset: 0x12F9E60 VA: 0x1812FAC60
	|-Dictionary.KeyCollection<Guid, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAD60 Offset: 0x12F9F60 VA: 0x1812FAD60
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FB1D0 Offset: 0x12FA3D0 VA: 0x1812FB1D0
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FACD0 Offset: 0x12F9ED0 VA: 0x1812FACD0
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAB50 Offset: 0x12F9D50 VA: 0x1812FAB50
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAE60 Offset: 0x12FA060 VA: 0x1812FAE60
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAE00 Offset: 0x12FA000 VA: 0x1812FAE00
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FB200 Offset: 0x12FA400 VA: 0x1812FB200
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FABB0 Offset: 0x12F9DB0 VA: 0x1812FABB0
	|-Dictionary.KeyCollection<int, TreeItem>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FB030 Offset: 0x12FA230 VA: 0x1812FB030
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAE90 Offset: 0x12FA090 VA: 0x1812FAE90
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<Int32Enum, uint>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FB1A0 Offset: 0x12FA3A0 VA: 0x1812FB1A0
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FABE0 Offset: 0x12F9DE0 VA: 0x1812FABE0
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAD00 Offset: 0x12F9F00 VA: 0x1812FAD00
	|-Dictionary.KeyCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAD30 Offset: 0x12F9F30 VA: 0x1812FAD30
	|-Dictionary.KeyCollection<long, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FB0E0 Offset: 0x12FA2E0 VA: 0x1812FB0E0
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAEC0 Offset: 0x12FA0C0 VA: 0x1812FAEC0
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FB110 Offset: 0x12FA310 VA: 0x1812FB110
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FB170 Offset: 0x12FA370 VA: 0x1812FB170
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FB140 Offset: 0x12FA340 VA: 0x1812FB140
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FACA0 Offset: 0x12F9EA0 VA: 0x1812FACA0
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, TextureId>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, TimeSpan>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x12FAB80 Offset: 0x12F9D80 VA: 0x1812FAB80
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308BC0 Offset: 0x1307DC0 VA: 0x181308BC0
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308A30 Offset: 0x1307C30 VA: 0x181308A30
	|-Dictionary.KeyCollection<UInt16Enum, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308C40 Offset: 0x1307E40 VA: 0x181308C40
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308D30 Offset: 0x1307F30 VA: 0x181308D30
	|-Dictionary.KeyCollection<UInt16Enum, uint>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308AE0 Offset: 0x1307CE0 VA: 0x181308AE0
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x13089D0 Offset: 0x1307BD0 VA: 0x1813089D0
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308A00 Offset: 0x1307C00 VA: 0x181308A00
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308B10 Offset: 0x1307D10 VA: 0x181308B10
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308CA0 Offset: 0x1307EA0 VA: 0x181308CA0
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308C70 Offset: 0x1307E70 VA: 0x181308C70
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308CD0 Offset: 0x1307ED0 VA: 0x181308CD0
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308D00 Offset: 0x1307F00 VA: 0x181308D00
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308B80 Offset: 0x1307D80 VA: 0x181308B80
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0xD06310 Offset: 0xD05510 VA: 0x180D06310
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308BF0 Offset: 0x1307DF0 VA: 0x181308BF0
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308A60 Offset: 0x1307C60 VA: 0x181308A60
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308B40 Offset: 0x1307D40 VA: 0x181308B40
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x1308AB0 Offset: 0x1307CB0 VA: 0x181308AB0
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F6D10 Offset: 0x12F5F10 VA: 0x1812F6D10
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<byte, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<ByteEnum, float>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<char, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Guid, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, TreeItem>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Int32Enum, uint>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<long, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, TextureId>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, TimeSpan>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<UInt16Enum, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<UInt16Enum, uint>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TKey>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF8C60 Offset: 0xCF7E60 VA: 0x180CF8C60
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Guid, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0xCF8A60 Offset: 0xCF7C60 VA: 0x180CF8A60
	|-Dictionary.KeyCollection<byte, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<ByteEnum, float>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0xCF8980 Offset: 0xCF7B80 VA: 0x180CF8980
	|-Dictionary.KeyCollection<char, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<UInt16Enum, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<UInt16Enum, uint>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0xCF88A0 Offset: 0xCF7AA0 VA: 0x180CF88A0
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<long, ComputedStyle>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<long, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, StylePropertyValue>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, TextureId>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, TimeSpan>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, XPathNodeRef>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0xCF89F0 Offset: 0xCF7BF0 VA: 0x180CF89F0
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, TreeItem>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, uint>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x12FB320 Offset: 0x12FA520 VA: 0x1812FB320
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0xD06E60 Offset: 0xD06060 VA: 0x180D06E60
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0xCF8EA0 Offset: 0xCF80A0 VA: 0x180CF8EA0
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF8C60 Offset: 0xCF7E60 VA: 0x180CF8C60
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Color, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Guid, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8A60 Offset: 0xCF7C60 VA: 0x180CF8A60
	|-Dictionary.KeyCollection<byte, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<byte, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<ByteEnum, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8980 Offset: 0xCF7B80 VA: 0x180CF8980
	|-Dictionary.KeyCollection<char, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<UInt16Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<UInt16Enum, uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF88A0 Offset: 0xCF7AA0 VA: 0x180CF88A0
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<long, ComputedStyle>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<long, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, float>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, StylePropertyValue>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, TextureId>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, TimeSpan>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, uint>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF89F0 Offset: 0xCF7BF0 VA: 0x180CF89F0
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, char>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, long>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, float>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, TreeItem>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, uint>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<uint, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12FB320 Offset: 0x12FA520 VA: 0x1812FB320
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD06E60 Offset: 0xD06060 VA: 0x180D06E60
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8EA0 Offset: 0xCF80A0 VA: 0x180CF8EA0
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F79B0 Offset: 0x12F6BB0 VA: 0x1812F79B0
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F8000 Offset: 0x12F7200 VA: 0x1812F8000
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F8650 Offset: 0x12F7850 VA: 0x1812F8650
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F7370 Offset: 0x12F6570 VA: 0x1812F7370
	|-Dictionary.KeyCollection<byte, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F8330 Offset: 0x12F7530 VA: 0x1812F8330
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F7690 Offset: 0x12F6890 VA: 0x1812F7690
	|-Dictionary.KeyCollection<byte, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F7050 Offset: 0x12F6250 VA: 0x1812F7050
	|-Dictionary.KeyCollection<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F7CE0 Offset: 0x12F6EE0 VA: 0x1812F7CE0
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F6D30 Offset: 0x12F5F30 VA: 0x1812F6D30
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1304FD0 Offset: 0x13041D0 VA: 0x181304FD0
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FCE20 Offset: 0x12FC020 VA: 0x1812FCE20
	|-Dictionary.KeyCollection<ByteEnum, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1302A60 Offset: 0x1301C60 VA: 0x181302A60
	|-Dictionary.KeyCollection<char, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FF0C0 Offset: 0x12FE2C0 VA: 0x1812FF0C0
	|-Dictionary.KeyCollection<Color, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1304380 Offset: 0x1303580 VA: 0x181304380
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1305D40 Offset: 0x1304F40 VA: 0x181305D40
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13046A0 Offset: 0x13038A0 VA: 0x1813046A0
	|-Dictionary.KeyCollection<Guid, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13030A0 Offset: 0x13022A0 VA: 0x1813030A0
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1304CB0 Offset: 0x1303EB0 VA: 0x181304CB0
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1301710 Offset: 0x1300910 VA: 0x181301710
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FDDA0 Offset: 0x12FCFA0 VA: 0x1812FDDA0
	|-Dictionary.KeyCollection<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13033D0 Offset: 0x13025D0 VA: 0x1813033D0
	|-Dictionary.KeyCollection<int, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FE0C0 Offset: 0x12FD2C0 VA: 0x1812FE0C0
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13052F0 Offset: 0x13044F0 VA: 0x1813052F0
	|-Dictionary.KeyCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1302420 Offset: 0x1301620 VA: 0x181302420
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FBF00 Offset: 0x12FB100 VA: 0x1812FBF00
	|-Dictionary.KeyCollection<int, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FF3F0 Offset: 0x12FE5F0 VA: 0x1812FF3F0
	|-Dictionary.KeyCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FF730 Offset: 0x12FE930 VA: 0x1812FF730
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1301A30 Offset: 0x1300C30 VA: 0x181301A30
	|-Dictionary.KeyCollection<int, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1302D80 Offset: 0x1301F80 VA: 0x181302D80
	|-Dictionary.KeyCollection<int, TreeItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1300760 Offset: 0x12FF960 VA: 0x181300760
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13039D0 Offset: 0x1302BD0 VA: 0x1813039D0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1302740 Offset: 0x1301940 VA: 0x181302740
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FD140 Offset: 0x12FC340 VA: 0x1812FD140
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FC820 Offset: 0x12FBA20 VA: 0x1812FC820
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FE3E0 Offset: 0x12FD5E0 VA: 0x1812FE3E0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FBBE0 Offset: 0x12FADE0 VA: 0x1812FBBE0
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1302100 Offset: 0x1301300 VA: 0x181302100
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1301080 Offset: 0x1300280 VA: 0x181301080
	|-Dictionary.KeyCollection<Int32Enum, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FFDC0 Offset: 0x12FEFC0 VA: 0x1812FFDC0
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1303CF0 Offset: 0x1302EF0 VA: 0x181303CF0
	|-Dictionary.KeyCollection<long, ComputedStyle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FE700 Offset: 0x12FD900 VA: 0x1812FE700
	|-Dictionary.KeyCollection<long, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FC220 Offset: 0x12FB420 VA: 0x1812FC220
	|-Dictionary.KeyCollection<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FD740 Offset: 0x12FC940 VA: 0x1812FD740
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FDA60 Offset: 0x12FCC60 VA: 0x1812FDA60
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1300D60 Offset: 0x12FFF60 VA: 0x181300D60
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FEA20 Offset: 0x12FDC20 VA: 0x1812FEA20
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1300480 Offset: 0x12FF680 VA: 0x181300480
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FCB40 Offset: 0x12FBD40 VA: 0x1812FCB40
	|-Dictionary.KeyCollection<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1300A80 Offset: 0x12FFC80 VA: 0x181300A80
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13036F0 Offset: 0x13028F0 VA: 0x1813036F0
	|-Dictionary.KeyCollection<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FD460 Offset: 0x12FC660 VA: 0x1812FD460
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13049D0 Offset: 0x1303BD0 VA: 0x1813049D0
	|-Dictionary.KeyCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1306070 Offset: 0x1305270 VA: 0x181306070
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FC540 Offset: 0x12FB740 VA: 0x1812FC540
	|-Dictionary.KeyCollection<object, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130DC40 Offset: 0x130CE40 VA: 0x18130DC40
	|-Dictionary.KeyCollection<object, StylePropertyValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130C010 Offset: 0x130B210 VA: 0x18130C010
	|-Dictionary.KeyCollection<object, TextureId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1309740 Offset: 0x1308940 VA: 0x181309740
	|-Dictionary.KeyCollection<object, TimeSpan>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130B410 Offset: 0x130A610 VA: 0x18130B410
	|-Dictionary.KeyCollection<object, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130C620 Offset: 0x130B820 VA: 0x18130C620
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1309A20 Offset: 0x1308C20 VA: 0x181309A20
	|-Dictionary.KeyCollection<object, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130A020 Offset: 0x1309220 VA: 0x18130A020
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130B6F0 Offset: 0x130A8F0 VA: 0x18130B6F0
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13090C0 Offset: 0x13082C0 VA: 0x1813090C0
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130D270 Offset: 0x130C470 VA: 0x18130D270
	|-Dictionary.KeyCollection<UInt16Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130BCF0 Offset: 0x130AEF0 VA: 0x18130BCF0
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130F480 Offset: 0x130E680 VA: 0x18130F480
	|-Dictionary.KeyCollection<UInt16Enum, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130F160 Offset: 0x130E360 VA: 0x18130F160
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130CF50 Offset: 0x130C150 VA: 0x18130CF50
	|-Dictionary.KeyCollection<uint, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130FAE0 Offset: 0x130ECE0 VA: 0x18130FAE0
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130A300 Offset: 0x1309500 VA: 0x18130A300
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130CC30 Offset: 0x130BE30 VA: 0x18130CC30
	|-Dictionary.KeyCollection<uint, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130D920 Offset: 0x130CB20 VA: 0x18130D920
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130B9D0 Offset: 0x130ABD0 VA: 0x18130B9D0
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130A620 Offset: 0x1309820 VA: 0x18130A620
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1308D90 Offset: 0x1307F90 VA: 0x181308D90
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130C900 Offset: 0x130BB00 VA: 0x18130C900
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1309D00 Offset: 0x1308F00 VA: 0x181309D00
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130E570 Offset: 0x130D770 VA: 0x18130E570
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130F7A0 Offset: 0x130E9A0 VA: 0x18130F7A0
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130B0E0 Offset: 0x130A2E0 VA: 0x18130B0E0
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130E240 Offset: 0x130D440 VA: 0x18130E240
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130C2F0 Offset: 0x130B4F0 VA: 0x18130C2F0
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130DF20 Offset: 0x130D120 VA: 0x18130DF20
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<byte, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<byte, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<byte, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<ByteEnum, float>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<char, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Color, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Guid, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, char>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, long>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, float>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, TreeItem>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Int32Enum, uint>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<long, ComputedStyle>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<long, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<long, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, float>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, StylePropertyValue>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, TextureId>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, TimeSpan>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, uint>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<UInt16Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<UInt16Enum, uint>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<uint, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<uint, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F8BB0 Offset: 0x12F7DB0 VA: 0x1812F8BB0
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x12F8AC0 Offset: 0x12F7CC0 VA: 0x1812F8AC0
	|-Dictionary.KeyCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x12F8B10 Offset: 0x12F7D10 VA: 0x1812F8B10
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x12F8A70 Offset: 0x12F7C70 VA: 0x1812F8A70
	|-Dictionary.KeyCollection<byte, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x12F8980 Offset: 0x12F7B80 VA: 0x1812F8980
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x12F8B60 Offset: 0x12F7D60 VA: 0x1812F8B60
	|-Dictionary.KeyCollection<byte, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x12F8A20 Offset: 0x12F7C20 VA: 0x1812F8A20
	|-Dictionary.KeyCollection<byte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x12F8C00 Offset: 0x12F7E00 VA: 0x1812F8C00
	|-Dictionary.KeyCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x12F89D0 Offset: 0x12F7BD0 VA: 0x1812F89D0
	|-Dictionary.KeyCollection<ByteEnum, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1307080 Offset: 0x1306280 VA: 0x181307080
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306440 Offset: 0x1305640 VA: 0x181306440
	|-Dictionary.KeyCollection<ByteEnum, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13064E0 Offset: 0x13056E0 VA: 0x1813064E0
	|-Dictionary.KeyCollection<char, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306D90 Offset: 0x1305F90 VA: 0x181306D90
	|-Dictionary.KeyCollection<Color, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306530 Offset: 0x1305730 VA: 0x181306530
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306670 Offset: 0x1305870 VA: 0x181306670
	|-Dictionary.KeyCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306350 Offset: 0x1305550 VA: 0x181306350
	|-Dictionary.KeyCollection<Guid, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1307620 Offset: 0x1306820 VA: 0x181307620
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1307120 Offset: 0x1306320 VA: 0x181307120
	|-Dictionary.KeyCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1307670 Offset: 0x1306870 VA: 0x181307670
	|-Dictionary.KeyCollection<int, TreeViewItemData<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1307440 Offset: 0x1306640 VA: 0x181307440
	|-Dictionary.KeyCollection<int, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13063A0 Offset: 0x13055A0 VA: 0x1813063A0
	|-Dictionary.KeyCollection<int, char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306AF0 Offset: 0x1305CF0 VA: 0x181306AF0
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1307490 Offset: 0x1306690 VA: 0x181307490
	|-Dictionary.KeyCollection<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306ED0 Offset: 0x13060D0 VA: 0x181306ED0
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13071C0 Offset: 0x13063C0 VA: 0x1813071C0
	|-Dictionary.KeyCollection<int, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13068A0 Offset: 0x1305AA0 VA: 0x1813068A0
	|-Dictionary.KeyCollection<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13070D0 Offset: 0x13062D0 VA: 0x1813070D0
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13068F0 Offset: 0x1305AF0 VA: 0x1813068F0
	|-Dictionary.KeyCollection<int, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306C30 Offset: 0x1305E30 VA: 0x181306C30
	|-Dictionary.KeyCollection<int, TreeItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306B90 Offset: 0x1305D90 VA: 0x181306B90
	|-Dictionary.KeyCollection<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306FE0 Offset: 0x13061E0 VA: 0x181306FE0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306990 Offset: 0x1305B90 VA: 0x181306990
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1307580 Offset: 0x1306780 VA: 0x181307580
	|-Dictionary.KeyCollection<Int32Enum, HatOptions>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1307300 Offset: 0x1306500 VA: 0x181307300
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13066C0 Offset: 0x13058C0 VA: 0x1813066C0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13067B0 Offset: 0x13059B0 VA: 0x1813067B0
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13065D0 Offset: 0x13057D0 VA: 0x1813065D0
	|-Dictionary.KeyCollection<Int32Enum, SkinOptions>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306850 Offset: 0x1305A50 VA: 0x181306850
	|-Dictionary.KeyCollection<Int32Enum, uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13072B0 Offset: 0x13064B0 VA: 0x1813072B0
	|-Dictionary.KeyCollection<Int32Enum, VisorOptions>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13073A0 Offset: 0x13065A0 VA: 0x1813073A0
	|-Dictionary.KeyCollection<long, ComputedStyle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13075D0 Offset: 0x13067D0 VA: 0x1813075D0
	|-Dictionary.KeyCollection<long, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306940 Offset: 0x1305B40 VA: 0x181306940
	|-Dictionary.KeyCollection<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1307170 Offset: 0x1306370 VA: 0x181307170
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1307530 Offset: 0x1306730 VA: 0x181307530
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306760 Offset: 0x1305960 VA: 0x181306760
	|-Dictionary.KeyCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306620 Offset: 0x1305820 VA: 0x181306620
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1307210 Offset: 0x1306410 VA: 0x181307210
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306490 Offset: 0x1305690 VA: 0x181306490
	|-Dictionary.KeyCollection<object, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306DE0 Offset: 0x1305FE0 VA: 0x181306DE0
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306BE0 Offset: 0x1305DE0 VA: 0x181306BE0
	|-Dictionary.KeyCollection<object, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13063F0 Offset: 0x13055F0 VA: 0x1813063F0
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306710 Offset: 0x1305910 VA: 0x181306710
	|-Dictionary.KeyCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306AA0 Offset: 0x1305CA0 VA: 0x181306AA0
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1306E30 Offset: 0x1306030 VA: 0x181306E30
	|-Dictionary.KeyCollection<object, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310210 Offset: 0x130F410 VA: 0x181310210
	|-Dictionary.KeyCollection<object, StylePropertyValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13102B0 Offset: 0x130F4B0 VA: 0x1813102B0
	|-Dictionary.KeyCollection<object, TextureId>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x130FEF0 Offset: 0x130F0F0 VA: 0x18130FEF0
	|-Dictionary.KeyCollection<object, TimeSpan>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13108C0 Offset: 0x130FAC0 VA: 0x1813108C0
	|-Dictionary.KeyCollection<object, uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310640 Offset: 0x130F840 VA: 0x181310640
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13105A0 Offset: 0x130F7A0 VA: 0x1813105A0
	|-Dictionary.KeyCollection<object, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310910 Offset: 0x130FB10 VA: 0x181310910
	|-Dictionary.KeyCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x130FF90 Offset: 0x130F190 VA: 0x18130FF90
	|-Dictionary.KeyCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310550 Offset: 0x130F750 VA: 0x181310550
	|-Dictionary.KeyCollection<TerrainTileCoord, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310170 Offset: 0x130F370 VA: 0x181310170
	|-Dictionary.KeyCollection<UInt16Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13103A0 Offset: 0x130F5A0 VA: 0x1813103A0
	|-Dictionary.KeyCollection<UInt16Enum, RoleRate>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310870 Offset: 0x130FA70 VA: 0x181310870
	|-Dictionary.KeyCollection<UInt16Enum, uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x130FE50 Offset: 0x130F050 VA: 0x18130FE50
	|-Dictionary.KeyCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310780 Offset: 0x130F980 VA: 0x181310780
	|-Dictionary.KeyCollection<uint, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13107D0 Offset: 0x130F9D0 VA: 0x1813107D0
	|-Dictionary.KeyCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13105F0 Offset: 0x130F7F0 VA: 0x1813105F0
	|-Dictionary.KeyCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310030 Offset: 0x130F230 VA: 0x181310030
	|-Dictionary.KeyCollection<uint, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x130FFE0 Offset: 0x130F1E0 VA: 0x18130FFE0
	|-Dictionary.KeyCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13106E0 Offset: 0x130F8E0 VA: 0x1813106E0
	|-Dictionary.KeyCollection<ulong, Helper.Allocation>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310690 Offset: 0x130F890 VA: 0x181310690
	|-Dictionary.KeyCollection<ulong, Helper.PinnedBuffer>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x130FEA0 Offset: 0x130F0A0 VA: 0x18130FEA0
	|-Dictionary.KeyCollection<Vector2, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310820 Offset: 0x130FA20 VA: 0x181310820
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310960 Offset: 0x130FB60 VA: 0x181310960
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x130FE00 Offset: 0x130F000 VA: 0x18130FE00
	|-Dictionary.KeyCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310120 Offset: 0x130F320 VA: 0x181310120
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x130FF40 Offset: 0x130F140 VA: 0x18130FF40
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310500 Offset: 0x130F700 VA: 0x181310500
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310300 Offset: 0x130F500 VA: 0x181310300
	|-Dictionary.KeyCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310350 Offset: 0x130F550 VA: 0x181310350
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.get_SyncRoot
	*/
}

// Namespace: 
[Serializable]
public struct Dictionary.ValueCollection.Enumerator<TKey, TValue> : IEnumerator<TValue>, IDisposable, IEnumerator // TypeDefIndex: 4432
{
	// Fields
	private Dictionary<TKey, TValue> _dictionary; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TValue _currentValue; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1116B80 Offset: 0x1115D80 VA: 0x181116B80
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<byte, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<Color, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<Guid, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-Dictionary.ValueCollection.Enumerator<int, long>..ctor
	|-Dictionary.ValueCollection.Enumerator<int, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<long, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, TimeSpan>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, ulong>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>..ctor
	|-Dictionary.ValueCollection.Enumerator<TerrainTileCoord, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, RoleRate>..ctor
	|-Dictionary.ValueCollection.Enumerator<uint, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x1116D70 Offset: 0x1115F70 VA: 0x181116D70
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0x1116C30 Offset: 0x1115E30 VA: 0x181116C30
	|-Dictionary.ValueCollection.Enumerator<byte, bool>..ctor
	|-Dictionary.ValueCollection.Enumerator<byte, byte>..ctor
	|-Dictionary.ValueCollection.Enumerator<int, bool>..ctor
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>..ctor
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, SkinOptions>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, bool>..ctor
	|
	|-RVA: 0x1116C60 Offset: 0x1115E60 VA: 0x181116C60
	|-Dictionary.ValueCollection.Enumerator<byte, int>..ctor
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, Int32Enum>..ctor
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, float>..ctor
	|-Dictionary.ValueCollection.Enumerator<char, int>..ctor
	|-Dictionary.ValueCollection.Enumerator<DiscardReasonWithCategory, int>..ctor
	|-Dictionary.ValueCollection.Enumerator<Guid, int>..ctor
	|-Dictionary.ValueCollection.Enumerator<int, int>..ctor
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>..ctor
	|-Dictionary.ValueCollection.Enumerator<int, float>..ctor
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, HatOptions>..ctor
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>..ctor
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>..ctor
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, uint>..ctor
	|-Dictionary.ValueCollection.Enumerator<long, Int32Enum>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, Color32>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, int>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, float>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, TextureId>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, uint>..ctor
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, uint>..ctor
	|-Dictionary.ValueCollection.Enumerator<uint, int>..ctor
	|-Dictionary.ValueCollection.Enumerator<Vector2, Int32Enum>..ctor
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x1116DF0 Offset: 0x1115FF0 VA: 0x181116DF0
	|-Dictionary.ValueCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|
	|-RVA: 0x111FFE0 Offset: 0x111F1E0 VA: 0x18111FFE0
	|-Dictionary.ValueCollection.Enumerator<int, TreeViewItemData<object>>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>..ctor
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.Allocation>..ctor
	|-Dictionary.ValueCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|
	|-RVA: 0x11200A0 Offset: 0x111F2A0 VA: 0x1811200A0
	|-Dictionary.ValueCollection.Enumerator<int, char>..ctor
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, VisorOptions>..ctor
	|
	|-RVA: 0x1120460 Offset: 0x111F660 VA: 0x181120460
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x1116C90 Offset: 0x1115E90 VA: 0x181116C90
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>..ctor
	|-Dictionary.ValueCollection.Enumerator<int, TreeItem>..ctor
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, StylePropertyValue>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, XPathNodeRef>..ctor
	|-Dictionary.ValueCollection.Enumerator<uint, VirtualHeap.PinnedBlob>..ctor
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.PinnedBuffer>..ctor
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x1126660 Offset: 0x1125860 VA: 0x181126660
	|-Dictionary.ValueCollection.Enumerator<int, TextResourceManager.FontAssetRef>..ctor
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x11267E0 Offset: 0x11259E0 VA: 0x1811267E0
	|-Dictionary.ValueCollection.Enumerator<long, ComputedStyle>..ctor
	|
	|-RVA: 0x112D4C0 Offset: 0x112C6C0 VA: 0x18112D4C0
	|-Dictionary.ValueCollection.Enumerator<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x113D500 Offset: 0x113C700 VA: 0x18113D500
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<byte, bool>.Dispose
	|-Dictionary.ValueCollection.Enumerator<byte, byte>.Dispose
	|-Dictionary.ValueCollection.Enumerator<byte, int>.Dispose
	|-Dictionary.ValueCollection.Enumerator<byte, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, Int32Enum>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, float>.Dispose
	|-Dictionary.ValueCollection.Enumerator<char, int>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Color, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<DiscardReasonWithCategory, int>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Guid, int>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, TreeViewItemData<object>>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, bool>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, char>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, int>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, long>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, float>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, TreeItem>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, TextResourceManager.FontAssetRef>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, HatOptions>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, SkinOptions>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, uint>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, VisorOptions>.Dispose
	|-Dictionary.ValueCollection.Enumerator<long, ComputedStyle>.Dispose
	|-Dictionary.ValueCollection.Enumerator<long, Int32Enum>.Dispose
	|-Dictionary.ValueCollection.Enumerator<long, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, bool>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, Color32>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, int>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, float>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, StylePropertyValue>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, TextureId>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, TimeSpan>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, uint>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, ulong>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, XPathNodeRef>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>.Dispose
	|-Dictionary.ValueCollection.Enumerator<TerrainTileCoord, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, RoleRate>.Dispose
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, uint>.Dispose
	|-Dictionary.ValueCollection.Enumerator<uint, GlyphPairAdjustmentRecord>.Dispose
	|-Dictionary.ValueCollection.Enumerator<uint, int>.Dispose
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>.Dispose
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>.Dispose
	|-Dictionary.ValueCollection.Enumerator<uint, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<uint, VirtualHeap.PinnedBlob>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.Allocation>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.PinnedBuffer>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Vector2, Int32Enum>.Dispose
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.Dispose
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	|-Dictionary.ValueCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.Dispose
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.Dispose
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112D70 Offset: 0x1111F70 VA: 0x181112D70
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Color, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.MoveNext
	|
	|-RVA: 0x1113300 Offset: 0x1112500 VA: 0x181113300
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.MoveNext
	|
	|-RVA: 0x1113AC0 Offset: 0x1112CC0 VA: 0x181113AC0
	|-Dictionary.ValueCollection.Enumerator<byte, bool>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<byte, byte>.MoveNext
	|
	|-RVA: 0x11131D0 Offset: 0x11123D0 VA: 0x1811131D0
	|-Dictionary.ValueCollection.Enumerator<byte, int>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, Int32Enum>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, float>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<char, int>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, int>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, float>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, HatOptions>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, uint>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, uint>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<uint, int>.MoveNext
	|
	|-RVA: 0x1113940 Offset: 0x1112B40 VA: 0x181113940
	|-Dictionary.ValueCollection.Enumerator<byte, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, long>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<long, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, TimeSpan>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, ulong>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<TerrainTileCoord, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<uint, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.MoveNext
	|
	|-RVA: 0x1112E00 Offset: 0x1112000 VA: 0x181112E00
	|-Dictionary.ValueCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.MoveNext
	|
	|-RVA: 0x1118A70 Offset: 0x1117C70 VA: 0x181118A70
	|-Dictionary.ValueCollection.Enumerator<DiscardReasonWithCategory, int>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.MoveNext
	|
	|-RVA: 0x1117FF0 Offset: 0x11171F0 VA: 0x181117FF0
	|-Dictionary.ValueCollection.Enumerator<Guid, int>.MoveNext
	|
	|-RVA: 0x1119570 Offset: 0x1118770 VA: 0x181119570
	|-Dictionary.ValueCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, RoleRate>.MoveNext
	|
	|-RVA: 0x11198D0 Offset: 0x1118AD0 VA: 0x1811198D0
	|-Dictionary.ValueCollection.Enumerator<int, TreeViewItemData<object>>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.Allocation>.MoveNext
	|
	|-RVA: 0x1119C70 Offset: 0x1118E70 VA: 0x181119C70
	|-Dictionary.ValueCollection.Enumerator<int, bool>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, SkinOptions>.MoveNext
	|
	|-RVA: 0x1118720 Offset: 0x1117920 VA: 0x181118720
	|-Dictionary.ValueCollection.Enumerator<int, char>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, VisorOptions>.MoveNext
	|
	|-RVA: 0x11170C0 Offset: 0x11162C0 VA: 0x1811170C0
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x1119E80 Offset: 0x1119080 VA: 0x181119E80
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>.MoveNext
	|
	|-RVA: 0x1121810 Offset: 0x1120A10 VA: 0x181121810
	|-Dictionary.ValueCollection.Enumerator<int, TreeItem>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, StylePropertyValue>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, XPathNodeRef>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<uint, VirtualHeap.PinnedBlob>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.PinnedBuffer>.MoveNext
	|
	|-RVA: 0x1120CD0 Offset: 0x111FED0 VA: 0x181120CD0
	|-Dictionary.ValueCollection.Enumerator<int, TextResourceManager.FontAssetRef>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x1121230 Offset: 0x1120430 VA: 0x181121230
	|-Dictionary.ValueCollection.Enumerator<long, ComputedStyle>.MoveNext
	|
	|-RVA: 0x1120700 Offset: 0x111F900 VA: 0x181120700
	|-Dictionary.ValueCollection.Enumerator<long, Int32Enum>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, Color32>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, int>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, float>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, TextureId>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, uint>.MoveNext
	|
	|-RVA: 0x1121E20 Offset: 0x1121020 VA: 0x181121E20
	|-Dictionary.ValueCollection.Enumerator<object, bool>.MoveNext
	|
	|-RVA: 0x1128290 Offset: 0x1127490 VA: 0x181128290
	|-Dictionary.ValueCollection.Enumerator<uint, GlyphPairAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x112F6A0 Offset: 0x112E8A0 VA: 0x18112F6A0
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x112FB40 Offset: 0x112ED40 VA: 0x18112FB40
	|-Dictionary.ValueCollection.Enumerator<Vector2, Int32Enum>.MoveNext
	|
	|-RVA: 0x112EEE0 Offset: 0x112E0E0 VA: 0x18112EEE0
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.MoveNext
	|
	|-RVA: 0x112FBD0 Offset: 0x112EDD0 VA: 0x18112FBD0
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x1130DC0 Offset: 0x112FFC0 VA: 0x181130DC0
	|-Dictionary.ValueCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.MoveNext
	|
	|-RVA: 0x1131950 Offset: 0x1130B50 VA: 0x181131950
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<byte, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Color, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, long>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<long, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, TimeSpan>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, ulong>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>.get_Current
	|-Dictionary.ValueCollection.Enumerator<TerrainTileCoord, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, RoleRate>.get_Current
	|-Dictionary.ValueCollection.Enumerator<uint, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.get_Current
	|
	|-RVA: 0x10EC0A0 Offset: 0x10EB2A0 VA: 0x1810EC0A0
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.get_Current
	|
	|-RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	|-Dictionary.ValueCollection.Enumerator<byte, bool>.get_Current
	|-Dictionary.ValueCollection.Enumerator<byte, byte>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, bool>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, SkinOptions>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, bool>.get_Current
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-Dictionary.ValueCollection.Enumerator<byte, int>.get_Current
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, Int32Enum>.get_Current
	|-Dictionary.ValueCollection.Enumerator<char, int>.get_Current
	|-Dictionary.ValueCollection.Enumerator<DiscardReasonWithCategory, int>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Guid, int>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, int>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, HatOptions>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, uint>.get_Current
	|-Dictionary.ValueCollection.Enumerator<long, Int32Enum>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, Color32>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, int>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, TextureId>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, uint>.get_Current
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, uint>.get_Current
	|-Dictionary.ValueCollection.Enumerator<uint, int>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Vector2, Int32Enum>.get_Current
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Current
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Current
	|
	|-RVA: 0x1116F40 Offset: 0x1116140 VA: 0x181116F40
	|-Dictionary.ValueCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.get_Current
	|
	|-RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, float>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, float>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, float>.get_Current
	|
	|-RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	|-Dictionary.ValueCollection.Enumerator<int, TreeViewItemData<object>>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.get_Current
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>.get_Current
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>.get_Current
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.Allocation>.get_Current
	|-Dictionary.ValueCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.get_Current
	|
	|-RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020
	|-Dictionary.ValueCollection.Enumerator<int, char>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, VisorOptions>.get_Current
	|
	|-RVA: 0x10F0C50 Offset: 0x10EFE50 VA: 0x1810F0C50
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.get_Current
	|
	|-RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, TreeItem>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, StylePropertyValue>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, XPathNodeRef>.get_Current
	|-Dictionary.ValueCollection.Enumerator<uint, VirtualHeap.PinnedBlob>.get_Current
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.PinnedBuffer>.get_Current
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.get_Current
	|
	|-RVA: 0x4FE170 Offset: 0x4FD370 VA: 0x1804FE170
	|-Dictionary.ValueCollection.Enumerator<int, TextResourceManager.FontAssetRef>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.get_Current
	|
	|-RVA: 0x1126AF0 Offset: 0x1125CF0 VA: 0x181126AF0
	|-Dictionary.ValueCollection.Enumerator<long, ComputedStyle>.get_Current
	|
	|-RVA: 0x10F0C70 Offset: 0x10EFE70 VA: 0x1810F0C70
	|-Dictionary.ValueCollection.Enumerator<uint, GlyphPairAdjustmentRecord>.get_Current
	|
	|-RVA: 0xE69B10 Offset: 0xE68D10 VA: 0x180E69B10
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114E20 Offset: 0x1114020 VA: 0x181114E20
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Color, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<TerrainTileCoord, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<uint, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1115C00 Offset: 0x1114E00 VA: 0x181115C00
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1114E60 Offset: 0x1114060 VA: 0x181114E60
	|-Dictionary.ValueCollection.Enumerator<byte, bool>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<byte, byte>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, SkinOptions>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1114DA0 Offset: 0x1113FA0 VA: 0x181114DA0
	|-Dictionary.ValueCollection.Enumerator<byte, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<char, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<DiscardReasonWithCategory, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Guid, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, HatOptions>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, uint>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<long, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, Color32>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, TextureId>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, uint>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, uint>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<uint, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Vector2, Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1116730 Offset: 0x1115930 VA: 0x181116730
	|-Dictionary.ValueCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111D570 Offset: 0x111C770 VA: 0x18111D570
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, float>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, float>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111DBB0 Offset: 0x111CDB0 VA: 0x18111DBB0
	|-Dictionary.ValueCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, TimeSpan>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, ulong>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, RoleRate>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111D2E0 Offset: 0x111C4E0 VA: 0x18111D2E0
	|-Dictionary.ValueCollection.Enumerator<int, TreeViewItemData<object>>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.Allocation>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111DB30 Offset: 0x111CD30 VA: 0x18111DB30
	|-Dictionary.ValueCollection.Enumerator<int, char>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, VisorOptions>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x111CFD0 Offset: 0x111C1D0 VA: 0x18111CFD0
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1115710 Offset: 0x1114910 VA: 0x181115710
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, TreeItem>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, StylePropertyValue>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<uint, VirtualHeap.PinnedBlob>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.PinnedBuffer>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1125100 Offset: 0x1124300 VA: 0x181125100
	|-Dictionary.ValueCollection.Enumerator<int, TextResourceManager.FontAssetRef>.System.Collections.IEnumerator.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1125260 Offset: 0x1124460 VA: 0x181125260
	|-Dictionary.ValueCollection.Enumerator<long, ComputedStyle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112ABF0 Offset: 0x1129DF0 VA: 0x18112ABF0
	|-Dictionary.ValueCollection.Enumerator<uint, GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113B0C0 Offset: 0x113A2C0 VA: 0x18113B0C0
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114A30 Offset: 0x1113C30 VA: 0x181114A30
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Color, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, TimeSpan>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, ulong>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, StyleComplexSelector.PseudoStateData>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<TerrainTileCoord, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, RoleRate>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<uint, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114CA0 Offset: 0x1113EA0 VA: 0x181114CA0
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114880 Offset: 0x1113A80 VA: 0x181114880
	|-Dictionary.ValueCollection.Enumerator<byte, bool>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<byte, byte>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, SkinOptions>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114980 Offset: 0x1113B80 VA: 0x181114980
	|-Dictionary.ValueCollection.Enumerator<byte, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, float>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<char, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<DiscardReasonWithCategory, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Guid, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<int, float>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, HatOptions>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, uint>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<long, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, Color32>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, TextureId>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, uint>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<UInt16Enum, uint>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<uint, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Vector2, Int32Enum>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114940 Offset: 0x1113B40 VA: 0x181114940
	|-Dictionary.ValueCollection.Enumerator<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x111C910 Offset: 0x111BB10 VA: 0x18111C910
	|-Dictionary.ValueCollection.Enumerator<int, TreeViewItemData<object>>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.Allocation>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x111C230 Offset: 0x111B430 VA: 0x18111C230
	|-Dictionary.ValueCollection.Enumerator<int, char>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, VisorOptions>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x111C850 Offset: 0x111BA50 VA: 0x18111C850
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1114AC0 Offset: 0x1113CC0 VA: 0x181114AC0
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<int, TreeItem>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, StylePropertyValue>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<uint, VirtualHeap.PinnedBlob>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<ulong, Helper.PinnedBuffer>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11232C0 Offset: 0x11224C0 VA: 0x1811232C0
	|-Dictionary.ValueCollection.Enumerator<int, TextResourceManager.FontAssetRef>.System.Collections.IEnumerator.Reset
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1123390 Offset: 0x1122590 VA: 0x181123390
	|-Dictionary.ValueCollection.Enumerator<long, ComputedStyle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1129FE0 Offset: 0x11291E0 VA: 0x181129FE0
	|-Dictionary.ValueCollection.Enumerator<uint, GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1137C20 Offset: 0x1136E20 VA: 0x181137C20
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<TKey, TValue>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public sealed class Dictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 4433
{
	// Fields
	private Dictionary<TKey, TValue> _dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04130 Offset: 0xD03330 VA: 0x180D04130
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>..ctor
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>..ctor
	|-Dictionary.ValueCollection<byte, bool>..ctor
	|-Dictionary.ValueCollection<byte, byte>..ctor
	|-Dictionary.ValueCollection<byte, int>..ctor
	|-Dictionary.ValueCollection<byte, object>..ctor
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>..ctor
	|-Dictionary.ValueCollection<ByteEnum, object>..ctor
	|-Dictionary.ValueCollection<ByteEnum, float>..ctor
	|-Dictionary.ValueCollection<char, int>..ctor
	|-Dictionary.ValueCollection<Color, object>..ctor
	|-Dictionary.ValueCollection<DateTime, object>..ctor
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>..ctor
	|-Dictionary.ValueCollection<Guid, int>..ctor
	|-Dictionary.ValueCollection<Guid, object>..ctor
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>..ctor
	|-Dictionary.ValueCollection<int, bool>..ctor
	|-Dictionary.ValueCollection<int, char>..ctor
	|-Dictionary.ValueCollection<int, DiagnosticEvent>..ctor
	|-Dictionary.ValueCollection<int, int>..ctor
	|-Dictionary.ValueCollection<int, Int32Enum>..ctor
	|-Dictionary.ValueCollection<int, long>..ctor
	|-Dictionary.ValueCollection<int, object>..ctor
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>..ctor
	|-Dictionary.ValueCollection<int, float>..ctor
	|-Dictionary.ValueCollection<int, TreeItem>..ctor
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>..ctor
	|-Dictionary.ValueCollection<Int32Enum, bool>..ctor
	|-Dictionary.ValueCollection<Int32Enum, Color>..ctor
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>..ctor
	|-Dictionary.ValueCollection<Int32Enum, int>..ctor
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>..ctor
	|-Dictionary.ValueCollection<Int32Enum, object>..ctor
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>..ctor
	|-Dictionary.ValueCollection<Int32Enum, uint>..ctor
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>..ctor
	|-Dictionary.ValueCollection<long, ComputedStyle>..ctor
	|-Dictionary.ValueCollection<long, Int32Enum>..ctor
	|-Dictionary.ValueCollection<long, object>..ctor
	|-Dictionary.ValueCollection<IntPtr, object>..ctor
	|-Dictionary.ValueCollection<IntVec3, object>..ctor
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>..ctor
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>..ctor
	|-Dictionary.ValueCollection<object, bool>..ctor
	|-Dictionary.ValueCollection<object, Color32>..ctor
	|-Dictionary.ValueCollection<object, int>..ctor
	|-Dictionary.ValueCollection<object, Int32Enum>..ctor
	|-Dictionary.ValueCollection<object, object>..ctor
	|-Dictionary.ValueCollection<object, ResourceLocator>..ctor
	|-Dictionary.ValueCollection<object, float>..ctor
	|-Dictionary.ValueCollection<object, StylePropertyValue>..ctor
	|-Dictionary.ValueCollection<object, TextureId>..ctor
	|-Dictionary.ValueCollection<object, TimeSpan>..ctor
	|-Dictionary.ValueCollection<object, uint>..ctor
	|-Dictionary.ValueCollection<object, ulong>..ctor
	|-Dictionary.ValueCollection<object, XPathNodeRef>..ctor
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>..ctor
	|-Dictionary.ValueCollection<TerrainTileCoord, object>..ctor
	|-Dictionary.ValueCollection<UInt16Enum, object>..ctor
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>..ctor
	|-Dictionary.ValueCollection<UInt16Enum, uint>..ctor
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>..ctor
	|-Dictionary.ValueCollection<uint, int>..ctor
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary.ValueCollection<uint, object>..ctor
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>..ctor
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>..ctor
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>..ctor
	|-Dictionary.ValueCollection<Vector2, Int32Enum>..ctor
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>..ctor
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>..ctor
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7C90 Offset: 0xCF6E90 VA: 0x180CF7C90
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.GetEnumerator
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.GetEnumerator
	|-Dictionary.ValueCollection<byte, object>.GetEnumerator
	|-Dictionary.ValueCollection<ByteEnum, object>.GetEnumerator
	|-Dictionary.ValueCollection<Color, object>.GetEnumerator
	|-Dictionary.ValueCollection<DateTime, object>.GetEnumerator
	|-Dictionary.ValueCollection<Guid, object>.GetEnumerator
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.GetEnumerator
	|-Dictionary.ValueCollection<int, long>.GetEnumerator
	|-Dictionary.ValueCollection<int, object>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, object>.GetEnumerator
	|-Dictionary.ValueCollection<long, object>.GetEnumerator
	|-Dictionary.ValueCollection<IntPtr, object>.GetEnumerator
	|-Dictionary.ValueCollection<IntVec3, object>.GetEnumerator
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.GetEnumerator
	|-Dictionary.ValueCollection<object, object>.GetEnumerator
	|-Dictionary.ValueCollection<object, TimeSpan>.GetEnumerator
	|-Dictionary.ValueCollection<object, ulong>.GetEnumerator
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.GetEnumerator
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.GetEnumerator
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.GetEnumerator
	|-Dictionary.ValueCollection<UInt16Enum, object>.GetEnumerator
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.GetEnumerator
	|-Dictionary.ValueCollection<uint, object>.GetEnumerator
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.GetEnumerator
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.GetEnumerator
	|
	|-RVA: 0xCF7FA0 Offset: 0xCF71A0 VA: 0x180CF7FA0
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.GetEnumerator
	|
	|-RVA: 0xCF7CD0 Offset: 0xCF6ED0 VA: 0x180CF7CD0
	|-Dictionary.ValueCollection<byte, bool>.GetEnumerator
	|-Dictionary.ValueCollection<byte, byte>.GetEnumerator
	|-Dictionary.ValueCollection<int, bool>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, bool>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.GetEnumerator
	|-Dictionary.ValueCollection<object, bool>.GetEnumerator
	|
	|-RVA: 0xCF7C50 Offset: 0xCF6E50 VA: 0x180CF7C50
	|-Dictionary.ValueCollection<byte, int>.GetEnumerator
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.GetEnumerator
	|-Dictionary.ValueCollection<ByteEnum, float>.GetEnumerator
	|-Dictionary.ValueCollection<char, int>.GetEnumerator
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.GetEnumerator
	|-Dictionary.ValueCollection<Guid, int>.GetEnumerator
	|-Dictionary.ValueCollection<int, int>.GetEnumerator
	|-Dictionary.ValueCollection<int, Int32Enum>.GetEnumerator
	|-Dictionary.ValueCollection<int, float>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, int>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, uint>.GetEnumerator
	|-Dictionary.ValueCollection<long, Int32Enum>.GetEnumerator
	|-Dictionary.ValueCollection<object, Color32>.GetEnumerator
	|-Dictionary.ValueCollection<object, int>.GetEnumerator
	|-Dictionary.ValueCollection<object, Int32Enum>.GetEnumerator
	|-Dictionary.ValueCollection<object, float>.GetEnumerator
	|-Dictionary.ValueCollection<object, TextureId>.GetEnumerator
	|-Dictionary.ValueCollection<object, uint>.GetEnumerator
	|-Dictionary.ValueCollection<UInt16Enum, uint>.GetEnumerator
	|-Dictionary.ValueCollection<uint, int>.GetEnumerator
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.GetEnumerator
	|
	|-RVA: 0xCF7E20 Offset: 0xCF7020 VA: 0x180CF7E20
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.GetEnumerator
	|
	|-RVA: 0xCF7D10 Offset: 0xCF6F10 VA: 0x180CF7D10
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.GetEnumerator
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.GetEnumerator
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.GetEnumerator
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.GetEnumerator
	|
	|-RVA: 0xCF7D50 Offset: 0xCF6F50 VA: 0x180CF7D50
	|-Dictionary.ValueCollection<int, char>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.GetEnumerator
	|
	|-RVA: 0xCF7E60 Offset: 0xCF7060 VA: 0x180CF7E60
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0xCF7EA0 Offset: 0xCF70A0 VA: 0x180CF7EA0
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.GetEnumerator
	|-Dictionary.ValueCollection<int, TreeItem>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, Color>.GetEnumerator
	|-Dictionary.ValueCollection<object, ResourceLocator>.GetEnumerator
	|-Dictionary.ValueCollection<object, StylePropertyValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, XPathNodeRef>.GetEnumerator
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.GetEnumerator
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.GetEnumerator
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.GetEnumerator
	|
	|-RVA: 0xCF7EE0 Offset: 0xCF70E0 VA: 0x180CF7EE0
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.GetEnumerator
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.GetEnumerator
	|
	|-RVA: 0xCF7C00 Offset: 0xCF6E00 VA: 0x180CF7C00
	|-Dictionary.ValueCollection<long, ComputedStyle>.GetEnumerator
	|
	|-RVA: 0xD05EC0 Offset: 0xD050C0 VA: 0x180D05EC0
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0xD05D60 Offset: 0xD04F60 VA: 0x180D05D60
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF6CB0 Offset: 0xCF5EB0 VA: 0x180CF6CB0
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.CopyTo
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.CopyTo
	|-Dictionary.ValueCollection<Color, object>.CopyTo
	|-Dictionary.ValueCollection<Guid, object>.CopyTo
	|-Dictionary.ValueCollection<IntVec3, object>.CopyTo
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.CopyTo
	|
	|-RVA: 0xCF6840 Offset: 0xCF5A40 VA: 0x180CF6840
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.CopyTo
	|
	|-RVA: 0xCF6FE0 Offset: 0xCF61E0 VA: 0x180CF6FE0
	|-Dictionary.ValueCollection<byte, bool>.CopyTo
	|-Dictionary.ValueCollection<byte, byte>.CopyTo
	|
	|-RVA: 0xCF61C0 Offset: 0xCF53C0 VA: 0x180CF61C0
	|-Dictionary.ValueCollection<byte, int>.CopyTo
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.CopyTo
	|-Dictionary.ValueCollection<ByteEnum, float>.CopyTo
	|-Dictionary.ValueCollection<char, int>.CopyTo
	|-Dictionary.ValueCollection<int, int>.CopyTo
	|-Dictionary.ValueCollection<int, Int32Enum>.CopyTo
	|-Dictionary.ValueCollection<int, float>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, int>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, uint>.CopyTo
	|-Dictionary.ValueCollection<UInt16Enum, uint>.CopyTo
	|-Dictionary.ValueCollection<uint, int>.CopyTo
	|
	|-RVA: 0xCF60B0 Offset: 0xCF52B0 VA: 0x180CF60B0
	|-Dictionary.ValueCollection<byte, object>.CopyTo
	|-Dictionary.ValueCollection<ByteEnum, object>.CopyTo
	|-Dictionary.ValueCollection<DateTime, object>.CopyTo
	|-Dictionary.ValueCollection<int, long>.CopyTo
	|-Dictionary.ValueCollection<int, object>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, object>.CopyTo
	|-Dictionary.ValueCollection<long, object>.CopyTo
	|-Dictionary.ValueCollection<IntPtr, object>.CopyTo
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.CopyTo
	|-Dictionary.ValueCollection<object, object>.CopyTo
	|-Dictionary.ValueCollection<object, TimeSpan>.CopyTo
	|-Dictionary.ValueCollection<object, ulong>.CopyTo
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.CopyTo
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.CopyTo
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.CopyTo
	|-Dictionary.ValueCollection<UInt16Enum, object>.CopyTo
	|-Dictionary.ValueCollection<uint, object>.CopyTo
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.CopyTo
	|
	|-RVA: 0xCF6600 Offset: 0xCF5800 VA: 0x180CF6600
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.CopyTo
	|
	|-RVA: 0xCF62D0 Offset: 0xCF54D0 VA: 0x180CF62D0
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.CopyTo
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.CopyTo
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.CopyTo
	|
	|-RVA: 0xCF6A90 Offset: 0xCF5C90 VA: 0x180CF6A90
	|-Dictionary.ValueCollection<Guid, int>.CopyTo
	|
	|-RVA: 0xCF6ED0 Offset: 0xCF60D0 VA: 0x180CF6ED0
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.CopyTo
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.CopyTo
	|
	|-RVA: 0xCF6970 Offset: 0xCF5B70 VA: 0x180CF6970
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.CopyTo
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.CopyTo
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.CopyTo
	|
	|-RVA: 0xCF6DC0 Offset: 0xCF5FC0 VA: 0x180CF6DC0
	|-Dictionary.ValueCollection<int, bool>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, bool>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.CopyTo
	|
	|-RVA: 0xCF5FA0 Offset: 0xCF51A0 VA: 0x180CF5FA0
	|-Dictionary.ValueCollection<int, char>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.CopyTo
	|
	|-RVA: 0xCF7940 Offset: 0xCF6B40 VA: 0x180CF7940
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.CopyTo
	|
	|-RVA: 0xCF64F0 Offset: 0xCF56F0 VA: 0x180CF64F0
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, Color>.CopyTo
	|
	|-RVA: 0xCF6BA0 Offset: 0xCF5DA0 VA: 0x180CF6BA0
	|-Dictionary.ValueCollection<int, TreeItem>.CopyTo
	|-Dictionary.ValueCollection<object, ResourceLocator>.CopyTo
	|-Dictionary.ValueCollection<object, StylePropertyValue>.CopyTo
	|-Dictionary.ValueCollection<object, XPathNodeRef>.CopyTo
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.CopyTo
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.CopyTo
	|
	|-RVA: 0xCF6720 Offset: 0xCF5920 VA: 0x180CF6720
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.CopyTo
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.CopyTo
	|
	|-RVA: 0xCF7280 Offset: 0xCF6480 VA: 0x180CF7280
	|-Dictionary.ValueCollection<long, ComputedStyle>.CopyTo
	|
	|-RVA: 0xCF63E0 Offset: 0xCF55E0 VA: 0x180CF63E0
	|-Dictionary.ValueCollection<long, Int32Enum>.CopyTo
	|-Dictionary.ValueCollection<object, Color32>.CopyTo
	|-Dictionary.ValueCollection<object, int>.CopyTo
	|-Dictionary.ValueCollection<object, Int32Enum>.CopyTo
	|-Dictionary.ValueCollection<object, float>.CopyTo
	|-Dictionary.ValueCollection<object, TextureId>.CopyTo
	|-Dictionary.ValueCollection<object, uint>.CopyTo
	|
	|-RVA: 0xD04C80 Offset: 0xD03E80 VA: 0x180D04C80
	|-Dictionary.ValueCollection<object, bool>.CopyTo
	|
	|-RVA: 0xD04D90 Offset: 0xD03F90 VA: 0x180D04D90
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.CopyTo
	|
	|-RVA: 0xD04EC0 Offset: 0xD040C0 VA: 0x180D04EC0
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.CopyTo
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.CopyTo
	|
	|-RVA: 0xD05960 Offset: 0xD04B60 VA: 0x180D05960
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.CopyTo
	|
	|-RVA: 0xD05C10 Offset: 0xD04E10 VA: 0x180D05C10
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.CopyTo
	|
	|-RVA: 0xD048D0 Offset: 0xD03AD0 VA: 0x180D048D0
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0xD04FE0 Offset: 0xD041E0 VA: 0x180D04FE0
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.CopyTo
	|
	|-RVA: 0xD05600 Offset: 0xD04800 VA: 0x180D05600
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04200 Offset: 0xD03400 VA: 0x180D04200
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.get_Count
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.get_Count
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.get_Count
	|-Dictionary.ValueCollection<byte, bool>.get_Count
	|-Dictionary.ValueCollection<byte, byte>.get_Count
	|-Dictionary.ValueCollection<byte, int>.get_Count
	|-Dictionary.ValueCollection<byte, object>.get_Count
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.get_Count
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.get_Count
	|-Dictionary.ValueCollection<ByteEnum, object>.get_Count
	|-Dictionary.ValueCollection<ByteEnum, float>.get_Count
	|-Dictionary.ValueCollection<char, int>.get_Count
	|-Dictionary.ValueCollection<Color, object>.get_Count
	|-Dictionary.ValueCollection<DateTime, object>.get_Count
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.get_Count
	|-Dictionary.ValueCollection<Guid, int>.get_Count
	|-Dictionary.ValueCollection<Guid, object>.get_Count
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Count
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.get_Count
	|-Dictionary.ValueCollection<int, bool>.get_Count
	|-Dictionary.ValueCollection<int, char>.get_Count
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.get_Count
	|-Dictionary.ValueCollection<int, int>.get_Count
	|-Dictionary.ValueCollection<int, Int32Enum>.get_Count
	|-Dictionary.ValueCollection<int, long>.get_Count
	|-Dictionary.ValueCollection<int, object>.get_Count
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.get_Count
	|-Dictionary.ValueCollection<int, float>.get_Count
	|-Dictionary.ValueCollection<int, TreeItem>.get_Count
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, bool>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, Color>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, int>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, object>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, uint>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.get_Count
	|-Dictionary.ValueCollection<long, ComputedStyle>.get_Count
	|-Dictionary.ValueCollection<long, Int32Enum>.get_Count
	|-Dictionary.ValueCollection<long, object>.get_Count
	|-Dictionary.ValueCollection<IntPtr, object>.get_Count
	|-Dictionary.ValueCollection<IntVec3, object>.get_Count
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.get_Count
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.get_Count
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.get_Count
	|-Dictionary.ValueCollection<object, bool>.get_Count
	|-Dictionary.ValueCollection<object, Color32>.get_Count
	|-Dictionary.ValueCollection<object, int>.get_Count
	|-Dictionary.ValueCollection<object, Int32Enum>.get_Count
	|-Dictionary.ValueCollection<object, object>.get_Count
	|-Dictionary.ValueCollection<object, ResourceLocator>.get_Count
	|-Dictionary.ValueCollection<object, float>.get_Count
	|-Dictionary.ValueCollection<object, StylePropertyValue>.get_Count
	|-Dictionary.ValueCollection<object, TextureId>.get_Count
	|-Dictionary.ValueCollection<object, TimeSpan>.get_Count
	|-Dictionary.ValueCollection<object, uint>.get_Count
	|-Dictionary.ValueCollection<object, ulong>.get_Count
	|-Dictionary.ValueCollection<object, XPathNodeRef>.get_Count
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Count
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.get_Count
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.get_Count
	|-Dictionary.ValueCollection<UInt16Enum, object>.get_Count
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.get_Count
	|-Dictionary.ValueCollection<UInt16Enum, uint>.get_Count
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.get_Count
	|-Dictionary.ValueCollection<uint, int>.get_Count
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.get_Count
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.get_Count
	|-Dictionary.ValueCollection<uint, object>.get_Count
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.get_Count
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.get_Count
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.get_Count
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.get_Count
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.get_Count
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.get_Count
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.get_Count
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Count
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Count
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Count
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.get_Count
	|
	|-RVA: 0xD120E0 Offset: 0xD112E0 VA: 0x180D120E0
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<byte, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<byte, byte>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<byte, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ByteEnum, float>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<char, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Guid, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, uint>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<long, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, TimeSpan>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<UInt16Enum, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<UInt16Enum, uint>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7FE0 Offset: 0xCF71E0 VA: 0x180CF7FE0
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<byte, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<byte, byte>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<byte, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ByteEnum, float>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<char, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Guid, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, uint>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<long, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, TimeSpan>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<UInt16Enum, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<UInt16Enum, uint>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF8880 Offset: 0xCF7A80 VA: 0x180CF8880
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<byte, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<byte, byte>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<byte, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ByteEnum, float>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<char, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Guid, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, uint>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<long, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, TimeSpan>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<UInt16Enum, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<UInt16Enum, uint>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7FE0 Offset: 0xCF71E0 VA: 0x180CF7FE0
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<byte, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<byte, byte>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<byte, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ByteEnum, float>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<char, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Guid, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, uint>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<long, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, TimeSpan>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<UInt16Enum, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<UInt16Enum, uint>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF8070 Offset: 0xCF7270 VA: 0x180CF8070
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8340 Offset: 0xCF7540 VA: 0x180CF8340
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8660 Offset: 0xCF7860 VA: 0x180CF8660
	|-Dictionary.ValueCollection<byte, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8120 Offset: 0xCF7320 VA: 0x180CF8120
	|-Dictionary.ValueCollection<byte, byte>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8150 Offset: 0xCF7350 VA: 0x180CF8150
	|-Dictionary.ValueCollection<byte, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<char, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF82B0 Offset: 0xCF74B0 VA: 0x180CF82B0
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<UInt16Enum, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF87A0 Offset: 0xCF79A0 VA: 0x180CF87A0
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF80F0 Offset: 0xCF72F0 VA: 0x180CF80F0
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8400 Offset: 0xCF7600 VA: 0x180CF8400
	|-Dictionary.ValueCollection<ByteEnum, float>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8250 Offset: 0xCF7450 VA: 0x180CF8250
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8690 Offset: 0xCF7890 VA: 0x180CF8690
	|-Dictionary.ValueCollection<Guid, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8430 Offset: 0xCF7630 VA: 0x180CF8430
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8610 Offset: 0xCF7810 VA: 0x180CF8610
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF83A0 Offset: 0xCF75A0 VA: 0x180CF83A0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8810 Offset: 0xCF7A10 VA: 0x180CF8810
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF80A0 Offset: 0xCF72A0 VA: 0x180CF80A0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8540 Offset: 0xCF7740 VA: 0x180CF8540
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8840 Offset: 0xCF7A40 VA: 0x180CF8840
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8760 Offset: 0xCF7960 VA: 0x180CF8760
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF84F0 Offset: 0xCF76F0 VA: 0x180CF84F0
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF86F0 Offset: 0xCF78F0 VA: 0x180CF86F0
	|-Dictionary.ValueCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF84C0 Offset: 0xCF76C0 VA: 0x180CF84C0
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8460 Offset: 0xCF7660 VA: 0x180CF8460
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8310 Offset: 0xCF7510 VA: 0x180CF8310
	|-Dictionary.ValueCollection<Int32Enum, uint>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<UInt16Enum, uint>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8280 Offset: 0xCF7480 VA: 0x180CF8280
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF8570 Offset: 0xCF7770 VA: 0x180CF8570
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xCF82E0 Offset: 0xCF74E0 VA: 0x180CF82E0
	|-Dictionary.ValueCollection<long, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06AF0 Offset: 0xD05CF0 VA: 0x180D06AF0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06C00 Offset: 0xD05E00 VA: 0x180D06C00
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD066B0 Offset: 0xD058B0 VA: 0x180D066B0
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06CD0 Offset: 0xD05ED0 VA: 0x180D06CD0
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD060D0 Offset: 0xD052D0 VA: 0x180D060D0
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD062D0 Offset: 0xD054D0 VA: 0x180D062D0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD069B0 Offset: 0xD05BB0 VA: 0x180D069B0
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD066E0 Offset: 0xD058E0 VA: 0x180D066E0
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06450 Offset: 0xD05650 VA: 0x180D06450
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06AC0 Offset: 0xD05CC0 VA: 0x180D06AC0
	|-Dictionary.ValueCollection<object, TimeSpan>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06480 Offset: 0xD05680 VA: 0x180D06480
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06980 Offset: 0xD05B80 VA: 0x180D06980
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06910 Offset: 0xD05B10 VA: 0x180D06910
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD064B0 Offset: 0xD056B0 VA: 0x180D064B0
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06950 Offset: 0xD05B50 VA: 0x180D06950
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06260 Offset: 0xD05460 VA: 0x180D06260
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD064E0 Offset: 0xD056E0 VA: 0x180D064E0
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06400 Offset: 0xD05600 VA: 0x180D06400
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06A20 Offset: 0xD05C20 VA: 0x180D06A20
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD069E0 Offset: 0xD05BE0 VA: 0x180D069E0
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06BB0 Offset: 0xD05DB0 VA: 0x180D06BB0
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06290 Offset: 0xD05490 VA: 0x180D06290
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06100 Offset: 0xD05300 VA: 0x180D06100
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06B70 Offset: 0xD05D70 VA: 0x180D06B70
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06310 Offset: 0xD05510 VA: 0x180D06310
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06A70 Offset: 0xD05C70 VA: 0x180D06A70
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06CA0 Offset: 0xD05EA0 VA: 0x180D06CA0
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD068E0 Offset: 0xD05AE0 VA: 0x180D068E0
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF88A0 Offset: 0xCF7AA0 VA: 0x180CF88A0
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ByteEnum, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, TimeSpan>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<UInt16Enum, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xCF8BB0 Offset: 0xCF7DB0 VA: 0x180CF8BB0
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xCF8A60 Offset: 0xCF7C60 VA: 0x180CF8A60
	|-Dictionary.ValueCollection<byte, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<byte, byte>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xCF89F0 Offset: 0xCF7BF0 VA: 0x180CF89F0
	|-Dictionary.ValueCollection<byte, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ByteEnum, float>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<char, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Guid, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, uint>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<long, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<UInt16Enum, uint>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xCF8910 Offset: 0xCF7B10 VA: 0x180CF8910
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xCF8EA0 Offset: 0xCF80A0 VA: 0x180CF8EA0
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xCF8980 Offset: 0xCF7B80 VA: 0x180CF8980
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xCF8F20 Offset: 0xCF8120 VA: 0x180CF8F20
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xCF8C60 Offset: 0xCF7E60 VA: 0x180CF8C60
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, Color>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xCF8CD0 Offset: 0xCF7ED0 VA: 0x180CF8CD0
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xCF8DC0 Offset: 0xCF7FC0 VA: 0x180CF8DC0
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xD07090 Offset: 0xD06290 VA: 0x180D07090
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xD06E60 Offset: 0xD06060 VA: 0x180D06E60
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF88A0 Offset: 0xCF7AA0 VA: 0x180CF88A0
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ByteEnum, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Color, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, long>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, TimeSpan>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<UInt16Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8BB0 Offset: 0xCF7DB0 VA: 0x180CF8BB0
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8A60 Offset: 0xCF7C60 VA: 0x180CF8A60
	|-Dictionary.ValueCollection<byte, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<byte, byte>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF89F0 Offset: 0xCF7BF0 VA: 0x180CF89F0
	|-Dictionary.ValueCollection<byte, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ByteEnum, float>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<char, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Guid, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, float>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, uint>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<long, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, float>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, uint>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<UInt16Enum, uint>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8910 Offset: 0xCF7B10 VA: 0x180CF8910
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8EA0 Offset: 0xCF80A0 VA: 0x180CF8EA0
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8980 Offset: 0xCF7B80 VA: 0x180CF8980
	|-Dictionary.ValueCollection<int, char>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8F20 Offset: 0xCF8120 VA: 0x180CF8F20
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8C60 Offset: 0xCF7E60 VA: 0x180CF8C60
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, Color>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8CD0 Offset: 0xCF7ED0 VA: 0x180CF8CD0
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCF8DC0 Offset: 0xCF7FC0 VA: 0x180CF8DC0
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD07090 Offset: 0xD06290 VA: 0x180D07090
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD06E60 Offset: 0xD06060 VA: 0x180D06E60
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD00420 Offset: 0xCFF620 VA: 0x180D00420
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFC2B0 Offset: 0xCFB4B0 VA: 0x180CFC2B0
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFC620 Offset: 0xCFB820 VA: 0x180CFC620
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFCF10 Offset: 0xCFC110 VA: 0x180CFCF10
	|-Dictionary.ValueCollection<byte, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFF120 Offset: 0xCFE320 VA: 0x180CFF120
	|-Dictionary.ValueCollection<byte, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD029F0 Offset: 0xD01BF0 VA: 0x180D029F0
	|-Dictionary.ValueCollection<byte, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFDB60 Offset: 0xCFCD60 VA: 0x180CFDB60
	|-Dictionary.ValueCollection<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD026C0 Offset: 0xD018C0 VA: 0x180D026C0
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFA070 Offset: 0xCF9270 VA: 0x180CFA070
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD00D50 Offset: 0xCFFF50 VA: 0x180D00D50
	|-Dictionary.ValueCollection<ByteEnum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFB8D0 Offset: 0xCFAAD0 VA: 0x180CFB8D0
	|-Dictionary.ValueCollection<ByteEnum, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFEE00 Offset: 0xCFE000 VA: 0x180CFEE00
	|-Dictionary.ValueCollection<char, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFCC30 Offset: 0xCFBE30 VA: 0x180CFCC30
	|-Dictionary.ValueCollection<Color, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFE490 Offset: 0xCFD690 VA: 0x180CFE490
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD01360 Offset: 0xD00560 VA: 0x180D01360
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFF440 Offset: 0xCFE640 VA: 0x180CFF440
	|-Dictionary.ValueCollection<Guid, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFA9A0 Offset: 0xCF9BA0 VA: 0x180CFA9A0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFE780 Offset: 0xCFD980 VA: 0x180CFE780
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCF8FB0 Offset: 0xCF81B0 VA: 0x180CF8FB0
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFE170 Offset: 0xCFD370 VA: 0x180CFE170
	|-Dictionary.ValueCollection<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFD840 Offset: 0xCFCA40 VA: 0x180CFD840
	|-Dictionary.ValueCollection<int, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFEAA0 Offset: 0xCFDCA0 VA: 0x180CFEAA0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD019B0 Offset: 0xD00BB0 VA: 0x180D019B0
	|-Dictionary.ValueCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD02D10 Offset: 0xD01F10 VA: 0x180D02D10
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFFAA0 Offset: 0xCFECA0 VA: 0x180CFFAA0
	|-Dictionary.ValueCollection<int, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFA390 Offset: 0xCF9590 VA: 0x180CFA390
	|-Dictionary.ValueCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD00A20 Offset: 0xCFFC20 VA: 0x180D00A20
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFB5B0 Offset: 0xCFA7B0 VA: 0x180CFB5B0
	|-Dictionary.ValueCollection<int, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD01680 Offset: 0xD00880 VA: 0x180D01680
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFBBF0 Offset: 0xCFADF0 VA: 0x180CFBBF0
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFD230 Offset: 0xCFC430 VA: 0x180CFD230
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFC900 Offset: 0xCFBB00 VA: 0x180CFC900
	|-Dictionary.ValueCollection<Int32Enum, Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFA680 Offset: 0xCF9880 VA: 0x180CFA680
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFF760 Offset: 0xCFE960 VA: 0x180CFF760
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCF9D50 Offset: 0xCF8F50 VA: 0x180CF9D50
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFAF60 Offset: 0xCFA160 VA: 0x180CFAF60
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCF9A30 Offset: 0xCF8C30 VA: 0x180CF9A30
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD00700 Offset: 0xCFF900 VA: 0x180D00700
	|-Dictionary.ValueCollection<Int32Enum, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD01040 Offset: 0xD00240 VA: 0x180D01040
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCF9690 Offset: 0xCF8890 VA: 0x180CF9690
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFDE50 Offset: 0xCFD050 VA: 0x180CFDE50
	|-Dictionary.ValueCollection<long, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD00130 Offset: 0xCFF330 VA: 0x180D00130
	|-Dictionary.ValueCollection<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD023D0 Offset: 0xD015D0 VA: 0x180D023D0
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFAC80 Offset: 0xCF9E80 VA: 0x180CFAC80
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFD550 Offset: 0xCFC750 VA: 0x180CFD550
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD093B0 Offset: 0xD085B0 VA: 0x180D093B0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0DB20 Offset: 0xD0CD20 VA: 0x180D0DB20
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0D4E0 Offset: 0xD0C6E0 VA: 0x180D0D4E0
	|-Dictionary.ValueCollection<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0AB60 Offset: 0xD09D60 VA: 0x180D0AB60
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD10830 Offset: 0xD0FA30 VA: 0x180D10830
	|-Dictionary.ValueCollection<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0D800 Offset: 0xD0CA00 VA: 0x180D0D800
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0BC00 Offset: 0xD0AE00 VA: 0x180D0BC00
	|-Dictionary.ValueCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD07D00 Offset: 0xD06F00 VA: 0x180D07D00
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0AE80 Offset: 0xD0A080 VA: 0x180D0AE80
	|-Dictionary.ValueCollection<object, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0B5E0 Offset: 0xD0A7E0 VA: 0x180D0B5E0
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD09A80 Offset: 0xD08C80 VA: 0x180D09A80
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0C540 Offset: 0xD0B740 VA: 0x180D0C540
	|-Dictionary.ValueCollection<object, TimeSpan>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0C220 Offset: 0xD0B420 VA: 0x180D0C220
	|-Dictionary.ValueCollection<object, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD10B50 Offset: 0xD0FD50 VA: 0x180D10B50
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0E1A0 Offset: 0xD0D3A0 VA: 0x180D0E1A0
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD101F0 Offset: 0xD0F3F0 VA: 0x180D101F0
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0F5D0 Offset: 0xD0E7D0 VA: 0x180D0F5D0
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD08DA0 Offset: 0xD07FA0 VA: 0x180D08DA0
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD08030 Offset: 0xD07230 VA: 0x180D08030
	|-Dictionary.ValueCollection<UInt16Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0D1C0 Offset: 0xD0C3C0 VA: 0x180D0D1C0
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD079E0 Offset: 0xD06BE0 VA: 0x180D079E0
	|-Dictionary.ValueCollection<UInt16Enum, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0E870 Offset: 0xD0DA70 VA: 0x180D0E870
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0CE80 Offset: 0xD0C080 VA: 0x180D0CE80
	|-Dictionary.ValueCollection<uint, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD08320 Offset: 0xD07520 VA: 0x180D08320
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0C860 Offset: 0xD0BA60 VA: 0x180D0C860
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0B910 Offset: 0xD0AB10 VA: 0x180D0B910
	|-Dictionary.ValueCollection<uint, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0FBD0 Offset: 0xD0EDD0 VA: 0x180D0FBD0
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0DE60 Offset: 0xD0D060 VA: 0x180D0DE60
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0BEF0 Offset: 0xD0B0F0 VA: 0x180D0BEF0
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD10510 Offset: 0xD0F710 VA: 0x180D10510
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0EF00 Offset: 0xD0E100 VA: 0x180D0EF00
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0EBE0 Offset: 0xD0DDE0 VA: 0x180D0EBE0
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD08660 Offset: 0xD07860 VA: 0x180D08660
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0CBA0 Offset: 0xD0BDA0 VA: 0x180D0CBA0
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD09090 Offset: 0xD08290 VA: 0x180D09090
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0A840 Offset: 0xD09A40 VA: 0x180D0A840
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0F8F0 Offset: 0xD0EAF0 VA: 0x180D0F8F0
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD0FF00 Offset: 0xD0F100 VA: 0x180D0FF00
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<byte, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<byte, byte>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<byte, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<byte, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ByteEnum, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ByteEnum, float>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<char, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Color, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Guid, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, char>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, long>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, float>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, Color>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, uint>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<long, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<long, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, float>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, TimeSpan>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, uint>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<UInt16Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<UInt16Enum, uint>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD03710 Offset: 0xD02910 VA: 0x180D03710
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03080 Offset: 0xD02280 VA: 0x180D03080
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03760 Offset: 0xD02960 VA: 0x180D03760
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03C80 Offset: 0xD02E80 VA: 0x180D03C80
	|-Dictionary.ValueCollection<byte, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03A30 Offset: 0xD02C30 VA: 0x180D03A30
	|-Dictionary.ValueCollection<byte, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03170 Offset: 0xD02370 VA: 0x180D03170
	|-Dictionary.ValueCollection<byte, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD031C0 Offset: 0xD023C0 VA: 0x180D031C0
	|-Dictionary.ValueCollection<byte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03940 Offset: 0xD02B40 VA: 0x180D03940
	|-Dictionary.ValueCollection<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD030D0 Offset: 0xD022D0 VA: 0x180D030D0
	|-Dictionary.ValueCollection<ByteEnum, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD036C0 Offset: 0xD028C0 VA: 0x180D036C0
	|-Dictionary.ValueCollection<ByteEnum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03350 Offset: 0xD02550 VA: 0x180D03350
	|-Dictionary.ValueCollection<ByteEnum, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD034E0 Offset: 0xD026E0 VA: 0x180D034E0
	|-Dictionary.ValueCollection<char, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03FF0 Offset: 0xD031F0 VA: 0x180D03FF0
	|-Dictionary.ValueCollection<Color, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03DC0 Offset: 0xD02FC0 VA: 0x180D03DC0
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03D70 Offset: 0xD02F70 VA: 0x180D03D70
	|-Dictionary.ValueCollection<DiscardReasonWithCategory, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03800 Offset: 0xD02A00 VA: 0x180D03800
	|-Dictionary.ValueCollection<Guid, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD038F0 Offset: 0xD02AF0 VA: 0x180D038F0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03300 Offset: 0xD02500 VA: 0x180D03300
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD035D0 Offset: 0xD027D0 VA: 0x180D035D0
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03210 Offset: 0xD02410 VA: 0x180D03210
	|-Dictionary.ValueCollection<int, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03260 Offset: 0xD02460 VA: 0x180D03260
	|-Dictionary.ValueCollection<int, char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD039E0 Offset: 0xD02BE0 VA: 0x180D039E0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03CD0 Offset: 0xD02ED0 VA: 0x180D03CD0
	|-Dictionary.ValueCollection<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03F50 Offset: 0xD03150 VA: 0x180D03F50
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03530 Offset: 0xD02730 VA: 0x180D03530
	|-Dictionary.ValueCollection<int, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD04040 Offset: 0xD03240 VA: 0x180D04040
	|-Dictionary.ValueCollection<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03D20 Offset: 0xD02F20 VA: 0x180D03D20
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03E10 Offset: 0xD03010 VA: 0x180D03E10
	|-Dictionary.ValueCollection<int, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03850 Offset: 0xD02A50 VA: 0x180D03850
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03990 Offset: 0xD02B90 VA: 0x180D03990
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03030 Offset: 0xD02230 VA: 0x180D03030
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03E60 Offset: 0xD03060 VA: 0x180D03E60
	|-Dictionary.ValueCollection<Int32Enum, Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03A80 Offset: 0xD02C80 VA: 0x180D03A80
	|-Dictionary.ValueCollection<Int32Enum, HatOptions>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD033A0 Offset: 0xD025A0 VA: 0x180D033A0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03EB0 Offset: 0xD030B0 VA: 0x180D03EB0
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03AD0 Offset: 0xD02CD0 VA: 0x180D03AD0
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03FA0 Offset: 0xD031A0 VA: 0x180D03FA0
	|-Dictionary.ValueCollection<Int32Enum, SkinOptions>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03120 Offset: 0xD02320 VA: 0x180D03120
	|-Dictionary.ValueCollection<Int32Enum, uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03C30 Offset: 0xD02E30 VA: 0x180D03C30
	|-Dictionary.ValueCollection<Int32Enum, VisorOptions>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD04090 Offset: 0xD03290 VA: 0x180D04090
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03620 Offset: 0xD02820 VA: 0x180D03620
	|-Dictionary.ValueCollection<long, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD033F0 Offset: 0xD025F0 VA: 0x180D033F0
	|-Dictionary.ValueCollection<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03B20 Offset: 0xD02D20 VA: 0x180D03B20
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03490 Offset: 0xD02690 VA: 0x180D03490
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD03440 Offset: 0xD02640 VA: 0x180D03440
	|-Dictionary.ValueCollection<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD115B0 Offset: 0xD107B0 VA: 0x180D115B0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11E20 Offset: 0xD11020 VA: 0x180D11E20
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11310 Offset: 0xD10510 VA: 0x180D11310
	|-Dictionary.ValueCollection<object, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD10E70 Offset: 0xD10070 VA: 0x180D10E70
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD117E0 Offset: 0xD109E0 VA: 0x180D117E0
	|-Dictionary.ValueCollection<object, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11020 Offset: 0xD10220 VA: 0x180D11020
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD118D0 Offset: 0xD10AD0 VA: 0x180D118D0
	|-Dictionary.ValueCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD116A0 Offset: 0xD108A0 VA: 0x180D116A0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD110C0 Offset: 0xD102C0 VA: 0x180D110C0
	|-Dictionary.ValueCollection<object, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11470 Offset: 0xD10670 VA: 0x180D11470
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD112C0 Offset: 0xD104C0 VA: 0x180D112C0
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11880 Offset: 0xD10A80 VA: 0x180D11880
	|-Dictionary.ValueCollection<object, TimeSpan>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11270 Offset: 0xD10470 VA: 0x180D11270
	|-Dictionary.ValueCollection<object, uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11110 Offset: 0xD10310 VA: 0x180D11110
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11970 Offset: 0xD10B70 VA: 0x180D11970
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11A10 Offset: 0xD10C10 VA: 0x180D11A10
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11B50 Offset: 0xD10D50 VA: 0x180D11B50
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD116F0 Offset: 0xD108F0 VA: 0x180D116F0
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11D80 Offset: 0xD10F80 VA: 0x180D11D80
	|-Dictionary.ValueCollection<UInt16Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11D30 Offset: 0xD10F30 VA: 0x180D11D30
	|-Dictionary.ValueCollection<UInt16Enum, RoleRate>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11600 Offset: 0xD10800 VA: 0x180D11600
	|-Dictionary.ValueCollection<UInt16Enum, uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11740 Offset: 0xD10940 VA: 0x180D11740
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11A60 Offset: 0xD10C60 VA: 0x180D11A60
	|-Dictionary.ValueCollection<uint, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD119C0 Offset: 0xD10BC0 VA: 0x180D119C0
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11DD0 Offset: 0xD10FD0 VA: 0x180D11DD0
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11BF0 Offset: 0xD10DF0 VA: 0x180D11BF0
	|-Dictionary.ValueCollection<uint, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11E70 Offset: 0xD11070 VA: 0x180D11E70
	|-Dictionary.ValueCollection<uint, VirtualHeap.PinnedBlob>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11560 Offset: 0xD10760 VA: 0x180D11560
	|-Dictionary.ValueCollection<ulong, Helper.Allocation>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11790 Offset: 0xD10990 VA: 0x180D11790
	|-Dictionary.ValueCollection<ulong, Helper.PinnedBuffer>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11360 Offset: 0xD10560 VA: 0x180D11360
	|-Dictionary.ValueCollection<Vector2, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11650 Offset: 0xD10850 VA: 0x180D11650
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD10FD0 Offset: 0xD101D0 VA: 0x180D10FD0
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11F10 Offset: 0xD11110 VA: 0x180D11F10
	|-Dictionary.ValueCollection<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11830 Offset: 0xD10A30 VA: 0x180D11830
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11B00 Offset: 0xD10D00 VA: 0x180D11B00
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11920 Offset: 0xD10B20 VA: 0x180D11920
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11BA0 Offset: 0xD10DA0 VA: 0x180D11BA0
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD11F60 Offset: 0xD11160 VA: 0x180D11F60
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.get_SyncRoot
	*/
}

// Namespace: System.Collections.Generic
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView<K, V>))]
[DefaultMember("Item")]
[Serializable]
public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback // TypeDefIndex: 4434
{
	// Fields
	private int[] _buckets; // 0x0
	private Dictionary.Entry<TKey, TValue>[] _entries; // 0x0
	private int _count; // 0x0
	private int _freeList; // 0x0
	private int _freeCount; // 0x0
	private int _version; // 0x0
	private IEqualityComparer<TKey> _comparer; // 0x0
	private Dictionary.KeyCollection<TKey, TValue> _keys; // 0x0
	private Dictionary.ValueCollection<TKey, TValue> _values; // 0x0
	private object _syncRoot; // 0x0
	private const string VersionName = "Version";
	private const string HashSizeName = "HashSize";
	private const string KeyValuePairsName = "KeyValuePairs";
	private const string ComparerName = "Comparer";

	// Properties
	public IEqualityComparer<TKey> Comparer { get; }
	public int Count { get; }
	public Dictionary.KeyCollection<TKey, TValue> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public Dictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	public TValue Item { get; set; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFDE880 Offset: 0xFDDA80 VA: 0x180FDE880
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0xFE00C0 Offset: 0xFDF2C0 VA: 0x180FE00C0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0xFE0070 Offset: 0xFDF270 VA: 0x180FE0070
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0xFDE8D0 Offset: 0xFDDAD0 VA: 0x180FDE8D0
	|-Dictionary<byte, bool>..ctor
	|-Dictionary<byte, byte>..ctor
	|-Dictionary<byte, int>..ctor
	|-Dictionary<byte, object>..ctor
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|
	|-RVA: 0xFF0E80 Offset: 0xFF0080 VA: 0x180FF0E80
	|-Dictionary<ByteEnum, Int32Enum>..ctor
	|-Dictionary<ByteEnum, object>..ctor
	|-Dictionary<ByteEnum, float>..ctor
	|
	|-RVA: 0xFF1F00 Offset: 0xFF1100 VA: 0x180FF1F00
	|-Dictionary<char, int>..ctor
	|
	|-RVA: 0x10094B0 Offset: 0x10086B0 VA: 0x1810094B0
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x1009AD0 Offset: 0x1008CD0 VA: 0x181009AD0
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x10099D0 Offset: 0x1008BD0 VA: 0x1810099D0
	|-Dictionary<DiscardReasonWithCategory, int>..ctor
	|
	|-RVA: 0x10073F0 Offset: 0x10065F0 VA: 0x1810073F0
	|-Dictionary<Guid, int>..ctor
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x1007770 Offset: 0x1006970 VA: 0x181007770
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|-Dictionary<int, bool>..ctor
	|-Dictionary<int, char>..ctor
	|-Dictionary<int, DiagnosticEvent>..ctor
	|-Dictionary<int, int>..ctor
	|-Dictionary<int, Int32Enum>..ctor
	|-Dictionary<int, long>..ctor
	|-Dictionary<int, object>..ctor
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|-Dictionary<int, float>..ctor
	|-Dictionary<int, TreeItem>..ctor
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x102D280 Offset: 0x102C480 VA: 0x18102D280
	|-Dictionary<Int32Enum, bool>..ctor
	|-Dictionary<Int32Enum, Color>..ctor
	|-Dictionary<Int32Enum, HatOptions>..ctor
	|-Dictionary<Int32Enum, int>..ctor
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|-Dictionary<Int32Enum, object>..ctor
	|-Dictionary<Int32Enum, SkinOptions>..ctor
	|-Dictionary<Int32Enum, uint>..ctor
	|-Dictionary<Int32Enum, VisorOptions>..ctor
	|
	|-RVA: 0x103ED30 Offset: 0x103DF30 VA: 0x18103ED30
	|-Dictionary<long, ComputedStyle>..ctor
	|-Dictionary<long, Int32Enum>..ctor
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x1068C90 Offset: 0x1067E90 VA: 0x181068C90
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x106AC30 Offset: 0x1069E30 VA: 0x18106AC30
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x1069EE0 Offset: 0x10690E0 VA: 0x181069EE0
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|
	|-RVA: 0x106ABC0 Offset: 0x1069DC0 VA: 0x18106ABC0
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|-Dictionary<object, bool>..ctor
	|-Dictionary<object, Color32>..ctor
	|-Dictionary<object, int>..ctor
	|-Dictionary<object, Int32Enum>..ctor
	|-Dictionary<object, object>..ctor
	|-Dictionary<object, ResourceLocator>..ctor
	|-Dictionary<object, float>..ctor
	|-Dictionary<object, StylePropertyValue>..ctor
	|-Dictionary<object, TextureId>..ctor
	|-Dictionary<object, TimeSpan>..ctor
	|-Dictionary<object, uint>..ctor
	|-Dictionary<object, ulong>..ctor
	|-Dictionary<object, XPathNodeRef>..ctor
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x109FE20 Offset: 0x109F020 VA: 0x18109FE20
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x109EC50 Offset: 0x109DE50 VA: 0x18109EC50
	|-Dictionary<UInt16Enum, object>..ctor
	|-Dictionary<UInt16Enum, RoleRate>..ctor
	|-Dictionary<UInt16Enum, uint>..ctor
	|
	|-RVA: 0x109D8D0 Offset: 0x109CAD0 VA: 0x18109D8D0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|-Dictionary<uint, int>..ctor
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary<uint, object>..ctor
	|-Dictionary<uint, VirtualHeap.PinnedBlob>..ctor
	|
	|-RVA: 0x10B25C0 Offset: 0x10B17C0 VA: 0x1810B25C0
	|-Dictionary<ulong, Helper.Allocation>..ctor
	|-Dictionary<ulong, Helper.PinnedBuffer>..ctor
	|
	|-RVA: 0x10B53E0 Offset: 0x10B45E0 VA: 0x1810B53E0
	|-Dictionary<Vector2, Int32Enum>..ctor
	|
	|-RVA: 0x10CD930 Offset: 0x10CCB30 VA: 0x1810CD930
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x10CBBE0 Offset: 0x10CADE0 VA: 0x1810CBBE0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x10CBB90 Offset: 0x10CAD90 VA: 0x1810CBB90
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|
	|-RVA: 0x10CA330 Offset: 0x10C9530 VA: 0x1810CA330
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x10C9FF0 Offset: 0x10C91F0 VA: 0x1810C9FF0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x10D12D0 Offset: 0x10D04D0 VA: 0x1810D12D0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE0470 Offset: 0xFDF670 VA: 0x180FE0470
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0xFDF890 Offset: 0xFDEA90 VA: 0x180FDF890
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0xFDF8B0 Offset: 0xFDEAB0 VA: 0x180FDF8B0
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0xFDF8D0 Offset: 0xFDEAD0 VA: 0x180FDF8D0
	|-Dictionary<byte, bool>..ctor
	|
	|-RVA: 0xFDF980 Offset: 0xFDEB80 VA: 0x180FDF980
	|-Dictionary<byte, byte>..ctor
	|
	|-RVA: 0xFF3510 Offset: 0xFF2710 VA: 0x180FF3510
	|-Dictionary<byte, int>..ctor
	|
	|-RVA: 0xFF3530 Offset: 0xFF2730 VA: 0x180FF3530
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0xFF3340 Offset: 0xFF2540 VA: 0x180FF3340
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|
	|-RVA: 0xFF3250 Offset: 0xFF2450 VA: 0x180FF3250
	|-Dictionary<ByteEnum, Int32Enum>..ctor
	|
	|-RVA: 0xFF3320 Offset: 0xFF2520 VA: 0x180FF3320
	|-Dictionary<ByteEnum, object>..ctor
	|
	|-RVA: 0xFF3BB0 Offset: 0xFF2DB0 VA: 0x180FF3BB0
	|-Dictionary<ByteEnum, float>..ctor
	|
	|-RVA: 0xFF3550 Offset: 0xFF2750 VA: 0x180FF3550
	|-Dictionary<char, int>..ctor
	|
	|-RVA: 0x1009A20 Offset: 0x1008C20 VA: 0x181009A20
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x1007730 Offset: 0x1006930 VA: 0x181007730
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x10099B0 Offset: 0x1008BB0 VA: 0x1810099B0
	|-Dictionary<DiscardReasonWithCategory, int>..ctor
	|
	|-RVA: 0x1006F50 Offset: 0x1006150 VA: 0x181006F50
	|-Dictionary<Guid, int>..ctor
	|
	|-RVA: 0x1009860 Offset: 0x1008A60 VA: 0x181009860
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x1005E90 Offset: 0x1005090 VA: 0x181005E90
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x10088A0 Offset: 0x1007AA0 VA: 0x1810088A0
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x1018E90 Offset: 0x1018090 VA: 0x181018E90
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x101B560 Offset: 0x101A760 VA: 0x18101B560
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x1019200 Offset: 0x1018400 VA: 0x181019200
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x101B580 Offset: 0x101A780 VA: 0x18101B580
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x1019DB0 Offset: 0x1018FB0 VA: 0x181019DB0
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x1019C70 Offset: 0x1018E70 VA: 0x181019C70
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x1019890 Offset: 0x1018A90 VA: 0x181019890
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x10300B0 Offset: 0x102F2B0 VA: 0x1810300B0
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x102D810 Offset: 0x102CA10 VA: 0x18102D810
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x102C720 Offset: 0x102B920 VA: 0x18102C720
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x102DC30 Offset: 0x102CE30 VA: 0x18102DC30
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x102CB60 Offset: 0x102BD60 VA: 0x18102CB60
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x102F1F0 Offset: 0x102E3F0 VA: 0x18102F1F0
	|-Dictionary<Int32Enum, Color>..ctor
	|
	|-RVA: 0x102D2D0 Offset: 0x102C4D0 VA: 0x18102D2D0
	|-Dictionary<Int32Enum, HatOptions>..ctor
	|
	|-RVA: 0x1040A40 Offset: 0x103FC40 VA: 0x181040A40
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x1041340 Offset: 0x1040540 VA: 0x181041340
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x1041B00 Offset: 0x1040D00 VA: 0x181041B00
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x103F4D0 Offset: 0x103E6D0 VA: 0x18103F4D0
	|-Dictionary<Int32Enum, SkinOptions>..ctor
	|
	|-RVA: 0x1041B60 Offset: 0x1040D60 VA: 0x181041B60
	|-Dictionary<Int32Enum, uint>..ctor
	|
	|-RVA: 0x103F140 Offset: 0x103E340 VA: 0x18103F140
	|-Dictionary<Int32Enum, VisorOptions>..ctor
	|
	|-RVA: 0x103E950 Offset: 0x103DB50 VA: 0x18103E950
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x106A4A0 Offset: 0x10696A0 VA: 0x18106A4A0
	|-Dictionary<long, Int32Enum>..ctor
	|
	|-RVA: 0x106B050 Offset: 0x106A250 VA: 0x18106B050
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x1069F30 Offset: 0x1069130 VA: 0x181069F30
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x10688E0 Offset: 0x1067AE0 VA: 0x1810688E0
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x106A480 Offset: 0x1069680 VA: 0x18106A480
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|
	|-RVA: 0x1069800 Offset: 0x1068A00 VA: 0x181069800
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x106B030 Offset: 0x106A230 VA: 0x18106B030
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x107A1C0 Offset: 0x10793C0 VA: 0x18107A1C0
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x107D140 Offset: 0x107C340 VA: 0x18107D140
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x107A270 Offset: 0x1079470 VA: 0x18107A270
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x107B4E0 Offset: 0x107A6E0 VA: 0x18107B4E0
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x107D840 Offset: 0x107CA40 VA: 0x18107D840
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x107BF70 Offset: 0x107B170 VA: 0x18107BF70
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x107C370 Offset: 0x107B570 VA: 0x18107C370
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x108A2C0 Offset: 0x10894C0 VA: 0x18108A2C0
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x108BE90 Offset: 0x108B090 VA: 0x18108BE90
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x108D490 Offset: 0x108C690 VA: 0x18108D490
	|-Dictionary<object, TimeSpan>..ctor
	|
	|-RVA: 0x108D4B0 Offset: 0x108C6B0 VA: 0x18108D4B0
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x108A2A0 Offset: 0x10894A0 VA: 0x18108A2A0
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x108D4D0 Offset: 0x108C6D0 VA: 0x18108D4D0
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x108A1B0 Offset: 0x10893B0 VA: 0x18108A1B0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x109FE00 Offset: 0x109F000 VA: 0x18109FE00
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x109F490 Offset: 0x109E690 VA: 0x18109F490
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x109E970 Offset: 0x109DB70 VA: 0x18109E970
	|-Dictionary<UInt16Enum, object>..ctor
	|
	|-RVA: 0x109E990 Offset: 0x109DB90 VA: 0x18109E990
	|-Dictionary<UInt16Enum, RoleRate>..ctor
	|
	|-RVA: 0x109F750 Offset: 0x109E950 VA: 0x18109F750
	|-Dictionary<UInt16Enum, uint>..ctor
	|
	|-RVA: 0x109FF00 Offset: 0x109F100 VA: 0x18109FF00
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x109F790 Offset: 0x109E990 VA: 0x18109F790
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x10B3EC0 Offset: 0x10B30C0 VA: 0x1810B3EC0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B5940 Offset: 0x10B4B40 VA: 0x1810B5940
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B1D10 Offset: 0x10B0F10 VA: 0x1810B1D10
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x10B5430 Offset: 0x10B4630 VA: 0x1810B5430
	|-Dictionary<uint, VirtualHeap.PinnedBlob>..ctor
	|
	|-RVA: 0x10B20C0 Offset: 0x10B12C0 VA: 0x1810B20C0
	|-Dictionary<ulong, Helper.Allocation>..ctor
	|
	|-RVA: 0x10B3F70 Offset: 0x10B3170 VA: 0x1810B3F70
	|-Dictionary<ulong, Helper.PinnedBuffer>..ctor
	|
	|-RVA: 0x10B3F90 Offset: 0x10B3190 VA: 0x1810B3F90
	|-Dictionary<Vector2, Int32Enum>..ctor
	|
	|-RVA: 0x10C9E40 Offset: 0x10C9040 VA: 0x1810C9E40
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x10CCB00 Offset: 0x10CBD00 VA: 0x1810CCB00
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x10CC160 Offset: 0x10CB360 VA: 0x1810CC160
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|
	|-RVA: 0x10CBCB0 Offset: 0x10CAEB0 VA: 0x1810CBCB0
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x10CB7D0 Offset: 0x10CA9D0 VA: 0x1810CB7D0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x10CBCD0 Offset: 0x10CAED0 VA: 0x1810CBCD0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x10CD8F0 Offset: 0x10CCAF0 VA: 0x1810CD8F0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x10D1290 Offset: 0x10D0490 VA: 0x1810D1290
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFDE9F0 Offset: 0xFDDBF0 VA: 0x180FDE9F0
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0xFDF740 Offset: 0xFDE940 VA: 0x180FDF740
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0xFE05B0 Offset: 0xFDF7B0 VA: 0x180FE05B0
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0xFDEF60 Offset: 0xFDE160 VA: 0x180FDEF60
	|-Dictionary<byte, bool>..ctor
	|-Dictionary<byte, byte>..ctor
	|-Dictionary<byte, int>..ctor
	|-Dictionary<byte, object>..ctor
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|
	|-RVA: 0xFF1E80 Offset: 0xFF1080 VA: 0x180FF1E80
	|-Dictionary<ByteEnum, Int32Enum>..ctor
	|-Dictionary<ByteEnum, object>..ctor
	|-Dictionary<ByteEnum, float>..ctor
	|
	|-RVA: 0xFF0610 Offset: 0xFEF810 VA: 0x180FF0610
	|-Dictionary<char, int>..ctor
	|
	|-RVA: 0x10077C0 Offset: 0x10069C0 VA: 0x1810077C0
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x1007390 Offset: 0x1006590 VA: 0x181007390
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x1006370 Offset: 0x1005570 VA: 0x181006370
	|-Dictionary<DiscardReasonWithCategory, int>..ctor
	|
	|-RVA: 0x10067E0 Offset: 0x10059E0 VA: 0x1810067E0
	|-Dictionary<Guid, int>..ctor
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x1008040 Offset: 0x1007240 VA: 0x181008040
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|-Dictionary<int, bool>..ctor
	|-Dictionary<int, char>..ctor
	|-Dictionary<int, DiagnosticEvent>..ctor
	|-Dictionary<int, int>..ctor
	|-Dictionary<int, Int32Enum>..ctor
	|-Dictionary<int, long>..ctor
	|-Dictionary<int, object>..ctor
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|-Dictionary<int, float>..ctor
	|-Dictionary<int, TreeItem>..ctor
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x102ED20 Offset: 0x102DF20 VA: 0x18102ED20
	|-Dictionary<Int32Enum, bool>..ctor
	|-Dictionary<Int32Enum, Color>..ctor
	|-Dictionary<Int32Enum, HatOptions>..ctor
	|-Dictionary<Int32Enum, int>..ctor
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|-Dictionary<Int32Enum, object>..ctor
	|-Dictionary<Int32Enum, SkinOptions>..ctor
	|-Dictionary<Int32Enum, uint>..ctor
	|-Dictionary<Int32Enum, VisorOptions>..ctor
	|
	|-RVA: 0x1041230 Offset: 0x1040430 VA: 0x181041230
	|-Dictionary<long, ComputedStyle>..ctor
	|-Dictionary<long, Int32Enum>..ctor
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x1069820 Offset: 0x1068A20 VA: 0x181069820
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x1068460 Offset: 0x1067660 VA: 0x181068460
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x1067F70 Offset: 0x1067170 VA: 0x181067F70
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|
	|-RVA: 0x1069B00 Offset: 0x1068D00 VA: 0x181069B00
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|-Dictionary<object, bool>..ctor
	|-Dictionary<object, Color32>..ctor
	|-Dictionary<object, int>..ctor
	|-Dictionary<object, Int32Enum>..ctor
	|-Dictionary<object, object>..ctor
	|-Dictionary<object, ResourceLocator>..ctor
	|-Dictionary<object, float>..ctor
	|-Dictionary<object, StylePropertyValue>..ctor
	|-Dictionary<object, TextureId>..ctor
	|-Dictionary<object, TimeSpan>..ctor
	|-Dictionary<object, uint>..ctor
	|-Dictionary<object, ulong>..ctor
	|-Dictionary<object, XPathNodeRef>..ctor
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x109FF20 Offset: 0x109F120 VA: 0x18109FF20
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x109D920 Offset: 0x109CB20 VA: 0x18109D920
	|-Dictionary<UInt16Enum, object>..ctor
	|-Dictionary<UInt16Enum, RoleRate>..ctor
	|-Dictionary<UInt16Enum, uint>..ctor
	|
	|-RVA: 0x109D9E0 Offset: 0x109CBE0 VA: 0x18109D9E0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|-Dictionary<uint, int>..ctor
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary<uint, object>..ctor
	|-Dictionary<uint, VirtualHeap.PinnedBlob>..ctor
	|
	|-RVA: 0x10B3E60 Offset: 0x10B3060 VA: 0x1810B3E60
	|-Dictionary<ulong, Helper.Allocation>..ctor
	|-Dictionary<ulong, Helper.PinnedBuffer>..ctor
	|
	|-RVA: 0x10B26C0 Offset: 0x10B18C0 VA: 0x1810B26C0
	|-Dictionary<Vector2, Int32Enum>..ctor
	|
	|-RVA: 0x10CCAA0 Offset: 0x10CBCA0 VA: 0x1810CCAA0
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x10C9F10 Offset: 0x10C9110 VA: 0x1810C9F10
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x10C9F30 Offset: 0x10C9130 VA: 0x1810C9F30
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|
	|-RVA: 0x10C9F90 Offset: 0x10C9190 VA: 0x1810C9F90
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x10CA800 Offset: 0x10C9A00 VA: 0x1810CA800
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x10D0B90 Offset: 0x10CFD90 VA: 0x1810D0B90
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE03E0 Offset: 0xFDF5E0 VA: 0x180FE03E0
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0xFDEFC0 Offset: 0xFDE1C0 VA: 0x180FDEFC0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0xFDE070 Offset: 0xFDD270 VA: 0x180FDE070
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0xFE0520 Offset: 0xFDF720 VA: 0x180FE0520
	|-Dictionary<byte, bool>..ctor
	|
	|-RVA: 0xFDEED0 Offset: 0xFDE0D0 VA: 0x180FDEED0
	|-Dictionary<byte, byte>..ctor
	|
	|-RVA: 0xFF31C0 Offset: 0xFF23C0 VA: 0x180FF31C0
	|-Dictionary<byte, int>..ctor
	|
	|-RVA: 0xFF3480 Offset: 0xFF2680 VA: 0x180FF3480
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0xFF3970 Offset: 0xFF2B70 VA: 0x180FF3970
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|
	|-RVA: 0xFF3A00 Offset: 0xFF2C00 VA: 0x180FF3A00
	|-Dictionary<ByteEnum, Int32Enum>..ctor
	|
	|-RVA: 0xFF3A90 Offset: 0xFF2C90 VA: 0x180FF3A90
	|-Dictionary<ByteEnum, object>..ctor
	|
	|-RVA: 0xFF2790 Offset: 0xFF1990 VA: 0x180FF2790
	|-Dictionary<ByteEnum, float>..ctor
	|
	|-RVA: 0xFF3BD0 Offset: 0xFF2DD0 VA: 0x180FF3BD0
	|-Dictionary<char, int>..ctor
	|
	|-RVA: 0x1009420 Offset: 0x1008620 VA: 0x181009420
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x1005FF0 Offset: 0x10051F0 VA: 0x181005FF0
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x1005ED0 Offset: 0x10050D0 VA: 0x181005ED0
	|-Dictionary<DiscardReasonWithCategory, int>..ctor
	|
	|-RVA: 0x1005F60 Offset: 0x1005160 VA: 0x181005F60
	|-Dictionary<Guid, int>..ctor
	|
	|-RVA: 0x10097D0 Offset: 0x10089D0 VA: 0x1810097D0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x1007B20 Offset: 0x1006D20 VA: 0x181007B20
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x1009BB0 Offset: 0x1008DB0 VA: 0x181009BB0
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x101B5A0 Offset: 0x101A7A0 VA: 0x18101B5A0
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x101B9F0 Offset: 0x101ABF0 VA: 0x18101B9F0
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x101BA80 Offset: 0x101AC80 VA: 0x18101BA80
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x1018EB0 Offset: 0x10180B0 VA: 0x181018EB0
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x1019D20 Offset: 0x1018F20 VA: 0x181019D20
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x101B3E0 Offset: 0x101A5E0 VA: 0x18101B3E0
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x1018DE0 Offset: 0x1017FE0 VA: 0x181018DE0
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x102EC90 Offset: 0x102DE90 VA: 0x18102EC90
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x102DC50 Offset: 0x102CE50 VA: 0x18102DC50
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x102C670 Offset: 0x102B870 VA: 0x18102C670
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x1030020 Offset: 0x102F220 VA: 0x181030020
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x102DBA0 Offset: 0x102CDA0 VA: 0x18102DBA0
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x102EC00 Offset: 0x102DE00 VA: 0x18102EC00
	|-Dictionary<Int32Enum, Color>..ctor
	|
	|-RVA: 0x102CB80 Offset: 0x102BD80 VA: 0x18102CB80
	|-Dictionary<Int32Enum, HatOptions>..ctor
	|
	|-RVA: 0x103FC30 Offset: 0x103EE30 VA: 0x18103FC30
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x1040210 Offset: 0x103F410 VA: 0x181040210
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x103FB60 Offset: 0x103ED60 VA: 0x18103FB60
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x1040B10 Offset: 0x103FD10 VA: 0x181040B10
	|-Dictionary<Int32Enum, SkinOptions>..ctor
	|
	|-RVA: 0x1040660 Offset: 0x103F860 VA: 0x181040660
	|-Dictionary<Int32Enum, uint>..ctor
	|
	|-RVA: 0x1041290 Offset: 0x1040490 VA: 0x181041290
	|-Dictionary<Int32Enum, VisorOptions>..ctor
	|
	|-RVA: 0x103F0B0 Offset: 0x103E2B0 VA: 0x18103F0B0
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x1069910 Offset: 0x1068B10 VA: 0x181069910
	|-Dictionary<long, Int32Enum>..ctor
	|
	|-RVA: 0x1069770 Offset: 0x1068970 VA: 0x181069770
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x1067FD0 Offset: 0x10671D0 VA: 0x181067FD0
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x106B090 Offset: 0x106A290 VA: 0x18106B090
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x1069F50 Offset: 0x1069150 VA: 0x181069F50
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|
	|-RVA: 0x1069880 Offset: 0x1068A80 VA: 0x181069880
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x1069420 Offset: 0x1068620 VA: 0x181069420
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x107C390 Offset: 0x107B590 VA: 0x18107C390
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x107A0A0 Offset: 0x10792A0 VA: 0x18107A0A0
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x107AF60 Offset: 0x107A160 VA: 0x18107AF60
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x107C730 Offset: 0x107B930 VA: 0x18107C730
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x107D930 Offset: 0x107CB30 VA: 0x18107D930
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x107D860 Offset: 0x107CA60 VA: 0x18107D860
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x107B990 Offset: 0x107AB90 VA: 0x18107B990
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x108B110 Offset: 0x108A310 VA: 0x18108B110
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x108C330 Offset: 0x108B530 VA: 0x18108C330
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x108A6E0 Offset: 0x10898E0 VA: 0x18108A6E0
	|-Dictionary<object, TimeSpan>..ctor
	|
	|-RVA: 0x108B6E0 Offset: 0x108A8E0 VA: 0x18108B6E0
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x108C3C0 Offset: 0x108B5C0 VA: 0x18108C3C0
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x108B1A0 Offset: 0x108A3A0 VA: 0x18108B1A0
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x108A1D0 Offset: 0x10893D0 VA: 0x18108A1D0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x10A0240 Offset: 0x109F440 VA: 0x1810A0240
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x109F560 Offset: 0x109E760 VA: 0x18109F560
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x109DFB0 Offset: 0x109D1B0 VA: 0x18109DFB0
	|-Dictionary<UInt16Enum, object>..ctor
	|
	|-RVA: 0x109F4B0 Offset: 0x109E6B0 VA: 0x18109F4B0
	|-Dictionary<UInt16Enum, RoleRate>..ctor
	|
	|-RVA: 0x109F7B0 Offset: 0x109E9B0 VA: 0x18109F7B0
	|-Dictionary<UInt16Enum, uint>..ctor
	|
	|-RVA: 0x10A09F0 Offset: 0x109FBF0 VA: 0x1810A09F0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x109E520 Offset: 0x109D720 VA: 0x18109E520
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x10B4300 Offset: 0x10B3500 VA: 0x1810B4300
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B4CC0 Offset: 0x10B3EC0 VA: 0x1810B4CC0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B4460 Offset: 0x10B3660 VA: 0x1810B4460
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x10B43D0 Offset: 0x10B35D0 VA: 0x1810B43D0
	|-Dictionary<uint, VirtualHeap.PinnedBlob>..ctor
	|
	|-RVA: 0x10B2630 Offset: 0x10B1830 VA: 0x1810B2630
	|-Dictionary<ulong, Helper.Allocation>..ctor
	|
	|-RVA: 0x10B2240 Offset: 0x10B1440 VA: 0x1810B2240
	|-Dictionary<ulong, Helper.PinnedBuffer>..ctor
	|
	|-RVA: 0x10B5870 Offset: 0x10B4A70 VA: 0x1810B5870
	|-Dictionary<Vector2, Int32Enum>..ctor
	|
	|-RVA: 0x10CD3D0 Offset: 0x10CC5D0 VA: 0x1810CD3D0
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x10CD460 Offset: 0x10CC660 VA: 0x1810CD460
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x10CBC20 Offset: 0x10CAE20 VA: 0x1810CBC20
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|
	|-RVA: 0x10CAC80 Offset: 0x10C9E80 VA: 0x1810CAC80
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x10CCB80 Offset: 0x10CBD80 VA: 0x1810CCB80
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x10CC180 Offset: 0x10CB380 VA: 0x1810CC180
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x10CC980 Offset: 0x10CBB80 VA: 0x1810CC980
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x10D0A50 Offset: 0x10CFC50 VA: 0x1810D0A50
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFDE9D0 Offset: 0xFDDBD0 VA: 0x180FDE9D0
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0xFDEEB0 Offset: 0xFDE0B0 VA: 0x180FDEEB0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0xFE0110 Offset: 0xFDF310 VA: 0x180FE0110
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0xFDF850 Offset: 0xFDEA50 VA: 0x180FDF850
	|-Dictionary<byte, bool>..ctor
	|
	|-RVA: 0xFE0610 Offset: 0xFDF810 VA: 0x180FE0610
	|-Dictionary<byte, byte>..ctor
	|
	|-RVA: 0xFF3930 Offset: 0xFF2B30 VA: 0x180FF3930
	|-Dictionary<byte, int>..ctor
	|
	|-RVA: 0xFF1E60 Offset: 0xFF1060 VA: 0x180FF1E60
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0xFF3950 Offset: 0xFF2B50 VA: 0x180FF3950
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|
	|-RVA: 0xFF2B00 Offset: 0xFF1D00 VA: 0x180FF2B00
	|-Dictionary<ByteEnum, Int32Enum>..ctor
	|
	|-RVA: 0xFF0670 Offset: 0xFEF870 VA: 0x180FF0670
	|-Dictionary<ByteEnum, object>..ctor
	|
	|-RVA: 0xFF2490 Offset: 0xFF1690 VA: 0x180FF2490
	|-Dictionary<ByteEnum, float>..ctor
	|
	|-RVA: 0xFF2B20 Offset: 0xFF1D20 VA: 0x180FF2B20
	|-Dictionary<char, int>..ctor
	|
	|-RVA: 0x1005E70 Offset: 0x1005070 VA: 0x181005E70
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x1006F10 Offset: 0x1006110 VA: 0x181006F10
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x1009970 Offset: 0x1008B70 VA: 0x181009970
	|-Dictionary<DiscardReasonWithCategory, int>..ctor
	|
	|-RVA: 0x1005EB0 Offset: 0x10050B0 VA: 0x181005EB0
	|-Dictionary<Guid, int>..ctor
	|
	|-RVA: 0x1009990 Offset: 0x1008B90 VA: 0x181009990
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x1009950 Offset: 0x1008B50 VA: 0x181009950
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x1007750 Offset: 0x1006950 VA: 0x181007750
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x101BBA0 Offset: 0x101ADA0 VA: 0x18101BBA0
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x101BBC0 Offset: 0x101ADC0 VA: 0x18101BBC0
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x101B540 Offset: 0x101A740 VA: 0x18101B540
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x101B490 Offset: 0x101A690 VA: 0x18101B490
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x101BFA0 Offset: 0x101B1A0 VA: 0x18101BFA0
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x1019EF0 Offset: 0x10190F0 VA: 0x181019EF0
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x1019F10 Offset: 0x1019110 VA: 0x181019F10
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x102DAD0 Offset: 0x102CCD0 VA: 0x18102DAD0
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x102DD70 Offset: 0x102CF70 VA: 0x18102DD70
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x102CB40 Offset: 0x102BD40 VA: 0x18102CB40
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x102D430 Offset: 0x102C630 VA: 0x18102D430
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x1030000 Offset: 0x102F200 VA: 0x181030000
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x102E080 Offset: 0x102D280 VA: 0x18102E080
	|-Dictionary<Int32Enum, Color>..ctor
	|
	|-RVA: 0x102E130 Offset: 0x102D330 VA: 0x18102E130
	|-Dictionary<Int32Enum, HatOptions>..ctor
	|
	|-RVA: 0x103F8A0 Offset: 0x103EAA0 VA: 0x18103F8A0
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x1041B80 Offset: 0x1040D80 VA: 0x181041B80
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x1041720 Offset: 0x1040920 VA: 0x181041720
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x10406F0 Offset: 0x103F8F0 VA: 0x1810406F0
	|-Dictionary<Int32Enum, SkinOptions>..ctor
	|
	|-RVA: 0x1040AF0 Offset: 0x103FCF0 VA: 0x181040AF0
	|-Dictionary<Int32Enum, uint>..ctor
	|
	|-RVA: 0x103F880 Offset: 0x103EA80 VA: 0x18103F880
	|-Dictionary<Int32Enum, VisorOptions>..ctor
	|
	|-RVA: 0x1040F70 Offset: 0x1040170 VA: 0x181040F70
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x106B010 Offset: 0x106A210 VA: 0x18106B010
	|-Dictionary<long, Int32Enum>..ctor
	|
	|-RVA: 0x106AF40 Offset: 0x106A140 VA: 0x18106AF40
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x106A4C0 Offset: 0x10696C0 VA: 0x18106A4C0
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x10688C0 Offset: 0x1067AC0 VA: 0x1810688C0
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x10699A0 Offset: 0x1068BA0 VA: 0x1810699A0
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|
	|-RVA: 0x106AC10 Offset: 0x1069E10 VA: 0x18106AC10
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x106AFF0 Offset: 0x106A1F0 VA: 0x18106AFF0
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x107C7C0 Offset: 0x107B9C0 VA: 0x18107C7C0
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x107D910 Offset: 0x107CB10 VA: 0x18107D910
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x107D540 Offset: 0x107C740 VA: 0x18107D540
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x107A290 Offset: 0x1079490 VA: 0x18107A290
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x107B4A0 Offset: 0x107A6A0 VA: 0x18107B4A0
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x107D8F0 Offset: 0x107CAF0 VA: 0x18107D8F0
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x107C710 Offset: 0x107B910 VA: 0x18107C710
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x108BE70 Offset: 0x108B070 VA: 0x18108BE70
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x108A260 Offset: 0x1089460 VA: 0x18108A260
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x108B6C0 Offset: 0x108A8C0 VA: 0x18108B6C0
	|-Dictionary<object, TimeSpan>..ctor
	|
	|-RVA: 0x108BEB0 Offset: 0x108B0B0 VA: 0x18108BEB0
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x108B2C0 Offset: 0x108A4C0 VA: 0x18108B2C0
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x108BE50 Offset: 0x108B050 VA: 0x18108BE50
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x108A280 Offset: 0x1089480 VA: 0x18108A280
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x109F090 Offset: 0x109E290 VA: 0x18109F090
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x109F680 Offset: 0x109E880 VA: 0x18109F680
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x109F540 Offset: 0x109E740 VA: 0x18109F540
	|-Dictionary<UInt16Enum, object>..ctor
	|
	|-RVA: 0x109D9A0 Offset: 0x109CBA0 VA: 0x18109D9A0
	|-Dictionary<UInt16Enum, RoleRate>..ctor
	|
	|-RVA: 0x109FDE0 Offset: 0x109EFE0 VA: 0x18109FDE0
	|-Dictionary<UInt16Enum, uint>..ctor
	|
	|-RVA: 0x10A09D0 Offset: 0x109FBD0 VA: 0x1810A09D0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x109D980 Offset: 0x109CB80 VA: 0x18109D980
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x10B2840 Offset: 0x10B1A40 VA: 0x1810B2840
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B2170 Offset: 0x10B1370 VA: 0x1810B2170
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B2610 Offset: 0x10B1810 VA: 0x1810B2610
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x10B5960 Offset: 0x10B4B60 VA: 0x1810B5960
	|-Dictionary<uint, VirtualHeap.PinnedBlob>..ctor
	|
	|-RVA: 0x10B2190 Offset: 0x10B1390 VA: 0x1810B2190
	|-Dictionary<ulong, Helper.Allocation>..ctor
	|
	|-RVA: 0x10B5980 Offset: 0x10B4B80 VA: 0x1810B5980
	|-Dictionary<ulong, Helper.PinnedBuffer>..ctor
	|
	|-RVA: 0x10B4390 Offset: 0x10B3590 VA: 0x1810B4390
	|-Dictionary<Vector2, Int32Enum>..ctor
	|
	|-RVA: 0x10CD910 Offset: 0x10CCB10 VA: 0x1810CD910
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x10CA380 Offset: 0x10C9580 VA: 0x1810CA380
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x10CAD10 Offset: 0x10C9F10 VA: 0x1810CAD10
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|
	|-RVA: 0x10CBCF0 Offset: 0x10CAEF0 VA: 0x1810CBCF0
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x10CBB70 Offset: 0x10CAD70 VA: 0x1810CBB70
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x10CAC60 Offset: 0x10C9E60 VA: 0x1810CAC60
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x10CCB40 Offset: 0x10CBD40 VA: 0x1810CCB40
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x10D0AE0 Offset: 0x10CFCE0 VA: 0x1810D0AE0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFDE480 Offset: 0xFDD680 VA: 0x180FDE480
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0xFDEA50 Offset: 0xFDDC50 VA: 0x180FDEA50
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0xFDF050 Offset: 0xFDE250 VA: 0x180FDF050
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0xFDF9A0 Offset: 0xFDEBA0 VA: 0x180FDF9A0
	|-Dictionary<byte, bool>..ctor
	|
	|-RVA: 0xFDD9F0 Offset: 0xFDCBF0 VA: 0x180FDD9F0
	|-Dictionary<byte, byte>..ctor
	|
	|-RVA: 0xFF2B40 Offset: 0xFF1D40 VA: 0x180FF2B40
	|-Dictionary<byte, int>..ctor
	|
	|-RVA: 0xFF0ED0 Offset: 0xFF00D0 VA: 0x180FF0ED0
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0xFF12A0 Offset: 0xFF04A0 VA: 0x180FF12A0
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|
	|-RVA: 0xFF3570 Offset: 0xFF2770 VA: 0x180FF3570
	|-Dictionary<ByteEnum, Int32Enum>..ctor
	|
	|-RVA: 0xFF1A70 Offset: 0xFF0C70 VA: 0x180FF1A70
	|-Dictionary<ByteEnum, object>..ctor
	|
	|-RVA: 0xFF0690 Offset: 0xFEF890 VA: 0x180FF0690
	|-Dictionary<ByteEnum, float>..ctor
	|
	|-RVA: 0xFF16B0 Offset: 0xFF08B0 VA: 0x180FF16B0
	|-Dictionary<char, int>..ctor
	|
	|-RVA: 0x1008C40 Offset: 0x1007E40 VA: 0x181008C40
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x1006B30 Offset: 0x1005D30 VA: 0x181006B30
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x1006F90 Offset: 0x1006190 VA: 0x181006F90
	|-Dictionary<DiscardReasonWithCategory, int>..ctor
	|
	|-RVA: 0x1009040 Offset: 0x1008240 VA: 0x181009040
	|-Dictionary<Guid, int>..ctor
	|
	|-RVA: 0x1007C40 Offset: 0x1006E40 VA: 0x181007C40
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x10084C0 Offset: 0x10076C0 VA: 0x1810084C0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x10063D0 Offset: 0x10055D0 VA: 0x1810063D0
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x101B630 Offset: 0x101A830 VA: 0x18101B630
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x10198B0 Offset: 0x1018AB0 VA: 0x1810198B0
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x101A620 Offset: 0x1019820 VA: 0x18101A620
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x101BBE0 Offset: 0x101ADE0 VA: 0x18101BBE0
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x101A1D0 Offset: 0x10193D0 VA: 0x18101A1D0
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x101C280 Offset: 0x101B480 VA: 0x18101C280
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x101B010 Offset: 0x101A210 VA: 0x18101B010
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x102C740 Offset: 0x102B940 VA: 0x18102C740
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x102F210 Offset: 0x102E410 VA: 0x18102F210
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x102E150 Offset: 0x102D350 VA: 0x18102E150
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x102ED80 Offset: 0x102DF80 VA: 0x18102ED80
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x102CC10 Offset: 0x102BE10 VA: 0x18102CC10
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x102FC00 Offset: 0x102EE00 VA: 0x18102FC00
	|-Dictionary<Int32Enum, Color>..ctor
	|
	|-RVA: 0x102D450 Offset: 0x102C650 VA: 0x18102D450
	|-Dictionary<Int32Enum, HatOptions>..ctor
	|
	|-RVA: 0x1041740 Offset: 0x1040940 VA: 0x181041740
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x1041360 Offset: 0x1040560 VA: 0x181041360
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x1040BA0 Offset: 0x103FDA0 VA: 0x181040BA0
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x103E500 Offset: 0x103D700 VA: 0x18103E500
	|-Dictionary<Int32Enum, SkinOptions>..ctor
	|
	|-RVA: 0x103E970 Offset: 0x103DB70 VA: 0x18103E970
	|-Dictionary<Int32Enum, uint>..ctor
	|
	|-RVA: 0x10402A0 Offset: 0x103F4A0 VA: 0x1810402A0
	|-Dictionary<Int32Enum, VisorOptions>..ctor
	|
	|-RVA: 0x103FCC0 Offset: 0x103EEC0 VA: 0x18103FCC0
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x10684E0 Offset: 0x10676E0 VA: 0x1810684E0
	|-Dictionary<long, Int32Enum>..ctor
	|
	|-RVA: 0x106B3E0 Offset: 0x106A5E0 VA: 0x18106B3E0
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x1068080 Offset: 0x1067280 VA: 0x181068080
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x106A070 Offset: 0x1069270 VA: 0x18106A070
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x106A4E0 Offset: 0x10696E0 VA: 0x18106A4E0
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|
	|-RVA: 0x106B7C0 Offset: 0x106A9C0 VA: 0x18106B7C0
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x1068FC0 Offset: 0x10681C0 VA: 0x181068FC0
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x107BF90 Offset: 0x107B190 VA: 0x18107BF90
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x107BA80 Offset: 0x107AC80 VA: 0x18107BA80
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x107AB80 Offset: 0x1079D80 VA: 0x18107AB80
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x107D160 Offset: 0x107C360 VA: 0x18107D160
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x107B080 Offset: 0x107A280 VA: 0x18107B080
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x107B500 Offset: 0x107A700 VA: 0x18107B500
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x107CAA0 Offset: 0x107BCA0 VA: 0x18107CAA0
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x108A2E0 Offset: 0x10894E0 VA: 0x18108A2E0
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x108BA60 Offset: 0x108AC60 VA: 0x18108BA60
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x108BED0 Offset: 0x108B0D0 VA: 0x18108BED0
	|-Dictionary<object, TimeSpan>..ctor
	|
	|-RVA: 0x108B2E0 Offset: 0x108A4E0 VA: 0x18108B2E0
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x108AA50 Offset: 0x1089C50 VA: 0x18108AA50
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x108D630 Offset: 0x108C830 VA: 0x18108D630
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x108C450 Offset: 0x108B650 VA: 0x18108C450
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x109ECA0 Offset: 0x109DEA0 VA: 0x18109ECA0
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x10A05D0 Offset: 0x109F7D0 VA: 0x1810A05D0
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x10A0A80 Offset: 0x109FC80 VA: 0x1810A0A80
	|-Dictionary<UInt16Enum, object>..ctor
	|
	|-RVA: 0x109F0B0 Offset: 0x109E2B0 VA: 0x18109F0B0
	|-Dictionary<UInt16Enum, RoleRate>..ctor
	|
	|-RVA: 0x109E160 Offset: 0x109D360 VA: 0x18109E160
	|-Dictionary<UInt16Enum, uint>..ctor
	|
	|-RVA: 0x109DA40 Offset: 0x109CC40 VA: 0x18109DA40
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x109E5B0 Offset: 0x109D7B0 VA: 0x18109E5B0
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x10B4890 Offset: 0x10B3A90 VA: 0x1810B4890
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B2F20 Offset: 0x10B2120 VA: 0x1810B2F20
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B4D50 Offset: 0x10B3F50 VA: 0x1810B4D50
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x10B5450 Offset: 0x10B4650 VA: 0x1810B5450
	|-Dictionary<uint, VirtualHeap.PinnedBlob>..ctor
	|
	|-RVA: 0x10B3A40 Offset: 0x10B2C40 VA: 0x1810B3A40
	|-Dictionary<ulong, Helper.Allocation>..ctor
	|
	|-RVA: 0x10B2860 Offset: 0x10B1A60 VA: 0x1810B2860
	|-Dictionary<ulong, Helper.PinnedBuffer>..ctor
	|
	|-RVA: 0x10B3350 Offset: 0x10B2550 VA: 0x1810B3350
	|-Dictionary<Vector2, Int32Enum>..ctor
	|
	|-RVA: 0x10CC210 Offset: 0x10CB410 VA: 0x1810CC210
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x10CB150 Offset: 0x10CA350 VA: 0x1810CB150
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x10CBD10 Offset: 0x10CAF10 VA: 0x1810CBD10
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|
	|-RVA: 0x10CA860 Offset: 0x10C9A60 VA: 0x1810CA860
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x10CCF20 Offset: 0x10CC120 VA: 0x1810CCF20
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x10CD4F0 Offset: 0x10CC6F0 VA: 0x1810CD4F0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x10CAD30 Offset: 0x10C9F30 VA: 0x1810CAD30
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x10D0BF0 Offset: 0x10CFDF0 VA: 0x1810D0BF0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<KeyValuePair<TKey, TValue>> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFDD9D0 Offset: 0xFDCBD0 VA: 0x180FDD9D0
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0xFDF7A0 Offset: 0xFDE9A0 VA: 0x180FDF7A0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0xFDE9B0 Offset: 0xFDDBB0 VA: 0x180FDE9B0
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0xFDF870 Offset: 0xFDEA70 VA: 0x180FDF870
	|-Dictionary<byte, bool>..ctor
	|
	|-RVA: 0xFDEE90 Offset: 0xFDE090 VA: 0x180FDEE90
	|-Dictionary<byte, byte>..ctor
	|
	|-RVA: 0xFF0A80 Offset: 0xFEFC80 VA: 0x180FF0A80
	|-Dictionary<byte, int>..ctor
	|
	|-RVA: 0xFF0E60 Offset: 0xFF0060 VA: 0x180FF0E60
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0xFF3270 Offset: 0xFF2470 VA: 0x180FF3270
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|
	|-RVA: 0xFF2AE0 Offset: 0xFF1CE0 VA: 0x180FF2AE0
	|-Dictionary<ByteEnum, Int32Enum>..ctor
	|
	|-RVA: 0xFF0A60 Offset: 0xFEFC60 VA: 0x180FF0A60
	|-Dictionary<ByteEnum, object>..ctor
	|
	|-RVA: 0xFF1EE0 Offset: 0xFF10E0 VA: 0x180FF1EE0
	|-Dictionary<ByteEnum, float>..ctor
	|
	|-RVA: 0xFF1E40 Offset: 0xFF1040 VA: 0x180FF1E40
	|-Dictionary<char, int>..ctor
	|
	|-RVA: 0x1007B00 Offset: 0x1006D00 VA: 0x181007B00
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x1009910 Offset: 0x1008B10 VA: 0x181009910
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x1006F70 Offset: 0x1006170 VA: 0x181006F70
	|-Dictionary<DiscardReasonWithCategory, int>..ctor
	|
	|-RVA: 0x1009930 Offset: 0x1008B30 VA: 0x181009930
	|-Dictionary<Guid, int>..ctor
	|
	|-RVA: 0x1008950 Offset: 0x1007B50 VA: 0x181008950
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x1006F30 Offset: 0x1006130 VA: 0x181006F30
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x1007AE0 Offset: 0x1006CE0 VA: 0x181007AE0
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x1018E70 Offset: 0x1018070 VA: 0x181018E70
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x1019540 Offset: 0x1018740 VA: 0x181019540
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x101AA70 Offset: 0x1019C70 VA: 0x18101AA70
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x101C260 Offset: 0x101B460 VA: 0x18101C260
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x101B470 Offset: 0x101A670 VA: 0x18101B470
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x101C650 Offset: 0x101B850 VA: 0x18101C650
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x10191E0 Offset: 0x10183E0 VA: 0x1810191E0
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x102F1B0 Offset: 0x102E3B0 VA: 0x18102F1B0
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x102D380 Offset: 0x102C580 VA: 0x18102D380
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x10300D0 Offset: 0x102F2D0 VA: 0x1810300D0
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x102F1D0 Offset: 0x102E3D0 VA: 0x18102F1D0
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x102DB80 Offset: 0x102CD80 VA: 0x18102DB80
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x102C700 Offset: 0x102B900 VA: 0x18102C700
	|-Dictionary<Int32Enum, Color>..ctor
	|
	|-RVA: 0x102F5E0 Offset: 0x102E7E0 VA: 0x18102F5E0
	|-Dictionary<Int32Enum, HatOptions>..ctor
	|
	|-RVA: 0x1041B40 Offset: 0x1040D40 VA: 0x181041B40
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x1041B20 Offset: 0x1040D20 VA: 0x181041B20
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x103FC10 Offset: 0x103EE10 VA: 0x18103FC10
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x103F160 Offset: 0x103E360 VA: 0x18103F160
	|-Dictionary<Int32Enum, SkinOptions>..ctor
	|
	|-RVA: 0x1041320 Offset: 0x1040520 VA: 0x181041320
	|-Dictionary<Int32Enum, uint>..ctor
	|
	|-RVA: 0x103F4F0 Offset: 0x103E6F0 VA: 0x18103F4F0
	|-Dictionary<Int32Enum, VisorOptions>..ctor
	|
	|-RVA: 0x103FBF0 Offset: 0x103EDF0 VA: 0x18103FBF0
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x1068060 Offset: 0x1067260 VA: 0x181068060
	|-Dictionary<long, Int32Enum>..ctor
	|
	|-RVA: 0x10684C0 Offset: 0x10676C0 VA: 0x1810684C0
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x10693E0 Offset: 0x10685E0 VA: 0x1810693E0
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x1068CE0 Offset: 0x1067EE0 VA: 0x181068CE0
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x1069400 Offset: 0x1068600 VA: 0x181069400
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|
	|-RVA: 0x10699C0 Offset: 0x1068BC0 VA: 0x1810699C0
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x106B070 Offset: 0x106A270 VA: 0x18106B070
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x107D820 Offset: 0x107CA20 VA: 0x18107D820
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x107BA60 Offset: 0x107AC60 VA: 0x18107BA60
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x107B4C0 Offset: 0x107A6C0 VA: 0x18107B4C0
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x107B460 Offset: 0x107A660 VA: 0x18107B460
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x107BA40 Offset: 0x107AC40 VA: 0x18107BA40
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x107BA20 Offset: 0x107AC20 VA: 0x18107BA20
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x107B480 Offset: 0x107A680 VA: 0x18107B480
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x108D580 Offset: 0x108C780 VA: 0x18108D580
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x108A190 Offset: 0x1089390 VA: 0x18108A190
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x108BE30 Offset: 0x108B030 VA: 0x18108BE30
	|-Dictionary<object, TimeSpan>..ctor
	|
	|-RVA: 0x108A770 Offset: 0x1089970 VA: 0x18108A770
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x108DA30 Offset: 0x108CC30 VA: 0x18108DA30
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x108AE30 Offset: 0x108A030 VA: 0x18108AE30
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x108C8B0 Offset: 0x108BAB0 VA: 0x18108C8B0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x109F770 Offset: 0x109E970 VA: 0x18109F770
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x109F070 Offset: 0x109E270 VA: 0x18109F070
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x10A09B0 Offset: 0x109FBB0 VA: 0x1810A09B0
	|-Dictionary<UInt16Enum, object>..ctor
	|
	|-RVA: 0x10A05B0 Offset: 0x109F7B0 VA: 0x1810A05B0
	|-Dictionary<UInt16Enum, RoleRate>..ctor
	|
	|-RVA: 0x10A02D0 Offset: 0x109F4D0 VA: 0x1810A02D0
	|-Dictionary<UInt16Enum, uint>..ctor
	|
	|-RVA: 0x109D9C0 Offset: 0x109CBC0 VA: 0x18109D9C0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x109F730 Offset: 0x109E930 VA: 0x18109F730
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x10B43B0 Offset: 0x10B35B0 VA: 0x1810B43B0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B59A0 Offset: 0x10B4BA0 VA: 0x1810B59A0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B3FB0 Offset: 0x10B31B0 VA: 0x1810B3FB0
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x10B3FD0 Offset: 0x10B31D0 VA: 0x1810B3FD0
	|-Dictionary<uint, VirtualHeap.PinnedBlob>..ctor
	|
	|-RVA: 0x10B5920 Offset: 0x10B4B20 VA: 0x1810B5920
	|-Dictionary<ulong, Helper.Allocation>..ctor
	|
	|-RVA: 0x10B5900 Offset: 0x10B4B00 VA: 0x1810B5900
	|-Dictionary<ulong, Helper.PinnedBuffer>..ctor
	|
	|-RVA: 0x10B5850 Offset: 0x10B4A50 VA: 0x1810B5850
	|-Dictionary<Vector2, Int32Enum>..ctor
	|
	|-RVA: 0x10CCB20 Offset: 0x10CBD20 VA: 0x1810CCB20
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x10CD3B0 Offset: 0x10CC5B0 VA: 0x1810CD3B0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x10CD980 Offset: 0x10CCB80 VA: 0x1810CD980
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|
	|-RVA: 0x10CB130 Offset: 0x10CA330 VA: 0x1810CB130
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x10CBC00 Offset: 0x10CAE00 VA: 0x1810CBC00
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x10CCB60 Offset: 0x10CBD60 VA: 0x1810CCB60
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x10C9EF0 Offset: 0x10C90F0 VA: 0x1810C9EF0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x10D12B0 Offset: 0x10D04B0 VA: 0x1810D12B0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFDF450 Offset: 0xFDE650 VA: 0x180FDF450
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0xFDFD70 Offset: 0xFDEF70 VA: 0x180FDFD70
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0xFDE190 Offset: 0xFDD390 VA: 0x180FDE190
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0xFDDDC0 Offset: 0xFDCFC0 VA: 0x180FDDDC0
	|-Dictionary<byte, bool>..ctor
	|
	|-RVA: 0xFE0130 Offset: 0xFDF330 VA: 0x180FE0130
	|-Dictionary<byte, byte>..ctor
	|
	|-RVA: 0xFF1F50 Offset: 0xFF1150 VA: 0x180FF1F50
	|-Dictionary<byte, int>..ctor
	|
	|-RVA: 0xFF2F00 Offset: 0xFF2100 VA: 0x180FF2F00
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0xFF24B0 Offset: 0xFF16B0 VA: 0x180FF24B0
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|
	|-RVA: 0xFF21F0 Offset: 0xFF13F0 VA: 0x180FF21F0
	|-Dictionary<ByteEnum, Int32Enum>..ctor
	|
	|-RVA: 0xFF2820 Offset: 0xFF1A20 VA: 0x180FF2820
	|-Dictionary<ByteEnum, object>..ctor
	|
	|-RVA: 0xFF3CF0 Offset: 0xFF2EF0 VA: 0x180FF3CF0
	|-Dictionary<ByteEnum, float>..ctor
	|
	|-RVA: 0xFF0BC0 Offset: 0xFEFDC0 VA: 0x180FF0BC0
	|-Dictionary<char, int>..ctor
	|
	|-RVA: 0x1007440 Offset: 0x1006640 VA: 0x181007440
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x1007820 Offset: 0x1006A20 VA: 0x181007820
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x1006080 Offset: 0x1005280 VA: 0x181006080
	|-Dictionary<DiscardReasonWithCategory, int>..ctor
	|
	|-RVA: 0x1008970 Offset: 0x1007B70 VA: 0x181008970
	|-Dictionary<Guid, int>..ctor
	|
	|-RVA: 0x1006840 Offset: 0x1005A40 VA: 0x181006840
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x1009500 Offset: 0x1008700 VA: 0x181009500
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x10080A0 Offset: 0x10072A0 VA: 0x1810080A0
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x1019F30 Offset: 0x1019130 VA: 0x181019F30
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x1018F40 Offset: 0x1018140 VA: 0x181018F40
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x1019220 Offset: 0x1018420 VA: 0x181019220
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x10195F0 Offset: 0x10187F0 VA: 0x1810195F0
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x101BFC0 Offset: 0x101B1C0 VA: 0x18101BFC0
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x101AA90 Offset: 0x1019C90 VA: 0x18101AA90
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x101AD50 Offset: 0x1019F50 VA: 0x18101AD50
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x102E910 Offset: 0x102DB10 VA: 0x18102E910
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x102CFD0 Offset: 0x102C1D0 VA: 0x18102CFD0
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x102F910 Offset: 0x102EB10 VA: 0x18102F910
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x102F600 Offset: 0x102E800 VA: 0x18102F600
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x102E550 Offset: 0x102D750 VA: 0x18102E550
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x102DD90 Offset: 0x102CF90 VA: 0x18102DD90
	|-Dictionary<Int32Enum, Color>..ctor
	|
	|-RVA: 0x102D830 Offset: 0x102CA30 VA: 0x18102D830
	|-Dictionary<Int32Enum, HatOptions>..ctor
	|
	|-RVA: 0x103F8C0 Offset: 0x103EAC0 VA: 0x18103F8C0
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x103ED80 Offset: 0x103DF80 VA: 0x18103ED80
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x103F180 Offset: 0x103E380 VA: 0x18103F180
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x10407A0 Offset: 0x103F9A0 VA: 0x1810407A0
	|-Dictionary<Int32Enum, SkinOptions>..ctor
	|
	|-RVA: 0x103E260 Offset: 0x103D460 VA: 0x18103E260
	|-Dictionary<Int32Enum, uint>..ctor
	|
	|-RVA: 0x1040F90 Offset: 0x1040190 VA: 0x181040F90
	|-Dictionary<Int32Enum, VisorOptions>..ctor
	|
	|-RVA: 0x103F510 Offset: 0x103E710 VA: 0x18103F510
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x1068D00 Offset: 0x1067F00 VA: 0x181068D00
	|-Dictionary<long, Int32Enum>..ctor
	|
	|-RVA: 0x106B120 Offset: 0x106A320 VA: 0x18106B120
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x10694B0 Offset: 0x10686B0 VA: 0x1810694B0
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x1069B60 Offset: 0x1068D60 VA: 0x181069B60
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x106AC80 Offset: 0x1069E80 VA: 0x18106AC80
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|
	|-RVA: 0x106A8B0 Offset: 0x1069AB0 VA: 0x18106A8B0
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x1068990 Offset: 0x1067B90 VA: 0x181068990
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x107CE80 Offset: 0x107C080 VA: 0x18107CE80
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x107C7E0 Offset: 0x107B9E0 VA: 0x18107C7E0
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x107A830 Offset: 0x1079A30 VA: 0x18107A830
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x107A2B0 Offset: 0x10794B0 VA: 0x18107A2B0
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x107A570 Offset: 0x1079770 VA: 0x18107A570
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x107C420 Offset: 0x107B620 VA: 0x18107C420
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x107D560 Offset: 0x107C760 VA: 0x18107D560
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x108CC20 Offset: 0x108BE20 VA: 0x18108CC20
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x108AE50 Offset: 0x108A050 VA: 0x18108AE50
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x108C960 Offset: 0x108BB60 VA: 0x18108C960
	|-Dictionary<object, TimeSpan>..ctor
	|
	|-RVA: 0x108A790 Offset: 0x1089990 VA: 0x18108A790
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x108D1D0 Offset: 0x108C3D0 VA: 0x18108D1D0
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x108B770 Offset: 0x108A970 VA: 0x18108B770
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x108CF10 Offset: 0x108C110 VA: 0x18108CF10
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x109FF80 Offset: 0x109F180 VA: 0x18109FF80
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x109FB20 Offset: 0x109ED20 VA: 0x18109FB20
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x10A02F0 Offset: 0x109F4F0 VA: 0x1810A02F0
	|-Dictionary<UInt16Enum, object>..ctor
	|
	|-RVA: 0x109F840 Offset: 0x109EA40 VA: 0x18109F840
	|-Dictionary<UInt16Enum, RoleRate>..ctor
	|
	|-RVA: 0x109E9B0 Offset: 0x109DBB0 VA: 0x18109E9B0
	|-Dictionary<UInt16Enum, uint>..ctor
	|
	|-RVA: 0x10A0E50 Offset: 0x10A0050 VA: 0x1810A0E50
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x10A1170 Offset: 0x10A0370 VA: 0x1810A1170
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x10B44F0 Offset: 0x10B36F0 VA: 0x1810B44F0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B3FF0 Offset: 0x10B31F0 VA: 0x1810B3FF0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B2C60 Offset: 0x10B1E60 VA: 0x1810B2C60
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x10B22D0 Offset: 0x10B14D0 VA: 0x1810B22D0
	|-Dictionary<uint, VirtualHeap.PinnedBlob>..ctor
	|
	|-RVA: 0x10B1DC0 Offset: 0x10B0FC0 VA: 0x1810B1DC0
	|-Dictionary<ulong, Helper.Allocation>..ctor
	|
	|-RVA: 0x10B3750 Offset: 0x10B2950 VA: 0x1810B3750
	|-Dictionary<ulong, Helper.PinnedBuffer>..ctor
	|
	|-RVA: 0x10B5120 Offset: 0x10B4320 VA: 0x1810B5120
	|-Dictionary<Vector2, Int32Enum>..ctor
	|
	|-RVA: 0x10CC6A0 Offset: 0x10CB8A0 VA: 0x1810CC6A0
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x10CA3A0 Offset: 0x10C95A0 VA: 0x1810CA3A0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x10CCC10 Offset: 0x10CBE10 VA: 0x1810CCC10
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|
	|-RVA: 0x10C9AE0 Offset: 0x10C8CE0 VA: 0x1810C9AE0
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x10CB880 Offset: 0x10CAA80 VA: 0x1810CB880
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x10CD9A0 Offset: 0x10CCBA0 VA: 0x1810CD9A0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x10CA040 Offset: 0x10C9240 VA: 0x1810CA040
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x10D0FD0 Offset: 0x10D01D0 VA: 0x1810D0FD0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE0490 Offset: 0xFDF690 VA: 0x180FE0490
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0xFDF7C0 Offset: 0xFDE9C0 VA: 0x180FDF7C0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0xFDE100 Offset: 0xFDD300 VA: 0x180FDE100
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0xFDF8F0 Offset: 0xFDEAF0 VA: 0x180FDF8F0
	|-Dictionary<byte, bool>..ctor
	|
	|-RVA: 0xFDE920 Offset: 0xFDDB20 VA: 0x180FDE920
	|-Dictionary<byte, byte>..ctor
	|
	|-RVA: 0xFF3360 Offset: 0xFF2560 VA: 0x180FF3360
	|-Dictionary<byte, int>..ctor
	|
	|-RVA: 0xFF3C60 Offset: 0xFF2E60 VA: 0x180FF3C60
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0xFF0B30 Offset: 0xFEFD30 VA: 0x180FF0B30
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>..ctor
	|
	|-RVA: 0xFF33F0 Offset: 0xFF25F0 VA: 0x180FF33F0
	|-Dictionary<ByteEnum, Int32Enum>..ctor
	|
	|-RVA: 0xFF0AA0 Offset: 0xFEFCA0 VA: 0x180FF0AA0
	|-Dictionary<ByteEnum, object>..ctor
	|
	|-RVA: 0xFF3290 Offset: 0xFF2490 VA: 0x180FF3290
	|-Dictionary<ByteEnum, float>..ctor
	|
	|-RVA: 0xFF3B20 Offset: 0xFF2D20 VA: 0x180FF3B20
	|-Dictionary<char, int>..ctor
	|
	|-RVA: 0x1009A40 Offset: 0x1008C40 VA: 0x181009A40
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x10088C0 Offset: 0x1007AC0 VA: 0x1810088C0
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x1008430 Offset: 0x1007630 VA: 0x181008430
	|-Dictionary<DiscardReasonWithCategory, int>..ctor
	|
	|-RVA: 0x1009B20 Offset: 0x1008D20 VA: 0x181009B20
	|-Dictionary<Guid, int>..ctor
	|
	|-RVA: 0x1009880 Offset: 0x1008A80 VA: 0x181009880
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x10083A0 Offset: 0x10075A0 VA: 0x1810083A0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x1007BB0 Offset: 0x1006DB0 VA: 0x181007BB0
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x1019560 Offset: 0x1018760 VA: 0x181019560
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x101B4B0 Offset: 0x101A6B0 VA: 0x18101B4B0
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x1019DD0 Offset: 0x1018FD0 VA: 0x181019DD0
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x101BB10 Offset: 0x101AD10 VA: 0x18101BB10
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x101A590 Offset: 0x1019790 VA: 0x18101A590
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x1019C90 Offset: 0x1018E90 VA: 0x181019C90
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x1019E60 Offset: 0x1019060 VA: 0x181019E60
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x102DCE0 Offset: 0x102CEE0 VA: 0x18102DCE0
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x102D3A0 Offset: 0x102C5A0 VA: 0x18102D3A0
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x102DAF0 Offset: 0x102CCF0 VA: 0x18102DAF0
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x102E0A0 Offset: 0x102D2A0 VA: 0x18102E0A0
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x102E880 Offset: 0x102DA80 VA: 0x18102E880
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x102E7F0 Offset: 0x102D9F0 VA: 0x18102E7F0
	|-Dictionary<Int32Enum, Color>..ctor
	|
	|-RVA: 0x102D2F0 Offset: 0x102C4F0 VA: 0x18102D2F0
	|-Dictionary<Int32Enum, HatOptions>..ctor
	|
	|-RVA: 0x1040180 Offset: 0x103F380 VA: 0x181040180
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x1040710 Offset: 0x103F910 VA: 0x181040710
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x1040A60 Offset: 0x103FC60 VA: 0x181040A60
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x103F020 Offset: 0x103E220 VA: 0x18103F020
	|-Dictionary<Int32Enum, SkinOptions>..ctor
	|
	|-RVA: 0x103E8C0 Offset: 0x103DAC0 VA: 0x18103E8C0
	|-Dictionary<Int32Enum, uint>..ctor
	|
	|-RVA: 0x103F440 Offset: 0x103E640 VA: 0x18103F440
	|-Dictionary<Int32Enum, VisorOptions>..ctor
	|
	|-RVA: 0x1041BA0 Offset: 0x1040DA0 VA: 0x181041BA0
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x106BBF0 Offset: 0x106ADF0 VA: 0x18106BBF0
	|-Dictionary<long, Int32Enum>..ctor
	|
	|-RVA: 0x10699E0 Offset: 0x1068BE0 VA: 0x1810699E0
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x106AF60 Offset: 0x106A160 VA: 0x18106AF60
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x1069E50 Offset: 0x1069050 VA: 0x181069E50
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x1068900 Offset: 0x1067B00 VA: 0x181068900
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>..ctor
	|
	|-RVA: 0x1069A70 Offset: 0x1068C70 VA: 0x181069A70
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x1069FE0 Offset: 0x10691E0 VA: 0x181069FE0
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x107AFF0 Offset: 0x107A1F0 VA: 0x18107AFF0
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x107A130 Offset: 0x1079330 VA: 0x18107A130
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x107AAF0 Offset: 0x1079CF0 VA: 0x18107AAF0
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x107BE50 Offset: 0x107B050 VA: 0x18107BE50
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x107A1E0 Offset: 0x10793E0 VA: 0x18107A1E0
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x107B900 Offset: 0x107AB00 VA: 0x18107B900
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x107BEE0 Offset: 0x107B0E0 VA: 0x18107BEE0
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x108A100 Offset: 0x1089300 VA: 0x18108A100
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x108C820 Offset: 0x108BA20 VA: 0x18108C820
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x108C8D0 Offset: 0x108BAD0 VA: 0x18108C8D0
	|-Dictionary<object, TimeSpan>..ctor
	|
	|-RVA: 0x108C2A0 Offset: 0x108B4A0 VA: 0x18108C2A0
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x108D5A0 Offset: 0x108C7A0 VA: 0x18108D5A0
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x108D4F0 Offset: 0x108C6F0 VA: 0x18108D4F0
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x108B230 Offset: 0x108A430 VA: 0x18108B230
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x109E040 Offset: 0x109D240 VA: 0x18109E040
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x109FE70 Offset: 0x109F070 VA: 0x18109FE70
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x109DE90 Offset: 0x109D090 VA: 0x18109DE90
	|-Dictionary<UInt16Enum, object>..ctor
	|
	|-RVA: 0x109F6A0 Offset: 0x109E8A0 VA: 0x18109F6A0
	|-Dictionary<UInt16Enum, RoleRate>..ctor
	|
	|-RVA: 0x109E0D0 Offset: 0x109D2D0 VA: 0x18109E0D0
	|-Dictionary<UInt16Enum, uint>..ctor
	|
	|-RVA: 0x109DF20 Offset: 0x109D120 VA: 0x18109DF20
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x109F5F0 Offset: 0x109E7F0 VA: 0x18109F5F0
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x10B21B0 Offset: 0x10B13B0 VA: 0x1810B21B0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B3EE0 Offset: 0x10B30E0 VA: 0x1810B3EE0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x10B20E0 Offset: 0x10B12E0 VA: 0x1810B20E0
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x10B4800 Offset: 0x10B3A00 VA: 0x1810B4800
	|-Dictionary<uint, VirtualHeap.PinnedBlob>..ctor
	|
	|-RVA: 0x10B2720 Offset: 0x10B1920 VA: 0x1810B2720
	|-Dictionary<ulong, Helper.Allocation>..ctor
	|
	|-RVA: 0x10B27B0 Offset: 0x10B19B0 VA: 0x1810B27B0
	|-Dictionary<ulong, Helper.PinnedBuffer>..ctor
	|
	|-RVA: 0x10B1D30 Offset: 0x10B0F30 VA: 0x1810B1D30
	|-Dictionary<Vector2, Int32Enum>..ctor
	|
	|-RVA: 0x10C9A50 Offset: 0x10C8C50 VA: 0x1810C9A50
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x10CCA10 Offset: 0x10CBC10 VA: 0x1810CCA10
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x10CC610 Offset: 0x10CB810 VA: 0x1810CC610
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>..ctor
	|
	|-RVA: 0x10C9DB0 Offset: 0x10C8FB0 VA: 0x1810C9DB0
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x10CD320 Offset: 0x10CC520 VA: 0x1810CD320
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x10C9E60 Offset: 0x10C9060 VA: 0x1810C9E60
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x10CB7F0 Offset: 0x10CA9F0 VA: 0x1810CB7F0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x10D0B00 Offset: 0x10CFD00 VA: 0x1810D0B00
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<TKey> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE0670 Offset: 0xFDF870 VA: 0x180FE0670
	|-Dictionary<KeyValuePair<object, object>, object>.get_Comparer
	|
	|-RVA: 0xFE0690 Offset: 0xFDF890 VA: 0x180FE0690
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.get_Comparer
	|
	|-RVA: 0xFE0650 Offset: 0xFDF850 VA: 0x180FE0650
	|-Dictionary<ValueTuple<object, object>, object>.get_Comparer
	|
	|-RVA: 0xFE0630 Offset: 0xFDF830 VA: 0x180FE0630
	|-Dictionary<byte, bool>.get_Comparer
	|-Dictionary<byte, byte>.get_Comparer
	|-Dictionary<byte, int>.get_Comparer
	|-Dictionary<byte, object>.get_Comparer
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.get_Comparer
	|
	|-RVA: 0xFF3FA0 Offset: 0xFF31A0 VA: 0x180FF3FA0
	|-Dictionary<ByteEnum, Int32Enum>.get_Comparer
	|-Dictionary<ByteEnum, object>.get_Comparer
	|-Dictionary<ByteEnum, float>.get_Comparer
	|
	|-RVA: 0xFF3FC0 Offset: 0xFF31C0 VA: 0x180FF3FC0
	|-Dictionary<char, int>.get_Comparer
	|
	|-RVA: 0x1009CA0 Offset: 0x1008EA0 VA: 0x181009CA0
	|-Dictionary<Color, object>.get_Comparer
	|
	|-RVA: 0x1009CC0 Offset: 0x1008EC0 VA: 0x181009CC0
	|-Dictionary<DateTime, object>.get_Comparer
	|
	|-RVA: 0x1009C60 Offset: 0x1008E60 VA: 0x181009C60
	|-Dictionary<DiscardReasonWithCategory, int>.get_Comparer
	|
	|-RVA: 0x1009C80 Offset: 0x1008E80 VA: 0x181009C80
	|-Dictionary<Guid, int>.get_Comparer
	|-Dictionary<Guid, object>.get_Comparer
	|
	|-RVA: 0x1009C40 Offset: 0x1008E40 VA: 0x181009C40
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Comparer
	|-Dictionary<int, TreeViewItemData<object>>.get_Comparer
	|-Dictionary<int, bool>.get_Comparer
	|-Dictionary<int, char>.get_Comparer
	|-Dictionary<int, DiagnosticEvent>.get_Comparer
	|-Dictionary<int, int>.get_Comparer
	|-Dictionary<int, Int32Enum>.get_Comparer
	|-Dictionary<int, long>.get_Comparer
	|-Dictionary<int, object>.get_Comparer
	|-Dictionary<int, RenderInstancedDataLayout>.get_Comparer
	|-Dictionary<int, float>.get_Comparer
	|-Dictionary<int, TreeItem>.get_Comparer
	|-Dictionary<int, TextResourceManager.FontAssetRef>.get_Comparer
	|
	|-RVA: 0x10300F0 Offset: 0x102F2F0 VA: 0x1810300F0
	|-Dictionary<Int32Enum, bool>.get_Comparer
	|-Dictionary<Int32Enum, Color>.get_Comparer
	|-Dictionary<Int32Enum, HatOptions>.get_Comparer
	|-Dictionary<Int32Enum, int>.get_Comparer
	|-Dictionary<Int32Enum, Int32Enum>.get_Comparer
	|-Dictionary<Int32Enum, object>.get_Comparer
	|-Dictionary<Int32Enum, SkinOptions>.get_Comparer
	|-Dictionary<Int32Enum, uint>.get_Comparer
	|-Dictionary<Int32Enum, VisorOptions>.get_Comparer
	|
	|-RVA: 0x1041C30 Offset: 0x1040E30 VA: 0x181041C30
	|-Dictionary<long, ComputedStyle>.get_Comparer
	|-Dictionary<long, Int32Enum>.get_Comparer
	|-Dictionary<long, object>.get_Comparer
	|
	|-RVA: 0x106BCA0 Offset: 0x106AEA0 VA: 0x18106BCA0
	|-Dictionary<IntPtr, object>.get_Comparer
	|
	|-RVA: 0x106BC80 Offset: 0x106AE80 VA: 0x18106BC80
	|-Dictionary<IntVec3, object>.get_Comparer
	|
	|-RVA: 0x106BCC0 Offset: 0x106AEC0 VA: 0x18106BCC0
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.get_Comparer
	|
	|-RVA: 0x106BCE0 Offset: 0x106AEE0 VA: 0x18106BCE0
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Comparer
	|-Dictionary<object, AsyncOperationHandle>.get_Comparer
	|-Dictionary<object, bool>.get_Comparer
	|-Dictionary<object, Color32>.get_Comparer
	|-Dictionary<object, int>.get_Comparer
	|-Dictionary<object, Int32Enum>.get_Comparer
	|-Dictionary<object, object>.get_Comparer
	|-Dictionary<object, ResourceLocator>.get_Comparer
	|-Dictionary<object, float>.get_Comparer
	|-Dictionary<object, StylePropertyValue>.get_Comparer
	|-Dictionary<object, TextureId>.get_Comparer
	|-Dictionary<object, TimeSpan>.get_Comparer
	|-Dictionary<object, uint>.get_Comparer
	|-Dictionary<object, ulong>.get_Comparer
	|-Dictionary<object, XPathNodeRef>.get_Comparer
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Comparer
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.get_Comparer
	|
	|-RVA: 0x10A1450 Offset: 0x10A0650 VA: 0x1810A1450
	|-Dictionary<TerrainTileCoord, object>.get_Comparer
	|
	|-RVA: 0x10A1430 Offset: 0x10A0630 VA: 0x1810A1430
	|-Dictionary<UInt16Enum, object>.get_Comparer
	|-Dictionary<UInt16Enum, RoleRate>.get_Comparer
	|-Dictionary<UInt16Enum, uint>.get_Comparer
	|
	|-RVA: 0x10A1410 Offset: 0x10A0610 VA: 0x1810A1410
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.get_Comparer
	|-Dictionary<uint, int>.get_Comparer
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Comparer
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Comparer
	|-Dictionary<uint, object>.get_Comparer
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.get_Comparer
	|
	|-RVA: 0x10B59C0 Offset: 0x10B4BC0 VA: 0x1810B59C0
	|-Dictionary<ulong, Helper.Allocation>.get_Comparer
	|-Dictionary<ulong, Helper.PinnedBuffer>.get_Comparer
	|
	|-RVA: 0x10B59E0 Offset: 0x10B4BE0 VA: 0x1810B59E0
	|-Dictionary<Vector2, Int32Enum>.get_Comparer
	|
	|-RVA: 0x10CDCE0 Offset: 0x10CCEE0 VA: 0x1810CDCE0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Comparer
	|
	|-RVA: 0x10CDC90 Offset: 0x10CCE90 VA: 0x1810CDC90
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Comparer
	|
	|-RVA: 0x10CDD00 Offset: 0x10CCF00 VA: 0x1810CDD00
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.get_Comparer
	|
	|-RVA: 0x10CDD20 Offset: 0x10CCF20 VA: 0x1810CDD20
	|-Dictionary<Regex.CachedCodeEntryKey, object>.get_Comparer
	|
	|-RVA: 0x10CDCC0 Offset: 0x10CCEC0 VA: 0x1810CDCC0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Comparer
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Comparer
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Comparer
	|
	|-RVA: 0x10D1320 Offset: 0x10D0520 VA: 0x1810D1320
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Comparer
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE06B0 Offset: 0xFDF8B0 VA: 0x180FE06B0
	|-Dictionary<KeyValuePair<object, object>, object>.get_Count
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.get_Count
	|-Dictionary<ValueTuple<object, object>, object>.get_Count
	|-Dictionary<byte, bool>.get_Count
	|-Dictionary<byte, byte>.get_Count
	|-Dictionary<byte, int>.get_Count
	|-Dictionary<byte, object>.get_Count
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.get_Count
	|-Dictionary<ByteEnum, Int32Enum>.get_Count
	|-Dictionary<ByteEnum, object>.get_Count
	|-Dictionary<ByteEnum, float>.get_Count
	|-Dictionary<char, int>.get_Count
	|-Dictionary<Color, object>.get_Count
	|-Dictionary<DateTime, object>.get_Count
	|-Dictionary<DiscardReasonWithCategory, int>.get_Count
	|-Dictionary<Guid, int>.get_Count
	|-Dictionary<Guid, object>.get_Count
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Count
	|-Dictionary<int, TreeViewItemData<object>>.get_Count
	|-Dictionary<int, bool>.get_Count
	|-Dictionary<int, char>.get_Count
	|-Dictionary<int, DiagnosticEvent>.get_Count
	|-Dictionary<int, int>.get_Count
	|-Dictionary<int, Int32Enum>.get_Count
	|-Dictionary<int, long>.get_Count
	|-Dictionary<int, object>.get_Count
	|-Dictionary<int, RenderInstancedDataLayout>.get_Count
	|-Dictionary<int, float>.get_Count
	|-Dictionary<int, TreeItem>.get_Count
	|-Dictionary<int, TextResourceManager.FontAssetRef>.get_Count
	|-Dictionary<Int32Enum, bool>.get_Count
	|-Dictionary<Int32Enum, Color>.get_Count
	|-Dictionary<Int32Enum, HatOptions>.get_Count
	|-Dictionary<Int32Enum, int>.get_Count
	|-Dictionary<Int32Enum, Int32Enum>.get_Count
	|-Dictionary<Int32Enum, object>.get_Count
	|-Dictionary<Int32Enum, SkinOptions>.get_Count
	|-Dictionary<Int32Enum, uint>.get_Count
	|-Dictionary<Int32Enum, VisorOptions>.get_Count
	|-Dictionary<long, ComputedStyle>.get_Count
	|-Dictionary<long, Int32Enum>.get_Count
	|-Dictionary<long, object>.get_Count
	|-Dictionary<IntPtr, object>.get_Count
	|-Dictionary<IntVec3, object>.get_Count
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.get_Count
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Count
	|-Dictionary<object, AsyncOperationHandle>.get_Count
	|-Dictionary<object, bool>.get_Count
	|-Dictionary<object, Color32>.get_Count
	|-Dictionary<object, int>.get_Count
	|-Dictionary<object, Int32Enum>.get_Count
	|-Dictionary<object, object>.get_Count
	|-Dictionary<object, ResourceLocator>.get_Count
	|-Dictionary<object, float>.get_Count
	|-Dictionary<object, StylePropertyValue>.get_Count
	|-Dictionary<object, TextureId>.get_Count
	|-Dictionary<object, TimeSpan>.get_Count
	|-Dictionary<object, uint>.get_Count
	|-Dictionary<object, ulong>.get_Count
	|-Dictionary<object, XPathNodeRef>.get_Count
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Count
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.get_Count
	|-Dictionary<TerrainTileCoord, object>.get_Count
	|-Dictionary<UInt16Enum, object>.get_Count
	|-Dictionary<UInt16Enum, RoleRate>.get_Count
	|-Dictionary<UInt16Enum, uint>.get_Count
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.get_Count
	|-Dictionary<uint, int>.get_Count
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Count
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Count
	|-Dictionary<uint, object>.get_Count
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.get_Count
	|-Dictionary<ulong, Helper.Allocation>.get_Count
	|-Dictionary<ulong, Helper.PinnedBuffer>.get_Count
	|-Dictionary<Vector2, Int32Enum>.get_Count
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Count
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.get_Count
	|-Dictionary<Regex.CachedCodeEntryKey, object>.get_Count
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Count
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Count
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Count
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD7510 Offset: 0xFD6710 VA: 0x180FD7510
	|-Dictionary<KeyValuePair<object, object>, object>.get_Keys
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.get_Keys
	|-Dictionary<ValueTuple<object, object>, object>.get_Keys
	|-Dictionary<byte, bool>.get_Keys
	|-Dictionary<byte, byte>.get_Keys
	|-Dictionary<byte, int>.get_Keys
	|-Dictionary<byte, object>.get_Keys
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.get_Keys
	|-Dictionary<ByteEnum, Int32Enum>.get_Keys
	|-Dictionary<ByteEnum, object>.get_Keys
	|-Dictionary<ByteEnum, float>.get_Keys
	|-Dictionary<char, int>.get_Keys
	|-Dictionary<Color, object>.get_Keys
	|-Dictionary<DateTime, object>.get_Keys
	|-Dictionary<DiscardReasonWithCategory, int>.get_Keys
	|-Dictionary<Guid, int>.get_Keys
	|-Dictionary<Guid, object>.get_Keys
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Keys
	|-Dictionary<int, TreeViewItemData<object>>.get_Keys
	|-Dictionary<int, bool>.get_Keys
	|-Dictionary<int, char>.get_Keys
	|-Dictionary<int, DiagnosticEvent>.get_Keys
	|-Dictionary<int, int>.get_Keys
	|-Dictionary<int, Int32Enum>.get_Keys
	|-Dictionary<int, long>.get_Keys
	|-Dictionary<int, object>.get_Keys
	|-Dictionary<int, RenderInstancedDataLayout>.get_Keys
	|-Dictionary<int, float>.get_Keys
	|-Dictionary<int, TreeItem>.get_Keys
	|-Dictionary<int, TextResourceManager.FontAssetRef>.get_Keys
	|-Dictionary<Int32Enum, bool>.get_Keys
	|-Dictionary<Int32Enum, Color>.get_Keys
	|-Dictionary<Int32Enum, HatOptions>.get_Keys
	|-Dictionary<Int32Enum, int>.get_Keys
	|-Dictionary<Int32Enum, Int32Enum>.get_Keys
	|-Dictionary<Int32Enum, object>.get_Keys
	|-Dictionary<Int32Enum, SkinOptions>.get_Keys
	|-Dictionary<Int32Enum, uint>.get_Keys
	|-Dictionary<Int32Enum, VisorOptions>.get_Keys
	|-Dictionary<long, ComputedStyle>.get_Keys
	|-Dictionary<long, Int32Enum>.get_Keys
	|-Dictionary<long, object>.get_Keys
	|-Dictionary<IntPtr, object>.get_Keys
	|-Dictionary<IntVec3, object>.get_Keys
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.get_Keys
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Keys
	|-Dictionary<object, AsyncOperationHandle>.get_Keys
	|-Dictionary<object, bool>.get_Keys
	|-Dictionary<object, Color32>.get_Keys
	|-Dictionary<object, int>.get_Keys
	|-Dictionary<object, Int32Enum>.get_Keys
	|-Dictionary<object, object>.get_Keys
	|-Dictionary<object, ResourceLocator>.get_Keys
	|-Dictionary<object, float>.get_Keys
	|-Dictionary<object, StylePropertyValue>.get_Keys
	|-Dictionary<object, TextureId>.get_Keys
	|-Dictionary<object, TimeSpan>.get_Keys
	|-Dictionary<object, uint>.get_Keys
	|-Dictionary<object, ulong>.get_Keys
	|-Dictionary<object, XPathNodeRef>.get_Keys
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Keys
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.get_Keys
	|-Dictionary<TerrainTileCoord, object>.get_Keys
	|-Dictionary<UInt16Enum, object>.get_Keys
	|-Dictionary<UInt16Enum, RoleRate>.get_Keys
	|-Dictionary<UInt16Enum, uint>.get_Keys
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.get_Keys
	|-Dictionary<uint, int>.get_Keys
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Keys
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Keys
	|-Dictionary<uint, object>.get_Keys
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.get_Keys
	|-Dictionary<ulong, Helper.Allocation>.get_Keys
	|-Dictionary<ulong, Helper.PinnedBuffer>.get_Keys
	|-Dictionary<Vector2, Int32Enum>.get_Keys
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Keys
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.get_Keys
	|-Dictionary<Regex.CachedCodeEntryKey, object>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Keys
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Keys
	|
	|-RVA: 0x10C0360 Offset: 0x10BF560 VA: 0x1810C0360
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD7510 Offset: 0xFD6710 VA: 0x180FD7510
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<byte, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<byte, byte>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<byte, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<byte, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ByteEnum, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ByteEnum, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ByteEnum, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<char, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Color, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<DateTime, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Guid, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Guid, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, char>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TreeItem>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, Color>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, HatOptions>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, SkinOptions>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, uint>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, VisorOptions>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<long, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<long, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<IntPtr, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<IntVec3, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Color32>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, TextureId>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, TimeSpan>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, uint>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ulong>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<UInt16Enum, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<UInt16Enum, RoleRate>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<UInt16Enum, uint>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ulong, Helper.Allocation>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ulong, Helper.PinnedBuffer>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Vector2, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x10C0360 Offset: 0x10BF560 VA: 0x1810C0360
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD7510 Offset: 0xFD6710 VA: 0x180FD7510
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<byte, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<byte, byte>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<byte, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<byte, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ByteEnum, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ByteEnum, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ByteEnum, float>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<char, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Color, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<DateTime, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Guid, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Guid, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, char>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, float>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TreeItem>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, Color>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, HatOptions>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, SkinOptions>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, uint>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, VisorOptions>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<long, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<long, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<IntPtr, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<IntVec3, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Color32>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, float>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, TextureId>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, TimeSpan>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, uint>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ulong>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<UInt16Enum, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<UInt16Enum, RoleRate>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<UInt16Enum, uint>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ulong, Helper.Allocation>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ulong, Helper.PinnedBuffer>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Vector2, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x10C0360 Offset: 0x10BF560 VA: 0x1810C0360
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD75A0 Offset: 0xFD67A0 VA: 0x180FD75A0
	|-Dictionary<KeyValuePair<object, object>, object>.get_Values
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.get_Values
	|-Dictionary<ValueTuple<object, object>, object>.get_Values
	|-Dictionary<byte, bool>.get_Values
	|-Dictionary<byte, byte>.get_Values
	|-Dictionary<byte, int>.get_Values
	|-Dictionary<byte, object>.get_Values
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.get_Values
	|-Dictionary<ByteEnum, Int32Enum>.get_Values
	|-Dictionary<ByteEnum, object>.get_Values
	|-Dictionary<ByteEnum, float>.get_Values
	|-Dictionary<char, int>.get_Values
	|-Dictionary<Color, object>.get_Values
	|-Dictionary<DateTime, object>.get_Values
	|-Dictionary<DiscardReasonWithCategory, int>.get_Values
	|-Dictionary<Guid, int>.get_Values
	|-Dictionary<Guid, object>.get_Values
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Values
	|-Dictionary<int, TreeViewItemData<object>>.get_Values
	|-Dictionary<int, bool>.get_Values
	|-Dictionary<int, char>.get_Values
	|-Dictionary<int, DiagnosticEvent>.get_Values
	|-Dictionary<int, int>.get_Values
	|-Dictionary<int, Int32Enum>.get_Values
	|-Dictionary<int, long>.get_Values
	|-Dictionary<int, object>.get_Values
	|-Dictionary<int, RenderInstancedDataLayout>.get_Values
	|-Dictionary<int, float>.get_Values
	|-Dictionary<int, TreeItem>.get_Values
	|-Dictionary<int, TextResourceManager.FontAssetRef>.get_Values
	|-Dictionary<Int32Enum, bool>.get_Values
	|-Dictionary<Int32Enum, Color>.get_Values
	|-Dictionary<Int32Enum, HatOptions>.get_Values
	|-Dictionary<Int32Enum, int>.get_Values
	|-Dictionary<Int32Enum, Int32Enum>.get_Values
	|-Dictionary<Int32Enum, object>.get_Values
	|-Dictionary<Int32Enum, SkinOptions>.get_Values
	|-Dictionary<Int32Enum, uint>.get_Values
	|-Dictionary<Int32Enum, VisorOptions>.get_Values
	|-Dictionary<long, ComputedStyle>.get_Values
	|-Dictionary<long, Int32Enum>.get_Values
	|-Dictionary<long, object>.get_Values
	|-Dictionary<IntPtr, object>.get_Values
	|-Dictionary<IntVec3, object>.get_Values
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.get_Values
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Values
	|-Dictionary<object, AsyncOperationHandle>.get_Values
	|-Dictionary<object, bool>.get_Values
	|-Dictionary<object, Color32>.get_Values
	|-Dictionary<object, int>.get_Values
	|-Dictionary<object, Int32Enum>.get_Values
	|-Dictionary<object, object>.get_Values
	|-Dictionary<object, ResourceLocator>.get_Values
	|-Dictionary<object, float>.get_Values
	|-Dictionary<object, StylePropertyValue>.get_Values
	|-Dictionary<object, TextureId>.get_Values
	|-Dictionary<object, TimeSpan>.get_Values
	|-Dictionary<object, uint>.get_Values
	|-Dictionary<object, ulong>.get_Values
	|-Dictionary<object, XPathNodeRef>.get_Values
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Values
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.get_Values
	|-Dictionary<TerrainTileCoord, object>.get_Values
	|-Dictionary<UInt16Enum, object>.get_Values
	|-Dictionary<UInt16Enum, RoleRate>.get_Values
	|-Dictionary<UInt16Enum, uint>.get_Values
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.get_Values
	|-Dictionary<uint, int>.get_Values
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Values
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Values
	|-Dictionary<uint, object>.get_Values
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.get_Values
	|-Dictionary<ulong, Helper.Allocation>.get_Values
	|-Dictionary<ulong, Helper.PinnedBuffer>.get_Values
	|-Dictionary<Vector2, Int32Enum>.get_Values
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Values
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.get_Values
	|-Dictionary<Regex.CachedCodeEntryKey, object>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Values
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Values
	|
	|-RVA: 0x10C03F0 Offset: 0x10BF5F0 VA: 0x1810C03F0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD75A0 Offset: 0xFD67A0 VA: 0x180FD75A0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<byte, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<byte, byte>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<byte, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<byte, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ByteEnum, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ByteEnum, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ByteEnum, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<char, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Color, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<DateTime, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Guid, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Guid, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, char>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TreeItem>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, Color>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, HatOptions>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, SkinOptions>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, uint>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, VisorOptions>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<long, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<long, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<IntPtr, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<IntVec3, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Color32>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, TextureId>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, TimeSpan>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, uint>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ulong>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<UInt16Enum, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<UInt16Enum, RoleRate>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<UInt16Enum, uint>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ulong, Helper.Allocation>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ulong, Helper.PinnedBuffer>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Vector2, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x10C03F0 Offset: 0x10BF5F0 VA: 0x1810C03F0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD75A0 Offset: 0xFD67A0 VA: 0x180FD75A0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<byte, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<byte, byte>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<byte, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<byte, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ByteEnum, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ByteEnum, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ByteEnum, float>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<char, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Color, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<DateTime, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Guid, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Guid, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, char>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, float>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TreeItem>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, Color>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, HatOptions>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, SkinOptions>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, uint>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, VisorOptions>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<long, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<long, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<IntPtr, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<IntVec3, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Color32>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, float>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, TextureId>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, TimeSpan>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, uint>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ulong>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<UInt16Enum, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<UInt16Enum, RoleRate>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<UInt16Enum, uint>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ulong, Helper.Allocation>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ulong, Helper.PinnedBuffer>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Vector2, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x10C03F0 Offset: 0x10BF5F0 VA: 0x1810C03F0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE0920 Offset: 0xFDFB20 VA: 0x180FE0920
	|-Dictionary<KeyValuePair<object, object>, object>.get_Item
	|
	|-RVA: 0xFE0830 Offset: 0xFDFA30 VA: 0x180FE0830
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.get_Item
	|
	|-RVA: 0xFE06C0 Offset: 0xFDF8C0 VA: 0x180FE06C0
	|-Dictionary<ValueTuple<object, object>, object>.get_Item
	|
	|-RVA: 0xFE0780 Offset: 0xFDF980 VA: 0x180FE0780
	|-Dictionary<byte, bool>.get_Item
	|-Dictionary<byte, byte>.get_Item
	|
	|-RVA: 0xFF4330 Offset: 0xFF3530 VA: 0x180FF4330
	|-Dictionary<byte, int>.get_Item
	|
	|-RVA: 0xFF41D0 Offset: 0xFF33D0 VA: 0x180FF41D0
	|-Dictionary<byte, object>.get_Item
	|
	|-RVA: 0xFF43D0 Offset: 0xFF35D0 VA: 0x180FF43D0
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.get_Item
	|
	|-RVA: 0xFF3FE0 Offset: 0xFF31E0 VA: 0x180FF3FE0
	|-Dictionary<ByteEnum, Int32Enum>.get_Item
	|
	|-RVA: 0xFF4120 Offset: 0xFF3320 VA: 0x180FF4120
	|-Dictionary<ByteEnum, object>.get_Item
	|
	|-RVA: 0xFF4280 Offset: 0xFF3480 VA: 0x180FF4280
	|-Dictionary<ByteEnum, float>.get_Item
	|
	|-RVA: 0xFF4080 Offset: 0xFF3280 VA: 0x180FF4080
	|-Dictionary<char, int>.get_Item
	|
	|-RVA: 0x1009DA0 Offset: 0x1008FA0 VA: 0x181009DA0
	|-Dictionary<Color, object>.get_Item
	|
	|-RVA: 0x100A150 Offset: 0x1009350 VA: 0x18100A150
	|-Dictionary<DateTime, object>.get_Item
	|
	|-RVA: 0x1009FC0 Offset: 0x10091C0 VA: 0x181009FC0
	|-Dictionary<DiscardReasonWithCategory, int>.get_Item
	|
	|-RVA: 0x1009F00 Offset: 0x1009100 VA: 0x181009F00
	|-Dictionary<Guid, int>.get_Item
	|
	|-RVA: 0x1009CE0 Offset: 0x1008EE0 VA: 0x181009CE0
	|-Dictionary<Guid, object>.get_Item
	|
	|-RVA: 0x1009E60 Offset: 0x1009060 VA: 0x181009E60
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Item
	|
	|-RVA: 0x100A080 Offset: 0x1009280 VA: 0x18100A080
	|-Dictionary<int, TreeViewItemData<object>>.get_Item
	|
	|-RVA: 0x101C930 Offset: 0x101BB30 VA: 0x18101C930
	|-Dictionary<int, bool>.get_Item
	|
	|-RVA: 0x101C720 Offset: 0x101B920 VA: 0x18101C720
	|-Dictionary<int, char>.get_Item
	|
	|-RVA: 0x101C860 Offset: 0x101BA60 VA: 0x18101C860
	|-Dictionary<int, DiagnosticEvent>.get_Item
	|
	|-RVA: 0x101C7C0 Offset: 0x101B9C0 VA: 0x18101C7C0
	|-Dictionary<int, int>.get_Item
	|-Dictionary<int, Int32Enum>.get_Item
	|
	|-RVA: 0x101C670 Offset: 0x101B870 VA: 0x18101C670
	|-Dictionary<int, long>.get_Item
	|-Dictionary<int, object>.get_Item
	|
	|-RVA: 0x1030330 Offset: 0x102F530 VA: 0x181030330
	|-Dictionary<int, RenderInstancedDataLayout>.get_Item
	|
	|-RVA: 0x1030480 Offset: 0x102F680 VA: 0x181030480
	|-Dictionary<int, float>.get_Item
	|
	|-RVA: 0x1030530 Offset: 0x102F730 VA: 0x181030530
	|-Dictionary<int, TreeItem>.get_Item
	|
	|-RVA: 0x1030110 Offset: 0x102F310 VA: 0x181030110
	|-Dictionary<int, TextResourceManager.FontAssetRef>.get_Item
	|
	|-RVA: 0x10303E0 Offset: 0x102F5E0 VA: 0x1810303E0
	|-Dictionary<Int32Enum, bool>.get_Item
	|-Dictionary<Int32Enum, SkinOptions>.get_Item
	|
	|-RVA: 0x10301E0 Offset: 0x102F3E0 VA: 0x1810301E0
	|-Dictionary<Int32Enum, Color>.get_Item
	|
	|-RVA: 0x1030290 Offset: 0x102F490 VA: 0x181030290
	|-Dictionary<Int32Enum, HatOptions>.get_Item
	|-Dictionary<Int32Enum, int>.get_Item
	|-Dictionary<Int32Enum, Int32Enum>.get_Item
	|-Dictionary<Int32Enum, uint>.get_Item
	|
	|-RVA: 0x1041C50 Offset: 0x1040E50 VA: 0x181041C50
	|-Dictionary<Int32Enum, object>.get_Item
	|
	|-RVA: 0x1041D00 Offset: 0x1040F00 VA: 0x181041D00
	|-Dictionary<Int32Enum, VisorOptions>.get_Item
	|
	|-RVA: 0x1041DA0 Offset: 0x1040FA0 VA: 0x181041DA0
	|-Dictionary<long, ComputedStyle>.get_Item
	|
	|-RVA: 0x106C090 Offset: 0x106B290 VA: 0x18106C090
	|-Dictionary<long, Int32Enum>.get_Item
	|
	|-RVA: 0x106BF30 Offset: 0x106B130 VA: 0x18106BF30
	|-Dictionary<long, object>.get_Item
	|
	|-RVA: 0x106BE80 Offset: 0x106B080 VA: 0x18106BE80
	|-Dictionary<IntPtr, object>.get_Item
	|
	|-RVA: 0x106BDB0 Offset: 0x106AFB0 VA: 0x18106BDB0
	|-Dictionary<IntVec3, object>.get_Item
	|
	|-RVA: 0x106BFE0 Offset: 0x106B1E0 VA: 0x18106BFE0
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.get_Item
	|
	|-RVA: 0x106BD00 Offset: 0x106AF00 VA: 0x18106BD00
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Item
	|
	|-RVA: 0x106C140 Offset: 0x106B340 VA: 0x18106C140
	|-Dictionary<object, AsyncOperationHandle>.get_Item
	|
	|-RVA: 0x107DC50 Offset: 0x107CE50 VA: 0x18107DC50
	|-Dictionary<object, bool>.get_Item
	|
	|-RVA: 0x107DB40 Offset: 0x107CD40 VA: 0x18107DB40
	|-Dictionary<object, Color32>.get_Item
	|-Dictionary<object, TextureId>.get_Item
	|
	|-RVA: 0x107D9C0 Offset: 0x107CBC0 VA: 0x18107D9C0
	|-Dictionary<object, int>.get_Item
	|-Dictionary<object, Int32Enum>.get_Item
	|-Dictionary<object, uint>.get_Item
	|
	|-RVA: 0x107DA40 Offset: 0x107CC40 VA: 0x18107DA40
	|-Dictionary<object, object>.get_Item
	|-Dictionary<object, ulong>.get_Item
	|
	|-RVA: 0x107DBC0 Offset: 0x107CDC0 VA: 0x18107DBC0
	|-Dictionary<object, ResourceLocator>.get_Item
	|-Dictionary<object, StylePropertyValue>.get_Item
	|-Dictionary<object, XPathNodeRef>.get_Item
	|
	|-RVA: 0x107DAC0 Offset: 0x107CCC0 VA: 0x18107DAC0
	|-Dictionary<object, float>.get_Item
	|
	|-RVA: 0x108DA50 Offset: 0x108CC50 VA: 0x18108DA50
	|-Dictionary<object, TimeSpan>.get_Item
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Item
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.get_Item
	|
	|-RVA: 0x10A1510 Offset: 0x10A0710 VA: 0x1810A1510
	|-Dictionary<TerrainTileCoord, object>.get_Item
	|
	|-RVA: 0x10A1670 Offset: 0x10A0870 VA: 0x1810A1670
	|-Dictionary<UInt16Enum, object>.get_Item
	|
	|-RVA: 0x10A15C0 Offset: 0x10A07C0 VA: 0x1810A15C0
	|-Dictionary<UInt16Enum, RoleRate>.get_Item
	|
	|-RVA: 0x10A1470 Offset: 0x10A0670 VA: 0x1810A1470
	|-Dictionary<UInt16Enum, uint>.get_Item
	|
	|-RVA: 0x10A1720 Offset: 0x10A0920 VA: 0x1810A1720
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.get_Item
	|
	|-RVA: 0x10A1800 Offset: 0x10A0A00 VA: 0x1810A1800
	|-Dictionary<uint, int>.get_Item
	|
	|-RVA: 0x10B5A00 Offset: 0x10B4C00 VA: 0x1810B5A00
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Item
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Item
	|
	|-RVA: 0x10B5AD0 Offset: 0x10B4CD0 VA: 0x1810B5AD0
	|-Dictionary<uint, object>.get_Item
	|
	|-RVA: 0x10B5CE0 Offset: 0x10B4EE0 VA: 0x1810B5CE0
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.get_Item
	|
	|-RVA: 0x10B5D90 Offset: 0x10B4F90 VA: 0x1810B5D90
	|-Dictionary<ulong, Helper.Allocation>.get_Item
	|
	|-RVA: 0x10B5B80 Offset: 0x10B4D80 VA: 0x1810B5B80
	|-Dictionary<ulong, Helper.PinnedBuffer>.get_Item
	|
	|-RVA: 0x10B5C30 Offset: 0x10B4E30 VA: 0x1810B5C30
	|-Dictionary<Vector2, Int32Enum>.get_Item
	|
	|-RVA: 0x10CDD40 Offset: 0x10CCF40 VA: 0x1810CDD40
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Item
	|
	|-RVA: 0x10CDF90 Offset: 0x10CD190 VA: 0x1810CDF90
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x10CE270 Offset: 0x10CD470 VA: 0x1810CE270
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.get_Item
	|
	|-RVA: 0x10CDE00 Offset: 0x10CD000 VA: 0x1810CDE00
	|-Dictionary<Regex.CachedCodeEntryKey, object>.get_Item
	|
	|-RVA: 0x10CE1B0 Offset: 0x10CD3B0 VA: 0x1810CE1B0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Item
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Item
	|
	|-RVA: 0x10CDED0 Offset: 0x10CD0D0 VA: 0x1810CDED0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Item
	|
	|-RVA: 0x10D1340 Offset: 0x10D0540 VA: 0x1810D1340
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE0AC0 Offset: 0xFDFCC0 VA: 0x180FE0AC0
	|-Dictionary<KeyValuePair<object, object>, object>.set_Item
	|
	|-RVA: 0xFE0A50 Offset: 0xFDFC50 VA: 0x180FE0A50
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.set_Item
	|
	|-RVA: 0xFE0A10 Offset: 0xFDFC10 VA: 0x180FE0A10
	|-Dictionary<ValueTuple<object, object>, object>.set_Item
	|
	|-RVA: 0xFE09E0 Offset: 0xFDFBE0 VA: 0x180FE09E0
	|-Dictionary<byte, bool>.set_Item
	|
	|-RVA: 0xFE0B00 Offset: 0xFDFD00 VA: 0x180FE0B00
	|-Dictionary<byte, byte>.set_Item
	|
	|-RVA: 0xFF4520 Offset: 0xFF3720 VA: 0x180FF4520
	|-Dictionary<byte, int>.set_Item
	|
	|-RVA: 0xFF4550 Offset: 0xFF3750 VA: 0x180FF4550
	|-Dictionary<byte, object>.set_Item
	|
	|-RVA: 0xFF45B0 Offset: 0xFF37B0 VA: 0x180FF45B0
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.set_Item
	|
	|-RVA: 0xFF4490 Offset: 0xFF3690 VA: 0x180FF4490
	|-Dictionary<ByteEnum, Int32Enum>.set_Item
	|
	|-RVA: 0xFF44F0 Offset: 0xFF36F0 VA: 0x180FF44F0
	|-Dictionary<ByteEnum, object>.set_Item
	|
	|-RVA: 0xFF4580 Offset: 0xFF3780 VA: 0x180FF4580
	|-Dictionary<ByteEnum, float>.set_Item
	|
	|-RVA: 0xFF44C0 Offset: 0xFF36C0 VA: 0x180FF44C0
	|-Dictionary<char, int>.set_Item
	|
	|-RVA: 0x100A200 Offset: 0x1009400 VA: 0x18100A200
	|-Dictionary<Color, object>.set_Item
	|
	|-RVA: 0x100A380 Offset: 0x1009580 VA: 0x18100A380
	|-Dictionary<DateTime, object>.set_Item
	|
	|-RVA: 0x100A2C0 Offset: 0x10094C0 VA: 0x18100A2C0
	|-Dictionary<DiscardReasonWithCategory, int>.set_Item
	|
	|-RVA: 0x100A240 Offset: 0x1009440 VA: 0x18100A240
	|-Dictionary<Guid, int>.set_Item
	|
	|-RVA: 0x100A280 Offset: 0x1009480 VA: 0x18100A280
	|-Dictionary<Guid, object>.set_Item
	|
	|-RVA: 0x100A350 Offset: 0x1009550 VA: 0x18100A350
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.set_Item
	|
	|-RVA: 0x100A300 Offset: 0x1009500 VA: 0x18100A300
	|-Dictionary<int, TreeViewItemData<object>>.set_Item
	|
	|-RVA: 0x101C9D0 Offset: 0x101BBD0 VA: 0x18101C9D0
	|-Dictionary<int, bool>.set_Item
	|
	|-RVA: 0x101CAC0 Offset: 0x101BCC0 VA: 0x18101CAC0
	|-Dictionary<int, char>.set_Item
	|
	|-RVA: 0x101CAF0 Offset: 0x101BCF0 VA: 0x18101CAF0
	|-Dictionary<int, DiagnosticEvent>.set_Item
	|
	|-RVA: 0x101CA30 Offset: 0x101BC30 VA: 0x18101CA30
	|-Dictionary<int, int>.set_Item
	|
	|-RVA: 0x101CA90 Offset: 0x101BC90 VA: 0x18101CA90
	|-Dictionary<int, Int32Enum>.set_Item
	|
	|-RVA: 0x101CA60 Offset: 0x101BC60 VA: 0x18101CA60
	|-Dictionary<int, long>.set_Item
	|
	|-RVA: 0x101CA00 Offset: 0x101BC00 VA: 0x18101CA00
	|-Dictionary<int, object>.set_Item
	|
	|-RVA: 0x1030730 Offset: 0x102F930 VA: 0x181030730
	|-Dictionary<int, RenderInstancedDataLayout>.set_Item
	|
	|-RVA: 0x10306C0 Offset: 0x102F8C0 VA: 0x1810306C0
	|-Dictionary<int, float>.set_Item
	|
	|-RVA: 0x10306F0 Offset: 0x102F8F0 VA: 0x1810306F0
	|-Dictionary<int, TreeItem>.set_Item
	|
	|-RVA: 0x1030650 Offset: 0x102F850 VA: 0x181030650
	|-Dictionary<int, TextResourceManager.FontAssetRef>.set_Item
	|
	|-RVA: 0x1030690 Offset: 0x102F890 VA: 0x181030690
	|-Dictionary<Int32Enum, bool>.set_Item
	|
	|-RVA: 0x10305E0 Offset: 0x102F7E0 VA: 0x1810305E0
	|-Dictionary<Int32Enum, Color>.set_Item
	|
	|-RVA: 0x1030620 Offset: 0x102F820 VA: 0x181030620
	|-Dictionary<Int32Enum, HatOptions>.set_Item
	|
	|-RVA: 0x1042030 Offset: 0x1041230 VA: 0x181042030
	|-Dictionary<Int32Enum, int>.set_Item
	|
	|-RVA: 0x1041EF0 Offset: 0x10410F0 VA: 0x181041EF0
	|-Dictionary<Int32Enum, Int32Enum>.set_Item
	|
	|-RVA: 0x1041FD0 Offset: 0x10411D0 VA: 0x181041FD0
	|-Dictionary<Int32Enum, object>.set_Item
	|
	|-RVA: 0x1041F20 Offset: 0x1041120 VA: 0x181041F20
	|-Dictionary<Int32Enum, SkinOptions>.set_Item
	|
	|-RVA: 0x1042000 Offset: 0x1041200 VA: 0x181042000
	|-Dictionary<Int32Enum, uint>.set_Item
	|
	|-RVA: 0x1041EC0 Offset: 0x10410C0 VA: 0x181041EC0
	|-Dictionary<Int32Enum, VisorOptions>.set_Item
	|
	|-RVA: 0x1041F50 Offset: 0x1041150 VA: 0x181041F50
	|-Dictionary<long, ComputedStyle>.set_Item
	|
	|-RVA: 0x106C310 Offset: 0x106B510 VA: 0x18106C310
	|-Dictionary<long, Int32Enum>.set_Item
	|
	|-RVA: 0x106C200 Offset: 0x106B400 VA: 0x18106C200
	|-Dictionary<long, object>.set_Item
	|
	|-RVA: 0x106C230 Offset: 0x106B430 VA: 0x18106C230
	|-Dictionary<IntPtr, object>.set_Item
	|
	|-RVA: 0x106C260 Offset: 0x106B460 VA: 0x18106C260
	|-Dictionary<IntVec3, object>.set_Item
	|
	|-RVA: 0x106C2A0 Offset: 0x106B4A0 VA: 0x18106C2A0
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.set_Item
	|
	|-RVA: 0x106C2D0 Offset: 0x106B4D0 VA: 0x18106C2D0
	|-Dictionary<object, AsyncOperationHandle<object>>.set_Item
	|
	|-RVA: 0x106C340 Offset: 0x106B540 VA: 0x18106C340
	|-Dictionary<object, AsyncOperationHandle>.set_Item
	|
	|-RVA: 0x107DE00 Offset: 0x107D000 VA: 0x18107DE00
	|-Dictionary<object, bool>.set_Item
	|
	|-RVA: 0x107DD00 Offset: 0x107CF00 VA: 0x18107DD00
	|-Dictionary<object, Color32>.set_Item
	|
	|-RVA: 0x107DD70 Offset: 0x107CF70 VA: 0x18107DD70
	|-Dictionary<object, int>.set_Item
	|
	|-RVA: 0x107DDD0 Offset: 0x107CFD0 VA: 0x18107DDD0
	|-Dictionary<object, Int32Enum>.set_Item
	|
	|-RVA: 0x107DCD0 Offset: 0x107CED0 VA: 0x18107DCD0
	|-Dictionary<object, object>.set_Item
	|
	|-RVA: 0x107DD30 Offset: 0x107CF30 VA: 0x18107DD30
	|-Dictionary<object, ResourceLocator>.set_Item
	|
	|-RVA: 0x107DDA0 Offset: 0x107CFA0 VA: 0x18107DDA0
	|-Dictionary<object, float>.set_Item
	|
	|-RVA: 0x108DAD0 Offset: 0x108CCD0 VA: 0x18108DAD0
	|-Dictionary<object, StylePropertyValue>.set_Item
	|
	|-RVA: 0x108DB10 Offset: 0x108CD10 VA: 0x18108DB10
	|-Dictionary<object, TextureId>.set_Item
	|
	|-RVA: 0x108DBA0 Offset: 0x108CDA0 VA: 0x18108DBA0
	|-Dictionary<object, TimeSpan>.set_Item
	|
	|-RVA: 0x108DB40 Offset: 0x108CD40 VA: 0x18108DB40
	|-Dictionary<object, uint>.set_Item
	|
	|-RVA: 0x108DB70 Offset: 0x108CD70 VA: 0x18108DB70
	|-Dictionary<object, ulong>.set_Item
	|
	|-RVA: 0x108DBD0 Offset: 0x108CDD0 VA: 0x18108DBD0
	|-Dictionary<object, XPathNodeRef>.set_Item
	|
	|-RVA: 0x108DC10 Offset: 0x108CE10 VA: 0x18108DC10
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.set_Item
	|
	|-RVA: 0x10A1930 Offset: 0x10A0B30 VA: 0x1810A1930
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.set_Item
	|
	|-RVA: 0x10A18A0 Offset: 0x10A0AA0 VA: 0x1810A18A0
	|-Dictionary<TerrainTileCoord, object>.set_Item
	|
	|-RVA: 0x10A19C0 Offset: 0x10A0BC0 VA: 0x1810A19C0
	|-Dictionary<UInt16Enum, object>.set_Item
	|
	|-RVA: 0x10A1990 Offset: 0x10A0B90 VA: 0x1810A1990
	|-Dictionary<UInt16Enum, RoleRate>.set_Item
	|
	|-RVA: 0x10A19F0 Offset: 0x10A0BF0 VA: 0x1810A19F0
	|-Dictionary<UInt16Enum, uint>.set_Item
	|
	|-RVA: 0x10A18D0 Offset: 0x10A0AD0 VA: 0x1810A18D0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.set_Item
	|
	|-RVA: 0x10A1960 Offset: 0x10A0B60 VA: 0x1810A1960
	|-Dictionary<uint, int>.set_Item
	|
	|-RVA: 0x10B5EE0 Offset: 0x10B50E0 VA: 0x1810B5EE0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.set_Item
	|
	|-RVA: 0x10B5E90 Offset: 0x10B5090 VA: 0x1810B5E90
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.set_Item
	|
	|-RVA: 0x10B5E60 Offset: 0x10B5060 VA: 0x1810B5E60
	|-Dictionary<uint, object>.set_Item
	|
	|-RVA: 0x10B5FB0 Offset: 0x10B51B0 VA: 0x1810B5FB0
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.set_Item
	|
	|-RVA: 0x10B5FF0 Offset: 0x10B51F0 VA: 0x1810B5FF0
	|-Dictionary<ulong, Helper.Allocation>.set_Item
	|
	|-RVA: 0x10B5F30 Offset: 0x10B5130 VA: 0x1810B5F30
	|-Dictionary<ulong, Helper.PinnedBuffer>.set_Item
	|
	|-RVA: 0x10B5F70 Offset: 0x10B5170 VA: 0x1810B5F70
	|-Dictionary<Vector2, Int32Enum>.set_Item
	|
	|-RVA: 0x10CE5C0 Offset: 0x10CD7C0 VA: 0x1810CE5C0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.set_Item
	|
	|-RVA: 0x10CE430 Offset: 0x10CD630 VA: 0x1810CE430
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	|
	|-RVA: 0x10CE610 Offset: 0x10CD810 VA: 0x1810CE610
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.set_Item
	|
	|-RVA: 0x10CE3B0 Offset: 0x10CD5B0 VA: 0x1810CE3B0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.set_Item
	|
	|-RVA: 0x10CE670 Offset: 0x10CD870 VA: 0x1810CE670
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.set_Item
	|
	|-RVA: 0x10CE370 Offset: 0x10CD570 VA: 0x1810CE370
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.set_Item
	|
	|-RVA: 0x10CE3F0 Offset: 0x10CD5F0 VA: 0x1810CE3F0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.set_Item
	|
	|-RVA: 0x10D13F0 Offset: 0x10D05F0 VA: 0x1810D13F0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD1360 Offset: 0xFD0560 VA: 0x180FD1360
	|-Dictionary<KeyValuePair<object, object>, object>.Add
	|
	|-RVA: 0xFD12F0 Offset: 0xFD04F0 VA: 0x180FD12F0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.Add
	|
	|-RVA: 0xFD13A0 Offset: 0xFD05A0 VA: 0x180FD13A0
	|-Dictionary<ValueTuple<object, object>, object>.Add
	|
	|-RVA: 0xFD1290 Offset: 0xFD0490 VA: 0x180FD1290
	|-Dictionary<byte, bool>.Add
	|
	|-RVA: 0xFD12C0 Offset: 0xFD04C0 VA: 0x180FD12C0
	|-Dictionary<byte, byte>.Add
	|
	|-RVA: 0xFE0BA0 Offset: 0xFDFDA0 VA: 0x180FE0BA0
	|-Dictionary<byte, int>.Add
	|
	|-RVA: 0xFE0B70 Offset: 0xFDFD70 VA: 0x180FE0B70
	|-Dictionary<byte, object>.Add
	|
	|-RVA: 0xFE0B30 Offset: 0xFDFD30 VA: 0x180FE0B30
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.Add
	|
	|-RVA: 0xFE0C00 Offset: 0xFDFE00 VA: 0x180FE0C00
	|-Dictionary<ByteEnum, Int32Enum>.Add
	|
	|-RVA: 0xFE0C30 Offset: 0xFDFE30 VA: 0x180FE0C30
	|-Dictionary<ByteEnum, object>.Add
	|
	|-RVA: 0xFE0C60 Offset: 0xFDFE60 VA: 0x180FE0C60
	|-Dictionary<ByteEnum, float>.Add
	|
	|-RVA: 0xFE0BD0 Offset: 0xFDFDD0 VA: 0x180FE0BD0
	|-Dictionary<char, int>.Add
	|
	|-RVA: 0xFF46A0 Offset: 0xFF38A0 VA: 0x180FF46A0
	|-Dictionary<Color, object>.Add
	|
	|-RVA: 0xFF4720 Offset: 0xFF3920 VA: 0x180FF4720
	|-Dictionary<DateTime, object>.Add
	|
	|-RVA: 0xFF4660 Offset: 0xFF3860 VA: 0x180FF4660
	|-Dictionary<DiscardReasonWithCategory, int>.Add
	|
	|-RVA: 0xFF46E0 Offset: 0xFF38E0 VA: 0x180FF46E0
	|-Dictionary<Guid, int>.Add
	|
	|-RVA: 0xFF4620 Offset: 0xFF3820 VA: 0x180FF4620
	|-Dictionary<Guid, object>.Add
	|
	|-RVA: 0xFF45F0 Offset: 0xFF37F0 VA: 0x180FF45F0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.Add
	|
	|-RVA: 0xFF4750 Offset: 0xFF3950 VA: 0x180FF4750
	|-Dictionary<int, TreeViewItemData<object>>.Add
	|
	|-RVA: 0x100A3B0 Offset: 0x10095B0 VA: 0x18100A3B0
	|-Dictionary<int, bool>.Add
	|
	|-RVA: 0x100A410 Offset: 0x1009610 VA: 0x18100A410
	|-Dictionary<int, char>.Add
	|
	|-RVA: 0x100A4A0 Offset: 0x10096A0 VA: 0x18100A4A0
	|-Dictionary<int, DiagnosticEvent>.Add
	|
	|-RVA: 0x100A440 Offset: 0x1009640 VA: 0x18100A440
	|-Dictionary<int, int>.Add
	|
	|-RVA: 0x100A470 Offset: 0x1009670 VA: 0x18100A470
	|-Dictionary<int, Int32Enum>.Add
	|
	|-RVA: 0x100A3E0 Offset: 0x10095E0 VA: 0x18100A3E0
	|-Dictionary<int, long>.Add
	|
	|-RVA: 0x100A4F0 Offset: 0x10096F0 VA: 0x18100A4F0
	|-Dictionary<int, object>.Add
	|
	|-RVA: 0x101CBE0 Offset: 0x101BDE0 VA: 0x18101CBE0
	|-Dictionary<int, RenderInstancedDataLayout>.Add
	|
	|-RVA: 0x101CB40 Offset: 0x101BD40 VA: 0x18101CB40
	|-Dictionary<int, float>.Add
	|
	|-RVA: 0x101CC20 Offset: 0x101BE20 VA: 0x18101CC20
	|-Dictionary<int, TreeItem>.Add
	|
	|-RVA: 0x101CB70 Offset: 0x101BD70 VA: 0x18101CB70
	|-Dictionary<int, TextResourceManager.FontAssetRef>.Add
	|
	|-RVA: 0x101CCA0 Offset: 0x101BEA0 VA: 0x18101CCA0
	|-Dictionary<Int32Enum, bool>.Add
	|
	|-RVA: 0x101CC60 Offset: 0x101BE60 VA: 0x18101CC60
	|-Dictionary<Int32Enum, Color>.Add
	|
	|-RVA: 0x101CBB0 Offset: 0x101BDB0 VA: 0x18101CBB0
	|-Dictionary<Int32Enum, HatOptions>.Add
	|
	|-RVA: 0x10308E0 Offset: 0x102FAE0 VA: 0x1810308E0
	|-Dictionary<Int32Enum, int>.Add
	|
	|-RVA: 0x1030800 Offset: 0x102FA00 VA: 0x181030800
	|-Dictionary<Int32Enum, Int32Enum>.Add
	|
	|-RVA: 0x1030830 Offset: 0x102FA30 VA: 0x181030830
	|-Dictionary<Int32Enum, object>.Add
	|
	|-RVA: 0x10307D0 Offset: 0x102F9D0 VA: 0x1810307D0
	|-Dictionary<Int32Enum, SkinOptions>.Add
	|
	|-RVA: 0x10307A0 Offset: 0x102F9A0 VA: 0x1810307A0
	|-Dictionary<Int32Enum, uint>.Add
	|
	|-RVA: 0x1030770 Offset: 0x102F970 VA: 0x181030770
	|-Dictionary<Int32Enum, VisorOptions>.Add
	|
	|-RVA: 0x1030860 Offset: 0x102FA60 VA: 0x181030860
	|-Dictionary<long, ComputedStyle>.Add
	|
	|-RVA: 0x1057690 Offset: 0x1056890 VA: 0x181057690
	|-Dictionary<long, Int32Enum>.Add
	|
	|-RVA: 0x1057780 Offset: 0x1056980 VA: 0x181057780
	|-Dictionary<long, object>.Add
	|
	|-RVA: 0x10577B0 Offset: 0x10569B0 VA: 0x1810577B0
	|-Dictionary<IntPtr, object>.Add
	|
	|-RVA: 0x1057650 Offset: 0x1056850 VA: 0x181057650
	|-Dictionary<IntVec3, object>.Add
	|
	|-RVA: 0x1057750 Offset: 0x1056950 VA: 0x181057750
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.Add
	|
	|-RVA: 0x1057710 Offset: 0x1056910 VA: 0x181057710
	|-Dictionary<object, AsyncOperationHandle<object>>.Add
	|
	|-RVA: 0x10576C0 Offset: 0x10568C0 VA: 0x1810576C0
	|-Dictionary<object, AsyncOperationHandle>.Add
	|
	|-RVA: 0x106C390 Offset: 0x106B590 VA: 0x18106C390
	|-Dictionary<object, bool>.Add
	|
	|-RVA: 0x106C3C0 Offset: 0x106B5C0 VA: 0x18106C3C0
	|-Dictionary<object, Color32>.Add
	|
	|-RVA: 0x106C420 Offset: 0x106B620 VA: 0x18106C420
	|-Dictionary<object, int>.Add
	|
	|-RVA: 0x106C3F0 Offset: 0x106B5F0 VA: 0x18106C3F0
	|-Dictionary<object, Int32Enum>.Add
	|
	|-RVA: 0x106C450 Offset: 0x106B650 VA: 0x18106C450
	|-Dictionary<object, object>.Add
	|
	|-RVA: 0x106C480 Offset: 0x106B680 VA: 0x18106C480
	|-Dictionary<object, ResourceLocator>.Add
	|
	|-RVA: 0x106C4C0 Offset: 0x106B6C0 VA: 0x18106C4C0
	|-Dictionary<object, float>.Add
	|
	|-RVA: 0x107DE60 Offset: 0x107D060 VA: 0x18107DE60
	|-Dictionary<object, StylePropertyValue>.Add
	|
	|-RVA: 0x107DF70 Offset: 0x107D170 VA: 0x18107DF70
	|-Dictionary<object, TextureId>.Add
	|
	|-RVA: 0x107DF10 Offset: 0x107D110 VA: 0x18107DF10
	|-Dictionary<object, TimeSpan>.Add
	|
	|-RVA: 0x107DEE0 Offset: 0x107D0E0 VA: 0x18107DEE0
	|-Dictionary<object, uint>.Add
	|
	|-RVA: 0x107DF40 Offset: 0x107D140 VA: 0x18107DF40
	|-Dictionary<object, ulong>.Add
	|
	|-RVA: 0x107DEA0 Offset: 0x107D0A0 VA: 0x18107DEA0
	|-Dictionary<object, XPathNodeRef>.Add
	|
	|-RVA: 0x107DE30 Offset: 0x107D030 VA: 0x18107DE30
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.Add
	|
	|-RVA: 0x108DC40 Offset: 0x108CE40 VA: 0x18108DC40
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.Add
	|
	|-RVA: 0x108DD30 Offset: 0x108CF30 VA: 0x18108DD30
	|-Dictionary<TerrainTileCoord, object>.Add
	|
	|-RVA: 0x108DC70 Offset: 0x108CE70 VA: 0x18108DC70
	|-Dictionary<UInt16Enum, object>.Add
	|
	|-RVA: 0x108DD00 Offset: 0x108CF00 VA: 0x18108DD00
	|-Dictionary<UInt16Enum, RoleRate>.Add
	|
	|-RVA: 0x108DCD0 Offset: 0x108CED0 VA: 0x18108DCD0
	|-Dictionary<UInt16Enum, uint>.Add
	|
	|-RVA: 0x108DD60 Offset: 0x108CF60 VA: 0x18108DD60
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.Add
	|
	|-RVA: 0x108DCA0 Offset: 0x108CEA0 VA: 0x18108DCA0
	|-Dictionary<uint, int>.Add
	|
	|-RVA: 0x10A1BB0 Offset: 0x10A0DB0 VA: 0x1810A1BB0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Add
	|
	|-RVA: 0x10A1B20 Offset: 0x10A0D20 VA: 0x1810A1B20
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Add
	|
	|-RVA: 0x10A1AF0 Offset: 0x10A0CF0 VA: 0x1810A1AF0
	|-Dictionary<uint, object>.Add
	|
	|-RVA: 0x10A1B70 Offset: 0x10A0D70 VA: 0x1810A1B70
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.Add
	|
	|-RVA: 0x10A1AA0 Offset: 0x10A0CA0 VA: 0x1810A1AA0
	|-Dictionary<ulong, Helper.Allocation>.Add
	|
	|-RVA: 0x10A1A20 Offset: 0x10A0C20 VA: 0x1810A1A20
	|-Dictionary<ulong, Helper.PinnedBuffer>.Add
	|
	|-RVA: 0x10A1A60 Offset: 0x10A0C60 VA: 0x1810A1A60
	|-Dictionary<Vector2, Int32Enum>.Add
	|
	|-RVA: 0x10B62F0 Offset: 0x10B54F0 VA: 0x1810B62F0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Add
	|
	|-RVA: 0x10B60E0 Offset: 0x10B52E0 VA: 0x1810B60E0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0x10B6040 Offset: 0x10B5240 VA: 0x1810B6040
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.Add
	|
	|-RVA: 0x10B6340 Offset: 0x10B5540 VA: 0x1810B6340
	|-Dictionary<Regex.CachedCodeEntryKey, object>.Add
	|
	|-RVA: 0x10B62B0 Offset: 0x10B54B0 VA: 0x1810B62B0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.Add
	|
	|-RVA: 0x10B60A0 Offset: 0x10B52A0 VA: 0x1810B60A0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.Add
	|
	|-RVA: 0x10B6270 Offset: 0x10B5470 VA: 0x1810B6270
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.Add
	|
	|-RVA: 0x10CE6F0 Offset: 0x10CD8F0 VA: 0x1810CE6F0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD6A70 Offset: 0xFD5C70 VA: 0x180FD6A70
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFD6AC0 Offset: 0xFD5CC0 VA: 0x180FD6AC0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFD6A20 Offset: 0xFD5C20 VA: 0x180FD6A20
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFD69D0 Offset: 0xFD5BD0 VA: 0x180FD69D0
	|-Dictionary<byte, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFD6980 Offset: 0xFD5B80 VA: 0x180FD6980
	|-Dictionary<byte, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFE76F0 Offset: 0xFE68F0 VA: 0x180FE76F0
	|-Dictionary<byte, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFE7650 Offset: 0xFE6850 VA: 0x180FE7650
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFE77E0 Offset: 0xFE69E0 VA: 0x180FE77E0
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFE7790 Offset: 0xFE6990 VA: 0x180FE7790
	|-Dictionary<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFE7740 Offset: 0xFE6940 VA: 0x180FE7740
	|-Dictionary<ByteEnum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFE76A0 Offset: 0xFE68A0 VA: 0x180FE76A0
	|-Dictionary<ByteEnum, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFE7600 Offset: 0xFE6800 VA: 0x180FE7600
	|-Dictionary<char, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFFC490 Offset: 0xFFB690 VA: 0x180FFC490
	|-Dictionary<Color, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFFC630 Offset: 0xFFB830 VA: 0x180FFC630
	|-Dictionary<DateTime, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFFC4E0 Offset: 0xFFB6E0 VA: 0x180FFC4E0
	|-Dictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFFC5E0 Offset: 0xFFB7E0 VA: 0x180FFC5E0
	|-Dictionary<Guid, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFFC530 Offset: 0xFFB730 VA: 0x180FFC530
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFFC680 Offset: 0xFFB880 VA: 0x180FFC680
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xFFC580 Offset: 0xFFB780 VA: 0x180FFC580
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1010460 Offset: 0x100F660 VA: 0x181010460
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10104B0 Offset: 0x100F6B0 VA: 0x1810104B0
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1010500 Offset: 0x100F700 VA: 0x181010500
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1010570 Offset: 0x100F770 VA: 0x181010570
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1010390 Offset: 0x100F590 VA: 0x181010390
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1010420 Offset: 0x100F620 VA: 0x181010420
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10103E0 Offset: 0x100F5E0 VA: 0x1810103E0
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1023680 Offset: 0x1022880 VA: 0x181023680
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1023630 Offset: 0x1022830 VA: 0x181023630
	|-Dictionary<int, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1023770 Offset: 0x1022970 VA: 0x181023770
	|-Dictionary<int, TreeItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10237C0 Offset: 0x10229C0 VA: 0x1810237C0
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10236D0 Offset: 0x10228D0 VA: 0x1810236D0
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1023720 Offset: 0x1022920 VA: 0x181023720
	|-Dictionary<Int32Enum, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1023820 Offset: 0x1022A20 VA: 0x181023820
	|-Dictionary<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1035EB0 Offset: 0x10350B0 VA: 0x181035EB0
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1035DD0 Offset: 0x1034FD0 VA: 0x181035DD0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1035E20 Offset: 0x1035020 VA: 0x181035E20
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1035F00 Offset: 0x1035100 VA: 0x181035F00
	|-Dictionary<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1035E60 Offset: 0x1035060 VA: 0x181035E60
	|-Dictionary<Int32Enum, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1035FE0 Offset: 0x10351E0 VA: 0x181035FE0
	|-Dictionary<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1035F50 Offset: 0x1035150 VA: 0x181035F50
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x105F1D0 Offset: 0x105E3D0 VA: 0x18105F1D0
	|-Dictionary<long, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x105F260 Offset: 0x105E460 VA: 0x18105F260
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x105F120 Offset: 0x105E320 VA: 0x18105F120
	|-Dictionary<IntPtr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x105F170 Offset: 0x105E370 VA: 0x18105F170
	|-Dictionary<IntVec3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x105F220 Offset: 0x105E420 VA: 0x18105F220
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x105F0C0 Offset: 0x105E2C0 VA: 0x18105F0C0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x105F060 Offset: 0x105E260 VA: 0x18105F060
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1072ED0 Offset: 0x10720D0 VA: 0x181072ED0
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1072D90 Offset: 0x1071F90 VA: 0x181072D90
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1072DE0 Offset: 0x1071FE0 VA: 0x181072DE0
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1072F70 Offset: 0x1072170 VA: 0x181072F70
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1072F20 Offset: 0x1072120 VA: 0x181072F20
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1072E30 Offset: 0x1072030 VA: 0x181072E30
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1072E80 Offset: 0x1072080 VA: 0x181072E80
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1083AD0 Offset: 0x1082CD0 VA: 0x181083AD0
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10839E0 Offset: 0x1082BE0 VA: 0x1810839E0
	|-Dictionary<object, TextureId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1083A30 Offset: 0x1082C30 VA: 0x181083A30
	|-Dictionary<object, TimeSpan>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1083B70 Offset: 0x1082D70 VA: 0x181083B70
	|-Dictionary<object, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1083B20 Offset: 0x1082D20 VA: 0x181083B20
	|-Dictionary<object, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1083990 Offset: 0x1082B90 VA: 0x181083990
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1083A80 Offset: 0x1082C80 VA: 0x181083A80
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1094D70 Offset: 0x1093F70 VA: 0x181094D70
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1094B70 Offset: 0x1093D70 VA: 0x181094B70
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1094C80 Offset: 0x1093E80 VA: 0x181094C80
	|-Dictionary<UInt16Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1094C30 Offset: 0x1093E30 VA: 0x181094C30
	|-Dictionary<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1094D20 Offset: 0x1093F20 VA: 0x181094D20
	|-Dictionary<UInt16Enum, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1094BC0 Offset: 0x1093DC0 VA: 0x181094BC0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1094CD0 Offset: 0x1093ED0 VA: 0x181094CD0
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10A8A50 Offset: 0x10A7C50 VA: 0x1810A8A50
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10A8B00 Offset: 0x10A7D00 VA: 0x1810A8B00
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10A8BB0 Offset: 0x10A7DB0 VA: 0x1810A8BB0
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10A89A0 Offset: 0x10A7BA0 VA: 0x1810A89A0
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10A89F0 Offset: 0x10A7BF0 VA: 0x1810A89F0
	|-Dictionary<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10A8AB0 Offset: 0x10A7CB0 VA: 0x1810A8AB0
	|-Dictionary<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10A8B60 Offset: 0x10A7D60 VA: 0x1810A8B60
	|-Dictionary<Vector2, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10BEEF0 Offset: 0x10BE0F0 VA: 0x1810BEEF0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10BF080 Offset: 0x10BE280 VA: 0x1810BF080
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10BF000 Offset: 0x10BE200 VA: 0x1810BF000
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10BEF50 Offset: 0x10BE150 VA: 0x1810BEF50
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10BEFB0 Offset: 0x10BE1B0 VA: 0x1810BEFB0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10BEE50 Offset: 0x10BE050 VA: 0x1810BEE50
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10BEEA0 Offset: 0x10BE0A0 VA: 0x1810BEEA0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x10CF640 Offset: 0x10CE840 VA: 0x1810CF640
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD6D30 Offset: 0xFD5F30 VA: 0x180FD6D30
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFD6B40 Offset: 0xFD5D40 VA: 0x180FD6B40
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFD6EC0 Offset: 0xFD60C0 VA: 0x180FD6EC0
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFD6E00 Offset: 0xFD6000 VA: 0x180FD6E00
	|-Dictionary<byte, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFD6C70 Offset: 0xFD5E70 VA: 0x180FD6C70
	|-Dictionary<byte, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFE7AA0 Offset: 0xFE6CA0 VA: 0x180FE7AA0
	|-Dictionary<byte, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFE7B60 Offset: 0xFE6D60 VA: 0x180FE7B60
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFE7840 Offset: 0xFE6A40 VA: 0x180FE7840
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFE7CE0 Offset: 0xFE6EE0 VA: 0x180FE7CE0
	|-Dictionary<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFE7920 Offset: 0xFE6B20 VA: 0x180FE7920
	|-Dictionary<ByteEnum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFE7C20 Offset: 0xFE6E20 VA: 0x180FE7C20
	|-Dictionary<ByteEnum, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFE79E0 Offset: 0xFE6BE0 VA: 0x180FE79E0
	|-Dictionary<char, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFFCBB0 Offset: 0xFFBDB0 VA: 0x180FFCBB0
	|-Dictionary<Color, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFFC950 Offset: 0xFFBB50 VA: 0x180FFC950
	|-Dictionary<DateTime, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFFCA10 Offset: 0xFFBC10 VA: 0x180FFCA10
	|-Dictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFFC7C0 Offset: 0xFFB9C0 VA: 0x180FFC7C0
	|-Dictionary<Guid, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFFCAE0 Offset: 0xFFBCE0 VA: 0x180FFCAE0
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFFC890 Offset: 0xFFBA90 VA: 0x180FFC890
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xFFC6C0 Offset: 0xFFB8C0 VA: 0x180FFC6C0
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1010790 Offset: 0x100F990 VA: 0x181010790
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1010910 Offset: 0x100FB10 VA: 0x181010910
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10105C0 Offset: 0x100F7C0 VA: 0x1810105C0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1010A90 Offset: 0x100FC90 VA: 0x181010A90
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10106D0 Offset: 0x100F8D0 VA: 0x1810106D0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10109D0 Offset: 0x100FBD0 VA: 0x1810109D0
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1010850 Offset: 0x100FA50 VA: 0x181010850
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1023AE0 Offset: 0x1022CE0 VA: 0x181023AE0
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1023BB0 Offset: 0x1022DB0 VA: 0x181023BB0
	|-Dictionary<int, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1023940 Offset: 0x1022B40 VA: 0x181023940
	|-Dictionary<int, TreeItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1023D30 Offset: 0x1022F30 VA: 0x181023D30
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1023A20 Offset: 0x1022C20 VA: 0x181023A20
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1023870 Offset: 0x1022A70 VA: 0x181023870
	|-Dictionary<Int32Enum, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1023C70 Offset: 0x1022E70 VA: 0x181023C70
	|-Dictionary<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1036490 Offset: 0x1035690 VA: 0x181036490
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1036250 Offset: 0x1035450 VA: 0x181036250
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1036550 Offset: 0x1035750 VA: 0x181036550
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1036190 Offset: 0x1035390 VA: 0x181036190
	|-Dictionary<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1036310 Offset: 0x1035510 VA: 0x181036310
	|-Dictionary<Int32Enum, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10363D0 Offset: 0x10355D0 VA: 0x1810363D0
	|-Dictionary<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1036030 Offset: 0x1035230 VA: 0x181036030
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x105F530 Offset: 0x105E730 VA: 0x18105F530
	|-Dictionary<long, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x105F5F0 Offset: 0x105E7F0 VA: 0x18105F5F0
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x105F2B0 Offset: 0x105E4B0 VA: 0x18105F2B0
	|-Dictionary<IntPtr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x105F6B0 Offset: 0x105E8B0 VA: 0x18105F6B0
	|-Dictionary<IntVec3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x105F370 Offset: 0x105E570 VA: 0x18105F370
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x105F780 Offset: 0x105E980 VA: 0x18105F780
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x105F430 Offset: 0x105E630 VA: 0x18105F430
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1072FC0 Offset: 0x10721C0 VA: 0x181072FC0
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10733C0 Offset: 0x10725C0 VA: 0x1810733C0
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1073300 Offset: 0x1072500 VA: 0x181073300
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1073480 Offset: 0x1072680 VA: 0x181073480
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1073170 Offset: 0x1072370 VA: 0x181073170
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1073090 Offset: 0x1072290 VA: 0x181073090
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1073230 Offset: 0x1072430 VA: 0x181073230
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1083BC0 Offset: 0x1082DC0 VA: 0x181083BC0
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1083F00 Offset: 0x1083100 VA: 0x181083F00
	|-Dictionary<object, TextureId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1083FC0 Offset: 0x10831C0 VA: 0x181083FC0
	|-Dictionary<object, TimeSpan>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1083CA0 Offset: 0x1082EA0 VA: 0x181083CA0
	|-Dictionary<object, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1083D60 Offset: 0x1082F60 VA: 0x181083D60
	|-Dictionary<object, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1083E20 Offset: 0x1083020 VA: 0x181083E20
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1084080 Offset: 0x1083280 VA: 0x181084080
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1094FB0 Offset: 0x10941B0 VA: 0x181094FB0
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1095130 Offset: 0x1094330 VA: 0x181095130
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10951F0 Offset: 0x10943F0 VA: 0x1810951F0
	|-Dictionary<UInt16Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1094EF0 Offset: 0x10940F0 VA: 0x181094EF0
	|-Dictionary<UInt16Enum, RoleRate>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1095070 Offset: 0x1094270 VA: 0x181095070
	|-Dictionary<UInt16Enum, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1094DC0 Offset: 0x1093FC0 VA: 0x181094DC0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10952B0 Offset: 0x10944B0 VA: 0x1810952B0
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10A8F60 Offset: 0x10A8160 VA: 0x1810A8F60
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10A9140 Offset: 0x10A8340 VA: 0x1810A9140
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10A8EA0 Offset: 0x10A80A0 VA: 0x1810A8EA0
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10A9060 Offset: 0x10A8260 VA: 0x1810A9060
	|-Dictionary<uint, VirtualHeap.PinnedBlob>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10A8BF0 Offset: 0x10A7DF0 VA: 0x1810A8BF0
	|-Dictionary<ulong, Helper.Allocation>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10A8DC0 Offset: 0x10A7FC0 VA: 0x1810A8DC0
	|-Dictionary<ulong, Helper.PinnedBuffer>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10A8CF0 Offset: 0x10A7EF0 VA: 0x1810A8CF0
	|-Dictionary<Vector2, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10BF7D0 Offset: 0x10BE9D0 VA: 0x1810BF7D0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10BF490 Offset: 0x10BE690 VA: 0x1810BF490
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10BF1F0 Offset: 0x10BE3F0 VA: 0x1810BF1F0
	|-Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10BF2F0 Offset: 0x10BE4F0 VA: 0x1810BF2F0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10BF3C0 Offset: 0x10BE5C0 VA: 0x1810BF3C0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10BF700 Offset: 0x10BE900 VA: 0x1810BF700
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10BF8B0 Offset: 0x10BEAB0 VA: 0x1810BF8B0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x10CF690 Offset: 0x10CE890 VA: 0x1810CF690
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD7410 Offset: 0xFD6610 VA: 0x180FD7410
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFD72B0 Offset: 0xFD64B0 VA: 0x180FD72B0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFD70D0 Offset: 0xFD62D0 VA: 0x180FD70D0
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFD71D0 Offset: 0xFD63D0 VA: 0x180FD71D0
	|-Dictionary<byte, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFD6FF0 Offset: 0xFD61F0 VA: 0x180FD6FF0
	|-Dictionary<byte, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFE7F50 Offset: 0xFE7150 VA: 0x180FE7F50
	|-Dictionary<byte, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFE8110 Offset: 0xFE7310 VA: 0x180FE8110
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFE7E40 Offset: 0xFE7040 VA: 0x180FE7E40
	|-Dictionary<byte, MushroomMixupSabotageSystem.CondensedOutfit>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFE8030 Offset: 0xFE7230 VA: 0x180FE8030
	|-Dictionary<ByteEnum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFE83B0 Offset: 0xFE75B0 VA: 0x180FE83B0
	|-Dictionary<ByteEnum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFE82D0 Offset: 0xFE74D0 VA: 0x180FE82D0
	|-Dictionary<ByteEnum, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFE81F0 Offset: 0xFE73F0 VA: 0x180FE81F0
	|-Dictionary<char, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFFCF00 Offset: 0xFFC100 VA: 0x180FFCF00
	|-Dictionary<Color, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFFCD20 Offset: 0xFFBF20 VA: 0x180FFCD20
	|-Dictionary<DateTime, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFFD300 Offset: 0xFFC500 VA: 0x180FFD300
	|-Dictionary<DiscardReasonWithCategory, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFFD200 Offset: 0xFFC400 VA: 0x180FFD200
	|-Dictionary<Guid, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFFCE00 Offset: 0xFFC000 VA: 0x180FFCE00
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFFD120 Offset: 0xFFC320 VA: 0x180FFD120
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xFFD000 Offset: 0xFFC200 VA: 0x180FFD000
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1010BF0 Offset: 0x100FDF0 VA: 0x181010BF0
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x10110A0 Offset: 0x10102A0 VA: 0x1810110A0
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1010CD0 Offset: 0x100FED0 VA: 0x181010CD0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1010FC0 Offset: 0x10101C0 VA: 0x181010FC0
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1010EE0 Offset: 0x10100E0 VA: 0x181010EE0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1010E00 Offset: 0x1010000 VA: 0x181010E00
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1011180 Offset: 0x1010380 VA: 0x181011180
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1023ED0 Offset: 0x10230D0 VA: 0x181023ED0
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1023FD0 Offset: 0x10231D0 VA: 0x181023FD0
	|-Dictionary<int, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1024490 Offset: 0x1023690 VA: 0x181024490
	|-Dictionary<int, TreeItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1024270 Offset: 0x1023470 VA: 0x181024270
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1024190 Offset: 0x1023390 VA: 0x181024190
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1024390 Offset: 0x1023590 VA: 0x181024390
	|-Dictionary<Int32Enum, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x10240B0 Offset: 0x10232B0 VA: 0x1810240B0
	|-Dictionary<Int32Enum, HatOptions>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x10369F0 Offset: 0x1035BF0 VA: 0x1810369F0
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1036910 Offset: 0x1035B10 VA: 0x181036910
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1036C50 Offset: 0x1035E50 VA: 0x181036C50
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1036830 Offset: 0x1035A30 VA: 0x181036830
	|-Dictionary<Int32Enum, SkinOptions>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1036750 Offset: 0x1035950 VA: 0x181036750
	|-Dictionary<Int32Enum, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1036670 Offset: 0x1035870 VA: 0x181036670
	|-Dictionary<Int32Enum, VisorOptions>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1036AD0 Offset: 0x1035CD0 VA: 0x181036AD0
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x105FB40 Offset: 0x105ED40 VA: 0x18105FB40
	|-Dictionary<long, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x105F940 Offset: 0x105EB40 VA: 0x18105F940
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x105FD00 Offset: 0x105EF00 VA: 0x18105FD00
	|-Dictionary<IntPtr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x105FF00 Offset: 0x105F100 VA: 0x18105FF00
	|-Dictionary<IntVec3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x105FC20 Offset: 0x105EE20 VA: 0x18105FC20
	|-Dictionary<MNJcwvoQkulZtllpaHFcSdphQVOi, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x105FA20 Offset: 0x105EC20 VA: 0x18105FA20
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x105FDE0 Offset: 0x105EFE0 VA: 0x18105FDE0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1073A20 Offset: 0x1072C20 VA: 0x181073A20
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x10735C0 Offset: 0x10727C0 VA: 0x1810735C0
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x10736A0 Offset: 0x10728A0 VA: 0x1810736A0
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1073860 Offset: 0x1072A60 VA: 0x181073860
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1073940 Offset: 0x1072B40 VA: 0x181073940
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1073B00 Offset: 0x1072D00 VA: 0x181073B00
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1073780 Offset: 0x1072980 VA: 0x181073780
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1084400 Offset: 0x1083600 VA: 0x181084400
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1084320 Offset: 0x1083520 VA: 0x181084320
	|-Dictionary<object, TextureId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1084160 Offset: 0x1083360 VA: 0x181084160
	|-Dictionary<object, TimeSpan>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1084240 Offset: 0x1083440 VA: 0x181084240
	|-Dictionary<object, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1084600 Offset: 0x1083800 VA: 0x181084600
	|-Dictionary<object, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1084500 Offset: 0x1083700 VA: 0x181084500
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
