	[CompilerGenerated]
	private SocketError <SocketError>k__BackingField; // 0x70
	[CompilerGenerated]
	private SocketFlags <SocketFlags>k__BackingField; // 0x74
	[CompilerGenerated]
	private object <UserToken>k__BackingField; // 0x78
	[CompilerGenerated]
	private EventHandler<SocketAsyncEventArgs> Completed; // 0x80
	private Memory<byte> _buffer; // 0x88
	private int _offset; // 0x98
	private int _count; // 0x9C
	private bool _bufferIsExplicitArray; // 0xA0
	private IList<ArraySegment<byte>> _bufferList; // 0xA8
	private List<ArraySegment<byte>> _bufferListInternal; // 0xB0

	// Properties
	public Exception ConnectByNameError { get; set; }
	public Socket AcceptSocket { get; set; }
	public int BytesTransferred { get; set; }
	public bool DisconnectReuseSocket { get; set; }
	public SocketAsyncOperation LastOperation { get; set; }
	public EndPoint RemoteEndPoint { get; set; }
	public IPPacketInformation ReceiveMessageFromPacketInfo { get; set; }
	public SendPacketsElement[] SendPacketsElements { get; set; }
	public TransmitFileOptions SendPacketsFlags { get; set; }
	[MonoTODO("unused property")]
	public int SendPacketsSendSize { get; set; }
	public SocketError SocketError { get; set; }
	public SocketFlags SocketFlags { get; set; }
	public object UserToken { get; set; }
	public Socket ConnectSocket { get; }
	internal Socket CurrentSocket { get; }
	public byte[] Buffer { get; }
	public Memory<byte> MemoryBuffer { get; }
	public int Offset { get; }
	public int Count { get; }
	public IList<ArraySegment<byte>> BufferList { get; set; }
	internal bool HasMultipleBuffers { get; }
	public SocketClientAccessPolicyProtocol SocketClientAccessPolicyProtocol { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Exception get_ConnectByNameError() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_ConnectByNameError(Exception value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Socket get_AcceptSocket() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_AcceptSocket(Socket value) { }

	[CompilerGenerated]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public int get_BytesTransferred() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	private void set_BytesTransferred(int value) { }

	[CompilerGenerated]
	// RVA: 0x190DB80 Offset: 0x190CD80 VA: 0x18190DB80
	public bool get_DisconnectReuseSocket() { }

	[CompilerGenerated]
	// RVA: 0x190DB90 Offset: 0x190CD90 VA: 0x18190DB90
	public void set_DisconnectReuseSocket(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public SocketAsyncOperation get_LastOperation() { }

	[CompilerGenerated]
	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	private void set_LastOperation(SocketAsyncOperation value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RemoteEndPoint(EndPoint value) { }

	[CompilerGenerated]
	// RVA: 0xC5DC80 Offset: 0xC5CE80 VA: 0x180C5DC80
	public IPPacketInformation get_ReceiveMessageFromPacketInfo() { }

	[CompilerGenerated]
	// RVA: 0x1EAAA00 Offset: 0x1EA9C00 VA: 0x181EAAA00
	private void set_ReceiveMessageFromPacketInfo(IPPacketInformation value) { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public SendPacketsElement[] get_SendPacketsElements() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_SendPacketsElements(SendPacketsElement[] value) { }

	[CompilerGenerated]
	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80
	public TransmitFileOptions get_SendPacketsFlags() { }

	[CompilerGenerated]
	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	public void set_SendPacketsFlags(TransmitFileOptions value) { }

	[CompilerGenerated]
	// RVA: 0x526CA0 Offset: 0x525EA0 VA: 0x180526CA0
	public int get_SendPacketsSendSize() { }

	[CompilerGenerated]
	// RVA: 0x526DA0 Offset: 0x525FA0 VA: 0x180526DA0
	public void set_SendPacketsSendSize(int value) { }

	[CompilerGenerated]
	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	public SocketError get_SocketError() { }

	[CompilerGenerated]
	// RVA: 0x526DC0 Offset: 0x525FC0 VA: 0x180526DC0
	public void set_SocketError(SocketError value) { }

	[CompilerGenerated]
	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90
	public SocketFlags get_SocketFlags() { }

	[CompilerGenerated]
	// RVA: 0x526D90 Offset: 0x525F90 VA: 0x180526D90
	public void set_SocketFlags(SocketFlags value) { }

	[CompilerGenerated]
	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public object get_UserToken() { }

	[CompilerGenerated]
	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	public void set_UserToken(object value) { }

	// RVA: 0x2220090 Offset: 0x221F290 VA: 0x182220090
	public Socket get_ConnectSocket() { }

	[CompilerGenerated]
	// RVA: 0x221FF00 Offset: 0x221F100 VA: 0x18221FF00
	public void add_Completed(EventHandler<SocketAsyncEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x22200E0 Offset: 0x221F2E0 VA: 0x1822200E0
	public void remove_Completed(EventHandler<SocketAsyncEventArgs> value) { }

	// RVA: 0x221FDF0 Offset: 0x221EFF0 VA: 0x18221FDF0
	public void .ctor() { }

	// RVA: 0x221FE80 Offset: 0x221F080 VA: 0x18221FE80
	internal void .ctor(bool flowExecutionContext) { }

	// RVA: 0x221F5E0 Offset: 0x221E7E0 VA: 0x18221F5E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x221F5D0 Offset: 0x221E7D0 VA: 0x18221F5D0
	private void Dispose(bool disposing) { }

	// RVA: 0x221F570 Offset: 0x221E770 VA: 0x18221F570 Slot: 4
	public void Dispose() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void SetConnectByNameError(Exception error) { }

	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	internal void SetBytesTransferred(int value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal Socket get_CurrentSocket() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void SetCurrentSocket(Socket socket) { }

	// RVA: 0x221FB60 Offset: 0x221ED60 VA: 0x18221FB60
	internal void SetLastOperation(SocketAsyncOperation op) { }

	// RVA: 0x221F4E0 Offset: 0x221E6E0 VA: 0x18221F4E0
	internal void Complete_internal() { }

	// RVA: 0x221F6D0 Offset: 0x221E8D0 VA: 0x18221F6D0 Slot: 5
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void StartOperationCommon(Socket socket) { }

	// RVA: 0x221FD20 Offset: 0x221EF20 VA: 0x18221FD20
	internal void StartOperationWrapperConnect(MultipleConnectAsync args) { }

	// RVA: 0x221F620 Offset: 0x221E820 VA: 0x18221F620
	internal void FinishConnectByNameSyncFailure(Exception exception, int bytesTransferred, SocketFlags flags) { }

	// RVA: 0x221F620 Offset: 0x221E820 VA: 0x18221F620
	internal void FinishOperationAsyncFailure(Exception exception, int bytesTransferred, SocketFlags flags) { }

	// RVA: 0x221F680 Offset: 0x221E880 VA: 0x18221F680
	internal void FinishWrapperConnectSuccess(Socket connectSocket, int bytesTransferred, SocketFlags flags) { }

	// RVA: 0x221FC30 Offset: 0x221EE30 VA: 0x18221FC30
	internal void SetResults(SocketError socketError, int bytesTransferred, SocketFlags flags) { }

	// RVA: 0x221FC50 Offset: 0x221EE50 VA: 0x18221FC50
	internal void SetResults(Exception exception, int bytesTransferred, SocketFlags flags) { }

	// RVA: 0x221FFC0 Offset: 0x221F1C0 VA: 0x18221FFC0
	public byte[] get_Buffer() { }

	// RVA: 0x454B20 Offset: 0x453D20 VA: 0x180454B20
	public Memory<byte> get_MemoryBuffer() { }

	// RVA: 0x838410 Offset: 0x837610 VA: 0x180838410
	public int get_Offset() { }

	// RVA: 0x1944140 Offset: 0x1943340 VA: 0x181944140
	public int get_Count() { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public IList<ArraySegment<byte>> get_BufferList() { }

	// RVA: 0x22201A0 Offset: 0x221F3A0 VA: 0x1822201A0
	public void set_BufferList(IList<ArraySegment<byte>> value) { }

	// RVA: 0x221F8D0 Offset: 0x221EAD0 VA: 0x18221F8D0
	public void SetBuffer(int offset, int count) { }

	// RVA: 0x221F520 Offset: 0x221E720 VA: 0x18221F520
	internal void CopyBufferFrom(SocketAsyncEventArgs source) { }

	// RVA: 0x221F700 Offset: 0x221E900 VA: 0x18221F700
	public void SetBuffer(byte[] buffer, int offset, int count) { }

	// RVA: 0x221FA70 Offset: 0x221EC70 VA: 0x18221FA70
	public void SetBuffer(Memory<byte> buffer) { }

	// RVA: 0x1DB4E00 Offset: 0x1DB4000 VA: 0x181DB4E00
	internal bool get_HasMultipleBuffers() { }

	[CompilerGenerated]
	// RVA: 0x22200B0 Offset: 0x221F2B0 VA: 0x1822200B0
	public SocketClientAccessPolicyProtocol get_SocketClientAccessPolicyProtocol() { }

	[CompilerGenerated]
	// RVA: 0x2220510 Offset: 0x221F710 VA: 0x182220510
	public void set_SocketClientAccessPolicyProtocol(SocketClientAccessPolicyProtocol value) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SocketAsyncResult.<>c // TypeDefIndex: 6213
{
	// Fields
	public static readonly SocketAsyncResult.<>c <>9; // 0x0
	public static WaitCallback <>9__27_0; // 0x8

	// Methods

	// RVA: 0x222C7F0 Offset: 0x222B9F0 VA: 0x18222C7F0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2226240 Offset: 0x2225440 VA: 0x182226240
	internal void <Complete>b__27_0(object state) { }
}

// Namespace: System.Net.Sockets
internal sealed class SocketAsyncResult : IOAsyncResult // TypeDefIndex: 6214
{
	// Fields
	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public Memory<byte> Buffer; // 0x50
	public int Offset; // 0x60
	public int Size; // 0x64
	public SocketFlags SockFlags; // 0x68
	public Socket AcceptSocket; // 0x70
	public IPAddress[] Addresses; // 0x78
	public int Port; // 0x80
	public IList<ArraySegment<byte>> Buffers; // 0x88
	public bool ReuseSocket; // 0x90
	public int CurrentAddress; // 0x94
	public Socket AcceptedSocket; // 0x98
	public int Total; // 0xA0
	internal int error; // 0xA4
	public int EndCalled; // 0xA8

	// Properties
	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }

	// Methods

	// RVA: 0x2220A40 Offset: 0x221FC40 VA: 0x182220A40
	public IntPtr get_Handle() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x2220890 Offset: 0x221FA90 VA: 0x182220890
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x2220960 Offset: 0x221FB60 VA: 0x182220960
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x22209A0 Offset: 0x221FBA0 VA: 0x1822209A0
	public SocketError get_ErrorCode() { }

	// RVA: 0x2220540 Offset: 0x221F740 VA: 0x182220540
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x22205F0 Offset: 0x221F7F0 VA: 0x1822205F0 Slot: 8
	internal override void CompleteDisposed() { }

	// RVA: 0x2220670 Offset: 0x221F870 VA: 0x182220670
	public void Complete() { }

	// RVA: 0x2220600 Offset: 0x221F800 VA: 0x182220600
	public void Complete(bool synch) { }

	// RVA: 0x2220650 Offset: 0x221F850 VA: 0x182220650
	public void Complete(int total) { }

	// RVA: 0x2220620 Offset: 0x221F820 VA: 0x182220620
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x2220610 Offset: 0x221F810 VA: 0x182220610
	public void Complete(Exception e) { }

	// RVA: 0x2220660 Offset: 0x221F860 VA: 0x182220660
	public void Complete(Socket s) { }

	// RVA: 0x2220630 Offset: 0x221F830 VA: 0x182220630
	public void Complete(Socket s, int total) { }
}

// Namespace: System.Net.Sockets
internal enum SocketOperation // TypeDefIndex: 6215
{
	// Fields
	public int value__; // 0x0
	public const SocketOperation Accept = 0;
	public const SocketOperation Connect = 1;
	public const SocketOperation Receive = 2;
	public const SocketOperation ReceiveFrom = 3;
	public const SocketOperation Send = 4;
	public const SocketOperation SendTo = 5;
	public const SocketOperation RecvJustCallback = 6;
	public const SocketOperation SendJustCallback = 7;
	public const SocketOperation Disconnect = 8;
	public const SocketOperation AcceptReceive = 9;
	public const SocketOperation ReceiveGeneric = 10;
	public const SocketOperation SendGeneric = 11;
}

// Namespace: System.Net.Sockets
public struct SocketReceiveFromResult // TypeDefIndex: 6216
{
	// Fields
	public int ReceivedBytes; // 0x0
	public EndPoint RemoteEndPoint; // 0x8
}

// Namespace: System.Net.Sockets
public struct SocketReceiveMessageFromResult // TypeDefIndex: 6217
{
	// Fields
	public int ReceivedBytes; // 0x0
	public SocketFlags SocketFlags; // 0x4
	public EndPoint RemoteEndPoint; // 0x8
	public IPPacketInformation PacketInformation; // 0x10
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SocketTaskExtensions.<>c // TypeDefIndex: 6218
{
	// Fields
	public static readonly SocketTaskExtensions.<>c <>9; // 0x0
	public static Func<AsyncCallback, object, IAsyncResult> <>9__0_0; // 0x8
	public static Func<IAsyncResult, Socket> <>9__0_1; // 0x10
	public static Func<Socket, int, AsyncCallback, object, IAsyncResult> <>9__1_0; // 0x18
	public static Func<IAsyncResult, Socket> <>9__1_1; // 0x20
	public static Func<EndPoint, AsyncCallback, object, IAsyncResult> <>9__2_0; // 0x28
	public static Action<IAsyncResult> <>9__2_1; // 0x30
	public static Func<IPAddress, int, AsyncCallback, object, IAsyncResult> <>9__3_0; // 0x38
	public static Action<IAsyncResult> <>9__3_1; // 0x40
	public static Func<IPAddress[], int, AsyncCallback, object, IAsyncResult> <>9__4_0; // 0x48
	public static Action<IAsyncResult> <>9__4_1; // 0x50
	public static Func<string, int, AsyncCallback, object, IAsyncResult> <>9__5_0; // 0x58
	public static Action<IAsyncResult> <>9__5_1; // 0x60
	public static Func<ArraySegment<byte>, SocketFlags, AsyncCallback, object, IAsyncResult> <>9__6_0; // 0x68
	public static Func<IAsyncResult, int> <>9__6_1; // 0x70
	public static Func<IList<ArraySegment<byte>>, SocketFlags, AsyncCallback, object, IAsyncResult> <>9__7_0; // 0x78
	public static Func<IAsyncResult, int> <>9__7_1; // 0x80
	public static Func<ArraySegment<byte>, SocketFlags, AsyncCallback, object, IAsyncResult> <>9__8_0; // 0x88
	public static Func<IAsyncResult, SocketReceiveFromResult> <>9__8_1; // 0x90
	public static Func<ArraySegment<byte>, AsyncCallback, object, IAsyncResult> <>9__9_0; // 0x98
	public static Func<IAsyncResult, SocketReceiveMessageFromResult> <>9__9_1; // 0xA0
	public static Func<ArraySegment<byte>, SocketFlags, AsyncCallback, object, IAsyncResult> <>9__10_0; // 0xA8
	public static Func<IAsyncResult, int> <>9__10_1; // 0xB0
	public static Func<IList<ArraySegment<byte>>, SocketFlags, AsyncCallback, object, IAsyncResult> <>9__11_0; // 0xB8
	public static Func<IAsyncResult, int> <>9__11_1; // 0xC0
	public static Func<ArraySegment<byte>, SocketFlags, EndPoint, AsyncCallback, object, IAsyncResult> <>9__12_0; // 0xC8
	public static Func<IAsyncResult, int> <>9__12_1; // 0xD0

	// Methods

	// RVA: 0x222C850 Offset: 0x222BA50 VA: 0x18222C850
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2225D10 Offset: 0x2224F10 VA: 0x182225D10
	internal IAsyncResult <AcceptAsync>b__0_0(AsyncCallback callback, object state) { }

	// RVA: 0x2225DF0 Offset: 0x2224FF0 VA: 0x182225DF0
	internal Socket <AcceptAsync>b__0_1(IAsyncResult asyncResult) { }

	// RVA: 0x2225EF0 Offset: 0x22250F0 VA: 0x182225EF0
	internal IAsyncResult <AcceptAsync>b__1_0(Socket socketForAccept, int receiveSize, AsyncCallback callback, object state) { }

	// RVA: 0x2225FF0 Offset: 0x22251F0 VA: 0x182225FF0
	internal Socket <AcceptAsync>b__1_1(IAsyncResult asyncResult) { }

	// RVA: 0x22268D0 Offset: 0x2225AD0 VA: 0x1822268D0
	internal IAsyncResult <ConnectAsync>b__2_0(EndPoint targetEndPoint, AsyncCallback callback, object state) { }

	// RVA: 0x22269D0 Offset: 0x2225BD0 VA: 0x1822269D0
	internal void <ConnectAsync>b__2_1(IAsyncResult asyncResult) { }

	// RVA: 0x2226AD0 Offset: 0x2225CD0 VA: 0x182226AD0
	internal IAsyncResult <ConnectAsync>b__3_0(IPAddress targetAddress, int targetPort, AsyncCallback callback, object state) { }

	// RVA: 0x2226BD0 Offset: 0x2225DD0 VA: 0x182226BD0
	internal void <ConnectAsync>b__3_1(IAsyncResult asyncResult) { }

	// RVA: 0x2226CD0 Offset: 0x2225ED0 VA: 0x182226CD0
	internal IAsyncResult <ConnectAsync>b__4_0(IPAddress[] targetAddresses, int targetPort, AsyncCallback callback, object state) { }

	// RVA: 0x2226DD0 Offset: 0x2225FD0 VA: 0x182226DD0
	internal void <ConnectAsync>b__4_1(IAsyncResult asyncResult) { }

	// RVA: 0x2226ED0 Offset: 0x22260D0 VA: 0x182226ED0
	internal IAsyncResult <ConnectAsync>b__5_0(string targetHost, int targetPort, AsyncCallback callback, object state) { }

	// RVA: 0x2226FD0 Offset: 0x22261D0 VA: 0x182226FD0
	internal void <ConnectAsync>b__5_1(IAsyncResult asyncResult) { }

	// RVA: 0x2227D00 Offset: 0x2226F00 VA: 0x182227D00
	internal IAsyncResult <ReceiveAsync>b__6_0(ArraySegment<byte> targetBuffer, SocketFlags flags, AsyncCallback callback, object state) { }

	// RVA: 0x2227E50 Offset: 0x2227050 VA: 0x182227E50
	internal int <ReceiveAsync>b__6_1(IAsyncResult asyncResult) { }

	// RVA: 0x2227F50 Offset: 0x2227150 VA: 0x182227F50
	internal IAsyncResult <ReceiveAsync>b__7_0(IList<ArraySegment<byte>> targetBuffers, SocketFlags flags, AsyncCallback callback, object state) { }

	// RVA: 0x2228050 Offset: 0x2227250 VA: 0x182228050
	internal int <ReceiveAsync>b__7_1(IAsyncResult asyncResult) { }

	// RVA: 0x2228370 Offset: 0x2227570 VA: 0x182228370
	internal IAsyncResult <ReceiveFromAsync>b__8_0(ArraySegment<byte> targetBuffer, SocketFlags flags, AsyncCallback callback, object state) { }

	// RVA: 0x22285C0 Offset: 0x22277C0 VA: 0x1822285C0
	internal SocketReceiveFromResult <ReceiveFromAsync>b__8_1(IAsyncResult asyncResult) { }

	// RVA: 0x2228A10 Offset: 0x2227C10 VA: 0x182228A10
	internal IAsyncResult <ReceiveMessageFromAsync>b__9_0(ArraySegment<byte> targetBuffer, AsyncCallback callback, object state) { }

	// RVA: 0x2228CB0 Offset: 0x2227EB0 VA: 0x182228CB0
	internal SocketReceiveMessageFromResult <ReceiveMessageFromAsync>b__9_1(IAsyncResult asyncResult) { }

	// RVA: 0x22296A0 Offset: 0x22288A0 VA: 0x1822296A0
	internal IAsyncResult <SendAsync>b__10_0(ArraySegment<byte> targetBuffer, SocketFlags flags, AsyncCallback callback, object state) { }

	// RVA: 0x22297F0 Offset: 0x22289F0 VA: 0x1822297F0
	internal int <SendAsync>b__10_1(IAsyncResult asyncResult) { }

	// RVA: 0x22298F0 Offset: 0x2228AF0 VA: 0x1822298F0
	internal IAsyncResult <SendAsync>b__11_0(IList<ArraySegment<byte>> targetBuffers, SocketFlags flags, AsyncCallback callback, object state) { }

	// RVA: 0x22299F0 Offset: 0x2228BF0 VA: 0x1822299F0
	internal int <SendAsync>b__11_1(IAsyncResult asyncResult) { }

	// RVA: 0x2229C10 Offset: 0x2228E10 VA: 0x182229C10
	internal IAsyncResult <SendToAsync>b__12_0(ArraySegment<byte> targetBuffer, SocketFlags flags, EndPoint endPoint, AsyncCallback callback, object state) { }

	// RVA: 0x2229D80 Offset: 0x2228F80 VA: 0x182229D80
	internal int <SendToAsync>b__12_1(IAsyncResult asyncResult) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SocketTaskExtensions.<>c__DisplayClass14_0 // TypeDefIndex: 6219
{
	// Fields
	public CancellationToken cancellationToken; // 0x10
	public byte[] buffer; // 0x18
	public Memory<byte> memory; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x222C180 Offset: 0x222B380 VA: 0x18222C180
	internal void <ReceiveAsync>b__0(IAsyncResult iar) { }
}

// Namespace: System.Net.Sockets
[Extension]
public static class SocketTaskExtensions // TypeDefIndex: 6220
{
	// Methods

	[Extension]
	// RVA: 0x2220C80 Offset: 0x221FE80 VA: 0x182220C80
	public static Task<Socket> AcceptAsync(Socket socket) { }

	[Extension]
	// RVA: 0x2220E60 Offset: 0x2220060 VA: 0x182220E60
	public static Task<Socket> AcceptAsync(Socket socket, Socket acceptSocket) { }

	[Extension]
	// RVA: 0x22214D0 Offset: 0x22206D0 VA: 0x1822214D0
	public static Task ConnectAsync(Socket socket, EndPoint remoteEP) { }

	[Extension]
	// RVA: 0x2221290 Offset: 0x2220490 VA: 0x182221290
	public static Task ConnectAsync(Socket socket, IPAddress address, int port) { }

	[Extension]
	// RVA: 0x2221050 Offset: 0x2220250 VA: 0x182221050
	public static Task ConnectAsync(Socket socket, IPAddress[] addresses, int port) { }

	[Extension]
	// RVA: 0x22216F0 Offset: 0x22208F0 VA: 0x1822216F0
	public static Task ConnectAsync(Socket socket, string host, int port) { }

	[Extension]
	// RVA: 0x2221B30 Offset: 0x2220D30 VA: 0x182221B30
	public static Task<int> ReceiveAsync(Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags) { }

	[Extension]
	// RVA: 0x2221930 Offset: 0x2220B30 VA: 0x182221930
	public static Task<int> ReceiveAsync(Socket socket, IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	[Extension]
	// RVA: 0x2221F40 Offset: 0x2221140 VA: 0x182221F40
	public static Task<SocketReceiveFromResult> ReceiveFromAsync(Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint) { }

	[Extension]
	// RVA: 0x2222200 Offset: 0x2221400 VA: 0x182222200
	public static Task<SocketReceiveMessageFromResult> ReceiveMessageFromAsync(Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint) { }

	[Extension]
	// RVA: 0x2222780 Offset: 0x2221980 VA: 0x182222780
	public static Task<int> SendAsync(Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags) { }

	[Extension]
	// RVA: 0x2222510 Offset: 0x2221710 VA: 0x182222510
	public static Task<int> SendAsync(Socket socket, IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	[Extension]
	// RVA: 0x2222990 Offset: 0x2221B90 VA: 0x182222990
	public static Task<int> SendToAsync(Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEP) { }

	[Extension]
	// RVA: 0x2222720 Offset: 0x2221920 VA: 0x182222720
	public static ValueTask<int> SendAsync(Socket socket, ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x2221D40 Offset: 0x2220F40 VA: 0x182221D40
	public static ValueTask<int> ReceiveAsync(Socket socket, Memory<byte> memory, SocketFlags socketFlags, CancellationToken cancellationToken) { }
}

// Namespace: System.Net.Mime
internal static class MailBnfHelper // TypeDefIndex: 6221
{
	// Fields
	internal static readonly bool[] Atext; // 0x0
	internal static readonly bool[] Qtext; // 0x8
	internal static readonly bool[] Dtext; // 0x10
	internal static readonly bool[] Ftext; // 0x18
	internal static readonly bool[] Ttext; // 0x20
	internal static readonly bool[] Ctext; // 0x28
	internal static readonly int Ascii7bitMaxValue; // 0x30
	internal static readonly char Quote; // 0x34
	internal static readonly char Space; // 0x36
	internal static readonly char Tab; // 0x38
	internal static readonly char CR; // 0x3A
	internal static readonly char LF; // 0x3C
	internal static readonly char StartComment; // 0x3E
	internal static readonly char EndComment; // 0x40
	internal static readonly char Backslash; // 0x42
	internal static readonly char At; // 0x44
	internal static readonly char EndAngleBracket; // 0x46
	internal static readonly char StartAngleBracket; // 0x48
	internal static readonly char StartSquareBracket; // 0x4A
	internal static readonly char EndSquareBracket; // 0x4C
	internal static readonly char Comma; // 0x4E
	internal static readonly char Dot; // 0x50
	private static readonly char[] s_colonSeparator; // 0x58
	private static string[] s_months; // 0x60

	// Methods

	// RVA: 0x2218FE0 Offset: 0x22181E0 VA: 0x182218FE0
	private static bool[] CreateCharactersAllowedInAtoms() { }

	// RVA: 0x2219420 Offset: 0x2218620 VA: 0x182219420
	private static bool[] CreateCharactersAllowedInQuotedStrings() { }

	// RVA: 0x22192A0 Offset: 0x22184A0 VA: 0x1822192A0
	private static bool[] CreateCharactersAllowedInDomainLiterals() { }

	// RVA: 0x2219390 Offset: 0x2218590 VA: 0x182219390
	private static bool[] CreateCharactersAllowedInHeaderNames() { }

	// RVA: 0x2219510 Offset: 0x2218710 VA: 0x182219510
	private static bool[] CreateCharactersAllowedInTokens() { }

	// RVA: 0x2219190 Offset: 0x2218390 VA: 0x182219190
	private static bool[] CreateCharactersAllowedInComments() { }

	// RVA: 0x221A740 Offset: 0x2219940 VA: 0x18221A740
	internal static bool SkipCFWS(string data, ref int offset) { }

	// RVA: 0x221A950 Offset: 0x2219B50 VA: 0x18221A950
	internal static void ValidateHeaderName(string data) { }

	// RVA: 0x221A490 Offset: 0x2219690 VA: 0x18221A490
	internal static string ReadQuotedString(string data, ref int offset, StringBuilder builder) { }

	// RVA: 0x221A000 Offset: 0x2219200 VA: 0x18221A000
	internal static string ReadQuotedString(string data, ref int offset, StringBuilder builder, bool doesntRequireQuotes, bool permitUnicodeInDisplayName) { }

	// RVA: 0x2219F70 Offset: 0x2219170 VA: 0x182219F70
	internal static string ReadParameterAttribute(string data, ref int offset, StringBuilder builder) { }

	// RVA: 0x221A510 Offset: 0x2219710 VA: 0x18221A510
	internal static string ReadToken(string data, ref int offset, StringBuilder builder) { }

	// RVA: 0x2219630 Offset: 0x2218830 VA: 0x182219630
	internal static string GetDateTimeString(DateTime value, StringBuilder builder) { }

	// RVA: 0x2219A00 Offset: 0x2218C00 VA: 0x182219A00
	internal static void GetTokenOrQuotedString(string data, StringBuilder builder, bool allowUnicode) { }

	// RVA: 0x2218EF0 Offset: 0x22180F0 VA: 0x182218EF0
	private static bool CheckForUnicode(char ch, bool allowUnicode) { }

	// RVA: 0x2219D30 Offset: 0x2218F30 VA: 0x182219D30
	internal static bool IsAllowedWhiteSpace(char c) { }

	// RVA: 0x2219CC0 Offset: 0x2218EC0 VA: 0x182219CC0
	internal static bool HasCROrLF(string data) { }

	// RVA: 0x2219E00 Offset: 0x2219000 VA: 0x182219E00
	internal static bool IsFWSAt(string data, int index) { }

	// RVA: 0x221AAF0 Offset: 0x2219CF0 VA: 0x18221AAF0
	private static void .cctor() { }
}

// Namespace: System.Net.Mime
internal class Base64WriteStateInfo : WriteStateInfoBase // TypeDefIndex: 6222
{
	// Fields
	[CompilerGenerated]
	private int <Padding>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <LastBits>k__BackingField; // 0x3C

	// Properties
	internal int Padding { get; set; }
	internal byte LastBits { get; set; }

	// Methods

	// RVA: 0x2212E70 Offset: 0x2212070 VA: 0x182212E70
	internal void .ctor() { }

	// RVA: 0x2212E80 Offset: 0x2212080 VA: 0x182212E80
	internal void .ctor(int bufferSize, byte[] header, byte[] footer, int maxLineLength, int mimeHeaderLength) { }

	[CompilerGenerated]
	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	internal int get_Padding() { }

	[CompilerGenerated]
	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	internal void set_Padding(int value) { }

	[CompilerGenerated]
	// RVA: 0x691760 Offset: 0x690960 VA: 0x180691760
	internal byte get_LastBits() { }

	[CompilerGenerated]
	// RVA: 0xC6E640 Offset: 0xC6D840 VA: 0x180C6E640
	internal void set_LastBits(byte value) { }
}

// Namespace: System.Net.Mime
internal abstract class BaseWriter // TypeDefIndex: 6223
{
	// Fields
	private const int DefaultLineLength = 76;
	private static readonly AsyncCallback s_onWrite; // 0x0
	protected static readonly byte[] s_crlf; // 0x8
	protected readonly BufferBuilder _bufferBuilder; // 0x10
	protected readonly Stream _stream; // 0x18
	private readonly EventHandler _onCloseHandler; // 0x20
	private readonly bool _shouldEncodeLeadingDots; // 0x28
	private int _lineLength; // 0x2C
	protected Stream _contentStream; // 0x30
	protected bool _isInContent; // 0x38

	// Methods

	// RVA: 0x2213A50 Offset: 0x2212C50 VA: 0x182213A50
	protected void .ctor(Stream stream, bool shouldEncodeLeadingDots) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void WriteHeaders(NameValueCollection headers, bool allowUnicode);

	// RVA: 0x2213770 Offset: 0x2212970 VA: 0x182213770
	internal void WriteHeader(string name, string value, bool allowUnicode) { }

	// RVA: 0x2213530 Offset: 0x2212730 VA: 0x182213530
	private void WriteAndFold(string value, int charsAlreadyOnLine, bool allowUnicode) { }

	// RVA: 0x22133B0 Offset: 0x22125B0 VA: 0x1822133B0
	internal Stream GetContentStream() { }

	// RVA: 0x2213230 Offset: 0x2212430 VA: 0x182213230
	private Stream GetContentStream(MultiAsyncResult multiResult) { }

	// RVA: 0x2212E90 Offset: 0x2212090 VA: 0x182212E90
	internal IAsyncResult BeginGetContentStream(AsyncCallback callback, object state) { }

	// RVA: 0x2212FA0 Offset: 0x22121A0 VA: 0x182212FA0
	internal Stream EndGetContentStream(IAsyncResult result) { }

	// RVA: 0x2213090 Offset: 0x2212290 VA: 0x182213090
	protected void Flush(MultiAsyncResult multiResult) { }

	// RVA: 0x22133C0 Offset: 0x22125C0 VA: 0x1822133C0
	protected static void OnWrite(IAsyncResult result) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void Close();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnClose(object sender, EventArgs args);

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	protected virtual void CheckBoundary() { }

	// RVA: 0x2213980 Offset: 0x2212B80 VA: 0x182213980
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ContentDisposition.<>c // TypeDefIndex: 6224
{
	// Fields
	public static readonly ContentDisposition.<>c <>9; // 0x0

	// Methods

	// RVA: 0x222C730 Offset: 0x222B930 VA: 0x18222C730
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x222BFF0 Offset: 0x222B1F0 VA: 0x18222BFF0
	internal object <.cctor>b__49_0(object v) { }

	// RVA: 0x222C070 Offset: 0x222B270 VA: 0x18222C070
	internal object <.cctor>b__49_1(object value) { }
}

// Namespace: System.Net.Mime
public class ContentDisposition // TypeDefIndex: 6225
{
	// Fields
	private const string CreationDateKey = "creation-date";
	private const string ModificationDateKey = "modification-date";
	private const string ReadDateKey = "read-date";
	private const string FileNameKey = "filename";
	private const string SizeKey = "size";
	private TrackingValidationObjectDictionary _parameters; // 0x10
	private string _disposition; // 0x18
	private string _dispositionType; // 0x20
	private bool _isChanged; // 0x28
	private bool _isPersisted; // 0x29
	private static readonly TrackingValidationObjectDictionary.ValidateAndParseValue s_dateParser; // 0x0
	private static readonly TrackingValidationObjectDictionary.ValidateAndParseValue s_longParser; // 0x8
	private static readonly Dictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue> s_validators; // 0x10

	// Properties
	public string DispositionType { get; set; }
	public StringDictionary Parameters { get; }
	public string FileName { get; set; }
	public DateTime CreationDate { get; set; }
	public DateTime ModificationDate { get; set; }
	public bool Inline { get; set; }
	public DateTime ReadDate { get; set; }
	public long Size { get; set; }
	internal bool IsChanged { get; }

	// Methods

	// RVA: 0x2214D60 Offset: 0x2213F60 VA: 0x182214D60
	public void .ctor() { }

	// RVA: 0x2214CD0 Offset: 0x2213ED0 VA: 0x182214CD0
	public void .ctor(string disposition) { }

	// RVA: 0x22141A0 Offset: 0x22133A0 VA: 0x1822141A0
	internal DateTime GetDateParameter(string parameterName) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_DispositionType() { }

	// RVA: 0x2215180 Offset: 0x2214380 VA: 0x182215180
	public void set_DispositionType(string value) { }

	// RVA: 0x2214EF0 Offset: 0x22140F0 VA: 0x182214EF0
	public StringDictionary get_Parameters() { }

	// RVA: 0x2214DF0 Offset: 0x2213FF0 VA: 0x182214DF0
	public string get_FileName() { }

	// RVA: 0x2215290 Offset: 0x2214490 VA: 0x182215290
	public void set_FileName(string value) { }

	// RVA: 0x2214DB0 Offset: 0x2213FB0 VA: 0x182214DB0
	public DateTime get_CreationDate() { }

	// RVA: 0x22150B0 Offset: 0x22142B0 VA: 0x1822150B0
	public void set_CreationDate(DateTime value) { }

	// RVA: 0x2214EB0 Offset: 0x22140B0 VA: 0x182214EB0
	public DateTime get_ModificationDate() { }

	// RVA: 0x22153A0 Offset: 0x22145A0 VA: 0x1822153A0
	public void set_ModificationDate(DateTime value) { }

	// RVA: 0x2214E50 Offset: 0x2214050 VA: 0x182214E50
	public bool get_Inline() { }

	// RVA: 0x2215340 Offset: 0x2214540 VA: 0x182215340
	public void set_Inline(bool value) { }

	// RVA: 0x2214FA0 Offset: 0x22141A0 VA: 0x182214FA0
	public DateTime get_ReadDate() { }

	// RVA: 0x2215470 Offset: 0x2214670 VA: 0x182215470
	public void set_ReadDate(DateTime value) { }

	// RVA: 0x2214FE0 Offset: 0x22141E0 VA: 0x182214FE0
	public long get_Size() { }

	// RVA: 0x2215540 Offset: 0x2214740 VA: 0x182215540
	public void set_Size(long value) { }

	// RVA: 0x2214980 Offset: 0x2213B80 VA: 0x182214980
	internal void Set(string contentDisposition, HeaderCollection headers) { }

	// RVA: 0x22148B0 Offset: 0x2213AB0 VA: 0x1822148B0
	internal void PersistIfNeeded(HeaderCollection headers, bool forcePersist) { }

	// RVA: 0x2214E90 Offset: 0x2214090 VA: 0x182214E90
	internal bool get_IsChanged() { }

	// RVA: 0x2214A30 Offset: 0x2213C30 VA: 0x182214A30 Slot: 3
	public override string ToString() { }

	// RVA: 0x2213DF0 Offset: 0x2212FF0 VA: 0x182213DF0
	internal string Encode(bool allowUnicode) { }

	// RVA: 0x2213B50 Offset: 0x2212D50 VA: 0x182213B50
	private static void EncodeToBuffer(string value, StringBuilder builder, bool allowUnicode) { }

	// RVA: 0x2214130 Offset: 0x2213330 VA: 0x182214130 Slot: 0
	public override bool Equals(object rparam) { }

	// RVA: 0x22142D0 Offset: 0x22134D0 VA: 0x1822142D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2214320 Offset: 0x2213520 VA: 0x182214320
	private void ParseValue() { }

	// RVA: 0x2214A90 Offset: 0x2213C90 VA: 0x182214A90
	private static void .cctor() { }
}

// Namespace: System.Net.Mime
public class ContentType // TypeDefIndex: 6226
{
	// Fields
	private readonly TrackingStringDictionary _parameters; // 0x10
	private string _mediaType; // 0x18
	private string _subType; // 0x20
	private bool _isChanged; // 0x28
	private string _type; // 0x30
	private bool _isPersisted; // 0x38
	internal const string Default = "application/octet-stream";

	// Properties
	public string Boundary { get; set; }
	public string CharSet { get; set; }
	public string MediaType { get; set; }
	public string Name { get; set; }
	public StringDictionary Parameters { get; }
	internal bool IsChanged { get; }

	// Methods

	// RVA: 0x2216210 Offset: 0x2215410 VA: 0x182216210
	public void .ctor() { }

	// RVA: 0x22163A0 Offset: 0x22155A0 VA: 0x1822163A0
	public void .ctor(string contentType) { }

	// RVA: 0x2216510 Offset: 0x2215710 VA: 0x182216510
	public string get_Boundary() { }

	// RVA: 0x22166F0 Offset: 0x22158F0 VA: 0x1822166F0
	public void set_Boundary(string value) { }

	// RVA: 0x2216570 Offset: 0x2215770 VA: 0x182216570
	public string get_CharSet() { }

	// RVA: 0x22167C0 Offset: 0x22159C0 VA: 0x1822167C0
	public void set_CharSet(string value) { }

	// RVA: 0x22165F0 Offset: 0x22157F0 VA: 0x1822165F0
	public string get_MediaType() { }

	// RVA: 0x2216890 Offset: 0x2215A90 VA: 0x182216890
	public void set_MediaType(string value) { }

	// RVA: 0x2216640 Offset: 0x2215840 VA: 0x182216640
	public string get_Name() { }

	// RVA: 0x2216B00 Offset: 0x2215D00 VA: 0x182216B00
	public void set_Name(string value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public StringDictionary get_Parameters() { }

	// RVA: 0x2216100 Offset: 0x2215300 VA: 0x182216100
	internal void Set(string contentType, HeaderCollection headers) { }

	// RVA: 0x2216030 Offset: 0x2215230 VA: 0x182216030
	internal void PersistIfNeeded(HeaderCollection headers, bool forcePersist) { }

	// RVA: 0x22165D0 Offset: 0x22157D0 VA: 0x1822165D0
	internal bool get_IsChanged() { }

	// RVA: 0x22161B0 Offset: 0x22153B0 VA: 0x1822161B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x22158A0 Offset: 0x2214AA0 VA: 0x1822158A0
	internal string Encode(bool allowUnicode) { }

	// RVA: 0x2215600 Offset: 0x2214800 VA: 0x182215600
	private static void EncodeToBuffer(string value, StringBuilder builder, bool allowUnicode) { }

	// RVA: 0x2214130 Offset: 0x2213330 VA: 0x182214130 Slot: 0
	public override bool Equals(object rparam) { }

	// RVA: 0x22142D0 Offset: 0x22134D0 VA: 0x1822142D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2215BD0 Offset: 0x2214DD0 VA: 0x182215BD0
	private void ParseValue() { }
}

// Namespace: System.Net.Mime
public static class DispositionTypeNames // TypeDefIndex: 6227
{
	// Fields
	public const string Inline = "inline";
	public const string Attachment = "attachment";
}

// Namespace: System.Net.Mime
internal class EightBitStream : DelegatedStream, IEncodableStream // TypeDefIndex: 6228
{
	// Fields
	private WriteStateInfoBase _writeState; // 0x38
	private bool _shouldEncodeLeadingDots; // 0x40

	// Properties
	private WriteStateInfoBase WriteState { get; }

	// Methods

	// RVA: 0x22171B0 Offset: 0x22163B0 VA: 0x1822171B0
	private WriteStateInfoBase get_WriteState() { }

	// RVA: 0x2217170 Offset: 0x2216370 VA: 0x182217170
	internal void .ctor(Stream stream) { }

	// RVA: 0x2217180 Offset: 0x2216380 VA: 0x182217180
	internal void .ctor(Stream stream, bool shouldEncodeLeadingDots) { }

	// RVA: 0x2216BD0 Offset: 0x2215DD0 VA: 0x182216BD0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2216F10 Offset: 0x2216110 VA: 0x182216F10 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2216FD0 Offset: 0x22161D0 VA: 0x182216FD0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2216DD0 Offset: 0x2215FD0 VA: 0x182216DD0
	private void EncodeLines(byte[] buffer, int offset, int count) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 43
	public Stream GetStream() { }

	// RVA: 0x2216D50 Offset: 0x2215F50 VA: 0x182216D50 Slot: 40
	public int DecodeBytes(byte[] buffer, int offset, int count) { }

	// RVA: 0x2216D90 Offset: 0x2215F90 VA: 0x182216D90 Slot: 41
	public int EncodeBytes(byte[] buffer, int offset, int count) { }

	// RVA: 0x2216F90 Offset: 0x2216190 VA: 0x182216F90 Slot: 42
	public string GetEncodedString() { }
}

// Namespace: System.Net.Mime
internal class EncodedStreamFactory // TypeDefIndex: 6229
{
	// Fields
	internal const int DefaultMaxLineLength = 70;
	private const int InitialBufferSize = 1024;

	// Methods

	// RVA: 0x2217600 Offset: 0x2216800 VA: 0x182217600
	internal IEncodableStream GetEncoder(TransferEncoding encoding, Stream stream) { }

	// RVA: 0x2217360 Offset: 0x2216560 VA: 0x182217360
	internal IEncodableStream GetEncoderForHeader(Encoding encoding, bool useBase64Encoding, int headerTextLength) { }

	// RVA: 0x2217270 Offset: 0x2216470 VA: 0x182217270
	protected byte[] CreateHeader(Encoding encoding, bool useBase64Encoding) { }

	// RVA: 0x2217210 Offset: 0x2216410 VA: 0x182217210
	protected byte[] CreateFooter() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net.Mime
internal class HeaderCollection : NameValueCollection // TypeDefIndex: 6230
{
	// Fields
	private MimeBasePart _part; // 0x68

	// Methods

	// RVA: 0x2218A00 Offset: 0x2217C00 VA: 0x182218A00
	internal void .ctor() { }

	// RVA: 0x22182A0 Offset: 0x22174A0 VA: 0x1822182A0 Slot: 22
	public override void Remove(string name) { }

	// RVA: 0x2217F90 Offset: 0x2217190 VA: 0x182217F90 Slot: 19
	public override string Get(string name) { }

	// RVA: 0x2217D30 Offset: 0x2216F30 VA: 0x182217D30 Slot: 20
	public override string[] GetValues(string name) { }

	// RVA: 0x2218280 Offset: 0x2217480 VA: 0x182218280
	internal void InternalRemove(string name) { }

	// RVA: 0x2218290 Offset: 0x2217490 VA: 0x182218290
	internal void InternalSet(string name, string value) { }

	// RVA: 0x22181F0 Offset: 0x22173F0 VA: 0x1822181F0
	internal void InternalAdd(string name, string value) { }

	// RVA: 0x2218530 Offset: 0x2217730 VA: 0x182218530 Slot: 21
	public override void Set(string name, string value) { }

	// RVA: 0x2217750 Offset: 0x2216950 VA: 0x182217750 Slot: 18
	public override void Add(string name, string value) { }
}

// Namespace: System.Net.Mime
internal interface IEncodableStream // TypeDefIndex: 6231
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int DecodeBytes(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int EncodeBytes(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetEncodedString();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Stream GetStream();
}

// Namespace: 
public static class MediaTypeNames.Text // TypeDefIndex: 6232
{
	// Fields
	public const string Plain = "text/plain";
	public const string Html = "text/html";
	public const string Xml = "text/xml";
	public const string RichText = "text/richtext";
}

// Namespace: 
public static class MediaTypeNames.Application // TypeDefIndex: 6233
{
	// Fields
	public const string Soap = "application/soap+xml";
	public const string Octet = "application/octet-stream";
	public const string Rtf = "application/rtf";
	public const string Pdf = "application/pdf";
	public const string Zip = "application/zip";
	public const string Json = "application/json";
	public const string Xml = "application/xml";
}

// Namespace: 
public static class MediaTypeNames.Image // TypeDefIndex: 6234
{
	// Fields
	public const string Gif = "image/gif";
	public const string Tiff = "image/tiff";
	public const string Jpeg = "image/jpeg";
}

// Namespace: System.Net.Mime
public static class MediaTypeNames // TypeDefIndex: 6235
{}

// Namespace: 
internal class MimeBasePart.MimePartAsyncResult : LazyAsyncResult // TypeDefIndex: 6236
{
	// Methods

	// RVA: 0x221E180 Offset: 0x221D380 VA: 0x18221E180
	internal void .ctor(MimeBasePart part, object state, AsyncCallback callback) { }
}

// Namespace: System.Net.Mime
internal class MimeBasePart // TypeDefIndex: 6237
{
	// Fields
	internal const string DefaultCharSet = "utf-8";
	private static readonly char[] s_decodeEncodingSplitChars; // 0x0
	protected ContentType _contentType; // 0x10
	protected ContentDisposition _contentDisposition; // 0x18
	private HeaderCollection _headers; // 0x20
	private static readonly char[] s_headerValueSplitChars; // 0x8
	private static readonly char[] s_questionMarkSplitChars; // 0x10

	// Properties
	internal string ContentID { get; set; }
	internal string ContentLocation { get; set; }
	internal NameValueCollection Headers { get; }
	internal ContentType ContentType { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x221C040 Offset: 0x221B240 VA: 0x18221C040
	internal static bool ShouldUseBase64Encoding(Encoding encoding) { }

	// RVA: 0x221B7D0 Offset: 0x221A9D0 VA: 0x18221B7D0
	internal static string EncodeHeaderValue(string value, Encoding encoding, bool base64Encoding) { }

	// RVA: 0x221B850 Offset: 0x221AA50 VA: 0x18221B850
	internal static string EncodeHeaderValue(string value, Encoding encoding, bool base64Encoding, int headerLength) { }

	// RVA: 0x221B4A0 Offset: 0x221A6A0 VA: 0x18221B4A0
	internal static string DecodeHeaderValue(string value) { }

	// RVA: 0x221B3A0 Offset: 0x221A5A0 VA: 0x18221B3A0
	internal static Encoding DecodeEncoding(string value) { }

	// RVA: 0x221BD30 Offset: 0x221AF30 VA: 0x18221BD30
	internal static bool IsAscii(string value, bool permitCROrLF) { }

	// RVA: 0x221C190 Offset: 0x221B390 VA: 0x18221C190
	internal string get_ContentID() { }

	// RVA: 0x221C430 Offset: 0x221B630 VA: 0x18221C430
	internal void set_ContentID(string value) { }

	// RVA: 0x221C210 Offset: 0x221B410 VA: 0x18221C210
	internal string get_ContentLocation() { }

	// RVA: 0x221C510 Offset: 0x221B710 VA: 0x18221C510
	internal void set_ContentLocation(string value) { }

	// RVA: 0x221C2F0 Offset: 0x221B4F0 VA: 0x18221C2F0
	internal NameValueCollection get_Headers() { }

	// RVA: 0x221C290 Offset: 0x221B490 VA: 0x18221C290
	internal ContentType get_ContentType() { }

	// RVA: 0x221C5F0 Offset: 0x221B7F0 VA: 0x18221C5F0
	internal void set_ContentType(ContentType value) { }

	// RVA: 0x221BDF0 Offset: 0x221AFF0 VA: 0x18221BDF0
	internal void PrepareHeaders(bool allowUnicode) { }

	// RVA: 0x221C000 Offset: 0x221B200 VA: 0x18221C000 Slot: 4
	internal virtual void Send(BaseWriter writer, bool allowUnicode) { }

	// RVA: 0x221B360 Offset: 0x221A560 VA: 0x18221B360 Slot: 5
	internal virtual IAsyncResult BeginSend(BaseWriter writer, AsyncCallback callback, bool allowUnicode, object state) { }

	// RVA: 0x221BAB0 Offset: 0x221ACB0 VA: 0x18221BAB0
	internal void EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x221C090 Offset: 0x221B290 VA: 0x18221C090
	private static void .cctor() { }
}

// Namespace: 
internal class MimeMultiPart.MimePartContext // TypeDefIndex: 6238
{
	// Fields
	internal IEnumerator<MimeBasePart> _partsEnumerator; // 0x10
	internal Stream _outputStream; // 0x18
	internal LazyAsyncResult _result; // 0x20
	internal BaseWriter _writer; // 0x28
	internal bool _completed; // 0x30
	internal bool _completedSynchronously; // 0x31

	// Methods

	// RVA: 0x2238CA0 Offset: 0x2237EA0 VA: 0x182238CA0
	internal void .ctor(BaseWriter writer, LazyAsyncResult result, IEnumerator<MimeBasePart> partsEnumerator) { }
}

// Namespace: System.Net.Mime
internal class MimeMultiPart : MimeBasePart // TypeDefIndex: 6239
{
	// Fields
	private Collection<MimeBasePart> _parts; // 0x28
	private static int s_boundary; // 0x0
	private AsyncCallback _mimePartSentCallback; // 0x30
	private bool _allowUnicode; // 0x38

	// Properties
	internal MimeMultiPartType MimeMultiPartType { set; }
	internal Collection<MimeBasePart> Parts { get; }

	// Methods

	// RVA: 0x221DF80 Offset: 0x221D180 VA: 0x18221DF80
	internal void .ctor(MimeMultiPartType type) { }

	// RVA: 0x221E0E0 Offset: 0x221D2E0 VA: 0x18221E0E0
	internal void set_MimeMultiPartType(MimeMultiPartType value) { }

	// RVA: 0x221DC70 Offset: 0x221CE70 VA: 0x18221DC70
	private void SetType(MimeMultiPartType type) { }

	// RVA: 0x221E060 Offset: 0x221D260 VA: 0x18221E060
	internal Collection<MimeBasePart> get_Parts() { }

	// RVA: 0x221C960 Offset: 0x221BB60 VA: 0x18221C960
	internal void Complete(IAsyncResult result, Exception e) { }

	// RVA: 0x221D7B0 Offset: 0x221C9B0 VA: 0x18221D7B0
	internal void MimeWriterCloseCallback(IAsyncResult result) { }

	// RVA: 0x221D5E0 Offset: 0x221C7E0 VA: 0x18221D5E0
	private void MimeWriterCloseCallbackHandler(IAsyncResult result) { }

	// RVA: 0x221D480 Offset: 0x221C680 VA: 0x18221D480
	internal void MimePartSentCallback(IAsyncResult result) { }

	// RVA: 0x221D190 Offset: 0x221C390 VA: 0x18221D190
	private void MimePartSentCallbackHandler(IAsyncResult result) { }

	// RVA: 0x221CF40 Offset: 0x221C140 VA: 0x18221CF40
	internal void ContentStreamCallback(IAsyncResult result) { }

	// RVA: 0x221CA90 Offset: 0x221BC90 VA: 0x18221CA90
	private void ContentStreamCallbackHandler(IAsyncResult result) { }

	// RVA: 0x221C6F0 Offset: 0x221B8F0 VA: 0x18221C6F0 Slot: 5
	internal override IAsyncResult BeginSend(BaseWriter writer, AsyncCallback callback, bool allowUnicode, object state) { }

	// RVA: 0x221D910 Offset: 0x221CB10 VA: 0x18221D910 Slot: 4
	internal override void Send(BaseWriter writer, bool allowUnicode) { }

	// RVA: 0x221D0A0 Offset: 0x221C2A0 VA: 0x18221D0A0
	internal string GetNextBoundary() { }
}

// Namespace: System.Net.Mime
internal enum MimeMultiPartType // TypeDefIndex: 6240
{
	// Fields
	public int value__; // 0x0
	public const MimeMultiPartType Mixed = 0;
	public const MimeMultiPartType Alternative = 1;
	public const MimeMultiPartType Parallel = 2;
	public const MimeMultiPartType Related = 3;
	public const MimeMultiPartType Unknown = -1;
}

// Namespace: 
internal class MimePart.MimePartContext // TypeDefIndex: 6241
{
	// Fields
	internal Stream _outputStream; // 0x10
	internal LazyAsyncResult _result; // 0x18
	internal int _bytesLeft; // 0x20
	internal BaseWriter _writer; // 0x28
	internal byte[] _buffer; // 0x30
	internal bool _completed; // 0x38
	internal bool _completedSynchronously; // 0x39

	// Methods

	// RVA: 0x2238C30 Offset: 0x2237E30 VA: 0x182238C30
	internal void .ctor(BaseWriter writer, LazyAsyncResult result) { }
}

// Namespace: System.Net.Mime
internal class MimePart : MimeBasePart, IDisposable // TypeDefIndex: 6242
{
	// Fields
	private Stream _stream; // 0x28
	private bool _streamSet; // 0x30
	private bool _streamUsedOnce; // 0x31
	private AsyncCallback _readCallback; // 0x38
	private AsyncCallback _writeCallback; // 0x40
	private const int maxBufferSize = 17408;

	// Properties
	internal Stream Stream { get; }
	internal ContentDisposition ContentDisposition { get; set; }
	internal TransferEncoding TransferEncoding { get; set; }

	// Methods

	// RVA: 0x2239F60 Offset: 0x2239160 VA: 0x182239F60
	internal void .ctor() { }

	// RVA: 0x2239330 Offset: 0x2238530 VA: 0x182239330 Slot: 6
	public void Dispose() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal Stream get_Stream() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal ContentDisposition get_ContentDisposition() { }

	// RVA: 0x223A150 Offset: 0x2239350 VA: 0x18223A150
	internal void set_ContentDisposition(ContentDisposition value) { }

	// RVA: 0x2239FB0 Offset: 0x22391B0 VA: 0x182239FB0
	internal TransferEncoding get_TransferEncoding() { }

	// RVA: 0x223A340 Offset: 0x2239540 VA: 0x18223A340
	internal void set_TransferEncoding(TransferEncoding value) { }

	// RVA: 0x22399A0 Offset: 0x2238BA0 VA: 0x1822399A0
	internal void SetContent(Stream stream) { }

	// RVA: 0x2239B10 Offset: 0x2238D10 VA: 0x182239B10
	internal void SetContent(Stream stream, string name, string mimeType) { }

	// RVA: 0x2239A50 Offset: 0x2238C50 VA: 0x182239A50
	internal void SetContent(Stream stream, ContentType contentType) { }

	// RVA: 0x2238EC0 Offset: 0x22380C0 VA: 0x182238EC0
	internal void Complete(IAsyncResult result, Exception e) { }

	// RVA: 0x2239620 Offset: 0x2238820 VA: 0x182239620
	internal void ReadCallback(IAsyncResult result) { }

	// RVA: 0x22394A0 Offset: 0x22386A0 VA: 0x1822394A0
	internal void ReadCallbackHandler(IAsyncResult result) { }

	// RVA: 0x2239E00 Offset: 0x2239000 VA: 0x182239E00
	internal void WriteCallback(IAsyncResult result) { }

	// RVA: 0x2239CA0 Offset: 0x2238EA0 VA: 0x182239CA0
	internal void WriteCallbackHandler(IAsyncResult result) { }

	// RVA: 0x2239350 Offset: 0x2238550 VA: 0x182239350
	internal Stream GetEncodedStream(Stream stream) { }

	// RVA: 0x2238FF0 Offset: 0x22381F0 VA: 0x182238FF0
	internal void ContentStreamCallbackHandler(IAsyncResult result) { }

	// RVA: 0x22391D0 Offset: 0x22383D0 VA: 0x1822391D0
	internal void ContentStreamCallback(IAsyncResult result) { }

	// RVA: 0x2238CF0 Offset: 0x2237EF0 VA: 0x182238CF0 Slot: 5
	internal override IAsyncResult BeginSend(BaseWriter writer, AsyncCallback callback, bool allowUnicode, object state) { }

	// RVA: 0x2239830 Offset: 0x2238A30 VA: 0x182239830 Slot: 4
	internal override void Send(BaseWriter writer, bool allowUnicode) { }

	// RVA: 0x2239780 Offset: 0x2238980 VA: 0x182239780
	internal void ResetStream() { }
}

// Namespace: System.Net.Mime
internal class MimeWriter : BaseWriter // TypeDefIndex: 6243
{
	// Fields
	private static byte[] s_DASHDASH; // 0x0
	private byte[] _boundaryBytes; // 0x40
	private bool _writeBoundary; // 0x48

	// Methods

	// RVA: 0x22432B0 Offset: 0x22424B0 VA: 0x1822432B0
	internal void .ctor(Stream stream, string boundary) { }

	// RVA: 0x2242FD0 Offset: 0x22421D0 VA: 0x182242FD0 Slot: 4
	internal override void WriteHeaders(NameValueCollection headers, bool allowUnicode) { }

	// RVA: 0x22429B0 Offset: 0x2241BB0 VA: 0x1822429B0
	internal IAsyncResult BeginClose(AsyncCallback callback, object state) { }

	// RVA: 0x2242EE0 Offset: 0x22420E0 VA: 0x182242EE0
	internal void EndClose(IAsyncResult result) { }

	// RVA: 0x2242EA0 Offset: 0x22420A0 VA: 0x182242EA0 Slot: 5
	internal override void Close() { }

	// RVA: 0x2242C60 Offset: 0x2241E60 VA: 0x182242C60
	private void Close(MultiAsyncResult multiResult) { }

	// RVA: 0x2242F80 Offset: 0x2242180 VA: 0x182242F80 Slot: 6
	protected override void OnClose(object sender, EventArgs args) { }

	// RVA: 0x2242A70 Offset: 0x2241C70 VA: 0x182242A70 Slot: 7
	protected override void CheckBoundary() { }

	// RVA: 0x2243230 Offset: 0x2242430 VA: 0x182243230
	private static void .cctor() { }
}

// Namespace: System.Net.Mime
internal sealed class MultiAsyncResult : LazyAsyncResult // TypeDefIndex: 6244
{
	// Fields
	private readonly object _context; // 0x48
	private int _outstanding; // 0x50

	// Properties
	internal object Context { get; }

	// Methods

	// RVA: 0x22434B0 Offset: 0x22426B0 VA: 0x1822434B0
	internal void .ctor(object context, AsyncCallback callback, object state) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal object get_Context() { }

	// RVA: 0x2243460 Offset: 0x2242660 VA: 0x182243460
	internal void Enter() { }

	// RVA: 0x22433A0 Offset: 0x22425A0 VA: 0x1822433A0
	internal void Leave() { }

	// RVA: 0x2243470 Offset: 0x2242670 VA: 0x182243470
	internal void Leave(object result) { }

	// RVA: 0x22433A0 Offset: 0x22425A0 VA: 0x1822433A0
	private void Decrement() { }

	// RVA: 0x2243460 Offset: 0x2242660 VA: 0x182243460
	private void Increment() { }

	// RVA: 0x22433A0 Offset: 0x22425A0 VA: 0x1822433A0
	internal void CompleteSequence() { }

	// RVA: 0x22433E0 Offset: 0x22425E0 VA: 0x1822433E0
	internal static object End(IAsyncResult result) { }
}

// Namespace: 
private sealed class QEncodedStream.ReadStateInfo // TypeDefIndex: 6245
{
	// Fields
	[CompilerGenerated]
	private bool <IsEscaped>k__BackingField; // 0x10
	[CompilerGenerated]
	private short <Byte>k__BackingField; // 0x12

	// Properties
	internal bool IsEscaped { get; set; }
	internal short Byte { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	internal bool get_IsEscaped() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void set_IsEscaped(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B6EE50 Offset: 0x1B6E050 VA: 0x181B6EE50
	internal short get_Byte() { }

	[CompilerGenerated]
	// RVA: 0x1B6EE40 Offset: 0x1B6E040 VA: 0x181B6EE40
	internal void set_Byte(short value) { }

	// RVA: 0x2246240 Offset: 0x2245440 VA: 0x182246240
	public void .ctor() { }
}

// Namespace: 
private class QEncodedStream.WriteAsyncResult : LazyAsyncResult // TypeDefIndex: 6246
{
	// Fields
	private static readonly AsyncCallback s_onWrite; // 0x0
	private readonly QEncodedStream _parent; // 0x48
	private readonly byte[] _buffer; // 0x50
	private readonly int _offset; // 0x58
	private readonly int _count; // 0x5C
	private int _written; // 0x60

	// Methods

	// RVA: 0x214BF00 Offset: 0x214B100 VA: 0x18214BF00
	internal void .ctor(QEncodedStream parent, byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x224F8B0 Offset: 0x224EAB0 VA: 0x18224F8B0
	private void CompleteWrite(IAsyncResult result) { }

	// RVA: 0x224F910 Offset: 0x224EB10 VA: 0x18224F910
	internal static void End(IAsyncResult result) { }

	// RVA: 0x224FB90 Offset: 0x224ED90 VA: 0x18224FB90
	private static void OnWrite(IAsyncResult result) { }

	// RVA: 0x224FD00 Offset: 0x224EF00 VA: 0x18224FD00
	internal void Write() { }

	// RVA: 0x2250240 Offset: 0x224F440 VA: 0x182250240
	private static void .cctor() { }
}

// Namespace: System.Net.Mime
internal class QEncodedStream : DelegatedStream, IEncodableStream // TypeDefIndex: 6247
{
	// Fields
	private const int SizeOfFoldingCRLF = 3;
	private static readonly byte[] s_hexDecodeMap; // 0x0
	private static readonly byte[] s_hexEncodeMap; // 0x8
	private QEncodedStream.ReadStateInfo _readState; // 0x38
	private WriteStateInfoBase _writeState; // 0x40

	// Properties
	private QEncodedStream.ReadStateInfo ReadState { get; }
	internal WriteStateInfoBase WriteState { get; }

	// Methods

	// RVA: 0x22446C0 Offset: 0x22438C0 VA: 0x1822446C0
	internal void .ctor(WriteStateInfoBase wsi) { }

	// RVA: 0x2244730 Offset: 0x2243930 VA: 0x182244730
	private QEncodedStream.ReadStateInfo get_ReadState() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal WriteStateInfoBase get_WriteState() { }

	// RVA: 0x22434F0 Offset: 0x22426F0 VA: 0x1822434F0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x22436A0 Offset: 0x22428A0 VA: 0x1822436A0 Slot: 20
	public override void Close() { }

	// RVA: 0x2243700 Offset: 0x2242900 VA: 0x182243700 Slot: 40
	public int DecodeBytes(byte[] buffer, int offset, int count) { }

	// RVA: 0x2243E20 Offset: 0x2243020 VA: 0x182243E20 Slot: 41
	public int EncodeBytes(byte[] buffer, int offset, int count) { }

	// RVA: 0x22443C0 Offset: 0x22435C0 VA: 0x1822443C0
	private static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x220A250 Offset: 0x2209450 VA: 0x18220A250
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 43
	public Stream GetStream() { }

	// RVA: 0x2137AE0 Offset: 0x2136CE0 VA: 0x182137AE0 Slot: 42
	public string GetEncodedString() { }

	// RVA: 0x2244200 Offset: 0x2243400 VA: 0x182244200 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2244360 Offset: 0x2243560 VA: 0x182244360 Slot: 22
	public override void Flush() { }

	// RVA: 0x2244310 Offset: 0x2243510 VA: 0x182244310
	private void FlushInternal() { }

	// RVA: 0x2244440 Offset: 0x2243640 VA: 0x182244440 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2244600 Offset: 0x2243800 VA: 0x182244600
	private static void .cctor() { }
}

// Namespace: 
private sealed class QuotedPrintableStream.ReadStateInfo // TypeDefIndex: 6248
{
	// Fields
	[CompilerGenerated]
	private bool <IsEscaped>k__BackingField; // 0x10
	[CompilerGenerated]
	private short <Byte>k__BackingField; // 0x12

	// Properties
	internal bool IsEscaped { get; set; }
	internal short Byte { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	internal bool get_IsEscaped() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void set_IsEscaped(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B6EE50 Offset: 0x1B6E050 VA: 0x181B6EE50
	internal short get_Byte() { }

	[CompilerGenerated]
	// RVA: 0x1B6EE40 Offset: 0x1B6E040 VA: 0x181B6EE40
	internal void set_Byte(short value) { }

	// RVA: 0x2246240 Offset: 0x2245440 VA: 0x182246240
	public void .ctor() { }
}

// Namespace: 
private sealed class QuotedPrintableStream.WriteAsyncResult : LazyAsyncResult // TypeDefIndex: 6249
{
	// Fields
	private readonly QuotedPrintableStream _parent; // 0x48
	private readonly byte[] _buffer; // 0x50
	private readonly int _offset; // 0x58
	private readonly int _count; // 0x5C
	private static readonly AsyncCallback s_onWrite; // 0x0
	private int _written; // 0x60

	// Methods

	// RVA: 0x214BF00 Offset: 0x214B100 VA: 0x18214BF00
	internal void .ctor(QuotedPrintableStream parent, byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x224F850 Offset: 0x224EA50 VA: 0x18224F850
	private void CompleteWrite(IAsyncResult result) { }

	// RVA: 0x224F9E0 Offset: 0x224EBE0 VA: 0x18224F9E0
	internal static void End(IAsyncResult result) { }

	// RVA: 0x224FA50 Offset: 0x224EC50 VA: 0x18224FA50
	private static void OnWrite(IAsyncResult result) { }

	// RVA: 0x224FF50 Offset: 0x224F150 VA: 0x18224FF50
	internal void Write() { }

	// RVA: 0x22501C0 Offset: 0x224F3C0 VA: 0x1822501C0
	private static void .cctor() { }
}

// Namespace: System.Net.Mime
internal class QuotedPrintableStream : DelegatedStream, IEncodableStream // TypeDefIndex: 6250
{
	// Fields
	private bool _encodeCRLF; // 0x38
	private const int SizeOfSoftCRLF = 3;
	private const int SizeOfEncodedChar = 3;
	private const int SizeOfEncodedCRLF = 6;
	private const int SizeOfNonEncodedCRLF = 2;
	private static readonly byte[] s_hexDecodeMap; // 0x0
	private static readonly byte[] s_hexEncodeMap; // 0x8
	private int _lineLength; // 0x3C
	private QuotedPrintableStream.ReadStateInfo _readState; // 0x40
	private WriteStateInfoBase _writeState; // 0x48

	// Properties
	private QuotedPrintableStream.ReadStateInfo ReadState { get; }
	internal WriteStateInfoBase WriteState { get; }

	// Methods

	// RVA: 0x2245C10 Offset: 0x2244E10 VA: 0x182245C10
	internal void .ctor(Stream stream, int lineLength) { }

	// RVA: 0x2245BE0 Offset: 0x2244DE0 VA: 0x182245BE0
	internal void .ctor(Stream stream, bool encodeCRLF) { }

	// RVA: 0x2245C90 Offset: 0x2244E90 VA: 0x182245C90
	private QuotedPrintableStream.ReadStateInfo get_ReadState() { }

	// RVA: 0x2245D00 Offset: 0x2244F00 VA: 0x182245D00
	internal WriteStateInfoBase get_WriteState() { }

	// RVA: 0x2244A30 Offset: 0x2243C30 VA: 0x182244A30 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2244BE0 Offset: 0x2243DE0 VA: 0x182244BE0 Slot: 20
	public override void Close() { }

	// RVA: 0x2244C00 Offset: 0x2243E00 VA: 0x182244C00 Slot: 40
	public int DecodeBytes(byte[] buffer, int offset, int count) { }

	// RVA: 0x2245310 Offset: 0x2244510 VA: 0x182245310 Slot: 41
	public int EncodeBytes(byte[] buffer, int offset, int count) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 43
	public Stream GetStream() { }

	// RVA: 0x2245920 Offset: 0x2244B20 VA: 0x182245920 Slot: 42
	public string GetEncodedString() { }

	// RVA: 0x22457E0 Offset: 0x22449E0 VA: 0x1822457E0 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2245900 Offset: 0x2244B00 VA: 0x182245900 Slot: 22
	public override void Flush() { }

	// RVA: 0x2245880 Offset: 0x2244A80 VA: 0x182245880
	private void FlushInternal() { }

	// RVA: 0x22459A0 Offset: 0x2244BA0 VA: 0x1822459A0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2245B20 Offset: 0x2244D20 VA: 0x182245B20
	private static void .cctor() { }
}

// Namespace: System.Net.Mime
internal class SmtpDateTime // TypeDefIndex: 6251
{
	// Fields
	internal const string UnknownTimeZoneDefaultOffset = "-0000";
	internal const string UtcDefaultTimeZoneOffset = "+0000";
	internal const int OffsetLength = 5;
	internal const int MaxMinuteValue = 59;
	internal const string DateFormatWithDayOfWeek = "ddd, dd MMM yyyy HH:mm:ss";
	internal const string DateFormatWithoutDayOfWeek = "dd MMM yyyy HH:mm:ss";
	internal const string DateFormatWithDayOfWeekAndNoSeconds = "ddd, dd MMM yyyy HH:mm";
	internal const string DateFormatWithoutDayOfWeekAndNoSeconds = "dd MMM yyyy HH:mm";
	internal static readonly string[] s_validDateTimeFormats; // 0x0
	internal static readonly char[] s_allowedWhiteSpaceChars; // 0x8
	internal static readonly Dictionary<string, TimeSpan> s_timeZoneOffsetLookup; // 0x10
	internal const long TimeSpanMaxTicks = 3599400000000;
	internal const int OffsetMaxValue = 9959;
	private readonly DateTime _date; // 0x10
	private readonly TimeSpan _timeZone; // 0x18
	private readonly bool _unknownTimeZone; // 0x20

	// Properties
	internal DateTime Date { get; }

	// Methods

	// RVA: 0x224D710 Offset: 0x224C910 VA: 0x18224D710
	internal static Dictionary<string, TimeSpan> InitializeShortHandLookups() { }

	// RVA: 0x224EF40 Offset: 0x224E140 VA: 0x18224EF40
	internal void .ctor(DateTime value) { }

	// RVA: 0x224EAA0 Offset: 0x224DCA0 VA: 0x18224EAA0
	internal void .ctor(string value) { }

	// RVA: 0x224F190 Offset: 0x224E390 VA: 0x18224F190
	internal DateTime get_Date() { }

	// RVA: 0x224DFC0 Offset: 0x224D1C0 VA: 0x18224DFC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x224E600 Offset: 0x224D800 VA: 0x18224E600
	internal void ValidateAndGetTimeZoneOffsetValues(string offset, out bool positive, out int hours, out int minutes) { }

	// RVA: 0x224E860 Offset: 0x224DA60 VA: 0x18224E860
	internal void ValidateTimeZoneShortHandValue(string value) { }

	// RVA: 0x224D680 Offset: 0x224C880 VA: 0x18224D680
	internal string FormatDate(DateTime value) { }

	// RVA: 0x224DA40 Offset: 0x224CC40 VA: 0x18224DA40
	internal DateTime ParseValue(string data, out string timeZone) { }

	// RVA: 0x224E250 Offset: 0x224D450 VA: 0x18224E250
	internal bool TryParseTimeZoneString(string timeZoneString, out TimeSpan timeZone) { }

	// RVA: 0x224E4C0 Offset: 0x224D6C0 VA: 0x18224E4C0
	internal TimeSpan ValidateAndGetSanitizedTimeSpan(TimeSpan span) { }

	// RVA: 0x224DE10 Offset: 0x224D010 VA: 0x18224DE10
	internal string TimeSpanToOffset(TimeSpan span) { }

	// RVA: 0x224E940 Offset: 0x224DB40 VA: 0x18224E940
	private static void .cctor() { }
}

// Namespace: System.Net.Mime
public enum TransferEncoding // TypeDefIndex: 6252
{
	// Fields
	public int value__; // 0x0
	public const TransferEncoding Unknown = -1;
	public const TransferEncoding QuotedPrintable = 0;
	public const TransferEncoding Base64 = 1;
	public const TransferEncoding SevenBit = 2;
	public const TransferEncoding EightBit = 3;
}

// Namespace: System.Net.Mime
internal class WriteStateInfoBase // TypeDefIndex: 6253
{
	// Fields
	protected readonly byte[] _header; // 0x10
	protected readonly byte[] _footer; // 0x18
	protected readonly int _maxLineLength; // 0x20
	protected byte[] _buffer; // 0x28
	protected int _currentLineLength; // 0x30
	protected int _currentBufferUsed; // 0x34
	protected const int DefaultBufferSize = 1024;

	// Properties
	internal int FooterLength { get; }
	internal byte[] Footer { get; }
	internal byte[] Header { get; }
	internal byte[] Buffer { get; }
	internal int Length { get; }
	internal int CurrentLineLength { get; }
	internal int MaxLineLength { get; }

	// Methods

	// RVA: 0x2250790 Offset: 0x224F990 VA: 0x182250790
	internal void .ctor() { }

	// RVA: 0x2250670 Offset: 0x224F870 VA: 0x182250670
	internal void .ctor(int bufferSize, byte[] header, byte[] footer, int maxLineLength) { }

	// RVA: 0x2250700 Offset: 0x224F900 VA: 0x182250700
	internal void .ctor(int bufferSize, byte[] header, byte[] footer, int maxLineLength, int mimeHeaderLength) { }

	// RVA: 0xBED310 Offset: 0xBEC510 VA: 0x180BED310
	internal int get_FooterLength() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal byte[] get_Footer() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal byte[] get_Header() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal byte[] get_Buffer() { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	internal int get_Length() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	internal int get_CurrentLineLength() { }

	// RVA: 0x22505D0 Offset: 0x224F7D0 VA: 0x1822505D0
	private void EnsureSpaceInBuffer(int moreBytes) { }

	// RVA: 0x2250500 Offset: 0x224F700 VA: 0x182250500
	internal void Append(byte aByte) { }

	// RVA: 0x2250560 Offset: 0x224F760 VA: 0x182250560
	internal void Append(byte[] bytes) { }

	// RVA: 0x22502C0 Offset: 0x224F4C0 VA: 0x1822502C0
	internal void AppendCRLF(bool includeSpace) { }

	// RVA: 0x22504A0 Offset: 0x224F6A0 VA: 0x1822504A0
	internal void AppendHeader() { }

	// RVA: 0x2250440 Offset: 0x224F640 VA: 0x182250440
	internal void AppendFooter() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal int get_MaxLineLength() { }

	// RVA: 0x2250660 Offset: 0x224F860 VA: 0x182250660
	internal void Reset() { }

	// RVA: 0x22505C0 Offset: 0x224F7C0 VA: 0x1822505C0
	internal void BufferFlushed() { }
}

// Namespace: System.Net.Mail
internal static class DomainLiteralReader // TypeDefIndex: 6254
{
	// Methods

	// RVA: 0x22330D0 Offset: 0x22322D0 VA: 0x1822330D0
	internal static int ReadReverse(string data, int index) { }
}

// Namespace: System.Net.Mail
internal static class DotAtomReader // TypeDefIndex: 6255
{
	// Methods

	// RVA: 0x2233370 Offset: 0x2232570 VA: 0x182233370
	internal static int ReadReverse(string data, int index) { }
}

// Namespace: System.Net.Mail
internal static class MailAddressParser // TypeDefIndex: 6256
{
	// Methods

	// RVA: 0x2235090 Offset: 0x2234290 VA: 0x182235090
	internal static MailAddress ParseAddress(string data) { }

	// RVA: 0x22359B0 Offset: 0x2234BB0 VA: 0x1822359B0
	internal static List<MailAddress> ParseMultipleAddresses(string data) { }

	// RVA: 0x2234B70 Offset: 0x2233D70 VA: 0x182234B70
	private static MailAddress ParseAddress(string data, bool expectMultipleAddresses, ref int index) { }

	// RVA: 0x2235A70 Offset: 0x2234C70 VA: 0x182235A70
	private static int ReadCfwsAndThrowIfIncomplete(string data, int index) { }

	// RVA: 0x22354F0 Offset: 0x22346F0 VA: 0x1822354F0
	private static string ParseDomain(string data, ref int index) { }

	// RVA: 0x2235680 Offset: 0x2234880 VA: 0x182235680
	private static string ParseLocalPart(string data, ref int index, bool expectAngleBracket, bool expectMultipleAddresses) { }

	// RVA: 0x22350C0 Offset: 0x22342C0 VA: 0x1822350C0
	private static string ParseDisplayName(string data, ref int index, bool expectMultipleAddresses) { }

	// RVA: 0x2234AE0 Offset: 0x2233CE0 VA: 0x182234AE0
	internal static string NormalizeOrThrow(string input) { }
}

// Namespace: System.Net.Mail
internal static class QuotedPairReader // TypeDefIndex: 6257
{
	// Methods

	// RVA: 0x2244840 Offset: 0x2243A40 VA: 0x182244840
	internal static int CountQuotedChars(string data, int index, bool permitUnicodeEscaping) { }

	// RVA: 0x22447A0 Offset: 0x22439A0 VA: 0x1822447A0
	private static int CountBackslashes(string data, int index) { }
}

// Namespace: System.Net.Mail
internal static class QuotedStringFormatReader // TypeDefIndex: 6258
{
	// Methods

	// RVA: 0x2245E60 Offset: 0x2245060 VA: 0x182245E60
	internal static int ReadReverseQuoted(string data, int index, bool permitUnicode) { }

	// RVA: 0x22460A0 Offset: 0x22452A0 VA: 0x1822460A0
	internal static int ReadReverseUnQuoted(string data, int index, bool permitUnicode, bool expectCommaDelimiter) { }

	// RVA: 0x2245DB0 Offset: 0x2244FB0 VA: 0x182245DB0
	private static bool IsValidQtext(bool allowUnicode, char ch) { }
}

// Namespace: System.Net.Mail
internal static class WhitespaceReader // TypeDefIndex: 6259
{
	// Methods

	// RVA: 0x224F600 Offset: 0x224E800 VA: 0x18224F600
	internal static int ReadFwsReverse(string data, int index) { }

	// RVA: 0x224F250 Offset: 0x224E450 VA: 0x18224F250
	internal static int ReadCfwsReverse(string data, int index) { }
}

// Namespace: System.Net.Mail
internal sealed class BufferBuilder // TypeDefIndex: 6260
{
	// Fields
	private byte[] _buffer; // 0x10
	private int _offset; // 0x18

	// Properties
	internal int Length { get; }

	// Methods

	// RVA: 0x2233080 Offset: 0x2232280 VA: 0x182233080
	internal void .ctor() { }

	// RVA: 0x2233020 Offset: 0x2232220 VA: 0x182233020
	internal void .ctor(int initialSize) { }

	// RVA: 0x2232F70 Offset: 0x2232170 VA: 0x182232F70
	private void EnsureBuffer(int count) { }

	// RVA: 0x2232CD0 Offset: 0x2231ED0 VA: 0x182232CD0
	internal void Append(byte value) { }

	// RVA: 0x2232AD0 Offset: 0x2231CD0 VA: 0x182232AD0
	internal void Append(byte[] value) { }

	// RVA: 0x2232D30 Offset: 0x2231F30 VA: 0x182232D30
	internal void Append(byte[] value, int offset, int count) { }

	// RVA: 0x2232A70 Offset: 0x2231C70 VA: 0x182232A70
	internal void Append(string value) { }

	// RVA: 0x2232C60 Offset: 0x2231E60 VA: 0x182232C60
	internal void Append(string value, bool allowUnicode) { }

	// RVA: 0x2232DA0 Offset: 0x2231FA0 VA: 0x182232DA0
	internal void Append(string value, int offset, int count, bool allowUnicode) { }

	// RVA: 0x2232B30 Offset: 0x2231D30 VA: 0x182232B30
	internal void Append(string value, int offset, int count) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	internal int get_Length() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal byte[] GetBuffer() { }

	// RVA: 0x2233010 Offset: 0x2232210 VA: 0x182233010
	internal void Reset() { }
}

// Namespace: System.Net.Mail
public class MailAddress // TypeDefIndex: 6261
{
	// Fields
	private readonly Encoding _displayNameEncoding; // 0x10
	private readonly string _displayName; // 0x18
	private readonly string _userName; // 0x20
	private readonly string _host; // 0x28
	private static readonly EncodedStreamFactory s_encoderFactory; // 0x0

	// Properties
	public string DisplayName { get; }
	public string User { get; }
	public string Host { get; }
	public string Address { get; }
	private string SmtpAddress { get; }

	// Methods

	// RVA: 0x2236670 Offset: 0x2235870 VA: 0x182236670
	internal void .ctor(string displayName, string userName, string domain) { }

	// RVA: 0x2236650 Offset: 0x2235850 VA: 0x182236650
	public void .ctor(string address) { }

	// RVA: 0x2236630 Offset: 0x2235830 VA: 0x182236630
	public void .ctor(string address, string displayName) { }

	// RVA: 0x22363B0 Offset: 0x22355B0 VA: 0x1822363B0
	public void .ctor(string address, string displayName, Encoding displayNameEncoding) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_DisplayName() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_User() { }

	// RVA: 0x2236140 Offset: 0x2235340 VA: 0x182236140
	private string GetUser(bool allowUnicode) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Host() { }

	// RVA: 0x2235F90 Offset: 0x2235190 VA: 0x182235F90
	private string GetHost(bool allowUnicode) { }

	// RVA: 0x22366F0 Offset: 0x22358F0 VA: 0x1822366F0
	public string get_Address() { }

	// RVA: 0x2235E70 Offset: 0x2235070 VA: 0x182235E70
	private string GetAddress(bool allowUnicode) { }

	// RVA: 0x2236740 Offset: 0x2235940 VA: 0x182236740
	private string get_SmtpAddress() { }

	// RVA: 0x22360D0 Offset: 0x22352D0 VA: 0x1822360D0
	internal string GetSmtpAddress(bool allowUnicode) { }

	// RVA: 0x2236220 Offset: 0x2235420 VA: 0x182236220 Slot: 3
	public override string ToString() { }

	// RVA: 0x2235DF0 Offset: 0x2234FF0 VA: 0x182235DF0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x407CA0 Offset: 0x406EA0 VA: 0x180407CA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2235AE0 Offset: 0x2234CE0 VA: 0x182235AE0
	internal string Encode(int charsConsumed, bool allowUnicode) { }

	// RVA: 0x2236350 Offset: 0x2235550 VA: 0x182236350
	private static void .cctor() { }
}

// Namespace: System.Net.Mail
public class MailAddressCollection : Collection<MailAddress> // TypeDefIndex: 6262
{
	// Methods

	// RVA: 0x2234AA0 Offset: 0x2233CA0 VA: 0x182234AA0
	public void .ctor() { }

	// RVA: 0x22340F0 Offset: 0x22332F0 VA: 0x1822340F0
	public void Add(string addresses) { }

	// RVA: 0x2234770 Offset: 0x2233970 VA: 0x182234770 Slot: 38
	protected override void SetItem(int index, MailAddress item) { }

	// RVA: 0x2234490 Offset: 0x2233690 VA: 0x182234490 Slot: 36
	protected override void InsertItem(int index, MailAddress item) { }

	// RVA: 0x2234540 Offset: 0x2233740 VA: 0x182234540
	internal void ParseValue(string addresses) { }

	// RVA: 0x2234820 Offset: 0x2233A20 VA: 0x182234820 Slot: 3
	public override string ToString() { }

	// RVA: 0x2234220 Offset: 0x2233420 VA: 0x182234220
	internal string Encode(int charsConsumed, bool allowUnicode) { }
}

// Namespace: System.Net.Mail
internal enum MailHeaderID // TypeDefIndex: 6263
{
	// Fields
	public int value__; // 0x0
	public const MailHeaderID Bcc = 0;
	public const MailHeaderID Cc = 1;
	public const MailHeaderID Comments = 2;
	public const MailHeaderID ContentDescription = 3;
	public const MailHeaderID ContentDisposition = 4;
	public const MailHeaderID ContentID = 5;
	public const MailHeaderID ContentLocation = 6;
	public const MailHeaderID ContentTransferEncoding = 7;
	public const MailHeaderID ContentType = 8;
	public const MailHeaderID Date = 9;
	public const MailHeaderID From = 10;
	public const MailHeaderID Importance = 11;
	public const MailHeaderID InReplyTo = 12;
	public const MailHeaderID Keywords = 13;
	public const MailHeaderID Max = 14;
	public const MailHeaderID MessageID = 15;
	public const MailHeaderID MimeVersion = 16;
	public const MailHeaderID Priority = 17;
	public const MailHeaderID References = 18;
	public const MailHeaderID ReplyTo = 19;
	public const MailHeaderID ResentBcc = 20;
	public const MailHeaderID ResentCc = 21;
	public const MailHeaderID ResentDate = 22;
	public const MailHeaderID ResentFrom = 23;
	public const MailHeaderID ResentMessageID = 24;
	public const MailHeaderID ResentSender = 25;
	public const MailHeaderID ResentTo = 26;
	public const MailHeaderID Sender = 27;
	public const MailHeaderID Subject = 28;
	public const MailHeaderID To = 29;
	public const MailHeaderID XPriority = 30;
	public const MailHeaderID XReceiver = 31;
	public const MailHeaderID XSender = 32;
	public const MailHeaderID ZMaxEnumValue = 32;
	public const MailHeaderID Unknown = -1;
}

// Namespace: 
[IsReadOnly]
private struct MailHeaderInfo.HeaderInfo // TypeDefIndex: 6264
{
	// Fields
	public readonly string NormalizedName; // 0x0
	public readonly bool IsSingleton; // 0x8
	public readonly MailHeaderID ID; // 0xC
	public readonly bool IsUserSettable; // 0x10
	public readonly bool AllowsUnicode; // 0x11

	// Methods

	// RVA: 0x2233620 Offset: 0x2232820 VA: 0x182233620
	public void .ctor(MailHeaderID id, string name, bool isSingleton, bool isUserSettable, bool allowsUnicode) { }
}

// Namespace: System.Net.Mail
internal static class MailHeaderInfo // TypeDefIndex: 6265
{
	// Fields
	private static readonly MailHeaderInfo.HeaderInfo[] s_headerInfo; // 0x0
	private static readonly Dictionary<string, int> s_headerDictionary; // 0x8

	// Methods

	// RVA: 0x2236C80 Offset: 0x2235E80 VA: 0x182236C80
	private static void .cctor() { }

	// RVA: 0x2236950 Offset: 0x2235B50 VA: 0x182236950
	internal static string GetString(MailHeaderID id) { }

	// RVA: 0x22368B0 Offset: 0x2235AB0 VA: 0x1822368B0
	internal static MailHeaderID GetID(string name) { }

	// RVA: 0x2236AC0 Offset: 0x2235CC0 VA: 0x182236AC0
	internal static bool IsUserSettable(string name) { }

	// RVA: 0x22369E0 Offset: 0x2235BE0 VA: 0x1822369E0
	internal static bool IsSingleton(string name) { }

	// RVA: 0x2236BA0 Offset: 0x2235DA0 VA: 0x182236BA0
	internal static string NormalizeCase(string name) { }

	// RVA: 0x22367D0 Offset: 0x22359D0 VA: 0x1822367D0
	internal static bool AllowsUnicode(string name) { }
}

// Namespace: System.Net.Mail
public class AlternateView : AttachmentBase // TypeDefIndex: 6266
{
	// Fields
	private Uri baseUri; // 0x30
	private LinkedResourceCollection linkedResources; // 0x38

	// Properties
	public Uri BaseUri { get; set; }
	public LinkedResourceCollection LinkedResources { get; }

	// Methods

	// RVA: 0x2230BC0 Offset: 0x222FDC0 VA: 0x182230BC0
	public void .ctor(string fileName) { }

	// RVA: 0x2230F20 Offset: 0x2230120 VA: 0x182230F20
	public void .ctor(string fileName, ContentType contentType) { }

	// RVA: 0x2231050 Offset: 0x2230250 VA: 0x182231050
	public void .ctor(string fileName, string mediaType) { }

	// RVA: 0x2230C90 Offset: 0x222FE90 VA: 0x182230C90
	public void .ctor(Stream contentStream) { }

	// RVA: 0x2230DE0 Offset: 0x222FFE0 VA: 0x182230DE0
	public void .ctor(Stream contentStream, string mediaType) { }

	// RVA: 0x2231190 Offset: 0x2230390 VA: 0x182231190
	public void .ctor(Stream contentStream, ContentType contentType) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Uri get_BaseUri() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_BaseUri(Uri value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public LinkedResourceCollection get_LinkedResources() { }

	// RVA: 0x22307B0 Offset: 0x222F9B0 VA: 0x1822307B0
	public static AlternateView CreateAlternateViewFromString(string content) { }

	// RVA: 0x2230660 Offset: 0x222F860 VA: 0x182230660
	public static AlternateView CreateAlternateViewFromString(string content, ContentType contentType) { }

	// RVA: 0x22304C0 Offset: 0x222F6C0 VA: 0x1822304C0
	public static AlternateView CreateAlternateViewFromString(string content, Encoding contentEncoding, string mediaType) { }

	// RVA: 0x22309D0 Offset: 0x222FBD0 VA: 0x1822309D0 Slot: 5
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Net.Mail
public sealed class AlternateViewCollection : Collection<AlternateView>, IDisposable // TypeDefIndex: 6267
{
	// Methods

	// RVA: 0x2230480 Offset: 0x222F680 VA: 0x182230480
	internal void .ctor() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 39
	public void Dispose() { }

	// RVA: 0x2230330 Offset: 0x222F530 VA: 0x182230330 Slot: 35
	protected override void ClearItems() { }

	// RVA: 0x2230370 Offset: 0x222F570 VA: 0x182230370 Slot: 36
	protected override void InsertItem(int index, AlternateView item) { }

	// RVA: 0x22303D0 Offset: 0x222F5D0 VA: 0x1822303D0 Slot: 37
	protected override void RemoveItem(int index) { }

	// RVA: 0x2230420 Offset: 0x222F620 VA: 0x182230420 Slot: 38
	protected override void SetItem(int index, AlternateView item) { }
}

// Namespace: System.Net.Mail
public class Attachment : AttachmentBase // TypeDefIndex: 6268
{
	// Fields
	private ContentDisposition contentDisposition; // 0x30
	private Encoding nameEncoding; // 0x38

	// Properties
	public ContentDisposition ContentDisposition { get; }
	public string Name { get; set; }
	public Encoding NameEncoding { get; set; }

	// Methods

	// RVA: 0x22322B0 Offset: 0x22314B0 VA: 0x1822322B0
	public void .ctor(string fileName) { }

	// RVA: 0x2232750 Offset: 0x2231950 VA: 0x182232750
	public void .ctor(string fileName, string mediaType) { }

	// RVA: 0x22328D0 Offset: 0x2231AD0 VA: 0x1822328D0
	public void .ctor(string fileName, ContentType contentType) { }

	// RVA: 0x2232500 Offset: 0x2231700 VA: 0x182232500
	public void .ctor(Stream contentStream, ContentType contentType) { }

	// RVA: 0x2232600 Offset: 0x2231800 VA: 0x182232600
	public void .ctor(Stream contentStream, string name) { }

	// RVA: 0x22323C0 Offset: 0x22315C0 VA: 0x1822323C0
	public void .ctor(Stream contentStream, string name, string mediaType) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ContentDisposition get_ContentDisposition() { }

	// RVA: 0x2232A30 Offset: 0x2231C30 VA: 0x182232A30
	public string get_Name() { }

	// RVA: 0x2232A50 Offset: 0x2231C50 VA: 0x182232A50
	public void set_Name(string value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Encoding get_NameEncoding() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_NameEncoding(Encoding value) { }

	// RVA: 0x2231DC0 Offset: 0x2230FC0 VA: 0x182231DC0
	public static Attachment CreateAttachmentFromString(string content, ContentType contentType) { }

	// RVA: 0x2231BF0 Offset: 0x2230DF0 VA: 0x182231BF0
	public static Attachment CreateAttachmentFromString(string content, string name) { }

	// RVA: 0x2231F40 Offset: 0x2231140 VA: 0x182231F40
	public static Attachment CreateAttachmentFromString(string content, string name, Encoding contentEncoding, string mediaType) { }

	// RVA: 0x22321F0 Offset: 0x22313F0 VA: 0x1822321F0
	private void InitName(string fileName) { }
}

// Namespace: 
private class AttachmentBase.MimeTypes // TypeDefIndex: 6269
{
	// Fields
	private static Hashtable mimeTypes; // 0x0

	// Methods

	// RVA: 0x223A7A0 Offset: 0x22399A0 VA: 0x18223A7A0
	private static void .cctor() { }

	// RVA: 0x223A690 Offset: 0x2239890 VA: 0x18223A690
	public static string GetMimeType(string fileName) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net.Mail
public abstract class AttachmentBase : IDisposable // TypeDefIndex: 6270
{
	// Fields
	private string id; // 0x10
	private ContentType contentType; // 0x18
	private Stream contentStream; // 0x20
	private TransferEncoding transferEncoding; // 0x28

	// Properties
	public string ContentId { get; set; }
	public Stream ContentStream { get; }
	public ContentType ContentType { get; set; }
	public TransferEncoding TransferEncoding { get; set; }

	// Methods

	// RVA: 0x2231860 Offset: 0x2230A60 VA: 0x182231860
	protected void .ctor(Stream contentStream) { }

	// RVA: 0x2231300 Offset: 0x2230500 VA: 0x182231300
	protected void .ctor(Stream contentStream, ContentType contentType) { }

	// RVA: 0x22313D0 Offset: 0x22305D0 VA: 0x1822313D0
	protected void .ctor(Stream contentStream, string mediaType) { }

	// RVA: 0x2231580 Offset: 0x2230780 VA: 0x182231580
	protected void .ctor(string fileName) { }

	// RVA: 0x22314B0 Offset: 0x22306B0 VA: 0x1822314B0
	protected void .ctor(string fileName, ContentType contentType) { }

	// RVA: 0x2231770 Offset: 0x2230970 VA: 0x182231770
	protected void .ctor(string fileName, string mediaType) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ContentId() { }

	// RVA: 0x2231950 Offset: 0x2230B50 VA: 0x182231950
	public void set_ContentId(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Stream get_ContentStream() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ContentType get_ContentType() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ContentType(ContentType value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public TransferEncoding get_TransferEncoding() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_TransferEncoding(TransferEncoding value) { }

	// RVA: 0x1744B80 Offset: 0x1743D80 VA: 0x181744B80 Slot: 4
	public void Dispose() { }

	// RVA: 0x22312C0 Offset: 0x22304C0 VA: 0x1822312C0 Slot: 5
	protected virtual void Dispose(bool disposing) { }
}

// Namespace: System.Net.Mail
public sealed class AttachmentCollection : Collection<Attachment>, IDisposable // TypeDefIndex: 6271
{
	// Methods

	// RVA: 0x2231BB0 Offset: 0x2230DB0 VA: 0x182231BB0
	internal void .ctor() { }

	// RVA: 0x22319F0 Offset: 0x2230BF0 VA: 0x1822319F0 Slot: 39
	public void Dispose() { }

	// RVA: 0x22319B0 Offset: 0x2230BB0 VA: 0x1822319B0 Slot: 35
	protected override void ClearItems() { }

	// RVA: 0x2231AA0 Offset: 0x2230CA0 VA: 0x182231AA0 Slot: 36
	protected override void InsertItem(int index, Attachment item) { }

	// RVA: 0x2231B00 Offset: 0x2230D00 VA: 0x182231B00 Slot: 37
	protected override void RemoveItem(int index) { }

	// RVA: 0x2231B50 Offset: 0x2230D50 VA: 0x182231B50 Slot: 38
	protected override void SetItem(int index, Attachment item) { }
}

// Namespace: System.Net.Mail
[Flags]
public enum DeliveryNotificationOptions // TypeDefIndex: 6272
{
	// Fields
	public int value__; // 0x0
	public const DeliveryNotificationOptions None = 0;
	public const DeliveryNotificationOptions OnSuccess = 1;
	public const DeliveryNotificationOptions OnFailure = 2;
	public const DeliveryNotificationOptions Delay = 4;
	public const DeliveryNotificationOptions Never = 134217728;
}

// Namespace: System.Net.Mail
public class LinkedResource : AttachmentBase // TypeDefIndex: 6273
{
	// Fields
	private Uri contentLink; // 0x30

	// Properties
	public Uri ContentLink { get; set; }

	// Methods

	// RVA: 0x2233EE0 Offset: 0x22330E0 VA: 0x182233EE0
	public void .ctor(string fileName) { }

	// RVA: 0x2233CC0 Offset: 0x2232EC0 VA: 0x182233CC0
	public void .ctor(string fileName, ContentType contentType) { }

	// RVA: 0x2233D90 Offset: 0x2232F90 VA: 0x182233D90
	public void .ctor(string fileName, string mediaType) { }

	// RVA: 0x2233E80 Offset: 0x2233080 VA: 0x182233E80
	public void .ctor(Stream contentStream) { }

	// RVA: 0x2234020 Offset: 0x2233220 VA: 0x182234020
	public void .ctor(Stream contentStream, ContentType contentType) { }

	// RVA: 0x2233F40 Offset: 0x2233140 VA: 0x182233F40
	public void .ctor(Stream contentStream, string mediaType) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Uri get_ContentLink() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_ContentLink(Uri value) { }

	// RVA: 0x22339C0 Offset: 0x2232BC0 VA: 0x1822339C0
	public static LinkedResource CreateLinkedResourceFromString(string content) { }

	// RVA: 0x2233820 Offset: 0x2232A20 VA: 0x182233820
	public static LinkedResource CreateLinkedResourceFromString(string content, ContentType contentType) { }

	// RVA: 0x2233B10 Offset: 0x2232D10 VA: 0x182233B10
	public static LinkedResource CreateLinkedResourceFromString(string content, Encoding contentEncoding, string mediaType) { }
}

// Namespace: System.Net.Mail
public sealed class LinkedResourceCollection : Collection<LinkedResource>, IDisposable // TypeDefIndex: 6274
{
	// Methods

	// RVA: 0x22337E0 Offset: 0x22329E0 VA: 0x1822337E0
	internal void .ctor() { }

	// RVA: 0x2233680 Offset: 0x2232880 VA: 0x182233680 Slot: 39
	public void Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Dispose(bool disposing) { }

	// RVA: 0x2233640 Offset: 0x2232840 VA: 0x182233640 Slot: 35
	protected override void ClearItems() { }

	// RVA: 0x22336D0 Offset: 0x22328D0 VA: 0x1822336D0 Slot: 36
	protected override void InsertItem(int index, LinkedResource item) { }

	// RVA: 0x2233730 Offset: 0x2232930 VA: 0x182233730 Slot: 37
	protected override void RemoveItem(int index) { }

	// RVA: 0x2233780 Offset: 0x2232980 VA: 0x182233780 Slot: 38
	protected override void SetItem(int index, LinkedResource item) { }
}

// Namespace: System.Net.Mail
public class MailMessage : IDisposable // TypeDefIndex: 6275
{
	// Fields
	private AlternateViewCollection alternateViews; // 0x10
	private AttachmentCollection attachments; // 0x18
	private MailAddressCollection bcc; // 0x20
	private MailAddressCollection replyTo; // 0x28
	private string body; // 0x30
	private MailPriority priority; // 0x38
	private MailAddress sender; // 0x40
	private DeliveryNotificationOptions deliveryNotificationOptions; // 0x48
	private MailAddressCollection cc; // 0x50
	private MailAddress from; // 0x58
	private NameValueCollection headers; // 0x60
	private MailAddressCollection to; // 0x68
	private string subject; // 0x70
	private Encoding subjectEncoding; // 0x78
	private Encoding bodyEncoding; // 0x80
	private Encoding headersEncoding; // 0x88
	private bool isHtml; // 0x90
	private static char[] hex; // 0x0
	private static Encoding utf8unmarked; // 0x8

	// Properties
	public AlternateViewCollection AlternateViews { get; }
	public AttachmentCollection Attachments { get; }
	public MailAddressCollection Bcc { get; }
	public string Body { get; set; }
	internal ContentType BodyContentType { get; }
	internal TransferEncoding ContentTransferEncoding { get; }
	public Encoding BodyEncoding { get; set; }
	public TransferEncoding BodyTransferEncoding { get; set; }
	public MailAddressCollection CC { get; }
	public DeliveryNotificationOptions DeliveryNotificationOptions { get; set; }
	public MailAddress From { get; set; }
	public NameValueCollection Headers { get; }
	public bool IsBodyHtml { get; set; }
	public MailPriority Priority { get; set; }
	public Encoding HeadersEncoding { get; set; }
	public MailAddressCollection ReplyToList { get; }
	[Obsolete("Use ReplyToList instead")]
	public MailAddress ReplyTo { get; set; }
	public MailAddress Sender { get; set; }
	public string Subject { get; set; }
	public Encoding SubjectEncoding { get; set; }
	public MailAddressCollection To { get; }
	private static Encoding UTF8Unmarked { get; }

	// Methods

	// RVA: 0x22381E0 Offset: 0x22373E0 VA: 0x1822381E0
	public void .ctor() { }

	// RVA: 0x2238710 Offset: 0x2237910 VA: 0x182238710
	public void .ctor(MailAddress from, MailAddress to) { }

	// RVA: 0x2237F60 Offset: 0x2237160 VA: 0x182237F60
	public void .ctor(string from, string to) { }

	// RVA: 0x2238430 Offset: 0x2237630 VA: 0x182238430
	public void .ctor(string from, string to, string subject, string body) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public AlternateViewCollection get_AlternateViews() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public AttachmentCollection get_Attachments() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public MailAddressCollection get_Bcc() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Body() { }

	// RVA: 0x2238B00 Offset: 0x2237D00 VA: 0x182238B00
	public void set_Body(string value) { }

	// RVA: 0x22387D0 Offset: 0x22379D0 VA: 0x1822387D0
	internal ContentType get_BodyContentType() { }

	// RVA: 0x2238900 Offset: 0x2237B00 VA: 0x182238900
	internal TransferEncoding get_ContentTransferEncoding() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public Encoding get_BodyEncoding() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_BodyEncoding(Encoding value) { }

	// RVA: 0x22388B0 Offset: 0x2237AB0 VA: 0x1822388B0
	public TransferEncoding get_BodyTransferEncoding() { }

	// RVA: 0x2238AC0 Offset: 0x2237CC0 VA: 0x182238AC0
	public void set_BodyTransferEncoding(TransferEncoding value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public MailAddressCollection get_CC() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public DeliveryNotificationOptions get_DeliveryNotificationOptions() { }

	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_DeliveryNotificationOptions(DeliveryNotificationOptions value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public MailAddress get_From() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_From(MailAddress value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public NameValueCollection get_Headers() { }

	// RVA: 0x5C4DE0 Offset: 0x5C3FE0 VA: 0x1805C4DE0
	public bool get_IsBodyHtml() { }

	// RVA: 0x834530 Offset: 0x833730 VA: 0x180834530
	public void set_IsBodyHtml(bool value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public MailPriority get_Priority() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_Priority(MailPriority value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public Encoding get_HeadersEncoding() { }

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	public void set_HeadersEncoding(Encoding value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public MailAddressCollection get_ReplyToList() { }

	// RVA: 0x2238950 Offset: 0x2237B50 VA: 0x182238950
	public MailAddress get_ReplyTo() { }

	// RVA: 0x2238B60 Offset: 0x2237D60 VA: 0x182238B60
	public void set_ReplyTo(MailAddress value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public MailAddress get_Sender() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_Sender(MailAddress value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public string get_Subject() { }

	// RVA: 0x2238BE0 Offset: 0x2237DE0 VA: 0x182238BE0
	public void set_Subject(string value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public Encoding get_SubjectEncoding() { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	public void set_SubjectEncoding(Encoding value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public MailAddressCollection get_To() { }

	// RVA: 0x2237960 Offset: 0x2236B60 VA: 0x182237960 Slot: 4
	public void Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2237BA0 Offset: 0x2236DA0 VA: 0x182237BA0
	private Encoding GuessEncoding(string s) { }

	// RVA: 0x2237C40 Offset: 0x2236E40 VA: 0x182237C40
	internal static TransferEncoding GuessTransferEncoding(Encoding enc) { }

	// RVA: 0x2237D50 Offset: 0x2236F50 VA: 0x182237D50
	internal static string To2047(byte[] bytes) { }

	// RVA: 0x22379D0 Offset: 0x2236BD0 VA: 0x1822379D0
	internal static string EncodeSubjectRFC2047(string s, Encoding enc) { }

	// RVA: 0x22389D0 Offset: 0x2237BD0 VA: 0x1822389D0
	private static Encoding get_UTF8Unmarked() { }

	// RVA: 0x2237EE0 Offset: 0x22370E0 VA: 0x182237EE0
	private static void .cctor() { }
}

// Namespace: System.Net.Mail
public enum MailPriority // TypeDefIndex: 6276
{
	// Fields
	public int value__; // 0x0
	public const MailPriority Normal = 0;
	public const MailPriority Low = 1;
	public const MailPriority High = 2;
}

// Namespace: System.Net.Mail
public sealed class SendCompletedEventHandler : MulticastDelegate // TypeDefIndex: 6277
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, AsyncCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, AsyncCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net.Mail
public enum SmtpAccess // TypeDefIndex: 6278
{
	// Fields
	public int value__; // 0x0
	public const SmtpAccess None = 0;
	public const SmtpAccess Connect = 1;
	public const SmtpAccess ConnectToUnrestrictedPort = 2;
}

// Namespace: 
[Flags]
private enum SmtpClient.AuthMechs // TypeDefIndex: 6279
{
	// Fields
	public int value__; // 0x0
	public const SmtpClient.AuthMechs None = 0;
	public const SmtpClient.AuthMechs Login = 1;
	public const SmtpClient.AuthMechs Plain = 2;
}

// Namespace: 
private class SmtpClient.CancellationException : Exception // TypeDefIndex: 6280
{
	// Methods

	// RVA: 0x2250D80 Offset: 0x224FF80 VA: 0x182250D80
	public void .ctor() { }
}

// Namespace: 
private struct SmtpClient.HeaderName // TypeDefIndex: 6281
{
	// Fields
	public const string ContentTransferEncoding = "Content-Transfer-Encoding";
	public const string ContentType = "Content-Type";
	public const string Bcc = "Bcc";
	public const string Cc = "Cc";
	public const string From = "From";
	public const string Subject = "Subject";
	public const string To = "To";
	public const string MimeVersion = "MIME-Version";
	public const string MessageId = "Message-ID";
	public const string Priority = "Priority";
	public const string Importance = "Importance";
	public const string XPriority = "X-Priority";
	public const string Date = "Date";
}

// Namespace: 
private struct SmtpClient.SmtpResponse // TypeDefIndex: 6282
{
	// Fields
	public SmtpStatusCode StatusCode; // 0x0
	public string Description; // 0x8

	// Methods

	// RVA: 0x225CDF0 Offset: 0x225BFF0 VA: 0x18225CDF0
	public static SmtpClient.SmtpResponse Parse(string line) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SmtpClient.<>c__DisplayClass85_0 // TypeDefIndex: 6283
{
	// Fields
	public TaskCompletionSource<object> tcs; // 0x10
	public SendCompletedEventHandler handler; // 0x18
	public SmtpClient <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2264EB0 Offset: 0x22640B0 VA: 0x182264EB0
	internal void <SendMailAsync>b__0(object s, AsyncCompletedEventArgs e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SmtpClient.<>c__DisplayClass90_0 // TypeDefIndex: 6284
{
	// Fields
	public SmtpClient <>4__this; // 0x10
	public MailMessage message; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2264EE0 Offset: 0x22640E0 VA: 0x182264EE0
	internal void <SendAsync>b__0(object o, DoWorkEventArgs ea) { }

	// RVA: 0x2264F90 Offset: 0x2264190 VA: 0x182264F90
	internal void <SendAsync>b__1(object o, RunWorkerCompletedEventArgs ea) { }
}

// Namespace: System.Net.Mail
[Obsolete("SmtpClient and its network of types are poorly designed, we strongly recommend you use https://github.com/jstedfast/MailKit and https://github.com/jstedfast/MimeKit instead")]
public class SmtpClient : IDisposable // TypeDefIndex: 6285
{
	// Fields
	private string host; // 0x10
	private int port; // 0x18
	private int timeout; // 0x1C
	private ICredentialsByHost credentials; // 0x20
	private string pickupDirectoryLocation; // 0x28
	private SmtpDeliveryMethod deliveryMethod; // 0x30
	private SmtpDeliveryFormat deliveryFormat; // 0x34
	private bool enableSsl; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private TcpClient client; // 0x48
	private Stream stream; // 0x50
	private StreamWriter writer; // 0x58
	private StreamReader reader; // 0x60
	private int boundaryIndex; // 0x68
	private MailAddress defaultFrom; // 0x70
	private MailMessage messageInProcess; // 0x78
	private BackgroundWorker worker; // 0x80
	private object user_async_state; // 0x88
	private SmtpClient.AuthMechs authMechs; // 0x90
	private Mutex mutex; // 0x98
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0xA0
	[CompilerGenerated]
	private SendCompletedEventHandler SendCompleted; // 0xA8

	// Properties
	[MonoTODO("Client certificates not used")]
	public X509CertificateCollection ClientCertificates { get; }
	public string TargetName { get; set; }
	public ICredentialsByHost Credentials { get; set; }
	public SmtpDeliveryMethod DeliveryMethod { get; set; }
	public bool EnableSsl { get; set; }
	public string Host { get; set; }
	public string PickupDirectoryLocation { get; set; }
	public int Port { get; set; }
	public SmtpDeliveryFormat DeliveryFormat { get; set; }
	[MonoTODO]
	public ServicePoint ServicePoint { get; }
	public int Timeout { get; set; }
	public bool UseDefaultCredentials { get; set; }

	// Methods

	// RVA: 0x224CE90 Offset: 0x224C090 VA: 0x18224CE90
	public void .ctor() { }

	// RVA: 0x224CF20 Offset: 0x224C120 VA: 0x18224CF20
	public void .ctor(string host) { }

	// RVA: 0x224CDE0 Offset: 0x224BFE0 VA: 0x18224CDE0
	public void .ctor(string host, int port) { }

	// RVA: 0x224D070 Offset: 0x224C270 VA: 0x18224D070
	public X509CertificateCollection get_ClientCertificates() { }

	[CompilerGenerated]
	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20
	public void set_TargetName(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ICredentialsByHost get_Credentials() { }

	// RVA: 0x224D1D0 Offset: 0x224C3D0 VA: 0x18224D1D0
	public void set_Credentials(ICredentialsByHost value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public SmtpDeliveryMethod get_DeliveryMethod() { }

	// RVA: 0x224D2B0 Offset: 0x224C4B0 VA: 0x18224D2B0
	public void set_DeliveryMethod(SmtpDeliveryMethod value) { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_EnableSsl() { }

	// RVA: 0x224D320 Offset: 0x224C520 VA: 0x18224D320
	public void set_EnableSsl(bool value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Host() { }

	// RVA: 0x224D390 Offset: 0x224C590 VA: 0x18224D390
	public void set_Host(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_PickupDirectoryLocation() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_PickupDirectoryLocation(string value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Port() { }

	// RVA: 0x224D470 Offset: 0x224C670 VA: 0x18224D470
	public void set_Port(int value) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public SmtpDeliveryFormat get_DeliveryFormat() { }

	// RVA: 0x224D240 Offset: 0x224C440 VA: 0x18224D240
	public void set_DeliveryFormat(SmtpDeliveryFormat value) { }

	// RVA: 0x224D0E0 Offset: 0x224C2E0 VA: 0x18224D0E0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_Timeout() { }

	// RVA: 0x224D520 Offset: 0x224C720 VA: 0x18224D520
	public void set_Timeout(int value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public bool get_UseDefaultCredentials() { }

	[MonoNotSupported("no DefaultCredential support in Mono")]
	// RVA: 0x224D5D0 Offset: 0x224C7D0 VA: 0x18224D5D0
	public void set_UseDefaultCredentials(bool value) { }

	[CompilerGenerated]
	// RVA: 0x224CFC0 Offset: 0x224C1C0 VA: 0x18224CFC0
	public void add_SendCompleted(SendCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x224D120 Offset: 0x224C320 VA: 0x18224D120
	public void remove_SendCompleted(SendCompletedEventHandler value) { }

	// RVA: 0x1744B80 Offset: 0x1743D80 VA: 0x181744B80 Slot: 4
	public void Dispose() { }

	[MonoTODO("Does nothing at the moment.")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x22469B0 Offset: 0x2245BB0 VA: 0x1822469B0
	private void CheckState() { }

	// RVA: 0x2246A80 Offset: 0x2245C80 VA: 0x182246A80
	private static string EncodeAddress(MailAddress address) { }

	// RVA: 0x2246C20 Offset: 0x2245E20 VA: 0x182246C20
	private static string EncodeAddresses(MailAddressCollection addresses) { }

	// RVA: 0x2247110 Offset: 0x2246310 VA: 0x182247110
	private string EncodeSubjectRFC2047(MailMessage message) { }

	// RVA: 0x2246E80 Offset: 0x2246080 VA: 0x182246E80
	private string EncodeBody(MailMessage message) { }

	// RVA: 0x2246FB0 Offset: 0x22461B0 VA: 0x182246FB0
	private string EncodeBody(AlternateView av) { }

	// RVA: 0x2247180 Offset: 0x2246380 VA: 0x182247180
	private void EndSection(string section) { }

	// RVA: 0x22472A0 Offset: 0x22464A0 VA: 0x1822472A0
	private string GenerateBoundary() { }

	// RVA: 0x2247200 Offset: 0x2246400 VA: 0x182247200
	private static string GenerateBoundary(int index) { }

	// RVA: 0x2247690 Offset: 0x2246890 VA: 0x182247690
	private bool IsError(SmtpClient.SmtpResponse status) { }

	// RVA: 0x22476A0 Offset: 0x22468A0 VA: 0x1822476A0
	protected void OnSendCompleted(AsyncCompletedEventArgs e) { }

	// RVA: 0x2246940 Offset: 0x2245B40 VA: 0x182246940
	private void CheckCancellation() { }

	// RVA: 0x2247900 Offset: 0x2246B00 VA: 0x182247900
	private SmtpClient.SmtpResponse Read() { }

	// RVA: 0x2247BC0 Offset: 0x2246DC0 VA: 0x182247BC0
	private void ResetExtensions() { }

	// RVA: 0x2247730 Offset: 0x2246930 VA: 0x182247730
	private void ParseExtensions(string extens) { }

	// RVA: 0x224C250 Offset: 0x224B450 VA: 0x18224C250
	public void Send(MailMessage message) { }

	// RVA: 0x224AA00 Offset: 0x2249C00 VA: 0x18224AA00
	private void SendInternal(MailMessage message) { }

	// RVA: 0x224B760 Offset: 0x224A960 VA: 0x18224B760
	private void SendToFile(MailMessage message) { }

	// RVA: 0x2248FF0 Offset: 0x22481F0 VA: 0x182248FF0
	private void SendCore(MailMessage message) { }

	// RVA: 0x224C1B0 Offset: 0x224B3B0 VA: 0x18224C1B0
	public void Send(string from, string recipients, string subject, string body) { }

	// RVA: 0x224B0D0 Offset: 0x224A2D0 VA: 0x18224B0D0
	public Task SendMailAsync(MailMessage message) { }

	// RVA: 0x224B340 Offset: 0x224A540 VA: 0x18224B340
	public Task SendMailAsync(string from, string recipients, string subject, string body) { }

	// RVA: 0x224AF70 Offset: 0x224A170 VA: 0x18224AF70
	private static void SendMailAsyncCompletedHandler(TaskCompletionSource<object> source, AsyncCompletedEventArgs e, SendCompletedEventHandler handler, SmtpClient client) { }

	// RVA: 0x224A920 Offset: 0x2249B20 VA: 0x18224A920
	private void SendDot() { }

	// RVA: 0x224A740 Offset: 0x2249940 VA: 0x18224A740
	private void SendData(string data) { }

	// RVA: 0x2247C50 Offset: 0x2246E50 VA: 0x182247C50
	public void SendAsync(MailMessage message, object userToken) { }

	// RVA: 0x2247E30 Offset: 0x2247030 VA: 0x182247E30
	public void SendAsync(string from, string recipients, string subject, string body, object userToken) { }

	// RVA: 0x2247BD0 Offset: 0x2246DD0 VA: 0x182247BD0
	public void SendAsyncCancel() { }

	// RVA: 0x2246250 Offset: 0x2245450 VA: 0x182246250
	private void AddPriorityHeader(MailMessage message) { }

	// RVA: 0x224B3E0 Offset: 0x224A5E0 VA: 0x18224B3E0
	private void SendSimpleBody(MailMessage message) { }

	// RVA: 0x2248CB0 Offset: 0x2247EB0 VA: 0x182248CB0
	private void SendBodylessSingleAlternate(AlternateView av) { }

	// RVA: 0x224C0B0 Offset: 0x224B2B0 VA: 0x18224C0B0
	private void SendWithoutAttachments(MailMessage message, string boundary, bool attachmentExists) { }

	// RVA: 0x224BDA0 Offset: 0x224AFA0 VA: 0x18224BDA0
	private void SendWithAttachments(MailMessage message) { }

	// RVA: 0x2248360 Offset: 0x2247560 VA: 0x182248360
	private void SendBodyWithAlternateViews(MailMessage message, string boundary, bool attachmentExists) { }

	// RVA: 0x224ABC0 Offset: 0x2249DC0 VA: 0x18224ABC0
	private void SendLinkedResources(MailMessage message, LinkedResourceCollection resources, string boundary) { }

	// RVA: 0x2247EE0 Offset: 0x22470E0 VA: 0x182247EE0
	private void SendAttachments(MailMessage message, Attachment body, string boundary) { }

	// RVA: 0x2248F20 Offset: 0x2248120 VA: 0x182248F20
	private SmtpClient.SmtpResponse SendCommand(string command) { }

	// RVA: 0x224A990 Offset: 0x2249B90 VA: 0x18224A990
	private void SendHeader(string name, string value) { }

	// RVA: 0x224C770 Offset: 0x224B970 VA: 0x18224C770
	private void StartSection(string section, ContentType sectionContentType) { }

	// RVA: 0x224C880 Offset: 0x224BA80 VA: 0x18224C880
	private void StartSection(string section, ContentType sectionContentType, AttachmentBase att) { }

	// RVA: 0x224C4D0 Offset: 0x224B6D0 VA: 0x18224C4D0
	private void StartSection(string section, ContentType sectionContentType, Attachment att, bool sendDisposition) { }

	// RVA: 0x224CAF0 Offset: 0x224BCF0 VA: 0x18224CAF0
	private string ToQuotedPrintable(string input, Encoding enc) { }

	// RVA: 0x224CB30 Offset: 0x224BD30 VA: 0x18224CB30
	private string ToQuotedPrintable(byte[] bytes) { }

	// RVA: 0x2247350 Offset: 0x2246550 VA: 0x182247350
	private static string GetTransferEncodingName(TransferEncoding encoding) { }

	// RVA: 0x22473E0 Offset: 0x22465E0 VA: 0x1822473E0
	private void InitiateSecureConnection() { }

	// RVA: 0x2246830 Offset: 0x2245A30 VA: 0x182246830
	private void Authenticate() { }

	// RVA: 0x2246A20 Offset: 0x2245C20 VA: 0x182246A20
	private void CheckStatus(SmtpClient.SmtpResponse status, int i) { }

	// RVA: 0x224CA90 Offset: 0x224BC90 VA: 0x18224CA90
	private void ThrowIfError(SmtpClient.SmtpResponse status) { }

	// RVA: 0x2246450 Offset: 0x2245650 VA: 0x182246450
	private void Authenticate(string user, string password) { }
}

// Namespace: System.Net.Mail
internal class CCredentialsByHost : ICredentialsByHost // TypeDefIndex: 6286
{
	// Fields
	private string userName; // 0x10
	private string password; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string userName, string password) { }

	// RVA: 0x2250D10 Offset: 0x224FF10 VA: 0x182250D10 Slot: 4
	public NetworkCredential GetCredential(string host, int port, string authenticationType) { }
}

// Namespace: System.Net.Mail
public enum SmtpDeliveryFormat // TypeDefIndex: 6287
{
	// Fields
	public int value__; // 0x0
	public const SmtpDeliveryFormat SevenBit = 0;
	public const SmtpDeliveryFormat International = 1;
}

// Namespace: System.Net.Mail
public enum SmtpDeliveryMethod // TypeDefIndex: 6288
{
	// Fields
	public int value__; // 0x0
	public const SmtpDeliveryMethod Network = 0;
	public const SmtpDeliveryMethod SpecifiedPickupDirectory = 1;
	public const SmtpDeliveryMethod PickupDirectoryFromIis = 2;
}

// Namespace: System.Net.Mail
[Serializable]
public class SmtpException : Exception, ISerializable // TypeDefIndex: 6289
{
	// Fields
	private SmtpStatusCode statusCode; // 0x90

	// Properties
	public SmtpStatusCode StatusCode { get; set; }

	// Methods

	// RVA: 0x225C330 Offset: 0x225B530 VA: 0x18225C330
	public void .ctor() { }

	// RVA: 0x225C2A0 Offset: 0x225B4A0 VA: 0x18225C2A0
	public void .ctor(SmtpStatusCode statusCode) { }

	// RVA: 0x225C3B0 Offset: 0x225B5B0 VA: 0x18225C3B0
	public void .ctor(string message) { }

	// RVA: 0x225C420 Offset: 0x225B620 VA: 0x18225C420
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x225C340 Offset: 0x225B540 VA: 0x18225C340
	public void .ctor(SmtpStatusCode statusCode, string message) { }

	// RVA: 0x225C610 Offset: 0x225B810 VA: 0x18225C610
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210
	public SmtpStatusCode get_StatusCode() { }

	// RVA: 0xB80190 Offset: 0xB7F390 VA: 0x180B80190
	public void set_StatusCode(SmtpStatusCode value) { }

	// RVA: 0x225C160 Offset: 0x225B360 VA: 0x18225C160 Slot: 15
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21677F0 Offset: 0x21669F0 VA: 0x1821677F0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Net.Mail
[Serializable]
public class SmtpFailedRecipientException : SmtpException, ISerializable // TypeDefIndex: 6290
{
	// Fields
	private string failedRecipient; // 0x98

	// Properties
	public string FailedRecipient { get; }

	// Methods

	// RVA: 0x225C330 Offset: 0x225B530 VA: 0x18225C330
	public void .ctor() { }

	// RVA: 0x225C3B0 Offset: 0x225B5B0 VA: 0x18225C3B0
	public void .ctor(string message) { }

	// RVA: 0x225C8D0 Offset: 0x225BAD0 VA: 0x18225C8D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x225C810 Offset: 0x225BA10 VA: 0x18225C810
	public void .ctor(SmtpStatusCode statusCode, string failedRecipient) { }

	// RVA: 0x225C610 Offset: 0x225B810 VA: 0x18225C610
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x225C840 Offset: 0x225BA40 VA: 0x18225C840
	public void .ctor(string message, string failedRecipient, Exception innerException) { }

	// RVA: 0x225C9A0 Offset: 0x225BBA0 VA: 0x18225C9A0
	public void .ctor(SmtpStatusCode statusCode, string failedRecipient, string serverResponse) { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public string get_FailedRecipient() { }

	// RVA: 0x225C690 Offset: 0x225B890 VA: 0x18225C690 Slot: 15
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21677F0 Offset: 0x21669F0 VA: 0x1821677F0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Net.Mail
[Serializable]
public class SmtpFailedRecipientsException : SmtpFailedRecipientException, ISerializable // TypeDefIndex: 6291
{
	// Fields
	private SmtpFailedRecipientException[] innerExceptions; // 0xA0

	// Properties
	public SmtpFailedRecipientException[] InnerExceptions { get; }

	// Methods

	// RVA: 0x225C330 Offset: 0x225B530 VA: 0x18225C330
	public void .ctor() { }

	// RVA: 0x225C3B0 Offset: 0x225B5B0 VA: 0x18225C3B0
	public void .ctor(string message) { }

	// RVA: 0x225C610 Offset: 0x225B810 VA: 0x18225C610
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x225CBD0 Offset: 0x225BDD0 VA: 0x18225CBD0
	public void .ctor(string message, SmtpFailedRecipientException[] innerExceptions) { }

	// RVA: 0x225CC50 Offset: 0x225BE50 VA: 0x18225CC50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public SmtpFailedRecipientException[] get_InnerExceptions() { }

	// RVA: 0x225CA20 Offset: 0x225BC20 VA: 0x18225CA20 Slot: 15
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x21677F0 Offset: 0x21669F0 VA: 0x1821677F0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Net.Mail
public enum SmtpStatusCode // TypeDefIndex: 6292
{
	// Fields
	public int value__; // 0x0
	public const SmtpStatusCode BadCommandSequence = 503;
	public const SmtpStatusCode CannotVerifyUserWillAttemptDelivery = 252;
	public const SmtpStatusCode ClientNotPermitted = 454;
	public const SmtpStatusCode CommandNotImplemented = 502;
	public const SmtpStatusCode CommandParameterNotImplemented = 504;
	public const SmtpStatusCode CommandUnrecognized = 500;
	public const SmtpStatusCode ExceededStorageAllocation = 552;
	public const SmtpStatusCode GeneralFailure = -1;
	public const SmtpStatusCode HelpMessage = 214;
	public const SmtpStatusCode InsufficientStorage = 452;
	public const SmtpStatusCode LocalErrorInProcessing = 451;
	public const SmtpStatusCode MailboxBusy = 450;
	public const SmtpStatusCode MailboxNameNotAllowed = 553;
	public const SmtpStatusCode MailboxUnavailable = 550;
	public const SmtpStatusCode Ok = 250;
	public const SmtpStatusCode ServiceClosingTransmissionChannel = 221;
	public const SmtpStatusCode ServiceNotAvailable = 421;
	public const SmtpStatusCode ServiceReady = 220;
	public const SmtpStatusCode StartMailInput = 354;
	public const SmtpStatusCode SyntaxError = 501;
	public const SmtpStatusCode SystemStatus = 211;
	public const SmtpStatusCode TransactionFailed = 554;
	public const SmtpStatusCode UserNotLocalTryAlternatePath = 551;
	public const SmtpStatusCode UserNotLocalWillForward = 251;
	public const SmtpStatusCode MustIssueStartTlsFirst = 530;
}

// Namespace: System.Net.Http
internal abstract class DelegatingStream : Stream // TypeDefIndex: 6293
{
	// Fields
	private readonly Stream _innerStream; // 0x28

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override int ReadTimeout { get; set; }
	public override bool CanTimeout { get; }
	public override int WriteTimeout { get; set; }

	// Methods

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

	// RVA: 0x1D8AEA0 Offset: 0x1D8A0A0 VA: 0x181D8AEA0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1D8B1E0 Offset: 0x1D8A3E0 VA: 0x181D8B1E0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1D8A450 Offset: 0x1D89650 VA: 0x181D8A450 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1D8B170 Offset: 0x1D8A370 VA: 0x181D8B170 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1D8B210 Offset: 0x1D8A410 VA: 0x181D8B210 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x22534F0 Offset: 0x22526F0 VA: 0x1822534F0
	protected void .ctor(Stream innerStream) { }

	// RVA: 0x2253300 Offset: 0x2252500 VA: 0x182253300 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x205C230 Offset: 0x205B430 VA: 0x18205C230 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x205C200 Offset: 0x205B400 VA: 0x18205C200 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x22533E0 Offset: 0x22525E0 VA: 0x1822533E0 Slot: 35
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x205C1D0 Offset: 0x205B3D0 VA: 0x18205C1D0 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x22533B0 Offset: 0x22525B0 VA: 0x1822533B0 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2253350 Offset: 0x2252550 VA: 0x182253350 Slot: 27
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x205BF60 Offset: 0x205B160 VA: 0x18205BF60 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x205C0F0 Offset: 0x205B2F0 VA: 0x18205C0F0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x173D3E0 Offset: 0x173C5E0 VA: 0x18173D3E0 Slot: 22
	public override void Flush() { }

	// RVA: 0x213A1D0 Offset: 0x21393D0 VA: 0x18213A1D0 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x173D050 Offset: 0x173C250 VA: 0x18173D050 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x205C290 Offset: 0x205B490 VA: 0x18205C290 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x22534B0 Offset: 0x22526B0 VA: 0x1822534B0 Slot: 38
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x205C260 Offset: 0x205B460 VA: 0x18205C260 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x2253480 Offset: 0x2252680 VA: 0x182253480 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2253420 Offset: 0x2252620 VA: 0x182253420 Slot: 31
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x205BFA0 Offset: 0x205B1A0 VA: 0x18205BFA0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x205C120 Offset: 0x205B320 VA: 0x18205C120 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x22532D0 Offset: 0x22524D0 VA: 0x1822532D0 Slot: 18
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }
}

// Namespace: 
private sealed class ManagedWebSocket.Utf8MessageState // TypeDefIndex: 6294
{
	// Fields
	internal bool SequenceInProgress; // 0x10
	internal int AdditionalBytesExpected; // 0x14
	internal int ExpectedValueMin; // 0x18
	internal int CurrentDecodeBits; // 0x1C

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private enum ManagedWebSocket.MessageOpcode // TypeDefIndex: 6295
{
	// Fields
	public byte value__; // 0x0
	public const ManagedWebSocket.MessageOpcode Continuation = 0;
	public const ManagedWebSocket.MessageOpcode Text = 1;
	public const ManagedWebSocket.MessageOpcode Binary = 2;
	public const ManagedWebSocket.MessageOpcode Close = 8;
	public const ManagedWebSocket.MessageOpcode Ping = 9;
	public const ManagedWebSocket.MessageOpcode Pong = 10;
}

// Namespace: 
private struct ManagedWebSocket.MessageHeader // TypeDefIndex: 6296
{
	// Fields
	internal ManagedWebSocket.MessageOpcode Opcode; // 0x0
	internal bool Fin; // 0x1
	internal long PayloadLength; // 0x8
	internal int Mask; // 0x10
}

// Namespace: 
private interface ManagedWebSocket.IWebSocketReceiveResultGetter<TResult> // TypeDefIndex: 6297
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TResult GetResult(int count, WebSocketMessageType messageType, bool endOfMessage, Nullable<WebSocketCloseStatus> closeStatus, string closeDescription);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ManagedWebSocket.IWebSocketReceiveResultGetter<__Il2CppFullySharedGenericType>.GetResult
	*/
}

// Namespace: 
[IsReadOnly]
private struct ManagedWebSocket.WebSocketReceiveResultGetter : ManagedWebSocket.IWebSocketReceiveResultGetter<WebSocketReceiveResult> // TypeDefIndex: 6298
{
	// Methods

	// RVA: 0x2267840 Offset: 0x2266A40 VA: 0x182267840 Slot: 4
	public WebSocketReceiveResult GetResult(int count, WebSocketMessageType messageType, bool endOfMessage, Nullable<WebSocketCloseStatus> closeStatus, string closeDescription) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ManagedWebSocket.<>c // TypeDefIndex: 6299
{
	// Fields
	public static readonly ManagedWebSocket.<>c <>9; // 0x0
	public static Action<object> <>9__36_0; // 0x8
	public static TimerCallback <>9__36_1; // 0x10
	public static Action<object> <>9__56_0; // 0x18
	public static Action<Task> <>9__58_0; // 0x20
	public static Action<object> <>9__63_0; // 0x28

	// Methods

	// RVA: 0x22650A0 Offset: 0x22642A0 VA: 0x1822650A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2264D20 Offset: 0x2263F20 VA: 0x182264D20
	internal void <.ctor>b__36_0(object s) { }

	// RVA: 0x2264E20 Offset: 0x2264020 VA: 0x182264E20
	internal void <.ctor>b__36_1(object s) { }

	// RVA: 0x2264C20 Offset: 0x2263E20 VA: 0x182264C20
	internal void <SendFrameFallbackAsync>b__56_0(object s) { }

	// RVA: 0x2264C90 Offset: 0x2263E90 VA: 0x182264C90
	internal void <SendKeepAliveFrameAsync>b__58_0(Task p) { }

	// RVA: 0x2264CB0 Offset: 0x2263EB0 VA: 0x182264CB0
	internal void <WaitForServerToCloseConnectionAsync>b__63_0(object s) { }
}

// Namespace: 
[CompilerGenerated]
private struct ManagedWebSocket.<WaitForWriteTaskAsync>d__55 : IAsyncStateMachine // TypeDefIndex: 6300
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ValueTask writeTask; // 0x20
	public ManagedWebSocket <>4__this; // 0x30
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x2265840 Offset: 0x2264A40 VA: 0x182265840 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2265CE0 Offset: 0x2264EE0 VA: 0x182265CE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ManagedWebSocket.<SendFrameFallbackAsync>d__56 : IAsyncStateMachine // TypeDefIndex: 6301
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ManagedWebSocket <>4__this; // 0x20
	public ManagedWebSocket.MessageOpcode opcode; // 0x28
	public bool endOfMessage; // 0x29
	public ReadOnlyMemory<byte> payloadBuffer; // 0x30
	public CancellationToken cancellationToken; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48
	private CancellationTokenRegistration <>7__wrap1; // 0x58
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__2; // 0x70

	// Methods

	// RVA: 0x2263BA0 Offset: 0x2262DA0 VA: 0x182263BA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x22644F0 Offset: 0x22636F0 VA: 0x1822644F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ManagedWebSocket.<>c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult> // TypeDefIndex: 6302
{
	// Fields
	public static readonly ManagedWebSocket.<>c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult> <>9; // 0x0
	public static Action<object> <>9__61_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-ManagedWebSocket.<>c__61<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>..cctor
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-ManagedWebSocket.<>c__61<ManagedWebSocket.WebSocketReceiveResultGetter, object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ManagedWebSocket.<>c__61<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>..ctor
	|-ManagedWebSocket.<>c__61<ManagedWebSocket.WebSocketReceiveResultGetter, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ReceiveAsyncPrivate>b__61_0(object s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB09980 Offset: 0xB08B80 VA: 0x180B09980
	|-ManagedWebSocket.<>c__61<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>.<ReceiveAsyncPrivate>b__61_0
	|
	|-RVA: 0xB09910 Offset: 0xB08B10 VA: 0x180B09910
	|-ManagedWebSocket.<>c__61<ManagedWebSocket.WebSocketReceiveResultGetter, object>.<ReceiveAsyncPrivate>b__61_0
	*/
}

// Namespace: 
[CompilerGenerated]
private struct ManagedWebSocket.<ReceiveAsyncPrivate>d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult> : IAsyncStateMachine // TypeDefIndex: 6303
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder<TWebSocketReceiveResult> <>t__builder; // 0x0
	public CancellationToken cancellationToken; // 0x0
	public ManagedWebSocket <>4__this; // 0x0
	public TWebSocketReceiveResultGetter resultGetter; // 0x0
	public Memory<byte> payloadBuffer; // 0x0
	private CancellationTokenRegistration <registration>5__2; // 0x0
	private ManagedWebSocket.MessageHeader <header>5__3; // 0x0
	private int <totalBytesReceived>5__4; // 0x0
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x0
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB277C0 Offset: 0xB269C0 VA: 0x180B277C0
	|-ManagedWebSocket.<ReceiveAsyncPrivate>d__61<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0xB25FB0 Offset: 0xB251B0 VA: 0x180B25FB0
	|-ManagedWebSocket.<ReceiveAsyncPrivate>d__61<ManagedWebSocket.WebSocketReceiveResultGetter, object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2AE30 Offset: 0xB2A030 VA: 0x180B2AE30
	|-ManagedWebSocket.<ReceiveAsyncPrivate>d__61<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>.SetStateMachine
	|
	|-RVA: 0xB2ADE0 Offset: 0xB29FE0 VA: 0x180B2ADE0
	|-ManagedWebSocket.<ReceiveAsyncPrivate>d__61<ManagedWebSocket.WebSocketReceiveResultGetter, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGenerated]
private struct ManagedWebSocket.<HandleReceivedCloseAsync>d__62 : IAsyncStateMachine // TypeDefIndex: 6304
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ManagedWebSocket <>4__this; // 0x20
	public ManagedWebSocket.MessageHeader header; // 0x28
	public CancellationToken cancellationToken; // 0x40
	private WebSocketCloseStatus <closeStatus>5__2; // 0x48
	private string <closeStatusDescription>5__3; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0x2260DE0 Offset: 0x225FFE0 VA: 0x182260DE0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x22617A0 Offset: 0x22609A0 VA: 0x1822617A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ManagedWebSocket.<WaitForServerToCloseConnectionAsync>d__63 : IAsyncStateMachine // TypeDefIndex: 6305
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ManagedWebSocket <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private CancellationTokenSource <finalCts>5__2; // 0x30
	private CancellationTokenRegistration <>7__wrap2; // 0x38
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__1; // 0x50

	// Methods

	// RVA: 0x2265100 Offset: 0x2264300 VA: 0x182265100 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x22657E0 Offset: 0x22649E0 VA: 0x1822657E0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ManagedWebSocket.<HandleReceivedPingPongAsync>d__64 : IAsyncStateMachine // TypeDefIndex: 6306
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ManagedWebSocket.MessageHeader header; // 0x20
	public ManagedWebSocket <>4__this; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__2; // 0x58

	// Methods

	// RVA: 0x2261800 Offset: 0x2260A00 VA: 0x182261800 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2261D20 Offset: 0x2260F20 VA: 0x182261D20 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ManagedWebSocket.<CloseWithReceiveErrorAndThrowAsync>d__66 : IAsyncStateMachine // TypeDefIndex: 6307
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ManagedWebSocket <>4__this; // 0x20
	public WebSocketCloseStatus closeStatus; // 0x28
	public WebSocketError error; // 0x2C
	public Exception innerException; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x225E6B0 Offset: 0x225D8B0 VA: 0x18225E6B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x225E8B0 Offset: 0x225DAB0 VA: 0x18225E8B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ManagedWebSocket.<CloseAsyncPrivate>d__68 : IAsyncStateMachine // TypeDefIndex: 6308
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ManagedWebSocket <>4__this; // 0x20
	public WebSocketCloseStatus closeStatus; // 0x28
	public string statusDescription; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private byte[] <closeBuffer>5__2; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x225DFB0 Offset: 0x225D1B0 VA: 0x18225DFB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x225E650 Offset: 0x225D850 VA: 0x18225E650 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ManagedWebSocket.<SendCloseFrameAsync>d__69 : IAsyncStateMachine // TypeDefIndex: 6309
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string closeStatusDescription; // 0x20
	public WebSocketCloseStatus closeStatus; // 0x28
	public ManagedWebSocket <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private byte[] <buffer>5__2; // 0x40
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x58

	// Methods

	// RVA: 0x2263320 Offset: 0x2262520 VA: 0x182263320 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2263B40 Offset: 0x2262D40 VA: 0x182263B40 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ManagedWebSocket.<EnsureBufferContainsAsync>d__71 : IAsyncStateMachine // TypeDefIndex: 6310
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ManagedWebSocket <>4__this; // 0x20
	public int minimumRequiredBytes; // 0x28
	public CancellationToken cancellationToken; // 0x30
	public bool throwOnPrematureClosure; // 0x38
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__1; // 0x40

	// Methods

	// RVA: 0x2260840 Offset: 0x225FA40 VA: 0x182260840 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2260D80 Offset: 0x225FF80 VA: 0x182260D80 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net.WebSockets
internal sealed class ManagedWebSocket : WebSocket // TypeDefIndex: 6311
{
	// Fields
	private static readonly RandomNumberGenerator s_random; // 0x0
	private static readonly UTF8Encoding s_textEncoding; // 0x8
	private static readonly WebSocketState[] s_validSendStates; // 0x10
	private static readonly WebSocketState[] s_validReceiveStates; // 0x18
	private static readonly WebSocketState[] s_validCloseOutputStates; // 0x20
	private static readonly WebSocketState[] s_validCloseStates; // 0x28
	private static readonly Task<WebSocketReceiveResult> s_cachedCloseTask; // 0x30
	internal const int MaxMessageHeaderLength = 14;
	private const int MaxControlPayloadLength = 125;
	private const int MaskLength = 4;
	private readonly Stream _stream; // 0x10
	private readonly bool _isServer; // 0x18
	private readonly string _subprotocol; // 0x20
	private readonly Timer _keepAliveTimer; // 0x28
	private readonly CancellationTokenSource _abortSource; // 0x30
	private Memory<byte> _receiveBuffer; // 0x38
	private readonly ManagedWebSocket.Utf8MessageState _utf8TextState; // 0x48
	private readonly SemaphoreSlim _sendFrameAsyncLock; // 0x50
	private WebSocketState _state; // 0x58
	private bool _disposed; // 0x5C
	private bool _sentCloseFrame; // 0x5D
	private bool _receivedCloseFrame; // 0x5E
	private Nullable<WebSocketCloseStatus> _closeStatus; // 0x60
	private string _closeStatusDescription; // 0x68
	private ManagedWebSocket.MessageHeader _lastReceiveHeader; // 0x70
	private int _receiveBufferOffset; // 0x88
	private int _receiveBufferCount; // 0x8C
	private int _receivedMaskOffsetOffset; // 0x90
	private byte[] _sendBuffer; // 0x98
	private bool _lastSendWasFragment; // 0xA0
	private Task _lastReceiveAsync; // 0xA8

	// Properties
	private object StateUpdateLock { get; }
	private object ReceiveAsyncLock { get; }
	public override Nullable<WebSocketCloseStatus> CloseStatus { get; }
	public override string CloseStatusDescription { get; }
	public override WebSocketState State { get; }
	public override string SubProtocol { get; }

	// Methods

	// RVA: 0x2254120 Offset: 0x2253320 VA: 0x182254120
	public static ManagedWebSocket CreateFromConnectedStream(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	private object get_StateUpdateLock() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	private object get_ReceiveAsyncLock() { }

	// RVA: 0x2256E80 Offset: 0x2256080 VA: 0x182256E80
	private void .ctor(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval) { }

	// RVA: 0x22542C0 Offset: 0x22534C0 VA: 0x1822542C0 Slot: 12
	public override void Dispose() { }

	// RVA: 0x2254270 Offset: 0x2253470 VA: 0x182254270
	private void DisposeCore() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 5
	public override Nullable<WebSocketCloseStatus> get_CloseStatus() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 6
	public override string get_CloseStatusDescription() { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20 Slot: 8
	public override WebSocketState get_State() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 7
	public override string get_SubProtocol() { }

	// RVA: 0x2254A40 Offset: 0x2253C40 VA: 0x182254A40 Slot: 14
	public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	// RVA: 0x2255950 Offset: 0x2254B50 VA: 0x182255950
	private ValueTask SendPrivateAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	// RVA: 0x22546C0 Offset: 0x22538C0 VA: 0x1822546C0 Slot: 13
	public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2253C90 Offset: 0x2252E90 VA: 0x182253C90 Slot: 10
	public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	// RVA: 0x2253E40 Offset: 0x2253040 VA: 0x182253E40 Slot: 11
	public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	// RVA: 0x22538F0 Offset: 0x2252AF0 VA: 0x1822538F0 Slot: 9
	public override void Abort() { }

	// RVA: 0x2254E20 Offset: 0x2254020 VA: 0x182254E20
	private ValueTask SendFrameAsync(ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x2255120 Offset: 0x2254320 VA: 0x182255120
	private ValueTask SendFrameLockAcquiredNonCancelableAsync(ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer) { }

	[AsyncStateMachine(typeof(ManagedWebSocket.<WaitForWriteTaskAsync>d__55))]
	// RVA: 0x2256570 Offset: 0x2255770 VA: 0x182256570
	private Task WaitForWriteTaskAsync(ValueTask writeTask) { }

	[AsyncStateMachine(typeof(ManagedWebSocket.<SendFrameFallbackAsync>d__56))]
	// RVA: 0x2255000 Offset: 0x2254200 VA: 0x182255000
	private Task SendFrameFallbackAsync(ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x2256650 Offset: 0x2255850 VA: 0x182256650
	private int WriteFrameToSendBuffer(ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, ReadOnlySpan<byte> payloadBuffer) { }

	// RVA: 0x2255580 Offset: 0x2254780 VA: 0x182255580
	private void SendKeepAliveFrameAsync() { }

	// RVA: 0x22569C0 Offset: 0x2255BC0 VA: 0x1822569C0
	private static int WriteHeader(ManagedWebSocket.MessageOpcode opcode, byte[] sendBuffer, ReadOnlySpan<byte> payload, bool endOfMessage, bool useMask) { }

	// RVA: 0x2256BA0 Offset: 0x2255DA0 VA: 0x182256BA0
	private static void WriteRandomMask(byte[] buffer, int offset) { }

	[AsyncStateMachine(typeof(ManagedWebSocket.<ReceiveAsyncPrivate>d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>))]
	// RVA: -1 Offset: -1
	private ValueTask<TWebSocketReceiveResult> ReceiveAsyncPrivate<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>(Memory<byte> payloadBuffer, CancellationToken cancellationToken, TWebSocketReceiveResultGetter resultGetter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA44BC0 Offset: 0xA43DC0 VA: 0x180A44BC0
	|-ManagedWebSocket.ReceiveAsyncPrivate<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0xA44E90 Offset: 0xA44090 VA: 0x180A44E90
	|-ManagedWebSocket.ReceiveAsyncPrivate<ManagedWebSocket.WebSocketReceiveResultGetter, object>
	*/

	[AsyncStateMachine(typeof(ManagedWebSocket.<HandleReceivedCloseAsync>d__62))]
	// RVA: 0x2254480 Offset: 0x2253680 VA: 0x182254480
	private Task HandleReceivedCloseAsync(ManagedWebSocket.MessageHeader header, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(ManagedWebSocket.<WaitForServerToCloseConnectionAsync>d__63))]
	// RVA: 0x2256490 Offset: 0x2255690 VA: 0x182256490
	private Task WaitForServerToCloseConnectionAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(ManagedWebSocket.<HandleReceivedPingPongAsync>d__64))]
	// RVA: 0x2254580 Offset: 0x2253780 VA: 0x182254580
	private Task HandleReceivedPingPongAsync(ManagedWebSocket.MessageHeader header, CancellationToken cancellationToken) { }

	// RVA: 0x2254680 Offset: 0x2253880 VA: 0x182254680
	private static bool IsValidCloseStatus(WebSocketCloseStatus closeStatus) { }

	[AsyncStateMachine(typeof(ManagedWebSocket.<CloseWithReceiveErrorAndThrowAsync>d__66))]
	// RVA: 0x2253F40 Offset: 0x2253140 VA: 0x182253F40
	private Task CloseWithReceiveErrorAndThrowAsync(WebSocketCloseStatus closeStatus, WebSocketError error, Exception innerException) { }

	// RVA: 0x2255DD0 Offset: 0x2254FD0 VA: 0x182255DD0
	private bool TryParseMessageHeaderFromReceiveBuffer(out ManagedWebSocket.MessageHeader resultHeader) { }

	[AsyncStateMachine(typeof(ManagedWebSocket.<CloseAsyncPrivate>d__68))]
	// RVA: 0x2253B90 Offset: 0x2252D90 VA: 0x182253B90
	private Task CloseAsyncPrivate(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(ManagedWebSocket.<SendCloseFrameAsync>d__69))]
	// RVA: 0x2254D10 Offset: 0x2253F10 VA: 0x182254D10
	private Task SendCloseFrameAsync(WebSocketCloseStatus closeStatus, string closeStatusDescription, CancellationToken cancellationToken) { }

	// RVA: 0x2254110 Offset: 0x2253310 VA: 0x182254110
	private void ConsumeFromBuffer(int count) { }

	[AsyncStateMachine(typeof(ManagedWebSocket.<EnsureBufferContainsAsync>d__71))]
	// RVA: 0x2254380 Offset: 0x2253580 VA: 0x182254380
	private Task EnsureBufferContainsAsync(int minimumRequiredBytes, CancellationToken cancellationToken, bool throwOnPrematureClosure = True) { }

	// RVA: 0x2255C80 Offset: 0x2254E80 VA: 0x182255C80
	private void ThrowIfEOFUnexpected(bool throwOnPrematureClosure) { }

	// RVA: 0x2253930 Offset: 0x2252B30 VA: 0x182253930
	private void AllocateSendBuffer(int minLength) { }

	// RVA: 0x22549A0 Offset: 0x2253BA0 VA: 0x1822549A0
	private void ReleaseSendBuffer() { }

	// RVA: 0x2254040 Offset: 0x2253240 VA: 0x182254040
	private static int CombineMaskBytes(Span<byte> buffer, int maskOffset) { }

	// RVA: 0x22539C0 Offset: 0x2252BC0 VA: 0x1822539C0
	private static int ApplyMask(Span<byte> toMask, byte[] mask, int maskOffset, int maskOffsetIndex) { }

	// RVA: 0x2253A80 Offset: 0x2252C80 VA: 0x182253A80
	private static int ApplyMask(Span<byte> toMask, int mask, int maskIndex) { }

	// RVA: 0x2255D20 Offset: 0x2254F20 VA: 0x182255D20
	private void ThrowIfOperationInProgress(bool operationCompleted, string methodName) { }

	// RVA: 0x2255D60 Offset: 0x2254F60 VA: 0x182255D60
	private void ThrowOperationInProgress(string methodName) { }

	// RVA: 0x22541B0 Offset: 0x22533B0 VA: 0x1822541B0
	private static Exception CreateOperationCanceledException(Exception innerException, CancellationToken cancellationToken) { }

	// RVA: 0x2256130 Offset: 0x2255330 VA: 0x182256130
	private static bool TryValidateUtf8(Span<byte> span, bool endOfMessage, ManagedWebSocket.Utf8MessageState state) { }

	// RVA: 0x22562D0 Offset: 0x22554D0 VA: 0x1822562D0
	private Task ValidateAndReceiveAsync(Task receiveTask, byte[] buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2256C30 Offset: 0x2255E30 VA: 0x182256C30
	private static void .cctor() { }
}

// Namespace: System.Net.WebSockets
internal static class WebSocketValidate // TypeDefIndex: 6312
{
	// Fields
	internal const int MaxControlFramePayloadLength = 123;
	private const int CloseStatusCodeAbort = 1006;
	private const int CloseStatusCodeFailedTLSHandshake = 1015;
	private const int InvalidCloseStatusCodesFrom = 0;
	private const int InvalidCloseStatusCodesTo = 999;
	private const string Separators = "()<>@,;:\\\"/[]?={} ";

	// Methods

	// RVA: 0x22679A0 Offset: 0x2266BA0 VA: 0x1822679A0
	internal static void ThrowIfInvalidState(WebSocketState currentState, bool isDisposed, WebSocketState[] validStates) { }

	// RVA: 0x2268110 Offset: 0x2267310 VA: 0x182268110
	internal static void ValidateSubprotocol(string subProtocol) { }

	// RVA: 0x2267EC0 Offset: 0x22670C0 VA: 0x182267EC0
	internal static void ValidateCloseStatus(WebSocketCloseStatus closeStatus, string statusDescription) { }

	// RVA: 0x2267B40 Offset: 0x2266D40 VA: 0x182267B40
	internal static void ThrowPlatformNotSupportedException() { }

	// RVA: 0x2267B90 Offset: 0x2266D90 VA: 0x182267B90
	internal static void ValidateArraySegment(ArraySegment<byte> arraySegment, string parameterName) { }

	// RVA: 0x2267DB0 Offset: 0x2266FB0 VA: 0x182267DB0
	internal static void ValidateBuffer(byte[] buffer, int offset, int count) { }
}

// Namespace: System.Net.WebSockets
public class HttpListenerWebSocketContext : WebSocketContext // TypeDefIndex: 6313
{
	// Fields
	private readonly Uri _requestUri; // 0x10
	private readonly NameValueCollection _headers; // 0x18
	private readonly CookieCollection _cookieCollection; // 0x20
	private readonly IPrincipal _user; // 0x28
	private readonly bool _isAuthenticated; // 0x30
	private readonly bool _isLocal; // 0x31
	private readonly bool _isSecureConnection; // 0x32
	private readonly string _origin; // 0x38
	private readonly IEnumerable<string> _secWebSocketProtocols; // 0x40
	private readonly string _secWebSocketVersion; // 0x48
	private readonly string _secWebSocketKey; // 0x50
	private readonly WebSocket _webSocket; // 0x58

	// Properties
	public override Uri RequestUri { get; }
	public override NameValueCollection Headers { get; }
	public override string Origin { get; }
	public override IEnumerable<string> SecWebSocketProtocols { get; }
	public override string SecWebSocketVersion { get; }
	public override string SecWebSocketKey { get; }
	public override CookieCollection CookieCollection { get; }
	public override IPrincipal User { get; }
	public override bool IsAuthenticated { get; }
	public override bool IsLocal { get; }
	public override bool IsSecureConnection { get; }
	public override WebSocket WebSocket { get; }

	// Methods

	// RVA: 0x2253790 Offset: 0x2252990 VA: 0x182253790
	internal void .ctor(Uri requestUri, NameValueCollection headers, CookieCollection cookieCollection, IPrincipal user, bool isAuthenticated, bool isLocal, bool isSecureConnection, string origin, IEnumerable<string> secWebSocketProtocols, string secWebSocketVersion, string secWebSocketKey, WebSocket webSocket) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public override Uri get_RequestUri() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public override NameValueCollection get_Headers() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 6
	public override string get_Origin() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 7
	public override IEnumerable<string> get_SecWebSocketProtocols() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 8
	public override string get_SecWebSocketVersion() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 9
	public override string get_SecWebSocketKey() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 10
	public override CookieCollection get_CookieCollection() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 11
	public override IPrincipal get_User() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40 Slot: 12
	public override bool get_IsAuthenticated() { }

	// RVA: 0x577B10 Offset: 0x576D10 VA: 0x180577B10 Slot: 13
	public override bool get_IsLocal() { }

	// RVA: 0x21BAF40 Offset: 0x21BA140 VA: 0x1821BAF40 Slot: 14
	public override bool get_IsSecureConnection() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 15
	public override WebSocket get_WebSocket() { }

	// RVA: 0x2253550 Offset: 0x2252750 VA: 0x182253550
	private static IPrincipal CopyPrincipal(IPrincipal user) { }

	// RVA: 0x22538C0 Offset: 0x2252AC0 VA: 0x1822538C0
	internal void .ctor() { }
}

// Namespace: 
private enum ClientWebSocket.InternalState // TypeDefIndex: 6314
{
	// Fields
	public int value__; // 0x0
	public const ClientWebSocket.InternalState Created = 0;
	public const ClientWebSocket.InternalState Connecting = 1;
	public const ClientWebSocket.InternalState Connected = 2;
	public const ClientWebSocket.InternalState Disposed = 3;
}

// Namespace: 
internal sealed class ClientWebSocket.DefaultWebProxy : IWebProxy // TypeDefIndex: 6315
{
	// Fields
	[CompilerGenerated]
	private static readonly ClientWebSocket.DefaultWebProxy <Instance>k__BackingField; // 0x0

	// Properties
	public static ClientWebSocket.DefaultWebProxy Instance { get; }
	public ICredentials Credentials { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2253240 Offset: 0x2252440 VA: 0x182253240
	public static ClientWebSocket.DefaultWebProxy get_Instance() { }

	// RVA: 0x2253200 Offset: 0x2252400 VA: 0x182253200 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x2253290 Offset: 0x2252490 VA: 0x182253290 Slot: 7
	public void set_Credentials(ICredentials value) { }

	// RVA: 0x2253120 Offset: 0x2252320 VA: 0x182253120 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x2253160 Offset: 0x2252360 VA: 0x182253160 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x22531A0 Offset: 0x22523A0 VA: 0x1822531A0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct ClientWebSocket.<ConnectAsyncCore>d__16 : IAsyncStateMachine // TypeDefIndex: 6316
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ClientWebSocket <>4__this; // 0x20
	public Uri uri; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x225E910 Offset: 0x225DB10 VA: 0x18225E910 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x225ED60 Offset: 0x225DF60 VA: 0x18225ED60 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net.WebSockets
public sealed class ClientWebSocket : WebSocket // TypeDefIndex: 6317
{
	// Fields
	private readonly ClientWebSocketOptions _options; // 0x10
	private WebSocketHandle _innerWebSocket; // 0x18
	private int _state; // 0x20

	// Properties
	public ClientWebSocketOptions Options { get; }
	public override Nullable<WebSocketCloseStatus> CloseStatus { get; }
	public override string CloseStatusDescription { get; }
	public override string SubProtocol { get; }
	public override WebSocketState State { get; }

	// Methods

	// RVA: 0x2252BF0 Offset: 0x2251DF0 VA: 0x182252BF0
	public void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ClientWebSocketOptions get_Options() { }

	// RVA: 0x2252F40 Offset: 0x2252140 VA: 0x182252F40 Slot: 5
	public override Nullable<WebSocketCloseStatus> get_CloseStatus() { }

	// RVA: 0x2252EB0 Offset: 0x22520B0 VA: 0x182252EB0 Slot: 6
	public override string get_CloseStatusDescription() { }

	// RVA: 0x2253090 Offset: 0x2252290 VA: 0x182253090 Slot: 7
	public override string get_SubProtocol() { }

	// RVA: 0x2252FD0 Offset: 0x22521D0 VA: 0x182252FD0 Slot: 8
	public override WebSocketState get_State() { }

	// RVA: 0x2252490 Offset: 0x2251690 VA: 0x182252490
	public Task ConnectAsync(Uri uri, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(ClientWebSocket.<ConnectAsyncCore>d__16))]
	// RVA: 0x22523A0 Offset: 0x22515A0 VA: 0x1822523A0
	private Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken) { }

	// RVA: 0x22529E0 Offset: 0x2251BE0 VA: 0x1822529E0 Slot: 14
	public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	// RVA: 0x2252A70 Offset: 0x2251C70 VA: 0x182252A70 Slot: 16
	public override ValueTask SendAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	// RVA: 0x22528D0 Offset: 0x2251AD0 VA: 0x1822528D0 Slot: 13
	public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2252940 Offset: 0x2251B40 VA: 0x182252940 Slot: 15
	public override ValueTask<ValueWebSocketReceiveResult> ReceiveAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x22522A0 Offset: 0x22514A0 VA: 0x1822522A0 Slot: 10
	public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	// RVA: 0x2252320 Offset: 0x2251520 VA: 0x182252320 Slot: 11
	public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	// RVA: 0x22521F0 Offset: 0x22513F0 VA: 0x1822521F0 Slot: 9
	public override void Abort() { }

	// RVA: 0x2252820 Offset: 0x2251A20 VA: 0x182252820 Slot: 12
	public override void Dispose() { }

	// RVA: 0x2252B20 Offset: 0x2251D20 VA: 0x182252B20
	private void ThrowIfNotConnected() { }
}

// Namespace: System.Net.WebSockets
public sealed class ClientWebSocketOptions // TypeDefIndex: 6318
{
	// Fields
	private bool _isReadOnly; // 0x10
	private readonly List<string> _requestedSubProtocols; // 0x18
	private readonly WebHeaderCollection _requestHeaders; // 0x20
	private TimeSpan _keepAliveInterval; // 0x28
	private bool _useDefaultCredentials; // 0x30
	private ICredentials _credentials; // 0x38
	private IWebProxy _proxy; // 0x40
	private X509CertificateCollection _clientCertificates; // 0x48
	private CookieContainer _cookies; // 0x50
	private int _receiveBufferSize; // 0x58
	private int _sendBufferSize; // 0x5C
	private Nullable<ArraySegment<byte>> _buffer; // 0x60
	private RemoteCertificateValidationCallback _remoteCertificateValidationCallback; // 0x78

	// Properties
	internal WebHeaderCollection RequestHeaders { get; }
	internal List<string> RequestedSubProtocols { get; }
	public bool UseDefaultCredentials { get; set; }
	public ICredentials Credentials { get; set; }
	public IWebProxy Proxy { get; set; }
	public X509CertificateCollection ClientCertificates { get; set; }
	public RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public CookieContainer Cookies { get; set; }
	public TimeSpan KeepAliveInterval { get; set; }
	internal int ReceiveBufferSize { get; }
	internal int SendBufferSize { get; }
	internal Nullable<ArraySegment<byte>> Buffer { get; }

	// Methods

	// RVA: 0x2251B80 Offset: 0x2250D80 VA: 0x182251B80
	internal void .ctor() { }

	// RVA: 0x2251A80 Offset: 0x2250C80 VA: 0x182251A80
	public void SetRequestHeader(string headerName, string headerValue) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal WebHeaderCollection get_RequestHeaders() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal List<string> get_RequestedSubProtocols() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x2252180 Offset: 0x2251380 VA: 0x182252180
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public ICredentials get_Credentials() { }

	// RVA: 0x2251E20 Offset: 0x2251020 VA: 0x182251E20
	public void set_Credentials(ICredentials value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public IWebProxy get_Proxy() { }

	// RVA: 0x22520A0 Offset: 0x22512A0 VA: 0x1822520A0
	public void set_Proxy(IWebProxy value) { }

	// RVA: 0x2251C90 Offset: 0x2250E90 VA: 0x182251C90
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x2251D00 Offset: 0x2250F00 VA: 0x182251D00
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public RemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	// RVA: 0x2252110 Offset: 0x2251310 VA: 0x182252110
	public void set_RemoteCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public CookieContainer get_Cookies() { }

	// RVA: 0x2251DB0 Offset: 0x2250FB0 VA: 0x182251DB0
	public void set_Cookies(CookieContainer value) { }

	// RVA: 0x22512D0 Offset: 0x22504D0 VA: 0x1822512D0
	public void AddSubProtocol(string subProtocol) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public TimeSpan get_KeepAliveInterval() { }

	// RVA: 0x2251E90 Offset: 0x2251090 VA: 0x182251E90
	public void set_KeepAliveInterval(TimeSpan value) { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	internal int get_ReceiveBufferSize() { }

	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10
	internal int get_SendBufferSize() { }

	// RVA: 0x2251C70 Offset: 0x2250E70 VA: 0x182251C70
	internal Nullable<ArraySegment<byte>> get_Buffer() { }

	// RVA: 0x2251880 Offset: 0x2250A80 VA: 0x182251880
	public void SetBuffer(int receiveBufferSize, int sendBufferSize) { }

	// RVA: 0x2251560 Offset: 0x2250760 VA: 0x182251560
	public void SetBuffer(int receiveBufferSize, int sendBufferSize, ArraySegment<byte> buffer) { }

	// RVA: 0x21A55F0 Offset: 0x21A47F0 VA: 0x1821A55F0
	internal void SetToReadOnly() { }

	// RVA: 0x2251B10 Offset: 0x2250D10 VA: 0x182251B10
	private void ThrowIfReadOnly() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class WebSocketHandle.<>c // TypeDefIndex: 6319
{
	// Fields
	public static readonly WebSocketHandle.<>c <>9; // 0x0
	public static Action<object> <>9__26_0; // 0x8
	public static Action<object> <>9__27_0; // 0x10
	public static Action<object> <>9__27_1; // 0x18

	// Methods

	// RVA: 0x2265040 Offset: 0x2264240 VA: 0x182265040
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x22649E0 Offset: 0x2263BE0 VA: 0x1822649E0
	internal void <ConnectAsyncCore>b__26_0(object s) { }

	// RVA: 0x2264A80 Offset: 0x2263C80 VA: 0x182264A80
	internal void <ConnectSocketAsync>b__27_0(object s) { }

	// RVA: 0x2264B50 Offset: 0x2263D50 VA: 0x182264B50
	internal void <ConnectSocketAsync>b__27_1(object s) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebSocketHandle.<ConnectAsyncCore>d__26 : IAsyncStateMachine // TypeDefIndex: 6320
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public WebSocketHandle <>4__this; // 0x28
	public Uri uri; // 0x30
	public ClientWebSocketOptions options; // 0x38
	private CancellationTokenRegistration <registration>5__2; // 0x40
	private Stream <stream>5__3; // 0x58
	private KeyValuePair<string, string> <secKeyAndSecWebSocketAccept>5__4; // 0x60
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Socket> <>u__1; // 0x70
	private SslStream <sslStream>5__5; // 0x80
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x88
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__3; // 0x98

	// Methods

	// RVA: 0x225EDC0 Offset: 0x225DFC0 VA: 0x18225EDC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x225FC90 Offset: 0x225EE90 VA: 0x18225FC90 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebSocketHandle.<ConnectSocketAsync>d__27 : IAsyncStateMachine // TypeDefIndex: 6321
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Socket> <>t__builder; // 0x8
	public string host; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public WebSocketHandle <>4__this; // 0x30
	public int port; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<IPAddress[]> <>u__1; // 0x40
	private IPAddress[] <>7__wrap1; // 0x50
	private int <>7__wrap2; // 0x58
	private Socket <socket>5__4; // 0x60
	private CancellationTokenRegistration <>7__wrap4; // 0x68
	private CancellationTokenRegistration <>7__wrap5; // 0x80
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x98

	// Methods

	// RVA: 0x225FCF0 Offset: 0x225EEF0 VA: 0x18225FCF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x22607D0 Offset: 0x225F9D0 VA: 0x1822607D0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebSocketHandle.<>c__DisplayClass30_0 // TypeDefIndex: 6322
{
	// Fields
	public string headerValue; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2264E90 Offset: 0x2264090 VA: 0x182264E90
	internal bool <ParseAndValidateConnectResponseAsync>b__0(string requested) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebSocketHandle.<ParseAndValidateConnectResponseAsync>d__30 : IAsyncStateMachine // TypeDefIndex: 6323
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public Stream stream; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public string expectedSecWebSocketAccept; // 0x30
	public ClientWebSocketOptions options; // 0x38
	private bool <foundUpgrade>5__2; // 0x40
	private bool <foundConnection>5__3; // 0x41
	private bool <foundSecWebSocketAccept>5__4; // 0x42
	private string <subprotocol>5__5; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__1; // 0x50

	// Methods

	// RVA: 0x2261D80 Offset: 0x2260F80 VA: 0x182261D80 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2262610 Offset: 0x2261810 VA: 0x182262610 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebSocketHandle.<ReadResponseHeaderLineAsync>d__32 : IAsyncStateMachine // TypeDefIndex: 6324
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public Stream stream; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private StringBuilder <sb>5__2; // 0x30
	private byte[] <arr>5__3; // 0x38
	private char <prevChar>5__4; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x2262680 Offset: 0x2261880 VA: 0x182262680 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2262BD0 Offset: 0x2261DD0 VA: 0x182262BD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net.WebSockets
internal sealed class WebSocketHandle // TypeDefIndex: 6325
{
	// Fields
	[ThreadStatic]
	private static StringBuilder t_cachedStringBuilder; // 0x80000000
	private static readonly Encoding s_defaultHttpEncoding; // 0x0
	private const int DefaultReceiveBufferSize = 4096;
	private const string WSServerGuid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";
	private readonly CancellationTokenSource _abortSource; // 0x10
	private WebSocketState _state; // 0x18
	private WebSocket _webSocket; // 0x20

	// Properties
	public Nullable<WebSocketCloseStatus> CloseStatus { get; }
	public string CloseStatusDescription { get; }
	public WebSocketState State { get; }
	public string SubProtocol { get; }

	// Methods

	// RVA: 0x2267160 Offset: 0x2266360 VA: 0x182267160
	public static WebSocketHandle Create() { }

	// RVA: 0x17738B0 Offset: 0x1772AB0 VA: 0x1817738B0
	public static bool IsValid(WebSocketHandle handle) { }

	// RVA: 0x22677D0 Offset: 0x22669D0 VA: 0x1822677D0
	public Nullable<WebSocketCloseStatus> get_CloseStatus() { }

	// RVA: 0x22677B0 Offset: 0x22669B0 VA: 0x1822677B0
	public string get_CloseStatusDescription() { }

	// RVA: 0x22677F0 Offset: 0x22669F0 VA: 0x1822677F0
	public WebSocketState get_State() { }

	// RVA: 0x2267820 Offset: 0x2266A20 VA: 0x182267820
	public string get_SubProtocol() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void CheckPlatformSupport() { }

	// RVA: 0x22671F0 Offset: 0x22663F0 VA: 0x1822671F0
	public void Dispose() { }

	// RVA: 0x2266470 Offset: 0x2265670 VA: 0x182266470
	public void Abort() { }

	// RVA: 0x2267550 Offset: 0x2266750 VA: 0x182267550
	public Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	// RVA: 0x22674E0 Offset: 0x22666E0 VA: 0x1822674E0
	public ValueTask SendAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	// RVA: 0x2267440 Offset: 0x2266640 VA: 0x182267440
	public Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2267480 Offset: 0x2266680 VA: 0x182267480
	public ValueTask<ValueWebSocketReceiveResult> ReceiveAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2266CE0 Offset: 0x2265EE0 VA: 0x182266CE0
	public Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	// RVA: 0x2266D10 Offset: 0x2265F10 VA: 0x182266D10
	public Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebSocketHandle.<ConnectAsyncCore>d__26))]
	// RVA: 0x2266D40 Offset: 0x2265F40 VA: 0x182266D40
	public Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken, ClientWebSocketOptions options) { }

	[AsyncStateMachine(typeof(WebSocketHandle.<ConnectSocketAsync>d__27))]
	// RVA: 0x2266E30 Offset: 0x2266030 VA: 0x182266E30
	private Task<Socket> ConnectSocketAsync(string host, int port, CancellationToken cancellationToken) { }

	// RVA: 0x22664C0 Offset: 0x22656C0 VA: 0x1822664C0
	private static byte[] BuildRequestHeader(Uri uri, ClientWebSocketOptions options, string secKey) { }

	// RVA: 0x2266F70 Offset: 0x2266170 VA: 0x182266F70
	private static KeyValuePair<string, string> CreateSecKeyAndSecWebSocketAccept() { }

	[AsyncStateMachine(typeof(WebSocketHandle.<ParseAndValidateConnectResponseAsync>d__30))]
	// RVA: 0x2267220 Offset: 0x2266420 VA: 0x182267220
	private Task<string> ParseAndValidateConnectResponseAsync(Stream stream, ClientWebSocketOptions options, string expectedSecWebSocketAccept, CancellationToken cancellationToken) { }

	// RVA: 0x22675A0 Offset: 0x22667A0 VA: 0x1822675A0
	private static void ValidateAndTrackHeader(string targetHeaderName, string targetHeaderValue, string foundHeaderName, string foundHeaderValue, ref bool foundHeader) { }

	[AsyncStateMachine(typeof(WebSocketHandle.<ReadResponseHeaderLineAsync>d__32))]
	// RVA: 0x2267330 Offset: 0x2266530 VA: 0x182267330
	private static Task<string> ReadResponseHeaderLineAsync(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x2267740 Offset: 0x2266940 VA: 0x182267740
	public void .ctor() { }

	// RVA: 0x22676F0 Offset: 0x22668F0 VA: 0x1822676F0
	private static void .cctor() { }
}

// Namespace: System.Net.WebSockets
[IsReadOnly]
public struct ValueWebSocketReceiveResult // TypeDefIndex: 6326
{
	// Fields
	private readonly uint _countAndEndOfMessage; // 0x0
	private readonly WebSocketMessageType _messageType; // 0x4

	// Properties
	public int Count { get; }
	public bool EndOfMessage { get; }
	public WebSocketMessageType MessageType { get; }

	// Methods

	// RVA: 0x2265DE0 Offset: 0x2264FE0 VA: 0x182265DE0
	public void .ctor(int count, WebSocketMessageType messageType, bool endOfMessage) { }

	// RVA: 0x2265E20 Offset: 0x2265020 VA: 0x182265E20
	public int get_Count() { }

	// RVA: 0x180F8F0 Offset: 0x180EAF0 VA: 0x18180F8F0
	public bool get_EndOfMessage() { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public WebSocketMessageType get_MessageType() { }

	// RVA: 0x2265D40 Offset: 0x2264F40 VA: 0x182265D40
	private static void ThrowCountOutOfRange() { }

	// RVA: 0x2265D90 Offset: 0x2264F90 VA: 0x182265D90
	private static void ThrowMessageTypeOutOfRange() { }
}

// Namespace: 
[CompilerGenerated]
private struct WebSocket.<ReceiveAsync>d__14 : IAsyncStateMachine // TypeDefIndex: 6327
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder<ValueWebSocketReceiveResult> <>t__builder; // 0x8
	public Memory<byte> buffer; // 0x30
	public WebSocket <>4__this; // 0x40
	public CancellationToken cancellationToken; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebSocketReceiveResult> <>u__1; // 0x50
	private byte[] <array>5__2; // 0x60

	// Methods

	// RVA: 0x2262C40 Offset: 0x2261E40 VA: 0x182262C40 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x22632D0 Offset: 0x22624D0 VA: 0x1822632D0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebSocket.<SendWithArrayPoolAsync>d__16 : IAsyncStateMachine // TypeDefIndex: 6328
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ReadOnlyMemory<byte> buffer; // 0x20
	public WebSocket <>4__this; // 0x30
	public WebSocketMessageType messageType; // 0x38
	public bool endOfMessage; // 0x3C
	public CancellationToken cancellationToken; // 0x40
	private byte[] <array>5__2; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0x2264550 Offset: 0x2263750 VA: 0x182264550 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2264980 Offset: 0x2263B80 VA: 0x182264980 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net.WebSockets
public abstract class WebSocket : IDisposable // TypeDefIndex: 6329
{
	// Properties
	public abstract Nullable<WebSocketCloseStatus> CloseStatus { get; }
	public abstract string CloseStatusDescription { get; }
	public abstract string SubProtocol { get; }
	public abstract WebSocketState State { get; }
	public static TimeSpan DefaultKeepAliveInterval { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Nullable<WebSocketCloseStatus> get_CloseStatus();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_CloseStatusDescription();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_SubProtocol();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract WebSocketState get_State();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Abort();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Dispose();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken);

	[AsyncStateMachine(typeof(WebSocket.<ReceiveAsync>d__14))]
	// RVA: 0x2268DA0 Offset: 0x2267FA0 VA: 0x182268DA0 Slot: 15
	public virtual ValueTask<ValueWebSocketReceiveResult> ReceiveAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2268F50 Offset: 0x2268150 VA: 0x182268F50 Slot: 16
	public virtual ValueTask SendAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebSocket.<SendWithArrayPoolAsync>d__16))]
	// RVA: 0x2269100 Offset: 0x2268300 VA: 0x182269100
	private Task SendWithArrayPoolAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	// RVA: 0x2269350 Offset: 0x2268550 VA: 0x182269350
	public static TimeSpan get_DefaultKeepAliveInterval() { }

	// RVA: 0x2269210 Offset: 0x2268410 VA: 0x182269210
	protected static void ThrowOnInvalidState(WebSocketState state, WebSocketState[] validStates) { }

	// RVA: 0x2268D90 Offset: 0x2267F90 VA: 0x182268D90
	protected static bool IsStateTerminal(WebSocketState state) { }

	// RVA: 0x2268360 Offset: 0x2267560 VA: 0x182268360
	public static ArraySegment<byte> CreateClientBuffer(int receiveBufferSize, int sendBufferSize) { }

	// RVA: 0x2268C60 Offset: 0x2267E60 VA: 0x182268C60
	public static ArraySegment<byte> CreateServerBuffer(int receiveBufferSize) { }

	// RVA: 0x2268960 Offset: 0x2267B60 VA: 0x182268960
	public static WebSocket CreateFromStream(Stream stream, bool isServer, string subProtocol, TimeSpan keepAliveInterval) { }

	[EditorBrowsable(1)]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.")]
	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public static bool IsApplicationTargeting45() { }

	[EditorBrowsable(1)]
	// RVA: 0x2268F10 Offset: 0x2268110 VA: 0x182268F10
	public static void RegisterPrefixes() { }

	[EditorBrowsable(1)]
	// RVA: 0x2268580 Offset: 0x2267780 VA: 0x182268580
	public static WebSocket CreateClientWebSocket(Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, TimeSpan keepAliveInterval, bool useZeroMaskingKey, ArraySegment<byte> internalBuffer) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.WebSockets
public enum WebSocketCloseStatus // TypeDefIndex: 6330
{
	// Fields
	public int value__; // 0x0
	public const WebSocketCloseStatus NormalClosure = 1000;
	public const WebSocketCloseStatus EndpointUnavailable = 1001;
	public const WebSocketCloseStatus ProtocolError = 1002;
	public const WebSocketCloseStatus InvalidMessageType = 1003;
	public const WebSocketCloseStatus Empty = 1005;
	public const WebSocketCloseStatus InvalidPayloadData = 1007;
	public const WebSocketCloseStatus PolicyViolation = 1008;
	public const WebSocketCloseStatus MessageTooBig = 1009;
	public const WebSocketCloseStatus MandatoryExtension = 1010;
	public const WebSocketCloseStatus InternalServerError = 1011;
}

// Namespace: System.Net.WebSockets
public abstract class WebSocketContext // TypeDefIndex: 6331
{
	// Properties
	public abstract Uri RequestUri { get; }
	public abstract NameValueCollection Headers { get; }
	public abstract string Origin { get; }
	public abstract IEnumerable<string> SecWebSocketProtocols { get; }
	public abstract string SecWebSocketVersion { get; }
	public abstract string SecWebSocketKey { get; }
	public abstract CookieCollection CookieCollection { get; }
	public abstract IPrincipal User { get; }
	public abstract bool IsAuthenticated { get; }
	public abstract bool IsLocal { get; }
	public abstract bool IsSecureConnection { get; }
	public abstract WebSocket WebSocket { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Uri get_RequestUri();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract NameValueCollection get_Headers();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Origin();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IEnumerable<string> get_SecWebSocketProtocols();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_SecWebSocketVersion();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_SecWebSocketKey();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract CookieCollection get_CookieCollection();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IPrincipal get_User();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_IsAuthenticated();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_IsLocal();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsSecureConnection();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract WebSocket get_WebSocket();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.WebSockets
public enum WebSocketError // TypeDefIndex: 6332
{
	// Fields
	public int value__; // 0x0
	public const WebSocketError Success = 0;
	public const WebSocketError InvalidMessageType = 1;
	public const WebSocketError Faulted = 2;
	public const WebSocketError NativeError = 3;
	public const WebSocketError NotAWebSocket = 4;
	public const WebSocketError UnsupportedVersion = 5;
	public const WebSocketError UnsupportedProtocol = 6;
	public const WebSocketError HeaderError = 7;
	public const WebSocketError ConnectionClosedPrematurely = 8;
	public const WebSocketError InvalidState = 9;
}

// Namespace: System.Net.WebSockets
[Serializable]
public sealed class WebSocketException : Win32Exception // TypeDefIndex: 6333
{
	// Fields
	private readonly WebSocketError _webSocketErrorCode; // 0x98

	// Properties
	public override int ErrorCode { get; }
	public WebSocketError WebSocketErrorCode { get; }

	// Methods

	// RVA: 0x2266270 Offset: 0x2265470 VA: 0x182266270
	public void .ctor() { }

	// RVA: 0x22660F0 Offset: 0x22652F0 VA: 0x1822660F0
	public void .ctor(WebSocketError error) { }

	// RVA: 0x22661F0 Offset: 0x22653F0 VA: 0x1822661F0
	public void .ctor(WebSocketError error, string message) { }

	// RVA: 0x2266420 Offset: 0x2265620 VA: 0x182266420
	public void .ctor(WebSocketError error, Exception innerException) { }

	// RVA: 0x2266070 Offset: 0x2265270 VA: 0x182266070
	public void .ctor(WebSocketError error, string message, Exception innerException) { }

	// RVA: 0x22662F0 Offset: 0x22654F0 VA: 0x1822662F0
	public void .ctor(int nativeError) { }

	// RVA: 0x2266220 Offset: 0x2265420 VA: 0x182266220
	public void .ctor(int nativeError, string message) { }

	// RVA: 0x22663A0 Offset: 0x22655A0 VA: 0x1822663A0
	public void .ctor(int nativeError, Exception innerException) { }

	// RVA: 0x2266190 Offset: 0x2265390 VA: 0x182266190
	public void .ctor(WebSocketError error, int nativeError) { }

	// RVA: 0x22660B0 Offset: 0x22652B0 VA: 0x1822660B0
	public void .ctor(WebSocketError error, int nativeError, string message) { }

	// RVA: 0x2266130 Offset: 0x2265330 VA: 0x182266130
	public void .ctor(WebSocketError error, int nativeError, Exception innerException) { }

	// RVA: 0x2266340 Offset: 0x2265540 VA: 0x182266340
	public void .ctor(WebSocketError error, int nativeError, string message, Exception innerException) { }

	// RVA: 0x2266390 Offset: 0x2265590 VA: 0x182266390
	public void .ctor(string message) { }

	// RVA: 0x22661E0 Offset: 0x22653E0 VA: 0x1822661E0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x215DAB0 Offset: 0x215CCB0 VA: 0x18215DAB0
	private void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2265FB0 Offset: 0x22651B0 VA: 0x182265FB0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210 Slot: 18
	public override int get_ErrorCode() { }

	// RVA: 0x838410 Offset: 0x837610 VA: 0x180838410
	public WebSocketError get_WebSocketErrorCode() { }

	// RVA: 0x2265E30 Offset: 0x2265030 VA: 0x182265E30
	private static string GetErrorMessage(WebSocketError error) { }

	// RVA: 0x2266060 Offset: 0x2265260 VA: 0x182266060
	private void SetErrorCodeOnError(int nativeError) { }

	// RVA: 0x7BA810 Offset: 0x7B9A10 VA: 0x1807BA810
	private static bool Succeeded(int hr) { }
}

// Namespace: System.Net.WebSockets
public enum WebSocketMessageType // TypeDefIndex: 6334
{
	// Fields
	public int value__; // 0x0
	public const WebSocketMessageType Text = 0;
	public const WebSocketMessageType Binary = 1;
	public const WebSocketMessageType Close = 2;
}

// Namespace: System.Net.WebSockets
public class WebSocketReceiveResult // TypeDefIndex: 6335
{
	// Fields
	[CompilerGenerated]
	private readonly int <Count>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <EndOfMessage>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly WebSocketMessageType <MessageType>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Nullable<WebSocketCloseStatus> <CloseStatus>k__BackingField; // 0x1C
	[CompilerGenerated]
	private readonly string <CloseStatusDescription>k__BackingField; // 0x28

	// Properties
	public int Count { get; }
	public bool EndOfMessage { get; }
	public WebSocketMessageType MessageType { get; }
	public Nullable<WebSocketCloseStatus> CloseStatus { get; }
	public string CloseStatusDescription { get; }

	// Methods

	// RVA: 0x2267980 Offset: 0x2266B80 VA: 0x182267980
	public void .ctor(int count, WebSocketMessageType messageType, bool endOfMessage) { }

	// RVA: 0x22678D0 Offset: 0x2266AD0 VA: 0x1822678D0
	public void .ctor(int count, WebSocketMessageType messageType, bool endOfMessage, Nullable<WebSocketCloseStatus> closeStatus, string closeStatusDescription) { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	public bool get_EndOfMessage() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public WebSocketMessageType get_MessageType() { }

	[CompilerGenerated]
	// RVA: 0x1CC1240 Offset: 0x1CC0440 VA: 0x181CC1240
	public Nullable<WebSocketCloseStatus> get_CloseStatus() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_CloseStatusDescription() { }
}

// Namespace: System.Net.WebSockets
public enum WebSocketState // TypeDefIndex: 6336
{
	// Fields
	public int value__; // 0x0
	public const WebSocketState None = 0;
	public const WebSocketState Connecting = 1;
	public const WebSocketState Open = 2;
	public const WebSocketState CloseSent = 3;
	public const WebSocketState CloseReceived = 4;
	public const WebSocketState Closed = 5;
	public const WebSocketState Aborted = 6;
}

// Namespace: System.Net.Security
internal static class CertificateHelper // TypeDefIndex: 6337
{
	// Fields
	private const string ClientAuthenticationOID = "1.3.6.1.5.5.7.3.2";

	// Methods

	// RVA: 0x2250E70 Offset: 0x2250070 VA: 0x182250E70
	internal static X509Certificate2 GetEligibleClientCertificate(X509CertificateCollection candidateCerts) { }

	// RVA: 0x2250DD0 Offset: 0x224FFD0 VA: 0x182250DD0
	internal static X509Certificate2 GetEligibleClientCertificate(X509Certificate2Collection candidateCerts) { }

	// RVA: 0x2251120 Offset: 0x2250320 VA: 0x182251120
	private static bool IsValidClientCertificate(X509Certificate2 cert) { }

	// RVA: 0x2251210 Offset: 0x2250410 VA: 0x182251210
	private static bool IsValidForClientAuthenticationEKU(X509EnhancedKeyUsageExtension eku) { }

	// RVA: 0x22512B0 Offset: 0x22504B0 VA: 0x1822512B0
	private static bool IsValidForDigitalSignatureUsage(X509KeyUsageExtension ku) { }

	// RVA: 0x2250F80 Offset: 0x2250180 VA: 0x182250F80
	internal static X509Certificate2 GetEligibleClientCertificate() { }
}

// Namespace: System.Net.Security
internal abstract class SafeDeleteContext : SafeHandle // TypeDefIndex: 6338
{
	// Fields
	internal Interop.SspiCli.CredHandle _handle; // 0x20
	private const string dummyStr = " ";
	private static readonly byte[] s_dummyBytes; // 0x0
	private static readonly IdnMapping s_idnMapping; // 0x8
	protected SafeFreeCredentials _EffectiveCredential; // 0x30

	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x225AD00 Offset: 0x2259F00 VA: 0x18225AD00
	protected void .ctor() { }

	// RVA: 0x225AD30 Offset: 0x2259F30 VA: 0x18225AD30 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x225AC60 Offset: 0x2259E60 VA: 0x18225AC60 Slot: 3
	public override string ToString() { }

	// RVA: 0x2259D10 Offset: 0x2258F10 VA: 0x182259D10
	internal static int InitializeSecurityContext(ref SafeFreeCredentials inCredentials, ref SafeDeleteContext refContext, string targetName, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer inSecBuffer, SecurityBuffer[] inSecBuffers, SecurityBuffer outSecBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x225A9A0 Offset: 0x2259BA0 VA: 0x18225A9A0
	private static int MustRunInitializeSecurityContext(ref SafeFreeCredentials inCredentials, void* inContextPtr, byte* targetName, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, Interop.SspiCli.SecBufferDesc* inputBuffer, SafeDeleteContext outContext, ref Interop.SspiCli.SecBufferDesc outputBuffer, ref Interop.SspiCli.ContextFlags attributes, SafeFreeContextBuffer handleTemplate) { }

	// RVA: 0x2258490 Offset: 0x2257690 VA: 0x182258490
	internal static int AcceptSecurityContext(ref SafeFreeCredentials inCredentials, ref SafeDeleteContext refContext, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SecurityBuffer inSecBuffer, SecurityBuffer[] inSecBuffers, SecurityBuffer outSecBuffer, ref Interop.SspiCli.ContextFlags outFlags) { }

	// RVA: 0x225A7A0 Offset: 0x22599A0 VA: 0x18225A7A0
	private static int MustRunAcceptSecurityContext_SECURITY(ref SafeFreeCredentials inCredentials, void* inContextPtr, Interop.SspiCli.SecBufferDesc* inputBuffer, Interop.SspiCli.ContextFlags inFlags, Interop.SspiCli.Endianness endianness, SafeDeleteContext outContext, ref Interop.SspiCli.SecBufferDesc outputBuffer, ref Interop.SspiCli.ContextFlags outFlags, SafeFreeContextBuffer handleTemplate) { }

	// RVA: 0x2259600 Offset: 0x2258800 VA: 0x182259600
	internal static int CompleteAuthToken(ref SafeDeleteContext refContext, SecurityBuffer[] inSecBuffers) { }

	// RVA: 0x2258ED0 Offset: 0x22580D0 VA: 0x182258ED0
	internal static int ApplyControlToken(ref SafeDeleteContext refContext, SecurityBuffer[] inSecBuffers) { }

	// RVA: 0x225AC70 Offset: 0x2259E70 VA: 0x18225AC70
	private static void .cctor() { }
}

// Namespace: System.Net.Security
internal sealed class SafeSspiAuthDataHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 6339
{
	// Methods

	// RVA: 0x225AD80 Offset: 0x2259F80 VA: 0x18225AD80
	public void .ctor() { }

	// RVA: 0x225BBC0 Offset: 0x225ADC0 VA: 0x18225BBC0 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: System.Net.Security
internal abstract class SafeFreeContextBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 6340
{
	// Methods

	// RVA: 0x225AD80 Offset: 0x2259F80 VA: 0x18225AD80
	protected void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void Set(IntPtr value) { }

	// RVA: 0x225B130 Offset: 0x225A330 VA: 0x18225B130
	internal static int EnumeratePackages(out int pkgnum, out SafeFreeContextBuffer pkgArray) { }

	// RVA: 0x225B0E0 Offset: 0x225A2E0 VA: 0x18225B0E0
	internal static SafeFreeContextBuffer CreateEmptyHandle() { }

	// RVA: 0x225B190 Offset: 0x225A390 VA: 0x18225B190
	public static int QueryContextAttributes(SafeDeleteContext phContext, Interop.SspiCli.ContextAttribute contextAttribute, byte* buffer, SafeHandle refHandle) { }

	// RVA: 0x225B400 Offset: 0x225A600 VA: 0x18225B400
	public static int SetContextAttributes(SafeDeleteContext phContext, Interop.SspiCli.ContextAttribute contextAttribute, byte[] buffer) { }
}

// Namespace: System.Net.Security
internal sealed class SafeFreeContextBuffer_SECURITY : SafeFreeContextBuffer // TypeDefIndex: 6341
{
	// Methods

	// RVA: 0x225AD80 Offset: 0x2259F80 VA: 0x18225AD80
	internal void .ctor() { }

	// RVA: 0x225AF40 Offset: 0x225A140 VA: 0x18225AF40 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: System.Net.Security
internal sealed class SafeFreeCertContext : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 6342
{
	// Fields
	private const uint CRYPT_ACQUIRE_SILENT_FLAG = 64;

	// Methods

	// RVA: 0x225AD80 Offset: 0x2259F80 VA: 0x18225AD80
	internal void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void Set(IntPtr value) { }

	// RVA: 0x225AD60 Offset: 0x2259F60 VA: 0x18225AD60 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: System.Net.Security
internal abstract class SafeFreeCredentials : SafeHandle // TypeDefIndex: 6343
{
	// Fields
	internal Interop.SspiCli.CredHandle _handle; // 0x20

	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x225AD00 Offset: 0x2259F00 VA: 0x18225AD00
	protected void .ctor() { }

	// RVA: 0x225AD30 Offset: 0x2259F30 VA: 0x18225AD30 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x225B890 Offset: 0x225AA90 VA: 0x18225B890
	public static int AcquireCredentialsHandle(string package, Interop.SspiCli.CredentialUse intent, ref Interop.SspiCli.SEC_WINNT_AUTH_IDENTITY_W authdata, out SafeFreeCredentials outCredential) { }

	// RVA: 0x225BA60 Offset: 0x225AC60 VA: 0x18225BA60
	public static int AcquireDefaultCredential(string package, Interop.SspiCli.CredentialUse intent, out SafeFreeCredentials outCredential) { }

	// RVA: 0x225B500 Offset: 0x225A700 VA: 0x18225B500
	public static int AcquireCredentialsHandle(string package, Interop.SspiCli.CredentialUse intent, ref SafeSspiAuthDataHandle authdata, out SafeFreeCredentials outCredential) { }

	// RVA: 0x225B5F0 Offset: 0x225A7F0 VA: 0x18225B5F0
	public static int AcquireCredentialsHandle(string package, Interop.SspiCli.CredentialUse intent, ref Interop.SspiCli.SCHANNEL_CRED authdata, out SafeFreeCredentials outCredential) { }
}

// Namespace: System.Net.Security
internal sealed class SafeCredentialReference : CriticalHandleMinusOneIsInvalid // TypeDefIndex: 6344
{
	// Fields
	internal SafeFreeCredentials Target; // 0x20

	// Methods

	// RVA: 0x2258330 Offset: 0x2257530 VA: 0x182258330
	internal static SafeCredentialReference CreateReference(SafeFreeCredentials target) { }

	// RVA: 0x2258420 Offset: 0x2257620 VA: 0x182258420
	private void .ctor(SafeFreeCredentials target) { }

	// RVA: 0x22583F0 Offset: 0x22575F0 VA: 0x1822583F0 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: System.Net.Security
internal sealed class SafeFreeCredential_SECURITY : SafeFreeCredentials // TypeDefIndex: 6345
{
	// Methods

	// RVA: 0x225AD00 Offset: 0x2259F00 VA: 0x18225AD00
	public void .ctor() { }

	// RVA: 0x225B4E0 Offset: 0x225A6E0 VA: 0x18225B4E0 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: System.Net.Security
internal sealed class SafeDeleteContext_SECURITY : SafeDeleteContext // TypeDefIndex: 6346
{
	// Methods

	// RVA: 0x225AC00 Offset: 0x2259E00 VA: 0x18225AC00
	internal void .ctor() { }

	// RVA: 0x225ABC0 Offset: 0x2259DC0 VA: 0x18225ABC0 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: System.Net.Security
internal abstract class SafeFreeContextBufferChannelBinding : ChannelBinding // TypeDefIndex: 6347
{
	// Fields
	private int _size; // 0x20

	// Properties
	public override int Size { get; }
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 8
	public override int get_Size() { }

	// RVA: 0x225B050 Offset: 0x225A250 VA: 0x18225B050 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void Set(IntPtr value) { }

	// RVA: 0x225AD90 Offset: 0x2259F90 VA: 0x18225AD90
	internal static SafeFreeContextBufferChannelBinding CreateEmptyHandle() { }

	// RVA: 0x225ADE0 Offset: 0x2259FE0 VA: 0x18225ADE0
	public static int QueryContextChannelBinding(SafeDeleteContext phContext, Interop.SspiCli.ContextAttribute contextAttribute, SecPkgContext_Bindings* buffer, SafeFreeContextBufferChannelBinding refHandle) { }

	// RVA: 0x225AF70 Offset: 0x225A170 VA: 0x18225AF70 Slot: 3
	public override string ToString() { }

	// RVA: 0x225AF60 Offset: 0x225A160 VA: 0x18225AF60
	protected void .ctor() { }
}

// Namespace: System.Net.Security
internal sealed class SafeFreeContextBufferChannelBinding_SECURITY : SafeFreeContextBufferChannelBinding // TypeDefIndex: 6348
{
	// Methods

	// RVA: 0x225AF40 Offset: 0x225A140 VA: 0x18225AF40 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x225AF60 Offset: 0x225A160 VA: 0x18225AF60
	public void .ctor() { }
}

// Namespace: System.Net.Security
internal static class NegotiateStreamPal // TypeDefIndex: 6349
{
	// Methods

	// RVA: 0x2257E50 Offset: 0x2257050 VA: 0x182257E50
	internal static int QueryMaxTokenSize(string package) { }

	// RVA: 0x2257620 Offset: 0x2256820 VA: 0x182257620
	internal static SafeFreeCredentials AcquireDefaultCredential(string package, bool isServer) { }

	// RVA: 0x22573C0 Offset: 0x22565C0 VA: 0x1822573C0
	internal static SafeFreeCredentials AcquireCredentialsHandle(string package, bool isServer, NetworkCredential credential) { }

	// RVA: 0x2257DC0 Offset: 0x2256FC0 VA: 0x182257DC0
	internal static string QueryContextClientSpecifiedSpn(SafeDeleteContext securityContext) { }

	// RVA: 0x2257CF0 Offset: 0x2256EF0 VA: 0x182257CF0
	internal static string QueryContextAuthenticationPackage(SafeDeleteContext securityContext) { }

	// RVA: 0x22577F0 Offset: 0x22569F0 VA: 0x1822577F0
	internal static SecurityStatusPal InitializeSecurityContext(SafeFreeCredentials credentialsHandle, ref SafeDeleteContext securityContext, string spn, ContextFlagsPal requestedContextFlags, SecurityBuffer[] inSecurityBufferArray, SecurityBuffer outSecurityBuffer, ref ContextFlagsPal contextFlags) { }

	// RVA: 0x22576A0 Offset: 0x22568A0 VA: 0x1822576A0
	internal static SecurityStatusPal CompleteAuthToken(ref SafeDeleteContext securityContext, SecurityBuffer[] inSecurityBufferArray) { }

	// RVA: 0x2257270 Offset: 0x2256470 VA: 0x182257270
	internal static SecurityStatusPal AcceptSecurityContext(SafeFreeCredentials credentialsHandle, ref SafeDeleteContext securityContext, ContextFlagsPal requestedContextFlags, SecurityBuffer[] inSecurityBufferArray, SecurityBuffer outSecurityBuffer, ref ContextFlagsPal contextFlags) { }

	// RVA: 0x2257760 Offset: 0x2256960 VA: 0x182257760
	internal static Win32Exception CreateExceptionFromError(SecurityStatusPal statusCode) { }

	// RVA: 0x2257EC0 Offset: 0x22570C0 VA: 0x182257EC0
	internal static int VerifySignature(SafeDeleteContext securityContext, byte[] buffer, int offset, int count) { }

	// RVA: 0x2257950 Offset: 0x2256B50 VA: 0x182257950
	internal static int MakeSignature(SafeDeleteContext securityContext, byte[] buffer, int offset, int count, ref byte[] output) { }
}

// Namespace: System.Net.Security
internal class SecurityBuffer // TypeDefIndex: 6350
{
	// Fields
	public int size; // 0x10
	public SecurityBufferType type; // 0x14
	public byte[] token; // 0x18
	public SafeHandle unmanagedToken; // 0x20
	public int offset; // 0x28

	// Methods

	// RVA: 0x225BBE0 Offset: 0x225ADE0 VA: 0x18225BBE0
	public void .ctor(byte[] data, int offset, int size, SecurityBufferType tokentype) { }

	// RVA: 0x225BEC0 Offset: 0x225B0C0 VA: 0x18225BEC0
	public void .ctor(byte[] data, SecurityBufferType tokentype) { }

	// RVA: 0x225BF80 Offset: 0x225B180 VA: 0x18225BF80
	public void .ctor(int size, SecurityBufferType tokentype) { }

	// RVA: 0x225BF20 Offset: 0x225B120 VA: 0x18225BF20
	public void .ctor(ChannelBinding binding) { }
}

// Namespace: System.Net.Security
internal enum SecurityBufferType // TypeDefIndex: 6351
{
	// Fields
	public int value__; // 0x0
	public const SecurityBufferType SECBUFFER_EMPTY = 0;
	public const SecurityBufferType SECBUFFER_DATA = 1;
	public const SecurityBufferType SECBUFFER_TOKEN = 2;
	public const SecurityBufferType SECBUFFER_PKG_PARAMS = 3;
	public const SecurityBufferType SECBUFFER_MISSING = 4;
	public const SecurityBufferType SECBUFFER_EXTRA = 5;
	public const SecurityBufferType SECBUFFER_STREAM_TRAILER = 6;
	public const SecurityBufferType SECBUFFER_STREAM_HEADER = 7;
	public const SecurityBufferType SECBUFFER_PADDING = 9;
	public const SecurityBufferType SECBUFFER_STREAM = 10;
	public const SecurityBufferType SECBUFFER_CHANNEL_BINDINGS = 14;
	public const SecurityBufferType SECBUFFER_TARGET_HOST = 16;
	public const SecurityBufferType SECBUFFER_ALERT = 17;
	public const SecurityBufferType SECBUFFER_APPLICATION_PROTOCOLS = 18;
	public const SecurityBufferType SECBUFFER_READONLY = -2147483648;
	public const SecurityBufferType SECBUFFER_READONLY_WITH_CHECKSUM = 268435456;
}

// Namespace: System.Net.Security
internal sealed class SecurityContextTokenHandle : CriticalHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 6352
{
	// Fields
	private int _disposed; // 0x20

	// Methods

	// RVA: 0x225C150 Offset: 0x225B350 VA: 0x18225C150
	private void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal IntPtr DangerousGetHandle() { }

	// RVA: 0x225C100 Offset: 0x225B300 VA: 0x18225C100 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: System.Net.Security
[Extension]
internal static class SslClientAuthenticationOptionsExtensions // TypeDefIndex: 6353
{
	// Methods

	[Extension]
	// RVA: 0x225DEF0 Offset: 0x225D0F0 VA: 0x18225DEF0
	public static SslClientAuthenticationOptions ShallowClone(SslClientAuthenticationOptions options) { }
}

// Namespace: System.Net.Security
[IsReadOnly]
public struct SslApplicationProtocol : IEquatable<SslApplicationProtocol> // TypeDefIndex: 6354
{
	// Fields
	private readonly ReadOnlyMemory<byte> _readOnlyProtocol; // 0x0
	private static readonly Encoding s_utf8; // 0x0
	public static readonly SslApplicationProtocol Http2; // 0x8
	public static readonly SslApplicationProtocol Http11; // 0x18

	// Properties
	public ReadOnlyMemory<byte> Protocol { get; }

	// Methods

	// RVA: 0x225DAF0 Offset: 0x225CCF0 VA: 0x18225DAF0
	internal void .ctor(byte[] protocol, bool copy) { }

	// RVA: 0x225DA90 Offset: 0x225CC90 VA: 0x18225DA90
	public void .ctor(byte[] protocol) { }

	// RVA: 0x225D900 Offset: 0x225CB00 VA: 0x18225D900
	public void .ctor(string protocol) { }

	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public ReadOnlyMemory<byte> get_Protocol() { }

	// RVA: 0x225D040 Offset: 0x225C240 VA: 0x18225D040 Slot: 4
	public bool Equals(SslApplicationProtocol other) { }

	// RVA: 0x225CF80 Offset: 0x225C180 VA: 0x18225CF80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x225D250 Offset: 0x225C450 VA: 0x18225D250 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x225D340 Offset: 0x225C540 VA: 0x18225D340 Slot: 3
	public override string ToString() { }

	// RVA: 0x225D330 Offset: 0x225C530 VA: 0x18225D330
	private static char GetHexValue(int i) { }

	// RVA: 0x225DC80 Offset: 0x225CE80 VA: 0x18225DC80
	public static bool op_Equality(SslApplicationProtocol left, SslApplicationProtocol right) { }

	// RVA: 0x225DCF0 Offset: 0x225CEF0 VA: 0x18225DCF0
	public static bool op_Inequality(SslApplicationProtocol left, SslApplicationProtocol right) { }

	// RVA: 0x225D610 Offset: 0x225C810 VA: 0x18225D610
	private static void .cctor() { }
}

// Namespace: System.Net.Security
internal class SslAuthenticationOptions // TypeDefIndex: 6355
{
	// Fields
	[CompilerGenerated]
	private bool <AllowRenegotiation>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; // 0x18
	[CompilerGenerated]
	private X509CertificateCollection <ClientCertificates>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly List<SslApplicationProtocol> <ApplicationProtocols>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsServer>k__BackingField; // 0x30
	[CompilerGenerated]
	private RemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x38
	[CompilerGenerated]
	private LocalCertificateSelectionCallback <LocalCertificateSelectionCallback>k__BackingField; // 0x40
	[CompilerGenerated]
	private X509Certificate <ServerCertificate>k__BackingField; // 0x48
	[CompilerGenerated]
	private SslProtocols <EnabledSslProtocols>k__BackingField; // 0x50
	[CompilerGenerated]
	private X509RevocationMode <CertificateRevocationCheckMode>k__BackingField; // 0x54
	[CompilerGenerated]
	private EncryptionPolicy <EncryptionPolicy>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <RemoteCertRequired>k__BackingField; // 0x5C
	[CompilerGenerated]
	private bool <CheckCertName>k__BackingField; // 0x5D
	[CompilerGenerated]
	private RemoteCertValidationCallback <CertValidationDelegate>k__BackingField; // 0x60
	[CompilerGenerated]
	private LocalCertSelectionCallback <CertSelectionDelegate>k__BackingField; // 0x68
	[CompilerGenerated]
	private ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField; // 0x70

	// Properties
	internal bool AllowRenegotiation { get; set; }
	internal string TargetHost { get; set; }
	internal X509CertificateCollection ClientCertificates { get; set; }
	internal List<SslApplicationProtocol> ApplicationProtocols { get; }
	internal bool IsServer { get; set; }
	internal RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	internal LocalCertificateSelectionCallback LocalCertificateSelectionCallback { get; set; }
	internal X509Certificate ServerCertificate { get; set; }
	internal SslProtocols EnabledSslProtocols { get; set; }
	internal X509RevocationMode CertificateRevocationCheckMode { get; set; }
	internal EncryptionPolicy EncryptionPolicy { get; set; }
	internal bool RemoteCertRequired { get; set; }
	internal bool CheckCertName { get; set; }
	internal RemoteCertValidationCallback CertValidationDelegate { get; set; }
	internal LocalCertSelectionCallback CertSelectionDelegate { get; set; }
	internal ServerCertSelectionCallback ServerCertSelectionDelegate { get; set; }

	// Methods

	// RVA: 0x225DDA0 Offset: 0x225CFA0 VA: 0x18225DDA0
	internal void .ctor(SslClientAuthenticationOptions sslClientAuthenticationOptions, RemoteCertValidationCallback remoteCallback, LocalCertSelectionCallback localCallback) { }

	// RVA: 0x225DE40 Offset: 0x225D040 VA: 0x18225DE40
	internal void .ctor(SslServerAuthenticationOptions sslServerAuthenticationOptions) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	internal bool get_AllowRenegotiation() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void set_AllowRenegotiation(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_TargetHost(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal X509CertificateCollection get_ClientCertificates() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_ClientCertificates(X509CertificateCollection value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal List<SslApplicationProtocol> get_ApplicationProtocols() { }

	[CompilerGenerated]
	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	internal bool get_IsServer() { }

	[CompilerGenerated]
	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	internal void set_IsServer(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal RemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void set_RemoteCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal LocalCertificateSelectionCallback get_LocalCertificateSelectionCallback() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_LocalCertificateSelectionCallback(LocalCertificateSelectionCallback value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal X509Certificate get_ServerCertificate() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	internal void set_ServerCertificate(X509Certificate value) { }

	[CompilerGenerated]
	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	internal SslProtocols get_EnabledSslProtocols() { }

	[CompilerGenerated]
	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630
	internal void set_EnabledSslProtocols(SslProtocols value) { }

	[CompilerGenerated]
	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	internal X509RevocationMode get_CertificateRevocationCheckMode() { }

	[CompilerGenerated]
	// RVA: 0x4D1A80 Offset: 0x4D0C80 VA: 0x1804D1A80
	internal void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[CompilerGenerated]
	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	internal EncryptionPolicy get_EncryptionPolicy() { }

	[CompilerGenerated]
	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	internal void set_EncryptionPolicy(EncryptionPolicy value) { }

	[CompilerGenerated]
	// RVA: 0x526D00 Offset: 0x525F00 VA: 0x180526D00
	internal bool get_RemoteCertRequired() { }

	[CompilerGenerated]
	// RVA: 0x526E00 Offset: 0x526000 VA: 0x180526E00
	internal void set_RemoteCertRequired(bool value) { }

	[CompilerGenerated]
	// RVA: 0x526CD0 Offset: 0x525ED0 VA: 0x180526CD0
	internal bool get_CheckCertName() { }

	[CompilerGenerated]
	// RVA: 0x526DD0 Offset: 0x525FD0 VA: 0x180526DD0
	internal void set_CheckCertName(bool value) { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal RemoteCertValidationCallback get_CertValidationDelegate() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	internal void set_CertValidationDelegate(RemoteCertValidationCallback value) { }

	[CompilerGenerated]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	internal LocalCertSelectionCallback get_CertSelectionDelegate() { }

	[CompilerGenerated]
	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	internal void set_CertSelectionDelegate(LocalCertSelectionCallback value) { }

	[CompilerGenerated]
	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	internal ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	[CompilerGenerated]
	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	internal void set_ServerCertSelectionDelegate(ServerCertSelectionCallback value) { }
}

// Namespace: System.Net.Security
public class SslClientAuthenticationOptions // TypeDefIndex: 6356
{
	// Fields
	private EncryptionPolicy _encryptionPolicy; // 0x10
	private X509RevocationMode _checkCertificateRevocation; // 0x14
	private SslProtocols _enabledSslProtocols; // 0x18
	private bool _allowRenegotiation; // 0x1C
	[CompilerGenerated]
	private LocalCertificateSelectionCallback <LocalCertificateSelectionCallback>k__BackingField; // 0x20
	[CompilerGenerated]
	private RemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x28
	[CompilerGenerated]
	private List<SslApplicationProtocol> <ApplicationProtocols>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; // 0x38
	[CompilerGenerated]
	private X509CertificateCollection <ClientCertificates>k__BackingField; // 0x40

	// Properties
	public bool AllowRenegotiation { get; set; }
	public LocalCertificateSelectionCallback LocalCertificateSelectionCallback { get; set; }
	public RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public List<SslApplicationProtocol> ApplicationProtocols { get; set; }
	public string TargetHost { get; set; }
	public X509CertificateCollection ClientCertificates { get; set; }
	public X509RevocationMode CertificateRevocationCheckMode { get; set; }
	public EncryptionPolicy EncryptionPolicy { get; set; }
	public SslProtocols EnabledSslProtocols { get; set; }

	// Methods

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_AllowRenegotiation() { }

	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_AllowRenegotiation(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public LocalCertificateSelectionCallback get_LocalCertificateSelectionCallback() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_LocalCertificateSelectionCallback(LocalCertificateSelectionCallback value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public RemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_RemoteCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public List<SslApplicationProtocol> get_ApplicationProtocols() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_ApplicationProtocols(List<SslApplicationProtocol> value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_TargetHost(string value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public X509CertificateCollection get_ClientCertificates() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public X509RevocationMode get_CertificateRevocationCheckMode() { }

	// RVA: 0x227FF80 Offset: 0x227F180 VA: 0x18227FF80
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public EncryptionPolicy get_EncryptionPolicy() { }

	// RVA: 0x2280020 Offset: 0x227F220 VA: 0x182280020
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x227FF70 Offset: 0x227F170 VA: 0x18227FF70
	public void .ctor() { }
}

// Namespace: System.Net.Security
public class SslServerAuthenticationOptions // TypeDefIndex: 6357
{
	// Fields
	private X509RevocationMode _checkCertificateRevocation; // 0x10
	private SslProtocols _enabledSslProtocols; // 0x14
	private EncryptionPolicy _encryptionPolicy; // 0x18
	private bool _allowRenegotiation; // 0x1C
	[CompilerGenerated]
	private bool <ClientCertificateRequired>k__BackingField; // 0x1D
	[CompilerGenerated]
	private List<SslApplicationProtocol> <ApplicationProtocols>k__BackingField; // 0x20
	[CompilerGenerated]
	private RemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x28
	[CompilerGenerated]
	private ServerCertificateSelectionCallback <ServerCertificateSelectionCallback>k__BackingField; // 0x30
	[CompilerGenerated]
	private X509Certificate <ServerCertificate>k__BackingField; // 0x38

	// Properties
	public bool AllowRenegotiation { get; set; }
	public bool ClientCertificateRequired { get; set; }
	public List<SslApplicationProtocol> ApplicationProtocols { get; set; }
	public RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public ServerCertificateSelectionCallback ServerCertificateSelectionCallback { get; set; }
	public X509Certificate ServerCertificate { get; set; }
	public SslProtocols EnabledSslProtocols { get; set; }
	public X509RevocationMode CertificateRevocationCheckMode { get; set; }
	public EncryptionPolicy EncryptionPolicy { get; set; }

	// Methods

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_AllowRenegotiation() { }

	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_AllowRenegotiation(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0
	public bool get_ClientCertificateRequired() { }

	[CompilerGenerated]
	// RVA: 0x7D66A0 Offset: 0x7D58A0 VA: 0x1807D66A0
	public void set_ClientCertificateRequired(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public List<SslApplicationProtocol> get_ApplicationProtocols() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ApplicationProtocols(List<SslApplicationProtocol> value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public RemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_RemoteCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ServerCertificateSelectionCallback get_ServerCertificateSelectionCallback() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_ServerCertificateSelectionCallback(ServerCertificateSelectionCallback value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public X509Certificate get_ServerCertificate() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_ServerCertificate(X509Certificate value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public X509RevocationMode get_CertificateRevocationCheckMode() { }

	// RVA: 0x22800C0 Offset: 0x227F2C0 VA: 0x1822800C0
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public EncryptionPolicy get_EncryptionPolicy() { }

	// RVA: 0x2280160 Offset: 0x227F360 VA: 0x182280160
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x227FF70 Offset: 0x227F170 VA: 0x18227FF70
	public void .ctor() { }
}

// Namespace: System.Net.Security
public abstract class AuthenticatedStream : Stream // TypeDefIndex: 6358
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties
	public bool LeaveInnerStreamOpen { get; }
	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }
	public abstract bool IsMutuallyAuthenticated { get; }
	public abstract bool IsEncrypted { get; }
	public abstract bool IsSigned { get; }
	public abstract bool IsServer { get; }

	// Methods

	// RVA: 0x2269CB0 Offset: 0x2268EB0 VA: 0x182269CB0
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_LeaveInnerStreamOpen() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	protected Stream get_InnerStream() { }

	// RVA: 0x2269BE0 Offset: 0x2268DE0 VA: 0x182269BE0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract bool get_IsAuthenticated();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract bool get_IsMutuallyAuthenticated();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract bool get_IsEncrypted();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract bool get_IsSigned();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract bool get_IsServer();
}

// Namespace: System.Net.Security
public enum AuthenticationLevel // TypeDefIndex: 6359
{
	// Fields
	public int value__; // 0x0
	public const AuthenticationLevel None = 0;
	public const AuthenticationLevel MutualAuthRequested = 1;
	public const AuthenticationLevel MutualAuthRequired = 2;
}

// Namespace: System.Net.Security
public enum ProtectionLevel // TypeDefIndex: 6360
{
	// Fields
	public int value__; // 0x0
	public const ProtectionLevel None = 0;
	public const ProtectionLevel Sign = 1;
	public const ProtectionLevel EncryptAndSign = 2;
}

// Namespace: System.Net.Security
public enum EncryptionPolicy // TypeDefIndex: 6361
{
	// Fields
	public int value__; // 0x0
	public const EncryptionPolicy RequireEncryption = 0;
	public const EncryptionPolicy AllowNoEncryption = 1;
	public const EncryptionPolicy NoEncryption = 2;
}

// Namespace: System.Net.Security
public sealed class LocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 6362
{
	// Methods

	// RVA: 0x2278240 Offset: 0x2277440 VA: 0x182278240
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x7B9D30 Offset: 0x7B8F30 VA: 0x1807B9D30 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NegotiateStream.<>c__DisplayClass69_0 // TypeDefIndex: 6363
{
	// Fields
	public NegotiateStream <>4__this; // 0x10
	public NetworkCredential credential; // 0x18
	public string targetName; // 0x20
	public ProtectionLevel requiredProtectionLevel; // 0x28
	public TokenImpersonationLevel allowedImpersonationLevel; // 0x2C

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2283C20 Offset: 0x2282E20 VA: 0x182283C20
	internal IAsyncResult <AuthenticateAsClientAsync>b__0(AsyncCallback callback, object state) { }
}

// Namespace: System.Net.Security
public class NegotiateStream : AuthenticatedStream // TypeDefIndex: 6364
{
	// Fields
	private int readTimeout; // 0x38
	private int writeTimeout; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	[MonoTODO]
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	[MonoTODO]
	public virtual TokenImpersonationLevel ImpersonationLevel { get; }
	[MonoTODO]
	public override bool IsAuthenticated { get; }
	[MonoTODO]
	public override bool IsEncrypted { get; }
	[MonoTODO]
	public override bool IsMutuallyAuthenticated { get; }
	[MonoTODO]
	public override bool IsServer { get; }
	[MonoTODO]
	public override bool IsSigned { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override int ReadTimeout { get; set; }
	[MonoTODO]
	public virtual IIdentity RemoteIdentity { get; }
	public override int WriteTimeout { get; set; }

	// Methods

	[MonoTODO]
	// RVA: 0x22794F0 Offset: 0x22786F0 VA: 0x1822794F0
	public void .ctor(Stream innerStream) { }

	[MonoTODO]
	// RVA: 0x2279500 Offset: 0x2278700 VA: 0x182279500
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x1C954E0 Offset: 0x1C946E0 VA: 0x181C954E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x557000 Offset: 0x556200 VA: 0x180557000 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2279510 Offset: 0x2278710 VA: 0x182279510 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x205C340 Offset: 0x205B540 VA: 0x18205C340 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2279550 Offset: 0x2278750 VA: 0x182279550 Slot: 45
	public virtual TokenImpersonationLevel get_ImpersonationLevel() { }

	// RVA: 0x2279590 Offset: 0x2278790 VA: 0x182279590 Slot: 40
	public override bool get_IsAuthenticated() { }

	// RVA: 0x22795D0 Offset: 0x22787D0 VA: 0x1822795D0 Slot: 42
	public override bool get_IsEncrypted() { }

	// RVA: 0x2279610 Offset: 0x2278810 VA: 0x182279610 Slot: 41
	public override bool get_IsMutuallyAuthenticated() { }

	// RVA: 0x2279650 Offset: 0x2278850 VA: 0x182279650 Slot: 44
	public override bool get_IsServer() { }

	// RVA: 0x2279690 Offset: 0x2278890 VA: 0x182279690 Slot: 43
	public override bool get_IsSigned() { }

	// RVA: 0x8008F0 Offset: 0x7FFAF0 VA: 0x1808008F0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1D8AE70 Offset: 0x1D8A070 VA: 0x181D8AE70 Slot: 12
	public override long get_Position() { }

	// RVA: 0x205C370 Offset: 0x205B570 VA: 0x18205C370 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x22796D0 Offset: 0x22788D0 VA: 0x1822796D0 Slot: 46
	public virtual IIdentity get_RemoteIdentity() { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70 Slot: 17
	public override void set_WriteTimeout(int value) { }

	[MonoTODO]
	// RVA: 0x22790B0 Offset: 0x22782B0 VA: 0x1822790B0 Slot: 47
	public virtual IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object asyncState) { }

	[MonoTODO]
	// RVA: 0x2279130 Offset: 0x2278330 VA: 0x182279130 Slot: 48
	public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, AsyncCallback asyncCallback, object asyncState) { }

	[MonoTODO]
	// RVA: 0x22790F0 Offset: 0x22782F0 VA: 0x1822790F0 Slot: 49
	public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, string targetName, AsyncCallback asyncCallback, object asyncState) { }

	[MonoTODO]
	// RVA: 0x2279030 Offset: 0x2278230 VA: 0x182279030 Slot: 50
	public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel, AsyncCallback asyncCallback, object asyncState) { }

	[MonoTODO]
	// RVA: 0x2279070 Offset: 0x2278270 VA: 0x182279070 Slot: 51
	public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel, AsyncCallback asyncCallback, object asyncState) { }

	[MonoTODO]
	// RVA: 0x2279270 Offset: 0x2278470 VA: 0x182279270 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	[MonoTODO]
	// RVA: 0x2279230 Offset: 0x2278430 VA: 0x182279230 Slot: 52
	public virtual IAsyncResult BeginAuthenticateAsServer(AsyncCallback asyncCallback, object asyncState) { }

	[MonoTODO]
	// RVA: 0x22791B0 Offset: 0x22783B0 VA: 0x1822791B0 Slot: 53
	public virtual IAsyncResult BeginAuthenticateAsServer(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel, AsyncCallback asyncCallback, object asyncState) { }

	[MonoTODO]
	// RVA: 0x22791F0 Offset: 0x22783F0 VA: 0x1822791F0 Slot: 54
	public virtual IAsyncResult BeginAuthenticateAsServer(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel, AsyncCallback asyncCallback, object asyncState) { }

	[MonoTODO]
	// RVA: 0x2279170 Offset: 0x2278370 VA: 0x182279170 Slot: 55
	public virtual IAsyncResult BeginAuthenticateAsServer(ExtendedProtectionPolicy policy, AsyncCallback asyncCallback, object asyncState) { }

	[MonoTODO]
	// RVA: 0x22792B0 Offset: 0x22784B0 VA: 0x1822792B0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	[MonoTODO]
	// RVA: 0x2278C40 Offset: 0x2277E40 VA: 0x182278C40 Slot: 56
	public virtual void AuthenticateAsClient() { }

	[MonoTODO]
	// RVA: 0x2278CC0 Offset: 0x2277EC0 VA: 0x182278CC0 Slot: 57
	public virtual void AuthenticateAsClient(NetworkCredential credential, string targetName) { }

	[MonoTODO]
	// RVA: 0x2278C80 Offset: 0x2277E80 VA: 0x182278C80 Slot: 58
	public virtual void AuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName) { }

	[MonoTODO]
	// RVA: 0x2278C00 Offset: 0x2277E00 VA: 0x182278C00 Slot: 59
	public virtual void AuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel) { }

	[MonoTODO]
	// RVA: 0x2278D00 Offset: 0x2277F00 VA: 0x182278D00 Slot: 60
	public virtual void AuthenticateAsClient(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel) { }

	[MonoTODO]
	// RVA: 0x2278F70 Offset: 0x2278170 VA: 0x182278F70 Slot: 61
	public virtual void AuthenticateAsServer() { }

	[MonoTODO]
	// RVA: 0x2278FB0 Offset: 0x22781B0 VA: 0x182278FB0 Slot: 62
	public virtual void AuthenticateAsServer(ExtendedProtectionPolicy policy) { }

	[MonoTODO]
	// RVA: 0x2278FF0 Offset: 0x22781F0 VA: 0x182278FF0 Slot: 63
	public virtual void AuthenticateAsServer(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel) { }

	[MonoTODO]
	// RVA: 0x2278F30 Offset: 0x2278130 VA: 0x182278F30 Slot: 64
	public virtual void AuthenticateAsServer(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel) { }

	[MonoTODO]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 21
	protected override void Dispose(bool disposing) { }

	[MonoTODO]
	// RVA: 0x22792F0 Offset: 0x22784F0 VA: 0x1822792F0 Slot: 65
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	[MonoTODO]
	// RVA: 0x2279370 Offset: 0x2278570 VA: 0x182279370 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	[MonoTODO]
	// RVA: 0x2279330 Offset: 0x2278530 VA: 0x182279330 Slot: 66
	public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

	[MonoTODO]
	// RVA: 0x22793B0 Offset: 0x22785B0 VA: 0x1822793B0 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	[MonoTODO]
	// RVA: 0x173D3E0 Offset: 0x173C5E0 VA: 0x18173D3E0 Slot: 22
	public override void Flush() { }

	[MonoTODO]
	// RVA: 0x22793F0 Offset: 0x22785F0 VA: 0x1822793F0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	[MonoTODO]
	// RVA: 0x2279430 Offset: 0x2278630 VA: 0x182279430 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	[MonoTODO]
	// RVA: 0x2279470 Offset: 0x2278670 VA: 0x182279470 Slot: 33
	public override void SetLength(long value) { }

	[MonoTODO]
	// RVA: 0x22794B0 Offset: 0x22786B0 VA: 0x1822794B0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x22788B0 Offset: 0x2277AB0 VA: 0x1822788B0 Slot: 67
	public virtual Task AuthenticateAsClientAsync() { }

	// RVA: 0x2278750 Offset: 0x2277950 VA: 0x182278750 Slot: 68
	public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, string targetName) { }

	// RVA: 0x2278A60 Offset: 0x2277C60 VA: 0x182278A60 Slot: 69
	public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel) { }

	// RVA: 0x22789E0 Offset: 0x2277BE0 VA: 0x1822789E0 Slot: 70
	public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, ChannelBinding binding, string targetName) { }

	// RVA: 0x2278A20 Offset: 0x2277C20 VA: 0x182278A20 Slot: 71
	public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel) { }

	// RVA: 0x2278DC0 Offset: 0x2277FC0 VA: 0x182278DC0 Slot: 72
	public virtual Task AuthenticateAsServerAsync() { }

	// RVA: 0x2278D40 Offset: 0x2277F40 VA: 0x182278D40 Slot: 73
	public virtual Task AuthenticateAsServerAsync(ExtendedProtectionPolicy policy) { }

	// RVA: 0x2278EF0 Offset: 0x22780F0 VA: 0x182278EF0 Slot: 74
	public virtual Task AuthenticateAsServerAsync(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel) { }

	// RVA: 0x2278D80 Offset: 0x2277F80 VA: 0x182278D80 Slot: 75
	public virtual Task AuthenticateAsServerAsync(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel) { }
}

// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 6365
{
	// Methods

	// RVA: 0x1D8C3C0 Offset: 0x1D8B5C0 VA: 0x181D8C3C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x227ADD0 Offset: 0x2279FD0 VA: 0x18227ADD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0x409E60 Offset: 0x409060 VA: 0x180409E60 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net.Security
[Flags]
public enum SslPolicyErrors // TypeDefIndex: 6366
{
	// Fields
	public int value__; // 0x0
	public const SslPolicyErrors None = 0;
	public const SslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const SslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const SslPolicyErrors RemoteCertificateChainErrors = 4;
}

// Namespace: System.Net.Security
public sealed class ServerCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 6367
{
	// Methods

	// RVA: 0x1206180 Offset: 0x1205380 VA: 0x181206180
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual X509Certificate Invoke(object sender, string hostName) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net.Security
internal sealed class RemoteCertValidationCallback : MulticastDelegate // TypeDefIndex: 6368
{
	// Methods

	// RVA: 0x15623F0 Offset: 0x15615F0 VA: 0x1815623F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual bool Invoke(string host, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x227AD30 Offset: 0x2279F30 VA: 0x18227AD30 Slot: 14
	public virtual IAsyncResult BeginInvoke(string host, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0x409E60 Offset: 0x409060 VA: 0x180409E60 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net.Security
internal sealed class LocalCertSelectionCallback : MulticastDelegate // TypeDefIndex: 6369
{
	// Methods

	// RVA: 0x1562340 Offset: 0x1561540 VA: 0x181562340
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x1D96670 Offset: 0x1D95870 VA: 0x181D96670 Slot: 14
	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net.Security
internal sealed class ServerCertSelectionCallback : MulticastDelegate // TypeDefIndex: 6370
{
	// Methods

	// RVA: 0x585960 Offset: 0x584B60 VA: 0x180585960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual X509Certificate Invoke(string hostName) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SslStream.<>c__DisplayClass21_0 // TypeDefIndex: 6371
{
	// Fields
	public LocalCertificateSelectionCallback callback; // 0x10
	public SslStream <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2283BA0 Offset: 0x2282DA0 VA: 0x182283BA0
	internal X509Certificate <SetAndVerifySelectionCallback>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SslStream.<>c__DisplayClass22_0 // TypeDefIndex: 6372
{
	// Fields
	public ServerCertificateSelectionCallback serverSelectionCallback; // 0x10
	public SslStream <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2283BF0 Offset: 0x2282DF0 VA: 0x182283BF0
	internal X509Certificate <CreateAuthenticationOptions>b__0(string x) { }
}

// Namespace: System.Net.Security
public class SslStream : AuthenticatedStream // TypeDefIndex: 6373
{
	// Fields
	private MobileTlsProvider provider; // 0x38
	private MonoTlsSettings settings; // 0x40
	private RemoteCertificateValidationCallback validationCallback; // 0x48
	private LocalCertificateSelectionCallback selectionCallback; // 0x50
	private MobileAuthenticatedStream impl; // 0x58
	private bool explicitSettings; // 0x60

	// Properties
	internal MobileAuthenticatedStream Impl { get; }
	internal MonoTlsProvider Provider { get; }
	internal string InternalTargetHost { get; }
	public TransportContext TransportContext { get; }
	public override bool IsAuthenticated { get; }
	public override bool IsMutuallyAuthenticated { get; }
	public override bool IsEncrypted { get; }
	public override bool IsSigned { get; }
	public override bool IsServer { get; }
	public virtual SslProtocols SslProtocol { get; }
	public virtual bool CheckCertRevocationStatus { get; }
	public virtual X509Certificate LocalCertificate { get; }
	public virtual X509Certificate RemoteCertificate { get; }
	public virtual CipherAlgorithmType CipherAlgorithm { get; }
	public virtual int CipherStrength { get; }
	public virtual HashAlgorithmType HashAlgorithm { get; }
	public virtual int HashStrength { get; }
	public virtual ExchangeAlgorithmType KeyExchangeAlgorithm { get; }
	public virtual int KeyExchangeStrength { get; }
	public SslApplicationProtocol NegotiatedApplicationProtocol { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x22820D0 Offset: 0x22812D0 VA: 0x1822820D0
	internal MobileAuthenticatedStream get_Impl() { }

	// RVA: 0x22826D0 Offset: 0x22818D0 VA: 0x1822826D0
	internal MonoTlsProvider get_Provider() { }

	// RVA: 0x2282140 Offset: 0x2281340 VA: 0x182282140
	internal string get_InternalTargetHost() { }

	// RVA: 0x22812F0 Offset: 0x22804F0 VA: 0x1822812F0
	private static MobileTlsProvider GetProvider() { }

	// RVA: 0x2281B90 Offset: 0x2280D90 VA: 0x182281B90
	public void .ctor(Stream innerStream) { }

	// RVA: 0x2281C30 Offset: 0x2280E30 VA: 0x182281C30
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x2281C10 Offset: 0x2280E10 VA: 0x182281C10
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	// RVA: 0x2281CC0 Offset: 0x2280EC0 VA: 0x182281CC0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	[MonoLimitation("encryptionPolicy is ignored")]
	// RVA: 0x2281B80 Offset: 0x2280D80 VA: 0x182281B80
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback, EncryptionPolicy encryptionPolicy) { }

	// RVA: 0x2281A10 Offset: 0x2280C10 VA: 0x182281A10
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x2281010 Offset: 0x2280210 VA: 0x182281010
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MobileTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x2281670 Offset: 0x2280870 VA: 0x182281670
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	// RVA: 0x22814E0 Offset: 0x22806E0 VA: 0x1822814E0
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	// RVA: 0x2280DE0 Offset: 0x227FFE0 VA: 0x182280DE0
	private MonoSslServerAuthenticationOptions CreateAuthenticationOptions(SslServerAuthenticationOptions sslServerAuthenticationOptions) { }

	// RVA: 0x2280580 Offset: 0x227F780 VA: 0x182280580 Slot: 45
	public virtual void AuthenticateAsClient(string targetHost) { }

	// RVA: 0x22804D0 Offset: 0x227F6D0 VA: 0x1822804D0 Slot: 46
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, bool checkCertificateRevocation) { }

	// RVA: 0x2280500 Offset: 0x227F700 VA: 0x182280500 Slot: 47
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x22809E0 Offset: 0x227FBE0 VA: 0x1822809E0 Slot: 48
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x22809A0 Offset: 0x227FBA0 VA: 0x1822809A0 Slot: 49
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x2280A90 Offset: 0x227FC90 VA: 0x182280A90 Slot: 50
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x15C9D80 Offset: 0x15C8F80 VA: 0x1815C9D80 Slot: 51
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x2280820 Offset: 0x227FA20 VA: 0x182280820 Slot: 52
	public virtual void AuthenticateAsServer(X509Certificate serverCertificate) { }

	// RVA: 0x2280920 Offset: 0x227FB20 VA: 0x182280920 Slot: 53
	public virtual void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation) { }

	// RVA: 0x22808A0 Offset: 0x227FAA0 VA: 0x1822808A0 Slot: 54
	public virtual void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x2280B30 Offset: 0x227FD30 VA: 0x182280B30 Slot: 55
	public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x2280C10 Offset: 0x227FE10 VA: 0x182280C10 Slot: 56
	public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x2280B70 Offset: 0x227FD70 VA: 0x182280B70 Slot: 57
	public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x15C9D80 Offset: 0x15C8F80 VA: 0x1815C9D80 Slot: 58
	public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public TransportContext get_TransportContext() { }

	// RVA: 0x2280380 Offset: 0x227F580 VA: 0x182280380 Slot: 59
	public virtual Task AuthenticateAsClientAsync(string targetHost) { }

	// RVA: 0x2280450 Offset: 0x227F650 VA: 0x182280450 Slot: 60
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, bool checkCertificateRevocation) { }

	// RVA: 0x2280300 Offset: 0x227F500 VA: 0x182280300 Slot: 61
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x2280200 Offset: 0x227F400 VA: 0x182280200
	public Task AuthenticateAsClientAsync(SslClientAuthenticationOptions sslClientAuthenticationOptions, CancellationToken cancellationToken) { }

	// RVA: 0x22807A0 Offset: 0x227F9A0 VA: 0x1822807A0 Slot: 62
	public virtual Task AuthenticateAsServerAsync(X509Certificate serverCertificate) { }

	// RVA: 0x2280720 Offset: 0x227F920 VA: 0x182280720 Slot: 63
	public virtual Task AuthenticateAsServerAsync(X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation) { }

	// RVA: 0x22806A0 Offset: 0x227F8A0 VA: 0x1822806A0 Slot: 64
	public virtual Task AuthenticateAsServerAsync(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x2280610 Offset: 0x227F810 VA: 0x182280610
	public Task AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken) { }

	// RVA: 0x22817D0 Offset: 0x22809D0 VA: 0x1822817D0 Slot: 65
	public virtual Task ShutdownAsync() { }

	// RVA: 0x22821B0 Offset: 0x22813B0 VA: 0x1822821B0 Slot: 40
	public override bool get_IsAuthenticated() { }

	// RVA: 0x22822B0 Offset: 0x22814B0 VA: 0x1822822B0 Slot: 41
	public override bool get_IsMutuallyAuthenticated() { }

	// RVA: 0x2282230 Offset: 0x2281430 VA: 0x182282230 Slot: 42
	public override bool get_IsEncrypted() { }

	// RVA: 0x22823B0 Offset: 0x22815B0 VA: 0x1822823B0 Slot: 43
	public override bool get_IsSigned() { }

	// RVA: 0x2282330 Offset: 0x2281530 VA: 0x182282330 Slot: 44
	public override bool get_IsServer() { }

	// RVA: 0x2282830 Offset: 0x2281A30 VA: 0x182282830 Slot: 66
	public virtual SslProtocols get_SslProtocol() { }

	// RVA: 0x2281EA0 Offset: 0x22810A0 VA: 0x182281EA0 Slot: 67
	public virtual bool get_CheckCertRevocationStatus() { }

	// RVA: 0x2282590 Offset: 0x2281790 VA: 0x182282590 Slot: 68
	public virtual X509Certificate get_LocalCertificate() { }

	// RVA: 0x22827C0 Offset: 0x22819C0 VA: 0x1822827C0 Slot: 69
	public virtual X509Certificate get_RemoteCertificate() { }

	// RVA: 0x2281F10 Offset: 0x2281110 VA: 0x182281F10 Slot: 70
	public virtual CipherAlgorithmType get_CipherAlgorithm() { }

	// RVA: 0x2281F80 Offset: 0x2281180 VA: 0x182281F80 Slot: 71
	public virtual int get_CipherStrength() { }

	// RVA: 0x2281FF0 Offset: 0x22811F0 VA: 0x182281FF0 Slot: 72
	public virtual HashAlgorithmType get_HashAlgorithm() { }

	// RVA: 0x2282060 Offset: 0x2281260 VA: 0x182282060 Slot: 73
	public virtual int get_HashStrength() { }

	// RVA: 0x2282430 Offset: 0x2281630 VA: 0x182282430 Slot: 74
	public virtual ExchangeAlgorithmType get_KeyExchangeAlgorithm() { }

	// RVA: 0x22824A0 Offset: 0x22816A0 VA: 0x1822824A0 Slot: 75
	public virtual int get_KeyExchangeStrength() { }

	// RVA: 0x2282600 Offset: 0x2281800 VA: 0x182282600
	public SslApplicationProtocol get_NegotiatedApplicationProtocol() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2281E40 Offset: 0x2281040 VA: 0x182281E40 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1D8A450 Offset: 0x1D89650 VA: 0x181D8A450 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x2281E70 Offset: 0x2281070 VA: 0x182281E70 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2282740 Offset: 0x2281940 VA: 0x182282740 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x2282980 Offset: 0x2281B80 VA: 0x182282980 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x22828A0 Offset: 0x2281AA0 VA: 0x1822828A0 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x2282A00 Offset: 0x2281C00 VA: 0x182282A00 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x2282510 Offset: 0x2281710 VA: 0x182282510 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2282650 Offset: 0x2281850 VA: 0x182282650 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2282920 Offset: 0x2281B20 VA: 0x182282920 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2281750 Offset: 0x2280950 VA: 0x182281750 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x2281480 Offset: 0x2280680 VA: 0x182281480 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x213A1D0 Offset: 0x21393D0 VA: 0x18213A1D0 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x173D3E0 Offset: 0x173C5E0 VA: 0x18173D3E0 Slot: 22
	public override void Flush() { }

	// RVA: 0x2280D70 Offset: 0x227FF70 VA: 0x182280D70
	private void CheckDisposed() { }

	// RVA: 0x2281210 Offset: 0x2280410 VA: 0x182281210 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2281400 Offset: 0x2280600 VA: 0x182281400 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x22818C0 Offset: 0x2280AC0 VA: 0x1822818C0
	public void Write(byte[] buffer) { }

	// RVA: 0x2281990 Offset: 0x2280B90 VA: 0x182281990 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2281380 Offset: 0x2280580 VA: 0x182281380 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2281840 Offset: 0x2280A40 VA: 0x182281840 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2280C50 Offset: 0x227FE50 VA: 0x182280C50 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x22812B0 Offset: 0x22804B0 VA: 0x1822812B0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2280CE0 Offset: 0x227FEE0 VA: 0x182280CE0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x15C9D80 Offset: 0x15C8F80 VA: 0x1815C9D80 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5 // TypeDefIndex: 6374
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 // TypeDefIndex: 6375
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 // TypeDefIndex: 6376
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 // TypeDefIndex: 6377
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 6378
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 // TypeDefIndex: 6379
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 // TypeDefIndex: 6380
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 6381
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 // TypeDefIndex: 6382
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=65 // TypeDefIndex: 6383
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 // TypeDefIndex: 6384
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 6385
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=506 // TypeDefIndex: 6386
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2024 // TypeDefIndex: 6387
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6388
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 00C700F38385659BA060672F86D4A9A5376EADF9ED1CABB1C63290A0FDEFE36A /*Metadata offset 0x8A6DC0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 04D9D643E5A26924DC98C9906714082D395DCB17CEE9674D5EBFEC15D098C2B5 /*Metadata offset 0x8A6EC8*/; // 0x100
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 063691760A57230E8119DF650327304D68AE1C009E476E48BE8C73DCA199D374 /*Metadata offset 0x8A6EF0*/; // 0x120
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 07FEA8B695D401E2B3BBDA6126C123DAA87153BB12384B21272ACC90823AC9A3 /*Metadata offset 0x8A6F18*/; // 0x140
	internal static readonly long 1417FCAA8455DC8E3C88BF916DD5C75746A2597CC052F212A8E4394C890E012B = 2533330625626144; // 0x150
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 21244F82B210125632917591768F6BF22EB6861F80C6C25A25BD26DFB580EA7B /*Metadata offset 0x8A6F38*/; // 0x158
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2125B2C332B1113AAE9BFC5E9F7E3B4C91D828CB942C2DF1EEB02502ECCAE9E9 /*Metadata offset 0x8A7040*/; // 0x258
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 27625E383C3A91E8B65BC745FF5D4048C82B883CCD293B07DED697BF82733811 /*Metadata offset 0x8A7058*/; // 0x268
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70 /*Metadata offset 0x8A7068*/; // 0x271
	internal static readonly long 34B06173CE6C3C7CBDB99C416ECB98BD8F75845A7E23ED4B039EC239EB5559AA = 3543824036607063144; // 0x298
	internal static readonly long 3505B8A2248AC03FE41ACADF8F29294572BBADEE1DD2E1A45D025766681C012C = 2533317740920864; // 0x2A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 356A582FCE68ACAE8FC944F7B4F0C0DA2BFF4A90D3767C75905F3EDE2E4E66CF /*Metadata offset 0x8A70B0*/; // 0x2A8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 3981C8DFF7DC0FD5962B5FB863DD1A0D4119D320706BFF88FD6F636AC6B93AFF /*Metadata offset 0x8A70C0*/; // 0x2B4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 403437D13B88F9747B77293CF0005E5570505DDE480AFCE7F2BC23DDDBE0F140 /*Metadata offset 0x8A70C8*/; // 0x2BA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 40AE2D0932F1E381C2D74CC90C0CDB9E9B281F32D52EC31C9F1B51CDCB209C19 /*Metadata offset 0x8A70D0*/; // 0x2C0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2024 4186171278342045F6399928145039267A761B52DE295D22617755191250963B /*Metadata offset 0x8A70D8*/; // 0x2C6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6 /*Metadata offset 0x8A78C8*/; // 0xAAE
	internal static readonly long 6C8F647E1FCD63826D12272FF0930E9C16F1FFEF719948703A4C0F3B90052885 = 2814805604696096; // 0xAB8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3 /*Metadata offset 0x8A78E8*/; // 0xAC0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8 /*Metadata offset 0x8A7970*/; // 0xB40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5 933B971C6388D594A23FA1559825DB5BEC8ADE2DB1240AA8FC9D0C684949E8C9 /*Metadata offset 0x8A79A0*/; // 0xB6C
	internal static readonly long 9AB02D4EDAFA1AFB26F1BAB7CDF573693435A48FFF5C20EDE5054E1CEEB23923 = 6269030238970214543; // 0xB78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 9DB0F923DCA529159AFF809431DDCC62C801C60246F66B693B861CBF79292994 /*Metadata offset 0x8A79B8*/; // 0xB80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 9F58F1261D211553DE8FBC1AFA477C84EA3974B9BFF38223D771D0CDA787E15A /*Metadata offset 0x8A79C8*/; // 0xB8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C /*Metadata offset 0x8A79D0*/; // 0xB92
	internal static readonly long BB6BB42AC5453BD8AA992CCB8929F1CB7D4E112E3FC56E57D711E106D1F72859 = 11540663026319392; // 0xC18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 CCB8E87DA26F5138481631D85E025CD55F0DE5BFAEF33909EAABD6D513EF4B89 /*Metadata offset 0x8A7A68*/; // 0xC20
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 DFA7289CF8D8029ACEE90F30530C6926950E8DD20285772458F271AFD015BAD5 /*Metadata offset 0x8A7A70*/; // 0xC26
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=506 E1284F363C1A2B6A4343050EF21AEF5522855D9D77B656F54D1933235476FADC /*Metadata offset 0x8A7A80*/; // 0xC34
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=65 E173D43DE98094098259467FF632B4FC61496AF96F3A354A006360D246E8166F /*Metadata offset 0x8A7C80*/; // 0xE2E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 E478CC6C0579E2198C99BFDE0ABAADC66644AF69312CB9D6E94E2D4E3559482A /*Metadata offset 0x8A7CC8*/; // 0xE6F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 F2830F044682E33B39018B5912634835B641562914E192CA66C654F5E4492FA8 /*Metadata offset 0x8A7CD8*/; // 0xE79

	// Methods

	// RVA: 0x840E00 Offset: 0x840000 VA: 0x180840E00
	internal static uint ComputeStringHash(string s) { }
}

// Namespace: System.CodeDom.Compiler
[ToolboxItem(False)]
[ComVisible(True)]
public abstract class CodeDomProvider : Component // TypeDefIndex: 6389
{
	// Properties
	public virtual string FileExtension { get; }
	public virtual LanguageOptions LanguageOptions { get; }

	// Methods

	// RVA: 0x226D5C0 Offset: 0x226C7C0 VA: 0x18226D5C0
	protected void .ctor() { }

	// RVA: 0x226D5F0 Offset: 0x226C7F0 VA: 0x18226D5F0 Slot: 16
	public virtual string get_FileExtension() { }

	// RVA: 0x226D620 Offset: 0x226C820 VA: 0x18226D620 Slot: 17
	public virtual LanguageOptions get_LanguageOptions() { }

	// RVA: 0x226D0E0 Offset: 0x226C2E0 VA: 0x18226D0E0 Slot: 18
	public virtual CompilerResults CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit[] compilationUnits) { }

	// RVA: 0x226D110 Offset: 0x226C310 VA: 0x18226D110 Slot: 19
	public virtual CompilerResults CompileAssemblyFromFile(CompilerParameters options, string[] fileNames) { }

	// RVA: 0x226D140 Offset: 0x226C340 VA: 0x18226D140 Slot: 20
	public virtual CompilerResults CompileAssemblyFromSource(CompilerParameters options, string[] sources) { }

	[Obsolete("Callers should not use the ICodeCompiler interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICodeCompiler CreateCompiler();

	// RVA: 0x226D170 Offset: 0x226C370 VA: 0x18226D170 Slot: 22
	public virtual string CreateEscapedIdentifier(string value) { }

	[Obsolete("Callers should not use the ICodeGenerator interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICodeGenerator CreateGenerator();

	// RVA: 0x226D1A0 Offset: 0x226C3A0 VA: 0x18226D1A0 Slot: 24
	public virtual ICodeGenerator CreateGenerator(TextWriter output) { }

	// RVA: 0x226D1D0 Offset: 0x226C3D0 VA: 0x18226D1D0 Slot: 25
	public virtual ICodeGenerator CreateGenerator(string fileName) { }

	[Obsolete("Callers should not use the ICodeParser interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
	// RVA: 0x226D200 Offset: 0x226C400 VA: 0x18226D200 Slot: 26
	public virtual ICodeParser CreateParser() { }

	[ComVisible(False)]
	// RVA: 0x226D230 Offset: 0x226C430 VA: 0x18226D230
	public static CodeDomProvider CreateProvider(string language) { }

	[ComVisible(False)]
	// RVA: 0x226D260 Offset: 0x226C460 VA: 0x18226D260
	public static CodeDomProvider CreateProvider(string language, IDictionary<string, string> providerOptions) { }

	// RVA: 0x226D290 Offset: 0x226C490 VA: 0x18226D290 Slot: 27
	public virtual string CreateValidIdentifier(string value) { }

	// RVA: 0x226D2C0 Offset: 0x226C4C0 VA: 0x18226D2C0 Slot: 28
	public virtual void GenerateCodeFromCompileUnit(CodeCompileUnit compileUnit, TextWriter writer, CodeGeneratorOptions options) { }

	// RVA: 0x226D2F0 Offset: 0x226C4F0 VA: 0x18226D2F0 Slot: 29
	public virtual void GenerateCodeFromExpression(CodeExpression expression, TextWriter writer, CodeGeneratorOptions options) { }

	// RVA: 0x226D320 Offset: 0x226C520 VA: 0x18226D320 Slot: 30
	public virtual void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options) { }

	// RVA: 0x226D350 Offset: 0x226C550 VA: 0x18226D350 Slot: 31
	public virtual void GenerateCodeFromNamespace(CodeNamespace codeNamespace, TextWriter writer, CodeGeneratorOptions options) { }

	// RVA: 0x226D380 Offset: 0x226C580 VA: 0x18226D380 Slot: 32
	public virtual void GenerateCodeFromStatement(CodeStatement statement, TextWriter writer, CodeGeneratorOptions options) { }

	// RVA: 0x226D3B0 Offset: 0x226C5B0 VA: 0x18226D3B0 Slot: 33
	public virtual void GenerateCodeFromType(CodeTypeDeclaration codeType, TextWriter writer, CodeGeneratorOptions options) { }

	[ComVisible(False)]
	// RVA: 0x226D3E0 Offset: 0x226C5E0 VA: 0x18226D3E0
	public static CompilerInfo[] GetAllCompilerInfo() { }

	[ComVisible(False)]
	// RVA: 0x226D410 Offset: 0x226C610 VA: 0x18226D410
	public static CompilerInfo GetCompilerInfo(string language) { }

	// RVA: 0x226D440 Offset: 0x226C640 VA: 0x18226D440 Slot: 34
	public virtual TypeConverter GetConverter(Type type) { }

	[ComVisible(False)]
	// RVA: 0x226D470 Offset: 0x226C670 VA: 0x18226D470
	public static string GetLanguageFromExtension(string extension) { }

	// RVA: 0x226D4A0 Offset: 0x226C6A0 VA: 0x18226D4A0 Slot: 35
	public virtual string GetTypeOutput(CodeTypeReference type) { }

	[ComVisible(False)]
	// RVA: 0x226D4D0 Offset: 0x226C6D0 VA: 0x18226D4D0
	public static bool IsDefinedExtension(string extension) { }

	[ComVisible(False)]
	// RVA: 0x226D500 Offset: 0x226C700 VA: 0x18226D500
	public static bool IsDefinedLanguage(string language) { }

	// RVA: 0x226D530 Offset: 0x226C730 VA: 0x18226D530 Slot: 36
	public virtual bool IsValidIdentifier(string value) { }

	// RVA: 0x226D560 Offset: 0x226C760 VA: 0x18226D560 Slot: 37
	public virtual CodeCompileUnit Parse(TextReader codeStream) { }

	// RVA: 0x226D590 Offset: 0x226C790 VA: 0x18226D590 Slot: 38
	public virtual bool Supports(GeneratorSupport generatorSupport) { }
}

// Namespace: System.CodeDom.Compiler
[Flags]
[Serializable]
public enum LanguageOptions // TypeDefIndex: 6390
{
	// Fields
	public int value__; // 0x0
	public const LanguageOptions CaseInsensitive = 1;
	public const LanguageOptions None = 0;
}

// Namespace: System.CodeDom.Compiler
[Serializable]
public class CompilerParameters // TypeDefIndex: 6391
{
	// Properties
	public string CompilerOptions { get; set; }
	public string CoreAssemblyFileName { get; set; }
	public StringCollection EmbeddedResources { get; }
	public Evidence Evidence { get; set; }
	public bool GenerateExecutable { get; set; }
	public bool GenerateInMemory { get; set; }
	public bool IncludeDebugInformation { get; set; }
	public StringCollection LinkedResources { get; }
	public string MainClass { get; set; }
	public string OutputAssembly { get; set; }
	public StringCollection ReferencedAssemblies { get; }
	public TempFileCollection TempFiles { get; set; }
	public bool TreatWarningsAsErrors { get; set; }
	public IntPtr UserToken { get; set; }
	public int WarningLevel { get; set; }
	public string Win32Resource { get; set; }

	// Methods

	// RVA: 0x2273A70 Offset: 0x2272C70 VA: 0x182273A70
	public void .ctor() { }

	// RVA: 0x2273AA0 Offset: 0x2272CA0 VA: 0x182273AA0
	public void .ctor(string[] assemblyNames) { }

	// RVA: 0x2273A40 Offset: 0x2272C40 VA: 0x182273A40
	public void .ctor(string[] assemblyNames, string outputName) { }

	// RVA: 0x2273A10 Offset: 0x2272C10 VA: 0x182273A10
	public void .ctor(string[] assemblyNames, string outputName, bool includeDebugInformation) { }

	// RVA: 0x2273AD0 Offset: 0x2272CD0 VA: 0x182273AD0
	public string get_CompilerOptions() { }

	// RVA: 0x2273DD0 Offset: 0x2272FD0 VA: 0x182273DD0
	public void set_CompilerOptions(string value) { }

	// RVA: 0x2273B00 Offset: 0x2272D00 VA: 0x182273B00
	public string get_CoreAssemblyFileName() { }

	// RVA: 0x2273E00 Offset: 0x2273000 VA: 0x182273E00
	public void set_CoreAssemblyFileName(string value) { }

	// RVA: 0x2273B30 Offset: 0x2272D30 VA: 0x182273B30
	public StringCollection get_EmbeddedResources() { }

	// RVA: 0x2273B60 Offset: 0x2272D60 VA: 0x182273B60
	public Evidence get_Evidence() { }

	// RVA: 0x2273E30 Offset: 0x2273030 VA: 0x182273E30
	public void set_Evidence(Evidence value) { }

	// RVA: 0x2273B90 Offset: 0x2272D90 VA: 0x182273B90
	public bool get_GenerateExecutable() { }

	// RVA: 0x2273E60 Offset: 0x2273060 VA: 0x182273E60
	public void set_GenerateExecutable(bool value) { }

	// RVA: 0x2273BC0 Offset: 0x2272DC0 VA: 0x182273BC0
	public bool get_GenerateInMemory() { }

	// RVA: 0x2273E90 Offset: 0x2273090 VA: 0x182273E90
	public void set_GenerateInMemory(bool value) { }

	// RVA: 0x2273BF0 Offset: 0x2272DF0 VA: 0x182273BF0
	public bool get_IncludeDebugInformation() { }

	// RVA: 0x2273EC0 Offset: 0x22730C0 VA: 0x182273EC0
	public void set_IncludeDebugInformation(bool value) { }

	// RVA: 0x2273C20 Offset: 0x2272E20 VA: 0x182273C20
	public StringCollection get_LinkedResources() { }

	// RVA: 0x2273C50 Offset: 0x2272E50 VA: 0x182273C50
	public string get_MainClass() { }

	// RVA: 0x2273EF0 Offset: 0x22730F0 VA: 0x182273EF0
	public void set_MainClass(string value) { }

	// RVA: 0x2273C80 Offset: 0x2272E80 VA: 0x182273C80
	public string get_OutputAssembly() { }

	// RVA: 0x2273F20 Offset: 0x2273120 VA: 0x182273F20
	public void set_OutputAssembly(string value) { }

	// RVA: 0x2273CB0 Offset: 0x2272EB0 VA: 0x182273CB0
	public StringCollection get_ReferencedAssemblies() { }

	// RVA: 0x2273CE0 Offset: 0x2272EE0 VA: 0x182273CE0
	public TempFileCollection get_TempFiles() { }

	// RVA: 0x2273F50 Offset: 0x2273150 VA: 0x182273F50
	public void set_TempFiles(TempFileCollection value) { }

	// RVA: 0x2273D10 Offset: 0x2272F10 VA: 0x182273D10
	public bool get_TreatWarningsAsErrors() { }

	// RVA: 0x2273F80 Offset: 0x2273180 VA: 0x182273F80
	public void set_TreatWarningsAsErrors(bool value) { }

	// RVA: 0x2273D40 Offset: 0x2272F40 VA: 0x182273D40
	public IntPtr get_UserToken() { }

	// RVA: 0x2273FB0 Offset: 0x22731B0 VA: 0x182273FB0
	public void set_UserToken(IntPtr value) { }

	// RVA: 0x2273D70 Offset: 0x2272F70 VA: 0x182273D70
	public int get_WarningLevel() { }

	// RVA: 0x2273FE0 Offset: 0x22731E0 VA: 0x182273FE0
	public void set_WarningLevel(int value) { }

	// RVA: 0x2273DA0 Offset: 0x2272FA0 VA: 0x182273DA0
	public string get_Win32Resource() { }

	// RVA: 0x2274010 Offset: 0x2273210 VA: 0x182274010
	public void set_Win32Resource(string value) { }
}

// Namespace: System.CodeDom.Compiler
[Serializable]
public class TempFileCollection : ICollection, IEnumerable, IDisposable // TypeDefIndex: 6392
{
	// Properties
	public string BasePath { get; }
	public int Count { get; }
	public bool KeepFiles { get; set; }
	public string TempDir { get; }

	// Methods

	// RVA: 0x2283830 Offset: 0x2282A30 VA: 0x182283830
	public void .ctor() { }

	// RVA: 0x2283860 Offset: 0x2282A60 VA: 0x182283860
	public void .ctor(string tempDir) { }

	// RVA: 0x2283890 Offset: 0x2282A90 VA: 0x182283890
	public void .ctor(string tempDir, bool keepFiles) { }

	// RVA: 0x22838C0 Offset: 0x2282AC0 VA: 0x1822838C0
	public string get_BasePath() { }

	// RVA: 0x22838F0 Offset: 0x2282AF0 VA: 0x1822838F0
	public int get_Count() { }

	// RVA: 0x2283920 Offset: 0x2282B20 VA: 0x182283920
	public bool get_KeepFiles() { }

	// RVA: 0x2283980 Offset: 0x2282B80 VA: 0x182283980
	public void set_KeepFiles(bool value) { }

	// RVA: 0x2283740 Offset: 0x2282940 VA: 0x182283740 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x2283770 Offset: 0x2282970 VA: 0x182283770 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x22837A0 Offset: 0x22829A0 VA: 0x1822837A0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2283950 Offset: 0x2282B50 VA: 0x182283950
	public string get_TempDir() { }

	// RVA: 0x22835C0 Offset: 0x22827C0 VA: 0x1822835C0
	public string AddExtension(string fileExtension) { }

	// RVA: 0x22835F0 Offset: 0x22827F0 VA: 0x1822835F0
	public string AddExtension(string fileExtension, bool keepFile) { }

	// RVA: 0x2283620 Offset: 0x2282820 VA: 0x182283620
	public void AddFile(string fileName, bool keepFile) { }

	// RVA: 0x2283650 Offset: 0x2282850 VA: 0x182283650
	public void CopyTo(string[] fileNames, int start) { }

	// RVA: 0x2283680 Offset: 0x2282880 VA: 0x182283680
	public void Delete() { }

	// RVA: 0x22836B0 Offset: 0x22828B0 VA: 0x1822836B0 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x22836E0 Offset: 0x22828E0 VA: 0x1822836E0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2283710 Offset: 0x2282910 VA: 0x182283710 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int start) { }

	// RVA: 0x22837D0 Offset: 0x22829D0 VA: 0x1822837D0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2283800 Offset: 0x2282A00 VA: 0x182283800 Slot: 9
	private void System.IDisposable.Dispose() { }
}

// Namespace: System.CodeDom.Compiler
[Serializable]
public class CompilerResults // TypeDefIndex: 6393
{
	// Properties
	public Assembly CompiledAssembly { get; set; }
	public CompilerErrorCollection Errors { get; }
	public Evidence Evidence { get; set; }
	public int NativeCompilerReturnValue { get; set; }
	public StringCollection Output { get; }
	public string PathToAssembly { get; set; }
	public TempFileCollection TempFiles { get; set; }

	// Methods

	// RVA: 0x2274040 Offset: 0x2273240 VA: 0x182274040
	public void .ctor(TempFileCollection tempFiles) { }

	// RVA: 0x2274070 Offset: 0x2273270 VA: 0x182274070
	public Assembly get_CompiledAssembly() { }

	// RVA: 0x22741C0 Offset: 0x22733C0 VA: 0x1822741C0
	public void set_CompiledAssembly(Assembly value) { }

	// RVA: 0x22740A0 Offset: 0x22732A0 VA: 0x1822740A0
	public CompilerErrorCollection get_Errors() { }

	// RVA: 0x22740D0 Offset: 0x22732D0 VA: 0x1822740D0
	public Evidence get_Evidence() { }

	// RVA: 0x22741F0 Offset: 0x22733F0 VA: 0x1822741F0
	public void set_Evidence(Evidence value) { }

	// RVA: 0x2274100 Offset: 0x2273300 VA: 0x182274100
	public int get_NativeCompilerReturnValue() { }

	// RVA: 0x2274220 Offset: 0x2273420 VA: 0x182274220
	public void set_NativeCompilerReturnValue(int value) { }

	// RVA: 0x2274130 Offset: 0x2273330 VA: 0x182274130
	public StringCollection get_Output() { }

	// RVA: 0x2274160 Offset: 0x2273360 VA: 0x182274160
	public string get_PathToAssembly() { }

	// RVA: 0x2274250 Offset: 0x2273450 VA: 0x182274250
	public void set_PathToAssembly(string value) { }

	// RVA: 0x2274190 Offset: 0x2273390 VA: 0x182274190
	public TempFileCollection get_TempFiles() { }

	// RVA: 0x2274280 Offset: 0x2273480 VA: 0x182274280
	public void set_TempFiles(TempFileCollection value) { }
}

// Namespace: System.CodeDom.Compiler
[DefaultMember("Item")]
[Serializable]
public class CompilerErrorCollection : CollectionBase // TypeDefIndex: 6394
{
	// Properties
	public bool HasErrors { get; }
	public bool HasWarnings { get; }
	public CompilerError Item { get; set; }

	// Methods

	// RVA: 0x2273500 Offset: 0x2272700 VA: 0x182273500
	public void .ctor() { }

	// RVA: 0x22734A0 Offset: 0x22726A0 VA: 0x1822734A0
	public void .ctor(CompilerErrorCollection value) { }

	// RVA: 0x22734D0 Offset: 0x22726D0 VA: 0x1822734D0
	public void .ctor(CompilerError[] value) { }

	// RVA: 0x2273530 Offset: 0x2272730 VA: 0x182273530
	public bool get_HasErrors() { }

	// RVA: 0x2273560 Offset: 0x2272760 VA: 0x182273560
	public bool get_HasWarnings() { }

	// RVA: 0x2273590 Offset: 0x2272790 VA: 0x182273590
	public CompilerError get_Item(int index) { }

	// RVA: 0x22735C0 Offset: 0x22727C0 VA: 0x1822735C0
	public void set_Item(int index, CompilerError value) { }

	// RVA: 0x2273380 Offset: 0x2272580 VA: 0x182273380
	public int Add(CompilerError value) { }

	// RVA: 0x2273350 Offset: 0x2272550 VA: 0x182273350
	public void AddRange(CompilerErrorCollection value) { }

	// RVA: 0x2273320 Offset: 0x2272520 VA: 0x182273320
	public void AddRange(CompilerError[] value) { }

	// RVA: 0x22733B0 Offset: 0x22725B0 VA: 0x1822733B0
	public bool Contains(CompilerError value) { }

	// RVA: 0x22733E0 Offset: 0x22725E0 VA: 0x1822733E0
	public void CopyTo(CompilerError[] array, int index) { }

	// RVA: 0x2273410 Offset: 0x2272610 VA: 0x182273410
	public int IndexOf(CompilerError value) { }

	// RVA: 0x2273440 Offset: 0x2272640 VA: 0x182273440
	public void Insert(int index, CompilerError value) { }

	// RVA: 0x2273470 Offset: 0x2272670 VA: 0x182273470
	public void Remove(CompilerError value) { }
}

// Namespace: System.CodeDom.Compiler
[Serializable]
public class CompilerError // TypeDefIndex: 6395
{
	// Properties
	public int Column { get; set; }
	public string ErrorNumber { get; set; }
	public string ErrorText { get; set; }
	public string FileName { get; set; }
	public bool IsWarning { get; set; }
	public int Line { get; set; }

	// Methods

	// RVA: 0x2273620 Offset: 0x2272820 VA: 0x182273620
	public void .ctor() { }

	// RVA: 0x22735F0 Offset: 0x22727F0 VA: 0x1822735F0
	public void .ctor(string fileName, int line, int column, string errorNumber, string errorText) { }

	// RVA: 0x2273650 Offset: 0x2272850 VA: 0x182273650
	public int get_Column() { }

	// RVA: 0x2273770 Offset: 0x2272970 VA: 0x182273770
	public void set_Column(int value) { }

	// RVA: 0x2273680 Offset: 0x2272880 VA: 0x182273680
	public string get_ErrorNumber() { }

	// RVA: 0x22737A0 Offset: 0x22729A0 VA: 0x1822737A0
	public void set_ErrorNumber(string value) { }

	// RVA: 0x22736B0 Offset: 0x22728B0 VA: 0x1822736B0
	public string get_ErrorText() { }

	// RVA: 0x22737D0 Offset: 0x22729D0 VA: 0x1822737D0
	public void set_ErrorText(string value) { }

	// RVA: 0x22736E0 Offset: 0x22728E0 VA: 0x1822736E0
	public string get_FileName() { }

	// RVA: 0x2273800 Offset: 0x2272A00 VA: 0x182273800
	public void set_FileName(string value) { }

	// RVA: 0x2273710 Offset: 0x2272910 VA: 0x182273710
	public bool get_IsWarning() { }

	// RVA: 0x2273830 Offset: 0x2272A30 VA: 0x182273830
	public void set_IsWarning(bool value) { }

	// RVA: 0x2273740 Offset: 0x2272940 VA: 0x182273740
	public int get_Line() { }

	// RVA: 0x2273860 Offset: 0x2272A60 VA: 0x182273860
	public void set_Line(int value) { }
}

// Namespace: System.CodeDom.Compiler
public interface ICodeCompiler // TypeDefIndex: 6396
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CompilerResults CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit compilationUnit);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract CompilerResults CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] compilationUnits);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract CompilerResults CompileAssemblyFromFile(CompilerParameters options, string fileName);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract CompilerResults CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract CompilerResults CompileAssemblyFromSource(CompilerParameters options, string source);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract CompilerResults CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources);
}

// Namespace: System.CodeDom.Compiler
public interface ICodeGenerator // TypeDefIndex: 6397
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string CreateEscapedIdentifier(string value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string CreateValidIdentifier(string value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GenerateCodeFromCompileUnit(CodeCompileUnit e, TextWriter w, CodeGeneratorOptions o);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GenerateCodeFromExpression(CodeExpression e, TextWriter w, CodeGeneratorOptions o);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void GenerateCodeFromNamespace(CodeNamespace e, TextWriter w, CodeGeneratorOptions o);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GenerateCodeFromStatement(CodeStatement e, TextWriter w, CodeGeneratorOptions o);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GenerateCodeFromType(CodeTypeDeclaration e, TextWriter w, CodeGeneratorOptions o);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string GetTypeOutput(CodeTypeReference type);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsValidIdentifier(string value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Supports(GeneratorSupport supports);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void ValidateIdentifier(string value);
}

// Namespace: System.CodeDom.Compiler
[DefaultMember("Item")]
public class CodeGeneratorOptions // TypeDefIndex: 6398
{
	// Properties
	public bool BlankLinesBetweenMembers { get; set; }
	public string BracingStyle { get; set; }
	public bool ElseOnClosing { get; set; }
	public string IndentString { get; set; }
	public object Item { get; set; }
	public bool VerbatimOrder { get; set; }

	// Methods

	// RVA: 0x226DC20 Offset: 0x226CE20 VA: 0x18226DC20
	public void .ctor() { }

	// RVA: 0x226DC50 Offset: 0x226CE50 VA: 0x18226DC50
	public bool get_BlankLinesBetweenMembers() { }

	// RVA: 0x226DD70 Offset: 0x226CF70 VA: 0x18226DD70
	public void set_BlankLinesBetweenMembers(bool value) { }

	// RVA: 0x226DC80 Offset: 0x226CE80 VA: 0x18226DC80
	public string get_BracingStyle() { }

	// RVA: 0x226DDA0 Offset: 0x226CFA0 VA: 0x18226DDA0
	public void set_BracingStyle(string value) { }

	// RVA: 0x226DCB0 Offset: 0x226CEB0 VA: 0x18226DCB0
	public bool get_ElseOnClosing() { }

	// RVA: 0x226DDD0 Offset: 0x226CFD0 VA: 0x18226DDD0
	public void set_ElseOnClosing(bool value) { }

	// RVA: 0x226DCE0 Offset: 0x226CEE0 VA: 0x18226DCE0
	public string get_IndentString() { }

	// RVA: 0x226DE00 Offset: 0x226D000 VA: 0x18226DE00
	public void set_IndentString(string value) { }

	// RVA: 0x226DD10 Offset: 0x226CF10 VA: 0x18226DD10
	public object get_Item(string index) { }

	// RVA: 0x226DE30 Offset: 0x226D030 VA: 0x18226DE30
	public void set_Item(string index, object value) { }

	// RVA: 0x226DD40 Offset: 0x226CF40 VA: 0x18226DD40
	public bool get_VerbatimOrder() { }

	// RVA: 0x226DE60 Offset: 0x226D060 VA: 0x18226DE60
	public void set_VerbatimOrder(bool value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeExpression : CodeObject // TypeDefIndex: 6399
{
	// Methods

	// RVA: 0x226DAD0 Offset: 0x226CCD0 VA: 0x18226DAD0
	public void .ctor() { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeObject // TypeDefIndex: 6400
{
	// Properties
	public IDictionary UserData { get; }

	// Methods

	// RVA: 0x2270860 Offset: 0x226FA60 VA: 0x182270860
	public void .ctor() { }

	// RVA: 0x2270890 Offset: 0x226FA90 VA: 0x182270890
	public IDictionary get_UserData() { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeNamespace : CodeObject // TypeDefIndex: 6401
{
	// Properties
	public CodeCommentStatementCollection Comments { get; }
	public CodeNamespaceImportCollection Imports { get; }
	public string Name { get; set; }
	public CodeTypeDeclarationCollection Types { get; }

	// Methods

	// RVA: 0x22704D0 Offset: 0x226F6D0 VA: 0x1822704D0
	public void .ctor() { }

	// RVA: 0x22704A0 Offset: 0x226F6A0 VA: 0x1822704A0
	public void .ctor(string name) { }

	// RVA: 0x2270590 Offset: 0x226F790 VA: 0x182270590
	public CodeCommentStatementCollection get_Comments() { }

	// RVA: 0x22705C0 Offset: 0x226F7C0 VA: 0x1822705C0
	public CodeNamespaceImportCollection get_Imports() { }

	// RVA: 0x22705F0 Offset: 0x226F7F0 VA: 0x1822705F0
	public string get_Name() { }

	// RVA: 0x22706E0 Offset: 0x226F8E0 VA: 0x1822706E0
	public void set_Name(string value) { }

	// RVA: 0x2270620 Offset: 0x226F820 VA: 0x182270620
	public CodeTypeDeclarationCollection get_Types() { }

	// RVA: 0x2270500 Offset: 0x226F700 VA: 0x182270500
	public void add_PopulateComments(EventHandler value) { }

	// RVA: 0x2270650 Offset: 0x226F850 VA: 0x182270650
	public void remove_PopulateComments(EventHandler value) { }

	// RVA: 0x2270530 Offset: 0x226F730 VA: 0x182270530
	public void add_PopulateImports(EventHandler value) { }

	// RVA: 0x2270680 Offset: 0x226F880 VA: 0x182270680
	public void remove_PopulateImports(EventHandler value) { }

	// RVA: 0x2270560 Offset: 0x226F760 VA: 0x182270560
	public void add_PopulateTypes(EventHandler value) { }

	// RVA: 0x22706B0 Offset: 0x226F8B0 VA: 0x1822706B0
	public void remove_PopulateTypes(EventHandler value) { }
}

// Namespace: System.CodeDom
[DefaultMember("Item")]
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeCommentStatementCollection : CollectionBase // TypeDefIndex: 6402
{
	// Properties
	public CodeCommentStatement Item { get; set; }

	// Methods

	// RVA: 0x226C1B0 Offset: 0x226B3B0 VA: 0x18226C1B0
	public void .ctor() { }

	// RVA: 0x226C1E0 Offset: 0x226B3E0 VA: 0x18226C1E0
	public void .ctor(CodeCommentStatementCollection value) { }

	// RVA: 0x226C210 Offset: 0x226B410 VA: 0x18226C210
	public void .ctor(CodeCommentStatement[] value) { }

	// RVA: 0x226C240 Offset: 0x226B440 VA: 0x18226C240
	public CodeCommentStatement get_Item(int index) { }

	// RVA: 0x226C270 Offset: 0x226B470 VA: 0x18226C270
	public void set_Item(int index, CodeCommentStatement value) { }

	// RVA: 0x226C090 Offset: 0x226B290 VA: 0x18226C090
	public int Add(CodeCommentStatement value) { }

	// RVA: 0x226C060 Offset: 0x226B260 VA: 0x18226C060
	public void AddRange(CodeCommentStatementCollection value) { }

	// RVA: 0x226C030 Offset: 0x226B230 VA: 0x18226C030
	public void AddRange(CodeCommentStatement[] value) { }

	// RVA: 0x226C0C0 Offset: 0x226B2C0 VA: 0x18226C0C0
	public bool Contains(CodeCommentStatement value) { }

	// RVA: 0x226C0F0 Offset: 0x226B2F0 VA: 0x18226C0F0
	public void CopyTo(CodeCommentStatement[] array, int index) { }

	// RVA: 0x226C120 Offset: 0x226B320 VA: 0x18226C120
	public int IndexOf(CodeCommentStatement value) { }

	// RVA: 0x226C150 Offset: 0x226B350 VA: 0x18226C150
	public void Insert(int index, CodeCommentStatement value) { }

	// RVA: 0x226C180 Offset: 0x226B380 VA: 0x18226C180
	public void Remove(CodeCommentStatement value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeCommentStatement : CodeStatement // TypeDefIndex: 6403
{
	// Properties
	public CodeComment Comment { get; set; }

	// Methods

	// RVA: 0x226C2A0 Offset: 0x226B4A0 VA: 0x18226C2A0
	public void .ctor() { }

	// RVA: 0x226C330 Offset: 0x226B530 VA: 0x18226C330
	public void .ctor(CodeComment comment) { }

	// RVA: 0x226C2D0 Offset: 0x226B4D0 VA: 0x18226C2D0
	public void .ctor(string text) { }

	// RVA: 0x226C300 Offset: 0x226B500 VA: 0x18226C300
	public void .ctor(string text, bool docComment) { }

	// RVA: 0x226C360 Offset: 0x226B560 VA: 0x18226C360
	public CodeComment get_Comment() { }

	// RVA: 0x226C390 Offset: 0x226B590 VA: 0x18226C390
	public void set_Comment(CodeComment value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeStatement : CodeObject // TypeDefIndex: 6404
{
	// Properties
	public CodeDirectiveCollection EndDirectives { get; }
	public CodeLinePragma LinePragma { get; set; }
	public CodeDirectiveCollection StartDirectives { get; }

	// Methods

	// RVA: 0x2271820 Offset: 0x2270A20 VA: 0x182271820
	public void .ctor() { }

	// RVA: 0x2271850 Offset: 0x2270A50 VA: 0x182271850
	public CodeDirectiveCollection get_EndDirectives() { }

	// RVA: 0x2271880 Offset: 0x2270A80 VA: 0x182271880
	public CodeLinePragma get_LinePragma() { }

	// RVA: 0x22718E0 Offset: 0x2270AE0 VA: 0x1822718E0
	public void set_LinePragma(CodeLinePragma value) { }

	// RVA: 0x22718B0 Offset: 0x2270AB0 VA: 0x1822718B0
	public CodeDirectiveCollection get_StartDirectives() { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[DefaultMember("Item")]
[Serializable]
public class CodeDirectiveCollection : CollectionBase // TypeDefIndex: 6405
{
	// Properties
	public CodeDirective Item { get; set; }

	// Methods

	// RVA: 0x226CFC0 Offset: 0x226C1C0 VA: 0x18226CFC0
	public void .ctor() { }

	// RVA: 0x226D020 Offset: 0x226C220 VA: 0x18226D020
	public void .ctor(CodeDirectiveCollection value) { }

	// RVA: 0x226CFF0 Offset: 0x226C1F0 VA: 0x18226CFF0
	public void .ctor(CodeDirective[] value) { }

	// RVA: 0x226D050 Offset: 0x226C250 VA: 0x18226D050
	public CodeDirective get_Item(int index) { }

	// RVA: 0x226D080 Offset: 0x226C280 VA: 0x18226D080
	public void set_Item(int index, CodeDirective value) { }

	// RVA: 0x226CEA0 Offset: 0x226C0A0 VA: 0x18226CEA0
	public int Add(CodeDirective value) { }

	// RVA: 0x226CE70 Offset: 0x226C070 VA: 0x18226CE70
	public void AddRange(CodeDirectiveCollection value) { }

	// RVA: 0x226CE40 Offset: 0x226C040 VA: 0x18226CE40
	public void AddRange(CodeDirective[] value) { }

	// RVA: 0x226CED0 Offset: 0x226C0D0 VA: 0x18226CED0
	public bool Contains(CodeDirective value) { }

	// RVA: 0x226CF00 Offset: 0x226C100 VA: 0x18226CF00
	public void CopyTo(CodeDirective[] array, int index) { }

	// RVA: 0x226CF30 Offset: 0x226C130 VA: 0x18226CF30
	public int IndexOf(CodeDirective value) { }

	// RVA: 0x226CF60 Offset: 0x226C160 VA: 0x18226CF60
	public void Insert(int index, CodeDirective value) { }

	// RVA: 0x226CF90 Offset: 0x226C190 VA: 0x18226CF90
	public void Remove(CodeDirective value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeDirective : CodeObject // TypeDefIndex: 6406
{
	// Methods

	// RVA: 0x226D0B0 Offset: 0x226C2B0 VA: 0x18226D0B0
	public void .ctor() { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeLinePragma // TypeDefIndex: 6407
{
	// Properties
	public string FileName { get; set; }
	public int LineNumber { get; set; }

	// Methods

	// RVA: 0x226F030 Offset: 0x226E230 VA: 0x18226F030
	public void .ctor() { }

	// RVA: 0x226F000 Offset: 0x226E200 VA: 0x18226F000
	public void .ctor(string fileName, int lineNumber) { }

	// RVA: 0x226F060 Offset: 0x226E260 VA: 0x18226F060
	public string get_FileName() { }

	// RVA: 0x226F0C0 Offset: 0x226E2C0 VA: 0x18226F0C0
	public void set_FileName(string value) { }

	// RVA: 0x226F090 Offset: 0x226E290 VA: 0x18226F090
	public int get_LineNumber() { }

	// RVA: 0x226F0F0 Offset: 0x226E2F0 VA: 0x18226F0F0
	public void set_LineNumber(int value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeComment : CodeObject // TypeDefIndex: 6408
{
	// Properties
	public bool DocComment { get; set; }
	public string Text { get; set; }

	// Methods

	// RVA: 0x226C3F0 Offset: 0x226B5F0 VA: 0x18226C3F0
	public void .ctor() { }

	// RVA: 0x226C3C0 Offset: 0x226B5C0 VA: 0x18226C3C0
	public void .ctor(string text) { }

	// RVA: 0x226C420 Offset: 0x226B620 VA: 0x18226C420
	public void .ctor(string text, bool docComment) { }

	// RVA: 0x226C450 Offset: 0x226B650 VA: 0x18226C450
	public bool get_DocComment() { }

	// RVA: 0x226C4B0 Offset: 0x226B6B0 VA: 0x18226C4B0
	public void set_DocComment(bool value) { }

	// RVA: 0x226C480 Offset: 0x226B680 VA: 0x18226C480
	public string get_Text() { }

	// RVA: 0x226C4E0 Offset: 0x226B6E0 VA: 0x18226C4E0
	public void set_Text(string value) { }
}

// Namespace: System.CodeDom
[DefaultMember("Item")]
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeNamespaceImportCollection : ICollection, IEnumerable, IList // TypeDefIndex: 6409
{
	// Properties
	public int Count { get; }
	public CodeNamespaceImport Item { get; set; }

	// Methods

	// RVA: 0x22702C0 Offset: 0x226F4C0 VA: 0x1822702C0
	public void .ctor() { }

	// RVA: 0x22702F0 Offset: 0x226F4F0 VA: 0x1822702F0
	public int get_Count() { }

	// RVA: 0x2270320 Offset: 0x226F520 VA: 0x182270320
	public CodeNamespaceImport get_Item(int index) { }

	// RVA: 0x2270350 Offset: 0x226F550 VA: 0x182270350
	public void set_Item(int index, CodeNamespaceImport value) { }

	// RVA: 0x226FFF0 Offset: 0x226F1F0 VA: 0x18226FFF0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x2270020 Offset: 0x226F220 VA: 0x182270020 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2270050 Offset: 0x226F250 VA: 0x182270050 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2270200 Offset: 0x226F400 VA: 0x182270200 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x2270230 Offset: 0x226F430 VA: 0x182270230 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x2270260 Offset: 0x226F460 VA: 0x182270260 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x2270290 Offset: 0x226F490 VA: 0x182270290 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x226FF30 Offset: 0x226F130 VA: 0x18226FF30
	public void Add(CodeNamespaceImport value) { }

	// RVA: 0x226FF00 Offset: 0x226F100 VA: 0x18226FF00
	public void AddRange(CodeNamespaceImport[] value) { }

	// RVA: 0x226FF60 Offset: 0x226F160 VA: 0x18226FF60
	public void Clear() { }

	// RVA: 0x226FF90 Offset: 0x226F190 VA: 0x18226FF90
	public IEnumerator GetEnumerator() { }

	// RVA: 0x226FFC0 Offset: 0x226F1C0 VA: 0x18226FFC0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2270080 Offset: 0x226F280 VA: 0x182270080 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x22700B0 Offset: 0x226F2B0 VA: 0x1822700B0 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x22700E0 Offset: 0x226F2E0 VA: 0x1822700E0 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x2270110 Offset: 0x226F310 VA: 0x182270110 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x2270140 Offset: 0x226F340 VA: 0x182270140 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x2270170 Offset: 0x226F370 VA: 0x182270170 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x22701D0 Offset: 0x226F3D0 VA: 0x1822701D0 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x22701A0 Offset: 0x226F3A0 VA: 0x1822701A0 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeNamespaceImport : CodeObject // TypeDefIndex: 6410
{
	// Properties
	public CodeLinePragma LinePragma { get; set; }
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x2270380 Offset: 0x226F580 VA: 0x182270380
	public void .ctor() { }

	// RVA: 0x22703B0 Offset: 0x226F5B0 VA: 0x1822703B0
	public void .ctor(string nameSpace) { }

	// RVA: 0x22703E0 Offset: 0x226F5E0 VA: 0x1822703E0
	public CodeLinePragma get_LinePragma() { }

	// RVA: 0x2270440 Offset: 0x226F640 VA: 0x182270440
	public void set_LinePragma(CodeLinePragma value) { }

	// RVA: 0x2270410 Offset: 0x226F610 VA: 0x182270410
	public string get_Namespace() { }

	// RVA: 0x2270470 Offset: 0x226F670 VA: 0x182270470
	public void set_Namespace(string value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[DefaultMember("Item")]
[Serializable]
public class CodeTypeDeclarationCollection : CollectionBase // TypeDefIndex: 6411
{
	// Properties
	public CodeTypeDeclaration Item { get; set; }

	// Methods

	// RVA: 0x2271D00 Offset: 0x2270F00 VA: 0x182271D00
	public void .ctor() { }

	// RVA: 0x2271D30 Offset: 0x2270F30 VA: 0x182271D30
	public void .ctor(CodeTypeDeclarationCollection value) { }

	// RVA: 0x2271CD0 Offset: 0x2270ED0 VA: 0x182271CD0
	public void .ctor(CodeTypeDeclaration[] value) { }

	// RVA: 0x2271D60 Offset: 0x2270F60 VA: 0x182271D60
	public CodeTypeDeclaration get_Item(int index) { }

	// RVA: 0x2271D90 Offset: 0x2270F90 VA: 0x182271D90
	public void set_Item(int index, CodeTypeDeclaration value) { }

	// RVA: 0x2271BB0 Offset: 0x2270DB0 VA: 0x182271BB0
	public int Add(CodeTypeDeclaration value) { }

	// RVA: 0x2271B50 Offset: 0x2270D50 VA: 0x182271B50
	public void AddRange(CodeTypeDeclarationCollection value) { }

	// RVA: 0x2271B80 Offset: 0x2270D80 VA: 0x182271B80
	public void AddRange(CodeTypeDeclaration[] value) { }

	// RVA: 0x2271BE0 Offset: 0x2270DE0 VA: 0x182271BE0
	public bool Contains(CodeTypeDeclaration value) { }

	// RVA: 0x2271C10 Offset: 0x2270E10 VA: 0x182271C10
	public void CopyTo(CodeTypeDeclaration[] array, int index) { }

	// RVA: 0x2271C40 Offset: 0x2270E40 VA: 0x182271C40
	public int IndexOf(CodeTypeDeclaration value) { }

	// RVA: 0x2271C70 Offset: 0x2270E70 VA: 0x182271C70
	public void Insert(int index, CodeTypeDeclaration value) { }

	// RVA: 0x2271CA0 Offset: 0x2270EA0 VA: 0x182271CA0
	public void Remove(CodeTypeDeclaration value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeTypeReference : CodeObject // TypeDefIndex: 6412
{
	// Properties
	public CodeTypeReference ArrayElementType { get; set; }
	public int ArrayRank { get; set; }
	public string BaseType { get; set; }
	public CodeTypeReferenceOptions Options { get; set; }
	public CodeTypeReferenceCollection TypeArguments { get; }

	// Methods

	// RVA: 0x2272C90 Offset: 0x2271E90 VA: 0x182272C90
	public void .ctor() { }

	// RVA: 0x2272D50 Offset: 0x2271F50 VA: 0x182272D50
	public void .ctor(CodeTypeParameter typeParameter) { }

	// RVA: 0x2272E10 Offset: 0x2272010 VA: 0x182272E10
	public void .ctor(CodeTypeReference arrayType, int rank) { }

	// RVA: 0x2272D20 Offset: 0x2271F20 VA: 0x182272D20
	public void .ctor(string typeName) { }

	// RVA: 0x2272D80 Offset: 0x2271F80 VA: 0x182272D80
	public void .ctor(string typeName, CodeTypeReferenceOptions codeTypeReferenceOption) { }

	// RVA: 0x2272CF0 Offset: 0x2271EF0 VA: 0x182272CF0
	public void .ctor(string typeName, CodeTypeReference[] typeArguments) { }

	// RVA: 0x2272CC0 Offset: 0x2271EC0 VA: 0x182272CC0
	public void .ctor(string baseType, int rank) { }

	// RVA: 0x2272DB0 Offset: 0x2271FB0 VA: 0x182272DB0
	public void .ctor(Type type) { }

	// RVA: 0x2272DE0 Offset: 0x2271FE0 VA: 0x182272DE0
	public void .ctor(Type type, CodeTypeReferenceOptions codeTypeReferenceOption) { }

	// RVA: 0x2272E40 Offset: 0x2272040 VA: 0x182272E40
	public CodeTypeReference get_ArrayElementType() { }

	// RVA: 0x2272F30 Offset: 0x2272130 VA: 0x182272F30
	public void set_ArrayElementType(CodeTypeReference value) { }

	// RVA: 0x2272E70 Offset: 0x2272070 VA: 0x182272E70
	public int get_ArrayRank() { }

	// RVA: 0x2272F60 Offset: 0x2272160 VA: 0x182272F60
	public void set_ArrayRank(int value) { }

	// RVA: 0x2272EA0 Offset: 0x22720A0 VA: 0x182272EA0
	public string get_BaseType() { }

	// RVA: 0x2272F90 Offset: 0x2272190 VA: 0x182272F90
	public void set_BaseType(string value) { }

	// RVA: 0x2272ED0 Offset: 0x22720D0 VA: 0x182272ED0
	public CodeTypeReferenceOptions get_Options() { }

	// RVA: 0x2272FC0 Offset: 0x22721C0 VA: 0x182272FC0
	public void set_Options(CodeTypeReferenceOptions value) { }

	// RVA: 0x2272F00 Offset: 0x2272100 VA: 0x182272F00
	public CodeTypeReferenceCollection get_TypeArguments() { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeTypeParameter : CodeObject // TypeDefIndex: 6413
{
	// Properties
	public CodeTypeReferenceCollection Constraints { get; }
	public CodeAttributeDeclarationCollection CustomAttributes { get; }
	public bool HasConstructorConstraint { get; set; }
	public string Name { get; set; }

	// Methods

	// RVA: 0x2272720 Offset: 0x2271920 VA: 0x182272720
	public void .ctor() { }

	// RVA: 0x2272750 Offset: 0x2271950 VA: 0x182272750
	public void .ctor(string name) { }

	// RVA: 0x2272780 Offset: 0x2271980 VA: 0x182272780
	public CodeTypeReferenceCollection get_Constraints() { }

	// RVA: 0x22727B0 Offset: 0x22719B0 VA: 0x1822727B0
	public CodeAttributeDeclarationCollection get_CustomAttributes() { }

	// RVA: 0x22727E0 Offset: 0x22719E0 VA: 0x1822727E0
	public bool get_HasConstructorConstraint() { }

	// RVA: 0x2272840 Offset: 0x2271A40 VA: 0x182272840
	public void set_HasConstructorConstraint(bool value) { }

	// RVA: 0x2272810 Offset: 0x2271A10 VA: 0x182272810
	public string get_Name() { }

	// RVA: 0x2272870 Offset: 0x2271A70 VA: 0x182272870
	public void set_Name(string value) { }
}

// Namespace: System.CodeDom
[DefaultMember("Item")]
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeTypeReferenceCollection : CollectionBase // TypeDefIndex: 6414
{
	// Properties
	public CodeTypeReference Item { get; set; }

	// Methods

	// RVA: 0x2272A80 Offset: 0x2271C80 VA: 0x182272A80
	public void .ctor() { }

	// RVA: 0x2272AE0 Offset: 0x2271CE0 VA: 0x182272AE0
	public void .ctor(CodeTypeReferenceCollection value) { }

	// RVA: 0x2272AB0 Offset: 0x2271CB0 VA: 0x182272AB0
	public void .ctor(CodeTypeReference[] value) { }

	// RVA: 0x2272B10 Offset: 0x2271D10 VA: 0x182272B10
	public CodeTypeReference get_Item(int index) { }

	// RVA: 0x2272B40 Offset: 0x2271D40 VA: 0x182272B40
	public void set_Item(int index, CodeTypeReference value) { }

	// RVA: 0x2272930 Offset: 0x2271B30 VA: 0x182272930
	public int Add(CodeTypeReference value) { }

	// RVA: 0x2272900 Offset: 0x2271B00 VA: 0x182272900
	public void Add(string value) { }

	// RVA: 0x2272960 Offset: 0x2271B60 VA: 0x182272960
	public void Add(Type value) { }

	// RVA: 0x22728D0 Offset: 0x2271AD0 VA: 0x1822728D0
	public void AddRange(CodeTypeReferenceCollection value) { }

	// RVA: 0x22728A0 Offset: 0x2271AA0 VA: 0x1822728A0
	public void AddRange(CodeTypeReference[] value) { }

	// RVA: 0x2272990 Offset: 0x2271B90 VA: 0x182272990
	public bool Contains(CodeTypeReference value) { }

	// RVA: 0x22729C0 Offset: 0x2271BC0 VA: 0x1822729C0
	public void CopyTo(CodeTypeReference[] array, int index) { }

	// RVA: 0x22729F0 Offset: 0x2271BF0 VA: 0x1822729F0
	public int IndexOf(CodeTypeReference value) { }

	// RVA: 0x2272A20 Offset: 0x2271C20 VA: 0x182272A20
	public void Insert(int index, CodeTypeReference value) { }

	// RVA: 0x2272A50 Offset: 0x2271C50 VA: 0x182272A50
	public void Remove(CodeTypeReference value) { }
}

// Namespace: System.CodeDom
[DefaultMember("Item")]
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeAttributeDeclarationCollection : CollectionBase // TypeDefIndex: 6415
{
	// Properties
	public CodeAttributeDeclaration Item { get; set; }

	// Methods

	// RVA: 0x226B510 Offset: 0x226A710 VA: 0x18226B510
	public void .ctor() { }

	// RVA: 0x226B4B0 Offset: 0x226A6B0 VA: 0x18226B4B0
	public void .ctor(CodeAttributeDeclarationCollection value) { }

	// RVA: 0x226B4E0 Offset: 0x226A6E0 VA: 0x18226B4E0
	public void .ctor(CodeAttributeDeclaration[] value) { }

	// RVA: 0x226B540 Offset: 0x226A740 VA: 0x18226B540
	public CodeAttributeDeclaration get_Item(int index) { }

	// RVA: 0x226B570 Offset: 0x226A770 VA: 0x18226B570
	public void set_Item(int index, CodeAttributeDeclaration value) { }

	// RVA: 0x226B390 Offset: 0x226A590 VA: 0x18226B390
	public int Add(CodeAttributeDeclaration value) { }

	// RVA: 0x226B330 Offset: 0x226A530 VA: 0x18226B330
	public void AddRange(CodeAttributeDeclarationCollection value) { }

	// RVA: 0x226B360 Offset: 0x226A560 VA: 0x18226B360
	public void AddRange(CodeAttributeDeclaration[] value) { }

	// RVA: 0x226B3C0 Offset: 0x226A5C0 VA: 0x18226B3C0
	public bool Contains(CodeAttributeDeclaration value) { }

	// RVA: 0x226B3F0 Offset: 0x226A5F0 VA: 0x18226B3F0
	public void CopyTo(CodeAttributeDeclaration[] array, int index) { }

	// RVA: 0x226B420 Offset: 0x226A620 VA: 0x18226B420
	public int IndexOf(CodeAttributeDeclaration value) { }

	// RVA: 0x226B450 Offset: 0x226A650 VA: 0x18226B450
	public void Insert(int index, CodeAttributeDeclaration value) { }

	// RVA: 0x226B480 Offset: 0x226A680 VA: 0x18226B480
	public void Remove(CodeAttributeDeclaration value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeAttributeDeclaration // TypeDefIndex: 6416
{
	// Properties
	public CodeAttributeArgumentCollection Arguments { get; }
	public CodeTypeReference AttributeType { get; }
	public string Name { get; set; }

	// Methods

	// RVA: 0x226B600 Offset: 0x226A800 VA: 0x18226B600
	public void .ctor() { }

	// RVA: 0x226B660 Offset: 0x226A860 VA: 0x18226B660
	public void .ctor(CodeTypeReference attributeType) { }

	// RVA: 0x226B5A0 Offset: 0x226A7A0 VA: 0x18226B5A0
	public void .ctor(CodeTypeReference attributeType, CodeAttributeArgument[] arguments) { }

	// RVA: 0x226B630 Offset: 0x226A830 VA: 0x18226B630
	public void .ctor(string name) { }

	// RVA: 0x226B5D0 Offset: 0x226A7D0 VA: 0x18226B5D0
	public void .ctor(string name, CodeAttributeArgument[] arguments) { }

	// RVA: 0x226B690 Offset: 0x226A890 VA: 0x18226B690
	public CodeAttributeArgumentCollection get_Arguments() { }

	// RVA: 0x226B6C0 Offset: 0x226A8C0 VA: 0x18226B6C0
	public CodeTypeReference get_AttributeType() { }

	// RVA: 0x226B6F0 Offset: 0x226A8F0 VA: 0x18226B6F0
	public string get_Name() { }

	// RVA: 0x226B720 Offset: 0x226A920 VA: 0x18226B720
	public void set_Name(string value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeAttributeArgument // TypeDefIndex: 6417
{
	// Properties
	public string Name { get; set; }
	public CodeExpression Value { get; set; }

	// Methods

	// RVA: 0x226B1E0 Offset: 0x226A3E0 VA: 0x18226B1E0
	public void .ctor() { }

	// RVA: 0x226B210 Offset: 0x226A410 VA: 0x18226B210
	public void .ctor(CodeExpression value) { }

	// RVA: 0x226B240 Offset: 0x226A440 VA: 0x18226B240
	public void .ctor(string name, CodeExpression value) { }

	// RVA: 0x226B270 Offset: 0x226A470 VA: 0x18226B270
	public string get_Name() { }

	// RVA: 0x226B2D0 Offset: 0x226A4D0 VA: 0x18226B2D0
	public void set_Name(string value) { }

	// RVA: 0x226B2A0 Offset: 0x226A4A0 VA: 0x18226B2A0
	public CodeExpression get_Value() { }

	// RVA: 0x226B300 Offset: 0x226A500 VA: 0x18226B300
	public void set_Value(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[DefaultMember("Item")]
[ClassInterface(1)]
[Serializable]
public class CodeAttributeArgumentCollection : CollectionBase // TypeDefIndex: 6418
{
	// Properties
	public CodeAttributeArgument Item { get; set; }

	// Methods

	// RVA: 0x226B0F0 Offset: 0x226A2F0 VA: 0x18226B0F0
	public void .ctor() { }

	// RVA: 0x226B150 Offset: 0x226A350 VA: 0x18226B150
	public void .ctor(CodeAttributeArgumentCollection value) { }

	// RVA: 0x226B120 Offset: 0x226A320 VA: 0x18226B120
	public void .ctor(CodeAttributeArgument[] value) { }

	// RVA: 0x226B180 Offset: 0x226A380 VA: 0x18226B180
	public CodeAttributeArgument get_Item(int index) { }

	// RVA: 0x226B1B0 Offset: 0x226A3B0 VA: 0x18226B1B0
	public void set_Item(int index, CodeAttributeArgument value) { }

	// RVA: 0x226AFD0 Offset: 0x226A1D0 VA: 0x18226AFD0
	public int Add(CodeAttributeArgument value) { }

	// RVA: 0x226AFA0 Offset: 0x226A1A0 VA: 0x18226AFA0
	public void AddRange(CodeAttributeArgumentCollection value) { }

	// RVA: 0x226AF70 Offset: 0x226A170 VA: 0x18226AF70
	public void AddRange(CodeAttributeArgument[] value) { }

	// RVA: 0x226B000 Offset: 0x226A200 VA: 0x18226B000
	public bool Contains(CodeAttributeArgument value) { }

	// RVA: 0x226B030 Offset: 0x226A230 VA: 0x18226B030
	public void CopyTo(CodeAttributeArgument[] array, int index) { }

	// RVA: 0x226B060 Offset: 0x226A260 VA: 0x18226B060
	public int IndexOf(CodeAttributeArgument value) { }

	// RVA: 0x226B090 Offset: 0x226A290 VA: 0x18226B090
	public void Insert(int index, CodeAttributeArgument value) { }

	// RVA: 0x226B0C0 Offset: 0x226A2C0 VA: 0x18226B0C0
	public void Remove(CodeAttributeArgument value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[Flags]
[Serializable]
public enum CodeTypeReferenceOptions // TypeDefIndex: 6419
{
	// Fields
	public int value__; // 0x0
	public const CodeTypeReferenceOptions GenericTypeParameter = 2;
	public const CodeTypeReferenceOptions GlobalReference = 1;
}

// Namespace: System.CodeDom.Compiler
[Flags]
[Serializable]
public enum GeneratorSupport // TypeDefIndex: 6420
{
	// Fields
	public int value__; // 0x0
	public const GeneratorSupport ArraysOfArrays = 1;
	public const GeneratorSupport AssemblyAttributes = 4096;
	public const GeneratorSupport ChainedConstructorArguments = 32768;
	public const GeneratorSupport ComplexExpressions = 524288;
	public const GeneratorSupport DeclareDelegates = 512;
	public const GeneratorSupport DeclareEnums = 256;
	public const GeneratorSupport DeclareEvents = 2048;
	public const GeneratorSupport DeclareIndexerProperties = 33554432;
	public const GeneratorSupport DeclareInterfaces = 1024;
	public const GeneratorSupport DeclareValueTypes = 128;
	public const GeneratorSupport EntryPointMethod = 2;
	public const GeneratorSupport GenericTypeDeclaration = 16777216;
	public const GeneratorSupport GenericTypeReference = 8388608;
	public const GeneratorSupport GotoStatements = 4;
	public const GeneratorSupport MultidimensionalArrays = 8;
	public const GeneratorSupport MultipleInterfaceMembers = 131072;
	public const GeneratorSupport NestedTypes = 65536;
	public const GeneratorSupport ParameterAttributes = 8192;
	public const GeneratorSupport PartialTypes = 4194304;
	public const GeneratorSupport PublicStaticMembers = 262144;
	public const GeneratorSupport ReferenceParameters = 16384;
	public const GeneratorSupport Resources = 2097152;
	public const GeneratorSupport ReturnTypeAttributes = 64;
	public const GeneratorSupport StaticConstructors = 16;
	public const GeneratorSupport TryCatchStatements = 32;
	public const GeneratorSupport Win32Resources = 1048576;
}

// Namespace: System.CodeDom.Compiler
public interface ICodeParser // TypeDefIndex: 6421
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CodeCompileUnit Parse(TextReader codeStream);
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeTypeMember : CodeObject // TypeDefIndex: 6422
{
	// Properties
	public MemberAttributes Attributes { get; set; }
	public CodeCommentStatementCollection Comments { get; }
	public CodeAttributeDeclarationCollection CustomAttributes { get; set; }
	public CodeDirectiveCollection EndDirectives { get; }
	public CodeLinePragma LinePragma { get; set; }
	public string Name { get; set; }
	public CodeDirectiveCollection StartDirectives { get; }

	// Methods

	// RVA: 0x2272120 Offset: 0x2271320 VA: 0x182272120
	public void .ctor() { }

	// RVA: 0x2272150 Offset: 0x2271350 VA: 0x182272150
	public MemberAttributes get_Attributes() { }

	// RVA: 0x22722A0 Offset: 0x22714A0 VA: 0x1822722A0
	public void set_Attributes(MemberAttributes value) { }

	// RVA: 0x2272180 Offset: 0x2271380 VA: 0x182272180
	public CodeCommentStatementCollection get_Comments() { }

	// RVA: 0x22721B0 Offset: 0x22713B0 VA: 0x1822721B0
	public CodeAttributeDeclarationCollection get_CustomAttributes() { }

	// RVA: 0x22722D0 Offset: 0x22714D0 VA: 0x1822722D0
	public void set_CustomAttributes(CodeAttributeDeclarationCollection value) { }

	// RVA: 0x22721E0 Offset: 0x22713E0 VA: 0x1822721E0
	public CodeDirectiveCollection get_EndDirectives() { }

	// RVA: 0x2272210 Offset: 0x2271410 VA: 0x182272210
	public CodeLinePragma get_LinePragma() { }

	// RVA: 0x2272300 Offset: 0x2271500 VA: 0x182272300
	public void set_LinePragma(CodeLinePragma value) { }

	// RVA: 0x2272240 Offset: 0x2271440 VA: 0x182272240
	public string get_Name() { }

	// RVA: 0x2272330 Offset: 0x2271530 VA: 0x182272330
	public void set_Name(string value) { }

	// RVA: 0x2272270 Offset: 0x2271470 VA: 0x182272270
	public CodeDirectiveCollection get_StartDirectives() { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[Serializable]
public enum MemberAttributes // TypeDefIndex: 6423
{
	// Fields
	public int value__; // 0x0
	public const MemberAttributes Abstract = 1;
	public const MemberAttributes AccessMask = 61440;
	public const MemberAttributes Assembly = 4096;
	public const MemberAttributes Const = 5;
	public const MemberAttributes Family = 12288;
	public const MemberAttributes FamilyAndAssembly = 8192;
	public const MemberAttributes FamilyOrAssembly = 16384;
	public const MemberAttributes Final = 2;
	public const MemberAttributes New = 16;
	public const MemberAttributes Overloaded = 256;
	public const MemberAttributes Override = 4;
	public const MemberAttributes Private = 20480;
	public const MemberAttributes Public = 24576;
	public const MemberAttributes ScopeMask = 15;
	public const MemberAttributes Static = 3;
	public const MemberAttributes VTableMask = 240;
}

// Namespace: System.CodeDom.Compiler
public sealed class CompilerInfo // TypeDefIndex: 6424
{
	// Properties
	public Type CodeDomProviderType { get; }
	public bool IsCodeDomProviderTypeValid { get; }

	// Methods

	// RVA: 0x2273980 Offset: 0x2272B80 VA: 0x182273980
	internal void .ctor() { }

	// RVA: 0x22739B0 Offset: 0x2272BB0 VA: 0x1822739B0
	public Type get_CodeDomProviderType() { }

	// RVA: 0x22739E0 Offset: 0x2272BE0 VA: 0x1822739E0
	public bool get_IsCodeDomProviderTypeValid() { }

	// RVA: 0x2273890 Offset: 0x2272A90 VA: 0x182273890
	public CompilerParameters CreateDefaultCompilerParameters() { }

	// RVA: 0x22738C0 Offset: 0x2272AC0 VA: 0x1822738C0
	public CodeDomProvider CreateProvider() { }

	// RVA: 0x22738F0 Offset: 0x2272AF0 VA: 0x1822738F0
	public CodeDomProvider CreateProvider(IDictionary<string, string> providerOptions) { }

	// RVA: 0x2273920 Offset: 0x2272B20 VA: 0x182273920
	public string[] GetExtensions() { }

	// RVA: 0x2273950 Offset: 0x2272B50 VA: 0x182273950
	public string[] GetLanguages() { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[DefaultMember("Item")]
[ClassInterface(1)]
[Serializable]
public class CodeNamespaceCollection : CollectionBase // TypeDefIndex: 6425
{
	// Properties
	public CodeNamespace Item { get; set; }

	// Methods

	// RVA: 0x226FE10 Offset: 0x226F010 VA: 0x18226FE10
	public void .ctor() { }

	// RVA: 0x226FE70 Offset: 0x226F070 VA: 0x18226FE70
	public void .ctor(CodeNamespaceCollection value) { }

	// RVA: 0x226FE40 Offset: 0x226F040 VA: 0x18226FE40
	public void .ctor(CodeNamespace[] value) { }

	// RVA: 0x226FEA0 Offset: 0x226F0A0 VA: 0x18226FEA0
	public CodeNamespace get_Item(int index) { }

	// RVA: 0x226FED0 Offset: 0x226F0D0 VA: 0x18226FED0
	public void set_Item(int index, CodeNamespace value) { }

	// RVA: 0x226FCF0 Offset: 0x226EEF0 VA: 0x18226FCF0
	public int Add(CodeNamespace value) { }

	// RVA: 0x226FC90 Offset: 0x226EE90 VA: 0x18226FC90
	public void AddRange(CodeNamespaceCollection value) { }

	// RVA: 0x226FCC0 Offset: 0x226EEC0 VA: 0x18226FCC0
	public void AddRange(CodeNamespace[] value) { }

	// RVA: 0x226FD20 Offset: 0x226EF20 VA: 0x18226FD20
	public bool Contains(CodeNamespace value) { }

	// RVA: 0x226FD50 Offset: 0x226EF50 VA: 0x18226FD50
	public void CopyTo(CodeNamespace[] array, int index) { }

	// RVA: 0x226FD80 Offset: 0x226EF80 VA: 0x18226FD80
	public int IndexOf(CodeNamespace value) { }

	// RVA: 0x226FDB0 Offset: 0x226EFB0 VA: 0x18226FDB0
	public void Insert(int index, CodeNamespace value) { }

	// RVA: 0x226FDE0 Offset: 0x226EFE0 VA: 0x18226FDE0
	public void Remove(CodeNamespace value) { }
}

// Namespace: System.CodeDom
[DefaultMember("Item")]
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeTypeMemberCollection : CollectionBase // TypeDefIndex: 6426
{
	// Properties
	public CodeTypeMember Item { get; set; }

	// Methods

	// RVA: 0x2272090 Offset: 0x2271290 VA: 0x182272090
	public void .ctor() { }

	// RVA: 0x2272060 Offset: 0x2271260 VA: 0x182272060
	public void .ctor(CodeTypeMemberCollection value) { }

	// RVA: 0x2272030 Offset: 0x2271230 VA: 0x182272030
	public void .ctor(CodeTypeMember[] value) { }

	// RVA: 0x22720C0 Offset: 0x22712C0 VA: 0x1822720C0
	public CodeTypeMember get_Item(int index) { }

	// RVA: 0x22720F0 Offset: 0x22712F0 VA: 0x1822720F0
	public void set_Item(int index, CodeTypeMember value) { }

	// RVA: 0x2271F10 Offset: 0x2271110 VA: 0x182271F10
	public int Add(CodeTypeMember value) { }

	// RVA: 0x2271EE0 Offset: 0x22710E0 VA: 0x182271EE0
	public void AddRange(CodeTypeMemberCollection value) { }

	// RVA: 0x2271EB0 Offset: 0x22710B0 VA: 0x182271EB0
	public void AddRange(CodeTypeMember[] value) { }

	// RVA: 0x2271F40 Offset: 0x2271140 VA: 0x182271F40
	public bool Contains(CodeTypeMember value) { }

	// RVA: 0x2271F70 Offset: 0x2271170 VA: 0x182271F70
	public void CopyTo(CodeTypeMember[] array, int index) { }

	// RVA: 0x2271FA0 Offset: 0x22711A0 VA: 0x182271FA0
	public int IndexOf(CodeTypeMember value) { }

	// RVA: 0x2271FD0 Offset: 0x22711D0 VA: 0x182271FD0
	public void Insert(int index, CodeTypeMember value) { }

	// RVA: 0x2272000 Offset: 0x2271200 VA: 0x182272000
	public void Remove(CodeTypeMember value) { }
}

// Namespace: System.CodeDom
[DefaultMember("Item")]
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeTypeParameterCollection : CollectionBase // TypeDefIndex: 6427
{
	// Properties
	public CodeTypeParameter Item { get; set; }

	// Methods

	// RVA: 0x2272660 Offset: 0x2271860 VA: 0x182272660
	public void .ctor() { }

	// RVA: 0x2272690 Offset: 0x2271890 VA: 0x182272690
	public void .ctor(CodeTypeParameterCollection value) { }

	// RVA: 0x2272630 Offset: 0x2271830 VA: 0x182272630
	public void .ctor(CodeTypeParameter[] value) { }

	// RVA: 0x22726C0 Offset: 0x22718C0 VA: 0x1822726C0
	public CodeTypeParameter get_Item(int index) { }

	// RVA: 0x22726F0 Offset: 0x22718F0 VA: 0x1822726F0
	public void set_Item(int index, CodeTypeParameter value) { }

	// RVA: 0x22724E0 Offset: 0x22716E0 VA: 0x1822724E0
	public int Add(CodeTypeParameter value) { }

	// RVA: 0x2272510 Offset: 0x2271710 VA: 0x182272510
	public void Add(string value) { }

	// RVA: 0x22724B0 Offset: 0x22716B0 VA: 0x1822724B0
	public void AddRange(CodeTypeParameterCollection value) { }

	// RVA: 0x2272480 Offset: 0x2271680 VA: 0x182272480
	public void AddRange(CodeTypeParameter[] value) { }

	// RVA: 0x2272540 Offset: 0x2271740 VA: 0x182272540
	public bool Contains(CodeTypeParameter value) { }

	// RVA: 0x2272570 Offset: 0x2271770 VA: 0x182272570
	public void CopyTo(CodeTypeParameter[] array, int index) { }

	// RVA: 0x22725A0 Offset: 0x22717A0 VA: 0x1822725A0
	public int IndexOf(CodeTypeParameter value) { }

	// RVA: 0x22725D0 Offset: 0x22717D0 VA: 0x1822725D0
	public void Insert(int index, CodeTypeParameter value) { }

	// RVA: 0x2272600 Offset: 0x2271800 VA: 0x182272600
	public void Remove(CodeTypeParameter value) { }
}

// Namespace: System.Diagnostics
public enum PerformanceCounterCategoryType // TypeDefIndex: 6428
{
	// Fields
	public int value__; // 0x0
	public const PerformanceCounterCategoryType MultiInstance = 1;
	public const PerformanceCounterCategoryType SingleInstance = 0;
	public const PerformanceCounterCategoryType Unknown = -1;
}

// Namespace: System.Diagnostics
[DefaultMember("Item")]
[Serializable]
public class CounterCreationDataCollection : CollectionBase // TypeDefIndex: 6429
{
	// Properties
	public CounterCreationData Item { get; set; }

	// Methods

	// RVA: 0x2274D60 Offset: 0x2273F60 VA: 0x182274D60
	public void .ctor() { }

	// RVA: 0x2274D00 Offset: 0x2273F00 VA: 0x182274D00
	public void .ctor(CounterCreationDataCollection value) { }

	// RVA: 0x2274D30 Offset: 0x2273F30 VA: 0x182274D30
	public void .ctor(CounterCreationData[] value) { }

	// RVA: 0x2274D90 Offset: 0x2273F90 VA: 0x182274D90
	public CounterCreationData get_Item(int index) { }

	// RVA: 0x2274DC0 Offset: 0x2273FC0 VA: 0x182274DC0
	public void set_Item(int index, CounterCreationData value) { }

	// RVA: 0x2274BE0 Offset: 0x2273DE0 VA: 0x182274BE0
	public int Add(CounterCreationData value) { }

	// RVA: 0x2274BB0 Offset: 0x2273DB0 VA: 0x182274BB0
	public void AddRange(CounterCreationDataCollection value) { }

	// RVA: 0x2274B80 Offset: 0x2273D80 VA: 0x182274B80
	public void AddRange(CounterCreationData[] value) { }

	// RVA: 0x2274C10 Offset: 0x2273E10 VA: 0x182274C10
	public bool Contains(CounterCreationData value) { }

	// RVA: 0x2274C40 Offset: 0x2273E40 VA: 0x182274C40
	public void CopyTo(CounterCreationData[] array, int index) { }

	// RVA: 0x2274C70 Offset: 0x2273E70 VA: 0x182274C70
	public int IndexOf(CounterCreationData value) { }

	// RVA: 0x2274CA0 Offset: 0x2273EA0 VA: 0x182274CA0
	public void Insert(int index, CounterCreationData value) { }

	// RVA: 0x2274CD0 Offset: 0x2273ED0 VA: 0x182274CD0 Slot: 29
	public virtual void Remove(CounterCreationData value) { }
}

// Namespace: System.Diagnostics
[TypeConverter("System.Diagnostics.Design.CounterCreationDataConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[Serializable]
public class CounterCreationData // TypeDefIndex: 6430
{
	// Properties
	public string CounterHelp { get; set; }
	public string CounterName { get; set; }
	public PerformanceCounterType CounterType { get; set; }

	// Methods

	// RVA: 0x2274DF0 Offset: 0x2273FF0 VA: 0x182274DF0
	public void .ctor() { }

	// RVA: 0x2274E20 Offset: 0x2274020 VA: 0x182274E20
	public void .ctor(string counterName, string counterHelp, PerformanceCounterType counterType) { }

	// RVA: 0x2274E50 Offset: 0x2274050 VA: 0x182274E50
	public string get_CounterHelp() { }

	// RVA: 0x2274EE0 Offset: 0x22740E0 VA: 0x182274EE0
	public void set_CounterHelp(string value) { }

	// RVA: 0x2274E80 Offset: 0x2274080 VA: 0x182274E80
	public string get_CounterName() { }

	// RVA: 0x2274F10 Offset: 0x2274110 VA: 0x182274F10
	public void set_CounterName(string value) { }

	// RVA: 0x2274EB0 Offset: 0x22740B0 VA: 0x182274EB0
	public PerformanceCounterType get_CounterType() { }

	// RVA: 0x2274F40 Offset: 0x2274140 VA: 0x182274F40
	public void set_CounterType(PerformanceCounterType value) { }
}

// Namespace: System.Diagnostics
[TypeConverter("System.Diagnostics.AlphabeticalEnumConverter")]
public enum PerformanceCounterType // TypeDefIndex: 6431
{
	// Fields
	public int value__; // 0x0
	public const PerformanceCounterType AverageBase = 1073939458;
	public const PerformanceCounterType AverageCount64 = 1073874176;
	public const PerformanceCounterType AverageTimer32 = 805438464;
	public const PerformanceCounterType CounterDelta32 = 4195328;
	public const PerformanceCounterType CounterDelta64 = 4195584;
	public const PerformanceCounterType CounterMultiBase = 1107494144;
	public const PerformanceCounterType CounterMultiTimer = 574686464;
	public const PerformanceCounterType CounterMultiTimer100Ns = 575735040;
	public const PerformanceCounterType CounterMultiTimer100NsInverse = 592512256;
	public const PerformanceCounterType CounterMultiTimerInverse = 591463680;
	public const PerformanceCounterType CounterTimer = 541132032;
	public const PerformanceCounterType CounterTimerInverse = 557909248;
	public const PerformanceCounterType CountPerTimeInterval32 = 4523008;
	public const PerformanceCounterType CountPerTimeInterval64 = 4523264;
	public const PerformanceCounterType ElapsedTime = 807666944;
	public const PerformanceCounterType NumberOfItems32 = 65536;
	public const PerformanceCounterType NumberOfItems64 = 65792;
	public const PerformanceCounterType NumberOfItemsHEX32 = 0;
	public const PerformanceCounterType NumberOfItemsHEX64 = 256;
	public const PerformanceCounterType RateOfCountsPerSecond32 = 272696320;
	public const PerformanceCounterType RateOfCountsPerSecond64 = 272696576;
	public const PerformanceCounterType RawBase = 1073939459;
	public const PerformanceCounterType RawFraction = 537003008;
	public const PerformanceCounterType SampleBase = 1073939457;
	public const PerformanceCounterType SampleCounter = 4260864;
	public const PerformanceCounterType SampleFraction = 549585920;
	public const PerformanceCounterType Timer100Ns = 542180608;
	public const PerformanceCounterType Timer100NsInverse = 558957824;
}

// Namespace: System.Configuration
[Serializable]
public class ConfigurationException : SystemException // TypeDefIndex: 6432
{
	// Properties
	public virtual string BareMessage { get; }
	public virtual string Filename { get; }
	public virtual int Line { get; }

	// Methods

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	// RVA: 0x2274520 Offset: 0x2273720 VA: 0x182274520
	public void .ctor() { }

	// RVA: 0x2274430 Offset: 0x2273630 VA: 0x182274430
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	// RVA: 0x2274460 Offset: 0x2273660 VA: 0x182274460
	public void .ctor(string message) { }

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	// RVA: 0x2274550 Offset: 0x2273750 VA: 0x182274550
	public void .ctor(string message, Exception inner) { }

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	// RVA: 0x2274490 Offset: 0x2273690 VA: 0x182274490
	public void .ctor(string message, Exception inner, string filename, int line) { }

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	// RVA: 0x22744C0 Offset: 0x22736C0 VA: 0x1822744C0
	public void .ctor(string message, Exception inner, XmlNode node) { }

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	// RVA: 0x2274580 Offset: 0x2273780 VA: 0x182274580
	public void .ctor(string message, string filename, int line) { }

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	// RVA: 0x22744F0 Offset: 0x22736F0 VA: 0x1822744F0
	public void .ctor(string message, XmlNode node) { }

	// RVA: 0x22745B0 Offset: 0x22737B0 VA: 0x1822745B0 Slot: 18
	public virtual string get_BareMessage() { }

	// RVA: 0x22745E0 Offset: 0x22737E0 VA: 0x1822745E0 Slot: 19
	public virtual string get_Filename() { }

	// RVA: 0x2274610 Offset: 0x2273810 VA: 0x182274610 Slot: 20
	public virtual int get_Line() { }

	[Obsolete("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetFilename instead")]
	// RVA: 0x22743D0 Offset: 0x22735D0 VA: 0x1822743D0
	public static string GetXmlNodeFilename(XmlNode node) { }

	[Obsolete("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetLinenumber instead")]
	// RVA: 0x2274400 Offset: 0x2273600 VA: 0x182274400
	public static int GetXmlNodeLineNumber(XmlNode node) { }
}

// Namespace: System.Configuration
public interface IConfigurationSectionHandler // TypeDefIndex: 6433
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Create(object parent, object configContext, XmlNode section);
}

// Namespace: System.CodeDom
[ComVisible(True)]
[Serializable]
public enum FieldDirection // TypeDefIndex: 6434
{
	// Fields
	public int value__; // 0x0
	public const FieldDirection In = 0;
	public const FieldDirection Out = 1;
	public const FieldDirection Ref = 2;
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
public class StandardOleMarshalObject : MarshalByRefObject // TypeDefIndex: 6435
{
	// Methods

	// RVA: 0x2282A80 Offset: 0x2281C80 VA: 0x182282A80
	protected void .ctor() { }
}

// Namespace: System.CodeDom
[DefaultMember("Item")]
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeStatementCollection : CollectionBase // TypeDefIndex: 6436
{
	// Properties
	public CodeStatement Item { get; set; }

	// Methods

	// RVA: 0x2271760 Offset: 0x2270960 VA: 0x182271760
	public void .ctor() { }

	// RVA: 0x2271790 Offset: 0x2270990 VA: 0x182271790
	public void .ctor(CodeStatementCollection value) { }

	// RVA: 0x2271730 Offset: 0x2270930 VA: 0x182271730
	public void .ctor(CodeStatement[] value) { }

	// RVA: 0x22717C0 Offset: 0x22709C0 VA: 0x1822717C0
	public CodeStatement get_Item(int index) { }

	// RVA: 0x22717F0 Offset: 0x22709F0 VA: 0x1822717F0
	public void set_Item(int index, CodeStatement value) { }

	// RVA: 0x22715E0 Offset: 0x22707E0 VA: 0x1822715E0
	public int Add(CodeExpression value) { }

	// RVA: 0x2271610 Offset: 0x2270810 VA: 0x182271610
	public int Add(CodeStatement value) { }

	// RVA: 0x2271580 Offset: 0x2270780 VA: 0x182271580
	public void AddRange(CodeStatementCollection value) { }

	// RVA: 0x22715B0 Offset: 0x22707B0 VA: 0x1822715B0
	public void AddRange(CodeStatement[] value) { }

	// RVA: 0x2271640 Offset: 0x2270840 VA: 0x182271640
	public bool Contains(CodeStatement value) { }

	// RVA: 0x2271670 Offset: 0x2270870 VA: 0x182271670
	public void CopyTo(CodeStatement[] array, int index) { }

	// RVA: 0x22716A0 Offset: 0x22708A0 VA: 0x1822716A0
	public int IndexOf(CodeStatement value) { }

	// RVA: 0x22716D0 Offset: 0x22708D0 VA: 0x1822716D0
	public void Insert(int index, CodeStatement value) { }

	// RVA: 0x2271700 Offset: 0x2270900 VA: 0x182271700
	public void Remove(CodeStatement value) { }
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public abstract class SettingsBase // TypeDefIndex: 6437
{
	// Properties
	public virtual SettingsContext Context { get; }
	public bool IsSynchronized { get; }
	public virtual object Item { get; set; }
	public virtual SettingsPropertyCollection Properties { get; }
	public virtual SettingsPropertyValueCollection PropertyValues { get; }
	public virtual SettingsProviderCollection Providers { get; }

	// Methods

	// RVA: 0x227D9C0 Offset: 0x227CBC0 VA: 0x18227D9C0
	protected void .ctor() { }

	// RVA: 0x227D9F0 Offset: 0x227CBF0 VA: 0x18227D9F0 Slot: 4
	public virtual SettingsContext get_Context() { }

	// RVA: 0x227DA20 Offset: 0x227CC20 VA: 0x18227DA20
	public bool get_IsSynchronized() { }

	// RVA: 0x227DA50 Offset: 0x227CC50 VA: 0x18227DA50 Slot: 5
	public virtual object get_Item(string propertyName) { }

	// RVA: 0x227DB10 Offset: 0x227CD10 VA: 0x18227DB10 Slot: 6
	public virtual void set_Item(string propertyName, object value) { }

	// RVA: 0x227DA80 Offset: 0x227CC80 VA: 0x18227DA80 Slot: 7
	public virtual SettingsPropertyCollection get_Properties() { }

	// RVA: 0x227DAB0 Offset: 0x227CCB0 VA: 0x18227DAB0 Slot: 8
	public virtual SettingsPropertyValueCollection get_PropertyValues() { }

	// RVA: 0x227DAE0 Offset: 0x227CCE0 VA: 0x18227DAE0 Slot: 9
	public virtual SettingsProviderCollection get_Providers() { }

	// RVA: 0x227D930 Offset: 0x227CB30 VA: 0x18227D930
	public void Initialize(SettingsContext context, SettingsPropertyCollection properties, SettingsProviderCollection providers) { }

	// RVA: 0x227D960 Offset: 0x227CB60 VA: 0x18227D960 Slot: 10
	public virtual void Save() { }

	// RVA: 0x227D990 Offset: 0x227CB90 VA: 0x18227D990
	public static SettingsBase Synchronized(SettingsBase settingsBase) { }
}

// Namespace: System.Configuration
[Serializable]
public class SettingsContext : Hashtable // TypeDefIndex: 6438
{
	// Methods

	// RVA: 0x227DB40 Offset: 0x227CD40 VA: 0x18227DB40
	public void .ctor() { }
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public class SettingsPropertyCollection : ICollection, IEnumerable, ICloneable // TypeDefIndex: 6439
{
	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public SettingsProperty Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x227DFC0 Offset: 0x227D1C0 VA: 0x18227DFC0
	public void .ctor() { }

	// RVA: 0x227DFF0 Offset: 0x227D1F0 VA: 0x18227DFF0 Slot: 5
	public int get_Count() { }

	// RVA: 0x227E020 Offset: 0x227D220 VA: 0x18227E020 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x227E050 Offset: 0x227D250 VA: 0x18227E050
	public SettingsProperty get_Item(string name) { }

	// RVA: 0x227E080 Offset: 0x227D280 VA: 0x18227E080 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x227DD50 Offset: 0x227CF50 VA: 0x18227DD50
	public void Add(SettingsProperty property) { }

	// RVA: 0x227DD80 Offset: 0x227CF80 VA: 0x18227DD80
	public void Clear() { }

	// RVA: 0x227DDB0 Offset: 0x227CFB0 VA: 0x18227DDB0 Slot: 9
	public object Clone() { }

	// RVA: 0x227DDE0 Offset: 0x227CFE0 VA: 0x18227DDE0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x227DE10 Offset: 0x227D010 VA: 0x18227DE10 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x227DE70 Offset: 0x227D070 VA: 0x18227DE70 Slot: 10
	protected virtual void OnAdd(SettingsProperty property) { }

	// RVA: 0x227DE40 Offset: 0x227D040 VA: 0x18227DE40 Slot: 11
	protected virtual void OnAddComplete(SettingsProperty property) { }

	// RVA: 0x227DED0 Offset: 0x227D0D0 VA: 0x18227DED0 Slot: 12
	protected virtual void OnClear() { }

	// RVA: 0x227DEA0 Offset: 0x227D0A0 VA: 0x18227DEA0 Slot: 13
	protected virtual void OnClearComplete() { }

	// RVA: 0x227DF30 Offset: 0x227D130 VA: 0x18227DF30 Slot: 14
	protected virtual void OnRemove(SettingsProperty property) { }

	// RVA: 0x227DF00 Offset: 0x227D100 VA: 0x18227DF00 Slot: 15
	protected virtual void OnRemoveComplete(SettingsProperty property) { }

	// RVA: 0x227DF60 Offset: 0x227D160 VA: 0x18227DF60
	public void Remove(string name) { }

	// RVA: 0x227DF90 Offset: 0x227D190 VA: 0x18227DF90
	public void SetReadOnly() { }
}

// Namespace: System.Configuration
public class SettingsProperty // TypeDefIndex: 6440
{
	// Properties
	public virtual SettingsAttributeDictionary Attributes { get; }
	public virtual object DefaultValue { get; set; }
	public virtual bool IsReadOnly { get; set; }
	public virtual string Name { get; set; }
	public virtual Type PropertyType { get; set; }
	public virtual SettingsProvider Provider { get; set; }
	public virtual SettingsSerializeAs SerializeAs { get; set; }
	public bool ThrowOnErrorDeserializing { get; set; }
	public bool ThrowOnErrorSerializing { get; set; }

	// Methods

	// RVA: 0x227E7A0 Offset: 0x227D9A0 VA: 0x18227E7A0
	public void .ctor(SettingsProperty propertyToCopy) { }

	// RVA: 0x227E770 Offset: 0x227D970 VA: 0x18227E770
	public void .ctor(string name) { }

	// RVA: 0x227E7D0 Offset: 0x227D9D0 VA: 0x18227E7D0
	public void .ctor(string name, Type propertyType, SettingsProvider provider, bool isReadOnly, object defaultValue, SettingsSerializeAs serializeAs, SettingsAttributeDictionary attributes, bool throwOnErrorDeserializing, bool throwOnErrorSerializing) { }

	// RVA: 0x227E800 Offset: 0x227DA00 VA: 0x18227E800 Slot: 4
	public virtual SettingsAttributeDictionary get_Attributes() { }

	// RVA: 0x227E830 Offset: 0x227DA30 VA: 0x18227E830 Slot: 5
	public virtual object get_DefaultValue() { }

	// RVA: 0x227E9B0 Offset: 0x227DBB0 VA: 0x18227E9B0 Slot: 6
	public virtual void set_DefaultValue(object value) { }

	// RVA: 0x227E860 Offset: 0x227DA60 VA: 0x18227E860 Slot: 7
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x227E9E0 Offset: 0x227DBE0 VA: 0x18227E9E0 Slot: 8
	public virtual void set_IsReadOnly(bool value) { }

	// RVA: 0x227E890 Offset: 0x227DA90 VA: 0x18227E890 Slot: 9
	public virtual string get_Name() { }

	// RVA: 0x227EA10 Offset: 0x227DC10 VA: 0x18227EA10 Slot: 10
	public virtual void set_Name(string value) { }

	// RVA: 0x227E8C0 Offset: 0x227DAC0 VA: 0x18227E8C0 Slot: 11
	public virtual Type get_PropertyType() { }

	// RVA: 0x227EA40 Offset: 0x227DC40 VA: 0x18227EA40 Slot: 12
	public virtual void set_PropertyType(Type value) { }

	// RVA: 0x227E8F0 Offset: 0x227DAF0 VA: 0x18227E8F0 Slot: 13
	public virtual SettingsProvider get_Provider() { }

	// RVA: 0x227EA70 Offset: 0x227DC70 VA: 0x18227EA70 Slot: 14
	public virtual void set_Provider(SettingsProvider value) { }

	// RVA: 0x227E920 Offset: 0x227DB20 VA: 0x18227E920 Slot: 15
	public virtual SettingsSerializeAs get_SerializeAs() { }

	// RVA: 0x227EAA0 Offset: 0x227DCA0 VA: 0x18227EAA0 Slot: 16
	public virtual void set_SerializeAs(SettingsSerializeAs value) { }

	// RVA: 0x227E950 Offset: 0x227DB50 VA: 0x18227E950
	public bool get_ThrowOnErrorDeserializing() { }

	// RVA: 0x227EAD0 Offset: 0x227DCD0 VA: 0x18227EAD0
	public void set_ThrowOnErrorDeserializing(bool value) { }

	// RVA: 0x227E980 Offset: 0x227DB80 VA: 0x18227E980
	public bool get_ThrowOnErrorSerializing() { }

	// RVA: 0x227EB00 Offset: 0x227DD00 VA: 0x18227EB00
	public void set_ThrowOnErrorSerializing(bool value) { }
}

// Namespace: System.Configuration
public abstract class SettingsProvider : ProviderBase // TypeDefIndex: 6441
{
	// Properties
	public abstract string ApplicationName { get; set; }

	// Methods

	// RVA: 0x227EBF0 Offset: 0x227DDF0 VA: 0x18227EBF0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_ApplicationName();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_ApplicationName(string value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection);
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public class SettingsPropertyValueCollection : ICollection, IEnumerable, ICloneable // TypeDefIndex: 6442
{
	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public SettingsPropertyValue Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x227E380 Offset: 0x227D580 VA: 0x18227E380
	public void .ctor() { }

	// RVA: 0x227E3B0 Offset: 0x227D5B0 VA: 0x18227E3B0 Slot: 5
	public int get_Count() { }

	// RVA: 0x227E3E0 Offset: 0x227D5E0 VA: 0x18227E3E0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x227E410 Offset: 0x227D610 VA: 0x18227E410
	public SettingsPropertyValue get_Item(string name) { }

	// RVA: 0x227E440 Offset: 0x227D640 VA: 0x18227E440 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x227E230 Offset: 0x227D430 VA: 0x18227E230
	public void Add(SettingsPropertyValue property) { }

	// RVA: 0x227E260 Offset: 0x227D460 VA: 0x18227E260
	public void Clear() { }

	// RVA: 0x227E290 Offset: 0x227D490 VA: 0x18227E290 Slot: 9
	public object Clone() { }

	// RVA: 0x227E2C0 Offset: 0x227D4C0 VA: 0x18227E2C0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x227E2F0 Offset: 0x227D4F0 VA: 0x18227E2F0 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x227E320 Offset: 0x227D520 VA: 0x18227E320
	public void Remove(string name) { }

	// RVA: 0x227E350 Offset: 0x227D550 VA: 0x18227E350
	public void SetReadOnly() { }
}

// Namespace: System.Configuration
public class SettingsPropertyValue // TypeDefIndex: 6443
{
	// Properties
	public bool Deserialized { get; set; }
	public bool IsDirty { get; set; }
	public string Name { get; }
	public SettingsProperty Property { get; }
	public object PropertyValue { get; set; }
	public object SerializedValue { get; set; }
	public bool UsingDefaultValue { get; }

	// Methods

	// RVA: 0x227E470 Offset: 0x227D670 VA: 0x18227E470
	public void .ctor(SettingsProperty property) { }

	// RVA: 0x227E4A0 Offset: 0x227D6A0 VA: 0x18227E4A0
	public bool get_Deserialized() { }

	// RVA: 0x227E5F0 Offset: 0x227D7F0 VA: 0x18227E5F0
	public void set_Deserialized(bool value) { }

	// RVA: 0x227E4D0 Offset: 0x227D6D0 VA: 0x18227E4D0
	public bool get_IsDirty() { }

	// RVA: 0x227E620 Offset: 0x227D820 VA: 0x18227E620
	public void set_IsDirty(bool value) { }

	// RVA: 0x227E500 Offset: 0x227D700 VA: 0x18227E500
	public string get_Name() { }

	// RVA: 0x227E560 Offset: 0x227D760 VA: 0x18227E560
	public SettingsProperty get_Property() { }

	// RVA: 0x227E530 Offset: 0x227D730 VA: 0x18227E530
	public object get_PropertyValue() { }

	// RVA: 0x227E650 Offset: 0x227D850 VA: 0x18227E650
	public void set_PropertyValue(object value) { }

	// RVA: 0x227E590 Offset: 0x227D790 VA: 0x18227E590
	public object get_SerializedValue() { }

	// RVA: 0x227E680 Offset: 0x227D880 VA: 0x18227E680
	public void set_SerializedValue(object value) { }

	// RVA: 0x227E5C0 Offset: 0x227D7C0 VA: 0x18227E5C0
	public bool get_UsingDefaultValue() { }
}

// Namespace: System.Configuration
public enum SettingsSerializeAs // TypeDefIndex: 6444
{
	// Fields
	public int value__; // 0x0
	public const SettingsSerializeAs Binary = 2;
	public const SettingsSerializeAs ProviderSpecific = 3;
	public const SettingsSerializeAs String = 0;
	public const SettingsSerializeAs Xml = 1;
}

// Namespace: System.Configuration
[Serializable]
public class SettingsAttributeDictionary : Hashtable // TypeDefIndex: 6445
{
	// Methods

	// RVA: 0x227D900 Offset: 0x227CB00 VA: 0x18227D900
	public void .ctor() { }

	// RVA: 0x227D8D0 Offset: 0x227CAD0 VA: 0x18227D8D0
	public void .ctor(SettingsAttributeDictionary attributes) { }
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public class SettingsProviderCollection : ProviderCollection // TypeDefIndex: 6446
{
	// Properties
	public SettingsProvider Item { get; }

	// Methods

	// RVA: 0x227EB90 Offset: 0x227DD90 VA: 0x18227EB90
	public void .ctor() { }

	// RVA: 0x227EBC0 Offset: 0x227DDC0 VA: 0x18227EBC0
	public SettingsProvider get_Item(string name) { }

	// RVA: 0x227EB60 Offset: 0x227DD60 VA: 0x18227EB60 Slot: 4
	public override void Add(ProviderBase provider) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeMemberMethod : CodeTypeMember // TypeDefIndex: 6447
{
	// Properties
	public CodeTypeReferenceCollection ImplementationTypes { get; }
	public CodeParameterDeclarationExpressionCollection Parameters { get; }
	public CodeTypeReference PrivateImplementationType { get; set; }
	public CodeTypeReference ReturnType { get; set; }
	public CodeAttributeDeclarationCollection ReturnTypeCustomAttributes { get; }
	public CodeStatementCollection Statements { get; }
	public CodeTypeParameterCollection TypeParameters { get; }

	// Methods

	// RVA: 0x226F3C0 Offset: 0x226E5C0 VA: 0x18226F3C0
	public void .ctor() { }

	// RVA: 0x226F480 Offset: 0x226E680 VA: 0x18226F480
	public CodeTypeReferenceCollection get_ImplementationTypes() { }

	// RVA: 0x226F4B0 Offset: 0x226E6B0 VA: 0x18226F4B0
	public CodeParameterDeclarationExpressionCollection get_Parameters() { }

	// RVA: 0x226F4E0 Offset: 0x226E6E0 VA: 0x18226F4E0
	public CodeTypeReference get_PrivateImplementationType() { }

	// RVA: 0x226F660 Offset: 0x226E860 VA: 0x18226F660
	public void set_PrivateImplementationType(CodeTypeReference value) { }

	// RVA: 0x226F540 Offset: 0x226E740 VA: 0x18226F540
	public CodeTypeReference get_ReturnType() { }

	// RVA: 0x226F690 Offset: 0x226E890 VA: 0x18226F690
	public void set_ReturnType(CodeTypeReference value) { }

	// RVA: 0x226F510 Offset: 0x226E710 VA: 0x18226F510
	public CodeAttributeDeclarationCollection get_ReturnTypeCustomAttributes() { }

	// RVA: 0x226F570 Offset: 0x226E770 VA: 0x18226F570
	public CodeStatementCollection get_Statements() { }

	// RVA: 0x226F5A0 Offset: 0x226E7A0 VA: 0x18226F5A0
	public CodeTypeParameterCollection get_TypeParameters() { }

	// RVA: 0x226F3F0 Offset: 0x226E5F0 VA: 0x18226F3F0
	public void add_PopulateImplementationTypes(EventHandler value) { }

	// RVA: 0x226F5D0 Offset: 0x226E7D0 VA: 0x18226F5D0
	public void remove_PopulateImplementationTypes(EventHandler value) { }

	// RVA: 0x226F420 Offset: 0x226E620 VA: 0x18226F420
	public void add_PopulateParameters(EventHandler value) { }

	// RVA: 0x226F600 Offset: 0x226E800 VA: 0x18226F600
	public void remove_PopulateParameters(EventHandler value) { }

	// RVA: 0x226F450 Offset: 0x226E650 VA: 0x18226F450
	public void add_PopulateStatements(EventHandler value) { }

	// RVA: 0x226F630 Offset: 0x226E830 VA: 0x18226F630
	public void remove_PopulateStatements(EventHandler value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[DefaultMember("Item")]
[ClassInterface(1)]
[Serializable]
public class CodeParameterDeclarationExpressionCollection : CollectionBase // TypeDefIndex: 6448
{
	// Properties
	public CodeParameterDeclarationExpression Item { get; set; }

	// Methods

	// RVA: 0x2270AA0 Offset: 0x226FCA0 VA: 0x182270AA0
	public void .ctor() { }

	// RVA: 0x2270A70 Offset: 0x226FC70 VA: 0x182270A70
	public void .ctor(CodeParameterDeclarationExpressionCollection value) { }

	// RVA: 0x2270A40 Offset: 0x226FC40 VA: 0x182270A40
	public void .ctor(CodeParameterDeclarationExpression[] value) { }

	// RVA: 0x2270AD0 Offset: 0x226FCD0 VA: 0x182270AD0
	public CodeParameterDeclarationExpression get_Item(int index) { }

	// RVA: 0x2270B00 Offset: 0x226FD00 VA: 0x182270B00
	public void set_Item(int index, CodeParameterDeclarationExpression value) { }

	// RVA: 0x2270920 Offset: 0x226FB20 VA: 0x182270920
	public int Add(CodeParameterDeclarationExpression value) { }

	// RVA: 0x22708F0 Offset: 0x226FAF0 VA: 0x1822708F0
	public void AddRange(CodeParameterDeclarationExpressionCollection value) { }

	// RVA: 0x22708C0 Offset: 0x226FAC0 VA: 0x1822708C0
	public void AddRange(CodeParameterDeclarationExpression[] value) { }

	// RVA: 0x2270950 Offset: 0x226FB50 VA: 0x182270950
	public bool Contains(CodeParameterDeclarationExpression value) { }

	// RVA: 0x2270980 Offset: 0x226FB80 VA: 0x182270980
	public void CopyTo(CodeParameterDeclarationExpression[] array, int index) { }

	// RVA: 0x22709B0 Offset: 0x226FBB0 VA: 0x1822709B0
	public int IndexOf(CodeParameterDeclarationExpression value) { }

	// RVA: 0x22709E0 Offset: 0x226FBE0 VA: 0x1822709E0
	public void Insert(int index, CodeParameterDeclarationExpression value) { }

	// RVA: 0x2270A10 Offset: 0x226FC10 VA: 0x182270A10
	public void Remove(CodeParameterDeclarationExpression value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeParameterDeclarationExpression : CodeExpression // TypeDefIndex: 6449
{
	// Properties
	public CodeAttributeDeclarationCollection CustomAttributes { get; set; }
	public FieldDirection Direction { get; set; }
	public string Name { get; set; }
	public CodeTypeReference Type { get; set; }

	// Methods

	// RVA: 0x2270BC0 Offset: 0x226FDC0 VA: 0x182270BC0
	public void .ctor() { }

	// RVA: 0x2270B60 Offset: 0x226FD60 VA: 0x182270B60
	public void .ctor(CodeTypeReference type, string name) { }

	// RVA: 0x2270B90 Offset: 0x226FD90 VA: 0x182270B90
	public void .ctor(string type, string name) { }

	// RVA: 0x2270B30 Offset: 0x226FD30 VA: 0x182270B30
	public void .ctor(Type type, string name) { }

	// RVA: 0x2270BF0 Offset: 0x226FDF0 VA: 0x182270BF0
	public CodeAttributeDeclarationCollection get_CustomAttributes() { }

	// RVA: 0x2270CB0 Offset: 0x226FEB0 VA: 0x182270CB0
	public void set_CustomAttributes(CodeAttributeDeclarationCollection value) { }

	// RVA: 0x2270C20 Offset: 0x226FE20 VA: 0x182270C20
	public FieldDirection get_Direction() { }

	// RVA: 0x2270CE0 Offset: 0x226FEE0 VA: 0x182270CE0
	public void set_Direction(FieldDirection value) { }

	// RVA: 0x2270C50 Offset: 0x226FE50 VA: 0x182270C50
	public string get_Name() { }

	// RVA: 0x2270D10 Offset: 0x226FF10 VA: 0x182270D10
	public void set_Name(string value) { }

	// RVA: 0x2270C80 Offset: 0x226FE80 VA: 0x182270C80
	public CodeTypeReference get_Type() { }

	// RVA: 0x2270D40 Offset: 0x226FF40 VA: 0x182270D40
	public void set_Type(CodeTypeReference value) { }
}

// Namespace: System.Security.Permissions
[Serializable]
public abstract class ResourcePermissionBase : CodeAccessPermission, IUnrestrictedPermission // TypeDefIndex: 6450
{
	// Fields
	public const string Any = "*";
	public const string Local = ".";

	// Properties
	protected Type PermissionAccessType { get; set; }
	protected string[] TagNames { get; set; }

	// Methods

	// RVA: 0x227B3E0 Offset: 0x227A5E0 VA: 0x18227B3E0
	protected void .ctor() { }

	// RVA: 0x227B3B0 Offset: 0x227A5B0 VA: 0x18227B3B0
	protected void .ctor(PermissionState state) { }

	// RVA: 0x227B410 Offset: 0x227A610 VA: 0x18227B410
	protected Type get_PermissionAccessType() { }

	// RVA: 0x227B470 Offset: 0x227A670 VA: 0x18227B470
	protected void set_PermissionAccessType(Type value) { }

	// RVA: 0x227B440 Offset: 0x227A640 VA: 0x18227B440
	protected string[] get_TagNames() { }

	// RVA: 0x227B4A0 Offset: 0x227A6A0 VA: 0x18227B4A0
	protected void set_TagNames(string[] value) { }

	// RVA: 0x227B1D0 Offset: 0x227A3D0 VA: 0x18227B1D0
	protected void AddPermissionAccess(ResourcePermissionBaseEntry entry) { }

	// RVA: 0x227B200 Offset: 0x227A400 VA: 0x18227B200
	protected void Clear() { }

	// RVA: 0x227B230 Offset: 0x227A430 VA: 0x18227B230 Slot: 7
	public override IPermission Copy() { }

	// RVA: 0x227B260 Offset: 0x227A460 VA: 0x18227B260 Slot: 9
	public override void FromXml(SecurityElement securityElement) { }

	// RVA: 0x227B290 Offset: 0x227A490 VA: 0x18227B290
	protected ResourcePermissionBaseEntry[] GetPermissionEntries() { }

	// RVA: 0x227B2C0 Offset: 0x227A4C0 VA: 0x18227B2C0 Slot: 10
	public override IPermission Intersect(IPermission target) { }

	// RVA: 0x227B2F0 Offset: 0x227A4F0 VA: 0x18227B2F0 Slot: 11
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x227B320 Offset: 0x227A520 VA: 0x18227B320 Slot: 14
	public bool IsUnrestricted() { }

	// RVA: 0x227B350 Offset: 0x227A550 VA: 0x18227B350
	protected void RemovePermissionAccess(ResourcePermissionBaseEntry entry) { }

	// RVA: 0x227B380 Offset: 0x227A580 VA: 0x18227B380 Slot: 12
	public override SecurityElement ToXml() { }
}

// Namespace: System.Security.Permissions
[Serializable]
public class ResourcePermissionBaseEntry // TypeDefIndex: 6451
{
	// Properties
	public int PermissionAccess { get; }
	public string[] PermissionAccessPath { get; }

	// Methods

	// RVA: 0x227B140 Offset: 0x227A340 VA: 0x18227B140
	public void .ctor() { }

	// RVA: 0x227B110 Offset: 0x227A310 VA: 0x18227B110
	public void .ctor(int permissionAccess, string[] permissionAccessPath) { }

	// RVA: 0x227B1A0 Offset: 0x227A3A0 VA: 0x18227B1A0
	public int get_PermissionAccess() { }

	// RVA: 0x227B170 Offset: 0x227A370 VA: 0x18227B170
	public string[] get_PermissionAccessPath() { }
}

// Namespace: System.Security.Authentication.ExtendedProtection.Configuration
public sealed class ExtendedProtectionPolicyElement : ConfigurationElement // TypeDefIndex: 6452
{
	// Properties
	public ServiceNameElementCollection CustomServiceNames { get; }
	public PolicyEnforcement PolicyEnforcement { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public ProtectionScenario ProtectionScenario { get; set; }

	// Methods

	// RVA: 0x2277310 Offset: 0x2276510 VA: 0x182277310
	public void .ctor() { }

	// RVA: 0x2277340 Offset: 0x2276540 VA: 0x182277340
	public ServiceNameElementCollection get_CustomServiceNames() { }

	// RVA: 0x2277370 Offset: 0x2276570 VA: 0x182277370
	public PolicyEnforcement get_PolicyEnforcement() { }

	// RVA: 0x2277400 Offset: 0x2276600 VA: 0x182277400
	public void set_PolicyEnforcement(PolicyEnforcement value) { }

	// RVA: 0x22773A0 Offset: 0x22765A0 VA: 0x1822773A0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x22773D0 Offset: 0x22765D0 VA: 0x1822773D0
	public ProtectionScenario get_ProtectionScenario() { }

	// RVA: 0x2277430 Offset: 0x2276630 VA: 0x182277430
	public void set_ProtectionScenario(ProtectionScenario value) { }

	// RVA: 0x22772E0 Offset: 0x22764E0 VA: 0x1822772E0
	public ExtendedProtectionPolicy BuildPolicy() { }
}

// Namespace: System.Security.Authentication.ExtendedProtection.Configuration
[ConfigurationCollection(typeof(ServiceNameElement))]
[DefaultMember("Item")]
public sealed class ServiceNameElementCollection : ConfigurationElementCollection // TypeDefIndex: 6453
{
	// Properties
	public ServiceNameElement Item { get; set; }

	// Methods

	// RVA: 0x227C940 Offset: 0x227BB40 VA: 0x18227C940
	public void .ctor() { }

	// RVA: 0x227C970 Offset: 0x227BB70 VA: 0x18227C970
	public ServiceNameElement get_Item(int index) { }

	// RVA: 0x227CA00 Offset: 0x227BC00 VA: 0x18227CA00
	public void set_Item(int index, ServiceNameElement value) { }

	// RVA: 0x227C9A0 Offset: 0x227BBA0 VA: 0x18227C9A0
	public ServiceNameElement get_Item(string name) { }

	// RVA: 0x227C9D0 Offset: 0x227BBD0 VA: 0x18227C9D0
	public void set_Item(string name, ServiceNameElement value) { }

	// RVA: 0x227C7C0 Offset: 0x227B9C0 VA: 0x18227C7C0
	public void Add(ServiceNameElement element) { }

	// RVA: 0x227C7F0 Offset: 0x227B9F0 VA: 0x18227C7F0
	public void Clear() { }

	// RVA: 0x227C820 Offset: 0x227BA20 VA: 0x18227C820 Slot: 16
	protected override ConfigurationElement CreateNewElement() { }

	// RVA: 0x227C850 Offset: 0x227BA50 VA: 0x18227C850 Slot: 17
	protected override object GetElementKey(ConfigurationElement element) { }

	// RVA: 0x227C880 Offset: 0x227BA80 VA: 0x18227C880
	public int IndexOf(ServiceNameElement element) { }

	// RVA: 0x227C8E0 Offset: 0x227BAE0 VA: 0x18227C8E0
	public void Remove(ServiceNameElement element) { }

	// RVA: 0x227C910 Offset: 0x227BB10 VA: 0x18227C910
	public void Remove(string name) { }

	// RVA: 0x227C8B0 Offset: 0x227BAB0 VA: 0x18227C8B0
	public void RemoveAt(int index) { }
}

// Namespace: System.Security.Authentication.ExtendedProtection.Configuration
public sealed class ServiceNameElement : ConfigurationElement // TypeDefIndex: 6454
{
	// Properties
	public string Name { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x227CA30 Offset: 0x227BC30 VA: 0x18227CA30
	public void .ctor() { }

	// RVA: 0x227CA60 Offset: 0x227BC60 VA: 0x18227CA60
	public string get_Name() { }

	// RVA: 0x227CAC0 Offset: 0x227BCC0 VA: 0x18227CAC0
	public void set_Name(string value) { }

	// RVA: 0x227CA90 Offset: 0x227BC90 VA: 0x18227CA90 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Diagnostics
[MonitoringDescription("EventLogDesc")]
[DefaultEvent("EntryWritten")]
[InstallerType("System.Diagnostics.EventLogInstaller, System.Configuration.Install, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class EventLog : Component, ISupportInitialize // TypeDefIndex: 6455
{
	// Properties
	public bool EnableRaisingEvents { get; set; }
	public EventLogEntryCollection Entries { get; }
	public string Log { get; set; }
	public string LogDisplayName { get; }
	public string MachineName { get; set; }
	public long MaximumKilobytes { get; set; }
	public int MinimumRetentionDays { get; }
	public OverflowAction OverflowAction { get; }
	public string Source { get; set; }
	public ISynchronizeInvoke SynchronizingObject { get; set; }

	// Methods

	// RVA: 0x2276B60 Offset: 0x2275D60 VA: 0x182276B60
	public void .ctor() { }

	// RVA: 0x2276B30 Offset: 0x2275D30 VA: 0x182276B30
	public void .ctor(string logName) { }

	// RVA: 0x2276B90 Offset: 0x2275D90 VA: 0x182276B90
	public void .ctor(string logName, string machineName) { }

	// RVA: 0x2276B00 Offset: 0x2275D00 VA: 0x182276B00
	public void .ctor(string logName, string machineName, string source) { }

	// RVA: 0x2276BF0 Offset: 0x2275DF0 VA: 0x182276BF0
	public bool get_EnableRaisingEvents() { }

	// RVA: 0x2276E00 Offset: 0x2276000 VA: 0x182276E00
	public void set_EnableRaisingEvents(bool value) { }

	// RVA: 0x2276C20 Offset: 0x2275E20 VA: 0x182276C20
	public EventLogEntryCollection get_Entries() { }

	// RVA: 0x2276C80 Offset: 0x2275E80 VA: 0x182276C80
	public string get_Log() { }

	// RVA: 0x2276E30 Offset: 0x2276030 VA: 0x182276E30
	public void set_Log(string value) { }

	// RVA: 0x2276C50 Offset: 0x2275E50 VA: 0x182276C50
	public string get_LogDisplayName() { }

	// RVA: 0x2276CB0 Offset: 0x2275EB0 VA: 0x182276CB0
	public string get_MachineName() { }

	// RVA: 0x2276E60 Offset: 0x2276060 VA: 0x182276E60
	public void set_MachineName(string value) { }

	// RVA: 0x2276CE0 Offset: 0x2275EE0 VA: 0x182276CE0
	public long get_MaximumKilobytes() { }

	// RVA: 0x2276E90 Offset: 0x2276090 VA: 0x182276E90
	public void set_MaximumKilobytes(long value) { }

	// RVA: 0x2276D10 Offset: 0x2275F10 VA: 0x182276D10
	public int get_MinimumRetentionDays() { }

	// RVA: 0x2276D40 Offset: 0x2275F40 VA: 0x182276D40
	public OverflowAction get_OverflowAction() { }

	// RVA: 0x2276D70 Offset: 0x2275F70 VA: 0x182276D70
	public string get_Source() { }

	// RVA: 0x2276EC0 Offset: 0x22760C0 VA: 0x182276EC0
	public void set_Source(string value) { }

	// RVA: 0x2276DA0 Offset: 0x2275FA0 VA: 0x182276DA0
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0x2276EF0 Offset: 0x22760F0 VA: 0x182276EF0
	public void set_SynchronizingObject(ISynchronizeInvoke value) { }

	// RVA: 0x2276BC0 Offset: 0x2275DC0 VA: 0x182276BC0
	public void add_EntryWritten(EntryWrittenEventHandler value) { }

	// RVA: 0x2276DD0 Offset: 0x2275FD0 VA: 0x182276DD0
	public void remove_EntryWritten(EntryWrittenEventHandler value) { }

	// RVA: 0x22764A0 Offset: 0x22756A0 VA: 0x1822764A0 Slot: 16
	public void BeginInit() { }

	// RVA: 0x22764D0 Offset: 0x22756D0 VA: 0x1822764D0
	public void Clear() { }

	// RVA: 0x2276500 Offset: 0x2275700 VA: 0x182276500
	public void Close() { }

	// RVA: 0x2276560 Offset: 0x2275760 VA: 0x182276560
	public static void CreateEventSource(EventSourceCreationData sourceData) { }

	// RVA: 0x2276590 Offset: 0x2275790 VA: 0x182276590
	public static void CreateEventSource(string source, string logName) { }

	[Obsolete("This method has been deprecated.  Please use System.Diagnostics.EventLog.CreateEventSource(EventSourceCreationData sourceData) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x2276530 Offset: 0x2275730 VA: 0x182276530
	public static void CreateEventSource(string source, string logName, string machineName) { }

	// RVA: 0x2276650 Offset: 0x2275850 VA: 0x182276650
	public static void Delete(string logName) { }

	// RVA: 0x2276620 Offset: 0x2275820 VA: 0x182276620
	public static void Delete(string logName, string machineName) { }

	// RVA: 0x22765C0 Offset: 0x22757C0 VA: 0x1822765C0
	public static void DeleteEventSource(string source) { }

	// RVA: 0x22765F0 Offset: 0x22757F0 VA: 0x1822765F0
	public static void DeleteEventSource(string source, string machineName) { }

	// RVA: 0x2276680 Offset: 0x2275880 VA: 0x182276680 Slot: 17
	public void EndInit() { }

	// RVA: 0x22766E0 Offset: 0x22758E0 VA: 0x1822766E0
	public static bool Exists(string logName) { }

	// RVA: 0x22766B0 Offset: 0x22758B0 VA: 0x1822766B0
	public static bool Exists(string logName, string machineName) { }

	// RVA: 0x2276710 Offset: 0x2275910 VA: 0x182276710
	public static EventLog[] GetEventLogs() { }

	// RVA: 0x2276740 Offset: 0x2275940 VA: 0x182276740
	public static EventLog[] GetEventLogs(string machineName) { }

	// RVA: 0x2276770 Offset: 0x2275970 VA: 0x182276770
	public static string LogNameFromSourceName(string source, string machineName) { }

	[ComVisible(False)]
	// RVA: 0x22767A0 Offset: 0x22759A0 VA: 0x1822767A0
	public void ModifyOverflowPolicy(OverflowAction action, int retentionDays) { }

	[ComVisible(False)]
	// RVA: 0x22767D0 Offset: 0x22759D0 VA: 0x1822767D0
	public void RegisterDisplayName(string resourceFile, long resourceId) { }

	// RVA: 0x2276830 Offset: 0x2275A30 VA: 0x182276830
	public static bool SourceExists(string source) { }

	// RVA: 0x2276800 Offset: 0x2275A00 VA: 0x182276800
	public static bool SourceExists(string source, string machineName) { }

	// RVA: 0x2276A10 Offset: 0x2275C10 VA: 0x182276A10
	public void WriteEntry(string message) { }

	// RVA: 0x2276890 Offset: 0x2275A90 VA: 0x182276890
	public void WriteEntry(string message, EventLogEntryType type) { }

	// RVA: 0x2276980 Offset: 0x2275B80 VA: 0x182276980
	public void WriteEntry(string message, EventLogEntryType type, int eventID) { }

	// RVA: 0x22769B0 Offset: 0x2275BB0 VA: 0x1822769B0
	public void WriteEntry(string message, EventLogEntryType type, int eventID, short category) { }

	// RVA: 0x2276920 Offset: 0x2275B20 VA: 0x182276920
	public void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData) { }

	// RVA: 0x2276860 Offset: 0x2275A60 VA: 0x182276860
	public static void WriteEntry(string source, string message) { }

	// RVA: 0x22769E0 Offset: 0x2275BE0 VA: 0x1822769E0
	public static void WriteEntry(string source, string message, EventLogEntryType type) { }

	// RVA: 0x22768C0 Offset: 0x2275AC0 VA: 0x1822768C0
	public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID) { }

	// RVA: 0x2276950 Offset: 0x2275B50 VA: 0x182276950
	public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category) { }

	// RVA: 0x22768F0 Offset: 0x2275AF0 VA: 0x1822768F0
	public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category, byte[] rawData) { }

	[ComVisible(False)]
	// RVA: 0x2276AA0 Offset: 0x2275CA0 VA: 0x182276AA0
	public void WriteEvent(EventInstance instance, byte[] data, object[] values) { }

	[ComVisible(False)]
	// RVA: 0x2276AD0 Offset: 0x2275CD0 VA: 0x182276AD0
	public void WriteEvent(EventInstance instance, object[] values) { }

	// RVA: 0x2276A70 Offset: 0x2275C70 VA: 0x182276A70
	public static void WriteEvent(string source, EventInstance instance, byte[] data, object[] values) { }

	// RVA: 0x2276A40 Offset: 0x2275C40 VA: 0x182276A40
	public static void WriteEvent(string source, EventInstance instance, object[] values) { }
}

// Namespace: System.Diagnostics
[DefaultMember("Item")]
public class EventLogEntryCollection : ICollection, IEnumerable // TypeDefIndex: 6456
{
	// Properties
	public int Count { get; }
	public virtual EventLogEntry Item { get; }

	// Methods

	// RVA: 0x2275B70 Offset: 0x2274D70 VA: 0x182275B70
	internal void .ctor() { }

	// RVA: 0x2275BA0 Offset: 0x2274DA0 VA: 0x182275BA0 Slot: 5
	public int get_Count() { }

	// RVA: 0x2275BD0 Offset: 0x2274DD0 VA: 0x182275BD0 Slot: 9
	public virtual EventLogEntry get_Item(int index) { }

	// RVA: 0x2275B10 Offset: 0x2274D10 VA: 0x182275B10 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2275B40 Offset: 0x2274D40 VA: 0x182275B40 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2275A80 Offset: 0x2274C80 VA: 0x182275A80
	public void CopyTo(EventLogEntry[] entries, int index) { }

	// RVA: 0x2275AB0 Offset: 0x2274CB0 VA: 0x182275AB0 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2275AE0 Offset: 0x2274CE0 VA: 0x182275AE0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
}

// Namespace: System.Diagnostics
[DesignTimeVisible(False)]
[ToolboxItem(False)]
[Serializable]
public sealed class EventLogEntry : Component, ISerializable // TypeDefIndex: 6457
{
	// Properties
	public string Category { get; }
	public short CategoryNumber { get; }
	public byte[] Data { get; }
	public EventLogEntryType EntryType { get; }
	public int EventID { get; }
	public int Index { get; }
	public long InstanceId { get; }
	public string MachineName { get; }
	public string Message { get; }
	public string[] ReplacementStrings { get; }
	public string Source { get; }
	public DateTime TimeGenerated { get; }
	public DateTime TimeWritten { get; }
	public string UserName { get; }

	// Methods

	// RVA: 0x2275C60 Offset: 0x2274E60 VA: 0x182275C60
	internal void .ctor() { }

	// RVA: 0x2275CC0 Offset: 0x2274EC0 VA: 0x182275CC0
	public string get_Category() { }

	// RVA: 0x2275C90 Offset: 0x2274E90 VA: 0x182275C90
	public short get_CategoryNumber() { }

	// RVA: 0x2275CF0 Offset: 0x2274EF0 VA: 0x182275CF0
	public byte[] get_Data() { }

	// RVA: 0x2275D20 Offset: 0x2274F20 VA: 0x182275D20
	public EventLogEntryType get_EntryType() { }

	// RVA: 0x2275D50 Offset: 0x2274F50 VA: 0x182275D50
	public int get_EventID() { }

	// RVA: 0x2275D80 Offset: 0x2274F80 VA: 0x182275D80
	public int get_Index() { }

	// RVA: 0x2275DB0 Offset: 0x2274FB0 VA: 0x182275DB0
	public long get_InstanceId() { }

	// RVA: 0x2275DE0 Offset: 0x2274FE0 VA: 0x182275DE0
	public string get_MachineName() { }

	// RVA: 0x2275E10 Offset: 0x2275010 VA: 0x182275E10
	public string get_Message() { }

	// RVA: 0x2275E40 Offset: 0x2275040 VA: 0x182275E40
	public string[] get_ReplacementStrings() { }

	// RVA: 0x2275E70 Offset: 0x2275070 VA: 0x182275E70
	public string get_Source() { }

	// RVA: 0x2275EA0 Offset: 0x22750A0 VA: 0x182275EA0
	public DateTime get_TimeGenerated() { }

	// RVA: 0x2275ED0 Offset: 0x22750D0 VA: 0x182275ED0
	public DateTime get_TimeWritten() { }

	// RVA: 0x2275F00 Offset: 0x2275100 VA: 0x182275F00
	public string get_UserName() { }

	// RVA: 0x2275C00 Offset: 0x2274E00 VA: 0x182275C00
	public bool Equals(EventLogEntry otherEntry) { }

	// RVA: 0x2275C30 Offset: 0x2274E30 VA: 0x182275C30 Slot: 16
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Diagnostics
public enum EventLogEntryType // TypeDefIndex: 6458
{
	// Fields
	public int value__; // 0x0
	public const EventLogEntryType Error = 1;
	public const EventLogEntryType FailureAudit = 16;
	public const EventLogEntryType Information = 4;
	public const EventLogEntryType SuccessAudit = 8;
	public const EventLogEntryType Warning = 2;
}

// Namespace: System.Diagnostics
public enum OverflowAction // TypeDefIndex: 6459
{
	// Fields
	public int value__; // 0x0
	public const OverflowAction DoNotOverwrite = -1;
	public const OverflowAction OverwriteAsNeeded = 0;
	public const OverflowAction OverwriteOlder = 1;
}

// Namespace: System.Diagnostics
public sealed class EntryWrittenEventHandler : MulticastDelegate // TypeDefIndex: 6460
{
	// Methods

	// RVA: 0x22758D0 Offset: 0x2274AD0 VA: 0x1822758D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22758A0 Offset: 0x2274AA0 VA: 0x1822758A0 Slot: 13
	public virtual void Invoke(object sender, EntryWrittenEventArgs e) { }

	// RVA: 0x2275840 Offset: 0x2274A40 VA: 0x182275840 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, EntryWrittenEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x2275870 Offset: 0x2274A70 VA: 0x182275870 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Diagnostics
public class EntryWrittenEventArgs : EventArgs // TypeDefIndex: 6461
{
	// Properties
	public EventLogEntry Entry { get; }

	// Methods

	// RVA: 0x22757B0 Offset: 0x22749B0 VA: 0x1822757B0
	public void .ctor() { }

	// RVA: 0x22757E0 Offset: 0x22749E0 VA: 0x1822757E0
	public void .ctor(EventLogEntry entry) { }

	// RVA: 0x2275810 Offset: 0x2274A10 VA: 0x182275810
	public EventLogEntry get_Entry() { }
}

// Namespace: System.Diagnostics
public class EventSourceCreationData // TypeDefIndex: 6462
{
	// Properties
	public int CategoryCount { get; set; }
	public string CategoryResourceFile { get; set; }
	public string LogName { get; set; }
	public string MachineName { get; set; }
	public string MessageResourceFile { get; set; }
	public string ParameterResourceFile { get; set; }
	public string Source { get; set; }

	// Methods

	// RVA: 0x2276F20 Offset: 0x2276120 VA: 0x182276F20
	public void .ctor(string source, string logName) { }

	// RVA: 0x2276F50 Offset: 0x2276150 VA: 0x182276F50
	public int get_CategoryCount() { }

	// RVA: 0x22770A0 Offset: 0x22762A0 VA: 0x1822770A0
	public void set_CategoryCount(int value) { }

	// RVA: 0x2276F80 Offset: 0x2276180 VA: 0x182276F80
	public string get_CategoryResourceFile() { }

	// RVA: 0x22770D0 Offset: 0x22762D0 VA: 0x1822770D0
	public void set_CategoryResourceFile(string value) { }

	// RVA: 0x2276FB0 Offset: 0x22761B0 VA: 0x182276FB0
	public string get_LogName() { }

	// RVA: 0x2277100 Offset: 0x2276300 VA: 0x182277100
	public void set_LogName(string value) { }

	// RVA: 0x2276FE0 Offset: 0x22761E0 VA: 0x182276FE0
	public string get_MachineName() { }

	// RVA: 0x2277130 Offset: 0x2276330 VA: 0x182277130
	public void set_MachineName(string value) { }

	// RVA: 0x2277010 Offset: 0x2276210 VA: 0x182277010
	public string get_MessageResourceFile() { }

	// RVA: 0x2277160 Offset: 0x2276360 VA: 0x182277160
	public void set_MessageResourceFile(string value) { }

	// RVA: 0x2277040 Offset: 0x2276240 VA: 0x182277040
	public string get_ParameterResourceFile() { }

	// RVA: 0x2277190 Offset: 0x2276390 VA: 0x182277190
	public void set_ParameterResourceFile(string value) { }

	// RVA: 0x2277070 Offset: 0x2276270 VA: 0x182277070
	public string get_Source() { }

	// RVA: 0x22771C0 Offset: 0x22763C0 VA: 0x1822771C0
	public void set_Source(string value) { }
}

// Namespace: System.Diagnostics
public class EventInstance // TypeDefIndex: 6463
{
	// Properties
	public int CategoryId { get; set; }
	public EventLogEntryType EntryType { get; set; }
	public long InstanceId { get; set; }

	// Methods

	// RVA: 0x2275900 Offset: 0x2274B00 VA: 0x182275900
	public void .ctor(long instanceId, int categoryId) { }

	// RVA: 0x2275930 Offset: 0x2274B30 VA: 0x182275930
	public void .ctor(long instanceId, int categoryId, EventLogEntryType entryType) { }

	// RVA: 0x2275960 Offset: 0x2274B60 VA: 0x182275960
	public int get_CategoryId() { }

	// RVA: 0x22759F0 Offset: 0x2274BF0 VA: 0x1822759F0
	public void set_CategoryId(int value) { }

	// RVA: 0x2275990 Offset: 0x2274B90 VA: 0x182275990
	public EventLogEntryType get_EntryType() { }

	// RVA: 0x2275A20 Offset: 0x2274C20 VA: 0x182275A20
	public void set_EntryType(EventLogEntryType value) { }

	// RVA: 0x22759C0 Offset: 0x2274BC0 VA: 0x1822759C0
	public long get_InstanceId() { }

	// RVA: 0x2275A50 Offset: 0x2274C50 VA: 0x182275A50
	public void set_InstanceId(long value) { }
}

// Namespace: System.Configuration
public interface IApplicationSettingsProvider // TypeDefIndex: 6464
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Reset(SettingsContext context);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Upgrade(SettingsContext context, SettingsPropertyCollection properties);
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeArgumentReferenceExpression : CodeExpression // TypeDefIndex: 6465
{
	// Properties
	public string ParameterName { get; set; }

	// Methods

	// RVA: 0x226A850 Offset: 0x2269A50 VA: 0x18226A850
	public void .ctor() { }

	// RVA: 0x226A820 Offset: 0x2269A20 VA: 0x18226A820
	public void .ctor(string parameterName) { }

	// RVA: 0x226A880 Offset: 0x2269A80 VA: 0x18226A880
	public string get_ParameterName() { }

	// RVA: 0x226A8B0 Offset: 0x2269AB0 VA: 0x18226A8B0
	public void set_ParameterName(string value) { }
}

// Namespace: Microsoft.Win32
public class IntranetZoneCredentialPolicy : ICredentialPolicy // TypeDefIndex: 6466
{
	// Methods

	// RVA: 0x2278090 Offset: 0x2277290 VA: 0x182278090
	public void .ctor() { }

	// RVA: 0x2278060 Offset: 0x2277260 VA: 0x182278060 Slot: 5
	public virtual bool ShouldSendCredential(Uri challengeUri, WebRequest request, NetworkCredential credential, IAuthenticationModule authModule) { }
}

// Namespace: Microsoft.Win32
public class PowerModeChangedEventArgs : EventArgs // TypeDefIndex: 6467
{
	// Properties
	public PowerModes Mode { get; }

	// Methods

	// RVA: 0x227A9D0 Offset: 0x2279BD0 VA: 0x18227A9D0
	public void .ctor(PowerModes mode) { }

	// RVA: 0x227AA00 Offset: 0x2279C00 VA: 0x18227AA00
	public PowerModes get_Mode() { }
}

// Namespace: Microsoft.Win32
public enum PowerModes // TypeDefIndex: 6468
{
	// Fields
	public int value__; // 0x0
	public const PowerModes Resume = 1;
	public const PowerModes StatusChange = 2;
	public const PowerModes Suspend = 3;
}

// Namespace: Microsoft.Win32
public sealed class PowerModeChangedEventHandler : MulticastDelegate // TypeDefIndex: 6469
{
	// Methods

	// RVA: 0x227AAC0 Offset: 0x2279CC0 VA: 0x18227AAC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x227AA90 Offset: 0x2279C90 VA: 0x18227AA90 Slot: 13
	public virtual void Invoke(object sender, PowerModeChangedEventArgs e) { }

	// RVA: 0x227AA30 Offset: 0x2279C30 VA: 0x18227AA30 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, PowerModeChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x227AA60 Offset: 0x2279C60 VA: 0x18227AA60 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Microsoft.Win32
public class SessionEndedEventArgs : EventArgs // TypeDefIndex: 6470
{
	// Properties
	public SessionEndReasons Reason { get; }

	// Methods

	// RVA: 0x227CE20 Offset: 0x227C020 VA: 0x18227CE20
	public void .ctor(SessionEndReasons reason) { }

	// RVA: 0x227CE50 Offset: 0x227C050 VA: 0x18227CE50
	public SessionEndReasons get_Reason() { }
}

// Namespace: Microsoft.Win32
public enum SessionEndReasons // TypeDefIndex: 6471
{
	// Fields
	public int value__; // 0x0
	public const SessionEndReasons Logoff = 1;
	public const SessionEndReasons SystemShutdown = 2;
}

// Namespace: Microsoft.Win32
public sealed class SessionEndedEventHandler : MulticastDelegate // TypeDefIndex: 6472
{
	// Methods

	// RVA: 0x227CF10 Offset: 0x227C110 VA: 0x18227CF10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x227CEE0 Offset: 0x227C0E0 VA: 0x18227CEE0 Slot: 13
	public virtual void Invoke(object sender, SessionEndedEventArgs e) { }

	// RVA: 0x227CE80 Offset: 0x227C080 VA: 0x18227CE80 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, SessionEndedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x227CEB0 Offset: 0x227C0B0 VA: 0x18227CEB0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Microsoft.Win32
public class SessionEndingEventArgs : EventArgs // TypeDefIndex: 6473
{
	// Properties
	public bool Cancel { get; set; }
	public SessionEndReasons Reason { get; }

	// Methods

	// RVA: 0x227CF40 Offset: 0x227C140 VA: 0x18227CF40
	public void .ctor(SessionEndReasons reason) { }

	// RVA: 0x227CF70 Offset: 0x227C170 VA: 0x18227CF70
	public bool get_Cancel() { }

	// RVA: 0x227CFD0 Offset: 0x227C1D0 VA: 0x18227CFD0
	public void set_Cancel(bool value) { }

	// RVA: 0x227CFA0 Offset: 0x227C1A0 VA: 0x18227CFA0
	public SessionEndReasons get_Reason() { }
}

// Namespace: Microsoft.Win32
public sealed class SessionEndingEventHandler : MulticastDelegate // TypeDefIndex: 6474
{
	// Methods

	// RVA: 0x227D090 Offset: 0x227C290 VA: 0x18227D090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x227D060 Offset: 0x227C260 VA: 0x18227D060 Slot: 13
	public virtual void Invoke(object sender, SessionEndingEventArgs e) { }

	// RVA: 0x227D000 Offset: 0x227C200 VA: 0x18227D000 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, SessionEndingEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x227D030 Offset: 0x227C230 VA: 0x18227D030 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Microsoft.Win32
public class SessionSwitchEventArgs : EventArgs // TypeDefIndex: 6475
{
	// Properties
	public SessionSwitchReason Reason { get; }

	// Methods

	// RVA: 0x227D0C0 Offset: 0x227C2C0 VA: 0x18227D0C0
	public void .ctor(SessionSwitchReason reason) { }

	// RVA: 0x227D0F0 Offset: 0x227C2F0 VA: 0x18227D0F0
	public SessionSwitchReason get_Reason() { }
}

// Namespace: Microsoft.Win32
public enum SessionSwitchReason // TypeDefIndex: 6476
{
	// Fields
	public int value__; // 0x0
	public const SessionSwitchReason ConsoleConnect = 1;
	public const SessionSwitchReason ConsoleDisconnect = 2;
	public const SessionSwitchReason RemoteConnect = 3;
	public const SessionSwitchReason RemoteDisconnect = 4;
	public const SessionSwitchReason SessionLock = 7;
	public const SessionSwitchReason SessionLogoff = 6;
	public const SessionSwitchReason SessionLogon = 5;
	public const SessionSwitchReason SessionRemoteControl = 9;
	public const SessionSwitchReason SessionUnlock = 8;
}

// Namespace: Microsoft.Win32
public sealed class SessionSwitchEventHandler : MulticastDelegate // TypeDefIndex: 6477
{
	// Methods

	// RVA: 0x227D1B0 Offset: 0x227C3B0 VA: 0x18227D1B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x227D180 Offset: 0x227C380 VA: 0x18227D180 Slot: 13
	public virtual void Invoke(object sender, SessionSwitchEventArgs e) { }

	// RVA: 0x227D120 Offset: 0x227C320 VA: 0x18227D120 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, SessionSwitchEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x227D150 Offset: 0x227C350 VA: 0x18227D150 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Microsoft.Win32
public sealed class SystemEvents // TypeDefIndex: 6478
{
	// Methods

	// RVA: 0x2282ED0 Offset: 0x22820D0 VA: 0x182282ED0
	internal void .ctor() { }

	// RVA: 0x2282F00 Offset: 0x2282100 VA: 0x182282F00
	public static void add_DisplaySettingsChanged(EventHandler value) { }

	// RVA: 0x22831A0 Offset: 0x22823A0 VA: 0x1822831A0
	public static void remove_DisplaySettingsChanged(EventHandler value) { }

	// RVA: 0x2282F30 Offset: 0x2282130 VA: 0x182282F30
	public static void add_DisplaySettingsChanging(EventHandler value) { }

	// RVA: 0x22831D0 Offset: 0x22823D0 VA: 0x1822831D0
	public static void remove_DisplaySettingsChanging(EventHandler value) { }

	// RVA: 0x2282F60 Offset: 0x2282160 VA: 0x182282F60
	public static void add_EventsThreadShutdown(EventHandler value) { }

	// RVA: 0x2283200 Offset: 0x2282400 VA: 0x182283200
	public static void remove_EventsThreadShutdown(EventHandler value) { }

	// RVA: 0x2282F90 Offset: 0x2282190 VA: 0x182282F90
	public static void add_InstalledFontsChanged(EventHandler value) { }

	// RVA: 0x2283230 Offset: 0x2282430 VA: 0x182283230
	public static void remove_InstalledFontsChanged(EventHandler value) { }

	// RVA: 0x2282FC0 Offset: 0x22821C0 VA: 0x182282FC0
	public static void add_LowMemory(EventHandler value) { }

	// RVA: 0x2283260 Offset: 0x2282460 VA: 0x182283260
	public static void remove_LowMemory(EventHandler value) { }

	// RVA: 0x2282FF0 Offset: 0x22821F0 VA: 0x182282FF0
	public static void add_PaletteChanged(EventHandler value) { }

	// RVA: 0x2283290 Offset: 0x2282490 VA: 0x182283290
	public static void remove_PaletteChanged(EventHandler value) { }

	// RVA: 0x2283020 Offset: 0x2282220 VA: 0x182283020
	public static void add_PowerModeChanged(PowerModeChangedEventHandler value) { }

	// RVA: 0x22832C0 Offset: 0x22824C0 VA: 0x1822832C0
	public static void remove_PowerModeChanged(PowerModeChangedEventHandler value) { }

	// RVA: 0x2283050 Offset: 0x2282250 VA: 0x182283050
	public static void add_SessionEnded(SessionEndedEventHandler value) { }

	// RVA: 0x22832F0 Offset: 0x22824F0 VA: 0x1822832F0
	public static void remove_SessionEnded(SessionEndedEventHandler value) { }

	// RVA: 0x2283080 Offset: 0x2282280 VA: 0x182283080
	public static void add_SessionEnding(SessionEndingEventHandler value) { }

	// RVA: 0x2283320 Offset: 0x2282520 VA: 0x182283320
	public static void remove_SessionEnding(SessionEndingEventHandler value) { }

	// RVA: 0x22830B0 Offset: 0x22822B0 VA: 0x1822830B0
	public static void add_SessionSwitch(SessionSwitchEventHandler value) { }

	// RVA: 0x2283350 Offset: 0x2282550 VA: 0x182283350
	public static void remove_SessionSwitch(SessionSwitchEventHandler value) { }

	// RVA: 0x22830E0 Offset: 0x22822E0 VA: 0x1822830E0
	public static void add_TimeChanged(EventHandler value) { }

	// RVA: 0x2283380 Offset: 0x2282580 VA: 0x182283380
	public static void remove_TimeChanged(EventHandler value) { }

	// RVA: 0x2283110 Offset: 0x2282310 VA: 0x182283110
	public static void add_TimerElapsed(TimerElapsedEventHandler value) { }

	// RVA: 0x22833B0 Offset: 0x22825B0 VA: 0x1822833B0
	public static void remove_TimerElapsed(TimerElapsedEventHandler value) { }

	// RVA: 0x2283140 Offset: 0x2282340 VA: 0x182283140
	public static void add_UserPreferenceChanged(UserPreferenceChangedEventHandler value) { }

	// RVA: 0x22833E0 Offset: 0x22825E0 VA: 0x1822833E0
	public static void remove_UserPreferenceChanged(UserPreferenceChangedEventHandler value) { }

	// RVA: 0x2283170 Offset: 0x2282370 VA: 0x182283170
	public static void add_UserPreferenceChanging(UserPreferenceChangingEventHandler value) { }

	// RVA: 0x2283410 Offset: 0x2282610 VA: 0x182283410
	public static void remove_UserPreferenceChanging(UserPreferenceChangingEventHandler value) { }

	// RVA: 0x2282E40 Offset: 0x2282040 VA: 0x182282E40
	public static IntPtr CreateTimer(int interval) { }

	// RVA: 0x2282E70 Offset: 0x2282070 VA: 0x182282E70
	public static void InvokeOnEventsThread(Delegate method) { }

	// RVA: 0x2282EA0 Offset: 0x22820A0 VA: 0x182282EA0
	public static void KillTimer(IntPtr timerId) { }
}

// Namespace: Microsoft.Win32
public sealed class TimerElapsedEventHandler : MulticastDelegate // TypeDefIndex: 6479
{
	// Methods

	// RVA: 0x2283AE0 Offset: 0x2282CE0 VA: 0x182283AE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2283AB0 Offset: 0x2282CB0 VA: 0x182283AB0 Slot: 13
	public virtual void Invoke(object sender, TimerElapsedEventArgs e) { }

	// RVA: 0x2283A50 Offset: 0x2282C50 VA: 0x182283A50 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, TimerElapsedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x2283A80 Offset: 0x2282C80 VA: 0x182283A80 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Microsoft.Win32
public class TimerElapsedEventArgs : EventArgs // TypeDefIndex: 6480
{
	// Properties
	public IntPtr TimerId { get; }

	// Methods

	// RVA: 0x22839F0 Offset: 0x2282BF0 VA: 0x1822839F0
	public void .ctor(IntPtr timerId) { }

	// RVA: 0x2283A20 Offset: 0x2282C20 VA: 0x182283A20
	public IntPtr get_TimerId() { }
}

// Namespace: Microsoft.Win32
public sealed class UserPreferenceChangedEventHandler : MulticastDelegate // TypeDefIndex: 6481
{
	// Methods

	// RVA: 0x2283E60 Offset: 0x2283060 VA: 0x182283E60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2283E30 Offset: 0x2283030 VA: 0x182283E30 Slot: 13
	public virtual void Invoke(object sender, UserPreferenceChangedEventArgs e) { }

	// RVA: 0x2283DD0 Offset: 0x2282FD0 VA: 0x182283DD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, UserPreferenceChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x2283E00 Offset: 0x2283000 VA: 0x182283E00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Microsoft.Win32
public class UserPreferenceChangedEventArgs : EventArgs // TypeDefIndex: 6482
{
	// Properties
	public UserPreferenceCategory Category { get; }

	// Methods

	// RVA: 0x2283D70 Offset: 0x2282F70 VA: 0x182283D70
	public void .ctor(UserPreferenceCategory category) { }

	// RVA: 0x2283DA0 Offset: 0x2282FA0 VA: 0x182283DA0
	public UserPreferenceCategory get_Category() { }
}

// Namespace: Microsoft.Win32
public enum UserPreferenceCategory // TypeDefIndex: 6483
{
	// Fields
	public int value__; // 0x0
	public const UserPreferenceCategory Accessibility = 1;
	public const UserPreferenceCategory Color = 2;
	public const UserPreferenceCategory Desktop = 3;
	public const UserPreferenceCategory General = 4;
	public const UserPreferenceCategory Icon = 5;
	public const UserPreferenceCategory Keyboard = 6;
	public const UserPreferenceCategory Locale = 13;
	public const UserPreferenceCategory Menu = 7;
	public const UserPreferenceCategory Mouse = 8;
	public const UserPreferenceCategory Policy = 9;
	public const UserPreferenceCategory Power = 10;
	public const UserPreferenceCategory Screensaver = 11;
	public const UserPreferenceCategory VisualStyle = 14;
	public const UserPreferenceCategory Window = 12;
}

// Namespace: Microsoft.Win32
public sealed class UserPreferenceChangingEventHandler : MulticastDelegate // TypeDefIndex: 6484
{
	// Methods

	// RVA: 0x2283F80 Offset: 0x2283180 VA: 0x182283F80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2283F50 Offset: 0x2283150 VA: 0x182283F50 Slot: 13
	public virtual void Invoke(object sender, UserPreferenceChangingEventArgs e) { }

	// RVA: 0x2283EF0 Offset: 0x22830F0 VA: 0x182283EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, UserPreferenceChangingEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x2283F20 Offset: 0x2283120 VA: 0x182283F20 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Microsoft.Win32
public class UserPreferenceChangingEventArgs : EventArgs // TypeDefIndex: 6485
{
	// Properties
	public UserPreferenceCategory Category { get; }

	// Methods

	// RVA: 0x2283E90 Offset: 0x2283090 VA: 0x182283E90
	public void .ctor(UserPreferenceCategory category) { }

	// RVA: 0x2283EC0 Offset: 0x22830C0 VA: 0x182283EC0
	public UserPreferenceCategory get_Category() { }
}

// Namespace: Microsoft.VisualBasic
public class VBCodeProvider : CodeDomProvider // TypeDefIndex: 6486
{
	// Properties
	public override string FileExtension { get; }
	public override LanguageOptions LanguageOptions { get; }

	// Methods

	// RVA: 0x22840A0 Offset: 0x22832A0 VA: 0x1822840A0
	public void .ctor() { }

	// RVA: 0x22840D0 Offset: 0x22832D0 VA: 0x1822840D0
	public void .ctor(IDictionary<string, string> providerOptions) { }

	// RVA: 0x2284100 Offset: 0x2283300 VA: 0x182284100 Slot: 16
	public override string get_FileExtension() { }

	// RVA: 0x2284130 Offset: 0x2283330 VA: 0x182284130 Slot: 17
	public override LanguageOptions get_LanguageOptions() { }

	[Obsolete("Callers should not use the ICodeCompiler interface and should instead use the methods directly on the CodeDomProvider class.")]
	// RVA: 0x2283FE0 Offset: 0x22831E0 VA: 0x182283FE0 Slot: 21
	public override ICodeCompiler CreateCompiler() { }

	[Obsolete("Callers should not use the ICodeGenerator interface and should instead use the methods directly on the CodeDomProvider class.")]
	// RVA: 0x2284010 Offset: 0x2283210 VA: 0x182284010 Slot: 23
	public override ICodeGenerator CreateGenerator() { }

	// RVA: 0x2284040 Offset: 0x2283240 VA: 0x182284040 Slot: 30
	public override void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options) { }

	// RVA: 0x2284070 Offset: 0x2283270 VA: 0x182284070 Slot: 34
	public override TypeConverter GetConverter(Type type) { }
}

// Namespace: Microsoft.CSharp
public class CSharpCodeProvider : CodeDomProvider // TypeDefIndex: 6487
{
	// Properties
	public override string FileExtension { get; }

	// Methods

	// RVA: 0x226A730 Offset: 0x2269930 VA: 0x18226A730
	public void .ctor() { }

	// RVA: 0x226A700 Offset: 0x2269900 VA: 0x18226A700
	public void .ctor(IDictionary<string, string> providerOptions) { }

	// RVA: 0x226A760 Offset: 0x2269960 VA: 0x18226A760 Slot: 16
	public override string get_FileExtension() { }

	[Obsolete("Callers should not use the ICodeCompiler interface and should instead use the methods directly on the CodeDomProvider class.")]
	// RVA: 0x226A640 Offset: 0x2269840 VA: 0x18226A640 Slot: 21
	public override ICodeCompiler CreateCompiler() { }

	[Obsolete("Callers should not use the ICodeGenerator interface and should instead use the methods directly on the CodeDomProvider class.")]
	// RVA: 0x226A670 Offset: 0x2269870 VA: 0x18226A670 Slot: 23
	public override ICodeGenerator CreateGenerator() { }

	// RVA: 0x226A6A0 Offset: 0x22698A0 VA: 0x18226A6A0 Slot: 30
	public override void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options) { }

	// RVA: 0x226A6D0 Offset: 0x22698D0 VA: 0x18226A6D0 Slot: 34
	public override TypeConverter GetConverter(Type type) { }
}

// Namespace: System.Web
[Serializable]
public sealed class AspNetHostingPermission : CodeAccessPermission, IUnrestrictedPermission // TypeDefIndex: 6488
{
	// Properties
	public AspNetHostingPermissionLevel Level { get; set; }

	// Methods

	// RVA: 0x2269B50 Offset: 0x2268D50 VA: 0x182269B50
	public void .ctor(PermissionState state) { }

	// RVA: 0x2269B20 Offset: 0x2268D20 VA: 0x182269B20
	public void .ctor(AspNetHostingPermissionLevel level) { }

	// RVA: 0x2269B80 Offset: 0x2268D80 VA: 0x182269B80
	public AspNetHostingPermissionLevel get_Level() { }

	// RVA: 0x2269BB0 Offset: 0x2268DB0 VA: 0x182269BB0
	public void set_Level(AspNetHostingPermissionLevel value) { }

	// RVA: 0x2269A00 Offset: 0x2268C00 VA: 0x182269A00 Slot: 7
	public override IPermission Copy() { }

	// RVA: 0x2269A30 Offset: 0x2268C30 VA: 0x182269A30 Slot: 9
	public override void FromXml(SecurityElement securityElement) { }

	// RVA: 0x2269A60 Offset: 0x2268C60 VA: 0x182269A60 Slot: 10
	public override IPermission Intersect(IPermission target) { }

	// RVA: 0x2269A90 Offset: 0x2268C90 VA: 0x182269A90 Slot: 11
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x2269AC0 Offset: 0x2268CC0 VA: 0x182269AC0 Slot: 14
	public bool IsUnrestricted() { }

	// RVA: 0x2269AF0 Offset: 0x2268CF0 VA: 0x182269AF0 Slot: 12
	public override SecurityElement ToXml() { }
}

// Namespace: System.Web
[Serializable]
public enum AspNetHostingPermissionLevel // TypeDefIndex: 6489
{
	// Fields
	public int value__; // 0x0
	public const AspNetHostingPermissionLevel High = 500;
	public const AspNetHostingPermissionLevel Low = 300;
	public const AspNetHostingPermissionLevel Medium = 400;
	public const AspNetHostingPermissionLevel Minimal = 200;
	public const AspNetHostingPermissionLevel None = 100;
	public const AspNetHostingPermissionLevel Unrestricted = 600;
}

// Namespace: System.Web
[Usage(32767, AllowMultiple = True, Inherited = False)]
[Serializable]
public sealed class AspNetHostingPermissionAttribute : CodeAccessSecurityAttribute // TypeDefIndex: 6490
{
	// Properties
	public AspNetHostingPermissionLevel Level { get; set; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(SecurityAction action) { }

	// RVA: 0x22699D0 Offset: 0x2268BD0 VA: 0x1822699D0
	public AspNetHostingPermissionLevel get_Level() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_Level(AspNetHostingPermissionLevel value) { }

	// RVA: 0x22699A0 Offset: 0x2268BA0 VA: 0x1822699A0 Slot: 7
	public override IPermission CreatePermission() { }
}

// Namespace: System.Reflection
public interface ICustomTypeProvider // TypeDefIndex: 6491
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type GetCustomType();
}

// Namespace: System.Net
[Serializable]
public sealed class DnsPermission : CodeAccessPermission, IUnrestrictedPermission // TypeDefIndex: 6492
{
	// Methods

	// RVA: 0x2275750 Offset: 0x2274950 VA: 0x182275750
	public void .ctor(PermissionState state) { }

	// RVA: 0x2275630 Offset: 0x2274830 VA: 0x182275630 Slot: 7
	public override IPermission Copy() { }

	// RVA: 0x2275660 Offset: 0x2274860 VA: 0x182275660 Slot: 9
	public override void FromXml(SecurityElement securityElement) { }

	// RVA: 0x2275690 Offset: 0x2274890 VA: 0x182275690 Slot: 10
	public override IPermission Intersect(IPermission target) { }

	// RVA: 0x22756C0 Offset: 0x22748C0 VA: 0x1822756C0 Slot: 11
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x22756F0 Offset: 0x22748F0 VA: 0x1822756F0 Slot: 14
	public bool IsUnrestricted() { }

	// RVA: 0x2275720 Offset: 0x2274920 VA: 0x182275720 Slot: 12
	public override SecurityElement ToXml() { }
}

// Namespace: System.Net
[Usage(109, AllowMultiple = True, Inherited = False)]
[Serializable]
public sealed class DnsPermissionAttribute : CodeAccessSecurityAttribute // TypeDefIndex: 6493
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(SecurityAction action) { }

	// RVA: 0x2275600 Offset: 0x2274800 VA: 0x182275600 Slot: 7
	public override IPermission CreatePermission() { }
}

// Namespace: System.Net.Mail
[Serializable]
public sealed class SmtpPermission : CodeAccessPermission, IUnrestrictedPermission // TypeDefIndex: 6494
{
	// Properties
	public SmtpAccess Access { get; }

	// Methods

	// RVA: 0x227F520 Offset: 0x227E720 VA: 0x18227F520
	public void .ctor(bool unrestricted) { }

	// RVA: 0x227F4C0 Offset: 0x227E6C0 VA: 0x18227F4C0
	public void .ctor(SmtpAccess access) { }

	// RVA: 0x227F4F0 Offset: 0x227E6F0 VA: 0x18227F4F0
	public void .ctor(PermissionState state) { }

	// RVA: 0x227F550 Offset: 0x227E750 VA: 0x18227F550
	public SmtpAccess get_Access() { }

	// RVA: 0x227F370 Offset: 0x227E570 VA: 0x18227F370
	public void AddPermission(SmtpAccess access) { }

	// RVA: 0x227F3A0 Offset: 0x227E5A0 VA: 0x18227F3A0 Slot: 7
	public override IPermission Copy() { }

	// RVA: 0x227F3D0 Offset: 0x227E5D0 VA: 0x18227F3D0 Slot: 9
	public override void FromXml(SecurityElement securityElement) { }

	// RVA: 0x227F400 Offset: 0x227E600 VA: 0x18227F400 Slot: 10
	public override IPermission Intersect(IPermission target) { }

	// RVA: 0x227F430 Offset: 0x227E630 VA: 0x18227F430 Slot: 11
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x227F460 Offset: 0x227E660 VA: 0x18227F460 Slot: 14
	public bool IsUnrestricted() { }

	// RVA: 0x227F490 Offset: 0x227E690 VA: 0x18227F490 Slot: 12
	public override SecurityElement ToXml() { }
}

// Namespace: System.Net.Mail
[Usage(109, AllowMultiple = True, Inherited = False)]
[Serializable]
public sealed class SmtpPermissionAttribute : CodeAccessSecurityAttribute // TypeDefIndex: 6495
{
	// Properties
	public string Access { get; set; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(SecurityAction action) { }

	// RVA: 0x227F340 Offset: 0x227E540 VA: 0x18227F340
	public string get_Access() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_Access(string value) { }

	// RVA: 0x227F310 Offset: 0x227E510 VA: 0x18227F310 Slot: 7
	public override IPermission CreatePermission() { }
}

// Namespace: System.Net.Configuration
public sealed class AuthenticationModuleElement : ConfigurationElement // TypeDefIndex: 6496
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }
	public string Type { get; set; }

	// Methods

	// RVA: 0x226A100 Offset: 0x2269300 VA: 0x18226A100
	public void .ctor() { }

	// RVA: 0x226A0D0 Offset: 0x22692D0 VA: 0x18226A0D0
	public void .ctor(string typeName) { }

	// RVA: 0x226A130 Offset: 0x2269330 VA: 0x18226A130 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x226A160 Offset: 0x2269360 VA: 0x18226A160
	public string get_Type() { }

	// RVA: 0x226A190 Offset: 0x2269390 VA: 0x18226A190
	public void set_Type(string value) { }
}

// Namespace: System.Net.Configuration
[ConfigurationCollection(typeof(AuthenticationModuleElement))]
[DefaultMember("Item")]
public sealed class AuthenticationModuleElementCollection : ConfigurationElementCollection // TypeDefIndex: 6497
{
	// Properties
	public AuthenticationModuleElement Item { get; set; }

	// Methods

	// RVA: 0x2269FE0 Offset: 0x22691E0 VA: 0x182269FE0
	public void .ctor() { }

	// RVA: 0x226A040 Offset: 0x2269240 VA: 0x18226A040
	public AuthenticationModuleElement get_Item(int index) { }

	// RVA: 0x226A0A0 Offset: 0x22692A0 VA: 0x18226A0A0
	public void set_Item(int index, AuthenticationModuleElement value) { }

	// RVA: 0x226A010 Offset: 0x2269210 VA: 0x18226A010
	public AuthenticationModuleElement get_Item(string name) { }

	// RVA: 0x226A070 Offset: 0x2269270 VA: 0x18226A070
	public void set_Item(string name, AuthenticationModuleElement value) { }

	// RVA: 0x2269E60 Offset: 0x2269060 VA: 0x182269E60
	public void Add(AuthenticationModuleElement element) { }

	// RVA: 0x2269E90 Offset: 0x2269090 VA: 0x182269E90
	public void Clear() { }

	// RVA: 0x2269EC0 Offset: 0x22690C0 VA: 0x182269EC0 Slot: 16
	protected override ConfigurationElement CreateNewElement() { }

	// RVA: 0x2269EF0 Offset: 0x22690F0 VA: 0x182269EF0 Slot: 17
	protected override object GetElementKey(ConfigurationElement element) { }

	// RVA: 0x2269F20 Offset: 0x2269120 VA: 0x182269F20
	public int IndexOf(AuthenticationModuleElement element) { }

	// RVA: 0x2269FB0 Offset: 0x22691B0 VA: 0x182269FB0
	public void Remove(AuthenticationModuleElement element) { }

	// RVA: 0x2269F80 Offset: 0x2269180 VA: 0x182269F80
	public void Remove(string name) { }

	// RVA: 0x2269F50 Offset: 0x2269150 VA: 0x182269F50
	public void RemoveAt(int index) { }
}

// Namespace: System.Net.Configuration
public sealed class AuthenticationModulesSection : ConfigurationSection // TypeDefIndex: 6498
{
	// Properties
	public AuthenticationModuleElementCollection AuthenticationModules { get; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x226A220 Offset: 0x2269420 VA: 0x18226A220
	public void .ctor() { }

	// RVA: 0x226A250 Offset: 0x2269450 VA: 0x18226A250
	public AuthenticationModuleElementCollection get_AuthenticationModules() { }

	// RVA: 0x226A280 Offset: 0x2269480 VA: 0x18226A280 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x226A1C0 Offset: 0x22693C0 VA: 0x18226A1C0 Slot: 6
	protected override void InitializeDefault() { }

	// RVA: 0x226A1F0 Offset: 0x22693F0 VA: 0x18226A1F0 Slot: 8
	protected override void PostDeserialize() { }
}

// Namespace: System.Net.Configuration
public sealed class BypassElement : ConfigurationElement // TypeDefIndex: 6499
{
	// Properties
	public string Address { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x226A580 Offset: 0x2269780 VA: 0x18226A580
	public void .ctor() { }

	// RVA: 0x226A550 Offset: 0x2269750 VA: 0x18226A550
	public void .ctor(string address) { }

	// RVA: 0x226A5B0 Offset: 0x22697B0 VA: 0x18226A5B0
	public string get_Address() { }

	// RVA: 0x226A610 Offset: 0x2269810 VA: 0x18226A610
	public void set_Address(string value) { }

	// RVA: 0x226A5E0 Offset: 0x22697E0 VA: 0x18226A5E0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
[DefaultMember("Item")]
[ConfigurationCollection(typeof(BypassElement))]
public sealed class BypassElementCollection : ConfigurationElementCollection // TypeDefIndex: 6500
{
	// Properties
	public BypassElement Item { get; set; }
	protected override bool ThrowOnDuplicate { get; }

	// Methods

	// RVA: 0x226A430 Offset: 0x2269630 VA: 0x18226A430
	public void .ctor() { }

	// RVA: 0x226A460 Offset: 0x2269660 VA: 0x18226A460
	public BypassElement get_Item(int index) { }

	// RVA: 0x226A520 Offset: 0x2269720 VA: 0x18226A520
	public void set_Item(int index, BypassElement value) { }

	// RVA: 0x226A490 Offset: 0x2269690 VA: 0x18226A490
	public BypassElement get_Item(string name) { }

	// RVA: 0x226A4F0 Offset: 0x22696F0 VA: 0x18226A4F0
	public void set_Item(string name, BypassElement value) { }

	// RVA: 0x226A4C0 Offset: 0x22696C0 VA: 0x18226A4C0 Slot: 15
	protected override bool get_ThrowOnDuplicate() { }

	// RVA: 0x226A2B0 Offset: 0x22694B0 VA: 0x18226A2B0
	public void Add(BypassElement element) { }

	// RVA: 0x226A2E0 Offset: 0x22694E0 VA: 0x18226A2E0
	public void Clear() { }

	// RVA: 0x226A310 Offset: 0x2269510 VA: 0x18226A310 Slot: 16
	protected override ConfigurationElement CreateNewElement() { }

	// RVA: 0x226A340 Offset: 0x2269540 VA: 0x18226A340 Slot: 17
	protected override object GetElementKey(ConfigurationElement element) { }

	// RVA: 0x226A370 Offset: 0x2269570 VA: 0x18226A370
	public int IndexOf(BypassElement element) { }

	// RVA: 0x226A3D0 Offset: 0x22695D0 VA: 0x18226A3D0
	public void Remove(BypassElement element) { }

	// RVA: 0x226A400 Offset: 0x2269600 VA: 0x18226A400
	public void Remove(string name) { }

	// RVA: 0x226A3A0 Offset: 0x22695A0 VA: 0x18226A3A0
	public void RemoveAt(int index) { }
}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElement : ConfigurationElement // TypeDefIndex: 6501
{
	// Properties
	public string Address { get; set; }
	public int MaxConnection { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x2274940 Offset: 0x2273B40 VA: 0x182274940
	public void .ctor() { }

	// RVA: 0x2274970 Offset: 0x2273B70 VA: 0x182274970
	public void .ctor(string address, int maxConnection) { }

	// RVA: 0x22749A0 Offset: 0x2273BA0 VA: 0x1822749A0
	public string get_Address() { }

	// RVA: 0x2274A30 Offset: 0x2273C30 VA: 0x182274A30
	public void set_Address(string value) { }

	// RVA: 0x22749D0 Offset: 0x2273BD0 VA: 0x1822749D0
	public int get_MaxConnection() { }

	// RVA: 0x2274A60 Offset: 0x2273C60 VA: 0x182274A60
	public void set_MaxConnection(int value) { }

	// RVA: 0x2274A00 Offset: 0x2273C00 VA: 0x182274A00 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
[ConfigurationCollection(typeof(ConnectionManagementElement))]
[DefaultMember("Item")]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 6502
{
	// Properties
	public ConnectionManagementElement Item { get; set; }

	// Methods

	// RVA: 0x2274850 Offset: 0x2273A50 VA: 0x182274850
	public void .ctor() { }

	// RVA: 0x22748B0 Offset: 0x2273AB0 VA: 0x1822748B0
	public ConnectionManagementElement get_Item(int index) { }

	// RVA: 0x2274910 Offset: 0x2273B10 VA: 0x182274910
	public void set_Item(int index, ConnectionManagementElement value) { }

	// RVA: 0x2274880 Offset: 0x2273A80 VA: 0x182274880
	public ConnectionManagementElement get_Item(string name) { }

	// RVA: 0x22748E0 Offset: 0x2273AE0 VA: 0x1822748E0
	public void set_Item(string name, ConnectionManagementElement value) { }

	// RVA: 0x22746D0 Offset: 0x22738D0 VA: 0x1822746D0
	public void Add(ConnectionManagementElement element) { }

	// RVA: 0x2274700 Offset: 0x2273900 VA: 0x182274700
	public void Clear() { }

	// RVA: 0x2274730 Offset: 0x2273930 VA: 0x182274730 Slot: 16
	protected override ConfigurationElement CreateNewElement() { }

	// RVA: 0x2274760 Offset: 0x2273960 VA: 0x182274760 Slot: 17
	protected override object GetElementKey(ConfigurationElement element) { }

	// RVA: 0x2274790 Offset: 0x2273990 VA: 0x182274790
	public int IndexOf(ConnectionManagementElement element) { }

	// RVA: 0x2274820 Offset: 0x2273A20 VA: 0x182274820
	public void Remove(ConnectionManagementElement element) { }

	// RVA: 0x22747F0 Offset: 0x22739F0 VA: 0x1822747F0
	public void Remove(string name) { }

	// RVA: 0x22747C0 Offset: 0x22739C0 VA: 0x1822747C0
	public void RemoveAt(int index) { }
}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementSection : ConfigurationSection // TypeDefIndex: 6503
{
	// Properties
	public ConnectionManagementElementCollection ConnectionManagement { get; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x2274A90 Offset: 0x2273C90 VA: 0x182274A90
	public void .ctor() { }

	// RVA: 0x2274AC0 Offset: 0x2273CC0 VA: 0x182274AC0
	public ConnectionManagementElementCollection get_ConnectionManagement() { }

	// RVA: 0x2274AF0 Offset: 0x2273CF0 VA: 0x182274AF0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class DefaultProxySection : ConfigurationSection // TypeDefIndex: 6504
{
	// Properties
	public BypassElementCollection BypassList { get; }
	public bool Enabled { get; set; }
	public ModuleElement Module { get; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public ProxyElement Proxy { get; }
	public bool UseDefaultCredentials { get; set; }

	// Methods

	// RVA: 0x2275300 Offset: 0x2274500 VA: 0x182275300
	public void .ctor() { }

	// RVA: 0x2275330 Offset: 0x2274530 VA: 0x182275330
	public BypassElementCollection get_BypassList() { }

	// RVA: 0x2275360 Offset: 0x2274560 VA: 0x182275360
	public bool get_Enabled() { }

	// RVA: 0x2275450 Offset: 0x2274650 VA: 0x182275450
	public void set_Enabled(bool value) { }

	// RVA: 0x2275390 Offset: 0x2274590 VA: 0x182275390
	public ModuleElement get_Module() { }

	// RVA: 0x22753C0 Offset: 0x22745C0 VA: 0x1822753C0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x22753F0 Offset: 0x22745F0 VA: 0x1822753F0
	public ProxyElement get_Proxy() { }

	// RVA: 0x2275420 Offset: 0x2274620 VA: 0x182275420
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x2275480 Offset: 0x2274680 VA: 0x182275480
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x22752A0 Offset: 0x22744A0 VA: 0x1822752A0 Slot: 8
	protected override void PostDeserialize() { }

	// RVA: 0x22752D0 Offset: 0x22744D0 VA: 0x1822752D0 Slot: 9
	protected override void Reset(ConfigurationElement parentElement) { }
}

// Namespace: System.Net.Configuration
public sealed class ModuleElement : ConfigurationElement // TypeDefIndex: 6505
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }
	public string Type { get; set; }

	// Methods

	// RVA: 0x2278570 Offset: 0x2277770 VA: 0x182278570
	public void .ctor() { }

	// RVA: 0x22785A0 Offset: 0x22777A0 VA: 0x1822785A0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x22785D0 Offset: 0x22777D0 VA: 0x1822785D0
	public string get_Type() { }

	// RVA: 0x2278600 Offset: 0x2277800 VA: 0x182278600
	public void set_Type(string value) { }
}

// Namespace: 
public enum ProxyElement.AutoDetectValues // TypeDefIndex: 6506
{
	// Fields
	public int value__; // 0x0
	public const ProxyElement.AutoDetectValues False = 0;
	public const ProxyElement.AutoDetectValues True = 1;
	public const ProxyElement.AutoDetectValues Unspecified = -1;
}

// Namespace: 
public enum ProxyElement.BypassOnLocalValues // TypeDefIndex: 6507
{
	// Fields
	public int value__; // 0x0
	public const ProxyElement.BypassOnLocalValues False = 0;
	public const ProxyElement.BypassOnLocalValues True = 1;
	public const ProxyElement.BypassOnLocalValues Unspecified = -1;
}

// Namespace: 
public enum ProxyElement.UseSystemDefaultValues // TypeDefIndex: 6508
{
	// Fields
	public int value__; // 0x0
	public const ProxyElement.UseSystemDefaultValues False = 0;
	public const ProxyElement.UseSystemDefaultValues True = 1;
	public const ProxyElement.UseSystemDefaultValues Unspecified = -1;
}

// Namespace: System.Net.Configuration
public sealed class ProxyElement : ConfigurationElement // TypeDefIndex: 6509
{
	// Properties
	public ProxyElement.AutoDetectValues AutoDetect { get; set; }
	public ProxyElement.BypassOnLocalValues BypassOnLocal { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public Uri ProxyAddress { get; set; }
	public Uri ScriptLocation { get; set; }
	public ProxyElement.UseSystemDefaultValues UseSystemDefault { get; set; }

	// Methods

	// RVA: 0x227AAF0 Offset: 0x2279CF0 VA: 0x18227AAF0
	public void .ctor() { }

	// RVA: 0x227AB20 Offset: 0x2279D20 VA: 0x18227AB20
	public ProxyElement.AutoDetectValues get_AutoDetect() { }

	// RVA: 0x227AC40 Offset: 0x2279E40 VA: 0x18227AC40
	public void set_AutoDetect(ProxyElement.AutoDetectValues value) { }

	// RVA: 0x227AB50 Offset: 0x2279D50 VA: 0x18227AB50
	public ProxyElement.BypassOnLocalValues get_BypassOnLocal() { }

	// RVA: 0x227AC70 Offset: 0x2279E70 VA: 0x18227AC70
	public void set_BypassOnLocal(ProxyElement.BypassOnLocalValues value) { }

	// RVA: 0x227AB80 Offset: 0x2279D80 VA: 0x18227AB80 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x227ABB0 Offset: 0x2279DB0 VA: 0x18227ABB0
	public Uri get_ProxyAddress() { }

	// RVA: 0x227ACA0 Offset: 0x2279EA0 VA: 0x18227ACA0
	public void set_ProxyAddress(Uri value) { }

	// RVA: 0x227ABE0 Offset: 0x2279DE0 VA: 0x18227ABE0
	public Uri get_ScriptLocation() { }

	// RVA: 0x227ACD0 Offset: 0x2279ED0 VA: 0x18227ACD0
	public void set_ScriptLocation(Uri value) { }

	// RVA: 0x227AC10 Offset: 0x2279E10 VA: 0x18227AC10
	public ProxyElement.UseSystemDefaultValues get_UseSystemDefault() { }

	// RVA: 0x227AD00 Offset: 0x2279F00 VA: 0x18227AD00
	public void set_UseSystemDefault(ProxyElement.UseSystemDefaultValues value) { }
}

// Namespace: System.Net.Configuration
public sealed class FtpCachePolicyElement : ConfigurationElement // TypeDefIndex: 6510
{
	// Properties
	public RequestCacheLevel PolicyLevel { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x22774C0 Offset: 0x22766C0 VA: 0x1822774C0
	public void .ctor() { }

	// RVA: 0x22774F0 Offset: 0x22766F0 VA: 0x1822774F0
	public RequestCacheLevel get_PolicyLevel() { }

	// RVA: 0x2277550 Offset: 0x2276750 VA: 0x182277550
	public void set_PolicyLevel(RequestCacheLevel value) { }

	// RVA: 0x2277520 Offset: 0x2276720 VA: 0x182277520 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x2277460 Offset: 0x2276660 VA: 0x182277460 Slot: 5
	protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey) { }

	// RVA: 0x2277490 Offset: 0x2276690 VA: 0x182277490 Slot: 9
	protected override void Reset(ConfigurationElement parentElement) { }
}

// Namespace: System.Net.Configuration
public sealed class HttpCachePolicyElement : ConfigurationElement // TypeDefIndex: 6511
{
	// Properties
	public TimeSpan MaximumAge { get; set; }
	public TimeSpan MaximumStale { get; set; }
	public TimeSpan MinimumFresh { get; set; }
	public HttpRequestCacheLevel PolicyLevel { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x22775E0 Offset: 0x22767E0 VA: 0x1822775E0
	public void .ctor() { }

	// RVA: 0x2277610 Offset: 0x2276810 VA: 0x182277610
	public TimeSpan get_MaximumAge() { }

	// RVA: 0x2277700 Offset: 0x2276900 VA: 0x182277700
	public void set_MaximumAge(TimeSpan value) { }

	// RVA: 0x2277640 Offset: 0x2276840 VA: 0x182277640
	public TimeSpan get_MaximumStale() { }

	// RVA: 0x2277730 Offset: 0x2276930 VA: 0x182277730
	public void set_MaximumStale(TimeSpan value) { }

	// RVA: 0x2277670 Offset: 0x2276870 VA: 0x182277670
	public TimeSpan get_MinimumFresh() { }

	// RVA: 0x2277760 Offset: 0x2276960 VA: 0x182277760
	public void set_MinimumFresh(TimeSpan value) { }

	// RVA: 0x22776A0 Offset: 0x22768A0 VA: 0x1822776A0
	public HttpRequestCacheLevel get_PolicyLevel() { }

	// RVA: 0x2277790 Offset: 0x2276990 VA: 0x182277790
	public void set_PolicyLevel(HttpRequestCacheLevel value) { }

	// RVA: 0x22776D0 Offset: 0x22768D0 VA: 0x1822776D0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x2277580 Offset: 0x2276780 VA: 0x182277580 Slot: 5
	protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey) { }

	// RVA: 0x22775B0 Offset: 0x22767B0 VA: 0x1822775B0 Slot: 9
	protected override void Reset(ConfigurationElement parentElement) { }
}

// Namespace: System.Net.Configuration
public sealed class HttpListenerElement : ConfigurationElement // TypeDefIndex: 6512
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }
	public HttpListenerTimeoutsElement Timeouts { get; }
	public bool UnescapeRequestUrl { get; }

	// Methods

	// RVA: 0x22777C0 Offset: 0x22769C0 VA: 0x1822777C0
	public void .ctor() { }

	// RVA: 0x22777F0 Offset: 0x22769F0 VA: 0x1822777F0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x2277820 Offset: 0x2276A20 VA: 0x182277820
	public HttpListenerTimeoutsElement get_Timeouts() { }

	// RVA: 0x2277850 Offset: 0x2276A50 VA: 0x182277850
	public bool get_UnescapeRequestUrl() { }
}

// Namespace: System.Net.Configuration
public sealed class HttpListenerTimeoutsElement : ConfigurationElement // TypeDefIndex: 6513
{
	// Properties
	public TimeSpan DrainEntityBody { get; }
	public TimeSpan EntityBody { get; }
	public TimeSpan HeaderWait { get; }
	public TimeSpan IdleConnection { get; }
	public long MinSendBytesPerSecond { get; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public TimeSpan RequestQueue { get; }

	// Methods

	// RVA: 0x2277880 Offset: 0x2276A80 VA: 0x182277880
	public void .ctor() { }

	// RVA: 0x22778B0 Offset: 0x2276AB0 VA: 0x1822778B0
	public TimeSpan get_DrainEntityBody() { }

	// RVA: 0x22778E0 Offset: 0x2276AE0 VA: 0x1822778E0
	public TimeSpan get_EntityBody() { }

	// RVA: 0x2277910 Offset: 0x2276B10 VA: 0x182277910
	public TimeSpan get_HeaderWait() { }

	// RVA: 0x2277940 Offset: 0x2276B40 VA: 0x182277940
	public TimeSpan get_IdleConnection() { }

	// RVA: 0x2277970 Offset: 0x2276B70 VA: 0x182277970
	public long get_MinSendBytesPerSecond() { }

	// RVA: 0x22779A0 Offset: 0x2276BA0 VA: 0x1822779A0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x22779D0 Offset: 0x2276BD0 VA: 0x1822779D0
	public TimeSpan get_RequestQueue() { }
}

// Namespace: System.Net.Configuration
public sealed class HttpWebRequestElement : ConfigurationElement // TypeDefIndex: 6514
{
	// Properties
	public int MaximumErrorResponseLength { get; set; }
	public int MaximumResponseHeadersLength { get; set; }
	public int MaximumUnauthorizedUploadLength { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public bool UseUnsafeHeaderParsing { get; set; }

	// Methods

	// RVA: 0x2277A30 Offset: 0x2276C30 VA: 0x182277A30
	public void .ctor() { }

	// RVA: 0x2277A60 Offset: 0x2276C60 VA: 0x182277A60
	public int get_MaximumErrorResponseLength() { }

	// RVA: 0x2277B50 Offset: 0x2276D50 VA: 0x182277B50
	public void set_MaximumErrorResponseLength(int value) { }

	// RVA: 0x2277A90 Offset: 0x2276C90 VA: 0x182277A90
	public int get_MaximumResponseHeadersLength() { }

	// RVA: 0x2277B80 Offset: 0x2276D80 VA: 0x182277B80
	public void set_MaximumResponseHeadersLength(int value) { }

	// RVA: 0x2277AC0 Offset: 0x2276CC0 VA: 0x182277AC0
	public int get_MaximumUnauthorizedUploadLength() { }

	// RVA: 0x2277BB0 Offset: 0x2276DB0 VA: 0x182277BB0
	public void set_MaximumUnauthorizedUploadLength(int value) { }

	// RVA: 0x2277AF0 Offset: 0x2276CF0 VA: 0x182277AF0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x2277B20 Offset: 0x2276D20 VA: 0x182277B20
	public bool get_UseUnsafeHeaderParsing() { }

	// RVA: 0x2277BE0 Offset: 0x2276DE0 VA: 0x182277BE0
	public void set_UseUnsafeHeaderParsing(bool value) { }

	// RVA: 0x2277A00 Offset: 0x2276C00 VA: 0x182277A00 Slot: 8
	protected override void PostDeserialize() { }
}

// Namespace: System.Net.Configuration
public sealed class Ipv6Element : ConfigurationElement // TypeDefIndex: 6515
{
	// Properties
	public bool Enabled { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x22780C0 Offset: 0x22772C0 VA: 0x1822780C0
	public void .ctor() { }

	// RVA: 0x22780F0 Offset: 0x22772F0 VA: 0x1822780F0
	public bool get_Enabled() { }

	// RVA: 0x2278150 Offset: 0x2277350 VA: 0x182278150
	public void set_Enabled(bool value) { }

	// RVA: 0x2278120 Offset: 0x2277320 VA: 0x182278120 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class MailSettingsSectionGroup : ConfigurationSectionGroup // TypeDefIndex: 6516
{
	// Properties
	public SmtpSection Smtp { get; }

	// Methods

	// RVA: 0x2278510 Offset: 0x2277710 VA: 0x182278510
	public void .ctor() { }

	// RVA: 0x2278540 Offset: 0x2277740 VA: 0x182278540
	public SmtpSection get_Smtp() { }
}

// Namespace: System.Net.Configuration
public sealed class SmtpSection : ConfigurationSection // TypeDefIndex: 6517
{
	// Properties
	public SmtpDeliveryFormat DeliveryFormat { get; set; }
	public SmtpDeliveryMethod DeliveryMethod { get; set; }
	public string From { get; set; }
	public SmtpNetworkElement Network { get; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory { get; }

	// Methods

	// RVA: 0x227F580 Offset: 0x227E780 VA: 0x18227F580
	public void .ctor() { }

	// RVA: 0x227F5B0 Offset: 0x227E7B0 VA: 0x18227F5B0
	public SmtpDeliveryFormat get_DeliveryFormat() { }

	// RVA: 0x227F6D0 Offset: 0x227E8D0 VA: 0x18227F6D0
	public void set_DeliveryFormat(SmtpDeliveryFormat value) { }

	// RVA: 0x227F5E0 Offset: 0x227E7E0 VA: 0x18227F5E0
	public SmtpDeliveryMethod get_DeliveryMethod() { }

	// RVA: 0x227F700 Offset: 0x227E900 VA: 0x18227F700
	public void set_DeliveryMethod(SmtpDeliveryMethod value) { }

	// RVA: 0x227F610 Offset: 0x227E810 VA: 0x18227F610
	public string get_From() { }

	// RVA: 0x227F730 Offset: 0x227E930 VA: 0x18227F730
	public void set_From(string value) { }

	// RVA: 0x227F640 Offset: 0x227E840 VA: 0x18227F640
	public SmtpNetworkElement get_Network() { }

	// RVA: 0x227F670 Offset: 0x227E870 VA: 0x18227F670 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x227F6A0 Offset: 0x227E8A0 VA: 0x18227F6A0
	public SmtpSpecifiedPickupDirectoryElement get_SpecifiedPickupDirectory() { }
}

// Namespace: System.Net.Configuration
public sealed class SmtpNetworkElement : ConfigurationElement // TypeDefIndex: 6518
{
	// Properties
	public string ClientDomain { get; set; }
	public bool DefaultCredentials { get; set; }
	public bool EnableSsl { get; set; }
	public string Host { get; set; }
	public string Password { get; set; }
	public int Port { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public string TargetName { get; set; }
	public string UserName { get; set; }

	// Methods

	// RVA: 0x227EFB0 Offset: 0x227E1B0 VA: 0x18227EFB0
	public void .ctor() { }

	// RVA: 0x227EFE0 Offset: 0x227E1E0 VA: 0x18227EFE0
	public string get_ClientDomain() { }

	// RVA: 0x227F190 Offset: 0x227E390 VA: 0x18227F190
	public void set_ClientDomain(string value) { }

	// RVA: 0x227F010 Offset: 0x227E210 VA: 0x18227F010
	public bool get_DefaultCredentials() { }

	// RVA: 0x227F1C0 Offset: 0x227E3C0 VA: 0x18227F1C0
	public void set_DefaultCredentials(bool value) { }

	// RVA: 0x227F040 Offset: 0x227E240 VA: 0x18227F040
	public bool get_EnableSsl() { }

	// RVA: 0x227F1F0 Offset: 0x227E3F0 VA: 0x18227F1F0
	public void set_EnableSsl(bool value) { }

	// RVA: 0x227F070 Offset: 0x227E270 VA: 0x18227F070
	public string get_Host() { }

	// RVA: 0x227F220 Offset: 0x227E420 VA: 0x18227F220
	public void set_Host(string value) { }

	// RVA: 0x227F0A0 Offset: 0x227E2A0 VA: 0x18227F0A0
	public string get_Password() { }

	// RVA: 0x227F250 Offset: 0x227E450 VA: 0x18227F250
	public void set_Password(string value) { }

	// RVA: 0x227F0D0 Offset: 0x227E2D0 VA: 0x18227F0D0
	public int get_Port() { }

	// RVA: 0x227F280 Offset: 0x227E480 VA: 0x18227F280
	public void set_Port(int value) { }

	// RVA: 0x227F100 Offset: 0x227E300 VA: 0x18227F100 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x227F130 Offset: 0x227E330 VA: 0x18227F130
	public string get_TargetName() { }

	// RVA: 0x227F2B0 Offset: 0x227E4B0 VA: 0x18227F2B0
	public void set_TargetName(string value) { }

	// RVA: 0x227F160 Offset: 0x227E360 VA: 0x18227F160
	public string get_UserName() { }

	// RVA: 0x227F2E0 Offset: 0x227E4E0 VA: 0x18227F2E0
	public void set_UserName(string value) { }

	// RVA: 0x227EF80 Offset: 0x227E180 VA: 0x18227EF80 Slot: 8
	protected override void PostDeserialize() { }
}

// Namespace: System.Net.Configuration
public sealed class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement // TypeDefIndex: 6519
{
	// Properties
	public string PickupDirectoryLocation { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x227F760 Offset: 0x227E960 VA: 0x18227F760
	public void .ctor() { }

	// RVA: 0x227F790 Offset: 0x227E990 VA: 0x18227F790
	public string get_PickupDirectoryLocation() { }

	// RVA: 0x227F7F0 Offset: 0x227E9F0 VA: 0x18227F7F0
	public void set_PickupDirectoryLocation(string value) { }

	// RVA: 0x227F7C0 Offset: 0x227E9C0 VA: 0x18227F7C0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class NetSectionGroup : ConfigurationSectionGroup // TypeDefIndex: 6520
{
	// Properties
	public AuthenticationModulesSection AuthenticationModules { get; }
	public ConnectionManagementSection ConnectionManagement { get; }
	public DefaultProxySection DefaultProxy { get; }
	public MailSettingsSectionGroup MailSettings { get; }
	public RequestCachingSection RequestCaching { get; }
	public SettingsSection Settings { get; }
	public WebRequestModulesSection WebRequestModules { get; }

	// Methods

	// RVA: 0x2279740 Offset: 0x2278940 VA: 0x182279740
	public void .ctor() { }

	// RVA: 0x2279770 Offset: 0x2278970 VA: 0x182279770
	public AuthenticationModulesSection get_AuthenticationModules() { }

	// RVA: 0x22797A0 Offset: 0x22789A0 VA: 0x1822797A0
	public ConnectionManagementSection get_ConnectionManagement() { }

	// RVA: 0x22797D0 Offset: 0x22789D0 VA: 0x1822797D0
	public DefaultProxySection get_DefaultProxy() { }

	// RVA: 0x2279800 Offset: 0x2278A00 VA: 0x182279800
	public MailSettingsSectionGroup get_MailSettings() { }

	// RVA: 0x2279830 Offset: 0x2278A30 VA: 0x182279830
	public RequestCachingSection get_RequestCaching() { }

	// RVA: 0x2279860 Offset: 0x2278A60 VA: 0x182279860
	public SettingsSection get_Settings() { }

	// RVA: 0x2279890 Offset: 0x2278A90 VA: 0x182279890
	public WebRequestModulesSection get_WebRequestModules() { }

	// RVA: 0x2279710 Offset: 0x2278910 VA: 0x182279710
	public static NetSectionGroup GetSectionGroup(Configuration config) { }
}

// Namespace: System.Net.Configuration
public sealed class RequestCachingSection : ConfigurationSection // TypeDefIndex: 6521
{
	// Properties
	public FtpCachePolicyElement DefaultFtpCachePolicy { get; }
	public HttpCachePolicyElement DefaultHttpCachePolicy { get; }
	public RequestCacheLevel DefaultPolicyLevel { get; set; }
	public bool DisableAllCaching { get; set; }
	public bool IsPrivateCache { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public TimeSpan UnspecifiedMaximumAge { get; set; }

	// Methods

	// RVA: 0x227AED0 Offset: 0x227A0D0 VA: 0x18227AED0
	public void .ctor() { }

	// RVA: 0x227AF00 Offset: 0x227A100 VA: 0x18227AF00
	public FtpCachePolicyElement get_DefaultFtpCachePolicy() { }

	// RVA: 0x227AF30 Offset: 0x227A130 VA: 0x18227AF30
	public HttpCachePolicyElement get_DefaultHttpCachePolicy() { }

	// RVA: 0x227AF60 Offset: 0x227A160 VA: 0x18227AF60
	public RequestCacheLevel get_DefaultPolicyLevel() { }

	// RVA: 0x227B050 Offset: 0x227A250 VA: 0x18227B050
	public void set_DefaultPolicyLevel(RequestCacheLevel value) { }

	// RVA: 0x227AF90 Offset: 0x227A190 VA: 0x18227AF90
	public bool get_DisableAllCaching() { }

	// RVA: 0x227B080 Offset: 0x227A280 VA: 0x18227B080
	public void set_DisableAllCaching(bool value) { }

	// RVA: 0x227AFC0 Offset: 0x227A1C0 VA: 0x18227AFC0
	public bool get_IsPrivateCache() { }

	// RVA: 0x227B0B0 Offset: 0x227A2B0 VA: 0x18227B0B0
	public void set_IsPrivateCache(bool value) { }

	// RVA: 0x227AFF0 Offset: 0x227A1F0 VA: 0x18227AFF0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x227B020 Offset: 0x227A220 VA: 0x18227B020
	public TimeSpan get_UnspecifiedMaximumAge() { }

	// RVA: 0x227B0E0 Offset: 0x227A2E0 VA: 0x18227B0E0
	public void set_UnspecifiedMaximumAge(TimeSpan value) { }

	// RVA: 0x227AE70 Offset: 0x227A070 VA: 0x18227AE70 Slot: 5
	protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey) { }

	// RVA: 0x227AEA0 Offset: 0x227A0A0 VA: 0x18227AEA0 Slot: 8
	protected override void PostDeserialize() { }
}

// Namespace: System.Net.Configuration
public sealed class SettingsSection : ConfigurationSection // TypeDefIndex: 6522
{
	// Properties
	public HttpListenerElement HttpListener { get; }
	public HttpWebRequestElement HttpWebRequest { get; }
	public Ipv6Element Ipv6 { get; }
	public PerformanceCountersElement PerformanceCounters { get; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public ServicePointManagerElement ServicePointManager { get; }
	public SocketElement Socket { get; }
	public WebProxyScriptElement WebProxyScript { get; }
	public WebUtilityElement WebUtility { get; }
	public WindowsAuthenticationElement WindowsAuthentication { get; }

	// Methods

	// RVA: 0x227ECE0 Offset: 0x227DEE0 VA: 0x18227ECE0
	public void .ctor() { }

	// RVA: 0x227ED10 Offset: 0x227DF10 VA: 0x18227ED10
	public HttpListenerElement get_HttpListener() { }

	// RVA: 0x227ED40 Offset: 0x227DF40 VA: 0x18227ED40
	public HttpWebRequestElement get_HttpWebRequest() { }

	// RVA: 0x227ED70 Offset: 0x227DF70 VA: 0x18227ED70
	public Ipv6Element get_Ipv6() { }

	// RVA: 0x227EDA0 Offset: 0x227DFA0 VA: 0x18227EDA0
	public PerformanceCountersElement get_PerformanceCounters() { }

	// RVA: 0x227EDD0 Offset: 0x227DFD0 VA: 0x18227EDD0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x227EE00 Offset: 0x227E000 VA: 0x18227EE00
	public ServicePointManagerElement get_ServicePointManager() { }

	// RVA: 0x227EE30 Offset: 0x227E030 VA: 0x18227EE30
	public SocketElement get_Socket() { }

	// RVA: 0x227EE60 Offset: 0x227E060 VA: 0x18227EE60
	public WebProxyScriptElement get_WebProxyScript() { }

	// RVA: 0x227EE90 Offset: 0x227E090 VA: 0x18227EE90
	public WebUtilityElement get_WebUtility() { }

	// RVA: 0x227EEC0 Offset: 0x227E0C0 VA: 0x18227EEC0
	public WindowsAuthenticationElement get_WindowsAuthentication() { }
}

// Namespace: System.Net.Configuration
public sealed class PerformanceCountersElement : ConfigurationElement // TypeDefIndex: 6523
{
	// Properties
	public bool Enabled { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x227A910 Offset: 0x2279B10 VA: 0x18227A910
	public void .ctor() { }

	// RVA: 0x227A940 Offset: 0x2279B40 VA: 0x18227A940
	public bool get_Enabled() { }

	// RVA: 0x227A9A0 Offset: 0x2279BA0 VA: 0x18227A9A0
	public void set_Enabled(bool value) { }

	// RVA: 0x227A970 Offset: 0x2279B70 VA: 0x18227A970 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class ServicePointManagerElement : ConfigurationElement // TypeDefIndex: 6524
{
	// Properties
	public bool CheckCertificateName { get; set; }
	public bool CheckCertificateRevocationList { get; set; }
	public int DnsRefreshTimeout { get; set; }
	public bool EnableDnsRoundRobin { get; set; }
	public EncryptionPolicy EncryptionPolicy { get; set; }
	public bool Expect100Continue { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public bool UseNagleAlgorithm { get; set; }

	// Methods

	// RVA: 0x227CB20 Offset: 0x227BD20 VA: 0x18227CB20
	public void .ctor() { }

	// RVA: 0x227CB50 Offset: 0x227BD50 VA: 0x18227CB50
	public bool get_CheckCertificateName() { }

	// RVA: 0x227CCD0 Offset: 0x227BED0 VA: 0x18227CCD0
	public void set_CheckCertificateName(bool value) { }

	// RVA: 0x227CB80 Offset: 0x227BD80 VA: 0x18227CB80
	public bool get_CheckCertificateRevocationList() { }

	// RVA: 0x227CD00 Offset: 0x227BF00 VA: 0x18227CD00
	public void set_CheckCertificateRevocationList(bool value) { }

	// RVA: 0x227CBB0 Offset: 0x227BDB0 VA: 0x18227CBB0
	public int get_DnsRefreshTimeout() { }

	// RVA: 0x227CD30 Offset: 0x227BF30 VA: 0x18227CD30
	public void set_DnsRefreshTimeout(int value) { }

	// RVA: 0x227CBE0 Offset: 0x227BDE0 VA: 0x18227CBE0
	public bool get_EnableDnsRoundRobin() { }

	// RVA: 0x227CD60 Offset: 0x227BF60 VA: 0x18227CD60
	public void set_EnableDnsRoundRobin(bool value) { }

	// RVA: 0x227CC10 Offset: 0x227BE10 VA: 0x18227CC10
	public EncryptionPolicy get_EncryptionPolicy() { }

	// RVA: 0x227CD90 Offset: 0x227BF90 VA: 0x18227CD90
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x227CC40 Offset: 0x227BE40 VA: 0x18227CC40
	public bool get_Expect100Continue() { }

	// RVA: 0x227CDC0 Offset: 0x227BFC0 VA: 0x18227CDC0
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x227CC70 Offset: 0x227BE70 VA: 0x18227CC70 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x227CCA0 Offset: 0x227BEA0 VA: 0x18227CCA0
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x227CDF0 Offset: 0x227BFF0 VA: 0x18227CDF0
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x227CAF0 Offset: 0x227BCF0 VA: 0x18227CAF0 Slot: 8
	protected override void PostDeserialize() { }
}

// Namespace: System.Net.Configuration
public sealed class SocketElement : ConfigurationElement // TypeDefIndex: 6525
{
	// Properties
	public bool AlwaysUseCompletionPortsForAccept { get; set; }
	public bool AlwaysUseCompletionPortsForConnect { get; set; }
	public IPProtectionLevel IPProtectionLevel { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x227F850 Offset: 0x227EA50 VA: 0x18227F850
	public void .ctor() { }

	// RVA: 0x227F880 Offset: 0x227EA80 VA: 0x18227F880
	public bool get_AlwaysUseCompletionPortsForAccept() { }

	// RVA: 0x227F940 Offset: 0x227EB40 VA: 0x18227F940
	public void set_AlwaysUseCompletionPortsForAccept(bool value) { }

	// RVA: 0x227F8B0 Offset: 0x227EAB0 VA: 0x18227F8B0
	public bool get_AlwaysUseCompletionPortsForConnect() { }

	// RVA: 0x227F970 Offset: 0x227EB70 VA: 0x18227F970
	public void set_AlwaysUseCompletionPortsForConnect(bool value) { }

	// RVA: 0x227F8E0 Offset: 0x227EAE0 VA: 0x18227F8E0
	public IPProtectionLevel get_IPProtectionLevel() { }

	// RVA: 0x227F9A0 Offset: 0x227EBA0 VA: 0x18227F9A0
	public void set_IPProtectionLevel(IPProtectionLevel value) { }

	// RVA: 0x227F910 Offset: 0x227EB10 VA: 0x18227F910 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x227F820 Offset: 0x227EA20 VA: 0x18227F820 Slot: 8
	protected override void PostDeserialize() { }
}

// Namespace: System.Net.Configuration
public sealed class WebProxyScriptElement : ConfigurationElement // TypeDefIndex: 6526
{
	// Properties
	public int AutoConfigUrlRetryInterval { get; set; }
	public TimeSpan DownloadTimeout { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x2284190 Offset: 0x2283390 VA: 0x182284190
	public void .ctor() { }

	// RVA: 0x22841C0 Offset: 0x22833C0 VA: 0x1822841C0
	public int get_AutoConfigUrlRetryInterval() { }

	// RVA: 0x2284250 Offset: 0x2283450 VA: 0x182284250
	public void set_AutoConfigUrlRetryInterval(int value) { }

	// RVA: 0x22841F0 Offset: 0x22833F0 VA: 0x1822841F0
	public TimeSpan get_DownloadTimeout() { }

	// RVA: 0x2284280 Offset: 0x2283480 VA: 0x182284280
	public void set_DownloadTimeout(TimeSpan value) { }

	// RVA: 0x2284220 Offset: 0x2283420 VA: 0x182284220 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x2284160 Offset: 0x2283360 VA: 0x182284160 Slot: 8
	protected override void PostDeserialize() { }
}

// Namespace: System.Net.Configuration
public sealed class WebUtilityElement : ConfigurationElement // TypeDefIndex: 6527
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }
	public UnicodeDecodingConformance UnicodeDecodingConformance { get; set; }
	public UnicodeEncodingConformance UnicodeEncodingConformance { get; set; }

	// Methods

	// RVA: 0x2284790 Offset: 0x2283990 VA: 0x182284790
	public void .ctor() { }

	// RVA: 0x22847C0 Offset: 0x22839C0 VA: 0x1822847C0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x22847F0 Offset: 0x22839F0 VA: 0x1822847F0
	public UnicodeDecodingConformance get_UnicodeDecodingConformance() { }

	// RVA: 0x2284850 Offset: 0x2283A50 VA: 0x182284850
	public void set_UnicodeDecodingConformance(UnicodeDecodingConformance value) { }

	// RVA: 0x2284820 Offset: 0x2283A20 VA: 0x182284820
	public UnicodeEncodingConformance get_UnicodeEncodingConformance() { }

	// RVA: 0x2284880 Offset: 0x2283A80 VA: 0x182284880
	public void set_UnicodeEncodingConformance(UnicodeEncodingConformance value) { }
}

// Namespace: System.Net.Configuration
public sealed class WindowsAuthenticationElement : ConfigurationElement // TypeDefIndex: 6528
{
	// Properties
	public int DefaultCredentialsHandleCacheSize { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x22848B0 Offset: 0x2283AB0 VA: 0x1822848B0
	public void .ctor() { }

	// RVA: 0x22848E0 Offset: 0x2283AE0 VA: 0x1822848E0
	public int get_DefaultCredentialsHandleCacheSize() { }

	// RVA: 0x2284940 Offset: 0x2283B40 VA: 0x182284940
	public void set_DefaultCredentialsHandleCacheSize(int value) { }

	// RVA: 0x2284910 Offset: 0x2283B10 VA: 0x182284910 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class WebRequestModulesSection : ConfigurationSection // TypeDefIndex: 6529
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }
	public WebRequestModuleElementCollection WebRequestModules { get; }

	// Methods

	// RVA: 0x2284700 Offset: 0x2283900 VA: 0x182284700
	public void .ctor() { }

	// RVA: 0x2284730 Offset: 0x2283930 VA: 0x182284730 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x2284760 Offset: 0x2283960 VA: 0x182284760
	public WebRequestModuleElementCollection get_WebRequestModules() { }

	// RVA: 0x22846A0 Offset: 0x22838A0 VA: 0x1822846A0 Slot: 6
	protected override void InitializeDefault() { }

	// RVA: 0x22846D0 Offset: 0x22838D0 VA: 0x1822846D0 Slot: 8
	protected override void PostDeserialize() { }
}

// Namespace: System.Net.Configuration
[ConfigurationCollection(typeof(WebRequestModuleElement))]
[DefaultMember("Item")]
public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection // TypeDefIndex: 6530
{
	// Properties
	public WebRequestModuleElement Item { get; set; }

	// Methods

	// RVA: 0x2284430 Offset: 0x2283630 VA: 0x182284430
	public void .ctor() { }

	// RVA: 0x2284490 Offset: 0x2283690 VA: 0x182284490
	public WebRequestModuleElement get_Item(int index) { }

	// RVA: 0x22844C0 Offset: 0x22836C0 VA: 0x1822844C0
	public void set_Item(int index, WebRequestModuleElement value) { }

	// RVA: 0x2284460 Offset: 0x2283660 VA: 0x182284460
	public WebRequestModuleElement get_Item(string name) { }

	// RVA: 0x22844F0 Offset: 0x22836F0 VA: 0x1822844F0
	public void set_Item(string name, WebRequestModuleElement value) { }

	// RVA: 0x22842B0 Offset: 0x22834B0 VA: 0x1822842B0
	public void Add(WebRequestModuleElement element) { }

	// RVA: 0x22842E0 Offset: 0x22834E0 VA: 0x1822842E0
	public void Clear() { }

	// RVA: 0x2284310 Offset: 0x2283510 VA: 0x182284310 Slot: 16
	protected override ConfigurationElement CreateNewElement() { }

	// RVA: 0x2284340 Offset: 0x2283540 VA: 0x182284340 Slot: 17
	protected override object GetElementKey(ConfigurationElement element) { }

	// RVA: 0x2284370 Offset: 0x2283570 VA: 0x182284370
	public int IndexOf(WebRequestModuleElement element) { }

	// RVA: 0x22843D0 Offset: 0x22835D0 VA: 0x1822843D0
	public void Remove(WebRequestModuleElement element) { }

	// RVA: 0x2284400 Offset: 0x2283600 VA: 0x182284400
	public void Remove(string name) { }

	// RVA: 0x22843A0 Offset: 0x22835A0 VA: 0x1822843A0
	public void RemoveAt(int index) { }
}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElement : ConfigurationElement // TypeDefIndex: 6531
{
	// Properties
	public string Prefix { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public Type Type { get; set; }

	// Methods

	// RVA: 0x2284550 Offset: 0x2283750 VA: 0x182284550
	public void .ctor() { }

	// RVA: 0x2284520 Offset: 0x2283720 VA: 0x182284520
	public void .ctor(string prefix, string type) { }

	// RVA: 0x2284580 Offset: 0x2283780 VA: 0x182284580
	public void .ctor(string prefix, Type type) { }

	// RVA: 0x22845B0 Offset: 0x22837B0 VA: 0x1822845B0
	public string get_Prefix() { }

	// RVA: 0x2284640 Offset: 0x2283840 VA: 0x182284640
	public void set_Prefix(string value) { }

	// RVA: 0x22845E0 Offset: 0x22837E0 VA: 0x1822845E0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x2284610 Offset: 0x2283810 VA: 0x182284610
	public Type get_Type() { }

	// RVA: 0x2284670 Offset: 0x2283870 VA: 0x182284670
	public void set_Type(Type value) { }
}

// Namespace: System.Media
[ToolboxItem(False)]
[Serializable]
public class SoundPlayer : Component, ISerializable // TypeDefIndex: 6532
{
	// Properties
	public bool IsLoadCompleted { get; }
	public int LoadTimeout { get; set; }
	public string SoundLocation { get; set; }
	public Stream Stream { get; set; }
	public object Tag { get; set; }

	// Methods

	// RVA: 0x227FC10 Offset: 0x227EE10 VA: 0x18227FC10
	public void .ctor() { }

	// RVA: 0x227FBB0 Offset: 0x227EDB0 VA: 0x18227FBB0
	public void .ctor(Stream stream) { }

	// RVA: 0x227FC40 Offset: 0x227EE40 VA: 0x18227FC40
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext context) { }

	// RVA: 0x227FBE0 Offset: 0x227EDE0 VA: 0x18227FBE0
	public void .ctor(string soundLocation) { }

	// RVA: 0x227FD00 Offset: 0x227EF00 VA: 0x18227FD00
	public bool get_IsLoadCompleted() { }

	// RVA: 0x227FD30 Offset: 0x227EF30 VA: 0x18227FD30
	public int get_LoadTimeout() { }

	// RVA: 0x227FE80 Offset: 0x227F080 VA: 0x18227FE80
	public void set_LoadTimeout(int value) { }

	// RVA: 0x227FD60 Offset: 0x227EF60 VA: 0x18227FD60
	public string get_SoundLocation() { }

	// RVA: 0x227FEB0 Offset: 0x227F0B0 VA: 0x18227FEB0
	public void set_SoundLocation(string value) { }

	// RVA: 0x227FD90 Offset: 0x227EF90 VA: 0x18227FD90
	public Stream get_Stream() { }

	// RVA: 0x227FEE0 Offset: 0x227F0E0 VA: 0x18227FEE0
	public void set_Stream(Stream value) { }

	// RVA: 0x227FDC0 Offset: 0x227EFC0 VA: 0x18227FDC0
	public object get_Tag() { }

	// RVA: 0x227FF10 Offset: 0x227F110 VA: 0x18227FF10
	public void set_Tag(object value) { }

	// RVA: 0x227FC70 Offset: 0x227EE70 VA: 0x18227FC70
	public void add_LoadCompleted(AsyncCompletedEventHandler value) { }

	// RVA: 0x227FDF0 Offset: 0x227EFF0 VA: 0x18227FDF0
	public void remove_LoadCompleted(AsyncCompletedEventHandler value) { }

	// RVA: 0x227FCA0 Offset: 0x227EEA0 VA: 0x18227FCA0
	public void add_SoundLocationChanged(EventHandler value) { }

	// RVA: 0x227FE20 Offset: 0x227F020 VA: 0x18227FE20
	public void remove_SoundLocationChanged(EventHandler value) { }

	// RVA: 0x227FCD0 Offset: 0x227EED0 VA: 0x18227FCD0
	public void add_StreamChanged(EventHandler value) { }

	// RVA: 0x227FE50 Offset: 0x227F050 VA: 0x18227FE50
	public void remove_StreamChanged(EventHandler value) { }

	// RVA: 0x227FA00 Offset: 0x227EC00 VA: 0x18227FA00
	public void Load() { }

	// RVA: 0x227F9D0 Offset: 0x227EBD0 VA: 0x18227F9D0
	public void LoadAsync() { }

	// RVA: 0x227FA30 Offset: 0x227EC30 VA: 0x18227FA30 Slot: 17
	protected virtual void OnLoadCompleted(AsyncCompletedEventArgs e) { }

	// RVA: 0x227FA60 Offset: 0x227EC60 VA: 0x18227FA60 Slot: 18
	protected virtual void OnSoundLocationChanged(EventArgs e) { }

	// RVA: 0x227FA90 Offset: 0x227EC90 VA: 0x18227FA90 Slot: 19
	protected virtual void OnStreamChanged(EventArgs e) { }

	// RVA: 0x227FB20 Offset: 0x227ED20 VA: 0x18227FB20
	public void Play() { }

	// RVA: 0x227FAC0 Offset: 0x227ECC0 VA: 0x18227FAC0
	public void PlayLooping() { }

	// RVA: 0x227FAF0 Offset: 0x227ECF0 VA: 0x18227FAF0
	public void PlaySync() { }

	// RVA: 0x227FB50 Offset: 0x227ED50 VA: 0x18227FB50
	public void Stop() { }

	// RVA: 0x227FB80 Offset: 0x227ED80 VA: 0x18227FB80 Slot: 16
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Media
public class SystemSound // TypeDefIndex: 6533
{
	// Methods

	// RVA: 0x2283470 Offset: 0x2282670 VA: 0x182283470
	internal void .ctor() { }

	// RVA: 0x2283440 Offset: 0x2282640 VA: 0x182283440
	public void Play() { }
}

// Namespace: System.Media
public sealed class SystemSounds // TypeDefIndex: 6534
{
	// Properties
	public static SystemSound Asterisk { get; }
	public static SystemSound Beep { get; }
	public static SystemSound Exclamation { get; }
	public static SystemSound Hand { get; }
	public static SystemSound Question { get; }

	// Methods

	// RVA: 0x22834A0 Offset: 0x22826A0 VA: 0x1822834A0
	internal void .ctor() { }

	// RVA: 0x22834D0 Offset: 0x22826D0 VA: 0x1822834D0
	public static SystemSound get_Asterisk() { }

	// RVA: 0x2283500 Offset: 0x2282700 VA: 0x182283500
	public static SystemSound get_Beep() { }

	// RVA: 0x2283530 Offset: 0x2282730 VA: 0x182283530
	public static SystemSound get_Exclamation() { }

	// RVA: 0x2283560 Offset: 0x2282760 VA: 0x182283560
	public static SystemSound get_Hand() { }

	// RVA: 0x2283590 Offset: 0x2282790 VA: 0x182283590
	public static SystemSound get_Question() { }
}

// Namespace: System.IO.Ports
public enum Handshake // TypeDefIndex: 6535
{
	// Fields
	public int value__; // 0x0
	public const Handshake None = 0;
	public const Handshake RequestToSend = 2;
	public const Handshake RequestToSendXOnXOff = 3;
	public const Handshake XOnXOff = 1;
}

// Namespace: System.IO.Ports
public enum Parity // TypeDefIndex: 6536
{
	// Fields
	public int value__; // 0x0
	public const Parity Even = 2;
	public const Parity Mark = 3;
	public const Parity None = 0;
	public const Parity Odd = 1;
	public const Parity Space = 4;
}

// Namespace: System.IO.Ports
public enum SerialData // TypeDefIndex: 6537
{
	// Fields
	public int value__; // 0x0
	public const SerialData Chars = 1;
	public const SerialData Eof = 2;
}

// Namespace: System.IO.Ports
public class SerialDataReceivedEventArgs : EventArgs // TypeDefIndex: 6538
{
	// Properties
	public SerialData EventType { get; }

	// Methods

	// RVA: 0x227B6E0 Offset: 0x227A8E0 VA: 0x18227B6E0
	internal void .ctor() { }

	// RVA: 0x227B710 Offset: 0x227A910 VA: 0x18227B710
	public SerialData get_EventType() { }
}

// Namespace: System.IO.Ports
public sealed class SerialDataReceivedEventHandler : MulticastDelegate // TypeDefIndex: 6539
{
	// Methods

	// RVA: 0x227B7D0 Offset: 0x227A9D0 VA: 0x18227B7D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x227B7A0 Offset: 0x227A9A0 VA: 0x18227B7A0 Slot: 13
	public virtual void Invoke(object sender, SerialDataReceivedEventArgs e) { }

	// RVA: 0x227B740 Offset: 0x227A940 VA: 0x18227B740 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, SerialDataReceivedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x227B770 Offset: 0x227A970 VA: 0x18227B770 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.IO.Ports
public enum SerialError // TypeDefIndex: 6540
{
	// Fields
	public int value__; // 0x0
	public const SerialError Frame = 8;
	public const SerialError Overrun = 2;
	public const SerialError RXOver = 1;
	public const SerialError RXParity = 4;
	public const SerialError TXFull = 256;
}

// Namespace: System.IO.Ports
public class SerialErrorReceivedEventArgs : EventArgs // TypeDefIndex: 6541
{
	// Properties
	public SerialError EventType { get; }

	// Methods

	// RVA: 0x227B800 Offset: 0x227AA00 VA: 0x18227B800
	internal void .ctor() { }

	// RVA: 0x227B830 Offset: 0x227AA30 VA: 0x18227B830
	public SerialError get_EventType() { }
}

// Namespace: System.IO.Ports
public sealed class SerialErrorReceivedEventHandler : MulticastDelegate // TypeDefIndex: 6542
{
	// Methods

	// RVA: 0x227B8F0 Offset: 0x227AAF0 VA: 0x18227B8F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x227B8C0 Offset: 0x227AAC0 VA: 0x18227B8C0 Slot: 13
	public virtual void Invoke(object sender, SerialErrorReceivedEventArgs e) { }

	// RVA: 0x227B860 Offset: 0x227AA60 VA: 0x18227B860 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, SerialErrorReceivedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x227B890 Offset: 0x227AA90 VA: 0x18227B890 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.IO.Ports
public enum SerialPinChange // TypeDefIndex: 6543
{
	// Fields
	public int value__; // 0x0
	public const SerialPinChange Break = 64;
	public const SerialPinChange CDChanged = 32;
	public const SerialPinChange CtsChanged = 8;
	public const SerialPinChange DsrChanged = 16;
	public const SerialPinChange Ring = 256;
}

// Namespace: System.IO.Ports
public class SerialPinChangedEventArgs : EventArgs // TypeDefIndex: 6544
{
	// Properties
	public SerialPinChange EventType { get; }

	// Methods

	// RVA: 0x227B920 Offset: 0x227AB20 VA: 0x18227B920
	internal void .ctor() { }

	// RVA: 0x227B950 Offset: 0x227AB50 VA: 0x18227B950
	public SerialPinChange get_EventType() { }
}

// Namespace: System.IO.Ports
public sealed class SerialPinChangedEventHandler : MulticastDelegate // TypeDefIndex: 6545
{
	// Methods

	// RVA: 0x227BA10 Offset: 0x227AC10 VA: 0x18227BA10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x227B9E0 Offset: 0x227ABE0 VA: 0x18227B9E0 Slot: 13
	public virtual void Invoke(object sender, SerialPinChangedEventArgs e) { }

	// RVA: 0x227B980 Offset: 0x227AB80 VA: 0x18227B980 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, SerialPinChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x227B9B0 Offset: 0x227ABB0 VA: 0x18227B9B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.IO.Ports
[MonitoringDescription("SerialPortDesc")]
public class SerialPort : Component // TypeDefIndex: 6546
{
	// Fields
	public const int InfiniteTimeout = -1;

	// Properties
	public Stream BaseStream { get; }
	public int BaudRate { get; set; }
	public bool BreakState { get; set; }
	public int BytesToRead { get; }
	public int BytesToWrite { get; }
	public bool CDHolding { get; }
	public bool CtsHolding { get; }
	public int DataBits { get; set; }
	public bool DiscardNull { get; set; }
	public bool DsrHolding { get; }
	public bool DtrEnable { get; set; }
	public Encoding Encoding { get; set; }
	public Handshake Handshake { get; set; }
	public bool IsOpen { get; }
	public string NewLine { get; set; }
	public Parity Parity { get; set; }
	public byte ParityReplace { get; set; }
	public string PortName { get; set; }
	public int ReadBufferSize { get; set; }
	public int ReadTimeout { get; set; }
	public int ReceivedBytesThreshold { get; set; }
	public bool RtsEnable { get; set; }
	public StopBits StopBits { get; set; }
	public int WriteBufferSize { get; set; }
	public int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x227BDA0 Offset: 0x227AFA0 VA: 0x18227BDA0
	public void .ctor() { }

	// RVA: 0x227BE30 Offset: 0x227B030 VA: 0x18227BE30
	public void .ctor(IContainer container) { }

	// RVA: 0x227BD40 Offset: 0x227AF40 VA: 0x18227BD40
	public void .ctor(string portName) { }

	// RVA: 0x227BE60 Offset: 0x227B060 VA: 0x18227BE60
	public void .ctor(string portName, int baudRate) { }

	// RVA: 0x227BE00 Offset: 0x227B000 VA: 0x18227BE00
	public void .ctor(string portName, int baudRate, Parity parity) { }

	// RVA: 0x227BDD0 Offset: 0x227AFD0 VA: 0x18227BDD0
	public void .ctor(string portName, int baudRate, Parity parity, int dataBits) { }

	// RVA: 0x227BD70 Offset: 0x227AF70 VA: 0x18227BD70
	public void .ctor(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) { }

	// RVA: 0x227BF20 Offset: 0x227B120 VA: 0x18227BF20
	public Stream get_BaseStream() { }

	// RVA: 0x227BF50 Offset: 0x227B150 VA: 0x18227BF50
	public int get_BaudRate() { }

	// RVA: 0x227C460 Offset: 0x227B660 VA: 0x18227C460
	public void set_BaudRate(int value) { }

	// RVA: 0x227BF80 Offset: 0x227B180 VA: 0x18227BF80
	public bool get_BreakState() { }

	// RVA: 0x227C490 Offset: 0x227B690 VA: 0x18227C490
	public void set_BreakState(bool value) { }

	// RVA: 0x227BFB0 Offset: 0x227B1B0 VA: 0x18227BFB0
	public int get_BytesToRead() { }

	// RVA: 0x227BFE0 Offset: 0x227B1E0 VA: 0x18227BFE0
	public int get_BytesToWrite() { }

	// RVA: 0x227C010 Offset: 0x227B210 VA: 0x18227C010
	public bool get_CDHolding() { }

	// RVA: 0x227C040 Offset: 0x227B240 VA: 0x18227C040
	public bool get_CtsHolding() { }

	// RVA: 0x227C070 Offset: 0x227B270 VA: 0x18227C070
	public int get_DataBits() { }

	// RVA: 0x227C4C0 Offset: 0x227B6C0 VA: 0x18227C4C0
	public void set_DataBits(int value) { }

	// RVA: 0x227C0A0 Offset: 0x227B2A0 VA: 0x18227C0A0
	public bool get_DiscardNull() { }

	// RVA: 0x227C4F0 Offset: 0x227B6F0 VA: 0x18227C4F0
	public void set_DiscardNull(bool value) { }

	// RVA: 0x227C0D0 Offset: 0x227B2D0 VA: 0x18227C0D0
	public bool get_DsrHolding() { }

	// RVA: 0x227C100 Offset: 0x227B300 VA: 0x18227C100
	public bool get_DtrEnable() { }

	// RVA: 0x227C520 Offset: 0x227B720 VA: 0x18227C520
	public void set_DtrEnable(bool value) { }

	// RVA: 0x227C130 Offset: 0x227B330 VA: 0x18227C130
	public Encoding get_Encoding() { }

	// RVA: 0x227C550 Offset: 0x227B750 VA: 0x18227C550
	public void set_Encoding(Encoding value) { }

	// RVA: 0x227C160 Offset: 0x227B360 VA: 0x18227C160
	public Handshake get_Handshake() { }

	// RVA: 0x227C580 Offset: 0x227B780 VA: 0x18227C580
	public void set_Handshake(Handshake value) { }

	// RVA: 0x227C190 Offset: 0x227B390 VA: 0x18227C190
	public bool get_IsOpen() { }

	// RVA: 0x227C1C0 Offset: 0x227B3C0 VA: 0x18227C1C0
	public string get_NewLine() { }

	// RVA: 0x227C5B0 Offset: 0x227B7B0 VA: 0x18227C5B0
	public void set_NewLine(string value) { }

	// RVA: 0x227C220 Offset: 0x227B420 VA: 0x18227C220
	public Parity get_Parity() { }

	// RVA: 0x227C610 Offset: 0x227B810 VA: 0x18227C610
	public void set_Parity(Parity value) { }

	// RVA: 0x227C1F0 Offset: 0x227B3F0 VA: 0x18227C1F0
	public byte get_ParityReplace() { }

	// RVA: 0x227C5E0 Offset: 0x227B7E0 VA: 0x18227C5E0
	public void set_ParityReplace(byte value) { }

	// RVA: 0x227C250 Offset: 0x227B450 VA: 0x18227C250
	public string get_PortName() { }

	// RVA: 0x227C640 Offset: 0x227B840 VA: 0x18227C640
	public void set_PortName(string value) { }

	// RVA: 0x227C280 Offset: 0x227B480 VA: 0x18227C280
	public int get_ReadBufferSize() { }

	// RVA: 0x227C670 Offset: 0x227B870 VA: 0x18227C670
	public void set_ReadBufferSize(int value) { }

	// RVA: 0x227C2B0 Offset: 0x227B4B0 VA: 0x18227C2B0
	public int get_ReadTimeout() { }

	// RVA: 0x227C6A0 Offset: 0x227B8A0 VA: 0x18227C6A0
	public void set_ReadTimeout(int value) { }

	// RVA: 0x227C2E0 Offset: 0x227B4E0 VA: 0x18227C2E0
	public int get_ReceivedBytesThreshold() { }

	// RVA: 0x227C6D0 Offset: 0x227B8D0 VA: 0x18227C6D0
	public void set_ReceivedBytesThreshold(int value) { }

	// RVA: 0x227C310 Offset: 0x227B510 VA: 0x18227C310
	public bool get_RtsEnable() { }

	// RVA: 0x227C700 Offset: 0x227B900 VA: 0x18227C700
	public void set_RtsEnable(bool value) { }

	// RVA: 0x227C340 Offset: 0x227B540 VA: 0x18227C340
	public StopBits get_StopBits() { }

	// RVA: 0x227C730 Offset: 0x227B930 VA: 0x18227C730
	public void set_StopBits(StopBits value) { }

	// RVA: 0x227C370 Offset: 0x227B570 VA: 0x18227C370
	public int get_WriteBufferSize() { }

	// RVA: 0x227C760 Offset: 0x227B960 VA: 0x18227C760
	public void set_WriteBufferSize(int value) { }

	// RVA: 0x227C3A0 Offset: 0x227B5A0 VA: 0x18227C3A0
	public int get_WriteTimeout() { }

	// RVA: 0x227C790 Offset: 0x227B990 VA: 0x18227C790
	public void set_WriteTimeout(int value) { }

	// RVA: 0x227BE90 Offset: 0x227B090 VA: 0x18227BE90
	public void add_DataReceived(SerialDataReceivedEventHandler value) { }

	// RVA: 0x227C3D0 Offset: 0x227B5D0 VA: 0x18227C3D0
	public void remove_DataReceived(SerialDataReceivedEventHandler value) { }

	// RVA: 0x227BEC0 Offset: 0x227B0C0 VA: 0x18227BEC0
	public void add_ErrorReceived(SerialErrorReceivedEventHandler value) { }

	// RVA: 0x227C400 Offset: 0x227B600 VA: 0x18227C400
	public void remove_ErrorReceived(SerialErrorReceivedEventHandler value) { }

	// RVA: 0x227BEF0 Offset: 0x227B0F0 VA: 0x18227BEF0
	public void add_PinChanged(SerialPinChangedEventHandler value) { }

	// RVA: 0x227C430 Offset: 0x227B630 VA: 0x18227C430
	public void remove_PinChanged(SerialPinChangedEventHandler value) { }

	// RVA: 0x227BA40 Offset: 0x227AC40 VA: 0x18227BA40
	public void Close() { }

	// RVA: 0x227BA70 Offset: 0x227AC70 VA: 0x18227BA70
	public void DiscardInBuffer() { }

	// RVA: 0x227BAA0 Offset: 0x227ACA0 VA: 0x18227BAA0
	public void DiscardOutBuffer() { }

	// RVA: 0x227BAD0 Offset: 0x227ACD0 VA: 0x18227BAD0
	public static string[] GetPortNames() { }

	// RVA: 0x227BB00 Offset: 0x227AD00 VA: 0x18227BB00
	public void Open() { }

	// RVA: 0x227BC50 Offset: 0x227AE50 VA: 0x18227BC50
	public int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x227BC20 Offset: 0x227AE20 VA: 0x18227BC20
	public int Read(char[] buffer, int offset, int count) { }

	// RVA: 0x227BB30 Offset: 0x227AD30 VA: 0x18227BB30
	public int ReadByte() { }

	// RVA: 0x227BB60 Offset: 0x227AD60 VA: 0x18227BB60
	public int ReadChar() { }

	// RVA: 0x227BB90 Offset: 0x227AD90 VA: 0x18227BB90
	public string ReadExisting() { }

	// RVA: 0x227BBC0 Offset: 0x227ADC0 VA: 0x18227BBC0
	public string ReadLine() { }

	// RVA: 0x227BBF0 Offset: 0x227ADF0 VA: 0x18227BBF0
	public string ReadTo(string value) { }

	// RVA: 0x227BD10 Offset: 0x227AF10 VA: 0x18227BD10
	public void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x227BCB0 Offset: 0x227AEB0 VA: 0x18227BCB0
	public void Write(char[] buffer, int offset, int count) { }

	// RVA: 0x227BCE0 Offset: 0x227AEE0 VA: 0x18227BCE0
	public void Write(string text) { }

	// RVA: 0x227BC80 Offset: 0x227AE80 VA: 0x18227BC80
	public void WriteLine(string text) { }
}

// Namespace: System.IO.Ports
public enum StopBits // TypeDefIndex: 6547
{
	// Fields
	public int value__; // 0x0
	public const StopBits None = 0;
	public const StopBits One = 1;
	public const StopBits OnePointFive = 3;
	public const StopBits Two = 2;
}

// Namespace: System.Diagnostics
public class ConsoleTraceListener : TextWriterTraceListener // TypeDefIndex: 6548
{
	// Methods

	// RVA: 0x2274B50 Offset: 0x2273D50 VA: 0x182274B50
	public void .ctor() { }

	// RVA: 0x2274B20 Offset: 0x2273D20 VA: 0x182274B20
	public void .ctor(bool useErrorStream) { }
}

// Namespace: System.Diagnostics
public struct CounterSample // TypeDefIndex: 6549
{
	// Fields
	public static CounterSample Empty; // 0x0

	// Properties
	public long BaseValue { get; }
	public long CounterFrequency { get; }
	public long CounterTimeStamp { get; }
	public PerformanceCounterType CounterType { get; }
	public long RawValue { get; }
	public long SystemFrequency { get; }
	public long TimeStamp { get; }
	public long TimeStamp100nSec { get; }

	// Methods

	// RVA: 0x2275060 Offset: 0x2274260 VA: 0x182275060
	public void .ctor(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType) { }

	// RVA: 0x2275090 Offset: 0x2274290 VA: 0x182275090
	public void .ctor(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType, long counterTimeStamp) { }

	// RVA: 0x22750C0 Offset: 0x22742C0 VA: 0x1822750C0
	public long get_BaseValue() { }

	// RVA: 0x22750F0 Offset: 0x22742F0 VA: 0x1822750F0
	public long get_CounterFrequency() { }

	// RVA: 0x2275120 Offset: 0x2274320 VA: 0x182275120
	public long get_CounterTimeStamp() { }

	// RVA: 0x2275150 Offset: 0x2274350 VA: 0x182275150
	public PerformanceCounterType get_CounterType() { }

	// RVA: 0x2275180 Offset: 0x2274380 VA: 0x182275180
	public long get_RawValue() { }

	// RVA: 0x22751B0 Offset: 0x22743B0 VA: 0x1822751B0
	public long get_SystemFrequency() { }

	// RVA: 0x2275210 Offset: 0x2274410 VA: 0x182275210
	public long get_TimeStamp() { }

	// RVA: 0x22751E0 Offset: 0x22743E0 VA: 0x1822751E0
	public long get_TimeStamp100nSec() { }

	// RVA: 0x2275000 Offset: 0x2274200 VA: 0x182275000
	public static float Calculate(CounterSample counterSample) { }

	// RVA: 0x2274FD0 Offset: 0x22741D0 VA: 0x182274FD0
	public static float Calculate(CounterSample counterSample, CounterSample nextCounterSample) { }

	// RVA: 0x2275030 Offset: 0x2274230 VA: 0x182275030
	public bool Equals(CounterSample sample) { }

	// RVA: 0x2275240 Offset: 0x2274440 VA: 0x182275240
	public static bool op_Equality(CounterSample a, CounterSample b) { }

	// RVA: 0x2275270 Offset: 0x2274470 VA: 0x182275270
	public static bool op_Inequality(CounterSample a, CounterSample b) { }
}

// Namespace: System.Diagnostics
public static class CounterSampleCalculator // TypeDefIndex: 6550
{
	// Methods

	// RVA: 0x2274F70 Offset: 0x2274170 VA: 0x182274F70
	public static float ComputeCounterValue(CounterSample newSample) { }

	// RVA: 0x2274FA0 Offset: 0x22741A0 VA: 0x182274FA0
	public static float ComputeCounterValue(CounterSample oldSample, CounterSample newSample) { }
}

// Namespace: System.Diagnostics
[Obsolete("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler // TypeDefIndex: 6551
{
	// Methods

	// RVA: 0x2275510 Offset: 0x2274710 VA: 0x182275510
	public void .ctor() { }

	// RVA: 0x22754E0 Offset: 0x22746E0 VA: 0x1822754E0 Slot: 5
	public virtual object Create(object parent, object configContext, XmlNode section) { }
}

// Namespace: System.Diagnostics
[Serializable]
public sealed class EventLogPermission : ResourcePermissionBase // TypeDefIndex: 6552
{
	// Properties
	public EventLogPermissionEntryCollection PermissionEntries { get; }

	// Methods

	// RVA: 0x2276260 Offset: 0x2275460 VA: 0x182276260
	public void .ctor() { }

	// RVA: 0x2276290 Offset: 0x2275490 VA: 0x182276290
	public void .ctor(EventLogPermissionAccess permissionAccess, string machineName) { }

	// RVA: 0x22762F0 Offset: 0x22754F0 VA: 0x1822762F0
	public void .ctor(EventLogPermissionEntry[] permissionAccessEntries) { }

	// RVA: 0x22762C0 Offset: 0x22754C0 VA: 0x1822762C0
	public void .ctor(PermissionState state) { }

	// RVA: 0x2276320 Offset: 0x2275520 VA: 0x182276320
	public EventLogPermissionEntryCollection get_PermissionEntries() { }
}

// Namespace: System.Diagnostics
[Flags]
public enum EventLogPermissionAccess // TypeDefIndex: 6553
{
	// Fields
	public int value__; // 0x0
	public const EventLogPermissionAccess Administer = 48;
	[Obsolete("This member has been deprecated.  Please use System.Diagnostics.EventLogPermissionAccess.Administer instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public const EventLogPermissionAccess Audit = 10;
	[Obsolete("This member has been deprecated.  Please use System.Diagnostics.EventLogPermissionAccess.Administer instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public const EventLogPermissionAccess Browse = 2;
	[Obsolete("This member has been deprecated.  Please use System.Diagnostics.EventLogPermissionAccess.Write instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public const EventLogPermissionAccess Instrument = 6;
	public const EventLogPermissionAccess None = 0;
	public const EventLogPermissionAccess Write = 16;
}

// Namespace: System.Diagnostics
[Serializable]
public class EventLogPermissionEntry // TypeDefIndex: 6554
{
	// Properties
	public string MachineName { get; }
	public EventLogPermissionAccess PermissionAccess { get; }

	// Methods

	// RVA: 0x22761D0 Offset: 0x22753D0 VA: 0x1822761D0
	public void .ctor(EventLogPermissionAccess permissionAccess, string machineName) { }

	// RVA: 0x2276200 Offset: 0x2275400 VA: 0x182276200
	public string get_MachineName() { }

	// RVA: 0x2276230 Offset: 0x2275430 VA: 0x182276230
	public EventLogPermissionAccess get_PermissionAccess() { }
}

// Namespace: System.Diagnostics
[DefaultMember("Item")]
[Serializable]
public class EventLogPermissionEntryCollection : CollectionBase // TypeDefIndex: 6555
{
	// Properties
	public EventLogPermissionEntry Item { get; set; }

	// Methods

	// RVA: 0x2276140 Offset: 0x2275340 VA: 0x182276140
	internal void .ctor() { }

	// RVA: 0x2276170 Offset: 0x2275370 VA: 0x182276170
	public EventLogPermissionEntry get_Item(int index) { }

	// RVA: 0x22761A0 Offset: 0x22753A0 VA: 0x1822761A0
	public void set_Item(int index, EventLogPermissionEntry value) { }

	// RVA: 0x2276020 Offset: 0x2275220 VA: 0x182276020
	public int Add(EventLogPermissionEntry value) { }

	// RVA: 0x2275FF0 Offset: 0x22751F0 VA: 0x182275FF0
	public void AddRange(EventLogPermissionEntryCollection value) { }

	// RVA: 0x2275FC0 Offset: 0x22751C0 VA: 0x182275FC0
	public void AddRange(EventLogPermissionEntry[] value) { }

	// RVA: 0x2276050 Offset: 0x2275250 VA: 0x182276050
	public bool Contains(EventLogPermissionEntry value) { }

	// RVA: 0x2276080 Offset: 0x2275280 VA: 0x182276080
	public void CopyTo(EventLogPermissionEntry[] array, int index) { }

	// RVA: 0x22760B0 Offset: 0x22752B0 VA: 0x1822760B0
	public int IndexOf(EventLogPermissionEntry value) { }

	// RVA: 0x22760E0 Offset: 0x22752E0 VA: 0x1822760E0
	public void Insert(int index, EventLogPermissionEntry value) { }

	// RVA: 0x2276110 Offset: 0x2275310 VA: 0x182276110
	public void Remove(EventLogPermissionEntry value) { }
}

// Namespace: System.Diagnostics
[Usage(621, AllowMultiple = True, Inherited = False)]
[Serializable]
public class EventLogPermissionAttribute : CodeAccessSecurityAttribute // TypeDefIndex: 6556
{
	// Properties
	public string MachineName { get; set; }
	public EventLogPermissionAccess PermissionAccess { get; set; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(SecurityAction action) { }

	// RVA: 0x2275F60 Offset: 0x2275160 VA: 0x182275F60
	public string get_MachineName() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_MachineName(string value) { }

	// RVA: 0x2275F90 Offset: 0x2275190 VA: 0x182275F90
	public EventLogPermissionAccess get_PermissionAccess() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_PermissionAccess(EventLogPermissionAccess value) { }

	// RVA: 0x2275F30 Offset: 0x2275130 VA: 0x182275F30 Slot: 7
	public override IPermission CreatePermission() { }
}

// Namespace: System.Diagnostics
public sealed class EventLogTraceListener : TraceListener // TypeDefIndex: 6557
{
	// Properties
	public EventLog EventLog { get; set; }

	// Methods

	// RVA: 0x22763E0 Offset: 0x22755E0 VA: 0x1822763E0
	public void .ctor() { }

	// RVA: 0x22763B0 Offset: 0x22755B0 VA: 0x1822763B0
	public void .ctor(EventLog eventLog) { }

	// RVA: 0x2276410 Offset: 0x2275610 VA: 0x182276410
	public void .ctor(string source) { }

	// RVA: 0x2276440 Offset: 0x2275640 VA: 0x182276440
	public EventLog get_EventLog() { }

	// RVA: 0x2276470 Offset: 0x2275670 VA: 0x182276470
	public void set_EventLog(EventLog value) { }

	// RVA: 0x2276380 Offset: 0x2275580 VA: 0x182276380 Slot: 16
	public override void Write(string message) { }

	// RVA: 0x2276350 Offset: 0x2275550 VA: 0x182276350 Slot: 21
	public override void WriteLine(string message) { }
}

// Namespace: System.Diagnostics
[InterfaceType(1)]
[Guid("73386977-D6FD-11D2-BED5-00C04F79E3AE")]
public interface ICollectData // TypeDefIndex: 6558
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CloseData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CollectData([In] int id, [In] IntPtr valueName, [In] IntPtr data, [In] int totalBytes, out IntPtr res);
}

// Namespace: System.Diagnostics
public class InstanceData // TypeDefIndex: 6559
{
	// Properties
	public string InstanceName { get; }
	public long RawValue { get; }
	public CounterSample Sample { get; }

	// Methods

	// RVA: 0x2277FA0 Offset: 0x22771A0 VA: 0x182277FA0
	public void .ctor(string instanceName, CounterSample sample) { }

	// RVA: 0x2277FD0 Offset: 0x22771D0 VA: 0x182277FD0
	public string get_InstanceName() { }

	// RVA: 0x2278000 Offset: 0x2277200 VA: 0x182278000
	public long get_RawValue() { }

	// RVA: 0x2278030 Offset: 0x2277230 VA: 0x182278030
	public CounterSample get_Sample() { }
}

// Namespace: System.Diagnostics
[DefaultMember("Item")]
public class InstanceDataCollection : DictionaryBase // TypeDefIndex: 6560
{
	// Properties
	public string CounterName { get; }
	public InstanceData Item { get; }
	public ICollection Keys { get; }
	public ICollection Values { get; }

	// Methods

	[Obsolete("This constructor has been deprecated.  Please use System.Diagnostics.InstanceDataCollectionCollection.get_Item to get an instance of this collection instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x2277EB0 Offset: 0x22770B0 VA: 0x182277EB0
	public void .ctor(string counterName) { }

	// RVA: 0x2277EE0 Offset: 0x22770E0 VA: 0x182277EE0
	public string get_CounterName() { }

	// RVA: 0x2277F10 Offset: 0x2277110 VA: 0x182277F10
	public InstanceData get_Item(string instanceName) { }

	// RVA: 0x2277F40 Offset: 0x2277140 VA: 0x182277F40
	public ICollection get_Keys() { }

	// RVA: 0x2277F70 Offset: 0x2277170 VA: 0x182277F70
	public ICollection get_Values() { }

	// RVA: 0x2277E50 Offset: 0x2277050 VA: 0x182277E50
	public bool Contains(string instanceName) { }

	// RVA: 0x2277E80 Offset: 0x2277080 VA: 0x182277E80
	public void CopyTo(InstanceData[] instances, int index) { }
}

// Namespace: System.Diagnostics
[DefaultMember("Item")]
public class InstanceDataCollectionCollection : DictionaryBase // TypeDefIndex: 6561
{
	// Properties
	public InstanceDataCollection Item { get; }
	public ICollection Keys { get; }
	public ICollection Values { get; }

	// Methods

	[Obsolete("This constructor has been deprecated.  Please use System.Diagnostics.PerformanceCounterCategory.ReadCategory() to get an instance of this collection instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x2277D90 Offset: 0x2276F90 VA: 0x182277D90
	public void .ctor() { }

	// RVA: 0x2277DC0 Offset: 0x2276FC0 VA: 0x182277DC0
	public InstanceDataCollection get_Item(string counterName) { }

	// RVA: 0x2277DF0 Offset: 0x2276FF0 VA: 0x182277DF0
	public ICollection get_Keys() { }

	// RVA: 0x2277E20 Offset: 0x2277020 VA: 0x182277E20
	public ICollection get_Values() { }

	// RVA: 0x2277D30 Offset: 0x2276F30 VA: 0x182277D30
	public bool Contains(string counterName) { }

	// RVA: 0x2277D60 Offset: 0x2276F60 VA: 0x182277D60
	public void CopyTo(InstanceDataCollection[] counters, int index) { }
}

// Namespace: System.Diagnostics
[InstallerType("System.Diagnostics.PerformanceCounterInstaller,System.Configuration.Install, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public sealed class PerformanceCounter : Component, ISupportInitialize // TypeDefIndex: 6562
{
	// Fields
	[Obsolete("This field has been deprecated and is not used.  Use machine.config or an application configuration file to set the size of the PerformanceCounter file mapping.")]
	public static int DefaultFileMappingSize; // 0x0

	// Properties
	public string CategoryName { get; set; }
	public string CounterHelp { get; }
	public string CounterName { get; set; }
	public PerformanceCounterType CounterType { get; }
	public PerformanceCounterInstanceLifetime InstanceLifetime { get; set; }
	public string InstanceName { get; set; }
	public string MachineName { get; set; }
	public long RawValue { get; set; }
	public bool ReadOnly { get; set; }

	// Methods

	// RVA: 0x227A5B0 Offset: 0x22797B0 VA: 0x18227A5B0
	public void .ctor() { }

	// RVA: 0x227A550 Offset: 0x2279750 VA: 0x18227A550
	public void .ctor(string categoryName, string counterName) { }

	// RVA: 0x227A520 Offset: 0x2279720 VA: 0x18227A520
	public void .ctor(string categoryName, string counterName, bool readOnly) { }

	// RVA: 0x227A5E0 Offset: 0x22797E0 VA: 0x18227A5E0
	public void .ctor(string categoryName, string counterName, string instanceName) { }

	// RVA: 0x227A580 Offset: 0x2279780 VA: 0x18227A580
	public void .ctor(string categoryName, string counterName, string instanceName, bool readOnly) { }

	// RVA: 0x227A4F0 Offset: 0x22796F0 VA: 0x18227A4F0
	public void .ctor(string categoryName, string counterName, string instanceName, string machineName) { }

	// RVA: 0x227A610 Offset: 0x2279810 VA: 0x18227A610
	public string get_CategoryName() { }

	// RVA: 0x227A7C0 Offset: 0x22799C0 VA: 0x18227A7C0
	public void set_CategoryName(string value) { }

	// RVA: 0x227A640 Offset: 0x2279840 VA: 0x18227A640
	public string get_CounterHelp() { }

	// RVA: 0x227A670 Offset: 0x2279870 VA: 0x18227A670
	public string get_CounterName() { }

	// RVA: 0x227A7F0 Offset: 0x22799F0 VA: 0x18227A7F0
	public void set_CounterName(string value) { }

	// RVA: 0x227A6A0 Offset: 0x22798A0 VA: 0x18227A6A0
	public PerformanceCounterType get_CounterType() { }

	// RVA: 0x227A6D0 Offset: 0x22798D0 VA: 0x18227A6D0
	public PerformanceCounterInstanceLifetime get_InstanceLifetime() { }

	// RVA: 0x227A820 Offset: 0x2279A20 VA: 0x18227A820
	public void set_InstanceLifetime(PerformanceCounterInstanceLifetime value) { }

	// RVA: 0x227A700 Offset: 0x2279900 VA: 0x18227A700
	public string get_InstanceName() { }

	// RVA: 0x227A850 Offset: 0x2279A50 VA: 0x18227A850
	public void set_InstanceName(string value) { }

	// RVA: 0x227A730 Offset: 0x2279930 VA: 0x18227A730
	public string get_MachineName() { }

	// RVA: 0x227A880 Offset: 0x2279A80 VA: 0x18227A880
	public void set_MachineName(string value) { }

	// RVA: 0x227A760 Offset: 0x2279960 VA: 0x18227A760
	public long get_RawValue() { }

	// RVA: 0x227A8B0 Offset: 0x2279AB0 VA: 0x18227A8B0
	public void set_RawValue(long value) { }

	// RVA: 0x227A790 Offset: 0x2279990 VA: 0x18227A790
	public bool get_ReadOnly() { }

	// RVA: 0x227A8E0 Offset: 0x2279AE0 VA: 0x18227A8E0
	public void set_ReadOnly(bool value) { }

	// RVA: 0x227A310 Offset: 0x2279510 VA: 0x18227A310 Slot: 16
	public void BeginInit() { }

	// RVA: 0x227A370 Offset: 0x2279570 VA: 0x18227A370
	public void Close() { }

	// RVA: 0x227A340 Offset: 0x2279540 VA: 0x18227A340
	public static void CloseSharedResources() { }

	// RVA: 0x227A3A0 Offset: 0x22795A0 VA: 0x18227A3A0
	public long Decrement() { }

	// RVA: 0x227A3D0 Offset: 0x22795D0 VA: 0x18227A3D0 Slot: 17
	public void EndInit() { }

	// RVA: 0x227A430 Offset: 0x2279630 VA: 0x18227A430
	public long Increment() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x227A400 Offset: 0x2279600 VA: 0x18227A400
	public long IncrementBy(long value) { }

	// RVA: 0x227A460 Offset: 0x2279660 VA: 0x18227A460
	public CounterSample NextSample() { }

	// RVA: 0x227A490 Offset: 0x2279690 VA: 0x18227A490
	public float NextValue() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x227A4C0 Offset: 0x22796C0 VA: 0x18227A4C0
	public void RemoveInstance() { }
}

// Namespace: System.Diagnostics
public enum PerformanceCounterInstanceLifetime // TypeDefIndex: 6563
{
	// Fields
	public int value__; // 0x0
	public const PerformanceCounterInstanceLifetime Global = 0;
	public const PerformanceCounterInstanceLifetime Process = 1;
}

// Namespace: System.Diagnostics
public sealed class PerformanceCounterCategory // TypeDefIndex: 6564
{
	// Properties
	public string CategoryHelp { get; }
	public string CategoryName { get; set; }
	public PerformanceCounterCategoryType CategoryType { get; }
	public string MachineName { get; set; }

	// Methods

	// RVA: 0x2279C80 Offset: 0x2278E80 VA: 0x182279C80
	public void .ctor() { }

	// RVA: 0x2279C50 Offset: 0x2278E50 VA: 0x182279C50
	public void .ctor(string categoryName) { }

	// RVA: 0x2279CB0 Offset: 0x2278EB0 VA: 0x182279CB0
	public void .ctor(string categoryName, string machineName) { }

	// RVA: 0x2279CE0 Offset: 0x2278EE0 VA: 0x182279CE0
	public string get_CategoryHelp() { }

	// RVA: 0x2279D10 Offset: 0x2278F10 VA: 0x182279D10
	public string get_CategoryName() { }

	// RVA: 0x2279DA0 Offset: 0x2278FA0 VA: 0x182279DA0
	public void set_CategoryName(string value) { }

	// RVA: 0x2279D40 Offset: 0x2278F40 VA: 0x182279D40
	public PerformanceCounterCategoryType get_CategoryType() { }

	// RVA: 0x2279D70 Offset: 0x2278F70 VA: 0x182279D70
	public string get_MachineName() { }

	// RVA: 0x2279DD0 Offset: 0x2278FD0 VA: 0x182279DD0
	public void set_MachineName(string value) { }

	// RVA: 0x2279920 Offset: 0x2278B20 VA: 0x182279920
	public bool CounterExists(string counterName) { }

	// RVA: 0x22798F0 Offset: 0x2278AF0 VA: 0x1822798F0
	public static bool CounterExists(string counterName, string categoryName) { }

	// RVA: 0x22798C0 Offset: 0x2278AC0 VA: 0x1822798C0
	public static bool CounterExists(string counterName, string categoryName, string machineName) { }

	[Obsolete("This method has been deprecated.  Please use System.Diagnostics.PerformanceCounterCategory.Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, CounterCreationDataCollection counterData) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x22799B0 Offset: 0x2278BB0 VA: 0x1822799B0
	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, CounterCreationDataCollection counterData) { }

	// RVA: 0x2279950 Offset: 0x2278B50 VA: 0x182279950
	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, CounterCreationDataCollection counterData) { }

	// RVA: 0x22799E0 Offset: 0x2278BE0 VA: 0x1822799E0
	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, string counterName, string counterHelp) { }

	[Obsolete("This method has been deprecated.  Please use System.Diagnostics.PerformanceCounterCategory.Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, string counterName, string counterHelp) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x2279980 Offset: 0x2278B80 VA: 0x182279980
	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, string counterName, string counterHelp) { }

	// RVA: 0x2279A10 Offset: 0x2278C10 VA: 0x182279A10
	public static void Delete(string categoryName) { }

	// RVA: 0x2279A70 Offset: 0x2278C70 VA: 0x182279A70
	public static bool Exists(string categoryName) { }

	// RVA: 0x2279A40 Offset: 0x2278C40 VA: 0x182279A40
	public static bool Exists(string categoryName, string machineName) { }

	// RVA: 0x2279AD0 Offset: 0x2278CD0 VA: 0x182279AD0
	public static PerformanceCounterCategory[] GetCategories() { }

	// RVA: 0x2279AA0 Offset: 0x2278CA0 VA: 0x182279AA0
	public static PerformanceCounterCategory[] GetCategories(string machineName) { }

	// RVA: 0x2279B30 Offset: 0x2278D30 VA: 0x182279B30
	public PerformanceCounter[] GetCounters() { }

	// RVA: 0x2279B00 Offset: 0x2278D00 VA: 0x182279B00
	public PerformanceCounter[] GetCounters(string instanceName) { }

	// RVA: 0x2279B60 Offset: 0x2278D60 VA: 0x182279B60
	public string[] GetInstanceNames() { }

	// RVA: 0x2279BC0 Offset: 0x2278DC0 VA: 0x182279BC0
	public bool InstanceExists(string instanceName) { }

	// RVA: 0x2279B90 Offset: 0x2278D90 VA: 0x182279B90
	public static bool InstanceExists(string instanceName, string categoryName) { }

	// RVA: 0x2279BF0 Offset: 0x2278DF0 VA: 0x182279BF0
	public static bool InstanceExists(string instanceName, string categoryName, string machineName) { }

	// RVA: 0x2279C20 Offset: 0x2278E20 VA: 0x182279C20
	public InstanceDataCollectionCollection ReadCategory() { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
[Guid("82840BE1-D273-11D2-B94A-00600893B17A")]
public sealed class PerformanceCounterManager : ICollectData // TypeDefIndex: 6565
{
	// Methods

	[Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x2279E60 Offset: 0x2279060 VA: 0x182279E60
	public void .ctor() { }

	[Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x2279E00 Offset: 0x2279000 VA: 0x182279E00 Slot: 4
	private void System.Diagnostics.ICollectData.CloseData() { }

	[Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x2279E30 Offset: 0x2279030 VA: 0x182279E30 Slot: 5
	private void System.Diagnostics.ICollectData.CollectData(int callIdx, IntPtr valueNamePtr, IntPtr dataPtr, int totalBytes, out IntPtr res) { }
}

// Namespace: System.Diagnostics
[Serializable]
public sealed class PerformanceCounterPermission : ResourcePermissionBase // TypeDefIndex: 6566
{
	// Properties
	public PerformanceCounterPermissionEntryCollection PermissionEntries { get; }

	// Methods

	// RVA: 0x227A280 Offset: 0x2279480 VA: 0x18227A280
	public void .ctor() { }

	// RVA: 0x227A250 Offset: 0x2279450 VA: 0x18227A250
	public void .ctor(PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName) { }

	// RVA: 0x227A2B0 Offset: 0x22794B0 VA: 0x18227A2B0
	public void .ctor(PerformanceCounterPermissionEntry[] permissionAccessEntries) { }

	// RVA: 0x227A220 Offset: 0x2279420 VA: 0x18227A220
	public void .ctor(PermissionState state) { }

	// RVA: 0x227A2E0 Offset: 0x22794E0 VA: 0x18227A2E0
	public PerformanceCounterPermissionEntryCollection get_PermissionEntries() { }
}

// Namespace: System.Diagnostics
[Flags]
public enum PerformanceCounterPermissionAccess // TypeDefIndex: 6567
{
	// Fields
	public int value__; // 0x0
	public const PerformanceCounterPermissionAccess Administer = 7;
	[Obsolete("This member has been deprecated.  Use System.Diagnostics.PerformanceCounter.PerformanceCounterPermissionAccess.Read instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public const PerformanceCounterPermissionAccess Browse = 1;
	[Obsolete("This member has been deprecated.  Use System.Diagnostics.PerformanceCounter.PerformanceCounterPermissionAccess.Write instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public const PerformanceCounterPermissionAccess Instrument = 3;
	public const PerformanceCounterPermissionAccess None = 0;
	public const PerformanceCounterPermissionAccess Read = 1;
	public const PerformanceCounterPermissionAccess Write = 2;
}

// Namespace: System.Diagnostics
[Serializable]
public class PerformanceCounterPermissionEntry // TypeDefIndex: 6568
{
	// Properties
	public string CategoryName { get; }
	public string MachineName { get; }
	public PerformanceCounterPermissionAccess PermissionAccess { get; }

	// Methods

	// RVA: 0x227A160 Offset: 0x2279360 VA: 0x18227A160
	public void .ctor(PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName) { }

	// RVA: 0x227A190 Offset: 0x2279390 VA: 0x18227A190
	public string get_CategoryName() { }

	// RVA: 0x227A1C0 Offset: 0x22793C0 VA: 0x18227A1C0
	public string get_MachineName() { }

	// RVA: 0x227A1F0 Offset: 0x22793F0 VA: 0x18227A1F0
	public PerformanceCounterPermissionAccess get_PermissionAccess() { }
}

// Namespace: System.Diagnostics
[DefaultMember("Item")]
[Serializable]
public class PerformanceCounterPermissionEntryCollection : CollectionBase // TypeDefIndex: 6569
{
	// Properties
	public PerformanceCounterPermissionEntry Item { get; set; }

	// Methods

	// RVA: 0x227A0D0 Offset: 0x22792D0 VA: 0x18227A0D0
	internal void .ctor() { }

	// RVA: 0x227A100 Offset: 0x2279300 VA: 0x18227A100
	public PerformanceCounterPermissionEntry get_Item(int index) { }

	// RVA: 0x227A130 Offset: 0x2279330 VA: 0x18227A130
	public void set_Item(int index, PerformanceCounterPermissionEntry value) { }

	// RVA: 0x2279FB0 Offset: 0x22791B0 VA: 0x182279FB0
	public int Add(PerformanceCounterPermissionEntry value) { }

	// RVA: 0x2279F80 Offset: 0x2279180 VA: 0x182279F80
	public void AddRange(PerformanceCounterPermissionEntryCollection value) { }

	// RVA: 0x2279F50 Offset: 0x2279150 VA: 0x182279F50
	public void AddRange(PerformanceCounterPermissionEntry[] value) { }

	// RVA: 0x2279FE0 Offset: 0x22791E0 VA: 0x182279FE0
	public bool Contains(PerformanceCounterPermissionEntry value) { }

	// RVA: 0x227A010 Offset: 0x2279210 VA: 0x18227A010
	public void CopyTo(PerformanceCounterPermissionEntry[] array, int index) { }

	// RVA: 0x227A040 Offset: 0x2279240 VA: 0x18227A040
	public int IndexOf(PerformanceCounterPermissionEntry value) { }

	// RVA: 0x227A070 Offset: 0x2279270 VA: 0x18227A070
	public void Insert(int index, PerformanceCounterPermissionEntry value) { }

	// RVA: 0x227A0A0 Offset: 0x22792A0 VA: 0x18227A0A0
	public void Remove(PerformanceCounterPermissionEntry value) { }
}

// Namespace: System.Diagnostics
[Usage(621, AllowMultiple = True, Inherited = False)]
[Serializable]
public class PerformanceCounterPermissionAttribute : CodeAccessSecurityAttribute // TypeDefIndex: 6570
{
	// Properties
	public string CategoryName { get; set; }
	public string MachineName { get; set; }
	public PerformanceCounterPermissionAccess PermissionAccess { get; set; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(SecurityAction action) { }

	// RVA: 0x2279EC0 Offset: 0x22790C0 VA: 0x182279EC0
	public string get_CategoryName() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_CategoryName(string value) { }

	// RVA: 0x2279EF0 Offset: 0x22790F0 VA: 0x182279EF0
	public string get_MachineName() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_MachineName(string value) { }

	// RVA: 0x2279F20 Offset: 0x2279120 VA: 0x182279F20
	public PerformanceCounterPermissionAccess get_PermissionAccess() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_PermissionAccess(PerformanceCounterPermissionAccess value) { }

	// RVA: 0x2279E90 Offset: 0x2279090 VA: 0x182279E90 Slot: 7
	public override IPermission CreatePermission() { }
}

// Namespace: System.Diagnostics
public class XmlWriterTraceListener : TextWriterTraceListener // TypeDefIndex: 6571
{
	// Methods

	// RVA: 0x22849D0 Offset: 0x2283BD0 VA: 0x1822849D0
	public void .ctor(Stream stream) { }

	// RVA: 0x2284970 Offset: 0x2283B70 VA: 0x182284970
	public void .ctor(Stream stream, string name) { }

	// RVA: 0x2284A30 Offset: 0x2283C30 VA: 0x182284A30
	public void .ctor(TextWriter writer) { }

	// RVA: 0x2284A00 Offset: 0x2283C00 VA: 0x182284A00
	public void .ctor(TextWriter writer, string name) { }

	// RVA: 0x2284A60 Offset: 0x2283C60 VA: 0x182284A60
	public void .ctor(string filename) { }

	// RVA: 0x22849A0 Offset: 0x2283BA0 VA: 0x1822849A0
	public void .ctor(string filename, string name) { }
}

// Namespace: System.Configuration
[Usage(128)]
public sealed class ApplicationScopedSettingAttribute : SettingAttribute // TypeDefIndex: 6572
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor() { }
}

// Namespace: System.Configuration
[Usage(128)]
public class SettingAttribute : Attribute // TypeDefIndex: 6573
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor() { }
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public abstract class ApplicationSettingsBase : SettingsBase, INotifyPropertyChanged // TypeDefIndex: 6574
{
	// Properties
	public override SettingsContext Context { get; }
	public override object Item { get; set; }
	public override SettingsPropertyCollection Properties { get; }
	public override SettingsPropertyValueCollection PropertyValues { get; }
	public override SettingsProviderCollection Providers { get; }
	public string SettingsKey { get; set; }

	// Methods

	// RVA: 0x2269610 Offset: 0x2268810 VA: 0x182269610
	protected void .ctor() { }

	// RVA: 0x22695B0 Offset: 0x22687B0 VA: 0x1822695B0
	protected void .ctor(IComponent owner) { }

	// RVA: 0x2269640 Offset: 0x2268840 VA: 0x182269640
	protected void .ctor(IComponent owner, string settingsKey) { }

	// RVA: 0x22695E0 Offset: 0x22687E0 VA: 0x1822695E0
	protected void .ctor(string settingsKey) { }

	// RVA: 0x2269730 Offset: 0x2268930 VA: 0x182269730 Slot: 4
	public override SettingsContext get_Context() { }

	// RVA: 0x2269760 Offset: 0x2268960 VA: 0x182269760 Slot: 5
	public override object get_Item(string propertyName) { }

	// RVA: 0x2269910 Offset: 0x2268B10 VA: 0x182269910 Slot: 6
	public override void set_Item(string propertyName, object value) { }

	// RVA: 0x2269790 Offset: 0x2268990 VA: 0x182269790 Slot: 7
	public override SettingsPropertyCollection get_Properties() { }

	// RVA: 0x22697C0 Offset: 0x22689C0 VA: 0x1822697C0 Slot: 8
	public override SettingsPropertyValueCollection get_PropertyValues() { }

	// RVA: 0x22697F0 Offset: 0x22689F0 VA: 0x1822697F0 Slot: 9
	public override SettingsProviderCollection get_Providers() { }

	// RVA: 0x2269820 Offset: 0x2268A20 VA: 0x182269820
	public string get_SettingsKey() { }

	// RVA: 0x2269940 Offset: 0x2268B40 VA: 0x182269940
	public void set_SettingsKey(string value) { }

	// RVA: 0x2269670 Offset: 0x2268870 VA: 0x182269670 Slot: 11
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x2269850 Offset: 0x2268A50 VA: 0x182269850 Slot: 12
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x22696A0 Offset: 0x22688A0 VA: 0x1822696A0
	public void add_SettingChanging(SettingChangingEventHandler value) { }

	// RVA: 0x2269880 Offset: 0x2268A80 VA: 0x182269880
	public void remove_SettingChanging(SettingChangingEventHandler value) { }

	// RVA: 0x22696D0 Offset: 0x22688D0 VA: 0x1822696D0
	public void add_SettingsLoaded(SettingsLoadedEventHandler value) { }

	// RVA: 0x22698B0 Offset: 0x2268AB0 VA: 0x1822698B0
	public void remove_SettingsLoaded(SettingsLoadedEventHandler value) { }

	// RVA: 0x2269700 Offset: 0x2268900 VA: 0x182269700
	public void add_SettingsSaving(SettingsSavingEventHandler value) { }

	// RVA: 0x22698E0 Offset: 0x2268AE0 VA: 0x1822698E0
	public void remove_SettingsSaving(SettingsSavingEventHandler value) { }

	// RVA: 0x2269400 Offset: 0x2268600 VA: 0x182269400
	public object GetPreviousVersion(string propertyName) { }

	// RVA: 0x2269430 Offset: 0x2268630 VA: 0x182269430 Slot: 13
	protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x2269460 Offset: 0x2268660 VA: 0x182269460 Slot: 14
	protected virtual void OnSettingChanging(object sender, SettingChangingEventArgs e) { }

	// RVA: 0x2269490 Offset: 0x2268690 VA: 0x182269490 Slot: 15
	protected virtual void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e) { }

	// RVA: 0x22694C0 Offset: 0x22686C0 VA: 0x1822694C0 Slot: 16
	protected virtual void OnSettingsSaving(object sender, CancelEventArgs e) { }

	// RVA: 0x22694F0 Offset: 0x22686F0 VA: 0x1822694F0
	public void Reload() { }

	// RVA: 0x2269520 Offset: 0x2268720 VA: 0x182269520
	public void Reset() { }

	// RVA: 0x2269550 Offset: 0x2268750 VA: 0x182269550 Slot: 10
	public override void Save() { }

	// RVA: 0x2269580 Offset: 0x2268780 VA: 0x182269580 Slot: 17
	public virtual void Upgrade() { }
}

// Namespace: System.Configuration
public sealed class SettingChangingEventHandler : MulticastDelegate // TypeDefIndex: 6575
{
	// Methods

	// RVA: 0x227D360 Offset: 0x227C560 VA: 0x18227D360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x227D330 Offset: 0x227C530 VA: 0x18227D330 Slot: 13
	public virtual void Invoke(object sender, SettingChangingEventArgs e) { }

	// RVA: 0x227D2D0 Offset: 0x227C4D0 VA: 0x18227D2D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, SettingChangingEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x227D300 Offset: 0x227C500 VA: 0x18227D300 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Configuration
public class SettingChangingEventArgs : CancelEventArgs // TypeDefIndex: 6576
{
	// Properties
	public object NewValue { get; }
	public string SettingClass { get; }
	public string SettingKey { get; }
	public string SettingName { get; }

	// Methods

	// RVA: 0x227D1E0 Offset: 0x227C3E0 VA: 0x18227D1E0
	public void .ctor(string settingName, string settingClass, string settingKey, object newValue, bool cancel) { }

	// RVA: 0x227D210 Offset: 0x227C410 VA: 0x18227D210
	public object get_NewValue() { }

	// RVA: 0x227D240 Offset: 0x227C440 VA: 0x18227D240
	public string get_SettingClass() { }

	// RVA: 0x227D270 Offset: 0x227C470 VA: 0x18227D270
	public string get_SettingKey() { }

	// RVA: 0x227D2A0 Offset: 0x227C4A0 VA: 0x18227D2A0
	public string get_SettingName() { }
}

// Namespace: System.Configuration
public sealed class SettingsLoadedEventHandler : MulticastDelegate // TypeDefIndex: 6577
{
	// Methods

	// RVA: 0x227DCF0 Offset: 0x227CEF0 VA: 0x18227DCF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x227DCC0 Offset: 0x227CEC0 VA: 0x18227DCC0 Slot: 13
	public virtual void Invoke(object sender, SettingsLoadedEventArgs e) { }

	// RVA: 0x227DC60 Offset: 0x227CE60 VA: 0x18227DC60 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, SettingsLoadedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x227DC90 Offset: 0x227CE90 VA: 0x18227DC90 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Configuration
public class SettingsLoadedEventArgs : EventArgs // TypeDefIndex: 6578
{
	// Properties
	public SettingsProvider Provider { get; }

	// Methods

	// RVA: 0x227DC00 Offset: 0x227CE00 VA: 0x18227DC00
	public void .ctor(SettingsProvider provider) { }

	// RVA: 0x227DC30 Offset: 0x227CE30 VA: 0x18227DC30
	public SettingsProvider get_Provider() { }
}

// Namespace: System.Configuration
public sealed class SettingsSavingEventHandler : MulticastDelegate // TypeDefIndex: 6579
{
	// Methods

	// RVA: 0x227ECB0 Offset: 0x227DEB0 VA: 0x18227ECB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x227EC80 Offset: 0x227DE80 VA: 0x18227EC80 Slot: 13
	public virtual void Invoke(object sender, CancelEventArgs e) { }

	// RVA: 0x227EC20 Offset: 0x227DE20 VA: 0x18227EC20 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, CancelEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x227EC50 Offset: 0x227DE50 VA: 0x18227EC50 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Configuration
public sealed class ApplicationSettingsGroup : ConfigurationSectionGroup // TypeDefIndex: 6580
{
	// Methods

	// RVA: 0x2269970 Offset: 0x2268B70 VA: 0x182269970
	public void .ctor() { }
}

// Namespace: System.Configuration
public class AppSettingsReader // TypeDefIndex: 6581
{
	// Methods

	// RVA: 0x22693D0 Offset: 0x22685D0 VA: 0x1822693D0
	public void .ctor() { }

	// RVA: 0x22693A0 Offset: 0x22685A0 VA: 0x1822693A0
	public object GetValue(string key, Type type) { }
}

// Namespace: System.Configuration
public sealed class ClientSettingsSection : ConfigurationSection // TypeDefIndex: 6582
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }
	public SettingElementCollection Settings { get; }

	// Methods

	// RVA: 0x226A790 Offset: 0x2269990 VA: 0x18226A790
	public void .ctor() { }

	// RVA: 0x226A7C0 Offset: 0x22699C0 VA: 0x18226A7C0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x226A7F0 Offset: 0x22699F0 VA: 0x18226A7F0
	public SettingElementCollection get_Settings() { }
}

// Namespace: System.Configuration
public sealed class SettingElementCollection : ConfigurationElementCollection // TypeDefIndex: 6583
{
	// Properties
	public override ConfigurationElementCollectionType CollectionType { get; }
	protected override string ElementName { get; }

	// Methods

	// RVA: 0x227D4B0 Offset: 0x227C6B0 VA: 0x18227D4B0
	public void .ctor() { }

	// RVA: 0x227D4E0 Offset: 0x227C6E0 VA: 0x18227D4E0 Slot: 13
	public override ConfigurationElementCollectionType get_CollectionType() { }

	// RVA: 0x227D510 Offset: 0x227C710 VA: 0x18227D510 Slot: 14
	protected override string get_ElementName() { }

	// RVA: 0x227D390 Offset: 0x227C590 VA: 0x18227D390
	public void Add(SettingElement element) { }

	// RVA: 0x227D3C0 Offset: 0x227C5C0 VA: 0x18227D3C0
	public void Clear() { }

	// RVA: 0x227D3F0 Offset: 0x227C5F0 VA: 0x18227D3F0 Slot: 16
	protected override ConfigurationElement CreateNewElement() { }

	// RVA: 0x227D450 Offset: 0x227C650 VA: 0x18227D450
	public SettingElement Get(string elementKey) { }

	// RVA: 0x227D420 Offset: 0x227C620 VA: 0x18227D420 Slot: 17
	protected override object GetElementKey(ConfigurationElement element) { }

	// RVA: 0x227D480 Offset: 0x227C680 VA: 0x18227D480
	public void Remove(SettingElement element) { }
}

// Namespace: System.Configuration
public sealed class SettingElement : ConfigurationElement // TypeDefIndex: 6584
{
	// Properties
	public string Name { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public SettingsSerializeAs SerializeAs { get; set; }
	public SettingValueElement Value { get; set; }

	// Methods

	// RVA: 0x227D540 Offset: 0x227C740 VA: 0x18227D540
	public void .ctor() { }

	// RVA: 0x227D570 Offset: 0x227C770 VA: 0x18227D570
	public void .ctor(string name, SettingsSerializeAs serializeAs) { }

	// RVA: 0x227D5A0 Offset: 0x227C7A0 VA: 0x18227D5A0
	public string get_Name() { }

	// RVA: 0x227D660 Offset: 0x227C860 VA: 0x18227D660
	public void set_Name(string value) { }

	// RVA: 0x227D5D0 Offset: 0x227C7D0 VA: 0x18227D5D0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x227D600 Offset: 0x227C800 VA: 0x18227D600
	public SettingsSerializeAs get_SerializeAs() { }

	// RVA: 0x227D690 Offset: 0x227C890 VA: 0x18227D690
	public void set_SerializeAs(SettingsSerializeAs value) { }

	// RVA: 0x227D630 Offset: 0x227C830 VA: 0x18227D630
	public SettingValueElement get_Value() { }

	// RVA: 0x227D6C0 Offset: 0x227C8C0 VA: 0x18227D6C0
	public void set_Value(SettingValueElement value) { }
}

// Namespace: System.Configuration
public sealed class SettingValueElement : ConfigurationElement // TypeDefIndex: 6585
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }
	public XmlNode ValueXml { get; set; }

	// Methods

	// RVA: 0x227D810 Offset: 0x227CA10 VA: 0x18227D810
	public void .ctor() { }

	// RVA: 0x227D840 Offset: 0x227CA40 VA: 0x18227D840 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x227D870 Offset: 0x227CA70 VA: 0x18227D870
	public XmlNode get_ValueXml() { }

	// RVA: 0x227D8A0 Offset: 0x227CAA0 VA: 0x18227D8A0
	public void set_ValueXml(XmlNode value) { }

	// RVA: 0x227D6F0 Offset: 0x227C8F0 VA: 0x18227D6F0 Slot: 5
	protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey) { }

	// RVA: 0x227D720 Offset: 0x227C920 VA: 0x18227D720 Slot: 7
	protected override bool IsModified() { }

	// RVA: 0x227D780 Offset: 0x227C980 VA: 0x18227D780 Slot: 9
	protected override void Reset(ConfigurationElement parentElement) { }

	// RVA: 0x227D750 Offset: 0x227C950 VA: 0x18227D750 Slot: 10
	protected override void ResetModified() { }

	// RVA: 0x227D7B0 Offset: 0x227C9B0 VA: 0x18227D7B0 Slot: 11
	protected override bool SerializeToXmlElement(XmlWriter writer, string elementName) { }

	// RVA: 0x227D7E0 Offset: 0x227C9E0 VA: 0x18227D7E0 Slot: 12
	protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode) { }
}

// Namespace: System.Configuration
public sealed class ConfigurationSettings // TypeDefIndex: 6586
{
	// Properties
	public static NameValueCollection AppSettings { get; }

	// Methods

	// RVA: 0x2274670 Offset: 0x2273870 VA: 0x182274670
	internal void .ctor() { }

	// RVA: 0x22746A0 Offset: 0x22738A0 VA: 0x1822746A0
	public static NameValueCollection get_AppSettings() { }

	[Obsolete("This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.GetSection")]
	// RVA: 0x2274640 Offset: 0x2273840 VA: 0x182274640
	public static object GetConfig(string sectionName) { }
}

// Namespace: System.Configuration
public sealed class ConfigXmlDocument : XmlDocument, IConfigErrorInfo // TypeDefIndex: 6587
{
	// Properties
	public string Filename { get; }
	public int LineNumber { get; }

	// Methods

	// RVA: 0x2274340 Offset: 0x2273540 VA: 0x182274340
	public void .ctor() { }

	// RVA: 0x2274370 Offset: 0x2273570 VA: 0x182274370
	public string get_Filename() { }

	// RVA: 0x22743A0 Offset: 0x22735A0 VA: 0x1822743A0
	public int get_LineNumber() { }

	// RVA: 0x22742E0 Offset: 0x22734E0 VA: 0x1822742E0 Slot: 84
	private string System.Configuration.Internal.IConfigErrorInfo.get_Filename() { }

	// RVA: 0x2274310 Offset: 0x2273510 VA: 0x182274310 Slot: 85
	private int System.Configuration.Internal.IConfigErrorInfo.get_LineNumber() { }

	// RVA: 0x22742B0 Offset: 0x22734B0 VA: 0x1822742B0
	public void LoadSingleElement(string filename, XmlTextReader sourceReader) { }
}

// Namespace: System.Configuration
[Usage(128)]
public sealed class DefaultSettingValueAttribute : Attribute // TypeDefIndex: 6588
{
	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(string value) { }

	// RVA: 0x22754B0 Offset: 0x22746B0 VA: 0x1822754B0
	public string get_Value() { }
}

// Namespace: System.Configuration
public class DictionarySectionHandler : IConfigurationSectionHandler // TypeDefIndex: 6589
{
	// Properties
	protected virtual string KeyAttributeName { get; }
	protected virtual string ValueAttributeName { get; }

	// Methods

	// RVA: 0x2275570 Offset: 0x2274770 VA: 0x182275570
	public void .ctor() { }

	// RVA: 0x22755A0 Offset: 0x22747A0 VA: 0x1822755A0 Slot: 5
	protected virtual string get_KeyAttributeName() { }

	// RVA: 0x22755D0 Offset: 0x22747D0 VA: 0x1822755D0 Slot: 6
	protected virtual string get_ValueAttributeName() { }

	// RVA: 0x2275540 Offset: 0x2274740 VA: 0x182275540 Slot: 7
	public virtual object Create(object parent, object context, XmlNode section) { }
}

// Namespace: System.Configuration
[ComVisible(False)]
public interface IConfigurationSystem // TypeDefIndex: 6590
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetConfig(string configKey);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Init();
}

// Namespace: System.Configuration
public sealed class IdnElement : ConfigurationElement // TypeDefIndex: 6591
{
	// Properties
	public UriIdnScope Enabled { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x2277C10 Offset: 0x2276E10 VA: 0x182277C10
	public void .ctor() { }

	// RVA: 0x2277C40 Offset: 0x2276E40 VA: 0x182277C40
	public UriIdnScope get_Enabled() { }

	// RVA: 0x2277CA0 Offset: 0x2276EA0 VA: 0x182277CA0
	public void set_Enabled(UriIdnScope value) { }

	// RVA: 0x2277C70 Offset: 0x2276E70 VA: 0x182277C70 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Configuration
public class IgnoreSectionHandler : IConfigurationSectionHandler // TypeDefIndex: 6592
{
	// Methods

	// RVA: 0x2277D00 Offset: 0x2276F00 VA: 0x182277D00
	public void .ctor() { }

	// RVA: 0x2277CD0 Offset: 0x2276ED0 VA: 0x182277CD0 Slot: 5
	public virtual object Create(object parent, object configContext, XmlNode section) { }
}

// Namespace: System.Configuration
public interface IPersistComponentSettings // TypeDefIndex: 6593
{
	// Properties
	public abstract bool SaveSettings { get; set; }
	public abstract string SettingsKey { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_SaveSettings();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_SaveSettings(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_SettingsKey();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_SettingsKey(string value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void LoadComponentSettings();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ResetComponentSettings();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SaveComponentSettings();
}

// Namespace: System.Configuration
public sealed class IriParsingElement : ConfigurationElement // TypeDefIndex: 6594
{
	// Properties
	public bool Enabled { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x2278180 Offset: 0x2277380 VA: 0x182278180
	public void .ctor() { }

	// RVA: 0x22781B0 Offset: 0x22773B0 VA: 0x1822781B0
	public bool get_Enabled() { }

	// RVA: 0x2278210 Offset: 0x2277410 VA: 0x182278210
	public void set_Enabled(bool value) { }

	// RVA: 0x22781E0 Offset: 0x22773E0 VA: 0x1822781E0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Configuration
public interface ISettingsProviderService // TypeDefIndex: 6595
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SettingsProvider GetSettingsProvider(SettingsProperty property);
}

// Namespace: System.Configuration
public class LocalFileSettingsProvider : SettingsProvider, IApplicationSettingsProvider // TypeDefIndex: 6596
{
	// Properties
	public override string ApplicationName { get; set; }

	// Methods

	// RVA: 0x2278480 Offset: 0x2277680 VA: 0x182278480
	public void .ctor() { }

	// RVA: 0x22784B0 Offset: 0x22776B0 VA: 0x1822784B0 Slot: 5
	public override string get_ApplicationName() { }

	// RVA: 0x22784E0 Offset: 0x22776E0 VA: 0x1822784E0 Slot: 6
	public override void set_ApplicationName(string value) { }

	// RVA: 0x2278360 Offset: 0x2277560 VA: 0x182278360 Slot: 9
	public SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property) { }

	// RVA: 0x2278390 Offset: 0x2277590 VA: 0x182278390 Slot: 7
	public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection properties) { }

	// RVA: 0x22783C0 Offset: 0x22775C0 VA: 0x1822783C0 Slot: 4
	public override void Initialize(string name, NameValueCollection values) { }

	// RVA: 0x22783F0 Offset: 0x22775F0 VA: 0x1822783F0 Slot: 10
	public void Reset(SettingsContext context) { }

	// RVA: 0x2278420 Offset: 0x2277620 VA: 0x182278420 Slot: 8
	public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values) { }

	// RVA: 0x2278450 Offset: 0x2277650 VA: 0x182278450 Slot: 11
	public void Upgrade(SettingsContext context, SettingsPropertyCollection properties) { }
}

// Namespace: System.Configuration
public class NameValueFileSectionHandler : IConfigurationSectionHandler // TypeDefIndex: 6597
{
	// Methods

	// RVA: 0x2278660 Offset: 0x2277860 VA: 0x182278660
	public void .ctor() { }

	// RVA: 0x2278630 Offset: 0x2277830 VA: 0x182278630 Slot: 4
	public object Create(object parent, object configContext, XmlNode section) { }
}

// Namespace: System.Configuration
public class NameValueSectionHandler : IConfigurationSectionHandler // TypeDefIndex: 6598
{
	// Properties
	protected virtual string KeyAttributeName { get; }
	protected virtual string ValueAttributeName { get; }

	// Methods

	// RVA: 0x22786C0 Offset: 0x22778C0 VA: 0x1822786C0
	public void .ctor() { }

	// RVA: 0x22786F0 Offset: 0x22778F0 VA: 0x1822786F0 Slot: 5
	protected virtual string get_KeyAttributeName() { }

	// RVA: 0x2278720 Offset: 0x2277920 VA: 0x182278720 Slot: 6
	protected virtual string get_ValueAttributeName() { }

	// RVA: 0x2278690 Offset: 0x2277890 VA: 0x182278690 Slot: 4
	public object Create(object parent, object context, XmlNode section) { }
}

// Namespace: System.Configuration
[Usage(128)]
public sealed class NoSettingsVersionUpgradeAttribute : Attribute // TypeDefIndex: 6599
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor() { }
}

// Namespace: System.Configuration
public sealed class SchemeSettingElement : ConfigurationElement // TypeDefIndex: 6600
{
	// Properties
	public GenericUriParserOptions GenericUriParserOptions { get; }
	public string Name { get; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x227B620 Offset: 0x227A820 VA: 0x18227B620
	public void .ctor() { }

	// RVA: 0x227B650 Offset: 0x227A850 VA: 0x18227B650
	public GenericUriParserOptions get_GenericUriParserOptions() { }

	// RVA: 0x227B680 Offset: 0x227A880 VA: 0x18227B680
	public string get_Name() { }

	// RVA: 0x227B6B0 Offset: 0x227A8B0 VA: 0x18227B6B0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Configuration
[ConfigurationCollection(typeof(SchemeSettingElement), CollectionType = 1, AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
[DefaultMember("Item")]
public sealed class SchemeSettingElementCollection : ConfigurationElementCollection // TypeDefIndex: 6601
{
	// Properties
	public override ConfigurationElementCollectionType CollectionType { get; }
	public SchemeSettingElement Item { get; }

	// Methods

	// RVA: 0x227B560 Offset: 0x227A760 VA: 0x18227B560
	public void .ctor() { }

	// RVA: 0x227B590 Offset: 0x227A790 VA: 0x18227B590 Slot: 13
	public override ConfigurationElementCollectionType get_CollectionType() { }

	// RVA: 0x227B5F0 Offset: 0x227A7F0 VA: 0x18227B5F0
	public SchemeSettingElement get_Item(int index) { }

	// RVA: 0x227B5C0 Offset: 0x227A7C0 VA: 0x18227B5C0
	public SchemeSettingElement get_Item(string name) { }

	// RVA: 0x227B4D0 Offset: 0x227A6D0 VA: 0x18227B4D0 Slot: 16
	protected override ConfigurationElement CreateNewElement() { }

	// RVA: 0x227B500 Offset: 0x227A700 VA: 0x18227B500 Slot: 17
	protected override object GetElementKey(ConfigurationElement element) { }

	// RVA: 0x227B530 Offset: 0x227A730 VA: 0x18227B530
	public int IndexOf(SchemeSettingElement element) { }
}

// Namespace: System.Configuration
[Usage(128)]
public sealed class SettingsDescriptionAttribute : Attribute // TypeDefIndex: 6602
{
	// Properties
	public string Description { get; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(string description) { }

	// RVA: 0x227DB70 Offset: 0x227CD70 VA: 0x18227DB70
	public string get_Description() { }
}

// Namespace: System.Configuration
[Usage(4)]
public sealed class SettingsGroupDescriptionAttribute : Attribute // TypeDefIndex: 6603
{
	// Properties
	public string Description { get; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(string description) { }

	// RVA: 0x227DBA0 Offset: 0x227CDA0 VA: 0x18227DBA0
	public string get_Description() { }
}

// Namespace: System.Configuration
[Usage(4)]
public sealed class SettingsGroupNameAttribute : Attribute // TypeDefIndex: 6604
{
	// Properties
	public string GroupName { get; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(string groupName) { }

	// RVA: 0x227DBD0 Offset: 0x227CDD0 VA: 0x18227DBD0
	public string get_GroupName() { }
}

// Namespace: System.Configuration
public enum SettingsManageability // TypeDefIndex: 6605
{
	// Fields
	public int value__; // 0x0
	public const SettingsManageability Roaming = 0;
}

// Namespace: System.Configuration
[Usage(132)]
public sealed class SettingsManageabilityAttribute : Attribute // TypeDefIndex: 6606
{
	// Properties
	public SettingsManageability Manageability { get; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(SettingsManageability manageability) { }

	// RVA: 0x227DD20 Offset: 0x227CF20 VA: 0x18227DD20
	public SettingsManageability get_Manageability() { }
}

// Namespace: System.Configuration
[Serializable]
public class SettingsPropertyIsReadOnlyException : Exception // TypeDefIndex: 6607
{
	// Methods

	// RVA: 0x227E0E0 Offset: 0x227D2E0 VA: 0x18227E0E0
	public void .ctor() { }

	// RVA: 0x227E110 Offset: 0x227D310 VA: 0x18227E110
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x227E0B0 Offset: 0x227D2B0 VA: 0x18227E0B0
	public void .ctor(string message) { }

	// RVA: 0x227E140 Offset: 0x227D340 VA: 0x18227E140
	public void .ctor(string message, Exception innerException) { }
}

// Namespace: System.Configuration
[Serializable]
public class SettingsPropertyNotFoundException : Exception // TypeDefIndex: 6608
{
	// Methods

	// RVA: 0x227E1D0 Offset: 0x227D3D0 VA: 0x18227E1D0
	public void .ctor() { }

	// RVA: 0x227E170 Offset: 0x227D370 VA: 0x18227E170
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x227E1A0 Offset: 0x227D3A0 VA: 0x18227E1A0
	public void .ctor(string message) { }

	// RVA: 0x227E200 Offset: 0x227D400 VA: 0x18227E200
	public void .ctor(string message, Exception innerException) { }
}

// Namespace: System.Configuration
[Serializable]
public class SettingsPropertyWrongTypeException : Exception // TypeDefIndex: 6609
{
	// Methods

	// RVA: 0x227E6E0 Offset: 0x227D8E0 VA: 0x18227E6E0
	public void .ctor() { }

	// RVA: 0x227E6B0 Offset: 0x227D8B0 VA: 0x18227E6B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x227E740 Offset: 0x227D940 VA: 0x18227E740
	public void .ctor(string message) { }

	// RVA: 0x227E710 Offset: 0x227D910 VA: 0x18227E710
	public void .ctor(string message, Exception innerException) { }
}

// Namespace: System.Configuration
[Usage(132)]
public sealed class SettingsProviderAttribute : Attribute // TypeDefIndex: 6610
{
	// Properties
	public string ProviderTypeName { get; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(string providerTypeName) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(Type providerType) { }

	// RVA: 0x227EB30 Offset: 0x227DD30 VA: 0x18227EB30
	public string get_ProviderTypeName() { }
}

// Namespace: System.Configuration
[Usage(132)]
public sealed class SettingsSerializeAsAttribute : Attribute // TypeDefIndex: 6611
{
	// Properties
	public SettingsSerializeAs SerializeAs { get; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(SettingsSerializeAs serializeAs) { }

	// RVA: 0x227EEF0 Offset: 0x227E0F0 VA: 0x18227EEF0
	public SettingsSerializeAs get_SerializeAs() { }
}

// Namespace: System.Configuration
public class SingleTagSectionHandler : IConfigurationSectionHandler // TypeDefIndex: 6612
{
	// Methods

	// RVA: 0x227EF50 Offset: 0x227E150 VA: 0x18227EF50
	public void .ctor() { }

	// RVA: 0x227EF20 Offset: 0x227E120 VA: 0x18227EF20 Slot: 5
	public virtual object Create(object parent, object context, XmlNode section) { }
}

// Namespace: System.Configuration
public enum SpecialSetting // TypeDefIndex: 6613
{
	// Fields
	public int value__; // 0x0
	public const SpecialSetting ConnectionString = 0;
	public const SpecialSetting WebServiceUrl = 1;
}

// Namespace: System.Configuration
[Usage(132)]
public sealed class SpecialSettingAttribute : Attribute // TypeDefIndex: 6614
{
	// Properties
	public SpecialSetting SpecialSetting { get; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(SpecialSetting specialSetting) { }

	// RVA: 0x227FF40 Offset: 0x227F140 VA: 0x18227FF40
	public SpecialSetting get_SpecialSetting() { }
}

// Namespace: System.Configuration
public sealed class UriSection : ConfigurationSection // TypeDefIndex: 6615
{
	// Properties
	public IdnElement Idn { get; }
	public IriParsingElement IriParsing { get; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public SchemeSettingElementCollection SchemeSettings { get; }

	// Methods

	// RVA: 0x2283C80 Offset: 0x2282E80 VA: 0x182283C80
	public void .ctor() { }

	// RVA: 0x2283CB0 Offset: 0x2282EB0 VA: 0x182283CB0
	public IdnElement get_Idn() { }

	// RVA: 0x2283CE0 Offset: 0x2282EE0 VA: 0x182283CE0
	public IriParsingElement get_IriParsing() { }

	// RVA: 0x2283D10 Offset: 0x2282F10 VA: 0x182283D10 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x2283D40 Offset: 0x2282F40 VA: 0x182283D40
	public SchemeSettingElementCollection get_SchemeSettings() { }
}

// Namespace: System.Configuration
[Usage(128)]
public sealed class UserScopedSettingAttribute : SettingAttribute // TypeDefIndex: 6616
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor() { }
}

// Namespace: System.Configuration
public sealed class UserSettingsGroup : ConfigurationSectionGroup // TypeDefIndex: 6617
{
	// Methods

	// RVA: 0x2283FB0 Offset: 0x22831B0 VA: 0x182283FB0
	public void .ctor() { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeArrayCreateExpression : CodeExpression // TypeDefIndex: 6618
{
	// Properties
	public CodeTypeReference CreateType { get; set; }
	public CodeExpressionCollection Initializers { get; }
	public int Size { get; set; }
	public CodeExpression SizeExpression { get; set; }

	// Methods

	// RVA: 0x226A910 Offset: 0x2269B10 VA: 0x18226A910
	public void .ctor() { }

	// RVA: 0x226A8E0 Offset: 0x2269AE0 VA: 0x18226A8E0
	public void .ctor(CodeTypeReference createType, CodeExpression size) { }

	// RVA: 0x226AA30 Offset: 0x2269C30 VA: 0x18226AA30
	public void .ctor(CodeTypeReference createType, CodeExpression[] initializers) { }

	// RVA: 0x226A9A0 Offset: 0x2269BA0 VA: 0x18226A9A0
	public void .ctor(CodeTypeReference createType, int size) { }

	// RVA: 0x226AA90 Offset: 0x2269C90 VA: 0x18226AA90
	public void .ctor(string createType, CodeExpression size) { }

	// RVA: 0x226A9D0 Offset: 0x2269BD0 VA: 0x18226A9D0
	public void .ctor(string createType, CodeExpression[] initializers) { }

	// RVA: 0x226A970 Offset: 0x2269B70 VA: 0x18226A970
	public void .ctor(string createType, int size) { }

	// RVA: 0x226A940 Offset: 0x2269B40 VA: 0x18226A940
	public void .ctor(Type createType, CodeExpression size) { }

	// RVA: 0x226AA60 Offset: 0x2269C60 VA: 0x18226AA60
	public void .ctor(Type createType, CodeExpression[] initializers) { }

	// RVA: 0x226AA00 Offset: 0x2269C00 VA: 0x18226AA00
	public void .ctor(Type createType, int size) { }

	// RVA: 0x226AAC0 Offset: 0x2269CC0 VA: 0x18226AAC0
	public CodeTypeReference get_CreateType() { }

	// RVA: 0x226AB80 Offset: 0x2269D80 VA: 0x18226AB80
	public void set_CreateType(CodeTypeReference value) { }

	// RVA: 0x226AAF0 Offset: 0x2269CF0 VA: 0x18226AAF0
	public CodeExpressionCollection get_Initializers() { }

	// RVA: 0x226AB50 Offset: 0x2269D50 VA: 0x18226AB50
	public int get_Size() { }

	// RVA: 0x226ABE0 Offset: 0x2269DE0 VA: 0x18226ABE0
	public void set_Size(int value) { }

	// RVA: 0x226AB20 Offset: 0x2269D20 VA: 0x18226AB20
	public CodeExpression get_SizeExpression() { }

	// RVA: 0x226ABB0 Offset: 0x2269DB0 VA: 0x18226ABB0
	public void set_SizeExpression(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[DefaultMember("Item")]
[Serializable]
public class CodeExpressionCollection : CollectionBase // TypeDefIndex: 6619
{
	// Properties
	public CodeExpression Item { get; set; }

	// Methods

	// RVA: 0x226D950 Offset: 0x226CB50 VA: 0x18226D950
	public void .ctor() { }

	// RVA: 0x226D920 Offset: 0x226CB20 VA: 0x18226D920
	public void .ctor(CodeExpressionCollection value) { }

	// RVA: 0x226D980 Offset: 0x226CB80 VA: 0x18226D980
	public void .ctor(CodeExpression[] value) { }

	// RVA: 0x226D9B0 Offset: 0x226CBB0 VA: 0x18226D9B0
	public CodeExpression get_Item(int index) { }

	// RVA: 0x226D9E0 Offset: 0x226CBE0 VA: 0x18226D9E0
	public void set_Item(int index, CodeExpression value) { }

	// RVA: 0x226D800 Offset: 0x226CA00 VA: 0x18226D800
	public int Add(CodeExpression value) { }

	// RVA: 0x226D7A0 Offset: 0x226C9A0 VA: 0x18226D7A0
	public void AddRange(CodeExpressionCollection value) { }

	// RVA: 0x226D7D0 Offset: 0x226C9D0 VA: 0x18226D7D0
	public void AddRange(CodeExpression[] value) { }

	// RVA: 0x226D830 Offset: 0x226CA30 VA: 0x18226D830
	public bool Contains(CodeExpression value) { }

	// RVA: 0x226D860 Offset: 0x226CA60 VA: 0x18226D860
	public void CopyTo(CodeExpression[] array, int index) { }

	// RVA: 0x226D890 Offset: 0x226CA90 VA: 0x18226D890
	public int IndexOf(CodeExpression value) { }

	// RVA: 0x226D8C0 Offset: 0x226CAC0 VA: 0x18226D8C0
	public void Insert(int index, CodeExpression value) { }

	// RVA: 0x226D8F0 Offset: 0x226CAF0 VA: 0x18226D8F0
	public void Remove(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeArrayIndexerExpression : CodeExpression // TypeDefIndex: 6620
{
	// Properties
	public CodeExpressionCollection Indices { get; }
	public CodeExpression TargetObject { get; set; }

	// Methods

	// RVA: 0x226AC10 Offset: 0x2269E10 VA: 0x18226AC10
	public void .ctor() { }

	// RVA: 0x226AC40 Offset: 0x2269E40 VA: 0x18226AC40
	public void .ctor(CodeExpression targetObject, CodeExpression[] indices) { }

	// RVA: 0x226AC70 Offset: 0x2269E70 VA: 0x18226AC70
	public CodeExpressionCollection get_Indices() { }

	// RVA: 0x226ACA0 Offset: 0x2269EA0 VA: 0x18226ACA0
	public CodeExpression get_TargetObject() { }

	// RVA: 0x226ACD0 Offset: 0x2269ED0 VA: 0x18226ACD0
	public void set_TargetObject(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeAssignStatement : CodeStatement // TypeDefIndex: 6621
{
	// Properties
	public CodeExpression Left { get; set; }
	public CodeExpression Right { get; set; }

	// Methods

	// RVA: 0x226AD00 Offset: 0x2269F00 VA: 0x18226AD00
	public void .ctor() { }

	// RVA: 0x226AD30 Offset: 0x2269F30 VA: 0x18226AD30
	public void .ctor(CodeExpression left, CodeExpression right) { }

	// RVA: 0x226AD60 Offset: 0x2269F60 VA: 0x18226AD60
	public CodeExpression get_Left() { }

	// RVA: 0x226ADC0 Offset: 0x2269FC0 VA: 0x18226ADC0
	public void set_Left(CodeExpression value) { }

	// RVA: 0x226AD90 Offset: 0x2269F90 VA: 0x18226AD90
	public CodeExpression get_Right() { }

	// RVA: 0x226ADF0 Offset: 0x2269FF0 VA: 0x18226ADF0
	public void set_Right(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeAttachEventStatement : CodeStatement // TypeDefIndex: 6622
{
	// Properties
	public CodeEventReferenceExpression Event { get; set; }
	public CodeExpression Listener { get; set; }

	// Methods

	// RVA: 0x226AE50 Offset: 0x226A050 VA: 0x18226AE50
	public void .ctor() { }

	// RVA: 0x226AE80 Offset: 0x226A080 VA: 0x18226AE80
	public void .ctor(CodeEventReferenceExpression eventRef, CodeExpression listener) { }

	// RVA: 0x226AE20 Offset: 0x226A020 VA: 0x18226AE20
	public void .ctor(CodeExpression targetObject, string eventName, CodeExpression listener) { }

	// RVA: 0x226AEB0 Offset: 0x226A0B0 VA: 0x18226AEB0
	public CodeEventReferenceExpression get_Event() { }

	// RVA: 0x226AF10 Offset: 0x226A110 VA: 0x18226AF10
	public void set_Event(CodeEventReferenceExpression value) { }

	// RVA: 0x226AEE0 Offset: 0x226A0E0 VA: 0x18226AEE0
	public CodeExpression get_Listener() { }

	// RVA: 0x226AF40 Offset: 0x226A140 VA: 0x18226AF40
	public void set_Listener(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeEventReferenceExpression : CodeExpression // TypeDefIndex: 6623
{
	// Properties
	public string EventName { get; set; }
	public CodeExpression TargetObject { get; set; }

	// Methods

	// RVA: 0x226D6B0 Offset: 0x226C8B0 VA: 0x18226D6B0
	public void .ctor() { }

	// RVA: 0x226D680 Offset: 0x226C880 VA: 0x18226D680
	public void .ctor(CodeExpression targetObject, string eventName) { }

	// RVA: 0x226D6E0 Offset: 0x226C8E0 VA: 0x18226D6E0
	public string get_EventName() { }

	// RVA: 0x226D740 Offset: 0x226C940 VA: 0x18226D740
	public void set_EventName(string value) { }

	// RVA: 0x226D710 Offset: 0x226C910 VA: 0x18226D710
	public CodeExpression get_TargetObject() { }

	// RVA: 0x226D770 Offset: 0x226C970 VA: 0x18226D770
	public void set_TargetObject(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeBaseReferenceExpression : CodeExpression // TypeDefIndex: 6624
{
	// Methods

	// RVA: 0x226B750 Offset: 0x226A950 VA: 0x18226B750
	public void .ctor() { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeBinaryOperatorExpression : CodeExpression // TypeDefIndex: 6625
{
	// Properties
	public CodeExpression Left { get; set; }
	public CodeBinaryOperatorType Operator { get; set; }
	public CodeExpression Right { get; set; }

	// Methods

	// RVA: 0x226B7B0 Offset: 0x226A9B0 VA: 0x18226B7B0
	public void .ctor() { }

	// RVA: 0x226B780 Offset: 0x226A980 VA: 0x18226B780
	public void .ctor(CodeExpression left, CodeBinaryOperatorType op, CodeExpression right) { }

	// RVA: 0x226B7E0 Offset: 0x226A9E0 VA: 0x18226B7E0
	public CodeExpression get_Left() { }

	// RVA: 0x226B870 Offset: 0x226AA70 VA: 0x18226B870
	public void set_Left(CodeExpression value) { }

	// RVA: 0x226B810 Offset: 0x226AA10 VA: 0x18226B810
	public CodeBinaryOperatorType get_Operator() { }

	// RVA: 0x226B8A0 Offset: 0x226AAA0 VA: 0x18226B8A0
	public void set_Operator(CodeBinaryOperatorType value) { }

	// RVA: 0x226B840 Offset: 0x226AA40 VA: 0x18226B840
	public CodeExpression get_Right() { }

	// RVA: 0x226B8D0 Offset: 0x226AAD0 VA: 0x18226B8D0
	public void set_Right(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[Serializable]
public enum CodeBinaryOperatorType // TypeDefIndex: 6626
{
	// Fields
	public int value__; // 0x0
	public const CodeBinaryOperatorType Add = 0;
	public const CodeBinaryOperatorType Assign = 5;
	public const CodeBinaryOperatorType BitwiseAnd = 10;
	public const CodeBinaryOperatorType BitwiseOr = 9;
	public const CodeBinaryOperatorType BooleanAnd = 12;
	public const CodeBinaryOperatorType BooleanOr = 11;
	public const CodeBinaryOperatorType Divide = 3;
	public const CodeBinaryOperatorType GreaterThan = 15;
	public const CodeBinaryOperatorType GreaterThanOrEqual = 16;
	public const CodeBinaryOperatorType IdentityEquality = 7;
	public const CodeBinaryOperatorType IdentityInequality = 6;
	public const CodeBinaryOperatorType LessThan = 13;
	public const CodeBinaryOperatorType LessThanOrEqual = 14;
	public const CodeBinaryOperatorType Modulus = 4;
	public const CodeBinaryOperatorType Multiply = 2;
	public const CodeBinaryOperatorType Subtract = 1;
	public const CodeBinaryOperatorType ValueEquality = 8;
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeCastExpression : CodeExpression // TypeDefIndex: 6627
{
	// Properties
	public CodeExpression Expression { get; set; }
	public CodeTypeReference TargetType { get; set; }

	// Methods

	// RVA: 0x226B990 Offset: 0x226AB90 VA: 0x18226B990
	public void .ctor() { }

	// RVA: 0x226B930 Offset: 0x226AB30 VA: 0x18226B930
	public void .ctor(CodeTypeReference targetType, CodeExpression expression) { }

	// RVA: 0x226B960 Offset: 0x226AB60 VA: 0x18226B960
	public void .ctor(string targetType, CodeExpression expression) { }

	// RVA: 0x226B900 Offset: 0x226AB00 VA: 0x18226B900
	public void .ctor(Type targetType, CodeExpression expression) { }

	// RVA: 0x226B9C0 Offset: 0x226ABC0 VA: 0x18226B9C0
	public CodeExpression get_Expression() { }

	// RVA: 0x226BA20 Offset: 0x226AC20 VA: 0x18226BA20
	public void set_Expression(CodeExpression value) { }

	// RVA: 0x226B9F0 Offset: 0x226ABF0 VA: 0x18226B9F0
	public CodeTypeReference get_TargetType() { }

	// RVA: 0x226BA50 Offset: 0x226AC50 VA: 0x18226BA50
	public void set_TargetType(CodeTypeReference value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeCatchClause // TypeDefIndex: 6628
{
	// Properties
	public CodeTypeReference CatchExceptionType { get; set; }
	public string LocalName { get; set; }
	public CodeStatementCollection Statements { get; }

	// Methods

	// RVA: 0x226BCF0 Offset: 0x226AEF0 VA: 0x18226BCF0
	public void .ctor() { }

	// RVA: 0x226BD80 Offset: 0x226AF80 VA: 0x18226BD80
	public void .ctor(string localName) { }

	// RVA: 0x226BD50 Offset: 0x226AF50 VA: 0x18226BD50
	public void .ctor(string localName, CodeTypeReference catchExceptionType) { }

	// RVA: 0x226BD20 Offset: 0x226AF20 VA: 0x18226BD20
	public void .ctor(string localName, CodeTypeReference catchExceptionType, CodeStatement[] statements) { }

	// RVA: 0x226BDB0 Offset: 0x226AFB0 VA: 0x18226BDB0
	public CodeTypeReference get_CatchExceptionType() { }

	// RVA: 0x226BE40 Offset: 0x226B040 VA: 0x18226BE40
	public void set_CatchExceptionType(CodeTypeReference value) { }

	// RVA: 0x226BDE0 Offset: 0x226AFE0 VA: 0x18226BDE0
	public string get_LocalName() { }

	// RVA: 0x226BE70 Offset: 0x226B070 VA: 0x18226BE70
	public void set_LocalName(string value) { }

	// RVA: 0x226BE10 Offset: 0x226B010 VA: 0x18226BE10
	public CodeStatementCollection get_Statements() { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[DefaultMember("Item")]
[ComVisible(True)]
[Serializable]
public class CodeCatchClauseCollection : CollectionBase // TypeDefIndex: 6629
{
	// Properties
	public CodeCatchClause Item { get; set; }

	// Methods

	// RVA: 0x226BC30 Offset: 0x226AE30 VA: 0x18226BC30
	public void .ctor() { }

	// RVA: 0x226BC00 Offset: 0x226AE00 VA: 0x18226BC00
	public void .ctor(CodeCatchClauseCollection value) { }

	// RVA: 0x226BC60 Offset: 0x226AE60 VA: 0x18226BC60
	public void .ctor(CodeCatchClause[] value) { }

	// RVA: 0x226BC90 Offset: 0x226AE90 VA: 0x18226BC90
	public CodeCatchClause get_Item(int index) { }

	// RVA: 0x226BCC0 Offset: 0x226AEC0 VA: 0x18226BCC0
	public void set_Item(int index, CodeCatchClause value) { }

	// RVA: 0x226BAE0 Offset: 0x226ACE0 VA: 0x18226BAE0
	public int Add(CodeCatchClause value) { }

	// RVA: 0x226BAB0 Offset: 0x226ACB0 VA: 0x18226BAB0
	public void AddRange(CodeCatchClauseCollection value) { }

	// RVA: 0x226BA80 Offset: 0x226AC80 VA: 0x18226BA80
	public void AddRange(CodeCatchClause[] value) { }

	// RVA: 0x226BB10 Offset: 0x226AD10 VA: 0x18226BB10
	public bool Contains(CodeCatchClause value) { }

	// RVA: 0x226BB40 Offset: 0x226AD40 VA: 0x18226BB40
	public void CopyTo(CodeCatchClause[] array, int index) { }

	// RVA: 0x226BB70 Offset: 0x226AD70 VA: 0x18226BB70
	public int IndexOf(CodeCatchClause value) { }

	// RVA: 0x226BBA0 Offset: 0x226ADA0 VA: 0x18226BBA0
	public void Insert(int index, CodeCatchClause value) { }

	// RVA: 0x226BBD0 Offset: 0x226ADD0 VA: 0x18226BBD0
	public void Remove(CodeCatchClause value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeChecksumPragma : CodeDirective // TypeDefIndex: 6630
{
	// Properties
	public Guid ChecksumAlgorithmId { get; set; }
	public byte[] ChecksumData { get; set; }
	public string FileName { get; set; }

	// Methods

	// RVA: 0x226BEA0 Offset: 0x226B0A0 VA: 0x18226BEA0
	public void .ctor() { }

	// RVA: 0x226BED0 Offset: 0x226B0D0 VA: 0x18226BED0
	public void .ctor(string fileName, Guid checksumAlgorithmId, byte[] checksumData) { }

	// RVA: 0x226BF00 Offset: 0x226B100 VA: 0x18226BF00
	public Guid get_ChecksumAlgorithmId() { }

	// RVA: 0x226BFA0 Offset: 0x226B1A0 VA: 0x18226BFA0
	public void set_ChecksumAlgorithmId(Guid value) { }

	// RVA: 0x226BF40 Offset: 0x226B140 VA: 0x18226BF40
	public byte[] get_ChecksumData() { }

	// RVA: 0x226BFD0 Offset: 0x226B1D0 VA: 0x18226BFD0
	public void set_ChecksumData(byte[] value) { }

	// RVA: 0x226BF70 Offset: 0x226B170 VA: 0x18226BF70
	public string get_FileName() { }

	// RVA: 0x226C000 Offset: 0x226B200 VA: 0x18226C000
	public void set_FileName(string value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeConditionStatement : CodeStatement // TypeDefIndex: 6631
{
	// Properties
	public CodeExpression Condition { get; set; }
	public CodeStatementCollection FalseStatements { get; }
	public CodeStatementCollection TrueStatements { get; }

	// Methods

	// RVA: 0x226C7E0 Offset: 0x226B9E0 VA: 0x18226C7E0
	public void .ctor() { }

	// RVA: 0x226C810 Offset: 0x226BA10 VA: 0x18226C810
	public void .ctor(CodeExpression condition, CodeStatement[] trueStatements) { }

	// RVA: 0x226C840 Offset: 0x226BA40 VA: 0x18226C840
	public void .ctor(CodeExpression condition, CodeStatement[] trueStatements, CodeStatement[] falseStatements) { }

	// RVA: 0x226C870 Offset: 0x226BA70 VA: 0x18226C870
	public CodeExpression get_Condition() { }

	// RVA: 0x226C900 Offset: 0x226BB00 VA: 0x18226C900
	public void set_Condition(CodeExpression value) { }

	// RVA: 0x226C8A0 Offset: 0x226BAA0 VA: 0x18226C8A0
	public CodeStatementCollection get_FalseStatements() { }

	// RVA: 0x226C8D0 Offset: 0x226BAD0 VA: 0x18226C8D0
	public CodeStatementCollection get_TrueStatements() { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeConstructor : CodeMemberMethod // TypeDefIndex: 6632
{
	// Properties
	public CodeExpressionCollection BaseConstructorArgs { get; }
	public CodeExpressionCollection ChainedConstructorArgs { get; }

	// Methods

	// RVA: 0x226C930 Offset: 0x226BB30 VA: 0x18226C930
	public void .ctor() { }

	// RVA: 0x226C960 Offset: 0x226BB60 VA: 0x18226C960
	public CodeExpressionCollection get_BaseConstructorArgs() { }

	// RVA: 0x226C990 Offset: 0x226BB90 VA: 0x18226C990
	public CodeExpressionCollection get_ChainedConstructorArgs() { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeDefaultValueExpression : CodeExpression // TypeDefIndex: 6633
{
	// Properties
	public CodeTypeReference Type { get; set; }

	// Methods

	// RVA: 0x226C9C0 Offset: 0x226BBC0 VA: 0x18226C9C0
	public void .ctor() { }

	// RVA: 0x226C9F0 Offset: 0x226BBF0 VA: 0x18226C9F0
	public void .ctor(CodeTypeReference type) { }

	// RVA: 0x226CA20 Offset: 0x226BC20 VA: 0x18226CA20
	public CodeTypeReference get_Type() { }

	// RVA: 0x226CA50 Offset: 0x226BC50 VA: 0x18226CA50
	public void set_Type(CodeTypeReference value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeDelegateCreateExpression : CodeExpression // TypeDefIndex: 6634
{
	// Properties
	public CodeTypeReference DelegateType { get; set; }
	public string MethodName { get; set; }
	public CodeExpression TargetObject { get; set; }

	// Methods

	// RVA: 0x226CAB0 Offset: 0x226BCB0 VA: 0x18226CAB0
	public void .ctor() { }

	// RVA: 0x226CA80 Offset: 0x226BC80 VA: 0x18226CA80
	public void .ctor(CodeTypeReference delegateType, CodeExpression targetObject, string methodName) { }

	// RVA: 0x226CAE0 Offset: 0x226BCE0 VA: 0x18226CAE0
	public CodeTypeReference get_DelegateType() { }

	// RVA: 0x226CB70 Offset: 0x226BD70 VA: 0x18226CB70
	public void set_DelegateType(CodeTypeReference value) { }

	// RVA: 0x226CB10 Offset: 0x226BD10 VA: 0x18226CB10
	public string get_MethodName() { }

	// RVA: 0x226CBA0 Offset: 0x226BDA0 VA: 0x18226CBA0
	public void set_MethodName(string value) { }

	// RVA: 0x226CB40 Offset: 0x226BD40 VA: 0x18226CB40
	public CodeExpression get_TargetObject() { }

	// RVA: 0x226CBD0 Offset: 0x226BDD0 VA: 0x18226CBD0
	public void set_TargetObject(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeDelegateInvokeExpression : CodeExpression // TypeDefIndex: 6635
{
	// Properties
	public CodeExpressionCollection Parameters { get; }
	public CodeExpression TargetObject { get; set; }

	// Methods

	// RVA: 0x226CC60 Offset: 0x226BE60 VA: 0x18226CC60
	public void .ctor() { }

	// RVA: 0x226CC00 Offset: 0x226BE00 VA: 0x18226CC00
	public void .ctor(CodeExpression targetObject) { }

	// RVA: 0x226CC30 Offset: 0x226BE30 VA: 0x18226CC30
	public void .ctor(CodeExpression targetObject, CodeExpression[] parameters) { }

	// RVA: 0x226CC90 Offset: 0x226BE90 VA: 0x18226CC90
	public CodeExpressionCollection get_Parameters() { }

	// RVA: 0x226CCC0 Offset: 0x226BEC0 VA: 0x18226CCC0
	public CodeExpression get_TargetObject() { }

	// RVA: 0x226CCF0 Offset: 0x226BEF0 VA: 0x18226CCF0
	public void set_TargetObject(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeDirectionExpression : CodeExpression // TypeDefIndex: 6636
{
	// Properties
	public FieldDirection Direction { get; set; }
	public CodeExpression Expression { get; set; }

	// Methods

	// RVA: 0x226CD20 Offset: 0x226BF20 VA: 0x18226CD20
	public void .ctor() { }

	// RVA: 0x226CD50 Offset: 0x226BF50 VA: 0x18226CD50
	public void .ctor(FieldDirection direction, CodeExpression expression) { }

	// RVA: 0x226CD80 Offset: 0x226BF80 VA: 0x18226CD80
	public FieldDirection get_Direction() { }

	// RVA: 0x226CDE0 Offset: 0x226BFE0 VA: 0x18226CDE0
	public void set_Direction(FieldDirection value) { }

	// RVA: 0x226CDB0 Offset: 0x226BFB0 VA: 0x18226CDB0
	public CodeExpression get_Expression() { }

	// RVA: 0x226CE10 Offset: 0x226C010 VA: 0x18226CE10
	public void set_Expression(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeEntryPointMethod : CodeMemberMethod // TypeDefIndex: 6637
{
	// Methods

	// RVA: 0x226D650 Offset: 0x226C850 VA: 0x18226D650
	public void .ctor() { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeExpressionStatement : CodeStatement // TypeDefIndex: 6638
{
	// Properties
	public CodeExpression Expression { get; set; }

	// Methods

	// RVA: 0x226DA10 Offset: 0x226CC10 VA: 0x18226DA10
	public void .ctor() { }

	// RVA: 0x226DA40 Offset: 0x226CC40 VA: 0x18226DA40
	public void .ctor(CodeExpression expression) { }

	// RVA: 0x226DA70 Offset: 0x226CC70 VA: 0x18226DA70
	public CodeExpression get_Expression() { }

	// RVA: 0x226DAA0 Offset: 0x226CCA0 VA: 0x18226DAA0
	public void set_Expression(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeFieldReferenceExpression : CodeExpression // TypeDefIndex: 6639
{
	// Properties
	public string FieldName { get; set; }
	public CodeExpression TargetObject { get; set; }

	// Methods

	// RVA: 0x226DB00 Offset: 0x226CD00 VA: 0x18226DB00
	public void .ctor() { }

	// RVA: 0x226DB30 Offset: 0x226CD30 VA: 0x18226DB30
	public void .ctor(CodeExpression targetObject, string fieldName) { }

	// RVA: 0x226DB60 Offset: 0x226CD60 VA: 0x18226DB60
	public string get_FieldName() { }

	// RVA: 0x226DBC0 Offset: 0x226CDC0 VA: 0x18226DBC0
	public void set_FieldName(string value) { }

	// RVA: 0x226DB90 Offset: 0x226CD90 VA: 0x18226DB90
	public CodeExpression get_TargetObject() { }

	// RVA: 0x226DBF0 Offset: 0x226CDF0 VA: 0x18226DBF0
	public void set_TargetObject(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeGotoStatement : CodeStatement // TypeDefIndex: 6640
{
	// Properties
	public string Label { get; set; }

	// Methods

	// RVA: 0x226EB50 Offset: 0x226DD50 VA: 0x18226EB50
	public void .ctor() { }

	// RVA: 0x226EB80 Offset: 0x226DD80 VA: 0x18226EB80
	public void .ctor(string label) { }

	// RVA: 0x226EBB0 Offset: 0x226DDB0 VA: 0x18226EBB0
	public string get_Label() { }

	// RVA: 0x226EBE0 Offset: 0x226DDE0 VA: 0x18226EBE0
	public void set_Label(string value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeIndexerExpression : CodeExpression // TypeDefIndex: 6641
{
	// Properties
	public CodeExpressionCollection Indices { get; }
	public CodeExpression TargetObject { get; set; }

	// Methods

	// RVA: 0x226EC40 Offset: 0x226DE40 VA: 0x18226EC40
	public void .ctor() { }

	// RVA: 0x226EC10 Offset: 0x226DE10 VA: 0x18226EC10
	public void .ctor(CodeExpression targetObject, CodeExpression[] indices) { }

	// RVA: 0x226EC70 Offset: 0x226DE70 VA: 0x18226EC70
	public CodeExpressionCollection get_Indices() { }

	// RVA: 0x226ECA0 Offset: 0x226DEA0 VA: 0x18226ECA0
	public CodeExpression get_TargetObject() { }

	// RVA: 0x226ECD0 Offset: 0x226DED0 VA: 0x18226ECD0
	public void set_TargetObject(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeIterationStatement : CodeStatement // TypeDefIndex: 6642
{
	// Properties
	public CodeStatement IncrementStatement { get; set; }
	public CodeStatement InitStatement { get; set; }
	public CodeStatementCollection Statements { get; }
	public CodeExpression TestExpression { get; set; }

	// Methods

	// RVA: 0x226ED30 Offset: 0x226DF30 VA: 0x18226ED30
	public void .ctor() { }

	// RVA: 0x226ED00 Offset: 0x226DF00 VA: 0x18226ED00
	public void .ctor(CodeStatement initStatement, CodeExpression testExpression, CodeStatement incrementStatement, CodeStatement[] statements) { }

	// RVA: 0x226ED60 Offset: 0x226DF60 VA: 0x18226ED60
	public CodeStatement get_IncrementStatement() { }

	// RVA: 0x226EE20 Offset: 0x226E020 VA: 0x18226EE20
	public void set_IncrementStatement(CodeStatement value) { }

	// RVA: 0x226ED90 Offset: 0x226DF90 VA: 0x18226ED90
	public CodeStatement get_InitStatement() { }

	// RVA: 0x226EE50 Offset: 0x226E050 VA: 0x18226EE50
	public void set_InitStatement(CodeStatement value) { }

	// RVA: 0x226EDC0 Offset: 0x226DFC0 VA: 0x18226EDC0
	public CodeStatementCollection get_Statements() { }

	// RVA: 0x226EDF0 Offset: 0x226DFF0 VA: 0x18226EDF0
	public CodeExpression get_TestExpression() { }

	// RVA: 0x226EE80 Offset: 0x226E080 VA: 0x18226EE80
	public void set_TestExpression(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeLabeledStatement : CodeStatement // TypeDefIndex: 6643
{
	// Properties
	public string Label { get; set; }
	public CodeStatement Statement { get; set; }

	// Methods

	// RVA: 0x226EF10 Offset: 0x226E110 VA: 0x18226EF10
	public void .ctor() { }

	// RVA: 0x226EEE0 Offset: 0x226E0E0 VA: 0x18226EEE0
	public void .ctor(string label) { }

	// RVA: 0x226EEB0 Offset: 0x226E0B0 VA: 0x18226EEB0
	public void .ctor(string label, CodeStatement statement) { }

	// RVA: 0x226EF40 Offset: 0x226E140 VA: 0x18226EF40
	public string get_Label() { }

	// RVA: 0x226EFA0 Offset: 0x226E1A0 VA: 0x18226EFA0
	public void set_Label(string value) { }

	// RVA: 0x226EF70 Offset: 0x226E170 VA: 0x18226EF70
	public CodeStatement get_Statement() { }

	// RVA: 0x226EFD0 Offset: 0x226E1D0 VA: 0x18226EFD0
	public void set_Statement(CodeStatement value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeMemberEvent : CodeTypeMember // TypeDefIndex: 6644
{
	// Properties
	public CodeTypeReferenceCollection ImplementationTypes { get; }
	public CodeTypeReference PrivateImplementationType { get; set; }
	public CodeTypeReference Type { get; set; }

	// Methods

	// RVA: 0x226F120 Offset: 0x226E320 VA: 0x18226F120
	public void .ctor() { }

	// RVA: 0x226F150 Offset: 0x226E350 VA: 0x18226F150
	public CodeTypeReferenceCollection get_ImplementationTypes() { }

	// RVA: 0x226F180 Offset: 0x226E380 VA: 0x18226F180
	public CodeTypeReference get_PrivateImplementationType() { }

	// RVA: 0x226F1E0 Offset: 0x226E3E0 VA: 0x18226F1E0
	public void set_PrivateImplementationType(CodeTypeReference value) { }

	// RVA: 0x226F1B0 Offset: 0x226E3B0 VA: 0x18226F1B0
	public CodeTypeReference get_Type() { }

	// RVA: 0x226F210 Offset: 0x226E410 VA: 0x18226F210
	public void set_Type(CodeTypeReference value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeMemberField : CodeTypeMember // TypeDefIndex: 6645
{
	// Properties
	public CodeExpression InitExpression { get; set; }
	public CodeTypeReference Type { get; set; }

	// Methods

	// RVA: 0x226F240 Offset: 0x226E440 VA: 0x18226F240
	public void .ctor() { }

	// RVA: 0x226F2A0 Offset: 0x226E4A0 VA: 0x18226F2A0
	public void .ctor(CodeTypeReference type, string name) { }

	// RVA: 0x226F2D0 Offset: 0x226E4D0 VA: 0x18226F2D0
	public void .ctor(string type, string name) { }

	// RVA: 0x226F270 Offset: 0x226E470 VA: 0x18226F270
	public void .ctor(Type type, string name) { }

	// RVA: 0x226F300 Offset: 0x226E500 VA: 0x18226F300
	public CodeExpression get_InitExpression() { }

	// RVA: 0x226F360 Offset: 0x226E560 VA: 0x18226F360
	public void set_InitExpression(CodeExpression value) { }

	// RVA: 0x226F330 Offset: 0x226E530 VA: 0x18226F330
	public CodeTypeReference get_Type() { }

	// RVA: 0x226F390 Offset: 0x226E590 VA: 0x18226F390
	public void set_Type(CodeTypeReference value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeMemberProperty : CodeTypeMember // TypeDefIndex: 6646
{
	// Properties
	public CodeStatementCollection GetStatements { get; }
	public bool HasGet { get; set; }
	public bool HasSet { get; set; }
	public CodeTypeReferenceCollection ImplementationTypes { get; }
	public CodeParameterDeclarationExpressionCollection Parameters { get; }
	public CodeTypeReference PrivateImplementationType { get; set; }
	public CodeStatementCollection SetStatements { get; }
	public CodeTypeReference Type { get; set; }

	// Methods

	// RVA: 0x226F6C0 Offset: 0x226E8C0 VA: 0x18226F6C0
	public void .ctor() { }

	// RVA: 0x226F6F0 Offset: 0x226E8F0 VA: 0x18226F6F0
	public CodeStatementCollection get_GetStatements() { }

	// RVA: 0x226F720 Offset: 0x226E920 VA: 0x18226F720
	public bool get_HasGet() { }

	// RVA: 0x226F870 Offset: 0x226EA70 VA: 0x18226F870
	public void set_HasGet(bool value) { }

	// RVA: 0x226F750 Offset: 0x226E950 VA: 0x18226F750
	public bool get_HasSet() { }

	// RVA: 0x226F8A0 Offset: 0x226EAA0 VA: 0x18226F8A0
	public void set_HasSet(bool value) { }

	// RVA: 0x226F780 Offset: 0x226E980 VA: 0x18226F780
	public CodeTypeReferenceCollection get_ImplementationTypes() { }

	// RVA: 0x226F7B0 Offset: 0x226E9B0 VA: 0x18226F7B0
	public CodeParameterDeclarationExpressionCollection get_Parameters() { }

	// RVA: 0x226F7E0 Offset: 0x226E9E0 VA: 0x18226F7E0
	public CodeTypeReference get_PrivateImplementationType() { }

	// RVA: 0x226F8D0 Offset: 0x226EAD0 VA: 0x18226F8D0
	public void set_PrivateImplementationType(CodeTypeReference value) { }

	// RVA: 0x226F810 Offset: 0x226EA10 VA: 0x18226F810
	public CodeStatementCollection get_SetStatements() { }

	// RVA: 0x226F840 Offset: 0x226EA40 VA: 0x18226F840
	public CodeTypeReference get_Type() { }

	// RVA: 0x226F900 Offset: 0x226EB00 VA: 0x18226F900
	public void set_Type(CodeTypeReference value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeMethodInvokeExpression : CodeExpression // TypeDefIndex: 6647
{
	// Properties
	public CodeMethodReferenceExpression Method { get; set; }
	public CodeExpressionCollection Parameters { get; }

	// Methods

	// RVA: 0x226F990 Offset: 0x226EB90 VA: 0x18226F990
	public void .ctor() { }

	// RVA: 0x226F930 Offset: 0x226EB30 VA: 0x18226F930
	public void .ctor(CodeExpression targetObject, string methodName, CodeExpression[] parameters) { }

	// RVA: 0x226F960 Offset: 0x226EB60 VA: 0x18226F960
	public void .ctor(CodeMethodReferenceExpression method, CodeExpression[] parameters) { }

	// RVA: 0x226F9C0 Offset: 0x226EBC0 VA: 0x18226F9C0
	public CodeMethodReferenceExpression get_Method() { }

	// RVA: 0x226FA20 Offset: 0x226EC20 VA: 0x18226FA20
	public void set_Method(CodeMethodReferenceExpression value) { }

	// RVA: 0x226F9F0 Offset: 0x226EBF0 VA: 0x18226F9F0
	public CodeExpressionCollection get_Parameters() { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeMethodReferenceExpression : CodeExpression // TypeDefIndex: 6648
{
	// Properties
	public string MethodName { get; set; }
	public CodeExpression TargetObject { get; set; }
	public CodeTypeReferenceCollection TypeArguments { get; }

	// Methods

	// RVA: 0x226FA50 Offset: 0x226EC50 VA: 0x18226FA50
	public void .ctor() { }

	// RVA: 0x226FAB0 Offset: 0x226ECB0 VA: 0x18226FAB0
	public void .ctor(CodeExpression targetObject, string methodName) { }

	// RVA: 0x226FA80 Offset: 0x226EC80 VA: 0x18226FA80
	public void .ctor(CodeExpression targetObject, string methodName, CodeTypeReference[] typeParameters) { }

	// RVA: 0x226FAE0 Offset: 0x226ECE0 VA: 0x18226FAE0
	public string get_MethodName() { }

	// RVA: 0x226FB70 Offset: 0x226ED70 VA: 0x18226FB70
	public void set_MethodName(string value) { }

	// RVA: 0x226FB10 Offset: 0x226ED10 VA: 0x18226FB10
	public CodeExpression get_TargetObject() { }

	// RVA: 0x226FBA0 Offset: 0x226EDA0 VA: 0x18226FBA0
	public void set_TargetObject(CodeExpression value) { }

	// RVA: 0x226FB40 Offset: 0x226ED40 VA: 0x18226FB40
	public CodeTypeReferenceCollection get_TypeArguments() { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeMethodReturnStatement : CodeStatement // TypeDefIndex: 6649
{
	// Properties
	public CodeExpression Expression { get; set; }

	// Methods

	// RVA: 0x226FBD0 Offset: 0x226EDD0 VA: 0x18226FBD0
	public void .ctor() { }

	// RVA: 0x226FC00 Offset: 0x226EE00 VA: 0x18226FC00
	public void .ctor(CodeExpression expression) { }

	// RVA: 0x226FC30 Offset: 0x226EE30 VA: 0x18226FC30
	public CodeExpression get_Expression() { }

	// RVA: 0x226FC60 Offset: 0x226EE60 VA: 0x18226FC60
	public void set_Expression(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeObjectCreateExpression : CodeExpression // TypeDefIndex: 6650
{
	// Properties
	public CodeTypeReference CreateType { get; set; }
	public CodeExpressionCollection Parameters { get; }

	// Methods

	// RVA: 0x2270770 Offset: 0x226F970 VA: 0x182270770
	public void .ctor() { }

	// RVA: 0x2270740 Offset: 0x226F940 VA: 0x182270740
	public void .ctor(CodeTypeReference createType, CodeExpression[] parameters) { }

	// RVA: 0x22707A0 Offset: 0x226F9A0 VA: 0x1822707A0
	public void .ctor(string createType, CodeExpression[] parameters) { }

	// RVA: 0x2270710 Offset: 0x226F910 VA: 0x182270710
	public void .ctor(Type createType, CodeExpression[] parameters) { }

	// RVA: 0x22707D0 Offset: 0x226F9D0 VA: 0x1822707D0
	public CodeTypeReference get_CreateType() { }

	// RVA: 0x2270830 Offset: 0x226FA30 VA: 0x182270830
	public void set_CreateType(CodeTypeReference value) { }

	// RVA: 0x2270800 Offset: 0x226FA00 VA: 0x182270800
	public CodeExpressionCollection get_Parameters() { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodePrimitiveExpression : CodeExpression // TypeDefIndex: 6651
{
	// Properties
	public object Value { get; set; }

	// Methods

	// RVA: 0x2270DD0 Offset: 0x226FFD0 VA: 0x182270DD0
	public void .ctor() { }

	// RVA: 0x2270DA0 Offset: 0x226FFA0 VA: 0x182270DA0
	public void .ctor(object value) { }

	// RVA: 0x2270E00 Offset: 0x2270000 VA: 0x182270E00
	public object get_Value() { }

	// RVA: 0x2270E30 Offset: 0x2270030 VA: 0x182270E30
	public void set_Value(object value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodePropertyReferenceExpression : CodeExpression // TypeDefIndex: 6652
{
	// Properties
	public string PropertyName { get; set; }
	public CodeExpression TargetObject { get; set; }

	// Methods

	// RVA: 0x2270E90 Offset: 0x2270090 VA: 0x182270E90
	public void .ctor() { }

	// RVA: 0x2270E60 Offset: 0x2270060 VA: 0x182270E60
	public void .ctor(CodeExpression targetObject, string propertyName) { }

	// RVA: 0x2270EC0 Offset: 0x22700C0 VA: 0x182270EC0
	public string get_PropertyName() { }

	// RVA: 0x2270F20 Offset: 0x2270120 VA: 0x182270F20
	public void set_PropertyName(string value) { }

	// RVA: 0x2270EF0 Offset: 0x22700F0 VA: 0x182270EF0
	public CodeExpression get_TargetObject() { }

	// RVA: 0x2270F50 Offset: 0x2270150 VA: 0x182270F50
	public void set_TargetObject(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodePropertySetValueReferenceExpression : CodeExpression // TypeDefIndex: 6653
{
	// Methods

	// RVA: 0x2270F80 Offset: 0x2270180 VA: 0x182270F80
	public void .ctor() { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeRegionDirective : CodeDirective // TypeDefIndex: 6654
{
	// Properties
	public CodeRegionMode RegionMode { get; set; }
	public string RegionText { get; set; }

	// Methods

	// RVA: 0x2270FB0 Offset: 0x22701B0 VA: 0x182270FB0
	public void .ctor() { }

	// RVA: 0x2270FE0 Offset: 0x22701E0 VA: 0x182270FE0
	public void .ctor(CodeRegionMode regionMode, string regionText) { }

	// RVA: 0x2271010 Offset: 0x2270210 VA: 0x182271010
	public CodeRegionMode get_RegionMode() { }

	// RVA: 0x2271070 Offset: 0x2270270 VA: 0x182271070
	public void set_RegionMode(CodeRegionMode value) { }

	// RVA: 0x2271040 Offset: 0x2270240 VA: 0x182271040
	public string get_RegionText() { }

	// RVA: 0x22710A0 Offset: 0x22702A0 VA: 0x1822710A0
	public void set_RegionText(string value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[Serializable]
public enum CodeRegionMode // TypeDefIndex: 6655
{
	// Fields
	public int value__; // 0x0
	public const CodeRegionMode End = 2;
	public const CodeRegionMode None = 0;
	public const CodeRegionMode Start = 1;
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeRemoveEventStatement : CodeStatement // TypeDefIndex: 6656
{
	// Properties
	public CodeEventReferenceExpression Event { get; set; }
	public CodeExpression Listener { get; set; }

	// Methods

	// RVA: 0x2271130 Offset: 0x2270330 VA: 0x182271130
	public void .ctor() { }

	// RVA: 0x22710D0 Offset: 0x22702D0 VA: 0x1822710D0
	public void .ctor(CodeEventReferenceExpression eventRef, CodeExpression listener) { }

	// RVA: 0x2271100 Offset: 0x2270300 VA: 0x182271100
	public void .ctor(CodeExpression targetObject, string eventName, CodeExpression listener) { }

	// RVA: 0x2271160 Offset: 0x2270360 VA: 0x182271160
	public CodeEventReferenceExpression get_Event() { }

	// RVA: 0x22711C0 Offset: 0x22703C0 VA: 0x1822711C0
	public void set_Event(CodeEventReferenceExpression value) { }

	// RVA: 0x2271190 Offset: 0x2270390 VA: 0x182271190
	public CodeExpression get_Listener() { }

	// RVA: 0x22711F0 Offset: 0x22703F0 VA: 0x1822711F0
	public void set_Listener(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeSnippetCompileUnit : CodeCompileUnit // TypeDefIndex: 6657
{
	// Properties
	public CodeLinePragma LinePragma { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x2271220 Offset: 0x2270420 VA: 0x182271220
	public void .ctor() { }

	// RVA: 0x2271250 Offset: 0x2270450 VA: 0x182271250
	public void .ctor(string value) { }

	// RVA: 0x2271280 Offset: 0x2270480 VA: 0x182271280
	public CodeLinePragma get_LinePragma() { }

	// RVA: 0x22712E0 Offset: 0x22704E0 VA: 0x1822712E0
	public void set_LinePragma(CodeLinePragma value) { }

	// RVA: 0x22712B0 Offset: 0x22704B0 VA: 0x1822712B0
	public string get_Value() { }

	// RVA: 0x2271310 Offset: 0x2270510 VA: 0x182271310
	public void set_Value(string value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeSnippetExpression : CodeExpression // TypeDefIndex: 6658
{
	// Properties
	public string Value { get; set; }

	// Methods

	// RVA: 0x2271340 Offset: 0x2270540 VA: 0x182271340
	public void .ctor() { }

	// RVA: 0x2271370 Offset: 0x2270570 VA: 0x182271370
	public void .ctor(string value) { }

	// RVA: 0x22713A0 Offset: 0x22705A0 VA: 0x1822713A0
	public string get_Value() { }

	// RVA: 0x22713D0 Offset: 0x22705D0 VA: 0x1822713D0
	public void set_Value(string value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeSnippetStatement : CodeStatement // TypeDefIndex: 6659
{
	// Properties
	public string Value { get; set; }

	// Methods

	// RVA: 0x2271430 Offset: 0x2270630 VA: 0x182271430
	public void .ctor() { }

	// RVA: 0x2271400 Offset: 0x2270600 VA: 0x182271400
	public void .ctor(string value) { }

	// RVA: 0x2271460 Offset: 0x2270660 VA: 0x182271460
	public string get_Value() { }

	// RVA: 0x2271490 Offset: 0x2270690 VA: 0x182271490
	public void set_Value(string value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeSnippetTypeMember : CodeTypeMember // TypeDefIndex: 6660
{
	// Properties
	public string Text { get; set; }

	// Methods

	// RVA: 0x22714C0 Offset: 0x22706C0 VA: 0x1822714C0
	public void .ctor() { }

	// RVA: 0x22714F0 Offset: 0x22706F0 VA: 0x1822714F0
	public void .ctor(string text) { }

	// RVA: 0x2271520 Offset: 0x2270720 VA: 0x182271520
	public string get_Text() { }

	// RVA: 0x2271550 Offset: 0x2270750 VA: 0x182271550
	public void set_Text(string value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeThisReferenceExpression : CodeExpression // TypeDefIndex: 6661
{
	// Methods

	// RVA: 0x2271910 Offset: 0x2270B10 VA: 0x182271910
	public void .ctor() { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeThrowExceptionStatement : CodeStatement // TypeDefIndex: 6662
{
	// Properties
	public CodeExpression ToThrow { get; set; }

	// Methods

	// RVA: 0x2271940 Offset: 0x2270B40 VA: 0x182271940
	public void .ctor() { }

	// RVA: 0x2271970 Offset: 0x2270B70 VA: 0x182271970
	public void .ctor(CodeExpression toThrow) { }

	// RVA: 0x22719A0 Offset: 0x2270BA0 VA: 0x1822719A0
	public CodeExpression get_ToThrow() { }

	// RVA: 0x22719D0 Offset: 0x2270BD0 VA: 0x1822719D0
	public void set_ToThrow(CodeExpression value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeTryCatchFinallyStatement : CodeStatement // TypeDefIndex: 6663
{
	// Properties
	public CodeCatchClauseCollection CatchClauses { get; }
	public CodeStatementCollection FinallyStatements { get; }
	public CodeStatementCollection TryStatements { get; }

	// Methods

	// RVA: 0x2271A30 Offset: 0x2270C30 VA: 0x182271A30
	public void .ctor() { }

	// RVA: 0x2271A60 Offset: 0x2270C60 VA: 0x182271A60
	public void .ctor(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses) { }

	// RVA: 0x2271A00 Offset: 0x2270C00 VA: 0x182271A00
	public void .ctor(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses, CodeStatement[] finallyStatements) { }

	// RVA: 0x2271A90 Offset: 0x2270C90 VA: 0x182271A90
	public CodeCatchClauseCollection get_CatchClauses() { }

	// RVA: 0x2271AC0 Offset: 0x2270CC0 VA: 0x182271AC0
	public CodeStatementCollection get_FinallyStatements() { }

	// RVA: 0x2271AF0 Offset: 0x2270CF0 VA: 0x182271AF0
	public CodeStatementCollection get_TryStatements() { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeTypeConstructor : CodeMemberMethod // TypeDefIndex: 6664
{
	// Methods

	// RVA: 0x2271B20 Offset: 0x2270D20 VA: 0x182271B20
	public void .ctor() { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeTypeDelegate : CodeTypeDeclaration // TypeDefIndex: 6665
{
	// Properties
	public CodeParameterDeclarationExpressionCollection Parameters { get; }
	public CodeTypeReference ReturnType { get; set; }

	// Methods

	// RVA: 0x2271DF0 Offset: 0x2270FF0 VA: 0x182271DF0
	public void .ctor() { }

	// RVA: 0x2271DC0 Offset: 0x2270FC0 VA: 0x182271DC0
	public void .ctor(string name) { }

	// RVA: 0x2271E20 Offset: 0x2271020 VA: 0x182271E20
	public CodeParameterDeclarationExpressionCollection get_Parameters() { }

	// RVA: 0x2271E50 Offset: 0x2271050 VA: 0x182271E50
	public CodeTypeReference get_ReturnType() { }

	// RVA: 0x2271E80 Offset: 0x2271080 VA: 0x182271E80
	public void set_ReturnType(CodeTypeReference value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeTypeOfExpression : CodeExpression // TypeDefIndex: 6666
{
	// Properties
	public CodeTypeReference Type { get; set; }

	// Methods

	// RVA: 0x22723F0 Offset: 0x22715F0 VA: 0x1822723F0
	public void .ctor() { }

	// RVA: 0x22723C0 Offset: 0x22715C0 VA: 0x1822723C0
	public void .ctor(CodeTypeReference type) { }

	// RVA: 0x2272360 Offset: 0x2271560 VA: 0x182272360
	public void .ctor(string type) { }

	// RVA: 0x2272390 Offset: 0x2271590 VA: 0x182272390
	public void .ctor(Type type) { }

	// RVA: 0x2272420 Offset: 0x2271620 VA: 0x182272420
	public CodeTypeReference get_Type() { }

	// RVA: 0x2272450 Offset: 0x2271650 VA: 0x182272450
	public void set_Type(CodeTypeReference value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeTypeReferenceExpression : CodeExpression // TypeDefIndex: 6667
{
	// Properties
	public CodeTypeReference Type { get; set; }

	// Methods

	// RVA: 0x2272BD0 Offset: 0x2271DD0 VA: 0x182272BD0
	public void .ctor() { }

	// RVA: 0x2272B70 Offset: 0x2271D70 VA: 0x182272B70
	public void .ctor(CodeTypeReference type) { }

	// RVA: 0x2272BA0 Offset: 0x2271DA0 VA: 0x182272BA0
	public void .ctor(string type) { }

	// RVA: 0x2272C00 Offset: 0x2271E00 VA: 0x182272C00
	public void .ctor(Type type) { }

	// RVA: 0x2272C30 Offset: 0x2271E30 VA: 0x182272C30
	public CodeTypeReference get_Type() { }

	// RVA: 0x2272C60 Offset: 0x2271E60 VA: 0x182272C60
	public void set_Type(CodeTypeReference value) { }
}

// Namespace: System.CodeDom
[ClassInterface(1)]
[ComVisible(True)]
[Serializable]
public class CodeVariableDeclarationStatement : CodeStatement // TypeDefIndex: 6668
{
	// Properties
	public CodeExpression InitExpression { get; set; }
	public string Name { get; set; }
	public CodeTypeReference Type { get; set; }

	// Methods

	// RVA: 0x22730B0 Offset: 0x22722B0 VA: 0x1822730B0
	public void .ctor() { }

	// RVA: 0x22730E0 Offset: 0x22722E0 VA: 0x1822730E0
	public void .ctor(CodeTypeReference type, string name) { }

	// RVA: 0x2273050 Offset: 0x2272250 VA: 0x182273050
	public void .ctor(CodeTypeReference type, string name, CodeExpression initExpression) { }

	// RVA: 0x2273080 Offset: 0x2272280 VA: 0x182273080
	public void .ctor(string type, string name) { }

	// RVA: 0x2273110 Offset: 0x2272310 VA: 0x182273110
	public void .ctor(string type, string name, CodeExpression initExpression) { }

	// RVA: 0x2272FF0 Offset: 0x22721F0 VA: 0x182272FF0
	public void .ctor(Type type, string name) { }

	// RVA: 0x2273020 Offset: 0x2272220 VA: 0x182273020
	public void .ctor(Type type, string name, CodeExpression initExpression) { }

	// RVA: 0x2273140 Offset: 0x2272340 VA: 0x182273140
	public CodeExpression get_InitExpression() { }

	// RVA: 0x22731D0 Offset: 0x22723D0 VA: 0x1822731D0
	public void set_InitExpression(CodeExpression value) { }

	// RVA: 0x2273170 Offset: 0x2272370 VA: 0x182273170
	public string get_Name() { }

	// RVA: 0x2273200 Offset: 0x2272400 VA: 0x182273200
	public void set_Name(string value) { }

	// RVA: 0x22731A0 Offset: 0x22723A0 VA: 0x1822731A0
	public CodeTypeReference get_Type() { }

	// RVA: 0x2273230 Offset: 0x2272430 VA: 0x182273230
	public void set_Type(CodeTypeReference value) { }
}

// Namespace: System.CodeDom
[ComVisible(True)]
[ClassInterface(1)]
[Serializable]
public class CodeVariableReferenceExpression : CodeExpression // TypeDefIndex: 6669
{
	// Properties
	public string VariableName { get; set; }

	// Methods

	// RVA: 0x2273290 Offset: 0x2272490 VA: 0x182273290
	public void .ctor() { }

	// RVA: 0x2273260 Offset: 0x2272460 VA: 0x182273260
	public void .ctor(string variableName) { }

	// RVA: 0x22732C0 Offset: 0x22724C0 VA: 0x1822732C0
	public string get_VariableName() { }

	// RVA: 0x22732F0 Offset: 0x22724F0 VA: 0x1822732F0
	public void set_VariableName(string value) { }
}

// Namespace: System.CodeDom.Compiler
public abstract class CodeCompiler : CodeGenerator, ICodeCompiler // TypeDefIndex: 6670
{
	// Properties
	protected abstract string CompilerName { get; }
	protected abstract string FileExtension { get; }

	// Methods

	// RVA: 0x226C7B0 Offset: 0x226B9B0 VA: 0x18226C7B0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 112
	protected abstract string get_CompilerName();

	// RVA: -1 Offset: -1 Slot: 113
	protected abstract string get_FileExtension();

	// RVA: -1 Offset: -1 Slot: 114
	protected abstract string CmdArgsFromParameters(CompilerParameters options);

	// RVA: 0x226C540 Offset: 0x226B740 VA: 0x18226C540 Slot: 115
	protected virtual CompilerResults FromDom(CompilerParameters options, CodeCompileUnit e) { }

	// RVA: 0x226C510 Offset: 0x226B710 VA: 0x18226C510 Slot: 116
	protected virtual CompilerResults FromDomBatch(CompilerParameters options, CodeCompileUnit[] ea) { }

	// RVA: 0x226C5A0 Offset: 0x226B7A0 VA: 0x18226C5A0 Slot: 117
	protected virtual CompilerResults FromFile(CompilerParameters options, string fileName) { }

	// RVA: 0x226C570 Offset: 0x226B770 VA: 0x18226C570 Slot: 118
	protected virtual CompilerResults FromFileBatch(CompilerParameters options, string[] fileNames) { }

	// RVA: 0x226C600 Offset: 0x226B800 VA: 0x18226C600 Slot: 119
	protected virtual CompilerResults FromSource(CompilerParameters options, string source) { }

	// RVA: 0x226C5D0 Offset: 0x226B7D0 VA: 0x18226C5D0 Slot: 120
	protected virtual CompilerResults FromSourceBatch(CompilerParameters options, string[] sources) { }

	// RVA: 0x226C630 Offset: 0x226B830 VA: 0x18226C630 Slot: 121
	protected virtual string GetResponseFileCmdArgs(CompilerParameters options, string cmdArgs) { }

	// RVA: 0x226C660 Offset: 0x226B860 VA: 0x18226C660
	protected static string JoinStringArray(string[] sa, string separator) { }

	// RVA: -1 Offset: -1 Slot: 122
	protected abstract void ProcessCompilerOutputLine(CompilerResults results, string line);

	// RVA: 0x226C6C0 Offset: 0x226B8C0 VA: 0x18226C6C0 Slot: 106
	private CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit e) { }

	// RVA: 0x226C690 Offset: 0x226B890 VA: 0x18226C690 Slot: 107
	private CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] ea) { }

	// RVA: 0x226C720 Offset: 0x226B920 VA: 0x18226C720 Slot: 108
	private CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromFile(CompilerParameters options, string fileName) { }

	// RVA: 0x226C6F0 Offset: 0x226B8F0 VA: 0x18226C6F0 Slot: 109
	private CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames) { }

	// RVA: 0x226C780 Offset: 0x226B980 VA: 0x18226C780 Slot: 110
	private CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromSource(CompilerParameters options, string source) { }

	// RVA: 0x226C750 Offset: 0x226B950 VA: 0x18226C750 Slot: 111
	private CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources) { }
}

// Namespace: System.CodeDom.Compiler
public abstract class CodeGenerator : ICodeGenerator // TypeDefIndex: 6671
{
	// Properties
	protected CodeTypeDeclaration CurrentClass { get; }
	protected CodeTypeMember CurrentMember { get; }
	protected string CurrentMemberName { get; }
	protected string CurrentTypeName { get; }
	protected int Indent { get; set; }
	protected bool IsCurrentClass { get; }
	protected bool IsCurrentDelegate { get; }
	protected bool IsCurrentEnum { get; }
	protected bool IsCurrentInterface { get; }
	protected bool IsCurrentStruct { get; }
	protected abstract string NullToken { get; }
	protected CodeGeneratorOptions Options { get; }
	protected TextWriter Output { get; }

	// Methods

	// RVA: 0x226E8B0 Offset: 0x226DAB0 VA: 0x18226E8B0
	protected void .ctor() { }

	// RVA: 0x226E8E0 Offset: 0x226DAE0 VA: 0x18226E8E0
	protected CodeTypeDeclaration get_CurrentClass() { }

	// RVA: 0x226E940 Offset: 0x226DB40 VA: 0x18226E940
	protected CodeTypeMember get_CurrentMember() { }

	// RVA: 0x226E910 Offset: 0x226DB10 VA: 0x18226E910
	protected string get_CurrentMemberName() { }

	// RVA: 0x226E970 Offset: 0x226DB70 VA: 0x18226E970
	protected string get_CurrentTypeName() { }

	// RVA: 0x226E9A0 Offset: 0x226DBA0 VA: 0x18226E9A0
	protected int get_Indent() { }

	// RVA: 0x226EB20 Offset: 0x226DD20 VA: 0x18226EB20
	protected void set_Indent(int value) { }

	// RVA: 0x226E9D0 Offset: 0x226DBD0 VA: 0x18226E9D0
	protected bool get_IsCurrentClass() { }

	// RVA: 0x226EA00 Offset: 0x226DC00 VA: 0x18226EA00
	protected bool get_IsCurrentDelegate() { }

	// RVA: 0x226EA30 Offset: 0x226DC30 VA: 0x18226EA30
	protected bool get_IsCurrentEnum() { }

	// RVA: 0x226EA60 Offset: 0x226DC60 VA: 0x18226EA60
	protected bool get_IsCurrentInterface() { }

	// RVA: 0x226EA90 Offset: 0x226DC90 VA: 0x18226EA90
	protected bool get_IsCurrentStruct() { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract string get_NullToken();

	// RVA: 0x226EAC0 Offset: 0x226DCC0 VA: 0x18226EAC0
	protected CodeGeneratorOptions get_Options() { }

	// RVA: 0x226EAF0 Offset: 0x226DCF0 VA: 0x18226EAF0
	protected TextWriter get_Output() { }

	// RVA: 0x226DE90 Offset: 0x226D090 VA: 0x18226DE90 Slot: 16
	protected virtual void ContinueOnNewLine(string st) { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract string CreateEscapedIdentifier(string value);

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract string CreateValidIdentifier(string value);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void GenerateArgumentReferenceExpression(CodeArgumentReferenceExpression e);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void GenerateArrayCreateExpression(CodeArrayCreateExpression e);

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void GenerateArrayIndexerExpression(CodeArrayIndexerExpression e);

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract void GenerateAssignStatement(CodeAssignStatement e);

	// RVA: -1 Offset: -1 Slot: 23
	protected abstract void GenerateAttachEventStatement(CodeAttachEventStatement e);

	// RVA: -1 Offset: -1 Slot: 24
	protected abstract void GenerateAttributeDeclarationsEnd(CodeAttributeDeclarationCollection attributes);

	// RVA: -1 Offset: -1 Slot: 25
	protected abstract void GenerateAttributeDeclarationsStart(CodeAttributeDeclarationCollection attributes);

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract void GenerateBaseReferenceExpression(CodeBaseReferenceExpression e);

	// RVA: 0x226DEC0 Offset: 0x226D0C0 VA: 0x18226DEC0 Slot: 27
	protected virtual void GenerateBinaryOperatorExpression(CodeBinaryOperatorExpression e) { }

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract void GenerateCastExpression(CodeCastExpression e);

	// RVA: 0x226DEF0 Offset: 0x226D0F0 VA: 0x18226DEF0 Slot: 29
	public virtual void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options) { }

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract void GenerateComment(CodeComment e);

	// RVA: 0x226DF20 Offset: 0x226D120 VA: 0x18226DF20 Slot: 31
	protected virtual void GenerateCommentStatement(CodeCommentStatement e) { }

	// RVA: 0x226DF50 Offset: 0x226D150 VA: 0x18226DF50 Slot: 32
	protected virtual void GenerateCommentStatements(CodeCommentStatementCollection e) { }

	// RVA: 0x226DFE0 Offset: 0x226D1E0 VA: 0x18226DFE0 Slot: 33
	protected virtual void GenerateCompileUnit(CodeCompileUnit e) { }

	// RVA: 0x226DF80 Offset: 0x226D180 VA: 0x18226DF80 Slot: 34
	protected virtual void GenerateCompileUnitEnd(CodeCompileUnit e) { }

	// RVA: 0x226DFB0 Offset: 0x226D1B0 VA: 0x18226DFB0 Slot: 35
	protected virtual void GenerateCompileUnitStart(CodeCompileUnit e) { }

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract void GenerateConditionStatement(CodeConditionStatement e);

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract void GenerateConstructor(CodeConstructor e, CodeTypeDeclaration c);

	// RVA: 0x226E010 Offset: 0x226D210 VA: 0x18226E010 Slot: 38
	protected virtual void GenerateDecimalValue(Decimal d) { }

	// RVA: 0x226E040 Offset: 0x226D240 VA: 0x18226E040 Slot: 39
	protected virtual void GenerateDefaultValueExpression(CodeDefaultValueExpression e) { }

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract void GenerateDelegateCreateExpression(CodeDelegateCreateExpression e);

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract void GenerateDelegateInvokeExpression(CodeDelegateInvokeExpression e);

	// RVA: 0x226E070 Offset: 0x226D270 VA: 0x18226E070 Slot: 42
	protected virtual void GenerateDirectionExpression(CodeDirectionExpression e) { }

	// RVA: 0x226E0A0 Offset: 0x226D2A0 VA: 0x18226E0A0 Slot: 43
	protected virtual void GenerateDirectives(CodeDirectiveCollection directives) { }

	// RVA: 0x226E0D0 Offset: 0x226D2D0 VA: 0x18226E0D0 Slot: 44
	protected virtual void GenerateDoubleValue(double d) { }

	// RVA: -1 Offset: -1 Slot: 45
	protected abstract void GenerateEntryPointMethod(CodeEntryPointMethod e, CodeTypeDeclaration c);

	// RVA: -1 Offset: -1 Slot: 46
	protected abstract void GenerateEvent(CodeMemberEvent e, CodeTypeDeclaration c);

	// RVA: -1 Offset: -1 Slot: 47
	protected abstract void GenerateEventReferenceExpression(CodeEventReferenceExpression e);

	// RVA: 0x226E100 Offset: 0x226D300 VA: 0x18226E100
	protected void GenerateExpression(CodeExpression e) { }

	// RVA: -1 Offset: -1 Slot: 48
	protected abstract void GenerateExpressionStatement(CodeExpressionStatement e);

	// RVA: -1 Offset: -1 Slot: 49
	protected abstract void GenerateField(CodeMemberField e);

	// RVA: -1 Offset: -1 Slot: 50
	protected abstract void GenerateFieldReferenceExpression(CodeFieldReferenceExpression e);

	// RVA: -1 Offset: -1 Slot: 51
	protected abstract void GenerateGotoStatement(CodeGotoStatement e);

	// RVA: -1 Offset: -1 Slot: 52
	protected abstract void GenerateIndexerExpression(CodeIndexerExpression e);

	// RVA: -1 Offset: -1 Slot: 53
	protected abstract void GenerateIterationStatement(CodeIterationStatement e);

	// RVA: -1 Offset: -1 Slot: 54
	protected abstract void GenerateLabeledStatement(CodeLabeledStatement e);

	// RVA: -1 Offset: -1 Slot: 55
	protected abstract void GenerateLinePragmaEnd(CodeLinePragma e);

	// RVA: -1 Offset: -1 Slot: 56
	protected abstract void GenerateLinePragmaStart(CodeLinePragma e);

	// RVA: -1 Offset: -1 Slot: 57
	protected abstract void GenerateMethod(CodeMemberMethod e, CodeTypeDeclaration c);

	// RVA: -1 Offset: -1 Slot: 58
	protected abstract void GenerateMethodInvokeExpression(CodeMethodInvokeExpression e);

	// RVA: -1 Offset: -1 Slot: 59
	protected abstract void GenerateMethodReferenceExpression(CodeMethodReferenceExpression e);

	// RVA: -1 Offset: -1 Slot: 60
	protected abstract void GenerateMethodReturnStatement(CodeMethodReturnStatement e);

	// RVA: 0x226E160 Offset: 0x226D360 VA: 0x18226E160 Slot: 61
	protected virtual void GenerateNamespace(CodeNamespace e) { }

	// RVA: -1 Offset: -1 Slot: 62
	protected abstract void GenerateNamespaceEnd(CodeNamespace e);

	// RVA: -1 Offset: -1 Slot: 63
	protected abstract void GenerateNamespaceImport(CodeNamespaceImport e);

	// RVA: 0x226E130 Offset: 0x226D330 VA: 0x18226E130
	protected void GenerateNamespaceImports(CodeNamespace e) { }

	// RVA: 0x226E190 Offset: 0x226D390 VA: 0x18226E190
	protected void GenerateNamespaces(CodeCompileUnit e) { }

	// RVA: -1 Offset: -1 Slot: 64
	protected abstract void GenerateNamespaceStart(CodeNamespace e);

	// RVA: -1 Offset: -1 Slot: 65
	protected abstract void GenerateObjectCreateExpression(CodeObjectCreateExpression e);

	// RVA: 0x226E1C0 Offset: 0x226D3C0 VA: 0x18226E1C0 Slot: 66
	protected virtual void GenerateParameterDeclarationExpression(CodeParameterDeclarationExpression e) { }

	// RVA: 0x226E1F0 Offset: 0x226D3F0 VA: 0x18226E1F0 Slot: 67
	protected virtual void GeneratePrimitiveExpression(CodePrimitiveExpression e) { }

	// RVA: -1 Offset: -1 Slot: 68
	protected abstract void GenerateProperty(CodeMemberProperty e, CodeTypeDeclaration c);

	// RVA: -1 Offset: -1 Slot: 69
	protected abstract void GeneratePropertyReferenceExpression(CodePropertyReferenceExpression e);

	// RVA: -1 Offset: -1 Slot: 70
	protected abstract void GeneratePropertySetValueReferenceExpression(CodePropertySetValueReferenceExpression e);

	// RVA: -1 Offset: -1 Slot: 71
	protected abstract void GenerateRemoveEventStatement(CodeRemoveEventStatement e);

	// RVA: 0x226E220 Offset: 0x226D420 VA: 0x18226E220 Slot: 72
	protected virtual void GenerateSingleFloatValue(float s) { }

	// RVA: 0x226E250 Offset: 0x226D450 VA: 0x18226E250 Slot: 73
	protected virtual void GenerateSnippetCompileUnit(CodeSnippetCompileUnit e) { }

	// RVA: -1 Offset: -1 Slot: 74
	protected abstract void GenerateSnippetExpression(CodeSnippetExpression e);

	// RVA: -1 Offset: -1 Slot: 75
	protected abstract void GenerateSnippetMember(CodeSnippetTypeMember e);

	// RVA: 0x226E280 Offset: 0x226D480 VA: 0x18226E280 Slot: 76
	protected virtual void GenerateSnippetStatement(CodeSnippetStatement e) { }

	// RVA: 0x226E2B0 Offset: 0x226D4B0 VA: 0x18226E2B0
	protected void GenerateStatement(CodeStatement e) { }

	// RVA: 0x226E2E0 Offset: 0x226D4E0 VA: 0x18226E2E0
	protected void GenerateStatements(CodeStatementCollection stms) { }

	// RVA: -1 Offset: -1 Slot: 77
	protected abstract void GenerateThisReferenceExpression(CodeThisReferenceExpression e);

	// RVA: -1 Offset: -1 Slot: 78
	protected abstract void GenerateThrowExceptionStatement(CodeThrowExceptionStatement e);

	// RVA: -1 Offset: -1 Slot: 79
	protected abstract void GenerateTryCatchFinallyStatement(CodeTryCatchFinallyStatement e);

	// RVA: -1 Offset: -1 Slot: 80
	protected abstract void GenerateTypeConstructor(CodeTypeConstructor e);

	// RVA: -1 Offset: -1 Slot: 81
	protected abstract void GenerateTypeEnd(CodeTypeDeclaration e);

	// RVA: 0x226E310 Offset: 0x226D510 VA: 0x18226E310 Slot: 82
	protected virtual void GenerateTypeOfExpression(CodeTypeOfExpression e) { }

	// RVA: 0x226E340 Offset: 0x226D540 VA: 0x18226E340 Slot: 83
	protected virtual void GenerateTypeReferenceExpression(CodeTypeReferenceExpression e) { }

	// RVA: 0x226E370 Offset: 0x226D570 VA: 0x18226E370
	protected void GenerateTypes(CodeNamespace e) { }

	// RVA: -1 Offset: -1 Slot: 84
	protected abstract void GenerateTypeStart(CodeTypeDeclaration e);

	// RVA: -1 Offset: -1 Slot: 85
	protected abstract void GenerateVariableDeclarationStatement(CodeVariableDeclarationStatement e);

	// RVA: -1 Offset: -1 Slot: 86
	protected abstract void GenerateVariableReferenceExpression(CodeVariableReferenceExpression e);

	// RVA: -1 Offset: -1 Slot: 87
	protected abstract string GetTypeOutput(CodeTypeReference value);

	// RVA: -1 Offset: -1 Slot: 88
	protected abstract bool IsValidIdentifier(string value);

	// RVA: 0x226E3A0 Offset: 0x226D5A0 VA: 0x18226E3A0
	public static bool IsValidLanguageIndependentIdentifier(string value) { }

	// RVA: 0x226E3D0 Offset: 0x226D5D0 VA: 0x18226E3D0 Slot: 89
	protected virtual void OutputAttributeArgument(CodeAttributeArgument arg) { }

	// RVA: 0x226E400 Offset: 0x226D600 VA: 0x18226E400 Slot: 90
	protected virtual void OutputAttributeDeclarations(CodeAttributeDeclarationCollection attributes) { }

	// RVA: 0x226E430 Offset: 0x226D630 VA: 0x18226E430 Slot: 91
	protected virtual void OutputDirection(FieldDirection dir) { }

	// RVA: 0x226E460 Offset: 0x226D660 VA: 0x18226E460 Slot: 92
	protected virtual void OutputExpressionList(CodeExpressionCollection expressions) { }

	// RVA: 0x226E490 Offset: 0x226D690 VA: 0x18226E490 Slot: 93
	protected virtual void OutputExpressionList(CodeExpressionCollection expressions, bool newlineBetweenItems) { }

	// RVA: 0x226E4C0 Offset: 0x226D6C0 VA: 0x18226E4C0 Slot: 94
	protected virtual void OutputFieldScopeModifier(MemberAttributes attributes) { }

	// RVA: 0x226E4F0 Offset: 0x226D6F0 VA: 0x18226E4F0 Slot: 95
	protected virtual void OutputIdentifier(string ident) { }

	// RVA: 0x226E520 Offset: 0x226D720 VA: 0x18226E520 Slot: 96
	protected virtual void OutputMemberAccessModifier(MemberAttributes attributes) { }

	// RVA: 0x226E550 Offset: 0x226D750 VA: 0x18226E550 Slot: 97
	protected virtual void OutputMemberScopeModifier(MemberAttributes attributes) { }

	// RVA: 0x226E580 Offset: 0x226D780 VA: 0x18226E580 Slot: 98
	protected virtual void OutputOperator(CodeBinaryOperatorType op) { }

	// RVA: 0x226E5B0 Offset: 0x226D7B0 VA: 0x18226E5B0 Slot: 99
	protected virtual void OutputParameters(CodeParameterDeclarationExpressionCollection parameters) { }

	// RVA: -1 Offset: -1 Slot: 100
	protected abstract void OutputType(CodeTypeReference typeRef);

	// RVA: 0x226E5E0 Offset: 0x226D7E0 VA: 0x18226E5E0 Slot: 101
	protected virtual void OutputTypeAttributes(TypeAttributes attributes, bool isStruct, bool isEnum) { }

	// RVA: 0x226E610 Offset: 0x226D810 VA: 0x18226E610 Slot: 102
	protected virtual void OutputTypeNamePair(CodeTypeReference typeRef, string name) { }

	// RVA: -1 Offset: -1 Slot: 103
	protected abstract string QuoteSnippetString(string value);

	// RVA: -1 Offset: -1 Slot: 104
	protected abstract bool Supports(GeneratorSupport support);

	// RVA: 0x226E640 Offset: 0x226D840 VA: 0x18226E640 Slot: 4
	private string System.CodeDom.Compiler.ICodeGenerator.CreateEscapedIdentifier(string value) { }

	// RVA: 0x226E670 Offset: 0x226D870 VA: 0x18226E670 Slot: 5
	private string System.CodeDom.Compiler.ICodeGenerator.CreateValidIdentifier(string value) { }

	// RVA: 0x226E6A0 Offset: 0x226D8A0 VA: 0x18226E6A0 Slot: 6
	private void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromCompileUnit(CodeCompileUnit e, TextWriter w, CodeGeneratorOptions o) { }

	// RVA: 0x226E6D0 Offset: 0x226D8D0 VA: 0x18226E6D0 Slot: 7
	private void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromExpression(CodeExpression e, TextWriter w, CodeGeneratorOptions o) { }

	// RVA: 0x226E700 Offset: 0x226D900 VA: 0x18226E700 Slot: 8
	private void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromNamespace(CodeNamespace e, TextWriter w, CodeGeneratorOptions o) { }

	// RVA: 0x226E730 Offset: 0x226D930 VA: 0x18226E730 Slot: 9
	private void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromStatement(CodeStatement e, TextWriter w, CodeGeneratorOptions o) { }

	// RVA: 0x226E760 Offset: 0x226D960 VA: 0x18226E760 Slot: 10
	private void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromType(CodeTypeDeclaration e, TextWriter w, CodeGeneratorOptions o) { }

	// RVA: 0x226E790 Offset: 0x226D990 VA: 0x18226E790 Slot: 11
	private string System.CodeDom.Compiler.ICodeGenerator.GetTypeOutput(CodeTypeReference type) { }

	// RVA: 0x226E7C0 Offset: 0x226D9C0 VA: 0x18226E7C0 Slot: 12
	private bool System.CodeDom.Compiler.ICodeGenerator.IsValidIdentifier(string value) { }

	// RVA: 0x226E7F0 Offset: 0x226D9F0 VA: 0x18226E7F0 Slot: 13
	private bool System.CodeDom.Compiler.ICodeGenerator.Supports(GeneratorSupport support) { }

	// RVA: 0x226E820 Offset: 0x226DA20 VA: 0x18226E820 Slot: 14
	private void System.CodeDom.Compiler.ICodeGenerator.ValidateIdentifier(string value) { }

	// RVA: 0x226E850 Offset: 0x226DA50 VA: 0x18226E850 Slot: 105
	protected virtual void ValidateIdentifier(string value) { }

	// RVA: 0x226E880 Offset: 0x226DA80 VA: 0x18226E880
	public static void ValidateIdentifiers(CodeObject e) { }
}

// Namespace: System.CodeDom.Compiler
public abstract class CodeParser : ICodeParser // TypeDefIndex: 6672
{
	// Methods

	// RVA: 0x2270D70 Offset: 0x226FF70 VA: 0x182270D70
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract CodeCompileUnit Parse(TextReader codeStream);
}

// Namespace: System.CodeDom.Compiler
public static class Executor // TypeDefIndex: 6673
{
	// Methods

	// RVA: 0x22772B0 Offset: 0x22764B0 VA: 0x1822772B0
	public static void ExecWait(string cmd, TempFileCollection tempFiles) { }

	// RVA: 0x22771F0 Offset: 0x22763F0 VA: 0x1822771F0
	public static int ExecWaitWithCapture(IntPtr userToken, string cmd, TempFileCollection tempFiles, ref string outputName, ref string errorName) { }

	// RVA: 0x2277250 Offset: 0x2276450 VA: 0x182277250
	public static int ExecWaitWithCapture(IntPtr userToken, string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName) { }

	// RVA: 0x2277220 Offset: 0x2276420 VA: 0x182277220
	public static int ExecWaitWithCapture(string cmd, TempFileCollection tempFiles, ref string outputName, ref string errorName) { }

	// RVA: 0x2277280 Offset: 0x2276480 VA: 0x182277280
	public static int ExecWaitWithCapture(string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName) { }
}

// Namespace: System.Security.Permissions
[Serializable]
public sealed class StorePermission : CodeAccessPermission, IUnrestrictedPermission // TypeDefIndex: 6674
{
	// Properties
	public StorePermissionFlags Flags { get; set; }

	// Methods

	// RVA: 0x2282D80 Offset: 0x2281F80 VA: 0x182282D80
	public void .ctor(PermissionState state) { }

	// RVA: 0x2282DB0 Offset: 0x2281FB0 VA: 0x182282DB0
	public void .ctor(StorePermissionFlags flag) { }

	// RVA: 0x2282DE0 Offset: 0x2281FE0 VA: 0x182282DE0
	public StorePermissionFlags get_Flags() { }

	// RVA: 0x2282E10 Offset: 0x2282010 VA: 0x182282E10
	public void set_Flags(StorePermissionFlags value) { }

	// RVA: 0x2282C60 Offset: 0x2281E60 VA: 0x182282C60 Slot: 7
	public override IPermission Copy() { }

	// RVA: 0x2282C90 Offset: 0x2281E90 VA: 0x182282C90 Slot: 9
	public override void FromXml(SecurityElement securityElement) { }

	// RVA: 0x2282CC0 Offset: 0x2281EC0 VA: 0x182282CC0 Slot: 10
	public override IPermission Intersect(IPermission target) { }

	// RVA: 0x2282CF0 Offset: 0x2281EF0 VA: 0x182282CF0 Slot: 11
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x2282D20 Offset: 0x2281F20 VA: 0x182282D20 Slot: 14
	public bool IsUnrestricted() { }

	// RVA: 0x2282D50 Offset: 0x2281F50 VA: 0x182282D50 Slot: 12
	public override SecurityElement ToXml() { }
}

// Namespace: System.Security.Permissions
[Flags]
[Serializable]
public enum StorePermissionFlags // TypeDefIndex: 6675
{
	// Fields
	public int value__; // 0x0
	public const StorePermissionFlags AddToStore = 32;
	public const StorePermissionFlags AllFlags = 247;
	public const StorePermissionFlags CreateStore = 1;
	public const StorePermissionFlags DeleteStore = 2;
	public const StorePermissionFlags EnumerateCertificates = 128;
	public const StorePermissionFlags EnumerateStores = 4;
	public const StorePermissionFlags NoFlags = 0;
	public const StorePermissionFlags OpenStore = 16;
	public const StorePermissionFlags RemoveFromStore = 64;
}

// Namespace: System.Security.Permissions
[Usage(109, AllowMultiple = True, Inherited = False)]
[Serializable]
public sealed class StorePermissionAttribute : CodeAccessSecurityAttribute // TypeDefIndex: 6676
{
	// Properties
	public bool AddToStore { get; set; }
	public bool CreateStore { get; set; }
	public bool DeleteStore { get; set; }
	public bool EnumerateCertificates { get; set; }
	public bool EnumerateStores { get; set; }
	public StorePermissionFlags Flags { get; set; }
	public bool OpenStore { get; set; }
	public bool RemoveFromStore { get; set; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(SecurityAction action) { }

	// RVA: 0x2282AE0 Offset: 0x2281CE0 VA: 0x182282AE0
	public bool get_AddToStore() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_AddToStore(bool value) { }

	// RVA: 0x2282B10 Offset: 0x2281D10 VA: 0x182282B10
	public bool get_CreateStore() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_CreateStore(bool value) { }

	// RVA: 0x2282B40 Offset: 0x2281D40 VA: 0x182282B40
	public bool get_DeleteStore() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_DeleteStore(bool value) { }

	// RVA: 0x2282B70 Offset: 0x2281D70 VA: 0x182282B70
	public bool get_EnumerateCertificates() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_EnumerateCertificates(bool value) { }

	// RVA: 0x2282BA0 Offset: 0x2281DA0 VA: 0x182282BA0
	public bool get_EnumerateStores() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_EnumerateStores(bool value) { }

	// RVA: 0x2282BD0 Offset: 0x2281DD0 VA: 0x182282BD0
	public StorePermissionFlags get_Flags() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_Flags(StorePermissionFlags value) { }

	// RVA: 0x2282C00 Offset: 0x2281E00 VA: 0x182282C00
	public bool get_OpenStore() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_OpenStore(bool value) { }

	// RVA: 0x2282C30 Offset: 0x2281E30 VA: 0x182282C30
	public bool get_RemoveFromStore() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_RemoveFromStore(bool value) { }

	// RVA: 0x2282AB0 Offset: 0x2281CB0 VA: 0x182282AB0 Slot: 7
	public override IPermission CreatePermission() { }
}

// Namespace: System.Security.Permissions
[Usage(109, AllowMultiple = True, Inherited = False)]
[Serializable]
public sealed class TypeDescriptorPermissionAttribute : CodeAccessSecurityAttribute // TypeDefIndex: 6677
{
	// Properties
	public TypeDescriptorPermissionFlags Flags { get; set; }
	public bool RestrictedRegistrationAccess { get; set; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor(SecurityAction action) { }

	// RVA: 0x2283B40 Offset: 0x2282D40 VA: 0x182283B40
	public TypeDescriptorPermissionFlags get_Flags() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_Flags(TypeDescriptorPermissionFlags value) { }

	// RVA: 0x2283B70 Offset: 0x2282D70 VA: 0x182283B70
	public bool get_RestrictedRegistrationAccess() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_RestrictedRegistrationAccess(bool value) { }

	// RVA: 0x2283B10 Offset: 0x2282D10 VA: 0x182283B10 Slot: 7
	public override IPermission CreatePermission() { }
}

// Namespace: System.Security.Claims
public static class DynamicRoleClaimProvider // TypeDefIndex: 6678
{
	// Methods

	[Obsolete("Use ClaimsAuthenticationManager to add claims to a ClaimsIdentity", True)]
	[EditorBrowsable(1)]
	// RVA: 0x2275780 Offset: 0x2274980 VA: 0x182275780
	public static void AddDynamicRoleClaims(ClaimsIdentity claimsIdentity, IEnumerable<Claim> claims) { }
}

// Namespace: Unity
internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 6679
{
	// Methods

	// RVA: 0x22839B0 Offset: 0x2282BB0 VA: 0x1822839B0
	public static void ThrowNotSupportedException() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 6680
{}

// Namespace: Rewired
public class ActionIdPropertyAttribute : PropertyAttribute // TypeDefIndex: 6681
{
	// Fields
	private Type pOhBaZskjTHDxcxbPUVoUhsOLebB; // 0x10

	// Properties
	public Type Type { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Type get_Type() { }

	// RVA: 0x18BAE30 Offset: 0x18BA030 VA: 0x1818BAE30
	public void .ctor(Type ) { }
}

// Namespace: Rewired
public class PlayerIdPropertyAttribute : PropertyAttribute // TypeDefIndex: 6682
{
	// Fields
	private Type pOhBaZskjTHDxcxbPUVoUhsOLebB; // 0x10

	// Properties
	public Type Type { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Type get_Type() { }

	// RVA: 0x18BAE30 Offset: 0x18BA030 VA: 0x1818BAE30
	public void .ctor(Type ) { }
}

// Namespace: Rewired
public sealed class ControllerStatusChangedEventArgs : EventArgs // TypeDefIndex: 6683
{
	// Fields
	private string NsRFUoBLVeZwnSsExKWhwStYeoRV; // 0x10
	private int ywemEHCIFHYFGIaBqcsShHUagHzN; // 0x18
	private ControllerType mssadAAejyKGHIfognJBtXtNdiiIB; // 0x1C

	// Properties
	public string name { get; }
	public int controllerId { get; }
	public ControllerType controllerType { get; }
	public Controller controller { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_name() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_controllerId() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public ControllerType get_controllerType() { }

	// RVA: 0x18C39C0 Offset: 0x18C2BC0 VA: 0x1818C39C0
	public Controller get_controller() { }

	// RVA: 0x18C3940 Offset: 0x18C2B40 VA: 0x1818C3940
	public void .ctor(string , int , ControllerType ) { }
}

// Namespace: Rewired
public sealed class ControllerAssignmentChangedEventArgs : EventArgs // TypeDefIndex: 6684
{
	// Fields
	private bool yvVggLPVEKDXAjKXDHgXyFMgifIgA; // 0x10
	private int rwAEYiLTgxJyqRHIqJhqBzEeRzGE; // 0x14
	private int ywemEHCIFHYFGIaBqcsShHUagHzN; // 0x18
	private ControllerType mssadAAejyKGHIfognJBtXtNdiiIB; // 0x1C

	// Properties
	public bool state { get; }
	public Controller controller { get; }
	public Player player { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_state() { }

	// RVA: 0x18C1C20 Offset: 0x18C0E20 VA: 0x1818C1C20
	public Controller get_controller() { }

	// RVA: 0x18C1CF0 Offset: 0x18C0EF0 VA: 0x1818C1CF0
	public Player get_player() { }

	// RVA: 0x18C1BA0 Offset: 0x18C0DA0 VA: 0x1818C1BA0
	internal void .ctor(int , int , ControllerType , bool ) { }
}

// Namespace: Rewired
public struct InputActionEventData // TypeDefIndex: 6685
{
	// Fields
	private kFuPHwnfsCwuzHDrtzjGMJwdcjDEA TVeFfoapvIZlneWYhOmXCtkHoBxXA; // 0x0
	private InputActionEventType BCBbrCGACEILkEHBFLtljkGADjikB; // 0x8
	public readonly int playerId; // 0xC
	public readonly int actionId; // 0x10
	public readonly UpdateLoopType updateLoop; // 0x14

	// Properties
	public InputActionEventType eventType { get; set; }
	public Player player { get; }
	public string actionName { get; }
	public string actionDescriptiveName { get; }

	// Methods

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public InputActionEventType get_eventType() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	internal void IvFfRHsZmKmdGDIXjGPqFhgGfChR(InputActionEventType ) { }

	// RVA: 0x18C6D40 Offset: 0x18C5F40 VA: 0x1818C6D40
	public Player get_player() { }

	// RVA: 0x18C6C50 Offset: 0x18C5E50 VA: 0x1818C6C50
	public string get_actionName() { }

	// RVA: 0x18C6B50 Offset: 0x18C5D50 VA: 0x1818C6B50
	public string get_actionDescriptiveName() { }

	// RVA: 0x18C6170 Offset: 0x18C5370 VA: 0x1818C6170
	public float GetAxis() { }

	// RVA: 0x18C6030 Offset: 0x18C5230 VA: 0x1818C6030
	public float GetAxisPrev() { }

	// RVA: 0x18C6010 Offset: 0x18C5210 VA: 0x1818C6010
	public float GetAxisDelta() { }

	// RVA: 0x18C6130 Offset: 0x18C5330 VA: 0x1818C6130
	public double GetAxisTimeActive() { }

	// RVA: 0x18C6150 Offset: 0x18C5350 VA: 0x1818C6150
	public double GetAxisTimeInactive() { }

	// RVA: 0x18C6110 Offset: 0x18C5310 VA: 0x1818C6110
	public float GetAxisRaw() { }

	// RVA: 0x18C6090 Offset: 0x18C5290 VA: 0x1818C6090
	public float GetAxisRawDelta() { }

	// RVA: 0x18C60B0 Offset: 0x18C52B0 VA: 0x1818C60B0
	public float GetAxisRawPrev() { }

	// RVA: 0x18C60D0 Offset: 0x18C52D0 VA: 0x1818C60D0
	public double GetAxisRawTimeActive() { }

	// RVA: 0x18C60F0 Offset: 0x18C52F0 VA: 0x1818C60F0
	public double GetAxisRawTimeInactive() { }

	// RVA: 0x18C5FF0 Offset: 0x18C51F0 VA: 0x1818C5FF0
	public AxisCoordinateMode GetAxisCoordinateMode() { }

	// RVA: 0x18C5FD0 Offset: 0x18C51D0 VA: 0x1818C5FD0
	public AxisCoordinateMode GetAxisCoordinateModePrev() { }

	// RVA: 0x18C6070 Offset: 0x18C5270 VA: 0x1818C6070
	public AxisCoordinateMode GetAxisRawCoordinateMode() { }

	// RVA: 0x18C6050 Offset: 0x18C5250 VA: 0x1818C6050
	public AxisCoordinateMode GetAxisRawCoordinateModePrev() { }

	// RVA: 0x18C64F0 Offset: 0x18C56F0 VA: 0x1818C64F0
	public bool GetButton() { }

	// RVA: 0x18C62D0 Offset: 0x18C54D0 VA: 0x1818C62D0
	public bool GetButtonPrev() { }

	// RVA: 0x18C6250 Offset: 0x18C5450 VA: 0x1818C6250
	public bool GetButtonDown() { }

	// RVA: 0x18C64D0 Offset: 0x18C56D0 VA: 0x1818C64D0
	public bool GetButtonUp() { }

	// RVA: 0x18C6390 Offset: 0x18C5590 VA: 0x1818C6390
	public bool GetButtonSinglePressHold() { }

	// RVA: 0x18C6370 Offset: 0x18C5570 VA: 0x1818C6370
	public bool GetButtonSinglePressDown() { }

	// RVA: 0x18C63B0 Offset: 0x18C55B0 VA: 0x1818C63B0
	public bool GetButtonSinglePressUp() { }

	// RVA: 0x18C6190 Offset: 0x18C5390 VA: 0x1818C6190
	public bool GetButtonDoublePressDown() { }

	// RVA: 0x18C61B0 Offset: 0x18C53B0 VA: 0x1818C61B0
	public bool GetButtonDoublePressDown(float speed) { }

	// RVA: 0x18C61D0 Offset: 0x18C53D0 VA: 0x1818C61D0
	public bool GetButtonDoublePressHold() { }

	// RVA: 0x18C61F0 Offset: 0x18C53F0 VA: 0x1818C61F0
	public bool GetButtonDoublePressHold(float speed) { }

	// RVA: 0x18C6210 Offset: 0x18C5410 VA: 0x1818C6210
	public bool GetButtonDoublePressUp() { }

	// RVA: 0x18C6230 Offset: 0x18C5430 VA: 0x1818C6230
	public bool GetButtonDoublePressUp(float speed) { }

	// RVA: 0x18C6480 Offset: 0x18C5680 VA: 0x1818C6480
	public bool GetButtonTimedPress(float time) { }

	// RVA: 0x18C64B0 Offset: 0x18C56B0 VA: 0x1818C64B0
	public bool GetButtonTimedPress(float time, float expireIn) { }

	// RVA: 0x18C6410 Offset: 0x18C5610 VA: 0x1818C6410
	public bool GetButtonTimedPressDown(float time) { }

	// RVA: 0x18C6430 Offset: 0x18C5630 VA: 0x1818C6430
	public bool GetButtonTimedPressUp(float time) { }

	// RVA: 0x18C6460 Offset: 0x18C5660 VA: 0x1818C6460
	public bool GetButtonTimedPressUp(float time, float expireIn) { }

	// RVA: 0x18C6350 Offset: 0x18C5550 VA: 0x1818C6350
	public bool GetButtonShortPress() { }

	// RVA: 0x18C6310 Offset: 0x18C5510 VA: 0x1818C6310
	public bool GetButtonShortPressDown() { }

	// RVA: 0x18C6330 Offset: 0x18C5530 VA: 0x1818C6330
	public bool GetButtonShortPressUp() { }

	// RVA: 0x18C62B0 Offset: 0x18C54B0 VA: 0x1818C62B0
	public bool GetButtonLongPress() { }

	// RVA: 0x18C6270 Offset: 0x18C5470 VA: 0x1818C6270
	public bool GetButtonLongPressDown() { }

	// RVA: 0x18C6290 Offset: 0x18C5490 VA: 0x1818C6290
	public bool GetButtonLongPressUp() { }

	// RVA: 0x18C62F0 Offset: 0x18C54F0 VA: 0x1818C62F0
	public bool GetButtonRepeating() { }

	// RVA: 0x18C63D0 Offset: 0x18C55D0 VA: 0x1818C63D0
	public double GetButtonTimePressed() { }

	// RVA: 0x18C63F0 Offset: 0x18C55F0 VA: 0x1818C63F0
	public double GetButtonTimeUnpressed() { }

	// RVA: 0x18C6900 Offset: 0x18C5B00 VA: 0x1818C6900
	public bool GetNegativeButton() { }

	// RVA: 0x18C66E0 Offset: 0x18C58E0 VA: 0x1818C66E0
	public bool GetNegativeButtonPrev() { }

	// RVA: 0x18C6660 Offset: 0x18C5860 VA: 0x1818C6660
	public bool GetNegativeButtonDown() { }

	// RVA: 0x18C68E0 Offset: 0x18C5AE0 VA: 0x1818C68E0
	public bool GetNegativeButtonUp() { }

	// RVA: 0x18C67A0 Offset: 0x18C59A0 VA: 0x1818C67A0
	public bool GetNegativeButtonSinglePressHold() { }

	// RVA: 0x18C6780 Offset: 0x18C5980 VA: 0x1818C6780
	public bool GetNegativeButtonSinglePressDown() { }

	// RVA: 0x18C67C0 Offset: 0x18C59C0 VA: 0x1818C67C0
	public bool GetNegativeButtonSinglePressUp() { }

	// RVA: 0x18C65C0 Offset: 0x18C57C0 VA: 0x1818C65C0
	public bool GetNegativeButtonDoublePressDown() { }

	// RVA: 0x18C65A0 Offset: 0x18C57A0 VA: 0x1818C65A0
	public bool GetNegativeButtonDoublePressDown(float speed) { }

	// RVA: 0x18C65E0 Offset: 0x18C57E0 VA: 0x1818C65E0
	public bool GetNegativeButtonDoublePressHold() { }

	// RVA: 0x18C6600 Offset: 0x18C5800 VA: 0x1818C6600
	public bool GetNegativeButtonDoublePressHold(float speed) { }

	// RVA: 0x18C6620 Offset: 0x18C5820 VA: 0x1818C6620
	public bool GetNegativeButtonDoublePressUp() { }

	// RVA: 0x18C6640 Offset: 0x18C5840 VA: 0x1818C6640
	public bool GetNegativeButtonDoublePressUp(float speed) { }

	// RVA: 0x18C6890 Offset: 0x18C5A90 VA: 0x1818C6890
	public bool GetNegativeButtonTimedPress(float time) { }

	// RVA: 0x18C68C0 Offset: 0x18C5AC0 VA: 0x1818C68C0
	public bool GetNegativeButtonTimedPress(float time, float expireIn) { }

	// RVA: 0x18C6820 Offset: 0x18C5A20 VA: 0x1818C6820
	public bool GetNegativeButtonTimedPressDown(float time) { }

	// RVA: 0x18C6840 Offset: 0x18C5A40 VA: 0x1818C6840
	public bool GetNegativeButtonTimedPressUp(float time) { }

	// RVA: 0x18C6870 Offset: 0x18C5A70 VA: 0x1818C6870
	public bool GetNegativeButtonTimedPressUp(float time, float expireIn) { }

	// RVA: 0x18C6760 Offset: 0x18C5960 VA: 0x1818C6760
	public bool GetNegativeButtonShortPress() { }

	// RVA: 0x18C6720 Offset: 0x18C5920 VA: 0x1818C6720
	public bool GetNegativeButtonShortPressDown() { }

	// RVA: 0x18C6740 Offset: 0x18C5940 VA: 0x1818C6740
	public bool GetNegativeButtonShortPressUp() { }

	// RVA: 0x18C66C0 Offset: 0x18C58C0 VA: 0x1818C66C0
	public bool GetNegativeButtonLongPress() { }

	// RVA: 0x18C6680 Offset: 0x18C5880 VA: 0x1818C6680
	public bool GetNegativeButtonLongPressDown() { }

	// RVA: 0x18C66A0 Offset: 0x18C58A0 VA: 0x1818C66A0
	public bool GetNegativeButtonLongPressUp() { }

	// RVA: 0x18C6700 Offset: 0x18C5900 VA: 0x1818C6700
	public bool GetNegativeButtonRepeating() { }

	// RVA: 0x18C67E0 Offset: 0x18C59E0 VA: 0x1818C67E0
	public double GetNegativeButtonTimePressed() { }

	// RVA: 0x18C6800 Offset: 0x18C5A00 VA: 0x1818C6800
	public double GetNegativeButtonTimeUnpressed() { }

	// RVA: 0x18C6510 Offset: 0x18C5710 VA: 0x1818C6510
	public IList<InputActionSourceData> GetCurrentInputSources() { }

	// RVA: 0x18C6A90 Offset: 0x18C5C90 VA: 0x1818C6A90
	public bool IsCurrentInputSource(ControllerType controllerType) { }

	// RVA: 0x18C69D0 Offset: 0x18C5BD0 VA: 0x1818C69D0
	public bool IsCurrentInputSource(ControllerType controllerType, int controllerId) { }

	// RVA: 0x18C6920 Offset: 0x18C5B20 VA: 0x1818C6920
	public bool IsCurrentInputSource(Controller controller) { }

	// RVA: 0x18C6B30 Offset: 0x18C5D30 VA: 0x1818C6B30
	internal void .ctor(kFuPHwnfsCwuzHDrtzjGMJwdcjDEA , int , int , UpdateLoopType ) { }
}

// Namespace: Rewired
public struct ControllerPollingInfo // TypeDefIndex: 6686
{
	// Fields
	private bool dRenyLkDCZjLHXGUzVXpxwEckwL; // 0x0
	private int rwAEYiLTgxJyqRHIqJhqBzEeRzGE; // 0x4
	private int ywemEHCIFHYFGIaBqcsShHUagHzN; // 0x8
	private string PbgoRcYsKkyaXeFwEhPLAIHzEyCiA; // 0x10
	private ControllerType mssadAAejyKGHIfognJBtXtNdiiIB; // 0x18
	private ControllerElementType ttqdXLdpzPeIRrBGzxvaiwBbWePS; // 0x1C
	private int nISbklZmCoWaHWDIpFZtyxRAgQfe; // 0x20
	private Pole EIphZdRMCiotBQfBbuMFdkLpCgvJ; // 0x24
	private string bIhCFMsZJruUXSIVYygqcNraUUQk; // 0x28
	private int dloXlVErIzRNttSTwpuctPZXBqjHA; // 0x30
	private KeyCode sIqpjDzfBwuHElWQXeXVHfuLRuLd; // 0x34

	// Properties
	public bool success { get; set; }
	public int playerId { get; set; }
	public int controllerId { get; set; }
	public string controllerName { get; set; }
	public ControllerType controllerType { get; set; }
	public ControllerElementType elementType { get; set; }
	public int elementIndex { get; set; }
	public Pole axisPole { get; set; }
	public string elementIdentifierName { get; set; }
	public int elementIdentifierId { get; set; }
	public KeyCode keyboardKey { get; set; }
	public Player player { get; }
	public Controller controller { get; }
	public ControllerElementIdentifier elementIdentifier { get; }

	// Methods

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_success() { }

	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	internal void IhCkNlQXKOCSTekuTbqNebfIrnsR(bool ) { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_playerId() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	internal void tizyvKmrgPULSUDDjvsATFdYPPlF(int ) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_controllerId() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	internal void yEJTScHOAKalRJkaeRRAAbYFKNHnB(int ) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_controllerName() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void RwUamjzdDcdEryGLgTckNHFxkwzi(string ) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ControllerType get_controllerType() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	internal void EOOSnSfhnzMKOZzuprFvTGJVuXVU(ControllerType ) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public ControllerElementType get_elementType() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	internal void wzFYdjyUXnvQKzFlkFPZZGZPKwl(ControllerElementType ) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_elementIndex() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	internal void mJWFgRRFAGPjNBLxPorqTdKiwjzG(int ) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public Pole get_axisPole() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	internal void jLmZBrrQpxeLAQvcVIMtMTWpCbVR(Pole ) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_elementIdentifierName() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void FprsrfroWhSLAqQqjTfZPXDtwCjg(string ) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int get_elementIdentifierId() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	internal void CEswvBOKwIPrkvSSfmxyHEyxblgq(int ) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public KeyCode get_keyboardKey() { }

	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	internal void YjibrEfshUaHQwLUjVmCgVkEfVtWA(KeyCode ) { }

	// RVA: 0x18C20F0 Offset: 0x18C12F0 VA: 0x1818C20F0
	public Player get_player() { }

	// RVA: 0x18C1F70 Offset: 0x18C1170 VA: 0x1818C1F70
	public Controller get_controller() { }

	// RVA: 0x18C2040 Offset: 0x18C1240 VA: 0x1818C2040
	public ControllerElementIdentifier get_elementIdentifier() { }

	// RVA: 0x18C1E50 Offset: 0x18C1050 VA: 0x1818C1E50
	internal void .ctor(bool , int , int , string , ControllerType , ControllerElementType , int , Pole , string , int , KeyCode ) { }

	// RVA: 0x18C1EA0 Offset: 0x18C10A0 VA: 0x1818C1EA0
	internal void .ctor(ControllerPollingInfo ) { }

	// RVA: 0x18C1EF0 Offset: 0x18C10F0 VA: 0x1818C1EF0
	internal static ControllerPollingInfo fGKnoKsbigoQCjKandXnqGVWxxYM() { }
}

// Namespace: Rewired
public struct ElementAssignmentConflictInfo // TypeDefIndex: 6687
{
	// Fields
	private bool PWFOThvHttMbtMdbhFdafHXBWuM; // 0x0
	private bool WAgNjHkTYMdGrceJJizNkBcsHxzM; // 0x1
	private int rwAEYiLTgxJyqRHIqJhqBzEeRzGE; // 0x4
	private ControllerType mssadAAejyKGHIfognJBtXtNdiiIB; // 0x8
	private int ywemEHCIFHYFGIaBqcsShHUagHzN; // 0xC
	private int INDWULDPEsJiiXZeJAkwwYJbDxke; // 0x10
	private int drKnFblJinShqsGTdcXAkSzwXtIq; // 0x14
	private ControllerElementType ttqdXLdpzPeIRrBGzxvaiwBbWePS; // 0x18
	private int dloXlVErIzRNttSTwpuctPZXBqjHA; // 0x1C
	private KeyCode gRrCggNxXceYXkTopJnSefITlYkr; // 0x20
	private ModifierKeyFlags HtqcTFdvkoDVnFJQmkUYhtyplmcb; // 0x24
	private int pFIFvsDSemlQRdLPLVmAuFVFNKGkA; // 0x28

	// Properties
	public bool isConflict { get; set; }
	public bool isUserAssignable { get; set; }
	public int playerId { get; set; }
	public ControllerType controllerType { get; set; }
	public int controllerId { get; set; }
	public int controllerMapId { get; set; }
	public int elementMapId { get; set; }
	public ControllerElementType elementType { get; set; }
	public int elementIdentifierId { get; set; }
	public KeyCode keyCode { get; set; }
	public ModifierKeyFlags modifierKeyFlags { get; set; }
	public int actionId { get; set; }
	public Player player { get; }
	public InputAction action { get; }
	public Controller controller { get; }
	public ControllerMap controllerMap { get; }
	public ControllerElementIdentifier elementIdentifier { get; }
	public ActionElementMap elementMap { get; }
	public string elementDisplayName { get; }

	// Methods

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_isConflict() { }

	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	internal void CXAfkHFtZQQijCmpWxQWpaMOajDr(bool ) { }

	// RVA: 0x13147E0 Offset: 0x13139E0 VA: 0x1813147E0
	public bool get_isUserAssignable() { }

	// RVA: 0x18C4840 Offset: 0x18C3A40 VA: 0x1818C4840
	internal void kEsARXEldHrfIurhkpnefljiidkFA(bool ) { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_playerId() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	internal void tizyvKmrgPULSUDDjvsATFdYPPlF(int ) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public ControllerType get_controllerType() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	internal void EOOSnSfhnzMKOZzuprFvTGJVuXVU(ControllerType ) { }

	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_controllerId() { }

	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	internal void yEJTScHOAKalRJkaeRRAAbYFKNHnB(int ) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_controllerMapId() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	internal void qMicuGrfBFpQpfmLPdMEjjPSMZSCb(int ) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_elementMapId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	internal void faINiSmVUhUZoLivQoGCbUFddZVV(int ) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ControllerElementType get_elementType() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	internal void wzFYdjyUXnvQKzFlkFPZZGZPKwl(ControllerElementType ) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_elementIdentifierId() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	internal void CEswvBOKwIPrkvSSfmxyHEyxblgq(int ) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public KeyCode get_keyCode() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	internal void InxhszsVOUsyFBLGrMljbPbMrHfi(KeyCode ) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public ModifierKeyFlags get_modifierKeyFlags() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	internal void GzqqZlNmLecYRaBOQJLtcFghcRrHA(ModifierKeyFlags ) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_actionId() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	internal void EHykHjPcQLiLEJYdORhqMwJbTWtU(int ) { }

	// RVA: 0x18C4770 Offset: 0x18C3970 VA: 0x1818C4770
	public Player get_player() { }

	// RVA: 0x18C4380 Offset: 0x18C3580 VA: 0x1818C4380
	public InputAction get_action() { }

	// RVA: 0x18C44C0 Offset: 0x18C36C0 VA: 0x1818C44C0
	public Controller get_controller() { }

	// RVA: 0x18C4450 Offset: 0x18C3650 VA: 0x1818C4450
	public ControllerMap get_controllerMap() { }

	// RVA: 0x18C4630 Offset: 0x18C3830 VA: 0x1818C4630
	public ControllerElementIdentifier get_elementIdentifier() { }

	// RVA: 0x18C4680 Offset: 0x18C3880 VA: 0x1818C4680
	public ActionElementMap get_elementMap() { }

	// RVA: 0x18C4590 Offset: 0x18C3790 VA: 0x1818C4590
	public string get_elementDisplayName() { }

	// RVA: 0x18C42E0 Offset: 0x18C34E0 VA: 0x1818C42E0
	public void .ctor(bool , bool , int , ControllerType , int , int , int , int , ControllerElementType , int , KeyCode , ModifierKeyFlags ) { }

	// RVA: 0x18C4330 Offset: 0x18C3530 VA: 0x1818C4330
	public void .ctor(ElementAssignmentConflictInfo ) { }
}

// Namespace: Rewired
public struct ElementAssignmentConflictCheck // TypeDefIndex: 6688
{
	// Fields
	private ElementAssignmentType zYwzPBAhJKhvbwmvdXCDnJQMHyZE; // 0x0
	private int rwAEYiLTgxJyqRHIqJhqBzEeRzGE; // 0x4
	private ControllerType mssadAAejyKGHIfognJBtXtNdiiIB; // 0x8
	private int ywemEHCIFHYFGIaBqcsShHUagHzN; // 0xC
	private int INDWULDPEsJiiXZeJAkwwYJbDxke; // 0x10
	private int RuWVIiytIPKRQIWTptuIFmZXDvWQ; // 0x14
	private int drKnFblJinShqsGTdcXAkSzwXtIq; // 0x18
	private int dloXlVErIzRNttSTwpuctPZXBqjHA; // 0x1C
	private AxisRange TauCMpZmUrXMDAWUBhzVJIReyAVJ; // 0x20
	private KeyCode sIqpjDzfBwuHElWQXeXVHfuLRuLd; // 0x24
	private ModifierKeyFlags HtqcTFdvkoDVnFJQmkUYhtyplmcb; // 0x28
	private int pFIFvsDSemlQRdLPLVmAuFVFNKGkA; // 0x2C
	private Pole YSoMBksWRLBGZHCoCnDDYNsLEJls; // 0x30
	private bool azfyOHWZqrmZRByfZIMBdPQxMYGB; // 0x34

	// Properties
	public ElementAssignmentType elementAssignmentType { get; set; }
	public int playerId { get; set; }
	public ControllerType controllerType { get; set; }
	public int controllerId { get; set; }
	public int controllerMapId { get; set; }
	public int controllerMapCategoryId { get; set; }
	public int elementMapId { get; set; }
	public int elementIdentifierId { get; set; }
	public AxisRange axisRange { get; set; }
	public KeyCode keyboardKey { get; set; }
	public ModifierKeyFlags modifierKeyFlags { get; set; }
	public int actionId { get; set; }
	public Pole axisContribution { get; set; }
	public bool invert { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public ElementAssignmentType get_elementAssignmentType() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_elementAssignmentType(ElementAssignmentType value) { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_playerId() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_playerId(int value) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public ControllerType get_controllerType() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_controllerType(ControllerType value) { }

	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_controllerId() { }

	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_controllerId(int value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_controllerMapId() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_controllerMapId(int value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_controllerMapCategoryId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_controllerMapCategoryId(int value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_elementMapId() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_elementMapId(int value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_elementIdentifierId() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_elementIdentifierId(int value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public AxisRange get_axisRange() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_axisRange(AxisRange value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public KeyCode get_keyboardKey() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_keyboardKey(KeyCode value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public ModifierKeyFlags get_modifierKeyFlags() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_modifierKeyFlags(ModifierKeyFlags value) { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public int get_actionId() { }

	// RVA: 0x5014F0 Offset: 0x5006F0 VA: 0x1805014F0
	public void set_actionId(int value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public Pole get_axisContribution() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_axisContribution(Pole value) { }

	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	public bool get_invert() { }

	// RVA: 0x18C42D0 Offset: 0x18C34D0 VA: 0x1818C42D0
	public void set_invert(bool value) { }

	// RVA: 0x18C4240 Offset: 0x18C3440 VA: 0x1818C4240
	public void .ctor(int , ControllerType , int , int , ElementAssignmentType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool ) { }

	// RVA: 0x18C3E00 Offset: 0x18C3000 VA: 0x1818C3E00
	public void .ctor(int , ControllerType , int , int , ElementAssignmentType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool , int ) { }

	// RVA: 0x18C41A0 Offset: 0x18C33A0 VA: 0x1818C41A0
	public void .ctor(int , ControllerType , int , int , ControllerElementType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool ) { }

	// RVA: 0x18C4050 Offset: 0x18C3250 VA: 0x1818C4050
	public void .ctor(int , ControllerType , int , int , ControllerElementType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool , int ) { }

	// RVA: 0x18C3F30 Offset: 0x18C3130 VA: 0x1818C3F30
	public void .ctor(int , ControllerType , int , int , int , int , bool ) { }

	// RVA: 0x18C3E70 Offset: 0x18C3070 VA: 0x1818C3E70
	public void .ctor(int , ControllerType , int , int , int , int , bool , int ) { }

	// RVA: 0x18C3F90 Offset: 0x18C3190 VA: 0x1818C3F90
	public void .ctor(int , ControllerType , int , int , int , AxisRange , int , Pole ) { }

	// RVA: 0x18C3D40 Offset: 0x18C2F40 VA: 0x1818C3D40
	public void .ctor(int , ControllerType , int , int , int , AxisRange , int , Pole , int ) { }

	// RVA: 0x18C3FF0 Offset: 0x18C31F0 VA: 0x1818C3FF0
	public void .ctor(int , ControllerType , int , int , int , int , Pole ) { }

	// RVA: 0x18C3ED0 Offset: 0x18C30D0 VA: 0x1818C3ED0
	public void .ctor(int , ControllerType , int , int , int , int , Pole , int ) { }

	// RVA: 0x18C3CD0 Offset: 0x18C2ED0 VA: 0x1818C3CD0
	public void .ctor(int , ControllerType , int , int , KeyCode , ModifierKeyFlags , int , Pole ) { }

	// RVA: 0x18C4130 Offset: 0x18C3330 VA: 0x1818C4130
	public void .ctor(int , ControllerType , int , int , KeyCode , ModifierKeyFlags , int , Pole , int ) { }

	// RVA: 0x18C3DA0 Offset: 0x18C2FA0 VA: 0x1818C3DA0
	public void .ctor(ElementAssignmentConflictCheck ) { }

	// RVA: 0x18C3B60 Offset: 0x18C2D60 VA: 0x1818C3B60
	public ElementAssignment ToElementAssignment() { }

	// RVA: 0x18C3BE0 Offset: 0x18C2DE0 VA: 0x1818C3BE0
	public ElementAssignment ToFullAxisAssignment() { }

	// RVA: 0x18C3C90 Offset: 0x18C2E90 VA: 0x1818C3C90
	public ElementAssignment ToSplitAxisAssignment() { }

	// RVA: 0x18C3AF0 Offset: 0x18C2CF0 VA: 0x1818C3AF0
	public ElementAssignment ToButtonAssignment() { }

	// RVA: 0x18C3C20 Offset: 0x18C2E20 VA: 0x1818C3C20
	public ElementAssignment ToKeyboardKeyAssignment() { }

	// RVA: 0x18C42B0 Offset: 0x18C34B0 VA: 0x1818C42B0
	private void qawehhOZbAjoOSSBWorCoeDMVKyM() { }
}

// Namespace: Rewired
public struct ElementAssignment // TypeDefIndex: 6689
{
	// Fields
	public ElementAssignmentType type; // 0x0
	public int elementMapId; // 0x4
	public int elementIdentifierId; // 0x8
	public AxisRange axisRange; // 0xC
	public KeyCode keyboardKey; // 0x10
	public ModifierKeyFlags modifierKeyFlags; // 0x14
	public int actionId; // 0x18
	public Pole axisContribution; // 0x1C
	public bool invert; // 0x20

	// Methods

	// RVA: 0x18C53A0 Offset: 0x18C45A0 VA: 0x1818C53A0
	public void .ctor(ElementAssignmentType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool , int ) { }

	// RVA: 0x18C53E0 Offset: 0x18C45E0 VA: 0x1818C53E0
	public void .ctor(ControllerType , ControllerElementType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool , int ) { }

	// RVA: 0x18C5680 Offset: 0x18C4880 VA: 0x1818C5680
	public void .ctor(ElementAssignmentType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool ) { }

	// RVA: 0x18C5460 Offset: 0x18C4660 VA: 0x1818C5460
	public void .ctor(ControllerType , ControllerElementType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool ) { }

	// RVA: 0x18C5650 Offset: 0x18C4850 VA: 0x1818C5650
	public void .ctor(int , int , bool ) { }

	// RVA: 0x18C5510 Offset: 0x18C4710 VA: 0x1818C5510
	public void .ctor(int , int , bool , int ) { }

	// RVA: 0x18C54E0 Offset: 0x18C46E0 VA: 0x1818C54E0
	public void .ctor(int , AxisRange , int , Pole ) { }

	// RVA: 0x18C5540 Offset: 0x18C4740 VA: 0x1818C5540
	public void .ctor(int , AxisRange , int , Pole , int ) { }

	// RVA: 0x18C5620 Offset: 0x18C4820 VA: 0x1818C5620
	public void .ctor(int , int , Pole ) { }

	// RVA: 0x18C5570 Offset: 0x18C4770 VA: 0x1818C5570
	public void .ctor(int , int , Pole , int ) { }

	// RVA: 0x18C55A0 Offset: 0x18C47A0 VA: 0x1818C55A0
	public void .ctor(KeyCode , ModifierKeyFlags , int , Pole ) { }

	// RVA: 0x18C56C0 Offset: 0x18C48C0 VA: 0x1818C56C0
	public void .ctor(KeyCode , ModifierKeyFlags , int , Pole , int ) { }

	// RVA: 0x18C5010 Offset: 0x18C4210 VA: 0x1818C5010
	public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId) { }

	// RVA: 0x18C4F80 Offset: 0x18C4180 VA: 0x1818C4F80
	public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId) { }

	// RVA: 0x18C50F0 Offset: 0x18C42F0 VA: 0x1818C50F0
	public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert) { }

	// RVA: 0x18C5060 Offset: 0x18C4260 VA: 0x1818C5060
	public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert) { }

	// RVA: 0x18C5140 Offset: 0x18C4340 VA: 0x1818C5140
	public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert) { }

	// RVA: 0x18C5170 Offset: 0x18C4370 VA: 0x1818C5170
	public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert, int elementMapId) { }

	// RVA: 0x18C5300 Offset: 0x18C4500 VA: 0x1818C5300
	public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution) { }

	// RVA: 0x18C52C0 Offset: 0x18C44C0 VA: 0x1818C52C0
	public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution, int elementMapId) { }

	// RVA: 0x18C4F00 Offset: 0x18C4100 VA: 0x1818C4F00
	public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution) { }

	// RVA: 0x18C4F40 Offset: 0x18C4140 VA: 0x1818C4F40
	public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution, int elementMapId) { }

	// RVA: 0x18C5230 Offset: 0x18C4430 VA: 0x1818C5230
	public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution) { }

	// RVA: 0x18C51A0 Offset: 0x18C43A0 VA: 0x1818C51A0
	public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, int elementMapId) { }

	// RVA: 0x18C5340 Offset: 0x18C4540 VA: 0x1818C5340
	public ElementAssignmentConflictCheck ToElementAssignmentConflictCheck() { }
}

// Namespace: Rewired
public sealed class ElementAssignmentInfo // TypeDefIndex: 6690
{
	// Fields
	private readonly ControllerMap SUGdqeYxYDFvxpaJyaCWAtSXvzHpA; // 0x10
	private readonly ControllerElementType ttqdXLdpzPeIRrBGzxvaiwBbWePS; // 0x18
	private readonly int XCBgFmYljNKlBNmxpOgxXvILXQGE; // 0x1C
	private readonly int dloXlVErIzRNttSTwpuctPZXBqjHA; // 0x20
	private readonly AxisRange TauCMpZmUrXMDAWUBhzVJIReyAVJ; // 0x24
	private readonly KeyCode gRrCggNxXceYXkTopJnSefITlYkr; // 0x28
	private readonly ModifierKeyFlags HtqcTFdvkoDVnFJQmkUYhtyplmcb; // 0x2C
	private readonly int pFIFvsDSemlQRdLPLVmAuFVFNKGkA; // 0x30
	private readonly Pole YSoMBksWRLBGZHCoCnDDYNsLEJls; // 0x34
	private readonly bool azfyOHWZqrmZRByfZIMBdPQxMYGB; // 0x38

	// Properties
	public Player player { get; }
	public InputAction action { get; }
	public Controller controller { get; }
	public ControllerType controllerType { get; }
	public int controllerId { get; }
	public ControllerMap controllerMap { get; }
	public ControllerElementIdentifier elementIdentifier { get; }
	public ActionElementMap elementMap { get; }
	public ControllerElementType elementType { get; }
	public Pole axisContribution { get; }
	public AxisRange axisRange { get; }
	public bool invert { get; }
	public KeyCode keyCode { get; }
	public ModifierKeyFlags modifierKeyFlags { get; }
	public string elementDisplayName { get; }

	// Methods

	// RVA: 0x18C4E60 Offset: 0x18C4060 VA: 0x1818C4E60
	public Player get_player() { }

	// RVA: 0x18C4960 Offset: 0x18C3B60 VA: 0x1818C4960
	public InputAction get_action() { }

	// RVA: 0x18C4B80 Offset: 0x18C3D80 VA: 0x1818C4B80
	public Controller get_controller() { }

	// RVA: 0x18C4AE0 Offset: 0x18C3CE0 VA: 0x1818C4AE0
	public ControllerType get_controllerType() { }

	// RVA: 0x18C4A30 Offset: 0x18C3C30 VA: 0x1818C4A30
	public int get_controllerId() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ControllerMap get_controllerMap() { }

	// RVA: 0x18C4DE0 Offset: 0x18C3FE0 VA: 0x1818C4DE0
	public ControllerElementIdentifier get_elementIdentifier() { }

	// RVA: 0x18C4E30 Offset: 0x18C4030 VA: 0x1818C4E30
	public ActionElementMap get_elementMap() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ControllerElementType get_elementType() { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public Pole get_axisContribution() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public AxisRange get_axisRange() { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_invert() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public KeyCode get_keyCode() { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public ModifierKeyFlags get_modifierKeyFlags() { }

	// RVA: 0x18C4C90 Offset: 0x18C3E90 VA: 0x1818C4C90
	public string get_elementDisplayName() { }

	// RVA: 0x18C4850 Offset: 0x18C3A50 VA: 0x1818C4850
	internal void .ctor(ControllerMap , ElementAssignment ) { }
}

// Namespace: Rewired
public struct InputActionSourceData // TypeDefIndex: 6691
{
	// Fields
	private Controller MjXwpaWgoFbhLALGDhNxlBElkuGl; // 0x0
	private ControllerMap SUGdqeYxYDFvxpaJyaCWAtSXvzHpA; // 0x8
	private ActionElementMap ZFPqtPmTIWXYpQHaTswSWXnKcWKc; // 0x10

	// Properties
	public Controller controller { get; }
	public ControllerType controllerType { get; }
	public ControllerMap controllerMap { get; }
	public ActionElementMap actionElementMap { get; }
	public string elementIdentifierName { get; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Controller get_controller() { }

	// RVA: 0x18C6E40 Offset: 0x18C6040 VA: 0x1818C6E40
	public ControllerType get_controllerType() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ControllerMap get_controllerMap() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ActionElementMap get_actionElementMap() { }

	// RVA: 0x18C6E60 Offset: 0x18C6060 VA: 0x1818C6E60
	public string get_elementIdentifierName() { }

	// RVA: 0xD45610 Offset: 0xD44810 VA: 0x180D45610
	internal void .ctor(Controller , ControllerMap , ActionElementMap ) { }

	// RVA: 0x18C6E10 Offset: 0x18C6010 VA: 0x1818C6E10
	internal void .ctor(wSLhttcgJMYvEFQjUPTkLEUWMEcK ) { }
}

// Namespace: Rewired
public struct ControllerIdentifier // TypeDefIndex: 6692
{
	// Fields
	private int ywemEHCIFHYFGIaBqcsShHUagHzN; // 0x0
	private ControllerType mssadAAejyKGHIfognJBtXtNdiiIB; // 0x4
	private Guid JOtCZQwEpMYtpSVARfiyfGvXauho; // 0x8
	private string BazzorGvIrjXLTaiPiNltxRZEFJp; // 0x18
	private Guid UHECCnnILQoILQTtYbKJcpQGYqoo; // 0x20

	// Properties
	public int controllerId { get; set; }
	public ControllerType controllerType { get; set; }
	public Guid hardwareTypeGuid { get; set; }
	public string hardwareIdentifier { get; set; }
	public Guid deviceInstanceGuid { get; set; }
	public static ControllerIdentifier Blank { get; }

	// Methods

	// RVA: 0x18C1DC0 Offset: 0x18C0FC0 VA: 0x1818C1DC0
	internal void .ctor(Controller ) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_controllerId() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_controllerId(int value) { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public ControllerType get_controllerType() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_controllerType(ControllerType value) { }

	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public Guid get_hardwareTypeGuid() { }

	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_hardwareTypeGuid(Guid value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_hardwareIdentifier() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_hardwareIdentifier(string value) { }

	// RVA: 0x416920 Offset: 0x415B20 VA: 0x180416920
	public Guid get_deviceInstanceGuid() { }

	// RVA: 0x416940 Offset: 0x415B40 VA: 0x180416940
	public void set_deviceInstanceGuid(Guid value) { }

	// RVA: 0x18C1E30 Offset: 0x18C1030 VA: 0x1818C1E30
	public static ControllerIdentifier get_Blank() { }
}

// Namespace: 
public enum ControllerSetSelector.Type // TypeDefIndex: 6693
{
	// Fields
	public int value__; // 0x0
	public const ControllerSetSelector.Type All = 0;
	public const ControllerSetSelector.Type ControllerType = 1;
	public const ControllerSetSelector.Type HardwareType = 2;
	public const ControllerSetSelector.Type ControllerTemplateType = 3;
	public const ControllerSetSelector.Type PersistentControllerInstance = 4;
	public const ControllerSetSelector.Type SessionControllerInstance = 5;
}

// Namespace: Rewired
[Preserve]
[Serializable]
public sealed class ControllerSetSelector : ISerializationCallbackReceiver, IDeepCloneable // TypeDefIndex: 6694
{
	// Fields
	[Serialize(Name = "type")]
	[SerializeField]
	private ControllerSetSelector.Type _type; // 0x10
	[Serialize(Name = "controllerType")]
	[SerializeField]
	private ControllerType _controllerType; // 0x14
	[Serialize(Name = "guid")]
	[SerializeField]
	private string _guid; // 0x18
	[SerializeField]
	[Serialize(Name = "hardwareIdentifier")]
	private string _hardwareIdentifier; // 0x20
	[SerializeField]
	[Serialize(Name = "controllerId")]
	private int _controllerId; // 0x28
	private Guid GhzvHzVdCTWDyGjspGDhrzHwUAGO; // 0x2C

	// Properties
	internal bool eJvWnoFGYUeQfBwODVHabSuLEnShA { get; }
	public ControllerSetSelector.Type type { get; set; }
	public ControllerType controllerType { get; set; }
	public Guid hardwareTypeGuid { get; set; }
	public string hardwareIdentifier { get; set; }
	public Guid controllerTemplateTypeGuid { get; set; }
	public Guid deviceInstanceGuid { get; set; }
	public int controllerId { get; set; }

	// Methods

	// RVA: 0x18C3380 Offset: 0x18C2580 VA: 0x1818C3380
	internal void .ctor(ControllerSetSelector.Type ) { }

	// RVA: 0x18C3360 Offset: 0x18C2560 VA: 0x1818C3360
	public void .ctor() { }

	// RVA: 0x18C33B0 Offset: 0x18C25B0 VA: 0x1818C33B0
	public void .ctor(ControllerSetSelector ) { }

	// RVA: 0x18C3450 Offset: 0x18C2650 VA: 0x1818C3450
	internal void .ctor(ControllerSetSelector.Type , ControllerType , string , string , int ) { }

	// RVA: 0x6CB670 Offset: 0x6CA870 VA: 0x1806CB670
	internal bool ZYjPInUMegwtiuEnBCykHOsaKTADb() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ControllerSetSelector.Type get_type() { }

	// RVA: 0x18C38B0 Offset: 0x18C2AB0 VA: 0x1818C38B0
	public void set_type(ControllerSetSelector.Type value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ControllerType get_controllerType() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_controllerType(ControllerType value) { }

	// RVA: 0x18C35D0 Offset: 0x18C27D0 VA: 0x1818C35D0
	public Guid get_hardwareTypeGuid() { }

	// RVA: 0x18C37E0 Offset: 0x18C29E0 VA: 0x1818C37E0
	public void set_hardwareTypeGuid(Guid value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_hardwareIdentifier() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_hardwareIdentifier(string value) { }

	// RVA: 0x18C34F0 Offset: 0x18C26F0 VA: 0x1818C34F0
	public Guid get_controllerTemplateTypeGuid() { }

	// RVA: 0x18C3640 Offset: 0x18C2840 VA: 0x1818C3640
	public void set_controllerTemplateTypeGuid(Guid value) { }

	// RVA: 0x18C3560 Offset: 0x18C2760 VA: 0x1818C3560
	public Guid get_deviceInstanceGuid() { }

	// RVA: 0x18C3710 Offset: 0x18C2910 VA: 0x1818C3710
	public void set_deviceInstanceGuid(Guid value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_controllerId() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_controllerId(int value) { }

	// RVA: 0x18C2270 Offset: 0x18C1470 VA: 0x1818C2270
	public bool Matches(Controller controller) { }

	// RVA: 0x18C3100 Offset: 0x18C2300 VA: 0x1818C3100 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C2200 Offset: 0x18C1400 VA: 0x1818C2200
	private void DFJPLWmINtFcBgfNJVWZSqrmDIMBb() { }

	// RVA: 0x18C32F0 Offset: 0x18C24F0 VA: 0x1818C32F0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x18C24B0 Offset: 0x18C16B0 VA: 0x1818C24B0 Slot: 6
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

	// RVA: 0x18C2580 Offset: 0x18C1780 VA: 0x1818C2580
	public static ControllerSetSelector SelectAll() { }

	// RVA: 0x18C29C0 Offset: 0x18C1BC0 VA: 0x1818C29C0
	public static ControllerSetSelector SelectControllerType(ControllerType controllerType) { }

	// RVA: 0x18C2A20 Offset: 0x18C1C20 VA: 0x1818C2A20
	public static ControllerSetSelector SelectHardwareType(ControllerType controllerType, Guid hardwareTypeGuid, string hardwareIdentifier) { }

	// RVA: 0x18C2B50 Offset: 0x18C1D50 VA: 0x1818C2B50
	public static ControllerSetSelector SelectHardwareType(Controller controller) { }

	// RVA: 0x18C25E0 Offset: 0x18C17E0 VA: 0x1818C25E0
	public static ControllerSetSelector SelectControllerTemplateType(ControllerType controllerType, Guid controllerTemplateTypeGuid) { }

	// RVA: 0x18C2710 Offset: 0x18C1910 VA: 0x1818C2710
	public static ControllerSetSelector SelectControllerTemplateType(IControllerTemplate controllerTemplate) { }

	// RVA: 0x18C2CF0 Offset: 0x18C1EF0 VA: 0x1818C2CF0
	public static ControllerSetSelector SelectPersistentControllerInstance(ControllerType controllerType, Guid deviceInstanceGuid) { }

	// RVA: 0x18C2E20 Offset: 0x18C2020 VA: 0x1818C2E20
	public static ControllerSetSelector SelectPersistentControllerInstance(Controller controller) { }

	// RVA: 0x18C3090 Offset: 0x18C2290 VA: 0x1818C3090
	public static ControllerSetSelector SelectSessionControllerInstance(ControllerType controllerType, int controllerId) { }

	// RVA: 0x18C2FC0 Offset: 0x18C21C0 VA: 0x1818C2FC0
	public static ControllerSetSelector SelectSessionControllerInstance(Controller controller) { }
}

// Namespace: 
internal struct kwvkLbxdAUWCsEnlMjEqbHRlHYiGb : IEquatable<kwvkLbxdAUWCsEnlMjEqbHRlHYiGb> // TypeDefIndex: 6695
{
	// Fields
	public KeyboardKeyCode xuOlZOhmFxenYaaSAdfKBuXrnARw; // 0x0
	public ModifierKey OuAfKQaethYPHaGyURWuCDPVyOoUA; // 0x4
	public ModifierKey dZwIfLvYwBVQUxNkjiIlwWDWRERl; // 0x8
	public ModifierKey HdCiNTKYChjJXqxdjCaYuxKwQimoA; // 0xC

	// Methods

	// RVA: 0xD4CCD0 Offset: 0xD4BED0 VA: 0x180D4CCD0
	public void .ctor(KeyboardKeyCode , ModifierKey , ModifierKey , ModifierKey ) { }

	// RVA: 0x18CDB70 Offset: 0x18CCD70 VA: 0x1818CDB70
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x1799990 Offset: 0x1798B90 VA: 0x181799990 Slot: 4
	public bool Equals(kwvkLbxdAUWCsEnlMjEqbHRlHYiGb other) { }

	// RVA: 0x18CDBA0 Offset: 0x18CCDA0 VA: 0x1818CDBA0 Slot: 0
	public override bool qqgHHTJxDwWCPuPIkOWSbcJkIYoo(object ) { }

	// RVA: 0x18CDB00 Offset: 0x18CCD00 VA: 0x1818CDB00 Slot: 2
	public override int UtvGGBMBYSnBDWQFySenkeOGlrPg() { }

	// RVA: 0x1799990 Offset: 0x1798B90 VA: 0x181799990
	public static bool ntGATOhIdYecgiymfhMunxBAVQfMA(kwvkLbxdAUWCsEnlMjEqbHRlHYiGb , kwvkLbxdAUWCsEnlMjEqbHRlHYiGb ) { }

	// RVA: 0x18CDAC0 Offset: 0x18CCCC0 VA: 0x1818CDAC0
	public static bool NpaIZTwhaYHLEEbXSVcjoupZjNCy(kwvkLbxdAUWCsEnlMjEqbHRlHYiGb , kwvkLbxdAUWCsEnlMjEqbHRlHYiGb ) { }
}

// Namespace: 
[DefaultMember("Item")]
internal struct QsDZbCgWKlJsblLJdqxzzQTkwLXg : IEquatable<QsDZbCgWKlJsblLJdqxzzQTkwLXg> // TypeDefIndex: 6696
{
	// Fields
	public ModifierKey OuAfKQaethYPHaGyURWuCDPVyOoUA; // 0x0
	public ModifierKey dZwIfLvYwBVQUxNkjiIlwWDWRERl; // 0x4
	public ModifierKey HdCiNTKYChjJXqxdjCaYuxKwQimoA; // 0x8

	// Properties
	private ModifierKey VcNaKpZiSjfBNHLSrIsuQryjanXbb { get; set; }

	// Methods

	// RVA: 0x18C9530 Offset: 0x18C8730 VA: 0x1818C9530
	private ModifierKey DqTTDBNrLYGAlGMLwfxhSdzmqObD(int ) { }

	// RVA: 0x18C9660 Offset: 0x18C8860 VA: 0x1818C9660
	private void jWXOgjssRvRquBiRELbAnueIghhs(int , ModifierKey ) { }

	// RVA: 0xD45600 Offset: 0xD44800 VA: 0x180D45600
	public void .ctor(ModifierKey , ModifierKey , ModifierKey ) { }

	// RVA: 0x18C9640 Offset: 0x18C8840 VA: 0x1818C9640
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x18C9730 Offset: 0x18C8930 VA: 0x1818C9730
	public static QsDZbCgWKlJsblLJdqxzzQTkwLXg yfCbmltJYvzIFOiFZgLqhDBhdobo(ModifierKeyFlags ) { }

	// RVA: 0x18C9550 Offset: 0x18C8750 VA: 0x1818C9550 Slot: 4
	public bool Equals(QsDZbCgWKlJsblLJdqxzzQTkwLXg other) { }

	// RVA: 0x18C9680 Offset: 0x18C8880 VA: 0x1818C9680 Slot: 0
	public override bool qqgHHTJxDwWCPuPIkOWSbcJkIYoo(object ) { }

	// RVA: 0x18C95E0 Offset: 0x18C87E0 VA: 0x1818C95E0 Slot: 2
	public override int UtvGGBMBYSnBDWQFySenkeOGlrPg() { }

	// RVA: 0x18C9550 Offset: 0x18C8750 VA: 0x1818C9550
	public static bool ntGATOhIdYecgiymfhMunxBAVQfMA(QsDZbCgWKlJsblLJdqxzzQTkwLXg , QsDZbCgWKlJsblLJdqxzzQTkwLXg ) { }

	// RVA: 0x18C9570 Offset: 0x18C8770 VA: 0x1818C9570
	public static bool NpaIZTwhaYHLEEbXSVcjoupZjNCy(QsDZbCgWKlJsblLJdqxzzQTkwLXg , QsDZbCgWKlJsblLJdqxzzQTkwLXg ) { }
}

// Namespace: 
private class ButtonStateRecorder.RdCHzsWMLaaCOTDtDPUhvdfUWWtN // TypeDefIndex: 6697
{
	// Fields
	public bool weGbcORDZNccLYOrlQZnpBKpgbQF; // 0x10
	public double HTkSenmNENTXHBxGcQgwNpUSaTwiA; // 0x18

	// Methods

	// RVA: 0x18C9830 Offset: 0x18C8A30 VA: 0x1818C9830
	public void MQHErEylLpkabJiPJFPMzIMISIct(ButtonStateRecorder.RdCHzsWMLaaCOTDtDPUhvdfUWWtN ) { }

	// RVA: 0x18C9860 Offset: 0x18C8A60 VA: 0x1818C9860
	public void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal class ButtonStateRecorder // TypeDefIndex: 6698
{
	// Fields
	private const int CZOpSaaMjcnMujKjThUfsCGgnrln = 3;
	private ButtonStateRecorder.RdCHzsWMLaaCOTDtDPUhvdfUWWtN[] SoaTxmiZVylilBUxGputtEzixo; // 0x10
	private ButtonStateRecorder.RdCHzsWMLaaCOTDtDPUhvdfUWWtN[] vFMfKXDOLpyXybqwYBtuUmzjyGlf; // 0x18
	private int ZElvrKDLzcJEwuVInqBdVHuMathm; // 0x20
	private int kcHMkMacxHxiPrbvzaVnlHDqTEKM; // 0x24
	private uint fdKPkoZmHfUBxHcRsYsUwZaobitB; // 0x28

	// Properties
	public double SThalXHNBtDebGqpGQzSgcjjXinBb { get; }
	public double NsVsLrfDAQDAQIPkGNYkblHhSyCFb { get; }
	public double tEdiWOSupYjGXgGEScvLpAGySkMy { get; }
	public double qIBjAAoDlNkZlSXPUpAozpRpYKyJ { get; }
	public double awPgdubvsXqTIoXUmijrPSjyJyqD { get; }
	public double lCfEjyDYChJEwknRZnJnKMUZNahRA { get; }
	public double DDPhkpxVCLHcRLqGEjSFjapSZLkM { get; }

	// Methods

	// RVA: 0x18BC2D0 Offset: 0x18BB4D0 VA: 0x1818BC2D0
	public double aXrGLKgSaUDzICaHWKgiFLvRIDNGA() { }

	// RVA: 0x18BC3D0 Offset: 0x18BB5D0 VA: 0x1818BC3D0
	public double qYAvjIAQPPpldNuJxJkaIijNdeIx() { }

	// RVA: 0x18BC510 Offset: 0x18BB710 VA: 0x1818BC510
	public double skqReLhttVkEgGTEyOzxHOmFUPld() { }

	// RVA: 0x18BC0B0 Offset: 0x18BB2B0 VA: 0x1818BC0B0
	public double TzFgJfEbfVmbQsFAAAJaIFlYApVOA() { }

	// RVA: 0x18BC5E0 Offset: 0x18BB7E0 VA: 0x1818BC5E0
	public double zKmGZBRSnbFtiOxGpNpuPrqgqAYb() { }

	// RVA: 0x18BBBE0 Offset: 0x18BADE0 VA: 0x1818BBBE0
	public double AwaeNwPRblrAxonvqBJqmCPObrnBA() { }

	// RVA: 0x18BC390 Offset: 0x18BB590 VA: 0x1818BC390
	public double ahBENdDUljBXoMANKEDKbOPdIkyMB() { }

	// RVA: 0x18BC150 Offset: 0x18BB350 VA: 0x1818BC150
	public void .ctor() { }

	// RVA: 0x18BBE80 Offset: 0x18BB080 VA: 0x1818BBE80
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV(bool , bool , double ) { }

	// RVA: 0x18BBC50 Offset: 0x18BAE50 VA: 0x1818BBC50
	public bool BotdzRLexTZaBLajwlBUumNjnmyq(float ) { }

	// RVA: 0x18BBD90 Offset: 0x18BAF90 VA: 0x1818BBD90
	public bool FMUaBOGClqjyQSXbxxmKqiiAKMPFA(float ) { }

	// RVA: 0x18BBCF0 Offset: 0x18BAEF0 VA: 0x1818BBCF0
	private static bool BotdzRLexTZaBLajwlBUumNjnmyq(ButtonStateRecorder.RdCHzsWMLaaCOTDtDPUhvdfUWWtN[] , int , float ) { }

	// RVA: 0x18BC490 Offset: 0x18BB690 VA: 0x1818BC490
	private void raNmOZpgVAuvmLtYWlBHCSFIGjGl() { }

	// RVA: 0x18BC030 Offset: 0x18BB230 VA: 0x1818BC030
	public void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }

	// RVA: 0x18BBE60 Offset: 0x18BB060 VA: 0x1818BBE60
	public void JpVNRgErpZIbBesKEebUuAqhdSEo(double ) { }

	// RVA: 0x18BC5B0 Offset: 0x18BB7B0 VA: 0x1818BC5B0
	private static int vOBsLJqbcLsOVGtUtUCyIFoxJklu(int , int ) { }

	// RVA: 0x18BBE30 Offset: 0x18BB030 VA: 0x1818BBE30
	private static int GNqAOXLNLwEwtIkVucyaJzIgBfct(int , int ) { }
}

// Namespace: 
private class snzDlAKUlMXeBVaWzfslXTsdKrGIA.xNzfECUhGrdyQaMvPnGWSNPRZYTAA // TypeDefIndex: 6699
{
	// Fields
	public bool ugrlDdbeiHsmlSraGEPuNcjeTwEh; // 0x10
	public bool weGbcORDZNccLYOrlQZnpBKpgbQF; // 0x11
	public double HTkSenmNENTXHBxGcQgwNpUSaTwiA; // 0x18
	public bool XgOTaTYIGnEfCofEnXaKCzxKCUZx; // 0x20

	// Methods

	// RVA: 0x18CE620 Offset: 0x18CD820 VA: 0x1818CE620
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class snzDlAKUlMXeBVaWzfslXTsdKrGIA // TypeDefIndex: 6700
{
	// Fields
	private const int CZOpSaaMjcnMujKjThUfsCGgnrln = 2;
	private bool ABOGdjpoQCATcAFVlobRVSpCMJhLA; // 0x10
	private bool uwcirWfDEYhAseReXIfGeagMjHWhA; // 0x11
	private bool tRCVhdAoQJSXQoEjfKoAgTJlCiAv; // 0x12
	private float ENdcteKgdtjDpiHTtLYmqoYPhkRhA; // 0x14
	private readonly snzDlAKUlMXeBVaWzfslXTsdKrGIA.xNzfECUhGrdyQaMvPnGWSNPRZYTAA[] vCwMQnNzvkJsTQrfYHEelPvINdqD; // 0x18
	private bool ylbPpbhpECDBiFAPstlGuFwRmScbb; // 0x20
	private bool HHdiPRGmgXsTCNSTuRgmOGnfPNpn; // 0x21

	// Properties
	public bool VuEyWYJKQErTlneiWLdLwmSYKIsO { get; }
	public bool LkknmLIlJLmqSyyGHeUAfBbJsRIB { get; }
	public bool xqZdBCEvUVNJauXdyILzErZGFngDb { get; }
	public float cZcXfaUQLSdMNuidSVChlgzDfnAE { get; }
	public bool IrpDFbwCUvxpDtNoHeNeXzEOzOtf { get; }
	public bool PPQIljnvdmJWAXvgjQqQPADjclIj { get; }
	public bool OrydYaUQIEIlMgWoEsLxcQRjxsxT { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool zyTvRpgVFprcHrjBZppVfBMUJuAO() { }

	// RVA: 0x18CE3F0 Offset: 0x18CD5F0 VA: 0x1818CE3F0
	public bool mROZzZvcDNFsSzqdIEpJFtJWaBuwA() { }

	// RVA: 0x18CE3D0 Offset: 0x18CD5D0 VA: 0x1818CE3D0
	public bool cGAOqUTMIRCDdjBRpBsxEvRuIpFdb() { }

	// RVA: 0x499030 Offset: 0x498230 VA: 0x180499030
	public float GHFhbkBubrrtqmGqXItEGJdJXSrb() { }

	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	public bool uhMSZzPFzLKdnfhwgypwjUfOvoKC() { }

	// RVA: 0x18CE330 Offset: 0x18CD530 VA: 0x1818CE330
	public bool YoOcUgcoDcqRQAALAjqLxBluvsucc() { }

	// RVA: 0x18CE400 Offset: 0x18CD600 VA: 0x1818CE400
	public bool tMMFTAPGzsEaJZmvYaulTcuQmQax() { }

	// RVA: 0x18CE350 Offset: 0x18CD550 VA: 0x1818CE350
	public void .ctor(float ) { }

	// RVA: 0x18CDEC0 Offset: 0x18CD0C0 VA: 0x1818CDEC0
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV(float , bool , bool ) { }

	// RVA: 0x18CE410 Offset: 0x18CD610 VA: 0x1818CE410
	public void wSacnEptJICEonqdAGxnBEDLuVZR(float ) { }

	// RVA: 0x18CE2D0 Offset: 0x18CD4D0 VA: 0x1818CE2D0
	public void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }
}

// Namespace: 
internal class piLLgKjeskLusNuDtSEiraiHqWND // TypeDefIndex: 6701
{
	// Fields
	private float XBOMrrRrnouwRiYmZWdhWiEABNYjA; // 0x10
	private float HZHpWVsBSiDNECooJpKsIdZGnNxPc; // 0x14
	private float aOQjRmFcOfjLbECpacDtFKeVnCVv; // 0x18
	private bool rjOIPKDFCdEWtsLDyzhxyZzzGIZA; // 0x1C
	private double msmFARDTyUBfoDYRnDmKzZLhCsUrA; // 0x20
	private double wAFoRkSROIaGcVZdVuCondoqamGl; // 0x28
	private bool GdLXzcqxWXpTYSnHoDQHCrCGRXVE; // 0x30
	private bool NkLFgsVnxntVgQxoInyaAVXlbOhN; // 0x31

	// Properties
	public bool weGbcORDZNccLYOrlQZnpBKpgbQF { get; }

	// Methods

	// RVA: 0x577B10 Offset: 0x576D10 VA: 0x180577B10
	public bool jdlVdPBudBUcvcslqDJuVXMsKUvv() { }

	// RVA: 0x18CDE70 Offset: 0x18CD070 VA: 0x1818CDE70
	public void .ctor(float , float ) { }

	// RVA: 0x18CDD30 Offset: 0x18CCF30 VA: 0x1818CDD30
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV(bool , bool , float , float , double ) { }

	// RVA: 0x18CDD10 Offset: 0x18CCF10 VA: 0x1818CDD10
	public void LTwNkdXugCJGbmgERwAopyJavimq(float , float ) { }

	// RVA: 0x18CDE30 Offset: 0x18CD030 VA: 0x1818CDE30
	public void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }

	// RVA: 0x18CDE10 Offset: 0x18CD010 VA: 0x1818CDE10
	private void OVAHhXYoWnOfgTkcQdOcZntUEeNb(double ) { }

	// RVA: 0x18CDE50 Offset: 0x18CD050 VA: 0x1818CDE50
	private void YAWdQNEwxNZIRcARogRGbZPamSaJA(bool , double ) { }
}

// Namespace: 
internal class HrlcjemCuLDOTWiWxHeuTfauJxQd // TypeDefIndex: 6702
{
	// Fields
	public float CdEckvrVAeswSaQCfMLbUlJjpTfR; // 0x10
	public ButtonStateFlags mdNAtANHwiAoYIoKusyAaLpVUIyoA; // 0x14
	public ControllerElementType sKjCmMOLFxixaCQzRKUpvBFTerKeA; // 0x18
	public ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x1C
	public Controller oucSTTgcWofhafDPqHrFgmhNLXuaA; // 0x20
	public ControllerMap CKLJUnnpndBsfdLuUgNsJpcsPydNA; // 0x28
	public ActionElementMap eWszhrzTgmaZrKigKDnkYoAPWDCy; // 0x30
	public int IGMCEIeowNOzOwnyZCOBTvzyXbagA; // 0x38
	public bool zfesRKCLztlCfhqKZMFycwLMpUas; // 0x3C
	public bool GTsBBpmyCMTavxHNIXFNkmzNelMO; // 0x3D
	public AxisCoordinateMode uFyItZhxHEkAIRyxWgVjNMFrppxgA; // 0x40

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class XBoAxPyoIvQNXtmkapFQwgBOjQfE.FDujmBdsqcWUxDfkzMZRuVTZRECGA // TypeDefIndex: 6703
{
	// Fields
	private readonly AList<IControllerTemplate> JnGVzZoTBuEUnSSFgOwPgefFkHvP; // 0x10
	private IList jNIIJDKelFhrwklZmRQCQrRjsnUc; // 0x18
	private IList GHYotMJSCzCEPmyhpITOsRmdIYln; // 0x20
	public readonly Type UFWJddMFhjHjXfYKjcudPDznBOzp; // 0x28

	// Methods

	// RVA: 0x18C5A70 Offset: 0x18C4C70 VA: 0x1818C5A70
	public void .ctor(Type ) { }

	// RVA: -1 Offset: -1
	public IList<> IIEcRxAYvDhpRNAocbOJspLHpodHb<>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACCD00 Offset: 0xACBF00 VA: 0x180ACCD00
	|-XBoAxPyoIvQNXtmkapFQwgBOjQfE.FDujmBdsqcWUxDfkzMZRuVTZRECGA.IIEcRxAYvDhpRNAocbOJspLHpodHb<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x18C5AF0 Offset: 0x18C4CF0 VA: 0x1818C5AF0
	public void xXDAAgkpHyujExYwkSGAdhBokBcFb(IControllerTemplate ) { }

	// RVA: 0x18C5970 Offset: 0x18C4B70 VA: 0x1818C5970
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(IControllerTemplate ) { }

	// RVA: -1 Offset: -1
	private void DiipeRdKgVfjItRkfFUsrHlWSLMy<>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACCAC0 Offset: 0xACBCC0 VA: 0x180ACCAC0
	|-XBoAxPyoIvQNXtmkapFQwgBOjQfE.FDujmBdsqcWUxDfkzMZRuVTZRECGA.DiipeRdKgVfjItRkfFUsrHlWSLMy<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
internal class XBoAxPyoIvQNXtmkapFQwgBOjQfE // TypeDefIndex: 6704
{
	// Fields
	private readonly AList<XBoAxPyoIvQNXtmkapFQwgBOjQfE.FDujmBdsqcWUxDfkzMZRuVTZRECGA> GqBguZeqqMnPYiylmdIFJfCWjpCV; // 0x10
	private readonly Type[] dgaNGXPnBhqXWMHPNxkvduwwhHHi; // 0x18
	private readonly Type[] ZBHZQFGBluCQzcRyzYOBGabzsQRj; // 0x20
	private readonly int laSssIqVnuQEFPnkyfJsJONpFfHnA; // 0x28

	// Methods

	// RVA: 0x18CAA10 Offset: 0x18C9C10 VA: 0x1818CAA10
	public void .ctor(Type[] , Type[] ) { }

	// RVA: 0x18CA830 Offset: 0x18C9A30 VA: 0x1818CA830
	public void MyfwOLHNaLNpoXqeunfzNlaPSaWq(Controller ) { }

	// RVA: 0x18CAC00 Offset: 0x18C9E00 VA: 0x1818CAC00
	public void vjixkWvWKpOvYZdKKQsZIFmDIRNc(Controller ) { }

	// RVA: -1 Offset: -1
	public IList<> IIEcRxAYvDhpRNAocbOJspLHpodHb<>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA48D0 Offset: 0xAA3AD0 VA: 0x180AA48D0
	|-XBoAxPyoIvQNXtmkapFQwgBOjQfE.IIEcRxAYvDhpRNAocbOJspLHpodHb<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x18CA7C0 Offset: 0x18C99C0 VA: 0x1818CA7C0
	private XBoAxPyoIvQNXtmkapFQwgBOjQfE.FDujmBdsqcWUxDfkzMZRuVTZRECGA DIbNMkqOFZwnefjmQbsmIMSWPvPk(Type ) { }

	// RVA: 0x18CADE0 Offset: 0x18C9FE0 VA: 0x1818CADE0
	private Type wsGwDHmrXrJqTjhVFImlEBrzpFih(Type ) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
internal abstract class PlatformInitializer // TypeDefIndex: 6705
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object Initialize(IConfigVars_Internal configVars);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IElementIdentifierTool CreateTool(string inputSourceString);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal abstract class PlatformInputManager // TypeDefIndex: 6706
{
	// Fields
	protected Action<BridgedController> _DeviceConnectedEvent; // 0x10
	protected Action<ControllerDisconnectedEventArgs> _DeviceDisconnectedEvent; // 0x18
	protected Action<UpdateControllerInfoEventArgs> _UpdateControllerInfoEvent; // 0x20
	protected Action _SystemDeviceConnectedEvent; // 0x28
	protected Action _SystemDeviceDisconnectedEvent; // 0x30

	// Properties
	public abstract int deviceCount { get; }
	public abstract PlatformInputManager primaryInputManager { get; }
	public abstract IInputSource inputSource { get; }
	public abstract InputSource inputSourceType { get; }

	// Methods

	// RVA: 0x18C8D70 Offset: 0x18C7F70 VA: 0x1818C8D70
	public void add_DeviceConnectedEvent(Action<BridgedController> value) { }

	// RVA: 0x18C90C0 Offset: 0x18C82C0 VA: 0x1818C90C0
	public void remove_DeviceConnectedEvent(Action<BridgedController> value) { }

	// RVA: 0x18C8E20 Offset: 0x18C8020 VA: 0x1818C8E20
	public void add_DeviceDisconnectedEvent(Action<ControllerDisconnectedEventArgs> value) { }

	// RVA: 0x18C9170 Offset: 0x18C8370 VA: 0x1818C9170
	public void remove_DeviceDisconnectedEvent(Action<ControllerDisconnectedEventArgs> value) { }

	// RVA: 0x18C9010 Offset: 0x18C8210 VA: 0x1818C9010
	public void add_UpdateControllerInfoEvent(Action<UpdateControllerInfoEventArgs> value) { }

	// RVA: 0x18C9360 Offset: 0x18C8560 VA: 0x1818C9360
	public void remove_UpdateControllerInfoEvent(Action<UpdateControllerInfoEventArgs> value) { }

	// RVA: 0x18C8ED0 Offset: 0x18C80D0 VA: 0x1818C8ED0
	public void add_SystemDeviceConnectedEvent(Action value) { }

	// RVA: 0x18C9220 Offset: 0x18C8420 VA: 0x1818C9220
	public void remove_SystemDeviceConnectedEvent(Action value) { }

	// RVA: 0x18C8F70 Offset: 0x18C8170 VA: 0x1818C8F70
	public void add_SystemDeviceDisconnectedEvent(Action value) { }

	// RVA: 0x18C92C0 Offset: 0x18C84C0 VA: 0x1818C92C0
	public void remove_SystemDeviceDisconnectedEvent(Action value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_deviceCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract PlatformInputManager get_primaryInputManager();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IInputSource get_inputSource();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract InputSource get_inputSourceType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Update(UpdateLoopType currentUpdateLoop);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnDestroy();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SystemDeviceConnected();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void SystemDeviceDisconnected();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UpdateControllerData(int controllerId, ControllerDataUpdater data);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void SetUnityJoystickId(int joystickId, int unityJoystickId);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IUnifiedMouseSource GetUnifiedMouseSource();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IUnifiedKeyboardSource GetUnifiedKeyboardSource();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomObfuscation(rename = False)]
[DefaultMember("Item")]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public class UnknownControllerHat.HatButtons // TypeDefIndex: 6707
{
	// Fields
	private int[] TruLmjieKAjQseiaxGYEoHxpFBwKA; // 0x10

	// Properties
	public int Item { get; }

	// Methods

	// RVA: 0x18C5FA0 Offset: 0x18C51A0 VA: 0x1818C5FA0
	public int get_Item(int index) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(int[] ) { }

	// RVA: 0x18C5D80 Offset: 0x18C4F80 VA: 0x1818C5D80
	public void GetNeighbors(int button, out int neighbor1, out int neighbor2) { }

	// RVA: 0x18C5ED0 Offset: 0x18C50D0 VA: 0x1818C5ED0
	public bool IsCardinal(int button) { }

	// RVA: 0x18C5F30 Offset: 0x18C5130 VA: 0x1818C5F30
	public bool IsCorner(int button) { }

	// RVA: 0x18C5E70 Offset: 0x18C5070 VA: 0x1818C5E70
	public int IndexOf(int button) { }

	// RVA: 0x18C5D20 Offset: 0x18C4F20 VA: 0x1818C5D20
	public bool Contains(int button) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class UnknownControllerHat // TypeDefIndex: 6708
{
	// Fields
	private UnknownControllerHat.HatButtons TruLmjieKAjQseiaxGYEoHxpFBwKA; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(UnknownControllerHat.HatButtons ) { }

	// RVA: 0x18CA6D0 Offset: 0x18C98D0 VA: 0x1818CA6D0
	public bool ContainsButtonIndex(int index) { }

	// RVA: 0x18CA730 Offset: 0x18C9930 VA: 0x1818CA730
	public bool IsButtonIndexCardinal(int index) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public UnknownControllerHat.HatButtons GetButtons() { }
}

// Namespace: 
internal class uNFJquNOBaRBwwpcUNtexUfCbTCU<> // TypeDefIndex: 6709
{
	// Fields
	private readonly TazLdYAWHLQBqtFIdhIKagbdFWe<> DoLZigvfVFftrIGIQZRkHMYTDsqgb; // 0x0
	private Controller azigYgkdmxzlwNzgZgMeCnnObleBA; // 0x0
	private Controller WnThbJGvDgHCCgMOrtiqGPkSmEYO; // 0x0
	private Controller BuuKIzKDbtCnQdxoREWFPRUpPMeJ; // 0x0
	public int ZyzUiRPLEbWdUklCNdQHZdRDjLQK; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE77AE0 Offset: 0xE76CE0 VA: 0x180E77AE0
	|-uNFJquNOBaRBwwpcUNtexUfCbTCU<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void KRErKlbKequNclHkZvSeWKLutvEp(int , Controller , Controller , Controller ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE77A00 Offset: 0xE76C00 VA: 0x180E77A00
	|-uNFJquNOBaRBwwpcUNtexUfCbTCU<object>.KRErKlbKequNclHkZvSeWKLutvEp
	*/

	// RVA: -1 Offset: -1
	public void BZJIdaZFJwehQwuHtjIUroFZdJvFA( ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE779B0 Offset: 0xE76BB0 VA: 0x180E779B0
	|-uNFJquNOBaRBwwpcUNtexUfCbTCU<object>.BZJIdaZFJwehQwuHtjIUroFZdJvFA
	*/

	// RVA: -1 Offset: -1
	public void BZJIdaZFJwehQwuHtjIUroFZdJvFA( , ControllerType ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE77960 Offset: 0xE76B60 VA: 0x180E77960
	|-uNFJquNOBaRBwwpcUNtexUfCbTCU<object>.BZJIdaZFJwehQwuHtjIUroFZdJvFA
	*/

	// RVA: -1 Offset: -1
	public void aLHlUCRMmGCkpdteigNMAGCBweMi( ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE77BB0 Offset: 0xE76DB0 VA: 0x180E77BB0
	|-uNFJquNOBaRBwwpcUNtexUfCbTCU<object>.aLHlUCRMmGCkpdteigNMAGCBweMi
	*/

	// RVA: -1 Offset: -1
	public void aLHlUCRMmGCkpdteigNMAGCBweMi( , ControllerType ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE77B60 Offset: 0xE76D60 VA: 0x180E77B60
	|-uNFJquNOBaRBwwpcUNtexUfCbTCU<object>.aLHlUCRMmGCkpdteigNMAGCBweMi
	*/

	// RVA: -1 Offset: -1
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE77C00 Offset: 0xE76E00 VA: 0x180E77C00
	|-uNFJquNOBaRBwwpcUNtexUfCbTCU<object>.emOgGAIJPwqUQQPmEukEIzmDcQhcb
	*/

	// RVA: -1 Offset: -1
	private void hZtXGwYvJjTVSXCtkwnApLCqOAoF() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE77C50 Offset: 0xE76E50 VA: 0x180E77C50
	|-uNFJquNOBaRBwwpcUNtexUfCbTCU<object>.hZtXGwYvJjTVSXCtkwnApLCqOAoF
	*/
}

// Namespace: 
private class TazLdYAWHLQBqtFIdhIKagbdFWe.kZPIydVQJGRugthukAdOaIKiJNjo<> // TypeDefIndex: 6710
{
	// Fields
	public readonly  idkAUUZTfjqHhLKHjqaTMdnuEbsM; // 0x0
	public readonly int XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor( , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	|-TazLdYAWHLQBqtFIdhIKagbdFWe.kZPIydVQJGRugthukAdOaIKiJNjo<object>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TazLdYAWHLQBqtFIdhIKagbdFWe.dvJBfgAjquBVtnLSBeVabLrDYRxjB<> // TypeDefIndex: 6711
{
	// Fields
	public  idkAUUZTfjqHhLKHjqaTMdnuEbsM; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-TazLdYAWHLQBqtFIdhIKagbdFWe.dvJBfgAjquBVtnLSBeVabLrDYRxjB<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool EQDzVdbMypbDLlamZSdCFPtrSJJq(TazLdYAWHLQBqtFIdhIKagbdFWe.kZPIydVQJGRugthukAdOaIKiJNjo<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6AE10 Offset: 0xE6A010 VA: 0x180E6AE10
	|-TazLdYAWHLQBqtFIdhIKagbdFWe.dvJBfgAjquBVtnLSBeVabLrDYRxjB<object>.EQDzVdbMypbDLlamZSdCFPtrSJJq
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TazLdYAWHLQBqtFIdhIKagbdFWe.PkgilDErsRVwITCNMfVbroWXtkYd<> // TypeDefIndex: 6712
{
	// Fields
	public  idkAUUZTfjqHhLKHjqaTMdnuEbsM; // 0x0
	public ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-TazLdYAWHLQBqtFIdhIKagbdFWe.PkgilDErsRVwITCNMfVbroWXtkYd<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool EQDzVdbMypbDLlamZSdCFPtrSJJq(TazLdYAWHLQBqtFIdhIKagbdFWe.kZPIydVQJGRugthukAdOaIKiJNjo<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7FE30 Offset: 0xB7F030 VA: 0x180B7FE30
	|-TazLdYAWHLQBqtFIdhIKagbdFWe.PkgilDErsRVwITCNMfVbroWXtkYd<object>.EQDzVdbMypbDLlamZSdCFPtrSJJq
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TazLdYAWHLQBqtFIdhIKagbdFWe.oMcVsTwQTMRBlyVKfYwANFlBXIch<> // TypeDefIndex: 6713
{
	// Fields
	public  idkAUUZTfjqHhLKHjqaTMdnuEbsM; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-TazLdYAWHLQBqtFIdhIKagbdFWe.oMcVsTwQTMRBlyVKfYwANFlBXIch<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool iZrHmXXGCdgPtBjywfKtlfJLBXyt(TazLdYAWHLQBqtFIdhIKagbdFWe.kZPIydVQJGRugthukAdOaIKiJNjo<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE70BB0 Offset: 0xE6FDB0 VA: 0x180E70BB0
	|-TazLdYAWHLQBqtFIdhIKagbdFWe.oMcVsTwQTMRBlyVKfYwANFlBXIch<object>.iZrHmXXGCdgPtBjywfKtlfJLBXyt
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TazLdYAWHLQBqtFIdhIKagbdFWe.fcYMcTdyaOTdkwORfOzyNWOtSePc<> // TypeDefIndex: 6714
{
	// Fields
	public  idkAUUZTfjqHhLKHjqaTMdnuEbsM; // 0x0
	public ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-TazLdYAWHLQBqtFIdhIKagbdFWe.fcYMcTdyaOTdkwORfOzyNWOtSePc<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool iZrHmXXGCdgPtBjywfKtlfJLBXyt(TazLdYAWHLQBqtFIdhIKagbdFWe.kZPIydVQJGRugthukAdOaIKiJNjo<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7FE30 Offset: 0xB7F030 VA: 0x180B7FE30
	|-TazLdYAWHLQBqtFIdhIKagbdFWe.fcYMcTdyaOTdkwORfOzyNWOtSePc<object>.iZrHmXXGCdgPtBjywfKtlfJLBXyt
	*/
}

// Namespace: 
internal class TazLdYAWHLQBqtFIdhIKagbdFWe<> // TypeDefIndex: 6715
{
	// Fields
	private const int HBuNfrVuLTVOCTHPunBYXpyztuHk = -2147483648;
	public int ZGDajhyxNzhNBiKJhEAsWFQbqjCfA; // 0x0
	private readonly AList<TazLdYAWHLQBqtFIdhIKagbdFWe.kZPIydVQJGRugthukAdOaIKiJNjo<>> NJcFlKXmiujhfSKuclmqBTKqKEZA; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6CA30 Offset: 0xC6BC30 VA: 0x180C6CA30
	|-TazLdYAWHLQBqtFIdhIKagbdFWe<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void BZJIdaZFJwehQwuHtjIUroFZdJvFA( ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6C730 Offset: 0xC6B930 VA: 0x180C6C730
	|-TazLdYAWHLQBqtFIdhIKagbdFWe<object>.BZJIdaZFJwehQwuHtjIUroFZdJvFA
	*/

	// RVA: -1 Offset: -1
	public void BZJIdaZFJwehQwuHtjIUroFZdJvFA( , ControllerType ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6C590 Offset: 0xC6B790 VA: 0x180C6C590
	|-TazLdYAWHLQBqtFIdhIKagbdFWe<object>.BZJIdaZFJwehQwuHtjIUroFZdJvFA
	*/

	// RVA: -1 Offset: -1
	public void aLHlUCRMmGCkpdteigNMAGCBweMi( ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6CAB0 Offset: 0xC6BCB0 VA: 0x180C6CAB0
	|-TazLdYAWHLQBqtFIdhIKagbdFWe<object>.aLHlUCRMmGCkpdteigNMAGCBweMi
	*/

	// RVA: -1 Offset: -1
	public void aLHlUCRMmGCkpdteigNMAGCBweMi( , ControllerType ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6CBE0 Offset: 0xC6BDE0 VA: 0x180C6CBE0
	|-TazLdYAWHLQBqtFIdhIKagbdFWe<object>.aLHlUCRMmGCkpdteigNMAGCBweMi
	*/

	// RVA: -1 Offset: -1
	public void JLhdRlStAksPqVNeNCiQCrIJrIlD(int , Controller ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6C8D0 Offset: 0xC6BAD0 VA: 0x180C6C8D0
	|-TazLdYAWHLQBqtFIdhIKagbdFWe<object>.JLhdRlStAksPqVNeNCiQCrIJrIlD
	*/

	// RVA: -1 Offset: -1
	public void JLhdRlStAksPqVNeNCiQCrIJrIlD(int , Controller , ControllerType ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6C900 Offset: 0xC6BB00 VA: 0x180C6C900
	|-TazLdYAWHLQBqtFIdhIKagbdFWe<object>.JLhdRlStAksPqVNeNCiQCrIJrIlD
	*/

	// RVA: -1 Offset: -1
	private void ObIXHcHFqAGWTdvtkVlEnHSsskFMA(int , Controller , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6C930 Offset: 0xC6BB30 VA: 0x180C6C930
	|-TazLdYAWHLQBqtFIdhIKagbdFWe<object>.ObIXHcHFqAGWTdvtkVlEnHSsskFMA
	*/

	// RVA: -1 Offset: -1
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6CD10 Offset: 0xC6BF10 VA: 0x180C6CD10
	|-TazLdYAWHLQBqtFIdhIKagbdFWe<object>.emOgGAIJPwqUQQPmEukEIzmDcQhcb
	*/

	// RVA: -1 Offset: -1
	private void lVvxVScUNjTGkpPEyAazDOoQPgkWA(TazLdYAWHLQBqtFIdhIKagbdFWe.kZPIydVQJGRugthukAdOaIKiJNjo<> , int , Controller ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6CD80 Offset: 0xC6BF80 VA: 0x180C6CD80
	|-TazLdYAWHLQBqtFIdhIKagbdFWe<object>.lVvxVScUNjTGkpPEyAazDOoQPgkWA
	*/

	// RVA: -1 Offset: -1
	private void hZtXGwYvJjTVSXCtkwnApLCqOAoF() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6CD60 Offset: 0xC6BF60 VA: 0x180C6CD60
	|-TazLdYAWHLQBqtFIdhIKagbdFWe<object>.hZtXGwYvJjTVSXCtkwnApLCqOAoF
	*/
}

// Namespace: 
public class YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW // TypeDefIndex: 6716
{
	// Fields
	public readonly Action<InputActionEventData> UDtXrlVZSfkUkZHoiDuFPlZLEHycA; // 0x10
	public readonly UpdateLoopType pdMpguIIJSXJuwgCZpDStKcWwtYN; // 0x18
	public readonly InputActionEventType uDVjETqmttIWEcQfUdqeEhEMAvNI; // 0x1C
	public readonly int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x20
	public readonly bool riBLCVFHIBxvVrABCyxdjRtBioPs; // 0x24
	public float[] OzLeVCaObgjNWeAnlhgYizoPvHBb; // 0x28

	// Methods

	// RVA: 0x18CD160 Offset: 0x18CC360 VA: 0x1818CD160
	public void .ctor(Action<InputActionEventData> , UpdateLoopType , InputActionEventType , int , object[] ) { }

	// RVA: 0x18CD120 Offset: 0x18CC320 VA: 0x1818CD120
	public bool KENaACeYEzpIPvUVQqIjBfnvFnGZ(int , out float ) { }

	// RVA: 0x18CD1E0 Offset: 0x18CC3E0 VA: 0x1818CD1E0
	private void qTgaOPJXDkNrVQayDPNyFpSMjXSIA(object[] ) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class YukdbraIOdkMeQxcSbggwPKIgDZM.mnmFXogxsknllRQssxYzoVezBZoY // TypeDefIndex: 6717
{
	// Fields
	public static readonly YukdbraIOdkMeQxcSbggwPKIgDZM.mnmFXogxsknllRQssxYzoVezBZoY <>9; // 0x0
	public static Func<AList<YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW>> <>9__8_0; // 0x8

	// Methods

	// RVA: 0x18CDC50 Offset: 0x18CCE50 VA: 0x1818CDC50
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18CDCB0 Offset: 0x18CCEB0 VA: 0x1818CDCB0
	internal AList<YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW> uIflQfYzSBzWLGCEfdTrYZnfFrgm() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class YukdbraIOdkMeQxcSbggwPKIgDZM.bvJFJVDvybxRkzAHIyituEhbjEEe // TypeDefIndex: 6718
{
	// Fields
	public Action<InputActionEventData> UDtXrlVZSfkUkZHoiDuFPlZLEHycA; // 0x10
	public Predicate<YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW> gEItlodkMseQRzZwNFynMrqsIBb; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18CD0F0 Offset: 0x18CC2F0 VA: 0x1818CD0F0
	internal bool YCqjjDgFJNCDGQNUewkUoUsVzixo(YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class YukdbraIOdkMeQxcSbggwPKIgDZM.CRAyAeCgdkHmLkgXzrMcJLftGtrMA // TypeDefIndex: 6719
{
	// Fields
	public Action<InputActionEventData> UDtXrlVZSfkUkZHoiDuFPlZLEHycA; // 0x10
	public int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x18
	public Predicate<YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW> gEItlodkMseQRzZwNFynMrqsIBb; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18BC650 Offset: 0x18BB850 VA: 0x1818BC650
	internal bool YCqjjDgFJNCDGQNUewkUoUsVzixo(YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class YukdbraIOdkMeQxcSbggwPKIgDZM.vVpEiWGLJjHmijCbRqqwMrLDQyieA // TypeDefIndex: 6720
{
	// Fields
	public Action<InputActionEventData> UDtXrlVZSfkUkZHoiDuFPlZLEHycA; // 0x10
	public UpdateLoopType pdMpguIIJSXJuwgCZpDStKcWwtYN; // 0x18
	public Predicate<YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW> gEItlodkMseQRzZwNFynMrqsIBb; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18CE4E0 Offset: 0x18CD6E0 VA: 0x1818CE4E0
	internal bool YCqjjDgFJNCDGQNUewkUoUsVzixo(YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class YukdbraIOdkMeQxcSbggwPKIgDZM.joDzJhuwXkuegsQpUzJaxISvNRwc // TypeDefIndex: 6721
{
	// Fields
	public Action<InputActionEventData> UDtXrlVZSfkUkZHoiDuFPlZLEHycA; // 0x10
	public InputActionEventType uDVjETqmttIWEcQfUdqeEhEMAvNI; // 0x18
	public Predicate<YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW> gEItlodkMseQRzZwNFynMrqsIBb; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18CDA70 Offset: 0x18CCC70 VA: 0x1818CDA70
	internal bool YCqjjDgFJNCDGQNUewkUoUsVzixo(YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class YukdbraIOdkMeQxcSbggwPKIgDZM.vbGIsVqNFSFQYjlaZdXFeeIgwqpWb // TypeDefIndex: 6722
{
	// Fields
	public Action<InputActionEventData> UDtXrlVZSfkUkZHoiDuFPlZLEHycA; // 0x10
	public UpdateLoopType pdMpguIIJSXJuwgCZpDStKcWwtYN; // 0x18
	public int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x1C
	public Predicate<YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW> gEItlodkMseQRzZwNFynMrqsIBb; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18CE530 Offset: 0x18CD730 VA: 0x1818CE530
	internal bool YCqjjDgFJNCDGQNUewkUoUsVzixo(YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class YukdbraIOdkMeQxcSbggwPKIgDZM.FXsHvurAhvRHPsAaCdwcGhRRaJMIb // TypeDefIndex: 6723
{
	// Fields
	public Action<InputActionEventData> UDtXrlVZSfkUkZHoiDuFPlZLEHycA; // 0x10
	public UpdateLoopType pdMpguIIJSXJuwgCZpDStKcWwtYN; // 0x18
	public int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x1C
	public InputActionEventType uDVjETqmttIWEcQfUdqeEhEMAvNI; // 0x20
	public Predicate<YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW> gEItlodkMseQRzZwNFynMrqsIBb; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18C5BF0 Offset: 0x18C4DF0 VA: 0x1818C5BF0
	internal bool YCqjjDgFJNCDGQNUewkUoUsVzixo(YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class YukdbraIOdkMeQxcSbggwPKIgDZM.DlsRAIQVXNmBcigeDEQJVlMCtqjb // TypeDefIndex: 6724
{
	// Fields
	public Action<InputActionEventData> UDtXrlVZSfkUkZHoiDuFPlZLEHycA; // 0x10
	public UpdateLoopType pdMpguIIJSXJuwgCZpDStKcWwtYN; // 0x18
	public InputActionEventType uDVjETqmttIWEcQfUdqeEhEMAvNI; // 0x1C
	public Predicate<YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW> gEItlodkMseQRzZwNFynMrqsIBb; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18C3A90 Offset: 0x18C2C90 VA: 0x1818C3A90
	internal bool YCqjjDgFJNCDGQNUewkUoUsVzixo(YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class YukdbraIOdkMeQxcSbggwPKIgDZM.ugcEgYaCeDozQjQFPYEqCROlLdHSA // TypeDefIndex: 6725
{
	// Fields
	public Action<InputActionEventData> UDtXrlVZSfkUkZHoiDuFPlZLEHycA; // 0x10
	public int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x18
	public InputActionEventType uDVjETqmttIWEcQfUdqeEhEMAvNI; // 0x1C
	public Predicate<YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW> gEItlodkMseQRzZwNFynMrqsIBb; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18CE480 Offset: 0x18CD680 VA: 0x1818CE480
	internal bool YCqjjDgFJNCDGQNUewkUoUsVzixo(YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW ) { }
}

// Namespace: 
internal class YukdbraIOdkMeQxcSbggwPKIgDZM // TypeDefIndex: 6726
{
	// Fields
	private static YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW[] eZVAvQnZHXGtKNjCCHlhkmRZdtlFb; // 0x0
	private bool DzRdwaCjMKOeYXXRtYawwePnAsSb; // 0x10
	private AList<YukdbraIOdkMeQxcSbggwPKIgDZM.hfLcqXDcSYRbonJJvuguMsoQrLFW>[] UmbDgBLsiLmJWygIpGslKRyJAuBCb; // 0x18
	private int[] PWnnimDWrXIVfuiwCgIZqJyFaofiA; // 0x20
	private int jLgtiotmDUtYCiSOrTRmEAupzraf; // 0x28
	public int zefrjHAdVEKWBxCsKMKUqiZDKYnQ; // 0x2C

	// Methods

	// RVA: 0x18CCAD0 Offset: 0x18CBCD0 VA: 0x1818CCAD0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18CC770 Offset: 0x18CB970 VA: 0x1818CC770
	private void ZFUcTEcndvHgBpdTmEAgSebxfOsJ() { }

	// RVA: 0x18CBBC0 Offset: 0x18CADC0 VA: 0x1818CBBC0
	public void ObIXHcHFqAGWTdvtkVlEnHSsskFMA(kFuPHwnfsCwuzHDrtzjGMJwdcjDEA , UpdateLoopType ) { }

	// RVA: 0x18CCC90 Offset: 0x18CBE90 VA: 0x1818CCC90
	public void xXDAAgkpHyujExYwkSGAdhBokBcFb(Action<InputActionEventData> , UpdateLoopType , InputActionEventType , int , object[] ) { }

	// RVA: 0x18CCF40 Offset: 0x18CC140 VA: 0x1818CCF40
	public void xXDAAgkpHyujExYwkSGAdhBokBcFb(Action<InputActionEventData> , UpdateLoopType , InputActionEventType , object[] ) { }

	// RVA: 0x18CB1B0 Offset: 0x18CA3B0 VA: 0x1818CB1B0
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(Action<InputActionEventData> ) { }

	// RVA: 0x18CAFE0 Offset: 0x18CA1E0 VA: 0x1818CAFE0
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(Action<InputActionEventData> , int ) { }

	// RVA: 0x18CBA30 Offset: 0x18CAC30 VA: 0x1818CBA30
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(Action<InputActionEventData> , UpdateLoopType ) { }

	// RVA: 0x18CAE50 Offset: 0x18CA050 VA: 0x1818CAE50
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(Action<InputActionEventData> , InputActionEventType ) { }

	// RVA: 0x18CB340 Offset: 0x18CA540 VA: 0x1818CB340
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(Action<InputActionEventData> , UpdateLoopType , int ) { }

	// RVA: 0x18CB6E0 Offset: 0x18CA8E0 VA: 0x1818CB6E0
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(Action<InputActionEventData> , UpdateLoopType , InputActionEventType , int ) { }

	// RVA: 0x18CB8B0 Offset: 0x18CAAB0 VA: 0x1818CB8B0
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(Action<InputActionEventData> , UpdateLoopType , InputActionEventType ) { }

	// RVA: 0x18CB510 Offset: 0x18CA710 VA: 0x1818CB510
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(Action<InputActionEventData> , InputActionEventType , int ) { }

	// RVA: 0x18CCB30 Offset: 0x18CBD30 VA: 0x1818CCB30
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x18CCC20 Offset: 0x18CBE20 VA: 0x1818CCC20
	private void wWkZvXpbGYTIxmDjuBMAOwoWpgqR() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class InputSourceWrapper<T> : IDisposable, IInputSource // TypeDefIndex: 6727
{
	// Fields
	private T SDwzWAaQayKsUsCLxvZirfQfmcnS; // 0x0
	private bool qlWbbXXJkXhrJOhRVlcxNUPVUYEt; // 0x0

	// Properties
	public T source { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_source() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-InputSourceWrapper<object>.get_source
	|
	|-RVA: 0xB16E40 Offset: 0xB16040 VA: 0x180B16E40
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.get_source
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	|-InputSourceWrapper<object>..ctor
	|
	|-RVA: 0x128E520 Offset: 0x128D720 VA: 0x18128E520
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void add_DeviceChangedEvent(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128E4E0 Offset: 0x128D6E0 VA: 0x18128E4E0
	|-InputSourceWrapper<object>.add_DeviceChangedEvent
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.add_DeviceChangedEvent
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void remove_DeviceChangedEvent(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128E4E0 Offset: 0x128D6E0 VA: 0x18128E4E0
	|-InputSourceWrapper<object>.remove_DeviceChangedEvent
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.remove_DeviceChangedEvent
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SystemDeviceConnected() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-InputSourceWrapper<object>.SystemDeviceConnected
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.SystemDeviceConnected
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void SystemDeviceDisconnected() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-InputSourceWrapper<object>.SystemDeviceDisconnected
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.SystemDeviceDisconnected
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E1940 Offset: 0x8E0B40 VA: 0x1808E1940
	|-InputSourceWrapper<object>.Update
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.Update
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void UpdateDevices(UpdateLoopType updateLoop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128E4E0 Offset: 0x128D6E0 VA: 0x18128E4E0
	|-InputSourceWrapper<object>.UpdateDevices
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.UpdateDevices
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void UpdateFinished() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E1940 Offset: 0x8E0B40 VA: 0x1808E1940
	|-InputSourceWrapper<object>.UpdateFinished
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.UpdateFinished
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public IList<TJoy> GetJoysticks<TJoy>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E1940 Offset: 0x8E0B40 VA: 0x1808E1940
	|-InputSourceWrapper<object>.GetJoysticks<object>
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.GetJoysticks<object>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128E3E0 Offset: 0x128D5E0 VA: 0x18128E3E0
	|-InputSourceWrapper<object>.Dispose
	|
	|-RVA: 0x128E300 Offset: 0x128D500 VA: 0x18128E300
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128E460 Offset: 0x128D660 VA: 0x18128E460
	|-InputSourceWrapper<object>.Finalize
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128E450 Offset: 0x128D650 VA: 0x18128E450
	|-InputSourceWrapper<object>.Dispose
	|
	|-RVA: 0x128E370 Offset: 0x128D570 VA: 0x18128E370
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: 
internal class wSLhttcgJMYvEFQjUPTkLEUWMEcK // TypeDefIndex: 6728
{
	// Fields
	public bool ugrlDdbeiHsmlSraGEPuNcjeTwEh; // 0x10
	public Controller oucSTTgcWofhafDPqHrFgmhNLXuaA; // 0x18
	public ControllerMap CKLJUnnpndBsfdLuUgNsJpcsPydNA; // 0x20
	public ActionElementMap eWszhrzTgmaZrKigKDnkYoAPWDCy; // 0x28

	// Methods

	// RVA: 0x18CE600 Offset: 0x18CD800 VA: 0x1818CE600
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x18CE5C0 Offset: 0x18CD7C0 VA: 0x1818CE5C0
	public void aLEuiSRTQwaSBsXbGGQLCoTwTDkl(wSLhttcgJMYvEFQjUPTkLEUWMEcK ) { }

	// RVA: 0x18CE590 Offset: 0x18CD790 VA: 0x1818CE590
	public void aLEuiSRTQwaSBsXbGGQLCoTwTDkl(HrlcjemCuLDOTWiWxHeuTfauJxQd ) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class UpdateLoopDataSet.RIAcGPcPzYGUnxqIpxmWXsOLINXgA<> // TypeDefIndex: 6729
{
	// Fields
	public readonly UpdateLoopType pdMpguIIJSXJuwgCZpDStKcWwtYN; // 0x0
	public  RvQriCbLWrMhpOFZPeSLErHymywu; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UpdateLoopType ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	|-UpdateLoopDataSet.RIAcGPcPzYGUnxqIpxmWXsOLINXgA<object>..ctor
	*/
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[DefaultMember("Item")]
internal class UpdateLoopDataSet<T> // TypeDefIndex: 6730
{
	// Fields
	private const int LykgfjFlQZigGomdXSDxPWbejlvqA = 0;
	private UpdateLoopDataSet.RIAcGPcPzYGUnxqIpxmWXsOLINXgA<T> RibJSMPVyCWmQFgvWeiXYxTxdGZO; // 0x0
	private int flLfjbEWRrNpTYNgxydNRNmBCEsaA; // 0x0
	public readonly int fixedUpdateSetIndex; // 0x0
	private readonly int[] iZyDKPlOBqXAunKcVdJXkDBhUAODA; // 0x0
	private readonly UpdateLoopDataSet.RIAcGPcPzYGUnxqIpxmWXsOLINXgA<T>[] npPflhdRYzRMfVkRceByHCLIUoEtA; // 0x0
	private UpdateLoopType rjUgekeINqhGhwkMCRcYNIsNTvOCA; // 0x0

	// Properties
	public T Current { get; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	|-UpdateLoopDataSet<object>.get_Current
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-UpdateLoopDataSet<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE7910 Offset: 0xCE6B10 VA: 0x180CE7910
	|-UpdateLoopDataSet<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE79E0 Offset: 0xCE6BE0 VA: 0x180CE79E0
	|-UpdateLoopDataSet<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UpdateLoopSetting ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE7DF0 Offset: 0xCE6FF0 VA: 0x180CE7DF0
	|-UpdateLoopDataSet<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UpdateLoopSetting , Func<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE7A60 Offset: 0xCE6C60 VA: 0x180CE7A60
	|-UpdateLoopDataSet<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void SetUpdateLoop(UpdateLoopType updateLoop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE7990 Offset: 0xCE6B90 VA: 0x180CE7990
	|-UpdateLoopDataSet<object>.SetUpdateLoop
	*/

	// RVA: -1 Offset: -1
	public T Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE7910 Offset: 0xCE6B10 VA: 0x180CE7910
	|-UpdateLoopDataSet<object>.Get
	*/

	// RVA: -1 Offset: -1
	public T Get(UpdateLoopType updateLoop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE78C0 Offset: 0xCE6AC0 VA: 0x180CE78C0
	|-UpdateLoopDataSet<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Set(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE79E0 Offset: 0xCE6BE0 VA: 0x180CE79E0
	|-UpdateLoopDataSet<object>.Set
	*/

	// RVA: -1 Offset: -1
	public UpdateLoopType GetUpdateLoopType(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE7830 Offset: 0xCE6A30 VA: 0x180CE7830
	|-UpdateLoopDataSet<object>.GetUpdateLoopType
	*/
}

// Namespace: 
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public class ButtonLoopSet.ButtonData // TypeDefIndex: 6731
{
	// Fields
	public readonly UpdateLoopType updateLoop; // 0x10
	public readonly bool[] values; // 0x18
	public readonly bool[] wasTrueThisFrame; // 0x20
	private bool[] lrEPXDxLXlNEXIqqmLkupvnNEJPG; // 0x28
	private int iNdFTqkWyngzRLhLztgirFFibKrP; // 0x30
	private readonly bool[] BCLmJCodubQoYErkxQnFaEydvvPf; // 0x38
	private readonly bool[] esLhpWdDLcDkilveMAlyVMcMysQB; // 0x40

	// Properties
	public bool[] effectiveValue { get; }

	// Methods

	// RVA: 0x18BB560 Offset: 0x18BA760 VA: 0x1818BB560
	public bool[] get_effectiveValue() { }

	// RVA: 0x18BB440 Offset: 0x18BA640 VA: 0x1818BB440
	public void .ctor(int , UpdateLoopType ) { }

	// RVA: 0x18BB1B0 Offset: 0x18BA3B0 VA: 0x1818BB1B0
	public void SetValue(int index, bool value) { }

	// RVA: 0x18BAE60 Offset: 0x18BA060 VA: 0x1818BAE60
	public void ClearWasTrueThisFrame() { }

	// RVA: 0x18BAF00 Offset: 0x18BA100 VA: 0x1818BAF00
	public void Clear() { }

	// RVA: 0x18BB030 Offset: 0x18BA230 VA: 0x1818BB030
	public void Import(ButtonLoopSet.ButtonData source) { }

	// RVA: 0x18BB2A0 Offset: 0x18BA4A0 VA: 0x1818BB2A0
	private void YWkZNshlpOsrQHQsTcTHOqgzBTow() { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
internal class ButtonLoopSet : UpdateLoopDataSet<ButtonLoopSet.ButtonData> // TypeDefIndex: 6732
{
	// Fields
	public readonly int buttonCount; // 0x38

	// Methods

	// RVA: 0x18BBA00 Offset: 0x18BAC00 VA: 0x1818BBA00
	public void .ctor(UpdateLoopSetting , int ) { }

	// RVA: 0x18BB890 Offset: 0x18BAA90 VA: 0x1818BB890
	public void SetValue(int index, bool value, double timestamp) { }

	// RVA: 0x18BB590 Offset: 0x18BA790 VA: 0x1818BB590
	public void Clear() { }

	// RVA: 0x18BB740 Offset: 0x18BA940 VA: 0x1818BB740
	public void Import(ButtonLoopSet set) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal struct TouchInfo // TypeDefIndex: 6733
{
	// Fields
	private bool gkkdXHNDAbAOpJYvSKofpsqHhreCb; // 0x0
	private int KNzoIVRnOsbmWGgJwjjxfyqAnGUpA; // 0x4
	private Vector2 aeiuzPBaedYnAMBKbQXNAfiKqXKE; // 0x8
	private Vector2 UEVwkcrIivFetlGnfnmEXqLIxal; // 0x10
	private Vector2 WwVgdofSshLswrJyqhsxJMbkvywc; // 0x18
	private Vector2 GzmunyFtJeiJnIDNYHGUdetIlBnuA; // 0x20
	private float AoiAzhjAUQtczdcSdpVQcBMDNHzT; // 0x28
	private int IGUqAfHxceGdQQdHVaOpKKqVEszp; // 0x2C

	// Properties
	public bool isValid { get; set; }
	public int touchId { get; set; }
	public Vector2 touchPos { get; set; }
	public Vector2 touchPosRaw { get; set; }
	public Vector2 deltaPos { get; set; }
	public Vector2 deltaPosRaw { get; set; }
	public float deltaTime { get; set; }
	public int tapCount { get; set; }
	internal static TouchInfo Invalid { get; }

	// Methods

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_isValid() { }

	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	internal void set_isValid(bool value) { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_touchId() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	internal void set_touchId(int value) { }

	// RVA: 0x18CA6B0 Offset: 0x18C98B0 VA: 0x1818CA6B0
	public Vector2 get_touchPos() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	internal void set_touchPos(Vector2 value) { }

	// RVA: 0x11116F0 Offset: 0x11108F0 VA: 0x1811116F0
	public Vector2 get_touchPosRaw() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_touchPosRaw(Vector2 value) { }

	// RVA: 0x12B30A0 Offset: 0x12B22A0 VA: 0x1812B30A0
	public Vector2 get_deltaPos() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_deltaPos(Vector2 value) { }

	// RVA: 0x5A6760 Offset: 0x5A5960 VA: 0x1805A6760
	public Vector2 get_deltaPosRaw() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_deltaPosRaw(Vector2 value) { }

	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20
	public float get_deltaTime() { }

	// RVA: 0x484EB0 Offset: 0x4840B0 VA: 0x180484EB0
	internal void set_deltaTime(float value) { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public int get_tapCount() { }

	// RVA: 0x5014F0 Offset: 0x5006F0 VA: 0x1805014F0
	internal void set_tapCount(int value) { }

	// RVA: 0x18CA670 Offset: 0x18C9870 VA: 0x1818CA670
	internal void .ctor(bool , int , Vector2 , Vector2 , Vector2 , Vector2 , float , int ) { }

	// RVA: 0x9E90E0 Offset: 0x9E82E0 VA: 0x1809E90E0
	internal static TouchInfo get_Invalid() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class SteamAction // TypeDefIndex: 6734
{
	// Fields
	public readonly string name; // 0x10
	public readonly ulong handle; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string , ulong ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class SteamActionSet // TypeDefIndex: 6735
{
	// Fields
	public readonly string name; // 0x10
	public readonly ulong handle; // 0x18
	public readonly Dictionary<string, SteamAction> actions; // 0x20

	// Methods

	// RVA: 0x18CA060 Offset: 0x18C9260 VA: 0x1818CA060
	public void .ctor(string , ulong ) { }

	// RVA: 0x18C9FC0 Offset: 0x18C91C0 VA: 0x1818C9FC0
	public void AddAction(SteamAction action) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal struct HardwareControllerMapIdentifier // TypeDefIndex: 6736
{
	// Fields
	public readonly Guid guid; // 0x0
	public readonly InputSource inputSource; // 0x10
	public readonly InputPlatform actualInputPlatform; // 0x14
	public readonly int variantIndex; // 0x18

	// Methods

	// RVA: 0x18C5D00 Offset: 0x18C4F00 VA: 0x1818C5D00
	public void .ctor(Guid , InputSource , InputPlatform , int ) { }

	// RVA: 0x18C5C50 Offset: 0x18C4E50 VA: 0x1818C5C50
	public static bool Matches(HardwareControllerMapIdentifier a, HardwareControllerMapIdentifier b) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal struct RewiredVersion // TypeDefIndex: 6737
{
	// Fields
	public int version1; // 0x0
	public int version2; // 0x4
	public int version3; // 0x8
	public int version4; // 0xC
	public string unityVersion; // 0x10

	// Methods

	// RVA: 0x18C9B20 Offset: 0x18C8D20 VA: 0x1818C9B20
	public void .ctor(int , int , int , int , string ) { }

	// RVA: 0x18C9B40 Offset: 0x18C8D40 VA: 0x1818C9B40
	public void .ctor(string ) { }

	// RVA: 0x18C9870 Offset: 0x18C8A70 VA: 0x1818C9870 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18C9930 Offset: 0x18C8B30 VA: 0x1818C9930 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C99E0 Offset: 0x18C8BE0 VA: 0x1818C99E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C9CA0 Offset: 0x18C8EA0 VA: 0x1818C9CA0
	public static bool op_Equality(RewiredVersion a, RewiredVersion b) { }

	// RVA: 0x18C9EC0 Offset: 0x18C90C0 VA: 0x1818C9EC0
	public static bool op_Inequality(RewiredVersion a, RewiredVersion b) { }

	// RVA: 0x18C9E10 Offset: 0x18C9010 VA: 0x1818C9E10
	public static bool op_GreaterThan(RewiredVersion a, RewiredVersion b) { }

	// RVA: 0x18C9F10 Offset: 0x18C9110 VA: 0x1818C9F10
	public static bool op_LessThan(RewiredVersion a, RewiredVersion b) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal struct PidVid : IEquatable<PidVid> // TypeDefIndex: 6738
{
	// Fields
	private const string zJcTcKvONuIrNArjkVlnddxZONJxA = "[^a-fA-F0-9]";
	public ushort productId; // 0x0
	public ushort vendorId; // 0x2

	// Properties
	public bool isZero { get; }

	// Methods

	// RVA: 0x16DBF30 Offset: 0x16DB130 VA: 0x1816DBF30
	public void .ctor(ushort , ushort ) { }

	// RVA: 0x18C8B30 Offset: 0x18C7D30 VA: 0x1818C8B30
	public void .ctor(string ) { }

	// RVA: 0x18C8BE0 Offset: 0x18C7DE0 VA: 0x1818C8BE0
	public void .ctor(Guid ) { }

	// RVA: 0x18C8D10 Offset: 0x18C7F10 VA: 0x1818C8D10
	public bool get_isZero() { }

	// RVA: 0x18C8870 Offset: 0x18C7A70 VA: 0x1818C8870
	public bool Equals(string pidVid) { }

	// RVA: 0x18C8A40 Offset: 0x18C7C40 VA: 0x1818C8A40
	public Guid ToProductGuid() { }

	// RVA: 0x18C8950 Offset: 0x18C7B50 VA: 0x1818C8950
	private bool GBbDWoKzKKqbuCyRaNGjxywgrfNp(string ) { }

	// RVA: 0x18C88C0 Offset: 0x18C7AC0 VA: 0x1818C88C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18C8A00 Offset: 0x18C7C00 VA: 0x1818C8A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C88A0 Offset: 0x18C7AA0 VA: 0x1818C88A0 Slot: 4
	public bool Equals(PidVid other) { }

	// RVA: 0x18C8D30 Offset: 0x18C7F30 VA: 0x1818C8D30
	public static bool op_Equality(PidVid x, PidVid y) { }

	// RVA: 0x18C8D50 Offset: 0x18C7F50 VA: 0x1818C8D50
	public static bool op_Inequality(PidVid x, PidVid y) { }

	// RVA: 0x18C8AC0 Offset: 0x18C7CC0 VA: 0x1818C8AC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C87F0 Offset: 0x18C79F0 VA: 0x1818C87F0
	public static bool ArrayContains(string[] pidVids, ref PidVid vidPid) { }

	// RVA: 0x18C8C30 Offset: 0x18C7E30 VA: 0x1818C8C30
	private static string bhXgmtZAyedirDaBPSxAJUVxGdPc(string ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False)]
internal static class Profiler // TypeDefIndex: 6739
{
	// Fields
	private const string yIeemKAxDPymWwCqBLgCKlszrWvq = "ENABLE_PROFILER must be set in Rewired Core to use the profiler.";

	// Properties
	public static bool enableBinaryLog { get; set; }
	public static bool enabled { get; set; }
	public static string logFile { get; set; }
	public static bool supported { get; }
	public static uint usedHeapSize { get; }
	public static long usedHeapSizeLong { get; }

	// Methods

	// RVA: 0x18C9410 Offset: 0x18C8610 VA: 0x1818C9410
	private static void gXtszyFOcMQxIdZYNVQoFnGHLszh() { }

	// RVA: 0x18C9490 Offset: 0x18C8690 VA: 0x1818C9490
	public static bool get_enableBinaryLog() { }

	// RVA: 0x18C9410 Offset: 0x18C8610 VA: 0x1818C9410
	public static void set_enableBinaryLog(bool value) { }

	// RVA: 0x18C9490 Offset: 0x18C8690 VA: 0x1818C9490
	public static bool get_enabled() { }

	// RVA: 0x18C9410 Offset: 0x18C8610 VA: 0x1818C9410
	public static void set_enabled(bool value) { }

	// RVA: 0x18C94D0 Offset: 0x18C86D0 VA: 0x1818C94D0
	public static string get_logFile() { }

	// RVA: 0x18C9410 Offset: 0x18C8610 VA: 0x1818C9410
	public static void set_logFile(string value) { }

	// RVA: 0x18C9490 Offset: 0x18C8690 VA: 0x1818C9490
	public static bool get_supported() { }

	// RVA: 0x18C9450 Offset: 0x18C8650 VA: 0x1818C9450
	public static uint get_usedHeapSize() { }

	// RVA: 0x18C9450 Offset: 0x18C8650 VA: 0x1818C9450
	public static long get_usedHeapSizeLong() { }

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x18C9410 Offset: 0x18C8610 VA: 0x1818C9410
	public static void AddFramesFromFile(string file) { }

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x18C9410 Offset: 0x18C8610 VA: 0x1818C9410
	public static void BeginSample(string name) { }

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x18C9410 Offset: 0x18C8610 VA: 0x1818C9410
	public static void BeginSample(string name, Object targetObject) { }

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x18C9410 Offset: 0x18C8610 VA: 0x1818C9410
	public static void EndSample() { }

	// RVA: 0x18C9450 Offset: 0x18C8650 VA: 0x1818C9450
	public static uint GetMonoHeapSize() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static long GetMonoHeapSizeLong() { }

	// RVA: 0x18C9450 Offset: 0x18C8650 VA: 0x1818C9450
	public static uint GetMonoUsedSize() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static long GetMonoUsedSizeLong() { }

	// RVA: 0x18C9450 Offset: 0x18C8650 VA: 0x1818C9450
	public static int GetRuntimeMemorySize(Object o) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static long GetRuntimeMemorySizeLong(Object o) { }

	// RVA: 0x18C9450 Offset: 0x18C8650 VA: 0x1818C9450
	public static uint GetTotalAllocatedMemory() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static long GetTotalAllocatedMemoryLong() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static uint GetTotalReservedMemory() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static long GetTotalReservedMemoryLong() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static uint GetTotalUnusedReservedMemory() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static long GetTotalUnusedReservedMemoryLong() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal static class EnumConverter // TypeDefIndex: 6740
{
	// Methods

	// RVA: 0x18C57A0 Offset: 0x18C49A0 VA: 0x1818C57A0
	public static int ToUpdateLoopTypes(UpdateLoopSetting updateLoopSetting, List<UpdateLoopType> results) { }

	// RVA: 0x18C5740 Offset: 0x18C4940 VA: 0x1818C5740
	public static AlternateAxisCalibrationType ToAlternateAxisCalibrationType(ThrottleCalibrationMode throttleCalibrationMode) { }
}

// Namespace: 
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
public sealed class ThreadSafeUnityInput.Keyboard // TypeDefIndex: 6741
{
	// Fields
	private const int cTYIIhkSNLiIzOyoHHWyhltrjmEo = 132;
	public static readonly int keyValueIndex_Escape; // 0x0
	public static readonly int keyValueIndex_Menu; // 0x4
	public static readonly int keyValueIndex_F2; // 0x8
	public static readonly int keyValueIndex_UpArrow; // 0xC
	public static readonly int keyValueIndex_RightArrow; // 0x10
	public static readonly int keyValueIndex_DownArrow; // 0x14
	public static readonly int keyValueIndex_LeftArrow; // 0x18
	private static readonly int[] FDXFTVtcyKlkdedDEqMUjiTDukzQ; // 0x20
	private readonly int EwPLuxlLbXZPcFBAUdFgjFxRiXUi; // 0x10
	private readonly int[] MImzPkCIMMxNKCaAnxjOIRjWBMmI; // 0x18
	private readonly bool[] EUVZDAbPFNBmuXHqxanDSAUisHVC; // 0x20
	private bool AqHaORMjZGTdLoJMHbRKCeXHvJfRA; // 0x28
	private int CeqBbAEzMDsJhQVtmbLbtWwszpnM; // 0x2C
	private readonly bool UmBzFAAyvjqLTqomLdIguNQCgLaB; // 0x30
	private bool EOIYzDBryxEkaWhJxYqkYWsTmCLI; // 0x31

	// Properties
	public bool enabled { get; set; }
	public bool monitoring { get; }
	public int keyCount { get; }

	// Methods

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_enabled() { }

	// RVA: 0x18C7850 Offset: 0x18C6A50 VA: 0x1818C7850
	public void set_enabled(bool value) { }

	// RVA: 0x18C7840 Offset: 0x18C6A40 VA: 0x1818C7840
	public bool get_monitoring() { }

	// RVA: 0xAA0220 Offset: 0xA9F420 VA: 0x180AA0220
	public int get_keyCount() { }

	// RVA: 0x18C74B0 Offset: 0x18C66B0 VA: 0x1818C74B0
	private static void .cctor() { }

	// RVA: 0x18C76D0 Offset: 0x18C68D0 VA: 0x1818C76D0
	public void .ctor() { }

	// RVA: 0x18C7070 Offset: 0x18C6270 VA: 0x1818C7070
	public void Initialize() { }

	// RVA: 0x18C7140 Offset: 0x18C6340 VA: 0x1818C7140
	public void PostInitialize() { }

	// RVA: 0x18C7150 Offset: 0x18C6350 VA: 0x1818C7150
	public void Update() { }

	// RVA: 0x18C70C0 Offset: 0x18C62C0 VA: 0x1818C70C0
	public void Monitor(bool state) { }

	// RVA: 0x18C6FE0 Offset: 0x18C61E0 VA: 0x1818C6FE0
	public bool GetKey(KeyCode keyCode) { }

	// RVA: 0x18C6F70 Offset: 0x18C6170 VA: 0x1818C6F70
	public void GetKeyValues(bool[] values) { }

	// RVA: 0x18C6E90 Offset: 0x18C6090 VA: 0x1818C6E90
	public void Clear() { }

	// RVA: 0x18C7450 Offset: 0x18C6650 VA: 0x1818C7450
	private void cCdKTiJIWNFDxgjNVSWxhdfuZPnt() { }

	// RVA: 0x18C6E80 Offset: 0x18C6080 VA: 0x1818C6E80
	private void BHjXZDxKJshZmZczZFrInOrGAvqH() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void yvffNSEZeSTAGUtjMSIBFYWdUCZ() { }

	// RVA: 0x18C7450 Offset: 0x18C6650 VA: 0x1818C7450
	private void UyAKUkrMhspVtwTdCweFLMAjemIbA() { }

	// RVA: 0x18C7470 Offset: 0x18C6670 VA: 0x1818C7470
	private void XZDLbAAWrkJvkhutOuHIOVcdjKsp() { }

	// RVA: 0x18C7950 Offset: 0x18C6B50 VA: 0x1818C7950
	private void xDlxWbIVtInyyJLwBsLykMiLCFJb() { }
}

// Namespace: 
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class ThreadSafeUnityInput.Mouse // TypeDefIndex: 6742
{
	// Fields
	private const int dMYthgilajDwsEEUbjsoUMrLjXgRA = 7;
	private const int dlFHsjxsLETDGWpWNiaFNmHAtPiR = 4;
	private readonly bool[] qCcRvKGVZggEJuRPOApCjfkkjLFN; // 0x10
	private readonly float[] FpGfpeBoiHDCxAyOgshDnpNwFkQTA; // 0x18
	private int CeqBbAEzMDsJhQVtmbLbtWwszpnM; // 0x20
	private Vector3 USwDTfNUDEQQNZnrnNUhKdwHljLC; // 0x24
	private bool HlGqYxsoNsFFrIkCKrQUYnHgMyZH; // 0x30
	private bool HeyddakbilgxOIPvyKiwyiGObemE; // 0x31

	// Properties
	public bool monitoring { get; }
	public Vector3 mousePosition { get; }
	public bool mousePresent { get; }

	// Methods

	// RVA: 0x18C87A0 Offset: 0x18C79A0 VA: 0x1818C87A0
	public bool get_monitoring() { }

	// RVA: 0x4BD720 Offset: 0x4BC920 VA: 0x1804BD720
	public Vector3 get_mousePosition() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_mousePresent() { }

	// RVA: 0x18C86F0 Offset: 0x18C78F0 VA: 0x1818C86F0
	public void .ctor() { }

	// RVA: 0x18C83B0 Offset: 0x18C75B0 VA: 0x1818C83B0
	public void PostInitialize() { }

	// RVA: 0x18C83C0 Offset: 0x18C75C0 VA: 0x1818C83C0
	public void Update() { }

	// RVA: 0x18C8320 Offset: 0x18C7520 VA: 0x1818C8320
	public void Monitor(bool state) { }

	// RVA: 0x18C82B0 Offset: 0x18C74B0 VA: 0x1818C82B0
	public bool GetButton(int index) { }

	// RVA: 0x18C81D0 Offset: 0x18C73D0 VA: 0x1818C81D0
	public float GetAxisRaw(int index) { }

	// RVA: 0x18C8240 Offset: 0x18C7440 VA: 0x1818C8240
	public void GetButtonValues(bool[] buttons) { }

	// RVA: 0x18C8160 Offset: 0x18C7360 VA: 0x1818C8160
	public void GetAxisRawValues(float[] axes) { }

	// RVA: 0x18C86B0 Offset: 0x18C78B0 VA: 0x1818C86B0
	private void cCdKTiJIWNFDxgjNVSWxhdfuZPnt() { }

	// RVA: 0x18C80C0 Offset: 0x18C72C0 VA: 0x1818C80C0
	private void BHjXZDxKJshZmZczZFrInOrGAvqH() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void yvffNSEZeSTAGUtjMSIBFYWdUCZ() { }

	// RVA: 0x18C86B0 Offset: 0x18C78B0 VA: 0x1818C86B0
	private void UyAKUkrMhspVtwTdCweFLMAjemIbA() { }

	// RVA: 0x18C8120 Offset: 0x18C7320 VA: 0x1818C8120
	private void BOtlJuMByrfYCWsBEFJvFrLbJsHwA() { }

	// RVA: 0x18C87B0 Offset: 0x18C79B0 VA: 0x1818C87B0
	private void xDlxWbIVtInyyJLwBsLykMiLCFJb() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal static class ThreadSafeUnityInput // TypeDefIndex: 6743
{
	// Fields
	private static ThreadSafeUnityInput.Mouse JNceIwNwuPmnGlkHagPSsmJtvVzX; // 0x0
	private static ThreadSafeUnityInput.Keyboard megWfcjaPKjFqPUeRBIQKJOBAjgS; // 0x8

	// Properties
	public static ThreadSafeUnityInput.Mouse mouse { get; }
	public static ThreadSafeUnityInput.Keyboard keyboard { get; }

	// Methods

	// RVA: 0x18CA550 Offset: 0x18C9750 VA: 0x1818CA550
	public static ThreadSafeUnityInput.Mouse get_mouse() { }

	// RVA: 0x18CA370 Offset: 0x18C9570 VA: 0x1818CA370
	public static ThreadSafeUnityInput.Keyboard get_keyboard() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Initialize() { }

	// RVA: 0x18CA150 Offset: 0x18C9350 VA: 0x1818CA150
	public static void PostInitialize() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void PostInitialize2() { }

	// RVA: 0x18CA0F0 Offset: 0x18C92F0 VA: 0x1818CA0F0
	public static void Deinitialize() { }

	// RVA: 0x18CA1C0 Offset: 0x18C93C0 VA: 0x1818CA1C0
	public static void Update() { }
}

// Namespace: 
internal class EzquJbHEydffWdoNsmXAduNipKns // TypeDefIndex: 6744
{
	// Fields
	public readonly EOUWaxCVQTNDomlxVsogCIpJuUVB[] yyIdQEtZFeRetsWTYjnaLSblnTyA; // 0x10
	public readonly EOUWaxCVQTNDomlxVsogCIpJuUVB[] HnkfaIKEuZUMwyeKwbJfOsllLEWq; // 0x18
	public readonly EOUWaxCVQTNDomlxVsogCIpJuUVB[] JfmJfNFMScdECKFvzgwFwRmgqNzhA; // 0x20
	public readonly EOUWaxCVQTNDomlxVsogCIpJuUVB[] PQtXgFYOMLDrCBUgPkxNDtjibabF; // 0x28

	// Methods

	// RVA: 0x1808FD0 Offset: 0x18081D0 VA: 0x181808FD0
	public void .ctor(EOUWaxCVQTNDomlxVsogCIpJuUVB[] , EOUWaxCVQTNDomlxVsogCIpJuUVB[] , EOUWaxCVQTNDomlxVsogCIpJuUVB[] , EOUWaxCVQTNDomlxVsogCIpJuUVB[] ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal struct LowLevelInputEvent // TypeDefIndex: 6745
{
	// Fields
	private const int PCPQdjKJGUTrvCCpWhoCEAgcglDU = 4;
	private const int nVCpNEeGnhvTGQPFNbJCzLAEXjOg = 8;
	private const int mpwDeQQbXZDTQKaUQqDrbdDvjbPo = 12;
	public const int buttonsPerPage = 32;
	public const int bytesPerButtonPage = 4;
	private const int JUvbGpRZJLHcsUmKBENTntMoizcC = 4;
	private const int kgYXGJGCZWBhzzozUJxnTQteXTrD = 4;
	public const int byteIndex_id = 0;
	public const int byteIndex_timestamp = 4;
	public const int byteIndex_elementsStart = 12;
	public IntPtr _buffer; // 0x0
	private int BLTtnEluUMAglSmjEJRxQEUjEIsl; // 0x8
	private int obpSlkOZGAMliMndpbbCzYkVINIv; // 0xC
	private int CMDQdGFzJRlLrErfZHLLJHBJirR; // 0x10
	private int XsFhNBjmIVPanbduzJhNROjJRerx; // 0x14
	private int nAQAZsJeUPGNtBFKynUvJUfEhdcY; // 0x18
	private int pBUUHmzIgqWlMnYKRXYkceOmLoRA; // 0x1C

	// Properties
	public bool isValid { get; }
	public int buttonCount { get; }
	public int axisCount { get; }
	public int byteIndex_axesStart { get; }
	public int byteIndex_buttonsStart { get; }
	public int byteIndex_hatsStart { get; }

	// Methods

	// RVA: 0x167A080 Offset: 0x1679280 VA: 0x18167A080
	public bool get_isValid() { }

	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_buttonCount() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_axisCount() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_byteIndex_axesStart() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_byteIndex_buttonsStart() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_byteIndex_hatsStart() { }

	// RVA: 0x18C7FE0 Offset: 0x18C71E0 VA: 0x1818C7FE0
	public void .ctor(IntPtr , int , int , int ) { }

	// RVA: 0x18C7DE0 Offset: 0x18C6FE0 VA: 0x1818C7DE0
	public void SetButtonsBitMask(int bitMask, int startButtonIndex) { }

	// RVA: 0x18C7D30 Offset: 0x18C6F30 VA: 0x1818C7D30
	public void SetAxisValue(int index, float value) { }

	// RVA: 0x18C7ED0 Offset: 0x18C70D0 VA: 0x1818C7ED0
	public void SetId(uint id) { }

	// RVA: 0x18C7F40 Offset: 0x18C7140 VA: 0x1818C7F40
	public void SetTimestamp(double value) { }

	// RVA: 0x18C7A30 Offset: 0x18C6C30 VA: 0x1818C7A30
	public bool GetButtonValue(int index) { }

	// RVA: 0x18C7B20 Offset: 0x18C6D20 VA: 0x1818C7B20
	public int GetButtonsBitMask(int startButtonIndex) { }

	// RVA: 0x18C7990 Offset: 0x18C6B90 VA: 0x1818C7990
	public float GetAxisValue(int index) { }

	// RVA: 0x18C7C10 Offset: 0x18C6E10 VA: 0x1818C7C10
	public uint GetId() { }

	// RVA: 0x18C7CA0 Offset: 0x18C6EA0 VA: 0x1818C7CA0
	public double GetTimestamp() { }

	// RVA: 0x18C7C70 Offset: 0x18C6E70 VA: 0x1818C7C70
	public static int GetReportSize(int buttonCount, int axisCount, int hatCount) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
[EditorBrowsable(1)]
public static class Consts // TypeDefIndex: 6746
{
	// Fields
	public const int systemPlayerId = 9999999;
	public const string menuRoot = "Window/Rewired";
	internal const int programVersion1 = 1;
	internal const int programVersion2 = 1;
	internal const int programVersion3 = 57;
	internal const int programVersion4 = 2;
	internal const int dataVersion = 1;
	internal const int unityMajorVersion = 2021;
	internal const string unityMajorVersionIdentifier = "U2021";
	internal const bool isTrial = False;
	internal const string copyrightYear = "2021";
	internal const string defaultNamespace = "Rewired";
	internal const LogLevelFlags defaultLogLevel = 7;
	internal const bool allowInputWhenEditorPaused = True;
	internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers = "[SplitTriggers]";
	internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers = "[CombinedTriggers]";
	internal const float editorGUIUpdateInterval = 0,5;
	internal const float joystickRefreshPollCheckTimeout = 1;
	internal const float controllerRefreshWaitTimeout = 0,5;
	internal const int buttonsPerHat = 8;
	internal const int keyboardKeyCount = 132;
	internal const int keyboardModifierKeyCount = 8;
	internal const int unityMouseButtonCount = 7;
	internal const int unityMouseAxisCount = 4;
	internal const int unityMaxJoysticks = 16;
	internal const int unityJoystickButtonCount = 20;
	internal const int unityJoystickStartingButtonKeycodeValue = 350;
	internal const int unityJoystickAxisCount = 29;
	internal const int unityJoystickLastJoystickIdWithButtonKeyCodes = 16;
	internal const string unityJoystickPrefix = "Joy";
	internal const string unityJoystickAxisSuffix = "Axis";
	internal const string unityJoystickButtonSuffix = "Button";
	internal const int directInputMaxButtons = 128;
	internal const int directInputMaxAxes = 32;
	internal const int directInputMaxHats = 4;
	internal const int directInputMaxSliders = 2;
	internal const int directInputMaxAxisValue = 65535;
	internal const int directInputMinAxisValue = -65535;
	internal const int directInputMaxHatValue = 36000;
	internal const int directInputHatZeroValue = -1;
	internal const int directInputHatSpan = 4500;
	internal const int directInputHatSpan4Way = 9000;
	internal const int directInput_hatValue_up = 0;
	internal const int directInput_hatValue_right = 9000;
	internal const int directInput_hatValue_down = 18000;
	internal const int directInput_hatValue_left = 27000;
	internal const int directInputLastDirectionValue = 31500;
	internal const int directInputLastDirectionValue4Way = 27000;
	internal const int directInputUnknownJoystickHatCount = 2;
	internal const int directInputUnknownJoystickHatButtonStartIndex = 128;
	internal const int directInputJoystickStateByteSize = 264;
	internal const int rawInputMaxButtons = 256;
	internal const int rawInputMaxAxes = 56;
	internal const int rawInputMaxHats = 4;
	internal const int rawInputMaxSliders = 2;
	internal const int rawInputMaxAxisValue = 65535;
	internal const int rawInputMinAxisValue = -65535;
	internal const int rawInputMaxHatValue = 36000;
	internal const int rawInputHatZeroValue = -1;
	internal const int rawInputHatSpan = 4500;
	internal const int rawInputHatSpan4Way = 9000;
	internal const int rawInput_hatValue_up = 0;
	internal const int rawInput_hatValue_right = 9000;
	internal const int rawInput_hatValue_down = 18000;
	internal const int rawInput_hatValue_left = 27000;
	internal const int rawInputLastDirectionValue = 31500;
	internal const int rawInputLastDirectionValue4Way = 27000;
	internal const int rawInputUnknownJoystickHatCount = 2;
	internal const int rawInputUnknownJoystickHatButtonStartIndex = 128;
	internal const int rawInputUnifiedMouseButtonCount = 5;
	internal const int rawInputUnifiedMouseAxisCount = 4;
	internal const float rawInputUnifiedMouseAxisUnityEquivalencyMultiplier = 0,5;
	internal const int rawInputUnifiedKeyboardButtonCount = 132;
	internal const int osxMaxSticks = 4;
	internal const int osxMaxButtons = 128;
	internal const int osxMaxAxesPerStick = 14;
	internal const int osxMaxHatsPerStick = 4;
	internal const int osxMaxAxisValue = 65536;
	internal const int osxMinAxisValue = -65536;
	internal const int osxMaxPressureSensitiveButtonValue = 65536;
	internal const int osxMinPressureSensitiveButtonValue = 0;
	internal const int osxMaxHatValue = 36000;
	internal const int osxInputHatZeroValue = -1;
	internal const int osxHatSpan = 4500;
	internal const int osxHatSpan4Way = 9000;
	internal const int osx_hatValue_up = 0;
	internal const int osx_hatValue_right = 9000;
	internal const int osx_hatValue_down = 18000;
	internal const int osx_hatValue_left = 27000;
	internal const int osxLastDirectionValue = 31500;
	internal const int osxLastDirectionValue4Way = 27000;
	internal const int osxUnknownJoystickHatCount = 16;
	internal const int osxUnknownJoystickHatButtonStartIndex = 128;
	internal const int linuxMaxButtons = 256;
	internal const int linuxMaxAxes = 56;
	internal const int linuxMaxHats = 4;
	internal const int linuxMaxSliders = 2;
	internal const int linuxMaxAxisValue = 32767;
	internal const int linuxMinAxisValue = -32768;
	internal const int linuxMaxHatValue = 36000;
	internal const int linuxHatZeroValue = -1;
	internal const int linuxHatSpan = 4500;
	internal const int linuxHatSpan4Way = 9000;
	internal const int linux_hatValue_up = 0;
	internal const int linux_hatValue_right = 9000;
	internal const int linux_hatValue_down = 18000;
	internal const int linux_hatValue_left = 27000;
	internal const int linuxLastDirectionValue = 31500;
	internal const int linuxLastDirectionValue4Way = 27000;
	internal const int linuxUnknownJoystickHatCount = 2;
	internal const int linuxUnknownJoystickHatButtonStartIndex = 128;
	internal const int linuxUnifiedMouseButtonCount = 5;
	internal const int linuxUnifiedMouseAxisCount = 3;
	internal const float linuxUnifiedMouseAxisUnityEquivalencyMultiplier = 0,5;
	internal const int sdl2MaxButtons = 256;
	internal const int sdl2MaxAxes = 56;
	internal const int sdl2MaxHats = 4;
	internal const int sdl2MaxSliders = 2;
	internal const int sdl2MaxAxisValue = 32768;
	internal const int sdl2MinAxisValue = -32767;
	internal const int sdl2AxisZeroValue = 0;
	internal const int sdl2MaxHatValue = 36000;
	internal const int sdl2HatZeroValue = -1;
	internal const int sdl2HatSpan = 4500;
	internal const int sdl2HatSpan4Way = 9000;
	internal const int sdl2_hatValue_up = 0;
	internal const int sdl2_hatValue_right = 9000;
	internal const int sdl2_hatValue_down = 18000;
	internal const int sdl2_hatValue_left = 27000;
	internal const int sdl2LastDirectionValue = 31500;
	internal const int sdl2LastDirectionValue4Way = 27000;
	internal const int sdl2UnknownJoystickHatCount = 2;
	internal const int sdl2UnknownJoystickHatButtonStartIndex = 128;
	internal const int sdl2UnifiedMouseButtonCount = 5;
	internal const int sdl2UnifiedMouseAxisCount = 3;
	internal const float sdl2UnifiedMouseAxisUnityEquivalencyMultiplier = 0,5;
	internal const int windowsUWPMaxButtons = 256;
	internal const int windowsUWPMaxAxes = 56;
	internal const int windowsUWPMaxHats = 4;
	internal const int windowsUWPMaxSliders = 2;
	internal const int windowsUWPMaxAxisValue = 32767;
	internal const int windowsUWPMinAxisValue = -32768;
	internal const int windowsUWPMaxHatValue = 36000;
	internal const int windowsUWPHatZeroValue = -1;
	internal const int windowsUWPDirectionsPerHat = 8;
	internal const int windowsUWPHatSpan = 4500;
	internal const int windowsUWPHatSpan4Way = 9000;
	internal const int windowsUWPLastDirectionValue = 31500;
	internal const int windowsUWPLastDirectionValue4Way = 27000;
	internal const int windowsUWPUnknownJoystickHatCount = 2;
	internal const int windowsUWPUnknownJoystickHatButtonStartIndex = 128;
	internal const int windowsUWPUnifiedMouseButtonCount = 5;
	internal const int windowsUWPUnifiedMouseAxisCount = 3;
	internal const float windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier = 0,5;
	internal const int windowsGamingInputHatZeroValue = -1;
	internal const int xInputMaxVibration = 65535;
	internal const int xInputMinVibration = 0;
	internal const float xInputAllowedVibrationInterval = 0,01;
	internal const int customPlatformMaxButtons = 256;
	internal const int customPlatformMaxAxes = 128;
	internal const int internalDriverMaxButtons = 256;
	internal const int internalDriverMaxAxes = 56;
	internal const int internalDriverMaxHats = 4;
	internal const int internalDriverMaxSliders = 2;
	internal const int internalDriverMaxAxisValue = 65535;
	internal const int internalDriverMinAxisValue = -65535;
	internal const int internalDriverMaxHatValue = 36000;
	internal const int internalDriverHatZeroValue = -1;
	internal const int internalDriverHatSpan = 4500;
	internal const int internalDriverHatSpan4Way = 9000;
	internal const int internalDriver_hatValue_up = 0;
	internal const int internalDriver_hatValue_right = 9000;
	internal const int internalDriver_hatValue_down = 18000;
	internal const int internalDriver_hatValue_left = 27000;
	internal const int internalDriverLastDirectionValue = 31500;
	internal const int internalDriverLastDirectionValue4Way = 27000;
	internal const int internalDriverUnknownJoystickHatCount = 2;
	internal const int internalDriverUnknownJoystickHatButtonStartIndex = 128;
	internal const int internalDriverUnifiedMouseButtonCount = 5;
	internal const int internalDriverUnifiedMouseAxisCount = 3;
	internal const float internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier = 0,5;
	internal const int webGLMaxButtons = 256;
	internal const int webGLMaxAxes = 128;
	internal const int gameCoreMaxButtons = 256;
	internal const int gameCoreMaxAxes = 32;
	internal const int gameCoreMaxHats = 4;
	internal const int gameCoreUnknownJoystickButtonCount = 128;
	internal const int gameCoreUnknownJoystickAxisCount = 32;
	internal const int gameCoreUnknownJoystickHatCount = 2;
	internal const int appleGCControllerMaxButtons = 128;
	internal const int appleGCControllerMaxAxes = 32;
	internal const int appleGCControllerMaxCompoundElements = 32;
	internal const int appleGCControllerUnknownJoystickButtonCount = 128;
	internal const int appleGCControllerUnknownJoystickAxisCount = 32;
	internal const int windowsGamingInputMaxButtons = 128;
	internal const int windowsGamingInputMaxAxes = 32;
	internal const int windowsGamingInputMaxHats = 16;
	internal const int windowsGamingInputMaxCompoundElements = 32;
	internal const int windowsGamingInputUnknownJoystickButtonCount = 128;
	internal const int windowsGamingInputUnknownJoystickAxisCount = 32;
	internal const int windowsGamingInputUnknownJoystickHatCount = 16;
	internal const int unknownJoystickMaxButtons = 128;
	internal const int unknownJoystickMaxAxes = 32;
	internal const int unknownJoystickMaxHats = 16;
	internal const int unknownJoystickButtonsPerHat = 8;
	internal const int unknownJoystickAxisElementIdentifierStartIndex = 0;
	internal const int unknownJoystickButtonElementIdentifierStartIndex = 32;
	internal const int unknownJoystickHatElementIdentifierStartIndex = 160;
	internal const float unknownJoystickDefaultAxisDeadZone = 0,1;
	internal const float defaultAbsoluteAxisPollingDeadZone = 0,7;
	internal const float defaultRelativeAxisPollingDeadZone = 100;
	internal const float defaultMouseXYAxisPollingDeadzone = 100;
	internal const float defaultMouseOtherAxisPollingDeadzone = 2;
	internal const float defaultButtonDeadZone = 0,5;
	internal const float hardwareButtonDeadZone = 0,01;
	internal const float axisDefaultSensitivity = 1;
	internal const AxisSensitivityType axisDefaultSensitivityType = 0;
	internal const float defaultButtonDoublePressSpeed = 0,3;
	internal const float minDoubleButtonPressSpeed = 0,01;
	internal const float maxDoubleButtonPressSpeed = 10;
	internal const float defaultButtonShortPressTime = 0,25;
	internal const float minButtonShortPressTime = 0;
	internal const float maxButtonShortPressTime = 3,4028235E+38;
	internal const float defaultButtonShortPressExpiresIn = 0;
	internal const float minButtonShortPressExpiresIn = 0;
	internal const float maxButtonShortPressExpiresIn = 3,4028235E+38;
	internal const float defaultButtonLongPressTime = 1;
	internal const float minButtonLongPressTime = 0;
	internal const float maxButtonLongPressTime = 3,4028235E+38;
	internal const float defaultButtonLongPressExpiresIn = 0;
	internal const float minButtonLongPressExpiresIn = 0;
	internal const float maxButtonLongPressExpiresIn = 3,4028235E+38;
	internal const float defaultButtonRepeatDelay = 0;
	internal const float defaultButtonRepeatRate = 30;
	internal const float minButtonRepeatRate = 0,001;
	internal const float mouseAxisPollingTimerLength = 1;
	internal const float fallbackPollingTimeout = 1;
	internal const KeyCombinationOverrideMode defaultKeyCombinationOverrideMode = 2;
	internal const bool defaultGenerateKeyEventsOnKeyCombinationOverride = True;
	internal const string unknownJoystickName = "Unknown Controller";
	internal const float xInputControllerVibrationRenewalInterval = 1,5;
	internal const int defaultInputThreadUpdateRateFPS = 240;
	internal const int maxInputThreadUpdateRateFPS = 2000;
	internal const int osxXInputOutputReportRefreshRateFPS = 60;
	internal const int defaultOutputRefreshRateFPS = 100;
	internal const int hidOutputReportRefreshRateFPS = 100;
	internal const int hidOutputReportThreadKillTimeout = 10000;
	internal const int joystickInputReportRingBufferCapacity = 60;
	internal const float joystickInputReportRingBufferCapacityDuration = 0,25;
	internal const string resourecesDLLPath_windowsStandalone = "Libs/Rewired_Windows";
	internal const string resourecesDLLPath_osxStandalone = "Libs/Rewired_OSX";
	internal const string resourecesDLLPath_linux = "Libs/Rewired_Linux";
	internal const float defaultInputBehaviorAxisSensitivity = 1;
	internal const float defaultInputBehaviorAxisSimulation_gravity = 3;
	internal const float defaultInputBehaviorAxisSimulation_sensitivity = 3;
	internal const bool defaultInputBehaviorAxisSmoothing_snap = True;
	internal const bool defaultInputBehaviorAxisSmoothing_instantReverse = False;
	internal const bool defaultInputBehaviorAxisSimulation_enabled = True;
	internal const int allFlagsIntEnum = -1;
	internal const float osxPreventSystemSleepInterval = 30;
	internal const string schemaNameSpace = "http://guavaman.com/rewired";
	internal const string schemaBaseLocation = "http://guavaman.com/schemas/rewired/";
	internal const string schemaVersionControllerMap = "1.1";
	internal const string schemaVersionCalibrationMap = "1.3";
	internal const string schemaVersionInputBehavior = "1.4";
	internal const string schemaVersionControllerTemplateMap = "1.0";
	internal const string schemaVersionPlayerEnabledMapsHelperData = "1.0";
	internal const string schemaVersionPlayerControllerMapLayoutManagerData = "1.0";
	internal const int controllerMapDataVersion = 2;
	internal const int calibrationMapDataVersion = 4;
	internal const int inputBehaviorDataVersion = 5;
	internal const int controllerTemplateMapDataVersion = 1;
	internal const int playerMapEnablerDataVersion = 1;
	internal const int playerControllerMapLayoutManagerDataVersion = 1;
	internal static readonly PidVid[] questionablePidVids; // 0x0
	internal static readonly int[] questionableVIDs; // 0x8
	internal const int controllerElementType_trueElements_minValue = 0;
	internal const int controllerElementType_trueElements_maxValue = 99;
	internal const float pressureSensitiveButtonDeadZone = 0,001;
	internal const string rewiredEditorAssembly = "Rewired_Editor";
	internal const string rewiredEditorInputEditorClassFullName = "Rewired.Editor.InputEditor";
	internal const string nintendoSwitchPluginEditorRuntimeAssembly = "Rewired_NintendoSwitch_EditorRuntime";
	internal const string nintendoSwitchPluginInputManagerFullClassPath = "Rewired.Platforms.Switch.NintendoSwitchInputManager";
	internal const string nintendoSwitchPluginHWJoystickMapGuid_JoyConDual = "521b808c-0248-4526-bc10-f1d16ee76bf1";
	internal const string nintendoSwitchPluginHWJoystickMapGuid_Handheld = "1fbdd13b-0795-4173-8a95-a2a75de9d204";
	internal const string gameCorePluginEditorRuntimeAssembly = "Rewired_GameCore_EditorRuntime";
	internal const string gameCorePluginInputManagerFullClassPath = "Rewired.Platforms.GameCore.GameCoreInputManager";
	internal const string ps4PluginEditorRuntimeAssembly = "Rewired_PlayStation4_EditorRuntime";
	internal const string ps5PluginEditorRuntimeAssembly = "Rewired_PlayStation5_EditorRuntime";
	internal static Guid joystickGuid_unknownController; // 0x10
	internal static Guid joystickGuid_appleMFiController; // 0x20
	internal static Guid joystickGuid_standardizedGamepad; // 0x30
	internal static Guid joystickGuid_steamController; // 0x40
	internal static Guid joystickGuid_SonyDualShock4; // 0x50
	internal static Guid joystickGuid_SonyPS4AimController; // 0x60
	internal static Guid joystickGuid_SonyPS4Drums; // 0x70
	internal static Guid joystickGuid_SonyPS4FlightStick; // 0x80
	internal static Guid joystickGuid_SonyPS4Guitar; // 0x90
	internal static Guid joystickGuid_SonyPS4SteeringWheel; // 0xA0
	internal static Guid joystickGuid_SonyDualSense; // 0xB0
	internal static Guid hardwareTypeGuid_universalKeyboard; // 0xC0
	internal static Guid hardwareTypeGuid_universalMouse; // 0xD0
	private static readonly Guid[] nVfPdADplnJcQtPCgfeHocJHQCZw; // 0xE0
	internal static readonly ReadOnlyCollection<Guid> reservedHardwareTypeGuids; // 0xE8
	private static ControllerElementIdentifier.vrCPviWPNzNACqMBjKpVQfDwMNSs[] wgKveWTBXdBszjVOCSTvpcYggKdX; // 0xF0
	private static ReadOnlyCollection<ControllerElementIdentifier> vGgsKeakdpgjMaJaHYDJLRbUJUyyA; // 0xF8
	private static ReadOnlyCollection<ControllerElementIdentifier> iZtMIuKfFjxFKSsmYlaIlprWGLnf; // 0x100
	internal static readonly IList<string> mouseAxisUnityNames; // 0x108
	private static readonly string[] gMmRjSCDWPcHCDKzFMxgjRKkjayz; // 0x110
	internal static readonly IList<string> mouseButtonUnityNames; // 0x118
	private static readonly string[] FvPYsEFEVkqtocPFTuByVmyQhPqb; // 0x120
	internal static readonly IList<string> keyboardKeyNames; // 0x128
	private static readonly string[] SItqpOsqFygwhEDkZBIIvAhxheFp; // 0x130
	internal static readonly IList<int> keyboardKeyValues; // 0x138
	internal static readonly int[] _keyboardKeyValues; // 0x140
	private static readonly IList<string> GZrdntEPDxmrVHVflPNPbQcIsUCz; // 0x148
	private static readonly string[] sxzwzIXPNIjCHeNhboZuuGiQHpHV; // 0x150
	private static readonly IList<string> mbPOCFMFtHEYQcsfBoTHMPlkMRQIA; // 0x158
	private static readonly string[] PfiiwEKHeLVggGrrqUbODyLzgSSo; // 0x160
	internal static readonly IReadOnlyDictionary<int, Keyboard.ModifierKeyInfo> modifierKeyInfo; // 0x168
	public const int vendorId_sony = 1356;
	internal static readonly IList<PidVid> pidVids_sony_dualShock4; // 0x170
	private static readonly PidVid[] ncHHHLTHIJEXUhHmUtiBdyBytnWC; // 0x178
	internal static readonly IList<string> productNames_sony_dualShock4; // 0x180
	private static readonly string[] eXTcpqcjybKpwWJnqlfmcjHCLAdqb; // 0x188
	internal static readonly IList<PidVid> pidVids_sony_dualSense; // 0x190
	private static readonly PidVid[] yTtMWrOckHGzwJiTEhntdpUuhasw; // 0x198
	internal static readonly IList<string> productNames_sony_dualSense; // 0x1A0
	private static readonly string[] uHWdnQjKpJyCzPYrkvAlmzRRqCQp; // 0x1A8
	private static readonly ControllerElementIdentifier[] NIjIUAmtUGcKhcECTawAgAZapfdc; // 0x1B0
	internal const int updateLoopTypeCount = 3;

	// Properties
	internal static int nintendoSwitchPlugin_minPluginVersion { get; }
	internal static int gameCorePlugin_minPluginVersion { get; }
	internal static int ps4Plugin_minPluginVersion { get; }
	internal static int ps5Plugin_minPluginVersion { get; }
	internal static ControllerElementIdentifier.vrCPviWPNzNACqMBjKpVQfDwMNSs[] commonMouseElementIdentifierInitOptions { get; }
	internal static IList<ControllerElementIdentifier> unityUnifiedMouseElementIdentifiers { get; }
	internal static IList<ControllerElementIdentifier> rawInputUnifiedMouseElementIdentifiers { get; }
	public static IList<string> keyboardKeyKeys { get; }
	public static IList<string> keyboardModifierKeyKeys { get; }
	internal static ControllerElementIdentifier[] unknownJoystickElementIdentifiers_orig { get; }

	// Methods

	// RVA: 0x16FD490 Offset: 0x16FC690 VA: 0x1816FD490
	internal static int get_nintendoSwitchPlugin_minPluginVersion() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	internal static int get_gameCorePlugin_minPluginVersion() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	internal static int get_ps4Plugin_minPluginVersion() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	internal static int get_ps5Plugin_minPluginVersion() { }

	// RVA: 0x18BD0F0 Offset: 0x18BC2F0 VA: 0x1818BD0F0
	private static void .cctor() { }

	// RVA: 0x18C0770 Offset: 0x18BF970 VA: 0x1818C0770
	internal static ControllerElementIdentifier.vrCPviWPNzNACqMBjKpVQfDwMNSs[] get_commonMouseElementIdentifierInitOptions() { }

	// RVA: 0x18C1710 Offset: 0x18C0910 VA: 0x1818C1710
	internal static IList<ControllerElementIdentifier> get_unityUnifiedMouseElementIdentifiers() { }

	// RVA: 0x18C1370 Offset: 0x18C0570 VA: 0x1818C1370
	internal static IList<ControllerElementIdentifier> get_rawInputUnifiedMouseElementIdentifiers() { }

	// RVA: 0x18C12B0 Offset: 0x18C04B0 VA: 0x1818C12B0
	public static IList<string> get_keyboardKeyKeys() { }

	// RVA: 0x18C1310 Offset: 0x18C0510 VA: 0x1818C1310
	public static IList<string> get_keyboardModifierKeyKeys() { }

	// RVA: 0x18C1B40 Offset: 0x18C0D40 VA: 0x1818C1B40
	internal static ControllerElementIdentifier[] get_unknownJoystickElementIdentifiers_orig() { }

	// RVA: 0x18BC6A0 Offset: 0x18BB8A0 VA: 0x1818BC6A0
	private static ControllerElementIdentifier[] EwKVGHIBeaHviaChhqulwLmONdOf() { }
}

// Namespace: 
public abstract class Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR.ouLcDyFXyNLoWotePlujXDTspsunA // TypeDefIndex: 6747
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void PKwtxaXvImPLSHYDPPVYFvKIgugQ();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
internal abstract class Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR // TypeDefIndex: 6748
{
	// Fields
	protected readonly int NHaFBMyixYkKbfAxyeMIMUXcKwFg; // 0x10
	protected readonly int[] TPQPedaoTFEFAGfZpncIwhzCDJroA; // 0x18
	protected Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR.ouLcDyFXyNLoWotePlujXDTspsunA[] dSqWRUMESoQNVjlRwDHrJhHqUcrF; // 0x20
	public Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR.ouLcDyFXyNLoWotePlujXDTspsunA iTFuASGuQutVUojQqElkbhgbLQmGA; // 0x28
	private int WIMClyaZOusxlluzIKvuJVSnDMD; // 0x30
	public int GpzjYGKCXJETgEjYKnMLWffWwBPBA; // 0x34
	protected ReadOnlyCollection<Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR.ouLcDyFXyNLoWotePlujXDTspsunA> DLpxDwwzKEuwLpmIDhNuzUVaBfge; // 0x38

	// Properties
	public IList<Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR.ouLcDyFXyNLoWotePlujXDTspsunA> nlBNIOHaXJiqrMTteQFgJjwBLShO { get; }
	public UpdateLoopType pdMpguIIJSXJuwgCZpDStKcWwtYN { set; }

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public IList<Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR.ouLcDyFXyNLoWotePlujXDTspsunA> xnaYDGzKmxfKVIipZByBHaTLYntVA() { }

	// RVA: 0x18E8C30 Offset: 0x18E7E30 VA: 0x1818E8C30
	public void zPFWMQpCzwJgyJDOSdmIEXbgHRDQA(UpdateLoopType ) { }

	// RVA: 0x18E8A20 Offset: 0x18E7C20 VA: 0x1818E8A20
	public void .ctor(UpdateLoopSetting ) { }

	// RVA: 0x18E89A0 Offset: 0x18E7BA0 VA: 0x1818E89A0
	public void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }

	// RVA: 0x18E8960 Offset: 0x18E7B60 VA: 0x1818E8960
	public Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR.ouLcDyFXyNLoWotePlujXDTspsunA FfZLBJmzYBGJGvSgrpmziKneKTcP(UpdateLoopType ) { }
}

// Namespace: 
public abstract class Controller.Element // TypeDefIndex: 6749
{
	// Fields
	public readonly int id; // 0x10
	public readonly string name; // 0x18
	public readonly ControllerElementType type; // 0x20
	internal Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR IPkUXAZqWeteiqWSJRjhYlfsWXPc; // 0x28
	internal int vadbbLaTbDkYeQgpkkKYNnLulaWf; // 0x30
	internal Controller MjXwpaWgoFbhLALGDhNxlBElkuGl; // 0x38
	internal readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x40
	private Controller.CompoundElement HzfDGgJCYZIrsTkJdwxFspQlxXRcA; // 0x48

	// Properties
	public ControllerElementIdentifier elementIdentifier { get; }
	public bool isMemberElement { get; }
	public Controller.CompoundElement compoundElement { get; }

	// Methods

	// RVA: 0x18E1AD0 Offset: 0x18E0CD0 VA: 0x1818E1AD0
	public ControllerElementIdentifier get_elementIdentifier() { }

	// RVA: 0x18E1B80 Offset: 0x18E0D80 VA: 0x1818E1B80
	public bool get_isMemberElement() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Controller.CompoundElement get_compoundElement() { }

	// RVA: 0x18E1A00 Offset: 0x18E0C00 VA: 0x1818E1A00
	internal void .ctor(Controller , int , string , ControllerElementType ) { }

	// RVA: 0x18E1910 Offset: 0x18E0B10 VA: 0x1818E1910
	public void Reset() { }

	// RVA: 0x18E18B0 Offset: 0x18E0AB0 VA: 0x1818E18B0
	internal void EjUljxeafxFpyiCgPMosXpxUAOAKA(Controller.CompoundElement ) { }

	// RVA: 0x18E1C10 Offset: 0x18E0E10 VA: 0x1818E1C10
	internal void zEkoIskbARqKvranEXplmysooqXV(Controller.CompoundElement ) { }
}

// Namespace: 
public class Controller.Axis.mHIZqFYBbvhIHfyYFQJeuHvjGbmx.tbYWgtRzzZQxEuKFCZfNWgJZcbam : Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR.ouLcDyFXyNLoWotePlujXDTspsunA // TypeDefIndex: 6750
{
	// Fields
	private const float VVoMFAeSlvzOsAqZZEZlSoZcszeL = 0,001;
	public float CdEckvrVAeswSaQCfMLbUlJjpTfR; // 0x10
	public float SGMJsWotyKKhqJZxQkbnCbTksVYy; // 0x14
	public float GRyAxrhJXHaDjdqtoWgzCeJMgpKtA; // 0x18
	public float xMrtmdbsKgIIzFTyFFVKYqJhatPBA; // 0x1C
	public float jOXxRjvQWorpVyydMRLaVGWPovDs; // 0x20
	public float GUetCPNGPrGlWZPYQFusicBSLWCe; // 0x24
	public double psKiFYaPtYOjRZEaIUKDTSXWUbpk; // 0x28
	public double FBkmRKMnVZKOQItxOcnWcypxXPGB; // 0x30
	public double QmIxgDmJHUKuvmYaUDpUEMlpKuwK; // 0x38
	public double SDNlTnHZcqLbQiHOhYBRegodHgoF; // 0x40
	public double duJDyyKwUGzjhBJEfBsyxDwsmhgJ; // 0x48
	public double dcHoFkpeBTgfLeeXBRnihYaQciUwA; // 0x50

	// Properties
	public double xnSfBkeLshESuEHbxQbQubNQJEGI { get; }
	public double iLItBsbJiABJaBRlbdGwNVXMzPXx { get; }
	public double lYkApkkDCUfGkLrpkxclvFjLCmjQA { get; }
	public double LYLdJFrERGAJLhDUnJukIkuYrwClA { get; }

	// Methods

	// RVA: 0x18E8D70 Offset: 0x18E7F70 VA: 0x1818E8D70
	public double KNjKzESFNQItjmOcNkMCekjYhIli() { }

	// RVA: 0x18E8D00 Offset: 0x18E7F00 VA: 0x1818E8D00
	public double HBGkRZPdjEnOknbtvaKyUfHdPCoy() { }

	// RVA: 0x18E8F60 Offset: 0x18E8160 VA: 0x1818E8F60
	public double kuHcXMvUfIjgpqAJqmcwXZMfhjgw() { }

	// RVA: 0x18E8C90 Offset: 0x18E7E90 VA: 0x1818E8C90
	public double AebMHedhckIyAYHUTXzAAZgltdHI() { }

	// RVA: 0x18E8DE0 Offset: 0x18E7FE0 VA: 0x1818E8DE0
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV(bool ) { }

	// RVA: 0x18E8FD0 Offset: 0x18E81D0 VA: 0x1818E8FD0
	public void tlSUZgofAjhXoRhpJwNUDdQzIFQX(float ) { }

	// RVA: 0x18E8F30 Offset: 0x18E8130 VA: 0x1818E8F30 Slot: 4
	public override void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class Controller.Axis.mHIZqFYBbvhIHfyYFQJeuHvjGbmx : Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR // TypeDefIndex: 6751
{
	// Methods

	// RVA: 0x18E87B0 Offset: 0x18E79B0 VA: 0x1818E87B0
	public void .ctor(UpdateLoopSetting ) { }
}

// Namespace: 
public sealed class Controller.Axis : Controller.Element // TypeDefIndex: 6752
{
	// Fields
	internal readonly AxisRange FQNeywDPCttjFUNLadNFaWxuTtulA; // 0x50
	internal readonly HardwareAxisInfo iQHusCUPFswFfpcAdnSNknDyWVur; // 0x58

	// Properties
	public float value { get; }
	public float valuePrev { get; }
	public float valueRaw { get; set; }
	public float valueRawPrev { get; }
	public float valueDelta { get; }
	public float valueDeltaRaw { get; }
	public double lastTimeActive { get; }
	public double lastTimeActiveRaw { get; }
	public double lastTimeInactive { get; }
	public double lastTimeInactiveRaw { get; }
	public double lastTimeValueChanged { get; }
	public double lastTimeValueChangedRaw { get; }
	public double timeActive { get; }
	public double timeActiveRaw { get; }
	public double timeInactive { get; }
	public double timeInactiveRaw { get; }
	public float pollingDeadZone { get; set; }
	internal float OewMQfFUlSxKxangGBYEYBaTRDmH { get; }
	internal float wNZkDcciglxAMiGoPOWnrQtvbRwB { get; }
	internal float ResvokzhpcTKZYTvloIGecrztUFj { get; }

	// Methods

	// RVA: 0x18D1420 Offset: 0x18D0620 VA: 0x1818D1420
	public float get_value() { }

	// RVA: 0x18D0F70 Offset: 0x18D0170 VA: 0x1818D0F70
	public float get_valuePrev() { }

	// RVA: 0x18D12D0 Offset: 0x18D04D0 VA: 0x1818D12D0
	public float get_valueRaw() { }

	// RVA: 0x18D1AC0 Offset: 0x18D0CC0 VA: 0x1818D1AC0
	internal void vthDJSrjRhDxvHfpGsUjSWmPMHyD(float ) { }

	// RVA: 0x18D1180 Offset: 0x18D0380 VA: 0x1818D1180
	public float get_valueRawPrev() { }

	// RVA: 0x18D0EC0 Offset: 0x18D00C0 VA: 0x1818D0EC0
	public float get_valueDelta() { }

	// RVA: 0x18D0CE0 Offset: 0x18CFEE0 VA: 0x1818D0CE0
	public float get_valueDeltaRaw() { }

	// RVA: 0x18CFFB0 Offset: 0x18CF1B0 VA: 0x1818CFFB0
	public double get_lastTimeActive() { }

	// RVA: 0x18CFE60 Offset: 0x18CF060 VA: 0x1818CFE60
	public double get_lastTimeActiveRaw() { }

	// RVA: 0x18D0250 Offset: 0x18CF450 VA: 0x1818D0250
	public double get_lastTimeInactive() { }

	// RVA: 0x18D0100 Offset: 0x18CF300 VA: 0x1818D0100
	public double get_lastTimeInactiveRaw() { }

	// RVA: 0x18D04F0 Offset: 0x18CF6F0 VA: 0x1818D04F0
	public double get_lastTimeValueChanged() { }

	// RVA: 0x18D03A0 Offset: 0x18CF5A0 VA: 0x1818D03A0
	public double get_lastTimeValueChangedRaw() { }

	// RVA: 0x18D0830 Offset: 0x18CFA30 VA: 0x1818D0830
	public double get_timeActive() { }

	// RVA: 0x18D06E0 Offset: 0x18CF8E0 VA: 0x1818D06E0
	public double get_timeActiveRaw() { }

	// RVA: 0x18D0B30 Offset: 0x18CFD30 VA: 0x1818D0B30
	public double get_timeInactive() { }

	// RVA: 0x18D0980 Offset: 0x18CFB80 VA: 0x1818D0980
	public double get_timeInactiveRaw() { }

	// RVA: 0x18D0640 Offset: 0x18CF840 VA: 0x1818D0640
	public float get_pollingDeadZone() { }

	// RVA: 0x18D18B0 Offset: 0x18D0AB0 VA: 0x1818D18B0
	public void set_pollingDeadZone(float value) { }

	// RVA: 0x18CF8B0 Offset: 0x18CEAB0 VA: 0x1818CF8B0
	internal float QjmhvOjuaOCthrQByGqMbxCshaos() { }

	// RVA: 0x18D1630 Offset: 0x18D0830 VA: 0x1818D1630
	internal float hLCijeSmSOUhlZnuhgOajOWYYpYK() { }

	// RVA: 0x18CF990 Offset: 0x18CEB90 VA: 0x1818CF990
	internal void RqqDUPVZtVHZSJcqSQKleOCaILby(float ) { }

	// RVA: 0x18D1960 Offset: 0x18D0B60 VA: 0x1818D1960
	internal float tEqFLWymjOsSBnCgPUQIQlwEDnZI() { }

	// RVA: 0x18CFCA0 Offset: 0x18CEEA0 VA: 0x1818CFCA0
	internal void .ctor(Controller , int , string , AxisRange , HardwareAxisInfo ) { }

	// RVA: 0x18D1A60 Offset: 0x18D0C60 VA: 0x1818D1A60
	internal void uibXYAlJguFmwLZjVcCdnQZqRcAH(UpdateLoopType ) { }

	// RVA: 0x18CF7C0 Offset: 0x18CE9C0 VA: 0x1818CF7C0
	internal void DXEGboivsFKYEzxkfLpHAvRnXcHOA(AxisCalibration ) { }

	// RVA: 0x18CF720 Offset: 0x18CE920 VA: 0x1818CF720
	internal void DXEGboivsFKYEzxkfLpHAvRnXcHOA() { }

	// RVA: 0x18D1710 Offset: 0x18D0910 VA: 0x1818D1710
	internal void ogNQAJvChBGFOvIdwIWHiBtJlGwW() { }

	// RVA: 0x18D17B0 Offset: 0x18D09B0 VA: 0x1818D17B0
	internal void qhvxyqHrsxiEKntljAzKtWYaTarm() { }

	// RVA: 0x18CFA40 Offset: 0x18CEC40 VA: 0x1818CFA40
	internal void UXIdrBAAegttDOgXOzMjmADtxloc(float ) { }

	// RVA: 0x18CF5E0 Offset: 0x18CE7E0 VA: 0x1818CF5E0
	internal float BbhEBykZnHHgJmriCYgSUekGkLXp(UpdateLoopType , AxisCalibration ) { }
}

// Namespace: 
public class Controller.Button.vLZSGBuovnQCsFWWlLGYqicqNHwu.UvtdELyiZImUWgdHehFveLNVljLm : Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR.ouLcDyFXyNLoWotePlujXDTspsunA // TypeDefIndex: 6753
{
	// Fields
	public bool CdEckvrVAeswSaQCfMLbUlJjpTfR; // 0x10
	public bool SGMJsWotyKKhqJZxQkbnCbTksVYy; // 0x11
	public ButtonStateRecorder UbMcSVijfMyVTlOwEbNRYhTZCXzdb; // 0x18
	public snzDlAKUlMXeBVaWzfslXTsdKrGIA FkChSXcljLwbwTbtgKMAgBaBKOdgb; // 0x20

	// Methods

	// RVA: 0x18E72B0 Offset: 0x18E64B0 VA: 0x1818E72B0
	public void .ctor() { }

	// RVA: 0x18E71B0 Offset: 0x18E63B0 VA: 0x1818E71B0
	public void ROpdkJZzkaEqMkeGLMPPtVjiKalS(bool ) { }

	// RVA: 0x18E7170 Offset: 0x18E6370 VA: 0x1818E7170 Slot: 4
	public override void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }
}

// Namespace: 
public class Controller.Button.vLZSGBuovnQCsFWWlLGYqicqNHwu.mZAPyxSbcYKQmkowqWBjGccwIsNIA : Controller.Button.vLZSGBuovnQCsFWWlLGYqicqNHwu.UvtdELyiZImUWgdHehFveLNVljLm // TypeDefIndex: 6754
{
	// Fields
	public float jawhHOmllKbfKgcVZEAeHopYcMMNA; // 0x28
	public float MrdNxmBbkyxkYPviGlGdtdEHrdsD; // 0x2C

	// Methods

	// RVA: 0x18E8950 Offset: 0x18E7B50 VA: 0x1818E8950
	public void .ctor() { }

	// RVA: 0x18E8900 Offset: 0x18E7B00 VA: 0x1818E8900
	public void ROpdkJZzkaEqMkeGLMPPtVjiKalS(float ) { }

	// RVA: 0x18E88B0 Offset: 0x18E7AB0 VA: 0x1818E88B0 Slot: 4
	public override void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }
}

// Namespace: 
internal class Controller.Button.vLZSGBuovnQCsFWWlLGYqicqNHwu : Controller.Element.ppCBUMYIwnWuPxJjbjaXhONNWVFR // TypeDefIndex: 6755
{
	// Methods

	// RVA: 0x18E9160 Offset: 0x18E8360 VA: 0x1818E9160
	public void .ctor(UpdateLoopSetting , bool ) { }

	// RVA: 0x18E92C0 Offset: 0x18E84C0 VA: 0x1818E92C0
	public void bEidyBRRHlimxnwfapmiMuGzcYpl(float ) { }

	// RVA: 0x18E9000 Offset: 0x18E8200 VA: 0x1818E9000
	public void BbhKznjevSmpvymVzkGiFLozFfoFA() { }
}

// Namespace: 
public sealed class Controller.Button : Controller.Element // TypeDefIndex: 6756
{
	// Fields
	internal readonly bool PoiJFnUpzTyVEujknIRiHjFFmtBo; // 0x50
	internal readonly HardwareButtonInfo UGwFMuADOYUKXuHDfoIaCEudkmuoc; // 0x58

	// Properties
	public bool valuePrev { get; }
	public bool value { get; }
	public float pressure { get; }
	public float pressurePrev { get; }
	public bool isPressureSensitive { get; }
	public bool justPressed { get; }
	public bool justReleased { get; }
	public bool justChangedState { get; }
	public bool doublePressedAndHeld { get; }
	public bool justDoublePressed { get; }
	public double timePressed { get; }
	public double timeUnpressed { get; }
	public double lastTimePressed { get; }
	public double lastTimeUnpressed { get; }
	public double lastTimeStateChanged { get; }
	internal ButtonStateFlags weGbcORDZNccLYOrlQZnpBKpgbQF { get; }

	// Methods

	// RVA: 0x18D3D70 Offset: 0x18D2F70 VA: 0x1818D3D70
	public bool get_valuePrev() { }

	// RVA: 0x18D3EB0 Offset: 0x18D30B0 VA: 0x1818D3EB0
	public bool get_value() { }

	// RVA: 0x18D38B0 Offset: 0x18D2AB0 VA: 0x1818D38B0
	public float get_pressure() { }

	// RVA: 0x18D3690 Offset: 0x18D2890 VA: 0x1818D3690
	public float get_pressurePrev() { }

	// RVA: 0x18D2B10 Offset: 0x18D1D10 VA: 0x1818D2B10
	public bool get_isPressureSensitive() { }

	// RVA: 0x18D2EE0 Offset: 0x18D20E0 VA: 0x1818D2EE0
	public bool get_justPressed() { }

	// RVA: 0x18D30C0 Offset: 0x18D22C0 VA: 0x1818D30C0
	public bool get_justReleased() { }

	// RVA: 0x18D2BA0 Offset: 0x18D1DA0 VA: 0x1818D2BA0
	public bool get_justChangedState() { }

	// RVA: 0x18D29C0 Offset: 0x18D1BC0 VA: 0x1818D29C0
	public bool get_doublePressedAndHeld() { }

	// RVA: 0x18D2D80 Offset: 0x18D1F80 VA: 0x1818D2D80
	public bool get_justDoublePressed() { }

	// RVA: 0x18D3AD0 Offset: 0x18D2CD0 VA: 0x1818D3AD0
	public double get_timePressed() { }

	// RVA: 0x18D3C20 Offset: 0x18D2E20 VA: 0x1818D3C20
	public double get_timeUnpressed() { }

	// RVA: 0x18D32A0 Offset: 0x18D24A0 VA: 0x1818D32A0
	public double get_lastTimePressed() { }

	// RVA: 0x18D3540 Offset: 0x18D2740 VA: 0x1818D3540
	public double get_lastTimeUnpressed() { }

	// RVA: 0x18D33F0 Offset: 0x18D25F0 VA: 0x1818D33F0
	public double get_lastTimeStateChanged() { }

	// RVA: 0x18D3FF0 Offset: 0x18D31F0 VA: 0x1818D3FF0
	internal ButtonStateFlags jdlVdPBudBUcvcslqDJuVXMsKUvv() { }

	// RVA: 0x18D2780 Offset: 0x18D1980 VA: 0x1818D2780
	internal void .ctor(Controller , int , string , HardwareButtonInfo ) { }

	// RVA: 0x18D28A0 Offset: 0x18D1AA0 VA: 0x1818D28A0
	internal void .ctor(Controller , int , string , bool , HardwareButtonInfo ) { }

	// RVA: 0x18D1BD0 Offset: 0x18D0DD0 VA: 0x1818D1BD0
	public bool DoublePressedAndHeld(float speed) { }

	// RVA: 0x18D1E00 Offset: 0x18D1000 VA: 0x1818D1E00
	public bool JustDoublePressed(float speed) { }

	// RVA: 0x18D2040 Offset: 0x18D1240 VA: 0x1818D2040
	internal void ROpdkJZzkaEqMkeGLMPPtVjiKalS(UpdateLoopType , int , ControllerDataUpdater ) { }

	// RVA: 0x18D22F0 Offset: 0x18D14F0 VA: 0x1818D22F0
	internal void URNqXhxfUHCsIMEHmwVeYUaKHdjf(UpdateLoopType ) { }

	// RVA: 0x18D2530 Offset: 0x18D1730 VA: 0x1818D2530
	internal void UXIdrBAAegttDOgXOzMjmADtxloc() { }
}

// Namespace: 
private class Controller.CompoundElement.akizbHfMiCjntsRxPIOPndxZWpiK // TypeDefIndex: 6757
{
	// Fields
	public readonly Controller.Element wJPDScqWkzUIZVAHhFjPxmZLlsks; // 0x10
	public readonly int TKZalybUaRqgoSjFAeepWEAqPOKSA; // 0x18

	// Methods

	// RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	public void .ctor(Controller.Element , int ) { }
}

// Namespace: 
public abstract class Controller.CompoundElement // TypeDefIndex: 6758
{
	// Fields
	private int dloXlVErIzRNttSTwpuctPZXBqjHA; // 0x10
	private string NsRFUoBLVeZwnSsExKWhwStYeoRV; // 0x18
	private CompoundControllerElementType pOhBaZskjTHDxcxbPUVoUhsOLebB; // 0x20
	private int DYlksxJmueEjKxIXVVMZgGCWkNTO; // 0x24
	private Controller.CompoundElement.akizbHfMiCjntsRxPIOPndxZWpiK[] YMDWxmViwDoKkxAzGzCOVCAFbaCT; // 0x28
	private Controller MjXwpaWgoFbhLALGDhNxlBElkuGl; // 0x30
	internal readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x38

	// Properties
	public int id { get; }
	public string name { get; }
	public CompoundControllerElementType type { get; }
	public bool hasElements { get; }
	public int elementCount { get; }
	public abstract int elementCapacity { get; }
	public ControllerElementIdentifier elementIdentifier { get; }

	// Methods

	// RVA: 0x18D4870 Offset: 0x18D3A70 VA: 0x1818D4870
	public int get_id() { }

	// RVA: 0x18D4900 Offset: 0x18D3B00 VA: 0x1818D4900
	public string get_name() { }

	// RVA: 0x18D49A0 Offset: 0x18D3BA0 VA: 0x1818D49A0
	public CompoundControllerElementType get_type() { }

	// RVA: 0x18D47E0 Offset: 0x18D39E0 VA: 0x1818D47E0
	public bool get_hasElements() { }

	// RVA: 0x18D46A0 Offset: 0x18D38A0 VA: 0x1818D46A0
	public int get_elementCount() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_elementCapacity();

	// RVA: 0x18D4730 Offset: 0x18D3930 VA: 0x1818D4730
	public ControllerElementIdentifier get_elementIdentifier() { }

	// RVA: 0x18D44A0 Offset: 0x18D36A0 VA: 0x1818D44A0
	internal void .ctor(Controller , int , string , CompoundControllerElementType ) { }

	// RVA: 0x18D42A0 Offset: 0x18D34A0 VA: 0x1818D42A0
	internal Controller.Element RnACvZlSzBBziMYJDRxiKAYAOKGL(int ) { }

	// RVA: -1 Offset: -1
	internal  RnACvZlSzBBziMYJDRxiKAYAOKGL<>(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC8200 Offset: 0xAC7400 VA: 0x180AC8200
	|-Controller.CompoundElement.RnACvZlSzBBziMYJDRxiKAYAOKGL<object>
	*/

	// RVA: -1 Offset: -1
	internal  TQoNkQaXZKoeUTBOiFRDdGLrTVbb<>(int , out int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC82F0 Offset: 0xAC74F0 VA: 0x180AC82F0
	|-Controller.CompoundElement.TQoNkQaXZKoeUTBOiFRDdGLrTVbb<object>
	*/

	// RVA: 0x18D4A30 Offset: 0x18D3C30 VA: 0x1818D4A30
	internal bool lAgTkkmrmCYHzLIplmpAFCsdJbIF(Controller.Element , int ) { }

	// RVA: 0x18D41D0 Offset: 0x18D33D0 VA: 0x1818D41D0
	internal bool HAecvEBOWFGsyAZkGxhZWqcdwJbeA(Controller.Element ) { }

	// RVA: 0x18D40C0 Offset: 0x18D32C0 VA: 0x1818D40C0
	internal void DztGUTGwrrEdNhBkClBllOVMZEZC() { }

	// RVA: 0x18D42F0 Offset: 0x18D34F0 VA: 0x1818D42F0
	private int SOyEZlaOZnmtToqrBQwaSSVmHYjYA(Controller.Element ) { }

	// RVA: 0x18D4360 Offset: 0x18D3560 VA: 0x1818D4360
	private bool UETFzegjFOqGpMKRFfZCmUhrolPlA(Controller.Element , int , int ) { }

	// RVA: 0x18D45A0 Offset: 0x18D37A0 VA: 0x1818D45A0
	private bool dsriWnGEzcEEKvlTrYssEOFUMcpq(int ) { }

	// RVA: 0x18D4CC0 Offset: 0x18D3EC0 VA: 0x1818D4CC0
	private int sgoUVtkYKWIxSFEZjXpaMBZlEOSw() { }
}

// Namespace: 
public sealed class Controller.Axis2D : Controller.CompoundElement // TypeDefIndex: 6759
{
	// Fields
	private const int TCOexgTmYJSbNGIpcOjoPrXaBNgD = 2;
	private CalibrationMap gRyWggvuTLiOxTlPfTGDiIAFFAZeA; // 0x40

	// Properties
	public override int elementCapacity { get; }
	public Controller.Axis xAxis { get; }
	public Controller.Axis yAxis { get; }
	public Vector2 value { get; }
	public Vector2 valuePrev { get; }
	public Vector2 valueRaw { get; }
	public Vector2 valueRawPrev { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public override int get_elementCapacity() { }

	// RVA: 0x18CF280 Offset: 0x18CE480 VA: 0x1818CF280
	public Controller.Axis get_xAxis() { }

	// RVA: 0x18CF320 Offset: 0x18CE520 VA: 0x1818CF320
	public Controller.Axis get_yAxis() { }

	// RVA: 0x18CF1B0 Offset: 0x18CE3B0 VA: 0x1818CF1B0
	public Vector2 get_value() { }

	// RVA: 0x18CED40 Offset: 0x18CDF40 VA: 0x1818CED40
	public Vector2 get_valuePrev() { }

	// RVA: 0x18CEFE0 Offset: 0x18CE1E0 VA: 0x1818CEFE0
	public Vector2 get_valueRaw() { }

	// RVA: 0x18CEE10 Offset: 0x18CE010 VA: 0x1818CEE10
	public Vector2 get_valueRawPrev() { }

	// RVA: 0x18CEA30 Offset: 0x18CDC30 VA: 0x1818CEA30
	internal void .ctor(Controller , int , string , Controller.Axis , Controller.Axis , int , int , CalibrationMap ) { }

	// RVA: 0x18CECB0 Offset: 0x18CDEB0 VA: 0x1818CECB0
	internal void eONGtYwbwtDdzfuKTLHYrUwrDqDB() { }

	// RVA: 0x18CF3C0 Offset: 0x18CE5C0 VA: 0x1818CF3C0
	private Vector2 lzLnsOSukCpvoEItdbHMaegjnWRGb() { }

	// RVA: 0x18CEA90 Offset: 0x18CDC90 VA: 0x1818CEA90
	private Vector2 beoaGlJEoyXbQqsvapsgEDZvmliEA() { }
}

// Namespace: 
public sealed class Controller.Hat : Controller.CompoundElement // TypeDefIndex: 6760
{
	// Fields
	private const int TCOexgTmYJSbNGIpcOjoPrXaBNgD = 8;
	private const int uZQqUDvuuELOqcGkzDzpbgztbGHu = 0;
	private const int LyQIDyKYmiqzbcnAPnfeYNeBGhwu = 1;
	private const int eLBjEVaiJdZxmMBaxCefftoWsokg = 2;
	private const int XqHfJkjoQRCFyrNNjQzPABkwofEcb = 3;
	private const int cJlXGyOTtelYPvlWhFZDXyQzHoWc = 4;
	private const int qrvjhFatoVHrndNbCUBQJdKidRclA = 5;
	private const int uwBAetyooHfXkngtLkCvqMiEcWMB = 6;
	private const int RxrYIYdKQxugDZomwQirlnXBPVes = 7;
	private readonly int obpSlkOZGAMliMndpbbCzYkVINIv; // 0x40
	private readonly Controller.Button[] qCcRvKGVZggEJuRPOApCjfkkjLFN; // 0x48
	private readonly ReadOnlyCollection<Controller.Button> TwgICQHvdqsSGpBgxiHBOsIbwbrd; // 0x50
	private readonly int[] UrRVneGHhiqrKvjUAEtFFSqVnFBAb; // 0x58
	private bool gPSWRhIJccwNxxYeEKxYuqjWNNoG; // 0x60

	// Properties
	public override int elementCapacity { get; }
	public bool force4Way { get; set; }
	public int directionCount { get; }
	public IList<Controller.Button> Buttons { get; }
	public Controller.Button buttonUp { get; }
	public Controller.Button buttonRight { get; }
	public Controller.Button buttonDown { get; }
	public Controller.Button buttonLeft { get; }
	public Controller.Button buttonUpRight { get; }
	public Controller.Button buttonDownRight { get; }
	public Controller.Button buttonDownLeft { get; }
	public Controller.Button buttonUpLeft { get; }

	// Methods

	// RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0 Slot: 4
	public override int get_elementCapacity() { }

	// RVA: 0x18E32A0 Offset: 0x18E24A0 VA: 0x1818E32A0
	public bool get_force4Way() { }

	// RVA: 0x18E3330 Offset: 0x18E2530 VA: 0x1818E3330
	public void set_force4Way(bool value) { }

	// RVA: 0x18E3210 Offset: 0x18E2410 VA: 0x1818E3210
	public int get_directionCount() { }

	// RVA: 0x18E2C70 Offset: 0x18E1E70 VA: 0x1818E2C70
	public IList<Controller.Button> get_Buttons() { }

	// RVA: 0x18E3170 Offset: 0x18E2370 VA: 0x1818E3170
	public Controller.Button get_buttonUp() { }

	// RVA: 0x18E2F90 Offset: 0x18E2190 VA: 0x1818E2F90
	public Controller.Button get_buttonRight() { }

	// RVA: 0x18E2E50 Offset: 0x18E2050 VA: 0x1818E2E50
	public Controller.Button get_buttonDown() { }

	// RVA: 0x18E2EF0 Offset: 0x18E20F0 VA: 0x1818E2EF0
	public Controller.Button get_buttonLeft() { }

	// RVA: 0x18E30D0 Offset: 0x18E22D0 VA: 0x1818E30D0
	public Controller.Button get_buttonUpRight() { }

	// RVA: 0x18E2DB0 Offset: 0x18E1FB0 VA: 0x1818E2DB0
	public Controller.Button get_buttonDownRight() { }

	// RVA: 0x18E2D10 Offset: 0x18E1F10 VA: 0x1818E2D10
	public Controller.Button get_buttonDownLeft() { }

	// RVA: 0x18E3030 Offset: 0x18E2230 VA: 0x1818E3030
	public Controller.Button get_buttonUpLeft() { }

	// RVA: 0x18E24E0 Offset: 0x18E16E0 VA: 0x1818E24E0
	internal void .ctor(Controller , int , string , Controller.Button[] , int[] ) { }

	// RVA: 0x18E26F0 Offset: 0x18E18F0 VA: 0x1818E26F0
	internal void eONGtYwbwtDdzfuKTLHYrUwrDqDB(UpdateLoopType , ControllerDataUpdater ) { }

	// RVA: 0x18E2350 Offset: 0x18E1550 VA: 0x1818E2350
	private void VfYjItqTOyYWqVDzDGYrZSpeDbAe(Controller.Button , int , int , int , UpdateLoopType , ControllerDataUpdater ) { }

	// RVA: 0x18E22A0 Offset: 0x18E14A0 VA: 0x1818E22A0
	private void ItEivxmWfZBpufLDbEaPTSlSdwte(Controller.Button , int , UpdateLoopType , ControllerDataUpdater ) { }
}

// Namespace: 
public sealed class Controller.DirectionalPad : Controller.CompoundElement // TypeDefIndex: 6761
{
	// Fields
	private const int TCOexgTmYJSbNGIpcOjoPrXaBNgD = 4;
	private const int uZQqUDvuuELOqcGkzDzpbgztbGHu = 0;
	private const int eLBjEVaiJdZxmMBaxCefftoWsokg = 1;
	private const int cJlXGyOTtelYPvlWhFZDXyQzHoWc = 2;
	private const int uwBAetyooHfXkngtLkCvqMiEcWMB = 3;
	private readonly int obpSlkOZGAMliMndpbbCzYkVINIv; // 0x40
	private readonly Controller.Button[] qCcRvKGVZggEJuRPOApCjfkkjLFN; // 0x48
	private readonly ReadOnlyCollection<Controller.Button> TwgICQHvdqsSGpBgxiHBOsIbwbrd; // 0x50
	private readonly int[] UrRVneGHhiqrKvjUAEtFFSqVnFBAb; // 0x58

	// Properties
	public override int elementCapacity { get; }
	public IList<Controller.Button> Buttons { get; }
	public Controller.Button buttonUp { get; }
	public Controller.Button buttonRight { get; }
	public Controller.Button buttonDown { get; }
	public Controller.Button buttonLeft { get; }

	// Methods

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 4
	public override int get_elementCapacity() { }

	// RVA: 0x18E1590 Offset: 0x18E0790 VA: 0x1818E1590
	public IList<Controller.Button> get_Buttons() { }

	// RVA: 0x18E1810 Offset: 0x18E0A10 VA: 0x1818E1810
	public Controller.Button get_buttonUp() { }

	// RVA: 0x18E1770 Offset: 0x18E0970 VA: 0x1818E1770
	public Controller.Button get_buttonRight() { }

	// RVA: 0x18E1630 Offset: 0x18E0830 VA: 0x1818E1630
	public Controller.Button get_buttonDown() { }

	// RVA: 0x18E16D0 Offset: 0x18E08D0 VA: 0x1818E16D0
	public Controller.Button get_buttonLeft() { }

	// RVA: 0x18E12C0 Offset: 0x18E04C0 VA: 0x1818E12C0
	internal void .ctor(Controller , int , string , Controller.Button[] , int[] ) { }

	// RVA: 0x18E14C0 Offset: 0x18E06C0 VA: 0x1818E14C0
	internal void eONGtYwbwtDdzfuKTLHYrUwrDqDB(UpdateLoopType , ControllerDataUpdater ) { }
}

// Namespace: 
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public abstract class Controller.Extension // TypeDefIndex: 6762
{
	// Fields
	private Controller MjXwpaWgoFbhLALGDhNxlBElkuGl; // 0x10
	private IControllerExtensionSource SDwzWAaQayKsUsCLxvZirfQfmcnS; // 0x18
	internal readonly int _reInputId; // 0x20

	// Properties
	internal bool isJoystickConnected { get; }
	internal bool enabled { get; }
	public Controller controller { get; }

	// Methods

	// RVA: 0x18E1E70 Offset: 0x18E1070 VA: 0x1818E1E70
	internal bool get_isJoystickConnected() { }

	// RVA: 0x18E1E50 Offset: 0x18E1050 VA: 0x1818E1E50
	internal bool get_enabled() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Controller get_controller() { }

	// RVA: 0x18E1D90 Offset: 0x18E0F90 VA: 0x1818E1D90
	internal void .ctor(IControllerExtensionSource ) { }

	// RVA: 0x18E1CB0 Offset: 0x18E0EB0 VA: 0x1818E1CB0
	internal void .ctor(Controller.Extension ) { }

	// RVA: -1 Offset: -1
	internal T GetController<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACCA10 Offset: 0xACBC10 VA: 0x180ACCA10
	|-Controller.Extension.GetController<object>
	*/

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void SetController(Controller controller) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal IControllerExtensionSource GetSource() { }

	// RVA: 0x18E1C80 Offset: 0x18E0E80 VA: 0x1818E1C80
	internal void SetSource(Controller.Extension extension) { }

	// RVA: 0x18E1E90 Offset: 0x18E1090 VA: 0x1818E1E90
	private void ksGxGcbFgLJbdUwDMewWPnzWJAAD(IControllerExtensionSource ) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	internal virtual void Clear() { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void SourceUpdated(IControllerExtensionSource source);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract void UpdateData(UpdateLoopType updateLoop);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract Controller.Extension Clone();
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Controller.VzjDycbrQLfFNVTLDyMdlJiZjtGkA // TypeDefIndex: 6763
{
	// Fields
	public static readonly Controller.VzjDycbrQLfFNVTLDyMdlJiZjtGkA <>9; // 0x0
	public static Func<Controller, Guid, bool> <>9__166_0; // 0x8
	public static Func<Controller, Type, bool> <>9__169_0; // 0x10

	// Methods

	// RVA: 0x18E7370 Offset: 0x18E6570 VA: 0x1818E7370
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18E7340 Offset: 0x18E6540 VA: 0x1818E7340
	internal bool MskcLxhLNBSMeVEqWrZGxxQpfUbp(Controller , Guid ) { }

	// RVA: 0x18E73D0 Offset: 0x18E65D0 VA: 0x1818E73D0
	internal bool umsOnGSBfBmrZpKeXiRPOieWaDOT(Controller , Type ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Controller.GEUkzoTBxodEGqECIZtDzneVzIiB : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 6764
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Controller nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x60

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18E1EB0 Offset: 0x18E10B0 VA: 0x1818E1EB0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18E21A0 Offset: 0x18E13A0 VA: 0x1818E21A0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18E21E0 Offset: 0x18E13E0 VA: 0x1818E21E0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18E20E0 Offset: 0x18E12E0 VA: 0x1818E20E0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18E20E0 Offset: 0x18E12E0 VA: 0x1818E20E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Controller.MmfCaWIZQQtEiDHJUbsQnXurMwvBA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 6765
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Controller nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x60

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18E6DD0 Offset: 0x18E5FD0 VA: 0x1818E6DD0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18E70C0 Offset: 0x18E62C0 VA: 0x1818E70C0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18E7100 Offset: 0x18E6300 VA: 0x1818E7100 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18E7000 Offset: 0x18E6200 VA: 0x1818E7000 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18E7000 Offset: 0x18E6200 VA: 0x1818E7000 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired
public abstract class Controller // TypeDefIndex: 6766
{
	// Fields
	public readonly int id; // 0x10
	protected string _tag; // 0x18
	protected string _name; // 0x20
	private readonly DeviceLocalizationInfo gDhzIOqcbIAwWxsdDHyTeeoAKNufA; // 0x28
	protected string _hardwareName; // 0x30
	protected readonly ControllerType _type; // 0x38
	internal readonly Guid JOtCZQwEpMYtpSVARfiyfGvXauho; // 0x3C
	protected string _hardwareIdentifier; // 0x50
	protected bool _isConnected; // 0x58
	private Controller.Extension UkNVbtIvrLthdNEqtaxlGsUzkdJNA; // 0x60
	private bool AqHaORMjZGTdLoJMHbRKCeXHvJfRA; // 0x68
	private ControllerIdentifier dfWYVRDPFLnAOiitYtfrlzFNktPy; // 0x70
	internal int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0xA0
	protected readonly int _buttonCount; // 0xA4
	protected readonly Controller.Button[] buttons; // 0xA8
	protected readonly ReadOnlyCollection<Controller.Button> buttons_readOnly; // 0xB0
	private readonly IList<Controller.Element> ZdSpjvRkgdsTMzWPFjtUndkXnkT; // 0xB8
	private readonly ReadOnlyCollection<Controller.Element> pWquskIZiDEOlilKSzVSUWvspUFo; // 0xC0
	private readonly IList<Controller.CompoundElement> uZpJSGakIlsuSAjQCeKpcpCfzvKdA; // 0xC8
	private readonly ReadOnlyCollection<Controller.CompoundElement> OlMQJSoVgKWVsiYGtawQXGhwwFTb; // 0xD0
	[CustomObfuscation(rename = False)]
	internal readonly InputSource inputSource; // 0xD8
	internal readonly ControllerDataUpdater hNGVoqwyjRaslFYsgQhaPzgAavTc; // 0xE0
	internal readonly HardwareControllerMap_Game GvrRKEvhRFQLAyweejKeBxXVLmWt; // 0xE8
	internal uint EnxcEnNEILDJLdgAGxGARsppWeUD; // 0xF0
	private uint QTfPEvHhwCKpyiJxbCEXqkkRAESiA; // 0xF4
	private uint VTpJsztUScEVLcOqQaZliBRWpoQwA; // 0xF8
	private ITryGetLocalizedName lGbcHjIodPFRQHvJpfKlVunkptkgb; // 0x100
	private readonly LocalizedString jboOUzMaWlYmsUjlZgbTGwOzdzuCA; // 0x108
	private readonly xYZRMdGsFrJEudjhPFkBaQKrJYfiA hJCFYDsxmXgKmnCrneLIJQplXKgG; // 0x110
	private Action<bool> IxiFGLWspltmQimVZfZHYWSfCDAfA; // 0x118
	private IControllerTemplate[] tkPTHtYmOdoiOXqrEpwGppRGfaJO; // 0x120
	private ReadOnlyCollection<IControllerTemplate> ddHpjqKvGRhOCbJUVJbSlToiXxqJ; // 0x128
	private static Func<Controller, Guid, bool> IeOEqUTNKQVAPANpfMKCRxTAdPZ; // 0x0
	private static Func<Controller, Type, bool> ZHKbxPgDUnCRaUnXJAlASBVHiHqhA; // 0x8

	// Properties
	internal bool RxBuIZOBAfKIIrHJbIbHeLYGUAiEA { get; }
	public bool enabled { get; set; }
	public string name { get; set; }
	public string tag { get; set; }
	public string hardwareName { get; }
	public ControllerType type { get; }
	public Guid hardwareTypeGuid { get; }
	public abstract Guid deviceInstanceGuid { get; }
	public ControllerIdentifier identifier { get; }
	public bool isConnected { get; set; }
	public string hardwareIdentifier { get; }
	public string mapTypeString { get; }
	public int elementCount { get; }
	public int buttonCount { get; }
	public IList<Controller.Element> Elements { get; }
	public IList<Controller.CompoundElement> CompoundElements { get; }
	public IList<Controller.Button> Buttons { get; }
	public Controller.Extension extension { get; }
	public IList<ControllerElementIdentifier> ElementIdentifiers { get; }
	public IList<ControllerElementIdentifier> ButtonElementIdentifiers { get; }
	internal ITryGetLocalizedName ezjyTNwkHUpaCzedDanhZXkmBexjA { get; set; }
	public IList<IControllerTemplate> Templates { get; }
	public int templateCount { get; }
	internal static Func<Controller, Guid, bool> CzJiKcmTqQMdsDeKghLFbXWijGlCA { get; }
	internal static Func<Controller, Type, bool> aBkbOyFrMQhHBpHVVduSukOJThGgA { get; }

	// Methods

	// RVA: 0x18DF9C0 Offset: 0x18DEBC0 VA: 0x1818DF9C0
	internal bool hZtzBrwDfZAbAfjxRevXyctqkhKXA() { }

	// RVA: 0x18DF060 Offset: 0x18DE260 VA: 0x1818DF060
	public bool get_enabled() { }

	// RVA: 0x18DFAE0 Offset: 0x18DECE0 VA: 0x1818DFAE0
	public void set_enabled(bool value) { }

	// RVA: 0x18DF4F0 Offset: 0x18DE6F0 VA: 0x1818DF4F0
	public string get_name() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void uGSHIPnuNZPbyNhItjkmgCPddCPV(string ) { }

	// RVA: 0x18DF750 Offset: 0x18DE950 VA: 0x1818DF750
	public string get_tag() { }

	// RVA: 0x18DFB00 Offset: 0x18DED00 VA: 0x1818DFB00
	public void set_tag(string value) { }

	// RVA: 0x18DF230 Offset: 0x18DE430 VA: 0x1818DF230
	public string get_hardwareName() { }

	// RVA: 0x18DF8A0 Offset: 0x18DEAA0 VA: 0x1818DF8A0
	public ControllerType get_type() { }

	// RVA: 0x18DF2E0 Offset: 0x18DE4E0 VA: 0x1818DF2E0
	public Guid get_hardwareTypeGuid() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_deviceInstanceGuid();

	// RVA: 0x18DF3B0 Offset: 0x18DE5B0 VA: 0x1818DF3B0
	public ControllerIdentifier get_identifier() { }

	// RVA: 0x18DF3E0 Offset: 0x18DE5E0 VA: 0x1818DF3E0
	public bool get_isConnected() { }

	// RVA: 0x18DE800 Offset: 0x18DDA00 VA: 0x1818DE800
	internal void dOWvfKBNYlNSjtebYDRoVHGxFIMeA(bool ) { }

	// RVA: 0x18DF180 Offset: 0x18DE380 VA: 0x1818DF180
	public string get_hardwareIdentifier() { }

	// RVA: 0x18DF470 Offset: 0x18DE670 VA: 0x1818DF470
	public string get_mapTypeString() { }

	// RVA: 0x18DEFB0 Offset: 0x18DE1B0 VA: 0x1818DEFB0
	public int get_elementCount() { }

	// RVA: 0x18DEF20 Offset: 0x18DE120 VA: 0x1818DEF20
	public int get_buttonCount() { }

	// RVA: 0x18DEDE0 Offset: 0x18DDFE0 VA: 0x1818DEDE0
	public IList<Controller.Element> get_Elements() { }

	// RVA: 0x18DEC90 Offset: 0x18DDE90 VA: 0x1818DEC90
	public IList<Controller.CompoundElement> get_CompoundElements() { }

	// RVA: 0x18DEBF0 Offset: 0x18DDDF0 VA: 0x1818DEBF0
	public IList<Controller.Button> get_Buttons() { }

	// RVA: 0x18DF0F0 Offset: 0x18DE2F0 VA: 0x1818DF0F0
	public Controller.Extension get_extension() { }

	// RVA: 0x18DED30 Offset: 0x18DDF30 VA: 0x1818DED30
	public IList<ControllerElementIdentifier> get_ElementIdentifiers() { }

	// RVA: 0x18DEB40 Offset: 0x18DDD40 VA: 0x1818DEB40
	public IList<ControllerElementIdentifier> get_ButtonElementIdentifiers() { }

	// RVA: 0x7960A0 Offset: 0x7952A0 VA: 0x1807960A0
	internal ITryGetLocalizedName jAydkulnOgWerToWlkuiZzkaAybV() { }

	// RVA: 0x7960F0 Offset: 0x7952F0 VA: 0x1807960F0
	internal void kEDSjJrgfugSfKtadewhBUmjBQusA(ITryGetLocalizedName ) { }

	// RVA: 0x18DCE60 Offset: 0x18DC060 VA: 0x1818DCE60
	internal void JRPFGeMgyapjWAXrJxXoSyYygsTK(Action<bool> ) { }

	// RVA: 0x18DCFF0 Offset: 0x18DC1F0 VA: 0x1818DCFF0
	internal void NvonAVYDcgaShELWvSYKxYSTmbdt(Action<bool> ) { }

	// RVA: 0x18DDA90 Offset: 0x18DCC90 VA: 0x1818DDA90
	internal void .ctor(int , InputSource , string , string , string , ControllerType , Guid , int , bool[] , HardwareButtonInfo[] , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x18DFA80 Offset: 0x18DEC80 VA: 0x1818DFA80 Slot: 5
	internal virtual void nIRUjisQJGnkVcmTpzMHHIDBKnMm() { }

	// RVA: 0x18DBE70 Offset: 0x18DB070 VA: 0x1818DBE70 Slot: 6
	public virtual Controller.Element GetElementById(int elementIdentifierId) { }

	// RVA: 0x18DBCD0 Offset: 0x18DAED0 VA: 0x1818DBCD0 Slot: 7
	public virtual Controller.CompoundElement GetCompoundElementById(int elementIdentifierId) { }

	[Obsolete("This method is deprecated. Use GetCompoundElementById instead.", False)]
	// RVA: 0x18DBE50 Offset: 0x18DB050 VA: 0x1818DBE50 Slot: 8
	public virtual Controller.CompoundElement GetCompundElementById(int elementIdentifierId) { }

	// RVA: 0x18DB0C0 Offset: 0x18DA2C0 VA: 0x1818DB0C0
	public int GetButtonIndexById(int elementIdentifierId) { }

	// RVA: 0x18DBF50 Offset: 0x18DB150 VA: 0x1818DBF50
	public ControllerElementIdentifier GetElementIdentifierById(int elementIdentifierId) { }

	// RVA: 0x18DBC00 Offset: 0x18DAE00 VA: 0x1818DBC00 Slot: 9
	public virtual bool GetButton(int index) { }

	// RVA: 0x18DAFF0 Offset: 0x18DA1F0 VA: 0x1818DAFF0 Slot: 10
	public virtual bool GetButtonDown(int index) { }

	// RVA: 0x18DBB30 Offset: 0x18DAD30 VA: 0x1818DBB30 Slot: 11
	public virtual bool GetButtonUp(int index) { }

	// RVA: 0x18DA710 Offset: 0x18D9910 VA: 0x1818DA710 Slot: 12
	public virtual bool GetButtonChanged(int index) { }

	// RVA: 0x18DB5F0 Offset: 0x18DA7F0 VA: 0x1818DB5F0 Slot: 13
	public virtual bool GetButtonPrev(int index) { }

	// RVA: 0x18DAE50 Offset: 0x18DA050 VA: 0x1818DAE50 Slot: 14
	public virtual bool GetButtonDoublePressHold(int index) { }

	// RVA: 0x18DAD60 Offset: 0x18D9F60 VA: 0x1818DAD60 Slot: 15
	public virtual bool GetButtonDoublePressHold(int index, float speed) { }

	// RVA: 0x18DAAE0 Offset: 0x18D9CE0 VA: 0x1818DAAE0 Slot: 16
	public virtual bool GetButtonDoublePressDown(int index) { }

	// RVA: 0x18DA9F0 Offset: 0x18D9BF0 VA: 0x1818DA9F0 Slot: 17
	public virtual bool GetButtonDoublePressDown(int index, float speed) { }

	// RVA: 0x18DB7B0 Offset: 0x18DA9B0 VA: 0x1818DB7B0 Slot: 18
	public virtual double GetButtonTimePressed(int index) { }

	// RVA: 0x18DB970 Offset: 0x18DAB70 VA: 0x1818DB970 Slot: 19
	public virtual double GetButtonTimeUnpressed(int index) { }

	// RVA: 0x18DB270 Offset: 0x18DA470 VA: 0x1818DB270 Slot: 20
	public virtual double GetButtonLastTimePressed(int index) { }

	// RVA: 0x18DB430 Offset: 0x18DA630 VA: 0x1818DB430 Slot: 21
	public virtual double GetButtonLastTimeUnpressed(int index) { }

	// RVA: 0x18DA520 Offset: 0x18D9720 VA: 0x1818DA520 Slot: 22
	public virtual bool GetAnyButton() { }

	// RVA: 0x18DA220 Offset: 0x18D9420 VA: 0x1818DA220 Slot: 23
	public virtual bool GetAnyButtonDown() { }

	// RVA: 0x18DA420 Offset: 0x18D9620 VA: 0x1818DA420 Slot: 24
	public virtual bool GetAnyButtonUp() { }

	// RVA: 0x18DA320 Offset: 0x18D9520 VA: 0x1818DA320 Slot: 25
	public virtual bool GetAnyButtonPrev() { }

	// RVA: 0x18DA120 Offset: 0x18D9320 VA: 0x1818DA120 Slot: 26
	public virtual bool GetAnyButtonChanged() { }

	// RVA: 0x18DA620 Offset: 0x18D9820 VA: 0x1818DA620 Slot: 27
	public virtual bool GetButtonById(int elementIdentifierId) { }

	// RVA: 0x18DAF00 Offset: 0x18DA100 VA: 0x1818DAF00 Slot: 28
	public virtual bool GetButtonDownById(int elementIdentifierId) { }

	// RVA: 0x18DBA40 Offset: 0x18DAC40 VA: 0x1818DBA40 Slot: 29
	public virtual bool GetButtonUpById(int elementIdentifierId) { }

	// RVA: 0x18DAC60 Offset: 0x18D9E60 VA: 0x1818DAC60 Slot: 30
	public virtual bool GetButtonDoublePressHoldById(int elementIdentifierId, float speed) { }

	// RVA: 0x18DA820 Offset: 0x18D9A20 VA: 0x1818DA820 Slot: 31
	public virtual bool GetButtonDoublePressDownById(int elementIdentifierId, float speed) { }

	// RVA: 0x18DAB90 Offset: 0x18D9D90 VA: 0x1818DAB90 Slot: 32
	public virtual bool GetButtonDoublePressHoldById(int elementIdentifierId) { }

	// RVA: 0x18DA920 Offset: 0x18D9B20 VA: 0x1818DA920 Slot: 33
	public virtual bool GetButtonDoublePressDownById(int elementIdentifierId) { }

	// RVA: 0x18DB500 Offset: 0x18DA700 VA: 0x1818DB500 Slot: 34
	public virtual bool GetButtonPrevById(int elementIdentifierId) { }

	// RVA: 0x18DB6C0 Offset: 0x18DA8C0 VA: 0x1818DB6C0 Slot: 35
	public virtual double GetButtonTimePressedById(int elementIdentifierId) { }

	// RVA: 0x18DB880 Offset: 0x18DAA80 VA: 0x1818DB880 Slot: 36
	public virtual double GetButtonTimeUnpressedById(int elementIdentifierId) { }

	// RVA: 0x18DB180 Offset: 0x18DA380 VA: 0x1818DB180 Slot: 37
	public virtual double GetButtonLastTimePressedById(int elementIdentifierId) { }

	// RVA: 0x18DB340 Offset: 0x18DA540 VA: 0x1818DB340 Slot: 38
	public virtual double GetButtonLastTimeUnpressedById(int elementIdentifierId) { }

	// RVA: 0x18DD610 Offset: 0x18DC810 VA: 0x1818DD610 Slot: 39
	public virtual ControllerPollingInfo PollForFirstElement() { }

	// RVA: 0x18DD5C0 Offset: 0x18DC7C0 VA: 0x1818DD5C0 Slot: 40
	public virtual ControllerPollingInfo PollForFirstElementDown() { }

	// RVA: 0x18DD3B0 Offset: 0x18DC5B0 VA: 0x1818DD3B0 Slot: 41
	public virtual ControllerPollingInfo PollForFirstButton() { }

	// RVA: 0x18DD1A0 Offset: 0x18DC3A0 VA: 0x1818DD1A0 Slot: 42
	public virtual ControllerPollingInfo PollForFirstButtonDown() { }

	// RVA: 0x18D77A0 Offset: 0x18D69A0 VA: 0x1818D77A0 Slot: 43
	public virtual IEnumerable<ControllerPollingInfo> PollForAllElements() { }

	// RVA: 0x17C88F0 Offset: 0x17C7AF0 VA: 0x1817C88F0 Slot: 44
	public virtual IEnumerable<ControllerPollingInfo> PollForAllElementsDown() { }

	// RVA: 0x18DD120 Offset: 0x18DC320 VA: 0x1818DD120 Slot: 45
	public virtual IEnumerable<ControllerPollingInfo> PollForAllButtons() { }

	// RVA: 0x18DD0A0 Offset: 0x18DC2A0 VA: 0x1818DD0A0 Slot: 46
	public virtual IEnumerable<ControllerPollingInfo> PollForAllButtonsDown() { }

	// RVA: 0x18DA040 Offset: 0x18D9240 VA: 0x1818DA040
	private bool EefPDGosMYJheTsSrxsKGJvuXggG(int , out int ) { }

	// RVA: 0x18DCF10 Offset: 0x18DC110 VA: 0x1818DCF10
	private bool KKcwsolErZEdjiaTJLdFqVkhGfSAb(int , out int ) { }

	// RVA: 0x18DD910 Offset: 0x18DCB10 VA: 0x1818DD910
	protected void UpdatePollingFrameTracking() { }

	// RVA: 0x18DC1A0 Offset: 0x18DB3A0 VA: 0x1818DC1A0 Slot: 47
	public virtual double GetLastTimeActive() { }

	// RVA: 0x18DC000 Offset: 0x18DB200 VA: 0x1818DC000 Slot: 48
	public virtual double GetLastTimeActive(bool useRawValues) { }

	// RVA: 0x18DC680 Offset: 0x18DB880 VA: 0x1818DC680 Slot: 49
	public virtual double GetLastTimeAnyElementChanged() { }

	// RVA: 0x18DC5F0 Offset: 0x18DB7F0 VA: 0x1818DC5F0 Slot: 50
	public virtual double GetLastTimeAnyElementChanged(bool useRawValues) { }

	// RVA: 0x18DC4C0 Offset: 0x18DB6C0 VA: 0x1818DC4C0
	public double GetLastTimeAnyButtonPressed() { }

	// RVA: 0x18DC240 Offset: 0x18DB440 VA: 0x1818DC240
	public double GetLastTimeAnyButtonChanged() { }

	// RVA: -1 Offset: -1
	public T GetExtension<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F890 Offset: 0x94EA90 VA: 0x18094F890
	|-Controller.GetExtension<object>
	*/

	// RVA: 0x18DEE80 Offset: 0x18DE080 VA: 0x1818DEE80
	public IList<IControllerTemplate> get_Templates() { }

	// RVA: 0x18DF800 Offset: 0x18DEA00 VA: 0x1818DF800
	public int get_templateCount() { }

	// RVA: 0x18DC870 Offset: 0x18DBA70 VA: 0x1818DC870
	public IControllerTemplate GetTemplate(Guid typeGuid) { }

	// RVA: 0x18DC720 Offset: 0x18DB920 VA: 0x1818DC720
	public IControllerTemplate GetTemplate(Type type) { }

	// RVA: -1 Offset: -1
	public T GetTemplate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F9A0 Offset: 0x94EBA0 VA: 0x18094F9A0
	|-Controller.GetTemplate<object>
	*/

	// RVA: 0x18DCC60 Offset: 0x18DBE60 VA: 0x1818DCC60
	public bool ImplementsTemplate(Guid typeGuid) { }

	// RVA: 0x18DCAD0 Offset: 0x18DBCD0 VA: 0x1818DCAD0
	public bool ImplementsTemplate(Type type) { }

	// RVA: -1 Offset: -1
	public bool ImplementsTemplate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94FBE0 Offset: 0x94EDE0 VA: 0x18094FBE0
	|-Controller.ImplementsTemplate<object>
	*/

	// RVA: 0x18DF930 Offset: 0x18DEB30 VA: 0x1818DF930
	internal void gxvpoDvoIzYlJMSCYiKNrRIGollG(IControllerTemplate[] ) { }

	// RVA: 0x18DE460 Offset: 0x18DD660 VA: 0x1818DE460 Slot: 51
	internal virtual void bEQbpgXPReDNkMuvWNRYrmEakniO(UpdateLoopType ) { }

	// RVA: 0x18DEA20 Offset: 0x18DDC20 VA: 0x1818DEA20 Slot: 52
	internal virtual ButtonStateFlags feiZAZalPguxtYdBYpkXdqkLPkpk(int ) { }

	// RVA: 0x18DE8D0 Offset: 0x18DDAD0 VA: 0x1818DE8D0
	internal void dtsoCPtbCrHcUPtaSXSfoDTCqiGE(Controller.Extension ) { }

	// RVA: 0x18DE770 Offset: 0x18DD970 VA: 0x1818DE770
	internal void dCtyYpHaoKAcSIoVeeJMEEaMPoOeA(Controller.Extension ) { }

	// RVA: 0x18DE970 Offset: 0x18DDB70 VA: 0x1818DE970 Slot: 53
	internal virtual void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x18DE6F0 Offset: 0x18DD8F0 VA: 0x1818DE6F0 Slot: 54
	internal virtual bool bVBdiGZsBixPGwYOsVSchVHJeQqe(bool ) { }

	// RVA: 0x18DD660 Offset: 0x18DC860 VA: 0x1818DD660 Slot: 55
	internal virtual void RgMjfbfnjUjIYdchKvQkeErKkjAnA(ControllerMap ) { }

	// RVA: 0x18DFBA0 Offset: 0x18DEDA0 VA: 0x1818DFBA0 Slot: 56
	internal virtual void tVhAGZVXXuysgVcDzFWAOOuvWioe(ControllerMap , ActionElementMap ) { }

	// RVA: 0x18DE310 Offset: 0x18DD510 VA: 0x1818DE310
	internal bool acNsjUZjcJrvPrufdMlRKPFWeOdr(ActionElementMap , int , out float , out bool ) { }

	// RVA: 0x18DE280 Offset: 0x18DD480 VA: 0x1818DE280
	internal bool acNsjUZjcJrvPrufdMlRKPFWeOdr(ActionElementMap , int , bool , out float ) { }

	// RVA: 0x18DFA20 Offset: 0x18DEC20 VA: 0x1818DFA20
	internal void lAgTkkmrmCYHzLIplmpAFCsdJbIF(Controller.Element ) { }

	// RVA: 0x18DDA30 Offset: 0x18DCC30 VA: 0x1818DDA30
	internal void WMLhUeVgGURuZbhaZaDTVhgxgJae(Controller.CompoundElement ) { }

	// RVA: 0x18DCA80 Offset: 0x18DBC80 VA: 0x1818DCA80 Slot: 57
	internal virtual Guid HxZBpVyQjXkNksjOIufyaeFYPOuW() { }

	// RVA: 0x18D9E80 Offset: 0x18D9080 VA: 0x1818D9E80 Slot: 58
	internal virtual void BrXJkfHLERFpbScebqEwNAEsBsbv(bool ) { }

	// RVA: 0x18D9F00 Offset: 0x18D9100 VA: 0x1818D9F00 Slot: 59
	protected virtual void Connected() { }

	// RVA: 0x18DA020 Offset: 0x18D9220 VA: 0x1818DA020 Slot: 60
	protected virtual void Disconnected() { }

	// RVA: 0x18D9F10 Offset: 0x18D9110 VA: 0x1818D9F10
	internal static Func<Controller, Guid, bool> DMRCcIfowYxkNmWkdotVnhfjekEA() { }

	// RVA: 0x18DE5E0 Offset: 0x18DD7E0 VA: 0x1818DE5E0
	internal static Func<Controller, Type, bool> bEcFtLKTjleUQuzodVKjxxadcSWo() { }

	[CompilerGenerated]
	// RVA: 0x18DE760 Offset: 0x18DD960 VA: 0x1818DE760
	private void dBTEbVbeHWyguuPXLaGHwFvyPtRjA() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerWithAxes.ZeZcuvbjklhqxsXDEdmoKhkqEXQaA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 6767
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public ControllerWithAxes nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x60

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18E7C90 Offset: 0x18E6E90 VA: 0x1818E7C90 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18E7FC0 Offset: 0x18E71C0 VA: 0x1818E7FC0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18E8000 Offset: 0x18E7200 VA: 0x1818E8000 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18E7F00 Offset: 0x18E7100 VA: 0x1818E7F00 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18E7F00 Offset: 0x18E7100 VA: 0x1818E7F00 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerWithAxes.ZYVfRyGkPgrWNNzbDoybchiovRal : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 6768
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public ControllerWithAxes nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x60

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x18E7B00 Offset: 0x18E6D00 VA: 0x1818E7B00 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18E7550 Offset: 0x18E6750 VA: 0x1818E7550 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x18E7C40 Offset: 0x18E6E40 VA: 0x1818E7C40
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	// RVA: 0x18E7940 Offset: 0x18E6B40 VA: 0x1818E7940
	private void NliQpQwAufCfLWbPmVSuBlrEIiqh() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18E7A50 Offset: 0x18E6C50 VA: 0x1818E7A50 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18E7A90 Offset: 0x18E6C90 VA: 0x1818E7A90 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18E7990 Offset: 0x18E6B90 VA: 0x1818E7990 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18E7990 Offset: 0x18E6B90 VA: 0x1818E7990 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerWithAxes.dfEESxqdwFmxoeSQlBxSpwIxqROI : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 6769
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public ControllerWithAxes nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x60

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x18E8620 Offset: 0x18E7820 VA: 0x1818E8620 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18E8070 Offset: 0x18E7270 VA: 0x1818E8070 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x18E8760 Offset: 0x18E7960 VA: 0x1818E8760
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	// RVA: 0x18E8460 Offset: 0x18E7660 VA: 0x1818E8460
	private void NliQpQwAufCfLWbPmVSuBlrEIiqh() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18E8570 Offset: 0x18E7770 VA: 0x1818E8570 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18E85B0 Offset: 0x18E77B0 VA: 0x1818E85B0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18E84B0 Offset: 0x18E76B0 VA: 0x1818E84B0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18E84B0 Offset: 0x18E76B0 VA: 0x1818E84B0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired
public abstract class ControllerWithAxes : ControllerWithMap // TypeDefIndex: 6770
{
	// Fields
	protected readonly int _axisCount; // 0x130
	protected readonly int _axis2DCount; // 0x134
	protected readonly Controller.Axis[] axes; // 0x138
	protected readonly ReadOnlyCollection<Controller.Axis> axes_readOnly; // 0x140
	protected readonly Controller.Axis2D[] axes2D; // 0x148
	protected readonly ReadOnlyCollection<Controller.Axis2D> axes2D_readOnly; // 0x150
	protected readonly CalibrationMap _calibrationMap; // 0x158
	private float[] rfnkHvZPZNsMzrLGQslHBPHcUzVH; // 0x160
	private uint EiHFMwczjxuxMAigHNDDfTSqVgBi; // 0x168
	private Func<int, int> RHOxdXlCWokvHEZYJkBfGsEBGryG; // 0x170

	// Properties
	public int axisCount { get; }
	public int axis2DCount { get; }
	public IList<Controller.Axis> Axes { get; }
	public IList<Controller.Axis2D> Axes2D { get; }
	public CalibrationMap calibrationMap { get; }
	public IList<ControllerElementIdentifier> AxisElementIdentifiers { get; }

	// Methods

	// RVA: 0x18D9B80 Offset: 0x18D8D80 VA: 0x1818D9B80
	public int get_axisCount() { }

	// RVA: 0x18D9AF0 Offset: 0x18D8CF0 VA: 0x1818D9AF0
	public int get_axis2DCount() { }

	// RVA: 0x18D9990 Offset: 0x18D8B90 VA: 0x1818D9990
	public IList<Controller.Axis> get_Axes() { }

	// RVA: 0x18D98F0 Offset: 0x18D8AF0 VA: 0x1818D98F0
	public IList<Controller.Axis2D> get_Axes2D() { }

	// RVA: 0x18D9C10 Offset: 0x18D8E10 VA: 0x1818D9C10
	public CalibrationMap get_calibrationMap() { }

	// RVA: 0x18D9A30 Offset: 0x18D8C30 VA: 0x1818D9A30
	public IList<ControllerElementIdentifier> get_AxisElementIdentifiers() { }

	// RVA: 0x18D82A0 Offset: 0x18D74A0 VA: 0x1818D82A0
	internal void .ctor(int , InputSource , string , string , string , ControllerType , Guid , int , int , bool[] , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x18D6870 Offset: 0x18D5A70 VA: 0x1818D6870 Slot: 6
	public override Controller.Element GetElementById(int elementIdentifierId) { }

	// RVA: 0x18D53A0 Offset: 0x18D45A0 VA: 0x1818D53A0
	public int GetAxisIndexById(int elementIdentifierId) { }

	// RVA: 0x18D67A0 Offset: 0x18D59A0 VA: 0x1818D67A0
	public float GetAxis(int index) { }

	// RVA: 0x18D58D0 Offset: 0x18D4AD0 VA: 0x1818D58D0
	public float GetAxisPrev(int index) { }

	// RVA: 0x18D6350 Offset: 0x18D5550 VA: 0x1818D6350
	public float GetAxisRaw(int index) { }

	// RVA: 0x18D5F00 Offset: 0x18D5100 VA: 0x1818D5F00
	public float GetAxisRawPrev(int index) { }

	// RVA: 0x18D6510 Offset: 0x18D5710 VA: 0x1818D6510
	public double GetAxisTimeActive(int index) { }

	// RVA: 0x18D66D0 Offset: 0x18D58D0 VA: 0x1818D66D0
	public double GetAxisTimeInactive(int index) { }

	// RVA: 0x18D5550 Offset: 0x18D4750 VA: 0x1818D5550
	public double GetAxisLastTimeActive(int index) { }

	// RVA: 0x18D5710 Offset: 0x18D4910 VA: 0x1818D5710
	public double GetAxisLastTimeInactive(int index) { }

	// RVA: 0x18D60C0 Offset: 0x18D52C0 VA: 0x1818D60C0
	public double GetAxisRawTimeActive(int index) { }

	// RVA: 0x18D6280 Offset: 0x18D5480 VA: 0x1818D6280
	public double GetAxisRawTimeInactive(int index) { }

	// RVA: 0x18D5B80 Offset: 0x18D4D80 VA: 0x1818D5B80
	public double GetAxisRawLastTimeActive(int index) { }

	// RVA: 0x18D5D40 Offset: 0x18D4F40 VA: 0x1818D5D40
	public double GetAxisRawLastTimeInactive(int index) { }

	// RVA: 0x18D52B0 Offset: 0x18D44B0 VA: 0x1818D52B0
	public float GetAxisById(int elementIdentifierId) { }

	// RVA: 0x18D57E0 Offset: 0x18D49E0 VA: 0x1818D57E0
	public float GetAxisPrevById(int elementIdentifierId) { }

	// RVA: 0x18D59A0 Offset: 0x18D4BA0 VA: 0x1818D59A0
	public float GetAxisRawById(int elementIdentifierId) { }

	// RVA: 0x18D5E10 Offset: 0x18D5010 VA: 0x1818D5E10
	public float GetAxisRawPrevById(int elementIdentifierId) { }

	// RVA: 0x18D6420 Offset: 0x18D5620 VA: 0x1818D6420
	public double GetAxisTimeActiveById(int elementIdentifierId) { }

	// RVA: 0x18D65E0 Offset: 0x18D57E0 VA: 0x1818D65E0
	public double GetAxisTimeInactiveById(int elementIdentifierId) { }

	// RVA: 0x18D5460 Offset: 0x18D4660 VA: 0x1818D5460
	public double GetAxisLastTimeActiveById(int elementIdentifierId) { }

	// RVA: 0x18D5620 Offset: 0x18D4820 VA: 0x1818D5620
	public double GetAxisLastTimeInactiveById(int elementIdentifierId) { }

	// RVA: 0x18D5FD0 Offset: 0x18D51D0 VA: 0x1818D5FD0
	public double GetAxisRawTimeActiveById(int elementIdentifierId) { }

	// RVA: 0x18D6190 Offset: 0x18D5390 VA: 0x1818D6190
	public double GetAxisRawTimeInactiveById(int elementIdentifierId) { }

	// RVA: 0x18D5A90 Offset: 0x18D4C90 VA: 0x1818D5A90
	public double GetAxisRawLastTimeActiveById(int elementIdentifierId) { }

	// RVA: 0x18D5C50 Offset: 0x18D4E50 VA: 0x1818D5C50
	public double GetAxisRawLastTimeInactiveById(int elementIdentifierId) { }

	// RVA: 0x18D5180 Offset: 0x18D4380 VA: 0x1818D5180
	public Vector2 GetAxis2D(int index) { }

	// RVA: 0x18D4D20 Offset: 0x18D3F20 VA: 0x1818D4D20
	public Vector2 GetAxis2DPrev(int index) { }

	// RVA: 0x18D5050 Offset: 0x18D4250 VA: 0x1818D5050
	public Vector2 GetAxis2DRaw(int index) { }

	// RVA: 0x18D4F20 Offset: 0x18D4120 VA: 0x1818D4F20
	public Vector2 GetAxis2DRawPrev(int index) { }

	// RVA: 0x18D6C50 Offset: 0x18D5E50 VA: 0x1818D6C50 Slot: 47
	public override double GetLastTimeActive() { }

	// RVA: 0x18D6A20 Offset: 0x18D5C20 VA: 0x1818D6A20 Slot: 48
	public override double GetLastTimeActive(bool useRawValues) { }

	// RVA: 0x18D7140 Offset: 0x18D6340 VA: 0x1818D7140 Slot: 49
	public override double GetLastTimeAnyElementChanged() { }

	// RVA: 0x18D6FF0 Offset: 0x18D61F0 VA: 0x1818D6FF0 Slot: 50
	public override double GetLastTimeAnyElementChanged(bool useRawValues) { }

	// RVA: 0x18D6E60 Offset: 0x18D6060 VA: 0x1818D6E60
	public double GetLastTimeAnyAxisActive() { }

	// RVA: 0x18D6CF0 Offset: 0x18D5EF0 VA: 0x1818D6CF0
	public double GetLastTimeAnyAxisActive(bool useRawValues) { }

	// RVA: 0x18D6E70 Offset: 0x18D6070 VA: 0x1818D6E70
	public double GetLastTimeAnyAxisChanged() { }

	// RVA: 0x18D6E80 Offset: 0x18D6080 VA: 0x1818D6E80
	public double GetLastTimeAnyAxisChanged(bool useRawValues) { }

	// RVA: 0x18D7CB0 Offset: 0x18D6EB0 VA: 0x1818D7CB0 Slot: 39
	public override ControllerPollingInfo PollForFirstElement() { }

	// RVA: 0x18D7B90 Offset: 0x18D6D90 VA: 0x1818D7B90 Slot: 40
	public override ControllerPollingInfo PollForFirstElementDown() { }

	// RVA: 0x18D7940 Offset: 0x18D6B40 VA: 0x1818D7940
	public ControllerPollingInfo PollForFirstAxis() { }

	// RVA: 0x18D78C0 Offset: 0x18D6AC0 VA: 0x1818D78C0 Slot: 43
	public override IEnumerable<ControllerPollingInfo> PollForAllElements() { }

	// RVA: 0x18D7840 Offset: 0x18D6A40 VA: 0x1818D7840 Slot: 44
	public override IEnumerable<ControllerPollingInfo> PollForAllElementsDown() { }

	// RVA: 0x18D77C0 Offset: 0x18D69C0 VA: 0x1818D77C0
	public IEnumerable<ControllerPollingInfo> PollForAllAxes() { }

	// RVA: 0x18D8100 Offset: 0x18D7300 VA: 0x1818D8100
	private void UShVAnFltpdBZHdeUOokQkIttKncA() { }

	// RVA: 0x18D7490 Offset: 0x18D6690 VA: 0x1818D7490 Slot: 61
	protected virtual bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId) { }

	// RVA: 0x18D73D0 Offset: 0x18D65D0 VA: 0x1818D73D0
	public bool ImportCalibrationMapFromXmlString(string xmlString) { }

	// RVA: 0x18D7310 Offset: 0x18D6510 VA: 0x1818D7310
	public bool ImportCalibrationMapFromJsonString(string jsonString) { }

	// RVA: 0x18D8EB0 Offset: 0x18D80B0 VA: 0x1818D8EB0 Slot: 51
	internal override void bEQbpgXPReDNkMuvWNRYrmEakniO(UpdateLoopType ) { }

	// RVA: 0x18D7160 Offset: 0x18D6360 VA: 0x1818D7160
	internal bool IcZGQfDosgPvmawBndowYHyVjgqAb(ActionElementMap , int , bool , bool , out float ) { }

	// RVA: 0x18D7DD0 Offset: 0x18D6FD0 VA: 0x1818D7DD0 Slot: 55
	internal override void RgMjfbfnjUjIYdchKvQkeErKkjAnA(ControllerMap ) { }

	// RVA: 0x18D9D80 Offset: 0x18D8F80 VA: 0x1818D9D80 Slot: 56
	internal override void tVhAGZVXXuysgVcDzFWAOOuvWioe(ControllerMap , ActionElementMap ) { }

	// RVA: 0x18D95B0 Offset: 0x18D87B0 VA: 0x1818D95B0
	internal void cspsLSEhfgPKdCpvbJoBEhHtEYMg() { }

	// RVA: 0x18D97E0 Offset: 0x18D89E0 VA: 0x1818D97E0 Slot: 53
	internal override void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	[CompilerGenerated]
	// RVA: 0x18D9CA0 Offset: 0x18D8EA0 VA: 0x1818D9CA0
	private int htewCpLapIpZFQWjwEWcXEynPBmu(int ) { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x18D77A0 Offset: 0x18D69A0 VA: 0x1818D77A0
	private IEnumerable<ControllerPollingInfo> PnMosMJCrGOUcFOILvclXtNcvbem() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x17C88F0 Offset: 0x17C7AF0 VA: 0x1817C88F0
	private IEnumerable<ControllerPollingInfo> UhSmNPTQLinwgIhzileKXlsycjrQ() { }
}

// Namespace: Rewired
public abstract class ControllerWithMap : Controller // TypeDefIndex: 6771
{
	// Methods

	// RVA: 0x18D9DD0 Offset: 0x18D8FD0 VA: 0x1818D9DD0
	internal void .ctor(int , InputSource , string , string , string , ControllerType , Guid , int , bool[] , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }
}

// Namespace: Rewired
public sealed class CustomController : ControllerWithAxes // TypeDefIndex: 6772
{
	// Fields
	private int WNlEuDeNBTQbjhsTdxaxQPDhtnlab; // 0x178
	private Func<int, float> blxXWhXaqLQCrKInCFCpotKPQiAu; // 0x180
	private Func<int, bool> LXPqbgkvXWbVEWewZNHPFeJWMHBO; // 0x188
	private bool CLahRYhtQSkxkjRVMzSAeWWNwegE; // 0x190
	private Guid UHECCnnILQoILQTtYbKJcpQGYqoo; // 0x194

	// Properties
	public int sourceControllerId { get; }
	public override Guid deviceInstanceGuid { get; }

	// Methods

	// RVA: 0x18E12B0 Offset: 0x18E04B0 VA: 0x1818E12B0
	public int get_sourceControllerId() { }

	// RVA: 0x18E11E0 Offset: 0x18E03E0 VA: 0x1818E11E0 Slot: 4
	public override Guid get_deviceInstanceGuid() { }

	// RVA: 0x18E0D90 Offset: 0x18DFF90 VA: 0x1818E0D90
	internal void .ctor(hLADcALOrVCJyFwWInyzhsJNNlIW ) { }

	// RVA: 0x18E1030 Offset: 0x18E0230 VA: 0x1818E1030
	private void .ctor(int , int , Guid , InputSource , string , string , string , int , int , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x18E0C60 Offset: 0x18DFE60 VA: 0x1818E0C60
	internal void ZwBvtrPADbVUfDEDRwwhVnBandVJ() { }

	// RVA: 0x18E0680 Offset: 0x18DF880 VA: 0x1818E0680
	public void SetAxisValue(int index, float value) { }

	// RVA: 0x18E0500 Offset: 0x18DF700 VA: 0x1818E0500
	public void SetAxisValue(string elementName, float value) { }

	// RVA: 0x18E03B0 Offset: 0x18DF5B0 VA: 0x1818E03B0
	public void SetAxisValueById(int elementId, float value) { }

	// RVA: 0x18E09B0 Offset: 0x18DFBB0 VA: 0x1818E09B0
	public void SetButtonValue(int index, bool value) { }

	// RVA: 0x18E0AE0 Offset: 0x18DFCE0 VA: 0x1818E0AE0
	public void SetButtonValue(string elementName, bool value) { }

	// RVA: 0x18E0860 Offset: 0x18DFA60 VA: 0x1818E0860
	public void SetButtonValueById(int elementId, bool value) { }

	// RVA: 0x18E0300 Offset: 0x18DF500 VA: 0x1818E0300
	public void SetAxisUpdateCallback(Func<int, float> callback) { }

	// RVA: 0x18E07B0 Offset: 0x18DF9B0 VA: 0x1818E07B0
	public void SetButtonUpdateCallback(Func<int, bool> callback) { }

	// RVA: 0x18DFCD0 Offset: 0x18DEED0 VA: 0x1818DFCD0
	public void ClearAxisValue(int index) { }

	// RVA: 0x18DFE20 Offset: 0x18DF020 VA: 0x1818DFE20
	public void ClearAxisValue(string elementName) { }

	// RVA: 0x18DFBC0 Offset: 0x18DEDC0 VA: 0x1818DFBC0
	public void ClearAxisValueById(int elementId) { }

	// RVA: 0x18E01B0 Offset: 0x18DF3B0 VA: 0x1818E01B0
	public void ClearButtonValue(int index) { }

	// RVA: 0x18E0070 Offset: 0x18DF270 VA: 0x1818E0070
	public void ClearButtonValue(string elementName) { }

	// RVA: 0x18DFF60 Offset: 0x18DF160 VA: 0x1818DFF60
	public void ClearButtonValueById(int elementId) { }
}

// Namespace: Rewired
public class Joystick : ControllerWithAxes // TypeDefIndex: 6773
{
	// Fields
	private const int yTbBEXkguIMsgcjPFOFXBeahouhEd = 0;
	private const int LOWjOcjKSHIkaQoerMkMmusMlzZM = 1;
	private IInputManagerJoystickPublic imneTkACsUAJjRPwdVHQDVkRtflH; // 0x178
	private readonly JoystickType[] zlZeIYRFLIQVJbuZFjpobiHuzIcp; // 0x180
	private readonly ReadOnlyCollection<JoystickType> KdAfHUGcGKzhzUKquzZcTYPGewlfb; // 0x188
	private readonly bool sdzISjHiUOikyuyAgPwgWzGuiBDi; // 0x190
	private readonly bool SDmfduJtDddfdNifwfhXFBrixMIcb; // 0x191
	private readonly bool BfCVZpquJaSaoGTueJZaOwHIeekQ; // 0x192
	private readonly int fWgmpuzVwoSWXOFdXQpJmzZMdCdg; // 0x194
	private readonly float[] ItMCiHCMZlUIKVIDvWnXOJSOwNWDA; // 0x198
	private readonly TimerAbs[] WIRktsdnnsOlpchtNbvahcyiubnX; // 0x1A0
	private readonly int PtpkEYJSaoRzEWDderRhgtfErati; // 0x1A8
	private readonly Controller.Hat[] RuOdsnTktewLQYyCkKoiwOioSGmH; // 0x1B0
	private readonly ReadOnlyCollection<Controller.Hat> lYDiwspcFWeYregtqyrrEcsqMwyIA; // 0x1B8
	private readonly int JAuicAYLhYpDZQgUUvlTWedJbUOR; // 0x1C0
	private readonly Controller.DirectionalPad[] JkYeRpBEKyppMxlCfZsiPRPKkqlbb; // 0x1C8
	private readonly ReadOnlyCollection<Controller.DirectionalPad> smGcsTEkrplhdaPhsrDXOHEgTHqK; // 0x1D0

	// Properties
	internal IList<JoystickType> TMMRmjLZxPuCWwZKDAQuDmfqCAvdA { get; }
	public Nullable<long> systemId { get; }
	public int unityId { get; }
	public override Guid deviceInstanceGuid { get; }
	public bool supportsVibration { get; }
	public float vibrationLeftMotor { get; set; }
	public float vibrationRightMotor { get; set; }
	public int vibrationMotorCount { get; }
	public int hatCount { get; }
	public IList<Controller.Hat> Hats { get; }
	public int directionalPadCount { get; }
	public IList<Controller.DirectionalPad> DirectionalPads { get; }
	internal int ZTzlfprNBzWJNqfVcymWAabFzOQM { get; }
	internal HardwareControllerMapIdentifier jMUOSJfvzZnQhIxzzrLWjgCCLhjk { get; }

	// Methods

	// RVA: 0x18E3BC0 Offset: 0x18E2DC0 VA: 0x1818E3BC0
	internal IList<JoystickType> RKtiVewdeAqZoyYFPxUqKstEYmoD() { }

	// RVA: 0x18E5F90 Offset: 0x18E5190 VA: 0x1818E5F90
	public Nullable<long> get_systemId() { }

	// RVA: 0x18E6100 Offset: 0x18E5300 VA: 0x1818E6100
	public int get_unityId() { }

	// RVA: 0x18E5C80 Offset: 0x18E4E80 VA: 0x1818E5C80 Slot: 4
	public override Guid get_deviceInstanceGuid() { }

	// RVA: 0x18E5F00 Offset: 0x18E5100 VA: 0x1818E5F00
	public bool get_supportsVibration() { }

	// RVA: 0x18E61C0 Offset: 0x18E53C0 VA: 0x1818E61C0
	public float get_vibrationLeftMotor() { }

	// RVA: 0x18E6A60 Offset: 0x18E5C60 VA: 0x1818E6A60
	public void set_vibrationLeftMotor(float value) { }

	// RVA: 0x18E6410 Offset: 0x18E5610 VA: 0x1818E6410
	public float get_vibrationRightMotor() { }

	// RVA: 0x18E6B60 Offset: 0x18E5D60 VA: 0x1818E6B60
	public void set_vibrationRightMotor(float value) { }

	// RVA: 0x18E6310 Offset: 0x18E5510 VA: 0x1818E6310
	public int get_vibrationMotorCount() { }

	// RVA: 0x18E5E70 Offset: 0x18E5070 VA: 0x1818E5E70
	public int get_hatCount() { }

	// RVA: 0x18E5BE0 Offset: 0x18E4DE0 VA: 0x1818E5BE0
	public IList<Controller.Hat> get_Hats() { }

	// RVA: 0x18E5DE0 Offset: 0x18E4FE0 VA: 0x1818E5DE0
	public int get_directionalPadCount() { }

	// RVA: 0x18E5B40 Offset: 0x18E4D40 VA: 0x1818E5B40
	public IList<Controller.DirectionalPad> get_DirectionalPads() { }

	// RVA: 0x18E6560 Offset: 0x18E5760 VA: 0x1818E6560
	internal int isTYUUkbFTnjPdFngeLvyEBSrQIQ() { }

	// RVA: 0x18E67F0 Offset: 0x18E59F0 VA: 0x1818E67F0
	internal HardwareControllerMapIdentifier oCuVTrPHDAOFmZZxJifXDjBwdjDkA() { }

	// RVA: 0x18E4480 Offset: 0x18E3680 VA: 0x1818E4480
	internal void .ctor(BridgedController ) { }

	// RVA: 0x18E4BF0 Offset: 0x18E3DF0 VA: 0x1818E4BF0
	private void .ctor(int , InputSource , string , string , string , Guid , int , int , bool[] , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x18E3AD0 Offset: 0x18E2CD0 VA: 0x1818E3AD0
	internal bool LtTgfJfEgUATUFImCjecktJKpBOjc(JoystickType ) { }

	// RVA: 0x18E3630 Offset: 0x18E2830 VA: 0x1818E3630
	public JoystickCalibrationMapSaveData GetCalibrationMapSaveData() { }

	// RVA: 0x18E4090 Offset: 0x18E3290 VA: 0x1818E4090
	public void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	// RVA: 0x18E3C60 Offset: 0x18E2E60 VA: 0x1818E3C60
	public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration) { }

	// RVA: 0x18E4070 Offset: 0x18E3270 VA: 0x1818E4070
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x18E3E60 Offset: 0x18E3060 VA: 0x1818E3E60
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x18E42D0 Offset: 0x18E34D0 VA: 0x1818E42D0
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x18E3E80 Offset: 0x18E3080 VA: 0x1818E3E80
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x18E37D0 Offset: 0x18E29D0 VA: 0x1818E37D0
	public float GetVibration(int motorIndex) { }

	// RVA: 0x18E42F0 Offset: 0x18E34F0 VA: 0x1818E42F0
	public void StopVibration() { }

	// RVA: 0x18E58A0 Offset: 0x18E4AA0 VA: 0x1818E58A0 Slot: 51
	internal override void bEQbpgXPReDNkMuvWNRYrmEakniO(UpdateLoopType ) { }

	// RVA: 0x18E6870 Offset: 0x18E5A70 VA: 0x1818E6870
	internal void owmfOgGjlBDESjJSizSYSeJGhVgSA(UpdateControllerInfoEventArgs ) { }

	// RVA: 0x18E6850 Offset: 0x18E5A50 VA: 0x1818E6850
	internal void owmfOgGjlBDESjJSizSYSeJGhVgSA(BridgedController ) { }

	// RVA: 0x18E6890 Offset: 0x18E5A90 VA: 0x1818E6890
	private void owmfOgGjlBDESjJSizSYSeJGhVgSA(IInputManagerJoystickPublic ) { }

	// RVA: 0x18E5A20 Offset: 0x18E4C20 VA: 0x1818E5A20 Slot: 53
	internal override void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x18E33D0 Offset: 0x18E25D0 VA: 0x1818E33D0 Slot: 58
	internal override void BrXJkfHLERFpbScebqEwNAEsBsbv(bool ) { }

	// RVA: 0x18E34A0 Offset: 0x18E26A0 VA: 0x1818E34A0 Slot: 60
	protected override void Disconnected() { }

	// RVA: 0x18E6730 Offset: 0x18E5930 VA: 0x1818E6730
	private void lAzNUmhqtxicPobytuVUvKsKECDL() { }

	// RVA: 0x18E3940 Offset: 0x18E2B40 VA: 0x1818E3940
	private void JDeduPROXgEDsApgWLCJoDrMakiA(int , float , float , bool , bool ) { }

	// RVA: 0x18E65B0 Offset: 0x18E57B0 VA: 0x1818E65B0
	private void jvfcrTiLALhVlbPJkDLhSFQeTxeMB() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void FJWWSsujGtWTVniggFTzbIaMPOHdA() { }

	// RVA: 0x18E6C70 Offset: 0x18E5E70 VA: 0x1818E6C70
	internal static int vBTGnVDSuUAknZuPTbiRKyVfTwfJ(Joystick , Joystick ) { }
}

// Namespace: 
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class Keyboard.ModifierKeyInfo // TypeDefIndex: 6774
{
	// Fields
	public readonly string shortName; // 0x10
	public readonly string longName; // 0x18
	public readonly string shortKey; // 0x20
	public readonly string longKey; // 0x28

	// Methods

	// RVA: 0x1808FD0 Offset: 0x18081D0 VA: 0x181808FD0
	public void .ctor(string , string , string , string ) { }

	// RVA: 0x19F12A0 Offset: 0x19F04A0 VA: 0x1819F12A0
	public string GetName(bool useShort) { }

	// RVA: 0x19F1290 Offset: 0x19F0490 VA: 0x1819F1290
	public string GetKey(bool useShort) { }
}

// Namespace: 
private class Keyboard.jwrRFJzwvEDEheZuLONJOPvpEhsdA // TypeDefIndex: 6775
{
	// Fields
	public readonly Keyboard.dxyyHSwMocqOlpSzqkCuixLGnRqD yHlUldSBJazCtFUNkZZPSdsvwZee; // 0x10
	public readonly Keyboard.dxyyHSwMocqOlpSzqkCuixLGnRqD YVNSuRZaGBHrChhSDljbVXRgtrKTA; // 0x18

	// Methods

	// RVA: 0x19F6B20 Offset: 0x19F5D20 VA: 0x1819F6B20
	public void .ctor(string , string ) { }
}

// Namespace: 
private sealed class Keyboard.dxyyHSwMocqOlpSzqkCuixLGnRqD // TypeDefIndex: 6776
{
	// Fields
	public readonly LocalizedString CdEckvrVAeswSaQCfMLbUlJjpTfR; // 0x10
	public bool TYvSdPlbTixfQnuaKhazNLSsPGKT; // 0x18

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(LocalizedString ) { }
}

// Namespace: 
private sealed class Keyboard.MpknkylTTykFoSjkYwCzMaSVhwdN // TypeDefIndex: 6777
{
	// Fields
	public readonly KeyedGlyph CdEckvrVAeswSaQCfMLbUlJjpTfR; // 0x10
	public bool IXlbusLIrJCtRjadkvVFdlXUbjxG; // 0x18

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(KeyedGlyph ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Keyboard.xUgaltgIuAnOSBhZcqzhcFuhYcDqC : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 6778
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Keyboard nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private int MntyOnrHoXdxNfrlxNHtHIVATsomc; // 0x60
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x64

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19FAEE0 Offset: 0x19FA0E0 VA: 0x1819FAEE0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19FB290 Offset: 0x19FA490 VA: 0x1819FB290 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x19FB2D0 Offset: 0x19FA4D0 VA: 0x1819FB2D0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19FB1D0 Offset: 0x19FA3D0 VA: 0x1819FB1D0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19FB1D0 Offset: 0x19FA3D0 VA: 0x1819FB1D0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Keyboard.CSDTkKZDgDAHnuGPSeDrGrZENjzs : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 6779
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Keyboard nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private int MntyOnrHoXdxNfrlxNHtHIVATsomc; // 0x60
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x64

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19E0A60 Offset: 0x19DFC60 VA: 0x1819E0A60 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19E0E10 Offset: 0x19E0010 VA: 0x1819E0E10 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x19E0E50 Offset: 0x19E0050 VA: 0x1819E0E50 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19E0D50 Offset: 0x19DFF50 VA: 0x1819E0D50 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19E0D50 Offset: 0x19DFF50 VA: 0x1819E0D50 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired
public sealed class Keyboard : ControllerWithMap // TypeDefIndex: 6780
{
	// Fields
	private const string pDpESUOEeqlrTWaTOTwCEFqKdCIiA = " + ";
	private static Keyboard hrdALeOvDlixWZvPkEXeSmXijFiP; // 0x0
	private static KeyboardKeyCode[] NqidHgIJvaGDekeHMnCRnjoBiDhfA; // 0x8
	private static Guid XgVrzZdPBibHKcOcGJbBlRGLYkTv; // 0x10
	private readonly IUnifiedKeyboardSource SDwzWAaQayKsUsCLxvZirfQfmcnS; // 0x130
	private ModifierKeyFlags XLXbCvHDOUMPlCwPEcjFWMwumfzrb; // 0x138
	private ModifierKeyFlags xIclrGajWanzhJveosTmDcbbJSMR; // 0x13C
	private Func<KeyboardKeyCode, int> KRdlsWFJFoUInMkfcSZGFSVbdLyS; // 0x140
	private readonly int[] MImzPkCIMMxNKCaAnxjOIRjWBMmI; // 0x148
	private readonly int EwPLuxlLbXZPcFBAUdFgjFxRiXUi; // 0x150
	private readonly xYZRMdGsFrJEudjhPFkBaQKrJYfiA uGKIFbobRgQFDoZqIMTqFxBxLFLr; // 0x158
	private readonly bKyEesgiGYPCvJiRvkjArHRLPJcc ZvlgTuiLQSqHayahkzzyzRrvsuPq; // 0x160
	private Dictionary<int, Keyboard.jwrRFJzwvEDEheZuLONJOPvpEhsdA> BNKvgFSqdvWYMJXjVJIjeABmVXmo; // 0x168
	private Dictionary<int, Keyboard.MpknkylTTykFoSjkYwCzMaSVhwdN> qjkfSrEaleQDnixYXonuWlquiAiF; // 0x170

	// Properties
	private static KeyboardKeyCode[] GhzIsavXUpqkyIZnteQpBvlWCqeI { get; }
	private Dictionary<int, Keyboard.jwrRFJzwvEDEheZuLONJOPvpEhsdA> VYFJDyJCxRkCBcyVnQrtomDGRoIs { get; }
	private Dictionary<int, Keyboard.MpknkylTTykFoSjkYwCzMaSVhwdN> dBjRYWRhdtcXNxIAsSgfVXJONCUb { get; }
	public override Guid deviceInstanceGuid { get; }

	// Methods

	// RVA: 0x19EEF30 Offset: 0x19EE130 VA: 0x1819EEF30
	private static KeyboardKeyCode[] TZpmBsjnXGZnceykFxUvYSOqqbjD() { }

	// RVA: 0x19F0490 Offset: 0x19EF690 VA: 0x1819F0490
	private Dictionary<int, Keyboard.jwrRFJzwvEDEheZuLONJOPvpEhsdA> iEiGvSYJwBVEqtSNOJITZxAAGhyW() { }

	// RVA: 0x19EC1E0 Offset: 0x19EB3E0 VA: 0x1819EC1E0
	private Dictionary<int, Keyboard.MpknkylTTykFoSjkYwCzMaSVhwdN> CbYajSGRKnMGfBJSMYwtFgPnjNMEA() { }

	// RVA: 0x19EF270 Offset: 0x19EE470 VA: 0x1819EF270
	internal void .ctor(string , IUnifiedKeyboardSource ) { }

	// RVA: 0x19EF750 Offset: 0x19EE950 VA: 0x1819EF750
	private void .ctor(int , InputSource , string , string , HardwareControllerMap_Game , int , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x19F0100 Offset: 0x19EF300 VA: 0x1819F0100 Slot: 4
	public override Guid get_deviceInstanceGuid() { }

	// RVA: 0x19ED500 Offset: 0x19EC700 VA: 0x1819ED500
	public bool GetKey(KeyCode keyCode) { }

	// RVA: 0x19ECEA0 Offset: 0x19EC0A0 VA: 0x1819ECEA0
	public bool GetKeyDown(KeyCode keyCode) { }

	// RVA: 0x19ED410 Offset: 0x19EC610 VA: 0x1819ED410
	public bool GetKeyUp(KeyCode keyCode) { }

	// RVA: 0x19ECD30 Offset: 0x19EBF30 VA: 0x1819ECD30
	public bool GetKeyDoublePressHold(KeyCode keyCode, float speed) { }

	// RVA: 0x19ECE30 Offset: 0x19EC030 VA: 0x1819ECE30
	public bool GetKeyDoublePressHold(KeyCode keyCode) { }

	// RVA: 0x19ECC30 Offset: 0x19EBE30 VA: 0x1819ECC30
	public bool GetKeyDoublePressDown(KeyCode keyCode, float speed) { }

	// RVA: 0x19ECB40 Offset: 0x19EBD40 VA: 0x1819ECB40
	public bool GetKeyDoublePressDown(KeyCode keyCode) { }

	// RVA: 0x19ED140 Offset: 0x19EC340 VA: 0x1819ED140
	public bool GetKeyPrev(KeyCode keyCode) { }

	// RVA: 0x19ED230 Offset: 0x19EC430 VA: 0x1819ED230
	public double GetKeyTimePressed(KeyCode keyCode) { }

	// RVA: 0x19ED320 Offset: 0x19EC520 VA: 0x1819ED320
	public double GetKeyTimeUnpressed(KeyCode keyCode) { }

	// RVA: 0x19EDE30 Offset: 0x19ED030 VA: 0x1819EDE30
	public bool GetModifierKey(ModifierKey key) { }

	// RVA: 0x19ED750 Offset: 0x19EC950 VA: 0x1819ED750
	public bool GetModifierKeyDown(ModifierKey key) { }

	// RVA: 0x19EDD10 Offset: 0x19ECF10 VA: 0x1819EDD10
	public bool GetModifierKeyUp(ModifierKey key) { }

	// RVA: 0x19ED9E0 Offset: 0x19ECBE0 VA: 0x1819ED9E0
	public bool GetModifierKeyPrev(ModifierKey key) { }

	// RVA: 0x19EDAF0 Offset: 0x19ECCF0 VA: 0x1819EDAF0
	public double GetModifierKeyTimePressed(ModifierKey key) { }

	// RVA: 0x19EDC00 Offset: 0x19ECE00 VA: 0x1819EDC00
	public double GetModifierKeyTimeUnpressed(ModifierKey key) { }

	// RVA: 0x19EC6E0 Offset: 0x19EB8E0 VA: 0x1819EC6E0
	public KeyCode GetKeyCodeByButtonIndex(int buttonIndex) { }

	// RVA: 0x19EC8D0 Offset: 0x19EBAD0 VA: 0x1819EC8D0
	public KeyCode GetKeyCodeById(int elementIdentifierId) { }

	// RVA: 0x19EC4E0 Offset: 0x19EB6E0 VA: 0x1819EC4E0
	public int GetButtonIndexByKeyCode(KeyCode keyCode) { }

	// RVA: 0x19EC5F0 Offset: 0x19EB7F0 VA: 0x1819EC5F0
	public ControllerElementIdentifier GetElementIdentifierByKeyCode(KeyCode keyCode) { }

	// RVA: 0x19EEBA0 Offset: 0x19EDDA0 VA: 0x1819EEBA0
	public ControllerPollingInfo PollForFirstKey() { }

	// RVA: 0x19EE7E0 Offset: 0x19ED9E0 VA: 0x1819EE7E0
	public IEnumerable<ControllerPollingInfo> PollForAllKeys() { }

	// RVA: 0x19EE760 Offset: 0x19ED960 VA: 0x1819EE760
	public IEnumerable<ControllerPollingInfo> PollForAllKeysDown() { }

	// RVA: 0x19EE8E0 Offset: 0x19EDAE0 VA: 0x1819EE8E0
	public ControllerPollingInfo PollForFirstKeyDown() { }

	// RVA: 0x19EE8A0 Offset: 0x19EDAA0 VA: 0x1819EE8A0 Slot: 41
	public override ControllerPollingInfo PollForFirstButton() { }

	// RVA: 0x19EE860 Offset: 0x19EDA60 VA: 0x1819EE860 Slot: 42
	public override ControllerPollingInfo PollForFirstButtonDown() { }

	// RVA: 0x19EE7E0 Offset: 0x19ED9E0 VA: 0x1819EE7E0 Slot: 45
	public override IEnumerable<ControllerPollingInfo> PollForAllButtons() { }

	// RVA: 0x19EE760 Offset: 0x19ED960 VA: 0x1819EE760 Slot: 46
	public override IEnumerable<ControllerPollingInfo> PollForAllButtonsDown() { }

	// RVA: 0x19EE110 Offset: 0x19ED310 VA: 0x1819EE110
	public static bool IsModifierKey(KeyCode key) { }

	// RVA: 0x19EE110 Offset: 0x19ED310 VA: 0x1819EE110
	internal static bool JIBttleDIJnagENMTuMPOTbjTkpO(KeyboardKeyCode ) { }

	// RVA: 0x19EE1B0 Offset: 0x19ED3B0 VA: 0x1819EE1B0
	public static ModifierKey KeyCodeToModifierKey(KeyCode key) { }

	// RVA: 0x19EE130 Offset: 0x19ED330 VA: 0x1819EE130
	public static ModifierKeyFlags KeyCodeToModifierKeyFlags(KeyCode key) { }

	// RVA: 0x19EE3B0 Offset: 0x19ED5B0 VA: 0x1819EE3B0
	public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, ModifierKey key) { }

	// RVA: 0x19EE400 Offset: 0x19ED600 VA: 0x1819EE400
	public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, KeyCode key) { }

	// RVA: 0x19EE4F0 Offset: 0x19ED6F0 VA: 0x1819EE4F0
	public static ModifierKey ModifierKeyFlagsToModifierKey(ModifierKeyFlags flags) { }

	// RVA: 0x19EE490 Offset: 0x19ED690 VA: 0x1819EE490
	public static KeyCode ModifierKeyFlagsToKeyCode(ModifierKeyFlags flags) { }

	// RVA: 0x19EE720 Offset: 0x19ED920 VA: 0x1819EE720
	public static ModifierKeyFlags ModifierKeyToModifierKeyFlags(ModifierKey key) { }

	// RVA: 0x19ECF90 Offset: 0x19EC190 VA: 0x1819ECF90
	public static string GetKeyName(KeyCode key) { }

	// RVA: 0x19ED070 Offset: 0x19EC270 VA: 0x1819ED070
	public static string GetKeyName(KeyCode key, ModifierKeyFlags flags) { }

	// RVA: 0x19ED8E0 Offset: 0x19ECAE0 VA: 0x1819ED8E0
	public static string GetModifierKeyName(ModifierKey modifierKey) { }

	// RVA: 0x19ED950 Offset: 0x19ECB50 VA: 0x1819ED950
	public static string GetModifierKeyName(ModifierKey modifierKey, bool getShortName) { }

	// RVA: 0x19EE540 Offset: 0x19ED740 VA: 0x1819EE540
	public static string ModifierKeyFlagsToString(ModifierKeyFlags flags, bool getShortName) { }

	// RVA: 0x19EE710 Offset: 0x19ED910 VA: 0x1819EE710
	public static string ModifierKeyFlagsToString(ModifierKeyFlags flags) { }

	// RVA: 0x19ED880 Offset: 0x19ECA80 VA: 0x1819ED880
	public static object GetModifierKeyGlyph(ModifierKey modifierKey) { }

	// RVA: 0x19F0A30 Offset: 0x19EFC30 VA: 0x1819F0A30
	internal static string lLHdPVkUBRfOZpehiJORXMgWafJIA(ModifierKey ) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	internal static KeyboardKeyCode RAGEwOiRVacBbgjJByOOfHDNgEqTb(KeyCode ) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	internal static KeyCode xZhbWQprUuhXOuSBcCLBWudKcsIK(KeyboardKeyCode ) { }

	// RVA: 0x19EEE60 Offset: 0x19EE060 VA: 0x1819EEE60
	internal static ModifierKeyFlags SaVRyfMCrEBfzGaQGhdOCNKCRLbj(ModifierKeyFlags ) { }

	// RVA: 0x19F0450 Offset: 0x19EF650 VA: 0x1819F0450
	internal static int hQZqkRnMMMeOHEvbalLlSIsIouXuA(ModifierKeyFlags ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19ED5F0 Offset: 0x19EC7F0 VA: 0x1819ED5F0
	internal static KeyboardKeyCode GetKeyboardKeyCodeByButtonIndex(int buttonIndex) { }

	// RVA: 0x19EBC30 Offset: 0x19EAE30 VA: 0x1819EBC30
	internal static int AAkRNEqBPdqcDpCtfQqrfCulaWtQ(KeyboardKeyCode ) { }

	// RVA: 0x19EFC20 Offset: 0x19EEE20 VA: 0x1819EFC20
	internal static void ezKgBQRdsXzrGcvSLLZAZYKAVCiI(ref int , ref KeyCode ) { }

	// RVA: 0x19EF870 Offset: 0x19EEA70 VA: 0x1819EF870 Slot: 51
	internal override void bEQbpgXPReDNkMuvWNRYrmEakniO(UpdateLoopType ) { }

	// RVA: 0x19F07A0 Offset: 0x19EF9A0 VA: 0x1819F07A0
	internal void jEcEJMgADVHXszwAOIQoYSMcucXg(UpdateLoopType ) { }

	// RVA: 0x19F0C60 Offset: 0x19EFE60 VA: 0x1819F0C60
	internal bool pUrcfOPUJVfooDsMfHBaFkAQfEcj(KeyboardKeyCode ) { }

	// RVA: 0x19EEEC0 Offset: 0x19EE0C0 VA: 0x1819EEEC0
	internal bool SjosWQbsggiBeGEVSTzbtIHBhyYg(KeyboardKeyCode ) { }

	// RVA: 0x19EF070 Offset: 0x19EE270 VA: 0x1819EF070
	internal bool ZuUVnBNeCJDkRALbFBPXBfMHrlVLc(KeyboardKeyCode , ModifierKeyFlags ) { }

	// RVA: 0x19EBEC0 Offset: 0x19EB0C0 VA: 0x1819EBEC0
	internal bool BAlTSmaKCCmkRIODiRDNAaqBYdYU(KeyboardKeyCode , ModifierKeyFlags ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19EC5B0 Offset: 0x19EB7B0 VA: 0x1819EC5B0
	internal int GetButtonIndex(KeyboardKeyCode keyCode) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19EC0A0 Offset: 0x19EB2A0 VA: 0x1819EC0A0 Slot: 55
	internal override void BakeMap(ControllerMap controllerMap) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19EC080 Offset: 0x19EB280 VA: 0x1819EC080 Slot: 56
	internal override void BakeActionElementMap(ControllerMap controllerMap, ActionElementMap map) { }

	// RVA: 0x19EFC00 Offset: 0x19EEE00 VA: 0x1819EFC00 Slot: 53
	internal override void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x19EF8F0 Offset: 0x19EEAF0 VA: 0x1819EF8F0 Slot: 54
	internal override bool bVBdiGZsBixPGwYOsVSchVHJeQqe(bool ) { }

	// RVA: 0x19F1050 Offset: 0x19F0250 VA: 0x1819F1050
	private bool spYuQvnSopJPpNACdgDoVqNrJnfV(out Controller.Button , out Controller.Button , ModifierKey ) { }

	// RVA: 0x19F0CD0 Offset: 0x19EFED0 VA: 0x1819F0CD0
	private void pcgIyKTZtQmpEIszkkxqbeZXzTYj() { }

	// RVA: 0x19EFD70 Offset: 0x19EEF70 VA: 0x1819EFD70
	private string gQaNFCgdDBFKvaNYcrkCSqfBhSxK(ModifierKey , bool ) { }

	// RVA: 0x19EE2F0 Offset: 0x19ED4F0 VA: 0x1819EE2F0
	private static bool MmSVFoZBjUpJvRZTNSAzzwzzZdkh(Keyboard.dxyyHSwMocqOlpSzqkCuixLGnRqD , string , string , DeviceLocalizationInfo , out string ) { }

	// RVA: 0x19EBCF0 Offset: 0x19EAEF0 VA: 0x1819EBCF0
	private object AdAckHBdXSXUovSuKrybulvPmXin(ModifierKey ) { }

	// RVA: 0x19EDF40 Offset: 0x19ED140 VA: 0x1819EDF40
	private string HLakBZFrwfeypZvedKWYlXtDUVnQ(ModifierKey ) { }

	// RVA: 0x19F03A0 Offset: 0x19EF5A0 VA: 0x1819F03A0
	private static bool gzwKqmaTyeJWnzlaOHGNSlJfHTTl(Keyboard.MpknkylTTykFoSjkYwCzMaSVhwdN , string , DeviceLocalizationInfo , out object ) { }

	// RVA: 0x19EE220 Offset: 0x19ED420 VA: 0x1819EE220
	private static bool MMJbkVwDhddGbsxjjhWAMSWCzoIe(Keyboard.MpknkylTTykFoSjkYwCzMaSVhwdN , string , DeviceLocalizationInfo , out string ) { }

	[CompilerGenerated]
	// RVA: 0x19EF9B0 Offset: 0x19EEBB0 VA: 0x1819EF9B0
	private void eRCLLhlTuekgipUnHcNOGIhKGrVm() { }

	[CompilerGenerated]
	// RVA: 0x19F01E0 Offset: 0x19EF3E0 VA: 0x1819F01E0
	private void gvUhOkYPlcZpHJLEFGWfccgYRLvEA() { }
}

// Namespace: Rewired
public sealed class Mouse : ControllerWithAxes // TypeDefIndex: 6781
{
	// Fields
	private TimerAbs RDAchgaPlGPEvGTvqGHLAGyQVirrA; // 0x178
	private float[] hKlZsuEIVpXthsLGYIKGupJOgvsL; // 0x180
	private Vector2 xdtSVilfQvXZxVJDFWOUGIEcKdNV; // 0x188
	private Vector2 fYykYqbyxfZLQhTQatQdsRqWqLui; // 0x190
	private int RrBvYHSbXvIrUPNcCxMiApcQwxev; // 0x198
	private readonly IUnifiedMouseSource SDwzWAaQayKsUsCLxvZirfQfmcnS; // 0x1A0
	private static Guid XgVrzZdPBibHKcOcGJbBlRGLYkTv; // 0x0

	// Properties
	public Vector2 screenPosition { get; }
	public Vector2 screenPositionPrev { get; }
	public Vector2 screenPositionDelta { get; }
	public override Guid deviceInstanceGuid { get; }

	// Methods

	// RVA: 0x19F2130 Offset: 0x19F1330 VA: 0x1819F2130
	public Vector2 get_screenPosition() { }

	// RVA: 0x19F2050 Offset: 0x19F1250 VA: 0x1819F2050
	public Vector2 get_screenPositionPrev() { }

	// RVA: 0x19F1F60 Offset: 0x19F1160 VA: 0x1819F1F60
	public Vector2 get_screenPositionDelta() { }

	// RVA: 0x19F1EA0 Offset: 0x19F10A0 VA: 0x1819F1EA0 Slot: 4
	public override Guid get_deviceInstanceGuid() { }

	// RVA: 0x19F18A0 Offset: 0x19F0AA0 VA: 0x1819F18A0
	internal void .ctor(string , IUnifiedMouseSource ) { }

	// RVA: 0x19F1790 Offset: 0x19F0990 VA: 0x1819F1790
	private void .ctor(int , InputSource , string , string , int , int , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x19F1BA0 Offset: 0x19F0DA0 VA: 0x1819F1BA0 Slot: 51
	internal override void bEQbpgXPReDNkMuvWNRYrmEakniO(UpdateLoopType ) { }

	// RVA: 0x19F1400 Offset: 0x19F0600 VA: 0x1819F1400 Slot: 61
	protected override bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId) { }

	// RVA: 0x19F1DE0 Offset: 0x19F0FE0 VA: 0x1819F1DE0 Slot: 53
	internal override void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x19F1C20 Offset: 0x19F0E20 VA: 0x1819F1C20 Slot: 54
	internal override bool bVBdiGZsBixPGwYOsVSchVHJeQqe(bool ) { }

	// RVA: 0x19F12B0 Offset: 0x19F04B0 VA: 0x1819F12B0
	private void ADRAdvBIGulRTCxvjGGuggeomnfBA() { }
}

// Namespace: 
internal abstract class ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA : IControllerTemplateElement, IControllerTemplateElement_Internal // TypeDefIndex: 6782
{
	// Fields
	private readonly IControllerTemplate YgOUhFlqQKEAUkaFqxIeQeWEyeff; // 0x10
	private readonly int yAQloNnkxShCOoclhwMCxCpNptHE; // 0x18
	private readonly ControllerTemplateElementType pOhBaZskjTHDxcxbPUVoUhsOLebB; // 0x1C
	protected readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x20
	protected readonly FaVFYcDpCyvshrEyVMRMxCjPlineb kGpWoVlownErpwRTMJUrRKHGaLckA; // 0x28

	// Properties
	public int id { get; }
	public string descriptiveName { get; }
	internal string PoFJEkFBxSDVlekDuffXJzshDawHb { get; }
	public ControllerTemplateElementType type { get; }
	public IControllerTemplate parent { get; }
	public abstract int elementCount { get; }
	public abstract IControllerTemplateElementSource source { get; }
	public abstract bool exists { get; }

	// Methods

	// RVA: 0x19F6320 Offset: 0x19F5520 VA: 0x1819F6320
	protected void .ctor(IControllerTemplate , int , ControllerTemplateElementType , FaVFYcDpCyvshrEyVMRMxCjPlineb ) { }

	// RVA: 0x19F6540 Offset: 0x19F5740 VA: 0x1819F6540 Slot: 4
	public int get_id() { }

	// RVA: 0x19F64A0 Offset: 0x19F56A0 VA: 0x1819F64A0 Slot: 5
	public string get_descriptiveName() { }

	// RVA: 0x18A7230 Offset: 0x18A6430 VA: 0x1818A7230
	internal string olBpGtDDBenlmiHYQvuYEdfkIlyf() { }

	// RVA: 0x19F65D0 Offset: 0x19F57D0 VA: 0x1819F65D0 Slot: 6
	public ControllerTemplateElementType get_type() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 9
	public IControllerTemplate get_parent() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int get_elementCount();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IControllerTemplateElement GetElement(int index);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IControllerTemplateElementSource get_source();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_exists();

	// RVA: 0x19F6660 Offset: 0x19F5860 VA: 0x1819F6660
	protected static FaVFYcDpCyvshrEyVMRMxCjPlineb pwGTwRowoRefPhhmTdgEVUYccsgiA(IControllerTemplate_Internal , int , string , string ) { }
}

// Namespace: 
internal abstract class ControllerTemplate.DixprdpRLggSecgFXOhNzBpezQxcA : ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA // TypeDefIndex: 6783
{
	// Fields
	protected readonly int CUnbAPAswMptMfVqyHLVspaYUyduA; // 0x30
	protected readonly ControllerTemplate.wXoZiEQFXLVogjaisIyhDRYDQixz[] IBuBPUPTJkiywifkyqZNMCzUnPed; // 0x38

	// Properties
	public override bool hgjWlmqONvwbNFkYpJoLPhsuQqyy { get; }

	// Methods

	// RVA: 0x19EA0F0 Offset: 0x19E92F0 VA: 0x1819EA0F0
	protected void .ctor(IControllerTemplate , int , ControllerTemplateElementType , IList<ControllerTemplate.wXoZiEQFXLVogjaisIyhDRYDQixz> , FaVFYcDpCyvshrEyVMRMxCjPlineb ) { }

	// RVA: 0x19EA2C0 Offset: 0x19E94C0 VA: 0x1819EA2C0 Slot: 17
	public override bool yUuHkSjoEYCzhjJAnCMyfImOwkwJA() { }
}

// Namespace: 
internal abstract class ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib : ControllerTemplate.DixprdpRLggSecgFXOhNzBpezQxcA, IControllerTemplateElement, IControllerTemplateButton, IControllerTemplateAxis // TypeDefIndex: 6784
{
	// Fields
	private jDCySwCSAVHKuUnPmaQCBczTSqylA aGdmGXiGhrYsfydTWTVhHYKVxvGl; // 0x40

	// Properties
	public float LJNxoLmpoFBFqTWkOchTiCYysjDx { get; }
	public float BFpiOSkWVGmuyjHRIqeeYNcATLEr { get; }
	public bool LrbRyzLEFKCQOUOPtHiCeChvmosAA { get; }
	public bool TvXgerUNlLuCZGhsYMBBlCrMsjyn { get; }
	private string Rewired.IControllerTemplateAxis.positiveDescriptiveName { get; }
	private string Rewired.IControllerTemplateAxis.negativeDescriptiveName { get; }
	private float Rewired.IControllerTemplateAxis.value { get; }
	private float Rewired.IControllerTemplateAxis.valuePrev { get; }
	private IControllerTemplateAxisSource Rewired.IControllerTemplateAxis.source { get; }
	private bool Rewired.IControllerTemplateButton.value { get; }
	private bool Rewired.IControllerTemplateButton.valuePrev { get; }
	private bool Rewired.IControllerTemplateButton.justPressed { get; }
	private bool Rewired.IControllerTemplateButton.justReleased { get; }
	private bool Rewired.IControllerTemplateButton.justChangedState { get; }
	private float Rewired.IControllerTemplateButton.pressure { get; }
	private float Rewired.IControllerTemplateButton.pressurePrev { get; }
	private IControllerTemplateButtonSource Rewired.IControllerTemplateButton.source { get; }
	public override IControllerTemplateElementSource source { get; }
	public override int elementCount { get; }
	public IControllerTemplateAxis AsAxis { get; }
	public IControllerTemplateButton AsButton { get; }
	protected JbfDCKDoFFynuqSCQfGdleIlXWOU dLWtDoRnxlYTfJkNtQVTjkMpfUHq { get; }

	// Methods

	// RVA: 0x19F59E0 Offset: 0x19F4BE0 VA: 0x1819F59E0
	protected void .ctor(IControllerTemplate , int , ControllerTemplateElementType , jDCySwCSAVHKuUnPmaQCBczTSqylA , IList<ControllerTemplate.wXoZiEQFXLVogjaisIyhDRYDQixz> , JbfDCKDoFFynuqSCQfGdleIlXWOU ) { }

	// RVA: 0x19F5C90 Offset: 0x19F4E90 VA: 0x1819F5C90
	public float dWiFzJeEoTCwGcWTPHdzQpargUPeA() { }

	// RVA: 0x19F4D80 Offset: 0x19F3F80 VA: 0x1819F4D80
	public float JAdrCBnENLTJStqCNhQxARPSAnkUA() { }

	// RVA: 0x19F6220 Offset: 0x19F5420 VA: 0x1819F6220
	public bool uWzBPUfjymiqUQKufLyLVHEAnJeqA() { }

	// RVA: 0x19F6090 Offset: 0x19F5290 VA: 0x1819F6090
	public bool tLePbtuOgHdAzUXWpdgiYDkSeulZ() { }

	// RVA: 0x19F5110 Offset: 0x19F4310 VA: 0x1819F5110 Slot: 28
	private string Rewired.IControllerTemplateAxis.get_positiveDescriptiveName() { }

	// RVA: 0x19F5070 Offset: 0x19F4270 VA: 0x1819F5070 Slot: 29
	private string Rewired.IControllerTemplateAxis.get_negativeDescriptiveName() { }

	// RVA: 0x19F52D0 Offset: 0x19F44D0 VA: 0x1819F52D0 Slot: 31
	private float Rewired.IControllerTemplateAxis.get_value() { }

	// RVA: 0x19F5240 Offset: 0x19F4440 VA: 0x1819F5240 Slot: 32
	private float Rewired.IControllerTemplateAxis.get_valuePrev() { }

	// RVA: 0x19F51B0 Offset: 0x19F43B0 VA: 0x1819F51B0 Slot: 33
	private IControllerTemplateAxisSource Rewired.IControllerTemplateAxis.get_source() { }

	// RVA: 0x19F4EE0 Offset: 0x19F40E0 VA: 0x1819F4EE0 Slot: 30
	private string Rewired.IControllerTemplateAxis.GetDescriptiveName(AxisRange axisRange) { }

	// RVA: 0x19F5950 Offset: 0x19F4B50 VA: 0x1819F5950 Slot: 19
	private bool Rewired.IControllerTemplateButton.get_value() { }

	// RVA: 0x19F58C0 Offset: 0x19F4AC0 VA: 0x1819F58C0 Slot: 20
	private bool Rewired.IControllerTemplateButton.get_valuePrev() { }

	// RVA: 0x19F5410 Offset: 0x19F4610 VA: 0x1819F5410 Slot: 23
	private bool Rewired.IControllerTemplateButton.get_justPressed() { }

	// RVA: 0x19F5590 Offset: 0x19F4790 VA: 0x1819F5590 Slot: 24
	private bool Rewired.IControllerTemplateButton.get_justReleased() { }

	// RVA: 0x19F5360 Offset: 0x19F4560 VA: 0x1819F5360 Slot: 25
	private bool Rewired.IControllerTemplateButton.get_justChangedState() { }

	// RVA: 0x19F57A0 Offset: 0x19F49A0 VA: 0x1819F57A0 Slot: 21
	private float Rewired.IControllerTemplateButton.get_pressure() { }

	// RVA: 0x19F5710 Offset: 0x19F4910 VA: 0x1819F5710 Slot: 22
	private float Rewired.IControllerTemplateButton.get_pressurePrev() { }

	// RVA: 0x19F5830 Offset: 0x19F4A30 VA: 0x1819F5830 Slot: 26
	private IControllerTemplateButtonSource Rewired.IControllerTemplateButton.get_source() { }

	// RVA: 0x19F6000 Offset: 0x19F5200 VA: 0x1819F6000 Slot: 16
	public override IControllerTemplateElementSource get_source() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 13
	public override int get_elementCount() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 14
	public override IControllerTemplateElement GetElement(int index) { }

	// RVA: 0x19F4A80 Offset: 0x19F3C80 VA: 0x1819F4A80 Slot: 15
	public override int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list) { }

	// RVA: 0x19F5EE0 Offset: 0x19F50E0 VA: 0x1819F5EE0 Slot: 27
	public IControllerTemplateAxis get_AsAxis() { }

	// RVA: 0x19F5F70 Offset: 0x19F5170 VA: 0x1819F5F70 Slot: 34
	public IControllerTemplateButton get_AsButton() { }

	// RVA: 0x19F6190 Offset: 0x19F5390 VA: 0x1819F6190
	protected JbfDCKDoFFynuqSCQfGdleIlXWOU uUkRONtUqGxTTisaNjmXGQFkNBD() { }

	// RVA: 0x19F5DF0 Offset: 0x19F4FF0 VA: 0x1819F5DF0
	private static bool dkSFbCXiNiJLUaOdFdvkoCHxEEIo(ControllerElementTarget , IControllerElementTarget ) { }
}

// Namespace: 
internal sealed class ControllerTemplate.oUlBdELDIWgriVMGRlQDerAeuBKn : ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib // TypeDefIndex: 6785
{
	// Methods

	// RVA: 0x19F6D00 Offset: 0x19F5F00 VA: 0x1819F6D00
	public void .ctor(IControllerTemplate_Internal , int , string , string , string , string , string , string , jDCySwCSAVHKuUnPmaQCBczTSqylA , IList<ControllerTemplate.wXoZiEQFXLVogjaisIyhDRYDQixz> ) { }

	// RVA: 0x19F6C20 Offset: 0x19F5E20 VA: 0x1819F6C20
	internal static ControllerTemplate.oUlBdELDIWgriVMGRlQDerAeuBKn FwIIDWKNCUcsDcEkbYKpcPYzjmUjb(IControllerTemplate_Internal ) { }
}

// Namespace: 
internal sealed class ControllerTemplate.HpBQuLEddEOpzWbWSDGxFuShaeNN : ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib // TypeDefIndex: 6786
{
	// Methods

	// RVA: 0x19EA4D0 Offset: 0x19E96D0 VA: 0x1819EA4D0
	public void .ctor(IControllerTemplate_Internal , int , string , string , string , string , string , string , jDCySwCSAVHKuUnPmaQCBczTSqylA , IList<ControllerTemplate.wXoZiEQFXLVogjaisIyhDRYDQixz> ) { }

	// RVA: 0x19EA3F0 Offset: 0x19E95F0 VA: 0x1819EA3F0
	internal static ControllerTemplate.HpBQuLEddEOpzWbWSDGxFuShaeNN FwIIDWKNCUcsDcEkbYKpcPYzjmUjb(IControllerTemplate_Internal ) { }
}

// Namespace: 
internal abstract class ControllerTemplate.vYDxyEyqqnGnaObAUMtqriYtosRt : ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA // TypeDefIndex: 6787
{
	// Fields
	protected readonly int DYlksxJmueEjKxIXVVMZgGCWkNTO; // 0x30
	protected readonly ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] ZdSpjvRkgdsTMzWPFjtUndkXnkT; // 0x38

	// Properties
	public override bool hgjWlmqONvwbNFkYpJoLPhsuQqyy { get; }
	public override IControllerTemplateElementSource PKfQXIKSJfbcbHmkplZndVmtesxB { get; }
	public override int lrWDgIrOzCXQbUBarwzagPaDOvYC { get; }

	// Methods

	// RVA: 0x19F9FA0 Offset: 0x19F91A0 VA: 0x1819F9FA0
	protected void .ctor(IControllerTemplate , int , ControllerTemplateElementType , ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] , FaVFYcDpCyvshrEyVMRMxCjPlineb ) { }

	// RVA: 0x19FA2D0 Offset: 0x19F94D0 VA: 0x1819FA2D0 Slot: 17
	public override bool yUuHkSjoEYCzhjJAnCMyfImOwkwJA() { }

	// RVA: 0x19FA250 Offset: 0x19F9450 VA: 0x1819FA250 Slot: 16
	public override IControllerTemplateElementSource iTufQtFnOhgvwAiYastJRXQEsdJEb() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 13
	public override int dQoZKsoMBhRgwrISAckjxhfmgzOB() { }

	// RVA: 0x19F9F70 Offset: 0x19F9170 VA: 0x1819F9F70 Slot: 14
	public override IControllerTemplateElement RnACvZlSzBBziMYJDRxiKAYAOKGL(int ) { }

	// RVA: 0x19F9EB0 Offset: 0x19F90B0 VA: 0x1819F9EB0 Slot: 15
	public override int HmSdRKnXCBFwNUTuvbbIjAPIAgTJA(ControllerElementTarget , ref IList<ControllerTemplateElementTarget> ) { }
}

// Namespace: 
internal abstract class ControllerTemplate.JOqUKujNCSEqJekksGheGLSYXllIA : ControllerTemplate.vYDxyEyqqnGnaObAUMtqriYtosRt, IControllerTemplateElement, IControllerTemplateAxis2D // TypeDefIndex: 6788
{
	// Fields
	protected const int zcIKVwaMSUJtuIOaSxTVJQxnzJoi = 0;
	protected const int APZfKXFhYnkMrCcjkBsbAdzsRIYHc = 1;
	protected const int rbaZHPFwxVTIbRKTVJEQoGICaYfE = 2;

	// Properties
	public Vector2 value { get; }
	public Vector2 valuePrev { get; }
	public IControllerTemplateAxis horizontal { get; }
	public IControllerTemplateAxis vertical { get; }

	// Methods

	// RVA: 0x19EA830 Offset: 0x19E9A30 VA: 0x1819EA830
	protected void .ctor(IControllerTemplate , int , ControllerTemplateElementType , ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] , FaVFYcDpCyvshrEyVMRMxCjPlineb ) { }

	// RVA: 0x19EABD0 Offset: 0x19E9DD0 VA: 0x1819EABD0 Slot: 23
	public Vector2 get_value() { }

	// RVA: 0x19EA930 Offset: 0x19E9B30 VA: 0x1819EA930 Slot: 24
	public Vector2 get_valuePrev() { }

	// RVA: 0x19EA840 Offset: 0x19E9A40 VA: 0x1819EA840 Slot: 25
	public IControllerTemplateAxis get_horizontal() { }

	// RVA: 0x19EAE70 Offset: 0x19EA070 VA: 0x1819EAE70 Slot: 26
	public IControllerTemplateAxis get_vertical() { }
}

// Namespace: 
internal abstract class ControllerTemplate.JssVtRFfxsfooXapcaPDXUqPAWGG : ControllerTemplate.vYDxyEyqqnGnaObAUMtqriYtosRt, IControllerTemplateElement, IControllerTemplateAxis3D // TypeDefIndex: 6789
{
	// Fields
	protected const int zcIKVwaMSUJtuIOaSxTVJQxnzJoi = 0;
	protected const int APZfKXFhYnkMrCcjkBsbAdzsRIYHc = 1;
	protected const int QqtvjgNsAIAKHdsjGleffAJUYcOd = 2;
	protected const int rbaZHPFwxVTIbRKTVJEQoGICaYfE = 3;

	// Properties
	public Vector3 value { get; }
	public Vector3 valuePrev { get; }
	public IControllerTemplateAxis horizontal { get; }
	public IControllerTemplateAxis vertical { get; }
	public IControllerTemplateAxis depth { get; }

	// Methods

	// RVA: 0x19EA830 Offset: 0x19E9A30 VA: 0x1819EA830
	protected void .ctor(IControllerTemplate_Internal , int , ControllerTemplateElementType , ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] , FaVFYcDpCyvshrEyVMRMxCjPlineb ) { }

	// RVA: 0x19EB4D0 Offset: 0x19EA6D0 VA: 0x1819EB4D0 Slot: 23
	public Vector3 get_value() { }

	// RVA: 0x19EB140 Offset: 0x19EA340 VA: 0x1819EB140 Slot: 24
	public Vector3 get_valuePrev() { }

	// RVA: 0x19EB050 Offset: 0x19EA250 VA: 0x1819EB050 Slot: 25
	public IControllerTemplateAxis get_horizontal() { }

	// RVA: 0x19EB860 Offset: 0x19EAA60 VA: 0x1819EB860 Slot: 26
	public IControllerTemplateAxis get_vertical() { }

	// RVA: 0x19EAF60 Offset: 0x19EA160 VA: 0x1819EAF60 Slot: 27
	public IControllerTemplateAxis get_depth() { }
}

// Namespace: 
internal abstract class ControllerTemplate.rgAECJFysMBbwnQfZnXsaLxhBBCcb : ControllerTemplate.vYDxyEyqqnGnaObAUMtqriYtosRt, IControllerTemplateElement, IControllerTemplateAxis6D // TypeDefIndex: 6790
{
	// Fields
	protected const int RMgPfRoIKrEnegXNzUQNEDjIIzMR = 0;
	protected const int CvrZhJHjdFVQRBDHHNaqBNMfpjAU = 1;
	protected const int tXXNxRZLcQkMXqMKZTiCFUxghMwx = 2;
	protected const int YcBcUcrCezutxssrCZFRNfIamUAL = 3;
	protected const int bEszBayXcIFbWEHlAOWrzUplhiFX = 4;
	protected const int zFXAwFPvhcpNEtlCCCNQbCJwsSAF = 5;
	protected const int rbaZHPFwxVTIbRKTVJEQoGICaYfE = 6;

	// Properties
	public Vector3 position { get; }
	public Vector3 positionPrev { get; }
	public Vector3 rotation { get; }
	public Vector3 rotationPrev { get; }
	public IControllerTemplateAxis positionX { get; }
	public IControllerTemplateAxis positionY { get; }
	public IControllerTemplateAxis positionZ { get; }
	public IControllerTemplateAxis rotationX { get; }
	public IControllerTemplateAxis rotationY { get; }
	public IControllerTemplateAxis rotationZ { get; }

	// Methods

	// RVA: 0x19EA830 Offset: 0x19E9A30 VA: 0x1819EA830
	protected void .ctor(IControllerTemplate , int , ControllerTemplateElementType , ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] , FaVFYcDpCyvshrEyVMRMxCjPlineb ) { }

	// RVA: 0x19F9130 Offset: 0x19F8330 VA: 0x1819F9130 Slot: 23
	public Vector3 get_position() { }

	// RVA: 0x19F8AD0 Offset: 0x19F7CD0 VA: 0x1819F8AD0 Slot: 24
	public Vector3 get_positionPrev() { }

	// RVA: 0x19F9B20 Offset: 0x19F8D20 VA: 0x1819F9B20 Slot: 25
	public Vector3 get_rotation() { }

	// RVA: 0x19F94C0 Offset: 0x19F86C0 VA: 0x1819F94C0 Slot: 26
	public Vector3 get_rotationPrev() { }

	// RVA: 0x19F8E60 Offset: 0x19F8060 VA: 0x1819F8E60 Slot: 27
	public IControllerTemplateAxis get_positionX() { }

	// RVA: 0x19F8F50 Offset: 0x19F8150 VA: 0x1819F8F50 Slot: 28
	public IControllerTemplateAxis get_positionY() { }

	// RVA: 0x19F9040 Offset: 0x19F8240 VA: 0x1819F9040 Slot: 29
	public IControllerTemplateAxis get_positionZ() { }

	// RVA: 0x19F9850 Offset: 0x19F8A50 VA: 0x1819F9850 Slot: 30
	public IControllerTemplateAxis get_rotationX() { }

	// RVA: 0x19F9940 Offset: 0x19F8B40 VA: 0x1819F9940 Slot: 31
	public IControllerTemplateAxis get_rotationY() { }

	// RVA: 0x19F9A30 Offset: 0x19F8C30 VA: 0x1819F9A30 Slot: 32
	public IControllerTemplateAxis get_rotationZ() { }
}

// Namespace: 
internal sealed class ControllerTemplate.zZWAdTizRuuimrwOzaayyUEqGyLU : ControllerTemplate.JssVtRFfxsfooXapcaPDXUqPAWGG, IControllerTemplateElement, IControllerTemplateStick // TypeDefIndex: 6791
{
	// Fields
	private const int rbaZHPFwxVTIbRKTVJEQoGICaYfE = 3;

	// Properties
	public IControllerTemplateAxis rotation { get; }

	// Methods

	// RVA: 0x19FC100 Offset: 0x19FB300 VA: 0x1819FC100
	private void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] ) { }

	// RVA: 0x19FBEF0 Offset: 0x19FB0F0 VA: 0x1819FBEF0
	public void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib ) { }

	// RVA: 0x19FC200 Offset: 0x19FB400 VA: 0x1819FC200 Slot: 32
	public IControllerTemplateAxis get_rotation() { }
}

// Namespace: 
internal sealed class ControllerTemplate.yefIMngWiReYUPEhCzDrCbhttvqtA : ControllerTemplate.JOqUKujNCSEqJekksGheGLSYXllIA, IControllerTemplateElement, IControllerTemplateThumbStick // TypeDefIndex: 6792
{
	// Fields
	private const int hgnymylHIqClCovIcnutlJXxpbgS = 2;
	private const int rbaZHPFwxVTIbRKTVJEQoGICaYfE = 3;

	// Properties
	public IControllerTemplateButton press { get; }

	// Methods

	// RVA: 0x19FBD00 Offset: 0x19FAF00 VA: 0x1819FBD00
	private void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] ) { }

	// RVA: 0x19FBAF0 Offset: 0x19FACF0 VA: 0x1819FBAF0
	internal void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib ) { }

	// RVA: 0x19FBE00 Offset: 0x19FB000 VA: 0x1819FBE00 Slot: 31
	public IControllerTemplateButton get_press() { }
}

// Namespace: 
internal sealed class ControllerTemplate.CbMYOqnmHQJPvUfOcOssqqjMxPkv : ControllerTemplate.vYDxyEyqqnGnaObAUMtqriYtosRt, IControllerTemplateElement, IControllerTemplateDPad // TypeDefIndex: 6793
{
	// Fields
	private const int rMlEufAVkcUnObyUyRnVSmstNDWs = 0;
	private const int qThHDvyaGNIqAfGrQhyVPfiFEBrj = 1;
	private const int YnhFhJbSTGQQVwzAKPtZQALmCCYAb = 2;
	private const int gUTQpqJkWAfBJCfUUNFjIkKEwbaoB = 3;
	private const int UCiNDjZJmSVyDdllPCgMJpGwavuaA = 4;
	private const int rbaZHPFwxVTIbRKTVJEQoGICaYfE = 5;

	// Properties
	public Vector2 value { get; }
	public Vector2 valuePrev { get; }
	public IControllerTemplateButton up { get; }
	public IControllerTemplateButton right { get; }
	public IControllerTemplateButton down { get; }
	public IControllerTemplateButton left { get; }
	public IControllerTemplateButton press { get; }

	// Methods

	// RVA: 0x19E1150 Offset: 0x19E0350 VA: 0x1819E1150
	private void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] ) { }

	// RVA: 0x19E0EC0 Offset: 0x19E00C0 VA: 0x1819E0EC0
	internal void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib ) { }

	// RVA: 0x19E1B40 Offset: 0x19E0D40 VA: 0x1819E1B40 Slot: 23
	public Vector2 get_value() { }

	// RVA: 0x19E1700 Offset: 0x19E0900 VA: 0x1819E1700 Slot: 24
	public Vector2 get_valuePrev() { }

	// RVA: 0x19E1610 Offset: 0x19E0810 VA: 0x1819E1610 Slot: 25
	public IControllerTemplateButton get_up() { }

	// RVA: 0x19E1520 Offset: 0x19E0720 VA: 0x1819E1520 Slot: 26
	public IControllerTemplateButton get_right() { }

	// RVA: 0x19E1250 Offset: 0x19E0450 VA: 0x1819E1250 Slot: 27
	public IControllerTemplateButton get_down() { }

	// RVA: 0x19E1340 Offset: 0x19E0540 VA: 0x1819E1340 Slot: 28
	public IControllerTemplateButton get_left() { }

	// RVA: 0x19E1430 Offset: 0x19E0630 VA: 0x1819E1430 Slot: 29
	public IControllerTemplateButton get_press() { }
}

// Namespace: 
internal sealed class ControllerTemplate.BraDyWedpIcGWwggUaSfzpaWzeWX : ControllerTemplate.vYDxyEyqqnGnaObAUMtqriYtosRt, IControllerTemplateElement, IControllerTemplateThrottle // TypeDefIndex: 6794
{
	// Fields
	private const int QRFDTcqSSWwXVKZYgmDvGJbRACug = 0;
	private const int DjqxkrskhWAFtCiTOAxifMKfIbgNc = 1;
	private const int rbaZHPFwxVTIbRKTVJEQoGICaYfE = 2;

	// Properties
	public float value { get; }
	public float valuePrev { get; }
	public IControllerTemplateAxis throttle { get; }
	public IControllerTemplateButton minDetent { get; }

	// Methods

	// RVA: 0x19E0300 Offset: 0x19DF500 VA: 0x1819E0300
	private void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] ) { }

	// RVA: 0x19E0400 Offset: 0x19DF600 VA: 0x1819E0400
	internal void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib ) { }

	// RVA: 0x19E0900 Offset: 0x19DFB00 VA: 0x1819E0900 Slot: 23
	public float get_value() { }

	// RVA: 0x19E07A0 Offset: 0x19DF9A0 VA: 0x1819E07A0 Slot: 24
	public float get_valuePrev() { }

	// RVA: 0x19E06B0 Offset: 0x19DF8B0 VA: 0x1819E06B0 Slot: 25
	public IControllerTemplateAxis get_throttle() { }

	// RVA: 0x19E05C0 Offset: 0x19DF7C0 VA: 0x1819E05C0 Slot: 26
	public IControllerTemplateButton get_minDetent() { }
}

// Namespace: 
internal sealed class ControllerTemplate.owKZCIFCvkfpBXiQJxqWNOyZGKgG : ControllerTemplate.vYDxyEyqqnGnaObAUMtqriYtosRt, IControllerTemplateElement, IControllerTemplateHat // TypeDefIndex: 6795
{
	// Fields
	private const int rMlEufAVkcUnObyUyRnVSmstNDWs = 0;
	private const int FkFcSIWDrKoZvdMEiIxTaVQhRoHH = 1;
	private const int qThHDvyaGNIqAfGrQhyVPfiFEBrj = 2;
	private const int wfTPavDLMWAVaAKOJLzcmAhBJhYvA = 3;
	private const int YnhFhJbSTGQQVwzAKPtZQALmCCYAb = 4;
	private const int aELxjrPbpiHIuoVFKCaaObMCfPSZ = 5;
	private const int gUTQpqJkWAfBJCfUUNFjIkKEwbaoB = 6;
	private const int NmsJLTDNHrCwjXdcWfzIAFDsqgCbA = 7;
	private const int rbaZHPFwxVTIbRKTVJEQoGICaYfE = 8;

	// Properties
	public Vector2 value { get; }
	public Vector2 valuePrev { get; }
	public IControllerTemplateButton up { get; }
	public IControllerTemplateButton upRight { get; }
	public IControllerTemplateButton right { get; }
	public IControllerTemplateButton downRight { get; }
	public IControllerTemplateButton down { get; }
	public IControllerTemplateButton downLeft { get; }
	public IControllerTemplateButton left { get; }
	public IControllerTemplateButton upLeft { get; }

	// Methods

	// RVA: 0x19F6F70 Offset: 0x19F6170 VA: 0x1819F6F70
	private void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] ) { }

	// RVA: 0x19F7070 Offset: 0x19F6270 VA: 0x1819F7070
	internal void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib ) { }

	// RVA: 0x19F8310 Offset: 0x19F7510 VA: 0x1819F8310 Slot: 23
	public Vector2 get_value() { }

	// RVA: 0x19F7B50 Offset: 0x19F6D50 VA: 0x1819F7B50 Slot: 24
	public Vector2 get_valuePrev() { }

	// RVA: 0x19F7A60 Offset: 0x19F6C60 VA: 0x1819F7A60 Slot: 25
	public IControllerTemplateButton get_up() { }

	// RVA: 0x19F7970 Offset: 0x19F6B70 VA: 0x1819F7970 Slot: 26
	public IControllerTemplateButton get_upRight() { }

	// RVA: 0x19F7790 Offset: 0x19F6990 VA: 0x1819F7790 Slot: 27
	public IControllerTemplateButton get_right() { }

	// RVA: 0x19F74C0 Offset: 0x19F66C0 VA: 0x1819F74C0 Slot: 28
	public IControllerTemplateButton get_downRight() { }

	// RVA: 0x19F75B0 Offset: 0x19F67B0 VA: 0x1819F75B0 Slot: 29
	public IControllerTemplateButton get_down() { }

	// RVA: 0x19F73D0 Offset: 0x19F65D0 VA: 0x1819F73D0 Slot: 30
	public IControllerTemplateButton get_downLeft() { }

	// RVA: 0x19F76A0 Offset: 0x19F68A0 VA: 0x1819F76A0 Slot: 31
	public IControllerTemplateButton get_left() { }

	// RVA: 0x19F7880 Offset: 0x19F6A80 VA: 0x1819F7880 Slot: 32
	public IControllerTemplateButton get_upLeft() { }
}

// Namespace: 
internal sealed class ControllerTemplate.wZTLSdRmKpcwGbdIeFEIFlvBXYRHA : ControllerTemplate.JOqUKujNCSEqJekksGheGLSYXllIA, IControllerTemplateElement, IControllerTemplateYoke // TypeDefIndex: 6796
{
	// Fields
	private const int rbaZHPFwxVTIbRKTVJEQoGICaYfE = 2;

	// Properties
	public IControllerTemplateAxis rotation { get; }
	public IControllerTemplateAxis pushPull { get; }

	// Methods

	// RVA: 0x19FAC80 Offset: 0x19F9E80 VA: 0x1819FAC80
	private void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] ) { }

	// RVA: 0x19FAB30 Offset: 0x19F9D30 VA: 0x1819FAB30
	internal void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib ) { }

	// RVA: 0x19FADF0 Offset: 0x19F9FF0 VA: 0x1819FADF0 Slot: 29
	public IControllerTemplateAxis get_rotation() { }

	// RVA: 0x19FAD00 Offset: 0x19F9F00 VA: 0x1819FAD00 Slot: 30
	public IControllerTemplateAxis get_pushPull() { }
}

// Namespace: 
internal sealed class ControllerTemplate.KQKcchpXPITOVirIaBHTxNibzCRb : ControllerTemplate.rgAECJFysMBbwnQfZnXsaLxhBBCcb, IControllerTemplateElement, IControllerTemplateStick6D // TypeDefIndex: 6797
{
	// Fields
	private const int rbaZHPFwxVTIbRKTVJEQoGICaYfE = 6;

	// Methods

	// RVA: 0x19EB950 Offset: 0x19EAB50 VA: 0x1819EB950
	private void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.ZqsDUgdrcRNuemHLMuNHMrKDOgyxA[] ) { }

	// RVA: 0x19EB9D0 Offset: 0x19EABD0 VA: 0x1819EB9D0
	internal void .ctor(IControllerTemplate_Internal , int , string , string , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib , ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib ) { }
}

// Namespace: 
internal class ControllerTemplate.wXoZiEQFXLVogjaisIyhDRYDQixz // TypeDefIndex: 6798
{
	// Fields
	public readonly Controller.Element wJPDScqWkzUIZVAHhFjPxmZLlsks; // 0x10
	public readonly IControllerElementTarget mYcefeYukDnqLskArSBAPWvWpplp; // 0x18

	// Properties
	public bool LrbRyzLEFKCQOUOPtHiCeChvmosAA { get; }
	public bool TvXgerUNlLuCZGhsYMBBlCrMsjyn { get; }
	public bool LwSWFfEenoFQEEcghBjciYqqlAec { get; }
	public bool WAGiAqHkASpcWDymigyMtxSFsXUGc { get; }
	public float LJNxoLmpoFBFqTWkOchTiCYysjDx { get; }
	public float BFpiOSkWVGmuyjHRIqeeYNcATLEr { get; }

	// Methods

	// RVA: 0x161DA80 Offset: 0x161CC80 VA: 0x18161DA80
	public void .ctor(IControllerElementTarget , Controller.Element ) { }

	// RVA: 0x19FA9F0 Offset: 0x19F9BF0 VA: 0x1819FA9F0
	public bool uWzBPUfjymiqUQKufLyLVHEAnJeqA() { }

	// RVA: 0x19FA8B0 Offset: 0x19F9AB0 VA: 0x1819FA8B0
	public bool tLePbtuOgHdAzUXWpdgiYDkSeulZ() { }

	// RVA: 0x19FA7E0 Offset: 0x19F99E0 VA: 0x1819FA7E0
	public bool isgMMXxPOOdAvzFJwWKpxyXkfZGe() { }

	// RVA: 0x19FA5D0 Offset: 0x19F97D0 VA: 0x1819FA5D0
	public bool LgJFsxnTxTMkwmwPSetqGYPuVlMt() { }

	// RVA: 0x19FA6A0 Offset: 0x19F98A0 VA: 0x1819FA6A0
	public float dWiFzJeEoTCwGcWTPHdzQpargUPeA() { }

	// RVA: 0x19FA490 Offset: 0x19F9690 VA: 0x1819FA490
	public float JAdrCBnENLTJStqCNhQxARPSAnkUA() { }

	// RVA: 0x19FA3E0 Offset: 0x19F95E0 VA: 0x1819FA3E0
	public static ControllerTemplate.wXoZiEQFXLVogjaisIyhDRYDQixz FwIIDWKNCUcsDcEkbYKpcPYzjmUjb() { }
}

// Namespace: 
internal class ControllerTemplate.ICsbDYGzZMyTEnnTyxYtmNshKyhyA // TypeDefIndex: 6799
{
	// Fields
	public readonly Controller oucSTTgcWofhafDPqHrFgmhNLXuaA; // 0x10
	public readonly IHardwareControllerTemplateMap_Internal tzURWdKSjBEUFbPQaYNMMfHDlmUf; // 0x18

	// Methods

	// RVA: 0x19EA750 Offset: 0x19E9950 VA: 0x1819EA750
	public void .ctor(Controller , IHardwareControllerTemplateMap_Internal ) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ControllerTemplate.xtkbxMkQIgGRAEarIvgrcgcgfwjs.hPCXolAkvtaIZYtBdZYVPLezBHqc // TypeDefIndex: 6800
{
	// Fields
	public static readonly ControllerTemplate.xtkbxMkQIgGRAEarIvgrcgcgfwjs.hPCXolAkvtaIZYtBdZYVPLezBHqc <>9; // 0x0
	public static Func<FaVFYcDpCyvshrEyVMRMxCjPlineb, FaVFYcDpCyvshrEyVMRMxCjPlineb, bool> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x19F67E0 Offset: 0x19F59E0 VA: 0x1819F67E0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x19F6840 Offset: 0x19F5A40 VA: 0x1819F6840
	internal bool hbcorxGebSGWVAXdCpuOmiBRYN(FaVFYcDpCyvshrEyVMRMxCjPlineb , FaVFYcDpCyvshrEyVMRMxCjPlineb ) { }
}

// Namespace: 
private sealed class ControllerTemplate.xtkbxMkQIgGRAEarIvgrcgcgfwjs // TypeDefIndex: 6801
{
	// Fields
	private static ControllerTemplate.xtkbxMkQIgGRAEarIvgrcgcgfwjs UVLGozxGAPPfmLecELzdCiykSygT; // 0x0
	private readonly RBTbtfxxywGQyDGTOxgBUjFHeEtDA<FaVFYcDpCyvshrEyVMRMxCjPlineb> QeVLqlLfKsiVaedHloOvPDTgmMxV; // 0x10

	// Properties
	private static ControllerTemplate.xtkbxMkQIgGRAEarIvgrcgcgfwjs mqkLfedmeRcvYyKvtVwYnkyMiHag { get; }

	// Methods

	// RVA: 0x19FB7C0 Offset: 0x19FA9C0 VA: 0x1819FB7C0
	private static ControllerTemplate.xtkbxMkQIgGRAEarIvgrcgcgfwjs dUqVkBxkvhUZAFBuybiKFczmYXLb() { }

	// RVA: 0x19FB5E0 Offset: 0x19FA7E0 VA: 0x1819FB5E0
	private void .ctor() { }

	// RVA: 0x19FB710 Offset: 0x19FA910 VA: 0x1819FB710
	private void cneJLUqoVILjQOkyKwaOlYsbtCCC() { }

	// RVA: 0x19FB440 Offset: 0x19FA640 VA: 0x1819FB440
	private void KPSfUAGoTAczUoyxgCKaOthRkGmo() { }

	// RVA: 0x19FB500 Offset: 0x19FA700 VA: 0x1819FB500
	public static FaVFYcDpCyvshrEyVMRMxCjPlineb PjrvWYysdnhrOONinazkfAfeuaqX(FaVFYcDpCyvshrEyVMRMxCjPlineb ) { }

	// RVA: 0x19FB340 Offset: 0x19FA540 VA: 0x1819FB340
	public static bool BBzDvtkJMbhpEdyHcGDPFStcUenSc(FaVFYcDpCyvshrEyVMRMxCjPlineb , out FaVFYcDpCyvshrEyVMRMxCjPlineb ) { }

	// RVA: 0x19FBA10 Offset: 0x19FAC10 VA: 0x1819FBA10
	public static void xXDAAgkpHyujExYwkSGAdhBokBcFb(FaVFYcDpCyvshrEyVMRMxCjPlineb ) { }
}

// Namespace: Rewired
public abstract class ControllerTemplate : IControllerTemplate, IControllerTemplate_Internal, ftUiUAiTGSDgAJCvnFpXJSUgtERQ // TypeDefIndex: 6802
{
	// Fields
	private const string gWsanYkjIRiDNxQaCqeJDOlsLFefb = "controller/template";
	private string NsRFUoBLVeZwnSsExKWhwStYeoRV; // 0x10
	private string sKEfXRhGnVSsmWsCqaKxYnjRjSNb; // 0x18
	private int lhWaVPChlXfgMFgLlRTKGxoUGNtgA; // 0x20
	private readonly Guid kBQCwpezNkzOSieVywbtGqWVutgb; // 0x24
	private readonly DeviceLocalizationInfo gDhzIOqcbIAwWxsdDHyTeeoAKNufA; // 0x38
	private readonly Controller MjXwpaWgoFbhLALGDhNxlBElkuGl; // 0x40
	private readonly ADictionary<int, IControllerTemplateElement> vhJUQfFLMFsGfWeHcAXohuizoZbfb; // 0x48
	private readonly ADictionary<string, IControllerTemplateElement> PJsfrUccxmYdHSchFBpgezfghTKFA; // 0x50
	private IControllerTemplateElement[] ZdSpjvRkgdsTMzWPFjtUndkXnkT; // 0x58
	private ReadOnlyCollection<IControllerTemplateElement> pWquskIZiDEOlilKSzVSUWvspUFo; // 0x60
	private readonly wxuBbaUjSloOlQfOCemKEVemgTdMA gEeATosTQCMbHLilWWJWbUSEBdYj; // 0x68
	private readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x70

	// Properties
	internal DeviceLocalizationInfo DyhYKswIsYTMkLaZOFRqjWShNSLB { get; }
	private DeviceLocalizationInfo Rewired.IControllerTemplate_Internal.deviceLocalizationInfo { get; }
	private Controller Rewired.IControllerTemplate.controller { get; }
	private string Rewired.IControllerTemplate.name { get; }
	private Guid Rewired.IControllerTemplate.typeGuid { get; }
	private IList<IControllerTemplateElement> Rewired.IControllerTemplate.elements { get; }
	private int Rewired.IControllerTemplate.elementCount { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }

	// Methods

	// RVA: 0x19E9B20 Offset: 0x19E8D20 VA: 0x1819E9B20
	protected void .ctor(object ) { }

	// RVA: 0x19E7B30 Offset: 0x19E6D30 VA: 0x1819E7B30
	private void .ctor(ControllerTemplate.ICsbDYGzZMyTEnnTyxYtmNshKyhyA ) { }

	// RVA: 0x19E7000 Offset: 0x19E6200 VA: 0x1819E7000
	protected IControllerTemplateElement GetElement(int id) { }

	// RVA: -1 Offset: -1
	protected T GetElement<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F690 Offset: 0x94E890 VA: 0x18094F690
	|-ControllerTemplate.GetElement<object>
	*/

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal DeviceLocalizationInfo myyrQRlHuLFScTohceelWDMdatUC() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 12
	private DeviceLocalizationInfo Rewired.IControllerTemplate_Internal.get_deviceLocalizationInfo() { }

	// RVA: 0x19E76B0 Offset: 0x19E68B0 VA: 0x1819E76B0 Slot: 4
	private Controller Rewired.IControllerTemplate.get_controller() { }

	// RVA: 0x19E7870 Offset: 0x19E6A70 VA: 0x1819E7870 Slot: 5
	private string Rewired.IControllerTemplate.get_name() { }

	// RVA: 0x19E7930 Offset: 0x19E6B30 VA: 0x1819E7930 Slot: 6
	private Guid Rewired.IControllerTemplate.get_typeGuid() { }

	// RVA: 0x19E77E0 Offset: 0x19E69E0 VA: 0x1819E77E0 Slot: 7
	private IList<IControllerTemplateElement> Rewired.IControllerTemplate.get_elements() { }

	// RVA: 0x19E7740 Offset: 0x19E6940 VA: 0x1819E7740 Slot: 8
	private int Rewired.IControllerTemplate.get_elementCount() { }

	// RVA: 0x19E74C0 Offset: 0x19E66C0 VA: 0x1819E74C0 Slot: 9
	private IControllerTemplateElement Rewired.IControllerTemplate.GetElement(int id) { }

	// RVA: -1 Offset: -1 Slot: 10
	private T Rewired.IControllerTemplate.GetElement<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F740 Offset: 0x94E940 VA: 0x18094F740
	|-ControllerTemplate.Rewired.IControllerTemplate.GetElement<object>
	*/

	// RVA: 0x19E73B0 Offset: 0x19E65B0 VA: 0x1819E73B0 Slot: 11
	private int Rewired.IControllerTemplate.GetElementTargets(ControllerElementTarget find, IList<ControllerTemplateElementTarget> results) { }

	// RVA: 0x19E79F0 Offset: 0x19E6BF0 VA: 0x1819E79F0 Slot: 13
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x19E7A20 Offset: 0x19E6C20 VA: 0x1819E7A20 Slot: 14
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 15
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 16
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 17
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 18
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420 Slot: 19
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x19E6E00 Offset: 0x19E6000 VA: 0x1819E6E00
	private int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> results) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19E7160 Offset: 0x19E6360 VA: 0x1819E7160
	internal static Type GetInterfaceType(ControllerTemplateElementType elementType) { }

	// RVA: 0x19E9BC0 Offset: 0x19E8DC0 VA: 0x1819E9BC0
	private static IList<ControllerTemplate.wXoZiEQFXLVogjaisIyhDRYDQixz> urvrmnDjnKKkiCrMgArissyTbhGB(Controller , IControllerTemplateAxisSource ) { }

	// RVA: 0x19E9E30 Offset: 0x19E9030 VA: 0x1819E9E30
	private static IList<ControllerTemplate.wXoZiEQFXLVogjaisIyhDRYDQixz> urvrmnDjnKKkiCrMgArissyTbhGB(Controller , IControllerTemplateButtonSource ) { }

	// RVA: 0x19E9EA0 Offset: 0x19E90A0 VA: 0x1819E9EA0
	private static IList<ControllerTemplate.wXoZiEQFXLVogjaisIyhDRYDQixz> urvrmnDjnKKkiCrMgArissyTbhGB(Controller , IControllerElementTarget ) { }

	// RVA: 0x19E7A60 Offset: 0x19E6C60 VA: 0x1819E7A60
	private static IControllerTemplateElement SOyEZlaOZnmtToqrBQwaSSVmHYjYA(List<IControllerTemplateElement> , int ) { }

	// RVA: 0x19EA010 Offset: 0x19E9210 VA: 0x1819EA010
	private static ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib vHNRSNglGtpCPLdNLxWkEZUTgUCD(IControllerTemplate_Internal , ADictionary<int, IControllerTemplateElement> , int ) { }

	// RVA: 0x19E72F0 Offset: 0x19E64F0 VA: 0x1819E72F0
	private static ControllerTemplate.RLttDhslzcUpqjBOeEVUcBadRfRib GuUJHJvayeaOkWrFtWBeDyUMOLnh(IControllerTemplate_Internal , ADictionary<int, IControllerTemplateElement> , int ) { }
}

// Namespace: Rewired
public abstract class ControllerTemplateActionElementMap // TypeDefIndex: 6803
{
	// Fields
	private readonly int yAQloNnkxShCOoclhwMCxCpNptHE; // 0x10
	private readonly ControllerTemplateElementType ttqdXLdpzPeIRrBGzxvaiwBbWePS; // 0x14
	private bool AqHaORMjZGTdLoJMHbRKCeXHvJfRA; // 0x18
	private int pFIFvsDSemlQRdLPLVmAuFVFNKGkA; // 0x1C
	private int dloXlVErIzRNttSTwpuctPZXBqjHA; // 0x20
	private static int ZFjxkyMhczitHBKJwjqlcsvvPKdTA; // 0x0

	// Properties
	public int id { get; }
	public ControllerTemplateElementType elementType { get; }
	public bool enabled { get; set; }
	public int actionId { get; set; }
	public int elementIdentifierId { get; set; }

	// Methods

	// RVA: 0x19E4100 Offset: 0x19E3300 VA: 0x1819E4100
	internal void .ctor(ControllerTemplateElementType ) { }

	// RVA: 0x19E4030 Offset: 0x19E3230 VA: 0x1819E4030
	internal void .ctor(ControllerTemplateElementType , int , ActionElementMap ) { }

	// RVA: 0x19E40C0 Offset: 0x19E32C0 VA: 0x1819E40C0
	internal void .ctor(ControllerTemplateElementType , int , int , bool ) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor(ActionElementMap ) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_id() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ControllerTemplateElementType get_elementType() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_enabled() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_enabled(bool value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_actionId() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_actionId(int value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_elementIdentifierId() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_elementIdentifierId(int value) { }

	// RVA: 0x19E4200 Offset: 0x19E3400 VA: 0x1819E4200
	internal int bVNbnZsxGZtLfOlXyQafIYiKvKxH(IControllerTemplate , List<ActionElementMap> , bool ) { }

	// RVA: 0x19E4460 Offset: 0x19E3660 VA: 0x1819E4460
	internal SerializedObject dDwdeldWYOLrnWiNJjDBHtCWImLzA() { }

	// RVA: 0x19E44F0 Offset: 0x19E36F0 VA: 0x1819E44F0 Slot: 4
	internal virtual void dDwdeldWYOLrnWiNJjDBHtCWImLzA(SerializedObject ) { }

	// RVA: 0x19E3A20 Offset: 0x19E2C20 VA: 0x1819E3A20 Slot: 5
	internal virtual void MQHErEylLpkabJiPJFPMzIMISIct(SerializedObject ) { }

	// RVA: 0x19E4610 Offset: 0x19E3810 VA: 0x1819E4610 Slot: 6
	internal virtual void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract int IaNKBGldazwqZmonVcMeYNQOcsseA(IControllerTemplateElementSource , List<ActionElementMap> , bool );

	// RVA: 0x19E4620 Offset: 0x19E3820 VA: 0x1819E4620
	private int mcYOnwUOTsDdSHkOPPVqqlcyerYo(IControllerTemplate , List<ActionElementMap> , bool ) { }

	// RVA: 0x19E3F00 Offset: 0x19E3100 VA: 0x1819E3F00
	internal static ControllerTemplateActionElementMap TZpAtmoswOXHtgELCQOweYKzFlBS(SerializedObject ) { }

	// RVA: 0x19E3CD0 Offset: 0x19E2ED0 VA: 0x1819E3CD0
	internal static ControllerTemplateActionElementMap TZpAtmoswOXHtgELCQOweYKzFlBS(ControllerTemplateElementTarget , ActionElementMap ) { }

	// RVA: 0x19E3B00 Offset: 0x19E2D00 VA: 0x1819E3B00
	internal static ControllerTemplateActionElementMap TZpAtmoswOXHtgELCQOweYKzFlBS(ActionElementMap ) { }
}

// Namespace: Rewired
public sealed class ControllerTemplateActionButtonMap : ControllerTemplateActionElementMap // TypeDefIndex: 6804
{
	// Fields
	private Pole YSoMBksWRLBGZHCoCnDDYNsLEJls; // 0x28

	// Properties
	public Pole axisContribution { get; }

	// Methods

	// RVA: 0x19E3810 Offset: 0x19E2A10 VA: 0x1819E3810
	internal void .ctor(SerializedObject ) { }

	// RVA: 0x19E3900 Offset: 0x19E2B00 VA: 0x1819E3900
	internal void .ctor(int , ActionElementMap ) { }

	// RVA: 0x19E38A0 Offset: 0x19E2AA0 VA: 0x1819E38A0
	internal void .ctor(int , int , Pole , bool ) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public Pole get_axisContribution() { }

	// RVA: 0x19E39A0 Offset: 0x19E2BA0 VA: 0x1819E39A0 Slot: 4
	internal override void dDwdeldWYOLrnWiNJjDBHtCWImLzA(SerializedObject ) { }

	// RVA: 0x19E3790 Offset: 0x19E2990 VA: 0x1819E3790 Slot: 5
	internal override void MQHErEylLpkabJiPJFPMzIMISIct(SerializedObject ) { }

	// RVA: 0x7C5D40 Offset: 0x7C4F40 VA: 0x1807C5D40 Slot: 6
	internal override void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x19E3600 Offset: 0x19E2800 VA: 0x1819E3600 Slot: 7
	internal override int IaNKBGldazwqZmonVcMeYNQOcsseA(IControllerTemplateElementSource , List<ActionElementMap> , bool ) { }

	// RVA: 0x19E34E0 Offset: 0x19E26E0 VA: 0x1819E34E0
	private ActionElementMap DMNsAuDLvulmeqnaijGOAqtHbXpFA(IControllerElementTarget , Pole ) { }
}

// Namespace: Rewired
public sealed class ControllerTemplateActionAxisMap : ControllerTemplateActionElementMap // TypeDefIndex: 6805
{
	// Fields
	private AxisRange TauCMpZmUrXMDAWUBhzVJIReyAVJ; // 0x28
	private Pole YSoMBksWRLBGZHCoCnDDYNsLEJls; // 0x2C
	private bool azfyOHWZqrmZRByfZIMBdPQxMYGB; // 0x30

	// Properties
	public AxisRange axisRange { get; }
	public Pole axisContribution { get; }
	public bool invert { get; }

	// Methods

	// RVA: 0x19E3190 Offset: 0x19E2390 VA: 0x1819E3190
	internal void .ctor(SerializedObject ) { }

	// RVA: 0x19E30E0 Offset: 0x19E22E0 VA: 0x1819E30E0
	internal void .ctor(int , AxisRange , ActionElementMap ) { }

	// RVA: 0x19E3220 Offset: 0x19E2420 VA: 0x1819E3220
	internal void .ctor(int , int , AxisRange , Pole , bool , bool ) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public AxisRange get_axisRange() { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public Pole get_axisContribution() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_invert() { }

	// RVA: 0x19E3280 Offset: 0x19E2480 VA: 0x1819E3280 Slot: 4
	internal override void dDwdeldWYOLrnWiNJjDBHtCWImLzA(SerializedObject ) { }

	// RVA: 0x19E2ED0 Offset: 0x19E20D0 VA: 0x1819E2ED0 Slot: 5
	internal override void MQHErEylLpkabJiPJFPMzIMISIct(SerializedObject ) { }

	// RVA: 0x19E3380 Offset: 0x19E2580 VA: 0x1819E3380 Slot: 6
	internal override void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x19E2CB0 Offset: 0x19E1EB0 VA: 0x1819E2CB0 Slot: 7
	internal override int IaNKBGldazwqZmonVcMeYNQOcsseA(IControllerTemplateElementSource , List<ActionElementMap> , bool ) { }

	// RVA: 0x19E3390 Offset: 0x19E2590 VA: 0x1819E3390
	private ActionElementMap jrnWlhbDmTaHgSifwjiSuyUVwaW(IControllerElementTarget , AxisRange , Pole ) { }

	// RVA: 0x19E2FB0 Offset: 0x19E21B0 VA: 0x1819E2FB0
	private ActionElementMap OtFQWyJPDnciYxQlVNGVlcOtjErbA(IControllerElementTarget , Pole , Pole ) { }
}

// Namespace: 
internal sealed class jDCySwCSAVHKuUnPmaQCBczTSqylA : IControllerTemplateElementSource, IControllerTemplateAxisSource, IControllerTemplateButtonSource // TypeDefIndex: 6806
{
	// Fields
	private ControllerTemplateElementType ttqdXLdpzPeIRrBGzxvaiwBbWePS; // 0x10
	private bool YRvlxuZXRlfZzTpMwySrFDuaJFXC; // 0x14
	private IControllerElementTarget aGdmGXiGhrYsfydTWTVhHYKVxvGl; // 0x18
	private IControllerElementTarget jbEhxJirwqPMbLpVYNwCnrjuTbyVA; // 0x20
	private IControllerElementTarget qpyAGMamfgglaCRTehGbxiJqwBDKA; // 0x28

	// Properties
	private ControllerTemplateElementSourceType Rewired.IControllerTemplateElementSource.type { get; }
	private bool Rewired.IControllerTemplateAxisSource.splitAxis { get; }
	private IControllerElementTarget Rewired.IControllerTemplateAxisSource.fullTarget { get; }
	private IControllerElementTarget Rewired.IControllerTemplateAxisSource.positiveTarget { get; }
	private IControllerElementTarget Rewired.IControllerTemplateAxisSource.negativeTarget { get; }
	private IControllerElementTarget Rewired.IControllerTemplateButtonSource.target { get; }

	// Methods

	// RVA: 0x19F69D0 Offset: 0x19F5BD0 VA: 0x1819F69D0
	internal void .ctor(ControllerTemplateElementType , bool , IControllerElementTarget , IControllerElementTarget , IControllerElementTarget ) { }

	// RVA: 0x19F69C0 Offset: 0x19F5BC0 VA: 0x1819F69C0 Slot: 4
	private ControllerTemplateElementSourceType Rewired.IControllerTemplateElementSource.get_type() { }

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30 Slot: 5
	private bool Rewired.IControllerTemplateAxisSource.get_splitAxis() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private IControllerElementTarget Rewired.IControllerTemplateAxisSource.get_fullTarget() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 7
	private IControllerElementTarget Rewired.IControllerTemplateAxisSource.get_positiveTarget() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	private IControllerElementTarget Rewired.IControllerTemplateAxisSource.get_negativeTarget() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private IControllerElementTarget Rewired.IControllerTemplateButtonSource.get_target() { }

	// RVA: 0x19F6870 Offset: 0x19F5A70 VA: 0x1819F6870
	internal static jDCySwCSAVHKuUnPmaQCBczTSqylA FwIIDWKNCUcsDcEkbYKpcPYzjmUjb(ControllerTemplateElementType ) { }
}

// Namespace: Rewired
public struct ControllerTemplateElementTarget // TypeDefIndex: 6807
{
	// Fields
	private IControllerTemplateElement tsdfIdOVBMGVIUvqPzbMSybZCWnq; // 0x0
	private AxisRange TauCMpZmUrXMDAWUBhzVJIReyAVJ; // 0x8

	// Properties
	public AxisRange axisRange { get; set; }
	public ControllerTemplateElementType elementType { get; }
	public string descriptiveName { get; }
	public IControllerTemplateElement element { get; set; }
	public IControllerTemplate template { get; }
	public bool hasTarget { get; }

	// Methods

	// RVA: 0x19E4780 Offset: 0x19E3980 VA: 0x1819E4780
	internal void .ctor(IControllerTemplateElement , AxisRange ) { }

	// RVA: 0x19E2AD0 Offset: 0x19E1CD0 VA: 0x1819E2AD0
	public void .ctor(ControllerTemplateElementTarget ) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public AxisRange get_axisRange() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_axisRange(AxisRange value) { }

	// RVA: 0x19E4A20 Offset: 0x19E3C20 VA: 0x1819E4A20
	public ControllerTemplateElementType get_elementType() { }

	// RVA: 0x19E47F0 Offset: 0x19E39F0 VA: 0x1819E47F0
	public string get_descriptiveName() { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IControllerTemplateElement get_element() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_element(IControllerTemplateElement value) { }

	// RVA: 0x19E4A70 Offset: 0x19E3C70 VA: 0x1819E4A70
	public IControllerTemplate get_template() { }

	// RVA: 0x180B7A0 Offset: 0x180A9A0 VA: 0x18180B7A0
	public bool get_hasTarget() { }
}

// Namespace: Rewired
public struct ControllerElementTarget // TypeDefIndex: 6808
{
	// Fields
	private Controller.Element tsdfIdOVBMGVIUvqPzbMSybZCWnq; // 0x0
	private AxisRange TauCMpZmUrXMDAWUBhzVJIReyAVJ; // 0x8

	// Properties
	public int elementIdentifierId { get; }
	public AxisRange axisRange { get; set; }
	public bool hasTarget { get; }
	public ControllerElementType elementType { get; }
	public string descriptiveName { get; }
	public Controller controller { get; }
	public Controller.Element element { get; set; }

	// Methods

	// RVA: 0x19E2980 Offset: 0x19E1B80 VA: 0x1819E2980
	public void .ctor(ActionElementMap ) { }

	// RVA: 0x19E2AD0 Offset: 0x19E1CD0 VA: 0x1819E2AD0
	public void .ctor(ControllerElementTarget ) { }

	// RVA: 0x19E2AE0 Offset: 0x19E1CE0 VA: 0x1819E2AE0
	public void .ctor(IControllerElementTarget ) { }

	// RVA: 0x19E2C40 Offset: 0x19E1E40 VA: 0x1819E2C40
	public int get_elementIdentifierId() { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public AxisRange get_axisRange() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_axisRange(AxisRange value) { }

	// RVA: 0x180B7A0 Offset: 0x180A9A0 VA: 0x18180B7A0
	public bool get_hasTarget() { }

	// RVA: 0x19E2C60 Offset: 0x19E1E60 VA: 0x1819E2C60
	public ControllerElementType get_elementType() { }

	// RVA: 0x19E2BC0 Offset: 0x19E1DC0 VA: 0x1819E2BC0
	public string get_descriptiveName() { }

	// RVA: 0x19E2BA0 Offset: 0x19E1DA0 VA: 0x1819E2BA0
	public Controller get_controller() { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Controller.Element get_element() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_element(Controller.Element value) { }

	// RVA: 0x19E2C70 Offset: 0x19E1E70 VA: 0x1819E2C70
	public static ControllerElementTarget op_Implicit(ActionElementMap actionElementMap) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CnSIGqGRGpRxFeYHoKnvWOiZFlaDA.cKzkQybaZkpOHjaTJiAiZPlKDMCd // TypeDefIndex: 6809
{
	// Fields
	public static readonly CnSIGqGRGpRxFeYHoKnvWOiZFlaDA.cKzkQybaZkpOHjaTJiAiZPlKDMCd <>9; // 0x0
	public static Func<CnSIGqGRGpRxFeYHoKnvWOiZFlaDA> <>9__30_0; // 0x8

	// Methods

	// RVA: 0x19F6780 Offset: 0x19F5980 VA: 0x1819F6780
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x19E1F80 Offset: 0x19E1180 VA: 0x1819E1F80
	internal CnSIGqGRGpRxFeYHoKnvWOiZFlaDA QUHSyDJWffkjCegLynZWnKOZWmJg() { }
}

// Namespace: 
internal sealed class CnSIGqGRGpRxFeYHoKnvWOiZFlaDA : IDisposable, IControllerElementTarget, IPoolableObject, IPoolableObject_Internal // TypeDefIndex: 6810
{
	// Fields
	private static ObjectPool<CnSIGqGRGpRxFeYHoKnvWOiZFlaDA> hLBvRkcbCuNHxTKkcvIeVmnCNGIl; // 0x0
	private Controller MjXwpaWgoFbhLALGDhNxlBElkuGl; // 0x10
	private int dloXlVErIzRNttSTwpuctPZXBqjHA; // 0x18
	private AxisRange TauCMpZmUrXMDAWUBhzVJIReyAVJ; // 0x1C
	private IObjectPool xSfhNEgSkwmkFwiOGXVcHGOUNZXc; // 0x20
	private bool qlWbbXXJkXhrJOhRVlcxNUPVUYEt; // 0x28

	// Properties
	public int elementIdentifierId { get; }
	public AxisRange axisRange { get; }
	public bool hasTarget { get; }
	public ControllerElementType elementType { get; }
	public string descriptiveName { get; }
	public Controller controller { get; }
	public Controller.Element element { get; }
	public ControllerElementIdentifier XIoMDdHETwAsAEuLqKtUisDnpcWJA { get; }
	private IObjectPool Rewired.Utils.Classes.Utility.IPoolableObject_Internal.pool { get; set; }

	// Methods

	// RVA: 0x6BFA00 Offset: 0x6BEC00 VA: 0x1806BFA00
	internal void .ctor(Controller , int , AxisRange ) { }

	// RVA: 0x19E1FE0 Offset: 0x19E11E0 VA: 0x1819E1FE0
	internal void MQHErEylLpkabJiPJFPMzIMISIct(ControllerElementTarget ) { }

	// RVA: 0x19E2020 Offset: 0x19E1220 VA: 0x1819E2020
	internal void MQHErEylLpkabJiPJFPMzIMISIct(IControllerElementTarget ) { }

	// RVA: 0x19E2020 Offset: 0x19E1220 VA: 0x1819E2020
	internal void MQHErEylLpkabJiPJFPMzIMISIct(CnSIGqGRGpRxFeYHoKnvWOiZFlaDA ) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 5
	public int get_elementIdentifierId() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 6
	public AxisRange get_axisRange() { }

	// RVA: 0x19E2560 Offset: 0x19E1760 VA: 0x1819E2560 Slot: 7
	public bool get_hasTarget() { }

	// RVA: 0x19E2450 Offset: 0x19E1650 VA: 0x1819E2450 Slot: 8
	public ControllerElementType get_elementType() { }

	// RVA: 0x19E2380 Offset: 0x19E1580 VA: 0x1819E2380 Slot: 9
	public string get_descriptiveName() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 10
	public Controller get_controller() { }

	// RVA: 0x19E2500 Offset: 0x19E1700 VA: 0x1819E2500 Slot: 11
	public Controller.Element get_element() { }

	// RVA: 0x19E2360 Offset: 0x19E1560 VA: 0x1819E2360
	public ControllerElementIdentifier bsGFIHxgTfXWwXcApRiRuUpYWNfJ() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 13
	private IObjectPool tUWMthTJoAFZLWJvFNJwfuVVqFDy() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0 Slot: 14
	private void aiuyZDXtGaTPZKPWmTvZWFOsjocI(IObjectPool ) { }

	// RVA: 0x19E2340 Offset: 0x19E1540 VA: 0x1819E2340 Slot: 15
	private void ZHbBjlMCMQeGGznpgTqtLcTaoTmV() { }

	// RVA: 0x19E2180 Offset: 0x19E1380 VA: 0x1819E2180 Slot: 12
	private void Rewired.Interfaces.IPoolableObject.Return() { }

	// RVA: 0x19E2800 Offset: 0x19E1A00 VA: 0x1819E2800
	internal static CnSIGqGRGpRxFeYHoKnvWOiZFlaDA zfWQkpcYObhqoQiABIxQbQoqCVxq() { }

	// RVA: 0x19E2640 Offset: 0x19E1840 VA: 0x1819E2640
	internal static CnSIGqGRGpRxFeYHoKnvWOiZFlaDA zfWQkpcYObhqoQiABIxQbQoqCVxq(ControllerElementTarget ) { }

	// RVA: 0x19E25D0 Offset: 0x19E17D0 VA: 0x1819E25D0
	internal static void woAOfEFSLTcovhpLNoKGbkMKQcOCB(CnSIGqGRGpRxFeYHoKnvWOiZFlaDA ) { }

	// RVA: 0x19E1F80 Offset: 0x19E1180 VA: 0x1819E1F80
	internal static CnSIGqGRGpRxFeYHoKnvWOiZFlaDA FwIIDWKNCUcsDcEkbYKpcPYzjmUjb() { }

	// RVA: 0x19E22C0 Offset: 0x19E14C0 VA: 0x1819E22C0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19E2240 Offset: 0x19E1440 VA: 0x1819E2240 Slot: 1
	protected override void SnyTHacbnnYzPrlQoFnKzkJtcRbdA() { }

	// RVA: 0x19E2120 Offset: 0x19E1320 VA: 0x1819E2120
	private void QKEYycJGvyEZCdnUfkbohEkzVpV(bool ) { }
}

// Namespace: Rewired
public enum ControllerTemplateElementType // TypeDefIndex: 6811
{
	// Fields
	public int value__; // 0x0
	public const ControllerTemplateElementType Axis = 0;
	public const ControllerTemplateElementType Button = 1;
	public const ControllerTemplateElementType ThumbStick = 2;
	public const ControllerTemplateElementType DPad = 4;
	public const ControllerTemplateElementType Stick = 5;
	public const ControllerTemplateElementType Throttle = 6;
	public const ControllerTemplateElementType Hat = 7;
	public const ControllerTemplateElementType Yoke = 8;
	public const ControllerTemplateElementType Stick6D = 9;
}

// Namespace: Rewired
public enum ControllerTemplateElementSourceType // TypeDefIndex: 6812
{
	// Fields
	public int value__; // 0x0
	public const ControllerTemplateElementSourceType Axis = 0;
	public const ControllerTemplateElementSourceType Button = 1;
}

// Namespace: Rewired
public interface IControllerTemplate // TypeDefIndex: 6813
{
	// Properties
	public abstract Controller controller { get; }
	public abstract string name { get; }
	public abstract Guid typeGuid { get; }
	public abstract IList<IControllerTemplateElement> elements { get; }
	public abstract int elementCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Controller get_controller();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Guid get_typeGuid();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IList<IControllerTemplateElement> get_elements();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_elementCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateElement GetElement(int id);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract T GetElement<T>(int id);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IControllerTemplate.GetElement<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetElementTargets(ControllerElementTarget target, IList<ControllerTemplateElementTarget> results);
}

// Namespace: Rewired
public interface IControllerTemplateElement // TypeDefIndex: 6814
{
	// Properties
	public abstract int id { get; }
	public abstract string descriptiveName { get; }
	public abstract ControllerTemplateElementType type { get; }
	public abstract bool exists { get; }
	public abstract IControllerTemplateElementSource source { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_id();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_descriptiveName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ControllerTemplateElementType get_type();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_exists();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateElementSource get_source();
}

// Namespace: Rewired
public interface IControllerTemplateButton : IControllerTemplateElement // TypeDefIndex: 6815
{
	// Properties
	public abstract bool value { get; }
	public abstract bool valuePrev { get; }
	public abstract float pressure { get; }
	public abstract float pressurePrev { get; }
	public abstract bool justPressed { get; }
	public abstract bool justReleased { get; }
	public abstract bool justChangedState { get; }
	public abstract IControllerTemplateButtonSource source { get; }
	public abstract IControllerTemplateAxis AsAxis { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_pressure();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_pressurePrev();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_justPressed();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_justReleased();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_justChangedState();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButtonSource get_source();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateAxis get_AsAxis();
}

// Namespace: Rewired
public interface IControllerTemplateAxis : IControllerTemplateElement // TypeDefIndex: 6816
{
	// Properties
	public abstract string positiveDescriptiveName { get; }
	public abstract string negativeDescriptiveName { get; }
	public abstract float value { get; }
	public abstract float valuePrev { get; }
	public abstract IControllerTemplateAxisSource source { get; }
	public abstract IControllerTemplateButton AsButton { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_positiveDescriptiveName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_negativeDescriptiveName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetDescriptiveName(AxisRange axisRange);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_value();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateAxisSource get_source();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_AsButton();
}

// Namespace: Rewired
public interface IControllerTemplateStick : IControllerTemplateElement // TypeDefIndex: 6817
{
	// Properties
	public abstract Vector3 value { get; }
	public abstract Vector3 valuePrev { get; }
	public abstract IControllerTemplateAxis horizontal { get; }
	public abstract IControllerTemplateAxis vertical { get; }
	public abstract IControllerTemplateAxis rotation { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_horizontal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_vertical();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateAxis get_rotation();
}

// Namespace: Rewired
public interface IControllerTemplateThumbStick : IControllerTemplateElement // TypeDefIndex: 6818
{
	// Properties
	public abstract Vector2 value { get; }
	public abstract Vector2 valuePrev { get; }
	public abstract IControllerTemplateAxis horizontal { get; }
	public abstract IControllerTemplateAxis vertical { get; }
	public abstract IControllerTemplateButton press { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_horizontal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_vertical();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_press();
}

// Namespace: Rewired
public interface IControllerTemplateDPad : IControllerTemplateElement // TypeDefIndex: 6819
{
	// Properties
	public abstract Vector2 value { get; }
	public abstract Vector2 valuePrev { get; }
	public abstract IControllerTemplateButton up { get; }
	public abstract IControllerTemplateButton right { get; }
	public abstract IControllerTemplateButton down { get; }
	public abstract IControllerTemplateButton left { get; }
	public abstract IControllerTemplateButton press { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateButton get_up();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_right();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_down();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_left();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_press();
}

// Namespace: Rewired
public interface IControllerTemplateThrottle : IControllerTemplateElement // TypeDefIndex: 6820
{
	// Properties
	public abstract float value { get; }
	public abstract float valuePrev { get; }
	public abstract IControllerTemplateAxis throttle { get; }
	public abstract IControllerTemplateButton minDetent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_throttle();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_minDetent();
}

// Namespace: Rewired
public interface IControllerTemplateHat : IControllerTemplateElement // TypeDefIndex: 6821
{
	// Properties
	public abstract Vector2 value { get; }
	public abstract Vector2 valuePrev { get; }
	public abstract IControllerTemplateButton up { get; }
	public abstract IControllerTemplateButton upRight { get; }
	public abstract IControllerTemplateButton right { get; }
	public abstract IControllerTemplateButton downRight { get; }
	public abstract IControllerTemplateButton down { get; }
	public abstract IControllerTemplateButton downLeft { get; }
	public abstract IControllerTemplateButton left { get; }
	public abstract IControllerTemplateButton upLeft { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateButton get_up();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_upRight();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_right();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_downRight();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_down();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_downLeft();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_left();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_upLeft();
}

// Namespace: Rewired
public interface IControllerTemplateYoke : IControllerTemplateElement // TypeDefIndex: 6822
{
	// Properties
	public abstract Vector2 value { get; }
	public abstract Vector2 valuePrev { get; }
	public abstract IControllerTemplateAxis rotation { get; }
	public abstract IControllerTemplateAxis pushPull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_rotation();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_pushPull();
}

// Namespace: Rewired
public interface IControllerTemplateStick6D : IControllerTemplateElement // TypeDefIndex: 6823
{
	// Properties
	public abstract Vector3 position { get; }
	public abstract Vector3 positionPrev { get; }
	public abstract Vector3 rotation { get; }
	public abstract Vector3 rotationPrev { get; }
	public abstract IControllerTemplateAxis positionX { get; }
	public abstract IControllerTemplateAxis positionY { get; }
	public abstract IControllerTemplateAxis positionZ { get; }
	public abstract IControllerTemplateAxis rotationX { get; }
	public abstract IControllerTemplateAxis rotationY { get; }
	public abstract IControllerTemplateAxis rotationZ { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 get_position();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 get_positionPrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector3 get_rotation();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Vector3 get_rotationPrev();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateAxis get_positionX();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateAxis get_positionY();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateAxis get_positionZ();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateAxis get_rotationX();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateAxis get_rotationY();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateAxis get_rotationZ();
}

// Namespace: Rewired
public interface IControllerTemplateElementSource // TypeDefIndex: 6824
{
	// Properties
	public abstract ControllerTemplateElementSourceType type { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ControllerTemplateElementSourceType get_type();
}

// Namespace: Rewired
public interface IControllerTemplateAxisSource : IControllerTemplateElementSource // TypeDefIndex: 6825
{
	// Properties
	public abstract bool splitAxis { get; }
	public abstract IControllerElementTarget fullTarget { get; }
	public abstract IControllerElementTarget positiveTarget { get; }
	public abstract IControllerElementTarget negativeTarget { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_splitAxis();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerElementTarget get_fullTarget();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerElementTarget get_positiveTarget();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerElementTarget get_negativeTarget();
}

// Namespace: Rewired
public interface IControllerTemplateButtonSource : IControllerTemplateElementSource // TypeDefIndex: 6826
{
	// Properties
	public abstract IControllerElementTarget target { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerElementTarget get_target();
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IControllerTemplateAxis2D : IControllerTemplateElement // TypeDefIndex: 6827
{
	// Properties
	public abstract Vector2 value { get; }
	public abstract Vector2 valuePrev { get; }
	public abstract IControllerTemplateAxis horizontal { get; }
	public abstract IControllerTemplateAxis vertical { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_horizontal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_vertical();
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IControllerTemplateAxis3D : IControllerTemplateElement // TypeDefIndex: 6828
{
	// Properties
	public abstract Vector3 value { get; }
	public abstract Vector3 valuePrev { get; }
	public abstract IControllerTemplateAxis horizontal { get; }
	public abstract IControllerTemplateAxis vertical { get; }
	public abstract IControllerTemplateAxis depth { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_horizontal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_vertical();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateAxis get_depth();
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IControllerTemplateAxis6D : IControllerTemplateElement // TypeDefIndex: 6829
{
	// Properties
	public abstract Vector3 position { get; }
	public abstract Vector3 positionPrev { get; }
	public abstract Vector3 rotation { get; }
	public abstract Vector3 rotationPrev { get; }
	public abstract IControllerTemplateAxis positionX { get; }
	public abstract IControllerTemplateAxis positionY { get; }
	public abstract IControllerTemplateAxis positionZ { get; }
	public abstract IControllerTemplateAxis rotationX { get; }
	public abstract IControllerTemplateAxis rotationY { get; }
	public abstract IControllerTemplateAxis rotationZ { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 get_position();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 get_positionPrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector3 get_rotation();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Vector3 get_rotationPrev();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateAxis get_positionX();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateAxis get_positionY();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateAxis get_positionZ();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateAxis get_rotationX();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateAxis get_rotationY();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateAxis get_rotationZ();
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IControllerTemplateElement_Internal // TypeDefIndex: 6830
{
	// Properties
	public abstract IControllerTemplate parent { get; }
	public abstract int elementCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplate get_parent();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_elementCount();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateElement GetElement(int index);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list);
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IControllerTemplate_Internal : IControllerTemplate // TypeDefIndex: 6831
{
	// Properties
	public abstract DeviceLocalizationInfo deviceLocalizationInfo { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DeviceLocalizationInfo get_deviceLocalizationInfo();
}

// Namespace: Rewired
public class ControllerTemplateMap // TypeDefIndex: 6832
{
	// Fields
	private readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x10
	private readonly int yAQloNnkxShCOoclhwMCxCpNptHE; // 0x14
	private readonly Guid IMPwAtVTGPiOBynFfnrFVsXqsEMb; // 0x18
	private readonly List<ControllerTemplateActionElementMap> BBMqDBHbjWjUpVErZgMsirjXoeHm; // 0x28
	private readonly ReadOnlyCollection<ControllerTemplateActionElementMap> mcgFpyEhJujQRffYWtEEQKLcaxNQ; // 0x30
	private bool AqHaORMjZGTdLoJMHbRKCeXHvJfRA; // 0x38
	private int SYiCAEAKsjvCSpVgcZytTbhciMRHA; // 0x3C
	private int fgBdvqArnypsIkvbhrmwPUYhcOGeb; // 0x40
	private int CVDclwiDBJZnBvdUCPdJBeOmNaNo; // 0x44
	private static int ZFjxkyMhczitHBKJwjqlcsvvPKdTA; // 0x0

	// Properties
	public int id { get; }
	public Guid templateTypeGuid { get; }
	public bool enabled { get; set; }
	public int categoryId { get; set; }
	public int layoutId { get; set; }
	public IList<ControllerTemplateActionElementMap> ElementMaps { get; }

	// Methods

	// RVA: 0x19E5F40 Offset: 0x19E5140 VA: 0x1819E5F40
	internal void .ctor(Guid ) { }

	// RVA: 0x19E6070 Offset: 0x19E5270 VA: 0x1819E6070
	internal void .ctor(Guid , int , int , int ) { }

	// RVA: 0x19E6390 Offset: 0x19E5590 VA: 0x1819E6390
	public int get_id() { }

	// RVA: 0x19E64B0 Offset: 0x19E56B0 VA: 0x1819E64B0
	public Guid get_templateTypeGuid() { }

	// RVA: 0x19E6300 Offset: 0x19E5500 VA: 0x1819E6300
	public bool get_enabled() { }

	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_enabled(bool value) { }

	// RVA: 0x19E6270 Offset: 0x19E5470 VA: 0x1819E6270
	public int get_categoryId() { }

	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70
	internal void agwrqjwkphLyJewepWkOzIeySpDg(int ) { }

	// RVA: 0x19E6420 Offset: 0x19E5620 VA: 0x1819E6420
	public int get_layoutId() { }

	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	internal void JtcdVSQbvatVgRVnyQjilPdaoaFV(int ) { }

	// RVA: 0x19E61D0 Offset: 0x19E53D0 VA: 0x1819E61D0
	public IList<ControllerTemplateActionElementMap> get_ElementMaps() { }

	// RVA: 0x19E5DA0 Offset: 0x19E4FA0 VA: 0x1819E5DA0
	public string ToXmlString() { }

	// RVA: 0x19E5C00 Offset: 0x19E4E00 VA: 0x1819E5C00
	public string ToJsonString() { }

	// RVA: 0x19E58B0 Offset: 0x19E4AB0 VA: 0x1819E58B0
	public ControllerMap ToControllerMap(Controller controller) { }

	// RVA: 0x19E4AF0 Offset: 0x19E3CF0 VA: 0x1819E4AF0 Slot: 4
	internal virtual void CHlQrZhwuPdYxNWJlUTNgThCUzEf(SerializedObject ) { }

	// RVA: 0x19E5580 Offset: 0x19E4780 VA: 0x1819E5580 Slot: 5
	internal virtual void MQHErEylLpkabJiPJFPMzIMISIct(SerializedObject ) { }

	// RVA: 0x19E6150 Offset: 0x19E5350 VA: 0x1819E6150
	private void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x19E60C0 Offset: 0x19E52C0 VA: 0x1819E60C0
	private SerializedObject dDwdeldWYOLrnWiNJjDBHtCWImLzA() { }

	// RVA: 0x19E6D50 Offset: 0x19E5F50 VA: 0x1819E6D50
	internal void zcwIffTIQRIZFZeomgCdhlmTJYHn(ControllerTemplateActionElementMap ) { }

	// RVA: 0x19E6690 Offset: 0x19E5890 VA: 0x1819E6690
	internal static ControllerTemplateMap tgAKCNLVAILSaqOEpslWKcyBKVjS(IControllerTemplate , ControllerMap ) { }

	// RVA: 0x19E5480 Offset: 0x19E4680 VA: 0x1819E5480
	public static ControllerTemplateMap FromXml(string xmlString) { }

	// RVA: 0x19E5380 Offset: 0x19E4580 VA: 0x1819E5380
	public static ControllerTemplateMap FromJson(string jsonString) { }

	// RVA: 0x19E6570 Offset: 0x19E5770 VA: 0x1819E6570
	private static ControllerTemplateMap svjYDGqGjibzrWEsVdQHKfZWUeTF(SerializedObject ) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IPlayerController // TypeDefIndex: 6833
{
	// Properties
	public abstract bool enabled { get; set; }
	public abstract int playerId { get; set; }
	public abstract IList<PlayerController.Button> buttons { get; }
	public abstract IList<PlayerController.Axis> axes { get; }
	public abstract IList<PlayerController.Element> elements { get; }
	public abstract int buttonCount { get; }
	public abstract int axisCount { get; }
	public abstract int elementCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_enabled(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_playerId();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_playerId(int value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IList<PlayerController.Button> get_buttons();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IList<PlayerController.Axis> get_axes();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IList<PlayerController.Element> get_elements();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_buttonCount();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_axisCount();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_elementCount();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void add_ButtonStateChangedEvent(Action<int, bool> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void remove_ButtonStateChangedEvent(Action<int, bool> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 12
	public abstract void add_AxisValueChangedEvent(Action<int, float> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 13
	public abstract void remove_AxisValueChangedEvent(Action<int, float> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 14
	public abstract void add_EnabledStateChangedEvent(Action<bool> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public abstract void remove_EnabledStateChangedEvent(Action<bool> value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool GetButton(int index);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool GetButtonDown(int index);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool GetButtonUp(int index);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract float GetAxis(int index);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract float GetAxisRaw(int index);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract PlayerController.Element GetElement(int index);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract T GetElement<T>(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPlayerController.GetElement<object>
	*/
}

// Namespace: 
public class PlayerController.Definition // TypeDefIndex: 6834
{
	// Fields
	public bool enabled; // 0x10
	public int playerId; // 0x14
	public ICollection<PlayerController.Element.Definition> elements; // 0x18

	// Methods

	// RVA: 0x19EA0D0 Offset: 0x19E92D0 VA: 0x1819EA0D0
	public void .ctor() { }
}

// Namespace: 
public static class PlayerController.Factory // TypeDefIndex: 6835
{
	// Methods

	// RVA: 0x19EA390 Offset: 0x19E9590 VA: 0x1819EA390
	public static PlayerController Create(PlayerController.Definition definition) { }
}

// Namespace: 
public class PlayerController.Axis.Definition : PlayerController.ElementWithSource.Definition // TypeDefIndex: 6836
{
	// Fields
	public AxisCoordinateMode coordinateMode; // 0x28
	public float absoluteToRelativeSensitivity; // 0x2C

	// Methods

	// RVA: 0x1A3A3E0 Offset: 0x1A395E0 VA: 0x181A3A3E0
	public void .ctor() { }

	// RVA: 0x1A3A710 Offset: 0x1A39910 VA: 0x181A3A710 Slot: 4
	internal override PlayerController.Element fGUDwTxdwzPvzpmEgWQxrRQmdckT(PlayerController ) { }
}

// Namespace: 
public class PlayerController.Axis : PlayerController.ElementWithSource // TypeDefIndex: 6837
{
	// Fields
	internal const float LDbCRTErQxNMUalxAeovNBsjVFxnA = 1;
	[CustomObfuscation(rename = False)]
	internal const AxisCoordinateMode defaultAxisCoordinateMode = 0;
	private float SnANzLSeWiIIySxTMEVxVhrLWbsn; // 0x30
	private AxisCoordinateMode ivVcaqSADyTZvXJTCtifQzjSHNEv; // 0x34

	// Properties
	public float absoluteToRelativeSensitivity { get; set; }
	public AxisCoordinateMode coordinateMode { get; }
	public virtual float value { get; }
	public virtual float valueRaw { get; }

	// Methods

	// RVA: 0x19E0120 Offset: 0x19DF320 VA: 0x1819E0120
	internal void .ctor(PlayerController , PlayerController.Axis.Definition ) { }

	// RVA: 0x527470 Offset: 0x526670 VA: 0x180527470
	public float get_absoluteToRelativeSensitivity() { }

	// RVA: 0x19E02F0 Offset: 0x19DF4F0 VA: 0x1819E02F0
	public void set_absoluteToRelativeSensitivity(float value) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public AxisCoordinateMode get_coordinateMode() { }

	// RVA: 0x19E01D0 Offset: 0x19DF3D0 VA: 0x1819E01D0 Slot: 6
	public virtual float get_value() { }

	// RVA: 0x19E0170 Offset: 0x19DF370 VA: 0x1819E0170 Slot: 7
	public virtual float get_valueRaw() { }
}

// Namespace: 
public class PlayerController.MouseAxis.Definition : PlayerController.Axis.Definition // TypeDefIndex: 6838
{
	// Methods

	// RVA: 0x1A3A2F0 Offset: 0x1A394F0 VA: 0x181A3A2F0
	public void .ctor() { }

	// RVA: 0x1A3A900 Offset: 0x1A39B00 VA: 0x181A3A900 Slot: 4
	internal override PlayerController.Element fGUDwTxdwzPvzpmEgWQxrRQmdckT(PlayerController ) { }
}

// Namespace: 
public class PlayerController.MouseAxis : PlayerController.Axis // TypeDefIndex: 6839
{
	// Fields
	[CustomObfuscation(rename = False)]
	internal const AxisCoordinateMode defaultAxisCoordinateMode = 1;
	[CustomObfuscation(rename = False)]
	internal const float defaultAbsoluteToRelativeSensitivity = 600;

	// Properties
	public override float value { get; }

	// Methods

	// RVA: 0x1A43CA0 Offset: 0x1A42EA0 VA: 0x181A43CA0
	internal void .ctor(PlayerController , PlayerController.MouseAxis.Definition ) { }

	// RVA: 0x1A43CB0 Offset: 0x1A42EB0 VA: 0x181A43CB0 Slot: 6
	public override float get_value() { }
}

// Namespace: 
public class PlayerController.Axis2D.Definition : PlayerController.CompoundElement.Definition // TypeDefIndex: 6840
{
	// Fields
	private PlayerController.Axis.Definition KiZqXDRXVShaeUIXCIlwPwKagpJt; // 0x20
	private PlayerController.Axis.Definition GFEEZqIlBLgXLopYXKsaqzMXvhAg; // 0x28

	// Properties
	public PlayerController.Axis.Definition xAxis { get; set; }
	public PlayerController.Axis.Definition yAxis { get; set; }

	// Methods

	// RVA: 0x1A3A280 Offset: 0x1A39480 VA: 0x181A3A280
	public void .ctor() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public PlayerController.Axis.Definition get_xAxis() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_xAxis(PlayerController.Axis.Definition value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public PlayerController.Axis.Definition get_yAxis() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_yAxis(PlayerController.Axis.Definition value) { }

	// RVA: 0x1A3A420 Offset: 0x1A39620 VA: 0x181A3A420 Slot: 4
	internal override PlayerController.Element fGUDwTxdwzPvzpmEgWQxrRQmdckT(PlayerController ) { }
}

// Namespace: 
public class PlayerController.Axis2D : PlayerController.CompoundElement // TypeDefIndex: 6841
{
	// Fields
	internal const int axsgIYhaBQpbryfBSLiBEwVgYBBMB = 0;
	internal const int cbrpvZTpOlJGEbGRgEHhaKMkDpDN = 1;
	internal const int quUNqeZRfWeeKlbBdiHGgDWBdclWA = 2;

	// Properties
	public PlayerController.Axis xAxis { get; }
	public PlayerController.Axis yAxis { get; }
	public virtual Vector2 value { get; }
	public virtual Vector2 valueRaw { get; }

	// Methods

	// RVA: 0x1A39190 Offset: 0x1A38390 VA: 0x181A39190
	internal void .ctor(PlayerController , PlayerController.Axis2D.Definition , PlayerController.Element.Definition[] ) { }

	// RVA: 0x1A38FF0 Offset: 0x1A381F0 VA: 0x181A38FF0
	internal void .ctor(PlayerController , PlayerController.Axis2D.Definition ) { }

	// RVA: 0x1A39300 Offset: 0x1A38500 VA: 0x181A39300
	public PlayerController.Axis get_xAxis() { }

	// RVA: 0x1A39340 Offset: 0x1A38540 VA: 0x181A39340
	public PlayerController.Axis get_yAxis() { }

	// RVA: 0x1A39250 Offset: 0x1A38450 VA: 0x181A39250 Slot: 6
	public virtual Vector2 get_value() { }

	// RVA: 0x1A391A0 Offset: 0x1A383A0 VA: 0x181A391A0 Slot: 7
	public virtual Vector2 get_valueRaw() { }
}

// Namespace: 
public class PlayerController.MouseAxis2D.Definition : PlayerController.Axis2D.Definition // TypeDefIndex: 6842
{
	// Properties
	public PlayerController.MouseAxis.Definition xAxis { get; set; }
	public PlayerController.MouseAxis.Definition yAxis { get; set; }

	// Methods

	// RVA: 0x1A3A280 Offset: 0x1A39480 VA: 0x181A3A280
	public void .ctor() { }

	// RVA: 0x1A3AA50 Offset: 0x1A39C50 VA: 0x181A3AA50
	public PlayerController.MouseAxis.Definition get_xAxis() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_xAxis(PlayerController.MouseAxis.Definition value) { }

	// RVA: 0x1A3AB50 Offset: 0x1A39D50 VA: 0x181A3AB50
	public PlayerController.MouseAxis.Definition get_yAxis() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_yAxis(PlayerController.MouseAxis.Definition value) { }

	// RVA: 0x1A3A7F0 Offset: 0x1A399F0 VA: 0x181A3A7F0 Slot: 4
	internal override PlayerController.Element fGUDwTxdwzPvzpmEgWQxrRQmdckT(PlayerController ) { }
}

// Namespace: 
public sealed class PlayerController.MouseAxis2D : PlayerController.Axis2D // TypeDefIndex: 6843
{
	// Properties
	public PlayerController.MouseAxis xAxis { get; }
	public PlayerController.MouseAxis yAxis { get; }

	// Methods

	// RVA: 0x1A43A40 Offset: 0x1A42C40 VA: 0x181A43A40
	internal void .ctor(PlayerController , PlayerController.MouseAxis2D.Definition ) { }

	// RVA: 0x1A43C20 Offset: 0x1A42E20 VA: 0x181A43C20
	public PlayerController.MouseAxis get_xAxis() { }

	// RVA: 0x1A43C60 Offset: 0x1A42E60 VA: 0x181A43C60
	public PlayerController.MouseAxis get_yAxis() { }
}

// Namespace: 
public class PlayerController.Button.Definition : PlayerController.ElementWithSource.Definition // TypeDefIndex: 6844
{
	// Methods

	// RVA: 0x1A3A330 Offset: 0x1A39530 VA: 0x181A3A330
	public void .ctor() { }

	// RVA: 0x1A3A5F0 Offset: 0x1A397F0 VA: 0x181A3A5F0 Slot: 4
	internal override PlayerController.Element fGUDwTxdwzPvzpmEgWQxrRQmdckT(PlayerController ) { }
}

// Namespace: 
public sealed class PlayerController.Button : PlayerController.ElementWithSource // TypeDefIndex: 6845
{
	// Properties
	public bool value { get; }
	public bool valuePrev { get; }
	public bool justPressed { get; }
	public bool justReleased { get; }

	// Methods

	// RVA: 0x1A39610 Offset: 0x1A38810 VA: 0x181A39610
	internal void .ctor(PlayerController , PlayerController.Button.Definition ) { }

	// RVA: 0x1A39820 Offset: 0x1A38A20 VA: 0x181A39820
	public bool get_value() { }

	// RVA: 0x1A397C0 Offset: 0x1A389C0 VA: 0x181A397C0
	public bool get_valuePrev() { }

	// RVA: 0x1A39700 Offset: 0x1A38900 VA: 0x181A39700
	public bool get_justPressed() { }

	// RVA: 0x1A39760 Offset: 0x1A38960 VA: 0x181A39760
	public bool get_justReleased() { }
}

// Namespace: 
public abstract class PlayerController.CompoundElement.Definition : PlayerController.Element.Definition // TypeDefIndex: 6846
{
	// Methods

	// RVA: 0x1A3A280 Offset: 0x1A39480 VA: 0x181A3A280
	public void .ctor() { }
}

// Namespace: 
public abstract class PlayerController.CompoundElement : PlayerController.Element // TypeDefIndex: 6847
{
	// Fields
	private readonly List<PlayerController.Element> ZdSpjvRkgdsTMzWPFjtUndkXnkT; // 0x28

	// Properties
	internal int lrWDgIrOzCXQbUBarwzagPaDOvYC { get; }

	// Methods

	// RVA: 0x1A39A50 Offset: 0x1A38C50 VA: 0x181A39A50
	internal void .ctor(PlayerController , PlayerController.CompoundElement.Definition , PlayerController.Element.Definition[] ) { }

	// RVA: 0x1A39C00 Offset: 0x1A38E00 VA: 0x181A39C00
	internal int dQoZKsoMBhRgwrISAckjxhfmgzOB() { }

	// RVA: -1 Offset: -1
	internal  RnACvZlSzBBziMYJDRxiKAYAOKGL<>(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC8110 Offset: 0xAC7310 VA: 0x180AC8110
	|-PlayerController.CompoundElement.RnACvZlSzBBziMYJDRxiKAYAOKGL<object>
	*/

	// RVA: 0x1A39880 Offset: 0x1A38A80 VA: 0x181A39880
	internal void EjfMWidzgnIypGQAwcYllwYQCwsg(List<PlayerController.Element> ) { }

	// RVA: 0x1A39C40 Offset: 0x1A38E40 VA: 0x181A39C40
	internal void lAgTkkmrmCYHzLIplmpAFCsdJbIF(PlayerController.Element ) { }
}

// Namespace: 
[CustomObfuscation(rename = False)]
internal enum PlayerController.Element.Type // TypeDefIndex: 6848
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.Type Button = 0;
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.Type Axis = 1;
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.Type MouseAxis = 2;
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.Type MouseWheelAxis = 3;
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.Type Axis2D = 100;
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.Type MouseAxis2D = 101;
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.Type MouseWheel = 102;
}

// Namespace: 
[CustomObfuscation(rename = False)]
internal enum PlayerController.Element.TypeWithSource // TypeDefIndex: 6849
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.TypeWithSource Button = 0;
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.TypeWithSource Axis = 1;
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.TypeWithSource MouseAxis = 2;
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.TypeWithSource MouseWheelAxis = 3;
}

// Namespace: 
[CustomObfuscation(rename = False)]
internal enum PlayerController.Element.CompoundTypes // TypeDefIndex: 6850
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.CompoundTypes Axis2D = 100;
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.CompoundTypes MouseAxis2D = 101;
	[CustomObfuscation(rename = False)]
	public const PlayerController.Element.CompoundTypes MouseWheel = 102;
}

// Namespace: 
public abstract class PlayerController.Element.Definition // TypeDefIndex: 6851
{
	// Fields
	public bool enabled; // 0x10
	public string name; // 0x18

	// Methods

	// RVA: 0x1A3A280 Offset: 0x1A39480 VA: 0x181A3A280
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract PlayerController.Element fGUDwTxdwzPvzpmEgWQxrRQmdckT(PlayerController );
}

// Namespace: 
internal struct PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA // TypeDefIndex: 6852
{
	// Fields
	public ControllerElementType sKjCmMOLFxixaCQzRKUpvBFTerKeA; // 0x0
	public int nJBlPrhdkfewybdTrEXsjTeHkYOv; // 0x4
	public float CdEckvrVAeswSaQCfMLbUlJjpTfR; // 0x8

	// Methods

	// RVA: 0x1991040 Offset: 0x1990240 VA: 0x181991040
	public void .ctor(ControllerElementType , int , float ) { }
}

// Namespace: 
public abstract class PlayerController.Element // TypeDefIndex: 6853
{
	// Fields
	[CustomObfuscation(rename = False)]
	internal const bool defaultEnabled = True;
	private readonly PlayerController YgOUhFlqQKEAUkaFqxIeQeWEyeff; // 0x10
	private bool hJPLvsMNxocSYBZoMomjQIYdVLZY; // 0x18
	private bool AqHaORMjZGTdLoJMHbRKCeXHvJfRA; // 0x19
	private string NsRFUoBLVeZwnSsExKWhwStYeoRV; // 0x20
	private static int[] WubUkJghZSLaNbbAxSJxyfJVoaNM; // 0x0
	private static int[] ENjSHyRWxTEZwxlEIFBhOdKzwjwq; // 0x8

	// Properties
	protected Player player { get; }
	protected bool selfAndParentEnabled { get; }
	internal bool hnUkmZbzchHgmUrdahmdMhnCrred { get; set; }
	public bool enabled { get; set; }
	public string name { get; set; }

	// Methods

	// RVA: 0x1A3B640 Offset: 0x1A3A840 VA: 0x181A3B640
	internal void .ctor(PlayerController , PlayerController.Element.Definition ) { }

	// RVA: 0x1A3B730 Offset: 0x1A3A930 VA: 0x181A3B730
	protected Player get_player() { }

	// RVA: 0x1A3B800 Offset: 0x1A3AA00 VA: 0x181A3B800
	protected bool get_selfAndParentEnabled() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	internal bool gWebgJDWXFqdmniZVPfojokcUnRdB() { }

	// RVA: 0x8B34C0 Offset: 0x8B26C0 VA: 0x1808B34C0
	internal void qjmJRkWdmDCRkkgNpoEIwznnryMIA(bool ) { }

	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40
	public bool get_enabled() { }

	// RVA: 0x1A3B830 Offset: 0x1A3AA30 VA: 0x181A3B830
	public void set_enabled(bool value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_name() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_name(string value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	internal virtual void NXsdcUmvlchkKwnLJYZgvWkOUNSV() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void EnabledStateChanged(bool state) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3B4E0 Offset: 0x1A3A6E0 VA: 0x181A3B4E0
	internal static bool IsTypeWithSource(PlayerController.Element.Type type) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3B380 Offset: 0x1A3A580 VA: 0x181A3B380
	internal static bool IsCompoundType(PlayerController.Element.Type type) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3B2C0 Offset: 0x1A3A4C0 VA: 0x181A3B2C0
	internal static int GetMaxElementCount(PlayerController.Element.Type type) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3B100 Offset: 0x1A3A300 VA: 0x181A3B100
	internal static string GetElementTitle(PlayerController.Element.Type type, int index) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3AF30 Offset: 0x1A3A130 VA: 0x181A3AF30
	internal static PlayerController.Element.Definition CreateDefinition(PlayerController.Element.Type type) { }
}

// Namespace: 
public abstract class PlayerController.ElementWithSource.Definition : PlayerController.Element.Definition // TypeDefIndex: 6854
{
	// Fields
	private int pFIFvsDSemlQRdLPLVmAuFVFNKGkA; // 0x20

	// Properties
	public int actionId { get; set; }
	public string actionName { get; set; }

	// Methods

	// RVA: 0x1A3A330 Offset: 0x1A39530 VA: 0x181A3A330
	public void .ctor() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_actionId() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_actionId(int value) { }

	// RVA: 0x1A3A970 Offset: 0x1A39B70 VA: 0x181A3A970
	public string get_actionName() { }

	// RVA: 0x1A3AC50 Offset: 0x1A39E50 VA: 0x181A3AC50
	public void set_actionName(string value) { }
}

// Namespace: 
public abstract class PlayerController.ElementWithSource : PlayerController.Element // TypeDefIndex: 6855
{
	// Fields
	[CustomObfuscation(rename = False)]
	internal const int defaultActionId = -1;
	private int pFIFvsDSemlQRdLPLVmAuFVFNKGkA; // 0x28

	// Properties
	public int actionId { get; set; }
	public string actionName { get; set; }

	// Methods

	// RVA: 0x1A39610 Offset: 0x1A38810 VA: 0x181A39610
	internal void .ctor(PlayerController , PlayerController.ElementWithSource.Definition ) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_actionId() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_actionId(int value) { }

	// RVA: 0x1A3AD60 Offset: 0x1A39F60 VA: 0x181A3AD60
	public string get_actionName() { }

	// RVA: 0x1A3AE40 Offset: 0x1A3A040 VA: 0x181A3AE40
	public void set_actionName(string value) { }
}

// Namespace: 
public class PlayerController.MouseWheel.Definition : PlayerController.Axis2D.Definition // TypeDefIndex: 6856
{
	// Properties
	public PlayerController.MouseWheelAxis.Definition xAxis { get; set; }
	public PlayerController.MouseWheelAxis.Definition yAxis { get; set; }

	// Methods

	// RVA: 0x1A3A280 Offset: 0x1A39480 VA: 0x181A3A280
	public void .ctor() { }

	// RVA: 0x1A3AAD0 Offset: 0x1A39CD0 VA: 0x181A3AAD0
	public PlayerController.MouseWheelAxis.Definition get_xAxis() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_xAxis(PlayerController.MouseWheelAxis.Definition value) { }

	// RVA: 0x1A3ABD0 Offset: 0x1A39DD0 VA: 0x181A3ABD0
	public PlayerController.MouseWheelAxis.Definition get_yAxis() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_yAxis(PlayerController.MouseWheelAxis.Definition value) { }

	// RVA: 0x1A3A780 Offset: 0x1A39980 VA: 0x181A3A780 Slot: 4
	internal override PlayerController.Element fGUDwTxdwzPvzpmEgWQxrRQmdckT(PlayerController ) { }
}

// Namespace: 
public sealed class PlayerController.MouseWheel : PlayerController.Axis2D // TypeDefIndex: 6857
{
	// Properties
	public PlayerController.MouseWheelAxis xAxis { get; }
	public PlayerController.MouseWheelAxis yAxis { get; }

	// Methods

	// RVA: 0x1A441F0 Offset: 0x1A433F0 VA: 0x181A441F0
	internal void .ctor(PlayerController , PlayerController.MouseWheel.Definition ) { }

	// RVA: 0x1A443E0 Offset: 0x1A435E0 VA: 0x181A443E0
	public PlayerController.MouseWheelAxis get_xAxis() { }

	// RVA: 0x1A44420 Offset: 0x1A43620 VA: 0x181A44420
	public PlayerController.MouseWheelAxis get_yAxis() { }
}

// Namespace: 
public class PlayerController.MouseWheelAxis.Definition : PlayerController.Axis.Definition // TypeDefIndex: 6858
{
	// Fields
	public float repeatRate; // 0x30

	// Methods

	// RVA: 0x1A3A2B0 Offset: 0x1A394B0 VA: 0x181A3A2B0
	public void .ctor() { }

	// RVA: 0x1A3A860 Offset: 0x1A39A60 VA: 0x181A3A860 Slot: 4
	internal override PlayerController.Element fGUDwTxdwzPvzpmEgWQxrRQmdckT(PlayerController ) { }
}

// Namespace: 
public sealed class PlayerController.MouseWheelAxis : PlayerController.Axis // TypeDefIndex: 6859
{
	// Fields
	[CustomObfuscation(rename = False)]
	internal const float defaultRepeatRate = 4;
	[CustomObfuscation(rename = False)]
	internal const AxisCoordinateMode defaultAxisCoordinateMode = 1;
	private const float CktQTyVqPSPXArQfvusYanfAUgCY = 0,01;
	private float cjkzQOIZdTOwXrRmpbPPZbJSHioHA; // 0x38
	private double QsLNgJYoDfdVNdjyiHWJvbMSMgtmA; // 0x40
	private float ABOGdjpoQCATcAFVlobRVSpCMJhLA; // 0x48

	// Properties
	public float repeatRate { get; set; }
	public override float value { get; }

	// Methods

	// RVA: 0x1A440E0 Offset: 0x1A432E0 VA: 0x181A440E0
	internal void .ctor(PlayerController , PlayerController.MouseWheelAxis.Definition ) { }

	// RVA: 0x1A44160 Offset: 0x1A43360 VA: 0x181A44160
	public float get_repeatRate() { }

	// RVA: 0x1A441C0 Offset: 0x1A433C0 VA: 0x181A441C0
	public void set_repeatRate(float value) { }

	// RVA: 0x1A44180 Offset: 0x1A43380 VA: 0x181A44180 Slot: 6
	public override float get_value() { }

	// RVA: 0x1A43F10 Offset: 0x1A43110 VA: 0x181A43F10 Slot: 4
	internal override void NXsdcUmvlchkKwnLJYZgvWkOUNSV() { }

	// RVA: 0x1A43F00 Offset: 0x1A43100 VA: 0x181A43F00 Slot: 5
	protected override void EnabledStateChanged(bool state) { }

	// RVA: 0x1A43D50 Offset: 0x1A42F50 VA: 0x181A43D50
	private float EBLvNPAxvHARaCcydHhVaFNuqhsv() { }

	// RVA: 0x1A44150 Offset: 0x1A43350 VA: 0x181A44150
	private void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }
}

// Namespace: Rewired
public class PlayerController : IPlayerController // TypeDefIndex: 6860
{
	// Fields
	internal readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x10
	private bool AqHaORMjZGTdLoJMHbRKCeXHvJfRA; // 0x14
	private int rwAEYiLTgxJyqRHIqJhqBzEeRzGE; // 0x18
	private readonly AList<PlayerController.Element> ZdSpjvRkgdsTMzWPFjtUndkXnkT; // 0x20
	private readonly AList<PlayerController.Button> qCcRvKGVZggEJuRPOApCjfkkjLFN; // 0x28
	private readonly AList<PlayerController.Axis> GpfcrdjIEBMflsTvZtwFtrSGTOKrA; // 0x30
	private readonly ReadOnlyCollection<PlayerController.Element> pWquskIZiDEOlilKSzVSUWvspUFo; // 0x38
	private readonly ReadOnlyCollection<PlayerController.Button> JMaJHTQMXSupUDqsRolXfXMLWXne; // 0x40
	private readonly ReadOnlyCollection<PlayerController.Axis> CMMFvHSNZxTZuxfCKWOPgGJPfURu; // 0x48
	private readonly List<PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA> xfcBdUPAycLLSwfpSHdcItfajNenA; // 0x50
	private Action<int, bool> BBwsmVomWdwQhyhCcaUrkhFovhTp; // 0x58
	private Action<int, float> qAjnIcNWvnwAceZthQHmQRTzhPsg; // 0x60
	private Action<bool> IxiFGLWspltmQimVZfZHYWSfCDAfA; // 0x68

	// Properties
	public bool enabled { get; set; }
	public int playerId { get; set; }
	public IList<PlayerController.Button> buttons { get; }
	public IList<PlayerController.Axis> axes { get; }
	public IList<PlayerController.Element> elements { get; }
	public int buttonCount { get; }
	public int axisCount { get; }
	public int elementCount { get; }
	internal Player dKxeWVrXJNsFqEAYKfLlJKDBwaWd { get; }

	// Methods

	// RVA: 0x19F2FE0 Offset: 0x19F21E0 VA: 0x1819F2FE0
	internal void .ctor(PlayerController.Definition ) { }

	// RVA: 0x19F2260 Offset: 0x19F1460 VA: 0x1819F2260 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19F3CA0 Offset: 0x19F2EA0 VA: 0x1819F3CA0 Slot: 4
	public bool get_enabled() { }

	// RVA: 0x19F4800 Offset: 0x19F3A00 VA: 0x1819F4800 Slot: 5
	public void set_enabled(bool value) { }

	// RVA: 0x19F3D30 Offset: 0x19F2F30 VA: 0x1819F3D30 Slot: 6
	public int get_playerId() { }

	// RVA: 0x19F49D0 Offset: 0x19F3BD0 VA: 0x1819F49D0 Slot: 7
	public void set_playerId(int value) { }

	// RVA: 0x19F3AF0 Offset: 0x19F2CF0 VA: 0x1819F3AF0 Slot: 8
	public IList<PlayerController.Button> get_buttons() { }

	// RVA: 0x19F3940 Offset: 0x19F2B40 VA: 0x1819F3940 Slot: 9
	public IList<PlayerController.Axis> get_axes() { }

	// RVA: 0x19F3C10 Offset: 0x19F2E10 VA: 0x1819F3C10 Slot: 10
	public IList<PlayerController.Element> get_elements() { }

	// RVA: 0x19F3A60 Offset: 0x19F2C60 VA: 0x1819F3A60 Slot: 11
	public int get_buttonCount() { }

	// RVA: 0x19F39D0 Offset: 0x19F2BD0 VA: 0x1819F39D0 Slot: 12
	public int get_axisCount() { }

	// RVA: 0x19F3B80 Offset: 0x19F2D80 VA: 0x1819F3B80 Slot: 13
	public int get_elementCount() { }

	// RVA: 0x19F3720 Offset: 0x19F2920 VA: 0x1819F3720 Slot: 14
	public void add_ButtonStateChangedEvent(Action<int, bool> value) { }

	// RVA: 0x19F46A0 Offset: 0x19F38A0 VA: 0x1819F46A0 Slot: 15
	public void remove_ButtonStateChangedEvent(Action<int, bool> value) { }

	// RVA: 0x19F3610 Offset: 0x19F2810 VA: 0x1819F3610 Slot: 16
	public void add_AxisValueChangedEvent(Action<int, float> value) { }

	// RVA: 0x19F45F0 Offset: 0x19F37F0 VA: 0x1819F45F0 Slot: 17
	public void remove_AxisValueChangedEvent(Action<int, float> value) { }

	// RVA: 0x19F3830 Offset: 0x19F2A30 VA: 0x1819F3830 Slot: 18
	public void add_EnabledStateChangedEvent(Action<bool> value) { }

	// RVA: 0x19F4750 Offset: 0x19F3950 VA: 0x1819F4750 Slot: 19
	public void remove_EnabledStateChangedEvent(Action<bool> value) { }

	// RVA: 0x19F26B0 Offset: 0x19F18B0 VA: 0x1819F26B0 Slot: 20
	public bool GetButton(int index) { }

	// RVA: 0x19F24F0 Offset: 0x19F16F0 VA: 0x1819F24F0 Slot: 21
	public bool GetButtonDown(int index) { }

	// RVA: 0x19F25D0 Offset: 0x19F17D0 VA: 0x1819F25D0 Slot: 22
	public bool GetButtonUp(int index) { }

	// RVA: 0x19F2410 Offset: 0x19F1610 VA: 0x1819F2410 Slot: 23
	public float GetAxis(int index) { }

