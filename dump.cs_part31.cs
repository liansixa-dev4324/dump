	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9795E0 Offset: 0x9787E0 VA: 0x1809795E0
	|-Enumerable.Single<object>
	|
	|-RVA: 0x978ED0 Offset: 0x9780D0 VA: 0x180978ED0
	|-Enumerable.Single<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x978BB0 Offset: 0x977DB0 VA: 0x180978BB0
	|-Enumerable.Single<QRCodeGenerator.ECCInfo>
	|
	|-RVA: 0x979AD0 Offset: 0x978CD0 VA: 0x180979AD0
	|-Enumerable.Single<QRCodeGenerator.VersionInfoDetails>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x978950 Offset: 0x977B50 VA: 0x180978950
	|-Enumerable.SingleOrDefault<object>
	|
	|-RVA: 0x977C50 Offset: 0x976E50 VA: 0x180977C50
	|-Enumerable.SingleOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9783C0 Offset: 0x9775C0 VA: 0x1809783C0
	|-Enumerable.SingleOrDefault<KeyValuePair<IntPtr, object>>
	|
	|-RVA: 0x9786D0 Offset: 0x9778D0 VA: 0x1809786D0
	|-Enumerable.SingleOrDefault<object>
	|
	|-RVA: 0x977FB0 Offset: 0x9771B0 VA: 0x180977FB0
	|-Enumerable.SingleOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96ED90 Offset: 0x96DF90 VA: 0x18096ED90
	|-Enumerable.ElementAt<object>
	|
	|-RVA: 0x96EA40 Offset: 0x96DC40 VA: 0x18096EA40
	|-Enumerable.ElementAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CD6BD0 Offset: 0x1CD5DD0 VA: 0x181CD6BD0
	public static IEnumerable<int> Range(int start, int count) { }

	[IteratorStateMachine(typeof(Enumerable.<RangeIterator>d__115))]
	// RVA: 0x1CD6B50 Offset: 0x1CD5D50 VA: 0x181CD6B50
	private static IEnumerable<int> RangeIterator(int start, int count) { }

	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Empty<TResult>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F10 Offset: 0x3D8110 VA: 0x1803D8F10
	|-Enumerable.Empty<KeyValuePair<object, object>>
	|-Enumerable.Empty<int>
	|-Enumerable.Empty<object>
	|-Enumerable.Empty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x968680 Offset: 0x967880 VA: 0x180968680
	|-Enumerable.Any<KeyValuePair<byte, object>>
	|-Enumerable.Any<int>
	|-Enumerable.Any<object>
	|-Enumerable.Any<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9689A0 Offset: 0x967BA0 VA: 0x1809689A0
	|-Enumerable.Any<KeyValuePair<DiscardReasonWithCategory, int>>
	|-Enumerable.Any<KeyValuePair<object, DateTimeOffset>>
	|
	|-RVA: 0x968C10 Offset: 0x967E10 VA: 0x180968C10
	|-Enumerable.Any<KeyValuePair<object, object>>
	|-Enumerable.Any<QRCodeGenerator.VersionInfoDetails>
	|-Enumerable.Any<ServerManager.PingWrapper>
	|
	|-RVA: 0x967DC0 Offset: 0x966FC0 VA: 0x180967DC0
	|-Enumerable.Any<byte>
	|
	|-RVA: 0x967FA0 Offset: 0x9671A0 VA: 0x180967FA0
	|-Enumerable.Any<char>
	|
	|-RVA: 0x968180 Offset: 0x967380 VA: 0x180968180
	|-Enumerable.Any<HttpStatusCodeRange>
	|
	|-RVA: 0x9687C0 Offset: 0x9679C0 VA: 0x1809687C0
	|-Enumerable.Any<Int32Enum>
	|
	|-RVA: 0x968E60 Offset: 0x968060 VA: 0x180968E60
	|-Enumerable.Any<object>
	|
	|-RVA: 0x9683C0 Offset: 0x9675C0 VA: 0x1809683C0
	|-Enumerable.Any<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x967B80 Offset: 0x966D80 VA: 0x180967B80
	|-Enumerable.Any<HeliSabotageSystem.ActiveConsoleData>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x967140 Offset: 0x966340 VA: 0x180967140
	|-Enumerable.All<bool>
	|-Enumerable.All<byte>
	|
	|-RVA: 0x967320 Offset: 0x966520 VA: 0x180967320
	|-Enumerable.All<char>
	|
	|-RVA: 0x9677C0 Offset: 0x9669C0 VA: 0x1809677C0
	|-Enumerable.All<int>
	|
	|-RVA: 0x9679A0 Offset: 0x966BA0 VA: 0x1809679A0
	|-Enumerable.All<object>
	|
	|-RVA: 0x967500 Offset: 0x966700 VA: 0x180967500
	|-Enumerable.All<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96DAF0 Offset: 0x96CCF0 VA: 0x18096DAF0
	|-Enumerable.Count<object>
	|-Enumerable.Count<__Il2CppFullySharedGenericType>
	|-Enumerable.Count<QRCodeGenerator.PolynomItem>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96D910 Offset: 0x96CB10 VA: 0x18096D910
	|-Enumerable.Count<byte>
	|
	|-RVA: 0x96DFE0 Offset: 0x96D1E0 VA: 0x18096DFE0
	|-Enumerable.Count<int>
	|-Enumerable.Count<Int32Enum>
	|
	|-RVA: 0x96E1C0 Offset: 0x96D3C0 VA: 0x18096E1C0
	|-Enumerable.Count<object>
	|
	|-RVA: 0x96DCF0 Offset: 0x96CEF0 VA: 0x18096DCF0
	|-Enumerable.Count<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x96E3A0 Offset: 0x96D5A0 VA: 0x18096E3A0
	|-Enumerable.Count<QRCodeGenerator.VersionInfoDetails>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96BF10 Offset: 0x96B110 VA: 0x18096BF10
	|-Enumerable.Contains<char>
	|
	|-RVA: 0x96CBA0 Offset: 0x96BDA0 VA: 0x18096CBA0
	|-Enumerable.Contains<int>
	|
	|-RVA: 0x96C530 Offset: 0x96B730 VA: 0x18096C530
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0x96D120 Offset: 0x96C320 VA: 0x18096D120
	|-Enumerable.Contains<object>
	|
	|-RVA: 0x96D000 Offset: 0x96C200 VA: 0x18096D000
	|-Enumerable.Contains<PidVid>
	|
	|-RVA: 0x96D440 Offset: 0x96C640 VA: 0x18096D440
	|-Enumerable.Contains<UInt16Enum>
	|
	|-RVA: 0x96C030 Offset: 0x96B230 VA: 0x18096C030
	|-Enumerable.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96BBD0 Offset: 0x96ADD0 VA: 0x18096BBD0
	|-Enumerable.Contains<char>
	|
	|-RVA: 0x96C8C0 Offset: 0x96BAC0 VA: 0x18096C8C0
	|-Enumerable.Contains<int>
	|
	|-RVA: 0x96C5E0 Offset: 0x96B7E0 VA: 0x18096C5E0
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0x96D240 Offset: 0x96C440 VA: 0x18096D240
	|-Enumerable.Contains<object>
	|
	|-RVA: 0x96CC50 Offset: 0x96BE50 VA: 0x18096CC50
	|-Enumerable.Contains<PidVid>
	|
	|-RVA: 0x96D560 Offset: 0x96C760 VA: 0x18096D560
	|-Enumerable.Contains<UInt16Enum>
	|
	|-RVA: 0x96C200 Offset: 0x96B400 VA: 0x18096C200
	|-Enumerable.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Aggregate<TSource>(IEnumerable<TSource> source, Func<TSource, TSource, TSource> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x966F00 Offset: 0x966100 VA: 0x180966F00
	|-Enumerable.Aggregate<object>
	|
	|-RVA: 0x966680 Offset: 0x965880 VA: 0x180966680
	|-Enumerable.Aggregate<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TAccumulate Aggregate<TSource, TAccumulate>(IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x966A70 Offset: 0x965C70 VA: 0x180966A70
	|-Enumerable.Aggregate<KeyValuePair<ulong, Helper.PinnedBuffer>, int>
	|
	|-RVA: 0x966210 Offset: 0x965410 VA: 0x180966210
	|-Enumerable.Aggregate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x966CD0 Offset: 0x965ED0 VA: 0x180966CD0
	|-Enumerable.Aggregate<QRCodeGenerator.PolynomItem, int>
	*/

	[Extension]
	// RVA: 0x1CD6C90 Offset: 0x1CD5E90 VA: 0x181CD6C90
	public static int Sum(IEnumerable<int> source) { }

	[Extension]
	// RVA: 0x1CD6E40 Offset: 0x1CD6040 VA: 0x181CD6E40
	public static float Sum(IEnumerable<float> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int Sum<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97A330 Offset: 0x979530 VA: 0x18097A330
	|-Enumerable.Sum<object>
	|
	|-RVA: 0x97A210 Offset: 0x979410 VA: 0x18097A210
	|-Enumerable.Sum<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float Sum<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97A2D0 Offset: 0x9794D0 VA: 0x18097A2D0
	|-Enumerable.Sum<object>
	|
	|-RVA: 0x97A270 Offset: 0x979470 VA: 0x18097A270
	|-Enumerable.Sum<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CD6900 Offset: 0x1CD5B00 VA: 0x181CD6900
	public static int Min(IEnumerable<int> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int Min<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x974450 Offset: 0x973650 VA: 0x180974450
	|-Enumerable.Min<object>
	|
	|-RVA: 0x9743F0 Offset: 0x9735F0 VA: 0x1809743F0
	|-Enumerable.Min<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CD66B0 Offset: 0x1CD58B0 VA: 0x181CD66B0
	public static int Max(IEnumerable<int> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Max<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x974160 Offset: 0x973360 VA: 0x180974160
	|-Enumerable.Max<uint>
	|
	|-RVA: 0x973AA0 Offset: 0x972CA0 VA: 0x180973AA0
	|-Enumerable.Max<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Linq
internal class EmptyEnumerable<TElement> // TypeDefIndex: 14655
{
	// Fields
	public static readonly TElement[] Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DCBE0 Offset: 0x10DBDE0 VA: 0x1810DCBE0
	|-EmptyEnumerable<KeyValuePair<object, object>>..cctor
	|-EmptyEnumerable<int>..cctor
	|-EmptyEnumerable<object>..cctor
	|-EmptyEnumerable<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class IdentityFunction.<>c<TElement> // TypeDefIndex: 14656
{
	// Fields
	public static readonly IdentityFunction.<>c<TElement> <>9; // 0x0
	public static Func<TElement, TElement> <>9__1_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-IdentityFunction.<>c<object>..cctor
	|-IdentityFunction.<>c<QRCodeGenerator.PolynomItem>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-IdentityFunction.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-IdentityFunction.<>c<object>..ctor
	|-IdentityFunction.<>c<__Il2CppFullySharedGenericType>..ctor
	|-IdentityFunction.<>c<QRCodeGenerator.PolynomItem>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TElement <get_Instance>b__1_0(TElement x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580
	|-IdentityFunction.<>c<object>.<get_Instance>b__1_0
	|-IdentityFunction.<>c<QRCodeGenerator.PolynomItem>.<get_Instance>b__1_0
	|
	|-RVA: 0xB08170 Offset: 0xB07370 VA: 0x180B08170
	|-IdentityFunction.<>c<__Il2CppFullySharedGenericType>.<get_Instance>b__1_0
	*/
}

// Namespace: System.Linq
internal class IdentityFunction<TElement> // TypeDefIndex: 14657
{
	// Properties
	public static Func<TElement, TElement> Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Func<TElement, TElement> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126ACA0 Offset: 0x1269EA0 VA: 0x18126ACA0
	|-IdentityFunction<object>.get_Instance
	|
	|-RVA: 0x126B100 Offset: 0x126A300 VA: 0x18126B100
	|-IdentityFunction<__Il2CppFullySharedGenericType>.get_Instance
	|
	|-RVA: 0x126AED0 Offset: 0x126A0D0 VA: 0x18126AED0
	|-IdentityFunction<QRCodeGenerator.PolynomItem>.get_Instance
	*/
}

// Namespace: System.Linq
public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 14658
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IOrderedEnumerable<__Il2CppFullySharedGenericType>.CreateOrderedEnumerable<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Linq
public interface IGrouping<TKey, TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 14659
{
	// Properties
	public abstract TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TKey get_Key();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGrouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Lookup.Grouping.<GetEnumerator>d__7<TKey, TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 14660
{
	// Fields
	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public Lookup.Grouping<TKey, TElement> <>4__this; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	|-Lookup.Grouping.<GetEnumerator>d__7<int, object>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<int, QRCodeGenerator.PolynomItem>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>..ctor
	|
	|-RVA: 0xB1E9D0 Offset: 0xB1DBD0 VA: 0x180B1E9D0
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-Lookup.Grouping.<GetEnumerator>d__7<int, object>.System.IDisposable.Dispose
	|-Lookup.Grouping.<GetEnumerator>d__7<int, QRCodeGenerator.PolynomItem>.System.IDisposable.Dispose
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.IDisposable.Dispose
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB24270 Offset: 0xB23470 VA: 0x180B24270
	|-Lookup.Grouping.<GetEnumerator>d__7<int, object>.MoveNext
	|
	|-RVA: 0xB242E0 Offset: 0xB234E0 VA: 0x180B242E0
	|-Lookup.Grouping.<GetEnumerator>d__7<int, QRCodeGenerator.PolynomItem>.MoveNext
	|
	|-RVA: 0xB24350 Offset: 0xB23550 VA: 0x180B24350
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.MoveNext
	|
	|-RVA: 0xB243C0 Offset: 0xB235C0 VA: 0x180B243C0
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Lookup.Grouping.<GetEnumerator>d__7<int, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB220A0 Offset: 0xB212A0 VA: 0x180B220A0
	|-Lookup.Grouping.<GetEnumerator>d__7<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB23C90 Offset: 0xB22E90 VA: 0x180B23C90
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Lookup.Grouping.<GetEnumerator>d__7<int, object>.System.Collections.IEnumerator.Reset
	|-Lookup.Grouping.<GetEnumerator>d__7<int, QRCodeGenerator.PolynomItem>.System.Collections.IEnumerator.Reset
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.Reset
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Lookup.Grouping.<GetEnumerator>d__7<int, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB246C0 Offset: 0xB238C0 VA: 0x180B246C0
	|-Lookup.Grouping.<GetEnumerator>d__7<int, QRCodeGenerator.PolynomItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB23D80 Offset: 0xB22F80 VA: 0x180B23D80
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
internal class Lookup.Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement> // TypeDefIndex: 14661
{
	// Fields
	internal TKey key; // 0x0
	internal int hashCode; // 0x0
	internal TElement[] elements; // 0x0
	internal int count; // 0x0
	internal Lookup.Grouping<TKey, TElement> hashNext; // 0x0
	internal Lookup.Grouping<TKey, TElement> next; // 0x0

	// Properties
	public TKey Key { get; }
	private int System.Collections.Generic.ICollection<TElement>.Count { get; }
	private bool System.Collections.Generic.ICollection<TElement>.IsReadOnly { get; }
	private TElement System.Collections.Generic.IList<TElement>.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void Add(TElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1213C70 Offset: 0x1212E70 VA: 0x181213C70
	|-Lookup.Grouping<int, object>.Add
	|
	|-RVA: 0x1213870 Offset: 0x1212A70 VA: 0x181213870
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.Add
	|
	|-RVA: 0x1213BC0 Offset: 0x1212DC0 VA: 0x181213BC0
	|-Lookup.Grouping<object, object>.Add
	|
	|-RVA: 0x1213920 Offset: 0x1212B20 VA: 0x181213920
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	[IteratorStateMachine(typeof(Lookup.Grouping.<GetEnumerator>d__7<TKey, TElement>))]
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1213D20 Offset: 0x1212F20 VA: 0x181213D20
	|-Lookup.Grouping<int, object>.GetEnumerator
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.GetEnumerator
	|-Lookup.Grouping<object, object>.GetEnumerator
	|
	|-RVA: 0x1213DA0 Offset: 0x1212FA0 VA: 0x181213DA0
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12145F0 Offset: 0x12137F0 VA: 0x1812145F0
	|-Lookup.Grouping<int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB205F0 Offset: 0xB1F7F0 VA: 0x180B205F0
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-Lookup.Grouping<int, object>.get_Key
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.get_Key
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-Lookup.Grouping<object, object>.get_Key
	|
	|-RVA: 0x1214680 Offset: 0x1213880 VA: 0x181214680
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Collections.Generic.ICollection<TElement>.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	|-Lookup.Grouping<int, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.ICollection<TElement>.get_Count
	|
	|-RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|
	|-RVA: 0x12141C0 Offset: 0x12133C0 VA: 0x1812141C0
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-Lookup.Grouping<int, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1213E50 Offset: 0x1213050 VA: 0x181213E50
	|-Lookup.Grouping<int, object>.System.Collections.Generic.ICollection<TElement>.Add
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.ICollection<TElement>.Add
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Add
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.Generic.ICollection<TElement>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1213E70 Offset: 0x1213070 VA: 0x181213E70
	|-Lookup.Grouping<int, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.ICollection<TElement>.Clear
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1214070 Offset: 0x1213270 VA: 0x181214070
	|-Lookup.Grouping<int, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x1213ED0 Offset: 0x12130D0 VA: 0x181213ED0
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x1213E90 Offset: 0x1213090 VA: 0x181213E90
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x1213F10 Offset: 0x1213110 VA: 0x181213F10
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12140B0 Offset: 0x12132B0 VA: 0x1812140B0
	|-Lookup.Grouping<int, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|
	|-RVA: 0x12140E0 Offset: 0x12132E0 VA: 0x1812140E0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|
	|-RVA: 0x1214110 Offset: 0x1213310 VA: 0x181214110
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1213E50 Offset: 0x1213050 VA: 0x181213E50
	|-Lookup.Grouping<int, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.ICollection<TElement>.Remove
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12141F0 Offset: 0x12133F0 VA: 0x1812141F0
	|-Lookup.Grouping<int, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x1214220 Offset: 0x1213420 VA: 0x181214220
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x12143A0 Offset: 0x12135A0 VA: 0x1812143A0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x1214250 Offset: 0x1213450 VA: 0x181214250
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12143D0 Offset: 0x12135D0 VA: 0x1812143D0
	|-Lookup.Grouping<int, object>.System.Collections.Generic.IList<TElement>.Insert
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.IList<TElement>.Insert
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.Insert
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1213E50 Offset: 0x1213050 VA: 0x181213E50
	|-Lookup.Grouping<int, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.IList<TElement>.RemoveAt
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1214590 Offset: 0x1213790 VA: 0x181214590
	|-Lookup.Grouping<int, object>.System.Collections.Generic.IList<TElement>.get_Item
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x12143F0 Offset: 0x12135F0 VA: 0x1812143F0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1214450 Offset: 0x1213650 VA: 0x181214450
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12143D0 Offset: 0x12135D0 VA: 0x1812143D0
	|-Lookup.Grouping<int, object>.System.Collections.Generic.IList<TElement>.set_Item
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.IList<TElement>.set_Item
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.set_Item
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-Lookup.Grouping<int, object>..ctor
	|-Lookup.Grouping<int, QRCodeGenerator.PolynomItem>..ctor
	|-Lookup.Grouping<object, object>..ctor
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Lookup.<GetEnumerator>d__12<TKey, TElement> : IEnumerator<IGrouping<TKey, TElement>>, IDisposable, IEnumerator // TypeDefIndex: 14662
{
	// Fields
	private int <>1__state; // 0x0
	private IGrouping<TKey, TElement> <>2__current; // 0x0
	public Lookup<TKey, TElement> <>4__this; // 0x0
	private Lookup.Grouping<TKey, TElement> <g>5__2; // 0x0

	// Properties
	private IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	|-Lookup.<GetEnumerator>d__12<int, object>..ctor
	|-Lookup.<GetEnumerator>d__12<int, QRCodeGenerator.PolynomItem>..ctor
	|-Lookup.<GetEnumerator>d__12<object, object>..ctor
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-Lookup.<GetEnumerator>d__12<int, object>.System.IDisposable.Dispose
	|-Lookup.<GetEnumerator>d__12<int, QRCodeGenerator.PolynomItem>.System.IDisposable.Dispose
	|-Lookup.<GetEnumerator>d__12<object, object>.System.IDisposable.Dispose
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB20E60 Offset: 0xB20060 VA: 0x180B20E60
	|-Lookup.<GetEnumerator>d__12<int, object>.MoveNext
	|-Lookup.<GetEnumerator>d__12<int, QRCodeGenerator.PolynomItem>.MoveNext
	|
	|-RVA: 0xB20EE0 Offset: 0xB200E0 VA: 0x180B20EE0
	|-Lookup.<GetEnumerator>d__12<object, object>.MoveNext
	|
	|-RVA: 0xB20DC0 Offset: 0xB1FFC0 VA: 0x180B20DC0
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Lookup.<GetEnumerator>d__12<int, object>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	|-Lookup.<GetEnumerator>d__12<int, QRCodeGenerator.PolynomItem>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Lookup.<GetEnumerator>d__12<int, object>.System.Collections.IEnumerator.Reset
	|-Lookup.<GetEnumerator>d__12<int, QRCodeGenerator.PolynomItem>.System.Collections.IEnumerator.Reset
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.IEnumerator.Reset
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Lookup.<GetEnumerator>d__12<int, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.<GetEnumerator>d__12<int, QRCodeGenerator.PolynomItem>.System.Collections.IEnumerator.get_Current
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Linq
[DefaultMember("Item")]
public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 14663
{
	// Fields
	private IEqualityComparer<TKey> comparer; // 0x0
	private Lookup.Grouping<TKey, TElement>[] groupings; // 0x0
	private Lookup.Grouping<TKey, TElement> lastGrouping; // 0x0
	private int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EE340 Offset: 0x8ED540 VA: 0x1808EE340
	|-Lookup<int, object>.Create<object>
	|
	|-RVA: 0x8EDCC0 Offset: 0x8ECEC0 VA: 0x1808EDCC0
	|-Lookup<int, QRCodeGenerator.PolynomItem>.Create<QRCodeGenerator.PolynomItem>
	|
	|-RVA: 0x8ED920 Offset: 0x8ECB20 VA: 0x1808ED920
	|-Lookup<object, object>.Create<KeyValuePair<object, object>>
	|
	|-RVA: 0x8EE030 Offset: 0x8ED230 VA: 0x1808EE030
	|-Lookup<object, object>.Create<object>
	|
	|-RVA: 0x8ED330 Offset: 0x8EC530 VA: 0x1808ED330
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Create<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x145C920 Offset: 0x145BB20 VA: 0x18145C920
	|-Lookup<int, object>..ctor
	|-Lookup<int, QRCodeGenerator.PolynomItem>..ctor
	|
	|-RVA: 0x145CA30 Offset: 0x145BC30 VA: 0x18145CA30
	|-Lookup<object, object>..ctor
	|
	|-RVA: 0x145C9A0 Offset: 0x145BBA0 VA: 0x18145C9A0
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[IteratorStateMachine(typeof(Lookup.<GetEnumerator>d__12<TKey, TElement>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BCA00 Offset: 0x11BBC00 VA: 0x1811BCA00
	|-Lookup<int, object>.GetEnumerator
	|-Lookup<int, QRCodeGenerator.PolynomItem>.GetEnumerator
	|-Lookup<object, object>.GetEnumerator
	|
	|-RVA: 0x145B550 Offset: 0x145A750 VA: 0x18145B550
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x145C890 Offset: 0x145BA90 VA: 0x18145C890
	|-Lookup<int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup<int, QRCodeGenerator.PolynomItem>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBB2A10 Offset: 0xBB1C10 VA: 0x180BB2A10
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x145C3A0 Offset: 0x145B5A0 VA: 0x18145C3A0
	|-Lookup<int, object>.InternalGetHashCode
	|-Lookup<int, QRCodeGenerator.PolynomItem>.InternalGetHashCode
	|
	|-RVA: 0x145C400 Offset: 0x145B600 VA: 0x18145C400
	|-Lookup<object, object>.InternalGetHashCode
	|
	|-RVA: 0x145C250 Offset: 0x145B450 VA: 0x18145C250
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InternalGetHashCode
	*/

	// RVA: -1 Offset: -1
	internal Lookup.Grouping<TKey, TElement> GetGrouping(TKey key, bool create) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x145BEC0 Offset: 0x145B0C0 VA: 0x18145BEC0
	|-Lookup<int, object>.GetGrouping
	|-Lookup<int, QRCodeGenerator.PolynomItem>.GetGrouping
	|
	|-RVA: 0x145BB30 Offset: 0x145AD30 VA: 0x18145BB30
	|-Lookup<object, object>.GetGrouping
	|
	|-RVA: 0x145B5D0 Offset: 0x145A7D0 VA: 0x18145B5D0
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetGrouping
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x145C630 Offset: 0x145B830 VA: 0x18145C630
	|-Lookup<int, object>.Resize
	|-Lookup<int, QRCodeGenerator.PolynomItem>.Resize
	|
	|-RVA: 0x145C760 Offset: 0x145B960 VA: 0x18145C760
	|-Lookup<object, object>.Resize
	|
	|-RVA: 0x145C470 Offset: 0x145B670 VA: 0x18145C470
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Resize
	*/
}

// Namespace: 
internal struct Set.Slot<TElement> // TypeDefIndex: 14664
{
	// Fields
	internal int hashCode; // 0x0
	internal TElement value; // 0x0
	internal int next; // 0x0
}

// Namespace: System.Linq
internal class Set<TElement> // TypeDefIndex: 14665
{
	// Fields
	private int[] buckets; // 0x0
	private Set.Slot<TElement>[] slots; // 0x0
	private int count; // 0x0
	private int freeList; // 0x0
	private IEqualityComparer<TElement> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TElement> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4C00 Offset: 0xBF3E00 VA: 0x180BF4C00
	|-Set<char>..ctor
	|
	|-RVA: 0xBF4CC0 Offset: 0xBF3EC0 VA: 0x180BF4CC0
	|-Set<int>..ctor
	|
	|-RVA: 0xBF4A50 Offset: 0xBF3C50 VA: 0x180BF4A50
	|-Set<Int32Enum>..ctor
	|
	|-RVA: 0xBF4E70 Offset: 0xBF4070 VA: 0x180BF4E70
	|-Set<object>..ctor
	|
	|-RVA: 0xBF4F30 Offset: 0xBF4130 VA: 0x180BF4F30
	|-Set<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2800 Offset: 0xBF1A00 VA: 0x180BF2800
	|-Set<char>.Add
	|
	|-RVA: 0xBF27D0 Offset: 0xBF19D0 VA: 0x180BF27D0
	|-Set<int>.Add
	|
	|-RVA: 0xBF2830 Offset: 0xBF1A30 VA: 0x180BF2830
	|-Set<Int32Enum>.Add
	|
	|-RVA: 0xBF2860 Offset: 0xBF1A60 VA: 0x180BF2860
	|-Set<object>.Add
	|
	|-RVA: 0xBF2890 Offset: 0xBF1A90 VA: 0x180BF2890
	|-Set<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF3AA0 Offset: 0xBF2CA0 VA: 0x180BF3AA0
	|-Set<char>.Find
	|
	|-RVA: 0xBF2DF0 Offset: 0xBF1FF0 VA: 0x180BF2DF0
	|-Set<int>.Find
	|
	|-RVA: 0xBF31B0 Offset: 0xBF23B0 VA: 0x180BF31B0
	|-Set<Int32Enum>.Find
	|
	|-RVA: 0xBF2990 Offset: 0xBF1B90 VA: 0x180BF2990
	|-Set<object>.Find
	|
	|-RVA: 0xBF3570 Offset: 0xBF2770 VA: 0x180BF3570
	|-Set<__Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF48F0 Offset: 0xBF3AF0 VA: 0x180BF48F0
	|-Set<char>.Resize
	|
	|-RVA: 0xBF4790 Offset: 0xBF3990 VA: 0x180BF4790
	|-Set<int>.Resize
	|
	|-RVA: 0xBF4630 Offset: 0xBF3830 VA: 0x180BF4630
	|-Set<Int32Enum>.Resize
	|
	|-RVA: 0xBF44D0 Offset: 0xBF36D0 VA: 0x180BF44D0
	|-Set<object>.Resize
	|
	|-RVA: 0xBF42B0 Offset: 0xBF34B0 VA: 0x180BF42B0
	|-Set<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF41E0 Offset: 0xBF33E0 VA: 0x180BF41E0
	|-Set<char>.InternalGetHashCode
	|
	|-RVA: 0xBF4180 Offset: 0xBF3380 VA: 0x180BF4180
	|-Set<int>.InternalGetHashCode
	|-Set<Int32Enum>.InternalGetHashCode
	|
	|-RVA: 0xBF40B0 Offset: 0xBF32B0 VA: 0x180BF40B0
	|-Set<object>.InternalGetHashCode
	|
	|-RVA: 0xBF3EE0 Offset: 0xBF30E0 VA: 0x180BF3EE0
	|-Set<__Il2CppFullySharedGenericType>.InternalGetHashCode
	*/
}

// Namespace: System.Linq
internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 14666
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, TKey> keySelector; // 0x0
	private Func<TSource, TElement> elementSelector; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12137A0 Offset: 0x12129A0 VA: 0x1812137A0
	|-GroupedEnumerable<KeyValuePair<object, object>, object, object>..ctor
	|-GroupedEnumerable<object, int, object>..ctor
	|-GroupedEnumerable<object, object, object>..ctor
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|-GroupedEnumerable<QRCodeGenerator.PolynomItem, int, QRCodeGenerator.PolynomItem>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1213580 Offset: 0x1212780 VA: 0x181213580
	|-GroupedEnumerable<KeyValuePair<object, object>, object, object>.GetEnumerator
	|
	|-RVA: 0x1213400 Offset: 0x1212600 VA: 0x181213400
	|-GroupedEnumerable<object, int, object>.GetEnumerator
	|
	|-RVA: 0x12134C0 Offset: 0x12126C0 VA: 0x1812134C0
	|-GroupedEnumerable<object, object, object>.GetEnumerator
	|
	|-RVA: 0x1213460 Offset: 0x1212660 VA: 0x181213460
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x1213520 Offset: 0x1212720 VA: 0x181213520
	|-GroupedEnumerable<QRCodeGenerator.PolynomItem, int, QRCodeGenerator.PolynomItem>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12136C0 Offset: 0x12128C0 VA: 0x1812136C0
	|-GroupedEnumerable<KeyValuePair<object, object>, object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1213650 Offset: 0x1212850 VA: 0x181213650
	|-GroupedEnumerable<object, int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12135E0 Offset: 0x12127E0 VA: 0x1812135E0
	|-GroupedEnumerable<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB1B530 Offset: 0xB1A730 VA: 0x180B1B530
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1213730 Offset: 0x1212930 VA: 0x181213730
	|-GroupedEnumerable<QRCodeGenerator.PolynomItem, int, QRCodeGenerator.PolynomItem>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class OrderedEnumerable.<GetEnumerator>d__1<TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 14667
{
	// Fields
	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public OrderedEnumerable<TElement> <>4__this; // 0x0
	private Buffer<TElement> <buffer>5__2; // 0x0
	private int[] <map>5__3; // 0x0
	private int <i>5__4; // 0x0

	// Properties
	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<object>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<QRCodeGenerator.PolynomItem>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<SpawnInMinigame.SpawnLocation>..ctor
	|
	|-RVA: 0xB1E9D0 Offset: 0xB1DBD0 VA: 0x180B1E9D0
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<DiscardReasonWithCategory, int>>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<QRCodeGenerator.PolynomItem>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<SpawnInMinigame.SpawnLocation>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB214C0 Offset: 0xB206C0 VA: 0x180B214C0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<DiscardReasonWithCategory, int>>.MoveNext
	|
	|-RVA: 0xB210B0 Offset: 0xB202B0 VA: 0x180B210B0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0xB218E0 Offset: 0xB20AE0 VA: 0x180B218E0
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.MoveNext
	|
	|-RVA: 0xB21770 Offset: 0xB20970 VA: 0x180B21770
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.MoveNext
	|
	|-RVA: 0xB21360 Offset: 0xB20560 VA: 0x180B21360
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.MoveNext
	|
	|-RVA: 0xB21A40 Offset: 0xB20C40 VA: 0x180B21A40
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.MoveNext
	|
	|-RVA: 0xB21620 Offset: 0xB20820 VA: 0x180B21620
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.MoveNext
	|
	|-RVA: 0xB21BA0 Offset: 0xB20DA0 VA: 0x180B21BA0
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0xB20F60 Offset: 0xB20160 VA: 0x180B20F60
	|-OrderedEnumerable.<GetEnumerator>d__1<QRCodeGenerator.PolynomItem>.MoveNext
	|
	|-RVA: 0xB21200 Offset: 0xB20400 VA: 0x180B21200
	|-OrderedEnumerable.<GetEnumerator>d__1<SpawnInMinigame.SpawnLocation>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<DiscardReasonWithCategory, int>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x4C1250 Offset: 0x4C0450 VA: 0x1804C1250
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<SpawnInMinigame.SpawnLocation>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB22080 Offset: 0xB21280 VA: 0x180B22080
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB1CEE0 Offset: 0xB1C0E0 VA: 0x180B1CEE0
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB220A0 Offset: 0xB212A0 VA: 0x180B220A0
	|-OrderedEnumerable.<GetEnumerator>d__1<QRCodeGenerator.PolynomItem>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<DiscardReasonWithCategory, int>>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<QRCodeGenerator.PolynomItem>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<SpawnInMinigame.SpawnLocation>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB220B0 Offset: 0xB212B0 VA: 0x180B220B0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<DiscardReasonWithCategory, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB22170 Offset: 0xB21370 VA: 0x180B22170
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB220F0 Offset: 0xB212F0 VA: 0x180B220F0
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<SpawnInMinigame.SpawnLocation>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB221A0 Offset: 0xB213A0 VA: 0x180B221A0
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB22130 Offset: 0xB21330 VA: 0x180B22130
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB1D160 Offset: 0xB1C360 VA: 0x180B1D160
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB221F0 Offset: 0xB213F0 VA: 0x180B221F0
	|-OrderedEnumerable.<GetEnumerator>d__1<QRCodeGenerator.PolynomItem>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Linq
internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 14668
{
	// Fields
	internal IEnumerable<TElement> source; // 0x0

	// Methods

	[IteratorStateMachine(typeof(OrderedEnumerable.<GetEnumerator>d__1<TElement>))]
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B6D0 Offset: 0xB7A8D0 VA: 0x180B7B6D0
	|-OrderedEnumerable<KeyValuePair<DiscardReasonWithCategory, int>>.GetEnumerator
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.GetEnumerator
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0xB7B8D0 Offset: 0xB7AAD0 VA: 0x180B7B8D0
	|-OrderedEnumerable<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0xB7B7D0 Offset: 0xB7A9D0 VA: 0x180B7B7D0
	|-OrderedEnumerable<DiagnosticEvent>.GetEnumerator
	|-OrderedEnumerable<SpawnInMinigame.SpawnLocation>.GetEnumerator
	|
	|-RVA: 0xB7B750 Offset: 0xB7A950 VA: 0x180B7B750
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0xB7B850 Offset: 0xB7AA50 VA: 0x180B7B850
	|-OrderedEnumerable<object>.GetEnumerator
	|-OrderedEnumerable<QRCodeGenerator.PolynomItem>.GetEnumerator
	|
	|-RVA: 0xB7B950 Offset: 0xB7AB50 VA: 0x180B7B950
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.GetEnumerableSorter
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7BA90 Offset: 0xB7AC90 VA: 0x180B7BA90
	|-OrderedEnumerable<KeyValuePair<DiscardReasonWithCategory, int>>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB7BC40 Offset: 0xB7AE40 VA: 0x180B7BC40
	|-OrderedEnumerable<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB7BB20 Offset: 0xB7AD20 VA: 0x180B7BB20
	|-OrderedEnumerable<DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<SpawnInMinigame.SpawnLocation>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB7BBB0 Offset: 0xB7ADB0 VA: 0x180B7BBB0
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB7BA00 Offset: 0xB7AC00 VA: 0x180B7BA00
	|-OrderedEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<QRCodeGenerator.PolynomItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB7BCD0 Offset: 0xB7AED0 VA: 0x180B7BCD0
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EE7D0 Offset: 0x8ED9D0 VA: 0x1808EE7D0
	|-OrderedEnumerable<KeyValuePair<DiscardReasonWithCategory, int>>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<DataCategory>
	|
	|-RVA: 0x8EEC50 Offset: 0x8EDE50 VA: 0x1808EEC50
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|
	|-RVA: 0x8EE650 Offset: 0x8ED850 VA: 0x1808EE650
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<bool>
	|
	|-RVA: 0x8EE710 Offset: 0x8ED910 VA: 0x1808EE710
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<byte>
	|
	|-RVA: 0x8EE890 Offset: 0x8EDA90 VA: 0x1808EE890
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<DateTime>
	|
	|-RVA: 0x8EEA10 Offset: 0x8EDC10 VA: 0x1808EEA10
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<int>
	|
	|-RVA: 0x8EEAD0 Offset: 0x8EDCD0 VA: 0x1808EEAD0
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<object>
	|
	|-RVA: 0x8EEB90 Offset: 0x8EDD90 VA: 0x1808EEB90
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<float>
	|-OrderedEnumerable<SpawnInMinigame.SpawnLocation>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<float>
	|
	|-RVA: 0x8EE950 Offset: 0x8EDB50 VA: 0x1808EE950
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-OrderedEnumerable<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|-OrderedEnumerable<KeyValuePair<object, object>>..ctor
	|-OrderedEnumerable<DiagnosticEvent>..ctor
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>..ctor
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>..ctor
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>..ctor
	|-OrderedEnumerable<object>..ctor
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>..ctor
	|-OrderedEnumerable<QRCodeGenerator.PolynomItem>..ctor
	|-OrderedEnumerable<SpawnInMinigame.SpawnLocation>..ctor
	*/
}

// Namespace: System.Linq
internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement> // TypeDefIndex: 14669
{
	// Fields
	internal OrderedEnumerable<TElement> parent; // 0x0
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7C370 Offset: 0xB7B570 VA: 0x180B7C370
	|-OrderedEnumerable<KeyValuePair<DiscardReasonWithCategory, int>, DataCategory>..ctor
	|
	|-RVA: 0xB7C030 Offset: 0xB7B230 VA: 0x180B7C030
	|-OrderedEnumerable<KeyValuePair<DiscardReasonWithCategory, int>, DiscardReason>..ctor
	|
	|-RVA: 0xB7C1D0 Offset: 0xB7B3D0 VA: 0x180B7C1D0
	|-OrderedEnumerable<KeyValuePair<object, object>, object>..ctor
	|-OrderedEnumerable<object, object>..ctor
	|
	|-RVA: 0xB7C100 Offset: 0xB7B300 VA: 0x180B7C100
	|-OrderedEnumerable<DiagnosticEvent, int>..ctor
	|-OrderedEnumerable<object, int>..ctor
	|-OrderedEnumerable<QRCodeGenerator.PolynomItem, int>..ctor
	|
	|-RVA: 0xB7BF60 Offset: 0xB7B160 VA: 0x180B7BF60
	|-OrderedEnumerable<GlyphPairAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<object, uint>..ctor
	|
	|-RVA: 0xB7C2A0 Offset: 0xB7B4A0 VA: 0x180B7C2A0
	|-OrderedEnumerable<object, bool>..ctor
	|
	|-RVA: 0xB7C5E0 Offset: 0xB7B7E0 VA: 0x180B7C5E0
	|-OrderedEnumerable<object, byte>..ctor
	|
	|-RVA: 0xB7C440 Offset: 0xB7B640 VA: 0x180B7C440
	|-OrderedEnumerable<object, DateTime>..ctor
	|
	|-RVA: 0xB7C510 Offset: 0xB7B710 VA: 0x180B7C510
	|-OrderedEnumerable<object, DateTimeOffset>..ctor
	|
	|-RVA: 0xB7C780 Offset: 0xB7B980 VA: 0x180B7C780
	|-OrderedEnumerable<object, Int32Enum>..ctor
	|
	|-RVA: 0xB7BE90 Offset: 0xB7B090 VA: 0x180B7BE90
	|-OrderedEnumerable<object, float>..ctor
	|-OrderedEnumerable<SpawnInMinigame.SpawnLocation, float>..ctor
	|
	|-RVA: 0xB7C6B0 Offset: 0xB7B8B0 VA: 0x180B7C6B0
	|-OrderedEnumerable<object, TimeSpan>..ctor
	|
	|-RVA: 0xB7C850 Offset: 0xB7BA50 VA: 0x180B7C850
	|-OrderedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7BCF0 Offset: 0xB7AEF0 VA: 0x180B7BCF0
	|-OrderedEnumerable<KeyValuePair<DiscardReasonWithCategory, int>, DataCategory>.GetEnumerableSorter
	|-OrderedEnumerable<KeyValuePair<DiscardReasonWithCategory, int>, DiscardReason>.GetEnumerableSorter
	|-OrderedEnumerable<KeyValuePair<object, object>, object>.GetEnumerableSorter
	|-OrderedEnumerable<DiagnosticEvent, int>.GetEnumerableSorter
	|-OrderedEnumerable<GlyphPairAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<object, bool>.GetEnumerableSorter
	|-OrderedEnumerable<object, byte>.GetEnumerableSorter
	|-OrderedEnumerable<object, DateTime>.GetEnumerableSorter
	|-OrderedEnumerable<object, DateTimeOffset>.GetEnumerableSorter
	|-OrderedEnumerable<object, int>.GetEnumerableSorter
	|-OrderedEnumerable<object, Int32Enum>.GetEnumerableSorter
	|-OrderedEnumerable<object, object>.GetEnumerableSorter
	|-OrderedEnumerable<object, float>.GetEnumerableSorter
	|-OrderedEnumerable<object, TimeSpan>.GetEnumerableSorter
	|-OrderedEnumerable<object, uint>.GetEnumerableSorter
	|-OrderedEnumerable<QRCodeGenerator.PolynomItem, int>.GetEnumerableSorter
	|-OrderedEnumerable<SpawnInMinigame.SpawnLocation, float>.GetEnumerableSorter
	|
	|-RVA: 0xB7BDC0 Offset: 0xB7AFC0 VA: 0x180B7BDC0
	|-OrderedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerableSorter
	*/
}

// Namespace: System.Linq
internal abstract class EnumerableSorter<TElement> // TypeDefIndex: 14670
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void ComputeKeys(TElement[] elements, int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int CompareKeys(int index1, int index2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.CompareKeys
	*/

	// RVA: -1 Offset: -1
	internal int[] Sort(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E3690 Offset: 0x10E2890 VA: 0x1810E3690
	|-EnumerableSorter<KeyValuePair<DiscardReasonWithCategory, int>>.Sort
	|
	|-RVA: 0x10E3CB0 Offset: 0x10E2EB0 VA: 0x1810E3CB0
	|-EnumerableSorter<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x10E35B0 Offset: 0x10E27B0 VA: 0x1810E35B0
	|-EnumerableSorter<DiagnosticEvent>.Sort
	|
	|-RVA: 0x10E3A10 Offset: 0x10E2C10 VA: 0x1810E3A10
	|-EnumerableSorter<GlyphPairAdjustmentRecord>.Sort
	|
	|-RVA: 0x10E3850 Offset: 0x10E2A50 VA: 0x1810E3850
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.Sort
	|
	|-RVA: 0x10E34D0 Offset: 0x10E26D0 VA: 0x1810E34D0
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.Sort
	|
	|-RVA: 0x10E3AF0 Offset: 0x10E2CF0 VA: 0x1810E3AF0
	|-EnumerableSorter<object>.Sort
	|
	|-RVA: 0x10E3770 Offset: 0x10E2970 VA: 0x1810E3770
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0x10E3930 Offset: 0x10E2B30 VA: 0x1810E3930
	|-EnumerableSorter<QRCodeGenerator.PolynomItem>.Sort
	|
	|-RVA: 0x10E3BD0 Offset: 0x10E2DD0 VA: 0x1810E3BD0
	|-EnumerableSorter<SpawnInMinigame.SpawnLocation>.Sort
	*/

	// RVA: -1 Offset: -1
	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E3030 Offset: 0x10E2230 VA: 0x1810E3030
	|-EnumerableSorter<KeyValuePair<DiscardReasonWithCategory, int>>.QuickSort
	|-EnumerableSorter<KeyValuePair<object, object>>.QuickSort
	|-EnumerableSorter<DiagnosticEvent>.QuickSort
	|-EnumerableSorter<GlyphPairAdjustmentRecord>.QuickSort
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.QuickSort
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.QuickSort
	|-EnumerableSorter<object>.QuickSort
	|-EnumerableSorter<QRCodeGenerator.PolynomItem>.QuickSort
	|-EnumerableSorter<SpawnInMinigame.SpawnLocation>.QuickSort
	|
	|-RVA: 0x10E3280 Offset: 0x10E2480 VA: 0x1810E3280
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.QuickSort
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-EnumerableSorter<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|-EnumerableSorter<KeyValuePair<object, object>>..ctor
	|-EnumerableSorter<DiagnosticEvent>..ctor
	|-EnumerableSorter<GlyphPairAdjustmentRecord>..ctor
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>..ctor
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>..ctor
	|-EnumerableSorter<object>..ctor
	|-EnumerableSorter<__Il2CppFullySharedGenericType>..ctor
	|-EnumerableSorter<QRCodeGenerator.PolynomItem>..ctor
	|-EnumerableSorter<SpawnInMinigame.SpawnLocation>..ctor
	*/
}

// Namespace: System.Linq
internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement> // TypeDefIndex: 14671
{
	// Fields
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0
	internal EnumerableSorter<TElement> next; // 0x0
	internal TKey[] keys; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E5750 Offset: 0x10E4950 VA: 0x1810E5750
	|-EnumerableSorter<KeyValuePair<DiscardReasonWithCategory, int>, DataCategory>..ctor
	|-EnumerableSorter<KeyValuePair<DiscardReasonWithCategory, int>, DiscardReason>..ctor
	|-EnumerableSorter<KeyValuePair<object, object>, object>..ctor
	|-EnumerableSorter<DiagnosticEvent, int>..ctor
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<object, bool>..ctor
	|-EnumerableSorter<object, byte>..ctor
	|-EnumerableSorter<object, DateTime>..ctor
	|-EnumerableSorter<object, DateTimeOffset>..ctor
	|-EnumerableSorter<object, int>..ctor
	|-EnumerableSorter<object, Int32Enum>..ctor
	|-EnumerableSorter<object, object>..ctor
	|-EnumerableSorter<object, float>..ctor
	|-EnumerableSorter<object, TimeSpan>..ctor
	|-EnumerableSorter<object, uint>..ctor
	|-EnumerableSorter<QRCodeGenerator.PolynomItem, int>..ctor
	|-EnumerableSorter<SpawnInMinigame.SpawnLocation, float>..ctor
	|
	|-RVA: 0x10E57B0 Offset: 0x10E49B0 VA: 0x1810E57B0
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override void ComputeKeys(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E5110 Offset: 0x10E4310 VA: 0x1810E5110
	|-EnumerableSorter<KeyValuePair<DiscardReasonWithCategory, int>, DataCategory>.ComputeKeys
	|-EnumerableSorter<KeyValuePair<DiscardReasonWithCategory, int>, DiscardReason>.ComputeKeys
	|
	|-RVA: 0x10E4BB0 Offset: 0x10E3DB0 VA: 0x1810E4BB0
	|-EnumerableSorter<KeyValuePair<object, object>, object>.ComputeKeys
	|
	|-RVA: 0x10E5600 Offset: 0x10E4800 VA: 0x1810E5600
	|-EnumerableSorter<DiagnosticEvent, int>.ComputeKeys
	|
	|-RVA: 0x10E4900 Offset: 0x10E3B00 VA: 0x1810E4900
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>.ComputeKeys
	|
	|-RVA: 0x10E4A60 Offset: 0x10E3C60 VA: 0x1810E4A60
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.ComputeKeys
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.ComputeKeys
	|
	|-RVA: 0x10E4CE0 Offset: 0x10E3EE0 VA: 0x1810E4CE0
	|-EnumerableSorter<object, bool>.ComputeKeys
	|-EnumerableSorter<object, byte>.ComputeKeys
	|
	|-RVA: 0x10E5000 Offset: 0x10E4200 VA: 0x1810E5000
	|-EnumerableSorter<object, DateTime>.ComputeKeys
	|-EnumerableSorter<object, TimeSpan>.ComputeKeys
	|
	|-RVA: 0x10E5260 Offset: 0x10E4460 VA: 0x1810E5260
	|-EnumerableSorter<object, DateTimeOffset>.ComputeKeys
	|
	|-RVA: 0x10E47E0 Offset: 0x10E39E0 VA: 0x1810E47E0
	|-EnumerableSorter<object, int>.ComputeKeys
	|-EnumerableSorter<object, Int32Enum>.ComputeKeys
	|-EnumerableSorter<object, uint>.ComputeKeys
	|-EnumerableSorter<QRCodeGenerator.PolynomItem, int>.ComputeKeys
	|
	|-RVA: 0x10E46D0 Offset: 0x10E38D0 VA: 0x1810E46D0
	|-EnumerableSorter<object, object>.ComputeKeys
	|
	|-RVA: 0x10E5380 Offset: 0x10E4580 VA: 0x1810E5380
	|-EnumerableSorter<object, float>.ComputeKeys
	|
	|-RVA: 0x10E4DE0 Offset: 0x10E3FE0 VA: 0x1810E4DE0
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ComputeKeys
	|
	|-RVA: 0x10E54A0 Offset: 0x10E46A0 VA: 0x1810E54A0
	|-EnumerableSorter<SpawnInMinigame.SpawnLocation, float>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E3E80 Offset: 0x10E3080 VA: 0x1810E3E80
	|-EnumerableSorter<KeyValuePair<DiscardReasonWithCategory, int>, DataCategory>.CompareKeys
	|-EnumerableSorter<KeyValuePair<DiscardReasonWithCategory, int>, DiscardReason>.CompareKeys
	|-EnumerableSorter<object, DateTime>.CompareKeys
	|-EnumerableSorter<object, TimeSpan>.CompareKeys
	|
	|-RVA: 0x10E3FD0 Offset: 0x10E31D0 VA: 0x1810E3FD0
	|-EnumerableSorter<KeyValuePair<object, object>, object>.CompareKeys
	|-EnumerableSorter<object, object>.CompareKeys
	|
	|-RVA: 0x10E3D90 Offset: 0x10E2F90 VA: 0x1810E3D90
	|-EnumerableSorter<DiagnosticEvent, int>.CompareKeys
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<object, int>.CompareKeys
	|-EnumerableSorter<object, Int32Enum>.CompareKeys
	|-EnumerableSorter<object, uint>.CompareKeys
	|-EnumerableSorter<QRCodeGenerator.PolynomItem, int>.CompareKeys
	|
	|-RVA: 0x10E40C0 Offset: 0x10E32C0 VA: 0x1810E40C0
	|-EnumerableSorter<object, bool>.CompareKeys
	|-EnumerableSorter<object, byte>.CompareKeys
	|
	|-RVA: 0x10E4550 Offset: 0x10E3750 VA: 0x1810E4550
	|-EnumerableSorter<object, DateTimeOffset>.CompareKeys
	|
	|-RVA: 0x10E4210 Offset: 0x10E3410 VA: 0x1810E4210
	|-EnumerableSorter<object, float>.CompareKeys
	|-EnumerableSorter<SpawnInMinigame.SpawnLocation, float>.CompareKeys
	|
	|-RVA: 0x10E4310 Offset: 0x10E3510 VA: 0x1810E4310
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareKeys
	*/
}

// Namespace: System.Linq
internal struct Buffer<TElement> // TypeDefIndex: 14672
{
	// Fields
	internal TElement[] items; // 0x0
	internal int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF2C70 Offset: 0xEF1E70 VA: 0x180EF2C70
	|-Buffer<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0xEF40A0 Offset: 0xEF32A0 VA: 0x180EF40A0
	|-Buffer<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|
	|-RVA: 0xEEFB60 Offset: 0xEEED60 VA: 0x180EEFB60
	|-Buffer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0xEF0A50 Offset: 0xEEFC50 VA: 0x180EF0A50
	|-Buffer<byte>..ctor
	|
	|-RVA: 0xEEF200 Offset: 0xEEE400 VA: 0x180EEF200
	|-Buffer<ByteEnum>..ctor
	|
	|-RVA: 0xEF0EC0 Offset: 0xEF00C0 VA: 0x180EF0EC0
	|-Buffer<Color>..ctor
	|
	|-RVA: 0xEF45C0 Offset: 0xEF37C0 VA: 0x180EF45C0
	|-Buffer<DiagnosticEvent>..ctor
	|
	|-RVA: 0xEF3160 Offset: 0xEF2360 VA: 0x180EF3160
	|-Buffer<Edge>..ctor
	|
	|-RVA: 0xEF3650 Offset: 0xEF2850 VA: 0x180EF3650
	|-Buffer<GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0xEF18F0 Offset: 0xEF0AF0 VA: 0x180EF18F0
	|-Buffer<int>..ctor
	|
	|-RVA: 0xEF05E0 Offset: 0xEEF7E0 VA: 0x180EF05E0
	|-Buffer<Int32Enum>..ctor
	|
	|-RVA: 0xEEDE60 Offset: 0xEED060 VA: 0x180EEDE60
	|-Buffer<MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0xEF2260 Offset: 0xEF1460 VA: 0x180EF2260
	|-Buffer<MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0xEED9F0 Offset: 0xEECBF0 VA: 0x180EED9F0
	|-Buffer<object>..ctor
	|
	|-RVA: 0xEEED00 Offset: 0xEEDF00 VA: 0x180EEED00
	|-Buffer<Resolution>..ctor
	|
	|-RVA: 0xEEE880 Offset: 0xEEDA80 VA: 0x180EEE880
	|-Buffer<float>..ctor
	|
	|-RVA: 0xEEF670 Offset: 0xEEE870 VA: 0x180EEF670
	|-Buffer<UInt16Enum>..ctor
	|
	|-RVA: 0xEF4AF0 Offset: 0xEF3CF0 VA: 0x180EF4AF0
	|-Buffer<uint>..ctor
	|
	|-RVA: 0xEF1D60 Offset: 0xEF0F60 VA: 0x180EF1D60
	|-Buffer<Vector2>..ctor
	|
	|-RVA: 0xEF3B90 Offset: 0xEF2D90 VA: 0x180EF3B90
	|-Buffer<Vector3>..ctor
	|
	|-RVA: 0xEEE380 Offset: 0xEED580 VA: 0x180EEE380
	|-Buffer<Vector4>..ctor
	|
	|-RVA: 0xEF0060 Offset: 0xEEF260 VA: 0x180EF0060
	|-Buffer<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xEF2780 Offset: 0xEF1980 VA: 0x180EF2780
	|-Buffer<QRCodeGenerator.PolynomItem>..ctor
	|
	|-RVA: 0xEF13C0 Offset: 0xEF05C0 VA: 0x180EF13C0
	|-Buffer<SpawnInMinigame.SpawnLocation>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TElement[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEED900 Offset: 0xEECB00 VA: 0x180EED900
	|-Buffer<KeyValuePair<byte, byte>>.ToArray
	|-Buffer<KeyValuePair<DiscardReasonWithCategory, int>>.ToArray
	|-Buffer<KeyValuePair<object, object>>.ToArray
	|-Buffer<byte>.ToArray
	|-Buffer<ByteEnum>.ToArray
	|-Buffer<Color>.ToArray
	|-Buffer<DiagnosticEvent>.ToArray
	|-Buffer<Edge>.ToArray
	|-Buffer<GlyphPairAdjustmentRecord>.ToArray
	|-Buffer<int>.ToArray
	|-Buffer<Int32Enum>.ToArray
	|-Buffer<MarkToBaseAdjustmentRecord>.ToArray
	|-Buffer<MarkToMarkAdjustmentRecord>.ToArray
	|-Buffer<object>.ToArray
	|-Buffer<Resolution>.ToArray
	|-Buffer<float>.ToArray
	|-Buffer<UInt16Enum>.ToArray
	|-Buffer<uint>.ToArray
	|-Buffer<Vector2>.ToArray
	|-Buffer<Vector3>.ToArray
	|-Buffer<Vector4>.ToArray
	|-Buffer<__Il2CppFullySharedGenericType>.ToArray
	|-Buffer<QRCodeGenerator.PolynomItem>.ToArray
	|-Buffer<SpawnInMinigame.SpawnLocation>.ToArray
	*/
}

// Namespace: System.Linq.Expressions
internal static class CachedReflectionInfo // TypeDefIndex: 14673
{
	// Fields
	private static MethodInfo s_String_Format_String_ObjectArray; // 0x0
	private static ConstructorInfo s_InvalidCastException_Ctor_String; // 0x8
	private static MethodInfo s_CallSiteOps_SetNotMatched; // 0x10
	private static MethodInfo s_CallSiteOps_CreateMatchmaker; // 0x18
	private static MethodInfo s_CallSiteOps_GetMatch; // 0x20
	private static MethodInfo s_CallSiteOps_ClearMatch; // 0x28
	private static MethodInfo s_CallSiteOps_UpdateRules; // 0x30
	private static MethodInfo s_CallSiteOps_GetRules; // 0x38
	private static MethodInfo s_CallSiteOps_GetRuleCache; // 0x40
	private static MethodInfo s_CallSiteOps_GetCachedRules; // 0x48
	private static MethodInfo s_CallSiteOps_AddRule; // 0x50
	private static MethodInfo s_CallSiteOps_MoveRule; // 0x58
	private static MethodInfo s_CallSiteOps_Bind; // 0x60
	private static MethodInfo s_DynamicObject_TryGetMember; // 0x68
	private static MethodInfo s_DynamicObject_TrySetMember; // 0x70
	private static MethodInfo s_DynamicObject_TryDeleteMember; // 0x78
	private static MethodInfo s_DynamicObject_TryGetIndex; // 0x80
	private static MethodInfo s_DynamicObject_TrySetIndex; // 0x88
	private static MethodInfo s_DynamicObject_TryDeleteIndex; // 0x90
	private static MethodInfo s_DynamicObject_TryConvert; // 0x98
	private static MethodInfo s_DynamicObject_TryInvoke; // 0xA0
	private static MethodInfo s_DynamicObject_TryInvokeMember; // 0xA8
	private static MethodInfo s_DynamicObject_TryBinaryOperation; // 0xB0
	private static MethodInfo s_DynamicObject_TryUnaryOperation; // 0xB8
	private static MethodInfo s_DynamicObject_TryCreateInstance; // 0xC0
	private static ConstructorInfo s_Nullable_Boolean_Ctor; // 0xC8
	private static ConstructorInfo s_Decimal_Ctor_Int32; // 0xD0
	private static ConstructorInfo s_Decimal_Ctor_UInt32; // 0xD8
	private static ConstructorInfo s_Decimal_Ctor_Int64; // 0xE0
	private static ConstructorInfo s_Decimal_Ctor_UInt64; // 0xE8
	private static ConstructorInfo s_Decimal_Ctor_Int32_Int32_Int32_Bool_Byte; // 0xF0
	private static FieldInfo s_Decimal_One; // 0xF8
	private static FieldInfo s_Decimal_MinusOne; // 0x100
	private static FieldInfo s_Decimal_MinValue; // 0x108
	private static FieldInfo s_Decimal_MaxValue; // 0x110
	private static FieldInfo s_Decimal_Zero; // 0x118
	private static FieldInfo s_DateTime_MinValue; // 0x120
	private static MethodInfo s_MethodBase_GetMethodFromHandle_RuntimeMethodHandle; // 0x128
	private static MethodInfo s_MethodBase_GetMethodFromHandle_RuntimeMethodHandle_RuntimeTypeHandle; // 0x130
	private static MethodInfo s_MethodInfo_CreateDelegate_Type_Object; // 0x138
	private static MethodInfo s_String_op_Equality_String_String; // 0x140
	private static MethodInfo s_String_Equals_String_String; // 0x148
	private static MethodInfo s_DictionaryOfStringInt32_Add_String_Int32; // 0x150
	private static ConstructorInfo s_DictionaryOfStringInt32_Ctor_Int32; // 0x158
	private static MethodInfo s_Type_GetTypeFromHandle; // 0x160
	private static MethodInfo s_Object_GetType; // 0x168
	private static MethodInfo s_Decimal_op_Implicit_Byte; // 0x170
	private static MethodInfo s_Decimal_op_Implicit_SByte; // 0x178
	private static MethodInfo s_Decimal_op_Implicit_Int16; // 0x180
	private static MethodInfo s_Decimal_op_Implicit_UInt16; // 0x188
	private static MethodInfo s_Decimal_op_Implicit_Int32; // 0x190
	private static MethodInfo s_Decimal_op_Implicit_UInt32; // 0x198
	private static MethodInfo s_Decimal_op_Implicit_Int64; // 0x1A0
	private static MethodInfo s_Decimal_op_Implicit_UInt64; // 0x1A8
	private static MethodInfo s_Decimal_op_Implicit_Char; // 0x1B0
	private static MethodInfo s_Math_Pow_Double_Double; // 0x1B8

	// Properties
	public static MethodInfo String_Format_String_ObjectArray { get; }
	public static ConstructorInfo InvalidCastException_Ctor_String { get; }
	public static MethodInfo CallSiteOps_SetNotMatched { get; }
	public static MethodInfo CallSiteOps_CreateMatchmaker { get; }
	public static MethodInfo CallSiteOps_GetMatch { get; }
	public static MethodInfo CallSiteOps_ClearMatch { get; }
	public static MethodInfo CallSiteOps_UpdateRules { get; }
	public static MethodInfo CallSiteOps_GetRules { get; }
	public static MethodInfo CallSiteOps_GetRuleCache { get; }
	public static MethodInfo CallSiteOps_GetCachedRules { get; }
	public static MethodInfo CallSiteOps_AddRule { get; }
	public static MethodInfo CallSiteOps_MoveRule { get; }
	public static MethodInfo CallSiteOps_Bind { get; }
	public static MethodInfo DynamicObject_TryGetMember { get; }
	public static MethodInfo DynamicObject_TrySetMember { get; }
	public static MethodInfo DynamicObject_TryDeleteMember { get; }
	public static MethodInfo DynamicObject_TryGetIndex { get; }
	public static MethodInfo DynamicObject_TrySetIndex { get; }
	public static MethodInfo DynamicObject_TryDeleteIndex { get; }
	public static MethodInfo DynamicObject_TryConvert { get; }
	public static MethodInfo DynamicObject_TryInvoke { get; }
	public static MethodInfo DynamicObject_TryInvokeMember { get; }
	public static MethodInfo DynamicObject_TryBinaryOperation { get; }
	public static MethodInfo DynamicObject_TryUnaryOperation { get; }
	public static MethodInfo DynamicObject_TryCreateInstance { get; }
	public static ConstructorInfo Nullable_Boolean_Ctor { get; }
	public static ConstructorInfo Decimal_Ctor_Int32 { get; }
	public static ConstructorInfo Decimal_Ctor_UInt32 { get; }
	public static ConstructorInfo Decimal_Ctor_Int64 { get; }
	public static ConstructorInfo Decimal_Ctor_UInt64 { get; }
	public static ConstructorInfo Decimal_Ctor_Int32_Int32_Int32_Bool_Byte { get; }
	public static FieldInfo Decimal_One { get; }
	public static FieldInfo Decimal_MinusOne { get; }
	public static FieldInfo Decimal_MinValue { get; }
	public static FieldInfo Decimal_MaxValue { get; }
	public static FieldInfo Decimal_Zero { get; }
	public static FieldInfo DateTime_MinValue { get; }
	public static MethodInfo MethodBase_GetMethodFromHandle_RuntimeMethodHandle { get; }
	public static MethodInfo MethodBase_GetMethodFromHandle_RuntimeMethodHandle_RuntimeTypeHandle { get; }
	public static MethodInfo MethodInfo_CreateDelegate_Type_Object { get; }
	public static MethodInfo String_op_Equality_String_String { get; }
	public static MethodInfo String_Equals_String_String { get; }
	public static MethodInfo DictionaryOfStringInt32_Add_String_Int32 { get; }
	public static ConstructorInfo DictionaryOfStringInt32_Ctor_Int32 { get; }
	public static MethodInfo Type_GetTypeFromHandle { get; }
	public static MethodInfo Object_GetType { get; }
	public static MethodInfo Decimal_op_Implicit_Byte { get; }
	public static MethodInfo Decimal_op_Implicit_SByte { get; }
	public static MethodInfo Decimal_op_Implicit_Int16 { get; }
	public static MethodInfo Decimal_op_Implicit_UInt16 { get; }
	public static MethodInfo Decimal_op_Implicit_Int32 { get; }
	public static MethodInfo Decimal_op_Implicit_UInt32 { get; }
	public static MethodInfo Decimal_op_Implicit_Int64 { get; }
	public static MethodInfo Decimal_op_Implicit_UInt64 { get; }
	public static MethodInfo Decimal_op_Implicit_Char { get; }
	public static MethodInfo Math_Pow_Double_Double { get; }

	// Methods

	// RVA: 0x1CD61D0 Offset: 0x1CD53D0 VA: 0x181CD61D0
	public static MethodInfo get_String_Format_String_ObjectArray() { }

	// RVA: 0x1CD5620 Offset: 0x1CD4820 VA: 0x181CD5620
	public static ConstructorInfo get_InvalidCastException_Ctor_String() { }

	// RVA: 0x1CD2EE0 Offset: 0x1CD20E0 VA: 0x181CD2EE0
	public static MethodInfo get_CallSiteOps_SetNotMatched() { }

	// RVA: 0x1CD2A60 Offset: 0x1CD1C60 VA: 0x181CD2A60
	public static MethodInfo get_CallSiteOps_CreateMatchmaker() { }

	// RVA: 0x1CD2BE0 Offset: 0x1CD1DE0 VA: 0x181CD2BE0
	public static MethodInfo get_CallSiteOps_GetMatch() { }

	// RVA: 0x1CD29A0 Offset: 0x1CD1BA0 VA: 0x181CD29A0
	public static MethodInfo get_CallSiteOps_ClearMatch() { }

	// RVA: 0x1CD2FA0 Offset: 0x1CD21A0 VA: 0x181CD2FA0
	public static MethodInfo get_CallSiteOps_UpdateRules() { }

	// RVA: 0x1CD2D60 Offset: 0x1CD1F60 VA: 0x181CD2D60
	public static MethodInfo get_CallSiteOps_GetRules() { }

	// RVA: 0x1CD2CA0 Offset: 0x1CD1EA0 VA: 0x181CD2CA0
	public static MethodInfo get_CallSiteOps_GetRuleCache() { }

	// RVA: 0x1CD2B20 Offset: 0x1CD1D20 VA: 0x181CD2B20
	public static MethodInfo get_CallSiteOps_GetCachedRules() { }

	// RVA: 0x1CD2820 Offset: 0x1CD1A20 VA: 0x181CD2820
	public static MethodInfo get_CallSiteOps_AddRule() { }

	// RVA: 0x1CD2E20 Offset: 0x1CD2020 VA: 0x181CD2E20
	public static MethodInfo get_CallSiteOps_MoveRule() { }

	// RVA: 0x1CD28E0 Offset: 0x1CD1AE0 VA: 0x181CD28E0
	public static MethodInfo get_CallSiteOps_Bind() { }

	// RVA: 0x1CD5160 Offset: 0x1CD4360 VA: 0x181CD5160
	public static MethodInfo get_DynamicObject_TryGetMember() { }

	// RVA: 0x1CD5490 Offset: 0x1CD4690 VA: 0x181CD5490
	public static MethodInfo get_DynamicObject_TrySetMember() { }

	// RVA: 0x1CD4FD0 Offset: 0x1CD41D0 VA: 0x181CD4FD0
	public static MethodInfo get_DynamicObject_TryDeleteMember() { }

	// RVA: 0x1CD5090 Offset: 0x1CD4290 VA: 0x181CD5090
	public static MethodInfo get_DynamicObject_TryGetIndex() { }

	// RVA: 0x1CD53C0 Offset: 0x1CD45C0 VA: 0x181CD53C0
	public static MethodInfo get_DynamicObject_TrySetIndex() { }

	// RVA: 0x1CD4F00 Offset: 0x1CD4100 VA: 0x181CD4F00
	public static MethodInfo get_DynamicObject_TryDeleteIndex() { }

	// RVA: 0x1CD4D60 Offset: 0x1CD3F60 VA: 0x181CD4D60
	public static MethodInfo get_DynamicObject_TryConvert() { }

	// RVA: 0x1CD52F0 Offset: 0x1CD44F0 VA: 0x181CD52F0
	public static MethodInfo get_DynamicObject_TryInvoke() { }

	// RVA: 0x1CD5220 Offset: 0x1CD4420 VA: 0x181CD5220
	public static MethodInfo get_DynamicObject_TryInvokeMember() { }

	// RVA: 0x1CD4C90 Offset: 0x1CD3E90 VA: 0x181CD4C90
	public static MethodInfo get_DynamicObject_TryBinaryOperation() { }

	// RVA: 0x1CD5550 Offset: 0x1CD4750 VA: 0x181CD5550
	public static MethodInfo get_DynamicObject_TryUnaryOperation() { }

	// RVA: 0x1CD4E30 Offset: 0x1CD4030 VA: 0x181CD4E30
	public static MethodInfo get_DynamicObject_TryCreateInstance() { }

	// RVA: 0x1CD5E00 Offset: 0x1CD5000 VA: 0x181CD5E00
	public static ConstructorInfo get_Nullable_Boolean_Ctor() { }

	// RVA: 0x1CD33D0 Offset: 0x1CD25D0 VA: 0x181CD33D0
	public static ConstructorInfo get_Decimal_Ctor_Int32() { }

	// RVA: 0x1CD3670 Offset: 0x1CD2870 VA: 0x181CD3670
	public static ConstructorInfo get_Decimal_Ctor_UInt32() { }

	// RVA: 0x1CD3520 Offset: 0x1CD2720 VA: 0x181CD3520
	public static ConstructorInfo get_Decimal_Ctor_Int64() { }

	// RVA: 0x1CD37C0 Offset: 0x1CD29C0 VA: 0x181CD37C0
	public static ConstructorInfo get_Decimal_Ctor_UInt64() { }

	// RVA: 0x1CD3130 Offset: 0x1CD2330 VA: 0x181CD3130
	public static ConstructorInfo get_Decimal_Ctor_Int32_Int32_Int32_Bool_Byte() { }

	// RVA: 0x1CD3B80 Offset: 0x1CD2D80 VA: 0x181CD3B80
	public static FieldInfo get_Decimal_One() { }

	// RVA: 0x1CD3AB0 Offset: 0x1CD2CB0 VA: 0x181CD3AB0
	public static FieldInfo get_Decimal_MinusOne() { }

	// RVA: 0x1CD39E0 Offset: 0x1CD2BE0 VA: 0x181CD39E0
	public static FieldInfo get_Decimal_MinValue() { }

	// RVA: 0x1CD3910 Offset: 0x1CD2B10 VA: 0x181CD3910
	public static FieldInfo get_Decimal_MaxValue() { }

	// RVA: 0x1CD3C50 Offset: 0x1CD2E50 VA: 0x181CD3C50
	public static FieldInfo get_Decimal_Zero() { }

	// RVA: 0x1CD3060 Offset: 0x1CD2260 VA: 0x181CD3060
	public static FieldInfo get_DateTime_MinValue() { }

	// RVA: 0x1CD5AE0 Offset: 0x1CD4CE0 VA: 0x181CD5AE0
	public static MethodInfo get_MethodBase_GetMethodFromHandle_RuntimeMethodHandle() { }

	// RVA: 0x1CD5920 Offset: 0x1CD4B20 VA: 0x181CD5920
	public static MethodInfo get_MethodBase_GetMethodFromHandle_RuntimeMethodHandle_RuntimeTypeHandle() { }

	// RVA: 0x1CD5C40 Offset: 0x1CD4E40 VA: 0x181CD5C40
	public static MethodInfo get_MethodInfo_CreateDelegate_Type_Object() { }

	// RVA: 0x1CD6380 Offset: 0x1CD5580 VA: 0x181CD6380
	public static MethodInfo get_String_op_Equality_String_String() { }

	// RVA: 0x1CD6020 Offset: 0x1CD5220 VA: 0x181CD6020
	public static MethodInfo get_String_Equals_String_String() { }

	// RVA: 0x1CD4980 Offset: 0x1CD3B80 VA: 0x181CD4980
	public static MethodInfo get_DictionaryOfStringInt32_Add_String_Int32() { }

	// RVA: 0x1CD4B40 Offset: 0x1CD3D40 VA: 0x181CD4B40
	public static ConstructorInfo get_DictionaryOfStringInt32_Ctor_Int32() { }

	// RVA: 0x1CD6530 Offset: 0x1CD5730 VA: 0x181CD6530
	public static MethodInfo get_Type_GetTypeFromHandle() { }

	// RVA: 0x1CD5F50 Offset: 0x1CD5150 VA: 0x181CD5F50
	public static MethodInfo get_Object_GetType() { }

	// RVA: 0x1CD3D20 Offset: 0x1CD2F20 VA: 0x181CD3D20
	public static MethodInfo get_Decimal_op_Implicit_Byte() { }

	// RVA: 0x1CD4400 Offset: 0x1CD3600 VA: 0x181CD4400
	public static MethodInfo get_Decimal_op_Implicit_SByte() { }

	// RVA: 0x1CD3FE0 Offset: 0x1CD31E0 VA: 0x181CD3FE0
	public static MethodInfo get_Decimal_op_Implicit_Int16() { }

	// RVA: 0x1CD4560 Offset: 0x1CD3760 VA: 0x181CD4560
	public static MethodInfo get_Decimal_op_Implicit_UInt16() { }

	// RVA: 0x1CD4140 Offset: 0x1CD3340 VA: 0x181CD4140
	public static MethodInfo get_Decimal_op_Implicit_Int32() { }

	// RVA: 0x1CD46C0 Offset: 0x1CD38C0 VA: 0x181CD46C0
	public static MethodInfo get_Decimal_op_Implicit_UInt32() { }

	// RVA: 0x1CD42A0 Offset: 0x1CD34A0 VA: 0x181CD42A0
	public static MethodInfo get_Decimal_op_Implicit_Int64() { }

	// RVA: 0x1CD4820 Offset: 0x1CD3A20 VA: 0x181CD4820
	public static MethodInfo get_Decimal_op_Implicit_UInt64() { }

	// RVA: 0x1CD3E80 Offset: 0x1CD3080 VA: 0x181CD3E80
	public static MethodInfo get_Decimal_op_Implicit_Char() { }

	// RVA: 0x1CD5770 Offset: 0x1CD4970 VA: 0x181CD5770
	public static MethodInfo get_Math_Pow_Double_Double() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.BinaryExpressionProxy))]
public class BinaryExpression : Expression // TypeDefIndex: 14674
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Right>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Left>k__BackingField; // 0x18

	// Properties
	public override bool CanReduce { get; }
	public Expression Right { get; }
	public Expression Left { get; }
	public MethodInfo Method { get; }
	public LambdaExpression Conversion { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	internal bool IsLiftedLogical { get; }
	internal bool IsReferenceComparison { get; }

	// Methods

	// RVA: 0x1CD03D0 Offset: 0x1CCF5D0 VA: 0x181CD03D0
	internal void .ctor(Expression left, Expression right) { }

	// RVA: 0x1CD2330 Offset: 0x1CD1530 VA: 0x181CD2330 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1CD0760 Offset: 0x1CCF960 VA: 0x181CD0760
	private static bool IsOpAssignment(ExpressionType op) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Expression get_Right() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Expression get_Left() { }

	// RVA: 0x577700 Offset: 0x576900 VA: 0x180577700
	public MethodInfo get_Method() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	internal virtual MethodInfo GetMethod() { }

	// RVA: 0x1CD1DE0 Offset: 0x1CD0FE0 VA: 0x181CD1DE0
	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right) { }

	// RVA: 0x1CD1D60 Offset: 0x1CD0F60 VA: 0x181CD1D60 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1CD0640 Offset: 0x1CCF840 VA: 0x181CD0640
	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op) { }

	// RVA: 0x1CD1C20 Offset: 0x1CD0E20 VA: 0x181CD1C20
	private Expression ReduceVariable() { }

	// RVA: 0x1CD0DD0 Offset: 0x1CCFFD0 VA: 0x181CD0DD0
	private Expression ReduceMember() { }

	// RVA: 0x1CD0770 Offset: 0x1CCF970 VA: 0x181CD0770
	private Expression ReduceIndex() { }

	// RVA: 0x7F6700 Offset: 0x7F5900 VA: 0x1807F6700
	public LambdaExpression get_Conversion() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 11
	internal virtual LambdaExpression GetConversion() { }

	// RVA: 0x1CD2570 Offset: 0x1CD1770 VA: 0x181CD2570
	public bool get_IsLifted() { }

	// RVA: 0x1CD24F0 Offset: 0x1CD16F0 VA: 0x181CD24F0
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1CD0450 Offset: 0x1CCF650 VA: 0x181CD0450 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1CD0480 Offset: 0x1CCF680 VA: 0x181CD0480
	internal static BinaryExpression Create(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CD2360 Offset: 0x1CD1560 VA: 0x181CD2360
	internal bool get_IsLiftedLogical() { }

	// RVA: 0x1CD2730 Offset: 0x1CD1930 VA: 0x181CD2730
	internal bool get_IsReferenceComparison() { }

	// RVA: 0x1CD12B0 Offset: 0x1CD04B0 VA: 0x181CD12B0
	internal Expression ReduceUserdefinedLifted() { }

	// RVA: 0x1CD2300 Offset: 0x1CD1500 VA: 0x181CD2300
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal sealed class LogicalBinaryExpression : BinaryExpression // TypeDefIndex: 14675
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x1CFB480 Offset: 0x1CFA680 VA: 0x181CFB480
	internal void .ctor(ExpressionType nodeType, Expression left, Expression right) { }

	// RVA: 0x1CFB500 Offset: 0x1CFA700 VA: 0x181CFB500 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 4
	public sealed override ExpressionType get_NodeType() { }
}

// Namespace: System.Linq.Expressions
internal class AssignBinaryExpression : BinaryExpression // TypeDefIndex: 14676
{
	// Properties
	internal virtual bool IsByRef { get; }
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x1CD03D0 Offset: 0x1CCF5D0 VA: 0x181CD03D0
	internal void .ctor(Expression left, Expression right) { }

	// RVA: 0x1CD0310 Offset: 0x1CCF510 VA: 0x181CD0310
	public static AssignBinaryExpression Make(Expression left, Expression right, bool byRef) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 12
	internal virtual bool get_IsByRef() { }

	// RVA: 0x1B57FC0 Offset: 0x1B571C0 VA: 0x181B57FC0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1CD0440 Offset: 0x1CCF640 VA: 0x181CD0440 Slot: 4
	public sealed override ExpressionType get_NodeType() { }
}

// Namespace: System.Linq.Expressions
internal class ByRefAssignBinaryExpression : AssignBinaryExpression // TypeDefIndex: 14677
{
	// Properties
	internal override bool IsByRef { get; }

	// Methods

	// RVA: 0x1CD03D0 Offset: 0x1CCF5D0 VA: 0x181CD03D0
	internal void .ctor(Expression left, Expression right) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 12
	internal override bool get_IsByRef() { }
}

// Namespace: System.Linq.Expressions
internal sealed class CoalesceConversionBinaryExpression : BinaryExpression // TypeDefIndex: 14678
{
	// Fields
	private readonly LambdaExpression _conversion; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1CD6600 Offset: 0x1CD5800 VA: 0x181CD6600
	internal void .ctor(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 11
	internal override LambdaExpression GetConversion() { }

	// RVA: 0x68EEF0 Offset: 0x68E0F0 VA: 0x18068EEF0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression // TypeDefIndex: 14679
{
	// Fields
	private readonly LambdaExpression _conversion; // 0x38

	// Methods

	// RVA: 0x1CFB600 Offset: 0x1CFA800 VA: 0x181CFB600
	internal void .ctor(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 11
	internal override LambdaExpression GetConversion() { }
}

// Namespace: System.Linq.Expressions
internal class SimpleBinaryExpression : BinaryExpression // TypeDefIndex: 14680
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x28

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1CFBAB0 Offset: 0x1CFACB0 VA: 0x181CFBAB0
	internal void .ctor(ExpressionType nodeType, Expression left, Expression right, Type type) { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal class MethodBinaryExpression : SimpleBinaryExpression // TypeDefIndex: 14681
{
	// Fields
	private readonly MethodInfo _method; // 0x30

	// Methods

	// RVA: 0x1CFB560 Offset: 0x1CFA760 VA: 0x181CFB560
	internal void .ctor(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 10
	internal override MethodInfo GetMethod() { }
}

// Namespace: 
internal class Expression.BinaryExpressionProxy // TypeDefIndex: 14682
{
	// Fields
	private readonly BinaryExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public LambdaExpression Conversion { get; }
	public string DebugView { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public Expression Left { get; }
	public MethodInfo Method { get; }
	public ExpressionType NodeType { get; }
	public Expression Right { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1CFBCB0 Offset: 0x1CFAEB0 VA: 0x181CFBCB0
	public void .ctor(BinaryExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD40 Offset: 0x1CFAF40 VA: 0x181CFBD40
	public LambdaExpression get_Conversion() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1CFBDA0 Offset: 0x1CFAFA0 VA: 0x181CFBDA0
	public bool get_IsLifted() { }

	// RVA: 0x1CFBD80 Offset: 0x1CFAF80 VA: 0x181CFBD80
	public bool get_IsLiftedToNull() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Expression get_Left() { }

	// RVA: 0x1CFBDC0 Offset: 0x1CFAFC0 VA: 0x181CFBDC0
	public MethodInfo get_Method() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public Expression get_Right() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.BlockExpressionProxy // TypeDefIndex: 14683
{
	// Fields
	private readonly BlockExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public ReadOnlyCollection<Expression> Expressions { get; }
	public ExpressionType NodeType { get; }
	public Expression Result { get; }
	public Type Type { get; }
	public ReadOnlyCollection<ParameterExpression> Variables { get; }

	// Methods

	// RVA: 0x1CFD6D0 Offset: 0x1CFC8D0 VA: 0x181CFD6D0
	public void .ctor(BlockExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1CFD730 Offset: 0x1CFC930 VA: 0x181CFD730
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CFD760 Offset: 0x1CFC960 VA: 0x181CFD760
	public Expression get_Result() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }

	// RVA: 0x1CFD7B0 Offset: 0x1CFC9B0 VA: 0x181CFD7B0
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }
}

// Namespace: 
internal class Expression.CatchBlockProxy // TypeDefIndex: 14684
{
	// Fields
	private readonly CatchBlock _node; // 0x10

	// Properties
	public Expression Body { get; }
	public Expression Filter { get; }
	public Type Test { get; }
	public ParameterExpression Variable { get; }

	// Methods

	// RVA: 0x1CFDFC0 Offset: 0x1CFD1C0 VA: 0x181CFDFC0
	public void .ctor(CatchBlock node) { }

	// RVA: 0x1BC9D40 Offset: 0x1BC8F40 VA: 0x181BC9D40
	public Expression get_Body() { }

	// RVA: 0x1683290 Offset: 0x1682490 VA: 0x181683290
	public Expression get_Filter() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Type get_Test() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public ParameterExpression get_Variable() { }
}

// Namespace: 
internal class Expression.ConditionalExpressionProxy // TypeDefIndex: 14685
{
	// Fields
	private readonly ConditionalExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public Expression IfFalse { get; }
	public Expression IfTrue { get; }
	public ExpressionType NodeType { get; }
	public Expression Test { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1CFE290 Offset: 0x1CFD490 VA: 0x181CFE290
	public void .ctor(ConditionalExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x16571B0 Offset: 0x16563B0 VA: 0x1816571B0
	public Expression get_IfFalse() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Expression get_IfTrue() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public Expression get_Test() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.ConstantExpressionProxy // TypeDefIndex: 14686
{
	// Fields
	private readonly ConstantExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1CFEAC0 Offset: 0x1CFDCC0 VA: 0x181CFEAC0
	public void .ctor(ConstantExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public object get_Value() { }
}

// Namespace: 
internal class Expression.DebugInfoExpressionProxy // TypeDefIndex: 14687
{
	// Fields
	private readonly DebugInfoExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public SymbolDocumentInfo Document { get; }
	public int EndColumn { get; }
	public int EndLine { get; }
	public bool IsClear { get; }
	public ExpressionType NodeType { get; }
	public int StartColumn { get; }
	public int StartLine { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1CFEC60 Offset: 0x1CFDE60 VA: 0x181CFEC60
	public void .ctor(DebugInfoExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public SymbolDocumentInfo get_Document() { }

	// RVA: 0x1CFD600 Offset: 0x1CFC800 VA: 0x181CFD600
	public int get_EndColumn() { }

	// RVA: 0x1CFECC0 Offset: 0x1CFDEC0 VA: 0x181CFECC0
	public int get_EndLine() { }

	// RVA: 0x1CFD730 Offset: 0x1CFC930 VA: 0x181CFD730
	public bool get_IsClear() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1657180 Offset: 0x1656380 VA: 0x181657180
	public int get_StartColumn() { }

	// RVA: 0x16571B0 Offset: 0x16563B0 VA: 0x1816571B0
	public int get_StartLine() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.DefaultExpressionProxy // TypeDefIndex: 14688
{
	// Fields
	private readonly DefaultExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D03F10 Offset: 0x1D03110 VA: 0x181D03F10
	public void .ctor(DefaultExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.GotoExpressionProxy // TypeDefIndex: 14689
{
	// Fields
	private readonly GotoExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public GotoExpressionKind Kind { get; }
	public ExpressionType NodeType { get; }
	public LabelTarget Target { get; }
	public Type Type { get; }
	public Expression Value { get; }

	// Methods

	// RVA: 0x1D12B00 Offset: 0x1D11D00 VA: 0x181D12B00
	public void .ctor(GotoExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1D12B60 Offset: 0x1D11D60 VA: 0x181D12B60
	public GotoExpressionKind get_Kind() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1BC9D40 Offset: 0x1BC8F40 VA: 0x181BC9D40
	public LabelTarget get_Target() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Expression get_Value() { }
}

// Namespace: 
internal class Expression.IndexExpressionProxy // TypeDefIndex: 14690
{
	// Fields
	private readonly IndexExpression _node; // 0x10

	// Properties
	public ReadOnlyCollection<Expression> Arguments { get; }
	public bool CanReduce { get; }
	public string DebugView { get; }
	public PropertyInfo Indexer { get; }
	public ExpressionType NodeType { get; }
	public Expression Object { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D12D40 Offset: 0x1D11F40 VA: 0x181D12D40
	public void .ctor(IndexExpression node) { }

	// RVA: 0x1D12DA0 Offset: 0x1D11FA0 VA: 0x181D12DA0
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1BC9D40 Offset: 0x1BC8F40 VA: 0x181BC9D40
	public PropertyInfo get_Indexer() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Expression get_Object() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.InvocationExpressionProxy // TypeDefIndex: 14691
{
	// Fields
	private readonly InvocationExpression _node; // 0x10

	// Properties
	public ReadOnlyCollection<Expression> Arguments { get; }
	public bool CanReduce { get; }
	public string DebugView { get; }
	public Expression Expression { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D14090 Offset: 0x1D13290 VA: 0x181D14090
	public void .ctor(InvocationExpression node) { }

	// RVA: 0x1CFECC0 Offset: 0x1CFDEC0 VA: 0x181CFECC0
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Expression get_Expression() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.LabelExpressionProxy // TypeDefIndex: 14692
{
	// Fields
	private readonly LabelExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public Expression DefaultValue { get; }
	public ExpressionType NodeType { get; }
	public LabelTarget Target { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D14430 Offset: 0x1D13630 VA: 0x181D14430
	public void .ctor(LabelExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Expression get_DefaultValue() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public LabelTarget get_Target() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.LambdaExpressionProxy // TypeDefIndex: 14693
{
	// Fields
	private readonly LambdaExpression _node; // 0x10

	// Properties
	public Expression Body { get; }
	public bool CanReduce { get; }
	public string DebugView { get; }
	public string Name { get; }
	public ExpressionType NodeType { get; }
	public ReadOnlyCollection<ParameterExpression> Parameters { get; }
	public Type ReturnType { get; }
	public bool TailCall { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D14670 Offset: 0x1D13870 VA: 0x181D14670
	public void .ctor(LambdaExpression node) { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public Expression get_Body() { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1CFD730 Offset: 0x1CFC930 VA: 0x181CFD730
	public string get_Name() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1657150 Offset: 0x1656350 VA: 0x181657150
	public ReadOnlyCollection<ParameterExpression> get_Parameters() { }

	// RVA: 0x1D146D0 Offset: 0x1D138D0 VA: 0x181D146D0
	public Type get_ReturnType() { }

	// RVA: 0x1CFD7B0 Offset: 0x1CFC9B0 VA: 0x181CFD7B0
	public bool get_TailCall() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.ListInitExpressionProxy // TypeDefIndex: 14694
{
	// Fields
	private readonly ListInitExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public ReadOnlyCollection<ElementInit> Initializers { get; }
	public NewExpression NewExpression { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D14A30 Offset: 0x1D13C30 VA: 0x181D14A30
	public void .ctor(ListInitExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public ReadOnlyCollection<ElementInit> get_Initializers() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public NewExpression get_NewExpression() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.LoopExpressionProxy // TypeDefIndex: 14695
{
	// Fields
	private readonly LoopExpression _node; // 0x10

	// Properties
	public Expression Body { get; }
	public LabelTarget BreakLabel { get; }
	public bool CanReduce { get; }
	public LabelTarget ContinueLabel { get; }
	public string DebugView { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D14C50 Offset: 0x1D13E50 VA: 0x181D14C50
	public void .ctor(LoopExpression node) { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public Expression get_Body() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public LabelTarget get_BreakLabel() { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1BC9D40 Offset: 0x1BC8F40 VA: 0x181BC9D40
	public LabelTarget get_ContinueLabel() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.MemberExpressionProxy // TypeDefIndex: 14696
{
	// Fields
	private readonly MemberExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public Expression Expression { get; }
	public MemberInfo Member { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D14FD0 Offset: 0x1D141D0 VA: 0x181D14FD0
	public void .ctor(MemberExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public Expression get_Expression() { }

	// RVA: 0x16571B0 Offset: 0x16563B0 VA: 0x1816571B0
	public MemberInfo get_Member() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.MemberInitExpressionProxy // TypeDefIndex: 14697
{
	// Fields
	private readonly MemberInitExpression _node; // 0x10

	// Properties
	public ReadOnlyCollection<MemberBinding> Bindings { get; }
	public bool CanReduce { get; }
	public string DebugView { get; }
	public NewExpression NewExpression { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D154E0 Offset: 0x1D146E0 VA: 0x181D154E0
	public void .ctor(MemberInitExpression node) { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public ReadOnlyCollection<MemberBinding> get_Bindings() { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public NewExpression get_NewExpression() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.MethodCallExpressionProxy // TypeDefIndex: 14698
{
	// Fields
	private readonly MethodCallExpression _node; // 0x10

	// Properties
	public ReadOnlyCollection<Expression> Arguments { get; }
	public bool CanReduce { get; }
	public string DebugView { get; }
	public MethodInfo Method { get; }
	public ExpressionType NodeType { get; }
	public Expression Object { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D16090 Offset: 0x1D15290 VA: 0x181D16090
	public void .ctor(MethodCallExpression node) { }

	// RVA: 0x1D160F0 Offset: 0x1D152F0 VA: 0x181D160F0
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public MethodInfo get_Method() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1D16110 Offset: 0x1D15310 VA: 0x181D16110
	public Expression get_Object() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.NewArrayExpressionProxy // TypeDefIndex: 14699
{
	// Fields
	private readonly NewArrayExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public ReadOnlyCollection<Expression> Expressions { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D16130 Offset: 0x1D15330 VA: 0x181D16130
	public void .ctor(NewArrayExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.NewExpressionProxy // TypeDefIndex: 14700
{
	// Fields
	private readonly NewExpression _node; // 0x10

	// Properties
	public ReadOnlyCollection<Expression> Arguments { get; }
	public bool CanReduce { get; }
	public ConstructorInfo Constructor { get; }
	public string DebugView { get; }
	public ReadOnlyCollection<MemberInfo> Members { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D16190 Offset: 0x1D15390 VA: 0x181D16190
	public void .ctor(NewExpression node) { }

	// RVA: 0x1D161F0 Offset: 0x1D153F0 VA: 0x181D161F0
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public ConstructorInfo get_Constructor() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1BC9D40 Offset: 0x1BC8F40 VA: 0x181BC9D40
	public ReadOnlyCollection<MemberInfo> get_Members() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.ParameterExpressionProxy // TypeDefIndex: 14701
{
	// Fields
	private readonly ParameterExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public bool IsByRef { get; }
	public string Name { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D16210 Offset: 0x1D15410 VA: 0x181D16210
	public void .ctor(ParameterExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1CFBDC0 Offset: 0x1CFAFC0 VA: 0x181CFBDC0
	public bool get_IsByRef() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public string get_Name() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.RuntimeVariablesExpressionProxy // TypeDefIndex: 14702
{
	// Fields
	private readonly RuntimeVariablesExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }
	public ReadOnlyCollection<ParameterExpression> Variables { get; }

	// Methods

	// RVA: 0x1D162A0 Offset: 0x1D154A0 VA: 0x181D162A0
	public void .ctor(RuntimeVariablesExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }
}

// Namespace: 
internal class Expression.SwitchCaseProxy // TypeDefIndex: 14703
{
	// Fields
	private readonly SwitchCase _node; // 0x10

	// Properties
	public Expression Body { get; }
	public ReadOnlyCollection<Expression> TestValues { get; }

	// Methods

	// RVA: 0x1D16C60 Offset: 0x1D15E60 VA: 0x181D16C60
	public void .ctor(SwitchCase node) { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Expression get_Body() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	public ReadOnlyCollection<Expression> get_TestValues() { }
}

// Namespace: 
internal class Expression.SwitchExpressionProxy // TypeDefIndex: 14704
{
	// Fields
	private readonly SwitchExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public ReadOnlyCollection<SwitchCase> Cases { get; }
	public MethodInfo Comparison { get; }
	public string DebugView { get; }
	public Expression DefaultBody { get; }
	public ExpressionType NodeType { get; }
	public Expression SwitchValue { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D16CC0 Offset: 0x1D15EC0 VA: 0x181D16CC0
	public void .ctor(SwitchExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1BC9D40 Offset: 0x1BC8F40 VA: 0x181BC9D40
	public ReadOnlyCollection<SwitchCase> get_Cases() { }

	// RVA: 0x1D16D20 Offset: 0x1D15F20 VA: 0x181D16D20
	public MethodInfo get_Comparison() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1683290 Offset: 0x1682490 VA: 0x181683290
	public Expression get_DefaultBody() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Expression get_SwitchValue() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.TryExpressionProxy // TypeDefIndex: 14705
{
	// Fields
	private readonly TryExpression _node; // 0x10

	// Properties
	public Expression Body { get; }
	public bool CanReduce { get; }
	public string DebugView { get; }
	public Expression Fault { get; }
	public Expression Finally { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D16D40 Offset: 0x1D15F40 VA: 0x181D16D40
	public void .ctor(TryExpression node) { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Expression get_Body() { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1D16D20 Offset: 0x1D15F20 VA: 0x181D16D20
	public Expression get_Fault() { }

	// RVA: 0x1683290 Offset: 0x1682490 VA: 0x181683290
	public Expression get_Finally() { }

	// RVA: 0x1BC9D40 Offset: 0x1BC8F40 VA: 0x181BC9D40
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
internal class Expression.TypeBinaryExpressionProxy // TypeDefIndex: 14706
{
	// Fields
	private readonly TypeBinaryExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public Expression Expression { get; }
	public ExpressionType NodeType { get; }
	public Type Type { get; }
	public Type TypeOperand { get; }

	// Methods

	// RVA: 0x1D16DA0 Offset: 0x1D15FA0 VA: 0x181D16DA0
	public void .ctor(TypeBinaryExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	public Expression get_Expression() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }

	// RVA: 0x1BC9D40 Offset: 0x1BC8F40 VA: 0x181BC9D40
	public Type get_TypeOperand() { }
}

// Namespace: 
internal class Expression.UnaryExpressionProxy // TypeDefIndex: 14707
{
	// Fields
	private readonly UnaryExpression _node; // 0x10

	// Properties
	public bool CanReduce { get; }
	public string DebugView { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public MethodInfo Method { get; }
	public ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D171C0 Offset: 0x1D163C0 VA: 0x181D171C0
	public void .ctor(UnaryExpression node) { }

	// RVA: 0x1CFBD10 Offset: 0x1CFAF10 VA: 0x181CFBD10
	public bool get_CanReduce() { }

	// RVA: 0x1CFBD60 Offset: 0x1CFAF60 VA: 0x181CFBD60
	public string get_DebugView() { }

	// RVA: 0x1D17240 Offset: 0x1D16440 VA: 0x181D17240
	public bool get_IsLifted() { }

	// RVA: 0x1D17220 Offset: 0x1D16420 VA: 0x181D17220
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1683290 Offset: 0x1682490 VA: 0x181683290
	public MethodInfo get_Method() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	public ExpressionType get_NodeType() { }

	// RVA: 0x1BC9D40 Offset: 0x1BC8F40 VA: 0x181BC9D40
	public Expression get_Operand() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680
	public Type get_Type() { }
}

// Namespace: 
private class Expression.ExtensionInfo // TypeDefIndex: 14708
{
	// Fields
	internal readonly ExpressionType NodeType; // 0x10
	internal readonly Type Type; // 0x18

	// Methods

	// RVA: 0x7B8500 Offset: 0x7B7700 VA: 0x1807B8500
	public void .ctor(ExpressionType nodeType, Type type) { }
}

// Namespace: 
private enum Expression.TryGetFuncActionArgsResult // TypeDefIndex: 14709
{
	// Fields
	public int value__; // 0x0
	public const Expression.TryGetFuncActionArgsResult Valid = 0;
	public const Expression.TryGetFuncActionArgsResult ArgumentNull = 1;
	public const Expression.TryGetFuncActionArgsResult ByRef = 2;
	public const Expression.TryGetFuncActionArgsResult PointerOrVoid = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Expression.<>c // TypeDefIndex: 14710
{
	// Fields
	public static readonly Expression.<>c <>9; // 0x0
	public static Func<ConstructorInfo, bool> <>9__358_0; // 0x8

	// Methods

	// RVA: 0x1D17160 Offset: 0x1D16360 VA: 0x181D17160
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D17100 Offset: 0x1D16300 VA: 0x181D17100
	internal bool <New>b__358_0(ConstructorInfo c) { }
}

// Namespace: System.Linq.Expressions
public abstract class Expression // TypeDefIndex: 14711
{
	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x8
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x10

	// Properties
	public virtual ExpressionType NodeType { get; }
	public virtual Type Type { get; }
	public virtual bool CanReduce { get; }
	private string DebugView { get; }

	// Methods

	// RVA: 0x1CD9890 Offset: 0x1CD8A90 VA: 0x181CD9890
	public static BinaryExpression Assign(Expression left, Expression right) { }

	// RVA: 0x1CE3D10 Offset: 0x1CE2F10 VA: 0x181CE3D10
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x1CE20F0 Offset: 0x1CE12F0 VA: 0x181CE20F0
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	// RVA: 0x1CE1E40 Offset: 0x1CE1040 VA: 0x181CE1E40
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x1CE3AB0 Offset: 0x1CE2CB0 VA: 0x181CE3AB0
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x1CE3800 Offset: 0x1CE2A00 VA: 0x181CE3800
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x1CE40E0 Offset: 0x1CE32E0 VA: 0x181CE40E0
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	// RVA: 0x1CE6E30 Offset: 0x1CE6030 VA: 0x181CE6E30
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	// RVA: 0x1CEFB80 Offset: 0x1CEED80 VA: 0x181CEFB80
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	// RVA: 0x1CF9170 Offset: 0x1CF8370 VA: 0x181CF9170
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	// RVA: 0x1CF8FB0 Offset: 0x1CF81B0 VA: 0x181CF8FB0
	private static void ValidateOperator(MethodInfo method) { }

	// RVA: 0x1CF8250 Offset: 0x1CF7450 VA: 0x181CF8250
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	// RVA: 0x1CE6EF0 Offset: 0x1CE60F0 VA: 0x181CE6EF0
	private static bool IsNullComparison(Expression left, Expression right) { }

	// RVA: 0x1CE7150 Offset: 0x1CE6350 VA: 0x181CE7150
	private static bool IsNullConstant(Expression e) { }

	// RVA: 0x1CFA090 Offset: 0x1CF9290 VA: 0x181CFA090
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	// RVA: 0x1CFAD00 Offset: 0x1CF9F00 VA: 0x181CFAD00
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	// RVA: 0x1CE74A0 Offset: 0x1CE66A0 VA: 0x181CE74A0
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	// RVA: 0x1CEA5B0 Offset: 0x1CE97B0 VA: 0x181CEA5B0
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right) { }

	// RVA: 0x1CEA520 Offset: 0x1CE9720 VA: 0x181CEA520
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1CE9BC0 Offset: 0x1CE8DC0 VA: 0x181CE9BC0
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CDFDD0 Offset: 0x1CDEFD0 VA: 0x181CDFDD0
	public static BinaryExpression Equal(Expression left, Expression right) { }

	// RVA: 0x1CDFE40 Offset: 0x1CDF040 VA: 0x181CDFE40
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1CF17E0 Offset: 0x1CF09E0 VA: 0x181CF17E0
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	// RVA: 0x1CEE9B0 Offset: 0x1CEDBB0 VA: 0x181CEE9B0
	public static BinaryExpression NotEqual(Expression left, Expression right) { }

	// RVA: 0x1CEEA20 Offset: 0x1CEDC20 VA: 0x181CEEA20
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1CF1970 Offset: 0x1CF0B70 VA: 0x181CF1970
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	// RVA: 0x1CE1610 Offset: 0x1CE0810 VA: 0x181CE1610
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x1CE4FE0 Offset: 0x1CE41E0 VA: 0x181CE4FE0
	public static BinaryExpression GreaterThan(Expression left, Expression right) { }

	// RVA: 0x1CE4EC0 Offset: 0x1CE40C0 VA: 0x181CE4EC0
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1CE8CD0 Offset: 0x1CE7ED0 VA: 0x181CE8CD0
	public static BinaryExpression LessThan(Expression left, Expression right) { }

	// RVA: 0x1CE8BB0 Offset: 0x1CE7DB0 VA: 0x181CE8BB0
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1CE4D30 Offset: 0x1CE3F30 VA: 0x181CE4D30
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right) { }

	// RVA: 0x1CE4DA0 Offset: 0x1CE3FA0 VA: 0x181CE4DA0
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1CE8A20 Offset: 0x1CE7C20 VA: 0x181CE8A20
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right) { }

	// RVA: 0x1CE8A90 Offset: 0x1CE7C90 VA: 0x181CE8A90
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1CE1320 Offset: 0x1CE0520 VA: 0x181CE1320
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x1CD8510 Offset: 0x1CD7710 VA: 0x181CD8510
	public static BinaryExpression AndAlso(Expression left, Expression right) { }

	// RVA: 0x1CD7FC0 Offset: 0x1CD71C0 VA: 0x181CD7FC0
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CEF870 Offset: 0x1CEEA70 VA: 0x181CEF870
	public static BinaryExpression OrElse(Expression left, Expression right) { }

	// RVA: 0x1CEF300 Offset: 0x1CEE500 VA: 0x181CEF300
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CDDD10 Offset: 0x1CDCF10 VA: 0x181CDDD10
	public static BinaryExpression Coalesce(Expression left, Expression right) { }

	// RVA: 0x1CDD660 Offset: 0x1CDC860 VA: 0x181CDD660
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x1CF6400 Offset: 0x1CF5600 VA: 0x181CF6400
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	// RVA: 0x1CD7F60 Offset: 0x1CD7160 VA: 0x181CD7F60
	public static BinaryExpression Add(Expression left, Expression right) { }

	// RVA: 0x1CD7D10 Offset: 0x1CD6F10 VA: 0x181CD7D10
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CD79F0 Offset: 0x1CD6BF0 VA: 0x181CD79F0
	public static BinaryExpression AddAssign(Expression left, Expression right) { }

	// RVA: 0x1CD7970 Offset: 0x1CD6B70 VA: 0x181CD7970
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CD76C0 Offset: 0x1CD68C0 VA: 0x181CD76C0
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CF8CE0 Offset: 0x1CF7EE0 VA: 0x181CF8CE0
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	// RVA: 0x1CD7620 Offset: 0x1CD6820 VA: 0x181CD7620
	public static BinaryExpression AddAssignChecked(Expression left, Expression right) { }

	// RVA: 0x1CD72F0 Offset: 0x1CD64F0 VA: 0x181CD72F0
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CD7370 Offset: 0x1CD6570 VA: 0x181CD7370
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CD7CB0 Offset: 0x1CD6EB0 VA: 0x181CD7CB0
	public static BinaryExpression AddChecked(Expression left, Expression right) { }

	// RVA: 0x1CD7A60 Offset: 0x1CD6C60 VA: 0x181CD7A60
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CF37A0 Offset: 0x1CF29A0 VA: 0x181CF37A0
	public static BinaryExpression Subtract(Expression left, Expression right) { }

	// RVA: 0x1CF3550 Offset: 0x1CF2750 VA: 0x181CF3550
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CF3230 Offset: 0x1CF2430 VA: 0x181CF3230
	public static BinaryExpression SubtractAssign(Expression left, Expression right) { }

	// RVA: 0x1CF31B0 Offset: 0x1CF23B0 VA: 0x181CF31B0
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CF2F00 Offset: 0x1CF2100 VA: 0x181CF2F00
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CF2DE0 Offset: 0x1CF1FE0 VA: 0x181CF2DE0
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right) { }

	// RVA: 0x1CF2E80 Offset: 0x1CF2080 VA: 0x181CF2E80
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CF2B30 Offset: 0x1CF1D30 VA: 0x181CF2B30
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CF34F0 Offset: 0x1CF26F0 VA: 0x181CF34F0
	public static BinaryExpression SubtractChecked(Expression left, Expression right) { }

	// RVA: 0x1CF32A0 Offset: 0x1CF24A0 VA: 0x181CF32A0
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CDF7A0 Offset: 0x1CDE9A0 VA: 0x181CDF7A0
	public static BinaryExpression Divide(Expression left, Expression right) { }

	// RVA: 0x1CDF800 Offset: 0x1CDEA00 VA: 0x181CDF800
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CDF6B0 Offset: 0x1CDE8B0 VA: 0x181CDF6B0
	public static BinaryExpression DivideAssign(Expression left, Expression right) { }

	// RVA: 0x1CDF720 Offset: 0x1CDE920 VA: 0x181CDF720
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CDF400 Offset: 0x1CDE600 VA: 0x181CDF400
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CEC3F0 Offset: 0x1CEB5F0 VA: 0x181CEC3F0
	public static BinaryExpression Modulo(Expression left, Expression right) { }

	// RVA: 0x1CEC450 Offset: 0x1CEB650 VA: 0x181CEC450
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CEC380 Offset: 0x1CEB580 VA: 0x181CEC380
	public static BinaryExpression ModuloAssign(Expression left, Expression right) { }

	// RVA: 0x1CEC300 Offset: 0x1CEB500 VA: 0x181CEC300
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CEC050 Offset: 0x1CEB250 VA: 0x181CEC050
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CED310 Offset: 0x1CEC510 VA: 0x181CED310
	public static BinaryExpression Multiply(Expression left, Expression right) { }

	// RVA: 0x1CED0C0 Offset: 0x1CEC2C0 VA: 0x181CED0C0
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CECA70 Offset: 0x1CEBC70 VA: 0x181CECA70
	public static BinaryExpression MultiplyAssign(Expression left, Expression right) { }

	// RVA: 0x1CECD90 Offset: 0x1CEBF90 VA: 0x181CECD90
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CECAE0 Offset: 0x1CEBCE0 VA: 0x181CECAE0
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CEC9D0 Offset: 0x1CEBBD0 VA: 0x181CEC9D0
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right) { }

	// RVA: 0x1CEC950 Offset: 0x1CEBB50 VA: 0x181CEC950
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CEC6A0 Offset: 0x1CEB8A0 VA: 0x181CEC6A0
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CED060 Offset: 0x1CEC260 VA: 0x181CED060
	public static BinaryExpression MultiplyChecked(Expression left, Expression right) { }

	// RVA: 0x1CECE10 Offset: 0x1CEC010 VA: 0x181CECE10
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CE71D0 Offset: 0x1CE63D0 VA: 0x181CE71D0
	private static bool IsSimpleShift(Type left, Type right) { }

	// RVA: 0x1CE36A0 Offset: 0x1CE28A0 VA: 0x181CE36A0
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	// RVA: 0x1CE8780 Offset: 0x1CE7980 VA: 0x181CE8780
	public static BinaryExpression LeftShift(Expression left, Expression right) { }

	// RVA: 0x1CE87E0 Offset: 0x1CE79E0 VA: 0x181CE87E0
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CE83F0 Offset: 0x1CE75F0 VA: 0x181CE83F0
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right) { }

	// RVA: 0x1CE8460 Offset: 0x1CE7660 VA: 0x181CE8460
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CE84E0 Offset: 0x1CE76E0 VA: 0x181CE84E0
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CF2640 Offset: 0x1CF1840 VA: 0x181CF2640
	public static BinaryExpression RightShift(Expression left, Expression right) { }

	// RVA: 0x1CF26A0 Offset: 0x1CF18A0 VA: 0x181CF26A0
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CF22B0 Offset: 0x1CF14B0 VA: 0x181CF22B0
	public static BinaryExpression RightShiftAssign(Expression left, Expression right) { }

	// RVA: 0x1CF25C0 Offset: 0x1CF17C0 VA: 0x181CF25C0
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CF2320 Offset: 0x1CF1520 VA: 0x181CF2320
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CD8B60 Offset: 0x1CD7D60 VA: 0x181CD8B60
	public static BinaryExpression And(Expression left, Expression right) { }

	// RVA: 0x1CD8910 Offset: 0x1CD7B10 VA: 0x181CD8910
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CD88A0 Offset: 0x1CD7AA0 VA: 0x181CD88A0
	public static BinaryExpression AndAssign(Expression left, Expression right) { }

	// RVA: 0x1CD8820 Offset: 0x1CD7A20 VA: 0x181CD8820
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CD8570 Offset: 0x1CD7770 VA: 0x181CD8570
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CEFB20 Offset: 0x1CEED20 VA: 0x181CEFB20
	public static BinaryExpression Or(Expression left, Expression right) { }

	// RVA: 0x1CEF8D0 Offset: 0x1CEEAD0 VA: 0x181CEF8D0
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CEF290 Offset: 0x1CEE490 VA: 0x181CEF290
	public static BinaryExpression OrAssign(Expression left, Expression right) { }

	// RVA: 0x1CEEF60 Offset: 0x1CEE160 VA: 0x181CEEF60
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CEEFE0 Offset: 0x1CEE1E0 VA: 0x181CEEFE0
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CE0550 Offset: 0x1CDF750 VA: 0x181CE0550
	public static BinaryExpression ExclusiveOr(Expression left, Expression right) { }

	// RVA: 0x1CE0300 Offset: 0x1CDF500 VA: 0x181CE0300
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CDFFE0 Offset: 0x1CDF1E0 VA: 0x181CDFFE0
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right) { }

	// RVA: 0x1CDFF60 Offset: 0x1CDF160 VA: 0x181CDFF60
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CE0050 Offset: 0x1CDF250 VA: 0x181CE0050
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CF01C0 Offset: 0x1CEF3C0 VA: 0x181CF01C0
	public static BinaryExpression Power(Expression left, Expression right) { }

	// RVA: 0x1CF0220 Offset: 0x1CEF420 VA: 0x181CF0220
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CEFFB0 Offset: 0x1CEF1B0 VA: 0x181CEFFB0
	public static BinaryExpression PowerAssign(Expression left, Expression right) { }

	// RVA: 0x1CEFF30 Offset: 0x1CEF130 VA: 0x181CEFF30
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1CF0020 Offset: 0x1CEF220 VA: 0x181CF0020
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1CD90D0 Offset: 0x1CD82D0 VA: 0x181CD90D0
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	// RVA: 0x1CDA870 Offset: 0x1CD9A70 VA: 0x181CDA870
	public static BlockExpression Block(Expression arg0, Expression arg1) { }

	// RVA: 0x1CDAB30 Offset: 0x1CD9D30 VA: 0x181CDAB30
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1CDA760 Offset: 0x1CD9960 VA: 0x181CDA760
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1CDAA00 Offset: 0x1CD9C00 VA: 0x181CDAA00
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1CDA980 Offset: 0x1CD9B80 VA: 0x181CDA980
	public static BlockExpression Block(Expression[] expressions) { }

	// RVA: 0x1CDAD80 Offset: 0x1CD9F80 VA: 0x181CDAD80
	public static BlockExpression Block(IEnumerable<Expression> expressions) { }

	// RVA: 0x1CDA670 Offset: 0x1CD9870 VA: 0x181CDA670
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	// RVA: 0x1CDA5D0 Offset: 0x1CD97D0 VA: 0x181CDA5D0
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	// RVA: 0x1CDAE10 Offset: 0x1CDA010 VA: 0x181CDAE10
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x1CDA910 Offset: 0x1CD9B10 VA: 0x181CDA910
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x1CDAC10 Offset: 0x1CD9E10 VA: 0x181CDAC10
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x1CDA3A0 Offset: 0x1CD95A0 VA: 0x181CDA3A0
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x1CD9E60 Offset: 0x1CD9060 VA: 0x181CD9E60
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x1CFA940 Offset: 0x1CF9B40 VA: 0x181CFA940
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	// RVA: 0x1CE2F90 Offset: 0x1CE2190 VA: 0x181CE2F90
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x1CDD170 Offset: 0x1CDC370 VA: 0x181CDD170
	public static CatchBlock Catch(Type type, Expression body) { }

	// RVA: 0x1CDD2D0 Offset: 0x1CDC4D0 VA: 0x181CDD2D0
	public static CatchBlock Catch(ParameterExpression variable, Expression body) { }

	// RVA: 0x1CDD450 Offset: 0x1CDC650 VA: 0x181CDD450
	public static CatchBlock Catch(Type type, Expression body, Expression filter) { }

	// RVA: 0x1CDD390 Offset: 0x1CDC590 VA: 0x181CDD390
	public static CatchBlock Catch(ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x1CEA630 Offset: 0x1CE9830 VA: 0x181CEA630
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x1CDE000 Offset: 0x1CDD200 VA: 0x181CDE000
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x1CDDD70 Offset: 0x1CDCF70 VA: 0x181CDDD70
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x1CE5110 Offset: 0x1CE4310 VA: 0x181CE5110
	public static ConditionalExpression IfThen(Expression test, Expression ifTrue) { }

	// RVA: 0x1CE5050 Offset: 0x1CE4250 VA: 0x181CE5050
	public static ConditionalExpression IfThenElse(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x1CDE470 Offset: 0x1CDD670 VA: 0x181CDE470
	public static ConstantExpression Constant(object value) { }

	// RVA: 0x1CDE220 Offset: 0x1CDD420 VA: 0x181CDE220
	public static ConstantExpression Constant(object value, Type type) { }

	// RVA: 0x1CDF030 Offset: 0x1CDE230 VA: 0x181CDF030
	public static DebugInfoExpression DebugInfo(SymbolDocumentInfo document, int startLine, int startColumn, int endLine, int endColumn) { }

	// RVA: 0x1CDD5E0 Offset: 0x1CDC7E0 VA: 0x181CDD5E0
	public static DebugInfoExpression ClearDebugInfo(SymbolDocumentInfo document) { }

	// RVA: 0x1CF9490 Offset: 0x1CF8690 VA: 0x181CF9490
	private static void ValidateSpan(int startLine, int startColumn, int endLine, int endColumn) { }

	// RVA: 0x1CDFD30 Offset: 0x1CDEF30 VA: 0x181CDFD30
	public static DefaultExpression Empty() { }

	// RVA: 0x1CDF350 Offset: 0x1CDE550 VA: 0x181CDF350
	public static DefaultExpression Default(Type type) { }

	// RVA: 0x1CDFAA0 Offset: 0x1CDECA0 VA: 0x181CDFAA0
	public static ElementInit ElementInit(MethodInfo addMethod, Expression[] arguments) { }

	// RVA: 0x1CDFC00 Offset: 0x1CDEE00 VA: 0x181CDFC00
	public static ElementInit ElementInit(MethodInfo addMethod, IEnumerable<Expression> arguments) { }

	// RVA: 0x1CF6600 Offset: 0x1CF5800 VA: 0x181CF6600
	private static void ValidateElementInitAddMethodInfo(MethodInfo addMethod, string paramName) { }

	[Obsolete("use a different constructor that does not take ExpressionType. Then override NodeType and Type properties to provide the values that would be specified to this constructor.")]
	// RVA: 0x1CFAFF0 Offset: 0x1CFA1F0 VA: 0x181CFAFF0
	protected void .ctor(ExpressionType nodeType, Type type) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x1CFB2A0 Offset: 0x1CFA4A0 VA: 0x181CFB2A0 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x1CFB390 Offset: 0x1CFA590 VA: 0x181CFB390 Slot: 5
	public virtual Type get_Type() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	public virtual bool get_CanReduce() { }

	// RVA: 0x1CF1790 Offset: 0x1CF0990 VA: 0x181CF1790 Slot: 7
	public virtual Expression Reduce() { }

	// RVA: 0x1CFAEE0 Offset: 0x1CFA0E0 VA: 0x181CFAEE0 Slot: 8
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) { }

	// RVA: 0x1CD72C0 Offset: 0x1CD64C0 VA: 0x181CD72C0 Slot: 9
	protected internal virtual Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1CF15E0 Offset: 0x1CF07E0 VA: 0x181CF15E0
	public Expression ReduceAndCheck() { }

	// RVA: 0x1CF1730 Offset: 0x1CF0930 VA: 0x181CF1730
	public Expression ReduceExtensions() { }

	// RVA: 0x1CF4D90 Offset: 0x1CF3F90 VA: 0x181CF4D90 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CFB160 Offset: 0x1CFA360 VA: 0x181CFB160
	private string get_DebugView() { }

	// RVA: 0x1CF1B00 Offset: 0x1CF0D00 VA: 0x181CF1B00
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	// RVA: 0x1CF1C20 Offset: 0x1CF0E20 VA: 0x181CF1C20
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	// RVA: 0x1CDFA60 Offset: 0x1CDEC60 VA: 0x181CDFA60
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, IEnumerable<Expression> arguments) { }

	// RVA: 0x1CDFA90 Offset: 0x1CDEC90 VA: 0x181CDFA90
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0) { }

	// RVA: 0x1CDFA80 Offset: 0x1CDEC80 VA: 0x181CDFA80
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1) { }

	// RVA: 0x1CDFA50 Offset: 0x1CDEC50 VA: 0x181CDFA50
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1CDFA70 Offset: 0x1CDEC70 VA: 0x181CDFA70
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1CDFA60 Offset: 0x1CDEC60 VA: 0x181CDFA60
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression[] arguments) { }

	// RVA: 0x1CEA960 Offset: 0x1CE9B60 VA: 0x181CEA960
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable<Expression> arguments) { }

	// RVA: 0x1CEA950 Offset: 0x1CE9B50 VA: 0x181CEA950
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0) { }

	// RVA: 0x1CEA8C0 Offset: 0x1CE9AC0 VA: 0x181CEA8C0
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1) { }

	// RVA: 0x1CEA8D0 Offset: 0x1CE9AD0 VA: 0x181CEA8D0
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1CEA970 Offset: 0x1CE9B70 VA: 0x181CEA970
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1CEA8E0 Offset: 0x1CE9AE0 VA: 0x181CEA8E0
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression[] arguments) { }

	// RVA: 0x1CDAE70 Offset: 0x1CDA070 VA: 0x181CDAE70
	public static GotoExpression Break(LabelTarget target) { }

	// RVA: 0x1CDAFA0 Offset: 0x1CDA1A0 VA: 0x181CDAFA0
	public static GotoExpression Break(LabelTarget target, Expression value) { }

	// RVA: 0x1CDB060 Offset: 0x1CDA260 VA: 0x181CDB060
	public static GotoExpression Break(LabelTarget target, Type type) { }

	// RVA: 0x1CDAF20 Offset: 0x1CDA120 VA: 0x181CDAF20
	public static GotoExpression Break(LabelTarget target, Expression value, Type type) { }

	// RVA: 0x1CDE4D0 Offset: 0x1CDD6D0 VA: 0x181CDE4D0
	public static GotoExpression Continue(LabelTarget target) { }

	// RVA: 0x1CDE580 Offset: 0x1CDD780 VA: 0x181CDE580
	public static GotoExpression Continue(LabelTarget target, Type type) { }

	// RVA: 0x1CF20C0 Offset: 0x1CF12C0 VA: 0x181CF20C0
	public static GotoExpression Return(LabelTarget target) { }

	// RVA: 0x1CF2050 Offset: 0x1CF1250 VA: 0x181CF2050
	public static GotoExpression Return(LabelTarget target, Type type) { }

	// RVA: 0x1CF21F0 Offset: 0x1CF13F0 VA: 0x181CF21F0
	public static GotoExpression Return(LabelTarget target, Expression value) { }

	// RVA: 0x1CF2170 Offset: 0x1CF1370 VA: 0x181CF2170
	public static GotoExpression Return(LabelTarget target, Expression value, Type type) { }

	// RVA: 0x1CE4C00 Offset: 0x1CE3E00 VA: 0x181CE4C00
	public static GotoExpression Goto(LabelTarget target) { }

	// RVA: 0x1CE4B90 Offset: 0x1CE3D90 VA: 0x181CE4B90
	public static GotoExpression Goto(LabelTarget target, Type type) { }

	// RVA: 0x1CE4AE0 Offset: 0x1CE3CE0 VA: 0x181CE4AE0
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	// RVA: 0x1CE4CB0 Offset: 0x1CE3EB0 VA: 0x181CE4CB0
	public static GotoExpression Goto(LabelTarget target, Expression value, Type type) { }

	// RVA: 0x1CEA980 Offset: 0x1CE9B80 VA: 0x181CEA980
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	// RVA: 0x1CF6C80 Offset: 0x1CF5E80 VA: 0x181CF6C80
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	// RVA: 0x1CF6B10 Offset: 0x1CF5D10 VA: 0x181CF6B10
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	// RVA: 0x1CEAB30 Offset: 0x1CE9D30 VA: 0x181CEAB30
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x1CD8C90 Offset: 0x1CD7E90 VA: 0x181CD8C90
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	// RVA: 0x1CD8CF0 Offset: 0x1CD7EF0 VA: 0x181CD8CF0
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x1CF0B40 Offset: 0x1CEFD40 VA: 0x181CF0B40
	public static IndexExpression Property(Expression instance, string propertyName, Expression[] arguments) { }

	// RVA: 0x1CE0A60 Offset: 0x1CDFC60 VA: 0x181CE0A60
	private static PropertyInfo FindInstanceProperty(Type type, string propertyName, Expression[] arguments) { }

	// RVA: 0x1CE11E0 Offset: 0x1CE03E0 VA: 0x181CE11E0
	private static string GetArgTypesString(Expression[] arguments) { }

	// RVA: 0x1CE0F00 Offset: 0x1CE0100 VA: 0x181CE0F00
	private static PropertyInfo FindProperty(Type type, string propertyName, Expression[] arguments, BindingFlags flags) { }

	// RVA: 0x1CE6A00 Offset: 0x1CE5C00 VA: 0x181CE6A00
	private static bool IsCompatible(PropertyInfo pi, Expression[] args) { }

	// RVA: 0x1CF1430 Offset: 0x1CF0630 VA: 0x181CF1430
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, Expression[] arguments) { }

	// RVA: 0x1CF1270 Offset: 0x1CF0470 VA: 0x181CF1270
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x1CEAA70 Offset: 0x1CE9C70 VA: 0x181CEAA70
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x1CF6F50 Offset: 0x1CF6150 VA: 0x181CF6F50
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x1CF5D70 Offset: 0x1CF4F70 VA: 0x181CF5D70
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x1CF5880 Offset: 0x1CF4A80 VA: 0x181CF5880
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x1CE5AF0 Offset: 0x1CE4CF0 VA: 0x181CE5AF0
	internal static InvocationExpression Invoke(Expression expression) { }

	// RVA: 0x1CE6320 Offset: 0x1CE5520 VA: 0x181CE6320
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	// RVA: 0x1CE5BF0 Offset: 0x1CE4DF0 VA: 0x181CE5BF0
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1) { }

	// RVA: 0x1CE5DE0 Offset: 0x1CE4FE0 VA: 0x181CE5DE0
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1CE6500 Offset: 0x1CE5700 VA: 0x181CE6500
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1CE6020 Offset: 0x1CE5220 VA: 0x181CE6020
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1CE64A0 Offset: 0x1CE56A0 VA: 0x181CE64A0
	public static InvocationExpression Invoke(Expression expression, Expression[] arguments) { }

	// RVA: 0x1CE5440 Offset: 0x1CE4640 VA: 0x181CE5440
	public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments) { }

	// RVA: 0x1CE1C20 Offset: 0x1CE0E20 VA: 0x181CE1C20
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	// RVA: 0x1CE7720 Offset: 0x1CE6920 VA: 0x181CE7720
	public static LabelExpression Label(LabelTarget target) { }

	// RVA: 0x1CE7650 Offset: 0x1CE6850 VA: 0x181CE7650
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x1CE7820 Offset: 0x1CE6A20 VA: 0x181CE7820
	public static LabelTarget Label() { }

	// RVA: 0x1CE75B0 Offset: 0x1CE67B0 VA: 0x181CE75B0
	public static LabelTarget Label(string name) { }

	// RVA: 0x1CE7970 Offset: 0x1CE6B70 VA: 0x181CE7970
	public static LabelTarget Label(Type type) { }

	// RVA: 0x1CE78B0 Offset: 0x1CE6AB0 VA: 0x181CE78B0
	public static LabelTarget Label(Type type, string name) { }

	// RVA: 0x1CDEB00 Offset: 0x1CDDD00 VA: 0x181CDEB00
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A6430 Offset: 0x9A5630 VA: 0x1809A6430
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A65C0 Offset: 0x9A57C0 VA: 0x1809A65C0
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A6870 Offset: 0x9A5A70 VA: 0x1809A6870
	|-Expression.Lambda<object>
	|
	|-RVA: 0x9A64B0 Offset: 0x9A56B0 VA: 0x1809A64B0
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A6530 Offset: 0x9A5730 VA: 0x1809A6530
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A67E0 Offset: 0x9A59E0 VA: 0x1809A67E0
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A6650 Offset: 0x9A5850 VA: 0x1809A6650
	|-Expression.Lambda<object>
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CE7EF0 Offset: 0x1CE70F0 VA: 0x181CE7EF0
	public static LambdaExpression Lambda(Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x1CE8110 Offset: 0x1CE7310 VA: 0x181CE8110
	public static LambdaExpression Lambda(Expression body, bool tailCall, ParameterExpression[] parameters) { }

	// RVA: 0x1CE7E80 Offset: 0x1CE7080 VA: 0x181CE7E80
	public static LambdaExpression Lambda(Expression body, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1CE7F90 Offset: 0x1CE7190 VA: 0x181CE7F90
	public static LambdaExpression Lambda(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1CE8090 Offset: 0x1CE7290 VA: 0x181CE8090
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x1CE7D60 Offset: 0x1CE6F60 VA: 0x181CE7D60
	public static LambdaExpression Lambda(Type delegateType, Expression body, bool tailCall, ParameterExpression[] parameters) { }

	// RVA: 0x1CE8010 Offset: 0x1CE7210 VA: 0x181CE8010
	public static LambdaExpression Lambda(Type delegateType, Expression body, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1CE7DF0 Offset: 0x1CE6FF0 VA: 0x181CE7DF0
	public static LambdaExpression Lambda(Type delegateType, Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1CE81C0 Offset: 0x1CE73C0 VA: 0x181CE81C0
	public static LambdaExpression Lambda(Expression body, string name, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1CE79C0 Offset: 0x1CE6BC0 VA: 0x181CE79C0
	public static LambdaExpression Lambda(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1CE8320 Offset: 0x1CE7520 VA: 0x181CE8320
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1CE8240 Offset: 0x1CE7440 VA: 0x181CE8240
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1CF75E0 Offset: 0x1CF67E0 VA: 0x181CF75E0
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	// RVA: 0x1CF9F50 Offset: 0x1CF9150 VA: 0x181CF9F50
	private static Expression.TryGetFuncActionArgsResult ValidateTryGetFuncActionArgs(Type[] typeArgs) { }

	// RVA: 0x1CE1AB0 Offset: 0x1CE0CB0 VA: 0x181CE1AB0
	public static Type GetFuncType(Type[] typeArgs) { }

	// RVA: 0x1CF5040 Offset: 0x1CF4240 VA: 0x181CF5040
	public static bool TryGetFuncType(Type[] typeArgs, out Type funcType) { }

	// RVA: 0x1CE1070 Offset: 0x1CE0270 VA: 0x181CE1070
	public static Type GetActionType(Type[] typeArgs) { }

	// RVA: 0x1CF4F70 Offset: 0x1CF4170 VA: 0x181CF4F70
	public static bool TryGetActionType(Type[] typeArgs, out Type actionType) { }

	// RVA: 0x1CE1570 Offset: 0x1CE0770 VA: 0x181CE1570
	public static Type GetDelegateType(Type[] typeArgs) { }

	// RVA: 0x1CE9850 Offset: 0x1CE8A50 VA: 0x181CE9850
	public static ListInitExpression ListInit(NewExpression newExpression, Expression[] initializers) { }

	// RVA: 0x1CE9600 Offset: 0x1CE8800 VA: 0x181CE9600
	public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<Expression> initializers) { }

	// RVA: 0x1CE9040 Offset: 0x1CE8240 VA: 0x181CE9040
	public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, Expression[] initializers) { }

	// RVA: 0x1CE90B0 Offset: 0x1CE82B0 VA: 0x181CE90B0
	public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, IEnumerable<Expression> initializers) { }

	// RVA: 0x1CE9480 Offset: 0x1CE8680 VA: 0x181CE9480
	public static ListInitExpression ListInit(NewExpression newExpression, ElementInit[] initializers) { }

	// RVA: 0x1CE94E0 Offset: 0x1CE86E0 VA: 0x181CE94E0
	public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<ElementInit> initializers) { }

	// RVA: 0x1CE98B0 Offset: 0x1CE8AB0 VA: 0x181CE98B0
	public static LoopExpression Loop(Expression body) { }

	// RVA: 0x1CE99B0 Offset: 0x1CE8BB0 VA: 0x181CE99B0
	public static LoopExpression Loop(Expression body, LabelTarget break) { }

	// RVA: 0x1CE9A90 Offset: 0x1CE8C90 VA: 0x181CE9A90
	public static LoopExpression Loop(Expression body, LabelTarget break, LabelTarget continue) { }

	// RVA: 0x1CD9D10 Offset: 0x1CD8F10 VA: 0x181CD9D10
	public static MemberAssignment Bind(MemberInfo member, Expression expression) { }

	// RVA: 0x1CD9AD0 Offset: 0x1CD8CD0 VA: 0x181CD9AD0
	public static MemberAssignment Bind(MethodInfo propertyAccessor, Expression expression) { }

	// RVA: 0x1CF9250 Offset: 0x1CF8450 VA: 0x181CF9250
	private static void ValidateSettableFieldOrPropertyMember(MemberInfo member, out Type memberType) { }

	// RVA: 0x1CE0860 Offset: 0x1CDFA60 VA: 0x181CE0860
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	// RVA: 0x1CE06D0 Offset: 0x1CDF8D0 VA: 0x181CE06D0
	public static MemberExpression Field(Expression expression, string fieldName) { }

	// RVA: 0x1CE05B0 Offset: 0x1CDF7B0 VA: 0x181CE05B0
	public static MemberExpression Field(Expression expression, Type type, string fieldName) { }

	// RVA: 0x1CF10F0 Offset: 0x1CF02F0 VA: 0x181CF10F0
	public static MemberExpression Property(Expression expression, string propertyName) { }

	// RVA: 0x1CF0A00 Offset: 0x1CEFC00 VA: 0x181CF0A00
	public static MemberExpression Property(Expression expression, Type type, string propertyName) { }

	// RVA: 0x1CF0D80 Offset: 0x1CEFF80 VA: 0x181CF0D80
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	// RVA: 0x1CF1320 Offset: 0x1CF0520 VA: 0x181CF1320
	public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor) { }

	// RVA: 0x1CE3430 Offset: 0x1CE2630 VA: 0x181CE3430
	private static PropertyInfo GetProperty(MethodInfo mi, string paramName, int index = -1) { }

	// RVA: 0x1CDD4D0 Offset: 0x1CDC6D0 VA: 0x181CDD4D0
	private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod) { }

	// RVA: 0x1CF07A0 Offset: 0x1CEF9A0 VA: 0x181CF07A0
	public static MemberExpression PropertyOrField(Expression expression, string propertyOrFieldName) { }

	// RVA: 0x1CEABE0 Offset: 0x1CE9DE0 VA: 0x181CEABE0
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	// RVA: 0x1CEBF00 Offset: 0x1CEB100 VA: 0x181CEBF00
	public static MemberInitExpression MemberInit(NewExpression newExpression, MemberBinding[] bindings) { }

	// RVA: 0x1CEBDE0 Offset: 0x1CEAFE0 VA: 0x181CEBDE0
	public static MemberInitExpression MemberInit(NewExpression newExpression, IEnumerable<MemberBinding> bindings) { }

	// RVA: 0x1CE8E50 Offset: 0x1CE8050 VA: 0x181CE8E50
	public static MemberListBinding ListBind(MemberInfo member, ElementInit[] initializers) { }

	// RVA: 0x1CE8D40 Offset: 0x1CE7F40 VA: 0x181CE8D40
	public static MemberListBinding ListBind(MemberInfo member, IEnumerable<ElementInit> initializers) { }

	// RVA: 0x1CE8EB0 Offset: 0x1CE80B0 VA: 0x181CE8EB0
	public static MemberListBinding ListBind(MethodInfo propertyAccessor, ElementInit[] initializers) { }

	// RVA: 0x1CE8F90 Offset: 0x1CE8190 VA: 0x181CE8F90
	public static MemberListBinding ListBind(MethodInfo propertyAccessor, IEnumerable<ElementInit> initializers) { }

	// RVA: 0x1CF7D40 Offset: 0x1CF6F40 VA: 0x181CF7D40
	private static void ValidateListInitArgs(Type listType, ReadOnlyCollection<ElementInit> initializers, string listTypeParamName) { }

	// RVA: 0x1CEBC70 Offset: 0x1CEAE70 VA: 0x181CEBC70
	public static MemberMemberBinding MemberBind(MemberInfo member, MemberBinding[] bindings) { }

	// RVA: 0x1CEBCD0 Offset: 0x1CEAED0 VA: 0x181CEBCD0
	public static MemberMemberBinding MemberBind(MemberInfo member, IEnumerable<MemberBinding> bindings) { }

	// RVA: 0x1CEBBB0 Offset: 0x1CEADB0 VA: 0x181CEBBB0
	public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, MemberBinding[] bindings) { }

	// RVA: 0x1CEBB20 Offset: 0x1CEAD20 VA: 0x181CEBB20
	public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, IEnumerable<MemberBinding> bindings) { }

	// RVA: 0x1CF68B0 Offset: 0x1CF5AB0 VA: 0x181CF68B0
	private static void ValidateGettableFieldOrPropertyMember(MemberInfo member, out Type memberType) { }

	// RVA: 0x1CF7EE0 Offset: 0x1CF70E0 VA: 0x181CF7EE0
	private static void ValidateMemberInitArgs(Type type, ReadOnlyCollection<MemberBinding> bindings) { }

	// RVA: 0x1CDC670 Offset: 0x1CDB870 VA: 0x181CDC670
	internal static MethodCallExpression Call(MethodInfo method) { }

	// RVA: 0x1CDC9F0 Offset: 0x1CDBBF0 VA: 0x181CDC9F0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	// RVA: 0x1CDCB40 Offset: 0x1CDBD40 VA: 0x181CDCB40
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x1CDBA10 Offset: 0x1CDAC10 VA: 0x181CDBA10
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1CDC730 Offset: 0x1CDB930 VA: 0x181CDC730
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1CDBE70 Offset: 0x1CDB070 VA: 0x181CDBE70
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1CDCD10 Offset: 0x1CDBF10 VA: 0x181CDCD10
	public static MethodCallExpression Call(MethodInfo method, Expression[] arguments) { }

	// RVA: 0x1CDD110 Offset: 0x1CDC310 VA: 0x181CDD110
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x1CDC560 Offset: 0x1CDB760 VA: 0x181CDC560
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	// RVA: 0x1CDCDA0 Offset: 0x1CDBFA0 VA: 0x181CDCDA0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	// RVA: 0x1CDCE10 Offset: 0x1CDC010 VA: 0x181CDCE10
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	// RVA: 0x1CDBC50 Offset: 0x1CDAE50 VA: 0x181CDBC50
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x1CDC2D0 Offset: 0x1CDB4D0 VA: 0x181CDC2D0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1CDCFB0 Offset: 0x1CDC1B0 VA: 0x181CDCFB0
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x1CDC1A0 Offset: 0x1CDB3A0 VA: 0x181CDC1A0
	public static MethodCallExpression Call(Type type, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x1CDB0D0 Offset: 0x1CDA2D0 VA: 0x181CDB0D0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x1CF8080 Offset: 0x1CF7280 VA: 0x181CF8080
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	// RVA: 0x1CF9680 Offset: 0x1CF8880 VA: 0x181CF9680
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	// RVA: 0x1CF6360 Offset: 0x1CF5560 VA: 0x181CF6360
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	// RVA: 0x1CF6350 Offset: 0x1CF5550 VA: 0x181CF6350
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x1CE3420 Offset: 0x1CE2620 VA: 0x181CE3420
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: 0x1CF6340 Offset: 0x1CF5540 VA: 0x181CF6340
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x1CF8CA0 Offset: 0x1CF7EA0 VA: 0x181CF8CA0
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	// RVA: 0x1CF5110 Offset: 0x1CF4310 VA: 0x181CF5110
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x1CE0BE0 Offset: 0x1CDFDE0 VA: 0x181CE0BE0
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	// RVA: 0x1CE67A0 Offset: 0x1CE59A0 VA: 0x181CE67A0
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	// RVA: 0x1CD8BC0 Offset: 0x1CD7DC0 VA: 0x181CD8BC0
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	// RVA: 0x1CD9610 Offset: 0x1CD8810 VA: 0x181CD9610
	public static MethodCallExpression ArrayIndex(Expression array, Expression[] indexes) { }

	// RVA: 0x1CD9300 Offset: 0x1CD8500 VA: 0x181CD9300
	public static MethodCallExpression ArrayIndex(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x1CEDF60 Offset: 0x1CED160 VA: 0x181CEDF60
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	// RVA: 0x1CEDB00 Offset: 0x1CECD00 VA: 0x181CEDB00
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	// RVA: 0x1CED7D0 Offset: 0x1CEC9D0 VA: 0x181CED7D0
	public static NewArrayExpression NewArrayBounds(Type type, Expression[] bounds) { }

	// RVA: 0x1CED830 Offset: 0x1CECA30 VA: 0x181CED830
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	// RVA: 0x1CEE420 Offset: 0x1CED620 VA: 0x181CEE420
	public static NewExpression New(ConstructorInfo constructor) { }

	// RVA: 0x1CEE1B0 Offset: 0x1CED3B0 VA: 0x181CEE1B0
	public static NewExpression New(ConstructorInfo constructor, Expression[] arguments) { }

	// RVA: 0x1CEE7E0 Offset: 0x1CED9E0 VA: 0x181CEE7E0
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments) { }

	// RVA: 0x1CEDFC0 Offset: 0x1CED1C0 VA: 0x181CEDFC0
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members) { }

	// RVA: 0x1CEE210 Offset: 0x1CED410 VA: 0x181CEE210
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, MemberInfo[] members) { }

	// RVA: 0x1CEE470 Offset: 0x1CED670 VA: 0x181CEE470
	public static NewExpression New(Type type) { }

	// RVA: 0x1CF82E0 Offset: 0x1CF74E0 VA: 0x181CF82E0
	private static void ValidateNewArgs(ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments, ref ReadOnlyCollection<MemberInfo> members) { }

	// RVA: 0x1CF5FE0 Offset: 0x1CF51E0 VA: 0x181CF5FE0
	private static void ValidateAnonymousTypeMember(ref MemberInfo member, out Type memberType, string paramName, int index) { }

	// RVA: 0x1CF65B0 Offset: 0x1CF57B0 VA: 0x181CF65B0
	private static void ValidateConstructor(ConstructorInfo constructor, string paramName) { }

	// RVA: 0x1CEFC30 Offset: 0x1CEEE30 VA: 0x181CEFC30
	public static ParameterExpression Parameter(Type type) { }

	// RVA: 0x1CFAC00 Offset: 0x1CF9E00 VA: 0x181CFAC00
	public static ParameterExpression Variable(Type type) { }

	// RVA: 0x1CEFD00 Offset: 0x1CEEF00 VA: 0x181CEFD00
	public static ParameterExpression Parameter(Type type, string name) { }

	// RVA: 0x1CFAC90 Offset: 0x1CF9E90 VA: 0x181CFAC90
	public static ParameterExpression Variable(Type type, string name) { }

	// RVA: 0x1CFAAF0 Offset: 0x1CF9CF0 VA: 0x181CFAAF0
	private static void Validate(Type type, bool allowByRef) { }

	// RVA: 0x1CF29F0 Offset: 0x1CF1BF0 VA: 0x181CF29F0
	public static RuntimeVariablesExpression RuntimeVariables(ParameterExpression[] variables) { }

	// RVA: 0x1CF28E0 Offset: 0x1CF1AE0 VA: 0x181CF28E0
	public static RuntimeVariablesExpression RuntimeVariables(IEnumerable<ParameterExpression> variables) { }

	// RVA: 0x1CF3800 Offset: 0x1CF2A00 VA: 0x181CF3800
	public static SwitchCase SwitchCase(Expression body, Expression[] testValues) { }

	// RVA: 0x1CF3940 Offset: 0x1CF2B40 VA: 0x181CF3940
	public static SwitchCase SwitchCase(Expression body, IEnumerable<Expression> testValues) { }

	// RVA: 0x1CF3A50 Offset: 0x1CF2C50 VA: 0x181CF3A50
	public static SwitchExpression Switch(Expression switchValue, SwitchCase[] cases) { }

	// RVA: 0x1CF3C00 Offset: 0x1CF2E00 VA: 0x181CF3C00
	public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, SwitchCase[] cases) { }

	// RVA: 0x1CF3AF0 Offset: 0x1CF2CF0 VA: 0x181CF3AF0
	public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, MethodInfo comparison, SwitchCase[] cases) { }

	// RVA: 0x1CF4940 Offset: 0x1CF3B40 VA: 0x181CF4940
	public static SwitchExpression Switch(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, SwitchCase[] cases) { }

	// RVA: 0x1CF3B70 Offset: 0x1CF2D70 VA: 0x181CF3B70
	public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, MethodInfo comparison, IEnumerable<SwitchCase> cases) { }

	// RVA: 0x1CF3C80 Offset: 0x1CF2E80 VA: 0x181CF3C80
	public static SwitchExpression Switch(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, IEnumerable<SwitchCase> cases) { }

	// RVA: 0x1CF9780 Offset: 0x1CF8980 VA: 0x181CF9780
	private static void ValidateSwitchCaseType(Expression case, bool customType, Type resultType, string parameterName) { }

	// RVA: 0x1CF4B40 Offset: 0x1CF3D40 VA: 0x181CF4B40
	public static SymbolDocumentInfo SymbolDocument(string fileName) { }

	// RVA: 0x1CF49C0 Offset: 0x1CF3BC0 VA: 0x181CF49C0
	public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language) { }

	// RVA: 0x1CF4A30 Offset: 0x1CF3C30 VA: 0x181CF4A30
	public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language, Guid languageVendor) { }

	// RVA: 0x1CF4AB0 Offset: 0x1CF3CB0 VA: 0x181CF4AB0
	public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language, Guid languageVendor, Guid documentType) { }

	// RVA: 0x1CF4E90 Offset: 0x1CF4090 VA: 0x181CF4E90
	public static TryExpression TryFault(Expression body, Expression fault) { }

	// RVA: 0x1CF4F00 Offset: 0x1CF4100 VA: 0x181CF4F00
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	// RVA: 0x1CF4E20 Offset: 0x1CF4020 VA: 0x181CF4E20
	public static TryExpression TryCatch(Expression body, CatchBlock[] handlers) { }

	// RVA: 0x1CF4DA0 Offset: 0x1CF3FA0 VA: 0x181CF4DA0
	public static TryExpression TryCatchFinally(Expression body, Expression finally, CatchBlock[] handlers) { }

	// RVA: 0x1CEB030 Offset: 0x1CEA230 VA: 0x181CEB030
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	// RVA: 0x1CF9910 Offset: 0x1CF8B10 VA: 0x181CF9910
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	// RVA: 0x1CF5380 Offset: 0x1CF4580 VA: 0x181CF5380
	public static TypeBinaryExpression TypeIs(Expression expression, Type type) { }

	// RVA: 0x1CF5280 Offset: 0x1CF4480 VA: 0x181CF5280
	public static TypeBinaryExpression TypeEqual(Expression expression, Type type) { }

	// RVA: 0x1CEB280 Offset: 0x1CEA480 VA: 0x181CEB280
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type) { }

	// RVA: 0x1CEB300 Offset: 0x1CEA500 VA: 0x181CEB300
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	// RVA: 0x1CE4600 Offset: 0x1CE3800 VA: 0x181CE4600
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x1CE47A0 Offset: 0x1CE39A0 VA: 0x181CE47A0
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x1CE2B60 Offset: 0x1CE1D60 VA: 0x181CE2B60
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	// RVA: 0x1CE4390 Offset: 0x1CE3590 VA: 0x181CE4390
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x1CE4500 Offset: 0x1CE3700 VA: 0x181CE4500
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x1CE2750 Offset: 0x1CE1950 VA: 0x181CE2750
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	// RVA: 0x1CED5A0 Offset: 0x1CEC7A0 VA: 0x181CED5A0
	public static UnaryExpression Negate(Expression expression) { }

	// RVA: 0x1CED5F0 Offset: 0x1CEC7F0 VA: 0x181CED5F0
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	// RVA: 0x1CF5620 Offset: 0x1CF4820 VA: 0x181CF5620
	public static UnaryExpression UnaryPlus(Expression expression) { }

	// RVA: 0x1CF5480 Offset: 0x1CF4680 VA: 0x181CF5480
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	// RVA: 0x1CED550 Offset: 0x1CEC750 VA: 0x181CED550
	public static UnaryExpression NegateChecked(Expression expression) { }

	// RVA: 0x1CED370 Offset: 0x1CEC570 VA: 0x181CED370
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	// RVA: 0x1CEEB40 Offset: 0x1CEDD40 VA: 0x181CEEB40
	public static UnaryExpression Not(Expression expression) { }

	// RVA: 0x1CEEB90 Offset: 0x1CEDD90 VA: 0x181CEEB90
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	// RVA: 0x1CE6DE0 Offset: 0x1CE5FE0 VA: 0x181CE6DE0
	public static UnaryExpression IsFalse(Expression expression) { }

	// RVA: 0x1CE6C40 Offset: 0x1CE5E40 VA: 0x181CE6C40
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	// RVA: 0x1CE7450 Offset: 0x1CE6650 VA: 0x181CE7450
	public static UnaryExpression IsTrue(Expression expression) { }

	// RVA: 0x1CE72B0 Offset: 0x1CE64B0 VA: 0x181CE72B0
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	// RVA: 0x1CEED70 Offset: 0x1CEDF70 VA: 0x181CEED70
	public static UnaryExpression OnesComplement(Expression expression) { }

	// RVA: 0x1CEEDC0 Offset: 0x1CEDFC0 VA: 0x181CEEDC0
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	// RVA: 0x1CF5120 Offset: 0x1CF4320 VA: 0x181CF5120
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	// RVA: 0x1CF5670 Offset: 0x1CF4870 VA: 0x181CF5670
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	// RVA: 0x1CDEAA0 Offset: 0x1CDDCA0 VA: 0x181CDEAA0
	public static UnaryExpression Convert(Expression expression, Type type) { }

	// RVA: 0x1CDE890 Offset: 0x1CDDA90 VA: 0x181CDE890
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x1CDE5F0 Offset: 0x1CDD7F0 VA: 0x181CDE5F0
	public static UnaryExpression ConvertChecked(Expression expression, Type type) { }

	// RVA: 0x1CDE650 Offset: 0x1CDD850 VA: 0x181CDE650
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x1CD9670 Offset: 0x1CD8870 VA: 0x181CD9670
	public static UnaryExpression ArrayLength(Expression array) { }

	// RVA: 0x1CF14A0 Offset: 0x1CF06A0 VA: 0x181CF14A0
	public static UnaryExpression Quote(Expression expression) { }

	// RVA: 0x1CF1F90 Offset: 0x1CF1190 VA: 0x181CF1F90
	public static UnaryExpression Rethrow() { }

	// RVA: 0x1CF1F40 Offset: 0x1CF1140 VA: 0x181CF1F40
	public static UnaryExpression Rethrow(Type type) { }

	// RVA: 0x1CF4BA0 Offset: 0x1CF3DA0 VA: 0x181CF4BA0
	public static UnaryExpression Throw(Expression value) { }

	// RVA: 0x1CF4C40 Offset: 0x1CF3E40 VA: 0x181CF4C40
	public static UnaryExpression Throw(Expression value, Type type) { }

	// RVA: 0x1CE5250 Offset: 0x1CE4450 VA: 0x181CE5250
	public static UnaryExpression Increment(Expression expression) { }

	// RVA: 0x1CE52A0 Offset: 0x1CE44A0 VA: 0x181CE52A0
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	// RVA: 0x1CDF300 Offset: 0x1CDE500 VA: 0x181CDF300
	public static UnaryExpression Decrement(Expression expression) { }

	// RVA: 0x1CDF160 Offset: 0x1CDE360 VA: 0x181CDF160
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	// RVA: 0x1CF0740 Offset: 0x1CEF940 VA: 0x181CF0740
	public static UnaryExpression PreIncrementAssign(Expression expression) { }

	// RVA: 0x1CF06E0 Offset: 0x1CEF8E0 VA: 0x181CF06E0
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x1CF0620 Offset: 0x1CEF820 VA: 0x181CF0620
	public static UnaryExpression PreDecrementAssign(Expression expression) { }

	// RVA: 0x1CF0680 Offset: 0x1CEF880 VA: 0x181CF0680
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x1CEFE70 Offset: 0x1CEF070 VA: 0x181CEFE70
	public static UnaryExpression PostIncrementAssign(Expression expression) { }

	// RVA: 0x1CEFED0 Offset: 0x1CEF0D0 VA: 0x181CEFED0
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x1CEFDB0 Offset: 0x1CEEFB0 VA: 0x181CEFDB0
	public static UnaryExpression PostDecrementAssign(Expression expression) { }

	// RVA: 0x1CEFE10 Offset: 0x1CEF010 VA: 0x181CEFE10
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x1CEAD90 Offset: 0x1CE9F90 VA: 0x181CEAD90
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	// RVA: 0x1CFAF70 Offset: 0x1CFA170 VA: 0x181CFAF70
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.BlockExpressionProxy))]
public class BlockExpression : Expression // TypeDefIndex: 14712
{
	// Properties
	public ReadOnlyCollection<Expression> Expressions { get; }
	public ReadOnlyCollection<ParameterExpression> Variables { get; }
	public Expression Result { get; }
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	[ExcludeFromCodeCoverage]
	internal virtual int ExpressionCount { get; }

	// Methods

	// RVA: 0x19B4EE0 Offset: 0x19B40E0 VA: 0x1819B4EE0
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x727AE0 Offset: 0x726CE0 VA: 0x180727AE0
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

	// RVA: 0x1CFDCF0 Offset: 0x1CFCEF0 VA: 0x181CFDCF0
	public Expression get_Result() { }

	// RVA: 0x1CFDC60 Offset: 0x1CFCE60 VA: 0x181CFDC60
	internal void .ctor() { }

	// RVA: 0x1CFD7E0 Offset: 0x1CFC9E0 VA: 0x181CFD7E0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1CFDCE0 Offset: 0x1CFCEE0 VA: 0x181CFDCE0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1CFDD30 Offset: 0x1CFCF30 VA: 0x181CFDD30 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x1CFDAF0 Offset: 0x1CFCCF0 VA: 0x181CFDAF0
	public BlockExpression Update(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x1CFDAA0 Offset: 0x1CFCCA0 VA: 0x181CFDAA0 Slot: 10
	internal virtual bool SameVariables(ICollection<ParameterExpression> variables) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1CFDA70 Offset: 0x1CFCC70 VA: 0x181CFDA70 Slot: 11
	internal virtual bool SameExpressions(ICollection<Expression> expressions) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1CFD810 Offset: 0x1CFCA10 VA: 0x181CFD810 Slot: 12
	internal virtual Expression GetExpression(int index) { }

	// RVA: 0x1CFDCB0 Offset: 0x1CFCEB0 VA: 0x181CFDCB0 Slot: 13
	internal virtual int get_ExpressionCount() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1CFD840 Offset: 0x1CFCA40 VA: 0x181CFD840 Slot: 14
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1CFD870 Offset: 0x1CFCA70 VA: 0x181CFD870 Slot: 15
	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1CFDA40 Offset: 0x1CFCC40 VA: 0x181CFDA40 Slot: 16
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

	// RVA: 0x1CFD8C0 Offset: 0x1CFCAC0 VA: 0x181CFD8C0
	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) { }
}

// Namespace: System.Linq.Expressions
internal sealed class Block2 : BlockExpression // TypeDefIndex: 14713
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1CFC180 Offset: 0x1CFB380 VA: 0x181CFC180
	internal void .ctor(Expression arg0, Expression arg1) { }

	// RVA: 0x1CFBDE0 Offset: 0x1CFAFE0 VA: 0x181CFBDE0 Slot: 12
	internal override Expression GetExpression(int index) { }

	// RVA: 0x1CFBF40 Offset: 0x1CFB140 VA: 0x181CFBF40 Slot: 11
	internal override bool SameExpressions(ICollection<Expression> expressions) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 13
	internal override int get_ExpressionCount() { }

	// RVA: 0x1CFBE70 Offset: 0x1CFB070 VA: 0x181CFBE70 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1CFBE80 Offset: 0x1CFB080 VA: 0x181CFBE80 Slot: 16
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class Block3 : BlockExpression // TypeDefIndex: 14714
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1CFC610 Offset: 0x1CFB810 VA: 0x181CFC610
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1CFC380 Offset: 0x1CFB580 VA: 0x181CFC380 Slot: 11
	internal override bool SameExpressions(ICollection<Expression> expressions) { }

	// RVA: 0x1CFC1F0 Offset: 0x1CFB3F0 VA: 0x181CFC1F0 Slot: 12
	internal override Expression GetExpression(int index) { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 13
	internal override int get_ExpressionCount() { }

	// RVA: 0x1CFBE70 Offset: 0x1CFB070 VA: 0x181CFBE70 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1CFC2A0 Offset: 0x1CFB4A0 VA: 0x181CFC2A0 Slot: 16
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class Block4 : BlockExpression // TypeDefIndex: 14715
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20
	private readonly Expression _arg3; // 0x28

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1CFCB20 Offset: 0x1CFBD20 VA: 0x181CFCB20
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1CFC850 Offset: 0x1CFBA50 VA: 0x181CFC850 Slot: 11
	internal override bool SameExpressions(ICollection<Expression> expressions) { }

	// RVA: 0x1CFC690 Offset: 0x1CFB890 VA: 0x181CFC690 Slot: 12
	internal override Expression GetExpression(int index) { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 13
	internal override int get_ExpressionCount() { }

	// RVA: 0x1CFBE70 Offset: 0x1CFB070 VA: 0x181CFBE70 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1CFC750 Offset: 0x1CFB950 VA: 0x181CFC750 Slot: 16
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class Block5 : BlockExpression // TypeDefIndex: 14716
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20
	private readonly Expression _arg3; // 0x28
	private readonly Expression _arg4; // 0x30

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1CFD0C0 Offset: 0x1CFC2C0 VA: 0x181CFD0C0
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1CFCBB0 Offset: 0x1CFBDB0 VA: 0x181CFCBB0 Slot: 12
	internal override Expression GetExpression(int index) { }

	// RVA: 0x1CFCDA0 Offset: 0x1CFBFA0 VA: 0x181CFCDA0 Slot: 11
	internal override bool SameExpressions(ICollection<Expression> expressions) { }

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 13
	internal override int get_ExpressionCount() { }

	// RVA: 0x1CFBE70 Offset: 0x1CFB070 VA: 0x181CFBE70 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1CFCC80 Offset: 0x1CFBE80 VA: 0x181CFCC80 Slot: 16
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal class BlockN : BlockExpression // TypeDefIndex: 14717
{
	// Fields
	private IReadOnlyList<Expression> _expressions; // 0x10

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1CFDF10 Offset: 0x1CFD110 VA: 0x181CFDF10
	internal void .ctor(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x1CFDEC0 Offset: 0x1CFD0C0 VA: 0x181CFDEC0 Slot: 11
	internal override bool SameExpressions(ICollection<Expression> expressions) { }

	// RVA: 0x1CFDD90 Offset: 0x1CFCF90 VA: 0x181CFDD90 Slot: 12
	internal override Expression GetExpression(int index) { }

	// RVA: 0x1CFDF70 Offset: 0x1CFD170 VA: 0x181CFDF70 Slot: 13
	internal override int get_ExpressionCount() { }

	// RVA: 0x1CFDDF0 Offset: 0x1CFCFF0 VA: 0x181CFDDF0 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1CFDE30 Offset: 0x1CFD030 VA: 0x181CFDE30 Slot: 16
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal class ScopeExpression : BlockExpression // TypeDefIndex: 14718
{
	// Fields
	private IReadOnlyList<ParameterExpression> _variables; // 0x10

	// Properties
	protected IReadOnlyList<ParameterExpression> VariablesList { get; }

	// Methods

	// RVA: 0x1CFDF10 Offset: 0x1CFD110 VA: 0x181CFDF10
	internal void .ctor(IReadOnlyList<ParameterExpression> variables) { }

	// RVA: 0x1D167B0 Offset: 0x1D159B0 VA: 0x181D167B0 Slot: 10
	internal override bool SameVariables(ICollection<ParameterExpression> variables) { }

	// RVA: 0x1D166E0 Offset: 0x1D158E0 VA: 0x181D166E0 Slot: 15
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	protected IReadOnlyList<ParameterExpression> get_VariablesList() { }

	// RVA: 0x1D16720 Offset: 0x1D15920 VA: 0x181D16720
	internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables) { }
}

// Namespace: System.Linq.Expressions
internal sealed class Scope1 : ScopeExpression // TypeDefIndex: 14719
{
	// Fields
	private object _body; // 0x18

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1CFC180 Offset: 0x1CFB380 VA: 0x181CFC180
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, Expression body) { }

	// RVA: 0x1CFC180 Offset: 0x1CFB380 VA: 0x181CFC180
	private void .ctor(IReadOnlyList<ParameterExpression> variables, object body) { }

	// RVA: 0x1D164F0 Offset: 0x1D156F0 VA: 0x181D164F0 Slot: 11
	internal override bool SameExpressions(ICollection<Expression> expressions) { }

	// RVA: 0x1D16300 Offset: 0x1D15500 VA: 0x181D16300 Slot: 12
	internal override Expression GetExpression(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 13
	internal override int get_ExpressionCount() { }

	// RVA: 0x1D16380 Offset: 0x1D15580 VA: 0x181D16380 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1D16390 Offset: 0x1D15590 VA: 0x181D16390 Slot: 16
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal class ScopeN : ScopeExpression // TypeDefIndex: 14720
{
	// Fields
	private IReadOnlyList<Expression> _body; // 0x18

	// Properties
	protected IReadOnlyList<Expression> Body { get; }
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1CFC180 Offset: 0x1CFB380 VA: 0x181CFC180
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) { }

	// RVA: 0x1D169F0 Offset: 0x1D15BF0 VA: 0x181D169F0 Slot: 11
	internal override bool SameExpressions(ICollection<Expression> expressions) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	protected IReadOnlyList<Expression> get_Body() { }

	// RVA: 0x1D16800 Offset: 0x1D15A00 VA: 0x181D16800 Slot: 12
	internal override Expression GetExpression(int index) { }

	// RVA: 0x1D16A40 Offset: 0x1D15C40 VA: 0x181D16A40 Slot: 13
	internal override int get_ExpressionCount() { }

	// RVA: 0x1D16860 Offset: 0x1D15A60 VA: 0x181D16860 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1D168A0 Offset: 0x1D15AA0 VA: 0x181D168A0 Slot: 16
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class ScopeWithType : ScopeN // TypeDefIndex: 14721
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1CFC610 Offset: 0x1CFB810 VA: 0x181CFC610
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> expressions, Type type) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1D16A90 Offset: 0x1D15C90 VA: 0x181D16A90 Slot: 16
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BlockExpressionList.<GetEnumerator>d__18 : IEnumerator<Expression>, IDisposable, IEnumerator // TypeDefIndex: 14722
{
	// Fields
	private int <>1__state; // 0x10
	private Expression <>2__current; // 0x18
	public BlockExpressionList <>4__this; // 0x20
	private int <i>5__2; // 0x28

	// Properties
	private Expression System.Collections.Generic.IEnumerator<System.Linq.Expressions.Expression>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1D16FD0 Offset: 0x1D161D0 VA: 0x181D16FD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private Expression System.Collections.Generic.IEnumerator<System.Linq.Expressions.Expression>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1D170C0 Offset: 0x1D162C0 VA: 0x181D170C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: System.Linq.Expressions
[DefaultMember("Item")]
internal class BlockExpressionList : IList<Expression>, ICollection<Expression>, IEnumerable<Expression>, IEnumerable // TypeDefIndex: 14723
{
	// Fields
	private readonly BlockExpression _block; // 0x10
	private readonly Expression _arg0; // 0x18

	// Properties
	public Expression Item { get; set; }
	public int Count { get; }
	[ExcludeFromCodeCoverage]
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(BlockExpression provider, Expression arg0) { }

	// RVA: 0x1CFD4C0 Offset: 0x1CFC6C0 VA: 0x181CFD4C0 Slot: 6
	public int IndexOf(Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1CFD570 Offset: 0x1CFC770 VA: 0x181CFD570 Slot: 7
	public void Insert(int index, Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1CFD5A0 Offset: 0x1CFC7A0 VA: 0x181CFD5A0 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x1CFD660 Offset: 0x1CFC860 VA: 0x181CFD660 Slot: 4
	public Expression get_Item(int index) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1CFD6A0 Offset: 0x1CFC8A0 VA: 0x181CFD6A0 Slot: 5
	public void set_Item(int index, Expression value) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1CFD150 Offset: 0x1CFC350 VA: 0x181CFD150 Slot: 11
	public void Add(Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1CFD180 Offset: 0x1CFC380 VA: 0x181CFD180 Slot: 12
	public void Clear() { }

	// RVA: 0x1CFD1B0 Offset: 0x1CFC3B0 VA: 0x181CFD1B0 Slot: 13
	public bool Contains(Expression item) { }

	// RVA: 0x1CFD260 Offset: 0x1CFC460 VA: 0x181CFD260 Slot: 14
	public void CopyTo(Expression[] array, int index) { }

	// RVA: 0x1CFD600 Offset: 0x1CFC800 VA: 0x181CFD600 Slot: 9
	public int get_Count() { }

	// RVA: 0x1CFD630 Offset: 0x1CFC830 VA: 0x181CFD630 Slot: 10
	public bool get_IsReadOnly() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1CFD5D0 Offset: 0x1CFC7D0 VA: 0x181CFD5D0 Slot: 15
	public bool Remove(Expression item) { }

	[IteratorStateMachine(typeof(BlockExpressionList.<GetEnumerator>d__18))]
	// RVA: 0x1CFD460 Offset: 0x1CFC660 VA: 0x181CFD460 Slot: 16
	public IEnumerator<Expression> GetEnumerator() { }

	// RVA: 0x1CFD460 Offset: 0x1CFC660 VA: 0x181CFD460 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.CatchBlockProxy))]
public sealed class CatchBlock // TypeDefIndex: 14724
{
	// Fields
	[CompilerGenerated]
	private readonly ParameterExpression <Variable>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <Test>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Expression <Filter>k__BackingField; // 0x28

	// Properties
	public ParameterExpression Variable { get; }
	public Type Test { get; }
	public Expression Body { get; }
	public Expression Filter { get; }

	// Methods

	// RVA: 0x1CFE1C0 Offset: 0x1CFD3C0 VA: 0x181CFE1C0
	internal void .ctor(Type test, ParameterExpression variable, Expression body, Expression filter) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ParameterExpression get_Variable() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Type get_Test() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Expression get_Filter() { }

	// RVA: 0x1CFE020 Offset: 0x1CFD220 VA: 0x181CFE020 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CFE0F0 Offset: 0x1CFD2F0 VA: 0x181CFE0F0
	public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body) { }

	// RVA: 0x1CFE190 Offset: 0x1CFD390 VA: 0x181CFE190
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
[Extension]
internal static class ArrayBuilderExtensions // TypeDefIndex: 14725
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ToReadOnly<T>(ArrayBuilder<T> builder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x917650 Offset: 0x916850 VA: 0x180917650
	|-ArrayBuilderExtensions.ToReadOnly<object>
	|
	|-RVA: 0x9175C0 Offset: 0x9167C0 VA: 0x1809175C0
	|-ArrayBuilderExtensions.ToReadOnly<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Linq.Expressions
internal enum AnalyzeTypeIsResult // TypeDefIndex: 14726
{
	// Fields
	public int value__; // 0x0
	public const AnalyzeTypeIsResult KnownFalse = 0;
	public const AnalyzeTypeIsResult KnownTrue = 1;
	public const AnalyzeTypeIsResult KnownAssignable = 2;
	public const AnalyzeTypeIsResult Unknown = 3;
}

// Namespace: System.Linq.Expressions
internal static class ConstantCheck // TypeDefIndex: 14727
{
	// Methods

	// RVA: 0x1CFE970 Offset: 0x1CFDB70 VA: 0x181CFE970
	internal static bool IsNull(Expression e) { }

	// RVA: 0x1CFE710 Offset: 0x1CFD910 VA: 0x181CFE710
	internal static AnalyzeTypeIsResult AnalyzeTypeIs(TypeBinaryExpression typeIs) { }

	// RVA: 0x1CFE740 Offset: 0x1CFD940 VA: 0x181CFE740
	private static AnalyzeTypeIsResult AnalyzeTypeIs(Expression operand, Type testType) { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ConditionalExpressionProxy))]
public class ConditionalExpression : Expression // TypeDefIndex: 14728
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Test>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <IfTrue>k__BackingField; // 0x18

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	public Expression Test { get; }
	public Expression IfTrue { get; }
	public Expression IfFalse { get; }

	// Methods

	// RVA: 0x1CFE670 Offset: 0x1CFD870 VA: 0x181CFE670
	internal void .ctor(Expression test, Expression ifTrue) { }

	// RVA: 0x1CFE380 Offset: 0x1CFD580 VA: 0x181CFE380
	internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1B57FC0 Offset: 0x1B571C0 VA: 0x181B57FC0 Slot: 5
	public override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Expression get_Test() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Expression get_IfTrue() { }

	// RVA: 0x577700 Offset: 0x576900 VA: 0x180577700
	public Expression get_IfFalse() { }

	// RVA: 0x1CFE320 Offset: 0x1CFD520 VA: 0x181CFE320 Slot: 10
	internal virtual Expression GetFalse() { }

	// RVA: 0x1CFE2F0 Offset: 0x1CFD4F0 VA: 0x181CFE2F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1CFE5A0 Offset: 0x1CFD7A0 VA: 0x181CFE5A0
	public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x1CFE6E0 Offset: 0x1CFD8E0 VA: 0x181CFE6E0
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal class FullConditionalExpression : ConditionalExpression // TypeDefIndex: 14729
{
	// Fields
	private readonly Expression _false; // 0x20

	// Methods

	// RVA: 0x1D12A80 Offset: 0x1D11C80 VA: 0x181D12A80
	internal void .ctor(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 10
	internal override Expression GetFalse() { }
}

// Namespace: System.Linq.Expressions
internal sealed class FullConditionalExpressionWithType : FullConditionalExpression // TypeDefIndex: 14730
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1D12A50 Offset: 0x1D11C50 VA: 0x181D12A50
	internal void .ctor(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ConstantExpressionProxy))]
public class ConstantExpression : Expression // TypeDefIndex: 14731
{
	// Fields
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x10

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1CFEB50 Offset: 0x1CFDD50 VA: 0x181CFEB50
	internal void .ctor(object value) { }

	// RVA: 0x1CFEBE0 Offset: 0x1CFDDE0 VA: 0x181CFEBE0 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x563540 Offset: 0x562740 VA: 0x180563540 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public object get_Value() { }

	// RVA: 0x1CFEB20 Offset: 0x1CFDD20 VA: 0x181CFEB20 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1CFEBB0 Offset: 0x1CFDDB0 VA: 0x181CFEBB0
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal class TypedConstantExpression : ConstantExpression // TypeDefIndex: 14732
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1D16E00 Offset: 0x1D16000 VA: 0x181D16E00
	internal void .ctor(object value, Type type) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.DebugInfoExpressionProxy))]
public class DebugInfoExpression : Expression // TypeDefIndex: 14733
{
	// Fields
	[CompilerGenerated]
	private readonly SymbolDocumentInfo <Document>k__BackingField; // 0x10

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	[ExcludeFromCodeCoverage]
	public virtual int StartLine { get; }
	[ExcludeFromCodeCoverage]
	public virtual int StartColumn { get; }
	[ExcludeFromCodeCoverage]
	public virtual int EndLine { get; }
	[ExcludeFromCodeCoverage]
	public virtual int EndColumn { get; }
	public SymbolDocumentInfo Document { get; }
	[ExcludeFromCodeCoverage]
	public virtual bool IsClear { get; }

	// Methods

	// RVA: 0x1CFE220 Offset: 0x1CFD420 VA: 0x181CFE220
	internal void .ctor(SymbolDocumentInfo document) { }

	// RVA: 0x1CFEE40 Offset: 0x1CFE040 VA: 0x181CFEE40 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0xAA0100 Offset: 0xA9F300 VA: 0x180AA0100 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1CFEE10 Offset: 0x1CFE010 VA: 0x181CFEE10 Slot: 10
	public virtual int get_StartLine() { }

	// RVA: 0x1CFEDE0 Offset: 0x1CFDFE0 VA: 0x181CFEDE0 Slot: 11
	public virtual int get_StartColumn() { }

	// RVA: 0x1CFED80 Offset: 0x1CFDF80 VA: 0x181CFED80 Slot: 12
	public virtual int get_EndLine() { }

	// RVA: 0x1CFED50 Offset: 0x1CFDF50 VA: 0x181CFED50 Slot: 13
	public virtual int get_EndColumn() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public SymbolDocumentInfo get_Document() { }

	// RVA: 0x1CFEDB0 Offset: 0x1CFDFB0 VA: 0x181CFEDB0 Slot: 14
	public virtual bool get_IsClear() { }

	// RVA: 0x1CFECF0 Offset: 0x1CFDEF0 VA: 0x181CFECF0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1CFED20 Offset: 0x1CFDF20 VA: 0x181CFED20
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal sealed class SpanDebugInfoExpression : DebugInfoExpression // TypeDefIndex: 14734
{
	// Fields
	private readonly int _startLine; // 0x18
	private readonly int _startColumn; // 0x1C
	private readonly int _endLine; // 0x20
	private readonly int _endColumn; // 0x24

	// Properties
	public override int StartLine { get; }
	public override int StartColumn { get; }
	public override int EndLine { get; }
	public override int EndColumn { get; }
	public override bool IsClear { get; }

	// Methods

	// RVA: 0x1D16BD0 Offset: 0x1D15DD0 VA: 0x181D16BD0
	internal void .ctor(SymbolDocumentInfo document, int startLine, int startColumn, int endLine, int endColumn) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 10
	public override int get_StartLine() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 11
	public override int get_StartColumn() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 12
	public override int get_EndLine() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90 Slot: 13
	public override int get_EndColumn() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 14
	public override bool get_IsClear() { }

	// RVA: 0x1CFECF0 Offset: 0x1CFDEF0 VA: 0x181CFECF0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
}

// Namespace: System.Linq.Expressions
internal sealed class ClearDebugInfoExpression : DebugInfoExpression // TypeDefIndex: 14735
{
	// Properties
	public override bool IsClear { get; }
	public override int StartLine { get; }
	public override int StartColumn { get; }
	public override int EndLine { get; }
	public override int EndColumn { get; }

	// Methods

	// RVA: 0x1CFE220 Offset: 0x1CFD420 VA: 0x181CFE220
	internal void .ctor(SymbolDocumentInfo document) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 14
	public override bool get_IsClear() { }

	// RVA: 0x1CFE280 Offset: 0x1CFD480 VA: 0x181CFE280 Slot: 10
	public override int get_StartLine() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 11
	public override int get_StartColumn() { }

	// RVA: 0x1CFE280 Offset: 0x1CFD480 VA: 0x181CFE280 Slot: 12
	public override int get_EndLine() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 13
	public override int get_EndColumn() { }
}

// Namespace: 
[Flags]
private enum DebugViewWriter.Flow // TypeDefIndex: 14736
{
	// Fields
	public int value__; // 0x0
	public const DebugViewWriter.Flow None = 0;
	public const DebugViewWriter.Flow Space = 1;
	public const DebugViewWriter.Flow NewLine = 2;
	public const DebugViewWriter.Flow Break = 32768;
}

// Namespace: System.Linq.Expressions
internal sealed class DebugViewWriter : ExpressionVisitor // TypeDefIndex: 14737
{
	// Fields
	private const int Tab = 4;
	private const int MaxColumn = 120;
	private readonly TextWriter _out; // 0x10
	private int _column; // 0x18
	private readonly Stack<int> _stack; // 0x20
	private int _delta; // 0x28
	private DebugViewWriter.Flow _flow; // 0x2C
	private Queue<LambdaExpression> _lambdas; // 0x30
	private Dictionary<LambdaExpression, int> _lambdaIds; // 0x38
	private Dictionary<ParameterExpression, int> _paramIds; // 0x40
	private Dictionary<LabelTarget, int> _labelIds; // 0x48

	// Properties
	private int Base { get; }
	private int Delta { get; }
	private int Depth { get; }

	// Methods

	// RVA: 0x1D03DB0 Offset: 0x1D02FB0 VA: 0x181D03DB0
	private void .ctor(TextWriter file) { }

	// RVA: 0x1D03E30 Offset: 0x1D03030 VA: 0x181D03E30
	private int get_Base() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	private int get_Delta() { }

	// RVA: 0x1D03EA0 Offset: 0x1D030A0 VA: 0x181D03EA0
	private int get_Depth() { }

	// RVA: 0x1CFF8C0 Offset: 0x1CFEAC0 VA: 0x181CFF8C0
	private void Indent() { }

	// RVA: 0x1CFEF80 Offset: 0x1CFE180 VA: 0x181CFEF80
	private void Dedent() { }

	// RVA: 0x1CFFBC0 Offset: 0x1CFEDC0 VA: 0x181CFFBC0
	private void NewLine() { }

	// RVA: -1 Offset: -1
	private static int GetId<T>(T e, ref Dictionary<T, int> ids) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x956A50 Offset: 0x955C50 VA: 0x180956A50
	|-DebugViewWriter.GetId<object>
	|
	|-RVA: 0x9567F0 Offset: 0x9559F0 VA: 0x1809567F0
	|-DebugViewWriter.GetId<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CFF5B0 Offset: 0x1CFE7B0 VA: 0x181CFF5B0
	private int GetLambdaId(LambdaExpression le) { }

	// RVA: 0x1CFF870 Offset: 0x1CFEA70 VA: 0x181CFF870
	private int GetParamId(ParameterExpression p) { }

	// RVA: 0x1CFF4A0 Offset: 0x1CFE6A0 VA: 0x181CFF4A0
	private int GetLabelTargetId(LabelTarget target) { }

	// RVA: 0x1D03B70 Offset: 0x1D02D70 VA: 0x181D03B70
	internal static void WriteTo(Expression node, TextWriter writer) { }

	// RVA: 0x1D03A20 Offset: 0x1D02C20 VA: 0x181D03A20
	private void WriteTo(Expression node) { }

	// RVA: 0x1CFFD00 Offset: 0x1CFEF00 VA: 0x181CFFD00
	private void Out(string s) { }

	// RVA: 0x1CFFD20 Offset: 0x1CFEF20 VA: 0x181CFFD20
	private void Out(DebugViewWriter.Flow before, string s) { }

	// RVA: 0x1CFFF10 Offset: 0x1CFF110 VA: 0x181CFFF10
	private void Out(string s, DebugViewWriter.Flow after) { }

	// RVA: 0x1CFFD40 Offset: 0x1CFEF40 VA: 0x181CFFD40
	private void Out(DebugViewWriter.Flow before, string s, DebugViewWriter.Flow after) { }

	// RVA: 0x1D039E0 Offset: 0x1D02BE0 VA: 0x181D039E0
	private void WriteLine() { }

	// RVA: 0x1D03D60 Offset: 0x1D02F60 VA: 0x181D03D60
	private void Write(string s) { }

	// RVA: 0x1CFF3E0 Offset: 0x1CFE5E0 VA: 0x181CFF3E0
	private DebugViewWriter.Flow GetFlow(DebugViewWriter.Flow flow) { }

	// RVA: 0x1CFEEA0 Offset: 0x1CFE0A0 VA: 0x181CFEEA0
	private DebugViewWriter.Flow CheckBreak(DebugViewWriter.Flow flow) { }

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, IReadOnlyList<T> expressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x957360 Offset: 0x956560 VA: 0x180957360
	|-DebugViewWriter.VisitExpressions<object>
	*/

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, char separator, IReadOnlyList<T> expressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x957430 Offset: 0x956630 VA: 0x180957430
	|-DebugViewWriter.VisitExpressions<object>
	*/

	// RVA: 0x1D01660 Offset: 0x1D00860 VA: 0x181D01660
	private void VisitDeclarations(IReadOnlyList<ParameterExpression> expressions) { }

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, char separator, IReadOnlyList<T> expressions, Action<T> visit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x956FE0 Offset: 0x9561E0 VA: 0x180956FE0
	|-DebugViewWriter.VisitExpressions<object>
	|
	|-RVA: 0x956B90 Offset: 0x955D90 VA: 0x180956B90
	|-DebugViewWriter.VisitExpressions<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D001D0 Offset: 0x1CFF3D0 VA: 0x181D001D0 Slot: 5
	protected internal override Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x1D02A30 Offset: 0x1D01C30 VA: 0x181D02A30 Slot: 23
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: -1 Offset: -1 Slot: 16
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x957680 Offset: 0x956880 VA: 0x180957680
	|-DebugViewWriter.VisitLambda<object>
	|
	|-RVA: 0x9574F0 Offset: 0x9566F0 VA: 0x1809574F0
	|-DebugViewWriter.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CFF8D0 Offset: 0x1CFEAD0 VA: 0x181CFF8D0
	private static bool IsSimpleExpression(Expression node) { }

	// RVA: 0x1D00CA0 Offset: 0x1CFFEA0 VA: 0x181D00CA0 Slot: 7
	protected internal override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x1D00F50 Offset: 0x1D00150 VA: 0x181D00F50 Slot: 8
	protected internal override Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x1CFF040 Offset: 0x1CFE240 VA: 0x181CFF040
	private static string GetConstantValueSuffix(Type type) { }

	// RVA: 0x1D02B30 Offset: 0x1D01D30 VA: 0x181D02B30 Slot: 24
	protected internal override Expression VisitRuntimeVariables(RuntimeVariablesExpression node) { }

	// RVA: 0x1CFFBD0 Offset: 0x1CFEDD0 VA: 0x181CFFBD0
	private void OutMember(Expression node, Expression instance, MemberInfo member) { }

	// RVA: 0x1D024A0 Offset: 0x1D016A0 VA: 0x181D024A0 Slot: 18
	protected internal override Expression VisitMember(MemberExpression node) { }

	// RVA: 0x1D01D30 Offset: 0x1D00F30 VA: 0x181D01D30 Slot: 13
	protected internal override Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x1CFF9E0 Offset: 0x1CFEBE0 VA: 0x181CFF9E0
	private static bool NeedsParentheses(Expression parent, Expression child) { }

	// RVA: 0x1CFF6F0 Offset: 0x1CFE8F0 VA: 0x181CFF6F0
	private static int GetOperatorPrecedence(Expression node) { }

	// RVA: 0x1CFFF30 Offset: 0x1CFF130 VA: 0x181CFFF30
	private void ParenthesizedVisit(Expression parent, Expression nodeToVisit) { }

	// RVA: 0x1D025F0 Offset: 0x1D017F0 VA: 0x181D025F0 Slot: 20
	protected internal override Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x1D027F0 Offset: 0x1D019F0 VA: 0x181D027F0 Slot: 21
	protected internal override Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x1D02950 Offset: 0x1D01B50 VA: 0x181D02950 Slot: 22
	protected internal override Expression VisitNew(NewExpression node) { }

	// RVA: 0x1D017D0 Offset: 0x1D009D0 VA: 0x181D017D0 Slot: 33
	protected override ElementInit VisitElementInit(ElementInit node) { }

	// RVA: 0x1D01E80 Offset: 0x1D01080 VA: 0x181D01E80 Slot: 32
	protected internal override Expression VisitListInit(ListInitExpression node) { }

	// RVA: 0x1D020A0 Offset: 0x1D012A0 VA: 0x181D020A0 Slot: 35
	protected override MemberAssignment VisitMemberAssignment(MemberAssignment assignment) { }

	// RVA: 0x1D02240 Offset: 0x1D01440 VA: 0x181D02240 Slot: 37
	protected override MemberListBinding VisitMemberListBinding(MemberListBinding binding) { }

	// RVA: 0x1D02370 Offset: 0x1D01570 VA: 0x181D02370 Slot: 36
	protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding binding) { }

	// RVA: 0x1D02160 Offset: 0x1D01360 VA: 0x181D02160 Slot: 31
	protected internal override Expression VisitMemberInit(MemberInitExpression node) { }

	// RVA: 0x1D031B0 Offset: 0x1D023B0 VA: 0x181D031B0 Slot: 29
	protected internal override Expression VisitTypeBinary(TypeBinaryExpression node) { }

	// RVA: 0x1D032A0 Offset: 0x1D024A0 VA: 0x181D032A0 Slot: 30
	protected internal override Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x1D008D0 Offset: 0x1CFFAD0 VA: 0x181D008D0 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1D01710 Offset: 0x1D00910 VA: 0x181D01710 Slot: 10
	protected internal override Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x1D01DE0 Offset: 0x1D00FE0 VA: 0x181D01DE0 Slot: 15
	protected internal override Expression VisitLabel(LabelExpression node) { }

	// RVA: 0x1D01A20 Offset: 0x1D00C20 VA: 0x181D01A20 Slot: 12
	protected internal override Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x1D01F60 Offset: 0x1D01160 VA: 0x181D01F60 Slot: 17
	protected internal override Expression VisitLoop(LoopExpression node) { }

	// RVA: 0x1D02BC0 Offset: 0x1D01DC0 VA: 0x181D02BC0 Slot: 25
	protected override SwitchCase VisitSwitchCase(SwitchCase node) { }

	// RVA: 0x1D02E30 Offset: 0x1D02030 VA: 0x181D02E30 Slot: 26
	protected internal override Expression VisitSwitch(SwitchExpression node) { }

	// RVA: 0x1D00B20 Offset: 0x1CFFD20 VA: 0x181D00B20 Slot: 27
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x1D02FF0 Offset: 0x1D021F0 VA: 0x181D02FF0 Slot: 28
	protected internal override Expression VisitTry(TryExpression node) { }

	// RVA: 0x1D01B70 Offset: 0x1D00D70 VA: 0x181D01B70 Slot: 19
	protected internal override Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x1D018A0 Offset: 0x1D00AA0 VA: 0x181D018A0 Slot: 11
	protected internal override Expression VisitExtension(Expression node) { }

	// RVA: 0x1D01380 Offset: 0x1D00580 VA: 0x181D01380 Slot: 9
	protected internal override Expression VisitDebugInfo(DebugInfoExpression node) { }

	// RVA: 0x1CFEF90 Offset: 0x1CFE190 VA: 0x181CFEF90
	private void DumpLabel(LabelTarget target) { }

	// RVA: 0x1CFF4F0 Offset: 0x1CFE6F0 VA: 0x181CFF4F0
	private string GetLabelTargetName(LabelTarget target) { }

	// RVA: 0x1D03790 Offset: 0x1D02990 VA: 0x181D03790
	private void WriteLambda(LambdaExpression lambda) { }

	// RVA: 0x1CFF600 Offset: 0x1CFE800 VA: 0x181CFF600
	private string GetLambdaName(LambdaExpression lambda) { }

	// RVA: 0x1CFEEE0 Offset: 0x1CFE0E0 VA: 0x181CFEEE0
	private static bool ContainsWhiteSpace(string name) { }

	// RVA: 0x1D00010 Offset: 0x1CFF210 VA: 0x181D00010
	private static string QuoteName(string name) { }

	// RVA: 0x1CFF2D0 Offset: 0x1CFE4D0 VA: 0x181CFF2D0
	private static string GetDisplayName(string name) { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <VisitExpressions>b__37_0<T>(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x956B60 Offset: 0x955D60 VA: 0x180956B60
	|-DebugViewWriter.<VisitExpressions>b__37_0<object>
	*/

	[CompilerGenerated]
	// RVA: 0x1D00080 Offset: 0x1CFF280 VA: 0x181D00080
	private void <VisitDeclarations>b__38_0(ParameterExpression variable) { }

	[CompilerGenerated]
	// RVA: 0x1D00190 Offset: 0x1CFF390 VA: 0x181D00190
	private void <VisitListInit>b__58_0(ElementInit e) { }

	[CompilerGenerated]
	// RVA: 0x1D00190 Offset: 0x1CFF390 VA: 0x181D00190
	private void <VisitMemberListBinding>b__60_0(ElementInit e) { }

	[CompilerGenerated]
	// RVA: 0x1D001B0 Offset: 0x1CFF3B0 VA: 0x181D001B0
	private void <VisitMemberMemberBinding>b__61_0(MemberBinding e) { }

	[CompilerGenerated]
	// RVA: 0x1D001B0 Offset: 0x1CFF3B0 VA: 0x181D001B0
	private void <VisitMemberInit>b__62_0(MemberBinding e) { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.DefaultExpressionProxy))]
public sealed class DefaultExpression : Expression // TypeDefIndex: 14738
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x1D03FA0 Offset: 0x1D031A0 VA: 0x181D03FA0
	internal void .ctor(Type type) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1D04030 Offset: 0x1D03230 VA: 0x181D04030 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1D03F70 Offset: 0x1D03170 VA: 0x181D03F70 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D04000 Offset: 0x1D03200 VA: 0x181D04000
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
public class DynamicExpression : Expression, IDynamicExpression, IArgumentProvider // TypeDefIndex: 14739
{
	// Fields
	[CompilerGenerated]
	private readonly CallSiteBinder <Binder>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <DelegateType>k__BackingField; // 0x18

	// Properties
	public override bool CanReduce { get; }
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public CallSiteBinder Binder { get; }
	public Type DelegateType { get; }
	public ReadOnlyCollection<Expression> Arguments { get; }
	[ExcludeFromCodeCoverage]
	private int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get; }

	// Methods

	// RVA: 0x1D05BA0 Offset: 0x1D04DA0 VA: 0x181D05BA0
	internal void .ctor(Type delegateType, CallSiteBinder binder) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1D05910 Offset: 0x1D04B10 VA: 0x181D05910 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1D057F0 Offset: 0x1D049F0 VA: 0x181D057F0
	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, ReadOnlyCollection<Expression> arguments) { }

	// RVA: 0x1D055A0 Offset: 0x1D047A0 VA: 0x181D055A0
	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0) { }

	// RVA: 0x1D056C0 Offset: 0x1D048C0 VA: 0x181D056C0
	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1) { }

	// RVA: 0x1D05460 Offset: 0x1D04660 VA: 0x181D05460
	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1D05300 Offset: 0x1D04500 VA: 0x181D05300
	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1D05C40 Offset: 0x1D04E40 VA: 0x181D05C40 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x1A47C60 Offset: 0x1A46E60 VA: 0x181A47C60 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public CallSiteBinder get_Binder() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	public Type get_DelegateType() { }

	// RVA: 0x727AE0 Offset: 0x726CE0 VA: 0x180727AE0
	public ReadOnlyCollection<Expression> get_Arguments() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D05280 Offset: 0x1D04480 VA: 0x181D05280 Slot: 15
	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D05170 Offset: 0x1D04370 VA: 0x181D05170 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D059F0 Offset: 0x1D04BF0 VA: 0x181D059F0 Slot: 16
	internal virtual DynamicExpression Rewrite(Expression[] args) { }

	// RVA: 0x1D05AE0 Offset: 0x1D04CE0 VA: 0x181D05AE0
	public DynamicExpression Update(IEnumerable<Expression> arguments) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D05A20 Offset: 0x1D04C20 VA: 0x181D05A20 Slot: 17
	internal virtual bool SameArguments(ICollection<Expression> arguments) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D05A50 Offset: 0x1D04C50 VA: 0x181D05A50 Slot: 13
	private Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) { }

	// RVA: 0x1D05A80 Offset: 0x1D04C80 VA: 0x181D05A80 Slot: 14
	private int System.Linq.Expressions.IArgumentProvider.get_ArgumentCount() { }

	// RVA: 0x1D05230 Offset: 0x1D04430 VA: 0x181D05230
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression[] arguments) { }

	// RVA: 0x1D05230 Offset: 0x1D04430 VA: 0x181D05230
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, IEnumerable<Expression> arguments) { }

	// RVA: 0x1D05250 Offset: 0x1D04450 VA: 0x181D05250
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0) { }

	// RVA: 0x1D05240 Offset: 0x1D04440 VA: 0x181D05240
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1) { }

	// RVA: 0x1D05260 Offset: 0x1D04460 VA: 0x181D05260
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1D05270 Offset: 0x1D04470 VA: 0x181D05270
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1D052C0 Offset: 0x1D044C0 VA: 0x181D052C0
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable<Expression> arguments) { }

	// RVA: 0x1D052C0 Offset: 0x1D044C0 VA: 0x181D052C0
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression[] arguments) { }

	// RVA: 0x1D052D0 Offset: 0x1D044D0 VA: 0x181D052D0
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0) { }

	// RVA: 0x1D052F0 Offset: 0x1D044F0 VA: 0x181D052F0
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1) { }

	// RVA: 0x1D052E0 Offset: 0x1D044E0 VA: 0x181D052E0
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1D052B0 Offset: 0x1D044B0 VA: 0x181D052B0
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1D05AC0 Offset: 0x1D04CC0 VA: 0x181D05AC0 Slot: 11
	private Expression System.Linq.Expressions.IDynamicExpression.Rewrite(Expression[] args) { }

	// RVA: 0x1D05AB0 Offset: 0x1D04CB0 VA: 0x181D05AB0 Slot: 12
	private object System.Linq.Expressions.IDynamicExpression.CreateCallSite() { }

	// RVA: 0x1D05C10 Offset: 0x1D04E10 VA: 0x181D05C10
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal class DynamicExpressionN : DynamicExpression, IArgumentProvider // TypeDefIndex: 14740
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x20

	// Properties
	private int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get; }

	// Methods

	// RVA: 0x1D042A0 Offset: 0x1D034A0 VA: 0x181D042A0
	internal void .ctor(Type delegateType, CallSiteBinder binder, IReadOnlyList<Expression> arguments) { }

	// RVA: 0x1D05070 Offset: 0x1D04270 VA: 0x181D05070 Slot: 13
	private Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) { }

	// RVA: 0x1D05020 Offset: 0x1D04220 VA: 0x181D05020 Slot: 17
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D050D0 Offset: 0x1D042D0 VA: 0x181D050D0 Slot: 14
	private int System.Linq.Expressions.IArgumentProvider.get_ArgumentCount() { }

	// RVA: 0x1D04FC0 Offset: 0x1D041C0 VA: 0x181D04FC0 Slot: 15
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D05000 Offset: 0x1D04200 VA: 0x181D05000 Slot: 16
	internal override DynamicExpression Rewrite(Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal class TypedDynamicExpressionN : DynamicExpressionN // TypeDefIndex: 14741
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1D16E70 Offset: 0x1D16070 VA: 0x181D16E70
	internal void .ctor(Type returnType, Type delegateType, CallSiteBinder binder, IReadOnlyList<Expression> arguments) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal class DynamicExpression1 : DynamicExpression, IArgumentProvider // TypeDefIndex: 14742
{
	// Fields
	private object _arg0; // 0x20

	// Properties
	private int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get; }

	// Methods

	// RVA: 0x1D042A0 Offset: 0x1D034A0 VA: 0x181D042A0
	internal void .ctor(Type delegateType, CallSiteBinder binder, Expression arg0) { }

	// RVA: 0x1D04200 Offset: 0x1D03400 VA: 0x181D04200 Slot: 13
	private Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 14
	private int System.Linq.Expressions.IArgumentProvider.get_ArgumentCount() { }

	// RVA: 0x1D04090 Offset: 0x1D03290 VA: 0x181D04090 Slot: 17
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 15
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D04050 Offset: 0x1D03250 VA: 0x181D04050 Slot: 16
	internal override DynamicExpression Rewrite(Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class TypedDynamicExpression1 : DynamicExpression1 // TypeDefIndex: 14743
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1D16E70 Offset: 0x1D16070 VA: 0x181D16E70
	internal void .ctor(Type retType, Type delegateType, CallSiteBinder binder, Expression arg0) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal class DynamicExpression2 : DynamicExpression, IArgumentProvider // TypeDefIndex: 14744
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28

	// Properties
	private int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get; }

	// Methods

	// RVA: 0x1D04650 Offset: 0x1D03850 VA: 0x181D04650
	internal void .ctor(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1) { }

	// RVA: 0x1D045A0 Offset: 0x1D037A0 VA: 0x181D045A0 Slot: 13
	private Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 14
	private int System.Linq.Expressions.IArgumentProvider.get_ArgumentCount() { }

	// RVA: 0x1D04370 Offset: 0x1D03570 VA: 0x181D04370 Slot: 17
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 15
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D04320 Offset: 0x1D03520 VA: 0x181D04320 Slot: 16
	internal override DynamicExpression Rewrite(Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class TypedDynamicExpression2 : DynamicExpression2 // TypeDefIndex: 14745
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1D16EB0 Offset: 0x1D160B0 VA: 0x181D16EB0
	internal void .ctor(Type retType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal class DynamicExpression3 : DynamicExpression, IArgumentProvider // TypeDefIndex: 14746
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30

	// Properties
	private int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get; }

	// Methods

	// RVA: 0x1D04A80 Offset: 0x1D03C80 VA: 0x181D04A80
	internal void .ctor(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1D049C0 Offset: 0x1D03BC0 VA: 0x181D049C0 Slot: 13
	private Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 14
	private int System.Linq.Expressions.IArgumentProvider.get_ArgumentCount() { }

	// RVA: 0x1D04740 Offset: 0x1D03940 VA: 0x181D04740 Slot: 17
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 15
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D046E0 Offset: 0x1D038E0 VA: 0x181D046E0 Slot: 16
	internal override DynamicExpression Rewrite(Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class TypedDynamicExpression3 : DynamicExpression3 // TypeDefIndex: 14747
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x38

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1D16F00 Offset: 0x1D16100 VA: 0x181D16F00
	internal void .ctor(Type retType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal class DynamicExpression4 : DynamicExpression, IArgumentProvider // TypeDefIndex: 14748
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30
	private readonly Expression _arg3; // 0x38

	// Properties
	private int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get; }

	// Methods

	// RVA: 0x1D04F20 Offset: 0x1D04120 VA: 0x181D04F20
	internal void .ctor(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1D04E50 Offset: 0x1D04050 VA: 0x181D04E50 Slot: 13
	private Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 14
	private int System.Linq.Expressions.IArgumentProvider.get_ArgumentCount() { }

	// RVA: 0x1D04B80 Offset: 0x1D03D80 VA: 0x181D04B80 Slot: 17
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 15
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D04B10 Offset: 0x1D03D10 VA: 0x181D04B10 Slot: 16
	internal override DynamicExpression Rewrite(Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class TypedDynamicExpression4 : DynamicExpression4 // TypeDefIndex: 14749
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x40

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1D16F60 Offset: 0x1D16160 VA: 0x181D16F60
	internal void .ctor(Type retType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal static class ExpressionExtension // TypeDefIndex: 14750
{
	// Methods

	// RVA: 0x1D052C0 Offset: 0x1D044C0 VA: 0x181D052C0
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression[] arguments) { }

	// RVA: 0x1D0CA00 Offset: 0x1D0BC00 VA: 0x181D0CA00
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable<Expression> arguments) { }

	// RVA: 0x1D0C190 Offset: 0x1D0B390 VA: 0x181D0C190
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0) { }

	// RVA: 0x1D0D090 Offset: 0x1D0C290 VA: 0x181D0D090
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1) { }

	// RVA: 0x1D0CD90 Offset: 0x1D0BF90 VA: 0x181D0CD90
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1D0C3B0 Offset: 0x1D0B5B0 VA: 0x181D0C3B0
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1D0C040 Offset: 0x1D0B240 VA: 0x181D0C040
	private static MethodInfo GetValidMethodForDynamic(Type delegateType) { }

	// RVA: 0x1D05230 Offset: 0x1D04430 VA: 0x181D05230
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression[] arguments) { }

	// RVA: 0x1D0BE60 Offset: 0x1D0B060 VA: 0x181D0BE60
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0) { }

	// RVA: 0x1D0B420 Offset: 0x1D0A620 VA: 0x181D0B420
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1) { }

	// RVA: 0x1D0B760 Offset: 0x1D0A960 VA: 0x181D0B760
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1D0BA90 Offset: 0x1D0AC90 VA: 0x181D0BA90
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1D0B690 Offset: 0x1D0A890 VA: 0x181D0B690
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, IEnumerable<Expression> arguments) { }

	// RVA: 0x1D0C730 Offset: 0x1D0B930 VA: 0x181D0C730
	private static DynamicExpression MakeDynamic(CallSiteBinder binder, Type returnType, ReadOnlyCollection<Expression> arguments) { }

	// RVA: 0x1D0D460 Offset: 0x1D0C660 VA: 0x181D0D460
	private static void ValidateDynamicArgument(Expression arg, string paramName) { }

	// RVA: 0x1D0D310 Offset: 0x1D0C510 VA: 0x181D0D310
	private static void ValidateDynamicArgument(Expression arg, string paramName, int index) { }
}

// Namespace: System.Linq.Expressions
public class DynamicExpressionVisitor : ExpressionVisitor // TypeDefIndex: 14751
{
	// Methods

	// RVA: 0x1D05120 Offset: 0x1D04320 VA: 0x181D05120 Slot: 38
	protected internal override Expression VisitDynamic(DynamicExpression node) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions
public sealed class ElementInit : IArgumentProvider // TypeDefIndex: 14752
{
	// Fields
	[CompilerGenerated]
	private readonly MethodInfo <AddMethod>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <Arguments>k__BackingField; // 0x18

	// Properties
	public MethodInfo AddMethod { get; }
	public ReadOnlyCollection<Expression> Arguments { get; }
	public int ArgumentCount { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(MethodInfo addMethod, ReadOnlyCollection<Expression> arguments) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public MethodInfo get_AddMethod() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1D05CA0 Offset: 0x1D04EA0 VA: 0x181D05CA0 Slot: 4
	public Expression GetArgument(int index) { }

	// RVA: 0x1D05E80 Offset: 0x1D05080 VA: 0x181D05E80 Slot: 5
	public int get_ArgumentCount() { }

	// RVA: 0x1D05D00 Offset: 0x1D04F00 VA: 0x181D05D00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D05DD0 Offset: 0x1D04FD0 VA: 0x181D05DD0
	public ElementInit Update(IEnumerable<Expression> arguments) { }

	// RVA: 0x1D05E50 Offset: 0x1D05050 VA: 0x181D05E50
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal static class Error // TypeDefIndex: 14753
{
	// Methods

	// RVA: 0x1D0A310 Offset: 0x1D09510 VA: 0x181D0A310
	internal static Exception ReducibleMustOverrideReduce() { }

	// RVA: 0x1D061F0 Offset: 0x1D053F0 VA: 0x181D061F0
	internal static Exception ArgCntMustBeGreaterThanNameCnt() { }

	// RVA: 0x1D08B80 Offset: 0x1D07D80 VA: 0x181D08B80
	internal static Exception InvalidMetaObjectCreated(object p0) { }

	// RVA: 0x1D06180 Offset: 0x1D05380 VA: 0x181D06180
	internal static Exception AmbiguousMatchInExpandoObject(object p0) { }

	// RVA: 0x1D0A440 Offset: 0x1D09640 VA: 0x181D0A440
	internal static Exception SameKeyExistsInExpando(object key) { }

	// RVA: 0x1D08DD0 Offset: 0x1D07FD0 VA: 0x181D08DD0
	internal static Exception KeyDoesNotExistInExpando(object p0) { }

	// RVA: 0x1D07120 Offset: 0x1D06320 VA: 0x181D07120
	internal static Exception CollectionModifiedWhileEnumerating() { }

	// RVA: 0x1D07180 Offset: 0x1D06380 VA: 0x181D07180
	internal static Exception CollectionReadOnly() { }

	// RVA: 0x1D094B0 Offset: 0x1D086B0 VA: 0x181D094B0
	internal static Exception MustReduceToDifferent() { }

	// RVA: 0x1D06CE0 Offset: 0x1D05EE0 VA: 0x181D06CE0
	internal static Exception BinderNotCompatibleWithCallSite(object p0, object p1, object p2) { }

	// RVA: 0x1D075C0 Offset: 0x1D067C0 VA: 0x181D075C0
	internal static Exception DynamicBindingNeedsRestrictions(object p0, object p1) { }

	// RVA: 0x1D07630 Offset: 0x1D06830 VA: 0x181D07630
	internal static Exception DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3) { }

	// RVA: 0x1D07540 Offset: 0x1D06740 VA: 0x181D07540
	internal static Exception DynamicBinderResultNotAssignable(object p0, object p1, object p2) { }

	// RVA: 0x1D06D60 Offset: 0x1D05F60 VA: 0x181D06D60
	internal static Exception BindingCannotBeNull() { }

	// RVA: 0x1D0A2B0 Offset: 0x1D094B0 VA: 0x181D0A2B0
	internal static Exception ReducedNotCompatible() { }

	// RVA: 0x1D0A4C0 Offset: 0x1D096C0 VA: 0x181D0A4C0
	internal static Exception SetterHasNoParams(string paramName) { }

	// RVA: 0x1D09D80 Offset: 0x1D08F80 VA: 0x181D09D80
	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	// RVA: 0x1D087A0 Offset: 0x1D079A0 VA: 0x181D087A0
	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	// RVA: 0x1D0ACE0 Offset: 0x1D09EE0 VA: 0x181D0ACE0
	internal static Exception TypeParameterIsNotDelegate(object p0) { }

	// RVA: 0x1D08230 Offset: 0x1D07430 VA: 0x181D08230
	internal static Exception FirstArgumentMustBeCallSite() { }

	// RVA: 0x1D05FC0 Offset: 0x1D051C0 VA: 0x181D05FC0
	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	// RVA: 0x1D05F50 Offset: 0x1D05150 VA: 0x181D05F50
	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	// RVA: 0x1D05ED0 Offset: 0x1D050D0 VA: 0x181D05ED0
	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	// RVA: 0x1D0AB20 Offset: 0x1D09D20 VA: 0x181D0AB20
	internal static Exception TypeMustBeDerivedFromSystemDelegate() { }

	// RVA: 0x1D09680 Offset: 0x1D08880 VA: 0x181D09680
	internal static Exception NoOrInvalidRuleProduced() { }

	// RVA: 0x1D06E90 Offset: 0x1D06090 VA: 0x181D06E90
	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	// RVA: 0x1D0AB80 Offset: 0x1D09D80 VA: 0x181D0AB80
	internal static Exception TypeMustNotBeByRef(string paramName) { }

	// RVA: 0x1D0ABF0 Offset: 0x1D09DF0 VA: 0x181D0ABF0
	internal static Exception TypeMustNotBePointer(string paramName) { }

	// RVA: 0x1D0A530 Offset: 0x1D09730 VA: 0x181D0A530
	internal static Exception SetterMustBeVoid(string paramName) { }

	// RVA: 0x1D0A0F0 Offset: 0x1D092F0 VA: 0x181D0A0F0
	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	// RVA: 0x1D0A160 Offset: 0x1D09360 VA: 0x181D0A160
	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	// RVA: 0x1D06E20 Offset: 0x1D06020 VA: 0x181D06E20
	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	// RVA: 0x1D09A70 Offset: 0x1D08C70 VA: 0x181D09A70
	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	// RVA: 0x1D09B40 Offset: 0x1D08D40 VA: 0x181D09B40
	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	// RVA: 0x1D09AE0 Offset: 0x1D08CE0 VA: 0x181D09AE0
	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	// RVA: 0x1D0A080 Offset: 0x1D09280 VA: 0x181D0A080
	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	// RVA: 0x1D08D60 Offset: 0x1D07F60 VA: 0x181D08D60
	internal static Exception InvalidUnboxType(string paramName) { }

	// RVA: 0x1D07A60 Offset: 0x1D06C60 VA: 0x181D07A60
	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	// RVA: 0x1D06950 Offset: 0x1D05B50 VA: 0x181D06950
	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	// RVA: 0x1D09450 Offset: 0x1D08650 VA: 0x181D09450
	internal static Exception MustBeReducible() { }

	// RVA: 0x1D060A0 Offset: 0x1D052A0 VA: 0x181D060A0
	internal static Exception AllTestValuesMustHaveSameType(string paramName) { }

	// RVA: 0x1D06030 Offset: 0x1D05230 VA: 0x181D06030
	internal static Exception AllCaseBodiesMustHaveSameType(string paramName) { }

	// RVA: 0x1D073C0 Offset: 0x1D065C0 VA: 0x181D073C0
	internal static Exception DefaultBodyMustBeSupplied(string paramName) { }

	// RVA: 0x1D08E40 Offset: 0x1D08040 VA: 0x181D08E40
	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	// RVA: 0x1D08F90 Offset: 0x1D08190 VA: 0x181D08F90
	internal static Exception LabelTypeMustBeVoid(string paramName) { }

	// RVA: 0x1D0A240 Offset: 0x1D09440 VA: 0x181D0A240
	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	// RVA: 0x1D0B3A0 Offset: 0x1D0A5A0 VA: 0x181D0B3A0
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	// RVA: 0x1D0B310 Offset: 0x1D0A510 VA: 0x181D0B310
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1D07430 Offset: 0x1D06630 VA: 0x181D07430
	private static Exception DuplicateVariable(object p0, string paramName) { }

	// RVA: 0x1D074B0 Offset: 0x1D066B0 VA: 0x181D074B0
	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	// RVA: 0x1D0A5A0 Offset: 0x1D097A0 VA: 0x181D0A5A0
	internal static Exception StartEndMustBeOrdered() { }

	// RVA: 0x1D080D0 Offset: 0x1D072D0 VA: 0x181D080D0
	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	// RVA: 0x1D0A6E0 Offset: 0x1D098E0 VA: 0x181D0A6E0
	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	// RVA: 0x1D06DC0 Offset: 0x1D05FC0 VA: 0x181D06DC0
	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	// RVA: 0x1D08060 Offset: 0x1D07260 VA: 0x181D08060
	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	// RVA: 0x1D0B210 Offset: 0x1D0A410 VA: 0x181D0B210
	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	// RVA: 0x1D0B290 Offset: 0x1D0A490 VA: 0x181D0B290
	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	// RVA: 0x1D070B0 Offset: 0x1D062B0 VA: 0x181D070B0
	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x1D0AD50 Offset: 0x1D09F50 VA: 0x181D0AD50
	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x1D06C60 Offset: 0x1D05E60 VA: 0x181D06C60
	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	// RVA: 0x1D0A370 Offset: 0x1D09570 VA: 0x181D0A370
	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	// RVA: 0x1D09BB0 Offset: 0x1D08DB0 VA: 0x181D09BB0
	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	// RVA: 0x1D09CA0 Offset: 0x1D08EA0 VA: 0x181D09CA0
	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	// RVA: 0x1D07360 Offset: 0x1D06560 VA: 0x181D07360
	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	// RVA: 0x1D06A20 Offset: 0x1D05C20 VA: 0x181D06A20
	internal static Exception ArgumentTypeCannotBeVoid() { }

	// RVA: 0x1D064C0 Offset: 0x1D056C0 VA: 0x181D064C0
	internal static Exception ArgumentMustBeArray(string paramName) { }

	// RVA: 0x1D06530 Offset: 0x1D05730 VA: 0x181D06530
	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	// RVA: 0x1D078F0 Offset: 0x1D06AF0 VA: 0x181D078F0
	internal static Exception EqualityMustReturnBoolean(object p0, string paramName) { }

	// RVA: 0x1D06690 Offset: 0x1D05890 VA: 0x181D06690
	internal static Exception ArgumentMustBeFieldInfoOrPropertyInfo(string paramName) { }

	// RVA: 0x1D06620 Offset: 0x1D05820 VA: 0x181D06620
	private static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName) { }

	// RVA: 0x1D065A0 Offset: 0x1D057A0 VA: 0x181D065A0
	internal static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName, int index) { }

	// RVA: 0x1D06780 Offset: 0x1D05980 VA: 0x181D06780
	private static Exception ArgumentMustBeInstanceMember(string paramName) { }

	// RVA: 0x1D06700 Offset: 0x1D05900 VA: 0x181D06700
	internal static Exception ArgumentMustBeInstanceMember(string paramName, int index) { }

	// RVA: 0x1D067F0 Offset: 0x1D059F0 VA: 0x181D067F0
	private static Exception ArgumentMustBeInteger(string paramName) { }

	// RVA: 0x1D06860 Offset: 0x1D05A60 VA: 0x181D06860
	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	// RVA: 0x1D063D0 Offset: 0x1D055D0 VA: 0x181D063D0
	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	// RVA: 0x1D06440 Offset: 0x1D05640 VA: 0x181D06440
	internal static Exception ArgumentMustBeArrayIndexType(string paramName, int index) { }

	// RVA: 0x1D068E0 Offset: 0x1D05AE0 VA: 0x181D068E0
	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	// RVA: 0x1D06B90 Offset: 0x1D05D90 VA: 0x181D06B90
	internal static Exception ArgumentTypesMustMatch() { }

	// RVA: 0x1D06BF0 Offset: 0x1D05DF0 VA: 0x181D06BF0
	internal static Exception ArgumentTypesMustMatch(string paramName) { }

	// RVA: 0x1D06F00 Offset: 0x1D06100 VA: 0x181D06F00
	internal static Exception CannotAutoInitializeValueTypeElementThroughProperty(object p0) { }

	// RVA: 0x1D06F70 Offset: 0x1D06170 VA: 0x181D06F70
	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	// RVA: 0x1D08720 Offset: 0x1D07920 VA: 0x181D08720
	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	// RVA: 0x1D07050 Offset: 0x1D06250 VA: 0x181D07050
	internal static Exception CoalesceUsedOnNonNullType() { }

	// RVA: 0x1D07AD0 Offset: 0x1D06CD0 VA: 0x181D07AD0
	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	// RVA: 0x1D06B10 Offset: 0x1D05D10 VA: 0x181D06B10
	private static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName) { }

	// RVA: 0x1D06A80 Offset: 0x1D05C80 VA: 0x181D06A80
	internal static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1D06350 Offset: 0x1D05550 VA: 0x181D06350
	private static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName) { }

	// RVA: 0x1D062C0 Offset: 0x1D054C0 VA: 0x181D062C0
	internal static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1D07F70 Offset: 0x1D07170 VA: 0x181D07F70
	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	// RVA: 0x1D07B40 Offset: 0x1D06D40 VA: 0x181D07B40
	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	// RVA: 0x1D07CC0 Offset: 0x1D06EC0 VA: 0x181D07CC0
	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	// RVA: 0x1D07FE0 Offset: 0x1D071E0 VA: 0x181D07FE0
	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	// RVA: 0x1D081C0 Offset: 0x1D073C0 VA: 0x181D081C0
	internal static Exception FieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1D08890 Offset: 0x1D07A90 VA: 0x181D08890
	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1D08140 Offset: 0x1D07340 VA: 0x181D08140
	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x1D08440 Offset: 0x1D07640 VA: 0x181D08440
	internal static Exception IncorrectNumberOfIndexes() { }

	// RVA: 0x1D08500 Offset: 0x1D07700 VA: 0x181D08500
	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	// RVA: 0x1D08560 Offset: 0x1D07760 VA: 0x181D08560
	internal static Exception IncorrectNumberOfMembersForGivenConstructor() { }

	// RVA: 0x1D08380 Offset: 0x1D07580 VA: 0x181D08380
	internal static Exception IncorrectNumberOfArgumentsForMembers() { }

	// RVA: 0x1D09000 Offset: 0x1D08200 VA: 0x181D09000
	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	// RVA: 0x1D090E0 Offset: 0x1D082E0 VA: 0x181D090E0
	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	// RVA: 0x1D09160 Offset: 0x1D08360 VA: 0x181D09160
	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x1D091E0 Offset: 0x1D083E0 VA: 0x181D091E0
	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	// RVA: 0x1D09260 Offset: 0x1D08460 VA: 0x181D09260
	private static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName) { }

	// RVA: 0x1D092E0 Offset: 0x1D084E0 VA: 0x181D092E0
	internal static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1D09E70 Offset: 0x1D09070 VA: 0x181D09E70
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName) { }

	// RVA: 0x1D09EF0 Offset: 0x1D090F0 VA: 0x181D09EF0
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName, int index) { }

	// RVA: 0x1D09F80 Offset: 0x1D09180 VA: 0x181D09F80
	internal static Exception PropertyDoesNotHaveSetter(object p0, string paramName) { }

	// RVA: 0x1D09DF0 Offset: 0x1D08FF0 VA: 0x181D09DF0
	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	// RVA: 0x1D09910 Offset: 0x1D08B10 VA: 0x181D09910
	internal static Exception NotAMemberOfType(object p0, object p1, string paramName) { }

	// RVA: 0x1D09990 Offset: 0x1D08B90 VA: 0x181D09990
	internal static Exception NotAMemberOfType(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1D09890 Offset: 0x1D08A90 VA: 0x181D09890
	internal static Exception NotAMemberOfAnyType(object p0, string paramName) { }

	// RVA: 0x1D09D10 Offset: 0x1D08F10 VA: 0x181D09D10
	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	// RVA: 0x1D0A000 Offset: 0x1D09200 VA: 0x181D0A000
	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x1D08900 Offset: 0x1D07B00 VA: 0x181D08900
	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x1D08A10 Offset: 0x1D07C10 VA: 0x181D08A10
	internal static Exception InstancePropertyWithoutParameterNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1D08980 Offset: 0x1D07B80 VA: 0x181D08980
	internal static Exception InstancePropertyWithSpecifiedParametersNotDefinedForType(object p0, object p1, object p2, string paramName) { }

	// RVA: 0x1D08810 Offset: 0x1D07A10 VA: 0x181D08810
	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	// RVA: 0x1D0AAA0 Offset: 0x1D09CA0 VA: 0x181D0AAA0
	internal static Exception TypeMissingDefaultConstructor(object p0, string paramName) { }

	// RVA: 0x1D07740 Offset: 0x1D06940 VA: 0x181D07740
	internal static Exception ElementInitializerMethodNotAdd(string paramName) { }

	// RVA: 0x1D076C0 Offset: 0x1D068C0 VA: 0x181D076C0
	internal static Exception ElementInitializerMethodNoRefOutParam(object p0, object p1, string paramName) { }

	// RVA: 0x1D07820 Offset: 0x1D06A20 VA: 0x181D07820
	internal static Exception ElementInitializerMethodWithZeroArgs(string paramName) { }

	// RVA: 0x1D077B0 Offset: 0x1D069B0 VA: 0x181D077B0
	internal static Exception ElementInitializerMethodStatic(string paramName) { }

	// RVA: 0x1D0AC60 Offset: 0x1D09E60 VA: 0x181D0AC60
	internal static Exception TypeNotIEnumerable(object p0, string paramName) { }

	// RVA: 0x1D0AEB0 Offset: 0x1D0A0B0 VA: 0x181D0AEB0
	internal static Exception UnhandledBinary(object p0, string paramName) { }

	// RVA: 0x1D0AFA0 Offset: 0x1D0A1A0 VA: 0x181D0AFA0
	internal static Exception UnhandledBinding() { }

	// RVA: 0x1D0AF30 Offset: 0x1D0A130 VA: 0x181D0AF30
	internal static Exception UnhandledBindingType(object p0) { }

	// RVA: 0x1D0B000 Offset: 0x1D0A200 VA: 0x181D0B000
	internal static Exception UnhandledUnary(object p0, string paramName) { }

	// RVA: 0x1D0B080 Offset: 0x1D0A280 VA: 0x181D0B080
	internal static Exception UnknownBindingType(int index) { }

	// RVA: 0x1D0B130 Offset: 0x1D0A330 VA: 0x181D0B130
	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	// RVA: 0x1D0B1A0 Offset: 0x1D0A3A0 VA: 0x181D0B1A0
	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	// RVA: 0x1D09070 Offset: 0x1D08270 VA: 0x181D09070
	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	// RVA: 0x1D09370 Offset: 0x1D08570 VA: 0x181D09370
	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x1D08290 Offset: 0x1D07490 VA: 0x181D08290
	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x1D093E0 Offset: 0x1D085E0 VA: 0x181D093E0
	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x1D0A1D0 Offset: 0x1D093D0 VA: 0x181D0A1D0
	internal static Exception PropertyWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x1D086B0 Offset: 0x1D078B0 VA: 0x181D086B0
	internal static Exception IncorrectNumberOfTypeArgsForFunc(string paramName) { }

	// RVA: 0x1D08640 Offset: 0x1D07840 VA: 0x181D08640
	internal static Exception IncorrectNumberOfTypeArgsForAction(string paramName) { }

	// RVA: 0x1D06250 Offset: 0x1D05450 VA: 0x181D06250
	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	// RVA: 0x1D09C20 Offset: 0x1D08E20 VA: 0x181D09C20
	internal static Exception OutOfRange(string paramName, object p1) { }

	// RVA: 0x1D08EB0 Offset: 0x1D080B0 VA: 0x181D08EB0
	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	// RVA: 0x1D08F20 Offset: 0x1D08120 VA: 0x181D08F20
	internal static Exception LabelTargetUndefined(object p0) { }

	// RVA: 0x1D07300 Offset: 0x1D06500 VA: 0x181D07300
	internal static Exception ControlCannotLeaveFinally() { }

	// RVA: 0x1D072A0 Offset: 0x1D064A0 VA: 0x181D072A0
	internal static Exception ControlCannotLeaveFilterTest() { }

	// RVA: 0x1D06110 Offset: 0x1D05310 VA: 0x181D06110
	internal static Exception AmbiguousJump(object p0) { }

	// RVA: 0x1D07240 Offset: 0x1D06440 VA: 0x181D07240
	internal static Exception ControlCannotEnterTry() { }

	// RVA: 0x1D071E0 Offset: 0x1D063E0 VA: 0x181D071E0
	internal static Exception ControlCannotEnterExpression() { }

	// RVA: 0x1D097B0 Offset: 0x1D089B0 VA: 0x181D097B0
	internal static Exception NonLocalJumpWithValue(object p0) { }

	// RVA: 0x1D08AF0 Offset: 0x1D07CF0 VA: 0x181D08AF0
	internal static Exception InvalidLvalue(ExpressionType p0) { }

	// RVA: 0x1D0ADC0 Offset: 0x1D09FC0 VA: 0x181D0ADC0
	internal static Exception UndefinedVariable(object p0, object p1, object p2) { }

	// RVA: 0x1D06FE0 Offset: 0x1D061E0 VA: 0x181D06FE0
	internal static Exception CannotCloseOverByRef(object p0, object p1) { }

	// RVA: 0x1D0AE40 Offset: 0x1D0A040 VA: 0x181D0AE40
	internal static Exception UnexpectedVarArgsCall(object p0) { }

	// RVA: 0x1D0A3E0 Offset: 0x1D095E0 VA: 0x181D0A3E0
	internal static Exception RethrowRequiresCatch() { }

	// RVA: 0x1D0A740 Offset: 0x1D09940 VA: 0x181D0A740
	internal static Exception TryNotAllowedInFilter() { }

	// RVA: 0x1D09590 Offset: 0x1D08790 VA: 0x181D09590
	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	// RVA: 0x1D09510 Offset: 0x1D08710 VA: 0x181D09510
	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	// RVA: 0x1D09610 Offset: 0x1D08810 VA: 0x181D09610
	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	// RVA: 0x1D0A7A0 Offset: 0x1D099A0 VA: 0x181D0A7A0
	internal static Exception TryNotSupportedForMethodsWithRefArgs(object p0) { }

	// RVA: 0x1D0A810 Offset: 0x1D09A10 VA: 0x181D0A810
	internal static Exception TryNotSupportedForValueTypeInstances(object p0) { }

	// RVA: 0x1D0A670 Offset: 0x1D09870 VA: 0x181D0A670
	internal static Exception TestValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1) { }

	// RVA: 0x1D0A600 Offset: 0x1D09800 VA: 0x181D0A600
	internal static Exception SwitchValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1) { }

	// RVA: 0x1D069C0 Offset: 0x1D05BC0 VA: 0x181D069C0
	internal static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x1D09A20 Offset: 0x1D08C20 VA: 0x181D09A20
	internal static Exception NotSupported() { }

	// RVA: 0x1D09820 Offset: 0x1D08A20 VA: 0x181D09820
	internal static Exception NonStaticConstructorRequired(string paramName) { }

	// RVA: 0x1D096E0 Offset: 0x1D088E0 VA: 0x181D096E0
	internal static Exception NonAbstractConstructorRequired() { }

	// RVA: 0x1D08C70 Offset: 0x1D07E70 VA: 0x181D08C70
	internal static Exception InvalidProgram() { }

	// RVA: 0x1D07890 Offset: 0x1D06A90 VA: 0x181D07890
	internal static Exception EnumerationIsDone() { }

	// RVA: 0x1D0A910 Offset: 0x1D09B10 VA: 0x181D0A910
	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x1D0A880 Offset: 0x1D09A80 VA: 0x181D0A880
	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	// RVA: 0x1D0A990 Offset: 0x1D09B90 VA: 0x181D0A990
	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	// RVA: 0x1D0AA10 Offset: 0x1D09C10 VA: 0x181D0AA10
	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	// RVA: 0x1D083E0 Offset: 0x1D075E0 VA: 0x181D083E0
	internal static Exception IncorrectNumberOfConstructorArguments() { }

	// RVA: 0x1D07D30 Offset: 0x1D06F30 VA: 0x181D07D30
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	// RVA: 0x1D07DC0 Offset: 0x1D06FC0 VA: 0x181D07DC0
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	// RVA: 0x1D07EF0 Offset: 0x1D070F0 VA: 0x181D07EF0
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	// RVA: 0x1D07E60 Offset: 0x1D07060 VA: 0x181D07E60
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1D084A0 Offset: 0x1D076A0 VA: 0x181D084A0
	internal static Exception IncorrectNumberOfLambdaArguments() { }

	// RVA: 0x1D085C0 Offset: 0x1D077C0 VA: 0x181D085C0
	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	// RVA: 0x1D07BB0 Offset: 0x1D06DB0 VA: 0x181D07BB0
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	// RVA: 0x1D07C30 Offset: 0x1D06E30 VA: 0x181D07C30
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1D07970 Offset: 0x1D06B70 VA: 0x181D07970
	internal static Exception ExpressionMustBeReadable(string paramName) { }

	// RVA: 0x1D079E0 Offset: 0x1D06BE0 VA: 0x181D079E0
	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	// RVA: 0x1D08A80 Offset: 0x1D07C80 VA: 0x181D08A80
	internal static Exception InvalidArgumentValue(string paramName) { }

	// RVA: 0x1D09740 Offset: 0x1D08940 VA: 0x181D09740
	internal static Exception NonEmptyCollectionRequired(string paramName) { }

	// RVA: 0x1D08BF0 Offset: 0x1D07DF0 VA: 0x181D08BF0
	internal static Exception InvalidNullValue(Type type, string paramName) { }

	// RVA: 0x1D08CC0 Offset: 0x1D07EC0 VA: 0x181D08CC0
	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	// RVA: 0x1D08300 Offset: 0x1D07500 VA: 0x181D08300
	private static string GetParamName(string paramName, int index) { }
}

// Namespace: System.Linq.Expressions
internal sealed class ExpressionStringBuilder : ExpressionVisitor // TypeDefIndex: 14754
{
	// Fields
	private readonly StringBuilder _out; // 0x10
	private Dictionary<object, int> _ids; // 0x18

	// Methods

	// RVA: 0x1D10B50 Offset: 0x1D0FD50 VA: 0x181D10B50
	private void .ctor() { }

	// RVA: 0x1D0DAF0 Offset: 0x1D0CCF0 VA: 0x181D0DAF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D0D710 Offset: 0x1D0C910 VA: 0x181D0D710
	private int GetLabelId(LabelTarget label) { }

	// RVA: 0x1D0D710 Offset: 0x1D0C910 VA: 0x181D0D710
	private int GetParamId(ParameterExpression p) { }

	// RVA: 0x1D0D600 Offset: 0x1D0C800 VA: 0x181D0D600
	private int GetId(object o) { }

	// RVA: 0x1D0D9E0 Offset: 0x1D0CBE0 VA: 0x181D0D9E0
	private void Out(string s) { }

	// RVA: 0x1D0DA00 Offset: 0x1D0CC00 VA: 0x181D0DA00
	private void Out(char c) { }

	// RVA: 0x1D0D530 Offset: 0x1D0C730 VA: 0x181D0D530
	internal static string ExpressionToString(Expression node) { }

	// RVA: 0x1CFE020 Offset: 0x1CFD220 VA: 0x181CFE020
	internal static string CatchBlockToString(CatchBlock node) { }

	// RVA: 0x1D0DA20 Offset: 0x1D0CC20 VA: 0x181D0DA20
	internal static string SwitchCaseToString(SwitchCase node) { }

	// RVA: 0x1D0D830 Offset: 0x1D0CA30 VA: 0x181D0D830
	internal static string MemberBindingToString(MemberBinding node) { }

	// RVA: 0x1D05D00 Offset: 0x1D04F00 VA: 0x181D05D00
	internal static string ElementInitBindingToString(ElementInit node) { }

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A4CC0 Offset: 0x9A3EC0 VA: 0x1809A4CC0
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close, string seperator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A4A70 Offset: 0x9A3C70 VA: 0x1809A4A70
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: 0x1D0DB20 Offset: 0x1D0CD20 VA: 0x181D0DB20 Slot: 5
	protected internal override Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x1D101E0 Offset: 0x1D0F3E0 VA: 0x181D101E0 Slot: 23
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: -1 Offset: -1 Slot: 16
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A4F00 Offset: 0x9A4100 VA: 0x1809A4F00
	|-ExpressionStringBuilder.VisitLambda<object>
	|
	|-RVA: 0x9A4D60 Offset: 0x9A3F60 VA: 0x1809A4D60
	|-ExpressionStringBuilder.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D0F450 Offset: 0x1D0E650 VA: 0x181D0F450 Slot: 32
	protected internal override Expression VisitListInit(ListInitExpression node) { }

	// RVA: 0x1D0E4E0 Offset: 0x1D0D6E0 VA: 0x181D0E4E0 Slot: 7
	protected internal override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x1D0E600 Offset: 0x1D0D800 VA: 0x181D0E600 Slot: 8
	protected internal override Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x1D0E7D0 Offset: 0x1D0D9D0 VA: 0x181D0E7D0 Slot: 9
	protected internal override Expression VisitDebugInfo(DebugInfoExpression node) { }

	// RVA: 0x1D102D0 Offset: 0x1D0F4D0 VA: 0x181D102D0 Slot: 24
	protected internal override Expression VisitRuntimeVariables(RuntimeVariablesExpression node) { }

	// RVA: 0x1D0D900 Offset: 0x1D0CB00 VA: 0x181D0D900
	private void OutMember(Expression instance, MemberInfo member) { }

	// RVA: 0x1D0FB80 Offset: 0x1D0ED80 VA: 0x181D0FB80 Slot: 18
	protected internal override Expression VisitMember(MemberExpression node) { }

	// RVA: 0x1D0F6B0 Offset: 0x1D0E8B0 VA: 0x181D0F6B0 Slot: 31
	protected internal override Expression VisitMemberInit(MemberInitExpression node) { }

	// RVA: 0x1D0F600 Offset: 0x1D0E800 VA: 0x181D0F600 Slot: 35
	protected override MemberAssignment VisitMemberAssignment(MemberAssignment assignment) { }

	// RVA: 0x1D0F8C0 Offset: 0x1D0EAC0 VA: 0x181D0F8C0 Slot: 37
	protected override MemberListBinding VisitMemberListBinding(MemberListBinding binding) { }

	// RVA: 0x1D0FA20 Offset: 0x1D0EC20 VA: 0x181D0FA20 Slot: 36
	protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding binding) { }

	// RVA: 0x1D0EB70 Offset: 0x1D0DD70 VA: 0x181D0EB70 Slot: 33
	protected override ElementInit VisitElementInit(ElementInit initializer) { }

	// RVA: 0x1D0F280 Offset: 0x1D0E480 VA: 0x181D0F280 Slot: 13
	protected internal override Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x1D0FCA0 Offset: 0x1D0EEA0 VA: 0x181D0FCA0 Slot: 20
	protected internal override Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x1D0FEA0 Offset: 0x1D0F0A0 VA: 0x181D0FEA0 Slot: 21
	protected internal override Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x1D0FFE0 Offset: 0x1D0F1E0 VA: 0x181D0FFE0 Slot: 22
	protected internal override Expression VisitNew(NewExpression node) { }

	// RVA: 0x1D10510 Offset: 0x1D0F710 VA: 0x181D10510 Slot: 29
	protected internal override Expression VisitTypeBinary(TypeBinaryExpression node) { }

	// RVA: 0x1D10630 Offset: 0x1D0F830 VA: 0x181D10630 Slot: 30
	protected internal override Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x1D0E150 Offset: 0x1D0D350 VA: 0x181D0E150 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1D0EAB0 Offset: 0x1D0DCB0 VA: 0x181D0EAB0 Slot: 10
	protected internal override Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x1D0F3C0 Offset: 0x1D0E5C0 VA: 0x181D0F3C0 Slot: 15
	protected internal override Expression VisitLabel(LabelExpression node) { }

	// RVA: 0x1D0EEF0 Offset: 0x1D0E0F0 VA: 0x181D0EEF0 Slot: 12
	protected internal override Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x1D0F5A0 Offset: 0x1D0E7A0 VA: 0x181D0F5A0 Slot: 17
	protected internal override Expression VisitLoop(LoopExpression node) { }

	// RVA: 0x1D10340 Offset: 0x1D0F540 VA: 0x181D10340 Slot: 25
	protected override SwitchCase VisitSwitchCase(SwitchCase node) { }

	// RVA: 0x1D103F0 Offset: 0x1D0F5F0 VA: 0x181D103F0 Slot: 26
	protected internal override Expression VisitSwitch(SwitchExpression node) { }

	// RVA: 0x1D0E3D0 Offset: 0x1D0D5D0 VA: 0x181D0E3D0 Slot: 27
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x1D104B0 Offset: 0x1D0F6B0 VA: 0x181D104B0 Slot: 28
	protected internal override Expression VisitTry(TryExpression node) { }

	// RVA: 0x1D0F080 Offset: 0x1D0E280 VA: 0x181D0F080 Slot: 19
	protected internal override Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x1D0ECD0 Offset: 0x1D0DED0 VA: 0x181D0ECD0 Slot: 11
	protected internal override Expression VisitExtension(Expression node) { }

	// RVA: 0x1D0D470 Offset: 0x1D0C670 VA: 0x181D0D470
	private void DumpLabel(LabelTarget target) { }

	// RVA: 0x1D0D720 Offset: 0x1D0C920 VA: 0x181D0D720
	private static bool IsBool(Expression node) { }
}

// Namespace: System.Linq.Expressions
public enum ExpressionType // TypeDefIndex: 14755
{
	// Fields
	public int value__; // 0x0
	public const ExpressionType Add = 0;
	public const ExpressionType AddChecked = 1;
	public const ExpressionType And = 2;
	public const ExpressionType AndAlso = 3;
	public const ExpressionType ArrayLength = 4;
	public const ExpressionType ArrayIndex = 5;
	public const ExpressionType Call = 6;
	public const ExpressionType Coalesce = 7;
	public const ExpressionType Conditional = 8;
	public const ExpressionType Constant = 9;
	public const ExpressionType Convert = 10;
	public const ExpressionType ConvertChecked = 11;
	public const ExpressionType Divide = 12;
	public const ExpressionType Equal = 13;
	public const ExpressionType ExclusiveOr = 14;
	public const ExpressionType GreaterThan = 15;
	public const ExpressionType GreaterThanOrEqual = 16;
	public const ExpressionType Invoke = 17;
	public const ExpressionType Lambda = 18;
	public const ExpressionType LeftShift = 19;
	public const ExpressionType LessThan = 20;
	public const ExpressionType LessThanOrEqual = 21;
	public const ExpressionType ListInit = 22;
	public const ExpressionType MemberAccess = 23;
	public const ExpressionType MemberInit = 24;
	public const ExpressionType Modulo = 25;
	public const ExpressionType Multiply = 26;
	public const ExpressionType MultiplyChecked = 27;
	public const ExpressionType Negate = 28;
	public const ExpressionType UnaryPlus = 29;
	public const ExpressionType NegateChecked = 30;
	public const ExpressionType New = 31;
	public const ExpressionType NewArrayInit = 32;
	public const ExpressionType NewArrayBounds = 33;
	public const ExpressionType Not = 34;
	public const ExpressionType NotEqual = 35;
	public const ExpressionType Or = 36;
	public const ExpressionType OrElse = 37;
	public const ExpressionType Parameter = 38;
	public const ExpressionType Power = 39;
	public const ExpressionType Quote = 40;
	public const ExpressionType RightShift = 41;
	public const ExpressionType Subtract = 42;
	public const ExpressionType SubtractChecked = 43;
	public const ExpressionType TypeAs = 44;
	public const ExpressionType TypeIs = 45;
	public const ExpressionType Assign = 46;
	public const ExpressionType Block = 47;
	public const ExpressionType DebugInfo = 48;
	public const ExpressionType Decrement = 49;
	public const ExpressionType Dynamic = 50;
	public const ExpressionType Default = 51;
	public const ExpressionType Extension = 52;
	public const ExpressionType Goto = 53;
	public const ExpressionType Increment = 54;
	public const ExpressionType Index = 55;
	public const ExpressionType Label = 56;
	public const ExpressionType RuntimeVariables = 57;
	public const ExpressionType Loop = 58;
	public const ExpressionType Switch = 59;
	public const ExpressionType Throw = 60;
	public const ExpressionType Try = 61;
	public const ExpressionType Unbox = 62;
	public const ExpressionType AddAssign = 63;
	public const ExpressionType AndAssign = 64;
	public const ExpressionType DivideAssign = 65;
	public const ExpressionType ExclusiveOrAssign = 66;
	public const ExpressionType LeftShiftAssign = 67;
	public const ExpressionType ModuloAssign = 68;
	public const ExpressionType MultiplyAssign = 69;
	public const ExpressionType OrAssign = 70;
	public const ExpressionType PowerAssign = 71;
	public const ExpressionType RightShiftAssign = 72;
	public const ExpressionType SubtractAssign = 73;
	public const ExpressionType AddAssignChecked = 74;
	public const ExpressionType MultiplyAssignChecked = 75;
	public const ExpressionType SubtractAssignChecked = 76;
	public const ExpressionType PreIncrementAssign = 77;
	public const ExpressionType PreDecrementAssign = 78;
	public const ExpressionType PostIncrementAssign = 79;
	public const ExpressionType PostDecrementAssign = 80;
	public const ExpressionType TypeEqual = 81;
	public const ExpressionType OnesComplement = 82;
	public const ExpressionType IsTrue = 83;
	public const ExpressionType IsFalse = 84;
}

// Namespace: System.Linq.Expressions
public abstract class ExpressionVisitor // TypeDefIndex: 14756
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x1D126C0 Offset: 0x1D118C0 VA: 0x181D126C0 Slot: 4
	public virtual Expression Visit(Expression node) { }

	// RVA: 0x1D126F0 Offset: 0x1D118F0 VA: 0x181D126F0
	public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes) { }

	// RVA: 0x1D10FD0 Offset: 0x1D101D0 VA: 0x181D10FD0
	private Expression[] VisitArguments(IArgumentProvider nodes) { }

	// RVA: 0x1D12180 Offset: 0x1D11380 VA: 0x181D12180
	private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName) { }

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A61E0 Offset: 0x9A53E0 VA: 0x1809A61E0
	|-ExpressionVisitor.Visit<object>
	|
	|-RVA: 0x9A5DF0 Offset: 0x9A4FF0 VA: 0x1809A5DF0
	|-ExpressionVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T VisitAndConvert<T>(T node, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A5860 Offset: 0x9A4A60 VA: 0x1809A5860
	|-ExpressionVisitor.VisitAndConvert<object>
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A5980 Offset: 0x9A4B80 VA: 0x1809A5980
	|-ExpressionVisitor.VisitAndConvert<object>
	*/

	// RVA: 0x1D10FE0 Offset: 0x1D101E0 VA: 0x181D10FE0 Slot: 5
	protected internal virtual Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x1D110D0 Offset: 0x1D102D0 VA: 0x181D110D0 Slot: 6
	protected internal virtual Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1D11300 Offset: 0x1D10500 VA: 0x181D11300 Slot: 7
	protected internal virtual Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 8
	protected internal virtual Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 9
	protected internal virtual Expression VisitDebugInfo(DebugInfoExpression node) { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 10
	protected internal virtual Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x1CFEB20 Offset: 0x1CFDD20 VA: 0x181CFEB20 Slot: 11
	protected internal virtual Expression VisitExtension(Expression node) { }

	// RVA: 0x1D114E0 Offset: 0x1D106E0 VA: 0x181D114E0 Slot: 12
	protected internal virtual Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x1D116A0 Offset: 0x1D108A0 VA: 0x181D116A0 Slot: 13
	protected internal virtual Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 14
	protected virtual LabelTarget VisitLabelTarget(LabelTarget node) { }

	// RVA: 0x1D11740 Offset: 0x1D10940 VA: 0x181D11740 Slot: 15
	protected internal virtual Expression VisitLabel(LabelExpression node) { }

	// RVA: -1 Offset: -1 Slot: 16
	protected internal virtual Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A5D30 Offset: 0x9A4F30 VA: 0x1809A5D30
	|-ExpressionVisitor.VisitLambda<object>
	|
	|-RVA: 0x9A5C70 Offset: 0x9A4E70 VA: 0x1809A5C70
	|-ExpressionVisitor.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D11980 Offset: 0x1D10B80 VA: 0x181D11980 Slot: 17
	protected internal virtual Expression VisitLoop(LoopExpression node) { }

	// RVA: 0x1D11FA0 Offset: 0x1D111A0 VA: 0x181D11FA0 Slot: 18
	protected internal virtual Expression VisitMember(MemberExpression node) { }

	// RVA: 0x1D115D0 Offset: 0x1D107D0 VA: 0x181D115D0 Slot: 19
	protected internal virtual Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x1D12050 Offset: 0x1D11250 VA: 0x181D12050 Slot: 20
	protected internal virtual Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x1D12100 Offset: 0x1D11300 VA: 0x181D12100 Slot: 21
	protected internal virtual Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x1D12140 Offset: 0x1D11340 VA: 0x181D12140 Slot: 22
	protected internal virtual Expression VisitNew(NewExpression node) { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 23
	protected internal virtual Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x1D12190 Offset: 0x1D11390 VA: 0x181D12190 Slot: 24
	protected internal virtual Expression VisitRuntimeVariables(RuntimeVariablesExpression node) { }

	// RVA: 0x1D12210 Offset: 0x1D11410 VA: 0x181D12210 Slot: 25
	protected virtual SwitchCase VisitSwitchCase(SwitchCase node) { }

	// RVA: 0x1D12280 Offset: 0x1D11480 VA: 0x181D12280 Slot: 26
	protected internal virtual Expression VisitSwitch(SwitchExpression node) { }

	// RVA: 0x1D111C0 Offset: 0x1D103C0 VA: 0x181D111C0 Slot: 27
	protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x1D12400 Offset: 0x1D11600 VA: 0x181D12400 Slot: 28
	protected internal virtual Expression VisitTry(TryExpression node) { }

	// RVA: 0x1D12530 Offset: 0x1D11730 VA: 0x181D12530 Slot: 29
	protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node) { }

	// RVA: 0x1D12570 Offset: 0x1D11770 VA: 0x181D12570 Slot: 30
	protected internal virtual Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x1D11CA0 Offset: 0x1D10EA0 VA: 0x181D11CA0 Slot: 31
	protected internal virtual Expression VisitMemberInit(MemberInitExpression node) { }

	// RVA: 0x1D11800 Offset: 0x1D10A00 VA: 0x181D11800 Slot: 32
	protected internal virtual Expression VisitListInit(ListInitExpression node) { }

	// RVA: 0x1D11450 Offset: 0x1D10650 VA: 0x181D11450 Slot: 33
	protected virtual ElementInit VisitElementInit(ElementInit node) { }

	// RVA: 0x1D11B00 Offset: 0x1D10D00 VA: 0x181D11B00 Slot: 34
	protected virtual MemberBinding VisitMemberBinding(MemberBinding node) { }

	// RVA: 0x1D11A70 Offset: 0x1D10C70 VA: 0x181D11A70 Slot: 35
	protected virtual MemberAssignment VisitMemberAssignment(MemberAssignment node) { }

	// RVA: 0x1D11EE0 Offset: 0x1D110E0 VA: 0x181D11EE0 Slot: 36
	protected virtual MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node) { }

	// RVA: 0x1D11E20 Offset: 0x1D11020 VA: 0x181D11E20 Slot: 37
	protected virtual MemberListBinding VisitMemberListBinding(MemberListBinding node) { }

	// RVA: 0x1D10EB0 Offset: 0x1D100B0 VA: 0x181D10EB0
	private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after) { }

	// RVA: 0x1D10BB0 Offset: 0x1D0FDB0 VA: 0x181D10BB0
	private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after) { }

	// RVA: 0x1D10E20 Offset: 0x1D10020 VA: 0x181D10E20
	private static SwitchExpression ValidateSwitch(SwitchExpression before, SwitchExpression after) { }

	// RVA: 0x1D10D50 Offset: 0x1D0FF50 VA: 0x181D10D50
	private static void ValidateChildType(Type before, Type after, string methodName) { }

	// RVA: 0x1D05120 Offset: 0x1D04320 VA: 0x181D05120 Slot: 38
	protected internal virtual Expression VisitDynamic(DynamicExpression node) { }
}

// Namespace: System.Linq.Expressions
public enum GotoExpressionKind // TypeDefIndex: 14757
{
	// Fields
	public int value__; // 0x0
	public const GotoExpressionKind Goto = 0;
	public const GotoExpressionKind Return = 1;
	public const GotoExpressionKind Break = 2;
	public const GotoExpressionKind Continue = 3;
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.GotoExpressionProxy))]
public sealed class GotoExpression : Expression // TypeDefIndex: 14758
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Value>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly GotoExpressionKind <Kind>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Value { get; }
	public LabelTarget Target { get; }
	public GotoExpressionKind Kind { get; }

	// Methods

	// RVA: 0x1D12C70 Offset: 0x1D11E70 VA: 0x181D12C70
	internal void .ctor(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1D12D30 Offset: 0x1D11F30 VA: 0x181D12D30 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Expression get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public LabelTarget get_Target() { }

	[CompilerGenerated]
	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public GotoExpressionKind get_Kind() { }

	// RVA: 0x1D12B80 Offset: 0x1D11D80 VA: 0x181D12B80 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D12BB0 Offset: 0x1D11DB0 VA: 0x181D12BB0
	public GotoExpression Update(LabelTarget target, Expression value) { }

	// RVA: 0x1D12D00 Offset: 0x1D11F00 VA: 0x181D12D00
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
public interface IArgumentProvider // TypeDefIndex: 14759
{
	// Properties
	public abstract int ArgumentCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Expression GetArgument(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ArgumentCount();
}

// Namespace: System.Linq.Expressions
public interface IDynamicExpression : IArgumentProvider // TypeDefIndex: 14760
{
	// Properties
	public abstract Type DelegateType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_DelegateType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Expression Rewrite(Expression[] args);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object CreateCallSite();
}

// Namespace: System.Linq.Expressions
internal interface IParameterProvider // TypeDefIndex: 14761
{
	// Properties
	public abstract int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ParameterExpression GetParameter(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ParameterCount();
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.IndexExpressionProxy))]
public sealed class IndexExpression : Expression, IArgumentProvider // TypeDefIndex: 14762
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x10
	[CompilerGenerated]
	private readonly Expression <Object>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly PropertyInfo <Indexer>k__BackingField; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public Expression Object { get; }
	public PropertyInfo Indexer { get; }
	public ReadOnlyCollection<Expression> Arguments { get; }
	public int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D13030 Offset: 0x1D12230 VA: 0x181D13030
	internal void .ctor(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments) { }

	// RVA: 0x1D13150 Offset: 0x1D12350 VA: 0x181D13150 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1D13160 Offset: 0x1D12360 VA: 0x181D13160 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Expression get_Object() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public PropertyInfo get_Indexer() { }

	// RVA: 0x1D13110 Offset: 0x1D12310 VA: 0x181D13110
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1D12F00 Offset: 0x1D12100 VA: 0x181D12F00
	public IndexExpression Update(Expression object, IEnumerable<Expression> arguments) { }

	// RVA: 0x1D12E20 Offset: 0x1D12020 VA: 0x181D12E20 Slot: 10
	public Expression GetArgument(int index) { }

	// RVA: 0x1D130C0 Offset: 0x1D122C0 VA: 0x181D130C0 Slot: 11
	public int get_ArgumentCount() { }

	// RVA: 0x1D12DF0 Offset: 0x1D11FF0 VA: 0x181D12DF0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D12E80 Offset: 0x1D12080 VA: 0x181D12E80
	internal Expression Rewrite(Expression instance, Expression[] arguments) { }

	// RVA: 0x1D13000 Offset: 0x1D12200 VA: 0x181D13000
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.InvocationExpressionProxy))]
public class InvocationExpression : Expression, IArgumentProvider // TypeDefIndex: 14763
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Expression { get; }
	public ReadOnlyCollection<Expression> Arguments { get; }
	[ExcludeFromCodeCoverage]
	public virtual int ArgumentCount { get; }
	internal LambdaExpression LambdaOperand { get; }

	// Methods

	// RVA: 0x1D132D0 Offset: 0x1D124D0 VA: 0x181D132D0
	internal void .ctor(Expression expression, Type returnType) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x18A5990 Offset: 0x18A4B90 VA: 0x1818A5990 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Expression get_Expression() { }

	// RVA: 0x7F66E0 Offset: 0x7F58E0 VA: 0x1807F66E0
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1D141B0 Offset: 0x1D133B0 VA: 0x181D141B0
	public InvocationExpression Update(Expression expression, IEnumerable<Expression> arguments) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D14150 Offset: 0x1D13350 VA: 0x181D14150 Slot: 12
	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D14120 Offset: 0x1D13320 VA: 0x181D14120 Slot: 13
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x1D142C0 Offset: 0x1D134C0 VA: 0x181D142C0 Slot: 14
	public virtual int get_ArgumentCount() { }

	// RVA: 0x1D140F0 Offset: 0x1D132F0 VA: 0x181D140F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D14180 Offset: 0x1D13380 VA: 0x181D14180 Slot: 15
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

	// RVA: 0x1D142F0 Offset: 0x1D134F0 VA: 0x181D142F0
	internal LambdaExpression get_LambdaOperand() { }

	// RVA: 0x1D14290 Offset: 0x1D13490 VA: 0x181D14290
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpressionN : InvocationExpression // TypeDefIndex: 14764
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D13FC0 Offset: 0x1D131C0 VA: 0x181D13FC0
	public void .ctor(Expression lambda, IReadOnlyList<Expression> arguments, Type returnType) { }

	// RVA: 0x1D13F10 Offset: 0x1D13110 VA: 0x181D13F10 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D13EB0 Offset: 0x1D130B0 VA: 0x181D13EB0 Slot: 13
	public override Expression GetArgument(int index) { }

	// RVA: 0x1D14040 Offset: 0x1D13240 VA: 0x181D14040 Slot: 14
	public override int get_ArgumentCount() { }

	// RVA: 0x1D13F50 Offset: 0x1D13150 VA: 0x181D13F50 Slot: 15
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression0 : InvocationExpression // TypeDefIndex: 14765
{
	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D132D0 Offset: 0x1D124D0 VA: 0x181D132D0
	public void .ctor(Expression lambda, Type returnType) { }

	// RVA: 0x1D13230 Offset: 0x1D12430 VA: 0x181D13230 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D131E0 Offset: 0x1D123E0 VA: 0x181D131E0 Slot: 13
	public override Expression GetArgument(int index) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 14
	public override int get_ArgumentCount() { }

	// RVA: 0x1D13280 Offset: 0x1D12480 VA: 0x181D13280 Slot: 15
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression1 : InvocationExpression // TypeDefIndex: 14766
{
	// Fields
	private object _arg0; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D13480 Offset: 0x1D12680 VA: 0x181D13480
	public void .ctor(Expression lambda, Type returnType, Expression arg0) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D13340 Offset: 0x1D12540 VA: 0x181D13340 Slot: 13
	public override Expression GetArgument(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 14
	public override int get_ArgumentCount() { }

	// RVA: 0x1D133E0 Offset: 0x1D125E0 VA: 0x181D133E0 Slot: 15
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression2 : InvocationExpression // TypeDefIndex: 14767
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D13680 Offset: 0x1D12880 VA: 0x181D13680
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D13500 Offset: 0x1D12700 VA: 0x181D13500 Slot: 13
	public override Expression GetArgument(int index) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 14
	public override int get_ArgumentCount() { }

	// RVA: 0x1D135B0 Offset: 0x1D127B0 VA: 0x181D135B0 Slot: 15
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression3 : InvocationExpression // TypeDefIndex: 14768
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D138D0 Offset: 0x1D12AD0 VA: 0x181D138D0
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D13710 Offset: 0x1D12910 VA: 0x181D13710 Slot: 13
	public override Expression GetArgument(int index) { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 14
	public override int get_ArgumentCount() { }

	// RVA: 0x1D137D0 Offset: 0x1D129D0 VA: 0x181D137D0 Slot: 15
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression4 : InvocationExpression // TypeDefIndex: 14769
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30
	private readonly Expression _arg3; // 0x38

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D13B50 Offset: 0x1D12D50 VA: 0x181D13B50
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D13960 Offset: 0x1D12B60 VA: 0x181D13960 Slot: 13
	public override Expression GetArgument(int index) { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 14
	public override int get_ArgumentCount() { }

	// RVA: 0x1D13A30 Offset: 0x1D12C30 VA: 0x181D13A30 Slot: 15
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression5 : InvocationExpression // TypeDefIndex: 14770
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30
	private readonly Expression _arg3; // 0x38
	private readonly Expression _arg4; // 0x40

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D13E10 Offset: 0x1D13010 VA: 0x181D13E10
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D13BF0 Offset: 0x1D12DF0 VA: 0x181D13BF0 Slot: 13
	public override Expression GetArgument(int index) { }

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 14
	public override int get_ArgumentCount() { }

	// RVA: 0x1D13CE0 Offset: 0x1D12EE0 VA: 0x181D13CE0 Slot: 15
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.LabelExpressionProxy))]
public sealed class LabelExpression : Expression // TypeDefIndex: 14771
{
	// Fields
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <DefaultValue>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public LabelTarget Target { get; }
	public Expression DefaultValue { get; }

	// Methods

	// RVA: 0x1D14550 Offset: 0x1D13750 VA: 0x181D14550
	internal void .ctor(LabelTarget label, Expression defaultValue) { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0xAA0130 Offset: 0xA9F330 VA: 0x180AA0130 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public LabelTarget get_Target() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Expression get_DefaultValue() { }

	// RVA: 0x1D14490 Offset: 0x1D13690 VA: 0x181D14490 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D144C0 Offset: 0x1D136C0 VA: 0x181D144C0
	public LabelExpression Update(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x1D145C0 Offset: 0x1D137C0 VA: 0x181D145C0
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
public sealed class LabelTarget // TypeDefIndex: 14772
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x18

	// Properties
	public string Name { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x162EF30 Offset: 0x162E130 VA: 0x18162EF30
	internal void .ctor(Type type, string name) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Type get_Type() { }

	// RVA: 0x1D145F0 Offset: 0x1D137F0 VA: 0x181D145F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D14640 Offset: 0x1D13840 VA: 0x181D14640
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.LambdaExpressionProxy))]
public abstract class LambdaExpression : Expression, IParameterProvider // TypeDefIndex: 14773
{
	// Fields
	private readonly Expression _body; // 0x10

	// Properties
	public sealed override Type Type { get; }
	internal abstract Type TypeCore { get; }
	internal abstract Type PublicType { get; }
	public sealed override ExpressionType NodeType { get; }
	public ReadOnlyCollection<ParameterExpression> Parameters { get; }
	public string Name { get; }
	internal virtual string NameCore { get; }
	public Expression Body { get; }
	public Type ReturnType { get; }
	public bool TailCall { get; }
	internal virtual bool TailCallCore { get; }
	[ExcludeFromCodeCoverage]
	private int System.Linq.Expressions.IParameterProvider.ParameterCount { get; }
	[ExcludeFromCodeCoverage]
	internal virtual int ParameterCount { get; }

	// Methods

	// RVA: 0x1D148F0 Offset: 0x1D13AF0 VA: 0x181D148F0
	internal void .ctor(Expression body) { }

	// RVA: 0x7F66E0 Offset: 0x7F58E0 VA: 0x1807F66E0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Type get_TypeCore();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Type get_PublicType();

	// RVA: 0x1698190 Offset: 0x1697390 VA: 0x181698190 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1D14980 Offset: 0x1D13B80 VA: 0x181D14980
	public ReadOnlyCollection<ParameterExpression> get_Parameters() { }

	// RVA: 0x19B4EE0 Offset: 0x19B40E0 VA: 0x1819B4EE0
	public string get_Name() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 14
	internal virtual string get_NameCore() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Expression get_Body() { }

	// RVA: 0x1D149A0 Offset: 0x1D13BA0 VA: 0x181D149A0
	public Type get_ReturnType() { }

	// RVA: 0x727AE0 Offset: 0x726CE0 VA: 0x180727AE0
	public bool get_TailCall() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 15
	internal virtual bool get_TailCallCore() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D14840 Offset: 0x1D13A40 VA: 0x181D14840 Slot: 16
	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeParameters() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D148A0 Offset: 0x1D13AA0 VA: 0x181D148A0 Slot: 10
	private ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(int index) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D14870 Offset: 0x1D13A70 VA: 0x181D14870 Slot: 17
	internal virtual ParameterExpression GetParameter(int index) { }

	// RVA: 0x7F68D0 Offset: 0x7F5AD0 VA: 0x1807F68D0 Slot: 11
	private int System.Linq.Expressions.IParameterProvider.get_ParameterCount() { }

	// RVA: 0x1D14950 Offset: 0x1D13B50 VA: 0x181D14950 Slot: 18
	internal virtual int get_ParameterCount() { }

	// RVA: 0x1D147C0 Offset: 0x1D139C0 VA: 0x181D147C0
	public Delegate Compile() { }

	// RVA: 0x1D147C0 Offset: 0x1D139C0 VA: 0x181D147C0
	public Delegate Compile(bool preferInterpretation) { }

	// RVA: 0x1D147C0 Offset: 0x1D139C0 VA: 0x181D147C0
	public Delegate Compile(DebugInfoGenerator debugInfoGenerator) { }

	// RVA: 0x1D148C0 Offset: 0x1D13AC0 VA: 0x181D148C0
	internal void .ctor() { }

	// RVA: 0x1D14790 Offset: 0x1D13990 VA: 0x181D14790
	public void CompileToMethod(MethodBuilder method) { }

	// RVA: 0x1D14760 Offset: 0x1D13960 VA: 0x181D14760
	public void CompileToMethod(MethodBuilder method, DebugInfoGenerator debugInfoGenerator) { }
}

// Namespace: System.Linq.Expressions
public class Expression<TDelegate> : LambdaExpression // TypeDefIndex: 14774
{
	// Properties
	internal sealed override Type TypeCore { get; }
	internal override Type PublicType { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Expression body) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2C70 Offset: 0x11F1E70 VA: 0x1811F2C70
	|-Expression<object>..ctor
	|-Expression<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	internal sealed override Type get_TypeCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2DA0 Offset: 0x11F1FA0 VA: 0x1811F2DA0
	|-Expression<object>.get_TypeCore
	|
	|-RVA: 0x11F2D40 Offset: 0x11F1F40 VA: 0x1811F2D40
	|-Expression<__Il2CppFullySharedGenericType>.get_TypeCore
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override Type get_PublicType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2C80 Offset: 0x11F1E80 VA: 0x1811F2C80
	|-Expression<object>.get_PublicType
	|
	|-RVA: 0x11F2CE0 Offset: 0x11F1EE0 VA: 0x1811F2CE0
	|-Expression<__Il2CppFullySharedGenericType>.get_PublicType
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F26C0 Offset: 0x11F18C0 VA: 0x1811F26C0
	|-Expression<object>.Compile
	|
	|-RVA: 0x11F2560 Offset: 0x11F1760 VA: 0x1811F2560
	|-Expression<__Il2CppFullySharedGenericType>.Compile
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile(bool preferInterpretation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2490 Offset: 0x11F1690 VA: 0x1811F2490
	|-Expression<object>.Compile
	|
	|-RVA: 0x11F27A0 Offset: 0x11F19A0 VA: 0x1811F27A0
	|-Expression<__Il2CppFullySharedGenericType>.Compile
	*/

	// RVA: -1 Offset: -1
	public Expression<TDelegate> Update(Expression body, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2B30 Offset: 0x11F1D30 VA: 0x1811F2B30
	|-Expression<object>.Update
	|
	|-RVA: 0x11F29F0 Offset: 0x11F1BF0 VA: 0x1811F29F0
	|-Expression<__Il2CppFullySharedGenericType>.Update
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 19
	internal virtual bool SameParameters(ICollection<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F29D0 Offset: 0x11F1BD0 VA: 0x1811F29D0
	|-Expression<object>.SameParameters
	|-Expression<__Il2CppFullySharedGenericType>.SameParameters
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 20
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F29B0 Offset: 0x11F1BB0 VA: 0x1811F29B0
	|-Expression<object>.Rewrite
	|-Expression<__Il2CppFullySharedGenericType>.Rewrite
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2430 Offset: 0x11F1630 VA: 0x1811F2430
	|-Expression<object>.Accept
	|-Expression<__Il2CppFullySharedGenericType>.Accept
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile(DebugInfoGenerator debugInfoGenerator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F28C0 Offset: 0x11F1AC0 VA: 0x1811F28C0
	|-Expression<object>.Compile
	|
	|-RVA: 0x11F2620 Offset: 0x11F1820 VA: 0x1811F2620
	|-Expression<__Il2CppFullySharedGenericType>.Compile
	*/

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04170 Offset: 0xD03370 VA: 0x180D04170
	|-Expression<object>..ctor
	|-Expression<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Linq.Expressions
internal static class ExpressionCreator<TDelegate> // TypeDefIndex: 14775
{
	// Methods

	// RVA: -1 Offset: -1
	public static LambdaExpression CreateExpressionFunc(Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1CE0 Offset: 0x11F0EE0 VA: 0x1811F1CE0
	|-ExpressionCreator<__Il2CppFullySharedGenericType>.CreateExpressionFunc
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression0<TDelegate> : Expression<TDelegate> // TypeDefIndex: 14776
{
	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3F990 Offset: 0xC3EB90 VA: 0x180C3F990
	|-Expression0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	|-Expression0<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override bool SameParameters(ICollection<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0F10 Offset: 0x11F0110 VA: 0x1811F0F10
	|-Expression0<__Il2CppFullySharedGenericType>.SameParameters
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0E60 Offset: 0x11F0060 VA: 0x1811F0E60
	|-Expression0<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeParameters() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0E10 Offset: 0x11F0010 VA: 0x1811F0E10
	|-Expression0<__Il2CppFullySharedGenericType>.GetOrMakeParameters
	*/

	// RVA: -1 Offset: -1 Slot: 20
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0E90 Offset: 0x11F0090 VA: 0x1811F0E90
	|-Expression0<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression1<TDelegate> : Expression<TDelegate> // TypeDefIndex: 14777
{
	// Fields
	private object _par0; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1270 Offset: 0x11F0470 VA: 0x1811F1270
	|-Expression1<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	|-Expression1<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0F70 Offset: 0x11F0170 VA: 0x1811F0F70
	|-Expression1<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override bool SameParameters(ICollection<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1100 Offset: 0x11F0300 VA: 0x1811F1100
	|-Expression1<__Il2CppFullySharedGenericType>.SameParameters
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeParameters() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0F60 Offset: 0x11F0160 VA: 0x1811F0F60
	|-Expression1<__Il2CppFullySharedGenericType>.GetOrMakeParameters
	*/

	// RVA: -1 Offset: -1 Slot: 20
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0FF0 Offset: 0x11F01F0 VA: 0x1811F0FF0
	|-Expression1<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression2<TDelegate> : Expression<TDelegate> // TypeDefIndex: 14778
{
	// Fields
	private object _par0; // 0x0
	private readonly ParameterExpression _par1; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0, ParameterExpression par1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1720 Offset: 0x11F0920 VA: 0x1811F1720
	|-Expression2<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920
	|-Expression2<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F12B0 Offset: 0x11F04B0 VA: 0x1811F12B0
	|-Expression2<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override bool SameParameters(ICollection<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F14F0 Offset: 0x11F06F0 VA: 0x1811F14F0
	|-Expression2<__Il2CppFullySharedGenericType>.SameParameters
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeParameters() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0F60 Offset: 0x11F0160 VA: 0x1811F0F60
	|-Expression2<__Il2CppFullySharedGenericType>.GetOrMakeParameters
	*/

	// RVA: -1 Offset: -1 Slot: 20
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1350 Offset: 0x11F0550 VA: 0x1811F1350
	|-Expression2<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression3<TDelegate> : Expression<TDelegate> // TypeDefIndex: 14779
{
	// Fields
	private object _par0; // 0x0
	private readonly ParameterExpression _par1; // 0x0
	private readonly ParameterExpression _par2; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1C80 Offset: 0x11F0E80 VA: 0x1811F1C80
	|-Expression3<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530
	|-Expression3<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1770 Offset: 0x11F0970 VA: 0x1811F1770
	|-Expression3<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override bool SameParameters(ICollection<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1A00 Offset: 0x11F0C00 VA: 0x1811F1A00
	|-Expression3<__Il2CppFullySharedGenericType>.SameParameters
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeParameters() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0F60 Offset: 0x11F0160 VA: 0x1811F0F60
	|-Expression3<__Il2CppFullySharedGenericType>.GetOrMakeParameters
	*/

	// RVA: -1 Offset: -1 Slot: 20
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1820 Offset: 0x11F0A20 VA: 0x1811F1820
	|-Expression3<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal class ExpressionN<TDelegate> : Expression<TDelegate> // TypeDefIndex: 14780
{
	// Fields
	private IReadOnlyList<ParameterExpression> _parameters; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, IReadOnlyList<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1270 Offset: 0x11F0470 VA: 0x1811F1270
	|-ExpressionN<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F23E0 Offset: 0x11F15E0 VA: 0x1811F23E0
	|-ExpressionN<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2210 Offset: 0x11F1410 VA: 0x1811F2210
	|-ExpressionN<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override bool SameParameters(ICollection<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2390 Offset: 0x11F1590 VA: 0x1811F2390
	|-ExpressionN<__Il2CppFullySharedGenericType>.SameParameters
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeParameters() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F21D0 Offset: 0x11F13D0 VA: 0x1811F21D0
	|-ExpressionN<__Il2CppFullySharedGenericType>.GetOrMakeParameters
	*/

	// RVA: -1 Offset: -1 Slot: 20
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F22C0 Offset: 0x11F14C0 VA: 0x1811F22C0
	|-ExpressionN<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class FullExpression<TDelegate> : ExpressionN<TDelegate> // TypeDefIndex: 14781
{
	// Fields
	[CompilerGenerated]
	private readonly string <NameCore>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <TailCallCore>k__BackingField; // 0x0

	// Properties
	internal override string NameCore { get; }
	internal override bool TailCallCore { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1201D10 Offset: 0x1200F10 VA: 0x181201D10
	|-FullExpression<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 14
	internal override string get_NameCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-FullExpression<__Il2CppFullySharedGenericType>.get_NameCore
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	internal override bool get_TailCallCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	|-FullExpression<__Il2CppFullySharedGenericType>.get_TailCallCore
	*/
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ListInitExpressionProxy))]
public sealed class ListInitExpression : Expression // TypeDefIndex: 14782
{
	// Fields
	[CompilerGenerated]
	private readonly NewExpression <NewExpression>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<ElementInit> <Initializers>k__BackingField; // 0x18

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public override bool CanReduce { get; }
	public NewExpression NewExpression { get; }
	public ReadOnlyCollection<ElementInit> Initializers { get; }

	// Methods

	// RVA: 0x1D14BB0 Offset: 0x1D13DB0 VA: 0x181D14BB0
	internal void .ctor(NewExpression newExpression, ReadOnlyCollection<ElementInit> initializers) { }

	// RVA: 0x16FD490 Offset: 0x16FC690 VA: 0x1816FD490 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	public override bool get_CanReduce() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public NewExpression get_NewExpression() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ReadOnlyCollection<ElementInit> get_Initializers() { }

	// RVA: 0x1D14A90 Offset: 0x1D13C90 VA: 0x181D14A90 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D14AC0 Offset: 0x1D13CC0 VA: 0x181D14AC0 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1D14AE0 Offset: 0x1D13CE0 VA: 0x181D14AE0
	public ListInitExpression Update(NewExpression newExpression, IEnumerable<ElementInit> initializers) { }

	// RVA: 0x1D14C20 Offset: 0x1D13E20 VA: 0x181D14C20
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.LoopExpressionProxy))]
public sealed class LoopExpression : Expression // TypeDefIndex: 14783
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly LabelTarget <BreakLabel>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly LabelTarget <ContinueLabel>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public LabelTarget BreakLabel { get; }
	public LabelTarget ContinueLabel { get; }

	// Methods

	// RVA: 0x1D14DA0 Offset: 0x1D13FA0 VA: 0x181D14DA0
	internal void .ctor(Expression body, LabelTarget break, LabelTarget continue) { }

	// RVA: 0x1D14E30 Offset: 0x1D14030 VA: 0x181D14E30 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1D14E20 Offset: 0x1D14020 VA: 0x181D14E20 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public LabelTarget get_BreakLabel() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public LabelTarget get_ContinueLabel() { }

	// RVA: 0x1D14CB0 Offset: 0x1D13EB0 VA: 0x181D14CB0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D14CE0 Offset: 0x1D13EE0 VA: 0x181D14CE0
	public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body) { }

	// RVA: 0x1D14D70 Offset: 0x1D13F70 VA: 0x181D14D70
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
public sealed class MemberAssignment : MemberBinding // TypeDefIndex: 14784
{
	// Fields
	private readonly Expression _expression; // 0x20

	// Properties
	public Expression Expression { get; }

	// Methods

	// RVA: 0x1D14F60 Offset: 0x1D14160 VA: 0x181D14F60
	internal void .ctor(MemberInfo member, Expression expression) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Expression get_Expression() { }

	// RVA: 0x1D14EB0 Offset: 0x1D140B0 VA: 0x181D14EB0
	public MemberAssignment Update(Expression expression) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	internal override void ValidateAsDefinedHere(int index) { }

	// RVA: 0x1D14F30 Offset: 0x1D14130 VA: 0x181D14F30
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
public enum MemberBindingType // TypeDefIndex: 14785
{
	// Fields
	public int value__; // 0x0
	public const MemberBindingType Assignment = 0;
	public const MemberBindingType MemberBinding = 1;
	public const MemberBindingType ListBinding = 2;
}

// Namespace: System.Linq.Expressions
public abstract class MemberBinding // TypeDefIndex: 14786
{
	// Fields
	[CompilerGenerated]
	private readonly MemberBindingType <BindingType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly MemberInfo <Member>k__BackingField; // 0x18

	// Properties
	public MemberBindingType BindingType { get; }
	public MemberInfo Member { get; }

	// Methods

	[Obsolete("Do not use this constructor. It will be removed in future releases.")]
	// RVA: 0x7B8500 Offset: 0x7B7700 VA: 0x1807B8500
	protected void .ctor(MemberBindingType type, MemberInfo member) { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public MemberBindingType get_BindingType() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public MemberInfo get_Member() { }

	// RVA: 0x1D0D830 Offset: 0x1D0CA30 VA: 0x181D0D830 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D14FA0 Offset: 0x1D141A0 VA: 0x181D14FA0 Slot: 4
	internal virtual void ValidateAsDefinedHere(int index) { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.MemberExpressionProxy))]
public class MemberExpression : Expression // TypeDefIndex: 14787
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x10

	// Properties
	public MemberInfo Member { get; }
	public Expression Expression { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x577700 Offset: 0x576900 VA: 0x180577700
	public MemberInfo get_Member() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Expression get_Expression() { }

	// RVA: 0x1D15450 Offset: 0x1D14650 VA: 0x181D15450
	internal void .ctor(Expression expression) { }

	// RVA: 0x1D15130 Offset: 0x1D14330 VA: 0x181D15130
	internal static PropertyExpression Make(Expression expression, PropertyInfo property) { }

	// RVA: 0x1D15090 Offset: 0x1D14290 VA: 0x181D15090
	internal static FieldExpression Make(Expression expression, FieldInfo field) { }

	// RVA: 0x1D151D0 Offset: 0x1D143D0 VA: 0x181D151D0
	internal static MemberExpression Make(Expression expression, MemberInfo member) { }

	// RVA: 0x1717A10 Offset: 0x1716C10 VA: 0x181717A10 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D15060 Offset: 0x1D14260 VA: 0x181D15060 Slot: 10
	internal virtual MemberInfo GetMember() { }

	// RVA: 0x1D15030 Offset: 0x1D14230 VA: 0x181D15030 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D153C0 Offset: 0x1D145C0 VA: 0x181D153C0
	public MemberExpression Update(Expression expression) { }

	// RVA: 0x1D154B0 Offset: 0x1D146B0 VA: 0x181D154B0
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal sealed class FieldExpression : MemberExpression // TypeDefIndex: 14788
{
	// Fields
	private readonly FieldInfo _field; // 0x18

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1D129B0 Offset: 0x1D11BB0 VA: 0x181D129B0
	public void .ctor(Expression expression, FieldInfo member) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	internal override MemberInfo GetMember() { }

	// RVA: 0x1D12A20 Offset: 0x1D11C20 VA: 0x181D12A20 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal sealed class PropertyExpression : MemberExpression // TypeDefIndex: 14789
{
	// Fields
	private readonly PropertyInfo _property; // 0x18

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1D129B0 Offset: 0x1D11BB0 VA: 0x181D129B0
	public void .ctor(Expression expression, PropertyInfo member) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	internal override MemberInfo GetMember() { }

	// RVA: 0x1D16270 Offset: 0x1D15470 VA: 0x181D16270 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.MemberInitExpressionProxy))]
public sealed class MemberInitExpression : Expression // TypeDefIndex: 14790
{
	// Fields
	[CompilerGenerated]
	private readonly NewExpression <NewExpression>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<MemberBinding> <Bindings>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public override bool CanReduce { get; }
	public sealed override ExpressionType NodeType { get; }
	public NewExpression NewExpression { get; }
	public ReadOnlyCollection<MemberBinding> Bindings { get; }

	// Methods

	// RVA: 0x1D15FF0 Offset: 0x1D151F0 VA: 0x181D15FF0
	internal void .ctor(NewExpression newExpression, ReadOnlyCollection<MemberBinding> bindings) { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0xAA00D0 Offset: 0xA9F2D0 VA: 0x180AA00D0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public NewExpression get_NewExpression() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ReadOnlyCollection<MemberBinding> get_Bindings() { }

	// RVA: 0x1D15540 Offset: 0x1D14740 VA: 0x181D15540 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D15F00 Offset: 0x1D15100 VA: 0x181D15F00 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1D15A70 Offset: 0x1D14C70 VA: 0x181D15A70
	private static Expression ReduceMemberInit(Expression objExpression, ReadOnlyCollection<MemberBinding> bindings, bool keepOnStack) { }

	// RVA: 0x1D15570 Offset: 0x1D14770 VA: 0x181D15570
	internal static Expression ReduceListInit(Expression listExpression, ReadOnlyCollection<ElementInit> initializers, bool keepOnStack) { }

	// RVA: 0x1D158B0 Offset: 0x1D14AB0 VA: 0x181D158B0
	internal static Expression ReduceMemberBinding(ParameterExpression objVar, MemberBinding binding) { }

	// RVA: 0x1D15F20 Offset: 0x1D15120 VA: 0x181D15F20
	public MemberInitExpression Update(NewExpression newExpression, IEnumerable<MemberBinding> bindings) { }

	// RVA: 0x1D16060 Offset: 0x1D15260 VA: 0x181D16060
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
public sealed class MemberListBinding : MemberBinding // TypeDefIndex: 14791
{
	// Fields
	[CompilerGenerated]
	private readonly ReadOnlyCollection<ElementInit> <Initializers>k__BackingField; // 0x20

	// Properties
	public ReadOnlyCollection<ElementInit> Initializers { get; }

	// Methods

	// RVA: 0x1D2BE50 Offset: 0x1D2B050 VA: 0x181D2BE50
	internal void .ctor(MemberInfo member, ReadOnlyCollection<ElementInit> initializers) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ReadOnlyCollection<ElementInit> get_Initializers() { }

	// RVA: 0x1D2BD70 Offset: 0x1D2AF70 VA: 0x181D2BD70
	public MemberListBinding Update(IEnumerable<ElementInit> initializers) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	internal override void ValidateAsDefinedHere(int index) { }

	// RVA: 0x1D2BE20 Offset: 0x1D2B020 VA: 0x181D2BE20
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
public sealed class MemberMemberBinding : MemberBinding // TypeDefIndex: 14792
{
	// Fields
	[CompilerGenerated]
	private readonly ReadOnlyCollection<MemberBinding> <Bindings>k__BackingField; // 0x20

	// Properties
	public ReadOnlyCollection<MemberBinding> Bindings { get; }

	// Methods

	// RVA: 0x1D2BF30 Offset: 0x1D2B130 VA: 0x181D2BF30
	internal void .ctor(MemberInfo member, ReadOnlyCollection<MemberBinding> bindings) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ReadOnlyCollection<MemberBinding> get_Bindings() { }

	// RVA: 0x1D2BE80 Offset: 0x1D2B080 VA: 0x181D2BE80
	public MemberMemberBinding Update(IEnumerable<MemberBinding> bindings) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	internal override void ValidateAsDefinedHere(int index) { }

	// RVA: 0x1D2BF60 Offset: 0x1D2B160 VA: 0x181D2BF60
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.MethodCallExpressionProxy))]
public class MethodCallExpression : Expression, IArgumentProvider // TypeDefIndex: 14793
{
	// Fields
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; // 0x10

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public MethodInfo Method { get; }
	public Expression Object { get; }
	public ReadOnlyCollection<Expression> Arguments { get; }
	[ExcludeFromCodeCoverage]
	public virtual int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D2C0D0 Offset: 0x1D2B2D0 VA: 0x181D2C0D0
	internal void .ctor(MethodInfo method) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	internal virtual Expression GetInstance() { }

	// RVA: 0x16F8530 Offset: 0x16F7730 VA: 0x1816F8530 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1D2DB70 Offset: 0x1D2CD70 VA: 0x181D2DB70 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public MethodInfo get_Method() { }

	// RVA: 0x7F66E0 Offset: 0x7F58E0 VA: 0x1807F66E0
	public Expression get_Object() { }

	// RVA: 0x19B4EE0 Offset: 0x19B40E0 VA: 0x1819B4EE0
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1D2DA00 Offset: 0x1D2CC00 VA: 0x181D2DA00
	public MethodCallExpression Update(Expression object, IEnumerable<Expression> arguments) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D2D9D0 Offset: 0x1D2CBD0 VA: 0x181D2D9D0 Slot: 13
	internal virtual bool SameArguments(ICollection<Expression> arguments) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D2D970 Offset: 0x1D2CB70 VA: 0x181D2D970 Slot: 14
	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D2D910 Offset: 0x1D2CB10 VA: 0x181D2D910 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D2D9A0 Offset: 0x1D2CBA0 VA: 0x181D2D9A0 Slot: 15
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1D2D940 Offset: 0x1D2CB40 VA: 0x181D2D940 Slot: 16
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x1D2DB40 Offset: 0x1D2CD40 VA: 0x181D2DB40 Slot: 17
	public virtual int get_ArgumentCount() { }

	// RVA: 0x1D2DB10 Offset: 0x1D2CD10 VA: 0x181D2DB10
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider // TypeDefIndex: 14794
{
	// Fields
	private readonly Expression _instance; // 0x18

	// Methods

	// RVA: 0x1D25790 Offset: 0x1D24990 VA: 0x181D25790
	public void .ctor(MethodInfo method, Expression instance) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 12
	internal override Expression GetInstance() { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider // TypeDefIndex: 14795
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x18

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D25790 Offset: 0x1D24990 VA: 0x181D25790
	public void .ctor(MethodInfo method, IReadOnlyList<Expression> args) { }

	// RVA: 0x1D2D760 Offset: 0x1D2C960 VA: 0x181D2D760 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0x1D2D8C0 Offset: 0x1D2CAC0 VA: 0x181D2D8C0 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D2D7C0 Offset: 0x1D2C9C0 VA: 0x181D2D7C0 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D2D870 Offset: 0x1D2CA70 VA: 0x181D2D870 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D2D800 Offset: 0x1D2CA00 VA: 0x181D2D800 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 14796
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D25AD0 Offset: 0x1D24CD0 VA: 0x181D25AD0
	public void .ctor(MethodInfo method, Expression instance, IReadOnlyList<Expression> args) { }

	// RVA: 0x1D264E0 Offset: 0x1D256E0 VA: 0x181D264E0 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0x1D26650 Offset: 0x1D25850 VA: 0x181D26650 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D26600 Offset: 0x1D25800 VA: 0x181D26600 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D26540 Offset: 0x1D25740 VA: 0x181D26540 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D26580 Offset: 0x1D25780 VA: 0x181D26580 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 14797
{
	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D2C0D0 Offset: 0x1D2B2D0 VA: 0x181D2C0D0
	public void .ctor(MethodInfo method) { }

	// RVA: 0x1D2BF90 Offset: 0x1D2B190 VA: 0x181D2BF90 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D2BFE0 Offset: 0x1D2B1E0 VA: 0x181D2BFE0 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D2C080 Offset: 0x1D2B280 VA: 0x181D2C080 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D2C030 Offset: 0x1D2B230 VA: 0x181D2C030 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression1 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 14798
{
	// Fields
	private object _arg0; // 0x18

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D25790 Offset: 0x1D24990 VA: 0x181D25790
	public void .ctor(MethodInfo method, Expression arg0) { }

	// RVA: 0x1D2C130 Offset: 0x1D2B330 VA: 0x181D2C130 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D2C1D0 Offset: 0x1D2B3D0 VA: 0x181D2C1D0 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D2C290 Offset: 0x1D2B490 VA: 0x181D2C290 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D2C1E0 Offset: 0x1D2B3E0 VA: 0x181D2C1E0 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression2 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 14799
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D25AD0 Offset: 0x1D24CD0 VA: 0x181D25AD0
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x1D2C400 Offset: 0x1D2B600 VA: 0x181D2C400 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D2C5A0 Offset: 0x1D2B7A0 VA: 0x181D2C5A0 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D2C1D0 Offset: 0x1D2B3D0 VA: 0x181D2C1D0 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D2C4B0 Offset: 0x1D2B6B0 VA: 0x181D2C4B0 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression3 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 14800
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D25F40 Offset: 0x1D25140 VA: 0x181D25F40
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1D2C7D0 Offset: 0x1D2B9D0 VA: 0x181D2C7D0 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D2C9B0 Offset: 0x1D2BBB0 VA: 0x181D2C9B0 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D2C1D0 Offset: 0x1D2B3D0 VA: 0x181D2C1D0 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D2C890 Offset: 0x1D2BA90 VA: 0x181D2C890 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression4 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 14801
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D26450 Offset: 0x1D25650 VA: 0x181D26450
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1D2CC30 Offset: 0x1D2BE30 VA: 0x181D2CC30 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D2CE60 Offset: 0x1D2C060 VA: 0x181D2CE60 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D2C1D0 Offset: 0x1D2B3D0 VA: 0x181D2C1D0 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D2CD00 Offset: 0x1D2BF00 VA: 0x181D2CD00 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 14802
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30
	private readonly Expression _arg4; // 0x38

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D2D6C0 Offset: 0x1D2C8C0 VA: 0x181D2D6C0
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1D2D130 Offset: 0x1D2C330 VA: 0x181D2D130 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D2D3A0 Offset: 0x1D2C5A0 VA: 0x181D2D3A0 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D2C1D0 Offset: 0x1D2B3D0 VA: 0x181D2C1D0 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D2D220 Offset: 0x1D2C420 VA: 0x181D2D220 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression0 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 14803
{
	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D25790 Offset: 0x1D24990 VA: 0x181D25790
	public void .ctor(MethodInfo method, Expression instance) { }

	// RVA: 0x1D25640 Offset: 0x1D24840 VA: 0x181D25640 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D25690 Offset: 0x1D24890 VA: 0x181D25690 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D25740 Offset: 0x1D24940 VA: 0x181D25740 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D256E0 Offset: 0x1D248E0 VA: 0x181D256E0 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 14804
{
	// Fields
	private object _arg0; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D25AD0 Offset: 0x1D24CD0 VA: 0x181D25AD0
	public void .ctor(MethodInfo method, Expression instance, Expression arg0) { }

	// RVA: 0x1D25800 Offset: 0x1D24A00 VA: 0x181D25800 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D25960 Offset: 0x1D24B60 VA: 0x181D25960 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D258A0 Offset: 0x1D24AA0 VA: 0x181D258A0 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 14805
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D25F40 Offset: 0x1D25140 VA: 0x181D25F40
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1) { }

	// RVA: 0x1D25B50 Offset: 0x1D24D50 VA: 0x181D25B50 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D25D10 Offset: 0x1D24F10 VA: 0x181D25D10 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D25C00 Offset: 0x1D24E00 VA: 0x181D25C00 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression3 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 14806
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1D26450 Offset: 0x1D25650 VA: 0x181D26450
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1D25FD0 Offset: 0x1D251D0 VA: 0x181D25FD0 Slot: 16
	public override Expression GetArgument(int index) { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 17
	public override int get_ArgumentCount() { }

	// RVA: 0x1D261D0 Offset: 0x1D253D0 VA: 0x181D261D0 Slot: 13
	internal override bool SameArguments(ICollection<Expression> arguments) { }

	// RVA: 0x1D04040 Offset: 0x1D03240 VA: 0x181D04040 Slot: 14
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	// RVA: 0x1D26090 Offset: 0x1D25290 VA: 0x181D26090 Slot: 15
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.NewArrayExpressionProxy))]
public class NewArrayExpression : Expression // TypeDefIndex: 14807
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <Expressions>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public ReadOnlyCollection<Expression> Expressions { get; }

	// Methods

	// RVA: 0x1D2E120 Offset: 0x1D2D320 VA: 0x181D2E120
	internal void .ctor(Type type, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x1D2E310 Offset: 0x1D2D510 VA: 0x181D2E310
	internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x1D2E2E0 Offset: 0x1D2D4E0 VA: 0x181D2E2E0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D2E3C0 Offset: 0x1D2D5C0 VA: 0x181D2E3C0
	public NewArrayExpression Update(IEnumerable<Expression> expressions) { }

	// RVA: 0x1D2E530 Offset: 0x1D2D730 VA: 0x181D2E530
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal sealed class NewArrayInitExpression : NewArrayExpression // TypeDefIndex: 14808
{
	// Properties
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x1D2E120 Offset: 0x1D2D320 VA: 0x181D2E120
	internal void .ctor(Type type, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x1533C40 Offset: 0x1532E40 VA: 0x181533C40 Slot: 4
	public sealed override ExpressionType get_NodeType() { }
}

// Namespace: System.Linq.Expressions
internal sealed class NewArrayBoundsExpression : NewArrayExpression // TypeDefIndex: 14809
{
	// Properties
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x1D2E120 Offset: 0x1D2D320 VA: 0x181D2E120
	internal void .ctor(Type type, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x1974960 Offset: 0x1973B60 VA: 0x181974960 Slot: 4
	public sealed override ExpressionType get_NodeType() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.NewExpressionProxy))]
public class NewExpression : Expression, IArgumentProvider // TypeDefIndex: 14810
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x10
	[CompilerGenerated]
	private readonly ConstructorInfo <Constructor>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ReadOnlyCollection<MemberInfo> <Members>k__BackingField; // 0x20

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public ConstructorInfo Constructor { get; }
	public ReadOnlyCollection<Expression> Arguments { get; }
	public int ArgumentCount { get; }
	public ReadOnlyCollection<MemberInfo> Members { get; }

	// Methods

	// RVA: 0x1D2E8B0 Offset: 0x1D2DAB0 VA: 0x181D2E8B0
	internal void .ctor(ConstructorInfo constructor, IReadOnlyList<Expression> arguments, ReadOnlyCollection<MemberInfo> members) { }

	// RVA: 0x157DBC0 Offset: 0x157CDC0 VA: 0x18157DBC0 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x1975F80 Offset: 0x1975180 VA: 0x181975F80 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ConstructorInfo get_Constructor() { }

	// RVA: 0x1D2E980 Offset: 0x1D2DB80 VA: 0x181D2E980
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1D2E710 Offset: 0x1D2D910 VA: 0x181D2E710 Slot: 10
	public Expression GetArgument(int index) { }

	// RVA: 0x1D2E930 Offset: 0x1D2DB30 VA: 0x181D2E930 Slot: 11
	public int get_ArgumentCount() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ReadOnlyCollection<MemberInfo> get_Members() { }

	// RVA: 0x1D2E6E0 Offset: 0x1D2D8E0 VA: 0x181D2E6E0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D2E770 Offset: 0x1D2D970 VA: 0x181D2E770
	public NewExpression Update(IEnumerable<Expression> arguments) { }

	// RVA: 0x1D2E880 Offset: 0x1D2DA80 VA: 0x181D2E880
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal sealed class NewValueTypeExpression : NewExpression // TypeDefIndex: 14811
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1D2E9C0 Offset: 0x1D2DBC0 VA: 0x181D2E9C0
	internal void .ctor(Type type, ReadOnlyCollection<Expression> arguments, ReadOnlyCollection<MemberInfo> members) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ParameterExpressionProxy))]
public class ParameterExpression : Expression // TypeDefIndex: 14812
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public string Name { get; }
	public bool IsByRef { get; }

	// Methods

	// RVA: 0x1D2F430 Offset: 0x1D2E630 VA: 0x181D2F430
	internal void .ctor(string name) { }

	// RVA: 0x1D2EC50 Offset: 0x1D2DE50 VA: 0x181D2EC50
	internal static ParameterExpression Make(Type type, string name, bool isByRef) { }

	// RVA: 0x1D2F4A0 Offset: 0x1D2E6A0 VA: 0x181D2F4A0 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x1D2F490 Offset: 0x1D2E690 VA: 0x181D2F490 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x577700 Offset: 0x576900 VA: 0x180577700
	public bool get_IsByRef() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	internal virtual bool GetIsByRef() { }

	// RVA: 0x19D4930 Offset: 0x19D3B30 VA: 0x1819D4930 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D2F400 Offset: 0x1D2E600 VA: 0x181D2F400
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal sealed class ByRefParameterExpression : TypedParameterExpression // TypeDefIndex: 14813
{
	// Methods

	// RVA: 0x1D1B5D0 Offset: 0x1D1A7D0 VA: 0x181D1B5D0
	internal void .ctor(Type type, string name) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 10
	internal override bool GetIsByRef() { }
}

// Namespace: System.Linq.Expressions
internal class TypedParameterExpression : ParameterExpression // TypeDefIndex: 14814
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1D1B5D0 Offset: 0x1D1A7D0 VA: 0x181D1B5D0
	internal void .ctor(Type type, string name) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal sealed class PrimitiveParameterExpression<T> : ParameterExpression // TypeDefIndex: 14815
{
	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB87970 Offset: 0xB86B70 VA: 0x180B87970
	|-PrimitiveParameterExpression<bool>..ctor
	|-PrimitiveParameterExpression<byte>..ctor
	|-PrimitiveParameterExpression<char>..ctor
	|-PrimitiveParameterExpression<DateTime>..ctor
	|-PrimitiveParameterExpression<Decimal>..ctor
	|-PrimitiveParameterExpression<double>..ctor
	|-PrimitiveParameterExpression<short>..ctor
	|-PrimitiveParameterExpression<int>..ctor
	|-PrimitiveParameterExpression<long>..ctor
	|-PrimitiveParameterExpression<object>..ctor
	|-PrimitiveParameterExpression<sbyte>..ctor
	|-PrimitiveParameterExpression<float>..ctor
	|-PrimitiveParameterExpression<ushort>..ctor
	|-PrimitiveParameterExpression<uint>..ctor
	|-PrimitiveParameterExpression<ulong>..ctor
	|-PrimitiveParameterExpression<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public sealed override Type get_Type() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB87E00 Offset: 0xB87000 VA: 0x180B87E00
	|-PrimitiveParameterExpression<bool>.get_Type
	|
	|-RVA: 0xB87AA0 Offset: 0xB86CA0 VA: 0x180B87AA0
	|-PrimitiveParameterExpression<byte>.get_Type
	|
	|-RVA: 0xB87D40 Offset: 0xB86F40 VA: 0x180B87D40
	|-PrimitiveParameterExpression<char>.get_Type
	|
	|-RVA: 0xB879E0 Offset: 0xB86BE0 VA: 0x180B879E0
	|-PrimitiveParameterExpression<DateTime>.get_Type
	|
	|-RVA: 0xB87CE0 Offset: 0xB86EE0 VA: 0x180B87CE0
	|-PrimitiveParameterExpression<Decimal>.get_Type
	|
	|-RVA: 0xB87DA0 Offset: 0xB86FA0 VA: 0x180B87DA0
	|-PrimitiveParameterExpression<double>.get_Type
	|
	|-RVA: 0xB87B60 Offset: 0xB86D60 VA: 0x180B87B60
	|-PrimitiveParameterExpression<short>.get_Type
	|
	|-RVA: 0xB87EC0 Offset: 0xB870C0 VA: 0x180B87EC0
	|-PrimitiveParameterExpression<int>.get_Type
	|
	|-RVA: 0xB87F20 Offset: 0xB87120 VA: 0x180B87F20
	|-PrimitiveParameterExpression<long>.get_Type
	|
	|-RVA: 0xB87980 Offset: 0xB86B80 VA: 0x180B87980
	|-PrimitiveParameterExpression<object>.get_Type
	|
	|-RVA: 0xB87A40 Offset: 0xB86C40 VA: 0x180B87A40
	|-PrimitiveParameterExpression<sbyte>.get_Type
	|
	|-RVA: 0xB87C20 Offset: 0xB86E20 VA: 0x180B87C20
	|-PrimitiveParameterExpression<float>.get_Type
	|
	|-RVA: 0xB87BC0 Offset: 0xB86DC0 VA: 0x180B87BC0
	|-PrimitiveParameterExpression<ushort>.get_Type
	|
	|-RVA: 0xB87B00 Offset: 0xB86D00 VA: 0x180B87B00
	|-PrimitiveParameterExpression<uint>.get_Type
	|
	|-RVA: 0xB87E60 Offset: 0xB87060 VA: 0x180B87E60
	|-PrimitiveParameterExpression<ulong>.get_Type
	|
	|-RVA: 0xB87C80 Offset: 0xB86E80 VA: 0x180B87C80
	|-PrimitiveParameterExpression<__Il2CppFullySharedGenericType>.get_Type
	*/
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.RuntimeVariablesExpressionProxy))]
public sealed class RuntimeVariablesExpression : Expression // TypeDefIndex: 14816
{
	// Fields
	[CompilerGenerated]
	private readonly ReadOnlyCollection<ParameterExpression> <Variables>k__BackingField; // 0x10

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public ReadOnlyCollection<ParameterExpression> Variables { get; }

	// Methods

	// RVA: 0x1D2F700 Offset: 0x1D2E900 VA: 0x181D2F700
	internal void .ctor(ReadOnlyCollection<ParameterExpression> variables) { }

	// RVA: 0x1D2F770 Offset: 0x1D2E970 VA: 0x181D2F770 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1D2F760 Offset: 0x1D2E960 VA: 0x181D2F760 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

	// RVA: 0x1D2F600 Offset: 0x1D2E800 VA: 0x181D2F600 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D2F630 Offset: 0x1D2E830 VA: 0x181D2F630
	public RuntimeVariablesExpression Update(IEnumerable<ParameterExpression> variables) { }

	// RVA: 0x1D2F6D0 Offset: 0x1D2E8D0 VA: 0x181D2F6D0
	internal void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StackGuard.<>c__3<T1, T2> // TypeDefIndex: 14817
{
	// Fields
	public static readonly StackGuard.<>c__3<T1, T2> <>9; // 0x0
	public static Func<object, object> <>9__3_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-StackGuard.<>c__3<object, object>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-StackGuard.<>c__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-StackGuard.<>c__3<object, object>..ctor
	|-StackGuard.<>c__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <RunOnEmptyStack>b__3_0(object s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08DA0 Offset: 0xB07FA0 VA: 0x180B08DA0
	|-StackGuard.<>c__3<object, object>.<RunOnEmptyStack>b__3_0
	|
	|-RVA: 0xB08BA0 Offset: 0xB07DA0 VA: 0x180B08BA0
	|-StackGuard.<>c__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<RunOnEmptyStack>b__3_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StackGuard.<>c__4<T1, T2, T3> // TypeDefIndex: 14818
{
	// Fields
	public static readonly StackGuard.<>c__4<T1, T2, T3> <>9; // 0x0
	public static Func<object, object> <>9__4_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-StackGuard.<>c__4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-StackGuard.<>c__4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <RunOnEmptyStack>b__4_0(object s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08E50 Offset: 0xB08050 VA: 0x180B08E50
	|-StackGuard.<>c__4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<RunOnEmptyStack>b__4_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StackGuard.<>c__5<T1, T2, R> // TypeDefIndex: 14819
{
	// Fields
	public static readonly StackGuard.<>c__5<T1, T2, R> <>9; // 0x0
	public static Func<object, R> <>9__5_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-StackGuard.<>c__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-StackGuard.<>c__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal R <RunOnEmptyStack>b__5_0(object s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB096C0 Offset: 0xB088C0 VA: 0x180B096C0
	|-StackGuard.<>c__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<RunOnEmptyStack>b__5_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StackGuard.<>c__6<T1, T2, T3, R> // TypeDefIndex: 14820
{
	// Fields
	public static readonly StackGuard.<>c__6<T1, T2, T3, R> <>9; // 0x0
	public static Func<object, R> <>9__6_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-StackGuard.<>c__6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-StackGuard.<>c__6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal R <RunOnEmptyStack>b__6_0(object s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB099F0 Offset: 0xB08BF0 VA: 0x180B099F0
	|-StackGuard.<>c__6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<RunOnEmptyStack>b__6_0
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class StackGuard // TypeDefIndex: 14821
{
	// Fields
	private const int MaxExecutionStackCount = 1024;
	private int _executionStackCount; // 0x10

	// Methods

	// RVA: 0x1D2F990 Offset: 0x1D2EB90 VA: 0x181D2F990
	public bool TryEnterOnCurrentStack() { }

	// RVA: -1 Offset: -1
	public void RunOnEmptyStack<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA79B40 Offset: 0xA78D40 VA: 0x180A79B40
	|-StackGuard.RunOnEmptyStack<object, object>
	|
	|-RVA: 0xA798A0 Offset: 0xA78AA0 VA: 0x180A798A0
	|-StackGuard.RunOnEmptyStack<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RunOnEmptyStack<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA79580 Offset: 0xA78780 VA: 0x180A79580
	|-StackGuard.RunOnEmptyStack<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public R RunOnEmptyStack<T1, T2, R>(Func<T1, T2, R> action, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA79260 Offset: 0xA78460 VA: 0x180A79260
	|-StackGuard.RunOnEmptyStack<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public R RunOnEmptyStack<T1, T2, T3, R>(Func<T1, T2, T3, R> action, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA78ED0 Offset: 0xA780D0 VA: 0x180A78ED0
	|-StackGuard.RunOnEmptyStack<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private R RunOnEmptyStackCore<R>(Func<object, R> action, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA78C00 Offset: 0xA77E00 VA: 0x180A78C00
	|-StackGuard.RunOnEmptyStackCore<object>
	|
	|-RVA: 0xA788D0 Offset: 0xA77AD0 VA: 0x180A788D0
	|-StackGuard.RunOnEmptyStackCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal static class Strings // TypeDefIndex: 14822
{
	// Properties
	internal static string ReducibleMustOverrideReduce { get; }
	internal static string MustReduceToDifferent { get; }
	internal static string ReducedNotCompatible { get; }
	internal static string SetterHasNoParams { get; }
	internal static string PropertyCannotHaveRefType { get; }
	internal static string IndexesOfSetGetMustMatch { get; }
	internal static string AccessorsCannotHaveVarArgs { get; }
	internal static string AccessorsCannotHaveByRefArgs { get; }
	internal static string BoundsCannotBeLessThanOne { get; }
	internal static string TypeMustNotBeByRef { get; }
	internal static string TypeMustNotBePointer { get; }
	internal static string SetterMustBeVoid { get; }
	internal static string PropertyTypeMustMatchGetter { get; }
	internal static string PropertyTypeMustMatchSetter { get; }
	internal static string BothAccessorsMustBeStatic { get; }
	internal static string OnlyStaticFieldsHaveNullInstance { get; }
	internal static string OnlyStaticPropertiesHaveNullInstance { get; }
	internal static string OnlyStaticMethodsHaveNullInstance { get; }
	internal static string PropertyTypeCannotBeVoid { get; }
	internal static string InvalidUnboxType { get; }
	internal static string ExpressionMustBeWriteable { get; }
	internal static string ArgumentMustNotHaveValueType { get; }
	internal static string MustBeReducible { get; }
	internal static string AllTestValuesMustHaveSameType { get; }
	internal static string AllCaseBodiesMustHaveSameType { get; }
	internal static string DefaultBodyMustBeSupplied { get; }
	internal static string LabelMustBeVoidOrHaveExpression { get; }
	internal static string LabelTypeMustBeVoid { get; }
	internal static string QuotedExpressionMustBeLambda { get; }
	internal static string CollectionModifiedWhileEnumerating { get; }
	internal static string CollectionReadOnly { get; }
	internal static string ArgCntMustBeGreaterThanNameCnt { get; }
	internal static string BindingCannotBeNull { get; }
	internal static string ArgumentTypeCannotBeVoid { get; }
	internal static string NoOrInvalidRuleProduced { get; }
	internal static string TypeMustBeDerivedFromSystemDelegate { get; }
	internal static string FirstArgumentMustBeCallSite { get; }
	internal static string StartEndMustBeOrdered { get; }
	internal static string FaultCannotHaveCatchOrFinally { get; }
	internal static string TryMustHaveCatchFinallyOrFault { get; }
	internal static string BodyOfCatchMustHaveSameTypeAsBodyOfTry { get; }
	internal static string ConversionIsNotSupportedForArithmeticTypes { get; }
	internal static string ArgumentMustBeArray { get; }
	internal static string ArgumentMustBeBoolean { get; }
	internal static string ArgumentMustBeFieldInfoOrPropertyInfo { get; }
	internal static string ArgumentMustBeFieldInfoOrPropertyInfoOrMethod { get; }
	internal static string ArgumentMustBeInstanceMember { get; }
	internal static string ArgumentMustBeInteger { get; }
	internal static string ArgumentMustBeArrayIndexType { get; }
	internal static string ArgumentMustBeSingleDimensionalArrayType { get; }
	internal static string ArgumentTypesMustMatch { get; }
	internal static string CoalesceUsedOnNonNullType { get; }
	internal static string IncorrectNumberOfIndexes { get; }
	internal static string IncorrectNumberOfLambdaDeclarationParameters { get; }
	internal static string IncorrectNumberOfMembersForGivenConstructor { get; }
	internal static string IncorrectNumberOfArgumentsForMembers { get; }
	internal static string LambdaTypeMustBeDerivedFromSystemDelegate { get; }
	internal static string ElementInitializerMethodNotAdd { get; }
	internal static string ElementInitializerMethodWithZeroArgs { get; }
	internal static string ElementInitializerMethodStatic { get; }
	internal static string UnhandledBinding { get; }
	internal static string UnknownBindingType { get; }
	internal static string IncorrectNumberOfTypeArgsForFunc { get; }
	internal static string IncorrectNumberOfTypeArgsForAction { get; }
	internal static string ArgumentCannotBeOfTypeVoid { get; }
	internal static string ControlCannotLeaveFinally { get; }
	internal static string ControlCannotLeaveFilterTest { get; }
	internal static string ControlCannotEnterTry { get; }
	internal static string ControlCannotEnterExpression { get; }
	internal static string RethrowRequiresCatch { get; }
	internal static string TryNotAllowedInFilter { get; }
	internal static string NonStaticConstructorRequired { get; }
	internal static string NonAbstractConstructorRequired { get; }
	internal static string ExpressionMustBeReadable { get; }
	internal static string EnumerationIsDone { get; }
	internal static string InvalidArgumentValue { get; }
	internal static string NonEmptyCollectionRequired { get; }
	internal static string IncorrectNumberOfLambdaArguments { get; }
	internal static string IncorrectNumberOfConstructorArguments { get; }

	// Methods

	// RVA: 0x1D323B0 Offset: 0x1D315B0 VA: 0x181D323B0
	internal static string get_ReducibleMustOverrideReduce() { }

	// RVA: 0x1D32110 Offset: 0x1D31310 VA: 0x181D32110
	internal static string get_MustReduceToDifferent() { }

	// RVA: 0x1D32380 Offset: 0x1D31580 VA: 0x181D32380
	internal static string get_ReducedNotCompatible() { }

	// RVA: 0x1D32410 Offset: 0x1D31610 VA: 0x181D32410
	internal static string get_SetterHasNoParams() { }

	// RVA: 0x1D32290 Offset: 0x1D31490 VA: 0x181D32290
	internal static string get_PropertyCannotHaveRefType() { }

	// RVA: 0x1D31FC0 Offset: 0x1D311C0 VA: 0x181D31FC0
	internal static string get_IndexesOfSetGetMustMatch() { }

	// RVA: 0x1D31750 Offset: 0x1D30950 VA: 0x181D31750
	internal static string get_AccessorsCannotHaveVarArgs() { }

	// RVA: 0x1D31720 Offset: 0x1D30920 VA: 0x181D31720
	internal static string get_AccessorsCannotHaveByRefArgs() { }

	// RVA: 0x1D31AE0 Offset: 0x1D30CE0 VA: 0x181D31AE0
	internal static string get_BoundsCannotBeLessThanOne() { }

	// RVA: 0x1D32530 Offset: 0x1D31730 VA: 0x181D32530
	internal static string get_TypeMustNotBeByRef() { }

	// RVA: 0x1D32560 Offset: 0x1D31760 VA: 0x181D32560
	internal static string get_TypeMustNotBePointer() { }

	// RVA: 0x1D32440 Offset: 0x1D31640 VA: 0x181D32440
	internal static string get_SetterMustBeVoid() { }

	// RVA: 0x1D322F0 Offset: 0x1D314F0 VA: 0x181D322F0
	internal static string get_PropertyTypeMustMatchGetter() { }

	// RVA: 0x1D32320 Offset: 0x1D31520 VA: 0x181D32320
	internal static string get_PropertyTypeMustMatchSetter() { }

	// RVA: 0x1D31AB0 Offset: 0x1D30CB0 VA: 0x181D31AB0
	internal static string get_BothAccessorsMustBeStatic() { }

	// RVA: 0x1D32200 Offset: 0x1D31400 VA: 0x181D32200
	internal static string get_OnlyStaticFieldsHaveNullInstance() { }

	// RVA: 0x1D32260 Offset: 0x1D31460 VA: 0x181D32260
	internal static string get_OnlyStaticPropertiesHaveNullInstance() { }

	// RVA: 0x1D32230 Offset: 0x1D31430 VA: 0x181D32230
	internal static string get_OnlyStaticMethodsHaveNullInstance() { }

	// RVA: 0x1D322C0 Offset: 0x1D314C0 VA: 0x181D322C0
	internal static string get_PropertyTypeCannotBeVoid() { }

	// RVA: 0x1D32020 Offset: 0x1D31220 VA: 0x181D32020
	internal static string get_InvalidUnboxType() { }

	// RVA: 0x1D31DB0 Offset: 0x1D30FB0 VA: 0x181D31DB0
	internal static string get_ExpressionMustBeWriteable() { }

	// RVA: 0x1D319C0 Offset: 0x1D30BC0 VA: 0x181D319C0
	internal static string get_ArgumentMustNotHaveValueType() { }

	// RVA: 0x1D320E0 Offset: 0x1D312E0 VA: 0x181D320E0
	internal static string get_MustBeReducible() { }

	// RVA: 0x1D317B0 Offset: 0x1D309B0 VA: 0x181D317B0
	internal static string get_AllTestValuesMustHaveSameType() { }

	// RVA: 0x1D31780 Offset: 0x1D30980 VA: 0x181D31780
	internal static string get_AllCaseBodiesMustHaveSameType() { }

	// RVA: 0x1D31C90 Offset: 0x1D30E90 VA: 0x181D31C90
	internal static string get_DefaultBodyMustBeSupplied() { }

	// RVA: 0x1D32050 Offset: 0x1D31250 VA: 0x181D32050
	internal static string get_LabelMustBeVoidOrHaveExpression() { }

	// RVA: 0x1D32080 Offset: 0x1D31280 VA: 0x181D32080
	internal static string get_LabelTypeMustBeVoid() { }

	// RVA: 0x1D32350 Offset: 0x1D31550 VA: 0x181D32350
	internal static string get_QuotedExpressionMustBeLambda() { }

	// RVA: 0x1D31B40 Offset: 0x1D30D40 VA: 0x181D31B40
	internal static string get_CollectionModifiedWhileEnumerating() { }

	// RVA: 0x1D316D0 Offset: 0x1D308D0 VA: 0x181D316D0
	internal static string VariableMustNotBeByRef(object p0, object p1) { }

	// RVA: 0x1D31B70 Offset: 0x1D30D70 VA: 0x181D31B70
	internal static string get_CollectionReadOnly() { }

	// RVA: 0x1D2FC60 Offset: 0x1D2EE60 VA: 0x181D2FC60
	internal static string AmbiguousMatchInExpandoObject(object p0) { }

	// RVA: 0x1D31150 Offset: 0x1D30350 VA: 0x181D31150
	internal static string SameKeyExistsInExpando(object p0) { }

	// RVA: 0x1D309A0 Offset: 0x1D2FBA0 VA: 0x181D309A0
	internal static string KeyDoesNotExistInExpando(object p0) { }

	// RVA: 0x1D317E0 Offset: 0x1D309E0 VA: 0x181D317E0
	internal static string get_ArgCntMustBeGreaterThanNameCnt() { }

	// RVA: 0x1D308D0 Offset: 0x1D2FAD0 VA: 0x181D308D0
	internal static string InvalidMetaObjectCreated(object p0) { }

	// RVA: 0x1D2FDB0 Offset: 0x1D2EFB0 VA: 0x181D2FDB0
	internal static string BinderNotCompatibleWithCallSite(object p0, object p1, object p2) { }

	// RVA: 0x1D2FFF0 Offset: 0x1D2F1F0 VA: 0x181D2FFF0
	internal static string DynamicBindingNeedsRestrictions(object p0, object p1) { }

	// RVA: 0x1D30040 Offset: 0x1D2F240 VA: 0x181D30040
	internal static string DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3) { }

	// RVA: 0x1D2FF80 Offset: 0x1D2F180 VA: 0x181D2FF80
	internal static string DynamicBinderResultNotAssignable(object p0, object p1, object p2) { }

	// RVA: 0x1D31A50 Offset: 0x1D30C50 VA: 0x181D31A50
	internal static string get_BindingCannotBeNull() { }

	// RVA: 0x1D2FF40 Offset: 0x1D2F140 VA: 0x181D2FF40
	internal static string DuplicateVariable(object p0) { }

	// RVA: 0x1D319F0 Offset: 0x1D30BF0 VA: 0x181D319F0
	internal static string get_ArgumentTypeCannotBeVoid() { }

	// RVA: 0x1D313B0 Offset: 0x1D305B0 VA: 0x181D313B0
	internal static string TypeParameterIsNotDelegate(object p0) { }

	// RVA: 0x1D32140 Offset: 0x1D31340 VA: 0x181D32140
	internal static string get_NoOrInvalidRuleProduced() { }

	// RVA: 0x1D32500 Offset: 0x1D31700 VA: 0x181D32500
	internal static string get_TypeMustBeDerivedFromSystemDelegate() { }

	// RVA: 0x1D31E10 Offset: 0x1D31010 VA: 0x181D31E10
	internal static string get_FirstArgumentMustBeCallSite() { }

	// RVA: 0x1D32470 Offset: 0x1D31670 VA: 0x181D32470
	internal static string get_StartEndMustBeOrdered() { }

	// RVA: 0x1D31DE0 Offset: 0x1D30FE0 VA: 0x181D31DE0
	internal static string get_FaultCannotHaveCatchOrFinally() { }

	// RVA: 0x1D324A0 Offset: 0x1D316A0 VA: 0x181D324A0
	internal static string get_TryMustHaveCatchFinallyOrFault() { }

	// RVA: 0x1D31A80 Offset: 0x1D30C80 VA: 0x181D31A80
	internal static string get_BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	// RVA: 0x1D304F0 Offset: 0x1D2F6F0 VA: 0x181D304F0
	internal static string ExtensionNodeMustOverrideProperty(object p0) { }

	// RVA: 0x1D31650 Offset: 0x1D30850 VA: 0x181D31650
	internal static string UserDefinedOperatorMustBeStatic(object p0) { }

	// RVA: 0x1D31690 Offset: 0x1D30890 VA: 0x181D31690
	internal static string UserDefinedOperatorMustNotBeVoid(object p0) { }

	// RVA: 0x1D2FEF0 Offset: 0x1D2F0F0 VA: 0x181D2FEF0
	internal static string CoercionOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x1D313F0 Offset: 0x1D305F0 VA: 0x181D313F0
	internal static string UnaryOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x1D2FD40 Offset: 0x1D2EF40 VA: 0x181D2FD40
	internal static string BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	// RVA: 0x1D31100 Offset: 0x1D30300 VA: 0x181D31100
	internal static string ReferenceEqualityNotDefined(object p0, object p1) { }

	// RVA: 0x1D30E60 Offset: 0x1D30060 VA: 0x181D30E60
	internal static string OperandTypesDoNotMatchParameters(object p0, object p1) { }

	// RVA: 0x1D30F00 Offset: 0x1D30100 VA: 0x181D30F00
	internal static string OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	// RVA: 0x1D31C60 Offset: 0x1D30E60 VA: 0x181D31C60
	internal static string get_ConversionIsNotSupportedForArithmeticTypes() { }

	// RVA: 0x1D31870 Offset: 0x1D30A70 VA: 0x181D31870
	internal static string get_ArgumentMustBeArray() { }

	// RVA: 0x1D318A0 Offset: 0x1D30AA0 VA: 0x181D318A0
	internal static string get_ArgumentMustBeBoolean() { }

	// RVA: 0x1D30220 Offset: 0x1D2F420 VA: 0x181D30220
	internal static string EqualityMustReturnBoolean(object p0) { }

	// RVA: 0x1D31900 Offset: 0x1D30B00 VA: 0x181D31900
	internal static string get_ArgumentMustBeFieldInfoOrPropertyInfo() { }

	// RVA: 0x1D318D0 Offset: 0x1D30AD0 VA: 0x181D318D0
	internal static string get_ArgumentMustBeFieldInfoOrPropertyInfoOrMethod() { }

	// RVA: 0x1D31930 Offset: 0x1D30B30 VA: 0x181D31930
	internal static string get_ArgumentMustBeInstanceMember() { }

	// RVA: 0x1D31960 Offset: 0x1D30B60 VA: 0x181D31960
	internal static string get_ArgumentMustBeInteger() { }

	// RVA: 0x1D31840 Offset: 0x1D30A40 VA: 0x181D31840
	internal static string get_ArgumentMustBeArrayIndexType() { }

	// RVA: 0x1D31990 Offset: 0x1D30B90 VA: 0x181D31990
	internal static string get_ArgumentMustBeSingleDimensionalArrayType() { }

	// RVA: 0x1D31A20 Offset: 0x1D30C20 VA: 0x181D31A20
	internal static string get_ArgumentTypesMustMatch() { }

	// RVA: 0x1D2FE20 Offset: 0x1D2F020 VA: 0x181D2FE20
	internal static string CannotAutoInitializeValueTypeElementThroughProperty(object p0) { }

	// RVA: 0x1D2FE60 Offset: 0x1D2F060 VA: 0x181D2FE60
	internal static string CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	// RVA: 0x1D30680 Offset: 0x1D2F880 VA: 0x181D30680
	internal static string IncorrectTypeForTypeAs(object p0) { }

	// RVA: 0x1D31B10 Offset: 0x1D30D10 VA: 0x181D31B10
	internal static string get_CoalesceUsedOnNonNullType() { }

	// RVA: 0x1D30260 Offset: 0x1D2F460 VA: 0x181D30260
	internal static string ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	// RVA: 0x1D2FCF0 Offset: 0x1D2EEF0 VA: 0x181D2FCF0
	internal static string ArgumentTypeDoesNotMatchMember(object p0, object p1) { }

	// RVA: 0x1D2FCA0 Offset: 0x1D2EEA0 VA: 0x181D2FCA0
	internal static string ArgumentMemberNotDeclOnType(object p0, object p1) { }

	// RVA: 0x1D30460 Offset: 0x1D2F660 VA: 0x181D30460
	internal static string ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	// RVA: 0x1D302B0 Offset: 0x1D2F4B0 VA: 0x181D302B0
	internal static string ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	// RVA: 0x1D30350 Offset: 0x1D2F550 VA: 0x181D30350
	internal static string ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	// RVA: 0x1D304B0 Offset: 0x1D2F6B0 VA: 0x181D304B0
	internal static string ExpressionTypeNotInvocable(object p0) { }

	// RVA: 0x1D305A0 Offset: 0x1D2F7A0 VA: 0x181D305A0
	internal static string FieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1D30730 Offset: 0x1D2F930 VA: 0x181D30730
	internal static string InstanceFieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1D30530 Offset: 0x1D2F730 VA: 0x181D30530
	internal static string FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x1D31EA0 Offset: 0x1D310A0 VA: 0x181D31EA0
	internal static string get_IncorrectNumberOfIndexes() { }

	// RVA: 0x1D31F00 Offset: 0x1D31100 VA: 0x181D31F00
	internal static string get_IncorrectNumberOfLambdaDeclarationParameters() { }

	// RVA: 0x1D31F30 Offset: 0x1D31130 VA: 0x181D31F30
	internal static string get_IncorrectNumberOfMembersForGivenConstructor() { }

	// RVA: 0x1D31E40 Offset: 0x1D31040 VA: 0x181D31E40
	internal static string get_IncorrectNumberOfArgumentsForMembers() { }

	// RVA: 0x1D320B0 Offset: 0x1D312B0 VA: 0x181D320B0
	internal static string get_LambdaTypeMustBeDerivedFromSystemDelegate() { }

	// RVA: 0x1D30AB0 Offset: 0x1D2FCB0 VA: 0x181D30AB0
	internal static string MemberNotFieldOrProperty(object p0) { }

	// RVA: 0x1D30AF0 Offset: 0x1D2FCF0 VA: 0x181D30AF0
	internal static string MethodContainsGenericParameters(object p0) { }

	// RVA: 0x1D30B30 Offset: 0x1D2FD30 VA: 0x181D30B30
	internal static string MethodIsGeneric(object p0) { }

	// RVA: 0x1D30B70 Offset: 0x1D2FD70 VA: 0x181D30B70
	internal static string MethodNotPropertyAccessor(object p0, object p1) { }

	// RVA: 0x1D30FE0 Offset: 0x1D301E0 VA: 0x181D30FE0
	internal static string PropertyDoesNotHaveGetter(object p0) { }

	// RVA: 0x1D31020 Offset: 0x1D30220 VA: 0x181D31020
	internal static string PropertyDoesNotHaveSetter(object p0) { }

	// RVA: 0x1D30FA0 Offset: 0x1D301A0 VA: 0x181D30FA0
	internal static string PropertyDoesNotHaveAccessor(object p0) { }

	// RVA: 0x1D30E10 Offset: 0x1D30010 VA: 0x181D30E10
	internal static string NotAMemberOfType(object p0, object p1) { }

	// RVA: 0x1D30DD0 Offset: 0x1D2FFD0 VA: 0x181D30DD0
	internal static string NotAMemberOfAnyType(object p0) { }

	// RVA: 0x1D30F50 Offset: 0x1D30150 VA: 0x181D30F50
	internal static string ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	// RVA: 0x1D31060 Offset: 0x1D30260 VA: 0x181D31060
	internal static string PropertyNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1D30780 Offset: 0x1D2F980 VA: 0x181D30780
	internal static string InstancePropertyNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1D30840 Offset: 0x1D2FA40 VA: 0x181D30840
	internal static string InstancePropertyWithoutParameterNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1D307D0 Offset: 0x1D2F9D0 VA: 0x181D307D0
	internal static string InstancePropertyWithSpecifiedParametersNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x1D306C0 Offset: 0x1D2F8C0 VA: 0x181D306C0
	internal static string InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	// RVA: 0x1D31330 Offset: 0x1D30530 VA: 0x181D31330
	internal static string TypeMissingDefaultConstructor(object p0) { }

	// RVA: 0x1D31CC0 Offset: 0x1D30EC0 VA: 0x181D31CC0
	internal static string get_ElementInitializerMethodNotAdd() { }

	// RVA: 0x1D301D0 Offset: 0x1D2F3D0 VA: 0x181D301D0
	internal static string ElementInitializerMethodNoRefOutParam(object p0, object p1) { }

	// RVA: 0x1D31D20 Offset: 0x1D30F20 VA: 0x181D31D20
	internal static string get_ElementInitializerMethodWithZeroArgs() { }

	// RVA: 0x1D31CF0 Offset: 0x1D30EF0 VA: 0x181D31CF0
	internal static string get_ElementInitializerMethodStatic() { }

	// RVA: 0x1D31370 Offset: 0x1D30570 VA: 0x181D31370
	internal static string TypeNotIEnumerable(object p0) { }

	// RVA: 0x1D314F0 Offset: 0x1D306F0 VA: 0x181D314F0
	internal static string UnhandledBinary(object p0) { }

	// RVA: 0x1D32590 Offset: 0x1D31790 VA: 0x181D32590
	internal static string get_UnhandledBinding() { }

	// RVA: 0x1D31530 Offset: 0x1D30730 VA: 0x181D31530
	internal static string UnhandledBindingType(object p0) { }

	// RVA: 0x1D31570 Offset: 0x1D30770 VA: 0x181D31570
	internal static string UnhandledUnary(object p0) { }

	// RVA: 0x1D325C0 Offset: 0x1D317C0 VA: 0x181D325C0
	internal static string get_UnknownBindingType() { }

	// RVA: 0x1D315B0 Offset: 0x1D307B0 VA: 0x181D315B0
	internal static string UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	// RVA: 0x1D31600 Offset: 0x1D30800 VA: 0x181D31600
	internal static string UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	// RVA: 0x1D30A60 Offset: 0x1D2FC60 VA: 0x181D30A60
	internal static string LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	// RVA: 0x1D30BC0 Offset: 0x1D2FDC0 VA: 0x181D30BC0
	internal static string MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x1D305F0 Offset: 0x1D2F7F0 VA: 0x181D305F0
	internal static string GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x1D30C10 Offset: 0x1D2FE10 VA: 0x181D30C10
	internal static string MethodWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x1D310B0 Offset: 0x1D302B0 VA: 0x181D310B0
	internal static string PropertyWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x1D31F90 Offset: 0x1D31190 VA: 0x181D31F90
	internal static string get_IncorrectNumberOfTypeArgsForFunc() { }

	// RVA: 0x1D31F60 Offset: 0x1D31160 VA: 0x181D31F60
	internal static string get_IncorrectNumberOfTypeArgsForAction() { }

	// RVA: 0x1D31810 Offset: 0x1D30A10 VA: 0x181D31810
	internal static string get_ArgumentCannotBeOfTypeVoid() { }

	// RVA: 0x1D30EB0 Offset: 0x1D300B0 VA: 0x181D30EB0
	internal static string OutOfRange(object p0, object p1) { }

	// RVA: 0x1D309E0 Offset: 0x1D2FBE0 VA: 0x181D309E0
	internal static string LabelTargetAlreadyDefined(object p0) { }

	// RVA: 0x1D30A20 Offset: 0x1D2FC20 VA: 0x181D30A20
	internal static string LabelTargetUndefined(object p0) { }

	// RVA: 0x1D31C30 Offset: 0x1D30E30 VA: 0x181D31C30
	internal static string get_ControlCannotLeaveFinally() { }

	// RVA: 0x1D31C00 Offset: 0x1D30E00 VA: 0x181D31C00
	internal static string get_ControlCannotLeaveFilterTest() { }

	// RVA: 0x1D2FC20 Offset: 0x1D2EE20 VA: 0x181D2FC20
	internal static string AmbiguousJump(object p0) { }

	// RVA: 0x1D31BD0 Offset: 0x1D30DD0 VA: 0x181D31BD0
	internal static string get_ControlCannotEnterTry() { }

	// RVA: 0x1D31BA0 Offset: 0x1D30DA0 VA: 0x181D31BA0
	internal static string get_ControlCannotEnterExpression() { }

	// RVA: 0x1D30D90 Offset: 0x1D2FF90 VA: 0x181D30D90
	internal static string NonLocalJumpWithValue(object p0) { }

	// RVA: 0x1D30890 Offset: 0x1D2FA90 VA: 0x181D30890
	internal static string InvalidLvalue(object p0) { }

	// RVA: 0x1D31440 Offset: 0x1D30640 VA: 0x181D31440
	internal static string UndefinedVariable(object p0, object p1, object p2) { }

	// RVA: 0x1D2FEA0 Offset: 0x1D2F0A0 VA: 0x181D2FEA0
	internal static string CannotCloseOverByRef(object p0, object p1) { }

	// RVA: 0x1D314B0 Offset: 0x1D306B0 VA: 0x181D314B0
	internal static string UnexpectedVarArgsCall(object p0) { }

	// RVA: 0x1D323E0 Offset: 0x1D315E0 VA: 0x181D323E0
	internal static string get_RethrowRequiresCatch() { }

	// RVA: 0x1D324D0 Offset: 0x1D316D0 VA: 0x181D324D0
	internal static string get_TryNotAllowedInFilter() { }

	// RVA: 0x1D30CD0 Offset: 0x1D2FED0 VA: 0x181D30CD0
	internal static string MustRewriteToSameNode(object p0, object p1, object p2) { }

	// RVA: 0x1D30C60 Offset: 0x1D2FE60 VA: 0x181D30C60
	internal static string MustRewriteChildToSameType(object p0, object p1, object p2) { }

	// RVA: 0x1D30D40 Offset: 0x1D2FF40 VA: 0x181D30D40
	internal static string MustRewriteWithoutMethod(object p0, object p1) { }

	// RVA: 0x1D31230 Offset: 0x1D30430 VA: 0x181D31230
	internal static string TryNotSupportedForMethodsWithRefArgs(object p0) { }

	// RVA: 0x1D31270 Offset: 0x1D30470 VA: 0x181D31270
	internal static string TryNotSupportedForValueTypeInstances(object p0) { }

	// RVA: 0x1D311E0 Offset: 0x1D303E0 VA: 0x181D311E0
	internal static string TestValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1) { }

	// RVA: 0x1D31190 Offset: 0x1D30390 VA: 0x181D31190
	internal static string SwitchValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1) { }

	// RVA: 0x1D321D0 Offset: 0x1D313D0 VA: 0x181D321D0
	internal static string get_NonStaticConstructorRequired() { }

	// RVA: 0x1D32170 Offset: 0x1D31370 VA: 0x181D32170
	internal static string get_NonAbstractConstructorRequired() { }

	// RVA: 0x1D31D80 Offset: 0x1D30F80 VA: 0x181D31D80
	internal static string get_ExpressionMustBeReadable() { }

	// RVA: 0x1D30300 Offset: 0x1D2F500 VA: 0x181D30300
	internal static string ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1) { }

	// RVA: 0x1D31D50 Offset: 0x1D30F50 VA: 0x181D31D50
	internal static string get_EnumerationIsDone() { }

	// RVA: 0x1D312B0 Offset: 0x1D304B0 VA: 0x181D312B0
	internal static string TypeContainsGenericParameters(object p0) { }

	// RVA: 0x1D312F0 Offset: 0x1D304F0 VA: 0x181D312F0
	internal static string TypeIsGeneric(object p0) { }

	// RVA: 0x1D31FF0 Offset: 0x1D311F0 VA: 0x181D31FF0
	internal static string get_InvalidArgumentValue() { }

	// RVA: 0x1D321A0 Offset: 0x1D313A0 VA: 0x181D321A0
	internal static string get_NonEmptyCollectionRequired() { }

	// RVA: 0x1D30910 Offset: 0x1D2FB10 VA: 0x181D30910
	internal static string InvalidNullValue(object p0) { }

	// RVA: 0x1D30950 Offset: 0x1D2FB50 VA: 0x181D30950
	internal static string InvalidObjectType(object p0, object p1) { }

	// RVA: 0x1D303A0 Offset: 0x1D2F5A0 VA: 0x181D303A0
	internal static string ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2) { }

	// RVA: 0x1D30410 Offset: 0x1D2F610 VA: 0x181D30410
	internal static string ExpressionTypeDoesNotMatchParameter(object p0, object p1) { }

	// RVA: 0x1D30640 Offset: 0x1D2F840 VA: 0x181D30640
	internal static string IncorrectNumberOfMethodCallArguments(object p0) { }

	// RVA: 0x1D31ED0 Offset: 0x1D310D0 VA: 0x181D31ED0
	internal static string get_IncorrectNumberOfLambdaArguments() { }

	// RVA: 0x1D31E70 Offset: 0x1D31070 VA: 0x181D31E70
	internal static string get_IncorrectNumberOfConstructorArguments() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.SwitchCaseProxy))]
public sealed class SwitchCase // TypeDefIndex: 14823
{
	// Fields
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <TestValues>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x18

	// Properties
	public ReadOnlyCollection<Expression> TestValues { get; }
	public Expression Body { get; }

	// Methods

	// RVA: 0x162EF30 Offset: 0x162E130 VA: 0x18162EF30
	internal void .ctor(Expression body, ReadOnlyCollection<Expression> testValues) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ReadOnlyCollection<Expression> get_TestValues() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Expression get_Body() { }

	// RVA: 0x1D325F0 Offset: 0x1D317F0 VA: 0x181D325F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D32600 Offset: 0x1D31800 VA: 0x181D32600
	public SwitchCase Update(IEnumerable<Expression> testValues, Expression body) { }

	// RVA: 0x1D326D0 Offset: 0x1D318D0 VA: 0x181D326D0
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.SwitchExpressionProxy))]
public sealed class SwitchExpression : Expression // TypeDefIndex: 14824
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <SwitchValue>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ReadOnlyCollection<SwitchCase> <Cases>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Expression <DefaultBody>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly MethodInfo <Comparison>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression SwitchValue { get; }
	public ReadOnlyCollection<SwitchCase> Cases { get; }
	public Expression DefaultBody { get; }
	public MethodInfo Comparison { get; }
	internal bool IsLifted { get; }

	// Methods

	// RVA: 0x1D32860 Offset: 0x1D31A60 VA: 0x181D32860
	internal void .ctor(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, ReadOnlyCollection<SwitchCase> cases) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1D32A50 Offset: 0x1D31C50 VA: 0x181D32A50 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Expression get_SwitchValue() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ReadOnlyCollection<SwitchCase> get_Cases() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Expression get_DefaultBody() { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public MethodInfo get_Comparison() { }

	// RVA: 0x1D32700 Offset: 0x1D31900 VA: 0x181D32700 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D328F0 Offset: 0x1D31AF0 VA: 0x181D328F0
	internal bool get_IsLifted() { }

	// RVA: 0x1D32730 Offset: 0x1D31930 VA: 0x181D32730
	public SwitchExpression Update(Expression switchValue, IEnumerable<SwitchCase> cases, Expression defaultBody) { }

	// RVA: 0x1D32830 Offset: 0x1D31A30 VA: 0x181D32830
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
public class SymbolDocumentInfo // TypeDefIndex: 14825
{
	// Fields
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x10
	internal static readonly Guid DocumentType_Text; // 0x0

	// Properties
	public string FileName { get; }
	public virtual Guid Language { get; }
	public virtual Guid LanguageVendor { get; }
	public virtual Guid DocumentType { get; }

	// Methods

	// RVA: 0x1D32B30 Offset: 0x1D31D30 VA: 0x181D32B30
	internal void .ctor(string fileName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_FileName() { }

	// RVA: 0x1D32C40 Offset: 0x1D31E40 VA: 0x181D32C40 Slot: 4
	public virtual Guid get_Language() { }

	// RVA: 0x1D32BF0 Offset: 0x1D31DF0 VA: 0x181D32BF0 Slot: 5
	public virtual Guid get_LanguageVendor() { }

	// RVA: 0x1D32B90 Offset: 0x1D31D90 VA: 0x181D32B90 Slot: 6
	public virtual Guid get_DocumentType() { }

	// RVA: 0x1D32A60 Offset: 0x1D31C60 VA: 0x181D32A60
	private static void .cctor() { }

	// RVA: 0x1D32B00 Offset: 0x1D31D00 VA: 0x181D32B00
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal sealed class SymbolDocumentWithGuids : SymbolDocumentInfo // TypeDefIndex: 14826
{
	// Fields
	[CompilerGenerated]
	private readonly Guid <Language>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Guid <LanguageVendor>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Guid <DocumentType>k__BackingField; // 0x38

	// Properties
	public override Guid Language { get; }
	public override Guid LanguageVendor { get; }
	public override Guid DocumentType { get; }

	// Methods

	// RVA: 0x1D32D60 Offset: 0x1D31F60 VA: 0x181D32D60
	internal void .ctor(string fileName, ref Guid language) { }

	// RVA: 0x1D32C90 Offset: 0x1D31E90 VA: 0x181D32C90
	internal void .ctor(string fileName, ref Guid language, ref Guid vendor) { }

	// RVA: 0x1D32E20 Offset: 0x1D32020 VA: 0x181D32E20
	internal void .ctor(string fileName, ref Guid language, ref Guid vendor, ref Guid documentType) { }

	[CompilerGenerated]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820 Slot: 4
	public override Guid get_Language() { }

	[CompilerGenerated]
	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80 Slot: 5
	public override Guid get_LanguageVendor() { }

	[CompilerGenerated]
	// RVA: 0x526C40 Offset: 0x525E40 VA: 0x180526C40 Slot: 6
	public override Guid get_DocumentType() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.TryExpressionProxy))]
public sealed class TryExpression : Expression // TypeDefIndex: 14827
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Expression <Finally>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Expression <Fault>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public Expression Finally { get; }
	public Expression Fault { get; }

	// Methods

	// RVA: 0x1D33320 Offset: 0x1D32520 VA: 0x181D33320
	internal void .ctor(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1D333E0 Offset: 0x1D325E0 VA: 0x181D333E0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Expression get_Finally() { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Expression get_Fault() { }

	// RVA: 0x1D331F0 Offset: 0x1D323F0 VA: 0x181D331F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D33220 Offset: 0x1D32420 VA: 0x181D33220
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }

	// RVA: 0x1D333B0 Offset: 0x1D325B0 VA: 0x181D333B0
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.TypeBinaryExpressionProxy))]
public sealed class TypeBinaryExpression : Expression // TypeDefIndex: 14828
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Type <TypeOperand>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Expression { get; }
	public Type TypeOperand { get; }

	// Methods

	// RVA: 0x1D34130 Offset: 0x1D33330 VA: 0x181D34130
	internal void .ctor(Expression expression, Type typeOperand, ExpressionType nodeType) { }

	// RVA: 0x1D341B0 Offset: 0x1D333B0 VA: 0x181D341B0 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Expression get_Expression() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Type get_TypeOperand() { }

	// RVA: 0x1D33960 Offset: 0x1D32B60 VA: 0x181D33960
	internal Expression ReduceTypeEqual() { }

	// RVA: 0x1D33420 Offset: 0x1D32620 VA: 0x181D33420
	private Expression ByValParameterTypeEqual(ParameterExpression value) { }

	// RVA: 0x1D337B0 Offset: 0x1D329B0 VA: 0x181D337B0
	private Expression ReduceConstantTypeEqual() { }

	// RVA: 0x1D333F0 Offset: 0x1D325F0 VA: 0x181D333F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D34040 Offset: 0x1D33240 VA: 0x181D34040
	public TypeBinaryExpression Update(Expression expression) { }

	// RVA: 0x1D34100 Offset: 0x1D33300 VA: 0x181D34100
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.UnaryExpressionProxy))]
public sealed class UnaryExpression : Expression // TypeDefIndex: 14829
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Expression <Operand>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public MethodInfo Method { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public override bool CanReduce { get; }
	private bool IsPrefix { get; }

	// Methods

	// RVA: 0x1D354D0 Offset: 0x1D346D0 VA: 0x181D354D0
	internal void .ctor(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Expression get_Operand() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public MethodInfo get_Method() { }

	// RVA: 0x1D35610 Offset: 0x1D34810 VA: 0x181D35610
	public bool get_IsLifted() { }

	// RVA: 0x1D35590 Offset: 0x1D34790 VA: 0x181D35590
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1D34210 Offset: 0x1D33410 VA: 0x181D34210 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1D35560 Offset: 0x1D34760 VA: 0x181D35560 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1D35350 Offset: 0x1D34550 VA: 0x181D35350 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1D35880 Offset: 0x1D34A80 VA: 0x181D35880
	private bool get_IsPrefix() { }

	// RVA: 0x1D34240 Offset: 0x1D33440 VA: 0x181D34240
	private UnaryExpression FunctionalOp(Expression operand) { }

	// RVA: 0x1D35020 Offset: 0x1D34220 VA: 0x181D35020
	private Expression ReduceVariable() { }

	// RVA: 0x1D34A60 Offset: 0x1D33C60 VA: 0x181D34A60
	private Expression ReduceMember() { }

	// RVA: 0x1D34360 Offset: 0x1D33560 VA: 0x181D34360
	private Expression ReduceIndex() { }

	// RVA: 0x1D353D0 Offset: 0x1D345D0 VA: 0x181D353D0
	public UnaryExpression Update(Expression operand) { }

	// RVA: 0x1D354A0 Offset: 0x1D346A0 VA: 0x181D354A0
	internal void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal static class Utils // TypeDefIndex: 14830
{
	// Fields
	public static readonly object BoxedFalse; // 0x0
	public static readonly object BoxedTrue; // 0x8
	public static readonly object BoxedIntM1; // 0x10
	public static readonly object BoxedInt0; // 0x18
	public static readonly object BoxedInt1; // 0x20
	public static readonly object BoxedInt2; // 0x28
	public static readonly object BoxedInt3; // 0x30
	public static readonly object BoxedDefaultSByte; // 0x38
	public static readonly object BoxedDefaultChar; // 0x40
	public static readonly object BoxedDefaultInt16; // 0x48
	public static readonly object BoxedDefaultInt64; // 0x50
	public static readonly object BoxedDefaultByte; // 0x58
	public static readonly object BoxedDefaultUInt16; // 0x60
	public static readonly object BoxedDefaultUInt32; // 0x68
	public static readonly object BoxedDefaultUInt64; // 0x70
	public static readonly object BoxedDefaultSingle; // 0x78
	public static readonly object BoxedDefaultDouble; // 0x80
	public static readonly object BoxedDefaultDecimal; // 0x88
	public static readonly object BoxedDefaultDateTime; // 0x90
	private static readonly ConstantExpression s_true; // 0x98
	private static readonly ConstantExpression s_false; // 0xA0
	private static readonly ConstantExpression s_m1; // 0xA8
	private static readonly ConstantExpression s_0; // 0xB0
	private static readonly ConstantExpression s_1; // 0xB8
	private static readonly ConstantExpression s_2; // 0xC0
	private static readonly ConstantExpression s_3; // 0xC8
	public static readonly DefaultExpression Empty; // 0xD0
	public static readonly ConstantExpression Null; // 0xD8

	// Methods

	// RVA: 0x1D35A70 Offset: 0x1D34C70 VA: 0x181D35A70
	public static ConstantExpression Constant(bool value) { }

	// RVA: 0x1D358D0 Offset: 0x1D34AD0 VA: 0x181D358D0
	public static ConstantExpression Constant(int value) { }

	// RVA: 0x1D35B00 Offset: 0x1D34D00 VA: 0x181D35B00
	private static void .cctor() { }
}

// Namespace: 
private sealed class AddInstruction.AddInt16 : AddInstruction // TypeDefIndex: 14831
{
	// Methods

	// RVA: 0x1D17BD0 Offset: 0x1D16DD0 VA: 0x181D17BD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddInstruction.AddInt32 : AddInstruction // TypeDefIndex: 14832
{
	// Methods

	// RVA: 0x1D17D40 Offset: 0x1D16F40 VA: 0x181D17D40 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddInstruction.AddInt64 : AddInstruction // TypeDefIndex: 14833
{
	// Methods

	// RVA: 0x1D17EB0 Offset: 0x1D170B0 VA: 0x181D17EB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddInstruction.AddUInt16 : AddInstruction // TypeDefIndex: 14834
{
	// Methods

	// RVA: 0x1D19340 Offset: 0x1D18540 VA: 0x181D19340 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddInstruction.AddUInt32 : AddInstruction // TypeDefIndex: 14835
{
	// Methods

	// RVA: 0x1D194B0 Offset: 0x1D186B0 VA: 0x181D194B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddInstruction.AddUInt64 : AddInstruction // TypeDefIndex: 14836
{
	// Methods

	// RVA: 0x1D19630 Offset: 0x1D18830 VA: 0x181D19630 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddInstruction.AddSingle : AddInstruction // TypeDefIndex: 14837
{
	// Methods

	// RVA: 0x1D191C0 Offset: 0x1D183C0 VA: 0x181D191C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddInstruction.AddDouble : AddInstruction // TypeDefIndex: 14838
{
	// Methods

	// RVA: 0x1D17670 Offset: 0x1D16870 VA: 0x181D17670 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AddInstruction : Instruction // TypeDefIndex: 14839
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D17BA0 Offset: 0x1D16DA0 VA: 0x181D17BA0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1D177F0 Offset: 0x1D169F0 VA: 0x181D177F0
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfInt16 : AddOvfInstruction // TypeDefIndex: 14840
{
	// Methods

	// RVA: 0x1D18360 Offset: 0x1D17560 VA: 0x181D18360 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfInt32 : AddOvfInstruction // TypeDefIndex: 14841
{
	// Methods

	// RVA: 0x1D18650 Offset: 0x1D17850 VA: 0x181D18650 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfInt64 : AddOvfInstruction // TypeDefIndex: 14842
{
	// Methods

	// RVA: 0x1D188C0 Offset: 0x1D17AC0 VA: 0x181D188C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfUInt16 : AddOvfInstruction // TypeDefIndex: 14843
{
	// Methods

	// RVA: 0x1D18B00 Offset: 0x1D17D00 VA: 0x181D18B00 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfUInt32 : AddOvfInstruction // TypeDefIndex: 14844
{
	// Methods

	// RVA: 0x1D18DA0 Offset: 0x1D17FA0 VA: 0x181D18DA0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfUInt64 : AddOvfInstruction // TypeDefIndex: 14845
{
	// Methods

	// RVA: 0x1D18FB0 Offset: 0x1D181B0 VA: 0x181D18FB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AddOvfInstruction : Instruction // TypeDefIndex: 14846
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D18330 Offset: 0x1D17530 VA: 0x181D18330 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1D18030 Offset: 0x1D17230 VA: 0x181D18030
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class AndInstruction.AndSByte : AndInstruction // TypeDefIndex: 14847
{
	// Methods

	// RVA: 0x1D1A150 Offset: 0x1D19350 VA: 0x181D1A150 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndInt16 : AndInstruction // TypeDefIndex: 14848
{
	// Methods

	// RVA: 0x1D19E80 Offset: 0x1D19080 VA: 0x181D19E80 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndInt32 : AndInstruction // TypeDefIndex: 14849
{
	// Methods

	// RVA: 0x1D19F70 Offset: 0x1D19170 VA: 0x181D19F70 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndInt64 : AndInstruction // TypeDefIndex: 14850
{
	// Methods

	// RVA: 0x1D1A050 Offset: 0x1D19250 VA: 0x181D1A050 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndByte : AndInstruction // TypeDefIndex: 14851
{
	// Methods

	// RVA: 0x1D19940 Offset: 0x1D18B40 VA: 0x181D19940 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndUInt16 : AndInstruction // TypeDefIndex: 14852
{
	// Methods

	// RVA: 0x1D1A240 Offset: 0x1D19440 VA: 0x181D1A240 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndUInt32 : AndInstruction // TypeDefIndex: 14853
{
	// Methods

	// RVA: 0x1D1A330 Offset: 0x1D19530 VA: 0x181D1A330 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndUInt64 : AndInstruction // TypeDefIndex: 14854
{
	// Methods

	// RVA: 0x1D1A420 Offset: 0x1D19620 VA: 0x181D1A420 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndBoolean : AndInstruction // TypeDefIndex: 14855
{
	// Methods

	// RVA: 0x1D197B0 Offset: 0x1D189B0 VA: 0x181D197B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AndInstruction : Instruction // TypeDefIndex: 14856
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D19E50 Offset: 0x1D19050 VA: 0x181D19E50 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1D19A30 Offset: 0x1D18C30 VA: 0x181D19A30
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayInitInstruction : Instruction // TypeDefIndex: 14857
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _elementCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	internal void .ctor(Type elementType, int elementCount) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D2E5F0 Offset: 0x1D2D7F0 VA: 0x181D2E5F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D2E560 Offset: 0x1D2D760 VA: 0x181D2E560 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayInstruction : Instruction // TypeDefIndex: 14858
{
	// Fields
	private readonly Type _elementType; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(Type elementType) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D2E6B0 Offset: 0x1D2D8B0 VA: 0x181D2E6B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D2E620 Offset: 0x1D2D820 VA: 0x181D2E620 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayBoundsInstruction : Instruction // TypeDefIndex: 14859
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _rank; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	internal void .ctor(Type elementType, int rank) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D2E2B0 Offset: 0x1D2D4B0 VA: 0x181D2E2B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D2E190 Offset: 0x1D2D390 VA: 0x181D2E190 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class GetArrayItemInstruction : Instruction // TypeDefIndex: 14860
{
	// Fields
	internal static readonly GetArrayItemInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D21C40 Offset: 0x1D20E40 VA: 0x181D21C40 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D21B00 Offset: 0x1D20D00 VA: 0x181D21B00 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D21BE0 Offset: 0x1D20DE0 VA: 0x181D21BE0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class SetArrayItemInstruction : Instruction // TypeDefIndex: 14861
{
	// Fields
	internal static readonly SetArrayItemInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D2F960 Offset: 0x1D2EB60 VA: 0x181D2F960 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D2F7D0 Offset: 0x1D2E9D0 VA: 0x181D2F7D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D2F900 Offset: 0x1D2EB00 VA: 0x181D2F900
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ArrayLengthInstruction : Instruction // TypeDefIndex: 14862
{
	// Fields
	public static readonly ArrayLengthInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D1A680 Offset: 0x1D19880 VA: 0x181D1A680 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1D1A520 Offset: 0x1D19720 VA: 0x181D1A520 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D1A620 Offset: 0x1D19820 VA: 0x181D1A620
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class ConvertHelper // TypeDefIndex: 14863
{
	// Methods

	// RVA: 0x1D1C0B0 Offset: 0x1D1B2B0 VA: 0x181D1C0B0
	public static int ToInt32NoNull(object val) { }
}

// Namespace: System.Linq.Expressions.Interpreter
[IsReadOnly]
internal struct RuntimeLabel // TypeDefIndex: 14864
{
	// Fields
	public readonly int Index; // 0x0
	public readonly int StackDepth; // 0x4
	public readonly int ContinuationStackDepth; // 0x8

	// Methods

	// RVA: 0x1D2F5F0 Offset: 0x1D2E7F0 VA: 0x181D2F5F0
	public void .ctor(int index, int continuationStackDepth, int stackDepth) { }

	// RVA: 0x1D2F500 Offset: 0x1D2E700 VA: 0x181D2F500 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchLabel // TypeDefIndex: 14865
{
	// Fields
	internal const int UnknownIndex = -2147483648;
	internal const int UnknownDepth = -2147483648;
	private int _targetIndex; // 0x10
	private int _stackDepth; // 0x14
	private int _continuationStackDepth; // 0x18
	private List<int> _forwardBranchFixups; // 0x20
	[CompilerGenerated]
	private int <LabelIndex>k__BackingField; // 0x28

	// Properties
	internal int LabelIndex { get; set; }
	internal bool HasRuntimeLabel { get; }
	internal int TargetIndex { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	internal int get_LabelIndex() { }

	[CompilerGenerated]
	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	internal void set_LabelIndex(int value) { }

	// RVA: 0x1D1AE60 Offset: 0x1D1A060 VA: 0x181D1AE60
	internal bool get_HasRuntimeLabel() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	internal int get_TargetIndex() { }

	// RVA: 0x1D1AE10 Offset: 0x1D1A010 VA: 0x181D1AE10
	internal RuntimeLabel ToRuntimeLabel() { }

	// RVA: 0x1D1AC90 Offset: 0x1D19E90 VA: 0x181D1AC90
	internal void Mark(InstructionList instructions) { }

	// RVA: 0x1D1AB30 Offset: 0x1D19D30 VA: 0x181D1AB30
	internal void AddBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x1D1AC60 Offset: 0x1D19E60 VA: 0x181D1AC60
	internal void FixupBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x1D1AE30 Offset: 0x1D1A030 VA: 0x181D1AE30
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class CallInstruction : Instruction // TypeDefIndex: 14866
{
	// Properties
	public abstract int ArgumentCount { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_ArgumentCount();

	// RVA: 0x1D1BF90 Offset: 0x1D1B190 VA: 0x181D1BF90 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D1B6E0 Offset: 0x1D1A8E0 VA: 0x181D1B6E0
	public static CallInstruction Create(MethodInfo info) { }

	// RVA: 0x1D1B740 Offset: 0x1D1A940 VA: 0x181D1B740
	public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters) { }

	// RVA: 0x1D1B8E0 Offset: 0x1D1AAE0 VA: 0x181D1B8E0
	private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount) { }

	// RVA: 0x1D1B640 Offset: 0x1D1A840 VA: 0x181D1B640
	public static void ArrayItemSetter1(Array array, int index0, object value) { }

	// RVA: 0x1D1B670 Offset: 0x1D1A870 VA: 0x181D1B670
	public static void ArrayItemSetter2(Array array, int index0, int index1, object value) { }

	// RVA: 0x1D1B6A0 Offset: 0x1D1A8A0 VA: 0x181D1B6A0
	public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value) { }

	// RVA: 0x7F66E0 Offset: 0x7F58E0 VA: 0x1807F66E0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D1BE70 Offset: 0x1D1B070 VA: 0x181D1BE70
	protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda) { }

	// RVA: 0x1D1BE10 Offset: 0x1D1B010 VA: 0x181D1BE10
	protected object InterpretLambdaInvoke(LightLambda targetLambda, object[] args) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class MethodInfoCallInstruction : CallInstruction // TypeDefIndex: 14867
{
	// Fields
	protected readonly MethodInfo _target; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ArgumentCount { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 12
	public override int get_ArgumentCount() { }

	// RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	internal void .ctor(MethodInfo target, int argumentCount) { }

	// RVA: 0x1D2E070 Offset: 0x1D2D270 VA: 0x181D2E070 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D2DD30 Offset: 0x1D2CF30 VA: 0x181D2DD30 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D2DBA0 Offset: 0x1D2CDA0 VA: 0x181D2DBA0
	protected object[] GetArgs(InterpretedFrame frame, int first, int skip) { }

	// RVA: 0x1D2DFF0 Offset: 0x1D2D1F0 VA: 0x181D2DFF0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction // TypeDefIndex: 14868
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x17E1FC0 Offset: 0x17E11C0 VA: 0x1817E1FC0
	internal void .ctor(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1D1B520 Offset: 0x1D1A720 VA: 0x181D1B520 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D1AFB0 Offset: 0x1D1A1B0 VA: 0x181D1AFB0 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class OffsetInstruction : Instruction // TypeDefIndex: 14869
{
	// Fields
	internal const int Unknown = -2147483648;
	internal const int CacheSize = 32;
	protected int _offset; // 0x10

	// Properties
	public abstract Instruction[] Cache { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Instruction[] get_Cache();

	// RVA: 0x1D2EA50 Offset: 0x1D2DC50 VA: 0x181D2EA50
	public Instruction Fixup(int offset) { }

	// RVA: 0x1D2EAE0 Offset: 0x1D2DCE0 VA: 0x181D2EAE0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1D2EBA0 Offset: 0x1D2DDA0 VA: 0x181D2EBA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D1A740 Offset: 0x1D19940 VA: 0x181D1A740
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchFalseInstruction : OffsetInstruction // TypeDefIndex: 14870
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1D1A750 Offset: 0x1D19950 VA: 0x181D1A750 Slot: 12
	public override Instruction[] get_Cache() { }

	// RVA: 0x1D1A7D0 Offset: 0x1D199D0 VA: 0x181D1A7D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D1A6B0 Offset: 0x1D198B0 VA: 0x181D1A6B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D1A740 Offset: 0x1D19940 VA: 0x181D1A740
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchTrueInstruction : OffsetInstruction // TypeDefIndex: 14871
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1D1AF00 Offset: 0x1D1A100 VA: 0x181D1AF00 Slot: 12
	public override Instruction[] get_Cache() { }

	// RVA: 0x1D1AF80 Offset: 0x1D1A180 VA: 0x181D1AF80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D1AE70 Offset: 0x1D1A070 VA: 0x181D1AE70 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D1A740 Offset: 0x1D19940 VA: 0x181D1A740
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CoalescingBranchInstruction : OffsetInstruction // TypeDefIndex: 14872
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1D1C000 Offset: 0x1D1B200 VA: 0x181D1C000 Slot: 12
	public override Instruction[] get_Cache() { }

	// RVA: 0x1D1C080 Offset: 0x1D1B280 VA: 0x181D1C080 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D1BFC0 Offset: 0x1D1B1C0 VA: 0x181D1BFC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D1A740 Offset: 0x1D19940 VA: 0x181D1A740
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class BranchInstruction : OffsetInstruction // TypeDefIndex: 14873
{
	// Fields
	private static Instruction[][][] s_caches; // 0x0
	internal readonly bool _hasResult; // 0x18
	internal readonly bool _hasValue; // 0x19

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1D1A870 Offset: 0x1D19A70 VA: 0x181D1A870 Slot: 12
	public override Instruction[] get_Cache() { }

	// RVA: 0x1D1A800 Offset: 0x1D19A00 VA: 0x181D1A800
	internal void .ctor() { }

	// RVA: 0x1D1A830 Offset: 0x1D19A30 VA: 0x181D1A830
	public void .ctor(bool hasResult, bool hasValue) { }

	// RVA: 0x1D1AAF0 Offset: 0x1D19CF0 VA: 0x181D1AAF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D1AAE0 Offset: 0x1D19CE0 VA: 0x181D1AAE0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D1AB20 Offset: 0x1D19D20 VA: 0x181D1AB20 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class IndexedBranchInstruction : Instruction // TypeDefIndex: 14874
{
	// Fields
	protected const int CacheSize = 32;
	internal readonly int _labelIndex; // 0x10

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int labelIndex) { }

	// RVA: 0x1D25490 Offset: 0x1D24690 VA: 0x181D25490
	public RuntimeLabel GetLabel(InterpretedFrame frame) { }

	// RVA: 0x1D254F0 Offset: 0x1D246F0 VA: 0x181D254F0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1D255B0 Offset: 0x1D247B0 VA: 0x181D255B0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class GotoInstruction : IndexedBranchInstruction // TypeDefIndex: 14875
{
	// Fields
	private const int Variants = 8;
	private static readonly GotoInstruction[] s_cache; // 0x0
	private readonly bool _hasResult; // 0x18
	private readonly bool _hasValue; // 0x19
	private readonly bool _labelTargetGetsValue; // 0x1A

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1D21F60 Offset: 0x1D21160 VA: 0x181D21F60 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D1AAE0 Offset: 0x1D19CE0 VA: 0x181D1AAE0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D1AB20 Offset: 0x1D19D20 VA: 0x181D1AB20 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D21F10 Offset: 0x1D21110 VA: 0x181D21F10
	private void .ctor(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x1D21C70 Offset: 0x1D20E70 VA: 0x181D21C70
	internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x1D21DD0 Offset: 0x1D20FD0 VA: 0x181D21DD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D21EB0 Offset: 0x1D210B0 VA: 0x181D21EB0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 14876
{
	// Fields
	private readonly bool _hasFinally; // 0x18
	private TryCatchFinallyHandler _tryHandler; // 0x20

	// Properties
	internal TryCatchFinallyHandler Handler { get; }
	public override int ProducedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void SetTryHandler(TryCatchFinallyHandler tryHandler) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal TryCatchFinallyHandler get_Handler() { }

	// RVA: 0x1D1AB20 Offset: 0x1D19D20 VA: 0x181D1AB20 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x1D1E960 Offset: 0x1D1DB60 VA: 0x181D1E960
	private void .ctor(int targetIndex, bool hasFinally) { }

	// RVA: 0x1D1E350 Offset: 0x1D1D550 VA: 0x181D1E350
	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) { }

	// RVA: 0x1D1E300 Offset: 0x1D1D500 VA: 0x181D1E300
	internal static EnterTryCatchFinallyInstruction CreateTryCatch() { }

	// RVA: 0x1D1E3B0 Offset: 0x1D1D5B0 VA: 0x181D1E3B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D1E9A0 Offset: 0x1D1DBA0 VA: 0x181D1E9A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D1E8E0 Offset: 0x1D1DAE0 VA: 0x181D1E8E0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 14877
{
	// Fields
	private TryFaultHandler _tryHandler; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ProducedContinuations { get; }
	internal TryFaultHandler Handler { get; }

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	internal void .ctor(int targetIndex) { }

	// RVA: 0x1D1EC90 Offset: 0x1D1DE90 VA: 0x181D1EC90 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal TryFaultHandler get_Handler() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void SetTryHandler(TryFaultHandler tryHandler) { }

	// RVA: 0x1D1E9F0 Offset: 0x1D1DBF0 VA: 0x181D1E9F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 14878
{
	// Fields
	private static readonly EnterFinallyInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedContinuations { get; }

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	private void .ctor(int labelIndex) { }

	// RVA: 0x1D1E2D0 Offset: 0x1D1D4D0 VA: 0x181D1E2D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x1D1E0D0 Offset: 0x1D1D2D0 VA: 0x181D1E0D0
	internal static EnterFinallyInstruction Create(int labelIndex) { }

	// RVA: 0x1D1E1D0 Offset: 0x1D1D3D0 VA: 0x181D1E1D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D1E270 Offset: 0x1D1D470 VA: 0x181D1E270
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveFinallyInstruction : Instruction // TypeDefIndex: 14879
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D2BC20 Offset: 0x1D2AE20 VA: 0x181D2BC20 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D2BB70 Offset: 0x1D2AD70 VA: 0x181D2BB70 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D2BBC0 Offset: 0x1D2ADC0 VA: 0x181D2BBC0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 14880
{
	// Fields
	private static readonly EnterFaultInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	private void .ctor(int labelIndex) { }

	// RVA: 0x1D1E0A0 Offset: 0x1D1D2A0 VA: 0x181D1E0A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D1DEC0 Offset: 0x1D1D0C0 VA: 0x181D1DEC0
	internal static EnterFaultInstruction Create(int labelIndex) { }

	// RVA: 0x1D1DFC0 Offset: 0x1D1D1C0 VA: 0x181D1DFC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D1E040 Offset: 0x1D1D240 VA: 0x181D1E040
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveFaultInstruction : Instruction // TypeDefIndex: 14881
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ConsumedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x1D2BB40 Offset: 0x1D2AD40 VA: 0x181D2BB40 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D2BAB0 Offset: 0x1D2ACB0 VA: 0x181D2BAB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D2BAE0 Offset: 0x1D2ACE0 VA: 0x181D2BAE0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterExceptionFilterInstruction : Instruction // TypeDefIndex: 14882
{
	// Fields
	internal static readonly EnterExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1D1DDC0 Offset: 0x1D1CFC0 VA: 0x181D1DDC0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D1DD60 Offset: 0x1D1CF60 VA: 0x181D1DD60
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveExceptionFilterInstruction : Instruction // TypeDefIndex: 14883
{
	// Fields
	internal static readonly LeaveExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1D2B870 Offset: 0x1D2AA70 VA: 0x181D2B870 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D2B810 Offset: 0x1D2AA10 VA: 0x181D2B810
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterExceptionHandlerInstruction : Instruction // TypeDefIndex: 14884
{
	// Fields
	internal static readonly EnterExceptionHandlerInstruction Void; // 0x0
	internal static readonly EnterExceptionHandlerInstruction NonVoid; // 0x8
	private readonly bool _hasValue; // 0x10

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x4090D0 Offset: 0x4082D0 VA: 0x1804090D0
	private void .ctor(bool hasValue) { }

	// RVA: 0x1D1DE90 Offset: 0x1D1D090 VA: 0x181D1DE90 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D1DE80 Offset: 0x1D1D080 VA: 0x181D1DE80 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D1DDF0 Offset: 0x1D1CFF0 VA: 0x181D1DDF0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction // TypeDefIndex: 14885
{
	// Fields
	private static readonly LeaveExceptionHandlerInstruction[] s_cache; // 0x0
	private readonly bool _hasValue; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1D1E960 Offset: 0x1D1DB60 VA: 0x181D1E960
	private void .ctor(int labelIndex, bool hasValue) { }

	// RVA: 0x1D2BA80 Offset: 0x1D2AC80 VA: 0x181D2BA80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D1AB20 Offset: 0x1D19D20 VA: 0x181D1AB20 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D1AB20 Offset: 0x1D19D20 VA: 0x181D1AB20 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D2B8A0 Offset: 0x1D2AAA0 VA: 0x181D2B8A0
	internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue) { }

	// RVA: 0x1D2B9D0 Offset: 0x1D2ABD0 VA: 0x181D2B9D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D2BA20 Offset: 0x1D2AC20 VA: 0x181D2BA20
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ThrowInstruction : Instruction // TypeDefIndex: 14886
{
	// Fields
	internal static readonly ThrowInstruction Throw; // 0x0
	internal static readonly ThrowInstruction VoidThrow; // 0x8
	internal static readonly ThrowInstruction Rethrow; // 0x10
	internal static readonly ThrowInstruction VoidRethrow; // 0x18
	private readonly bool _hasResult; // 0x10
	private readonly bool _rethrow; // 0x11

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x8035A0 Offset: 0x8027A0 VA: 0x1808035A0
	private void .ctor(bool hasResult, bool isRethrow) { }

	// RVA: 0x1D331C0 Offset: 0x1D323C0 VA: 0x181D331C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D1DE80 Offset: 0x1D1D080 VA: 0x181D1DE80 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D32EE0 Offset: 0x1D320E0 VA: 0x181D32EE0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D33020 Offset: 0x1D32220 VA: 0x181D33020
	private static Exception WrapThrownObject(object thrown) { }

	// RVA: 0x1D330D0 Offset: 0x1D322D0 VA: 0x181D330D0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class IntSwitchInstruction<T> : Instruction // TypeDefIndex: 14887
{
	// Fields
	private readonly Dictionary<T, int> _cases; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	|-IntSwitchInstruction<int>..ctor
	|-IntSwitchInstruction<object>..ctor
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override string get_InstructionName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128F1F0 Offset: 0x128E3F0 VA: 0x18128F1F0
	|-IntSwitchInstruction<int>.get_InstructionName
	|
	|-RVA: 0x128F220 Offset: 0x128E420 VA: 0x18128F220
	|-IntSwitchInstruction<object>.get_InstructionName
	|
	|-RVA: 0x128F250 Offset: 0x128E450 VA: 0x18128F250
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.get_InstructionName
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override int get_ConsumedStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	|-IntSwitchInstruction<int>.get_ConsumedStack
	|-IntSwitchInstruction<object>.get_ConsumedStack
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.get_ConsumedStack
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override int Run(InterpretedFrame frame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128EF30 Offset: 0x128E130 VA: 0x18128EF30
	|-IntSwitchInstruction<int>.Run
	|
	|-RVA: 0x128F130 Offset: 0x128E330 VA: 0x18128F130
	|-IntSwitchInstruction<object>.Run
	|
	|-RVA: 0x128F000 Offset: 0x128E200 VA: 0x18128F000
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.Run
	*/
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StringSwitchInstruction : Instruction // TypeDefIndex: 14888
{
	// Fields
	private readonly Dictionary<string, int> _cases; // 0x10
	private readonly StrongBox<int> _nullCase; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x1D2FBF0 Offset: 0x1D2EDF0 VA: 0x181D2FBF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D2FB20 Offset: 0x1D2ED20 VA: 0x181D2FB20 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementInt16 : DecrementInstruction // TypeDefIndex: 14889
{
	// Methods

	// RVA: 0x1D1C840 Offset: 0x1D1BA40 VA: 0x181D1C840 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementInt32 : DecrementInstruction // TypeDefIndex: 14890
{
	// Methods

	// RVA: 0x1D1C8E0 Offset: 0x1D1BAE0 VA: 0x181D1C8E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementInt64 : DecrementInstruction // TypeDefIndex: 14891
{
	// Methods

	// RVA: 0x1D1C980 Offset: 0x1D1BB80 VA: 0x181D1C980 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementUInt16 : DecrementInstruction // TypeDefIndex: 14892
{
	// Methods

	// RVA: 0x1D1CAD0 Offset: 0x1D1BCD0 VA: 0x181D1CAD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementUInt32 : DecrementInstruction // TypeDefIndex: 14893
{
	// Methods

	// RVA: 0x1D1CB70 Offset: 0x1D1BD70 VA: 0x181D1CB70 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementUInt64 : DecrementInstruction // TypeDefIndex: 14894
{
	// Methods

	// RVA: 0x1D1CC10 Offset: 0x1D1BE10 VA: 0x181D1CC10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementSingle : DecrementInstruction // TypeDefIndex: 14895
{
	// Methods

	// RVA: 0x1D1CA20 Offset: 0x1D1BC20 VA: 0x181D1CA20 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementDouble : DecrementInstruction // TypeDefIndex: 14896
{
	// Methods

	// RVA: 0x1D1C3B0 Offset: 0x1D1B5B0 VA: 0x181D1C3B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class DecrementInstruction : Instruction // TypeDefIndex: 14897
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D1C810 Offset: 0x1D1BA10 VA: 0x181D1C810 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1D1C460 Offset: 0x1D1B660 VA: 0x181D1C460
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DefaultValueInstruction : Instruction // TypeDefIndex: 14898
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(Type type) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D1CD50 Offset: 0x1D1BF50 VA: 0x181D1CD50 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D1CCB0 Offset: 0x1D1BEB0 VA: 0x181D1CCB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D1CCF0 Offset: 0x1D1BEF0 VA: 0x181D1CCF0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private sealed class DivInstruction.DivInt16 : DivInstruction // TypeDefIndex: 14899
{
	// Methods

	// RVA: 0x1D1D2E0 Offset: 0x1D1C4E0 VA: 0x181D1D2E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivInt32 : DivInstruction // TypeDefIndex: 14900
{
	// Methods

	// RVA: 0x1D1D460 Offset: 0x1D1C660 VA: 0x181D1D460 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivInt64 : DivInstruction // TypeDefIndex: 14901
{
	// Methods

	// RVA: 0x1D1D5E0 Offset: 0x1D1C7E0 VA: 0x181D1D5E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivUInt16 : DivInstruction // TypeDefIndex: 14902
{
	// Methods

	// RVA: 0x1D1D8E0 Offset: 0x1D1CAE0 VA: 0x181D1D8E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivUInt32 : DivInstruction // TypeDefIndex: 14903
{
	// Methods

	// RVA: 0x1D1DA60 Offset: 0x1D1CC60 VA: 0x181D1DA60 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivUInt64 : DivInstruction // TypeDefIndex: 14904
{
	// Methods

	// RVA: 0x1D1DBE0 Offset: 0x1D1CDE0 VA: 0x181D1DBE0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivSingle : DivInstruction // TypeDefIndex: 14905
{
	// Methods

	// RVA: 0x1D1D760 Offset: 0x1D1C960 VA: 0x181D1D760 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivDouble : DivInstruction // TypeDefIndex: 14906
{
	// Methods

	// RVA: 0x1D1CD80 Offset: 0x1D1BF80 VA: 0x181D1CD80 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class DivInstruction : Instruction // TypeDefIndex: 14907
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D1D2B0 Offset: 0x1D1C4B0 VA: 0x181D1D2B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1D1CF00 Offset: 0x1D1C100 VA: 0x181D1CF00
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class EqualInstruction.EqualBoolean : EqualInstruction // TypeDefIndex: 14908
{
	// Methods

	// RVA: 0x1D1EDA0 Offset: 0x1D1DFA0 VA: 0x181D1EDA0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualSByte : EqualInstruction // TypeDefIndex: 14909
{
	// Methods

	// RVA: 0x1D205A0 Offset: 0x1D1F7A0 VA: 0x181D205A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt16 : EqualInstruction // TypeDefIndex: 14910
{
	// Methods

	// RVA: 0x1D20000 Offset: 0x1D1F200 VA: 0x181D20000 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualChar : EqualInstruction // TypeDefIndex: 14911
{
	// Methods

	// RVA: 0x1D1F120 Offset: 0x1D1E320 VA: 0x181D1F120 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt32 : EqualInstruction // TypeDefIndex: 14912
{
	// Methods

	// RVA: 0x1D201C0 Offset: 0x1D1F3C0 VA: 0x181D201C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt64 : EqualInstruction // TypeDefIndex: 14913
{
	// Methods

	// RVA: 0x1D20380 Offset: 0x1D1F580 VA: 0x181D20380 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualByte : EqualInstruction // TypeDefIndex: 14914
{
	// Methods

	// RVA: 0x1D1EF60 Offset: 0x1D1E160 VA: 0x181D1EF60 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt16 : EqualInstruction // TypeDefIndex: 14915
{
	// Methods

	// RVA: 0x1D20950 Offset: 0x1D1FB50 VA: 0x181D20950 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt32 : EqualInstruction // TypeDefIndex: 14916
{
	// Methods

	// RVA: 0x1D20B10 Offset: 0x1D1FD10 VA: 0x181D20B10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt64 : EqualInstruction // TypeDefIndex: 14917
{
	// Methods

	// RVA: 0x1D20CD0 Offset: 0x1D1FED0 VA: 0x181D20CD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualSingle : EqualInstruction // TypeDefIndex: 14918
{
	// Methods

	// RVA: 0x1D20780 Offset: 0x1D1F980 VA: 0x181D20780 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualDouble : EqualInstruction // TypeDefIndex: 14919
{
	// Methods

	// RVA: 0x1D1F300 Offset: 0x1D1E500 VA: 0x181D1F300 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualReference : EqualInstruction // TypeDefIndex: 14920
{
	// Methods

	// RVA: 0x1D20460 Offset: 0x1D1F660 VA: 0x181D20460 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualBooleanLiftedToNull : EqualInstruction // TypeDefIndex: 14921
{
	// Methods

	// RVA: 0x1D1ECC0 Offset: 0x1D1DEC0 VA: 0x181D1ECC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualSByteLiftedToNull : EqualInstruction // TypeDefIndex: 14922
{
	// Methods

	// RVA: 0x1D204C0 Offset: 0x1D1F6C0 VA: 0x181D204C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt16LiftedToNull : EqualInstruction // TypeDefIndex: 14923
{
	// Methods

	// RVA: 0x1D1FF20 Offset: 0x1D1F120 VA: 0x181D1FF20 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualCharLiftedToNull : EqualInstruction // TypeDefIndex: 14924
{
	// Methods

	// RVA: 0x1D1F040 Offset: 0x1D1E240 VA: 0x181D1F040 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt32LiftedToNull : EqualInstruction // TypeDefIndex: 14925
{
	// Methods

	// RVA: 0x1D200E0 Offset: 0x1D1F2E0 VA: 0x181D200E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt64LiftedToNull : EqualInstruction // TypeDefIndex: 14926
{
	// Methods

	// RVA: 0x1D202A0 Offset: 0x1D1F4A0 VA: 0x181D202A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualByteLiftedToNull : EqualInstruction // TypeDefIndex: 14927
{
	// Methods

	// RVA: 0x1D1EE80 Offset: 0x1D1E080 VA: 0x181D1EE80 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt16LiftedToNull : EqualInstruction // TypeDefIndex: 14928
{
	// Methods

	// RVA: 0x1D20870 Offset: 0x1D1FA70 VA: 0x181D20870 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt32LiftedToNull : EqualInstruction // TypeDefIndex: 14929
{
	// Methods

	// RVA: 0x1D20A30 Offset: 0x1D1FC30 VA: 0x181D20A30 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt64LiftedToNull : EqualInstruction // TypeDefIndex: 14930
{
	// Methods

	// RVA: 0x1D20BF0 Offset: 0x1D1FDF0 VA: 0x181D20BF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualSingleLiftedToNull : EqualInstruction // TypeDefIndex: 14931
{
	// Methods

	// RVA: 0x1D20680 Offset: 0x1D1F880 VA: 0x181D20680 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualDoubleLiftedToNull : EqualInstruction // TypeDefIndex: 14932
{
	// Methods

	// RVA: 0x1D1F200 Offset: 0x1D1E400 VA: 0x181D1F200 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class EqualInstruction : Instruction // TypeDefIndex: 14933
{
	// Fields
	private static Instruction s_reference; // 0x0
	private static Instruction s_Boolean; // 0x8
	private static Instruction s_SByte; // 0x10
	private static Instruction s_Int16; // 0x18
	private static Instruction s_Char; // 0x20
	private static Instruction s_Int32; // 0x28
	private static Instruction s_Int64; // 0x30
	private static Instruction s_Byte; // 0x38
	private static Instruction s_UInt16; // 0x40
	private static Instruction s_UInt32; // 0x48
	private static Instruction s_UInt64; // 0x50
	private static Instruction s_Single; // 0x58
	private static Instruction s_Double; // 0x60
	private static Instruction s_BooleanLiftedToNull; // 0x68
	private static Instruction s_SByteLiftedToNull; // 0x70
	private static Instruction s_Int16LiftedToNull; // 0x78
	private static Instruction s_CharLiftedToNull; // 0x80
	private static Instruction s_Int32LiftedToNull; // 0x88
	private static Instruction s_Int64LiftedToNull; // 0x90
	private static Instruction s_ByteLiftedToNull; // 0x98
	private static Instruction s_UInt16LiftedToNull; // 0xA0
	private static Instruction s_UInt32LiftedToNull; // 0xA8
	private static Instruction s_UInt64LiftedToNull; // 0xB0
	private static Instruction s_SingleLiftedToNull; // 0xB8
	private static Instruction s_DoubleLiftedToNull; // 0xC0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D1FEF0 Offset: 0x1D1F0F0 VA: 0x181D1FEF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1D1F3F0 Offset: 0x1D1E5F0 VA: 0x181D1F3F0
	public static Instruction Create(Type type, bool liftedToNull) { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrSByte : ExclusiveOrInstruction // TypeDefIndex: 14934
{
	// Methods

	// RVA: 0x1D216A0 Offset: 0x1D208A0 VA: 0x181D216A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrInt16 : ExclusiveOrInstruction // TypeDefIndex: 14935
{
	// Methods

	// RVA: 0x1D213E0 Offset: 0x1D205E0 VA: 0x181D213E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrInt32 : ExclusiveOrInstruction // TypeDefIndex: 14936
{
	// Methods

	// RVA: 0x1D214D0 Offset: 0x1D206D0 VA: 0x181D214D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrInt64 : ExclusiveOrInstruction // TypeDefIndex: 14937
{
	// Methods

	// RVA: 0x1D215B0 Offset: 0x1D207B0 VA: 0x181D215B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrByte : ExclusiveOrInstruction // TypeDefIndex: 14938
{
	// Methods

	// RVA: 0x1D20EA0 Offset: 0x1D200A0 VA: 0x181D20EA0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrUInt16 : ExclusiveOrInstruction // TypeDefIndex: 14939
{
	// Methods

	// RVA: 0x1D21790 Offset: 0x1D20990 VA: 0x181D21790 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrUInt32 : ExclusiveOrInstruction // TypeDefIndex: 14940
{
	// Methods

	// RVA: 0x1D21880 Offset: 0x1D20A80 VA: 0x181D21880 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrUInt64 : ExclusiveOrInstruction // TypeDefIndex: 14941
{
	// Methods

	// RVA: 0x1D21970 Offset: 0x1D20B70 VA: 0x181D21970 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrBoolean : ExclusiveOrInstruction // TypeDefIndex: 14942
{
	// Methods

	// RVA: 0x1D20DB0 Offset: 0x1D1FFB0 VA: 0x181D20DB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ExclusiveOrInstruction : Instruction // TypeDefIndex: 14943
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D213B0 Offset: 0x1D205B0 VA: 0x181D213B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1D20F90 Offset: 0x1D20190 VA: 0x181D20F90
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class FieldInstruction : Instruction // TypeDefIndex: 14944
{
	// Fields
	protected readonly FieldInfo _field; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(FieldInfo field) { }

	// RVA: 0x1D21A60 Offset: 0x1D20C60 VA: 0x181D21A60 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadStaticFieldInstruction : FieldInstruction // TypeDefIndex: 14945
{
	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(FieldInfo field) { }

	// RVA: 0x1D2BD40 Offset: 0x1D2AF40 VA: 0x181D2BD40 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D2BCF0 Offset: 0x1D2AEF0 VA: 0x181D2BCF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadFieldInstruction : FieldInstruction // TypeDefIndex: 14946
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(FieldInfo field) { }

	// RVA: 0x1D2BCC0 Offset: 0x1D2AEC0 VA: 0x181D2BCC0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D2BC50 Offset: 0x1D2AE50 VA: 0x181D2BC50 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreFieldInstruction : FieldInstruction // TypeDefIndex: 14947
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(FieldInfo field) { }

	// RVA: 0x1D2FA70 Offset: 0x1D2EC70 VA: 0x181D2FA70 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D2FA00 Offset: 0x1D2EC00 VA: 0x181D2FA00 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreStaticFieldInstruction : FieldInstruction // TypeDefIndex: 14948
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(FieldInfo field) { }

	// RVA: 0x1D2FAF0 Offset: 0x1D2ECF0 VA: 0x181D2FAF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D2FAA0 Offset: 0x1D2ECA0 VA: 0x181D2FAA0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanSByte : GreaterThanInstruction // TypeDefIndex: 14949
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D246F0 Offset: 0x1D238F0 VA: 0x181D246F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanInt16 : GreaterThanInstruction // TypeDefIndex: 14950
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D22E30 Offset: 0x1D22030 VA: 0x181D22E30 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanChar : GreaterThanInstruction // TypeDefIndex: 14951
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D22080 Offset: 0x1D21280 VA: 0x181D22080 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanInt32 : GreaterThanInstruction // TypeDefIndex: 14952
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D22F20 Offset: 0x1D22120 VA: 0x181D22F20 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanInt64 : GreaterThanInstruction // TypeDefIndex: 14953
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D23000 Offset: 0x1D22200 VA: 0x181D23000 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanByte : GreaterThanInstruction // TypeDefIndex: 14954
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D21F90 Offset: 0x1D21190 VA: 0x181D21F90 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanUInt16 : GreaterThanInstruction // TypeDefIndex: 14955
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D248D0 Offset: 0x1D23AD0 VA: 0x181D248D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanUInt32 : GreaterThanInstruction // TypeDefIndex: 14956
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D249C0 Offset: 0x1D23BC0 VA: 0x181D249C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanUInt64 : GreaterThanInstruction // TypeDefIndex: 14957
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D24AA0 Offset: 0x1D23CA0 VA: 0x181D24AA0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanSingle : GreaterThanInstruction // TypeDefIndex: 14958
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D247E0 Offset: 0x1D239E0 VA: 0x181D247E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanDouble : GreaterThanInstruction // TypeDefIndex: 14959
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D22170 Offset: 0x1D21370 VA: 0x181D22170 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class GreaterThanInstruction : Instruction // TypeDefIndex: 14960
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D22E00 Offset: 0x1D22000 VA: 0x181D22E00 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	private void .ctor(object nullValue) { }

	// RVA: 0x1D22260 Offset: 0x1D21460 VA: 0x181D22260
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte : GreaterThanOrEqualInstruction // TypeDefIndex: 14961
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D24250 Offset: 0x1D23450 VA: 0x181D24250 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16 : GreaterThanOrEqualInstruction // TypeDefIndex: 14962
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D23F90 Offset: 0x1D23190 VA: 0x181D23F90 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualChar : GreaterThanOrEqualInstruction // TypeDefIndex: 14963
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D231E0 Offset: 0x1D223E0 VA: 0x181D231E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32 : GreaterThanOrEqualInstruction // TypeDefIndex: 14964
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D24080 Offset: 0x1D23280 VA: 0x181D24080 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64 : GreaterThanOrEqualInstruction // TypeDefIndex: 14965
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D24160 Offset: 0x1D23360 VA: 0x181D24160 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualByte : GreaterThanOrEqualInstruction // TypeDefIndex: 14966
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D230F0 Offset: 0x1D222F0 VA: 0x181D230F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16 : GreaterThanOrEqualInstruction // TypeDefIndex: 14967
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D24430 Offset: 0x1D23630 VA: 0x181D24430 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32 : GreaterThanOrEqualInstruction // TypeDefIndex: 14968
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D24520 Offset: 0x1D23720 VA: 0x181D24520 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64 : GreaterThanOrEqualInstruction // TypeDefIndex: 14969
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D24600 Offset: 0x1D23800 VA: 0x181D24600 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle : GreaterThanOrEqualInstruction // TypeDefIndex: 14970
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D24340 Offset: 0x1D23540 VA: 0x181D24340 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble : GreaterThanOrEqualInstruction // TypeDefIndex: 14971
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(object nullValue) { }

	// RVA: 0x1D232D0 Offset: 0x1D224D0 VA: 0x181D232D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class GreaterThanOrEqualInstruction : Instruction // TypeDefIndex: 14972
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D23F60 Offset: 0x1D23160 VA: 0x181D23F60 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	private void .ctor(object nullValue) { }

	// RVA: 0x1D233C0 Offset: 0x1D225C0 VA: 0x181D233C0
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementInt16 : IncrementInstruction // TypeDefIndex: 14973
{
	// Methods

	// RVA: 0x1D25020 Offset: 0x1D24220 VA: 0x181D25020 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementInt32 : IncrementInstruction // TypeDefIndex: 14974
{
	// Methods

	// RVA: 0x1D250C0 Offset: 0x1D242C0 VA: 0x181D250C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementInt64 : IncrementInstruction // TypeDefIndex: 14975
{
	// Methods

	// RVA: 0x1D25160 Offset: 0x1D24360 VA: 0x181D25160 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementUInt16 : IncrementInstruction // TypeDefIndex: 14976
{
	// Methods

	// RVA: 0x1D252B0 Offset: 0x1D244B0 VA: 0x181D252B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementUInt32 : IncrementInstruction // TypeDefIndex: 14977
{
	// Methods

	// RVA: 0x1D25350 Offset: 0x1D24550 VA: 0x181D25350 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementUInt64 : IncrementInstruction // TypeDefIndex: 14978
{
	// Methods

	// RVA: 0x1D253F0 Offset: 0x1D245F0 VA: 0x181D253F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementSingle : IncrementInstruction // TypeDefIndex: 14979
{
	// Methods

	// RVA: 0x1D25200 Offset: 0x1D24400 VA: 0x181D25200 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementDouble : IncrementInstruction // TypeDefIndex: 14980
{
	// Methods

	// RVA: 0x1D24B90 Offset: 0x1D23D90 VA: 0x181D24B90 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class IncrementInstruction : Instruction // TypeDefIndex: 14981
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D24FF0 Offset: 0x1D241F0 VA: 0x181D24FF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1D24C40 Offset: 0x1D23E40 VA: 0x181D24C40
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class Instruction // TypeDefIndex: 14982
{
	// Fields
	public const int UnknownInstrIndex = 2147483647;

	// Properties
	public virtual int ConsumedStack { get; }
	public virtual int ProducedStack { get; }
	public virtual int ConsumedContinuations { get; }
	public virtual int ProducedContinuations { get; }
	public int StackBalance { get; }
	public int ContinuationsBalance { get; }
	public abstract string InstructionName { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 4
	public virtual int get_ConsumedStack() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public virtual int get_ProducedStack() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public virtual int get_ConsumedContinuations() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public virtual int get_ProducedContinuations() { }

	// RVA: 0x1D2B7C0 Offset: 0x1D2A9C0 VA: 0x181D2B7C0
	public int get_StackBalance() { }

	// RVA: 0x1D2B770 Offset: 0x1D2A970 VA: 0x181D2B770
	public int get_ContinuationsBalance() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int Run(InterpretedFrame frame);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_InstructionName();

	// RVA: 0x1D2B710 Offset: 0x1D2A910 VA: 0x181D2B710 Slot: 3
	public override string ToString() { }

	// RVA: 0x172A230 Offset: 0x1729430 VA: 0x18172A230 Slot: 10
	public virtual string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 11
	public virtual object GetDebugCookie(LightCompiler compiler) { }

	// RVA: 0x1D2B6F0 Offset: 0x1D2A8F0 VA: 0x181D2B6F0
	protected static void NullCheck(object o) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
internal sealed class InstructionArray.DebugView // TypeDefIndex: 14983
{
	// Fields
	private readonly InstructionArray _array; // 0x10

	// Properties
	[DebuggerBrowsable(3)]
	public InstructionList.DebugView.InstructionView[] A0 { get; }

	// Methods

	// RVA: 0x1D1C260 Offset: 0x1D1B460 VA: 0x181D1C260
	public void .ctor(InstructionArray array) { }

	// RVA: 0x1D1C310 Offset: 0x1D1B510 VA: 0x181D1C310
	public InstructionList.DebugView.InstructionView[] get_A0() { }

	// RVA: 0x1D1C170 Offset: 0x1D1B370 VA: 0x181D1C170
	public InstructionList.DebugView.InstructionView[] GetInstructionViews(bool includeDebugCookies = False) { }

	[CompilerGenerated]
	// RVA: 0x1D1C230 Offset: 0x1D1B430 VA: 0x181D1C230
	private int <GetInstructionViews>b__4_0(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
[DebuggerTypeProxy(typeof(InstructionArray.DebugView))]
[IsReadOnly]
internal struct InstructionArray // TypeDefIndex: 14984
{
	// Fields
	internal readonly int MaxStackDepth; // 0x0
	internal readonly int MaxContinuationDepth; // 0x4
	internal readonly Instruction[] Instructions; // 0x8
	internal readonly object[] Objects; // 0x10
	internal readonly RuntimeLabel[] Labels; // 0x18
	internal readonly List<KeyValuePair<int, object>> DebugCookies; // 0x20

	// Methods

	// RVA: 0x1D266A0 Offset: 0x1D258A0 VA: 0x181D266A0
	internal void .ctor(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, object[] objects, RuntimeLabel[] labels, List<KeyValuePair<int, object>> debugCookies) { }
}

// Namespace: 
[IsReadOnly]
[DebuggerDisplay("{GetValue(),nq}", Name = "{GetName(),nq}", Type = "{GetDisplayType(), nq}")]
internal struct InstructionList.DebugView.InstructionView // TypeDefIndex: 14985
{
	// Fields
	private readonly int _index; // 0x0
	private readonly int _stackDepth; // 0x4
	private readonly int _continuationsDepth; // 0x8
	private readonly string _name; // 0x10
	private readonly Instruction _instruction; // 0x18

	// Methods

	// RVA: 0x1D37680 Offset: 0x1D36880 VA: 0x181D37680
	internal string GetName() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal string GetValue() { }

	// RVA: 0x1D375E0 Offset: 0x1D367E0 VA: 0x181D375E0
	internal string GetDisplayType() { }

	// RVA: 0x1D37770 Offset: 0x1D36970 VA: 0x181D37770
	public void .ctor(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth) { }
}

// Namespace: 
internal sealed class InstructionList.DebugView // TypeDefIndex: 14986
{
	// Fields
	private readonly InstructionList _list; // 0x10

	// Properties
	[DebuggerBrowsable(3)]
	public InstructionList.DebugView.InstructionView[] A0 { get; }

	// Methods

	// RVA: 0x1D36DD0 Offset: 0x1D35FD0 VA: 0x181D36DD0
	public void .ctor(InstructionList list) { }

	// RVA: 0x1D36E30 Offset: 0x1D36030 VA: 0x181D36E30
	public InstructionList.DebugView.InstructionView[] get_A0() { }

	// RVA: 0x1D36C90 Offset: 0x1D35E90 VA: 0x181D36C90
	public InstructionList.DebugView.InstructionView[] GetInstructionViews(bool includeDebugCookies = False) { }

	// RVA: 0x1D368B0 Offset: 0x1D35AB0 VA: 0x181D368B0
	internal static InstructionList.DebugView.InstructionView[] GetInstructionViews(IReadOnlyList<Instruction> instructions, IReadOnlyList<object> objects, Func<int, int> labelIndexer, IReadOnlyList<KeyValuePair<int, object>> debugCookies) { }

	[CompilerGenerated]
	// RVA: 0x1D36D60 Offset: 0x1D35F60 VA: 0x181D36D60
	private int <GetInstructionViews>b__4_0(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
[DebuggerTypeProxy(typeof(InstructionList.DebugView))]
internal sealed class InstructionList // TypeDefIndex: 14987
{
	// Fields
	private readonly List<Instruction> _instructions; // 0x10
	private List<object> _objects; // 0x18
	private int _currentStackDepth; // 0x20
	private int _maxStackDepth; // 0x24
	private int _currentContinuationsDepth; // 0x28
	private int _maxContinuationDepth; // 0x2C
	private int _runtimeLabelCount; // 0x30
	private List<BranchLabel> _labels; // 0x38
	private List<KeyValuePair<int, object>> _debugCookies; // 0x40
	private const int PushIntMinCachedValue = -100;
	private const int PushIntMaxCachedValue = 100;
	private const int CachedObjectCount = 256;
	private static Instruction s_null; // 0x0
	private static Instruction s_true; // 0x8
	private static Instruction s_false; // 0x10
	private static Instruction[] s_Ints; // 0x18
	private static Instruction[] s_loadObjectCached; // 0x20
	private const int LocalInstrCacheSize = 64;
	private static Instruction[] s_loadLocal; // 0x28
	private static Instruction[] s_loadLocalBoxed; // 0x30
	private static Instruction[] s_loadLocalFromClosure; // 0x38
	private static Instruction[] s_loadLocalFromClosureBoxed; // 0x40
	private static Instruction[] s_assignLocal; // 0x48
	private static Instruction[] s_storeLocal; // 0x50
	private static Instruction[] s_assignLocalBoxed; // 0x58
	private static Instruction[] s_storeLocalBoxed; // 0x60
	private static Instruction[] s_assignLocalToClosure; // 0x68
	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields; // 0x70
	private static readonly RuntimeLabel[] s_emptyRuntimeLabels; // 0x78

	// Properties
	public int Count { get; }
	public int CurrentStackDepth { get; }
	public int CurrentContinuationsDepth { get; }
	public int MaxStackDepth { get; }

	// Methods

	// RVA: 0x1D2A400 Offset: 0x1D29600 VA: 0x181D2A400
	public void Emit(Instruction instruction) { }

	// RVA: 0x1D2B4A0 Offset: 0x1D2A6A0 VA: 0x181D2B4A0
	private void UpdateStackDepth(Instruction instruction) { }

	// RVA: 0x1D2B380 Offset: 0x1D2A580 VA: 0x181D2B380
	public void UnEmit() { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void SetDebugCookie(object cookie) { }

	// RVA: 0x1D2B6B0 Offset: 0x1D2A8B0 VA: 0x181D2B6B0
	public int get_Count() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_CurrentStackDepth() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_CurrentContinuationsDepth() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_MaxStackDepth() { }

	// RVA: 0x1D2A720 Offset: 0x1D29920 VA: 0x181D2A720
	internal Instruction GetInstruction(int index) { }

	// RVA: 0x1D2B2B0 Offset: 0x1D2A4B0 VA: 0x181D2B2B0
	public InstructionArray ToArray() { }

	// RVA: 0x1D29680 Offset: 0x1D28880 VA: 0x181D29680
	public void EmitLoad(object value) { }

	// RVA: 0x1D294C0 Offset: 0x1D286C0 VA: 0x181D294C0
	public void EmitLoad(bool value) { }

	// RVA: 0x1D28D90 Offset: 0x1D27F90 VA: 0x181D28D90
	public void EmitLoad(object value, Type type) { }

	// RVA: 0x1D278D0 Offset: 0x1D26AD0 VA: 0x181D278D0
	public void EmitDup() { }

	// RVA: 0x1D29C20 Offset: 0x1D28E20 VA: 0x181D29C20
	public void EmitPop() { }

	// RVA: 0x1D2B180 Offset: 0x1D2A380 VA: 0x181D2B180
	internal void SwitchToBoxed(int index, int instructionIndex) { }

	// RVA: 0x1D28BA0 Offset: 0x1D27DA0 VA: 0x181D28BA0
	public void EmitLoadLocal(int index) { }

	// RVA: 0x1D28750 Offset: 0x1D27950 VA: 0x181D28750
	public void EmitLoadLocalBoxed(int index) { }

	// RVA: 0x1D2AA60 Offset: 0x1D29C60 VA: 0x181D2AA60
	internal static Instruction LoadLocalBoxed(int index) { }

	// RVA: 0x1D289B0 Offset: 0x1D27BB0 VA: 0x181D289B0
	public void EmitLoadLocalFromClosure(int index) { }

	// RVA: 0x1D287C0 Offset: 0x1D279C0 VA: 0x181D287C0
	public void EmitLoadLocalFromClosureBoxed(int index) { }

	// RVA: 0x1D26E00 Offset: 0x1D26000 VA: 0x181D26E00
	public void EmitAssignLocal(int index) { }

	// RVA: 0x1D29F50 Offset: 0x1D29150 VA: 0x181D29F50
	public void EmitStoreLocal(int index) { }

	// RVA: 0x1D26BA0 Offset: 0x1D25DA0 VA: 0x181D26BA0
	public void EmitAssignLocalBoxed(int index) { }

	// RVA: 0x1D266D0 Offset: 0x1D258D0 VA: 0x181D266D0
	internal static Instruction AssignLocalBoxed(int index) { }

	// RVA: 0x1D29E70 Offset: 0x1D29070 VA: 0x181D29E70
	public void EmitStoreLocalBoxed(int index) { }

	// RVA: 0x1D2AFA0 Offset: 0x1D2A1A0 VA: 0x181D2AFA0
	internal static Instruction StoreLocalBoxed(int index) { }

	// RVA: 0x1D26C10 Offset: 0x1D25E10 VA: 0x181D26C10
	public void EmitAssignLocalToClosure(int index) { }

	// RVA: 0x1D29EE0 Offset: 0x1D290E0 VA: 0x181D29EE0
	public void EmitStoreLocalToClosure(int index) { }

	// RVA: 0x1D281E0 Offset: 0x1D273E0 VA: 0x181D281E0
	public void EmitInitializeLocal(int index, Type type) { }

	// RVA: 0x1D28320 Offset: 0x1D27520 VA: 0x181D28320
	internal void EmitInitializeParameter(int index) { }

	// RVA: 0x1D2AF40 Offset: 0x1D2A140 VA: 0x181D2AF40
	internal static Instruction Parameter(int index) { }

	// RVA: 0x1D2AEE0 Offset: 0x1D2A0E0 VA: 0x181D2AEE0
	internal static Instruction ParameterBox(int index) { }

	// RVA: 0x1D2AA00 Offset: 0x1D29C00 VA: 0x181D2AA00
	internal static Instruction InitReference(int index) { }

	// RVA: 0x1D2A9A0 Offset: 0x1D29BA0 VA: 0x181D2A9A0
	internal static Instruction InitImmutableRefBox(int index) { }

	// RVA: 0x1D298D0 Offset: 0x1D28AD0 VA: 0x181D298D0
	public void EmitNewRuntimeVariables(int count) { }

	// RVA: 0x1D27F10 Offset: 0x1D27110 VA: 0x181D27F10
	public void EmitGetArrayItem() { }

	// RVA: 0x1D29D70 Offset: 0x1D28F70 VA: 0x181D29D70
	public void EmitSetArrayItem() { }

	// RVA: 0x1D29860 Offset: 0x1D28A60 VA: 0x181D29860
	public void EmitNewArray(Type elementType) { }

	// RVA: 0x1D29760 Offset: 0x1D28960 VA: 0x181D29760
	public void EmitNewArrayBounds(Type elementType, int rank) { }

	// RVA: 0x1D297E0 Offset: 0x1D289E0 VA: 0x181D297E0
	public void EmitNewArrayInit(Type elementType, int elementCount) { }

	// RVA: 0x1D26AD0 Offset: 0x1D25CD0 VA: 0x181D26AD0
	public void EmitAdd(Type type, bool checked) { }

	// RVA: 0x1D2A1C0 Offset: 0x1D293C0 VA: 0x181D2A1C0
	public void EmitSub(Type type, bool checked) { }

	// RVA: 0x1D296C0 Offset: 0x1D288C0 VA: 0x181D296C0
	public void EmitMul(Type type, bool checked) { }

	// RVA: 0x1D278A0 Offset: 0x1D26AA0 VA: 0x181D278A0
	public void EmitDiv(Type type) { }

	// RVA: 0x1D29690 Offset: 0x1D28890 VA: 0x181D29690
	public void EmitModulo(Type type) { }

	// RVA: 0x1D27EE0 Offset: 0x1D270E0 VA: 0x181D27EE0
	public void EmitExclusiveOr(Type type) { }

	// RVA: 0x1D26B10 Offset: 0x1D25D10 VA: 0x181D26B10
	public void EmitAnd(Type type) { }

	// RVA: 0x1D29BF0 Offset: 0x1D28DF0 VA: 0x181D29BF0
	public void EmitOr(Type type) { }

	// RVA: 0x1D28670 Offset: 0x1D27870 VA: 0x181D28670
	public void EmitLeftShift(Type type) { }

	// RVA: 0x1D29D40 Offset: 0x1D28F40 VA: 0x181D29D40
	public void EmitRightShift(Type type) { }

	// RVA: 0x1D27EA0 Offset: 0x1D270A0 VA: 0x181D27EA0
	public void EmitEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x1D299D0 Offset: 0x1D28BD0 VA: 0x181D299D0
	public void EmitNotEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x1D286E0 Offset: 0x1D278E0 VA: 0x181D286E0
	public void EmitLessThan(Type type, bool liftedToNull) { }

	// RVA: 0x1D286A0 Offset: 0x1D278A0 VA: 0x181D286A0
	public void EmitLessThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x1D28170 Offset: 0x1D27370 VA: 0x181D28170
	public void EmitGreaterThan(Type type, bool liftedToNull) { }

	// RVA: 0x1D28130 Offset: 0x1D27330 VA: 0x181D28130
	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x1D29AB0 Offset: 0x1D28CB0 VA: 0x181D29AB0
	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1D29B50 Offset: 0x1D28D50 VA: 0x181D29B50
	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1D27710 Offset: 0x1D26910 VA: 0x181D27710
	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1D27660 Offset: 0x1D26860 VA: 0x181D27660
	public void EmitCast(Type toType) { }

	// RVA: 0x1D275F0 Offset: 0x1D267F0 VA: 0x181D275F0
	public void EmitCastToEnum(Type toType) { }

	// RVA: 0x1D27580 Offset: 0x1D26780 VA: 0x181D27580
	public void EmitCastReferenceToEnum(Type toType) { }

	// RVA: 0x1D29A10 Offset: 0x1D28C10 VA: 0x181D29A10
	public void EmitNot(Type type) { }

	// RVA: 0x1D27830 Offset: 0x1D26A30 VA: 0x181D27830
	public void EmitDefaultValue(Type type) { }

	// RVA: 0x1D29940 Offset: 0x1D28B40 VA: 0x181D29940
	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) { }

	// RVA: 0x1D27430 Offset: 0x1D26630 VA: 0x181D27430
	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) { }

	// RVA: 0x1D27790 Offset: 0x1D26990 VA: 0x181D27790
	internal void EmitCreateDelegate(LightDelegateCreator creator) { }

	// RVA: 0x1D2A330 Offset: 0x1D29530 VA: 0x181D2A330
	public void EmitTypeEquals() { }

	// RVA: 0x1D26B40 Offset: 0x1D25D40 VA: 0x181D26B40
	public void EmitArrayLength() { }

	// RVA: 0x1D29730 Offset: 0x1D28930 VA: 0x181D29730
	public void EmitNegate(Type type) { }

	// RVA: 0x1D29700 Offset: 0x1D28900 VA: 0x181D29700
	public void EmitNegateChecked(Type type) { }

	// RVA: 0x1D281B0 Offset: 0x1D273B0 VA: 0x181D281B0
	public void EmitIncrement(Type type) { }

	// RVA: 0x1D27800 Offset: 0x1D26A00 VA: 0x181D27800
	public void EmitDecrement(Type type) { }

	// RVA: 0x1D2A390 Offset: 0x1D29590 VA: 0x181D2A390
	public void EmitTypeIs(Type type) { }

	// RVA: 0x1D2A2C0 Offset: 0x1D294C0 VA: 0x181D2A2C0
	public void EmitTypeAs(Type type) { }

	// RVA: 0x1D28720 Offset: 0x1D27920 VA: 0x181D28720
	public void EmitLoadField(FieldInfo field) { }

	// RVA: 0x1D2A780 Offset: 0x1D29980 VA: 0x181D2A780
	private Instruction GetLoadField(FieldInfo field) { }

	// RVA: 0x1D29DD0 Offset: 0x1D28FD0 VA: 0x181D29DD0
	public void EmitStoreField(FieldInfo field) { }

	// RVA: 0x1D27500 Offset: 0x1D26700 VA: 0x181D27500
	public void EmitCall(MethodInfo method) { }

	// RVA: 0x1D274D0 Offset: 0x1D266D0 VA: 0x181D274D0
	public void EmitCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x1D27370 Offset: 0x1D26570 VA: 0x181D27370
	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1D29A40 Offset: 0x1D28C40 VA: 0x181D29A40
	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x1D268B0 Offset: 0x1D25AB0 VA: 0x181D268B0
	private RuntimeLabel[] BuildRuntimeLabels() { }

	// RVA: 0x1D2AC40 Offset: 0x1D29E40 VA: 0x181D2AC40
	public BranchLabel MakeLabel() { }

	// RVA: 0x1D2A570 Offset: 0x1D29770 VA: 0x181D2A570
	internal void FixupBranch(int branchIndex, int offset) { }

	// RVA: 0x1D2A540 Offset: 0x1D29740 VA: 0x181D2A540
	private int EnsureLabelIndex(BranchLabel label) { }

	// RVA: 0x1D2ADA0 Offset: 0x1D29FA0 VA: 0x181D2ADA0
	public int MarkRuntimeLabel() { }

	// RVA: 0x1D2AD70 Offset: 0x1D29F70 VA: 0x181D2AD70
	public void MarkLabel(BranchLabel label) { }

	// RVA: 0x1D27F70 Offset: 0x1D27170 VA: 0x181D27F70
	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x1D27210 Offset: 0x1D26410 VA: 0x181D27210
	private void EmitBranch(OffsetInstruction instruction, BranchLabel label) { }

	// RVA: 0x1D270F0 Offset: 0x1D262F0 VA: 0x181D270F0
	public void EmitBranch(BranchLabel label) { }

	// RVA: 0x1D27170 Offset: 0x1D26370 VA: 0x181D27170
	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) { }

	// RVA: 0x1D27690 Offset: 0x1D26890 VA: 0x181D27690
	public void EmitCoalescingBranch(BranchLabel leftNotNull) { }

	// RVA: 0x1D27070 Offset: 0x1D26270 VA: 0x181D27070
	public void EmitBranchTrue(BranchLabel elseLabel) { }

	// RVA: 0x1D26FF0 Offset: 0x1D261F0 VA: 0x181D26FF0
	public void EmitBranchFalse(BranchLabel elseLabel) { }

	// RVA: 0x1D2A260 Offset: 0x1D29460 VA: 0x181D2A260
	public void EmitThrow() { }

	// RVA: 0x1D2A200 Offset: 0x1D29400 VA: 0x181D2A200
	public void EmitThrowVoid() { }

	// RVA: 0x1D29CE0 Offset: 0x1D28EE0 VA: 0x181D29CE0
	public void EmitRethrow() { }

	// RVA: 0x1D29C80 Offset: 0x1D28E80 VA: 0x181D29C80
	public void EmitRethrowVoid() { }

	// RVA: 0x1D27E10 Offset: 0x1D27010 VA: 0x181D27E10
	public void EmitEnterTryFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x1D27D10 Offset: 0x1D26F10 VA: 0x181D27D10
	public void EmitEnterTryCatch() { }

	// RVA: 0x1D27D80 Offset: 0x1D26F80 VA: 0x181D27D80
	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) { }

	// RVA: 0x1D27BB0 Offset: 0x1D26DB0 VA: 0x181D27BB0
	public void EmitEnterFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x1D28610 Offset: 0x1D27810 VA: 0x181D28610
	public void EmitLeaveFinally() { }

	// RVA: 0x1D27A50 Offset: 0x1D26C50 VA: 0x181D27A50
	public void EmitEnterFault(BranchLabel faultStartLabel) { }

	// RVA: 0x1D285B0 Offset: 0x1D277B0 VA: 0x181D285B0
	public void EmitLeaveFault() { }

	// RVA: 0x1D27930 Offset: 0x1D26B30 VA: 0x181D27930
	public void EmitEnterExceptionFilter() { }

	// RVA: 0x1D283C0 Offset: 0x1D275C0 VA: 0x181D283C0
	public void EmitLeaveExceptionFilter() { }

	// RVA: 0x1D27990 Offset: 0x1D26B90 VA: 0x181D27990
	public void EmitEnterExceptionHandlerNonVoid() { }

	// RVA: 0x1D279F0 Offset: 0x1D26BF0 VA: 0x181D279F0
	public void EmitEnterExceptionHandlerVoid() { }

	// RVA: 0x1D28420 Offset: 0x1D27620 VA: 0x181D28420
	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) { }

	// RVA: -1 Offset: -1
	public void EmitIntSwitch<T>(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA24A50 Offset: 0xA23C50 VA: 0x180A24A50
	|-InstructionList.EmitIntSwitch<int>
	|-InstructionList.EmitIntSwitch<object>
	|
	|-RVA: 0xA249C0 Offset: 0xA23BC0 VA: 0x180A249C0
	|-InstructionList.EmitIntSwitch<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D2A140 Offset: 0x1D29340 VA: 0x181D2A140
	public void EmitStringSwitch(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x1D2B640 Offset: 0x1D2A840 VA: 0x181D2B640
	public void .ctor() { }

	// RVA: 0x1D2B560 Offset: 0x1D2A760 VA: 0x181D2B560
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InterpretedFrame.<GetStackTraceDebugInfo>d__29 : IEnumerable<InterpretedFrameInfo>, IEnumerable, IEnumerator<InterpretedFrameInfo>, IDisposable, IEnumerator // TypeDefIndex: 14988
{
	// Fields
	private int <>1__state; // 0x10
	private InterpretedFrameInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x28
	public InterpretedFrame <>4__this; // 0x30
	private InterpretedFrame <frame>5__2; // 0x38

	// Properties
	private InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xB028A0 Offset: 0xB01AA0 VA: 0x180B028A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1D50420 Offset: 0x1D4F620 VA: 0x181D50420 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820 Slot: 6
	private InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1D50680 Offset: 0x1D4F880 VA: 0x181D50680 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1D506C0 Offset: 0x1D4F8C0 VA: 0x181D506C0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1D505E0 Offset: 0x1D4F7E0 VA: 0x181D505E0 Slot: 4
	private IEnumerator<InterpretedFrameInfo> System.Collections.Generic.IEnumerable<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1D505E0 Offset: 0x1D4F7E0 VA: 0x181D505E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class InterpretedFrame // TypeDefIndex: 14989
{
	// Fields
	[ThreadStatic]
	private static InterpretedFrame s_currentFrame; // 0x80000000
	internal readonly Interpreter Interpreter; // 0x10
	internal InterpretedFrame _parent; // 0x18
	private readonly int[] _continuations; // 0x20
	private int _continuationIndex; // 0x28
	private int _pendingContinuation; // 0x2C
	private object _pendingValue; // 0x30
	public readonly object[] Data; // 0x38
	public readonly IStrongBox[] Closure; // 0x40
	public int StackIndex; // 0x48
	public int InstructionIndex; // 0x4C

	// Properties
	public string Name { get; }
	public InterpretedFrame Parent { get; }

	// Methods

	// RVA: 0x1D38A90 Offset: 0x1D37C90 VA: 0x181D38A90
	internal void .ctor(Interpreter interpreter, IStrongBox[] closure) { }

	// RVA: 0x1D37910 Offset: 0x1D36B10 VA: 0x181D37910
	public DebugInfo GetDebugInfo(int instructionIndex) { }

	// RVA: 0x775290 Offset: 0x774490 VA: 0x180775290
	public string get_Name() { }

	// RVA: 0x1D380B0 Offset: 0x1D372B0 VA: 0x181D380B0
	public void Push(object value) { }

	// RVA: 0x1D38400 Offset: 0x1D37600 VA: 0x181D38400
	public void Push(bool value) { }

	// RVA: 0x1D38370 Offset: 0x1D37570 VA: 0x181D38370
	public void Push(int value) { }

	// RVA: 0x1D381F0 Offset: 0x1D373F0 VA: 0x181D381F0
	public void Push(byte value) { }

	// RVA: 0x1D382B0 Offset: 0x1D374B0 VA: 0x181D382B0
	public void Push(sbyte value) { }

	// RVA: 0x1D38130 Offset: 0x1D37330 VA: 0x181D38130
	public void Push(short value) { }

	// RVA: 0x1D384F0 Offset: 0x1D376F0 VA: 0x181D384F0
	public void Push(ushort value) { }

	// RVA: 0x1D37F50 Offset: 0x1D37150 VA: 0x181D37F50
	public object Pop() { }

	// RVA: 0x1D38810 Offset: 0x1D37A10 VA: 0x181D38810
	internal void SetStackDepth(int depth) { }

	// RVA: 0x1D37E70 Offset: 0x1D37070 VA: 0x181D37E70
	public object Peek() { }

	// RVA: 0x1D37810 Offset: 0x1D36A10 VA: 0x181D37810
	public void Dup() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public InterpretedFrame get_Parent() { }

	// RVA: 0x1D37D20 Offset: 0x1D36F20 VA: 0x181D37D20
	public static bool IsInterpretedFrame(MethodBase method) { }

	[IteratorStateMachine(typeof(InterpretedFrame.<GetStackTraceDebugInfo>d__29))]
	// RVA: 0x1D37B10 Offset: 0x1D36D10 VA: 0x181D37B10
	public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo() { }

	// RVA: 0x1D385B0 Offset: 0x1D377B0 VA: 0x181D385B0
	internal void SaveTraceToException(Exception exception) { }

	// RVA: 0x1D37A40 Offset: 0x1D36C40 VA: 0x181D37A40
	public static InterpretedFrameInfo[] GetExceptionStackTrace(Exception exception) { }

	// RVA: 0x1D378A0 Offset: 0x1D36AA0 VA: 0x181D378A0
	internal InterpretedFrame Enter() { }

	// RVA: 0x1D37E20 Offset: 0x1D37020 VA: 0x181D37E20
	internal void Leave(InterpretedFrame prevFrame) { }

	// RVA: 0x1D37E10 Offset: 0x1D37010 VA: 0x181D37E10
	internal bool IsJumpHappened() { }

	// RVA: 0xCB8280 Offset: 0xCB7480 VA: 0x180CB8280
	public void RemoveContinuation() { }

	// RVA: 0x1D37F90 Offset: 0x1D37190 VA: 0x181D37F90
	public void PushContinuation(int continuation) { }

	// RVA: 0x1D38830 Offset: 0x1D37A30 VA: 0x181D38830
	public int YieldToCurrentContinuation() { }

	// RVA: 0x1D388B0 Offset: 0x1D37AB0 VA: 0x181D388B0
	public int YieldToPendingContinuation() { }

	// RVA: 0x1D37FD0 Offset: 0x1D371D0 VA: 0x181D37FD0
	internal void PushPendingContinuation() { }

	// RVA: 0x1D37EA0 Offset: 0x1D370A0 VA: 0x181D37EA0
	internal void PopPendingContinuation() { }

	// RVA: 0x1D37B80 Offset: 0x1D36D80 VA: 0x181D37B80
	public int Goto(int labelIndex, object value, bool gotoExceptionHandler) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class Interpreter // TypeDefIndex: 14990
{
	// Fields
	internal static readonly object NoValue; // 0x0
	internal const int RethrowOnReturn = 2147483647;
	private readonly InstructionArray _instructions; // 0x10
	internal readonly object[] _objects; // 0x38
	internal readonly RuntimeLabel[] _labels; // 0x40
	internal readonly DebugInfo[] _debugInfos; // 0x48
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly int <LocalCount>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly Dictionary<ParameterExpression, LocalVariable> <ClosureVariables>k__BackingField; // 0x60

	// Properties
	internal string Name { get; }
	internal int LocalCount { get; }
	internal int ClosureSize { get; }
	internal InstructionArray Instructions { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x1D38C50 Offset: 0x1D37E50 VA: 0x181D38C50
	internal void .ctor(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	internal int get_LocalCount() { }

	// RVA: 0x1D38CE0 Offset: 0x1D37EE0 VA: 0x181D38CE0
	internal int get_ClosureSize() { }

	// RVA: 0x4A1870 Offset: 0x4A0A70 VA: 0x1804A1870
	internal InstructionArray get_Instructions() { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x1D38B80 Offset: 0x1D37D80 VA: 0x181D38B80
	public void Run(InterpretedFrame frame) { }

	// RVA: 0x1D38BF0 Offset: 0x1D37DF0 VA: 0x181D38BF0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LabelInfo.<>c // TypeDefIndex: 14991
{
	// Fields
	public static readonly LabelInfo.<>c <>9; // 0x0
	public static Func<LabelScopeInfo, LabelScopeInfo> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x1D50930 Offset: 0x1D4FB30 VA: 0x181D50930
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A04C0 Offset: 0x59F6C0 VA: 0x1805A04C0
	internal LabelScopeInfo <ValidateJump>b__9_0(LabelScopeInfo b) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LabelInfo // TypeDefIndex: 14992
{
	// Fields
	private readonly LabelTarget _node; // 0x10
	private BranchLabel _label; // 0x18
	private object _definitions; // 0x20
	private readonly List<LabelScopeInfo> _references; // 0x28
	private bool _acrossBlockJump; // 0x30

	// Properties
	private bool HasDefinitions { get; }
	private bool HasMultipleDefinitions { get; }

	// Methods

	// RVA: 0x1D39A60 Offset: 0x1D38C60 VA: 0x181D39A60
	internal void .ctor(LabelTarget node) { }

	// RVA: 0x1D39530 Offset: 0x1D38730 VA: 0x181D39530
	internal BranchLabel GetLabel(LightCompiler compiler) { }

	// RVA: 0x1D39570 Offset: 0x1D38770 VA: 0x181D39570
	internal void Reference(LabelScopeInfo block) { }

	// RVA: 0x1D38E70 Offset: 0x1D38070 VA: 0x181D38E70
	internal void Define(LabelScopeInfo block) { }

	// RVA: 0x1D396B0 Offset: 0x1D388B0 VA: 0x181D396B0
	private void ValidateJump(LabelScopeInfo reference) { }

	// RVA: 0x1D39620 Offset: 0x1D38820 VA: 0x181D39620
	internal void ValidateFinish() { }

	// RVA: 0x1D39300 Offset: 0x1D38500 VA: 0x181D39300
	private void EnsureLabel(LightCompiler compiler) { }

	// RVA: 0x1D39240 Offset: 0x1D38440 VA: 0x181D39240
	private bool DefinedIn(LabelScopeInfo scope) { }

	// RVA: 0x1D39AE0 Offset: 0x1D38CE0 VA: 0x181D39AE0
	private bool get_HasDefinitions() { }

	// RVA: 0x1D39340 Offset: 0x1D38540 VA: 0x181D39340
	private LabelScopeInfo FirstDefinition() { }

	// RVA: 0x1D38D30 Offset: 0x1D37F30 VA: 0x181D38D30
	private void AddDefinition(LabelScopeInfo scope) { }

	// RVA: 0x1D39AF0 Offset: 0x1D38CF0 VA: 0x181D39AF0
	private bool get_HasMultipleDefinitions() { }

	// RVA: -1 Offset: -1
	internal static T CommonNode<T>(T first, T second, Func<T, T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2FD70 Offset: 0xA2EF70 VA: 0x180A2FD70
	|-LabelInfo.CommonNode<object>
	*/
}

// Namespace: System.Linq.Expressions.Interpreter
internal enum LabelScopeKind // TypeDefIndex: 14993
{
	// Fields
	public int value__; // 0x0
	public const LabelScopeKind Statement = 0;
	public const LabelScopeKind Block = 1;
	public const LabelScopeKind Switch = 2;
	public const LabelScopeKind Lambda = 3;
	public const LabelScopeKind Try = 4;
	public const LabelScopeKind Catch = 5;
	public const LabelScopeKind Finally = 6;
	public const LabelScopeKind Filter = 7;
	public const LabelScopeKind Expression = 8;
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LabelScopeInfo // TypeDefIndex: 14994
{
	// Fields
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; // 0x10
	internal readonly LabelScopeKind Kind; // 0x18
	internal readonly LabelScopeInfo Parent; // 0x20

	// Properties
	internal bool CanJumpInto { get; }

	// Methods

	// RVA: 0x1D39D00 Offset: 0x1D38F00 VA: 0x181D39D00
	internal void .ctor(LabelScopeInfo parent, LabelScopeKind kind) { }

	// RVA: 0x1D39D40 Offset: 0x1D38F40 VA: 0x181D39D40
	internal bool get_CanJumpInto() { }

	// RVA: 0x1D39C20 Offset: 0x1D38E20 VA: 0x181D39C20
	internal bool ContainsTarget(LabelTarget target) { }

	// RVA: 0x1D39C80 Offset: 0x1D38E80 VA: 0x181D39C80
	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

	// RVA: 0x1D39B70 Offset: 0x1D38D70 VA: 0x181D39B70
	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftSByte : LeftShiftInstruction // TypeDefIndex: 14995
{
	// Methods

	// RVA: 0x1D3A810 Offset: 0x1D39A10 VA: 0x181D3A810 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftInt16 : LeftShiftInstruction // TypeDefIndex: 14996
{
	// Methods

	// RVA: 0x1D3A320 Offset: 0x1D39520 VA: 0x181D3A320 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftInt32 : LeftShiftInstruction // TypeDefIndex: 14997
{
	// Methods

	// RVA: 0x1D3A510 Offset: 0x1D39710 VA: 0x181D3A510 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftInt64 : LeftShiftInstruction // TypeDefIndex: 14998
{
	// Methods

	// RVA: 0x1D3A650 Offset: 0x1D39850 VA: 0x181D3A650 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftByte : LeftShiftInstruction // TypeDefIndex: 14999
{
	// Methods

	// RVA: 0x1D39D50 Offset: 0x1D38F50 VA: 0x181D39D50 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftUInt16 : LeftShiftInstruction // TypeDefIndex: 15000
{
	// Methods

	// RVA: 0x1D3AA00 Offset: 0x1D39C00 VA: 0x181D3AA00 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftUInt32 : LeftShiftInstruction // TypeDefIndex: 15001
{
	// Methods

	// RVA: 0x1D3ABF0 Offset: 0x1D39DF0 VA: 0x181D3ABF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftUInt64 : LeftShiftInstruction // TypeDefIndex: 15002
{
	// Methods

	// RVA: 0x1D3ADB0 Offset: 0x1D39FB0 VA: 0x181D3ADB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LeftShiftInstruction : Instruction // TypeDefIndex: 15003
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D3A2F0 Offset: 0x1D394F0 VA: 0x181D3A2F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D39F40 Offset: 0x1D39140 VA: 0x181D39F40
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanSByte : LessThanInstruction // TypeDefIndex: 15004
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3E0C0 Offset: 0x1D3D2C0 VA: 0x181D3E0C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanInt16 : LessThanInstruction // TypeDefIndex: 15005
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3BFD0 Offset: 0x1D3B1D0 VA: 0x181D3BFD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanChar : LessThanInstruction // TypeDefIndex: 15006
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3B0F0 Offset: 0x1D3A2F0 VA: 0x181D3B0F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanInt32 : LessThanInstruction // TypeDefIndex: 15007
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3C150 Offset: 0x1D3B350 VA: 0x181D3C150 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanInt64 : LessThanInstruction // TypeDefIndex: 15008
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3C2D0 Offset: 0x1D3B4D0 VA: 0x181D3C2D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanByte : LessThanInstruction // TypeDefIndex: 15009
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3AF70 Offset: 0x1D3A170 VA: 0x181D3AF70 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanUInt16 : LessThanInstruction // TypeDefIndex: 15010
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3E3D0 Offset: 0x1D3D5D0 VA: 0x181D3E3D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanUInt32 : LessThanInstruction // TypeDefIndex: 15011
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3E550 Offset: 0x1D3D750 VA: 0x181D3E550 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanUInt64 : LessThanInstruction // TypeDefIndex: 15012
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3E6D0 Offset: 0x1D3D8D0 VA: 0x181D3E6D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanSingle : LessThanInstruction // TypeDefIndex: 15013
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3E240 Offset: 0x1D3D440 VA: 0x181D3E240 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanDouble : LessThanInstruction // TypeDefIndex: 15014
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3B270 Offset: 0x1D3A470 VA: 0x181D3B270 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LessThanInstruction : Instruction // TypeDefIndex: 15015
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D3BFA0 Offset: 0x1D3B1A0 VA: 0x181D3BFA0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	private void .ctor(object nullValue) { }

	// RVA: 0x1D3B400 Offset: 0x1D3A600 VA: 0x181D3B400
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualSByte : LessThanOrEqualInstruction // TypeDefIndex: 15016
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3D930 Offset: 0x1D3CB30 VA: 0x181D3D930 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualInt16 : LessThanOrEqualInstruction // TypeDefIndex: 15017
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3D4B0 Offset: 0x1D3C6B0 VA: 0x181D3D4B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualChar : LessThanOrEqualInstruction // TypeDefIndex: 15018
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3C5D0 Offset: 0x1D3B7D0 VA: 0x181D3C5D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualInt32 : LessThanOrEqualInstruction // TypeDefIndex: 15019
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3D630 Offset: 0x1D3C830 VA: 0x181D3D630 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualInt64 : LessThanOrEqualInstruction // TypeDefIndex: 15020
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3D7B0 Offset: 0x1D3C9B0 VA: 0x181D3D7B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualByte : LessThanOrEqualInstruction // TypeDefIndex: 15021
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3C450 Offset: 0x1D3B650 VA: 0x181D3C450 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualUInt16 : LessThanOrEqualInstruction // TypeDefIndex: 15022
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3DC40 Offset: 0x1D3CE40 VA: 0x181D3DC40 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualUInt32 : LessThanOrEqualInstruction // TypeDefIndex: 15023
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3DDC0 Offset: 0x1D3CFC0 VA: 0x181D3DDC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualUInt64 : LessThanOrEqualInstruction // TypeDefIndex: 15024
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3DF40 Offset: 0x1D3D140 VA: 0x181D3DF40 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualSingle : LessThanOrEqualInstruction // TypeDefIndex: 15025
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3DAB0 Offset: 0x1D3CCB0 VA: 0x181D3DAB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualDouble : LessThanOrEqualInstruction // TypeDefIndex: 15026
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object nullValue) { }

	// RVA: 0x1D3C750 Offset: 0x1D3B950 VA: 0x181D3C750 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LessThanOrEqualInstruction : Instruction // TypeDefIndex: 15027
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D3D480 Offset: 0x1D3C680 VA: 0x181D3D480 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	private void .ctor(object nullValue) { }

	// RVA: 0x1D3C8E0 Offset: 0x1D3BAE0 VA: 0x181D3C8E0
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ExceptionFilter // TypeDefIndex: 15028
{
	// Fields
	public readonly int LabelIndex; // 0x10
	public readonly int StartIndex; // 0x14
	public readonly int EndIndex; // 0x18

	// Methods

	// RVA: 0x15E5C40 Offset: 0x15E4E40 VA: 0x1815E5C40
	internal void .ctor(int labelIndex, int start, int end) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ExceptionHandler // TypeDefIndex: 15029
{
	// Fields
	private readonly Type _exceptionType; // 0x10
	public readonly int LabelIndex; // 0x18
	public readonly int HandlerStartIndex; // 0x1C
	public readonly int HandlerEndIndex; // 0x20
	public readonly ExceptionFilter Filter; // 0x28

	// Methods

	// RVA: 0x1D37020 Offset: 0x1D36220 VA: 0x181D37020
	internal void .ctor(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter) { }

	// RVA: 0x1D36EF0 Offset: 0x1D360F0 VA: 0x181D36EF0
	public bool Matches(Type exceptionType) { }

	// RVA: 0x1D36F20 Offset: 0x1D36120 VA: 0x181D36F20 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TryCatchFinallyHandler // TypeDefIndex: 15030
{
	// Fields
	internal readonly int TryStartIndex; // 0x10
	internal readonly int TryEndIndex; // 0x14
	internal readonly int FinallyStartIndex; // 0x18
	internal readonly int FinallyEndIndex; // 0x1C
	internal readonly int GotoEndTargetIndex; // 0x20
	private readonly ExceptionHandler[] _handlers; // 0x28

	// Properties
	internal bool IsFinallyBlockExist { get; }
	internal ExceptionHandler[] Handlers { get; }
	internal bool IsCatchBlockExist { get; }

	// Methods

	// RVA: 0x1D50410 Offset: 0x1D4F610 VA: 0x181D50410
	internal bool get_IsFinallyBlockExist() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal ExceptionHandler[] get_Handlers() { }

	// RVA: 0x6B5280 Offset: 0x6B4480 VA: 0x1806B5280
	internal bool get_IsCatchBlockExist() { }

	// RVA: 0x1D503B0 Offset: 0x1D4F5B0 VA: 0x181D503B0
	internal void .ctor(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers) { }

	// RVA: 0x1D50350 Offset: 0x1D4F550 VA: 0x181D50350
	internal void .ctor(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers) { }

	// RVA: 0x1D501E0 Offset: 0x1D4F3E0 VA: 0x181D501E0
	internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException) { }

	// RVA: 0x1D4FF80 Offset: 0x1D4F180 VA: 0x181D4FF80
	private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TryFaultHandler // TypeDefIndex: 15031
{
	// Fields
	internal readonly int TryStartIndex; // 0x10
	internal readonly int TryEndIndex; // 0x14
	internal readonly int FinallyStartIndex; // 0x18
	internal readonly int FinallyEndIndex; // 0x1C

	// Methods

	// RVA: 0x18BA040 Offset: 0x18B9240 VA: 0x1818BA040
	internal void .ctor(int tryStart, int tryEnd, int finallyStart, int finallyEnd) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class RethrowException : Exception // TypeDefIndex: 15032
{
	// Methods

	// RVA: 0x1D4FF30 Offset: 0x1D4F130 VA: 0x181D4FF30
	public void .ctor() { }
}

// Namespace: 
private class DebugInfo.DebugInfoComparer : IComparer<DebugInfo> // TypeDefIndex: 15033
{
	// Methods

	// RVA: 0x1D364A0 Offset: 0x1D356A0 VA: 0x181D364A0 Slot: 4
	private int System.Collections.Generic.IComparer<System.Linq.Expressions.Interpreter.DebugInfo>.Compare(DebugInfo d1, DebugInfo d2) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DebugInfo // TypeDefIndex: 15034
{
	// Fields
	public int StartLine; // 0x10
	public int EndLine; // 0x14
	public int Index; // 0x18
	public string FileName; // 0x20
	public bool IsClear; // 0x28
	private static readonly DebugInfo.DebugInfoComparer s_debugComparer; // 0x0

	// Methods

	// RVA: 0x1D364E0 Offset: 0x1D356E0 VA: 0x181D364E0
	public static DebugInfo GetMatchingDebugInfo(DebugInfo[] debugInfos, int index) { }

	// RVA: 0x1D365D0 Offset: 0x1D357D0 VA: 0x181D365D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D36850 Offset: 0x1D35A50 VA: 0x181D36850
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
[IsReadOnly]
internal struct InterpretedFrameInfo // TypeDefIndex: 15035
{
	// Fields
	private readonly string _methodName; // 0x0
	private readonly DebugInfo _debugInfo; // 0x8

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(string methodName, DebugInfo info) { }

	// RVA: 0x1D37790 Offset: 0x1D36990 VA: 0x181D37790 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private sealed class LightCompiler.QuoteVisitor : ExpressionVisitor // TypeDefIndex: 15036
{
	// Fields
	private readonly Dictionary<ParameterExpression, int> _definedParameters; // 0x10
	public readonly HashSet<ParameterExpression> _hoistedParameters; // 0x18

	// Methods

	// RVA: 0x1D4FE00 Offset: 0x1D4F000 VA: 0x181D4FE00 Slot: 23
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x1D4FC20 Offset: 0x1D4EE20 VA: 0x181D4FC20 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1D4FC90 Offset: 0x1D4EE90 VA: 0x181D4FC90 Slot: 27
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: -1 Offset: -1 Slot: 16
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD5360 Offset: 0xAD4560 VA: 0x180AD5360
	|-LightCompiler.QuoteVisitor.VisitLambda<object>
	|
	|-RVA: 0xAD51B0 Offset: 0xAD43B0 VA: 0x180AD51B0
	|-LightCompiler.QuoteVisitor.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D4F9F0 Offset: 0x1D4EBF0 VA: 0x181D4F9F0
	private void PushParameters(IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1D4F7B0 Offset: 0x1D4E9B0 VA: 0x181D4F7B0
	private void PopParameters(IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1D4FE80 Offset: 0x1D4F080 VA: 0x181D4FE80
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LightCompiler.<>c // TypeDefIndex: 15037
{
	// Fields
	public static readonly LightCompiler.<>c <>9; // 0x0
	public static Func<Expression, bool> <>9__56_1; // 0x8
	public static Func<SwitchCase, bool> <>9__56_0; // 0x10
	public static Action<LightCompiler, Expression> <>9__101_0; // 0x18

	// Methods

	// RVA: 0x1D508D0 Offset: 0x1D4FAD0 VA: 0x181D508D0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D50740 Offset: 0x1D4F940 VA: 0x181D50740
	internal bool <CompileSwitchExpression>b__56_0(SwitchCase c) { }

	// RVA: 0x1D50850 Offset: 0x1D4FA50 VA: 0x181D50850
	internal bool <CompileSwitchExpression>b__56_1(Expression t) { }

	// RVA: 0x1D50710 Offset: 0x1D4F910 VA: 0x181D50710
	internal void <CompileNoLabelPush>b__101_0(LightCompiler this, Expression e) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LightCompiler // TypeDefIndex: 15038
{
	// Fields
	private readonly InstructionList _instructions; // 0x10
	private readonly LocalVariables _locals; // 0x18
	private readonly List<DebugInfo> _debugInfos; // 0x20
	private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels; // 0x28
	private LabelScopeInfo _labelBlock; // 0x30
	private readonly Stack<ParameterExpression> _exceptionForRethrowStack; // 0x38
	private readonly LightCompiler _parent; // 0x40
	private readonly StackGuard _guard; // 0x48
	private static readonly LocalDefinition[] s_emptyLocals; // 0x0

	// Properties
	public InstructionList Instructions { get; }

	// Methods

	// RVA: 0x1D4D5C0 Offset: 0x1D4C7C0 VA: 0x181D4D5C0
	public void .ctor() { }

	// RVA: 0x1D4D410 Offset: 0x1D4C610 VA: 0x181D4D410
	private void .ctor(LightCompiler parent) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public InstructionList get_Instructions() { }

	// RVA: 0x1D49D00 Offset: 0x1D48F00 VA: 0x181D49D00
	public LightDelegateCreator CompileTop(LambdaExpression node) { }

	// RVA: 0x1D4C840 Offset: 0x1D4BA40 VA: 0x181D4C840
	private Interpreter MakeInterpreter(string lambdaName) { }

	// RVA: 0x1D42130 Offset: 0x1D41330 VA: 0x181D42130
	private void CompileConstantExpression(Expression expr) { }

	// RVA: 0x1D43150 Offset: 0x1D42350 VA: 0x181D43150
	private void CompileDefaultExpression(Expression expr) { }

	// RVA: 0x1D43040 Offset: 0x1D42240 VA: 0x181D43040
	private void CompileDefaultExpression(Type type) { }

	// RVA: 0x1D4C3B0 Offset: 0x1D4B5B0 VA: 0x181D4C3B0
	private LocalVariable EnsureAvailableForClosure(ParameterExpression expr) { }

	// RVA: 0x1D4CD60 Offset: 0x1D4BF60 VA: 0x181D4CD60
	private LocalVariable ResolveLocal(ParameterExpression variable) { }

	// RVA: 0x1D43420 Offset: 0x1D42620 VA: 0x181D43420
	private void CompileGetVariable(ParameterExpression variable) { }

	// RVA: 0x1D4BE70 Offset: 0x1D4B070 VA: 0x181D4BE70
	private void EmitCopyValueType(Type valueType) { }

	// RVA: 0x1D4C760 Offset: 0x1D4B960 VA: 0x181D4C760
	private void LoadLocalNoValueTypeCopy(ParameterExpression variable) { }

	// RVA: 0x1D4CBA0 Offset: 0x1D4BDA0 VA: 0x181D4CBA0
	private bool MaybeMutableValueType(Type type) { }

	// RVA: 0x1D43370 Offset: 0x1D42570 VA: 0x181D43370
	private void CompileGetBoxedVariable(ParameterExpression variable) { }

	// RVA: 0x1D48C10 Offset: 0x1D47E10 VA: 0x181D48C10
	private void CompileSetVariable(ParameterExpression variable, bool isVoid) { }

	// RVA: 0x1D485A0 Offset: 0x1D477A0 VA: 0x181D485A0
	private void CompileParameterExpression(Expression expr) { }

	// RVA: 0x1D40FC0 Offset: 0x1D401C0 VA: 0x181D40FC0
	private void CompileBlockExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1D41190 Offset: 0x1D40390 VA: 0x181D41190
	private LocalDefinition[] CompileBlockStart(BlockExpression node) { }

	// RVA: 0x1D40F10 Offset: 0x1D40110 VA: 0x181D40F10
	private void CompileBlockEnd(LocalDefinition[] locals) { }

	// RVA: 0x1D43B40 Offset: 0x1D42D40 VA: 0x181D43B40
	private void CompileIndexExpression(Expression expr) { }

	// RVA: 0x1D4BF30 Offset: 0x1D4B130 VA: 0x181D4BF30
	private void EmitIndexGet(IndexExpression index) { }

	// RVA: 0x1D437E0 Offset: 0x1D429E0 VA: 0x181D437E0
	private void CompileIndexAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x1D45A20 Offset: 0x1D44C20 VA: 0x181D45A20
	private void CompileMemberAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x1D455F0 Offset: 0x1D447F0 VA: 0x181D455F0
	private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding) { }

	// RVA: 0x1D4BAA0 Offset: 0x1D4ACA0 VA: 0x181D4BAA0
	private void CompileVariableAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x1D3FC00 Offset: 0x1D3EE00 VA: 0x181D3FC00
	private void CompileAssignBinaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1D3FEE0 Offset: 0x1D3F0E0 VA: 0x181D3FEE0
	private void CompileBinaryExpression(Expression expr) { }

	// RVA: 0x1D43280 Offset: 0x1D42480 VA: 0x181D43280
	private void CompileEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x1D48360 Offset: 0x1D47560 VA: 0x181D48360
	private void CompileNotEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x1D41C60 Offset: 0x1D40E60 VA: 0x181D41C60
	private void CompileComparison(BinaryExpression node) { }

	// RVA: 0x1D3F4B0 Offset: 0x1D3E6B0 VA: 0x181D3F4B0
	private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right) { }

	// RVA: 0x1D42790 Offset: 0x1D41990 VA: 0x181D42790
	private void CompileConvertUnaryExpression(Expression expr) { }

	// RVA: 0x1D42200 Offset: 0x1D41400 VA: 0x181D42200
	private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull) { }

	// RVA: 0x1D48450 Offset: 0x1D47650 VA: 0x181D48450
	private void CompileNotExpression(UnaryExpression node) { }

	// RVA: 0x1D4B280 Offset: 0x1D4A480 VA: 0x181D4B280
	private void CompileUnaryExpression(Expression expr) { }

	// RVA: 0x1D4C280 Offset: 0x1D4B480 VA: 0x181D4C280
	private void EmitUnaryMethodCall(UnaryExpression node) { }

	// RVA: 0x1D4C040 Offset: 0x1D4B240 VA: 0x181D4C040
	private void EmitUnaryBoolCheck(UnaryExpression node) { }

	// RVA: 0x1D3F410 Offset: 0x1D3E610 VA: 0x181D3F410
	private void CompileAndAlsoBinaryExpression(Expression expr) { }

	// RVA: 0x1D48500 Offset: 0x1D47700 VA: 0x181D48500
	private void CompileOrElseBinaryExpression(Expression expr) { }

	// RVA: 0x1D45170 Offset: 0x1D44370 VA: 0x181D45170
	private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso) { }

	// RVA: 0x1D469C0 Offset: 0x1D45BC0 VA: 0x181D469C0
	private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x1D44570 Offset: 0x1D43770 VA: 0x181D44570
	private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso) { }

	// RVA: 0x1D4B910 Offset: 0x1D4AB10 VA: 0x181D4B910
	private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x1D41ED0 Offset: 0x1D410D0 VA: 0x181D41ED0
	private void CompileConditionalExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1D452F0 Offset: 0x1D444F0 VA: 0x181D452F0
	private void CompileLoopExpression(Expression expr) { }

	// RVA: 0x1D49340 Offset: 0x1D48540 VA: 0x181D49340
	private void CompileSwitchExpression(Expression expr) { }

	// RVA: -1 Offset: -1
	private void CompileIntSwitchExpression<T>(SwitchExpression node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA32010 Offset: 0xA31210 VA: 0x180A32010
	|-LightCompiler.CompileIntSwitchExpression<int>
	|
	|-RVA: 0xA324F0 Offset: 0xA316F0 VA: 0x180A324F0
	|-LightCompiler.CompileIntSwitchExpression<object>
	|
	|-RVA: 0xA31A50 Offset: 0xA30C50 VA: 0x180A31A50
	|-LightCompiler.CompileIntSwitchExpression<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D48D80 Offset: 0x1D47F80 VA: 0x181D48D80
	private void CompileStringSwitchExpression(SwitchExpression node) { }

	// RVA: 0x1D43F10 Offset: 0x1D43110 VA: 0x181D43F10
	private void CompileLabelExpression(Expression expr) { }

	// RVA: 0x1D43500 Offset: 0x1D42700 VA: 0x181D43500
	private void CompileGotoExpression(Expression expr) { }

	// RVA: 0x1D4CC20 Offset: 0x1D4BE20 VA: 0x181D4CC20
	private void PushLabelBlock(LabelScopeKind type) { }

	// RVA: 0x1D4CC00 Offset: 0x1D4BE00 VA: 0x181D4CC00
	private void PopLabelBlock(LabelScopeKind kind) { }

	// RVA: 0x1D4C510 Offset: 0x1D4B710 VA: 0x181D4C510
	private LabelInfo EnsureLabel(LabelTarget node) { }

	// RVA: 0x1D4CCA0 Offset: 0x1D4BEA0 VA: 0x181D4CCA0
	private LabelInfo ReferenceLabel(LabelTarget node) { }

	// RVA: 0x1D4BDD0 Offset: 0x1D4AFD0 VA: 0x181D4BDD0
	private LabelInfo DefineLabel(LabelTarget node) { }

	// RVA: 0x1D4CF80 Offset: 0x1D4C180 VA: 0x181D4CF80
	private bool TryPushLabelBlock(Expression node) { }

	// RVA: 0x1D4BC90 Offset: 0x1D4AE90 VA: 0x181D4BC90
	private void DefineBlockLabels(Expression node) { }

	// RVA: 0x1D3E850 Offset: 0x1D3DA50 VA: 0x181D3E850
	private void CheckRethrow() { }

	// RVA: 0x1D49B00 Offset: 0x1D48D00 VA: 0x181D49B00
	private void CompileThrowUnaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1D49F40 Offset: 0x1D49140 VA: 0x181D49F40
	private void CompileTryExpression(Expression expr) { }

	// RVA: 0x1D4AA00 Offset: 0x1D49C00 VA: 0x181D4AA00
	private void CompileTryFaultExpression(TryExpression expr) { }

	// RVA: 0x1D46900 Offset: 0x1D45B00 VA: 0x181D46900
	private void CompileMethodCallExpression(Expression expr) { }

	// RVA: 0x1D46440 Offset: 0x1D45640 VA: 0x181D46440
	private void CompileMethodCallExpression(Expression object, MethodInfo method, IArgumentProvider arguments) { }

	// RVA: 0x1D3F7C0 Offset: 0x1D3E9C0 VA: 0x181D3F7C0
	private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex) { }

	// RVA: 0x1D4C030 Offset: 0x1D4B230 VA: 0x181D4C030
	private void EmitThisForMethodCall(Expression node) { }

	// RVA: 0x1D4CDD0 Offset: 0x1D4BFD0 VA: 0x181D4CDD0
	private static bool ShouldWritebackNode(Expression node) { }

	// RVA: 0x1D3E8B0 Offset: 0x1D3DAB0 VA: 0x181D3E8B0
	private ByRefUpdater CompileAddress(Expression node, int index) { }

	// RVA: 0x1D46BB0 Offset: 0x1D45DB0 VA: 0x181D46BB0
	private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index) { }

	// RVA: 0x1D473D0 Offset: 0x1D465D0 VA: 0x181D473D0
	private void CompileNewExpression(Expression expr) { }

	// RVA: 0x1D45B20 Offset: 0x1D44D20 VA: 0x181D45B20
	private void CompileMemberExpression(Expression expr) { }

	// RVA: 0x1D460D0 Offset: 0x1D452D0 VA: 0x181D460D0
	private void CompileMember(Expression from, MemberInfo member, bool forBinding) { }

	// RVA: 0x1D47080 Offset: 0x1D46280 VA: 0x181D47080
	private void CompileNewArrayExpression(Expression expr) { }

	// RVA: 0x1D42E80 Offset: 0x1D42080 VA: 0x181D42E80
	private void CompileDebugInfoExpression(Expression expr) { }

	// RVA: 0x1D489C0 Offset: 0x1D47BC0 VA: 0x181D489C0
	private void CompileRuntimeVariablesExpression(Expression expr) { }

	// RVA: 0x1D441C0 Offset: 0x1D433C0 VA: 0x181D441C0
	private void CompileLambdaExpression(Expression expr) { }

	// RVA: 0x1D41550 Offset: 0x1D40750 VA: 0x181D41550
	private void CompileCoalesceBinaryExpression(Expression expr) { }

	// RVA: 0x1D43C70 Offset: 0x1D42E70 VA: 0x181D43C70
	private void CompileInvocationExpression(Expression expr) { }

	// RVA: 0x1D44E40 Offset: 0x1D44040 VA: 0x181D44E40
	private void CompileListInitExpression(Expression expr) { }

	// RVA: 0x1D44ED0 Offset: 0x1D440D0 VA: 0x181D44ED0
	private void CompileListInit(ReadOnlyCollection<ElementInit> initializers) { }

	// RVA: 0x1D45BE0 Offset: 0x1D44DE0 VA: 0x181D45BE0
	private void CompileMemberInitExpression(Expression expr) { }

	// RVA: 0x1D45C70 Offset: 0x1D44E70 VA: 0x181D45C70
	private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings) { }

	// RVA: 0x1D4C5E0 Offset: 0x1D4B7E0 VA: 0x181D4C5E0
	private static Type GetMemberType(MemberInfo member) { }

	// RVA: 0x1D48640 Offset: 0x1D47840 VA: 0x181D48640
	private void CompileQuoteUnaryExpression(Expression expr) { }

	// RVA: 0x1D4B790 Offset: 0x1D4A990 VA: 0x181D4B790
	private void CompileUnboxUnaryExpression(Expression expr) { }

	// RVA: 0x1D4ADE0 Offset: 0x1D49FE0 VA: 0x181D4ADE0
	private void CompileTypeEqualExpression(Expression expr) { }

	// RVA: 0x1D4AD40 Offset: 0x1D49F40 VA: 0x181D4AD40
	private void CompileTypeAsExpression(UnaryExpression node) { }

	// RVA: 0x1D4B000 Offset: 0x1D4A200 VA: 0x181D4B000
	private void CompileTypeIsExpression(Expression expr) { }

	// RVA: 0x1D4BC10 Offset: 0x1D4AE10 VA: 0x181D4BC10
	private void Compile(Expression expr, bool asVoid) { }

	// RVA: 0x1D3FA70 Offset: 0x1D3EC70 VA: 0x181D3FA70
	private void CompileAsVoid(Expression expr) { }

	// RVA: 0x1D47750 Offset: 0x1D46950 VA: 0x181D47750
	private void CompileNoLabelPush(Expression expr) { }

	// RVA: 0x1D4BBB0 Offset: 0x1D4ADB0 VA: 0x181D4BBB0
	private void Compile(Expression expr) { }

	// RVA: 0x1D4D360 Offset: 0x1D4C560 VA: 0x181D4D360
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ByRefUpdater // TypeDefIndex: 15039
{
	// Fields
	public readonly int ArgumentIndex; // 0x10

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int argumentIndex) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update(InterpretedFrame frame, object value);

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ParameterByRefUpdater : ByRefUpdater // TypeDefIndex: 15040
{
	// Fields
	private readonly LocalVariable _parameter; // 0x18

	// Methods

	// RVA: 0x1D4F5F0 Offset: 0x1D4E7F0 VA: 0x181D4F5F0
	public void .ctor(LocalVariable parameter, int argumentIndex) { }

	// RVA: 0x1D4F430 Offset: 0x1D4E630 VA: 0x181D4F430 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ArrayByRefUpdater : ByRefUpdater // TypeDefIndex: 15041
{
	// Fields
	private readonly LocalDefinition _array; // 0x18
	private readonly LocalDefinition _index; // 0x28

	// Methods

	// RVA: 0x1D36450 Offset: 0x1D35650 VA: 0x181D36450
	public void .ctor(LocalDefinition array, LocalDefinition index, int argumentIndex) { }

	// RVA: 0x1D362D0 Offset: 0x1D354D0 VA: 0x181D362D0 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x1D36240 Offset: 0x1D35440 VA: 0x181D36240 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class FieldByRefUpdater : ByRefUpdater // TypeDefIndex: 15042
{
	// Fields
	private readonly Nullable<LocalDefinition> _object; // 0x18
	private readonly FieldInfo _field; // 0x30

	// Methods

	// RVA: 0x1D371C0 Offset: 0x1D363C0 VA: 0x181D371C0
	public void .ctor(Nullable<LocalDefinition> obj, FieldInfo field, int argumentIndex) { }

	// RVA: 0x1D37120 Offset: 0x1D36320 VA: 0x181D37120 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x1D37080 Offset: 0x1D36280 VA: 0x181D37080 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class PropertyByRefUpdater : ByRefUpdater // TypeDefIndex: 15043
{
	// Fields
	private readonly Nullable<LocalDefinition> _object; // 0x18
	private readonly PropertyInfo _property; // 0x30

	// Methods

	// RVA: 0x1D371C0 Offset: 0x1D363C0 VA: 0x181D371C0
	public void .ctor(Nullable<LocalDefinition> obj, PropertyInfo property, int argumentIndex) { }

	// RVA: 0x1D4F6D0 Offset: 0x1D4E8D0 VA: 0x181D4F6D0 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x1D4F630 Offset: 0x1D4E830 VA: 0x181D4F630 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class IndexMethodByRefUpdater : ByRefUpdater // TypeDefIndex: 15044
{
	// Fields
	private readonly MethodInfo _indexer; // 0x18
	private readonly Nullable<LocalDefinition> _obj; // 0x20
	private readonly LocalDefinition[] _args; // 0x38

	// Methods

	// RVA: 0x1D37580 Offset: 0x1D36780 VA: 0x181D37580
	public void .ctor(Nullable<LocalDefinition> obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex) { }

	// RVA: 0x1D37350 Offset: 0x1D36550 VA: 0x181D37350 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x1D37220 Offset: 0x1D36420 VA: 0x181D37220 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LightDelegateCreator // TypeDefIndex: 15045
{
	// Fields
	private readonly LambdaExpression _lambda; // 0x10
	[CompilerGenerated]
	private readonly Interpreter <Interpreter>k__BackingField; // 0x18

	// Properties
	internal Interpreter Interpreter { get; }

	// Methods

	// RVA: 0x162EF30 Offset: 0x162E130 VA: 0x18162EF30
	internal void .ctor(Interpreter interpreter, LambdaExpression lambda) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal Interpreter get_Interpreter() { }

	// RVA: 0x1D4D760 Offset: 0x1D4C960 VA: 0x181D4D760
	public Delegate CreateDelegate() { }

	// RVA: 0x1D4D860 Offset: 0x1D4CA60 VA: 0x181D4D860
	internal Delegate CreateDelegate(IStrongBox[] closure) { }
}

// Namespace: 
private class LightLambda.DebugViewPrinter // TypeDefIndex: 15046
{
	// Fields
	private readonly Interpreter _interpreter; // 0x10
	private readonly Dictionary<int, int> _tryStart; // 0x18
	private readonly Dictionary<int, string> _handlerEnter; // 0x20
	private readonly Dictionary<int, int> _handlerExit; // 0x28
	private string _indent; // 0x30

	// Methods

	// RVA: 0x1D550B0 Offset: 0x1D542B0 VA: 0x181D550B0
	public void .ctor(Interpreter interpreter) { }

	// RVA: 0x1D54640 Offset: 0x1D53840 VA: 0x181D54640
	private void Analyze() { }

	// RVA: 0x1D54580 Offset: 0x1D53780 VA: 0x181D54580
	private void AddTryStart(int index) { }

	// RVA: 0x1D544E0 Offset: 0x1D536E0 VA: 0x181D544E0
	private void AddHandlerExit(int index) { }

	// RVA: 0x1D54A90 Offset: 0x1D53C90 VA: 0x181D54A90
	private void Indent() { }

	// RVA: 0x1D54960 Offset: 0x1D53B60 VA: 0x181D54960
	private void Dedent() { }

	// RVA: 0x1D54AD0 Offset: 0x1D53CD0 VA: 0x181D54AD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D549A0 Offset: 0x1D53BA0 VA: 0x181D549A0
	private void EmitExits(StringBuilder sb, int index) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LightLambda.<>c__DisplayClass74_0 // TypeDefIndex: 15047
{
	// Fields
	public MethodInfo targetMethod; // 0x10
	public Type delegateType; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D6C1C0 Offset: 0x1D6B3C0 VA: 0x181D6C1C0
	internal Delegate <MakeRunDelegateCtor>b__0(LightLambda lambda) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class LightLambda // TypeDefIndex: 15048
{
	// Fields
	internal const int MaxParameters = 16;
	private readonly IStrongBox[] _closure; // 0x10
	private readonly Interpreter _interpreter; // 0x18
	private static readonly CacheDict<Type, Func<LightLambda, Delegate>> _runCache; // 0x0
	private readonly LightDelegateCreator _delegateCreator; // 0x20

	// Properties
	internal string DebugView { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal TRet Run0<TRet>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA32A50 Offset: 0xA31C50 VA: 0x180A32A50
	|-LightLambda.Run0<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D4EE20 Offset: 0x1D4E020 VA: 0x181D4EE20
	internal void RunVoid0() { }

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun0<TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun0<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D4EDB0 Offset: 0x1D4DFB0 VA: 0x181D4EDB0
	internal static Delegate MakeRunVoid0(LightLambda lambda) { }

	// RVA: -1 Offset: -1
	internal TRet Run1<T0, TRet>(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA372B0 Offset: 0xA364B0 VA: 0x180A372B0
	|-LightLambda.Run1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid1<T0>(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3E7E0 Offset: 0xA3D9E0 VA: 0x180A3E7E0
	|-LightLambda.RunVoid1<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun1<T0, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid1<T0>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid1<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run2<T0, T1, TRet>(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA37510 Offset: 0xA36710 VA: 0x180A37510
	|-LightLambda.Run2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid2<T0, T1>(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3E980 Offset: 0xA3DB80 VA: 0x180A3E980
	|-LightLambda.RunVoid2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun2<T0, T1, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid2<T0, T1>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run3<T0, T1, T2, TRet>(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA37840 Offset: 0xA36A40 VA: 0x180A37840
	|-LightLambda.Run3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3EC10 Offset: 0xA3DE10 VA: 0x180A3EC10
	|-LightLambda.RunVoid3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun3<T0, T1, T2, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid3<T0, T1, T2>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run4<T0, T1, T2, T3, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA37C30 Offset: 0xA36E30 VA: 0x180A37C30
	|-LightLambda.Run4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3EF70 Offset: 0xA3E170 VA: 0x180A3EF70
	|-LightLambda.RunVoid4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun4<T0, T1, T2, T3, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid4<T0, T1, T2, T3>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run5<T0, T1, T2, T3, T4, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA380E0 Offset: 0xA372E0 VA: 0x180A380E0
	|-LightLambda.Run5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3F3A0 Offset: 0xA3E5A0 VA: 0x180A3F3A0
	|-LightLambda.RunVoid5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun5<T0, T1, T2, T3, T4, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid5<T0, T1, T2, T3, T4>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run6<T0, T1, T2, T3, T4, T5, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA38660 Offset: 0xA37860 VA: 0x180A38660
	|-LightLambda.Run6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3F8A0 Offset: 0xA3EAA0 VA: 0x180A3F8A0
	|-LightLambda.RunVoid6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun6<T0, T1, T2, T3, T4, T5, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid6<T0, T1, T2, T3, T4, T5>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run7<T0, T1, T2, T3, T4, T5, T6, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA38CA0 Offset: 0xA37EA0 VA: 0x180A38CA0
	|-LightLambda.Run7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3FE60 Offset: 0xA3F060 VA: 0x180A3FE60
	|-LightLambda.RunVoid7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun7<T0, T1, T2, T3, T4, T5, T6, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid7<T0, T1, T2, T3, T4, T5, T6>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA393B0 Offset: 0xA385B0 VA: 0x180A393B0
	|-LightLambda.Run8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA404F0 Offset: 0xA3F6F0 VA: 0x180A404F0
	|-LightLambda.RunVoid8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA39BA0 Offset: 0xA38DA0 VA: 0x180A39BA0
	|-LightLambda.Run9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA40C40 Offset: 0xA3FE40 VA: 0x180A40C40
	|-LightLambda.RunVoid9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA32BE0 Offset: 0xA31DE0 VA: 0x180A32BE0
	|-LightLambda.Run10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3A470 Offset: 0xA39670 VA: 0x180A3A470
	|-LightLambda.RunVoid10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA33590 Offset: 0xA32790 VA: 0x180A33590
	|-LightLambda.Run11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3AD80 Offset: 0xA39F80 VA: 0x180A3AD80
	|-LightLambda.RunVoid11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA34020 Offset: 0xA33220 VA: 0x180A34020
	|-LightLambda.Run12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3B770 Offset: 0xA3A970 VA: 0x180A3B770
	|-LightLambda.RunVoid12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA34B80 Offset: 0xA33D80 VA: 0x180A34B80
	|-LightLambda.Run13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3C240 Offset: 0xA3B440 VA: 0x180A3C240
	|-LightLambda.RunVoid13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA357C0 Offset: 0xA349C0 VA: 0x180A357C0
	|-LightLambda.Run14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3CDF0 Offset: 0xA3BFF0 VA: 0x180A3CDF0
	|-LightLambda.RunVoid14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA364D0 Offset: 0xA356D0 VA: 0x180A364D0
	|-LightLambda.Run15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3DA80 Offset: 0xA3CC80 VA: 0x180A3DA80
	|-LightLambda.RunVoid15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRun15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA329D0 Offset: 0xA31BD0 VA: 0x180A329D0
	|-LightLambda.MakeRunVoid15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D4F360 Offset: 0x1D4E560 VA: 0x181D4F360
	internal void .ctor(LightDelegateCreator delegateCreator, IStrongBox[] closure) { }

	// RVA: 0x1D4F3B0 Offset: 0x1D4E5B0 VA: 0x181D4F3B0
	internal string get_DebugView() { }

	// RVA: 0x1D4E170 Offset: 0x1D4D370 VA: 0x181D4E170
	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType) { }

	// RVA: 0x1D4E4A0 Offset: 0x1D4D6A0 VA: 0x181D4E4A0
	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType) { }

	// RVA: 0x1D4D960 Offset: 0x1D4CB60 VA: 0x181D4D960
	private Delegate CreateCustomDelegate(Type delegateType) { }

	// RVA: 0x1D4E300 Offset: 0x1D4D500 VA: 0x181D4E300
	internal Delegate MakeDelegate(Type delegateType) { }

	// RVA: 0x1D4E380 Offset: 0x1D4D580 VA: 0x181D4E380
	private InterpretedFrame MakeFrame() { }

	// RVA: -1 Offset: -1
	internal void RunVoidRef2<T0, T1>(ref T0 arg0, ref T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA41470 Offset: 0xA40670 VA: 0x180A41470
	|-LightLambda.RunVoidRef2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D4F0E0 Offset: 0x1D4E2E0 VA: 0x181D4F0E0
	public object Run(object[] arguments) { }

	// RVA: 0x1D4EF10 Offset: 0x1D4E110 VA: 0x181D4EF10
	public object RunVoid(object[] arguments) { }

	// RVA: 0x1D4F2E0 Offset: 0x1D4E4E0 VA: 0x181D4F2E0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal interface IBoxableInstruction // TypeDefIndex: 15049
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Instruction BoxIfIndexMatches(int index);
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LocalAccessInstruction : Instruction // TypeDefIndex: 15050
{
	// Fields
	internal readonly int _index; // 0x10

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	protected void .ctor(int index) { }

	// RVA: 0x1D5BCB0 Offset: 0x1D5AEB0 VA: 0x181D5BCB0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 15051
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D5BB40 Offset: 0x1D5AD40 VA: 0x181D5BB40 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D5BAA0 Offset: 0x1D5ACA0 VA: 0x181D5BAA0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D5BA30 Offset: 0x1D5AC30 VA: 0x181D5BA30 Slot: 12
	public Instruction BoxIfIndexMatches(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 15052
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D5B830 Offset: 0x1D5AA30 VA: 0x181D5B830 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D5B720 Offset: 0x1D5A920 VA: 0x181D5B720 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalFromClosureInstruction : LocalAccessInstruction // TypeDefIndex: 15053
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D5BA00 Offset: 0x1D5AC00 VA: 0x181D5BA00 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D5B930 Offset: 0x1D5AB30 VA: 0x181D5B930 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 15054
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D5B900 Offset: 0x1D5AB00 VA: 0x181D5B900 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D5B860 Offset: 0x1D5AA60 VA: 0x181D5B860 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 15055
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D50C90 Offset: 0x1D4FE90 VA: 0x181D50C90 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D50C00 Offset: 0x1D4FE00 VA: 0x181D50C00 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D50B90 Offset: 0x1D4FD90 VA: 0x181D50B90 Slot: 12
	public Instruction BoxIfIndexMatches(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 15056
{
	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D68CE0 Offset: 0x1D67EE0 VA: 0x181D68CE0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D68C50 Offset: 0x1D67E50 VA: 0x181D68C50 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D68BE0 Offset: 0x1D67DE0 VA: 0x181D68BE0 Slot: 12
	public Instruction BoxIfIndexMatches(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 15057
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D50B60 Offset: 0x1D4FD60 VA: 0x181D50B60 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D50A80 Offset: 0x1D4FC80 VA: 0x181D50A80 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 15058
{
	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D68BB0 Offset: 0x1D67DB0 VA: 0x181D68BB0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D68AB0 Offset: 0x1D67CB0 VA: 0x181D68AB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction // TypeDefIndex: 15059
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D50D50 Offset: 0x1D4FF50 VA: 0x181D50D50 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D50CC0 Offset: 0x1D4FEC0 VA: 0x181D50CC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ValueTypeCopyInstruction : Instruction // TypeDefIndex: 15060
{
	// Fields
	public static readonly ValueTypeCopyInstruction Instruction; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D6D230 Offset: 0x1D6C430 VA: 0x181D6D230 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D6D180 Offset: 0x1D6C380 VA: 0x181D6D180 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x1D6D1D0 Offset: 0x1D6C3D0 VA: 0x181D6D1D0
	private static void .cctor() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.Reference : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 15061
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x1D673E0 Offset: 0x1D665E0 VA: 0x181D673E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D67370 Offset: 0x1D66570 VA: 0x181D67370 Slot: 12
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x1D67420 Offset: 0x1D66620 VA: 0x181D67420 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.ImmutableValue : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 15062
{
	// Fields
	private readonly object _defaultValue; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1D5AD70 Offset: 0x1D59F70 VA: 0x181D5AD70
	internal void .ctor(int index, object defaultValue) { }

	// RVA: 0x1D5AF60 Offset: 0x1D5A160 VA: 0x181D5AF60 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D5AEE0 Offset: 0x1D5A0E0 VA: 0x181D5AEE0 Slot: 12
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x1D5AFE0 Offset: 0x1D5A1E0 VA: 0x181D5AFE0 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.ImmutableBox : InitializeLocalInstruction // TypeDefIndex: 15063
{
	// Fields
	private readonly object _defaultValue; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1D5AD70 Offset: 0x1D59F70 VA: 0x181D5AD70
	internal void .ctor(int index, object defaultValue) { }

	// RVA: 0x1D5AC90 Offset: 0x1D59E90 VA: 0x181D5AC90 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D5ADB0 Offset: 0x1D59FB0 VA: 0x181D5ADB0 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.ImmutableRefBox : InitializeLocalInstruction // TypeDefIndex: 15064
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x1D5ADE0 Offset: 0x1D59FE0 VA: 0x181D5ADE0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D5AEB0 Offset: 0x1D5A0B0 VA: 0x181D5AEB0 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.ParameterBox : InitializeLocalInstruction // TypeDefIndex: 15065
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(int index) { }

	// RVA: 0x1D66F80 Offset: 0x1D66180 VA: 0x181D66F80 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D67060 Offset: 0x1D66260 VA: 0x181D67060 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.Parameter : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 15066
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D67090 Offset: 0x1D66290 VA: 0x181D67090 Slot: 12
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x1D67100 Offset: 0x1D66300 VA: 0x181D67100 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.MutableValue : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 15067
{
	// Fields
	private readonly Type _type; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1D5AD70 Offset: 0x1D59F70 VA: 0x181D5AD70
	internal void .ctor(int index, Type type) { }

	// RVA: 0x1D61F90 Offset: 0x1D61190 VA: 0x181D61F90 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D61F10 Offset: 0x1D61110 VA: 0x181D61F10 Slot: 12
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x1D62060 Offset: 0x1D61260 VA: 0x181D62060 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.MutableBox : InitializeLocalInstruction // TypeDefIndex: 15068
{
	// Fields
	private readonly Type _type; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1D5AD70 Offset: 0x1D59F70 VA: 0x181D5AD70
	internal void .ctor(int index, Type type) { }

	// RVA: 0x1D61DB0 Offset: 0x1D60FB0 VA: 0x181D61DB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D61EE0 Offset: 0x1D610E0 VA: 0x181D61EE0 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class InitializeLocalInstruction : LocalAccessInstruction // TypeDefIndex: 15069
{
	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class RuntimeVariablesInstruction : Instruction // TypeDefIndex: 15070
{
	// Fields
	private readonly int _count; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(int count) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D68300 Offset: 0x1D67500 VA: 0x181D68300 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D68150 Offset: 0x1D67350 VA: 0x181D68150 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LocalVariable // TypeDefIndex: 15071
{
	// Fields
	private const int IsBoxedFlag = 1;
	private const int InClosureFlag = 2;
	public readonly int Index; // 0x10
	private int _flags; // 0x14

	// Properties
	public bool IsBoxed { get; set; }
	public bool InClosure { get; }

	// Methods

	// RVA: 0x1D5C060 Offset: 0x1D5B260 VA: 0x181D5C060
	public bool get_IsBoxed() { }

	// RVA: 0x1D5C070 Offset: 0x1D5B270 VA: 0x181D5C070
	public void set_IsBoxed(bool value) { }

	// RVA: 0x1D5C050 Offset: 0x1D5B250 VA: 0x181D5C050
	public bool get_InClosure() { }

	// RVA: 0x1D5C010 Offset: 0x1D5B210 VA: 0x181D5C010
	internal void .ctor(int index, bool closure) { }

	// RVA: 0x1D5BF30 Offset: 0x1D5B130 VA: 0x181D5BF30 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
[IsReadOnly]
internal struct LocalDefinition // TypeDefIndex: 15072
{
	// Fields
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ParameterExpression <Parameter>k__BackingField; // 0x8

	// Properties
	public int Index { get; }
	public ParameterExpression Parameter { get; }

	// Methods

	// RVA: 0xBB0D00 Offset: 0xBAFF00 VA: 0x180BB0D00
	internal void .ctor(int localIndex, ParameterExpression parameter) { }

	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ParameterExpression get_Parameter() { }

	// RVA: 0x1D5BE30 Offset: 0x1D5B030 VA: 0x181D5BE30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D5BED0 Offset: 0x1D5B0D0 VA: 0x181D5BED0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private sealed class LocalVariables.VariableScope // TypeDefIndex: 15073
{
	// Fields
	public readonly int Start; // 0x10
	public int Stop; // 0x14
	public readonly LocalVariable Variable; // 0x18
	public readonly LocalVariables.VariableScope Parent; // 0x20
	public List<LocalVariables.VariableScope> ChildScopes; // 0x28

	// Methods

	// RVA: 0x1D6D2A0 Offset: 0x1D6C4A0 VA: 0x181D6D2A0
	public void .ctor(LocalVariable variable, int start, LocalVariables.VariableScope parent) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LocalVariables // TypeDefIndex: 15074
{
	// Fields
	private readonly HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope> _variables; // 0x10
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; // 0x18
	private int _localCount; // 0x20
	private int _maxLocalCount; // 0x24

	// Properties
	public int LocalCount { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x1D5C2F0 Offset: 0x1D5B4F0 VA: 0x181D5C2F0
	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	// RVA: 0x1D5C630 Offset: 0x1D5B830 VA: 0x181D5C630
	public void UndefineLocal(LocalDefinition definition, int end) { }

	// RVA: 0x1D5C1A0 Offset: 0x1D5B3A0 VA: 0x181D5C1A0
	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_LocalCount() { }

	// RVA: 0x1D5C560 Offset: 0x1D5B760 VA: 0x181D5C560
	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x1D5C090 Offset: 0x1D5B290 VA: 0x181D5C090
	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	// RVA: 0x1D5C710 Offset: 0x1D5B910 VA: 0x181D5C710
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloInt16 : ModuloInstruction // TypeDefIndex: 15075
{
	// Methods

	// RVA: 0x1D5F190 Offset: 0x1D5E390 VA: 0x181D5F190 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloInt32 : ModuloInstruction // TypeDefIndex: 15076
{
	// Methods

	// RVA: 0x1D5F310 Offset: 0x1D5E510 VA: 0x181D5F310 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloInt64 : ModuloInstruction // TypeDefIndex: 15077
{
	// Methods

	// RVA: 0x1D5F490 Offset: 0x1D5E690 VA: 0x181D5F490 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloUInt16 : ModuloInstruction // TypeDefIndex: 15078
{
	// Methods

	// RVA: 0x1D5F790 Offset: 0x1D5E990 VA: 0x181D5F790 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloUInt32 : ModuloInstruction // TypeDefIndex: 15079
{
	// Methods

	// RVA: 0x1D5F910 Offset: 0x1D5EB10 VA: 0x181D5F910 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloUInt64 : ModuloInstruction // TypeDefIndex: 15080
{
	// Methods

	// RVA: 0x1D5FA90 Offset: 0x1D5EC90 VA: 0x181D5FA90 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloSingle : ModuloInstruction // TypeDefIndex: 15081
{
	// Methods

	// RVA: 0x1D5F610 Offset: 0x1D5E810 VA: 0x181D5F610 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloDouble : ModuloInstruction // TypeDefIndex: 15082
{
	// Methods

	// RVA: 0x1D5EC30 Offset: 0x1D5DE30 VA: 0x181D5EC30 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ModuloInstruction : Instruction // TypeDefIndex: 15083
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D5F160 Offset: 0x1D5E360 VA: 0x181D5F160 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D5EDB0 Offset: 0x1D5DFB0 VA: 0x181D5EDB0
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class MulInstruction.MulInt16 : MulInstruction // TypeDefIndex: 15084
{
	// Methods

	// RVA: 0x1D60170 Offset: 0x1D5F370 VA: 0x181D60170 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulInt32 : MulInstruction // TypeDefIndex: 15085
{
	// Methods

	// RVA: 0x1D602F0 Offset: 0x1D5F4F0 VA: 0x181D602F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulInt64 : MulInstruction // TypeDefIndex: 15086
{
	// Methods

	// RVA: 0x1D60450 Offset: 0x1D5F650 VA: 0x181D60450 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulUInt16 : MulInstruction // TypeDefIndex: 15087
{
	// Methods

	// RVA: 0x1D61950 Offset: 0x1D60B50 VA: 0x181D61950 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulUInt32 : MulInstruction // TypeDefIndex: 15088
{
	// Methods

	// RVA: 0x1D61AD0 Offset: 0x1D60CD0 VA: 0x181D61AD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulUInt64 : MulInstruction // TypeDefIndex: 15089
{
	// Methods

	// RVA: 0x1D61C40 Offset: 0x1D60E40 VA: 0x181D61C40 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulSingle : MulInstruction // TypeDefIndex: 15090
{
	// Methods

	// RVA: 0x1D617D0 Offset: 0x1D609D0 VA: 0x181D617D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulDouble : MulInstruction // TypeDefIndex: 15091
{
	// Methods

	// RVA: 0x1D5FC10 Offset: 0x1D5EE10 VA: 0x181D5FC10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class MulInstruction : Instruction // TypeDefIndex: 15092
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D60140 Offset: 0x1D5F340 VA: 0x181D60140 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D5FD90 Offset: 0x1D5EF90 VA: 0x181D5FD90
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfInt16 : MulOvfInstruction // TypeDefIndex: 15093
{
	// Methods

	// RVA: 0x1D608F0 Offset: 0x1D5FAF0 VA: 0x181D608F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfInt32 : MulOvfInstruction // TypeDefIndex: 15094
{
	// Methods

	// RVA: 0x1D60BF0 Offset: 0x1D5FDF0 VA: 0x181D60BF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfInt64 : MulOvfInstruction // TypeDefIndex: 15095
{
	// Methods

	// RVA: 0x1D60E60 Offset: 0x1D60060 VA: 0x181D60E60 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfUInt16 : MulOvfInstruction // TypeDefIndex: 15096
{
	// Methods

	// RVA: 0x1D610C0 Offset: 0x1D602C0 VA: 0x181D610C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfUInt32 : MulOvfInstruction // TypeDefIndex: 15097
{
	// Methods

	// RVA: 0x1D613A0 Offset: 0x1D605A0 VA: 0x181D613A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfUInt64 : MulOvfInstruction // TypeDefIndex: 15098
{
	// Methods

	// RVA: 0x1D615B0 Offset: 0x1D607B0 VA: 0x181D615B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class MulOvfInstruction : Instruction // TypeDefIndex: 15099
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D608C0 Offset: 0x1D5FAC0 VA: 0x181D608C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D605C0 Offset: 0x1D5F7C0 VA: 0x181D605C0
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class NegateInstruction.NegateInt16 : NegateInstruction // TypeDefIndex: 15100
{
	// Methods

	// RVA: 0x1D62A30 Offset: 0x1D61C30 VA: 0x181D62A30 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateInstruction.NegateInt32 : NegateInstruction // TypeDefIndex: 15101
{
	// Methods

	// RVA: 0x1D62AD0 Offset: 0x1D61CD0 VA: 0x181D62AD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateInstruction.NegateInt64 : NegateInstruction // TypeDefIndex: 15102
{
	// Methods

	// RVA: 0x1D62B70 Offset: 0x1D61D70 VA: 0x181D62B70 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateInstruction.NegateSingle : NegateInstruction // TypeDefIndex: 15103
{
	// Methods

	// RVA: 0x1D62C10 Offset: 0x1D61E10 VA: 0x181D62C10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateInstruction.NegateDouble : NegateInstruction // TypeDefIndex: 15104
{
	// Methods

	// RVA: 0x1D626B0 Offset: 0x1D618B0 VA: 0x181D626B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NegateInstruction : Instruction // TypeDefIndex: 15105
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_Single; // 0x18
	private static Instruction s_Double; // 0x20

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D62A00 Offset: 0x1D61C00 VA: 0x181D62A00 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D62760 Offset: 0x1D61960 VA: 0x181D62760
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class NegateCheckedInstruction.NegateCheckedInt32 : NegateCheckedInstruction // TypeDefIndex: 15106
{
	// Methods

	// RVA: 0x1D62440 Offset: 0x1D61640 VA: 0x181D62440 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateCheckedInstruction.NegateCheckedInt16 : NegateCheckedInstruction // TypeDefIndex: 15107
{
	// Methods

	// RVA: 0x1D622A0 Offset: 0x1D614A0 VA: 0x181D622A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateCheckedInstruction.NegateCheckedInt64 : NegateCheckedInstruction // TypeDefIndex: 15108
{
	// Methods

	// RVA: 0x1D62580 Offset: 0x1D61780 VA: 0x181D62580 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NegateCheckedInstruction : Instruction // TypeDefIndex: 15109
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D62270 Offset: 0x1D61470 VA: 0x181D62270 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D62090 Offset: 0x1D61290 VA: 0x181D62090
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class NewInstruction : Instruction // TypeDefIndex: 15110
{
	// Fields
	protected readonly ConstructorInfo _constructor; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x16774B0 Offset: 0x16766B0 VA: 0x1816774B0
	public void .ctor(ConstructorInfo constructor, int argumentCount) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D63020 Offset: 0x1D62220 VA: 0x181D63020 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D62DE0 Offset: 0x1D61FE0 VA: 0x181D62DE0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D62CC0 Offset: 0x1D61EC0 VA: 0x181D62CC0
	protected object[] GetArgs(InterpretedFrame frame, int first) { }

	// RVA: 0x1D62EE0 Offset: 0x1D620E0 VA: 0x181D62EE0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class ByRefNewInstruction : NewInstruction // TypeDefIndex: 15111
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1D51710 Offset: 0x1D50910 VA: 0x181D51710
	internal void .ctor(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1D51760 Offset: 0x1D50960 VA: 0x181D51760 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D51530 Offset: 0x1D50730 VA: 0x181D51530 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualBoolean : NotEqualInstruction // TypeDefIndex: 15112
{
	// Methods

	// RVA: 0x1D63190 Offset: 0x1D62390 VA: 0x181D63190 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualSByte : NotEqualInstruction // TypeDefIndex: 15113
{
	// Methods

	// RVA: 0x1D64940 Offset: 0x1D63B40 VA: 0x181D64940 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt16 : NotEqualInstruction // TypeDefIndex: 15114
{
	// Methods

	// RVA: 0x1D643A0 Offset: 0x1D635A0 VA: 0x181D643A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualChar : NotEqualInstruction // TypeDefIndex: 15115
{
	// Methods

	// RVA: 0x1D63510 Offset: 0x1D62710 VA: 0x181D63510 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt32 : NotEqualInstruction // TypeDefIndex: 15116
{
	// Methods

	// RVA: 0x1D64560 Offset: 0x1D63760 VA: 0x181D64560 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt64 : NotEqualInstruction // TypeDefIndex: 15117
{
	// Methods

	// RVA: 0x1D64720 Offset: 0x1D63920 VA: 0x181D64720 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualByte : NotEqualInstruction // TypeDefIndex: 15118
{
	// Methods

	// RVA: 0x1D63350 Offset: 0x1D62550 VA: 0x181D63350 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt16 : NotEqualInstruction // TypeDefIndex: 15119
{
	// Methods

	// RVA: 0x1D64CF0 Offset: 0x1D63EF0 VA: 0x181D64CF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt32 : NotEqualInstruction // TypeDefIndex: 15120
{
	// Methods

	// RVA: 0x1D64EB0 Offset: 0x1D640B0 VA: 0x181D64EB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt64 : NotEqualInstruction // TypeDefIndex: 15121
{
	// Methods

	// RVA: 0x1D65070 Offset: 0x1D64270 VA: 0x181D65070 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualSingle : NotEqualInstruction // TypeDefIndex: 15122
{
	// Methods

	// RVA: 0x1D64B20 Offset: 0x1D63D20 VA: 0x181D64B20 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualDouble : NotEqualInstruction // TypeDefIndex: 15123
{
	// Methods

	// RVA: 0x1D636F0 Offset: 0x1D628F0 VA: 0x181D636F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualReference : NotEqualInstruction // TypeDefIndex: 15124
{
	// Methods

	// RVA: 0x1D64800 Offset: 0x1D63A00 VA: 0x181D64800 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualSByteLiftedToNull : NotEqualInstruction // TypeDefIndex: 15125
{
	// Methods

	// RVA: 0x1D64860 Offset: 0x1D63A60 VA: 0x181D64860 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt16LiftedToNull : NotEqualInstruction // TypeDefIndex: 15126
{
	// Methods

	// RVA: 0x1D642C0 Offset: 0x1D634C0 VA: 0x181D642C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualCharLiftedToNull : NotEqualInstruction // TypeDefIndex: 15127
{
	// Methods

	// RVA: 0x1D63430 Offset: 0x1D62630 VA: 0x181D63430 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt32LiftedToNull : NotEqualInstruction // TypeDefIndex: 15128
{
	// Methods

	// RVA: 0x1D64480 Offset: 0x1D63680 VA: 0x181D64480 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt64LiftedToNull : NotEqualInstruction // TypeDefIndex: 15129
{
	// Methods

	// RVA: 0x1D64640 Offset: 0x1D63840 VA: 0x181D64640 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualByteLiftedToNull : NotEqualInstruction // TypeDefIndex: 15130
{
	// Methods

	// RVA: 0x1D63270 Offset: 0x1D62470 VA: 0x181D63270 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt16LiftedToNull : NotEqualInstruction // TypeDefIndex: 15131
{
	// Methods

	// RVA: 0x1D64C10 Offset: 0x1D63E10 VA: 0x181D64C10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt32LiftedToNull : NotEqualInstruction // TypeDefIndex: 15132
{
	// Methods

	// RVA: 0x1D64DD0 Offset: 0x1D63FD0 VA: 0x181D64DD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt64LiftedToNull : NotEqualInstruction // TypeDefIndex: 15133
{
	// Methods

	// RVA: 0x1D64F90 Offset: 0x1D64190 VA: 0x181D64F90 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualSingleLiftedToNull : NotEqualInstruction // TypeDefIndex: 15134
{
	// Methods

	// RVA: 0x1D64A20 Offset: 0x1D63C20 VA: 0x181D64A20 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualDoubleLiftedToNull : NotEqualInstruction // TypeDefIndex: 15135
{
	// Methods

	// RVA: 0x1D635F0 Offset: 0x1D627F0 VA: 0x181D635F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NotEqualInstruction : Instruction // TypeDefIndex: 15136
{
	// Fields
	private static Instruction s_reference; // 0x0
	private static Instruction s_Boolean; // 0x8
	private static Instruction s_SByte; // 0x10
	private static Instruction s_Int16; // 0x18
	private static Instruction s_Char; // 0x20
	private static Instruction s_Int32; // 0x28
	private static Instruction s_Int64; // 0x30
	private static Instruction s_Byte; // 0x38
	private static Instruction s_UInt16; // 0x40
	private static Instruction s_UInt32; // 0x48
	private static Instruction s_UInt64; // 0x50
	private static Instruction s_Single; // 0x58
	private static Instruction s_Double; // 0x60
	private static Instruction s_SByteLiftedToNull; // 0x68
	private static Instruction s_Int16LiftedToNull; // 0x70
	private static Instruction s_CharLiftedToNull; // 0x78
	private static Instruction s_Int32LiftedToNull; // 0x80
	private static Instruction s_Int64LiftedToNull; // 0x88
	private static Instruction s_ByteLiftedToNull; // 0x90
	private static Instruction s_UInt16LiftedToNull; // 0x98
	private static Instruction s_UInt32LiftedToNull; // 0xA0
	private static Instruction s_UInt64LiftedToNull; // 0xA8
	private static Instruction s_SingleLiftedToNull; // 0xB0
	private static Instruction s_DoubleLiftedToNull; // 0xB8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D64290 Offset: 0x1D63490 VA: 0x181D64290 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D637E0 Offset: 0x1D629E0 VA: 0x181D637E0
	public static Instruction Create(Type type, bool liftedToNull) { }
}

// Namespace: 
private sealed class NotInstruction.NotBoolean : NotInstruction // TypeDefIndex: 15137
{
	// Methods

	// RVA: 0x1D63050 Offset: 0x1D62250 VA: 0x181D63050 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotInt64 : NotInstruction // TypeDefIndex: 15138
{
	// Methods

	// RVA: 0x1D656E0 Offset: 0x1D648E0 VA: 0x181D656E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotInt32 : NotInstruction // TypeDefIndex: 15139
{
	// Methods

	// RVA: 0x1D65640 Offset: 0x1D64840 VA: 0x181D65640 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotInt16 : NotInstruction // TypeDefIndex: 15140
{
	// Methods

	// RVA: 0x1D655A0 Offset: 0x1D647A0 VA: 0x181D655A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotUInt64 : NotInstruction // TypeDefIndex: 15141
{
	// Methods

	// RVA: 0x1D65960 Offset: 0x1D64B60 VA: 0x181D65960 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotUInt32 : NotInstruction // TypeDefIndex: 15142
{
	// Methods

	// RVA: 0x1D658C0 Offset: 0x1D64AC0 VA: 0x181D658C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotUInt16 : NotInstruction // TypeDefIndex: 15143
{
	// Methods

	// RVA: 0x1D65820 Offset: 0x1D64A20 VA: 0x181D65820 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotByte : NotInstruction // TypeDefIndex: 15144
{
	// Methods

	// RVA: 0x1D630F0 Offset: 0x1D622F0 VA: 0x181D630F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotSByte : NotInstruction // TypeDefIndex: 15145
{
	// Methods

	// RVA: 0x1D65780 Offset: 0x1D64980 VA: 0x181D65780 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NotInstruction : Instruction // TypeDefIndex: 15146
{
	// Fields
	public static Instruction s_Boolean; // 0x0
	public static Instruction s_Int64; // 0x8
	public static Instruction s_Int32; // 0x10
	public static Instruction s_Int16; // 0x18
	public static Instruction s_UInt64; // 0x20
	public static Instruction s_UInt32; // 0x28
	public static Instruction s_UInt16; // 0x30
	public static Instruction s_Byte; // 0x38
	public static Instruction s_SByte; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D65570 Offset: 0x1D64770 VA: 0x181D65570 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D65150 Offset: 0x1D64350 VA: 0x181D65150
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NullCheckInstruction : Instruction // TypeDefIndex: 15147
{
	// Fields
	public static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D65AD0 Offset: 0x1D64CD0 VA: 0x181D65AD0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D65A00 Offset: 0x1D64C00 VA: 0x181D65A00 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D65A70 Offset: 0x1D64C70 VA: 0x181D65A70
	private static void .cctor() { }
}

// Namespace: 
internal sealed class NumericConvertInstruction.Unchecked : NumericConvertInstruction // TypeDefIndex: 15148
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1D6D150 Offset: 0x1D6C350 VA: 0x181D6D150 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D53FF0 Offset: 0x1D531F0 VA: 0x181D53FF0
	public void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1D6CD30 Offset: 0x1D6BF30 VA: 0x181D6CD30 Slot: 12
	protected override object Convert(object obj) { }

	// RVA: 0x1D6C5B0 Offset: 0x1D6B7B0 VA: 0x181D6C5B0
	private object ConvertInt32(int obj) { }

	// RVA: 0x1D6C830 Offset: 0x1D6BA30 VA: 0x181D6C830
	private object ConvertInt64(long obj) { }

	// RVA: 0x1D6CA90 Offset: 0x1D6BC90 VA: 0x181D6CA90
	private object ConvertUInt64(ulong obj) { }

	// RVA: 0x1D6C2C0 Offset: 0x1D6B4C0 VA: 0x181D6C2C0
	private object ConvertDouble(double obj) { }
}

// Namespace: 
internal sealed class NumericConvertInstruction.Checked : NumericConvertInstruction // TypeDefIndex: 15149
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1D54040 Offset: 0x1D53240 VA: 0x181D54040 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D53FF0 Offset: 0x1D531F0 VA: 0x181D53FF0
	public void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1D53BD0 Offset: 0x1D52DD0 VA: 0x181D53BD0 Slot: 12
	protected override object Convert(object obj) { }

	// RVA: 0x1D53140 Offset: 0x1D52340 VA: 0x181D53140
	private object ConvertInt32(int obj) { }

	// RVA: 0x1D53480 Offset: 0x1D52680 VA: 0x181D53480
	private object ConvertInt64(long obj) { }

	// RVA: 0x1D537F0 Offset: 0x1D529F0 VA: 0x181D537F0
	private object ConvertUInt64(ulong obj) { }

	// RVA: 0x1D52D30 Offset: 0x1D51F30 VA: 0x181D52D30
	private object ConvertDouble(double obj) { }
}

// Namespace: 
internal sealed class NumericConvertInstruction.ToUnderlying : NumericConvertInstruction // TypeDefIndex: 15150
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1D6B840 Offset: 0x1D6AA40 VA: 0x181D6B840 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D6B800 Offset: 0x1D6AA00 VA: 0x181D6B800
	public void .ctor(TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1D6B380 Offset: 0x1D6A580 VA: 0x181D6B380 Slot: 12
	protected override object Convert(object obj) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NumericConvertInstruction : Instruction // TypeDefIndex: 15151
{
	// Fields
	internal readonly TypeCode _from; // 0x10
	internal readonly TypeCode _to; // 0x14
	private readonly bool _isLiftedToNull; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1D53FF0 Offset: 0x1D531F0 VA: 0x181D53FF0
	protected void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1D65FA0 Offset: 0x1D651A0 VA: 0x181D65FA0 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract object Convert(object obj);

	// RVA: 0x1D66200 Offset: 0x1D65400 VA: 0x181D66200 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D660A0 Offset: 0x1D652A0 VA: 0x181D660A0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private sealed class OrInstruction.OrSByte : OrInstruction // TypeDefIndex: 15152
{
	// Methods

	// RVA: 0x1D66BC0 Offset: 0x1D65DC0 VA: 0x181D66BC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrInt16 : OrInstruction // TypeDefIndex: 15153
{
	// Methods

	// RVA: 0x1D66900 Offset: 0x1D65B00 VA: 0x181D66900 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrInt32 : OrInstruction // TypeDefIndex: 15154
{
	// Methods

	// RVA: 0x1D669F0 Offset: 0x1D65BF0 VA: 0x181D669F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrInt64 : OrInstruction // TypeDefIndex: 15155
{
	// Methods

	// RVA: 0x1D66AD0 Offset: 0x1D65CD0 VA: 0x181D66AD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrByte : OrInstruction // TypeDefIndex: 15156
{
	// Methods

	// RVA: 0x1D663C0 Offset: 0x1D655C0 VA: 0x181D663C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrUInt16 : OrInstruction // TypeDefIndex: 15157
{
	// Methods

	// RVA: 0x1D66CB0 Offset: 0x1D65EB0 VA: 0x181D66CB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrUInt32 : OrInstruction // TypeDefIndex: 15158
{
	// Methods

	// RVA: 0x1D66DA0 Offset: 0x1D65FA0 VA: 0x181D66DA0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrUInt64 : OrInstruction // TypeDefIndex: 15159
{
	// Methods

	// RVA: 0x1D66E90 Offset: 0x1D66090 VA: 0x181D66E90 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrBoolean : OrInstruction // TypeDefIndex: 15160
{
	// Methods

	// RVA: 0x1D66230 Offset: 0x1D65430 VA: 0x181D66230 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class OrInstruction : Instruction // TypeDefIndex: 15161
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D668D0 Offset: 0x1D65AD0 VA: 0x181D668D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D664B0 Offset: 0x1D656B0 VA: 0x181D664B0
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftSByte : RightShiftInstruction // TypeDefIndex: 15162
{
	// Methods

	// RVA: 0x1D67BF0 Offset: 0x1D66DF0 VA: 0x181D67BF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftInt16 : RightShiftInstruction // TypeDefIndex: 15163
{
	// Methods

	// RVA: 0x1D67920 Offset: 0x1D66B20 VA: 0x181D67920 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftInt32 : RightShiftInstruction // TypeDefIndex: 15164
{
	// Methods

	// RVA: 0x1D67A10 Offset: 0x1D66C10 VA: 0x181D67A10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftInt64 : RightShiftInstruction // TypeDefIndex: 15165
{
	// Methods

	// RVA: 0x1D67AF0 Offset: 0x1D66CF0 VA: 0x181D67AF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftByte : RightShiftInstruction // TypeDefIndex: 15166
{
	// Methods

	// RVA: 0x1D67450 Offset: 0x1D66650 VA: 0x181D67450 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftUInt16 : RightShiftInstruction // TypeDefIndex: 15167
{
	// Methods

	// RVA: 0x1D67CE0 Offset: 0x1D66EE0 VA: 0x181D67CE0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftUInt32 : RightShiftInstruction // TypeDefIndex: 15168
{
	// Methods

	// RVA: 0x1D67DD0 Offset: 0x1D66FD0 VA: 0x181D67DD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftUInt64 : RightShiftInstruction // TypeDefIndex: 15169
{
	// Methods

	// RVA: 0x1D67ED0 Offset: 0x1D670D0 VA: 0x181D67ED0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class RightShiftInstruction : Instruction // TypeDefIndex: 15170
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D678F0 Offset: 0x1D66AF0 VA: 0x181D678F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D67540 Offset: 0x1D66740 VA: 0x181D67540
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class RuntimeVariables : IRuntimeVariables // TypeDefIndex: 15171
{
	// Fields
	private readonly IStrongBox[] _boxes; // 0x10

	// Properties
	private int System.Runtime.CompilerServices.IRuntimeVariables.Count { get; }
	private object System.Runtime.CompilerServices.IRuntimeVariables.Item { get; set; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	private void .ctor(IStrongBox[] boxes) { }

	// RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20 Slot: 4
	private int System.Runtime.CompilerServices.IRuntimeVariables.get_Count() { }

	// RVA: 0x1D68400 Offset: 0x1D67600 VA: 0x181D68400 Slot: 5
	private object System.Runtime.CompilerServices.IRuntimeVariables.get_Item(int index) { }

	// RVA: 0x1D68470 Offset: 0x1D67670 VA: 0x181D68470 Slot: 6
	private void System.Runtime.CompilerServices.IRuntimeVariables.set_Item(int index, object value) { }

	// RVA: 0x1D68330 Offset: 0x1D67530 VA: 0x181D68330
	internal static IRuntimeVariables Create(IStrongBox[] boxes) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadObjectInstruction : Instruction // TypeDefIndex: 15172
{
	// Fields
	private readonly object _value; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	internal void .ctor(object value) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D5BC80 Offset: 0x1D5AE80 VA: 0x181D5BC80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D5BB70 Offset: 0x1D5AD70 VA: 0x181D5BB70 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D5BBF0 Offset: 0x1D5ADF0 VA: 0x181D5BBF0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadCachedObjectInstruction : Instruction // TypeDefIndex: 15173
{
	// Fields
	private readonly uint _index; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	internal void .ctor(uint index) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D5B6F0 Offset: 0x1D5A8F0 VA: 0x181D5B6F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D5B510 Offset: 0x1D5A710 VA: 0x181D5B510 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D5B5B0 Offset: 0x1D5A7B0 VA: 0x181D5B5B0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1D5B690 Offset: 0x1D5A890 VA: 0x181D5B690 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class PopInstruction : Instruction // TypeDefIndex: 15174
{
	// Fields
	internal static readonly PopInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D671C0 Offset: 0x1D663C0 VA: 0x181D671C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D67130 Offset: 0x1D66330 VA: 0x181D67130 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D67160 Offset: 0x1D66360 VA: 0x181D67160
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DupInstruction : Instruction // TypeDefIndex: 15175
{
	// Fields
	internal static readonly DupInstruction Instance; // 0x0

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D57770 Offset: 0x1D56970 VA: 0x181D57770 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D576E0 Offset: 0x1D568E0 VA: 0x181D576E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D57710 Offset: 0x1D56910 VA: 0x181D57710
	private static void .cctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubInt16 : SubInstruction // TypeDefIndex: 15176
{
	// Methods

	// RVA: 0x1D69270 Offset: 0x1D68470 VA: 0x181D69270 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubInt32 : SubInstruction // TypeDefIndex: 15177
{
	// Methods

	// RVA: 0x1D693F0 Offset: 0x1D685F0 VA: 0x181D693F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubInt64 : SubInstruction // TypeDefIndex: 15178
{
	// Methods

	// RVA: 0x1D69550 Offset: 0x1D68750 VA: 0x181D69550 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubUInt16 : SubInstruction // TypeDefIndex: 15179
{
	// Methods

	// RVA: 0x1D6AA20 Offset: 0x1D69C20 VA: 0x181D6AA20 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubUInt32 : SubInstruction // TypeDefIndex: 15180
{
	// Methods

	// RVA: 0x1D6ABA0 Offset: 0x1D69DA0 VA: 0x181D6ABA0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubUInt64 : SubInstruction // TypeDefIndex: 15181
{
	// Methods

	// RVA: 0x1D6AD10 Offset: 0x1D69F10 VA: 0x181D6AD10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubSingle : SubInstruction // TypeDefIndex: 15182
{
	// Methods

	// RVA: 0x1D6A8A0 Offset: 0x1D69AA0 VA: 0x181D6A8A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubDouble : SubInstruction // TypeDefIndex: 15183
{
	// Methods

	// RVA: 0x1D68D10 Offset: 0x1D67F10 VA: 0x181D68D10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class SubInstruction : Instruction // TypeDefIndex: 15184
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D69240 Offset: 0x1D68440 VA: 0x181D69240 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D68E90 Offset: 0x1D68090 VA: 0x181D68E90
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfInt16 : SubOvfInstruction // TypeDefIndex: 15185
{
	// Methods

	// RVA: 0x1D69A00 Offset: 0x1D68C00 VA: 0x181D69A00 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfInt32 : SubOvfInstruction // TypeDefIndex: 15186
{
	// Methods

	// RVA: 0x1D69CF0 Offset: 0x1D68EF0 VA: 0x181D69CF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfInt64 : SubOvfInstruction // TypeDefIndex: 15187
{
	// Methods

	// RVA: 0x1D69F50 Offset: 0x1D69150 VA: 0x181D69F50 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfUInt16 : SubOvfInstruction // TypeDefIndex: 15188
{
	// Methods

	// RVA: 0x1D6A190 Offset: 0x1D69390 VA: 0x181D6A190 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfUInt32 : SubOvfInstruction // TypeDefIndex: 15189
{
	// Methods

	// RVA: 0x1D6A480 Offset: 0x1D69680 VA: 0x181D6A480 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfUInt64 : SubOvfInstruction // TypeDefIndex: 15190
{
	// Methods

	// RVA: 0x1D6A690 Offset: 0x1D69890 VA: 0x181D6A690 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class SubOvfInstruction : Instruction // TypeDefIndex: 15191
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D699D0 Offset: 0x1D68BD0 VA: 0x181D699D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D696D0 Offset: 0x1D688D0 VA: 0x181D696D0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CreateDelegateInstruction : Instruction // TypeDefIndex: 15192
{
	// Fields
	private readonly LightDelegateCreator _creator; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	internal void .ctor(LightDelegateCreator delegateCreator) { }

	// RVA: 0x1D542E0 Offset: 0x1D534E0 VA: 0x181D542E0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D54310 Offset: 0x1D53510 VA: 0x181D54310 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D54120 Offset: 0x1D53320 VA: 0x181D54120 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeIsInstruction : Instruction // TypeDefIndex: 15193
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	internal void .ctor(Type type) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D6BE80 Offset: 0x1D6B080 VA: 0x181D6BE80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D6BDB0 Offset: 0x1D6AFB0 VA: 0x181D6BDB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D6BE20 Offset: 0x1D6B020 VA: 0x181D6BE20 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeAsInstruction : Instruction // TypeDefIndex: 15194
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	internal void .ctor(Type type) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D6B950 Offset: 0x1D6AB50 VA: 0x181D6B950 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D6B870 Offset: 0x1D6AA70 VA: 0x181D6B870 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D6B8F0 Offset: 0x1D6AAF0 VA: 0x181D6B8F0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeEqualsInstruction : Instruction // TypeDefIndex: 15195
{
	// Fields
	public static readonly TypeEqualsInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D6BA40 Offset: 0x1D6AC40 VA: 0x181D6BA40 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D6B980 Offset: 0x1D6AB80 VA: 0x181D6B980 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1D6B9E0 Offset: 0x1D6ABE0 VA: 0x181D6B9E0
	private static void .cctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.HasValue : NullableMethodCallInstruction // TypeDefIndex: 15196
{
	// Methods

	// RVA: 0x1D5A940 Offset: 0x1D59B40 VA: 0x181D5A940 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.GetValue : NullableMethodCallInstruction // TypeDefIndex: 15197
{
	// Methods

	// RVA: 0x1D5A8D0 Offset: 0x1D59AD0 VA: 0x181D5A8D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.GetValueOrDefault : NullableMethodCallInstruction // TypeDefIndex: 15198
{
	// Fields
	private readonly Type _defaultValueType; // 0x10

	// Methods

	// RVA: 0x1D5A880 Offset: 0x1D59A80 VA: 0x181D5A880
	public void .ctor(MethodInfo mi) { }

	// RVA: 0x1D5A820 Offset: 0x1D59A20 VA: 0x181D5A820 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.GetValueOrDefault1 : NullableMethodCallInstruction // TypeDefIndex: 15199
{
	// Properties
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D5A7C0 Offset: 0x1D599C0 VA: 0x181D5A7C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.EqualsClass : NullableMethodCallInstruction // TypeDefIndex: 15200
{
	// Properties
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1D59230 Offset: 0x1D58430 VA: 0x181D59230 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.ToStringClass : NullableMethodCallInstruction // TypeDefIndex: 15201
{
	// Methods

	// RVA: 0x1D6B300 Offset: 0x1D6A500 VA: 0x181D6B300 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.GetHashCodeClass : NullableMethodCallInstruction // TypeDefIndex: 15202
{
	// Methods

	// RVA: 0x1D5A760 Offset: 0x1D59960 VA: 0x181D5A760 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NullableMethodCallInstruction : Instruction // TypeDefIndex: 15203
{
	// Fields
	private static NullableMethodCallInstruction s_hasValue; // 0x0
	private static NullableMethodCallInstruction s_value; // 0x8
	private static NullableMethodCallInstruction s_equals; // 0x10
	private static NullableMethodCallInstruction s_getHashCode; // 0x18
	private static NullableMethodCallInstruction s_getValueOrDefault1; // 0x20
	private static NullableMethodCallInstruction s_toString; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D65F70 Offset: 0x1D65170 VA: 0x181D65F70 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1D65B80 Offset: 0x1D64D80 VA: 0x181D65B80
	public static Instruction Create(string method, int argCount, MethodInfo mi) { }

	// RVA: 0x1D65B00 Offset: 0x1D64D00 VA: 0x181D65B00
	public static Instruction CreateGetValue() { }
}

// Namespace: 
private sealed class CastInstruction.CastInstructionT<T> : CastInstruction // TypeDefIndex: 15204
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public override int Run(InterpretedFrame frame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD260 Offset: 0xEFC460 VA: 0x180EFD260
	|-CastInstruction.CastInstructionT<bool>.Run
	|-CastInstruction.CastInstructionT<byte>.Run
	|-CastInstruction.CastInstructionT<sbyte>.Run
	|
	|-RVA: 0xEFD100 Offset: 0xEFC300 VA: 0x180EFD100
	|-CastInstruction.CastInstructionT<char>.Run
	|-CastInstruction.CastInstructionT<short>.Run
	|-CastInstruction.CastInstructionT<ushort>.Run
	|
	|-RVA: 0xEFCD40 Offset: 0xEFBF40 VA: 0x180EFCD40
	|-CastInstruction.CastInstructionT<DateTime>.Run
	|-CastInstruction.CastInstructionT<long>.Run
	|-CastInstruction.CastInstructionT<ulong>.Run
	|
	|-RVA: 0xEFCF80 Offset: 0xEFC180 VA: 0x180EFCF80
	|-CastInstruction.CastInstructionT<Decimal>.Run
	|
	|-RVA: 0xEFD040 Offset: 0xEFC240 VA: 0x180EFD040
	|-CastInstruction.CastInstructionT<double>.Run
	|
	|-RVA: 0xEFCEC0 Offset: 0xEFC0C0 VA: 0x180EFCEC0
	|-CastInstruction.CastInstructionT<int>.Run
	|-CastInstruction.CastInstructionT<uint>.Run
	|
	|-RVA: 0xEFD1C0 Offset: 0xEFC3C0 VA: 0x180EFD1C0
	|-CastInstruction.CastInstructionT<object>.Run
	|
	|-RVA: 0xEFCE00 Offset: 0xEFC000 VA: 0x180EFCE00
	|-CastInstruction.CastInstructionT<float>.Run
	|
	|-RVA: 0xEFD320 Offset: 0xEFC520 VA: 0x180EFD320
	|-CastInstruction.CastInstructionT<__Il2CppFullySharedGenericType>.Run
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	|-CastInstruction.CastInstructionT<bool>..ctor
	|-CastInstruction.CastInstructionT<byte>..ctor
	|-CastInstruction.CastInstructionT<char>..ctor
	|-CastInstruction.CastInstructionT<DateTime>..ctor
	|-CastInstruction.CastInstructionT<Decimal>..ctor
	|-CastInstruction.CastInstructionT<double>..ctor
	|-CastInstruction.CastInstructionT<short>..ctor
	|-CastInstruction.CastInstructionT<int>..ctor
	|-CastInstruction.CastInstructionT<long>..ctor
	|-CastInstruction.CastInstructionT<object>..ctor
	|-CastInstruction.CastInstructionT<sbyte>..ctor
	|-CastInstruction.CastInstructionT<float>..ctor
	|-CastInstruction.CastInstructionT<ushort>..ctor
	|-CastInstruction.CastInstructionT<uint>..ctor
	|-CastInstruction.CastInstructionT<ulong>..ctor
	|-CastInstruction.CastInstructionT<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private sealed class CastInstruction.CastInstructionNoT.Ref : CastInstruction.CastInstructionNoT // TypeDefIndex: 15205
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type t) { }

	// RVA: 0x1D67340 Offset: 0x1D66540 VA: 0x181D67340 Slot: 12
	protected override void ConvertNull(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class CastInstruction.CastInstructionNoT.Value : CastInstruction.CastInstructionNoT // TypeDefIndex: 15206
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type t) { }

	// RVA: 0x1D6D260 Offset: 0x1D6C460 VA: 0x181D6D260 Slot: 12
	protected override void ConvertNull(InterpretedFrame frame) { }
}

// Namespace: 
private abstract class CastInstruction.CastInstructionNoT : CastInstruction // TypeDefIndex: 15207
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	protected void .ctor(Type t) { }

	// RVA: 0x1D51D40 Offset: 0x1D50F40 VA: 0x181D51D40
	public static CastInstruction Create(Type t) { }

	// RVA: 0x1D51DF0 Offset: 0x1D50FF0 VA: 0x181D51DF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void ConvertNull(InterpretedFrame frame);
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class CastInstruction : Instruction // TypeDefIndex: 15208
{
	// Fields
	private static CastInstruction s_Boolean; // 0x0
	private static CastInstruction s_Byte; // 0x8
	private static CastInstruction s_Char; // 0x10
	private static CastInstruction s_DateTime; // 0x18
	private static CastInstruction s_Decimal; // 0x20
	private static CastInstruction s_Double; // 0x28
	private static CastInstruction s_Int16; // 0x30
	private static CastInstruction s_Int32; // 0x38
	private static CastInstruction s_Int64; // 0x40
	private static CastInstruction s_SByte; // 0x48
	private static CastInstruction s_Single; // 0x50
	private static CastInstruction s_String; // 0x58
	private static CastInstruction s_UInt16; // 0x60
	private static CastInstruction s_UInt32; // 0x68
	private static CastInstruction s_UInt64; // 0x70

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D52740 Offset: 0x1D51940 VA: 0x181D52740 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D51F90 Offset: 0x1D51190 VA: 0x181D51F90
	public static Instruction Create(Type t) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CastToEnumInstruction : CastInstruction // TypeDefIndex: 15209
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type t) { }

	// RVA: 0x1D52C90 Offset: 0x1D51E90 VA: 0x181D52C90 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CastReferenceToEnumInstruction : CastInstruction // TypeDefIndex: 15210
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type t) { }

	// RVA: 0x1D52770 Offset: 0x1D51970 VA: 0x181D52770 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class QuoteInstruction.ExpressionQuoter : ExpressionVisitor // TypeDefIndex: 15211
{
	// Fields
	private readonly Dictionary<ParameterExpression, LocalVariable> _variables; // 0x10
	private readonly InterpretedFrame _frame; // 0x18
	private readonly Stack<HashSet<ParameterExpression>> _shadowedVars; // 0x20

	// Methods

	// RVA: 0x1D5A690 Offset: 0x1D59890 VA: 0x181D5A690
	internal void .ctor(Dictionary<ParameterExpression, LocalVariable> hoistedVariables, InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 16
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACC700 Offset: 0xACB900 VA: 0x180ACC700
	|-QuoteInstruction.ExpressionQuoter.VisitLambda<object>
	|
	|-RVA: 0xACC530 Offset: 0xACB730 VA: 0x180ACC530
	|-QuoteInstruction.ExpressionQuoter.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D59EA0 Offset: 0x1D590A0 VA: 0x181D59EA0 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1D5A020 Offset: 0x1D59220 VA: 0x181D5A020 Slot: 27
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x1D5A290 Offset: 0x1D59490 VA: 0x181D5A290 Slot: 24
	protected internal override Expression VisitRuntimeVariables(RuntimeVariablesExpression node) { }

	// RVA: 0x1D59E20 Offset: 0x1D59020 VA: 0x181D59E20
	private static IRuntimeVariables MergeRuntimeVariables(IRuntimeVariables first, IRuntimeVariables second, int[] indexes) { }

	// RVA: 0x1D5A1C0 Offset: 0x1D593C0 VA: 0x181D5A1C0 Slot: 23
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x1D59CF0 Offset: 0x1D58EF0 VA: 0x181D59CF0
	private IStrongBox GetBox(ParameterExpression variable) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class QuoteInstruction : Instruction // TypeDefIndex: 15212
{
	// Fields
	private readonly Expression _operand; // 0x10
	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; // 0x18

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	public void .ctor(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1D67310 Offset: 0x1D66510 VA: 0x181D67310 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1D671F0 Offset: 0x1D663F0 VA: 0x181D671F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DelegateHelpers.<>c // TypeDefIndex: 15213
{
	// Fields
	public static readonly DelegateHelpers.<>c <>9; // 0x0
	public static Func<Type, bool> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x1D6C260 Offset: 0x1D6B460 VA: 0x181D6C260
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D6C0D0 Offset: 0x1D6B2D0 VA: 0x181D6C0D0
	internal bool <MakeDelegate>b__1_0(Type t) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class DelegateHelpers // TypeDefIndex: 15214
{
	// Fields
	private const int MaximumArity = 17;

	// Methods

	// RVA: 0x1D56320 Offset: 0x1D55520 VA: 0x181D56320
	internal static Type MakeDelegate(Type[] types) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class ScriptingRuntimeHelpers // TypeDefIndex: 15215
{
	// Methods

	// RVA: 0x1D68940 Offset: 0x1D67B40 VA: 0x181D68940
	public static object Int32ToObject(int i) { }

	// RVA: 0x1D68570 Offset: 0x1D67770 VA: 0x181D68570
	internal static object GetPrimitiveDefaultValue(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class ExceptionHelpers // TypeDefIndex: 15216
{
	// Methods

	// RVA: 0x1D59310 Offset: 0x1D58510 VA: 0x181D59310
	public static void UnwrapAndRethrow(TargetInvocationException exception) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HybridReferenceDictionary.<GetEnumeratorWorker>d__7<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 15217
{
	// Fields
	private int <>1__state; // 0x0
	private KeyValuePair<TKey, TValue> <>2__current; // 0x0
	public HybridReferenceDictionary<TKey, TValue> <>4__this; // 0x0
	private int <i>5__2; // 0x0

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
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>..ctor
	|
	|-RVA: 0xB1E9D0 Offset: 0xB1DBD0 VA: 0x180B1E9D0
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>.System.IDisposable.Dispose
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB246F0 Offset: 0xB238F0 VA: 0x180B246F0
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>.MoveNext
	|
	|-RVA: 0xB24790 Offset: 0xB23990 VA: 0x180B24790
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0xB23C90 Offset: 0xB22E90 VA: 0x180B23C90
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>.System.Collections.IEnumerator.Reset
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB24AF0 Offset: 0xB23CF0 VA: 0x180B24AF0
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB23D80 Offset: 0xB22F80 VA: 0x180B23D80
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Linq.Expressions.Interpreter
[DefaultMember("Item")]
internal class HybridReferenceDictionary<TKey, TValue> // TypeDefIndex: 15218
{
	// Fields
	private KeyValuePair<TKey, TValue>[] _keysAndValues; // 0x0
	private Dictionary<TKey, TValue> _dict; // 0x0
	private const int ArraySize = 10;

	// Properties
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12609E0 Offset: 0x125FBE0 VA: 0x1812609E0
	|-HybridReferenceDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x1260A70 Offset: 0x125FC70 VA: 0x181260A70
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260960 Offset: 0x125FB60 VA: 0x181260960
	|-HybridReferenceDictionary<object, object>.Remove
	|
	|-RVA: 0x1260800 Offset: 0x125FA00 VA: 0x181260800
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260430 Offset: 0x125F630 VA: 0x181260430
	|-HybridReferenceDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x1260320 Offset: 0x125F520 VA: 0x181260320
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12606E0 Offset: 0x125F8E0 VA: 0x1812606E0
	|-HybridReferenceDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x1260600 Offset: 0x125F800 VA: 0x181260600
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[IteratorStateMachine(typeof(HybridReferenceDictionary.<GetEnumeratorWorker>d__7<TKey, TValue>))]
	// RVA: -1 Offset: -1
	private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260570 Offset: 0x125F770 VA: 0x181260570
	|-HybridReferenceDictionary<object, object>.GetEnumeratorWorker
	|
	|-RVA: 0x12604B0 Offset: 0x125F6B0 VA: 0x1812604B0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.GetEnumeratorWorker
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260DE0 Offset: 0x125FFE0 VA: 0x181260DE0
	|-HybridReferenceDictionary<object, object>.get_Item
	|
	|-RVA: 0x1260C80 Offset: 0x125FE80 VA: 0x181260C80
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260F10 Offset: 0x1260110 VA: 0x181260F10
	|-HybridReferenceDictionary<object, object>.set_Item
	|
	|-RVA: 0x12611D0 Offset: 0x12603D0 VA: 0x1812611D0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-HybridReferenceDictionary<object, object>..ctor
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class Assert // TypeDefIndex: 15219
{
	// Methods

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void NotNull(object var) { }
}

// Namespace: 
internal class DelegateHelpers.TypeInfo // TypeDefIndex: 15220
{
	// Fields
	public Type DelegateType; // 0x10
	public Dictionary<Type, DelegateHelpers.TypeInfo> TypeChain; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public sealed class DelegateHelpers.VBCallSiteDelegate0<T> : MulticastDelegate // TypeDefIndex: 15221
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0700 Offset: 0xCEF900 VA: 0x180CF0700
	|-DelegateHelpers.VBCallSiteDelegate0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual object Invoke(T callSite, object instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-DelegateHelpers.VBCallSiteDelegate0<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T callSite, object instance, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0660 Offset: 0xCEF860 VA: 0x180CF0660
	|-DelegateHelpers.VBCallSiteDelegate0<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240
	|-DelegateHelpers.VBCallSiteDelegate0<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
public sealed class DelegateHelpers.VBCallSiteDelegate1<T> : MulticastDelegate // TypeDefIndex: 15222
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF08B0 Offset: 0xCEFAB0 VA: 0x180CF08B0
	|-DelegateHelpers.VBCallSiteDelegate1<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual object Invoke(T callSite, object instance, ref object arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0
	|-DelegateHelpers.VBCallSiteDelegate1<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T callSite, object instance, ref object arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0810 Offset: 0xCEFA10 VA: 0x180CF0810
	|-DelegateHelpers.VBCallSiteDelegate1<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual object EndInvoke(ref object arg1, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070
	|-DelegateHelpers.VBCallSiteDelegate1<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
public sealed class DelegateHelpers.VBCallSiteDelegate2<T> : MulticastDelegate // TypeDefIndex: 15223
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0A80 Offset: 0xCEFC80 VA: 0x180CF0A80
	|-DelegateHelpers.VBCallSiteDelegate2<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual object Invoke(T callSite, object instance, ref object arg1, ref object arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0
	|-DelegateHelpers.VBCallSiteDelegate2<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T callSite, object instance, ref object arg1, ref object arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF09C0 Offset: 0xCEFBC0 VA: 0x180CF09C0
	|-DelegateHelpers.VBCallSiteDelegate2<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual object EndInvoke(ref object arg1, ref object arg2, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43FCF0 Offset: 0x43EEF0 VA: 0x18043FCF0
	|-DelegateHelpers.VBCallSiteDelegate2<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
public sealed class DelegateHelpers.VBCallSiteDelegate3<T> : MulticastDelegate // TypeDefIndex: 15224
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0C90 Offset: 0xCEFE90 VA: 0x180CF0C90
	|-DelegateHelpers.VBCallSiteDelegate3<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual object Invoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x449250 Offset: 0x448450 VA: 0x180449250
	|-DelegateHelpers.VBCallSiteDelegate3<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0B90 Offset: 0xCEFD90 VA: 0x180CF0B90
	|-DelegateHelpers.VBCallSiteDelegate3<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual object EndInvoke(ref object arg1, ref object arg2, ref object arg3, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0C60 Offset: 0xCEFE60 VA: 0x180CF0C60
	|-DelegateHelpers.VBCallSiteDelegate3<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
public sealed class DelegateHelpers.VBCallSiteDelegate4<T> : MulticastDelegate // TypeDefIndex: 15225
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0EC0 Offset: 0xCF00C0 VA: 0x180CF0EC0
	|-DelegateHelpers.VBCallSiteDelegate4<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual object Invoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4508F0 Offset: 0x44FAF0 VA: 0x1804508F0
	|-DelegateHelpers.VBCallSiteDelegate4<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0DA0 Offset: 0xCEFFA0 VA: 0x180CF0DA0
	|-DelegateHelpers.VBCallSiteDelegate4<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual object EndInvoke(ref object arg1, ref object arg2, ref object arg3, ref object arg4, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0E80 Offset: 0xCF0080 VA: 0x180CF0E80
	|-DelegateHelpers.VBCallSiteDelegate4<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
public sealed class DelegateHelpers.VBCallSiteDelegate5<T> : MulticastDelegate // TypeDefIndex: 15226
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1130 Offset: 0xCF0330 VA: 0x180CF1130
	|-DelegateHelpers.VBCallSiteDelegate5<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual object Invoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1110 Offset: 0xCF0310 VA: 0x180CF1110
	|-DelegateHelpers.VBCallSiteDelegate5<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0FD0 Offset: 0xCF01D0 VA: 0x180CF0FD0
	|-DelegateHelpers.VBCallSiteDelegate5<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual object EndInvoke(ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF10C0 Offset: 0xCF02C0 VA: 0x180CF10C0
	|-DelegateHelpers.VBCallSiteDelegate5<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
public sealed class DelegateHelpers.VBCallSiteDelegate6<T> : MulticastDelegate // TypeDefIndex: 15227
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF13B0 Offset: 0xCF05B0 VA: 0x180CF13B0
	|-DelegateHelpers.VBCallSiteDelegate6<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual object Invoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, ref object arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1390 Offset: 0xCF0590 VA: 0x180CF1390
	|-DelegateHelpers.VBCallSiteDelegate6<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, ref object arg6, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1240 Offset: 0xCF0440 VA: 0x180CF1240
	|-DelegateHelpers.VBCallSiteDelegate6<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual object EndInvoke(ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, ref object arg6, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1340 Offset: 0xCF0540 VA: 0x180CF1340
	|-DelegateHelpers.VBCallSiteDelegate6<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
public sealed class DelegateHelpers.VBCallSiteDelegate7<T> : MulticastDelegate // TypeDefIndex: 15228
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF16A0 Offset: 0xCF08A0 VA: 0x180CF16A0
	|-DelegateHelpers.VBCallSiteDelegate7<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual object Invoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, ref object arg6, ref object arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1630 Offset: 0xCF0830 VA: 0x180CF1630
	|-DelegateHelpers.VBCallSiteDelegate7<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, ref object arg6, ref object arg7, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF14C0 Offset: 0xCF06C0 VA: 0x180CF14C0
	|-DelegateHelpers.VBCallSiteDelegate7<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual object EndInvoke(ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, ref object arg6, ref object arg7, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF15D0 Offset: 0xCF07D0 VA: 0x180CF15D0
	|-DelegateHelpers.VBCallSiteDelegate7<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: System.Linq.Expressions.Compiler
internal static class DelegateHelpers // TypeDefIndex: 15229
{
	// Fields
	private static DelegateHelpers.TypeInfo _DelegateCache; // 0x0
	private const int MaximumArity = 17;

	// Methods

	// RVA: 0x1D560E0 Offset: 0x1D552E0 VA: 0x181D560E0
	internal static Type MakeDelegateType(Type[] types) { }

	// RVA: 0x1D56BA0 Offset: 0x1D55DA0 VA: 0x181D56BA0
	internal static DelegateHelpers.TypeInfo NextTypeInfo(Type initialArg) { }

	// RVA: 0x1D556F0 Offset: 0x1D548F0 VA: 0x181D556F0
	internal static DelegateHelpers.TypeInfo GetNextTypeInfo(Type initialArg, DelegateHelpers.TypeInfo curTypeInfo) { }

	// RVA: 0x1D56CC0 Offset: 0x1D55EC0 VA: 0x181D56CC0
	private static DelegateHelpers.TypeInfo NextTypeInfo(Type initialArg, DelegateHelpers.TypeInfo curTypeInfo) { }

	// RVA: 0x1D56E00 Offset: 0x1D56000 VA: 0x181D56E00
	private static Type TryMakeVBStyledCallSite(Type[] types) { }

	// RVA: 0x1D569E0 Offset: 0x1D55BE0 VA: 0x181D569E0
	internal static Type MakeNewDelegate(Type[] types) { }

	// RVA: 0x1D55460 Offset: 0x1D54660 VA: 0x181D55460
	internal static Type GetFuncType(Type[] types) { }

	// RVA: 0x1D551B0 Offset: 0x1D543B0 VA: 0x181D551B0
	internal static Type GetActionType(Type[] types) { }

	// RVA: 0x1D558A0 Offset: 0x1D54AA0 VA: 0x181D558A0
	internal static Type MakeCallSiteDelegate(ReadOnlyCollection<Expression> types, Type returnType) { }

	// RVA: 0x1D55B40 Offset: 0x1D54D40 VA: 0x181D55B40
	internal static Type MakeDeferredSiteDelegate(DynamicMetaObject[] args, Type returnType) { }

	// RVA: 0x1D55800 Offset: 0x1D54A00 VA: 0x181D55800
	private static bool IsByRef(DynamicMetaObject mo) { }

	// RVA: 0x1D569A0 Offset: 0x1D55BA0 VA: 0x181D569A0
	private static Type MakeNewCustomDelegate(Type[] types) { }

	// RVA: 0x1D57520 Offset: 0x1D56720 VA: 0x181D57520
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Compiler
internal sealed class HoistedLocals // TypeDefIndex: 15230
{
	// Fields
	internal readonly HoistedLocals Parent; // 0x10
	internal readonly ReadOnlyDictionary<Expression, int> Indexes; // 0x18
	internal readonly ReadOnlyCollection<ParameterExpression> Variables; // 0x20
	internal readonly ParameterExpression SelfVariable; // 0x28

	// Properties
	internal ParameterExpression ParentVariable { get; }

	// Methods

	// RVA: 0x1D5AA70 Offset: 0x1D59C70 VA: 0x181D5AA70
	internal void .ctor(HoistedLocals parent, ReadOnlyCollection<ParameterExpression> vars) { }

	// RVA: 0x1D5AC80 Offset: 0x1D59E80 VA: 0x181D5AC80
	internal ParameterExpression get_ParentVariable() { }

	// RVA: 0x1D5A980 Offset: 0x1D59B80 VA: 0x181D5A980
	internal static object[] GetParent(object[] locals) { }
}

// Namespace: System.Linq.Expressions.Compiler
[Extension]
internal static class TypeInfoExtensions // TypeDefIndex: 15231
{
	// Methods

	[Extension]
	// RVA: 0x1D6BA70 Offset: 0x1D6AC70 VA: 0x181D6BA70
	public static Type MakeDelegateType(DelegateHelpers.TypeInfo info, Type retType, Expression[] args) { }

	[Extension]
	// RVA: 0x1D6BA80 Offset: 0x1D6AC80 VA: 0x181D6BA80
	public static Type MakeDelegateType(DelegateHelpers.TypeInfo info, Type retType, IList<Expression> args) { }
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class RuntimeOps.MergedRuntimeVariables : IRuntimeVariables // TypeDefIndex: 15232
{
	// Fields
	private readonly IRuntimeVariables _first; // 0x10
	private readonly IRuntimeVariables _second; // 0x18
	private readonly int[] _indexes; // 0x20

	// Properties
	public int Count { get; }
	public object Item { get; set; }

	// Methods

	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	internal void .ctor(IRuntimeVariables first, IRuntimeVariables second, int[] indexes) { }

	// RVA: 0x10E1340 Offset: 0x10E0540 VA: 0x1810E1340 Slot: 4
	public int get_Count() { }

	// RVA: 0x1D5CBD0 Offset: 0x1D5BDD0 VA: 0x181D5CBD0 Slot: 5
	public object get_Item(int index) { }

	// RVA: 0x1D5CC60 Offset: 0x1D5BE60 VA: 0x181D5CC60 Slot: 6
	public void set_Item(int index, object value) { }
}

// Namespace: 
internal sealed class RuntimeOps.RuntimeVariables : IRuntimeVariables // TypeDefIndex: 15233
{
	// Fields
	private readonly IStrongBox[] _boxes; // 0x10

	// Properties
	private int System.Runtime.CompilerServices.IRuntimeVariables.Count { get; }
	private object System.Runtime.CompilerServices.IRuntimeVariables.Item { get; set; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(IStrongBox[] boxes) { }

	// RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20 Slot: 4
	private int System.Runtime.CompilerServices.IRuntimeVariables.get_Count() { }

	// RVA: 0x1D68390 Offset: 0x1D67590 VA: 0x181D68390 Slot: 5
	private object System.Runtime.CompilerServices.IRuntimeVariables.get_Item(int index) { }

	// RVA: 0x1D684F0 Offset: 0x1D676F0 VA: 0x181D684F0 Slot: 6
	private void System.Runtime.CompilerServices.IRuntimeVariables.set_Item(int index, object value) { }
}

// Namespace: System.Runtime.CompilerServices
[EditorBrowsable(1)]
[DebuggerStepThrough]
public static class RuntimeOps // TypeDefIndex: 15234
{
	// Methods

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1D680D0 Offset: 0x1D672D0 VA: 0x181D680D0
	public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1D68100 Offset: 0x1D67300 VA: 0x181D68100
	public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1D68020 Offset: 0x1D67220 VA: 0x181D68020
	public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase) { }

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x1D67FD0 Offset: 0x1D671D0 VA: 0x181D67FD0
	public static bool ExpandoCheckVersion(ExpandoObject expando, object version) { }

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x1D68000 Offset: 0x1D67200 VA: 0x181D68000
	public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass) { }
}

// Namespace: System.Runtime.CompilerServices
public class CallSite // TypeDefIndex: 15235
{
	// Fields
	private static CacheDict<Type, Func<CallSiteBinder, CallSite>> s_siteCtors; // 0x0
	internal readonly CallSiteBinder _binder; // 0x10
	internal bool _match; // 0x18

	// Properties
	public CallSiteBinder Binder { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(CallSiteBinder binder) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public CallSiteBinder get_Binder() { }

	// RVA: 0x1D518C0 Offset: 0x1D50AC0 VA: 0x181D518C0
	public static CallSite Create(Type delegateType, CallSiteBinder binder) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CallSite.<>c<T> // TypeDefIndex: 15236
{
	// Fields
	public static readonly CallSite.<>c<T> <>9; // 0x0
	public static Converter<ParameterInfo, ParameterExpression> <>9__20_0; // 0x0
	public static Converter<ParameterExpression, Expression> <>9__20_1; // 0x0
	public static Converter<ParameterInfo, ParameterExpression> <>9__21_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-CallSite.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-CallSite.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal ParameterExpression <CreateCustomUpdateDelegate>b__20_0(ParameterInfo p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB05F10 Offset: 0xB05110 VA: 0x180B05F10
	|-CallSite.<>c<object>.<CreateCustomUpdateDelegate>b__20_0
	*/

	// RVA: -1 Offset: -1
	internal Expression <CreateCustomUpdateDelegate>b__20_1(ParameterExpression p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB05FB0 Offset: 0xB051B0 VA: 0x180B05FB0
	|-CallSite.<>c<object>.<CreateCustomUpdateDelegate>b__20_1
	*/

	// RVA: -1 Offset: -1
	internal ParameterExpression <CreateCustomNoMatchDelegate>b__21_0(ParameterInfo p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB05E70 Offset: 0xB05070 VA: 0x180B05E70
	|-CallSite.<>c<object>.<CreateCustomNoMatchDelegate>b__21_0
	*/
}

// Namespace: System.Runtime.CompilerServices
public class CallSite<T> : CallSite // TypeDefIndex: 15237
{
	// Fields
	public T Target; // 0x0
	internal T[] Rules; // 0x0
	private static T s_cachedUpdate; // 0x0
	private static T s_cachedNoMatch; // 0x0

	// Properties
	public T Update { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFCCD0 Offset: 0xEFBED0 VA: 0x180EFCCD0
	|-CallSite<object>.get_Update
	*/

	// RVA: -1 Offset: -1
	private void .ctor(CallSiteBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFCB20 Offset: 0xEFBD20 VA: 0x180EFCB20
	|-CallSite<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFCCC0 Offset: 0xEFBEC0 VA: 0x180EFCCC0
	|-CallSite<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal CallSite<T> CreateMatchMaker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFC350 Offset: 0xEFB550 VA: 0x180EFC350
	|-CallSite<object>.CreateMatchMaker
	*/

	// RVA: -1 Offset: -1
	public static CallSite<T> Create(CallSiteBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFC3A0 Offset: 0xEFB5A0 VA: 0x180EFC3A0
	|-CallSite<object>.Create
	*/

	// RVA: -1 Offset: -1
	private T GetUpdateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFC680 Offset: 0xEFB880 VA: 0x180EFC680
	|-CallSite<object>.GetUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T GetUpdateDelegate(ref T addr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFC800 Offset: 0xEFBA00 VA: 0x180EFC800
	|-CallSite<object>.GetUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	internal void AddRule(T newRule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFAA50 Offset: 0xEF9C50 VA: 0x180EFAA50
	|-CallSite<object>.AddRule
	*/

	// RVA: -1 Offset: -1
	internal void MoveRule(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFCAA0 Offset: 0xEFBCA0 VA: 0x180EFCAA0
	|-CallSite<object>.MoveRule
	*/

	// RVA: -1 Offset: -1
	internal T MakeUpdateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFC970 Offset: 0xEFBB70 VA: 0x180EFC970
	|-CallSite<object>.MakeUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T CreateCustomUpdateDelegate(MethodInfo invoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFAF90 Offset: 0xEFA190 VA: 0x180EFAF90
	|-CallSite<object>.CreateCustomUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T CreateCustomNoMatchDelegate(MethodInfo invoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFAC30 Offset: 0xEF9E30 VA: 0x180EFAC30
	|-CallSite<object>.CreateCustomNoMatchDelegate
	*/

	// RVA: -1 Offset: -1
	private static Expression Convert(Expression arg, Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFAB60 Offset: 0xEF9D60 VA: 0x180EFAB60
	|-CallSite<object>.Convert
	*/
}

// Namespace: 
private sealed class CallSiteBinder.LambdaSignature<T> // TypeDefIndex: 15238
{
	// Fields
	private static CallSiteBinder.LambdaSignature<T> s_instance; // 0x0
	internal readonly ReadOnlyCollection<ParameterExpression> Parameters; // 0x0
	internal readonly LabelTarget ReturnLabel; // 0x0

	// Properties
	internal static CallSiteBinder.LambdaSignature<T> Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal static CallSiteBinder.LambdaSignature<T> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131C180 Offset: 0x131B380 VA: 0x18131C180
	|-CallSiteBinder.LambdaSignature<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131BDF0 Offset: 0x131AFF0 VA: 0x18131BDF0
	|-CallSiteBinder.LambdaSignature<object>..ctor
	*/
}

// Namespace: System.Runtime.CompilerServices
public abstract class CallSiteBinder // TypeDefIndex: 15239
{
	// Fields
	internal Dictionary<Type, object> Cache; // 0x10
	[CompilerGenerated]
	private static readonly LabelTarget <UpdateLabel>k__BackingField; // 0x0

	// Properties
	public static LabelTarget UpdateLabel { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D51810 Offset: 0x1D50A10 VA: 0x181D51810
	public static LabelTarget get_UpdateLabel() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);

	// RVA: -1 Offset: -1 Slot: 5
	public virtual T BindDelegate<T>(CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	|-CallSiteBinder.BindDelegate<object>
	*/

	// RVA: -1 Offset: -1
	internal T BindCore<T>(CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x945860 Offset: 0x944A60 VA: 0x180945860
	|-CallSiteBinder.BindCore<object>
	*/

	// RVA: -1 Offset: -1
	protected void CacheTarget<T>(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9459E0 Offset: 0x944BE0 VA: 0x1809459E0
	|-CallSiteBinder.CacheTarget<object>
	*/

	// RVA: -1 Offset: -1
	private static Expression<T> Stitch<T>(Expression binding, CallSiteBinder.LambdaSignature<T> signature) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x945CC0 Offset: 0x944EC0 VA: 0x180945CC0
	|-CallSiteBinder.Stitch<object>
	*/

	// RVA: -1 Offset: -1
	internal RuleCache<T> GetRuleCache<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x945A50 Offset: 0x944C50 VA: 0x180945A50
	|-CallSiteBinder.GetRuleCache<object>
	*/

	// RVA: 0x1D51790 Offset: 0x1D50990 VA: 0x181D51790
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
[EditorBrowsable(1)]
[DebuggerStepThrough]
public static class CallSiteOps // TypeDefIndex: 15240
{
	// Methods

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static CallSite<T> CreateMatchmaker<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x946280 Offset: 0x945480 VA: 0x180946280
	|-CallSiteOps.CreateMatchmaker<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1D518A0 Offset: 0x1D50AA0 VA: 0x181D518A0
	public static bool SetNotMatched(CallSite site) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1D51880 Offset: 0x1D50A80 VA: 0x181D51880
	public static bool GetMatch(CallSite site) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1D51860 Offset: 0x1D50A60 VA: 0x181D51860
	public static void ClearMatch(CallSite site) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static void AddRule<T>(CallSite<T> site, T rule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x946080 Offset: 0x945280 VA: 0x180946080
	|-CallSiteOps.AddRule<object>
	*/

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static void UpdateRules<T>(CallSite<T> this, int matched) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9463E0 Offset: 0x9455E0 VA: 0x1809463E0
	|-CallSiteOps.UpdateRules<object>
	*/

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static T[] GetRules<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x946350 Offset: 0x945550 VA: 0x180946350
	|-CallSiteOps.GetRules<object>
	*/

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static RuleCache<T> GetRuleCache<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x946300 Offset: 0x945500 VA: 0x180946300
	|-CallSiteOps.GetRuleCache<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static void MoveRule<T>(RuleCache<T> cache, T rule, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x946370 Offset: 0x945570 VA: 0x180946370
	|-CallSiteOps.MoveRule<object>
	*/

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static T[] GetCachedRules<T>(RuleCache<T> cache) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9462D0 Offset: 0x9454D0 VA: 0x1809462D0
	|-CallSiteOps.GetCachedRules<object>
	*/

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static T Bind<T>(CallSiteBinder binder, CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9460E0 Offset: 0x9452E0 VA: 0x1809460E0
	|-CallSiteOps.Bind<object>
	*/
}

// Namespace: System.Runtime.CompilerServices
public abstract class DebugInfoGenerator // TypeDefIndex: 15241
{}

// Namespace: System.Runtime.CompilerServices
[DefaultMember("Item")]
public interface IRuntimeVariables // TypeDefIndex: 15242
{
	// Properties
	public abstract int Count { get; }
	public abstract object Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_Item(int index, object value);
}

// Namespace: 
[Serializable]
private class ReadOnlyCollectionBuilder.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 15243
{
	// Fields
	private readonly ReadOnlyCollectionBuilder<T> _builder; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ReadOnlyCollectionBuilder<T> builder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0350 Offset: 0x10EF550 VA: 0x1810F0350
	|-ReadOnlyCollectionBuilder.Enumerator<object>..ctor
	|
	|-RVA: 0x1110A50 Offset: 0x110FC50 VA: 0x181110A50
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-ReadOnlyCollectionBuilder.Enumerator<object>.get_Current
	|
	|-RVA: 0xBFE5D0 Offset: 0xBFD7D0 VA: 0x180BFE5D0
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ReadOnlyCollectionBuilder.Enumerator<object>.Dispose
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EEB00 Offset: 0x10EDD00 VA: 0x1810EEB00
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110E620 Offset: 0x110D820 VA: 0x18110E620
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED5A0 Offset: 0x10EC7A0 VA: 0x1810ED5A0
	|-ReadOnlyCollectionBuilder.Enumerator<object>.MoveNext
	|
	|-RVA: 0x1109890 Offset: 0x1108A90 VA: 0x181109890
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE9D0 Offset: 0x10EDBD0 VA: 0x1810EE9D0
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x110CFC0 Offset: 0x110C1C0 VA: 0x18110CFC0
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: System.Runtime.CompilerServices
[DefaultMember("Item")]
[Serializable]
public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection // TypeDefIndex: 15244
{
	// Fields
	private T[] _items; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0

	// Properties
	public int Capacity { set; }
	public int Count { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB95030 Offset: 0xB94230 VA: 0x180B95030
	|-ReadOnlyCollectionBuilder<object>..ctor
	|
	|-RVA: 0xB966E0 Offset: 0xB958E0 VA: 0x180B966E0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB40D0 Offset: 0xBB32D0 VA: 0x180BB40D0
	|-ReadOnlyCollectionBuilder<object>..ctor
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB42F0 Offset: 0xBB34F0 VA: 0x180BB42F0
	|-ReadOnlyCollectionBuilder<object>.set_Capacity
	|
	|-RVA: 0xBB4400 Offset: 0xBB3600 VA: 0x180BB4400
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-ReadOnlyCollectionBuilder<object>.get_Count
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1F80 Offset: 0xBB1180 VA: 0x180BB1F80
	|-ReadOnlyCollectionBuilder<object>.IndexOf
	|
	|-RVA: 0xBB1E70 Offset: 0xBB1070 VA: 0x180BB1E70
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1FB0 Offset: 0xBB11B0 VA: 0x180BB1FB0
	|-ReadOnlyCollectionBuilder<object>.Insert
	|
	|-RVA: 0xBB20B0 Offset: 0xBB12B0 VA: 0x180BB20B0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB2410 Offset: 0xBB1610 VA: 0x180BB2410
	|-ReadOnlyCollectionBuilder<object>.RemoveAt
	|
	|-RVA: 0xBB24D0 Offset: 0xBB16D0 VA: 0x180BB24D0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB4170 Offset: 0xBB3370 VA: 0x180BB4170
	|-ReadOnlyCollectionBuilder<object>.get_Item
	|
	|-RVA: 0xBB41F0 Offset: 0xBB33F0 VA: 0x180BB41F0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB4660 Offset: 0xBB3860 VA: 0x180BB4660
	|-ReadOnlyCollectionBuilder<object>.set_Item
	|
	|-RVA: 0xBB4510 Offset: 0xBB3710 VA: 0x180BB4510
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB16D0 Offset: 0xBB08D0 VA: 0x180BB16D0
	|-ReadOnlyCollectionBuilder<object>.Add
	|
	|-RVA: 0xBB1590 Offset: 0xBB0790 VA: 0x180BB1590
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1750 Offset: 0xBB0950 VA: 0x180BB1750
	|-ReadOnlyCollectionBuilder<object>.Clear
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1790 Offset: 0xBB0990 VA: 0x180BB1790
	|-ReadOnlyCollectionBuilder<object>.Contains
	|
	|-RVA: 0xBB1970 Offset: 0xBB0B70 VA: 0x180BB1970
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1BC0 Offset: 0xBB0DC0 VA: 0x180BB1BC0
	|-ReadOnlyCollectionBuilder<object>.CopyTo
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ReadOnlyCollectionBuilder<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB2680 Offset: 0xBB1880 VA: 0x180BB2680
	|-ReadOnlyCollectionBuilder<object>.Remove
	|
	|-RVA: 0xBB2790 Offset: 0xBB1990 VA: 0x180BB2790
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1D90 Offset: 0xBB0F90 VA: 0x180BB1D90
	|-ReadOnlyCollectionBuilder<object>.GetEnumerator
	|
	|-RVA: 0xBB1E00 Offset: 0xBB1000 VA: 0x180BB1E00
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB2990 Offset: 0xBB1B90 VA: 0x180BB2990
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBB2A10 Offset: 0xBB1C10 VA: 0x180BB2A10
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB2BE0 Offset: 0xBB1DE0 VA: 0x180BB2BE0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Add
	|
	|-RVA: 0xBB2A30 Offset: 0xBB1C30 VA: 0x180BB2A30
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB2D70 Offset: 0xBB1F70 VA: 0x180BB2D70
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Contains
	|
	|-RVA: 0xBB2E70 Offset: 0xBB2070 VA: 0x180BB2E70
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB30B0 Offset: 0xBB22B0 VA: 0x180BB30B0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xBB2F90 Offset: 0xBB2190 VA: 0x180BB2F90
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB3390 Offset: 0xBB2590 VA: 0x180BB3390
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Insert
	|
	|-RVA: 0xBB31D0 Offset: 0xBB23D0 VA: 0x180BB31D0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB3690 Offset: 0xBB2890 VA: 0x180BB3690
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Remove
	|
	|-RVA: 0xBB3580 Offset: 0xBB2780 VA: 0x180BB3580
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB3860 Offset: 0xBB2A60 VA: 0x180BB3860
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0xBB38F0 Offset: 0xBB2AF0 VA: 0x180BB38F0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB3B80 Offset: 0xBB2D80 VA: 0x180BB3B80
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0xBB39C0 Offset: 0xBB2BC0 VA: 0x180BB39C0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB28A0 Offset: 0xBB1AA0 VA: 0x180BB28A0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.CopyTo
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_SyncRoot
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB3D00 Offset: 0xBB2F00 VA: 0x180BB3D00
	|-ReadOnlyCollectionBuilder<object>.ToArray
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> ToReadOnlyCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB3E50 Offset: 0xBB3050 VA: 0x180BB3E50
	|-ReadOnlyCollectionBuilder<object>.ToReadOnlyCollection
	|
	|-RVA: 0xBB3D70 Offset: 0xBB2F70 VA: 0x180BB3D70
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ToReadOnlyCollection
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1BF0 Offset: 0xBB0DF0 VA: 0x180BB1BF0
	|-ReadOnlyCollectionBuilder<object>.EnsureCapacity
	|
	|-RVA: 0xBB1D30 Offset: 0xBB0F30 VA: 0x180BB1D30
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB23B0 Offset: 0xBB15B0 VA: 0x180BB23B0
	|-ReadOnlyCollectionBuilder<object>.IsCompatibleObject
	|
	|-RVA: 0xBB2270 Offset: 0xBB1470 VA: 0x180BB2270
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1
	private static void ValidateNullValue(object value, string argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x767080 Offset: 0x766280 VA: 0x180767080
	|-ReadOnlyCollectionBuilder<object>.ValidateNullValue
	|
	|-RVA: 0xBB3F70 Offset: 0xBB3170 VA: 0x180BB3F70
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ValidateNullValue
	*/
}

// Namespace: System.Runtime.CompilerServices
[DebuggerStepThrough]
[EditorBrowsable(1)]
public class RuleCache<T> // TypeDefIndex: 15245
{
	// Fields
	private T[] _rules; // 0x0
	private readonly object _cacheLock; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEA530 Offset: 0xBE9730 VA: 0x180BEA530
	|-RuleCache<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] GetRules() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-RuleCache<object>.GetRules
	*/

	// RVA: -1 Offset: -1
	internal void MoveRule(T rule, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEA2D0 Offset: 0xBE94D0 VA: 0x180BEA2D0
	|-RuleCache<object>.MoveRule
	*/

	// RVA: -1 Offset: -1
	internal void AddRule(T newRule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEA100 Offset: 0xBE9300 VA: 0x180BEA100
	|-RuleCache<object>.AddRule
	*/

	// RVA: -1 Offset: -1
	private static T[] AddOrInsert(T[] rules, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE9FD0 Offset: 0xBE91D0 VA: 0x180BE9FD0
	|-RuleCache<object>.AddOrInsert
	*/
}

// Namespace: System.Runtime.CompilerServices
internal sealed class TrueReadOnlyCollection<T> : ReadOnlyCollection<T> // TypeDefIndex: 15246
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC5A00 Offset: 0xCC4C00 VA: 0x180CC5A00
	|-TrueReadOnlyCollection<object>..ctor
	|
	|-RVA: 0xCC59E0 Offset: 0xCC4BE0 VA: 0x180CC59E0
	|-TrueReadOnlyCollection<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Runtime.CompilerServices
public class StrongBox<T> : IStrongBox // TypeDefIndex: 15247
{
	// Fields
	public T Value; // 0x0

	// Properties
	private object System.Runtime.CompilerServices.IStrongBox.Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-StrongBox<int>..ctor
	|-StrongBox<object>..ctor
	|-StrongBox<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	|-StrongBox<int>..ctor
	|
	|-RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	|-StrongBox<object>..ctor
	|
	|-RVA: 0xC3FD80 Offset: 0xC3EF80 VA: 0x180C3FD80
	|-StrongBox<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private object System.Runtime.CompilerServices.IStrongBox.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3FAA0 Offset: 0xC3ECA0 VA: 0x180C3FAA0
	|-StrongBox<int>.System.Runtime.CompilerServices.IStrongBox.get_Value
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-StrongBox<object>.System.Runtime.CompilerServices.IStrongBox.get_Value
	|
	|-RVA: 0xC3FAD0 Offset: 0xC3ECD0 VA: 0x180C3FAD0
	|-StrongBox<__Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.IStrongBox.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Runtime.CompilerServices.IStrongBox.set_Value(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3FC50 Offset: 0xC3EE50 VA: 0x180C3FC50
	|-StrongBox<int>.System.Runtime.CompilerServices.IStrongBox.set_Value
	|
	|-RVA: 0xC3FCC0 Offset: 0xC3EEC0 VA: 0x180C3FCC0
	|-StrongBox<object>.System.Runtime.CompilerServices.IStrongBox.set_Value
	|
	|-RVA: 0xC3FB80 Offset: 0xC3ED80 VA: 0x180C3FB80
	|-StrongBox<__Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.IStrongBox.set_Value
	*/
}

// Namespace: System.Runtime.CompilerServices
public interface IStrongBox // TypeDefIndex: 15248
{
	// Properties
	public abstract object Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Value(object value);
}

// Namespace: System.Runtime.CompilerServices
[Usage(10636)]
public sealed class DynamicAttribute : Attribute // TypeDefIndex: 15249
{}

// Namespace: System.Dynamic
public abstract class BinaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 15250
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <Operation>k__BackingField; // 0x18

	// Properties
	public ExpressionType Operation { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ExpressionType get_Operation() { }

	// RVA: 0x1D50E60 Offset: 0x1D50060 VA: 0x181D50E60
	public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);

	// RVA: 0x1D50D80 Offset: 0x1D4FF80 VA: 0x181D50D80 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: 
private struct BindingRestrictions.TestBuilder.AndNode // TypeDefIndex: 15251
{
	// Fields
	internal int Depth; // 0x0
	internal Expression Node; // 0x8
}

// Namespace: 
private sealed class BindingRestrictions.TestBuilder // TypeDefIndex: 15252
{
	// Fields
	private readonly HashSet<BindingRestrictions> _unique; // 0x10
	private readonly Stack<BindingRestrictions.TestBuilder.AndNode> _tests; // 0x18

	// Methods

	// RVA: 0x1D6AE90 Offset: 0x1D6A090 VA: 0x181D6AE90
	internal void Append(BindingRestrictions restrictions) { }

	// RVA: 0x1D6B170 Offset: 0x1D6A370 VA: 0x181D6B170
	internal Expression ToExpression() { }

	// RVA: 0x1D6B030 Offset: 0x1D6A230 VA: 0x181D6B030
	private void Push(Expression node, int depth) { }

	// RVA: 0x1D6B250 Offset: 0x1D6A450 VA: 0x181D6B250
	public void .ctor() { }
}

// Namespace: 
private sealed class BindingRestrictions.MergedRestriction : BindingRestrictions // TypeDefIndex: 15253
{
	// Fields
	internal readonly BindingRestrictions Left; // 0x10
	internal readonly BindingRestrictions Right; // 0x18

	// Methods

	// RVA: 0x1D5CB60 Offset: 0x1D5BD60 VA: 0x181D5CB60
	internal void .ctor(BindingRestrictions left, BindingRestrictions right) { }

	// RVA: 0x1D5C780 Offset: 0x1D5B980 VA: 0x181D5C780 Slot: 4
	internal override Expression GetExpression() { }
}

// Namespace: 
private sealed class BindingRestrictions.CustomRestriction : BindingRestrictions // TypeDefIndex: 15254
{
	// Fields
	private readonly Expression _expression; // 0x10

	// Methods

	// RVA: 0x1D54480 Offset: 0x1D53680 VA: 0x181D54480
	internal void .ctor(Expression expression) { }

	// RVA: 0x1D543F0 Offset: 0x1D535F0 VA: 0x181D543F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D54450 Offset: 0x1D53650 VA: 0x181D54450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	internal override Expression GetExpression() { }
}

// Namespace: 
private sealed class BindingRestrictions.TypeRestriction : BindingRestrictions // TypeDefIndex: 15255
{
	// Fields
	private readonly Expression _expression; // 0x10
	private readonly Type _type; // 0x18

	// Methods

	// RVA: 0x1D6C020 Offset: 0x1D6B220 VA: 0x181D6C020
	internal void .ctor(Expression parameter, Type type) { }

	// RVA: 0x1D6BEB0 Offset: 0x1D6B0B0 VA: 0x181D6BEB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D6BFC0 Offset: 0x1D6B1C0 VA: 0x181D6BFC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D6BF60 Offset: 0x1D6B160 VA: 0x181D6BF60 Slot: 4
	internal override Expression GetExpression() { }
}

// Namespace: 
private sealed class BindingRestrictions.InstanceRestriction : BindingRestrictions // TypeDefIndex: 15256
{
	// Fields
	private readonly Expression _expression; // 0x10
	private readonly object _instance; // 0x18

	// Methods

	// RVA: 0x1D5B4A0 Offset: 0x1D5A6A0 VA: 0x181D5B4A0
	internal void .ctor(Expression parameter, object instance) { }

	// RVA: 0x1D5B010 Offset: 0x1D5A210 VA: 0x181D5B010 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D5B450 Offset: 0x1D5A650 VA: 0x181D5B450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D5B0A0 Offset: 0x1D5A2A0 VA: 0x181D5B0A0 Slot: 4
	internal override Expression GetExpression() { }
}

// Namespace: 
private sealed class BindingRestrictions.BindingRestrictionsProxy // TypeDefIndex: 15257
{}

// Namespace: System.Dynamic
[DebuggerTypeProxy(typeof(BindingRestrictions.BindingRestrictionsProxy))]
[DebuggerDisplay("{DebugView}")]
public abstract class BindingRestrictions // TypeDefIndex: 15258
{
	// Fields
	public static readonly BindingRestrictions Empty; // 0x0

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract Expression GetExpression();

	// RVA: 0x1D51330 Offset: 0x1D50530 VA: 0x181D51330
	public BindingRestrictions Merge(BindingRestrictions restrictions) { }

	// RVA: 0x1D51250 Offset: 0x1D50450 VA: 0x181D51250
	public static BindingRestrictions GetTypeRestriction(Expression expression, Type type) { }

	// RVA: 0x1D50F50 Offset: 0x1D50150 VA: 0x181D50F50
	internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj) { }

	// RVA: 0x1D50E90 Offset: 0x1D50090 VA: 0x181D50E90
	public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance) { }

	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170
	public Expression ToExpression() { }

	// RVA: 0x1D51460 Offset: 0x1D50660 VA: 0x181D51460
	private static void .cctor() { }
}

// Namespace: System.Dynamic
public abstract class ConvertBinder : DynamicMetaObjectBinder // TypeDefIndex: 15259
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x18

	// Properties
	public Type Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Type get_Type() { }

	// RVA: 0x156A970 Offset: 0x1569B70 VA: 0x18156A970
	public DynamicMetaObject FallbackConvert(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1D54070 Offset: 0x1D53270 VA: 0x181D54070 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public abstract class CreateInstanceBinder : DynamicMetaObjectBinder // TypeDefIndex: 15260
{
	// Methods

	// RVA: 0x1D50E60 Offset: 0x1D50060 VA: 0x181D50E60
	public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: 0x1D54340 Offset: 0x1D53540 VA: 0x181D54340 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public abstract class DeleteIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 15261
{
	// Methods

	// RVA: 0x1D57580 Offset: 0x1D56780 VA: 0x181D57580 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1D50E60 Offset: 0x1D50060 VA: 0x181D50E60
	public DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class DeleteMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15262
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public string Name { get; }
	public bool IgnoreCase { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IgnoreCase() { }

	// RVA: 0x156A970 Offset: 0x1569B70 VA: 0x18156A970
	public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1D57630 Offset: 0x1D56830 VA: 0x181D57630 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public class DynamicMetaObject // TypeDefIndex: 15263
{
	// Fields
	public static readonly DynamicMetaObject[] EmptyMetaObjects; // 0x0
	private static readonly object s_noValueSentinel; // 0x8
	private readonly object _value; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly BindingRestrictions <Restrictions>k__BackingField; // 0x20

	// Properties
	public Expression Expression { get; }
	public BindingRestrictions Restrictions { get; }
	public object Value { get; }
	public bool HasValue { get; }
	public Type RuntimeType { get; }
	public Type LimitType { get; }

	// Methods

	// RVA: 0x1D58DC0 Offset: 0x1D57FC0 VA: 0x181D58DC0
	public void .ctor(Expression expression, BindingRestrictions restrictions) { }

	// RVA: 0x1D58CE0 Offset: 0x1D57EE0 VA: 0x181D58CE0
	public void .ctor(Expression expression, BindingRestrictions restrictions, object value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Expression get_Expression() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public BindingRestrictions get_Restrictions() { }

	// RVA: 0x1D59090 Offset: 0x1D58290 VA: 0x181D59090
	public object get_Value() { }

	// RVA: 0x1D58E80 Offset: 0x1D58080 VA: 0x181D58E80
	public bool get_HasValue() { }

	// RVA: 0x1D58FC0 Offset: 0x1D581C0 VA: 0x181D58FC0
	public Type get_RuntimeType() { }

	// RVA: 0x1D58EE0 Offset: 0x1D580E0 VA: 0x181D58EE0
	public Type get_LimitType() { }

	// RVA: 0x1D583B0 Offset: 0x1D575B0 VA: 0x181D583B0 Slot: 4
	public virtual DynamicMetaObject BindConvert(ConvertBinder binder) { }

	// RVA: 0x1D58630 Offset: 0x1D57830 VA: 0x181D58630 Slot: 5
	public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x1D58830 Offset: 0x1D57A30 VA: 0x181D58830 Slot: 6
	public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x1D58540 Offset: 0x1D57740 VA: 0x181D58540 Slot: 7
	public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x1D585B0 Offset: 0x1D577B0 VA: 0x181D585B0 Slot: 8
	public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x1D587A0 Offset: 0x1D579A0 VA: 0x181D587A0 Slot: 9
	public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: 0x1D584B0 Offset: 0x1D576B0 VA: 0x181D584B0 Slot: 10
	public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x1D586A0 Offset: 0x1D578A0 VA: 0x181D586A0 Slot: 11
	public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1D58720 Offset: 0x1D57920 VA: 0x181D58720 Slot: 12
	public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1D58420 Offset: 0x1D57620 VA: 0x181D58420 Slot: 13
	public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1D588B0 Offset: 0x1D57AB0 VA: 0x181D588B0 Slot: 14
	public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	// RVA: 0x1D58320 Offset: 0x1D57520 VA: 0x181D58320 Slot: 15
	public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	// RVA: 0x1D58AF0 Offset: 0x1D57CF0 VA: 0x181D58AF0 Slot: 16
	public virtual IEnumerable<string> GetDynamicMemberNames() { }

	// RVA: 0x1D58B20 Offset: 0x1D57D20 VA: 0x181D58B20
	internal static Expression[] GetExpressions(DynamicMetaObject[] objects) { }

	// RVA: 0x1D58920 Offset: 0x1D57B20 VA: 0x181D58920
	public static DynamicMetaObject Create(object value, Expression expression) { }

	// RVA: 0x1D58C50 Offset: 0x1D57E50 VA: 0x181D58C50
	private static void .cctor() { }
}

// Namespace: System.Dynamic
public abstract class DynamicMetaObjectBinder : CallSiteBinder // TypeDefIndex: 15264
{
	// Properties
	public virtual Type ReturnType { get; }
	internal virtual bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x1D58270 Offset: 0x1D57470 VA: 0x181D58270
	protected void .ctor() { }

	// RVA: 0x1D582C0 Offset: 0x1D574C0 VA: 0x181D582C0 Slot: 6
	public virtual Type get_ReturnType() { }

	// RVA: 0x1D577A0 Offset: 0x1D569A0 VA: 0x181D577A0 Slot: 4
	public sealed override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) { }

	// RVA: 0x1D58020 Offset: 0x1D57220 VA: 0x181D58020
	private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);

	// RVA: 0x1D581B0 Offset: 0x1D573B0 VA: 0x181D581B0
	public Expression GetUpdateExpression(Type type) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	internal virtual bool get_IsStandardBinder() { }
}

// Namespace: 
private sealed class DynamicObject.MetaDynamic.Fallback<TBinder> : MulticastDelegate // TypeDefIndex: 15265
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3030 Offset: 0x11F2230 VA: 0x1811F3030
	|-DynamicObject.MetaDynamic.Fallback<object>..ctor
	|
	|-RVA: 0x11F30E0 Offset: 0x11F22E0 VA: 0x1811F30E0
	|-DynamicObject.MetaDynamic.Fallback<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual DynamicMetaObject Invoke(DynamicObject.MetaDynamic this, TBinder binder, DynamicMetaObject errorSuggestion) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0
	|-DynamicObject.MetaDynamic.Fallback<object>.Invoke
	|-DynamicObject.MetaDynamic.Fallback<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class DynamicObject.MetaDynamic.GetBinderAdapter : GetMemberBinder // TypeDefIndex: 15266
{
	// Methods

	// RVA: 0x1211C90 Offset: 0x1210E90 VA: 0x181211C90
	internal void .ctor(InvokeMemberBinder binder) { }

	// RVA: 0x1D5A720 Offset: 0x1D59920 VA: 0x181D5A720 Slot: 9
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DynamicObject.MetaDynamic.<>c // TypeDefIndex: 15267
{
	// Fields
	public static readonly DynamicObject.MetaDynamic.<>c <>9; // 0x0
	public static DynamicObject.MetaDynamic.Fallback<GetMemberBinder> <>9__2_0; // 0x8
	public static DynamicObject.MetaDynamic.Fallback<DeleteMemberBinder> <>9__4_0; // 0x10
	public static DynamicObject.MetaDynamic.Fallback<ConvertBinder> <>9__5_0; // 0x18
	public static DynamicObject.MetaDynamic.Fallback<UnaryOperationBinder> <>9__10_0; // 0x20

	// Methods

	// RVA: 0x1D6C200 Offset: 0x1D6B400 VA: 0x181D6C200
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D6C090 Offset: 0x1D6B290 VA: 0x181D6C090
	internal DynamicMetaObject <BindGetMember>b__2_0(DynamicObject.MetaDynamic this, GetMemberBinder b, DynamicMetaObject e) { }

	// RVA: 0x1D6C090 Offset: 0x1D6B290 VA: 0x181D6C090
	internal DynamicMetaObject <BindDeleteMember>b__4_0(DynamicObject.MetaDynamic this, DeleteMemberBinder b, DynamicMetaObject e) { }

	// RVA: 0x1D6C090 Offset: 0x1D6B290 VA: 0x181D6C090
	internal DynamicMetaObject <BindConvert>b__5_0(DynamicObject.MetaDynamic this, ConvertBinder b, DynamicMetaObject e) { }

	// RVA: 0x1D6C090 Offset: 0x1D6B290 VA: 0x181D6C090
	internal DynamicMetaObject <BindUnaryOperation>b__10_0(DynamicObject.MetaDynamic this, UnaryOperationBinder b, DynamicMetaObject e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicObject.MetaDynamic.<>c__DisplayClass3_0 // TypeDefIndex: 15268
{
	// Fields
	public DynamicMetaObject localValue; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D6C0F0 Offset: 0x1D6B2F0 VA: 0x181D6C0F0
	internal DynamicMetaObject <BindSetMember>b__0(DynamicObject.MetaDynamic this, SetMemberBinder b, DynamicMetaObject e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicObject.MetaDynamic.<>c__DisplayClass6_0 // TypeDefIndex: 15269
{
	// Fields
	public InvokeMemberBinder binder; // 0x10
	public DynamicMetaObject[] args; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D6C170 Offset: 0x1D6B370 VA: 0x181D6C170
	internal DynamicMetaObject <BindInvokeMember>b__0(DynamicObject.MetaDynamic this, GetMemberBinder ignored, DynamicMetaObject e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicObject.MetaDynamic.<>c__DisplayClass7_0 // TypeDefIndex: 15270
{
	// Fields
	public DynamicMetaObject[] localArgs; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D6C0F0 Offset: 0x1D6B2F0 VA: 0x181D6C0F0
	internal DynamicMetaObject <BindCreateInstance>b__0(DynamicObject.MetaDynamic this, CreateInstanceBinder b, DynamicMetaObject e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicObject.MetaDynamic.<>c__DisplayClass8_0 // TypeDefIndex: 15271
{
	// Fields
	public DynamicMetaObject[] localArgs; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D6C0F0 Offset: 0x1D6B2F0 VA: 0x181D6C0F0
	internal DynamicMetaObject <BindInvoke>b__0(DynamicObject.MetaDynamic this, InvokeBinder b, DynamicMetaObject e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicObject.MetaDynamic.<>c__DisplayClass9_0 // TypeDefIndex: 15272
{
	// Fields
	public DynamicMetaObject localArg; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D6C0F0 Offset: 0x1D6B2F0 VA: 0x181D6C0F0
	internal DynamicMetaObject <BindBinaryOperation>b__0(DynamicObject.MetaDynamic this, BinaryOperationBinder b, DynamicMetaObject e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicObject.MetaDynamic.<>c__DisplayClass11_0 // TypeDefIndex: 15273
{
	// Fields
	public DynamicMetaObject[] localIndexes; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D6C0F0 Offset: 0x1D6B2F0 VA: 0x181D6C0F0
	internal DynamicMetaObject <BindGetIndex>b__0(DynamicObject.MetaDynamic this, GetIndexBinder b, DynamicMetaObject e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicObject.MetaDynamic.<>c__DisplayClass12_0 // TypeDefIndex: 15274
{
	// Fields
	public DynamicMetaObject[] localIndexes; // 0x10
	public DynamicMetaObject localValue; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D6C130 Offset: 0x1D6B330 VA: 0x181D6C130
	internal DynamicMetaObject <BindSetIndex>b__0(DynamicObject.MetaDynamic this, SetIndexBinder b, DynamicMetaObject e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicObject.MetaDynamic.<>c__DisplayClass13_0 // TypeDefIndex: 15275
{
	// Fields
	public DynamicMetaObject[] localIndexes; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D6C0F0 Offset: 0x1D6B2F0 VA: 0x181D6C0F0
	internal DynamicMetaObject <BindDeleteIndex>b__0(DynamicObject.MetaDynamic this, DeleteIndexBinder b, DynamicMetaObject e) { }
}

// Namespace: 
private sealed class DynamicObject.MetaDynamic : DynamicMetaObject // TypeDefIndex: 15276
{
	// Fields
	private static readonly Expression[] s_noArgs; // 0x0

	// Properties
	private DynamicObject Value { get; }

	// Methods

	// RVA: 0x1D5EAE0 Offset: 0x1D5DCE0 VA: 0x181D5EAE0
	internal void .ctor(Expression expression, DynamicObject value) { }

	// RVA: 0x1D5E440 Offset: 0x1D5D640 VA: 0x181D5E440 Slot: 16
	public override IEnumerable<string> GetDynamicMemberNames() { }

	// RVA: 0x1D5D790 Offset: 0x1D5C990 VA: 0x181D5D790 Slot: 5
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x1D5DF10 Offset: 0x1D5D110 VA: 0x181D5DF10 Slot: 6
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x1D5D420 Offset: 0x1D5C620 VA: 0x181D5D420 Slot: 7
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x1D5CEE0 Offset: 0x1D5C0E0 VA: 0x181D5CEE0 Slot: 4
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }

	// RVA: 0x1D5D960 Offset: 0x1D5CB60 VA: 0x181D5D960 Slot: 11
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1D5D0C0 Offset: 0x1D5C2C0 VA: 0x181D5D0C0 Slot: 13
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1D5DBD0 Offset: 0x1D5CDD0 VA: 0x181D5DBD0 Slot: 12
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1D5CD00 Offset: 0x1D5BF00 VA: 0x181D5CD00 Slot: 15
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	// RVA: 0x1D5E0C0 Offset: 0x1D5D2C0 VA: 0x181D5E0C0 Slot: 14
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	// RVA: 0x1D5D600 Offset: 0x1D5C800 VA: 0x181D5D600 Slot: 8
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x1D5DD60 Offset: 0x1D5CF60 VA: 0x181D5DD60 Slot: 9
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: 0x1D5D270 Offset: 0x1D5C470 VA: 0x181D5D270 Slot: 10
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x1D5E290 Offset: 0x1D5D490 VA: 0x181D5E290
	private static ReadOnlyCollection<Expression> GetConvertedArgs(Expression[] args) { }

	// RVA: 0x1D5E820 Offset: 0x1D5DA20 VA: 0x181D5E820
	private static Expression ReferenceArgAssign(Expression callArgs, Expression[] args) { }

	// RVA: -1 Offset: -1
	private static Expression[] BuildCallArgs<TBinder>(TBinder binder, Expression[] parameters, Expression arg0, Expression arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD3110 Offset: 0xAD2310 VA: 0x180AD3110
	|-DynamicObject.MetaDynamic.BuildCallArgs<object>
	*/

	// RVA: -1 Offset: -1
	private static ConstantExpression Constant<TBinder>(TBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD4D10 Offset: 0xAD3F10 VA: 0x180AD4D10
	|-DynamicObject.MetaDynamic.Constant<object>
	|
	|-RVA: 0xAD4C00 Offset: 0xAD3E00 VA: 0x180AD4C00
	|-DynamicObject.MetaDynamic.Constant<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodWithResult<TBinder>(MethodInfo method, TBinder binder, Expression[] args, DynamicObject.MetaDynamic.Fallback<TBinder> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD4A30 Offset: 0xAD3C30 VA: 0x180AD4A30
	|-DynamicObject.MetaDynamic.CallMethodWithResult<object>
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodWithResult<TBinder>(MethodInfo method, TBinder binder, Expression[] args, DynamicObject.MetaDynamic.Fallback<TBinder> fallback, DynamicObject.MetaDynamic.Fallback<TBinder> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD4B20 Offset: 0xAD3D20 VA: 0x180AD4B20
	|-DynamicObject.MetaDynamic.CallMethodWithResult<object>
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject BuildCallMethodWithResult<TBinder>(MethodInfo method, TBinder binder, Expression[] args, DynamicMetaObject fallbackResult, DynamicObject.MetaDynamic.Fallback<TBinder> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD34B0 Offset: 0xAD26B0 VA: 0x180AD34B0
	|-DynamicObject.MetaDynamic.BuildCallMethodWithResult<object>
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodReturnLast<TBinder>(MethodInfo method, TBinder binder, Expression[] args, Expression value, DynamicObject.MetaDynamic.Fallback<TBinder> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD4560 Offset: 0xAD3760 VA: 0x180AD4560
	|-DynamicObject.MetaDynamic.CallMethodReturnLast<object>
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodNoResult<TBinder>(MethodInfo method, TBinder binder, Expression[] args, DynamicObject.MetaDynamic.Fallback<TBinder> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD40D0 Offset: 0xAD32D0 VA: 0x180AD40D0
	|-DynamicObject.MetaDynamic.CallMethodNoResult<object>
	*/

	// RVA: 0x1D5E610 Offset: 0x1D5D810 VA: 0x181D5E610
	private bool IsOverridden(MethodInfo method) { }

	// RVA: 0x1D5E5C0 Offset: 0x1D5D7C0 VA: 0x181D5E5C0
	private BindingRestrictions GetRestrictions() { }

	// RVA: 0x1D5E480 Offset: 0x1D5D680 VA: 0x181D5E480
	private Expression GetLimitedSelf() { }

	// RVA: 0x1D5EBA0 Offset: 0x1D5DDA0 VA: 0x181D5EBA0
	private DynamicObject get_Value() { }

	// RVA: 0x1D5EA90 Offset: 0x1D5DC90 VA: 0x181D5EA90
	private static void .cctor() { }
}

// Namespace: System.Dynamic
[Serializable]
public class DynamicObject : IDynamicMetaObjectProvider // TypeDefIndex: 15277
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x1D59220 Offset: 0x1D58420 VA: 0x181D59220 Slot: 5
	public virtual bool TryGetMember(GetMemberBinder binder, out object result) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	public virtual bool TrySetMember(SetMemberBinder binder, object value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public virtual bool TryDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x10DCA20 Offset: 0x10DBC20 VA: 0x1810DCA20 Slot: 8
	public virtual bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result) { }

	// RVA: 0x1D59220 Offset: 0x1D58420 VA: 0x181D59220 Slot: 9
	public virtual bool TryConvert(ConvertBinder binder, out object result) { }

	// RVA: 0x10DCA20 Offset: 0x10DBC20 VA: 0x1810DCA20 Slot: 10
	public virtual bool TryCreateInstance(CreateInstanceBinder binder, object[] args, out object result) { }

	// RVA: 0x10DCA20 Offset: 0x10DBC20 VA: 0x1810DCA20 Slot: 11
	public virtual bool TryInvoke(InvokeBinder binder, object[] args, out object result) { }

	// RVA: 0x10DCA20 Offset: 0x10DBC20 VA: 0x1810DCA20 Slot: 12
	public virtual bool TryBinaryOperation(BinaryOperationBinder binder, object arg, out object result) { }

	// RVA: 0x1D59220 Offset: 0x1D58420 VA: 0x181D59220 Slot: 13
	public virtual bool TryUnaryOperation(UnaryOperationBinder binder, out object result) { }

	// RVA: 0x10DCA20 Offset: 0x10DBC20 VA: 0x1810DCA20 Slot: 14
	public virtual bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 15
	public virtual bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 16
	public virtual bool TryDeleteIndex(DeleteIndexBinder binder, object[] indexes) { }

	// RVA: 0x1D59110 Offset: 0x1D58310 VA: 0x181D59110 Slot: 17
	public virtual IEnumerable<string> GetDynamicMemberNames() { }

	// RVA: 0x1D59140 Offset: 0x1D58340 VA: 0x181D59140 Slot: 18
	public virtual DynamicMetaObject GetMetaObject(Expression parameter) { }
}

// Namespace: System.Dynamic
internal class ExpandoClass // TypeDefIndex: 15278
{
	// Fields
	private readonly string[] _keys; // 0x10
	private readonly int _hashCode; // 0x18
	private Dictionary<int, List<WeakReference>> _transitions; // 0x20
	internal static readonly ExpandoClass Empty; // 0x0

	// Properties
	internal string[] Keys { get; }

	// Methods

	// RVA: 0x1D59CA0 Offset: 0x1D58EA0 VA: 0x181D59CA0
	internal void .ctor() { }

	// RVA: 0x1D59C60 Offset: 0x1D58E60 VA: 0x181D59C60
	internal void .ctor(string[] keys, int hashCode) { }

	// RVA: 0x1D59330 Offset: 0x1D58530 VA: 0x181D59330
	internal ExpandoClass FindNewClass(string newKey) { }

	// RVA: 0x1D597F0 Offset: 0x1D589F0 VA: 0x181D597F0
	private List<WeakReference> GetTransitionList(int hashCode) { }

	// RVA: 0x1D59B20 Offset: 0x1D58D20 VA: 0x181D59B20
	internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj) { }

	// RVA: 0x1D59A80 Offset: 0x1D58C80 VA: 0x181D59A80
	internal int GetValueIndexCaseSensitive(string name) { }

	// RVA: 0x1D59910 Offset: 0x1D58B10 VA: 0x181D59910
	private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal string[] get_Keys() { }

	// RVA: 0x1D59BD0 Offset: 0x1D58DD0 VA: 0x181D59BD0
	private static void .cctor() { }
}

// Namespace: 
private sealed class ExpandoObject.KeyCollectionDebugView // TypeDefIndex: 15279
{}

// Namespace: 
[CompilerGenerated]
private sealed class ExpandoObject.KeyCollection.<GetEnumerator>d__15 : IEnumerator<string>, IDisposable, IEnumerator // TypeDefIndex: 15280
{
	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	public ExpandoObject.KeyCollection <>4__this; // 0x20
	private int <i>5__2; // 0x28
	private int <n>5__3; // 0x2C

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1D7C550 Offset: 0x1D7B750 VA: 0x181D7C550 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1D7C750 Offset: 0x1D7B950 VA: 0x181D7C750 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[DebuggerTypeProxy(typeof(ExpandoObject.KeyCollectionDebugView))]
[DebuggerDisplay("Count = {Count}")]
private class ExpandoObject.KeyCollection : ICollection<string>, IEnumerable<string>, IEnumerable // TypeDefIndex: 15281
{
	// Fields
	private readonly ExpandoObject _expando; // 0x10
	private readonly int _expandoVersion; // 0x18
	private readonly int _expandoCount; // 0x1C
	private readonly ExpandoObject.ExpandoData _expandoData; // 0x20

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1D71F60 Offset: 0x1D71160 VA: 0x181D71F60
	internal void .ctor(ExpandoObject expando) { }

	// RVA: 0x1D71A20 Offset: 0x1D70C20 VA: 0x181D71A20
	private void CheckVersion() { }

	// RVA: 0x1D719F0 Offset: 0x1D70BF0 VA: 0x181D719F0 Slot: 6
	public void Add(string item) { }

	// RVA: 0x1D71A90 Offset: 0x1D70C90 VA: 0x181D71A90 Slot: 7
	public void Clear() { }

	// RVA: 0x1D71AC0 Offset: 0x1D70CC0 VA: 0x181D71AC0 Slot: 8
	public bool Contains(string item) { }

	// RVA: 0x1D71BF0 Offset: 0x1D70DF0 VA: 0x181D71BF0 Slot: 9
	public void CopyTo(string[] array, int arrayIndex) { }

	// RVA: 0x1D72030 Offset: 0x1D71230 VA: 0x181D72030 Slot: 4
	public int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1D71F30 Offset: 0x1D71130 VA: 0x181D71F30 Slot: 10
	public bool Remove(string item) { }

	[IteratorStateMachine(typeof(ExpandoObject.KeyCollection.<GetEnumerator>d__15))]
	// RVA: 0x1D71ED0 Offset: 0x1D710D0 VA: 0x181D71ED0 Slot: 11
	public IEnumerator<string> GetEnumerator() { }

	// RVA: 0x1D71ED0 Offset: 0x1D710D0 VA: 0x181D71ED0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
private sealed class ExpandoObject.ValueCollectionDebugView // TypeDefIndex: 15282
{}

// Namespace: 
[CompilerGenerated]
private sealed class ExpandoObject.ValueCollection.<GetEnumerator>d__15 : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 15283
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ExpandoObject.ValueCollection <>4__this; // 0x20
	private ExpandoObject.ExpandoData <data>5__2; // 0x28
	private int <i>5__3; // 0x30

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

	// RVA: 0x1D7C3B0 Offset: 0x1D7B5B0 VA: 0x181D7C3B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1D7C710 Offset: 0x1D7B910 VA: 0x181D7C710 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[DebuggerTypeProxy(typeof(ExpandoObject.ValueCollectionDebugView))]
[DebuggerDisplay("Count = {Count}")]
private class ExpandoObject.ValueCollection : ICollection<object>, IEnumerable<object>, IEnumerable // TypeDefIndex: 15284
{
	// Fields
	private readonly ExpandoObject _expando; // 0x10
	private readonly int _expandoVersion; // 0x18
	private readonly int _expandoCount; // 0x1C
	private readonly ExpandoObject.ExpandoData _expandoData; // 0x20

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1D71F60 Offset: 0x1D71160 VA: 0x181D71F60
	internal void .ctor(ExpandoObject expando) { }

	// RVA: 0x1D7CC10 Offset: 0x1D7BE10 VA: 0x181D7CC10
	private void CheckVersion() { }

	// RVA: 0x1D7CBE0 Offset: 0x1D7BDE0 VA: 0x181D7CBE0 Slot: 6
	public void Add(object item) { }

	// RVA: 0x1D7CC80 Offset: 0x1D7BE80 VA: 0x181D7CC80 Slot: 7
	public void Clear() { }

	// RVA: 0x1D7CCB0 Offset: 0x1D7BEB0 VA: 0x181D7CCB0 Slot: 8
	public bool Contains(object item) { }

	// RVA: 0x1D7CE60 Offset: 0x1D7C060 VA: 0x181D7CE60 Slot: 9
	public void CopyTo(object[] array, int arrayIndex) { }

	// RVA: 0x1D7D200 Offset: 0x1D7C400 VA: 0x181D7D200 Slot: 4
	public int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1D7D1D0 Offset: 0x1D7C3D0 VA: 0x181D7D1D0 Slot: 10
	public bool Remove(object item) { }

	[IteratorStateMachine(typeof(ExpandoObject.ValueCollection.<GetEnumerator>d__15))]
	// RVA: 0x1D7D170 Offset: 0x1D7C370 VA: 0x181D7D170 Slot: 11
	public IEnumerator<object> GetEnumerator() { }

	// RVA: 0x1D7D170 Offset: 0x1D7C370 VA: 0x181D7D170 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExpandoObject.MetaExpando.<>c__DisplayClass3_0 // TypeDefIndex: 15285
{
	// Fields
	public InvokeMemberBinder binder; // 0x10
	public DynamicMetaObject[] args; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D7CA50 Offset: 0x1D7BC50 VA: 0x181D7CA50
	internal DynamicMetaObject <BindInvokeMember>b__0(DynamicMetaObject value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExpandoObject.MetaExpando.<GetDynamicMemberNames>d__6 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator // TypeDefIndex: 15286
{
	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public ExpandoObject.MetaExpando <>4__this; // 0x28
	private ExpandoObject.ExpandoData <expandoData>5__2; // 0x30
	private ExpandoClass <klass>5__3; // 0x38
	private int <i>5__4; // 0x40

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1D7C130 Offset: 0x1D7B330 VA: 0x181D7C130 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1D7C370 Offset: 0x1D7B570 VA: 0x181D7C370 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1D7C2D0 Offset: 0x1D7B4D0 VA: 0x181D7C2D0 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1D7C2D0 Offset: 0x1D7B4D0 VA: 0x181D7C2D0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
private class ExpandoObject.MetaExpando : DynamicMetaObject // TypeDefIndex: 15287
{
	// Properties
	public ExpandoObject Value { get; }

	// Methods

	// RVA: 0x1D74E90 Offset: 0x1D74090 VA: 0x181D74E90
	public void .ctor(Expression expression, ExpandoObject value) { }

	// RVA: 0x1D73D50 Offset: 0x1D72F50 VA: 0x181D73D50
	private DynamicMetaObject BindGetOrInvokeMember(DynamicMetaObjectBinder binder, string name, bool ignoreCase, DynamicMetaObject fallback, Func<DynamicMetaObject, DynamicMetaObject> fallbackInvoke) { }

	// RVA: 0x1D73C70 Offset: 0x1D72E70 VA: 0x181D73C70 Slot: 5
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x1D74470 Offset: 0x1D73670 VA: 0x181D74470 Slot: 11
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1D745F0 Offset: 0x1D737F0 VA: 0x181D745F0 Slot: 6
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x1D73870 Offset: 0x1D72A70 VA: 0x181D73870 Slot: 7
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	[IteratorStateMachine(typeof(ExpandoObject.MetaExpando.<GetDynamicMemberNames>d__6))]
	// RVA: 0x1D74C80 Offset: 0x1D73E80 VA: 0x181D74C80 Slot: 16
	public override IEnumerable<string> GetDynamicMemberNames() { }

	// RVA: 0x1D73570 Offset: 0x1D72770 VA: 0x181D73570
	private DynamicMetaObject AddDynamicTestAndDefer(DynamicMetaObjectBinder binder, ExpandoClass klass, ExpandoClass originalClass, DynamicMetaObject succeeds) { }

	// RVA: 0x1D74B70 Offset: 0x1D73D70 VA: 0x181D74B70
	private ExpandoClass GetClassEnsureIndex(string name, bool caseInsensitive, ExpandoObject obj, out ExpandoClass klass, out int index) { }

	// RVA: 0x1D74CF0 Offset: 0x1D73EF0 VA: 0x181D74CF0
	private Expression GetLimitedSelf() { }

	// RVA: 0x1D74E40 Offset: 0x1D74040 VA: 0x181D74E40
	private BindingRestrictions GetRestrictions() { }

	// RVA: 0x1D74F50 Offset: 0x1D74150 VA: 0x181D74F50
	public ExpandoObject get_Value() { }
}

// Namespace: 
[DefaultMember("Item")]
private class ExpandoObject.ExpandoData // TypeDefIndex: 15288
{
	// Fields
	internal static ExpandoObject.ExpandoData Empty; // 0x0
	internal readonly ExpandoClass Class; // 0x10
	private readonly object[] _dataArray; // 0x18
	private int _version; // 0x20

	// Properties
	internal object Item { get; set; }
	internal int Version { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x1654DC0 Offset: 0x1653FC0 VA: 0x181654DC0
	internal object get_Item(int index) { }

	// RVA: 0x1D6DE30 Offset: 0x1D6D030 VA: 0x181D6DE30
	internal void set_Item(int index, object value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal int get_Version() { }

	// RVA: 0xBED310 Offset: 0xBEC510 VA: 0x180BED310
	internal int get_Length() { }

	// RVA: 0x1D6DD50 Offset: 0x1D6CF50 VA: 0x181D6DD50
	private void .ctor() { }

	// RVA: 0xB18200 Offset: 0xB17400 VA: 0x180B18200
	internal void .ctor(ExpandoClass klass, object[] data, int version) { }

	// RVA: 0x1D6D9D0 Offset: 0x1D6CBD0 VA: 0x181D6D9D0
	internal ExpandoObject.ExpandoData UpdateClass(ExpandoClass newClass) { }

	// RVA: 0x1D6D9C0 Offset: 0x1D6CBC0 VA: 0x181D6D9C0
	private static int GetAlignedSize(int len) { }

	// RVA: 0x1D6DC30 Offset: 0x1D6CE30 VA: 0x181D6DC30
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExpandoObject.<GetExpandoEnumerator>d__51 : IEnumerator<KeyValuePair<string, object>>, IDisposable, IEnumerator // TypeDefIndex: 15289
{
	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, object> <>2__current; // 0x18
	public ExpandoObject <>4__this; // 0x28
	public int version; // 0x30
	public ExpandoObject.ExpandoData data; // 0x38
	private int <i>5__2; // 0x40

	// Properties
	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1D7C790 Offset: 0x1D7B990 VA: 0x181D7C790 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820 Slot: 4
	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1D7C960 Offset: 0x1D7BB60 VA: 0x181D7C960 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1D7C9A0 Offset: 0x1D7BBA0 VA: 0x181D7C9A0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: System.Dynamic
public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged // TypeDefIndex: 15290
{
	// Fields
	private static readonly MethodInfo s_expandoTryGetValue; // 0x0
	private static readonly MethodInfo s_expandoTrySetValue; // 0x8
	private static readonly MethodInfo s_expandoTryDeleteValue; // 0x10
	private static readonly MethodInfo s_expandoPromoteClass; // 0x18
	private static readonly MethodInfo s_expandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
	private ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.Values { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; set; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x1D6FBD0 Offset: 0x1D6EDD0 VA: 0x181D6FBD0
	public void .ctor() { }

	// RVA: 0x1D6F4C0 Offset: 0x1D6E6C0 VA: 0x181D6F4C0
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x1D6F600 Offset: 0x1D6E800 VA: 0x181D6F600
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x1D6F050 Offset: 0x1D6E250 VA: 0x181D6F050
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x1D6DF50 Offset: 0x1D6D150 VA: 0x181D6DF50
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x18A59A0 Offset: 0x18A4BA0 VA: 0x1818A59A0
	internal ExpandoClass get_Class() { }

	// RVA: 0x1D6DFF0 Offset: 0x1D6D1F0 VA: 0x181D6DFF0
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x1D6E030 Offset: 0x1D6D230 VA: 0x181D6E030
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x1D6EF70 Offset: 0x1D6E170 VA: 0x181D6EF70 Slot: 4
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0x1D6E910 Offset: 0x1D6DB10 VA: 0x181D6E910
	private void TryAddMember(string key, object value) { }

	// RVA: 0x1D6F3B0 Offset: 0x1D6E5B0 VA: 0x181D6F3B0
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x1D6DEA0 Offset: 0x1D6D0A0 VA: 0x181D6DEA0
	private bool ExpandoContainsKey(string key) { }

	// RVA: 0x1D6EC70 Offset: 0x1D6DE70 VA: 0x181D6EC70 Slot: 7
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	// RVA: 0x1D6ECD0 Offset: 0x1D6DED0 VA: 0x181D6ECD0 Slot: 8
	private ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values() { }

	// RVA: 0x1D6EC10 Offset: 0x1D6DE10 VA: 0x181D6EC10 Slot: 5
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x1D6ED30 Offset: 0x1D6DF30 VA: 0x181D6ED30 Slot: 6
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(string key, object value) { }

	// RVA: 0x1D6E910 Offset: 0x1D6DB10 VA: 0x181D6E910 Slot: 10
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x1D6E9E0 Offset: 0x1D6DBE0 VA: 0x181D6E9E0 Slot: 9
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x1D6EB10 Offset: 0x1D6DD10 VA: 0x181D6EB10 Slot: 11
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(string key) { }

	// RVA: 0x1D6EC00 Offset: 0x1D6DE00 VA: 0x181D6EC00 Slot: 12
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 13
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 14
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x1D6E1D0 Offset: 0x1D6D3D0 VA: 0x181D6E1D0 Slot: 15
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x1D6E2C0 Offset: 0x1D6D4C0 VA: 0x181D6E2C0 Slot: 16
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x1D6E510 Offset: 0x1D6D710 VA: 0x181D6E510 Slot: 17
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x1D6E590 Offset: 0x1D6D790 VA: 0x181D6E590 Slot: 18
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x1D6E8A0 Offset: 0x1D6DAA0 VA: 0x181D6E8A0 Slot: 19
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x1D6EE00 Offset: 0x1D6E000 VA: 0x181D6EE00 Slot: 20
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x1D6EE00 Offset: 0x1D6E000 VA: 0x181D6EE00 Slot: 21
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachine(typeof(ExpandoObject.<GetExpandoEnumerator>d__51))]
	// RVA: 0x1D6DED0 Offset: 0x1D6D0D0 VA: 0x181D6DED0
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x1D6EE30 Offset: 0x1D6E030 VA: 0x181D6EE30 Slot: 22
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x1D6EED0 Offset: 0x1D6E0D0 VA: 0x181D6EED0 Slot: 23
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x1D6F9D0 Offset: 0x1D6EBD0 VA: 0x181D6F9D0
	private static void .cctor() { }
}

// Namespace: System.Dynamic
public abstract class GetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 15291
{
	// Methods

	// RVA: 0x1D71520 Offset: 0x1D70720 VA: 0x181D71520 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1D50E60 Offset: 0x1D50060 VA: 0x181D50E60
	public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class GetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15292
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public sealed override Type ReturnType { get; }
	public string Name { get; }
	public bool IgnoreCase { get; }
	internal sealed override bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x1D71700 Offset: 0x1D70900 VA: 0x181D71700
	protected void .ctor(string name, bool ignoreCase) { }

	// RVA: 0x1D717B0 Offset: 0x1D709B0 VA: 0x181D717B0 Slot: 6
	public sealed override Type get_ReturnType() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IgnoreCase() { }

	// RVA: 0x156A970 Offset: 0x1569B70 VA: 0x18156A970
	public DynamicMetaObject FallbackGetMember(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1D71610 Offset: 0x1D70810 VA: 0x181D71610 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	internal sealed override bool get_IsStandardBinder() { }
}

// Namespace: System.Dynamic
public interface IDynamicMetaObjectProvider // TypeDefIndex: 15293
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DynamicMetaObject GetMetaObject(Expression parameter);
}

// Namespace: System.Dynamic
public abstract class InvokeBinder : DynamicMetaObjectBinder // TypeDefIndex: 15294
{
	// Methods

	// RVA: 0x1D50E60 Offset: 0x1D50060 VA: 0x181D50E60
	public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: 0x1D71810 Offset: 0x1D70A10 VA: 0x181D71810 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public abstract class InvokeMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15295
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public string Name { get; }
	public bool IgnoreCase { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IgnoreCase() { }

	// RVA: 0x1D71900 Offset: 0x1D70B00 VA: 0x181D71900 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1D50E60 Offset: 0x1D50060 VA: 0x181D50E60
	public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class SetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 15296
{
	// Methods

	// RVA: 0x1D76ED0 Offset: 0x1D760D0 VA: 0x181D76ED0 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1D770D0 Offset: 0x1D762D0 VA: 0x181D770D0
	public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class SetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15297
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public sealed override Type ReturnType { get; }
	public string Name { get; }
	public bool IgnoreCase { get; }
	internal sealed override bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x1D77290 Offset: 0x1D76490 VA: 0x181D77290
	protected void .ctor(string name, bool ignoreCase) { }

	// RVA: 0x1D77340 Offset: 0x1D76540 VA: 0x181D77340 Slot: 6
	public sealed override Type get_ReturnType() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IgnoreCase() { }

	// RVA: 0x1D77100 Offset: 0x1D76300 VA: 0x181D77100 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	internal sealed override bool get_IsStandardBinder() { }

	// RVA: 0x1D50E60 Offset: 0x1D50060 VA: 0x181D50E60
	public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class UnaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 15298
{
	// Methods

	// RVA: 0x156A970 Offset: 0x1569B70 VA: 0x18156A970
	public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1D7CAF0 Offset: 0x1D7BCF0 VA: 0x181D7CAF0 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: 
private sealed class CacheDict.Entry<TKey, TValue> // TypeDefIndex: 15299
{
	// Fields
	internal readonly int _hash; // 0x0
	internal readonly TKey _key; // 0x0
	internal readonly TValue _value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int hash, TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DDCC0 Offset: 0x10DCEC0 VA: 0x1810DDCC0
	|-CacheDict.Entry<object, object>..ctor
	|
	|-RVA: 0x10DDD10 Offset: 0x10DCF10 VA: 0x1810DDD10
	|-CacheDict.Entry<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Dynamic.Utils
[DefaultMember("Item")]
internal sealed class CacheDict<TKey, TValue> // TypeDefIndex: 15300
{
	// Fields
	private readonly int _mask; // 0x0
	private readonly CacheDict.Entry<TKey, TValue>[] _entries; // 0x0

	// Properties
	internal TKey Item { set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFA0A0 Offset: 0xEF92A0 VA: 0x180EFA0A0
	|-CacheDict<object, object>..ctor
	|
	|-RVA: 0xEFA130 Offset: 0xEF9330 VA: 0x180EFA130
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static int AlignSize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF9BB0 Offset: 0xEF8DB0 VA: 0x180EF9BB0
	|-CacheDict<object, object>.AlignSize
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AlignSize
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF9BE0 Offset: 0xEF8DE0 VA: 0x180EF9BE0
	|-CacheDict<object, object>.TryGetValue
	|
	|-RVA: 0xEF9CA0 Offset: 0xEF8EA0 VA: 0x180EF9CA0
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	internal void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF9A70 Offset: 0xEF8C70 VA: 0x180EF9A70
	|-CacheDict<object, object>.Add
	|
	|-RVA: 0xEF9590 Offset: 0xEF8790 VA: 0x180EF9590
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	internal void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFA1B0 Offset: 0xEF93B0 VA: 0x180EFA1B0
	|-CacheDict<object, object>.set_Item
	|
	|-RVA: 0xEFA300 Offset: 0xEF9500 VA: 0x180EFA300
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class CollectionExtensions // TypeDefIndex: 15301
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static TrueReadOnlyCollection<T> AddFirst<T>(ReadOnlyCollection<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x946F00 Offset: 0x946100 VA: 0x180946F00
	|-CollectionExtensions.AddFirst<object>
	|
	|-RVA: 0x946D70 Offset: 0x945F70 VA: 0x180946D70
	|-CollectionExtensions.AddFirst<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] AddLast<T>(T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x947140 Offset: 0x946340 VA: 0x180947140
	|-CollectionExtensions.AddLast<object>
	|
	|-RVA: 0x947000 Offset: 0x946200 VA: 0x180947000
	|-CollectionExtensions.AddLast<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] RemoveFirst<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x947980 Offset: 0x946B80 VA: 0x180947980
	|-CollectionExtensions.RemoveFirst<object>
	|-CollectionExtensions.RemoveFirst<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] RemoveLast<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x947A20 Offset: 0x946C20 VA: 0x180947A20
	|-CollectionExtensions.RemoveLast<object>
	|-CollectionExtensions.RemoveLast<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ToReadOnly<T>(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x947DE0 Offset: 0x946FE0 VA: 0x180947DE0
	|-CollectionExtensions.ToReadOnly<object>
	|
	|-RVA: 0x947C10 Offset: 0x946E10 VA: 0x180947C10
	|-CollectionExtensions.ToReadOnly<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Dynamic.Utils
internal static class ContractUtils // TypeDefIndex: 15302
{
	// Properties
	[ExcludeFromCodeCoverage]
	public static Exception Unreachable { get; }

	// Methods

	// RVA: 0x1D6D960 Offset: 0x1D6CB60 VA: 0x181D6D960
	public static Exception get_Unreachable() { }

	// RVA: 0x1D6D920 Offset: 0x1D6CB20 VA: 0x181D6D920
	public static void Requires(bool precondition, string paramName) { }

	// RVA: 0x1D6D8C0 Offset: 0x1D6CAC0 VA: 0x181D6D8C0
	public static void RequiresNotNull(object value, string paramName) { }

	// RVA: 0x1D6D840 Offset: 0x1D6CA40 VA: 0x181D6D840
	public static void RequiresNotNull(object value, string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresNotEmpty<T>(ICollection<T> collection, string paramName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94EAE0 Offset: 0x94DCE0 VA: 0x18094EAE0
	|-ContractUtils.RequiresNotEmpty<object>
	|-ContractUtils.RequiresNotEmpty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void RequiresNotNullItems<T>(IList<T> array, string arrayName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94ED50 Offset: 0x94DF50 VA: 0x18094ED50
	|-ContractUtils.RequiresNotNullItems<object>
	|
	|-RVA: 0x94EB70 Offset: 0x94DD70 VA: 0x18094EB70
	|-ContractUtils.RequiresNotNullItems<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D6D7C0 Offset: 0x1D6C9C0 VA: 0x181D6D7C0
	private static string GetParamName(string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E9E0 Offset: 0x94DBE0 VA: 0x18094E9E0
	|-ContractUtils.RequiresArrayRange<KeyValuePair<object, object>>
	|-ContractUtils.RequiresArrayRange<object>
	|-ContractUtils.RequiresArrayRange<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Dynamic.Utils
internal static class EmptyReadOnlyCollection<T> // TypeDefIndex: 15303
{
	// Fields
	public static readonly ReadOnlyCollection<T> Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DD930 Offset: 0x10DCB30 VA: 0x1810DD930
	|-EmptyReadOnlyCollection<object>..cctor
	|
	|-RVA: 0x10DDAA0 Offset: 0x10DCCA0 VA: 0x1810DDAA0
	|-EmptyReadOnlyCollection<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class ExpressionUtils // TypeDefIndex: 15304
{
	// Methods

	// RVA: 0x1D6FFB0 Offset: 0x1D6F1B0 VA: 0x181D6FFB0
	public static ReadOnlyCollection<ParameterExpression> ReturnReadOnly(IParameterProvider provider, ref object collection) { }

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A5360 Offset: 0x9A4560 VA: 0x1809A5360
	|-ExpressionUtils.ReturnReadOnly<object>
	|
	|-RVA: 0x9A5230 Offset: 0x9A4430 VA: 0x1809A5230
	|-ExpressionUtils.ReturnReadOnly<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D70140 Offset: 0x1D6F340 VA: 0x181D70140
	public static ReadOnlyCollection<Expression> ReturnReadOnly(IArgumentProvider provider, ref object collection) { }

	// RVA: -1 Offset: -1
	public static T ReturnObject<T>(object collectionOrT) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A50A0 Offset: 0x9A42A0 VA: 0x1809A50A0
	|-ExpressionUtils.ReturnObject<object>
	*/

	// RVA: 0x1D70600 Offset: 0x1D6F800 VA: 0x181D70600
	public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x1D70520 Offset: 0x1D6F720 VA: 0x181D70520
	public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x1D70A30 Offset: 0x1D6FC30 VA: 0x181D70A30
	public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1) { }

	// RVA: 0x1D6FCF0 Offset: 0x1D6EEF0 VA: 0x181D6FCF0
	public static void RequiresCanRead(Expression expression, string paramName) { }

	// RVA: 0x1D6FD00 Offset: 0x1D6EF00 VA: 0x181D6FD00
	public static void RequiresCanRead(Expression expression, string paramName, int idx) { }

	// RVA: 0x1D702D0 Offset: 0x1D6F4D0 VA: 0x181D702D0
	public static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x1D6FC70 Offset: 0x1D6EE70 VA: 0x181D6FC70
	internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: -1 Offset: -1
	internal static bool SameElements<T>(ICollection<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A56B0 Offset: 0x9A48B0 VA: 0x1809A56B0
	|-ExpressionUtils.SameElements<object>
	*/

	// RVA: -1 Offset: -1
	internal static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A5760 Offset: 0x9A4960 VA: 0x1809A5760
	|-ExpressionUtils.SameElements<object>
	*/

	// RVA: -1 Offset: -1
	private static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A5490 Offset: 0x9A4690 VA: 0x1809A5490
	|-ExpressionUtils.SameElementsInCollection<object>
	*/

	[Extension]
	// RVA: 0x1D704A0 Offset: 0x1D6F6A0 VA: 0x181D704A0
	public static void ValidateArgumentCount(LambdaExpression lambda) { }
}

// Namespace: System.Dynamic.Utils
internal static class ExpressionVisitorUtils // TypeDefIndex: 15305
{
	// Methods

	// RVA: 0x1D71060 Offset: 0x1D70260 VA: 0x181D71060
	public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block) { }

	// RVA: 0x1D712B0 Offset: 0x1D704B0 VA: 0x181D712B0
	public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName) { }

	// RVA: 0x1D70E10 Offset: 0x1D70010 VA: 0x181D70E10
	public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ListProvider.<GetEnumerator>d__20<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 15306
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public ListProvider<T> <>4__this; // 0x0
	private int <i>5__2; // 0x0
	private int <n>5__3; // 0x0

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
	|-ListProvider.<GetEnumerator>d__20<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ListProvider.<GetEnumerator>d__20<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB22220 Offset: 0xB21420 VA: 0x180B22220
	|-ListProvider.<GetEnumerator>d__20<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-ListProvider.<GetEnumerator>d__20<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ListProvider.<GetEnumerator>d__20<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-ListProvider.<GetEnumerator>d__20<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Dynamic.Utils
[DefaultMember("Item")]
internal abstract class ListProvider<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 15307
{
	// Properties
	protected abstract T First { get; }
	protected abstract int ElementCount { get; }
	public T Item { get; set; }
	public int Count { get; }
	[ExcludeFromCodeCoverage]
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract T get_First();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ListProvider<object>.get_First
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract int get_ElementCount();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ListProvider<object>.get_ElementCount
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract T GetElement(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ListProvider<object>.GetElement
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132CCD0 Offset: 0x132BED0 VA: 0x18132CCD0
	|-ListProvider<object>.IndexOf
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F29B0 Offset: 0x11F1BB0 VA: 0x1811F29B0
	|-ListProvider<object>.Insert
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F29D0 Offset: 0x11F1BD0 VA: 0x1811F29D0
	|-ListProvider<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132CE30 Offset: 0x132C030 VA: 0x18132CE30
	|-ListProvider<object>.get_Item
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F29B0 Offset: 0x11F1BB0 VA: 0x1811F29B0
	|-ListProvider<object>.set_Item
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F29D0 Offset: 0x11F1BD0 VA: 0x1811F29D0
	|-ListProvider<object>.Add
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132CA80 Offset: 0x132BC80 VA: 0x18132CA80
	|-ListProvider<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132CAA0 Offset: 0x132BCA0 VA: 0x18132CAA0
	|-ListProvider<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132CB50 Offset: 0x132BD50 VA: 0x18132CB50
	|-ListProvider<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132CE10 Offset: 0x132C010 VA: 0x18132CE10
	|-ListProvider<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ListProvider<object>.get_IsReadOnly
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F29D0 Offset: 0x11F1BD0 VA: 0x1811F29D0
	|-ListProvider<object>.Remove
	*/

	[IteratorStateMachine(typeof(ListProvider.<GetEnumerator>d__20<T>))]
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBF6E0 Offset: 0xFBE8E0 VA: 0x180FBF6E0
	|-ListProvider<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132CD80 Offset: 0x132BF80 VA: 0x18132CD80
	|-ListProvider<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ListProvider<object>..ctor
	*/
}

// Namespace: System.Dynamic.Utils
internal sealed class ListArgumentProvider : ListProvider<Expression> // TypeDefIndex: 15308
{
	// Fields
	private readonly IArgumentProvider _provider; // 0x10
	private readonly Expression _arg0; // 0x18

	// Properties
	protected override Expression First { get; }
	protected override int ElementCount { get; }

	// Methods

	// RVA: 0x1D72100 Offset: 0x1D71300 VA: 0x181D72100
	internal void .ctor(IArgumentProvider provider, Expression arg0) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 18
	protected override Expression get_First() { }

	// RVA: 0x1D72160 Offset: 0x1D71360 VA: 0x181D72160 Slot: 19
	protected override int get_ElementCount() { }

	// RVA: 0x1D720A0 Offset: 0x1D712A0 VA: 0x181D720A0 Slot: 20
	protected override Expression GetElement(int index) { }
}

// Namespace: System.Dynamic.Utils
internal sealed class ListParameterProvider : ListProvider<ParameterExpression> // TypeDefIndex: 15309
{
	// Fields
	private readonly IParameterProvider _provider; // 0x10
	private readonly ParameterExpression _arg0; // 0x18

	// Properties
	protected override ParameterExpression First { get; }
	protected override int ElementCount { get; }

	// Methods

	// RVA: 0x1D72210 Offset: 0x1D71410 VA: 0x181D72210
	internal void .ctor(IParameterProvider provider, ParameterExpression arg0) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 18
	protected override ParameterExpression get_First() { }

	// RVA: 0x1D72270 Offset: 0x1D71470 VA: 0x181D72270 Slot: 19
	protected override int get_ElementCount() { }

	// RVA: 0x1D721B0 Offset: 0x1D713B0 VA: 0x181D721B0 Slot: 20
	protected override ParameterExpression GetElement(int index) { }
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class TypeExtensions // TypeDefIndex: 15310
{
	// Fields
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; // 0x0

	// Methods

	[Extension]
	// RVA: 0x1D774F0 Offset: 0x1D766F0 VA: 0x181D774F0
	public static MethodInfo GetAnyStaticMethodValidated(Type type, string name, Type[] types) { }

	[Extension]
	// RVA: 0x1D77940 Offset: 0x1D76B40 VA: 0x181D77940
	private static bool MatchesArgumentTypes(MethodInfo mi, Type[] argTypes) { }

	[Extension]
	// RVA: 0x1D777E0 Offset: 0x1D769E0 VA: 0x181D777E0
	public static Type GetReturnType(MethodBase mi) { }

	[Extension]
	// RVA: 0x1D778F0 Offset: 0x1D76AF0 VA: 0x181D778F0
	public static TypeCode GetTypeCode(Type type) { }

	[Extension]
	// RVA: 0x1D776C0 Offset: 0x1D768C0 VA: 0x181D776C0
	internal static ParameterInfo[] GetParametersCached(MethodBase method) { }

	// RVA: 0x1D77AB0 Offset: 0x1D76CB0 VA: 0x181D77AB0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeUtils.<>c // TypeDefIndex: 15311
{
	// Fields
	public static readonly TypeUtils.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1D7CA90 Offset: 0x1D7BC90 VA: 0x181D7CA90
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1D7C9F0 Offset: 0x1D7BBF0 VA: 0x181D7C9F0
	internal bool <.cctor>b__44_0(Type i) { }

	// RVA: 0x1D7CA20 Offset: 0x1D7BC20 VA: 0x181D7CA20
	internal Type <.cctor>b__44_1(Type i) { }
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class TypeUtils // TypeDefIndex: 15312
{
	// Fields
	private static readonly Type[] s_arrayAssignableInterfaces; // 0x0

	// Methods

	[Extension]
	// RVA: 0x1D78520 Offset: 0x1D77720 VA: 0x181D78520
	public static Type GetNonNullableType(Type type) { }

	[Extension]
	// RVA: 0x1D78600 Offset: 0x1D77800 VA: 0x181D78600
	public static Type GetNullableType(Type type) { }

	[Extension]
	// RVA: 0x1D7AF50 Offset: 0x1D7A150 VA: 0x181D7AF50
	public static bool IsNullableType(Type type) { }

	[Extension]
	// RVA: 0x1D7AEE0 Offset: 0x1D7A0E0 VA: 0x181D7AEE0
	public static bool IsNullableOrReferenceType(Type type) { }

	[Extension]
	// RVA: 0x1D799C0 Offset: 0x1D78BC0 VA: 0x181D799C0
	public static bool IsBool(Type type) { }

	[Extension]
	// RVA: 0x1D7B180 Offset: 0x1D7A380 VA: 0x181D7B180
	public static bool IsNumeric(Type type) { }

	[Extension]
	// RVA: 0x1D7A8D0 Offset: 0x1D79AD0 VA: 0x181D7A8D0
	public static bool IsInteger(Type type) { }

	[Extension]
	// RVA: 0x1D79860 Offset: 0x1D78A60 VA: 0x181D79860
	public static bool IsArithmetic(Type type) { }

	[Extension]
	// RVA: 0x1D7B3D0 Offset: 0x1D7A5D0 VA: 0x181D7B3D0
	public static bool IsUnsignedInt(Type type) { }

	[Extension]
	// RVA: 0x1D7A770 Offset: 0x1D79970 VA: 0x181D7A770
	public static bool IsIntegerOrBool(Type type) { }

	[Extension]
	// RVA: 0x1D7B010 Offset: 0x1D7A210 VA: 0x181D7B010
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x1D7B540 Offset: 0x1D7A740 VA: 0x181D7B540
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[Extension]
	// RVA: 0x1D78F80 Offset: 0x1D78180 VA: 0x181D78F80
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[Extension]
	// RVA: 0x1D79550 Offset: 0x1D78750 VA: 0x181D79550
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	[Extension]
	// RVA: 0x1D7B8F0 Offset: 0x1D7AAF0 VA: 0x181D7B8F0
	private static bool StrictHasReferenceConversionTo(Type source, Type dest, bool skipNonArray) { }

	// RVA: 0x1D78AF0 Offset: 0x1D77CF0 VA: 0x181D78AF0
	private static bool HasArrayToInterfaceConversion(Type source, Type dest) { }

	// RVA: 0x1D79310 Offset: 0x1D78510 VA: 0x181D79310
	private static bool HasInterfaceToArrayConversion(Type source, Type dest) { }

	// RVA: 0x1D79C60 Offset: 0x1D78E60 VA: 0x181D79C60
	private static bool IsCovariant(Type t) { }

	// RVA: 0x1D79AD0 Offset: 0x1D78CD0 VA: 0x181D79AD0
	private static bool IsContravariant(Type t) { }

	// RVA: 0x1D7AA30 Offset: 0x1D79C30 VA: 0x181D7AA30
	private static bool IsInvariant(Type t) { }

	// RVA: 0x1D79C90 Offset: 0x1D78E90 VA: 0x181D79C90
	private static bool IsDelegate(Type t) { }

	// RVA: 0x1D7AA60 Offset: 0x1D79C60 VA: 0x181D7AA60
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[Extension]
	// RVA: 0x1D79B00 Offset: 0x1D78D00 VA: 0x181D79B00
	public static bool IsConvertible(Type type) { }

	// RVA: 0x1D79770 Offset: 0x1D78970 VA: 0x181D79770
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x1D78D30 Offset: 0x1D77F30 VA: 0x181D78D30
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[Extension]
	// RVA: 0x1D7A200 Offset: 0x1D79400 VA: 0x181D7A200
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x1D78760 Offset: 0x1D77960 VA: 0x181D78760
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x1D77CE0 Offset: 0x1D76EE0 VA: 0x181D77CE0
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x1D7A010 Offset: 0x1D79210 VA: 0x181D7A010
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x19D4930 Offset: 0x19D3B30 VA: 0x1819D4930
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x1D79D20 Offset: 0x1D78F20 VA: 0x181D79D20
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x1D79E90 Offset: 0x1D79090 VA: 0x181D79E90
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x1D77EC0 Offset: 0x1D770C0 VA: 0x181D77EC0
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x1D781E0 Offset: 0x1D773E0 VA: 0x181D781E0
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[Extension]
	// RVA: 0x1D785B0 Offset: 0x1D777B0 VA: 0x181D785B0
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x1D77B30 Offset: 0x1D76D30 VA: 0x181D77B30
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x1D77BC0 Offset: 0x1D76DC0 VA: 0x181D77BC0
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x1D7B2E0 Offset: 0x1D7A4E0 VA: 0x181D7B2E0
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x1D7BDE0 Offset: 0x1D7AFE0 VA: 0x181D7BDE0
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x1D7BC10 Offset: 0x1D7AE10 VA: 0x181D7BC10
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x1D7BE50 Offset: 0x1D7B050 VA: 0x181D7BE50
	public static bool ValidateType(Type type, string paramName, int index) { }

	[Extension]
	// RVA: 0x1D784D0 Offset: 0x1D776D0 VA: 0x181D784D0
	public static MethodInfo GetInvokeMethod(Type delegateType) { }

	// RVA: 0x1D7BF60 Offset: 0x1D7B160 VA: 0x181D7BF60
	private static void .cctor() { }
}

// Namespace: System.IO
[Serializable]
public enum HandleInheritability // TypeDefIndex: 15313
{
	// Fields
	public int value__; // 0x0
	public const HandleInheritability None = 0;
	public const HandleInheritability Inheritable = 1;
}

// Namespace: System.IO.MemoryMappedFiles
[Serializable]
public enum MemoryMappedFileAccess // TypeDefIndex: 15314
{
	// Fields
	public int value__; // 0x0
	public const MemoryMappedFileAccess ReadWrite = 0;
	public const MemoryMappedFileAccess Read = 1;
	public const MemoryMappedFileAccess Write = 2;
	public const MemoryMappedFileAccess CopyOnWrite = 3;
	public const MemoryMappedFileAccess ReadExecute = 4;
	public const MemoryMappedFileAccess ReadWriteExecute = 5;
}

// Namespace: System.IO.MemoryMappedFiles
[Flags]
[Serializable]
public enum MemoryMappedFileOptions // TypeDefIndex: 15315
{
	// Fields
	public int value__; // 0x0
	public const MemoryMappedFileOptions None = 0;
	public const MemoryMappedFileOptions DelayAllocatePages = 67108864;
}

// Namespace: System.IO.MemoryMappedFiles
public sealed class MemoryMappedViewAccessor : UnmanagedMemoryAccessor // TypeDefIndex: 15316
{
	// Fields
	private MemoryMappedView m_view; // 0x30

	// Properties
	public SafeMemoryMappedViewHandle SafeMemoryMappedViewHandle { get; }
	public long PointerOffset { get; }

	// Methods

	// RVA: 0x1D73170 Offset: 0x1D72370 VA: 0x181D73170
	internal void .ctor(MemoryMappedView view) { }

	// RVA: 0x1D732D0 Offset: 0x1D724D0 VA: 0x181D732D0
	public SafeMemoryMappedViewHandle get_SafeMemoryMappedViewHandle() { }

	// RVA: 0x1D73240 Offset: 0x1D72440 VA: 0x181D73240
	public long get_PointerOffset() { }

	// RVA: 0x1D72F80 Offset: 0x1D72180 VA: 0x181D72F80 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1D730B0 Offset: 0x1D722B0 VA: 0x181D730B0
	public void Flush() { }
}

// Namespace: System.IO.MemoryMappedFiles
internal static class MemoryMapImpl // TypeDefIndex: 15317
{
	// Methods

	// RVA: 0x1D72760 Offset: 0x1D71960 VA: 0x181D72760
	private static IntPtr OpenHandleInternal(IntPtr handle, char* mapName, int mapName_length, out long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, out int error) { }

	// RVA: 0x1D72340 Offset: 0x1D71540 VA: 0x181D72340
	internal static void CloseMapping(IntPtr handle) { }

	// RVA: 0x1D726E0 Offset: 0x1D718E0 VA: 0x181D726E0
	internal static void Flush(IntPtr file_handle) { }

	// RVA: 0x1D72350 Offset: 0x1D71550 VA: 0x181D72350
	internal static void ConfigureHandleInheritability(IntPtr handle, HandleInheritability inheritability) { }

	// RVA: 0x1D728C0 Offset: 0x1D71AC0 VA: 0x181D728C0
	internal static bool Unmap(IntPtr mmap_handle) { }

	// RVA: 0x1D726F0 Offset: 0x1D718F0 VA: 0x181D726F0
	private static int MapInternal(IntPtr handle, long offset, ref long size, MemoryMappedFileAccess access, out IntPtr mmap_handle, out IntPtr base_address) { }

	// RVA: 0x1D72700 Offset: 0x1D71900 VA: 0x181D72700
	internal static void Map(IntPtr handle, long offset, ref long size, MemoryMappedFileAccess access, out IntPtr mmap_handle, out IntPtr base_address) { }

	// RVA: 0x1D72360 Offset: 0x1D71560 VA: 0x181D72360
	private static Exception CreateException(int error, string path) { }

	// RVA: 0x1D728B0 Offset: 0x1D71AB0 VA: 0x181D728B0
	private static int StringLength(string a) { }

	// RVA: 0x1D722C0 Offset: 0x1D714C0 VA: 0x181D722C0
	private static void CheckString(string name, string value) { }

	// RVA: 0x1D72770 Offset: 0x1D71970 VA: 0x181D72770
	internal static IntPtr OpenHandle(IntPtr handle, string mapName, out long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options) { }
}

// Namespace: System.IO.MemoryMappedFiles
public class MemoryMappedFile : IDisposable // TypeDefIndex: 15318
{
	// Fields
	private FileStream stream; // 0x10
	private bool keepOpen; // 0x18
	private SafeMemoryMappedFileHandle handle; // 0x20

	// Methods

	// RVA: 0x1D728D0 Offset: 0x1D71AD0 VA: 0x181D728D0
	public static MemoryMappedFile CreateFromFile(FileStream fileStream, string mapName, long capacity, MemoryMappedFileAccess access, HandleInheritability inheritability, bool leaveOpen) { }

	// RVA: 0x1D72C50 Offset: 0x1D71E50 VA: 0x181D72C50
	public MemoryMappedViewAccessor CreateViewAccessor(long offset, long size, MemoryMappedFileAccess access) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1744B80 Offset: 0x1743D80 VA: 0x181744B80 Slot: 4
	public void Dispose() { }

	// RVA: 0x1D72E80 Offset: 0x1D72080 VA: 0x181D72E80 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1D72EE0 Offset: 0x1D720E0 VA: 0x181D72EE0
	internal static FileAccess GetFileAccess(MemoryMappedFileAccess access) { }
}

// Namespace: System.IO.MemoryMappedFiles
internal class MemoryMappedView : IDisposable // TypeDefIndex: 15319
{
	// Fields
	private SafeMemoryMappedViewHandle m_viewHandle; // 0x10
	private long m_pointerOffset; // 0x18
	private long m_size; // 0x20
	private MemoryMappedFileAccess m_access; // 0x28

	// Properties
	internal SafeMemoryMappedViewHandle ViewHandle { get; }
	internal long PointerOffset { get; }
	internal long Size { get; }
	internal MemoryMappedFileAccess Access { get; }
	internal bool IsClosed { get; }

	// Methods

	// RVA: 0x1D73500 Offset: 0x1D72700 VA: 0x181D73500
	private void .ctor(SafeMemoryMappedViewHandle viewHandle, long pointerOffset, long size, MemoryMappedFileAccess access) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal SafeMemoryMappedViewHandle get_ViewHandle() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal long get_PointerOffset() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal long get_Size() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	internal MemoryMappedFileAccess get_Access() { }

	// RVA: 0x1D732F0 Offset: 0x1D724F0 VA: 0x181D732F0
	internal static MemoryMappedView Create(IntPtr handle, long offset, long size, MemoryMappedFileAccess access) { }

	// RVA: 0x1D734E0 Offset: 0x1D726E0 VA: 0x181D734E0
	public void Flush(IntPtr capacity) { }

	// RVA: 0x1D73430 Offset: 0x1D72630 VA: 0x181D73430 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1D73470 Offset: 0x1D72670 VA: 0x181D73470 Slot: 4
	public void Dispose() { }

	// RVA: 0x1D73550 Offset: 0x1D72750 VA: 0x181D73550
	internal bool get_IsClosed() { }
}

// Namespace: System.Collections.Generic
[DefaultMember("Item")]
internal struct ArrayBuilder<T> // TypeDefIndex: 15320
{
	// Fields
	private T[] _array; // 0x0
	private int _count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A84F0 Offset: 0x12A76F0 VA: 0x1812A84F0
	|-ArrayBuilder<object>..ctor
	|-ArrayBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8000 Offset: 0x12A7200 VA: 0x1812A8000
	|-ArrayBuilder<object>.ToArray
	|
	|-RVA: 0x12A8130 Offset: 0x12A7330 VA: 0x1812A8130
	|-ArrayBuilder<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void UncheckedAdd(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8230 Offset: 0x12A7430 VA: 0x1812A8230
	|-ArrayBuilder<object>.UncheckedAdd
	|
	|-RVA: 0x12A8270 Offset: 0x12A7470 VA: 0x1812A8270
	|-ArrayBuilder<__Il2CppFullySharedGenericType>.UncheckedAdd
	*/
}

// Namespace: System.Collections.Generic
internal sealed class BitHelper // TypeDefIndex: 15321
{
	// Fields
	private readonly int _length; // 0x10
	private readonly int* _arrayPtr; // 0x18
	private readonly int[] _array; // 0x20
	private readonly bool _useStackAlloc; // 0x28

	// Methods

	// RVA: 0x1D6D740 Offset: 0x1D6C940 VA: 0x181D6D740
	internal void .ctor(int* bitArrayPtr, int length) { }

	// RVA: 0x1D6D780 Offset: 0x1D6C980 VA: 0x181D6D780
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x1D6D6B0 Offset: 0x1D6C8B0 VA: 0x181D6D6B0
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x1D6D630 Offset: 0x1D6C830 VA: 0x181D6D630
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x1D6D720 Offset: 0x1D6C920 VA: 0x181D6D720
	internal static int ToIntArrayLength(int n) { }
}

// Namespace: 
internal struct HashSet.ElementCount<T> // TypeDefIndex: 15322
{
	// Fields
	internal int uniqueCount; // 0x0
	internal int unfoundCount; // 0x0
}

// Namespace: 
internal struct HashSet.Slot<T> // TypeDefIndex: 15323
{
	// Fields
	internal int hashCode; // 0x0
	internal int next; // 0x0
	internal T value; // 0x0
}

// Namespace: 
[Serializable]
public struct HashSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 15324
{
	// Fields
	private HashSet<T> _set; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(HashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EB730 Offset: 0x10EA930 VA: 0x1810EB730
	|-HashSet.Enumerator<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x10EBA20 Offset: 0x10EAC20 VA: 0x1810EBA20
	|-HashSet.Enumerator<byte>..ctor
	|
	|-RVA: 0x10EB6D0 Offset: 0x10EA8D0 VA: 0x1810EB6D0
	|-HashSet.Enumerator<char>..ctor
	|-HashSet.Enumerator<ushort>..ctor
	|-HashSet.Enumerator<UInt16Enum>..ctor
	|-HashSet.Enumerator<HeliSabotageSystem.ActiveConsoleData>..ctor
	|
	|-RVA: 0xE6A870 Offset: 0xE69A70 VA: 0x180E6A870
	|-HashSet.Enumerator<Edge>..ctor
	|-HashSet.Enumerator<object>..ctor
	|
	|-RVA: 0x10F00C0 Offset: 0x10EF2C0 VA: 0x1810F00C0
	|-HashSet.Enumerator<int>..ctor
	|-HashSet.Enumerator<Int32Enum>..ctor
	|-HashSet.Enumerator<uint>..ctor
	|
	|-RVA: 0x1110BF0 Offset: 0x110FDF0 VA: 0x181110BF0
	|-HashSet.Enumerator<Vector3Int>..ctor
	|
	|-RVA: 0xE6A900 Offset: 0xE69B00 VA: 0x180E6A900
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-HashSet.Enumerator<AsyncOperationHandle>.Dispose
	|-HashSet.Enumerator<byte>.Dispose
	|-HashSet.Enumerator<char>.Dispose
	|-HashSet.Enumerator<Edge>.Dispose
	|-HashSet.Enumerator<int>.Dispose
	|-HashSet.Enumerator<Int32Enum>.Dispose
	|-HashSet.Enumerator<object>.Dispose
	|-HashSet.Enumerator<ushort>.Dispose
	|-HashSet.Enumerator<UInt16Enum>.Dispose
	|-HashSet.Enumerator<uint>.Dispose
	|-HashSet.Enumerator<Vector3Int>.Dispose
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	|-HashSet.Enumerator<HeliSabotageSystem.ActiveConsoleData>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E61E0 Offset: 0x10E53E0 VA: 0x1810E61E0
	|-HashSet.Enumerator<AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x10E7590 Offset: 0x10E6790 VA: 0x1810E7590
	|-HashSet.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x10E6D90 Offset: 0x10E5F90 VA: 0x1810E6D90
	|-HashSet.Enumerator<char>.MoveNext
	|-HashSet.Enumerator<ushort>.MoveNext
	|-HashSet.Enumerator<UInt16Enum>.MoveNext
	|-HashSet.Enumerator<HeliSabotageSystem.ActiveConsoleData>.MoveNext
	|
	|-RVA: 0x10ECBF0 Offset: 0x10EBDF0 VA: 0x1810ECBF0
	|-HashSet.Enumerator<Edge>.MoveNext
	|-HashSet.Enumerator<object>.MoveNext
	|
	|-RVA: 0x10EC490 Offset: 0x10EB690 VA: 0x1810EC490
	|-HashSet.Enumerator<int>.MoveNext
	|-HashSet.Enumerator<Int32Enum>.MoveNext
	|-HashSet.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x1109DE0 Offset: 0x1108FE0 VA: 0x181109DE0
	|-HashSet.Enumerator<Vector3Int>.MoveNext
	|
	|-RVA: 0x1107C00 Offset: 0x1106E00 VA: 0x181107C00
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	|-HashSet.Enumerator<AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	|-HashSet.Enumerator<byte>.get_Current
	|
	|-RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020
	|-HashSet.Enumerator<char>.get_Current
	|-HashSet.Enumerator<ushort>.get_Current
	|-HashSet.Enumerator<UInt16Enum>.get_Current
	|-HashSet.Enumerator<HeliSabotageSystem.ActiveConsoleData>.get_Current
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-HashSet.Enumerator<Edge>.get_Current
	|-HashSet.Enumerator<object>.get_Current
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-HashSet.Enumerator<int>.get_Current
	|-HashSet.Enumerator<Int32Enum>.get_Current
	|-HashSet.Enumerator<uint>.get_Current
	|
	|-RVA: 0x10EBEF0 Offset: 0x10EB0F0 VA: 0x1810EBEF0
	|-HashSet.Enumerator<Vector3Int>.get_Current
	|
	|-RVA: 0xE69B10 Offset: 0xE68D10 VA: 0x180E69B10
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9D90 Offset: 0x10E8F90 VA: 0x1810E9D90
	|-HashSet.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E9AC0 Offset: 0x10E8CC0 VA: 0x1810E9AC0
	|-HashSet.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E9450 Offset: 0x10E8650 VA: 0x1810E9450
	|-HashSet.Enumerator<char>.System.Collections.IEnumerator.get_Current
	|-HashSet.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|-HashSet.Enumerator<UInt16Enum>.System.Collections.IEnumerator.get_Current
	|-HashSet.Enumerator<HeliSabotageSystem.ActiveConsoleData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EFF00 Offset: 0x10EF100 VA: 0x1810EFF00
	|-HashSet.Enumerator<Edge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EEDD0 Offset: 0x10EDFD0 VA: 0x1810EEDD0
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|-HashSet.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EEE90 Offset: 0x10EE090 VA: 0x1810EEE90
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110D530 Offset: 0x110C730 VA: 0x18110D530
	|-HashSet.Enumerator<Vector3Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110DF30 Offset: 0x110D130 VA: 0x18110DF30
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8910 Offset: 0x10E7B10 VA: 0x1810E8910
	|-HashSet.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x10E8CA0 Offset: 0x10E7EA0 VA: 0x1810E8CA0
	|-HashSet.Enumerator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x10E8D60 Offset: 0x10E7F60 VA: 0x1810E8D60
	|-HashSet.Enumerator<char>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<ushort>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<UInt16Enum>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<HeliSabotageSystem.ActiveConsoleData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x10EE5C0 Offset: 0x10ED7C0 VA: 0x1810EE5C0
	|-HashSet.Enumerator<Edge>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x10EE870 Offset: 0x10EDA70 VA: 0x1810EE870
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x110CB30 Offset: 0x110BD30 VA: 0x18110CB30
	|-HashSet.Enumerator<Vector3Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x110C450 Offset: 0x110B650 VA: 0x18110C450
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: System.Collections.Generic
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 15325
{
	// Fields
	private const int Lower31BitMask = 2147483647;
	private const int StackAllocThreshold = 100;
	private const int ShrinkThreshold = 3;
	private const string CapacityName = "Capacity";
	private const string ElementsName = "Elements";
	private const string ComparerName = "Comparer";
	private const string VersionName = "Version";
	private int[] _buckets; // 0x0
	private HashSet.Slot<T>[] _slots; // 0x0
	private int _count; // 0x0
	private int _lastIndex; // 0x0
	private int _freeList; // 0x0
	private IEqualityComparer<T> _comparer; // 0x0
	private int _version; // 0x0
	private SerializationInfo _siInfo; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	public IEqualityComparer<T> Comparer { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121F680 Offset: 0x121E880 VA: 0x18121F680
	|-HashSet<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x123C300 Offset: 0x123B500 VA: 0x18123C300
	|-HashSet<byte>..ctor
	|
	|-RVA: 0x1239FC0 Offset: 0x12391C0 VA: 0x181239FC0
	|-HashSet<char>..ctor
	|
	|-RVA: 0x123BD80 Offset: 0x123AF80 VA: 0x18123BD80
	|-HashSet<Edge>..ctor
	|
	|-RVA: 0x123B750 Offset: 0x123A950 VA: 0x18123B750
	|-HashSet<int>..ctor
	|
	|-RVA: 0x123C650 Offset: 0x123B850 VA: 0x18123C650
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x123B7E0 Offset: 0x123A9E0 VA: 0x18123B7E0
	|-HashSet<object>..ctor
	|
	|-RVA: 0x1259500 Offset: 0x1258700 VA: 0x181259500
	|-HashSet<ushort>..ctor
	|
	|-RVA: 0x12592D0 Offset: 0x12584D0 VA: 0x1812592D0
	|-HashSet<UInt16Enum>..ctor
	|
	|-RVA: 0x1259E50 Offset: 0x1259050 VA: 0x181259E50
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x1259360 Offset: 0x1258560 VA: 0x181259360
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x125A1F0 Offset: 0x12593F0 VA: 0x18125A1F0
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x125A100 Offset: 0x1259300 VA: 0x18125A100
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121F710 Offset: 0x121E910 VA: 0x18121F710
	|-HashSet<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x123C1B0 Offset: 0x123B3B0 VA: 0x18123C1B0
	|-HashSet<byte>..ctor
	|
	|-RVA: 0x123CAE0 Offset: 0x123BCE0 VA: 0x18123CAE0
	|-HashSet<char>..ctor
	|
	|-RVA: 0x123CB40 Offset: 0x123BD40 VA: 0x18123CB40
	|-HashSet<Edge>..ctor
	|
	|-RVA: 0x123C590 Offset: 0x123B790 VA: 0x18123C590
	|-HashSet<int>..ctor
	|
	|-RVA: 0x123C150 Offset: 0x123B350 VA: 0x18123C150
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x123BE10 Offset: 0x123B010 VA: 0x18123BE10
	|-HashSet<object>..ctor
	|
	|-RVA: 0x125AAA0 Offset: 0x1259CA0 VA: 0x18125AAA0
	|-HashSet<ushort>..ctor
	|
	|-RVA: 0x125ACE0 Offset: 0x1259EE0 VA: 0x18125ACE0
	|-HashSet<UInt16Enum>..ctor
	|
	|-RVA: 0x12599F0 Offset: 0x1258BF0 VA: 0x1812599F0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x1259990 Offset: 0x1258B90 VA: 0x181259990
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x125AB00 Offset: 0x1259D00 VA: 0x18125AB00
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x125AB70 Offset: 0x1259D70 VA: 0x18125AB70
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121F570 Offset: 0x121E770 VA: 0x18121F570
	|-HashSet<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x123BF80 Offset: 0x123B180 VA: 0x18123BF80
	|-HashSet<byte>..ctor
	|
	|-RVA: 0x123ACF0 Offset: 0x1239EF0 VA: 0x18123ACF0
	|-HashSet<char>..ctor
	|
	|-RVA: 0x123C480 Offset: 0x123B680 VA: 0x18123C480
	|-HashSet<Edge>..ctor
	|
	|-RVA: 0x123BE70 Offset: 0x123B070 VA: 0x18123BE70
	|-HashSet<int>..ctor
	|
	|-RVA: 0x123A540 Offset: 0x1239740 VA: 0x18123A540
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x123B870 Offset: 0x123AA70 VA: 0x18123B870
	|-HashSet<object>..ctor
	|
	|-RVA: 0x125AD40 Offset: 0x1259F40 VA: 0x18125AD40
	|-HashSet<ushort>..ctor
	|
	|-RVA: 0x125A330 Offset: 0x1259530 VA: 0x18125A330
	|-HashSet<UInt16Enum>..ctor
	|
	|-RVA: 0x125ABD0 Offset: 0x1259DD0 VA: 0x18125ABD0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x12593F0 Offset: 0x12585F0 VA: 0x1812593F0
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x125AE50 Offset: 0x125A050 VA: 0x18125AE50
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x125A8A0 Offset: 0x1259AA0 VA: 0x18125A8A0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121FC90 Offset: 0x121EE90 VA: 0x18121FC90
	|-HashSet<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x123C090 Offset: 0x123B290 VA: 0x18123C090
	|-HashSet<byte>..ctor
	|
	|-RVA: 0x123C5F0 Offset: 0x123B7F0 VA: 0x18123C5F0
	|-HashSet<char>..ctor
	|
	|-RVA: 0x123A650 Offset: 0x1239850 VA: 0x18123A650
	|-HashSet<Edge>..ctor
	|
	|-RVA: 0x123A890 Offset: 0x1239A90 VA: 0x18123A890
	|-HashSet<int>..ctor
	|
	|-RVA: 0x123AE00 Offset: 0x123A000 VA: 0x18123AE00
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x123C0F0 Offset: 0x123B2F0 VA: 0x18123C0F0
	|-HashSet<object>..ctor
	|
	|-RVA: 0x125B250 Offset: 0x125A450 VA: 0x18125B250
	|-HashSet<ushort>..ctor
	|
	|-RVA: 0x125B1F0 Offset: 0x125A3F0 VA: 0x18125B1F0
	|-HashSet<UInt16Enum>..ctor
	|
	|-RVA: 0x125AEB0 Offset: 0x125A0B0 VA: 0x18125AEB0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x125A190 Offset: 0x1259390 VA: 0x18125A190
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x125B190 Offset: 0x125A390 VA: 0x18125B190
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x125A840 Offset: 0x1259A40 VA: 0x18125A840
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121F890 Offset: 0x121EA90 VA: 0x18121F890
	|-HashSet<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x123A050 Offset: 0x1239250 VA: 0x18123A050
	|-HashSet<byte>..ctor
	|
	|-RVA: 0x123B350 Offset: 0x123A550 VA: 0x18123B350
	|-HashSet<char>..ctor
	|
	|-RVA: 0x123AE60 Offset: 0x123A060 VA: 0x18123AE60
	|-HashSet<Edge>..ctor
	|
	|-RVA: 0x123B980 Offset: 0x123AB80 VA: 0x18123B980
	|-HashSet<int>..ctor
	|
	|-RVA: 0x123A8F0 Offset: 0x1239AF0 VA: 0x18123A8F0
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x123C6E0 Offset: 0x123B8E0 VA: 0x18123C6E0
	|-HashSet<object>..ctor
	|
	|-RVA: 0x125B2B0 Offset: 0x125A4B0 VA: 0x18125B2B0
	|-HashSet<ushort>..ctor
	|
	|-RVA: 0x1259A50 Offset: 0x1258C50 VA: 0x181259A50
	|-HashSet<UInt16Enum>..ctor
	|
	|-RVA: 0x1258ED0 Offset: 0x12580D0 VA: 0x181258ED0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x125A440 Offset: 0x1259640 VA: 0x18125A440
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x1259EE0 Offset: 0x12590E0 VA: 0x181259EE0
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x1259590 Offset: 0x1258790 VA: 0x181259590
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121F770 Offset: 0x121E970 VA: 0x18121F770
	|-HashSet<AsyncOperationHandle>..ctor
	|-HashSet<byte>..ctor
	|-HashSet<char>..ctor
	|-HashSet<Edge>..ctor
	|-HashSet<int>..ctor
	|-HashSet<Int32Enum>..ctor
	|-HashSet<object>..ctor
	|-HashSet<ushort>..ctor
	|-HashSet<UInt16Enum>..ctor
	|-HashSet<uint>..ctor
	|-HashSet<Vector3Int>..ctor
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CopyFrom(HashSet<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121B5E0 Offset: 0x121A7E0 VA: 0x18121B5E0
	|-HashSet<AsyncOperationHandle>.CopyFrom
	|
	|-RVA: 0x1225C40 Offset: 0x1224E40 VA: 0x181225C40
	|-HashSet<byte>.CopyFrom
	|
	|-RVA: 0x12256E0 Offset: 0x12248E0 VA: 0x1812256E0
	|-HashSet<char>.CopyFrom
	|
	|-RVA: 0x1225990 Offset: 0x1224B90 VA: 0x181225990
	|-HashSet<Edge>.CopyFrom
	|
	|-RVA: 0x1225180 Offset: 0x1224380 VA: 0x181225180
	|-HashSet<int>.CopyFrom
	|
	|-RVA: 0x1225430 Offset: 0x1224630 VA: 0x181225430
	|-HashSet<Int32Enum>.CopyFrom
	|
	|-RVA: 0x1224ED0 Offset: 0x12240D0 VA: 0x181224ED0
	|-HashSet<object>.CopyFrom
	|
	|-RVA: 0x1243500 Offset: 0x1242700 VA: 0x181243500
	|-HashSet<ushort>.CopyFrom
	|
	|-RVA: 0x1242FA0 Offset: 0x12421A0 VA: 0x181242FA0
	|-HashSet<UInt16Enum>.CopyFrom
	|
	|-RVA: 0x1243250 Offset: 0x1242450 VA: 0x181243250
	|-HashSet<uint>.CopyFrom
	|
	|-RVA: 0x1242CD0 Offset: 0x1241ED0 VA: 0x181242CD0
	|-HashSet<Vector3Int>.CopyFrom
	|
	|-RVA: 0x1243A60 Offset: 0x1242C60 VA: 0x181243A60
	|-HashSet<__Il2CppFullySharedGenericType>.CopyFrom
	|
	|-RVA: 0x12437B0 Offset: 0x12429B0 VA: 0x1812437B0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121F7A0 Offset: 0x121E9A0 VA: 0x18121F7A0
	|-HashSet<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x123A450 Offset: 0x1239650 VA: 0x18123A450
	|-HashSet<byte>..ctor
	|
	|-RVA: 0x123C390 Offset: 0x123B590 VA: 0x18123C390
	|-HashSet<char>..ctor
	|
	|-RVA: 0x123B260 Offset: 0x123A460 VA: 0x18123B260
	|-HashSet<Edge>..ctor
	|
	|-RVA: 0x123C210 Offset: 0x123B410 VA: 0x18123C210
	|-HashSet<int>..ctor
	|
	|-RVA: 0x123A7A0 Offset: 0x12399A0 VA: 0x18123A7A0
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x123A6B0 Offset: 0x12398B0 VA: 0x18123A6B0
	|-HashSet<object>..ctor
	|
	|-RVA: 0x1258DE0 Offset: 0x1257FE0 VA: 0x181258DE0
	|-HashSet<ushort>..ctor
	|
	|-RVA: 0x125AFB0 Offset: 0x125A1B0 VA: 0x18125AFB0
	|-HashSet<UInt16Enum>..ctor
	|
	|-RVA: 0x125A9B0 Offset: 0x1259BB0 VA: 0x18125A9B0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x125A240 Offset: 0x1259440 VA: 0x18125A240
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x125AF10 Offset: 0x125A110 VA: 0x18125AF10
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x125B0A0 Offset: 0x125A2A0 VA: 0x18125B0A0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121AC60 Offset: 0x1219E60 VA: 0x18121AC60
	|-HashSet<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1222390 Offset: 0x1221590 VA: 0x181222390
	|-HashSet<byte>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1222370 Offset: 0x1221570 VA: 0x181222370
	|-HashSet<char>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1222330 Offset: 0x1221530 VA: 0x181222330
	|-HashSet<Edge>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1222350 Offset: 0x1221550 VA: 0x181222350
	|-HashSet<int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1222310 Offset: 0x1221510 VA: 0x181222310
	|-HashSet<Int32Enum>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x12222F0 Offset: 0x12214F0 VA: 0x1812222F0
	|-HashSet<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x123F940 Offset: 0x123EB40 VA: 0x18123F940
	|-HashSet<ushort>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x123FA90 Offset: 0x123EC90 VA: 0x18123FA90
	|-HashSet<UInt16Enum>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x123FAB0 Offset: 0x123ECB0 VA: 0x18123FAB0
	|-HashSet<uint>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x123FA50 Offset: 0x123EC50 VA: 0x18123FA50
	|-HashSet<Vector3Int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1257200 Offset: 0x1256400 VA: 0x181257200
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x123FAD0 Offset: 0x123ECD0 VA: 0x18123FAD0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121B150 Offset: 0x121A350 VA: 0x18121B150
	|-HashSet<AsyncOperationHandle>.Clear
	|-HashSet<byte>.Clear
	|-HashSet<char>.Clear
	|-HashSet<Edge>.Clear
	|-HashSet<int>.Clear
	|-HashSet<Int32Enum>.Clear
	|-HashSet<object>.Clear
	|-HashSet<ushort>.Clear
	|-HashSet<UInt16Enum>.Clear
	|-HashSet<uint>.Clear
	|-HashSet<Vector3Int>.Clear
	|-HashSet<__Il2CppFullySharedGenericType>.Clear
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121B390 Offset: 0x121A590 VA: 0x18121B390
	|-HashSet<AsyncOperationHandle>.Contains
	|
	|-RVA: 0x12246D0 Offset: 0x12238D0 VA: 0x1812246D0
	|-HashSet<byte>.Contains
	|
	|-RVA: 0x1224D40 Offset: 0x1223F40 VA: 0x181224D40
	|-HashSet<char>.Contains
	|
	|-RVA: 0x1224860 Offset: 0x1223A60 VA: 0x181224860
	|-HashSet<Edge>.Contains
	|
	|-RVA: 0x12249F0 Offset: 0x1223BF0 VA: 0x1812249F0
	|-HashSet<int>.Contains
	|-HashSet<Int32Enum>.Contains
	|
	|-RVA: 0x1224BC0 Offset: 0x1223DC0 VA: 0x181224BC0
	|-HashSet<object>.Contains
	|
	|-RVA: 0x12428B0 Offset: 0x1241AB0 VA: 0x1812428B0
	|-HashSet<ushort>.Contains
	|-HashSet<UInt16Enum>.Contains
	|
	|-RVA: 0x1242230 Offset: 0x1241430 VA: 0x181242230
	|-HashSet<uint>.Contains
	|
	|-RVA: 0x1242A80 Offset: 0x1241C80 VA: 0x181242A80
	|-HashSet<Vector3Int>.Contains
	|
	|-RVA: 0x1242550 Offset: 0x1241750 VA: 0x181242550
	|-HashSet<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x12423C0 Offset: 0x12415C0 VA: 0x1812423C0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121BB50 Offset: 0x121AD50 VA: 0x18121BB50
	|-HashSet<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x1226130 Offset: 0x1225330 VA: 0x181226130
	|-HashSet<byte>.CopyTo
	|
	|-RVA: 0x1226490 Offset: 0x1225690 VA: 0x181226490
	|-HashSet<char>.CopyTo
	|-HashSet<ushort>.CopyTo
	|-HashSet<UInt16Enum>.CopyTo
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.CopyTo
	|
	|-RVA: 0x1226460 Offset: 0x1225660 VA: 0x181226460
	|-HashSet<Edge>.CopyTo
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x12264C0 Offset: 0x12256C0 VA: 0x1812264C0
	|-HashSet<int>.CopyTo
	|-HashSet<Int32Enum>.CopyTo
	|-HashSet<uint>.CopyTo
	|
	|-RVA: 0x1243E40 Offset: 0x1243040 VA: 0x181243E40
	|-HashSet<Vector3Int>.CopyTo
	|
	|-RVA: 0x1244220 Offset: 0x1243420 VA: 0x181244220
	|-HashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121E200 Offset: 0x121D400 VA: 0x18121E200
	|-HashSet<AsyncOperationHandle>.Remove
	|
	|-RVA: 0x1233AC0 Offset: 0x1232CC0 VA: 0x181233AC0
	|-HashSet<byte>.Remove
	|
	|-RVA: 0x1234220 Offset: 0x1233420 VA: 0x181234220
	|-HashSet<char>.Remove
	|
	|-RVA: 0x1233860 Offset: 0x1232A60 VA: 0x181233860
	|-HashSet<Edge>.Remove
	|
	|-RVA: 0x1233D20 Offset: 0x1232F20 VA: 0x181233D20
	|-HashSet<int>.Remove
	|-HashSet<Int32Enum>.Remove
	|
	|-RVA: 0x1233FB0 Offset: 0x12331B0 VA: 0x181233FB0
	|-HashSet<object>.Remove
	|
	|-RVA: 0x1251B20 Offset: 0x1250D20 VA: 0x181251B20
	|-HashSet<ushort>.Remove
	|-HashSet<UInt16Enum>.Remove
	|
	|-RVA: 0x1251DC0 Offset: 0x1250FC0 VA: 0x181251DC0
	|-HashSet<uint>.Remove
	|
	|-RVA: 0x1252020 Offset: 0x1251220 VA: 0x181252020
	|-HashSet<Vector3Int>.Remove
	|
	|-RVA: 0x12525A0 Offset: 0x12517A0 VA: 0x1812525A0
	|-HashSet<__Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0x1252330 Offset: 0x1251530 VA: 0x181252330
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	|-HashSet<AsyncOperationHandle>.get_Count
	|-HashSet<byte>.get_Count
	|-HashSet<char>.get_Count
	|-HashSet<Edge>.get_Count
	|-HashSet<int>.get_Count
	|-HashSet<Int32Enum>.get_Count
	|-HashSet<object>.get_Count
	|-HashSet<ushort>.get_Count
	|-HashSet<UInt16Enum>.get_Count
	|-HashSet<uint>.get_Count
	|-HashSet<Vector3Int>.get_Count
	|-HashSet<__Il2CppFullySharedGenericType>.get_Count
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-HashSet<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<Edge>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<ushort>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<UInt16Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<Vector3Int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public HashSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121BDA0 Offset: 0x121AFA0 VA: 0x18121BDA0
	|-HashSet<AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x1227580 Offset: 0x1226780 VA: 0x181227580
	|-HashSet<byte>.GetEnumerator
	|
	|-RVA: 0x12275C0 Offset: 0x12267C0 VA: 0x1812275C0
	|-HashSet<char>.GetEnumerator
	|-HashSet<ushort>.GetEnumerator
	|-HashSet<UInt16Enum>.GetEnumerator
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.GetEnumerator
	|
	|-RVA: 0x1227500 Offset: 0x1226700 VA: 0x181227500
	|-HashSet<Edge>.GetEnumerator
	|-HashSet<object>.GetEnumerator
	|
	|-RVA: 0x1227540 Offset: 0x1226740 VA: 0x181227540
	|-HashSet<int>.GetEnumerator
	|-HashSet<Int32Enum>.GetEnumerator
	|-HashSet<uint>.GetEnumerator
	|
	|-RVA: 0x12451A0 Offset: 0x12443A0 VA: 0x1812451A0
	|-HashSet<Vector3Int>.GetEnumerator
	|
	|-RVA: 0x12451E0 Offset: 0x12443E0 VA: 0x1812451E0
	|-HashSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121F0E0 Offset: 0x121E2E0 VA: 0x18121F0E0
	|-HashSet<AsyncOperationHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1238750 Offset: 0x1237950 VA: 0x181238750
	|-HashSet<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x12387C0 Offset: 0x12379C0 VA: 0x1812387C0
	|-HashSet<char>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<UInt16Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x12386E0 Offset: 0x12378E0 VA: 0x1812386E0
	|-HashSet<Edge>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1238830 Offset: 0x1237A30 VA: 0x181238830
	|-HashSet<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x12572F0 Offset: 0x12564F0 VA: 0x1812572F0
	|-HashSet<Vector3Int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1257360 Offset: 0x1256560 VA: 0x181257360
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121F0E0 Offset: 0x121E2E0 VA: 0x18121F0E0
	|-HashSet<AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1238750 Offset: 0x1237950 VA: 0x181238750
	|-HashSet<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12387C0 Offset: 0x12379C0 VA: 0x1812387C0
	|-HashSet<char>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<ushort>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<UInt16Enum>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12386E0 Offset: 0x12378E0 VA: 0x1812386E0
	|-HashSet<Edge>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1238830 Offset: 0x1237A30 VA: 0x181238830
	|-HashSet<int>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12572F0 Offset: 0x12564F0 VA: 0x1812572F0
	|-HashSet<Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1257360 Offset: 0x1256560 VA: 0x181257360
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121BDE0 Offset: 0x121AFE0 VA: 0x18121BDE0
	|-HashSet<AsyncOperationHandle>.GetObjectData
	|
	|-RVA: 0x1227EC0 Offset: 0x12270C0 VA: 0x181227EC0
	|-HashSet<byte>.GetObjectData
	|
	|-RVA: 0x1227830 Offset: 0x1226A30 VA: 0x181227830
	|-HashSet<char>.GetObjectData
	|
	|-RVA: 0x12280F0 Offset: 0x12272F0 VA: 0x1812280F0
	|-HashSet<Edge>.GetObjectData
	|
	|-RVA: 0x1227600 Offset: 0x1226800 VA: 0x181227600
	|-HashSet<int>.GetObjectData
	|
	|-RVA: 0x1227C90 Offset: 0x1226E90 VA: 0x181227C90
	|-HashSet<Int32Enum>.GetObjectData
	|
	|-RVA: 0x1227A60 Offset: 0x1226C60 VA: 0x181227A60
	|-HashSet<object>.GetObjectData
	|
	|-RVA: 0x1245B30 Offset: 0x1244D30 VA: 0x181245B30
	|-HashSet<ushort>.GetObjectData
	|
	|-RVA: 0x12456D0 Offset: 0x12448D0 VA: 0x1812456D0
	|-HashSet<UInt16Enum>.GetObjectData
	|
	|-RVA: 0x1245290 Offset: 0x1244490 VA: 0x181245290
	|-HashSet<uint>.GetObjectData
	|
	|-RVA: 0x1245900 Offset: 0x1244B00 VA: 0x181245900
	|-HashSet<Vector3Int>.GetObjectData
	|
	|-RVA: 0x12454C0 Offset: 0x12446C0 VA: 0x1812454C0
	|-HashSet<__Il2CppFullySharedGenericType>.GetObjectData
	|
	|-RVA: 0x1245D60 Offset: 0x1244F60 VA: 0x181245D60
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121D750 Offset: 0x121C950 VA: 0x18121D750
	|-HashSet<AsyncOperationHandle>.OnDeserialization
	|
	|-RVA: 0x1230190 Offset: 0x122F390 VA: 0x181230190
	|-HashSet<byte>.OnDeserialization
	|
	|-RVA: 0x12320C0 Offset: 0x12312C0 VA: 0x1812320C0
	|-HashSet<char>.OnDeserialization
	|
	|-RVA: 0x1230DE0 Offset: 0x122FFE0 VA: 0x181230DE0
	|-HashSet<Edge>.OnDeserialization
	|
	|-RVA: 0x1231400 Offset: 0x1230600 VA: 0x181231400
	|-HashSet<int>.OnDeserialization
	|
	|-RVA: 0x1231A60 Offset: 0x1230C60 VA: 0x181231A60
	|-HashSet<Int32Enum>.OnDeserialization
	|
	|-RVA: 0x12307C0 Offset: 0x122F9C0 VA: 0x1812307C0
	|-HashSet<object>.OnDeserialization
	|
	|-RVA: 0x124EC30 Offset: 0x124DE30 VA: 0x18124EC30
	|-HashSet<ushort>.OnDeserialization
	|
	|-RVA: 0x124FFE0 Offset: 0x124F1E0 VA: 0x18124FFE0
	|-HashSet<UInt16Enum>.OnDeserialization
	|
	|-RVA: 0x124E610 Offset: 0x124D810 VA: 0x18124E610
	|-HashSet<uint>.OnDeserialization
	|
	|-RVA: 0x124F2A0 Offset: 0x124E4A0 VA: 0x18124F2A0
	|-HashSet<Vector3Int>.OnDeserialization
	|
	|-RVA: 0x124E220 Offset: 0x124D420 VA: 0x18124E220
	|-HashSet<__Il2CppFullySharedGenericType>.OnDeserialization
	|
	|-RVA: 0x124F9C0 Offset: 0x124EBC0 VA: 0x18124F9C0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121AC60 Offset: 0x1219E60 VA: 0x18121AC60
	|-HashSet<AsyncOperationHandle>.Add
	|
	|-RVA: 0x1222390 Offset: 0x1221590 VA: 0x181222390
	|-HashSet<byte>.Add
	|
	|-RVA: 0x1222370 Offset: 0x1221570 VA: 0x181222370
	|-HashSet<char>.Add
	|
	|-RVA: 0x1222330 Offset: 0x1221530 VA: 0x181222330
	|-HashSet<Edge>.Add
	|
	|-RVA: 0x1222350 Offset: 0x1221550 VA: 0x181222350
	|-HashSet<int>.Add
	|
	|-RVA: 0x1222310 Offset: 0x1221510 VA: 0x181222310
	|-HashSet<Int32Enum>.Add
	|
	|-RVA: 0x12222F0 Offset: 0x12214F0 VA: 0x1812222F0
	|-HashSet<object>.Add
	|
	|-RVA: 0x123F940 Offset: 0x123EB40 VA: 0x18123F940
	|-HashSet<ushort>.Add
	|
	|-RVA: 0x123FA90 Offset: 0x123EC90 VA: 0x18123FA90
	|-HashSet<UInt16Enum>.Add
	|
	|-RVA: 0x123FAB0 Offset: 0x123ECB0 VA: 0x18123FAB0
	|-HashSet<uint>.Add
	|
	|-RVA: 0x123FA50 Offset: 0x123EC50 VA: 0x18123FA50
	|-HashSet<Vector3Int>.Add
	|
	|-RVA: 0x123F960 Offset: 0x123EB60 VA: 0x18123F960
	|-HashSet<__Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0x123FAD0 Offset: 0x123ECD0 VA: 0x18123FAD0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void UnionWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121F320 Offset: 0x121E520 VA: 0x18121F320
	|-HashSet<AsyncOperationHandle>.UnionWith
	|
	|-RVA: 0x1239960 Offset: 0x1238B60 VA: 0x181239960
	|-HashSet<byte>.UnionWith
	|
	|-RVA: 0x1239740 Offset: 0x1238940 VA: 0x181239740
	|-HashSet<char>.UnionWith
	|
	|-RVA: 0x1239B80 Offset: 0x1238D80 VA: 0x181239B80
	|-HashSet<Edge>.UnionWith
	|
	|-RVA: 0x1239520 Offset: 0x1238720 VA: 0x181239520
	|-HashSet<int>.UnionWith
	|
	|-RVA: 0x1239300 Offset: 0x1238500 VA: 0x181239300
	|-HashSet<Int32Enum>.UnionWith
	|
	|-RVA: 0x1239DA0 Offset: 0x1238FA0 VA: 0x181239DA0
	|-HashSet<object>.UnionWith
	|
	|-RVA: 0x1258750 Offset: 0x1257950 VA: 0x181258750
	|-HashSet<ushort>.UnionWith
	|
	|-RVA: 0x1258530 Offset: 0x1257730 VA: 0x181258530
	|-HashSet<UInt16Enum>.UnionWith
	|
	|-RVA: 0x1258BC0 Offset: 0x1257DC0 VA: 0x181258BC0
	|-HashSet<uint>.UnionWith
	|
	|-RVA: 0x1258970 Offset: 0x1257B70 VA: 0x181258970
	|-HashSet<Vector3Int>.UnionWith
	|
	|-RVA: 0x1258200 Offset: 0x1257400 VA: 0x181258200
	|-HashSet<__Il2CppFullySharedGenericType>.UnionWith
	|
	|-RVA: 0x1257FE0 Offset: 0x12571E0 VA: 0x181257FE0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.UnionWith
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public void IntersectWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121CA90 Offset: 0x121BC90 VA: 0x18121CA90
	|-HashSet<AsyncOperationHandle>.IntersectWith
	|
	|-RVA: 0x122BC60 Offset: 0x122AE60 VA: 0x18122BC60
	|-HashSet<byte>.IntersectWith
	|
	|-RVA: 0x122C1A0 Offset: 0x122B3A0 VA: 0x18122C1A0
	|-HashSet<char>.IntersectWith
	|
	|-RVA: 0x122BF00 Offset: 0x122B100 VA: 0x18122BF00
	|-HashSet<Edge>.IntersectWith
	|
	|-RVA: 0x122C6D0 Offset: 0x122B8D0 VA: 0x18122C6D0
	|-HashSet<int>.IntersectWith
	|
	|-RVA: 0x122C440 Offset: 0x122B640 VA: 0x18122C440
	|-HashSet<Int32Enum>.IntersectWith
	|
	|-RVA: 0x122B9C0 Offset: 0x122ABC0 VA: 0x18122B9C0
	|-HashSet<object>.IntersectWith
	|
	|-RVA: 0x124A0E0 Offset: 0x12492E0 VA: 0x18124A0E0
	|-HashSet<ushort>.IntersectWith
	|
	|-RVA: 0x124A620 Offset: 0x1249820 VA: 0x18124A620
	|-HashSet<UInt16Enum>.IntersectWith
	|
	|-RVA: 0x1249C80 Offset: 0x1248E80 VA: 0x181249C80
	|-HashSet<uint>.IntersectWith
	|
	|-RVA: 0x12499B0 Offset: 0x1248BB0 VA: 0x1812499B0
	|-HashSet<Vector3Int>.IntersectWith
	|
	|-RVA: 0x1249F10 Offset: 0x1249110 VA: 0x181249F10
	|-HashSet<__Il2CppFullySharedGenericType>.IntersectWith
	|
	|-RVA: 0x124A380 Offset: 0x1249580 VA: 0x18124A380
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.IntersectWith
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public void ExceptWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121BB80 Offset: 0x121AD80 VA: 0x18121BB80
	|-HashSet<AsyncOperationHandle>.ExceptWith
	|
	|-RVA: 0x1226F30 Offset: 0x1226130 VA: 0x181226F30
	|-HashSet<byte>.ExceptWith
	|
	|-RVA: 0x1227120 Offset: 0x1226320 VA: 0x181227120
	|-HashSet<char>.ExceptWith
	|
	|-RVA: 0x1226B50 Offset: 0x1225D50 VA: 0x181226B50
	|-HashSet<Edge>.ExceptWith
	|
	|-RVA: 0x1227310 Offset: 0x1226510 VA: 0x181227310
	|-HashSet<int>.ExceptWith
	|
	|-RVA: 0x1226D40 Offset: 0x1225F40 VA: 0x181226D40
	|-HashSet<Int32Enum>.ExceptWith
	|
	|-RVA: 0x1226960 Offset: 0x1225B60 VA: 0x181226960
	|-HashSet<object>.ExceptWith
	|
	|-RVA: 0x1244FB0 Offset: 0x12441B0 VA: 0x181244FB0
	|-HashSet<ushort>.ExceptWith
	|
	|-RVA: 0x1244BD0 Offset: 0x1243DD0 VA: 0x181244BD0
	|-HashSet<UInt16Enum>.ExceptWith
	|
	|-RVA: 0x1244710 Offset: 0x1243910 VA: 0x181244710
	|-HashSet<uint>.ExceptWith
	|
	|-RVA: 0x12444A0 Offset: 0x12436A0 VA: 0x1812444A0
	|-HashSet<Vector3Int>.ExceptWith
	|
	|-RVA: 0x1244900 Offset: 0x1243B00 VA: 0x181244900
	|-HashSet<__Il2CppFullySharedGenericType>.ExceptWith
	|
	|-RVA: 0x1244DC0 Offset: 0x1243FC0 VA: 0x181244DC0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.ExceptWith
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void SymmetricExceptWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121EF10 Offset: 0x121E110 VA: 0x18121EF10
	|-HashSet<AsyncOperationHandle>.SymmetricExceptWith
	|
	|-RVA: 0x1237C00 Offset: 0x1236E00 VA: 0x181237C00
	|-HashSet<byte>.SymmetricExceptWith
	|
	|-RVA: 0x1237DD0 Offset: 0x1236FD0 VA: 0x181237DD0
	|-HashSet<char>.SymmetricExceptWith
	|
	|-RVA: 0x1238340 Offset: 0x1237540 VA: 0x181238340
	|-HashSet<Edge>.SymmetricExceptWith
	|
	|-RVA: 0x1238510 Offset: 0x1237710 VA: 0x181238510
	|-HashSet<int>.SymmetricExceptWith
	|
	|-RVA: 0x1238170 Offset: 0x1237370 VA: 0x181238170
	|-HashSet<Int32Enum>.SymmetricExceptWith
	|
	|-RVA: 0x1237FA0 Offset: 0x12371A0 VA: 0x181237FA0
	|-HashSet<object>.SymmetricExceptWith
	|
	|-RVA: 0x1256B00 Offset: 0x1255D00 VA: 0x181256B00
	|-HashSet<ushort>.SymmetricExceptWith
	|
	|-RVA: 0x1256CD0 Offset: 0x1255ED0 VA: 0x181256CD0
	|-HashSet<UInt16Enum>.SymmetricExceptWith
	|
	|-RVA: 0x1257030 Offset: 0x1256230 VA: 0x181257030
	|-HashSet<uint>.SymmetricExceptWith
	|
	|-RVA: 0x1256760 Offset: 0x1255960 VA: 0x181256760
	|-HashSet<Vector3Int>.SymmetricExceptWith
	|
	|-RVA: 0x1256EA0 Offset: 0x12560A0 VA: 0x181256EA0
	|-HashSet<__Il2CppFullySharedGenericType>.SymmetricExceptWith
	|
	|-RVA: 0x1256930 Offset: 0x1255B30 VA: 0x181256930
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.SymmetricExceptWith
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool IsSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121D3A0 Offset: 0x121C5A0 VA: 0x18121D3A0
	|-HashSet<AsyncOperationHandle>.IsSubsetOf
	|
	|-RVA: 0x122EEF0 Offset: 0x122E0F0 VA: 0x18122EEF0
	|-HashSet<byte>.IsSubsetOf
	|
	|-RVA: 0x122ED30 Offset: 0x122DF30 VA: 0x18122ED30
	|-HashSet<char>.IsSubsetOf
	|
	|-RVA: 0x122F0B0 Offset: 0x122E2B0 VA: 0x18122F0B0
	|-HashSet<Edge>.IsSubsetOf
	|
	|-RVA: 0x122EB70 Offset: 0x122DD70 VA: 0x18122EB70
	|-HashSet<int>.IsSubsetOf
	|
	|-RVA: 0x122F430 Offset: 0x122E630 VA: 0x18122F430
	|-HashSet<Int32Enum>.IsSubsetOf
	|
	|-RVA: 0x122F270 Offset: 0x122E470 VA: 0x18122F270
	|-HashSet<object>.IsSubsetOf
	|
	|-RVA: 0x124CC40 Offset: 0x124BE40 VA: 0x18124CC40
	|-HashSet<ushort>.IsSubsetOf
	|
	|-RVA: 0x124D340 Offset: 0x124C540 VA: 0x18124D340
	|-HashSet<UInt16Enum>.IsSubsetOf
	|
	|-RVA: 0x124CFC0 Offset: 0x124C1C0 VA: 0x18124CFC0
	|-HashSet<uint>.IsSubsetOf
	|
	|-RVA: 0x124CE00 Offset: 0x124C000 VA: 0x18124CE00
	|-HashSet<Vector3Int>.IsSubsetOf
	|
	|-RVA: 0x124D500 Offset: 0x124C700 VA: 0x18124D500
	|-HashSet<__Il2CppFullySharedGenericType>.IsSubsetOf
	|
	|-RVA: 0x124D180 Offset: 0x124C380 VA: 0x18124D180
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.IsSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool IsProperSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121CD80 Offset: 0x121BF80 VA: 0x18121CD80
	|-HashSet<AsyncOperationHandle>.IsProperSubsetOf
	|
	|-RVA: 0x122CBA0 Offset: 0x122BDA0 VA: 0x18122CBA0
	|-HashSet<byte>.IsProperSubsetOf
	|
	|-RVA: 0x122C960 Offset: 0x122BB60 VA: 0x18122C960
	|-HashSet<char>.IsProperSubsetOf
	|
	|-RVA: 0x122D260 Offset: 0x122C460 VA: 0x18122D260
	|-HashSet<Edge>.IsProperSubsetOf
	|
	|-RVA: 0x122D020 Offset: 0x122C220 VA: 0x18122D020
	|-HashSet<int>.IsProperSubsetOf
	|
	|-RVA: 0x122D4A0 Offset: 0x122C6A0 VA: 0x18122D4A0
	|-HashSet<Int32Enum>.IsProperSubsetOf
	|
	|-RVA: 0x122CDE0 Offset: 0x122BFE0 VA: 0x18122CDE0
	|-HashSet<object>.IsProperSubsetOf
	|
	|-RVA: 0x124A8C0 Offset: 0x1249AC0 VA: 0x18124A8C0
	|-HashSet<ushort>.IsProperSubsetOf
	|
	|-RVA: 0x124AF80 Offset: 0x124A180 VA: 0x18124AF80
	|-HashSet<UInt16Enum>.IsProperSubsetOf
	|
	|-RVA: 0x124B1C0 Offset: 0x124A3C0 VA: 0x18124B1C0
	|-HashSet<uint>.IsProperSubsetOf
	|
	|-RVA: 0x124AB00 Offset: 0x1249D00 VA: 0x18124AB00
	|-HashSet<Vector3Int>.IsProperSubsetOf
	|
	|-RVA: 0x124B400 Offset: 0x124A600 VA: 0x18124B400
	|-HashSet<__Il2CppFullySharedGenericType>.IsProperSubsetOf
	|
	|-RVA: 0x124AD40 Offset: 0x1249F40 VA: 0x18124AD40
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.IsProperSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool IsSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121D560 Offset: 0x121C760 VA: 0x18121D560
	|-HashSet<AsyncOperationHandle>.IsSupersetOf
	|
	|-RVA: 0x122F5F0 Offset: 0x122E7F0 VA: 0x18122F5F0
	|-HashSet<byte>.IsSupersetOf
	|
	|-RVA: 0x122F9D0 Offset: 0x122EBD0 VA: 0x18122F9D0
	|-HashSet<char>.IsSupersetOf
	|
	|-RVA: 0x122FFA0 Offset: 0x122F1A0 VA: 0x18122FFA0
	|-HashSet<Edge>.IsSupersetOf
	|
	|-RVA: 0x122FBC0 Offset: 0x122EDC0 VA: 0x18122FBC0
	|-HashSet<int>.IsSupersetOf
	|
	|-RVA: 0x122FDB0 Offset: 0x122EFB0 VA: 0x18122FDB0
	|-HashSet<Int32Enum>.IsSupersetOf
	|
	|-RVA: 0x122F7E0 Offset: 0x122E9E0 VA: 0x18122F7E0
	|-HashSet<object>.IsSupersetOf
	|
	|-RVA: 0x124D6B0 Offset: 0x124C8B0 VA: 0x18124D6B0
	|-HashSet<ushort>.IsSupersetOf
	|
	|-RVA: 0x124E030 Offset: 0x124D230 VA: 0x18124E030
	|-HashSet<UInt16Enum>.IsSupersetOf
	|
	|-RVA: 0x124DE40 Offset: 0x124D040 VA: 0x18124DE40
	|-HashSet<uint>.IsSupersetOf
	|
	|-RVA: 0x124DC50 Offset: 0x124CE50 VA: 0x18124DC50
	|-HashSet<Vector3Int>.IsSupersetOf
	|
	|-RVA: 0x124DA90 Offset: 0x124CC90 VA: 0x18124DA90
	|-HashSet<__Il2CppFullySharedGenericType>.IsSupersetOf
	|
	|-RVA: 0x124D8A0 Offset: 0x124CAA0 VA: 0x18124D8A0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.IsSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public bool IsProperSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121CFC0 Offset: 0x121C1C0 VA: 0x18121CFC0
	|-HashSet<AsyncOperationHandle>.IsProperSupersetOf
	|
	|-RVA: 0x122DB20 Offset: 0x122CD20 VA: 0x18122DB20
	|-HashSet<byte>.IsProperSupersetOf
	|
	|-RVA: 0x122DF60 Offset: 0x122D160 VA: 0x18122DF60
	|-HashSet<char>.IsProperSupersetOf
	|
	|-RVA: 0x122E180 Offset: 0x122D380 VA: 0x18122E180
	|-HashSet<Edge>.IsProperSupersetOf
	|
	|-RVA: 0x122D6E0 Offset: 0x122C8E0 VA: 0x18122D6E0
	|-HashSet<int>.IsProperSupersetOf
	|
	|-RVA: 0x122D900 Offset: 0x122CB00 VA: 0x18122D900
	|-HashSet<Int32Enum>.IsProperSupersetOf
	|
	|-RVA: 0x122DD40 Offset: 0x122CF40 VA: 0x18122DD40
	|-HashSet<object>.IsProperSupersetOf
	|
	|-RVA: 0x124BA70 Offset: 0x124AC70 VA: 0x18124BA70
	|-HashSet<ushort>.IsProperSupersetOf
	|
	|-RVA: 0x124B630 Offset: 0x124A830 VA: 0x18124B630
	|-HashSet<UInt16Enum>.IsProperSupersetOf
	|
	|-RVA: 0x124BEB0 Offset: 0x124B0B0 VA: 0x18124BEB0
	|-HashSet<uint>.IsProperSupersetOf
	|
	|-RVA: 0x124BC90 Offset: 0x124AE90 VA: 0x18124BC90
	|-HashSet<Vector3Int>.IsProperSupersetOf
	|
	|-RVA: 0x124C0D0 Offset: 0x124B2D0 VA: 0x18124C0D0
	|-HashSet<__Il2CppFullySharedGenericType>.IsProperSupersetOf
	|
	|-RVA: 0x124B850 Offset: 0x124AA50 VA: 0x18124B850
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.IsProperSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public bool Overlaps(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121DE70 Offset: 0x121D070 VA: 0x18121DE70
	|-HashSet<AsyncOperationHandle>.Overlaps
	|
	|-RVA: 0x12326F0 Offset: 0x12318F0 VA: 0x1812326F0
	|-HashSet<byte>.Overlaps
	|
	|-RVA: 0x1232EF0 Offset: 0x12320F0 VA: 0x181232EF0
	|-HashSet<char>.Overlaps
	|
	|-RVA: 0x12328F0 Offset: 0x1231AF0 VA: 0x1812328F0
	|-HashSet<Edge>.Overlaps
	|
	|-RVA: 0x1232AF0 Offset: 0x1231CF0 VA: 0x181232AF0
	|-HashSet<int>.Overlaps
	|
	|-RVA: 0x1232CF0 Offset: 0x1231EF0 VA: 0x181232CF0
	|-HashSet<Int32Enum>.Overlaps
	|
	|-RVA: 0x12330F0 Offset: 0x12322F0 VA: 0x1812330F0
	|-HashSet<object>.Overlaps
	|
	|-RVA: 0x12511C0 Offset: 0x12503C0 VA: 0x1812511C0
	|-HashSet<ushort>.Overlaps
	|
	|-RVA: 0x1250650 Offset: 0x124F850 VA: 0x181250650
	|-HashSet<UInt16Enum>.Overlaps
	|
	|-RVA: 0x1250FC0 Offset: 0x12501C0 VA: 0x181250FC0
	|-HashSet<uint>.Overlaps
	|
	|-RVA: 0x1250850 Offset: 0x124FA50 VA: 0x181250850
	|-HashSet<Vector3Int>.Overlaps
	|
	|-RVA: 0x1250AD0 Offset: 0x124FCD0 VA: 0x181250AD0
	|-HashSet<__Il2CppFullySharedGenericType>.Overlaps
	|
	|-RVA: 0x1250DC0 Offset: 0x124FFC0 VA: 0x181250DC0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.Overlaps
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool SetEquals(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121E660 Offset: 0x121D860 VA: 0x18121E660
	|-HashSet<AsyncOperationHandle>.SetEquals
	|
	|-RVA: 0x1234D70 Offset: 0x1233F70 VA: 0x181234D70
	|-HashSet<byte>.SetEquals
	|
	|-RVA: 0x1234FA0 Offset: 0x12341A0 VA: 0x181234FA0
	|-HashSet<char>.SetEquals
	|
	|-RVA: 0x12351D0 Offset: 0x12343D0 VA: 0x1812351D0
	|-HashSet<Edge>.SetEquals
	|
	|-RVA: 0x1234B40 Offset: 0x1233D40 VA: 0x181234B40
	|-HashSet<int>.SetEquals
	|
	|-RVA: 0x1235400 Offset: 0x1234600 VA: 0x181235400
	|-HashSet<Int32Enum>.SetEquals
	|
	|-RVA: 0x1235630 Offset: 0x1234830 VA: 0x181235630
	|-HashSet<object>.SetEquals
	|
	|-RVA: 0x1253290 Offset: 0x1252490 VA: 0x181253290
	|-HashSet<ushort>.SetEquals
	|
	|-RVA: 0x1253920 Offset: 0x1252B20 VA: 0x181253920
	|-HashSet<UInt16Enum>.SetEquals
	|
	|-RVA: 0x12534C0 Offset: 0x12526C0 VA: 0x1812534C0
	|-HashSet<uint>.SetEquals
	|
	|-RVA: 0x1253D70 Offset: 0x1252F70 VA: 0x181253D70
	|-HashSet<Vector3Int>.SetEquals
	|
	|-RVA: 0x1253B50 Offset: 0x1252D50 VA: 0x181253B50
	|-HashSet<__Il2CppFullySharedGenericType>.SetEquals
	|
	|-RVA: 0x12536F0 Offset: 0x12528F0 VA: 0x1812536F0
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.SetEquals
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121B8D0 Offset: 0x121AAD0 VA: 0x18121B8D0
	|-HashSet<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x1226160 Offset: 0x1225360 VA: 0x181226160
	|-HashSet<byte>.CopyTo
	|
	|-RVA: 0x1226190 Offset: 0x1225390 VA: 0x181226190
	|-HashSet<char>.CopyTo
	|-HashSet<ushort>.CopyTo
	|-HashSet<UInt16Enum>.CopyTo
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.CopyTo
	|
	|-RVA: 0x1226400 Offset: 0x1225600 VA: 0x181226400
	|-HashSet<Edge>.CopyTo
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x1226430 Offset: 0x1225630 VA: 0x181226430
	|-HashSet<int>.CopyTo
	|-HashSet<Int32Enum>.CopyTo
	|-HashSet<uint>.CopyTo
	|
	|-RVA: 0x1243E10 Offset: 0x1243010 VA: 0x181243E10
	|-HashSet<Vector3Int>.CopyTo
	|
	|-RVA: 0x12441F0 Offset: 0x12433F0 VA: 0x1812441F0
	|-HashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121B900 Offset: 0x121AB00 VA: 0x18121B900
	|-HashSet<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x12264F0 Offset: 0x12256F0 VA: 0x1812264F0
	|-HashSet<byte>.CopyTo
	|
	|-RVA: 0x1226720 Offset: 0x1225920 VA: 0x181226720
	|-HashSet<char>.CopyTo
	|-HashSet<ushort>.CopyTo
	|-HashSet<UInt16Enum>.CopyTo
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.CopyTo
	|
	|-RVA: 0x1225EF0 Offset: 0x12250F0 VA: 0x181225EF0
	|-HashSet<Edge>.CopyTo
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x12261C0 Offset: 0x12253C0 VA: 0x1812261C0
	|-HashSet<int>.CopyTo
	|-HashSet<Int32Enum>.CopyTo
	|-HashSet<uint>.CopyTo
	|
	|-RVA: 0x1244250 Offset: 0x1243450 VA: 0x181244250
	|-HashSet<Vector3Int>.CopyTo
	|
	|-RVA: 0x1243E70 Offset: 0x1243070 VA: 0x181243E70
	|-HashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public int RemoveWhere(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121E0A0 Offset: 0x121D2A0 VA: 0x18121E0A0
	|-HashSet<AsyncOperationHandle>.RemoveWhere
	|
	|-RVA: 0x1233620 Offset: 0x1232820 VA: 0x181233620
	|-HashSet<byte>.RemoveWhere
	|
	|-RVA: 0x1233740 Offset: 0x1232940 VA: 0x181233740
	|-HashSet<char>.RemoveWhere
	|
	|-RVA: 0x1233400 Offset: 0x1232600 VA: 0x181233400
	|-HashSet<Edge>.RemoveWhere
	|
	|-RVA: 0x12332F0 Offset: 0x12324F0 VA: 0x1812332F0
	|-HashSet<int>.RemoveWhere
	|-HashSet<Int32Enum>.RemoveWhere
	|
	|-RVA: 0x1233510 Offset: 0x1232710 VA: 0x181233510
	|-HashSet<object>.RemoveWhere
	|
	|-RVA: 0x1251720 Offset: 0x1250920 VA: 0x181251720
	|-HashSet<ushort>.RemoveWhere
	|-HashSet<UInt16Enum>.RemoveWhere
	|
	|-RVA: 0x1251500 Offset: 0x1250700 VA: 0x181251500
	|-HashSet<uint>.RemoveWhere
	|
	|-RVA: 0x12513C0 Offset: 0x12505C0 VA: 0x1812513C0
	|-HashSet<Vector3Int>.RemoveWhere
	|
	|-RVA: 0x1251840 Offset: 0x1250A40 VA: 0x181251840
	|-HashSet<__Il2CppFullySharedGenericType>.RemoveWhere
	|
	|-RVA: 0x1251610 Offset: 0x1250810 VA: 0x181251610
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.RemoveWhere
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	|-HashSet<AsyncOperationHandle>.get_Comparer
	|-HashSet<byte>.get_Comparer
	|-HashSet<char>.get_Comparer
	|-HashSet<Edge>.get_Comparer
	|-HashSet<int>.get_Comparer
	|-HashSet<Int32Enum>.get_Comparer
	|-HashSet<object>.get_Comparer
	|-HashSet<ushort>.get_Comparer
	|-HashSet<UInt16Enum>.get_Comparer
	|-HashSet<uint>.get_Comparer
	|-HashSet<Vector3Int>.get_Comparer
	|-HashSet<__Il2CppFullySharedGenericType>.get_Comparer
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.get_Comparer
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121F160 Offset: 0x121E360 VA: 0x18121F160
	|-HashSet<AsyncOperationHandle>.TrimExcess
	|
	|-RVA: 0x12388A0 Offset: 0x1237AA0 VA: 0x1812388A0
	|-HashSet<byte>.TrimExcess
	|
	|-RVA: 0x1238F80 Offset: 0x1238180 VA: 0x181238F80
	|-HashSet<char>.TrimExcess
	|
	|-RVA: 0x1238C10 Offset: 0x1237E10 VA: 0x181238C10
	|-HashSet<Edge>.TrimExcess
	|
	|-RVA: 0x1239140 Offset: 0x1238340 VA: 0x181239140
	|-HashSet<int>.TrimExcess
	|
	|-RVA: 0x1238DC0 Offset: 0x1237FC0 VA: 0x181238DC0
	|-HashSet<Int32Enum>.TrimExcess
	|
	|-RVA: 0x1238A60 Offset: 0x1237C60 VA: 0x181238A60
	|-HashSet<object>.TrimExcess
	|
	|-RVA: 0x1257E20 Offset: 0x1257020 VA: 0x181257E20
	|-HashSet<ushort>.TrimExcess
	|
	|-RVA: 0x1257AA0 Offset: 0x1256CA0 VA: 0x181257AA0
	|-HashSet<UInt16Enum>.TrimExcess
	|
	|-RVA: 0x12575D0 Offset: 0x12567D0 VA: 0x1812575D0
	|-HashSet<uint>.TrimExcess
	|
	|-RVA: 0x1257C60 Offset: 0x1256E60 VA: 0x181257C60
	|-HashSet<Vector3Int>.TrimExcess
	|
	|-RVA: 0x1257790 Offset: 0x1256990 VA: 0x181257790
	|-HashSet<__Il2CppFullySharedGenericType>.TrimExcess
	|
	|-RVA: 0x1257410 Offset: 0x1256610 VA: 0x181257410
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	private int Initialize(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121C1D0 Offset: 0x121B3D0 VA: 0x18121C1D0
	|-HashSet<AsyncOperationHandle>.Initialize
	|
	|-RVA: 0x1228FE0 Offset: 0x12281E0 VA: 0x181228FE0
	|-HashSet<byte>.Initialize
	|
	|-RVA: 0x1229160 Offset: 0x1228360 VA: 0x181229160
	|-HashSet<char>.Initialize
	|
	|-RVA: 0x1228E60 Offset: 0x1228060 VA: 0x181228E60
	|-HashSet<Edge>.Initialize
	|
	|-RVA: 0x12290A0 Offset: 0x12282A0 VA: 0x1812290A0
	|-HashSet<int>.Initialize
	|
	|-RVA: 0x1228DA0 Offset: 0x1227FA0 VA: 0x181228DA0
	|-HashSet<Int32Enum>.Initialize
	|
	|-RVA: 0x1228F20 Offset: 0x1228120 VA: 0x181228F20
	|-HashSet<object>.Initialize
	|
	|-RVA: 0x1246910 Offset: 0x1245B10 VA: 0x181246910
	|-HashSet<ushort>.Initialize
	|
	|-RVA: 0x1246C10 Offset: 0x1245E10 VA: 0x181246C10
	|-HashSet<UInt16Enum>.Initialize
	|
	|-RVA: 0x12469D0 Offset: 0x1245BD0 VA: 0x1812469D0
	|-HashSet<uint>.Initialize
	|
	|-RVA: 0x1246A90 Offset: 0x1245C90 VA: 0x181246A90
	|-HashSet<Vector3Int>.Initialize
	|
	|-RVA: 0x1246CD0 Offset: 0x1245ED0 VA: 0x181246CD0
	|-HashSet<__Il2CppFullySharedGenericType>.Initialize
	|
	|-RVA: 0x1246B50 Offset: 0x1245D50 VA: 0x181246B50
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.Initialize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121C010 Offset: 0x121B210 VA: 0x18121C010
	|-HashSet<AsyncOperationHandle>.IncreaseCapacity
	|
	|-RVA: 0x1228A20 Offset: 0x1227C20 VA: 0x181228A20
	|-HashSet<byte>.IncreaseCapacity
	|
	|-RVA: 0x12284E0 Offset: 0x12276E0 VA: 0x1812284E0
	|-HashSet<char>.IncreaseCapacity
	|
	|-RVA: 0x12286A0 Offset: 0x12278A0 VA: 0x1812286A0
	|-HashSet<Edge>.IncreaseCapacity
	|
	|-RVA: 0x1228320 Offset: 0x1227520 VA: 0x181228320
	|-HashSet<int>.IncreaseCapacity
	|
	|-RVA: 0x1228BE0 Offset: 0x1227DE0 VA: 0x181228BE0
	|-HashSet<Int32Enum>.IncreaseCapacity
	|
	|-RVA: 0x1228860 Offset: 0x1227A60 VA: 0x181228860
	|-HashSet<object>.IncreaseCapacity
	|
	|-RVA: 0x1245F90 Offset: 0x1245190 VA: 0x181245F90
	|-HashSet<ushort>.IncreaseCapacity
	|
	|-RVA: 0x1246150 Offset: 0x1245350 VA: 0x181246150
	|-HashSet<UInt16Enum>.IncreaseCapacity
	|
	|-RVA: 0x1246310 Offset: 0x1245510 VA: 0x181246310
	|-HashSet<uint>.IncreaseCapacity
	|
	|-RVA: 0x12464D0 Offset: 0x12456D0 VA: 0x1812464D0
	|-HashSet<Vector3Int>.IncreaseCapacity
	|
	|-RVA: 0x1246690 Offset: 0x1245890 VA: 0x181246690
	|-HashSet<__Il2CppFullySharedGenericType>.IncreaseCapacity
	|
	|-RVA: 0x1246750 Offset: 0x1245950 VA: 0x181246750
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.IncreaseCapacity
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121E540 Offset: 0x121D740 VA: 0x18121E540
	|-HashSet<AsyncOperationHandle>.SetCapacity
	|
	|-RVA: 0x1234A20 Offset: 0x1233C20 VA: 0x181234A20
	|-HashSet<byte>.SetCapacity
	|
	|-RVA: 0x12347E0 Offset: 0x12339E0 VA: 0x1812347E0
	|-HashSet<char>.SetCapacity
	|
	|-RVA: 0x12345A0 Offset: 0x12337A0 VA: 0x1812345A0
	|-HashSet<Edge>.SetCapacity
	|
	|-RVA: 0x1234900 Offset: 0x1233B00 VA: 0x181234900
	|-HashSet<int>.SetCapacity
	|
	|-RVA: 0x1234480 Offset: 0x1233680 VA: 0x181234480
	|-HashSet<Int32Enum>.SetCapacity
	|
	|-RVA: 0x12346C0 Offset: 0x12338C0 VA: 0x1812346C0
	|-HashSet<object>.SetCapacity
	|
	|-RVA: 0x1253170 Offset: 0x1252370 VA: 0x181253170
	|-HashSet<ushort>.SetCapacity
	|
	|-RVA: 0x1252C40 Offset: 0x1251E40 VA: 0x181252C40
	|-HashSet<UInt16Enum>.SetCapacity
	|
	|-RVA: 0x1252B20 Offset: 0x1251D20 VA: 0x181252B20
	|-HashSet<uint>.SetCapacity
	|
	|-RVA: 0x1252F30 Offset: 0x1252130 VA: 0x181252F30
	|-HashSet<Vector3Int>.SetCapacity
	|
	|-RVA: 0x1252D60 Offset: 0x1251F60 VA: 0x181252D60
	|-HashSet<__Il2CppFullySharedGenericType>.SetCapacity
	|
	|-RVA: 0x1253050 Offset: 0x1252250 VA: 0x181253050
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private bool AddIfNotPresent(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121A440 Offset: 0x1219640 VA: 0x18121A440
	|-HashSet<AsyncOperationHandle>.AddIfNotPresent
	|
	|-RVA: 0x1220B70 Offset: 0x121FD70 VA: 0x181220B70
	|-HashSet<byte>.AddIfNotPresent
	|
	|-RVA: 0x12202D0 Offset: 0x121F4D0 VA: 0x1812202D0
	|-HashSet<char>.AddIfNotPresent
	|
	|-RVA: 0x121FCF0 Offset: 0x121EEF0 VA: 0x18121FCF0
	|-HashSet<Edge>.AddIfNotPresent
	|
	|-RVA: 0x121FFC0 Offset: 0x121F1C0 VA: 0x18121FFC0
	|-HashSet<int>.AddIfNotPresent
	|
	|-RVA: 0x12205A0 Offset: 0x121F7A0 VA: 0x1812205A0
	|-HashSet<Int32Enum>.AddIfNotPresent
	|
	|-RVA: 0x12208B0 Offset: 0x121FAB0 VA: 0x1812208B0
	|-HashSet<object>.AddIfNotPresent
	|
	|-RVA: 0x123DB90 Offset: 0x123CD90 VA: 0x18123DB90
	|-HashSet<ushort>.AddIfNotPresent
	|
	|-RVA: 0x123D2B0 Offset: 0x123C4B0 VA: 0x18123D2B0
	|-HashSet<UInt16Enum>.AddIfNotPresent
	|
	|-RVA: 0x123DEB0 Offset: 0x123D0B0 VA: 0x18123DEB0
	|-HashSet<uint>.AddIfNotPresent
	|
	|-RVA: 0x123CF00 Offset: 0x123C100 VA: 0x18123CF00
	|-HashSet<Vector3Int>.AddIfNotPresent
	|
	|-RVA: 0x123D5D0 Offset: 0x123C7D0 VA: 0x18123D5D0
	|-HashSet<__Il2CppFullySharedGenericType>.AddIfNotPresent
	|
	|-RVA: 0x123CC30 Offset: 0x123BE30 VA: 0x18123CC30
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.AddIfNotPresent
	*/

	// RVA: -1 Offset: -1
	private void AddValue(int index, int hashCode, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121AB80 Offset: 0x1219D80 VA: 0x18121AB80
	|-HashSet<AsyncOperationHandle>.AddValue
	|
	|-RVA: 0x1222000 Offset: 0x1221200 VA: 0x181222000
	|-HashSet<byte>.AddValue
	|
	|-RVA: 0x1222180 Offset: 0x1221380 VA: 0x181222180
	|-HashSet<char>.AddValue
	|-HashSet<ushort>.AddValue
	|-HashSet<UInt16Enum>.AddValue
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.AddValue
	|
	|-RVA: 0x1222240 Offset: 0x1221440 VA: 0x181222240
	|-HashSet<Edge>.AddValue
	|
	|-RVA: 0x12220C0 Offset: 0x12212C0 VA: 0x1812220C0
	|-HashSet<int>.AddValue
	|-HashSet<Int32Enum>.AddValue
	|-HashSet<uint>.AddValue
	|
	|-RVA: 0x1221F40 Offset: 0x1221140 VA: 0x181221F40
	|-HashSet<object>.AddValue
	|
	|-RVA: 0x123F870 Offset: 0x123EA70 VA: 0x18123F870
	|-HashSet<Vector3Int>.AddValue
	|
	|-RVA: 0x123F660 Offset: 0x123E860 VA: 0x18123F660
	|-HashSet<__Il2CppFullySharedGenericType>.AddValue
	*/

	// RVA: -1 Offset: -1
	private bool ContainsAllElements(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121B1B0 Offset: 0x121A3B0 VA: 0x18121B1B0
	|-HashSet<AsyncOperationHandle>.ContainsAllElements
	|
	|-RVA: 0x1224350 Offset: 0x1223550 VA: 0x181224350
	|-HashSet<byte>.ContainsAllElements
	|
	|-RVA: 0x1224510 Offset: 0x1223710 VA: 0x181224510
	|-HashSet<char>.ContainsAllElements
	|
	|-RVA: 0x1223E30 Offset: 0x1223030 VA: 0x181223E30
	|-HashSet<Edge>.ContainsAllElements
	|
	|-RVA: 0x1223FF0 Offset: 0x12231F0 VA: 0x181223FF0
	|-HashSet<int>.ContainsAllElements
	|
	|-RVA: 0x12241A0 Offset: 0x12233A0 VA: 0x1812241A0
	|-HashSet<Int32Enum>.ContainsAllElements
	|
	|-RVA: 0x1223C70 Offset: 0x1222E70 VA: 0x181223C70
	|-HashSet<object>.ContainsAllElements
	|
	|-RVA: 0x1241DD0 Offset: 0x1240FD0 VA: 0x181241DD0
	|-HashSet<ushort>.ContainsAllElements
	|
	|-RVA: 0x1241C10 Offset: 0x1240E10 VA: 0x181241C10
	|-HashSet<UInt16Enum>.ContainsAllElements
	|
	|-RVA: 0x1241660 Offset: 0x1240860 VA: 0x181241660
	|-HashSet<uint>.ContainsAllElements
	|
	|-RVA: 0x12419D0 Offset: 0x1240BD0 VA: 0x1812419D0
	|-HashSet<Vector3Int>.ContainsAllElements
	|
	|-RVA: 0x1241F90 Offset: 0x1241190 VA: 0x181241F90
	|-HashSet<__Il2CppFullySharedGenericType>.ContainsAllElements
	|
	|-RVA: 0x1241810 Offset: 0x1240A10 VA: 0x181241810
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.ContainsAllElements
	*/

	// RVA: -1 Offset: -1
	private bool IsSubsetOfHashSetWithSameEC(HashSet<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121D1E0 Offset: 0x121C3E0 VA: 0x18121D1E0
	|-HashSet<AsyncOperationHandle>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x122E9E0 Offset: 0x122DBE0 VA: 0x18122E9E0
	|-HashSet<byte>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x122E6C0 Offset: 0x122D8C0 VA: 0x18122E6C0
	|-HashSet<char>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x122E530 Offset: 0x122D730 VA: 0x18122E530
	|-HashSet<Edge>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x122E3A0 Offset: 0x122D5A0 VA: 0x18122E3A0
	|-HashSet<int>.IsSubsetOfHashSetWithSameEC
	|-HashSet<Int32Enum>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x122E850 Offset: 0x122DA50 VA: 0x18122E850
	|-HashSet<object>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x124C2D0 Offset: 0x124B4D0 VA: 0x18124C2D0
	|-HashSet<ushort>.IsSubsetOfHashSetWithSameEC
	|-HashSet<UInt16Enum>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x124C460 Offset: 0x124B660 VA: 0x18124C460
	|-HashSet<uint>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x124CAA0 Offset: 0x124BCA0 VA: 0x18124CAA0
	|-HashSet<Vector3Int>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x124C5F0 Offset: 0x124B7F0 VA: 0x18124C5F0
	|-HashSet<__Il2CppFullySharedGenericType>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x124C910 Offset: 0x124BB10 VA: 0x18124C910
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.IsSubsetOfHashSetWithSameEC
	*/

	// RVA: -1 Offset: -1
	private void IntersectWithHashSetWithSameEC(HashSet<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121C980 Offset: 0x121BB80 VA: 0x18121C980
	|-HashSet<AsyncOperationHandle>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x122B780 Offset: 0x122A980 VA: 0x18122B780
	|-HashSet<byte>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x122B900 Offset: 0x122AB00 VA: 0x18122B900
	|-HashSet<char>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x122B840 Offset: 0x122AA40 VA: 0x18122B840
	|-HashSet<Edge>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x122B600 Offset: 0x122A800 VA: 0x18122B600
	|-HashSet<int>.IntersectWithHashSetWithSameEC
	|-HashSet<Int32Enum>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x122B6C0 Offset: 0x122A8C0 VA: 0x18122B6C0
	|-HashSet<object>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x1249400 Offset: 0x1248600 VA: 0x181249400
	|-HashSet<ushort>.IntersectWithHashSetWithSameEC
	|-HashSet<UInt16Enum>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x12494C0 Offset: 0x12486C0 VA: 0x1812494C0
	|-HashSet<uint>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x12498B0 Offset: 0x1248AB0 VA: 0x1812498B0
	|-HashSet<Vector3Int>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x1249640 Offset: 0x1248840 VA: 0x181249640
	|-HashSet<__Il2CppFullySharedGenericType>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x1249580 Offset: 0x1248780 VA: 0x181249580
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.IntersectWithHashSetWithSameEC
	*/

	// RVA: -1 Offset: -1
	private void IntersectWithEnumerable(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121C5B0 Offset: 0x121B7B0 VA: 0x18121C5B0
	|-HashSet<AsyncOperationHandle>.IntersectWithEnumerable
	|
	|-RVA: 0x122AD40 Offset: 0x1229F40 VA: 0x18122AD40
	|-HashSet<byte>.IntersectWithEnumerable
	|
	|-RVA: 0x122A9C0 Offset: 0x1229BC0 VA: 0x18122A9C0
	|-HashSet<char>.IntersectWithEnumerable
	|
	|-RVA: 0x1229D90 Offset: 0x1228F90 VA: 0x181229D90
	|-HashSet<Edge>.IntersectWithEnumerable
	|
	|-RVA: 0x122A640 Offset: 0x1229840 VA: 0x18122A640
	|-HashSet<int>.IntersectWithEnumerable
	|
	|-RVA: 0x122A2C0 Offset: 0x12294C0 VA: 0x18122A2C0
	|-HashSet<Int32Enum>.IntersectWithEnumerable
	|
	|-RVA: 0x122B0C0 Offset: 0x122A2C0 VA: 0x18122B0C0
	|-HashSet<object>.IntersectWithEnumerable
	|
	|-RVA: 0x1248070 Offset: 0x1247270 VA: 0x181248070
	|-HashSet<ushort>.IntersectWithEnumerable
	|
	|-RVA: 0x1249080 Offset: 0x1248280 VA: 0x181249080
	|-HashSet<UInt16Enum>.IntersectWithEnumerable
	|
	|-RVA: 0x12483F0 Offset: 0x12475F0 VA: 0x1812483F0
	|-HashSet<uint>.IntersectWithEnumerable
	|
	|-RVA: 0x1247CC0 Offset: 0x1246EC0 VA: 0x181247CC0
	|-HashSet<Vector3Int>.IntersectWithEnumerable
	|
	|-RVA: 0x1248770 Offset: 0x1247970 VA: 0x181248770
	|-HashSet<__Il2CppFullySharedGenericType>.IntersectWithEnumerable
	|
	|-RVA: 0x1248D00 Offset: 0x1247F00 VA: 0x181248D00
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.IntersectWithEnumerable
	*/

	// RVA: -1 Offset: -1
	private int InternalIndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121C370 Offset: 0x121B570 VA: 0x18121C370
	|-HashSet<AsyncOperationHandle>.InternalIndexOf
	|
	|-RVA: 0x1229900 Offset: 0x1228B00 VA: 0x181229900
	|-HashSet<byte>.InternalIndexOf
	|
	|-RVA: 0x1229A80 Offset: 0x1228C80 VA: 0x181229A80
	|-HashSet<char>.InternalIndexOf
	|
	|-RVA: 0x1229C00 Offset: 0x1228E00 VA: 0x181229C00
	|-HashSet<Edge>.InternalIndexOf
	|
	|-RVA: 0x1229740 Offset: 0x1228940 VA: 0x181229740
	|-HashSet<int>.InternalIndexOf
	|-HashSet<Int32Enum>.InternalIndexOf
	|
	|-RVA: 0x12295C0 Offset: 0x12287C0 VA: 0x1812295C0
	|-HashSet<object>.InternalIndexOf
	|
	|-RVA: 0x1247740 Offset: 0x1246940 VA: 0x181247740
	|-HashSet<ushort>.InternalIndexOf
	|-HashSet<UInt16Enum>.InternalIndexOf
	|
	|-RVA: 0x1247B40 Offset: 0x1246D40 VA: 0x181247B40
	|-HashSet<uint>.InternalIndexOf
	|
	|-RVA: 0x1247910 Offset: 0x1246B10 VA: 0x181247910
	|-HashSet<Vector3Int>.InternalIndexOf
	|
	|-RVA: 0x12473E0 Offset: 0x12465E0 VA: 0x1812473E0
	|-HashSet<__Il2CppFullySharedGenericType>.InternalIndexOf
	|
	|-RVA: 0x1247250 Offset: 0x1246450 VA: 0x181247250
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.InternalIndexOf
	*/

	// RVA: -1 Offset: -1
	private void SymmetricExceptWithUniqueHashSet(HashSet<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121ED20 Offset: 0x121DF20 VA: 0x18121ED20
	|-HashSet<AsyncOperationHandle>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x1237430 Offset: 0x1236630 VA: 0x181237430
	|-HashSet<byte>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x1237750 Offset: 0x1236950 VA: 0x181237750
	|-HashSet<char>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x1237A70 Offset: 0x1236C70 VA: 0x181237A70
	|-HashSet<Edge>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x12372A0 Offset: 0x12364A0 VA: 0x1812372A0
	|-HashSet<int>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x12375C0 Offset: 0x12367C0 VA: 0x1812375C0
	|-HashSet<Int32Enum>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x12378E0 Offset: 0x1236AE0 VA: 0x1812378E0
	|-HashSet<object>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x1255EF0 Offset: 0x12550F0 VA: 0x181255EF0
	|-HashSet<ushort>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x1255D60 Offset: 0x1254F60 VA: 0x181255D60
	|-HashSet<UInt16Enum>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x1255BD0 Offset: 0x1254DD0 VA: 0x181255BD0
	|-HashSet<uint>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x1256080 Offset: 0x1255280 VA: 0x181256080
	|-HashSet<Vector3Int>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x12563D0 Offset: 0x12555D0 VA: 0x1812563D0
	|-HashSet<__Il2CppFullySharedGenericType>.SymmetricExceptWithUniqueHashSet
	|
	|-RVA: 0x1256240 Offset: 0x1255440 VA: 0x181256240
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.SymmetricExceptWithUniqueHashSet
	*/

	// RVA: -1 Offset: -1
	private void SymmetricExceptWithEnumerable(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121E890 Offset: 0x121DA90 VA: 0x18121E890
	|-HashSet<AsyncOperationHandle>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x1235860 Offset: 0x1234A60 VA: 0x181235860
	|-HashSet<byte>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x12369E0 Offset: 0x1235BE0 VA: 0x1812369E0
	|-HashSet<char>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x1235CC0 Offset: 0x1234EC0 VA: 0x181235CC0
	|-HashSet<Edge>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x1236120 Offset: 0x1235320 VA: 0x181236120
	|-HashSet<int>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x1236E40 Offset: 0x1236040 VA: 0x181236E40
	|-HashSet<Int32Enum>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x1236580 Offset: 0x1235780 VA: 0x181236580
	|-HashSet<object>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x1255150 Offset: 0x1254350 VA: 0x181255150
	|-HashSet<ushort>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x1254CF0 Offset: 0x1253EF0 VA: 0x181254CF0
	|-HashSet<UInt16Enum>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x1253FA0 Offset: 0x12531A0 VA: 0x181253FA0
	|-HashSet<uint>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x1254400 Offset: 0x1253600 VA: 0x181254400
	|-HashSet<Vector3Int>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x12555B0 Offset: 0x12547B0 VA: 0x1812555B0
	|-HashSet<__Il2CppFullySharedGenericType>.SymmetricExceptWithEnumerable
	|
	|-RVA: 0x1254890 Offset: 0x1253A90 VA: 0x181254890
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.SymmetricExceptWithEnumerable
	*/

	// RVA: -1 Offset: -1
	private bool AddOrGetLocation(T value, out int location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121A7F0 Offset: 0x12199F0 VA: 0x18121A7F0
	|-HashSet<AsyncOperationHandle>.AddOrGetLocation
	|
	|-RVA: 0x12210F0 Offset: 0x12202F0 VA: 0x1812210F0
	|-HashSet<byte>.AddOrGetLocation
	|
	|-RVA: 0x12219B0 Offset: 0x1220BB0 VA: 0x1812219B0
	|-HashSet<char>.AddOrGetLocation
	|
	|-RVA: 0x1220E40 Offset: 0x1220040 VA: 0x181220E40
	|-HashSet<Edge>.AddOrGetLocation
	|
	|-RVA: 0x12213B0 Offset: 0x12205B0 VA: 0x1812213B0
	|-HashSet<int>.AddOrGetLocation
	|
	|-RVA: 0x12216B0 Offset: 0x12208B0 VA: 0x1812216B0
	|-HashSet<Int32Enum>.AddOrGetLocation
	|
	|-RVA: 0x1221C80 Offset: 0x1220E80 VA: 0x181221C80
	|-HashSet<object>.AddOrGetLocation
	|
	|-RVA: 0x123E180 Offset: 0x123D380 VA: 0x18123E180
	|-HashSet<ushort>.AddOrGetLocation
	|
	|-RVA: 0x123E750 Offset: 0x123D950 VA: 0x18123E750
	|-HashSet<UInt16Enum>.AddOrGetLocation
	|
	|-RVA: 0x123EA60 Offset: 0x123DC60 VA: 0x18123EA60
	|-HashSet<uint>.AddOrGetLocation
	|
	|-RVA: 0x123F2D0 Offset: 0x123E4D0 VA: 0x18123F2D0
	|-HashSet<Vector3Int>.AddOrGetLocation
	|
	|-RVA: 0x123ED20 Offset: 0x123DF20 VA: 0x18123ED20
	|-HashSet<__Il2CppFullySharedGenericType>.AddOrGetLocation
	|
	|-RVA: 0x123E490 Offset: 0x123D690 VA: 0x18123E490
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.AddOrGetLocation
	*/

	// RVA: -1 Offset: -1
	private HashSet.ElementCount<T> CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121AD20 Offset: 0x1219F20 VA: 0x18121AD20
	|-HashSet<AsyncOperationHandle>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x12223B0 Offset: 0x12215B0 VA: 0x1812223B0
	|-HashSet<byte>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1223430 Offset: 0x1222630 VA: 0x181223430
	|-HashSet<char>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1222BF0 Offset: 0x1221DF0 VA: 0x181222BF0
	|-HashSet<Edge>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x12227D0 Offset: 0x12219D0 VA: 0x1812227D0
	|-HashSet<int>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1223010 Offset: 0x1222210 VA: 0x181223010
	|-HashSet<Int32Enum>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1223850 Offset: 0x1222A50 VA: 0x181223850
	|-HashSet<object>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1240020 Offset: 0x123F220 VA: 0x181240020
	|-HashSet<ushort>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1240440 Offset: 0x123F640 VA: 0x181240440
	|-HashSet<UInt16Enum>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x123FC00 Offset: 0x123EE00 VA: 0x18123FC00
	|-HashSet<uint>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1240860 Offset: 0x123FA60 VA: 0x181240860
	|-HashSet<Vector3Int>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1240D20 Offset: 0x123FF20 VA: 0x181240D20
	|-HashSet<__Il2CppFullySharedGenericType>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1241240 Offset: 0x1240440 VA: 0x181241240
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.CheckUniqueAndUnfoundElements
	*/

	// RVA: -1 Offset: -1
	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121ACA0 Offset: 0x1219EA0 VA: 0x18121ACA0
	|-HashSet<AsyncOperationHandle>.AreEqualityComparersEqual
	|-HashSet<byte>.AreEqualityComparersEqual
	|-HashSet<char>.AreEqualityComparersEqual
	|-HashSet<Edge>.AreEqualityComparersEqual
	|-HashSet<int>.AreEqualityComparersEqual
	|-HashSet<Int32Enum>.AreEqualityComparersEqual
	|-HashSet<object>.AreEqualityComparersEqual
	|-HashSet<ushort>.AreEqualityComparersEqual
	|-HashSet<UInt16Enum>.AreEqualityComparersEqual
	|-HashSet<uint>.AreEqualityComparersEqual
	|-HashSet<Vector3Int>.AreEqualityComparersEqual
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.AreEqualityComparersEqual
	|
	|-RVA: 0x123FAF0 Offset: 0x123ECF0 VA: 0x18123FAF0
	|-HashSet<__Il2CppFullySharedGenericType>.AreEqualityComparersEqual
	*/

	// RVA: -1 Offset: -1
	private int InternalGetHashCode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121C290 Offset: 0x121B490 VA: 0x18121C290
	|-HashSet<AsyncOperationHandle>.InternalGetHashCode
	|
	|-RVA: 0x1229220 Offset: 0x1228420 VA: 0x181229220
	|-HashSet<byte>.InternalGetHashCode
	|
	|-RVA: 0x12293C0 Offset: 0x12285C0 VA: 0x1812293C0
	|-HashSet<char>.InternalGetHashCode
	|
	|-RVA: 0x12294F0 Offset: 0x12286F0 VA: 0x1812294F0
	|-HashSet<Edge>.InternalGetHashCode
	|
	|-RVA: 0x1229490 Offset: 0x1228690 VA: 0x181229490
	|-HashSet<int>.InternalGetHashCode
	|-HashSet<Int32Enum>.InternalGetHashCode
	|
	|-RVA: 0x12292F0 Offset: 0x12284F0 VA: 0x1812292F0
	|-HashSet<object>.InternalGetHashCode
	|
	|-RVA: 0x1246D90 Offset: 0x1245F90 VA: 0x181246D90
	|-HashSet<ushort>.InternalGetHashCode
	|-HashSet<UInt16Enum>.InternalGetHashCode
	|
	|-RVA: 0x1246FD0 Offset: 0x12461D0 VA: 0x181246FD0
	|-HashSet<uint>.InternalGetHashCode
	|
	|-RVA: 0x12470A0 Offset: 0x12462A0 VA: 0x1812470A0
	|-HashSet<Vector3Int>.InternalGetHashCode
	|
	|-RVA: 0x1246DF0 Offset: 0x1245FF0 VA: 0x181246DF0
	|-HashSet<__Il2CppFullySharedGenericType>.InternalGetHashCode
	|
	|-RVA: 0x1247180 Offset: 0x1246380 VA: 0x181247180
	|-HashSet<HeliSabotageSystem.ActiveConsoleData>.InternalGetHashCode
	*/
}

// Namespace: System.Collections.Generic
internal sealed class ICollectionDebugView<T> // TypeDefIndex: 15326
{}

// Namespace: System.Threading
public enum LockRecursionPolicy // TypeDefIndex: 15327
{
	// Fields
	public int value__; // 0x0
	public const LockRecursionPolicy NoRecursion = 0;
	public const LockRecursionPolicy SupportsRecursion = 1;
}

// Namespace: System.Threading
internal class ReaderWriterCount // TypeDefIndex: 15328
{
	// Fields
	public long lockID; // 0x10
	public int readercount; // 0x18
	public int writercount; // 0x1C
	public int upgradecount; // 0x20
	public ReaderWriterCount next; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private struct ReaderWriterLockSlim.TimeoutTracker // TypeDefIndex: 15329
{
	// Fields
	private int m_total; // 0x0
	private int m_start; // 0x4

	// Properties
	public int RemainingMilliseconds { get; }
	public bool IsExpired { get; }

	// Methods

	// RVA: 0x1D773E0 Offset: 0x1D765E0 VA: 0x181D773E0
	public void .ctor(int millisecondsTimeout) { }

	// RVA: 0x1D774B0 Offset: 0x1D766B0 VA: 0x181D774B0
	public int get_RemainingMilliseconds() { }

	// RVA: 0x1D77460 Offset: 0x1D76660 VA: 0x181D77460
	public bool get_IsExpired() { }
}

// Namespace: System.Threading
public class ReaderWriterLockSlim : IDisposable // TypeDefIndex: 15330
{
	// Fields
	private bool fIsReentrant; // 0x10
	private int myLock; // 0x14
	private uint numWriteWaiters; // 0x18
	private uint numReadWaiters; // 0x1C
	private uint numWriteUpgradeWaiters; // 0x20
	private uint numUpgradeWaiters; // 0x24
	private bool fNoWaiters; // 0x28
	private int upgradeLockOwnerId; // 0x2C
	private int writeLockOwnerId; // 0x30
	private EventWaitHandle writeEvent; // 0x38
	private EventWaitHandle readEvent; // 0x40
	private EventWaitHandle upgradeEvent; // 0x48
	private EventWaitHandle waitUpgradeEvent; // 0x50
	private static long s_nextLockID; // 0x0
	private long lockID; // 0x58
	[ThreadStatic]
	private static ReaderWriterCount t_rwc; // 0x80000000
	private bool fUpgradeThreadHoldingRead; // 0x60
	private uint owners; // 0x64
	private bool fDisposed; // 0x68

	// Properties
	public bool IsReadLockHeld { get; }
	public bool IsUpgradeableReadLockHeld { get; }
	public bool IsWriteLockHeld { get; }
	public int RecursiveReadCount { get; }
	public int RecursiveUpgradeCount { get; }
	public int RecursiveWriteCount { get; }
	public int WaitingReadCount { get; }
	public int WaitingUpgradeCount { get; }
	public int WaitingWriteCount { get; }

	// Methods

	// RVA: 0x1D75C60 Offset: 0x1D74E60 VA: 0x181D75C60
	private void InitializeThreadCounts() { }

	// RVA: 0x1D76A80 Offset: 0x1D75C80 VA: 0x181D76A80
	public void .ctor() { }

	// RVA: 0x1D76A10 Offset: 0x1D75C10 VA: 0x181D76A10
	public void .ctor(LockRecursionPolicy recursionPolicy) { }

	// RVA: 0x1D75C70 Offset: 0x1D74E70 VA: 0x181D75C70
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	// RVA: 0x1D75CB0 Offset: 0x1D74EB0 VA: 0x181D75CB0
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	// RVA: 0x1D75B40 Offset: 0x1D74D40 VA: 0x181D75B40
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	// RVA: 0x1D75420 Offset: 0x1D74620 VA: 0x181D75420
	public void EnterWriteLock() { }

	// RVA: 0x1D76850 Offset: 0x1D75A50 VA: 0x181D76850
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	// RVA: 0x1D76840 Offset: 0x1D75A40 VA: 0x181D76840
	private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1D76390 Offset: 0x1D75590 VA: 0x181D76390
	private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1D75400 Offset: 0x1D74600 VA: 0x181D75400
	public void EnterUpgradeableReadLock() { }

	// RVA: 0x1D76300 Offset: 0x1D75500 VA: 0x181D76300
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	// RVA: 0x1D762F0 Offset: 0x1D754F0 VA: 0x181D762F0
	private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1D75E90 Offset: 0x1D75090 VA: 0x181D75E90
	private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1D75930 Offset: 0x1D74B30 VA: 0x181D75930
	public void ExitWriteLock() { }

	// RVA: 0x1D75630 Offset: 0x1D74830 VA: 0x181D75630
	public void ExitUpgradeableReadLock() { }

	// RVA: 0x1D75CE0 Offset: 0x1D74EE0 VA: 0x181D75CE0
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	// RVA: 0x1D768E0 Offset: 0x1D75AE0 VA: 0x181D768E0
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter) { }

