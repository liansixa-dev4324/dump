internal enum NodeColor // TypeDefIndex: 5574
{
	// Fields
	public byte value__; // 0x0
	public const NodeColor Black = 0;
	public const NodeColor Red = 1;
}

// Namespace: System.Collections.Generic
internal sealed class TreeWalkPredicate<T> : MulticastDelegate // TypeDefIndex: 5575
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC5940 Offset: 0xCC4B40 VA: 0x180CC5940
	|-TreeWalkPredicate<KeyValuePair<object, char>>..ctor
	|-TreeWalkPredicate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-TreeWalkPredicate<KeyValuePair<object, char>>.Invoke
	|-TreeWalkPredicate<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(SortedSet.Node<T> node, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210
	|-TreeWalkPredicate<KeyValuePair<object, char>>.BeginInvoke
	|-TreeWalkPredicate<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x409E60 Offset: 0x409060 VA: 0x180409E60
	|-TreeWalkPredicate<KeyValuePair<object, char>>.EndInvoke
	|-TreeWalkPredicate<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: System.Collections.Generic
internal enum TreeRotation // TypeDefIndex: 5576
{
	// Fields
	public byte value__; // 0x0
	public const TreeRotation Left = 0;
	public const TreeRotation LeftRight = 1;
	public const TreeRotation Right = 2;
	public const TreeRotation RightLeft = 3;
}

// Namespace: System.Collections.Generic
internal sealed class SortedSetEqualityComparer<T> : IEqualityComparer<SortedSet<T>> // TypeDefIndex: 5577
{
	// Fields
	private readonly IComparer<T> _comparer; // 0x0
	private readonly IEqualityComparer<T> _memberEqualityComparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<T> memberEqualityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1CCC0 Offset: 0xC1BEC0 VA: 0x180C1CCC0
	|-SortedSetEqualityComparer<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0xC1CC10 Offset: 0xC1BE10 VA: 0x180C1CC10
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(IComparer<T> comparer, IEqualityComparer<T> memberEqualityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1CAA0 Offset: 0xC1BCA0 VA: 0x180C1CAA0
	|-SortedSetEqualityComparer<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0xC1CC30 Offset: 0xC1BE30 VA: 0x180C1CC30
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(SortedSet<T> x, SortedSet<T> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1C400 Offset: 0xC1B600 VA: 0x180C1C400
	|-SortedSetEqualityComparer<KeyValuePair<object, char>>.Equals
	|
	|-RVA: 0xC1C3D0 Offset: 0xC1B5D0 VA: 0x180C1C3D0
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int GetHashCode(SortedSet<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1C800 Offset: 0xC1BA00 VA: 0x180C1C800
	|-SortedSetEqualityComparer<KeyValuePair<object, char>>.GetHashCode
	|
	|-RVA: 0xC1C500 Offset: 0xC1B700 VA: 0x180C1C500
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1C430 Offset: 0xC1B630 VA: 0x180C1C430
	|-SortedSetEqualityComparer<KeyValuePair<object, char>>.Equals
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1C4A0 Offset: 0xC1B6A0 VA: 0x180C1C4A0
	|-SortedSetEqualityComparer<KeyValuePair<object, char>>.GetHashCode
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>.GetHashCode
	*/
}

// Namespace: System.Collections.Generic
internal sealed class CollectionDebugView<T> // TypeDefIndex: 5578
{
	// Fields
	private readonly ICollection<T> _collection; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public T[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04180 Offset: 0xD03380 VA: 0x180D04180
	|-CollectionDebugView<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07E80 Offset: 0xF07080 VA: 0x180F07E80
	|-CollectionDebugView<__Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: System.Collections.Generic
internal sealed class DictionaryDebugView<K, V> // TypeDefIndex: 5579
{
	// Fields
	private readonly IDictionary<K, V> _dict; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public KeyValuePair<K, V>[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<K, V> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCECF0 Offset: 0xBCDEF0 VA: 0x180BCECF0
	|-DictionaryDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<K, V>[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC61F0 Offset: 0xFC53F0 VA: 0x180FC61F0
	|-DictionaryDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: System.Collections.Generic
public interface ISet<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 5580
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Add(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void UnionWith(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.UnionWith
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void IntersectWith(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IntersectWith
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ExceptWith(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.ExceptWith
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SymmetricExceptWith(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.SymmetricExceptWith
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool IsSubsetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool IsSupersetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsProperSupersetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsProperSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsProperSubsetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsProperSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Overlaps(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.Overlaps
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool SetEquals(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.SetEquals
	*/
}

// Namespace: System.IO
public class FileSystemEventArgs : EventArgs // TypeDefIndex: 5581
{
	// Fields
	private readonly WatcherChangeTypes _changeType; // 0x10
	private readonly string _name; // 0x18
	private readonly string _fullPath; // 0x20

	// Properties
	public WatcherChangeTypes ChangeType { get; }
	public string FullPath { get; }
	public string Name { get; }

	// Methods

	// RVA: 0x211FC50 Offset: 0x211EE50 VA: 0x18211FC50
	public void .ctor(WatcherChangeTypes changeType, string directory, string name) { }

	// RVA: 0x211FB00 Offset: 0x211ED00 VA: 0x18211FB00
	internal static string Combine(string directoryPath, string name) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public WatcherChangeTypes get_ChangeType() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_FullPath() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Name() { }
}

// Namespace: 
private sealed class ChunkedMemoryStream.MemoryChunk // TypeDefIndex: 5582
{
	// Fields
	internal readonly byte[] _buffer; // 0x10
	internal int _freeOffset; // 0x18
	internal ChunkedMemoryStream.MemoryChunk _next; // 0x20

	// Methods

	// RVA: 0x21277C0 Offset: 0x21269C0 VA: 0x1821277C0
	internal void .ctor(int bufferSize) { }
}

// Namespace: System.IO
internal sealed class ChunkedMemoryStream : Stream // TypeDefIndex: 5583
{
	// Fields
	private ChunkedMemoryStream.MemoryChunk _headChunk; // 0x28
	private ChunkedMemoryStream.MemoryChunk _currentChunk; // 0x30
	private const int InitialChunkDefaultSize = 1024;
	private const int MaxChunkSize = 1048576;
	private int _totalLength; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x21196B0 Offset: 0x21188B0 VA: 0x1821196B0
	internal void .ctor() { }

	// RVA: 0x21193E0 Offset: 0x21185E0 VA: 0x1821193E0
	public byte[] ToArray() { }

	// RVA: 0x21195B0 Offset: 0x21187B0 VA: 0x1821195B0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2119480 Offset: 0x2118680 VA: 0x182119480 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2119160 Offset: 0x2118360 VA: 0x182119160
	private void AppendChunk(long count) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2119700 Offset: 0x2118900 VA: 0x182119700 Slot: 11
	public override long get_Length() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public override void Flush() { }

	// RVA: 0x2119270 Offset: 0x2118470 VA: 0x182119270 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2119710 Offset: 0x2118910 VA: 0x182119710 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2119750 Offset: 0x2118950 VA: 0x182119750 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2119300 Offset: 0x2118500 VA: 0x182119300 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2119340 Offset: 0x2118540 VA: 0x182119340 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2119380 Offset: 0x2118580 VA: 0x182119380 Slot: 33
	public override void SetLength(long value) { }
}

// Namespace: System.IO
internal static class PathInternal // TypeDefIndex: 5584
{
	// Fields
	private static readonly bool s_isCaseSensitive; // 0x0

	// Properties
	internal static StringComparison StringComparison { get; }
	internal static bool IsCaseSensitive { get; }

	// Methods

	// RVA: 0x212C040 Offset: 0x212B240 VA: 0x18212C040
	internal static StringComparison get_StringComparison() { }

	// RVA: 0x212BFF0 Offset: 0x212B1F0 VA: 0x18212BFF0
	internal static bool get_IsCaseSensitive() { }

	// RVA: 0x212BDF0 Offset: 0x212AFF0 VA: 0x18212BDF0
	private static bool GetIsCaseSensitive() { }

	// RVA: 0x212BFB0 Offset: 0x212B1B0 VA: 0x18212BFB0
	private static void .cctor() { }
}

// Namespace: System.IO
internal sealed class ReadOnlyMemoryStream : Stream // TypeDefIndex: 5585
{
	// Fields
	private readonly ReadOnlyMemory<byte> _content; // 0x28
	private int _position; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x212CEB0 Offset: 0x212C0B0 VA: 0x18212CEB0
	public void .ctor(ReadOnlyMemory<byte> content) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x212CF10 Offset: 0x212C110 VA: 0x18212CF10 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2119700 Offset: 0x2118900 VA: 0x182119700 Slot: 12
	public override long get_Position() { }

	// RVA: 0x212CF50 Offset: 0x212C150 VA: 0x18212CF50 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x212CBB0 Offset: 0x212BDB0 VA: 0x18212CBB0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x212C850 Offset: 0x212BA50 VA: 0x18212C850 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x212CAE0 Offset: 0x212BCE0 VA: 0x18212CAE0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x212C8D0 Offset: 0x212BAD0 VA: 0x18212C8D0 Slot: 35
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x212C6D0 Offset: 0x212B8D0 VA: 0x18212C6D0 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x212C570 Offset: 0x212B770 VA: 0x18212C570 Slot: 27
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x212C140 Offset: 0x212B340 VA: 0x18212C140 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x212C4A0 Offset: 0x212B6A0 VA: 0x18212C4A0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x212C360 Offset: 0x212B560 VA: 0x18212C360 Slot: 19
	public override void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x212C170 Offset: 0x212B370 VA: 0x18212C170 Slot: 18
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public override void Flush() { }

	// RVA: 0x212C4E0 Offset: 0x212B6E0 VA: 0x18212C4E0 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x212CD20 Offset: 0x212BF20 VA: 0x18212CD20 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x212CE70 Offset: 0x212C070 VA: 0x18212CE70 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x212CD60 Offset: 0x212BF60 VA: 0x18212CD60
	private static void ValidateReadArrayArguments(byte[] buffer, int offset, int count) { }
}

// Namespace: System.IO
public sealed class FileSystemEventHandler : MulticastDelegate // TypeDefIndex: 5586
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, FileSystemEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, FileSystemEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.IO
public class RenamedEventArgs : FileSystemEventArgs // TypeDefIndex: 5587
{
	// Fields
	private readonly string _oldName; // 0x28
	private readonly string _oldFullPath; // 0x30

	// Properties
	public string OldFullPath { get; }
	public string OldName { get; }

	// Methods

	// RVA: 0x212CFC0 Offset: 0x212C1C0 VA: 0x18212CFC0
	public void .ctor(WatcherChangeTypes changeType, string directory, string name, string oldName) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_OldFullPath() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_OldName() { }
}

// Namespace: System.IO
public sealed class RenamedEventHandler : MulticastDelegate // TypeDefIndex: 5588
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, RenamedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, RenamedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.IO
public struct WaitForChangedResult // TypeDefIndex: 5589
{
	// Fields
	internal static readonly WaitForChangedResult TimedOutResult; // 0x0
	[CompilerGenerated]
	private WatcherChangeTypes <ChangeType>k__BackingField; // 0x0
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x8
	[CompilerGenerated]
	private string <OldName>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <TimedOut>k__BackingField; // 0x18

	// Properties
	public WatcherChangeTypes ChangeType { get; set; }
	public string Name { get; set; }
	public string OldName { get; set; }
	public bool TimedOut { get; set; }

	// Methods

	// RVA: 0x2135B30 Offset: 0x2134D30 VA: 0x182135B30
	internal void .ctor(WatcherChangeTypes changeType, string name, string oldName, bool timedOut) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public WatcherChangeTypes get_ChangeType() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ChangeType(WatcherChangeTypes value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Name(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_OldName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_OldName(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_TimedOut() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_TimedOut(bool value) { }

	// RVA: 0x2135AA0 Offset: 0x2134CA0 VA: 0x182135AA0
	private static void .cctor() { }
}

// Namespace: System.IO
internal class DefaultWatcherData // TypeDefIndex: 5590
{
	// Fields
	public FileSystemWatcher FSW; // 0x10
	public string Directory; // 0x18
	public string FileMask; // 0x20
	public bool IncludeSubdirs; // 0x28
	public bool Enabled; // 0x29
	public bool NoWildcards; // 0x2A
	public DateTime DisabledTime; // 0x30
	public object FilesLock; // 0x38
	public Dictionary<string, FileData> Files; // 0x40

	// Methods

	// RVA: 0x211ACE0 Offset: 0x2119EE0 VA: 0x18211ACE0
	public void .ctor() { }
}

// Namespace: System.IO
internal class FileData // TypeDefIndex: 5591
{
	// Fields
	public string Directory; // 0x10
	public FileAttributes Attributes; // 0x18
	public bool NotExists; // 0x1C
	public DateTime CreationTime; // 0x20
	public DateTime LastWriteTime; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.IO
internal class DefaultWatcher : IFileWatcher // TypeDefIndex: 5592
{
	// Fields
	private static DefaultWatcher instance; // 0x0
	private static Thread thread; // 0x8
	private static Hashtable watches; // 0x10
	private static string[] NoStringsArray; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x211B130 Offset: 0x211A330 VA: 0x18211B130
	public static bool GetInstance(out IFileWatcher watcher) { }

	// RVA: 0x211C330 Offset: 0x211B530 VA: 0x18211C330 Slot: 4
	public void StartDispatching(object handle) { }

	// RVA: 0x211CB00 Offset: 0x211BD00 VA: 0x18211CB00 Slot: 5
	public void StopDispatching(object handle) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose(object handle) { }

	// RVA: 0x211BBE0 Offset: 0x211ADE0 VA: 0x18211BBE0
	private void Monitor() { }

	// RVA: 0x211CEC0 Offset: 0x211C0C0 VA: 0x18211CEC0
	private bool UpdateDataAndDispatch(DefaultWatcherData data, bool dispatch) { }

	// RVA: 0x211AE10 Offset: 0x211A010 VA: 0x18211AE10
	private static void DispatchEvents(FileSystemWatcher fsw, FileAction action, string filename) { }

	// RVA: 0x211AEF0 Offset: 0x211A0F0 VA: 0x18211AEF0
	private void DoFiles(DefaultWatcherData data, string directory, bool dispatch) { }

	// RVA: 0x211B210 Offset: 0x211A410 VA: 0x18211B210
	private void IterateAndModifyFilesData(DefaultWatcherData data, string directory, bool dispatch, string[] files) { }

	// RVA: 0x211AD40 Offset: 0x2119F40 VA: 0x18211AD40
	private static FileData CreateFileData(string directory, string filename) { }

	// RVA: 0x211CFF0 Offset: 0x211C1F0 VA: 0x18211CFF0
	private static void .cctor() { }
}

// Namespace: System.IO
public class ErrorEventArgs : EventArgs // TypeDefIndex: 5593
{
	// Fields
	private Exception exception; // 0x10

	// Methods

	// RVA: 0x211FA20 Offset: 0x211EC20 VA: 0x18211FA20
	public void .ctor(Exception exception) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public virtual Exception GetException() { }
}

// Namespace: System.IO
public sealed class ErrorEventHandler : MulticastDelegate // TypeDefIndex: 5594
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

// Namespace: System.IO
internal enum FileAction // TypeDefIndex: 5595
{
	// Fields
	public int value__; // 0x0
	public const FileAction Added = 1;
	public const FileAction Removed = 2;
	public const FileAction Modified = 3;
	public const FileAction RenamedOldName = 4;
	public const FileAction RenamedNewName = 5;
}

// Namespace: 
private enum FileSystemWatcher.EventType // TypeDefIndex: 5596
{
	// Fields
	public int value__; // 0x0
	public const FileSystemWatcher.EventType FileSystemEvent = 0;
	public const FileSystemWatcher.EventType ErrorEvent = 1;
	public const FileSystemWatcher.EventType RenameEvent = 2;
}

// Namespace: 
[CompilerGenerated]
private sealed class FileSystemWatcher.<>c__DisplayClass70_0 // TypeDefIndex: 5597
{
	// Fields
	public FileSystemWatcher <>4__this; // 0x10
	public string filename; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2135540 Offset: 0x2134740 VA: 0x182135540
	internal void <DispatchEvents>b__0() { }

	// RVA: 0x21355F0 Offset: 0x21347F0 VA: 0x1821355F0
	internal void <DispatchEvents>b__1() { }

	// RVA: 0x21356A0 Offset: 0x21348A0 VA: 0x1821356A0
	internal void <DispatchEvents>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FileSystemWatcher.<>c__DisplayClass70_1 // TypeDefIndex: 5598
{
	// Fields
	public RenamedEventArgs renamed_ref; // 0x10
	public FileSystemWatcher.<>c__DisplayClass70_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2135750 Offset: 0x2134950 VA: 0x182135750
	internal void <DispatchEvents>b__3() { }
}

// Namespace: System.IO
[DefaultEvent("Changed")]
[IODescription("")]
public class FileSystemWatcher : Component, ISupportInitialize // TypeDefIndex: 5599
{
	// Fields
	private bool inited; // 0x28
	private bool start_requested; // 0x29
	private bool enableRaisingEvents; // 0x2A
	private string filter; // 0x30
	private bool includeSubdirectories; // 0x38
	private int internalBufferSize; // 0x3C
	private NotifyFilters notifyFilter; // 0x40
	private string path; // 0x48
	private string fullpath; // 0x50
	private ISynchronizeInvoke synchronizingObject; // 0x58
	private WaitForChangedResult lastData; // 0x60
	private bool waiting; // 0x80
	private SearchPattern2 pattern; // 0x88
	private bool disposed; // 0x90
	private string mangledFilter; // 0x98
	private IFileWatcher watcher; // 0xA0
	private object watcher_handle; // 0xA8
	private static object lockobj; // 0x0
	[CompilerGenerated]
	private FileSystemEventHandler Changed; // 0xB0
	[CompilerGenerated]
	private FileSystemEventHandler Created; // 0xB8
	[CompilerGenerated]
	private FileSystemEventHandler Deleted; // 0xC0
	[CompilerGenerated]
	private ErrorEventHandler Error; // 0xC8
	[CompilerGenerated]
	private RenamedEventHandler Renamed; // 0xD0

	// Properties
	internal bool Waiting { get; set; }
	internal string MangledFilter { get; }
	internal SearchPattern2 Pattern { get; }
	internal string FullPath { get; }
	[IODescription("Flag to indicate if this instance is active")]
	[DefaultValue(False)]
	public bool EnableRaisingEvents { get; set; }
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[IODescription("File name filter pattern")]
	[SettingsBindable(True)]
	[DefaultValue("*.*")]
	public string Filter { get; set; }
	[IODescription("Flag to indicate we want to watch subdirectories")]
	[DefaultValue(False)]
	public bool IncludeSubdirectories { get; set; }
	[DefaultValue(8192)]
	[Browsable(False)]
	public int InternalBufferSize { get; set; }
	[IODescription("Flag to indicate which change event we want to monitor")]
	[DefaultValue(19)]
	public NotifyFilters NotifyFilter { get; set; }
	[SettingsBindable(True)]
	[IODescription("The directory to monitor")]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[Editor("System.Diagnostics.Design.FSWPathEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultValue("")]
	public string Path { get; set; }
	[Browsable(False)]
	public override ISite Site { get; set; }
	[IODescription("The object used to marshal the event handler calls resulting from a directory change")]
	[DefaultValue(null)]
	[Browsable(False)]
	public ISynchronizeInvoke SynchronizingObject { get; set; }

	// Methods

	// RVA: 0x2122D50 Offset: 0x2121F50 VA: 0x182122D50
	public void .ctor() { }

	// RVA: 0x2122860 Offset: 0x2121A60 VA: 0x182122860
	public void .ctor(string path) { }

	// RVA: 0x2122AE0 Offset: 0x2121CE0 VA: 0x182122AE0
	public void .ctor(string path, string filter) { }

	// RVA: 0x2120690 Offset: 0x211F890 VA: 0x182120690
	private void InitWatcher() { }

	[Conditional("TRACE")]
	[Conditional("DEBUG")]
	// RVA: 0x21219E0 Offset: 0x2120BE0 VA: 0x1821219E0
	private void ShowWatcherInfo() { }

	// RVA: 0x67AA00 Offset: 0x679C00 VA: 0x18067AA00
	internal bool get_Waiting() { }

	// RVA: 0x67AD80 Offset: 0x679F80 VA: 0x18067AD80
	internal void set_Waiting(bool value) { }

	// RVA: 0x21235D0 Offset: 0x21227D0 VA: 0x1821235D0
	internal string get_MangledFilter() { }

	// RVA: 0x2123640 Offset: 0x2122840 VA: 0x182123640
	internal SearchPattern2 get_Pattern() { }

	// RVA: 0x2123520 Offset: 0x2122720 VA: 0x182123520
	internal string get_FullPath() { }

	// RVA: 0x4C6AA0 Offset: 0x4C5CA0 VA: 0x1804C6AA0
	public bool get_EnableRaisingEvents() { }

	// RVA: 0x2123DC0 Offset: 0x2122FC0 VA: 0x182123DC0
	public void set_EnableRaisingEvents(bool value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Filter() { }

	// RVA: 0x2123EF0 Offset: 0x21230F0 VA: 0x182123EF0
	public void set_Filter(string value) { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_IncludeSubdirectories() { }

	// RVA: 0x2124060 Offset: 0x2123260 VA: 0x182124060
	public void set_IncludeSubdirectories(bool value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	public int get_InternalBufferSize() { }

	// RVA: 0x21240A0 Offset: 0x21232A0 VA: 0x1821240A0
	public void set_InternalBufferSize(int value) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public NotifyFilters get_NotifyFilter() { }

	// RVA: 0x2124230 Offset: 0x2123430 VA: 0x182124230
	public void set_NotifyFilter(NotifyFilters value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_Path() { }

	// RVA: 0x2124270 Offset: 0x2123470 VA: 0x182124270
	public void set_Path(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 12
	public override ISite get_Site() { }

	// RVA: 0x21247C0 Offset: 0x21239C0 VA: 0x1821247C0 Slot: 13
	public override void set_Site(ISite value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_SynchronizingObject(ISynchronizeInvoke value) { }

	// RVA: 0x538580 Offset: 0x537780 VA: 0x180538580 Slot: 16
	public void BeginInit() { }

	// RVA: 0x2120370 Offset: 0x211F570 VA: 0x182120370 Slot: 14
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21205E0 Offset: 0x211F7E0 VA: 0x1821205E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2120500 Offset: 0x211F700 VA: 0x182120500 Slot: 17
	public void EndInit() { }

	// RVA: 0x2121690 Offset: 0x2120890 VA: 0x182121690
	private void RaiseEvent(Delegate ev, EventArgs arg, FileSystemWatcher.EventType evtype) { }

	// RVA: 0x21212B0 Offset: 0x21204B0 VA: 0x1821212B0
	protected void OnChanged(FileSystemEventArgs e) { }

	// RVA: 0x21212F0 Offset: 0x21204F0 VA: 0x1821212F0
	protected void OnCreated(FileSystemEventArgs e) { }

	// RVA: 0x2121330 Offset: 0x2120530 VA: 0x182121330
	protected void OnDeleted(FileSystemEventArgs e) { }

	// RVA: 0x2121370 Offset: 0x2120570 VA: 0x182121370
	protected void OnError(ErrorEventArgs e) { }

	// RVA: 0x2121500 Offset: 0x2120700 VA: 0x182121500
	protected void OnRenamed(RenamedEventArgs e) { }

	// RVA: 0x2121C90 Offset: 0x2120E90 VA: 0x182121C90
	public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType) { }

	// RVA: 0x2122490 Offset: 0x2121690 VA: 0x182122490
	public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout) { }

	// RVA: 0x211FF50 Offset: 0x211F150 VA: 0x18211FF50
	internal void DispatchErrorEvents(ErrorEventArgs args) { }

	// RVA: 0x211FF80 Offset: 0x211F180 VA: 0x18211FF80
	internal void DispatchEvents(FileAction act, string filename, ref RenamedEventArgs renamed) { }

	// RVA: 0x2121B70 Offset: 0x2120D70 VA: 0x182121B70
	private void Start() { }

	// RVA: 0x2121C20 Offset: 0x2120E20 VA: 0x182121C20
	private void Stop() { }

	[CompilerGenerated]
	// RVA: 0x2122DF0 Offset: 0x2121FF0 VA: 0x182122DF0
	public void add_Changed(FileSystemEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2123780 Offset: 0x2122980 VA: 0x182123780
	public void remove_Changed(FileSystemEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2122F40 Offset: 0x2122140 VA: 0x182122F40
	public void add_Created(FileSystemEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x21238D0 Offset: 0x2122AD0 VA: 0x1821238D0
	public void remove_Created(FileSystemEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2123130 Offset: 0x2122330 VA: 0x182123130
	public void add_Deleted(FileSystemEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2123A20 Offset: 0x2122C20 VA: 0x182123A20
	public void remove_Deleted(FileSystemEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2123280 Offset: 0x2122480 VA: 0x182123280
	public void add_Error(ErrorEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2123B70 Offset: 0x2122D70 VA: 0x182123B70
	public void remove_Error(ErrorEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2123330 Offset: 0x2122530 VA: 0x182123330
	public void add_Renamed(RenamedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2123C20 Offset: 0x2122E20 VA: 0x182123C20
	public void remove_Renamed(RenamedEventHandler value) { }

	// RVA: 0x2120930 Offset: 0x211FB30 VA: 0x182120930
	private static int InternalSupportsFSW() { }

	// RVA: 0x2122730 Offset: 0x2121930 VA: 0x182122730
	private static void .cctor() { }
}

// Namespace: System.IO
internal interface IFileWatcher // TypeDefIndex: 5600
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void StartDispatching(object fsw);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StopDispatching(object fsw);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Dispose(object fsw);
}

// Namespace: System.IO
[Usage(32767)]
public class IODescriptionAttribute : DescriptionAttribute // TypeDefIndex: 5601
{
	// Properties
	public override string Description { get; }

	// Methods

	// RVA: 0x2126720 Offset: 0x2125920 VA: 0x182126720
	public void .ctor(string description) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 7
	public override string get_Description() { }
}

// Namespace: System.IO
[Serializable]
public class InternalBufferOverflowException : SystemException // TypeDefIndex: 5602
{
	// Methods

	// RVA: 0x2127030 Offset: 0x2126230 VA: 0x182127030
	public void .ctor() { }

	// RVA: 0x160B4C0 Offset: 0x160A6C0 VA: 0x18160B4C0
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1633A30 Offset: 0x1632C30 VA: 0x181633A30
	public void .ctor(string message, Exception inner) { }
}

// Namespace: System.IO
[Serializable]
public sealed class InvalidDataException : SystemException // TypeDefIndex: 5603
{
	// Fields
	private const int Result = -2146233085;

	// Methods

	// RVA: 0x2127770 Offset: 0x2126970 VA: 0x182127770
	public void .ctor() { }

	// RVA: 0x2127750 Offset: 0x2126950 VA: 0x182127750
	public void .ctor(string message) { }

	// RVA: 0x2127730 Offset: 0x2126930 VA: 0x182127730
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
[Flags]
public enum NotifyFilters // TypeDefIndex: 5604
{
	// Fields
	public int value__; // 0x0
	public const NotifyFilters Attributes = 4;
	public const NotifyFilters CreationTime = 64;
	public const NotifyFilters DirectoryName = 2;
	public const NotifyFilters FileName = 1;
	public const NotifyFilters LastAccess = 32;
	public const NotifyFilters LastWrite = 16;
	public const NotifyFilters Security = 256;
	public const NotifyFilters Size = 8;
}

// Namespace: System.IO
internal class NullFileWatcher : IFileWatcher // TypeDefIndex: 5605
{
	// Fields
	private static IFileWatcher instance; // 0x0

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public void StartDispatching(object handle) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void StopDispatching(object handle) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose(object handle) { }

	// RVA: 0x212BD40 Offset: 0x212AF40 VA: 0x18212BD40
	public static bool GetInstance(out IFileWatcher watcher) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class SearchPattern2.Op // TypeDefIndex: 5606
{
	// Fields
	public SearchPattern2.OpCode Code; // 0x10
	public string Argument; // 0x18
	public SearchPattern2.Op Next; // 0x20

	// Methods

	// RVA: 0x212BDC0 Offset: 0x212AFC0 VA: 0x18212BDC0
	public void .ctor(SearchPattern2.OpCode code) { }
}

// Namespace: 
private enum SearchPattern2.OpCode // TypeDefIndex: 5607
{
	// Fields
	public int value__; // 0x0
	public const SearchPattern2.OpCode ExactString = 0;
	public const SearchPattern2.OpCode AnyChar = 1;
	public const SearchPattern2.OpCode AnyString = 2;
	public const SearchPattern2.OpCode End = 3;
	public const SearchPattern2.OpCode True = 4;
}

// Namespace: System.IO
internal class SearchPattern2 // TypeDefIndex: 5608
{
	// Fields
	private SearchPattern2.Op ops; // 0x10
	private bool ignore; // 0x18
	private bool hasWildcard; // 0x19
	private string pattern; // 0x20
	internal static readonly char[] WildcardChars; // 0x0
	internal static readonly char[] InvalidChars; // 0x8

	// Properties
	public bool HasWildcard { get; }

	// Methods

	// RVA: 0x2133F60 Offset: 0x2133160 VA: 0x182133F60
	public void .ctor(string pattern) { }

	// RVA: 0x2133F10 Offset: 0x2133110 VA: 0x182133F10
	public void .ctor(string pattern, bool ignore) { }

	// RVA: 0x2133AC0 Offset: 0x2132CC0 VA: 0x182133AC0
	public bool IsMatch(string text, bool ignorecase) { }

	// RVA: 0x2133AB0 Offset: 0x2132CB0 VA: 0x182133AB0
	public bool IsMatch(string text) { }

	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40
	public bool get_HasWildcard() { }

	// RVA: 0x21337B0 Offset: 0x21329B0 VA: 0x1821337B0
	private void Compile(string pattern) { }

	// RVA: 0x2133CA0 Offset: 0x2132EA0 VA: 0x182133CA0
	private bool Match(SearchPattern2.Op op, string text, int ptr) { }

	// RVA: 0x2133DF0 Offset: 0x2132FF0 VA: 0x182133DF0
	private static void .cctor() { }
}

// Namespace: System.IO
[Flags]
public enum WatcherChangeTypes // TypeDefIndex: 5609
{
	// Fields
	public int value__; // 0x0
	public const WatcherChangeTypes All = 15;
	public const WatcherChangeTypes Changed = 4;
	public const WatcherChangeTypes Created = 1;
	public const WatcherChangeTypes Deleted = 2;
	public const WatcherChangeTypes Renamed = 8;
}

// Namespace: System.IO.Ports
internal static class InternalResources // TypeDefIndex: 5610
{
	// Methods

	// RVA: 0x2127070 Offset: 0x2126270 VA: 0x182127070
	internal static void EndOfFile() { }

	// RVA: 0x2127200 Offset: 0x2126400 VA: 0x182127200
	internal static string GetMessage(int errorCode) { }

	// RVA: 0x2127190 Offset: 0x2126390 VA: 0x182127190
	internal static void FileNotOpen() { }

	// RVA: 0x21276D0 Offset: 0x21268D0 VA: 0x1821276D0
	internal static void WrongAsyncResult() { }

	// RVA: 0x21270D0 Offset: 0x21262D0 VA: 0x1821270D0
	internal static void EndReadCalledTwice() { }

	// RVA: 0x2127130 Offset: 0x2126330 VA: 0x182127130
	internal static void EndWriteCalledTwice() { }

	// RVA: 0x21272D0 Offset: 0x21264D0 VA: 0x1821272D0
	internal static void WinIOError(int errorCode, string str) { }

	// RVA: 0x1597170 Offset: 0x1596370 VA: 0x181597170
	internal static int MakeHRFromErrorCode(int errorCode) { }
}

// Namespace: System.IO.Compression
public enum CompressionLevel // TypeDefIndex: 5611
{
	// Fields
	public int value__; // 0x0
	public const CompressionLevel Optimal = 0;
	public const CompressionLevel Fastest = 1;
	public const CompressionLevel NoCompression = 2;
}

// Namespace: System.IO.Compression
public enum CompressionMode // TypeDefIndex: 5612
{
	// Fields
	public int value__; // 0x0
	public const CompressionMode Decompress = 0;
	public const CompressionMode Compress = 1;
}

// Namespace: System.IO.Compression
public class GZipStream : Stream // TypeDefIndex: 5613
{
	// Fields
	private DeflateStream _deflateStream; // 0x28

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public Stream BaseStream { get; }

	// Methods

	// RVA: 0x21252D0 Offset: 0x21244D0 VA: 0x1821252D0
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x21254F0 Offset: 0x21246F0 VA: 0x1821254F0
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x2125380 Offset: 0x2124580 VA: 0x182125380
	public void .ctor(Stream stream, CompressionLevel compressionLevel) { }

	// RVA: 0x2125430 Offset: 0x2124630 VA: 0x182125430
	public void .ctor(Stream stream, CompressionLevel compressionLevel, bool leaveOpen) { }

	// RVA: 0x21255C0 Offset: 0x21247C0 VA: 0x1821255C0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2125600 Offset: 0x2124800 VA: 0x182125600 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x21255E0 Offset: 0x21247E0 VA: 0x1821255E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2125620 Offset: 0x2124820 VA: 0x182125620 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2125670 Offset: 0x2124870 VA: 0x182125670 Slot: 12
	public override long get_Position() { }

	// RVA: 0x21256C0 Offset: 0x21248C0 VA: 0x1821256C0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2124B50 Offset: 0x2123D50 VA: 0x182124B50 Slot: 22
	public override void Flush() { }

	// RVA: 0x2124F10 Offset: 0x2124110 VA: 0x182124F10 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2124F60 Offset: 0x2124160 VA: 0x182124F60 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x2124CC0 Offset: 0x2123EC0 VA: 0x182124CC0 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x2124860 Offset: 0x2123A60 VA: 0x182124860 Slot: 24
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x2124AE0 Offset: 0x2123CE0 VA: 0x182124AE0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2124CF0 Offset: 0x2123EF0 VA: 0x182124CF0 Slot: 34
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x2124D30 Offset: 0x2123F30 VA: 0x182124D30 Slot: 35
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x2124910 Offset: 0x2123B10 VA: 0x182124910 Slot: 28
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x15C9D80 Offset: 0x15C8F80 VA: 0x1815C9D80 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2125150 Offset: 0x2124350 VA: 0x182125150 Slot: 37
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x2125190 Offset: 0x2124390 VA: 0x182125190 Slot: 38
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x2124A20 Offset: 0x2123C20 VA: 0x182124A20 Slot: 19
	public override void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x2124A50 Offset: 0x2123C50 VA: 0x182124A50 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21255B0 Offset: 0x21247B0 VA: 0x1821255B0
	public Stream get_BaseStream() { }

	// RVA: 0x2124B80 Offset: 0x2123D80 VA: 0x182124B80 Slot: 26
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2124BC0 Offset: 0x2123DC0 VA: 0x182124BC0 Slot: 27
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2125010 Offset: 0x2124210 VA: 0x182125010 Slot: 30
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2125050 Offset: 0x2124250 VA: 0x182125050 Slot: 31
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2124B20 Offset: 0x2123D20 VA: 0x182124B20 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x21249E0 Offset: 0x2123BE0 VA: 0x1821249E0 Slot: 18
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x21249C0 Offset: 0x2123BC0 VA: 0x1821249C0
	private void CheckDeflateStream() { }

	// RVA: 0x2124FB0 Offset: 0x21241B0 VA: 0x182124FB0
	private static void ThrowStreamClosedException() { }
}

// Namespace: 
private sealed class DeflateStream.ReadMethod : MulticastDelegate // TypeDefIndex: 5614
{
	// Methods

	// RVA: 0x1768F40 Offset: 0x1768140 VA: 0x181768F40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual int Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x212C0A0 Offset: 0x212B2A0 VA: 0x18212C0A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class DeflateStream.WriteMethod : MulticastDelegate // TypeDefIndex: 5615
{
	// Methods

	// RVA: 0x1769F10 Offset: 0x1769110 VA: 0x181769F10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x2135BB0 Offset: 0x2134DB0 VA: 0x182135BB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.IO.Compression
public class DeflateStream : Stream // TypeDefIndex: 5616
{
	// Fields
	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private bool leaveOpen; // 0x34
	private bool disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	// Properties
	public Stream BaseStream { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x211F580 Offset: 0x211E780 VA: 0x18211F580
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x211F5C0 Offset: 0x211E7C0 VA: 0x18211F5C0
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x211F8C0 Offset: 0x211EAC0 VA: 0x18211F8C0
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x211F5E0 Offset: 0x211E7E0 VA: 0x18211F5E0
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x211F770 Offset: 0x211E970 VA: 0x18211F770
	public void .ctor(Stream stream, CompressionLevel compressionLevel) { }

	// RVA: 0x211F5A0 Offset: 0x211E7A0 VA: 0x18211F5A0
	public void .ctor(Stream stream, CompressionLevel compressionLevel, bool leaveOpen) { }

	// RVA: 0x211F560 Offset: 0x211E760 VA: 0x18211F560
	internal void .ctor(Stream stream, CompressionLevel compressionLevel, bool leaveOpen, int windowsBits) { }

	// RVA: 0x211F790 Offset: 0x211E990 VA: 0x18211F790
	internal void .ctor(Stream stream, CompressionLevel compressionLevel, bool leaveOpen, bool gzip) { }

	// RVA: 0x173CC70 Offset: 0x173BE70 VA: 0x18173CC70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x211E4E0 Offset: 0x211D6E0 VA: 0x18211E4E0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x211EBE0 Offset: 0x211DDE0 VA: 0x18211EBE0
	private int ReadInternal(byte[] array, int offset, int count) { }

	// RVA: 0x211EA90 Offset: 0x211DC90 VA: 0x18211EA90
	internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken) { }

	// RVA: 0x211EAD0 Offset: 0x211DCD0 VA: 0x18211EAD0
	internal int ReadCore(Span<byte> destination) { }

	// RVA: 0x211ECF0 Offset: 0x211DEF0 VA: 0x18211ECF0 Slot: 34
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x211F150 Offset: 0x211E350 VA: 0x18211F150
	private void WriteInternal(byte[] array, int offset, int count) { }

	// RVA: 0x211F090 Offset: 0x211E290 VA: 0x18211F090
	internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken) { }

	// RVA: 0x211F0D0 Offset: 0x211E2D0 VA: 0x18211F0D0
	internal void WriteCore(ReadOnlySpan<byte> source) { }

	// RVA: 0x211F250 Offset: 0x211E450 VA: 0x18211F250 Slot: 37
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x211E950 Offset: 0x211DB50 VA: 0x18211E950 Slot: 22
	public override void Flush() { }

	// RVA: 0x211DDC0 Offset: 0x211CFC0 VA: 0x18211DDC0 Slot: 24
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x211E150 Offset: 0x211D350 VA: 0x18211E150 Slot: 28
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x211E5A0 Offset: 0x211D7A0 VA: 0x18211E5A0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x211E780 Offset: 0x211D980 VA: 0x18211E780 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x211F010 Offset: 0x211E210 VA: 0x18211F010 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x211F050 Offset: 0x211E250 VA: 0x18211F050 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Stream get_BaseStream() { }

	// RVA: 0x211F8E0 Offset: 0x211EAE0 VA: 0x18211F8E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x211F920 Offset: 0x211EB20 VA: 0x18211F920 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x211F960 Offset: 0x211EB60 VA: 0x18211F960 Slot: 11
	public override long get_Length() { }

	// RVA: 0x211F9A0 Offset: 0x211EBA0 VA: 0x18211F9A0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x211F9E0 Offset: 0x211EBE0 VA: 0x18211F9E0 Slot: 13
	public override void set_Position(long value) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
private sealed class DeflateStreamNative.UnmanagedReadOrWrite : MulticastDelegate // TypeDefIndex: 5617
{
	// Methods

	// RVA: 0x4585F0 Offset: 0x4577F0 VA: 0x1804585F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x21359F0 Offset: 0x2134BF0 VA: 0x1821359F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr buffer, int length, IntPtr data, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class DeflateStreamNative.SafeDeflateStreamHandle : SafeHandle // TypeDefIndex: 5618
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x20BA030 Offset: 0x20B9230 VA: 0x1820BA030 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x15949D0 Offset: 0x1593BD0 VA: 0x1815949D0
	private void .ctor() { }

	// RVA: 0x20B3380 Offset: 0x20B2580 VA: 0x1820B3380
	internal void .ctor(IntPtr handle) { }

	// RVA: 0x2133790 Offset: 0x2132990 VA: 0x182133790 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: System.IO.Compression
internal class DeflateStreamNative // TypeDefIndex: 5619
{
	// Fields
	private const int BufferSize = 4096;
	private DeflateStreamNative.UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private DeflateStreamNative.SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x30
	private byte[] io_buffer; // 0x38
	private Exception last_error; // 0x40

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x211D240 Offset: 0x211C440 VA: 0x18211D240
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x211D570 Offset: 0x211C770 VA: 0x18211D570 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x211D470 Offset: 0x211C670 VA: 0x18211D470
	public void Dispose(bool disposing) { }

	// RVA: 0x211D5D0 Offset: 0x211C7D0 VA: 0x18211D5D0
	public void Flush() { }

	// RVA: 0x211D6F0 Offset: 0x211C8F0 VA: 0x18211D6F0
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x211DC80 Offset: 0x211CE80 VA: 0x18211DC80
	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
	// RVA: 0x211D830 Offset: 0x211CA30 VA: 0x18211D830
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x211D900 Offset: 0x211CB00 VA: 0x18211D900
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
	// RVA: 0x211DBB0 Offset: 0x211CDB0 VA: 0x18211DBB0
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x211DA50 Offset: 0x211CC50 VA: 0x18211DA50
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x211D050 Offset: 0x211C250 VA: 0x18211D050
	private void CheckResult(int result, string where) { }

	// RVA: 0x211D1B0 Offset: 0x211C3B0 VA: 0x18211D1B0
	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x211D1A0 Offset: 0x211C3A0 VA: 0x18211D1A0
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x211D680 Offset: 0x211C880 VA: 0x18211D680
	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	// RVA: 0x211D7B0 Offset: 0x211C9B0 VA: 0x18211D7B0
	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x211DD40 Offset: 0x211CF40 VA: 0x18211DD40
	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }
}

// Namespace: System.IO.Compression
internal class ZLibNative // TypeDefIndex: 5620
{
	// Fields
	public const int GZip_DefaultWindowBits = 31;

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[DefaultMember("Item")]
private sealed class FileSystemWatcher.NormalizedFilterCollection.ImmutableStringList : IList<string>, ICollection<string>, IEnumerable<string>, IEnumerable // TypeDefIndex: 5621
{
	// Fields
	public string[] Items; // 0x10

	// Properties
	public string Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x2126F00 Offset: 0x2126100 VA: 0x182126F00 Slot: 4
	public string get_Item(int index) { }

	// RVA: 0x2126F80 Offset: 0x2126180 VA: 0x182126F80 Slot: 5
	public void set_Item(int index, string value) { }

	// RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20 Slot: 9
	public int get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x2126780 Offset: 0x2125980 VA: 0x182126780 Slot: 11
	public void Add(string item) { }

	// RVA: 0x21267C0 Offset: 0x21259C0 VA: 0x1821267C0 Slot: 12
	public void Clear() { }

	// RVA: 0x2126800 Offset: 0x2125A00 VA: 0x182126800 Slot: 13
	public bool Contains(string item) { }

	// RVA: 0x1460D20 Offset: 0x145FF20 VA: 0x181460D20 Slot: 14
	public void CopyTo(string[] array, int arrayIndex) { }

	// RVA: 0x2126850 Offset: 0x2125A50 VA: 0x182126850 Slot: 16
	public IEnumerator<string> GetEnumerator() { }

	// RVA: 0x21268A0 Offset: 0x2125AA0 VA: 0x1821268A0 Slot: 6
	public int IndexOf(string item) { }

	// RVA: 0x21268F0 Offset: 0x2125AF0 VA: 0x1821268F0 Slot: 7
	public void Insert(int index, string item) { }

	// RVA: 0x2126E70 Offset: 0x2126070 VA: 0x182126E70 Slot: 15
	public bool Remove(string item) { }

	// RVA: 0x2126BC0 Offset: 0x2125DC0 VA: 0x182126BC0 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x2126850 Offset: 0x2125A50 VA: 0x182126850 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2126EB0 Offset: 0x21260B0 VA: 0x182126EB0
	public void .ctor() { }
}

// Namespace: 
private sealed class FileSystemWatcher.NormalizedFilterCollection : Collection<string> // TypeDefIndex: 5622
{
	// Methods

	// RVA: 0x212BCA0 Offset: 0x212AEA0 VA: 0x18212BCA0
	internal void .ctor() { }

	// RVA: 0x212BB40 Offset: 0x212AD40 VA: 0x18212BB40 Slot: 36
	protected override void InsertItem(int index, string item) { }

	// RVA: 0x212BBF0 Offset: 0x212ADF0 VA: 0x18212BBF0 Slot: 38
	protected override void SetItem(int index, string item) { }

	// RVA: 0x212BAC0 Offset: 0x212ACC0 VA: 0x18212BAC0
	internal string[] GetFilters() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FileSystemWatcher.<>c__DisplayClass73_0 // TypeDefIndex: 5623
{
	// Fields
	public WatcherChangeTypes changeType; // 0x10
	public TaskCompletionSource<WaitForChangedResult> tcs; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21357A0 Offset: 0x21349A0 VA: 0x1821357A0
	internal void <WaitForChanged>b__0(object s, FileSystemEventArgs e) { }

	// RVA: 0x2135890 Offset: 0x2134A90 VA: 0x182135890
	internal void <WaitForChanged>b__1(object s, RenamedEventArgs e) { }
}

// Namespace: System.IO.CoreFX
public class FileSystemWatcher : Component, ISupportInitialize // TypeDefIndex: 5624
{
	// Fields
	private readonly FileSystemWatcher.NormalizedFilterCollection _filters; // 0x28
	private string _directory; // 0x30
	private const NotifyFilters c_defaultNotifyFilters = 19;
	private NotifyFilters _notifyFilters; // 0x38
	private bool _includeSubdirectories; // 0x3C
	private bool _enabled; // 0x3D
	private bool _initializing; // 0x3E
	private uint _internalBufferSize; // 0x40
	private bool _disposed; // 0x44
	private FileSystemEventHandler _onChangedHandler; // 0x48
	private FileSystemEventHandler _onCreatedHandler; // 0x50
	private FileSystemEventHandler _onDeletedHandler; // 0x58
	private RenamedEventHandler _onRenamedHandler; // 0x60
	private ErrorEventHandler _onErrorHandler; // 0x68
	private static readonly char[] s_wildcards; // 0x0
	private const int c_notifyFiltersValidMask = 383;
	[CompilerGenerated]
	private ISynchronizeInvoke <SynchronizingObject>k__BackingField; // 0x70

	// Properties
	public NotifyFilters NotifyFilter { get; set; }
	public Collection<string> Filters { get; }
	public bool EnableRaisingEvents { get; set; }
	public string Filter { get; set; }
	public bool IncludeSubdirectories { get; set; }
	public int InternalBufferSize { get; set; }
	public string Path { get; set; }
	public override ISite Site { get; set; }
	public ISynchronizeInvoke SynchronizingObject { get; set; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void FinalizeDispose() { }

	// RVA: 0x2121B30 Offset: 0x2120D30 VA: 0x182121B30
	private void StartRaisingEvents() { }

	// RVA: 0x2121BE0 Offset: 0x2120DE0 VA: 0x182121BE0
	private void StopRaisingEvents() { }

	// RVA: 0x2122A30 Offset: 0x2121C30 VA: 0x182122A30
	public void .ctor() { }

	// RVA: 0x2122790 Offset: 0x2121990 VA: 0x182122790
	public void .ctor(string path) { }

	// RVA: 0x21228B0 Offset: 0x2121AB0 VA: 0x1821228B0
	public void .ctor(string path, string filter) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public NotifyFilters get_NotifyFilter() { }

	// RVA: 0x2124130 Offset: 0x2123330 VA: 0x182124130
	public void set_NotifyFilter(NotifyFilters value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Collection<string> get_Filters() { }

	// RVA: 0x2123480 Offset: 0x2122680 VA: 0x182123480
	public bool get_EnableRaisingEvents() { }

	// RVA: 0x2123D70 Offset: 0x2122F70 VA: 0x182123D70
	public void set_EnableRaisingEvents(bool value) { }

	// RVA: 0x2123490 Offset: 0x2122690 VA: 0x182123490
	public string get_Filter() { }

	// RVA: 0x2123E70 Offset: 0x2123070 VA: 0x182123E70
	public void set_Filter(string value) { }

	// RVA: 0x691760 Offset: 0x690960 VA: 0x180691760
	public bool get_IncludeSubdirectories() { }

	// RVA: 0x2124020 Offset: 0x2123220 VA: 0x182124020
	public void set_IncludeSubdirectories(bool value) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public int get_InternalBufferSize() { }

	// RVA: 0x21240E0 Offset: 0x21232E0 VA: 0x1821240E0
	public void set_InternalBufferSize(int value) { }

	// RVA: 0x211FD10 Offset: 0x211EF10 VA: 0x18211FD10
	private byte[] AllocateBuffer() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Path() { }

	// RVA: 0x2124500 Offset: 0x2123700 VA: 0x182124500
	public void set_Path(string value) { }

	// RVA: 0x2122EA0 Offset: 0x21220A0 VA: 0x182122EA0
	public void add_Changed(FileSystemEventHandler value) { }

	// RVA: 0x21236E0 Offset: 0x21228E0 VA: 0x1821236E0
	public void remove_Changed(FileSystemEventHandler value) { }

	// RVA: 0x2122FF0 Offset: 0x21221F0 VA: 0x182122FF0
	public void add_Created(FileSystemEventHandler value) { }

	// RVA: 0x2123830 Offset: 0x2122A30 VA: 0x182123830
	public void remove_Created(FileSystemEventHandler value) { }

	// RVA: 0x2123090 Offset: 0x2122290 VA: 0x182123090
	public void add_Deleted(FileSystemEventHandler value) { }

	// RVA: 0x2123980 Offset: 0x2122B80 VA: 0x182123980
	public void remove_Deleted(FileSystemEventHandler value) { }

	// RVA: 0x21231E0 Offset: 0x21223E0 VA: 0x1821231E0
	public void add_Error(ErrorEventHandler value) { }

	// RVA: 0x2123AD0 Offset: 0x2122CD0 VA: 0x182123AD0
	public void remove_Error(ErrorEventHandler value) { }

	// RVA: 0x21233E0 Offset: 0x21225E0 VA: 0x1821233E0
	public void add_Renamed(RenamedEventHandler value) { }

	// RVA: 0x2123CD0 Offset: 0x2122ED0 VA: 0x182123CD0
	public void remove_Renamed(RenamedEventHandler value) { }

	// RVA: 0x2120470 Offset: 0x211F670 VA: 0x182120470 Slot: 14
	protected override void Dispose(bool disposing) { }

	// RVA: 0x211FE00 Offset: 0x211F000 VA: 0x18211FE00
	private static void CheckPathValidity(string path) { }

	// RVA: 0x2120AB0 Offset: 0x211FCB0 VA: 0x182120AB0
	private bool MatchPattern(ReadOnlySpan<char> relativePath) { }

	// RVA: 0x2121030 Offset: 0x2120230 VA: 0x182121030
	private void NotifyInternalBufferOverflowEvent() { }

	// RVA: 0x2121140 Offset: 0x2120340 VA: 0x182121140
	private void NotifyRenameEventArgs(WatcherChangeTypes action, ReadOnlySpan<char> name, ReadOnlySpan<char> oldName) { }

	// RVA: 0x2120660 Offset: 0x211F860 VA: 0x182120660
	private FileSystemEventHandler GetHandler(WatcherChangeTypes changeType) { }

	// RVA: 0x2120D50 Offset: 0x211FF50 VA: 0x182120D50
	private void NotifyFileSystemEventArgs(WatcherChangeTypes changeType, ReadOnlySpan<char> name) { }

	// RVA: 0x2120EE0 Offset: 0x21200E0 VA: 0x182120EE0
	private void NotifyFileSystemEventArgs(WatcherChangeTypes changeType, string name) { }

	// RVA: 0x21212E0 Offset: 0x21204E0 VA: 0x1821212E0
	protected void OnChanged(FileSystemEventArgs e) { }

	// RVA: 0x2121320 Offset: 0x2120520 VA: 0x182121320
	protected void OnCreated(FileSystemEventArgs e) { }

	// RVA: 0x2121360 Offset: 0x2120560 VA: 0x182121360
	protected void OnDeleted(FileSystemEventArgs e) { }

	// RVA: 0x2120940 Offset: 0x211FB40 VA: 0x182120940
	private void InvokeOn(FileSystemEventArgs e, FileSystemEventHandler handler) { }

	// RVA: 0x21213A0 Offset: 0x21205A0 VA: 0x1821213A0
	protected void OnError(ErrorEventArgs e) { }

	// RVA: 0x2121530 Offset: 0x2120730 VA: 0x182121530
	protected void OnRenamed(RenamedEventArgs e) { }

	// RVA: 0x2122670 Offset: 0x2121870 VA: 0x182122670
	public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType) { }

	// RVA: 0x2121CD0 Offset: 0x2120ED0 VA: 0x182121CD0
	public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout) { }

	// RVA: 0x21219B0 Offset: 0x2120BB0 VA: 0x1821219B0
	private void Restart() { }

	// RVA: 0x2121AA0 Offset: 0x2120CA0 VA: 0x182121AA0
	private void StartRaisingEventsIfNotDisposed() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 12
	public override ISite get_Site() { }

	// RVA: 0x2124700 Offset: 0x2123900 VA: 0x182124700 Slot: 13
	public override void set_Site(ISite value) { }

	[CompilerGenerated]
	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public ISynchronizeInvoke get_SynchronizingObject() { }

	[CompilerGenerated]
	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_SynchronizingObject(ISynchronizeInvoke value) { }

	// RVA: 0x211FDF0 Offset: 0x211EFF0 VA: 0x18211FDF0 Slot: 16
	public void BeginInit() { }

	// RVA: 0x21205B0 Offset: 0x211F7B0 VA: 0x1821205B0 Slot: 17
	public void EndInit() { }

	// RVA: 0x2120AA0 Offset: 0x211FCA0 VA: 0x182120AA0
	private bool IsSuspended() { }

	// RVA: 0x21226B0 Offset: 0x21218B0 VA: 0x1821226B0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class SecPkgContext_ConnectionInfo // TypeDefIndex: 5625
{
	// Fields
	public readonly int Protocol; // 0x10
	public readonly int DataCipherAlg; // 0x14
	public readonly int DataKeySize; // 0x18
	public readonly int DataHashAlg; // 0x1C
	public readonly int DataHashKeySize; // 0x20
	public readonly int KeyExchangeAlg; // 0x24
	public readonly int KeyExchKeySize; // 0x28

	// Methods

	// RVA: 0x2133FA0 Offset: 0x21331A0 VA: 0x182133FA0
	internal void .ctor(byte[] nativeBuffer) { }
}

// Namespace: System.Net
internal static class GlobalSSPI // TypeDefIndex: 5626
{
	// Fields
	internal static readonly SSPIInterface SSPIAuth; // 0x0
	internal static readonly SSPIInterface SSPISecureChannel; // 0x8

	// Methods

	// RVA: 0x2125710 Offset: 0x2124910 VA: 0x182125710
	private static void .cctor() { }
}

// Namespace: System.Net
internal class NegotiationInfoClass // TypeDefIndex: 5627
{
	// Fields
	internal string AuthenticationPackage; // 0x10
	internal const string NTLM = "NTLM";
	internal const string Kerberos = "Kerberos";
	internal const string Negotiate = "Negotiate";
	internal const string Basic = "Basic";

	// Methods

	// RVA: 0x2127820 Offset: 0x2126A20 VA: 0x182127820
	internal void .ctor(SafeHandle safeHandle, int negotiationState) { }
}

// Namespace: System.Net
internal class SSPIAuthType : SSPIInterface // TypeDefIndex: 5628
{
	// Fields
	private static SecurityPackageInfoClass[] s_securityPackages; // 0x0

	// Properties
	public SecurityPackageInfoClass[] SecurityPackages { get; set; }

	// Methods

	// RVA: 0x212DD10 Offset: 0x212CF10 VA: 0x18212DD10 Slot: 4
	public SecurityPackageInfoClass[] get_SecurityPackages() { }

	// RVA: 0x212DD60 Offset: 0x212CF60 VA: 0x18212DD60 Slot: 5
	public void set_SecurityPackages(SecurityPackageInfoClass[] value) { }

	// RVA: 0x212D570 Offset: 0x212C770 VA: 0x18212D570 Slot: 6
	public int EnumerateSecurityPackages(out int pkgnum, out SafeFreeContextBuffer pkgArray) { }

	// RVA: 0x212D170 Offset: 0x212C370 VA: 0x18212D170 Slot: 7
	public int AcquireCredentialsHandle(string moduleName, Interop.SspiCli.CredentialUse usage, ref Interop.SspiCli.SEC_WINNT_AUTH_IDENTITY_W authdata, out SafeFreeCredentials outCredential) { }

	// RVA: 0x212D1A0 Offset: 0x212C3A0 VA: 0x18212D1A0 Slot: 8
	public int AcquireCredentialsHandle(string moduleName, Interop.SspiCli.CredentialUse usage, ref SafeSspiAuthDataHandle authdata, out SafeFreeCredentials outCredential) { }

	// RVA: 0x212D1D0 Offset: 0x212C3D0 VA: 0x18212D1D0 Slot: 9
	public int AcquireDefaultCredential(string moduleName, Interop.SspiCli.CredentialUse usage, out SafeFreeCredentials outCredential) { }

	// RVA: 0x212D140 Offset: 0x212C340 VA: 0x18212D140 Slot: 10
	public int AcquireCredentialsHandle(string moduleName, Interop.SspiCli.CredentialUse usage, ref Interop.SspiCli.SCHANNEL_CRED authdata, out SafeFreeCredentials outCredential) { }

	// RVA: 0x212D0B0 Offset: 0x212C2B0 VA: 0x18212D0B0 Slot: 11
	public int AcceptSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer inputBuffer, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x212D010 Offset: 0x212C210 VA: 0x18212D010 Slot: 12
	public int AcceptSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer[] inputBuffers, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x212D7E0 Offset: 0x212C9E0 VA: 0x18212D7E0 Slot: 13
	public int InitializeSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x212D730 Offset: 0x212C930 VA: 0x18212D730 Slot: 14
	public int InitializeSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer[] inputBuffers, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x212D490 Offset: 0x212C690 VA: 0x18212D490 Slot: 15
	public int EncryptMessage(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber) { }

	// RVA: 0x212D290 Offset: 0x212C490 VA: 0x18212D290 Slot: 16
	public int DecryptMessage(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber) { }

	// RVA: 0x212D890 Offset: 0x212CA90 VA: 0x18212D890 Slot: 17
	public int MakeSignature(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber) { }

	// RVA: 0x212DC30 Offset: 0x212CE30 VA: 0x18212DC30 Slot: 18
	public int VerifySignature(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber) { }

	// RVA: 0x212DB80 Offset: 0x212CD80 VA: 0x18212DB80 Slot: 19
	public int QueryContextChannelBinding(SafeDeleteContext context, Interop.SspiCli.ContextAttribute attribute, out SafeFreeContextBufferChannelBinding binding) { }

	// RVA: 0x212D970 Offset: 0x212CB70 VA: 0x18212D970 Slot: 20
	public int QueryContextAttributes(SafeDeleteContext context, Interop.SspiCli.ContextAttribute attribute, byte[] buffer, Type handleType, out SafeHandle refHandle) { }

	// RVA: 0x212DBF0 Offset: 0x212CDF0 VA: 0x18212DBF0 Slot: 21
	public int SetContextAttributes(SafeDeleteContext context, Interop.SspiCli.ContextAttribute attribute, byte[] buffer) { }

	// RVA: 0x212DBD0 Offset: 0x212CDD0 VA: 0x18212DBD0 Slot: 22
	public int QuerySecurityContextToken(SafeDeleteContext phContext, out SecurityContextTokenHandle phToken) { }

	// RVA: 0x212D230 Offset: 0x212C430 VA: 0x18212D230 Slot: 23
	public int CompleteAuthToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers) { }

	// RVA: 0x212D670 Offset: 0x212C870 VA: 0x18212D670
	private static int GetSecurityContextToken(SafeDeleteContext phContext, out SecurityContextTokenHandle safeHandle) { }

	// RVA: 0x212D1F0 Offset: 0x212C3F0 VA: 0x18212D1F0 Slot: 24
	public int ApplyControlToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
internal interface SSPIInterface // TypeDefIndex: 5629
{
	// Properties
	public abstract SecurityPackageInfoClass[] SecurityPackages { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SecurityPackageInfoClass[] get_SecurityPackages();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_SecurityPackages(SecurityPackageInfoClass[] value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int EnumerateSecurityPackages(out int pkgnum, out SafeFreeContextBuffer pkgArray);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int AcquireCredentialsHandle(string moduleName, Interop.SspiCli.CredentialUse usage, ref Interop.SspiCli.SEC_WINNT_AUTH_IDENTITY_W authdata, out SafeFreeCredentials outCredential);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int AcquireCredentialsHandle(string moduleName, Interop.SspiCli.CredentialUse usage, ref SafeSspiAuthDataHandle authdata, out SafeFreeCredentials outCredential);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int AcquireDefaultCredential(string moduleName, Interop.SspiCli.CredentialUse usage, out SafeFreeCredentials outCredential);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int AcquireCredentialsHandle(string moduleName, Interop.SspiCli.CredentialUse usage, ref Interop.SspiCli.SCHANNEL_CRED authdata, out SafeFreeCredentials outCredential);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int AcceptSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer inputBuffer, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int AcceptSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer[] inputBuffers, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int InitializeSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int InitializeSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer[] inputBuffers, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int EncryptMessage(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int DecryptMessage(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int MakeSignature(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int VerifySignature(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int QueryContextChannelBinding(SafeDeleteContext phContext, Interop.SspiCli.ContextAttribute attribute, out SafeFreeContextBufferChannelBinding refHandle);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int QueryContextAttributes(SafeDeleteContext phContext, Interop.SspiCli.ContextAttribute attribute, byte[] buffer, Type handleType, out SafeHandle refHandle);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int SetContextAttributes(SafeDeleteContext phContext, Interop.SspiCli.ContextAttribute attribute, byte[] buffer);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int QuerySecurityContextToken(SafeDeleteContext phContext, out SecurityContextTokenHandle phToken);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int CompleteAuthToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract int ApplyControlToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers);
}

// Namespace: System.Net
internal class SSPISecureChannelType : SSPIInterface // TypeDefIndex: 5630
{
	// Fields
	private static SecurityPackageInfoClass[] s_securityPackages; // 0x0

	// Properties
	public SecurityPackageInfoClass[] SecurityPackages { get; set; }

	// Methods

	// RVA: 0x212E610 Offset: 0x212D810 VA: 0x18212E610 Slot: 4
	public SecurityPackageInfoClass[] get_SecurityPackages() { }

	// RVA: 0x212E660 Offset: 0x212D860 VA: 0x18212E660 Slot: 5
	public void set_SecurityPackages(SecurityPackageInfoClass[] value) { }

	// RVA: 0x212E060 Offset: 0x212D260 VA: 0x18212E060 Slot: 6
	public int EnumerateSecurityPackages(out int pkgnum, out SafeFreeContextBuffer pkgArray) { }

	// RVA: 0x212D170 Offset: 0x212C370 VA: 0x18212D170 Slot: 7
	public int AcquireCredentialsHandle(string moduleName, Interop.SspiCli.CredentialUse usage, ref Interop.SspiCli.SEC_WINNT_AUTH_IDENTITY_W authdata, out SafeFreeCredentials outCredential) { }

	// RVA: 0x212D1A0 Offset: 0x212C3A0 VA: 0x18212D1A0 Slot: 8
	public int AcquireCredentialsHandle(string moduleName, Interop.SspiCli.CredentialUse usage, ref SafeSspiAuthDataHandle authdata, out SafeFreeCredentials outCredential) { }

	// RVA: 0x212D1D0 Offset: 0x212C3D0 VA: 0x18212D1D0 Slot: 9
	public int AcquireDefaultCredential(string moduleName, Interop.SspiCli.CredentialUse usage, out SafeFreeCredentials outCredential) { }

	// RVA: 0x212D140 Offset: 0x212C340 VA: 0x18212D140 Slot: 10
	public int AcquireCredentialsHandle(string moduleName, Interop.SspiCli.CredentialUse usage, ref Interop.SspiCli.SCHANNEL_CRED authdata, out SafeFreeCredentials outCredential) { }

	// RVA: 0x212DDB0 Offset: 0x212CFB0 VA: 0x18212DDB0 Slot: 11
	public int AcceptSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer inputBuffer, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x212DE40 Offset: 0x212D040 VA: 0x18212DE40 Slot: 12
	public int AcceptSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer[] inputBuffers, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x212E210 Offset: 0x212D410 VA: 0x18212E210 Slot: 13
	public int InitializeSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x212E160 Offset: 0x212D360 VA: 0x18212E160 Slot: 14
	public int InitializeSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer[] inputBuffers, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x212D490 Offset: 0x212C690 VA: 0x18212D490 Slot: 15
	public int EncryptMessage(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber) { }

	// RVA: 0x212DF80 Offset: 0x212D180 VA: 0x18212DF80 Slot: 16
	public int DecryptMessage(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber) { }

	// RVA: 0x212E2C0 Offset: 0x212D4C0 VA: 0x18212E2C0 Slot: 17
	public int MakeSignature(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber) { }

	// RVA: 0x212E5D0 Offset: 0x212D7D0 VA: 0x18212E5D0 Slot: 18
	public int VerifySignature(SafeDeleteContext context, ref Interop.SspiCli.SecBufferDesc inputOutput, uint sequenceNumber) { }

	// RVA: 0x212E510 Offset: 0x212D710 VA: 0x18212E510 Slot: 19
	public int QueryContextChannelBinding(SafeDeleteContext phContext, Interop.SspiCli.ContextAttribute attribute, out SafeFreeContextBufferChannelBinding refHandle) { }

	// RVA: 0x212E300 Offset: 0x212D500 VA: 0x18212E300 Slot: 20
	public int QueryContextAttributes(SafeDeleteContext phContext, Interop.SspiCli.ContextAttribute attribute, byte[] buffer, Type handleType, out SafeHandle refHandle) { }

	// RVA: 0x212E5B0 Offset: 0x212D7B0 VA: 0x18212E5B0 Slot: 21
	public int SetContextAttributes(SafeDeleteContext phContext, Interop.SspiCli.ContextAttribute attribute, byte[] buffer) { }

	// RVA: 0x212E570 Offset: 0x212D770 VA: 0x18212E570 Slot: 22
	public int QuerySecurityContextToken(SafeDeleteContext phContext, out SecurityContextTokenHandle phToken) { }

	// RVA: 0x212DF40 Offset: 0x212D140 VA: 0x18212DF40 Slot: 23
	public int CompleteAuthToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers) { }

	// RVA: 0x212DEE0 Offset: 0x212D0E0 VA: 0x18212DEE0 Slot: 24
	public int ApplyControlToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private enum SSPIWrapper.OP // TypeDefIndex: 5631
{
	// Fields
	public int value__; // 0x0
	public const SSPIWrapper.OP Encrypt = 1;
	public const SSPIWrapper.OP Decrypt = 2;
	public const SSPIWrapper.OP MakeSignature = 3;
	public const SSPIWrapper.OP VerifySignature = 4;
}

// Namespace: System.Net
internal static class SSPIWrapper // TypeDefIndex: 5632
{
	// Methods

	// RVA: 0x21309A0 Offset: 0x212FBA0 VA: 0x1821309A0
	internal static SecurityPackageInfoClass[] EnumerateSecurityPackages(SSPIInterface secModule) { }

	// RVA: 0x2131C10 Offset: 0x2130E10 VA: 0x182131C10
	internal static SecurityPackageInfoClass GetVerifyPackageInfo(SSPIInterface secModule, string packageName) { }

	// RVA: 0x2131A00 Offset: 0x2130C00 VA: 0x182131A00
	internal static SecurityPackageInfoClass GetVerifyPackageInfo(SSPIInterface secModule, string packageName, bool throwIfMissing) { }

	// RVA: 0x212F670 Offset: 0x212E870 VA: 0x18212F670
	public static SafeFreeCredentials AcquireDefaultCredential(SSPIInterface secModule, string package, Interop.SspiCli.CredentialUse intent) { }

	// RVA: 0x212EF50 Offset: 0x212E150 VA: 0x18212EF50
	public static SafeFreeCredentials AcquireCredentialsHandle(SSPIInterface secModule, string package, Interop.SspiCli.CredentialUse intent, ref Interop.SspiCli.SEC_WINNT_AUTH_IDENTITY_W authdata) { }

	// RVA: 0x212EC90 Offset: 0x212DE90 VA: 0x18212EC90
	public static SafeFreeCredentials AcquireCredentialsHandle(SSPIInterface secModule, string package, Interop.SspiCli.CredentialUse intent, ref SafeSspiAuthDataHandle authdata) { }

	// RVA: 0x212F280 Offset: 0x212E480 VA: 0x18212F280
	public static SafeFreeCredentials AcquireCredentialsHandle(SSPIInterface secModule, string package, Interop.SspiCli.CredentialUse intent, Interop.SspiCli.SCHANNEL_CRED scc) { }

	// RVA: 0x2131F40 Offset: 0x2131140 VA: 0x182131F40
	internal static int InitializeSecurityContext(SSPIInterface secModule, ref SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness datarep, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x2131C20 Offset: 0x2130E20 VA: 0x182131C20
	internal static int InitializeSecurityContext(SSPIInterface secModule, SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness datarep, SecurityBuffer[] inputBuffers, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x212E6B0 Offset: 0x212D8B0 VA: 0x18212E6B0
	internal static int AcceptSecurityContext(SSPIInterface secModule, ref SafeFreeCredentials credential, ref SafeDeleteContext context, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness datarep, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x212E9A0 Offset: 0x212DBA0 VA: 0x18212E9A0
	internal static int AcceptSecurityContext(SSPIInterface secModule, SafeFreeCredentials credential, ref SafeDeleteContext context, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness datarep, SecurityBuffer[] inputBuffers, SecurityBuffer outputBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x212FB80 Offset: 0x212ED80 VA: 0x18212FB80
	internal static int CompleteAuthToken(SSPIInterface secModule, ref SafeDeleteContext context, SecurityBuffer[] inputBuffers) { }

	// RVA: 0x212FA40 Offset: 0x212EC40 VA: 0x18212FA40
	internal static int ApplyControlToken(SSPIInterface secModule, ref SafeDeleteContext context, SecurityBuffer[] inputBuffers) { }

	// RVA: 0x2133690 Offset: 0x2132890 VA: 0x182133690
	public static int QuerySecurityContextToken(SSPIInterface secModule, SafeDeleteContext context, out SecurityContextTokenHandle token) { }

	// RVA: 0x2130970 Offset: 0x212FB70 VA: 0x182130970
	public static int EncryptMessage(SSPIInterface secModule, SafeDeleteContext context, SecurityBuffer[] input, uint sequenceNumber) { }

	// RVA: 0x212FCC0 Offset: 0x212EEC0 VA: 0x18212FCC0
	public static int DecryptMessage(SSPIInterface secModule, SafeDeleteContext context, SecurityBuffer[] input, uint sequenceNumber) { }

	// RVA: 0x2132260 Offset: 0x2131460 VA: 0x182132260
	internal static int MakeSignature(SSPIInterface secModule, SafeDeleteContext context, SecurityBuffer[] input, uint sequenceNumber) { }

	// RVA: 0x2133760 Offset: 0x2132960 VA: 0x182133760
	public static int VerifySignature(SSPIInterface secModule, SafeDeleteContext context, SecurityBuffer[] input, uint sequenceNumber) { }

	// RVA: 0x212FCF0 Offset: 0x212EEF0 VA: 0x18212FCF0
	private static int EncryptDecryptHelper(SSPIWrapper.OP op, SSPIInterface secModule, SafeDeleteContext context, SecurityBuffer[] input, uint sequenceNumber) { }

	// RVA: 0x21332F0 Offset: 0x21324F0 VA: 0x1821332F0
	public static SafeFreeContextBufferChannelBinding QueryContextChannelBinding(SSPIInterface secModule, SafeDeleteContext securityContext, Interop.SspiCli.ContextAttribute contextAttribute) { }

	// RVA: 0x2132290 Offset: 0x2131490 VA: 0x182132290
	public static object QueryContextAttributes(SSPIInterface secModule, SafeDeleteContext securityContext, Interop.SspiCli.ContextAttribute contextAttribute) { }

	// RVA: 0x21322B0 Offset: 0x21314B0 VA: 0x1821322B0
	public static object QueryContextAttributes(SSPIInterface secModule, SafeDeleteContext securityContext, Interop.SspiCli.ContextAttribute contextAttribute, out int errorCode) { }

	// RVA: 0x2131800 Offset: 0x2130A00 VA: 0x182131800
	public static string ErrorDescription(int errorCode) { }
}

// Namespace: System.Net
internal struct SecPkgContext_Bindings // TypeDefIndex: 5633
{
	// Fields
	internal int BindingsLength; // 0x0
	internal IntPtr Bindings; // 0x8
}

// Namespace: System.Net
internal struct SecPkgContext_NegotiationInfoW // TypeDefIndex: 5634
{
	// Fields
	internal IntPtr PackageInfo; // 0x0
	internal uint NegotiationState; // 0x8
}

// Namespace: System.Net
internal class SecPkgContext_Sizes // TypeDefIndex: 5635
{
	// Fields
	public readonly int cbMaxToken; // 0x10
	public readonly int cbMaxSignature; // 0x14
	public readonly int cbBlockSize; // 0x18
	public readonly int cbSecurityTrailer; // 0x1C
	public static readonly int SizeOf; // 0x0

	// Methods

	// RVA: 0x2134170 Offset: 0x2133370 VA: 0x182134170
	internal void .ctor(byte[] memory) { }

	// RVA: 0x2134100 Offset: 0x2133300 VA: 0x182134100
	private static void .cctor() { }
}

// Namespace: System.Net
internal class SecPkgContext_StreamSizes // TypeDefIndex: 5636
{
	// Fields
	public int cbHeader; // 0x10
	public int cbTrailer; // 0x14
	public int cbMaximumMessage; // 0x18
	public int cBuffers; // 0x1C
	public int cbBlockSize; // 0x20
	public static readonly int SizeOf; // 0x0

	// Methods

	// RVA: 0x2134310 Offset: 0x2133510 VA: 0x182134310
	internal void .ctor(byte[] memory) { }

	// RVA: 0x21342A0 Offset: 0x21334A0 VA: 0x1821342A0
	private static void .cctor() { }
}

// Namespace: System.Net
internal struct SecurityPackageInfo // TypeDefIndex: 5637
{
	// Fields
	internal int Capabilities; // 0x0
	internal short Version; // 0x4
	internal short RPCID; // 0x6
	internal int MaxToken; // 0x8
	internal IntPtr Name; // 0x10
	internal IntPtr Comment; // 0x18
}

// Namespace: System.Net
internal class SecurityPackageInfoClass // TypeDefIndex: 5638
{
	// Fields
	internal int Capabilities; // 0x10
	internal short Version; // 0x14
	internal short RPCID; // 0x16
	internal int MaxToken; // 0x18
	internal string Name; // 0x20
	internal string Comment; // 0x28

	// Methods

	// RVA: 0x21346C0 Offset: 0x21338C0 VA: 0x1821346C0
	internal void .ctor(SafeHandle safeHandle, int index) { }

	// RVA: 0x2134450 Offset: 0x2133650 VA: 0x182134450 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Flags]
private enum ContextAwareResult.StateFlags // TypeDefIndex: 5639
{
	// Fields
	public byte value__; // 0x0
	public const ContextAwareResult.StateFlags None = 0;
	public const ContextAwareResult.StateFlags CaptureIdentity = 1;
	public const ContextAwareResult.StateFlags CaptureContext = 2;
	public const ContextAwareResult.StateFlags ThreadSafeContextCopy = 4;
	public const ContextAwareResult.StateFlags PostBlockStarted = 8;
	public const ContextAwareResult.StateFlags PostBlockFinished = 16;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ContextAwareResult.<>c // TypeDefIndex: 5640
{
	// Fields
	public static readonly ContextAwareResult.<>c <>9; // 0x0
	public static ContextCallback <>9__17_0; // 0x8

	// Methods

	// RVA: 0x2135990 Offset: 0x2134B90 VA: 0x182135990
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2135390 Offset: 0x2134590 VA: 0x182135390
	internal void <Complete>b__17_0(object s) { }
}

// Namespace: System.Net
internal class ContextAwareResult : LazyAsyncResult // TypeDefIndex: 5641
{
	// Fields
	private ExecutionContext _context; // 0x48
	private object _lock; // 0x50
	private ContextAwareResult.StateFlags _flags; // 0x58

	// Properties
	internal ExecutionContext ContextCopy { get; }
	internal virtual EndPoint RemoteEndPoint { get; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void SafeCaptureIdentity() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void CleanupInternal() { }

	// RVA: 0x211A520 Offset: 0x2119720 VA: 0x18211A520
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x211A4C0 Offset: 0x21196C0 VA: 0x18211A4C0
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x211A450 Offset: 0x2119650 VA: 0x18211A450
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x211A540 Offset: 0x2119740 VA: 0x18211A540
	internal ExecutionContext get_ContextCopy() { }

	// RVA: 0x211A380 Offset: 0x2119580 VA: 0x18211A380
	internal object StartPostingAsyncOp() { }

	// RVA: 0x211A2B0 Offset: 0x21194B0 VA: 0x18211A2B0
	internal object StartPostingAsyncOp(bool lockCapture) { }

	// RVA: 0x211A270 Offset: 0x2119470 VA: 0x18211A270
	internal bool FinishPostingAsyncOp() { }

	// RVA: 0x211A160 Offset: 0x2119360 VA: 0x18211A160
	internal bool FinishPostingAsyncOp(ref CallbackClosure closure) { }

	// RVA: 0x2119C40 Offset: 0x2118E40 VA: 0x182119C40 Slot: 9
	protected override void Cleanup() { }

	// RVA: 0x2119790 Offset: 0x2118990 VA: 0x182119790
	private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext) { }

	// RVA: 0x2119E10 Offset: 0x2119010 VA: 0x182119E10 Slot: 8
	protected override void Complete(IntPtr userToken) { }

	// RVA: 0x2119D20 Offset: 0x2118F20 VA: 0x182119D20
	private void CompleteCallback() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	internal virtual EndPoint get_RemoteEndPoint() { }
}

// Namespace: System.Net
internal class CallbackClosure // TypeDefIndex: 5642
{
	// Fields
	private AsyncCallback _savedCallback; // 0x10
	private ExecutionContext _savedContext; // 0x18

	// Properties
	internal AsyncCallback AsyncCallback { get; }
	internal ExecutionContext Context { get; }

	// Methods

	// RVA: 0x2119120 Offset: 0x2118320 VA: 0x182119120
	internal void .ctor(ExecutionContext context, AsyncCallback callback) { }

	// RVA: 0x21190F0 Offset: 0x21182F0 VA: 0x1821190F0
	internal bool IsCompatible(AsyncCallback callback) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal AsyncCallback get_AsyncCallback() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal ExecutionContext get_Context() { }
}

// Namespace: 
[IsReadOnly]
private struct ContextFlagsAdapterPal.ContextFlagMapping // TypeDefIndex: 5643
{
	// Fields
	public readonly Interop.SspiCli.ContextFlags Win32Flag; // 0x0
	public readonly ContextFlagsPal ContextFlag; // 0x4

	// Methods

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void .ctor(Interop.SspiCli.ContextFlags win32Flag, ContextFlagsPal contextFlag) { }
}

// Namespace: System.Net
internal static class ContextFlagsAdapterPal // TypeDefIndex: 5644
{
	// Fields
	private static readonly ContextFlagsAdapterPal.ContextFlagMapping[] s_contextFlagMapping; // 0x0

	// Methods

	// RVA: 0x211A800 Offset: 0x2119A00 VA: 0x18211A800
	internal static ContextFlagsPal GetContextFlagsPalFromInterop(Interop.SspiCli.ContextFlags win32Flags) { }

	// RVA: 0x211A8B0 Offset: 0x2119AB0 VA: 0x18211A8B0
	internal static Interop.SspiCli.ContextFlags GetInteropFromContextFlagsPal(ContextFlagsPal flags) { }

	// RVA: 0x211A960 Offset: 0x2119B60 VA: 0x18211A960
	private static void .cctor() { }
}

// Namespace: System.Net
[Flags]
internal enum ContextFlagsPal // TypeDefIndex: 5645
{
	// Fields
	public int value__; // 0x0
	public const ContextFlagsPal None = 0;
	public const ContextFlagsPal Delegate = 1;
	public const ContextFlagsPal MutualAuth = 2;
	public const ContextFlagsPal ReplayDetect = 4;
	public const ContextFlagsPal SequenceDetect = 8;
	public const ContextFlagsPal Confidentiality = 16;
	public const ContextFlagsPal UseSessionKey = 32;
	public const ContextFlagsPal AllocateMemory = 256;
	public const ContextFlagsPal Connection = 2048;
	public const ContextFlagsPal InitExtendedError = 16384;
	public const ContextFlagsPal AcceptExtendedError = 32768;
	public const ContextFlagsPal InitStream = 32768;
	public const ContextFlagsPal AcceptStream = 65536;
	public const ContextFlagsPal InitIntegrity = 65536;
	public const ContextFlagsPal AcceptIntegrity = 131072;
	public const ContextFlagsPal InitManualCredValidation = 524288;
	public const ContextFlagsPal InitUseSuppliedCreds = 128;
	public const ContextFlagsPal InitIdentify = 131072;
	public const ContextFlagsPal AcceptIdentify = 524288;
	public const ContextFlagsPal ProxyBindings = 67108864;
	public const ContextFlagsPal AllowMissingBindings = 268435456;
	public const ContextFlagsPal UnverifiedTargetName = 536870912;
}

// Namespace: System.Net
internal static class ExceptionCheck // TypeDefIndex: 5646
{
	// Methods

	// RVA: 0x211FA80 Offset: 0x211EC80 VA: 0x18211FA80
	internal static bool IsFatal(Exception exception) { }
}

// Namespace: System.Net
internal static class HttpStatusDescription // TypeDefIndex: 5647
{
	// Methods

	// RVA: 0x21257B0 Offset: 0x21249B0 VA: 0x1821257B0
	internal static string Get(HttpStatusCode code) { }

	// RVA: 0x21257C0 Offset: 0x21249C0 VA: 0x1821257C0
	internal static string Get(int code) { }
}

// Namespace: System.Net
internal static class HttpValidationHelpers // TypeDefIndex: 5648
{
	// Fields
	private static readonly char[] s_httpTrimCharacters; // 0x0

	// Methods

	// RVA: 0x2125FC0 Offset: 0x21251C0 VA: 0x182125FC0
	internal static string CheckBadHeaderNameChars(string name) { }

	// RVA: 0x2126400 Offset: 0x2125600 VA: 0x182126400
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x21265C0 Offset: 0x21257C0 VA: 0x1821265C0
	internal static bool IsValidToken(string token) { }

	// RVA: 0x2126130 Offset: 0x2125330 VA: 0x182126130
	public static string CheckBadHeaderValueChars(string value) { }

	// RVA: 0x2126470 Offset: 0x2125670 VA: 0x182126470
	public static bool IsInvalidMethodOrHeaderString(string stringValue) { }

	// RVA: 0x21266A0 Offset: 0x21258A0 VA: 0x1821266A0
	private static void .cctor() { }
}

// Namespace: System.Net
internal static class IPAddressParserStatics // TypeDefIndex: 5649
{
	// Fields
	public const int IPv4AddressBytes = 4;
	public const int IPv6AddressBytes = 16;
	public const int IPv6AddressShorts = 8;
}

// Namespace: 
public class NetEventSource.Keywords // TypeDefIndex: 5650
{
	// Fields
	public const EventKeywords Default = 1;
	public const EventKeywords Debug = 2;
	public const EventKeywords EnterExit = 4;

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
internal sealed class NetEventSource : EventSource // TypeDefIndex: 5651
{
	// Fields
	public static readonly NetEventSource Log; // 0x0
	private const string MissingMember = "(?)";
	private const string NullInstance = "(null)";
	private const string StaticMethodObject = "(static)";
	private const string NoParameters = "";
	private const int MaxDumpSize = 1024;
	private const int EnterEventId = 1;
	private const int ExitEventId = 2;
	private const int AssociateEventId = 3;
	private const int InfoEventId = 4;
	private const int ErrorEventId = 5;
	private const int CriticalFailureEventId = 6;
	private const int DumpArrayEventId = 7;
	private const int EnumerateSecurityPackagesId = 8;
	private const int SspiPackageNotFoundId = 9;
	private const int AcquireDefaultCredentialId = 10;
	private const int AcquireCredentialsHandleId = 11;
	private const int InitializeSecurityContextId = 12;
	private const int SecurityContextInputBufferId = 13;
	private const int SecurityContextInputBuffersId = 14;
	private const int AcceptSecuritContextId = 15;
	private const int OperationReturnedSomethingId = 16;
	private const int NextAvailableEventId = 17;

	// Properties
	public static bool IsEnabled { get; }

	// Methods

	[NonEvent]
	// RVA: 0x2128FB0 Offset: 0x21281B0 VA: 0x182128FB0
	public static void Enter(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x2128E30 Offset: 0x2128030 VA: 0x182128E30
	public static void Enter(object thisOrContextObject, object arg0, string memberName) { }

	[NonEvent]
	// RVA: 0x2128CA0 Offset: 0x2127EA0 VA: 0x182128CA0
	public static void Enter(object thisOrContextObject, object arg0, object arg1, string memberName) { }

	[NonEvent]
	// RVA: 0x2129140 Offset: 0x2128340 VA: 0x182129140
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName) { }

	[Event(1, Level = 4, Keywords = 4)]
	// RVA: 0x21292F0 Offset: 0x21284F0 VA: 0x1821292F0
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	[NonEvent]
	// RVA: 0x2129970 Offset: 0x2128B70 VA: 0x182129970
	public static void Exit(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x2129B00 Offset: 0x2128D00 VA: 0x182129B00
	public static void Exit(object thisOrContextObject, object arg0, string memberName) { }

	[NonEvent]
	// RVA: 0x2129750 Offset: 0x2128950 VA: 0x182129750
	public static void Exit(object thisOrContextObject, object arg0, object arg1, string memberName) { }

	[Event(2, Level = 4, Keywords = 4)]
	// RVA: 0x21298E0 Offset: 0x2128AE0 VA: 0x1821298E0
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	[NonEvent]
	// RVA: 0x212A870 Offset: 0x2129A70 VA: 0x18212A870
	public static void Info(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x212AA90 Offset: 0x2129C90 VA: 0x18212AA90
	public static void Info(object thisOrContextObject, object message, string memberName) { }

	[Event(4, Level = 4, Keywords = 1)]
	// RVA: 0x212AA00 Offset: 0x2129C00 VA: 0x18212AA00
	private void Info(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x21295F0 Offset: 0x21287F0 VA: 0x1821295F0
	public static void Error(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x2129480 Offset: 0x2128680 VA: 0x182129480
	public static void Error(object thisOrContextObject, object message, string memberName) { }

	[Event(5, Level = 3, Keywords = 1)]
	// RVA: 0x21293F0 Offset: 0x21285F0 VA: 0x1821293F0
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x2129DE0 Offset: 0x2128FE0 VA: 0x182129DE0
	public static void Fail(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x2129C70 Offset: 0x2128E70 VA: 0x182129C70
	public static void Fail(object thisOrContextObject, object message, string memberName) { }

	[Event(6, Level = 1, Keywords = 2)]
	// RVA: 0x2128490 Offset: 0x2127690 VA: 0x182128490
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x2128990 Offset: 0x2127B90 VA: 0x182128990
	public static void DumpBuffer(object thisOrContextObject, byte[] buffer, string memberName) { }

	[NonEvent]
	// RVA: 0x21285B0 Offset: 0x21277B0 VA: 0x1821285B0
	public static void DumpBuffer(object thisOrContextObject, byte[] buffer, int offset, int count, string memberName) { }

	[NonEvent]
	// RVA: 0x2128AB0 Offset: 0x2127CB0 VA: 0x182128AB0
	public static void DumpBuffer(object thisOrContextObject, IntPtr bufferPtr, int count, string memberName) { }

	[Event(7, Level = 5, Keywords = 2)]
	// RVA: 0x2128A20 Offset: 0x2127C20 VA: 0x182128A20
	private void DumpBuffer(string thisOrContextObject, string memberName, byte[] buffer) { }

	[NonEvent]
	// RVA: 0x21280F0 Offset: 0x21272F0 VA: 0x1821280F0
	public static void Associate(object first, object second, string memberName) { }

	[NonEvent]
	// RVA: 0x2128310 Offset: 0x2127510 VA: 0x182128310
	public static void Associate(object thisOrContextObject, object first, object second, string memberName) { }

	[Event(3, Level = 4, Keywords = 1, Message = "[{2}]<-->[{3}]")]
	// RVA: 0x2128270 Offset: 0x2127470 VA: 0x182128270
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	[Conditional("DEBUG_NETEVENTSOURCE_MISUSE")]
	// RVA: 0x2128520 Offset: 0x2127720 VA: 0x182128520
	private static void DebugValidateArg(object arg) { }

	[Conditional("DEBUG_NETEVENTSOURCE_MISUSE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DebugValidateArg(FormattableString arg) { }

	// RVA: 0x212BA60 Offset: 0x212AC60 VA: 0x18212BA60
	public static bool get_IsEnabled() { }

	[NonEvent]
	// RVA: 0x212A780 Offset: 0x2129980 VA: 0x18212A780
	public static string IdOf(object value) { }

	[NonEvent]
	// RVA: 0x212A760 Offset: 0x2129960 VA: 0x18212A760
	public static int GetHashCode(object value) { }

	[NonEvent]
	// RVA: 0x212A2C0 Offset: 0x21294C0 VA: 0x18212A2C0
	public static object Format(object value) { }

	[NonEvent]
	// RVA: 0x2129F40 Offset: 0x2129140 VA: 0x182129F40
	private static string Format(FormattableString s) { }

	[NonEvent]
	// RVA: 0x212B5B0 Offset: 0x212A7B0 VA: 0x18212B5B0
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

	[NonEvent]
	// RVA: 0x212B7B0 Offset: 0x212A9B0 VA: 0x18212B7B0
	private void WriteEvent(int eventId, string arg1, string arg2, byte[] arg3) { }

	[NonEvent]
	// RVA: 0x212AF70 Offset: 0x212A170 VA: 0x18212AF70
	private void WriteEvent(int eventId, string arg1, int arg2, int arg3, int arg4) { }

	[NonEvent]
	// RVA: 0x212B430 Offset: 0x212A630 VA: 0x18212B430
	private void WriteEvent(int eventId, string arg1, int arg2, string arg3) { }

	[NonEvent]
	// RVA: 0x212B2B0 Offset: 0x212A4B0 VA: 0x18212B2B0
	private void WriteEvent(int eventId, string arg1, string arg2, int arg3) { }

	[NonEvent]
	// RVA: 0x212B0D0 Offset: 0x212A2D0 VA: 0x18212B0D0
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, int arg4) { }

	[Event(10, Keywords = 1, Level = 4)]
	// RVA: 0x2127FC0 Offset: 0x21271C0 VA: 0x182127FC0
	public void AcquireDefaultCredential(string packageName, Interop.SspiCli.CredentialUse intent) { }

	[NonEvent]
	// RVA: 0x2127F10 Offset: 0x2127110 VA: 0x182127F10
	public void AcquireCredentialsHandle(string packageName, Interop.SspiCli.CredentialUse intent, object authdata) { }

	[Event(11, Keywords = 1, Level = 4)]
	// RVA: 0x2127EA0 Offset: 0x21270A0 VA: 0x182127EA0
	public void AcquireCredentialsHandle(string packageName, Interop.SspiCli.CredentialUse intent, string authdata) { }

	[NonEvent]
	// RVA: 0x212AC00 Offset: 0x2129E00 VA: 0x18212AC00
	public void InitializeSecurityContext(SafeFreeCredentials credential, SafeDeleteContext context, string targetName, Interop.SspiCli.ContextFlags inFlags) { }

	[Event(12, Keywords = 1, Level = 4)]
	// RVA: 0x212ACC0 Offset: 0x2129EC0 VA: 0x18212ACC0
	private void InitializeSecurityContext(string credential, string context, string targetName, Interop.SspiCli.ContextFlags inFlags) { }

	[NonEvent]
	// RVA: 0x2127DC0 Offset: 0x2126FC0 VA: 0x182127DC0
	public void AcceptSecurityContext(SafeFreeCredentials credential, SafeDeleteContext context, Interop.SspiCli.ContextFlags inFlags) { }

	[Event(15, Keywords = 1, Level = 4)]
	// RVA: 0x2127E70 Offset: 0x2127070 VA: 0x182127E70
	private void AcceptSecurityContext(string credential, string context, Interop.SspiCli.ContextFlags inFlags) { }

	[Event(16, Keywords = 1, Level = 4)]
	// RVA: 0x212ACF0 Offset: 0x2129EF0 VA: 0x18212ACF0
	public void OperationReturnedSomething(string operation, Interop.SECURITY_STATUS errorCode) { }

	[Event(13, Keywords = 1, Level = 4)]
	// RVA: 0x212AE20 Offset: 0x212A020 VA: 0x18212AE20
	public void SecurityContextInputBuffer(string context, int inputBufferSize, int outputBufferSize, Interop.SECURITY_STATUS errorCode) { }

	[Event(14, Keywords = 1, Level = 4)]
	// RVA: 0x212AE90 Offset: 0x212A090 VA: 0x18212AE90
	public void SecurityContextInputBuffers(string context, int inputBuffersSize, int outputBufferSize, Interop.SECURITY_STATUS errorCode) { }

	[Event(8, Keywords = 1, Level = 4)]
	// RVA: 0x2129380 Offset: 0x2128580 VA: 0x182129380
	public void EnumerateSecurityPackages(string securityPackage) { }

	[Event(9, Keywords = 1, Level = 4)]
	// RVA: 0x212AF00 Offset: 0x212A100 VA: 0x18212AF00
	public void SspiPackageNotFound(string packageName) { }

	// RVA: 0x172F990 Offset: 0x172EB90 VA: 0x18172F990
	public void .ctor() { }

	// RVA: 0x212BA00 Offset: 0x212AC00 VA: 0x18212BA00
	private static void .cctor() { }
}

// Namespace: System.Net
internal static class RangeValidationHelpers // TypeDefIndex: 5652
{
	// Methods

	// RVA: 0x214B910 Offset: 0x214AB10 VA: 0x18214B910
	public static bool ValidateRange(int actual, int fromAllowed, int toAllowed) { }

	// RVA: 0x214B920 Offset: 0x214AB20 VA: 0x18214B920
	public static void ValidateSegment(ArraySegment<byte> segment) { }
}

// Namespace: System.Net
internal static class SecurityProtocol // TypeDefIndex: 5653
{
	// Fields
	public const SslProtocols DefaultSecurityProtocols = 4032;
	public const SslProtocols SystemDefaultSecurityProtocols = 0;
}

// Namespace: System.Net
internal static class SecurityStatusAdapterPal // TypeDefIndex: 5654
{
	// Fields
	private const int StatusDictionarySize = 41;
	private static readonly BidirectionalDictionary<Interop.SECURITY_STATUS, SecurityStatusPalErrorCode> s_statusDictionary; // 0x0

	// Methods

	// RVA: 0x214C3D0 Offset: 0x214B5D0 VA: 0x18214C3D0
	internal static SecurityStatusPal GetSecurityStatusPalFromNativeInt(int win32SecurityStatus) { }

	// RVA: 0x214C290 Offset: 0x214B490 VA: 0x18214C290
	internal static SecurityStatusPal GetSecurityStatusPalFromInterop(Interop.SECURITY_STATUS win32SecurityStatus, bool attachException = False) { }

	// RVA: 0x214C1C0 Offset: 0x214B3C0 VA: 0x18214C1C0
	internal static Interop.SECURITY_STATUS GetInteropFromSecurityStatusPal(SecurityStatusPal status) { }

	// RVA: 0x214C500 Offset: 0x214B700 VA: 0x18214C500
	private static void .cctor() { }
}

// Namespace: System.Net
[IsReadOnly]
internal struct SecurityStatusPal // TypeDefIndex: 5655
{
	// Fields
	public readonly SecurityStatusPalErrorCode ErrorCode; // 0x0
	public readonly Exception Exception; // 0x8

	// Methods

	// RVA: 0xBB0D00 Offset: 0xBAFF00 VA: 0x180BB0D00
	public void .ctor(SecurityStatusPalErrorCode errorCode, Exception exception) { }

	// RVA: 0x214C9C0 Offset: 0x214BBC0 VA: 0x18214C9C0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net
internal enum SecurityStatusPalErrorCode // TypeDefIndex: 5656
{
	// Fields
	public int value__; // 0x0
	public const SecurityStatusPalErrorCode NotSet = 0;
	public const SecurityStatusPalErrorCode OK = 1;
	public const SecurityStatusPalErrorCode ContinueNeeded = 2;
	public const SecurityStatusPalErrorCode CompleteNeeded = 3;
	public const SecurityStatusPalErrorCode CompAndContinue = 4;
	public const SecurityStatusPalErrorCode ContextExpired = 5;
	public const SecurityStatusPalErrorCode CredentialsNeeded = 6;
	public const SecurityStatusPalErrorCode Renegotiate = 7;
	public const SecurityStatusPalErrorCode OutOfMemory = 8;
	public const SecurityStatusPalErrorCode InvalidHandle = 9;
	public const SecurityStatusPalErrorCode Unsupported = 10;
	public const SecurityStatusPalErrorCode TargetUnknown = 11;
	public const SecurityStatusPalErrorCode InternalError = 12;
	public const SecurityStatusPalErrorCode PackageNotFound = 13;
	public const SecurityStatusPalErrorCode NotOwner = 14;
	public const SecurityStatusPalErrorCode CannotInstall = 15;
	public const SecurityStatusPalErrorCode InvalidToken = 16;
	public const SecurityStatusPalErrorCode CannotPack = 17;
	public const SecurityStatusPalErrorCode QopNotSupported = 18;
	public const SecurityStatusPalErrorCode NoImpersonation = 19;
	public const SecurityStatusPalErrorCode LogonDenied = 20;
	public const SecurityStatusPalErrorCode UnknownCredentials = 21;
	public const SecurityStatusPalErrorCode NoCredentials = 22;
	public const SecurityStatusPalErrorCode MessageAltered = 23;
	public const SecurityStatusPalErrorCode OutOfSequence = 24;
	public const SecurityStatusPalErrorCode NoAuthenticatingAuthority = 25;
	public const SecurityStatusPalErrorCode IncompleteMessage = 26;
	public const SecurityStatusPalErrorCode IncompleteCredentials = 27;
	public const SecurityStatusPalErrorCode BufferNotEnough = 28;
	public const SecurityStatusPalErrorCode WrongPrincipal = 29;
	public const SecurityStatusPalErrorCode TimeSkew = 30;
	public const SecurityStatusPalErrorCode UntrustedRoot = 31;
	public const SecurityStatusPalErrorCode IllegalMessage = 32;
	public const SecurityStatusPalErrorCode CertUnknown = 33;
	public const SecurityStatusPalErrorCode CertExpired = 34;
	public const SecurityStatusPalErrorCode AlgorithmMismatch = 35;
	public const SecurityStatusPalErrorCode SecurityQosFailed = 36;
	public const SecurityStatusPalErrorCode SmartcardLogonRequired = 37;
	public const SecurityStatusPalErrorCode UnsupportedPreauth = 38;
	public const SecurityStatusPalErrorCode BadBinding = 39;
	public const SecurityStatusPalErrorCode DowngradeDetected = 40;
	public const SecurityStatusPalErrorCode ApplicationProtocolMismatch = 41;
}

// Namespace: System.Net
internal static class TcpValidationHelpers // TypeDefIndex: 5657
{
	// Methods

	// RVA: 0x214CBE0 Offset: 0x214BDE0 VA: 0x18214CBE0
	public static bool ValidatePortNumber(int port) { }
}

// Namespace: System.Net
internal class TlsStream : NetworkStream // TypeDefIndex: 5658
{
	// Fields
	private SslStream _sslStream; // 0x48
	private string _host; // 0x50
	private X509CertificateCollection _clientCertificates; // 0x58

	// Methods

	// RVA: 0x214D020 Offset: 0x214C220 VA: 0x18214D020
	public void .ctor(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	// RVA: 0x214CC00 Offset: 0x214BE00 VA: 0x18214CC00
	public void AuthenticateAsClient() { }

	// RVA: 0x214CD30 Offset: 0x214BF30 VA: 0x18214CD30
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	// RVA: 0x214CF30 Offset: 0x214C130 VA: 0x18214CF30
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x214CEB0 Offset: 0x214C0B0 VA: 0x18214CEB0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x214CF90 Offset: 0x214C190 VA: 0x18214CF90 Slot: 29
	public override void EndWrite(IAsyncResult result) { }

	// RVA: 0x214CFF0 Offset: 0x214C1F0 VA: 0x18214CFF0 Slot: 37
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x214CFC0 Offset: 0x214C1C0 VA: 0x18214CFC0 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x214CE70 Offset: 0x214C070 VA: 0x18214CE70 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x214CF60 Offset: 0x214C160 VA: 0x18214CF60 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x214CEF0 Offset: 0x214C0F0 VA: 0x18214CEF0 Slot: 20
	public override void Close() { }
}

// Namespace: System.Net
internal static class UriScheme // TypeDefIndex: 5659
{
	// Fields
	public const string File = "file";
	public const string Ftp = "ftp";
	public const string Gopher = "gopher";
	public const string Http = "http";
	public const string Https = "https";
	public const string News = "news";
	public const string NetPipe = "net.pipe";
	public const string NetTcp = "net.tcp";
	public const string Nntp = "nntp";
	public const string Mailto = "mailto";
	public const string Ws = "ws";
	public const string Wss = "wss";
	public const string SchemeDelimiter = "://";
}

// Namespace: 
private sealed class Base64Stream.ReadAsyncResult : LazyAsyncResult // TypeDefIndex: 5660
{
	// Fields
	private readonly Base64Stream _parent; // 0x48
	private readonly byte[] _buffer; // 0x50
	private readonly int _offset; // 0x58
	private readonly int _count; // 0x5C
	private int _read; // 0x60
	private static readonly AsyncCallback s_onRead; // 0x0

	// Methods

	// RVA: 0x214BF00 Offset: 0x214B100 VA: 0x18214BF00
	internal void .ctor(Base64Stream parent, byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x214BA90 Offset: 0x214AC90 VA: 0x18214BA90
	private bool CompleteRead(IAsyncResult result) { }

	// RVA: 0x214BC90 Offset: 0x214AE90 VA: 0x18214BC90
	internal void Read() { }

	// RVA: 0x214BB80 Offset: 0x214AD80 VA: 0x18214BB80
	private static void OnRead(IAsyncResult result) { }

	// RVA: 0x214BB10 Offset: 0x214AD10 VA: 0x18214BB10
	internal static int End(IAsyncResult result) { }

	// RVA: 0x214BE80 Offset: 0x214B080 VA: 0x18214BE80
	private static void .cctor() { }
}

// Namespace: 
private sealed class Base64Stream.WriteAsyncResult : LazyAsyncResult // TypeDefIndex: 5661
{
	// Fields
	private static readonly AsyncCallback s_onWrite; // 0x0
	private readonly Base64Stream _parent; // 0x48
	private readonly byte[] _buffer; // 0x50
	private readonly int _offset; // 0x58
	private readonly int _count; // 0x5C
	private int _written; // 0x60

	// Methods

	// RVA: 0x214BF00 Offset: 0x214B100 VA: 0x18214BF00
	internal void .ctor(Base64Stream parent, byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2159720 Offset: 0x2158920 VA: 0x182159720
	internal void Write() { }

	// RVA: 0x21594E0 Offset: 0x21586E0 VA: 0x1821594E0
	private void CompleteWrite(IAsyncResult result) { }

	// RVA: 0x21595B0 Offset: 0x21587B0 VA: 0x1821595B0
	private static void OnWrite(IAsyncResult result) { }

	// RVA: 0x2159540 Offset: 0x2158740 VA: 0x182159540
	internal static void End(IAsyncResult result) { }

	// RVA: 0x2159980 Offset: 0x2158B80 VA: 0x182159980
	private static void .cctor() { }
}

// Namespace: 
private sealed class Base64Stream.ReadStateInfo // TypeDefIndex: 5662
{
	// Fields
	[CompilerGenerated]
	private byte <Val>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <Pos>k__BackingField; // 0x11

	// Properties
	internal byte Val { get; set; }
	internal byte Pos { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	internal byte get_Val() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void set_Val(byte value) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	internal byte get_Pos() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	internal void set_Pos(byte value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
internal sealed class Base64Stream : DelegatedStream, IEncodableStream // TypeDefIndex: 5663
{
	// Fields
	private static readonly byte[] s_base64DecodeMap; // 0x0
	private static readonly byte[] s_base64EncodeMap; // 0x8
	private readonly int _lineLength; // 0x38
	private readonly Base64WriteStateInfo _writeState; // 0x40
	private Base64Stream.ReadStateInfo _readState; // 0x48
	private const int SizeOfBase64EncodedChar = 4;
	private const byte InvalidBase64Value = 255;

	// Properties
	private Base64Stream.ReadStateInfo ReadState { get; }
	internal Base64WriteStateInfo WriteState { get; }

	// Methods

	// RVA: 0x2138030 Offset: 0x2137230 VA: 0x182138030
	internal void .ctor(Stream stream, Base64WriteStateInfo writeStateInfo) { }

	// RVA: 0x2137FB0 Offset: 0x21371B0 VA: 0x182137FB0
	internal void .ctor(Base64WriteStateInfo writeStateInfo) { }

	// RVA: 0x21380B0 Offset: 0x21372B0 VA: 0x1821380B0
	private Base64Stream.ReadStateInfo get_ReadState() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal Base64WriteStateInfo get_WriteState() { }

	// RVA: 0x2136570 Offset: 0x2135770 VA: 0x182136570 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2136720 Offset: 0x2135920 VA: 0x182136720 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x21368D0 Offset: 0x2135AD0 VA: 0x1821368D0 Slot: 20
	public override void Close() { }

	// RVA: 0x2136B20 Offset: 0x2135D20 VA: 0x182136B20 Slot: 40
	public int DecodeBytes(byte[] buffer, int offset, int count) { }

	// RVA: 0x2136DB0 Offset: 0x2135FB0 VA: 0x182136DB0 Slot: 41
	public int EncodeBytes(byte[] buffer, int offset, int count) { }

	// RVA: 0x2136DE0 Offset: 0x2135FE0 VA: 0x182136DE0
	internal int EncodeBytes(byte[] buffer, int offset, int count, bool dontDeferFinalBytes, bool shouldAppendSpaceToCRLF) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 43
	public Stream GetStream() { }

	// RVA: 0x2137AE0 Offset: 0x2136CE0 VA: 0x182137AE0 Slot: 42
	public string GetEncodedString() { }

	// RVA: 0x21377E0 Offset: 0x21369E0 VA: 0x1821377E0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x21378C0 Offset: 0x2136AC0 VA: 0x1821378C0 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2137A90 Offset: 0x2136C90 VA: 0x182137A90 Slot: 22
	public override void Flush() { }

	// RVA: 0x21379B0 Offset: 0x2136BB0 VA: 0x1821379B0
	private void FlushInternal() { }

	// RVA: 0x2137B40 Offset: 0x2136D40 VA: 0x182137B40 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2137D50 Offset: 0x2136F50 VA: 0x182137D50 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2137EF0 Offset: 0x21370F0 VA: 0x182137EF0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class ClosableStream : DelegatedStream // TypeDefIndex: 5664
{
	// Fields
	private readonly EventHandler _onClose; // 0x38
	private int _closed; // 0x40

	// Methods

	// RVA: 0x21381A0 Offset: 0x21373A0 VA: 0x1821381A0
	internal void .ctor(Stream stream, EventHandler onClose) { }

	// RVA: 0x2138110 Offset: 0x2137310 VA: 0x182138110 Slot: 20
	public override void Close() { }
}

// Namespace: System.Net
internal class DelegatedStream : Stream // TypeDefIndex: 5665
{
	// Fields
	private readonly Stream _stream; // 0x28
	private readonly NetworkStream _netStream; // 0x30

	// Properties
	protected Stream BaseStream { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x213A690 Offset: 0x2139890 VA: 0x18213A690
	protected void .ctor(Stream stream) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	protected Stream get_BaseStream() { }

	// RVA: 0x1C954E0 Offset: 0x1C946E0 VA: 0x181C954E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x557000 Offset: 0x556200 VA: 0x180557000 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x205C340 Offset: 0x205B540 VA: 0x18205C340 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x213A790 Offset: 0x2139990 VA: 0x18213A790 Slot: 11
	public override long get_Length() { }

	// RVA: 0x213A830 Offset: 0x2139A30 VA: 0x18213A830 Slot: 12
	public override long get_Position() { }

	// RVA: 0x213A8D0 Offset: 0x2139AD0 VA: 0x18213A8D0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2139E80 Offset: 0x2139080 VA: 0x182139E80 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2139F70 Offset: 0x2139170 VA: 0x182139F70 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x213A060 Offset: 0x2139260 VA: 0x18213A060 Slot: 20
	public override void Close() { }

	// RVA: 0x213A090 Offset: 0x2139290 VA: 0x18213A090 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x213A130 Offset: 0x2139330 VA: 0x18213A130 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x173D3E0 Offset: 0x173C5E0 VA: 0x18173D3E0 Slot: 22
	public override void Flush() { }

	// RVA: 0x213A1D0 Offset: 0x21393D0 VA: 0x18213A1D0 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x213A2D0 Offset: 0x21394D0 VA: 0x18213A2D0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x213A200 Offset: 0x2139400 VA: 0x18213A200 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x213A3A0 Offset: 0x21395A0 VA: 0x18213A3A0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x213A450 Offset: 0x2139650 VA: 0x18213A450 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x213A5C0 Offset: 0x21397C0 VA: 0x18213A5C0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x213A4F0 Offset: 0x21396F0 VA: 0x18213A4F0 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }
}

// Namespace: System.Net
[DefaultMember("Item")]
internal sealed class TrackingStringDictionary : StringDictionary // TypeDefIndex: 5666
{
	// Fields
	private readonly bool _isReadOnly; // 0x18
	private bool _isChanged; // 0x19

	// Properties
	internal bool IsChanged { get; set; }
	public override string Item { get; set; }

	// Methods

	// RVA: 0x214D270 Offset: 0x214C470 VA: 0x18214D270
	internal void .ctor() { }

	// RVA: 0x214D240 Offset: 0x214C440 VA: 0x18214D240
	internal void .ctor(bool isReadOnly) { }

	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40
	internal bool get_IsChanged() { }

	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50
	internal void set_IsChanged(bool value) { }

	// RVA: 0x214D0F0 Offset: 0x214C2F0 VA: 0x18214D0F0 Slot: 12
	public override void Add(string key, string value) { }

	// RVA: 0x214D160 Offset: 0x214C360 VA: 0x18214D160 Slot: 13
	public override void Clear() { }

	// RVA: 0x214D1D0 Offset: 0x214C3D0 VA: 0x18214D1D0 Slot: 18
	public override void Remove(string key) { }

	// RVA: 0x214D290 Offset: 0x214C490 VA: 0x18214D290 Slot: 7
	public override string get_Item(string key) { }

	// RVA: 0x214D2A0 Offset: 0x214C4A0 VA: 0x18214D2A0 Slot: 8
	public override void set_Item(string key, string value) { }
}

// Namespace: 
internal sealed class TrackingValidationObjectDictionary.ValidateAndParseValue : MulticastDelegate // TypeDefIndex: 5667
{
	// Methods

	// RVA: 0x16390A0 Offset: 0x16382A0 VA: 0x1816390A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual object Invoke(object valueToValidate) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(object valueToValidate, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
[DefaultMember("Item")]
internal sealed class TrackingValidationObjectDictionary : StringDictionary // TypeDefIndex: 5668
{
	// Fields
	private readonly Dictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue> _validators; // 0x18
	private Dictionary<string, object> _internalObjects; // 0x20
	[CompilerGenerated]
	private bool <IsChanged>k__BackingField; // 0x28

	// Properties
	internal bool IsChanged { get; set; }
	public override string Item { get; set; }

	// Methods

	// RVA: 0x214D740 Offset: 0x214C940 VA: 0x18214D740
	internal void .ctor(Dictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue> validators) { }

	// RVA: 0x214D4F0 Offset: 0x214C6F0 VA: 0x18214D4F0
	private void PersistValue(string key, string value, bool addValue) { }

	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	internal bool get_IsChanged() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	internal void set_IsChanged(bool value) { }

	// RVA: 0x214D380 Offset: 0x214C580 VA: 0x18214D380
	internal object InternalGet(string key) { }

	// RVA: 0x214D410 Offset: 0x214C610 VA: 0x18214D410
	internal void InternalSet(string key, object value) { }

	// RVA: 0x214D290 Offset: 0x214C490 VA: 0x18214D290 Slot: 7
	public override string get_Item(string key) { }

	// RVA: 0x214D770 Offset: 0x214C970 VA: 0x18214D770 Slot: 8
	public override void set_Item(string key, string value) { }

	// RVA: 0x214D310 Offset: 0x214C510 VA: 0x18214D310 Slot: 12
	public override void Add(string key, string value) { }

	// RVA: 0x214D330 Offset: 0x214C530 VA: 0x18214D330 Slot: 13
	public override void Clear() { }

	// RVA: 0x214D6D0 Offset: 0x214C8D0 VA: 0x18214D6D0 Slot: 18
	public override void Remove(string key) { }
}

// Namespace: System.Net
public enum HttpStatusCode // TypeDefIndex: 5669
{
	// Fields
	public int value__; // 0x0
	public const HttpStatusCode Continue = 100;
	public const HttpStatusCode SwitchingProtocols = 101;
	public const HttpStatusCode Processing = 102;
	public const HttpStatusCode EarlyHints = 103;
	public const HttpStatusCode OK = 200;
	public const HttpStatusCode Created = 201;
	public const HttpStatusCode Accepted = 202;
	public const HttpStatusCode NonAuthoritativeInformation = 203;
	public const HttpStatusCode NoContent = 204;
	public const HttpStatusCode ResetContent = 205;
	public const HttpStatusCode PartialContent = 206;
	public const HttpStatusCode MultiStatus = 207;
	public const HttpStatusCode AlreadyReported = 208;
	public const HttpStatusCode IMUsed = 226;
	public const HttpStatusCode MultipleChoices = 300;
	public const HttpStatusCode Ambiguous = 300;
	public const HttpStatusCode MovedPermanently = 301;
	public const HttpStatusCode Moved = 301;
	public const HttpStatusCode Found = 302;
	public const HttpStatusCode Redirect = 302;
	public const HttpStatusCode SeeOther = 303;
	public const HttpStatusCode RedirectMethod = 303;
	public const HttpStatusCode NotModified = 304;
	public const HttpStatusCode UseProxy = 305;
	public const HttpStatusCode Unused = 306;
	public const HttpStatusCode TemporaryRedirect = 307;
	public const HttpStatusCode RedirectKeepVerb = 307;
	public const HttpStatusCode PermanentRedirect = 308;
	public const HttpStatusCode BadRequest = 400;
	public const HttpStatusCode Unauthorized = 401;
	public const HttpStatusCode PaymentRequired = 402;
	public const HttpStatusCode Forbidden = 403;
	public const HttpStatusCode NotFound = 404;
	public const HttpStatusCode MethodNotAllowed = 405;
	public const HttpStatusCode NotAcceptable = 406;
	public const HttpStatusCode ProxyAuthenticationRequired = 407;
	public const HttpStatusCode RequestTimeout = 408;
	public const HttpStatusCode Conflict = 409;
	public const HttpStatusCode Gone = 410;
	public const HttpStatusCode LengthRequired = 411;
	public const HttpStatusCode PreconditionFailed = 412;
	public const HttpStatusCode RequestEntityTooLarge = 413;
	public const HttpStatusCode RequestUriTooLong = 414;
	public const HttpStatusCode UnsupportedMediaType = 415;
	public const HttpStatusCode RequestedRangeNotSatisfiable = 416;
	public const HttpStatusCode ExpectationFailed = 417;
	public const HttpStatusCode MisdirectedRequest = 421;
	public const HttpStatusCode UnprocessableEntity = 422;
	public const HttpStatusCode Locked = 423;
	public const HttpStatusCode FailedDependency = 424;
	public const HttpStatusCode UpgradeRequired = 426;
	public const HttpStatusCode PreconditionRequired = 428;
	public const HttpStatusCode TooManyRequests = 429;
	public const HttpStatusCode RequestHeaderFieldsTooLarge = 431;
	public const HttpStatusCode UnavailableForLegalReasons = 451;
	public const HttpStatusCode InternalServerError = 500;
	public const HttpStatusCode NotImplemented = 501;
	public const HttpStatusCode BadGateway = 502;
	public const HttpStatusCode ServiceUnavailable = 503;
	public const HttpStatusCode GatewayTimeout = 504;
	public const HttpStatusCode HttpVersionNotSupported = 505;
	public const HttpStatusCode VariantAlsoNegotiates = 506;
	public const HttpStatusCode InsufficientStorage = 507;
	public const HttpStatusCode LoopDetected = 508;
	public const HttpStatusCode NotExtended = 510;
	public const HttpStatusCode NetworkAuthenticationRequired = 511;
}

// Namespace: System.Net
public class HttpVersion // TypeDefIndex: 5670
{
	// Fields
	public static readonly Version Unknown; // 0x0
	public static readonly Version Version10; // 0x8
	public static readonly Version Version11; // 0x10
	public static readonly Version Version20; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2147810 Offset: 0x2146A10 VA: 0x182147810
	private static void .cctor() { }
}

// Namespace: 
private sealed class IPAddress.ReadOnlyIPAddress : IPAddress // TypeDefIndex: 5671
{
	// Methods

	// RVA: 0x214BF70 Offset: 0x214B170 VA: 0x18214BF70
	public void .ctor(long newAddress) { }
}

// Namespace: System.Net
[Serializable]
public class IPAddress // TypeDefIndex: 5672
{
	// Fields
	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const long LoopbackMask = 255;
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private uint _addressOrScopeId; // 0x10
	private readonly ushort[] _numbers; // 0x18
	private string _toString; // 0x20
	private int _hashCode; // 0x28
	internal const int NumberOfLabels = 8;

	// Properties
	private bool IsIPv4 { get; }
	private bool IsIPv6 { get; }
	private uint PrivateAddress { get; set; }
	private uint PrivateScopeId { get; set; }
	public AddressFamily AddressFamily { get; }
	public long ScopeId { get; set; }
	public bool IsIPv6Multicast { get; }
	public bool IsIPv6LinkLocal { get; }
	public bool IsIPv6SiteLocal { get; }
	public bool IsIPv6Teredo { get; }
	public bool IsIPv4MappedToIPv6 { get; }
	[Obsolete("This property has been deprecated. It is address family dependent. Please use IPAddress.Equals method to perform comparisons. https://go.microsoft.com/fwlink/?linkid=14202")]
	public long Address { get; set; }

	// Methods

	// RVA: 0x10EC0D0 Offset: 0x10EB2D0 VA: 0x1810EC0D0
	private bool get_IsIPv4() { }

	// RVA: 0x159CCC0 Offset: 0x159BEC0 VA: 0x18159CCC0
	private bool get_IsIPv6() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	private uint get_PrivateAddress() { }

	// RVA: 0x214AAD0 Offset: 0x2149CD0 VA: 0x18214AAD0
	private void set_PrivateAddress(uint value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	private uint get_PrivateScopeId() { }

	// RVA: 0x214AAD0 Offset: 0x2149CD0 VA: 0x18214AAD0
	private void set_PrivateScopeId(uint value) { }

	// RVA: 0x214A3A0 Offset: 0x21495A0 VA: 0x18214A3A0
	public void .ctor(long newAddress) { }

	// RVA: 0x214A0F0 Offset: 0x21492F0 VA: 0x18214A0F0
	public void .ctor(byte[] address, long scopeid) { }

	// RVA: 0x214A5D0 Offset: 0x21497D0 VA: 0x18214A5D0
	public void .ctor(ReadOnlySpan<byte> address, long scopeid) { }

	// RVA: 0x214A2F0 Offset: 0x21494F0 VA: 0x18214A2F0
	internal void .ctor(ushort* numbers, int numbersLength, uint scopeid) { }

	// RVA: 0x214A080 Offset: 0x2149280 VA: 0x18214A080
	private void .ctor(ushort[] numbers, uint scopeid) { }

	// RVA: 0x2149FF0 Offset: 0x21491F0 VA: 0x182149FF0
	public void .ctor(byte[] address) { }

	// RVA: 0x214A430 Offset: 0x2149630 VA: 0x18214A430
	public void .ctor(ReadOnlySpan<byte> address) { }

	// RVA: 0x214A0C0 Offset: 0x21492C0 VA: 0x18214A0C0
	internal void .ctor(int newAddress) { }

	// RVA: 0x2149B40 Offset: 0x2148D40 VA: 0x182149B40
	public static bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x2149BE0 Offset: 0x2148DE0 VA: 0x182149BE0
	public static bool TryParse(ReadOnlySpan<char> ipSpan, out IPAddress address) { }

	// RVA: 0x2149870 Offset: 0x2148A70 VA: 0x182149870
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x2149850 Offset: 0x2148A50 VA: 0x182149850
	public static IPAddress Parse(ReadOnlySpan<char> ipSpan) { }

	// RVA: 0x2149C10 Offset: 0x2148E10 VA: 0x182149C10
	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x21364C0 Offset: 0x21356C0 VA: 0x1821364C0
	private void WriteIPv6Bytes(Span<byte> destination) { }

	// RVA: 0x2149D10 Offset: 0x2148F10 VA: 0x182149D10
	private void WriteIPv4Bytes(Span<byte> destination) { }

	// RVA: 0x2148EB0 Offset: 0x21480B0 VA: 0x182148EB0
	public byte[] GetAddressBytes() { }

	// RVA: 0x214A7A0 Offset: 0x21499A0 VA: 0x18214A7A0
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x214A980 Offset: 0x2149B80 VA: 0x18214A980
	public long get_ScopeId() { }

	// RVA: 0x214AAE0 Offset: 0x2149CE0 VA: 0x18214AAE0
	public void set_ScopeId(long value) { }

	// RVA: 0x2149980 Offset: 0x2148B80 VA: 0x182149980 Slot: 3
	public override string ToString() { }

	// RVA: 0x21499E0 Offset: 0x2148BE0 VA: 0x1821499E0
	public bool TryFormat(Span<char> destination, out int charsWritten) { }

	// RVA: 0x2149460 Offset: 0x2148660 VA: 0x182149460
	public static long HostToNetworkOrder(long host) { }

	// RVA: 0x2149450 Offset: 0x2148650 VA: 0x182149450
	public static int HostToNetworkOrder(int host) { }

	// RVA: 0x2149480 Offset: 0x2148680 VA: 0x182149480
	public static short HostToNetworkOrder(short host) { }

	// RVA: 0x21497F0 Offset: 0x21489F0 VA: 0x1821497F0
	public static long NetworkToHostOrder(long network) { }

	// RVA: 0x2149750 Offset: 0x2148950 VA: 0x182149750
	public static int NetworkToHostOrder(int network) { }

	// RVA: 0x21497A0 Offset: 0x21489A0 VA: 0x1821497A0
	public static short NetworkToHostOrder(short network) { }

	// RVA: 0x2149490 Offset: 0x2148690 VA: 0x182149490
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x214A8C0 Offset: 0x2149AC0 VA: 0x18214A8C0
	public bool get_IsIPv6Multicast() { }

	// RVA: 0x214A880 Offset: 0x2149A80 VA: 0x18214A880
	public bool get_IsIPv6LinkLocal() { }

	// RVA: 0x214A900 Offset: 0x2149B00 VA: 0x18214A900
	public bool get_IsIPv6SiteLocal() { }

	// RVA: 0x214A940 Offset: 0x2149B40 VA: 0x18214A940
	public bool get_IsIPv6Teredo() { }

	// RVA: 0x214A820 Offset: 0x2149A20 VA: 0x18214A820
	public bool get_IsIPv4MappedToIPv6() { }

	// RVA: 0x214A7C0 Offset: 0x21499C0 VA: 0x18214A7C0
	public long get_Address() { }

	// RVA: 0x214A9E0 Offset: 0x2149BE0 VA: 0x18214A9E0
	public void set_Address(long value) { }

	// RVA: 0x2148D60 Offset: 0x2147F60 VA: 0x182148D60
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x2148C50 Offset: 0x2147E50 VA: 0x182148C50 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x2148FC0 Offset: 0x21481C0 VA: 0x182148FC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2149660 Offset: 0x2148860 VA: 0x182149660
	public IPAddress MapToIPv6() { }

	// RVA: 0x2149570 Offset: 0x2148770 VA: 0x182149570
	public IPAddress MapToIPv4() { }

	// RVA: 0x2149930 Offset: 0x2148B30 VA: 0x182149930
	private static byte[] ThrowAddressNullException() { }

	// RVA: 0x2149D60 Offset: 0x2148F60 VA: 0x182149D60
	private static void .cctor() { }
}

// Namespace: System.Net
internal class IPAddressParser // TypeDefIndex: 5673
{
	// Fields
	private const int MaxIPv4StringLength = 15;

	// Methods

	// RVA: 0x2148850 Offset: 0x2147A50 VA: 0x182148850
	internal static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse) { }

	// RVA: 0x2147F10 Offset: 0x2147110 VA: 0x182147F10
	internal static string IPv4AddressToString(uint address) { }

	// RVA: 0x2147F70 Offset: 0x2147170 VA: 0x182147F70
	internal static void IPv4AddressToString(uint address, StringBuilder destination) { }

	// RVA: 0x2147FE0 Offset: 0x21471E0 VA: 0x182147FE0
	internal static bool IPv4AddressToString(uint address, Span<char> formatted, out int charsWritten) { }

	// RVA: 0x2147CC0 Offset: 0x2146EC0 VA: 0x182147CC0
	private static int IPv4AddressToStringHelper(uint address, char* addressString) { }

	// RVA: 0x2148510 Offset: 0x2147710 VA: 0x182148510
	internal static string IPv6AddressToString(ushort[] address, uint scopeId) { }

	// RVA: 0x2148530 Offset: 0x2147730 VA: 0x182148530
	internal static bool IPv6AddressToString(ushort[] address, uint scopeId, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2148080 Offset: 0x2147280 VA: 0x182148080
	internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId) { }

	// RVA: 0x2147C00 Offset: 0x2146E00 VA: 0x182147C00
	private static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset) { }

	// RVA: 0x2148600 Offset: 0x2147800 VA: 0x182148600
	public static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address) { }

	// RVA: 0x21486E0 Offset: 0x21478E0 VA: 0x1821486E0
	public static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope) { }

	// RVA: 0x21479C0 Offset: 0x2146BC0 VA: 0x1821479C0
	private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	// RVA: 0x2147910 Offset: 0x2146B10 VA: 0x182147910
	private static void AppendHex(ushort value, StringBuilder buffer) { }

	// RVA: 0x2147BB0 Offset: 0x2146DB0 VA: 0x182147BB0
	private static uint ExtractIPv4Address(ushort[] address) { }

	// RVA: 0x172DF60 Offset: 0x172D160 VA: 0x18172DF60
	private static ushort Reverse(ushort number) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
[Serializable]
public class IPEndPoint : EndPoint // TypeDefIndex: 5674
{
	// Fields
	public const int MinPort = 0;
	public const int MaxPort = 65535;
	private IPAddress _address; // 0x10
	private int _port; // 0x18
	internal const int AnyPort = 0;
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Properties
	public override AddressFamily AddressFamily { get; }
	public IPAddress Address { get; set; }
	public int Port { get; set; }

	// Methods

	// RVA: 0x214B370 Offset: 0x214A570 VA: 0x18214B370 Slot: 4
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x214B1C0 Offset: 0x214A3C0 VA: 0x18214B1C0
	public void .ctor(long address, int port) { }

	// RVA: 0x214B290 Offset: 0x214A490 VA: 0x18214B290
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IPAddress get_Address() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Address(IPAddress value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Port() { }

	// RVA: 0x214B3A0 Offset: 0x214A5A0 VA: 0x18214B3A0
	public void set_Port(int value) { }

	// RVA: 0x214AF80 Offset: 0x214A180 VA: 0x18214AF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x214AF10 Offset: 0x214A110 VA: 0x18214AF10 Slot: 5
	public override SocketAddress Serialize() { }

	// RVA: 0x214ABA0 Offset: 0x2149DA0 VA: 0x18214ABA0 Slot: 6
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x214AE00 Offset: 0x214A000 VA: 0x18214AE00 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x214AED0 Offset: 0x214A0D0 VA: 0x18214AED0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214B040 Offset: 0x214A240 VA: 0x18214B040
	private static void .cctor() { }
}

// Namespace: 
internal enum CommandStream.PipelineInstruction // TypeDefIndex: 5675
{
	// Fields
	public int value__; // 0x0
	public const CommandStream.PipelineInstruction Abort = 0;
	public const CommandStream.PipelineInstruction Advance = 1;
	public const CommandStream.PipelineInstruction Pause = 2;
	public const CommandStream.PipelineInstruction Reread = 3;
	public const CommandStream.PipelineInstruction GiveStream = 4;
}

// Namespace: 
[Flags]
internal enum CommandStream.PipelineEntryFlags // TypeDefIndex: 5676
{
	// Fields
	public int value__; // 0x0
	public const CommandStream.PipelineEntryFlags UserCommand = 1;
	public const CommandStream.PipelineEntryFlags GiveDataStream = 2;
	public const CommandStream.PipelineEntryFlags CreateDataConnection = 4;
	public const CommandStream.PipelineEntryFlags DontLogParameter = 8;
}

// Namespace: 
internal class CommandStream.PipelineEntry // TypeDefIndex: 5677
{
	// Fields
	internal string Command; // 0x10
	internal CommandStream.PipelineEntryFlags Flags; // 0x18

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(string command) { }

	// RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	internal void .ctor(string command, CommandStream.PipelineEntryFlags flags) { }

	// RVA: 0x214B900 Offset: 0x214AB00 VA: 0x18214B900
	internal bool HasFlag(CommandStream.PipelineEntryFlags flags) { }
}

// Namespace: System.Net
internal class CommandStream : NetworkStreamWrapper // TypeDefIndex: 5678
{
	// Fields
	private static readonly AsyncCallback s_writeCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_readCallbackDelegate; // 0x8
	private bool _recoverableFailure; // 0x38
	protected WebRequest _request; // 0x40
	protected bool _isAsync; // 0x48
	private bool _aborted; // 0x49
	protected CommandStream.PipelineEntry[] _commands; // 0x50
	protected int _index; // 0x58
	private bool _doRead; // 0x5C
	private bool _doSend; // 0x5D
	private ResponseDescription _currentResponseDescription; // 0x60
	protected string _abortReason; // 0x68
	private const int WaitingForPipeline = 1;
	private const int CompletedPipeline = 2;
	private string _buffer; // 0x70
	private Encoding _encoding; // 0x78
	private Decoder _decoder; // 0x80

	// Properties
	internal bool RecoverableFailure { get; }
	protected Encoding Encoding { get; set; }

	// Methods

	// RVA: 0x2139D60 Offset: 0x2138F60 VA: 0x182139D60
	internal void .ctor(TcpClient client) { }

	// RVA: 0x21381D0 Offset: 0x21373D0 VA: 0x1821381D0 Slot: 40
	internal virtual void Abort(Exception e) { }

	// RVA: 0x2138910 Offset: 0x2137B10 VA: 0x182138910 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2138B60 Offset: 0x2137D60 VA: 0x182138B60
	protected void InvokeRequestCallback(object obj) { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	internal bool get_RecoverableFailure() { }

	// RVA: 0x2138BF0 Offset: 0x2137DF0 VA: 0x182138BF0
	protected void MarkAsRecoverableFailure() { }

	// RVA: 0x2139A80 Offset: 0x2138C80 VA: 0x182139A80
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	// RVA: 0x21383E0 Offset: 0x21375E0 VA: 0x1821383E0 Slot: 41
	protected virtual void ClearState() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 42
	protected virtual CommandStream.PipelineEntry[] BuildCommandsList(WebRequest request) { }

	// RVA: 0x2138A50 Offset: 0x2137C50 VA: 0x182138A50
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	// RVA: 0x21389A0 Offset: 0x2137BA0 VA: 0x1821389A0
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	// RVA: 0x2138AD0 Offset: 0x2137CD0 VA: 0x182138AD0
	protected void InitCommandPipeline(WebRequest request, CommandStream.PipelineEntry[] commands, bool isAsync) { }

	// RVA: 0x21383A0 Offset: 0x21375A0 VA: 0x1821383A0
	internal void CheckContinuePipeline() { }

	// RVA: 0x2138440 Offset: 0x2137640 VA: 0x182138440
	protected Stream ContinueCommandPipeline() { }

	// RVA: 0x2138E00 Offset: 0x2138000 VA: 0x182138E00
	private bool PostSendCommandProcessing(ref Stream stream) { }

	// RVA: 0x2138C00 Offset: 0x2137E00 VA: 0x182138C00
	private bool PostReadCommandProcessing(ref Stream stream) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 43
	protected virtual CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x2138EF0 Offset: 0x21380F0 VA: 0x182138EF0
	private static void ReadCallback(IAsyncResult asyncResult) { }

	// RVA: 0x2139B20 Offset: 0x2138D20 VA: 0x182139B20
	private static void WriteCallback(IAsyncResult asyncResult) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	protected Encoding get_Encoding() { }

	// RVA: 0x2139E40 Offset: 0x2139040 VA: 0x182139E40
	protected void set_Encoding(Encoding value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 44
	protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x2139720 Offset: 0x2138920 VA: 0x182139720
	private ResponseDescription ReceiveCommandResponse() { }

	// RVA: 0x21390F0 Offset: 0x21382F0 VA: 0x1821390F0
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	// RVA: 0x2139CA0 Offset: 0x2138EA0 VA: 0x182139CA0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class ResponseDescription // TypeDefIndex: 5679
{
	// Fields
	internal const int NoStatus = -1;
	internal bool Multiline; // 0x10
	internal int Status; // 0x14
	internal string StatusDescription; // 0x18
	internal StringBuilder StatusBuffer; // 0x20
	internal string StatusCodeString; // 0x28

	// Properties
	internal bool PositiveIntermediate { get; }
	internal bool PositiveCompletion { get; }
	internal bool TransientFailure { get; }
	internal bool PermanentFailure { get; }
	internal bool InvalidStatusCode { get; }

	// Methods

	// RVA: 0x214C180 Offset: 0x214B380 VA: 0x18214C180
	internal bool get_PositiveIntermediate() { }

	// RVA: 0x214C160 Offset: 0x214B360 VA: 0x18214C160
	internal bool get_PositiveCompletion() { }

	// RVA: 0x214C1A0 Offset: 0x214B3A0 VA: 0x18214C1A0
	internal bool get_TransientFailure() { }

	// RVA: 0x214C140 Offset: 0x214B340 VA: 0x18214C140
	internal bool get_PermanentFailure() { }

	// RVA: 0x214C120 Offset: 0x214B320 VA: 0x18214C120
	internal bool get_InvalidStatusCode() { }

	// RVA: 0x214C0B0 Offset: 0x214B2B0 VA: 0x18214C0B0
	public void .ctor() { }
}

// Namespace: System.Net
internal class ReceiveState // TypeDefIndex: 5680
{
	// Fields
	private const int bufferSize = 1024;
	internal ResponseDescription Resp; // 0x10
	internal int ValidThrough; // 0x18
	internal byte[] Buffer; // 0x20
	internal CommandStream Connection; // 0x28

	// Methods

	// RVA: 0x214BFD0 Offset: 0x214B1D0 VA: 0x18214BFD0
	internal void .ctor(CommandStream connection) { }
}

// Namespace: System.Net
internal enum FtpLoginState // TypeDefIndex: 5681
{
	// Fields
	public byte value__; // 0x0
	public const FtpLoginState NotLoggedIn = 0;
	public const FtpLoginState LoggedIn = 1;
	public const FtpLoginState LoggedInButNeedsRelogin = 2;
	public const FtpLoginState ReloginFailed = 3;
}

// Namespace: 
private enum FtpControlStream.GetPathOption // TypeDefIndex: 5682
{
	// Fields
	public int value__; // 0x0
	public const FtpControlStream.GetPathOption Normal = 0;
	public const FtpControlStream.GetPathOption AssumeFilename = 1;
	public const FtpControlStream.GetPathOption AssumeNoFilename = 2;
}

// Namespace: 
[CompilerGenerated]
private sealed class FtpControlStream.<>c__DisplayClass31_0 // TypeDefIndex: 5683
{
	// Fields
	public FtpControlStream <>4__this; // 0x10
	public TlsStream tlsStream; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x214DA50 Offset: 0x214CC50 VA: 0x18214DA50
	internal void <PipelineCallback>b__0(IAsyncResult ar) { }
}

// Namespace: System.Net
internal class FtpControlStream : CommandStream // TypeDefIndex: 5684
{
	// Fields
	private Socket _dataSocket; // 0x88
	private IPEndPoint _passiveEndPoint; // 0x90
	private TlsStream _tlsStream; // 0x98
	private StringBuilder _bannerMessage; // 0xA0
	private StringBuilder _welcomeMessage; // 0xA8
	private StringBuilder _exitMessage; // 0xB0
	private WeakReference _credentials; // 0xB8
	private string _currentTypeSetting; // 0xC0
	private long _contentLength; // 0xC8
	private DateTime _lastModified; // 0xD0
	private bool _dataHandshakeStarted; // 0xD8
	private string _loginDirectory; // 0xE0
	private string _establishedServerDirectory; // 0xE8
	private string _requestedServerDirectory; // 0xF0
	private Uri _responseUri; // 0xF8
	private FtpLoginState _loginState; // 0x100
	internal FtpStatusCode StatusCode; // 0x104
	internal string StatusLine; // 0x108
	private static readonly AsyncCallback s_acceptCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_connectCallbackDelegate; // 0x8
	private static readonly AsyncCallback s_SSLHandshakeCallback; // 0x10

	// Properties
	internal NetworkCredential Credentials { get; set; }
	internal long ContentLength { get; }
	internal DateTime LastModified { get; }
	internal Uri ResponseUri { get; }
	internal string BannerMessage { get; }
	internal string WelcomeMessage { get; }
	internal string ExitMessage { get; }

	// Methods

	// RVA: 0x213F820 Offset: 0x213EA20 VA: 0x18213F820
	internal NetworkCredential get_Credentials() { }

	// RVA: 0x213F960 Offset: 0x213EB60 VA: 0x18213F960
	internal void set_Credentials(NetworkCredential value) { }

	// RVA: 0x213F6B0 Offset: 0x213E8B0 VA: 0x18213F6B0
	internal void .ctor(TcpClient client) { }

	// RVA: 0x213A9C0 Offset: 0x2139BC0 VA: 0x18213A9C0
	internal void AbortConnect() { }

	// RVA: 0x213A9E0 Offset: 0x2139BE0 VA: 0x18213A9E0
	private static void AcceptCallback(IAsyncResult asyncResult) { }

	// RVA: 0x213C250 Offset: 0x213B450 VA: 0x18213C250
	private static void ConnectCallback(IAsyncResult asyncResult) { }

	// RVA: 0x213EFE0 Offset: 0x213E1E0 VA: 0x18213EFE0
	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	// RVA: 0x213EC60 Offset: 0x213DE60 VA: 0x18213EC60
	private CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream) { }

	// RVA: 0x213C160 Offset: 0x213B360 VA: 0x18213C160 Slot: 41
	protected override void ClearState() { }

	// RVA: 0x213D850 Offset: 0x213CA50 VA: 0x18213D850 Slot: 43
	protected override CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x213AD00 Offset: 0x2139F00 VA: 0x18213AD00 Slot: 42
	protected override CommandStream.PipelineEntry[] BuildCommandsList(WebRequest req) { }

	// RVA: 0x213E450 Offset: 0x213D650 VA: 0x18213E450
	private CommandStream.PipelineInstruction QueueOrCreateDataConection(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady) { }

	// RVA: 0x213CFA0 Offset: 0x213C1A0 VA: 0x18213CFA0
	private static void GetPathInfo(FtpControlStream.GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename) { }

	// RVA: 0x213C790 Offset: 0x213B990 VA: 0x18213C790
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x213C670 Offset: 0x213B870 VA: 0x18213C670
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x738340 Offset: 0x737540 VA: 0x180738340
	internal long get_ContentLength() { }

	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	internal DateTime get_LastModified() { }

	// RVA: 0x794CD0 Offset: 0x793ED0 VA: 0x180794CD0
	internal Uri get_ResponseUri() { }

	// RVA: 0x213F7F0 Offset: 0x213E9F0 VA: 0x18213F7F0
	internal string get_BannerMessage() { }

	// RVA: 0x213F930 Offset: 0x213EB30 VA: 0x18213F930
	internal string get_WelcomeMessage() { }

	// RVA: 0x213F900 Offset: 0x213EB00 VA: 0x18213F900
	internal string get_ExitMessage() { }

	// RVA: 0x213CAC0 Offset: 0x213BCC0 VA: 0x18213CAC0
	private long GetContentLengthFrom213Response(string responseString) { }

	// RVA: 0x213CBF0 Offset: 0x213BDF0 VA: 0x18213CBF0
	private DateTime GetLastModifiedFrom213Response(string str) { }

	// RVA: 0x213F210 Offset: 0x213E410 VA: 0x18213F210
	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

	// RVA: 0x213F120 Offset: 0x213E320 VA: 0x18213F120
	private void TryUpdateContentLength(string str) { }

	// RVA: 0x213CF00 Offset: 0x213C100 VA: 0x18213CF00
	private string GetLoginDirectory(string str) { }

	// RVA: 0x213D400 Offset: 0x213C600 VA: 0x18213D400
	private int GetPortV4(string responseString) { }

	// RVA: 0x213D5E0 Offset: 0x213C7E0 VA: 0x18213D5E0
	private int GetPortV6(string responseString) { }

	// RVA: 0x213C400 Offset: 0x213B600 VA: 0x18213C400
	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	// RVA: 0x213D140 Offset: 0x213C340 VA: 0x18213D140
	private string GetPortCommandLine(FtpWebRequest request) { }

	// RVA: 0x213C9B0 Offset: 0x213BBB0 VA: 0x18213C9B0
	private string FormatFtpCommand(string command, string parameter) { }

	// RVA: 0x213C370 Offset: 0x213B570 VA: 0x18213C370
	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	// RVA: 0x213BDC0 Offset: 0x213AFC0 VA: 0x18213BDC0 Slot: 44
	protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x213D7D0 Offset: 0x213C9D0 VA: 0x18213D7D0
	private TriState IsFtpDataStreamWriteable() { }

	// RVA: 0x213F5B0 Offset: 0x213E7B0 VA: 0x18213F5B0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class FtpDataStream : Stream, ICloseEx // TypeDefIndex: 5685
{
	// Fields
	private FtpWebRequest _request; // 0x28
	private NetworkStream _networkStream; // 0x30
	private bool _writeable; // 0x38
	private bool _readable; // 0x39
	private bool _isFullyRead; // 0x3A
	private bool _closing; // 0x3B
	private const int DefaultCloseTimeout = -1;

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x21407D0 Offset: 0x213F9D0 VA: 0x1821407D0
	internal void .ctor(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	// RVA: 0x213FE20 Offset: 0x213F020 VA: 0x18213FE20 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2140390 Offset: 0x213F590 VA: 0x182140390 Slot: 40
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x213FDD0 Offset: 0x213EFD0 VA: 0x18213FDD0
	private void CheckError() { }

	// RVA: 0x4BD740 Offset: 0x4BC940 VA: 0x1804BD740 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x17555C0 Offset: 0x17547C0 VA: 0x1817555C0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1755D10 Offset: 0x1754F10 VA: 0x181755D10 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1755D70 Offset: 0x1754F70 VA: 0x181755D70 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1672A40 Offset: 0x1671C40 VA: 0x181672A40 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2140290 Offset: 0x213F490 VA: 0x182140290 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21401C0 Offset: 0x213F3C0 VA: 0x1821401C0 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x2140730 Offset: 0x213F930 VA: 0x182140730 Slot: 37
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x213FA00 Offset: 0x213EC00 VA: 0x18213FA00
	private void AsyncReadCallback(IAsyncResult ar) { }

	// RVA: 0x213FB90 Offset: 0x213ED90 VA: 0x18213FB90 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x213FEE0 Offset: 0x213F0E0 VA: 0x18213FEE0 Slot: 25
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x213FD10 Offset: 0x213EF10 VA: 0x18213FD10 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x21400E0 Offset: 0x213F2E0 VA: 0x1821400E0 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2140190 Offset: 0x213F390 VA: 0x182140190 Slot: 22
	public override void Flush() { }

	// RVA: 0x17558D0 Offset: 0x1754AD0 VA: 0x1817558D0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x21408D0 Offset: 0x213FAD0 VA: 0x1821408D0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1D87880 Offset: 0x1D86A80 VA: 0x181D87880 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1674460 Offset: 0x1673660 VA: 0x181674460 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x2140900 Offset: 0x213FB00 VA: 0x182140900 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1674490 Offset: 0x1673690 VA: 0x181674490 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x2140330 Offset: 0x213F530 VA: 0x182140330
	internal void SetSocketTimeoutOption(int timeout) { }
}

// Namespace: System.Net
internal enum FtpOperation // TypeDefIndex: 5686
{
	// Fields
	public int value__; // 0x0
	public const FtpOperation DownloadFile = 0;
	public const FtpOperation ListDirectory = 1;
	public const FtpOperation ListDirectoryDetails = 2;
	public const FtpOperation UploadFile = 3;
	public const FtpOperation UploadFileUnique = 4;
	public const FtpOperation AppendFile = 5;
	public const FtpOperation DeleteFile = 6;
	public const FtpOperation GetDateTimestamp = 7;
	public const FtpOperation GetFileSize = 8;
	public const FtpOperation Rename = 9;
	public const FtpOperation MakeDirectory = 10;
	public const FtpOperation RemoveDirectory = 11;
	public const FtpOperation PrintWorkingDirectory = 12;
	public const FtpOperation Other = 13;
}

// Namespace: System.Net
[Flags]
internal enum FtpMethodFlags // TypeDefIndex: 5687
{
	// Fields
	public int value__; // 0x0
	public const FtpMethodFlags None = 0;
	public const FtpMethodFlags IsDownload = 1;
	public const FtpMethodFlags IsUpload = 2;
	public const FtpMethodFlags TakesParameter = 4;
	public const FtpMethodFlags MayTakeParameter = 8;
	public const FtpMethodFlags DoesNotTakeParameter = 16;
	public const FtpMethodFlags ParameterIsDirectory = 32;
	public const FtpMethodFlags ShouldParseForResponseUri = 64;
	public const FtpMethodFlags HasHttpCommand = 128;
	public const FtpMethodFlags MustChangeWorkingDirectoryToPath = 256;
}

// Namespace: System.Net
internal class FtpMethodInfo // TypeDefIndex: 5688
{
	// Fields
	internal string Method; // 0x10
	internal FtpOperation Operation; // 0x18
	internal FtpMethodFlags Flags; // 0x1C
	internal string HttpCommand; // 0x20
	private static readonly FtpMethodInfo[] s_knownMethodInfo; // 0x0

	// Properties
	internal bool IsCommandOnly { get; }
	internal bool IsUpload { get; }
	internal bool IsDownload { get; }
	internal bool ShouldParseForResponseUri { get; }

	// Methods

	// RVA: 0x2141190 Offset: 0x2140390 VA: 0x182141190
	internal void .ctor(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	// RVA: 0x2140AA0 Offset: 0x213FCA0 VA: 0x182140AA0
	internal bool HasFlag(FtpMethodFlags flags) { }

	// RVA: 0x21411E0 Offset: 0x21403E0 VA: 0x1821411E0
	internal bool get_IsCommandOnly() { }

	// RVA: 0x21411F0 Offset: 0x21403F0 VA: 0x1821411F0
	internal bool get_IsUpload() { }

	// RVA: 0x1ED89F0 Offset: 0x1ED7BF0 VA: 0x181ED89F0
	internal bool get_IsDownload() { }

	// RVA: 0x2141200 Offset: 0x2140400 VA: 0x182141200
	internal bool get_ShouldParseForResponseUri() { }

	// RVA: 0x2140930 Offset: 0x213FB30 VA: 0x182140930
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	// RVA: 0x2140AB0 Offset: 0x213FCB0 VA: 0x182140AB0
	private static void .cctor() { }
}

// Namespace: 
private enum FtpWebRequest.RequestStage // TypeDefIndex: 5689
{
	// Fields
	public int value__; // 0x0
	public const FtpWebRequest.RequestStage CheckForError = 0;
	public const FtpWebRequest.RequestStage RequestStarted = 1;
	public const FtpWebRequest.RequestStage WriteReady = 2;
	public const FtpWebRequest.RequestStage ReadReady = 3;
	public const FtpWebRequest.RequestStage ReleaseConnection = 4;
}

// Namespace: 
[CompilerGenerated]
private struct FtpWebRequest.<CreateConnectionAsync>d__86 : IAsyncStateMachine // TypeDefIndex: 5690
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public FtpWebRequest <>4__this; // 0x28
	private TcpClient <client>5__2; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x214D790 Offset: 0x214C990 VA: 0x18214D790 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x71F7C0 Offset: 0x71E9C0 VA: 0x18071F7C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FtpWebRequest.<>c // TypeDefIndex: 5691
{
	// Fields
	public static readonly FtpWebRequest.<>c <>9; // 0x0
	public static Func<X509CertificateCollection> <>9__114_0; // 0x8

	// Methods

	// RVA: 0x214DB00 Offset: 0x214CD00 VA: 0x18214DB00
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x214DA00 Offset: 0x214CC00 VA: 0x18214DA00
	internal X509CertificateCollection <get_ClientCertificates>b__114_0() { }
}

// Namespace: System.Net
public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 5692
{
	// Fields
	private object _syncObject; // 0x38
	private ICredentials _authInfo; // 0x40
	private readonly Uri _uri; // 0x48
	private FtpMethodInfo _methodInfo; // 0x50
	private string _renameTo; // 0x58
	private bool _getRequestStreamStarted; // 0x60
	private bool _getResponseStarted; // 0x61
	private DateTime _startTime; // 0x68
	private int _timeout; // 0x70
	private int _remainingTimeout; // 0x74
	private long _contentLength; // 0x78
	private long _contentOffset; // 0x80
	private X509CertificateCollection _clientCertificates; // 0x88
	private bool _passive; // 0x90
	private bool _binary; // 0x91
	private string _connectionGroupName; // 0x98
	private ServicePoint _servicePoint; // 0xA0
	private bool _async; // 0xA8
	private bool _aborted; // 0xA9
	private bool _timedOut; // 0xAA
	private Exception _exception; // 0xB0
	private TimerThread.Queue _timerQueue; // 0xB8
	private TimerThread.Callback _timerCallback; // 0xC0
	private bool _enableSsl; // 0xC8
	private FtpControlStream _connection; // 0xD0
	private Stream _stream; // 0xD8
	private FtpWebRequest.RequestStage _requestStage; // 0xE0
	private bool _onceFailed; // 0xE4
	private WebHeaderCollection _ftpRequestHeaders; // 0xE8
	private FtpWebResponse _ftpWebResponse; // 0xF0
	private int _readWriteTimeout; // 0xF8
	private ContextAwareResult _writeAsyncResult; // 0x100
	private LazyAsyncResult _readAsyncResult; // 0x108
	private LazyAsyncResult _requestCompleteAsyncResult; // 0x110
	private static readonly NetworkCredential s_defaultFtpNetworkCredential; // 0x0
	private const int s_DefaultTimeout = 100000;
	private static readonly TimerThread.Queue s_DefaultTimerQueue; // 0x8

	// Properties
	internal FtpMethodInfo MethodInfo { get; }
	public static RequestCachePolicy DefaultCachePolicy { get; set; }
	public override string Method { get; set; }
	public string RenameTo { get; set; }
	public override ICredentials Credentials { get; set; }
	public override Uri RequestUri { get; }
	public override int Timeout { get; set; }
	internal int RemainingTimeout { get; }
	public int ReadWriteTimeout { get; set; }
	public long ContentOffset { get; set; }
	public override long ContentLength { get; set; }
	public override IWebProxy Proxy { get; set; }
	public override string ConnectionGroupName { get; set; }
	public ServicePoint ServicePoint { get; }
	internal bool Aborted { get; }
	private TimerThread.Queue TimerQueue { get; }
	public bool KeepAlive { get; set; }
	public override RequestCachePolicy CachePolicy { get; set; }
	public bool UseBinary { get; set; }
	public bool UsePassive { get; set; }
	public X509CertificateCollection ClientCertificates { get; set; }
	public bool EnableSsl { get; set; }
	public override WebHeaderCollection Headers { get; set; }
	public override string ContentType { get; set; }
	public override bool UseDefaultCredentials { get; set; }
	public override bool PreAuthenticate { get; set; }
	private bool InUse { get; }

	// Methods

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal FtpMethodInfo get_MethodInfo() { }

	// RVA: 0x2146710 Offset: 0x2145910 VA: 0x182146710
	public static RequestCachePolicy get_DefaultCachePolicy() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void set_DefaultCachePolicy(RequestCachePolicy value) { }

	// RVA: 0x21467E0 Offset: 0x21459E0 VA: 0x1821467E0 Slot: 11
	public override string get_Method() { }

	// RVA: 0x2146DD0 Offset: 0x2145FD0 VA: 0x182146DD0 Slot: 12
	public override void set_Method(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_RenameTo() { }

	// RVA: 0x21470D0 Offset: 0x21462D0 VA: 0x1821470D0
	public void set_RenameTo(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 22
	public override ICredentials get_Credentials() { }

	// RVA: 0x2146B80 Offset: 0x2145D80 VA: 0x182146B80 Slot: 23
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 13
	public override Uri get_RequestUri() { }

	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0 Slot: 30
	public override int get_Timeout() { }

	// RVA: 0x21471B0 Offset: 0x21463B0 VA: 0x1821471B0 Slot: 31
	public override void set_Timeout(int value) { }

	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90
	internal int get_RemainingTimeout() { }

	// RVA: 0x190DD30 Offset: 0x190CF30 VA: 0x18190DD30
	public int get_ReadWriteTimeout() { }

	// RVA: 0x2147000 Offset: 0x2146200 VA: 0x182147000
	public void set_ReadWriteTimeout(int value) { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public long get_ContentOffset() { }

	// RVA: 0x2146A90 Offset: 0x2145C90 VA: 0x182146A90
	public void set_ContentOffset(long value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 18
	public override long get_ContentLength() { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40 Slot: 19
	public override void set_ContentLength(long value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 26
	public override IWebProxy get_Proxy() { }

	// RVA: 0x2146F90 Offset: 0x2146190 VA: 0x182146F90 Slot: 27
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50 Slot: 14
	public override string get_ConnectionGroupName() { }

	// RVA: 0x2146A20 Offset: 0x2145C20 VA: 0x182146A20 Slot: 15
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x2146830 Offset: 0x2145A30 VA: 0x182146830
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x738150 Offset: 0x737350 VA: 0x180738150
	internal bool get_Aborted() { }

	// RVA: 0x2146190 Offset: 0x2145390 VA: 0x182146190
	internal void .ctor(Uri uri) { }

	// RVA: 0x2144560 Offset: 0x2143760 VA: 0x182144560 Slot: 33
	public override WebResponse GetResponse() { }

	// RVA: 0x21426E0 Offset: 0x21418E0 VA: 0x1821426E0 Slot: 34
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x2143260 Offset: 0x2142460 VA: 0x182143260 Slot: 35
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x2144050 Offset: 0x2143250 VA: 0x182144050 Slot: 32
	public override Stream GetRequestStream() { }

	// RVA: 0x2142280 Offset: 0x2141480 VA: 0x182142280 Slot: 36
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x2142EF0 Offset: 0x21420F0 VA: 0x182142EF0 Slot: 37
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x21450A0 Offset: 0x21442A0 VA: 0x1821450A0
	private void SubmitRequest(bool isAsync) { }

	// RVA: 0x2145F70 Offset: 0x2145170 VA: 0x182145F70
	private Exception TranslateConnectException(Exception e) { }

	[AsyncStateMachine(typeof(FtpWebRequest.<CreateConnectionAsync>d__86))]
	// RVA: 0x2142C90 Offset: 0x2141E90 VA: 0x182142C90
	private void CreateConnectionAsync() { }

	// RVA: 0x2142D30 Offset: 0x2141F30 VA: 0x182142D30
	private FtpControlStream CreateConnection() { }

	// RVA: 0x21459B0 Offset: 0x2144BB0 VA: 0x1821459B0
	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	// RVA: 0x2145E70 Offset: 0x2145070 VA: 0x182145E70
	private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context) { }

	// RVA: 0x21468A0 Offset: 0x2145AA0 VA: 0x1821468A0
	private TimerThread.Queue get_TimerQueue() { }

	// RVA: 0x2141FD0 Offset: 0x21411D0 VA: 0x182141FD0
	private bool AttemptedRecovery(Exception e) { }

	// RVA: 0x2144C60 Offset: 0x2143E60 VA: 0x182144C60
	private void SetException(Exception exception) { }

	// RVA: 0x2142C70 Offset: 0x2141E70 VA: 0x182142C70
	private void CheckError() { }

	// RVA: 0x2144C40 Offset: 0x2143E40 VA: 0x182144C40
	internal void RequestCallback(object obj) { }

	// RVA: 0x2145610 Offset: 0x2144810 VA: 0x182145610
	private void SyncRequestCallback(object obj) { }

	// RVA: 0x21415E0 Offset: 0x21407E0 VA: 0x1821415E0
	private void AsyncRequestCallback(object obj) { }

	// RVA: 0x2143BB0 Offset: 0x2142DB0 VA: 0x182143BB0
	private FtpWebRequest.RequestStage FinishRequestStage(FtpWebRequest.RequestStage stage) { }

	// RVA: 0x2141270 Offset: 0x2140470 VA: 0x182141270 Slot: 40
	public override void Abort() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public bool get_KeepAlive() { }

	// RVA: 0x2146D60 Offset: 0x2145F60 VA: 0x182146D60
	public void set_KeepAlive(bool value) { }

	// RVA: 0x2146560 Offset: 0x2145760 VA: 0x182146560 Slot: 9
	public override RequestCachePolicy get_CachePolicy() { }

	// RVA: 0x2146940 Offset: 0x2145B40 VA: 0x182146940 Slot: 10
	public override void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x8663E0 Offset: 0x8655E0 VA: 0x1808663E0
	public bool get_UseBinary() { }

	// RVA: 0x2147290 Offset: 0x2146490 VA: 0x182147290
	public void set_UseBinary(bool value) { }

	// RVA: 0x5C4DE0 Offset: 0x5C3FE0 VA: 0x1805C4DE0
	public bool get_UsePassive() { }

	// RVA: 0x2147330 Offset: 0x2146530 VA: 0x182147330
	public void set_UsePassive(bool value) { }

	// RVA: 0x21465E0 Offset: 0x21457E0 VA: 0x1821465E0
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x21469B0 Offset: 0x2145BB0 VA: 0x1821469B0
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x772600 Offset: 0x771800 VA: 0x180772600
	public bool get_EnableSsl() { }

	// RVA: 0x2146CF0 Offset: 0x2145EF0 VA: 0x182146CF0
	public void set_EnableSsl(bool value) { }

	// RVA: 0x2146750 Offset: 0x2145950 VA: 0x182146750 Slot: 16
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x7960E0 Offset: 0x7952E0 VA: 0x1807960E0 Slot: 17
	public override void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x21466E0 Offset: 0x21458E0 VA: 0x1821466E0 Slot: 20
	public override string get_ContentType() { }

	// RVA: 0x2146B50 Offset: 0x2145D50 VA: 0x182146B50 Slot: 21
	public override void set_ContentType(string value) { }

	// RVA: 0x2146910 Offset: 0x2145B10 VA: 0x182146910 Slot: 24
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x2147300 Offset: 0x2146500 VA: 0x182147300 Slot: 25
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x2146800 Offset: 0x2145A00 VA: 0x182146800 Slot: 28
	public override bool get_PreAuthenticate() { }

	// RVA: 0x2146F60 Offset: 0x2146160 VA: 0x182146F60 Slot: 29
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x21467C0 Offset: 0x21459C0 VA: 0x1821467C0
	private bool get_InUse() { }

	// RVA: 0x2143540 Offset: 0x2142740 VA: 0x182143540
	private void EnsureFtpWebResponse(Exception exception) { }

	// RVA: 0x2142E40 Offset: 0x2142040 VA: 0x182142E40
	internal void DataStreamClosed(CloseExState closeState) { }

	// RVA: 0x2146060 Offset: 0x2145260 VA: 0x182146060
	private static void .cctor() { }

	// RVA: 0x2146160 Offset: 0x2145360 VA: 0x182146160
	internal void .ctor() { }
}

// Namespace: System.Net
internal class FtpWebRequestCreator : IWebRequestCreate // TypeDefIndex: 5693
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x2141210 Offset: 0x2140410 VA: 0x182141210 Slot: 4
	public WebRequest Create(Uri uri) { }
}

// Namespace: 
internal sealed class FtpWebResponse.EmptyStream : MemoryStream // TypeDefIndex: 5694
{
	// Methods

	// RVA: 0x213A970 Offset: 0x2139B70 VA: 0x18213A970
	internal void .ctor() { }
}

// Namespace: System.Net
public class FtpWebResponse : WebResponse, IDisposable // TypeDefIndex: 5695
{
	// Fields
	internal Stream _responseStream; // 0x20
	private long _contentLength; // 0x28
	private Uri _responseUri; // 0x30
	private FtpStatusCode _statusCode; // 0x38
	private string _statusLine; // 0x40
	private WebHeaderCollection _ftpRequestHeaders; // 0x48
	private DateTime _lastModified; // 0x50
	private string _bannerMessage; // 0x58
	private string _welcomeMessage; // 0x60
	private string _exitMessage; // 0x68

	// Properties
	public override long ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override bool SupportsHeaders { get; }
	public override Uri ResponseUri { get; }
	public FtpStatusCode StatusCode { get; }
	public string StatusDescription { get; }
	public DateTime LastModified { get; }
	public string BannerMessage { get; }
	public string WelcomeMessage { get; }
	public string ExitMessage { get; }

	// Methods

	// RVA: 0x2147600 Offset: 0x2146800 VA: 0x182147600
	internal void .ctor(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	// RVA: 0x21475C0 Offset: 0x21467C0 VA: 0x1821475C0
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

	// RVA: 0x2147490 Offset: 0x2146690 VA: 0x182147490 Slot: 18
	public override Stream GetResponseStream() { }

	// RVA: 0x2147530 Offset: 0x2146730 VA: 0x182147530
	internal void SetResponseStream(Stream stream) { }

	// RVA: 0x21473A0 Offset: 0x21465A0 VA: 0x1821473A0 Slot: 9
	public override void Close() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 14
	public override long get_ContentLength() { }

	// RVA: 0x2147720 Offset: 0x2146920 VA: 0x182147720 Slot: 20
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 21
	public override bool get_SupportsHeaders() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 19
	public override Uri get_ResponseUri() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public FtpStatusCode get_StatusCode() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_StatusDescription() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public DateTime get_LastModified() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_BannerMessage() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_WelcomeMessage() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public string get_ExitMessage() { }

	// RVA: 0x21475D0 Offset: 0x21467D0 VA: 0x1821475D0
	internal void .ctor() { }
}

// Namespace: System.Net
internal class NetworkStreamWrapper : Stream // TypeDefIndex: 5696
{
	// Fields
	private TcpClient _client; // 0x28
	private NetworkStream _networkStream; // 0x30

	// Properties
	protected bool UsingSecureStream { get; }
	internal IPAddress ServerAddress { get; }
	internal Socket Socket { get; }
	internal NetworkStream NetworkStream { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x214B710 Offset: 0x214A910 VA: 0x18214B710
	internal void .ctor(TcpClient client) { }

	// RVA: 0x214B880 Offset: 0x214AA80 VA: 0x18214B880
	protected bool get_UsingSecureStream() { }

	// RVA: 0x214B790 Offset: 0x214A990 VA: 0x18214B790
	internal IPAddress get_ServerAddress() { }

	// RVA: 0x199EB70 Offset: 0x199DD70 VA: 0x18199EB70
	internal Socket get_Socket() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal NetworkStream get_NetworkStream() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_NetworkStream(NetworkStream value) { }

	// RVA: 0x1755D40 Offset: 0x1754F40 VA: 0x181755D40 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x17555C0 Offset: 0x17547C0 VA: 0x1817555C0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1755650 Offset: 0x1754850 VA: 0x181755650 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x21408D0 Offset: 0x213FAD0 VA: 0x1821408D0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1D87880 Offset: 0x1D86A80 VA: 0x181D87880 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1674460 Offset: 0x1673660 VA: 0x181674460 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x2140900 Offset: 0x213FB00 VA: 0x182140900 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1674490 Offset: 0x1673690 VA: 0x181674490 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1755D10 Offset: 0x1754F10 VA: 0x181755D10 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1755D70 Offset: 0x1754F70 VA: 0x181755D70 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1672A40 Offset: 0x1671C40 VA: 0x181672A40 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x214B680 Offset: 0x214A880 VA: 0x18214B680 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x214B650 Offset: 0x214A850 VA: 0x18214B650 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x214B6E0 Offset: 0x214A8E0 VA: 0x18214B6E0 Slot: 37
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x214B510 Offset: 0x214A710 VA: 0x18214B510 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x214B490 Offset: 0x214A690 VA: 0x18214B490
	internal void CloseSocket() { }

	// RVA: 0x214B4D0 Offset: 0x214A6D0 VA: 0x18214B4D0
	public void Close(int timeout) { }

	// RVA: 0x214B410 Offset: 0x214A610 VA: 0x18214B410 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x214B5C0 Offset: 0x214A7C0 VA: 0x18214B5C0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x214B620 Offset: 0x214A820 VA: 0x18214B620 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x214B450 Offset: 0x214A650 VA: 0x18214B450 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x214B5F0 Offset: 0x214A7F0 VA: 0x18214B5F0 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x214B6B0 Offset: 0x214A8B0 VA: 0x18214B6B0 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2140190 Offset: 0x213F390 VA: 0x182140190 Slot: 22
	public override void Flush() { }

	// RVA: 0x1755C60 Offset: 0x1754E60 VA: 0x181755C60 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x17558D0 Offset: 0x1754AD0 VA: 0x1817558D0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x2140330 Offset: 0x213F530 VA: 0x182140330
	internal void SetSocketTimeoutOption(int timeout) { }
}

// Namespace: System.Net
[Flags]
public enum SecurityProtocolType // TypeDefIndex: 5697
{
	// Fields
	public int value__; // 0x0
	public const SecurityProtocolType SystemDefault = 0;
	public const SecurityProtocolType Ssl3 = 48;
	public const SecurityProtocolType Tls = 192;
	public const SecurityProtocolType Tls11 = 768;
	public const SecurityProtocolType Tls12 = 3072;
	public const SecurityProtocolType Tls13 = 12288;
}

// Namespace: 
private sealed class WebClient.ProgressData // TypeDefIndex: 5698
{
	// Fields
	internal long BytesSent; // 0x10
	internal long TotalBytesToSend; // 0x18
	internal long BytesReceived; // 0x20
	internal long TotalBytesToReceive; // 0x28
	internal bool HasUploadPhase; // 0x30

	// Methods

	// RVA: 0x2161610 Offset: 0x2160810 VA: 0x182161610
	internal void Reset() { }

	// RVA: 0x2161630 Offset: 0x2160830 VA: 0x182161630
	public void .ctor() { }
}

// Namespace: 
private sealed class WebClient.WebClientWriteStream : DelegatingStream // TypeDefIndex: 5699
{
	// Fields
	private readonly WebRequest _request; // 0x30
	private readonly WebClient _webClient; // 0x38

	// Methods

	// RVA: 0x21675B0 Offset: 0x21667B0 VA: 0x1821675B0
	public void .ctor(Stream stream, WebRequest request, WebClient webClient) { }

	// RVA: 0x2167500 Offset: 0x2166700 VA: 0x182167500 Slot: 21
	protected override void Dispose(bool disposing) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebClient.<GetWebResponseTaskAsync>d__112 : IAsyncStateMachine // TypeDefIndex: 5700
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<WebResponse> <>t__builder; // 0x8
	public WebRequest request; // 0x20
	public WebClient <>4__this; // 0x28
	private WebRequest <>7__wrap1; // 0x30
	private object <>u__1; // 0x38

	// Methods

	// RVA: 0x21639B0 Offset: 0x2162BB0 VA: 0x1821639B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2163CA0 Offset: 0x2162EA0 VA: 0x182163CA0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebClient.<DownloadBitsAsync>d__150 : IAsyncStateMachine // TypeDefIndex: 5701
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public WebClient <>4__this; // 0x28
	public WebRequest request; // 0x30
	public Stream writeStream; // 0x38
	public AsyncOperation asyncOp; // 0x40
	public Action<byte[], Exception, AsyncOperation> completionDelegate; // 0x48
	private Exception <exception>5__2; // 0x50
	private byte[] <copyBuffer>5__3; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse> <>u__1; // 0x60
	private Stream <>7__wrap3; // 0x70
	private Stream <readStream>5__5; // 0x78
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__2; // 0x80
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__3; // 0x90

	// Methods

	// RVA: 0x2162B30 Offset: 0x2161D30 VA: 0x182162B30 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x71F7C0 Offset: 0x71E9C0 VA: 0x18071F7C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebClient.<UploadBitsAsync>d__152 : IAsyncStateMachine // TypeDefIndex: 5702
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public WebClient <>4__this; // 0x28
	public WebRequest request; // 0x30
	public byte[] header; // 0x38
	public byte[] footer; // 0x40
	public AsyncOperation asyncOp; // 0x48
	public Stream readStream; // 0x50
	public byte[] buffer; // 0x58
	public int chunkSize; // 0x60
	public Action<byte[], Exception, AsyncOperation> completionDelegate; // 0x68
	private Exception <exception>5__2; // 0x70
	private Stream <writeStream>5__3; // 0x78
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x80
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__2; // 0x90
	private Stream <>7__wrap3; // 0xA0
	private int <bytesRead>5__5; // 0xA8
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__3; // 0xB0
	private int <toWrite>5__6; // 0xC0

	// Methods

	// RVA: 0x21657C0 Offset: 0x21649C0 VA: 0x1821657C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x71F7C0 Offset: 0x71E9C0 VA: 0x18071F7C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass164_0 // TypeDefIndex: 5703
{
	// Fields
	public WebClient <>4__this; // 0x10
	public AsyncOperation asyncOp; // 0x18
	public WebRequest request; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2163EF0 Offset: 0x21630F0 VA: 0x182163EF0
	internal void <OpenReadAsync>b__0(IAsyncResult iar) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass167_0 // TypeDefIndex: 5704
{
	// Fields
	public WebClient <>4__this; // 0x10
	public AsyncOperation asyncOp; // 0x18
	public WebRequest request; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2164170 Offset: 0x2163370 VA: 0x182164170
	internal void <OpenWriteAsync>b__0(IAsyncResult iar) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass182_0 // TypeDefIndex: 5705
{
	// Fields
	public WebClient <>4__this; // 0x10
	public AsyncOperation asyncOp; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2164400 Offset: 0x2163600 VA: 0x182164400
	internal void <UploadDataAsync>b__0(byte[] result, Exception error, AsyncOperation uploadAsyncOp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass185_0 // TypeDefIndex: 5706
{
	// Fields
	public WebClient <>4__this; // 0x10
	public AsyncOperation asyncOp; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21644D0 Offset: 0x21636D0 VA: 0x1821644D0
	internal void <UploadFileAsync>b__0(byte[] result, Exception error, AsyncOperation uploadAsyncOp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass188_0 // TypeDefIndex: 5707
{
	// Fields
	public WebClient <>4__this; // 0x10
	public AsyncOperation asyncOp; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21645A0 Offset: 0x21637A0 VA: 0x1821645A0
	internal void <UploadValuesAsync>b__0(byte[] result, Exception error, AsyncOperation uploadAsyncOp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass192_0 // TypeDefIndex: 5708
{
	// Fields
	public WebClient <>4__this; // 0x10
	public TaskCompletionSource<string> tcs; // 0x18
	public DownloadStringCompletedEventHandler handler; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2164670 Offset: 0x2163870 VA: 0x182164670
	internal void <DownloadStringTaskAsync>b__0(object sender, DownloadStringCompletedEventArgs e) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class WebClient.<>c // TypeDefIndex: 5709
{
	// Fields
	public static readonly WebClient.<>c <>9; // 0x0
	public static Func<DownloadStringCompletedEventArgs, string> <>9__192_1; // 0x8
	public static Action<WebClient, DownloadStringCompletedEventHandler> <>9__192_2; // 0x10
	public static Func<OpenReadCompletedEventArgs, Stream> <>9__194_1; // 0x18
	public static Action<WebClient, OpenReadCompletedEventHandler> <>9__194_2; // 0x20
	public static Func<OpenWriteCompletedEventArgs, Stream> <>9__198_1; // 0x28
	public static Action<WebClient, OpenWriteCompletedEventHandler> <>9__198_2; // 0x30
	public static Func<UploadStringCompletedEventArgs, string> <>9__202_1; // 0x38
	public static Action<WebClient, UploadStringCompletedEventHandler> <>9__202_2; // 0x40
	public static Func<DownloadDataCompletedEventArgs, byte[]> <>9__204_1; // 0x48
	public static Action<WebClient, DownloadDataCompletedEventHandler> <>9__204_2; // 0x50
	public static Func<AsyncCompletedEventArgs, object> <>9__206_1; // 0x58
	public static Action<WebClient, AsyncCompletedEventHandler> <>9__206_2; // 0x60
	public static Func<UploadDataCompletedEventArgs, byte[]> <>9__210_1; // 0x68
	public static Action<WebClient, UploadDataCompletedEventHandler> <>9__210_2; // 0x70
	public static Func<UploadFileCompletedEventArgs, byte[]> <>9__214_1; // 0x78
	public static Action<WebClient, UploadFileCompletedEventHandler> <>9__214_2; // 0x80
	public static Func<UploadValuesCompletedEventArgs, byte[]> <>9__218_1; // 0x88
	public static Action<WebClient, UploadValuesCompletedEventHandler> <>9__218_2; // 0x90

	// Methods

	// RVA: 0x2165760 Offset: 0x2164960 VA: 0x182165760
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2163D10 Offset: 0x2162F10 VA: 0x182163D10
	internal string <DownloadStringTaskAsync>b__192_1(DownloadStringCompletedEventArgs args) { }

	// RVA: 0x2163DA0 Offset: 0x2162FA0 VA: 0x182163DA0
	internal void <DownloadStringTaskAsync>b__192_2(WebClient webClient, DownloadStringCompletedEventHandler completion) { }

	// RVA: 0x2163D10 Offset: 0x2162F10 VA: 0x182163D10
	internal Stream <OpenReadTaskAsync>b__194_1(OpenReadCompletedEventArgs args) { }

	// RVA: 0x2163DD0 Offset: 0x2162FD0 VA: 0x182163DD0
	internal void <OpenReadTaskAsync>b__194_2(WebClient webClient, OpenReadCompletedEventHandler completion) { }

	// RVA: 0x2163D10 Offset: 0x2162F10 VA: 0x182163D10
	internal Stream <OpenWriteTaskAsync>b__198_1(OpenWriteCompletedEventArgs args) { }

	// RVA: 0x2163E00 Offset: 0x2163000 VA: 0x182163E00
	internal void <OpenWriteTaskAsync>b__198_2(WebClient webClient, OpenWriteCompletedEventHandler completion) { }

	// RVA: 0x2163D10 Offset: 0x2162F10 VA: 0x182163D10
	internal string <UploadStringTaskAsync>b__202_1(UploadStringCompletedEventArgs args) { }

	// RVA: 0x2163E90 Offset: 0x2163090 VA: 0x182163E90
	internal void <UploadStringTaskAsync>b__202_2(WebClient webClient, UploadStringCompletedEventHandler completion) { }

	// RVA: 0x2163D10 Offset: 0x2162F10 VA: 0x182163D10
	internal byte[] <DownloadDataTaskAsync>b__204_1(DownloadDataCompletedEventArgs args) { }

	// RVA: 0x2163D40 Offset: 0x2162F40 VA: 0x182163D40
	internal void <DownloadDataTaskAsync>b__204_2(WebClient webClient, DownloadDataCompletedEventHandler completion) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal object <DownloadFileTaskAsync>b__206_1(AsyncCompletedEventArgs args) { }

	// RVA: 0x2163D70 Offset: 0x2162F70 VA: 0x182163D70
	internal void <DownloadFileTaskAsync>b__206_2(WebClient webClient, AsyncCompletedEventHandler completion) { }

	// RVA: 0x2163D10 Offset: 0x2162F10 VA: 0x182163D10
	internal byte[] <UploadDataTaskAsync>b__210_1(UploadDataCompletedEventArgs args) { }

	// RVA: 0x2163E30 Offset: 0x2163030 VA: 0x182163E30
	internal void <UploadDataTaskAsync>b__210_2(WebClient webClient, UploadDataCompletedEventHandler completion) { }

	// RVA: 0x2163D10 Offset: 0x2162F10 VA: 0x182163D10
	internal byte[] <UploadFileTaskAsync>b__214_1(UploadFileCompletedEventArgs args) { }

	// RVA: 0x2163E60 Offset: 0x2163060 VA: 0x182163E60
	internal void <UploadFileTaskAsync>b__214_2(WebClient webClient, UploadFileCompletedEventHandler completion) { }

	// RVA: 0x2163D10 Offset: 0x2162F10 VA: 0x182163D10
	internal byte[] <UploadValuesTaskAsync>b__218_1(UploadValuesCompletedEventArgs args) { }

	// RVA: 0x2163EC0 Offset: 0x21630C0 VA: 0x182163EC0
	internal void <UploadValuesTaskAsync>b__218_2(WebClient webClient, UploadValuesCompletedEventHandler completion) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass194_0 // TypeDefIndex: 5710
{
	// Fields
	public WebClient <>4__this; // 0x10
	public TaskCompletionSource<Stream> tcs; // 0x18
	public OpenReadCompletedEventHandler handler; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2164850 Offset: 0x2163A50 VA: 0x182164850
	internal void <OpenReadTaskAsync>b__0(object sender, OpenReadCompletedEventArgs e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass198_0 // TypeDefIndex: 5711
{
	// Fields
	public WebClient <>4__this; // 0x10
	public TaskCompletionSource<Stream> tcs; // 0x18
	public OpenWriteCompletedEventHandler handler; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2164A30 Offset: 0x2163C30 VA: 0x182164A30
	internal void <OpenWriteTaskAsync>b__0(object sender, OpenWriteCompletedEventArgs e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass202_0 // TypeDefIndex: 5712
{
	// Fields
	public WebClient <>4__this; // 0x10
	public TaskCompletionSource<string> tcs; // 0x18
	public UploadStringCompletedEventHandler handler; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2164C10 Offset: 0x2163E10 VA: 0x182164C10
	internal void <UploadStringTaskAsync>b__0(object sender, UploadStringCompletedEventArgs e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass204_0 // TypeDefIndex: 5713
{
	// Fields
	public WebClient <>4__this; // 0x10
	public TaskCompletionSource<byte[]> tcs; // 0x18
	public DownloadDataCompletedEventHandler handler; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2164DF0 Offset: 0x2163FF0 VA: 0x182164DF0
	internal void <DownloadDataTaskAsync>b__0(object sender, DownloadDataCompletedEventArgs e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass206_0 // TypeDefIndex: 5714
{
	// Fields
	public WebClient <>4__this; // 0x10
	public TaskCompletionSource<object> tcs; // 0x18
	public AsyncCompletedEventHandler handler; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2164FD0 Offset: 0x21641D0 VA: 0x182164FD0
	internal void <DownloadFileTaskAsync>b__0(object sender, AsyncCompletedEventArgs e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass210_0 // TypeDefIndex: 5715
{
	// Fields
	public WebClient <>4__this; // 0x10
	public TaskCompletionSource<byte[]> tcs; // 0x18
	public UploadDataCompletedEventHandler handler; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21651B0 Offset: 0x21643B0 VA: 0x1821651B0
	internal void <UploadDataTaskAsync>b__0(object sender, UploadDataCompletedEventArgs e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass214_0 // TypeDefIndex: 5716
{
	// Fields
	public WebClient <>4__this; // 0x10
	public TaskCompletionSource<byte[]> tcs; // 0x18
	public UploadFileCompletedEventHandler handler; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2165390 Offset: 0x2164590 VA: 0x182165390
	internal void <UploadFileTaskAsync>b__0(object sender, UploadFileCompletedEventArgs e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebClient.<>c__DisplayClass218_0 // TypeDefIndex: 5717
{
	// Fields
	public WebClient <>4__this; // 0x10
	public TaskCompletionSource<byte[]> tcs; // 0x18
	public UploadValuesCompletedEventHandler handler; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2165570 Offset: 0x2164770 VA: 0x182165570
	internal void <UploadValuesTaskAsync>b__0(object sender, UploadValuesCompletedEventArgs e) { }
}

// Namespace: System.Net
public class WebClient : Component // TypeDefIndex: 5718
{
	// Fields
	private const int DefaultCopyBufferLength = 8192;
	private const int DefaultDownloadBufferLength = 65536;
	private const string DefaultUploadFileContentType = "application/octet-stream";
	private const string UploadFileContentType = "multipart/form-data";
	private const string UploadValuesContentType = "application/x-www-form-urlencoded";
	private Uri _baseAddress; // 0x28
	private ICredentials _credentials; // 0x30
	private WebHeaderCollection _headers; // 0x38
	private NameValueCollection _requestParameters; // 0x40
	private WebResponse _webResponse; // 0x48
	private WebRequest _webRequest; // 0x50
	private Encoding _encoding; // 0x58
	private string _method; // 0x60
	private long _contentLength; // 0x68
	private bool _initWebClientAsync; // 0x70
	private bool _canceled; // 0x71
	private WebClient.ProgressData _progress; // 0x78
	private IWebProxy _proxy; // 0x80
	private bool _proxySet; // 0x88
	private int _callNesting; // 0x8C
	private AsyncOperation _asyncOp; // 0x90
	private SendOrPostCallback _downloadDataOperationCompleted; // 0x98
	private SendOrPostCallback _openReadOperationCompleted; // 0xA0
	private SendOrPostCallback _openWriteOperationCompleted; // 0xA8
	private SendOrPostCallback _downloadStringOperationCompleted; // 0xB0
	private SendOrPostCallback _downloadFileOperationCompleted; // 0xB8
	private SendOrPostCallback _uploadStringOperationCompleted; // 0xC0
	private SendOrPostCallback _uploadDataOperationCompleted; // 0xC8
	private SendOrPostCallback _uploadFileOperationCompleted; // 0xD0
	private SendOrPostCallback _uploadValuesOperationCompleted; // 0xD8
	private SendOrPostCallback _reportDownloadProgressChanged; // 0xE0
	private SendOrPostCallback _reportUploadProgressChanged; // 0xE8
	[CompilerGenerated]
	private DownloadStringCompletedEventHandler DownloadStringCompleted; // 0xF0
	[CompilerGenerated]
	private DownloadDataCompletedEventHandler DownloadDataCompleted; // 0xF8
	[CompilerGenerated]
	private AsyncCompletedEventHandler DownloadFileCompleted; // 0x100
	[CompilerGenerated]
	private UploadStringCompletedEventHandler UploadStringCompleted; // 0x108
	[CompilerGenerated]
	private UploadDataCompletedEventHandler UploadDataCompleted; // 0x110
	[CompilerGenerated]
	private UploadFileCompletedEventHandler UploadFileCompleted; // 0x118
	[CompilerGenerated]
	private UploadValuesCompletedEventHandler UploadValuesCompleted; // 0x120
	[CompilerGenerated]
	private OpenReadCompletedEventHandler OpenReadCompleted; // 0x128
	[CompilerGenerated]
	private OpenWriteCompletedEventHandler OpenWriteCompleted; // 0x130
	[CompilerGenerated]
	private DownloadProgressChangedEventHandler DownloadProgressChanged; // 0x138
	[CompilerGenerated]
	private UploadProgressChangedEventHandler UploadProgressChanged; // 0x140
	[CompilerGenerated]
	private RequestCachePolicy <CachePolicy>k__BackingField; // 0x148
	private static readonly char[] s_parseContentTypeSeparators; // 0x0
	private static readonly Encoding[] s_knownEncodings; // 0x8
	[CompilerGenerated]
	private bool <AllowReadStreamBuffering>k__BackingField; // 0x150
	[CompilerGenerated]
	private bool <AllowWriteStreamBuffering>k__BackingField; // 0x151

	// Properties
	public Encoding Encoding { get; set; }
	public string BaseAddress { get; set; }
	public ICredentials Credentials { get; set; }
	public bool UseDefaultCredentials { get; set; }
	public WebHeaderCollection Headers { get; set; }
	public NameValueCollection QueryString { get; set; }
	public WebHeaderCollection ResponseHeaders { get; }
	public IWebProxy Proxy { get; set; }
	public RequestCachePolicy CachePolicy { get; set; }
	public bool IsBusy { get; }
	[EditorBrowsable(1)]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	public bool AllowReadStreamBuffering { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	public bool AllowWriteStreamBuffering { get; set; }

	// Methods

	// RVA: 0x2158020 Offset: 0x2157220 VA: 0x182158020
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2158330 Offset: 0x2157530 VA: 0x182158330
	public void add_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158D20 Offset: 0x2157F20 VA: 0x182158D20
	public void remove_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158120 Offset: 0x2157320 VA: 0x182158120
	public void add_DownloadDataCompleted(DownloadDataCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158B10 Offset: 0x2157D10 VA: 0x182158B10
	public void remove_DownloadDataCompleted(DownloadDataCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x21581D0 Offset: 0x21573D0 VA: 0x1821581D0
	public void add_DownloadFileCompleted(AsyncCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158BC0 Offset: 0x2157DC0 VA: 0x182158BC0
	public void remove_DownloadFileCompleted(AsyncCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158750 Offset: 0x2157950 VA: 0x182158750
	public void add_UploadStringCompleted(UploadStringCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2159140 Offset: 0x2158340 VA: 0x182159140
	public void remove_UploadStringCompleted(UploadStringCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158540 Offset: 0x2157740 VA: 0x182158540
	public void add_UploadDataCompleted(UploadDataCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158F30 Offset: 0x2158130 VA: 0x182158F30
	public void remove_UploadDataCompleted(UploadDataCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x21585F0 Offset: 0x21577F0 VA: 0x1821585F0
	public void add_UploadFileCompleted(UploadFileCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158FE0 Offset: 0x21581E0 VA: 0x182158FE0
	public void remove_UploadFileCompleted(UploadFileCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158800 Offset: 0x2157A00 VA: 0x182158800
	public void add_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x21591F0 Offset: 0x21583F0 VA: 0x1821591F0
	public void remove_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x21583E0 Offset: 0x21575E0 VA: 0x1821583E0
	public void add_OpenReadCompleted(OpenReadCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158DD0 Offset: 0x2157FD0 VA: 0x182158DD0
	public void remove_OpenReadCompleted(OpenReadCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158490 Offset: 0x2157690 VA: 0x182158490
	public void add_OpenWriteCompleted(OpenWriteCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158E80 Offset: 0x2158080 VA: 0x182158E80
	public void remove_OpenWriteCompleted(OpenWriteCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158280 Offset: 0x2157480 VA: 0x182158280
	public void add_DownloadProgressChanged(DownloadProgressChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2158C70 Offset: 0x2157E70 VA: 0x182158C70
	public void remove_DownloadProgressChanged(DownloadProgressChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x21586A0 Offset: 0x21578A0 VA: 0x1821586A0
	public void add_UploadProgressChanged(UploadProgressChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2159090 Offset: 0x2158290 VA: 0x182159090
	public void remove_UploadProgressChanged(UploadProgressChangedEventHandler value) { }

	// RVA: 0x21518B0 Offset: 0x2150AB0 VA: 0x1821518B0 Slot: 16
	protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e) { }

	// RVA: 0x2151820 Offset: 0x2150A20 VA: 0x182151820 Slot: 17
	protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e) { }

	// RVA: 0x2151850 Offset: 0x2150A50 VA: 0x182151850 Slot: 18
	protected virtual void OnDownloadFileCompleted(AsyncCompletedEventArgs e) { }

	// RVA: 0x2151880 Offset: 0x2150A80 VA: 0x182151880 Slot: 19
	protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e) { }

	// RVA: 0x21519D0 Offset: 0x2150BD0 VA: 0x1821519D0 Slot: 20
	protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs e) { }

	// RVA: 0x2151940 Offset: 0x2150B40 VA: 0x182151940 Slot: 21
	protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs e) { }

	// RVA: 0x2151970 Offset: 0x2150B70 VA: 0x182151970 Slot: 22
	protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs e) { }

	// RVA: 0x2151A00 Offset: 0x2150C00 VA: 0x182151A00 Slot: 23
	protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e) { }

	// RVA: 0x21519A0 Offset: 0x2150BA0 VA: 0x1821519A0 Slot: 24
	protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e) { }

	// RVA: 0x21518E0 Offset: 0x2150AE0 VA: 0x1821518E0 Slot: 25
	protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs e) { }

	// RVA: 0x2151910 Offset: 0x2150B10 VA: 0x182151910 Slot: 26
	protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e) { }

	// RVA: 0x2153A40 Offset: 0x2152C40 VA: 0x182153A40
	private void StartOperation() { }

	// RVA: 0x21536C0 Offset: 0x21528C0 VA: 0x1821536C0
	private AsyncOperation StartAsyncOperation(object userToken) { }

	// RVA: 0x2150570 Offset: 0x214F770 VA: 0x182150570
	private void EndOperation() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Encoding get_Encoding() { }

	// RVA: 0x21593B0 Offset: 0x21585B0 VA: 0x1821593B0
	public void set_Encoding(Encoding value) { }

	// RVA: 0x21588B0 Offset: 0x2157AB0 VA: 0x1821588B0
	public string get_BaseAddress() { }

	// RVA: 0x21592A0 Offset: 0x21584A0 VA: 0x1821592A0
	public void set_BaseAddress(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ICredentials get_Credentials() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Credentials(ICredentials value) { }

	// RVA: 0x2158AB0 Offset: 0x2157CB0 VA: 0x182158AB0
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x2159470 Offset: 0x2158670 VA: 0x182159470
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x2158960 Offset: 0x2157B60 VA: 0x182158960
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x2158A30 Offset: 0x2157C30 VA: 0x182158A30
	public NameValueCollection get_QueryString() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_QueryString(NameValueCollection value) { }

	// RVA: 0x2158A90 Offset: 0x2157C90 VA: 0x182158A90
	public WebHeaderCollection get_ResponseHeaders() { }

	// RVA: 0x21589D0 Offset: 0x2157BD0 VA: 0x1821589D0
	public IWebProxy get_Proxy() { }

	// RVA: 0x2159460 Offset: 0x2158660 VA: 0x182159460
	public void set_Proxy(IWebProxy value) { }

	[CompilerGenerated]
	// RVA: 0x794D90 Offset: 0x793F90 VA: 0x180794D90
	public RequestCachePolicy get_CachePolicy() { }

	[CompilerGenerated]
	// RVA: 0x21593A0 Offset: 0x21585A0 VA: 0x1821593A0
	public void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x21589C0 Offset: 0x2157BC0 VA: 0x1821589C0
	public bool get_IsBusy() { }

	// RVA: 0x2151330 Offset: 0x2150530 VA: 0x182151330 Slot: 27
	protected virtual WebRequest GetWebRequest(Uri address) { }

	// RVA: 0x21515B0 Offset: 0x21507B0 VA: 0x1821515B0 Slot: 28
	protected virtual WebResponse GetWebResponse(WebRequest request) { }

	// RVA: 0x2151570 Offset: 0x2150770 VA: 0x182151570 Slot: 29
	protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result) { }

	[AsyncStateMachine(typeof(WebClient.<GetWebResponseTaskAsync>d__112))]
	// RVA: 0x2151480 Offset: 0x2150680 VA: 0x182151480
	private Task<WebResponse> GetWebResponseTaskAsync(WebRequest request) { }

	// RVA: 0x214EFF0 Offset: 0x214E1F0 VA: 0x18214EFF0
	public byte[] DownloadData(string address) { }

	// RVA: 0x214F020 Offset: 0x214E220 VA: 0x18214F020
	public byte[] DownloadData(Uri address) { }

	// RVA: 0x214EB20 Offset: 0x214DD20 VA: 0x18214EB20
	private byte[] DownloadDataInternal(Uri address, out WebRequest request) { }

	// RVA: 0x214F820 Offset: 0x214EA20 VA: 0x18214F820
	public void DownloadFile(string address, string fileName) { }

	// RVA: 0x214F860 Offset: 0x214EA60 VA: 0x18214F860
	public void DownloadFile(Uri address, string fileName) { }

	// RVA: 0x21529A0 Offset: 0x2151BA0 VA: 0x1821529A0
	public Stream OpenRead(string address) { }

	// RVA: 0x21525C0 Offset: 0x21517C0 VA: 0x1821525C0
	public Stream OpenRead(Uri address) { }

	// RVA: 0x2153440 Offset: 0x2152640 VA: 0x182153440
	public Stream OpenWrite(string address) { }

	// RVA: 0x2153430 Offset: 0x2152630 VA: 0x182153430
	public Stream OpenWrite(Uri address) { }

	// RVA: 0x2153470 Offset: 0x2152670 VA: 0x182153470
	public Stream OpenWrite(string address, string method) { }

	// RVA: 0x2153010 Offset: 0x2152210 VA: 0x182153010
	public Stream OpenWrite(Uri address, string method) { }

	// RVA: 0x2155740 Offset: 0x2154940 VA: 0x182155740
	public byte[] UploadData(string address, byte[] data) { }

	// RVA: 0x2155720 Offset: 0x2154920 VA: 0x182155720
	public byte[] UploadData(Uri address, byte[] data) { }

	// RVA: 0x2155500 Offset: 0x2154700 VA: 0x182155500
	public byte[] UploadData(string address, string method, byte[] data) { }

	// RVA: 0x2155550 Offset: 0x2154750 VA: 0x182155550
	public byte[] UploadData(Uri address, string method, byte[] data) { }

	// RVA: 0x2154FA0 Offset: 0x21541A0 VA: 0x182154FA0
	private byte[] UploadDataInternal(Uri address, string method, byte[] data, out WebRequest request) { }

	// RVA: 0x2151A30 Offset: 0x2150C30 VA: 0x182151A30
	private void OpenFileInternal(bool needsHeaderAndBoundary, string fileName, ref FileStream fs, ref byte[] buffer, ref byte[] formHeaderBytes, ref byte[] boundaryBytes) { }

	// RVA: 0x2156470 Offset: 0x2155670 VA: 0x182156470
	public byte[] UploadFile(string address, string fileName) { }

	// RVA: 0x2155F30 Offset: 0x2155130 VA: 0x182155F30
	public byte[] UploadFile(Uri address, string fileName) { }

	// RVA: 0x2156420 Offset: 0x2155620 VA: 0x182156420
	public byte[] UploadFile(string address, string method, string fileName) { }

	// RVA: 0x2155F50 Offset: 0x2155150 VA: 0x182155F50
	public byte[] UploadFile(Uri address, string method, string fileName) { }

	// RVA: 0x2151040 Offset: 0x2150240 VA: 0x182151040
	private byte[] GetValuesToUpload(NameValueCollection data) { }

	// RVA: 0x2157600 Offset: 0x2156800 VA: 0x182157600
	public byte[] UploadValues(string address, NameValueCollection data) { }

	// RVA: 0x21575E0 Offset: 0x21567E0 VA: 0x1821575E0
	public byte[] UploadValues(Uri address, NameValueCollection data) { }

	// RVA: 0x2157590 Offset: 0x2156790 VA: 0x182157590
	public byte[] UploadValues(string address, string method, NameValueCollection data) { }

	// RVA: 0x2157640 Offset: 0x2156840 VA: 0x182157640
	public byte[] UploadValues(Uri address, string method, NameValueCollection data) { }

	// RVA: 0x2156BE0 Offset: 0x2155DE0 VA: 0x182156BE0
	public string UploadString(string address, string data) { }

	// RVA: 0x2156E30 Offset: 0x2156030 VA: 0x182156E30
	public string UploadString(Uri address, string data) { }

	// RVA: 0x2156B90 Offset: 0x2155D90 VA: 0x182156B90
	public string UploadString(string address, string method, string data) { }

	// RVA: 0x2156C20 Offset: 0x2155E20 VA: 0x182156C20
	public string UploadString(Uri address, string method, string data) { }

	// RVA: 0x2150540 Offset: 0x214F740 VA: 0x182150540
	public string DownloadString(string address) { }

	// RVA: 0x21503F0 Offset: 0x214F5F0 VA: 0x1821503F0
	public string DownloadString(Uri address) { }

	// RVA: 0x214DB60 Offset: 0x214CD60 VA: 0x18214DB60
	private static void AbortRequest(WebRequest request) { }

	// RVA: 0x214DD50 Offset: 0x214CF50 VA: 0x18214DD50
	private void CopyHeadersTo(WebRequest request) { }

	// RVA: 0x2150B30 Offset: 0x214FD30 VA: 0x182150B30
	private Uri GetUri(string address) { }

	// RVA: 0x2150CF0 Offset: 0x214FEF0 VA: 0x182150CF0
	private Uri GetUri(Uri address) { }

	// RVA: 0x214E220 Offset: 0x214D420 VA: 0x18214E220
	private byte[] DownloadBits(WebRequest request, Stream writeStream) { }

	[AsyncStateMachine(typeof(WebClient.<DownloadBitsAsync>d__150))]
	// RVA: 0x214E150 Offset: 0x214D350 VA: 0x18214E150
	private void DownloadBitsAsync(WebRequest request, Stream writeStream, AsyncOperation asyncOp, Action<byte[], Exception, AsyncOperation> completionDelegate) { }

	// RVA: 0x2154580 Offset: 0x2153780 VA: 0x182154580
	private byte[] UploadBits(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer) { }

	[AsyncStateMachine(typeof(WebClient.<UploadBitsAsync>d__152))]
	// RVA: 0x2154470 Offset: 0x2153670 VA: 0x182154470
	private void UploadBitsAsync(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, AsyncOperation asyncOp, Action<byte[], Exception, AsyncOperation> completionDelegate) { }

	// RVA: 0x214DC80 Offset: 0x214CE80 VA: 0x18214DC80
	private static bool ByteArrayHasPrefix(byte[] prefix, byte[] byteArray) { }

	// RVA: 0x2150690 Offset: 0x214F890 VA: 0x182150690
	private string GetStringUsingEncoding(WebRequest request, byte[] data) { }

	// RVA: 0x21516F0 Offset: 0x21508F0 VA: 0x1821516F0
	private string MapToDefaultMethod(Uri address) { }

	// RVA: 0x2157D70 Offset: 0x2156F70 VA: 0x182157D70
	private static string UrlEncode(string str) { }

	// RVA: 0x2157AB0 Offset: 0x2156CB0 VA: 0x182157AB0
	private static byte[] UrlEncodeBytesToBytesInternal(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue) { }

	// RVA: 0x1856520 Offset: 0x1855720 VA: 0x181856520
	private static char IntToHex(int n) { }

	// RVA: 0x2151670 Offset: 0x2150870 VA: 0x182151670
	private static bool IsSafe(char ch) { }

	// RVA: 0x21515F0 Offset: 0x21507F0 VA: 0x1821515F0
	private void InvokeOperationCompleted(AsyncOperation asyncOp, SendOrPostCallback callback, AsyncCompletedEventArgs eventArgs) { }

	// RVA: 0x2152030 Offset: 0x2151230 VA: 0x182152030
	public void OpenReadAsync(Uri address) { }

	// RVA: 0x2152040 Offset: 0x2151240 VA: 0x182152040
	public void OpenReadAsync(Uri address, object userToken) { }

	// RVA: 0x2152D70 Offset: 0x2151F70 VA: 0x182152D70
	public void OpenWriteAsync(Uri address) { }

	// RVA: 0x21529D0 Offset: 0x2151BD0 VA: 0x1821529D0
	public void OpenWriteAsync(Uri address, string method) { }

	// RVA: 0x21529F0 Offset: 0x2151BF0 VA: 0x1821529F0
	public void OpenWriteAsync(Uri address, string method, object userToken) { }

	// RVA: 0x214FCB0 Offset: 0x214EEB0 VA: 0x18214FCB0
	private void DownloadStringAsyncCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x214FF10 Offset: 0x214F110 VA: 0x18214FF10
	public void DownloadStringAsync(Uri address) { }

	// RVA: 0x214FF20 Offset: 0x214F120 VA: 0x18214FF20
	public void DownloadStringAsync(Uri address, object userToken) { }

	// RVA: 0x214E740 Offset: 0x214D940 VA: 0x18214E740
	private void DownloadDataAsyncCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x214E860 Offset: 0x214DA60 VA: 0x18214E860
	public void DownloadDataAsync(Uri address) { }

	// RVA: 0x214E870 Offset: 0x214DA70 VA: 0x18214E870
	public void DownloadDataAsync(Uri address, object userToken) { }

	// RVA: 0x214F160 Offset: 0x214E360 VA: 0x18214F160
	private void DownloadFileAsyncCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x214F5C0 Offset: 0x214E7C0 VA: 0x18214F5C0
	public void DownloadFileAsync(Uri address, string fileName) { }

	// RVA: 0x214F270 Offset: 0x214E470 VA: 0x18214F270
	public void DownloadFileAsync(Uri address, string fileName, object userToken) { }

	// RVA: 0x21564D0 Offset: 0x21556D0 VA: 0x1821564D0
	public void UploadStringAsync(Uri address, string data) { }

	// RVA: 0x21564B0 Offset: 0x21556B0 VA: 0x1821564B0
	public void UploadStringAsync(Uri address, string method, string data) { }

	// RVA: 0x21564F0 Offset: 0x21556F0 VA: 0x1821564F0
	public void UploadStringAsync(Uri address, string method, string data, object userToken) { }

	// RVA: 0x2154F60 Offset: 0x2154160 VA: 0x182154F60
	public void UploadDataAsync(Uri address, byte[] data) { }

	// RVA: 0x2154F80 Offset: 0x2154180 VA: 0x182154F80
	public void UploadDataAsync(Uri address, string method, byte[] data) { }

	// RVA: 0x2154B20 Offset: 0x2153D20 VA: 0x182154B20
	public void UploadDataAsync(Uri address, string method, byte[] data, object userToken) { }

	// RVA: 0x2155780 Offset: 0x2154980 VA: 0x182155780
	public void UploadFileAsync(Uri address, string fileName) { }

	// RVA: 0x21557A0 Offset: 0x21549A0 VA: 0x1821557A0
	public void UploadFileAsync(Uri address, string method, string fileName) { }

	// RVA: 0x21557C0 Offset: 0x21549C0 VA: 0x1821557C0
	public void UploadFileAsync(Uri address, string method, string fileName, object userToken) { }

	// RVA: 0x2156E50 Offset: 0x2156050 VA: 0x182156E50
	public void UploadValuesAsync(Uri address, NameValueCollection data) { }

	// RVA: 0x2156E70 Offset: 0x2156070 VA: 0x182156E70
	public void UploadValuesAsync(Uri address, string method, NameValueCollection data) { }

	// RVA: 0x2156E90 Offset: 0x2156090 VA: 0x182156E90
	public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken) { }

	// RVA: 0x2150580 Offset: 0x214F780 VA: 0x182150580
	private static Exception GetExceptionToPropagate(Exception e) { }

	// RVA: 0x214DCF0 Offset: 0x214CEF0 VA: 0x18214DCF0
	public void CancelAsync() { }

	// RVA: 0x21503C0 Offset: 0x214F5C0 VA: 0x1821503C0
	public Task<string> DownloadStringTaskAsync(string address) { }

	// RVA: 0x21501D0 Offset: 0x214F3D0 VA: 0x1821501D0
	public Task<string> DownloadStringTaskAsync(Uri address) { }

	// RVA: 0x2152590 Offset: 0x2151790 VA: 0x182152590
	public Task<Stream> OpenReadTaskAsync(string address) { }

	// RVA: 0x21523A0 Offset: 0x21515A0 VA: 0x1821523A0
	public Task<Stream> OpenReadTaskAsync(Uri address) { }

	// RVA: 0x2152D90 Offset: 0x2151F90 VA: 0x182152D90
	public Task<Stream> OpenWriteTaskAsync(string address) { }

	// RVA: 0x2152DC0 Offset: 0x2151FC0 VA: 0x182152DC0
	public Task<Stream> OpenWriteTaskAsync(Uri address) { }

	// RVA: 0x2152FD0 Offset: 0x21521D0 VA: 0x182152FD0
	public Task<Stream> OpenWriteTaskAsync(string address, string method) { }

	// RVA: 0x2152DD0 Offset: 0x2151FD0 VA: 0x182152DD0
	public Task<Stream> OpenWriteTaskAsync(Uri address, string method) { }

	// RVA: 0x2156900 Offset: 0x2155B00 VA: 0x182156900
	public Task<string> UploadStringTaskAsync(string address, string data) { }

	// RVA: 0x21568E0 Offset: 0x2155AE0 VA: 0x1821568E0
	public Task<string> UploadStringTaskAsync(Uri address, string data) { }

	// RVA: 0x2156940 Offset: 0x2155B40 VA: 0x182156940
	public Task<string> UploadStringTaskAsync(string address, string method, string data) { }

	// RVA: 0x2156990 Offset: 0x2155B90 VA: 0x182156990
	public Task<string> UploadStringTaskAsync(Uri address, string method, string data) { }

	// RVA: 0x214EDD0 Offset: 0x214DFD0 VA: 0x18214EDD0
	public Task<byte[]> DownloadDataTaskAsync(string address) { }

	// RVA: 0x214EE00 Offset: 0x214E000 VA: 0x18214EE00
	public Task<byte[]> DownloadDataTaskAsync(Uri address) { }

	// RVA: 0x214F5E0 Offset: 0x214E7E0 VA: 0x18214F5E0
	public Task DownloadFileTaskAsync(string address, string fileName) { }

	// RVA: 0x214F620 Offset: 0x214E820 VA: 0x18214F620
	public Task DownloadFileTaskAsync(Uri address, string fileName) { }

	// RVA: 0x21554C0 Offset: 0x21546C0 VA: 0x1821554C0
	public Task<byte[]> UploadDataTaskAsync(string address, byte[] data) { }

	// RVA: 0x2155250 Offset: 0x2154450 VA: 0x182155250
	public Task<byte[]> UploadDataTaskAsync(Uri address, byte[] data) { }

	// RVA: 0x2155470 Offset: 0x2154670 VA: 0x182155470
	public Task<byte[]> UploadDataTaskAsync(string address, string method, byte[] data) { }

	// RVA: 0x2155270 Offset: 0x2154470 VA: 0x182155270
	public Task<byte[]> UploadDataTaskAsync(Uri address, string method, byte[] data) { }

	// RVA: 0x2155ED0 Offset: 0x21550D0 VA: 0x182155ED0
	public Task<byte[]> UploadFileTaskAsync(string address, string fileName) { }

	// RVA: 0x2155F10 Offset: 0x2155110 VA: 0x182155F10
	public Task<byte[]> UploadFileTaskAsync(Uri address, string fileName) { }

	// RVA: 0x2155E80 Offset: 0x2155080 VA: 0x182155E80
	public Task<byte[]> UploadFileTaskAsync(string address, string method, string fileName) { }

	// RVA: 0x2155C80 Offset: 0x2154E80 VA: 0x182155C80
	public Task<byte[]> UploadFileTaskAsync(Uri address, string method, string fileName) { }

	// RVA: 0x21574E0 Offset: 0x21566E0 VA: 0x1821574E0
	public Task<byte[]> UploadValuesTaskAsync(string address, NameValueCollection data) { }

	// RVA: 0x2157520 Offset: 0x2156720 VA: 0x182157520
	public Task<byte[]> UploadValuesTaskAsync(string address, string method, NameValueCollection data) { }

	// RVA: 0x2157570 Offset: 0x2156770 VA: 0x182157570
	public Task<byte[]> UploadValuesTaskAsync(Uri address, NameValueCollection data) { }

	// RVA: 0x21572E0 Offset: 0x21564E0 VA: 0x1821572E0
	public Task<byte[]> UploadValuesTaskAsync(Uri address, string method, NameValueCollection data) { }

	// RVA: -1 Offset: -1
	private void HandleCompletion<TAsyncCompletedEventArgs, TCompletionDelegate, T>(TaskCompletionSource<T> tcs, TAsyncCompletedEventArgs e, Func<TAsyncCompletedEventArgs, T> getResult, TCompletionDelegate handler, Action<WebClient, TCompletionDelegate> unregisterHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA47F0 Offset: 0xAA39F0 VA: 0x180AA47F0
	|-WebClient.HandleCompletion<object, object, object>
	|
	|-RVA: 0xAA4610 Offset: 0xAA3810 VA: 0x180AA4610
	|-WebClient.HandleCompletion<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21534B0 Offset: 0x21526B0 VA: 0x1821534B0
	private void PostProgressChanged(AsyncOperation asyncOp, WebClient.ProgressData progress) { }

	// RVA: 0x2153AF0 Offset: 0x2152CF0 VA: 0x182153AF0
	private static void ThrowIfNull(object argument, string parameterName) { }

	[CompilerGenerated]
	// RVA: 0x1C617C0 Offset: 0x1C609C0 VA: 0x181C617C0
	public bool get_AllowReadStreamBuffering() { }

	[CompilerGenerated]
	// RVA: 0x1C62310 Offset: 0x1C61510 VA: 0x181C62310
	public void set_AllowReadStreamBuffering(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C617E0 Offset: 0x1C609E0 VA: 0x181C617E0
	public bool get_AllowWriteStreamBuffering() { }

	[CompilerGenerated]
	// RVA: 0x1C62420 Offset: 0x1C61620 VA: 0x181C62420
	public void set_AllowWriteStreamBuffering(bool value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void add_WriteStreamClosed(WriteStreamClosedEventHandler value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void remove_WriteStreamClosed(WriteStreamClosedEventHandler value) { }

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	[EditorBrowsable(1)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 30
	protected virtual void OnWriteStreamClosed(WriteStreamClosedEventArgs e) { }

	// RVA: 0x2157E50 Offset: 0x2157050 VA: 0x182157E50
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2153B50 Offset: 0x2152D50 VA: 0x182153B50
	private void <StartAsyncOperation>b__78_0(object arg) { }

	[CompilerGenerated]
	// RVA: 0x2153C90 Offset: 0x2152E90 VA: 0x182153C90
	private void <StartAsyncOperation>b__78_1(object arg) { }

	[CompilerGenerated]
	// RVA: 0x2153D30 Offset: 0x2152F30 VA: 0x182153D30
	private void <StartAsyncOperation>b__78_2(object arg) { }

	[CompilerGenerated]
	// RVA: 0x2153DD0 Offset: 0x2152FD0 VA: 0x182153DD0
	private void <StartAsyncOperation>b__78_3(object arg) { }

	[CompilerGenerated]
	// RVA: 0x2153E70 Offset: 0x2153070 VA: 0x182153E70
	private void <StartAsyncOperation>b__78_4(object arg) { }

	[CompilerGenerated]
	// RVA: 0x2153F10 Offset: 0x2153110 VA: 0x182153F10
	private void <StartAsyncOperation>b__78_5(object arg) { }

	[CompilerGenerated]
	// RVA: 0x2153FB0 Offset: 0x21531B0 VA: 0x182153FB0
	private void <StartAsyncOperation>b__78_6(object arg) { }

	[CompilerGenerated]
	// RVA: 0x2154050 Offset: 0x2153250 VA: 0x182154050
	private void <StartAsyncOperation>b__78_7(object arg) { }

	[CompilerGenerated]
	// RVA: 0x21540F0 Offset: 0x21532F0 VA: 0x1821540F0
	private void <StartAsyncOperation>b__78_8(object arg) { }

	[CompilerGenerated]
	// RVA: 0x2154190 Offset: 0x2153390 VA: 0x182154190
	private void <StartAsyncOperation>b__78_9(object arg) { }

	[CompilerGenerated]
	// RVA: 0x2153BF0 Offset: 0x2152DF0 VA: 0x182153BF0
	private void <StartAsyncOperation>b__78_10(object arg) { }

	[CompilerGenerated]
	// RVA: 0x2154230 Offset: 0x2153430 VA: 0x182154230
	private void <UploadStringAsync>b__179_0(byte[] bytesResult, Exception error, AsyncOperation uploadAsyncOp) { }
}

// Namespace: System.Net
public sealed class OpenReadCompletedEventHandler : MulticastDelegate // TypeDefIndex: 5719
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, OpenReadCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, OpenReadCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public sealed class OpenWriteCompletedEventHandler : MulticastDelegate // TypeDefIndex: 5720
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, OpenWriteCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, OpenWriteCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public sealed class DownloadStringCompletedEventHandler : MulticastDelegate // TypeDefIndex: 5721
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DownloadStringCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, DownloadStringCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public sealed class DownloadDataCompletedEventHandler : MulticastDelegate // TypeDefIndex: 5722
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DownloadDataCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, DownloadDataCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public sealed class UploadStringCompletedEventHandler : MulticastDelegate // TypeDefIndex: 5723
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, UploadStringCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, UploadStringCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public sealed class UploadDataCompletedEventHandler : MulticastDelegate // TypeDefIndex: 5724
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, UploadDataCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, UploadDataCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public sealed class UploadFileCompletedEventHandler : MulticastDelegate // TypeDefIndex: 5725
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, UploadFileCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, UploadFileCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public sealed class UploadValuesCompletedEventHandler : MulticastDelegate // TypeDefIndex: 5726
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, UploadValuesCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, UploadValuesCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public sealed class DownloadProgressChangedEventHandler : MulticastDelegate // TypeDefIndex: 5727
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DownloadProgressChangedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, DownloadProgressChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public sealed class UploadProgressChangedEventHandler : MulticastDelegate // TypeDefIndex: 5728
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, UploadProgressChangedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, UploadProgressChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
[EditorBrowsable(1)]
public sealed class WriteStreamClosedEventHandler : MulticastDelegate // TypeDefIndex: 5729
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, WriteStreamClosedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, WriteStreamClosedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public class OpenReadCompletedEventArgs : AsyncCompletedEventArgs // TypeDefIndex: 5730
{
	// Fields
	private readonly Stream _result; // 0x28

	// Properties
	public Stream Result { get; }

	// Methods

	// RVA: 0x215CB90 Offset: 0x215BD90 VA: 0x18215CB90
	internal void .ctor(Stream result, Exception exception, bool cancelled, object userToken) { }

	// RVA: 0x20EF9B0 Offset: 0x20EEBB0 VA: 0x1820EF9B0
	public Stream get_Result() { }

	// RVA: 0x21615B0 Offset: 0x21607B0 VA: 0x1821615B0
	internal void .ctor() { }
}

// Namespace: System.Net
public class OpenWriteCompletedEventArgs : AsyncCompletedEventArgs // TypeDefIndex: 5731
{
	// Fields
	private readonly Stream _result; // 0x28

	// Properties
	public Stream Result { get; }

	// Methods

	// RVA: 0x215CB90 Offset: 0x215BD90 VA: 0x18215CB90
	internal void .ctor(Stream result, Exception exception, bool cancelled, object userToken) { }

	// RVA: 0x20EF9B0 Offset: 0x20EEBB0 VA: 0x1820EF9B0
	public Stream get_Result() { }

	// RVA: 0x21615E0 Offset: 0x21607E0 VA: 0x1821615E0
	internal void .ctor() { }
}

// Namespace: System.Net
public class DownloadStringCompletedEventArgs : AsyncCompletedEventArgs // TypeDefIndex: 5732
{
	// Fields
	private readonly string _result; // 0x28

	// Properties
	public string Result { get; }

	// Methods

	// RVA: 0x215CB90 Offset: 0x215BD90 VA: 0x18215CB90
	internal void .ctor(string result, Exception exception, bool cancelled, object userToken) { }

	// RVA: 0x20EF9B0 Offset: 0x20EEBB0 VA: 0x1820EF9B0
	public string get_Result() { }

	// RVA: 0x215CC30 Offset: 0x215BE30 VA: 0x18215CC30
	internal void .ctor() { }
}

// Namespace: System.Net
public class DownloadDataCompletedEventArgs : AsyncCompletedEventArgs // TypeDefIndex: 5733
{
	// Fields
	private readonly byte[] _result; // 0x28

	// Properties
	public byte[] Result { get; }

	// Methods

	// RVA: 0x215CB90 Offset: 0x215BD90 VA: 0x18215CB90
	internal void .ctor(byte[] result, Exception exception, bool cancelled, object userToken) { }

	// RVA: 0x20EF9B0 Offset: 0x20EEBB0 VA: 0x1820EF9B0
	public byte[] get_Result() { }

	// RVA: 0x215CB60 Offset: 0x215BD60 VA: 0x18215CB60
	internal void .ctor() { }
}

// Namespace: System.Net
public class UploadStringCompletedEventArgs : AsyncCompletedEventArgs // TypeDefIndex: 5734
{
	// Fields
	private readonly string _result; // 0x28

	// Properties
	public string Result { get; }

	// Methods

	// RVA: 0x215CB90 Offset: 0x215BD90 VA: 0x18215CB90
	internal void .ctor(string result, Exception exception, bool cancelled, object userToken) { }

	// RVA: 0x20EF9B0 Offset: 0x20EEBB0 VA: 0x1820EF9B0
	public string get_Result() { }

	// RVA: 0x2166DB0 Offset: 0x2165FB0 VA: 0x182166DB0
	internal void .ctor() { }
}

// Namespace: System.Net
public class UploadDataCompletedEventArgs : AsyncCompletedEventArgs // TypeDefIndex: 5735
{
	// Fields
	private readonly byte[] _result; // 0x28

	// Properties
	public byte[] Result { get; }

	// Methods

	// RVA: 0x215CB90 Offset: 0x215BD90 VA: 0x18215CB90
	internal void .ctor(byte[] result, Exception exception, bool cancelled, object userToken) { }

	// RVA: 0x20EF9B0 Offset: 0x20EEBB0 VA: 0x1820EF9B0
	public byte[] get_Result() { }

	// RVA: 0x2166CD0 Offset: 0x2165ED0 VA: 0x182166CD0
	internal void .ctor() { }
}

// Namespace: System.Net
public class UploadFileCompletedEventArgs : AsyncCompletedEventArgs // TypeDefIndex: 5736
{
	// Fields
	private readonly byte[] _result; // 0x28

	// Properties
	public byte[] Result { get; }

	// Methods

	// RVA: 0x215CB90 Offset: 0x215BD90 VA: 0x18215CB90
	internal void .ctor(byte[] result, Exception exception, bool cancelled, object userToken) { }

	// RVA: 0x20EF9B0 Offset: 0x20EEBB0 VA: 0x1820EF9B0
	public byte[] get_Result() { }

	// RVA: 0x2166D00 Offset: 0x2165F00 VA: 0x182166D00
	internal void .ctor() { }
}

// Namespace: System.Net
public class UploadValuesCompletedEventArgs : AsyncCompletedEventArgs // TypeDefIndex: 5737
{
	// Fields
	private readonly byte[] _result; // 0x28

	// Properties
	public byte[] Result { get; }

	// Methods

	// RVA: 0x215CB90 Offset: 0x215BD90 VA: 0x18215CB90
	internal void .ctor(byte[] result, Exception exception, bool cancelled, object userToken) { }

	// RVA: 0x20EF9B0 Offset: 0x20EEBB0 VA: 0x1820EF9B0
	public byte[] get_Result() { }

	// RVA: 0x2166DE0 Offset: 0x2165FE0 VA: 0x182166DE0
	internal void .ctor() { }
}

// Namespace: System.Net
public class DownloadProgressChangedEventArgs : ProgressChangedEventArgs // TypeDefIndex: 5738
{
	// Fields
	[CompilerGenerated]
	private readonly long <BytesReceived>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly long <TotalBytesToReceive>k__BackingField; // 0x28

	// Properties
	public long BytesReceived { get; }
	public long TotalBytesToReceive { get; }

	// Methods

	// RVA: 0x215CC00 Offset: 0x215BE00 VA: 0x18215CC00
	internal void .ctor(int progressPercentage, object userToken, long bytesReceived, long totalBytesToReceive) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public long get_BytesReceived() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public long get_TotalBytesToReceive() { }

	// RVA: 0x215CBD0 Offset: 0x215BDD0 VA: 0x18215CBD0
	internal void .ctor() { }
}

// Namespace: System.Net
public class UploadProgressChangedEventArgs : ProgressChangedEventArgs // TypeDefIndex: 5739
{
	// Fields
	[CompilerGenerated]
	private readonly long <BytesReceived>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly long <TotalBytesToReceive>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly long <BytesSent>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly long <TotalBytesToSend>k__BackingField; // 0x38

	// Properties
	public long BytesReceived { get; }
	public long TotalBytesToReceive { get; }
	public long BytesSent { get; }
	public long TotalBytesToSend { get; }

	// Methods

	// RVA: 0x2166D60 Offset: 0x2165F60 VA: 0x182166D60
	internal void .ctor(int progressPercentage, object userToken, long bytesSent, long totalBytesToSend, long bytesReceived, long totalBytesToReceive) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public long get_BytesReceived() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public long get_TotalBytesToReceive() { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public long get_BytesSent() { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public long get_TotalBytesToSend() { }

	// RVA: 0x2166D30 Offset: 0x2165F30 VA: 0x182166D30
	internal void .ctor() { }
}

// Namespace: System.Net
[EditorBrowsable(1)]
public class WriteStreamClosedEventArgs : EventArgs // TypeDefIndex: 5740
{
	// Properties
	[EditorBrowsable(1)]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	public Exception Error { get; }

	// Methods

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	[EditorBrowsable(1)]
	// RVA: 0x2173FB0 Offset: 0x21731B0 VA: 0x182173FB0
	public void .ctor() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public Exception get_Error() { }
}

// Namespace: System.Net
[Flags]
public enum AuthenticationSchemes // TypeDefIndex: 5741
{
	// Fields
	public int value__; // 0x0
	public const AuthenticationSchemes None = 0;
	public const AuthenticationSchemes Digest = 1;
	public const AuthenticationSchemes Negotiate = 2;
	public const AuthenticationSchemes Ntlm = 4;
	public const AuthenticationSchemes Basic = 8;
	public const AuthenticationSchemes Anonymous = 32768;
	public const AuthenticationSchemes IntegratedWindowsAuthentication = 6;
}

// Namespace: System.Net
public sealed class AuthenticationSchemeSelector : MulticastDelegate // TypeDefIndex: 5742
{
	// Methods

	// RVA: 0x20BE860 Offset: 0x20BDA60 VA: 0x1820BE860
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual AuthenticationSchemes Invoke(HttpListenerRequest httpRequest) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(HttpListenerRequest httpRequest, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual AuthenticationSchemes EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public class Authorization // TypeDefIndex: 5743
{
	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	private string[] m_ProtectionRealm; // 0x20
	private string m_ConnectionGroupId; // 0x28
	private bool m_MutualAuth; // 0x30
	internal string ModuleAuthenticationType; // 0x38

	// Properties
	public string Message { get; }
	public string ConnectionGroupId { get; }
	public bool Complete { get; }
	public string[] ProtectionRealm { get; set; }
	public bool MutuallyAuthenticated { get; set; }

	// Methods

	// RVA: 0x2159B90 Offset: 0x2158D90 VA: 0x182159B90
	public void .ctor(string token) { }

	// RVA: 0x2159C10 Offset: 0x2158E10 VA: 0x182159C10
	public void .ctor(string token, bool finished) { }

	// RVA: 0x2159AF0 Offset: 0x2158CF0 VA: 0x182159AF0
	public void .ctor(string token, bool finished, string connectionGroupId) { }

	// RVA: 0x2159CA0 Offset: 0x2158EA0 VA: 0x182159CA0
	internal void .ctor(string token, bool finished, string connectionGroupId, bool mutualAuth) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Message() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_ConnectionGroupId() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_Complete() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	internal void SetComplete(bool complete) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string[] get_ProtectionRealm() { }

	// RVA: 0x2159D50 Offset: 0x2158F50 VA: 0x182159D50
	public void set_ProtectionRealm(string[] value) { }

	// RVA: 0x2159D40 Offset: 0x2158F40 VA: 0x182159D40
	public bool get_MutuallyAuthenticated() { }

	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	public void set_MutuallyAuthenticated(bool value) { }
}

// Namespace: 
private class CredentialCache.CredentialEnumerator : IEnumerator // TypeDefIndex: 5744
{
	// Fields
	private CredentialCache m_cache; // 0x10
	private ICredentials[] m_array; // 0x18
	private int m_index; // 0x20
	private int m_version; // 0x24

	// Properties
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x215B910 Offset: 0x215AB10 VA: 0x18215B910
	internal void .ctor(CredentialCache cache, Hashtable table, Hashtable hostTable, int version) { }

	// RVA: 0x215B800 Offset: 0x215AA00 VA: 0x18215B800 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x215B740 Offset: 0x215A940 VA: 0x18215B740 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1647AF0 Offset: 0x1646CF0 VA: 0x181647AF0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
}

// Namespace: System.Net
public class CredentialCache : ICredentials, ICredentialsByHost, IEnumerable // TypeDefIndex: 5745
{
	// Fields
	private Hashtable cache; // 0x10
	private Hashtable cacheForHosts; // 0x18
	internal int m_version; // 0x20
	private int m_NumbDefaultCredInCache; // 0x24

	// Properties
	internal bool IsDefaultInCache { get; }
	public static ICredentials DefaultCredentials { get; }
	public static NetworkCredential DefaultNetworkCredentials { get; }

	// Methods

	// RVA: 0x215B730 Offset: 0x215A930 VA: 0x18215B730
	internal bool get_IsDefaultInCache() { }

	// RVA: 0x215B610 Offset: 0x215A810 VA: 0x18215B610
	public void .ctor() { }

	// RVA: 0x215A390 Offset: 0x2159590 VA: 0x18215A390
	public void Add(Uri uriPrefix, string authType, NetworkCredential cred) { }

	// RVA: 0x215A690 Offset: 0x2159890 VA: 0x18215A690
	public void Add(string host, int port, string authenticationType, NetworkCredential credential) { }

	// RVA: 0x215B480 Offset: 0x215A680 VA: 0x18215B480
	public void Remove(Uri uriPrefix, string authType) { }

	// RVA: 0x215B340 Offset: 0x215A540 VA: 0x18215B340
	public void Remove(string host, int port, string authenticationType) { }

	// RVA: 0x215AE50 Offset: 0x215A050 VA: 0x18215AE50 Slot: 4
	public NetworkCredential GetCredential(Uri uriPrefix, string authType) { }

	// RVA: 0x215AA40 Offset: 0x2159C40 VA: 0x18215AA40 Slot: 5
	public NetworkCredential GetCredential(string host, int port, string authenticationType) { }

	// RVA: 0x215B1A0 Offset: 0x215A3A0 VA: 0x18215B1A0 Slot: 6
	public IEnumerator GetEnumerator() { }

	// RVA: 0x215B690 Offset: 0x215A890 VA: 0x18215B690
	public static ICredentials get_DefaultCredentials() { }

	// RVA: 0x215B6E0 Offset: 0x215A8E0 VA: 0x18215B6E0
	public static NetworkCredential get_DefaultNetworkCredentials() { }
}

// Namespace: System.Net
internal class SystemNetworkCredential : NetworkCredential // TypeDefIndex: 5746
{
	// Fields
	internal static readonly SystemNetworkCredential defaultCredential; // 0x0

	// Methods

	// RVA: 0x2162A00 Offset: 0x2161C00 VA: 0x182162A00
	private void .ctor() { }

	// RVA: 0x21628E0 Offset: 0x2161AE0 VA: 0x1821628E0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class CredentialHostKey // TypeDefIndex: 5747
{
	// Fields
	internal string Host; // 0x10
	internal string AuthenticationType; // 0x18
	internal int Port; // 0x20
	private int m_HashCode; // 0x24
	private bool m_ComputedHashCode; // 0x28

	// Methods

	// RVA: 0x215BE00 Offset: 0x215B000 VA: 0x18215BE00
	internal void .ctor(string host, int port, string authenticationType) { }

	// RVA: 0x215BC00 Offset: 0x215AE00 VA: 0x18215BC00
	internal bool Match(string host, int port, string authenticationType) { }

	// RVA: 0x215BB50 Offset: 0x215AD50 VA: 0x18215BB50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x215BA70 Offset: 0x215AC70 VA: 0x18215BA70 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x215BC80 Offset: 0x215AE80 VA: 0x18215BC80 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net
internal class CredentialKey // TypeDefIndex: 5748
{
	// Fields
	internal Uri UriPrefix; // 0x10
	internal int UriPrefixLength; // 0x18
	internal string AuthenticationType; // 0x20
	private int m_HashCode; // 0x28
	private bool m_ComputedHashCode; // 0x2C

	// Methods

	// RVA: 0x215C440 Offset: 0x215B640 VA: 0x18215C440
	internal void .ctor(Uri uriPrefix, string authenticationType) { }

	// RVA: 0x215C120 Offset: 0x215B320 VA: 0x18215C120
	internal bool Match(Uri uri, string authenticationType) { }

	// RVA: 0x215BFD0 Offset: 0x215B1D0 VA: 0x18215BFD0
	internal bool IsPrefix(Uri uri, Uri prefixUri) { }

	// RVA: 0x215BF40 Offset: 0x215B140 VA: 0x18215BF40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x215BE50 Offset: 0x215B050 VA: 0x18215BE50 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x215C300 Offset: 0x215B500 VA: 0x18215C300 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net
public class DnsEndPoint : EndPoint // TypeDefIndex: 5749
{
	// Fields
	private string m_Host; // 0x10
	private int m_Port; // 0x18
	private AddressFamily m_Family; // 0x1C

	// Properties
	public string Host { get; }
	public override AddressFamily AddressFamily { get; }
	public int Port { get; }

	// Methods

	// RVA: 0x215CB40 Offset: 0x215BD40 VA: 0x18215CB40
	public void .ctor(string host, int port) { }

	// RVA: 0x215C920 Offset: 0x215BB20 VA: 0x18215C920
	public void .ctor(string host, int port, AddressFamily addressFamily) { }

	// RVA: 0x215C6A0 Offset: 0x215B8A0 VA: 0x18215C6A0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x215C750 Offset: 0x215B950 VA: 0x18215C750 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x215C820 Offset: 0x215BA20 VA: 0x18215C820 Slot: 3
	public override string ToString() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Host() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 4
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Port() { }
}

// Namespace: System.Net
[Serializable]
public abstract class EndPoint // TypeDefIndex: 5750
{
	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x215CCC0 Offset: 0x215BEC0 VA: 0x18215CCC0 Slot: 4
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x215CC90 Offset: 0x215BE90 VA: 0x18215CC90 Slot: 5
	public virtual SocketAddress Serialize() { }

	// RVA: 0x215CC60 Offset: 0x215BE60 VA: 0x18215CC60 Slot: 6
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net
public enum FtpStatusCode // TypeDefIndex: 5751
{
	// Fields
	public int value__; // 0x0
	public const FtpStatusCode Undefined = 0;
	public const FtpStatusCode RestartMarker = 110;
	public const FtpStatusCode ServiceTemporarilyNotAvailable = 120;
	public const FtpStatusCode DataAlreadyOpen = 125;
	public const FtpStatusCode OpeningData = 150;
	public const FtpStatusCode CommandOK = 200;
	public const FtpStatusCode CommandExtraneous = 202;
	public const FtpStatusCode DirectoryStatus = 212;
	public const FtpStatusCode FileStatus = 213;
	public const FtpStatusCode SystemType = 215;
	public const FtpStatusCode SendUserCommand = 220;
	public const FtpStatusCode ClosingControl = 221;
	public const FtpStatusCode ClosingData = 226;
	public const FtpStatusCode EnteringPassive = 227;
	public const FtpStatusCode LoggedInProceed = 230;
	public const FtpStatusCode ServerWantsSecureSession = 234;
	public const FtpStatusCode FileActionOK = 250;
	public const FtpStatusCode PathnameCreated = 257;
	public const FtpStatusCode SendPasswordCommand = 331;
	public const FtpStatusCode NeedLoginAccount = 332;
	public const FtpStatusCode FileCommandPending = 350;
	public const FtpStatusCode ServiceNotAvailable = 421;
	public const FtpStatusCode CantOpenData = 425;
	public const FtpStatusCode ConnectionClosed = 426;
	public const FtpStatusCode ActionNotTakenFileUnavailableOrBusy = 450;
	public const FtpStatusCode ActionAbortedLocalProcessingError = 451;
	public const FtpStatusCode ActionNotTakenInsufficientSpace = 452;
	public const FtpStatusCode CommandSyntaxError = 500;
	public const FtpStatusCode ArgumentSyntaxError = 501;
	public const FtpStatusCode CommandNotImplemented = 502;
	public const FtpStatusCode BadCommandSequence = 503;
	public const FtpStatusCode NotLoggedIn = 530;
	public const FtpStatusCode AccountNeeded = 532;
	public const FtpStatusCode ActionNotTakenFileUnavailable = 550;
	public const FtpStatusCode ActionAbortedUnknownPageType = 551;
	public const FtpStatusCode FileActionAborted = 552;
	public const FtpStatusCode ActionNotTakenFilenameNotAllowed = 553;
}

// Namespace: System.Net
[Obsolete("This class has been deprecated. Please use WebRequest.DefaultWebProxy instead to access and set the global default proxy. Use 'null' instead of GetEmptyWebProxy. https://go.microsoft.com/fwlink/?linkid=14202")]
public class GlobalProxySelection // TypeDefIndex: 5752
{
	// Properties
	public static IWebProxy Select { get; set; }

	// Methods

	// RVA: 0x215D1E0 Offset: 0x215C3E0 VA: 0x18215D1E0
	public static IWebProxy get_Select() { }

	// RVA: 0x215D2D0 Offset: 0x215C4D0 VA: 0x18215D2D0
	public static void set_Select(IWebProxy value) { }

	// RVA: 0x215D190 Offset: 0x215C390 VA: 0x18215D190
	public static IWebProxy GetEmptyWebProxy() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
[Serializable]
public class HttpListenerException : Win32Exception // TypeDefIndex: 5753
{
	// Properties
	public override int ErrorCode { get; }

	// Methods

	// RVA: 0x215DA30 Offset: 0x215CC30 VA: 0x18215DA30
	public void .ctor() { }

	// RVA: 0x215DAA0 Offset: 0x215CCA0 VA: 0x18215DAA0
	public void .ctor(int errorCode) { }

	// RVA: 0x215DA90 Offset: 0x215CC90 VA: 0x18215DA90
	public void .ctor(int errorCode, string message) { }

	// RVA: 0x215DAB0 Offset: 0x215CCB0 VA: 0x18215DAB0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210 Slot: 18
	public override int get_ErrorCode() { }
}

// Namespace: 
private enum HttpListenerRequestUriBuilder.ParsingResult // TypeDefIndex: 5754
{
	// Fields
	public int value__; // 0x0
	public const HttpListenerRequestUriBuilder.ParsingResult Success = 0;
	public const HttpListenerRequestUriBuilder.ParsingResult InvalidString = 1;
	public const HttpListenerRequestUriBuilder.ParsingResult EncodingError = 2;
}

// Namespace: 
private enum HttpListenerRequestUriBuilder.EncodingType // TypeDefIndex: 5755
{
	// Fields
	public int value__; // 0x0
	public const HttpListenerRequestUriBuilder.EncodingType Primary = 0;
	public const HttpListenerRequestUriBuilder.EncodingType Secondary = 1;
}

// Namespace: System.Net
internal sealed class HttpListenerRequestUriBuilder // TypeDefIndex: 5756
{
	// Fields
	private static readonly bool useCookedRequestUrl; // 0x0
	private static readonly Encoding utf8Encoding; // 0x8
	private static readonly Encoding ansiEncoding; // 0x10
	private readonly string rawUri; // 0x10
	private readonly string cookedUriScheme; // 0x18
	private readonly string cookedUriHost; // 0x20
	private readonly string cookedUriPath; // 0x28
	private readonly string cookedUriQuery; // 0x30
	private StringBuilder requestUriString; // 0x38
	private List<byte> rawOctets; // 0x40
	private string rawPath; // 0x48
	private Uri requestUri; // 0x50

	// Methods

	// RVA: 0x215F8E0 Offset: 0x215EAE0 VA: 0x18215F8E0
	private static void .cctor() { }

	// RVA: 0x215FA50 Offset: 0x215EC50 VA: 0x18215FA50
	private void .ctor(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery) { }

	// RVA: 0x215F540 Offset: 0x215E740 VA: 0x18215F540
	public static Uri GetRequestUri(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery) { }

	// RVA: 0x215EBB0 Offset: 0x215DDB0 VA: 0x18215EBB0
	private Uri Build() { }

	// RVA: 0x215E1A0 Offset: 0x215D3A0 VA: 0x18215E1A0
	private void BuildRequestUriUsingCookedPath() { }

	// RVA: 0x215E400 Offset: 0x215D600 VA: 0x18215E400
	private void BuildRequestUriUsingRawPath() { }

	// RVA: 0x215F070 Offset: 0x215E270 VA: 0x18215F070
	private static Encoding GetEncoding(HttpListenerRequestUriBuilder.EncodingType type) { }

	// RVA: 0x215E920 Offset: 0x215DB20 VA: 0x18215E920
	private HttpListenerRequestUriBuilder.ParsingResult BuildRequestUriUsingRawPath(Encoding encoding) { }

	// RVA: 0x215F750 Offset: 0x215E950 VA: 0x18215F750
	private HttpListenerRequestUriBuilder.ParsingResult ParseRawPath(Encoding encoding) { }

	// RVA: 0x215DEB0 Offset: 0x215D0B0 VA: 0x18215DEB0
	private bool AppendUnicodeCodePointValuePercentEncoded(string codePoint) { }

	// RVA: 0x215DAD0 Offset: 0x215CCD0 VA: 0x18215DAD0
	private bool AddPercentEncodedOctetToRawOctetsList(Encoding encoding, string escapedCharacter) { }

	// RVA: 0x215ECB0 Offset: 0x215DEB0 VA: 0x18215ECB0
	private bool EmptyDecodeAndAppendRawOctetsList(Encoding encoding) { }

	// RVA: 0x215DC90 Offset: 0x215CE90 VA: 0x18215DC90
	private static void AppendOctetsPercentEncoded(StringBuilder target, IEnumerable<byte> octets) { }

	// RVA: 0x215F100 Offset: 0x215E300 VA: 0x18215F100
	private static string GetOctetsAsString(IEnumerable<byte> octets) { }

	// RVA: 0x215F3B0 Offset: 0x215E5B0 VA: 0x18215F3B0
	private static string GetPath(string uriString) { }

	// RVA: 0x215DC30 Offset: 0x215CE30 VA: 0x18215DC30
	private static string AddSlashToAsteriskOnlyPath(string path) { }

	// RVA: 0x215F740 Offset: 0x215E940 VA: 0x18215F740
	private void LogWarning(string methodName, string message, object[] args) { }
}

// Namespace: System.Net
public enum HttpRequestHeader // TypeDefIndex: 5757
{
	// Fields
	public int value__; // 0x0
	public const HttpRequestHeader CacheControl = 0;
	public const HttpRequestHeader Connection = 1;
	public const HttpRequestHeader Date = 2;
	public const HttpRequestHeader KeepAlive = 3;
	public const HttpRequestHeader Pragma = 4;
	public const HttpRequestHeader Trailer = 5;
	public const HttpRequestHeader TransferEncoding = 6;
	public const HttpRequestHeader Upgrade = 7;
	public const HttpRequestHeader Via = 8;
	public const HttpRequestHeader Warning = 9;
	public const HttpRequestHeader Allow = 10;
	public const HttpRequestHeader ContentLength = 11;
	public const HttpRequestHeader ContentType = 12;
	public const HttpRequestHeader ContentEncoding = 13;
	public const HttpRequestHeader ContentLanguage = 14;
	public const HttpRequestHeader ContentLocation = 15;
	public const HttpRequestHeader ContentMd5 = 16;
	public const HttpRequestHeader ContentRange = 17;
	public const HttpRequestHeader Expires = 18;
	public const HttpRequestHeader LastModified = 19;
	public const HttpRequestHeader Accept = 20;
	public const HttpRequestHeader AcceptCharset = 21;
	public const HttpRequestHeader AcceptEncoding = 22;
	public const HttpRequestHeader AcceptLanguage = 23;
	public const HttpRequestHeader Authorization = 24;
	public const HttpRequestHeader Cookie = 25;
	public const HttpRequestHeader Expect = 26;
	public const HttpRequestHeader From = 27;
	public const HttpRequestHeader Host = 28;
	public const HttpRequestHeader IfMatch = 29;
	public const HttpRequestHeader IfModifiedSince = 30;
	public const HttpRequestHeader IfNoneMatch = 31;
	public const HttpRequestHeader IfRange = 32;
	public const HttpRequestHeader IfUnmodifiedSince = 33;
	public const HttpRequestHeader MaxForwards = 34;
	public const HttpRequestHeader ProxyAuthorization = 35;
	public const HttpRequestHeader Referer = 36;
	public const HttpRequestHeader Range = 37;
	public const HttpRequestHeader Te = 38;
	public const HttpRequestHeader Translate = 39;
	public const HttpRequestHeader UserAgent = 40;
}

// Namespace: System.Net
public enum HttpResponseHeader // TypeDefIndex: 5758
{
	// Fields
	public int value__; // 0x0
	public const HttpResponseHeader CacheControl = 0;
	public const HttpResponseHeader Connection = 1;
	public const HttpResponseHeader Date = 2;
	public const HttpResponseHeader KeepAlive = 3;
	public const HttpResponseHeader Pragma = 4;
	public const HttpResponseHeader Trailer = 5;
	public const HttpResponseHeader TransferEncoding = 6;
	public const HttpResponseHeader Upgrade = 7;
	public const HttpResponseHeader Via = 8;
	public const HttpResponseHeader Warning = 9;
	public const HttpResponseHeader Allow = 10;
	public const HttpResponseHeader ContentLength = 11;
	public const HttpResponseHeader ContentType = 12;
	public const HttpResponseHeader ContentEncoding = 13;
	public const HttpResponseHeader ContentLanguage = 14;
	public const HttpResponseHeader ContentLocation = 15;
	public const HttpResponseHeader ContentMd5 = 16;
	public const HttpResponseHeader ContentRange = 17;
	public const HttpResponseHeader Expires = 18;
	public const HttpResponseHeader LastModified = 19;
	public const HttpResponseHeader AcceptRanges = 20;
	public const HttpResponseHeader Age = 21;
	public const HttpResponseHeader ETag = 22;
	public const HttpResponseHeader Location = 23;
	public const HttpResponseHeader ProxyAuthenticate = 24;
	public const HttpResponseHeader RetryAfter = 25;
	public const HttpResponseHeader Server = 26;
	public const HttpResponseHeader SetCookie = 27;
	public const HttpResponseHeader Vary = 28;
	public const HttpResponseHeader WwwAuthenticate = 29;
}

// Namespace: System.Net
public interface IAuthenticationModule // TypeDefIndex: 5759
{
	// Properties
	public abstract bool CanPreAuthenticate { get; }
	public abstract string AuthenticationType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_CanPreAuthenticate();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_AuthenticationType();
}

// Namespace: System.Net
public interface ICertificatePolicy // TypeDefIndex: 5760
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);
}

// Namespace: System.Net
public interface ICredentials // TypeDefIndex: 5761
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NetworkCredential GetCredential(Uri uri, string authType);
}

// Namespace: System.Net
public interface ICredentialsByHost // TypeDefIndex: 5762
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NetworkCredential GetCredential(string host, int port, string authenticationType);
}

// Namespace: System.Net
public class IPHostEntry // TypeDefIndex: 5763
{
	// Fields
	private string hostName; // 0x10
	private string[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	// Properties
	public string HostName { get; set; }
	public string[] Aliases { get; set; }
	public IPAddress[] AddressList { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_HostName() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_HostName(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string[] get_Aliases() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Aliases(string[] value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IPAddress[] get_AddressList() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x590DF0 Offset: 0x58FFF0 VA: 0x180590DF0
	public void .ctor() { }
}

// Namespace: System.Net
internal interface IWebProxyFinder : IDisposable // TypeDefIndex: 5764
{
	// Properties
	public abstract bool IsValid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool GetProxies(Uri destination, out IList<string> proxyList);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Abort();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsValid();
}

// Namespace: System.Net
public interface IWebRequestCreate // TypeDefIndex: 5765
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract WebRequest Create(Uri uri);
}

// Namespace: System.Net
internal static class IntPtrHelper // TypeDefIndex: 5766
{
	// Methods

	// RVA: 0x215FC90 Offset: 0x215EE90 VA: 0x18215FC90
	internal static IntPtr Add(IntPtr a, int b) { }

	// RVA: 0x215FCB0 Offset: 0x215EEB0 VA: 0x18215FCB0
	internal static long Subtract(IntPtr a, IntPtr b) { }
}

// Namespace: System.Net
internal class InternalException : SystemException // TypeDefIndex: 5767
{
	// Methods

	// RVA: 0x15E0800 Offset: 0x15DFA00 VA: 0x1815E0800
	internal void .ctor() { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	internal void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Net
internal static class NclUtilities // TypeDefIndex: 5768
{
	// Fields
	private static ContextCallback s_ContextRelativeDemandCallback; // 0x0
	private static IPAddress[] _LocalAddresses; // 0x8
	private static object _LocalAddressesLock; // 0x10
	private const int HostNameBufferLength = 256;
	internal static string _LocalDomainName; // 0x18

	// Properties
	internal static bool HasShutdownStarted { get; }
	internal static ContextCallback ContextRelativeDemandCallback { get; }
	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }

	// Methods

	// RVA: 0x2160850 Offset: 0x215FA50 VA: 0x182160850
	internal static bool IsThreadPoolLow() { }

	// RVA: 0x2160930 Offset: 0x215FB30 VA: 0x182160930
	internal static bool get_HasShutdownStarted() { }

	// RVA: 0x2160760 Offset: 0x215F960 VA: 0x182160760
	internal static bool IsCredentialFailure(SecurityStatus error) { }

	// RVA: 0x2160730 Offset: 0x215F930 VA: 0x182160730
	internal static bool IsClientFault(SecurityStatus error) { }

	// RVA: 0x2160880 Offset: 0x215FA80 VA: 0x182160880
	internal static ContextCallback get_ContextRelativeDemandCallback() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DemandCallback(object state) { }

	// RVA: 0x2160610 Offset: 0x215F810 VA: 0x182160610
	internal static bool GuessWhetherHostIsLoopback(string host) { }

	// RVA: 0x2160790 Offset: 0x215F990 VA: 0x182160790
	internal static bool IsFatal(Exception exception) { }

	// RVA: 0x21606A0 Offset: 0x215F8A0 VA: 0x1821606A0
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x21605C0 Offset: 0x215F7C0 VA: 0x1821605C0
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x2160A10 Offset: 0x215FC10 VA: 0x182160A10
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x2160970 Offset: 0x215FB70 VA: 0x182160970
	private static object get_LocalAddressesLock() { }
}

// Namespace: System.Net
internal static class NclConstants // TypeDefIndex: 5769
{
	// Fields
	internal static readonly object Sentinel; // 0x0
	internal static readonly object[] EmptyObjectArray; // 0x8
	internal static readonly Uri[] EmptyUriArray; // 0x10
	internal static readonly byte[] CRLF; // 0x18
	internal static readonly byte[] ChunkTerminator; // 0x20

	// Methods

	// RVA: 0x2160470 Offset: 0x215F670 VA: 0x182160470
	private static void .cctor() { }
}

// Namespace: System.Net
internal struct InterlockedGate // TypeDefIndex: 5770
{
	// Fields
	private int m_State; // 0x0
	internal const int Open = 0;
	internal const int Triggering = 1;
	internal const int Triggered = 2;
	internal const int Signaling = 3;
	internal const int Signaled = 4;
	internal const int Completed = 5;

	// Methods

	// RVA: 0x169ECA0 Offset: 0x169DEA0 VA: 0x18169ECA0
	internal void Reset() { }

	// RVA: 0x215FEE0 Offset: 0x215F0E0 VA: 0x18215FEE0
	internal bool Trigger(bool exclusive) { }

	// RVA: 0x215FE70 Offset: 0x215F070 VA: 0x18215FE70
	internal bool StartTriggering(bool exclusive) { }

	// RVA: 0x215FD90 Offset: 0x215EF90 VA: 0x18215FD90
	internal void FinishTriggering() { }

	// RVA: 0x215FE00 Offset: 0x215F000 VA: 0x18215FE00
	internal bool StartSignaling(bool exclusive) { }

	// RVA: 0x215FD20 Offset: 0x215EF20 VA: 0x18215FD20
	internal void FinishSignaling() { }

	// RVA: 0x215FCF0 Offset: 0x215EEF0 VA: 0x18215FCF0
	internal bool Complete() { }
}

// Namespace: System.Net
internal static class ValidationHelper // TypeDefIndex: 5771
{
	// Fields
	public static string[] EmptyArray; // 0x0
	internal static readonly char[] InvalidMethodChars; // 0x8
	internal static readonly char[] InvalidParamChars; // 0x10

	// Methods

	// RVA: 0x2167060 Offset: 0x2166260 VA: 0x182167060
	public static string[] MakeEmptyArrayNull(string[] stringArray) { }

	// RVA: 0x2167070 Offset: 0x2166270 VA: 0x182167070
	public static string MakeStringNull(string stringValue) { }

	// RVA: 0x2166E10 Offset: 0x2166010 VA: 0x182166E10
	public static string ExceptionMessage(Exception exception) { }

	// RVA: 0x2167080 Offset: 0x2166280 VA: 0x182167080
	public static string ToString(object objectValue) { }

	// RVA: 0x2166F00 Offset: 0x2166100 VA: 0x182166F00
	public static string HashString(object objectValue) { }

	// RVA: 0x2166FE0 Offset: 0x21661E0 VA: 0x182166FE0
	public static bool IsInvalidHttpString(string stringValue) { }

	// RVA: 0x2166FD0 Offset: 0x21661D0 VA: 0x182166FD0
	public static bool IsBlankString(string stringValue) { }

	// RVA: 0x214CBE0 Offset: 0x214BDE0 VA: 0x18214CBE0
	public static bool ValidateTcpPort(int port) { }

	// RVA: 0x214B910 Offset: 0x214AB10 VA: 0x18214B910
	public static bool ValidateRange(int actual, int fromAllowed, int toAllowed) { }

	// RVA: 0x21672A0 Offset: 0x21664A0 VA: 0x1821672A0
	internal static void ValidateSegment(ArraySegment<byte> segment) { }

	// RVA: 0x2167410 Offset: 0x2166610 VA: 0x182167410
	private static void .cctor() { }
}

// Namespace: System.Net
internal static class ExceptionHelper // TypeDefIndex: 5772
{
	// Properties
	internal static NotImplementedException MethodNotImplementedException { get; }
	internal static NotImplementedException PropertyNotImplementedException { get; }
	internal static WebException TimeoutException { get; }
	internal static NotSupportedException MethodNotSupportedException { get; }
	internal static NotSupportedException PropertyNotSupportedException { get; }
	internal static WebException IsolatedException { get; }
	internal static WebException RequestAbortedException { get; }
	internal static WebException CacheEntryNotFoundException { get; }
	internal static WebException RequestProhibitedByCachePolicyException { get; }

	// Methods

	// RVA: 0x215CE60 Offset: 0x215C060 VA: 0x18215CE60
	internal static NotImplementedException get_MethodNotImplementedException() { }

	// RVA: 0x215CF40 Offset: 0x215C140 VA: 0x18215CF40
	internal static NotImplementedException get_PropertyNotImplementedException() { }

	// RVA: 0x215D120 Offset: 0x215C320 VA: 0x18215D120
	internal static WebException get_TimeoutException() { }

	// RVA: 0x215CED0 Offset: 0x215C0D0 VA: 0x18215CED0
	internal static NotSupportedException get_MethodNotSupportedException() { }

	// RVA: 0x215CFB0 Offset: 0x215C1B0 VA: 0x18215CFB0
	internal static NotSupportedException get_PropertyNotSupportedException() { }

	// RVA: 0x215CD70 Offset: 0x215BF70 VA: 0x18215CD70
	internal static WebException get_IsolatedException() { }

	// RVA: 0x215D020 Offset: 0x215C220 VA: 0x18215D020
	internal static WebException get_RequestAbortedException() { }

	// RVA: 0x215CCF0 Offset: 0x215BEF0 VA: 0x18215CCF0
	internal static WebException get_CacheEntryNotFoundException() { }

	// RVA: 0x215D0A0 Offset: 0x215C2A0 VA: 0x18215D0A0
	internal static WebException get_RequestProhibitedByCachePolicyException() { }
}

// Namespace: System.Net
internal enum WindowsInstallationType // TypeDefIndex: 5773
{
	// Fields
	public int value__; // 0x0
	public const WindowsInstallationType Unknown = 0;
	public const WindowsInstallationType Client = 1;
	public const WindowsInstallationType Server = 2;
	public const WindowsInstallationType ServerCore = 3;
	public const WindowsInstallationType Embedded = 4;
}

// Namespace: System.Net
internal enum SecurityStatus // TypeDefIndex: 5774
{
	// Fields
	public int value__; // 0x0
	public const SecurityStatus OK = 0;
	public const SecurityStatus ContinueNeeded = 590610;
	public const SecurityStatus CompleteNeeded = 590611;
	public const SecurityStatus CompAndContinue = 590612;
	public const SecurityStatus ContextExpired = 590615;
	public const SecurityStatus CredentialsNeeded = 590624;
	public const SecurityStatus Renegotiate = 590625;
	public const SecurityStatus OutOfMemory = -2146893056;
	public const SecurityStatus InvalidHandle = -2146893055;
	public const SecurityStatus Unsupported = -2146893054;
	public const SecurityStatus TargetUnknown = -2146893053;
	public const SecurityStatus InternalError = -2146893052;
	public const SecurityStatus PackageNotFound = -2146893051;
	public const SecurityStatus NotOwner = -2146893050;
	public const SecurityStatus CannotInstall = -2146893049;
	public const SecurityStatus InvalidToken = -2146893048;
	public const SecurityStatus CannotPack = -2146893047;
	public const SecurityStatus QopNotSupported = -2146893046;
	public const SecurityStatus NoImpersonation = -2146893045;
	public const SecurityStatus LogonDenied = -2146893044;
	public const SecurityStatus UnknownCredentials = -2146893043;
	public const SecurityStatus NoCredentials = -2146893042;
	public const SecurityStatus MessageAltered = -2146893041;
	public const SecurityStatus OutOfSequence = -2146893040;
	public const SecurityStatus NoAuthenticatingAuthority = -2146893039;
	public const SecurityStatus IncompleteMessage = -2146893032;
	public const SecurityStatus IncompleteCredentials = -2146893024;
	public const SecurityStatus BufferNotEnough = -2146893023;
	public const SecurityStatus WrongPrincipal = -2146893022;
	public const SecurityStatus TimeSkew = -2146893020;
	public const SecurityStatus UntrustedRoot = -2146893019;
	public const SecurityStatus IllegalMessage = -2146893018;
	public const SecurityStatus CertUnknown = -2146893017;
	public const SecurityStatus CertExpired = -2146893016;
	public const SecurityStatus AlgorithmMismatch = -2146893007;
	public const SecurityStatus SecurityQosFailed = -2146893006;
	public const SecurityStatus SmartcardLogonRequired = -2146892994;
	public const SecurityStatus UnsupportedPreauth = -2146892989;
	public const SecurityStatus BadBinding = -2146892986;
}

// Namespace: System.Net
internal enum ContentTypeValues // TypeDefIndex: 5775
{
	// Fields
	public int value__; // 0x0
	public const ContentTypeValues ChangeCipherSpec = 20;
	public const ContentTypeValues Alert = 21;
	public const ContentTypeValues HandShake = 22;
	public const ContentTypeValues AppData = 23;
	public const ContentTypeValues Unrecognized = 255;
}

// Namespace: System.Net
internal enum ContextAttribute // TypeDefIndex: 5776
{
	// Fields
	public int value__; // 0x0
	public const ContextAttribute Sizes = 0;
	public const ContextAttribute Names = 1;
	public const ContextAttribute Lifespan = 2;
	public const ContextAttribute DceInfo = 3;
	public const ContextAttribute StreamSizes = 4;
	public const ContextAttribute Authority = 6;
	public const ContextAttribute PackageInfo = 10;
	public const ContextAttribute NegotiationInfo = 12;
	public const ContextAttribute UniqueBindings = 25;
	public const ContextAttribute EndpointBindings = 26;
	public const ContextAttribute ClientSpecifiedSpn = 27;
	public const ContextAttribute RemoteCertificate = 83;
	public const ContextAttribute LocalCertificate = 84;
	public const ContextAttribute RootStore = 85;
	public const ContextAttribute IssuerListInfoEx = 89;
	public const ContextAttribute ConnectionInfo = 90;
	public const ContextAttribute UiInfo = 104;
}

// Namespace: System.Net
internal enum Endianness // TypeDefIndex: 5777
{
	// Fields
	public int value__; // 0x0
	public const Endianness Network = 0;
	public const Endianness Native = 16;
}

// Namespace: System.Net
internal enum CredentialUse // TypeDefIndex: 5778
{
	// Fields
	public int value__; // 0x0
	public const CredentialUse Inbound = 1;
	public const CredentialUse Outbound = 2;
	public const CredentialUse Both = 3;
}

// Namespace: System.Net
internal enum BufferType // TypeDefIndex: 5779
{
	// Fields
	public int value__; // 0x0
	public const BufferType Empty = 0;
	public const BufferType Data = 1;
	public const BufferType Token = 2;
	public const BufferType Parameters = 3;
	public const BufferType Missing = 4;
	public const BufferType Extra = 5;
	public const BufferType Trailer = 6;
	public const BufferType Header = 7;
	public const BufferType Padding = 9;
	public const BufferType Stream = 10;
	public const BufferType ChannelBindings = 14;
	public const BufferType TargetHost = 16;
	public const BufferType ReadOnlyFlag = -2147483648;
	public const BufferType ReadOnlyWithChecksum = 268435456;
}

// Namespace: System.Net
internal enum ChainPolicyType // TypeDefIndex: 5780
{
	// Fields
	public int value__; // 0x0
	public const ChainPolicyType Base = 1;
	public const ChainPolicyType Authenticode = 2;
	public const ChainPolicyType Authenticode_TS = 3;
	public const ChainPolicyType SSL = 4;
	public const ChainPolicyType BasicConstraints = 5;
	public const ChainPolicyType NtAuth = 6;
}

// Namespace: System.Net
internal enum IgnoreCertProblem // TypeDefIndex: 5781
{
	// Fields
	public int value__; // 0x0
	public const IgnoreCertProblem not_time_valid = 1;
	public const IgnoreCertProblem ctl_not_time_valid = 2;
	public const IgnoreCertProblem not_time_nested = 4;
	public const IgnoreCertProblem invalid_basic_constraints = 8;
	public const IgnoreCertProblem all_not_time_valid = 7;
	public const IgnoreCertProblem allow_unknown_ca = 16;
	public const IgnoreCertProblem wrong_usage = 32;
	public const IgnoreCertProblem invalid_name = 64;
	public const IgnoreCertProblem invalid_policy = 128;
	public const IgnoreCertProblem end_rev_unknown = 256;
	public const IgnoreCertProblem ctl_signer_rev_unknown = 512;
	public const IgnoreCertProblem ca_rev_unknown = 1024;
	public const IgnoreCertProblem root_rev_unknown = 2048;
	public const IgnoreCertProblem all_rev_unknown = 3840;
	public const IgnoreCertProblem none = 4095;
}

// Namespace: System.Net
internal enum CertUsage // TypeDefIndex: 5782
{
	// Fields
	public int value__; // 0x0
	public const CertUsage MatchTypeAnd = 0;
	public const CertUsage MatchTypeOr = 1;
}

// Namespace: System.Net
internal enum CertificateEncoding // TypeDefIndex: 5783
{
	// Fields
	public int value__; // 0x0
	public const CertificateEncoding Zero = 0;
	public const CertificateEncoding X509AsnEncoding = 1;
	public const CertificateEncoding X509NdrEncoding = 2;
	public const CertificateEncoding Pkcs7AsnEncoding = 65536;
	public const CertificateEncoding Pkcs7NdrEncoding = 131072;
	public const CertificateEncoding AnyAsnEncoding = 65537;
}

// Namespace: System.Net
internal enum CertificateProblem // TypeDefIndex: 5784
{
	// Fields
	public int value__; // 0x0
	public const CertificateProblem OK = 0;
	public const CertificateProblem TrustNOSIGNATURE = -2146762496;
	public const CertificateProblem CertEXPIRED = -2146762495;
	public const CertificateProblem CertVALIDITYPERIODNESTING = -2146762494;
	public const CertificateProblem CertROLE = -2146762493;
	public const CertificateProblem CertPATHLENCONST = -2146762492;
	public const CertificateProblem CertCRITICAL = -2146762491;
	public const CertificateProblem CertPURPOSE = -2146762490;
	public const CertificateProblem CertISSUERCHAINING = -2146762489;
	public const CertificateProblem CertMALFORMED = -2146762488;
	public const CertificateProblem CertUNTRUSTEDROOT = -2146762487;
	public const CertificateProblem CertCHAINING = -2146762486;
	public const CertificateProblem CertREVOKED = -2146762484;
	public const CertificateProblem CertUNTRUSTEDTESTROOT = -2146762483;
	public const CertificateProblem CertREVOCATION_FAILURE = -2146762482;
	public const CertificateProblem CertCN_NO_MATCH = -2146762481;
	public const CertificateProblem CertWRONG_USAGE = -2146762480;
	public const CertificateProblem TrustEXPLICITDISTRUST = -2146762479;
	public const CertificateProblem CertUNTRUSTEDCA = -2146762478;
	public const CertificateProblem CertINVALIDPOLICY = -2146762477;
	public const CertificateProblem CertINVALIDNAME = -2146762476;
	public const CertificateProblem CryptNOREVOCATIONCHECK = -2146885614;
	public const CertificateProblem CryptREVOCATIONOFFLINE = -2146885613;
	public const CertificateProblem TrustSYSTEMERROR = -2146869247;
	public const CertificateProblem TrustNOSIGNERCERT = -2146869246;
	public const CertificateProblem TrustCOUNTERSIGNER = -2146869245;
	public const CertificateProblem TrustCERTSIGNATURE = -2146869244;
	public const CertificateProblem TrustTIMESTAMP = -2146869243;
	public const CertificateProblem TrustBADDIGEST = -2146869232;
	public const CertificateProblem TrustBASICCONSTRAINTS = -2146869223;
	public const CertificateProblem TrustFINANCIALCRITERIA = -2146869218;
}

// Namespace: System.Net
internal class SecChannelBindings // TypeDefIndex: 5785
{
	// Fields
	internal int dwInitiatorAddrType; // 0x10
	internal int cbInitiatorLength; // 0x14
	internal int dwInitiatorOffset; // 0x18
	internal int dwAcceptorAddrType; // 0x1C
	internal int cbAcceptorLength; // 0x20
	internal int dwAcceptorOffset; // 0x24
	internal int cbApplicationDataLength; // 0x28
	internal int dwApplicationDataOffset; // 0x2C

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
internal class WebRequestPrefixElement // TypeDefIndex: 5786
{
	// Fields
	public string Prefix; // 0x10
	internal IWebRequestCreate creator; // 0x18
	internal Type creatorType; // 0x20

	// Properties
	public IWebRequestCreate Creator { get; set; }

	// Methods

	// RVA: 0x2173DC0 Offset: 0x2172FC0 VA: 0x182173DC0
	public IWebRequestCreate get_Creator() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Creator(IWebRequestCreate value) { }

	// RVA: 0x2173C10 Offset: 0x2172E10 VA: 0x182173C10
	public void .ctor(string P, Type creatorType) { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string P, IWebRequestCreate C) { }
}

// Namespace: System.Net
internal sealed class HttpAbortDelegate : MulticastDelegate // TypeDefIndex: 5787
{
	// Methods

	// RVA: 0x12052D0 Offset: 0x12044D0 VA: 0x1812052D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual bool Invoke(HttpWebRequest request, WebException webException) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(HttpWebRequest request, WebException webException, AsyncCallback callback, object object) { }

	// RVA: 0x409E60 Offset: 0x409060 VA: 0x180409E60 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
internal static class HttpKnownHeaderNames // TypeDefIndex: 5788
{
	// Fields
	public const string CacheControl = "Cache-Control";
	public const string Connection = "Connection";
	public const string Date = "Date";
	public const string KeepAlive = "Keep-Alive";
	public const string Pragma = "Pragma";
	public const string ProxyConnection = "Proxy-Connection";
	public const string Trailer = "Trailer";
	public const string TransferEncoding = "Transfer-Encoding";
	public const string Upgrade = "Upgrade";
	public const string Via = "Via";
	public const string Warning = "Warning";
	public const string ContentLength = "Content-Length";
	public const string ContentType = "Content-Type";
	public const string ContentDisposition = "Content-Disposition";
	public const string ContentEncoding = "Content-Encoding";
	public const string ContentLanguage = "Content-Language";
	public const string ContentLocation = "Content-Location";
	public const string ContentRange = "Content-Range";
	public const string Expires = "Expires";
	public const string LastModified = "Last-Modified";
	public const string Age = "Age";
	public const string Location = "Location";
	public const string ProxyAuthenticate = "Proxy-Authenticate";
	public const string RetryAfter = "Retry-After";
	public const string Server = "Server";
	public const string SetCookie = "Set-Cookie";
	public const string SetCookie2 = "Set-Cookie2";
	public const string Vary = "Vary";
	public const string WWWAuthenticate = "WWW-Authenticate";
	public const string Accept = "Accept";
	public const string AcceptCharset = "Accept-Charset";
	public const string AcceptEncoding = "Accept-Encoding";
	public const string AcceptLanguage = "Accept-Language";
	public const string Authorization = "Authorization";
	public const string Cookie = "Cookie";
	public const string Cookie2 = "Cookie2";
	public const string Expect = "Expect";
	public const string From = "From";
	public const string Host = "Host";
	public const string IfMatch = "If-Match";
	public const string IfModifiedSince = "If-Modified-Since";
	public const string IfNoneMatch = "If-None-Match";
	public const string IfRange = "If-Range";
	public const string IfUnmodifiedSince = "If-Unmodified-Since";
	public const string MaxForwards = "Max-Forwards";
	public const string ProxyAuthorization = "Proxy-Authorization";
	public const string Referer = "Referer";
	public const string Range = "Range";
	public const string UserAgent = "User-Agent";
	public const string ContentMD5 = "Content-MD5";
	public const string ETag = "ETag";
	public const string TE = "TE";
	public const string Allow = "Allow";
	public const string AcceptRanges = "Accept-Ranges";
	public const string P3P = "P3P";
	public const string XPoweredBy = "X-Powered-By";
	public const string XAspNetVersion = "X-AspNet-Version";
	public const string SecWebSocketKey = "Sec-WebSocket-Key";
	public const string SecWebSocketExtensions = "Sec-WebSocket-Extensions";
	public const string SecWebSocketAccept = "Sec-WebSocket-Accept";
	public const string Origin = "Origin";
	public const string SecWebSocketProtocol = "Sec-WebSocket-Protocol";
	public const string SecWebSocketVersion = "Sec-WebSocket-Version";
}

// Namespace: System.Net
public sealed class HttpContinueDelegate : MulticastDelegate // TypeDefIndex: 5789
{
	// Methods

	// RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }

	// RVA: 0x215D9A0 Offset: 0x215CBA0 VA: 0x18215D9A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int StatusCode, WebHeaderCollection httpHeaders, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
internal enum HttpWriteMode // TypeDefIndex: 5790
{
	// Fields
	public int value__; // 0x0
	public const HttpWriteMode Unknown = 0;
	public const HttpWriteMode ContentLength = 1;
	public const HttpWriteMode Chunked = 2;
	public const HttpWriteMode Buffer = 3;
	public const HttpWriteMode None = 4;
}

// Namespace: System.Net
internal sealed class UnlockConnectionDelegate : MulticastDelegate // TypeDefIndex: 5791
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

// Namespace: System.Net
internal enum HttpBehaviour // TypeDefIndex: 5792
{
	// Fields
	public byte value__; // 0x0
	public const HttpBehaviour Unknown = 0;
	public const HttpBehaviour HTTP10 = 1;
	public const HttpBehaviour HTTP11PartiallyCompliant = 2;
	public const HttpBehaviour HTTP11 = 3;
}

// Namespace: System.Net
internal enum HttpProcessingResult // TypeDefIndex: 5793
{
	// Fields
	public int value__; // 0x0
	public const HttpProcessingResult Continue = 0;
	public const HttpProcessingResult ReadWait = 1;
	public const HttpProcessingResult WriteWait = 2;
}

// Namespace: System.Net
internal class KnownHttpVerb // TypeDefIndex: 5794
{
	// Fields
	internal string Name; // 0x10
	internal bool RequireContentBody; // 0x18
	internal bool ContentBodyNotAllowed; // 0x19
	internal bool ConnectRequest; // 0x1A
	internal bool ExpectNoContentResponse; // 0x1B
	private static ListDictionary NamedHeaders; // 0x0
	internal static KnownHttpVerb Get; // 0x8
	internal static KnownHttpVerb Connect; // 0x10
	internal static KnownHttpVerb Head; // 0x18
	internal static KnownHttpVerb Put; // 0x20
	internal static KnownHttpVerb Post; // 0x28
	internal static KnownHttpVerb MkCol; // 0x30

	// Methods

	// RVA: 0x2160410 Offset: 0x215F610 VA: 0x182160410
	internal void .ctor(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse) { }

	// RVA: 0x2160080 Offset: 0x215F280 VA: 0x182160080
	private static void .cctor() { }

	// RVA: 0x215FF50 Offset: 0x215F150 VA: 0x18215FF50
	public bool Equals(KnownHttpVerb verb) { }

	// RVA: 0x215FF90 Offset: 0x215F190 VA: 0x18215FF90
	public static KnownHttpVerb Parse(string name) { }
}

// Namespace: System.Net
internal class HttpProtocolUtils // TypeDefIndex: 5795
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x215FBF0 Offset: 0x215EDF0 VA: 0x18215FBF0
	internal static DateTime string2date(string S) { }

	// RVA: 0x215FB50 Offset: 0x215ED50 VA: 0x18215FB50
	internal static string date2string(DateTime D) { }
}

// Namespace: System.Net
internal enum TriState // TypeDefIndex: 5796
{
	// Fields
	public int value__; // 0x0
	public const TriState Unspecified = -1;
	public const TriState False = 0;
	public const TriState True = 1;
}

// Namespace: System.Net
internal enum DefaultPorts // TypeDefIndex: 5797
{
	// Fields
	public int value__; // 0x0
	public const DefaultPorts DEFAULT_FTP_PORT = 21;
	public const DefaultPorts DEFAULT_GOPHER_PORT = 70;
	public const DefaultPorts DEFAULT_HTTP_PORT = 80;
	public const DefaultPorts DEFAULT_HTTPS_PORT = 443;
	public const DefaultPorts DEFAULT_NNTP_PORT = 119;
	public const DefaultPorts DEFAULT_SMTP_PORT = 25;
	public const DefaultPorts DEFAULT_TELNET_PORT = 23;
}

// Namespace: System.Net
internal struct hostent // TypeDefIndex: 5798
{
	// Fields
	public IntPtr h_name; // 0x0
	public IntPtr h_aliases; // 0x8
	public short h_addrtype; // 0x10
	public short h_length; // 0x12
	public IntPtr h_addr_list; // 0x18
}

// Namespace: System.Net
internal struct Blob // TypeDefIndex: 5799
{
	// Fields
	public int cbSize; // 0x0
	public int pBlobData; // 0x4
}

// Namespace: System.Net
internal class SplitWritesState // TypeDefIndex: 5800
{
	// Fields
	private const int c_SplitEncryptedBuffersSize = 65536;
	private BufferOffsetSize[] _UserBuffers; // 0x10
	private int _Index; // 0x18
	private int _LastBufferConsumed; // 0x1C
	private BufferOffsetSize[] _RealBuffers; // 0x20

	// Properties
	internal bool IsDone { get; }

	// Methods

	// RVA: 0x2162850 Offset: 0x2161A50 VA: 0x182162850
	internal void .ctor(BufferOffsetSize[] buffers) { }

	// RVA: 0x2162880 Offset: 0x2161A80 VA: 0x182162880
	internal bool get_IsDone() { }

	// RVA: 0x21624D0 Offset: 0x21616D0 VA: 0x1821624D0
	internal BufferOffsetSize[] GetNextBuffers() { }
}

// Namespace: System.Net
[Flags]
public enum NetworkAccess // TypeDefIndex: 5801
{
	// Fields
	public int value__; // 0x0
	public const NetworkAccess Accept = 128;
	public const NetworkAccess Connect = 64;
}

// Namespace: System.Net
public class NetworkCredential : ICredentials, ICredentialsByHost // TypeDefIndex: 5802
{
	// Fields
	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Properties
	public string UserName { get; set; }
	public string Password { get; set; }
	public SecureString SecurePassword { get; set; }
	public string Domain { get; set; }

	// Methods

	// RVA: 0x2160F60 Offset: 0x2160160 VA: 0x182160F60
	public void .ctor() { }

	// RVA: 0x2161340 Offset: 0x2160540 VA: 0x182161340
	public void .ctor(string userName, string password) { }

	// RVA: 0x2161210 Offset: 0x2160410 VA: 0x182161210
	public void .ctor(string userName, SecureString password) { }

	// RVA: 0x2161050 Offset: 0x2160250 VA: 0x182161050
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x2161110 Offset: 0x2160310 VA: 0x182161110
	public void .ctor(string userName, SecureString password, string domain) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_UserName() { }

	// RVA: 0x2161550 Offset: 0x2160750 VA: 0x182161550
	public void set_UserName(string value) { }

	// RVA: 0x2160F50 Offset: 0x2160150 VA: 0x182160F50
	public string get_Password() { }

	// RVA: 0x21614B0 Offset: 0x21606B0 VA: 0x1821614B0
	public void set_Password(string value) { }

	// RVA: 0x2161430 Offset: 0x2160630 VA: 0x182161430
	public SecureString get_SecurePassword() { }

	// RVA: 0x21614D0 Offset: 0x21606D0 VA: 0x1821614D0
	public void set_SecurePassword(SecureString value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Domain() { }

	// RVA: 0x2161450 Offset: 0x2160650 VA: 0x182161450
	public void set_Domain(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string InternalGetUserName() { }

	// RVA: 0x2160F50 Offset: 0x2160150 VA: 0x182160F50
	internal string InternalGetPassword() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal SecureString InternalGetSecurePassword() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal string InternalGetDomain() { }

	// RVA: 0x2160EF0 Offset: 0x21600F0 VA: 0x182160EF0
	internal string InternalGetDomainUserName() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 4
	public NetworkCredential GetCredential(Uri uri, string authType) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 5
	public NetworkCredential GetCredential(string host, int port, string authenticationType) { }
}

// Namespace: System.Net
[Serializable]
public class ProtocolViolationException : InvalidOperationException, ISerializable // TypeDefIndex: 5803
{
	// Methods

	// RVA: 0x2161670 Offset: 0x2160870 VA: 0x182161670
	public void .ctor() { }

	// RVA: 0x2161680 Offset: 0x2160880 VA: 0x182161680
	public void .ctor(string message) { }

	// RVA: 0x15A17F0 Offset: 0x15A09F0 VA: 0x1815A17F0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2161650 Offset: 0x2160850 VA: 0x182161650 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2161650 Offset: 0x2160850 VA: 0x182161650 Slot: 15
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Net
[DefaultMember("Item")]
public class SocketAddress // TypeDefIndex: 5804
{
	// Fields
	internal const int IPv6AddressSize = 28;
	internal const int IPv4AddressSize = 16;
	internal int m_Size; // 0x10
	internal byte[] m_Buffer; // 0x18
	private const int WriteableOffset = 2;
	private const int MaxSize = 32;
	private bool m_changed; // 0x20
	private int m_hash; // 0x24

	// Properties
	public AddressFamily Family { get; }
	public int Size { get; }
	public byte Item { get; set; }

	// Methods

	// RVA: 0x2162380 Offset: 0x2161580 VA: 0x182162380
	public AddressFamily get_Family() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_Size() { }

	// RVA: 0x21623C0 Offset: 0x21615C0 VA: 0x1821623C0
	public byte get_Item(int offset) { }

	// RVA: 0x2162440 Offset: 0x2161640 VA: 0x182162440
	public void set_Item(int offset, byte value) { }

	// RVA: 0x2161FE0 Offset: 0x21611E0 VA: 0x182161FE0
	public void .ctor(AddressFamily family) { }

	// RVA: 0x2161FF0 Offset: 0x21611F0 VA: 0x182161FF0
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x2162100 Offset: 0x2161300 VA: 0x182162100
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x2161F80 Offset: 0x2161180 VA: 0x182161F80
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x2161A10 Offset: 0x2160C10 VA: 0x182161A10
	internal IPAddress GetIPAddress() { }

	// RVA: 0x2161C70 Offset: 0x2160E70 VA: 0x182161C70
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x2161690 Offset: 0x2160890 VA: 0x182161690
	internal void CopyAddressSizeIntoBuffer() { }

	// RVA: 0x21618B0 Offset: 0x2160AB0 VA: 0x1821618B0
	internal int GetAddressSizeOffset() { }

	// RVA: 0x2161D10 Offset: 0x2160F10 VA: 0x182161D10
	internal void SetSize(IntPtr ptr) { }

	// RVA: 0x2161770 Offset: 0x2160970 VA: 0x182161770 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x21618E0 Offset: 0x2160AE0 VA: 0x1821618E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2161D40 Offset: 0x2160F40 VA: 0x182161D40 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net
public abstract class TransportContext // TypeDefIndex: 5805
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ChannelBinding GetChannelBinding(ChannelBindingKind kind);

	// RVA: 0x2162AF0 Offset: 0x2161CF0 VA: 0x182162AF0 Slot: 5
	public virtual IEnumerable<TokenBinding> GetTlsTokenBindings() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net
internal class CachedTransportContext : TransportContext // TypeDefIndex: 5806
{
	// Fields
	private ChannelBinding binding; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(ChannelBinding binding) { }

	// RVA: 0x2159DC0 Offset: 0x2158FC0 VA: 0x182159DC0 Slot: 4
	public override ChannelBinding GetChannelBinding(ChannelBindingKind kind) { }
}

// Namespace: System.Net
public enum TransportType // TypeDefIndex: 5807
{
	// Fields
	public int value__; // 0x0
	public const TransportType Udp = 1;
	public const TransportType Connectionless = 1;
	public const TransportType Tcp = 2;
	public const TransportType ConnectionOriented = 2;
	public const TransportType All = 3;
}

// Namespace: System.Net
[Serializable]
public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 5808
{
	// Fields
	private WebExceptionStatus m_Status; // 0x90
	private WebResponse m_Response; // 0x98
	private WebExceptionInternalStatus m_InternalStatus; // 0xA0

	// Properties
	public WebExceptionStatus Status { get; }
	public WebResponse Response { get; }
	internal WebExceptionInternalStatus InternalStatus { get; }

	// Methods

	// RVA: 0x2167820 Offset: 0x2166A20 VA: 0x182167820
	public void .ctor() { }

	// RVA: 0x2167D00 Offset: 0x2166F00 VA: 0x182167D00
	public void .ctor(string message) { }

	// RVA: 0x2167A80 Offset: 0x2166C80 VA: 0x182167A80
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x2167840 Offset: 0x2166A40 VA: 0x182167840
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x2167910 Offset: 0x2166B10 VA: 0x182167910
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x2167AA0 Offset: 0x2166CA0 VA: 0x182167AA0
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x2167B50 Offset: 0x2166D50 VA: 0x182167B50
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x21679C0 Offset: 0x2166BC0 VA: 0x1821679C0
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x2167C20 Offset: 0x2166E20 VA: 0x182167C20
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x21678E0 Offset: 0x2166AE0 VA: 0x1821678E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21677F0 Offset: 0x21669F0 VA: 0x1821677F0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2161650 Offset: 0x2160850 VA: 0x182161650 Slot: 15
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210
	public WebExceptionStatus get_Status() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public WebResponse get_Response() { }

	// RVA: 0x5E7ED0 Offset: 0x5E70D0 VA: 0x1805E7ED0
	internal WebExceptionInternalStatus get_InternalStatus() { }
}

// Namespace: System.Net
internal enum WebExceptionInternalStatus // TypeDefIndex: 5809
{
	// Fields
	public int value__; // 0x0
	public const WebExceptionInternalStatus RequestFatal = 0;
	public const WebExceptionInternalStatus ServicePointFatal = 1;
	public const WebExceptionInternalStatus Recoverable = 2;
	public const WebExceptionInternalStatus Isolated = 3;
}

// Namespace: System.Net
public enum WebExceptionStatus // TypeDefIndex: 5810
{
	// Fields
	public int value__; // 0x0
	public const WebExceptionStatus Success = 0;
	public const WebExceptionStatus NameResolutionFailure = 1;
	public const WebExceptionStatus ConnectFailure = 2;
	public const WebExceptionStatus ReceiveFailure = 3;
	public const WebExceptionStatus SendFailure = 4;
	public const WebExceptionStatus PipelineFailure = 5;
	public const WebExceptionStatus RequestCanceled = 6;
	public const WebExceptionStatus ProtocolError = 7;
	public const WebExceptionStatus ConnectionClosed = 8;
	public const WebExceptionStatus TrustFailure = 9;
	public const WebExceptionStatus SecureChannelFailure = 10;
	public const WebExceptionStatus ServerProtocolViolation = 11;
	public const WebExceptionStatus KeepAliveFailure = 12;
	public const WebExceptionStatus Pending = 13;
	public const WebExceptionStatus Timeout = 14;
	public const WebExceptionStatus ProxyNameResolutionFailure = 15;
	public const WebExceptionStatus UnknownError = 16;
	public const WebExceptionStatus MessageLengthLimitExceeded = 17;
	public const WebExceptionStatus CacheEntryNotFound = 18;
	public const WebExceptionStatus RequestProhibitedByCachePolicy = 19;
	public const WebExceptionStatus RequestProhibitedByProxy = 20;
}

// Namespace: System.Net
internal static class WebExceptionMapping // TypeDefIndex: 5811
{
	// Fields
	private static readonly string[] s_Mapping; // 0x0

	// Methods

	// RVA: 0x21675F0 Offset: 0x21667F0 VA: 0x1821675F0
	internal static string GetWebStatusString(WebExceptionStatus status) { }

	// RVA: 0x2167790 Offset: 0x2166990 VA: 0x182167790
	private static void .cctor() { }
}

// Namespace: System.Net
internal enum WebHeaderCollectionType // TypeDefIndex: 5812
{
	// Fields
	public ushort value__; // 0x0
	public const WebHeaderCollectionType Unknown = 0;
	public const WebHeaderCollectionType WebRequest = 1;
	public const WebHeaderCollectionType WebResponse = 2;
	public const WebHeaderCollectionType HttpWebRequest = 3;
	public const WebHeaderCollectionType HttpWebResponse = 4;
	public const WebHeaderCollectionType HttpListenerRequest = 5;
	public const WebHeaderCollectionType HttpListenerResponse = 6;
	public const WebHeaderCollectionType FtpWebRequest = 7;
	public const WebHeaderCollectionType FtpWebResponse = 8;
	public const WebHeaderCollectionType FileWebRequest = 9;
	public const WebHeaderCollectionType FileWebResponse = 10;
}

// Namespace: 
internal static class WebHeaderCollection.HeaderEncoding // TypeDefIndex: 5813
{
	// Methods

	// RVA: 0x215D750 Offset: 0x215C950 VA: 0x18215D750
	internal static string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x215D630 Offset: 0x215C830 VA: 0x18215D630
	internal static string GetString(byte* pBytes, int byteCount) { }

	// RVA: 0x215D4A0 Offset: 0x215C6A0 VA: 0x18215D4A0
	internal static int GetByteCount(string myString) { }

	// RVA: 0x215D4C0 Offset: 0x215C6C0 VA: 0x18215D4C0
	internal static void GetBytes(string myString, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x215D560 Offset: 0x215C760 VA: 0x18215D560
	internal static byte[] GetBytes(string myString) { }

	[FriendAccessAllowed]
	// RVA: 0x215D320 Offset: 0x215C520 VA: 0x18215D320
	internal static string DecodeUtf8FromString(string input) { }
}

// Namespace: 
private enum WebHeaderCollection.RfcChar // TypeDefIndex: 5814
{
	// Fields
	public byte value__; // 0x0
	public const WebHeaderCollection.RfcChar High = 0;
	public const WebHeaderCollection.RfcChar Reg = 1;
	public const WebHeaderCollection.RfcChar Ctl = 2;
	public const WebHeaderCollection.RfcChar CR = 3;
	public const WebHeaderCollection.RfcChar LF = 4;
	public const WebHeaderCollection.RfcChar WS = 5;
	public const WebHeaderCollection.RfcChar Colon = 6;
	public const WebHeaderCollection.RfcChar Delim = 7;
}

// Namespace: System.Net
[DefaultMember("Item")]
[ComVisible(True)]
[Serializable]
public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 5815
{
	// Fields
	private const int ApproxAveHeaderLineSize = 30;
	private const int ApproxHighAvgNumHeaders = 16;
	private static readonly HeaderInfoTable HInfo; // 0x0
	private string[] m_CommonHeaders; // 0x68
	private int m_NumCommonHeaders; // 0x70
	private static readonly string[] s_CommonHeaderNames; // 0x8
	private static readonly sbyte[] s_CommonHeaderHints; // 0x10
	private const int c_AcceptRanges = 0;
	private const int c_ContentLength = 1;
	private const int c_CacheControl = 2;
	private const int c_ContentType = 3;
	private const int c_Date = 4;
	private const int c_Expires = 5;
	private const int c_ETag = 6;
	private const int c_LastModified = 7;
	private const int c_Location = 8;
	private const int c_ProxyAuthenticate = 9;
	private const int c_P3P = 10;
	private const int c_SetCookie2 = 11;
	private const int c_SetCookie = 12;
	private const int c_Server = 13;
	private const int c_Via = 14;
	private const int c_WwwAuthenticate = 15;
	private const int c_XAspNetVersion = 16;
	private const int c_XPoweredBy = 17;
	private NameValueCollection m_InnerCollection; // 0x78
	private WebHeaderCollectionType m_Type; // 0x80
	private static readonly char[] HttpTrimCharacters; // 0x18
	private static WebHeaderCollection.RfcChar[] RfcCharMap; // 0x20

	// Properties
	internal string ContentLength { get; }
	internal string CacheControl { get; }
	internal string ContentType { get; }
	internal string Date { get; }
	internal string Expires { get; }
	internal string ETag { get; }
	internal string LastModified { get; }
	internal string Location { get; }
	internal string ProxyAuthenticate { get; }
	internal string SetCookie2 { get; }
	internal string SetCookie { get; }
	internal string Server { get; }
	internal string Via { get; }
	private NameValueCollection InnerCollection { get; }
	private bool AllowHttpRequestHeader { get; }
	internal bool AllowHttpResponseHeader { get; }
	public string Item { get; set; }
	public string Item { get; set; }
	public override int Count { get; }
	public override NameObjectCollectionBase.KeysCollection Keys { get; }
	public override string[] AllKeys { get; }

	// Methods

	// RVA: 0x216CAB0 Offset: 0x216BCB0 VA: 0x18216CAB0
	internal string get_ContentLength() { }

	// RVA: 0x216CA00 Offset: 0x216BC00 VA: 0x18216CA00
	internal string get_CacheControl() { }

	// RVA: 0x216CB60 Offset: 0x216BD60 VA: 0x18216CB60
	internal string get_ContentType() { }

	// RVA: 0x216CC50 Offset: 0x216BE50 VA: 0x18216CC50
	internal string get_Date() { }

	// RVA: 0x216CDB0 Offset: 0x216BFB0 VA: 0x18216CDB0
	internal string get_Expires() { }

	// RVA: 0x216CD00 Offset: 0x216BF00 VA: 0x18216CD00
	internal string get_ETag() { }

	// RVA: 0x216D190 Offset: 0x216C390 VA: 0x18216D190
	internal string get_LastModified() { }

	// RVA: 0x216D240 Offset: 0x216C440 VA: 0x18216D240
	internal string get_Location() { }

	// RVA: 0x216D300 Offset: 0x216C500 VA: 0x18216D300
	internal string get_ProxyAuthenticate() { }

	// RVA: 0x216D460 Offset: 0x216C660 VA: 0x18216D460
	internal string get_SetCookie2() { }

	// RVA: 0x216D510 Offset: 0x216C710 VA: 0x18216D510
	internal string get_SetCookie() { }

	// RVA: 0x216D3B0 Offset: 0x216C5B0 VA: 0x18216D3B0
	internal string get_Server() { }

	// RVA: 0x216D5C0 Offset: 0x216C7C0 VA: 0x18216D5C0
	internal string get_Via() { }

	// RVA: 0x2169D10 Offset: 0x2168F10 VA: 0x182169D10
	private void NormalizeCommonHeaders() { }

	// RVA: 0x216CE60 Offset: 0x216C060 VA: 0x18216CE60
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x2168760 Offset: 0x2167960 VA: 0x182168760
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x216C980 Offset: 0x216BB80 VA: 0x18216C980
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x216C9C0 Offset: 0x216BBC0 VA: 0x18216C9C0
	internal bool get_AllowHttpResponseHeader() { }

	// RVA: 0x216D050 Offset: 0x216C250 VA: 0x18216D050
	public string get_Item(HttpRequestHeader header) { }

	// RVA: 0x216D860 Offset: 0x216CA60 VA: 0x18216D860
	public void set_Item(HttpRequestHeader header, string value) { }

	// RVA: 0x216CF10 Offset: 0x216C110 VA: 0x18216CF10
	public string get_Item(HttpResponseHeader header) { }

	// RVA: 0x216D670 Offset: 0x216C870 VA: 0x18216D670
	public void set_Item(HttpResponseHeader header, string value) { }

	// RVA: 0x2167FA0 Offset: 0x21671A0 VA: 0x182167FA0
	public void Add(HttpRequestHeader header, string value) { }

	// RVA: 0x2168560 Offset: 0x2167760 VA: 0x182168560
	public void Add(HttpResponseHeader header, string value) { }

	// RVA: 0x216B8A0 Offset: 0x216AAA0 VA: 0x18216B8A0
	public void Set(HttpRequestHeader header, string value) { }

	// RVA: 0x216B6A0 Offset: 0x216A8A0 VA: 0x18216B6A0
	public void Set(HttpResponseHeader header, string value) { }

	// RVA: 0x216B270 Offset: 0x216A470 VA: 0x18216B270
	internal void SetInternal(HttpResponseHeader header, string value) { }

	// RVA: 0x216AF40 Offset: 0x216A140 VA: 0x18216AF40
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x216AE40 Offset: 0x216A040 VA: 0x18216AE40
	public void Remove(HttpResponseHeader header) { }

	// RVA: 0x2167DF0 Offset: 0x2166FF0 VA: 0x182167DF0
	protected void AddWithoutValidate(string headerName, string headerValue) { }

	// RVA: 0x216B160 Offset: 0x216A360 VA: 0x18216B160
	internal void SetAddVerified(string name, string value) { }

	// RVA: 0x2167D80 Offset: 0x2166F80 VA: 0x182167D80
	internal void AddInternal(string name, string value) { }

	// RVA: 0x2168800 Offset: 0x2167A00 VA: 0x182168800
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x216ADE0 Offset: 0x2169FE0 VA: 0x18216ADE0
	internal void RemoveInternal(string name) { }

	// RVA: 0x2168DF0 Offset: 0x2167FF0 VA: 0x182168DF0
	internal void CheckUpdate(string name, string value) { }

	// RVA: 0x2167D20 Offset: 0x2166F20 VA: 0x182167D20
	private void AddInternalNotCommon(string name, string value) { }

	// RVA: 0x2168870 Offset: 0x2167A70 VA: 0x182168870
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x2169C10 Offset: 0x2168E10 VA: 0x182169C10
	internal static bool IsValidToken(string token) { }

	// RVA: 0x2126400 Offset: 0x2125600 VA: 0x182126400
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x216BC30 Offset: 0x216AE30 VA: 0x18216BC30
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x21680B0 Offset: 0x21672B0 VA: 0x1821680B0 Slot: 18
	public override void Add(string name, string value) { }

	// RVA: 0x2168270 Offset: 0x2167470 VA: 0x182168270
	public void Add(string header) { }

	// RVA: 0x216B9B0 Offset: 0x216ABB0 VA: 0x18216B9B0 Slot: 21
	public override void Set(string name, string value) { }

	// RVA: 0x216B460 Offset: 0x216A660 VA: 0x18216B460
	internal void SetInternal(string name, string value) { }

	// RVA: 0x216B040 Offset: 0x216A240 VA: 0x18216B040 Slot: 22
	public override void Remove(string name) { }

	// RVA: 0x21693D0 Offset: 0x21685D0 VA: 0x1821693D0 Slot: 20
	public override string[] GetValues(string header) { }

	// RVA: 0x216BF50 Offset: 0x216B150 VA: 0x18216BF50 Slot: 3
	public override string ToString() { }

	// RVA: 0x216BFA0 Offset: 0x216B1A0 VA: 0x18216BFA0
	internal string ToString(bool forTrace) { }

	// RVA: 0x2168EF0 Offset: 0x21680F0 VA: 0x182168EF0
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x216BE70 Offset: 0x216B070 VA: 0x18216BE70
	public byte[] ToByteArray() { }

	// RVA: 0x2169B50 Offset: 0x2168D50 VA: 0x182169B50
	public static bool IsRestricted(string headerName) { }

	// RVA: 0x2169A60 Offset: 0x2168C60 VA: 0x182169A60
	public static bool IsRestricted(string headerName, bool response) { }

	// RVA: 0x216C7F0 Offset: 0x216B9F0 VA: 0x18216C7F0
	public void .ctor() { }

	// RVA: 0x216C850 Offset: 0x216BA50 VA: 0x18216C850
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x216C420 Offset: 0x216B620 VA: 0x18216C420
	internal void .ctor(NameValueCollection cc) { }

	// RVA: 0x216C630 Offset: 0x216B830 VA: 0x18216C630
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public override void OnDeserialization(object sender) { }

	// RVA: 0x2169250 Offset: 0x2168450 VA: 0x182169250 Slot: 11
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x216A940 Offset: 0x2169B40 VA: 0x18216A940
	internal DataParseStatus ParseHeaders(byte[] buffer, int size, ref int unparsed, ref int totalResponseHeadersLength, int maximumResponseHeadersLength, ref WebParseError parseError) { }

	// RVA: 0x2169E40 Offset: 0x2169040 VA: 0x182169E40
	internal DataParseStatus ParseHeadersStrict(byte[] buffer, int size, ref int unparsed, ref int totalResponseHeadersLength, int maximumResponseHeadersLength, ref WebParseError parseError) { }

	// RVA: 0x216BC00 Offset: 0x216AE00 VA: 0x18216BC00 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2169670 Offset: 0x2168870 VA: 0x182169670 Slot: 19
	public override string Get(string name) { }

	// RVA: 0x2169190 Offset: 0x2168390 VA: 0x182169190 Slot: 13
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x216CC10 Offset: 0x216BE10 VA: 0x18216CC10 Slot: 14
	public override int get_Count() { }

	// RVA: 0x216D140 Offset: 0x216C340 VA: 0x18216D140 Slot: 15
	public override NameObjectCollectionBase.KeysCollection get_Keys() { }

	// RVA: 0x2169A30 Offset: 0x2168C30 VA: 0x182169A30 Slot: 17
	internal override bool InternalHasKeys() { }

	// RVA: 0x21699E0 Offset: 0x2168BE0 VA: 0x1821699E0 Slot: 23
	public override string Get(int index) { }

	// RVA: 0x2169620 Offset: 0x2168820 VA: 0x182169620 Slot: 24
	public override string[] GetValues(int index) { }

	// RVA: 0x2169200 Offset: 0x2168400 VA: 0x182169200 Slot: 25
	public override string GetKey(int index) { }

	// RVA: 0x216C930 Offset: 0x216BB30 VA: 0x18216C930 Slot: 26
	public override string[] get_AllKeys() { }

	// RVA: 0x2168EA0 Offset: 0x21680A0 VA: 0x182168EA0 Slot: 16
	public override void Clear() { }

	// RVA: 0x216BFF0 Offset: 0x216B1F0 VA: 0x18216BFF0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class CaseInsensitiveAscii : IEqualityComparer, IComparer // TypeDefIndex: 5816
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x215A1C0 Offset: 0x21593C0 VA: 0x18215A1C0 Slot: 5
	public int GetHashCode(object myObject) { }

	// RVA: 0x2159DD0 Offset: 0x2158FD0 VA: 0x182159DD0 Slot: 6
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x215A0D0 Offset: 0x21592D0 VA: 0x18215A0D0
	private int FastGetHashCode(string myString) { }

	// RVA: 0x2159F50 Offset: 0x2159150 VA: 0x182159F50 Slot: 4
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x215A2E0 Offset: 0x21594E0 VA: 0x18215A2E0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class HostHeaderString // TypeDefIndex: 5817
{
	// Fields
	private bool m_Converted; // 0x10
	private string m_String; // 0x18
	private byte[] m_Bytes; // 0x20

	// Properties
	internal string String { get; set; }
	internal int ByteCount { get; }
	internal byte[] Bytes { get; }

	// Methods

	// RVA: 0x215D920 Offset: 0x215CB20 VA: 0x18215D920
	internal void .ctor() { }

	// RVA: 0x215D8E0 Offset: 0x215CAE0 VA: 0x18215D8E0
	internal void .ctor(string s) { }

	// RVA: 0x215D8C0 Offset: 0x215CAC0 VA: 0x18215D8C0
	private void Init(string s) { }

	// RVA: 0x215D790 Offset: 0x215C990 VA: 0x18215D790
	private void Convert() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string get_String() { }

	// RVA: 0x215D8C0 Offset: 0x215CAC0 VA: 0x18215D8C0
	internal void set_String(string value) { }

	// RVA: 0x215D950 Offset: 0x215CB50 VA: 0x18215D950
	internal int get_ByteCount() { }

	// RVA: 0x215D980 Offset: 0x215CB80 VA: 0x18215D980
	internal byte[] get_Bytes() { }

	// RVA: 0x215D860 Offset: 0x215CA60 VA: 0x18215D860
	internal void Copy(byte[] destBytes, int destByteIndex) { }
}

// Namespace: System.Net
[Usage(109, AllowMultiple = True, Inherited = False)]
[Serializable]
public sealed class WebPermissionAttribute : CodeAccessSecurityAttribute // TypeDefIndex: 5818
{
	// Fields
	private object m_accept; // 0x18
	private object m_connect; // 0x20

	// Properties
	public string Connect { get; set; }
	public string Accept { get; set; }
	public string ConnectPattern { get; set; }
	public string AcceptPattern { get; set; }

	// Methods

	// RVA: 0x216DCF0 Offset: 0x216CEF0 VA: 0x18216DCF0
	public void .ctor(SecurityAction action) { }

	// RVA: 0x216DF70 Offset: 0x216D170 VA: 0x18216DF70
	public string get_Connect() { }

	// RVA: 0x216E4B0 Offset: 0x216D6B0 VA: 0x18216E4B0
	public void set_Connect(string value) { }

	// RVA: 0x216DE10 Offset: 0x216D010 VA: 0x18216DE10
	public string get_Accept() { }

	// RVA: 0x216E1B0 Offset: 0x216D3B0 VA: 0x18216E1B0
	public void set_Accept(string value) { }

	// RVA: 0x216DE60 Offset: 0x216D060 VA: 0x18216DE60
	public string get_ConnectPattern() { }

	// RVA: 0x216E2C0 Offset: 0x216D4C0 VA: 0x18216E2C0
	public void set_ConnectPattern(string value) { }

	// RVA: 0x216DD00 Offset: 0x216CF00 VA: 0x18216DD00
	public string get_AcceptPattern() { }

	// RVA: 0x216DFC0 Offset: 0x216D1C0 VA: 0x18216DFC0
	public void set_AcceptPattern(string value) { }

	// RVA: 0x216D960 Offset: 0x216CB60 VA: 0x18216D960 Slot: 7
	public override IPermission CreatePermission() { }
}

// Namespace: System.Net
[Serializable]
internal class DelayedRegex // TypeDefIndex: 5819
{
	// Fields
	private Regex _AsRegex; // 0x10
	private string _AsString; // 0x18

	// Properties
	internal Regex AsRegex { get; }

	// Methods

	// RVA: 0x215C500 Offset: 0x215B700 VA: 0x18215C500
	internal void .ctor(string regexString) { }

	// RVA: 0x215C580 Offset: 0x215B780 VA: 0x18215C580
	internal void .ctor(Regex regex) { }

	// RVA: 0x215C600 Offset: 0x215B800 VA: 0x18215C600
	internal Regex get_AsRegex() { }

	// RVA: 0x215C4B0 Offset: 0x215B6B0 VA: 0x18215C4B0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net
[Serializable]
public sealed class WebPermission : CodeAccessPermission, IUnrestrictedPermission // TypeDefIndex: 5820
{
	// Fields
	private bool m_noRestriction; // 0x10
	[OptionalField]
	private bool m_UnrestrictedConnect; // 0x11
	[OptionalField]
	private bool m_UnrestrictedAccept; // 0x12
	private ArrayList m_connectList; // 0x18
	private ArrayList m_acceptList; // 0x20
	internal const string MatchAll = ".*";
	private static Regex s_MatchAllRegex; // 0x0

	// Properties
	internal static Regex MatchAllRegex { get; }
	public IEnumerator ConnectList { get; }
	public IEnumerator AcceptList { get; }

	// Methods

	// RVA: 0x2172430 Offset: 0x2171630 VA: 0x182172430
	internal static Regex get_MatchAllRegex() { }

	// RVA: 0x21720A0 Offset: 0x21712A0 VA: 0x1821720A0
	public IEnumerator get_ConnectList() { }

	// RVA: 0x2171D10 Offset: 0x2170F10 VA: 0x182171D10
	public IEnumerator get_AcceptList() { }

	// RVA: 0x2171970 Offset: 0x2170B70 VA: 0x182171970
	public void .ctor(PermissionState state) { }

	// RVA: 0x21717C0 Offset: 0x21709C0 VA: 0x1821717C0
	internal void .ctor(bool unrestricted) { }

	// RVA: 0x21718F0 Offset: 0x2170AF0 VA: 0x1821718F0
	public void .ctor() { }

	// RVA: 0x2171AA0 Offset: 0x2170CA0 VA: 0x182171AA0
	internal void .ctor(NetworkAccess access) { }

	// RVA: 0x2171B40 Offset: 0x2170D40 VA: 0x182171B40
	public void .ctor(NetworkAccess access, Regex uriRegex) { }

	// RVA: 0x2171A00 Offset: 0x2170C00 VA: 0x182171A00
	public void .ctor(NetworkAccess access, string uriString) { }

	// RVA: 0x2171850 Offset: 0x2170A50 VA: 0x182171850
	internal void .ctor(NetworkAccess access, Uri uri) { }

	// RVA: 0x216EE50 Offset: 0x216E050 VA: 0x18216EE50
	public void AddPermission(NetworkAccess access, string uriString) { }

	// RVA: 0x216E9F0 Offset: 0x216DBF0 VA: 0x18216E9F0
	internal void AddPermission(NetworkAccess access, Uri uri) { }

	// RVA: 0x216F290 Offset: 0x216E490 VA: 0x18216F290
	public void AddPermission(NetworkAccess access, Regex uriRegex) { }

	// RVA: 0x216E5C0 Offset: 0x216D7C0 VA: 0x18216E5C0
	internal void AddAsPattern(NetworkAccess access, DelayedRegex uriRegexPattern) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 14
	public bool IsUnrestricted() { }

	// RVA: 0x216F400 Offset: 0x216E600 VA: 0x18216F400 Slot: 7
	public override IPermission Copy() { }

	// RVA: 0x2170180 Offset: 0x216F380 VA: 0x182170180 Slot: 11
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x21738E0 Offset: 0x2172AE0 VA: 0x1821738E0
	private static bool isSpecialSubsetCase(string regexToCheck, ArrayList permList) { }

	// RVA: 0x2171190 Offset: 0x2170390 VA: 0x182171190 Slot: 13
	public override IPermission Union(IPermission target) { }

	// RVA: 0x216FEB0 Offset: 0x216F0B0 VA: 0x18216FEB0 Slot: 10
	public override IPermission Intersect(IPermission target) { }

	// RVA: 0x216F660 Offset: 0x216E860 VA: 0x18216F660 Slot: 9
	public override void FromXml(SecurityElement securityElement) { }

	// RVA: 0x21707A0 Offset: 0x216F9A0 VA: 0x1821707A0 Slot: 12
	public override SecurityElement ToXml() { }

	// RVA: 0x21734D0 Offset: 0x21726D0 VA: 0x1821734D0
	private static bool isMatchedURI(object uriToCheck, ArrayList uriPatternList) { }

	// RVA: 0x21724E0 Offset: 0x21716E0 VA: 0x1821724E0
	private static void intersectList(ArrayList A, ArrayList B, ArrayList result) { }

	// RVA: 0x2172F40 Offset: 0x2172140 VA: 0x182172F40
	private static object intersectPair(object L, object R, out bool isUri) { }
}

// Namespace: 
internal class WebRequest.DesignerWebRequestCreate : IWebRequestCreate // TypeDefIndex: 5821
{
	// Methods

	// RVA: 0x217EDB0 Offset: 0x217DFB0 VA: 0x18217EDB0 Slot: 4
	public WebRequest Create(Uri uri) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class WebRequest.WebProxyWrapperOpaque : IAutoWebProxy, IWebProxy // TypeDefIndex: 5822
{
	// Fields
	protected readonly WebProxy webProxy; // 0x10

	// Properties
	public ICredentials Credentials { get; set; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(WebProxy webProxy) { }

	// RVA: 0x2188070 Offset: 0x2187270 VA: 0x182188070 Slot: 5
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x2188090 Offset: 0x2187290 VA: 0x182188090 Slot: 6
	public bool IsBypassed(Uri host) { }

	// RVA: 0x1683290 Offset: 0x1682490 VA: 0x181683290 Slot: 7
	public ICredentials get_Credentials() { }

	// RVA: 0x21880B0 Offset: 0x21872B0 VA: 0x1821880B0 Slot: 8
	public void set_Credentials(ICredentials value) { }

	// RVA: 0x2187FB0 Offset: 0x21871B0 VA: 0x182187FB0 Slot: 4
	public ProxyChain GetProxies(Uri destination) { }
}

// Namespace: 
internal class WebRequest.WebProxyWrapper : WebRequest.WebProxyWrapperOpaque // TypeDefIndex: 5823
{
	// Properties
	internal WebProxy WebProxy { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(WebProxy webProxy) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal WebProxy get_WebProxy() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebRequest.<>c__DisplayClass78_0 // TypeDefIndex: 5824
{
	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2186AD0 Offset: 0x2185CD0 VA: 0x182186AD0
	internal Task<Stream> <GetRequestStreamAsync>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebRequest.<>c__DisplayClass79_0 // TypeDefIndex: 5825
{
	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2186D10 Offset: 0x2185F10 VA: 0x182186D10
	internal Task<WebResponse> <GetResponseAsync>b__1() { }
}

// Namespace: System.Net
[Serializable]
public abstract class WebRequest : MarshalByRefObject, ISerializable // TypeDefIndex: 5826
{
	// Fields
	internal const int DefaultTimeout = 100000;
	private static ArrayList s_PrefixList; // 0x0
	private static object s_InternalSyncObject; // 0x8
	private static TimerThread.Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private RequestCachePolicy m_CachePolicy; // 0x20
	private RequestCacheProtocol m_CacheProtocol; // 0x28
	private RequestCacheBinding m_CacheBinding; // 0x30
	private static WebRequest.DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static bool s_DefaultWebProxyInitialized; // 0x28

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	public virtual IWebRequestCreate CreatorInstance { get; }
	private static object InternalSyncObject { get; }
	internal static TimerThread.Queue DefaultTimerQueue { get; }
	internal static ArrayList PrefixList { get; set; }
	public static RequestCachePolicy DefaultCachePolicy { get; set; }
	public virtual RequestCachePolicy CachePolicy { get; set; }
	public virtual string Method { get; set; }
	public virtual Uri RequestUri { get; }
	public virtual string ConnectionGroupName { get; set; }
	public virtual WebHeaderCollection Headers { get; set; }
	public virtual long ContentLength { get; set; }
	public virtual string ContentType { get; set; }
	public virtual ICredentials Credentials { get; set; }
	public virtual bool UseDefaultCredentials { get; set; }
	public virtual IWebProxy Proxy { get; set; }
	public virtual bool PreAuthenticate { get; set; }
	public virtual int Timeout { get; set; }
	internal RequestCacheProtocol CacheProtocol { get; set; }
	public AuthenticationLevel AuthenticationLevel { get; set; }
	public TokenImpersonationLevel ImpersonationLevel { get; set; }
	internal static IWebProxy InternalDefaultWebProxy { get; set; }
	public static IWebProxy DefaultWebProxy { get; set; }

	// Methods

	// RVA: 0x2189CE0 Offset: 0x2188EE0 VA: 0x182189CE0 Slot: 7
	public virtual IWebRequestCreate get_CreatorInstance() { }

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	[EditorBrowsable(1)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void RegisterPortableWebRequestCreator(IWebRequestCreate creator) { }

	// RVA: 0x218A070 Offset: 0x2189270 VA: 0x18218A070
	private static object get_InternalSyncObject() { }

	// RVA: 0x2189DE0 Offset: 0x2188FE0 VA: 0x182189DE0
	internal static TimerThread.Queue get_DefaultTimerQueue() { }

	// RVA: 0x21885F0 Offset: 0x21877F0 VA: 0x1821885F0
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x21889A0 Offset: 0x2187BA0 VA: 0x1821889A0
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x21888D0 Offset: 0x2187AD0 VA: 0x1821888D0
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x2188160 Offset: 0x2187360 VA: 0x182188160
	public static WebRequest CreateDefault(Uri requestUri) { }

	// RVA: 0x2188230 Offset: 0x2187430 VA: 0x182188230
	public static HttpWebRequest CreateHttp(string requestUriString) { }

	// RVA: 0x2188300 Offset: 0x2187500 VA: 0x182188300
	public static HttpWebRequest CreateHttp(Uri requestUri) { }

	// RVA: 0x21892D0 Offset: 0x21884D0 VA: 0x1821892D0
	public static bool RegisterPrefix(string prefix, IWebRequestCreate creator) { }

	// RVA: 0x218A1C0 Offset: 0x21893C0 VA: 0x18218A1C0
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x218A840 Offset: 0x2189A40 VA: 0x18218A840
	internal static void set_PrefixList(ArrayList value) { }

	// RVA: 0x21890C0 Offset: 0x21882C0 VA: 0x1821890C0
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x2189C20 Offset: 0x2188E20 VA: 0x182189C20
	protected void .ctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2189950 Offset: 0x2188B50 VA: 0x182189950 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2189D60 Offset: 0x2188F60 VA: 0x182189D60
	public static RequestCachePolicy get_DefaultCachePolicy() { }

	// RVA: 0x218A4E0 Offset: 0x21896E0 VA: 0x18218A4E0
	public static void set_DefaultCachePolicy(RequestCachePolicy value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	public virtual RequestCachePolicy get_CachePolicy() { }

	// RVA: 0x218A410 Offset: 0x2189610 VA: 0x18218A410 Slot: 10
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x2189000 Offset: 0x2188200 VA: 0x182189000
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x218A160 Offset: 0x2189360 VA: 0x18218A160 Slot: 11
	public virtual string get_Method() { }

	// RVA: 0x218A7E0 Offset: 0x21899E0 VA: 0x18218A7E0 Slot: 12
	public virtual void set_Method(string value) { }

	// RVA: 0x218A380 Offset: 0x2189580 VA: 0x18218A380 Slot: 13
	public virtual Uri get_RequestUri() { }

	// RVA: 0x2189C50 Offset: 0x2188E50 VA: 0x182189C50 Slot: 14
	public virtual string get_ConnectionGroupName() { }

	// RVA: 0x218A420 Offset: 0x2189620 VA: 0x18218A420 Slot: 15
	public virtual void set_ConnectionGroupName(string value) { }

	// RVA: 0x2189E70 Offset: 0x2189070 VA: 0x182189E70 Slot: 16
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x218A630 Offset: 0x2189830 VA: 0x18218A630 Slot: 17
	public virtual void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x2189C80 Offset: 0x2188E80 VA: 0x182189C80 Slot: 18
	public virtual long get_ContentLength() { }

	// RVA: 0x218A450 Offset: 0x2189650 VA: 0x18218A450 Slot: 19
	public virtual void set_ContentLength(long value) { }

	// RVA: 0x2189CB0 Offset: 0x2188EB0 VA: 0x182189CB0 Slot: 20
	public virtual string get_ContentType() { }

	// RVA: 0x218A480 Offset: 0x2189680 VA: 0x18218A480 Slot: 21
	public virtual void set_ContentType(string value) { }

	// RVA: 0x2189D30 Offset: 0x2188F30 VA: 0x182189D30 Slot: 22
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x218A4B0 Offset: 0x21896B0 VA: 0x18218A4B0 Slot: 23
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x218A3E0 Offset: 0x21895E0 VA: 0x18218A3E0 Slot: 24
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x218A900 Offset: 0x2189B00 VA: 0x18218A900 Slot: 25
	public virtual void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x218A350 Offset: 0x2189550 VA: 0x18218A350 Slot: 26
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x218A8A0 Offset: 0x2189AA0 VA: 0x18218A8A0 Slot: 27
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x218A190 Offset: 0x2189390 VA: 0x18218A190 Slot: 28
	public virtual bool get_PreAuthenticate() { }

	// RVA: 0x218A810 Offset: 0x2189A10 VA: 0x18218A810 Slot: 29
	public virtual void set_PreAuthenticate(bool value) { }

	// RVA: 0x218A3B0 Offset: 0x21895B0 VA: 0x18218A3B0 Slot: 30
	public virtual int get_Timeout() { }

	// RVA: 0x218A8D0 Offset: 0x2189AD0 VA: 0x18218A8D0 Slot: 31
	public virtual void set_Timeout(int value) { }

	// RVA: 0x2188D10 Offset: 0x2187F10 VA: 0x182188D10 Slot: 32
	public virtual Stream GetRequestStream() { }

	// RVA: 0x2188F80 Offset: 0x2188180 VA: 0x182188F80 Slot: 33
	public virtual WebResponse GetResponse() { }

	// RVA: 0x2188130 Offset: 0x2187330 VA: 0x182188130 Slot: 34
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x2188AA0 Offset: 0x2187CA0 VA: 0x182188AA0 Slot: 35
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x2188100 Offset: 0x2187300 VA: 0x182188100 Slot: 36
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x2188A70 Offset: 0x2187C70 VA: 0x182188A70 Slot: 37
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x2188AD0 Offset: 0x2187CD0 VA: 0x182188AD0 Slot: 38
	public virtual Task<Stream> GetRequestStreamAsync() { }

	// RVA: 0x2188D40 Offset: 0x2187F40 VA: 0x182188D40 Slot: 39
	public virtual Task<WebResponse> GetResponseAsync() { }

	// RVA: 0x21897E0 Offset: 0x21889E0 VA: 0x1821897E0
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x21880D0 Offset: 0x21872D0 VA: 0x1821880D0 Slot: 40
	public virtual void Abort() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public AuthenticationLevel get_AuthenticationLevel() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_AuthenticationLevel(AuthenticationLevel value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public TokenImpersonationLevel get_ImpersonationLevel() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_ImpersonationLevel(TokenImpersonationLevel value) { }

	// RVA: 0x2189EA0 Offset: 0x21890A0 VA: 0x182189EA0
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x218A660 Offset: 0x2189860 VA: 0x18218A660
	internal static void set_InternalDefaultWebProxy(IWebProxy value) { }

	// RVA: 0x2189E30 Offset: 0x2189030 VA: 0x182189E30
	public static IWebProxy get_DefaultWebProxy() { }

	// RVA: 0x218A5E0 Offset: 0x21897E0 VA: 0x18218A5E0
	public static void set_DefaultWebProxy(IWebProxy value) { }

	// RVA: 0x2188FB0 Offset: 0x21881B0 VA: 0x182188FB0
	public static IWebProxy GetSystemWebProxy() { }

	// RVA: 0x2188FF0 Offset: 0x21881F0 VA: 0x182188FF0
	internal static IWebProxy InternalGetSystemWebProxy() { }

	// RVA: 0x2189820 Offset: 0x2188A20 VA: 0x182189820
	internal void SetupCacheProtocol(Uri uri) { }

	// RVA: 0x2189B80 Offset: 0x2188D80 VA: 0x182189B80
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2189980 Offset: 0x2188B80 VA: 0x182189980
	private Task<Stream> <GetRequestStreamAsync>b__78_0() { }

	[CompilerGenerated]
	// RVA: 0x2189A80 Offset: 0x2188C80 VA: 0x182189A80
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }
}

// Namespace: 
public static class WebRequestMethods.Ftp // TypeDefIndex: 5827
{
	// Fields
	public const string DownloadFile = "RETR";
	public const string ListDirectory = "NLST";
	public const string UploadFile = "STOR";
	public const string DeleteFile = "DELE";
	public const string AppendFile = "APPE";
	public const string GetFileSize = "SIZE";
	public const string UploadFileWithUniqueName = "STOU";
	public const string MakeDirectory = "MKD";
	public const string RemoveDirectory = "RMD";
	public const string ListDirectoryDetails = "LIST";
	public const string GetDateTimestamp = "MDTM";
	public const string PrintWorkingDirectory = "PWD";
	public const string Rename = "RENAME";
}

// Namespace: 
public static class WebRequestMethods.Http // TypeDefIndex: 5828
{
	// Fields
	public const string Get = "GET";
	public const string Connect = "CONNECT";
	public const string Head = "HEAD";
	public const string Put = "PUT";
	public const string Post = "POST";
	public const string MkCol = "MKCOL";
}

// Namespace: 
public static class WebRequestMethods.File // TypeDefIndex: 5829
{
	// Fields
	public const string DownloadFile = "GET";
	public const string UploadFile = "PUT";
}

// Namespace: System.Net
public static class WebRequestMethods // TypeDefIndex: 5830
{}

// Namespace: System.Net
[Serializable]
public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable // TypeDefIndex: 5831
{
	// Fields
	private bool m_IsCacheFresh; // 0x18
	private bool m_IsFromCache; // 0x19

	// Properties
	public virtual bool IsFromCache { get; }
	internal bool InternalSetFromCache { set; }
	internal virtual bool IsCacheFresh { get; }
	internal bool InternalSetIsCacheFresh { set; }
	public virtual bool IsMutuallyAuthenticated { get; }
	public virtual long ContentLength { get; set; }
	public virtual string ContentType { get; set; }
	public virtual Uri ResponseUri { get; }
	public virtual WebHeaderCollection Headers { get; }
	public virtual bool SupportsHeaders { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2189950 Offset: 0x2188B50 VA: 0x182189950 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	public virtual void Close() { }

	// RVA: 0x218A960 Offset: 0x2189B60 VA: 0x18218A960 Slot: 7
	public void Dispose() { }

	// RVA: 0x218A930 Offset: 0x2189B30 VA: 0x18218A930 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40 Slot: 11
	public virtual bool get_IsFromCache() { }

	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50
	internal void set_InternalSetFromCache(bool value) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20 Slot: 12
	internal virtual bool get_IsCacheFresh() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	internal void set_InternalSetIsCacheFresh(bool value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 13
	public virtual bool get_IsMutuallyAuthenticated() { }

	// RVA: 0x218AA00 Offset: 0x2189C00 VA: 0x18218AA00 Slot: 14
	public virtual long get_ContentLength() { }

	// RVA: 0x218AAC0 Offset: 0x2189CC0 VA: 0x18218AAC0 Slot: 15
	public virtual void set_ContentLength(long value) { }

	// RVA: 0x218AA30 Offset: 0x2189C30 VA: 0x18218AA30 Slot: 16
	public virtual string get_ContentType() { }

	// RVA: 0x218AAF0 Offset: 0x2189CF0 VA: 0x18218AAF0 Slot: 17
	public virtual void set_ContentType(string value) { }

	// RVA: 0x218A9D0 Offset: 0x2189BD0 VA: 0x18218A9D0 Slot: 18
	public virtual Stream GetResponseStream() { }

	// RVA: 0x218AA90 Offset: 0x2189C90 VA: 0x18218AA90 Slot: 19
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x218AA60 Offset: 0x2189C60 VA: 0x18218AA60 Slot: 20
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 21
	public virtual bool get_SupportsHeaders() { }
}

// Namespace: 
private class WebUtility.UrlDecoder // TypeDefIndex: 5832
{
	// Fields
	private int _bufferSize; // 0x10
	private int _numChars; // 0x14
	private char[] _charBuffer; // 0x18
	private int _numBytes; // 0x20
	private byte[] _byteBuffer; // 0x28
	private Encoding _encoding; // 0x30

	// Methods

	// RVA: 0x2187030 Offset: 0x2186230 VA: 0x182187030
	private void FlushBytes() { }

	// RVA: 0x2187120 Offset: 0x2186320 VA: 0x182187120
	internal void .ctor(int bufferSize, Encoding encoding) { }

	// RVA: 0x2186FD0 Offset: 0x21861D0 VA: 0x182186FD0
	internal void AddChar(char ch) { }

	// RVA: 0x2186F50 Offset: 0x2186150 VA: 0x182186F50
	internal void AddByte(byte b) { }

	// RVA: 0x21870A0 Offset: 0x21862A0 VA: 0x1821870A0
	internal string GetString() { }
}

// Namespace: 
private static class WebUtility.HtmlEntities // TypeDefIndex: 5833
{
	// Fields
	private static readonly long[] entities; // 0x0
	private static readonly char[] entities_values; // 0x8

	// Methods

	// RVA: 0x2181560 Offset: 0x2180760 VA: 0x182181560
	public static char Lookup(string entity) { }

	// RVA: 0x21814D0 Offset: 0x21806D0 VA: 0x1821814D0
	private static long CalculateKeyValue(string s) { }

	// RVA: 0x21816C0 Offset: 0x21808C0 VA: 0x1821816C0
	private static void .cctor() { }
}

// Namespace: System.Net
public static class WebUtility // TypeDefIndex: 5834
{
	// Fields
	private const char HIGH_SURROGATE_START = '\xd800';
	private const char LOW_SURROGATE_START = '\xdc00';
	private const char LOW_SURROGATE_END = '\xdfff';
	private const int UNICODE_PLANE00_END = 65535;
	private const int UNICODE_PLANE01_START = 65536;
	private const int UNICODE_PLANE16_END = 1114111;
	private const int UnicodeReplacementChar = 65533;
	private static readonly char[] _htmlEntityEndingChars; // 0x0
	private static UnicodeDecodingConformance _htmlDecodeConformance; // 0x8
	private static UnicodeEncodingConformance _htmlEncodeConformance; // 0xC

	// Properties
	private static UnicodeDecodingConformance HtmlDecodeConformance { get; }
	private static UnicodeEncodingConformance HtmlEncodeConformance { get; }

	// Methods

	// RVA: 0x218B5D0 Offset: 0x218A7D0 VA: 0x18218B5D0
	public static string HtmlEncode(string value) { }

	// RVA: 0x218B190 Offset: 0x218A390 VA: 0x18218B190
	public static void HtmlEncode(string value, TextWriter output) { }

	// RVA: 0x218AC50 Offset: 0x2189E50 VA: 0x18218AC50
	public static string HtmlDecode(string value) { }

	// RVA: 0x218AD70 Offset: 0x2189F70 VA: 0x18218AD70
	public static void HtmlDecode(string value, TextWriter output) { }

	// RVA: 0x218B6F0 Offset: 0x218A8F0 VA: 0x18218B6F0
	private static int IndexOfHtmlEncodingChars(string s, int startPos) { }

	// RVA: 0x218C750 Offset: 0x218B950 VA: 0x18218C750
	private static UnicodeDecodingConformance get_HtmlDecodeConformance() { }

	// RVA: 0x218C860 Offset: 0x218BA60 VA: 0x18218C860
	private static UnicodeEncodingConformance get_HtmlEncodeConformance() { }

	// RVA: 0x218C380 Offset: 0x218B580 VA: 0x18218C380
	private static byte[] UrlEncode(byte[] bytes, int offset, int count, bool alwaysCreateNewReturnValue) { }

	// RVA: 0x218C010 Offset: 0x218B210 VA: 0x18218C010
	private static byte[] UrlEncode(byte[] bytes, int offset, int count) { }

	// RVA: 0x218C450 Offset: 0x218B650 VA: 0x18218C450
	public static string UrlEncode(string value) { }

	// RVA: 0x218BF90 Offset: 0x218B190 VA: 0x18218BF90
	public static byte[] UrlEncodeToBytes(byte[] value, int offset, int count) { }

	// RVA: 0x218BC60 Offset: 0x218AE60 VA: 0x18218BC60
	private static string UrlDecodeInternal(string value, Encoding encoding) { }

	// RVA: 0x218B9A0 Offset: 0x218ABA0 VA: 0x18218B9A0
	private static byte[] UrlDecodeInternal(byte[] bytes, int offset, int count) { }

	// RVA: 0x218BF20 Offset: 0x218B120 VA: 0x18218BF20
	public static string UrlDecode(string encodedValue) { }

	// RVA: 0x218BEB0 Offset: 0x218B0B0 VA: 0x18218BEB0
	public static byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count) { }

	// RVA: 0x218AB20 Offset: 0x2189D20 VA: 0x18218AB20
	private static void ConvertSmpToUtf16(uint smpChar, out char leadingSurrogate, out char trailingSurrogate) { }

	// RVA: 0x218AB60 Offset: 0x2189D60 VA: 0x18218AB60
	private static int GetNextUnicodeScalarValueFromUtf16Surrogate(ref char* pch, ref int charsRemaining) { }

	// RVA: 0x218AC10 Offset: 0x2189E10 VA: 0x18218AC10
	private static int HexToInt(char h) { }

	// RVA: 0x218B810 Offset: 0x218AA10 VA: 0x18218B810
	private static char IntToHex(int n) { }

	// RVA: 0x218B820 Offset: 0x218AA20 VA: 0x18218B820
	private static bool IsUrlSafeChar(char ch) { }

	// RVA: 0x218C570 Offset: 0x218B770 VA: 0x18218C570
	private static bool ValidateUrlEncodingParameters(byte[] bytes, int offset, int count) { }

	// RVA: 0x218B890 Offset: 0x218AA90 VA: 0x18218B890
	private static bool StringRequiresHtmlDecoding(string s) { }

	// RVA: 0x218C690 Offset: 0x218B890 VA: 0x18218C690
	private static void .cctor() { }
}

// Namespace: System.Net
internal class BufferOffsetSize // TypeDefIndex: 5835
{
	// Fields
	internal byte[] Buffer; // 0x10
	internal int Offset; // 0x18
	internal int Size; // 0x1C

	// Methods

	// RVA: 0x2174120 Offset: 0x2173320 VA: 0x182174120
	internal void .ctor(byte[] buffer, int offset, int size, bool copyBuffer) { }

	// RVA: 0x21740F0 Offset: 0x21732F0 VA: 0x1821740F0
	internal void .ctor(byte[] buffer, bool copyBuffer) { }
}

// Namespace: System.Net
internal enum DataParseStatus // TypeDefIndex: 5836
{
	// Fields
	public int value__; // 0x0
	public const DataParseStatus NeedMoreData = 0;
	public const DataParseStatus ContinueParsing = 1;
	public const DataParseStatus Done = 2;
	public const DataParseStatus Invalid = 3;
	public const DataParseStatus DataTooBig = 4;
}

// Namespace: System.Net
internal enum WriteBufferState // TypeDefIndex: 5837
{
	// Fields
	public int value__; // 0x0
	public const WriteBufferState Disabled = 0;
	public const WriteBufferState Headers = 1;
	public const WriteBufferState Buffer = 2;
	public const WriteBufferState Playback = 3;
}

// Namespace: System.Net
internal enum WebParseErrorSection // TypeDefIndex: 5838
{
	// Fields
	public int value__; // 0x0
	public const WebParseErrorSection Generic = 0;
	public const WebParseErrorSection ResponseHeader = 1;
	public const WebParseErrorSection ResponseStatusLine = 2;
	public const WebParseErrorSection ResponseBody = 3;
}

// Namespace: System.Net
internal enum WebParseErrorCode // TypeDefIndex: 5839
{
	// Fields
	public int value__; // 0x0
	public const WebParseErrorCode Generic = 0;
	public const WebParseErrorCode InvalidHeaderName = 1;
	public const WebParseErrorCode InvalidContentLength = 2;
	public const WebParseErrorCode IncompleteHeaderLine = 3;
	public const WebParseErrorCode CrLfError = 4;
	public const WebParseErrorCode InvalidChunkFormat = 5;
	public const WebParseErrorCode UnexpectedServerResponse = 6;
}

// Namespace: System.Net
internal struct WebParseError // TypeDefIndex: 5840
{
	// Fields
	public WebParseErrorSection Section; // 0x0
	public WebParseErrorCode Code; // 0x4
}

// Namespace: System.Net
internal static class HttpDateParse // TypeDefIndex: 5841
{
	// Fields
	private const int BASE_DEC = 10;
	private const int DATE_INDEX_DAY_OF_WEEK = 0;
	private const int DATE_1123_INDEX_DAY = 1;
	private const int DATE_1123_INDEX_MONTH = 2;
	private const int DATE_1123_INDEX_YEAR = 3;
	private const int DATE_1123_INDEX_HRS = 4;
	private const int DATE_1123_INDEX_MINS = 5;
	private const int DATE_1123_INDEX_SECS = 6;
	private const int DATE_ANSI_INDEX_MONTH = 1;
	private const int DATE_ANSI_INDEX_DAY = 2;
	private const int DATE_ANSI_INDEX_HRS = 3;
	private const int DATE_ANSI_INDEX_MINS = 4;
	private const int DATE_ANSI_INDEX_SECS = 5;
	private const int DATE_ANSI_INDEX_YEAR = 6;
	private const int DATE_INDEX_TZ = 7;
	private const int DATE_INDEX_LAST = 7;
	private const int MAX_FIELD_DATE_ENTRIES = 8;
	private const int DATE_TOKEN_JANUARY = 1;
	private const int DATE_TOKEN_FEBRUARY = 2;
	private const int DATE_TOKEN_Microsoft = 3;
	private const int DATE_TOKEN_APRIL = 4;
	private const int DATE_TOKEN_MAY = 5;
	private const int DATE_TOKEN_JUNE = 6;
	private const int DATE_TOKEN_JULY = 7;
	private const int DATE_TOKEN_AUGUST = 8;
	private const int DATE_TOKEN_SEPTEMBER = 9;
	private const int DATE_TOKEN_OCTOBER = 10;
	private const int DATE_TOKEN_NOVEMBER = 11;
	private const int DATE_TOKEN_DECEMBER = 12;
	private const int DATE_TOKEN_LAST_MONTH = 13;
	private const int DATE_TOKEN_SUNDAY = 0;
	private const int DATE_TOKEN_MONDAY = 1;
	private const int DATE_TOKEN_TUESDAY = 2;
	private const int DATE_TOKEN_WEDNESDAY = 3;
	private const int DATE_TOKEN_THURSDAY = 4;
	private const int DATE_TOKEN_FRIDAY = 5;
	private const int DATE_TOKEN_SATURDAY = 6;
	private const int DATE_TOKEN_LAST_DAY = 7;
	private const int DATE_TOKEN_GMT = -1000;
	private const int DATE_TOKEN_LAST = -1000;
	private const int DATE_TOKEN_ERROR = -999;

	// Methods

	// RVA: 0x2181790 Offset: 0x2180990 VA: 0x182181790
	private static char MAKE_UPPER(char c) { }

	// RVA: 0x2181820 Offset: 0x2180A20 VA: 0x182181820
	private static int MapDayMonthToDword(char[] lpszDay, int index) { }

	// RVA: 0x2181B50 Offset: 0x2180D50 VA: 0x182181B50
	public static bool ParseHttpDate(string DateString, out DateTime dtOut) { }
}

// Namespace: System.Net
internal sealed class HeaderParser : MulticastDelegate // TypeDefIndex: 5842
{
	// Methods

	// RVA: 0x585960 Offset: 0x584B60 VA: 0x180585960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual string[] Invoke(string value) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string value, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual string[] EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
internal class HeaderInfo // TypeDefIndex: 5843
{
	// Fields
	internal readonly bool IsRequestRestricted; // 0x10
	internal readonly bool IsResponseRestricted; // 0x11
	internal readonly HeaderParser Parser; // 0x18
	internal readonly string HeaderName; // 0x20
	internal readonly bool AllowMultiValues; // 0x28

	// Methods

	// RVA: 0x2181470 Offset: 0x2180670 VA: 0x182181470
	internal void .ctor(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }
}

// Namespace: System.Net
[DefaultMember("Item")]
internal class HeaderInfoTable // TypeDefIndex: 5844
{
	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x217F410 Offset: 0x217E610 VA: 0x18217F410
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x217F200 Offset: 0x217E400 VA: 0x18217F200
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x217F470 Offset: 0x217E670 VA: 0x18217F470
	private static void .cctor() { }

	// RVA: 0x2181360 Offset: 0x2180560 VA: 0x182181360
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
[Flags]
internal enum CloseExState // TypeDefIndex: 5845
{
	// Fields
	public int value__; // 0x0
	public const CloseExState Normal = 0;
	public const CloseExState Abort = 1;
	public const CloseExState Silent = 2;
}

// Namespace: System.Net
internal interface ICloseEx // TypeDefIndex: 5846
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CloseEx(CloseExState closeState);
}

// Namespace: 
private class LazyAsyncResult.ThreadContext // TypeDefIndex: 5847
{
	// Fields
	internal int m_NestedIOCount; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 5848
{
	// Fields
	private const int c_HighBit = -2147483648;
	private const int c_ForceAsyncCount = 50;
	[ThreadStatic]
	private static LazyAsyncResult.ThreadContext t_ThreadContext; // 0x80000000
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_ErrorCode; // 0x30
	private int m_IntCompleted; // 0x34
	private bool m_EndCalled; // 0x38
	private bool m_UserEvent; // 0x39
	private object m_Event; // 0x40

	// Properties
	private static LazyAsyncResult.ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	protected AsyncCallback AsyncCallback { get; set; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }
	internal object Result { get; set; }
	internal bool EndCalled { get; set; }
	internal int ErrorCode { get; set; }

	// Methods

	// RVA: 0x2182A20 Offset: 0x2181C20 VA: 0x182182A20
	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x2182840 Offset: 0x2181A40 VA: 0x182182840
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x21828E0 Offset: 0x2181AE0 VA: 0x1821828E0
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack, object result) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal object get_AsyncObject() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	protected AsyncCallback get_AsyncCallback() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	protected void set_AsyncCallback(AsyncCallback value) { }

	// RVA: 0x2182950 Offset: 0x2181B50 VA: 0x182182950 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x2182300 Offset: 0x2181500 VA: 0x182182300
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	protected void DebugProtectState(bool protect) { }

	// RVA: 0x21829F0 Offset: 0x2181BF0 VA: 0x1821829F0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x2182AC0 Offset: 0x2181CC0 VA: 0x182182AC0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x2182AB0 Offset: 0x2181CB0 VA: 0x182182AB0
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x2182AF0 Offset: 0x2181CF0 VA: 0x182182AF0
	internal object get_Result() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_Result(object value) { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	internal bool get_EndCalled() { }

	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	internal void set_EndCalled(bool value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	internal int get_ErrorCode() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	internal void set_ErrorCode(int value) { }

	// RVA: 0x2182460 Offset: 0x2181660 VA: 0x182182460
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x21822F0 Offset: 0x21814F0 VA: 0x1821822F0
	internal void InvokeCallback(object result) { }

	// RVA: 0x21822E0 Offset: 0x21814E0 VA: 0x1821822E0
	internal void InvokeCallback() { }

	// RVA: 0x2182090 Offset: 0x2181290 VA: 0x182182090 Slot: 8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x21827B0 Offset: 0x21819B0 VA: 0x1821827B0
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	protected virtual void Cleanup() { }

	// RVA: 0x21822D0 Offset: 0x21814D0 VA: 0x1821822D0
	internal object InternalWaitForCompletion() { }

	// RVA: 0x21825E0 Offset: 0x21817E0 VA: 0x1821825E0
	private object WaitForCompletion(bool snap) { }

	// RVA: 0x2182280 Offset: 0x2181480 VA: 0x182182280
	internal void InternalCleanup() { }
}

// Namespace: System.Net
internal class BaseLoggingObject // TypeDefIndex: 5849
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	internal virtual void EnterFunc(string funcname) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	internal virtual void LeaveFunc(string funcname) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	internal virtual void DumpArrayToConsole() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	internal virtual void PrintLine(string msg) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	internal virtual void DumpArray(bool shouldClose) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	internal virtual void DumpArrayToFile(bool shouldClose) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	internal virtual void Flush() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	internal virtual void Flush(bool close) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	internal virtual void LoggingMonitorTick() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	internal virtual void Dump(byte[] buffer) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 14
	internal virtual void Dump(byte[] buffer, int length) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	internal virtual void Dump(byte[] buffer, int offset, int length) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	internal virtual void Dump(IntPtr pBuffer, int offset, int length) { }
}

// Namespace: System.Net
[Flags]
internal enum ThreadKinds // TypeDefIndex: 5850
{
	// Fields
	public int value__; // 0x0
	public const ThreadKinds Unknown = 0;
	public const ThreadKinds User = 1;
	public const ThreadKinds System = 2;
	public const ThreadKinds Sync = 4;
	public const ThreadKinds Async = 8;
	public const ThreadKinds Timer = 16;
	public const ThreadKinds CompletionPort = 32;
	public const ThreadKinds Worker = 64;
	public const ThreadKinds Finalization = 128;
	public const ThreadKinds Other = 256;
	public const ThreadKinds OwnerMask = 3;
	public const ThreadKinds SyncMask = 12;
	public const ThreadKinds SourceMask = 496;
	public const ThreadKinds SafeSources = 352;
	public const ThreadKinds ThreadPool = 96;
}

// Namespace: System.Net
internal static class GlobalLog // TypeDefIndex: 5851
{
	// Fields
	private static BaseLoggingObject Logobject; // 0x0

	// Properties
	internal static ThreadKinds CurrentThreadKind { get; }

	// Methods

	[ReliabilityContract(1, 0)]
	// RVA: 0x217F0A0 Offset: 0x217E2A0 VA: 0x18217F0A0
	private static BaseLoggingObject LoggingInitialize() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal static ThreadKinds get_CurrentThreadKind() { }

	[Conditional("DEBUG")]
	[ReliabilityContract(1, 0)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void SetThreadSource(ThreadKinds source) { }

	[ReliabilityContract(1, 0)]
	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void ThreadContract(ThreadKinds kind, string errorMsg) { }

	[Conditional("DEBUG")]
	[ReliabilityContract(1, 0)]
	// RVA: 0x217F0F0 Offset: 0x217E2F0 VA: 0x18217F0F0
	internal static void ThreadContract(ThreadKinds kind, ThreadKinds allowedSources, string errorMsg) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void AddToArray(string msg) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Ignore(object msg) { }

	[ReliabilityContract(1, 0)]
	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Print(string msg) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void PrintHex(string msg, object value) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Enter(string func) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Enter(string func, string parms) { }

	[Conditional("DEBUG")]
	[Conditional("_FORCE_ASSERTS")]
	[ReliabilityContract(1, 0)]
	// RVA: 0x217F010 Offset: 0x217E210 VA: 0x18217F010
	public static void Assert(bool condition, string messageFormat, object[] data) { }

	[Conditional("DEBUG")]
	[ReliabilityContract(1, 0)]
	[Conditional("_FORCE_ASSERTS")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Assert(string message) { }

	[Conditional("_FORCE_ASSERTS")]
	[Conditional("DEBUG")]
	[ReliabilityContract(1, 0)]
	// RVA: 0x217EF40 Offset: 0x217E140 VA: 0x18217EF40
	public static void Assert(string message, string detailMessage) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void LeaveException(string func, Exception exception) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Leave(string func) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Leave(string func, string result) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Leave(string func, int returnval) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Leave(string func, bool returnval) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void DumpArray() { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Dump(byte[] buffer) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Dump(byte[] buffer, int length) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Dump(byte[] buffer, int offset, int length) { }

	[Conditional("TRAVE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Dump(IntPtr buffer, int offset, int length) { }

	// RVA: 0x217F190 Offset: 0x217E390 VA: 0x18217F190
	private static void .cctor() { }
}

// Namespace: System.Net
internal class NetRes // TypeDefIndex: 5852
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x2182ED0 Offset: 0x21820D0 VA: 0x182182ED0
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x2182E70 Offset: 0x2182070 VA: 0x182182E70
	public static string GetWebStatusString(WebExceptionStatus Status) { }

	// RVA: 0x2182D20 Offset: 0x2181F20 VA: 0x182182D20
	public static string GetWebStatusCodeString(HttpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x2182BD0 Offset: 0x2181DD0 VA: 0x182182BD0
	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }
}

// Namespace: System.Net
internal interface IAutoWebProxy : IWebProxy // TypeDefIndex: 5853
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ProxyChain GetProxies(Uri destination);
}

// Namespace: 
private class ProxyChain.ProxyEnumerator : IEnumerator<Uri>, IDisposable, IEnumerator // TypeDefIndex: 5854
{
	// Fields
	private ProxyChain m_Chain; // 0x10
	private bool m_Finished; // 0x18
	private int m_CurrentIndex; // 0x1C
	private bool m_TriedDirect; // 0x20

	// Properties
	public Uri Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x21835A0 Offset: 0x21827A0 VA: 0x1821835A0
	internal void .ctor(ProxyChain chain) { }

	// RVA: 0x21834E0 Offset: 0x21826E0 VA: 0x1821834E0 Slot: 4
	public Uri get_Current() { }

	// RVA: 0x21834E0 Offset: 0x21826E0 VA: 0x1821834E0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2183190 Offset: 0x2182390 VA: 0x182183190 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x21834D0 Offset: 0x21826D0 VA: 0x1821834D0 Slot: 8
	public void Reset() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void Dispose() { }
}

// Namespace: System.Net
internal abstract class ProxyChain : IEnumerable<Uri>, IEnumerable, IDisposable // TypeDefIndex: 5855
{
	// Fields
	private List<Uri> m_Cache; // 0x10
	private bool m_CacheComplete; // 0x18
	private ProxyChain.ProxyEnumerator m_MainEnumerator; // 0x20
	private Uri m_Destination; // 0x28
	private HttpAbortDelegate m_HttpAbortDelegate; // 0x30

	// Properties
	internal IEnumerator<Uri> Enumerator { get; }
	internal Uri Destination { get; }
	internal HttpAbortDelegate HttpAbortDelegate { get; }

	// Methods

	// RVA: 0x2183010 Offset: 0x2182210 VA: 0x182183010
	protected void .ctor(Uri destination) { }

	// RVA: 0x2182F80 Offset: 0x2182180 VA: 0x182182F80 Slot: 4
	public IEnumerator<Uri> GetEnumerator() { }

	// RVA: 0x2182F80 Offset: 0x2182180 VA: 0x182182F80 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public virtual void Dispose() { }

	// RVA: 0x2183090 Offset: 0x2182290 VA: 0x182183090
	internal IEnumerator<Uri> get_Enumerator() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal Uri get_Destination() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	internal virtual void Abort() { }

	// RVA: 0x2182FF0 Offset: 0x21821F0 VA: 0x182182FF0
	internal bool HttpAbort(HttpWebRequest request, WebException webException) { }

	// RVA: 0x2183110 Offset: 0x2182310 VA: 0x182183110
	internal HttpAbortDelegate get_HttpAbortDelegate() { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract bool GetNextProxy(out Uri proxy);
}

// Namespace: System.Net
internal class ProxyScriptChain : ProxyChain // TypeDefIndex: 5856
{
	// Fields
	private WebProxy m_Proxy; // 0x38
	private Uri[] m_ScriptProxies; // 0x40
	private int m_CurrentIndex; // 0x48
	private int m_SyncStatus; // 0x4C

	// Methods

	// RVA: 0x21836D0 Offset: 0x21828D0 VA: 0x1821836D0
	internal void .ctor(WebProxy proxy, Uri destination) { }

	// RVA: 0x2183600 Offset: 0x2182800 VA: 0x182183600 Slot: 9
	protected override bool GetNextProxy(out Uri proxy) { }

	// RVA: 0x21835D0 Offset: 0x21827D0 VA: 0x1821835D0 Slot: 8
	internal override void Abort() { }
}

// Namespace: System.Net
internal class DirectProxy : ProxyChain // TypeDefIndex: 5857
{
	// Fields
	private bool m_ProxyRetrieved; // 0x38

	// Methods

	// RVA: 0x217EED0 Offset: 0x217E0D0 VA: 0x18217EED0
	internal void .ctor(Uri destination) { }

	// RVA: 0x217EEB0 Offset: 0x217E0B0 VA: 0x18217EEB0 Slot: 9
	protected override bool GetNextProxy(out Uri proxy) { }
}

// Namespace: System.Net
internal class StaticProxy : ProxyChain // TypeDefIndex: 5858
{
	// Fields
	private Uri m_Proxy; // 0x38

	// Methods

	// RVA: 0x21847F0 Offset: 0x21839F0 VA: 0x1821847F0
	internal void .ctor(Uri destination, Uri proxy) { }

	// RVA: 0x2184760 Offset: 0x2183960 VA: 0x182184760 Slot: 9
	protected override bool GetNextProxy(out Uri proxy) { }
}

// Namespace: 
private class ScatterGatherBuffers.MemoryChunk // TypeDefIndex: 5859
{
	// Fields
	internal byte[] Buffer; // 0x10
	internal int FreeOffset; // 0x18
	internal ScatterGatherBuffers.MemoryChunk Next; // 0x20

	// Methods

	// RVA: 0x2182B70 Offset: 0x2181D70 VA: 0x182182B70
	internal void .ctor(int bufferSize) { }
}

// Namespace: System.Net
internal class ScatterGatherBuffers // TypeDefIndex: 5860
{
	// Fields
	private ScatterGatherBuffers.MemoryChunk headChunk; // 0x10
	private ScatterGatherBuffers.MemoryChunk currentChunk; // 0x18
	private int nextChunkLength; // 0x20
	private int totalLength; // 0x24
	private int chunkCount; // 0x28

	// Properties
	private bool Empty { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x2183AC0 Offset: 0x2182CC0 VA: 0x182183AC0
	internal void .ctor() { }

	// RVA: 0x2183A70 Offset: 0x2182C70 VA: 0x182183A70
	internal void .ctor(long totalSize) { }

	// RVA: 0x2183800 Offset: 0x2182A00 VA: 0x182183800
	internal BufferOffsetSize[] GetBuffers() { }

	// RVA: 0x2183AD0 Offset: 0x2182CD0 VA: 0x182183AD0
	private bool get_Empty() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	internal int get_Length() { }

	// RVA: 0x2183970 Offset: 0x2182B70 VA: 0x182183970
	internal void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2183740 Offset: 0x2182940 VA: 0x182183740
	private ScatterGatherBuffers.MemoryChunk AllocateMemoryChunk(int newSize) { }
}

// Namespace: System.Net
internal sealed class Semaphore : WaitHandle // TypeDefIndex: 5861
{
	// Methods

	// RVA: 0x2183B30 Offset: 0x2182D30 VA: 0x182183B30
	internal void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x2183AF0 Offset: 0x2182CF0 VA: 0x182183AF0
	internal bool ReleaseSemaphore() { }
}

// Namespace: System.Net
internal class ServiceNameStore // TypeDefIndex: 5862
{
	// Fields
	private List<string> serviceNames; // 0x10
	private ServiceNameCollection serviceNameCollection; // 0x18

	// Properties
	public ServiceNameCollection ServiceNames { get; }

	// Methods

	// RVA: 0x21846E0 Offset: 0x21838E0 VA: 0x1821846E0
	public ServiceNameCollection get_ServiceNames() { }

	// RVA: 0x2184660 Offset: 0x2183860 VA: 0x182184660
	public void .ctor() { }

	// RVA: 0x2183C60 Offset: 0x2182E60 VA: 0x182183C60
	private bool AddSingleServiceName(string spn) { }

	// RVA: 0x2183D40 Offset: 0x2182F40 VA: 0x182183D40
	public bool Add(string uriPrefix) { }

	// RVA: 0x2184500 Offset: 0x2183700 VA: 0x182184500
	public bool Remove(string uriPrefix) { }

	// RVA: 0x2184340 Offset: 0x2183540 VA: 0x182184340
	private bool Contains(string newServiceName) { }

	// RVA: 0x21842D0 Offset: 0x21834D0 VA: 0x1821842D0
	public void Clear() { }

	// RVA: 0x2184360 Offset: 0x2183560 VA: 0x182184360
	private string ExtractHostname(string uriPrefix, bool allowInvalidUriStrings) { }

	// RVA: 0x21841F0 Offset: 0x21833F0 VA: 0x1821841F0
	public string BuildSimpleServiceName(string uriPrefix) { }

	// RVA: 0x2183E90 Offset: 0x2183090 VA: 0x182183E90
	public string[] BuildServiceNames(string uriPrefix) { }
}

// Namespace: 
internal abstract class TimerThread.Queue // TypeDefIndex: 5863
{
	// Fields
	private readonly int m_DurationMilliseconds; // 0x10

	// Properties
	internal int Duration { get; }

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	internal int get_Duration() { }

	// RVA: 0x2183700 Offset: 0x2182900 VA: 0x182183700
	internal TimerThread.Timer CreateTimer() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context);
}

// Namespace: 
internal abstract class TimerThread.Timer : IDisposable // TypeDefIndex: 5864
{
	// Fields
	private readonly int m_StartTimeMilliseconds; // 0x10
	private readonly int m_DurationMilliseconds; // 0x14

	// Properties
	internal int Duration { get; }
	internal int StartTime { get; }
	internal int Expiration { get; }
	internal int TimeRemaining { get; }
	internal abstract bool HasExpired { get; }

	// Methods

	// RVA: 0x2186980 Offset: 0x2185B80 VA: 0x182186980
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	internal int get_Duration() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	internal int get_StartTime() { }

	// RVA: 0x21869B0 Offset: 0x2185BB0 VA: 0x1821869B0
	internal int get_Expiration() { }

	// RVA: 0x21869C0 Offset: 0x2185BC0 VA: 0x1821869C0
	internal int get_TimeRemaining() { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool Cancel();

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool get_HasExpired();

	// RVA: 0x19B4EC0 Offset: 0x19B40C0 VA: 0x1819B4EC0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
internal sealed class TimerThread.Callback : MulticastDelegate // TypeDefIndex: 5865
{
	// Methods

	// RVA: 0x2174260 Offset: 0x2173460 VA: 0x182174260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(TimerThread.Timer timer, int timeNoticed, object context) { }

	// RVA: 0x21741D0 Offset: 0x21733D0 VA: 0x1821741D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(TimerThread.Timer timer, int timeNoticed, object context, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum TimerThread.TimerThreadState // TypeDefIndex: 5866
{
	// Fields
	public int value__; // 0x0
	public const TimerThread.TimerThreadState Idle = 0;
	public const TimerThread.TimerThreadState Running = 1;
	public const TimerThread.TimerThreadState Stopped = 2;
}

// Namespace: 
private class TimerThread.TimerQueue : TimerThread.Queue // TypeDefIndex: 5867
{
	// Fields
	private IntPtr m_ThisHandle; // 0x18
	private readonly TimerThread.TimerNode m_Timers; // 0x20

	// Methods

	// RVA: 0x2185140 Offset: 0x2184340 VA: 0x182185140
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x2184C90 Offset: 0x2183E90 VA: 0x182184C90 Slot: 4
	internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context) { }

	// RVA: 0x2184F90 Offset: 0x2184190 VA: 0x182184F90
	internal bool Fire(out int nextExpiration) { }
}

// Namespace: 
private class TimerThread.InfiniteTimerQueue : TimerThread.Queue // TypeDefIndex: 5868
{
	// Methods

	// RVA: 0x2182020 Offset: 0x2181220 VA: 0x182182020
	internal void .ctor() { }

	// RVA: 0x2181FC0 Offset: 0x21811C0 VA: 0x182181FC0 Slot: 4
	internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context) { }
}

// Namespace: 
private enum TimerThread.TimerNode.TimerState // TypeDefIndex: 5869
{
	// Fields
	public int value__; // 0x0
	public const TimerThread.TimerNode.TimerState Ready = 0;
	public const TimerThread.TimerNode.TimerState Fired = 1;
	public const TimerThread.TimerNode.TimerState Cancelled = 2;
	public const TimerThread.TimerNode.TimerState Sentinel = 3;
}

// Namespace: 
private class TimerThread.TimerNode : TimerThread.Timer // TypeDefIndex: 5870
{
	// Fields
	private TimerThread.TimerNode.TimerState m_TimerState; // 0x18
	private TimerThread.Callback m_Callback; // 0x20
	private object m_Context; // 0x28
	private object m_QueueLock; // 0x30
	private TimerThread.TimerNode next; // 0x38
	private TimerThread.TimerNode prev; // 0x40

	// Properties
	internal override bool HasExpired { get; }
	internal TimerThread.TimerNode Next { get; set; }
	internal TimerThread.TimerNode Prev { get; set; }

	// Methods

	// RVA: 0x2184C10 Offset: 0x2183E10 VA: 0x182184C10
	internal void .ctor(TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock) { }

	// RVA: 0x2184BE0 Offset: 0x2183DE0 VA: 0x182184BE0
	internal void .ctor() { }

	// RVA: 0x2184C80 Offset: 0x2183E80 VA: 0x182184C80 Slot: 6
	internal override bool get_HasExpired() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal TimerThread.TimerNode get_Next() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void set_Next(TimerThread.TimerNode value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal TimerThread.TimerNode get_Prev() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_Prev(TimerThread.TimerNode value) { }

	// RVA: 0x21848C0 Offset: 0x2183AC0 VA: 0x1821848C0 Slot: 5
	internal override bool Cancel() { }

	// RVA: 0x21849C0 Offset: 0x2183BC0 VA: 0x1821849C0
	internal bool Fire() { }
}

// Namespace: 
private class TimerThread.InfiniteTimer : TimerThread.Timer // TypeDefIndex: 5871
{
	// Fields
	private int cancelled; // 0x18

	// Properties
	internal override bool HasExpired { get; }

	// Methods

	// RVA: 0x2182060 Offset: 0x2181260 VA: 0x182182060
	internal void .ctor() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	internal override bool get_HasExpired() { }

	// RVA: 0x2182040 Offset: 0x2181240 VA: 0x182182040 Slot: 5
	internal override bool Cancel() { }
}

// Namespace: System.Net
internal static class TimerThread // TypeDefIndex: 5872
{
	// Fields
	private const int c_ThreadIdleTimeoutMilliseconds = 30000;
	private const int c_CacheScanPerIterations = 32;
	private const int c_TickCountResolution = 15;
	private static LinkedList<WeakReference> s_Queues; // 0x0
	private static LinkedList<WeakReference> s_NewQueues; // 0x8
	private static int s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static int s_CacheScanIteration; // 0x30
	private static Hashtable s_QueuesCache; // 0x38

	// Methods

	// RVA: 0x21866E0 Offset: 0x21858E0 VA: 0x1821866E0
	private static void .cctor() { }

	// RVA: 0x21851D0 Offset: 0x21843D0 VA: 0x1821851D0
	internal static TimerThread.Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x21853F0 Offset: 0x21845F0 VA: 0x1821853F0
	internal static TimerThread.Queue GetOrCreateQueue(int durationMilliseconds) { }

	// RVA: 0x2185DD0 Offset: 0x2184FD0 VA: 0x182185DD0
	private static void Prod() { }

	// RVA: 0x2185F70 Offset: 0x2185170 VA: 0x182185F70
	private static void ThreadProc() { }

	// RVA: 0x2185EF0 Offset: 0x21850F0 VA: 0x182185EF0
	private static void StopTimerThread() { }

	// RVA: 0x2185CF0 Offset: 0x2184EF0 VA: 0x182185CF0
	private static bool IsTickBetween(int start, int end, int comparand) { }

	// RVA: 0x2185D10 Offset: 0x2184F10 VA: 0x182185D10
	private static void OnDomainUnload(object sender, EventArgs e) { }
}

// Namespace: System.Net
internal abstract class WebProxyDataBuilder // TypeDefIndex: 5873
{
	// Fields
	private const char addressListDelimiter = '\x3b';
	private const char addressListSchemeValueDelimiter = '\x3d';
	private const char bypassListDelimiter = '\x3b';
	private WebProxyData m_Result; // 0x10
	private const string regexReserved = "#$()+.?[\\^{|";

	// Methods

	// RVA: 0x2187190 Offset: 0x2186390 VA: 0x182187190
	public WebProxyData Build() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void BuildInternal();

	// RVA: 0x2187D10 Offset: 0x2186F10 VA: 0x182187D10
	protected void SetProxyAndBypassList(string addressString, string bypassListString) { }

	// RVA: 0x2187C70 Offset: 0x2186E70 VA: 0x182187C70
	protected void SetAutoProxyUrl(string autoConfigUrl) { }

	// RVA: 0x2187C50 Offset: 0x2186E50 VA: 0x182187C50
	protected void SetAutoDetectSettings(bool value) { }

	// RVA: 0x2187B60 Offset: 0x2186D60 VA: 0x182187B60
	private static Uri ParseProxyUri(string proxyString) { }

	// RVA: 0x2187880 Offset: 0x2186A80 VA: 0x182187880
	private static Hashtable ParseProtocolProxies(string proxyListString) { }

	// RVA: 0x2187600 Offset: 0x2186800 VA: 0x182187600
	private static FormatException CreateInvalidProxyStringException(string originalProxyString) { }

	// RVA: 0x2187200 Offset: 0x2186400 VA: 0x182187200
	private static string BypassStringEscape(string rawString) { }

	// RVA: 0x21874E0 Offset: 0x21866E0 VA: 0x1821874E0
	private static string ConvertRegexReservedChars(string rawString) { }

	// RVA: 0x21876E0 Offset: 0x21868E0 VA: 0x1821876E0
	private static ArrayList ParseBypassList(string bypassListString, out bool bypassOnLocal) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net
[Serializable]
internal sealed class EmptyWebProxy : IAutoWebProxy, IWebProxy // TypeDefIndex: 5874
{
	// Fields
	private ICredentials m_credentials; // 0x10

	// Properties
	public ICredentials Credentials { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 5
	public Uri GetProxy(Uri uri) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	public bool IsBypassed(Uri uri) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 7
	public ICredentials get_Credentials() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 8
	public void set_Credentials(ICredentials value) { }

	// RVA: 0x217EEE0 Offset: 0x217E0E0 VA: 0x18217EEE0 Slot: 4
	private ProxyChain System.Net.IAutoWebProxy.GetProxies(Uri destination) { }
}

// Namespace: System.Net
internal enum CookieVariant // TypeDefIndex: 5875
{
	// Fields
	public int value__; // 0x0
	public const CookieVariant Unknown = 0;
	public const CookieVariant Plain = 1;
	public const CookieVariant Rfc2109 = 2;
	public const CookieVariant Rfc2965 = 3;
	public const CookieVariant Default = 2;
}

// Namespace: System.Net
[Serializable]
public sealed class Cookie // TypeDefIndex: 5876
{
	// Fields
	internal const int MaxSupportedVersion = 1;
	internal const string CommentAttributeName = "Comment";
	internal const string CommentUrlAttributeName = "CommentURL";
	internal const string DiscardAttributeName = "Discard";
	internal const string DomainAttributeName = "Domain";
	internal const string ExpiresAttributeName = "Expires";
	internal const string MaxAgeAttributeName = "Max-Age";
	internal const string PathAttributeName = "Path";
	internal const string PortAttributeName = "Port";
	internal const string SecureAttributeName = "Secure";
	internal const string VersionAttributeName = "Version";
	internal const string HttpOnlyAttributeName = "HttpOnly";
	internal const string SeparatorLiteral = "; ";
	internal const string EqualsLiteral = "=";
	internal const string QuotesLiteral = "\"";
	internal const string SpecialAttributeLiteral = "$";
	internal static readonly char[] PortSplitDelimiters; // 0x0
	internal static readonly char[] Reserved2Name; // 0x8
	internal static readonly char[] Reserved2Value; // 0x10
	private static Comparer staticComparer; // 0x18
	private string m_comment; // 0x10
	private Uri m_commentUri; // 0x18
	private CookieVariant m_cookieVariant; // 0x20
	private bool m_discard; // 0x24
	private string m_domain; // 0x28
	private bool m_domain_implicit; // 0x30
	private DateTime m_expires; // 0x38
	private string m_name; // 0x40
	private string m_path; // 0x48
	private bool m_path_implicit; // 0x50
	private string m_port; // 0x58
	private bool m_port_implicit; // 0x60
	private int[] m_port_list; // 0x68
	private bool m_secure; // 0x70
	[OptionalField]
	private bool m_httpOnly; // 0x71
	private DateTime m_timeStamp; // 0x78
	private string m_value; // 0x80
	private int m_version; // 0x88
	private string m_domainKey; // 0x90
	internal bool IsQuotedVersion; // 0x98
	internal bool IsQuotedDomain; // 0x99

	// Properties
	public string Comment { get; set; }
	public Uri CommentUri { get; set; }
	public bool HttpOnly { get; set; }
	public bool Discard { get; set; }
	public string Domain { get; set; }
	private string _Domain { get; }
	internal bool DomainImplicit { get; set; }
	public bool Expired { get; set; }
	public DateTime Expires { get; set; }
	public string Name { get; set; }
	public string Path { get; set; }
	private string _Path { get; }
	internal bool Plain { get; }
	public string Port { get; set; }
	internal int[] PortList { get; }
	private string _Port { get; }
	public bool Secure { get; set; }
	public DateTime TimeStamp { get; }
	public string Value { get; set; }
	internal CookieVariant Variant { get; set; }
	internal string DomainKey { get; }
	public int Version { get; set; }
	private string _Version { get; }

	// Methods

	// RVA: 0x217DC60 Offset: 0x217CE60 VA: 0x18217DC60
	public void .ctor() { }

	// RVA: 0x217DEC0 Offset: 0x217D0C0 VA: 0x18217DEC0
	public void .ctor(string name, string value) { }

	// RVA: 0x217DD90 Offset: 0x217CF90 VA: 0x18217DD90
	public void .ctor(string name, string value, string path) { }

	// RVA: 0x217DE00 Offset: 0x217D000 VA: 0x18217DE00
	public void .ctor(string name, string value, string path, string domain) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Comment() { }

	// RVA: 0x217E530 Offset: 0x217D730 VA: 0x18217E530
	public void set_Comment(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Uri get_CommentUri() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_CommentUri(Uri value) { }

	// RVA: 0x53DC80 Offset: 0x53CE80 VA: 0x18053DC80
	public bool get_HttpOnly() { }

	// RVA: 0x1826FC0 Offset: 0x18261C0 VA: 0x181826FC0
	public void set_HttpOnly(bool value) { }

	// RVA: 0x695F30 Offset: 0x695130 VA: 0x180695F30
	public bool get_Discard() { }

	// RVA: 0x7428E0 Offset: 0x741AE0 VA: 0x1807428E0
	public void set_Discard(bool value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Domain() { }

	// RVA: 0x217E590 Offset: 0x217D790 VA: 0x18217E590
	public void set_Domain(string value) { }

	// RVA: 0x217E220 Offset: 0x217D420 VA: 0x18217E220
	private string get__Domain() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	internal bool get_DomainImplicit() { }

	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	internal void set_DomainImplicit(bool value) { }

	// RVA: 0x217E160 Offset: 0x217D360 VA: 0x18217E160
	public bool get_Expired() { }

	// RVA: 0x217E610 Offset: 0x217D810 VA: 0x18217E610
	public void set_Expired(bool value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public DateTime get_Expires() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Expires(DateTime value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_Name() { }

	// RVA: 0x217E670 Offset: 0x217D870 VA: 0x18217E670
	public void set_Name(string value) { }

	// RVA: 0x217C1A0 Offset: 0x217B3A0 VA: 0x18217C1A0
	internal bool InternalSetName(string value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_Path() { }

	// RVA: 0x217E7D0 Offset: 0x217D9D0 VA: 0x18217E7D0
	public void set_Path(string value) { }

	// RVA: 0x217E2F0 Offset: 0x217D4F0 VA: 0x18217E2F0
	private string get__Path() { }

	// RVA: 0x2039F90 Offset: 0x2039190 VA: 0x182039F90
	internal bool get_Plain() { }

	// RVA: 0x217BC80 Offset: 0x217AE80 VA: 0x18217BC80
	internal Cookie Clone() { }

	// RVA: 0x217C2A0 Offset: 0x217B4A0 VA: 0x18217C2A0
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x217CB40 Offset: 0x217BD40 VA: 0x18217CB40
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x217BE50 Offset: 0x217B050 VA: 0x18217BE50
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_Port() { }

	// RVA: 0x217E830 Offset: 0x217DA30 VA: 0x18217E830
	public void set_Port(string value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	internal int[] get_PortList() { }

	// RVA: 0x217E370 Offset: 0x217D570 VA: 0x18217E370
	private string get__Port() { }

	// RVA: 0x6167C0 Offset: 0x6159C0 VA: 0x1806167C0
	public bool get_Secure() { }

	// RVA: 0x1826DA0 Offset: 0x1825FA0 VA: 0x181826DA0
	public void set_Secure(bool value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public DateTime get_TimeStamp() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public string get_Value() { }

	// RVA: 0x217ECD0 Offset: 0x217DED0 VA: 0x18217ECD0
	public void set_Value(string value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal CookieVariant get_Variant() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	internal void set_Variant(CookieVariant value) { }

	// RVA: 0x217E140 Offset: 0x217D340 VA: 0x18217E140
	internal string get_DomainKey() { }

	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950
	public int get_Version() { }

	// RVA: 0x217ED30 Offset: 0x217DF30 VA: 0x18217ED30
	public void set_Version(int value) { }

	// RVA: 0x217E430 Offset: 0x217D630 VA: 0x18217E430
	private string get__Version() { }

	// RVA: 0x217BFF0 Offset: 0x217B1F0 VA: 0x18217BFF0
	internal static IComparer GetComparer() { }

	// RVA: 0x217BEE0 Offset: 0x217B0E0 VA: 0x18217BEE0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x217C040 Offset: 0x217B240 VA: 0x18217C040 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x217C680 Offset: 0x217B880 VA: 0x18217C680 Slot: 3
	public override string ToString() { }

	// RVA: 0x217C300 Offset: 0x217B500 VA: 0x18217C300
	internal string ToServerString() { }

	// RVA: 0x217DB10 Offset: 0x217CD10 VA: 0x18217DB10
	private static void .cctor() { }
}

// Namespace: System.Net
internal enum CookieToken // TypeDefIndex: 5877
{
	// Fields
	public int value__; // 0x0
	public const CookieToken Nothing = 0;
	public const CookieToken NameValuePair = 1;
	public const CookieToken Attribute = 2;
	public const CookieToken EndToken = 3;
	public const CookieToken EndCookie = 4;
	public const CookieToken End = 5;
	public const CookieToken Equals = 6;
	public const CookieToken Comment = 7;
	public const CookieToken CommentUrl = 8;
	public const CookieToken CookieName = 9;
	public const CookieToken Discard = 10;
	public const CookieToken Domain = 11;
	public const CookieToken Expires = 12;
	public const CookieToken MaxAge = 13;
	public const CookieToken Path = 14;
	public const CookieToken Port = 15;
	public const CookieToken Secure = 16;
	public const CookieToken HttpOnly = 17;
	public const CookieToken Unknown = 18;
	public const CookieToken Version = 19;
}

// Namespace: 
private struct CookieTokenizer.RecognizedAttribute // TypeDefIndex: 5878
{
	// Fields
	private string m_name; // 0x0
	private CookieToken m_token; // 0x8

	// Properties
	internal CookieToken Token { get; }

	// Methods

	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	internal void .ctor(string name, CookieToken token) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	internal CookieToken get_Token() { }

	// RVA: 0x2183720 Offset: 0x2182920 VA: 0x182183720
	internal bool IsEqualTo(string value) { }
}

// Namespace: System.Net
internal class CookieTokenizer // TypeDefIndex: 5879
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x217BC30 Offset: 0x217AE30 VA: 0x18217BC30
	internal void .ctor(string tokenStream) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	internal bool get_EndOfCookie() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x217BC70 Offset: 0x217AE70 VA: 0x18217BC70
	internal bool get_Eof() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal string get_Name() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_Name(string value) { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	internal bool get_Quoted() { }

	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	internal void set_Quoted(bool value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	internal CookieToken get_Token() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	internal void set_Token(CookieToken value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal string get_Value() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_Value(string value) { }

	// RVA: 0x217B080 Offset: 0x217A280 VA: 0x18217B080
	internal string Extract() { }

	// RVA: 0x217B100 Offset: 0x217A300 VA: 0x18217B100
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x217B370 Offset: 0x217A570 VA: 0x18217B370
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x217B600 Offset: 0x217A800 VA: 0x18217B600
	internal void Reset() { }

	// RVA: 0x217B670 Offset: 0x217A870 VA: 0x18217B670
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x217B870 Offset: 0x217AA70 VA: 0x18217B870
	private static void .cctor() { }
}

// Namespace: System.Net
internal class CookieParser // TypeDefIndex: 5880
{
	// Fields
	private CookieTokenizer m_tokenizer; // 0x10
	private Cookie m_savedCookie; // 0x18

	// Methods

	// RVA: 0x217B000 Offset: 0x217A200 VA: 0x18217B000
	internal void .ctor(string cookieString) { }

	// RVA: 0x217A5D0 Offset: 0x21797D0 VA: 0x18217A5D0
	internal Cookie Get() { }

	// RVA: 0x2179FD0 Offset: 0x21791D0 VA: 0x182179FD0
	internal Cookie GetServer() { }

	// RVA: 0x2179F20 Offset: 0x2179120 VA: 0x182179F20
	internal static string CheckQuoted(string value) { }
}

// Namespace: System.Net
internal class Comparer : IComparer // TypeDefIndex: 5881
{
	// Methods

	// RVA: 0x2174380 Offset: 0x2173580 VA: 0x182174380 Slot: 4
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal enum CookieCollection.Stamp // TypeDefIndex: 5882
{
	// Fields
	public int value__; // 0x0
	public const CookieCollection.Stamp Check = 0;
	public const CookieCollection.Stamp Set = 1;
	public const CookieCollection.Stamp SetToUnused = 2;
	public const CookieCollection.Stamp SetToMaxUsed = 3;
}

// Namespace: 
private class CookieCollection.CookieCollectionEnumerator : IEnumerator // TypeDefIndex: 5883
{
	// Fields
	private CookieCollection m_cookies; // 0x10
	private int m_count; // 0x18
	private int m_index; // 0x1C
	private int m_version; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x2174630 Offset: 0x2173830 VA: 0x182174630
	internal void .ctor(CookieCollection cookies) { }

	// RVA: 0x2174530 Offset: 0x2173730 VA: 0x182174530 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2174470 Offset: 0x2173670 VA: 0x182174470 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x2174520 Offset: 0x2173720 VA: 0x182174520 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
}

// Namespace: System.Net
[DefaultMember("Item")]
[Serializable]
public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 5884
{
	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	[OptionalField]
	private bool m_IsReadOnly; // 0x29

	// Properties
	public bool IsReadOnly { get; }
	public Cookie Item { get; }
	public Cookie Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	internal bool IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0x21751F0 Offset: 0x21743F0 VA: 0x1821751F0
	public void .ctor() { }

	// RVA: 0x2175290 Offset: 0x2174490 VA: 0x182175290
	internal void .ctor(bool IsReadOnly) { }

	// RVA: 0x4C6AB0 Offset: 0x4C5CB0 VA: 0x1804C6AB0
	public bool get_IsReadOnly() { }

	// RVA: 0x2175340 Offset: 0x2174540 VA: 0x182175340
	public Cookie get_Item(int index) { }

	// RVA: 0x2175440 Offset: 0x2174640 VA: 0x182175440
	public Cookie get_Item(string name) { }

	// RVA: 0x2174690 Offset: 0x2173890 VA: 0x182174690
	public void Add(Cookie cookie) { }

	// RVA: 0x2174760 Offset: 0x2173960 VA: 0x182174760
	public void Add(CookieCollection cookies) { }

	// RVA: 0x15D62B0 Offset: 0x15D54B0 VA: 0x1815D62B0 Slot: 5
	public int get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x2174AA0 Offset: 0x2173CA0 VA: 0x182174AA0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x2174AA0 Offset: 0x2173CA0 VA: 0x182174AA0
	public void CopyTo(Cookie[] array, int index) { }

	// RVA: 0x21750F0 Offset: 0x21742F0 VA: 0x1821750F0
	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x2174D80 Offset: 0x2173F80 VA: 0x182174D80
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x2174B60 Offset: 0x2173D60 VA: 0x182174B60
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x21750C0 Offset: 0x21742C0 VA: 0x1821750C0
	internal void RemoveAt(int idx) { }

	// RVA: 0x2174AD0 Offset: 0x2173CD0 VA: 0x182174AD0 Slot: 8
	public IEnumerator GetEnumerator() { }
}

// Namespace: System.Net
internal struct HeaderVariantInfo // TypeDefIndex: 5885
{
	// Fields
	private string m_name; // 0x0
	private CookieVariant m_variant; // 0x8

	// Properties
	internal string Name { get; }
	internal CookieVariant Variant { get; }

	// Methods

	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	internal void .ctor(string name, CookieVariant variant) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	internal string get_Name() { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	internal CookieVariant get_Variant() { }
}

// Namespace: System.Net
[Serializable]
public class CookieContainer // TypeDefIndex: 5886
{
	// Fields
	public const int DefaultCookieLimit = 300;
	public const int DefaultPerDomainCookieLimit = 20;
	public const int DefaultCookieLengthLimit = 4096;
	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28

	// Properties
	public int Capacity { get; set; }
	public int Count { get; }
	public int MaxCookieSize { get; set; }
	public int PerDomainCapacity { get; set; }

	// Methods

	// RVA: 0x2179B90 Offset: 0x2178D90 VA: 0x182179B90
	public void .ctor() { }

	// RVA: 0x21796F0 Offset: 0x21788F0 VA: 0x1821796F0
	public void .ctor(int capacity) { }

	// RVA: 0x2179850 Offset: 0x2178A50 VA: 0x182179850
	public void .ctor(int capacity, int perDomainCapacity, int maxCookieSize) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_Capacity() { }

	// RVA: 0x2179C80 Offset: 0x2178E80 VA: 0x182179C80
	public void set_Capacity(int value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_Count() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_MaxCookieSize() { }

	// RVA: 0x2179E20 Offset: 0x2179020 VA: 0x182179E20
	public void set_MaxCookieSize(int value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_PerDomainCapacity() { }

	// RVA: 0x2179E90 Offset: 0x2179090 VA: 0x182179E90
	public void set_PerDomainCapacity(int value) { }

	// RVA: 0x2176150 Offset: 0x2175350 VA: 0x182176150
	public void Add(Cookie cookie) { }

	// RVA: 0x21755F0 Offset: 0x21747F0 VA: 0x1821755F0
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x2175720 Offset: 0x2174920 VA: 0x182175720
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x2176AE0 Offset: 0x2175CE0 VA: 0x182176AE0
	private bool AgeCookies(string domain) { }

	// RVA: 0x21785C0 Offset: 0x21777C0 VA: 0x1821785C0
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x2175EC0 Offset: 0x21750C0 VA: 0x182175EC0
	public void Add(CookieCollection cookies) { }

	// RVA: 0x2179080 Offset: 0x2178280 VA: 0x182179080
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x2176950 Offset: 0x2175B50 VA: 0x182176950
	public void Add(Uri uri, Cookie cookie) { }

	// RVA: 0x21765B0 Offset: 0x21757B0 VA: 0x1821765B0
	public void Add(Uri uri, CookieCollection cookies) { }

	// RVA: 0x2177E70 Offset: 0x2177070 VA: 0x182177E70
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x2178B60 Offset: 0x2177D60 VA: 0x182178B60
	public CookieCollection GetCookies(Uri uri) { }

	// RVA: 0x2178C20 Offset: 0x2177E20 VA: 0x182178C20
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x2177840 Offset: 0x2176A40 VA: 0x182177840
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x2179320 Offset: 0x2178520 VA: 0x182179320
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x2178730 Offset: 0x2177930 VA: 0x182178730
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x2178800 Offset: 0x2177A00 VA: 0x182178800
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x2179500 Offset: 0x2178700 VA: 0x182179500
	public void SetCookies(Uri uri, string cookieHeader) { }

	// RVA: 0x2179620 Offset: 0x2178820 VA: 0x182179620
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
private class PathList.PathListComparer : IComparer // TypeDefIndex: 5887
{
	// Fields
	internal static readonly PathList.PathListComparer StaticInstance; // 0x0

	// Methods

	// RVA: 0x21A3380 Offset: 0x21A2580 VA: 0x1821A3380 Slot: 4
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21A34F0 Offset: 0x21A26F0 VA: 0x1821A34F0
	private static void .cctor() { }
}

// Namespace: System.Net
[DefaultMember("Item")]
[Serializable]
internal class PathList // TypeDefIndex: 5888
{
	// Fields
	private SortedList m_list; // 0x10

	// Properties
	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x21A3860 Offset: 0x21A2A60 VA: 0x1821A3860
	public void .ctor() { }

	// RVA: 0x17192C0 Offset: 0x17184C0 VA: 0x1817192C0
	public int get_Count() { }

	// RVA: 0x21A3550 Offset: 0x21A2750 VA: 0x1821A3550
	public int GetCookiesCount() { }

	// RVA: 0x1718E10 Offset: 0x1718010 VA: 0x181718E10
	public ICollection get_Values() { }

	// RVA: 0x2116980 Offset: 0x2115B80 VA: 0x182116980
	public object get_Item(string s) { }

	// RVA: 0x21A3910 Offset: 0x21A2B10 VA: 0x1821A3910
	public void set_Item(string s, object value) { }

	// RVA: 0x154B250 Offset: 0x154A450 VA: 0x18154B250
	public IEnumerator GetEnumerator() { }

	// RVA: 0x17384E0 Offset: 0x17376E0 VA: 0x1817384E0
	public object get_SyncRoot() { }
}

// Namespace: System.Net
[Serializable]
public class CookieException : FormatException, ISerializable // TypeDefIndex: 5889
{
	// Methods

	// RVA: 0x218F280 Offset: 0x218E480 VA: 0x18218F280
	public void .ctor() { }

	// RVA: 0x218F260 Offset: 0x218E460 VA: 0x18218F260
	internal void .ctor(string message) { }

	// RVA: 0x218F270 Offset: 0x218E470 VA: 0x18218F270
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x15A17F0 Offset: 0x15A09F0 VA: 0x1815A17F0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2161650 Offset: 0x2160850 VA: 0x182161650 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2161650 Offset: 0x2160850 VA: 0x182161650 Slot: 15
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Net
[Serializable]
public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 5890
{
	// Fields
	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private string m_connectionGroupName; // 0x38
	private long m_contentLength; // 0x40
	private ICredentials m_credentials; // 0x48
	private FileAccess m_fileAccess; // 0x50
	private WebHeaderCollection m_headers; // 0x58
	private string m_method; // 0x60
	private bool m_preauthenticate; // 0x68
	private IWebProxy m_proxy; // 0x70
	private ManualResetEvent m_readerEvent; // 0x78
	private bool m_readPending; // 0x80
	private WebResponse m_response; // 0x88
	private Stream m_stream; // 0x90
	private bool m_syncHint; // 0x98
	private int m_timeout; // 0x9C
	private Uri m_uri; // 0xA0
	private bool m_writePending; // 0xA8
	private bool m_writing; // 0xA9
	private LazyAsyncResult m_WriteAResult; // 0xB0
	private LazyAsyncResult m_ReadAResult; // 0xB8
	private int m_Aborted; // 0xC0

	// Properties
	internal bool Aborted { get; }
	public override string ConnectionGroupName { get; set; }
	public override long ContentLength { get; set; }
	public override string ContentType { get; set; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override bool PreAuthenticate { get; set; }
	public override IWebProxy Proxy { get; set; }
	public override int Timeout { get; set; }
	public override Uri RequestUri { get; }
	public override bool UseDefaultCredentials { get; set; }

	// Methods

	// RVA: 0x2199520 Offset: 0x2198720 VA: 0x182199520
	internal void .ctor(Uri uri) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x2199680 Offset: 0x2198880 VA: 0x182199680
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2189950 Offset: 0x2188B50 VA: 0x182189950 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2198810 Offset: 0x2197A10 VA: 0x182198810 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2199AA0 Offset: 0x2198CA0 VA: 0x182199AA0
	internal bool get_Aborted() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 14
	public override string get_ConnectionGroupName() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50 Slot: 15
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 18
	public override long get_ContentLength() { }

	// RVA: 0x2199B30 Offset: 0x2198D30 VA: 0x182199B30 Slot: 19
	public override void set_ContentLength(long value) { }

	// RVA: 0x2199AB0 Offset: 0x2198CB0 VA: 0x182199AB0 Slot: 20
	public override string get_ContentType() { }

	// RVA: 0x2199BC0 Offset: 0x2198DC0 VA: 0x182199BC0 Slot: 21
	public override void set_ContentType(string value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 22
	public override ICredentials get_Credentials() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200 Slot: 23
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 16
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 11
	public override string get_Method() { }

	// RVA: 0x2199C20 Offset: 0x2198E20 VA: 0x182199C20 Slot: 12
	public override void set_Method(string value) { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40 Slot: 28
	public override bool get_PreAuthenticate() { }

	// RVA: 0x2199CF0 Offset: 0x2198EF0 VA: 0x182199CF0 Slot: 29
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 26
	public override IWebProxy get_Proxy() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30 Slot: 27
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1944140 Offset: 0x1943340 VA: 0x181944140 Slot: 30
	public override int get_Timeout() { }

	// RVA: 0x2199D00 Offset: 0x2198F00 VA: 0x182199D00 Slot: 31
	public override void set_Timeout(int value) { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0 Slot: 13
	public override Uri get_RequestUri() { }

	// RVA: 0x2197D80 Offset: 0x2196F80 VA: 0x182197D80 Slot: 36
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x21980C0 Offset: 0x21972C0 VA: 0x1821980C0 Slot: 34
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x21982F0 Offset: 0x21974F0 VA: 0x1821982F0
	private bool CanGetRequestStream() { }

	// RVA: 0x2198350 Offset: 0x2197550 VA: 0x182198350 Slot: 37
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x21985B0 Offset: 0x21977B0 VA: 0x1821985B0 Slot: 35
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x2198CB0 Offset: 0x2197EB0 VA: 0x182198CB0 Slot: 32
	public override Stream GetRequestStream() { }

	// RVA: 0x21991C0 Offset: 0x21983C0 VA: 0x1821991C0 Slot: 33
	public override WebResponse GetResponse() { }

	// RVA: 0x2198A70 Offset: 0x2197C70 VA: 0x182198A70
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x2198EB0 Offset: 0x21980B0 VA: 0x182198EB0
	private static void GetResponseCallback(object state) { }

	// RVA: 0x21993C0 Offset: 0x21985C0 VA: 0x1821993C0
	internal void UnblockReader() { }

	// RVA: 0x2199B00 Offset: 0x2198D00 VA: 0x182199B00 Slot: 24
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x2199D90 Offset: 0x2198F90 VA: 0x182199D90 Slot: 25
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x2197B40 Offset: 0x2196D40 VA: 0x182197B40 Slot: 40
	public override void Abort() { }

	// RVA: 0x2199460 Offset: 0x2198660 VA: 0x182199460
	private static void .cctor() { }
}

// Namespace: System.Net
internal class FileWebRequestCreator : IWebRequestCreate // TypeDefIndex: 5891
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x21979C0 Offset: 0x2196BC0 VA: 0x1821979C0 Slot: 4
	public WebRequest Create(Uri uri) { }
}

// Namespace: System.Net
internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 5892
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x219AC00 Offset: 0x2199E00 VA: 0x18219AC00
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x219AC90 Offset: 0x2199E90 VA: 0x18219AC90
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x219A980 Offset: 0x2199B80 VA: 0x18219A980 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x219AB20 Offset: 0x2199D20 VA: 0x18219AB20 Slot: 42
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x219AA90 Offset: 0x2199C90 VA: 0x18219AA90 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x219AB70 Offset: 0x2199D70 VA: 0x18219AB70 Slot: 37
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x219A780 Offset: 0x2199980 VA: 0x18219A780 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x219AA10 Offset: 0x2199C10 VA: 0x18219AA10 Slot: 25
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x219A830 Offset: 0x2199A30 VA: 0x18219A830 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x219AA50 Offset: 0x2199C50 VA: 0x18219AA50 Slot: 29
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x219A8E0 Offset: 0x2199AE0 VA: 0x18219A8E0
	private void CheckError() { }
}

// Namespace: System.Net
[Serializable]
public class FileWebResponse : WebResponse, ISerializable, ICloseEx // TypeDefIndex: 5893
{
	// Fields
	private const int DefaultFileStreamBufferSize = 8192;
	private const string DefaultFileContentType = "application/octet-stream";
	private bool m_closed; // 0x20
	private long m_contentLength; // 0x28
	private FileAccess m_fileAccess; // 0x30
	private WebHeaderCollection m_headers; // 0x38
	private Stream m_stream; // 0x40
	private Uri m_uri; // 0x48

	// Properties
	public override long ContentLength { get; }
	public override string ContentType { get; }
	public override WebHeaderCollection Headers { get; }
	public override bool SupportsHeaders { get; }
	public override Uri ResponseUri { get; }

	// Methods

	// RVA: 0x219A430 Offset: 0x2199630 VA: 0x18219A430
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x219A170 Offset: 0x2199370 VA: 0x18219A170
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2189950 Offset: 0x2188B50 VA: 0x182189950 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2199E90 Offset: 0x2199090 VA: 0x182199E90 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x219A6E0 Offset: 0x21998E0 VA: 0x18219A6E0 Slot: 14
	public override long get_ContentLength() { }

	// RVA: 0x219A700 Offset: 0x2199900 VA: 0x18219A700 Slot: 16
	public override string get_ContentType() { }

	// RVA: 0x219A740 Offset: 0x2199940 VA: 0x18219A740 Slot: 20
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 21
	public override bool get_SupportsHeaders() { }

	// RVA: 0x219A760 Offset: 0x2199960 VA: 0x18219A760 Slot: 19
	public override Uri get_ResponseUri() { }

	// RVA: 0x2199DC0 Offset: 0x2198FC0 VA: 0x182199DC0
	private void CheckDisposed() { }

	// RVA: 0x2199E50 Offset: 0x2199050 VA: 0x182199E50 Slot: 9
	public override void Close() { }

	// RVA: 0x219A060 Offset: 0x2199260 VA: 0x18219A060 Slot: 22
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x219A020 Offset: 0x2199220 VA: 0x18219A020 Slot: 18
	public override Stream GetResponseStream() { }
}

// Namespace: System.Net
public interface IWebProxy // TypeDefIndex: 5894
{
	// Properties
	public abstract ICredentials Credentials { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Uri GetProxy(Uri destination);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsBypassed(Uri host);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICredentials get_Credentials();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Credentials(ICredentials value);
}

// Namespace: System.Net
internal class WebProxyData // TypeDefIndex: 5895
{
	// Fields
	internal bool bypassOnLocal; // 0x10
	internal bool automaticallyDetectSettings; // 0x11
	internal Uri proxyAddress; // 0x18
	internal Hashtable proxyHostAddresses; // 0x20
	internal Uri scriptLocation; // 0x28
	internal ArrayList bypassList; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
[Serializable]
public class WebProxy : IAutoWebProxy, IWebProxy, ISerializable // TypeDefIndex: 5896
{
	// Fields
	private bool _UseRegistry; // 0x10
	private bool _BypassOnLocal; // 0x11
	private bool m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Properties
	public Uri Address { get; set; }
	internal bool AutoDetect { set; }
	internal Uri ScriptLocation { set; }
	public bool BypassProxyOnLocal { get; set; }
	public string[] BypassList { get; set; }
	public ICredentials Credentials { get; set; }
	public bool UseDefaultCredentials { get; set; }
	public ArrayList BypassArrayList { get; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; set; }

	// Methods

	// RVA: 0x21A5CE0 Offset: 0x21A4EE0 VA: 0x1821A5CE0
	public void .ctor() { }

	// RVA: 0x21A60A0 Offset: 0x21A52A0 VA: 0x1821A60A0
	public void .ctor(Uri Address) { }

	// RVA: 0x21A5EF0 Offset: 0x21A50F0 VA: 0x1821A5EF0
	public void .ctor(Uri Address, bool BypassOnLocal) { }

	// RVA: 0x21A5A00 Offset: 0x21A4C00 VA: 0x1821A5A00
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList) { }

	// RVA: 0x21A5D30 Offset: 0x21A4F30 VA: 0x1821A5D30
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x21A5DE0 Offset: 0x21A4FE0 VA: 0x1821A5DE0
	public void .ctor(string Host, int Port) { }

	// RVA: 0x21A5AB0 Offset: 0x21A4CB0 VA: 0x1821A5AB0
	public void .ctor(string Address) { }

	// RVA: 0x21A5900 Offset: 0x21A4B00 VA: 0x1821A5900
	public void .ctor(string Address, bool BypassOnLocal) { }

	// RVA: 0x21A5F60 Offset: 0x21A5160 VA: 0x1821A5F60
	public void .ctor(string Address, bool BypassOnLocal, string[] BypassList) { }

	// RVA: 0x21A5BA0 Offset: 0x21A4DA0 VA: 0x1821A5BA0
	public void .ctor(string Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Uri get_Address() { }

	// RVA: 0x21A6660 Offset: 0x21A5860 VA: 0x1821A6660
	public void set_Address(Uri value) { }

	// RVA: 0x21A6680 Offset: 0x21A5880 VA: 0x1821A6680
	internal void set_AutoDetect(bool value) { }

	// RVA: 0x21A67B0 Offset: 0x21A59B0 VA: 0x1821A67B0
	internal void set_ScriptLocation(Uri value) { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_BypassProxyOnLocal() { }

	// RVA: 0x21A6790 Offset: 0x21A5990 VA: 0x1821A6790
	public void set_BypassProxyOnLocal(bool value) { }

	// RVA: 0x21A64E0 Offset: 0x21A56E0 VA: 0x1821A64E0
	public string[] get_BypassList() { }

	// RVA: 0x21A6700 Offset: 0x21A5900 VA: 0x1821A6700
	public void set_BypassList(string[] value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 7
	public ICredentials get_Credentials() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650 Slot: 8
	public void set_Credentials(ICredentials value) { }

	// RVA: 0x21A65E0 Offset: 0x21A57E0 VA: 0x1821A65E0
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x21A6830 Offset: 0x21A5A30 VA: 0x1821A6830
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x21A6470 Offset: 0x21A5670 VA: 0x1821A6470
	public ArrayList get_BypassArrayList() { }

	// RVA: 0x767080 Offset: 0x766280 VA: 0x180767080
	internal void CheckForChanges() { }

	// RVA: 0x21A4AA0 Offset: 0x21A3CA0 VA: 0x1821A4AA0 Slot: 5
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x21A46E0 Offset: 0x21A38E0 VA: 0x1821A46E0
	private static Uri CreateProxyUri(string address) { }

	// RVA: 0x21A5600 Offset: 0x21A4800 VA: 0x1821A5600
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x21A52C0 Offset: 0x21A44C0 VA: 0x1821A52C0
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x21A5140 Offset: 0x21A4340 VA: 0x1821A5140
	private bool IsLocal(Uri host) { }

	// RVA: 0x21A5040 Offset: 0x21A4240 VA: 0x1821A5040
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x21A4F70 Offset: 0x21A4170 VA: 0x1821A4F70 Slot: 6
	public bool IsBypassed(Uri host) { }

	// RVA: 0x21A4C90 Offset: 0x21A3E90 VA: 0x1821A4C90
	private bool IsBypassedManual(Uri host) { }

	[Obsolete("This method has been deprecated. Please use the proxy selected for you by default. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x21A47A0 Offset: 0x21A39A0 VA: 0x1821A47A0
	public static WebProxy GetDefaultProxy() { }

	// RVA: 0x21A6100 Offset: 0x21A5300 VA: 0x1821A6100
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21A55C0 Offset: 0x21A47C0 VA: 0x1821A55C0 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21A47F0 Offset: 0x21A39F0 VA: 0x1821A47F0 Slot: 10
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_ScriptEngine(AutoWebProxyScriptEngine value) { }

	// RVA: 0x21A4690 Offset: 0x21A3890 VA: 0x1821A4690
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x21A58D0 Offset: 0x21A4AD0 VA: 0x1821A58D0
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x21A4790 Offset: 0x21A3990 VA: 0x1821A4790
	internal void DeleteScriptEngine() { }

	// RVA: 0x21A55F0 Offset: 0x21A47F0 VA: 0x1821A55F0
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x21A57D0 Offset: 0x21A49D0 VA: 0x1821A57D0
	internal void Update(WebProxyData webProxyData) { }

	// RVA: 0x21A54E0 Offset: 0x21A46E0 VA: 0x1821A54E0 Slot: 4
	private ProxyChain System.Net.IAutoWebProxy.GetProxies(Uri destination) { }

	// RVA: 0x21A4A60 Offset: 0x21A3C60 VA: 0x1821A4A60
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x21A4C60 Offset: 0x21A3E60 VA: 0x1821A4C60
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x21A4940 Offset: 0x21A3B40 VA: 0x1821A4940
	internal Uri[] GetProxiesAuto(Uri destination, ref int syncStatus) { }

	// RVA: 0x767080 Offset: 0x766280 VA: 0x180767080
	internal void AbortGetProxiesAuto(ref int syncStatus) { }

	// RVA: 0x21A4980 Offset: 0x21A3B80 VA: 0x1821A4980
	internal Uri GetProxyAutoFailover(Uri destination) { }

	// RVA: 0x21A4520 Offset: 0x21A3720 VA: 0x1821A4520
	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	// RVA: 0x21A5450 Offset: 0x21A4650 VA: 0x1821A5450
	private static Uri ProxyUri(string proxyName) { }
}

// Namespace: System.Net
internal class AutoWebProxyScriptEngine // TypeDefIndex: 5897
{
	// Fields
	[CompilerGenerated]
	private Uri <AutomaticConfigurationScript>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <AutomaticallyDetectSettings>k__BackingField; // 0x18

	// Properties
	public Uri AutomaticConfigurationScript { get; set; }
	public bool AutomaticallyDetectSettings { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor(WebProxy proxy, bool useRegistry) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Uri get_AutomaticConfigurationScript() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_AutomaticConfigurationScript(Uri value) { }

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_AutomaticallyDetectSettings() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_AutomaticallyDetectSettings(bool value) { }

	// RVA: 0x1D59220 Offset: 0x1D58420 VA: 0x181D59220
	public bool GetProxies(Uri destination, out IList<string> proxyList) { }

	// RVA: 0x1D59220 Offset: 0x1D58420 VA: 0x181D59220
	public bool GetProxies(Uri destination, out IList<string> proxyList, ref int syncStatus) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Close() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Abort(ref int syncStatus) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void CheckForChanges() { }
}

// Namespace: 
internal static class UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID // TypeDefIndex: 5898
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x219AE80 Offset: 0x219A080 VA: 0x18219AE80
	internal static string ToString(int position) { }

	// RVA: 0x219AEF0 Offset: 0x219A0F0 VA: 0x18219AEF0
	private static void .cctor() { }
}

// Namespace: 
internal static class UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE_HEADER_ID // TypeDefIndex: 5899
{
	// Fields
	private static Hashtable m_Hashtable; // 0x0

	// Methods

	// RVA: 0x219B620 Offset: 0x219A820 VA: 0x18219B620
	private static void .cctor() { }

	// RVA: 0x219B4F0 Offset: 0x219A6F0 VA: 0x18219B4F0
	internal static int IndexOfKnownHeader(string HeaderName) { }

	// RVA: 0x219B5B0 Offset: 0x219A7B0 VA: 0x18219B5B0
	internal static string ToString(int position) { }
}

// Namespace: 
internal enum UnsafeNclNativeMethods.HttpApi.Enum // TypeDefIndex: 5900
{
	// Fields
	public int value__; // 0x0
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderCacheControl = 0;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderConnection = 1;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderDate = 2;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderKeepAlive = 3;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderPragma = 4;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderTrailer = 5;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderTransferEncoding = 6;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderUpgrade = 7;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderVia = 8;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderWarning = 9;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderAllow = 10;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderContentLength = 11;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderContentType = 12;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderContentEncoding = 13;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderContentLanguage = 14;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderContentLocation = 15;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderContentMd5 = 16;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderContentRange = 17;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderExpires = 18;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderLastModified = 19;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderAcceptRanges = 20;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderAge = 21;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderEtag = 22;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderLocation = 23;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderProxyAuthenticate = 24;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderRetryAfter = 25;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderServer = 26;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderSetCookie = 27;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderVary = 28;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderWwwAuthenticate = 29;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderResponseMaximum = 30;
	public const UnsafeNclNativeMethods.HttpApi.Enum HttpHeaderMaximum = 41;
}

// Namespace: 
internal static class UnsafeNclNativeMethods.HttpApi // TypeDefIndex: 5901
{
	// Fields
	private const int HttpHeaderRequestMaximum = 41;
	private const int HttpHeaderResponseMaximum = 30;
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x219B760 Offset: 0x219A960 VA: 0x18219B760
	private static void .cctor() { }
}

// Namespace: 
internal static class UnsafeNclNativeMethods.SecureStringHelper // TypeDefIndex: 5902
{
	// Methods

	// RVA: 0x21A3B00 Offset: 0x21A2D00 VA: 0x1821A3B00
	internal static string CreateString(SecureString secureString) { }

	// RVA: 0x21A3A60 Offset: 0x21A2C60 VA: 0x1821A3A60
	internal static SecureString CreateSecureString(string plainString) { }
}

// Namespace: System.Net
internal static class UnsafeNclNativeMethods // TypeDefIndex: 5903
{}

// Namespace: System.Net
internal static class HttpSysSettings // TypeDefIndex: 5904
{
	// Fields
	public const bool EnableNonUtf8 = True;
	public const bool FavorUtf8 = True;
}

// Namespace: System.Net
internal static class Logging // TypeDefIndex: 5905
{
	// Properties
	internal static bool On { get; }
	internal static TraceSource Web { get; }
	internal static TraceSource HttpListener { get; }
	internal static TraceSource Sockets { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool get_On() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal static TraceSource get_Web() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal static TraceSource get_HttpListener() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal static TraceSource get_Sockets() { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void Enter(TraceSource traceSource, object obj, string method, object paramObject) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void Enter(TraceSource traceSource, string msg) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void Enter(TraceSource traceSource, string msg, string parameters) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void Exception(TraceSource traceSource, object obj, string method, Exception e) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void Exit(TraceSource traceSource, object obj, string method, object retObject) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void Exit(TraceSource traceSource, string msg) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void Exit(TraceSource traceSource, string msg, string parameters) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void PrintInfo(TraceSource traceSource, object obj, string method, string msg) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void PrintInfo(TraceSource traceSource, object obj, string msg) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void PrintInfo(TraceSource traceSource, string msg) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void PrintWarning(TraceSource traceSource, object obj, string method, string msg) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void PrintWarning(TraceSource traceSource, string msg) { }

	[Conditional("TRACE")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void PrintError(TraceSource traceSource, string msg) { }
}

// Namespace: System.Net
internal class TraceSource // TypeDefIndex: 5906
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class ServerCertValidationCallback.CallbackContext // TypeDefIndex: 5907
{
	// Fields
	internal readonly object request; // 0x10
	internal readonly X509Certificate certificate; // 0x18
	internal readonly X509Chain chain; // 0x20
	internal readonly SslPolicyErrors sslPolicyErrors; // 0x28
	internal bool result; // 0x2C

	// Methods

	// RVA: 0x1D73500 Offset: 0x1D72700 VA: 0x181D73500
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}

// Namespace: System.Net
internal class ServerCertValidationCallback // TypeDefIndex: 5908
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Properties
	internal RemoteCertificateValidationCallback ValidationCallback { get; }

	// Methods

	// RVA: 0x21A3E50 Offset: 0x21A3050 VA: 0x1821A3E50
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	// RVA: 0x21A3C30 Offset: 0x21A2E30 VA: 0x1821A3C30
	internal void Callback(object state) { }

	// RVA: 0x21A3D00 Offset: 0x21A2F00 VA: 0x1821A3D00
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}

// Namespace: System.Net
public class AuthenticationManager // TypeDefIndex: 5909
{
	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Properties
	public static ICredentialPolicy CredentialPolicy { get; set; }
	[MonoTODO]
	public static StringDictionary CustomTargetNameDictionary { get; }
	public static IEnumerator RegisteredModules { get; }
	[MonoTODO]
	internal static bool OSSupportsExtendedProtection { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x218D3A0 Offset: 0x218C5A0 VA: 0x18218D3A0
	private static void EnsureModules() { }

	// RVA: 0x218DDC0 Offset: 0x218CFC0 VA: 0x18218DDC0
	public static ICredentialPolicy get_CredentialPolicy() { }

	// RVA: 0x218DEC0 Offset: 0x218D0C0 VA: 0x18218DEC0
	public static void set_CredentialPolicy(ICredentialPolicy value) { }

	// RVA: 0x218D620 Offset: 0x218C820 VA: 0x18218D620
	private static Exception GetMustImplement() { }

	// RVA: 0x218DE10 Offset: 0x218D010 VA: 0x18218DE10
	public static StringDictionary get_CustomTargetNameDictionary() { }

	// RVA: 0x218DE50 Offset: 0x218D050 VA: 0x18218DE50
	public static IEnumerator get_RegisteredModules() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool get_OSSupportsExtendedProtection() { }

	// RVA: 0x218CBA0 Offset: 0x218BDA0 VA: 0x18218CBA0
	internal static void Clear() { }

	// RVA: 0x218CA40 Offset: 0x218BC40 VA: 0x18218CA40
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x218CCB0 Offset: 0x218BEB0 VA: 0x18218CCB0
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x218D670 Offset: 0x218C870 VA: 0x18218D670
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x218DA40 Offset: 0x218CC40 VA: 0x18218DA40
	public static void Register(IAuthenticationModule authenticationModule) { }

	// RVA: 0x218DC80 Offset: 0x218CE80 VA: 0x18218DC80
	public static void Unregister(IAuthenticationModule authenticationModule) { }

	// RVA: 0x218DBE0 Offset: 0x218CDE0 VA: 0x18218DBE0
	public static void Unregister(string authenticationScheme) { }

	// RVA: 0x218D020 Offset: 0x218C220 VA: 0x18218D020
	private static void DoUnregister(string authenticationScheme, bool throwEx) { }

	// RVA: 0x218DD40 Offset: 0x218CF40 VA: 0x18218DD40
	private static void .cctor() { }
}

// Namespace: System.Net
internal class BasicClient : IAuthenticationModule // TypeDefIndex: 5910
{
	// Properties
	public string AuthenticationType { get; }
	public bool CanPreAuthenticate { get; }

	// Methods

	// RVA: 0x218DF20 Offset: 0x218D120 VA: 0x18218DF20 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x218DFD0 Offset: 0x218D1D0 VA: 0x18218DFD0
	private static byte[] GetBytes(string str) { }

	// RVA: 0x218E080 Offset: 0x218D280 VA: 0x18218E080
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x218E350 Offset: 0x218D550 VA: 0x18218E350 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x218E370 Offset: 0x218D570 VA: 0x18218E370 Slot: 7
	public string get_AuthenticationType() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	public bool get_CanPreAuthenticate() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
public sealed class BindIPEndPoint : MulticastDelegate // TypeDefIndex: 5911
{
	// Methods

	// RVA: 0x1BC6DB0 Offset: 0x1BC5FB0 VA: 0x181BC6DB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }

	// RVA: 0x218E3A0 Offset: 0x218D5A0 VA: 0x18218E3A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual IPEndPoint EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private struct BufferedReadStream.<ProcessReadAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 5912
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public BufferedReadStream <>4__this; // 0x28
	public int size; // 0x30
	public byte[] buffer; // 0x38
	public int offset; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x21A3EC0 Offset: 0x21A30C0 VA: 0x1821A3EC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21A4190 Offset: 0x21A3390 VA: 0x1821A4190 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class BufferedReadStream : WebReadStream // TypeDefIndex: 5913
{
	// Fields
	private readonly BufferOffsetSize readBuffer; // 0x40

	// Methods

	// RVA: 0x218E610 Offset: 0x218D810 VA: 0x18218E610
	public void .ctor(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	[AsyncStateMachine(typeof(BufferedReadStream.<ProcessReadAsync>d__2))]
	// RVA: 0x218E430 Offset: 0x218D630 VA: 0x18218E430 Slot: 40
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x218E570 Offset: 0x218D770 VA: 0x18218E570
	internal bool TryReadFromBuffer(byte[] buffer, int offset, int size, out int result) { }
}

// Namespace: 
private class ChunkedInputStream.ReadBufferState // TypeDefIndex: 5914
{
	// Fields
	public byte[] Buffer; // 0x10
	public int Offset; // 0x18
	public int Count; // 0x1C
	public int InitialCount; // 0x20
	public HttpStreamAsyncResult Ares; // 0x28

	// Methods

	// RVA: 0x21A3A00 Offset: 0x21A2C00 VA: 0x1821A3A00
	public void .ctor(byte[] buffer, int offset, int count, HttpStreamAsyncResult ares) { }
}

// Namespace: System.Net
internal class ChunkedInputStream : RequestStream // TypeDefIndex: 5915
{
	// Fields
	private bool disposed; // 0x50
	private MonoChunkParser decoder; // 0x58
	private HttpListenerContext context; // 0x60
	private bool no_more_data; // 0x68

	// Properties
	public MonoChunkParser Decoder { get; set; }

	// Methods

	// RVA: 0x218EF50 Offset: 0x218E150 VA: 0x18218EF50
	public void .ctor(HttpListenerContext context, Stream stream, byte[] buffer, int offset, int length) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public MonoChunkParser get_Decoder() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Decoder(MonoChunkParser value) { }

	// RVA: 0x218EF00 Offset: 0x218E100 VA: 0x18218EF00 Slot: 34
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x218E640 Offset: 0x218D840 VA: 0x18218E640 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state) { }

	// RVA: 0x218EC10 Offset: 0x218DE10 VA: 0x18218EC10
	private void OnRead(IAsyncResult base_ares) { }

	// RVA: 0x218E9D0 Offset: 0x218DBD0 VA: 0x18218E9D0 Slot: 25
	public override int EndRead(IAsyncResult ares) { }

	// RVA: 0x218E9B0 Offset: 0x218DBB0 VA: 0x18218E9B0 Slot: 20
	public override void Close() { }
}

// Namespace: 
internal enum ContentDecodeStream.Mode // TypeDefIndex: 5916
{
	// Fields
	public int value__; // 0x0
	public const ContentDecodeStream.Mode GZip = 0;
	public const ContentDecodeStream.Mode Deflate = 1;
}

// Namespace: System.Net
internal class ContentDecodeStream : WebReadStream // TypeDefIndex: 5917
{
	// Fields
	[CompilerGenerated]
	private readonly Stream <OriginalInnerStream>k__BackingField; // 0x40

	// Properties
	private Stream OriginalInnerStream { get; }

	// Methods

	// RVA: 0x218F070 Offset: 0x218E270 VA: 0x18218F070
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, ContentDecodeStream.Mode mode) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	private Stream get_OriginalInnerStream() { }

	// RVA: 0x218E610 Offset: 0x218D810 VA: 0x18218E610
	private void .ctor(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	// RVA: 0x214B620 Offset: 0x214A820 VA: 0x18214B620 Slot: 40
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x218F150 Offset: 0x218E350 VA: 0x18218F150 Slot: 41
	internal override Task FinishReading(CancellationToken cancellationToken) { }
}

// Namespace: System.Net
[Flags]
public enum DecompressionMethods // TypeDefIndex: 5918
{
	// Fields
	public int value__; // 0x0
	public const DecompressionMethods None = 0;
	public const DecompressionMethods GZip = 1;
	public const DecompressionMethods Deflate = 2;
}

// Namespace: System.Net
internal class DefaultCertificatePolicy : ICertificatePolicy // TypeDefIndex: 5919
{
	// Methods

	// RVA: 0x218F290 Offset: 0x218E490 VA: 0x18218F290 Slot: 4
	public bool CheckValidationResult(ServicePoint point, X509Certificate certificate, WebRequest request, int certificateProblem) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
internal class DigestHeaderParser // TypeDefIndex: 5920
{
	// Fields
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	// Properties
	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }

	// Methods

	// RVA: 0x2190780 Offset: 0x218F980 VA: 0x182190780
	public void .ctor(string header) { }

	// RVA: 0x16DB3D0 Offset: 0x16DA5D0 VA: 0x1816DB3D0
	public string get_Realm() { }

	// RVA: 0x16DB2E0 Offset: 0x16DA4E0 VA: 0x1816DB2E0
	public string get_Opaque() { }

	// RVA: 0x16DB340 Offset: 0x16DA540 VA: 0x1816DB340
	public string get_Nonce() { }

	// RVA: 0x16DB370 Offset: 0x16DA570 VA: 0x1816DB370
	public string get_Algorithm() { }

	// RVA: 0x16DB3A0 Offset: 0x16DA5A0 VA: 0x1816DB3A0
	public string get_QOP() { }

	// RVA: 0x2190450 Offset: 0x218F650 VA: 0x182190450
	public bool Parse() { }

	// RVA: 0x2190610 Offset: 0x218F810 VA: 0x182190610
	private void SkipWhitespace() { }

	// RVA: 0x2190120 Offset: 0x218F320 VA: 0x182190120
	private string GetKey() { }

	// RVA: 0x2190200 Offset: 0x218F400 VA: 0x182190200
	private bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x2190680 Offset: 0x218F880 VA: 0x182190680
	private static void .cctor() { }
}

// Namespace: System.Net
internal class DigestSession // TypeDefIndex: 5921
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	// Properties
	public string Algorithm { get; }
	public string Realm { get; }
	public string Nonce { get; }
	public string Opaque { get; }
	public string QOP { get; }
	public string CNonce { get; }
	public DateTime LastUse { get; }

	// Methods

	// RVA: 0x21916B0 Offset: 0x21908B0 VA: 0x1821916B0
	private static void .cctor() { }

	// RVA: 0x21916F0 Offset: 0x21908F0 VA: 0x1821916F0
	public void .ctor() { }

	// RVA: 0x2191750 Offset: 0x2190950 VA: 0x182191750
	public string get_Algorithm() { }

	// RVA: 0x2191940 Offset: 0x2190B40 VA: 0x182191940
	public string get_Realm() { }

	// RVA: 0x2191880 Offset: 0x2190A80 VA: 0x182191880
	public string get_Nonce() { }

	// RVA: 0x21918C0 Offset: 0x2190AC0 VA: 0x1821918C0
	public string get_Opaque() { }

	// RVA: 0x2191900 Offset: 0x2190B00 VA: 0x182191900
	public string get_QOP() { }

	// RVA: 0x2191790 Offset: 0x2190990 VA: 0x182191790
	public string get_CNonce() { }

	// RVA: 0x21911C0 Offset: 0x21903C0 VA: 0x1821911C0
	public bool Parse(string challenge) { }

	// RVA: 0x2191050 Offset: 0x2190250 VA: 0x182191050
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x2190DF0 Offset: 0x218FFF0 VA: 0x182190DF0
	private string HA1(string username, string password) { }

	// RVA: 0x2190F50 Offset: 0x2190150 VA: 0x182190F50
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x2191340 Offset: 0x2190540 VA: 0x182191340
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x2190830 Offset: 0x218FA30 VA: 0x182190830
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public DateTime get_LastUse() { }
}

// Namespace: System.Net
internal class DigestClient : IAuthenticationModule // TypeDefIndex: 5922
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Properties
	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }
	public bool CanPreAuthenticate { get; }

	// Methods

	// RVA: 0x218FFC0 Offset: 0x218F1C0 VA: 0x18218FFC0
	private static Hashtable get_Cache() { }

	// RVA: 0x218F630 Offset: 0x218E830 VA: 0x18218F630
	private static void CheckExpired(int count) { }

	// RVA: 0x218F2F0 Offset: 0x218E4F0 VA: 0x18218F2F0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x218FD40 Offset: 0x218EF40 VA: 0x18218FD40 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x218FF90 Offset: 0x218F190 VA: 0x18218FF90 Slot: 7
	public string get_AuthenticationType() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	public bool get_CanPreAuthenticate() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x218FF20 Offset: 0x218F120 VA: 0x18218FF20
	private static void .cctor() { }
}

// Namespace: 
private sealed class Dns.GetHostByNameCallback : MulticastDelegate // TypeDefIndex: 5923
{
	// Methods

	// RVA: 0x585960 Offset: 0x584B60 VA: 0x180585960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IPHostEntry Invoke(string hostName) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual IPHostEntry EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class Dns.ResolveCallback : MulticastDelegate // TypeDefIndex: 5924
{
	// Methods

	// RVA: 0x585960 Offset: 0x584B60 VA: 0x180585960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IPHostEntry Invoke(string hostName) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual IPHostEntry EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class Dns.GetHostEntryNameCallback : MulticastDelegate // TypeDefIndex: 5925
{
	// Methods

	// RVA: 0x585960 Offset: 0x584B60 VA: 0x180585960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IPHostEntry Invoke(string hostName) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual IPHostEntry EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class Dns.GetHostEntryIPCallback : MulticastDelegate // TypeDefIndex: 5926
{
	// Methods

	// RVA: 0x11F2F10 Offset: 0x11F2110 VA: 0x1811F2F10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IPHostEntry Invoke(IPAddress hostAddress) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(IPAddress hostAddress, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual IPHostEntry EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class Dns.GetHostAddressesCallback : MulticastDelegate // TypeDefIndex: 5927
{
	// Methods

	// RVA: 0x585960 Offset: 0x584B60 VA: 0x180585960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IPAddress[] Invoke(string hostName) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual IPAddress[] EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public static class Dns // TypeDefIndex: 5928
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void .cctor() { }

	[Obsolete("Use BeginGetHostEntry instead")]
	// RVA: 0x2191B90 Offset: 0x2190D90 VA: 0x182191B90
	public static IAsyncResult BeginGetHostByName(string hostName, AsyncCallback requestCallback, object stateObject) { }

	[Obsolete("Use BeginGetHostEntry instead")]
	// RVA: 0x21920D0 Offset: 0x21912D0 VA: 0x1821920D0
	public static IAsyncResult BeginResolve(string hostName, AsyncCallback requestCallback, object stateObject) { }

	// RVA: 0x2191980 Offset: 0x2190B80 VA: 0x182191980
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	// RVA: 0x2191D00 Offset: 0x2190F00 VA: 0x182191D00
	public static IAsyncResult BeginGetHostEntry(string hostNameOrAddress, AsyncCallback requestCallback, object stateObject) { }

	// RVA: 0x2191F10 Offset: 0x2191110 VA: 0x182191F10
	public static IAsyncResult BeginGetHostEntry(IPAddress address, AsyncCallback requestCallback, object stateObject) { }

	[Obsolete("Use EndGetHostEntry instead")]
	// RVA: 0x21923B0 Offset: 0x21915B0 VA: 0x1821923B0
	public static IPHostEntry EndGetHostByName(IAsyncResult asyncResult) { }

	[Obsolete("Use EndGetHostEntry instead")]
	// RVA: 0x21926E0 Offset: 0x21918E0 VA: 0x1821926E0
	public static IPHostEntry EndResolve(IAsyncResult asyncResult) { }

	// RVA: 0x2192240 Offset: 0x2191440 VA: 0x182192240
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x2192520 Offset: 0x2191720 VA: 0x182192520
	public static IPHostEntry EndGetHostEntry(IAsyncResult asyncResult) { }

	// RVA: 0x2192EF0 Offset: 0x21920F0 VA: 0x182192EF0
	private static bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x2192C00 Offset: 0x2191E00 VA: 0x182192C00
	private static bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x21935B0 Offset: 0x21927B0 VA: 0x1821935B0
	private static bool GetHostName_icall(out string h_name) { }

	// RVA: 0x2192850 Offset: 0x2191A50 VA: 0x182192850
	private static void Error_11001(string hostName) { }

	// RVA: 0x2193760 Offset: 0x2192960 VA: 0x182193760
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	[Obsolete("Use GetHostEntry instead")]
	// RVA: 0x2192D90 Offset: 0x2191F90 VA: 0x182192D90
	public static IPHostEntry GetHostByAddress(IPAddress address) { }

	[Obsolete("Use GetHostEntry instead")]
	// RVA: 0x2192E50 Offset: 0x2192050 VA: 0x182192E50
	public static IPHostEntry GetHostByAddress(string address) { }

	// RVA: 0x2192C10 Offset: 0x2191E10 VA: 0x182192C10
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x2193280 Offset: 0x2192480 VA: 0x182193280
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x21934F0 Offset: 0x21926F0 VA: 0x1821934F0
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0x21929D0 Offset: 0x2191BD0 VA: 0x1821929D0
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	[Obsolete("Use GetHostEntry instead")]
	// RVA: 0x2192F00 Offset: 0x2192100 VA: 0x182192F00
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x21935C0 Offset: 0x21927C0 VA: 0x1821935C0
	public static string GetHostName() { }

	[Obsolete("Use GetHostEntry instead")]
	// RVA: 0x2193640 Offset: 0x2192840 VA: 0x182193640
	public static IPHostEntry Resolve(string hostName) { }

	// RVA: 0x21928C0 Offset: 0x2191AC0 VA: 0x1821928C0
	public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { }

	// RVA: 0x2193170 Offset: 0x2192370 VA: 0x182193170
	public static Task<IPHostEntry> GetHostEntryAsync(IPAddress address) { }

	// RVA: 0x2193060 Offset: 0x2192260 VA: 0x182193060
	public static Task<IPHostEntry> GetHostEntryAsync(string hostNameOrAddress) { }
}

// Namespace: System.Net
internal sealed class EndPointListener // TypeDefIndex: 5929
{
	// Fields
	private HttpListener listener; // 0x10
	private IPEndPoint endpoint; // 0x18
	private Socket sock; // 0x20
	private Hashtable prefixes; // 0x28
	private ArrayList unhandled; // 0x30
	private ArrayList all; // 0x38
	private X509Certificate cert; // 0x40
	private bool secure; // 0x48
	private Dictionary<HttpConnection, HttpConnection> unregistered; // 0x50

	// Properties
	internal HttpListener Listener { get; }

	// Methods

	// RVA: 0x2195530 Offset: 0x2194730 VA: 0x182195530
	public void .ctor(HttpListener listener, IPAddress addr, int port, bool secure) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal HttpListener get_Listener() { }

	// RVA: 0x2193A20 Offset: 0x2192C20 VA: 0x182193A20
	private static void Accept(Socket socket, SocketAsyncEventArgs e, ref Socket accepted) { }

	// RVA: 0x2194740 Offset: 0x2193940 VA: 0x182194740
	private static void ProcessAccept(SocketAsyncEventArgs args) { }

	// RVA: 0x2194730 Offset: 0x2193930 VA: 0x182194730
	private static void OnAccept(object sender, SocketAsyncEventArgs e) { }

	// RVA: 0x2194960 Offset: 0x2193B60 VA: 0x182194960
	internal void RemoveConnection(HttpConnection conn) { }

	// RVA: 0x2194100 Offset: 0x2193300 VA: 0x182194100
	public bool BindContext(HttpListenerContext context) { }

	// RVA: 0x2195500 Offset: 0x2194700 VA: 0x182195500
	public void UnbindContext(HttpListenerContext context) { }

	// RVA: 0x2195000 Offset: 0x2194200 VA: 0x182195000
	private HttpListener SearchListener(Uri uri, out ListenerPrefix prefix) { }

	// RVA: 0x21944A0 Offset: 0x21936A0 VA: 0x1821944A0
	private HttpListener MatchFromList(string host, string path, ArrayList list, out ListenerPrefix prefix) { }

	// RVA: 0x2193EC0 Offset: 0x21930C0 VA: 0x182193EC0
	private void AddSpecial(ArrayList coll, ListenerPrefix prefix) { }

	// RVA: 0x2194F00 Offset: 0x2194100 VA: 0x182194F00
	private bool RemoveSpecial(ArrayList coll, ListenerPrefix prefix) { }

	// RVA: 0x2194160 Offset: 0x2193360 VA: 0x182194160
	private void CheckIfRemove() { }

	// RVA: 0x2194230 Offset: 0x2193430 VA: 0x182194230
	public void Close() { }

	// RVA: 0x2193AB0 Offset: 0x2192CB0 VA: 0x182193AB0
	public void AddPrefix(ListenerPrefix prefix, HttpListener listener) { }

	// RVA: 0x2194A30 Offset: 0x2193C30 VA: 0x182194A30
	public void RemovePrefix(ListenerPrefix prefix, HttpListener listener) { }
}

// Namespace: System.Net
internal sealed class EndPointManager // TypeDefIndex: 5930
{
	// Fields
	private static Hashtable ip_to_endpoints; // 0x0

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x2195760 Offset: 0x2194960 VA: 0x182195760
	public static void AddListener(HttpListener listener) { }

	// RVA: 0x2195D60 Offset: 0x2194F60 VA: 0x182195D60
	public static void AddPrefix(string prefix, HttpListener listener) { }

	// RVA: 0x2195B90 Offset: 0x2194D90 VA: 0x182195B90
	private static void AddPrefixInternal(string p, HttpListener listener) { }

	// RVA: 0x2195E60 Offset: 0x2195060 VA: 0x182195E60
	private static EndPointListener GetEPListener(string host, int port, HttpListener listener, bool secure) { }

	// RVA: 0x21962D0 Offset: 0x21954D0 VA: 0x1821962D0
	public static void RemoveEndPoint(EndPointListener epl, IPEndPoint ep) { }

	// RVA: 0x2196530 Offset: 0x2195730 VA: 0x182196530
	public static void RemoveListener(HttpListener listener) { }

	// RVA: 0x2196910 Offset: 0x2195B10 VA: 0x182196910
	public static void RemovePrefix(string prefix, HttpListener listener) { }

	// RVA: 0x21967D0 Offset: 0x21959D0 VA: 0x1821967D0
	private static void RemovePrefixInternal(string prefix, HttpListener listener) { }

	// RVA: 0x2196A10 Offset: 0x2195C10 VA: 0x182196A10
	private static void .cctor() { }
}

// Namespace: System.Net
[Serializable]
public class EndpointPermission // TypeDefIndex: 5931
{
	// Fields
	private static char[] dot_char; // 0x0
	private string hostname; // 0x10
	private int port; // 0x18
	private TransportType transport; // 0x1C
	private bool resolved; // 0x20
	private bool hasWildcard; // 0x21
	private IPAddress[] addresses; // 0x28

	// Properties
	public string Hostname { get; }
	public int Port { get; }
	public TransportType Transport { get; }

	// Methods

	// RVA: 0x21978E0 Offset: 0x2196AE0 VA: 0x1821978E0
	internal void .ctor(string hostname, int port, TransportType transport) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Hostname() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Port() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public TransportType get_Transport() { }

	// RVA: 0x2196A70 Offset: 0x2195C70 VA: 0x182196A70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x407CA0 Offset: 0x406EA0 VA: 0x180407CA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2197780 Offset: 0x2196980 VA: 0x182197780 Slot: 3
	public override string ToString() { }

	// RVA: 0x2197130 Offset: 0x2196330 VA: 0x182197130
	internal bool IsSubsetOf(EndpointPermission perm) { }

	// RVA: 0x21972A0 Offset: 0x21964A0 VA: 0x1821972A0
	private bool IsSubsetOf(string addr1, string addr2) { }

	// RVA: 0x2197040 Offset: 0x2196240 VA: 0x182197040
	internal EndpointPermission Intersect(EndpointPermission perm) { }

	// RVA: 0x2196B30 Offset: 0x2195D30 VA: 0x182196B30
	private string IntersectHostname(EndpointPermission perm) { }

	// RVA: 0x2196D60 Offset: 0x2195F60 VA: 0x182196D60
	private string Intersect(string addr1, string addr2) { }

	// RVA: 0x2197600 Offset: 0x2196800 VA: 0x182197600
	private int ToNumber(string value) { }

	// RVA: 0x2197400 Offset: 0x2196600 VA: 0x182197400
	internal void Resolve() { }

	// RVA: 0x1B8E590 Offset: 0x1B8D790 VA: 0x181B8E590
	internal void UndoResolve() { }

	// RVA: 0x2197860 Offset: 0x2196A60 VA: 0x182197860
	private static void .cctor() { }

	// RVA: 0x2197990 Offset: 0x2196B90 VA: 0x182197990
	internal void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct FixedSizeReadStream.<ProcessReadAsync>d__5 : IAsyncStateMachine // TypeDefIndex: 5932
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public FixedSizeReadStream <>4__this; // 0x28
	public int size; // 0x30
	public byte[] buffer; // 0x38
	public int offset; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x21A4200 Offset: 0x21A3400 VA: 0x1821A4200 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21A44B0 Offset: 0x21A36B0 VA: 0x1821A44B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class FixedSizeReadStream : WebReadStream // TypeDefIndex: 5933
{
	// Fields
	[CompilerGenerated]
	private readonly long <ContentLength>k__BackingField; // 0x40
	private long position; // 0x48

	// Properties
	public long ContentLength { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public long get_ContentLength() { }

	// RVA: 0x218E610 Offset: 0x218D810 VA: 0x18218E610
	public void .ctor(WebOperation operation, Stream innerStream, long contentLength) { }

	[AsyncStateMachine(typeof(FixedSizeReadStream.<ProcessReadAsync>d__5))]
	// RVA: 0x219AD40 Offset: 0x2199F40 VA: 0x18219AD40 Slot: 40
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }
}

// Namespace: 
private enum HttpConnection.InputState // TypeDefIndex: 5934
{
	// Fields
	public int value__; // 0x0
	public const HttpConnection.InputState RequestLine = 0;
	public const HttpConnection.InputState Headers = 1;
}

// Namespace: 
private enum HttpConnection.LineState // TypeDefIndex: 5935
{
	// Fields
	public int value__; // 0x0
	public const HttpConnection.LineState None = 0;
	public const HttpConnection.LineState CR = 1;
	public const HttpConnection.LineState LF = 2;
}

// Namespace: System.Net
internal sealed class HttpConnection // TypeDefIndex: 5936
{
	// Fields
	private static AsyncCallback onread_cb; // 0x0
	private const int BufferSize = 8192;
	private Socket sock; // 0x10
	private Stream stream; // 0x18
	private EndPointListener epl; // 0x20
	private MemoryStream ms; // 0x28
	private byte[] buffer; // 0x30
	private HttpListenerContext context; // 0x38
	private StringBuilder current_line; // 0x40
	private ListenerPrefix prefix; // 0x48
	private RequestStream i_stream; // 0x50
	private ResponseStream o_stream; // 0x58
	private bool chunked; // 0x60
	private int reuses; // 0x64
	private bool context_bound; // 0x68
	private bool secure; // 0x69
	private X509Certificate cert; // 0x70
	private int s_timeout; // 0x78
	private Timer timer; // 0x80
	private IPEndPoint local_ep; // 0x88
	private HttpListener last_listener; // 0x90
	private int[] client_cert_errors; // 0x98
	private X509Certificate2 client_cert; // 0xA0
	private SslStream ssl_stream; // 0xA8
	private HttpConnection.InputState input_state; // 0xB0
	private HttpConnection.LineState line_state; // 0xB4
	private int position; // 0xB8

	// Properties
	internal SslStream SslStream { get; }
	internal int[] ClientCertificateErrors { get; }
	internal X509Certificate2 ClientCertificate { get; }
	public bool IsClosed { get; }
	public int Reuses { get; }
	public IPEndPoint LocalEndPoint { get; }
	public IPEndPoint RemoteEndPoint { get; }
	public bool IsSecure { get; }
	public ListenerPrefix Prefix { get; set; }

	// Methods

	// RVA: 0x219D470 Offset: 0x219C670 VA: 0x18219D470
	public void .ctor(Socket sock, EndPointListener epl, bool secure, X509Certificate cert) { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	internal SslStream get_SslStream() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	internal int[] get_ClientCertificateErrors() { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	internal X509Certificate2 get_ClientCertificate() { }

	// RVA: 0x219C590 Offset: 0x219B790 VA: 0x18219C590
	private void Init() { }

	// RVA: 0x805870 Offset: 0x804A70 VA: 0x180805870
	public bool get_IsClosed() { }

	// RVA: 0x6772F0 Offset: 0x6764F0 VA: 0x1806772F0
	public int get_Reuses() { }

	// RVA: 0x219D6F0 Offset: 0x219C8F0 VA: 0x18219D6F0
	public IPEndPoint get_LocalEndPoint() { }

	// RVA: 0x219D810 Offset: 0x219CA10 VA: 0x18219D810
	public IPEndPoint get_RemoteEndPoint() { }

	// RVA: 0x1C134F0 Offset: 0x1C126F0 VA: 0x181C134F0
	public bool get_IsSecure() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public ListenerPrefix get_Prefix() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_Prefix(ListenerPrefix value) { }

	// RVA: 0x219CBA0 Offset: 0x219BDA0 VA: 0x18219CBA0
	private void OnTimeout(object unused) { }

	// RVA: 0x219BBD0 Offset: 0x219ADD0 VA: 0x18219BBD0
	public void BeginReadRequest() { }

	// RVA: 0x219C260 Offset: 0x219B460 VA: 0x18219C260
	public RequestStream GetRequestStream(bool chunked, long contentlength) { }

	// RVA: 0x219C4B0 Offset: 0x219B6B0 VA: 0x18219C4B0
	public ResponseStream GetResponseStream() { }

	// RVA: 0x219CB10 Offset: 0x219BD10 VA: 0x18219CB10
	private static void OnRead(IAsyncResult ares) { }

	// RVA: 0x219C730 Offset: 0x219B930 VA: 0x18219C730
	private void OnReadInternal(IAsyncResult ares) { }

	// RVA: 0x219D0B0 Offset: 0x219C2B0 VA: 0x18219D0B0
	private void RemoveConnection() { }

	// RVA: 0x219CBF0 Offset: 0x219BDF0 VA: 0x18219CBF0
	private bool ProcessInput(MemoryStream ms) { }

	// RVA: 0x219CF40 Offset: 0x219C140 VA: 0x18219CF40
	private string ReadLine(byte[] buffer, int offset, int len, ref int used) { }

	// RVA: 0x219D110 Offset: 0x219C310 VA: 0x18219D110
	public void SendError(string msg, int status) { }

	// RVA: 0x219D260 Offset: 0x219C460 VA: 0x18219D260
	public void SendError() { }

	// RVA: 0x219D3A0 Offset: 0x219C5A0 VA: 0x18219D3A0
	private void Unbind() { }

	// RVA: 0x219BDF0 Offset: 0x219AFF0 VA: 0x18219BDF0
	public void Close() { }

	// RVA: 0x219BD20 Offset: 0x219AF20 VA: 0x18219BD20
	private void CloseSocket() { }

	// RVA: 0x219BE00 Offset: 0x219B000 VA: 0x18219BE00
	internal void Close(bool force_close) { }

	// RVA: 0x219D3F0 Offset: 0x219C5F0 VA: 0x18219D3F0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x219D290 Offset: 0x219C490 VA: 0x18219D290
	private bool <.ctor>b__24_0(object t, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }
}

// Namespace: 
public sealed class HttpListener.ExtendedProtectionSelector : MulticastDelegate // TypeDefIndex: 5937
{
	// Methods

	// RVA: 0x585960 Offset: 0x584B60 VA: 0x180585960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual ExtendedProtectionPolicy Invoke(HttpListenerRequest request) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(HttpListenerRequest request, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual ExtendedProtectionPolicy EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public sealed class HttpListener : IDisposable // TypeDefIndex: 5938
{
	// Fields
	private MonoTlsProvider tlsProvider; // 0x10
	private MonoTlsSettings tlsSettings; // 0x18
	private X509Certificate certificate; // 0x20
	private AuthenticationSchemes auth_schemes; // 0x28
	private HttpListenerPrefixCollection prefixes; // 0x30
	private AuthenticationSchemeSelector auth_selector; // 0x38
	private string realm; // 0x40
	private bool ignore_write_exceptions; // 0x48
	private bool unsafe_ntlm_auth; // 0x49
	private bool listening; // 0x4A
	private bool disposed; // 0x4B
	private readonly object _internalLock; // 0x50
	private Hashtable registry; // 0x58
	private ArrayList ctx_queue; // 0x60
	private ArrayList wait_queue; // 0x68
	private Hashtable connections; // 0x70
	private ServiceNameStore defaultServiceNames; // 0x78
	private ExtendedProtectionPolicy extendedProtectionPolicy; // 0x80
	private HttpListener.ExtendedProtectionSelector extendedProtectionSelectorDelegate; // 0x88

	// Properties
	public AuthenticationSchemes AuthenticationSchemes { get; set; }
	public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate { get; set; }
	public HttpListener.ExtendedProtectionSelector ExtendedProtectionSelectorDelegate { get; set; }
	public bool IgnoreWriteExceptions { get; set; }
	public bool IsListening { get; }
	public static bool IsSupported { get; }
	public HttpListenerPrefixCollection Prefixes { get; }
	[MonoTODO]
	public HttpListenerTimeoutManager TimeoutManager { get; }
	[MonoTODO("not used anywhere in the implementation")]
	public ExtendedProtectionPolicy ExtendedProtectionPolicy { get; set; }
	public ServiceNameCollection DefaultServiceNames { get; }
	public string Realm { get; set; }
	[MonoTODO("Support for NTLM needs some loving.")]
	public bool UnsafeConnectionNtlmAuthentication { get; set; }

	// Methods

	// RVA: 0x21A2DA0 Offset: 0x21A1FA0 VA: 0x1821A2DA0
	internal void .ctor(X509Certificate certificate, MonoTlsProvider tlsProvider, MonoTlsSettings tlsSettings) { }

	// RVA: 0x21A2160 Offset: 0x21A1360 VA: 0x1821A2160
	internal X509Certificate LoadCertificateAndKey(IPAddress addr, int port) { }

	// RVA: 0x21A18B0 Offset: 0x21A0AB0 VA: 0x1821A18B0
	internal SslStream CreateSslStream(Stream innerStream, bool ownsStream, RemoteCertificateValidationCallback callback) { }

	// RVA: 0x21A2BC0 Offset: 0x21A1DC0 VA: 0x1821A2BC0
	public void .ctor() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public AuthenticationSchemes get_AuthenticationSchemes() { }

	// RVA: 0x21A3050 Offset: 0x21A2250 VA: 0x1821A3050
	public void set_AuthenticationSchemes(AuthenticationSchemes value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public AuthenticationSchemeSelector get_AuthenticationSchemeSelectorDelegate() { }

	// RVA: 0x21A3020 Offset: 0x21A2220 VA: 0x1821A3020
	public void set_AuthenticationSchemeSelectorDelegate(AuthenticationSchemeSelector value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public HttpListener.ExtendedProtectionSelector get_ExtendedProtectionSelectorDelegate() { }

	// RVA: 0x21A3210 Offset: 0x21A2410 VA: 0x1821A3210
	public void set_ExtendedProtectionSelectorDelegate(HttpListener.ExtendedProtectionSelector value) { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_IgnoreWriteExceptions() { }

	// RVA: 0x21A32F0 Offset: 0x21A24F0 VA: 0x1821A32F0
	public void set_IgnoreWriteExceptions(bool value) { }

	// RVA: 0x190DBC0 Offset: 0x190CDC0 VA: 0x18190DBC0
	public bool get_IsListening() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public static bool get_IsSupported() { }

	// RVA: 0x21A2FC0 Offset: 0x21A21C0 VA: 0x1821A2FC0
	public HttpListenerPrefixCollection get_Prefixes() { }

	// RVA: 0x21A2FE0 Offset: 0x21A21E0 VA: 0x1821A2FE0
	public HttpListenerTimeoutManager get_TimeoutManager() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public ExtendedProtectionPolicy get_ExtendedProtectionPolicy() { }

	// RVA: 0x21A3080 Offset: 0x21A2280 VA: 0x1821A3080
	public void set_ExtendedProtectionPolicy(ExtendedProtectionPolicy value) { }

	// RVA: 0x21A2FA0 Offset: 0x21A21A0 VA: 0x1821A2FA0
	public ServiceNameCollection get_DefaultServiceNames() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_Realm() { }

	// RVA: 0x21A3320 Offset: 0x21A2520 VA: 0x1821A3320
	public void set_Realm(string value) { }

	// RVA: 0x563E30 Offset: 0x563030 VA: 0x180563E30
	public bool get_UnsafeConnectionNtlmAuthentication() { }

	// RVA: 0x21A3350 Offset: 0x21A2550 VA: 0x1821A3350
	public void set_UnsafeConnectionNtlmAuthentication(bool value) { }

	// RVA: 0x21A0B00 Offset: 0x219FD00 VA: 0x1821A0B00
	public void Abort() { }

	// RVA: 0x21A1800 Offset: 0x21A0A00 VA: 0x1821A1800
	public void Close() { }

	// RVA: 0x21A1840 Offset: 0x21A0A40 VA: 0x1821A1840
	private void Close(bool force) { }

	// RVA: 0x21A0F00 Offset: 0x21A0100 VA: 0x1821A0F00
	private void Cleanup(bool close_existing) { }

	// RVA: 0x21A0B50 Offset: 0x219FD50 VA: 0x1821A0B50
	public IAsyncResult BeginGetContext(AsyncCallback callback, object state) { }

	// RVA: 0x21A1A30 Offset: 0x21A0C30 VA: 0x1821A1A30
	public HttpListenerContext EndGetContext(IAsyncResult asyncResult) { }

	// RVA: 0x21A2890 Offset: 0x21A1A90 VA: 0x1821A2890
	internal AuthenticationSchemes SelectAuthenticationScheme(HttpListenerContext context) { }

	// RVA: 0x21A2020 Offset: 0x21A1220 VA: 0x1821A2020
	public HttpListenerContext GetContext() { }

	// RVA: 0x21A28D0 Offset: 0x21A1AD0 VA: 0x1821A28D0
	public void Start() { }

	// RVA: 0x21A2930 Offset: 0x21A1B30 VA: 0x1821A2930
	public void Stop() { }

	// RVA: 0x21A29A0 Offset: 0x21A1BA0 VA: 0x1821A29A0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21A1E40 Offset: 0x21A1040 VA: 0x1821A1E40
	public Task<HttpListenerContext> GetContextAsync() { }

	// RVA: 0x21A0E70 Offset: 0x21A0070 VA: 0x1821A0E70
	internal void CheckDisposed() { }

	// RVA: 0x21A1F50 Offset: 0x21A1150 VA: 0x1821A1F50
	private HttpListenerContext GetContextFromQueue() { }

	// RVA: 0x21A2510 Offset: 0x21A1710 VA: 0x1821A2510
	internal void RegisterContext(HttpListenerContext context) { }

	// RVA: 0x21A2A10 Offset: 0x21A1C10 VA: 0x1821A2A10
	internal void UnregisterContext(HttpListenerContext context) { }

	// RVA: 0x21A0B20 Offset: 0x219FD20 VA: 0x1821A0B20
	internal void AddConnection(HttpConnection cnc) { }

	// RVA: 0x21A2860 Offset: 0x21A1A60 VA: 0x1821A2860
	internal void RemoveConnection(HttpConnection cnc) { }
}

// Namespace: System.Net
public class HttpListenerBasicIdentity : GenericIdentity // TypeDefIndex: 5939
{
	// Fields
	private string password; // 0x88

	// Properties
	public virtual string Password { get; }

	// Methods

	// RVA: 0x219D8B0 Offset: 0x219CAB0 VA: 0x18219D8B0
	public void .ctor(string username, string password) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 13
	public virtual string get_Password() { }
}

// Namespace: System.Net
public sealed class HttpListenerContext // TypeDefIndex: 5940
{
	// Fields
	private HttpListenerRequest request; // 0x10
	private HttpListenerResponse response; // 0x18
	private IPrincipal user; // 0x20
	private HttpConnection cnc; // 0x28
	private string error; // 0x30
	private int err_status; // 0x38
	internal HttpListener Listener; // 0x40

	// Properties
	internal int ErrorStatus { get; set; }
	internal string ErrorMessage { get; set; }
	internal bool HaveError { get; }
	internal HttpConnection Connection { get; }
	public HttpListenerRequest Request { get; }
	public HttpListenerResponse Response { get; }
	public IPrincipal User { get; }

	// Methods

	// RVA: 0x219DD10 Offset: 0x219CF10 VA: 0x18219DD10
	internal void .ctor(HttpConnection cnc) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	internal int get_ErrorStatus() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	internal void set_ErrorStatus(int value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal string get_ErrorMessage() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_ErrorMessage(string value) { }

	// RVA: 0x1656350 Offset: 0x1655550 VA: 0x181656350
	internal bool get_HaveError() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal HttpConnection get_Connection() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public HttpListenerRequest get_Request() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public HttpListenerResponse get_Response() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IPrincipal get_User() { }

	// RVA: 0x219DA10 Offset: 0x219CC10 VA: 0x18219DA10
	internal void ParseAuthentication(AuthenticationSchemes expectedSchemes) { }

	// RVA: 0x219DB30 Offset: 0x219CD30 VA: 0x18219DB30
	internal IPrincipal ParseBasicAuthentication(string authData) { }

	[MonoTODO]
	// RVA: 0x219D910 Offset: 0x219CB10 VA: 0x18219D910
	public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol) { }

	[MonoTODO]
	// RVA: 0x219D9D0 Offset: 0x219CBD0 VA: 0x18219D9D0
	public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, TimeSpan keepAliveInterval) { }

	[MonoTODO]
	// RVA: 0x219D950 Offset: 0x219CB50 VA: 0x18219D950
	public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval) { }

	[MonoTODO]
	// RVA: 0x219D990 Offset: 0x219CB90 VA: 0x18219D990
	public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval, ArraySegment<byte> internalBuffer) { }

	// RVA: 0x219DCE0 Offset: 0x219CEE0 VA: 0x18219DCE0
	internal void .ctor() { }
}

// Namespace: System.Net
public class HttpListenerPrefixCollection : ICollection<string>, IEnumerable<string>, IEnumerable // TypeDefIndex: 5941
{
	// Fields
	private List<string> prefixes; // 0x10
	private HttpListener listener; // 0x18

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public bool IsSynchronized { get; }

	// Methods

	// RVA: 0x219E3D0 Offset: 0x219D5D0 VA: 0x18219E3D0
	internal void .ctor(HttpListener listener) { }

	// RVA: 0x219E450 Offset: 0x219D650 VA: 0x18219E450 Slot: 4
	public int get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public bool get_IsSynchronized() { }

	// RVA: 0x219DE30 Offset: 0x219D030 VA: 0x18219DE30 Slot: 6
	public void Add(string uriPrefix) { }

	// RVA: 0x219DF60 Offset: 0x219D160 VA: 0x18219DF60 Slot: 7
	public void Clear() { }

	// RVA: 0x219E010 Offset: 0x219D210 VA: 0x18219E010 Slot: 8
	public bool Contains(string uriPrefix) { }

	// RVA: 0x219E080 Offset: 0x219D280 VA: 0x18219E080 Slot: 9
	public void CopyTo(string[] array, int offset) { }

	// RVA: 0x219E100 Offset: 0x219D300 VA: 0x18219E100
	public void CopyTo(Array array, int offset) { }

	// RVA: 0x219E180 Offset: 0x219D380 VA: 0x18219E180 Slot: 11
	public IEnumerator<string> GetEnumerator() { }

	// RVA: 0x219E320 Offset: 0x219D520 VA: 0x18219E320 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x219E200 Offset: 0x219D400 VA: 0x18219E200 Slot: 10
	public bool Remove(string uriPrefix) { }

	// RVA: 0x219E3A0 Offset: 0x219D5A0 VA: 0x18219E3A0
	internal void .ctor() { }
}

// Namespace: 
private class HttpListenerRequest.Context : TransportContext // TypeDefIndex: 5942
{
	// Methods

	// RVA: 0x21A79E0 Offset: 0x21A6BE0 VA: 0x1821A79E0 Slot: 4
	public override ChannelBinding GetChannelBinding(ChannelBindingKind kind) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class HttpListenerRequest.GCCDelegate : MulticastDelegate // TypeDefIndex: 5943
{
	// Methods

	// RVA: 0x1202980 Offset: 0x1201B80 VA: 0x181202980
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual X509Certificate2 Invoke() { }

	// RVA: 0x4240B0 Offset: 0x4232B0 VA: 0x1804240B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual X509Certificate2 EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public sealed class HttpListenerRequest // TypeDefIndex: 5944
{
	// Fields
	private string[] accept_types; // 0x10
	private Encoding content_encoding; // 0x18
	private long content_length; // 0x20
	private bool cl_set; // 0x28
	private CookieCollection cookies; // 0x30
	private WebHeaderCollection headers; // 0x38
	private string method; // 0x40
	private Stream input_stream; // 0x48
	private Version version; // 0x50
	private NameValueCollection query_string; // 0x58
	private string raw_url; // 0x60
	private Uri url; // 0x68
	private Uri referrer; // 0x70
	private string[] user_languages; // 0x78
	private HttpListenerContext context; // 0x80
	private bool is_chunked; // 0x88
	private bool ka_set; // 0x89
	private bool keep_alive; // 0x8A
	private HttpListenerRequest.GCCDelegate gcc_delegate; // 0x90
	private static byte[] _100continue; // 0x0
	private static char[] separators; // 0x8

	// Properties
	public string[] AcceptTypes { get; }
	public int ClientCertificateError { get; }
	public Encoding ContentEncoding { get; }
	public long ContentLength64 { get; }
	public string ContentType { get; }
	public CookieCollection Cookies { get; }
	public bool HasEntityBody { get; }
	public NameValueCollection Headers { get; }
	public string HttpMethod { get; }
	public Stream InputStream { get; }
	[MonoTODO("Always returns false")]
	public bool IsAuthenticated { get; }
	public bool IsLocal { get; }
	public bool IsSecureConnection { get; }
	public bool KeepAlive { get; }
	public IPEndPoint LocalEndPoint { get; }
	public Version ProtocolVersion { get; }
	public NameValueCollection QueryString { get; }
	public string RawUrl { get; }
	public IPEndPoint RemoteEndPoint { get; }
	[MonoTODO("Always returns Guid.Empty")]
	public Guid RequestTraceIdentifier { get; }
	public Uri Url { get; }
	public Uri UrlReferrer { get; }
	public string UserAgent { get; }
	public string UserHostAddress { get; }
	public string UserHostName { get; }
	public string[] UserLanguages { get; }
	[MonoTODO]
	public string ServiceName { get; }
	public TransportContext TransportContext { get; }
	[MonoTODO]
	public bool IsWebSocketRequest { get; }

	// Methods

	// RVA: 0x21A01A0 Offset: 0x219F3A0 VA: 0x1821A01A0
	internal void .ctor(HttpListenerContext context) { }

	// RVA: 0x219FD90 Offset: 0x219EF90 VA: 0x18219FD90
	internal void SetRequestLine(string req) { }

	// RVA: 0x219ED20 Offset: 0x219DF20 VA: 0x18219ED20
	private void CreateQueryString(string query) { }

	// RVA: 0x219FD00 Offset: 0x219EF00 VA: 0x18219FD00
	private static bool MaybeUri(string s) { }

	// RVA: 0x219FB20 Offset: 0x219ED20 VA: 0x18219FB20
	private static bool IsPredefinedScheme(string scheme) { }

	// RVA: 0x219EFF0 Offset: 0x219E1F0 VA: 0x18219EFF0
	internal bool FinishInitialization() { }

	// RVA: 0x21A0070 Offset: 0x219F270 VA: 0x1821A0070
	internal static string Unquote(string str) { }

	// RVA: 0x219E490 Offset: 0x219D690 VA: 0x18219E490
	internal void AddHeader(string header) { }

	// RVA: 0x219F730 Offset: 0x219E930 VA: 0x18219F730
	internal bool FlushInput() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string[] get_AcceptTypes() { }

	// RVA: 0x21A0270 Offset: 0x219F470 VA: 0x1821A0270
	public int get_ClientCertificateError() { }

	// RVA: 0x21A0320 Offset: 0x219F520 VA: 0x1821A0320
	public Encoding get_ContentEncoding() { }

	// RVA: 0x21A0350 Offset: 0x219F550 VA: 0x1821A0350
	public long get_ContentLength64() { }

	// RVA: 0x21A0370 Offset: 0x219F570 VA: 0x1821A0370
	public string get_ContentType() { }

	// RVA: 0x21A03C0 Offset: 0x219F5C0 VA: 0x1821A03C0
	public CookieCollection get_Cookies() { }

	// RVA: 0x21A0430 Offset: 0x219F630 VA: 0x1821A0430
	public bool get_HasEntityBody() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public NameValueCollection get_Headers() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_HttpMethod() { }

	// RVA: 0x21A0450 Offset: 0x219F650 VA: 0x1821A0450
	public Stream get_InputStream() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public bool get_IsAuthenticated() { }

	// RVA: 0x21A0500 Offset: 0x219F700 VA: 0x1821A0500
	public bool get_IsLocal() { }

	// RVA: 0x21A05F0 Offset: 0x219F7F0 VA: 0x1821A05F0
	public bool get_IsSecureConnection() { }

	// RVA: 0x21A0620 Offset: 0x219F820 VA: 0x1821A0620
	public bool get_KeepAlive() { }

	// RVA: 0x21A07A0 Offset: 0x219F9A0 VA: 0x1821A07A0
	public IPEndPoint get_LocalEndPoint() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public Version get_ProtocolVersion() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public NameValueCollection get_QueryString() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_RawUrl() { }

	// RVA: 0x21A08D0 Offset: 0x219FAD0 VA: 0x1821A08D0
	public IPEndPoint get_RemoteEndPoint() { }

	// RVA: 0x21A0980 Offset: 0x219FB80 VA: 0x1821A0980
	public Guid get_RequestTraceIdentifier() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public Uri get_Url() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public Uri get_UrlReferrer() { }

	// RVA: 0x21A0A20 Offset: 0x219FC20 VA: 0x1821A0A20
	public string get_UserAgent() { }

	// RVA: 0x21A0A70 Offset: 0x219FC70 VA: 0x1821A0A70
	public string get_UserHostAddress() { }

	// RVA: 0x21A0AB0 Offset: 0x219FCB0 VA: 0x1821A0AB0
	public string get_UserHostName() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public string[] get_UserLanguages() { }

	// RVA: 0x219EC70 Offset: 0x219DE70 VA: 0x18219EC70
	public IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state) { }

	// RVA: 0x219EF40 Offset: 0x219E140 VA: 0x18219EF40
	public X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult) { }

	// RVA: 0x219FAF0 Offset: 0x219ECF0 VA: 0x18219FAF0
	public X509Certificate2 GetClientCertificate() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public string get_ServiceName() { }

	// RVA: 0x21A09D0 Offset: 0x219FBD0 VA: 0x1821A09D0
	public TransportContext get_TransportContext() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public bool get_IsWebSocketRequest() { }

	// RVA: 0x219F9E0 Offset: 0x219EBE0 VA: 0x18219F9E0
	public Task<X509Certificate2> GetClientCertificateAsync() { }

	// RVA: 0x21A00E0 Offset: 0x219F2E0 VA: 0x1821A00E0
	private static void .cctor() { }

	// RVA: 0x21A0240 Offset: 0x219F440 VA: 0x1821A0240
	internal void .ctor() { }
}

// Namespace: System.Net
public sealed class HttpListenerResponse : IDisposable // TypeDefIndex: 5945
{
	// Fields
	private bool disposed; // 0x10
	private Encoding content_encoding; // 0x18
	private long content_length; // 0x20
	private bool cl_set; // 0x28
	private string content_type; // 0x30
	private CookieCollection cookies; // 0x38
	private WebHeaderCollection headers; // 0x40
	private bool keep_alive; // 0x48
	private ResponseStream output_stream; // 0x50
	private Version version; // 0x58
	private string location; // 0x60
	private int status_code; // 0x68
	private string status_description; // 0x70
	private bool chunked; // 0x78
	private HttpListenerContext context; // 0x80
	internal bool HeadersSent; // 0x88
	internal object headers_lock; // 0x90
	private bool force_close_chunked; // 0x98
	private static string tspecials; // 0x0

	// Properties
	internal bool ForceCloseChunked { get; }
	public Encoding ContentEncoding { get; set; }
	public long ContentLength64 { get; set; }
	public string ContentType { get; set; }
	public CookieCollection Cookies { get; set; }
	public WebHeaderCollection Headers { get; set; }
	public bool KeepAlive { get; set; }
	public Stream OutputStream { get; }
	public Version ProtocolVersion { get; set; }
	public string RedirectLocation { get; set; }
	public bool SendChunked { get; set; }
	public int StatusCode { get; set; }
	public string StatusDescription { get; set; }

	// Methods

	// RVA: 0x21A95E0 Offset: 0x21A87E0 VA: 0x1821A95E0
	internal void .ctor(HttpListenerContext context) { }

	// RVA: 0x738170 Offset: 0x737370 VA: 0x180738170
	internal bool get_ForceCloseChunked() { }

	// RVA: 0x21A0320 Offset: 0x219F520 VA: 0x1821A0320
	public Encoding get_ContentEncoding() { }

	// RVA: 0x21A97C0 Offset: 0x21A89C0 VA: 0x1821A97C0
	public void set_ContentEncoding(Encoding value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public long get_ContentLength64() { }

	// RVA: 0x21A9890 Offset: 0x21A8A90 VA: 0x1821A9890
	public void set_ContentLength64(long value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_ContentType() { }

	// RVA: 0x21A99D0 Offset: 0x21A8BD0 VA: 0x1821A99D0
	public void set_ContentType(string value) { }

	// RVA: 0x21A9710 Offset: 0x21A8910 VA: 0x1821A9710
	public CookieCollection get_Cookies() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Cookies(CookieCollection value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_KeepAlive() { }

	// RVA: 0x21A9AA0 Offset: 0x21A8CA0 VA: 0x1821A9AA0
	public void set_KeepAlive(bool value) { }

	// RVA: 0x21A9780 Offset: 0x21A8980 VA: 0x1821A9780
	public Stream get_OutputStream() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Version get_ProtocolVersion() { }

	// RVA: 0x21A9B70 Offset: 0x21A8D70 VA: 0x1821A9B70
	public void set_ProtocolVersion(Version value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_RedirectLocation() { }

	// RVA: 0x21A9DA0 Offset: 0x21A8FA0 VA: 0x1821A9DA0
	public void set_RedirectLocation(string value) { }

	// RVA: 0x61CC40 Offset: 0x61BE40 VA: 0x18061CC40
	public bool get_SendChunked() { }

	// RVA: 0x21A9E70 Offset: 0x21A9070 VA: 0x1821A9E70
	public void set_SendChunked(bool value) { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80
	public int get_StatusCode() { }

	// RVA: 0x21A9F40 Offset: 0x21A9140 VA: 0x1821A9F40
	public void set_StatusCode(int value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public string get_StatusDescription() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_StatusDescription(string value) { }

	// RVA: 0x21A9550 Offset: 0x21A8750 VA: 0x1821A9550 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21A7A20 Offset: 0x21A6C20 VA: 0x1821A7A20
	public void Abort() { }

	// RVA: 0x21A7A60 Offset: 0x21A6C60 VA: 0x1821A7A60
	public void AddHeader(string name, string value) { }

	// RVA: 0x21A7BF0 Offset: 0x21A6DF0 VA: 0x1821A7BF0
	public void AppendCookie(Cookie cookie) { }

	// RVA: 0x21A7CC0 Offset: 0x21A6EC0 VA: 0x1821A7CC0
	public void AppendHeader(string name, string value) { }

	// RVA: 0x21A8060 Offset: 0x21A7260 VA: 0x1821A8060
	private void Close(bool force) { }

	// RVA: 0x21A8020 Offset: 0x21A7220 VA: 0x1821A8020
	public void Close() { }

	// RVA: 0x21A7E50 Offset: 0x21A7050 VA: 0x1821A7E50
	public void Close(byte[] responseEntity, bool willBlock) { }

	// RVA: 0x21A8350 Offset: 0x21A7550 VA: 0x1821A8350
	public void CopyFrom(HttpListenerResponse templateResponse) { }

	// RVA: 0x21A8A70 Offset: 0x21A7C70 VA: 0x1821A8A70
	public void Redirect(string url) { }

	// RVA: 0x21A83D0 Offset: 0x21A75D0 VA: 0x1821A83D0
	private bool FindCookie(Cookie cookie) { }

	// RVA: 0x21A8AA0 Offset: 0x21A7CA0 VA: 0x1821A8AA0
	internal void SendHeaders(bool closing, MemoryStream ms) { }

	// RVA: 0x21A85C0 Offset: 0x21A77C0 VA: 0x1821A85C0
	private static string FormatHeaders(WebHeaderCollection headers) { }

	// RVA: 0x21A8090 Offset: 0x21A7290 VA: 0x1821A8090
	private static string CookieToClientString(Cookie cookie) { }

	// RVA: 0x21A8910 Offset: 0x21A7B10 VA: 0x1821A8910
	private static string QuotedString(Cookie cookie, string value) { }

	// RVA: 0x21A8840 Offset: 0x21A7A40 VA: 0x1821A8840
	private static bool IsToken(string value) { }

	// RVA: 0x21A9420 Offset: 0x21A8620 VA: 0x1821A9420
	public void SetCookie(Cookie cookie) { }

	// RVA: 0x21A9590 Offset: 0x21A8790 VA: 0x1821A9590
	private static void .cctor() { }

	// RVA: 0x21A96E0 Offset: 0x21A88E0 VA: 0x1821A96E0
	internal void .ctor() { }
}

// Namespace: System.Net
public class HttpListenerTimeoutManager // TypeDefIndex: 5946
{
	// Properties
	[MonoTODO]
	public TimeSpan EntityBody { get; set; }
	[MonoTODO]
	public TimeSpan DrainEntityBody { get; set; }
	[MonoTODO]
	public TimeSpan RequestQueue { get; set; }
	[MonoTODO]
	public TimeSpan IdleConnection { get; set; }
	[MonoTODO]
	public TimeSpan HeaderWait { get; set; }
	[MonoTODO]
	public long MinSendBytesPerSecond { get; set; }

	// Methods

	// RVA: 0x21AA0C0 Offset: 0x21A92C0 VA: 0x1821AA0C0
	public TimeSpan get_EntityBody() { }

	// RVA: 0x21AA240 Offset: 0x21A9440 VA: 0x1821AA240
	public void set_EntityBody(TimeSpan value) { }

	// RVA: 0x21AA080 Offset: 0x21A9280 VA: 0x1821AA080
	public TimeSpan get_DrainEntityBody() { }

	// RVA: 0x21AA200 Offset: 0x21A9400 VA: 0x1821AA200
	public void set_DrainEntityBody(TimeSpan value) { }

	// RVA: 0x21AA1C0 Offset: 0x21A93C0 VA: 0x1821AA1C0
	public TimeSpan get_RequestQueue() { }

	// RVA: 0x21AA340 Offset: 0x21A9540 VA: 0x1821AA340
	public void set_RequestQueue(TimeSpan value) { }

	// RVA: 0x21AA140 Offset: 0x21A9340 VA: 0x1821AA140
	public TimeSpan get_IdleConnection() { }

	// RVA: 0x21AA2C0 Offset: 0x21A94C0 VA: 0x1821AA2C0
	public void set_IdleConnection(TimeSpan value) { }

	// RVA: 0x21AA100 Offset: 0x21A9300 VA: 0x1821AA100
	public TimeSpan get_HeaderWait() { }

	// RVA: 0x21AA280 Offset: 0x21A9480 VA: 0x1821AA280
	public void set_HeaderWait(TimeSpan value) { }

	// RVA: 0x21AA180 Offset: 0x21A9380 VA: 0x1821AA180
	public long get_MinSendBytesPerSecond() { }

	// RVA: 0x21AA300 Offset: 0x21A9500 VA: 0x1821AA300
	public void set_MinSendBytesPerSecond(long value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net
internal class HttpRequestCreator : IWebRequestCreate // TypeDefIndex: 5947
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x21AA380 Offset: 0x21A9580 VA: 0x1821AA380 Slot: 4
	public WebRequest Create(Uri uri) { }
}

// Namespace: System.Net
internal class HttpStreamAsyncResult : IAsyncResult // TypeDefIndex: 5948
{
	// Fields
	private object locker; // 0x10
	private ManualResetEvent handle; // 0x18
	private bool completed; // 0x20
	internal byte[] Buffer; // 0x28
	internal int Offset; // 0x30
	internal int Count; // 0x34
	internal AsyncCallback Callback; // 0x38
	internal object State; // 0x40
	internal int SynchRead; // 0x48
	internal Exception Error; // 0x50

	// Properties
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x21AA4C0 Offset: 0x21A96C0 VA: 0x1821AA4C0
	public void Complete(Exception e) { }

	// RVA: 0x21AA3E0 Offset: 0x21A95E0 VA: 0x1821AA3E0
	public void Complete() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x21AA530 Offset: 0x21A9730 VA: 0x1821AA530 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x21AA610 Offset: 0x21A9810 VA: 0x1821AA610 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x21AA620 Offset: 0x21A9820 VA: 0x1821AA620 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x21AA4D0 Offset: 0x21A96D0 VA: 0x1821AA4D0
	public void .ctor() { }
}

// Namespace: 
private enum HttpWebRequest.NtlmAuthState // TypeDefIndex: 5949
{
	// Fields
	public int value__; // 0x0
	public const HttpWebRequest.NtlmAuthState None = 0;
	public const HttpWebRequest.NtlmAuthState Challenge = 1;
	public const HttpWebRequest.NtlmAuthState Response = 2;
}

// Namespace: 
private struct HttpWebRequest.AuthorizationState // TypeDefIndex: 5950
{
	// Fields
	private readonly HttpWebRequest request; // 0x0
	private readonly bool isProxy; // 0x8
	private bool isCompleted; // 0x9
	private HttpWebRequest.NtlmAuthState ntlm_auth_state; // 0xC

	// Properties
	public bool IsCompleted { get; }
	public HttpWebRequest.NtlmAuthState NtlmAuthState { get; }
	public bool IsNtlmAuthenticated { get; }

	// Methods

	// RVA: 0x48F5B0 Offset: 0x48E7B0 VA: 0x18048F5B0
	public bool get_IsCompleted() { }

	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public HttpWebRequest.NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x21A6CB0 Offset: 0x21A5EB0 VA: 0x1821A6CB0
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x21A6C90 Offset: 0x21A5E90 VA: 0x1821A6C90
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x21A68A0 Offset: 0x21A5AA0 VA: 0x1821A68A0
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x21A6B30 Offset: 0x21A5D30 VA: 0x1821A6B30
	public void Reset() { }

	// RVA: 0x21A6BB0 Offset: 0x21A5DB0 VA: 0x1821A6BB0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HttpWebRequest.<>c__241<T> // TypeDefIndex: 5951
{
	// Fields
	public static readonly HttpWebRequest.<>c__241<T> <>9; // 0x0
	public static Func<Task<T>, Nullable<int>> <>9__241_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-HttpWebRequest.<>c__241<int>..cctor
	|-HttpWebRequest.<>c__241<object>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-HttpWebRequest.<>c__241<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-HttpWebRequest.<>c__241<int>..ctor
	|-HttpWebRequest.<>c__241<object>..ctor
	|-HttpWebRequest.<>c__241<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Nullable<int> <RunWithTimeoutWorker>b__241_0(Task<T> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08910 Offset: 0xB07B10 VA: 0x180B08910
	|-HttpWebRequest.<>c__241<int>.<RunWithTimeoutWorker>b__241_0
	|
	|-RVA: 0xB08A30 Offset: 0xB07C30 VA: 0x180B08A30
	|-HttpWebRequest.<>c__241<object>.<RunWithTimeoutWorker>b__241_0
	|
	|-RVA: 0xB089A0 Offset: 0xB07BA0 VA: 0x180B089A0
	|-HttpWebRequest.<>c__241<__Il2CppFullySharedGenericType>.<RunWithTimeoutWorker>b__241_0
	*/
}

// Namespace: 
[CompilerGenerated]
private struct HttpWebRequest.<RunWithTimeoutWorker>d__241<T> : IAsyncStateMachine // TypeDefIndex: 5952
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	public Task<T> workerTask; // 0x0
	public int timeout; // 0x0
	public CancellationTokenSource cts; // 0x0
	public Action abort; // 0x0
	public Func<bool> aborted; // 0x0
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2CC60 Offset: 0xB2BE60 VA: 0x180B2CC60
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<int>.MoveNext
	|
	|-RVA: 0xB2BDD0 Offset: 0xB2AFD0 VA: 0x180B2BDD0
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<object>.MoveNext
	|
	|-RVA: 0xB2C450 Offset: 0xB2B650 VA: 0x180B2C450
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2D2E0 Offset: 0xB2C4E0 VA: 0x180B2D2E0
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<int>.SetStateMachine
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<object>.SetStateMachine
	|
	|-RVA: 0xB2D380 Offset: 0xB2C580 VA: 0x180B2D380
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<__Il2CppFullySharedGenericType>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGenerated]
private struct HttpWebRequest.<MyGetResponseAsync>d__243 : IAsyncStateMachine // TypeDefIndex: 5953
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpWebResponse> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private WebCompletionSource <completion>5__2; // 0x30
	private WebOperation <operation>5__3; // 0x38
	private WebException <throwMe>5__4; // 0x40
	private HttpWebResponse <response>5__5; // 0x48
	private WebResponseStream <stream>5__6; // 0x50
	private bool <redirect>5__7; // 0x58
	private bool <mustReadAll>5__8; // 0x59
	private WebOperation <ntlm>5__9; // 0x60
	private BufferOffsetSize <writeBuffer>5__10; // 0x68
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebRequestStream> <>u__1; // 0x70
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x80
	private TaskAwaiter<WebResponseStream> <>u__3; // 0x90
	[TupleElementNames(new[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> <>u__4; // 0x98

	// Methods

	// RVA: 0x21BBEA0 Offset: 0x21BB0A0 VA: 0x1821BBEA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21BCE30 Offset: 0x21BC030 VA: 0x1821BCE30 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpWebRequest.<GetResponseFromData>d__244 : IAsyncStateMachine // TypeDefIndex: 5954
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNames(new[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
	public AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	public WebResponseStream stream; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private HttpWebResponse <response>5__2; // 0x38
	private WebException <throwMe>5__3; // 0x40
	private bool <redirect>5__4; // 0x48
	private bool <mustReadAll>5__5; // 0x49
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<BufferOffsetSize> <>u__2; // 0x60

	// Methods

	// RVA: 0x21BB5E0 Offset: 0x21BA7E0 VA: 0x1821BB5E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21BBE30 Offset: 0x21BB030 VA: 0x1821BBE30 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpWebRequest.<<GetRewriteHandler>b__271_0>d : IAsyncStateMachine // TypeDefIndex: 5955
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<BufferOffsetSize> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	private MemoryStream <ms>5__2; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x21BD2D0 Offset: 0x21BC4D0 VA: 0x1821BD2D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21BD6A0 Offset: 0x21BC8A0 VA: 0x1821BD6A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
[Serializable]
public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 5956
{
	// Fields
	private Uri requestUri; // 0x38
	private Uri actualUri; // 0x40
	private bool hostChanged; // 0x48
	private bool allowAutoRedirect; // 0x49
	private bool allowBuffering; // 0x4A
	private bool allowReadStreamBuffering; // 0x4B
	private X509CertificateCollection certificates; // 0x50
	private string connectionGroup; // 0x58
	private bool haveContentLength; // 0x60
	private long contentLength; // 0x68
	private HttpContinueDelegate continueDelegate; // 0x70
	private CookieContainer cookieContainer; // 0x78
	private ICredentials credentials; // 0x80
	private bool haveResponse; // 0x88
	private bool requestSent; // 0x89
	private WebHeaderCollection webHeaders; // 0x90
	private bool keepAlive; // 0x98
	private int maxAutoRedirect; // 0x9C
	private string mediaType; // 0xA0
	private string method; // 0xA8
	private string initialMethod; // 0xB0
	private bool pipelined; // 0xB8
	private bool preAuthenticate; // 0xB9
	private bool usedPreAuth; // 0xBA
	private Version version; // 0xC0
	private bool force_version; // 0xC8
	private Version actualVersion; // 0xD0
	private IWebProxy proxy; // 0xD8
	private bool sendChunked; // 0xE0
	private ServicePoint servicePoint; // 0xE8
	private int timeout; // 0xF0
	private int continueTimeout; // 0xF4
	private WebRequestStream writeStream; // 0xF8
	private HttpWebResponse webResponse; // 0x100
	private WebCompletionSource responseTask; // 0x108
	private WebOperation currentOperation; // 0x110
	private int aborted; // 0x118
	private bool gotRequestStream; // 0x11C
	private int redirects; // 0x120
	private bool expectContinue; // 0x124
	private bool getResponseCalled; // 0x125
	private object locker; // 0x128
	private bool finished_reading; // 0x130
	private DecompressionMethods auto_decomp; // 0x134
	private int maxResponseHeadersLength; // 0x138
	private static int defaultMaxResponseHeadersLength; // 0x0
	private static int defaultMaximumErrorResponseLength; // 0x4
	private static RequestCachePolicy defaultCachePolicy; // 0x8
	private int readWriteTimeout; // 0x13C
	private MobileTlsProvider tlsProvider; // 0x140
	private MonoTlsSettings tlsSettings; // 0x148
	private ServerCertValidationCallback certValidationCallback; // 0x150
	private bool hostHasPort; // 0x158
	private Uri hostUri; // 0x160
	private HttpWebRequest.AuthorizationState auth_state; // 0x168
	private HttpWebRequest.AuthorizationState proxy_auth_state; // 0x178
	internal Func<Stream, Task> ResendContentFactory; // 0x188
	internal readonly int ID; // 0x190
	[CompilerGenerated]
	private bool <ThrowOnError>k__BackingField; // 0x194
	private bool unsafe_auth_blah; // 0x195
	[CompilerGenerated]
	private bool <ReuseConnection>k__BackingField; // 0x196

	// Properties
	public string Accept { get; set; }
	public Uri Address { get; set; }
	public virtual bool AllowAutoRedirect { get; set; }
	public virtual bool AllowWriteStreamBuffering { get; set; }
	public virtual bool AllowReadStreamBuffering { get; set; }
	public DecompressionMethods AutomaticDecompression { get; set; }
	internal bool InternalAllowBuffering { get; }
	private bool MethodWithBuffer { get; }
	internal MobileTlsProvider TlsProvider { get; }
	internal MonoTlsSettings TlsSettings { get; }
	public X509CertificateCollection ClientCertificates { get; set; }
	public string Connection { get; set; }
	public override string ConnectionGroupName { get; set; }
	public override long ContentLength { get; set; }
	internal long InternalContentLength { set; }
	internal bool ThrowOnError { get; set; }
	public override string ContentType { get; set; }
	public HttpContinueDelegate ContinueDelegate { get; set; }
	public virtual CookieContainer CookieContainer { get; set; }
	public override ICredentials Credentials { get; set; }
	public DateTime Date { get; set; }
	[MonoTODO]
	public static int DefaultMaximumErrorResponseLength { get; set; }
	public string Expect { get; set; }
	public virtual bool HaveResponse { get; }
	public override WebHeaderCollection Headers { get; set; }
	public string Host { get; set; }
	public DateTime IfModifiedSince { get; set; }
	public bool KeepAlive { get; set; }
	public int MaximumAutomaticRedirections { get; set; }
	[MonoTODO("Use this")]
	public int MaximumResponseHeadersLength { get; set; }
	[MonoTODO("Use this")]
	public static int DefaultMaximumResponseHeadersLength { get; set; }
	public int ReadWriteTimeout { get; set; }
	[MonoTODO]
	public int ContinueTimeout { get; set; }
	public string MediaType { get; set; }
	public override string Method { get; set; }
	public bool Pipelined { get; set; }
	public override bool PreAuthenticate { get; set; }
	public Version ProtocolVersion { get; set; }
	public override IWebProxy Proxy { get; set; }
	public string Referer { get; set; }
	public override Uri RequestUri { get; }
	public bool SendChunked { get; set; }
	public ServicePoint ServicePoint { get; }
	internal ServicePoint ServicePointNoLock { get; }
	public virtual bool SupportsCookieContainer { get; }
	public override int Timeout { get; set; }
	public string TransferEncoding { get; set; }
	public override bool UseDefaultCredentials { get; set; }
	public string UserAgent { get; set; }
	public bool UnsafeAuthenticatedConnectionSharing { get; set; }
	internal bool GotRequestStream { get; }
	internal bool ExpectContinue { get; set; }
	internal Uri AuthUri { get; }
	internal bool ProxyQuery { get; }
	internal ServerCertValidationCallback ServerCertValidationCallback { get; }
	public RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; set; }
	internal bool FinishedReading { get; set; }
	internal bool Aborted { get; }
	internal bool ReuseConnection { get; set; }

	// Methods

	// RVA: 0x21AE590 Offset: 0x21AD790 VA: 0x1821AE590
	private static void .cctor() { }

	// RVA: 0x21AE690 Offset: 0x21AD890 VA: 0x1821AE690
	public void .ctor(Uri uri) { }

	// RVA: 0x21AE620 Offset: 0x21AD820 VA: 0x1821AE620
	internal void .ctor(Uri uri, MobileTlsProvider tlsProvider, MonoTlsSettings settings) { }

	[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x21AE870 Offset: 0x21ADA70 VA: 0x1821AE870
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21ADF40 Offset: 0x21AD140 VA: 0x1821ADF40
	private void ResetAuthorization() { }

	// RVA: 0x21AE2F0 Offset: 0x21AD4F0 VA: 0x1821AE2F0
	private void SetSpecialHeaders(string HeaderName, string value) { }

	// RVA: 0x21AEA00 Offset: 0x21ADC00 VA: 0x1821AEA00
	public string get_Accept() { }

	// RVA: 0x21AF280 Offset: 0x21AE480 VA: 0x1821AF280
	public void set_Accept(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Uri get_Address() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_Address(Uri value) { }

	// RVA: 0x563E30 Offset: 0x563030 VA: 0x180563E30 Slot: 41
	public virtual bool get_AllowAutoRedirect() { }

	// RVA: 0x563E50 Offset: 0x563050 VA: 0x180563E50 Slot: 42
	public virtual void set_AllowAutoRedirect(bool value) { }

	// RVA: 0x190DBC0 Offset: 0x190CDC0 VA: 0x18190DBC0 Slot: 43
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x190DBD0 Offset: 0x190CDD0 VA: 0x18190DBD0 Slot: 44
	public virtual void set_AllowWriteStreamBuffering(bool value) { }

	// RVA: 0x190DBE0 Offset: 0x190CDE0 VA: 0x18190DBE0 Slot: 45
	public virtual bool get_AllowReadStreamBuffering() { }

	// RVA: 0x190DBF0 Offset: 0x190CDF0 VA: 0x18190DBF0 Slot: 46
	public virtual void set_AllowReadStreamBuffering(bool value) { }

	// RVA: 0x21AC4F0 Offset: 0x21AB6F0 VA: 0x1821AC4F0
	private static Exception GetMustImplement() { }

	// RVA: 0x1C61750 Offset: 0x1C60950 VA: 0x181C61750
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x21AF320 Offset: 0x21AE520 VA: 0x1821AF320
	public void set_AutomaticDecompression(DecompressionMethods value) { }

	// RVA: 0x21AEF70 Offset: 0x21AE170 VA: 0x1821AEF70
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x21AEF80 Offset: 0x21AE180 VA: 0x1821AEF80
	private bool get_MethodWithBuffer() { }

	// RVA: 0x78BCB0 Offset: 0x78AEB0 VA: 0x18078BCB0
	internal MobileTlsProvider get_TlsProvider() { }

	// RVA: 0x794D90 Offset: 0x793F90 VA: 0x180794D90
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x21AEA50 Offset: 0x21ADC50 VA: 0x1821AEA50
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x21AF390 Offset: 0x21AE590 VA: 0x1821AF390
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x21AEAC0 Offset: 0x21ADCC0 VA: 0x1821AEAC0
	public string get_Connection() { }

	// RVA: 0x21AF400 Offset: 0x21AE600 VA: 0x1821AF400
	public void set_Connection(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 14
	public override string get_ConnectionGroupName() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0 Slot: 15
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 18
	public override long get_ContentLength() { }

	// RVA: 0x21AF5F0 Offset: 0x21AE7F0 VA: 0x1821AF5F0 Slot: 19
	public override void set_ContentLength(long value) { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	internal void set_InternalContentLength(long value) { }

	[CompilerGenerated]
	// RVA: 0x19AD060 Offset: 0x19AC260 VA: 0x1819AD060
	internal bool get_ThrowOnError() { }

	[CompilerGenerated]
	// RVA: 0x21B08A0 Offset: 0x21AFAA0 VA: 0x1821B08A0
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x21AEB10 Offset: 0x21ADD10 VA: 0x1821AEB10 Slot: 20
	public override string get_ContentType() { }

	// RVA: 0x21AF6C0 Offset: 0x21AE8C0 VA: 0x1821AF6C0 Slot: 21
	public override void set_ContentType(string value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public HttpContinueDelegate get_ContinueDelegate() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_ContinueDelegate(HttpContinueDelegate value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 47
	public virtual CookieContainer get_CookieContainer() { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40 Slot: 48
	public virtual void set_CookieContainer(CookieContainer value) { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830 Slot: 22
	public override ICredentials get_Credentials() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780 Slot: 23
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x21AEB60 Offset: 0x21ADD60 VA: 0x1821AEB60
	public DateTime get_Date() { }

	// RVA: 0x21AF7E0 Offset: 0x21AE9E0 VA: 0x1821AF7E0
	public void set_Date(DateTime value) { }

	// RVA: 0x21AE250 Offset: 0x21AD450 VA: 0x1821AE250
	private void SetDateHeaderHelper(string headerName, DateTime dateTime) { }

	// RVA: 0x21AEC70 Offset: 0x21ADE70 VA: 0x1821AEC70
	public static int get_DefaultMaximumErrorResponseLength() { }

	// RVA: 0x21AF8A0 Offset: 0x21AEAA0 VA: 0x1821AF8A0
	public static void set_DefaultMaximumErrorResponseLength(int value) { }

	// RVA: 0x21AED20 Offset: 0x21ADF20 VA: 0x1821AED20
	public string get_Expect() { }

	// RVA: 0x21AF970 Offset: 0x21AEB70 VA: 0x1821AF970
	public void set_Expect(string value) { }

	// RVA: 0x5C3440 Offset: 0x5C2640 VA: 0x1805C3440 Slot: 49
	public virtual bool get_HaveResponse() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560 Slot: 16
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x21AFB10 Offset: 0x21AED10 VA: 0x1821AFB10 Slot: 17
	public override void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x21AED80 Offset: 0x21ADF80 VA: 0x1821AED80
	public string get_Host() { }

	// RVA: 0x21AFC90 Offset: 0x21AEE90 VA: 0x1821AFC90
	public void set_Host(string value) { }

	// RVA: 0x21AE3E0 Offset: 0x21AD5E0 VA: 0x1821AE3E0
	private bool TryGetHostUri(string hostName, out Uri hostUri) { }

	// RVA: 0x21AEE90 Offset: 0x21AE090 VA: 0x1821AEE90
	public DateTime get_IfModifiedSince() { }

	// RVA: 0x21AFF10 Offset: 0x21AF110 VA: 0x1821AFF10
	public void set_IfModifiedSince(DateTime value) { }

	// RVA: 0x738170 Offset: 0x737370 VA: 0x180738170
	public bool get_KeepAlive() { }

	// RVA: 0x7388B0 Offset: 0x737AB0 VA: 0x1807388B0
	public void set_KeepAlive(bool value) { }

	// RVA: 0x1944140 Offset: 0x1943340 VA: 0x181944140
	public int get_MaximumAutomaticRedirections() { }

	// RVA: 0x21B0010 Offset: 0x21AF210 VA: 0x1821B0010
	public void set_MaximumAutomaticRedirections(int value) { }

	// RVA: 0x19A2DD0 Offset: 0x19A1FD0 VA: 0x1819A2DD0
	public int get_MaximumResponseHeadersLength() { }

	// RVA: 0x21B00A0 Offset: 0x21AF2A0 VA: 0x1821B00A0
	public void set_MaximumResponseHeadersLength(int value) { }

	// RVA: 0x21AECC0 Offset: 0x21ADEC0 VA: 0x1821AECC0
	public static int get_DefaultMaximumResponseHeadersLength() { }

	// RVA: 0x21AF900 Offset: 0x21AEB00 VA: 0x1821AF900
	public static void set_DefaultMaximumResponseHeadersLength(int value) { }

	// RVA: 0x21AF0A0 Offset: 0x21AE2A0 VA: 0x1821AF0A0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x21B05C0 Offset: 0x21AF7C0 VA: 0x1821B05C0
	public void set_ReadWriteTimeout(int value) { }

	// RVA: 0xB82FE0 Offset: 0xB821E0 VA: 0x180B82FE0
	public int get_ContinueTimeout() { }

	// RVA: 0x21AF710 Offset: 0x21AE910 VA: 0x1821AF710
	public void set_ContinueTimeout(int value) { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public string get_MediaType() { }

	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20
	public void set_MediaType(string value) { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0 Slot: 11
	public override string get_Method() { }

	// RVA: 0x21B0170 Offset: 0x21AF370 VA: 0x1821B0170 Slot: 12
	public override void set_Method(string value) { }

	// RVA: 0x535D10 Offset: 0x534F10 VA: 0x180535D10
	public bool get_Pipelined() { }

	// RVA: 0x21B0400 Offset: 0x21AF600 VA: 0x1821B0400
	public void set_Pipelined(bool value) { }

	// RVA: 0x21AF060 Offset: 0x21AE260 VA: 0x1821AF060 Slot: 28
	public override bool get_PreAuthenticate() { }

	// RVA: 0x21B0410 Offset: 0x21AF610 VA: 0x1821B0410 Slot: 29
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0
	public Version get_ProtocolVersion() { }

	// RVA: 0x21B0420 Offset: 0x21AF620 VA: 0x1821B0420
	public void set_ProtocolVersion(Version value) { }

	// RVA: 0x599C40 Offset: 0x598E40 VA: 0x180599C40 Slot: 26
	public override IWebProxy get_Proxy() { }

	// RVA: 0x21B0540 Offset: 0x21AF740 VA: 0x1821B0540 Slot: 27
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x21AF0B0 Offset: 0x21AE2B0 VA: 0x1821AF0B0
	public string get_Referer() { }

	// RVA: 0x21B06A0 Offset: 0x21AF8A0 VA: 0x1821B06A0
	public void set_Referer(string value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 13
	public override Uri get_RequestUri() { }

	// RVA: 0x21AF110 Offset: 0x21AE310 VA: 0x1821AF110
	public bool get_SendChunked() { }

	// RVA: 0x21B07B0 Offset: 0x21AF9B0 VA: 0x1821B07B0
	public void set_SendChunked(bool value) { }

	// RVA: 0x21AF140 Offset: 0x21AE340 VA: 0x1821AF140
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x796090 Offset: 0x795290 VA: 0x180796090
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 50
	public virtual bool get_SupportsCookieContainer() { }

	// RVA: 0x190DCF0 Offset: 0x190CEF0 VA: 0x18190DCF0 Slot: 30
	public override int get_Timeout() { }

	// RVA: 0x21B08B0 Offset: 0x21AFAB0 VA: 0x1821B08B0 Slot: 31
	public override void set_Timeout(int value) { }

	// RVA: 0x21AF150 Offset: 0x21AE350 VA: 0x1821AF150
	public string get_TransferEncoding() { }

	// RVA: 0x21B0920 Offset: 0x21AFB20 VA: 0x1821B0920
	public void set_TransferEncoding(string value) { }

	// RVA: 0x21AF1B0 Offset: 0x21AE3B0 VA: 0x1821AF1B0 Slot: 24
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x21B0B40 Offset: 0x21AFD40 VA: 0x1821B0B40 Slot: 25
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x21AF230 Offset: 0x21AE430 VA: 0x1821AF230
	public string get_UserAgent() { }

	// RVA: 0x21B0BC0 Offset: 0x21AFDC0 VA: 0x1821B0BC0
	public void set_UserAgent(string value) { }

	// RVA: 0x21AF1A0 Offset: 0x21AE3A0 VA: 0x1821AF1A0
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x21B0B30 Offset: 0x21AFD30 VA: 0x1821B0B30
	public void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	// RVA: 0x21AED70 Offset: 0x21ADF70 VA: 0x1821AED70
	internal bool get_GotRequestStream() { }

	// RVA: 0x21AED10 Offset: 0x21ADF10 VA: 0x1821AED10
	internal bool get_ExpectContinue() { }

	// RVA: 0x21AF960 Offset: 0x21AEB60 VA: 0x1821AF960
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal Uri get_AuthUri() { }

	// RVA: 0x21AF070 Offset: 0x21AE270 VA: 0x1821AF070
	internal bool get_ProxyQuery() { }

	// RVA: 0x794D40 Offset: 0x793F40 VA: 0x180794D40
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x21AF120 Offset: 0x21AE320 VA: 0x1821AF120
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x21B0820 Offset: 0x21AFA20 VA: 0x1821B0820
	public void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	// RVA: 0x21ACE70 Offset: 0x21AC070 VA: 0x1821ACE70
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x21AA850 Offset: 0x21A9A50 VA: 0x1821AA850
	public void AddRange(int range) { }

	// RVA: 0x21AA790 Offset: 0x21A9990 VA: 0x1821AA790
	public void AddRange(int from, int to) { }

	// RVA: 0x21AA780 Offset: 0x21A9980 VA: 0x1821AA780
	public void AddRange(string rangeSpecifier, int range) { }

	// RVA: 0x21AAB50 Offset: 0x21A9D50 VA: 0x1821AAB50
	public void AddRange(string rangeSpecifier, int from, int to) { }

	// RVA: 0x21AA800 Offset: 0x21A9A00 VA: 0x1821AA800
	public void AddRange(long range) { }

	// RVA: 0x21AAB70 Offset: 0x21A9D70 VA: 0x1821AAB70
	public void AddRange(long from, long to) { }

	// RVA: 0x21AA8A0 Offset: 0x21A9AA0 VA: 0x1821AA8A0
	public void AddRange(string rangeSpecifier, long range) { }

	// RVA: 0x21AABE0 Offset: 0x21A9DE0 VA: 0x1821AABE0
	public void AddRange(string rangeSpecifier, long from, long to) { }

	// RVA: 0x21ADFF0 Offset: 0x21AD1F0 VA: 0x1821ADFF0
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x21AD530 Offset: 0x21AC730 VA: 0x1821AD530
	private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken) { }

	// RVA: 0x21AAEB0 Offset: 0x21AA0B0 VA: 0x1821AAEB0 Slot: 36
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x21AB920 Offset: 0x21AAB20 VA: 0x1821AB920 Slot: 37
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x21ACA10 Offset: 0x21ABC10 VA: 0x1821ACA10 Slot: 32
	public override Stream GetRequestStream() { }

	[MonoTODO]
	// RVA: 0x21AC9D0 Offset: 0x21ABBD0 VA: 0x1821AC9D0
	public Stream GetRequestStream(out TransportContext context) { }

	// RVA: 0x21AC940 Offset: 0x21ABB40 VA: 0x1821AC940 Slot: 38
	public override Task<Stream> GetRequestStreamAsync() { }

	// RVA: -1 Offset: -1
	internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA22AE0 Offset: 0xA21CE0 VA: 0x180A22AE0
	|-HttpWebRequest.RunWithTimeout<int>
	|
	|-RVA: 0xA229B0 Offset: 0xA21BB0 VA: 0x180A229B0
	|-HttpWebRequest.RunWithTimeout<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<RunWithTimeoutWorker>d__241<T>))]
	// RVA: -1 Offset: -1
	private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA225F0 Offset: 0xA217F0 VA: 0x180A225F0
	|-HttpWebRequest.RunWithTimeoutWorker<int>
	|
	|-RVA: 0xA22710 Offset: 0xA21910 VA: 0x180A22710
	|-HttpWebRequest.RunWithTimeoutWorker<object>
	|
	|-RVA: 0xA224C0 Offset: 0xA216C0 VA: 0x180A224C0
	|-HttpWebRequest.RunWithTimeoutWorker<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA22CA0 Offset: 0xA21EA0 VA: 0x180A22CA0
	|-HttpWebRequest.RunWithTimeout<object>
	|
	|-RVA: 0xA22830 Offset: 0xA21A30 VA: 0x180A22830
	|-HttpWebRequest.RunWithTimeout<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<MyGetResponseAsync>d__243))]
	// RVA: 0x21AD900 Offset: 0x21ACB00 VA: 0x1821AD900
	private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(HttpWebRequest.<GetResponseFromData>d__244))]
	// RVA: 0x21ACAB0 Offset: 0x21ABCB0 VA: 0x1821ACAB0
	private Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x21ABB40 Offset: 0x21AAD40 VA: 0x1821ABB40
	internal static Exception FlattenException(Exception e) { }

	// RVA: 0x21AD210 Offset: 0x21AC410 VA: 0x1821AD210
	private WebException GetWebException(Exception e) { }

	// RVA: 0x21ACF70 Offset: 0x21AC170 VA: 0x1821ACF70
	private static WebException GetWebException(Exception e, bool aborted) { }

	// RVA: 0x21AB6D0 Offset: 0x21AA8D0 VA: 0x1821AB6D0
	internal static WebException CreateRequestAbortedException() { }

	// RVA: 0x21AAF60 Offset: 0x21AA160 VA: 0x1821AAF60 Slot: 34
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x21ABA70 Offset: 0x21AAC70 VA: 0x1821ABA70 Slot: 35
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x21AB9F0 Offset: 0x21AABF0 VA: 0x1821AB9F0
	public Stream EndGetRequestStream(IAsyncResult asyncResult, out TransportContext context) { }

	// RVA: 0x21ACBD0 Offset: 0x21ABDD0 VA: 0x1821ACBD0 Slot: 33
	public override WebResponse GetResponse() { }

	// RVA: 0x19BF270 Offset: 0x19BE470 VA: 0x1819BF270
	internal bool get_FinishedReading() { }

	// RVA: 0x21AFB00 Offset: 0x21AED00 VA: 0x1821AFB00
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x21AE9D0 Offset: 0x21ADBD0 VA: 0x1821AE9D0
	internal bool get_Aborted() { }

	// RVA: 0x21AA6C0 Offset: 0x21A98C0 VA: 0x1821AA6C0 Slot: 40
	public override void Abort() { }

	// RVA: 0x21AE3A0 Offset: 0x21AD5A0 VA: 0x1821AE3A0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21AC540 Offset: 0x21AB740 VA: 0x1821AC540 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21AB660 Offset: 0x21AA860 VA: 0x1821AB660
	private void CheckRequestStarted() { }

	// RVA: 0x21AB770 Offset: 0x21AA970 VA: 0x1821AB770
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x21ADF80 Offset: 0x21AD180 VA: 0x1821ADF80
	private void RewriteRedirectToGet() { }

	// RVA: 0x21ADA20 Offset: 0x21ACC20 VA: 0x1821ADA20
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x21ABCF0 Offset: 0x21AAEF0 VA: 0x1821ABCF0
	private string GetHeaders() { }

	// RVA: 0x21AB790 Offset: 0x21AA990 VA: 0x1821AB790
	private void DoPreAuthenticate() { }

	// RVA: 0x21AC580 Offset: 0x21AB780 VA: 0x1821AC580
	internal byte[] GetRequestHeaders() { }

	// RVA: 0x21AD290 Offset: 0x21AC490 VA: 0x1821AD290
	private ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x21AB130 Offset: 0x21AA330 VA: 0x1821AB130
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x21ACC70 Offset: 0x21ABE70 VA: 0x1821ACC70
	private ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x21AB160 Offset: 0x21AA360 VA: 0x1821AB160
	private ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response) { }

	[CompilerGenerated]
	// RVA: 0x21AF100 Offset: 0x21AE300 VA: 0x1821AF100
	internal bool get_ReuseConnection() { }

	[CompilerGenerated]
	// RVA: 0x21B07A0 Offset: 0x21AF9A0 VA: 0x1821B07A0
	internal void set_ReuseConnection(bool value) { }

	// RVA: 0x21ABC10 Offset: 0x21AAE10 VA: 0x1821ABC10
	internal static StringBuilder GenerateConnectionGroup(string connectionGroupName, bool unsafeConnectionGroup, bool isInternalGroup) { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private bool <RunWithTimeout>b__242_0<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA22ED0 Offset: 0xA220D0 VA: 0x180A22ED0
	|-HttpWebRequest.<RunWithTimeout>b__242_0<object>
	|-HttpWebRequest.<RunWithTimeout>b__242_0<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<<GetRewriteHandler>b__271_0>d))]
	[CompilerGenerated]
	// RVA: 0x21AE4B0 Offset: 0x21AD6B0 VA: 0x1821AE4B0
	private Task<BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	[EditorBrowsable(1)]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	// RVA: 0x21AE660 Offset: 0x21AD860 VA: 0x1821AE660
	public void .ctor() { }
}

// Namespace: System.Net
[Serializable]
public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 5957
{
	// Fields
	private Uri uri; // 0x20
	private WebHeaderCollection webHeaders; // 0x28
	private CookieCollection cookieCollection; // 0x30
	private string method; // 0x38
	private Version version; // 0x40
	private HttpStatusCode statusCode; // 0x48
	private string statusDescription; // 0x50
	private long contentLength; // 0x58
	private string contentType; // 0x60
	private CookieContainer cookie_container; // 0x68
	private bool disposed; // 0x70
	private Stream stream; // 0x78

	// Properties
	public string CharacterSet { get; }
	public string ContentEncoding { get; }
	public override long ContentLength { get; }
	public override string ContentType { get; }
	public virtual CookieCollection Cookies { get; set; }
	public override WebHeaderCollection Headers { get; }
	[MonoTODO]
	public override bool IsMutuallyAuthenticated { get; }
	public DateTime LastModified { get; }
	public virtual string Method { get; }
	public Version ProtocolVersion { get; }
	public override Uri ResponseUri { get; }
	public string Server { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual string StatusDescription { get; }
	public override bool SupportsHeaders { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x21B1170 Offset: 0x21B0370 VA: 0x1821B1170
	internal void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x21B1630 Offset: 0x21B0830 VA: 0x1821B1630
	internal void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	[Obsolete("Serialization is obsoleted for this type", False)]
	// RVA: 0x21B1230 Offset: 0x21B0430 VA: 0x1821B1230
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21B1890 Offset: 0x21B0A90 VA: 0x1821B1890
	public string get_CharacterSet() { }

	// RVA: 0x21B19A0 Offset: 0x21B0BA0 VA: 0x1821B19A0
	public string get_ContentEncoding() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 14
	public override long get_ContentLength() { }

	// RVA: 0x21B1A10 Offset: 0x21B0C10 VA: 0x1821B1A10 Slot: 16
	public override string get_ContentType() { }

	// RVA: 0x21B1AA0 Offset: 0x21B0CA0 VA: 0x1821B1AA0 Slot: 22
	public virtual CookieCollection get_Cookies() { }

	// RVA: 0x21B1CE0 Offset: 0x21B0EE0 VA: 0x1821B1CE0 Slot: 23
	public virtual void set_Cookies(CookieCollection value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 20
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x21B0E80 Offset: 0x21B0080 VA: 0x1821B0E80
	private static Exception GetMustImplement() { }

	// RVA: 0x21B1B10 Offset: 0x21B0D10 VA: 0x1821B1B10 Slot: 13
	public override bool get_IsMutuallyAuthenticated() { }

	// RVA: 0x21B1B40 Offset: 0x21B0D40 VA: 0x1821B1B40
	public DateTime get_LastModified() { }

	// RVA: 0x21B1BF0 Offset: 0x21B0DF0 VA: 0x1821B1BF0 Slot: 24
	public virtual string get_Method() { }

	// RVA: 0x21B1C10 Offset: 0x21B0E10 VA: 0x1821B1C10
	public Version get_ProtocolVersion() { }

	// RVA: 0x21B1C30 Offset: 0x21B0E30 VA: 0x1821B1C30 Slot: 19
	public override Uri get_ResponseUri() { }

	// RVA: 0x21B1C50 Offset: 0x21B0E50 VA: 0x1821B1C50
	public string get_Server() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0 Slot: 25
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x21B1CC0 Offset: 0x21B0EC0 VA: 0x1821B1CC0 Slot: 26
	public virtual string get_StatusDescription() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 21
	public override bool get_SupportsHeaders() { }

	// RVA: 0x21B1040 Offset: 0x21B0240 VA: 0x1821B1040
	public string GetResponseHeader(string headerName) { }

	// RVA: 0x21B10B0 Offset: 0x21B02B0 VA: 0x1821B10B0 Slot: 18
	public override Stream GetResponseStream() { }

	// RVA: 0x2189950 Offset: 0x2188B50 VA: 0x182189950 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21B0ED0 Offset: 0x21B00D0 VA: 0x1821B0ED0 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21B0CB0 Offset: 0x21AFEB0 VA: 0x1821B0CB0 Slot: 9
	public override void Close() { }

	// RVA: 0x21B1150 Offset: 0x21B0350 VA: 0x1821B1150 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21B0CF0 Offset: 0x21AFEF0 VA: 0x1821B0CF0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21B0C20 Offset: 0x21AFE20 VA: 0x1821B0C20
	private void CheckDisposed() { }

	// RVA: 0x21B0D00 Offset: 0x21AFF00 VA: 0x1821B0D00
	private void FillCookies() { }
}

// Namespace: System.Net
public interface ICredentialPolicy // TypeDefIndex: 5958
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool ShouldSendCredential(Uri challengeUri, WebRequest request, NetworkCredential credential, IAuthenticationModule authenticationModule);
}

// Namespace: System.Net
internal struct IPv6AddressFormatter // TypeDefIndex: 5959
{
	// Fields
	private ushort[] address; // 0x0
	private long scopeId; // 0x8

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(ushort[] addr, long scopeId) { }

	// RVA: 0x172DF60 Offset: 0x172D160 VA: 0x18172DF60
	private static ushort SwapUShort(ushort number) { }

	// RVA: 0x21B1D10 Offset: 0x21B0F10 VA: 0x1821B1D10
	private uint AsIPv4Int() { }

	// RVA: 0x21B1D60 Offset: 0x21B0F60 VA: 0x1821B1D60
	private bool IsIPv4Compatible() { }

	// RVA: 0x21B1DF0 Offset: 0x21B0FF0 VA: 0x1821B1DF0
	private bool IsIPv4Mapped() { }

	// RVA: 0x21B1E60 Offset: 0x21B1060 VA: 0x1821B1E60 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net
public interface IWebProxyScript // TypeDefIndex: 5960
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool Load(Uri scriptLocation, string script, Type helperType);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string Run(string url, string host);
}

// Namespace: System.Net
internal class ListenerAsyncResult : IAsyncResult // TypeDefIndex: 5961
{
	// Fields
	private ManualResetEvent handle; // 0x10
	private bool synch; // 0x18
	private bool completed; // 0x19
	private AsyncCallback cb; // 0x20
	private object state; // 0x28
	private Exception exception; // 0x30
	private HttpListenerContext context; // 0x38
	private object locker; // 0x40
	private ListenerAsyncResult forward; // 0x48
	internal bool EndCalled; // 0x50
	internal bool InGet; // 0x51
	private static WaitCallback InvokeCB; // 0x0

	// Properties
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x21B2B20 Offset: 0x21B1D20 VA: 0x1821B2B20
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x21B27A0 Offset: 0x21B19A0 VA: 0x1821B27A0
	internal void Complete(Exception exc) { }

	// RVA: 0x21B29C0 Offset: 0x21B1BC0 VA: 0x1821B29C0
	private static void InvokeCallback(object o) { }

	// RVA: 0x21B2210 Offset: 0x21B1410 VA: 0x1821B2210
	internal void Complete(HttpListenerContext context) { }

	// RVA: 0x21B2220 Offset: 0x21B1420 VA: 0x1821B2220
	internal void Complete(HttpListenerContext context, bool synch) { }

	// RVA: 0x21B2960 Offset: 0x21B1B60 VA: 0x1821B2960
	internal HttpListenerContext GetContext() { }

	// RVA: 0x21B2BA0 Offset: 0x21B1DA0 VA: 0x1821B2BA0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x21B2BC0 Offset: 0x21B1DC0 VA: 0x1821B2BC0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x21B2CD0 Offset: 0x21B1ED0 VA: 0x1821B2CD0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x21B2CF0 Offset: 0x21B1EF0 VA: 0x1821B2CF0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x21B2AA0 Offset: 0x21B1CA0 VA: 0x1821B2AA0
	private static void .cctor() { }
}

// Namespace: System.Net
internal sealed class ListenerPrefix // TypeDefIndex: 5962
{
	// Fields
	private string original; // 0x10
	private string host; // 0x18
	private ushort port; // 0x20
	private string path; // 0x28
	private bool secure; // 0x30
	private IPAddress[] addresses; // 0x38
	public HttpListener Listener; // 0x40

	// Properties
	public IPAddress[] Addresses { get; set; }
	public bool Secure { get; }
	public string Host { get; }
	public int Port { get; }
	public string Path { get; }

	// Methods

	// RVA: 0x21B3540 Offset: 0x21B2740 VA: 0x1821B3540
	public void .ctor(string prefix) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public IPAddress[] get_Addresses() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Addresses(IPAddress[] value) { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_Secure() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Host() { }

	// RVA: 0x8CA2C0 Offset: 0x8C94C0 VA: 0x1808CA2C0
	public int get_Port() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Path() { }

	// RVA: 0x21B3170 Offset: 0x21B2370 VA: 0x1821B3170 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21B31E0 Offset: 0x21B23E0 VA: 0x1821B31E0
	private void Parse(string uri) { }

	// RVA: 0x21B2DB0 Offset: 0x21B1FB0 VA: 0x1821B2DB0
	public static void CheckUri(string uri) { }
}

// Namespace: 
private enum MonoChunkParser.State // TypeDefIndex: 5963
{
	// Fields
	public int value__; // 0x0
	public const MonoChunkParser.State None = 0;
	public const MonoChunkParser.State PartialSize = 1;
	public const MonoChunkParser.State Body = 2;
	public const MonoChunkParser.State BodyFinished = 3;
	public const MonoChunkParser.State Trailer = 4;
}

// Namespace: 
private class MonoChunkParser.Chunk // TypeDefIndex: 5964
{
	// Fields
	public byte[] Bytes; // 0x10
	public int Offset; // 0x18

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(byte[] chunk) { }

	// RVA: 0x21A6CD0 Offset: 0x21A5ED0 VA: 0x1821A6CD0
	public int Read(byte[] buffer, int offset, int size) { }
}

// Namespace: System.Net
internal class MonoChunkParser // TypeDefIndex: 5965
{
	// Fields
	private WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private MonoChunkParser.State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties
	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int TotalDataSize { get; }
	public int ChunkLeft { get; }

	// Methods

	// RVA: 0x21B43F0 Offset: 0x21B35F0 VA: 0x1821B43F0
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x21B4340 Offset: 0x21B3540 VA: 0x1821B4340
	public void WriteAndReadBack(byte[] buffer, int offset, int size, ref int read) { }

	// RVA: 0x21B4280 Offset: 0x21B3480 VA: 0x1821B4280
	public int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x21B3D20 Offset: 0x21B2F20 VA: 0x1821B3D20
	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	// RVA: 0x21B43C0 Offset: 0x21B35C0 VA: 0x1821B43C0
	public void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x21B3850 Offset: 0x21B2A50 VA: 0x1821B3850
	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x21B45D0 Offset: 0x21B37D0 VA: 0x1821B45D0
	public bool get_WantMore() { }

	// RVA: 0x21B44A0 Offset: 0x21B36A0 VA: 0x1821B44A0
	public bool get_DataAvailable() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_TotalDataSize() { }

	// RVA: 0x21B4490 Offset: 0x21B3690 VA: 0x1821B4490
	public int get_ChunkLeft() { }

	// RVA: 0x21B3B10 Offset: 0x21B2D10 VA: 0x1821B3B10
	private MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x21B3580 Offset: 0x21B2780 VA: 0x1821B3580
	private MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x21B4290 Offset: 0x21B3490 VA: 0x1821B4290
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x21B3C40 Offset: 0x21B2E40 VA: 0x1821B3C40
	private MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x21B4020 Offset: 0x21B3220 VA: 0x1821B4020
	private MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x21B42E0 Offset: 0x21B34E0 VA: 0x1821B42E0
	private static void ThrowProtocolViolation(string message) { }
}

// Namespace: 
[CompilerGenerated]
private struct MonoChunkStream.<ProcessReadAsync>d__7 : IAsyncStateMachine // TypeDefIndex: 5966
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public MonoChunkStream <>4__this; // 0x28
	public byte[] buffer; // 0x30
	public int offset; // 0x38
	public int size; // 0x3C
	private byte[] <moreBytes>5__2; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x21BCEA0 Offset: 0x21BC0A0 VA: 0x1821BCEA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21BD260 Offset: 0x21BC460 VA: 0x1821BD260 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct MonoChunkStream.<FinishReading>d__8 : IAsyncStateMachine // TypeDefIndex: 5967
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public MonoChunkStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30
	private byte[] <buffer>5__2; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2; // 0x48

	// Methods

	// RVA: 0x21BB150 Offset: 0x21BA350 VA: 0x1821BB150 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21BB580 Offset: 0x21BA780 VA: 0x1821BB580 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class MonoChunkStream : WebReadStream // TypeDefIndex: 5968
{
	// Fields
	[CompilerGenerated]
	private readonly WebHeaderCollection <Headers>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly MonoChunkParser <Decoder>k__BackingField; // 0x48

	// Properties
	protected WebHeaderCollection Headers { get; }
	protected MonoChunkParser Decoder { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	protected WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	protected MonoChunkParser get_Decoder() { }

	// RVA: 0x21B4870 Offset: 0x21B3A70 VA: 0x1821B4870
	public void .ctor(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	[AsyncStateMachine(typeof(MonoChunkStream.<ProcessReadAsync>d__7))]
	// RVA: 0x21B46D0 Offset: 0x21B38D0 VA: 0x1821B46D0 Slot: 40
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MonoChunkStream.<FinishReading>d__8))]
	// RVA: 0x21B45F0 Offset: 0x21B37F0 VA: 0x1821B45F0 Slot: 41
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x21B47F0 Offset: 0x21B39F0 VA: 0x1821B47F0
	private static void ThrowExpectingChunkTrailer() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x21B4860 Offset: 0x21B3A60 VA: 0x1821B4860
	private Task <>n__0(CancellationToken cancellationToken) { }
}

// Namespace: System.Net
internal class MonoHttpDate // TypeDefIndex: 5969
{
	// Fields
	private static readonly string rfc1123_date; // 0x0
	private static readonly string rfc850_date; // 0x8
	private static readonly string asctime_date; // 0x10
	private static readonly string[] formats; // 0x18

	// Methods

	// RVA: 0x21B4970 Offset: 0x21B3B70 VA: 0x1821B4970
	internal static DateTime Parse(string dateStr) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21B4A60 Offset: 0x21B3C60 VA: 0x1821B4A60
	private static void .cctor() { }
}

// Namespace: System.Net
internal class NetConfig : ICloneable // TypeDefIndex: 5970
{
	// Fields
	internal bool ipv6Enabled; // 0x10
	internal int MaxResponseHeadersLength; // 0x14

	// Methods

	// RVA: 0x21B4B90 Offset: 0x21B3D90 VA: 0x1821B4B90
	internal void .ctor() { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }
}

// Namespace: System.Net
internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 5971
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Properties
	public string AuthenticationType { get; }
	public bool CanPreAuthenticate { get; }

	// Methods

	// RVA: 0x21B4C80 Offset: 0x21B3E80 VA: 0x1821B4C80
	public void .ctor() { }

	// RVA: 0x21B4BA0 Offset: 0x21B3DA0 VA: 0x1821B4BA0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x21B4CE0 Offset: 0x21B3EE0 VA: 0x1821B4CE0 Slot: 7
	public string get_AuthenticationType() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	public bool get_CanPreAuthenticate() { }
}

// Namespace: System.Net
internal class RequestStream : Stream // TypeDefIndex: 5972
{
	// Fields
	private byte[] buffer; // 0x28
	private int offset; // 0x30
	private int length; // 0x34
	private long remaining_body; // 0x38
	private bool disposed; // 0x40
	private Stream stream; // 0x48

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x21B5810 Offset: 0x21B4A10 VA: 0x1821B5810
	internal void .ctor(Stream stream, byte[] buffer, int offset, int length) { }

	// RVA: 0x21B5780 Offset: 0x21B4980 VA: 0x1821B5780
	internal void .ctor(Stream stream, byte[] buffer, int offset, int length, long contentlength) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x21B58A0 Offset: 0x21B4AA0 VA: 0x1821B58A0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x21B58E0 Offset: 0x21B4AE0 VA: 0x1821B58E0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x21B5920 Offset: 0x21B4B20 VA: 0x1821B5920 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1C3D660 Offset: 0x1C3C860 VA: 0x181C3D660 Slot: 20
	public override void Close() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public override void Flush() { }

	// RVA: 0x21B5270 Offset: 0x21B4470 VA: 0x1821B5270
	private int FillFromBuffer(byte[] buffer, int off, int count) { }

	// RVA: 0x21B5590 Offset: 0x21B4790 VA: 0x1821B5590 Slot: 34
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x21B4D10 Offset: 0x21B3F10 VA: 0x1821B4D10 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state) { }

	// RVA: 0x21B4FA0 Offset: 0x21B41A0 VA: 0x1821B4FA0 Slot: 25
	public override int EndRead(IAsyncResult ares) { }

	// RVA: 0x21B56C0 Offset: 0x21B48C0 VA: 0x1821B56C0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21B5700 Offset: 0x21B4900 VA: 0x1821B5700 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x21B5740 Offset: 0x21B4940 VA: 0x1821B5740 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21B4F60 Offset: 0x21B4160 VA: 0x1821B4F60 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cback, object state) { }

	// RVA: 0x21B5230 Offset: 0x21B4430 VA: 0x1821B5230 Slot: 29
	public override void EndWrite(IAsyncResult async_result) { }
}

// Namespace: System.Net
internal class ResponseStream : Stream // TypeDefIndex: 5973
{
	// Fields
	private HttpListenerResponse response; // 0x28
	private bool ignore_errors; // 0x30
	private bool disposed; // 0x31
	private bool trailer_sent; // 0x32
	private Stream stream; // 0x38
	private static byte[] crlf; // 0x0

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x21B67C0 Offset: 0x21B59C0 VA: 0x1821B67C0
	internal void .ctor(Stream stream, HttpListenerResponse response, bool ignore_errors) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x21B6840 Offset: 0x21B5A40 VA: 0x1821B6840 Slot: 11
	public override long get_Length() { }

	// RVA: 0x21B6880 Offset: 0x21B5A80 VA: 0x1821B6880 Slot: 12
	public override long get_Position() { }

	// RVA: 0x21B68C0 Offset: 0x21B5AC0 VA: 0x1821B68C0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x21B5C20 Offset: 0x21B4E20 VA: 0x1821B5C20 Slot: 20
	public override void Close() { }

	// RVA: 0x21B6170 Offset: 0x21B5370 VA: 0x1821B6170
	private MemoryStream GetHeaders(bool closing) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public override void Flush() { }

	// RVA: 0x21B60A0 Offset: 0x21B52A0 VA: 0x1821B60A0
	private static byte[] GetChunkSizeBytes(int size, bool final) { }

	// RVA: 0x21B62C0 Offset: 0x21B54C0 VA: 0x1821B62C0
	internal void InternalWrite(byte[] buffer, int offset, int count) { }

	// RVA: 0x21B63F0 Offset: 0x21B55F0 VA: 0x1821B63F0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21B59A0 Offset: 0x21B4BA0 VA: 0x1821B59A0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cback, object state) { }

	// RVA: 0x21B5EA0 Offset: 0x21B50A0 VA: 0x1821B5EA0 Slot: 29
	public override void EndWrite(IAsyncResult ares) { }

	// RVA: 0x21B6330 Offset: 0x21B5530 VA: 0x1821B6330 Slot: 34
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x21B5960 Offset: 0x21B4B60 VA: 0x1821B5960 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state) { }

	// RVA: 0x21B5E60 Offset: 0x21B5060 VA: 0x1821B5E60 Slot: 25
	public override int EndRead(IAsyncResult ares) { }

	// RVA: 0x21B6370 Offset: 0x21B5570 VA: 0x1821B6370 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21B63B0 Offset: 0x21B55B0 VA: 0x1821B63B0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x21B6740 Offset: 0x21B5940 VA: 0x1821B6740
	private static void .cctor() { }
}

// Namespace: System.Net
public class ServicePoint // TypeDefIndex: 5974
{
	// Fields
	private readonly Uri uri; // 0x10
	private DateTime lastDnsResolve; // 0x18
	private Version protocolVersion; // 0x20
	private IPHostEntry host; // 0x28
	private bool usesProxy; // 0x30
	private bool sendContinue; // 0x31
	private bool useConnect; // 0x32
	private object hostE; // 0x38
	private bool useNagle; // 0x40
	private BindIPEndPoint endPointCallback; // 0x48
	private bool tcp_keepalive; // 0x50
	private int tcp_keepalive_time; // 0x54
	private int tcp_keepalive_interval; // 0x58
	private bool disposed; // 0x5C
	private int connectionLeaseTimeout; // 0x60
	private int receiveBufferSize; // 0x64
	[CompilerGenerated]
	private readonly ServicePointManager.SPKey <Key>k__BackingField; // 0x68
	[CompilerGenerated]
	private ServicePointScheduler <Scheduler>k__BackingField; // 0x70
	private int connectionLimit; // 0x78
	private int maxIdleTime; // 0x7C
	private object m_ServerCertificateOrBytes; // 0x80
	private object m_ClientCertificateOrBytes; // 0x88

	// Properties
	internal ServicePointManager.SPKey Key { get; }
	private ServicePointScheduler Scheduler { get; set; }
	public Uri Address { get; }
	public BindIPEndPoint BindIPEndPointDelegate { get; set; }
	public int ConnectionLeaseTimeout { get; set; }
	public int ConnectionLimit { get; set; }
	public string ConnectionName { get; }
	public int CurrentConnections { get; }
	public DateTime IdleSince { get; }
	public int MaxIdleTime { get; set; }
	public virtual Version ProtocolVersion { get; }
	public int ReceiveBufferSize { get; set; }
	public bool SupportsPipelining { get; }
	public bool Expect100Continue { get; set; }
	public bool UseNagleAlgorithm { get; set; }
	internal bool SendContinue { get; set; }
	internal bool UsesProxy { get; set; }
	internal bool UseConnect { get; set; }
	private bool HasTimedOut { get; }
	internal IPHostEntry HostEntry { get; }
	public X509Certificate Certificate { get; }
	public X509Certificate ClientCertificate { get; }

	// Methods

	// RVA: 0x21BA260 Offset: 0x21B9460 VA: 0x1821BA260
	internal void .ctor(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	[CompilerGenerated]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	internal ServicePointManager.SPKey get_Key() { }

	[CompilerGenerated]
	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	private ServicePointScheduler get_Scheduler() { }

	[CompilerGenerated]
	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	private void set_Scheduler(ServicePointScheduler value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Uri get_Address() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public BindIPEndPoint get_BindIPEndPointDelegate() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_BindIPEndPointDelegate(BindIPEndPoint value) { }

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public int get_ConnectionLeaseTimeout() { }

	// RVA: 0x21BAF50 Offset: 0x21BA150 VA: 0x1821BAF50
	public void set_ConnectionLeaseTimeout(int value) { }

	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990
	public int get_ConnectionLimit() { }

	// RVA: 0x21BAFC0 Offset: 0x21BA1C0 VA: 0x1821BAFC0
	public void set_ConnectionLimit(int value) { }

	// RVA: 0x21BA7D0 Offset: 0x21B99D0 VA: 0x1821BA7D0
	public string get_ConnectionName() { }

	// RVA: 0x21BA7F0 Offset: 0x21B99F0 VA: 0x1821BA7F0
	public int get_CurrentConnections() { }

	// RVA: 0x21BADA0 Offset: 0x21B9FA0 VA: 0x1821BADA0
	public DateTime get_IdleSince() { }

	// RVA: 0x1C44BB0 Offset: 0x1C43DB0 VA: 0x181C44BB0
	public int get_MaxIdleTime() { }

	// RVA: 0x21BB050 Offset: 0x21BA250 VA: 0x1821BB050
	public void set_MaxIdleTime(int value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 4
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x6772F0 Offset: 0x6764F0 VA: 0x1806772F0
	public int get_ReceiveBufferSize() { }

	// RVA: 0x21BB0D0 Offset: 0x21BA2D0 VA: 0x1821BB0D0
	public void set_ReceiveBufferSize(int value) { }

	// RVA: 0x21BAED0 Offset: 0x21BA0D0 VA: 0x1821BAED0
	public bool get_SupportsPipelining() { }

	// RVA: 0x21BA820 Offset: 0x21B9A20 VA: 0x1821BA820
	public bool get_Expect100Continue() { }

	// RVA: 0x21BB040 Offset: 0x21BA240 VA: 0x1821BB040
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x445700 Offset: 0x444900 VA: 0x180445700
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x21BAE40 Offset: 0x21BA040 VA: 0x1821BAE40
	internal bool get_SendContinue() { }

	// RVA: 0x21BB040 Offset: 0x21BA240 VA: 0x1821BB040
	internal void set_SendContinue(bool value) { }

	// RVA: 0x21BA0A0 Offset: 0x21B92A0 VA: 0x1821BA0A0
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x21B9DA0 Offset: 0x21B8FA0 VA: 0x1821B9DA0
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x21B9EF0 Offset: 0x21B90F0 VA: 0x1821B9EF0
	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	internal bool get_UsesProxy() { }

	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x21BAF40 Offset: 0x21BA140 VA: 0x1821BAF40
	internal bool get_UseConnect() { }

	// RVA: 0x21BB140 Offset: 0x21BA340 VA: 0x1821BB140
	internal void set_UseConnect(bool value) { }

	// RVA: 0x21BA830 Offset: 0x21B9A30 VA: 0x1821BA830
	private bool get_HasTimedOut() { }

	// RVA: 0x21BA950 Offset: 0x21B9B50 VA: 0x1821BA950
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void SetVersion(Version version) { }

	// RVA: 0x21B9F60 Offset: 0x21B9160 VA: 0x1821B9F60
	internal void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x21B9BC0 Offset: 0x21B8DC0 VA: 0x1821B9BC0
	public bool CloseConnectionGroup(string connectionGroupName) { }

	// RVA: 0x21B9D90 Offset: 0x21B8F90 VA: 0x1821B9D90
	internal void FreeServicePoint() { }

	// RVA: 0x21BA490 Offset: 0x21B9690 VA: 0x1821BA490
	public X509Certificate get_Certificate() { }

	// RVA: 0x21BA1E0 Offset: 0x21B93E0 VA: 0x1821BA1E0
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x21BA630 Offset: 0x21B9830 VA: 0x1821BA630
	public X509Certificate get_ClientCertificate() { }

	// RVA: 0x21BA190 Offset: 0x21B9390 VA: 0x1821BA190
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x21B9AE0 Offset: 0x21B8CE0 VA: 0x1821B9AE0
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	// RVA: 0x21BA230 Offset: 0x21B9430 VA: 0x1821BA230
	internal void .ctor() { }
}

// Namespace: 
internal class ServicePointManager.SPKey // TypeDefIndex: 5975
{
	// Fields
	private Uri uri; // 0x10
	private Uri proxy; // 0x18
	private bool use_connect; // 0x20

	// Properties
	public Uri Uri { get; }
	public bool UseConnect { get; }
	public bool UsesProxy { get; }

	// Methods

	// RVA: 0x15A45E0 Offset: 0x15A37E0 VA: 0x1815A45E0
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Uri get_Uri() { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_UseConnect() { }

	// RVA: 0x21B6B10 Offset: 0x21B5D10 VA: 0x1821B6B10
	public bool get_UsesProxy() { }

	// RVA: 0x21B6A30 Offset: 0x21B5C30 VA: 0x1821B6A30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21B6900 Offset: 0x21B5B00 VA: 0x1821B6900 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: System.Net
public class ServicePointManager // TypeDefIndex: 5976
{
	// Fields
	private static ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint> servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static int defaultConnectionLimit; // 0x10
	private static int maxServicePointIdleTime; // 0x14
	private static int maxServicePoints; // 0x18
	private static int dnsRefreshTimeout; // 0x1C
	private static bool _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static bool expectContinue; // 0x28
	private static bool useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static bool tcp_keepalive; // 0x38
	private static int tcp_keepalive_time; // 0x3C
	private static int tcp_keepalive_interval; // 0x40
	public const int DefaultNonPersistentConnectionLimit = 4;
	public const int DefaultPersistentConnectionLimit = 10;
	[CompilerGenerated]
	private static CipherSuitesCallback <ClientCipherSuitesCallback>k__BackingField; // 0x48
	[CompilerGenerated]
	private static CipherSuitesCallback <ServerCipherSuitesCallback>k__BackingField; // 0x50

	// Properties
	[Obsolete("Use ServerCertificateValidationCallback instead", False)]
	public static ICertificatePolicy CertificatePolicy { get; set; }
	[MonoTODO("CRL checks not implemented")]
	public static bool CheckCertificateRevocationList { get; set; }
	public static int DefaultConnectionLimit { get; set; }
	public static int DnsRefreshTimeout { get; set; }
	[MonoTODO]
	public static bool EnableDnsRoundRobin { get; set; }
	public static int MaxServicePointIdleTime { get; set; }
	public static int MaxServicePoints { get; set; }
	[MonoTODO]
	public static bool ReusePort { get; set; }
	public static SecurityProtocolType SecurityProtocol { get; set; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; set; }
	[MonoTODO("Always returns EncryptionPolicy.RequireEncryption.")]
	public static EncryptionPolicy EncryptionPolicy { get; }
	public static bool Expect100Continue { get; set; }
	public static bool UseNagleAlgorithm { get; set; }
	internal static bool DisableStrongCrypto { get; }
	internal static bool DisableSendAuxRecord { get; }
	[Obsolete("This API is no longer supported.", True)]
	public static CipherSuitesCallback ClientCipherSuitesCallback { get; set; }
	[Obsolete("This API is no longer supported.", True)]
	public static CipherSuitesCallback ServerCipherSuitesCallback { get; set; }

	// Methods

	// RVA: 0x21B7960 Offset: 0x21B6B60 VA: 0x1821B7960
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x21B7A60 Offset: 0x21B6C60 VA: 0x1821B7A60
	public static ICertificatePolicy get_CertificatePolicy() { }

	// RVA: 0x21B7F80 Offset: 0x21B7180 VA: 0x1821B7F80
	public static void set_CertificatePolicy(ICertificatePolicy value) { }

	// RVA: 0x21B76D0 Offset: 0x21B68D0 VA: 0x1821B76D0
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x21B7B40 Offset: 0x21B6D40 VA: 0x1821B7B40
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x21B7FE0 Offset: 0x21B71E0 VA: 0x1821B7FE0
	public static void set_CheckCertificateRevocationList(bool value) { }

	// RVA: 0x21B7BE0 Offset: 0x21B6DE0 VA: 0x1821B7BE0
	public static int get_DefaultConnectionLimit() { }

	// RVA: 0x21B8090 Offset: 0x21B7290 VA: 0x1821B8090
	public static void set_DefaultConnectionLimit(int value) { }

	// RVA: 0x21B7720 Offset: 0x21B6920 VA: 0x1821B7720
	private static Exception GetMustImplement() { }

	// RVA: 0x21B7C30 Offset: 0x21B6E30 VA: 0x1821B7C30
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x21B8130 Offset: 0x21B7330 VA: 0x1821B8130
	public static void set_DnsRefreshTimeout(int value) { }

	// RVA: 0x21B7C80 Offset: 0x21B6E80 VA: 0x1821B7C80
	public static bool get_EnableDnsRoundRobin() { }

	// RVA: 0x21B81D0 Offset: 0x21B73D0 VA: 0x1821B81D0
	public static void set_EnableDnsRoundRobin(bool value) { }

	// RVA: 0x21B7D10 Offset: 0x21B6F10 VA: 0x1821B7D10
	public static int get_MaxServicePointIdleTime() { }

	// RVA: 0x21B8270 Offset: 0x21B7470 VA: 0x1821B8270
	public static void set_MaxServicePointIdleTime(int value) { }

	// RVA: 0x21B7D60 Offset: 0x21B6F60 VA: 0x1821B7D60
	public static int get_MaxServicePoints() { }

	// RVA: 0x21B8320 Offset: 0x21B7520 VA: 0x1821B8320
	public static void set_MaxServicePoints(int value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public static bool get_ReusePort() { }

	// RVA: 0x21B83C0 Offset: 0x21B75C0 VA: 0x1821B83C0
	public static void set_ReusePort(bool value) { }

	// RVA: 0x21B7DB0 Offset: 0x21B6FB0 VA: 0x1821B7DB0
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x21B8400 Offset: 0x21B7600 VA: 0x1821B8400
	public static void set_SecurityProtocol(SecurityProtocolType value) { }

	// RVA: 0x21B7E00 Offset: 0x21B7000 VA: 0x1821B7E00
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x21B7E50 Offset: 0x21B7050 VA: 0x1821B7E50
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x21B8460 Offset: 0x21B7660 VA: 0x1821B8460
	public static void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static EncryptionPolicy get_EncryptionPolicy() { }

	// RVA: 0x21B7CC0 Offset: 0x21B6EC0 VA: 0x1821B7CC0
	public static bool get_Expect100Continue() { }

	// RVA: 0x21B8210 Offset: 0x21B7410 VA: 0x1821B8210
	public static void set_Expect100Continue(bool value) { }

	// RVA: 0x21B7F30 Offset: 0x21B7130 VA: 0x1821B7F30
	public static bool get_UseNagleAlgorithm() { }

	// RVA: 0x21B8590 Offset: 0x21B7790 VA: 0x1821B8590
	public static void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool get_DisableStrongCrypto() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool get_DisableSendAuxRecord() { }

	// RVA: 0x21B7800 Offset: 0x21B6A00 VA: 0x1821B7800
	public static void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x21B75F0 Offset: 0x21B67F0 VA: 0x1821B75F0
	public static ServicePoint FindServicePoint(Uri address) { }

	// RVA: 0x21B7640 Offset: 0x21B6840 VA: 0x1821B7640
	public static ServicePoint FindServicePoint(string uriString, IWebProxy proxy) { }

	// RVA: 0x21B6E30 Offset: 0x21B6030 VA: 0x1821B6E30
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0x21B6B60 Offset: 0x21B5D60 VA: 0x1821B6B60
	internal static void CloseConnectionGroup(string connectionGroupName) { }

	// RVA: 0x21B7770 Offset: 0x21B6970 VA: 0x1821B7770
	internal static void RemoveServicePoint(ServicePoint sp) { }

	[CompilerGenerated]
	// RVA: 0x21B7B90 Offset: 0x21B6D90 VA: 0x1821B7B90
	public static CipherSuitesCallback get_ClientCipherSuitesCallback() { }

	[CompilerGenerated]
	// RVA: 0x21B8030 Offset: 0x21B7230 VA: 0x1821B8030
	public static void set_ClientCipherSuitesCallback(CipherSuitesCallback value) { }

	[CompilerGenerated]
	// RVA: 0x21B7EE0 Offset: 0x21B70E0 VA: 0x1821B7EE0
	public static CipherSuitesCallback get_ServerCipherSuitesCallback() { }

	[CompilerGenerated]
	// RVA: 0x21B8530 Offset: 0x21B7730 VA: 0x1821B8530
	public static void set_ServerCipherSuitesCallback(CipherSuitesCallback value) { }
}

// Namespace: System.Net
[Obsolete("This API is no longer supported.")]
public sealed class CipherSuitesCallback : MulticastDelegate // TypeDefIndex: 5977
{
	// Methods

	// RVA: 0x1205FC0 Offset: 0x12051C0 VA: 0x181205FC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual IEnumerable<string> Invoke(SecurityProtocolType protocol, IEnumerable<string> allCiphers) { }

	// RVA: 0x21A6D40 Offset: 0x21A5F40 VA: 0x1821A6D40 Slot: 14
	public virtual IAsyncResult BeginInvoke(SecurityProtocolType protocol, IEnumerable<string> allCiphers, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual IEnumerable<string> EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class ServicePointScheduler.ConnectionGroup // TypeDefIndex: 5978
{
	// Fields
	[CompilerGenerated]
	private readonly ServicePointScheduler <Scheduler>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	private static int nextId; // 0x0
	public readonly int ID; // 0x20
	private LinkedList<WebConnection> connections; // 0x28
	private LinkedList<WebOperation> queue; // 0x30

	// Properties
	public ServicePointScheduler Scheduler { get; }
	public string Name { get; }
	public bool IsDefault { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ServicePointScheduler get_Scheduler() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Name() { }

	// RVA: 0x21A79D0 Offset: 0x21A6BD0 VA: 0x1821A79D0
	public bool get_IsDefault() { }

	// RVA: 0x21A78E0 Offset: 0x21A6AE0 VA: 0x1821A78E0
	public void .ctor(ServicePointScheduler scheduler, string name) { }

	// RVA: 0x21A77E0 Offset: 0x21A69E0 VA: 0x1821A77E0
	public bool IsEmpty() { }

	// RVA: 0x21A7850 Offset: 0x21A6A50 VA: 0x1821A7850
	public void RemoveConnection(WebConnection connection) { }

	// RVA: 0x21A6DD0 Offset: 0x21A5FD0 VA: 0x1821A6DD0
	public void Cleanup() { }

	// RVA: 0x21A6ED0 Offset: 0x21A60D0 VA: 0x1821A6ED0
	public void Close() { }

	// RVA: 0x21A73A0 Offset: 0x21A65A0 VA: 0x1821A73A0
	public void EnqueueOperation(WebOperation operation) { }

	// RVA: 0x21A76F0 Offset: 0x21A68F0 VA: 0x1821A76F0
	public WebOperation GetNextOperation() { }

	// RVA: 0x21A7400 Offset: 0x21A6600 VA: 0x1821A7400
	public WebConnection FindIdleConnection(WebOperation operation) { }

	// RVA: 0x21A71D0 Offset: 0x21A63D0 VA: 0x1821A71D0
	public ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ServicePointScheduler.AsyncManualResetEvent.<>c // TypeDefIndex: 5979
{
	// Fields
	public static readonly ServicePointScheduler.AsyncManualResetEvent.<>c <>9; // 0x0
	public static Func<object, bool> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x21CB2B0 Offset: 0x21CA4B0 VA: 0x1821CB2B0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21CB030 Offset: 0x21CA230 VA: 0x1821CB030
	internal bool <Set>b__4_0(object s) { }
}

// Namespace: 
private class ServicePointScheduler.AsyncManualResetEvent // TypeDefIndex: 5980
{
	// Fields
	private TaskCompletionSource<bool> m_tcs; // 0x10

	// Methods

	// RVA: 0x21BDB40 Offset: 0x21BCD40 VA: 0x1821BDB40
	public Task WaitAsync() { }

	// RVA: 0x21BDB90 Offset: 0x21BCD90 VA: 0x1821BDB90
	public bool WaitOne(int millisecondTimeout) { }

	// RVA: 0x21BDAE0 Offset: 0x21BCCE0 VA: 0x1821BDAE0
	public Task<bool> WaitAsync(int millisecondTimeout) { }

	// RVA: 0x21BD8A0 Offset: 0x21BCAA0 VA: 0x1821BD8A0
	public void Set() { }

	// RVA: 0x21BD7E0 Offset: 0x21BC9E0 VA: 0x1821BD7E0
	public void Reset() { }

	// RVA: 0x21BDBF0 Offset: 0x21BCDF0 VA: 0x1821BDBF0
	public void .ctor(bool state) { }
}

// Namespace: 
[CompilerGenerated]
private struct ServicePointScheduler.<RunScheduler>d__32 : IAsyncStateMachine // TypeDefIndex: 5981
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ServicePointScheduler <>4__this; // 0x20
	private ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>[] <operationArray>5__2; // 0x28
	private ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>[] <idleArray>5__3; // 0x30
	private List<Task> <taskList>5__4; // 0x38
	private Task<bool> <schedulerTask>5__5; // 0x40
	private bool <finalCleanup>5__6; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50

	// Methods

	// RVA: 0x21C9350 Offset: 0x21C8550 VA: 0x1821C9350 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C9EA0 Offset: 0x21C90A0 VA: 0x1821C9EA0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ServicePointScheduler.<WaitAsync>d__46 : IAsyncStateMachine // TypeDefIndex: 5982
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public int millisecondTimeout; // 0x20
	public Task workerTask; // 0x28
	private CancellationTokenSource <cts>5__2; // 0x30
	private Task <timeoutTask>5__3; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x40

	// Methods

	// RVA: 0x21CB310 Offset: 0x21CA510 VA: 0x1821CB310 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21CB7D0 Offset: 0x21CA9D0 VA: 0x1821CB7D0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class ServicePointScheduler // TypeDefIndex: 5983
{
	// Fields
	[CompilerGenerated]
	private ServicePoint <ServicePoint>k__BackingField; // 0x10
	private int running; // 0x18
	private int maxIdleTime; // 0x1C
	private ServicePointScheduler.AsyncManualResetEvent schedulerEvent; // 0x20
	private ServicePointScheduler.ConnectionGroup defaultGroup; // 0x28
	private Dictionary<string, ServicePointScheduler.ConnectionGroup> groups; // 0x30
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations; // 0x38
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections; // 0x40
	private int currentConnections; // 0x48
	private int connectionLimit; // 0x4C
	private DateTime idleSince; // 0x50
	private static int nextId; // 0x0
	public readonly int ID; // 0x58
	[CompilerGenerated]
	private readonly string <ME>k__BackingField; // 0x60

	// Properties
	private ServicePoint ServicePoint { get; set; }
	public int MaxIdleTime { get; set; }
	public int ConnectionLimit { get; set; }
	public int CurrentConnections { get; }
	public DateTime IdleSince { get; }
	internal string ME { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	private ServicePoint get_ServicePoint() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_MaxIdleTime() { }

	// RVA: 0x21B9A70 Offset: 0x21B8C70 VA: 0x1821B9A70
	public void set_MaxIdleTime(int value) { }

	// RVA: 0x547AA0 Offset: 0x546CA0 VA: 0x180547AA0
	public int get_ConnectionLimit() { }

	// RVA: 0x21B9A00 Offset: 0x21B8C00 VA: 0x1821B9A00
	public void set_ConnectionLimit(int value) { }

	// RVA: 0x21B9860 Offset: 0x21B8A60 VA: 0x1821B9860
	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	[Conditional("MONO_WEB_DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Debug(string message) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public int get_CurrentConnections() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public DateTime get_IdleSince() { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal string get_ME() { }

	// RVA: 0x21B93B0 Offset: 0x21B85B0 VA: 0x1821B93B0
	public void Run() { }

	[AsyncStateMachine(typeof(ServicePointScheduler.<RunScheduler>d__32))]
	// RVA: 0x21B92E0 Offset: 0x21B84E0 VA: 0x1821B92E0
	private Task RunScheduler() { }

	// RVA: 0x21B85F0 Offset: 0x21B77F0 VA: 0x1821B85F0
	private void Cleanup() { }

	// RVA: 0x21B9130 Offset: 0x21B8330 VA: 0x1821B9130
	private void RunSchedulerIteration() { }

	// RVA: 0x21B8CA0 Offset: 0x21B7EA0 VA: 0x1821B8CA0
	private bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation) { }

	// RVA: 0x21B88C0 Offset: 0x21B7AC0 VA: 0x1821B88C0
	private void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x21B9480 Offset: 0x21B8680 VA: 0x1821B9480
	private bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group) { }

	// RVA: 0x21B9060 Offset: 0x21B8260 VA: 0x1821B9060
	private void RemoveOperation(WebOperation operation) { }

	// RVA: 0x21B8F90 Offset: 0x21B8190 VA: 0x1821B8F90
	private void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x21B8970 Offset: 0x21B7B70 VA: 0x1821B8970
	private void FinalCleanup() { }

	// RVA: 0x21B9660 Offset: 0x21B8860 VA: 0x1821B9660
	public void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x21B87B0 Offset: 0x21B79B0 VA: 0x1821B87B0
	public bool CloseConnectionGroup(string groupName) { }

	// RVA: 0x21B8A70 Offset: 0x21B7C70 VA: 0x1821B8A70
	private ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x21B8C90 Offset: 0x21B7E90 VA: 0x1821B8C90
	private void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x21B8C60 Offset: 0x21B7E60 VA: 0x1821B8C60
	private void OnConnectionClosed(WebConnection connection) { }

	[AsyncStateMachine(typeof(ServicePointScheduler.<WaitAsync>d__46))]
	// RVA: 0x21B9760 Offset: 0x21B8960 VA: 0x1821B9760
	public static Task<bool> WaitAsync(Task workerTask, int millisecondTimeout) { }

	[CompilerGenerated]
	// RVA: 0x21B92E0 Offset: 0x21B84E0 VA: 0x1821B92E0
	private Task <Run>b__31_0() { }
}

// Namespace: System.Net
[Serializable]
public sealed class SocketPermission : CodeAccessPermission, IUnrestrictedPermission // TypeDefIndex: 5984
{
	// Fields
	private ArrayList m_acceptList; // 0x10
	private ArrayList m_connectList; // 0x18
	private bool m_noRestriction; // 0x20
	public const int AllPorts = -1;

	// Properties
	public IEnumerator AcceptList { get; }
	public IEnumerator ConnectList { get; }

	// Methods

	// RVA: 0x21C2CC0 Offset: 0x21C1EC0 VA: 0x1821C2CC0
	public void .ctor(PermissionState state) { }

	// RVA: 0x21C2D50 Offset: 0x21C1F50 VA: 0x1821C2D50
	public void .ctor(NetworkAccess access, TransportType transport, string hostName, int portNumber) { }

	// RVA: 0x154B250 Offset: 0x154A450 VA: 0x18154B250
	public IEnumerator get_AcceptList() { }

	// RVA: 0x15D5810 Offset: 0x15D4A10 VA: 0x1815D5810
	public IEnumerator get_ConnectList() { }

	// RVA: 0x21C1080 Offset: 0x21C0280 VA: 0x1821C1080
	public void AddPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber) { }

	// RVA: 0x21C1150 Offset: 0x21C0350 VA: 0x1821C1150 Slot: 7
	public override IPermission Copy() { }

	// RVA: 0x21C1AD0 Offset: 0x21C0CD0 VA: 0x1821C1AD0 Slot: 10
	public override IPermission Intersect(IPermission target) { }

	// RVA: 0x21C1A60 Offset: 0x21C0C60 VA: 0x1821C1A60
	private bool IntersectEmpty(SocketPermission permission) { }

	// RVA: 0x21C1CA0 Offset: 0x21C0EA0 VA: 0x1821C1CA0
	private void Intersect(ArrayList list1, ArrayList list2, ArrayList result) { }

	// RVA: 0x21C2050 Offset: 0x21C1250 VA: 0x1821C2050 Slot: 11
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x21C2260 Offset: 0x21C1460 VA: 0x1821C2260
	private bool IsSubsetOf(ArrayList list1, ArrayList list2) { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0 Slot: 14
	public bool IsUnrestricted() { }

	// RVA: 0x21C2560 Offset: 0x21C1760 VA: 0x1821C2560 Slot: 12
	public override SecurityElement ToXml() { }

	// RVA: 0x21C2770 Offset: 0x21C1970 VA: 0x1821C2770
	private void ToXml(SecurityElement root, string childName, IEnumerator enumerator) { }

	// RVA: 0x21C1370 Offset: 0x21C0570 VA: 0x1821C1370 Slot: 9
	public override void FromXml(SecurityElement securityElement) { }

	// RVA: 0x21C16C0 Offset: 0x21C08C0 VA: 0x1821C16C0
	private void FromXml(ArrayList endpoints, NetworkAccess access) { }

	// RVA: 0x21C2AA0 Offset: 0x21C1CA0 VA: 0x1821C2AA0 Slot: 13
	public override IPermission Union(IPermission target) { }
}

// Namespace: System.Net
[Usage(109, AllowMultiple = True, Inherited = False)]
[Serializable]
public sealed class SocketPermissionAttribute : CodeAccessSecurityAttribute // TypeDefIndex: 5985
{
	// Fields
	private string m_access; // 0x18
	private string m_host; // 0x20
	private string m_port; // 0x28
	private string m_transport; // 0x30

	// Properties
	public string Access { get; set; }
	public string Host { get; set; }
	public string Port { get; set; }
	public string Transport { get; set; }

	// Methods

	// RVA: 0x216DCF0 Offset: 0x216CEF0 VA: 0x18216DCF0
	public void .ctor(SecurityAction action) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Access() { }

	// RVA: 0x21C0F00 Offset: 0x21C0100 VA: 0x1821C0F00
	public void set_Access(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Host() { }

	// RVA: 0x21C0F60 Offset: 0x21C0160 VA: 0x1821C0F60
	public void set_Host(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Port() { }

	// RVA: 0x21C0FC0 Offset: 0x21C01C0 VA: 0x1821C0FC0
	public void set_Port(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Transport() { }

	// RVA: 0x21C1020 Offset: 0x21C0220 VA: 0x1821C1020
	public void set_Transport(string value) { }

	// RVA: 0x21C0940 Offset: 0x21BFB40 VA: 0x1821C0940 Slot: 7
	public override IPermission CreatePermission() { }

	// RVA: 0x21C08C0 Offset: 0x21BFAC0 VA: 0x1821C08C0
	internal void AlreadySet(string property) { }
}

// Namespace: 
internal enum WebCompletionSource.Status<T> // TypeDefIndex: 5986
{
	// Fields
	public int value__; // 0x0
	public const WebCompletionSource.Status<T> Running = 0;
	public const WebCompletionSource.Status<T> Completed = 1;
	public const WebCompletionSource.Status<T> Canceled = 2;
	public const WebCompletionSource.Status<T> Faulted = 3;
}

// Namespace: 
internal class WebCompletionSource.Result<T> // TypeDefIndex: 5987
{
	// Fields
	[CompilerGenerated]
	private readonly WebCompletionSource.Status<T> <Status>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ExceptionDispatchInfo <Error>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly T <Argument>k__BackingField; // 0x0

	// Properties
	public WebCompletionSource.Status<T> Status { get; }
	public bool Success { get; }
	public ExceptionDispatchInfo Error { get; }
	public T Argument { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public WebCompletionSource.Status<T> get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-WebCompletionSource.Result<ValueTuple<bool, object>>.get_Status
	|-WebCompletionSource.Result<object>.get_Status
	|
	|-RVA: 0xBE50C0 Offset: 0xBE42C0 VA: 0x180BE50C0
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>.get_Status
	*/

	// RVA: -1 Offset: -1
	public bool get_Success() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE5120 Offset: 0xBE4320 VA: 0x180BE5120
	|-WebCompletionSource.Result<ValueTuple<bool, object>>.get_Success
	|-WebCompletionSource.Result<object>.get_Success
	|
	|-RVA: 0xBE50F0 Offset: 0xBE42F0 VA: 0x180BE50F0
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>.get_Success
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public ExceptionDispatchInfo get_Error() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-WebCompletionSource.Result<ValueTuple<bool, object>>.get_Error
	|-WebCompletionSource.Result<object>.get_Error
	|
	|-RVA: 0xBE5090 Offset: 0xBE4290 VA: 0x180BE5090
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>.get_Error
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_Argument() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x416920 Offset: 0x415B20 VA: 0x180416920
	|-WebCompletionSource.Result<ValueTuple<bool, object>>.get_Argument
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-WebCompletionSource.Result<object>.get_Argument
	|
	|-RVA: 0xB18440 Offset: 0xB17640 VA: 0x180B18440
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>.get_Argument
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4E80 Offset: 0xBE4080 VA: 0x180BE4E80
	|-WebCompletionSource.Result<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0xBE5060 Offset: 0xBE4260 VA: 0x180BE5060
	|-WebCompletionSource.Result<object>..ctor
	|
	|-RVA: 0xBE4F60 Offset: 0xBE4160 VA: 0x180BE4F60
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(WebCompletionSource.Status<T> state, ExceptionDispatchInfo error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B8500 Offset: 0x7B7700 VA: 0x1807B8500
	|-WebCompletionSource.Result<ValueTuple<bool, object>>..ctor
	|-WebCompletionSource.Result<object>..ctor
	|
	|-RVA: 0xBE4EB0 Offset: 0xBE40B0 VA: 0x180BE4EB0
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private struct WebCompletionSource.<WaitForCompletion>d__15<T> : IAsyncStateMachine // TypeDefIndex: 5988
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	public WebCompletionSource<T> <>4__this; // 0x0
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebCompletionSource.Result<T>> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF53E20 Offset: 0xF53020 VA: 0x180F53E20
	|-WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>.MoveNext
	|
	|-RVA: 0xF541D0 Offset: 0xF533D0 VA: 0x180F541D0
	|-WebCompletionSource.<WaitForCompletion>d__15<object>.MoveNext
	|
	|-RVA: 0xF53790 Offset: 0xF52990 VA: 0x180F53790
	|-WebCompletionSource.<WaitForCompletion>d__15<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF54630 Offset: 0xF53830 VA: 0x180F54630
	|-WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>.SetStateMachine
	|-WebCompletionSource.<WaitForCompletion>d__15<object>.SetStateMachine
	|
	|-RVA: 0xF54560 Offset: 0xF53760 VA: 0x180F54560
	|-WebCompletionSource.<WaitForCompletion>d__15<__Il2CppFullySharedGenericType>.SetStateMachine
	*/
}

// Namespace: System.Net
internal class WebCompletionSource<T> // TypeDefIndex: 5989
{
	// Fields
	private TaskCompletionSource<WebCompletionSource.Result<T>> completion; // 0x0
	private WebCompletionSource.Result<T> currentResult; // 0x0

	// Properties
	internal WebCompletionSource.Result<T> CurrentResult { get; }
	internal WebCompletionSource.Status<T> CurrentStatus { get; }
	internal Task Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(bool runAsync = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3B950 Offset: 0xE3AB50 VA: 0x180E3B950
	|-WebCompletionSource<ValueTuple<bool, object>>..ctor
	|-WebCompletionSource<object>..ctor
	|
	|-RVA: 0xE3B9E0 Offset: 0xE3ABE0 VA: 0x180E3B9E0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal WebCompletionSource.Result<T> get_CurrentResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-WebCompletionSource<ValueTuple<bool, object>>.get_CurrentResult
	|-WebCompletionSource<object>.get_CurrentResult
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.get_CurrentResult
	*/

	// RVA: -1 Offset: -1
	internal WebCompletionSource.Status<T> get_CurrentStatus() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3BAA0 Offset: 0xE3ACA0 VA: 0x180E3BAA0
	|-WebCompletionSource<ValueTuple<bool, object>>.get_CurrentStatus
	|-WebCompletionSource<object>.get_CurrentStatus
	|
	|-RVA: 0xE3BA70 Offset: 0xE3AC70 VA: 0x180E3BA70
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.get_CurrentStatus
	*/

	// RVA: -1 Offset: -1
	internal Task get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	|-WebCompletionSource<ValueTuple<bool, object>>.get_Task
	|-WebCompletionSource<object>.get_Task
	|
	|-RVA: 0xE3BAD0 Offset: 0xE3ACD0 VA: 0x180E3BAD0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCompleted(T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3B460 Offset: 0xE3A660 VA: 0x180E3B460
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCompleted
	|
	|-RVA: 0xE3B090 Offset: 0xE3A290 VA: 0x180E3B090
	|-WebCompletionSource<object>.TrySetCompleted
	|
	|-RVA: 0xE3B2F0 Offset: 0xE3A4F0 VA: 0x180E3B2F0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3B150 Offset: 0xE3A350 VA: 0x180E3B150
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCompleted
	|-WebCompletionSource<object>.TrySetCompleted
	|
	|-RVA: 0xE3B210 Offset: 0xE3A410 VA: 0x180E3B210
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3AF80 Offset: 0xE3A180 VA: 0x180E3AF80
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0xE3ADF0 Offset: 0xE39FF0 VA: 0x180E3ADF0
	|-WebCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0xE3AF00 Offset: 0xE3A100 VA: 0x180E3AF00
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(OperationCanceledException error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3AD20 Offset: 0xE39F20 VA: 0x180E3AD20
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|-WebCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0xE3AC40 Offset: 0xE39E40 VA: 0x180E3AC40
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetException(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3B600 Offset: 0xE3A800 VA: 0x180E3B600
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetException
	|-WebCompletionSource<object>.TrySetException
	|
	|-RVA: 0xE3B520 Offset: 0xE3A720 VA: 0x180E3B520
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetException
	*/

	// RVA: -1 Offset: -1
	public void ThrowOnError() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3AAD0 Offset: 0xE39CD0 VA: 0x180E3AAD0
	|-WebCompletionSource<ValueTuple<bool, object>>.ThrowOnError
	|-WebCompletionSource<object>.ThrowOnError
	|
	|-RVA: 0xE3AB50 Offset: 0xE39D50 VA: 0x180E3AB50
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.ThrowOnError
	*/

	[AsyncStateMachine(typeof(WebCompletionSource.<WaitForCompletion>d__15<T>))]
	// RVA: -1 Offset: -1
	public Task<T> WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3B7B0 Offset: 0xE3A9B0 VA: 0x180E3B7B0
	|-WebCompletionSource<ValueTuple<bool, object>>.WaitForCompletion
	|
	|-RVA: 0xE3B880 Offset: 0xE3AA80 VA: 0x180E3B880
	|-WebCompletionSource<object>.WaitForCompletion
	|
	|-RVA: 0xE3B6D0 Offset: 0xE3A8D0 VA: 0x180E3B6D0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/
}

// Namespace: System.Net
internal class WebCompletionSource : WebCompletionSource<object> // TypeDefIndex: 5990
{
	// Methods

	// RVA: 0x21CCEE0 Offset: 0x21CC0E0 VA: 0x1821CCEE0
	public void .ctor() { }
}

// Namespace: System.Net
internal enum ReadState // TypeDefIndex: 5991
{
	// Fields
	public int value__; // 0x0
	public const ReadState None = 0;
	public const ReadState Status = 1;
	public const ReadState Headers = 2;
	public const ReadState Content = 3;
	public const ReadState Aborted = 4;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class WebConnection.<>c // TypeDefIndex: 5992
{
	// Fields
	public static readonly WebConnection.<>c <>9; // 0x0
	public static Func<IPEndPoint, AsyncCallback, object, IAsyncResult> <>9__16_0; // 0x8
	public static Action<IAsyncResult> <>9__16_1; // 0x10

	// Methods

	// RVA: 0x21CB250 Offset: 0x21CA450 VA: 0x1821CB250
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21CAE30 Offset: 0x21CA030 VA: 0x1821CAE30
	internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state) { }

	// RVA: 0x21CAF30 Offset: 0x21CA130 VA: 0x1821CAF30
	internal void <Connect>b__16_1(IAsyncResult asyncResult) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebConnection.<Connect>d__16 : IAsyncStateMachine // TypeDefIndex: 5993
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebConnection <>4__this; // 0x20
	public WebOperation operation; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private Exception <connectException>5__2; // 0x38
	private IPAddress[] <>7__wrap2; // 0x40
	private int <>7__wrap3; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0x21C2E10 Offset: 0x21C2010 VA: 0x1821C2E10 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C35C0 Offset: 0x21C27C0 VA: 0x1821C35C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebConnection.<CreateStream>d__18 : IAsyncStateMachine // TypeDefIndex: 5994
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public WebConnection <>4__this; // 0x20
	public WebOperation operation; // 0x28
	public bool reused; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private NetworkStream <stream>5__2; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__2; // 0x58

	// Methods

	// RVA: 0x21C3620 Offset: 0x21C2820 VA: 0x1821C3620 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C3D40 Offset: 0x21C2F40 VA: 0x1821C3D40 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebConnection.<InitConnection>d__19 : IAsyncStateMachine // TypeDefIndex: 5995
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<WebRequestStream> <>t__builder; // 0x8
	public WebOperation operation; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public WebConnection <>4__this; // 0x30
	private bool <reused>5__2; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2; // 0x50

	// Methods

	// RVA: 0x21C4390 Offset: 0x21C3590 VA: 0x1821C4390 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C4B50 Offset: 0x21C3D50 VA: 0x1821C4B50 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class WebConnection : IDisposable // TypeDefIndex: 5996
{
	// Fields
	private NetworkCredential ntlm_credentials; // 0x10
	private bool ntlm_authenticated; // 0x18
	private bool unsafe_sharing; // 0x19
	private Stream networkStream; // 0x20
	private Socket socket; // 0x28
	private MonoTlsStream monoTlsStream; // 0x30
	private WebConnectionTunnel tunnel; // 0x38
	private int disposed; // 0x40
	[CompilerGenerated]
	private readonly ServicePoint <ServicePoint>k__BackingField; // 0x48
	internal readonly int ID; // 0x50
	private DateTime idleSince; // 0x58
	private WebOperation currentOperation; // 0x60

	// Properties
	public ServicePoint ServicePoint { get; }
	public bool Closed { get; }
	public bool Busy { get; }
	public DateTime IdleSince { get; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x21CF5D0 Offset: 0x21CE7D0 VA: 0x1821CF5D0
	public void .ctor(ServicePoint sPoint) { }

	[Conditional("MONO_WEB_DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void Debug(string message, object[] args) { }

	[Conditional("MONO_WEB_DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void Debug(string message) { }

	// RVA: 0x21CE680 Offset: 0x21CD880 VA: 0x1821CE680
	private bool CanReuse() { }

	// RVA: 0x21CE6B0 Offset: 0x21CD8B0 VA: 0x1821CE6B0
	private bool CheckReusable() { }

	[AsyncStateMachine(typeof(WebConnection.<Connect>d__16))]
	// RVA: 0x21CE8E0 Offset: 0x21CDAE0 VA: 0x1821CE8E0
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnection.<CreateStream>d__18))]
	// RVA: 0x21CEB20 Offset: 0x21CDD20 VA: 0x1821CEB20
	private Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnection.<InitConnection>d__19))]
	// RVA: 0x21CEE10 Offset: 0x21CE010 VA: 0x1821CEE10
	internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x21CEC90 Offset: 0x21CDE90 VA: 0x1821CEC90
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x21CF180 Offset: 0x21CE380 VA: 0x1821CF180
	internal static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x21CE320 Offset: 0x21CD520 VA: 0x1821CE320
	internal bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x21CEF30 Offset: 0x21CE130 VA: 0x1821CEF30
	private bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x21CF360 Offset: 0x21CE560 VA: 0x1821CF360
	private void Reset() { }

	// RVA: 0x21CE840 Offset: 0x21CDA40 VA: 0x1821CE840
	private void Close(bool reset) { }

	// RVA: 0x21CE700 Offset: 0x21CD900 VA: 0x1821CE700
	private void CloseSocket() { }

	// RVA: 0x21CF600 Offset: 0x21CE800 VA: 0x1821CF600
	public bool get_Closed() { }

	// RVA: 0x1650470 Offset: 0x164F670 VA: 0x181650470
	public bool get_Busy() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public DateTime get_IdleSince() { }

	// RVA: 0x21CF3F0 Offset: 0x21CE5F0 VA: 0x1821CF3F0
	public bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x21CE9D0 Offset: 0x21CDBD0 VA: 0x1821CE9D0
	public bool Continue(WebOperation next) { }

	// RVA: 0x21CEC50 Offset: 0x21CDE50 VA: 0x1821CEC50
	private void Dispose(bool disposing) { }

	// RVA: 0x21CEC50 Offset: 0x21CDE50 VA: 0x1821CEC50 Slot: 4
	public void Dispose() { }

	// RVA: 0x21CF350 Offset: 0x21CE550 VA: 0x1821CF350
	private void ResetNtlm() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }
}

// Namespace: System.Net
internal abstract class WebConnectionStream : Stream // TypeDefIndex: 5997
{
	// Fields
	protected bool closed; // 0x28
	private bool disposed; // 0x29
	private object locker; // 0x30
	private int read_timeout; // 0x38
	private int write_timeout; // 0x3C
	internal bool IgnoreIOErrors; // 0x40
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly WebConnection <Connection>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; // 0x58

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebConnection Connection { get; }
	internal WebOperation Operation { get; }
	internal ServicePoint ServicePoint { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x21CDDC0 Offset: 0x21CCFC0 VA: 0x1821CDDC0
	protected void .ctor(WebConnection cnc, WebOperation operation) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal WebConnection get_Connection() { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal WebOperation get_Operation() { }

	// RVA: 0x21CDF30 Offset: 0x21CD130 VA: 0x1821CDF30
	internal ServicePoint get_ServicePoint() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x21CDFA0 Offset: 0x21CD1A0 VA: 0x1821CDFA0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x21CE010 Offset: 0x21CD210 VA: 0x1821CE010 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x21CD650 Offset: 0x21CC850 VA: 0x1821CD650
	protected Exception GetException(Exception e) { }

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result);

	// RVA: 0x21CD820 Offset: 0x21CCA20 VA: 0x1821CD820 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x21CCF20 Offset: 0x21CC120 VA: 0x1821CCF20 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x21CD3F0 Offset: 0x21CC5F0 VA: 0x1821CD3F0 Slot: 25
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x21CD1A0 Offset: 0x21CC3A0 VA: 0x1821CD1A0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x21CD4C0 Offset: 0x21CC6C0 VA: 0x1821CD4C0 Slot: 29
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x21CDB80 Offset: 0x21CCD80 VA: 0x1821CDB80 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public override void Flush() { }

	// RVA: 0x21CD570 Offset: 0x21CC770 VA: 0x1821CD570 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x841460 Offset: 0x840660 VA: 0x180841460
	internal void InternalClose() { }

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract void Close_internal(ref bool disposed);

	// RVA: 0x21CD3D0 Offset: 0x21CC5D0 VA: 0x1821CD3D0 Slot: 20
	public override void Close() { }

	// RVA: 0x21CDAE0 Offset: 0x21CCCE0 VA: 0x1821CDAE0 Slot: 32
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x21CDB30 Offset: 0x21CCD30 VA: 0x1821CDB30 Slot: 33
	public override void SetLength(long a) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x21CDE90 Offset: 0x21CD090 VA: 0x1821CDE90 Slot: 11
	public override long get_Length() { }

	// RVA: 0x21CDEE0 Offset: 0x21CD0E0 VA: 0x1821CDEE0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x21CDF50 Offset: 0x21CD150 VA: 0x1821CDF50 Slot: 13
	public override void set_Position(long value) { }
}

// Namespace: 
private enum WebConnectionTunnel.NtlmAuthState // TypeDefIndex: 5998
{
	// Fields
	public int value__; // 0x0
	public const WebConnectionTunnel.NtlmAuthState None = 0;
	public const WebConnectionTunnel.NtlmAuthState Challenge = 1;
	public const WebConnectionTunnel.NtlmAuthState Response = 2;
}

// Namespace: 
[CompilerGenerated]
private struct WebConnectionTunnel.<Initialize>d__42 : IAsyncStateMachine // TypeDefIndex: 5999
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebConnectionTunnel <>4__this; // 0x20
	public Stream stream; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private bool <have_auth>5__2; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<WebHeaderCollection, byte[], int>> <>u__2; // 0x50

	// Methods

	// RVA: 0x21C56B0 Offset: 0x21C48B0 VA: 0x1821C56B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C6390 Offset: 0x21C5590 VA: 0x1821C6390 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebConnectionTunnel.<ReadHeaders>d__43 : IAsyncStateMachine // TypeDefIndex: 6000
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public Stream stream; // 0x28
	public WebConnectionTunnel <>4__this; // 0x30
	private byte[] <retBuffer>5__2; // 0x38
	private int <status>5__3; // 0x40
	private byte[] <buffer>5__4; // 0x48
	private MemoryStream <ms>5__5; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x58

	// Methods

	// RVA: 0x21C8AA0 Offset: 0x21C7CA0 VA: 0x1821C8AA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C92E0 Offset: 0x21C84E0 VA: 0x1821C92E0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class WebConnectionTunnel // TypeDefIndex: 6001
{
	// Fields
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Uri <ConnectUri>k__BackingField; // 0x18
	private HttpWebRequest connectRequest; // 0x20
	private WebConnectionTunnel.NtlmAuthState ntlmAuthState; // 0x28
	[CompilerGenerated]
	private bool <Success>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <CloseConnection>k__BackingField; // 0x2D
	[CompilerGenerated]
	private int <StatusCode>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; // 0x38
	[CompilerGenerated]
	private string[] <Challenge>k__BackingField; // 0x40
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; // 0x48
	[CompilerGenerated]
	private Version <ProxyVersion>k__BackingField; // 0x50
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x58

	// Properties
	public HttpWebRequest Request { get; }
	public Uri ConnectUri { get; }
	public bool Success { get; set; }
	public bool CloseConnection { get; set; }
	public int StatusCode { get; set; }
	public string StatusDescription { get; set; }
	public string[] Challenge { get; set; }
	public WebHeaderCollection Headers { get; set; }
	public Version ProxyVersion { get; set; }
	public byte[] Data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Uri get_ConnectUri() { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(HttpWebRequest request, Uri connectUri) { }

	[CompilerGenerated]
	// RVA: 0x48DA50 Offset: 0x48CC50 VA: 0x18048DA50
	public bool get_Success() { }

	[CompilerGenerated]
	// RVA: 0x48DA70 Offset: 0x48CC70 VA: 0x18048DA70
	private void set_Success(bool value) { }

	[CompilerGenerated]
	// RVA: 0x48DA60 Offset: 0x48CC60 VA: 0x18048DA60
	public bool get_CloseConnection() { }

	[CompilerGenerated]
	// RVA: 0x48DA80 Offset: 0x48CC80 VA: 0x18048DA80
	private void set_CloseConnection(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	private void set_StatusCode(int value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_StatusDescription() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string[] get_Challenge() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	private void set_Challenge(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public Version get_ProxyVersion() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	private void set_ProxyVersion(Version value) { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public byte[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	private void set_Data(byte[] value) { }

	[AsyncStateMachine(typeof(WebConnectionTunnel.<Initialize>d__42))]
	// RVA: 0x21CE110 Offset: 0x21CD310 VA: 0x1821CE110
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnectionTunnel.<ReadHeaders>d__43))]
	// RVA: 0x21CE200 Offset: 0x21CD400 VA: 0x1821CE200
	private Task<ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x21CE080 Offset: 0x21CD280 VA: 0x1821CE080
	private void FlushContents(Stream stream, int contentLength) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebOperation.<GetRequestStream>d__50 : IAsyncStateMachine // TypeDefIndex: 6002
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public WebOperation <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebRequestStream> <>u__1; // 0x28

	// Methods

	// RVA: 0x21C4120 Offset: 0x21C3320 VA: 0x1821C4120 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C4320 Offset: 0x21C3520 VA: 0x1821C4320 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebOperation.<Run>d__58 : IAsyncStateMachine // TypeDefIndex: 6003
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public WebOperation <>4__this; // 0x28
	private WebRequestStream <requestStream>5__2; // 0x30
	private WebResponseStream <stream>5__3; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebRequestStream> <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0x21C9F00 Offset: 0x21C9100 VA: 0x1821C9F00 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x71F7C0 Offset: 0x71E9C0 VA: 0x18071F7C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class WebOperation // TypeDefIndex: 6004
{
	// Fields
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGenerated]
	private WebConnection <Connection>k__BackingField; // 0x18
	[CompilerGenerated]
	private ServicePoint <ServicePoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly BufferOffsetSize <WriteBuffer>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly bool <IsNtlmChallenge>k__BackingField; // 0x30
	internal readonly int ID; // 0x34
	private CancellationTokenSource cts; // 0x38
	private WebCompletionSource<WebRequestStream> requestTask; // 0x40
	private WebCompletionSource<WebRequestStream> requestWrittenTask; // 0x48
	private WebCompletionSource<WebResponseStream> responseTask; // 0x50
	private WebCompletionSource<ValueTuple<bool, WebOperation>> finishedTask; // 0x58
	private WebRequestStream writeStream; // 0x60
	private WebResponseStream responseStream; // 0x68
	private ExceptionDispatchInfo disposedInfo; // 0x70
	private ExceptionDispatchInfo closedInfo; // 0x78
	private WebOperation priorityRequest; // 0x80
	private int requestSent; // 0x88
	private int finished; // 0x8C

	// Properties
	public HttpWebRequest Request { get; }
	public WebConnection Connection { get; set; }
	public ServicePoint ServicePoint { get; set; }
	public BufferOffsetSize WriteBuffer { get; }
	public bool IsNtlmChallenge { get; }
	internal string ME { get; }
	public bool Aborted { get; }
	public bool Closed { get; }
	public WebRequestStream WriteStream { get; }
	internal WebCompletionSource<ValueTuple<bool, WebOperation>> Finished { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public WebConnection get_Connection() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_Connection(WebConnection value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ServicePoint get_ServicePoint() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_ServicePoint(ServicePoint value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public BufferOffsetSize get_WriteBuffer() { }

	[CompilerGenerated]
	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_IsNtlmChallenge() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal string get_ME() { }

	// RVA: 0x21D0660 Offset: 0x21CF860 VA: 0x1821D0660
	public void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x21D07D0 Offset: 0x21CF9D0 VA: 0x1821D07D0
	public bool get_Aborted() { }

	// RVA: 0x21D0820 Offset: 0x21CFA20 VA: 0x1821D0820
	public bool get_Closed() { }

	// RVA: 0x21CF610 Offset: 0x21CE810 VA: 0x1821CF610
	public void Abort() { }

	// RVA: 0x21CF7C0 Offset: 0x21CE9C0 VA: 0x1821CF7C0
	public void Close() { }

	// RVA: 0x21CFFA0 Offset: 0x21CF1A0 VA: 0x1821CFFA0
	private void SetCanceled() { }

	// RVA: 0x21D0150 Offset: 0x21CF350 VA: 0x1821D0150
	private void SetError(Exception error) { }

	// RVA: 0x21D0070 Offset: 0x21CF270 VA: 0x1821D0070
	private ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field) { }

	// RVA: 0x21CF670 Offset: 0x21CE870 VA: 0x1821CF670
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x21D0570 Offset: 0x21CF770 VA: 0x1821D0570
	internal void ThrowIfDisposed() { }

	// RVA: 0x21D0490 Offset: 0x21CF690 VA: 0x1821D0490
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x21D0350 Offset: 0x21CF550 VA: 0x1821D0350
	internal void ThrowIfClosedOrDisposed() { }

	// RVA: 0x21D03B0 Offset: 0x21CF5B0 VA: 0x1821D03B0
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x21CF750 Offset: 0x21CE950 VA: 0x1821CF750
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field) { }

	// RVA: 0x21CFCA0 Offset: 0x21CEEA0 VA: 0x1821CFCA0
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x21D01F0 Offset: 0x21CF3F0 VA: 0x1821D01F0
	public void SetPriorityRequest(WebOperation operation) { }

	[AsyncStateMachine(typeof(WebOperation.<GetRequestStream>d__50))]
	// RVA: 0x21CFB80 Offset: 0x21CED80 VA: 0x1821CFB80
	public Task<Stream> GetRequestStream() { }

	// RVA: 0x21CFB30 Offset: 0x21CED30 VA: 0x1821CFB30
	internal Task<WebRequestStream> GetRequestStreamInternal() { }

	// RVA: 0x21D0610 Offset: 0x21CF810 VA: 0x1821D0610
	public Task WaitUntilRequestWritten() { }

	// RVA: 0x21D0880 Offset: 0x21CFA80 VA: 0x1821D0880
	public WebRequestStream get_WriteStream() { }

	// RVA: 0x21CFC50 Offset: 0x21CEE50 VA: 0x1821CFC50
	public Task<WebResponseStream> GetResponseStream() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal WebCompletionSource<ValueTuple<bool, WebOperation>> get_Finished() { }

	[AsyncStateMachine(typeof(WebOperation.<Run>d__58))]
	// RVA: 0x21CFF00 Offset: 0x21CF100 VA: 0x1821CFF00
	internal void Run() { }

	// RVA: 0x21CF820 Offset: 0x21CEA20 VA: 0x1821CF820
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x21CF8B0 Offset: 0x21CEAB0 VA: 0x1821CF8B0
	internal void Finish(bool ok, Exception error) { }

	[CompilerGenerated]
	// RVA: 0x21D05D0 Offset: 0x21CF7D0 VA: 0x1821D05D0
	private void <RegisterRequest>b__48_0() { }
}

// Namespace: 
[CompilerGenerated]
private struct WebReadStream.<ReadAsync>d__28 : IAsyncStateMachine // TypeDefIndex: 6005
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public WebReadStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public byte[] buffer; // 0x30
	public int offset; // 0x38
	public int size; // 0x3C
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0x21C7C10 Offset: 0x21C6E10 VA: 0x1821C7C10 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C80F0 Offset: 0x21C72F0 VA: 0x1821C80F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal abstract class WebReadStream : Stream // TypeDefIndex: 6006
{
	// Fields
	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; // 0x30
	private bool disposed; // 0x38

	// Properties
	public WebOperation Operation { get; }
	protected Stream InnerStream { get; }
	internal string ME { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public WebOperation get_Operation() { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	protected Stream get_InnerStream() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal string get_ME() { }

	// RVA: 0x21D1460 Offset: 0x21D0660 VA: 0x1821D1460
	public void .ctor(WebOperation operation, Stream innerStream) { }

	// RVA: 0x21D14D0 Offset: 0x21D06D0 VA: 0x1821D14D0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x21D1510 Offset: 0x21D0710 VA: 0x1821D1510 Slot: 12
	public override long get_Position() { }

	// RVA: 0x21D1550 Offset: 0x21D0750 VA: 0x1821D1550 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x21D13E0 Offset: 0x21D05E0 VA: 0x1821D13E0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x21D13A0 Offset: 0x21D05A0 VA: 0x1821D13A0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21D1420 Offset: 0x21D0620 VA: 0x1821D1420 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21D0DB0 Offset: 0x21CFFB0 VA: 0x1821D0DB0 Slot: 22
	public override void Flush() { }

	// RVA: 0x21D0DF0 Offset: 0x21CFFF0 VA: 0x1821D0DF0
	protected Exception GetException(Exception e) { }

	// RVA: 0x21D10E0 Offset: 0x21D02E0 VA: 0x1821D10E0 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x21D08E0 Offset: 0x21CFAE0 VA: 0x1821D08E0 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x21D0BB0 Offset: 0x21CFDB0 VA: 0x1821D0BB0 Slot: 25
	public override int EndRead(IAsyncResult r) { }

	[AsyncStateMachine(typeof(WebReadStream.<ReadAsync>d__28))]
	// RVA: 0x21D0FC0 Offset: 0x21D01C0 VA: 0x1821D0FC0 Slot: 26
	public sealed override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);

	// RVA: 0x21D0C80 Offset: 0x21CFE80 VA: 0x1821D0C80 Slot: 41
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x21D0B60 Offset: 0x21CFD60 VA: 0x1821D0B60 Slot: 21
	protected override void Dispose(bool disposing) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<FinishWriting>d__31 : IAsyncStateMachine // TypeDefIndex: 6007
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x21C3DB0 Offset: 0x21C2FB0 VA: 0x1821C3DB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C40C0 Offset: 0x21C32C0 VA: 0x1821C40C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<WriteAsyncInner>d__33 : IAsyncStateMachine // TypeDefIndex: 6008
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public byte[] buffer; // 0x28
	public int offset; // 0x30
	public int size; // 0x34
	public CancellationToken cancellationToken; // 0x38
	public WebCompletionSource completion; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48
	private TaskAwaiter <>u__2; // 0x58

	// Methods

	// RVA: 0x21CB840 Offset: 0x21CAA40 VA: 0x1821CB840 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21CBDB0 Offset: 0x21CAFB0 VA: 0x1821CBDB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<ProcessWrite>d__34 : IAsyncStateMachine // TypeDefIndex: 6009
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public int size; // 0x30
	public byte[] buffer; // 0x38
	public int offset; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x21C63F0 Offset: 0x21C55F0 VA: 0x1821C63F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C6980 Offset: 0x21C5B80 VA: 0x1821C6980 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<Initialize>d__36 : IAsyncStateMachine // TypeDefIndex: 6010
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30
	private TaskAwaiter <>u__2; // 0x40

	// Methods

	// RVA: 0x21C5240 Offset: 0x21C4440 VA: 0x1821C5240 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C5650 Offset: 0x21C4850 VA: 0x1821C5650 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<SetHeadersAsync>d__37 : IAsyncStateMachine // TypeDefIndex: 6011
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public bool setInternalLength; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x21CA720 Offset: 0x21C9920 VA: 0x1821CA720 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21CADD0 Offset: 0x21C9FD0 VA: 0x1821CADD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<WriteRequestAsync>d__38 : IAsyncStateMachine // TypeDefIndex: 6012
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private BufferOffsetSize <buffer>5__2; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38
	private TaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x21CC850 Offset: 0x21CBA50 VA: 0x1821CC850 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21CCE80 Offset: 0x21CC080 VA: 0x1821CCE80 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<WriteChunkTrailer_inner>d__39 : IAsyncStateMachine // TypeDefIndex: 6013
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x21CC5A0 Offset: 0x21CB7A0 VA: 0x1821CC5A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21CC7F0 Offset: 0x21CB9F0 VA: 0x1821CC7F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<WriteChunkTrailer>d__40 : IAsyncStateMachine // TypeDefIndex: 6014
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	private CancellationTokenSource <cts>5__2; // 0x28
	private Task <timeoutTask>5__3; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x21CBE10 Offset: 0x21CB010 VA: 0x1821CBE10 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21CC540 Offset: 0x21CB740 VA: 0x1821CC540 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class WebRequestStream : WebConnectionStream // TypeDefIndex: 6015
{
	// Fields
	private static byte[] crlf; // 0x0
	private MemoryStream writeBuffer; // 0x60
	private bool requestWritten; // 0x68
	private bool allowBuffering; // 0x69
	private bool sendChunked; // 0x6A
	private WebCompletionSource pendingWrite; // 0x70
	private long totalWritten; // 0x78
	private byte[] headers; // 0x80
	private bool headersSent; // 0x88
	private int completeRequestWritten; // 0x8C
	private int chunkTrailerWritten; // 0x90
	internal readonly string ME; // 0x98
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; // 0xA0
	[CompilerGenerated]
	private readonly bool <KeepAlive>k__BackingField; // 0xA8

	// Properties
	internal Stream InnerStream { get; }
	public bool KeepAlive { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	internal bool SendChunked { get; set; }
	internal bool HasWriteBuffer { get; }
	internal int WriteBufferLength { get; }

	// Methods

	// RVA: 0x21D2670 Offset: 0x21D1870 VA: 0x1821D2670
	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	[CompilerGenerated]
	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	internal Stream get_InnerStream() { }

	[CompilerGenerated]
	// RVA: 0x738050 Offset: 0x737250 VA: 0x180738050
	public bool get_KeepAlive() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1C13490 Offset: 0x1C12690 VA: 0x181C13490
	internal bool get_SendChunked() { }

	// RVA: 0x1C13500 Offset: 0x1C12700 VA: 0x181C13500
	internal void set_SendChunked(bool value) { }

	// RVA: 0x21D27F0 Offset: 0x21D19F0 VA: 0x1821D27F0
	internal bool get_HasWriteBuffer() { }

	// RVA: 0x21D2820 Offset: 0x21D1A20 VA: 0x1821D2820
	internal int get_WriteBufferLength() { }

	// RVA: 0x21D19A0 Offset: 0x21D0BA0 VA: 0x1821D19A0
	internal BufferOffsetSize GetWriteBuffer() { }

	[AsyncStateMachine(typeof(WebRequestStream.<FinishWriting>d__31))]
	// RVA: 0x21D18C0 Offset: 0x21D0AC0 VA: 0x1821D18C0
	private Task FinishWriting(CancellationToken cancellationToken) { }

	// RVA: 0x21D1FA0 Offset: 0x21D11A0 VA: 0x1821D1FA0 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteAsyncInner>d__33))]
	// RVA: 0x21D1E80 Offset: 0x21D1080 VA: 0x1821D1E80
	private Task WriteAsyncInner(byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<ProcessWrite>d__34))]
	// RVA: 0x21D1BB0 Offset: 0x21D0DB0 VA: 0x1821D1BB0
	private Task ProcessWrite(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x21D1590 Offset: 0x21D0790 VA: 0x1821D1590
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	[AsyncStateMachine(typeof(WebRequestStream.<Initialize>d__36))]
	// RVA: 0x21D1AC0 Offset: 0x21D0CC0 VA: 0x1821D1AC0
	internal Task Initialize(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<SetHeadersAsync>d__37))]
	// RVA: 0x21D1D50 Offset: 0x21D0F50 VA: 0x1821D1D50
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteRequestAsync>d__38))]
	// RVA: 0x21D2510 Offset: 0x21D1710 VA: 0x1821D2510
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteChunkTrailer_inner>d__39))]
	// RVA: 0x21D2360 Offset: 0x21D1560 VA: 0x1821D2360
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteChunkTrailer>d__40))]
	// RVA: 0x21D2440 Offset: 0x21D1640 VA: 0x1821D2440
	private Task WriteChunkTrailer() { }

	// RVA: 0x21D1BA0 Offset: 0x21D0DA0 VA: 0x1821D1BA0
	internal void KillBuffer() { }

	// RVA: 0x21D1CC0 Offset: 0x21D0EC0 VA: 0x1821D1CC0 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x21D1E40 Offset: 0x21D1040 VA: 0x1821D1E40 Slot: 40
	protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x21D1640 Offset: 0x21D0840 VA: 0x1821D1640 Slot: 41
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x21D25F0 Offset: 0x21D17F0 VA: 0x1821D25F0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct WebResponseStream.<ReadAsync>d__40 : IAsyncStateMachine // TypeDefIndex: 6016
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public byte[] buffer; // 0x28
	public int offset; // 0x30
	public int count; // 0x34
	public WebResponseStream <>4__this; // 0x38
	private WebCompletionSource <completion>5__2; // 0x40
	private int <nbytes>5__3; // 0x48
	private Exception <throwMe>5__4; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__1; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2; // 0x68

	// Methods

	// RVA: 0x21C8160 Offset: 0x21C7360 VA: 0x1821C8160 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C8A30 Offset: 0x21C7C30 VA: 0x1821C8A30 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebResponseStream.<>c__DisplayClass41_0 // TypeDefIndex: 6017
{
	// Fields
	public WebResponseStream <>4__this; // 0x10
	public byte[] buffer; // 0x18
	public int offset; // 0x20
	public int size; // 0x24

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21CB110 Offset: 0x21CA310 VA: 0x1821CB110
	internal Task<int> <ProcessRead>b__0(CancellationToken ct) { }

	// RVA: 0x21CB160 Offset: 0x21CA360 VA: 0x1821CB160
	internal void <ProcessRead>b__1() { }

	// RVA: 0x21CB1F0 Offset: 0x21CA3F0 VA: 0x1821CB1F0
	internal bool <ProcessRead>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private struct WebResponseStream.<ReadAllAsyncInner>d__47 : IAsyncStateMachine // TypeDefIndex: 6018
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public WebResponseStream <>4__this; // 0x28
	private long <maximumSize>5__2; // 0x30
	private MemoryStream <ms>5__3; // 0x38
	private byte[] <buffer>5__4; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x21C69E0 Offset: 0x21C5BE0 VA: 0x1821C69E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C6F50 Offset: 0x21C6150 VA: 0x1821C6F50 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebResponseStream.<ReadAllAsync>d__48 : IAsyncStateMachine // TypeDefIndex: 6019
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebResponseStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public bool resending; // 0x30
	private WebCompletionSource <completion>5__2; // 0x38
	private CancellationTokenSource <timeoutCts>5__3; // 0x40
	private Task <timeoutTask>5__4; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<byte[]> <>u__2; // 0x60

	// Methods

	// RVA: 0x21C6FC0 Offset: 0x21C61C0 VA: 0x1821C6FC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C7BB0 Offset: 0x21C6DB0 VA: 0x1821C7BB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebResponseStream.<InitReadAsync>d__52 : IAsyncStateMachine // TypeDefIndex: 6020
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebResponseStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private BufferOffsetSize <buffer>5__2; // 0x30
	private ReadState <state>5__3; // 0x38
	private int <position>5__4; // 0x3C
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x40

	// Methods

	// RVA: 0x21C4BC0 Offset: 0x21C3DC0 VA: 0x1821C4BC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x21C51E0 Offset: 0x21C43E0 VA: 0x1821C51E0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class WebResponseStream : WebConnectionStream // TypeDefIndex: 6021
{
	// Fields
	private WebReadStream innerStream; // 0x60
	private bool nextReadCalled; // 0x68
	private bool bufferedEntireContent; // 0x69
	private WebCompletionSource pendingRead; // 0x70
	private object locker; // 0x78
	private int nestedRead; // 0x80
	private bool read_eof; // 0x84
	[CompilerGenerated]
	private readonly WebRequestStream <RequestStream>k__BackingField; // 0x88
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; // 0x90
	[CompilerGenerated]
	private HttpStatusCode <StatusCode>k__BackingField; // 0x98
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Version <Version>k__BackingField; // 0xA8
	[CompilerGenerated]
	private bool <KeepAlive>k__BackingField; // 0xB0
	internal readonly string ME; // 0xB8
	[CompilerGenerated]
	private bool <ChunkedRead>k__BackingField; // 0xC0

	// Properties
	public WebRequestStream RequestStream { get; }
	public WebHeaderCollection Headers { get; set; }
	public HttpStatusCode StatusCode { get; set; }
	public string StatusDescription { get; set; }
	public Version Version { get; set; }
	public bool KeepAlive { get; set; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	private bool ChunkedRead { get; set; }
	private bool ExpectContent { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public WebRequestStream get_RequestStream() { }

	[CompilerGenerated]
	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x43B590 Offset: 0x43A790 VA: 0x18043B590
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	// RVA: 0x838410 Offset: 0x837610 VA: 0x180838410
	public HttpStatusCode get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0x838420 Offset: 0x837620 VA: 0x180838420
	private void set_StatusCode(HttpStatusCode value) { }

	[CompilerGenerated]
	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public string get_StatusDescription() { }

	[CompilerGenerated]
	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public Version get_Version() { }

	[CompilerGenerated]
	// RVA: 0xB83400 Offset: 0xB82600 VA: 0x180B83400
	private void set_Version(Version value) { }

	[CompilerGenerated]
	// RVA: 0xB82FA0 Offset: 0xB821A0 VA: 0x180B82FA0
	public bool get_KeepAlive() { }

	[CompilerGenerated]
	// RVA: 0xB833A0 Offset: 0xB825A0 VA: 0x180B833A0
	private void set_KeepAlive(bool value) { }

	// RVA: 0x21D4190 Offset: 0x21D3390 VA: 0x1821D4190
	public void .ctor(WebRequestStream request) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	public override bool get_CanWrite() { }

	[CompilerGenerated]
	// RVA: 0x5C6220 Offset: 0x5C5420 VA: 0x1805C6220
	private bool get_ChunkedRead() { }

	[CompilerGenerated]
	// RVA: 0x6BC540 Offset: 0x6BB740 VA: 0x1806BC540
	private void set_ChunkedRead(bool value) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAsync>d__40))]
	// RVA: 0x21D3EF0 Offset: 0x21D30F0 VA: 0x1821D3EF0 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x21D3A70 Offset: 0x21D2C70 VA: 0x1821D3A70
	private Task<int> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x21D4040 Offset: 0x21D3240 VA: 0x1821D4040 Slot: 40
	protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x21D2880 Offset: 0x21D1A80 VA: 0x1821D2880
	private bool CheckAuthHeader(string headerName) { }

	// RVA: 0x21D4220 Offset: 0x21D3420 VA: 0x1821D4220
	private bool get_ExpectContent() { }

	// RVA: 0x21D34F0 Offset: 0x21D26F0 VA: 0x1821D34F0
	private void Initialize(BufferOffsetSize buffer) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAllAsyncInner>d__47))]
	// RVA: 0x21D3CE0 Offset: 0x21D2EE0 VA: 0x1821D3CE0
	private Task<byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAllAsync>d__48))]
	// RVA: 0x21D3DF0 Offset: 0x21D2FF0 VA: 0x1821D3DF0
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x21D4110 Offset: 0x21D3310 VA: 0x1821D4110 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x21D2910 Offset: 0x21D1B10 VA: 0x1821D2910 Slot: 41
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x21D29A0 Offset: 0x21D1BA0 VA: 0x1821D29A0
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	[AsyncStateMachine(typeof(WebResponseStream.<InitReadAsync>d__52))]
	// RVA: 0x21D3410 Offset: 0x21D2610 VA: 0x1821D3410
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x21D2C80 Offset: 0x21D1E80 VA: 0x1821D2C80
	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }
}

// Namespace: System.Net.NetworkInformation
public enum DuplicateAddressDetectionState // TypeDefIndex: 6022
{
	// Fields
	public int value__; // 0x0
	public const DuplicateAddressDetectionState Invalid = 0;
	public const DuplicateAddressDetectionState Tentative = 1;
	public const DuplicateAddressDetectionState Duplicate = 2;
	public const DuplicateAddressDetectionState Deprecated = 3;
	public const DuplicateAddressDetectionState Preferred = 4;
}

// Namespace: System.Net.NetworkInformation
public abstract class GatewayIPAddressInformation // TypeDefIndex: 6023
{
	// Properties
	public abstract IPAddress Address { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IPAddress get_Address();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
[DefaultMember("Item")]
public class GatewayIPAddressInformationCollection : ICollection<GatewayIPAddressInformation>, IEnumerable<GatewayIPAddressInformation>, IEnumerable // TypeDefIndex: 6024
{
	// Fields
	private Collection<GatewayIPAddressInformation> addresses; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual GatewayIPAddressInformation Item { get; }

	// Methods

	// RVA: 0x21BDF20 Offset: 0x21BD120 VA: 0x1821BDF20
	protected internal void .ctor() { }

	// RVA: 0x21BDDA0 Offset: 0x21BCFA0 VA: 0x1821BDDA0 Slot: 13
	public virtual void CopyTo(GatewayIPAddressInformation[] array, int offset) { }

	// RVA: 0x21BDF90 Offset: 0x21BD190 VA: 0x1821BDF90 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 15
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x21BDFE0 Offset: 0x21BD1E0 VA: 0x1821BDFE0 Slot: 16
	public virtual GatewayIPAddressInformation get_Item(int index) { }

	// RVA: 0x21BDC80 Offset: 0x21BCE80 VA: 0x1821BDC80 Slot: 17
	public virtual void Add(GatewayIPAddressInformation address) { }

	// RVA: 0x21BDE60 Offset: 0x21BD060 VA: 0x1821BDE60
	internal void InternalAdd(GatewayIPAddressInformation address) { }

	// RVA: 0x21BDD40 Offset: 0x21BCF40 VA: 0x1821BDD40 Slot: 18
	public virtual bool Contains(GatewayIPAddressInformation address) { }

	// RVA: 0x21BDE10 Offset: 0x21BD010 VA: 0x1821BDE10 Slot: 19
	public virtual IEnumerator<GatewayIPAddressInformation> GetEnumerator() { }

	// RVA: 0x132CE10 Offset: 0x132C010 VA: 0x18132CE10 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x21BDEC0 Offset: 0x21BD0C0 VA: 0x1821BDEC0 Slot: 20
	public virtual bool Remove(GatewayIPAddressInformation address) { }

	// RVA: 0x21BDCE0 Offset: 0x21BCEE0 VA: 0x1821BDCE0 Slot: 21
	public virtual void Clear() { }
}

// Namespace: System.Net.NetworkInformation
[DefaultMember("Item")]
public class IPAddressCollection : ICollection<IPAddress>, IEnumerable<IPAddress>, IEnumerable // TypeDefIndex: 6025
{
	// Fields
	private Collection<IPAddress> addresses; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual IPAddress Item { get; }

	// Methods

	// RVA: 0x21BE2E0 Offset: 0x21BD4E0 VA: 0x1821BE2E0
	protected internal void .ctor() { }

	// RVA: 0x21BE160 Offset: 0x21BD360 VA: 0x1821BE160 Slot: 13
	public virtual void CopyTo(IPAddress[] array, int offset) { }

	// RVA: 0x21BE350 Offset: 0x21BD550 VA: 0x1821BE350 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 15
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x21BE040 Offset: 0x21BD240 VA: 0x1821BE040 Slot: 16
	public virtual void Add(IPAddress address) { }

	// RVA: 0x21BE220 Offset: 0x21BD420 VA: 0x1821BE220
	internal void InternalAdd(IPAddress address) { }

	// RVA: 0x21BE100 Offset: 0x21BD300 VA: 0x1821BE100 Slot: 17
	public virtual bool Contains(IPAddress address) { }

	// RVA: 0x7F68D0 Offset: 0x7F5AD0 VA: 0x1807F68D0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x21BE1D0 Offset: 0x21BD3D0 VA: 0x1821BE1D0 Slot: 18
	public virtual IEnumerator<IPAddress> GetEnumerator() { }

	// RVA: 0x21BE3A0 Offset: 0x21BD5A0 VA: 0x1821BE3A0 Slot: 19
	public virtual IPAddress get_Item(int index) { }

	// RVA: 0x21BE280 Offset: 0x21BD480 VA: 0x1821BE280 Slot: 20
	public virtual bool Remove(IPAddress address) { }

	// RVA: 0x21BE0A0 Offset: 0x21BD2A0 VA: 0x1821BE0A0 Slot: 21
	public virtual void Clear() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class IPAddressInformation // TypeDefIndex: 6026
{
	// Properties
	public abstract IPAddress Address { get; }
	public abstract bool IsDnsEligible { get; }
	public abstract bool IsTransient { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IPAddress get_Address();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsDnsEligible();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsTransient();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
[DefaultMember("Item")]
public class IPAddressInformationCollection : ICollection<IPAddressInformation>, IEnumerable<IPAddressInformation>, IEnumerable // TypeDefIndex: 6027
{
	// Fields
	private Collection<IPAddressInformation> addresses; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual IPAddressInformation Item { get; }

	// Methods

	// RVA: 0x21BE6A0 Offset: 0x21BD8A0 VA: 0x1821BE6A0
	internal void .ctor() { }

	// RVA: 0x21BE520 Offset: 0x21BD720 VA: 0x1821BE520 Slot: 13
	public virtual void CopyTo(IPAddressInformation[] array, int offset) { }

	// RVA: 0x21BE710 Offset: 0x21BD910 VA: 0x1821BE710 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 15
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x21BE400 Offset: 0x21BD600 VA: 0x1821BE400 Slot: 16
	public virtual void Add(IPAddressInformation address) { }

	// RVA: 0x21BE5E0 Offset: 0x21BD7E0 VA: 0x1821BE5E0
	internal void InternalAdd(IPAddressInformation address) { }

	// RVA: 0x21BE4C0 Offset: 0x21BD6C0 VA: 0x1821BE4C0 Slot: 17
	public virtual bool Contains(IPAddressInformation address) { }

	// RVA: 0x7F68D0 Offset: 0x7F5AD0 VA: 0x1807F68D0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x21BE590 Offset: 0x21BD790 VA: 0x1821BE590 Slot: 18
	public virtual IEnumerator<IPAddressInformation> GetEnumerator() { }

	// RVA: 0x21BE760 Offset: 0x21BD960 VA: 0x1821BE760 Slot: 19
	public virtual IPAddressInformation get_Item(int index) { }

	// RVA: 0x21BE640 Offset: 0x21BD840 VA: 0x1821BE640 Slot: 20
	public virtual bool Remove(IPAddressInformation address) { }

	// RVA: 0x21BE460 Offset: 0x21BD660 VA: 0x1821BE460 Slot: 21
	public virtual void Clear() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties // TypeDefIndex: 6028
{
	// Properties
	public abstract string DhcpScopeName { get; }
	public abstract string DomainName { get; }
	public abstract string HostName { get; }
	public abstract bool IsWinsProxy { get; }
	public abstract NetBiosNodeType NodeType { get; }

	// Methods

	// RVA: 0x21BE820 Offset: 0x21BDA20 VA: 0x1821BE820
	public static IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0x21BE820 Offset: 0x21BDA20 VA: 0x1821BE820
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IPEndPoint[] GetActiveUdpListeners();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IPEndPoint[] GetActiveTcpListeners();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TcpConnectionInformation[] GetActiveTcpConnections();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_DhcpScopeName();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_DomainName();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_HostName();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsWinsProxy();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract NetBiosNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract TcpStatistics GetTcpIPv4Statistics();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract TcpStatistics GetTcpIPv6Statistics();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract UdpStatistics GetUdpIPv4Statistics();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract UdpStatistics GetUdpIPv6Statistics();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IcmpV4Statistics GetIcmpV4Statistics();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IcmpV6Statistics GetIcmpV6Statistics();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IPGlobalStatistics GetIPv4GlobalStatistics();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IPGlobalStatistics GetIPv6GlobalStatistics();

	// RVA: 0x21BE930 Offset: 0x21BDB30 VA: 0x1821BE930 Slot: 20
	public virtual UnicastIPAddressInformationCollection GetUnicastAddresses() { }

	// RVA: 0x21BE7C0 Offset: 0x21BD9C0 VA: 0x1821BE7C0 Slot: 21
	public virtual IAsyncResult BeginGetUnicastAddresses(AsyncCallback callback, object state) { }

	// RVA: 0x21BE7F0 Offset: 0x21BD9F0 VA: 0x1821BE7F0 Slot: 22
	public virtual UnicastIPAddressInformationCollection EndGetUnicastAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x21BE830 Offset: 0x21BDA30 VA: 0x1821BE830 Slot: 23
	public virtual Task<UnicastIPAddressInformationCollection> GetUnicastAddressesAsync() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalStatistics // TypeDefIndex: 6029
{
	// Properties
	public abstract int DefaultTtl { get; }
	public abstract bool ForwardingEnabled { get; }
	public abstract int NumberOfInterfaces { get; }
	public abstract int NumberOfIPAddresses { get; }
	public abstract long OutputPacketRequests { get; }
	public abstract long OutputPacketRoutingDiscards { get; }
	public abstract long OutputPacketsDiscarded { get; }
	public abstract long OutputPacketsWithNoRoute { get; }
	public abstract long PacketFragmentFailures { get; }
	public abstract long PacketReassembliesRequired { get; }
	public abstract long PacketReassemblyFailures { get; }
	public abstract long PacketReassemblyTimeout { get; }
	public abstract long PacketsFragmented { get; }
	public abstract long PacketsReassembled { get; }
	public abstract long ReceivedPackets { get; }
	public abstract long ReceivedPacketsDelivered { get; }
	public abstract long ReceivedPacketsDiscarded { get; }
	public abstract long ReceivedPacketsForwarded { get; }
	public abstract long ReceivedPacketsWithAddressErrors { get; }
	public abstract long ReceivedPacketsWithHeadersErrors { get; }
	public abstract long ReceivedPacketsWithUnknownProtocol { get; }
	public abstract int NumberOfRoutes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_DefaultTtl();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_ForwardingEnabled();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_NumberOfInterfaces();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_NumberOfIPAddresses();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract long get_OutputPacketRequests();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract long get_OutputPacketRoutingDiscards();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_OutputPacketsDiscarded();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_OutputPacketsWithNoRoute();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_PacketFragmentFailures();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract long get_PacketReassembliesRequired();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract long get_PacketReassemblyFailures();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract long get_PacketReassemblyTimeout();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract long get_PacketsFragmented();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract long get_PacketsReassembled();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract long get_ReceivedPackets();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract long get_ReceivedPacketsDelivered();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract long get_ReceivedPacketsDiscarded();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract long get_ReceivedPacketsForwarded();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract long get_ReceivedPacketsWithAddressErrors();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract long get_ReceivedPacketsWithHeadersErrors();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract long get_ReceivedPacketsWithUnknownProtocol();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int get_NumberOfRoutes();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class IPInterfaceProperties // TypeDefIndex: 6030
{
	// Properties
	public abstract bool IsDnsEnabled { get; }
	public abstract string DnsSuffix { get; }
	public abstract bool IsDynamicDnsEnabled { get; }
	public abstract UnicastIPAddressInformationCollection UnicastAddresses { get; }
	public abstract MulticastIPAddressInformationCollection MulticastAddresses { get; }
	public abstract IPAddressInformationCollection AnycastAddresses { get; }
	public abstract IPAddressCollection DnsAddresses { get; }
	public abstract GatewayIPAddressInformationCollection GatewayAddresses { get; }
	public abstract IPAddressCollection DhcpServerAddresses { get; }
	public abstract IPAddressCollection WinsServersAddresses { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsDnsEnabled();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_DnsSuffix();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsDynamicDnsEnabled();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract UnicastIPAddressInformationCollection get_UnicastAddresses();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract MulticastIPAddressInformationCollection get_MulticastAddresses();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IPAddressInformationCollection get_AnycastAddresses();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IPAddressCollection get_DnsAddresses();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract GatewayIPAddressInformationCollection get_GatewayAddresses();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IPAddressCollection get_DhcpServerAddresses();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IPAddressCollection get_WinsServersAddresses();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IPv4InterfaceProperties GetIPv4Properties();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IPv6InterfaceProperties GetIPv6Properties();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class IPInterfaceStatistics // TypeDefIndex: 6031
{
	// Properties
	public abstract long BytesReceived { get; }
	public abstract long BytesSent { get; }
	public abstract long IncomingPacketsDiscarded { get; }
	public abstract long IncomingPacketsWithErrors { get; }
	public abstract long IncomingUnknownProtocolPackets { get; }
	public abstract long NonUnicastPacketsReceived { get; }
	public abstract long NonUnicastPacketsSent { get; }
	public abstract long OutgoingPacketsDiscarded { get; }
	public abstract long OutgoingPacketsWithErrors { get; }
	public abstract long OutputQueueLength { get; }
	public abstract long UnicastPacketsReceived { get; }
	public abstract long UnicastPacketsSent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_BytesReceived();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract long get_BytesSent();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract long get_IncomingPacketsDiscarded();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_IncomingPacketsWithErrors();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract long get_IncomingUnknownProtocolPackets();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract long get_NonUnicastPacketsReceived();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_NonUnicastPacketsSent();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_OutgoingPacketsDiscarded();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_OutgoingPacketsWithErrors();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract long get_OutputQueueLength();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract long get_UnicastPacketsReceived();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract long get_UnicastPacketsSent();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class IPv4InterfaceStatistics // TypeDefIndex: 6032
{
	// Properties
	public abstract long BytesReceived { get; }
	public abstract long BytesSent { get; }
	public abstract long IncomingPacketsDiscarded { get; }
	public abstract long IncomingPacketsWithErrors { get; }
	public abstract long IncomingUnknownProtocolPackets { get; }
	public abstract long NonUnicastPacketsReceived { get; }
	public abstract long NonUnicastPacketsSent { get; }
	public abstract long OutgoingPacketsDiscarded { get; }
	public abstract long OutgoingPacketsWithErrors { get; }
	public abstract long OutputQueueLength { get; }
	public abstract long UnicastPacketsReceived { get; }
	public abstract long UnicastPacketsSent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_BytesReceived();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract long get_BytesSent();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract long get_IncomingPacketsDiscarded();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_IncomingPacketsWithErrors();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract long get_IncomingUnknownProtocolPackets();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract long get_NonUnicastPacketsReceived();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_NonUnicastPacketsSent();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_OutgoingPacketsDiscarded();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_OutgoingPacketsWithErrors();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract long get_OutputQueueLength();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract long get_UnicastPacketsReceived();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract long get_UnicastPacketsSent();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal enum IcmpV4Type // TypeDefIndex: 6033
{
	// Fields
	public int value__; // 0x0
	public const IcmpV4Type ICMP4_ECHO_REPLY = 0;
	public const IcmpV4Type ICMP4_DST_UNREACH = 3;
	public const IcmpV4Type ICMP4_SOURCE_QUENCH = 4;
	public const IcmpV4Type ICMP4_TIME_EXCEEDED = 11;
	public const IcmpV4Type ICMP4_PARAM_PROB = 12;
	public const IcmpV4Type ICMP4_REDIRECT = 5;
	public const IcmpV4Type ICMP4_ECHO_REQUEST = 8;
	public const IcmpV4Type ICMP4_ROUTER_ADVERT = 9;
	public const IcmpV4Type ICMP4_ROUTER_SOLICIT = 10;
	public const IcmpV4Type ICMP4_TIMESTAMP_REQUEST = 13;
	public const IcmpV4Type ICMP4_TIMESTAMP_REPLY = 14;
	public const IcmpV4Type ICMP4_MASK_REQUEST = 17;
	public const IcmpV4Type ICMP4_MASK_REPLY = 18;
}

// Namespace: System.Net.NetworkInformation
internal enum IcmpV4Code // TypeDefIndex: 6034
{
	// Fields
	public int value__; // 0x0
	public const IcmpV4Code ICMP4_UNREACH_NET = 0;
	public const IcmpV4Code ICMP4_UNREACH_HOST = 1;
	public const IcmpV4Code ICMP4_UNREACH_PROTOCOL = 2;
	public const IcmpV4Code ICMP4_UNREACH_PORT = 3;
	public const IcmpV4Code ICMP4_UNREACH_FRAG_NEEDED = 4;
	public const IcmpV4Code ICMP4_UNREACH_SOURCEROUTE_FAILED = 5;
	public const IcmpV4Code ICMP4_UNREACH_NET_UNKNOWN = 6;
	public const IcmpV4Code ICMP4_UNREACH_HOST_UNKNOWN = 7;
	public const IcmpV4Code ICMP4_UNREACH_ISOLATED = 8;
	public const IcmpV4Code ICMP4_UNREACH_NET_ADMIN = 9;
	public const IcmpV4Code ICMP4_UNREACH_HOST_ADMIN = 10;
	public const IcmpV4Code ICMP4_UNREACH_NET_TOS = 11;
	public const IcmpV4Code ICMP4_UNREACH_HOST_TOS = 12;
	public const IcmpV4Code ICMP4_UNREACH_ADMIN = 13;
}

// Namespace: System.Net.NetworkInformation
public enum IPStatus // TypeDefIndex: 6035
{
	// Fields
	public int value__; // 0x0
	public const IPStatus Success = 0;
	public const IPStatus DestinationNetworkUnreachable = 11002;
	public const IPStatus DestinationHostUnreachable = 11003;
	public const IPStatus DestinationProtocolUnreachable = 11004;
	public const IPStatus DestinationPortUnreachable = 11005;
	public const IPStatus DestinationProhibited = 11004;
	public const IPStatus NoResources = 11006;
	public const IPStatus BadOption = 11007;
	public const IPStatus HardwareError = 11008;
	public const IPStatus PacketTooBig = 11009;
	public const IPStatus TimedOut = 11010;
	public const IPStatus BadRoute = 11012;
	public const IPStatus TtlExpired = 11013;
	public const IPStatus TtlReassemblyTimeExceeded = 11014;
	public const IPStatus ParameterProblem = 11015;
	public const IPStatus SourceQuench = 11016;
	public const IPStatus BadDestination = 11018;
	public const IPStatus DestinationUnreachable = 11040;
	public const IPStatus TimeExceeded = 11041;
	public const IPStatus BadHeader = 11042;
	public const IPStatus UnrecognizedNextHeader = 11043;
	public const IPStatus IcmpError = 11044;
	public const IPStatus DestinationScopeMismatch = 11045;
	public const IPStatus Unknown = -1;
}

// Namespace: System.Net.NetworkInformation
public abstract class IPv4InterfaceProperties // TypeDefIndex: 6036
{
	// Properties
	public abstract bool UsesWins { get; }
	public abstract bool IsDhcpEnabled { get; }
	public abstract bool IsAutomaticPrivateAddressingActive { get; }
	public abstract bool IsAutomaticPrivateAddressingEnabled { get; }
	public abstract int Index { get; }
	public abstract bool IsForwardingEnabled { get; }
	public abstract int Mtu { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_UsesWins();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsDhcpEnabled();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsAutomaticPrivateAddressingActive();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsAutomaticPrivateAddressingEnabled();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Index();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsForwardingEnabled();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_Mtu();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class IPv6InterfaceProperties // TypeDefIndex: 6037
{
	// Properties
	public abstract int Index { get; }
	public abstract int Mtu { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_Index();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_Mtu();

	// RVA: 0x21BE960 Offset: 0x21BDB60 VA: 0x1821BE960 Slot: 6
	public virtual long GetScopeId(ScopeLevel scopeLevel) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class IcmpV4Statistics // TypeDefIndex: 6038
{
	// Properties
	public abstract long AddressMaskRepliesReceived { get; }
	public abstract long AddressMaskRepliesSent { get; }
	public abstract long AddressMaskRequestsReceived { get; }
	public abstract long AddressMaskRequestsSent { get; }
	public abstract long DestinationUnreachableMessagesReceived { get; }
	public abstract long DestinationUnreachableMessagesSent { get; }
	public abstract long EchoRepliesReceived { get; }
	public abstract long EchoRepliesSent { get; }
	public abstract long EchoRequestsReceived { get; }
	public abstract long EchoRequestsSent { get; }
	public abstract long ErrorsReceived { get; }
	public abstract long ErrorsSent { get; }
	public abstract long MessagesReceived { get; }
	public abstract long MessagesSent { get; }
	public abstract long ParameterProblemsReceived { get; }
	public abstract long ParameterProblemsSent { get; }
	public abstract long RedirectsReceived { get; }
	public abstract long RedirectsSent { get; }
	public abstract long SourceQuenchesReceived { get; }
	public abstract long SourceQuenchesSent { get; }
	public abstract long TimeExceededMessagesReceived { get; }
	public abstract long TimeExceededMessagesSent { get; }
	public abstract long TimestampRepliesReceived { get; }
	public abstract long TimestampRepliesSent { get; }
	public abstract long TimestampRequestsReceived { get; }
	public abstract long TimestampRequestsSent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_AddressMaskRepliesReceived();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract long get_AddressMaskRepliesSent();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract long get_AddressMaskRequestsReceived();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_AddressMaskRequestsSent();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract long get_DestinationUnreachableMessagesReceived();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract long get_DestinationUnreachableMessagesSent();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_EchoRepliesReceived();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_EchoRepliesSent();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_EchoRequestsReceived();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract long get_EchoRequestsSent();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract long get_ErrorsReceived();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract long get_ErrorsSent();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract long get_MessagesReceived();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract long get_MessagesSent();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract long get_ParameterProblemsReceived();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract long get_ParameterProblemsSent();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract long get_RedirectsReceived();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract long get_RedirectsSent();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract long get_SourceQuenchesReceived();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract long get_SourceQuenchesSent();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract long get_TimeExceededMessagesReceived();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract long get_TimeExceededMessagesSent();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract long get_TimestampRepliesReceived();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract long get_TimestampRepliesSent();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract long get_TimestampRequestsReceived();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract long get_TimestampRequestsSent();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class IcmpV6Statistics // TypeDefIndex: 6039
{
	// Properties
	public abstract long DestinationUnreachableMessagesReceived { get; }
	public abstract long DestinationUnreachableMessagesSent { get; }
	public abstract long EchoRepliesReceived { get; }
	public abstract long EchoRepliesSent { get; }
	public abstract long EchoRequestsReceived { get; }
	public abstract long EchoRequestsSent { get; }
	public abstract long ErrorsReceived { get; }
	public abstract long ErrorsSent { get; }
	public abstract long MembershipQueriesReceived { get; }
	public abstract long MembershipQueriesSent { get; }
	public abstract long MembershipReductionsReceived { get; }
	public abstract long MembershipReductionsSent { get; }
	public abstract long MembershipReportsReceived { get; }
	public abstract long MembershipReportsSent { get; }
	public abstract long MessagesReceived { get; }
	public abstract long MessagesSent { get; }
	public abstract long NeighborAdvertisementsReceived { get; }
	public abstract long NeighborAdvertisementsSent { get; }
	public abstract long NeighborSolicitsReceived { get; }
	public abstract long NeighborSolicitsSent { get; }
	public abstract long PacketTooBigMessagesReceived { get; }
	public abstract long PacketTooBigMessagesSent { get; }
	public abstract long ParameterProblemsReceived { get; }
	public abstract long ParameterProblemsSent { get; }
	public abstract long RedirectsReceived { get; }
	public abstract long RedirectsSent { get; }
	public abstract long RouterAdvertisementsReceived { get; }
	public abstract long RouterAdvertisementsSent { get; }
	public abstract long RouterSolicitsReceived { get; }
	public abstract long RouterSolicitsSent { get; }
	public abstract long TimeExceededMessagesReceived { get; }
	public abstract long TimeExceededMessagesSent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_DestinationUnreachableMessagesReceived();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract long get_DestinationUnreachableMessagesSent();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract long get_EchoRepliesReceived();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_EchoRepliesSent();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract long get_EchoRequestsReceived();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract long get_EchoRequestsSent();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_ErrorsReceived();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_ErrorsSent();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_MembershipQueriesReceived();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract long get_MembershipQueriesSent();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract long get_MembershipReductionsReceived();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract long get_MembershipReductionsSent();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract long get_MembershipReportsReceived();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract long get_MembershipReportsSent();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract long get_MessagesReceived();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract long get_MessagesSent();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract long get_NeighborAdvertisementsReceived();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract long get_NeighborAdvertisementsSent();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract long get_NeighborSolicitsReceived();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract long get_NeighborSolicitsSent();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract long get_PacketTooBigMessagesReceived();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract long get_PacketTooBigMessagesSent();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract long get_ParameterProblemsReceived();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract long get_ParameterProblemsSent();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract long get_RedirectsReceived();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract long get_RedirectsSent();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract long get_RouterAdvertisementsReceived();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract long get_RouterAdvertisementsSent();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract long get_RouterSolicitsReceived();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract long get_RouterSolicitsSent();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract long get_TimeExceededMessagesReceived();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract long get_TimeExceededMessagesSent();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class MulticastIPAddressInformation : IPAddressInformation // TypeDefIndex: 6040
{
	// Properties
	public abstract long AddressPreferredLifetime { get; }
	public abstract long AddressValidLifetime { get; }
	public abstract long DhcpLeaseLifetime { get; }
	public abstract DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }
	public abstract PrefixOrigin PrefixOrigin { get; }
	public abstract SuffixOrigin SuffixOrigin { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_AddressPreferredLifetime();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract long get_AddressValidLifetime();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract long get_DhcpLeaseLifetime();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DuplicateAddressDetectionState get_DuplicateAddressDetectionState();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract PrefixOrigin get_PrefixOrigin();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract SuffixOrigin get_SuffixOrigin();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
[DefaultMember("Item")]
public class MulticastIPAddressInformationCollection : ICollection<MulticastIPAddressInformation>, IEnumerable<MulticastIPAddressInformation>, IEnumerable // TypeDefIndex: 6041
{
	// Fields
	private Collection<MulticastIPAddressInformation> addresses; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual MulticastIPAddressInformation Item { get; }

	// Methods

	// RVA: 0x21BEC40 Offset: 0x21BDE40 VA: 0x1821BEC40
	protected internal void .ctor() { }

	// RVA: 0x21BEAC0 Offset: 0x21BDCC0 VA: 0x1821BEAC0 Slot: 13
	public virtual void CopyTo(MulticastIPAddressInformation[] array, int offset) { }

	// RVA: 0x21BECB0 Offset: 0x21BDEB0 VA: 0x1821BECB0 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 15
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x21BE9A0 Offset: 0x21BDBA0 VA: 0x1821BE9A0 Slot: 16
	public virtual void Add(MulticastIPAddressInformation address) { }

	// RVA: 0x21BEB80 Offset: 0x21BDD80 VA: 0x1821BEB80
	internal void InternalAdd(MulticastIPAddressInformation address) { }

	// RVA: 0x21BEA60 Offset: 0x21BDC60 VA: 0x1821BEA60 Slot: 17
	public virtual bool Contains(MulticastIPAddressInformation address) { }

	// RVA: 0x7F68D0 Offset: 0x7F5AD0 VA: 0x1807F68D0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x21BEB30 Offset: 0x21BDD30 VA: 0x1821BEB30 Slot: 18
	public virtual IEnumerator<MulticastIPAddressInformation> GetEnumerator() { }

	// RVA: 0x21BED00 Offset: 0x21BDF00 VA: 0x1821BED00 Slot: 19
	public virtual MulticastIPAddressInformation get_Item(int index) { }

	// RVA: 0x21BEBE0 Offset: 0x21BDDE0 VA: 0x1821BEBE0 Slot: 20
	public virtual bool Remove(MulticastIPAddressInformation address) { }

	// RVA: 0x21BEA00 Offset: 0x21BDC00 VA: 0x1821BEA00 Slot: 21
	public virtual void Clear() { }
}

// Namespace: System.Net.NetworkInformation
[Flags]
internal enum StartIPOptions // TypeDefIndex: 6042
{
	// Fields
	public int value__; // 0x0
	public const StartIPOptions Both = 3;
	public const StartIPOptions None = 0;
	public const StartIPOptions StartIPv4 = 1;
	public const StartIPOptions StartIPv6 = 2;
}

// Namespace: System.Net.NetworkInformation
public class NetworkAvailabilityEventArgs : EventArgs // TypeDefIndex: 6043
{
	// Fields
	private bool isAvailable; // 0x10

	// Properties
	public bool IsAvailable { get; }

	// Methods

	// RVA: 0x21BED90 Offset: 0x21BDF90 VA: 0x1821BED90
	internal void .ctor(bool isAvailable) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsAvailable() { }

	// RVA: 0x21BED60 Offset: 0x21BDF60 VA: 0x1821BED60
	internal void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public sealed class NetworkAddressChangedEventHandler : MulticastDelegate // TypeDefIndex: 6044
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net.NetworkInformation
public sealed class NetworkAvailabilityChangedEventHandler : MulticastDelegate // TypeDefIndex: 6045
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, NetworkAvailabilityEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, NetworkAvailabilityEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net.NetworkInformation
[Serializable]
public class NetworkInformationException : Win32Exception // TypeDefIndex: 6046
{
	// Properties
	public override int ErrorCode { get; }

	// Methods

	// RVA: 0x21BEDF0 Offset: 0x21BDFF0 VA: 0x1821BEDF0
	public void .ctor() { }

	// RVA: 0x215DAA0 Offset: 0x215CCA0 VA: 0x18215DAA0
	public void .ctor(int errorCode) { }

	// RVA: 0x215DAA0 Offset: 0x215CCA0 VA: 0x18215DAA0
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x215DAB0 Offset: 0x215CCB0 VA: 0x18215DAB0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210 Slot: 18
	public override int get_ErrorCode() { }
}

// Namespace: System.Net.NetworkInformation
[Flags]
public enum NetworkInformationAccess // TypeDefIndex: 6047
{
	// Fields
	public int value__; // 0x0
	public const NetworkInformationAccess None = 0;
	public const NetworkInformationAccess Read = 1;
	public const NetworkInformationAccess Ping = 4;
}

// Namespace: System.Net.NetworkInformation
[Usage(109, AllowMultiple = True, Inherited = False)]
[Serializable]
public sealed class NetworkInformationPermissionAttribute : CodeAccessSecurityAttribute // TypeDefIndex: 6048
{
	// Fields
	private const string strAccess = "Access";
	private string access; // 0x18

	// Properties
	public string Access { get; set; }

	// Methods

	// RVA: 0x216DCF0 Offset: 0x216CEF0 VA: 0x18216DCF0
	public void .ctor(SecurityAction action) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Access() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Access(string value) { }

	// RVA: 0x21BEE50 Offset: 0x21BE050 VA: 0x1821BEE50 Slot: 7
	public override IPermission CreatePermission() { }
}

// Namespace: System.Net.NetworkInformation
[Serializable]
public sealed class NetworkInformationPermission : CodeAccessPermission, IUnrestrictedPermission // TypeDefIndex: 6049
{
	// Fields
	private NetworkInformationAccess access; // 0x10
	private bool unrestricted; // 0x14

	// Properties
	public NetworkInformationAccess Access { get; }

	// Methods

	// RVA: 0x21BFC20 Offset: 0x21BEE20 VA: 0x1821BFC20
	public void .ctor(PermissionState state) { }

	// RVA: 0x21BFBF0 Offset: 0x21BEDF0 VA: 0x1821BFBF0
	internal void .ctor(bool unrestricted) { }

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(NetworkInformationAccess access) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public NetworkInformationAccess get_Access() { }

	// RVA: 0x21BF080 Offset: 0x21BE280 VA: 0x1821BF080
	public void AddPermission(NetworkInformationAccess access) { }

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30 Slot: 14
	public bool IsUnrestricted() { }

	// RVA: 0x21BF090 Offset: 0x21BE290 VA: 0x1821BF090 Slot: 7
	public override IPermission Copy() { }

	// RVA: 0x21BFAA0 Offset: 0x21BECA0 VA: 0x1821BFAA0 Slot: 13
	public override IPermission Union(IPermission target) { }

	// RVA: 0x21BF5A0 Offset: 0x21BE7A0 VA: 0x1821BF5A0 Slot: 10
	public override IPermission Intersect(IPermission target) { }

	// RVA: 0x21BF6D0 Offset: 0x21BE8D0 VA: 0x1821BF6D0 Slot: 11
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x21BF120 Offset: 0x21BE320 VA: 0x1821BF120 Slot: 9
	public override void FromXml(SecurityElement securityElement) { }

	// RVA: 0x21BF7C0 Offset: 0x21BE9C0 VA: 0x1821BF7C0 Slot: 12
	public override SecurityElement ToXml() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class NetworkInterface // TypeDefIndex: 6050
{
	// Properties
	public static int LoopbackInterfaceIndex { get; }
	public static int IPv6LoopbackInterfaceIndex { get; }
	public virtual string Id { get; }
	public virtual string Name { get; }
	public virtual string Description { get; }
	public virtual OperationalStatus OperationalStatus { get; }
	public virtual long Speed { get; }
	public virtual bool IsReceiveOnly { get; }
	public virtual bool SupportsMulticast { get; }
	public virtual NetworkInterfaceType NetworkInterfaceType { get; }

	// Methods

	// RVA: 0x21BFC70 Offset: 0x21BEE70 VA: 0x1821BFC70
	public static NetworkInterface[] GetAllNetworkInterfaces() { }

	// RVA: 0x21BFD70 Offset: 0x21BEF70 VA: 0x1821BFD70
	public static bool GetIsNetworkAvailable() { }

	// RVA: 0x21BFF30 Offset: 0x21BF130 VA: 0x1821BFF30
	public static int get_LoopbackInterfaceIndex() { }

	// RVA: 0x21BFE70 Offset: 0x21BF070 VA: 0x1821BFE70
	public static int get_IPv6LoopbackInterfaceIndex() { }

	// RVA: 0x21BFEB0 Offset: 0x21BF0B0 VA: 0x1821BFEB0 Slot: 4
	public virtual string get_Id() { }

	// RVA: 0x21BFF70 Offset: 0x21BF170 VA: 0x1821BFF70 Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x21BFE30 Offset: 0x21BF030 VA: 0x1821BFE30 Slot: 6
	public virtual string get_Description() { }

	// RVA: 0x21BFCB0 Offset: 0x21BEEB0 VA: 0x1821BFCB0 Slot: 7
	public virtual IPInterfaceProperties GetIPProperties() { }

	// RVA: 0x21BFD30 Offset: 0x21BEF30 VA: 0x1821BFD30 Slot: 8
	public virtual IPv4InterfaceStatistics GetIPv4Statistics() { }

	// RVA: 0x21BFCF0 Offset: 0x21BEEF0 VA: 0x1821BFCF0 Slot: 9
	public virtual IPInterfaceStatistics GetIPStatistics() { }

	// RVA: 0x21BFFF0 Offset: 0x21BF1F0 VA: 0x1821BFFF0 Slot: 10
	public virtual OperationalStatus get_OperationalStatus() { }

	// RVA: 0x21C0030 Offset: 0x21BF230 VA: 0x1821C0030 Slot: 11
	public virtual long get_Speed() { }

	// RVA: 0x21BFEF0 Offset: 0x21BF0F0 VA: 0x1821BFEF0 Slot: 12
	public virtual bool get_IsReceiveOnly() { }

	// RVA: 0x21C0070 Offset: 0x21BF270 VA: 0x1821C0070 Slot: 13
	public virtual bool get_SupportsMulticast() { }

	// RVA: 0x21BFDB0 Offset: 0x21BEFB0 VA: 0x1821BFDB0 Slot: 14
	public virtual PhysicalAddress GetPhysicalAddress() { }

	// RVA: 0x21BFFB0 Offset: 0x21BF1B0 VA: 0x1821BFFB0 Slot: 15
	public virtual NetworkInterfaceType get_NetworkInterfaceType() { }

	// RVA: 0x21BFDF0 Offset: 0x21BEFF0 VA: 0x1821BFDF0 Slot: 16
	public virtual bool Supports(NetworkInterfaceComponent networkInterfaceComponent) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public enum NetworkInterfaceComponent // TypeDefIndex: 6051
{
	// Fields
	public int value__; // 0x0
	public const NetworkInterfaceComponent IPv4 = 0;
	public const NetworkInterfaceComponent IPv6 = 1;
}

// Namespace: System.Net.NetworkInformation
public enum OperationalStatus // TypeDefIndex: 6052
{
	// Fields
	public int value__; // 0x0
	public const OperationalStatus Up = 1;
	public const OperationalStatus Down = 2;
	public const OperationalStatus Testing = 3;
	public const OperationalStatus Unknown = 4;
	public const OperationalStatus Dormant = 5;
	public const OperationalStatus NotPresent = 6;
	public const OperationalStatus LowerLayerDown = 7;
}

// Namespace: System.Net.NetworkInformation
public class PhysicalAddress // TypeDefIndex: 6053
{
	// Fields
	private byte[] address; // 0x10
	private bool changed; // 0x18
	private int hash; // 0x1C
	public static readonly PhysicalAddress None; // 0x0

	// Methods

	// RVA: 0x8B34D0 Offset: 0x8B26D0 VA: 0x1808B34D0
	public void .ctor(byte[] address) { }

	// RVA: 0x21C0230 Offset: 0x21BF430 VA: 0x1821C0230 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21C00B0 Offset: 0x21BF2B0 VA: 0x1821C00B0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x21C0720 Offset: 0x21BF920 VA: 0x1821C0720 Slot: 3
	public override string ToString() { }

	// RVA: 0x21C01A0 Offset: 0x21BF3A0 VA: 0x1821C01A0
	public byte[] GetAddressBytes() { }

	// RVA: 0x21C0360 Offset: 0x21BF560 VA: 0x1821C0360
	public static PhysicalAddress Parse(string address) { }

	// RVA: 0x21C0840 Offset: 0x21BFA40 VA: 0x1821C0840
	private static void .cctor() { }
}

// Namespace: System.Net.NetworkInformation
public class PingOptions // TypeDefIndex: 6054
{
	// Fields
	private const int DontFragmentFlag = 2;
	private int ttl; // 0x10
	private bool dontFragment; // 0x14

	// Properties
	public int Ttl { get; set; }
	public bool DontFragment { get; set; }

	// Methods

	// RVA: 0x21DCED0 Offset: 0x21DC0D0 VA: 0x1821DCED0
	public void .ctor(int ttl, bool dontFragment) { }

	// RVA: 0x21DCEC0 Offset: 0x21DC0C0 VA: 0x1821DCEC0
	public void .ctor() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_Ttl() { }

	// RVA: 0x21DCF60 Offset: 0x21DC160 VA: 0x1821DCF60
	public void set_Ttl(int value) { }

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	public bool get_DontFragment() { }

	// RVA: 0x41AC60 Offset: 0x419E60 VA: 0x18041AC60
	public void set_DontFragment(bool value) { }
}

// Namespace: System.Net.NetworkInformation
public class PingReply // TypeDefIndex: 6055
{
	// Fields
	private IPAddress address; // 0x10
	private PingOptions options; // 0x18
	private IPStatus ipStatus; // 0x20
	private long rtt; // 0x28
	private byte[] buffer; // 0x30

	// Properties
	public IPStatus Status { get; }
	public IPAddress Address { get; }
	public long RoundtripTime { get; }
	public PingOptions Options { get; }
	public byte[] Buffer { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x21DD0C0 Offset: 0x21DC2C0 VA: 0x1821DD0C0
	internal void .ctor(IPStatus ipStatus) { }

	// RVA: 0x21DD120 Offset: 0x21DC320 VA: 0x1821DD120
	internal void .ctor(byte[] data, int dataLength, IPAddress address, int time) { }

	// RVA: 0x21DD060 Offset: 0x21DC260 VA: 0x1821DD060
	internal void .ctor(IPAddress address, byte[] buffer, PingOptions options, long roundtripTime, IPStatus status) { }

	// RVA: 0x21DCFD0 Offset: 0x21DC1D0 VA: 0x1821DCFD0
	private IPStatus GetIPStatus(IcmpV4Type type, IcmpV4Code code) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public IPStatus get_Status() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IPAddress get_Address() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public long get_RoundtripTime() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public PingOptions get_Options() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public byte[] get_Buffer() { }
}

// Namespace: System.Net.NetworkInformation
public enum PrefixOrigin // TypeDefIndex: 6056
{
	// Fields
	public int value__; // 0x0
	public const PrefixOrigin Other = 0;
	public const PrefixOrigin Manual = 1;
	public const PrefixOrigin WellKnown = 2;
	public const PrefixOrigin Dhcp = 3;
	public const PrefixOrigin RouterAdvertisement = 4;
}

// Namespace: System.Net.NetworkInformation
public enum ScopeLevel // TypeDefIndex: 6057
{
	// Fields
	public int value__; // 0x0
	public const ScopeLevel None = 0;
	public const ScopeLevel Interface = 1;
	public const ScopeLevel Link = 2;
	public const ScopeLevel Subnet = 3;
	public const ScopeLevel Admin = 4;
	public const ScopeLevel Site = 5;
	public const ScopeLevel Organization = 8;
	public const ScopeLevel Global = 14;
}

// Namespace: System.Net.NetworkInformation
public enum SuffixOrigin // TypeDefIndex: 6058
{
	// Fields
	public int value__; // 0x0
	public const SuffixOrigin Other = 0;
	public const SuffixOrigin Manual = 1;
	public const SuffixOrigin WellKnown = 2;
	public const SuffixOrigin OriginDhcp = 3;
	public const SuffixOrigin LinkLayerAddress = 4;
	public const SuffixOrigin Random = 5;
}

// Namespace: System.Net.NetworkInformation
internal class SystemGatewayIPAddressInformation : GatewayIPAddressInformation // TypeDefIndex: 6059
{
	// Fields
	private IPAddress address; // 0x10

	// Properties
	public override IPAddress Address { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	internal void .ctor(IPAddress address) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public override IPAddress get_Address() { }

	// RVA: 0x21F71D0 Offset: 0x21F63D0 VA: 0x1821F71D0
	internal static GatewayIPAddressInformationCollection ToGatewayIpAddressInformationCollection(IPAddressCollection addresses) { }
}

// Namespace: System.Net.NetworkInformation
internal class SystemIPAddressInformation : IPAddressInformation // TypeDefIndex: 6060
{
	// Fields
	private IPAddress address; // 0x10
	internal bool transient; // 0x18
	internal bool dnsEligible; // 0x19

	// Properties
	public override IPAddress Address { get; }
	public override bool IsTransient { get; }
	public override bool IsDnsEligible { get; }

	// Methods

	// RVA: 0x21F73F0 Offset: 0x21F65F0 VA: 0x1821F73F0
	public void .ctor(IPAddress address, bool isDnsEligible, bool isTransient) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public override IPAddress get_Address() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20 Slot: 6
	public override bool get_IsTransient() { }

	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40 Slot: 5
	public override bool get_IsDnsEligible() { }
}

// Namespace: System.Net.NetworkInformation
internal class SystemMulticastIPAddressInformation : MulticastIPAddressInformation // TypeDefIndex: 6061
{
	// Fields
	private SystemIPAddressInformation innerInfo; // 0x10

	// Properties
	public override IPAddress Address { get; }
	public override bool IsTransient { get; }
	public override bool IsDnsEligible { get; }
	public override PrefixOrigin PrefixOrigin { get; }
	public override SuffixOrigin SuffixOrigin { get; }
	public override DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }
	public override long AddressValidLifetime { get; }
	public override long AddressPreferredLifetime { get; }
	public override long DhcpLeaseLifetime { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(SystemIPAddressInformation addressInfo) { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160 Slot: 4
	public override IPAddress get_Address() { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10 Slot: 6
	public override bool get_IsTransient() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680 Slot: 5
	public override bool get_IsDnsEligible() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 11
	public override PrefixOrigin get_PrefixOrigin() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	public override SuffixOrigin get_SuffixOrigin() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	public override DuplicateAddressDetectionState get_DuplicateAddressDetectionState() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public override long get_AddressValidLifetime() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public override long get_AddressPreferredLifetime() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public override long get_DhcpLeaseLifetime() { }

	// RVA: 0x21F7440 Offset: 0x21F6640 VA: 0x1821F7440
	internal static MulticastIPAddressInformationCollection ToMulticastIpAddressInformationCollection(IPAddressInformationCollection addresses) { }
}

// Namespace: System.Net.NetworkInformation
internal class SystemTcpConnectionInformation : TcpConnectionInformation // TypeDefIndex: 6062
{
	// Fields
	private IPEndPoint localEndPoint; // 0x10
	private IPEndPoint remoteEndPoint; // 0x18
	private TcpState state; // 0x20

	// Properties
	public override TcpState State { get; }
	public override IPEndPoint LocalEndPoint { get; }
	public override IPEndPoint RemoteEndPoint { get; }

	// Methods

	// RVA: 0xB18200 Offset: 0xB17400 VA: 0x180B18200
	public void .ctor(IPEndPoint local, IPEndPoint remote, TcpState state) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 6
	public override TcpState get_State() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public override IPEndPoint get_LocalEndPoint() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public override IPEndPoint get_RemoteEndPoint() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class TcpConnectionInformation // TypeDefIndex: 6063
{
	// Properties
	public abstract IPEndPoint LocalEndPoint { get; }
	public abstract IPEndPoint RemoteEndPoint { get; }
	public abstract TcpState State { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IPEndPoint get_LocalEndPoint();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IPEndPoint get_RemoteEndPoint();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TcpState get_State();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public enum TcpState // TypeDefIndex: 6064
{
	// Fields
	public int value__; // 0x0
	public const TcpState Unknown = 0;
	public const TcpState Closed = 1;
	public const TcpState Listen = 2;
	public const TcpState SynSent = 3;
	public const TcpState SynReceived = 4;
	public const TcpState Established = 5;
	public const TcpState FinWait1 = 6;
	public const TcpState FinWait2 = 7;
	public const TcpState CloseWait = 8;
	public const TcpState Closing = 9;
	public const TcpState LastAck = 10;
	public const TcpState TimeWait = 11;
	public const TcpState DeleteTcb = 12;
}

// Namespace: System.Net.NetworkInformation
public abstract class TcpStatistics // TypeDefIndex: 6065
{
	// Properties
	public abstract long ConnectionsAccepted { get; }
	public abstract long ConnectionsInitiated { get; }
	public abstract long CumulativeConnections { get; }
	public abstract long CurrentConnections { get; }
	public abstract long ErrorsReceived { get; }
	public abstract long FailedConnectionAttempts { get; }
	public abstract long MaximumConnections { get; }
	public abstract long MaximumTransmissionTimeout { get; }
	public abstract long MinimumTransmissionTimeout { get; }
	public abstract long ResetConnections { get; }
	public abstract long SegmentsReceived { get; }
	public abstract long SegmentsResent { get; }
	public abstract long SegmentsSent { get; }
	public abstract long ResetsSent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_ConnectionsAccepted();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract long get_ConnectionsInitiated();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract long get_CumulativeConnections();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_CurrentConnections();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract long get_ErrorsReceived();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract long get_FailedConnectionAttempts();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_MaximumConnections();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_MaximumTransmissionTimeout();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_MinimumTransmissionTimeout();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract long get_ResetConnections();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract long get_SegmentsReceived();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract long get_SegmentsResent();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract long get_SegmentsSent();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract long get_ResetsSent();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class UdpStatistics // TypeDefIndex: 6066
{
	// Properties
	public abstract long DatagramsReceived { get; }
	public abstract long DatagramsSent { get; }
	public abstract long IncomingDatagramsDiscarded { get; }
	public abstract long IncomingDatagramsWithErrors { get; }
	public abstract int UdpListeners { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_DatagramsReceived();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract long get_DatagramsSent();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract long get_IncomingDatagramsDiscarded();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_IncomingDatagramsWithErrors();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_UdpListeners();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public abstract class UnicastIPAddressInformation : IPAddressInformation // TypeDefIndex: 6067
{
	// Properties
	public abstract long AddressPreferredLifetime { get; }
	public abstract long AddressValidLifetime { get; }
	public abstract long DhcpLeaseLifetime { get; }
	public abstract DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }
	public abstract PrefixOrigin PrefixOrigin { get; }
	public abstract SuffixOrigin SuffixOrigin { get; }
	public abstract IPAddress IPv4Mask { get; }
	public virtual int PrefixLength { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_AddressPreferredLifetime();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract long get_AddressValidLifetime();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract long get_DhcpLeaseLifetime();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DuplicateAddressDetectionState get_DuplicateAddressDetectionState();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract PrefixOrigin get_PrefixOrigin();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract SuffixOrigin get_SuffixOrigin();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IPAddress get_IPv4Mask();

	// RVA: 0x21F8150 Offset: 0x21F7350 VA: 0x1821F8150 Slot: 14
	public virtual int get_PrefixLength() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
[DefaultMember("Item")]
public class UnicastIPAddressInformationCollection : ICollection<UnicastIPAddressInformation>, IEnumerable<UnicastIPAddressInformation>, IEnumerable // TypeDefIndex: 6068
{
	// Fields
	private Collection<UnicastIPAddressInformation> addresses; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual UnicastIPAddressInformation Item { get; }

	// Methods

	// RVA: 0x21F8030 Offset: 0x21F7230 VA: 0x1821F8030
	protected internal void .ctor() { }

	// RVA: 0x21F7EB0 Offset: 0x21F70B0 VA: 0x1821F7EB0 Slot: 13
	public virtual void CopyTo(UnicastIPAddressInformation[] array, int offset) { }

	// RVA: 0x21F80A0 Offset: 0x21F72A0 VA: 0x1821F80A0 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 15
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x21F7D90 Offset: 0x21F6F90 VA: 0x1821F7D90 Slot: 16
	public virtual void Add(UnicastIPAddressInformation address) { }

	// RVA: 0x21F7F70 Offset: 0x21F7170 VA: 0x1821F7F70
	internal void InternalAdd(UnicastIPAddressInformation address) { }

	// RVA: 0x21F7E50 Offset: 0x21F7050 VA: 0x1821F7E50 Slot: 17
	public virtual bool Contains(UnicastIPAddressInformation address) { }

	// RVA: 0x7F68D0 Offset: 0x7F5AD0 VA: 0x1807F68D0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x21F7F20 Offset: 0x21F7120 VA: 0x1821F7F20 Slot: 18
	public virtual IEnumerator<UnicastIPAddressInformation> GetEnumerator() { }

	// RVA: 0x21F80F0 Offset: 0x21F72F0 VA: 0x1821F80F0 Slot: 19
	public virtual UnicastIPAddressInformation get_Item(int index) { }

	// RVA: 0x21F7FD0 Offset: 0x21F71D0 VA: 0x1821F7FD0 Slot: 20
	public virtual bool Remove(UnicastIPAddressInformation address) { }

	// RVA: 0x21F7DF0 Offset: 0x21F6FF0 VA: 0x1821F7DF0 Slot: 21
	public virtual void Clear() { }
}

// Namespace: System.Net.NetworkInformation
public enum NetworkInterfaceType // TypeDefIndex: 6069
{
	// Fields
	public int value__; // 0x0
	public const NetworkInterfaceType Unknown = 1;
	public const NetworkInterfaceType Ethernet = 6;
	public const NetworkInterfaceType TokenRing = 9;
	public const NetworkInterfaceType Fddi = 15;
	public const NetworkInterfaceType BasicIsdn = 20;
	public const NetworkInterfaceType PrimaryIsdn = 21;
	public const NetworkInterfaceType Ppp = 23;
	public const NetworkInterfaceType Loopback = 24;
	public const NetworkInterfaceType Ethernet3Megabit = 26;
	public const NetworkInterfaceType Slip = 28;
	public const NetworkInterfaceType Atm = 37;
	public const NetworkInterfaceType GenericModem = 48;
	public const NetworkInterfaceType FastEthernetT = 62;
	public const NetworkInterfaceType Isdn = 63;
	public const NetworkInterfaceType FastEthernetFx = 69;
	public const NetworkInterfaceType Wireless80211 = 71;
	public const NetworkInterfaceType AsymmetricDsl = 94;
	public const NetworkInterfaceType RateAdaptDsl = 95;
	public const NetworkInterfaceType SymmetricDsl = 96;
	public const NetworkInterfaceType VeryHighSpeedDsl = 97;
	public const NetworkInterfaceType IPOverAtm = 114;
	public const NetworkInterfaceType GigabitEthernet = 117;
	public const NetworkInterfaceType Tunnel = 131;
	public const NetworkInterfaceType MultiRateSymmetricDsl = 143;
	public const NetworkInterfaceType HighPerformanceSerialBus = 144;
	public const NetworkInterfaceType Wman = 237;
	public const NetworkInterfaceType Wwanpp = 243;
	public const NetworkInterfaceType Wwanpp2 = 244;
}

// Namespace: System.Net.NetworkInformation
public enum NetBiosNodeType // TypeDefIndex: 6070
{
	// Fields
	public int value__; // 0x0
	public const NetBiosNodeType Unknown = 0;
	public const NetBiosNodeType Broadcast = 1;
	public const NetBiosNodeType Peer2Peer = 2;
	public const NetBiosNodeType Mixed = 4;
	public const NetBiosNodeType Hybrid = 8;
}

// Namespace: System.Net.NetworkInformation
[Serializable]
public class PingException : InvalidOperationException // TypeDefIndex: 6071
{
	// Methods

	// RVA: 0x2161670 Offset: 0x2160870 VA: 0x182161670
	internal void .ctor() { }

	// RVA: 0x15A17F0 Offset: 0x15A09F0 VA: 0x1815A17F0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2161680 Offset: 0x2160880 VA: 0x182161680
	public void .ctor(string message) { }

	// RVA: 0x21DCEB0 Offset: 0x21DC0B0 VA: 0x1821DCEB0
	public void .ctor(string message, Exception innerException) { }
}

// Namespace: System.Net.NetworkInformation
internal static class IPGlobalPropertiesFactoryPal // TypeDefIndex: 6072
{
	// Methods

	// RVA: 0x21D55C0 Offset: 0x21D47C0 VA: 0x1821D55C0
	public static IPGlobalProperties Create() { }
}

// Namespace: System.Net.NetworkInformation
internal interface INetworkChange : IDisposable // TypeDefIndex: 6073
{
	// Properties
	public abstract bool HasRegisteredEvents { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_NetworkAddressChanged(NetworkAddressChangedEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_NetworkAddressChanged(NetworkAddressChangedEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_NetworkAvailabilityChanged(NetworkAvailabilityChangedEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_NetworkAvailabilityChanged(NetworkAvailabilityChangedEventHandler value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_HasRegisteredEvents();
}

// Namespace: System.Net.NetworkInformation
public sealed class NetworkChange // TypeDefIndex: 6074
{
	// Fields
	private static INetworkChange networkChange; // 0x0

	// Properties
	private static bool IsWindows { get; }

	// Methods

	// RVA: 0x21D9270 Offset: 0x21D8470 VA: 0x1821D9270
	public static void add_NetworkAddressChanged(NetworkAddressChangedEventHandler value) { }

	// RVA: 0x21D94C0 Offset: 0x21D86C0 VA: 0x1821D94C0
	public static void remove_NetworkAddressChanged(NetworkAddressChangedEventHandler value) { }

	// RVA: 0x21D9390 Offset: 0x21D8590 VA: 0x1821D9390
	public static void add_NetworkAvailabilityChanged(NetworkAvailabilityChangedEventHandler value) { }

	// RVA: 0x21D95F0 Offset: 0x21D87F0 VA: 0x1821D95F0
	public static void remove_NetworkAvailabilityChanged(NetworkAvailabilityChangedEventHandler value) { }

	// RVA: 0x21D9050 Offset: 0x21D8250 VA: 0x1821D9050
	private static void MaybeCreate() { }

	// RVA: 0x1768DB0 Offset: 0x1767FB0 VA: 0x181768DB0
	private static bool get_IsWindows() { }

	// RVA: 0x21D9190 Offset: 0x21D8390 VA: 0x1821D9190
	private static void MaybeDispose() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	[EditorBrowsable(1)]
	// RVA: 0x21D9240 Offset: 0x21D8440 VA: 0x1821D9240
	public static void RegisterNetworkChange(NetworkChange nc) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
private sealed class MacNetworkChange.SCNetworkReachabilityCallback : MulticastDelegate // TypeDefIndex: 6075
{
	// Methods

	// RVA: 0x4496C0 Offset: 0x4488C0 VA: 0x1804496C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr target, MacNetworkChange.NetworkReachabilityFlags flags, IntPtr info) { }

	// RVA: 0x21E1C60 Offset: 0x21E0E60 VA: 0x1821E1C60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr target, MacNetworkChange.NetworkReachabilityFlags flags, IntPtr info, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private struct MacNetworkChange.sockaddr_in // TypeDefIndex: 6076
{
	// Fields
	public byte sin_len; // 0x0
	public byte sin_family; // 0x1

	// Methods

	// RVA: 0x21FFEA0 Offset: 0x21FF0A0 VA: 0x1821FFEA0
	public static MacNetworkChange.sockaddr_in Create() { }
}

// Namespace: 
private struct MacNetworkChange.SCNetworkReachabilityContext // TypeDefIndex: 6077
{
	// Fields
	public IntPtr version; // 0x0
	public IntPtr info; // 0x8
	public IntPtr retain; // 0x10
	public IntPtr release; // 0x18
	public IntPtr copyDescription; // 0x20
}

// Namespace: 
[Flags]
private enum MacNetworkChange.NetworkReachabilityFlags // TypeDefIndex: 6078
{
	// Fields
	public int value__; // 0x0
	public const MacNetworkChange.NetworkReachabilityFlags None = 0;
	public const MacNetworkChange.NetworkReachabilityFlags TransientConnection = 1;
	public const MacNetworkChange.NetworkReachabilityFlags Reachable = 2;
	public const MacNetworkChange.NetworkReachabilityFlags ConnectionRequired = 4;
	public const MacNetworkChange.NetworkReachabilityFlags ConnectionOnTraffic = 8;
	public const MacNetworkChange.NetworkReachabilityFlags InterventionRequired = 16;
	public const MacNetworkChange.NetworkReachabilityFlags ConnectionOnDemand = 32;
	public const MacNetworkChange.NetworkReachabilityFlags IsLocalAddress = 65536;
	public const MacNetworkChange.NetworkReachabilityFlags IsDirect = 131072;
	public const MacNetworkChange.NetworkReachabilityFlags IsWWAN = 262144;
	public const MacNetworkChange.NetworkReachabilityFlags ConnectionAutomatic = 8;
}

// Namespace: System.Net.NetworkInformation
internal sealed class MacNetworkChange : INetworkChange, IDisposable // TypeDefIndex: 6079
{
	// Fields
	private const string DL_LIB = "/usr/lib/libSystem.dylib";
	private const string CORE_SERVICES_LIB = "/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration";
	private const string CORE_FOUNDATION_LIB = "/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation";
	private IntPtr handle; // 0x10
	private IntPtr runLoopMode; // 0x18
	private MacNetworkChange.SCNetworkReachabilityCallback callback; // 0x20
	private bool scheduledWithRunLoop; // 0x28
	private MacNetworkChange.NetworkReachabilityFlags flags; // 0x2C
	[CompilerGenerated]
	private NetworkAddressChangedEventHandler networkAddressChanged; // 0x30
	[CompilerGenerated]
	private NetworkAvailabilityChangedEventHandler networkAvailabilityChanged; // 0x38

	// Properties
	private bool IsAvailable { get; }
	public bool HasRegisteredEvents { get; }

	// Methods

	// RVA: 0x21D7AF0 Offset: 0x21D6CF0 VA: 0x1821D7AF0
	private static extern IntPtr dlopen(string path, int mode) { }

	// RVA: 0x21D7BA0 Offset: 0x21D6DA0 VA: 0x1821D7BA0
	private static extern IntPtr dlsym(IntPtr handle, string symbol) { }

	// RVA: 0x21D7A70 Offset: 0x21D6C70 VA: 0x1821D7A70
	private static extern int dlclose(IntPtr handle) { }

	// RVA: 0x21D6A00 Offset: 0x21D5C00 VA: 0x1821D6A00
	private static extern void CFRelease(IntPtr handle) { }

	// RVA: 0x21D6A80 Offset: 0x21D5C80 VA: 0x1821D6A80
	private static extern IntPtr CFRunLoopGetMain() { }

	// RVA: 0x21D7050 Offset: 0x21D6250 VA: 0x1821D7050
	private static extern IntPtr SCNetworkReachabilityCreateWithAddress(IntPtr allocator, ref MacNetworkChange.sockaddr_in sockaddr) { }

	// RVA: 0x21D70E0 Offset: 0x21D62E0 VA: 0x1821D70E0
	private static extern bool SCNetworkReachabilityGetFlags(IntPtr reachability, out MacNetworkChange.NetworkReachabilityFlags flags) { }

	// RVA: 0x21D7210 Offset: 0x21D6410 VA: 0x1821D7210
	private static extern bool SCNetworkReachabilitySetCallback(IntPtr reachability, MacNetworkChange.SCNetworkReachabilityCallback callback, ref MacNetworkChange.SCNetworkReachabilityContext context) { }

	// RVA: 0x21D7170 Offset: 0x21D6370 VA: 0x1821D7170
	private static extern bool SCNetworkReachabilityScheduleWithRunLoop(IntPtr reachability, IntPtr runLoop, IntPtr runLoopMode) { }

	// RVA: 0x21D72C0 Offset: 0x21D64C0 VA: 0x1821D72C0
	private static extern bool SCNetworkReachabilityUnscheduleFromRunLoop(IntPtr reachability, IntPtr runLoop, IntPtr runLoopMode) { }

	[CompilerGenerated]
	// RVA: 0x21D7930 Offset: 0x21D6B30 VA: 0x1821D7930
	private void add_networkAddressChanged(NetworkAddressChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x21D7C90 Offset: 0x21D6E90 VA: 0x1821D7C90
	private void remove_networkAddressChanged(NetworkAddressChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x21D79D0 Offset: 0x21D6BD0 VA: 0x1821D79D0
	private void add_networkAvailabilityChanged(NetworkAvailabilityChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x21D7D30 Offset: 0x21D6F30 VA: 0x1821D7D30
	private void remove_networkAvailabilityChanged(NetworkAvailabilityChangedEventHandler value) { }

	// RVA: 0x21D7700 Offset: 0x21D6900 VA: 0x1821D7700 Slot: 4
	public void add_NetworkAddressChanged(NetworkAddressChangedEventHandler value) { }

	// RVA: 0x21D7C90 Offset: 0x21D6E90 VA: 0x1821D7C90 Slot: 5
	public void remove_NetworkAddressChanged(NetworkAddressChangedEventHandler value) { }

	// RVA: 0x21D7810 Offset: 0x21D6A10 VA: 0x1821D7810 Slot: 6
	public void add_NetworkAvailabilityChanged(NetworkAvailabilityChangedEventHandler value) { }

	// RVA: 0x21D7D30 Offset: 0x21D6F30 VA: 0x1821D7D30 Slot: 7
	public void remove_NetworkAvailabilityChanged(NetworkAvailabilityChangedEventHandler value) { }

	// RVA: 0x21D7C70 Offset: 0x21D6E70 VA: 0x1821D7C70
	private bool get_IsAvailable() { }

	// RVA: 0x21D7C50 Offset: 0x21D6E50 VA: 0x1821D7C50 Slot: 8
	public bool get_HasRegisteredEvents() { }

	// RVA: 0x21D7360 Offset: 0x21D6560 VA: 0x1821D7360
	public void .ctor() { }

	// RVA: 0x21D6E10 Offset: 0x21D6010 VA: 0x1821D6E10
	private bool LoadRunLoopMode() { }

	// RVA: 0x21D6AF0 Offset: 0x21D5CF0 VA: 0x1821D6AF0 Slot: 9
	public void Dispose() { }

	[MonoPInvokeCallback(typeof(MacNetworkChange.SCNetworkReachabilityCallback))]
	// RVA: 0x21D6CC0 Offset: 0x21D5EC0 VA: 0x1821D6CC0
	private static void HandleCallback(IntPtr reachability, MacNetworkChange.NetworkReachabilityFlags flags, IntPtr info) { }
}

// Namespace: 
[Flags]
private enum LinuxNetworkChange.EventType // TypeDefIndex: 6080
{
	// Fields
	public int value__; // 0x0
	public const LinuxNetworkChange.EventType Availability = 1;
	public const LinuxNetworkChange.EventType Address = 2;
}

// Namespace: System.Net.NetworkInformation
internal sealed class LinuxNetworkChange : INetworkChange, IDisposable // TypeDefIndex: 6081
{
	// Fields
	private object _lock; // 0x10
	private Socket nl_sock; // 0x18
	private SocketAsyncEventArgs nl_args; // 0x20
	private LinuxNetworkChange.EventType pending_events; // 0x28
	private Timer timer; // 0x30
	private NetworkAddressChangedEventHandler AddressChanged; // 0x38
	private NetworkAvailabilityChangedEventHandler AvailabilityChanged; // 0x40

	// Properties
	public bool HasRegisteredEvents { get; }

	// Methods

	// RVA: 0x21D6500 Offset: 0x21D5700 VA: 0x1821D6500 Slot: 4
	public void add_NetworkAddressChanged(NetworkAddressChangedEventHandler value) { }

	// RVA: 0x21D69E0 Offset: 0x21D5BE0 VA: 0x1821D69E0 Slot: 5
	public void remove_NetworkAddressChanged(NetworkAddressChangedEventHandler value) { }

	// RVA: 0x21D65A0 Offset: 0x21D57A0 VA: 0x1821D65A0 Slot: 6
	public void add_NetworkAvailabilityChanged(NetworkAvailabilityChangedEventHandler value) { }

	// RVA: 0x21D69F0 Offset: 0x21D5BF0 VA: 0x1821D69F0 Slot: 7
	public void remove_NetworkAvailabilityChanged(NetworkAvailabilityChangedEventHandler value) { }

	// RVA: 0x21D69C0 Offset: 0x21D5BC0 VA: 0x1821D69C0 Slot: 8
	public bool get_HasRegisteredEvents() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	public void Dispose() { }

	// RVA: 0x21D5C00 Offset: 0x21D4E00 VA: 0x1821D5C00
	private bool EnsureSocket() { }

	// RVA: 0x21D5F40 Offset: 0x21D5140 VA: 0x1821D5F40
	private void MaybeCloseSocket() { }

	// RVA: 0x21D5E90 Offset: 0x21D5090 VA: 0x1821D5E90
	private bool GetAvailability() { }

	// RVA: 0x21D6060 Offset: 0x21D5260 VA: 0x1821D6060
	private void OnAvailabilityChanged(object unused) { }

	// RVA: 0x21D5FE0 Offset: 0x21D51E0 VA: 0x1821D5FE0
	private void OnAddressChanged(object unused) { }

	// RVA: 0x21D6220 Offset: 0x21D5420 VA: 0x1821D6220
	private void OnEventDue(object unused) { }

	// RVA: 0x21D63A0 Offset: 0x21D55A0 VA: 0x1821D63A0
	private void QueueEvent(LinuxNetworkChange.EventType type) { }

	// RVA: 0x21D6180 Offset: 0x21D5380 VA: 0x1821D6180
	private void OnDataAvailable(object sender, SocketAsyncEventArgs args) { }

	// RVA: 0x21D6500 Offset: 0x21D5700 VA: 0x1821D6500
	private void Register(NetworkAddressChangedEventHandler d) { }

	// RVA: 0x21D65A0 Offset: 0x21D57A0 VA: 0x1821D65A0
	private void Register(NetworkAvailabilityChangedEventHandler d) { }

	// RVA: 0x21D67D0 Offset: 0x21D59D0 VA: 0x1821D67D0
	private void Unregister(NetworkAddressChangedEventHandler d) { }

	// RVA: 0x21D6640 Offset: 0x21D5840 VA: 0x1821D6640
	private void Unregister(NetworkAvailabilityChangedEventHandler d) { }

	// RVA: 0x21D5BF0 Offset: 0x21D4DF0 VA: 0x1821D5BF0
	private static extern IntPtr CreateNLSocket() { }

	// RVA: 0x21D64F0 Offset: 0x21D56F0 VA: 0x1821D64F0
	private static extern LinuxNetworkChange.EventType ReadEvents(IntPtr sock, IntPtr buffer, int count, int size) { }

	// RVA: 0x21D5BE0 Offset: 0x21D4DE0 VA: 0x1821D5BE0
	private static extern IntPtr CloseNLSocket(IntPtr sock) { }

	// RVA: 0x21D6960 Offset: 0x21D5B60 VA: 0x1821D6960
	public void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal static class SystemNetworkInterface // TypeDefIndex: 6082
{
	// Fields
	private static readonly NetworkInterfaceFactory nif; // 0x0

	// Properties
	public static int InternalLoopbackInterfaceIndex { get; }
	public static int InternalIPv6LoopbackInterfaceIndex { get; }

	// Methods

	// RVA: 0x21F7750 Offset: 0x21F6950 VA: 0x1821F7750
	public static NetworkInterface[] GetNetworkInterfaces() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public static bool InternalGetIsNetworkAvailable() { }

	// RVA: 0x21F7930 Offset: 0x21F6B30 VA: 0x1821F7930
	public static int get_InternalLoopbackInterfaceIndex() { }

	// RVA: 0x21F78F0 Offset: 0x21F6AF0 VA: 0x1821F78F0
	public static int get_InternalIPv6LoopbackInterfaceIndex() { }

	// RVA: 0x21F76D0 Offset: 0x21F68D0 VA: 0x1821F76D0
	public static IPAddress GetNetMask(IPAddress address) { }

	// RVA: 0x21F77E0 Offset: 0x21F69E0 VA: 0x1821F77E0
	private static void .cctor() { }
}

// Namespace: System.Net.NetworkInformation
internal abstract class NetworkInterfaceFactory // TypeDefIndex: 6083
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract NetworkInterface[] GetAllNetworkInterfaces();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetLoopbackInterfaceIndex();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IPAddress GetNetMask(IPAddress address);

	// RVA: 0x21D9720 Offset: 0x21D8920 VA: 0x1821D9720
	public static NetworkInterfaceFactory Create() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal static class NetworkInterfaceFactoryPal // TypeDefIndex: 6084
{
	// Methods

	// RVA: 0x21D9720 Offset: 0x21D8920 VA: 0x1821D9720
	public static NetworkInterfaceFactory Create() { }
}

// Namespace: 
private struct Ping.cap_user_header_t // TypeDefIndex: 6085
{
	// Fields
	public uint version; // 0x0
	public int pid; // 0x4
}

// Namespace: 
private struct Ping.cap_user_data_t // TypeDefIndex: 6086
{
	// Fields
	public uint effective; // 0x0
	public uint permitted; // 0x4
	public uint inheritable; // 0x8
}

// Namespace: 
private class Ping.IcmpMessage // TypeDefIndex: 6087
{
	// Fields
	private byte[] bytes; // 0x10

	// Properties
	public byte Type { get; }
	public byte Code { get; }
	public ushort Identifier { get; }
	public ushort Sequence { get; }
	public byte[] Data { get; }
	public IPStatus IPStatus { get; }

	// Methods

	// RVA: 0x21D58C0 Offset: 0x21D4AC0 VA: 0x1821D58C0
	public void .ctor(byte[] bytes, int offset, int size) { }

	// RVA: 0x21D56D0 Offset: 0x21D48D0 VA: 0x1821D56D0
	public void .ctor(byte type, byte code, ushort identifier, ushort sequence, byte[] data) { }

	// RVA: 0x21D5BB0 Offset: 0x21D4DB0 VA: 0x1821D5BB0
	public byte get_Type() { }

	// RVA: 0x1613030 Offset: 0x1612230 VA: 0x181613030
	public byte get_Code() { }

	// RVA: 0x21D5B30 Offset: 0x21D4D30 VA: 0x1821D5B30
	public ushort get_Identifier() { }

	// RVA: 0x21D5B70 Offset: 0x21D4D70 VA: 0x1821D5B70
	public ushort get_Sequence() { }

	// RVA: 0x21D5950 Offset: 0x21D4B50 VA: 0x1821D5950
	public byte[] get_Data() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public byte[] GetBytes() { }

	// RVA: 0x21D5650 Offset: 0x21D4850 VA: 0x1821D5650
	private static ushort ComputeChecksum(byte[] data) { }

	// RVA: 0x21D59E0 Offset: 0x21D4BE0 VA: 0x1821D59E0
	public IPStatus get_IPStatus() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Ping.<>c__DisplayClass39_0 // TypeDefIndex: 6088
{
	// Fields
	public Ping <>4__this; // 0x10
	public IPAddress address; // 0x18
	public int timeout; // 0x20
	public byte[] buffer; // 0x28
	public PingOptions options; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21F79A0 Offset: 0x21F6BA0 VA: 0x1821F79A0
	internal void <SendAsync>b__0(object o, DoWorkEventArgs ea) { }

	// RVA: 0x21F7A30 Offset: 0x21F6C30 VA: 0x1821F7A30
	internal void <SendAsync>b__1(object o, RunWorkerCompletedEventArgs ea) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Ping.<>c__DisplayClass50_0 // TypeDefIndex: 6089
{
	// Fields
	public Ping <>4__this; // 0x10
	public IPAddress address; // 0x18
	public int timeout; // 0x20
	public byte[] buffer; // 0x28
	public PingOptions options; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21F7B90 Offset: 0x21F6D90 VA: 0x1821F7B90
	internal PingReply <SendPingAsync>b__0() { }

	// RVA: 0x21F7BD0 Offset: 0x21F6DD0 VA: 0x1821F7BD0
	internal void <SendPingAsync>b__1(Task<PingReply> t) { }
}

// Namespace: System.Net.NetworkInformation
[MonoTODO("IPv6 support is missing")]
public class Ping : Component, IDisposable // TypeDefIndex: 6090
{
	// Fields
	private const int DefaultCount = 1;
	private static readonly string[] PingBinPaths; // 0x0
	private static readonly string PingBinPath; // 0x8
	private static bool canSendPrivileged; // 0x10
	private const int default_timeout = 4000;
	private ushort identifier; // 0x28
	private const uint _LINUX_CAPABILITY_VERSION_1 = 429392688;
	private static readonly byte[] default_buffer; // 0x18
	private BackgroundWorker worker; // 0x30
	private object user_async_state; // 0x38
	private CancellationTokenSource cts; // 0x40
	[CompilerGenerated]
	private PingCompletedEventHandler PingCompleted; // 0x48

	// Methods

	[CompilerGenerated]
	// RVA: 0x21E0740 Offset: 0x21DF940 VA: 0x1821E0740
	public void add_PingCompleted(PingCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x21E0870 Offset: 0x21DFA70 VA: 0x1821E0870
	public void remove_PingCompleted(PingCompletedEventHandler value) { }

	// RVA: 0x21E03E0 Offset: 0x21DF5E0 VA: 0x1821E03E0
	private static void .cctor() { }

	// RVA: 0x21E0640 Offset: 0x21DF840 VA: 0x1821E0640
	public void .ctor() { }

	// RVA: 0x21E07E0 Offset: 0x21DF9E0 VA: 0x1821E07E0
	private static extern int capget(ref Ping.cap_user_header_t header, ref Ping.cap_user_data_t data) { }

	// RVA: 0x21DD4F0 Offset: 0x21DC6F0 VA: 0x1821DD4F0
	private static void CheckLinuxCapabilities() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21DD640 Offset: 0x21DC840 VA: 0x1821DD640
	protected void OnPingCompleted(PingCompletedEventArgs e) { }

	// RVA: 0x21E0070 Offset: 0x21DF270 VA: 0x1821E0070
	public PingReply Send(IPAddress address) { }

	// RVA: 0x21DFAE0 Offset: 0x21DECE0 VA: 0x1821DFAE0
	public PingReply Send(IPAddress address, int timeout) { }

	// RVA: 0x21E0340 Offset: 0x21DF540 VA: 0x1821E0340
	public PingReply Send(IPAddress address, int timeout, byte[] buffer) { }

	// RVA: 0x21DFDF0 Offset: 0x21DEFF0 VA: 0x1821DFDF0
	public PingReply Send(string hostNameOrAddress) { }

	// RVA: 0x21DFCB0 Offset: 0x21DEEB0 VA: 0x1821DFCB0
	public PingReply Send(string hostNameOrAddress, int timeout) { }

	// RVA: 0x21DFBC0 Offset: 0x21DEDC0 VA: 0x1821DFBC0
	public PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer) { }

	// RVA: 0x21E0290 Offset: 0x21DF490 VA: 0x1821E0290
	public PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options) { }

	// RVA: 0x21DF8D0 Offset: 0x21DEAD0 VA: 0x1821DF8D0
	public PingReply Send(IPAddress address, int timeout, byte[] buffer, PingOptions options) { }

	// RVA: 0x21DE880 Offset: 0x21DDA80 VA: 0x1821DE880
	private PingReply SendPrivileged(IPAddress address, int timeout, byte[] buffer, PingOptions options) { }

	// RVA: 0x21DF480 Offset: 0x21DE680 VA: 0x1821DF480
	private PingReply SendUnprivileged(IPAddress address, int timeout, byte[] buffer, PingOptions options) { }

	// RVA: 0x21DD740 Offset: 0x21DC940 VA: 0x1821DD740
	public void SendAsync(IPAddress address, int timeout, byte[] buffer, object userToken) { }

	// RVA: 0x21DD8C0 Offset: 0x21DCAC0 VA: 0x1821DD8C0
	public void SendAsync(IPAddress address, int timeout, object userToken) { }

	// RVA: 0x21DDC20 Offset: 0x21DCE20 VA: 0x1821DDC20
	public void SendAsync(IPAddress address, object userToken) { }

	// RVA: 0x21DDB10 Offset: 0x21DCD10 VA: 0x1821DDB10
	public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, object userToken) { }

	// RVA: 0x21DD810 Offset: 0x21DCA10 VA: 0x1821DD810
	public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options, object userToken) { }

	// RVA: 0x21DD9D0 Offset: 0x21DCBD0 VA: 0x1821DD9D0
	public void SendAsync(string hostNameOrAddress, int timeout, object userToken) { }

	// RVA: 0x21DDD30 Offset: 0x21DCF30 VA: 0x1821DDD30
	public void SendAsync(string hostNameOrAddress, object userToken) { }

	// RVA: 0x21DDE80 Offset: 0x21DD080 VA: 0x1821DDE80
	public void SendAsync(IPAddress address, int timeout, byte[] buffer, PingOptions options, object userToken) { }

	// RVA: 0x21DD6B0 Offset: 0x21DC8B0 VA: 0x1821DD6B0
	public void SendAsyncCancel() { }

	// RVA: 0x21DD290 Offset: 0x21DC490 VA: 0x1821DD290
	private string BuildPingArgs(IPAddress address, int timeout, PingOptions options) { }

	// RVA: 0x21DE600 Offset: 0x21DD800 VA: 0x1821DE600
	public Task<PingReply> SendPingAsync(IPAddress address, int timeout, byte[] buffer) { }

	// RVA: 0x21DE290 Offset: 0x21DD490 VA: 0x1821DE290
	public Task<PingReply> SendPingAsync(IPAddress address, int timeout) { }

	// RVA: 0x21DE290 Offset: 0x21DD490 VA: 0x1821DE290
	public Task<PingReply> SendPingAsync(IPAddress address) { }

	// RVA: 0x21DE780 Offset: 0x21DD980 VA: 0x1821DE780
	public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer) { }

	// RVA: 0x21DE6D0 Offset: 0x21DD8D0 VA: 0x1821DE6D0
	public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options) { }

	// RVA: 0x21DE4C0 Offset: 0x21DD6C0 VA: 0x1821DE4C0
	public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout) { }

	// RVA: 0x21DE390 Offset: 0x21DD590 VA: 0x1821DE390
	public Task<PingReply> SendPingAsync(string hostNameOrAddress) { }

	// RVA: 0x21DE070 Offset: 0x21DD270 VA: 0x1821DE070
	public Task<PingReply> SendPingAsync(IPAddress address, int timeout, byte[] buffer, PingOptions options) { }
}

// Namespace: System.Net.NetworkInformation
public class PingCompletedEventArgs : AsyncCompletedEventArgs // TypeDefIndex: 6091
{
	// Fields
	private PingReply reply; // 0x28

	// Properties
	public PingReply Reply { get; }

	// Methods

	// RVA: 0x21DCE50 Offset: 0x21DC050 VA: 0x1821DCE50
	internal void .ctor(Exception ex, bool cancelled, object userState, PingReply reply) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public PingReply get_Reply() { }

	// RVA: 0x21DCE80 Offset: 0x21DC080 VA: 0x1821DCE80
	internal void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public sealed class PingCompletedEventHandler : MulticastDelegate // TypeDefIndex: 6092
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, PingCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, PingCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32IPAddressCollection : IPAddressCollection // TypeDefIndex: 6093
{
	// Fields
	public static readonly Win32IPAddressCollection Empty; // 0x0

	// Methods

	// RVA: 0x21F89F0 Offset: 0x21F7BF0 VA: 0x1821F89F0
	private void .ctor() { }

	// RVA: 0x21F8A00 Offset: 0x21F7C00 VA: 0x1821F8A00
	public void .ctor(IntPtr[] heads) { }

	// RVA: 0x21F8900 Offset: 0x21F7B00 VA: 0x1821F8900
	public void .ctor(Win32_IP_ADDR_STRING[] al) { }

	// RVA: 0x21F8310 Offset: 0x21F7510 VA: 0x1821F8310
	public static Win32IPAddressCollection FromAnycast(IntPtr ptr) { }

	// RVA: 0x21F8490 Offset: 0x21F7690 VA: 0x1821F8490
	public static Win32IPAddressCollection FromDnsServer(IntPtr ptr) { }

	// RVA: 0x21F8610 Offset: 0x21F7810 VA: 0x1821F8610
	public static Win32IPAddressCollection FromSocketAddress(Win32_SOCKET_ADDRESS addr) { }

	// RVA: 0x21F86A0 Offset: 0x21F78A0 VA: 0x1821F86A0
	public static Win32IPAddressCollection FromWinsServer(IntPtr ptr) { }

	// RVA: 0x21F8190 Offset: 0x21F7390 VA: 0x1821F8190
	private void AddSubsequentlyString(IntPtr head) { }

	// RVA: 0x21F8820 Offset: 0x21F7A20 VA: 0x1821F8820
	private static void .cctor() { }
}

// Namespace: 
private struct Win32IPGlobalProperties.Win32_IN6_ADDR // TypeDefIndex: 6094
{
	// Fields
	public byte[] Bytes; // 0x0
}

// Namespace: 
private class Win32IPGlobalProperties.Win32_MIB_TCPROW // TypeDefIndex: 6095
{
	// Fields
	public TcpState State; // 0x10
	public uint LocalAddr; // 0x14
	public uint LocalPort; // 0x18
	public uint RemoteAddr; // 0x1C
	public uint RemotePort; // 0x20

	// Properties
	public IPEndPoint LocalEndPoint { get; }
	public IPEndPoint RemoteEndPoint { get; }
	public TcpConnectionInformation TcpInfo { get; }

	// Methods

	// RVA: 0x21FFA00 Offset: 0x21FEC00 VA: 0x1821FFA00
	public IPEndPoint get_LocalEndPoint() { }

	// RVA: 0x21FFA80 Offset: 0x21FEC80 VA: 0x1821FFA80
	public IPEndPoint get_RemoteEndPoint() { }

	// RVA: 0x21FFB00 Offset: 0x21FED00 VA: 0x1821FFB00
	public TcpConnectionInformation get_TcpInfo() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class Win32IPGlobalProperties.Win32_MIB_TCP6ROW // TypeDefIndex: 6096
{
	// Fields
	public TcpState State; // 0x10
	public Win32IPGlobalProperties.Win32_IN6_ADDR LocalAddr; // 0x18
	public uint LocalScopeId; // 0x20
	public uint LocalPort; // 0x24
	public Win32IPGlobalProperties.Win32_IN6_ADDR RemoteAddr; // 0x28
	public uint RemoteScopeId; // 0x30
	public uint RemotePort; // 0x34

	// Properties
	public IPEndPoint LocalEndPoint { get; }
	public IPEndPoint RemoteEndPoint { get; }
	public TcpConnectionInformation TcpInfo { get; }

	// Methods

	// RVA: 0x21FF790 Offset: 0x21FE990 VA: 0x1821FF790
	public IPEndPoint get_LocalEndPoint() { }

	// RVA: 0x21FF840 Offset: 0x21FEA40 VA: 0x1821FF840
	public IPEndPoint get_RemoteEndPoint() { }

	// RVA: 0x21FF8F0 Offset: 0x21FEAF0 VA: 0x1821FF8F0
	public TcpConnectionInformation get_TcpInfo() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class Win32IPGlobalProperties.Win32_MIB_UDPROW // TypeDefIndex: 6097
{
	// Fields
	public uint LocalAddr; // 0x10
	public uint LocalPort; // 0x14

	// Properties
	public IPEndPoint LocalEndPoint { get; }

	// Methods

	// RVA: 0x21FFC90 Offset: 0x21FEE90 VA: 0x1821FFC90
	public IPEndPoint get_LocalEndPoint() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class Win32IPGlobalProperties.Win32_MIB_UDP6ROW // TypeDefIndex: 6098
{
	// Fields
	public Win32IPGlobalProperties.Win32_IN6_ADDR LocalAddr; // 0x10
	public uint LocalScopeId; // 0x18
	public uint LocalPort; // 0x1C

	// Properties
	public IPEndPoint LocalEndPoint { get; }

	// Methods

	// RVA: 0x21FFBE0 Offset: 0x21FEDE0 VA: 0x1821FFBE0
	public IPEndPoint get_LocalEndPoint() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32IPGlobalProperties : IPGlobalProperties // TypeDefIndex: 6099
{
	// Fields
	public const int AF_INET = 2;
	public const int AF_INET6 = 23;

	// Properties
	public override string DhcpScopeName { get; }
	public override string DomainName { get; }
	public override string HostName { get; }
	public override bool IsWinsProxy { get; }
	public override NetBiosNodeType NodeType { get; }

	// Methods

	// RVA: 0x21F8C20 Offset: 0x21F7E20 VA: 0x1821F8C20
	private void FillTcpTable(out List<Win32IPGlobalProperties.Win32_MIB_TCPROW> tab4, out List<Win32IPGlobalProperties.Win32_MIB_TCP6ROW> tab6) { }

	// RVA: 0x21FB430 Offset: 0x21FA630 VA: 0x1821FB430
	private bool IsListenerState(TcpState state) { }

	// RVA: 0x21F9210 Offset: 0x21F8410 VA: 0x1821F9210 Slot: 6
	public override TcpConnectionInformation[] GetActiveTcpConnections() { }

	// RVA: 0x21F95D0 Offset: 0x21F87D0 VA: 0x1821F95D0 Slot: 5
	public override IPEndPoint[] GetActiveTcpListeners() { }

	// RVA: 0x21F97E0 Offset: 0x21F89E0 VA: 0x1821F97E0 Slot: 4
	public override IPEndPoint[] GetActiveUdpListeners() { }

	// RVA: 0x21FA440 Offset: 0x21F9640 VA: 0x1821FA440 Slot: 16
	public override IcmpV4Statistics GetIcmpV4Statistics() { }

	// RVA: 0x21FA660 Offset: 0x21F9860 VA: 0x1821FA660 Slot: 17
	public override IcmpV6Statistics GetIcmpV6Statistics() { }

	// RVA: 0x21F9EA0 Offset: 0x21F90A0 VA: 0x1821F9EA0 Slot: 18
	public override IPGlobalStatistics GetIPv4GlobalStatistics() { }

	// RVA: 0x21FA0B0 Offset: 0x21F92B0 VA: 0x1821FA0B0 Slot: 19
	public override IPGlobalStatistics GetIPv6GlobalStatistics() { }

	// RVA: 0x21FA960 Offset: 0x21F9B60 VA: 0x1821FA960 Slot: 12
	public override TcpStatistics GetTcpIPv4Statistics() { }

	// RVA: 0x21FAB80 Offset: 0x21F9D80 VA: 0x1821FAB80 Slot: 13
	public override TcpStatistics GetTcpIPv6Statistics() { }

	// RVA: 0x21FAF90 Offset: 0x21FA190 VA: 0x1821FAF90 Slot: 14
	public override UdpStatistics GetUdpIPv4Statistics() { }

	// RVA: 0x21FB140 Offset: 0x21FA340 VA: 0x1821FB140 Slot: 15
	public override UdpStatistics GetUdpIPv6Statistics() { }

	// RVA: 0x21FB450 Offset: 0x21FA650 VA: 0x1821FB450 Slot: 7
	public override string get_DhcpScopeName() { }

	// RVA: 0x21FB470 Offset: 0x21FA670 VA: 0x1821FB470 Slot: 8
	public override string get_DomainName() { }

	// RVA: 0x21FB490 Offset: 0x21FA690 VA: 0x1821FB490 Slot: 9
	public override string get_HostName() { }

	// RVA: 0x21FB4B0 Offset: 0x21FA6B0 VA: 0x1821FB4B0 Slot: 10
	public override bool get_IsWinsProxy() { }

	// RVA: 0x21FB4E0 Offset: 0x21FA6E0 VA: 0x1821FB4E0 Slot: 11
	public override NetBiosNodeType get_NodeType() { }

	// RVA: 0x21FAE30 Offset: 0x21FA030 VA: 0x1821FAE30
	private static extern int GetTcpTable(byte[] pTcpTable, ref int pdwSize, bool bOrder) { }

	// RVA: 0x21FA8B0 Offset: 0x21F9AB0 VA: 0x1821FA8B0
	private static extern int GetTcp6Table(byte[] TcpTable, ref int SizePointer, bool Order) { }

	// RVA: 0x21FB380 Offset: 0x21FA580 VA: 0x1821FB380
	private static extern int GetUdpTable(byte[] pUdpTable, ref int pdwSize, bool bOrder) { }

	// RVA: 0x21FAEE0 Offset: 0x21FA0E0 VA: 0x1821FAEE0
	private static extern int GetUdp6Table(byte[] Udp6Table, ref int SizePointer, bool Order) { }

	// RVA: 0x21FADA0 Offset: 0x21F9FA0 VA: 0x1821FADA0
	private static extern int GetTcpStatisticsEx(out Win32_MIB_TCPSTATS pStats, int dwFamily) { }

	// RVA: 0x21FB2F0 Offset: 0x21FA4F0 VA: 0x1821FB2F0
	private static extern int GetUdpStatisticsEx(out Win32_MIB_UDPSTATS pStats, int dwFamily) { }

	// RVA: 0x21FA3B0 Offset: 0x21F95B0 VA: 0x1821FA3B0
	private static extern int GetIcmpStatistics(out Win32_MIBICMPINFO pStats, int dwFamily) { }

	// RVA: 0x21FA2C0 Offset: 0x21F94C0 VA: 0x1821FA2C0
	private static extern int GetIcmpStatisticsEx(out Win32_MIB_ICMP_EX pStats, int dwFamily) { }

	// RVA: 0x21FA820 Offset: 0x21F9A20 VA: 0x1821FA820
	private static extern int GetIpStatisticsEx(out Win32_MIB_IPSTATS pStats, int dwFamily) { }

	// RVA: 0x21FB500 Offset: 0x21FA700 VA: 0x1821FB500
	private static extern ushort ntohs(ushort netshort) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal static class Win32IPGlobalPropertiesFactoryPal // TypeDefIndex: 6100
{
	// Methods

	// RVA: 0x21F8BD0 Offset: 0x21F7DD0 VA: 0x1821F8BD0
	public static IPGlobalProperties Create() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32IPGlobalStatistics : IPGlobalStatistics // TypeDefIndex: 6101
{
	// Fields
	private Win32_MIB_IPSTATS info; // 0x10

	// Properties
	public override int DefaultTtl { get; }
	public override bool ForwardingEnabled { get; }
	public override int NumberOfInterfaces { get; }
	public override int NumberOfIPAddresses { get; }
	public override int NumberOfRoutes { get; }
	public override long OutputPacketRequests { get; }
	public override long OutputPacketRoutingDiscards { get; }
	public override long OutputPacketsDiscarded { get; }
	public override long OutputPacketsWithNoRoute { get; }
	public override long PacketFragmentFailures { get; }
	public override long PacketReassembliesRequired { get; }
	public override long PacketReassemblyFailures { get; }
	public override long PacketReassemblyTimeout { get; }
	public override long PacketsFragmented { get; }
	public override long PacketsReassembled { get; }
	public override long ReceivedPackets { get; }
	public override long ReceivedPacketsDelivered { get; }
	public override long ReceivedPacketsDiscarded { get; }
	public override long ReceivedPacketsForwarded { get; }
	public override long ReceivedPacketsWithAddressErrors { get; }
	public override long ReceivedPacketsWithHeadersErrors { get; }
	public override long ReceivedPacketsWithUnknownProtocol { get; }

	// Methods

	// RVA: 0x21FB580 Offset: 0x21FA780 VA: 0x1821FB580
	public void .ctor(Win32_MIB_IPSTATS info) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 4
	public override int get_DefaultTtl() { }

	// RVA: 0x6CB670 Offset: 0x6CA870 VA: 0x1806CB670 Slot: 5
	public override bool get_ForwardingEnabled() { }

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890 Slot: 6
	public override int get_NumberOfInterfaces() { }

	// RVA: 0x6772F0 Offset: 0x6764F0 VA: 0x1806772F0 Slot: 7
	public override int get_NumberOfIPAddresses() { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80 Slot: 25
	public override int get_NumberOfRoutes() { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480 Slot: 8
	public override long get_OutputPacketRequests() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 9
	public override long get_OutputPacketRoutingDiscards() { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 10
	public override long get_OutputPacketsDiscarded() { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 11
	public override long get_OutputPacketsWithNoRoute() { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20 Slot: 12
	public override long get_PacketFragmentFailures() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0 Slot: 13
	public override long get_PacketReassembliesRequired() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410 Slot: 14
	public override long get_PacketReassemblyFailures() { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0 Slot: 15
	public override long get_PacketReassemblyTimeout() { }

	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40 Slot: 16
	public override long get_PacketsFragmented() { }

	// RVA: 0x547AA0 Offset: 0x546CA0 VA: 0x180547AA0 Slot: 17
	public override long get_PacketsReassembled() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 18
	public override long get_ReceivedPackets() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 19
	public override long get_ReceivedPacketsDelivered() { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0 Slot: 20
	public override long get_ReceivedPacketsDiscarded() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90 Slot: 21
	public override long get_ReceivedPacketsForwarded() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 22
	public override long get_ReceivedPacketsWithAddressErrors() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 23
	public override long get_ReceivedPacketsWithHeadersErrors() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050 Slot: 24
	public override long get_ReceivedPacketsWithUnknownProtocol() { }
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_MIB_IPSTATS // TypeDefIndex: 6102
{
	// Fields
	public int Forwarding; // 0x0
	public int DefaultTTL; // 0x4
	public uint InReceives; // 0x8
	public uint InHdrErrors; // 0xC
	public uint InAddrErrors; // 0x10
	public uint ForwDatagrams; // 0x14
	public uint InUnknownProtos; // 0x18
	public uint InDiscards; // 0x1C
	public uint InDelivers; // 0x20
	public uint OutRequests; // 0x24
	public uint RoutingDiscards; // 0x28
	public uint OutDiscards; // 0x2C
	public uint OutNoRoutes; // 0x30
	public uint ReasmTimeout; // 0x34
	public uint ReasmReqds; // 0x38
	public uint ReasmOks; // 0x3C
	public uint ReasmFails; // 0x40
	public uint FragOks; // 0x44
	public uint FragFails; // 0x48
	public uint FragCreates; // 0x4C
	public int NumIf; // 0x50
	public int NumAddr; // 0x54
	public int NumRoutes; // 0x58
}

// Namespace: System.Net.NetworkInformation
internal class Win32IPInterfaceProperties2 : IPInterfaceProperties // TypeDefIndex: 6103
{
	// Fields
	private readonly Win32_IP_ADAPTER_ADDRESSES addr; // 0x10
	private readonly Win32_MIB_IFROW mib4; // 0x118
	private readonly Win32_MIB_IFROW mib6; // 0x188

	// Properties
	public override IPAddressInformationCollection AnycastAddresses { get; }
	public override IPAddressCollection DhcpServerAddresses { get; }
	public override IPAddressCollection DnsAddresses { get; }
	public override string DnsSuffix { get; }
	public override GatewayIPAddressInformationCollection GatewayAddresses { get; }
	public override bool IsDnsEnabled { get; }
	public override bool IsDynamicDnsEnabled { get; }
	public override MulticastIPAddressInformationCollection MulticastAddresses { get; }
	public override UnicastIPAddressInformationCollection UnicastAddresses { get; }
	public override IPAddressCollection WinsServersAddresses { get; }

	// Methods

	// RVA: 0x21FC020 Offset: 0x21FB220 VA: 0x1821FC020
	public void .ctor(Win32_IP_ADAPTER_ADDRESSES addr, Win32_MIB_IFROW mib4, Win32_MIB_IFROW mib6) { }

	// RVA: 0x21FB5E0 Offset: 0x21FA7E0 VA: 0x1821FB5E0 Slot: 14
	public override IPv4InterfaceProperties GetIPv4Properties() { }

	// RVA: 0x21FB7E0 Offset: 0x21FA9E0 VA: 0x1821FB7E0 Slot: 15
	public override IPv6InterfaceProperties GetIPv6Properties() { }

	// RVA: 0x21FC160 Offset: 0x21FB360 VA: 0x1821FC160 Slot: 9
	public override IPAddressInformationCollection get_AnycastAddresses() { }

	// RVA: 0x21FB8D0 Offset: 0x21FAAD0 VA: 0x1821FB8D0
	private static IPAddressInformationCollection Win32FromAnycast(IntPtr ptr) { }

	// RVA: 0x21FC330 Offset: 0x21FB530 VA: 0x1821FC330 Slot: 12
	public override IPAddressCollection get_DhcpServerAddresses() { }

	// RVA: 0x21FC430 Offset: 0x21FB630 VA: 0x1821FC430 Slot: 10
	public override IPAddressCollection get_DnsAddresses() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 5
	public override string get_DnsSuffix() { }

	// RVA: 0x21FC5E0 Offset: 0x21FB7E0 VA: 0x1821FC5E0 Slot: 11
	public override GatewayIPAddressInformationCollection get_GatewayAddresses() { }

	// RVA: 0x21FC7A0 Offset: 0x21FB9A0 VA: 0x1821FC7A0 Slot: 4
	public override bool get_IsDnsEnabled() { }

	// RVA: 0x21FC7D0 Offset: 0x21FB9D0 VA: 0x1821FC7D0 Slot: 6
	public override bool get_IsDynamicDnsEnabled() { }

	// RVA: 0x21FC860 Offset: 0x21FBA60 VA: 0x1821FC860 Slot: 8
	public override MulticastIPAddressInformationCollection get_MulticastAddresses() { }

	// RVA: 0x21FBAA0 Offset: 0x21FACA0 VA: 0x1821FBAA0
	private static MulticastIPAddressInformationCollection Win32FromMulticast(IntPtr ptr) { }

	// RVA: 0x21FC870 Offset: 0x21FBA70 VA: 0x1821FC870 Slot: 7
	public override UnicastIPAddressInformationCollection get_UnicastAddresses() { }

	// RVA: 0x21FBCA0 Offset: 0x21FAEA0 VA: 0x1821FBCA0
	private static UnicastIPAddressInformationCollection Win32FromUnicast(IntPtr ptr) { }

	// RVA: 0x21FC8B0 Offset: 0x21FBAB0 VA: 0x1821FC8B0 Slot: 13
	public override IPAddressCollection get_WinsServersAddresses() { }
}

// Namespace: System.Net.NetworkInformation
internal sealed class Win32IPv4InterfaceProperties : IPv4InterfaceProperties // TypeDefIndex: 6104
{
	// Fields
	private Win32_IP_ADAPTER_ADDRESSES addr; // 0x10
	private Win32_IP_PER_ADAPTER_INFO painfo; // 0x118
	private Win32_MIB_IFROW mib; // 0x120

	// Properties
	public override int Index { get; }
	public override bool IsAutomaticPrivateAddressingActive { get; }
	public override bool IsAutomaticPrivateAddressingEnabled { get; }
	public override bool IsDhcpEnabled { get; }
	public override bool IsForwardingEnabled { get; }
	public override int Mtu { get; }
	public override bool UsesWins { get; }

	// Methods

	// RVA: 0x21FCA90 Offset: 0x21FBC90 VA: 0x1821FCA90
	private static extern int GetPerAdapterInfo(int IfIndex, Win32_IP_PER_ADAPTER_INFO pPerAdapterInfo, ref int pOutBufLen) { }

	// RVA: 0x21FCBB0 Offset: 0x21FBDB0 VA: 0x1821FCBB0
	public void .ctor(Win32_IP_ADAPTER_ADDRESSES addr, Win32_MIB_IFROW mib) { }

	// RVA: 0x21FCEB0 Offset: 0x21FC0B0 VA: 0x1821FCEB0 Slot: 8
	public override int get_Index() { }

	// RVA: 0x21FCEC0 Offset: 0x21FC0C0 VA: 0x1821FCEC0 Slot: 6
	public override bool get_IsAutomaticPrivateAddressingActive() { }

	// RVA: 0x21FCEF0 Offset: 0x21FC0F0 VA: 0x1821FCEF0 Slot: 7
	public override bool get_IsAutomaticPrivateAddressingEnabled() { }

	// RVA: 0x21FCF20 Offset: 0x21FC120 VA: 0x1821FCF20 Slot: 5
	public override bool get_IsDhcpEnabled() { }

	// RVA: 0x21FCF30 Offset: 0x21FC130 VA: 0x1821FCF30 Slot: 9
	public override bool get_IsForwardingEnabled() { }

	// RVA: 0x1C61760 Offset: 0x1C60960 VA: 0x181C61760 Slot: 10
	public override int get_Mtu() { }

	// RVA: 0x21FCF60 Offset: 0x21FC160 VA: 0x1821FCF60 Slot: 4
	public override bool get_UsesWins() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32_IP_PER_ADAPTER_INFO // TypeDefIndex: 6105
{
	// Fields
	public uint AutoconfigEnabled; // 0x10
	public uint AutoconfigActive; // 0x14
	public IntPtr CurrentDnsServer; // 0x18
	public Win32_IP_ADDR_STRING DnsServerList; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics // TypeDefIndex: 6106
{
	// Fields
	private Win32_MIB_IFROW info; // 0x10

	// Properties
	public override long BytesReceived { get; }
	public override long BytesSent { get; }
	public override long IncomingPacketsDiscarded { get; }
	public override long IncomingPacketsWithErrors { get; }
	public override long IncomingUnknownProtocolPackets { get; }
	public override long NonUnicastPacketsReceived { get; }
	public override long NonUnicastPacketsSent { get; }
	public override long OutgoingPacketsDiscarded { get; }
	public override long OutgoingPacketsWithErrors { get; }
	public override long OutputQueueLength { get; }
	public override long UnicastPacketsReceived { get; }
	public override long UnicastPacketsSent { get; }

	// Methods

	// RVA: 0x21FCF80 Offset: 0x21FC180 VA: 0x1821FCF80
	public void .ctor(Win32_MIB_IFROW info) { }

	// RVA: 0x21FCFE0 Offset: 0x21FC1E0 VA: 0x1821FCFE0 Slot: 4
	public override long get_BytesReceived() { }

	// RVA: 0x21FCFF0 Offset: 0x21FC1F0 VA: 0x1821FCFF0 Slot: 5
	public override long get_BytesSent() { }

	// RVA: 0x21FD000 Offset: 0x21FC200 VA: 0x1821FD000 Slot: 6
	public override long get_IncomingPacketsDiscarded() { }

	// RVA: 0x21FD010 Offset: 0x21FC210 VA: 0x1821FD010 Slot: 7
	public override long get_IncomingPacketsWithErrors() { }

	// RVA: 0x21FD020 Offset: 0x21FC220 VA: 0x1821FD020 Slot: 8
	public override long get_IncomingUnknownProtocolPackets() { }

	// RVA: 0x21FD030 Offset: 0x21FC230 VA: 0x1821FD030 Slot: 9
	public override long get_NonUnicastPacketsReceived() { }

	// RVA: 0x21FD040 Offset: 0x21FC240 VA: 0x1821FD040 Slot: 10
	public override long get_NonUnicastPacketsSent() { }

	// RVA: 0x21FD050 Offset: 0x21FC250 VA: 0x1821FD050 Slot: 11
	public override long get_OutgoingPacketsDiscarded() { }

	// RVA: 0x21FD060 Offset: 0x21FC260 VA: 0x1821FD060 Slot: 12
	public override long get_OutgoingPacketsWithErrors() { }

	// RVA: 0x21FD070 Offset: 0x21FC270 VA: 0x1821FD070 Slot: 13
	public override long get_OutputQueueLength() { }

	// RVA: 0x21FD080 Offset: 0x21FC280 VA: 0x1821FD080 Slot: 14
	public override long get_UnicastPacketsReceived() { }

	// RVA: 0x21FD090 Offset: 0x21FC290 VA: 0x1821FD090 Slot: 15
	public override long get_UnicastPacketsSent() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32IPv6InterfaceProperties : IPv6InterfaceProperties // TypeDefIndex: 6107
{
	// Fields
	private Win32_MIB_IFROW mib; // 0x10

	// Properties
	public override int Index { get; }
	public override int Mtu { get; }

	// Methods

	// RVA: 0x21FCF80 Offset: 0x21FC180 VA: 0x1821FCF80
	public void .ctor(Win32_MIB_IFROW mib) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 4
	public override int get_Index() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 5
	public override int get_Mtu() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32IcmpV4Statistics : IcmpV4Statistics // TypeDefIndex: 6108
{
	// Fields
	private Win32_MIBICMPSTATS iin; // 0x10
	private Win32_MIBICMPSTATS iout; // 0x44

	// Properties
	public override long AddressMaskRepliesReceived { get; }
	public override long AddressMaskRepliesSent { get; }
	public override long AddressMaskRequestsReceived { get; }
	public override long AddressMaskRequestsSent { get; }
	public override long DestinationUnreachableMessagesReceived { get; }
	public override long DestinationUnreachableMessagesSent { get; }
	public override long EchoRepliesReceived { get; }
	public override long EchoRepliesSent { get; }
	public override long EchoRequestsReceived { get; }
	public override long EchoRequestsSent { get; }
	public override long ErrorsReceived { get; }
	public override long ErrorsSent { get; }
	public override long MessagesReceived { get; }
	public override long MessagesSent { get; }
	public override long ParameterProblemsReceived { get; }
	public override long ParameterProblemsSent { get; }
	public override long RedirectsReceived { get; }
	public override long RedirectsSent { get; }
	public override long SourceQuenchesReceived { get; }
	public override long SourceQuenchesSent { get; }
	public override long TimeExceededMessagesReceived { get; }
	public override long TimeExceededMessagesSent { get; }
	public override long TimestampRepliesReceived { get; }
	public override long TimestampRepliesSent { get; }
	public override long TimestampRequestsReceived { get; }
	public override long TimestampRequestsSent { get; }

	// Methods

	// RVA: 0x21FD0A0 Offset: 0x21FC2A0 VA: 0x1821FD0A0
	public void .ctor(Win32_MIBICMPINFO info) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 4
	public override long get_AddressMaskRepliesReceived() { }

	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90 Slot: 5
	public override long get_AddressMaskRepliesSent() { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 6
	public override long get_AddressMaskRequestsReceived() { }

	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0 Slot: 7
	public override long get_AddressMaskRequestsSent() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 8
	public override long get_DestinationUnreachableMessagesReceived() { }

	// RVA: 0x547AA0 Offset: 0x546CA0 VA: 0x180547AA0 Slot: 9
	public override long get_DestinationUnreachableMessagesSent() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 10
	public override long get_EchoRepliesReceived() { }

	// RVA: 0x6772F0 Offset: 0x6764F0 VA: 0x1806772F0 Slot: 11
	public override long get_EchoRepliesSent() { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0 Slot: 12
	public override long get_EchoRequestsReceived() { }

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890 Slot: 13
	public override long get_EchoRequestsSent() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 14
	public override long get_ErrorsReceived() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0 Slot: 15
	public override long get_ErrorsSent() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 16
	public override long get_MessagesReceived() { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0 Slot: 17
	public override long get_MessagesSent() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 18
	public override long get_ParameterProblemsReceived() { }

	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40 Slot: 19
	public override long get_ParameterProblemsSent() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050 Slot: 20
	public override long get_RedirectsReceived() { }

	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10 Slot: 21
	public override long get_RedirectsSent() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90 Slot: 22
	public override long get_SourceQuenchesReceived() { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20 Slot: 23
	public override long get_SourceQuenchesSent() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 24
	public override long get_TimeExceededMessagesReceived() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410 Slot: 25
	public override long get_TimeExceededMessagesSent() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 26
	public override long get_TimestampRepliesReceived() { }

	// RVA: 0x526CA0 Offset: 0x525EA0 VA: 0x180526CA0 Slot: 27
	public override long get_TimestampRepliesSent() { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480 Slot: 28
	public override long get_TimestampRequestsReceived() { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80 Slot: 29
	public override long get_TimestampRequestsSent() { }
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_MIBICMPINFO // TypeDefIndex: 6109
{
	// Fields
	public Win32_MIBICMPSTATS InStats; // 0x0
	public Win32_MIBICMPSTATS OutStats; // 0x34
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_MIBICMPSTATS // TypeDefIndex: 6110
{
	// Fields
	public uint Msgs; // 0x0
	public uint Errors; // 0x4
	public uint DestUnreachs; // 0x8
	public uint TimeExcds; // 0xC
	public uint ParmProbs; // 0x10
	public uint SrcQuenchs; // 0x14
	public uint Redirects; // 0x18
	public uint Echos; // 0x1C
	public uint EchoReps; // 0x20
	public uint Timestamps; // 0x24
	public uint TimestampReps; // 0x28
	public uint AddrMasks; // 0x2C
	public uint AddrMaskReps; // 0x30
}

// Namespace: System.Net.NetworkInformation
internal class IcmpV6MessageTypes // TypeDefIndex: 6111
{
	// Fields
	public const int DestinationUnreachable = 1;
	public const int PacketTooBig = 2;
	public const int TimeExceeded = 3;
	public const int ParameterProblem = 4;
	public const int EchoRequest = 128;
	public const int EchoReply = 129;
	public const int GroupMembershipQuery = 130;
	public const int GroupMembershipReport = 131;
	public const int GroupMembershipReduction = 132;
	public const int RouterSolicitation = 133;
	public const int RouterAdvertisement = 134;
	public const int NeighborSolicitation = 135;
	public const int NeighborAdvertisement = 136;
	public const int Redirect = 137;
	public const int RouterRenumbering = 138;

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32IcmpV6Statistics : IcmpV6Statistics // TypeDefIndex: 6112
{
	// Fields
	private Win32_MIBICMPSTATS_EX iin; // 0x10
	private Win32_MIBICMPSTATS_EX iout; // 0x20

	// Properties
	public override long DestinationUnreachableMessagesReceived { get; }
	public override long DestinationUnreachableMessagesSent { get; }
	public override long EchoRepliesReceived { get; }
	public override long EchoRepliesSent { get; }
	public override long EchoRequestsReceived { get; }
	public override long EchoRequestsSent { get; }
	public override long ErrorsReceived { get; }
	public override long ErrorsSent { get; }
	public override long MembershipQueriesReceived { get; }
	public override long MembershipQueriesSent { get; }
	public override long MembershipReductionsReceived { get; }
	public override long MembershipReductionsSent { get; }
	public override long MembershipReportsReceived { get; }
	public override long MembershipReportsSent { get; }
	public override long MessagesReceived { get; }
	public override long MessagesSent { get; }
	public override long NeighborAdvertisementsReceived { get; }
	public override long NeighborAdvertisementsSent { get; }
	public override long NeighborSolicitsReceived { get; }
	public override long NeighborSolicitsSent { get; }
	public override long PacketTooBigMessagesReceived { get; }
	public override long PacketTooBigMessagesSent { get; }
	public override long ParameterProblemsReceived { get; }
	public override long ParameterProblemsSent { get; }
	public override long RedirectsReceived { get; }
	public override long RedirectsSent { get; }
	public override long RouterAdvertisementsReceived { get; }
	public override long RouterAdvertisementsSent { get; }
	public override long RouterSolicitsReceived { get; }
	public override long RouterSolicitsSent { get; }
	public override long TimeExceededMessagesReceived { get; }
	public override long TimeExceededMessagesSent { get; }

	// Methods

	// RVA: 0x21FD100 Offset: 0x21FC300 VA: 0x1821FD100
	public void .ctor(Win32_MIB_ICMP_EX info) { }

	// RVA: 0x21FD140 Offset: 0x21FC340 VA: 0x1821FD140 Slot: 4
	public override long get_DestinationUnreachableMessagesReceived() { }

	// RVA: 0x21FD170 Offset: 0x21FC370 VA: 0x1821FD170 Slot: 5
	public override long get_DestinationUnreachableMessagesSent() { }

	// RVA: 0x21FD1A0 Offset: 0x21FC3A0 VA: 0x1821FD1A0 Slot: 6
	public override long get_EchoRepliesReceived() { }

	// RVA: 0x21FD1D0 Offset: 0x21FC3D0 VA: 0x1821FD1D0 Slot: 7
	public override long get_EchoRepliesSent() { }

	// RVA: 0x21FD200 Offset: 0x21FC400 VA: 0x1821FD200 Slot: 8
	public override long get_EchoRequestsReceived() { }

	// RVA: 0x21FD230 Offset: 0x21FC430 VA: 0x1821FD230 Slot: 9
	public override long get_EchoRequestsSent() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public override long get_ErrorsReceived() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90 Slot: 11
	public override long get_ErrorsSent() { }

	// RVA: 0x21FD260 Offset: 0x21FC460 VA: 0x1821FD260 Slot: 12
	public override long get_MembershipQueriesReceived() { }

	// RVA: 0x21FD290 Offset: 0x21FC490 VA: 0x1821FD290 Slot: 13
	public override long get_MembershipQueriesSent() { }

	// RVA: 0x21FD2C0 Offset: 0x21FC4C0 VA: 0x1821FD2C0 Slot: 14
	public override long get_MembershipReductionsReceived() { }

	// RVA: 0x21FD2F0 Offset: 0x21FC4F0 VA: 0x1821FD2F0 Slot: 15
	public override long get_MembershipReductionsSent() { }

	// RVA: 0x21FD320 Offset: 0x21FC520 VA: 0x1821FD320 Slot: 16
	public override long get_MembershipReportsReceived() { }

	// RVA: 0x21FD350 Offset: 0x21FC550 VA: 0x1821FD350 Slot: 17
	public override long get_MembershipReportsSent() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 18
	public override long get_MessagesReceived() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 19
	public override long get_MessagesSent() { }

	// RVA: 0x21FD380 Offset: 0x21FC580 VA: 0x1821FD380 Slot: 20
	public override long get_NeighborAdvertisementsReceived() { }

	// RVA: 0x21FD3B0 Offset: 0x21FC5B0 VA: 0x1821FD3B0 Slot: 21
	public override long get_NeighborAdvertisementsSent() { }

	// RVA: 0x21FD3E0 Offset: 0x21FC5E0 VA: 0x1821FD3E0 Slot: 22
	public override long get_NeighborSolicitsReceived() { }

	// RVA: 0x21FD410 Offset: 0x21FC610 VA: 0x1821FD410 Slot: 23
	public override long get_NeighborSolicitsSent() { }

	// RVA: 0x21FD440 Offset: 0x21FC640 VA: 0x1821FD440 Slot: 24
	public override long get_PacketTooBigMessagesReceived() { }

	// RVA: 0x21FD470 Offset: 0x21FC670 VA: 0x1821FD470 Slot: 25
	public override long get_PacketTooBigMessagesSent() { }

	// RVA: 0x21FD4A0 Offset: 0x21FC6A0 VA: 0x1821FD4A0 Slot: 26
	public override long get_ParameterProblemsReceived() { }

	// RVA: 0x21FD4D0 Offset: 0x21FC6D0 VA: 0x1821FD4D0 Slot: 27
	public override long get_ParameterProblemsSent() { }

	// RVA: 0x21FD500 Offset: 0x21FC700 VA: 0x1821FD500 Slot: 28
	public override long get_RedirectsReceived() { }

	// RVA: 0x21FD530 Offset: 0x21FC730 VA: 0x1821FD530 Slot: 29
	public override long get_RedirectsSent() { }

	// RVA: 0x21FD560 Offset: 0x21FC760 VA: 0x1821FD560 Slot: 30
	public override long get_RouterAdvertisementsReceived() { }

	// RVA: 0x21FD590 Offset: 0x21FC790 VA: 0x1821FD590 Slot: 31
	public override long get_RouterAdvertisementsSent() { }

	// RVA: 0x21FD5C0 Offset: 0x21FC7C0 VA: 0x1821FD5C0 Slot: 32
	public override long get_RouterSolicitsReceived() { }

	// RVA: 0x21FD5F0 Offset: 0x21FC7F0 VA: 0x1821FD5F0 Slot: 33
	public override long get_RouterSolicitsSent() { }

	// RVA: 0x21FD620 Offset: 0x21FC820 VA: 0x1821FD620 Slot: 34
	public override long get_TimeExceededMessagesReceived() { }

	// RVA: 0x21FD650 Offset: 0x21FC850 VA: 0x1821FD650 Slot: 35
	public override long get_TimeExceededMessagesSent() { }
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_MIB_ICMP_EX // TypeDefIndex: 6113
{
	// Fields
	public Win32_MIBICMPSTATS_EX InStats; // 0x0
	public Win32_MIBICMPSTATS_EX OutStats; // 0x10
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_MIBICMPSTATS_EX // TypeDefIndex: 6114
{
	// Fields
	public uint Msgs; // 0x0
	public uint Errors; // 0x4
	public uint[] Counts; // 0x8
}

// Namespace: System.Net.NetworkInformation
internal class Win32NetworkInterfaceAPI : NetworkInterfaceFactory // TypeDefIndex: 6115
{
	// Fields
	private const string IPHLPAPI = "iphlpapi.dll";

	// Methods

	// RVA: 0x21FE700 Offset: 0x21FD900 VA: 0x1821FE700
	private static extern int GetAdaptersAddresses(uint family, uint flags, IntPtr reserved, IntPtr info, ref int size) { }

	// RVA: 0x21FEA00 Offset: 0x21FDC00 VA: 0x1821FEA00
	private static extern uint GetBestInterfaceEx(byte[] ipAddress, out int index) { }

	// RVA: 0x21FE270 Offset: 0x21FD470 VA: 0x1821FE270
	private static Win32_IP_ADAPTER_ADDRESSES[] GetAdaptersAddresses() { }

	// RVA: 0x21FE7C0 Offset: 0x21FD9C0 VA: 0x1821FE7C0 Slot: 4
	public override NetworkInterface[] GetAllNetworkInterfaces() { }

	// RVA: 0x21FEAA0 Offset: 0x21FDCA0 VA: 0x1821FEAA0
	private static int GetBestInterfaceForAddress(IPAddress addr) { }

	// RVA: 0x21FEBD0 Offset: 0x21FDDD0 VA: 0x1821FEBD0 Slot: 5
	public override int GetLoopbackInterfaceIndex() { }

	// RVA: 0x21FED40 Offset: 0x21FDF40 VA: 0x1821FED40 Slot: 6
	public override IPAddress GetNetMask(IPAddress address) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal sealed class Win32NetworkInterface2 : NetworkInterface // TypeDefIndex: 6116
{
	// Fields
	private Win32_IP_ADAPTER_ADDRESSES addr; // 0x10
	private Win32_MIB_IFROW mib4; // 0x118
	private Win32_MIB_IFROW mib6; // 0x188
	private Win32IPv4InterfaceStatistics ip4stats; // 0x1F8
	private IPInterfaceProperties ip_if_props; // 0x200

	// Properties
	public override string Description { get; }
	public override string Id { get; }
	public override bool IsReceiveOnly { get; }
	public override string Name { get; }
	public override NetworkInterfaceType NetworkInterfaceType { get; }
	public override OperationalStatus OperationalStatus { get; }
	public override long Speed { get; }
	public override bool SupportsMulticast { get; }

	// Methods

	// RVA: 0x21FDA60 Offset: 0x21FCC60 VA: 0x1821FDA60
	private static extern int GetAdaptersInfo(IntPtr info, ref int size) { }

	// RVA: 0x21FDAF0 Offset: 0x21FCCF0 VA: 0x1821FDAF0
	private static extern int GetIfEntry(ref Win32_MIB_IFROW row) { }

	// RVA: 0x21FD6A0 Offset: 0x21FC8A0 VA: 0x1821FD6A0
	private static Win32_IP_ADAPTER_INFO[] GetAdaptersInfo() { }

	// RVA: 0x21FDD00 Offset: 0x21FCF00 VA: 0x1821FDD00
	internal void .ctor(Win32_IP_ADAPTER_ADDRESSES addr) { }

	// RVA: 0x1C61730 Offset: 0x1C60930 VA: 0x181C61730 Slot: 7
	public override IPInterfaceProperties GetIPProperties() { }

	// RVA: 0x88CED0 Offset: 0x88C0D0 VA: 0x18088CED0 Slot: 8
	public override IPv4InterfaceStatistics GetIPv4Statistics() { }

	// RVA: 0x21FDC30 Offset: 0x21FCE30 VA: 0x1821FDC30 Slot: 14
	public override PhysicalAddress GetPhysicalAddress() { }

	// RVA: 0x21FDCD0 Offset: 0x21FCED0 VA: 0x1821FDCD0 Slot: 16
	public override bool Supports(NetworkInterfaceComponent networkInterfaceComponent) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 6
	public override string get_Description() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 4
	public override string get_Id() { }

	// RVA: 0x21FE230 Offset: 0x21FD430 VA: 0x1821FE230 Slot: 12
	public override bool get_IsReceiveOnly() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 5
	public override string get_Name() { }

	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90 Slot: 15
	public override NetworkInterfaceType get_NetworkInterfaceType() { }

	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990 Slot: 10
	public override OperationalStatus get_OperationalStatus() { }

	// RVA: 0x21FE240 Offset: 0x21FD440 VA: 0x1821FE240 Slot: 11
	public override long get_Speed() { }

	// RVA: 0x21FE260 Offset: 0x21FD460 VA: 0x1821FE260 Slot: 13
	public override bool get_SupportsMulticast() { }
}

// Namespace: System.Net.NetworkInformation
internal static class Win32NetworkInterfaceFactoryPal // TypeDefIndex: 6117
{
	// Methods

	// RVA: 0x21FED80 Offset: 0x21FDF80 VA: 0x1821FED80
	public static NetworkInterfaceFactory Create() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32NetworkInterface // TypeDefIndex: 6118
{
	// Fields
	private static Win32_FIXED_INFO fixedInfo; // 0x0
	private static bool initialized; // 0x58

	// Properties
	public static Win32_FIXED_INFO FixedInfo { get; }

	// Methods

	// RVA: 0x21FEE30 Offset: 0x21FE030 VA: 0x1821FEE30
	private static extern int GetNetworkParams(IntPtr ptr, ref int size) { }

	// RVA: 0x21FEEC0 Offset: 0x21FE0C0 VA: 0x1821FEEC0
	private static extern int MultiByteToWideChar(uint CodePage, uint dwFlags, byte* lpMultiByteStr, int cbMultiByte, char* lpWideCharStr, int cchWideChar) { }

	// RVA: 0x21FF090 Offset: 0x21FE290 VA: 0x1821FF090
	public static Win32_FIXED_INFO get_FixedInfo() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x21FEF90 Offset: 0x21FE190 VA: 0x1821FEF90
	internal static string <get_FixedInfo>g__GetStringFromMultiByte|5_0(byte* bytes) { }
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_FIXED_INFO // TypeDefIndex: 6119
{
	// Fields
	public string HostName; // 0x0
	public string DomainName; // 0x8
	public IntPtr CurrentDnsServer; // 0x10
	public Win32_IP_ADDR_STRING DnsServerList; // 0x18
	public NetBiosNodeType NodeType; // 0x38
	public string ScopeId; // 0x40
	public uint EnableRouting; // 0x48
	public uint EnableProxy; // 0x4C
	public uint EnableDns; // 0x50
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct Win32_FIXED_INFO_Marshal.<HostName>e__FixedBuffer // TypeDefIndex: 6120
{
	// Fields
	public byte FixedElementField; // 0x0
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct Win32_FIXED_INFO_Marshal.<DomainName>e__FixedBuffer // TypeDefIndex: 6121
{
	// Fields
	public byte FixedElementField; // 0x0
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct Win32_FIXED_INFO_Marshal.<ScopeId>e__FixedBuffer // TypeDefIndex: 6122
{
	// Fields
	public byte FixedElementField; // 0x0
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_FIXED_INFO_Marshal // TypeDefIndex: 6123
{
	// Fields
	private const int MAX_HOSTNAME_LEN = 128;
	private const int MAX_DOMAIN_NAME_LEN = 128;
	private const int MAX_SCOPE_ID_LEN = 256;
	[FixedBuffer(typeof(byte), 132)]
	public Win32_FIXED_INFO_Marshal.<HostName>e__FixedBuffer HostName; // 0x0
	[FixedBuffer(typeof(byte), 132)]
	public Win32_FIXED_INFO_Marshal.<DomainName>e__FixedBuffer DomainName; // 0x84
	public IntPtr CurrentDnsServer; // 0x108
	public Win32_IP_ADDR_STRING DnsServerList; // 0x110
	public NetBiosNodeType NodeType; // 0x130
	[FixedBuffer(typeof(byte), 260)]
	public Win32_FIXED_INFO_Marshal.<ScopeId>e__FixedBuffer ScopeId; // 0x134
	public uint EnableRouting; // 0x238
	public uint EnableProxy; // 0x23C
	public uint EnableDns; // 0x240
}

// Namespace: System.Net.NetworkInformation
internal struct AlignmentUnion // TypeDefIndex: 6124
{
	// Fields
	public ulong Alignment; // 0x0
	public int Length; // 0x0
	public int IfIndex; // 0x4
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADAPTER_ADDRESSES // TypeDefIndex: 6125
{
	// Fields
	public AlignmentUnion Alignment; // 0x0
	public IntPtr Next; // 0x8
	public string AdapterName; // 0x10
	public IntPtr FirstUnicastAddress; // 0x18
	public IntPtr FirstAnycastAddress; // 0x20
	public IntPtr FirstMulticastAddress; // 0x28
	public IntPtr FirstDnsServerAddress; // 0x30
	public string DnsSuffix; // 0x38
	public string Description; // 0x40
	public string FriendlyName; // 0x48
	public byte[] PhysicalAddress; // 0x50
	public uint PhysicalAddressLength; // 0x58
	public uint Flags; // 0x5C
	public uint Mtu; // 0x60
	public NetworkInterfaceType IfType; // 0x64
	public OperationalStatus OperStatus; // 0x68
	public int Ipv6IfIndex; // 0x6C
	public uint[] ZoneIndices; // 0x70
	public IntPtr FirstPrefix; // 0x78
	public ulong TransmitLinkSpeed; // 0x80
	public ulong ReceiveLinkSpeed; // 0x88
	public IntPtr FirstWinsServerAddress; // 0x90
	public IntPtr FirstGatewayAddress; // 0x98
	public uint Ipv4Metric; // 0xA0
	public uint Ipv6Metric; // 0xA4
	public ulong Luid; // 0xA8
	public Win32_SOCKET_ADDRESS Dhcpv4Server; // 0xB0
	public uint CompartmentId; // 0xC0
	public ulong NetworkGuid; // 0xC8
	public int ConnectionType; // 0xD0
	public int TunnelType; // 0xD4
	public Win32_SOCKET_ADDRESS Dhcpv6Server; // 0xD8
	public byte[] Dhcpv6ClientDuid; // 0xE8
	public ulong Dhcpv6ClientDuidLength; // 0xF0
	public ulong Dhcpv6Iaid; // 0xF8
	public IntPtr FirstDnsSuffix; // 0x100
	public const int GAA_FLAG_INCLUDE_WINS_INFO = 64;
	public const int GAA_FLAG_INCLUDE_GATEWAYS = 128;
	private const int MAX_ADAPTER_ADDRESS_LENGTH = 8;
	private const int MAX_DHCPV6_DUID_LENGTH = 130;
	private const int IP_ADAPTER_DDNS_ENABLED = 1;
	private const int IP_ADAPTER_DHCP_ENABLED = 4;
	private const int IP_ADAPTER_RECEIVE_ONLY = 8;
	private const int IP_ADAPTER_NO_MULTICAST = 16;

	// Properties
	public bool DdnsEnabled { get; }
	public bool DhcpEnabled { get; }
	public bool IsReceiveOnly { get; }
	public bool NoMulticast { get; }

	// Methods

	// RVA: 0x21FF750 Offset: 0x21FE950 VA: 0x1821FF750
	public bool get_DdnsEnabled() { }

	// RVA: 0x21FF760 Offset: 0x21FE960 VA: 0x1821FF760
	public bool get_DhcpEnabled() { }

	// RVA: 0x21FF770 Offset: 0x21FE970 VA: 0x1821FF770
	public bool get_IsReceiveOnly() { }

	// RVA: 0x21FF780 Offset: 0x21FE980 VA: 0x1821FF780
	public bool get_NoMulticast() { }
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADAPTER_INFO // TypeDefIndex: 6126
{
	// Fields
	private const int MAX_ADAPTER_NAME_LENGTH = 256;
	private const int MAX_ADAPTER_DESCRIPTION_LENGTH = 128;
	private const int MAX_ADAPTER_ADDRESS_LENGTH = 8;
	public IntPtr Next; // 0x0
	public int ComboIndex; // 0x8
	public string AdapterName; // 0x10
	public string Description; // 0x18
	public uint AddressLength; // 0x20
	public byte[] Address; // 0x28
	public uint Index; // 0x30
	public uint Type; // 0x34
	public uint DhcpEnabled; // 0x38
	public IntPtr CurrentIpAddress; // 0x40
	public Win32_IP_ADDR_STRING IpAddressList; // 0x48
	public Win32_IP_ADDR_STRING GatewayList; // 0x68
	public Win32_IP_ADDR_STRING DhcpServer; // 0x88
	public bool HaveWins; // 0xA8
	public Win32_IP_ADDR_STRING PrimaryWinsServer; // 0xB0
	public Win32_IP_ADDR_STRING SecondaryWinsServer; // 0xD0
	public long LeaseObtained; // 0xF0
	public long LeaseExpires; // 0xF8
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_MIB_IFROW // TypeDefIndex: 6127
{
	// Fields
	private const int MAX_INTERFACE_NAME_LEN = 256;
	private const int MAXLEN_PHYSADDR = 8;
	private const int MAXLEN_IFDESCR = 256;
	public char[] Name; // 0x0
	public int Index; // 0x8
	public NetworkInterfaceType Type; // 0xC
	public int Mtu; // 0x10
	public uint Speed; // 0x14
	public int PhysAddrLen; // 0x18
	public byte[] PhysAddr; // 0x20
	public uint AdminStatus; // 0x28
	public uint OperStatus; // 0x2C
	public uint LastChange; // 0x30
	public int InOctets; // 0x34
	public int InUcastPkts; // 0x38
	public int InNUcastPkts; // 0x3C
	public int InDiscards; // 0x40
	public int InErrors; // 0x44
	public int InUnknownProtos; // 0x48
	public int OutOctets; // 0x4C
	public int OutUcastPkts; // 0x50
	public int OutNUcastPkts; // 0x54
	public int OutDiscards; // 0x58
	public int OutErrors; // 0x5C
	public int OutQLen; // 0x60
	public int DescrLen; // 0x64
	public byte[] Descr; // 0x68
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADDR_STRING // TypeDefIndex: 6128
{
	// Fields
	public IntPtr Next; // 0x0
	public string IpAddress; // 0x8
	public string IpMask; // 0x10
	public uint Context; // 0x18
}

// Namespace: System.Net.NetworkInformation
internal struct Win32LengthFlagsUnion // TypeDefIndex: 6129
{
	// Fields
	private const int IP_ADAPTER_ADDRESS_DNS_ELIGIBLE = 1;
	private const int IP_ADAPTER_ADDRESS_TRANSIENT = 2;
	public uint Length; // 0x0
	public uint Flags; // 0x4

	// Properties
	public bool IsDnsEligible { get; }
	public bool IsTransient { get; }

	// Methods

	// RVA: 0x21FD680 Offset: 0x21FC880 VA: 0x1821FD680
	public bool get_IsDnsEligible() { }

	// RVA: 0x21FD690 Offset: 0x21FC890 VA: 0x1821FD690
	public bool get_IsTransient() { }
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADAPTER_ANYCAST_ADDRESS // TypeDefIndex: 6130
{
	// Fields
	public Win32LengthFlagsUnion LengthFlags; // 0x0
	public IntPtr Next; // 0x8
	public Win32_SOCKET_ADDRESS Address; // 0x10
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADAPTER_DNS_SERVER_ADDRESS // TypeDefIndex: 6131
{
	// Fields
	public Win32LengthFlagsUnion LengthFlags; // 0x0
	public IntPtr Next; // 0x8
	public Win32_SOCKET_ADDRESS Address; // 0x10
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADAPTER_MULTICAST_ADDRESS // TypeDefIndex: 6132
{
	// Fields
	public Win32LengthFlagsUnion LengthFlags; // 0x0
	public IntPtr Next; // 0x8
	public Win32_SOCKET_ADDRESS Address; // 0x10
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADAPTER_GATEWAY_ADDRESS // TypeDefIndex: 6133
{
	// Fields
	public Win32LengthFlagsUnion LengthFlags; // 0x0
	public IntPtr Next; // 0x8
	public Win32_SOCKET_ADDRESS Address; // 0x10
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADAPTER_WINS_SERVER_ADDRESS // TypeDefIndex: 6134
{
	// Fields
	public Win32LengthFlagsUnion LengthFlags; // 0x0
	public IntPtr Next; // 0x8
	public Win32_SOCKET_ADDRESS Address; // 0x10
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADAPTER_UNICAST_ADDRESS // TypeDefIndex: 6135
{
	// Fields
	public Win32LengthFlagsUnion LengthFlags; // 0x0
	public IntPtr Next; // 0x8
	public Win32_SOCKET_ADDRESS Address; // 0x10
	public PrefixOrigin PrefixOrigin; // 0x20
	public SuffixOrigin SuffixOrigin; // 0x24
	public DuplicateAddressDetectionState DadState; // 0x28
	public uint ValidLifetime; // 0x2C
	public uint PreferredLifetime; // 0x30
	public uint LeaseLifetime; // 0x34
	public byte OnLinkPrefixLength; // 0x38
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_SOCKADDR // TypeDefIndex: 6136
{
	// Fields
	public ushort AddressFamily; // 0x0
	public byte[] AddressData; // 0x8
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_SOCKET_ADDRESS // TypeDefIndex: 6137
{
	// Fields
	public IntPtr Sockaddr; // 0x0
	public int SockaddrLength; // 0x8
	private const int AF_INET6 = 23;

	// Methods

	// RVA: 0x21FFD10 Offset: 0x21FEF10 VA: 0x1821FFD10
	public IPAddress GetIPAddress() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32TcpStatistics : TcpStatistics // TypeDefIndex: 6138
{
	// Fields
	private Win32_MIB_TCPSTATS info; // 0x10

	// Properties
	public override long ConnectionsAccepted { get; }
	public override long ConnectionsInitiated { get; }
	public override long CumulativeConnections { get; }
	public override long CurrentConnections { get; }
	public override long ErrorsReceived { get; }
	public override long FailedConnectionAttempts { get; }
	public override long MaximumConnections { get; }
	public override long MaximumTransmissionTimeout { get; }
	public override long MinimumTransmissionTimeout { get; }
	public override long ResetConnections { get; }
	public override long ResetsSent { get; }
	public override long SegmentsReceived { get; }
	public override long SegmentsResent { get; }
	public override long SegmentsSent { get; }

	// Methods

	// RVA: 0x21FF410 Offset: 0x21FE610 VA: 0x1821FF410
	public void .ctor(Win32_MIB_TCPSTATS info) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90 Slot: 4
	public override long get_ConnectionsAccepted() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 5
	public override long get_ConnectionsInitiated() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0 Slot: 6
	public override long get_CumulativeConnections() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 7
	public override long get_CurrentConnections() { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 8
	public override long get_ErrorsReceived() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050 Slot: 9
	public override long get_FailedConnectionAttempts() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 10
	public override long get_MaximumConnections() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 11
	public override long get_MaximumTransmissionTimeout() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 12
	public override long get_MinimumTransmissionTimeout() { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0 Slot: 13
	public override long get_ResetConnections() { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0 Slot: 17
	public override long get_ResetsSent() { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480 Slot: 14
	public override long get_SegmentsReceived() { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 15
	public override long get_SegmentsResent() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 16
	public override long get_SegmentsSent() { }
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_MIB_TCPSTATS // TypeDefIndex: 6139
{
	// Fields
	public uint RtoAlgorithm; // 0x0
	public uint RtoMin; // 0x4
	public uint RtoMax; // 0x8
	public uint MaxConn; // 0xC
	public uint ActiveOpens; // 0x10
	public uint PassiveOpens; // 0x14
	public uint AttemptFails; // 0x18
	public uint EstabResets; // 0x1C
	public uint CurrEstab; // 0x20
	public uint InSegs; // 0x24
	public uint OutSegs; // 0x28
	public uint RetransSegs; // 0x2C
	public uint InErrs; // 0x30
	public uint OutRsts; // 0x34
	public uint NumConns; // 0x38
}

// Namespace: System.Net.NetworkInformation
internal class Win32UdpStatistics : UdpStatistics // TypeDefIndex: 6140
{
	// Fields
	private Win32_MIB_UDPSTATS info; // 0x10

	// Properties
	public override long DatagramsReceived { get; }
	public override long DatagramsSent { get; }
	public override long IncomingDatagramsDiscarded { get; }
	public override long IncomingDatagramsWithErrors { get; }
	public override int UdpListeners { get; }

	// Methods

	// RVA: 0x21FF460 Offset: 0x21FE660 VA: 0x1821FF460
	public void .ctor(Win32_MIB_UDPSTATS info) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 4
	public override long get_DatagramsReceived() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 5
	public override long get_DatagramsSent() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 6
	public override long get_IncomingDatagramsDiscarded() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 7
	public override long get_IncomingDatagramsWithErrors() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 8
	public override int get_UdpListeners() { }
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_MIB_UDPSTATS // TypeDefIndex: 6141
{
	// Fields
	public uint InDatagrams; // 0x0
	public uint NoPorts; // 0x4
	public uint InErrors; // 0x8
	public uint OutDatagrams; // 0xC
	public int NumAddrs; // 0x10
}

// Namespace: System.Net.NetworkInformation
internal class Win32UnicastIPAddressInformation : UnicastIPAddressInformation // TypeDefIndex: 6142
{
	// Fields
	private Win32_IP_ADAPTER_UNICAST_ADDRESS info; // 0x10
	private IPAddress ipv4Mask; // 0x50

	// Properties
	public override IPAddress Address { get; }
	public override bool IsDnsEligible { get; }
	public override bool IsTransient { get; }
	public override long AddressPreferredLifetime { get; }
	public override long AddressValidLifetime { get; }
	public override long DhcpLeaseLifetime { get; }
	public override DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }
	public override IPAddress IPv4Mask { get; }
	public override PrefixOrigin PrefixOrigin { get; }
	public override SuffixOrigin SuffixOrigin { get; }

	// Methods

	// RVA: 0x21FF570 Offset: 0x21FE770 VA: 0x1821FF570
	public void .ctor(Win32_IP_ADAPTER_UNICAST_ADDRESS info) { }

	// RVA: 0x21FF6A0 Offset: 0x21FE8A0 VA: 0x1821FF6A0 Slot: 4
	public override IPAddress get_Address() { }

	// RVA: 0x21FF740 Offset: 0x21FE940 VA: 0x1821FF740 Slot: 5
	public override bool get_IsDnsEligible() { }

	// RVA: 0x1D5C050 Offset: 0x1D5B250 VA: 0x181D5C050 Slot: 6
	public override bool get_IsTransient() { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 7
	public override long get_AddressPreferredLifetime() { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 8
	public override long get_AddressValidLifetime() { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0 Slot: 9
	public override long get_DhcpLeaseLifetime() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 10
	public override DuplicateAddressDetectionState get_DuplicateAddressDetectionState() { }

	// RVA: 0x21FF6B0 Offset: 0x21FE8B0 VA: 0x1821FF6B0 Slot: 13
	public override IPAddress get_IPv4Mask() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 11
	public override PrefixOrigin get_PrefixOrigin() { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480 Slot: 12
	public override SuffixOrigin get_SuffixOrigin() { }

	// RVA: 0x21FF490 Offset: 0x21FE690 VA: 0x1821FF490
	private static IPAddress PrefixLengthToSubnetMask(byte prefixLength, AddressFamily family) { }
}

// Namespace: System.Net.NetworkInformation
internal static class UnixNetworkInterfaceFactoryPal // TypeDefIndex: 6143
{
	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static NetworkInterfaceFactory Create() { }
}

// Namespace: System.Net.NetworkInformation
internal static class UnixIPGlobalPropertiesFactoryPal // TypeDefIndex: 6144
{
	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static IPGlobalProperties Create() { }
}

// Namespace: System.Net.Configuration
internal sealed class DefaultProxySectionInternal // TypeDefIndex: 6145
{
	// Fields
	private IWebProxy webProxy; // 0x10
	private static object classSyncObject; // 0x0

	// Properties
	internal static object ClassSyncObject { get; }
	internal IWebProxy WebProxy { get; }

	// Methods

	// RVA: 0x2188FF0 Offset: 0x21881F0 VA: 0x182188FF0
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	// RVA: 0x2188FF0 Offset: 0x21881F0 VA: 0x182188FF0
	private static IWebProxy GetSystemWebProxy() { }

	// RVA: 0x21D4600 Offset: 0x21D3800 VA: 0x1821D4600
	internal static object get_ClassSyncObject() { }

	// RVA: 0x21D44A0 Offset: 0x21D36A0 VA: 0x1821D44A0
	internal static DefaultProxySectionInternal GetSection() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal IWebProxy get_WebProxy() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net.Configuration
public enum UnicodeDecodingConformance // TypeDefIndex: 6146
{
	// Fields
	public int value__; // 0x0
	public const UnicodeDecodingConformance Auto = 0;
	public const UnicodeDecodingConformance Strict = 1;
	public const UnicodeDecodingConformance Compat = 2;
	public const UnicodeDecodingConformance Loose = 3;
}

// Namespace: System.Net.Configuration
public enum UnicodeEncodingConformance // TypeDefIndex: 6147
{
	// Fields
	public int value__; // 0x0
	public const UnicodeEncodingConformance Auto = 0;
	public const UnicodeEncodingConformance Strict = 1;
	public const UnicodeEncodingConformance Compat = 2;
}

// Namespace: System.Net.Configuration
internal sealed class SettingsSectionInternal // TypeDefIndex: 6148
{
	// Fields
	private static readonly SettingsSectionInternal instance; // 0x0
	internal readonly bool HttpListenerUnescapeRequestUrl; // 0x10
	internal readonly IPProtectionLevel IPProtectionLevel; // 0x14
	[CompilerGenerated]
	private bool <UseNagleAlgorithm>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <Expect100Continue>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <CheckCertificateName>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <DnsRefreshTimeout>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <EnableDnsRoundRobin>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <CheckCertificateRevocationList>k__BackingField; // 0x21
	[CompilerGenerated]
	private EncryptionPolicy <EncryptionPolicy>k__BackingField; // 0x24

	// Properties
	internal static SettingsSectionInternal Section { get; }
	internal bool UseNagleAlgorithm { get; set; }
	internal bool Expect100Continue { get; set; }
	internal bool CheckCertificateName { get; set; }
	internal int DnsRefreshTimeout { get; set; }
	internal bool EnableDnsRoundRobin { get; set; }
	internal bool CheckCertificateRevocationList { get; set; }
	internal EncryptionPolicy EncryptionPolicy { get; set; }
	internal bool Ipv6Enabled { get; }

	// Methods

	// RVA: 0x21E1D70 Offset: 0x21E0F70 VA: 0x1821E1D70
	internal static SettingsSectionInternal get_Section() { }

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	internal bool get_UseNagleAlgorithm() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	internal void set_UseNagleAlgorithm(bool value) { }

	[CompilerGenerated]
	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40
	internal bool get_Expect100Continue() { }

	[CompilerGenerated]
	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50
	internal void set_Expect100Continue(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81F0F0 Offset: 0x81E2F0 VA: 0x18081F0F0
	internal bool get_CheckCertificateName() { }

	[CompilerGenerated]
	// RVA: 0x18AE3F0 Offset: 0x18AD5F0 VA: 0x1818AE3F0
	private void set_CheckCertificateName(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	internal int get_DnsRefreshTimeout() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	internal void set_DnsRefreshTimeout(int value) { }

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	internal bool get_EnableDnsRoundRobin() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	internal void set_EnableDnsRoundRobin(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	internal bool get_CheckCertificateRevocationList() { }

	[CompilerGenerated]
	// RVA: 0x4BD770 Offset: 0x4BC970 VA: 0x1804BD770
	internal void set_CheckCertificateRevocationList(bool value) { }

	[CompilerGenerated]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	internal EncryptionPolicy get_EncryptionPolicy() { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	private void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	internal bool get_Ipv6Enabled() { }

	// RVA: 0x19EA0D0 Offset: 0x19E92D0 VA: 0x1819EA0D0
	public void .ctor() { }

	// RVA: 0x21E1D10 Offset: 0x21E0F10 VA: 0x1821E1D10
	private static void .cctor() { }
}

// Namespace: System.Net.Cache
internal abstract class RequestCache // TypeDefIndex: 6149
{
	// Fields
	internal static readonly char[] LineSplits; // 0x0
	private bool _IsPrivateCache; // 0x10
	private bool _CanWrite; // 0x11

	// Properties
	internal bool IsPrivateCache { get; }
	internal bool CanWrite { get; }

	// Methods

	// RVA: 0x8035A0 Offset: 0x8027A0 VA: 0x1808035A0
	protected void .ctor(bool isPrivateCache, bool canWrite) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	internal bool get_IsPrivateCache() { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	internal bool get_CanWrite() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract Stream Retrieve(string key, out RequestCacheEntry cacheEntry);

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract Stream Store(string key, long contentLength, DateTime expiresUtc, DateTime lastModifiedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract void Remove(string key);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void Update(string key, DateTime expiresUtc, DateTime lastModifiedUtc, DateTime lastSynchronizedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract bool TryRetrieve(string key, out RequestCacheEntry cacheEntry, out Stream readStream);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool TryStore(string key, long contentLength, DateTime expiresUtc, DateTime lastModifiedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata, out Stream writeStream);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool TryRemove(string key);

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool TryUpdate(string key, DateTime expiresUtc, DateTime lastModifiedUtc, DateTime lastSynchronizedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract void UnlockEntry(Stream retrieveStream);

	// RVA: 0x21E1BE0 Offset: 0x21E0DE0 VA: 0x1821E1BE0
	private static void .cctor() { }
}

// Namespace: System.Net.Cache
internal class RequestCacheEntry // TypeDefIndex: 6150
{
	// Fields
	private bool m_IsPrivateEntry; // 0x10
	private long m_StreamSize; // 0x18
	private DateTime m_ExpiresUtc; // 0x20
	private int m_HitCount; // 0x28
	private DateTime m_LastAccessedUtc; // 0x30
	private DateTime m_LastModifiedUtc; // 0x38
	private DateTime m_LastSynchronizedUtc; // 0x40
	private TimeSpan m_MaxStale; // 0x48
	private int m_UsageCount; // 0x50
	private bool m_IsPartialEntry; // 0x54
	private StringCollection m_EntryMetadata; // 0x58
	private StringCollection m_SystemMetadata; // 0x60

	// Properties
	internal bool IsPrivateEntry { get; set; }
	internal long StreamSize { get; set; }
	internal DateTime ExpiresUtc { get; set; }
	internal DateTime LastAccessedUtc { get; set; }
	internal DateTime LastModifiedUtc { get; set; }
	internal DateTime LastSynchronizedUtc { get; set; }
	internal TimeSpan MaxStale { get; set; }
	internal int HitCount { get; set; }
	internal int UsageCount { get; set; }
	internal bool IsPartialEntry { get; set; }
	internal StringCollection EntryMetadata { get; set; }
	internal StringCollection SystemMetadata { get; set; }

	// Methods

	// RVA: 0x21E11F0 Offset: 0x21E03F0 VA: 0x1821E11F0
	internal void .ctor() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	internal bool get_IsPrivateEntry() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void set_IsPrivateEntry(bool value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal long get_StreamSize() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_StreamSize(long value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal DateTime get_ExpiresUtc() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_ExpiresUtc(DateTime value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal DateTime get_LastAccessedUtc() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_LastAccessedUtc(DateTime value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal DateTime get_LastModifiedUtc() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void set_LastModifiedUtc(DateTime value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal DateTime get_LastSynchronizedUtc() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_LastSynchronizedUtc(DateTime value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal TimeSpan get_MaxStale() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	internal void set_MaxStale(TimeSpan value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	internal int get_HitCount() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	internal void set_HitCount(int value) { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	internal int get_UsageCount() { }

	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630
	internal void set_UsageCount(int value) { }

	// RVA: 0x645A10 Offset: 0x644C10 VA: 0x180645A10
	internal bool get_IsPartialEntry() { }

	// RVA: 0x645A30 Offset: 0x644C30 VA: 0x180645A30
	internal void set_IsPartialEntry(bool value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal StringCollection get_EntryMetadata() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	internal void set_EntryMetadata(StringCollection value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal StringCollection get_SystemMetadata() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	internal void set_SystemMetadata(StringCollection value) { }

	// RVA: 0x21E0910 Offset: 0x21DFB10 VA: 0x1821E0910 Slot: 4
	internal virtual string ToString(bool verbose) { }
}

// Namespace: System.Net.Cache
internal sealed class RequestCacheManager // TypeDefIndex: 6151
{
	// Fields
	private static RequestCachingSectionInternal s_CacheConfigSettings; // 0x0
	private static readonly RequestCacheBinding s_BypassCacheBinding; // 0x8
	private static RequestCacheBinding s_DefaultGlobalBinding; // 0x10
	private static RequestCacheBinding s_DefaultHttpBinding; // 0x18
	private static RequestCacheBinding s_DefaultFtpBinding; // 0x20

	// Properties
	internal static bool IsCachingEnabled { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x21E1260 Offset: 0x21E0460 VA: 0x1821E1260
	internal static RequestCacheBinding GetBinding(string internedScheme) { }

	// RVA: 0x21E1990 Offset: 0x21E0B90 VA: 0x1821E1990
	internal static bool get_IsCachingEnabled() { }

	// RVA: 0x21E1640 Offset: 0x21E0840 VA: 0x1821E1640
	internal static void SetBinding(string uriScheme, RequestCacheBinding binding) { }

	// RVA: 0x21E14F0 Offset: 0x21E06F0 VA: 0x1821E14F0
	private static void LoadConfigSettings() { }

	// RVA: 0x21E18E0 Offset: 0x21E0AE0 VA: 0x1821E18E0
	private static void .cctor() { }
}

// Namespace: System.Net.Cache
internal class RequestCacheValidator // TypeDefIndex: 6152
{
	// Methods

	// RVA: 0x21E1BA0 Offset: 0x21E0DA0 VA: 0x1821E1BA0
	public object CreateValidator() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net.Cache
internal class RequestCachingSectionInternal // TypeDefIndex: 6153
{
	// Fields
	public readonly bool DisableAllCaching; // 0x10

	// Methods

	// RVA: 0x3D6D90 Offset: 0x3D5F90 VA: 0x1803D6D90
	public void .ctor() { }
}

// Namespace: System.Net.Cache
internal class RequestCacheBinding // TypeDefIndex: 6154
{
	// Fields
	private RequestCache m_RequestCache; // 0x10
	private RequestCacheValidator m_CacheValidator; // 0x18
	private RequestCachePolicy m_Policy; // 0x20

	// Properties
	internal RequestCache Cache { get; }
	internal RequestCacheValidator Validator { get; }
	internal RequestCachePolicy Policy { get; }

	// Methods

	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	internal void .ctor(RequestCache requestCache, RequestCacheValidator cacheValidator, RequestCachePolicy policy) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal RequestCache get_Cache() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal RequestCacheValidator get_Validator() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal RequestCachePolicy get_Policy() { }
}

// Namespace: System.Net.Cache
public enum RequestCacheLevel // TypeDefIndex: 6155
{
	// Fields
	public int value__; // 0x0
	public const RequestCacheLevel Default = 0;
	public const RequestCacheLevel BypassCache = 1;
	public const RequestCacheLevel CacheOnly = 2;
	public const RequestCacheLevel CacheIfAvailable = 3;
	public const RequestCacheLevel Revalidate = 4;
	public const RequestCacheLevel Reload = 5;
	public const RequestCacheLevel NoCacheNoStore = 6;
}

// Namespace: System.Net.Cache
public class RequestCachePolicy // TypeDefIndex: 6156
{
	// Fields
	private RequestCacheLevel m_Level; // 0x10

	// Properties
	public RequestCacheLevel Level { get; }

	// Methods

	// RVA: 0x408060 Offset: 0x407260 VA: 0x180408060
	public void .ctor() { }

	// RVA: 0x21E1AD0 Offset: 0x21E0CD0 VA: 0x1821E1AD0
	public void .ctor(RequestCacheLevel level) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public RequestCacheLevel get_Level() { }

	// RVA: 0x21E1A50 Offset: 0x21E0C50 VA: 0x1821E1A50 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Cache
public enum HttpRequestCacheLevel // TypeDefIndex: 6157
{
	// Fields
	public int value__; // 0x0
	public const HttpRequestCacheLevel Default = 0;
	public const HttpRequestCacheLevel BypassCache = 1;
	public const HttpRequestCacheLevel CacheOnly = 2;
	public const HttpRequestCacheLevel CacheIfAvailable = 3;
	public const HttpRequestCacheLevel Revalidate = 4;
	public const HttpRequestCacheLevel Reload = 5;
	public const HttpRequestCacheLevel NoCacheNoStore = 6;
	public const HttpRequestCacheLevel CacheOrNextCacheOnly = 7;
	public const HttpRequestCacheLevel Refresh = 8;
}

// Namespace: System.Net.Cache
public enum HttpCacheAgeControl // TypeDefIndex: 6158
{
	// Fields
	public int value__; // 0x0
	public const HttpCacheAgeControl None = 0;
	public const HttpCacheAgeControl MinFresh = 1;
	public const HttpCacheAgeControl MaxAge = 2;
	public const HttpCacheAgeControl MaxStale = 4;
	public const HttpCacheAgeControl MaxAgeAndMinFresh = 3;
	public const HttpCacheAgeControl MaxAgeAndMaxStale = 6;
}

// Namespace: System.Net.Cache
public class HttpRequestCachePolicy : RequestCachePolicy // TypeDefIndex: 6159
{
	// Fields
	internal static readonly HttpRequestCachePolicy BypassCache; // 0x0
	private HttpRequestCacheLevel m_Level; // 0x18
	private DateTime m_LastSyncDateUtc; // 0x20
	private TimeSpan m_MaxAge; // 0x28
	private TimeSpan m_MinFresh; // 0x30
	private TimeSpan m_MaxStale; // 0x38

	// Properties
	public HttpRequestCacheLevel Level { get; }
	public DateTime CacheSyncDate { get; }
	internal DateTime InternalCacheSyncDateUtc { get; }
	public TimeSpan MaxAge { get; }
	public TimeSpan MinFresh { get; }
	public TimeSpan MaxStale { get; }

	// Methods

	// RVA: 0x21D53A0 Offset: 0x21D45A0 VA: 0x1821D53A0
	public void .ctor() { }

	// RVA: 0x21D5230 Offset: 0x21D4430 VA: 0x1821D5230
	public void .ctor(HttpRequestCacheLevel level) { }

	// RVA: 0x21D53B0 Offset: 0x21D45B0 VA: 0x1821D53B0
	public void .ctor(HttpCacheAgeControl cacheAgeControl, TimeSpan ageOrFreshOrStale) { }

	// RVA: 0x21D4ED0 Offset: 0x21D40D0 VA: 0x1821D4ED0
	public void .ctor(HttpCacheAgeControl cacheAgeControl, TimeSpan maxAge, TimeSpan freshOrStale) { }

	// RVA: 0x21D51C0 Offset: 0x21D43C0 VA: 0x1821D51C0
	public void .ctor(DateTime cacheSyncDate) { }

	// RVA: 0x21D5020 Offset: 0x21D4220 VA: 0x1821D5020
	public void .ctor(HttpCacheAgeControl cacheAgeControl, TimeSpan maxAge, TimeSpan freshOrStale, DateTime cacheSyncDate) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public HttpRequestCacheLevel get_Level() { }

	// RVA: 0x21D54E0 Offset: 0x21D46E0 VA: 0x1821D54E0
	public DateTime get_CacheSyncDate() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal DateTime get_InternalCacheSyncDateUtc() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public TimeSpan get_MaxAge() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public TimeSpan get_MinFresh() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public TimeSpan get_MaxStale() { }

	// RVA: 0x21D4AB0 Offset: 0x21D3CB0 VA: 0x1821D4AB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21D4A30 Offset: 0x21D3C30 VA: 0x1821D4A30
	private static RequestCacheLevel MapLevel(HttpRequestCacheLevel level) { }

	// RVA: 0x21D4E70 Offset: 0x21D4070 VA: 0x1821D4E70
	private static void .cctor() { }
}

// Namespace: System.Net.Cache
internal class RequestCacheProtocol // TypeDefIndex: 6160
{
	// Methods

	// RVA: 0x21E1B50 Offset: 0x21E0D50 VA: 0x1821E1B50
	public void .ctor(object arg1, object arg2) { }
}

// Namespace: 
private enum MultipleConnectAsync.State // TypeDefIndex: 6161
{
	// Fields
	public int value__; // 0x0
	public const MultipleConnectAsync.State NotStarted = 0;
	public const MultipleConnectAsync.State DnsQuery = 1;
	public const MultipleConnectAsync.State ConnectAttempt = 2;
	public const MultipleConnectAsync.State Completed = 3;
	public const MultipleConnectAsync.State Canceled = 4;
}

// Namespace: System.Net.Sockets
internal abstract class MultipleConnectAsync // TypeDefIndex: 6162
{
	// Fields
	protected SocketAsyncEventArgs _userArgs; // 0x10
	protected SocketAsyncEventArgs _internalArgs; // 0x18
	protected DnsEndPoint _endPoint; // 0x20
	protected IPAddress[] _addressList; // 0x28
	protected int _nextAddress; // 0x30
	private MultipleConnectAsync.State _state; // 0x34
	private object _lockObject; // 0x38

	// Methods

	// RVA: 0x21D8AC0 Offset: 0x21D7CC0 VA: 0x1821D8AC0
	public bool StartConnectAsync(SocketAsyncEventArgs args, DnsEndPoint endPoint) { }

	// RVA: 0x21D8460 Offset: 0x21D7660 VA: 0x1821D8460
	private void DnsCallback(IAsyncResult result) { }

	// RVA: 0x21D84D0 Offset: 0x21D76D0 VA: 0x1821D84D0
	private bool DoDnsCallback(IAsyncResult result, bool sync) { }

	// RVA: 0x21D87D0 Offset: 0x21D79D0 VA: 0x1821D87D0
	private void InternalConnectCallback(object sender, SocketAsyncEventArgs args) { }

	// RVA: 0x21D7E40 Offset: 0x21D7040 VA: 0x1821D7E40
	private Exception AttemptConnection() { }

	// RVA: 0x21D7FF0 Offset: 0x21D71F0 VA: 0x1821D7FF0
	private Exception AttemptConnection(Socket attemptSocket, SocketAsyncEventArgs args) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnSucceed();

	// RVA: 0x21D8E90 Offset: 0x21D8090 VA: 0x1821D8E90
	private void Succeed() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnFail(bool abortive);

	// RVA: 0x21D87A0 Offset: 0x21D79A0 VA: 0x1821D87A0
	private bool Fail(bool sync, Exception e) { }

	// RVA: 0x21D8F10 Offset: 0x21D8110 VA: 0x1821D8F10
	private void SyncFail(Exception e) { }

	// RVA: 0x21D7DD0 Offset: 0x21D6FD0 VA: 0x1821D7DD0
	private void AsyncFail(Exception e) { }

	// RVA: 0x21D81B0 Offset: 0x21D73B0 VA: 0x1821D81B0
	public void Cancel() { }

	// RVA: 0x21D8100 Offset: 0x21D7300 VA: 0x1821D8100
	private void CallAsyncFail(object ignored) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract IPAddress GetNextAddress(out Socket attemptSocket);

	// RVA: 0x21D8FF0 Offset: 0x21D81F0 VA: 0x1821D8FF0
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x21D8100 Offset: 0x21D7300 VA: 0x1821D8100
	private void <Cancel>b__20_0(object s) { }
}

// Namespace: System.Net.Sockets
internal sealed class SingleSocketMultipleConnectAsync : MultipleConnectAsync // TypeDefIndex: 6163
{
	// Fields
	private Socket _socket; // 0x40
	private bool _userSocket; // 0x48

	// Methods

	// RVA: 0x21E1F10 Offset: 0x21E1110 VA: 0x1821E1F10
	public void .ctor(Socket socket, bool userSocket) { }

	// RVA: 0x21E1DC0 Offset: 0x21E0FC0 VA: 0x1821E1DC0 Slot: 6
	protected override IPAddress GetNextAddress(out Socket attemptSocket) { }

	// RVA: 0x21E1E80 Offset: 0x21E1080 VA: 0x1821E1E80 Slot: 5
	protected override void OnFail(bool abortive) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	protected override void OnSucceed() { }
}

// Namespace: System.Net.Sockets
internal sealed class DualSocketMultipleConnectAsync : MultipleConnectAsync // TypeDefIndex: 6164
{
	// Fields
	private Socket _socket4; // 0x40
	private Socket _socket6; // 0x48

	// Methods

	// RVA: 0x21D4870 Offset: 0x21D3A70 VA: 0x1821D4870
	public void .ctor(SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x21D46A0 Offset: 0x21D38A0 VA: 0x1821D46A0 Slot: 6
	protected override IPAddress GetNextAddress(out Socket attemptSocket) { }

	// RVA: 0x21D4820 Offset: 0x21D3A20 VA: 0x1821D4820 Slot: 4
	protected override void OnSucceed() { }

	// RVA: 0x21D4750 Offset: 0x21D3950 VA: 0x1821D4750 Slot: 5
	protected override void OnFail(bool abortive) { }
}

// Namespace: System.Net.Sockets
public class NetworkStream : Stream // TypeDefIndex: 6165
{
	// Fields
	private readonly Socket _streamSocket; // 0x28
	private readonly bool _ownsSocket; // 0x30
	private bool _readable; // 0x31
	private bool _writeable; // 0x32
	private int _closeTimeout; // 0x34
	private bool _cleanedUp; // 0x38
	private int _currentReadTimeout; // 0x3C
	private int _currentWriteTimeout; // 0x40

	// Properties
	protected Socket Socket { get; }
	protected bool Readable { get; set; }
	protected bool Writeable { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public virtual bool DataAvailable { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	internal Socket InternalSocket { get; }

	// Methods

	// RVA: 0x21DC6C0 Offset: 0x21DB8C0 VA: 0x1821DC6C0
	public void .ctor(Socket socket) { }

	// RVA: 0x21DC6E0 Offset: 0x21DB8E0 VA: 0x1821DC6E0
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x21DC710 Offset: 0x21DB910 VA: 0x1821DC710
	public void .ctor(Socket socket, FileAccess access) { }

	// RVA: 0x21DC730 Offset: 0x21DB930 VA: 0x1821DC730
	public void .ctor(Socket socket, FileAccess access, bool ownsSocket) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	protected Socket get_Socket() { }

	// RVA: 0x577B10 Offset: 0x576D10 VA: 0x180577B10
	protected bool get_Readable() { }

	// RVA: 0x21BB040 Offset: 0x21BA240 VA: 0x1821BB040
	protected void set_Readable(bool value) { }

	// RVA: 0x21BAF40 Offset: 0x21BA140 VA: 0x1821BAF40
	protected bool get_Writeable() { }

	// RVA: 0x21BB140 Offset: 0x21BA340 VA: 0x1821BB140
	protected void set_Writeable(bool value) { }

	// RVA: 0x577B10 Offset: 0x576D10 VA: 0x180577B10 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x21BAF40 Offset: 0x21BA140 VA: 0x1821BAF40 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x21DCBA0 Offset: 0x21DBDA0 VA: 0x1821DCBA0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x21DCD10 Offset: 0x21DBF10 VA: 0x1821DCD10 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x21DCC30 Offset: 0x21DBE30 VA: 0x1821DCC30 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x21DCDB0 Offset: 0x21DBFB0 VA: 0x1821DCDB0 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x21DC920 Offset: 0x21DBB20 VA: 0x1821DC920 Slot: 40
	public virtual bool get_DataAvailable() { }

	// RVA: 0x21DCB00 Offset: 0x21DBD00 VA: 0x1821DCB00 Slot: 11
	public override long get_Length() { }

	// RVA: 0x21DCB50 Offset: 0x21DBD50 VA: 0x1821DCB50 Slot: 12
	public override long get_Position() { }

	// RVA: 0x21DCCC0 Offset: 0x21DBEC0 VA: 0x1821DCCC0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x21DB640 Offset: 0x21DA840 VA: 0x1821DB640 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21DB290 Offset: 0x21DA490 VA: 0x1821DB290 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x21DAF50 Offset: 0x21DA150 VA: 0x1821DAF50 Slot: 35
	public override int Read(Span<byte> destination) { }

	// RVA: 0x21DAED0 Offset: 0x21DA0D0 VA: 0x1821DAED0 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x21DC310 Offset: 0x21DB510 VA: 0x1821DC310 Slot: 37
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x21DC050 Offset: 0x21DB250 VA: 0x1821DC050 Slot: 38
	public override void Write(ReadOnlySpan<byte> source) { }

	// RVA: 0x21DBFE0 Offset: 0x21DB1E0 VA: 0x1821DBFE0 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x21D9F80 Offset: 0x21D9180 VA: 0x1821D9F80
	public void Close(int timeout) { }

	// RVA: 0x21D9FF0 Offset: 0x21D91F0 VA: 0x1821D9FF0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x173CC70 Offset: 0x173BE70 VA: 0x18173CC70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x21D9800 Offset: 0x21D8A00 VA: 0x1821D9800 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x21DA130 Offset: 0x21D9330 VA: 0x1821DA130 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x21D9BC0 Offset: 0x21D8DC0 VA: 0x1821D9BC0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x21DA4A0 Offset: 0x21D96A0 VA: 0x1821DA4A0 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x21DA7A0 Offset: 0x21D99A0 VA: 0x1821DA7A0 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x21DABF0 Offset: 0x21D9DF0 VA: 0x1821DABF0 Slot: 27
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x21DB8B0 Offset: 0x21DAAB0 VA: 0x1821DB8B0 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x21DBD00 Offset: 0x21DAF00 VA: 0x1821DBD00 Slot: 31
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public override void Flush() { }

	// RVA: 0x21DA710 Offset: 0x21D9910 VA: 0x1821DA710 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x21DB690 Offset: 0x21DA890 VA: 0x1821DB690 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x21DB6E0 Offset: 0x21DA8E0 VA: 0x1821DB6E0
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	// RVA: 0x21DCA60 Offset: 0x21DBC60 VA: 0x1821DCA60
	internal Socket get_InternalSocket() { }
}

// Namespace: 
private class Socket.StateTaskCompletionSource<TField1, TResult> : TaskCompletionSource<TResult> // TypeDefIndex: 6166
{
	// Fields
	internal TField1 _field1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object baseState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3F9B0 Offset: 0xC3EBB0 VA: 0x180C3F9B0
	|-Socket.StateTaskCompletionSource<Int32Enum, SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC3F970 Offset: 0xC3EB70 VA: 0x180C3F970
	|-Socket.StateTaskCompletionSource<object, SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC3F990 Offset: 0xC3EB90 VA: 0x180C3F990
	|-Socket.StateTaskCompletionSource<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class Socket.StateTaskCompletionSource<TField1, TField2, TResult> : Socket.StateTaskCompletionSource<TField1, TResult> // TypeDefIndex: 6167
{
	// Fields
	internal TField2 _field2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object baseState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3F9D0 Offset: 0xC3EBD0 VA: 0x180C3F9D0
	|-Socket.StateTaskCompletionSource<Int32Enum, object, SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC3F990 Offset: 0xC3EB90 VA: 0x180C3F990
	|-Socket.StateTaskCompletionSource<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private sealed class Socket.CachedEventArgs // TypeDefIndex: 6168
{
	// Fields
	public Socket.TaskSocketAsyncEventArgs<Socket> TaskAccept; // 0x10
	public Socket.Int32TaskSocketAsyncEventArgs TaskReceive; // 0x18
	public Socket.Int32TaskSocketAsyncEventArgs TaskSend; // 0x20
	public Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive; // 0x28
	public Socket.AwaitableSocketAsyncEventArgs ValueTaskSend; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class Socket.TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs // TypeDefIndex: 6169
{
	// Fields
	internal AsyncTaskMethodBuilder<TResult> _builder; // 0x0
	internal bool _accessed; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5CDD0 Offset: 0xC5BFD0 VA: 0x180C5CDD0
	|-Socket.TaskSocketAsyncEventArgs<int>..ctor
	|-Socket.TaskSocketAsyncEventArgs<object>..ctor
	|-Socket.TaskSocketAsyncEventArgs<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5CB90 Offset: 0xC5BD90 VA: 0x180C5CB90
	|-Socket.TaskSocketAsyncEventArgs<int>.GetCompletionResponsibility
	|
	|-RVA: 0xC5CA70 Offset: 0xC5BC70 VA: 0x180C5CA70
	|-Socket.TaskSocketAsyncEventArgs<object>.GetCompletionResponsibility
	|
	|-RVA: 0xC5CCB0 Offset: 0xC5BEB0 VA: 0x180C5CCB0
	|-Socket.TaskSocketAsyncEventArgs<__Il2CppFullySharedGenericType>.GetCompletionResponsibility
	*/
}

// Namespace: 
private sealed class Socket.Int32TaskSocketAsyncEventArgs : Socket.TaskSocketAsyncEventArgs<int> // TypeDefIndex: 6170
{
	// Fields
	internal bool _wrapExceptionsInIOExceptions; // 0xD8

	// Methods

	// RVA: 0x2218EB0 Offset: 0x22180B0 VA: 0x182218EB0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Socket.AwaitableSocketAsyncEventArgs.<>c // TypeDefIndex: 6171
{
	// Fields
	public static readonly Socket.AwaitableSocketAsyncEventArgs.<>c <>9; // 0x0
	public static ContextCallback <>9__14_0; // 0x8
	public static SendOrPostCallback <>9__20_0; // 0x10

	// Methods

	// RVA: 0x222C790 Offset: 0x222B990 VA: 0x18222C790
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2227390 Offset: 0x2226590 VA: 0x182227390
	internal void <OnCompleted>b__14_0(object runState) { }

	// RVA: 0x22272D0 Offset: 0x22264D0 VA: 0x1822272D0
	internal void <InvokeContinuation>b__20_0(object s) { }

	// RVA: 0x222A100 Offset: 0x2229300 VA: 0x18222A100
	internal void <.cctor>b__27_0(object state) { }

	// RVA: 0x222A150 Offset: 0x2229350 VA: 0x18222A150
	internal void <.cctor>b__27_1(object state) { }
}

// Namespace: 
internal sealed class Socket.AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<int> // TypeDefIndex: 6172
{
	// Fields
	internal static readonly Socket.AwaitableSocketAsyncEventArgs Reserved; // 0x0
	private static readonly Action<object> s_completedSentinel; // 0x8
	private static readonly Action<object> s_availableSentinel; // 0x10
	private Action<object> _continuation; // 0xB8
	private ExecutionContext _executionContext; // 0xC0
	private object _scheduler; // 0xC8
	private short _token; // 0xD0
	[CompilerGenerated]
	private bool <WrapExceptionsInIOExceptions>k__BackingField; // 0xD2

	// Properties
	public bool WrapExceptionsInIOExceptions { get; set; }

	// Methods

	// RVA: 0x2212D90 Offset: 0x2211F90 VA: 0x182212D90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6BF9F0 Offset: 0x6BEBF0 VA: 0x1806BF9F0
	public bool get_WrapExceptionsInIOExceptions() { }

	[CompilerGenerated]
	// RVA: 0x2212E60 Offset: 0x2212060 VA: 0x182212E60
	public void set_WrapExceptionsInIOExceptions(bool value) { }

	// RVA: 0x2212830 Offset: 0x2211A30 VA: 0x182212830
	public bool Reserve() { }

	// RVA: 0x22127B0 Offset: 0x22119B0 VA: 0x1822127B0
	private void Release() { }

	// RVA: 0x2212440 Offset: 0x2211640 VA: 0x182212440 Slot: 5
	protected override void OnCompleted(SocketAsyncEventArgs _) { }

	// RVA: 0x2212650 Offset: 0x2211850 VA: 0x182212650
	public ValueTask<int> ReceiveAsync(Socket socket) { }

	// RVA: 0x22129C0 Offset: 0x2211BC0 VA: 0x1822129C0
	public ValueTask<int> SendAsync(Socket socket) { }

	// RVA: 0x22128B0 Offset: 0x2211AB0 VA: 0x1822128B0
	public ValueTask SendAsyncForNetworkStream(Socket socket) { }

	// RVA: 0x2211E70 Offset: 0x2211070 VA: 0x182211E70 Slot: 9
	public ValueTaskSourceStatus GetStatus(short token) { }

	// RVA: 0x2212220 Offset: 0x2211420 VA: 0x182212220 Slot: 10
	public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

	// RVA: 0x2211F10 Offset: 0x2211110 VA: 0x182211F10
	private void InvokeContinuation(Action<object> continuation, object state, bool forceAsync) { }

	// RVA: 0x2211E10 Offset: 0x2211010 VA: 0x182211E10 Slot: 11
	public int GetResult(short token) { }

	// RVA: 0x2212B20 Offset: 0x2211D20 VA: 0x182212B20 Slot: 8
	private void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token) { }

	// RVA: 0x2212BA0 Offset: 0x2211DA0 VA: 0x182212BA0
	private void ThrowIncorrectTokenException() { }

	// RVA: 0x2212BF0 Offset: 0x2211DF0 VA: 0x182212BF0
	private void ThrowMultipleContinuationsException() { }

	// RVA: 0x2212B70 Offset: 0x2211D70 VA: 0x182212B70
	private void ThrowException(SocketError error) { }

	// RVA: 0x2211D20 Offset: 0x2210F20 VA: 0x182211D20
	private Exception CreateException(SocketError error) { }

	// RVA: 0x2212C40 Offset: 0x2211E40 VA: 0x182212C40
	private static void .cctor() { }
}

// Namespace: 
private sealed class Socket.SendFileHandler : MulticastDelegate // TypeDefIndex: 6173
{
	// Methods

	// RVA: 0x221F050 Offset: 0x221E250 VA: 0x18221F050
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags) { }

	// RVA: 0x221EFB0 Offset: 0x221E1B0 VA: 0x18221EFB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class Socket.SendFileAsyncResult : IAsyncResult // TypeDefIndex: 6174
{
	// Fields
	private IAsyncResult ares; // 0x10
	private Socket.SendFileHandler d; // 0x18

	// Properties
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	public Socket.SendFileHandler Delegate { get; }
	public IAsyncResult Original { get; }

	// Methods

	// RVA: 0x162EF30 Offset: 0x162E130 VA: 0x18162EF30
	public void .ctor(Socket.SendFileHandler d, IAsyncResult ares) { }

	// RVA: 0x221EE00 Offset: 0x221E000 VA: 0x18221EE00 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x221EE50 Offset: 0x221E050 VA: 0x18221EE50 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x221EF10 Offset: 0x221E110 VA: 0x18221EF10 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x221EF60 Offset: 0x221E160 VA: 0x18221EF60 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Socket.SendFileHandler get_Delegate() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IAsyncResult get_Original() { }
}

// Namespace: 
private struct Socket.WSABUF // TypeDefIndex: 6175
{
	// Fields
	public int len; // 0x0
	public IntPtr buf; // 0x8
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Socket.<>c // TypeDefIndex: 6176
{
	// Fields
	public static readonly Socket.<>c <>9; // 0x0
	public static Func<Socket.CachedEventArgs> <>9__7_0; // 0x8
	public static AsyncCallback <>9__8_0; // 0x10
	public static AsyncCallback <>9__9_0; // 0x18
	public static AsyncCallback <>9__10_0; // 0x20
	public static AsyncCallback <>9__11_0; // 0x28
	public static AsyncCallback <>9__12_0; // 0x30
	public static Func<Socket.CachedEventArgs> <>9__14_0; // 0x38
	public static Func<Socket.AwaitableSocketAsyncEventArgs> <>9__14_1; // 0x40
	public static AsyncCallback <>9__15_0; // 0x48
	public static AsyncCallback <>9__15_1; // 0x50
	public static AsyncCallback <>9__17_0; // 0x58
	public static AsyncCallback <>9__18_0; // 0x60
	public static AsyncCallback <>9__19_0; // 0x68
	public static Func<Socket.CachedEventArgs> <>9__21_0; // 0x70
	public static Func<Socket.AwaitableSocketAsyncEventArgs> <>9__21_1; // 0x78
	public static Func<Socket.CachedEventArgs> <>9__22_0; // 0x80
	public static Func<Socket.AwaitableSocketAsyncEventArgs> <>9__22_1; // 0x88
	public static AsyncCallback <>9__23_0; // 0x90
	public static AsyncCallback <>9__23_1; // 0x98
	public static AsyncCallback <>9__25_0; // 0xA0
	public static AsyncCallback <>9__26_0; // 0xA8
	public static Func<Socket.CachedEventArgs> <>9__34_0; // 0xB0
	public static IOAsyncCallback <>9__295_0; // 0xB8
	public static IOAsyncCallback <>9__297_0; // 0xC0
	public static IOAsyncCallback <>9__308_0; // 0xC8
	public static IOAsyncCallback <>9__310_0; // 0xD0

	// Methods

	// RVA: 0x222C8B0 Offset: 0x222BAB0 VA: 0x18222C8B0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x22260F0 Offset: 0x22252F0 VA: 0x1822260F0
	internal Socket.CachedEventArgs <AcceptAsync>b__7_0() { }

	// RVA: 0x2225B00 Offset: 0x2224D00 VA: 0x182225B00
	internal void <AcceptAsyncApm>b__8_0(IAsyncResult iar) { }

	// RVA: 0x22270D0 Offset: 0x22262D0 VA: 0x1822270D0
	internal void <ConnectAsync>b__9_0(IAsyncResult iar) { }

	// RVA: 0x22262D0 Offset: 0x22254D0 VA: 0x1822262D0
	internal void <ConnectAsync>b__10_0(IAsyncResult iar) { }

	// RVA: 0x22264D0 Offset: 0x22256D0 VA: 0x1822264D0
	internal void <ConnectAsync>b__11_0(IAsyncResult iar) { }

	// RVA: 0x22266D0 Offset: 0x22258D0 VA: 0x1822266D0
	internal void <ConnectAsync>b__12_0(IAsyncResult iar) { }

	// RVA: 0x2227C60 Offset: 0x2226E60 VA: 0x182227C60
	internal Socket.CachedEventArgs <ReceiveAsync>b__14_0() { }

	// RVA: 0x2227CB0 Offset: 0x2226EB0 VA: 0x182227CB0
	internal Socket.AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1() { }

	// RVA: 0x2227460 Offset: 0x2226660 VA: 0x182227460
	internal void <ReceiveAsyncApm>b__15_0(IAsyncResult iar) { }

	// RVA: 0x2227660 Offset: 0x2226860 VA: 0x182227660
	internal void <ReceiveAsyncApm>b__15_1(IAsyncResult iar) { }

	// RVA: 0x2227A60 Offset: 0x2226C60 VA: 0x182227A60
	internal void <ReceiveAsyncApm>b__17_0(IAsyncResult iar) { }

	// RVA: 0x2228150 Offset: 0x2227350 VA: 0x182228150
	internal void <ReceiveFromAsync>b__18_0(IAsyncResult iar) { }

	// RVA: 0x22287A0 Offset: 0x22279A0 VA: 0x1822287A0
	internal void <ReceiveMessageFromAsync>b__19_0(IAsyncResult iar) { }

	// RVA: 0x2229AF0 Offset: 0x2228CF0 VA: 0x182229AF0
	internal Socket.CachedEventArgs <SendAsync>b__21_0() { }

	// RVA: 0x2229B40 Offset: 0x2228D40 VA: 0x182229B40
	internal Socket.AwaitableSocketAsyncEventArgs <SendAsync>b__21_1() { }

	// RVA: 0x2229600 Offset: 0x2228800 VA: 0x182229600
	internal Socket.CachedEventArgs <SendAsyncForNetworkStream>b__22_0() { }

	// RVA: 0x2229650 Offset: 0x2228850 VA: 0x182229650
	internal Socket.AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1() { }

	// RVA: 0x2228F50 Offset: 0x2228150 VA: 0x182228F50
	internal void <SendAsyncApm>b__23_0(IAsyncResult iar) { }

	// RVA: 0x2229150 Offset: 0x2228350 VA: 0x182229150
	internal void <SendAsyncApm>b__23_1(IAsyncResult iar) { }

	// RVA: 0x2229400 Offset: 0x2228600 VA: 0x182229400
	internal void <SendAsyncApm>b__25_0(IAsyncResult iar) { }

	// RVA: 0x2229E80 Offset: 0x2229080 VA: 0x182229E80
	internal void <SendToAsync>b__26_0(IAsyncResult iar) { }

	// RVA: 0x2228F00 Offset: 0x2228100 VA: 0x182228F00
	internal Socket.CachedEventArgs <RentSocketAsyncEventArgs>b__34_0() { }

	// RVA: 0x2229B90 Offset: 0x2228D90 VA: 0x182229B90
	internal void <SendAsync>b__295_0(IOAsyncResult s) { }

	// RVA: 0x22261C0 Offset: 0x22253C0 VA: 0x1822261C0
	internal void <BeginSend>b__297_0(IOAsyncResult s) { }

	// RVA: 0x222A080 Offset: 0x2229280 VA: 0x18222A080
	internal void <SendToAsync>b__308_0(IOAsyncResult s) { }

	// RVA: 0x2226140 Offset: 0x2225340 VA: 0x182226140
	internal void <BeginSendTo>b__310_0(IOAsyncResult s) { }

	// RVA: 0x222A1A0 Offset: 0x22293A0 VA: 0x18222A1A0
	internal void <.cctor>b__367_0(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x222B180 Offset: 0x222A380 VA: 0x18222B180
	internal void <.cctor>b__367_1(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x222B270 Offset: 0x222A470 VA: 0x18222B270
	internal void <.cctor>b__367_2(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x222B360 Offset: 0x222A560 VA: 0x18222B360
	internal void <.cctor>b__367_3(IAsyncResult ares) { }

	// RVA: 0x222B590 Offset: 0x222A790 VA: 0x18222B590
	internal void <.cctor>b__367_4(IOAsyncResult ares) { }

	// RVA: 0x222B680 Offset: 0x222A880 VA: 0x18222B680
	internal void <.cctor>b__367_5(IOAsyncResult ares) { }

	// RVA: 0x222B830 Offset: 0x222AA30 VA: 0x18222B830
	internal void <.cctor>b__367_6(IAsyncResult ares) { }

	// RVA: 0x222BA70 Offset: 0x222AC70 VA: 0x18222BA70
	internal void <.cctor>b__367_7(IOAsyncResult ares) { }

	// RVA: 0x222BCF0 Offset: 0x222AEF0 VA: 0x18222BCF0
	internal void <.cctor>b__367_8(IAsyncResult ares) { }

	// RVA: 0x222BF30 Offset: 0x222B130 VA: 0x18222BF30
	internal void <.cctor>b__367_9(IOAsyncResult ares) { }

	// RVA: 0x222A2B0 Offset: 0x22294B0 VA: 0x18222A2B0
	internal void <.cctor>b__367_10(IAsyncResult ares) { }

	// RVA: 0x222A500 Offset: 0x2229700 VA: 0x18222A500
	internal void <.cctor>b__367_11(IOAsyncResult ares) { }

	// RVA: 0x222A770 Offset: 0x2229970 VA: 0x18222A770
	internal void <.cctor>b__367_12(IOAsyncResult ares) { }

	// RVA: 0x222A840 Offset: 0x2229A40 VA: 0x18222A840
	internal void <.cctor>b__367_13(IAsyncResult ares) { }

	// RVA: 0x222AAC0 Offset: 0x2229CC0 VA: 0x18222AAC0
	internal void <.cctor>b__367_14(IOAsyncResult ares) { }

	// RVA: 0x222AC10 Offset: 0x2229E10 VA: 0x18222AC10
	internal void <.cctor>b__367_15(IAsyncResult ares) { }

	// RVA: 0x222AE60 Offset: 0x222A060 VA: 0x18222AE60
	internal void <.cctor>b__367_16(IOAsyncResult ares) { }

	// RVA: 0x222AF30 Offset: 0x222A130 VA: 0x18222AF30
	internal void <.cctor>b__367_17(IAsyncResult ares) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Socket.<>c__DisplayClass240_0 // TypeDefIndex: 6177
{
	// Fields
	public SocketAsyncResult sockares; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x222C3B0 Offset: 0x222B5B0 VA: 0x18222C3B0
	internal void <BeginConnect>b__0(Task<IPAddress[]> t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Socket.<>c__DisplayClass298_0 // TypeDefIndex: 6178
{
	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x222C4E0 Offset: 0x222B6E0 VA: 0x18222C4E0
	internal void <BeginSendCallback>b__0(IOAsyncResult s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Socket.<>c__DisplayClass311_0 // TypeDefIndex: 6179
{
	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x222C570 Offset: 0x222B770 VA: 0x18222C570
	internal void <BeginSendToCallback>b__0(IOAsyncResult s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Socket.<>c__DisplayClass316_0 // TypeDefIndex: 6180
{
	// Fields
	public AsyncCallback callback; // 0x10
	public Socket.SendFileHandler handler; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x222C600 Offset: 0x222B800 VA: 0x18222C600
	internal void <BeginSendFile>b__0(IAsyncResult ar) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Socket.<>c__DisplayClass355_0 // TypeDefIndex: 6181
{
	// Fields
	public Socket <>4__this; // 0x10
	public IOSelectorJob job; // 0x18
	public IntPtr handle; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x222C690 Offset: 0x222B890 VA: 0x18222C690
	internal void <QueueIOSelectorJob>b__0(Task t) { }
}

// Namespace: System.Net.Sockets
public class Socket : IDisposable // TypeDefIndex: 6182
{
	// Fields
	private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler; // 0x0
	private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler; // 0x8
	private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler; // 0x10
	private static readonly Socket.TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel; // 0x18
	private static readonly Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel; // 0x20
	private static readonly Task<int> s_zeroTask; // 0x28
	private Socket.CachedEventArgs _cachedTaskEventArgs; // 0x10
	private static object s_InternalSyncObject; // 0x30
	internal static bool s_SupportsIPv4; // 0x38
	internal static bool s_SupportsIPv6; // 0x39
	internal static bool s_OSSupportsIPv6; // 0x3A
	internal static bool s_Initialized; // 0x3B
	private static bool s_LoggingEnabled; // 0x3C
	internal static bool s_PerfCountersEnabled; // 0x3D
	internal const int DefaultCloseTimeout = -1;
	private const int SOCKET_CLOSED_CODE = 10004;
	private const string TIMEOUT_EXCEPTION_MSG = "A connection attempt failed because the connected party did not properly respondafter a period of time, or established connection failed because connected host has failed to respond";
	private bool is_closed; // 0x18
	private bool is_listening; // 0x19
	private bool useOverlappedIO; // 0x1A
	private int linger_timeout; // 0x1C
	private AddressFamily addressFamily; // 0x20
	private SocketType socketType; // 0x24
	private ProtocolType protocolType; // 0x28
	internal SafeSocketHandle m_Handle; // 0x30
	internal EndPoint seed_endpoint; // 0x38
	internal SemaphoreSlim ReadSem; // 0x40
	internal SemaphoreSlim WriteSem; // 0x48
	internal bool is_blocking; // 0x50
	internal bool is_bound; // 0x51
	internal bool is_connected; // 0x52
	private int m_IntCleanedUp; // 0x54
	internal bool connect_in_progress; // 0x58
	internal readonly int ID; // 0x5C
	private static AsyncCallback AcceptAsyncCallback; // 0x40
	private static IOAsyncCallback BeginAcceptCallback; // 0x48
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x50
	private static AsyncCallback ConnectAsyncCallback; // 0x58
	private static IOAsyncCallback BeginConnectCallback; // 0x60
	private static AsyncCallback DisconnectAsyncCallback; // 0x68
	private static IOAsyncCallback BeginDisconnectCallback; // 0x70
	private static AsyncCallback ReceiveAsyncCallback; // 0x78
	private static IOAsyncCallback BeginReceiveCallback; // 0x80
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x88
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x90
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x98
	private static AsyncCallback SendAsyncCallback; // 0xA0
	private static IOAsyncCallback BeginSendGenericCallback; // 0xA8
	private static AsyncCallback SendToAsyncCallback; // 0xB0

	// Properties
	[Obsolete("SupportsIPv4 is obsoleted for this type, please use OSSupportsIPv4 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static bool SupportsIPv4 { get; }
	public static bool OSSupportsIPv4 { get; }
	[Obsolete("SupportsIPv6 is obsoleted for this type, please use OSSupportsIPv6 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static bool SupportsIPv6 { get; }
	internal static bool LegacySupportsIPv6 { get; }
	public static bool OSSupportsIPv6 { get; }
	public IntPtr Handle { get; }
	public bool UseOnlyOverlappedIO { get; set; }
	public AddressFamily AddressFamily { get; }
	public SocketType SocketType { get; }
	public ProtocolType ProtocolType { get; }
	public bool ExclusiveAddressUse { get; set; }
	public int ReceiveBufferSize { get; set; }
	public int SendBufferSize { get; set; }
	public int ReceiveTimeout { get; set; }
	public int SendTimeout { get; set; }
	public LingerOption LingerState { get; set; }
	public short Ttl { get; set; }
	public bool DontFragment { get; set; }
	public bool DualMode { get; set; }
	private bool IsDualMode { get; }
	private static object InternalSyncObject { get; }
	internal bool CleanedUp { get; }
	public int Available { get; }
	public bool EnableBroadcast { get; set; }
	public bool IsBound { get; }
	public bool MulticastLoopback { get; set; }
	public EndPoint LocalEndPoint { get; }
	public bool Blocking { get; set; }
	public bool Connected { get; set; }
	public bool NoDelay { get; set; }
	public EndPoint RemoteEndPoint { get; }
	internal SafeHandle SafeHandle { get; }
	internal static int FamilyHint { get; }

	// Methods

	// RVA: 0x21E2100 Offset: 0x21E1300 VA: 0x1821E2100
	internal Task<Socket> AcceptAsync(Socket acceptSocket) { }

	// RVA: 0x21E1F90 Offset: 0x21E1190 VA: 0x1821E1F90
	private Task<Socket> AcceptAsyncApm(Socket acceptSocket) { }

	// RVA: 0x21E6E20 Offset: 0x21E6020 VA: 0x1821E6E20
	internal Task ConnectAsync(EndPoint remoteEP) { }

	// RVA: 0x21E7100 Offset: 0x21E6300 VA: 0x1821E7100
	internal Task ConnectAsync(IPAddress address, int port) { }

	// RVA: 0x21E6F90 Offset: 0x21E6190 VA: 0x1821E6F90
	internal Task ConnectAsync(IPAddress[] addresses, int port) { }

	// RVA: 0x21E7F10 Offset: 0x21E7110 VA: 0x1821E7F10
	internal Task ConnectAsync(string host, int port) { }

	// RVA: 0x21ED1F0 Offset: 0x21EC3F0 VA: 0x1821ED1F0
	internal Task<int> ReceiveAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream) { }

	// RVA: 0x21ECA50 Offset: 0x21EBC50 VA: 0x1821ECA50
	internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	// RVA: 0x21EC640 Offset: 0x21EB840 VA: 0x1821EC640
	private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x21ED100 Offset: 0x21EC300 VA: 0x1821ED100
	internal Task<int> ReceiveAsync(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x21EC390 Offset: 0x21EB590 VA: 0x1821EC390
	private Task<int> ReceiveAsyncApm(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x21ED5F0 Offset: 0x21EC7F0 VA: 0x1821ED5F0
	internal Task<SocketReceiveFromResult> ReceiveFromAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint) { }

	// RVA: 0x21EDFA0 Offset: 0x21ED1A0 VA: 0x1821EDFA0
	internal Task<SocketReceiveMessageFromResult> ReceiveMessageFromAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint) { }

	// RVA: 0x21F11E0 Offset: 0x21F03E0 VA: 0x1821F11E0
	internal Task<int> SendAsync(ArraySegment<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x21F0C40 Offset: 0x21EFE40 VA: 0x1821F0C40
	internal ValueTask<int> SendAsync(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x21F04E0 Offset: 0x21EF6E0 VA: 0x1821F04E0
	internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x21EFF10 Offset: 0x21EF110 VA: 0x1821EFF10
	private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x21F0FB0 Offset: 0x21F01B0 VA: 0x1821F0FB0
	internal Task<int> SendAsync(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x21F0370 Offset: 0x21EF570 VA: 0x1821F0370
	private Task<int> SendAsyncApm(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x21F1690 Offset: 0x21F0890 VA: 0x1821F1690
	internal Task<int> SendToAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x21F45C0 Offset: 0x21F37C0 VA: 0x1821F45C0
	private static void ValidateBuffer(ArraySegment<byte> buffer) { }

	// RVA: 0x21F47A0 Offset: 0x21F39A0 VA: 0x1821F47A0
	private static void ValidateBuffersList(IList<ArraySegment<byte>> buffers) { }

	// RVA: 0x21E6D60 Offset: 0x21E5F60 VA: 0x1821E6D60
	private static void ConfigureBufferList(Socket.Int32TaskSocketAsyncEventArgs saea, IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x21EAC90 Offset: 0x21E9E90 VA: 0x1821EAC90
	private Task<int> GetTaskForSendReceive(bool pending, Socket.Int32TaskSocketAsyncEventArgs saea, bool fromNetworkStream, bool isReceive) { }

	// RVA: 0x21E69D0 Offset: 0x21E5BD0 VA: 0x1821E69D0
	private static void CompleteAccept(Socket s, Socket.TaskSocketAsyncEventArgs<Socket> saea) { }

	// RVA: 0x21E6BA0 Offset: 0x21E5DA0 VA: 0x1821E6BA0
	private static void CompleteSendReceive(Socket s, Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x21EA490 Offset: 0x21E9690 VA: 0x1821EA490
	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = False) { }

	// RVA: 0x21EF7A0 Offset: 0x21EE9A0 VA: 0x1821EF7A0
	private Socket.Int32TaskSocketAsyncEventArgs RentSocketAsyncEventArgs(bool isReceive) { }

	// RVA: 0x21EFA60 Offset: 0x21EEC60 VA: 0x1821EFA60
	private void ReturnSocketAsyncEventArgs(Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x21EFA00 Offset: 0x21EEC00 VA: 0x1821EFA00
	private void ReturnSocketAsyncEventArgs(Socket.TaskSocketAsyncEventArgs<Socket> saea) { }

	// RVA: 0x21E8E60 Offset: 0x21E8060 VA: 0x1821E8E60
	private void DisposeCachedTaskSocketAsyncEventArgs() { }

	// RVA: 0x21F5450 Offset: 0x21F4650 VA: 0x1821F5450
	public void .ctor(SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x21F5170 Offset: 0x21F4370 VA: 0x1821F5170
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x21F67C0 Offset: 0x21F59C0 VA: 0x1821F67C0
	public static bool get_SupportsIPv4() { }

	// RVA: 0x21F6400 Offset: 0x21F5600 VA: 0x1821F6400
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x21F6820 Offset: 0x21F5A20 VA: 0x1821F6820
	public static bool get_SupportsIPv6() { }

	// RVA: 0x21F5FC0 Offset: 0x21F51C0 VA: 0x1821F5FC0
	internal static bool get_LegacySupportsIPv6() { }

	// RVA: 0x21F6460 Offset: 0x21F5660 VA: 0x1821F6460
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x201A420 Offset: 0x2019620 VA: 0x18201A420
	public IntPtr get_Handle() { }

	// RVA: 0x81F0F0 Offset: 0x81E2F0 VA: 0x18081F0F0
	public bool get_UseOnlyOverlappedIO() { }

	// RVA: 0x18AE3F0 Offset: 0x18AD5F0 VA: 0x1818AE3F0
	public void set_UseOnlyOverlappedIO(bool value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public SocketType get_SocketType() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x21F5C30 Offset: 0x21F4E30 VA: 0x1821F5C30
	public bool get_ExclusiveAddressUse() { }

	// RVA: 0x21F6C50 Offset: 0x21F5E50 VA: 0x1821F6C50
	public void set_ExclusiveAddressUse(bool value) { }

	// RVA: 0x21F64C0 Offset: 0x21F56C0 VA: 0x1821F64C0
	public int get_ReceiveBufferSize() { }

	// RVA: 0x21F6EA0 Offset: 0x21F60A0 VA: 0x1821F6EA0
	public void set_ReceiveBufferSize(int value) { }

	// RVA: 0x21F66C0 Offset: 0x21F58C0 VA: 0x1821F66C0
	public int get_SendBufferSize() { }

	// RVA: 0x21F6FB0 Offset: 0x21F61B0 VA: 0x1821F6FB0
	public void set_SendBufferSize(int value) { }

	// RVA: 0x21F6540 Offset: 0x21F5740 VA: 0x1821F6540
	public int get_ReceiveTimeout() { }

	// RVA: 0x21F6F20 Offset: 0x21F6120 VA: 0x1821F6F20
	public void set_ReceiveTimeout(int value) { }

	// RVA: 0x21F6740 Offset: 0x21F5940 VA: 0x1821F6740
	public int get_SendTimeout() { }

	// RVA: 0x21F7030 Offset: 0x21F6230 VA: 0x1821F7030
	public void set_SendTimeout(int value) { }

	// RVA: 0x21F6020 Offset: 0x21F5220 VA: 0x1821F6020
	public LingerOption get_LingerState() { }

	// RVA: 0x21F6CF0 Offset: 0x21F5EF0 VA: 0x1821F6CF0
	public void set_LingerState(LingerOption value) { }

	// RVA: 0x21F6880 Offset: 0x21F5A80 VA: 0x1821F6880
	public short get_Ttl() { }

	// RVA: 0x21F70C0 Offset: 0x21F62C0 VA: 0x1821F70C0
	public void set_Ttl(short value) { }

	// RVA: 0x21F59A0 Offset: 0x21F4BA0 VA: 0x1821F59A0
	public bool get_DontFragment() { }

	// RVA: 0x21F6A80 Offset: 0x21F5C80 VA: 0x1821F6A80
	public void set_DontFragment(bool value) { }

	// RVA: 0x21F5A80 Offset: 0x21F4C80 VA: 0x1821F5A80
	public bool get_DualMode() { }

	// RVA: 0x21F6B20 Offset: 0x21F5D20 VA: 0x1821F6B20
	public void set_DualMode(bool value) { }

	// RVA: 0x21F5ED0 Offset: 0x21F50D0 VA: 0x1821F5ED0
	private bool get_IsDualMode() { }

	// RVA: 0x21E67E0 Offset: 0x21E59E0 VA: 0x1821E67E0
	internal bool CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0x21E8610 Offset: 0x21E7810 VA: 0x1821E8610
	public void Connect(IPAddress[] addresses, int port) { }

	// RVA: 0x21F2650 Offset: 0x21F1850 VA: 0x1821F2650
	public int Send(byte[] buffer, int size, SocketFlags socketFlags) { }

	// RVA: 0x21F2F10 Offset: 0x21F2110 VA: 0x1821F2F10
	public int Send(byte[] buffer, SocketFlags socketFlags) { }

	// RVA: 0x21F2740 Offset: 0x21F1940 VA: 0x1821F2740
	public int Send(byte[] buffer) { }

	// RVA: 0x21F3160 Offset: 0x21F2360 VA: 0x1821F3160
	public int Send(IList<ArraySegment<byte>> buffers) { }

	// RVA: 0x21F26D0 Offset: 0x21F18D0 VA: 0x1821F26D0
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x21F1620 Offset: 0x21F0820 VA: 0x1821F1620
	public void SendFile(string fileName) { }

	// RVA: 0x21F31D0 Offset: 0x21F23D0 VA: 0x1821F31D0
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x21F22D0 Offset: 0x21F14D0 VA: 0x1821F22D0
	public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x21F2230 Offset: 0x21F1430 VA: 0x1821F2230
	public int SendTo(byte[] buffer, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x21F2280 Offset: 0x21F1480 VA: 0x1821F2280
	public int SendTo(byte[] buffer, EndPoint remoteEP) { }

	// RVA: 0x21EF340 Offset: 0x21EE540 VA: 0x1821EF340
	public int Receive(byte[] buffer, int size, SocketFlags socketFlags) { }

	// RVA: 0x21EF0A0 Offset: 0x21EE2A0 VA: 0x1821EF0A0
	public int Receive(byte[] buffer, SocketFlags socketFlags) { }

	// RVA: 0x21EE690 Offset: 0x21ED890 VA: 0x1821EE690
	public int Receive(byte[] buffer) { }

	// RVA: 0x21EE8B0 Offset: 0x21EDAB0 VA: 0x1821EE8B0
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x21EF2D0 Offset: 0x21EE4D0 VA: 0x1821EF2D0
	public int Receive(IList<ArraySegment<byte>> buffers) { }

	// RVA: 0x21EF530 Offset: 0x21EE730 VA: 0x1821EF530
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x21EDD90 Offset: 0x21ECF90 VA: 0x1821EDD90
	public int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref EndPoint remoteEP) { }

	// RVA: 0x21EDDC0 Offset: 0x21ECFC0 VA: 0x1821EDDC0
	public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP) { }

	// RVA: 0x21ED930 Offset: 0x21ECB30 VA: 0x1821ED930
	public int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP) { }

	// RVA: 0x21EB010 Offset: 0x21EA210 VA: 0x1821EB010
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x21F3250 Offset: 0x21F2450 VA: 0x1821F3250
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x21E56A0 Offset: 0x21E48A0 VA: 0x1821E56A0
	public IAsyncResult BeginSendFile(string fileName, AsyncCallback callback, object state) { }

	// RVA: 0x21E36F0 Offset: 0x21E28F0 VA: 0x1821E36F0
	public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x21E6180 Offset: 0x21E5380 VA: 0x1821E6180
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x21E5F90 Offset: 0x21E5190 VA: 0x1821E5F90
	public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x21EA110 Offset: 0x21E9310 VA: 0x1821EA110
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x21E4C10 Offset: 0x21E3E10 VA: 0x1821E4C10
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x21E4A70 Offset: 0x21E3C70 VA: 0x1821E4A70
	public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x21E9D10 Offset: 0x21E8F10 VA: 0x1821E9D10
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x21E30D0 Offset: 0x21E22D0 VA: 0x1821E30D0
	public IAsyncResult BeginAccept(int receiveSize, AsyncCallback callback, object state) { }

	// RVA: 0x21E9700 Offset: 0x21E8900 VA: 0x1821E9700
	public Socket EndAccept(out byte[] buffer, IAsyncResult asyncResult) { }

	// RVA: 0x21F5DE0 Offset: 0x21F4FE0 VA: 0x1821F5DE0
	private static object get_InternalSyncObject() { }

	// RVA: 0x21F5990 Offset: 0x21F4B90 VA: 0x1821F5990
	internal bool get_CleanedUp() { }

	// RVA: 0x21EB4E0 Offset: 0x21EA6E0 VA: 0x1821EB4E0
	internal static void InitializeSockets() { }

	// RVA: 0x21E91D0 Offset: 0x21E83D0 VA: 0x1821E91D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x15667F0 Offset: 0x15659F0 VA: 0x1815667F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x21E7270 Offset: 0x21E6470 VA: 0x1821E7270
	public static bool ConnectAsync(SocketType socketType, ProtocolType protocolType, SocketAsyncEventArgs e) { }

	// RVA: 0x21EB820 Offset: 0x21EAA20 VA: 0x1821EB820
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x21F4590 Offset: 0x21F3790 VA: 0x1821F4590
	internal IAsyncResult UnsafeBeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x21F45B0 Offset: 0x21F37B0 VA: 0x1821F45B0
	internal IAsyncResult UnsafeBeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x21F45A0 Offset: 0x21F37A0 VA: 0x1821F45A0
	internal IAsyncResult UnsafeBeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x21E4210 Offset: 0x21E3410 VA: 0x1821E4210
	internal IAsyncResult BeginMultipleSend(BufferOffsetSize[] buffers, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x21E4210 Offset: 0x21E3410 VA: 0x1821E4210
	internal IAsyncResult UnsafeBeginMultipleSend(BufferOffsetSize[] buffers, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x21E9920 Offset: 0x21E8B20 VA: 0x1821E9920
	internal int EndMultipleSend(IAsyncResult asyncResult) { }

	// RVA: 0x21EBDD0 Offset: 0x21EAFD0 VA: 0x1821EBDD0
	internal void MultipleSend(BufferOffsetSize[] buffers, SocketFlags socketFlags) { }

	// RVA: 0x21F3AA0 Offset: 0x21F2CA0 VA: 0x1821F3AA0
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x21F5490 Offset: 0x21F4690 VA: 0x1821F5490
	public void .ctor(SocketInformation socketInformation) { }

	// RVA: 0x21F57C0 Offset: 0x21F49C0 VA: 0x1821F57C0
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x21F3FF0 Offset: 0x21F31F0 VA: 0x1821F3FF0
	private void SocketDefaults() { }

	// RVA: 0x21F41D0 Offset: 0x21F33D0 VA: 0x1821F41D0
	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x21F58D0 Offset: 0x21F4AD0 VA: 0x1821F58D0
	public int get_Available() { }

	// RVA: 0x21E2FC0 Offset: 0x21E21C0 VA: 0x1821E2FC0
	private static int Available_internal(SafeSocketHandle safeHandle, out int error) { }

	// RVA: 0x21E2FB0 Offset: 0x21E21B0 VA: 0x1821E2FB0
	private static int Available_icall(IntPtr socket, out int error) { }

	// RVA: 0x21F5B60 Offset: 0x21F4D60 VA: 0x1821F5B60
	public bool get_EnableBroadcast() { }

	// RVA: 0x21F6BC0 Offset: 0x21F5DC0 VA: 0x1821F6BC0
	public void set_EnableBroadcast(bool value) { }

	// RVA: 0x163B670 Offset: 0x163A870 VA: 0x18163B670
	public bool get_IsBound() { }

	// RVA: 0x21F61C0 Offset: 0x21F53C0 VA: 0x1821F61C0
	public bool get_MulticastLoopback() { }

	// RVA: 0x21F6D20 Offset: 0x21F5F20 VA: 0x1821F6D20
	public void set_MulticastLoopback(bool value) { }

	// RVA: 0x21F60C0 Offset: 0x21F52C0 VA: 0x1821F60C0
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x21EBCA0 Offset: 0x21EAEA0 VA: 0x1821EBCA0
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x21EBC90 Offset: 0x21EAE90 VA: 0x1821EBC90
	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x4D1A10 Offset: 0x4D0C10 VA: 0x1804D1A10
	public bool get_Blocking() { }

	// RVA: 0x21F69A0 Offset: 0x21F5BA0 VA: 0x1821F69A0
	public void set_Blocking(bool value) { }

	// RVA: 0x21E66D0 Offset: 0x21E58D0 VA: 0x1821E66D0
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0x21E66C0 Offset: 0x21E58C0 VA: 0x1821E66C0
	internal static void Blocking_icall(IntPtr socket, bool block, out int error) { }

	// RVA: 0x1E0FA10 Offset: 0x1E0EC10 VA: 0x181E0FA10
	public bool get_Connected() { }

	// RVA: 0x21F6A70 Offset: 0x21F5C70 VA: 0x1821F6A70
	internal void set_Connected(bool value) { }

	// RVA: 0x21F6330 Offset: 0x21F5530 VA: 0x1821F6330
	public bool get_NoDelay() { }

	// RVA: 0x21F6E10 Offset: 0x21F6010 VA: 0x1821F6E10
	public void set_NoDelay(bool value) { }

	// RVA: 0x21F65C0 Offset: 0x21F57C0 VA: 0x1821F65C0
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x21EF670 Offset: 0x21EE870 VA: 0x1821EF670
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x21EF660 Offset: 0x21EE860 VA: 0x1821EF660
	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal SafeHandle get_SafeHandle() { }

	// RVA: 0x21EFAE0 Offset: 0x21EECE0 VA: 0x1821EFAE0
	public static void Select(IList checkRead, IList checkWrite, IList checkError, int microSeconds) { }

	// RVA: 0x21E2D00 Offset: 0x21E1F00 VA: 0x1821E2D00
	private static void AddSockets(List<Socket> sockets, IList list, string name) { }

	// RVA: 0x21EFAD0 Offset: 0x21EECD0 VA: 0x1821EFAD0
	private static void Select_icall(ref Socket[] sockets, int microSeconds, out int error) { }

	// RVA: 0x21EC0B0 Offset: 0x21EB2B0 VA: 0x1821EC0B0
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x21EBF70 Offset: 0x21EB170 VA: 0x1821EBF70
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x21EBF60 Offset: 0x21EB160 VA: 0x1821EBF60
	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x21E2A80 Offset: 0x21E1C80 VA: 0x1821E2A80
	public Socket Accept() { }

	// RVA: 0x21E2BD0 Offset: 0x21E1DD0 VA: 0x1821E2BD0
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x21E25F0 Offset: 0x21E17F0 VA: 0x1821E25F0
	public bool AcceptAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x21E3400 Offset: 0x21E2600 VA: 0x1821E3400
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x21E3100 Offset: 0x21E2300 VA: 0x1821E3100
	public IAsyncResult BeginAccept(Socket acceptSocket, int receiveSize, AsyncCallback callback, object state) { }

	// RVA: 0x21E95D0 Offset: 0x21E87D0 VA: 0x1821E95D0
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x21E9600 Offset: 0x21E8800 VA: 0x1821E9600
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x21E2950 Offset: 0x21E1B50 VA: 0x1821E2950
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0x21E2940 Offset: 0x21E1B40 VA: 0x1821E2940
	private static IntPtr Accept_icall(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0x21E6510 Offset: 0x21E5710 VA: 0x1821E6510
	public void Bind(EndPoint localEP) { }

	// RVA: 0x21E6400 Offset: 0x21E5600 VA: 0x1821E6400
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0x21E63F0 Offset: 0x21E55F0 VA: 0x1821E63F0
	private static void Bind_icall(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x21EBB80 Offset: 0x21EAD80 VA: 0x1821EBB80
	public void Listen(int backlog) { }

	// RVA: 0x21EBA70 Offset: 0x21EAC70 VA: 0x1821EBA70
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x21EBA60 Offset: 0x21EAC60 VA: 0x1821EBA60
	private static void Listen_icall(IntPtr sock, int backlog, out int error) { }

	// RVA: 0x21E8A40 Offset: 0x21E7C40 VA: 0x1821E8A40
	public void Connect(IPAddress address, int port) { }

	// RVA: 0x21E8590 Offset: 0x21E7790 VA: 0x1821E8590
	public void Connect(string host, int port) { }

	// RVA: 0x21E8190 Offset: 0x21E7390 VA: 0x1821E8190
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x21E7760 Offset: 0x21E6960 VA: 0x1821E7760
	public bool ConnectAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x21E6800 Offset: 0x21E5A00 VA: 0x1821E6800
	public static void CancelConnectAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x21E3C20 Offset: 0x21E2E20 VA: 0x1821E3C20
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	// RVA: 0x21E3580 Offset: 0x21E2780 VA: 0x1821E3580
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x21E3990 Offset: 0x21E2B90 VA: 0x1821E3990
	public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x21E4060 Offset: 0x21E3260 VA: 0x1821E4060
	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x21E4E00 Offset: 0x21E4000 VA: 0x1821E4E00
	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x21E97A0 Offset: 0x21E89A0 VA: 0x1821E97A0
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x21E8090 Offset: 0x21E7290 VA: 0x1821E8090
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x21E8080 Offset: 0x21E7280 VA: 0x1821E8080
	private static void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x21EA240 Offset: 0x21E9440 VA: 0x1821EA240
	private bool GetCheckedIPs(SocketAsyncEventArgs e, out IPAddress[] addresses) { }

	// RVA: 0x21E8D50 Offset: 0x21E7F50 VA: 0x1821E8D50
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x21E8AC0 Offset: 0x21E7CC0 VA: 0x1821E8AC0
	public bool DisconnectAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x21E3F20 Offset: 0x21E3120 VA: 0x1821E3F20
	public IAsyncResult BeginDisconnect(bool reuseSocket, AsyncCallback callback, object state) { }

	// RVA: 0x21E9860 Offset: 0x21E8A60 VA: 0x1821E9860
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x21E8C40 Offset: 0x21E7E40 VA: 0x1821E8C40
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0x21E8C30 Offset: 0x21E7E30 VA: 0x1821E8C30
	private static void Disconnect_icall(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x21EF3C0 Offset: 0x21EE5C0 VA: 0x1821EF3C0
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x21EE930 Offset: 0x21EDB30 VA: 0x1821EE930
	private int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(False)]
	// RVA: 0x21EEB30 Offset: 0x21EDD30 VA: 0x1821EEB30
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x21EE570 Offset: 0x21ED770 VA: 0x1821EE570
	public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x21F27E0 Offset: 0x21F19E0 VA: 0x1821F27E0
	public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x21EE730 Offset: 0x21ED930 VA: 0x1821EE730
	public int Receive(Span<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x21EF140 Offset: 0x21EE340 VA: 0x1821EF140
	public int Receive(Span<byte> buffer) { }

	// RVA: 0x21ECD90 Offset: 0x21EBF90 VA: 0x1821ECD90
	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x21E4870 Offset: 0x21E3A70 VA: 0x1821E4870
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	[CLSCompliant(False)]
	// RVA: 0x21E46C0 Offset: 0x21E38C0 VA: 0x1821E46C0
	public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x21E9C20 Offset: 0x21E8E20 VA: 0x1821E9C20
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x21EE440 Offset: 0x21ED640 VA: 0x1821EE440
	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x21EE2F0 Offset: 0x21ED4F0 VA: 0x1821EE2F0
	private static int Receive_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x21EE310 Offset: 0x21ED510 VA: 0x1821EE310
	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x21EE300 Offset: 0x21ED500 VA: 0x1821EE300
	private static int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x21EDC10 Offset: 0x21ECE10 VA: 0x1821EDC10
	public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP) { }

	// RVA: 0x21EDE10 Offset: 0x21ED010 VA: 0x1821EDE10
	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x21ED980 Offset: 0x21ECB80 VA: 0x1821ED980
	private int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x21ED300 Offset: 0x21EC500 VA: 0x1821ED300
	public bool ReceiveFromAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x21E4350 Offset: 0x21E3550 VA: 0x1821E4350
	public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x21E9A10 Offset: 0x21E8C10 VA: 0x1821E9A10
	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	// RVA: 0x21E9930 Offset: 0x21E8B30 VA: 0x1821E9930
	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	// RVA: 0x21ED7F0 Offset: 0x21EC9F0 VA: 0x1821ED7F0
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x21ED7E0 Offset: 0x21EC9E0 VA: 0x1821ED7E0
	private static int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	[MonoTODO("Not implemented")]
	// RVA: 0x21EE1D0 Offset: 0x21ED3D0 VA: 0x1821EE1D0
	public int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref EndPoint remoteEP, out IPPacketInformation ipPacketInformation) { }

	[MonoTODO("Not implemented")]
	// RVA: 0x21EE180 Offset: 0x21ED380 VA: 0x1821EE180
	public bool ReceiveMessageFromAsync(SocketAsyncEventArgs e) { }

	[MonoTODO]
	// RVA: 0x21E45A0 Offset: 0x21E37A0 VA: 0x1821E45A0
	public IAsyncResult BeginReceiveMessageFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state) { }

	[MonoTODO]
	// RVA: 0x21E9B40 Offset: 0x21E8D40 VA: 0x1821E9B40
	public int EndReceiveMessageFrom(IAsyncResult asyncResult, ref SocketFlags socketFlags, ref EndPoint endPoint, out IPPacketInformation ipPacketInformation) { }

	// RVA: 0x21F2FB0 Offset: 0x21F21B0 VA: 0x1821F2FB0
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(False)]
	// RVA: 0x21F2870 Offset: 0x21F1A70 VA: 0x1821F2870
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x21F2E30 Offset: 0x21F2030 VA: 0x1821F2E30
	public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x21F2580 Offset: 0x21F1780 VA: 0x1821F2580
	public int Send(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x21F0830 Offset: 0x21EFA30 VA: 0x1821F0830
	public bool SendAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x21E5D00 Offset: 0x21E4F00 VA: 0x1821E5D00
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x21E5350 Offset: 0x21E4550 VA: 0x1821E5350
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	[CLSCompliant(False)]
	// RVA: 0x21E6220 Offset: 0x21E5420 VA: 0x1821E6220
	public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x21EA020 Offset: 0x21E9220 VA: 0x1821EA020
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x21F2450 Offset: 0x21F1650 VA: 0x1821F2450
	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x21F2300 Offset: 0x21F1500 VA: 0x1821F2300
	private static int Send_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x21F2320 Offset: 0x21F1520 VA: 0x1821F2320
	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x21F2310 Offset: 0x21F1510 VA: 0x1821F2310
	private static int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x21F2000 Offset: 0x21F1200 VA: 0x1821F2000
	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x21F1D40 Offset: 0x21F0F40 VA: 0x1821F1D40
	private int SendTo(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x21F1870 Offset: 0x21F0A70 VA: 0x1821F1870
	public bool SendToAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x21E5A90 Offset: 0x21E4C90 VA: 0x1821E5A90
	public IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x21E58E0 Offset: 0x21E4AE0 VA: 0x1821E58E0
	private static void BeginSendToCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x21E9F60 Offset: 0x21E9160 VA: 0x1821E9F60
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x21F1C00 Offset: 0x21F0E00 VA: 0x1821F1C00
	private static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x21F1BF0 Offset: 0x21F0DF0 VA: 0x1821F1BF0
	private static int SendTo_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x21F1420 Offset: 0x21F0620 VA: 0x1821F1420
	public void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags) { }

	// RVA: 0x21E56D0 Offset: 0x21E48D0 VA: 0x1821E56D0
	public IAsyncResult BeginSendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags, AsyncCallback callback, object state) { }

	// RVA: 0x21E9E40 Offset: 0x21E9040 VA: 0x1821E9E40
	public void EndSendFile(IAsyncResult asyncResult) { }

	// RVA: 0x21F12E0 Offset: 0x21F04E0 VA: 0x1821F12E0
	private static bool SendFile_internal(SafeSocketHandle safeHandle, string filename, byte[] pre_buffer, byte[] post_buffer, TransmitFileOptions flags, out int error, bool blocking) { }

	// RVA: 0x21F12D0 Offset: 0x21F04D0 VA: 0x1821F12D0
	private static bool SendFile_icall(IntPtr sock, string filename, byte[] pre_buffer, byte[] post_buffer, TransmitFileOptions flags, out int error, bool blocking) { }

	[MonoTODO("Not implemented")]
	// RVA: 0x21F1640 Offset: 0x21F0840 VA: 0x1821F1640
	public bool SendPacketsAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	private static bool Duplicate_icall(IntPtr handle, int targetProcessId, out IntPtr duplicateHandle, out MonoIOError error) { }

	[MonoLimitation("We do not support passing sockets across processes, we merely allow this API to pass the socket across AppDomains")]
	// RVA: 0x21E9240 Offset: 0x21E8440 VA: 0x1821E9240
	public SocketInformation DuplicateAndClose(int targetProcessId) { }

	// RVA: 0x21EA900 Offset: 0x21E9B00 VA: 0x1821EA900
	public void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue) { }

	// RVA: 0x21EAA40 Offset: 0x21E9C40 VA: 0x1821EAA40
	public byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength) { }

	// RVA: 0x21EA6D0 Offset: 0x21E98D0 VA: 0x1821EA6D0
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x21EA590 Offset: 0x21E9790 VA: 0x1821EA590
	private static void GetSocketOption_arr_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, ref byte[] byte_val, out int error) { }

	// RVA: 0x21EA580 Offset: 0x21E9780 VA: 0x1821EA580
	private static void GetSocketOption_arr_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, ref byte[] byte_val, out int error) { }

	// RVA: 0x21EAB50 Offset: 0x21E9D50 VA: 0x1821EAB50
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x21EAB40 Offset: 0x21E9D40 VA: 0x1821EAB40
	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x21F3C10 Offset: 0x21F2E10 VA: 0x1821F3C10
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue) { }

	// RVA: 0x21F34E0 Offset: 0x21F26E0 VA: 0x1821F34E0
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue) { }

	// RVA: 0x21F3DA0 Offset: 0x21F2FA0 VA: 0x1821F3DA0
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) { }

	// RVA: 0x21F3960 Offset: 0x21F2B60 VA: 0x1821F3960
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x21F3380 Offset: 0x21F2580 VA: 0x1821F3380
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x21F3370 Offset: 0x21F2570 VA: 0x1821F3370
	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x21EB1B0 Offset: 0x21EA3B0 VA: 0x1821EB1B0
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x21EAED0 Offset: 0x21EA0D0 VA: 0x1821EAED0
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x21EAEC0 Offset: 0x21EA0C0 VA: 0x1821EAEC0
	private static int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x21E68F0 Offset: 0x21E5AF0 VA: 0x1821E68F0
	public void Close() { }

	// RVA: 0x21E6960 Offset: 0x21E5B60 VA: 0x1821E6960
	public void Close(int timeout) { }

	// RVA: 0x21E68E0 Offset: 0x21E5AE0 VA: 0x1821E68E0
	internal static void Close_icall(IntPtr socket, out int error) { }

	// RVA: 0x21F3EE0 Offset: 0x21F30E0 VA: 0x1821F3EE0
	public void Shutdown(SocketShutdown how) { }

	// RVA: 0x21F3DD0 Offset: 0x21F2FD0 VA: 0x1821F3DD0
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x21F3DC0 Offset: 0x21F2FC0 VA: 0x1821F3DC0
	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0x21E9000 Offset: 0x21E8200 VA: 0x1821E9000 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x21EB8F0 Offset: 0x21EAAF0 VA: 0x1821EB8F0
	private void Linger(IntPtr handle) { }

	// RVA: 0x21F4400 Offset: 0x21F3600 VA: 0x1821F4400
	private void ThrowIfDisposedAndClosed(Socket socket) { }

	// RVA: 0x21F44A0 Offset: 0x21F36A0 VA: 0x1821F44A0
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x21F41E0 Offset: 0x21F33E0 VA: 0x1821F41E0
	private void ThrowIfBufferNull(byte[] buffer) { }

	// RVA: 0x21F4240 Offset: 0x21F3440 VA: 0x1821F4240
	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	// RVA: 0x21F4530 Offset: 0x21F3730 VA: 0x1821F4530
	private void ThrowIfUdp() { }

	// RVA: 0x21F48C0 Offset: 0x21F3AC0 VA: 0x1821F48C0
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x21EC250 Offset: 0x21EB450 VA: 0x1821EC250
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x21EB350 Offset: 0x21EA550 VA: 0x1821EB350
	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x21F40A0 Offset: 0x21F32A0 VA: 0x1821F40A0
	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	// RVA: 0x21EF5A0 Offset: 0x21EE7A0 VA: 0x1821EF5A0
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x21F58C0 Offset: 0x21F4AC0 VA: 0x1821F58C0
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	internal static bool SupportsPortReuse(ProtocolType proto) { }

	// RVA: 0x21F5CB0 Offset: 0x21F4EB0 VA: 0x1821F5CB0
	internal static int get_FamilyHint() { }

	// RVA: 0x1679DF0 Offset: 0x1678FF0 VA: 0x181679DF0
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x21EB8A0 Offset: 0x21EAAA0 VA: 0x1821EB8A0
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void ReplaceHandleIfNecessaryAfterFailedConnect() { }

	// RVA: 0x21F4A30 Offset: 0x21F3C30 VA: 0x1821F4A30
	private static void .cctor() { }
}

// Namespace: System.Net.Sockets
[Serializable]
public class SocketException : Win32Exception // TypeDefIndex: 6183
{
	// Fields
	private EndPoint m_EndPoint; // 0x98

	// Properties
	public override int ErrorCode { get; }
	public override string Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0x2220A60 Offset: 0x221FC60 VA: 0x182220A60
	private static int WSAGetLastError_icall() { }

	// RVA: 0x2220B10 Offset: 0x221FD10 VA: 0x182220B10
	public void .ctor() { }

	// RVA: 0x215DA90 Offset: 0x215CC90 VA: 0x18215DA90
	internal void .ctor(int error, string message) { }

	// RVA: 0x2220AA0 Offset: 0x221FCA0 VA: 0x182220AA0
	internal void .ctor(EndPoint endPoint) { }

	// RVA: 0x215DAA0 Offset: 0x215CCA0 VA: 0x18215DAA0
	public void .ctor(int errorCode) { }

	// RVA: 0x2220A70 Offset: 0x221FC70 VA: 0x182220A70
	internal void .ctor(int errorCode, EndPoint endPoint) { }

	// RVA: 0x215DAA0 Offset: 0x215CCA0 VA: 0x18215DAA0
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x215DAB0 Offset: 0x215CCB0 VA: 0x18215DAB0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210 Slot: 18
	public override int get_ErrorCode() { }

	// RVA: 0x2220B30 Offset: 0x221FD30 VA: 0x182220B30 Slot: 5
	public override string get_Message() { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210
	public SocketError get_SocketErrorCode() { }
}

// Namespace: System.Net.Sockets
public enum AddressFamily // TypeDefIndex: 6184
{
	// Fields
	public int value__; // 0x0
	public const AddressFamily Unknown = -1;
	public const AddressFamily Unspecified = 0;
	public const AddressFamily Unix = 1;
	public const AddressFamily InterNetwork = 2;
	public const AddressFamily ImpLink = 3;
	public const AddressFamily Pup = 4;
	public const AddressFamily Chaos = 5;
	public const AddressFamily NS = 6;
	public const AddressFamily Ipx = 6;
	public const AddressFamily Iso = 7;
	public const AddressFamily Osi = 7;
	public const AddressFamily Ecma = 8;
	public const AddressFamily DataKit = 9;
	public const AddressFamily Ccitt = 10;
	public const AddressFamily Sna = 11;
	public const AddressFamily DecNet = 12;
	public const AddressFamily DataLink = 13;
	public const AddressFamily Lat = 14;
	public const AddressFamily HyperChannel = 15;
	public const AddressFamily AppleTalk = 16;
	public const AddressFamily NetBios = 17;
	public const AddressFamily VoiceView = 18;
	public const AddressFamily FireFox = 19;
	public const AddressFamily Banyan = 21;
	public const AddressFamily Atm = 22;
	public const AddressFamily InterNetworkV6 = 23;
	public const AddressFamily Cluster = 24;
	public const AddressFamily Ieee12844 = 25;
	public const AddressFamily Irda = 26;
	public const AddressFamily NetworkDesigners = 28;
	public const AddressFamily Max = 29;
}

// Namespace: System.Net.Sockets
public enum IOControlCode // TypeDefIndex: 6185
{
	// Fields
	public long value__; // 0x0
	public const IOControlCode AsyncIO = 2147772029;
	public const IOControlCode NonBlockingIO = 2147772030;
	public const IOControlCode DataToRead = 1074030207;
	public const IOControlCode OobDataRead = 1074033415;
	public const IOControlCode AssociateHandle = 2281701377;
	public const IOControlCode EnableCircularQueuing = 671088642;
	public const IOControlCode Flush = 671088644;
	public const IOControlCode GetBroadcastAddress = 1207959557;
	public const IOControlCode GetExtensionFunctionPointer = 3355443206;
	public const IOControlCode GetQos = 3355443207;
	public const IOControlCode GetGroupQos = 3355443208;
	public const IOControlCode MultipointLoopback = 2281701385;
	public const IOControlCode MulticastScope = 2281701386;
	public const IOControlCode SetQos = 2281701387;
	public const IOControlCode SetGroupQos = 2281701388;
	public const IOControlCode TranslateHandle = 3355443213;
	public const IOControlCode RoutingInterfaceQuery = 3355443220;
	public const IOControlCode RoutingInterfaceChange = 2281701397;
	public const IOControlCode AddressListQuery = 1207959574;
	public const IOControlCode AddressListChange = 671088663;
	public const IOControlCode QueryTargetPnpHandle = 1207959576;
	public const IOControlCode NamespaceChange = 2281701401;
	public const IOControlCode AddressListSort = 3355443225;
	public const IOControlCode ReceiveAll = 2550136833;
	public const IOControlCode ReceiveAllMulticast = 2550136834;
	public const IOControlCode ReceiveAllIgmpMulticast = 2550136835;
	public const IOControlCode KeepAliveValues = 2550136836;
	public const IOControlCode AbsorbRouterAlert = 2550136837;
	public const IOControlCode UnicastInterface = 2550136838;
	public const IOControlCode LimitBroadcasts = 2550136839;
	public const IOControlCode BindToInterface = 2550136840;
	public const IOControlCode MulticastInterface = 2550136841;
	public const IOControlCode AddMulticastGroupOnInterface = 2550136842;
	public const IOControlCode DeleteMulticastGroupFromInterface = 2550136843;
}

// Namespace: System.Net.Sockets
public struct IPPacketInformation // TypeDefIndex: 6186
{
	// Fields
	private IPAddress address; // 0x0
	private int networkInterface; // 0x8

	// Properties
	public IPAddress Address { get; }
	public int Interface { get; }

	// Methods

	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	internal void .ctor(IPAddress address, int networkInterface) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IPAddress get_Address() { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_Interface() { }

	// RVA: 0x2218BA0 Offset: 0x2217DA0 VA: 0x182218BA0
	public static bool op_Equality(IPPacketInformation packetInformation1, IPPacketInformation packetInformation2) { }

	// RVA: 0x2218C00 Offset: 0x2217E00 VA: 0x182218C00
	public static bool op_Inequality(IPPacketInformation packetInformation1, IPPacketInformation packetInformation2) { }

	// RVA: 0x2218A90 Offset: 0x2217C90 VA: 0x182218A90 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x2218B50 Offset: 0x2217D50 VA: 0x182218B50 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Net.Sockets
public enum IPProtectionLevel // TypeDefIndex: 6187
{
	// Fields
	public int value__; // 0x0
	public const IPProtectionLevel Unspecified = -1;
	public const IPProtectionLevel Unrestricted = 10;
	public const IPProtectionLevel EdgeRestricted = 20;
	public const IPProtectionLevel Restricted = 30;
}

// Namespace: System.Net.Sockets
public class LingerOption // TypeDefIndex: 6188
{
	// Fields
	private bool enabled; // 0x10
	private int lingerTime; // 0x14

	// Properties
	public bool Enabled { get; set; }
	public int LingerTime { get; set; }

	// Methods

	// RVA: 0x192A840 Offset: 0x1929A40 VA: 0x18192A840
	public void .ctor(bool enable, int seconds) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Enabled() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_Enabled(bool value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_LingerTime() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_LingerTime(int value) { }
}

// Namespace: System.Net.Sockets
public class MulticastOption // TypeDefIndex: 6189
{
	// Fields
	private IPAddress group; // 0x10
	private IPAddress localAddress; // 0x18
	private int ifIndex; // 0x20

	// Properties
	public IPAddress Group { get; set; }
	public IPAddress LocalAddress { get; set; }
	public int InterfaceIndex { get; set; }

	// Methods

	// RVA: 0x221E190 Offset: 0x221D390 VA: 0x18221E190
	public void .ctor(IPAddress group, IPAddress mcint) { }

	// RVA: 0x221E340 Offset: 0x221D540 VA: 0x18221E340
	public void .ctor(IPAddress group, int interfaceIndex) { }

	// RVA: 0x221E270 Offset: 0x221D470 VA: 0x18221E270
	public void .ctor(IPAddress group) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IPAddress get_Group() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Group(IPAddress value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IPAddress get_LocalAddress() { }

	// RVA: 0x221E490 Offset: 0x221D690 VA: 0x18221E490
	public void set_LocalAddress(IPAddress value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_InterfaceIndex() { }

	// RVA: 0x221E420 Offset: 0x221D620 VA: 0x18221E420
	public void set_InterfaceIndex(int value) { }
}

// Namespace: System.Net.Sockets
public class IPv6MulticastOption // TypeDefIndex: 6190
{
	// Fields
	private IPAddress m_Group; // 0x10
	private long m_Interface; // 0x18

	// Properties
	public IPAddress Group { get; set; }
	public long InterfaceIndex { get; set; }

	// Methods

	// RVA: 0x2218C60 Offset: 0x2217E60 VA: 0x182218C60
	public void .ctor(IPAddress group, long ifindex) { }

	// RVA: 0x2218D50 Offset: 0x2217F50 VA: 0x182218D50
	public void .ctor(IPAddress group) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IPAddress get_Group() { }

	// RVA: 0x2218DD0 Offset: 0x2217FD0 VA: 0x182218DD0
	public void set_Group(IPAddress value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public long get_InterfaceIndex() { }

	// RVA: 0x2218E40 Offset: 0x2218040 VA: 0x182218E40
	public void set_InterfaceIndex(long value) { }
}

// Namespace: System.Net.Sockets
public enum ProtocolFamily // TypeDefIndex: 6191
{
	// Fields
	public int value__; // 0x0
	public const ProtocolFamily Unknown = -1;
	public const ProtocolFamily Unspecified = 0;
	public const ProtocolFamily Unix = 1;
	public const ProtocolFamily InterNetwork = 2;
	public const ProtocolFamily ImpLink = 3;
	public const ProtocolFamily Pup = 4;
	public const ProtocolFamily Chaos = 5;
	public const ProtocolFamily NS = 6;
	public const ProtocolFamily Ipx = 6;
	public const ProtocolFamily Iso = 7;
	public const ProtocolFamily Osi = 7;
	public const ProtocolFamily Ecma = 8;
	public const ProtocolFamily DataKit = 9;
	public const ProtocolFamily Ccitt = 10;
	public const ProtocolFamily Sna = 11;
	public const ProtocolFamily DecNet = 12;
	public const ProtocolFamily DataLink = 13;
	public const ProtocolFamily Lat = 14;
	public const ProtocolFamily HyperChannel = 15;
	public const ProtocolFamily AppleTalk = 16;
	public const ProtocolFamily NetBios = 17;
	public const ProtocolFamily VoiceView = 18;
	public const ProtocolFamily FireFox = 19;
	public const ProtocolFamily Banyan = 21;
	public const ProtocolFamily Atm = 22;
	public const ProtocolFamily InterNetworkV6 = 23;
	public const ProtocolFamily Cluster = 24;
	public const ProtocolFamily Ieee12844 = 25;
	public const ProtocolFamily Irda = 26;
	public const ProtocolFamily NetworkDesigners = 28;
	public const ProtocolFamily Max = 29;
}

// Namespace: System.Net.Sockets
public enum ProtocolType // TypeDefIndex: 6192
{
	// Fields
	public int value__; // 0x0
	public const ProtocolType IP = 0;
	public const ProtocolType IPv6HopByHopOptions = 0;
	public const ProtocolType Icmp = 1;
	public const ProtocolType Igmp = 2;
	public const ProtocolType Ggp = 3;
	public const ProtocolType IPv4 = 4;
	public const ProtocolType Tcp = 6;
	public const ProtocolType Pup = 12;
	public const ProtocolType Udp = 17;
	public const ProtocolType Idp = 22;
	public const ProtocolType IPv6 = 41;
	public const ProtocolType IPv6RoutingHeader = 43;
	public const ProtocolType IPv6FragmentHeader = 44;
	public const ProtocolType IPSecEncapsulatingSecurityPayload = 50;
	public const ProtocolType IPSecAuthenticationHeader = 51;
	public const ProtocolType IcmpV6 = 58;
	public const ProtocolType IPv6NoNextHeader = 59;
	public const ProtocolType IPv6DestinationOptions = 60;
	public const ProtocolType ND = 77;
	public const ProtocolType Raw = 255;
	public const ProtocolType Unspecified = 0;
	public const ProtocolType Ipx = 1000;
	public const ProtocolType Spx = 1256;
	public const ProtocolType SpxII = 1257;
	public const ProtocolType Unknown = -1;
}

// Namespace: System.Net.Sockets
public enum SelectMode // TypeDefIndex: 6193
{
	// Fields
	public int value__; // 0x0
	public const SelectMode SelectRead = 0;
	public const SelectMode SelectWrite = 1;
	public const SelectMode SelectError = 2;
}

// Namespace: System.Net.Sockets
public enum SocketAsyncOperation // TypeDefIndex: 6194
{
	// Fields
	public int value__; // 0x0
	public const SocketAsyncOperation None = 0;
	public const SocketAsyncOperation Accept = 1;
	public const SocketAsyncOperation Connect = 2;
	public const SocketAsyncOperation Disconnect = 3;
	public const SocketAsyncOperation Receive = 4;
	public const SocketAsyncOperation ReceiveFrom = 5;
	public const SocketAsyncOperation ReceiveMessageFrom = 6;
	public const SocketAsyncOperation Send = 7;
	public const SocketAsyncOperation SendPackets = 8;
	public const SocketAsyncOperation SendTo = 9;
}

// Namespace: System.Net.Sockets
public class SendPacketsElement // TypeDefIndex: 6195
{
	// Fields
	internal string m_FilePath; // 0x10
	internal byte[] m_Buffer; // 0x18
	internal int m_Offset; // 0x20
	internal int m_Count; // 0x24
	private bool m_endOfPacket; // 0x28

	// Properties
	public string FilePath { get; }
	public byte[] Buffer { get; }
	public int Count { get; }
	public int Offset { get; }
	public bool EndOfPacket { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x221F120 Offset: 0x221E320 VA: 0x18221F120
	public void .ctor(string filepath) { }

	// RVA: 0x221F480 Offset: 0x221E680 VA: 0x18221F480
	public void .ctor(string filepath, int offset, int count) { }

	// RVA: 0x221F1B0 Offset: 0x221E3B0 VA: 0x18221F1B0
	public void .ctor(string filepath, int offset, int count, bool endOfPacket) { }

	// RVA: 0x221F4A0 Offset: 0x221E6A0 VA: 0x18221F4A0
	public void .ctor(byte[] buffer) { }

	// RVA: 0x221F300 Offset: 0x221E500 VA: 0x18221F300
	public void .ctor(byte[] buffer, int offset, int count) { }

	// RVA: 0x221F320 Offset: 0x221E520 VA: 0x18221F320
	public void .ctor(byte[] buffer, int offset, int count, bool endOfPacket) { }

	// RVA: 0x221F100 Offset: 0x221E300 VA: 0x18221F100
	private void Initialize(string filePath, byte[] buffer, int offset, int count, bool endOfPacket) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_FilePath() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public byte[] get_Buffer() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_Count() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_Offset() { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_EndOfPacket() { }
}

// Namespace: System.Net.Sockets
[EditorBrowsable(1)]
[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
public enum SocketClientAccessPolicyProtocol // TypeDefIndex: 6196
{
	// Fields
	public int value__; // 0x0
	public const SocketClientAccessPolicyProtocol Tcp = 0;
	public const SocketClientAccessPolicyProtocol Http = 1;
}

// Namespace: System.Net.Sockets
public enum SocketError // TypeDefIndex: 6197
{
	// Fields
	public int value__; // 0x0
	public const SocketError Success = 0;
	public const SocketError SocketError = -1;
	public const SocketError Interrupted = 10004;
	public const SocketError AccessDenied = 10013;
	public const SocketError Fault = 10014;
	public const SocketError InvalidArgument = 10022;
	public const SocketError TooManyOpenSockets = 10024;
	public const SocketError WouldBlock = 10035;
	public const SocketError InProgress = 10036;
	public const SocketError AlreadyInProgress = 10037;
	public const SocketError NotSocket = 10038;
	public const SocketError DestinationAddressRequired = 10039;
	public const SocketError MessageSize = 10040;
	public const SocketError ProtocolType = 10041;
	public const SocketError ProtocolOption = 10042;
	public const SocketError ProtocolNotSupported = 10043;
	public const SocketError SocketNotSupported = 10044;
	public const SocketError OperationNotSupported = 10045;
	public const SocketError ProtocolFamilyNotSupported = 10046;
	public const SocketError AddressFamilyNotSupported = 10047;
	public const SocketError AddressAlreadyInUse = 10048;
	public const SocketError AddressNotAvailable = 10049;
	public const SocketError NetworkDown = 10050;
	public const SocketError NetworkUnreachable = 10051;
	public const SocketError NetworkReset = 10052;
	public const SocketError ConnectionAborted = 10053;
	public const SocketError ConnectionReset = 10054;
	public const SocketError NoBufferSpaceAvailable = 10055;
	public const SocketError IsConnected = 10056;
	public const SocketError NotConnected = 10057;
	public const SocketError Shutdown = 10058;
	public const SocketError TimedOut = 10060;
	public const SocketError ConnectionRefused = 10061;
	public const SocketError HostDown = 10064;
	public const SocketError HostUnreachable = 10065;
	public const SocketError ProcessLimit = 10067;
	public const SocketError SystemNotReady = 10091;
	public const SocketError VersionNotSupported = 10092;
	public const SocketError NotInitialized = 10093;
	public const SocketError Disconnecting = 10101;
	public const SocketError TypeNotFound = 10109;
	public const SocketError HostNotFound = 11001;
	public const SocketError TryAgain = 11002;
	public const SocketError NoRecovery = 11003;
	public const SocketError NoData = 11004;
	public const SocketError IOPending = 997;
	public const SocketError OperationAborted = 995;
}

// Namespace: System.Net.Sockets
[Flags]
public enum SocketFlags // TypeDefIndex: 6198
{
	// Fields
	public int value__; // 0x0
	public const SocketFlags None = 0;
	public const SocketFlags OutOfBand = 1;
	public const SocketFlags Peek = 2;
	public const SocketFlags DontRoute = 4;
	public const SocketFlags MaxIOVectorLength = 16;
	public const SocketFlags Truncated = 256;
	public const SocketFlags ControlDataTruncated = 512;
	public const SocketFlags Broadcast = 1024;
	public const SocketFlags Multicast = 2048;
	public const SocketFlags Partial = 32768;
}

// Namespace: System.Net.Sockets
[Serializable]
public struct SocketInformation // TypeDefIndex: 6199
{
	// Fields
	private byte[] protocolInformation; // 0x0
	private SocketInformationOptions options; // 0x8
	[OptionalField]
	private EndPoint remoteEndPoint; // 0x10

	// Properties
	public byte[] ProtocolInformation { get; set; }
	public SocketInformationOptions Options { get; set; }
	internal bool IsNonBlocking { get; set; }
	internal bool IsConnected { get; set; }
	internal bool IsListening { get; set; }
	internal bool UseOnlyOverlappedIO { get; set; }
	internal EndPoint RemoteEndPoint { get; set; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public byte[] get_ProtocolInformation() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ProtocolInformation(byte[] value) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public SocketInformationOptions get_Options() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Options(SocketInformationOptions value) { }

	// RVA: 0x2220BE0 Offset: 0x221FDE0 VA: 0x182220BE0
	internal bool get_IsNonBlocking() { }

	// RVA: 0x2220C40 Offset: 0x221FE40 VA: 0x182220C40
	internal void set_IsNonBlocking(bool value) { }

	// RVA: 0x2220BC0 Offset: 0x221FDC0 VA: 0x182220BC0
	internal bool get_IsConnected() { }

	// RVA: 0x2220C00 Offset: 0x221FE00 VA: 0x182220C00
	internal void set_IsConnected(bool value) { }

	// RVA: 0x2220BD0 Offset: 0x221FDD0 VA: 0x182220BD0
	internal bool get_IsListening() { }

	// RVA: 0x2220C20 Offset: 0x221FE20 VA: 0x182220C20
	internal void set_IsListening(bool value) { }

	// RVA: 0x2220BF0 Offset: 0x221FDF0 VA: 0x182220BF0
	internal bool get_UseOnlyOverlappedIO() { }

	// RVA: 0x2220C60 Offset: 0x221FE60 VA: 0x182220C60
	internal void set_UseOnlyOverlappedIO(bool value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal EndPoint get_RemoteEndPoint() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_RemoteEndPoint(EndPoint value) { }
}

// Namespace: System.Net.Sockets
[Flags]
public enum SocketInformationOptions // TypeDefIndex: 6200
{
	// Fields
	public int value__; // 0x0
	public const SocketInformationOptions NonBlocking = 1;
	public const SocketInformationOptions Connected = 2;
	public const SocketInformationOptions Listening = 4;
	public const SocketInformationOptions UseOnlyOverlappedIO = 8;
}

// Namespace: System.Net.Sockets
public enum SocketOptionLevel // TypeDefIndex: 6201
{
	// Fields
	public int value__; // 0x0
	public const SocketOptionLevel Socket = 65535;
	public const SocketOptionLevel IP = 0;
	public const SocketOptionLevel IPv6 = 41;
	public const SocketOptionLevel Tcp = 6;
	public const SocketOptionLevel Udp = 17;
}

// Namespace: System.Net.Sockets
public enum SocketOptionName // TypeDefIndex: 6202
{
	// Fields
	public int value__; // 0x0
	public const SocketOptionName Debug = 1;
	public const SocketOptionName AcceptConnection = 2;
	public const SocketOptionName ReuseAddress = 4;
	public const SocketOptionName KeepAlive = 8;
	public const SocketOptionName DontRoute = 16;
	public const SocketOptionName Broadcast = 32;
	public const SocketOptionName UseLoopback = 64;
	public const SocketOptionName Linger = 128;
	public const SocketOptionName OutOfBandInline = 256;
	public const SocketOptionName DontLinger = -129;
	public const SocketOptionName ExclusiveAddressUse = -5;
	public const SocketOptionName SendBuffer = 4097;
	public const SocketOptionName ReceiveBuffer = 4098;
	public const SocketOptionName SendLowWater = 4099;
	public const SocketOptionName ReceiveLowWater = 4100;
	public const SocketOptionName SendTimeout = 4101;
	public const SocketOptionName ReceiveTimeout = 4102;
	public const SocketOptionName Error = 4103;
	public const SocketOptionName Type = 4104;
	public const SocketOptionName ReuseUnicastPort = 12295;
	public const SocketOptionName MaxConnections = 2147483647;
	public const SocketOptionName IPOptions = 1;
	public const SocketOptionName HeaderIncluded = 2;
	public const SocketOptionName TypeOfService = 3;
	public const SocketOptionName IpTimeToLive = 4;
	public const SocketOptionName MulticastInterface = 9;
	public const SocketOptionName MulticastTimeToLive = 10;
	public const SocketOptionName MulticastLoopback = 11;
	public const SocketOptionName AddMembership = 12;
	public const SocketOptionName DropMembership = 13;
	public const SocketOptionName DontFragment = 14;
	public const SocketOptionName AddSourceMembership = 15;
	public const SocketOptionName DropSourceMembership = 16;
	public const SocketOptionName BlockSource = 17;
	public const SocketOptionName UnblockSource = 18;
	public const SocketOptionName PacketInformation = 19;
	public const SocketOptionName HopLimit = 21;
	public const SocketOptionName IPProtectionLevel = 23;
	public const SocketOptionName IPv6Only = 27;
	public const SocketOptionName NoDelay = 1;
	public const SocketOptionName BsdUrgent = 2;
	public const SocketOptionName Expedited = 2;
	public const SocketOptionName NoChecksum = 1;
	public const SocketOptionName ChecksumCoverage = 20;
	public const SocketOptionName UpdateAcceptContext = 28683;
	public const SocketOptionName UpdateConnectContext = 28688;
}

// Namespace: System.Net.Sockets
public enum SocketShutdown // TypeDefIndex: 6203
{
	// Fields
	public int value__; // 0x0
	public const SocketShutdown Receive = 0;
	public const SocketShutdown Send = 1;
	public const SocketShutdown Both = 2;
}

// Namespace: System.Net.Sockets
public enum SocketType // TypeDefIndex: 6204
{
	// Fields
	public int value__; // 0x0
	public const SocketType Stream = 1;
	public const SocketType Dgram = 2;
	public const SocketType Raw = 3;
	public const SocketType Rdm = 4;
	public const SocketType Seqpacket = 5;
	public const SocketType Unknown = -1;
}

// Namespace: System.Net.Sockets
public class TcpClient : IDisposable // TypeDefIndex: 6205
{
	// Fields
	private Socket m_ClientSocket; // 0x10
	private bool m_Active; // 0x18
	private NetworkStream m_DataStream; // 0x20
	private AddressFamily m_Family; // 0x28
	private bool m_CleanedUp; // 0x2C

	// Properties
	public Socket Client { get; set; }
	protected bool Active { get; set; }
	public int Available { get; }
	public bool Connected { get; }
	public bool ExclusiveAddressUse { get; set; }
	public int ReceiveBufferSize { get; set; }
	public int SendBufferSize { get; set; }
	public int ReceiveTimeout { get; set; }
	public int SendTimeout { get; set; }
	public LingerOption LingerState { get; set; }
	public bool NoDelay { get; set; }

	// Methods

	// RVA: 0x2223E80 Offset: 0x2223080 VA: 0x182223E80
	public void .ctor(IPEndPoint localEP) { }

	// RVA: 0x2224180 Offset: 0x2223380 VA: 0x182224180
	public void .ctor() { }

	// RVA: 0x2224210 Offset: 0x2223410 VA: 0x182224210
	public void .ctor(AddressFamily family) { }

	// RVA: 0x2223F50 Offset: 0x2223150 VA: 0x182223F50
	public void .ctor(string hostname, int port) { }

	// RVA: 0x22241D0 Offset: 0x22233D0 VA: 0x1822241D0
	internal void .ctor(Socket acceptedSocket) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Socket get_Client() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Client(Socket value) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	protected bool get_Active() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	protected void set_Active(bool value) { }

	// RVA: 0x2224320 Offset: 0x2223520 VA: 0x182224320
	public int get_Available() { }

	// RVA: 0x2224340 Offset: 0x2223540 VA: 0x182224340
	public bool get_Connected() { }

	// RVA: 0x2224360 Offset: 0x2223560 VA: 0x182224360
	public bool get_ExclusiveAddressUse() { }

	// RVA: 0x22245F0 Offset: 0x22237F0 VA: 0x1822245F0
	public void set_ExclusiveAddressUse(bool value) { }

	// RVA: 0x22234A0 Offset: 0x22226A0 VA: 0x1822234A0
	public void Connect(string hostname, int port) { }

	// RVA: 0x22232E0 Offset: 0x22224E0 VA: 0x1822232E0
	public void Connect(IPAddress address, int port) { }

	// RVA: 0x22231D0 Offset: 0x22223D0 VA: 0x1822231D0
	public void Connect(IPEndPoint remoteEP) { }

	// RVA: 0x2223B30 Offset: 0x2222D30 VA: 0x182223B30
	public void Connect(IPAddress[] ipAddresses, int port) { }

	// RVA: 0x2222CB0 Offset: 0x2221EB0 VA: 0x182222CB0
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x2222BB0 Offset: 0x2221DB0 VA: 0x182222BB0
	public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x2222C30 Offset: 0x2221E30 VA: 0x182222C30
	public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x2223CD0 Offset: 0x2222ED0 VA: 0x182223CD0
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x2222EF0 Offset: 0x22220F0 VA: 0x182222EF0
	public Task ConnectAsync(IPAddress address, int port) { }

	// RVA: 0x2222D80 Offset: 0x2221F80 VA: 0x182222D80
	public Task ConnectAsync(string host, int port) { }

	// RVA: 0x2223060 Offset: 0x2222260 VA: 0x182223060
	public Task ConnectAsync(IPAddress[] addresses, int port) { }

	// RVA: 0x2223D20 Offset: 0x2222F20 VA: 0x182223D20
	public NetworkStream GetStream() { }

	// RVA: 0x2222D30 Offset: 0x2221F30 VA: 0x182222D30
	public void Close() { }

	// RVA: 0x2223B90 Offset: 0x2222D90 VA: 0x182223B90 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1744B80 Offset: 0x1743D80 VA: 0x181744B80 Slot: 4
	public void Dispose() { }

	// RVA: 0x15667F0 Offset: 0x15659F0 VA: 0x1815667F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2224460 Offset: 0x2223660 VA: 0x182224460
	public int get_ReceiveBufferSize() { }

	// RVA: 0x2224690 Offset: 0x2223890 VA: 0x182224690
	public void set_ReceiveBufferSize(int value) { }

	// RVA: 0x22244A0 Offset: 0x22236A0 VA: 0x1822244A0
	public int get_SendBufferSize() { }

	// RVA: 0x2224710 Offset: 0x2223910 VA: 0x182224710
	public void set_SendBufferSize(int value) { }

	// RVA: 0x2224480 Offset: 0x2223680 VA: 0x182224480
	public int get_ReceiveTimeout() { }

	// RVA: 0x22246D0 Offset: 0x22238D0 VA: 0x1822246D0
	public void set_ReceiveTimeout(int value) { }

	// RVA: 0x22244C0 Offset: 0x22236C0 VA: 0x1822244C0
	public int get_SendTimeout() { }

	// RVA: 0x2224750 Offset: 0x2223950 VA: 0x182224750
	public void set_SendTimeout(int value) { }

	// RVA: 0x2224380 Offset: 0x2223580 VA: 0x182224380
	public LingerOption get_LingerState() { }

	// RVA: 0x2224610 Offset: 0x2223810 VA: 0x182224610
	public void set_LingerState(LingerOption value) { }

	// RVA: 0x2224430 Offset: 0x2223630 VA: 0x182224430
	public bool get_NoDelay() { }

	// RVA: 0x2224650 Offset: 0x2223850 VA: 0x182224650
	public void set_NoDelay(bool value) { }

	// RVA: 0x22244E0 Offset: 0x22236E0 VA: 0x1822244E0
	private void initialize() { }

	// RVA: 0x2224560 Offset: 0x2223760 VA: 0x182224560
	private int numericOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }
}

// Namespace: System.Net.Sockets
public class TcpListener // TypeDefIndex: 6206
{
	// Fields
	private IPEndPoint m_ServerSocketEP; // 0x10
	private Socket m_ServerSocket; // 0x18
	private bool m_Active; // 0x20
	private bool m_ExclusiveAddressUse; // 0x21

	// Properties
	public Socket Server { get; }
	protected bool Active { get; }
	public EndPoint LocalEndpoint { get; }
	public bool ExclusiveAddressUse { get; set; }

	// Methods

	// RVA: 0x2225750 Offset: 0x2224950 VA: 0x182225750
	public void .ctor(IPEndPoint localEP) { }

	// RVA: 0x2225850 Offset: 0x2224A50 VA: 0x182225850
	public void .ctor(IPAddress localaddr, int port) { }

	[Obsolete("This method has been deprecated. Please use TcpListener(IPAddress localaddr, int port) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x22255C0 Offset: 0x22247C0 VA: 0x1822255C0
	public void .ctor(int port) { }

	// RVA: 0x2224D80 Offset: 0x2223F80 VA: 0x182224D80
	public static TcpListener Create(int port) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Socket get_Server() { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	protected bool get_Active() { }

	// RVA: 0x2225A30 Offset: 0x2224C30 VA: 0x182225A30
	public EndPoint get_LocalEndpoint() { }

	// RVA: 0x2225A10 Offset: 0x2224C10 VA: 0x182225A10
	public bool get_ExclusiveAddressUse() { }

	// RVA: 0x2225A60 Offset: 0x2224C60 VA: 0x182225A60
	public void set_ExclusiveAddressUse(bool value) { }

	// RVA: 0x2224B50 Offset: 0x2223D50 VA: 0x182224B50
	public void AllowNatTraversal(bool allowed) { }

	// RVA: 0x2225390 Offset: 0x2224590 VA: 0x182225390
	public void Start() { }

	// RVA: 0x22253A0 Offset: 0x22245A0 VA: 0x1822253A0
	public void Start(int backlog) { }

	// RVA: 0x22254E0 Offset: 0x22246E0 VA: 0x1822254E0
	public void Stop() { }

	// RVA: 0x22252F0 Offset: 0x22244F0 VA: 0x1822252F0
	public bool Pending() { }

	// RVA: 0x22248A0 Offset: 0x2223AA0 VA: 0x1822248A0
	public Socket AcceptSocket() { }

	// RVA: 0x2224A50 Offset: 0x2223C50 VA: 0x182224A50
	public TcpClient AcceptTcpClient() { }

	// RVA: 0x2224C00 Offset: 0x2223E00 VA: 0x182224C00
	public IAsyncResult BeginAcceptSocket(AsyncCallback callback, object state) { }

	// RVA: 0x2225040 Offset: 0x2224240 VA: 0x182225040
	public Socket EndAcceptSocket(IAsyncResult asyncResult) { }

	// RVA: 0x2224CC0 Offset: 0x2223EC0 VA: 0x182224CC0
	public IAsyncResult BeginAcceptTcpClient(AsyncCallback callback, object state) { }

	// RVA: 0x2225170 Offset: 0x2224370 VA: 0x182225170
	public TcpClient EndAcceptTcpClient(IAsyncResult asyncResult) { }

	// RVA: 0x2224790 Offset: 0x2223990 VA: 0x182224790
	public Task<Socket> AcceptSocketAsync() { }

	// RVA: 0x2224940 Offset: 0x2223B40 VA: 0x182224940
	public Task<TcpClient> AcceptTcpClientAsync() { }
}

// Namespace: System.Net.Sockets
[Flags]
public enum TransmitFileOptions // TypeDefIndex: 6207
{
	// Fields
	public int value__; // 0x0
	public const TransmitFileOptions UseDefaultWorkerThread = 0;
	public const TransmitFileOptions Disconnect = 1;
	public const TransmitFileOptions ReuseSocket = 2;
	public const TransmitFileOptions WriteBehind = 4;
	public const TransmitFileOptions UseSystemThread = 16;
	public const TransmitFileOptions UseKernelApc = 32;
}

// Namespace: 
[CompilerGenerated]
private sealed class UdpClient.<>c__DisplayClass64_0 // TypeDefIndex: 6208
{
	// Fields
	public UdpClient <>4__this; // 0x10
	public byte[] datagram; // 0x18
	public int bytes; // 0x20
	public string hostname; // 0x28
	public int port; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x222C6E0 Offset: 0x222B8E0 VA: 0x18222C6E0
	internal IAsyncResult <SendAsync>b__0(AsyncCallback callback, object state) { }
}

// Namespace: System.Net.Sockets
public class UdpClient : IDisposable // TypeDefIndex: 6209
{
	// Fields
	private const int MaxUDPSize = 65536;
	private Socket m_ClientSocket; // 0x10
	private bool m_Active; // 0x18
	private byte[] m_Buffer; // 0x20
	private AddressFamily m_Family; // 0x28
	private bool m_CleanedUp; // 0x2C
	private bool m_IsBroadcast; // 0x2D

	// Properties
	public Socket Client { get; set; }
	protected bool Active { get; set; }
	public int Available { get; }
	public short Ttl { get; set; }
	public bool DontFragment { get; set; }
	public bool MulticastLoopback { get; set; }
	public bool EnableBroadcast { get; set; }
	public bool ExclusiveAddressUse { get; set; }

	// Methods

	// RVA: 0x222F7D0 Offset: 0x222E9D0 VA: 0x18222F7D0
	public void .ctor() { }

	// RVA: 0x222FA80 Offset: 0x222EC80 VA: 0x18222FA80
	public void .ctor(AddressFamily family) { }

	// RVA: 0x222F980 Offset: 0x222EB80 VA: 0x18222F980
	public void .ctor(int port) { }

	// RVA: 0x222FBB0 Offset: 0x222EDB0 VA: 0x18222FBB0
	public void .ctor(int port, AddressFamily family) { }

	// RVA: 0x222F990 Offset: 0x222EB90 VA: 0x18222F990
	public void .ctor(IPEndPoint localEP) { }

	// RVA: 0x222F840 Offset: 0x222EA40 VA: 0x18222F840
	public void .ctor(string hostname, int port) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Socket get_Client() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Client(Socket value) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	protected bool get_Active() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	protected void set_Active(bool value) { }

	// RVA: 0x2224320 Offset: 0x2223520 VA: 0x182224320
	public int get_Available() { }

	// RVA: 0x222FEB0 Offset: 0x222F0B0 VA: 0x18222FEB0
	public short get_Ttl() { }

	// RVA: 0x222FF30 Offset: 0x222F130 VA: 0x18222FF30
	public void set_Ttl(short value) { }

	// RVA: 0x222FE50 Offset: 0x222F050 VA: 0x18222FE50
	public bool get_DontFragment() { }

	// RVA: 0x222FED0 Offset: 0x222F0D0 VA: 0x18222FED0
	public void set_DontFragment(bool value) { }

	// RVA: 0x222FE90 Offset: 0x222F090 VA: 0x18222FE90
	public bool get_MulticastLoopback() { }

	// RVA: 0x222FF10 Offset: 0x222F110 VA: 0x18222FF10
	public void set_MulticastLoopback(bool value) { }

	// RVA: 0x222FE70 Offset: 0x222F070 VA: 0x18222FE70
	public bool get_EnableBroadcast() { }

	// RVA: 0x222FEF0 Offset: 0x222F0F0 VA: 0x18222FEF0
	public void set_EnableBroadcast(bool value) { }

	// RVA: 0x2224360 Offset: 0x2223560 VA: 0x182224360
	public bool get_ExclusiveAddressUse() { }

	// RVA: 0x22245F0 Offset: 0x22237F0 VA: 0x1822245F0
	public void set_ExclusiveAddressUse(bool value) { }

	// RVA: 0x222C910 Offset: 0x222BB10 VA: 0x18222C910
	public void AllowNatTraversal(bool allowed) { }

	// RVA: 0x1744B80 Offset: 0x1743D80 VA: 0x181744B80
	public void Close() { }

	// RVA: 0x222E030 Offset: 0x222D230 VA: 0x18222E030
	private void FreeResources() { }

	// RVA: 0x1744B80 Offset: 0x1743D80 VA: 0x181744B80 Slot: 4
	public void Dispose() { }

	// RVA: 0x222D830 Offset: 0x222CA30 VA: 0x18222D830 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x222D170 Offset: 0x222C370 VA: 0x18222D170
	public void Connect(string hostname, int port) { }

	// RVA: 0x222D680 Offset: 0x222C880 VA: 0x18222D680
	public void Connect(IPAddress addr, int port) { }

	// RVA: 0x222D070 Offset: 0x222C270 VA: 0x18222D070
	public void Connect(IPEndPoint endPoint) { }

	// RVA: 0x222CF90 Offset: 0x222C190 VA: 0x18222CF90
	private void CheckForBroadcast(IPAddress ipAddress) { }

	// RVA: 0x222E080 Offset: 0x222D280 VA: 0x18222E080
	private static bool IsBroadcast(IPAddress address) { }

	// RVA: 0x222F3C0 Offset: 0x222E5C0 VA: 0x18222F3C0
	public int Send(byte[] dgram, int bytes, IPEndPoint endPoint) { }

	// RVA: 0x222F070 Offset: 0x222E270 VA: 0x18222F070
	public int Send(byte[] dgram, int bytes, string hostname, int port) { }

	// RVA: 0x222F580 Offset: 0x222E780 VA: 0x18222F580
	public int Send(byte[] dgram, int bytes) { }

	// RVA: 0x222CAD0 Offset: 0x222BCD0 VA: 0x18222CAD0
	public IAsyncResult BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state) { }

	// RVA: 0x222CD30 Offset: 0x222BF30 VA: 0x18222CD30
	public IAsyncResult BeginSend(byte[] datagram, int bytes, string hostname, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x222CAA0 Offset: 0x222BCA0 VA: 0x18222CAA0
	public IAsyncResult BeginSend(byte[] datagram, int bytes, AsyncCallback requestCallback, object state) { }

	// RVA: 0x222DF80 Offset: 0x222D180 VA: 0x18222DF80
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x222EA60 Offset: 0x222DC60 VA: 0x18222EA60
	public byte[] Receive(ref IPEndPoint remoteEP) { }

	// RVA: 0x222C950 Offset: 0x222BB50 VA: 0x18222C950
	public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state) { }

	// RVA: 0x222DD40 Offset: 0x222CF40 VA: 0x18222DD40
	public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP) { }

	// RVA: 0x222E2D0 Offset: 0x222D4D0 VA: 0x18222E2D0
	public void JoinMulticastGroup(IPAddress multicastAddr) { }

	// RVA: 0x222E540 Offset: 0x222D740 VA: 0x18222E540
	public void JoinMulticastGroup(IPAddress multicastAddr, IPAddress localAddress) { }

	// RVA: 0x222E740 Offset: 0x222D940 VA: 0x18222E740
	public void JoinMulticastGroup(int ifindex, IPAddress multicastAddr) { }

	// RVA: 0x222E110 Offset: 0x222D310 VA: 0x18222E110
	public void JoinMulticastGroup(IPAddress multicastAddr, int timeToLive) { }

	// RVA: 0x222DAD0 Offset: 0x222CCD0 VA: 0x18222DAD0
	public void DropMulticastGroup(IPAddress multicastAddr) { }

	// RVA: 0x222D8C0 Offset: 0x222CAC0 VA: 0x18222D8C0
	public void DropMulticastGroup(IPAddress multicastAddr, int ifindex) { }

	// RVA: 0x222EF50 Offset: 0x222E150 VA: 0x18222EF50
	public Task<int> SendAsync(byte[] datagram, int bytes) { }

	// RVA: 0x222EE10 Offset: 0x222E010 VA: 0x18222EE10
	public Task<int> SendAsync(byte[] datagram, int bytes, IPEndPoint endPoint) { }

	// RVA: 0x222ECB0 Offset: 0x222DEB0 VA: 0x18222ECB0
	public Task<int> SendAsync(byte[] datagram, int bytes, string hostname, int port) { }

	// RVA: 0x222E950 Offset: 0x222DB50 VA: 0x18222E950
	public Task<UdpReceiveResult> ReceiveAsync() { }

	// RVA: 0x222FDD0 Offset: 0x222EFD0 VA: 0x18222FDD0
	private void createClientSocket() { }

	[CompilerGenerated]
	// RVA: 0x222C950 Offset: 0x222BB50 VA: 0x18222C950
	private IAsyncResult <ReceiveAsync>b__65_0(AsyncCallback callback, object state) { }

	[CompilerGenerated]
	// RVA: 0x222F6E0 Offset: 0x222E8E0 VA: 0x18222F6E0
	private UdpReceiveResult <ReceiveAsync>b__65_1(IAsyncResult ar) { }
}

// Namespace: System.Net.Sockets
public struct UdpReceiveResult : IEquatable<UdpReceiveResult> // TypeDefIndex: 6210
{
	// Fields
	private byte[] m_buffer; // 0x0
	private IPEndPoint m_remoteEndPoint; // 0x8

	// Properties
	public byte[] Buffer { get; }
	public IPEndPoint RemoteEndPoint { get; }

	// Methods

	// RVA: 0x2230070 Offset: 0x222F270 VA: 0x182230070
	public void .ctor(byte[] buffer, IPEndPoint remoteEndPoint) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public byte[] get_Buffer() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IPEndPoint get_RemoteEndPoint() { }

	// RVA: 0x2230000 Offset: 0x222F200 VA: 0x182230000 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x222FF50 Offset: 0x222F150 VA: 0x18222FF50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xC3FE50 Offset: 0xC3F050 VA: 0x180C3FE50 Slot: 4
	public bool Equals(UdpReceiveResult other) { }

	// RVA: 0xC3FE50 Offset: 0xC3F050 VA: 0x180C3FE50
	public static bool op_Equality(UdpReceiveResult left, UdpReceiveResult right) { }

	// RVA: 0x2230120 Offset: 0x222F320 VA: 0x182230120
	public static bool op_Inequality(UdpReceiveResult left, UdpReceiveResult right) { }
}

// Namespace: System.Net.Sockets
internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid // TypeDefIndex: 6211
{
	// Fields
	private List<Thread> blocking_threads; // 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private const int SOCKET_CLOSED = 10004;
	private const int ABORT_RETRIES = 10;
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0x221ED40 Offset: 0x221DF40 VA: 0x18221ED40
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x221ED30 Offset: 0x221DF30 VA: 0x18221ED30
	internal void .ctor() { }

	// RVA: 0x221E5E0 Offset: 0x221D7E0 VA: 0x18221E5E0 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x221E4A0 Offset: 0x221D6A0 VA: 0x18221E4A0
	public void RegisterForBlockingSyscall() { }

	// RVA: 0x221EB20 Offset: 0x221DD20 VA: 0x18221EB20
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0x221ECC0 Offset: 0x221DEC0 VA: 0x18221ECC0
	private static void .cctor() { }
}

// Namespace: System.Net.Sockets
public class SocketAsyncEventArgs : EventArgs, IDisposable // TypeDefIndex: 6212
{
	// Fields
	private bool disposed; // 0x10
	internal int in_progress; // 0x14
	private EndPoint remote_ep; // 0x18
	private Socket current_socket; // 0x20
	internal SocketAsyncResult socket_async_result; // 0x28
	[CompilerGenerated]
	private Exception <ConnectByNameError>k__BackingField; // 0x30
	[CompilerGenerated]
	private Socket <AcceptSocket>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <BytesTransferred>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <DisconnectReuseSocket>k__BackingField; // 0x44
	[CompilerGenerated]
	private SocketAsyncOperation <LastOperation>k__BackingField; // 0x48
	[CompilerGenerated]
	private IPPacketInformation <ReceiveMessageFromPacketInfo>k__BackingField; // 0x50
	[CompilerGenerated]
	private SendPacketsElement[] <SendPacketsElements>k__BackingField; // 0x60
	[CompilerGenerated]
	private TransmitFileOptions <SendPacketsFlags>k__BackingField; // 0x68
	[CompilerGenerated]
	private int <SendPacketsSendSize>k__BackingField; // 0x6C
