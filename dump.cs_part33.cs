	public void .ctor(ReadOnlySpan<byte> jsonData, bool isFinalBlock, JsonReaderState state) { }

	// RVA: 0x1C06B90 Offset: 0x1C05D90 VA: 0x181C06B90
	public bool Read() { }

	// RVA: 0x1C08720 Offset: 0x1C07920 VA: 0x181C08720
	public void Skip() { }

	// RVA: 0x1BDE3A0 Offset: 0x1BDD5A0 VA: 0x181BDE3A0
	private void SkipHelper() { }

	// RVA: 0x1C0B900 Offset: 0x1C0AB00 VA: 0x181C0B900
	public bool TrySkip() { }

	// RVA: 0x1C0B660 Offset: 0x1C0A860 VA: 0x181C0B660
	private bool TrySkipHelper() { }

	// RVA: 0x1C08870 Offset: 0x1C07A70 VA: 0x181C08870
	private void StartObject() { }

	// RVA: 0x1C03590 Offset: 0x1C02790 VA: 0x181C03590
	private void EndObject() { }

	// RVA: 0x1C08760 Offset: 0x1C07960 VA: 0x181C08760
	private void StartArray() { }

	// RVA: 0x1C03460 Offset: 0x1C02660 VA: 0x181C03460
	private void EndArray() { }

	// RVA: 0x1BDEB70 Offset: 0x1BDDD70 VA: 0x181BDEB70
	private void UpdateBitStackOnEndToken() { }

	// RVA: 0x1C06950 Offset: 0x1C05B50 VA: 0x181C06950
	private bool ReadSingleSegment() { }

	// RVA: 0x1C05FF0 Offset: 0x1C051F0 VA: 0x181C05FF0
	private bool HasMoreData() { }

	// RVA: 0x1C06100 Offset: 0x1C05300 VA: 0x181C06100
	private bool HasMoreData(ExceptionResource resource) { }

	// RVA: 0x1C063A0 Offset: 0x1C055A0 VA: 0x181C063A0
	private bool ReadFirstToken(byte first) { }

	// RVA: 0x1C08630 Offset: 0x1C07830 VA: 0x181C08630
	private void SkipWhiteSpace() { }

	// RVA: 0x1C02740 Offset: 0x1C01940 VA: 0x181C02740
	private bool ConsumeValue(byte marker) { }

	// RVA: 0x1BFD310 Offset: 0x1BFC510 VA: 0x181BFD310
	private bool ConsumeLiteral(ReadOnlySpan<byte> literal, JsonTokenType tokenType) { }

	// RVA: 0x1BFC2E0 Offset: 0x1BFB4E0 VA: 0x181BFC2E0
	private bool CheckLiteral(ReadOnlySpan<byte> span, ReadOnlySpan<byte> literal) { }

	// RVA: 0x1C08980 Offset: 0x1C07B80 VA: 0x181C08980
	private void ThrowInvalidLiteral(ReadOnlySpan<byte> span) { }

	// RVA: 0x1BFFBE0 Offset: 0x1BFEDE0 VA: 0x181BFFBE0
	private bool ConsumeNumber() { }

	// RVA: 0x1BFFF00 Offset: 0x1BFF100 VA: 0x181BFFF00
	private bool ConsumePropertyName() { }

	// RVA: 0x1C01D00 Offset: 0x1C00F00 VA: 0x181C01D00
	private bool ConsumeString() { }

	// RVA: 0x1C00DB0 Offset: 0x1BFFFB0 VA: 0x181C00DB0
	private bool ConsumeStringAndValidate(ReadOnlySpan<byte> data, int idx) { }

	// RVA: 0x1C0B920 Offset: 0x1C0AB20 VA: 0x181C0B920
	private bool ValidateHexDigits(ReadOnlySpan<byte> data, int idx) { }

	// RVA: 0x1C0A9E0 Offset: 0x1C09BE0 VA: 0x181C0A9E0
	private bool TryGetNumber(ReadOnlySpan<byte> data, out int consumed) { }

	// RVA: 0x1BFD8C0 Offset: 0x1BFCAC0 VA: 0x181BFD8C0
	private ConsumeNumberResult ConsumeNegativeSign(ref ReadOnlySpan<byte> data, ref int i) { }

	// RVA: 0x1C03170 Offset: 0x1C02370 VA: 0x181C03170
	private ConsumeNumberResult ConsumeZero(ref ReadOnlySpan<byte> data, ref int i) { }

	// RVA: 0x1BFCE50 Offset: 0x1BFC050 VA: 0x181BFCE50
	private ConsumeNumberResult ConsumeIntegerDigits(ref ReadOnlySpan<byte> data, ref int i) { }

	// RVA: 0x1BFC950 Offset: 0x1BFBB50 VA: 0x181BFC950
	private ConsumeNumberResult ConsumeDecimalDigits(ref ReadOnlySpan<byte> data, ref int i) { }

	// RVA: 0x1C003D0 Offset: 0x1BFF5D0 VA: 0x181C003D0
	private ConsumeNumberResult ConsumeSign(ref ReadOnlySpan<byte> data, ref int i) { }

	// RVA: 0x1BFEC30 Offset: 0x1BFDE30 VA: 0x181BFEC30
	private bool ConsumeNextTokenOrRollback(byte marker) { }

	// RVA: 0x1BFF640 Offset: 0x1BFE840 VA: 0x181BFF640
	private ConsumeTokenResult ConsumeNextToken(byte marker) { }

	// RVA: 0x1BFE180 Offset: 0x1BFD380 VA: 0x181BFE180
	private ConsumeTokenResult ConsumeNextTokenFromLastNonCommentToken() { }

	// RVA: 0x1C06DF0 Offset: 0x1C05FF0 VA: 0x181C06DF0
	private bool SkipAllComments(ref byte marker) { }

	// RVA: 0x1C06EB0 Offset: 0x1C060B0 VA: 0x181C06EB0
	private bool SkipAllComments(ref byte marker, ExceptionResource resource) { }

	// RVA: 0x1BFF1D0 Offset: 0x1BFE3D0 VA: 0x181BFF1D0
	private ConsumeTokenResult ConsumeNextTokenUntilAfterAllCommentsAreSkipped(byte marker) { }

	// RVA: 0x1C073A0 Offset: 0x1C065A0 VA: 0x181C073A0
	private bool SkipComment() { }

	// RVA: 0x1C08480 Offset: 0x1C07680 VA: 0x181C08480
	private bool SkipSingleLineComment(ReadOnlySpan<byte> localBuffer, out int idx) { }

	// RVA: 0x1C03B80 Offset: 0x1C02D80 VA: 0x181C03B80
	private int FindLineSeparator(ReadOnlySpan<byte> localBuffer) { }

	// RVA: 0x1C08B80 Offset: 0x1C07D80 VA: 0x181C08B80
	private void ThrowOnDangerousLineSeparator(ReadOnlySpan<byte> localBuffer) { }

	// RVA: 0x1C07B80 Offset: 0x1C06D80 VA: 0x181C07B80
	private bool SkipMultiLineComment(ReadOnlySpan<byte> localBuffer, out int idx) { }

	// RVA: 0x1BFC420 Offset: 0x1BFB620 VA: 0x181BFC420
	private bool ConsumeComment() { }

	// RVA: 0x1C00640 Offset: 0x1BFF840 VA: 0x181C00640
	private bool ConsumeSingleLineComment(ReadOnlySpan<byte> localBuffer, int previousConsumed) { }

	// RVA: 0x1BFD570 Offset: 0x1BFC770 VA: 0x181BFD570
	private bool ConsumeMultiLineComment(ReadOnlySpan<byte> localBuffer, int previousConsumed) { }

	// RVA: 0x1C05C70 Offset: 0x1C04E70 VA: 0x181C05C70
	private ReadOnlySpan<byte> GetUnescapedSpan() { }

	// RVA: 0x1C06610 Offset: 0x1C05810 VA: 0x181C06610
	private bool ReadMultiSegment() { }

	// RVA: 0x1C0BA80 Offset: 0x1C0AC80 VA: 0x181C0BA80
	private bool ValidateStateAtEndOfData() { }

	// RVA: 0x1C05F50 Offset: 0x1C05150 VA: 0x181C05F50
	private bool HasMoreDataMultiSegment() { }

	// RVA: 0x1C05E30 Offset: 0x1C05030 VA: 0x181C05E30
	private bool HasMoreDataMultiSegment(ExceptionResource resource) { }

	// RVA: 0x1C04FA0 Offset: 0x1C041A0 VA: 0x181C04FA0
	private bool GetNextSpan() { }

	// RVA: 0x1C061C0 Offset: 0x1C053C0 VA: 0x181C061C0
	private bool ReadFirstTokenMultiSegment(byte first) { }

	// RVA: 0x1C085E0 Offset: 0x1C077E0 VA: 0x181C085E0
	private void SkipWhiteSpaceMultiSegment() { }

	// RVA: 0x1C02050 Offset: 0x1C01250 VA: 0x181C02050
	private bool ConsumeValueMultiSegment(byte marker) { }

	// RVA: 0x1BFD090 Offset: 0x1BFC290 VA: 0x181BFD090
	private bool ConsumeLiteralMultiSegment(ReadOnlySpan<byte> literal, JsonTokenType tokenType) { }

	// RVA: 0x1BFB690 Offset: 0x1BFA890 VA: 0x181BFB690
	private bool CheckLiteralMultiSegment(ReadOnlySpan<byte> span, ReadOnlySpan<byte> literal, out int consumed) { }

	// RVA: 0x1C03E30 Offset: 0x1C03030 VA: 0x181C03E30
	private int FindMismatch(ReadOnlySpan<byte> span, ReadOnlySpan<byte> literal) { }

	// RVA: 0x1C04F00 Offset: 0x1C04100 VA: 0x181C04F00
	private JsonException GetInvalidLiteralMultiSegment(ReadOnlySpan<byte> span) { }

	// RVA: 0x1BFFA10 Offset: 0x1BFEC10 VA: 0x181BFFA10
	private bool ConsumeNumberMultiSegment() { }

	// RVA: 0x1BFFDB0 Offset: 0x1BFEFB0 VA: 0x181BFFDB0
	private bool ConsumePropertyNameMultiSegment() { }

	// RVA: 0x1C01120 Offset: 0x1C00320 VA: 0x181C01120
	private bool ConsumeStringMultiSegment() { }

	// RVA: 0x1C01480 Offset: 0x1C00680 VA: 0x181C01480
	private bool ConsumeStringNextSegment() { }

	// RVA: 0x1C00720 Offset: 0x1BFF920 VA: 0x181C00720
	private bool ConsumeStringAndValidateMultiSegment(ReadOnlySpan<byte> data, int idx) { }

	// RVA: 0x1C06C20 Offset: 0x1C05E20 VA: 0x181C06C20
	private void RollBackState(in Utf8JsonReader.PartialStateForRollback state, bool isError = False) { }

	// RVA: 0x1C0A4F0 Offset: 0x1C096F0 VA: 0x181C0A4F0
	private bool TryGetNumberMultiSegment(ReadOnlySpan<byte> data, out int consumed) { }

	// RVA: 0x1BFD650 Offset: 0x1BFC850 VA: 0x181BFD650
	private ConsumeNumberResult ConsumeNegativeSignMultiSegment(ref ReadOnlySpan<byte> data, ref int i, in Utf8JsonReader.PartialStateForRollback rollBackState) { }

	// RVA: 0x1C02DD0 Offset: 0x1C01FD0 VA: 0x181C02DD0
	private ConsumeNumberResult ConsumeZeroMultiSegment(ref ReadOnlySpan<byte> data, ref int i, in Utf8JsonReader.PartialStateForRollback rollBackState) { }

	// RVA: 0x1BFCB10 Offset: 0x1BFBD10 VA: 0x181BFCB10
	private ConsumeNumberResult ConsumeIntegerDigitsMultiSegment(ref ReadOnlySpan<byte> data, ref int i) { }

	// RVA: 0x1BFC700 Offset: 0x1BFB900 VA: 0x181BFC700
	private ConsumeNumberResult ConsumeDecimalDigitsMultiSegment(ref ReadOnlySpan<byte> data, ref int i, in Utf8JsonReader.PartialStateForRollback rollBackState) { }

	// RVA: 0x1C00050 Offset: 0x1BFF250 VA: 0x181C00050
	private ConsumeNumberResult ConsumeSignMultiSegment(ref ReadOnlySpan<byte> data, ref int i, in Utf8JsonReader.PartialStateForRollback rollBackState) { }

	// RVA: 0x1BFEB90 Offset: 0x1BFDD90 VA: 0x181BFEB90
	private bool ConsumeNextTokenOrRollbackMultiSegment(byte marker) { }

	// RVA: 0x1BFE740 Offset: 0x1BFD940 VA: 0x181BFE740
	private ConsumeTokenResult ConsumeNextTokenMultiSegment(byte marker) { }

	// RVA: 0x1BFDA90 Offset: 0x1BFCC90 VA: 0x181BFDA90
	private ConsumeTokenResult ConsumeNextTokenFromLastNonCommentTokenMultiSegment() { }

	// RVA: 0x1C06D30 Offset: 0x1C05F30 VA: 0x181C06D30
	private bool SkipAllCommentsMultiSegment(ref byte marker) { }

	// RVA: 0x1C06C50 Offset: 0x1C05E50 VA: 0x181C06C50
	private bool SkipAllCommentsMultiSegment(ref byte marker, ExceptionResource resource) { }

	// RVA: 0x1BFECB0 Offset: 0x1BFDEB0 VA: 0x181BFECB0
	private ConsumeTokenResult ConsumeNextTokenUntilAfterAllCommentsAreSkippedMultiSegment(byte marker) { }

	// RVA: 0x1C08020 Offset: 0x1C07220 VA: 0x181C08020
	private bool SkipOrConsumeCommentMultiSegmentWithRollback() { }

	// RVA: 0x1C06F90 Offset: 0x1C06190 VA: 0x181C06F90
	private bool SkipCommentMultiSegment(out int tailBytesToIgnore) { }

	// RVA: 0x1C082B0 Offset: 0x1C074B0 VA: 0x181C082B0
	private bool SkipSingleLineCommentMultiSegment(ReadOnlySpan<byte> localBuffer, out int tailBytesToSkip) { }

	// RVA: 0x1C036C0 Offset: 0x1C028C0 VA: 0x181C036C0
	private int FindLineSeparatorMultiSegment(ReadOnlySpan<byte> localBuffer, ref int dangerousLineSeparatorBytesConsumed) { }

	// RVA: 0x1C08A10 Offset: 0x1C07C10 VA: 0x181C08A10
	private void ThrowOnDangerousLineSeparatorMultiSegment(ReadOnlySpan<byte> localBuffer, ref int dangerousLineSeparatorBytesConsumed) { }

	// RVA: 0x1C07670 Offset: 0x1C06870 VA: 0x181C07670
	private bool SkipMultiLineCommentMultiSegment(ReadOnlySpan<byte> localBuffer) { }

	// RVA: 0x1BFB630 Offset: 0x1BFA830 VA: 0x181BFB630
	private Utf8JsonReader.PartialStateForRollback CaptureState() { }

	[NullableContext(2)]
	// RVA: 0x1C05650 Offset: 0x1C04850 VA: 0x181C05650
	public string GetString() { }

	// RVA: 0x1C03F50 Offset: 0x1C03150 VA: 0x181C03F50
	public bool GetBoolean() { }

	[NullableContext(1)]
	// RVA: 0x1C04180 Offset: 0x1C03380 VA: 0x181C04180
	public byte[] GetBytesFromBase64() { }

	// RVA: 0x1C04120 Offset: 0x1C03320 VA: 0x181C04120
	public byte GetByte() { }

	// RVA: 0x1C04020 Offset: 0x1C03220 VA: 0x181C04020
	internal byte GetByteWithQuotes() { }

	[CLSCompliant(False)]
	// RVA: 0x1C05240 Offset: 0x1C04440 VA: 0x181C05240
	public sbyte GetSByte() { }

	// RVA: 0x1C05140 Offset: 0x1C04340 VA: 0x181C05140
	internal sbyte GetSByteWithQuotes() { }

	// RVA: 0x1C04BE0 Offset: 0x1C03DE0 VA: 0x181C04BE0
	public short GetInt16() { }

	// RVA: 0x1C04AE0 Offset: 0x1C03CE0 VA: 0x181C04AE0
	internal short GetInt16WithQuotes() { }

	// RVA: 0x1C04D40 Offset: 0x1C03F40 VA: 0x181C04D40
	public int GetInt32() { }

	// RVA: 0x1C04C40 Offset: 0x1C03E40 VA: 0x181C04C40
	internal int GetInt32WithQuotes() { }

	// RVA: 0x1C04EA0 Offset: 0x1C040A0 VA: 0x181C04EA0
	public long GetInt64() { }

	// RVA: 0x1C04DA0 Offset: 0x1C03FA0 VA: 0x181C04DA0
	internal long GetInt64WithQuotes() { }

	[CLSCompliant(False)]
	// RVA: 0x1C05950 Offset: 0x1C04B50 VA: 0x181C05950
	public ushort GetUInt16() { }

	// RVA: 0x1C05850 Offset: 0x1C04A50 VA: 0x181C05850
	internal ushort GetUInt16WithQuotes() { }

	[CLSCompliant(False)]
	// RVA: 0x1C05AB0 Offset: 0x1C04CB0 VA: 0x181C05AB0
	public uint GetUInt32() { }

	// RVA: 0x1C059B0 Offset: 0x1C04BB0 VA: 0x181C059B0
	internal uint GetUInt32WithQuotes() { }

	[CLSCompliant(False)]
	// RVA: 0x1C05C10 Offset: 0x1C04E10 VA: 0x181C05C10
	public ulong GetUInt64() { }

	// RVA: 0x1C05B10 Offset: 0x1C04D10 VA: 0x181C05B10
	internal ulong GetUInt64WithQuotes() { }

	// RVA: 0x1C055F0 Offset: 0x1C047F0 VA: 0x181C055F0
	public float GetSingle() { }

	// RVA: 0x1C05370 Offset: 0x1C04570 VA: 0x181C05370
	internal float GetSingleWithQuotes() { }

	// RVA: 0x1C052A0 Offset: 0x1C044A0 VA: 0x181C052A0
	internal float GetSingleFloatingPointConstant() { }

	// RVA: 0x1C04990 Offset: 0x1C03B90 VA: 0x181C04990
	public double GetDouble() { }

	// RVA: 0x1C046F0 Offset: 0x1C038F0 VA: 0x181C046F0
	internal double GetDoubleWithQuotes() { }

	// RVA: 0x1C04620 Offset: 0x1C03820 VA: 0x181C04620
	internal double GetDoubleFloatingPointConstant() { }

	// RVA: 0x1C045C0 Offset: 0x1C037C0 VA: 0x181C045C0
	public Decimal GetDecimal() { }

	// RVA: 0x1C043C0 Offset: 0x1C035C0 VA: 0x181C043C0
	internal Decimal GetDecimalWithQuotes() { }

	// RVA: 0x1C04330 Offset: 0x1C03530 VA: 0x181C04330
	public DateTime GetDateTime() { }

	// RVA: 0x1C041E0 Offset: 0x1C033E0 VA: 0x181C041E0
	internal DateTime GetDateTimeNoValidation() { }

	// RVA: 0x1C042A0 Offset: 0x1C034A0 VA: 0x181C042A0
	public DateTimeOffset GetDateTimeOffset() { }

	// RVA: 0x1C04240 Offset: 0x1C03440 VA: 0x181C04240
	internal DateTimeOffset GetDateTimeOffsetNoValidation() { }

	// RVA: 0x1C04A50 Offset: 0x1C03C50 VA: 0x181C04A50
	public Guid GetGuid() { }

	// RVA: 0x1C049F0 Offset: 0x1C03BF0 VA: 0x181C049F0
	internal Guid GetGuidNoValidation() { }

	[NullableContext(2)]
	// RVA: 0x1C08E70 Offset: 0x1C08070 VA: 0x181C08E70
	public bool TryGetBytesFromBase64(out byte[] value) { }

	// RVA: 0x1C08D60 Offset: 0x1C07F60 VA: 0x181C08D60
	public bool TryGetByte(out byte value) { }

	// RVA: 0x1C08C90 Offset: 0x1C07E90 VA: 0x181C08C90
	internal bool TryGetByteCore(out byte value, ReadOnlySpan<byte> span) { }

	[CLSCompliant(False)]
	// RVA: 0x1C0ADE0 Offset: 0x1C09FE0 VA: 0x181C0ADE0
	public bool TryGetSByte(out sbyte value) { }

	// RVA: 0x1C0AD10 Offset: 0x1C09F10 VA: 0x181C0AD10
	internal bool TryGetSByteCore(out sbyte value, ReadOnlySpan<byte> span) { }

	// RVA: 0x1C0A020 Offset: 0x1C09220 VA: 0x181C0A020
	public bool TryGetInt16(out short value) { }

	// RVA: 0x1C09F50 Offset: 0x1C09150 VA: 0x181C09F50
	internal bool TryGetInt16Core(out short value, ReadOnlySpan<byte> span) { }

	// RVA: 0x1C0A200 Offset: 0x1C09400 VA: 0x181C0A200
	public bool TryGetInt32(out int value) { }

	// RVA: 0x1C0A130 Offset: 0x1C09330 VA: 0x181C0A130
	internal bool TryGetInt32Core(out int value, ReadOnlySpan<byte> span) { }

	// RVA: 0x1C0A3E0 Offset: 0x1C095E0 VA: 0x181C0A3E0
	public bool TryGetInt64(out long value) { }

	// RVA: 0x1C0A310 Offset: 0x1C09510 VA: 0x181C0A310
	internal bool TryGetInt64Core(out long value, ReadOnlySpan<byte> span) { }

	[CLSCompliant(False)]
	// RVA: 0x1C0B190 Offset: 0x1C0A390 VA: 0x181C0B190
	public bool TryGetUInt16(out ushort value) { }

	// RVA: 0x1C0B0C0 Offset: 0x1C0A2C0 VA: 0x181C0B0C0
	internal bool TryGetUInt16Core(out ushort value, ReadOnlySpan<byte> span) { }

	[CLSCompliant(False)]
	// RVA: 0x1C0B370 Offset: 0x1C0A570 VA: 0x181C0B370
	public bool TryGetUInt32(out uint value) { }

	// RVA: 0x1C0B2A0 Offset: 0x1C0A4A0 VA: 0x181C0B2A0
	internal bool TryGetUInt32Core(out uint value, ReadOnlySpan<byte> span) { }

	[CLSCompliant(False)]
	// RVA: 0x1C0B550 Offset: 0x1C0A750 VA: 0x181C0B550
	public bool TryGetUInt64(out ulong value) { }

	// RVA: 0x1C0B480 Offset: 0x1C0A680 VA: 0x181C0B480
	internal bool TryGetUInt64Core(out ulong value, ReadOnlySpan<byte> span) { }

	// RVA: 0x1C0AEF0 Offset: 0x1C0A0F0 VA: 0x181C0AEF0
	public bool TryGetSingle(out float value) { }

	// RVA: 0x1C09A10 Offset: 0x1C08C10 VA: 0x181C09A10
	public bool TryGetDouble(out double value) { }

	// RVA: 0x1C09830 Offset: 0x1C08A30 VA: 0x181C09830
	public bool TryGetDecimal(out Decimal value) { }

	// RVA: 0x1C097E0 Offset: 0x1C089E0 VA: 0x181C097E0
	public bool TryGetDateTime(out DateTime value) { }

	// RVA: 0x1C09070 Offset: 0x1C08270 VA: 0x181C09070
	internal bool TryGetDateTimeCore(out DateTime value) { }

	// RVA: 0x1C09790 Offset: 0x1C08990 VA: 0x181C09790
	public bool TryGetDateTimeOffset(out DateTimeOffset value) { }

	// RVA: 0x1C09400 Offset: 0x1C08600 VA: 0x181C09400
	internal bool TryGetDateTimeOffsetCore(out DateTimeOffset value) { }

	// RVA: 0x1C09F00 Offset: 0x1C09100 VA: 0x181C09F00
	public bool TryGetGuid(out Guid value) { }

	// RVA: 0x1C09BE0 Offset: 0x1C08DE0 VA: 0x181C09BE0
	internal bool TryGetGuidCore(out Guid value) { }
}

// Namespace: System.Text.Json
internal sealed class Arguments<TArg0, TArg1, TArg2, TArg3> // TypeDefIndex: 15869
{
	// Fields
	public TArg0 Arg0; // 0x0
	public TArg1 Arg1; // 0x0
	public TArg2 Arg2; // 0x0
	public TArg3 Arg3; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-Arguments<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json
internal class ArgumentState // TypeDefIndex: 15870
{
	// Fields
	public object Arguments; // 0x10
	public ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>[] FoundProperties; // 0x18
	public ValueTuple<JsonPropertyInfo, object, string>[] FoundPropertiesAsync; // 0x20
	public int FoundPropertyCount; // 0x28
	public JsonParameterInfo JsonParameterInfo; // 0x30
	public int ParameterIndex; // 0x38
	public List<ParameterRef> ParameterRefCache; // 0x40
	public bool FoundKey; // 0x48
	public bool FoundValue; // 0x49

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Text.Json
internal enum ClassType // TypeDefIndex: 15871
{
	// Fields
	public byte value__; // 0x0
	public const ClassType None = 0;
	public const ClassType Object = 1;
	public const ClassType Value = 2;
	public const ClassType NewValue = 4;
	public const ClassType Enumerable = 8;
	public const ClassType Dictionary = 16;
}

// Namespace: System.Text.Json
internal sealed class JsonCamelCaseNamingPolicy : JsonNamingPolicy // TypeDefIndex: 15872
{
	// Methods

	// RVA: 0x1C0D9B0 Offset: 0x1C0CBB0 VA: 0x181C0D9B0 Slot: 4
	public override string ConvertName(string name) { }

	// RVA: 0x1C0DAA0 Offset: 0x1C0CCA0 VA: 0x181C0DAA0
	private static void FixCasing(Span<char> chars) { }

	// RVA: 0x1C0DC70 Offset: 0x1C0CE70 VA: 0x181C0DC70
	public void .ctor() { }
}

// Namespace: 
public sealed class JsonClassInfo.ConstructorDelegate : MulticastDelegate // TypeDefIndex: 15873
{
	// Methods

	// RVA: 0x1202980 Offset: 0x1201B80 VA: 0x181202980
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual object Invoke() { }
}

// Namespace: 
public sealed class JsonClassInfo.ParameterizedConstructorDelegate<T> : MulticastDelegate // TypeDefIndex: 15874
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7D3D0 Offset: 0xB7C5D0 VA: 0x180B7D3D0
	|-JsonClassInfo.ParameterizedConstructorDelegate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual T Invoke(object[] arguments) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-JsonClassInfo.ParameterizedConstructorDelegate<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
public sealed class JsonClassInfo.ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3> : MulticastDelegate // TypeDefIndex: 15875
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7D4E0 Offset: 0xB7C6E0 VA: 0x180B7D4E0
	|-JsonClassInfo.ParameterizedConstructorDelegate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual T Invoke(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x449250 Offset: 0x448450 VA: 0x180449250
	|-JsonClassInfo.ParameterizedConstructorDelegate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class JsonClassInfo.ParameterLookupKey // TypeDefIndex: 15876
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

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string name, Type type) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Type get_Type() { }

	// RVA: 0x1C1ADC0 Offset: 0x1C19FC0 VA: 0x181C1ADC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C1ACE0 Offset: 0x1C19EE0 VA: 0x181C1ACE0 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: 
private sealed class JsonClassInfo.ParameterLookupValue // TypeDefIndex: 15877
{
	// Fields
	[CompilerGenerated]
	private string <DuplicateName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly JsonPropertyInfo <JsonPropertyInfo>k__BackingField; // 0x18

	// Properties
	public string DuplicateName { get; set; }
	public JsonPropertyInfo JsonPropertyInfo { get; }

	// Methods

	// RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	public void .ctor(JsonPropertyInfo jsonPropertyInfo) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_DuplicateName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_DuplicateName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public JsonPropertyInfo get_JsonPropertyInfo() { }
}

// Namespace: System.Text.Json
[DebuggerDisplay("ClassType.{ClassType}, {Type.Name}")]
[DebuggerDisplay("ClassType.{ClassType}, {Type.Name}")]
internal sealed class JsonClassInfo // TypeDefIndex: 15878
{
	// Fields
	[CompilerGenerated]
	private JsonClassInfo.ConstructorDelegate <CreateObject>k__BackingField; // 0x10
	[CompilerGenerated]
	private object <CreateObjectWithArgs>k__BackingField; // 0x18
	[CompilerGenerated]
	private object <AddMethodDelegate>k__BackingField; // 0x20
	[CompilerGenerated]
	private ClassType <ClassType>k__BackingField; // 0x28
	[CompilerGenerated]
	private JsonPropertyInfo <DataExtensionProperty>k__BackingField; // 0x30
	private JsonClassInfo _elementClassInfo; // 0x38
	[CompilerGenerated]
	private Type <ElementType>k__BackingField; // 0x40
	[CompilerGenerated]
	private JsonSerializerOptions <Options>k__BackingField; // 0x48
	[CompilerGenerated]
	private Type <Type>k__BackingField; // 0x50
	[CompilerGenerated]
	private JsonPropertyInfo <PropertyInfoForClassInfo>k__BackingField; // 0x58
	public static readonly Type ObjectType; // 0x0
	[CompilerGenerated]
	private int <ParameterCount>k__BackingField; // 0x60
	public Dictionary<string, JsonParameterInfo> ParameterCache; // 0x68
	public Dictionary<string, JsonPropertyInfo> PropertyCache; // 0x70
	public JsonPropertyInfo[] PropertyCacheArray; // 0x78
	private ParameterRef[] _parameterRefsSorted; // 0x80
	private PropertyRef[] _propertyRefsSorted; // 0x88

	// Properties
	public JsonClassInfo.ConstructorDelegate CreateObject { get; set; }
	public object CreateObjectWithArgs { get; set; }
	public object AddMethodDelegate { get; set; }
	public ClassType ClassType { get; set; }
	public JsonPropertyInfo DataExtensionProperty { get; set; }
	public JsonClassInfo ElementClassInfo { get; }
	public Type ElementType { get; set; }
	public JsonSerializerOptions Options { get; set; }
	public Type Type { get; set; }
	public JsonPropertyInfo PropertyInfoForClassInfo { get; set; }
	public int ParameterCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public JsonClassInfo.ConstructorDelegate get_CreateObject() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_CreateObject(JsonClassInfo.ConstructorDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public object get_CreateObjectWithArgs() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_CreateObjectWithArgs(object value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public object get_AddMethodDelegate() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_AddMethodDelegate(object value) { }

	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public ClassType get_ClassType() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	private void set_ClassType(ClassType value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public JsonPropertyInfo get_DataExtensionProperty() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_DataExtensionProperty(JsonPropertyInfo value) { }

	// RVA: 0x1C11F80 Offset: 0x1C11180 VA: 0x181C11F80
	public JsonClassInfo get_ElementClassInfo() { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Type get_ElementType() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_ElementType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public JsonSerializerOptions get_Options() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	private void set_Options(JsonSerializerOptions value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	private void set_Type(Type value) { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public JsonPropertyInfo get_PropertyInfoForClassInfo() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	private void set_PropertyInfoForClassInfo(JsonPropertyInfo value) { }

	// RVA: 0x1C11110 Offset: 0x1C10310 VA: 0x181C11110
	public void .ctor(Type type, JsonSerializerOptions options) { }

	// RVA: 0x1C0E020 Offset: 0x1C0D220 VA: 0x181C0E020
	private void CacheMember(Type declaringType, Type memberType, MemberInfo memberInfo, Nullable<JsonNumberHandling> typeNumberHandling, Dictionary<string, JsonPropertyInfo> cache, ref Dictionary<string, MemberInfo> ignoredMembers) { }

	// RVA: 0x1C0FD80 Offset: 0x1C0EF80 VA: 0x181C0FD80
	private void InitializeConstructorParameters(ConstructorInfo constructorInfo) { }

	// RVA: 0x1C10830 Offset: 0x1C0FA30 VA: 0x181C10830
	private static bool PropertyIsOverridenAndIgnored(MemberInfo currentMember, Dictionary<string, MemberInfo> ignoredMembers) { }

	// RVA: 0x1C10A80 Offset: 0x1C0FC80 VA: 0x181C10A80
	private static bool PropertyIsVirtual(PropertyInfo propertyInfo) { }

	// RVA: 0x1C0E600 Offset: 0x1C0D800 VA: 0x181C0E600
	public bool DetermineExtensionDataProperty(Dictionary<string, JsonPropertyInfo> cache) { }

	// RVA: 0x1C0F400 Offset: 0x1C0E600 VA: 0x181C0F400
	private static JsonPropertyInfo GetPropertyWithUniqueAttribute(Type classType, Type attributeType, Dictionary<string, JsonPropertyInfo> cache) { }

	// RVA: 0x1C0DCC0 Offset: 0x1C0CEC0 VA: 0x181C0DCC0
	private static JsonParameterInfo AddConstructorParameter(ParameterInfo parameterInfo, JsonPropertyInfo jsonPropertyInfo, JsonSerializerOptions options) { }

	// RVA: 0x1C0E7B0 Offset: 0x1C0D9B0 VA: 0x181C0E7B0
	public static JsonConverter GetConverter(Type type, Type parentClassType, MemberInfo memberInfo, out Type runtimeType, JsonSerializerOptions options) { }

	// RVA: 0x1C10E90 Offset: 0x1C10090 VA: 0x181C10E90
	private static void ValidateType(Type type, Type parentClassType, MemberInfo memberInfo, JsonSerializerOptions options) { }

	// RVA: 0x1C104B0 Offset: 0x1C0F6B0 VA: 0x181C104B0
	private static bool IsInvalidForSerialization(Type type) { }

	// RVA: 0x1C103B0 Offset: 0x1C0F5B0 VA: 0x181C103B0
	private static bool IsByRefLike(Type type) { }

	// RVA: 0x1C0EAA0 Offset: 0x1C0DCA0 VA: 0x181C0EAA0
	private static Nullable<JsonNumberHandling> GetNumberHandlingForType(Type type) { }

	[CompilerGenerated]
	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public int get_ParameterCount() { }

	[CompilerGenerated]
	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	private void set_ParameterCount(int value) { }

	// RVA: 0x1C0DE20 Offset: 0x1C0D020 VA: 0x181C0DE20
	public static JsonPropertyInfo AddProperty(MemberInfo memberInfo, Type memberType, Type parentClassType, Nullable<JsonNumberHandling> parentTypeNumberHandling, JsonSerializerOptions options) { }

	// RVA: 0x1C0E510 Offset: 0x1C0D710 VA: 0x181C0E510
	internal static JsonPropertyInfo CreateProperty(Type declaredPropertyType, Type runtimePropertyType, MemberInfo memberInfo, Type parentClassType, JsonConverter converter, JsonSerializerOptions options, Nullable<JsonNumberHandling> parentTypeNumberHandling, Nullable<JsonIgnoreCondition> ignoreCondition) { }

	// RVA: 0x1C0E460 Offset: 0x1C0D660 VA: 0x181C0E460
	internal static JsonPropertyInfo CreatePropertyInfoForClassInfo(Type declaredPropertyType, Type runtimePropertyType, JsonConverter converter, JsonSerializerOptions options) { }

	// RVA: 0x1C0F590 Offset: 0x1C0E790 VA: 0x181C0F590
	public JsonPropertyInfo GetProperty(ReadOnlySpan<byte> propertyName, ref ReadStackFrame frame, out byte[] utf8PropertyName) { }

	// RVA: 0x1C0EC30 Offset: 0x1C0DE30 VA: 0x181C0EC30
	public JsonParameterInfo GetParameter(ReadOnlySpan<byte> propertyName, ref ReadStackFrame frame, out byte[] utf8PropertyName) { }

	// RVA: 0x1C10720 Offset: 0x1C0F920 VA: 0x181C10720
	private static bool IsPropertyRefEqual(in PropertyRef propertyRef, ReadOnlySpan<byte> propertyName, ulong key) { }

	// RVA: 0x1C10610 Offset: 0x1C0F810 VA: 0x181C10610
	private static bool IsParameterRefEqual(in ParameterRef parameterRef, ReadOnlySpan<byte> parameterName, ulong key) { }

	// RVA: 0x1C0E990 Offset: 0x1C0DB90 VA: 0x181C0E990
	public static ulong GetKey(ReadOnlySpan<byte> name) { }

	// RVA: 0x1C10D30 Offset: 0x1C0FF30 VA: 0x181C10D30
	public void UpdateSortedPropertyCache(ref ReadStackFrame frame) { }

	// RVA: 0x1C10BC0 Offset: 0x1C0FDC0 VA: 0x181C10BC0
	public void UpdateSortedParameterCache(ref ReadStackFrame frame) { }

	// RVA: 0x1C11090 Offset: 0x1C10290 VA: 0x181C11090
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1C10B10 Offset: 0x1C0FD10 VA: 0x181C10B10
	internal static Type <InitializeConstructorParameters>g__GetMemberType|46_0(MemberInfo memberInfo) { }
}

// Namespace: System.Text.Json
internal class JsonDefaultNamingPolicy : JsonNamingPolicy // TypeDefIndex: 15879
{
	// Methods

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 4
	public override string ConvertName(string name) { }

	// RVA: 0x1C12010 Offset: 0x1C11210 VA: 0x181C12010
	public void .ctor() { }
}

// Namespace: System.Text.Json
[NullableContext(1)]
[Nullable(0)]
internal abstract class JsonNamingPolicy // TypeDefIndex: 15880
{
	// Fields
	[CompilerGenerated]
	private static readonly JsonNamingPolicy <CamelCase>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly JsonNamingPolicy <Default>k__BackingField; // 0x8

	// Properties
	public static JsonNamingPolicy CamelCase { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C12160 Offset: 0x1C11360 VA: 0x181C12160
	public static JsonNamingPolicy get_CamelCase() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string ConvertName(string name);

	// RVA: 0x1C12060 Offset: 0x1C11260 VA: 0x181C12060
	private static void .cctor() { }
}

// Namespace: System.Text.Json
internal abstract class JsonParameterInfo // TypeDefIndex: 15881
{
	// Fields
	[CompilerGenerated]
	private JsonConverter <ConverterBase>k__BackingField; // 0x10
	[CompilerGenerated]
	private object <DefaultValue>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IgnoreDefaultValuesOnRead>k__BackingField; // 0x20
	[CompilerGenerated]
	private JsonSerializerOptions <Options>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <NameAsUtf8Bytes>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<JsonNumberHandling> <NumberHandling>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <Position>k__BackingField; // 0x40
	private JsonClassInfo _runtimeClassInfo; // 0x48
	[CompilerGenerated]
	private Type <RuntimePropertyType>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <ShouldDeserialize>k__BackingField; // 0x58

	// Properties
	public JsonConverter ConverterBase { get; set; }
	public object DefaultValue { get; set; }
	public bool IgnoreDefaultValuesOnRead { get; set; }
	public JsonSerializerOptions Options { get; set; }
	public byte[] NameAsUtf8Bytes { get; set; }
	public Nullable<JsonNumberHandling> NumberHandling { get; set; }
	public int Position { get; set; }
	public JsonClassInfo RuntimeClassInfo { get; }
	internal Type RuntimePropertyType { get; set; }
	public bool ShouldDeserialize { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public JsonConverter get_ConverterBase() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_ConverterBase(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public object get_DefaultValue() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	protected void set_DefaultValue(object value) { }

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IgnoreDefaultValuesOnRead() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	private void set_IgnoreDefaultValuesOnRead(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public JsonSerializerOptions get_Options() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Options(JsonSerializerOptions value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public byte[] get_NameAsUtf8Bytes() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_NameAsUtf8Bytes(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Nullable<JsonNumberHandling> get_NumberHandling() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_NumberHandling(Nullable<JsonNumberHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public int get_Position() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	private void set_Position(int value) { }

	// RVA: 0x1C12310 Offset: 0x1C11510 VA: 0x181C12310
	public JsonClassInfo get_RuntimeClassInfo() { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal Type get_RuntimePropertyType() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	internal void set_RuntimePropertyType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30
	public bool get_ShouldDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x4D1A70 Offset: 0x4D0C70 VA: 0x1804D1A70
	private void set_ShouldDeserialize(bool value) { }

	// RVA: 0x1C12280 Offset: 0x1C11480 VA: 0x181C12280 Slot: 4
	public virtual void Initialize(Type runtimePropertyType, ParameterInfo parameterInfo, JsonPropertyInfo matchingProperty, JsonSerializerOptions options) { }

	// RVA: 0x1C121B0 Offset: 0x1C113B0 VA: 0x181C121B0
	public static JsonParameterInfo CreateIgnoredParameterPlaceholder(JsonPropertyInfo matchingProperty) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Text.Json
internal class JsonParameterInfo<T> : JsonParameterInfo // TypeDefIndex: 15882
{
	// Fields
	[CompilerGenerated]
	private T <TypedDefaultValue>k__BackingField; // 0x0

	// Properties
	public T TypedDefaultValue { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_TypedDefaultValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DC690 Offset: 0x12DB890 VA: 0x1812DC690
	|-JsonParameterInfo<Nullable<IntPtr>>.get_TypedDefaultValue
	|-JsonParameterInfo<Nullable<UIntPtr>>.get_TypedDefaultValue
	|-JsonParameterInfo<DateTimeOffset>.get_TypedDefaultValue
	|-JsonParameterInfo<Decimal>.get_TypedDefaultValue
	|-JsonParameterInfo<Guid>.get_TypedDefaultValue
	|-JsonParameterInfo<JsonElement>.get_TypedDefaultValue
	|
	|-RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290
	|-JsonParameterInfo<bool>.get_TypedDefaultValue
	|-JsonParameterInfo<byte>.get_TypedDefaultValue
	|-JsonParameterInfo<sbyte>.get_TypedDefaultValue
	|
	|-RVA: 0x12DC6A0 Offset: 0x12DB8A0 VA: 0x1812DC6A0
	|-JsonParameterInfo<char>.get_TypedDefaultValue
	|-JsonParameterInfo<short>.get_TypedDefaultValue
	|-JsonParameterInfo<ushort>.get_TypedDefaultValue
	|
	|-RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	|-JsonParameterInfo<DateTime>.get_TypedDefaultValue
	|-JsonParameterInfo<long>.get_TypedDefaultValue
	|-JsonParameterInfo<IntPtr>.get_TypedDefaultValue
	|-JsonParameterInfo<object>.get_TypedDefaultValue
	|-JsonParameterInfo<ulong>.get_TypedDefaultValue
	|-JsonParameterInfo<UIntPtr>.get_TypedDefaultValue
	|
	|-RVA: 0x12DC6B0 Offset: 0x12DB8B0 VA: 0x1812DC6B0
	|-JsonParameterInfo<double>.get_TypedDefaultValue
	|
	|-RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	|-JsonParameterInfo<int>.get_TypedDefaultValue
	|-JsonParameterInfo<uint>.get_TypedDefaultValue
	|
	|-RVA: 0x6D7F60 Offset: 0x6D7160 VA: 0x1806D7F60
	|-JsonParameterInfo<float>.get_TypedDefaultValue
	|
	|-RVA: 0xB16E40 Offset: 0xB16040 VA: 0x180B16E40
	|-JsonParameterInfo<__Il2CppFullySharedGenericType>.get_TypedDefaultValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_TypedDefaultValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DC6D0 Offset: 0x12DB8D0 VA: 0x1812DC6D0
	|-JsonParameterInfo<Nullable<IntPtr>>.set_TypedDefaultValue
	|-JsonParameterInfo<Nullable<UIntPtr>>.set_TypedDefaultValue
	|-JsonParameterInfo<DateTimeOffset>.set_TypedDefaultValue
	|-JsonParameterInfo<Decimal>.set_TypedDefaultValue
	|-JsonParameterInfo<Guid>.set_TypedDefaultValue
	|-JsonParameterInfo<JsonElement>.set_TypedDefaultValue
	|
	|-RVA: 0x4EE2A0 Offset: 0x4ED4A0 VA: 0x1804EE2A0
	|-JsonParameterInfo<bool>.set_TypedDefaultValue
	|-JsonParameterInfo<byte>.set_TypedDefaultValue
	|-JsonParameterInfo<sbyte>.set_TypedDefaultValue
	|
	|-RVA: 0x12DC6C0 Offset: 0x12DB8C0 VA: 0x1812DC6C0
	|-JsonParameterInfo<char>.set_TypedDefaultValue
	|-JsonParameterInfo<short>.set_TypedDefaultValue
	|-JsonParameterInfo<ushort>.set_TypedDefaultValue
	|
	|-RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	|-JsonParameterInfo<DateTime>.set_TypedDefaultValue
	|-JsonParameterInfo<long>.set_TypedDefaultValue
	|-JsonParameterInfo<IntPtr>.set_TypedDefaultValue
	|-JsonParameterInfo<object>.set_TypedDefaultValue
	|-JsonParameterInfo<ulong>.set_TypedDefaultValue
	|-JsonParameterInfo<UIntPtr>.set_TypedDefaultValue
	|
	|-RVA: 0x12DC6E0 Offset: 0x12DB8E0 VA: 0x1812DC6E0
	|-JsonParameterInfo<double>.set_TypedDefaultValue
	|
	|-RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	|-JsonParameterInfo<int>.set_TypedDefaultValue
	|-JsonParameterInfo<uint>.set_TypedDefaultValue
	|
	|-RVA: 0x56E660 Offset: 0x56D860 VA: 0x18056E660
	|-JsonParameterInfo<float>.set_TypedDefaultValue
	|
	|-RVA: 0xCDEA80 Offset: 0xCDDC80 VA: 0x180CDEA80
	|-JsonParameterInfo<__Il2CppFullySharedGenericType>.set_TypedDefaultValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Initialize(Type runtimePropertyType, ParameterInfo parameterInfo, JsonPropertyInfo matchingProperty, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DC1E0 Offset: 0x12DB3E0 VA: 0x1812DC1E0
	|-JsonParameterInfo<Nullable<IntPtr>>.Initialize
	|-JsonParameterInfo<Nullable<UIntPtr>>.Initialize
	|
	|-RVA: 0x12DBF20 Offset: 0x12DB120 VA: 0x1812DBF20
	|-JsonParameterInfo<bool>.Initialize
	|-JsonParameterInfo<byte>.Initialize
	|-JsonParameterInfo<sbyte>.Initialize
	|
	|-RVA: 0x12DB9C0 Offset: 0x12DABC0 VA: 0x1812DB9C0
	|-JsonParameterInfo<char>.Initialize
	|-JsonParameterInfo<short>.Initialize
	|-JsonParameterInfo<ushort>.Initialize
	|
	|-RVA: 0x12DBC60 Offset: 0x12DAE60 VA: 0x1812DBC60
	|-JsonParameterInfo<DateTime>.Initialize
	|-JsonParameterInfo<long>.Initialize
	|-JsonParameterInfo<IntPtr>.Initialize
	|-JsonParameterInfo<ulong>.Initialize
	|-JsonParameterInfo<UIntPtr>.Initialize
	|
	|-RVA: 0x12DB860 Offset: 0x12DAA60 VA: 0x1812DB860
	|-JsonParameterInfo<DateTimeOffset>.Initialize
	|-JsonParameterInfo<Decimal>.Initialize
	|-JsonParameterInfo<Guid>.Initialize
	|-JsonParameterInfo<JsonElement>.Initialize
	|
	|-RVA: 0x12DC530 Offset: 0x12DB730 VA: 0x1812DC530
	|-JsonParameterInfo<double>.Initialize
	|
	|-RVA: 0x12DC080 Offset: 0x12DB280 VA: 0x1812DC080
	|-JsonParameterInfo<int>.Initialize
	|-JsonParameterInfo<uint>.Initialize
	|
	|-RVA: 0x12DBB20 Offset: 0x12DAD20 VA: 0x1812DBB20
	|-JsonParameterInfo<object>.Initialize
	|
	|-RVA: 0x12DBDC0 Offset: 0x12DAFC0 VA: 0x1812DBDC0
	|-JsonParameterInfo<float>.Initialize
	|
	|-RVA: 0x12DC350 Offset: 0x12DB550 VA: 0x1812DC350
	|-JsonParameterInfo<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	|-JsonParameterInfo<Nullable<IntPtr>>..ctor
	|-JsonParameterInfo<Nullable<UIntPtr>>..ctor
	|-JsonParameterInfo<bool>..ctor
	|-JsonParameterInfo<byte>..ctor
	|-JsonParameterInfo<char>..ctor
	|-JsonParameterInfo<DateTime>..ctor
	|-JsonParameterInfo<DateTimeOffset>..ctor
	|-JsonParameterInfo<Decimal>..ctor
	|-JsonParameterInfo<double>..ctor
	|-JsonParameterInfo<Guid>..ctor
	|-JsonParameterInfo<short>..ctor
	|-JsonParameterInfo<int>..ctor
	|-JsonParameterInfo<long>..ctor
	|-JsonParameterInfo<IntPtr>..ctor
	|-JsonParameterInfo<JsonElement>..ctor
	|-JsonParameterInfo<object>..ctor
	|-JsonParameterInfo<sbyte>..ctor
	|-JsonParameterInfo<float>..ctor
	|-JsonParameterInfo<ushort>..ctor
	|-JsonParameterInfo<uint>..ctor
	|-JsonParameterInfo<ulong>..ctor
	|-JsonParameterInfo<UIntPtr>..ctor
	|-JsonParameterInfo<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json
[DebuggerDisplay("MemberInfo={MemberInfo}")]
internal abstract class JsonPropertyInfo // TypeDefIndex: 15883
{
	// Fields
	public static readonly JsonPropertyInfo s_missingProperty; // 0x0
	private JsonClassInfo _runtimeClassInfo; // 0x10
	public ClassType ClassType; // 0x18
	[CompilerGenerated]
	private Type <DeclaredPropertyType>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <HasGetter>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <HasSetter>k__BackingField; // 0x29
	[CompilerGenerated]
	private bool <IgnoreDefaultValuesOnRead>k__BackingField; // 0x2A
	[CompilerGenerated]
	private bool <IgnoreDefaultValuesOnWrite>k__BackingField; // 0x2B
	[CompilerGenerated]
	private bool <IsForClassInfo>k__BackingField; // 0x2C
	[CompilerGenerated]
	private string <NameAsString>k__BackingField; // 0x30
	public byte[] NameAsUtf8Bytes; // 0x38
	public byte[] EscapedNameSection; // 0x40
	[CompilerGenerated]
	private JsonSerializerOptions <Options>k__BackingField; // 0x48
	[CompilerGenerated]
	private Type <ParentClassType>k__BackingField; // 0x50
	[CompilerGenerated]
	private MemberInfo <MemberInfo>k__BackingField; // 0x58
	[CompilerGenerated]
	private Type <RuntimePropertyType>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <ShouldSerialize>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <ShouldDeserialize>k__BackingField; // 0x69
	[CompilerGenerated]
	private bool <IsIgnored>k__BackingField; // 0x6A
	[CompilerGenerated]
	private Nullable<JsonNumberHandling> <NumberHandling>k__BackingField; // 0x6C
	[CompilerGenerated]
	private bool <PropertyTypeCanBeNull>k__BackingField; // 0x74

	// Properties
	public abstract JsonConverter ConverterBase { get; set; }
	public Type DeclaredPropertyType { get; set; }
	public bool HasGetter { get; set; }
	public bool HasSetter { get; set; }
	public bool IgnoreDefaultValuesOnRead { get; set; }
	public bool IgnoreDefaultValuesOnWrite { get; set; }
	public bool IsForClassInfo { get; set; }
	public string NameAsString { get; set; }
	protected JsonSerializerOptions Options { get; set; }
	public Type ParentClassType { get; set; }
	public MemberInfo MemberInfo { get; set; }
	public JsonClassInfo RuntimeClassInfo { get; }
	public Type RuntimePropertyType { get; set; }
	public bool ShouldSerialize { get; set; }
	public bool ShouldDeserialize { get; set; }
	public bool IsIgnored { get; set; }
	public Nullable<JsonNumberHandling> NumberHandling { get; set; }
	public bool PropertyTypeCanBeNull { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract JsonConverter get_ConverterBase();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_ConverterBase(JsonConverter value);

	// RVA: 0x1C12CA0 Offset: 0x1C11EA0 VA: 0x181C12CA0
	public static JsonPropertyInfo GetPropertyPlaceholder() { }

	// RVA: 0x1C12350 Offset: 0x1C11550 VA: 0x181C12350
	public static JsonPropertyInfo CreateIgnoredPropertyPlaceholder(MemberInfo memberInfo, JsonSerializerOptions options) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Type get_DeclaredPropertyType() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_DeclaredPropertyType(Type value) { }

	// RVA: 0x1C12AC0 Offset: 0x1C11CC0 VA: 0x181C12AC0 Slot: 6
	public virtual void GetPolicies(Nullable<JsonIgnoreCondition> ignoreCondition, Nullable<JsonNumberHandling> parentTypeNumberHandling, bool defaultValueIsNull) { }

	// RVA: 0x1C126B0 Offset: 0x1C118B0 VA: 0x181C126B0
	private void DeterminePropertyName() { }

	// RVA: 0x1C129C0 Offset: 0x1C11BC0 VA: 0x181C129C0
	private void DetermineSerializationCapabilities(Nullable<JsonIgnoreCondition> ignoreCondition) { }

	// RVA: 0x1C123E0 Offset: 0x1C115E0 VA: 0x181C123E0
	private void DetermineIgnoreCondition(Nullable<JsonIgnoreCondition> ignoreCondition, bool defaultValueIsNull) { }

	// RVA: 0x1C124D0 Offset: 0x1C116D0 VA: 0x181C124D0
	private void DetermineNumberHandling(Nullable<JsonNumberHandling> parentTypeNumberHandling) { }

	// RVA: -1 Offset: -1
	public static TAttribute GetAttribute<TAttribute>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2A5B0 Offset: 0xA297B0 VA: 0x180A2A5B0
	|-JsonPropertyInfo.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool GetMemberAndWriteJson(object obj, ref WriteStack state, Utf8JsonWriter writer);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool GetMemberAndWriteJsonExtensionData(object obj, ref WriteStack state, Utf8JsonWriter writer);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object GetValueAsObject(object obj);

	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_HasGetter() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_HasGetter(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4C6AB0 Offset: 0x4C5CB0 VA: 0x1804C6AB0
	public bool get_HasSetter() { }

	[CompilerGenerated]
	// RVA: 0x4C6AE0 Offset: 0x4C5CE0 VA: 0x1804C6AE0
	public void set_HasSetter(bool value) { }

	// RVA: 0x1C12D30 Offset: 0x1C11F30 VA: 0x181C12D30 Slot: 10
	public virtual void Initialize(Type parentClassType, Type declaredPropertyType, Type runtimePropertyType, ClassType runtimeClassType, MemberInfo memberInfo, JsonConverter converter, Nullable<JsonIgnoreCondition> ignoreCondition, Nullable<JsonNumberHandling> parentTypeNumberHandling, JsonSerializerOptions options) { }

	[CompilerGenerated]
	// RVA: 0x4C6AA0 Offset: 0x4C5CA0 VA: 0x1804C6AA0
	public bool get_IgnoreDefaultValuesOnRead() { }

	[CompilerGenerated]
	// RVA: 0x4C6AD0 Offset: 0x4C5CD0 VA: 0x1804C6AD0
	private void set_IgnoreDefaultValuesOnRead(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4C6AC0 Offset: 0x4C5CC0 VA: 0x1804C6AC0
	public bool get_IgnoreDefaultValuesOnWrite() { }

	[CompilerGenerated]
	// RVA: 0x4C6AF0 Offset: 0x4C5CF0 VA: 0x1804C6AF0
	private void set_IgnoreDefaultValuesOnWrite(bool value) { }

	[CompilerGenerated]
	// RVA: 0x48DA50 Offset: 0x48CC50 VA: 0x18048DA50
	public bool get_IsForClassInfo() { }

	[CompilerGenerated]
	// RVA: 0x48DA70 Offset: 0x48CC70 VA: 0x18048DA70
	protected void set_IsForClassInfo(bool value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_NameAsString() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_NameAsString(string value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	protected JsonSerializerOptions get_Options() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	protected void set_Options(JsonSerializerOptions value) { }

	// RVA: 0x1C12D80 Offset: 0x1C11F80 VA: 0x181C12D80
	public bool ReadJsonAndAddExtensionProperty(object obj, ref ReadStack state, ref Utf8JsonReader reader) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool ReadJsonAndSetMember(object obj, ref ReadStack state, ref Utf8JsonReader reader);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool ReadJsonAsObject(ref ReadStack state, ref Utf8JsonReader reader, out object value);

	// RVA: 0x1C13180 Offset: 0x1C12380 VA: 0x181C13180
	public bool ReadJsonExtensionDataValue(ref ReadStack state, ref Utf8JsonReader reader, out object value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public Type get_ParentClassType() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	private void set_ParentClassType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public MemberInfo get_MemberInfo() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	private void set_MemberInfo(MemberInfo value) { }

	// RVA: 0x1C134B0 Offset: 0x1C126B0 VA: 0x181C134B0
	public JsonClassInfo get_RuntimeClassInfo() { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public Type get_RuntimePropertyType() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	private void set_RuntimePropertyType(Type value) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void SetExtensionDictionaryAsObject(object obj, object extensionDict);

	[CompilerGenerated]
	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	public bool get_ShouldSerialize() { }

	[CompilerGenerated]
	// RVA: 0x563E60 Offset: 0x563060 VA: 0x180563E60
	private void set_ShouldSerialize(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C134F0 Offset: 0x1C126F0 VA: 0x181C134F0
	public bool get_ShouldDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x1C13530 Offset: 0x1C12730 VA: 0x181C13530
	private void set_ShouldDeserialize(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C13490 Offset: 0x1C12690 VA: 0x181C13490
	public bool get_IsIgnored() { }

	[CompilerGenerated]
	// RVA: 0x1C13500 Offset: 0x1C12700 VA: 0x181C13500
	private void set_IsIgnored(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C134A0 Offset: 0x1C126A0 VA: 0x181C134A0
	public Nullable<JsonNumberHandling> get_NumberHandling() { }

	[CompilerGenerated]
	// RVA: 0x1C13510 Offset: 0x1C12710 VA: 0x181C13510
	private void set_NumberHandling(Nullable<JsonNumberHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x8CA2F0 Offset: 0x8C94F0 VA: 0x1808CA2F0
	public bool get_PropertyTypeCanBeNull() { }

	[CompilerGenerated]
	// RVA: 0x1C13520 Offset: 0x1C12720 VA: 0x181C13520
	protected void set_PropertyTypeCanBeNull(bool value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x1C133E0 Offset: 0x1C125E0 VA: 0x181C133E0
	private static void .cctor() { }
}

// Namespace: System.Text.Json
internal sealed class JsonPropertyInfo<T> : JsonPropertyInfo // TypeDefIndex: 15884
{
	// Fields
	private bool _converterIsExternalAndPolymorphic; // 0x0
	[CompilerGenerated]
	private Func<object, T> <Get>k__BackingField; // 0x0
	[CompilerGenerated]
	private Action<object, T> <Set>k__BackingField; // 0x0
	[CompilerGenerated]
	private JsonConverter<T> <Converter>k__BackingField; // 0x0

	// Properties
	public Func<object, T> Get { get; set; }
	public Action<object, T> Set { get; set; }
	public JsonConverter<T> Converter { get; set; }
	public override JsonConverter ConverterBase { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Func<object, T> get_Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	|-JsonPropertyInfo<Nullable<IntPtr>>.get_Get
	|-JsonPropertyInfo<Nullable<UIntPtr>>.get_Get
	|-JsonPropertyInfo<bool>.get_Get
	|-JsonPropertyInfo<byte>.get_Get
	|-JsonPropertyInfo<char>.get_Get
	|-JsonPropertyInfo<DateTime>.get_Get
	|-JsonPropertyInfo<DateTimeOffset>.get_Get
	|-JsonPropertyInfo<Decimal>.get_Get
	|-JsonPropertyInfo<double>.get_Get
	|-JsonPropertyInfo<Guid>.get_Get
	|-JsonPropertyInfo<short>.get_Get
	|-JsonPropertyInfo<int>.get_Get
	|-JsonPropertyInfo<long>.get_Get
	|-JsonPropertyInfo<IntPtr>.get_Get
	|-JsonPropertyInfo<JsonElement>.get_Get
	|-JsonPropertyInfo<object>.get_Get
	|-JsonPropertyInfo<sbyte>.get_Get
	|-JsonPropertyInfo<float>.get_Get
	|-JsonPropertyInfo<ushort>.get_Get
	|-JsonPropertyInfo<uint>.get_Get
	|-JsonPropertyInfo<ulong>.get_Get
	|-JsonPropertyInfo<UIntPtr>.get_Get
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.get_Get
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Get(Func<object, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	|-JsonPropertyInfo<Nullable<IntPtr>>.set_Get
	|-JsonPropertyInfo<Nullable<UIntPtr>>.set_Get
	|-JsonPropertyInfo<bool>.set_Get
	|-JsonPropertyInfo<byte>.set_Get
	|-JsonPropertyInfo<char>.set_Get
	|-JsonPropertyInfo<DateTime>.set_Get
	|-JsonPropertyInfo<DateTimeOffset>.set_Get
	|-JsonPropertyInfo<Decimal>.set_Get
	|-JsonPropertyInfo<double>.set_Get
	|-JsonPropertyInfo<Guid>.set_Get
	|-JsonPropertyInfo<short>.set_Get
	|-JsonPropertyInfo<int>.set_Get
	|-JsonPropertyInfo<long>.set_Get
	|-JsonPropertyInfo<IntPtr>.set_Get
	|-JsonPropertyInfo<JsonElement>.set_Get
	|-JsonPropertyInfo<object>.set_Get
	|-JsonPropertyInfo<sbyte>.set_Get
	|-JsonPropertyInfo<float>.set_Get
	|-JsonPropertyInfo<ushort>.set_Get
	|-JsonPropertyInfo<uint>.set_Get
	|-JsonPropertyInfo<ulong>.set_Get
	|-JsonPropertyInfo<UIntPtr>.set_Get
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.set_Get
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Action<object, T> get_Set() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	|-JsonPropertyInfo<Nullable<IntPtr>>.get_Set
	|-JsonPropertyInfo<Nullable<UIntPtr>>.get_Set
	|-JsonPropertyInfo<bool>.get_Set
	|-JsonPropertyInfo<byte>.get_Set
	|-JsonPropertyInfo<char>.get_Set
	|-JsonPropertyInfo<DateTime>.get_Set
	|-JsonPropertyInfo<DateTimeOffset>.get_Set
	|-JsonPropertyInfo<Decimal>.get_Set
	|-JsonPropertyInfo<double>.get_Set
	|-JsonPropertyInfo<Guid>.get_Set
	|-JsonPropertyInfo<short>.get_Set
	|-JsonPropertyInfo<int>.get_Set
	|-JsonPropertyInfo<long>.get_Set
	|-JsonPropertyInfo<IntPtr>.get_Set
	|-JsonPropertyInfo<JsonElement>.get_Set
	|-JsonPropertyInfo<object>.get_Set
	|-JsonPropertyInfo<sbyte>.get_Set
	|-JsonPropertyInfo<float>.get_Set
	|-JsonPropertyInfo<ushort>.get_Set
	|-JsonPropertyInfo<uint>.get_Set
	|-JsonPropertyInfo<ulong>.get_Set
	|-JsonPropertyInfo<UIntPtr>.get_Set
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.get_Set
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Set(Action<object, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	|-JsonPropertyInfo<Nullable<IntPtr>>.set_Set
	|-JsonPropertyInfo<Nullable<UIntPtr>>.set_Set
	|-JsonPropertyInfo<bool>.set_Set
	|-JsonPropertyInfo<byte>.set_Set
	|-JsonPropertyInfo<char>.set_Set
	|-JsonPropertyInfo<DateTime>.set_Set
	|-JsonPropertyInfo<DateTimeOffset>.set_Set
	|-JsonPropertyInfo<Decimal>.set_Set
	|-JsonPropertyInfo<double>.set_Set
	|-JsonPropertyInfo<Guid>.set_Set
	|-JsonPropertyInfo<short>.set_Set
	|-JsonPropertyInfo<int>.set_Set
	|-JsonPropertyInfo<long>.set_Set
	|-JsonPropertyInfo<IntPtr>.set_Set
	|-JsonPropertyInfo<JsonElement>.set_Set
	|-JsonPropertyInfo<object>.set_Set
	|-JsonPropertyInfo<sbyte>.set_Set
	|-JsonPropertyInfo<float>.set_Set
	|-JsonPropertyInfo<ushort>.set_Set
	|-JsonPropertyInfo<uint>.set_Set
	|-JsonPropertyInfo<ulong>.set_Set
	|-JsonPropertyInfo<UIntPtr>.set_Set
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.set_Set
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public JsonConverter<T> get_Converter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	|-JsonPropertyInfo<Nullable<IntPtr>>.get_Converter
	|-JsonPropertyInfo<Nullable<UIntPtr>>.get_Converter
	|-JsonPropertyInfo<bool>.get_Converter
	|-JsonPropertyInfo<byte>.get_Converter
	|-JsonPropertyInfo<char>.get_Converter
	|-JsonPropertyInfo<DateTime>.get_Converter
	|-JsonPropertyInfo<DateTimeOffset>.get_Converter
	|-JsonPropertyInfo<Decimal>.get_Converter
	|-JsonPropertyInfo<double>.get_Converter
	|-JsonPropertyInfo<Guid>.get_Converter
	|-JsonPropertyInfo<short>.get_Converter
	|-JsonPropertyInfo<int>.get_Converter
	|-JsonPropertyInfo<long>.get_Converter
	|-JsonPropertyInfo<IntPtr>.get_Converter
	|-JsonPropertyInfo<JsonElement>.get_Converter
	|-JsonPropertyInfo<object>.get_Converter
	|-JsonPropertyInfo<sbyte>.get_Converter
	|-JsonPropertyInfo<float>.get_Converter
	|-JsonPropertyInfo<ushort>.get_Converter
	|-JsonPropertyInfo<uint>.get_Converter
	|-JsonPropertyInfo<ulong>.get_Converter
	|-JsonPropertyInfo<UIntPtr>.get_Converter
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.get_Converter
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_Converter(JsonConverter<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43B590 Offset: 0x43A790 VA: 0x18043B590
	|-JsonPropertyInfo<Nullable<IntPtr>>.set_Converter
	|-JsonPropertyInfo<Nullable<UIntPtr>>.set_Converter
	|-JsonPropertyInfo<bool>.set_Converter
	|-JsonPropertyInfo<byte>.set_Converter
	|-JsonPropertyInfo<char>.set_Converter
	|-JsonPropertyInfo<DateTime>.set_Converter
	|-JsonPropertyInfo<DateTimeOffset>.set_Converter
	|-JsonPropertyInfo<Decimal>.set_Converter
	|-JsonPropertyInfo<double>.set_Converter
	|-JsonPropertyInfo<Guid>.set_Converter
	|-JsonPropertyInfo<short>.set_Converter
	|-JsonPropertyInfo<int>.set_Converter
	|-JsonPropertyInfo<long>.set_Converter
	|-JsonPropertyInfo<IntPtr>.set_Converter
	|-JsonPropertyInfo<JsonElement>.set_Converter
	|-JsonPropertyInfo<object>.set_Converter
	|-JsonPropertyInfo<sbyte>.set_Converter
	|-JsonPropertyInfo<float>.set_Converter
	|-JsonPropertyInfo<ushort>.set_Converter
	|-JsonPropertyInfo<uint>.set_Converter
	|-JsonPropertyInfo<ulong>.set_Converter
	|-JsonPropertyInfo<UIntPtr>.set_Converter
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.set_Converter
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void Initialize(Type parentClassType, Type declaredPropertyType, Type runtimePropertyType, ClassType runtimeClassType, MemberInfo memberInfo, JsonConverter converter, Nullable<JsonIgnoreCondition> ignoreCondition, Nullable<JsonNumberHandling> parentTypeNumberHandling, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E0E60 Offset: 0x12E0060 VA: 0x1812E0E60
	|-JsonPropertyInfo<Nullable<IntPtr>>.Initialize
	|
	|-RVA: 0x12E0360 Offset: 0x12DF560 VA: 0x1812E0360
	|-JsonPropertyInfo<Nullable<UIntPtr>>.Initialize
	|
	|-RVA: 0x12DE7E0 Offset: 0x12DD9E0 VA: 0x1812DE7E0
	|-JsonPropertyInfo<bool>.Initialize
	|
	|-RVA: 0x12DFDE0 Offset: 0x12DEFE0 VA: 0x1812DFDE0
	|-JsonPropertyInfo<byte>.Initialize
	|
	|-RVA: 0x12E13E0 Offset: 0x12E05E0 VA: 0x1812E13E0
	|-JsonPropertyInfo<char>.Initialize
	|
	|-RVA: 0x12DF2E0 Offset: 0x12DE4E0 VA: 0x1812DF2E0
	|-JsonPropertyInfo<DateTime>.Initialize
	|
	|-RVA: 0x12E08E0 Offset: 0x12DFAE0 VA: 0x1812E08E0
	|-JsonPropertyInfo<DateTimeOffset>.Initialize
	|
	|-RVA: 0x12DED60 Offset: 0x12DDF60 VA: 0x1812DED60
	|-JsonPropertyInfo<Decimal>.Initialize
	|
	|-RVA: 0x12DF860 Offset: 0x12DEA60 VA: 0x1812DF860
	|-JsonPropertyInfo<double>.Initialize
	|
	|-RVA: 0x12E8A70 Offset: 0x12E7C70 VA: 0x1812E8A70
	|-JsonPropertyInfo<Guid>.Initialize
	|
	|-RVA: 0x12E9AF0 Offset: 0x12E8CF0 VA: 0x1812E9AF0
	|-JsonPropertyInfo<short>.Initialize
	|
	|-RVA: 0x12E8FF0 Offset: 0x12E81F0 VA: 0x1812E8FF0
	|-JsonPropertyInfo<int>.Initialize
	|
	|-RVA: 0x12EC1E0 Offset: 0x12EB3E0 VA: 0x1812EC1E0
	|-JsonPropertyInfo<long>.Initialize
	|
	|-RVA: 0x12E9570 Offset: 0x12E8770 VA: 0x1812E9570
	|-JsonPropertyInfo<IntPtr>.Initialize
	|
	|-RVA: 0x12EB670 Offset: 0x12EA870 VA: 0x1812EB670
	|-JsonPropertyInfo<JsonElement>.Initialize
	|
	|-RVA: 0x12EB0F0 Offset: 0x12EA2F0 VA: 0x1812EB0F0
	|-JsonPropertyInfo<object>.Initialize
	|
	|-RVA: 0x12EC760 Offset: 0x12EB960 VA: 0x1812EC760
	|-JsonPropertyInfo<sbyte>.Initialize
	|
	|-RVA: 0x12E84F0 Offset: 0x12E76F0 VA: 0x1812E84F0
	|-JsonPropertyInfo<float>.Initialize
	|
	|-RVA: 0x12EAB70 Offset: 0x12E9D70 VA: 0x1812EAB70
	|-JsonPropertyInfo<ushort>.Initialize
	|
	|-RVA: 0x12EA070 Offset: 0x12E9270 VA: 0x1812EA070
	|-JsonPropertyInfo<uint>.Initialize
	|
	|-RVA: 0x12EA5F0 Offset: 0x12E97F0 VA: 0x1812EA5F0
	|-JsonPropertyInfo<ulong>.Initialize
	|
	|-RVA: 0x12E7F70 Offset: 0x12E7170 VA: 0x1812E7F70
	|-JsonPropertyInfo<UIntPtr>.Initialize
	|
	|-RVA: 0x12EBBF0 Offset: 0x12EADF0 VA: 0x1812EBBF0
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override JsonConverter get_ConverterBase() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	|-JsonPropertyInfo<Nullable<IntPtr>>.get_ConverterBase
	|-JsonPropertyInfo<Nullable<UIntPtr>>.get_ConverterBase
	|-JsonPropertyInfo<bool>.get_ConverterBase
	|-JsonPropertyInfo<byte>.get_ConverterBase
	|-JsonPropertyInfo<char>.get_ConverterBase
	|-JsonPropertyInfo<DateTime>.get_ConverterBase
	|-JsonPropertyInfo<DateTimeOffset>.get_ConverterBase
	|-JsonPropertyInfo<Decimal>.get_ConverterBase
	|-JsonPropertyInfo<double>.get_ConverterBase
	|-JsonPropertyInfo<Guid>.get_ConverterBase
	|-JsonPropertyInfo<short>.get_ConverterBase
	|-JsonPropertyInfo<int>.get_ConverterBase
	|-JsonPropertyInfo<long>.get_ConverterBase
	|-JsonPropertyInfo<IntPtr>.get_ConverterBase
	|-JsonPropertyInfo<JsonElement>.get_ConverterBase
	|-JsonPropertyInfo<object>.get_ConverterBase
	|-JsonPropertyInfo<sbyte>.get_ConverterBase
	|-JsonPropertyInfo<float>.get_ConverterBase
	|-JsonPropertyInfo<ushort>.get_ConverterBase
	|-JsonPropertyInfo<uint>.get_ConverterBase
	|-JsonPropertyInfo<ulong>.get_ConverterBase
	|-JsonPropertyInfo<UIntPtr>.get_ConverterBase
	|
	|-RVA: 0xB1B530 Offset: 0xB1A730 VA: 0x180B1B530
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.get_ConverterBase
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void set_ConverterBase(JsonConverter value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4E60 Offset: 0x12E4060 VA: 0x1812E4E60
	|-JsonPropertyInfo<Nullable<IntPtr>>.set_ConverterBase
	|-JsonPropertyInfo<Nullable<UIntPtr>>.set_ConverterBase
	|-JsonPropertyInfo<bool>.set_ConverterBase
	|-JsonPropertyInfo<byte>.set_ConverterBase
	|-JsonPropertyInfo<char>.set_ConverterBase
	|-JsonPropertyInfo<DateTime>.set_ConverterBase
	|-JsonPropertyInfo<DateTimeOffset>.set_ConverterBase
	|-JsonPropertyInfo<Decimal>.set_ConverterBase
	|-JsonPropertyInfo<double>.set_ConverterBase
	|-JsonPropertyInfo<Guid>.set_ConverterBase
	|-JsonPropertyInfo<short>.set_ConverterBase
	|-JsonPropertyInfo<int>.set_ConverterBase
	|-JsonPropertyInfo<long>.set_ConverterBase
	|-JsonPropertyInfo<IntPtr>.set_ConverterBase
	|-JsonPropertyInfo<JsonElement>.set_ConverterBase
	|-JsonPropertyInfo<object>.set_ConverterBase
	|-JsonPropertyInfo<sbyte>.set_ConverterBase
	|-JsonPropertyInfo<float>.set_ConverterBase
	|-JsonPropertyInfo<ushort>.set_ConverterBase
	|-JsonPropertyInfo<uint>.set_ConverterBase
	|-JsonPropertyInfo<ulong>.set_ConverterBase
	|-JsonPropertyInfo<UIntPtr>.set_ConverterBase
	|
	|-RVA: 0x12F2160 Offset: 0x12F1360 VA: 0x1812F2160
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.set_ConverterBase
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override object GetValueAsObject(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DE5A0 Offset: 0x12DD7A0 VA: 0x1812DE5A0
	|-JsonPropertyInfo<Nullable<IntPtr>>.GetValueAsObject
	|-JsonPropertyInfo<Nullable<UIntPtr>>.GetValueAsObject
	|-JsonPropertyInfo<DateTimeOffset>.GetValueAsObject
	|-JsonPropertyInfo<Decimal>.GetValueAsObject
	|-JsonPropertyInfo<Guid>.GetValueAsObject
	|-JsonPropertyInfo<JsonElement>.GetValueAsObject
	|
	|-RVA: 0x12DE620 Offset: 0x12DD820 VA: 0x1812DE620
	|-JsonPropertyInfo<bool>.GetValueAsObject
	|-JsonPropertyInfo<byte>.GetValueAsObject
	|-JsonPropertyInfo<sbyte>.GetValueAsObject
	|
	|-RVA: 0x12DE690 Offset: 0x12DD890 VA: 0x1812DE690
	|-JsonPropertyInfo<char>.GetValueAsObject
	|-JsonPropertyInfo<short>.GetValueAsObject
	|-JsonPropertyInfo<ushort>.GetValueAsObject
	|
	|-RVA: 0x12DE700 Offset: 0x12DD900 VA: 0x1812DE700
	|-JsonPropertyInfo<DateTime>.GetValueAsObject
	|-JsonPropertyInfo<long>.GetValueAsObject
	|-JsonPropertyInfo<IntPtr>.GetValueAsObject
	|-JsonPropertyInfo<ulong>.GetValueAsObject
	|-JsonPropertyInfo<UIntPtr>.GetValueAsObject
	|
	|-RVA: 0x12DE770 Offset: 0x12DD970 VA: 0x1812DE770
	|-JsonPropertyInfo<double>.GetValueAsObject
	|
	|-RVA: 0x12E7D50 Offset: 0x12E6F50 VA: 0x1812E7D50
	|-JsonPropertyInfo<int>.GetValueAsObject
	|-JsonPropertyInfo<uint>.GetValueAsObject
	|
	|-RVA: 0x12E7DC0 Offset: 0x12E6FC0 VA: 0x1812E7DC0
	|-JsonPropertyInfo<object>.GetValueAsObject
	|
	|-RVA: 0x12E7F00 Offset: 0x12E7100 VA: 0x1812E7F00
	|-JsonPropertyInfo<float>.GetValueAsObject
	|
	|-RVA: 0x12E7E00 Offset: 0x12E7000 VA: 0x1812E7E00
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.GetValueAsObject
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override bool GetMemberAndWriteJson(object obj, ref WriteStack state, Utf8JsonWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DDCA0 Offset: 0x12DCEA0 VA: 0x1812DDCA0
	|-JsonPropertyInfo<Nullable<IntPtr>>.GetMemberAndWriteJson
	|
	|-RVA: 0x12DD3A0 Offset: 0x12DC5A0 VA: 0x1812DD3A0
	|-JsonPropertyInfo<Nullable<UIntPtr>>.GetMemberAndWriteJson
	|
	|-RVA: 0x12DCEE0 Offset: 0x12DC0E0 VA: 0x1812DCEE0
	|-JsonPropertyInfo<bool>.GetMemberAndWriteJson
	|
	|-RVA: 0x12DCC80 Offset: 0x12DBE80 VA: 0x1812DCC80
	|-JsonPropertyInfo<byte>.GetMemberAndWriteJson
	|
	|-RVA: 0x12DD140 Offset: 0x12DC340 VA: 0x1812DD140
	|-JsonPropertyInfo<char>.GetMemberAndWriteJson
	|
	|-RVA: 0x12DD7C0 Offset: 0x12DC9C0 VA: 0x1812DD7C0
	|-JsonPropertyInfo<DateTime>.GetMemberAndWriteJson
	|
	|-RVA: 0x12DE320 Offset: 0x12DD520 VA: 0x1812DE320
	|-JsonPropertyInfo<DateTimeOffset>.GetMemberAndWriteJson
	|
	|-RVA: 0x12DDA20 Offset: 0x12DCC20 VA: 0x1812DDA20
	|-JsonPropertyInfo<Decimal>.GetMemberAndWriteJson
	|
	|-RVA: 0x12DE0C0 Offset: 0x12DD2C0 VA: 0x1812DE0C0
	|-JsonPropertyInfo<double>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E6ED0 Offset: 0x12E60D0 VA: 0x1812E6ED0
	|-JsonPropertyInfo<Guid>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E73B0 Offset: 0x12E65B0 VA: 0x1812E73B0
	|-JsonPropertyInfo<short>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E7610 Offset: 0x12E6810 VA: 0x1812E7610
	|-JsonPropertyInfo<int>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E7870 Offset: 0x12E6A70 VA: 0x1812E7870
	|-JsonPropertyInfo<long>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E5B00 Offset: 0x12E4D00 VA: 0x1812E5B00
	|-JsonPropertyInfo<IntPtr>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E7AD0 Offset: 0x12E6CD0 VA: 0x1812E7AD0
	|-JsonPropertyInfo<JsonElement>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E6C80 Offset: 0x12E5E80 VA: 0x1812E6C80
	|-JsonPropertyInfo<object>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E58A0 Offset: 0x12E4AA0 VA: 0x1812E58A0
	|-JsonPropertyInfo<sbyte>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E67C0 Offset: 0x12E59C0 VA: 0x1812E67C0
	|-JsonPropertyInfo<float>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E7150 Offset: 0x12E6350 VA: 0x1812E7150
	|-JsonPropertyInfo<ushort>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E6300 Offset: 0x12E5500 VA: 0x1812E6300
	|-JsonPropertyInfo<uint>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E6A20 Offset: 0x12E5C20 VA: 0x1812E6A20
	|-JsonPropertyInfo<ulong>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E6560 Offset: 0x12E5760 VA: 0x1812E6560
	|-JsonPropertyInfo<UIntPtr>.GetMemberAndWriteJson
	|
	|-RVA: 0x12E5D60 Offset: 0x12E4F60 VA: 0x1812E5D60
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.GetMemberAndWriteJson
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool GetMemberAndWriteJsonExtensionData(object obj, ref WriteStack state, Utf8JsonWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DC9F0 Offset: 0x12DBBF0 VA: 0x1812DC9F0
	|-JsonPropertyInfo<Nullable<IntPtr>>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12DC930 Offset: 0x12DBB30 VA: 0x1812DC930
	|-JsonPropertyInfo<Nullable<UIntPtr>>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12DC780 Offset: 0x12DB980 VA: 0x1812DC780
	|-JsonPropertyInfo<bool>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12DCB50 Offset: 0x12DBD50 VA: 0x1812DCB50
	|-JsonPropertyInfo<byte>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12DC810 Offset: 0x12DBA10 VA: 0x1812DC810
	|-JsonPropertyInfo<char>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12DC8A0 Offset: 0x12DBAA0 VA: 0x1812DC8A0
	|-JsonPropertyInfo<DateTime>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12DCAB0 Offset: 0x12DBCB0 VA: 0x1812DCAB0
	|-JsonPropertyInfo<DateTimeOffset>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12DCBE0 Offset: 0x12DBDE0 VA: 0x1812DCBE0
	|-JsonPropertyInfo<Decimal>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12DC6F0 Offset: 0x12DB8F0 VA: 0x1812DC6F0
	|-JsonPropertyInfo<double>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E4F80 Offset: 0x12E4180 VA: 0x1812E4F80
	|-JsonPropertyInfo<Guid>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E5660 Offset: 0x12E4860 VA: 0x1812E5660
	|-JsonPropertyInfo<short>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E5810 Offset: 0x12E4A10 VA: 0x1812E5810
	|-JsonPropertyInfo<int>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E4EF0 Offset: 0x12E40F0 VA: 0x1812E4EF0
	|-JsonPropertyInfo<long>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E51E0 Offset: 0x12E43E0 VA: 0x1812E51E0
	|-JsonPropertyInfo<IntPtr>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E5270 Offset: 0x12E4470 VA: 0x1812E5270
	|-JsonPropertyInfo<JsonElement>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E5140 Offset: 0x12E4340 VA: 0x1812E5140
	|-JsonPropertyInfo<object>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E53A0 Offset: 0x12E45A0 VA: 0x1812E53A0
	|-JsonPropertyInfo<sbyte>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E56F0 Offset: 0x12E48F0 VA: 0x1812E56F0
	|-JsonPropertyInfo<float>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E5780 Offset: 0x12E4980 VA: 0x1812E5780
	|-JsonPropertyInfo<ushort>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E50B0 Offset: 0x12E42B0 VA: 0x1812E50B0
	|-JsonPropertyInfo<uint>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E5020 Offset: 0x12E4220 VA: 0x1812E5020
	|-JsonPropertyInfo<ulong>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E5310 Offset: 0x12E4510 VA: 0x1812E5310
	|-JsonPropertyInfo<UIntPtr>.GetMemberAndWriteJsonExtensionData
	|
	|-RVA: 0x12E5430 Offset: 0x12E4630 VA: 0x1812E5430
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.GetMemberAndWriteJsonExtensionData
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override bool ReadJsonAndSetMember(object obj, ref ReadStack state, ref Utf8JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2C40 Offset: 0x12E1E40 VA: 0x1812E2C40
	|-JsonPropertyInfo<Nullable<IntPtr>>.ReadJsonAndSetMember
	|
	|-RVA: 0x12E2FA0 Offset: 0x12E21A0 VA: 0x1812E2FA0
	|-JsonPropertyInfo<Nullable<UIntPtr>>.ReadJsonAndSetMember
	|
	|-RVA: 0x12E22E0 Offset: 0x12E14E0 VA: 0x1812E22E0
	|-JsonPropertyInfo<bool>.ReadJsonAndSetMember
	|
	|-RVA: 0x12E2920 Offset: 0x12E1B20 VA: 0x1812E2920
	|-JsonPropertyInfo<byte>.ReadJsonAndSetMember
	|
	|-RVA: 0x12E1960 Offset: 0x12E0B60 VA: 0x1812E1960
	|-JsonPropertyInfo<char>.ReadJsonAndSetMember
	|
	|-RVA: 0x12E2600 Offset: 0x12E1800 VA: 0x1812E2600
	|-JsonPropertyInfo<DateTime>.ReadJsonAndSetMember
	|
	|-RVA: 0x12E3300 Offset: 0x12E2500 VA: 0x1812E3300
	|-JsonPropertyInfo<DateTimeOffset>.ReadJsonAndSetMember
	|
	|-RVA: 0x12E1FB0 Offset: 0x12E11B0 VA: 0x1812E1FB0
	|-JsonPropertyInfo<Decimal>.ReadJsonAndSetMember
	|
	|-RVA: 0x12E1C80 Offset: 0x12E0E80 VA: 0x1812E1C80
	|-JsonPropertyInfo<double>.ReadJsonAndSetMember
	|
	|-RVA: 0x12EDFA0 Offset: 0x12ED1A0 VA: 0x1812EDFA0
	|-JsonPropertyInfo<Guid>.ReadJsonAndSetMember
	|
	|-RVA: 0x12EE2D0 Offset: 0x12ED4D0 VA: 0x1812EE2D0
	|-JsonPropertyInfo<short>.ReadJsonAndSetMember
	|
	|-RVA: 0x12EDC80 Offset: 0x12ECE80 VA: 0x1812EDC80
	|-JsonPropertyInfo<int>.ReadJsonAndSetMember
	|
	|-RVA: 0x12EE5F0 Offset: 0x12ED7F0 VA: 0x1812EE5F0
	|-JsonPropertyInfo<long>.ReadJsonAndSetMember
	|
	|-RVA: 0x12ED000 Offset: 0x12EC200 VA: 0x1812ED000
	|-JsonPropertyInfo<IntPtr>.ReadJsonAndSetMember
	|
	|-RVA: 0x12EE910 Offset: 0x12EDB10 VA: 0x1812EE910
	|-JsonPropertyInfo<JsonElement>.ReadJsonAndSetMember
	|
	|-RVA: 0x12ECCE0 Offset: 0x12EBEE0 VA: 0x1812ECCE0
	|-JsonPropertyInfo<object>.ReadJsonAndSetMember
	|
	|-RVA: 0x12EF750 Offset: 0x12EE950 VA: 0x1812EF750
	|-JsonPropertyInfo<sbyte>.ReadJsonAndSetMember
	|
	|-RVA: 0x12ED320 Offset: 0x12EC520 VA: 0x1812ED320
	|-JsonPropertyInfo<float>.ReadJsonAndSetMember
	|
	|-RVA: 0x12ED640 Offset: 0x12EC840 VA: 0x1812ED640
	|-JsonPropertyInfo<ushort>.ReadJsonAndSetMember
	|
	|-RVA: 0x12EFA70 Offset: 0x12EEC70 VA: 0x1812EFA70
	|-JsonPropertyInfo<uint>.ReadJsonAndSetMember
	|
	|-RVA: 0x12EEC40 Offset: 0x12EDE40 VA: 0x1812EEC40
	|-JsonPropertyInfo<ulong>.ReadJsonAndSetMember
	|
	|-RVA: 0x12ED960 Offset: 0x12ECB60 VA: 0x1812ED960
	|-JsonPropertyInfo<UIntPtr>.ReadJsonAndSetMember
	|
	|-RVA: 0x12EEF60 Offset: 0x12EE160 VA: 0x1812EEF60
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.ReadJsonAndSetMember
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override bool ReadJsonAsObject(ref ReadStack state, ref Utf8JsonReader reader, out object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E45B0 Offset: 0x12E37B0 VA: 0x1812E45B0
	|-JsonPropertyInfo<Nullable<IntPtr>>.ReadJsonAsObject
	|
	|-RVA: 0x12E3BD0 Offset: 0x12E2DD0 VA: 0x1812E3BD0
	|-JsonPropertyInfo<Nullable<UIntPtr>>.ReadJsonAsObject
	|
	|-RVA: 0x12E3810 Offset: 0x12E2A10 VA: 0x1812E3810
	|-JsonPropertyInfo<bool>.ReadJsonAsObject
	|
	|-RVA: 0x12E39F0 Offset: 0x12E2BF0 VA: 0x1812E39F0
	|-JsonPropertyInfo<byte>.ReadJsonAsObject
	|
	|-RVA: 0x12E3630 Offset: 0x12E2830 VA: 0x1812E3630
	|-JsonPropertyInfo<char>.ReadJsonAsObject
	|
	|-RVA: 0x12E3DD0 Offset: 0x12E2FD0 VA: 0x1812E3DD0
	|-JsonPropertyInfo<DateTime>.ReadJsonAsObject
	|
	|-RVA: 0x12E3FB0 Offset: 0x12E31B0 VA: 0x1812E3FB0
	|-JsonPropertyInfo<DateTimeOffset>.ReadJsonAsObject
	|
	|-RVA: 0x12E41B0 Offset: 0x12E33B0 VA: 0x1812E41B0
	|-JsonPropertyInfo<Decimal>.ReadJsonAsObject
	|
	|-RVA: 0x12E43B0 Offset: 0x12E35B0 VA: 0x1812E43B0
	|-JsonPropertyInfo<double>.ReadJsonAsObject
	|
	|-RVA: 0x12F0A90 Offset: 0x12EFC90 VA: 0x1812F0A90
	|-JsonPropertyInfo<Guid>.ReadJsonAsObject
	|
	|-RVA: 0x12F0360 Offset: 0x12EF560 VA: 0x1812F0360
	|-JsonPropertyInfo<short>.ReadJsonAsObject
	|
	|-RVA: 0x12EFF90 Offset: 0x12EF190 VA: 0x1812EFF90
	|-JsonPropertyInfo<int>.ReadJsonAsObject
	|
	|-RVA: 0x12F0540 Offset: 0x12EF740 VA: 0x1812F0540
	|-JsonPropertyInfo<long>.ReadJsonAsObject
	|
	|-RVA: 0x12F0E70 Offset: 0x12F0070 VA: 0x1812F0E70
	|-JsonPropertyInfo<IntPtr>.ReadJsonAsObject
	|
	|-RVA: 0x12EFD90 Offset: 0x12EEF90 VA: 0x1812EFD90
	|-JsonPropertyInfo<JsonElement>.ReadJsonAsObject
	|
	|-RVA: 0x12F0720 Offset: 0x12EF920 VA: 0x1812F0720
	|-JsonPropertyInfo<object>.ReadJsonAsObject
	|
	|-RVA: 0x12F1050 Offset: 0x12F0250 VA: 0x1812F1050
	|-JsonPropertyInfo<sbyte>.ReadJsonAsObject
	|
	|-RVA: 0x12F0170 Offset: 0x12EF370 VA: 0x1812F0170
	|-JsonPropertyInfo<float>.ReadJsonAsObject
	|
	|-RVA: 0x12F08B0 Offset: 0x12EFAB0 VA: 0x1812F08B0
	|-JsonPropertyInfo<ushort>.ReadJsonAsObject
	|
	|-RVA: 0x12F15C0 Offset: 0x12F07C0 VA: 0x1812F15C0
	|-JsonPropertyInfo<uint>.ReadJsonAsObject
	|
	|-RVA: 0x12F17A0 Offset: 0x12F09A0 VA: 0x1812F17A0
	|-JsonPropertyInfo<ulong>.ReadJsonAsObject
	|
	|-RVA: 0x12F0C90 Offset: 0x12EFE90 VA: 0x1812F0C90
	|-JsonPropertyInfo<UIntPtr>.ReadJsonAsObject
	|
	|-RVA: 0x12F1230 Offset: 0x12F0430 VA: 0x1812F1230
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.ReadJsonAsObject
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override void SetExtensionDictionaryAsObject(object obj, object extensionDict) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4990 Offset: 0x12E3B90 VA: 0x1812E4990
	|-JsonPropertyInfo<Nullable<IntPtr>>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<Nullable<UIntPtr>>.SetExtensionDictionaryAsObject
	|
	|-RVA: 0x12E4850 Offset: 0x12E3A50 VA: 0x1812E4850
	|-JsonPropertyInfo<bool>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<byte>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<sbyte>.SetExtensionDictionaryAsObject
	|
	|-RVA: 0x12E4AF0 Offset: 0x12E3CF0 VA: 0x1812E4AF0
	|-JsonPropertyInfo<char>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<short>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<ushort>.SetExtensionDictionaryAsObject
	|
	|-RVA: 0x12E4A50 Offset: 0x12E3C50 VA: 0x1812E4A50
	|-JsonPropertyInfo<DateTime>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<long>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<IntPtr>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<ulong>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<UIntPtr>.SetExtensionDictionaryAsObject
	|
	|-RVA: 0x12E47B0 Offset: 0x12E39B0 VA: 0x1812E47B0
	|-JsonPropertyInfo<DateTimeOffset>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<Decimal>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<Guid>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<JsonElement>.SetExtensionDictionaryAsObject
	|
	|-RVA: 0x12E48F0 Offset: 0x12E3AF0 VA: 0x1812E48F0
	|-JsonPropertyInfo<double>.SetExtensionDictionaryAsObject
	|
	|-RVA: 0x12F1BB0 Offset: 0x12F0DB0 VA: 0x1812F1BB0
	|-JsonPropertyInfo<int>.SetExtensionDictionaryAsObject
	|-JsonPropertyInfo<uint>.SetExtensionDictionaryAsObject
	|
	|-RVA: 0x12F1C50 Offset: 0x12F0E50 VA: 0x1812F1C50
	|-JsonPropertyInfo<object>.SetExtensionDictionaryAsObject
	|
	|-RVA: 0x12F1B10 Offset: 0x12F0D10 VA: 0x1812F1B10
	|-JsonPropertyInfo<float>.SetExtensionDictionaryAsObject
	|
	|-RVA: 0x12F1980 Offset: 0x12F0B80 VA: 0x1812F1980
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>.SetExtensionDictionaryAsObject
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4DC0 Offset: 0x12E3FC0 VA: 0x1812E4DC0
	|-JsonPropertyInfo<Nullable<IntPtr>>..ctor
	|
	|-RVA: 0x12E4E10 Offset: 0x12E4010 VA: 0x1812E4E10
	|-JsonPropertyInfo<Nullable<UIntPtr>>..ctor
	|
	|-RVA: 0x12E4D70 Offset: 0x12E3F70 VA: 0x1812E4D70
	|-JsonPropertyInfo<bool>..ctor
	|
	|-RVA: 0x12E4D20 Offset: 0x12E3F20 VA: 0x1812E4D20
	|-JsonPropertyInfo<byte>..ctor
	|
	|-RVA: 0x12E4B90 Offset: 0x12E3D90 VA: 0x1812E4B90
	|-JsonPropertyInfo<char>..ctor
	|
	|-RVA: 0x12E4C30 Offset: 0x12E3E30 VA: 0x1812E4C30
	|-JsonPropertyInfo<DateTime>..ctor
	|
	|-RVA: 0x12E4BE0 Offset: 0x12E3DE0 VA: 0x1812E4BE0
	|-JsonPropertyInfo<DateTimeOffset>..ctor
	|
	|-RVA: 0x12E4C80 Offset: 0x12E3E80 VA: 0x1812E4C80
	|-JsonPropertyInfo<Decimal>..ctor
	|
	|-RVA: 0x12E4CD0 Offset: 0x12E3ED0 VA: 0x1812E4CD0
	|-JsonPropertyInfo<double>..ctor
	|
	|-RVA: 0x12F1F30 Offset: 0x12F1130 VA: 0x1812F1F30
	|-JsonPropertyInfo<Guid>..ctor
	|
	|-RVA: 0x12F2110 Offset: 0x12F1310 VA: 0x1812F2110
	|-JsonPropertyInfo<short>..ctor
	|
	|-RVA: 0x12F20C0 Offset: 0x12F12C0 VA: 0x1812F20C0
	|-JsonPropertyInfo<int>..ctor
	|
	|-RVA: 0x12F1DF0 Offset: 0x12F0FF0 VA: 0x1812F1DF0
	|-JsonPropertyInfo<long>..ctor
	|
	|-RVA: 0x12F1D50 Offset: 0x12F0F50 VA: 0x1812F1D50
	|-JsonPropertyInfo<IntPtr>..ctor
	|
	|-RVA: 0x12F1FD0 Offset: 0x12F11D0 VA: 0x1812F1FD0
	|-JsonPropertyInfo<JsonElement>..ctor
	|
	|-RVA: 0x12F2020 Offset: 0x12F1220 VA: 0x1812F2020
	|-JsonPropertyInfo<object>..ctor
	|
	|-RVA: 0x12F2070 Offset: 0x12F1270 VA: 0x1812F2070
	|-JsonPropertyInfo<sbyte>..ctor
	|
	|-RVA: 0x12F1EE0 Offset: 0x12F10E0 VA: 0x1812F1EE0
	|-JsonPropertyInfo<float>..ctor
	|
	|-RVA: 0x12F1DA0 Offset: 0x12F0FA0 VA: 0x1812F1DA0
	|-JsonPropertyInfo<ushort>..ctor
	|
	|-RVA: 0x12F1E90 Offset: 0x12F1090 VA: 0x1812F1E90
	|-JsonPropertyInfo<uint>..ctor
	|
	|-RVA: 0x12F1F80 Offset: 0x12F1180 VA: 0x1812F1F80
	|-JsonPropertyInfo<ulong>..ctor
	|
	|-RVA: 0x12F1E40 Offset: 0x12F1040 VA: 0x1812F1E40
	|-JsonPropertyInfo<UIntPtr>..ctor
	|
	|-RVA: 0x12F1D00 Offset: 0x12F0F00 VA: 0x1812F1D00
	|-JsonPropertyInfo<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json
[Nullable(0)]
[NullableContext(1)]
internal static class JsonSerializer // TypeDefIndex: 15885
{
	// Fields
	internal static readonly byte[] s_idPropertyName; // 0x0
	internal static readonly byte[] s_refPropertyName; // 0x8
	internal static readonly byte[] s_valuesPropertyName; // 0x10
	internal static readonly JsonEncodedText s_metadataId; // 0x18
	internal static readonly JsonEncodedText s_metadataRef; // 0x28
	internal static readonly JsonEncodedText s_metadataValues; // 0x38

	// Methods

	// RVA: -1 Offset: -1
	internal static bool ResolveMetadataForJsonObject<T>(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2CEF0 Offset: 0xA2C0F0 VA: 0x180A2CEF0
	|-JsonSerializer.ResolveMetadataForJsonObject<object>
	|
	|-RVA: 0xA2CA60 Offset: 0xA2BC60 VA: 0x180A2CA60
	|-JsonSerializer.ResolveMetadataForJsonObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static bool ResolveMetadataForJsonArray<T>(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2C3E0 Offset: 0xA2B5E0 VA: 0x180A2C3E0
	|-JsonSerializer.ResolveMetadataForJsonArray<object>
	|
	|-RVA: 0xA2BD60 Offset: 0xA2AF60 VA: 0x180A2BD60
	|-JsonSerializer.ResolveMetadataForJsonArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C17230 Offset: 0x1C16430 VA: 0x181C17230
	private static bool TryReadAheadMetadataAndSetState(ref Utf8JsonReader reader, ref ReadStack state, StackFrameObjectState nextState) { }

	// RVA: 0x1C16750 Offset: 0x1C15950 VA: 0x181C16750
	internal static MetadataPropertyName GetMetadataPropertyName(ReadOnlySpan<byte> propertyName) { }

	// RVA: 0x1C16F70 Offset: 0x1C16170 VA: 0x181C16F70
	internal static bool TryGetReferenceFromJsonElement(ref ReadStack state, JsonElement element, out object referenceValue) { }

	// RVA: -1 Offset: -1
	private static void ValidateValueIsCorrectType<T>(object value, string referenceId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2E0E0 Offset: 0xA2D2E0 VA: 0x180A2E0E0
	|-JsonSerializer.ValidateValueIsCorrectType<object>
	|
	|-RVA: 0xA2DF90 Offset: 0xA2D190 VA: 0x180A2DF90
	|-JsonSerializer.ValidateValueIsCorrectType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C16CE0 Offset: 0x1C15EE0 VA: 0x181C16CE0
	internal static JsonPropertyInfo LookupProperty(object obj, ReadOnlySpan<byte> unescapedPropertyName, ref ReadStack state, out bool useExtensionProperty, bool createExtensionProperty = True) { }

	// RVA: 0x1C16950 Offset: 0x1C15B50 VA: 0x181C16950
	internal static ReadOnlySpan<byte> GetPropertyName(ref ReadStack state, ref Utf8JsonReader reader, JsonSerializerOptions options) { }

	// RVA: 0x1C16660 Offset: 0x1C15860 VA: 0x181C16660
	internal static void CreateDataExtensionProperty(object obj, JsonPropertyInfo jsonPropertyInfo) { }

	// RVA: -1 Offset: -1
	private static TValue ReadCore<TValue>(ref Utf8JsonReader reader, Type returnType, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2BA30 Offset: 0xA2AC30 VA: 0x180A2BA30
	|-JsonSerializer.ReadCore<object>
	|
	|-RVA: 0xA2B8A0 Offset: 0xA2AAA0 VA: 0x180A2B8A0
	|-JsonSerializer.ReadCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static TValue ReadCore<TValue>(JsonConverter jsonConverter, ref Utf8JsonReader reader, JsonSerializerOptions options, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2BC20 Offset: 0xA2AE20 VA: 0x180A2BC20
	|-JsonSerializer.ReadCore<object>
	|
	|-RVA: 0xA2B720 Offset: 0xA2A920 VA: 0x180A2B720
	|-JsonSerializer.ReadCore<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public static TValue Deserialize<TValue>(string json, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2B070 Offset: 0xA2A270 VA: 0x180A2B070
	|-JsonSerializer.Deserialize<object>
	|
	|-RVA: 0xA2A670 Offset: 0xA29870 VA: 0x180A2A670
	|-JsonSerializer.Deserialize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static TValue Deserialize<TValue>(string json, Type returnType, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2B170 Offset: 0xA2A370 VA: 0x180A2B170
	|-JsonSerializer.Deserialize<object>
	|
	|-RVA: 0xA2A8F0 Offset: 0xA29AF0 VA: 0x180A2A8F0
	|-JsonSerializer.Deserialize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C17760 Offset: 0x1C16960 VA: 0x181C17760
	internal static MetadataPropertyName WriteReferenceForObject(JsonConverter jsonConverter, object currentValue, ref WriteStack state, Utf8JsonWriter writer) { }

	// RVA: 0x1C17240 Offset: 0x1C16440 VA: 0x181C17240
	internal static MetadataPropertyName WriteReferenceForCollection(JsonConverter jsonConverter, object currentValue, ref WriteStack state, Utf8JsonWriter writer) { }

	// RVA: -1 Offset: -1
	private static void WriteCore<TValue>(Utf8JsonWriter writer, in TValue value, Type inputType, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2E5E0 Offset: 0xA2D7E0 VA: 0x180A2E5E0
	|-JsonSerializer.WriteCore<object>
	|
	|-RVA: 0xA2E1D0 Offset: 0xA2D3D0 VA: 0x180A2E1D0
	|-JsonSerializer.WriteCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool WriteCore<TValue>(JsonConverter jsonConverter, Utf8JsonWriter writer, in TValue value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2E820 Offset: 0xA2DA20 VA: 0x180A2E820
	|-JsonSerializer.WriteCore<object>
	|
	|-RVA: 0xA2E470 Offset: 0xA2D670 VA: 0x180A2E470
	|-JsonSerializer.WriteCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static string Serialize<TValue>(TValue value, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2DBE0 Offset: 0xA2CDE0 VA: 0x180A2DBE0
	|-JsonSerializer.Serialize<object>
	|
	|-RVA: 0xA2D880 Offset: 0xA2CA80 VA: 0x180A2D880
	|-JsonSerializer.Serialize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static string Serialize<TValue>(in TValue value, Type inputType, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2DC90 Offset: 0xA2CE90 VA: 0x180A2DC90
	|-JsonSerializer.Serialize<object>
	|
	|-RVA: 0xA2D380 Offset: 0xA2C580 VA: 0x180A2D380
	|-JsonSerializer.Serialize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Serialize<TValue>(Utf8JsonWriter writer, TValue value, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2D940 Offset: 0xA2CB40 VA: 0x180A2D940
	|-JsonSerializer.Serialize<object>
	|
	|-RVA: 0xA2D7A0 Offset: 0xA2C9A0 VA: 0x180A2D7A0
	|-JsonSerializer.Serialize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void Serialize<TValue>(Utf8JsonWriter writer, in TValue value, Type type, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2DAC0 Offset: 0xA2CCC0 VA: 0x180A2DAC0
	|-JsonSerializer.Serialize<object>
	|
	|-RVA: 0xA2D680 Offset: 0xA2C880 VA: 0x180A2D680
	|-JsonSerializer.Serialize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C178D0 Offset: 0x1C16AD0 VA: 0x181C178D0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonSerializerOptions.<>c__DisplayClass3_0 // TypeDefIndex: 15886
{
	// Fields
	public Dictionary<Type, JsonConverter> converters; // 0x0
}

// Namespace: 
[CompilerGenerated]
private struct JsonSerializerOptions.<>c__DisplayClass4_0 // TypeDefIndex: 15887
{
	// Fields
	public Type keyType; // 0x0
	public JsonSerializerOptions <>4__this; // 0x8
}

// Namespace: 
[CompilerGenerated]
private struct JsonSerializerOptions.<>c__DisplayClass6_0 // TypeDefIndex: 15888
{
	// Fields
	public ConcurrentDictionary<Type, JsonConverter> converters; // 0x0
}

// Namespace: System.Text.Json
[Nullable(0)]
[NullableContext(2)]
internal sealed class JsonSerializerOptions // TypeDefIndex: 15889
{
	// Fields
	private static readonly Dictionary<Type, JsonConverter> s_defaultSimpleConverters; // 0x0
	private static readonly JsonConverter[] s_defaultFactoryConverters; // 0x8
	private readonly ConcurrentDictionary<Type, JsonConverter> _converters; // 0x10
	private ConcurrentDictionary<Type, JsonConverter> _dictionaryKeyConverters; // 0x18
	[CompilerGenerated]
	private readonly IList<JsonConverter> <Converters>k__BackingField; // 0x20
	internal static readonly JsonSerializerOptions s_defaultOptions; // 0x10
	private readonly ConcurrentDictionary<Type, JsonClassInfo> _classes; // 0x28
	[CompilerGenerated]
	private JsonClassInfo <_lastClass>k__BackingField; // 0x30
	private MemberAccessor _memberAccessorStrategy; // 0x38
	private JsonNamingPolicy _dictionaryKeyPolicy; // 0x40
	private JsonNamingPolicy _jsonPropertyNamingPolicy; // 0x48
	private JsonCommentHandling _readCommentHandling; // 0x50
	private ReferenceHandler _referenceHandler; // 0x58
	private JavaScriptEncoder _encoder; // 0x60
	private JsonIgnoreCondition _defaultIgnoreCondition; // 0x68
	private JsonNumberHandling _numberHandling; // 0x6C
	private int _defaultBufferSize; // 0x70
	private int _maxDepth; // 0x74
	private bool _allowTrailingCommas; // 0x78
	private bool _haveTypesBeenCreated; // 0x79
	private bool _ignoreNullValues; // 0x7A
	private bool _ignoreReadOnlyProperties; // 0x7B
	private bool _ignoreReadonlyFields; // 0x7C
	private bool _includeFields; // 0x7D
	private bool _propertyNameCaseInsensitive; // 0x7E
	private bool _writeIndented; // 0x7F
	[CompilerGenerated]
	private int <EffectiveMaxDepth>k__BackingField; // 0x80

	// Properties
	[Nullable(1)]
	public IList<JsonConverter> Converters { get; }
	private JsonClassInfo _lastClass { get; set; }
	public bool AllowTrailingCommas { get; }
	public int DefaultBufferSize { get; }
	public JavaScriptEncoder Encoder { get; }
	public JsonNamingPolicy DictionaryKeyPolicy { get; }
	[EditorBrowsable(1)]
	public bool IgnoreNullValues { get; }
	public JsonIgnoreCondition DefaultIgnoreCondition { get; }
	public JsonNumberHandling NumberHandling { get; }
	public bool IgnoreReadOnlyProperties { get; }
	public bool IgnoreReadOnlyFields { get; }
	public bool IncludeFields { get; }
	public int MaxDepth { get; }
	internal int EffectiveMaxDepth { get; }
	public JsonNamingPolicy PropertyNamingPolicy { get; set; }
	public bool PropertyNameCaseInsensitive { get; }
	public JsonCommentHandling ReadCommentHandling { get; }
	public bool WriteIndented { get; }
	public ReferenceHandler ReferenceHandler { get; set; }
	[Nullable(1)]
	internal MemberAccessor MemberAccessorStrategy { get; }

	// Methods

	// RVA: 0x1C14360 Offset: 0x1C13560 VA: 0x181C14360
	private static Dictionary<Type, JsonConverter> GetDefaultSimpleConverters() { }

	// RVA: 0x1C14E80 Offset: 0x1C14080 VA: 0x181C14E80
	internal JsonConverter GetDictionaryKeyConverter(Type keyType) { }

	// RVA: 0x1C14FB0 Offset: 0x1C141B0 VA: 0x181C14FB0
	private static ConcurrentDictionary<Type, JsonConverter> GetDictionaryKeyConverters() { }

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IList<JsonConverter> get_Converters() { }

	// RVA: 0x1C13540 Offset: 0x1C12740 VA: 0x181C13540
	internal JsonConverter DetermineConverter(Type parentClassType, Type runtimePropertyType, MemberInfo memberInfo) { }

	[NullableContext(1)]
	// RVA: 0x1C13DF0 Offset: 0x1C12FF0 VA: 0x181C13DF0
	public JsonConverter GetConverter(Type typeToConvert) { }

	// RVA: 0x1C13AC0 Offset: 0x1C12CC0 VA: 0x181C13AC0
	private JsonConverter GetConverterFromAttribute(JsonConverterAttribute converterAttribute, Type typeToConvert, Type classTypeAttributeIsOn, MemberInfo memberInfo) { }

	// RVA: 0x1C13880 Offset: 0x1C12A80 VA: 0x181C13880
	private static Attribute GetAttributeThatCanHaveMultiple(Type classType, Type attributeType, MemberInfo memberInfo) { }

	// RVA: 0x1C13930 Offset: 0x1C12B30 VA: 0x181C13930
	internal static Attribute GetAttributeThatCanHaveMultiple(Type classType, Type attributeType) { }

	// RVA: 0x1C139D0 Offset: 0x1C12BD0 VA: 0x181C139D0
	private static Attribute GetAttributeThatCanHaveMultiple(Type attributeType, Type classType, MemberInfo memberInfo, object[] attributes) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	private JsonClassInfo get__lastClass() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set__lastClass(JsonClassInfo value) { }

	// RVA: 0x1C16430 Offset: 0x1C15630 VA: 0x181C16430
	public void .ctor() { }

	// RVA: 0x61CC40 Offset: 0x61BE40 VA: 0x18061CC40
	public bool get_AllowTrailingCommas() { }

	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	public int get_DefaultBufferSize() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public JavaScriptEncoder get_Encoder() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public JsonNamingPolicy get_DictionaryKeyPolicy() { }

	// RVA: 0x1C16520 Offset: 0x1C15720 VA: 0x181C16520
	public bool get_IgnoreNullValues() { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80
	public JsonIgnoreCondition get_DefaultIgnoreCondition() { }

	// RVA: 0x526CA0 Offset: 0x525EA0 VA: 0x180526CA0
	public JsonNumberHandling get_NumberHandling() { }

	// RVA: 0x1C16530 Offset: 0x1C15730 VA: 0x181C16530
	public bool get_IgnoreReadOnlyProperties() { }

	// RVA: 0x1701E00 Offset: 0x1701000 VA: 0x181701E00
	public bool get_IgnoreReadOnlyFields() { }

	// RVA: 0x1C16540 Offset: 0x1C15740 VA: 0x181C16540
	public bool get_IncludeFields() { }

	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90
	public int get_MaxDepth() { }

	[CompilerGenerated]
	// RVA: 0x1A6BA60 Offset: 0x1A6AC60 VA: 0x181A6BA60
	internal int get_EffectiveMaxDepth() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public JsonNamingPolicy get_PropertyNamingPolicy() { }

	// RVA: 0x1C165E0 Offset: 0x1C157E0 VA: 0x181C165E0
	public void set_PropertyNamingPolicy(JsonNamingPolicy value) { }

	// RVA: 0x1C165C0 Offset: 0x1C157C0 VA: 0x181C165C0
	public bool get_PropertyNameCaseInsensitive() { }

	// RVA: 0x4D1A10 Offset: 0x4D0C10 VA: 0x1804D1A10
	public JsonCommentHandling get_ReadCommentHandling() { }

	// RVA: 0x1C165D0 Offset: 0x1C157D0 VA: 0x181C165D0
	public bool get_WriteIndented() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public ReferenceHandler get_ReferenceHandler() { }

	// RVA: 0x1C16620 Offset: 0x1C15820 VA: 0x181C16620
	public void set_ReferenceHandler(ReferenceHandler value) { }

	// RVA: 0x1C16550 Offset: 0x1C15750 VA: 0x181C16550
	internal MemberAccessor get_MemberAccessorStrategy() { }

	// RVA: 0x1C15C00 Offset: 0x1C14E00 VA: 0x181C15C00
	internal JsonClassInfo GetOrAddClass(Type type) { }

	// RVA: 0x1C15B60 Offset: 0x1C14D60 VA: 0x181C15B60
	internal JsonClassInfo GetOrAddClassForRootType(Type type) { }

	// RVA: 0x1C15D60 Offset: 0x1C14F60 VA: 0x181C15D60
	internal bool TypeIsCached(Type type) { }

	// RVA: 0x1C15CE0 Offset: 0x1C14EE0 VA: 0x181C15CE0
	internal JsonReaderOptions GetReaderOptions() { }

	// RVA: 0x1C15D30 Offset: 0x1C14F30 VA: 0x181C15D30
	internal JsonWriterOptions GetWriterOptions() { }

	// RVA: 0x1C16120 Offset: 0x1C15320 VA: 0x181C16120
	internal void VerifyMutable() { }

	// RVA: 0x1C16130 Offset: 0x1C15330 VA: 0x181C16130
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1C15DC0 Offset: 0x1C14FC0 VA: 0x181C15DC0
	internal static void <GetDefaultSimpleConverters>g__Add|3_0(JsonConverter converter, ref JsonSerializerOptions.<>c__DisplayClass3_0 ) { }

	[CompilerGenerated]
	// RVA: 0x1C15E40 Offset: 0x1C15040 VA: 0x181C15E40
	private JsonConverter <GetDictionaryKeyConverter>g__GetEnumConverter|4_0(ref JsonSerializerOptions.<>c__DisplayClass4_0 ) { }

	[CompilerGenerated]
	// RVA: 0x1C160A0 Offset: 0x1C152A0 VA: 0x181C160A0
	internal static void <GetDictionaryKeyConverters>g__Add|6_0(JsonConverter converter, ref JsonSerializerOptions.<>c__DisplayClass6_0 ) { }
}

// Namespace: System.Text.Json
internal abstract class MemberAccessor // TypeDefIndex: 15890
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract JsonClassInfo.ConstructorDelegate CreateConstructor(Type classType);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract JsonClassInfo.ParameterizedConstructorDelegate<T> CreateParameterizedConstructor<T>(ConstructorInfo constructor);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberAccessor.CreateParameterizedConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract JsonClassInfo.ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3> CreateParameterizedConstructor<T, TArg0, TArg1, TArg2, TArg3>(ConstructorInfo constructor);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberAccessor.CreateParameterizedConstructor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Action<TCollection, object> CreateAddMethodDelegate<TCollection>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberAccessor.CreateAddMethodDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Func<IEnumerable<TElement>, TCollection> CreateImmutableEnumerableCreateRangeDelegate<TCollection, TElement>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberAccessor.CreateImmutableEnumerableCreateRangeDelegate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Func<IEnumerable<KeyValuePair<TKey, TValue>>, TCollection> CreateImmutableDictionaryCreateRangeDelegate<TCollection, TKey, TValue>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberAccessor.CreateImmutableDictionaryCreateRangeDelegate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Func<object, TProperty> CreatePropertyGetter<TProperty>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberAccessor.CreatePropertyGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Action<object, TProperty> CreatePropertySetter<TProperty>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberAccessor.CreatePropertySetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Func<object, TProperty> CreateFieldGetter<TProperty>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberAccessor.CreateFieldGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Action<object, TProperty> CreateFieldSetter<TProperty>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberAccessor.CreateFieldSetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Text.Json
internal enum MetadataPropertyName // TypeDefIndex: 15891
{
	// Fields
	public int value__; // 0x0
	public const MetadataPropertyName NoMetadata = 0;
	public const MetadataPropertyName Values = 1;
	public const MetadataPropertyName Id = 2;
	public const MetadataPropertyName Ref = 3;
}

// Namespace: System.Text.Json
[IsReadOnly]
internal struct ParameterRef // TypeDefIndex: 15892
{
	// Fields
	public readonly ulong Key; // 0x0
	public readonly JsonParameterInfo Info; // 0x8
	public readonly byte[] NameFromJson; // 0x10

	// Methods

	// RVA: 0xD45610 Offset: 0xD44810 VA: 0x180D45610
	public void .ctor(ulong key, JsonParameterInfo info, byte[] nameFromJson) { }
}

// Namespace: System.Text.Json
[IsReadOnly]
internal struct PropertyRef // TypeDefIndex: 15893
{
	// Fields
	public readonly ulong Key; // 0x0
	public readonly JsonPropertyInfo Info; // 0x8
	public readonly byte[] NameFromJson; // 0x10

	// Methods

	// RVA: 0xD45610 Offset: 0xD44810 VA: 0x180D45610
	public void .ctor(ulong key, JsonPropertyInfo info, byte[] nameFromJson) { }
}

// Namespace: System.Text.Json
[DebuggerDisplay("Path:{JsonPath()} Current: ClassType.{Current.JsonClassInfo.ClassType}, {Current.JsonClassInfo.Type.Name}")]
internal struct ReadStack // TypeDefIndex: 15894
{
	// Fields
	internal static readonly char[] SpecialCharacters; // 0x0
	private int _continuationCount; // 0x0
	private int _count; // 0x4
	private List<ReadStackFrame> _previous; // 0x8
	private List<ArgumentState> _ctorArgStateCache; // 0x10
	public long BytesConsumed; // 0x18
	public ReadStackFrame Current; // 0x20
	public bool ReadAhead; // 0x88
	public ReferenceResolver ReferenceResolver; // 0x90
	public bool SupportContinuation; // 0x98
	public bool UseFastPath; // 0x99

	// Properties
	public bool IsContinuation { get; }

	// Methods

	// RVA: 0x1C1C100 Offset: 0x1C1B300 VA: 0x181C1C100
	public bool get_IsContinuation() { }

	// RVA: 0x1C1AFB0 Offset: 0x1C1A1B0 VA: 0x181C1AFB0
	private void AddCurrent() { }

	// RVA: 0x1C1B1A0 Offset: 0x1C1A3A0 VA: 0x181C1B1A0
	public void Initialize(Type type, JsonSerializerOptions options, bool supportContinuation) { }

	// RVA: 0x1C1B650 Offset: 0x1C1A850 VA: 0x181C1B650
	public void Push() { }

	// RVA: 0x1C1B440 Offset: 0x1C1A640 VA: 0x181C1B440
	public void Pop(bool success) { }

	// RVA: 0x1C1B260 Offset: 0x1C1A460 VA: 0x181C1B260
	public string JsonPath() { }

	// RVA: 0x1C1B910 Offset: 0x1C1AB10 VA: 0x181C1B910
	private void SetConstructorArgumentState() { }

	// RVA: 0x1C1C080 Offset: 0x1C1B280 VA: 0x181C1C080
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1C1BB30 Offset: 0x1C1AD30 VA: 0x181C1BB30
	internal static void <JsonPath>g__AppendStackFrame|19_0(StringBuilder sb, in ReadStackFrame frame) { }

	[CompilerGenerated]
	// RVA: 0x1C1BE00 Offset: 0x1C1B000 VA: 0x181C1BE00
	internal static int <JsonPath>g__GetCount|19_1(IEnumerable enumerable) { }

	[CompilerGenerated]
	// RVA: 0x1C1BA40 Offset: 0x1C1AC40 VA: 0x181C1BA40
	internal static void <JsonPath>g__AppendPropertyName|19_2(StringBuilder sb, string propertyName) { }

	[CompilerGenerated]
	// RVA: 0x1C1BFB0 Offset: 0x1C1B1B0 VA: 0x181C1BFB0
	internal static string <JsonPath>g__GetPropertyName|19_3(in ReadStackFrame frame) { }
}

// Namespace: System.Text.Json
[DebuggerDisplay("ClassType.{JsonClassInfo.ClassType}, {JsonClassInfo.Type.Name}")]
internal struct ReadStackFrame // TypeDefIndex: 15895
{
	// Fields
	public JsonPropertyInfo JsonPropertyInfo; // 0x0
	public StackFramePropertyState PropertyState; // 0x8
	public bool UseExtensionProperty; // 0x9
	public byte[] JsonPropertyName; // 0x10
	public string JsonPropertyNameAsString; // 0x18
	public object DictionaryKey; // 0x20
	public int OriginalDepth; // 0x28
	public JsonTokenType OriginalTokenType; // 0x2C
	public object ReturnValue; // 0x30
	public JsonClassInfo JsonClassInfo; // 0x38
	public StackFrameObjectState ObjectState; // 0x40
	public bool ValidateEndTokenOnArray; // 0x41
	public int PropertyIndex; // 0x44
	public List<PropertyRef> PropertyRefCache; // 0x48
	public int CtorArgumentStateIndex; // 0x50
	public ArgumentState CtorArgumentState; // 0x58
	public Nullable<JsonNumberHandling> NumberHandling; // 0x60

	// Methods

	// RVA: 0x1C1AED0 Offset: 0x1C1A0D0 VA: 0x181C1AED0
	public void EndConstructorParameter() { }

	// RVA: 0x1C1AF10 Offset: 0x1C1A110 VA: 0x181C1AF10
	public void EndProperty() { }

	// RVA: 0x1C1AF00 Offset: 0x1C1A100 VA: 0x181C1AF00
	public void EndElement() { }

	// RVA: 0x1C1AF30 Offset: 0x1C1A130 VA: 0x181C1AF30
	public bool IsProcessingDictionary() { }

	// RVA: 0x1C1AF50 Offset: 0x1C1A150 VA: 0x181C1AF50
	public bool IsProcessingEnumerable() { }

	// RVA: 0x1C1AF70 Offset: 0x1C1A170 VA: 0x181C1AF70
	public void Reset() { }
}

// Namespace: System.Text.Json
internal enum StackFrameObjectState // TypeDefIndex: 15896
{
	// Fields
	public byte value__; // 0x0
	public const StackFrameObjectState None = 0;
	public const StackFrameObjectState StartToken = 1;
	public const StackFrameObjectState ReadAheadNameOrEndObject = 2;
	public const StackFrameObjectState ReadNameOrEndObject = 3;
	public const StackFrameObjectState ReadAheadIdValue = 4;
	public const StackFrameObjectState ReadAheadRefValue = 5;
	public const StackFrameObjectState ReadIdValue = 6;
	public const StackFrameObjectState ReadRefValue = 7;
	public const StackFrameObjectState ReadAheadRefEndObject = 8;
	public const StackFrameObjectState ReadRefEndObject = 9;
	public const StackFrameObjectState ReadAheadValuesName = 10;
	public const StackFrameObjectState ReadValuesName = 11;
	public const StackFrameObjectState ReadAheadValuesStartArray = 12;
	public const StackFrameObjectState ReadValuesStartArray = 13;
	public const StackFrameObjectState PropertyValue = 14;
	public const StackFrameObjectState CreatedObject = 15;
	public const StackFrameObjectState ReadElements = 16;
	public const StackFrameObjectState EndToken = 17;
	public const StackFrameObjectState EndTokenValidation = 18;
}

// Namespace: System.Text.Json
internal enum StackFramePropertyState // TypeDefIndex: 15897
{
	// Fields
	public byte value__; // 0x0
	public const StackFramePropertyState None = 0;
	public const StackFramePropertyState ReadName = 1;
	public const StackFramePropertyState Name = 2;
	public const StackFramePropertyState ReadValue = 3;
	public const StackFramePropertyState ReadValueIsEnd = 4;
	public const StackFramePropertyState TryRead = 5;
}

// Namespace: System.Text.Json
[DebuggerDisplay("Path:{PropertyPath()} Current: ClassType.{Current.JsonClassInfo.ClassType}, {Current.JsonClassInfo.Type.Name}")]
internal struct WriteStack // TypeDefIndex: 15898
{
	// Fields
	private int _continuationCount; // 0x0
	private int _count; // 0x4
	private List<WriteStackFrame> _previous; // 0x8
	public WriteStackFrame Current; // 0x10
	public int FlushThreshold; // 0x60
	public ReferenceResolver ReferenceResolver; // 0x68
	public bool SupportContinuation; // 0x70

	// Properties
	public bool IsContinuation { get; }

	// Methods

	// RVA: 0x1C1C100 Offset: 0x1C1B300 VA: 0x181C1C100
	public bool get_IsContinuation() { }

	// RVA: 0x1C34270 Offset: 0x1C33470 VA: 0x181C34270
	private void AddCurrent() { }

	// RVA: 0x1C34410 Offset: 0x1C33610 VA: 0x181C34410
	public JsonConverter Initialize(Type type, JsonSerializerOptions options, bool supportContinuation) { }

	// RVA: 0x1C347B0 Offset: 0x1C339B0 VA: 0x181C347B0
	public void Push() { }

	// RVA: 0x1C344D0 Offset: 0x1C336D0 VA: 0x181C344D0
	public void Pop(bool success) { }

	// RVA: 0x1C34630 Offset: 0x1C33830 VA: 0x181C34630
	public string PropertyPath() { }

	[CompilerGenerated]
	// RVA: 0x1C34A20 Offset: 0x1C33C20 VA: 0x181C34A20
	internal static void <PropertyPath>g__AppendStackFrame|13_0(StringBuilder sb, in WriteStackFrame frame) { }

	[CompilerGenerated]
	// RVA: 0x1C34930 Offset: 0x1C33B30 VA: 0x181C34930
	internal static void <PropertyPath>g__AppendPropertyName|13_1(StringBuilder sb, string propertyName) { }
}

// Namespace: System.Text.Json
[DebuggerDisplay("ClassType.{JsonClassInfo.ClassType}, {JsonClassInfo.Type.Name}")]
internal struct WriteStackFrame // TypeDefIndex: 15899
{
	// Fields
	public IEnumerator CollectionEnumerator; // 0x0
	public JsonPropertyInfo DeclaredJsonPropertyInfo; // 0x8
	public bool IgnoreDictionaryKeyPolicy; // 0x10
	public JsonClassInfo JsonClassInfo; // 0x18
	public int OriginalDepth; // 0x20
	public bool ProcessedStartToken; // 0x24
	public bool ProcessedEndToken; // 0x25
	public StackFramePropertyState PropertyState; // 0x26
	public int EnumeratorIndex; // 0x28
	public string JsonPropertyNameAsString; // 0x30
	public MetadataPropertyName MetadataPropertyName; // 0x38
	public JsonPropertyInfo PolymorphicJsonPropertyInfo; // 0x40
	public Nullable<JsonNumberHandling> NumberHandling; // 0x48

	// Methods

	// RVA: 0x1C341A0 Offset: 0x1C333A0 VA: 0x181C341A0
	public void EndDictionaryElement() { }

	// RVA: 0x1C341B0 Offset: 0x1C333B0 VA: 0x181C341B0
	public void EndProperty() { }

	// RVA: 0x1C341D0 Offset: 0x1C333D0 VA: 0x181C341D0
	public JsonPropertyInfo GetPolymorphicJsonPropertyInfo() { }

	// RVA: 0x1C341E0 Offset: 0x1C333E0 VA: 0x181C341E0
	public JsonConverter InitializeReEntry(Type type, JsonSerializerOptions options, string propertyName) { }

	// RVA: 0x1C34240 Offset: 0x1C33440 VA: 0x181C34240
	public void Reset() { }
}

// Namespace: System.Text.Json
internal enum ExceptionResource // TypeDefIndex: 15900
{
	// Fields
	public int value__; // 0x0
	public const ExceptionResource ArrayDepthTooLarge = 0;
	public const ExceptionResource EndOfCommentNotFound = 1;
	public const ExceptionResource EndOfStringNotFound = 2;
	public const ExceptionResource RequiredDigitNotFoundAfterDecimal = 3;
	public const ExceptionResource RequiredDigitNotFoundAfterSign = 4;
	public const ExceptionResource RequiredDigitNotFoundEndOfData = 5;
	public const ExceptionResource ExpectedEndAfterSingleJson = 6;
	public const ExceptionResource ExpectedEndOfDigitNotFound = 7;
	public const ExceptionResource ExpectedFalse = 8;
	public const ExceptionResource ExpectedNextDigitEValueNotFound = 9;
	public const ExceptionResource ExpectedNull = 10;
	public const ExceptionResource ExpectedSeparatorAfterPropertyNameNotFound = 11;
	public const ExceptionResource ExpectedStartOfPropertyNotFound = 12;
	public const ExceptionResource ExpectedStartOfPropertyOrValueNotFound = 13;
	public const ExceptionResource ExpectedStartOfPropertyOrValueAfterComment = 14;
	public const ExceptionResource ExpectedStartOfValueNotFound = 15;
	public const ExceptionResource ExpectedTrue = 16;
	public const ExceptionResource ExpectedValueAfterPropertyNameNotFound = 17;
	public const ExceptionResource FoundInvalidCharacter = 18;
	public const ExceptionResource InvalidCharacterWithinString = 19;
	public const ExceptionResource InvalidCharacterAfterEscapeWithinString = 20;
	public const ExceptionResource InvalidHexCharacterWithinString = 21;
	public const ExceptionResource InvalidEndOfJsonNonPrimitive = 22;
	public const ExceptionResource MismatchedObjectArray = 23;
	public const ExceptionResource ObjectDepthTooLarge = 24;
	public const ExceptionResource ZeroDepthAtEnd = 25;
	public const ExceptionResource DepthTooLarge = 26;
	public const ExceptionResource CannotStartObjectArrayWithoutProperty = 27;
	public const ExceptionResource CannotStartObjectArrayAfterPrimitiveOrClose = 28;
	public const ExceptionResource CannotWriteValueWithinObject = 29;
	public const ExceptionResource CannotWriteValueAfterPrimitiveOrClose = 30;
	public const ExceptionResource CannotWritePropertyWithinArray = 31;
	public const ExceptionResource ExpectedJsonTokens = 32;
	public const ExceptionResource TrailingCommaNotAllowedBeforeArrayEnd = 33;
	public const ExceptionResource TrailingCommaNotAllowedBeforeObjectEnd = 34;
	public const ExceptionResource InvalidCharacterAtStartOfComment = 35;
	public const ExceptionResource UnexpectedEndOfDataWhileReadingComment = 36;
	public const ExceptionResource UnexpectedEndOfLineSeparator = 37;
	public const ExceptionResource ExpectedOneCompleteToken = 38;
	public const ExceptionResource NotEnoughData = 39;
	public const ExceptionResource InvalidLeadingZeroInNumber = 40;
}

// Namespace: System.Text.Json
internal enum NumericType // TypeDefIndex: 15901
{
	// Fields
	public int value__; // 0x0
	public const NumericType Byte = 0;
	public const NumericType SByte = 1;
	public const NumericType Int16 = 2;
	public const NumericType Int32 = 3;
	public const NumericType Int64 = 4;
	public const NumericType UInt16 = 5;
	public const NumericType UInt32 = 6;
	public const NumericType UInt64 = 7;
	public const NumericType Single = 8;
	public const NumericType Double = 9;
	public const NumericType Decimal = 10;
}

// Namespace: System.Text.Json
internal enum DataType // TypeDefIndex: 15902
{
	// Fields
	public int value__; // 0x0
	public const DataType Boolean = 0;
	public const DataType DateTime = 1;
	public const DataType DateTimeOffset = 2;
	public const DataType Base64String = 3;
	public const DataType Guid = 4;
}

// Namespace: System.Text.Json
[Extension]
internal static class TypeExtensions // TypeDefIndex: 15903
{
	// Methods

	[Extension]
	// RVA: 0x1C1C290 Offset: 0x1C1B490 VA: 0x181C1C290
	public static bool IsNullableValueType(Type type) { }

	[Extension]
	// RVA: 0x1C1C210 Offset: 0x1C1B410 VA: 0x181C1C210
	public static bool IsNullableType(Type type) { }

	[Extension]
	// RVA: 0x1C1C110 Offset: 0x1C1B310 VA: 0x181C1C110
	public static bool IsAssignableFromInternal(Type type, Type from) { }
}

// Namespace: System.Text.Json
internal static class JsonWriterHelper // TypeDefIndex: 15904
{
	// Fields
	private static readonly StandardFormat s_dateTimeStandardFormat; // 0x0
	private static readonly StandardFormat s_hexStandardFormat; // 0x2

	// Properties
	private static ReadOnlySpan<byte> AllowList { get; }

	// Methods

	// RVA: 0x1C1A970 Offset: 0x1C19B70 VA: 0x181C1A970
	public static void WriteIndentation(Span<byte> buffer, int indent) { }

	// RVA: 0x1C1A020 Offset: 0x1C19220 VA: 0x181C1A020
	public static void ValidateProperty(ReadOnlySpan<byte> propertyName) { }

	// RVA: 0x1C1A170 Offset: 0x1C19370 VA: 0x181C1A170
	public static void ValidateValue(ReadOnlySpan<byte> value) { }

	// RVA: 0x1C19950 Offset: 0x1C18B50 VA: 0x181C19950
	public static void ValidateBytes(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x1C199A0 Offset: 0x1C18BA0 VA: 0x181C199A0
	public static void ValidateDouble(double value) { }

	// RVA: 0x1C1A0C0 Offset: 0x1C192C0 VA: 0x181C1A0C0
	public static void ValidateSingle(float value) { }

	// RVA: 0x1C1A070 Offset: 0x1C19270 VA: 0x181C1A070
	public static void ValidateProperty(ReadOnlySpan<char> propertyName) { }

	// RVA: 0x1C1A120 Offset: 0x1C19320 VA: 0x181C1A120
	public static void ValidateValue(ReadOnlySpan<char> value) { }

	// RVA: 0x1C19F90 Offset: 0x1C19190 VA: 0x181C19F90
	public static void ValidatePropertyAndValue(ReadOnlySpan<char> propertyName, ReadOnlySpan<char> value) { }

	// RVA: 0x1C19A00 Offset: 0x1C18C00 VA: 0x181C19A00
	internal static void ValidateNumber(ReadOnlySpan<byte> utf8FormattedNumber) { }

	// RVA: 0x1C1A4E0 Offset: 0x1C196E0 VA: 0x181C1A4E0
	public static void WriteDateTimeTrimmed(Span<byte> buffer, DateTime value, out int bytesWritten) { }

	// RVA: 0x1C1A1C0 Offset: 0x1C193C0 VA: 0x181C1A1C0
	public static void WriteDateTimeOffsetTrimmed(Span<byte> buffer, DateTimeOffset value, out int bytesWritten) { }

	// RVA: 0x1C194B0 Offset: 0x1C186B0 VA: 0x181C194B0
	public static void TrimDateTimeOffset(Span<byte> buffer, out int bytesWritten) { }

	// RVA: 0x1C17A80 Offset: 0x1C16C80 VA: 0x181C17A80
	private static uint DivMod(uint numerator, uint denominator, out uint modulo) { }

	// RVA: 0x1C1AB60 Offset: 0x1C19D60 VA: 0x181C1AB60
	private static ReadOnlySpan<byte> get_AllowList() { }

	// RVA: 0x1C18EA0 Offset: 0x1C180A0 VA: 0x181C18EA0
	private static bool NeedsEscaping(byte value) { }

	// RVA: 0x1C18CE0 Offset: 0x1C17EE0 VA: 0x181C18CE0
	private static bool NeedsEscapingNoBoundsCheck(char value) { }

	// RVA: 0x1C18F50 Offset: 0x1C18150 VA: 0x181C18F50
	public static int NeedsEscaping(ReadOnlySpan<byte> value, JavaScriptEncoder encoder) { }

	// RVA: 0x1C18D90 Offset: 0x1C17F90 VA: 0x181C18D90
	public static int NeedsEscaping(ReadOnlySpan<char> value, JavaScriptEncoder encoder) { }

	// RVA: 0x1C18CC0 Offset: 0x1C17EC0 VA: 0x181C18CC0
	public static int GetMaxEscapedLength(int textLength, int firstIndexToEscape) { }

	// RVA: 0x1C187B0 Offset: 0x1C179B0 VA: 0x181C187B0
	private static void EscapeString(ReadOnlySpan<byte> value, Span<byte> destination, JavaScriptEncoder encoder, ref int written) { }

	// RVA: 0x1C18950 Offset: 0x1C17B50 VA: 0x181C18950
	public static void EscapeString(ReadOnlySpan<byte> value, Span<byte> destination, int indexOfFirstByteToEscape, JavaScriptEncoder encoder, out int written) { }

	// RVA: 0x1C17AA0 Offset: 0x1C16CA0 VA: 0x181C17AA0
	private static void EscapeNextBytes(byte value, Span<byte> destination, ref int written) { }

	// RVA: 0x1C18CD0 Offset: 0x1C17ED0 VA: 0x181C18CD0
	private static bool IsAsciiValue(byte value) { }

	// RVA: 0x176E7D0 Offset: 0x176D9D0 VA: 0x18176E7D0
	private static bool IsAsciiValue(char value) { }

	// RVA: 0x1C18690 Offset: 0x1C17890 VA: 0x181C18690
	private static void EscapeString(ReadOnlySpan<char> value, Span<char> destination, JavaScriptEncoder encoder, ref int written) { }

	// RVA: 0x1C18240 Offset: 0x1C17440 VA: 0x181C18240
	public static void EscapeString(ReadOnlySpan<char> value, Span<char> destination, int indexOfFirstByteToEscape, JavaScriptEncoder encoder, out int written) { }

	// RVA: 0x1C17EE0 Offset: 0x1C170E0 VA: 0x181C17EE0
	private static void EscapeNextChars(char value, Span<char> destination, ref int written) { }

	// RVA: 0x1C1A800 Offset: 0x1C19A00 VA: 0x181C1A800
	private static int WriteHex(int value, Span<char> destination, int written) { }

	// RVA: 0x1C18FF0 Offset: 0x1C181F0 VA: 0x181C18FF0
	public static OperationStatus ToUtf8(ReadOnlySpan<byte> utf16Source, Span<byte> utf8Destination, out int bytesConsumed, out int bytesWritten) { }

	// RVA: 0x15C8800 Offset: 0x15C7A00 VA: 0x1815C8800
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x15C87F0 Offset: 0x15C79F0 VA: 0x1815C87F0
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x1C1AAD0 Offset: 0x1C19CD0 VA: 0x181C1AAD0
	private static void .cctor() { }
}

// Namespace: System.Text.Json
[Nullable(0)]
[NullableContext(2)]
internal struct JsonWriterOptions // TypeDefIndex: 15905
{
	// Fields
	private int _optionsMask; // 0x0
	[CompilerGenerated]
	private JavaScriptEncoder <Encoder>k__BackingField; // 0x8

	// Properties
	public JavaScriptEncoder Encoder { get; set; }
	public bool Indented { get; set; }
	public bool SkipValidation { get; set; }
	internal bool IndentedOrNotSkipValidation { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public JavaScriptEncoder get_Encoder() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Encoder(JavaScriptEncoder value) { }

	// RVA: 0x1C1AC80 Offset: 0x1C19E80 VA: 0x181C1AC80
	public bool get_Indented() { }

	// RVA: 0x1C1ACA0 Offset: 0x1C19EA0 VA: 0x181C1ACA0
	public void set_Indented(bool value) { }

	// RVA: 0x1C1AC90 Offset: 0x1C19E90 VA: 0x181C1AC90
	public bool get_SkipValidation() { }

	// RVA: 0x1C1ACC0 Offset: 0x1C19EC0 VA: 0x181C1ACC0
	public void set_SkipValidation(bool value) { }

	// RVA: 0x1C1AC70 Offset: 0x1C19E70 VA: 0x181C1AC70
	internal bool get_IndentedOrNotSkipValidation() { }
}

// Namespace: 
[CompilerGenerated]
private struct Utf8JsonWriter.<DisposeAsync>d__35 : IAsyncStateMachine // TypeDefIndex: 15906
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public Utf8JsonWriter <>4__this; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1C3AD30 Offset: 0x1C39F30 VA: 0x181C3AD30 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C3AEA0 Offset: 0x1C3A0A0 VA: 0x181C3AEA0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct Utf8JsonWriter.<FlushAsync>d__36 : IAsyncStateMachine // TypeDefIndex: 15907
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Utf8JsonWriter <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1C3AEB0 Offset: 0x1C3A0B0 VA: 0x181C3AEB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C3B370 Offset: 0x1C3A570 VA: 0x181C3B370 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Text.Json
[DebuggerDisplay("{DebuggerDisplay,nq}")]
internal sealed class Utf8JsonWriter : IDisposable, IAsyncDisposable // TypeDefIndex: 15908
{
	// Fields
	private static readonly int s_newLineLength; // 0x0
	private IBufferWriter<byte> _output; // 0x10
	private Stream _stream; // 0x18
	private ArrayBufferWriter<byte> _arrayBufferWriter; // 0x20
	private Memory<byte> _memory; // 0x28
	private bool _inObject; // 0x38
	private JsonTokenType _tokenType; // 0x39
	private BitStack _bitStack; // 0x40
	private int _currentDepth; // 0x58
	private JsonWriterOptions _options; // 0x60
	[CompilerGenerated]
	private int <BytesPending>k__BackingField; // 0x70
	[CompilerGenerated]
	private long <BytesCommitted>k__BackingField; // 0x78
	private static readonly char[] s_singleLineCommentDelimiter; // 0x8

	// Properties
	public int BytesPending { get; set; }
	public long BytesCommitted { get; set; }
	public JsonWriterOptions Options { get; }
	private int Indentation { get; }
	public int CurrentDepth { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	public int get_BytesPending() { }

	[CompilerGenerated]
	// RVA: 0x526DC0 Offset: 0x525FC0 VA: 0x180526DC0
	private void set_BytesPending(int value) { }

	[CompilerGenerated]
	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public long get_BytesCommitted() { }

	[CompilerGenerated]
	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	private void set_BytesCommitted(long value) { }

	// RVA: 0x12DC690 Offset: 0x12DB890 VA: 0x1812DC690
	public JsonWriterOptions get_Options() { }

	// RVA: 0x1C34190 Offset: 0x1C33390 VA: 0x181C34190
	private int get_Indentation() { }

	// RVA: 0x1C34180 Offset: 0x1C33380 VA: 0x181C34180
	public int get_CurrentDepth() { }

	[NullableContext(1)]
	// RVA: 0x1C340E0 Offset: 0x1C332E0 VA: 0x181C340E0
	public void .ctor(IBufferWriter<byte> bufferWriter, JsonWriterOptions options) { }

	[NullableContext(1)]
	// RVA: 0x1C33F90 Offset: 0x1C33190 VA: 0x181C33F90
	public void .ctor(Stream utf8Json, JsonWriterOptions options) { }

	// RVA: 0x1C1CF60 Offset: 0x1C1C160 VA: 0x181C1CF60
	private void ResetHelper() { }

	// RVA: 0x1C1C6E0 Offset: 0x1C1B8E0 VA: 0x181C1C6E0
	private void CheckNotDisposed() { }

	// RVA: 0x1C1CAA0 Offset: 0x1C1BCA0 VA: 0x181C1CAA0
	public void Flush() { }

	// RVA: 0x1C1C850 Offset: 0x1C1BA50 VA: 0x181C1C850 Slot: 4
	public void Dispose() { }

	[AsyncStateMachine(typeof(Utf8JsonWriter.<DisposeAsync>d__35))]
	// RVA: 0x1C1C750 Offset: 0x1C1B950 VA: 0x181C1C750 Slot: 5
	public ValueTask DisposeAsync() { }

	[NullableContext(1)]
	[AsyncStateMachine(typeof(Utf8JsonWriter.<FlushAsync>d__36))]
	// RVA: 0x1C1C9C0 Offset: 0x1C1BBC0 VA: 0x181C1C9C0
	public Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1C2AF80 Offset: 0x1C2A180 VA: 0x181C2AF80
	public void WriteStartArray() { }

	// RVA: 0x1C2BBE0 Offset: 0x1C2ADE0 VA: 0x181C2BBE0
	public void WriteStartObject() { }

	// RVA: 0x1C2BF70 Offset: 0x1C2B170 VA: 0x181C2BF70
	private void WriteStart(byte token) { }

	// RVA: 0x1C2BAC0 Offset: 0x1C2ACC0 VA: 0x181C2BAC0
	private void WriteStartMinimized(byte token) { }

	// RVA: 0x1C2BE70 Offset: 0x1C2B070 VA: 0x181C2BE70
	private void WriteStartSlow(byte token) { }

	// RVA: 0x1C1D5C0 Offset: 0x1C1C7C0 VA: 0x181C1D5C0
	private void ValidateStart() { }

	// RVA: 0x1C2B850 Offset: 0x1C2AA50 VA: 0x181C2B850
	private void WriteStartIndented(byte token) { }

	// RVA: 0x1C2AFA0 Offset: 0x1C2A1A0 VA: 0x181C2AFA0
	public void WriteStartArray(JsonEncodedText propertyName) { }

	// RVA: 0x1C2B790 Offset: 0x1C2A990 VA: 0x181C2B790
	private void WriteStartHelper(ReadOnlySpan<byte> utf8PropertyName, byte token) { }

	// RVA: 0x1C2B150 Offset: 0x1C2A350 VA: 0x181C2B150
	private void WriteStartByOptions(ReadOnlySpan<byte> utf8PropertyName, byte token) { }

	[NullableContext(1)]
	// RVA: 0x1C2ADD0 Offset: 0x1C29FD0 VA: 0x181C2ADD0
	public void WriteStartArray(string propertyName) { }

	[NullableContext(1)]
	// RVA: 0x1C2BCC0 Offset: 0x1C2AEC0 VA: 0x181C2BCC0
	public void WriteStartObject(string propertyName) { }

	// RVA: 0x1C2AD10 Offset: 0x1C29F10 VA: 0x181C2AD10
	public void WriteStartArray(ReadOnlySpan<char> propertyName) { }

	// RVA: 0x1C2BC00 Offset: 0x1C2AE00 VA: 0x181C2BC00
	public void WriteStartObject(ReadOnlySpan<char> propertyName) { }

	// RVA: 0x1C2B580 Offset: 0x1C2A780 VA: 0x181C2B580
	private void WriteStartEscape(ReadOnlySpan<char> propertyName, byte token) { }

	// RVA: 0x1C2B0A0 Offset: 0x1C2A2A0 VA: 0x181C2B0A0
	private void WriteStartByOptions(ReadOnlySpan<char> propertyName, byte token) { }

	// RVA: 0x1C2B200 Offset: 0x1C2A400 VA: 0x181C2B200
	private void WriteStartEscapeProperty(ReadOnlySpan<char> propertyName, byte token, int firstEscapeIndexProp) { }

	// RVA: 0x1C1E2D0 Offset: 0x1C1D4D0 VA: 0x181C1E2D0
	public void WriteEndArray() { }

	// RVA: 0x1C1E630 Offset: 0x1C1D830 VA: 0x181C1E630
	public void WriteEndObject() { }

	// RVA: 0x1C1E6B0 Offset: 0x1C1D8B0 VA: 0x181C1E6B0
	private void WriteEnd(byte token) { }

	// RVA: 0x1C1E550 Offset: 0x1C1D750 VA: 0x181C1E550
	private void WriteEndMinimized(byte token) { }

	// RVA: 0x1C1E650 Offset: 0x1C1D850 VA: 0x181C1E650
	private void WriteEndSlow(byte token) { }

	// RVA: 0x1C1D470 Offset: 0x1C1C670 VA: 0x181C1D470
	private void ValidateEnd(byte token) { }

	// RVA: 0x1C1E2F0 Offset: 0x1C1D4F0 VA: 0x181C1E2F0
	private void WriteEndIndented(byte token) { }

	// RVA: 0x1C20930 Offset: 0x1C1FB30 VA: 0x181C20930
	private void WriteNewLine(Span<byte> output) { }

	// RVA: 0x1C0CDD0 Offset: 0x1C0BFD0 VA: 0x181C0CDD0
	private void UpdateBitStackOnStart(byte token) { }

	// RVA: 0x1C1CCF0 Offset: 0x1C1BEF0 VA: 0x181C1CCF0
	private void Grow(int requiredSize) { }

	// RVA: 0x1C1C8B0 Offset: 0x1C1BAB0 VA: 0x181C1C8B0
	private void FirstCallToGetMemory(int requiredSize) { }

	// RVA: 0x1C1CF80 Offset: 0x1C1C180 VA: 0x181C1CF80
	private void SetFlagToAddListSeparatorBeforeNextItem() { }

	// RVA: 0x1C2A520 Offset: 0x1C29720 VA: 0x181C2A520
	internal void WritePropertyName(DateTime value) { }

	[NullableContext(1)]
	// RVA: 0x1C33910 Offset: 0x1C32B10 VA: 0x181C33910
	public void WriteString(string propertyName, DateTimeOffset value) { }

	// RVA: 0x1C33AF0 Offset: 0x1C32CF0 VA: 0x181C33AF0
	public void WriteString(ReadOnlySpan<char> propertyName, DateTimeOffset value) { }

	// RVA: 0x1C2EAB0 Offset: 0x1C2DCB0 VA: 0x181C2EAB0
	private void WriteStringEscape(ReadOnlySpan<char> propertyName, DateTimeOffset value) { }

	// RVA: 0x1C2CF20 Offset: 0x1C2C120 VA: 0x181C2CF20
	private void WriteStringEscapeProperty(ReadOnlySpan<char> propertyName, DateTimeOffset value, int firstEscapeIndexProp) { }

	// RVA: 0x1C2C1B0 Offset: 0x1C2B3B0 VA: 0x181C2C1B0
	private void WriteStringByOptions(ReadOnlySpan<char> propertyName, DateTimeOffset value) { }

	// RVA: 0x1C31540 Offset: 0x1C30740 VA: 0x181C31540
	private void WriteStringMinimized(ReadOnlySpan<char> escapedPropertyName, DateTimeOffset value) { }

	// RVA: 0x1C2FF40 Offset: 0x1C2F140 VA: 0x181C2FF40
	private void WriteStringIndented(ReadOnlySpan<char> escapedPropertyName, DateTimeOffset value) { }

	// RVA: 0x1C29000 Offset: 0x1C28200 VA: 0x181C29000
	internal void WritePropertyName(DateTimeOffset value) { }

	// RVA: 0x1C29280 Offset: 0x1C28480 VA: 0x181C29280
	internal void WritePropertyName(Decimal value) { }

	[NullableContext(1)]
	// RVA: 0x1C27800 Offset: 0x1C26A00 VA: 0x181C27800
	public void WriteNumber(string propertyName, double value) { }

	// RVA: 0x1C274F0 Offset: 0x1C266F0 VA: 0x181C274F0
	public void WriteNumber(ReadOnlySpan<char> propertyName, double value) { }

	// RVA: 0x1C22600 Offset: 0x1C21800 VA: 0x181C22600
	private void WriteNumberEscape(ReadOnlySpan<char> propertyName, double value) { }

	// RVA: 0x1C21900 Offset: 0x1C20B00 VA: 0x181C21900
	private void WriteNumberEscapeProperty(ReadOnlySpan<char> propertyName, double value, int firstEscapeIndexProp) { }

	// RVA: 0x1C21040 Offset: 0x1C20240 VA: 0x181C21040
	private void WriteNumberByOptions(ReadOnlySpan<char> propertyName, double value) { }

	// RVA: 0x1C23800 Offset: 0x1C22A00 VA: 0x181C23800
	private void WriteNumberMinimized(ReadOnlySpan<char> escapedPropertyName, double value) { }

	// RVA: 0x1C23000 Offset: 0x1C22200 VA: 0x181C23000
	private void WriteNumberIndented(ReadOnlySpan<char> escapedPropertyName, double value) { }

	// RVA: 0x1C29D10 Offset: 0x1C28F10 VA: 0x181C29D10
	internal void WritePropertyName(double value) { }

	[NullableContext(1)]
	// RVA: 0x1C27F50 Offset: 0x1C27150 VA: 0x181C27F50
	public void WriteNumber(string propertyName, float value) { }

	// RVA: 0x1C276E0 Offset: 0x1C268E0 VA: 0x181C276E0
	public void WriteNumber(ReadOnlySpan<char> propertyName, float value) { }

	// RVA: 0x1C22400 Offset: 0x1C21600 VA: 0x181C22400
	private void WriteNumberEscape(ReadOnlySpan<char> propertyName, float value) { }

	// RVA: 0x1C21C80 Offset: 0x1C20E80 VA: 0x181C21C80
	private void WriteNumberEscapeProperty(ReadOnlySpan<char> propertyName, float value, int firstEscapeIndexProp) { }

	// RVA: 0x1C20FA0 Offset: 0x1C201A0 VA: 0x181C20FA0
	private void WriteNumberByOptions(ReadOnlySpan<char> propertyName, float value) { }

	// RVA: 0x1C23D50 Offset: 0x1C22F50 VA: 0x181C23D50
	private void WriteNumberMinimized(ReadOnlySpan<char> escapedPropertyName, float value) { }

	// RVA: 0x1C23400 Offset: 0x1C22600 VA: 0x181C23400
	private void WriteNumberIndented(ReadOnlySpan<char> escapedPropertyName, float value) { }

	// RVA: 0x1C2A010 Offset: 0x1C29210 VA: 0x181C2A010
	internal void WritePropertyName(float value) { }

	// RVA: 0x1C2A790 Offset: 0x1C29990 VA: 0x181C2A790
	internal void WritePropertyName(Guid value) { }

	// RVA: 0x1C1D540 Offset: 0x1C1C740 VA: 0x181C1D540
	private void ValidatePropertyNameAndDepth(ReadOnlySpan<char> propertyName) { }

	// RVA: 0x1C1D450 Offset: 0x1C1C650 VA: 0x181C1D450
	private void ValidateDepth() { }

	// RVA: 0x1C1D610 Offset: 0x1C1C810 VA: 0x181C1D610
	private void ValidateWritingProperty() { }

	// RVA: 0x1C1D650 Offset: 0x1C1C850 VA: 0x181C1D650
	private void ValidateWritingProperty(byte token) { }

	// RVA: 0x1C28920 Offset: 0x1C27B20 VA: 0x181C28920
	private void WritePropertyNameMinimized(ReadOnlySpan<byte> escapedPropertyName, byte token) { }

	// RVA: 0x1C28550 Offset: 0x1C27750 VA: 0x181C28550
	private void WritePropertyNameIndented(ReadOnlySpan<byte> escapedPropertyName, byte token) { }

	// RVA: 0x1C28BB0 Offset: 0x1C27DB0 VA: 0x181C28BB0
	private void WritePropertyNameMinimized(ReadOnlySpan<char> escapedPropertyName, byte token) { }

	// RVA: 0x1C281F0 Offset: 0x1C273F0 VA: 0x181C281F0
	private void WritePropertyNameIndented(ReadOnlySpan<char> escapedPropertyName, byte token) { }

	// RVA: 0x1C1CF90 Offset: 0x1C1C190 VA: 0x181C1CF90
	private void TranscodeAndWrite(ReadOnlySpan<char> escapedPropertyName, Span<byte> output) { }

	// RVA: 0x1C20EB0 Offset: 0x1C200B0 VA: 0x181C20EB0
	public void WriteNull(JsonEncodedText propertyName) { }

	// RVA: 0x1C20A30 Offset: 0x1C1FC30 VA: 0x181C20A30
	internal void WriteNullSection(ReadOnlySpan<byte> escapedPropertyNameSection) { }

	// RVA: 0x1C1F330 Offset: 0x1C1E530 VA: 0x181C1F330
	private void WriteLiteralHelper(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> value) { }

	[NullableContext(1)]
	// RVA: 0x1C20C90 Offset: 0x1C1FE90 VA: 0x181C20C90
	public void WriteNull(string propertyName) { }

	// RVA: 0x1C20DD0 Offset: 0x1C1FFD0 VA: 0x181C20DD0
	public void WriteNull(ReadOnlySpan<char> propertyName) { }

	[NullableContext(1)]
	// RVA: 0x1C1DFB0 Offset: 0x1C1D1B0 VA: 0x181C1DFB0
	public void WriteBoolean(string propertyName, bool value) { }

	// RVA: 0x1C1E1C0 Offset: 0x1C1D3C0 VA: 0x181C1E1C0
	public void WriteBoolean(ReadOnlySpan<char> propertyName, bool value) { }

	// RVA: 0x1C1F100 Offset: 0x1C1E300 VA: 0x181C1F100
	private void WriteLiteralEscape(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> value) { }

	// RVA: 0x1C1ED80 Offset: 0x1C1DF80 VA: 0x181C1ED80
	private void WriteLiteralEscapeProperty(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> value, int firstEscapeIndexProp) { }

	// RVA: 0x1C1ECA0 Offset: 0x1C1DEA0 VA: 0x181C1ECA0
	private void WriteLiteralByOptions(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> value) { }

	// RVA: 0x1C1EB20 Offset: 0x1C1DD20 VA: 0x181C1EB20
	private void WriteLiteralByOptions(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> value) { }

	// RVA: 0x1C200F0 Offset: 0x1C1F2F0 VA: 0x181C200F0
	private void WriteLiteralMinimized(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<byte> value) { }

	// RVA: 0x1C203A0 Offset: 0x1C1F5A0 VA: 0x181C203A0
	private void WriteLiteralMinimized(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<byte> value) { }

	// RVA: 0x1C206B0 Offset: 0x1C1F8B0 VA: 0x181C206B0
	private void WriteLiteralSection(ReadOnlySpan<byte> escapedPropertyNameSection, ReadOnlySpan<byte> value) { }

	// RVA: 0x1C1F850 Offset: 0x1C1EA50 VA: 0x181C1F850
	private void WriteLiteralIndented(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<byte> value) { }

	// RVA: 0x1C1F400 Offset: 0x1C1E600 VA: 0x181C1F400
	private void WriteLiteralIndented(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<byte> value) { }

	// RVA: 0x1C296D0 Offset: 0x1C288D0 VA: 0x181C296D0
	internal void WritePropertyName(bool value) { }

	[NullableContext(1)]
	// RVA: 0x1C27B60 Offset: 0x1C26D60 VA: 0x181C27B60
	public void WriteNumber(string propertyName, long value) { }

	// RVA: 0x1C27610 Offset: 0x1C26810 VA: 0x181C27610
	public void WriteNumber(ReadOnlySpan<char> propertyName, long value) { }

	[NullableContext(1)]
	// RVA: 0x1C27A10 Offset: 0x1C26C10 VA: 0x181C27A10
	public void WriteNumber(string propertyName, int value) { }

	// RVA: 0x1C22200 Offset: 0x1C21400 VA: 0x181C22200
	private void WriteNumberEscape(ReadOnlySpan<char> propertyName, long value) { }

	// RVA: 0x1C21590 Offset: 0x1C20790 VA: 0x181C21590
	private void WriteNumberEscapeProperty(ReadOnlySpan<char> propertyName, long value, int firstEscapeIndexProp) { }

	// RVA: 0x1C21180 Offset: 0x1C20380 VA: 0x181C21180
	private void WriteNumberByOptions(ReadOnlySpan<char> propertyName, long value) { }

	// RVA: 0x1C23FF0 Offset: 0x1C231F0 VA: 0x181C23FF0
	private void WriteNumberMinimized(ReadOnlySpan<char> escapedPropertyName, long value) { }

	// RVA: 0x1C22C00 Offset: 0x1C21E00 VA: 0x181C22C00
	private void WriteNumberIndented(ReadOnlySpan<char> escapedPropertyName, long value) { }

	// RVA: 0x1C296C0 Offset: 0x1C288C0 VA: 0x181C296C0
	internal void WritePropertyName(int value) { }

	// RVA: 0x1C29950 Offset: 0x1C28B50 VA: 0x181C29950
	internal void WritePropertyName(long value) { }

	// RVA: 0x1C2AA20 Offset: 0x1C29C20 VA: 0x181C2AA20
	public void WritePropertyName(JsonEncodedText propertyName) { }

	// RVA: 0x1C28DC0 Offset: 0x1C27FC0 VA: 0x181C28DC0
	internal void WritePropertyNameSection(ReadOnlySpan<byte> escapedPropertyNameSection) { }

	// RVA: 0x1C28160 Offset: 0x1C27360 VA: 0x181C28160
	private void WritePropertyNameHelper(ReadOnlySpan<byte> utf8PropertyName) { }

	[NullableContext(1)]
	// RVA: 0x1C29BD0 Offset: 0x1C28DD0 VA: 0x181C29BD0
	public void WritePropertyName(string propertyName) { }

	// RVA: 0x1C2AAE0 Offset: 0x1C29CE0 VA: 0x181C2AAE0
	public void WritePropertyName(ReadOnlySpan<char> propertyName) { }

	// RVA: 0x1C2D290 Offset: 0x1C2C490 VA: 0x181C2D290
	private void WriteStringEscapeProperty(ReadOnlySpan<char> propertyName, int firstEscapeIndexProp) { }

	// RVA: 0x1C2C090 Offset: 0x1C2B290 VA: 0x181C2C090
	private void WriteStringByOptionsPropertyName(ReadOnlySpan<char> propertyName) { }

	// RVA: 0x1C30AC0 Offset: 0x1C2FCC0 VA: 0x181C30AC0
	private void WriteStringMinimizedPropertyName(ReadOnlySpan<char> escapedPropertyName) { }

	// RVA: 0x1C2F490 Offset: 0x1C2E690 VA: 0x181C2F490
	private void WriteStringIndentedPropertyName(ReadOnlySpan<char> escapedPropertyName) { }

	// RVA: 0x1C29510 Offset: 0x1C28710 VA: 0x181C29510
	public void WritePropertyName(ReadOnlySpan<byte> utf8PropertyName) { }

	// RVA: 0x1C28EF0 Offset: 0x1C280F0 VA: 0x181C28EF0
	private void WritePropertyNameUnescaped(ReadOnlySpan<byte> utf8PropertyName) { }

	// RVA: 0x1C2CBB0 Offset: 0x1C2BDB0 VA: 0x181C2CBB0
	private void WriteStringEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, int firstEscapeIndexProp) { }

	// RVA: 0x1C2C120 Offset: 0x1C2B320 VA: 0x181C2C120
	private void WriteStringByOptionsPropertyName(ReadOnlySpan<byte> utf8PropertyName) { }

	// RVA: 0x1C30C90 Offset: 0x1C2FE90 VA: 0x181C30C90
	private void WriteStringMinimizedPropertyName(ReadOnlySpan<byte> escapedPropertyName) { }

	// RVA: 0x1C31B60 Offset: 0x1C30D60 VA: 0x181C31B60
	private void WriteStringPropertyNameSection(ReadOnlySpan<byte> escapedPropertyNameSection) { }

	// RVA: 0x1C2F0F0 Offset: 0x1C2E2F0 VA: 0x181C2F0F0
	private void WriteStringIndentedPropertyName(ReadOnlySpan<byte> escapedPropertyName) { }

	[NullableContext(1)]
	// RVA: 0x1C33BD0 Offset: 0x1C32DD0 VA: 0x181C33BD0
	public void WriteString(string propertyName, string value) { }

	// RVA: 0x1C337E0 Offset: 0x1C329E0 VA: 0x181C337E0
	public void WriteString(ReadOnlySpan<char> propertyName, ReadOnlySpan<char> value) { }

	[NullableContext(2)]
	// RVA: 0x1C335F0 Offset: 0x1C327F0 VA: 0x181C335F0
	public void WriteString(JsonEncodedText propertyName, string value) { }

	// RVA: 0x1C33590 Offset: 0x1C32790 VA: 0x181C33590
	public void WriteString(JsonEncodedText propertyName, ReadOnlySpan<char> value) { }

	// RVA: 0x1C2EE80 Offset: 0x1C2E080 VA: 0x181C2EE80
	private void WriteStringHelperEscapeValue(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<char> value) { }

	// RVA: 0x1C2D610 Offset: 0x1C2C810 VA: 0x181C2D610
	private void WriteStringEscapeValueOnly(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<char> value, int firstEscapeIndex) { }

	// RVA: 0x1C2E580 Offset: 0x1C2D780 VA: 0x181C2E580
	private void WriteStringEscape(ReadOnlySpan<char> propertyName, ReadOnlySpan<char> value) { }

	// RVA: 0x1C2C560 Offset: 0x1C2B760 VA: 0x181C2C560
	private void WriteStringEscapePropertyOrValue(ReadOnlySpan<char> propertyName, ReadOnlySpan<char> value, int firstEscapeIndexProp, int firstEscapeIndexVal) { }

	// RVA: 0x1C2C260 Offset: 0x1C2B460 VA: 0x181C2C260
	private void WriteStringByOptions(ReadOnlySpan<char> propertyName, ReadOnlySpan<char> value) { }

	// RVA: 0x1C2C340 Offset: 0x1C2B540 VA: 0x181C2C340
	private void WriteStringByOptions(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<char> value) { }

	// RVA: 0x1C312C0 Offset: 0x1C304C0 VA: 0x181C312C0
	private void WriteStringMinimized(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<char> escapedValue) { }

	// RVA: 0x1C31850 Offset: 0x1C30A50 VA: 0x181C31850
	private void WriteStringMinimized(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<char> escapedValue) { }

	// RVA: 0x1C306E0 Offset: 0x1C2F8E0 VA: 0x181C306E0
	private void WriteStringIndented(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<char> escapedValue) { }

	// RVA: 0x1C2FAD0 Offset: 0x1C2ECD0 VA: 0x181C2FAD0
	private void WriteStringIndented(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<char> escapedValue) { }

	[NullableContext(1)]
	[CLSCompliant(False)]
	// RVA: 0x1C27D80 Offset: 0x1C26F80 VA: 0x181C27D80
	public void WriteNumber(string propertyName, ulong value) { }

	[CLSCompliant(False)]
	// RVA: 0x1C27CB0 Offset: 0x1C26EB0 VA: 0x181C27CB0
	public void WriteNumber(ReadOnlySpan<char> propertyName, ulong value) { }

	// RVA: 0x1C22000 Offset: 0x1C21200 VA: 0x181C22000
	private void WriteNumberEscape(ReadOnlySpan<char> propertyName, ulong value) { }

	// RVA: 0x1C21220 Offset: 0x1C20420 VA: 0x181C21220
	private void WriteNumberEscapeProperty(ReadOnlySpan<char> propertyName, ulong value, int firstEscapeIndexProp) { }

	// RVA: 0x1C210E0 Offset: 0x1C202E0 VA: 0x181C210E0
	private void WriteNumberByOptions(ReadOnlySpan<char> propertyName, ulong value) { }

	// RVA: 0x1C23AA0 Offset: 0x1C22CA0 VA: 0x181C23AA0
	private void WriteNumberMinimized(ReadOnlySpan<char> escapedPropertyName, ulong value) { }

	// RVA: 0x1C22800 Offset: 0x1C21A00 VA: 0x181C22800
	private void WriteNumberIndented(ReadOnlySpan<char> escapedPropertyName, ulong value) { }

	// RVA: 0x1C28FF0 Offset: 0x1C281F0 VA: 0x181C28FF0
	internal void WritePropertyName(uint value) { }

	// RVA: 0x1C2A2A0 Offset: 0x1C294A0 VA: 0x181C2A2A0
	internal void WritePropertyName(ulong value) { }

	// RVA: 0x1C1DD10 Offset: 0x1C1CF10 VA: 0x181C1DD10
	public void WriteBase64StringValue(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x1C1D700 Offset: 0x1C1C900 VA: 0x181C1D700
	private void WriteBase64ByOptions(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x1C1DB10 Offset: 0x1C1CD10 VA: 0x181C1DB10
	private void WriteBase64Minimized(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x1C1D7A0 Offset: 0x1C1C9A0 VA: 0x181C1D7A0
	private void WriteBase64Indented(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x1C33500 Offset: 0x1C32700 VA: 0x181C33500
	public void WriteStringValue(DateTime value) { }

	// RVA: 0x1C32730 Offset: 0x1C31930 VA: 0x181C32730
	private void WriteStringValueMinimized(DateTime value) { }

	// RVA: 0x1C32090 Offset: 0x1C31290 VA: 0x181C32090
	private void WriteStringValueIndented(DateTime value) { }

	// RVA: 0x1C32DF0 Offset: 0x1C31FF0 VA: 0x181C32DF0
	public void WriteStringValue(DateTimeOffset value) { }

	// RVA: 0x1C32BB0 Offset: 0x1C31DB0 VA: 0x181C32BB0
	private void WriteStringValueMinimized(DateTimeOffset value) { }

	// RVA: 0x1C323E0 Offset: 0x1C315E0 VA: 0x181C323E0
	private void WriteStringValueIndented(DateTimeOffset value) { }

	// RVA: 0x1C26FE0 Offset: 0x1C261E0 VA: 0x181C26FE0
	public void WriteNumberValue(Decimal value) { }

	// RVA: 0x1C26950 Offset: 0x1C25B50 VA: 0x181C26950
	private void WriteNumberValueMinimized(Decimal value) { }

	// RVA: 0x1C254C0 Offset: 0x1C246C0 VA: 0x181C254C0
	private void WriteNumberValueIndented(Decimal value) { }

	// RVA: 0x1C24620 Offset: 0x1C23820 VA: 0x181C24620
	internal void WriteNumberValueAsString(Decimal value) { }

	// RVA: 0x1C26EE0 Offset: 0x1C260E0 VA: 0x181C26EE0
	public void WriteNumberValue(double value) { }

	// RVA: 0x1C263B0 Offset: 0x1C255B0 VA: 0x181C263B0
	private void WriteNumberValueMinimized(double value) { }

	// RVA: 0x1C257C0 Offset: 0x1C249C0 VA: 0x181C257C0
	private void WriteNumberValueIndented(double value) { }

	// RVA: 0x1C1D130 Offset: 0x1C1C330 VA: 0x181C1D130
	private static bool TryFormatDouble(double value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1C24EE0 Offset: 0x1C240E0 VA: 0x181C24EE0
	internal void WriteNumberValueAsString(double value) { }

	// RVA: 0x1C1E730 Offset: 0x1C1D930 VA: 0x181C1E730
	internal void WriteFloatingPointConstant(double value) { }

	// RVA: 0x1C273F0 Offset: 0x1C265F0 VA: 0x181C273F0
	public void WriteNumberValue(float value) { }

	// RVA: 0x1C26D00 Offset: 0x1C25F00 VA: 0x181C26D00
	private void WriteNumberValueMinimized(float value) { }

	// RVA: 0x1C260A0 Offset: 0x1C252A0 VA: 0x181C260A0
	private void WriteNumberValueIndented(float value) { }

	// RVA: 0x1C1D2C0 Offset: 0x1C1C4C0 VA: 0x181C1D2C0
	private static bool TryFormatSingle(float value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1C24BF0 Offset: 0x1C23DF0 VA: 0x181C24BF0
	internal void WriteNumberValueAsString(float value) { }

	// RVA: 0x1C1E930 Offset: 0x1C1DB30 VA: 0x181C1E930
	internal void WriteFloatingPointConstant(float value) { }

	// RVA: 0x1C272C0 Offset: 0x1C264C0 VA: 0x181C272C0
	internal void WriteNumberValue(ReadOnlySpan<byte> utf8FormattedNumber) { }

	// RVA: 0x1C26B40 Offset: 0x1C25D40 VA: 0x181C26B40
	private void WriteNumberValueMinimized(ReadOnlySpan<byte> utf8Value) { }

	// RVA: 0x1C25AD0 Offset: 0x1C24CD0 VA: 0x181C25AD0
	private void WriteNumberValueIndented(ReadOnlySpan<byte> utf8Value) { }

	// RVA: 0x1C330A0 Offset: 0x1C322A0 VA: 0x181C330A0
	public void WriteStringValue(Guid value) { }

	// RVA: 0x1C32970 Offset: 0x1C31B70 VA: 0x181C32970
	private void WriteStringValueMinimized(Guid value) { }

	// RVA: 0x1C31D20 Offset: 0x1C30F20 VA: 0x181C31D20
	private void WriteStringValueIndented(Guid value) { }

	// RVA: 0x1C1D6B0 Offset: 0x1C1C8B0 VA: 0x181C1D6B0
	private void ValidateWritingValue() { }

	// RVA: 0x1C1C2F0 Offset: 0x1C1B4F0 VA: 0x181C1C2F0
	private void Base64EncodeAndWrite(ReadOnlySpan<byte> bytes, Span<byte> output, int encodingLength) { }

	// RVA: 0x1C20BC0 Offset: 0x1C1FDC0 VA: 0x181C20BC0
	public void WriteNullValue() { }

	// RVA: 0x1C1DE20 Offset: 0x1C1D020 VA: 0x181C1DE20
	public void WriteBooleanValue(bool value) { }

	// RVA: 0x1C1EC00 Offset: 0x1C1DE00 VA: 0x181C1EC00
	private void WriteLiteralByOptions(ReadOnlySpan<byte> utf8Value) { }

	// RVA: 0x1C1FF30 Offset: 0x1C1F130 VA: 0x181C1FF30
	private void WriteLiteralMinimized(ReadOnlySpan<byte> utf8Value) { }

	// RVA: 0x1C1FC50 Offset: 0x1C1EE50 VA: 0x181C1FC50
	private void WriteLiteralIndented(ReadOnlySpan<byte> utf8Value) { }

	// RVA: 0x1C271A0 Offset: 0x1C263A0 VA: 0x181C271A0
	public void WriteNumberValue(int value) { }

	// RVA: 0x1C27110 Offset: 0x1C26310 VA: 0x181C27110
	public void WriteNumberValue(long value) { }

	// RVA: 0x1C26590 Offset: 0x1C25790 VA: 0x181C26590
	private void WriteNumberValueMinimized(long value) { }

	// RVA: 0x1C25DB0 Offset: 0x1C24FB0 VA: 0x181C25DB0
	private void WriteNumberValueIndented(long value) { }

	// RVA: 0x1C24910 Offset: 0x1C23B10 VA: 0x181C24910
	internal void WriteNumberValueAsString(long value) { }

	// RVA: 0x1C33200 Offset: 0x1C32400 VA: 0x181C33200
	public void WriteStringValue(JsonEncodedText value) { }

	[NullableContext(2)]
	// RVA: 0x1C332D0 Offset: 0x1C324D0 VA: 0x181C332D0
	public void WriteStringValue(string value) { }

	// RVA: 0x1C33140 Offset: 0x1C32340 VA: 0x181C33140
	public void WriteStringValue(ReadOnlySpan<char> value) { }

	// RVA: 0x1C2E8B0 Offset: 0x1C2DAB0 VA: 0x181C2E8B0
	private void WriteStringEscape(ReadOnlySpan<char> value) { }

	// RVA: 0x1C2C420 Offset: 0x1C2B620 VA: 0x181C2C420
	private void WriteStringByOptions(ReadOnlySpan<char> value) { }

	// RVA: 0x1C31120 Offset: 0x1C30320 VA: 0x181C31120
	private void WriteStringMinimized(ReadOnlySpan<char> escapedValue) { }

	// RVA: 0x1C2F7C0 Offset: 0x1C2E9C0 VA: 0x181C2F7C0
	private void WriteStringIndented(ReadOnlySpan<char> escapedValue) { }

	// RVA: 0x1C2E210 Offset: 0x1C2D410 VA: 0x181C2E210
	private void WriteStringEscapeValue(ReadOnlySpan<char> value, int firstEscapeIndexVal) { }

	// RVA: 0x1C32E90 Offset: 0x1C32090 VA: 0x181C32E90
	public void WriteStringValue(ReadOnlySpan<byte> utf8Value) { }

	// RVA: 0x1C2ECD0 Offset: 0x1C2DED0 VA: 0x181C2ECD0
	private void WriteStringEscape(ReadOnlySpan<byte> utf8Value) { }

	// RVA: 0x1C2C4C0 Offset: 0x1C2B6C0 VA: 0x181C2C4C0
	private void WriteStringByOptions(ReadOnlySpan<byte> utf8Value) { }

	// RVA: 0x1C30EF0 Offset: 0x1C300F0 VA: 0x181C30EF0
	private void WriteStringMinimized(ReadOnlySpan<byte> escapedValue) { }

	// RVA: 0x1C30390 Offset: 0x1C2F590 VA: 0x181C30390
	private void WriteStringIndented(ReadOnlySpan<byte> escapedValue) { }

	// RVA: 0x1C2D990 Offset: 0x1C2CB90 VA: 0x181C2D990
	private void WriteStringEscapeValue(ReadOnlySpan<byte> utf8Value, int firstEscapeIndexVal) { }

	// RVA: 0x1C242A0 Offset: 0x1C234A0 VA: 0x181C242A0
	internal void WriteNumberValueAsStringUnescaped(ReadOnlySpan<byte> utf8Value) { }

	[CLSCompliant(False)]
	// RVA: 0x1C27080 Offset: 0x1C26280 VA: 0x181C27080
	public void WriteNumberValue(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1C27230 Offset: 0x1C26430 VA: 0x181C27230
	public void WriteNumberValue(ulong value) { }

	// RVA: 0x1C26770 Offset: 0x1C25970 VA: 0x181C26770
	private void WriteNumberValueMinimized(ulong value) { }

	// RVA: 0x1C251D0 Offset: 0x1C243D0 VA: 0x181C251D0
	private void WriteNumberValueIndented(ulong value) { }

	// RVA: 0x1C24340 Offset: 0x1C23540 VA: 0x181C24340
	internal void WriteNumberValueAsString(ulong value) { }

	// RVA: 0x1C33EF0 Offset: 0x1C330F0 VA: 0x181C33EF0
	private static void .cctor() { }
}

// Namespace: System.Text.Json.Serialization
internal abstract class JsonAttribute : Attribute // TypeDefIndex: 15909
{}

// Namespace: System.Text.Json.Serialization
[Usage(32, AllowMultiple = False)]
internal sealed class JsonConstructorAttribute : JsonAttribute // TypeDefIndex: 15910
{}

// Namespace: System.Text.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
[Usage(412, AllowMultiple = False)]
internal class JsonConverterAttribute : JsonAttribute // TypeDefIndex: 15911
{
	// Fields
	[CompilerGenerated]
	private Type <ConverterType>k__BackingField; // 0x10

	// Properties
	[Nullable(2)]
	[DynamicallyAccessedMembers(1)]
	public Type ConverterType { get; }

	// Methods

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Type get_ConverterType() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public virtual JsonConverter CreateConverter(Type typeToConvert) { }
}

// Namespace: System.Text.Json.Serialization
[Usage(384, AllowMultiple = False)]
internal sealed class JsonExtensionDataAttribute : JsonAttribute // TypeDefIndex: 15912
{}

// Namespace: System.Text.Json.Serialization
[Usage(384, AllowMultiple = False)]
internal sealed class JsonIgnoreAttribute : JsonAttribute // TypeDefIndex: 15913
{
	// Fields
	[CompilerGenerated]
	private JsonIgnoreCondition <Condition>k__BackingField; // 0x10

	// Properties
	public JsonIgnoreCondition Condition { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public JsonIgnoreCondition get_Condition() { }
}

// Namespace: System.Text.Json.Serialization
[Usage(384, AllowMultiple = False)]
internal sealed class JsonIncludeAttribute : JsonAttribute // TypeDefIndex: 15914
{}

// Namespace: System.Text.Json.Serialization
[Usage(396, AllowMultiple = False)]
internal sealed class JsonNumberHandlingAttribute : JsonAttribute // TypeDefIndex: 15915
{
	// Fields
	[CompilerGenerated]
	private readonly JsonNumberHandling <Handling>k__BackingField; // 0x10

	// Properties
	public JsonNumberHandling Handling { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public JsonNumberHandling get_Handling() { }
}

// Namespace: System.Text.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
[Usage(384, AllowMultiple = False)]
internal sealed class JsonPropertyNameAttribute : JsonAttribute // TypeDefIndex: 15916
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }
}

// Namespace: System.Text.Json.Serialization
[DefaultMember("Item")]
internal sealed class ConverterList : IList<JsonConverter>, ICollection<JsonConverter>, IEnumerable<JsonConverter>, IEnumerable // TypeDefIndex: 15917
{
	// Fields
	private readonly List<JsonConverter> _list; // 0x10
	private readonly JsonSerializerOptions _options; // 0x18

	// Properties
	public JsonConverter Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1C356C0 Offset: 0x1C348C0 VA: 0x181C356C0
	public void .ctor(JsonSerializerOptions options) { }

	// RVA: 0x1C35780 Offset: 0x1C34980 VA: 0x181C35780 Slot: 4
	public JsonConverter get_Item(int index) { }

	// RVA: 0x1C357E0 Offset: 0x1C349E0 VA: 0x181C357E0 Slot: 5
	public void set_Item(int index, JsonConverter value) { }

	// RVA: 0x1C35740 Offset: 0x1C34940 VA: 0x181C35740 Slot: 9
	public int get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1C35170 Offset: 0x1C34370 VA: 0x181C35170 Slot: 11
	public void Add(JsonConverter item) { }

	// RVA: 0x1C35280 Offset: 0x1C34480 VA: 0x181C35280 Slot: 12
	public void Clear() { }

	// RVA: 0x1C352F0 Offset: 0x1C344F0 VA: 0x181C352F0 Slot: 13
	public bool Contains(JsonConverter item) { }

	// RVA: 0x1C35350 Offset: 0x1C34550 VA: 0x181C35350 Slot: 14
	public void CopyTo(JsonConverter[] array, int arrayIndex) { }

	// RVA: 0x1C353C0 Offset: 0x1C345C0 VA: 0x181C353C0 Slot: 16
	public IEnumerator<JsonConverter> GetEnumerator() { }

	// RVA: 0x1C35440 Offset: 0x1C34640 VA: 0x181C35440 Slot: 6
	public int IndexOf(JsonConverter item) { }

	// RVA: 0x1C354A0 Offset: 0x1C346A0 VA: 0x181C354A0 Slot: 7
	public void Insert(int index, JsonConverter item) { }

	// RVA: 0x1C355D0 Offset: 0x1C347D0 VA: 0x181C355D0 Slot: 15
	public bool Remove(JsonConverter item) { }

	// RVA: 0x1C35560 Offset: 0x1C34760 VA: 0x181C35560 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x1C35640 Offset: 0x1C34840 VA: 0x181C35640 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Text.Json.Serialization
[Extension]
internal static class IEnumerableConverterFactoryHelpers // TypeDefIndex: 15918
{
	// Methods

	[Extension]
	// RVA: 0x1C360B0 Offset: 0x1C352B0 VA: 0x181C360B0
	internal static Type GetCompatibleGenericBaseClass(Type type, Type baseType) { }

	[Extension]
	// RVA: 0x1C36220 Offset: 0x1C35420 VA: 0x181C36220
	internal static Type GetCompatibleGenericInterface(Type type, Type interfaceType) { }

	[Extension]
	// RVA: 0x1C36EA0 Offset: 0x1C360A0 VA: 0x181C36EA0
	public static bool IsImmutableDictionaryType(Type type) { }

	[Extension]
	// RVA: 0x1C37010 Offset: 0x1C36210 VA: 0x181C37010
	public static bool IsImmutableEnumerableType(Type type) { }

	[Extension]
	// RVA: 0x1C36C20 Offset: 0x1C35E20 VA: 0x181C36C20
	public static MethodInfo GetImmutableEnumerableCreateRangeMethod(Type type, Type elementType) { }

	[Extension]
	// RVA: 0x1C36500 Offset: 0x1C35700 VA: 0x181C36500
	public static MethodInfo GetImmutableDictionaryCreateRangeMethod(Type type, Type keyType, Type valueType) { }

	// RVA: 0x1C36870 Offset: 0x1C35A70 VA: 0x181C36870
	private static Type GetImmutableEnumerableConstructingType(Type type) { }

	// RVA: 0x1C363B0 Offset: 0x1C355B0 VA: 0x181C363B0
	private static Type GetImmutableDictionaryConstructingType(Type type) { }

	[Extension]
	// RVA: 0x1C372E0 Offset: 0x1C364E0 VA: 0x181C372E0
	public static bool IsNonGenericStackOrQueue(Type type) { }

	// RVA: 0x1C36E30 Offset: 0x1C36030 VA: 0x181C36E30
	private static Type GetTypeIfExists(string name) { }
}

// Namespace: System.Text.Json.Serialization
internal abstract class JsonCollectionConverter<TCollection, TElement> : JsonResumableConverter<TCollection> // TypeDefIndex: 15919
{
	// Properties
	internal sealed override ClassType ClassType { get; }
	internal override Type ElementType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	internal sealed override ClassType get_ClassType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D20B0 Offset: 0x7D12B0 VA: 0x1807D20B0
	|-JsonCollectionConverter<object, object>.get_ClassType
	|-JsonCollectionConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_ClassType
	*/

	// RVA: -1 Offset: -1 Slot: 9
	internal override Type get_ElementType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B3D00 Offset: 0x12B2F00 VA: 0x1812B3D00
	|-JsonCollectionConverter<object, object>.get_ElementType
	|
	|-RVA: 0x12B3CA0 Offset: 0x12B2EA0 VA: 0x1812B3CA0
	|-JsonCollectionConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_ElementType
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B3C60 Offset: 0x12B2E60 VA: 0x1812B3C60
	|-JsonCollectionConverter<object, object>..ctor
	|
	|-RVA: 0x12B3C80 Offset: 0x12B2E80 VA: 0x1812B3C80
	|-JsonCollectionConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization
internal abstract class JsonDictionaryConverter<T> : JsonResumableConverter<T> // TypeDefIndex: 15920
{
	// Properties
	internal sealed override ClassType ClassType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	internal sealed override ClassType get_ClassType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8101F0 Offset: 0x80F3F0 VA: 0x1808101F0
	|-JsonDictionaryConverter<Nullable<IntPtr>>.get_ClassType
	|-JsonDictionaryConverter<Nullable<UIntPtr>>.get_ClassType
	|-JsonDictionaryConverter<bool>.get_ClassType
	|-JsonDictionaryConverter<byte>.get_ClassType
	|-JsonDictionaryConverter<char>.get_ClassType
	|-JsonDictionaryConverter<DateTime>.get_ClassType
	|-JsonDictionaryConverter<DateTimeOffset>.get_ClassType
	|-JsonDictionaryConverter<Decimal>.get_ClassType
	|-JsonDictionaryConverter<double>.get_ClassType
	|-JsonDictionaryConverter<Guid>.get_ClassType
	|-JsonDictionaryConverter<short>.get_ClassType
	|-JsonDictionaryConverter<int>.get_ClassType
	|-JsonDictionaryConverter<long>.get_ClassType
	|-JsonDictionaryConverter<IntPtr>.get_ClassType
	|-JsonDictionaryConverter<JsonElement>.get_ClassType
	|-JsonDictionaryConverter<object>.get_ClassType
	|-JsonDictionaryConverter<sbyte>.get_ClassType
	|-JsonDictionaryConverter<float>.get_ClassType
	|-JsonDictionaryConverter<ushort>.get_ClassType
	|-JsonDictionaryConverter<uint>.get_ClassType
	|-JsonDictionaryConverter<ulong>.get_ClassType
	|-JsonDictionaryConverter<UIntPtr>.get_ClassType
	|-JsonDictionaryConverter<__Il2CppFullySharedGenericType>.get_ClassType
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected internal abstract bool OnWriteResume(Utf8JsonWriter writer, T dictionary, JsonSerializerOptions options, ref WriteStack state);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-JsonDictionaryConverter<__Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DB820 Offset: 0x12DAA20 VA: 0x1812DB820
	|-JsonDictionaryConverter<Nullable<IntPtr>>..ctor
	|
	|-RVA: 0x12DB6E0 Offset: 0x12DA8E0 VA: 0x1812DB6E0
	|-JsonDictionaryConverter<Nullable<UIntPtr>>..ctor
	|
	|-RVA: 0x12DB620 Offset: 0x12DA820 VA: 0x1812DB620
	|-JsonDictionaryConverter<bool>..ctor
	|
	|-RVA: 0x12DB5C0 Offset: 0x12DA7C0 VA: 0x1812DB5C0
	|-JsonDictionaryConverter<byte>..ctor
	|
	|-RVA: 0x12DB7C0 Offset: 0x12DA9C0 VA: 0x1812DB7C0
	|-JsonDictionaryConverter<char>..ctor
	|
	|-RVA: 0x12DB680 Offset: 0x12DA880 VA: 0x1812DB680
	|-JsonDictionaryConverter<DateTime>..ctor
	|
	|-RVA: 0x12DB5A0 Offset: 0x12DA7A0 VA: 0x1812DB5A0
	|-JsonDictionaryConverter<DateTimeOffset>..ctor
	|
	|-RVA: 0x12DB780 Offset: 0x12DA980 VA: 0x1812DB780
	|-JsonDictionaryConverter<Decimal>..ctor
	|
	|-RVA: 0x12DB640 Offset: 0x12DA840 VA: 0x1812DB640
	|-JsonDictionaryConverter<double>..ctor
	|
	|-RVA: 0x12DB6A0 Offset: 0x12DA8A0 VA: 0x1812DB6A0
	|-JsonDictionaryConverter<Guid>..ctor
	|
	|-RVA: 0x12DB7A0 Offset: 0x12DA9A0 VA: 0x1812DB7A0
	|-JsonDictionaryConverter<short>..ctor
	|
	|-RVA: 0x12DB660 Offset: 0x12DA860 VA: 0x1812DB660
	|-JsonDictionaryConverter<int>..ctor
	|
	|-RVA: 0x12DB600 Offset: 0x12DA800 VA: 0x1812DB600
	|-JsonDictionaryConverter<long>..ctor
	|
	|-RVA: 0x12DB760 Offset: 0x12DA960 VA: 0x1812DB760
	|-JsonDictionaryConverter<IntPtr>..ctor
	|
	|-RVA: 0x12DB6C0 Offset: 0x12DA8C0 VA: 0x1812DB6C0
	|-JsonDictionaryConverter<JsonElement>..ctor
	|
	|-RVA: 0x12DB740 Offset: 0x12DA940 VA: 0x1812DB740
	|-JsonDictionaryConverter<object>..ctor
	|
	|-RVA: 0x12DB7E0 Offset: 0x12DA9E0 VA: 0x1812DB7E0
	|-JsonDictionaryConverter<sbyte>..ctor
	|
	|-RVA: 0x12DB840 Offset: 0x12DAA40 VA: 0x1812DB840
	|-JsonDictionaryConverter<float>..ctor
	|
	|-RVA: 0x12DB5E0 Offset: 0x12DA7E0 VA: 0x1812DB5E0
	|-JsonDictionaryConverter<ushort>..ctor
	|
	|-RVA: 0x12DB800 Offset: 0x12DAA00 VA: 0x1812DB800
	|-JsonDictionaryConverter<uint>..ctor
	|
	|-RVA: 0x12DB720 Offset: 0x12DA920 VA: 0x1812DB720
	|-JsonDictionaryConverter<ulong>..ctor
	|
	|-RVA: 0x12DB700 Offset: 0x12DA900 VA: 0x1812DB700
	|-JsonDictionaryConverter<UIntPtr>..ctor
	|
	|-RVA: 0xB7B430 Offset: 0xB7A630 VA: 0x180B7B430
	|-JsonDictionaryConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization
internal abstract class JsonObjectConverter<T> : JsonResumableConverter<T> // TypeDefIndex: 15921
{
	// Properties
	internal sealed override ClassType ClassType { get; }
	internal sealed override Type ElementType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	internal sealed override ClassType get_ClassType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-JsonObjectConverter<__Il2CppFullySharedGenericType>.get_ClassType
	*/

	// RVA: -1 Offset: -1 Slot: 9
	internal sealed override Type get_ElementType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	|-JsonObjectConverter<__Il2CppFullySharedGenericType>.get_ElementType
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B430 Offset: 0xB7A630 VA: 0x180B7B430
	|-JsonObjectConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal abstract class JsonConverter // TypeDefIndex: 15922
{
	// Fields
	[CompilerGenerated]
	private bool <CanUseDirectReadOrWrite>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <CanBePolymorphic>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <IsValueType>k__BackingField; // 0x12
	[CompilerGenerated]
	private bool <IsInternalConverter>k__BackingField; // 0x13
	internal bool IsInternalConverterForNumberType; // 0x14
	[CompilerGenerated]
	private readonly bool <ConstructorIsParameterized>k__BackingField; // 0x15
	[CompilerGenerated]
	private ConstructorInfo <ConstructorInfo>k__BackingField; // 0x18

	// Properties
	internal abstract ClassType ClassType { get; }
	internal bool CanUseDirectReadOrWrite { get; set; }
	internal virtual bool CanHaveIdMetadata { get; }
	internal bool CanBePolymorphic { get; set; }
	[Nullable(2)]
	internal abstract Type ElementType { get; }
	internal bool IsValueType { get; set; }
	internal bool IsInternalConverter { get; set; }
	internal virtual Type RuntimeType { get; }
	internal abstract Type TypeToConvert { get; }
	internal virtual bool ConstructorIsParameterized { get; }
	[Nullable(2)]
	internal ConstructorInfo ConstructorInfo { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool CanConvert(Type typeToConvert);

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract ClassType get_ClassType();

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	internal bool get_CanUseDirectReadOrWrite() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void set_CanUseDirectReadOrWrite(bool value) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	internal virtual bool get_CanHaveIdMetadata() { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	internal bool get_CanBePolymorphic() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	internal void set_CanBePolymorphic(bool value) { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract JsonPropertyInfo CreateJsonPropertyInfo();

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract JsonParameterInfo CreateJsonParameterInfo();

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract Type get_ElementType();

	[CompilerGenerated]
	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10
	internal bool get_IsValueType() { }

	[CompilerGenerated]
	// RVA: 0x7D7A30 Offset: 0x7D6C30 VA: 0x1807D7A30
	internal void set_IsValueType(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7F2E20 Offset: 0x7F2020 VA: 0x1807F2E20
	internal bool get_IsInternalConverter() { }

	[CompilerGenerated]
	// RVA: 0x1B4D480 Offset: 0x1B4C680 VA: 0x181B4D480
	internal void set_IsInternalConverter(bool value) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract object ReadCoreAsObject(ref Utf8JsonReader reader, JsonSerializerOptions options, ref ReadStack state);

	// RVA: 0x7F66E0 Offset: 0x7F58E0 VA: 0x1807F66E0 Slot: 11
	internal virtual Type get_RuntimeType() { }

	// RVA: 0x1C38D20 Offset: 0x1C37F20 VA: 0x181C38D20
	internal bool ShouldFlush(Utf8JsonWriter writer, ref WriteStack state) { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Type get_TypeToConvert();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool TryReadAsObject(ref Utf8JsonReader reader, JsonSerializerOptions options, ref ReadStack state, out object value);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool TryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract bool WriteCoreAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void WriteWithQuotesAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state);

	[CompilerGenerated]
	// RVA: 0x41AC40 Offset: 0x419E40 VA: 0x18041AC40 Slot: 17
	internal virtual bool get_ConstructorIsParameterized() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal ConstructorInfo get_ConstructorInfo() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_ConstructorInfo(ConstructorInfo value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 18
	internal virtual void Initialize(JsonSerializerOptions options) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 19
	internal virtual void CreateInstanceForReferenceResolver(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }

	// RVA: 0x1C38D50 Offset: 0x1C37F50 VA: 0x181C38D50
	internal static bool SingleValueReadWithReadAhead(ClassType classType, ref Utf8JsonReader reader, ref ReadStack state) { }

	// RVA: 0x1C389F0 Offset: 0x1C37BF0 VA: 0x181C389F0
	internal static bool DoSingleValueReadWithReadAhead(ref Utf8JsonReader reader, ref ReadStack state) { }
}

// Namespace: System.Text.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal abstract class JsonConverterFactory : JsonConverter // TypeDefIndex: 15923
{
	// Properties
	internal sealed override ClassType ClassType { get; }
	[Nullable(2)]
	internal sealed override Type ElementType { get; }
	internal sealed override Type TypeToConvert { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 5
	internal sealed override ClassType get_ClassType() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options);

	// RVA: 0x1C38820 Offset: 0x1C37A20 VA: 0x181C38820 Slot: 7
	internal override JsonPropertyInfo CreateJsonPropertyInfo() { }

	// RVA: 0x1C387E0 Offset: 0x1C379E0 VA: 0x181C387E0 Slot: 8
	internal override JsonParameterInfo CreateJsonParameterInfo() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	internal sealed override Type get_ElementType() { }

	// RVA: 0x1C38860 Offset: 0x1C37A60 VA: 0x181C38860
	internal JsonConverter GetConverterInternal(Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C388B0 Offset: 0x1C37AB0 VA: 0x181C388B0 Slot: 10
	internal sealed override object ReadCoreAsObject(ref Utf8JsonReader reader, JsonSerializerOptions options, ref ReadStack state) { }

	// RVA: 0x1C388F0 Offset: 0x1C37AF0 VA: 0x181C388F0 Slot: 13
	internal sealed override bool TryReadAsObject(ref Utf8JsonReader reader, JsonSerializerOptions options, ref ReadStack state, out object value) { }

	// RVA: 0x1C38930 Offset: 0x1C37B30 VA: 0x181C38930 Slot: 14
	internal sealed override bool TryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	internal sealed override Type get_TypeToConvert() { }

	// RVA: 0x1C38970 Offset: 0x1C37B70 VA: 0x181C38970 Slot: 15
	internal sealed override bool WriteCoreAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C389B0 Offset: 0x1C37BB0 VA: 0x181C389B0 Slot: 16
	internal sealed override void WriteWithQuotesAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }
}

// Namespace: System.Text.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal abstract class JsonConverter<T> : JsonConverter // TypeDefIndex: 15924
{
	// Fields
	[CompilerGenerated]
	private bool <HandleNullOnRead>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <HandleNullOnWrite>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <CanBeNull>k__BackingField; // 0x0

	// Properties
	internal override ClassType ClassType { get; }
	[Nullable(2)]
	internal override Type ElementType { get; }
	public virtual bool HandleNull { get; }
	internal bool HandleNullOnRead { get; set; }
	internal bool HandleNullOnWrite { get; set; }
	internal bool CanBeNull { get; }
	internal sealed override Type TypeToConvert { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	internal sealed override object ReadCoreAsObject(ref Utf8JsonReader reader, JsonSerializerOptions options, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B46D0 Offset: 0x12B38D0 VA: 0x1812B46D0
	|-JsonConverter<Nullable<IntPtr>>.ReadCoreAsObject
	|
	|-RVA: 0x12B4660 Offset: 0x12B3860 VA: 0x1812B4660
	|-JsonConverter<Nullable<UIntPtr>>.ReadCoreAsObject
	|
	|-RVA: 0x12B45C0 Offset: 0x12B37C0 VA: 0x1812B45C0
	|-JsonConverter<bool>.ReadCoreAsObject
	|
	|-RVA: 0x12B4570 Offset: 0x12B3770 VA: 0x1812B4570
	|-JsonConverter<byte>.ReadCoreAsObject
	|
	|-RVA: 0x12B4610 Offset: 0x12B3810 VA: 0x1812B4610
	|-JsonConverter<char>.ReadCoreAsObject
	|
	|-RVA: 0x12B4740 Offset: 0x12B3940 VA: 0x1812B4740
	|-JsonConverter<DateTime>.ReadCoreAsObject
	|
	|-RVA: 0x12BF5D0 Offset: 0x12BE7D0 VA: 0x1812BF5D0
	|-JsonConverter<DateTimeOffset>.ReadCoreAsObject
	|
	|-RVA: 0x12BF880 Offset: 0x12BEA80 VA: 0x1812BF880
	|-JsonConverter<Decimal>.ReadCoreAsObject
	|
	|-RVA: 0x12BF700 Offset: 0x12BE900 VA: 0x1812BF700
	|-JsonConverter<double>.ReadCoreAsObject
	|
	|-RVA: 0x12BF7A0 Offset: 0x12BE9A0 VA: 0x1812BF7A0
	|-JsonConverter<Guid>.ReadCoreAsObject
	|
	|-RVA: 0x12BF990 Offset: 0x12BEB90 VA: 0x1812BF990
	|-JsonConverter<short>.ReadCoreAsObject
	|
	|-RVA: 0x12BF8F0 Offset: 0x12BEAF0 VA: 0x1812BF8F0
	|-JsonConverter<int>.ReadCoreAsObject
	|
	|-RVA: 0x12BF690 Offset: 0x12BE890 VA: 0x1812BF690
	|-JsonConverter<long>.ReadCoreAsObject
	|
	|-RVA: 0x12BF940 Offset: 0x12BEB40 VA: 0x1812BF940
	|-JsonConverter<IntPtr>.ReadCoreAsObject
	|
	|-RVA: 0x12BF810 Offset: 0x12BEA10 VA: 0x1812BF810
	|-JsonConverter<JsonElement>.ReadCoreAsObject
	|
	|-RVA: 0x12BF6E0 Offset: 0x12BE8E0 VA: 0x1812BF6E0
	|-JsonConverter<object>.ReadCoreAsObject
	|
	|-RVA: 0x12BF640 Offset: 0x12BE840 VA: 0x1812BF640
	|-JsonConverter<sbyte>.ReadCoreAsObject
	|
	|-RVA: 0x12BF750 Offset: 0x12BE950 VA: 0x1812BF750
	|-JsonConverter<float>.ReadCoreAsObject
	|
	|-RVA: 0x12D2E30 Offset: 0x12D2030 VA: 0x1812D2E30
	|-JsonConverter<ushort>.ReadCoreAsObject
	|
	|-RVA: 0x12D2DE0 Offset: 0x12D1FE0 VA: 0x1812D2DE0
	|-JsonConverter<uint>.ReadCoreAsObject
	|
	|-RVA: 0x12D2D40 Offset: 0x12D1F40 VA: 0x1812D2D40
	|-JsonConverter<ulong>.ReadCoreAsObject
	|
	|-RVA: 0x12D2D90 Offset: 0x12D1F90 VA: 0x1812D2D90
	|-JsonConverter<UIntPtr>.ReadCoreAsObject
	|
	|-RVA: 0x12D2E80 Offset: 0x12D2080 VA: 0x1812D2E80
	|-JsonConverter<__Il2CppFullySharedGenericType>.ReadCoreAsObject
	*/

	// RVA: -1 Offset: -1
	internal T ReadCore(ref Utf8JsonReader reader, JsonSerializerOptions options, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B5220 Offset: 0x12B4420 VA: 0x1812B5220
	|-JsonConverter<Nullable<IntPtr>>.ReadCore
	|
	|-RVA: 0x12B6220 Offset: 0x12B5420 VA: 0x1812B6220
	|-JsonConverter<Nullable<UIntPtr>>.ReadCore
	|
	|-RVA: 0x12B57A0 Offset: 0x12B49A0 VA: 0x1812B57A0
	|-JsonConverter<bool>.ReadCore
	|
	|-RVA: 0x12B4790 Offset: 0x12B3990 VA: 0x1812B4790
	|-JsonConverter<byte>.ReadCore
	|
	|-RVA: 0x12B4CD0 Offset: 0x12B3ED0 VA: 0x1812B4CD0
	|-JsonConverter<char>.ReadCore
	|
	|-RVA: 0x12B5CE0 Offset: 0x12B4EE0 VA: 0x1812B5CE0
	|-JsonConverter<DateTime>.ReadCore
	|
	|-RVA: 0x12C2A70 Offset: 0x12C1C70 VA: 0x1812C2A70
	|-JsonConverter<DateTimeOffset>.ReadCore
	|
	|-RVA: 0x12C24C0 Offset: 0x12C16C0 VA: 0x1812C24C0
	|-JsonConverter<Decimal>.ReadCore
	|
	|-RVA: 0x12C1A20 Offset: 0x12C0C20 VA: 0x1812C1A20
	|-JsonConverter<double>.ReadCore
	|
	|-RVA: 0x12C0A10 Offset: 0x12BFC10 VA: 0x1812C0A10
	|-JsonConverter<Guid>.ReadCore
	|
	|-RVA: 0x12C3570 Offset: 0x12C2770 VA: 0x1812C3570
	|-JsonConverter<short>.ReadCore
	|
	|-RVA: 0x12C1F70 Offset: 0x12C1170 VA: 0x1812C1F70
	|-JsonConverter<int>.ReadCore
	|
	|-RVA: 0x12C0FC0 Offset: 0x12C01C0 VA: 0x1812C0FC0
	|-JsonConverter<long>.ReadCore
	|
	|-RVA: 0x12BFF20 Offset: 0x12BF120 VA: 0x1812BFF20
	|-JsonConverter<IntPtr>.ReadCore
	|
	|-RVA: 0x12C0460 Offset: 0x12BF660 VA: 0x1812C0460
	|-JsonConverter<JsonElement>.ReadCore
	|
	|-RVA: 0x12C1500 Offset: 0x12C0700 VA: 0x1812C1500
	|-JsonConverter<object>.ReadCore
	|
	|-RVA: 0x12BF9E0 Offset: 0x12BEBE0 VA: 0x1812BF9E0
	|-JsonConverter<sbyte>.ReadCore
	|
	|-RVA: 0x12C3020 Offset: 0x12C2220 VA: 0x1812C3020
	|-JsonConverter<float>.ReadCore
	|
	|-RVA: 0x12D4160 Offset: 0x12D3360 VA: 0x1812D4160
	|-JsonConverter<ushort>.ReadCore
	|
	|-RVA: 0x12D3C10 Offset: 0x12D2E10 VA: 0x1812D3C10
	|-JsonConverter<uint>.ReadCore
	|
	|-RVA: 0x12D2F40 Offset: 0x12D2140 VA: 0x1812D2F40
	|-JsonConverter<ulong>.ReadCore
	|
	|-RVA: 0x12D46B0 Offset: 0x12D38B0 VA: 0x1812D46B0
	|-JsonConverter<UIntPtr>.ReadCore
	|
	|-RVA: 0x12D3480 Offset: 0x12D2680 VA: 0x1812D3480
	|-JsonConverter<__Il2CppFullySharedGenericType>.ReadCore
	*/

	// RVA: -1 Offset: -1 Slot: 15
	internal sealed override bool WriteCoreAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BC590 Offset: 0x12BB790 VA: 0x1812BC590
	|-JsonConverter<Nullable<IntPtr>>.WriteCoreAsObject
	|
	|-RVA: 0x12BC170 Offset: 0x12BB370 VA: 0x1812BC170
	|-JsonConverter<Nullable<UIntPtr>>.WriteCoreAsObject
	|
	|-RVA: 0x12BC440 Offset: 0x12BB640 VA: 0x1812BC440
	|-JsonConverter<bool>.WriteCoreAsObject
	|
	|-RVA: 0x12BC020 Offset: 0x12BB220 VA: 0x1812BC020
	|-JsonConverter<byte>.WriteCoreAsObject
	|
	|-RVA: 0x12BC2F0 Offset: 0x12BB4F0 VA: 0x1812BC2F0
	|-JsonConverter<char>.WriteCoreAsObject
	|
	|-RVA: 0x12BBED0 Offset: 0x12BB0D0 VA: 0x1812BBED0
	|-JsonConverter<DateTime>.WriteCoreAsObject
	|
	|-RVA: 0x12CDF20 Offset: 0x12CD120 VA: 0x1812CDF20
	|-JsonConverter<DateTimeOffset>.WriteCoreAsObject
	|
	|-RVA: 0x12CE730 Offset: 0x12CD930 VA: 0x1812CE730
	|-JsonConverter<Decimal>.WriteCoreAsObject
	|
	|-RVA: 0x12CE080 Offset: 0x12CD280 VA: 0x1812CE080
	|-JsonConverter<double>.WriteCoreAsObject
	|
	|-RVA: 0x12CE9F0 Offset: 0x12CDBF0 VA: 0x1812CE9F0
	|-JsonConverter<Guid>.WriteCoreAsObject
	|
	|-RVA: 0x12CE490 Offset: 0x12CD690 VA: 0x1812CE490
	|-JsonConverter<short>.WriteCoreAsObject
	|
	|-RVA: 0x12CE340 Offset: 0x12CD540 VA: 0x1812CE340
	|-JsonConverter<int>.WriteCoreAsObject
	|
	|-RVA: 0x12CDB20 Offset: 0x12CCD20 VA: 0x1812CDB20
	|-JsonConverter<long>.WriteCoreAsObject
	|
	|-RVA: 0x12CE5E0 Offset: 0x12CD7E0 VA: 0x1812CE5E0
	|-JsonConverter<IntPtr>.WriteCoreAsObject
	|
	|-RVA: 0x12CDC70 Offset: 0x12CCE70 VA: 0x1812CDC70
	|-JsonConverter<JsonElement>.WriteCoreAsObject
	|
	|-RVA: 0x12CE890 Offset: 0x12CDA90 VA: 0x1812CE890
	|-JsonConverter<object>.WriteCoreAsObject
	|
	|-RVA: 0x12CDDD0 Offset: 0x12CCFD0 VA: 0x1812CDDD0
	|-JsonConverter<sbyte>.WriteCoreAsObject
	|
	|-RVA: 0x12CE1E0 Offset: 0x12CD3E0 VA: 0x1812CE1E0
	|-JsonConverter<float>.WriteCoreAsObject
	|
	|-RVA: 0x12D95D0 Offset: 0x12D87D0 VA: 0x1812D95D0
	|-JsonConverter<ushort>.WriteCoreAsObject
	|
	|-RVA: 0x12D9A40 Offset: 0x12D8C40 VA: 0x1812D9A40
	|-JsonConverter<uint>.WriteCoreAsObject
	|
	|-RVA: 0x12D9B90 Offset: 0x12D8D90 VA: 0x1812D9B90
	|-JsonConverter<ulong>.WriteCoreAsObject
	|
	|-RVA: 0x12D9720 Offset: 0x12D8920 VA: 0x1812D9720
	|-JsonConverter<UIntPtr>.WriteCoreAsObject
	|
	|-RVA: 0x12D9870 Offset: 0x12D8A70 VA: 0x1812D9870
	|-JsonConverter<__Il2CppFullySharedGenericType>.WriteCoreAsObject
	*/

	// RVA: -1 Offset: -1
	internal bool WriteCore(Utf8JsonWriter writer, in T value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BC910 Offset: 0x12BBB10 VA: 0x1812BC910
	|-JsonConverter<Nullable<IntPtr>>.WriteCore
	|
	|-RVA: 0x12BCD10 Offset: 0x12BBF10 VA: 0x1812BCD10
	|-JsonConverter<Nullable<UIntPtr>>.WriteCore
	|
	|-RVA: 0x12BC710 Offset: 0x12BB910 VA: 0x1812BC710
	|-JsonConverter<bool>.WriteCore
	|
	|-RVA: 0x12BD110 Offset: 0x12BC310 VA: 0x1812BD110
	|-JsonConverter<byte>.WriteCore
	|
	|-RVA: 0x12BCF10 Offset: 0x12BC110 VA: 0x1812BCF10
	|-JsonConverter<char>.WriteCore
	|
	|-RVA: 0x12BCB10 Offset: 0x12BBD10 VA: 0x1812BCB10
	|-JsonConverter<DateTime>.WriteCore
	|
	|-RVA: 0x12CF950 Offset: 0x12CEB50 VA: 0x1812CF950
	|-JsonConverter<DateTimeOffset>.WriteCore
	|
	|-RVA: 0x12CF150 Offset: 0x12CE350 VA: 0x1812CF150
	|-JsonConverter<Decimal>.WriteCore
	|
	|-RVA: 0x12CEF50 Offset: 0x12CE150 VA: 0x1812CEF50
	|-JsonConverter<double>.WriteCore
	|
	|-RVA: 0x12CFB50 Offset: 0x12CED50 VA: 0x1812CFB50
	|-JsonConverter<Guid>.WriteCore
	|
	|-RVA: 0x12CF750 Offset: 0x12CE950 VA: 0x1812CF750
	|-JsonConverter<short>.WriteCore
	|
	|-RVA: 0x12CFD50 Offset: 0x12CEF50 VA: 0x1812CFD50
	|-JsonConverter<int>.WriteCore
	|
	|-RVA: 0x12CF550 Offset: 0x12CE750 VA: 0x1812CF550
	|-JsonConverter<long>.WriteCore
	|
	|-RVA: 0x12CED50 Offset: 0x12CDF50 VA: 0x1812CED50
	|-JsonConverter<IntPtr>.WriteCore
	|
	|-RVA: 0x12CF350 Offset: 0x12CE550 VA: 0x1812CF350
	|-JsonConverter<JsonElement>.WriteCore
	|
	|-RVA: 0x12CEB50 Offset: 0x12CDD50 VA: 0x1812CEB50
	|-JsonConverter<object>.WriteCore
	|
	|-RVA: 0x12D0150 Offset: 0x12CF350 VA: 0x1812D0150
	|-JsonConverter<sbyte>.WriteCore
	|
	|-RVA: 0x12CFF50 Offset: 0x12CF150 VA: 0x1812CFF50
	|-JsonConverter<float>.WriteCore
	|
	|-RVA: 0x12DA2E0 Offset: 0x12D94E0 VA: 0x1812DA2E0
	|-JsonConverter<ushort>.WriteCore
	|
	|-RVA: 0x12D9EE0 Offset: 0x12D90E0 VA: 0x1812D9EE0
	|-JsonConverter<uint>.WriteCore
	|
	|-RVA: 0x12DA0E0 Offset: 0x12D92E0 VA: 0x1812DA0E0
	|-JsonConverter<ulong>.WriteCore
	|
	|-RVA: 0x12D9CE0 Offset: 0x12D8EE0 VA: 0x1812D9CE0
	|-JsonConverter<UIntPtr>.WriteCore
	|
	|-RVA: 0x12DA4E0 Offset: 0x12D96E0 VA: 0x1812DA4E0
	|-JsonConverter<__Il2CppFullySharedGenericType>.WriteCore
	*/

	// RVA: -1 Offset: -1
	protected internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BDF30 Offset: 0x12BD130 VA: 0x1812BDF30
	|-JsonConverter<Nullable<IntPtr>>..ctor
	|
	|-RVA: 0x12BE5F0 Offset: 0x12BD7F0 VA: 0x1812BE5F0
	|-JsonConverter<Nullable<UIntPtr>>..ctor
	|
	|-RVA: 0x12BDCF0 Offset: 0x12BCEF0 VA: 0x1812BDCF0
	|-JsonConverter<bool>..ctor
	|
	|-RVA: 0x12BE170 Offset: 0x12BD370 VA: 0x1812BE170
	|-JsonConverter<byte>..ctor
	|
	|-RVA: 0x12BE3B0 Offset: 0x12BD5B0 VA: 0x1812BE3B0
	|-JsonConverter<char>..ctor
	|
	|-RVA: 0x12BDAB0 Offset: 0x12BCCB0 VA: 0x1812BDAB0
	|-JsonConverter<DateTime>..ctor
	|
	|-RVA: 0x12D06E0 Offset: 0x12CF8E0 VA: 0x1812D06E0
	|-JsonConverter<DateTimeOffset>..ctor
	|
	|-RVA: 0x12D1FA0 Offset: 0x12D11A0 VA: 0x1812D1FA0
	|-JsonConverter<Decimal>..ctor
	|
	|-RVA: 0x12D1B20 Offset: 0x12D0D20 VA: 0x1812D1B20
	|-JsonConverter<double>..ctor
	|
	|-RVA: 0x12D1220 Offset: 0x12D0420 VA: 0x1812D1220
	|-JsonConverter<Guid>..ctor
	|
	|-RVA: 0x12D0DA0 Offset: 0x12CFFA0 VA: 0x1812D0DA0
	|-JsonConverter<short>..ctor
	|
	|-RVA: 0x12D1460 Offset: 0x12D0660 VA: 0x1812D1460
	|-JsonConverter<int>..ctor
	|
	|-RVA: 0x12D0920 Offset: 0x12CFB20 VA: 0x1812D0920
	|-JsonConverter<long>..ctor
	|
	|-RVA: 0x12D18E0 Offset: 0x12D0AE0 VA: 0x1812D18E0
	|-JsonConverter<IntPtr>..ctor
	|
	|-RVA: 0x12D0FE0 Offset: 0x12D01E0 VA: 0x1812D0FE0
	|-JsonConverter<JsonElement>..ctor
	|
	|-RVA: 0x12D16A0 Offset: 0x12D08A0 VA: 0x1812D16A0
	|-JsonConverter<object>..ctor
	|
	|-RVA: 0x12D1D60 Offset: 0x12D0F60 VA: 0x1812D1D60
	|-JsonConverter<sbyte>..ctor
	|
	|-RVA: 0x12D0B60 Offset: 0x12CFD60 VA: 0x1812D0B60
	|-JsonConverter<float>..ctor
	|
	|-RVA: 0x12DB110 Offset: 0x12DA310 VA: 0x1812DB110
	|-JsonConverter<ushort>..ctor
	|
	|-RVA: 0x12DAED0 Offset: 0x12DA0D0 VA: 0x1812DAED0
	|-JsonConverter<uint>..ctor
	|
	|-RVA: 0x12DA7F0 Offset: 0x12D99F0 VA: 0x1812DA7F0
	|-JsonConverter<ulong>..ctor
	|
	|-RVA: 0x12DAA30 Offset: 0x12D9C30 VA: 0x1812DAA30
	|-JsonConverter<UIntPtr>..ctor
	|
	|-RVA: 0x12DAC70 Offset: 0x12D9E70 VA: 0x1812DAC70
	|-JsonConverter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override bool CanConvert(Type typeToConvert) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B3EF0 Offset: 0x12B30F0 VA: 0x1812B3EF0
	|-JsonConverter<Nullable<IntPtr>>.CanConvert
	|
	|-RVA: 0x12B3DF0 Offset: 0x12B2FF0 VA: 0x1812B3DF0
	|-JsonConverter<Nullable<UIntPtr>>.CanConvert
	|
	|-RVA: 0x12B3E70 Offset: 0x12B3070 VA: 0x1812B3E70
	|-JsonConverter<bool>.CanConvert
	|
	|-RVA: 0x12B4080 Offset: 0x12B3280 VA: 0x1812B4080
	|-JsonConverter<byte>.CanConvert
	|
	|-RVA: 0x12B4100 Offset: 0x12B3300 VA: 0x1812B4100
	|-JsonConverter<char>.CanConvert
	|
	|-RVA: 0x12B4000 Offset: 0x12B3200 VA: 0x1812B4000
	|-JsonConverter<DateTime>.CanConvert
	|
	|-RVA: 0x12BEB90 Offset: 0x12BDD90 VA: 0x1812BEB90
	|-JsonConverter<DateTimeOffset>.CanConvert
	|
	|-RVA: 0x12BF010 Offset: 0x12BE210 VA: 0x1812BF010
	|-JsonConverter<Decimal>.CanConvert
	|
	|-RVA: 0x12BEC90 Offset: 0x12BDE90 VA: 0x1812BEC90
	|-JsonConverter<double>.CanConvert
	|
	|-RVA: 0x12BED90 Offset: 0x12BDF90 VA: 0x1812BED90
	|-JsonConverter<Guid>.CanConvert
	|
	|-RVA: 0x12BED10 Offset: 0x12BDF10 VA: 0x1812BED10
	|-JsonConverter<short>.CanConvert
	|
	|-RVA: 0x12BEB10 Offset: 0x12BDD10 VA: 0x1812BEB10
	|-JsonConverter<int>.CanConvert
	|
	|-RVA: 0x12BEE90 Offset: 0x12BE090 VA: 0x1812BEE90
	|-JsonConverter<long>.CanConvert
	|
	|-RVA: 0x12BEE10 Offset: 0x12BE010 VA: 0x1812BEE10
	|-JsonConverter<IntPtr>.CanConvert
	|
	|-RVA: 0x12BEC10 Offset: 0x12BDE10 VA: 0x1812BEC10
	|-JsonConverter<JsonElement>.CanConvert
	|
	|-RVA: 0x12BEA90 Offset: 0x12BDC90 VA: 0x1812BEA90
	|-JsonConverter<object>.CanConvert
	|
	|-RVA: 0x12BEF10 Offset: 0x12BE110 VA: 0x1812BEF10
	|-JsonConverter<sbyte>.CanConvert
	|
	|-RVA: 0x12BEF90 Offset: 0x12BE190 VA: 0x1812BEF90
	|-JsonConverter<float>.CanConvert
	|
	|-RVA: 0x12D27E0 Offset: 0x12D19E0 VA: 0x1812D27E0
	|-JsonConverter<ushort>.CanConvert
	|
	|-RVA: 0x12D2760 Offset: 0x12D1960 VA: 0x1812D2760
	|-JsonConverter<uint>.CanConvert
	|
	|-RVA: 0x12D2660 Offset: 0x12D1860 VA: 0x1812D2660
	|-JsonConverter<ulong>.CanConvert
	|
	|-RVA: 0x12D26E0 Offset: 0x12D18E0 VA: 0x1812D26E0
	|-JsonConverter<UIntPtr>.CanConvert
	|
	|-RVA: 0x12D2860 Offset: 0x12D1A60 VA: 0x1812D2860
	|-JsonConverter<__Il2CppFullySharedGenericType>.CanConvert
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override ClassType get_ClassType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D6670 Offset: 0x7D5870 VA: 0x1807D6670
	|-JsonConverter<Nullable<IntPtr>>.get_ClassType
	|-JsonConverter<Nullable<UIntPtr>>.get_ClassType
	|-JsonConverter<bool>.get_ClassType
	|-JsonConverter<byte>.get_ClassType
	|-JsonConverter<char>.get_ClassType
	|-JsonConverter<DateTime>.get_ClassType
	|-JsonConverter<DateTimeOffset>.get_ClassType
	|-JsonConverter<Decimal>.get_ClassType
	|-JsonConverter<double>.get_ClassType
	|-JsonConverter<Guid>.get_ClassType
	|-JsonConverter<short>.get_ClassType
	|-JsonConverter<int>.get_ClassType
	|-JsonConverter<long>.get_ClassType
	|-JsonConverter<IntPtr>.get_ClassType
	|-JsonConverter<JsonElement>.get_ClassType
	|-JsonConverter<object>.get_ClassType
	|-JsonConverter<sbyte>.get_ClassType
	|-JsonConverter<float>.get_ClassType
	|-JsonConverter<ushort>.get_ClassType
	|-JsonConverter<uint>.get_ClassType
	|-JsonConverter<ulong>.get_ClassType
	|-JsonConverter<UIntPtr>.get_ClassType
	|-JsonConverter<__Il2CppFullySharedGenericType>.get_ClassType
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal sealed override JsonPropertyInfo CreateJsonPropertyInfo() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B4300 Offset: 0x12B3500 VA: 0x1812B4300
	|-JsonConverter<Nullable<IntPtr>>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12B41E0 Offset: 0x12B33E0 VA: 0x1812B41E0
	|-JsonConverter<Nullable<UIntPtr>>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12B43C0 Offset: 0x12B35C0 VA: 0x1812B43C0
	|-JsonConverter<bool>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12B4240 Offset: 0x12B3440 VA: 0x1812B4240
	|-JsonConverter<byte>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12B42A0 Offset: 0x12B34A0 VA: 0x1812B42A0
	|-JsonConverter<char>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12B4360 Offset: 0x12B3560 VA: 0x1812B4360
	|-JsonConverter<DateTime>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF270 Offset: 0x12BE470 VA: 0x1812BF270
	|-JsonConverter<DateTimeOffset>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF4B0 Offset: 0x12BE6B0 VA: 0x1812BF4B0
	|-JsonConverter<Decimal>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF210 Offset: 0x12BE410 VA: 0x1812BF210
	|-JsonConverter<double>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF390 Offset: 0x12BE590 VA: 0x1812BF390
	|-JsonConverter<Guid>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF2D0 Offset: 0x12BE4D0 VA: 0x1812BF2D0
	|-JsonConverter<short>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF0F0 Offset: 0x12BE2F0 VA: 0x1812BF0F0
	|-JsonConverter<int>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF090 Offset: 0x12BE290 VA: 0x1812BF090
	|-JsonConverter<long>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF150 Offset: 0x12BE350 VA: 0x1812BF150
	|-JsonConverter<IntPtr>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF1B0 Offset: 0x12BE3B0 VA: 0x1812BF1B0
	|-JsonConverter<JsonElement>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF3F0 Offset: 0x12BE5F0 VA: 0x1812BF3F0
	|-JsonConverter<object>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF450 Offset: 0x12BE650 VA: 0x1812BF450
	|-JsonConverter<sbyte>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12BF330 Offset: 0x12BE530 VA: 0x1812BF330
	|-JsonConverter<float>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12D2990 Offset: 0x12D1B90 VA: 0x1812D2990
	|-JsonConverter<ushort>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12D2AB0 Offset: 0x12D1CB0 VA: 0x1812D2AB0
	|-JsonConverter<uint>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12D29F0 Offset: 0x12D1BF0 VA: 0x1812D29F0
	|-JsonConverter<ulong>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12D2A50 Offset: 0x12D1C50 VA: 0x1812D2A50
	|-JsonConverter<UIntPtr>.CreateJsonPropertyInfo
	|
	|-RVA: 0x12D2B10 Offset: 0x12D1D10 VA: 0x1812D2B10
	|-JsonConverter<__Il2CppFullySharedGenericType>.CreateJsonPropertyInfo
	*/

	// RVA: -1 Offset: -1 Slot: 8
	internal sealed override JsonParameterInfo CreateJsonParameterInfo() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B4180 Offset: 0x12B3380 VA: 0x1812B4180
	|-JsonConverter<Nullable<IntPtr>>.CreateJsonParameterInfo
	|-JsonConverter<Nullable<UIntPtr>>.CreateJsonParameterInfo
	|-JsonConverter<bool>.CreateJsonParameterInfo
	|-JsonConverter<byte>.CreateJsonParameterInfo
	|-JsonConverter<char>.CreateJsonParameterInfo
	|-JsonConverter<DateTime>.CreateJsonParameterInfo
	|-JsonConverter<DateTimeOffset>.CreateJsonParameterInfo
	|-JsonConverter<Decimal>.CreateJsonParameterInfo
	|-JsonConverter<double>.CreateJsonParameterInfo
	|-JsonConverter<Guid>.CreateJsonParameterInfo
	|-JsonConverter<short>.CreateJsonParameterInfo
	|-JsonConverter<int>.CreateJsonParameterInfo
	|-JsonConverter<long>.CreateJsonParameterInfo
	|-JsonConverter<IntPtr>.CreateJsonParameterInfo
	|-JsonConverter<JsonElement>.CreateJsonParameterInfo
	|-JsonConverter<object>.CreateJsonParameterInfo
	|-JsonConverter<sbyte>.CreateJsonParameterInfo
	|-JsonConverter<float>.CreateJsonParameterInfo
	|
	|-RVA: 0x12D28E0 Offset: 0x12D1AE0 VA: 0x1812D28E0
	|-JsonConverter<ushort>.CreateJsonParameterInfo
	|-JsonConverter<uint>.CreateJsonParameterInfo
	|-JsonConverter<ulong>.CreateJsonParameterInfo
	|-JsonConverter<UIntPtr>.CreateJsonParameterInfo
	|
	|-RVA: 0x12D2930 Offset: 0x12D1B30 VA: 0x1812D2930
	|-JsonConverter<__Il2CppFullySharedGenericType>.CreateJsonParameterInfo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	internal override Type get_ElementType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	|-JsonConverter<Nullable<IntPtr>>.get_ElementType
	|-JsonConverter<Nullable<UIntPtr>>.get_ElementType
	|-JsonConverter<bool>.get_ElementType
	|-JsonConverter<byte>.get_ElementType
	|-JsonConverter<char>.get_ElementType
	|-JsonConverter<DateTime>.get_ElementType
	|-JsonConverter<DateTimeOffset>.get_ElementType
	|-JsonConverter<Decimal>.get_ElementType
	|-JsonConverter<double>.get_ElementType
	|-JsonConverter<Guid>.get_ElementType
	|-JsonConverter<short>.get_ElementType
	|-JsonConverter<int>.get_ElementType
	|-JsonConverter<long>.get_ElementType
	|-JsonConverter<IntPtr>.get_ElementType
	|-JsonConverter<JsonElement>.get_ElementType
	|-JsonConverter<object>.get_ElementType
	|-JsonConverter<sbyte>.get_ElementType
	|-JsonConverter<float>.get_ElementType
	|-JsonConverter<ushort>.get_ElementType
	|-JsonConverter<uint>.get_ElementType
	|-JsonConverter<ulong>.get_ElementType
	|-JsonConverter<UIntPtr>.get_ElementType
	|-JsonConverter<__Il2CppFullySharedGenericType>.get_ElementType
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public virtual bool get_HandleNull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BE830 Offset: 0x12BDA30 VA: 0x1812BE830
	|-JsonConverter<Nullable<IntPtr>>.get_HandleNull
	|-JsonConverter<Nullable<UIntPtr>>.get_HandleNull
	|-JsonConverter<bool>.get_HandleNull
	|-JsonConverter<byte>.get_HandleNull
	|-JsonConverter<char>.get_HandleNull
	|-JsonConverter<DateTime>.get_HandleNull
	|-JsonConverter<DateTimeOffset>.get_HandleNull
	|-JsonConverter<Decimal>.get_HandleNull
	|-JsonConverter<double>.get_HandleNull
	|-JsonConverter<Guid>.get_HandleNull
	|-JsonConverter<short>.get_HandleNull
	|-JsonConverter<int>.get_HandleNull
	|-JsonConverter<long>.get_HandleNull
	|-JsonConverter<IntPtr>.get_HandleNull
	|-JsonConverter<JsonElement>.get_HandleNull
	|-JsonConverter<object>.get_HandleNull
	|-JsonConverter<sbyte>.get_HandleNull
	|-JsonConverter<float>.get_HandleNull
	|-JsonConverter<ushort>.get_HandleNull
	|-JsonConverter<uint>.get_HandleNull
	|-JsonConverter<ulong>.get_HandleNull
	|-JsonConverter<UIntPtr>.get_HandleNull
	|
	|-RVA: 0x12DB350 Offset: 0x12DA550 VA: 0x1812DB350
	|-JsonConverter<__Il2CppFullySharedGenericType>.get_HandleNull
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal bool get_HandleNullOnRead() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	|-JsonConverter<Nullable<IntPtr>>.get_HandleNullOnRead
	|-JsonConverter<Nullable<UIntPtr>>.get_HandleNullOnRead
	|-JsonConverter<bool>.get_HandleNullOnRead
	|-JsonConverter<byte>.get_HandleNullOnRead
	|-JsonConverter<char>.get_HandleNullOnRead
	|-JsonConverter<DateTime>.get_HandleNullOnRead
	|-JsonConverter<DateTimeOffset>.get_HandleNullOnRead
	|-JsonConverter<Decimal>.get_HandleNullOnRead
	|-JsonConverter<double>.get_HandleNullOnRead
	|-JsonConverter<Guid>.get_HandleNullOnRead
	|-JsonConverter<short>.get_HandleNullOnRead
	|-JsonConverter<int>.get_HandleNullOnRead
	|-JsonConverter<long>.get_HandleNullOnRead
	|-JsonConverter<IntPtr>.get_HandleNullOnRead
	|-JsonConverter<JsonElement>.get_HandleNullOnRead
	|-JsonConverter<object>.get_HandleNullOnRead
	|-JsonConverter<sbyte>.get_HandleNullOnRead
	|-JsonConverter<float>.get_HandleNullOnRead
	|-JsonConverter<ushort>.get_HandleNullOnRead
	|-JsonConverter<uint>.get_HandleNullOnRead
	|-JsonConverter<ulong>.get_HandleNullOnRead
	|-JsonConverter<UIntPtr>.get_HandleNullOnRead
	|-JsonConverter<__Il2CppFullySharedGenericType>.get_HandleNullOnRead
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_HandleNullOnRead(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	|-JsonConverter<Nullable<IntPtr>>.set_HandleNullOnRead
	|-JsonConverter<Nullable<UIntPtr>>.set_HandleNullOnRead
	|-JsonConverter<bool>.set_HandleNullOnRead
	|-JsonConverter<byte>.set_HandleNullOnRead
	|-JsonConverter<char>.set_HandleNullOnRead
	|-JsonConverter<DateTime>.set_HandleNullOnRead
	|-JsonConverter<DateTimeOffset>.set_HandleNullOnRead
	|-JsonConverter<Decimal>.set_HandleNullOnRead
	|-JsonConverter<double>.set_HandleNullOnRead
	|-JsonConverter<Guid>.set_HandleNullOnRead
	|-JsonConverter<short>.set_HandleNullOnRead
	|-JsonConverter<int>.set_HandleNullOnRead
	|-JsonConverter<long>.set_HandleNullOnRead
	|-JsonConverter<IntPtr>.set_HandleNullOnRead
	|-JsonConverter<JsonElement>.set_HandleNullOnRead
	|-JsonConverter<object>.set_HandleNullOnRead
	|-JsonConverter<sbyte>.set_HandleNullOnRead
	|-JsonConverter<float>.set_HandleNullOnRead
	|-JsonConverter<ushort>.set_HandleNullOnRead
	|-JsonConverter<uint>.set_HandleNullOnRead
	|-JsonConverter<ulong>.set_HandleNullOnRead
	|-JsonConverter<UIntPtr>.set_HandleNullOnRead
	|-JsonConverter<__Il2CppFullySharedGenericType>.set_HandleNullOnRead
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal bool get_HandleNullOnWrite() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	|-JsonConverter<Nullable<IntPtr>>.get_HandleNullOnWrite
	|-JsonConverter<Nullable<UIntPtr>>.get_HandleNullOnWrite
	|-JsonConverter<bool>.get_HandleNullOnWrite
	|-JsonConverter<byte>.get_HandleNullOnWrite
	|-JsonConverter<char>.get_HandleNullOnWrite
	|-JsonConverter<DateTime>.get_HandleNullOnWrite
	|-JsonConverter<DateTimeOffset>.get_HandleNullOnWrite
	|-JsonConverter<Decimal>.get_HandleNullOnWrite
	|-JsonConverter<double>.get_HandleNullOnWrite
	|-JsonConverter<Guid>.get_HandleNullOnWrite
	|-JsonConverter<short>.get_HandleNullOnWrite
	|-JsonConverter<int>.get_HandleNullOnWrite
	|-JsonConverter<long>.get_HandleNullOnWrite
	|-JsonConverter<IntPtr>.get_HandleNullOnWrite
	|-JsonConverter<JsonElement>.get_HandleNullOnWrite
	|-JsonConverter<object>.get_HandleNullOnWrite
	|-JsonConverter<sbyte>.get_HandleNullOnWrite
	|-JsonConverter<float>.get_HandleNullOnWrite
	|-JsonConverter<ushort>.get_HandleNullOnWrite
	|-JsonConverter<uint>.get_HandleNullOnWrite
	|-JsonConverter<ulong>.get_HandleNullOnWrite
	|-JsonConverter<UIntPtr>.get_HandleNullOnWrite
	|-JsonConverter<__Il2CppFullySharedGenericType>.get_HandleNullOnWrite
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_HandleNullOnWrite(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BD770 Offset: 0x4BC970 VA: 0x1804BD770
	|-JsonConverter<Nullable<IntPtr>>.set_HandleNullOnWrite
	|-JsonConverter<Nullable<UIntPtr>>.set_HandleNullOnWrite
	|-JsonConverter<bool>.set_HandleNullOnWrite
	|-JsonConverter<byte>.set_HandleNullOnWrite
	|-JsonConverter<char>.set_HandleNullOnWrite
	|-JsonConverter<DateTime>.set_HandleNullOnWrite
	|-JsonConverter<DateTimeOffset>.set_HandleNullOnWrite
	|-JsonConverter<Decimal>.set_HandleNullOnWrite
	|-JsonConverter<double>.set_HandleNullOnWrite
	|-JsonConverter<Guid>.set_HandleNullOnWrite
	|-JsonConverter<short>.set_HandleNullOnWrite
	|-JsonConverter<int>.set_HandleNullOnWrite
	|-JsonConverter<long>.set_HandleNullOnWrite
	|-JsonConverter<IntPtr>.set_HandleNullOnWrite
	|-JsonConverter<JsonElement>.set_HandleNullOnWrite
	|-JsonConverter<object>.set_HandleNullOnWrite
	|-JsonConverter<sbyte>.set_HandleNullOnWrite
	|-JsonConverter<float>.set_HandleNullOnWrite
	|-JsonConverter<ushort>.set_HandleNullOnWrite
	|-JsonConverter<uint>.set_HandleNullOnWrite
	|-JsonConverter<ulong>.set_HandleNullOnWrite
	|-JsonConverter<UIntPtr>.set_HandleNullOnWrite
	|-JsonConverter<__Il2CppFullySharedGenericType>.set_HandleNullOnWrite
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal bool get_CanBeNull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x742460 Offset: 0x741660 VA: 0x180742460
	|-JsonConverter<Nullable<IntPtr>>.get_CanBeNull
	|-JsonConverter<Nullable<UIntPtr>>.get_CanBeNull
	|-JsonConverter<bool>.get_CanBeNull
	|-JsonConverter<byte>.get_CanBeNull
	|-JsonConverter<char>.get_CanBeNull
	|-JsonConverter<DateTime>.get_CanBeNull
	|-JsonConverter<DateTimeOffset>.get_CanBeNull
	|-JsonConverter<Decimal>.get_CanBeNull
	|-JsonConverter<double>.get_CanBeNull
	|-JsonConverter<Guid>.get_CanBeNull
	|-JsonConverter<short>.get_CanBeNull
	|-JsonConverter<int>.get_CanBeNull
	|-JsonConverter<long>.get_CanBeNull
	|-JsonConverter<IntPtr>.get_CanBeNull
	|-JsonConverter<JsonElement>.get_CanBeNull
	|-JsonConverter<object>.get_CanBeNull
	|-JsonConverter<sbyte>.get_CanBeNull
	|-JsonConverter<float>.get_CanBeNull
	|-JsonConverter<ushort>.get_CanBeNull
	|-JsonConverter<uint>.get_CanBeNull
	|-JsonConverter<ulong>.get_CanBeNull
	|-JsonConverter<UIntPtr>.get_CanBeNull
	|-JsonConverter<__Il2CppFullySharedGenericType>.get_CanBeNull
	*/

	// RVA: -1 Offset: -1 Slot: 14
	internal sealed override bool TryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B9960 Offset: 0x12B8B60 VA: 0x1812B9960
	|-JsonConverter<Nullable<IntPtr>>.TryWriteAsObject
	|
	|-RVA: 0x12B9610 Offset: 0x12B8810 VA: 0x1812B9610
	|-JsonConverter<Nullable<UIntPtr>>.TryWriteAsObject
	|
	|-RVA: 0x12B9A40 Offset: 0x12B8C40 VA: 0x1812B9A40
	|-JsonConverter<bool>.TryWriteAsObject
	|
	|-RVA: 0x12B96F0 Offset: 0x12B88F0 VA: 0x1812B96F0
	|-JsonConverter<byte>.TryWriteAsObject
	|
	|-RVA: 0x12B9890 Offset: 0x12B8A90 VA: 0x1812B9890
	|-JsonConverter<char>.TryWriteAsObject
	|
	|-RVA: 0x12B97C0 Offset: 0x12B89C0 VA: 0x1812B97C0
	|-JsonConverter<DateTime>.TryWriteAsObject
	|
	|-RVA: 0x12C9540 Offset: 0x12C8740 VA: 0x1812C9540
	|-JsonConverter<DateTimeOffset>.TryWriteAsObject
	|
	|-RVA: 0x12C8DF0 Offset: 0x12C7FF0 VA: 0x1812C8DF0
	|-JsonConverter<Decimal>.TryWriteAsObject
	|
	|-RVA: 0x12C8D20 Offset: 0x12C7F20 VA: 0x1812C8D20
	|-JsonConverter<double>.TryWriteAsObject
	|
	|-RVA: 0x12C93A0 Offset: 0x12C85A0 VA: 0x1812C93A0
	|-JsonConverter<Guid>.TryWriteAsObject
	|
	|-RVA: 0x12C9060 Offset: 0x12C8260 VA: 0x1812C9060
	|-JsonConverter<short>.TryWriteAsObject
	|
	|-RVA: 0x12C9200 Offset: 0x12C8400 VA: 0x1812C9200
	|-JsonConverter<int>.TryWriteAsObject
	|
	|-RVA: 0x12C92D0 Offset: 0x12C84D0 VA: 0x1812C92D0
	|-JsonConverter<long>.TryWriteAsObject
	|
	|-RVA: 0x12C8F90 Offset: 0x12C8190 VA: 0x1812C8F90
	|-JsonConverter<IntPtr>.TryWriteAsObject
	|
	|-RVA: 0x12C9130 Offset: 0x12C8330 VA: 0x1812C9130
	|-JsonConverter<JsonElement>.TryWriteAsObject
	|
	|-RVA: 0x12C9610 Offset: 0x12C8810 VA: 0x1812C9610
	|-JsonConverter<object>.TryWriteAsObject
	|
	|-RVA: 0x12C8EC0 Offset: 0x12C80C0 VA: 0x1812C8EC0
	|-JsonConverter<sbyte>.TryWriteAsObject
	|
	|-RVA: 0x12C9470 Offset: 0x12C8670 VA: 0x1812C9470
	|-JsonConverter<float>.TryWriteAsObject
	|
	|-RVA: 0x12D7280 Offset: 0x12D6480 VA: 0x1812D7280
	|-JsonConverter<ushort>.TryWriteAsObject
	|
	|-RVA: 0x12D7540 Offset: 0x12D6740 VA: 0x1812D7540
	|-JsonConverter<uint>.TryWriteAsObject
	|
	|-RVA: 0x12D71B0 Offset: 0x12D63B0 VA: 0x1812D71B0
	|-JsonConverter<ulong>.TryWriteAsObject
	|
	|-RVA: 0x12D7470 Offset: 0x12D6670 VA: 0x1812D7470
	|-JsonConverter<UIntPtr>.TryWriteAsObject
	|
	|-RVA: 0x12D7350 Offset: 0x12D6550 VA: 0x1812D7350
	|-JsonConverter<__Il2CppFullySharedGenericType>.TryWriteAsObject
	*/

	// RVA: -1 Offset: -1 Slot: 21
	internal virtual bool OnTryWrite(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B4500 Offset: 0x12B3700 VA: 0x1812B4500
	|-JsonConverter<Nullable<IntPtr>>.OnTryWrite
	|-JsonConverter<Nullable<UIntPtr>>.OnTryWrite
	|-JsonConverter<DateTimeOffset>.OnTryWrite
	|-JsonConverter<Decimal>.OnTryWrite
	|-JsonConverter<Guid>.OnTryWrite
	|-JsonConverter<JsonElement>.OnTryWrite
	|
	|-RVA: 0x12B4540 Offset: 0x12B3740 VA: 0x1812B4540
	|-JsonConverter<bool>.OnTryWrite
	|-JsonConverter<byte>.OnTryWrite
	|-JsonConverter<char>.OnTryWrite
	|-JsonConverter<DateTime>.OnTryWrite
	|-JsonConverter<short>.OnTryWrite
	|-JsonConverter<int>.OnTryWrite
	|-JsonConverter<long>.OnTryWrite
	|-JsonConverter<IntPtr>.OnTryWrite
	|-JsonConverter<object>.OnTryWrite
	|-JsonConverter<sbyte>.OnTryWrite
	|-JsonConverter<ushort>.OnTryWrite
	|-JsonConverter<uint>.OnTryWrite
	|-JsonConverter<ulong>.OnTryWrite
	|-JsonConverter<UIntPtr>.OnTryWrite
	|
	|-RVA: 0x12BF5A0 Offset: 0x12BE7A0 VA: 0x1812BF5A0
	|-JsonConverter<double>.OnTryWrite
	|-JsonConverter<float>.OnTryWrite
	|
	|-RVA: 0x12D2C50 Offset: 0x12D1E50 VA: 0x1812D2C50
	|-JsonConverter<__Il2CppFullySharedGenericType>.OnTryWrite
	*/

	// RVA: -1 Offset: -1 Slot: 22
	internal virtual bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, ref ReadStack state, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B4480 Offset: 0x12B3680 VA: 0x1812B4480
	|-JsonConverter<Nullable<IntPtr>>.OnTryRead
	|-JsonConverter<Nullable<UIntPtr>>.OnTryRead
	|-JsonConverter<DateTimeOffset>.OnTryRead
	|-JsonConverter<Decimal>.OnTryRead
	|-JsonConverter<Guid>.OnTryRead
	|-JsonConverter<JsonElement>.OnTryRead
	|
	|-RVA: 0x12B4420 Offset: 0x12B3620 VA: 0x1812B4420
	|-JsonConverter<bool>.OnTryRead
	|-JsonConverter<byte>.OnTryRead
	|-JsonConverter<sbyte>.OnTryRead
	|
	|-RVA: 0x12B4450 Offset: 0x12B3650 VA: 0x1812B4450
	|-JsonConverter<char>.OnTryRead
	|-JsonConverter<short>.OnTryRead
	|-JsonConverter<ushort>.OnTryRead
	|
	|-RVA: 0x12B44D0 Offset: 0x12B36D0 VA: 0x1812B44D0
	|-JsonConverter<DateTime>.OnTryRead
	|-JsonConverter<long>.OnTryRead
	|-JsonConverter<IntPtr>.OnTryRead
	|-JsonConverter<object>.OnTryRead
	|-JsonConverter<ulong>.OnTryRead
	|-JsonConverter<UIntPtr>.OnTryRead
	|
	|-RVA: 0x12BF570 Offset: 0x12BE770 VA: 0x1812BF570
	|-JsonConverter<double>.OnTryRead
	|
	|-RVA: 0x12BF540 Offset: 0x12BE740 VA: 0x1812BF540
	|-JsonConverter<int>.OnTryRead
	|-JsonConverter<uint>.OnTryRead
	|
	|-RVA: 0x12BF510 Offset: 0x12BE710 VA: 0x1812BF510
	|-JsonConverter<float>.OnTryRead
	|
	|-RVA: 0x12D2B70 Offset: 0x12D1D70 VA: 0x1812D2B70
	|-JsonConverter<__Il2CppFullySharedGenericType>.OnTryRead
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public abstract T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-JsonConverter<__Il2CppFullySharedGenericType>.Read
	*/

	// RVA: -1 Offset: -1
	internal bool TryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, ref ReadStack state, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B83B0 Offset: 0x12B75B0 VA: 0x1812B83B0
	|-JsonConverter<Nullable<IntPtr>>.TryRead
	|
	|-RVA: 0x12B89E0 Offset: 0x12B7BE0 VA: 0x1812B89E0
	|-JsonConverter<Nullable<UIntPtr>>.TryRead
	|
	|-RVA: 0x12B71D0 Offset: 0x12B63D0 VA: 0x1812B71D0
	|-JsonConverter<bool>.TryRead
	|
	|-RVA: 0x12B77C0 Offset: 0x12B69C0 VA: 0x1812B77C0
	|-JsonConverter<byte>.TryRead
	|
	|-RVA: 0x12B9010 Offset: 0x12B8210 VA: 0x1812B9010
	|-JsonConverter<char>.TryRead
	|
	|-RVA: 0x12B7DB0 Offset: 0x12B6FB0 VA: 0x1812B7DB0
	|-JsonConverter<DateTime>.TryRead
	|
	|-RVA: 0x12C56C0 Offset: 0x12C48C0 VA: 0x1812C56C0
	|-JsonConverter<DateTimeOffset>.TryRead
	|
	|-RVA: 0x12C44A0 Offset: 0x12C36A0 VA: 0x1812C44A0
	|-JsonConverter<Decimal>.TryRead
	|
	|-RVA: 0x12C7B30 Offset: 0x12C6D30 VA: 0x1812C7B30
	|-JsonConverter<double>.TryRead
	|
	|-RVA: 0x12C6920 Offset: 0x12C5B20 VA: 0x1812C6920
	|-JsonConverter<Guid>.TryRead
	|
	|-RVA: 0x12C50C0 Offset: 0x12C42C0 VA: 0x1812C50C0
	|-JsonConverter<short>.TryRead
	|
	|-RVA: 0x12C8130 Offset: 0x12C7330 VA: 0x1812C8130
	|-JsonConverter<int>.TryRead
	|
	|-RVA: 0x12C6320 Offset: 0x12C5520 VA: 0x1812C6320
	|-JsonConverter<long>.TryRead
	|
	|-RVA: 0x12C7530 Offset: 0x12C6730 VA: 0x1812C7530
	|-JsonConverter<IntPtr>.TryRead
	|
	|-RVA: 0x12C5CF0 Offset: 0x12C4EF0 VA: 0x1812C5CF0
	|-JsonConverter<JsonElement>.TryRead
	|
	|-RVA: 0x12C6F50 Offset: 0x12C6150 VA: 0x1812C6F50
	|-JsonConverter<object>.TryRead
	|
	|-RVA: 0x12C4AD0 Offset: 0x12C3CD0 VA: 0x1812C4AD0
	|-JsonConverter<sbyte>.TryRead
	|
	|-RVA: 0x12C8720 Offset: 0x12C7920 VA: 0x1812C8720
	|-JsonConverter<float>.TryRead
	|
	|-RVA: 0x12D6BB0 Offset: 0x12D5DB0 VA: 0x1812D6BB0
	|-JsonConverter<ushort>.TryRead
	|
	|-RVA: 0x12D51A0 Offset: 0x12D43A0 VA: 0x1812D51A0
	|-JsonConverter<uint>.TryRead
	|
	|-RVA: 0x12D65B0 Offset: 0x12D57B0 VA: 0x1812D65B0
	|-JsonConverter<ulong>.TryRead
	|
	|-RVA: 0x12D5FB0 Offset: 0x12D51B0 VA: 0x1812D5FB0
	|-JsonConverter<UIntPtr>.TryRead
	|
	|-RVA: 0x12D5790 Offset: 0x12D4990 VA: 0x1812D5790
	|-JsonConverter<__Il2CppFullySharedGenericType>.TryRead
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal sealed override bool TryReadAsObject(ref Utf8JsonReader reader, JsonSerializerOptions options, ref ReadStack state, out object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B7010 Offset: 0x12B6210 VA: 0x1812B7010
	|-JsonConverter<Nullable<IntPtr>>.TryReadAsObject
	|
	|-RVA: 0x12B70F0 Offset: 0x12B62F0 VA: 0x1812B70F0
	|-JsonConverter<Nullable<UIntPtr>>.TryReadAsObject
	|
	|-RVA: 0x12B6F40 Offset: 0x12B6140 VA: 0x1812B6F40
	|-JsonConverter<bool>.TryReadAsObject
	|
	|-RVA: 0x12B6E70 Offset: 0x12B6070 VA: 0x1812B6E70
	|-JsonConverter<byte>.TryReadAsObject
	|
	|-RVA: 0x12B6DA0 Offset: 0x12B5FA0 VA: 0x1812B6DA0
	|-JsonConverter<char>.TryReadAsObject
	|
	|-RVA: 0x12B6CD0 Offset: 0x12B5ED0 VA: 0x1812B6CD0
	|-JsonConverter<DateTime>.TryReadAsObject
	|
	|-RVA: 0x12C3B90 Offset: 0x12C2D90 VA: 0x1812C3B90
	|-JsonConverter<DateTimeOffset>.TryReadAsObject
	|
	|-RVA: 0x12C4060 Offset: 0x12C3260 VA: 0x1812C4060
	|-JsonConverter<Decimal>.TryReadAsObject
	|
	|-RVA: 0x12C43D0 Offset: 0x12C35D0 VA: 0x1812C43D0
	|-JsonConverter<double>.TryReadAsObject
	|
	|-RVA: 0x12C4140 Offset: 0x12C3340 VA: 0x1812C4140
	|-JsonConverter<Guid>.TryReadAsObject
	|
	|-RVA: 0x12C3AC0 Offset: 0x12C2CC0 VA: 0x1812C3AC0
	|-JsonConverter<short>.TryReadAsObject
	|
	|-RVA: 0x12C4300 Offset: 0x12C3500 VA: 0x1812C4300
	|-JsonConverter<int>.TryReadAsObject
	|
	|-RVA: 0x12C3DF0 Offset: 0x12C2FF0 VA: 0x1812C3DF0
	|-JsonConverter<long>.TryReadAsObject
	|
	|-RVA: 0x12C3D20 Offset: 0x12C2F20 VA: 0x1812C3D20
	|-JsonConverter<IntPtr>.TryReadAsObject
	|
	|-RVA: 0x12C4220 Offset: 0x12C3420 VA: 0x1812C4220
	|-JsonConverter<JsonElement>.TryReadAsObject
	|
	|-RVA: 0x12C3C70 Offset: 0x12C2E70 VA: 0x1812C3C70
	|-JsonConverter<object>.TryReadAsObject
	|
	|-RVA: 0x12C3F90 Offset: 0x12C3190 VA: 0x1812C3F90
	|-JsonConverter<sbyte>.TryReadAsObject
	|
	|-RVA: 0x12C3EC0 Offset: 0x12C30C0 VA: 0x1812C3EC0
	|-JsonConverter<float>.TryReadAsObject
	|
	|-RVA: 0x12D50D0 Offset: 0x12D42D0 VA: 0x1812D50D0
	|-JsonConverter<ushort>.TryReadAsObject
	|
	|-RVA: 0x12D4D20 Offset: 0x12D3F20 VA: 0x1812D4D20
	|-JsonConverter<uint>.TryReadAsObject
	|
	|-RVA: 0x12D5000 Offset: 0x12D4200 VA: 0x1812D5000
	|-JsonConverter<ulong>.TryReadAsObject
	|
	|-RVA: 0x12D4F30 Offset: 0x12D4130 VA: 0x1812D4F30
	|-JsonConverter<UIntPtr>.TryReadAsObject
	|
	|-RVA: 0x12D4DF0 Offset: 0x12D3FF0 VA: 0x1812D4DF0
	|-JsonConverter<__Il2CppFullySharedGenericType>.TryReadAsObject
	*/

	// RVA: -1 Offset: -1
	internal bool TryWrite(Utf8JsonWriter writer, in T value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BB5F0 Offset: 0x12BA7F0 VA: 0x1812BB5F0
	|-JsonConverter<Nullable<IntPtr>>.TryWrite
	|
	|-RVA: 0x12BAA30 Offset: 0x12B9C30 VA: 0x1812BAA30
	|-JsonConverter<Nullable<UIntPtr>>.TryWrite
	|
	|-RVA: 0x12BAE70 Offset: 0x12BA070 VA: 0x1812BAE70
	|-JsonConverter<bool>.TryWrite
	|
	|-RVA: 0x12BB230 Offset: 0x12BA430 VA: 0x1812BB230
	|-JsonConverter<byte>.TryWrite
	|
	|-RVA: 0x12BA670 Offset: 0x12B9870 VA: 0x1812BA670
	|-JsonConverter<char>.TryWrite
	|
	|-RVA: 0x12BBA30 Offset: 0x12BAC30 VA: 0x1812BBA30
	|-JsonConverter<DateTime>.TryWrite
	|
	|-RVA: 0x12CC850 Offset: 0x12CBA50 VA: 0x1812CC850
	|-JsonConverter<DateTimeOffset>.TryWrite
	|
	|-RVA: 0x12CB540 Offset: 0x12CA740 VA: 0x1812CB540
	|-JsonConverter<Decimal>.TryWrite
	|
	|-RVA: 0x12CB170 Offset: 0x12CA370 VA: 0x1812CB170
	|-JsonConverter<double>.TryWrite
	|
	|-RVA: 0x12CB920 Offset: 0x12CAB20 VA: 0x1812CB920
	|-JsonConverter<Guid>.TryWrite
	|
	|-RVA: 0x12CCFE0 Offset: 0x12CC1E0 VA: 0x1812CCFE0
	|-JsonConverter<short>.TryWrite
	|
	|-RVA: 0x12CCC30 Offset: 0x12CBE30 VA: 0x1812CCC30
	|-JsonConverter<int>.TryWrite
	|
	|-RVA: 0x12CC0C0 Offset: 0x12CB2C0 VA: 0x1812CC0C0
	|-JsonConverter<long>.TryWrite
	|
	|-RVA: 0x12CD3A0 Offset: 0x12CC5A0 VA: 0x1812CD3A0
	|-JsonConverter<IntPtr>.TryWrite
	|
	|-RVA: 0x12CC470 Offset: 0x12CB670 VA: 0x1812CC470
	|-JsonConverter<JsonElement>.TryWrite
	|
	|-RVA: 0x12CBD00 Offset: 0x12CAF00 VA: 0x1812CBD00
	|-JsonConverter<object>.TryWrite
	|
	|-RVA: 0x12CADB0 Offset: 0x12C9FB0 VA: 0x1812CADB0
	|-JsonConverter<sbyte>.TryWrite
	|
	|-RVA: 0x12CD750 Offset: 0x12CC950 VA: 0x1812CD750
	|-JsonConverter<float>.TryWrite
	|
	|-RVA: 0x12D8790 Offset: 0x12D7990 VA: 0x1812D8790
	|-JsonConverter<ushort>.TryWrite
	|
	|-RVA: 0x12D83E0 Offset: 0x12D75E0 VA: 0x1812D83E0
	|-JsonConverter<uint>.TryWrite
	|
	|-RVA: 0x12D8030 Offset: 0x12D7230 VA: 0x1812D8030
	|-JsonConverter<ulong>.TryWrite
	|
	|-RVA: 0x12D8B50 Offset: 0x12D7D50 VA: 0x1812D8B50
	|-JsonConverter<UIntPtr>.TryWrite
	|
	|-RVA: 0x12D8F00 Offset: 0x12D8100 VA: 0x1812D8F00
	|-JsonConverter<__Il2CppFullySharedGenericType>.TryWrite
	*/

	// RVA: -1 Offset: -1
	internal bool TryWriteDataExtensionProperty(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BA480 Offset: 0x12B9680 VA: 0x1812BA480
	|-JsonConverter<Nullable<IntPtr>>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12BA0B0 Offset: 0x12B92B0 VA: 0x1812BA0B0
	|-JsonConverter<Nullable<UIntPtr>>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12B9CF0 Offset: 0x12B8EF0 VA: 0x1812B9CF0
	|-JsonConverter<bool>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12B9B10 Offset: 0x12B8D10 VA: 0x1812B9B10
	|-JsonConverter<byte>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12B9ED0 Offset: 0x12B90D0 VA: 0x1812B9ED0
	|-JsonConverter<char>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12BA2A0 Offset: 0x12B94A0 VA: 0x1812BA2A0
	|-JsonConverter<DateTime>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12C9AA0 Offset: 0x12C8CA0 VA: 0x1812C9AA0
	|-JsonConverter<DateTimeOffset>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12C98B0 Offset: 0x12C8AB0 VA: 0x1812C98B0
	|-JsonConverter<Decimal>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12CA800 Offset: 0x12C9A00 VA: 0x1812CA800
	|-JsonConverter<double>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12CA610 Offset: 0x12C9810 VA: 0x1812CA610
	|-JsonConverter<Guid>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12C9C90 Offset: 0x12C8E90 VA: 0x1812C9C90
	|-JsonConverter<short>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12CA240 Offset: 0x12C9440 VA: 0x1812CA240
	|-JsonConverter<int>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12C96D0 Offset: 0x12C88D0 VA: 0x1812C96D0
	|-JsonConverter<long>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12C9E70 Offset: 0x12C9070 VA: 0x1812C9E70
	|-JsonConverter<IntPtr>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12CA050 Offset: 0x12C9250 VA: 0x1812CA050
	|-JsonConverter<JsonElement>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12CA9F0 Offset: 0x12C9BF0 VA: 0x1812CA9F0
	|-JsonConverter<object>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12CABD0 Offset: 0x12C9DD0 VA: 0x1812CABD0
	|-JsonConverter<sbyte>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12CA420 Offset: 0x12C9620 VA: 0x1812CA420
	|-JsonConverter<float>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12D79D0 Offset: 0x12D6BD0 VA: 0x1812D79D0
	|-JsonConverter<ushort>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12D7BB0 Offset: 0x12D6DB0 VA: 0x1812D7BB0
	|-JsonConverter<uint>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12D77F0 Offset: 0x12D69F0 VA: 0x1812D77F0
	|-JsonConverter<ulong>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12D7610 Offset: 0x12D6810 VA: 0x1812D7610
	|-JsonConverter<UIntPtr>.TryWriteDataExtensionProperty
	|
	|-RVA: 0x12D7D90 Offset: 0x12D6F90 VA: 0x1812D7D90
	|-JsonConverter<__Il2CppFullySharedGenericType>.TryWriteDataExtensionProperty
	*/

	// RVA: -1 Offset: -1 Slot: 12
	internal sealed override Type get_TypeToConvert() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BE9D0 Offset: 0x12BDBD0 VA: 0x1812BE9D0
	|-JsonConverter<Nullable<IntPtr>>.get_TypeToConvert
	|
	|-RVA: 0x12BE970 Offset: 0x12BDB70 VA: 0x1812BE970
	|-JsonConverter<Nullable<UIntPtr>>.get_TypeToConvert
	|
	|-RVA: 0x12BEA30 Offset: 0x12BDC30 VA: 0x1812BEA30
	|-JsonConverter<bool>.get_TypeToConvert
	|
	|-RVA: 0x12BE8B0 Offset: 0x12BDAB0 VA: 0x1812BE8B0
	|-JsonConverter<byte>.get_TypeToConvert
	|
	|-RVA: 0x12BE910 Offset: 0x12BDB10 VA: 0x1812BE910
	|-JsonConverter<char>.get_TypeToConvert
	|
	|-RVA: 0x12BE850 Offset: 0x12BDA50 VA: 0x1812BE850
	|-JsonConverter<DateTime>.get_TypeToConvert
	|
	|-RVA: 0x12D23C0 Offset: 0x12D15C0 VA: 0x1812D23C0
	|-JsonConverter<DateTimeOffset>.get_TypeToConvert
	|
	|-RVA: 0x12D2360 Offset: 0x12D1560 VA: 0x1812D2360
	|-JsonConverter<Decimal>.get_TypeToConvert
	|
	|-RVA: 0x12D2240 Offset: 0x12D1440 VA: 0x1812D2240
	|-JsonConverter<double>.get_TypeToConvert
	|
	|-RVA: 0x12D21E0 Offset: 0x12D13E0 VA: 0x1812D21E0
	|-JsonConverter<Guid>.get_TypeToConvert
	|
	|-RVA: 0x12D2420 Offset: 0x12D1620 VA: 0x1812D2420
	|-JsonConverter<short>.get_TypeToConvert
	|
	|-RVA: 0x12D22A0 Offset: 0x12D14A0 VA: 0x1812D22A0
	|-JsonConverter<int>.get_TypeToConvert
	|
	|-RVA: 0x12D2480 Offset: 0x12D1680 VA: 0x1812D2480
	|-JsonConverter<long>.get_TypeToConvert
	|
	|-RVA: 0x12D24E0 Offset: 0x12D16E0 VA: 0x1812D24E0
	|-JsonConverter<IntPtr>.get_TypeToConvert
	|
	|-RVA: 0x12D2300 Offset: 0x12D1500 VA: 0x1812D2300
	|-JsonConverter<JsonElement>.get_TypeToConvert
	|
	|-RVA: 0x12D2600 Offset: 0x12D1800 VA: 0x1812D2600
	|-JsonConverter<object>.get_TypeToConvert
	|
	|-RVA: 0x12D2540 Offset: 0x12D1740 VA: 0x1812D2540
	|-JsonConverter<sbyte>.get_TypeToConvert
	|
	|-RVA: 0x12D25A0 Offset: 0x12D17A0 VA: 0x1812D25A0
	|-JsonConverter<float>.get_TypeToConvert
	|
	|-RVA: 0x12DB480 Offset: 0x12DA680 VA: 0x1812DB480
	|-JsonConverter<ushort>.get_TypeToConvert
	|
	|-RVA: 0x12DB3C0 Offset: 0x12DA5C0 VA: 0x1812DB3C0
	|-JsonConverter<uint>.get_TypeToConvert
	|
	|-RVA: 0x12DB420 Offset: 0x12DA620 VA: 0x1812DB420
	|-JsonConverter<ulong>.get_TypeToConvert
	|
	|-RVA: 0x12DB4E0 Offset: 0x12DA6E0 VA: 0x1812DB4E0
	|-JsonConverter<UIntPtr>.get_TypeToConvert
	|
	|-RVA: 0x12DB540 Offset: 0x12DA740 VA: 0x1812DB540
	|-JsonConverter<__Il2CppFullySharedGenericType>.get_TypeToConvert
	*/

	// RVA: -1 Offset: -1
	internal void VerifyRead(JsonTokenType tokenType, int depth, long bytesConsumed, bool isValueConverter, ref Utf8JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BBDF0 Offset: 0x12BAFF0 VA: 0x1812BBDF0
	|-JsonConverter<Nullable<IntPtr>>.VerifyRead
	|-JsonConverter<Nullable<UIntPtr>>.VerifyRead
	|-JsonConverter<bool>.VerifyRead
	|-JsonConverter<byte>.VerifyRead
	|-JsonConverter<char>.VerifyRead
	|-JsonConverter<DateTime>.VerifyRead
	|-JsonConverter<DateTimeOffset>.VerifyRead
	|-JsonConverter<Decimal>.VerifyRead
	|-JsonConverter<double>.VerifyRead
	|-JsonConverter<Guid>.VerifyRead
	|-JsonConverter<short>.VerifyRead
	|-JsonConverter<int>.VerifyRead
	|-JsonConverter<long>.VerifyRead
	|-JsonConverter<IntPtr>.VerifyRead
	|-JsonConverter<JsonElement>.VerifyRead
	|-JsonConverter<object>.VerifyRead
	|-JsonConverter<sbyte>.VerifyRead
	|-JsonConverter<float>.VerifyRead
	|-JsonConverter<ushort>.VerifyRead
	|-JsonConverter<uint>.VerifyRead
	|-JsonConverter<ulong>.VerifyRead
	|-JsonConverter<UIntPtr>.VerifyRead
	|-JsonConverter<__Il2CppFullySharedGenericType>.VerifyRead
	*/

	// RVA: -1 Offset: -1
	internal void VerifyWrite(int originalDepth, Utf8JsonWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BBE90 Offset: 0x12BB090 VA: 0x1812BBE90
	|-JsonConverter<Nullable<IntPtr>>.VerifyWrite
	|-JsonConverter<Nullable<UIntPtr>>.VerifyWrite
	|-JsonConverter<bool>.VerifyWrite
	|-JsonConverter<byte>.VerifyWrite
	|-JsonConverter<char>.VerifyWrite
	|-JsonConverter<DateTime>.VerifyWrite
	|-JsonConverter<DateTimeOffset>.VerifyWrite
	|-JsonConverter<Decimal>.VerifyWrite
	|-JsonConverter<double>.VerifyWrite
	|-JsonConverter<Guid>.VerifyWrite
	|-JsonConverter<short>.VerifyWrite
	|-JsonConverter<int>.VerifyWrite
	|-JsonConverter<long>.VerifyWrite
	|-JsonConverter<IntPtr>.VerifyWrite
	|-JsonConverter<JsonElement>.VerifyWrite
	|-JsonConverter<object>.VerifyWrite
	|-JsonConverter<sbyte>.VerifyWrite
	|-JsonConverter<float>.VerifyWrite
	|-JsonConverter<ushort>.VerifyWrite
	|-JsonConverter<uint>.VerifyWrite
	|-JsonConverter<ulong>.VerifyWrite
	|-JsonConverter<UIntPtr>.VerifyWrite
	|-JsonConverter<__Il2CppFullySharedGenericType>.VerifyWrite
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-JsonConverter<__Il2CppFullySharedGenericType>.Write
	*/

	// RVA: -1 Offset: -1 Slot: 25
	internal virtual T ReadWithQuotes(ref Utf8JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B6C10 Offset: 0x12B5E10 VA: 0x1812B6C10
	|-JsonConverter<Nullable<IntPtr>>.ReadWithQuotes
	|-JsonConverter<Nullable<UIntPtr>>.ReadWithQuotes
	|-JsonConverter<DateTimeOffset>.ReadWithQuotes
	|-JsonConverter<Decimal>.ReadWithQuotes
	|-JsonConverter<Guid>.ReadWithQuotes
	|-JsonConverter<JsonElement>.ReadWithQuotes
	|
	|-RVA: 0x12B6C90 Offset: 0x12B5E90 VA: 0x1812B6C90
	|-JsonConverter<bool>.ReadWithQuotes
	|-JsonConverter<byte>.ReadWithQuotes
	|-JsonConverter<char>.ReadWithQuotes
	|-JsonConverter<DateTime>.ReadWithQuotes
	|-JsonConverter<double>.ReadWithQuotes
	|-JsonConverter<short>.ReadWithQuotes
	|-JsonConverter<int>.ReadWithQuotes
	|-JsonConverter<long>.ReadWithQuotes
	|-JsonConverter<IntPtr>.ReadWithQuotes
	|-JsonConverter<object>.ReadWithQuotes
	|-JsonConverter<sbyte>.ReadWithQuotes
	|-JsonConverter<float>.ReadWithQuotes
	|-JsonConverter<ushort>.ReadWithQuotes
	|-JsonConverter<uint>.ReadWithQuotes
	|-JsonConverter<ulong>.ReadWithQuotes
	|-JsonConverter<UIntPtr>.ReadWithQuotes
	|
	|-RVA: 0x12D4C90 Offset: 0x12D3E90 VA: 0x1812D4C90
	|-JsonConverter<__Il2CppFullySharedGenericType>.ReadWithQuotes
	*/

	// RVA: -1 Offset: -1 Slot: 26
	internal virtual void WriteWithQuotes(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BDA70 Offset: 0x12BCC70 VA: 0x1812BDA70
	|-JsonConverter<Nullable<IntPtr>>.WriteWithQuotes
	|-JsonConverter<Nullable<UIntPtr>>.WriteWithQuotes
	|-JsonConverter<bool>.WriteWithQuotes
	|-JsonConverter<byte>.WriteWithQuotes
	|-JsonConverter<char>.WriteWithQuotes
	|-JsonConverter<DateTime>.WriteWithQuotes
	|-JsonConverter<DateTimeOffset>.WriteWithQuotes
	|-JsonConverter<Decimal>.WriteWithQuotes
	|-JsonConverter<double>.WriteWithQuotes
	|-JsonConverter<Guid>.WriteWithQuotes
	|-JsonConverter<short>.WriteWithQuotes
	|-JsonConverter<int>.WriteWithQuotes
	|-JsonConverter<long>.WriteWithQuotes
	|-JsonConverter<IntPtr>.WriteWithQuotes
	|-JsonConverter<JsonElement>.WriteWithQuotes
	|-JsonConverter<object>.WriteWithQuotes
	|-JsonConverter<sbyte>.WriteWithQuotes
	|-JsonConverter<float>.WriteWithQuotes
	|-JsonConverter<ushort>.WriteWithQuotes
	|-JsonConverter<uint>.WriteWithQuotes
	|-JsonConverter<ulong>.WriteWithQuotes
	|-JsonConverter<UIntPtr>.WriteWithQuotes
	|-JsonConverter<__Il2CppFullySharedGenericType>.WriteWithQuotes
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal sealed override void WriteWithQuotesAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BD840 Offset: 0x12BCA40 VA: 0x1812BD840
	|-JsonConverter<Nullable<IntPtr>>.WriteWithQuotesAsObject
	|-JsonConverter<Nullable<UIntPtr>>.WriteWithQuotesAsObject
	|
	|-RVA: 0x12BD790 Offset: 0x12BC990 VA: 0x1812BD790
	|-JsonConverter<bool>.WriteWithQuotesAsObject
	|-JsonConverter<byte>.WriteWithQuotesAsObject
	|-JsonConverter<sbyte>.WriteWithQuotesAsObject
	|
	|-RVA: 0x12BD910 Offset: 0x12BCB10 VA: 0x1812BD910
	|-JsonConverter<char>.WriteWithQuotesAsObject
	|-JsonConverter<short>.WriteWithQuotesAsObject
	|-JsonConverter<ushort>.WriteWithQuotesAsObject
	|
	|-RVA: 0x12BD9C0 Offset: 0x12BCBC0 VA: 0x1812BD9C0
	|-JsonConverter<DateTime>.WriteWithQuotesAsObject
	|-JsonConverter<long>.WriteWithQuotesAsObject
	|-JsonConverter<IntPtr>.WriteWithQuotesAsObject
	|-JsonConverter<ulong>.WriteWithQuotesAsObject
	|-JsonConverter<UIntPtr>.WriteWithQuotesAsObject
	|
	|-RVA: 0x12D0350 Offset: 0x12CF550 VA: 0x1812D0350
	|-JsonConverter<DateTimeOffset>.WriteWithQuotesAsObject
	|-JsonConverter<Decimal>.WriteWithQuotesAsObject
	|-JsonConverter<Guid>.WriteWithQuotesAsObject
	|-JsonConverter<JsonElement>.WriteWithQuotesAsObject
	|
	|-RVA: 0x12D04C0 Offset: 0x12CF6C0 VA: 0x1812D04C0
	|-JsonConverter<double>.WriteWithQuotesAsObject
	|
	|-RVA: 0x12D0410 Offset: 0x12CF610 VA: 0x1812D0410
	|-JsonConverter<int>.WriteWithQuotesAsObject
	|-JsonConverter<uint>.WriteWithQuotesAsObject
	|
	|-RVA: 0x12D0620 Offset: 0x12CF820 VA: 0x1812D0620
	|-JsonConverter<object>.WriteWithQuotesAsObject
	|
	|-RVA: 0x12D0570 Offset: 0x12CF770 VA: 0x1812D0570
	|-JsonConverter<float>.WriteWithQuotesAsObject
	|
	|-RVA: 0x12DA6E0 Offset: 0x12D98E0 VA: 0x1812DA6E0
	|-JsonConverter<__Il2CppFullySharedGenericType>.WriteWithQuotesAsObject
	*/

	// RVA: -1 Offset: -1 Slot: 27
	internal virtual T ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B6C50 Offset: 0x12B5E50 VA: 0x1812B6C50
	|-JsonConverter<Nullable<IntPtr>>.ReadNumberWithCustomHandling
	|-JsonConverter<Nullable<UIntPtr>>.ReadNumberWithCustomHandling
	|-JsonConverter<DateTimeOffset>.ReadNumberWithCustomHandling
	|-JsonConverter<Decimal>.ReadNumberWithCustomHandling
	|-JsonConverter<Guid>.ReadNumberWithCustomHandling
	|-JsonConverter<JsonElement>.ReadNumberWithCustomHandling
	|
	|-RVA: 0x12B6C10 Offset: 0x12B5E10 VA: 0x1812B6C10
	|-JsonConverter<bool>.ReadNumberWithCustomHandling
	|-JsonConverter<byte>.ReadNumberWithCustomHandling
	|-JsonConverter<char>.ReadNumberWithCustomHandling
	|-JsonConverter<DateTime>.ReadNumberWithCustomHandling
	|-JsonConverter<double>.ReadNumberWithCustomHandling
	|-JsonConverter<short>.ReadNumberWithCustomHandling
	|-JsonConverter<int>.ReadNumberWithCustomHandling
	|-JsonConverter<long>.ReadNumberWithCustomHandling
	|-JsonConverter<IntPtr>.ReadNumberWithCustomHandling
	|-JsonConverter<object>.ReadNumberWithCustomHandling
	|-JsonConverter<sbyte>.ReadNumberWithCustomHandling
	|-JsonConverter<float>.ReadNumberWithCustomHandling
	|-JsonConverter<ushort>.ReadNumberWithCustomHandling
	|-JsonConverter<uint>.ReadNumberWithCustomHandling
	|-JsonConverter<ulong>.ReadNumberWithCustomHandling
	|-JsonConverter<UIntPtr>.ReadNumberWithCustomHandling
	|
	|-RVA: 0x12D4BF0 Offset: 0x12D3DF0 VA: 0x1812D4BF0
	|-JsonConverter<__Il2CppFullySharedGenericType>.ReadNumberWithCustomHandling
	*/

	// RVA: -1 Offset: -1 Slot: 28
	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, T value, JsonNumberHandling handling) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B6C50 Offset: 0x12B5E50 VA: 0x1812B6C50
	|-JsonConverter<Nullable<IntPtr>>.WriteNumberWithCustomHandling
	|-JsonConverter<Nullable<UIntPtr>>.WriteNumberWithCustomHandling
	|-JsonConverter<bool>.WriteNumberWithCustomHandling
	|-JsonConverter<byte>.WriteNumberWithCustomHandling
	|-JsonConverter<char>.WriteNumberWithCustomHandling
	|-JsonConverter<DateTime>.WriteNumberWithCustomHandling
	|-JsonConverter<DateTimeOffset>.WriteNumberWithCustomHandling
	|-JsonConverter<Decimal>.WriteNumberWithCustomHandling
	|-JsonConverter<double>.WriteNumberWithCustomHandling
	|-JsonConverter<Guid>.WriteNumberWithCustomHandling
	|-JsonConverter<short>.WriteNumberWithCustomHandling
	|-JsonConverter<int>.WriteNumberWithCustomHandling
	|-JsonConverter<long>.WriteNumberWithCustomHandling
	|-JsonConverter<IntPtr>.WriteNumberWithCustomHandling
	|-JsonConverter<JsonElement>.WriteNumberWithCustomHandling
	|-JsonConverter<object>.WriteNumberWithCustomHandling
	|-JsonConverter<sbyte>.WriteNumberWithCustomHandling
	|-JsonConverter<float>.WriteNumberWithCustomHandling
	|-JsonConverter<ushort>.WriteNumberWithCustomHandling
	|-JsonConverter<uint>.WriteNumberWithCustomHandling
	|-JsonConverter<ulong>.WriteNumberWithCustomHandling
	|-JsonConverter<UIntPtr>.WriteNumberWithCustomHandling
	|-JsonConverter<__Il2CppFullySharedGenericType>.WriteNumberWithCustomHandling
	*/
}

// Namespace: System.Text.Json.Serialization
internal enum JsonIgnoreCondition // TypeDefIndex: 15925
{
	// Fields
	public int value__; // 0x0
	public const JsonIgnoreCondition Never = 0;
	public const JsonIgnoreCondition Always = 1;
	public const JsonIgnoreCondition WhenWritingDefault = 2;
	public const JsonIgnoreCondition WhenWritingNull = 3;
}

// Namespace: System.Text.Json.Serialization
[Flags]
internal enum JsonNumberHandling // TypeDefIndex: 15926
{
	// Fields
	public int value__; // 0x0
	public const JsonNumberHandling Strict = 0;
	public const JsonNumberHandling AllowReadingFromString = 1;
	public const JsonNumberHandling WriteAsString = 2;
	public const JsonNumberHandling AllowNamedFloatingPointLiterals = 4;
}

// Namespace: System.Text.Json.Serialization
internal abstract class JsonResumableConverter<T> : JsonConverter<T> // TypeDefIndex: 15927
{
	// Properties
	public sealed override bool HandleNull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 23
	public sealed override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F24C0 Offset: 0x12F16C0 VA: 0x1812F24C0
	|-JsonResumableConverter<Nullable<IntPtr>>.Read
	|
	|-RVA: 0x12F3CF0 Offset: 0x12F2EF0 VA: 0x1812F3CF0
	|-JsonResumableConverter<Nullable<UIntPtr>>.Read
	|
	|-RVA: 0x12F3A50 Offset: 0x12F2C50 VA: 0x1812F3A50
	|-JsonResumableConverter<bool>.Read
	|
	|-RVA: 0x12F2220 Offset: 0x12F1420 VA: 0x1812F2220
	|-JsonResumableConverter<byte>.Read
	|
	|-RVA: 0x12F2CA0 Offset: 0x12F1EA0 VA: 0x1812F2CA0
	|-JsonResumableConverter<char>.Read
	|
	|-RVA: 0x12F2370 Offset: 0x12F1570 VA: 0x1812F2370
	|-JsonResumableConverter<DateTime>.Read
	|
	|-RVA: 0x12F3E40 Offset: 0x12F3040 VA: 0x1812F3E40
	|-JsonResumableConverter<DateTimeOffset>.Read
	|
	|-RVA: 0x12F3510 Offset: 0x12F2710 VA: 0x1812F3510
	|-JsonResumableConverter<Decimal>.Read
	|
	|-RVA: 0x12F3F90 Offset: 0x12F3190 VA: 0x1812F3F90
	|-JsonResumableConverter<double>.Read
	|
	|-RVA: 0x12F2A00 Offset: 0x12F1C00 VA: 0x1812F2A00
	|-JsonResumableConverter<Guid>.Read
	|
	|-RVA: 0x12F3900 Offset: 0x12F2B00 VA: 0x1812F3900
	|-JsonResumableConverter<short>.Read
	|
	|-RVA: 0x12F3660 Offset: 0x12F2860 VA: 0x1812F3660
	|-JsonResumableConverter<int>.Read
	|
	|-RVA: 0x12F2F40 Offset: 0x12F2140 VA: 0x1812F2F40
	|-JsonResumableConverter<long>.Read
	|
	|-RVA: 0x12F2760 Offset: 0x12F1960 VA: 0x1812F2760
	|-JsonResumableConverter<IntPtr>.Read
	|
	|-RVA: 0x12F2B50 Offset: 0x12F1D50 VA: 0x1812F2B50
	|-JsonResumableConverter<JsonElement>.Read
	|
	|-RVA: 0x12F28B0 Offset: 0x12F1AB0 VA: 0x1812F28B0
	|-JsonResumableConverter<object>.Read
	|
	|-RVA: 0x12F3090 Offset: 0x12F2290 VA: 0x1812F3090
	|-JsonResumableConverter<sbyte>.Read
	|
	|-RVA: 0x12F2DF0 Offset: 0x12F1FF0 VA: 0x1812F2DF0
	|-JsonResumableConverter<float>.Read
	|
	|-RVA: 0x12F3BA0 Offset: 0x12F2DA0 VA: 0x1812F3BA0
	|-JsonResumableConverter<ushort>.Read
	|
	|-RVA: 0x12F37B0 Offset: 0x12F29B0 VA: 0x1812F37B0
	|-JsonResumableConverter<uint>.Read
	|
	|-RVA: 0x12F33C0 Offset: 0x12F25C0 VA: 0x1812F33C0
	|-JsonResumableConverter<ulong>.Read
	|
	|-RVA: 0x12F2610 Offset: 0x12F1810 VA: 0x1812F2610
	|-JsonResumableConverter<UIntPtr>.Read
	|
	|-RVA: 0x12F31E0 Offset: 0x12F23E0 VA: 0x1812F31E0
	|-JsonResumableConverter<__Il2CppFullySharedGenericType>.Read
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public sealed override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F4E60 Offset: 0x12F4060 VA: 0x1812F4E60
	|-JsonResumableConverter<Nullable<IntPtr>>.Write
	|
	|-RVA: 0x12F5D70 Offset: 0x12F4F70 VA: 0x1812F5D70
	|-JsonResumableConverter<Nullable<UIntPtr>>.Write
	|
	|-RVA: 0x12F4860 Offset: 0x12F3A60 VA: 0x1812F4860
	|-JsonResumableConverter<bool>.Write
	|
	|-RVA: 0x12F52E0 Offset: 0x12F44E0 VA: 0x1812F52E0
	|-JsonResumableConverter<byte>.Write
	|
	|-RVA: 0x12F4560 Offset: 0x12F3760 VA: 0x1812F4560
	|-JsonResumableConverter<char>.Write
	|
	|-RVA: 0x12F40E0 Offset: 0x12F32E0 VA: 0x1812F40E0
	|-JsonResumableConverter<DateTime>.Write
	|
	|-RVA: 0x12F58F0 Offset: 0x12F4AF0 VA: 0x1812F58F0
	|-JsonResumableConverter<DateTimeOffset>.Write
	|
	|-RVA: 0x12F49E0 Offset: 0x12F3BE0 VA: 0x1812F49E0
	|-JsonResumableConverter<Decimal>.Write
	|
	|-RVA: 0x12F43E0 Offset: 0x12F35E0 VA: 0x1812F43E0
	|-JsonResumableConverter<double>.Write
	|
	|-RVA: 0x12F4FE0 Offset: 0x12F41E0 VA: 0x1812F4FE0
	|-JsonResumableConverter<Guid>.Write
	|
	|-RVA: 0x12F4260 Offset: 0x12F3460 VA: 0x1812F4260
	|-JsonResumableConverter<short>.Write
	|
	|-RVA: 0x12F5A70 Offset: 0x12F4C70 VA: 0x1812F5A70
	|-JsonResumableConverter<int>.Write
	|
	|-RVA: 0x12F5EF0 Offset: 0x12F50F0 VA: 0x1812F5EF0
	|-JsonResumableConverter<long>.Write
	|
	|-RVA: 0x12F5770 Offset: 0x12F4970 VA: 0x1812F5770
	|-JsonResumableConverter<IntPtr>.Write
	|
	|-RVA: 0x12F61F0 Offset: 0x12F53F0 VA: 0x1812F61F0
	|-JsonResumableConverter<JsonElement>.Write
	|
	|-RVA: 0x12F5160 Offset: 0x12F4360 VA: 0x1812F5160
	|-JsonResumableConverter<object>.Write
	|
	|-RVA: 0x12F5BF0 Offset: 0x12F4DF0 VA: 0x1812F5BF0
	|-JsonResumableConverter<sbyte>.Write
	|
	|-RVA: 0x12F46E0 Offset: 0x12F38E0 VA: 0x1812F46E0
	|-JsonResumableConverter<float>.Write
	|
	|-RVA: 0x12F6070 Offset: 0x12F5270 VA: 0x1812F6070
	|-JsonResumableConverter<ushort>.Write
	|
	|-RVA: 0x12F5460 Offset: 0x12F4660 VA: 0x1812F5460
	|-JsonResumableConverter<uint>.Write
	|
	|-RVA: 0x12F4B60 Offset: 0x12F3D60 VA: 0x1812F4B60
	|-JsonResumableConverter<ulong>.Write
	|
	|-RVA: 0x12F4CE0 Offset: 0x12F3EE0 VA: 0x1812F4CE0
	|-JsonResumableConverter<UIntPtr>.Write
	|
	|-RVA: 0x12F55E0 Offset: 0x12F47E0 VA: 0x1812F55E0
	|-JsonResumableConverter<__Il2CppFullySharedGenericType>.Write
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public sealed override bool get_HandleNull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-JsonResumableConverter<Nullable<IntPtr>>.get_HandleNull
	|-JsonResumableConverter<Nullable<UIntPtr>>.get_HandleNull
	|-JsonResumableConverter<bool>.get_HandleNull
	|-JsonResumableConverter<byte>.get_HandleNull
	|-JsonResumableConverter<char>.get_HandleNull
	|-JsonResumableConverter<DateTime>.get_HandleNull
	|-JsonResumableConverter<DateTimeOffset>.get_HandleNull
	|-JsonResumableConverter<Decimal>.get_HandleNull
	|-JsonResumableConverter<double>.get_HandleNull
	|-JsonResumableConverter<Guid>.get_HandleNull
	|-JsonResumableConverter<short>.get_HandleNull
	|-JsonResumableConverter<int>.get_HandleNull
	|-JsonResumableConverter<long>.get_HandleNull
	|-JsonResumableConverter<IntPtr>.get_HandleNull
	|-JsonResumableConverter<JsonElement>.get_HandleNull
	|-JsonResumableConverter<object>.get_HandleNull
	|-JsonResumableConverter<sbyte>.get_HandleNull
	|-JsonResumableConverter<float>.get_HandleNull
	|-JsonResumableConverter<ushort>.get_HandleNull
	|-JsonResumableConverter<uint>.get_HandleNull
	|-JsonResumableConverter<ulong>.get_HandleNull
	|-JsonResumableConverter<UIntPtr>.get_HandleNull
	|-JsonResumableConverter<__Il2CppFullySharedGenericType>.get_HandleNull
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F6430 Offset: 0x12F5630 VA: 0x1812F6430
	|-JsonResumableConverter<Nullable<IntPtr>>..ctor
	|
	|-RVA: 0x12F6550 Offset: 0x12F5750 VA: 0x1812F6550
	|-JsonResumableConverter<Nullable<UIntPtr>>..ctor
	|
	|-RVA: 0x12F6450 Offset: 0x12F5650 VA: 0x1812F6450
	|-JsonResumableConverter<bool>..ctor
	|
	|-RVA: 0x12F64D0 Offset: 0x12F56D0 VA: 0x1812F64D0
	|-JsonResumableConverter<byte>..ctor
	|
	|-RVA: 0x12F6530 Offset: 0x12F5730 VA: 0x1812F6530
	|-JsonResumableConverter<char>..ctor
	|
	|-RVA: 0x12F6370 Offset: 0x12F5570 VA: 0x1812F6370
	|-JsonResumableConverter<DateTime>..ctor
	|
	|-RVA: 0x12F6470 Offset: 0x12F5670 VA: 0x1812F6470
	|-JsonResumableConverter<DateTimeOffset>..ctor
	|
	|-RVA: 0x12F63D0 Offset: 0x12F55D0 VA: 0x1812F63D0
	|-JsonResumableConverter<Decimal>..ctor
	|
	|-RVA: 0x12F6490 Offset: 0x12F5690 VA: 0x1812F6490
	|-JsonResumableConverter<double>..ctor
	|
	|-RVA: 0x12F63B0 Offset: 0x12F55B0 VA: 0x1812F63B0
	|-JsonResumableConverter<Guid>..ctor
	|
	|-RVA: 0x12F6390 Offset: 0x12F5590 VA: 0x1812F6390
	|-JsonResumableConverter<short>..ctor
	|
	|-RVA: 0x12F65F0 Offset: 0x12F57F0 VA: 0x1812F65F0
	|-JsonResumableConverter<int>..ctor
	|
	|-RVA: 0x12F64F0 Offset: 0x12F56F0 VA: 0x1812F64F0
	|-JsonResumableConverter<long>..ctor
	|
	|-RVA: 0x12F6510 Offset: 0x12F5710 VA: 0x1812F6510
	|-JsonResumableConverter<IntPtr>..ctor
	|
	|-RVA: 0x12F63F0 Offset: 0x12F55F0 VA: 0x1812F63F0
	|-JsonResumableConverter<JsonElement>..ctor
	|
	|-RVA: 0x12F65B0 Offset: 0x12F57B0 VA: 0x1812F65B0
	|-JsonResumableConverter<object>..ctor
	|
	|-RVA: 0x12F6590 Offset: 0x12F5790 VA: 0x1812F6590
	|-JsonResumableConverter<sbyte>..ctor
	|
	|-RVA: 0x12F64B0 Offset: 0x12F56B0 VA: 0x1812F64B0
	|-JsonResumableConverter<float>..ctor
	|
	|-RVA: 0x12F65D0 Offset: 0x12F57D0 VA: 0x1812F65D0
	|-JsonResumableConverter<ushort>..ctor
	|
	|-RVA: 0x12F6570 Offset: 0x12F5770 VA: 0x1812F6570
	|-JsonResumableConverter<uint>..ctor
	|
	|-RVA: 0x12F6610 Offset: 0x12F5810 VA: 0x1812F6610
	|-JsonResumableConverter<ulong>..ctor
	|
	|-RVA: 0x12F6410 Offset: 0x12F5610 VA: 0x1812F6410
	|-JsonResumableConverter<UIntPtr>..ctor
	|
	|-RVA: 0xB615F0 Offset: 0xB607F0 VA: 0x180B615F0
	|-JsonResumableConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization
internal sealed class PreserveReferenceHandler : ReferenceHandler // TypeDefIndex: 15928
{
	// Methods

	// RVA: 0x1C3A1C0 Offset: 0x1C393C0 VA: 0x181C3A1C0 Slot: 4
	public override ReferenceResolver CreateResolver() { }

	// RVA: 0x1C3A060 Offset: 0x1C39260 VA: 0x181C3A060 Slot: 5
	internal override ReferenceResolver CreateResolver(bool writing) { }

	// RVA: 0x1C3A200 Offset: 0x1C39400 VA: 0x181C3A200
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization
internal sealed class PreserveReferenceResolver : ReferenceResolver // TypeDefIndex: 15929
{
	// Fields
	private uint _referenceCount; // 0x10
	private readonly Dictionary<string, object> _referenceIdToObjectMap; // 0x18
	private readonly Dictionary<object, string> _objectToReferenceIdMap; // 0x20

	// Methods

	// RVA: 0x1C3A420 Offset: 0x1C39620 VA: 0x181C3A420
	public void .ctor(bool writing) { }

	// RVA: 0x1C3A250 Offset: 0x1C39450 VA: 0x181C3A250 Slot: 4
	public override void AddReference(string referenceId, object value) { }

	// RVA: 0x1C3A2E0 Offset: 0x1C394E0 VA: 0x181C3A2E0 Slot: 5
	public override string GetReference(object value, out bool alreadyExists) { }

	// RVA: 0x1C3A3A0 Offset: 0x1C395A0 VA: 0x181C3A3A0 Slot: 6
	public override object ResolveReference(string referenceId) { }
}

// Namespace: System.Text.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal abstract class ReferenceHandler // TypeDefIndex: 15930
{
	// Fields
	[CompilerGenerated]
	private static readonly ReferenceHandler <Preserve>k__BackingField; // 0x0

	// Properties
	public static ReferenceHandler Preserve { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C3A5E0 Offset: 0x1C397E0 VA: 0x181C3A5E0
	public static ReferenceHandler get_Preserve() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ReferenceResolver CreateResolver();

	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170 Slot: 5
	internal virtual ReferenceResolver CreateResolver(bool writing) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x1C3A550 Offset: 0x1C39750 VA: 0x181C3A550
	private static void .cctor() { }
}

// Namespace: System.Text.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal abstract class ReferenceResolver // TypeDefIndex: 15931
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddReference(string referenceId, object value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string GetReference(object value, out bool alreadyExists);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object ResolveReference(string referenceId);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionMemberAccessor.<>c__DisplayClass0_0 // TypeDefIndex: 15932
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C3B3D0 Offset: 0x1C3A5D0 VA: 0x181C3B3D0
	internal object <CreateConstructor>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionMemberAccessor.<>c__DisplayClass1_0<T> // TypeDefIndex: 15933
{
	// Fields
	public int parameterCount; // 0x0
	public ConstructorInfo constructor; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ReflectionMemberAccessor.<>c__DisplayClass1_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T <CreateParameterizedConstructor>b__0(object[] arguments) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0A530 Offset: 0xB09730 VA: 0x180B0A530
	|-ReflectionMemberAccessor.<>c__DisplayClass1_0<__Il2CppFullySharedGenericType>.<CreateParameterizedConstructor>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionMemberAccessor.<>c__DisplayClass2_0<T, TArg0, TArg1, TArg2, TArg3> // TypeDefIndex: 15934
{
	// Fields
	public int parameterCount; // 0x0
	public ConstructorInfo constructor; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ReflectionMemberAccessor.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T <CreateParameterizedConstructor>b__0(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0C6C0 Offset: 0xB0B8C0 VA: 0x180B0C6C0
	|-ReflectionMemberAccessor.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateParameterizedConstructor>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionMemberAccessor.<>c__DisplayClass3_0<TCollection> // TypeDefIndex: 15935
{
	// Fields
	public MethodInfo addMethod; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ReflectionMemberAccessor.<>c__DisplayClass3_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateAddMethodDelegate>b__0(TCollection collection, object element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0DFF0 Offset: 0xB0D1F0 VA: 0x180B0DFF0
	|-ReflectionMemberAccessor.<>c__DisplayClass3_0<__Il2CppFullySharedGenericType>.<CreateAddMethodDelegate>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionMemberAccessor.<>c__DisplayClass6_0<TProperty> // TypeDefIndex: 15936
{
	// Fields
	public MethodInfo getMethodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<Nullable<IntPtr>>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<Nullable<UIntPtr>>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<bool>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<byte>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<char>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<DateTime>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<DateTimeOffset>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<Decimal>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<double>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<Guid>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<short>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<int>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<long>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<IntPtr>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<JsonElement>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<object>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<sbyte>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<float>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<ushort>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<uint>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<ulong>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<UIntPtr>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TProperty <CreatePropertyGetter>b__0(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB10000 Offset: 0xB0F200 VA: 0x180B10000
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<Nullable<IntPtr>>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<Nullable<UIntPtr>>.<CreatePropertyGetter>b__0
	|
	|-RVA: 0xB0FCE0 Offset: 0xB0EEE0 VA: 0x180B0FCE0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<bool>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<byte>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<sbyte>.<CreatePropertyGetter>b__0
	|
	|-RVA: 0xB0FE60 Offset: 0xB0F060 VA: 0x180B0FE60
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<char>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<short>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<ushort>.<CreatePropertyGetter>b__0
	|
	|-RVA: 0xB0FC60 Offset: 0xB0EE60 VA: 0x180B0FC60
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<DateTime>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<long>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<IntPtr>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<ulong>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<UIntPtr>.<CreatePropertyGetter>b__0
	|
	|-RVA: 0xB0FEE0 Offset: 0xB0F0E0 VA: 0x180B0FEE0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<DateTimeOffset>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<Decimal>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<Guid>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<JsonElement>.<CreatePropertyGetter>b__0
	|
	|-RVA: 0xB0FF80 Offset: 0xB0F180 VA: 0x180B0FF80
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<double>.<CreatePropertyGetter>b__0
	|
	|-RVA: 0xB0FD60 Offset: 0xB0EF60 VA: 0x180B0FD60
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<int>.<CreatePropertyGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<uint>.<CreatePropertyGetter>b__0
	|
	|-RVA: 0xB0FBE0 Offset: 0xB0EDE0 VA: 0x180B0FBE0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<object>.<CreatePropertyGetter>b__0
	|
	|-RVA: 0xB0FDE0 Offset: 0xB0EFE0 VA: 0x180B0FDE0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<float>.<CreatePropertyGetter>b__0
	|
	|-RVA: 0xB100C0 Offset: 0xB0F2C0 VA: 0x180B100C0
	|-ReflectionMemberAccessor.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>.<CreatePropertyGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionMemberAccessor.<>c__DisplayClass7_0<TProperty> // TypeDefIndex: 15937
{
	// Fields
	public MethodInfo setMethodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<Nullable<IntPtr>>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<Nullable<UIntPtr>>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<bool>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<byte>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<char>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<DateTime>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<DateTimeOffset>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<Decimal>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<double>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<Guid>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<short>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<int>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<long>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<IntPtr>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<JsonElement>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<object>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<sbyte>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<float>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<ushort>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<uint>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<ulong>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<UIntPtr>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreatePropertySetter>b__0(object obj, TProperty value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB112A0 Offset: 0xB104A0 VA: 0x180B112A0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<Nullable<IntPtr>>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB10900 Offset: 0xB0FB00 VA: 0x180B10900
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<Nullable<UIntPtr>>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB10640 Offset: 0xB0F840 VA: 0x180B10640
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<bool>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB11B00 Offset: 0xB10D00 VA: 0x180B11B00
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<byte>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB111B0 Offset: 0xB103B0 VA: 0x180B111B0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<char>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB10730 Offset: 0xB0F930 VA: 0x180B10730
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<DateTime>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB110B0 Offset: 0xB102B0 VA: 0x180B110B0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<DateTimeOffset>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB10EB0 Offset: 0xB100B0 VA: 0x180B10EB0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<Decimal>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB10AF0 Offset: 0xB0FCF0 VA: 0x180B10AF0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<double>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB10FB0 Offset: 0xB101B0 VA: 0x180B10FB0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<Guid>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB10A00 Offset: 0xB0FC00 VA: 0x180B10A00
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<short>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB10DD0 Offset: 0xB0FFD0 VA: 0x180B10DD0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<int>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB11620 Offset: 0xB10820 VA: 0x180B11620
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<long>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB11700 Offset: 0xB10900 VA: 0x180B11700
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<IntPtr>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB10BE0 Offset: 0xB0FDE0 VA: 0x180B10BE0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<JsonElement>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB11480 Offset: 0xB10680 VA: 0x180B11480
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<object>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB10810 Offset: 0xB0FA10 VA: 0x180B10810
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<sbyte>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB11A10 Offset: 0xB10C10 VA: 0x180B11A10
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<float>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB10CE0 Offset: 0xB0FEE0 VA: 0x180B10CE0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<ushort>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB117E0 Offset: 0xB109E0 VA: 0x180B117E0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<uint>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB113A0 Offset: 0xB105A0 VA: 0x180B113A0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<ulong>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB11540 Offset: 0xB10740 VA: 0x180B11540
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<UIntPtr>.<CreatePropertySetter>b__0
	|
	|-RVA: 0xB118C0 Offset: 0xB10AC0 VA: 0x180B118C0
	|-ReflectionMemberAccessor.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>.<CreatePropertySetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionMemberAccessor.<>c__DisplayClass8_0<TProperty> // TypeDefIndex: 15938
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<Nullable<IntPtr>>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<Nullable<UIntPtr>>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<bool>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<byte>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<char>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<DateTime>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<DateTimeOffset>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<Decimal>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<double>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<Guid>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<short>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<int>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<long>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<IntPtr>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<JsonElement>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<object>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<sbyte>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<float>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<ushort>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<uint>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<ulong>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<UIntPtr>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TProperty <CreateFieldGetter>b__0(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB12570 Offset: 0xB11770 VA: 0x180B12570
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<Nullable<IntPtr>>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<Nullable<UIntPtr>>.<CreateFieldGetter>b__0
	|
	|-RVA: 0xB129A0 Offset: 0xB11BA0 VA: 0x180B129A0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<bool>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<byte>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<sbyte>.<CreateFieldGetter>b__0
	|
	|-RVA: 0xB124E0 Offset: 0xB116E0 VA: 0x180B124E0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<char>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<short>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<ushort>.<CreateFieldGetter>b__0
	|
	|-RVA: 0xB12760 Offset: 0xB11960 VA: 0x180B12760
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<DateTime>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<long>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<IntPtr>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<ulong>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<UIntPtr>.<CreateFieldGetter>b__0
	|
	|-RVA: 0xB126C0 Offset: 0xB118C0 VA: 0x180B126C0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<DateTimeOffset>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<Decimal>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<Guid>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<JsonElement>.<CreateFieldGetter>b__0
	|
	|-RVA: 0xB12880 Offset: 0xB11A80 VA: 0x180B12880
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<double>.<CreateFieldGetter>b__0
	|
	|-RVA: 0xB127F0 Offset: 0xB119F0 VA: 0x180B127F0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<int>.<CreateFieldGetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<uint>.<CreateFieldGetter>b__0
	|
	|-RVA: 0xB12630 Offset: 0xB11830 VA: 0x180B12630
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<object>.<CreateFieldGetter>b__0
	|
	|-RVA: 0xB12910 Offset: 0xB11B10 VA: 0x180B12910
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<float>.<CreateFieldGetter>b__0
	|
	|-RVA: 0xB12A30 Offset: 0xB11C30 VA: 0x180B12A30
	|-ReflectionMemberAccessor.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType>.<CreateFieldGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionMemberAccessor.<>c__DisplayClass9_0<TProperty> // TypeDefIndex: 15939
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<Nullable<IntPtr>>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<Nullable<UIntPtr>>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<bool>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<byte>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<char>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<DateTime>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<DateTimeOffset>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<Decimal>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<double>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<Guid>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<short>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<int>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<long>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<IntPtr>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<JsonElement>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<object>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<sbyte>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<float>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<ushort>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<uint>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<ulong>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<UIntPtr>..ctor
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateFieldSetter>b__0(object obj, TProperty value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB13E00 Offset: 0xB13000 VA: 0x180B13E00
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<Nullable<IntPtr>>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<Nullable<UIntPtr>>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<DateTimeOffset>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<Decimal>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<Guid>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<JsonElement>.<CreateFieldSetter>b__0
	|
	|-RVA: 0xB13D40 Offset: 0xB12F40 VA: 0x180B13D40
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<bool>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<byte>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<sbyte>.<CreateFieldSetter>b__0
	|
	|-RVA: 0xB13F30 Offset: 0xB13130 VA: 0x180B13F30
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<char>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<short>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<ushort>.<CreateFieldSetter>b__0
	|
	|-RVA: 0xB13DA0 Offset: 0xB12FA0 VA: 0x180B13DA0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<DateTime>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<long>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<IntPtr>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<ulong>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<UIntPtr>.<CreateFieldSetter>b__0
	|
	|-RVA: 0xB13F90 Offset: 0xB13190 VA: 0x180B13F90
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<double>.<CreateFieldSetter>b__0
	|
	|-RVA: 0xB13FF0 Offset: 0xB131F0 VA: 0x180B13FF0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<int>.<CreateFieldSetter>b__0
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<uint>.<CreateFieldSetter>b__0
	|
	|-RVA: 0xB12B00 Offset: 0xB11D00 VA: 0x180B12B00
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<object>.<CreateFieldSetter>b__0
	|
	|-RVA: 0xB14050 Offset: 0xB13250 VA: 0x180B14050
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<float>.<CreateFieldSetter>b__0
	|
	|-RVA: 0xB13E60 Offset: 0xB13060 VA: 0x180B13E60
	|-ReflectionMemberAccessor.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>.<CreateFieldSetter>b__0
	*/
}

// Namespace: System.Text.Json.Serialization
internal sealed class ReflectionMemberAccessor : MemberAccessor // TypeDefIndex: 15940
{
	// Methods

	// RVA: 0x1C3A630 Offset: 0x1C39830 VA: 0x181C3A630 Slot: 4
	public override JsonClassInfo.ConstructorDelegate CreateConstructor(Type type) { }

	// RVA: -1 Offset: -1 Slot: 5
	public override JsonClassInfo.ParameterizedConstructorDelegate<T> CreateParameterizedConstructor<T>(ConstructorInfo constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA62020 Offset: 0xA61220 VA: 0x180A62020
	|-ReflectionMemberAccessor.CreateParameterizedConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override JsonClassInfo.ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3> CreateParameterizedConstructor<T, TArg0, TArg1, TArg2, TArg3>(ConstructorInfo constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA61F00 Offset: 0xA61100 VA: 0x180A61F00
	|-ReflectionMemberAccessor.CreateParameterizedConstructor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Action<TCollection, object> CreateAddMethodDelegate<TCollection>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA60D30 Offset: 0xA5FF30 VA: 0x180A60D30
	|-ReflectionMemberAccessor.CreateAddMethodDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override Func<IEnumerable<TElement>, TCollection> CreateImmutableEnumerableCreateRangeDelegate<TCollection, TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA61DF0 Offset: 0xA60FF0 VA: 0x180A61DF0
	|-ReflectionMemberAccessor.CreateImmutableEnumerableCreateRangeDelegate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override Func<IEnumerable<KeyValuePair<TKey, TValue>>, TCollection> CreateImmutableDictionaryCreateRangeDelegate<TCollection, TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA61CD0 Offset: 0xA60ED0 VA: 0x180A61CD0
	|-ReflectionMemberAccessor.CreateImmutableDictionaryCreateRangeDelegate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override Func<object, TProperty> CreatePropertyGetter<TProperty>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA623D0 Offset: 0xA615D0 VA: 0x180A623D0
	|-ReflectionMemberAccessor.CreatePropertyGetter<Nullable<IntPtr>>
	|-ReflectionMemberAccessor.CreatePropertyGetter<Nullable<UIntPtr>>
	|-ReflectionMemberAccessor.CreatePropertyGetter<DateTimeOffset>
	|-ReflectionMemberAccessor.CreatePropertyGetter<Decimal>
	|-ReflectionMemberAccessor.CreatePropertyGetter<Guid>
	|-ReflectionMemberAccessor.CreatePropertyGetter<JsonElement>
	|
	|-RVA: 0xA62160 Offset: 0xA61360 VA: 0x180A62160
	|-ReflectionMemberAccessor.CreatePropertyGetter<bool>
	|-ReflectionMemberAccessor.CreatePropertyGetter<sbyte>
	|
	|-RVA: 0xA62230 Offset: 0xA61430 VA: 0x180A62230
	|-ReflectionMemberAccessor.CreatePropertyGetter<byte>
	|
	|-RVA: 0xA62300 Offset: 0xA61500 VA: 0x180A62300
	|-ReflectionMemberAccessor.CreatePropertyGetter<char>
	|-ReflectionMemberAccessor.CreatePropertyGetter<short>
	|-ReflectionMemberAccessor.CreatePropertyGetter<ushort>
	|
	|-RVA: 0xA624A0 Offset: 0xA616A0 VA: 0x180A624A0
	|-ReflectionMemberAccessor.CreatePropertyGetter<DateTime>
	|-ReflectionMemberAccessor.CreatePropertyGetter<object>
	|
	|-RVA: 0xA62570 Offset: 0xA61770 VA: 0x180A62570
	|-ReflectionMemberAccessor.CreatePropertyGetter<double>
	|-ReflectionMemberAccessor.CreatePropertyGetter<float>
	|
	|-RVA: 0xA62640 Offset: 0xA61840 VA: 0x180A62640
	|-ReflectionMemberAccessor.CreatePropertyGetter<int>
	|
	|-RVA: 0xA627F0 Offset: 0xA619F0 VA: 0x180A627F0
	|-ReflectionMemberAccessor.CreatePropertyGetter<long>
	|-ReflectionMemberAccessor.CreatePropertyGetter<IntPtr>
	|-ReflectionMemberAccessor.CreatePropertyGetter<ulong>
	|-ReflectionMemberAccessor.CreatePropertyGetter<UIntPtr>
	|
	|-RVA: 0xA628C0 Offset: 0xA61AC0 VA: 0x180A628C0
	|-ReflectionMemberAccessor.CreatePropertyGetter<uint>
	|
	|-RVA: 0xA62710 Offset: 0xA61910 VA: 0x180A62710
	|-ReflectionMemberAccessor.CreatePropertyGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Action<object, TProperty> CreatePropertySetter<TProperty>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA62B30 Offset: 0xA61D30 VA: 0x180A62B30
	|-ReflectionMemberAccessor.CreatePropertySetter<Nullable<IntPtr>>
	|-ReflectionMemberAccessor.CreatePropertySetter<Nullable<UIntPtr>>
	|-ReflectionMemberAccessor.CreatePropertySetter<DateTimeOffset>
	|-ReflectionMemberAccessor.CreatePropertySetter<Decimal>
	|-ReflectionMemberAccessor.CreatePropertySetter<Guid>
	|-ReflectionMemberAccessor.CreatePropertySetter<JsonElement>
	|
	|-RVA: 0xA62990 Offset: 0xA61B90 VA: 0x180A62990
	|-ReflectionMemberAccessor.CreatePropertySetter<bool>
	|-ReflectionMemberAccessor.CreatePropertySetter<byte>
	|-ReflectionMemberAccessor.CreatePropertySetter<sbyte>
	|
	|-RVA: 0xA62A60 Offset: 0xA61C60 VA: 0x180A62A60
	|-ReflectionMemberAccessor.CreatePropertySetter<char>
	|-ReflectionMemberAccessor.CreatePropertySetter<short>
	|-ReflectionMemberAccessor.CreatePropertySetter<ushort>
	|
	|-RVA: 0xA62C00 Offset: 0xA61E00 VA: 0x180A62C00
	|-ReflectionMemberAccessor.CreatePropertySetter<DateTime>
	|
	|-RVA: 0xA62CD0 Offset: 0xA61ED0 VA: 0x180A62CD0
	|-ReflectionMemberAccessor.CreatePropertySetter<double>
	|-ReflectionMemberAccessor.CreatePropertySetter<float>
	|
	|-RVA: 0xA62E80 Offset: 0xA62080 VA: 0x180A62E80
	|-ReflectionMemberAccessor.CreatePropertySetter<int>
	|
	|-RVA: 0xA62F50 Offset: 0xA62150 VA: 0x180A62F50
	|-ReflectionMemberAccessor.CreatePropertySetter<long>
	|-ReflectionMemberAccessor.CreatePropertySetter<IntPtr>
	|-ReflectionMemberAccessor.CreatePropertySetter<ulong>
	|-ReflectionMemberAccessor.CreatePropertySetter<UIntPtr>
	|
	|-RVA: 0xA63020 Offset: 0xA62220 VA: 0x180A63020
	|-ReflectionMemberAccessor.CreatePropertySetter<object>
	|
	|-RVA: 0xA630F0 Offset: 0xA622F0 VA: 0x180A630F0
	|-ReflectionMemberAccessor.CreatePropertySetter<uint>
	|
	|-RVA: 0xA62DA0 Offset: 0xA61FA0 VA: 0x180A62DA0
	|-ReflectionMemberAccessor.CreatePropertySetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override Func<object, TProperty> CreateFieldGetter<TProperty>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA610D0 Offset: 0xA602D0 VA: 0x180A610D0
	|-ReflectionMemberAccessor.CreateFieldGetter<Nullable<IntPtr>>
	|-ReflectionMemberAccessor.CreateFieldGetter<Nullable<UIntPtr>>
	|-ReflectionMemberAccessor.CreateFieldGetter<DateTimeOffset>
	|-ReflectionMemberAccessor.CreateFieldGetter<Decimal>
	|-ReflectionMemberAccessor.CreateFieldGetter<Guid>
	|-ReflectionMemberAccessor.CreateFieldGetter<JsonElement>
	|
	|-RVA: 0xA60E90 Offset: 0xA60090 VA: 0x180A60E90
	|-ReflectionMemberAccessor.CreateFieldGetter<bool>
	|-ReflectionMemberAccessor.CreateFieldGetter<sbyte>
	|
	|-RVA: 0xA60F50 Offset: 0xA60150 VA: 0x180A60F50
	|-ReflectionMemberAccessor.CreateFieldGetter<byte>
	|
	|-RVA: 0xA61010 Offset: 0xA60210 VA: 0x180A61010
	|-ReflectionMemberAccessor.CreateFieldGetter<char>
	|-ReflectionMemberAccessor.CreateFieldGetter<short>
	|-ReflectionMemberAccessor.CreateFieldGetter<ushort>
	|
	|-RVA: 0xA61190 Offset: 0xA60390 VA: 0x180A61190
	|-ReflectionMemberAccessor.CreateFieldGetter<DateTime>
	|-ReflectionMemberAccessor.CreateFieldGetter<object>
	|
	|-RVA: 0xA61250 Offset: 0xA60450 VA: 0x180A61250
	|-ReflectionMemberAccessor.CreateFieldGetter<double>
	|-ReflectionMemberAccessor.CreateFieldGetter<float>
	|
	|-RVA: 0xA613D0 Offset: 0xA605D0 VA: 0x180A613D0
	|-ReflectionMemberAccessor.CreateFieldGetter<int>
	|
	|-RVA: 0xA61490 Offset: 0xA60690 VA: 0x180A61490
	|-ReflectionMemberAccessor.CreateFieldGetter<long>
	|-ReflectionMemberAccessor.CreateFieldGetter<IntPtr>
	|-ReflectionMemberAccessor.CreateFieldGetter<ulong>
	|-ReflectionMemberAccessor.CreateFieldGetter<UIntPtr>
	|
	|-RVA: 0xA61550 Offset: 0xA60750 VA: 0x180A61550
	|-ReflectionMemberAccessor.CreateFieldGetter<uint>
	|
	|-RVA: 0xA61310 Offset: 0xA60510 VA: 0x180A61310
	|-ReflectionMemberAccessor.CreateFieldGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override Action<object, TProperty> CreateFieldSetter<TProperty>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA61790 Offset: 0xA60990 VA: 0x180A61790
	|-ReflectionMemberAccessor.CreateFieldSetter<Nullable<IntPtr>>
	|-ReflectionMemberAccessor.CreateFieldSetter<Nullable<UIntPtr>>
	|-ReflectionMemberAccessor.CreateFieldSetter<DateTimeOffset>
	|-ReflectionMemberAccessor.CreateFieldSetter<Decimal>
	|-ReflectionMemberAccessor.CreateFieldSetter<Guid>
	|-ReflectionMemberAccessor.CreateFieldSetter<JsonElement>
	|
	|-RVA: 0xA61610 Offset: 0xA60810 VA: 0x180A61610
	|-ReflectionMemberAccessor.CreateFieldSetter<bool>
	|-ReflectionMemberAccessor.CreateFieldSetter<byte>
	|-ReflectionMemberAccessor.CreateFieldSetter<sbyte>
	|
	|-RVA: 0xA616D0 Offset: 0xA608D0 VA: 0x180A616D0
	|-ReflectionMemberAccessor.CreateFieldSetter<char>
	|-ReflectionMemberAccessor.CreateFieldSetter<short>
	|-ReflectionMemberAccessor.CreateFieldSetter<ushort>
	|
	|-RVA: 0xA61850 Offset: 0xA60A50 VA: 0x180A61850
	|-ReflectionMemberAccessor.CreateFieldSetter<DateTime>
	|
	|-RVA: 0xA61910 Offset: 0xA60B10 VA: 0x180A61910
	|-ReflectionMemberAccessor.CreateFieldSetter<double>
	|-ReflectionMemberAccessor.CreateFieldSetter<float>
	|
	|-RVA: 0xA619D0 Offset: 0xA60BD0 VA: 0x180A619D0
	|-ReflectionMemberAccessor.CreateFieldSetter<int>
	|
	|-RVA: 0xA61A90 Offset: 0xA60C90 VA: 0x180A61A90
	|-ReflectionMemberAccessor.CreateFieldSetter<long>
	|-ReflectionMemberAccessor.CreateFieldSetter<IntPtr>
	|-ReflectionMemberAccessor.CreateFieldSetter<ulong>
	|-ReflectionMemberAccessor.CreateFieldSetter<UIntPtr>
	|
	|-RVA: 0xA61B50 Offset: 0xA60D50 VA: 0x180A61B50
	|-ReflectionMemberAccessor.CreateFieldSetter<object>
	|
	|-RVA: 0xA61C10 Offset: 0xA60E10 VA: 0x180A61C10
	|-ReflectionMemberAccessor.CreateFieldSetter<uint>
	|
	|-RVA: 0xA61310 Offset: 0xA60510 VA: 0x180A61310
	|-ReflectionMemberAccessor.CreateFieldSetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class ArrayConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> // TypeDefIndex: 15941
{
	// Properties
	internal override bool CanHaveIdMetadata { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	internal override bool get_CanHaveIdMetadata() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ArrayConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_CanHaveIdMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in TElement value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1266B40 Offset: 0x1265D40 VA: 0x181266B40
	|-ArrayConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1276630 Offset: 0x1275830 VA: 0x181276630
	|-ArrayConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override void ConvertCollection(ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8570 Offset: 0x12A7770 VA: 0x1812A8570
	|-ArrayConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ConvertCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8630 Offset: 0x12A7830 VA: 0x1812A8630
	|-ArrayConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB93480 Offset: 0xB92680 VA: 0x180B93480
	|-ArrayConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class ConcurrentQueueOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> // TypeDefIndex: 15942
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in TElement value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB92F20 Offset: 0xB92120 VA: 0x180B92F20
	|-ConcurrentQueueOfTConverter<object, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB93080 Offset: 0xB92280 VA: 0x180B93080
	|-ConcurrentQueueOfTConverter<object, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB03F0 Offset: 0xFAF5F0 VA: 0x180FB03F0
	|-ConcurrentQueueOfTConverter<object, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB0740 Offset: 0xFAF940 VA: 0x180FB0740
	|-ConcurrentQueueOfTConverter<object, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class ConcurrentStackOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> // TypeDefIndex: 15943
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in TElement value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB92F20 Offset: 0xB92120 VA: 0x180B92F20
	|-ConcurrentStackOfTConverter<object, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB93080 Offset: 0xB92280 VA: 0x180B93080
	|-ConcurrentStackOfTConverter<object, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB4080 Offset: 0xFB3280 VA: 0x180FB4080
	|-ConcurrentStackOfTConverter<object, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB0740 Offset: 0xFAF940 VA: 0x180FB0740
	|-ConcurrentStackOfTConverter<object, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private struct DictionaryDefaultConverter.<>c__DisplayClass12_0<TCollection, TKey, TValue> // TypeDefIndex: 15944
{
	// Fields
	public DictionaryDefaultConverter<TCollection, TKey, TValue> <>4__this; // 0x0
	public JsonSerializerOptions options; // 0x0
}

// Namespace: System.Text.Json.Serialization.Converters
internal abstract class DictionaryDefaultConverter<TCollection, TKey, TValue> : JsonDictionaryConverter<TCollection> // TypeDefIndex: 15945
{
	// Fields
	private static Type s_valueType; // 0x0
	protected Type KeyType; // 0x0
	protected bool IsStringKey; // 0x0
	protected JsonConverter<TKey> _keyConverter; // 0x0
	protected JsonConverter<TValue> _valueConverter; // 0x0

	// Properties
	internal override Type ElementType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract void Add(TKey key, in TValue value, JsonSerializerOptions options, ref ReadStack state);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected virtual void ConvertCollection(ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-DictionaryDefaultConverter<object, object, object>.ConvertCollection
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ConvertCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected virtual void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-DictionaryDefaultConverter<object, object, object>.CreateCollection
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 9
	internal override Type get_ElementType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC7430 Offset: 0xFC6630 VA: 0x180FC7430
	|-DictionaryDefaultConverter<object, object, object>.get_ElementType
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_ElementType
	*/

	// RVA: -1 Offset: -1
	protected static JsonConverter<TValue> GetValueConverter(JsonClassInfo elementClassInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC6490 Offset: 0xFC5690 VA: 0x180FC6490
	|-DictionaryDefaultConverter<object, object, object>.GetValueConverter
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValueConverter
	*/

	// RVA: -1 Offset: -1
	protected static JsonConverter<TKey> GetKeyConverter(Type keyType, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC63D0 Offset: 0xFC55D0 VA: 0x180FC63D0
	|-DictionaryDefaultConverter<object, object, object>.GetKeyConverter
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeyConverter
	*/

	// RVA: -1 Offset: -1 Slot: 22
	internal sealed override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, ref ReadStack state, out TCollection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC6560 Offset: 0xFC5760 VA: 0x180FC6560
	|-DictionaryDefaultConverter<object, object, object>.OnTryRead
	|
	|-RVA: 0xFC7510 Offset: 0xFC6710 VA: 0x180FC7510
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnTryRead
	*/

	// RVA: -1 Offset: -1 Slot: 21
	internal sealed override bool OnTryWrite(Utf8JsonWriter writer, TCollection dictionary, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC6F10 Offset: 0xFC6110 VA: 0x180FC6F10
	|-DictionaryDefaultConverter<object, object, object>.OnTryWrite
	|
	|-RVA: 0xFC8190 Offset: 0xFC7390 VA: 0x180FC8190
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnTryWrite
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal sealed override void CreateInstanceForReferenceResolver(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC63B0 Offset: 0xFC55B0 VA: 0x180FC63B0
	|-DictionaryDefaultConverter<object, object, object>.CreateInstanceForReferenceResolver
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateInstanceForReferenceResolver
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC7350 Offset: 0xFC6550 VA: 0x180FC7350
	|-DictionaryDefaultConverter<object, object, object>..ctor
	|
	|-RVA: 0xFC8720 Offset: 0xFC7920 VA: 0x180FC8720
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC7260 Offset: 0xFC6460 VA: 0x180FC7260
	|-DictionaryDefaultConverter<object, object, object>..cctor
	|
	|-RVA: 0xFC8630 Offset: 0xFC7830 VA: 0x180FC8630
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private TKey <OnTryRead>g__ReadDictionaryKey|12_0(ref Utf8JsonReader reader, ref ReadStack state, ref DictionaryDefaultConverter.<>c__DisplayClass12_0<TCollection, TKey, TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC7080 Offset: 0xFC6280 VA: 0x180FC7080
	|-DictionaryDefaultConverter<object, object, object>.<OnTryRead>g__ReadDictionaryKey|12_0
	|
	|-RVA: 0xFC8440 Offset: 0xFC7640 VA: 0x180FC8440
	|-DictionaryDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<OnTryRead>g__ReadDictionaryKey|12_0
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class DictionaryOfTKeyTValueConverter<TCollection, TKey, TValue> : DictionaryDefaultConverter<TCollection, TKey, TValue> // TypeDefIndex: 15946
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 30
	protected override void Add(TKey key, in TValue value, JsonSerializerOptions options, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCD0E0 Offset: 0xFCC2E0 VA: 0x180FCD0E0
	|-DictionaryOfTKeyTValueConverter<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB93080 Offset: 0xB92280 VA: 0x180B93080
	|-DictionaryOfTKeyTValueConverter<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected internal override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCD2D0 Offset: 0xFCC4D0 VA: 0x180FCD2D0
	|-DictionaryOfTKeyTValueConverter<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCDBE0 Offset: 0xFCCDE0 VA: 0x180FCDBE0
	|-DictionaryOfTKeyTValueConverter<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class ICollectionOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> // TypeDefIndex: 15947
{
	// Properties
	internal override Type RuntimeType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in TElement value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1261A10 Offset: 0x1260C10 VA: 0x181261A10
	|-ICollectionOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1261BF0 Offset: 0x1260DF0 VA: 0x181261BF0
	|-ICollectionOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1261F60 Offset: 0x1261160 VA: 0x181261F60
	|-ICollectionOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override Type get_RuntimeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1262350 Offset: 0x1261550 VA: 0x181262350
	|-ICollectionOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_RuntimeType
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1262330 Offset: 0x1261530 VA: 0x181262330
	|-ICollectionOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class IDictionaryConverter<TCollection> : DictionaryDefaultConverter<TCollection, string, object> // TypeDefIndex: 15948
{
	// Fields
	private JsonConverter<object> _objectConverter; // 0x0

	// Properties
	internal override Type RuntimeType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 30
	protected override void Add(string key, in object value, JsonSerializerOptions options, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1262440 Offset: 0x1261640 VA: 0x181262440
	|-IDictionaryConverter<object>.Add
	|
	|-RVA: 0x1262500 Offset: 0x1261700 VA: 0x181262500
	|-IDictionaryConverter<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private static JsonConverter<object> GetObjectKeyConverter(JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1262B90 Offset: 0x1261D90 VA: 0x181262B90
	|-IDictionaryConverter<object>.GetObjectKeyConverter
	|
	|-RVA: 0x1262C80 Offset: 0x1261E80 VA: 0x181262C80
	|-IDictionaryConverter<__Il2CppFullySharedGenericType>.GetObjectKeyConverter
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12625C0 Offset: 0x12617C0 VA: 0x1812625C0
	|-IDictionaryConverter<object>.CreateCollection
	|
	|-RVA: 0x1262830 Offset: 0x1261A30 VA: 0x181262830
	|-IDictionaryConverter<__Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected internal override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1262D70 Offset: 0x1261F70 VA: 0x181262D70
	|-IDictionaryConverter<object>.OnWriteResume
	|
	|-RVA: 0x12632E0 Offset: 0x12624E0 VA: 0x1812632E0
	|-IDictionaryConverter<__Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override Type get_RuntimeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1263920 Offset: 0x1262B20 VA: 0x181263920
	|-IDictionaryConverter<object>.get_RuntimeType
	|
	|-RVA: 0x1263A00 Offset: 0x1262C00 VA: 0x181263A00
	|-IDictionaryConverter<__Il2CppFullySharedGenericType>.get_RuntimeType
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1263840 Offset: 0x1262A40 VA: 0x181263840
	|-IDictionaryConverter<object>..ctor
	|
	|-RVA: 0x12638B0 Offset: 0x1262AB0 VA: 0x1812638B0
	|-IDictionaryConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class IDictionaryOfTKeyTValueConverter<TCollection, TKey, TValue> : DictionaryDefaultConverter<TCollection, TKey, TValue> // TypeDefIndex: 15949
{
	// Properties
	internal override Type RuntimeType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 30
	protected override void Add(TKey key, in TValue value, JsonSerializerOptions options, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1263C30 Offset: 0x1262E30 VA: 0x181263C30
	|-IDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1263E90 Offset: 0x1263090 VA: 0x181263E90
	|-IDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected internal override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12641F0 Offset: 0x12633F0 VA: 0x1812641F0
	|-IDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override Type get_RuntimeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1264A40 Offset: 0x1263C40 VA: 0x181264A40
	|-IDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_RuntimeType
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12649D0 Offset: 0x1263BD0 VA: 0x1812649D0
	|-IDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class IEnumerableConverter<TCollection> : IEnumerableDefaultConverter<TCollection, object> // TypeDefIndex: 15950
{
	// Properties
	internal override Type RuntimeType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in object value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1264B90 Offset: 0x1263D90 VA: 0x181264B90
	|-IEnumerableConverter<object>.Add
	|
	|-RVA: 0x1264CE0 Offset: 0x1263EE0 VA: 0x181264CE0
	|-IEnumerableConverter<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1264E30 Offset: 0x1264030 VA: 0x181264E30
	|-IEnumerableConverter<object>.CreateCollection
	|
	|-RVA: 0x1264F40 Offset: 0x1264140 VA: 0x181264F40
	|-IEnumerableConverter<__Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1265340 Offset: 0x1264540 VA: 0x181265340
	|-IEnumerableConverter<object>.OnWriteResume
	|
	|-RVA: 0x1265050 Offset: 0x1264250 VA: 0x181265050
	|-IEnumerableConverter<__Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override Type get_RuntimeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1265640 Offset: 0x1264840 VA: 0x181265640
	|-IEnumerableConverter<object>.get_RuntimeType
	|
	|-RVA: 0x12655E0 Offset: 0x12647E0 VA: 0x1812655E0
	|-IEnumerableConverter<__Il2CppFullySharedGenericType>.get_RuntimeType
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12655B0 Offset: 0x12647B0 VA: 0x1812655B0
	|-IEnumerableConverter<object>..ctor
	|
	|-RVA: 0xCEA020 Offset: 0xCE9220 VA: 0x180CEA020
	|-IEnumerableConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal class IEnumerableConverterFactory : JsonConverterFactory // TypeDefIndex: 15951
{
	// Fields
	private static readonly IDictionaryConverter<IDictionary> s_converterForIDictionary; // 0x0
	private static readonly IEnumerableConverter<IEnumerable> s_converterForIEnumerable; // 0x8
	private static readonly IListConverter<IList> s_converterForIList; // 0x10

	// Methods

	// RVA: 0x1C373F0 Offset: 0x1C365F0 VA: 0x181C373F0 Slot: 4
	public override bool CanConvert(Type typeToConvert) { }

	// RVA: 0x1C37480 Offset: 0x1C36680 VA: 0x181C37480 Slot: 20
	public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C38350 Offset: 0x1C37550 VA: 0x181C38350
	private static void .cctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal abstract class IEnumerableDefaultConverter<TCollection, TElement> : JsonCollectionConverter<TCollection, TElement> // TypeDefIndex: 15952
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected abstract void Add(in TElement value, ref ReadStack state);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEnumerableDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEnumerableDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected virtual void ConvertCollection(ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-IEnumerableDefaultConverter<object, object>.ConvertCollection
	|-IEnumerableDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ConvertCollection
	*/

	// RVA: -1 Offset: -1
	protected static JsonConverter<TElement> GetElementConverter(JsonClassInfo elementClassInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1265790 Offset: 0x1264990 VA: 0x181265790
	|-IEnumerableDefaultConverter<object, object>.GetElementConverter
	|-IEnumerableDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetElementConverter
	*/

	// RVA: -1 Offset: -1
	protected static JsonConverter<TElement> GetElementConverter(ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12656C0 Offset: 0x12648C0 VA: 0x1812656C0
	|-IEnumerableDefaultConverter<object, object>.GetElementConverter
	|-IEnumerableDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetElementConverter
	*/

	// RVA: -1 Offset: -1 Slot: 22
	internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, ref ReadStack state, out TCollection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1265860 Offset: 0x1264A60 VA: 0x181265860
	|-IEnumerableDefaultConverter<object, object>.OnTryRead
	|
	|-RVA: 0x1265F60 Offset: 0x1265160 VA: 0x181265F60
	|-IEnumerableDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnTryRead
	*/

	// RVA: -1 Offset: -1 Slot: 21
	internal sealed override bool OnTryWrite(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1266980 Offset: 0x1265B80 VA: 0x181266980
	|-IEnumerableDefaultConverter<object, object>.OnTryWrite
	|
	|-RVA: 0x12666C0 Offset: 0x12658C0 VA: 0x1812666C0
	|-IEnumerableDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnTryWrite
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEnumerableDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal sealed override void CreateInstanceForReferenceResolver(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12656A0 Offset: 0x12648A0 VA: 0x1812656A0
	|-IEnumerableDefaultConverter<object, object>.CreateInstanceForReferenceResolver
	|-IEnumerableDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateInstanceForReferenceResolver
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1266B20 Offset: 0x1265D20 VA: 0x181266B20
	|-IEnumerableDefaultConverter<object, object>..ctor
	|
	|-RVA: 0x1266B00 Offset: 0x1265D00 VA: 0x181266B00
	|-IEnumerableDefaultConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class IEnumerableOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> // TypeDefIndex: 15953
{
	// Properties
	internal override Type RuntimeType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in TElement value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1266B40 Offset: 0x1265D40 VA: 0x181266B40
	|-IEnumerableOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1266CE0 Offset: 0x1265EE0 VA: 0x181266CE0
	|-IEnumerableOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1266DF0 Offset: 0x1265FF0 VA: 0x181266DF0
	|-IEnumerableOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override Type get_RuntimeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12671E0 Offset: 0x12663E0 VA: 0x1812671E0
	|-IEnumerableOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_RuntimeType
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12671C0 Offset: 0x12663C0 VA: 0x1812671C0
	|-IEnumerableOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class IEnumerableWithAddMethodConverter<TCollection> : IEnumerableDefaultConverter<TCollection, object> // TypeDefIndex: 15954
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in object value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1267240 Offset: 0x1266440 VA: 0x181267240
	|-IEnumerableWithAddMethodConverter<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12673B0 Offset: 0x12665B0 VA: 0x1812673B0
	|-IEnumerableWithAddMethodConverter<__Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12674B0 Offset: 0x12666B0 VA: 0x1812674B0
	|-IEnumerableWithAddMethodConverter<__Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12677A0 Offset: 0x12669A0 VA: 0x1812677A0
	|-IEnumerableWithAddMethodConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class IListConverter<TCollection> : IEnumerableDefaultConverter<TCollection, object> // TypeDefIndex: 15955
{
	// Properties
	internal override Type RuntimeType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in object value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1267870 Offset: 0x1266A70 VA: 0x181267870
	|-IListConverter<object>.Add
	|
	|-RVA: 0x12677C0 Offset: 0x12669C0 VA: 0x1812677C0
	|-IListConverter<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1267C80 Offset: 0x1266E80 VA: 0x181267C80
	|-IListConverter<object>.CreateCollection
	|
	|-RVA: 0x1267920 Offset: 0x1266B20 VA: 0x181267920
	|-IListConverter<__Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1267EF0 Offset: 0x12670F0 VA: 0x181267EF0
	|-IListConverter<object>.OnWriteResume
	|
	|-RVA: 0x12681C0 Offset: 0x12673C0 VA: 0x1812681C0
	|-IListConverter<__Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override Type get_RuntimeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12685D0 Offset: 0x12677D0 VA: 0x1812685D0
	|-IListConverter<object>.get_RuntimeType
	|
	|-RVA: 0x12684F0 Offset: 0x12676F0 VA: 0x1812684F0
	|-IListConverter<__Il2CppFullySharedGenericType>.get_RuntimeType
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12655B0 Offset: 0x12647B0 VA: 0x1812655B0
	|-IListConverter<object>..ctor
	|
	|-RVA: 0xCEA020 Offset: 0xCE9220 VA: 0x180CEA020
	|-IListConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class IListOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> // TypeDefIndex: 15956
{
	// Properties
	internal override Type RuntimeType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in TElement value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12686B0 Offset: 0x12678B0 VA: 0x1812686B0
	|-IListOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1268880 Offset: 0x1267A80 VA: 0x181268880
	|-IListOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1268BE0 Offset: 0x1267DE0 VA: 0x181268BE0
	|-IListOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override Type get_RuntimeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1268FB0 Offset: 0x12681B0 VA: 0x181268FB0
	|-IListOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_RuntimeType
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1262330 Offset: 0x1261530 VA: 0x181262330
	|-IListOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class ImmutableDictionaryOfTKeyTValueConverter<TCollection, TKey, TValue> : DictionaryDefaultConverter<TCollection, TKey, TValue> // TypeDefIndex: 15957
{
	// Properties
	internal override bool CanHaveIdMetadata { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 30
	protected override void Add(TKey key, in TValue value, JsonSerializerOptions options, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12690A0 Offset: 0x12682A0 VA: 0x1812690A0
	|-ImmutableDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override bool get_CanHaveIdMetadata() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ImmutableDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_CanHaveIdMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270810 Offset: 0x126FA10 VA: 0x181270810
	|-ImmutableDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override void ConvertCollection(ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270610 Offset: 0x126F810 VA: 0x181270610
	|-ImmutableDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ConvertCollection
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected internal override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270880 Offset: 0x126FA80 VA: 0x181270880
	|-ImmutableDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1271060 Offset: 0x1270260 VA: 0x181271060
	|-ImmutableDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class ImmutableEnumerableOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> // TypeDefIndex: 15958
{
	// Properties
	internal override bool CanHaveIdMetadata { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in TElement value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1266B40 Offset: 0x1265D40 VA: 0x181266B40
	|-ImmutableEnumerableOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override bool get_CanHaveIdMetadata() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ImmutableEnumerableOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_CanHaveIdMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1276630 Offset: 0x1275830 VA: 0x181276630
	|-ImmutableEnumerableOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override void ConvertCollection(ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1276430 Offset: 0x1275630 VA: 0x181276430
	|-ImmutableEnumerableOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ConvertCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12766A0 Offset: 0x12758A0 VA: 0x1812766A0
	|-ImmutableEnumerableOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1262330 Offset: 0x1261530 VA: 0x181262330
	|-ImmutableEnumerableOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class IReadOnlyDictionaryOfTKeyTValueConverter<TCollection, TKey, TValue> : DictionaryDefaultConverter<TCollection, TKey, TValue> // TypeDefIndex: 15959
{
	// Properties
	internal override Type RuntimeType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 30
	protected override void Add(TKey key, in TValue value, JsonSerializerOptions options, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12690A0 Offset: 0x12682A0 VA: 0x1812690A0
	|-IReadOnlyDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12692D0 Offset: 0x12684D0 VA: 0x1812692D0
	|-IReadOnlyDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected internal override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12693F0 Offset: 0x12685F0 VA: 0x1812693F0
	|-IReadOnlyDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override Type get_RuntimeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1269C40 Offset: 0x1268E40 VA: 0x181269C40
	|-IReadOnlyDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_RuntimeType
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1269BD0 Offset: 0x1268DD0 VA: 0x181269BD0
	|-IReadOnlyDictionaryOfTKeyTValueConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class ISetOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> // TypeDefIndex: 15960
{
	// Properties
	internal override Type RuntimeType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in TElement value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1269CA0 Offset: 0x1268EA0 VA: 0x181269CA0
	|-ISetOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1269E80 Offset: 0x1269080 VA: 0x181269E80
	|-ISetOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126A1E0 Offset: 0x12693E0 VA: 0x18126A1E0
	|-ISetOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override Type get_RuntimeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126A5D0 Offset: 0x12697D0 VA: 0x18126A5D0
	|-ISetOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_RuntimeType
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126A5B0 Offset: 0x12697B0 VA: 0x18126A5B0
	|-ISetOfTConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class ListOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> // TypeDefIndex: 15961
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in TElement value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB92F20 Offset: 0xB92120 VA: 0x180B92F20
	|-ListOfTConverter<object, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB93080 Offset: 0xB92280 VA: 0x180B93080
	|-ListOfTConverter<object, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C6E0 Offset: 0x132B8E0 VA: 0x18132C6E0
	|-ListOfTConverter<object, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB0740 Offset: 0xFAF940 VA: 0x180FB0740
	|-ListOfTConverter<object, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class QueueOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> // TypeDefIndex: 15962
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in TElement value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB92F20 Offset: 0xB92120 VA: 0x180B92F20
	|-QueueOfTConverter<object, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB93080 Offset: 0xB92280 VA: 0x180B93080
	|-QueueOfTConverter<object, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB930E0 Offset: 0xB922E0 VA: 0x180B930E0
	|-QueueOfTConverter<object, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB93480 Offset: 0xB92680 VA: 0x180B93480
	|-QueueOfTConverter<object, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class StackOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> // TypeDefIndex: 15963
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Add(in TElement value, ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB92F20 Offset: 0xB92120 VA: 0x180B92F20
	|-StackOfTConverter<object, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override void CreateCollection(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB93080 Offset: 0xB92280 VA: 0x180B93080
	|-StackOfTConverter<object, __Il2CppFullySharedGenericType>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3CC40 Offset: 0xC3BE40 VA: 0x180C3CC40
	|-StackOfTConverter<object, __Il2CppFullySharedGenericType>.OnWriteResume
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB93480 Offset: 0xB92680 VA: 0x180B93480
	|-StackOfTConverter<object, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class KeyValuePairConverter<TKey, TValue> : SmallObjectWithParameterizedConstructorConverter<KeyValuePair<TKey, TValue>, TKey, TValue, object, object> // TypeDefIndex: 15964
{
	// Fields
	private string _keyName; // 0x0
	private string _valueName; // 0x0
	private static readonly ConstructorInfo s_constructorInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 18
	internal override void Initialize(JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1311640 Offset: 0x1310840 VA: 0x181311640
	|-KeyValuePairConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool TryLookupConstructorParameter(ref ReadStack state, ref Utf8JsonReader reader, JsonSerializerOptions options, out JsonParameterInfo jsonParameterInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1311760 Offset: 0x1310960 VA: 0x181311760
	|-KeyValuePairConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryLookupConstructorParameter
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override void EndRead(ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13114D0 Offset: 0x13106D0 VA: 0x1813114D0
	|-KeyValuePairConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndRead
	*/

	// RVA: -1 Offset: -1
	private bool FoundKeyProperty(string propertyName, bool caseInsensitiveMatch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1311500 Offset: 0x1310700 VA: 0x181311500
	|-KeyValuePairConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FoundKeyProperty
	*/

	// RVA: -1 Offset: -1
	private bool FoundValueProperty(string propertyName, bool caseInsensitiveMatch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13115A0 Offset: 0x13107A0 VA: 0x1813115A0
	|-KeyValuePairConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FoundValueProperty
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12677A0 Offset: 0x12669A0 VA: 0x1812677A0
	|-KeyValuePairConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13118F0 Offset: 0x1310AF0 VA: 0x1813118F0
	|-KeyValuePairConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal class ObjectConverterFactory : JsonConverterFactory // TypeDefIndex: 15965
{
	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 4
	public override bool CanConvert(Type typeToConvert) { }

	// RVA: 0x1C39280 Offset: 0x1C38480 VA: 0x181C39280 Slot: 20
	public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C39CC0 Offset: 0x1C38EC0 VA: 0x181C39CC0
	private bool IsKeyValuePair(Type typeToConvert) { }

	// RVA: 0x1C397F0 Offset: 0x1C389F0 VA: 0x181C397F0
	private JsonConverter CreateKeyValuePairConverter(Type type, JsonSerializerOptions options) { }

	// RVA: 0x1C39A50 Offset: 0x1C38C50 VA: 0x181C39A50
	private ConstructorInfo GetDeserializationConstructor(Type type) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal class ObjectDefaultConverter<T> : JsonObjectConverter<T> // TypeDefIndex: 15966
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 22
	internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, ref ReadStack state, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB60B90 Offset: 0xB5FD90 VA: 0x180B60B90
	|-ObjectDefaultConverter<__Il2CppFullySharedGenericType>.OnTryRead
	*/

	// RVA: -1 Offset: -1 Slot: 21
	internal sealed override bool OnTryWrite(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB61100 Offset: 0xB60300 VA: 0x180B61100
	|-ObjectDefaultConverter<__Il2CppFullySharedGenericType>.OnTryWrite
	*/

	// RVA: -1 Offset: -1
	protected void ReadPropertyValue(object obj, ref ReadStack state, ref Utf8JsonReader reader, JsonPropertyInfo jsonPropertyInfo, bool useExtensionProperty) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB61510 Offset: 0xB60710 VA: 0x180B61510
	|-ObjectDefaultConverter<__Il2CppFullySharedGenericType>.ReadPropertyValue
	*/

	// RVA: -1 Offset: -1
	protected bool ReadAheadPropertyValue(ref ReadStack state, ref Utf8JsonReader reader, JsonPropertyInfo jsonPropertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB61430 Offset: 0xB60630 VA: 0x180B61430
	|-ObjectDefaultConverter<__Il2CppFullySharedGenericType>.ReadAheadPropertyValue
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal sealed override void CreateInstanceForReferenceResolver(ref Utf8JsonReader reader, ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB60B30 Offset: 0xB5FD30 VA: 0x180B60B30
	|-ObjectDefaultConverter<__Il2CppFullySharedGenericType>.CreateInstanceForReferenceResolver
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB615F0 Offset: 0xB607F0 VA: 0x180B615F0
	|-ObjectDefaultConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal abstract class ObjectWithParameterizedConstructorConverter<T> : ObjectDefaultConverter<T> // TypeDefIndex: 15967
{
	// Properties
	internal override bool ConstructorIsParameterized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 22
	internal sealed override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, ref ReadStack state, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB79240 Offset: 0xB78440 VA: 0x180B79240
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.OnTryRead
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected abstract void InitializeConstructorArgumentCaches(ref ReadStack state, JsonSerializerOptions options);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.InitializeConstructorArgumentCaches
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract bool ReadAndCacheConstructorArgument(ref ReadStack state, ref Utf8JsonReader reader, JsonParameterInfo jsonParameterInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.ReadAndCacheConstructorArgument
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected abstract object CreateObject(ref ReadStackFrame frame);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.CreateObject
	*/

	// RVA: -1 Offset: -1
	private void ReadConstructorArguments(ref ReadStack state, ref Utf8JsonReader reader, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB79BE0 Offset: 0xB78DE0 VA: 0x180B79BE0
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.ReadConstructorArguments
	*/

	// RVA: -1 Offset: -1
	private bool ReadConstructorArgumentsWithContinuation(ref ReadStack state, ref Utf8JsonReader reader, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB79A10 Offset: 0xB78C10 VA: 0x180B79A10
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.ReadConstructorArgumentsWithContinuation
	*/

	// RVA: -1 Offset: -1
	private bool HandleConstructorArgumentWithContinuation(ref ReadStack state, ref Utf8JsonReader reader, JsonParameterInfo jsonParameterInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB78E40 Offset: 0xB78040 VA: 0x180B78E40
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.HandleConstructorArgumentWithContinuation
	*/

	// RVA: -1 Offset: -1
	private bool HandlePropertyWithContinuation(ref ReadStack state, ref Utf8JsonReader reader, JsonPropertyInfo jsonPropertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB78F40 Offset: 0xB78140 VA: 0x180B78F40
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.HandlePropertyWithContinuation
	*/

	// RVA: -1 Offset: -1
	private void BeginRead(ref ReadStack state, ref Utf8JsonReader reader, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB78D40 Offset: 0xB77F40 VA: 0x180B78D40
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.BeginRead
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected virtual void EndRead(ref ReadStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.EndRead
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected virtual bool TryLookupConstructorParameter(ref ReadStack state, ref Utf8JsonReader reader, JsonSerializerOptions options, out JsonParameterInfo jsonParameterInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7A120 Offset: 0xB79320 VA: 0x180B7A120
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.TryLookupConstructorParameter
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override bool get_ConstructorIsParameterized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.get_ConstructorIsParameterized
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7A240 Offset: 0xB79440 VA: 0x180B7A240
	|-ObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class LargeObjectWithParameterizedConstructorConverter<T> : ObjectWithParameterizedConstructorConverter<T> // TypeDefIndex: 15968
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 30
	protected override bool ReadAndCacheConstructorArgument(ref ReadStack state, ref Utf8JsonReader reader, JsonParameterInfo jsonParameterInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131DD20 Offset: 0x131CF20 VA: 0x18131DD20
	|-LargeObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.ReadAndCacheConstructorArgument
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override object CreateObject(ref ReadStackFrame frame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131D8A0 Offset: 0x131CAA0 VA: 0x18131D8A0
	|-LargeObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.CreateObject
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void InitializeConstructorArgumentCaches(ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131DAA0 Offset: 0x131CCA0 VA: 0x18131DAA0
	|-LargeObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>.InitializeConstructorArgumentCaches
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1209080 Offset: 0x1208280 VA: 0x181209080
	|-LargeObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal class SmallObjectWithParameterizedConstructorConverter<T, TArg0, TArg1, TArg2, TArg3> : ObjectWithParameterizedConstructorConverter<T> // TypeDefIndex: 15969
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 31
	protected override object CreateObject(ref ReadStackFrame frame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF7020 Offset: 0xBF6220 VA: 0x180BF7020
	|-SmallObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateObject
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override bool ReadAndCacheConstructorArgument(ref ReadStack state, ref Utf8JsonReader reader, JsonParameterInfo jsonParameterInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF7B10 Offset: 0xBF6D10 VA: 0x180BF7B10
	|-SmallObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReadAndCacheConstructorArgument
	*/

	// RVA: -1 Offset: -1
	private bool TryRead<TArg>(ref ReadStack state, ref Utf8JsonReader reader, JsonParameterInfo jsonParameterInfo, out TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F0C30 Offset: 0x8EFE30 VA: 0x1808F0C30
	|-SmallObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRead<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void InitializeConstructorArgumentCaches(ref ReadStack state, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF73F0 Offset: 0xBF65F0 VA: 0x180BF73F0
	|-SmallObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InitializeConstructorArgumentCaches
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF7D00 Offset: 0xBF6F00 VA: 0x180BF7D00
	|-SmallObjectWithParameterizedConstructorConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class BooleanConverter : JsonConverter<bool> // TypeDefIndex: 15970
{
	// Methods

	// RVA: 0x1C34CF0 Offset: 0x1C33EF0 VA: 0x181C34CF0 Slot: 23
	public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C34D30 Offset: 0x1C33F30 VA: 0x181C34D30 Slot: 24
	public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) { }

	// RVA: 0x1C34B40 Offset: 0x1C33D40 VA: 0x181C34B40 Slot: 25
	internal override bool ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C34D00 Offset: 0x1C33F00 VA: 0x181C34D00 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, bool value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C34D60 Offset: 0x1C33F60 VA: 0x181C34D60
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class ByteArrayConverter : JsonConverter<byte[]> // TypeDefIndex: 15971
{
	// Methods

	// RVA: 0x1C34DA0 Offset: 0x1C33FA0 VA: 0x181C34DA0 Slot: 23
	public override byte[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C34DB0 Offset: 0x1C33FB0 VA: 0x181C34DB0 Slot: 24
	public override void Write(Utf8JsonWriter writer, byte[] value, JsonSerializerOptions options) { }

	// RVA: 0x1C34E30 Offset: 0x1C34030 VA: 0x181C34E30
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class ByteConverter : JsonConverter<byte> // TypeDefIndex: 15972
{
	// Methods

	// RVA: 0x1C34F60 Offset: 0x1C34160 VA: 0x181C34F60
	public void .ctor() { }

	// RVA: 0x1C34EB0 Offset: 0x1C340B0 VA: 0x181C34EB0 Slot: 23
	public override byte Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C34F30 Offset: 0x1C34130 VA: 0x181C34F30 Slot: 24
	public override void Write(Utf8JsonWriter writer, byte value, JsonSerializerOptions options) { }

	// RVA: 0x1C34EA0 Offset: 0x1C340A0 VA: 0x181C34EA0 Slot: 25
	internal override byte ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C34F00 Offset: 0x1C34100 VA: 0x181C34F00 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, byte value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C34E70 Offset: 0x1C34070 VA: 0x181C34E70 Slot: 27
	internal override byte ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }

	// RVA: 0x1C34EC0 Offset: 0x1C340C0 VA: 0x181C34EC0 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, byte value, JsonNumberHandling handling) { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class CharConverter : JsonConverter<char> // TypeDefIndex: 15973
{
	// Methods

	// RVA: 0x1C34FD0 Offset: 0x1C341D0 VA: 0x181C34FD0 Slot: 23
	public override char Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C350C0 Offset: 0x1C342C0 VA: 0x181C350C0 Slot: 24
	public override void Write(Utf8JsonWriter writer, char value, JsonSerializerOptions options) { }

	// RVA: 0x1C34FA0 Offset: 0x1C341A0 VA: 0x181C34FA0 Slot: 25
	internal override char ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C35050 Offset: 0x1C34250 VA: 0x181C35050 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, char value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C35130 Offset: 0x1C34330 VA: 0x181C35130
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class DateTimeConverter : JsonConverter<DateTime> // TypeDefIndex: 15974
{
	// Methods

	// RVA: 0x1C358B0 Offset: 0x1C34AB0 VA: 0x181C358B0 Slot: 23
	public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C358F0 Offset: 0x1C34AF0 VA: 0x181C358F0 Slot: 24
	public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) { }

	// RVA: 0x1C358A0 Offset: 0x1C34AA0 VA: 0x181C358A0 Slot: 25
	internal override DateTime ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C358C0 Offset: 0x1C34AC0 VA: 0x181C358C0 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C35920 Offset: 0x1C34B20 VA: 0x181C35920
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class DateTimeOffsetConverter : JsonConverter<DateTimeOffset> // TypeDefIndex: 15975
{
	// Methods

	// RVA: 0x1C35990 Offset: 0x1C34B90 VA: 0x181C35990 Slot: 23
	public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C359F0 Offset: 0x1C34BF0 VA: 0x181C359F0 Slot: 24
	public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options) { }

	// RVA: 0x1C35960 Offset: 0x1C34B60 VA: 0x181C35960 Slot: 25
	internal override DateTimeOffset ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C359C0 Offset: 0x1C34BC0 VA: 0x181C359C0 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C35A20 Offset: 0x1C34C20 VA: 0x181C35A20
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class DecimalConverter : JsonConverter<Decimal> // TypeDefIndex: 15976
{
	// Methods

	// RVA: 0x1C35BD0 Offset: 0x1C34DD0 VA: 0x181C35BD0
	public void .ctor() { }

	// RVA: 0x1C35AF0 Offset: 0x1C34CF0 VA: 0x181C35AF0 Slot: 23
	public override Decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C35BA0 Offset: 0x1C34DA0 VA: 0x181C35BA0 Slot: 24
	public override void Write(Utf8JsonWriter writer, Decimal value, JsonSerializerOptions options) { }

	// RVA: 0x1C35AC0 Offset: 0x1C34CC0 VA: 0x181C35AC0 Slot: 25
	internal override Decimal ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C35B70 Offset: 0x1C34D70 VA: 0x181C35B70 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, Decimal value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C35A60 Offset: 0x1C34C60 VA: 0x181C35A60 Slot: 27
	internal override Decimal ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }

	// RVA: 0x1C35B20 Offset: 0x1C34D20 VA: 0x181C35B20 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, Decimal value, JsonNumberHandling handling) { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class DoubleConverter : JsonConverter<double> // TypeDefIndex: 15977
{
	// Methods

	// RVA: 0x1C35D20 Offset: 0x1C34F20 VA: 0x181C35D20
	public void .ctor() { }

	// RVA: 0x1C35C60 Offset: 0x1C34E60 VA: 0x181C35C60 Slot: 23
	public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C35CF0 Offset: 0x1C34EF0 VA: 0x181C35CF0 Slot: 24
	public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options) { }

	// RVA: 0x1C35C50 Offset: 0x1C34E50 VA: 0x181C35C50 Slot: 25
	internal override double ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C35CC0 Offset: 0x1C34EC0 VA: 0x181C35CC0 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, double value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C35C10 Offset: 0x1C34E10 VA: 0x181C35C10 Slot: 27
	internal override double ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }

	// RVA: 0x1C35C70 Offset: 0x1C34E70 VA: 0x181C35C70 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, double value, JsonNumberHandling handling) { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal class EnumConverter<T> : JsonConverter<T> // TypeDefIndex: 15978
{
	// Fields
	private static readonly TypeCode s_enumTypeCode; // 0x0
	private static readonly string s_negativeSign; // 0x0
	private readonly EnumConverterOptions _converterOptions; // 0x0
	private readonly JsonNamingPolicy _namingPolicy; // 0x0
	private readonly ConcurrentDictionary<ulong, JsonEncodedText> _nameCache; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override bool CanConvert(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DE000 Offset: 0x10DD200 VA: 0x1810DE000
	|-EnumConverter<__Il2CppFullySharedGenericStructType>.CanConvert
	*/

	// RVA: -1 Offset: -1
	public void .ctor(EnumConverterOptions converterOptions, JsonSerializerOptions serializerOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DF6C0 Offset: 0x10DE8C0 VA: 0x1810DF6C0
	|-EnumConverter<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(EnumConverterOptions converterOptions, JsonNamingPolicy namingPolicy, JsonSerializerOptions serializerOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DF6F0 Offset: 0x10DE8F0 VA: 0x1810DF6F0
	|-EnumConverter<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DE810 Offset: 0x10DDA10 VA: 0x1810DE810
	|-EnumConverter<__Il2CppFullySharedGenericStructType>.Read
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DF040 Offset: 0x10DE240 VA: 0x1810DF040
	|-EnumConverter<__Il2CppFullySharedGenericStructType>.Write
	*/

	// RVA: -1 Offset: -1
	private static ulong ConvertToUInt64(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DE030 Offset: 0x10DD230 VA: 0x1810DE030
	|-EnumConverter<__Il2CppFullySharedGenericStructType>.ConvertToUInt64
	*/

	// RVA: -1 Offset: -1
	private static bool IsValidIdentifier(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DE540 Offset: 0x10DD740 VA: 0x1810DE540
	|-EnumConverter<__Il2CppFullySharedGenericStructType>.IsValidIdentifier
	*/

	// RVA: -1 Offset: -1
	private JsonEncodedText FormatEnumValue(string value, JavaScriptEncoder encoder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DE4D0 Offset: 0x10DD6D0 VA: 0x1810DE4D0
	|-EnumConverter<__Il2CppFullySharedGenericStructType>.FormatEnumValue
	*/

	// RVA: -1 Offset: -1
	private string FormatEnumValueToString(string value, JavaScriptEncoder encoder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DE380 Offset: 0x10DD580 VA: 0x1810DE380
	|-EnumConverter<__Il2CppFullySharedGenericStructType>.FormatEnumValueToString
	*/

	// RVA: -1 Offset: -1 Slot: 25
	internal override T ReadWithQuotes(ref Utf8JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DE6A0 Offset: 0x10DD8A0 VA: 0x1810DE6A0
	|-EnumConverter<__Il2CppFullySharedGenericStructType>.ReadWithQuotes
	*/

	// RVA: -1 Offset: -1 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DEBE0 Offset: 0x10DDDE0 VA: 0x1810DEBE0
	|-EnumConverter<__Il2CppFullySharedGenericStructType>.WriteWithQuotes
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DF540 Offset: 0x10DE740 VA: 0x1810DF540
	|-EnumConverter<__Il2CppFullySharedGenericStructType>..cctor
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class EnumConverterFactory : JsonConverterFactory // TypeDefIndex: 15979
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x10DE000 Offset: 0x10DD200 VA: 0x1810DE000 Slot: 4
	public override bool CanConvert(Type type) { }

	// RVA: 0x1C35D60 Offset: 0x1C34F60 VA: 0x181C35D60 Slot: 20
	public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options) { }
}

// Namespace: System.Text.Json.Serialization.Converters
[Flags]
internal enum EnumConverterOptions // TypeDefIndex: 15980
{
	// Fields
	public int value__; // 0x0
	public const EnumConverterOptions AllowStrings = 1;
	public const EnumConverterOptions AllowNumbers = 2;
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class GuidConverter : JsonConverter<Guid> // TypeDefIndex: 15981
{
	// Methods

	// RVA: 0x1C35FE0 Offset: 0x1C351E0 VA: 0x181C35FE0 Slot: 23
	public override Guid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C36040 Offset: 0x1C35240 VA: 0x181C36040 Slot: 24
	public override void Write(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options) { }

	// RVA: 0x1C35FB0 Offset: 0x1C351B0 VA: 0x181C35FB0 Slot: 25
	internal override Guid ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C36010 Offset: 0x1C35210 VA: 0x181C36010 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C36070 Offset: 0x1C35270 VA: 0x181C36070
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class Int16Converter : JsonConverter<short> // TypeDefIndex: 15982
{
	// Methods

	// RVA: 0x1C38540 Offset: 0x1C37740 VA: 0x181C38540
	public void .ctor() { }

	// RVA: 0x1C38490 Offset: 0x1C37690 VA: 0x181C38490 Slot: 23
	public override short Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C38510 Offset: 0x1C37710 VA: 0x181C38510 Slot: 24
	public override void Write(Utf8JsonWriter writer, short value, JsonSerializerOptions options) { }

	// RVA: 0x1C38480 Offset: 0x1C37680 VA: 0x181C38480 Slot: 25
	internal override short ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C384E0 Offset: 0x1C376E0 VA: 0x181C384E0 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, short value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C38450 Offset: 0x1C37650 VA: 0x181C38450 Slot: 27
	internal override short ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }

	// RVA: 0x1C384A0 Offset: 0x1C376A0 VA: 0x181C384A0 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, short value, JsonNumberHandling handling) { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class Int32Converter : JsonConverter<int> // TypeDefIndex: 15983
{
	// Methods

	// RVA: 0x1C38670 Offset: 0x1C37870 VA: 0x181C38670
	public void .ctor() { }

	// RVA: 0x1C385C0 Offset: 0x1C377C0 VA: 0x181C385C0 Slot: 23
	public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C38640 Offset: 0x1C37840 VA: 0x181C38640 Slot: 24
	public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options) { }

	// RVA: 0x1C385B0 Offset: 0x1C377B0 VA: 0x181C385B0 Slot: 25
	internal override int ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C38610 Offset: 0x1C37810 VA: 0x181C38610 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, int value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C38580 Offset: 0x1C37780 VA: 0x181C38580 Slot: 27
	internal override int ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }

	// RVA: 0x1C385D0 Offset: 0x1C377D0 VA: 0x181C385D0 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, int value, JsonNumberHandling handling) { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class Int64Converter : JsonConverter<long> // TypeDefIndex: 15984
{
	// Methods

	// RVA: 0x1C387A0 Offset: 0x1C379A0 VA: 0x181C387A0
	public void .ctor() { }

	// RVA: 0x1C386F0 Offset: 0x1C378F0 VA: 0x181C386F0 Slot: 23
	public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C38770 Offset: 0x1C37970 VA: 0x181C38770 Slot: 24
	public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options) { }

	// RVA: 0x1C386E0 Offset: 0x1C378E0 VA: 0x181C386E0 Slot: 25
	internal override long ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C38740 Offset: 0x1C37940 VA: 0x181C38740 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, long value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C386B0 Offset: 0x1C378B0 VA: 0x181C386B0 Slot: 27
	internal override long ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }

	// RVA: 0x1C38700 Offset: 0x1C37900 VA: 0x181C38700 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, long value, JsonNumberHandling handling) { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class JsonDocumentConverter : JsonConverter<JsonDocument> // TypeDefIndex: 15985
{
	// Methods

	// RVA: 0x1C38D80 Offset: 0x1C37F80 VA: 0x181C38D80 Slot: 23
	public override JsonDocument Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C38D90 Offset: 0x1C37F90 VA: 0x181C38D90 Slot: 24
	public override void Write(Utf8JsonWriter writer, JsonDocument value, JsonSerializerOptions options) { }

	// RVA: 0x1C38DC0 Offset: 0x1C37FC0 VA: 0x181C38DC0
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class JsonElementConverter : JsonConverter<JsonElement> // TypeDefIndex: 15986
{
	// Methods

	// RVA: 0x1C38E00 Offset: 0x1C38000 VA: 0x181C38E00 Slot: 23
	public override JsonElement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C38EF0 Offset: 0x1C380F0 VA: 0x181C38EF0 Slot: 24
	public override void Write(Utf8JsonWriter writer, JsonElement value, JsonSerializerOptions options) { }

	// RVA: 0x1C38F10 Offset: 0x1C38110 VA: 0x181C38F10
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal class NullableConverter<T> : JsonConverter<Nullable<T>> // TypeDefIndex: 15987
{
	// Fields
	private readonly JsonConverter<T> _converter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(JsonConverter<T> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148CDC0 Offset: 0x148BFC0 VA: 0x18148CDC0
	|-NullableConverter<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public override Nullable<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148C8E0 Offset: 0x148BAE0 VA: 0x18148C8E0
	|-NullableConverter<__Il2CppFullySharedGenericStructType>.Read
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public override void Write(Utf8JsonWriter writer, Nullable<T> value, JsonSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148CCA0 Offset: 0x148BEA0 VA: 0x18148CCA0
	|-NullableConverter<__Il2CppFullySharedGenericStructType>.Write
	*/

	// RVA: -1 Offset: -1 Slot: 27
	internal override Nullable<T> ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling numberHandling) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148C690 Offset: 0x148B890 VA: 0x18148C690
	|-NullableConverter<__Il2CppFullySharedGenericStructType>.ReadNumberWithCustomHandling
	*/

	// RVA: -1 Offset: -1 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, Nullable<T> value, JsonNumberHandling handling) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148CB70 Offset: 0x148BD70 VA: 0x18148CB70
	|-NullableConverter<__Il2CppFullySharedGenericStructType>.WriteNumberWithCustomHandling
	*/
}

// Namespace: System.Text.Json.Serialization.Converters
internal class NullableConverterFactory : JsonConverterFactory // TypeDefIndex: 15988
{
	// Methods

	// RVA: 0x1C38F50 Offset: 0x1C38150 VA: 0x181C38F50 Slot: 4
	public override bool CanConvert(Type typeToConvert) { }

	// RVA: 0x1C38FB0 Offset: 0x1C381B0 VA: 0x181C38FB0 Slot: 20
	public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C39080 Offset: 0x1C38280 VA: 0x181C39080
	public static JsonConverter CreateValueConverter(Type valueTypeToConvert, JsonConverter valueConverter) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class ObjectConverter : JsonConverter<object> // TypeDefIndex: 15989
{
	// Methods

	// RVA: 0x1C39E10 Offset: 0x1C39010 VA: 0x181C39E10 Slot: 23
	public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C39FE0 Offset: 0x1C391E0 VA: 0x181C39FE0 Slot: 24
	public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options) { }

	// RVA: 0x1C39DE0 Offset: 0x1C38FE0 VA: 0x181C39DE0 Slot: 25
	internal override object ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C39F30 Offset: 0x1C39130 VA: 0x181C39F30 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C39D80 Offset: 0x1C38F80 VA: 0x181C39D80
	private JsonConverter GetRuntimeConverter(Type runtimeType, JsonSerializerOptions options) { }

	// RVA: 0x1C3A020 Offset: 0x1C39220 VA: 0x181C3A020
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class SByteConverter : JsonConverter<sbyte> // TypeDefIndex: 15990
{
	// Methods

	// RVA: 0x1C3A890 Offset: 0x1C39A90 VA: 0x181C3A890
	public void .ctor() { }

	// RVA: 0x1C3A7E0 Offset: 0x1C399E0 VA: 0x181C3A7E0 Slot: 23
	public override sbyte Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C3A860 Offset: 0x1C39A60 VA: 0x181C3A860 Slot: 24
	public override void Write(Utf8JsonWriter writer, sbyte value, JsonSerializerOptions options) { }

	// RVA: 0x1C3A7D0 Offset: 0x1C399D0 VA: 0x181C3A7D0 Slot: 25
	internal override sbyte ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C3A830 Offset: 0x1C39A30 VA: 0x181C3A830 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, sbyte value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C3A7A0 Offset: 0x1C399A0 VA: 0x181C3A7A0 Slot: 27
	internal override sbyte ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }

	// RVA: 0x1C3A7F0 Offset: 0x1C399F0 VA: 0x181C3A7F0 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, sbyte value, JsonNumberHandling handling) { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class SingleConverter : JsonConverter<float> // TypeDefIndex: 15991
{
	// Methods

	// RVA: 0x1C3A9E0 Offset: 0x1C39BE0 VA: 0x181C3A9E0
	public void .ctor() { }

	// RVA: 0x1C3A920 Offset: 0x1C39B20 VA: 0x181C3A920 Slot: 23
	public override float Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C3A9B0 Offset: 0x1C39BB0 VA: 0x181C3A9B0 Slot: 24
	public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options) { }

	// RVA: 0x1C3A910 Offset: 0x1C39B10 VA: 0x181C3A910 Slot: 25
	internal override float ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C3A980 Offset: 0x1C39B80 VA: 0x181C3A980 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, float value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C3A8D0 Offset: 0x1C39AD0 VA: 0x181C3A8D0 Slot: 27
	internal override float ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }

	// RVA: 0x1C3A930 Offset: 0x1C39B30 VA: 0x181C3A930 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, float value, JsonNumberHandling handling) { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class StringConverter : JsonConverter<string> // TypeDefIndex: 15992
{
	// Methods

	// RVA: 0x1C3AA20 Offset: 0x1C39C20 VA: 0x181C3AA20 Slot: 23
	public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C3AAC0 Offset: 0x1C39CC0 VA: 0x181C3AAC0 Slot: 24
	public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options) { }

	// RVA: 0x1C3AA20 Offset: 0x1C39C20 VA: 0x181C3AA20 Slot: 25
	internal override string ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C3AA30 Offset: 0x1C39C30 VA: 0x181C3AA30 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, string value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C3ABD0 Offset: 0x1C39DD0 VA: 0x181C3ABD0
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class TypeConverter : JsonConverter<Type> // TypeDefIndex: 15993
{
	// Methods

	// RVA: 0x1C3AC10 Offset: 0x1C39E10 VA: 0x181C3AC10 Slot: 23
	public override Type Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C3AC80 Offset: 0x1C39E80 VA: 0x181C3AC80 Slot: 24
	public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options) { }

	// RVA: 0x1C3ACF0 Offset: 0x1C39EF0 VA: 0x181C3ACF0
	public void .ctor() { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class UInt16Converter : JsonConverter<ushort> // TypeDefIndex: 15994
{
	// Methods

	// RVA: 0x1C3B4D0 Offset: 0x1C3A6D0 VA: 0x181C3B4D0
	public void .ctor() { }

	// RVA: 0x1C3B420 Offset: 0x1C3A620 VA: 0x181C3B420 Slot: 23
	public override ushort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C3B4A0 Offset: 0x1C3A6A0 VA: 0x181C3B4A0 Slot: 24
	public override void Write(Utf8JsonWriter writer, ushort value, JsonSerializerOptions options) { }

	// RVA: 0x1C3B410 Offset: 0x1C3A610 VA: 0x181C3B410 Slot: 25
	internal override ushort ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C3B470 Offset: 0x1C3A670 VA: 0x181C3B470 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, ushort value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C3B3E0 Offset: 0x1C3A5E0 VA: 0x181C3B3E0 Slot: 27
	internal override ushort ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }

	// RVA: 0x1C3B430 Offset: 0x1C3A630 VA: 0x181C3B430 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, ushort value, JsonNumberHandling handling) { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class UInt32Converter : JsonConverter<uint> // TypeDefIndex: 15995
{
	// Methods

	// RVA: 0x1C3B600 Offset: 0x1C3A800 VA: 0x181C3B600
	public void .ctor() { }

	// RVA: 0x1C3B550 Offset: 0x1C3A750 VA: 0x181C3B550 Slot: 23
	public override uint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C3B5D0 Offset: 0x1C3A7D0 VA: 0x181C3B5D0 Slot: 24
	public override void Write(Utf8JsonWriter writer, uint value, JsonSerializerOptions options) { }

	// RVA: 0x1C3B540 Offset: 0x1C3A740 VA: 0x181C3B540 Slot: 25
	internal override uint ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C3B5A0 Offset: 0x1C3A7A0 VA: 0x181C3B5A0 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, uint value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C3B510 Offset: 0x1C3A710 VA: 0x181C3B510 Slot: 27
	internal override uint ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }

	// RVA: 0x1C3B560 Offset: 0x1C3A760 VA: 0x181C3B560 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, uint value, JsonNumberHandling handling) { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class UInt64Converter : JsonConverter<ulong> // TypeDefIndex: 15996
{
	// Methods

	// RVA: 0x1C3B730 Offset: 0x1C3A930 VA: 0x181C3B730
	public void .ctor() { }

	// RVA: 0x1C3B680 Offset: 0x1C3A880 VA: 0x181C3B680 Slot: 23
	public override ulong Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C3B700 Offset: 0x1C3A900 VA: 0x181C3B700 Slot: 24
	public override void Write(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options) { }

	// RVA: 0x1C3B670 Offset: 0x1C3A870 VA: 0x181C3B670 Slot: 25
	internal override ulong ReadWithQuotes(ref Utf8JsonReader reader) { }

	// RVA: 0x1C3B6D0 Offset: 0x1C3A8D0 VA: 0x181C3B6D0 Slot: 26
	internal override void WriteWithQuotes(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options, ref WriteStack state) { }

	// RVA: 0x1C3B640 Offset: 0x1C3A840 VA: 0x181C3B640 Slot: 27
	internal override ulong ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling) { }

	// RVA: 0x1C3B690 Offset: 0x1C3A890 VA: 0x181C3B690 Slot: 28
	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, ulong value, JsonNumberHandling handling) { }
}

// Namespace: System.Text.Json.Serialization.Converters
internal sealed class UriConverter : JsonConverter<Uri> // TypeDefIndex: 15997
{
	// Methods

	// RVA: 0x1C3B770 Offset: 0x1C3A970 VA: 0x181C3B770 Slot: 23
	public override Uri Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1C3B800 Offset: 0x1C3AA00 VA: 0x181C3B800 Slot: 24
	public override void Write(Utf8JsonWriter writer, Uri value, JsonSerializerOptions options) { }

	// RVA: 0x1C3B840 Offset: 0x1C3AA40 VA: 0x181C3B840
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 // TypeDefIndex: 15998
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5 // TypeDefIndex: 15999
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7 // TypeDefIndex: 16000
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 // TypeDefIndex: 16001
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 // TypeDefIndex: 16002
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 // TypeDefIndex: 16003
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 16004
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16005
{
	// Fields
	internal static readonly int 0B13BAAC84920A23C8AAAE0B9B15BAD28E4DBAB4B45B8A6C64861EDE8A38995F = 18; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 21244F82B210125632917591768F6BF22EB6861F80C6C25A25BD26DFB580EA7B /*Metadata offset 0x8F3C58*/; // 0x4
	internal static readonly long 4A290E521C8FFD514F69D5856AA11C25E90EAF4B5048918F4874D4506A77E2F7 = 3389254531716840748; // 0x108
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA /*Metadata offset 0x8F3D70*/; // 0x110
	internal static readonly long 610135388C72AB5255BDEE95D50F660AC9B5890460A4A64B744F83102F0F857A = 7377587986263862818; // 0x148
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7 6C13BC6D02316E0DC1A544D398F2C8235A05FAE2FE8771B8D06A833974BD4D16 /*Metadata offset 0x8F3DB8*/; // 0x150
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 7367A65185E4F747AA29364AB199D01646A010A62129A6BA2E35E929D7294D62 /*Metadata offset 0x8F3DC0*/; // 0x157
	internal static readonly int 74234E98AFE7498FB5DAF1F36AC2D78ACC339464F950703B8C019892F982B90B = 55; // 0x17C
	internal static readonly int B5BEA41B6C623F7C09F1BF24DCAE58EBAB3C0CDD90AD966BC43A45B44867E12B = 58; // 0x180
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 C64DDF11BCD45660F0CF66DD0C22D2B4570EF3D3FC6527A9A6F6C722AEFA3C39 /*Metadata offset 0x8F3DF8*/; // 0x184
	internal static readonly long D0067CAD9A63E0813759A2BB841051CA73570C0DA2E08E840A8EB45DB6A7A010 = 8751735898823355977; // 0x190
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 D5B592C05DC25B5032553F1B27F4139BE95E881F73DB33B02B05AB20C3F9981E /*Metadata offset 0x8F3E18*/; // 0x198
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 EC4918E40D55761A30A08F3C3CA8DCDC51A7044CD2A90596392A840286223FFA /*Metadata offset 0x8F3E20*/; // 0x19B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 EFE627BE173681E4F55F4133AB4C1782E26D1080CB80CDB6BFAAC81416A2714E /*Metadata offset 0x8F3E28*/; // 0x19E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 F1945CD6C19E56B3C1C78943EF5EC18116907A4CA1EFC40A57D48AB1DB7ADFC5 /*Metadata offset 0x8F3F30*/; // 0x29E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315 /*Metadata offset 0x8F3F38*/; // 0x2A1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5 FCBCF165908DD18A9E49F7FF27810176DB8E9F63B4352213741664245224F8AA /*Metadata offset 0x8F3F70*/; // 0x2D5

	// Methods

	// RVA: 0x840E00 Offset: 0x840000 VA: 0x180840E00
	internal static uint ComputeStringHash(string s) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16006
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 16007
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 16008
{
	// Methods

	// RVA: 0x25690B0 Offset: 0x25682B0 VA: 0x1825690B0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public class AnimationTriggers // TypeDefIndex: 16009
{
	// Fields
	private const string kDefaultNormalAnimName = "Normal";
	private const string kDefaultHighlightedAnimName = "Highlighted";
	private const string kDefaultPressedAnimName = "Pressed";
	private const string kDefaultSelectedAnimName = "Selected";
	private const string kDefaultDisabledAnimName = "Disabled";
	[FormerlySerializedAs("normalTrigger")]
	[SerializeField]
	private string m_NormalTrigger; // 0x10
	[FormerlySerializedAs("highlightedTrigger")]
	[SerializeField]
	private string m_HighlightedTrigger; // 0x18
	[FormerlySerializedAs("pressedTrigger")]
	[SerializeField]
	private string m_PressedTrigger; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_HighlightedTrigger")]
	private string m_SelectedTrigger; // 0x28
	[FormerlySerializedAs("disabledTrigger")]
	[SerializeField]
	private string m_DisabledTrigger; // 0x30

	// Properties
	public string normalTrigger { get; set; }
	public string highlightedTrigger { get; set; }
	public string pressedTrigger { get; set; }
	public string selectedTrigger { get; set; }
	public string disabledTrigger { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_normalTrigger() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_normalTrigger(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_highlightedTrigger() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_pressedTrigger() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_pressedTrigger(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_selectedTrigger() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_selectedTrigger(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_disabledTrigger() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_disabledTrigger(string value) { }

	// RVA: 0x254E980 Offset: 0x254DB80 VA: 0x18254E980
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Button.ButtonClickedEvent : UnityEvent // TypeDefIndex: 16010
{
	// Methods

	// RVA: 0x1990F70 Offset: 0x1990170 VA: 0x181990F70
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Button.<OnFinishSubmit>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 16011
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Button <>4__this; // 0x20
	private float <fadeTime>5__2; // 0x28
	private float <elapsedTime>5__3; // 0x2C

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

	// RVA: 0x2568D40 Offset: 0x2567F40 VA: 0x182568D40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x2568E70 Offset: 0x2568070 VA: 0x182568E70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Button", 30)]
public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 16012
{
	// Fields
	[FormerlySerializedAs("onClick")]
	[SerializeField]
	private Button.ButtonClickedEvent m_OnClick; // 0x100

	// Properties
	public Button.ButtonClickedEvent onClick { get; set; }

	// Methods

	// RVA: 0x254EC10 Offset: 0x254DE10 VA: 0x18254EC10
	protected void .ctor() { }

	// RVA: 0x7960A0 Offset: 0x7952A0 VA: 0x1807960A0
	public Button.ButtonClickedEvent get_onClick() { }

	// RVA: 0x7960F0 Offset: 0x7952F0 VA: 0x1807960F0
	public void set_onClick(Button.ButtonClickedEvent value) { }

	// RVA: 0x254EB80 Offset: 0x254DD80 VA: 0x18254EB80
	private void Press() { }

	// RVA: 0x254EA80 Offset: 0x254DC80 VA: 0x18254EA80 Slot: 41
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x254EAB0 Offset: 0x254DCB0 VA: 0x18254EAB0 Slot: 42
	public virtual void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachine(typeof(Button.<OnFinishSubmit>d__9))]
	// RVA: 0x254EA20 Offset: 0x254DC20 VA: 0x18254EA20
	private IEnumerator OnFinishSubmit() { }
}

// Namespace: UnityEngine.UI
public enum CanvasUpdate // TypeDefIndex: 16013
{
	// Fields
	public int value__; // 0x0
	public const CanvasUpdate Prelayout = 0;
	public const CanvasUpdate Layout = 1;
	public const CanvasUpdate PostLayout = 2;
	public const CanvasUpdate PreRender = 3;
	public const CanvasUpdate LatePreRender = 4;
	public const CanvasUpdate MaxUpdateValue = 5;
}

// Namespace: UnityEngine.UI
public interface ICanvasElement // TypeDefIndex: 16014
{
	// Properties
	public abstract Transform transform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Rebuild(CanvasUpdate executing);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Transform get_transform();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LayoutComplete();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GraphicUpdateComplete();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsDestroyed();
}

// Namespace: UnityEngine.UI
public class CanvasUpdateRegistry // TypeDefIndex: 16015
{
	// Fields
	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private string[] m_CanvasUpdateProfilerStrings; // 0x18
	private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x20
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x28
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x8

	// Properties
	public static CanvasUpdateRegistry instance { get; }

	// Methods

	// RVA: 0x2550430 Offset: 0x254F630 VA: 0x182550430
	protected void .ctor() { }

	// RVA: 0x25505E0 Offset: 0x254F7E0 VA: 0x1825505E0
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x254F6C0 Offset: 0x254E8C0 VA: 0x18254F6C0
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x254EC90 Offset: 0x254DE90 VA: 0x18254EC90
	private void CleanInvalidItems() { }

	// RVA: 0x254F8A0 Offset: 0x254EAA0 VA: 0x18254F8A0
	private void PerformUpdate() { }

	// RVA: 0x254F7D0 Offset: 0x254E9D0 VA: 0x18254F7D0
	private static int ParentCount(Transform child) { }

	// RVA: 0x2550000 Offset: 0x254F200 VA: 0x182550000
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x254FFA0 Offset: 0x254F1A0 VA: 0x18254FFA0
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2550110 Offset: 0x254F310 VA: 0x182550110
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x254F370 Offset: 0x254E570 VA: 0x18254F370
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x254FF40 Offset: 0x254F140 VA: 0x18254FF40
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x25500B0 Offset: 0x254F2B0 VA: 0x1825500B0
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x254F2B0 Offset: 0x254E4B0 VA: 0x18254F2B0
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x2550170 Offset: 0x254F370 VA: 0x182550170
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x254EE50 Offset: 0x254E050 VA: 0x18254EE50
	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x254F510 Offset: 0x254E710 VA: 0x18254F510
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x254F400 Offset: 0x254E600 VA: 0x18254F400
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x254F1A0 Offset: 0x254E3A0 VA: 0x18254F1A0
	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x254F090 Offset: 0x254E290 VA: 0x18254F090
	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x254F670 Offset: 0x254E870 VA: 0x18254F670
	public static bool IsRebuildingLayout() { }

	// RVA: 0x254F620 Offset: 0x254E820 VA: 0x18254F620
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x25503B0 Offset: 0x254F5B0 VA: 0x1825503B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 16016
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("normalColor")]
	private Color m_NormalColor; // 0x0
	[SerializeField]
	[FormerlySerializedAs("highlightedColor")]
	private Color m_HighlightedColor; // 0x10
	[SerializeField]
	[FormerlySerializedAs("pressedColor")]
	private Color m_PressedColor; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_HighlightedColor")]
	private Color m_SelectedColor; // 0x30
	[SerializeField]
	[FormerlySerializedAs("disabledColor")]
	private Color m_DisabledColor; // 0x40
	[Range(1, 5)]
	[SerializeField]
	private float m_ColorMultiplier; // 0x50
	[SerializeField]
	[FormerlySerializedAs("fadeDuration")]
	private float m_FadeDuration; // 0x54
	public static ColorBlock defaultColorBlock; // 0x0

	// Properties
	public Color normalColor { get; set; }
	public Color highlightedColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledColor { get; set; }
	public float colorMultiplier { get; set; }
	public float fadeDuration { get; set; }

	// Methods

	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public Color get_normalColor() { }

	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	public void set_normalColor(Color value) { }

	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public Color get_highlightedColor() { }

	// RVA: 0x4829A0 Offset: 0x481BA0 VA: 0x1804829A0
	public void set_highlightedColor(Color value) { }

	// RVA: 0x416920 Offset: 0x415B20 VA: 0x180416920
	public Color get_pressedColor() { }

	// RVA: 0x416940 Offset: 0x415B40 VA: 0x180416940
	public void set_pressedColor(Color value) { }

	// RVA: 0x160E010 Offset: 0x160D210 VA: 0x18160E010
	public Color get_selectedColor() { }

	// RVA: 0x160E020 Offset: 0x160D220 VA: 0x18160E020
	public void set_selectedColor(Color value) { }

	// RVA: 0x4D1A20 Offset: 0x4D0C20 VA: 0x1804D1A20
	public Color get_disabledColor() { }

	// RVA: 0x4D1A60 Offset: 0x4D0C60 VA: 0x1804D1A60
	public void set_disabledColor(Color value) { }

	// RVA: 0x646040 Offset: 0x645240 VA: 0x180646040
	public float get_colorMultiplier() { }

	// RVA: 0x646080 Offset: 0x645280 VA: 0x180646080
	public void set_colorMultiplier(float value) { }

	// RVA: 0x6D7290 Offset: 0x6D6490 VA: 0x1806D7290
	public float get_fadeDuration() { }

	// RVA: 0x24258C0 Offset: 0x2424AC0 VA: 0x1824258C0
	public void set_fadeDuration(float value) { }

	// RVA: 0x2551330 Offset: 0x2550530 VA: 0x182551330
	private static void .cctor() { }

	// RVA: 0x2550EB0 Offset: 0x25500B0 VA: 0x182550EB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2550FA0 Offset: 0x25501A0 VA: 0x182550FA0 Slot: 4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x2551660 Offset: 0x2550860 VA: 0x182551660
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x2551700 Offset: 0x2550900 VA: 0x182551700
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x25512A0 Offset: 0x25504A0 VA: 0x1825512A0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UI
public class ClipperRegistry // TypeDefIndex: 16017
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	// Properties
	public static ClipperRegistry instance { get; }

	// Methods

	// RVA: 0x2550AB0 Offset: 0x254FCB0 VA: 0x182550AB0
	protected void .ctor() { }

	// RVA: 0x2550B20 Offset: 0x254FD20 VA: 0x182550B20
	public static ClipperRegistry get_instance() { }

	// RVA: 0x2550840 Offset: 0x254FA40 VA: 0x182550840
	public void Cull() { }

	// RVA: 0x25509E0 Offset: 0x254FBE0 VA: 0x1825509E0
	public static void Register(IClipper c) { }

	// RVA: 0x2550A50 Offset: 0x254FC50 VA: 0x182550A50
	public static void Unregister(IClipper c) { }

	// RVA: 0x2550980 Offset: 0x254FB80 VA: 0x182550980
	public static void Disable(IClipper c) { }
}

// Namespace: UnityEngine.UI
public static class Clipping // TypeDefIndex: 16018
{
	// Methods

	// RVA: 0x2550BF0 Offset: 0x254FDF0 VA: 0x182550BF0
	public static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect) { }
}

// Namespace: UnityEngine.UI
public interface IClipper // TypeDefIndex: 16019
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PerformClipping();
}

// Namespace: UnityEngine.UI
public interface IClippable // TypeDefIndex: 16020
{
	// Properties
	public abstract GameObject gameObject { get; }
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject get_gameObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RecalculateClipping();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract RectTransform get_rectTransform();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Cull(Rect clipRect, bool validRect);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetClipRect(Rect value, bool validRect);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetClipSoftness(Vector2 clipSoftness);
}

// Namespace: UnityEngine.UI
internal class RectangularVertexClipper // TypeDefIndex: 16021
{
	// Fields
	private readonly Vector3[] m_WorldCorners; // 0x10
	private readonly Vector3[] m_CanvasCorners; // 0x18

	// Methods

	// RVA: 0x2568A20 Offset: 0x2567C20 VA: 0x182568A20
	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

	// RVA: 0x2568BF0 Offset: 0x2567DF0 VA: 0x182568BF0
	public void .ctor() { }
}

// Namespace: 
public interface DefaultControls.IFactoryControls // TypeDefIndex: 16022
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject CreateGameObject(string name, Type[] components);
}

// Namespace: 
private class DefaultControls.DefaultRuntimeFactory : DefaultControls.IFactoryControls // TypeDefIndex: 16023
{
	// Fields
	public static DefaultControls.IFactoryControls Default; // 0x0

	// Methods

	// RVA: 0x2556C00 Offset: 0x2555E00 VA: 0x182556C00 Slot: 4
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2556C70 Offset: 0x2555E70 VA: 0x182556C70
	private static void .cctor() { }
}

// Namespace: 
public struct DefaultControls.Resources // TypeDefIndex: 16024
{
	// Fields
	public Sprite standard; // 0x0
	public Sprite background; // 0x8
	public Sprite inputField; // 0x10
	public Sprite knob; // 0x18
	public Sprite checkmark; // 0x20
	public Sprite dropdown; // 0x28
	public Sprite mask; // 0x30
}

// Namespace: UnityEngine.UI
public static class DefaultControls // TypeDefIndex: 16025
{
	// Fields
	private static DefaultControls.IFactoryControls m_CurrentFactory; // 0x0
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	// Properties
	public static DefaultControls.IFactoryControls factory { get; }

	// Methods

	// RVA: 0x2556BB0 Offset: 0x2555DB0 VA: 0x182556BB0
	public static DefaultControls.IFactoryControls get_factory() { }

	// RVA: 0x25565C0 Offset: 0x25557C0 VA: 0x1825565C0
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x25566D0 Offset: 0x25558D0 VA: 0x1825566D0
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x2556800 Offset: 0x2555A00 VA: 0x182556800
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x25567B0 Offset: 0x25559B0 VA: 0x1825567B0
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x25569C0 Offset: 0x2555BC0 VA: 0x1825569C0
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x25568E0 Offset: 0x2555AE0 VA: 0x1825568E0
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x2553D70 Offset: 0x2552F70 VA: 0x182553D70
	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	// RVA: 0x25517A0 Offset: 0x25509A0 VA: 0x1825517A0
	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	// RVA: 0x2555CD0 Offset: 0x2554ED0 VA: 0x182555CD0
	public static GameObject CreateText(DefaultControls.Resources resources) { }

	// RVA: 0x2553420 Offset: 0x2552620 VA: 0x182553420
	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	// RVA: 0x25540E0 Offset: 0x25532E0 VA: 0x1825540E0
	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	// RVA: 0x2555390 Offset: 0x2554590 VA: 0x182555390
	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	// RVA: 0x2554D70 Offset: 0x2553F70 VA: 0x182554D70
	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	// RVA: 0x2555E80 Offset: 0x2555080 VA: 0x182555E80
	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	// RVA: 0x2553560 Offset: 0x2552760 VA: 0x182553560
	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	// RVA: 0x2551CA0 Offset: 0x2550EA0 VA: 0x182551CA0
	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	// RVA: 0x2554220 Offset: 0x2553420 VA: 0x182554220
	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	// RVA: 0x2556AA0 Offset: 0x2555CA0 VA: 0x182556AA0
	private static void .cctor() { }
}

// Namespace: 
protected internal class Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 16026
{
	// Fields
	[SerializeField]
	private Text m_Text; // 0x20
	[SerializeField]
	private Image m_Image; // 0x28
	[SerializeField]
	private RectTransform m_RectTransform; // 0x30
	[SerializeField]
	private Toggle m_Toggle; // 0x38

	// Properties
	public Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Text get_text() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_text(Text value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Image get_image() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_image(Image value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public RectTransform get_rectTransform() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Toggle get_toggle() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_toggle(Toggle value) { }

	// RVA: 0x2556DA0 Offset: 0x2555FA0 VA: 0x182556DA0 Slot: 6
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x2556D10 Offset: 0x2555F10 VA: 0x182556D10 Slot: 7
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Dropdown.OptionData // TypeDefIndex: 16027
{
	// Fields
	[SerializeField]
	private string m_Text; // 0x10
	[SerializeField]
	private Sprite m_Image; // 0x18

	// Properties
	public string text { get; set; }
	public Sprite image { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_text() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_text(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Sprite get_image() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_image(Sprite value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(string text) { }

	// RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	public void .ctor(Sprite image) { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string text, Sprite image) { }
}

// Namespace: 
[Serializable]
public class Dropdown.OptionDataList // TypeDefIndex: 16028
{
	// Fields
	[SerializeField]
	private List<Dropdown.OptionData> m_Options; // 0x10

	// Properties
	public List<Dropdown.OptionData> options { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x25689B0 Offset: 0x2567BB0 VA: 0x1825689B0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 16029
{
	// Methods

	// RVA: 0x2556CD0 Offset: 0x2555ED0 VA: 0x182556CD0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Dropdown.<>c__DisplayClass63_0 // TypeDefIndex: 16030
{
	// Fields
	public Dropdown.DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2568F20 Offset: 0x2568120 VA: 0x182568F20
	internal void <Show>b__0(bool x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Dropdown.<DelayedDestroyDropdownList>d__75 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 16031
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public Dropdown <>4__this; // 0x28

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

	// RVA: 0x2568C50 Offset: 0x2567E50 VA: 0x182568C50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x2568D00 Offset: 0x2567F00 VA: 0x182568D00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Legacy/Dropdown", 102)]
public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 16032
{
	// Fields
	[SerializeField]
	private RectTransform m_Template; // 0x100
	[SerializeField]
	private Text m_CaptionText; // 0x108
	[SerializeField]
	private Image m_CaptionImage; // 0x110
	[Space]
	[SerializeField]
	private Text m_ItemText; // 0x118
	[SerializeField]
	private Image m_ItemImage; // 0x120
	[Space]
	[SerializeField]
	private int m_Value; // 0x128
	[Space]
	[SerializeField]
	private Dropdown.OptionDataList m_Options; // 0x130
	[SerializeField]
	[Space]
	private Dropdown.DropdownEvent m_OnValueChanged; // 0x138
	[SerializeField]
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private List<Dropdown.DropdownItem> m_Items; // 0x158
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private const int kHighSortingLayer = 30000;
	private static Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<Dropdown.OptionData> options { get; set; }
	public Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }

	// Methods

	// RVA: 0x7960A0 Offset: 0x7952A0 VA: 0x1807960A0
	public RectTransform get_template() { }

	// RVA: 0x255A1F0 Offset: 0x25593F0 VA: 0x18255A1F0
	public void set_template(RectTransform value) { }

	// RVA: 0x789810 Offset: 0x788A10 VA: 0x180789810
	public Text get_captionText() { }

	// RVA: 0x255A190 Offset: 0x2559390 VA: 0x18255A190
	public void set_captionText(Text value) { }

	// RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520
	public Image get_captionImage() { }

	// RVA: 0x255A180 Offset: 0x2559380 VA: 0x18255A180
	public void set_captionImage(Image value) { }

	// RVA: 0x6ED510 Offset: 0x6EC710 VA: 0x1806ED510
	public Text get_itemText() { }

	// RVA: 0x255A1B0 Offset: 0x25593B0 VA: 0x18255A1B0
	public void set_itemText(Text value) { }

	// RVA: 0x53DA70 Offset: 0x53CC70 VA: 0x18053DA70
	public Image get_itemImage() { }

	// RVA: 0x255A1A0 Offset: 0x25593A0 VA: 0x18255A1A0
	public void set_itemImage(Image value) { }

	// RVA: 0x255A150 Offset: 0x2559350 VA: 0x18255A150
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x255A1C0 Offset: 0x25593C0 VA: 0x18255A1C0
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x794CA0 Offset: 0x793EA0 VA: 0x180794CA0
	public Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x1C62530 Offset: 0x1C61730 VA: 0x181C62530
	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	// RVA: 0x19A2DE0 Offset: 0x19A1FE0 VA: 0x1819A2DE0
	public float get_alphaFadeSpeed() { }

	// RVA: 0x255A170 Offset: 0x2559370 VA: 0x18255A170
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x21FCEB0 Offset: 0x21FC0B0 VA: 0x1821FCEB0
	public int get_value() { }

	// RVA: 0x255A200 Offset: 0x2559400 VA: 0x18255A200
	public void set_value(int value) { }

	// RVA: 0x2558730 Offset: 0x2557930 VA: 0x182558730
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x2558740 Offset: 0x2557940 VA: 0x182558740
	private void Set(int value, bool sendCallback = True) { }

	// RVA: 0x2559FE0 Offset: 0x25591E0 VA: 0x182559FE0
	protected void .ctor() { }

	// RVA: 0x2557660 Offset: 0x2556860 VA: 0x182557660 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2559EE0 Offset: 0x25590E0 VA: 0x182559EE0 Slot: 6
	protected override void Start() { }

	// RVA: 0x25582A0 Offset: 0x25574A0 VA: 0x1825582A0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2558470 Offset: 0x2557670 VA: 0x182558470
	public void RefreshShownValue() { }

	// RVA: 0x25573F0 Offset: 0x25565F0 VA: 0x1825573F0
	public void AddOptions(List<Dropdown.OptionData> options) { }

	// RVA: 0x2557130 Offset: 0x2556330 VA: 0x182557130
	public void AddOptions(List<string> options) { }

	// RVA: 0x2557290 Offset: 0x2556490 VA: 0x182557290
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x2557770 Offset: 0x2556970 VA: 0x182557770
	public void ClearOptions() { }

	// RVA: 0x2558870 Offset: 0x2557A70 VA: 0x182558870
	private void SetupTemplate(Canvas rootCanvas) { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x965450 Offset: 0x964650 VA: 0x180965450
	|-Dropdown.GetOrAddComponent<object>
	*/

	// RVA: 0x2558340 Offset: 0x2557540 VA: 0x182558340 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2558340 Offset: 0x2557540 VA: 0x182558340 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2558290 Offset: 0x2557490 VA: 0x182558290 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x2558F60 Offset: 0x2558160 VA: 0x182558F60
	public void Show() { }

	// RVA: 0x25577F0 Offset: 0x25569F0 VA: 0x1825577F0 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x2557E70 Offset: 0x2557070 VA: 0x182557E70 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x2557D40 Offset: 0x2556F40 VA: 0x182557D40 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x2557EC0 Offset: 0x25570C0 VA: 0x182557EC0 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x2557DA0 Offset: 0x2556FA0 VA: 0x182557DA0 Slot: 49
	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 50
	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	// RVA: 0x2556E20 Offset: 0x2556020 VA: 0x182556E20
	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	// RVA: 0x25575D0 Offset: 0x25567D0 VA: 0x1825575D0
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x2557460 Offset: 0x2556660 VA: 0x182557460
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x2558680 Offset: 0x2557880 VA: 0x182558680
	private void SetAlpha(float alpha) { }

	// RVA: 0x2557F10 Offset: 0x2557110 VA: 0x182557F10
	public void Hide() { }

	[IteratorStateMachine(typeof(Dropdown.<DelayedDestroyDropdownList>d__75))]
	// RVA: 0x2557E00 Offset: 0x2557000 VA: 0x182557E00
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x25580E0 Offset: 0x25572E0 VA: 0x1825580E0
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x2558350 Offset: 0x2557550 VA: 0x182558350
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x2559F80 Offset: 0x2559180 VA: 0x182559F80
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 16033
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("font")]
	private Font m_Font; // 0x10
	[SerializeField]
	[FormerlySerializedAs("fontSize")]
	private int m_FontSize; // 0x18
	[SerializeField]
	[FormerlySerializedAs("fontStyle")]
	private FontStyle m_FontStyle; // 0x1C
	[SerializeField]
	private bool m_BestFit; // 0x20
	[SerializeField]
	private int m_MinSize; // 0x24
	[SerializeField]
	private int m_MaxSize; // 0x28
	[SerializeField]
	[FormerlySerializedAs("alignment")]
	private TextAnchor m_Alignment; // 0x2C
	[SerializeField]
	private bool m_AlignByGeometry; // 0x30
	[FormerlySerializedAs("richText")]
	[SerializeField]
	private bool m_RichText; // 0x31
	[SerializeField]
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	[SerializeField]
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	[SerializeField]
	private float m_LineSpacing; // 0x3C

	// Properties
	public static FontData defaultFontData { get; }
	public Font font { get; set; }
	public int fontSize { get; set; }
	public FontStyle fontStyle { get; set; }
	public bool bestFit { get; set; }
	public int minSize { get; set; }
	public int maxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public bool richText { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }

	// Methods

	// RVA: 0x255A260 Offset: 0x2559460 VA: 0x18255A260
	public static FontData get_defaultFontData() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Font get_font() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_font(Font value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_fontSize() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_fontSize(int value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public FontStyle get_fontStyle() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_bestFit() { }

	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_bestFit(bool value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_minSize() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_minSize(int value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_maxSize() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_maxSize(int value) { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public TextAnchor get_alignment() { }

	// RVA: 0x5014F0 Offset: 0x5006F0 VA: 0x1805014F0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_alignByGeometry() { }

	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x577B10 Offset: 0x576D10 VA: 0x180577B10
	public bool get_richText() { }

	// RVA: 0x21BB040 Offset: 0x21BA240 VA: 0x1821BB040
	public void set_richText(bool value) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x5D01F0 Offset: 0x5CF3F0 VA: 0x1805D01F0
	public float get_lineSpacing() { }

	// RVA: 0x5D0200 Offset: 0x5CF400 VA: 0x1805D0200
	public void set_lineSpacing(float value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x255A210 Offset: 0x2559410 VA: 0x18255A210 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public static class FontUpdateTracker // TypeDefIndex: 16034
{
	// Fields
	private static Dictionary<Font, HashSet<Text>> m_Tracked; // 0x0

	// Methods

	// RVA: 0x255A450 Offset: 0x2559650 VA: 0x18255A450
	public static void TrackText(Text t) { }

	// RVA: 0x255A2E0 Offset: 0x25594E0 VA: 0x18255A2E0
	private static void RebuildForFont(Font f) { }

	// RVA: 0x255A6A0 Offset: 0x25598A0 VA: 0x18255A6A0
	public static void UntrackText(Text t) { }

	// RVA: 0x255A8B0 Offset: 0x2559AB0 VA: 0x18255A8B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 16035
{
	// Fields
	protected static Material s_DefaultUI; // 0x0
	protected static Texture2D s_WhiteTexture; // 0x8
	[SerializeField]
	[FormerlySerializedAs("m_Mat")]
	protected Material m_Material; // 0x20
	[SerializeField]
	private Color m_Color; // 0x28
	protected bool m_SkipLayoutUpdate; // 0x38
	protected bool m_SkipMaterialUpdate; // 0x39
	[SerializeField]
	private bool m_RaycastTarget; // 0x3A
	private bool m_RaycastTargetCache; // 0x3B
	[SerializeField]
	private Vector4 m_RaycastPadding; // 0x3C
	private RectTransform m_RectTransform; // 0x50
	private CanvasRenderer m_CanvasRenderer; // 0x58
	private Canvas m_Canvas; // 0x60
	private bool m_VertsDirty; // 0x68
	private bool m_MaterialDirty; // 0x69
	protected UnityAction m_OnDirtyLayoutCallback; // 0x70
	protected UnityAction m_OnDirtyVertsCallback; // 0x78
	protected UnityAction m_OnDirtyMaterialCallback; // 0x80
	protected static Mesh s_Mesh; // 0x10
	private static readonly VertexHelper s_VertexHelper; // 0x18
	protected Mesh m_CachedMesh; // 0x88
	protected Vector2[] m_CachedUvs; // 0x90
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; // 0x98
	[CompilerGenerated]
	private bool <useLegacyMeshGeneration>k__BackingField; // 0xA0

	// Properties
	public static Material defaultGraphicMaterial { get; }
	public virtual Color color { get; set; }
	public virtual bool raycastTarget { get; set; }
	public Vector4 raycastPadding { get; set; }
	protected bool useLegacyMeshGeneration { get; set; }
	public int depth { get; }
	public RectTransform rectTransform { get; }
	public Canvas canvas { get; }
	public CanvasRenderer canvasRenderer { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Material material { get; set; }
	public virtual Material materialForRendering { get; }
	public virtual Texture mainTexture { get; }
	protected static Mesh workerMesh { get; }

	// Methods

	// RVA: 0x255FF80 Offset: 0x255F180 VA: 0x18255FF80
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80 Slot: 22
	public virtual Color get_color() { }

	// RVA: 0x25605F0 Offset: 0x255F7F0 VA: 0x1825605F0 Slot: 23
	public virtual void set_color(Color value) { }

	// RVA: 0x161DE50 Offset: 0x161D050 VA: 0x18161DE50 Slot: 24
	public virtual bool get_raycastTarget() { }

	// RVA: 0x25606E0 Offset: 0x255F8E0 VA: 0x1825606E0 Slot: 25
	public virtual void set_raycastTarget(bool value) { }

	// RVA: 0x2560450 Offset: 0x255F650 VA: 0x182560450
	public Vector4 get_raycastPadding() { }

	// RVA: 0x25606D0 Offset: 0x255F8D0 VA: 0x1825606D0
	public void set_raycastPadding(Vector4 value) { }

	[CompilerGenerated]
	// RVA: 0x1200DC0 Offset: 0x11FFFC0 VA: 0x181200DC0
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGenerated]
	// RVA: 0x1200DD0 Offset: 0x11FFFD0 VA: 0x181200DD0
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x255FDC0 Offset: 0x255EFC0 VA: 0x18255FDC0
	protected void .ctor() { }

	// RVA: 0x255F680 Offset: 0x255E880 VA: 0x18255F680 Slot: 26
	public virtual void SetAllDirty() { }

	// RVA: 0x255F6F0 Offset: 0x255E8F0 VA: 0x18255F6F0 Slot: 27
	public virtual void SetLayoutDirty() { }

	// RVA: 0x255F980 Offset: 0x255EB80 VA: 0x18255F980 Slot: 28
	public virtual void SetVerticesDirty() { }

	// RVA: 0x255F7C0 Offset: 0x255E9C0 VA: 0x18255F7C0 Slot: 29
	public virtual void SetMaterialDirty() { }

	// RVA: 0x255F8A0 Offset: 0x255EAA0 VA: 0x18255F8A0
	public void SetRaycastDirty() { }

	// RVA: 0x255ED20 Offset: 0x255DF20 VA: 0x18255ED20 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x255E2D0 Offset: 0x255D4D0 VA: 0x18255E2D0 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x255EE10 Offset: 0x255E010 VA: 0x18255EE10 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2560170 Offset: 0x255F370 VA: 0x182560170
	public int get_depth() { }

	// RVA: 0x2560460 Offset: 0x255F660 VA: 0x182560460 Slot: 30
	public RectTransform get_rectTransform() { }

	// RVA: 0x255FF10 Offset: 0x255F110 VA: 0x18255FF10
	public Canvas get_canvas() { }

	// RVA: 0x255D1B0 Offset: 0x255C3B0 VA: 0x18255D1B0
	private void CacheCanvas() { }

	// RVA: 0x255FE80 Offset: 0x255F080 VA: 0x18255FE80
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x2560060 Offset: 0x255F260 VA: 0x182560060 Slot: 31
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x25603C0 Offset: 0x255F5C0 VA: 0x1825603C0 Slot: 32
	public virtual Material get_material() { }

	// RVA: 0x2560640 Offset: 0x255F840 VA: 0x182560640 Slot: 33
	public virtual void set_material(Material value) { }

	// RVA: 0x25601F0 Offset: 0x255F3F0 VA: 0x1825601F0 Slot: 34
	public virtual Material get_materialForRendering() { }

	// RVA: 0x25601A0 Offset: 0x255F3A0 VA: 0x1825601A0 Slot: 35
	public virtual Texture get_mainTexture() { }

	// RVA: 0x255E900 Offset: 0x255DB00 VA: 0x18255E900 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x255E750 Offset: 0x255D950 VA: 0x18255E750 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x255E600 Offset: 0x255D800 VA: 0x18255E600 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x255E3E0 Offset: 0x255D5E0 VA: 0x18255E3E0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x255E530 Offset: 0x255D730 VA: 0x18255E530 Slot: 36
	public virtual void OnCullingChanged() { }

	// RVA: 0x255F3C0 Offset: 0x255E5C0 VA: 0x18255F3C0 Slot: 37
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 38
	public virtual void LayoutComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 39
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x255FC60 Offset: 0x255EE60 VA: 0x18255FC60 Slot: 40
	protected virtual void UpdateMaterial() { }

	// RVA: 0x255FC40 Offset: 0x255EE40 VA: 0x18255FC40 Slot: 41
	protected virtual void UpdateGeometry() { }

	// RVA: 0x255DBE0 Offset: 0x255CDE0 VA: 0x18255DBE0
	private void DoMeshGeneration() { }

	// RVA: 0x255D730 Offset: 0x255C930 VA: 0x18255D730
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x25604B0 Offset: 0x255F6B0 VA: 0x1825604B0
	protected static Mesh get_workerMesh() { }

	[Obsolete("Use OnPopulateMesh instead.", True)]
	[EditorBrowsable(1)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 42
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", False)]
	// RVA: 0x255EA70 Offset: 0x255DC70 VA: 0x18255EA70 Slot: 43
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x255EB10 Offset: 0x255DD10 VA: 0x18255EB10 Slot: 44
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x209D490 Offset: 0x209C690 VA: 0x18209D490 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 45
	public virtual void SetNativeSize() { }

	// RVA: 0x255F060 Offset: 0x255E260 VA: 0x18255F060 Slot: 46
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x255EED0 Offset: 0x255E0D0 VA: 0x18255EED0
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x255E0F0 Offset: 0x255D2F0 VA: 0x18255E0F0
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x255D6F0 Offset: 0x255C8F0 VA: 0x18255D6F0 Slot: 47
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x255D410 Offset: 0x255C610 VA: 0x18255D410 Slot: 48
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x255D320 Offset: 0x255C520 VA: 0x18255D320
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x255D340 Offset: 0x255C540 VA: 0x18255D340 Slot: 49
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x255F4A0 Offset: 0x255E6A0 VA: 0x18255F4A0
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x255FA60 Offset: 0x255EC60 VA: 0x18255FA60
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x255F5E0 Offset: 0x255E7E0 VA: 0x18255F5E0
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x255FBA0 Offset: 0x255EDA0 VA: 0x18255FBA0
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x255F540 Offset: 0x255E740 VA: 0x18255F540
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x255FB00 Offset: 0x255ED00 VA: 0x18255FB00
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x255FD30 Offset: 0x255EF30 VA: 0x18255FD30
	private static void .cctor() { }

	// RVA: 0x23F4140 Offset: 0x23F3340 VA: 0x1823F4140 Slot: 18
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum GraphicRaycaster.BlockingObjects // TypeDefIndex: 16036
{
	// Fields
	public int value__; // 0x0
	public const GraphicRaycaster.BlockingObjects None = 0;
	public const GraphicRaycaster.BlockingObjects TwoD = 1;
	public const GraphicRaycaster.BlockingObjects ThreeD = 2;
	public const GraphicRaycaster.BlockingObjects All = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GraphicRaycaster.<>c // TypeDefIndex: 16037
{
	// Fields
	public static readonly GraphicRaycaster.<>c <>9; // 0x0
	public static Comparison<Graphic> <>9__27_0; // 0x8

	// Methods

	// RVA: 0x2569050 Offset: 0x2568250 VA: 0x182569050
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2568EB0 Offset: 0x25680B0 VA: 0x182568EB0
	internal int <Raycast>b__27_0(Graphic g1, Graphic g2) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Event/Graphic Raycaster")]
[RequireComponent(typeof(Canvas))]
public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 16038
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	[SerializeField]
	[FormerlySerializedAs("ignoreReversedGraphics")]
	private bool m_IgnoreReversedGraphics; // 0x28
	[FormerlySerializedAs("blockingObjects")]
	[SerializeField]
	private GraphicRaycaster.BlockingObjects m_BlockingObjects; // 0x2C
	[SerializeField]
	protected LayerMask m_BlockingMask; // 0x30
	private Canvas m_Canvas; // 0x38
	private List<Graphic> m_RaycastResults; // 0x40
	private static readonly List<Graphic> s_SortedGraphics; // 0x0

	// Properties
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public bool ignoreReversedGraphics { get; set; }
	public GraphicRaycaster.BlockingObjects blockingObjects { get; set; }
	public LayerMask blockingMask { get; set; }
	private Canvas canvas { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x255BFC0 Offset: 0x255B1C0 VA: 0x18255BFC0 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x255BF60 Offset: 0x255B160 VA: 0x18255BF60 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	// RVA: 0x5014F0 Offset: 0x5006F0 VA: 0x1805014F0
	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public LayerMask get_blockingMask() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x255BD90 Offset: 0x255AF90 VA: 0x18255BD90
	protected void .ctor() { }

	// RVA: 0x255BE10 Offset: 0x255B010 VA: 0x18255BE10
	private Canvas get_canvas() { }

	// RVA: 0x255AED0 Offset: 0x255A0D0 VA: 0x18255AED0 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x255BEA0 Offset: 0x255B0A0 VA: 0x18255BEA0 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x255A920 Offset: 0x2559B20 VA: 0x18255A920
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	// RVA: 0x255BD20 Offset: 0x255AF20 VA: 0x18255BD20
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
public class GraphicRegistry // TypeDefIndex: 16039
{
	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics; // 0x18
	private static readonly List<Graphic> s_EmptyList; // 0x8

	// Properties
	public static GraphicRegistry instance { get; }

	// Methods

	// RVA: 0x255CE10 Offset: 0x255C010 VA: 0x18255CE10
	protected void .ctor() { }

	// RVA: 0x255CF80 Offset: 0x255C180 VA: 0x18255CF80
	public static GraphicRegistry get_instance() { }

	// RVA: 0x255C630 Offset: 0x255B830 VA: 0x18255C630
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x255C830 Offset: 0x255BA30 VA: 0x18255C830
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x255CA50 Offset: 0x255BC50 VA: 0x18255CA50
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x255CC10 Offset: 0x255BE10 VA: 0x18255CC10
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x255C020 Offset: 0x255B220 VA: 0x18255C020
	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x255C320 Offset: 0x255B520 VA: 0x18255C320
	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x255C4B0 Offset: 0x255B6B0 VA: 0x18255C4B0
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x255C570 Offset: 0x255B770 VA: 0x18255C570
	public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x255CDA0 Offset: 0x255BFA0 VA: 0x18255CDA0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Not supported anymore")]
internal interface IGraphicEnabledDisabled // TypeDefIndex: 16040
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSiblingGraphicEnabledDisabled();
}

// Namespace: 
public enum Image.Type // TypeDefIndex: 16041
{
	// Fields
	public int value__; // 0x0
	public const Image.Type Simple = 0;
	public const Image.Type Sliced = 1;
	public const Image.Type Tiled = 2;
	public const Image.Type Filled = 3;
}

// Namespace: 
public enum Image.FillMethod // TypeDefIndex: 16042
{
	// Fields
	public int value__; // 0x0
	public const Image.FillMethod Horizontal = 0;
	public const Image.FillMethod Vertical = 1;
	public const Image.FillMethod Radial90 = 2;
	public const Image.FillMethod Radial180 = 3;
	public const Image.FillMethod Radial360 = 4;
}

// Namespace: 
public enum Image.OriginHorizontal // TypeDefIndex: 16043
{
	// Fields
	public int value__; // 0x0
	public const Image.OriginHorizontal Left = 0;
	public const Image.OriginHorizontal Right = 1;
}

// Namespace: 
public enum Image.OriginVertical // TypeDefIndex: 16044
{
	// Fields
	public int value__; // 0x0
	public const Image.OriginVertical Bottom = 0;
	public const Image.OriginVertical Top = 1;
}

// Namespace: 
public enum Image.Origin90 // TypeDefIndex: 16045
{
	// Fields
	public int value__; // 0x0
	public const Image.Origin90 BottomLeft = 0;
	public const Image.Origin90 TopLeft = 1;
	public const Image.Origin90 TopRight = 2;
	public const Image.Origin90 BottomRight = 3;
}

// Namespace: 
public enum Image.Origin180 // TypeDefIndex: 16046
{
	// Fields
	public int value__; // 0x0
	public const Image.Origin180 Bottom = 0;
	public const Image.Origin180 Left = 1;
	public const Image.Origin180 Top = 2;
	public const Image.Origin180 Right = 3;
}

// Namespace: 
public enum Image.Origin360 // TypeDefIndex: 16047
{
	// Fields
	public int value__; // 0x0
	public const Image.Origin360 Bottom = 0;
	public const Image.Origin360 Right = 1;
	public const Image.Origin360 Top = 2;
	public const Image.Origin360 Left = 3;
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/Image", 11)]
public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 16048
{
	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
	[SerializeField]
	[FormerlySerializedAs("m_Frame")]
	private Sprite m_Sprite; // 0xE0
	private Sprite m_OverrideSprite; // 0xE8
	[SerializeField]
	private Image.Type m_Type; // 0xF0
	[SerializeField]
	private bool m_PreserveAspect; // 0xF4
	[SerializeField]
	private bool m_FillCenter; // 0xF5
	[SerializeField]
	private Image.FillMethod m_FillMethod; // 0xF8
	[Range(0, 1)]
	[SerializeField]
	private float m_FillAmount; // 0xFC
	[SerializeField]
	private bool m_FillClockwise; // 0x100
	[SerializeField]
	private int m_FillOrigin; // 0x104
	private float m_AlphaHitTestMinimumThreshold; // 0x108
	private bool m_Tracked; // 0x10C
	[SerializeField]
	private bool m_UseSpriteMesh; // 0x10D
	[SerializeField]
	private float m_PixelsPerUnitMultiplier; // 0x110
	private float m_CachedReferencePixelsPerUnit; // 0x114
	private static readonly Vector2[] s_VertScratch; // 0x8
	private static readonly Vector2[] s_UVScratch; // 0x10
	private static readonly Vector3[] s_Xy; // 0x18
	private static readonly Vector3[] s_Uv; // 0x20
	private static List<Image> m_TrackedTexturelessImages; // 0x28
	private static bool s_Initialized; // 0x30

	// Properties
	public Sprite sprite { get; set; }
	public Sprite overrideSprite { get; set; }
	private Sprite activeSprite { get; }
	public Image.Type type { get; set; }
	public bool preserveAspect { get; set; }
	public bool fillCenter { get; set; }
	public Image.FillMethod fillMethod { get; set; }
	public float fillAmount { get; set; }
	public bool fillClockwise { get; set; }
	public int fillOrigin { get; set; }
	[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
	public float eventAlphaThreshold { get; set; }
	public float alphaHitTestMinimumThreshold { get; set; }
	public bool useSpriteMesh { get; set; }
	public static Material defaultETC1GraphicMaterial { get; }
	public override Texture mainTexture { get; }
	public bool hasBorder { get; }
	public float pixelsPerUnitMultiplier { get; set; }
	public float pixelsPerUnit { get; }
	protected float multipliedPixelsPerUnit { get; }
	public override Material material { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	public Sprite get_sprite() { }

	// RVA: 0x25685F0 Offset: 0x25677F0 VA: 0x1825685F0
	public void set_sprite(Sprite value) { }

	// RVA: 0x2560B80 Offset: 0x255FD80 VA: 0x182560B80
	public void DisableSpriteOptimizations() { }

	// RVA: 0x2567C30 Offset: 0x2566E30 VA: 0x182567C30
	public Sprite get_overrideSprite() { }

	// RVA: 0x25684D0 Offset: 0x25676D0 VA: 0x1825684D0
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x25675D0 Offset: 0x25667D0 VA: 0x1825675D0
	private Sprite get_activeSprite() { }

	// RVA: 0x190DCF0 Offset: 0x190CEF0 VA: 0x18190DCF0
	public Image.Type get_type() { }

	// RVA: 0x25688D0 Offset: 0x2567AD0 VA: 0x1825688D0
	public void set_type(Image.Type value) { }

	// RVA: 0x7724D0 Offset: 0x7716D0 VA: 0x1807724D0
	public bool get_preserveAspect() { }

	// RVA: 0x2568580 Offset: 0x2567780 VA: 0x182568580
	public void set_preserveAspect(bool value) { }

	// RVA: 0x772490 Offset: 0x771690 VA: 0x180772490
	public bool get_fillCenter() { }

	// RVA: 0x2568310 Offset: 0x2567510 VA: 0x182568310
	public void set_fillCenter(bool value) { }

	// RVA: 0x190DD30 Offset: 0x190CF30 VA: 0x18190DD30
	public Image.FillMethod get_fillMethod() { }

	// RVA: 0x25683F0 Offset: 0x25675F0 VA: 0x1825683F0
	public void set_fillMethod(Image.FillMethod value) { }

	// RVA: 0x2567760 Offset: 0x2566960 VA: 0x182567760
	public float get_fillAmount() { }

	// RVA: 0x2568280 Offset: 0x2567480 VA: 0x182568280
	public void set_fillAmount(float value) { }

	// RVA: 0x1864140 Offset: 0x1863340 VA: 0x181864140
	public bool get_fillClockwise() { }

	// RVA: 0x2568380 Offset: 0x2567580 VA: 0x182568380
	public void set_fillClockwise(bool value) { }

	// RVA: 0x2567770 Offset: 0x2566970 VA: 0x182567770
	public int get_fillOrigin() { }

	// RVA: 0x2568460 Offset: 0x2567660 VA: 0x182568460
	public void set_fillOrigin(int value) { }

	// RVA: 0x2567740 Offset: 0x2566940 VA: 0x182567740
	public float get_eventAlphaThreshold() { }

	// RVA: 0x2568110 Offset: 0x2567310 VA: 0x182568110
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x2567650 Offset: 0x2566850 VA: 0x182567650
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x2567FB0 Offset: 0x25671B0 VA: 0x182567FB0
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0xB82C00 Offset: 0xB81E00 VA: 0x180B82C00
	public bool get_useSpriteMesh() { }

	// RVA: 0x2568940 Offset: 0x2567B40 VA: 0x182568940
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x2567570 Offset: 0x2566770 VA: 0x182567570
	protected void .ctor() { }

	// RVA: 0x2567660 Offset: 0x2566860 VA: 0x182567660
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x2567870 Offset: 0x2566A70 VA: 0x182567870 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x2567780 Offset: 0x2566980 VA: 0x182567780
	public bool get_hasBorder() { }

	// RVA: 0x2567C40 Offset: 0x2566E40 VA: 0x182567C40
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x2568550 Offset: 0x2567750 VA: 0x182568550
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x2567C50 Offset: 0x2566E50 VA: 0x182567C50
	public float get_pixelsPerUnit() { }

	// RVA: 0x2567C10 Offset: 0x2566E10 VA: 0x182567C10
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x2567A00 Offset: 0x2566C00 VA: 0x182567A00 Slot: 32
	public override Material get_material() { }

	// RVA: 0x2560640 Offset: 0x255F840 VA: 0x182560640 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 77
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x2565B70 Offset: 0x2564D70 VA: 0x182565B70 Slot: 78
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x2565FD0 Offset: 0x25651D0 VA: 0x182565FD0
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	// RVA: 0x2564C10 Offset: 0x2563E10 VA: 0x182564C10
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x2566990 Offset: 0x2565B90 VA: 0x182566990 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x2565E80 Offset: 0x2565080 VA: 0x182565E80 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x2566CF0 Offset: 0x2565EF0 VA: 0x182566CF0
	private void TrackSprite() { }

	// RVA: 0x2565E60 Offset: 0x2565060 VA: 0x182565E60 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2565D90 Offset: 0x2564F90 VA: 0x182565D90 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2567290 Offset: 0x2566490 VA: 0x182567290 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x2565BE0 Offset: 0x2564DE0 VA: 0x182565BE0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x25620B0 Offset: 0x25612B0 VA: 0x1825620B0
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x2562EB0 Offset: 0x25620B0 VA: 0x182562EB0
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x2562470 Offset: 0x2561670 VA: 0x182562470
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x2563480 Offset: 0x2562680 VA: 0x182563480
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x2560A00 Offset: 0x255FC00 VA: 0x182560A00
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x25607C0 Offset: 0x255F9C0 VA: 0x1825607C0
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x2564860 Offset: 0x2563A60 VA: 0x182564860
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x2560B90 Offset: 0x255FD90 VA: 0x182560B90
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x2566130 Offset: 0x2565330 VA: 0x182566130
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x2566280 Offset: 0x2565480 VA: 0x182566280
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 79
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 80
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 81
	public virtual float get_minWidth() { }

	// RVA: 0x2567EA0 Offset: 0x25670A0 VA: 0x182567EA0 Slot: 82
	public virtual float get_preferredWidth() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 83
	public virtual float get_flexibleWidth() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 84
	public virtual float get_minHeight() { }

	// RVA: 0x2567D90 Offset: 0x2566F90 VA: 0x182567D90 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 86
	public virtual float get_flexibleHeight() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 87
	public virtual int get_layoutPriority() { }

	// RVA: 0x2564F80 Offset: 0x2564180 VA: 0x182564F80 Slot: 88
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x25653D0 Offset: 0x25645D0 VA: 0x1825653D0
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x2566790 Offset: 0x2565990 VA: 0x182566790
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x2566B90 Offset: 0x2565D90 VA: 0x182566B90
	private static void TrackImage(Image g) { }

	// RVA: 0x2567210 Offset: 0x2566410 VA: 0x182567210
	private static void UnTrackImage(Image g) { }

	// RVA: 0x2565D40 Offset: 0x2564F40 VA: 0x182565D40 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2567440 Offset: 0x2566640 VA: 0x182567440
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2566F20 Offset: 0x2566120 VA: 0x182566F20
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	[CompilerGenerated]
	// RVA: 0x25670D0 Offset: 0x25662D0 VA: 0x1825670D0
	private bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Not supported anymore.", True)]
[EditorBrowsable(1)]
public interface IMask // TypeDefIndex: 16049
{
	// Properties
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract RectTransform get_rectTransform();
}

// Namespace: UnityEngine.UI
public interface IMaskable // TypeDefIndex: 16050
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RecalculateMasking();
}

// Namespace: 
public enum InputField.ContentType // TypeDefIndex: 16051
{
	// Fields
	public int value__; // 0x0
	public const InputField.ContentType Standard = 0;
	public const InputField.ContentType Autocorrected = 1;
	public const InputField.ContentType IntegerNumber = 2;
	public const InputField.ContentType DecimalNumber = 3;
	public const InputField.ContentType Alphanumeric = 4;
	public const InputField.ContentType Name = 5;
	public const InputField.ContentType EmailAddress = 6;
	public const InputField.ContentType Password = 7;
	public const InputField.ContentType Pin = 8;
	public const InputField.ContentType Custom = 9;
}

// Namespace: 
public enum InputField.InputType // TypeDefIndex: 16052
{
	// Fields
	public int value__; // 0x0
	public const InputField.InputType Standard = 0;
	public const InputField.InputType AutoCorrect = 1;
	public const InputField.InputType Password = 2;
}

// Namespace: 
public enum InputField.CharacterValidation // TypeDefIndex: 16053
{
	// Fields
	public int value__; // 0x0
	public const InputField.CharacterValidation None = 0;
	public const InputField.CharacterValidation Integer = 1;
	public const InputField.CharacterValidation Decimal = 2;
	public const InputField.CharacterValidation Alphanumeric = 3;
	public const InputField.CharacterValidation Name = 4;
	public const InputField.CharacterValidation EmailAddress = 5;
}

// Namespace: 
public enum InputField.LineType // TypeDefIndex: 16054
{
	// Fields
	public int value__; // 0x0
	public const InputField.LineType SingleLine = 0;
	public const InputField.LineType MultiLineSubmit = 1;
	public const InputField.LineType MultiLineNewline = 2;
}

// Namespace: 
public sealed class InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 16055
{
	// Methods

	// RVA: 0x2415B90 Offset: 0x2414D90 VA: 0x182415B90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x26E5DF0 Offset: 0x26E4FF0 VA: 0x1826E5DF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x2415B60 Offset: 0x2414D60 VA: 0x182415B60 Slot: 15
	public virtual char EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[Serializable]
public class InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 16056
{
	// Methods

	// RVA: 0x26E5E90 Offset: 0x26E5090 VA: 0x1826E5E90
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class InputField.EndEditEvent : UnityEvent<string> // TypeDefIndex: 16057
{
	// Methods

	// RVA: 0x26D1E60 Offset: 0x26D1060 VA: 0x1826D1E60
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 16058
{
	// Methods

	// RVA: 0x26E5DB0 Offset: 0x26E4FB0 VA: 0x1826E5DB0
	public void .ctor() { }
}

// Namespace: 
protected enum InputField.EditState // TypeDefIndex: 16059
{
	// Fields
	public int value__; // 0x0
	public const InputField.EditState Continue = 0;
	public const InputField.EditState Finish = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class InputField.<CaretBlink>d__170 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 16060
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InputField <>4__this; // 0x20

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

	// RVA: 0x26E5ED0 Offset: 0x26E50D0 VA: 0x1826E5ED0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x26E6000 Offset: 0x26E5200 VA: 0x1826E6000 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InputField.<MouseDragOutsideRect>d__194 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 16061
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PointerEventData eventData; // 0x20
	public InputField <>4__this; // 0x28

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

	// RVA: 0x26E6100 Offset: 0x26E5300 VA: 0x1826E6100 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x26E6510 Offset: 0x26E5710 VA: 0x1826E6510 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Legacy/Input Field", 103)]
public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 16062
{
	// Fields
	protected TouchScreenKeyboard m_Keyboard; // 0x100
	private static readonly char[] kSeparators; // 0x0
	private static bool s_IsQuestDevice; // 0x8
	[SerializeField]
	[FormerlySerializedAs("text")]
	protected Text m_TextComponent; // 0x108
	[SerializeField]
	protected Graphic m_Placeholder; // 0x110
	[SerializeField]
	private InputField.ContentType m_ContentType; // 0x118
	[FormerlySerializedAs("inputType")]
	[SerializeField]
	private InputField.InputType m_InputType; // 0x11C
	[FormerlySerializedAs("asteriskChar")]
	[SerializeField]
	private char m_AsteriskChar; // 0x120
	[FormerlySerializedAs("keyboardType")]
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; // 0x124
	[SerializeField]
	private InputField.LineType m_LineType; // 0x128
	[SerializeField]
	[FormerlySerializedAs("hideMobileInput")]
	private bool m_HideMobileInput; // 0x12C
	[FormerlySerializedAs("validation")]
	[SerializeField]
	private InputField.CharacterValidation m_CharacterValidation; // 0x130
	[SerializeField]
	[FormerlySerializedAs("characterLimit")]
	private int m_CharacterLimit; // 0x134
	[FormerlySerializedAs("m_OnSubmit")]
	[FormerlySerializedAs("onSubmit")]
	[FormerlySerializedAs("m_EndEdit")]
	[FormerlySerializedAs("m_OnEndEdit")]
	[SerializeField]
	private InputField.SubmitEvent m_OnSubmit; // 0x138
	[SerializeField]
	private InputField.EndEditEvent m_OnDidEndEdit; // 0x140
	[FormerlySerializedAs("onValueChange")]
	[FormerlySerializedAs("m_OnValueChange")]
	[SerializeField]
	private InputField.OnChangeEvent m_OnValueChanged; // 0x148
	[FormerlySerializedAs("onValidateInput")]
	[SerializeField]
	private InputField.OnValidateInput m_OnValidateInput; // 0x150
	[FormerlySerializedAs("selectionColor")]
	[SerializeField]
	private Color m_CaretColor; // 0x158
	[SerializeField]
	private bool m_CustomCaretColor; // 0x168
	[SerializeField]
	private Color m_SelectionColor; // 0x16C
	[SerializeField]
	[Multiline]
	[FormerlySerializedAs("mValue")]
	protected string m_Text; // 0x180
	[SerializeField]
	[Range(0, 4)]
	private float m_CaretBlinkRate; // 0x188
	[SerializeField]
	[Range(1, 5)]
	private int m_CaretWidth; // 0x18C
	[SerializeField]
	private bool m_ReadOnly; // 0x190
	[SerializeField]
	private bool m_ShouldActivateOnSelect; // 0x191
	protected int m_CaretPosition; // 0x194
	protected int m_CaretSelectPosition; // 0x198
	private RectTransform caretRectTrans; // 0x1A0
	protected UIVertex[] m_CursorVerts; // 0x1A8
	private TextGenerator m_InputTextCache; // 0x1B0
	private CanvasRenderer m_CachedInputRenderer; // 0x1B8
	private bool m_PreventFontCallback; // 0x1C0
	protected Mesh m_Mesh; // 0x1C8
	private bool m_AllowInput; // 0x1D0
	private bool m_ShouldActivateNextUpdate; // 0x1D1
	private bool m_UpdateDrag; // 0x1D2
	private bool m_DragPositionOutOfBounds; // 0x1D3
	private const float kHScrollSpeed = 0,05;
	private const float kVScrollSpeed = 0,1;
	protected bool m_CaretVisible; // 0x1D4
	private Coroutine m_BlinkCoroutine; // 0x1D8
	private float m_BlinkStartTime; // 0x1E0
	protected int m_DrawStart; // 0x1E4
	protected int m_DrawEnd; // 0x1E8
	private Coroutine m_DragCoroutine; // 0x1F0
	private string m_OriginalText; // 0x1F8
	private bool m_WasCanceled; // 0x200
	private bool m_HasDoneFocusTransition; // 0x201
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x208
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x210
	private bool m_IsCompositionActive; // 0x211
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private const string kOculusQuestDeviceModel = "Oculus Quest";
	private Event m_ProcessingEvent; // 0x218
	private const int k_MaxTextLength = 16382;

	// Properties
	private BaseInput input { get; }
	private string compositionString { get; }
	protected Mesh mesh { get; }
	protected TextGenerator cachedInputTextGenerator { get; }
	public bool shouldHideMobileInput { get; set; }
	public virtual bool shouldActivateOnSelect { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public InputField.EndEditEvent onEndEdit { get; set; }
	public InputField.SubmitEvent onSubmit { get; set; }
	[Obsolete("onValueChange has been renamed to onValueChanged")]
	public InputField.OnChangeEvent onValueChange { get; set; }
	public InputField.OnChangeEvent onValueChanged { get; set; }
	public InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public InputField.ContentType contentType { get; set; }
	public InputField.LineType lineType { get; set; }
	public InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public InputField.CharacterValidation characterValidation { get; set; }
	public bool readOnly { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x26DDE00 Offset: 0x26DD000 VA: 0x1826DDE00
	private BaseInput get_input() { }

	// RVA: 0x26DDCF0 Offset: 0x26DCEF0 VA: 0x1826DDCF0
	private string get_compositionString() { }

	// RVA: 0x26DD970 Offset: 0x26DCB70 VA: 0x1826DD970
	protected void .ctor() { }

	// RVA: 0x26DDF10 Offset: 0x26DD110 VA: 0x1826DDF10
	protected Mesh get_mesh() { }

	// RVA: 0x26DDB70 Offset: 0x26DCD70 VA: 0x1826DDB70
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x26DF070 Offset: 0x26DE270 VA: 0x1826DF070
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x26DE410 Offset: 0x26DD610 VA: 0x1826DE410
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x26DF060 Offset: 0x26DE260 VA: 0x1826DF060 Slot: 59
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x26DE3B0 Offset: 0x26DD5B0 VA: 0x1826DE3B0 Slot: 60
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x78AC50 Offset: 0x789E50 VA: 0x18078AC50
	public string get_text() { }

	// RVA: 0x26DF360 Offset: 0x26DE560 VA: 0x1826DF360
	public void set_text(string value) { }

	// RVA: 0x26DBF50 Offset: 0x26DB150 VA: 0x1826DBF50
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x26DBF60 Offset: 0x26DB160 VA: 0x1826DBF60
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x26DDF00 Offset: 0x26DD100 VA: 0x1826DDF00
	public bool get_isFocused() { }

	// RVA: 0x26DDBE0 Offset: 0x26DCDE0 VA: 0x1826DDBE0
	public float get_caretBlinkRate() { }

	// RVA: 0x26DE4E0 Offset: 0x26DD6E0 VA: 0x1826DE4E0
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x1C612F0 Offset: 0x1C604F0 VA: 0x181C612F0
	public int get_caretWidth() { }

	// RVA: 0x26DE720 Offset: 0x26DD920 VA: 0x1826DE720
	public void set_caretWidth(int value) { }

	// RVA: 0x789810 Offset: 0x788A10 VA: 0x180789810
	public Text get_textComponent() { }

	// RVA: 0x26DF0C0 Offset: 0x26DE2C0 VA: 0x1826DF0C0
	public void set_textComponent(Text value) { }

	// RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520
	public Graphic get_placeholder() { }

	// RVA: 0x26DEEB0 Offset: 0x26DE0B0 VA: 0x1826DEEB0
	public void set_placeholder(Graphic value) { }

	// RVA: 0x26DDBF0 Offset: 0x26DCDF0 VA: 0x1826DDBF0
	public Color get_caretColor() { }

	// RVA: 0x26DE550 Offset: 0x26DD750 VA: 0x1826DE550
	public void set_caretColor(Color value) { }

	// RVA: 0x2413450 Offset: 0x2412650 VA: 0x182413450
	public bool get_customCaretColor() { }

	// RVA: 0x26DEB50 Offset: 0x26DDD50 VA: 0x1826DEB50
	public void set_customCaretColor(bool value) { }

	// RVA: 0x26DE3A0 Offset: 0x26DD5A0 VA: 0x1826DE3A0
	public Color get_selectionColor() { }

	// RVA: 0x26DEF80 Offset: 0x26DE180 VA: 0x1826DEF80
	public void set_selectionColor(Color value) { }

	// RVA: 0x78BCB0 Offset: 0x78AEB0 VA: 0x18078BCB0
	public InputField.EndEditEvent get_onEndEdit() { }

	// RVA: 0x26DED70 Offset: 0x26DDF70 VA: 0x1826DED70
	public void set_onEndEdit(InputField.EndEditEvent value) { }

	// RVA: 0x794CA0 Offset: 0x793EA0 VA: 0x180794CA0
	public InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0x26DEDC0 Offset: 0x26DDFC0 VA: 0x1826DEDC0
	public void set_onSubmit(InputField.SubmitEvent value) { }

	// RVA: 0x794D90 Offset: 0x793F90 VA: 0x180794D90
	public InputField.OnChangeEvent get_onValueChange() { }

	// RVA: 0x26DEE60 Offset: 0x26DE060 VA: 0x1826DEE60
	public void set_onValueChange(InputField.OnChangeEvent value) { }

	// RVA: 0x794D90 Offset: 0x793F90 VA: 0x180794D90
	public InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x26DEE60 Offset: 0x26DE060 VA: 0x1826DEE60
	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	// RVA: 0x794D40 Offset: 0x793F40 VA: 0x180794D40
	public InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x26DEE10 Offset: 0x26DE010 VA: 0x1826DEE10
	public void set_onValidateInput(InputField.OnValidateInput value) { }

	// RVA: 0x1C61750 Offset: 0x1C60950 VA: 0x181C61750
	public int get_characterLimit() { }

	// RVA: 0x26DE7B0 Offset: 0x26DD9B0 VA: 0x1826DE7B0
	public void set_characterLimit(int value) { }

	// RVA: 0x25E7AB0 Offset: 0x25E6CB0 VA: 0x1825E7AB0
	public InputField.ContentType get_contentType() { }

	// RVA: 0x26DE920 Offset: 0x26DDB20 VA: 0x1826DE920
	public void set_contentType(InputField.ContentType value) { }

	// RVA: 0x21FCEB0 Offset: 0x21FC0B0 VA: 0x1821FCEB0
	public InputField.LineType get_lineType() { }

	// RVA: 0x26DEC90 Offset: 0x26DDE90 VA: 0x1826DEC90
	public void set_lineType(InputField.LineType value) { }

	// RVA: 0x25E7AA0 Offset: 0x25E6CA0 VA: 0x1825E7AA0
	public InputField.InputType get_inputType() { }

	// RVA: 0x26DEBB0 Offset: 0x26DDDB0 VA: 0x1826DEBB0
	public void set_inputType(InputField.InputType value) { }

	// RVA: 0x7960A0 Offset: 0x7952A0 VA: 0x1807960A0
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x1B89CB0 Offset: 0x1B88EB0 VA: 0x181B89CB0
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x26DEC20 Offset: 0x26DDE20 VA: 0x1826DEC20
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x1C61760 Offset: 0x1C60960 VA: 0x181C61760
	public InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x26DE860 Offset: 0x26DDA60 VA: 0x1826DE860
	public void set_characterValidation(InputField.CharacterValidation value) { }

	// RVA: 0x19AD240 Offset: 0x19AC440 VA: 0x1819AD240
	public bool get_readOnly() { }

	// RVA: 0x26DEF00 Offset: 0x26DE100 VA: 0x1826DEF00
	public void set_readOnly(bool value) { }

	// RVA: 0x26DDFC0 Offset: 0x26DD1C0 VA: 0x1826DDFC0
	public bool get_multiLine() { }

	// RVA: 0x26DDB60 Offset: 0x26DCD60 VA: 0x1826DDB60
	public char get_asteriskChar() { }

	// RVA: 0x26DE480 Offset: 0x26DD680 VA: 0x1826DE480
	public void set_asteriskChar(char value) { }

	// RVA: 0x26DE470 Offset: 0x26DD670 VA: 0x1826DE470
	public bool get_wasCanceled() { }

	// RVA: 0x26D5230 Offset: 0x26D4430 VA: 0x1826D5230
	protected void ClampPos(ref int pos) { }

	// RVA: 0x26DDC50 Offset: 0x26DCE50 VA: 0x1826DDC50
	protected int get_caretPositionInternal() { }

	// RVA: 0x26DE5C0 Offset: 0x26DD7C0 VA: 0x1826DE5C0
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x26DDC80 Offset: 0x26DCE80 VA: 0x1826DDC80
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x26DE6D0 Offset: 0x26DD8D0 VA: 0x1826DE6D0
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x26DDDA0 Offset: 0x26DCFA0 VA: 0x1826DDDA0
	private bool get_hasSelection() { }

	// RVA: 0x26DDC80 Offset: 0x26DCE80 VA: 0x1826DDC80
	public int get_caretPosition() { }

	// RVA: 0x26DE610 Offset: 0x26DD810 VA: 0x1826DE610
	public void set_caretPosition(int value) { }

	// RVA: 0x26DDC50 Offset: 0x26DCE50 VA: 0x1826DDC50
	public int get_selectionAnchorPosition() { }

	// RVA: 0x26DEF10 Offset: 0x26DE110 VA: 0x1826DEF10
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x26DDC80 Offset: 0x26DCE80 VA: 0x1826DDC80
	public int get_selectionFocusPosition() { }

	// RVA: 0x26DEFF0 Offset: 0x26DE1F0 VA: 0x1826DEFF0
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x26DA470 Offset: 0x26D9670 VA: 0x1826DA470 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26D9F60 Offset: 0x26D9160 VA: 0x1826D9F60 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26D9F00 Offset: 0x26D9100 VA: 0x1826D9F00 Slot: 8
	protected override void OnDestroy() { }

	[IteratorStateMachine(typeof(InputField.<CaretBlink>d__170))]
	// RVA: 0x26D51D0 Offset: 0x26D43D0 VA: 0x1826D51D0
	private IEnumerator CaretBlink() { }

	// RVA: 0x26DB650 Offset: 0x26DA850 VA: 0x1826DB650
	private void SetCaretVisible() { }

	// RVA: 0x26DB5A0 Offset: 0x26DA7A0 VA: 0x1826DB5A0
	private void SetCaretActive() { }

	// RVA: 0x26DC5E0 Offset: 0x26DB7E0 VA: 0x1826DC5E0
	private void UpdateCaretMaterial() { }

	// RVA: 0x26DA920 Offset: 0x26D9B20 VA: 0x1826DA920
	protected void OnFocus() { }

	// RVA: 0x26DB370 Offset: 0x26DA570 VA: 0x1826DB370
	protected void SelectAll() { }

	// RVA: 0x26D9AA0 Offset: 0x26D8CA0 VA: 0x1826D9AA0
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x26D9BC0 Offset: 0x26D8DC0 VA: 0x1826D9BC0
	public void MoveTextStart(bool shift) { }

	// RVA: 0x26DDCB0 Offset: 0x26DCEB0 VA: 0x1826DDCB0
	private static string get_clipboard() { }

	// RVA: 0x26DE8D0 Offset: 0x26DDAD0 VA: 0x1826DE8D0
	private static void set_clipboard(string value) { }

	// RVA: 0x26DC400 Offset: 0x26DB600 VA: 0x1826DC400
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x26D7BB0 Offset: 0x26D6DB0 VA: 0x1826D7BB0
	private bool InPlaceEditing() { }

	// RVA: 0x26D7B30 Offset: 0x26D6D30 VA: 0x1826D7B30
	private bool InPlaceEditingChanged() { }

	// RVA: 0x26D74D0 Offset: 0x26D66D0 VA: 0x1826D74D0
	private RangeInt GetInternalSelection() { }

	// RVA: 0x26DCBA0 Offset: 0x26DBDA0 VA: 0x1826DCBA0
	private void UpdateKeyboardCaret() { }

	// RVA: 0x26DC4B0 Offset: 0x26DB6B0 VA: 0x1826DC4B0
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x26D84E0 Offset: 0x26D76E0 VA: 0x1826D84E0 Slot: 61
	protected virtual void LateUpdate() { }

	[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
	// RVA: 0x26DAE70 Offset: 0x26DA070 VA: 0x1826DAE70
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x26D78B0 Offset: 0x26D6AB0 VA: 0x1826D78B0
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x26D7280 Offset: 0x26D6480 VA: 0x1826D7280
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x26D91E0 Offset: 0x26D83E0 VA: 0x1826D91E0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x26D9EA0 Offset: 0x26D90A0 VA: 0x1826D9EA0 Slot: 62
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x26DA1C0 Offset: 0x26D93C0 VA: 0x1826DA1C0 Slot: 63
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(InputField.<MouseDragOutsideRect>d__194))]
	// RVA: 0x26D92D0 Offset: 0x26D84D0 VA: 0x1826D92D0
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x26DA6F0 Offset: 0x26D98F0 VA: 0x1826DA6F0 Slot: 64
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x26DA960 Offset: 0x26D9B60 VA: 0x1826DA960 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x26D7EC0 Offset: 0x26D70C0 VA: 0x1826D7EC0
	protected InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x26D7E60 Offset: 0x26D7060 VA: 0x1826D7E60
	private bool IsValidChar(char c) { }

	// RVA: 0x26DAE50 Offset: 0x26DA050 VA: 0x1826DAE50
	public void ProcessEvent(Event e) { }

	// RVA: 0x26DAC80 Offset: 0x26D9E80 VA: 0x1826DAC80 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x26D77B0 Offset: 0x26D69B0 VA: 0x1826D77B0
	private string GetSelectedString() { }

	// RVA: 0x26D5D50 Offset: 0x26D4F50 VA: 0x1826D5D50
	private int FindtNextWordBegin() { }

	// RVA: 0x26D97F0 Offset: 0x26D89F0 VA: 0x1826D97F0
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x26D5E50 Offset: 0x26D5050 VA: 0x1826D5E50
	private int FindtPrevWordBegin() { }

	// RVA: 0x26D9570 Offset: 0x26D8770 VA: 0x1826D9570
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x26D5960 Offset: 0x26D4B60 VA: 0x1826D5960
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x26D8EF0 Offset: 0x26D80F0 VA: 0x1826D8EF0
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x26D8BB0 Offset: 0x26D7DB0 VA: 0x1826D8BB0
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x26D9560 Offset: 0x26D8760 VA: 0x1826D9560
	private void MoveDown(bool shift) { }

	// RVA: 0x26D9340 Offset: 0x26D8540 VA: 0x1826D9340
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x26D9CB0 Offset: 0x26D8EB0 VA: 0x1826D9CB0
	private void MoveUp(bool shift) { }

	// RVA: 0x26D9CC0 Offset: 0x26D8EC0 VA: 0x1826D9CC0
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x26D5650 Offset: 0x26D4850 VA: 0x1826D5650
	private void Delete() { }

	// RVA: 0x26D5F50 Offset: 0x26D5150 VA: 0x1826D5F50
	private void ForwardSpace() { }

	// RVA: 0x26D5020 Offset: 0x26D4220 VA: 0x1826D5020
	private void Backspace() { }

	// RVA: 0x26D7BE0 Offset: 0x26D6DE0 VA: 0x1826D7BE0
	private void Insert(char c) { }

	// RVA: 0x26DD170 Offset: 0x26DC370 VA: 0x1826DD170
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x26DB500 Offset: 0x26DA700 VA: 0x1826DB500
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x26DB520 Offset: 0x26DA720 VA: 0x1826DB520
	private void SendOnValueChanged() { }

	// RVA: 0x26DB400 Offset: 0x26DA600 VA: 0x1826DB400
	protected void SendOnEndEdit() { }

	// RVA: 0x26DB480 Offset: 0x26DA680 VA: 0x1826DB480
	protected void SendOnSubmit() { }

	// RVA: 0x26D47F0 Offset: 0x26D39F0 VA: 0x1826D47F0 Slot: 66
	protected virtual void Append(string input) { }

	// RVA: 0x26D4470 Offset: 0x26D3670 VA: 0x1826D4470 Slot: 67
	protected virtual void Append(char input) { }

	// RVA: 0x26DCC70 Offset: 0x26DBE70 VA: 0x1826DCC70
	protected void UpdateLabel() { }

	// RVA: 0x26D7D90 Offset: 0x26D6F90 VA: 0x1826D7D90
	private bool IsSelectionVisible() { }

	// RVA: 0x26D7690 Offset: 0x26D6890 VA: 0x1826D7690
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x26D75D0 Offset: 0x26D67D0 VA: 0x1826D75D0
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x26DB690 Offset: 0x26DA890 VA: 0x1826DB690
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x26D5F40 Offset: 0x26D5140 VA: 0x1826D5F40
	public void ForceLabelUpdate() { }

	// RVA: 0x26D9190 Offset: 0x26D8390 VA: 0x1826D9190
	private void MarkGeometryAsDirty() { }

	// RVA: 0x26DAE60 Offset: 0x26DA060 VA: 0x1826DAE60 Slot: 68
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 69
	public virtual void LayoutComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 70
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x26DC6F0 Offset: 0x26DB8F0 VA: 0x1826DC6F0
	private void UpdateGeometry() { }

	// RVA: 0x26D48A0 Offset: 0x26D3AA0 VA: 0x1826D48A0
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x26DA720 Offset: 0x26D9920 VA: 0x1826DA720
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x26D6090 Offset: 0x26D5290 VA: 0x1826D6090
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x26D5270 Offset: 0x26D4470 VA: 0x1826D5270
	private void CreateCursorVerts() { }

	// RVA: 0x26D6B30 Offset: 0x26D5D30 VA: 0x1826D6B30
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x26DD1D0 Offset: 0x26DC3D0 VA: 0x1826DD1D0
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x26D4330 Offset: 0x26D3530 VA: 0x1826D4330
	public void ActivateInputField() { }

	// RVA: 0x26D3F00 Offset: 0x26D3100 VA: 0x1826D3F00
	private void ActivateInputFieldInternal() { }

	// RVA: 0x26DABF0 Offset: 0x26D9DF0 VA: 0x1826DABF0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x26DA930 Offset: 0x26D9B30 VA: 0x1826DA930 Slot: 71
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x26D5410 Offset: 0x26D4610 VA: 0x1826D5410
	public void DeactivateInputField() { }

	// RVA: 0x26D9ED0 Offset: 0x26D90D0 VA: 0x1826D9ED0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x26DAC30 Offset: 0x26D9E30 VA: 0x1826DAC30 Slot: 72
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x26D5AB0 Offset: 0x26D4CB0 VA: 0x1826D5AB0
	private void EnforceContentType() { }

	// RVA: 0x26D5CA0 Offset: 0x26D4EA0 VA: 0x1826D5CA0
	private void EnforceTextHOverflow() { }

	// RVA: 0x26DC370 Offset: 0x26DB570 VA: 0x1826DC370
	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x26DC3E0 Offset: 0x26DB5E0 VA: 0x1826DC3E0
	private void SetToCustom() { }

	// RVA: 0x26D5A80 Offset: 0x26D4C80 VA: 0x1826D5A80 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 73
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 74
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x646050 Offset: 0x645250 VA: 0x180646050 Slot: 75
	public virtual float get_minWidth() { }

	// RVA: 0x26DE1C0 Offset: 0x26DD3C0 VA: 0x1826DE1C0 Slot: 76
	public virtual float get_preferredWidth() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 77
	public virtual float get_flexibleWidth() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 78
	public virtual float get_minHeight() { }

	// RVA: 0x26DDFE0 Offset: 0x26DD1E0 VA: 0x1826DDFE0 Slot: 79
	public virtual float get_preferredHeight() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 80
	public virtual float get_flexibleHeight() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 81
	public virtual int get_layoutPriority() { }

	// RVA: 0x26DD8E0 Offset: 0x26DCAE0 VA: 0x1826DD8E0
	private static void .cctor() { }

	// RVA: 0x23F4140 Offset: 0x23F3340 VA: 0x1823F4140 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum AspectRatioFitter.AspectMode // TypeDefIndex: 16063
{
	// Fields
	public int value__; // 0x0
	public const AspectRatioFitter.AspectMode None = 0;
	public const AspectRatioFitter.AspectMode WidthControlsHeight = 1;
	public const AspectRatioFitter.AspectMode HeightControlsWidth = 2;
	public const AspectRatioFitter.AspectMode FitInParent = 3;
	public const AspectRatioFitter.AspectMode EnvelopeParent = 4;
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
[DisallowMultipleComponent]
[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
[RequireComponent(typeof(RectTransform))]
public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 16064
{
	// Fields
	[SerializeField]
	private AspectRatioFitter.AspectMode m_AspectMode; // 0x20
	[SerializeField]
	private float m_AspectRatio; // 0x24
	private RectTransform m_Rect; // 0x28
	private bool m_DelayedSetDirty; // 0x30
	private bool m_DoesParentExist; // 0x31
	private DrivenRectTransformTracker m_Tracker; // 0x32

	// Properties
	public AspectRatioFitter.AspectMode aspectMode { get; set; }
	public float aspectRatio { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public AspectRatioFitter.AspectMode get_aspectMode() { }

	// RVA: 0x26D1160 Offset: 0x26D0360 VA: 0x1826D1160
	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	// RVA: 0x499040 Offset: 0x498240 VA: 0x180499040
	public float get_aspectRatio() { }

	// RVA: 0x26D11C0 Offset: 0x26D03C0 VA: 0x1826D11C0
	public void set_aspectRatio(float value) { }

	// RVA: 0x26D10D0 Offset: 0x26D02D0 VA: 0x1826D10D0
	private RectTransform get_rectTransform() { }

	// RVA: 0x26D10C0 Offset: 0x26D02C0 VA: 0x1826D10C0
	protected void .ctor() { }

	// RVA: 0x26D0B10 Offset: 0x26CFD10 VA: 0x1826D0B10 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26D0C60 Offset: 0x26CFE60 VA: 0x1826D0C60 Slot: 6
	protected override void Start() { }

	// RVA: 0x26D0A90 Offset: 0x26CFC90 VA: 0x1826D0A90 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26D0BC0 Offset: 0x26CFDC0 VA: 0x1826D0BC0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x26D10A0 Offset: 0x26D02A0 VA: 0x1826D10A0 Slot: 19
	protected virtual void Update() { }

	// RVA: 0x26D0BB0 Offset: 0x26CFDB0 VA: 0x1826D0BB0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x26D0CB0 Offset: 0x26CFEB0 VA: 0x1826D0CB0
	private void UpdateRect() { }

	// RVA: 0x26D07F0 Offset: 0x26CF9F0 VA: 0x1826D07F0
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x26D06F0 Offset: 0x26CF8F0 VA: 0x1826D06F0
	private Vector2 GetParentSize() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0x26D0BB0 Offset: 0x26CFDB0 VA: 0x1826D0BB0
	protected void SetDirty() { }

	// RVA: 0x26D09E0 Offset: 0x26CFBE0 VA: 0x1826D09E0
	public bool IsComponentValidOnObject() { }

	// RVA: 0x26D09C0 Offset: 0x26CFBC0 VA: 0x1826D09C0
	public bool IsAspectModeValid() { }

	// RVA: 0x577B10 Offset: 0x576D10 VA: 0x180577B10
	private bool DoesParentExists() { }
}

// Namespace: 
public enum CanvasScaler.ScaleMode // TypeDefIndex: 16065
{
	// Fields
	public int value__; // 0x0
	public const CanvasScaler.ScaleMode ConstantPixelSize = 0;
	public const CanvasScaler.ScaleMode ScaleWithScreenSize = 1;
	public const CanvasScaler.ScaleMode ConstantPhysicalSize = 2;
}

// Namespace: 
public enum CanvasScaler.ScreenMatchMode // TypeDefIndex: 16066
{
	// Fields
	public int value__; // 0x0
	public const CanvasScaler.ScreenMatchMode MatchWidthOrHeight = 0;
	public const CanvasScaler.ScreenMatchMode Expand = 1;
	public const CanvasScaler.ScreenMatchMode Shrink = 2;
}

// Namespace: 
public enum CanvasScaler.Unit // TypeDefIndex: 16067
{
	// Fields
	public int value__; // 0x0
	public const CanvasScaler.Unit Centimeters = 0;
	public const CanvasScaler.Unit Millimeters = 1;
	public const CanvasScaler.Unit Inches = 2;
	public const CanvasScaler.Unit Points = 3;
	public const CanvasScaler.Unit Picas = 4;
}

// Namespace: UnityEngine.UI
[DisallowMultipleComponent]
[AddComponentMenu("Layout/Canvas Scaler", 101)]
[ExecuteAlways]
[RequireComponent(typeof(Canvas))]
public class CanvasScaler : UIBehaviour // TypeDefIndex: 16068
{
	// Fields
	[Tooltip("Determines how UI elements in the Canvas are scaled.")]
	[SerializeField]
	private CanvasScaler.ScaleMode m_UiScaleMode; // 0x20
	[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
	[SerializeField]
	protected float m_ReferencePixelsPerUnit; // 0x24
	[Tooltip("Scales all UI elements in the Canvas by this factor.")]
	[SerializeField]
	protected float m_ScaleFactor; // 0x28
	[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
	[SerializeField]
	protected Vector2 m_ReferenceResolution; // 0x2C
	[SerializeField]
	[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; // 0x34
	[SerializeField]
	[Range(0, 1)]
	[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
	protected float m_MatchWidthOrHeight; // 0x38
	private const float kLogBase = 2;
	[Tooltip("The physical unit to specify positions and sizes in.")]
	[SerializeField]
	protected CanvasScaler.Unit m_PhysicalUnit; // 0x3C
	[Tooltip("The DPI to assume if the screen DPI is not known.")]
	[SerializeField]
	protected float m_FallbackScreenDPI; // 0x40
	[SerializeField]
	[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
	protected float m_DefaultSpriteDPI; // 0x44
	[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
	[SerializeField]
	protected float m_DynamicPixelsPerUnit; // 0x48
	private Canvas m_Canvas; // 0x50
	private float m_PrevScaleFactor; // 0x58
	private float m_PrevReferencePixelsPerUnit; // 0x5C
	[SerializeField]
	protected bool m_PresetInfoIsWorld; // 0x60

	// Properties
	public CanvasScaler.ScaleMode uiScaleMode { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public float scaleFactor { get; set; }
	public Vector2 referenceResolution { get; set; }
	public CanvasScaler.ScreenMatchMode screenMatchMode { get; set; }
	public float matchWidthOrHeight { get; set; }
	public CanvasScaler.Unit physicalUnit { get; set; }
	public float fallbackScreenDPI { get; set; }
	public float defaultSpriteDPI { get; set; }
	public float dynamicPixelsPerUnit { get; set; }

	// Methods

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	// RVA: 0x499040 Offset: 0x498240 VA: 0x180499040
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x499000 Offset: 0x498200 VA: 0x180499000
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20
	public float get_scaleFactor() { }

	// RVA: 0x26D1A60 Offset: 0x26D0C60 VA: 0x1826D1A60
	public void set_scaleFactor(float value) { }

	// RVA: 0x26D19A0 Offset: 0x26D0BA0 VA: 0x1826D19A0
	public Vector2 get_referenceResolution() { }

	// RVA: 0x26D19E0 Offset: 0x26D0BE0 VA: 0x1826D19E0
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	// RVA: 0x7974D0 Offset: 0x7966D0 VA: 0x1807974D0
	public float get_matchWidthOrHeight() { }

	// RVA: 0x2507580 Offset: 0x2506780 VA: 0x182507580
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	public CanvasScaler.Unit get_physicalUnit() { }

	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70
	public void set_physicalUnit(CanvasScaler.Unit value) { }

	// RVA: 0x78EC10 Offset: 0x78DE10 VA: 0x18078EC10
	public float get_fallbackScreenDPI() { }

	// RVA: 0xCDEA70 Offset: 0xCDDC70 VA: 0x180CDEA70
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0x78EC00 Offset: 0x78DE00 VA: 0x18078EC00
	public float get_defaultSpriteDPI() { }

	// RVA: 0x26D19C0 Offset: 0x26D0BC0 VA: 0x1826D19C0
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x78EC20 Offset: 0x78DE20 VA: 0x18078EC20
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x5269B0 Offset: 0x525BB0 VA: 0x1805269B0
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x26D1950 Offset: 0x26D0B50 VA: 0x1826D1950
	protected void .ctor() { }

	// RVA: 0x26D1820 Offset: 0x26D0A20 VA: 0x1826D1820 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x75C760 Offset: 0x75B960 VA: 0x18075C760
	private void Canvas_preWillRenderCanvases() { }

	// RVA: 0x26D1750 Offset: 0x26D0950 VA: 0x1826D1750 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26D1630 Offset: 0x26D0830 VA: 0x1826D1630 Slot: 17
	protected virtual void Handle() { }

	// RVA: 0x26D15C0 Offset: 0x26D07C0 VA: 0x1826D15C0 Slot: 18
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x26D1300 Offset: 0x26D0500 VA: 0x1826D1300 Slot: 19
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x26D1370 Offset: 0x26D0570 VA: 0x1826D1370 Slot: 20
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x26D1220 Offset: 0x26D0420 VA: 0x1826D1220 Slot: 21
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x26D1910 Offset: 0x26D0B10 VA: 0x1826D1910
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x26D18D0 Offset: 0x26D0AD0 VA: 0x1826D18D0
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }
}

// Namespace: 
public enum ContentSizeFitter.FitMode // TypeDefIndex: 16069
{
	// Fields
	public int value__; // 0x0
	public const ContentSizeFitter.FitMode Unconstrained = 0;
	public const ContentSizeFitter.FitMode MinSize = 1;
	public const ContentSizeFitter.FitMode PreferredSize = 2;
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Content Size Fitter", 141)]
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 16070
{
	// Fields
	[SerializeField]
	protected ContentSizeFitter.FitMode m_HorizontalFit; // 0x20
	[SerializeField]
	protected ContentSizeFitter.FitMode m_VerticalFit; // 0x24
	private RectTransform m_Rect; // 0x28
	private DrivenRectTransformTracker m_Tracker; // 0x30

	// Properties
	public ContentSizeFitter.FitMode horizontalFit { get; set; }
	public ContentSizeFitter.FitMode verticalFit { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public ContentSizeFitter.FitMode get_horizontalFit() { }

	// RVA: 0x26D1D60 Offset: 0x26D0F60 VA: 0x1826D1D60
	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public ContentSizeFitter.FitMode get_verticalFit() { }

	// RVA: 0x26D1DC0 Offset: 0x26D0FC0 VA: 0x1826D1DC0
	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x26D1CD0 Offset: 0x26D0ED0 VA: 0x1826D1CD0
	private RectTransform get_rectTransform() { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	protected void .ctor() { }

	// RVA: 0x26D1BE0 Offset: 0x26D0DE0 VA: 0x1826D1BE0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26D1B60 Offset: 0x26D0D60 VA: 0x1826D1B60 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26D1C00 Offset: 0x26D0E00 VA: 0x1826D1C00 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x26D1A80 Offset: 0x26D0C80 VA: 0x1826D1A80
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x26D1C90 Offset: 0x26D0E90 VA: 0x1826D1C90 Slot: 19
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x26D1CC0 Offset: 0x26D0EC0 VA: 0x1826D1CC0 Slot: 20
	public virtual void SetLayoutVertical() { }

	// RVA: 0x26D1C10 Offset: 0x26D0E10 VA: 0x1826D1C10
	protected void SetDirty() { }
}

// Namespace: 
public enum GridLayoutGroup.Corner // TypeDefIndex: 16071
{
	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Corner UpperLeft = 0;
	public const GridLayoutGroup.Corner UpperRight = 1;
	public const GridLayoutGroup.Corner LowerLeft = 2;
	public const GridLayoutGroup.Corner LowerRight = 3;
}

// Namespace: 
public enum GridLayoutGroup.Axis // TypeDefIndex: 16072
{
	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Axis Horizontal = 0;
	public const GridLayoutGroup.Axis Vertical = 1;
}

// Namespace: 
public enum GridLayoutGroup.Constraint // TypeDefIndex: 16073
{
	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Constraint Flexible = 0;
	public const GridLayoutGroup.Constraint FixedColumnCount = 1;
	public const GridLayoutGroup.Constraint FixedRowCount = 2;
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Grid Layout Group", 152)]
public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 16074
{
	// Fields
	[SerializeField]
	protected GridLayoutGroup.Corner m_StartCorner; // 0x60
	[SerializeField]
	protected GridLayoutGroup.Axis m_StartAxis; // 0x64
	[SerializeField]
	protected Vector2 m_CellSize; // 0x68
	[SerializeField]
	protected Vector2 m_Spacing; // 0x70
	[SerializeField]
	protected GridLayoutGroup.Constraint m_Constraint; // 0x78
	[SerializeField]
	protected int m_ConstraintCount; // 0x7C

	// Properties
	public GridLayoutGroup.Corner startCorner { get; set; }
	public GridLayoutGroup.Axis startAxis { get; set; }
	public Vector2 cellSize { get; set; }
	public Vector2 spacing { get; set; }
	public GridLayoutGroup.Constraint constraint { get; set; }
	public int constraintCount { get; set; }

	// Methods

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public GridLayoutGroup.Corner get_startCorner() { }

	// RVA: 0x26D2D10 Offset: 0x26D1F10 VA: 0x1826D2D10
	public void set_startCorner(GridLayoutGroup.Corner value) { }

	// RVA: 0x6772F0 Offset: 0x6764F0 VA: 0x1806772F0
	public GridLayoutGroup.Axis get_startAxis() { }

	// RVA: 0x26D2CC0 Offset: 0x26D1EC0 VA: 0x1826D2CC0
	public void set_startAxis(GridLayoutGroup.Axis value) { }

	// RVA: 0x26D2B10 Offset: 0x26D1D10 VA: 0x1826D2B10
	public Vector2 get_cellSize() { }

	// RVA: 0x26D2B50 Offset: 0x26D1D50 VA: 0x1826D2B50
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x26D2B30 Offset: 0x26D1D30 VA: 0x1826D2B30
	public Vector2 get_spacing() { }

	// RVA: 0x26D2C60 Offset: 0x26D1E60 VA: 0x1826D2C60
	public void set_spacing(Vector2 value) { }

	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990
	public GridLayoutGroup.Constraint get_constraint() { }

	// RVA: 0x26D2C10 Offset: 0x26D1E10 VA: 0x1826D2C10
	public void set_constraint(GridLayoutGroup.Constraint value) { }

	// RVA: 0x1C44BB0 Offset: 0x1C43DB0 VA: 0x181C44BB0
	public int get_constraintCount() { }

	// RVA: 0x26D2BB0 Offset: 0x26D1DB0 VA: 0x1826D2BB0
	public void set_constraintCount(int value) { }

	// RVA: 0x26D2AA0 Offset: 0x26D1CA0 VA: 0x1826D2AA0
	protected void .ctor() { }

	// RVA: 0x26D1EA0 Offset: 0x26D10A0 VA: 0x1826D1EA0 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x26D20A0 Offset: 0x26D12A0 VA: 0x1826D20A0 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x26D2A80 Offset: 0x26D1C80 VA: 0x1826D2A80 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x26D2A90 Offset: 0x26D1C90 VA: 0x1826D2A90 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x26D2280 Offset: 0x26D1480 VA: 0x1826D2280
	private void SetCellsAlongAxis(int axis) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 16075
{
	// Methods

	// RVA: 0x26D2DC0 Offset: 0x26D1FC0 VA: 0x1826D2DC0
	protected void .ctor() { }

	// RVA: 0x26D2D60 Offset: 0x26D1F60 VA: 0x1826D2D60 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x26D2D90 Offset: 0x26D1F90 VA: 0x1826D2D90 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x26D2DA0 Offset: 0x26D1FA0 VA: 0x1826D2DA0 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x26D2DB0 Offset: 0x26D1FB0 VA: 0x1826D2DB0 Slot: 38
	public override void SetLayoutVertical() { }
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 16076
{
	// Fields
	[SerializeField]
	protected float m_Spacing; // 0x60
	[SerializeField]
	protected bool m_ChildForceExpandWidth; // 0x64
	[SerializeField]
	protected bool m_ChildForceExpandHeight; // 0x65
	[SerializeField]
	protected bool m_ChildControlWidth; // 0x66
	[SerializeField]
	protected bool m_ChildControlHeight; // 0x67
	[SerializeField]
	protected bool m_ChildScaleWidth; // 0x68
	[SerializeField]
	protected bool m_ChildScaleHeight; // 0x69
	[SerializeField]
	protected bool m_ReverseArrangement; // 0x6A

	// Properties
	public float spacing { get; set; }
	public bool childForceExpandWidth { get; set; }
	public bool childForceExpandHeight { get; set; }
	public bool childControlWidth { get; set; }
	public bool childControlHeight { get; set; }
	public bool childScaleWidth { get; set; }
	public bool childScaleHeight { get; set; }
	public bool reverseArrangement { get; set; }

	// Methods

	// RVA: 0x6D7F60 Offset: 0x6D7160 VA: 0x1806D7F60
	public float get_spacing() { }

	// RVA: 0x26D3EB0 Offset: 0x26D30B0 VA: 0x1826D3EB0
	public void set_spacing(float value) { }

	// RVA: 0x1C44B00 Offset: 0x1C43D00 VA: 0x181C44B00
	public bool get_childForceExpandWidth() { }

	// RVA: 0x26D3D70 Offset: 0x26D2F70 VA: 0x1826D3D70
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x1E01BB0 Offset: 0x1E00DB0 VA: 0x181E01BB0
	public bool get_childForceExpandHeight() { }

	// RVA: 0x26D3D20 Offset: 0x26D2F20 VA: 0x1826D3D20
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x1E00F40 Offset: 0x1E00140 VA: 0x181E00F40
	public bool get_childControlWidth() { }

	// RVA: 0x26D3CD0 Offset: 0x26D2ED0 VA: 0x1826D3CD0
	public void set_childControlWidth(bool value) { }

	// RVA: 0x1E00F30 Offset: 0x1E00130 VA: 0x181E00F30
	public bool get_childControlHeight() { }

	// RVA: 0x26D3C80 Offset: 0x26D2E80 VA: 0x1826D3C80
	public void set_childControlHeight(bool value) { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	public bool get_childScaleWidth() { }

	// RVA: 0x26D3E10 Offset: 0x26D3010 VA: 0x1826D3E10
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x1C134F0 Offset: 0x1C126F0 VA: 0x181C134F0
	public bool get_childScaleHeight() { }

	// RVA: 0x26D3DC0 Offset: 0x26D2FC0 VA: 0x1826D3DC0
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x1C13490 Offset: 0x1C12690 VA: 0x181C13490
	public bool get_reverseArrangement() { }

	// RVA: 0x26D3E60 Offset: 0x26D3060 VA: 0x1826D3E60
	public void set_reverseArrangement(bool value) { }

	// RVA: 0x26D2DD0 Offset: 0x26D1FD0 VA: 0x1826D2DD0
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x26D3440 Offset: 0x26D2640 VA: 0x1826D3440
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x26D3190 Offset: 0x26D2390 VA: 0x1826D3190
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x26D2DC0 Offset: 0x26D1FC0 VA: 0x1826D2DC0
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
public interface ILayoutElement // TypeDefIndex: 16077
{
	// Properties
	public abstract float minWidth { get; }
	public abstract float preferredWidth { get; }
	public abstract float flexibleWidth { get; }
	public abstract float minHeight { get; }
	public abstract float preferredHeight { get; }
	public abstract float flexibleHeight { get; }
	public abstract int layoutPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CalculateLayoutInputHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CalculateLayoutInputVertical();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_minWidth();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_preferredWidth();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_flexibleWidth();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_minHeight();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_preferredHeight();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_flexibleHeight();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_layoutPriority();
}

// Namespace: UnityEngine.UI
public interface ILayoutController // TypeDefIndex: 16078
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetLayoutVertical();
}

// Namespace: UnityEngine.UI
public interface ILayoutGroup : ILayoutController // TypeDefIndex: 16079
{}

// Namespace: UnityEngine.UI
public interface ILayoutSelfController : ILayoutController // TypeDefIndex: 16080
{}

// Namespace: UnityEngine.UI
public interface ILayoutIgnorer // TypeDefIndex: 16081
{
	// Properties
	public abstract bool ignoreLayout { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_ignoreLayout();
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Layout Element", 140)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 16082
{
	// Fields
	[SerializeField]
	private bool m_IgnoreLayout; // 0x20
	[SerializeField]
	private float m_MinWidth; // 0x24
	[SerializeField]
	private float m_MinHeight; // 0x28
	[SerializeField]
	private float m_PreferredWidth; // 0x2C
	[SerializeField]
	private float m_PreferredHeight; // 0x30
	[SerializeField]
	private float m_FlexibleWidth; // 0x34
	[SerializeField]
	private float m_FlexibleHeight; // 0x38
	[SerializeField]
	private int m_LayoutPriority; // 0x3C

	// Properties
	public virtual bool ignoreLayout { get; set; }
	public virtual float minWidth { get; set; }
	public virtual float minHeight { get; set; }
	public virtual float preferredWidth { get; set; }
	public virtual float preferredHeight { get; set; }
	public virtual float flexibleWidth { get; set; }
	public virtual float flexibleHeight { get; set; }
	public virtual int layoutPriority { get; set; }

	// Methods

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0 Slot: 27
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x26DF560 Offset: 0x26DE760 VA: 0x1826DF560 Slot: 28
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 29
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x499040 Offset: 0x498240 VA: 0x180499040 Slot: 31
	public virtual float get_minWidth() { }

	// RVA: 0x26DF680 Offset: 0x26DE880 VA: 0x1826DF680 Slot: 32
	public virtual void set_minWidth(float value) { }

	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x26DF620 Offset: 0x26DE820 VA: 0x1826DF620 Slot: 34
	public virtual void set_minHeight(float value) { }

	// RVA: 0x6F31E0 Offset: 0x6F23E0 VA: 0x1806F31E0 Slot: 35
	public virtual float get_preferredWidth() { }

	// RVA: 0x26DF740 Offset: 0x26DE940 VA: 0x1826DF740 Slot: 36
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x527470 Offset: 0x526670 VA: 0x180527470 Slot: 37
	public virtual float get_preferredHeight() { }

	// RVA: 0x26DF6E0 Offset: 0x26DE8E0 VA: 0x1826DF6E0 Slot: 38
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x7974C0 Offset: 0x7966C0 VA: 0x1807974C0 Slot: 39
	public virtual float get_flexibleWidth() { }

	// RVA: 0x26DF500 Offset: 0x26DE700 VA: 0x1826DF500 Slot: 40
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x7974D0 Offset: 0x7966D0 VA: 0x1807974D0 Slot: 41
	public virtual float get_flexibleHeight() { }

	// RVA: 0x26DF4A0 Offset: 0x26DE6A0 VA: 0x1826DF4A0 Slot: 42
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 43
	public virtual int get_layoutPriority() { }

	// RVA: 0x26DF5C0 Offset: 0x26DE7C0 VA: 0x1826DF5C0 Slot: 44
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x26DF460 Offset: 0x26DE660 VA: 0x1826DF460
	protected void .ctor() { }

	// RVA: 0x26DF3A0 Offset: 0x26DE5A0 VA: 0x1826DF3A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26DF370 Offset: 0x26DE570 VA: 0x1826DF370 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x26DF380 Offset: 0x26DE580 VA: 0x1826DF380 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26DF370 Offset: 0x26DE570 VA: 0x1826DF370 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x26DF370 Offset: 0x26DE570 VA: 0x1826DF370 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x26DF3C0 Offset: 0x26DE5C0 VA: 0x1826DF3C0
	protected void SetDirty() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LayoutGroup.<DelayedSetDirty>d__56 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 16083
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RectTransform rectTransform; // 0x20

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

	// RVA: 0x26E6040 Offset: 0x26E5240 VA: 0x1826E6040 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x26E60C0 Offset: 0x26E52C0 VA: 0x1826E60C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
[DisallowMultipleComponent]
public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 16084
{
	// Fields
	[SerializeField]
	protected RectOffset m_Padding; // 0x20
	[SerializeField]
	protected TextAnchor m_ChildAlignment; // 0x28
	private RectTransform m_Rect; // 0x30
	protected DrivenRectTransformTracker m_Tracker; // 0x38
	private Vector2 m_TotalMinSize; // 0x3C
	private Vector2 m_TotalPreferredSize; // 0x44
	private Vector2 m_TotalFlexibleSize; // 0x4C
	private List<RectTransform> m_RectChildren; // 0x58

	// Properties
	public RectOffset padding { get; set; }
	public TextAnchor childAlignment { get; set; }
	protected RectTransform rectTransform { get; }
	protected List<RectTransform> rectChildren { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }
	private bool isRootLayoutGroup { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public RectOffset get_padding() { }

	// RVA: 0x26E0AA0 Offset: 0x26DFCA0 VA: 0x1826E0AA0
	public void set_padding(RectOffset value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public TextAnchor get_childAlignment() { }

	// RVA: 0x26E0A50 Offset: 0x26DFC50 VA: 0x1826E0A50
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x26E09C0 Offset: 0x26DFBC0 VA: 0x1826E09C0
	protected RectTransform get_rectTransform() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	protected List<RectTransform> get_rectChildren() { }

	// RVA: 0x26DF7A0 Offset: 0x26DE9A0 VA: 0x1826DF7A0 Slot: 28
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CalculateLayoutInputVertical();

	// RVA: 0x23C42B0 Offset: 0x23C34B0 VA: 0x1823C42B0 Slot: 30
	public virtual float get_minWidth() { }

	// RVA: 0x2507530 Offset: 0x2506730 VA: 0x182507530 Slot: 31
	public virtual float get_preferredWidth() { }

	// RVA: 0x2507560 Offset: 0x2506760 VA: 0x182507560 Slot: 32
	public virtual float get_flexibleWidth() { }

	// RVA: 0x24E2890 Offset: 0x24E1A90 VA: 0x1824E2890 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x2507540 Offset: 0x2506740 VA: 0x182507540 Slot: 34
	public virtual float get_preferredHeight() { }

	// RVA: 0x2507570 Offset: 0x2506770 VA: 0x182507570 Slot: 35
	public virtual float get_flexibleHeight() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 36
	public virtual int get_layoutPriority() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void SetLayoutVertical();

	// RVA: 0x26E0720 Offset: 0x26DF920 VA: 0x1826E0720
	protected void .ctor() { }

	// RVA: 0x26DFDA0 Offset: 0x26DEFA0 VA: 0x1826DFDA0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26DFD20 Offset: 0x26DEF20 VA: 0x1826DFD20 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26DFD10 Offset: 0x26DEF10 VA: 0x1826DFD10 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x26DFCF0 Offset: 0x26DEEF0 VA: 0x1826DFCF0
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x26DFD00 Offset: 0x26DEF00 VA: 0x1826DFD00
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x26DFCE0 Offset: 0x26DEEE0 VA: 0x1826DFCE0
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x26DFB90 Offset: 0x26DED90 VA: 0x1826DFB90
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x26DFB40 Offset: 0x26DED40 VA: 0x1826DFB40
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x26E0690 Offset: 0x26DF890 VA: 0x1826E0690
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x26E0420 Offset: 0x26DF620 VA: 0x1826E0420
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x26E01D0 Offset: 0x26DF3D0 VA: 0x1826E01D0
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x26E04C0 Offset: 0x26DF6C0 VA: 0x1826E04C0
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x26DFF00 Offset: 0x26DF100 VA: 0x1826DFF00
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x26E0890 Offset: 0x26DFA90 VA: 0x1826E0890
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x26DFDC0 Offset: 0x26DEFC0 VA: 0x1826DFDC0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x26DFD10 Offset: 0x26DEF10 VA: 0x1826DFD10 Slot: 39
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: -1 Offset: -1
	protected void SetProperty<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA30BC0 Offset: 0xA2FDC0 VA: 0x180A30BC0
	|-LayoutGroup.SetProperty<bool>
	|
	|-RVA: 0xA30F40 Offset: 0xA30140 VA: 0x180A30F40
	|-LayoutGroup.SetProperty<int>
	|
	|-RVA: 0xA30E90 Offset: 0xA30090 VA: 0x180A30E90
	|-LayoutGroup.SetProperty<Int32Enum>
	|
	|-RVA: 0xA30FC0 Offset: 0xA301C0 VA: 0x180A30FC0
	|-LayoutGroup.SetProperty<object>
	|
	|-RVA: 0xA31020 Offset: 0xA30220 VA: 0x180A31020
	|-LayoutGroup.SetProperty<float>
	|
	|-RVA: 0xA310B0 Offset: 0xA302B0 VA: 0x180A310B0
	|-LayoutGroup.SetProperty<Vector2>
	|
	|-RVA: 0xA30C70 Offset: 0xA2FE70 VA: 0x180A30C70
	|-LayoutGroup.SetProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x26E0570 Offset: 0x26DF770 VA: 0x1826E0570
	protected void SetDirty() { }

	[IteratorStateMachine(typeof(LayoutGroup.<DelayedSetDirty>d__56))]
	// RVA: 0x26DFAE0 Offset: 0x26DECE0 VA: 0x1826DFAE0
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LayoutRebuilder.<>c // TypeDefIndex: 16085
{
	// Fields
	public static readonly LayoutRebuilder.<>c <>9; // 0x0
	public static Predicate<Component> <>9__10_0; // 0x8
	public static UnityAction<Component> <>9__12_0; // 0x10
	public static UnityAction<Component> <>9__12_1; // 0x18
	public static UnityAction<Component> <>9__12_2; // 0x20
	public static UnityAction<Component> <>9__12_3; // 0x28

	// Methods

	// RVA: 0x26E6B70 Offset: 0x26E5D70 VA: 0x1826E6B70
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x26E6AA0 Offset: 0x26E5CA0 VA: 0x1826E6AA0
	internal LayoutRebuilder <.cctor>b__5_0() { }

	// RVA: 0x26E6AF0 Offset: 0x26E5CF0 VA: 0x1826E6AF0
	internal void <.cctor>b__5_1(LayoutRebuilder x) { }

	// RVA: 0x26E6990 Offset: 0x26E5B90 VA: 0x1826E6990
	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x26E67D0 Offset: 0x26E59D0 VA: 0x1826E67D0
	internal void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x26E6840 Offset: 0x26E5A40 VA: 0x1826E6840
	internal void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x26E68B0 Offset: 0x26E5AB0 VA: 0x1826E68B0
	internal void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x26E6920 Offset: 0x26E5B20 VA: 0x1826E6920
	internal void <Rebuild>b__12_3(Component e) { }
}

// Namespace: UnityEngine.UI
public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 16086
{
	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	// Properties
	public Transform transform { get; }

	// Methods

	// RVA: 0x26E0C40 Offset: 0x26DFE40 VA: 0x1826E0C40
	private void Initialize(RectTransform controller) { }

	// RVA: 0x18B36B0 Offset: 0x18B28B0 VA: 0x1818B36B0
	private void Clear() { }

	// RVA: 0x26E2140 Offset: 0x26E1340 VA: 0x1826E2140
	private static void .cctor() { }

	// RVA: 0x26E1A60 Offset: 0x26E0C60 VA: 0x1826E1A60
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	public Transform get_transform() { }

	// RVA: 0x26E0C80 Offset: 0x26DFE80 VA: 0x1826E0C80 Slot: 8
	public bool IsDestroyed() { }

	// RVA: 0x26E1DA0 Offset: 0x26E0FA0 VA: 0x1826E1DA0
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	// RVA: 0x26E0B50 Offset: 0x26DFD50 VA: 0x1826E0B50
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x26E1AB0 Offset: 0x26E0CB0 VA: 0x1826E1AB0 Slot: 4
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x26E16A0 Offset: 0x26E08A0 VA: 0x1826E16A0
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x26E1410 Offset: 0x26E0610 VA: 0x1826E1410
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x26E0D50 Offset: 0x26DFF50 VA: 0x1826E0D50
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x26E1F00 Offset: 0x26E1100 VA: 0x1826E1F00
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	// RVA: 0x26E12A0 Offset: 0x26E04A0 VA: 0x1826E12A0
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x26E0CD0 Offset: 0x26DFED0 VA: 0x1826E0CD0 Slot: 6
	public void LayoutComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void GraphicUpdateComplete() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26E0AF0 Offset: 0x26DFCF0 VA: 0x1826E0AF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26E1EA0 Offset: 0x26E10A0 VA: 0x1826E1EA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LayoutUtility.<>c // TypeDefIndex: 16087
{
	// Fields
	public static readonly LayoutUtility.<>c <>9; // 0x0
	public static Func<ILayoutElement, float> <>9__3_0; // 0x8
	public static Func<ILayoutElement, float> <>9__4_0; // 0x10
	public static Func<ILayoutElement, float> <>9__4_1; // 0x18
	public static Func<ILayoutElement, float> <>9__5_0; // 0x20
	public static Func<ILayoutElement, float> <>9__6_0; // 0x28
	public static Func<ILayoutElement, float> <>9__7_0; // 0x30
	public static Func<ILayoutElement, float> <>9__7_1; // 0x38
	public static Func<ILayoutElement, float> <>9__8_0; // 0x40

	// Methods

	// RVA: 0x26E6B10 Offset: 0x26E5D10 VA: 0x1826E6B10
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x26E6640 Offset: 0x26E5840 VA: 0x1826E6640
	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x26E6730 Offset: 0x26E5930 VA: 0x1826E6730
	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x26E6780 Offset: 0x26E5980 VA: 0x1826E6780
	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x26E65A0 Offset: 0x26E57A0 VA: 0x1826E65A0
	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x26E65F0 Offset: 0x26E57F0 VA: 0x1826E65F0
	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x26E6690 Offset: 0x26E5890 VA: 0x1826E6690
	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x26E66E0 Offset: 0x26E58E0 VA: 0x1826E66E0
	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x26E6550 Offset: 0x26E5750 VA: 0x1826E6550
	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }
}

// Namespace: UnityEngine.UI
public static class LayoutUtility // TypeDefIndex: 16088
{
	// Methods

	// RVA: 0x26E2AC0 Offset: 0x26E1CC0 VA: 0x1826E2AC0
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x26E2F40 Offset: 0x26E2140 VA: 0x1826E2F40
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x26E23F0 Offset: 0x26E15F0 VA: 0x1826E23F0
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x26E2C80 Offset: 0x26E1E80 VA: 0x1826E2C80
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x26E3270 Offset: 0x26E2470 VA: 0x1826E3270
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x26E25B0 Offset: 0x26E17B0 VA: 0x1826E25B0
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x26E29C0 Offset: 0x26E1BC0 VA: 0x1826E29C0
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x26E2D80 Offset: 0x26E1F80 VA: 0x1826E2D80
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x26E22F0 Offset: 0x26E14F0 VA: 0x1826E22F0
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x26E26B0 Offset: 0x26E18B0 VA: 0x1826E26B0
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	// RVA: 0x26E26D0 Offset: 0x26E18D0 VA: 0x1826E26D0
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Vertical Layout Group", 151)]
public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 16089
{
	// Methods

	// RVA: 0x26D2DC0 Offset: 0x26D1FC0 VA: 0x1826D2DC0
	protected void .ctor() { }

	// RVA: 0x26E6BD0 Offset: 0x26E5DD0 VA: 0x1826E6BD0 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x26E6C00 Offset: 0x26E5E00 VA: 0x1826E6C00 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x26E6C10 Offset: 0x26E5E10 VA: 0x1826E6C10 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x26E6C20 Offset: 0x26E5E20 VA: 0x1826E6C20 Slot: 38
	public override void SetLayoutVertical() { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
[DisallowMultipleComponent]
[AddComponentMenu("UI/Mask", 13)]
public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 16090
{
	// Fields
	private RectTransform m_RectTransform; // 0x20
	[SerializeField]
	private bool m_ShowMaskGraphic; // 0x28
	private Graphic m_Graphic; // 0x30
	private Material m_MaskMaterial; // 0x38
	private Material m_UnmaskMaterial; // 0x40

	// Properties
	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }

	// Methods

	// RVA: 0x26E5040 Offset: 0x26E4240 VA: 0x1826E5040
	public RectTransform get_rectTransform() { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_showMaskGraphic() { }

	// RVA: 0x26E5090 Offset: 0x26E4290 VA: 0x1826E5090
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x26E4FF0 Offset: 0x26E41F0 VA: 0x1826E4FF0
	public Graphic get_graphic() { }

	// RVA: 0x26E4FE0 Offset: 0x26E41E0 VA: 0x1826E4FE0
	protected void .ctor() { }

	// RVA: 0x26E48C0 Offset: 0x26E3AC0 VA: 0x1826E48C0 Slot: 19
	public virtual bool MaskEnabled() { }

	[Obsolete("Not used anymore.")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 20
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x26E4D00 Offset: 0x26E3F00 VA: 0x1826E4D00 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26E4980 Offset: 0x26E3B80 VA: 0x1826E4980 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26E47E0 Offset: 0x26E39E0 VA: 0x1826E47E0 Slot: 21
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x26E4460 Offset: 0x26E3660 VA: 0x1826E4460 Slot: 22
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }
}

// Namespace: 
[Serializable]
public class MaskableGraphic.CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 16091
{
	// Methods

	// RVA: 0x26D1E20 Offset: 0x26D1020 VA: 0x1826D1E20
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 16092
{
	// Fields
	protected bool m_ShouldRecalculateStencil; // 0xA8
	protected Material m_MaskMaterial; // 0xB0
	private RectMask2D m_ParentMask; // 0xB8
	[SerializeField]
	private bool m_Maskable; // 0xC0
	private bool m_IsMaskingGraphic; // 0xC1
	[EditorBrowsable(1)]
	[Obsolete("Not used anymore.", True)]
	protected bool m_IncludeForMasking; // 0xC2
	[SerializeField]
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; // 0xC8
	[EditorBrowsable(1)]
	[Obsolete("Not used anymore", True)]
	protected bool m_ShouldRecalculate; // 0xD0
	protected int m_StencilValue; // 0xD4
	private readonly Vector3[] m_Corners; // 0xD8

	// Properties
	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	public bool isMaskingGraphic { get; set; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x738340 Offset: 0x737540 VA: 0x180738340
	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x1532B30 Offset: 0x1531D30 VA: 0x181532B30
	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	// RVA: 0x5C6220 Offset: 0x5C5420 VA: 0x1805C6220
	public bool get_maskable() { }

	// RVA: 0x26E5D80 Offset: 0x26E4F80 VA: 0x1826E5D80
	public void set_maskable(bool value) { }

	// RVA: 0x1C44B10 Offset: 0x1C43D10 VA: 0x181C44B10
	public bool get_isMaskingGraphic() { }

	// RVA: 0x26E5D70 Offset: 0x26E4F70 VA: 0x1826E5D70
	public void set_isMaskingGraphic(bool value) { }

	// RVA: 0x26E5300 Offset: 0x26E4500 VA: 0x1826E5300 Slot: 58
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x26E5190 Offset: 0x26E4390 VA: 0x1826E5190 Slot: 59
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x26E58F0 Offset: 0x26E4AF0 VA: 0x1826E58F0
	private void UpdateCull(bool cull) { }

	// RVA: 0x26E56C0 Offset: 0x26E48C0 VA: 0x1826E56C0 Slot: 60
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x26E5720 Offset: 0x26E4920 VA: 0x1826E5720 Slot: 61
	public virtual void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x26E5560 Offset: 0x26E4760 VA: 0x1826E5560 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26E54B0 Offset: 0x26E46B0 VA: 0x1826E54B0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26E55C0 Offset: 0x26E47C0 VA: 0x1826E55C0 Slot: 12
	protected override void OnTransformParentChanged() { }

	[EditorBrowsable(1)]
	[Obsolete("Not used anymore.", True)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 62
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x26E5450 Offset: 0x26E4650 VA: 0x1826E5450 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x26E5AA0 Offset: 0x26E4CA0 VA: 0x1826E5AA0
	private Rect get_rootCanvasRect() { }

	// RVA: 0x26E5770 Offset: 0x26E4970 VA: 0x1826E5770
	private void UpdateClipParent() { }

	// RVA: 0x26E5620 Offset: 0x26E4820 VA: 0x1826E5620 Slot: 63
	public virtual void RecalculateClipping() { }

	// RVA: 0x26E5630 Offset: 0x26E4830 VA: 0x1826E5630 Slot: 64
	public virtual void RecalculateMasking() { }

	// RVA: 0x26E59C0 Offset: 0x26E4BC0 VA: 0x1826E59C0
	protected void .ctor() { }

	// RVA: 0x26E5760 Offset: 0x26E4960 VA: 0x1826E5760 Slot: 50
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }
}

// Namespace: UnityEngine.UI
public class MaskUtilities // TypeDefIndex: 16093
{
	// Methods

	// RVA: 0x26E4040 Offset: 0x26E3240 VA: 0x1826E4040
	public static void Notify2DMaskStateChanged(Component mask) { }

	// RVA: 0x26E4250 Offset: 0x26E3450 VA: 0x1826E4250
	public static void NotifyStencilStateChanged(Component mask) { }

	// RVA: 0x26E3430 Offset: 0x26E2630 VA: 0x1826E3430
	public static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x26E3C30 Offset: 0x26E2E30 VA: 0x1826E3C30
	public static int GetStencilDepth(Transform transform, Transform stopAfter) { }

	// RVA: 0x26E3ED0 Offset: 0x26E30D0 VA: 0x1826E3ED0
	public static bool IsDescendantOrSelf(Transform father, Transform child) { }

	// RVA: 0x26E35B0 Offset: 0x26E27B0 VA: 0x1826E35B0
	public static RectMask2D GetRectMaskForClippable(IClippable clippable) { }

	// RVA: 0x26E38E0 Offset: 0x26E2AE0 VA: 0x1826E38E0
	public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public interface IMaterialModifier // TypeDefIndex: 16094
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Material GetModifiedMaterial(Material baseMaterial);
}

// Namespace: UnityEngine.UI
internal static class Misc // TypeDefIndex: 16095
{
	// Methods

	// RVA: 0x26E75D0 Offset: 0x26E67D0 VA: 0x1826E75D0
	public static void Destroy(Object obj) { }

	// RVA: 0x26E7510 Offset: 0x26E6710 VA: 0x1826E7510
	public static void DestroyImmediate(Object obj) { }
}

// Namespace: UnityEngine.UI
internal static class MultipleDisplayUtilities // TypeDefIndex: 16096
{
	// Methods

	// RVA: 0x26E76F0 Offset: 0x26E68F0 VA: 0x1826E76F0
	public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position) { }

	// RVA: 0x26E77D0 Offset: 0x26E69D0 VA: 0x1826E77D0
	internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData) { }

	// RVA: 0x26E78E0 Offset: 0x26E6AE0 VA: 0x1826E78E0
	public static Vector3 RelativeMouseAtScaled(Vector2 position) { }
}

// Namespace: 
[Flags]
public enum Navigation.Mode // TypeDefIndex: 16097
{
	// Fields
	public int value__; // 0x0
	public const Navigation.Mode None = 0;
	public const Navigation.Mode Horizontal = 1;
	public const Navigation.Mode Vertical = 2;
	public const Navigation.Mode Automatic = 3;
	public const Navigation.Mode Explicit = 4;
}

// Namespace: UnityEngine.UI
[Serializable]
public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 16098
{
	// Fields
	[SerializeField]
	private Navigation.Mode m_Mode; // 0x0
	[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
	[SerializeField]
	private bool m_WrapAround; // 0x4
	[SerializeField]
	private Selectable m_SelectOnUp; // 0x8
	[SerializeField]
	private Selectable m_SelectOnDown; // 0x10
	[SerializeField]
	private Selectable m_SelectOnLeft; // 0x18
	[SerializeField]
	private Selectable m_SelectOnRight; // 0x20

	// Properties
	public Navigation.Mode mode { get; set; }
	public bool wrapAround { get; set; }
	public Selectable selectOnUp { get; set; }
	public Selectable selectOnDown { get; set; }
	public Selectable selectOnLeft { get; set; }
	public Selectable selectOnRight { get; set; }
	public static Navigation defaultNavigation { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Navigation.Mode get_mode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_mode(Navigation.Mode value) { }

	// RVA: 0x499020 Offset: 0x498220 VA: 0x180499020
	public bool get_wrapAround() { }

	// RVA: 0x499070 Offset: 0x498270 VA: 0x180499070
	public void set_wrapAround(bool value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Selectable get_selectOnUp() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Selectable get_selectOnDown() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Selectable get_selectOnLeft() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Selectable get_selectOnRight() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x26E8020 Offset: 0x26E7220 VA: 0x1826E8020
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x26E7F10 Offset: 0x26E7110 VA: 0x1826E7F10 Slot: 4
	public bool Equals(Navigation other) { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/Raw Image", 12)]
public class RawImage : MaskableGraphic // TypeDefIndex: 16099
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_Tex")]
	private Texture m_Texture; // 0xE0
	[SerializeField]
	private Rect m_UVRect; // 0xE8

	// Properties
	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }

	// Methods

	// RVA: 0x26E8950 Offset: 0x26E7B50 VA: 0x1826E8950
	protected void .ctor() { }

	// RVA: 0x26E8980 Offset: 0x26E7B80 VA: 0x1826E8980 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	public Texture get_texture() { }

	// RVA: 0x26E8B10 Offset: 0x26E7D10 VA: 0x1826E8B10
	public void set_texture(Texture value) { }

	// RVA: 0x26E8B00 Offset: 0x26E7D00 VA: 0x1826E8B00
	public Rect get_uvRect() { }

	// RVA: 0x26E8BC0 Offset: 0x26E7DC0 VA: 0x1826E8BC0
	public void set_uvRect(Rect value) { }

	// RVA: 0x26E87F0 Offset: 0x26E79F0 VA: 0x1826E87F0 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x26E83C0 Offset: 0x26E75C0 VA: 0x1826E83C0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x2565D40 Offset: 0x2564F40 VA: 0x182565D40 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Rect Mask 2D", 14)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 16100
{
	// Fields
	private readonly RectangularVertexClipper m_VertexClipper; // 0x20
	private RectTransform m_RectTransform; // 0x28
	private HashSet<MaskableGraphic> m_MaskableTargets; // 0x30
	private HashSet<IClippable> m_ClipTargets; // 0x38
	private bool m_ShouldRecalculateClipRects; // 0x40
	private List<RectMask2D> m_Clippers; // 0x48
	private Rect m_LastClipRectCanvasSpace; // 0x50
	private bool m_ForceClip; // 0x60
	[SerializeField]
	private Vector4 m_Padding; // 0x64
	[SerializeField]
	private Vector2Int m_Softness; // 0x74
	private Canvas m_Canvas; // 0x80
	private Vector3[] m_Corners; // 0x88

	// Properties
	public Vector4 padding { get; set; }
	public Vector2Int softness { get; set; }
	internal Canvas Canvas { get; }
	public Rect canvasRect { get; }
	public RectTransform rectTransform { get; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x26EA710 Offset: 0x26E9910 VA: 0x1826EA710
	public Vector4 get_padding() { }

	// RVA: 0x26EA940 Offset: 0x26E9B40 VA: 0x1826EA940
	public void set_padding(Vector4 value) { }

	// RVA: 0x1C69250 Offset: 0x1C68450 VA: 0x181C69250
	public Vector2Int get_softness() { }

	// RVA: 0x26EA950 Offset: 0x26E9B50 VA: 0x1826EA950
	public void set_softness(Vector2Int value) { }

	// RVA: 0x26EA510 Offset: 0x26E9710 VA: 0x1826EA510
	internal Canvas get_Canvas() { }

	// RVA: 0x26EA660 Offset: 0x26E9860 VA: 0x1826EA660
	public Rect get_canvasRect() { }

	// RVA: 0x26EA720 Offset: 0x26E9920 VA: 0x1826EA720
	public RectTransform get_rectTransform() { }

	// RVA: 0x26EA3E0 Offset: 0x26E95E0 VA: 0x1826EA3E0
	protected void .ctor() { }

	// RVA: 0x26E93D0 Offset: 0x26E85D0 VA: 0x1826E93D0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26E9310 Offset: 0x26E8510 VA: 0x1826E9310 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26E92F0 Offset: 0x26E84F0 VA: 0x1826E92F0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x26E91C0 Offset: 0x26E83C0 VA: 0x1826E91C0 Slot: 19
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x26EA770 Offset: 0x26E9970 VA: 0x1826EA770
	private Rect get_rootCanvasRect() { }

	// RVA: 0x26E9400 Offset: 0x26E8600 VA: 0x1826E9400 Slot: 20
	public virtual void PerformClipping() { }

	// RVA: 0x26EA0C0 Offset: 0x26E92C0 VA: 0x1826EA0C0 Slot: 21
	public virtual void UpdateClipSoftness() { }

	// RVA: 0x26E90B0 Offset: 0x26E82B0 VA: 0x1826E90B0
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x26E9F10 Offset: 0x26E9110 VA: 0x1826E9F10
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x26E92C0 Offset: 0x26E84C0 VA: 0x1826E92C0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x26E92C0 Offset: 0x26E84C0 VA: 0x1826E92C0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }
}

// Namespace: 
public enum Scrollbar.Direction // TypeDefIndex: 16101
{
	// Fields
	public int value__; // 0x0
	public const Scrollbar.Direction LeftToRight = 0;
	public const Scrollbar.Direction RightToLeft = 1;
	public const Scrollbar.Direction BottomToTop = 2;
	public const Scrollbar.Direction TopToBottom = 3;
}

// Namespace: 
[Serializable]
public class Scrollbar.ScrollEvent : UnityEvent<float> // TypeDefIndex: 16102
{
	// Methods

	// RVA: 0x26EB840 Offset: 0x26EAA40 VA: 0x1826EB840
	public void .ctor() { }
}

// Namespace: 
private enum Scrollbar.Axis // TypeDefIndex: 16103
{
	// Fields
	public int value__; // 0x0
	public const Scrollbar.Axis Horizontal = 0;
	public const Scrollbar.Axis Vertical = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class Scrollbar.<ClickRepeat>d__58 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 16104
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Scrollbar <>4__this; // 0x20
	public Vector2 screenPosition; // 0x28
	public Camera camera; // 0x30

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

	// RVA: 0x26FB170 Offset: 0x26FA370 VA: 0x1826FB170 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x26FB3D0 Offset: 0x26FA5D0 VA: 0x1826FB3D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Scrollbar", 36)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 16105
{
	// Fields
	[SerializeField]
	private RectTransform m_HandleRect; // 0x100
	[SerializeField]
	private Scrollbar.Direction m_Direction; // 0x108
	[SerializeField]
	[Range(0, 1)]
	private float m_Value; // 0x10C
	[Range(0, 1)]
	[SerializeField]
	private float m_Size; // 0x110
	[Range(0, 11)]
	[SerializeField]
	private int m_NumberOfSteps; // 0x114
	[Space(6)]
	[SerializeField]
	private Scrollbar.ScrollEvent m_OnValueChanged; // 0x118
	private RectTransform m_ContainerRect; // 0x120
	private Vector2 m_Offset; // 0x128
	private DrivenRectTransformTracker m_Tracker; // 0x130
	private Coroutine m_PointerDownRepeat; // 0x138
	private bool isPointerDownAndNotDragging; // 0x140
	private bool m_DelayedUpdateVisuals; // 0x141

	// Properties
	public RectTransform handleRect { get; set; }
	public Scrollbar.Direction direction { get; set; }
	public float value { get; set; }
	public float size { get; set; }
	public int numberOfSteps { get; set; }
	public Scrollbar.ScrollEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Scrollbar.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x7960A0 Offset: 0x7952A0 VA: 0x1807960A0
	public RectTransform get_handleRect() { }

	// RVA: 0x26F2040 Offset: 0x26F1240 VA: 0x1826F2040
	public void set_handleRect(RectTransform value) { }

	// RVA: 0xB82FD0 Offset: 0xB821D0 VA: 0x180B82FD0
	public Scrollbar.Direction get_direction() { }

	// RVA: 0x26F1FE0 Offset: 0x26F11E0 VA: 0x1826F1FE0
	public void set_direction(Scrollbar.Direction value) { }

	// RVA: 0x26F1E20 Offset: 0x26F1020 VA: 0x1826F1E20
	protected void .ctor() { }

	// RVA: 0x26F1F80 Offset: 0x26F1180 VA: 0x1826F1F80
	public float get_value() { }

	// RVA: 0x26F21A0 Offset: 0x26F13A0 VA: 0x1826F21A0
	public void set_value(float value) { }

	// RVA: 0x26F13E0 Offset: 0x26F05E0 VA: 0x1826F13E0 Slot: 47
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x2567C40 Offset: 0x2566E40 VA: 0x182567C40
	public float get_size() { }

	// RVA: 0x26F2120 Offset: 0x26F1320 VA: 0x1826F2120
	public void set_size(float value) { }

	// RVA: 0x19A7A90 Offset: 0x19A6C90 VA: 0x1819A7A90
	public int get_numberOfSteps() { }

	// RVA: 0x26F20B0 Offset: 0x26F12B0 VA: 0x1826F20B0
	public void set_numberOfSteps(int value) { }

	// RVA: 0x6ED510 Offset: 0x6EC710 VA: 0x1806ED510
	public Scrollbar.ScrollEvent get_onValueChanged() { }

	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	// RVA: 0x26F1F50 Offset: 0x26F1150 VA: 0x1826F1F50
	private float get_stepSize() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 48
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 49
	public virtual void LayoutComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 50
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x26F0AA0 Offset: 0x26EFCA0 VA: 0x1826F0AA0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26F09A0 Offset: 0x26EFBA0 VA: 0x1826F09A0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26F1E00 Offset: 0x26F1000 VA: 0x1826F1E00 Slot: 51
	protected virtual void Update() { }

	// RVA: 0x26F15C0 Offset: 0x26F07C0 VA: 0x1826F15C0
	private void UpdateCachedReferences() { }

	// RVA: 0x26F1490 Offset: 0x26F0690 VA: 0x1826F1490
	private void Set(float input, bool sendCallback = True) { }

	// RVA: 0x26F11D0 Offset: 0x26F03D0 VA: 0x1826F11D0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x26F1F10 Offset: 0x26F1110 VA: 0x1826F1F10
	private Scrollbar.Axis get_axis() { }

	// RVA: 0x26F1F30 Offset: 0x26F1130 VA: 0x1826F1F30
	private bool get_reverseValue() { }

	// RVA: 0x26F1A70 Offset: 0x26F0C70 VA: 0x1826F1A70
	private void UpdateVisuals() { }

	// RVA: 0x26F16B0 Offset: 0x26F08B0 VA: 0x1826F16B0
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x26F0510 Offset: 0x26EF710 VA: 0x1826F0510
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x26F0690 Offset: 0x26EF890 VA: 0x1826F0690
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x26F0700 Offset: 0x26EF900 VA: 0x1826F0700 Slot: 52
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x26F09D0 Offset: 0x26EFBD0 VA: 0x1826F09D0 Slot: 53
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x26F10A0 Offset: 0x26F02A0 VA: 0x1826F10A0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x26F04A0 Offset: 0x26EF6A0 VA: 0x1826F04A0
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(Scrollbar.<ClickRepeat>d__58))]
	// RVA: 0x26F0410 Offset: 0x26EF610 VA: 0x1826F0410
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x26F1190 Offset: 0x26F0390 VA: 0x1826F1190 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x26F0B90 Offset: 0x26EFD90 VA: 0x1826F0B90 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x26F0600 Offset: 0x26EF800 VA: 0x1826F0600 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x26F0630 Offset: 0x26EF830 VA: 0x1826F0630 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x26F0660 Offset: 0x26EF860 VA: 0x1826F0660 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x26F05D0 Offset: 0x26EF7D0 VA: 0x1826F05D0 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x26F0B70 Offset: 0x26EFD70 VA: 0x1826F0B70 Slot: 54
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x26F1210 Offset: 0x26F0410 VA: 0x1826F1210
	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x23F4140 Offset: 0x23F3340 VA: 0x1823F4140 Slot: 43
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum ScrollRect.MovementType // TypeDefIndex: 16106
{
	// Fields
	public int value__; // 0x0
	public const ScrollRect.MovementType Unrestricted = 0;
	public const ScrollRect.MovementType Elastic = 1;
	public const ScrollRect.MovementType Clamped = 2;
}

// Namespace: 
public enum ScrollRect.ScrollbarVisibility // TypeDefIndex: 16107
{
	// Fields
	public int value__; // 0x0
	public const ScrollRect.ScrollbarVisibility Permanent = 0;
	public const ScrollRect.ScrollbarVisibility AutoHide = 1;
	public const ScrollRect.ScrollbarVisibility AutoHideAndExpandViewport = 2;
}

// Namespace: 
[Serializable]
public class ScrollRect.ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 16108
{
	// Methods

	// RVA: 0x26EB880 Offset: 0x26EAA80 VA: 0x1826EB880
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
[DisallowMultipleComponent]
[AddComponentMenu("UI/Scroll Rect", 37)]
[SelectionBase]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 16109
{
	// Fields
	[SerializeField]
	private RectTransform m_Content; // 0x20
	[SerializeField]
	private bool m_Horizontal; // 0x28
	[SerializeField]
	private bool m_Vertical; // 0x29
	[SerializeField]
	private ScrollRect.MovementType m_MovementType; // 0x2C
	[SerializeField]
	private float m_Elasticity; // 0x30
	[SerializeField]
	private bool m_Inertia; // 0x34
	[SerializeField]
	private float m_DecelerationRate; // 0x38
	[SerializeField]
	private float m_ScrollSensitivity; // 0x3C
	[SerializeField]
	private RectTransform m_Viewport; // 0x40
	[SerializeField]
	private Scrollbar m_HorizontalScrollbar; // 0x48
	[SerializeField]
	private Scrollbar m_VerticalScrollbar; // 0x50
	[SerializeField]
	private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x58
	[SerializeField]
	private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x5C
	[SerializeField]
	private float m_HorizontalScrollbarSpacing; // 0x60
	[SerializeField]
	private float m_VerticalScrollbarSpacing; // 0x64
	[SerializeField]
	private ScrollRect.ScrollRectEvent m_OnValueChanged; // 0x68
	private Vector2 m_PointerStartLocalCursor; // 0x70
	protected Vector2 m_ContentStartPosition; // 0x78
	private RectTransform m_ViewRect; // 0x80
	protected Bounds m_ContentBounds; // 0x88
	private Bounds m_ViewBounds; // 0xA0
	private Vector2 m_Velocity; // 0xB8
	private bool m_Dragging; // 0xC0
	private bool m_Scrolling; // 0xC1
	private Vector2 m_PrevPosition; // 0xC4
	private Bounds m_PrevContentBounds; // 0xCC
	private Bounds m_PrevViewBounds; // 0xE4
	private bool m_HasRebuiltLayout; // 0xFC
	private bool m_HSliderExpand; // 0xFD
	private bool m_VSliderExpand; // 0xFE
	private float m_HSliderHeight; // 0x100
	private float m_VSliderWidth; // 0x104
	private RectTransform m_Rect; // 0x108
	private RectTransform m_HorizontalScrollbarRect; // 0x110
	private RectTransform m_VerticalScrollbarRect; // 0x118
	private DrivenRectTransformTracker m_Tracker; // 0x120
	private readonly Vector3[] m_Corners; // 0x128

	// Properties
	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRect.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRect.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public RectTransform get_content() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_content(RectTransform value) { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_horizontal() { }

	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_horizontal(bool value) { }

	// RVA: 0x4C6AB0 Offset: 0x4C5CB0 VA: 0x1804C6AB0
	public bool get_vertical() { }

	// RVA: 0x4C6AE0 Offset: 0x4C5CE0 VA: 0x1804C6AE0
	public void set_vertical(bool value) { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public ScrollRect.MovementType get_movementType() { }

	// RVA: 0x5014F0 Offset: 0x5006F0 VA: 0x1805014F0
	public void set_movementType(ScrollRect.MovementType value) { }

	// RVA: 0x527470 Offset: 0x526670 VA: 0x180527470
	public float get_elasticity() { }

	// RVA: 0x499010 Offset: 0x498210 VA: 0x180499010
	public void set_elasticity(float value) { }

	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	public bool get_inertia() { }

	// RVA: 0x18C42D0 Offset: 0x18C34D0 VA: 0x1818C42D0
	public void set_inertia(bool value) { }

	// RVA: 0x7974D0 Offset: 0x7966D0 VA: 0x1807974D0
	public float get_decelerationRate() { }

	// RVA: 0x2507580 Offset: 0x2506780 VA: 0x182507580
	public void set_decelerationRate(float value) { }

	// RVA: 0x5D01F0 Offset: 0x5CF3F0 VA: 0x1805D01F0
	public float get_scrollSensitivity() { }

	// RVA: 0x5D0200 Offset: 0x5CF400 VA: 0x1805D0200
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public RectTransform get_viewport() { }

	// RVA: 0x26F0400 Offset: 0x26EF600 VA: 0x1826F0400
	public void set_viewport(RectTransform value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x26F0080 Offset: 0x26EF280 VA: 0x1826F0080
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x26F0280 Offset: 0x26EF480 VA: 0x1826F0280
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x26F0070 Offset: 0x26EF270 VA: 0x1826F0070
	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10
	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x26F0270 Offset: 0x26EF470 VA: 0x1826F0270
	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x6D7F60 Offset: 0x6D7160 VA: 0x1806D7F60
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x26F0060 Offset: 0x26EF260 VA: 0x1826F0060
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x526CB0 Offset: 0x525EB0 VA: 0x180526CB0
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x26F0260 Offset: 0x26EF460 VA: 0x1826F0260
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	// RVA: 0x26EFF50 Offset: 0x26EF150 VA: 0x1826EFF50
	protected RectTransform get_viewRect() { }

	// RVA: 0x26EFE20 Offset: 0x26EF020 VA: 0x1826EFE20
	public Vector2 get_velocity() { }

	// RVA: 0x146AE20 Offset: 0x146A020 VA: 0x18146AE20
	public void set_velocity(Vector2 value) { }

	// RVA: 0x26EFD10 Offset: 0x26EEF10 VA: 0x1826EFD10
	private RectTransform get_rectTransform() { }

	// RVA: 0x26EF9A0 Offset: 0x26EEBA0 VA: 0x1826EF9A0
	protected void .ctor() { }

	// RVA: 0x26ED600 Offset: 0x26EC800 VA: 0x1826ED600 Slot: 38
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 39
	public virtual void LayoutComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 40
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x26EEDE0 Offset: 0x26EDFE0 VA: 0x1826EEDE0
	private void UpdateCachedData() { }

	// RVA: 0x26ED190 Offset: 0x26EC390 VA: 0x1826ED190 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26ECD00 Offset: 0x26EBF00 VA: 0x1826ECD00 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26EC110 Offset: 0x26EB310 VA: 0x1826EC110 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x26EBB40 Offset: 0x26EAD40 VA: 0x1826EBB40
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x26EE720 Offset: 0x26ED920 VA: 0x1826EE720 Slot: 41
	public virtual void StopMovement() { }

	// RVA: 0x26ED3F0 Offset: 0x26EC5F0 VA: 0x1826ED3F0 Slot: 42
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x26ED370 Offset: 0x26EC570 VA: 0x1826ED370 Slot: 43
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x26ECB90 Offset: 0x26EBD90 VA: 0x1826ECB90 Slot: 44
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x26ED340 Offset: 0x26EC540 VA: 0x1826ED340 Slot: 45
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x26ECF40 Offset: 0x26EC140 VA: 0x1826ECF40 Slot: 46
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x26ED6F0 Offset: 0x26EC8F0 VA: 0x1826ED6F0 Slot: 47
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x26EC180 Offset: 0x26EB380 VA: 0x1826EC180 Slot: 48
	protected virtual void LateUpdate() { }

	// RVA: 0x26EF250 Offset: 0x26EE450 VA: 0x1826EF250
	protected void UpdatePrevData() { }

	// RVA: 0x26EF7B0 Offset: 0x26EE9B0 VA: 0x1826EF7B0
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x26EFCD0 Offset: 0x26EEED0 VA: 0x1826EFCD0
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x26F0200 Offset: 0x26EF400 VA: 0x1826F0200
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x26EFBC0 Offset: 0x26EEDC0 VA: 0x1826EFBC0
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x26ED950 Offset: 0x26ECB50 VA: 0x1826ED950
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x26EFE40 Offset: 0x26EF040 VA: 0x1826EFE40
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x26EE700 Offset: 0x26ED900 VA: 0x1826EE700
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x26ED950 Offset: 0x26ECB50 VA: 0x1826ED950
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x26EE700 Offset: 0x26ED900 VA: 0x1826EE700
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x26EE1E0 Offset: 0x26ED3E0 VA: 0x1826EE1E0 Slot: 49
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x26ED690 Offset: 0x26EC890 VA: 0x1826ED690
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x26ED3E0 Offset: 0x26EC5E0 VA: 0x1826ED3E0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x26EFB30 Offset: 0x26EED30 VA: 0x1826EFB30
	private bool get_hScrollingNeeded() { }

	// RVA: 0x26EFDA0 Offset: 0x26EEFA0 VA: 0x1826EFDA0
	private bool get_vScrollingNeeded() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 50
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 51
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 52
	public virtual float get_minWidth() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 53
	public virtual float get_preferredWidth() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 54
	public virtual float get_flexibleWidth() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 55
	public virtual float get_minHeight() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 56
	public virtual float get_preferredHeight() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 57
	public virtual float get_flexibleHeight() { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380 Slot: 58
	public virtual int get_layoutPriority() { }

	// RVA: 0x26ED970 Offset: 0x26ECB70 VA: 0x1826ED970 Slot: 59
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x26EE0B0 Offset: 0x26ED2B0 VA: 0x1826EE0B0 Slot: 60
	public virtual void SetLayoutVertical() { }

	// RVA: 0x26EF750 Offset: 0x26EE950 VA: 0x1826EF750
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x26EF160 Offset: 0x26EE360 VA: 0x1826EF160
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x26EF370 Offset: 0x26EE570 VA: 0x1826EF370
	private void UpdateScrollbarLayout() { }

	// RVA: 0x26EE780 Offset: 0x26ED980 VA: 0x1826EE780
	protected void UpdateBounds() { }

	// RVA: 0x26EB8C0 Offset: 0x26EAAC0 VA: 0x1826EB8C0
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x26EBBA0 Offset: 0x26EADA0 VA: 0x1826EBBA0
	private Bounds GetBounds() { }

	// RVA: 0x26EBE90 Offset: 0x26EB090 VA: 0x1826EBE90
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x26EB960 Offset: 0x26EAB60 VA: 0x1826EB960
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x26EBCE0 Offset: 0x26EAEE0 VA: 0x1826EBCE0
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x26ED8D0 Offset: 0x26ECAD0 VA: 0x1826ED8D0
	protected void SetDirty() { }

	// RVA: 0x26ED810 Offset: 0x26ECA10 VA: 0x1826ED810
	protected void SetDirtyCaching() { }

	// RVA: 0x23F4140 Offset: 0x23F3340 VA: 0x1823F4140 Slot: 23
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum Selectable.Transition // TypeDefIndex: 16110
{
	// Fields
	public int value__; // 0x0
	public const Selectable.Transition None = 0;
	public const Selectable.Transition ColorTint = 1;
	public const Selectable.Transition SpriteSwap = 2;
	public const Selectable.Transition Animation = 3;
}

// Namespace: 
protected enum Selectable.SelectionState // TypeDefIndex: 16111
{
	// Fields
	public int value__; // 0x0
	public const Selectable.SelectionState Normal = 0;
	public const Selectable.SelectionState Highlighted = 1;
	public const Selectable.SelectionState Pressed = 2;
	public const Selectable.SelectionState Selected = 3;
	public const Selectable.SelectionState Disabled = 4;
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
[AddComponentMenu("UI/Selectable", 35)]
[SelectionBase]
[DisallowMultipleComponent]
public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 16112
{
	// Fields
	protected static Selectable[] s_Selectables; // 0x0
	protected static int s_SelectableCount; // 0x8
	private bool m_EnableCalled; // 0x20
	[SerializeField]
	[FormerlySerializedAs("navigation")]
	private Navigation m_Navigation; // 0x28
	[SerializeField]
	[FormerlySerializedAs("transition")]
	private Selectable.Transition m_Transition; // 0x50
	[SerializeField]
	[FormerlySerializedAs("colors")]
	private ColorBlock m_Colors; // 0x54
	[SerializeField]
	[FormerlySerializedAs("spriteState")]
	private SpriteState m_SpriteState; // 0xB0
	[FormerlySerializedAs("animationTriggers")]
	[SerializeField]
	private AnimationTriggers m_AnimationTriggers; // 0xD0
	[Tooltip("Can the Selectable be interacted with?")]
	[SerializeField]
	private bool m_Interactable; // 0xD8
	[SerializeField]
	[FormerlySerializedAs("highlightGraphic")]
	[FormerlySerializedAs("m_HighlightGraphic")]
	private Graphic m_TargetGraphic; // 0xE0
	private bool m_GroupsAllowInteraction; // 0xE8
	protected int m_CurrentIndex; // 0xEC
	[CompilerGenerated]
	private bool <isPointerInside>k__BackingField; // 0xF0
	[CompilerGenerated]
	private bool <isPointerDown>k__BackingField; // 0xF1
	[CompilerGenerated]
	private bool <hasSelection>k__BackingField; // 0xF2
	private readonly List<CanvasGroup> m_CanvasGroupCache; // 0xF8

	// Properties
	public static Selectable[] allSelectablesArray { get; }
	public static int allSelectableCount { get; }
	[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", False)]
	public static List<Selectable> allSelectables { get; }
	public Navigation navigation { get; set; }
	public Selectable.Transition transition { get; set; }
	public ColorBlock colors { get; set; }
	public SpriteState spriteState { get; set; }
	public AnimationTriggers animationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public bool interactable { get; set; }
	private bool isPointerInside { get; set; }
	private bool isPointerDown { get; set; }
	private bool hasSelection { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }
	protected Selectable.SelectionState currentSelectionState { get; }

	// Methods

	// RVA: 0x26F4840 Offset: 0x26F3A40 VA: 0x1826F4840
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x26F47F0 Offset: 0x26F39F0 VA: 0x1826F47F0
	public static int get_allSelectableCount() { }

	// RVA: 0x26F48D0 Offset: 0x26F3AD0 VA: 0x1826F48D0
	public static List<Selectable> get_allSelectables() { }

	// RVA: 0x26F21B0 Offset: 0x26F13B0 VA: 0x1826F21B0
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x26F4B40 Offset: 0x26F3D40 VA: 0x1826F4B40
	public Navigation get_navigation() { }

	// RVA: 0x26F4E10 Offset: 0x26F4010 VA: 0x1826F4E10
	public void set_navigation(Navigation value) { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public Selectable.Transition get_transition() { }

	// RVA: 0x26F4F60 Offset: 0x26F4160 VA: 0x1826F4F60
	public void set_transition(Selectable.Transition value) { }

	// RVA: 0x26F4A10 Offset: 0x26F3C10 VA: 0x1826F4A10
	public ColorBlock get_colors() { }

	// RVA: 0x26F4BE0 Offset: 0x26F3DE0 VA: 0x1826F4BE0
	public void set_colors(ColorBlock value) { }

	// RVA: 0x26F4B60 Offset: 0x26F3D60 VA: 0x1826F4B60
	public SpriteState get_spriteState() { }

	// RVA: 0x26F4E90 Offset: 0x26F4090 VA: 0x1826F4E90
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x26F4B80 Offset: 0x26F3D80 VA: 0x1826F4B80
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	public Graphic get_targetGraphic() { }

	// RVA: 0x26F4F00 Offset: 0x26F4100 VA: 0x1826F4F00
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x1C61220 Offset: 0x1C60420 VA: 0x181C61220
	public bool get_interactable() { }

	// RVA: 0x26F4C80 Offset: 0x26F3E80 VA: 0x1826F4C80
	public void set_interactable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x772510 Offset: 0x771710 VA: 0x180772510
	private bool get_isPointerInside() { }

	[CompilerGenerated]
	// RVA: 0x26F4E00 Offset: 0x26F4000 VA: 0x1826F4E00
	private void set_isPointerInside(bool value) { }

	[CompilerGenerated]
	// RVA: 0x772480 Offset: 0x771680 VA: 0x180772480
	private bool get_isPointerDown() { }

	[CompilerGenerated]
	// RVA: 0x26F4DF0 Offset: 0x26F3FF0 VA: 0x1826F4DF0
	private void set_isPointerDown(bool value) { }

	[CompilerGenerated]
	// RVA: 0x772460 Offset: 0x771660 VA: 0x180772460
	private bool get_hasSelection() { }

	[CompilerGenerated]
	// RVA: 0x1861F90 Offset: 0x1861190 VA: 0x181861F90
	private void set_hasSelection(bool value) { }

	// RVA: 0x26F4690 Offset: 0x26F3890 VA: 0x1826F4690
	protected void .ctor() { }

	// RVA: 0x26F4AC0 Offset: 0x26F3CC0 VA: 0x1826F4AC0
	public Image get_image() { }

	// RVA: 0x8A5A60 Offset: 0x8A4C60 VA: 0x1808A5A60
	public void set_image(Image value) { }

	// RVA: 0x26F49D0 Offset: 0x26F3BD0 VA: 0x1826F49D0
	public Animator get_animator() { }

	// RVA: 0x26F2280 Offset: 0x26F1480 VA: 0x1826F2280 Slot: 4
	protected override void Awake() { }

	// RVA: 0x26F3640 Offset: 0x26F2840 VA: 0x1826F3640 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x26F4050 Offset: 0x26F3250 VA: 0x1826F4050
	private bool ParentGroupAllowsInteraction() { }

	// RVA: 0x26F34C0 Offset: 0x26F26C0 VA: 0x1826F34C0 Slot: 24
	public virtual bool IsInteractable() { }

	// RVA: 0x26F3700 Offset: 0x26F2900 VA: 0x1826F3700 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x26F3890 Offset: 0x26F2A90 VA: 0x1826F3890 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26F4020 Offset: 0x26F3220 VA: 0x1826F4020 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x26F3FA0 Offset: 0x26F31A0 VA: 0x1826F3FA0
	private void OnSetProperty() { }

	// RVA: 0x26F3710 Offset: 0x26F2910 VA: 0x1826F3710 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26F35D0 Offset: 0x26F27D0 VA: 0x1826F35D0
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x26F4A50 Offset: 0x26F3C50 VA: 0x1826F4A50
	protected Selectable.SelectionState get_currentSelectionState() { }

	// RVA: 0x26F3330 Offset: 0x26F2530 VA: 0x1826F3330 Slot: 25
	protected virtual void InstantClearState() { }

	// RVA: 0x26F23B0 Offset: 0x26F15B0 VA: 0x1826F23B0 Slot: 26
	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x26F2A40 Offset: 0x26F1C40 VA: 0x1826F2A40
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x26F3100 Offset: 0x26F2300 VA: 0x1826F3100
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x26F3530 Offset: 0x26F2730 VA: 0x1826F3530
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x26F27A0 Offset: 0x26F19A0 VA: 0x1826F27A0 Slot: 27
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x26F2880 Offset: 0x26F1A80 VA: 0x1826F2880 Slot: 28
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x26F2960 Offset: 0x26F1B60 VA: 0x1826F2960 Slot: 29
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x26F26C0 Offset: 0x26F18C0 VA: 0x1826F26C0 Slot: 30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x26F3B90 Offset: 0x26F2D90 VA: 0x1826F3B90 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x26F42D0 Offset: 0x26F34D0 VA: 0x1826F42D0
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x26F2310 Offset: 0x26F1510 VA: 0x1826F2310
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x26F43D0 Offset: 0x26F35D0 VA: 0x1826F43D0
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x26F3450 Offset: 0x26F2650 VA: 0x1826F3450
	protected bool IsHighlighted() { }

	// RVA: 0x26F34E0 Offset: 0x26F26E0 VA: 0x1826F34E0
	protected bool IsPressed() { }

	// RVA: 0x26F2650 Offset: 0x26F1850 VA: 0x1826F2650
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x26F3CC0 Offset: 0x26F2EC0 VA: 0x1826F3CC0 Slot: 32
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x26F3EF0 Offset: 0x26F30F0 VA: 0x1826F3EF0 Slot: 33
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x26F3DF0 Offset: 0x26F2FF0 VA: 0x1826F3DF0 Slot: 34
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x26F3E70 Offset: 0x26F3070 VA: 0x1826F3E70 Slot: 35
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x26F3F20 Offset: 0x26F3120 VA: 0x1826F3F20 Slot: 36
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x26F3680 Offset: 0x26F2880 VA: 0x1826F3680 Slot: 37
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x26F41E0 Offset: 0x26F33E0 VA: 0x1826F41E0 Slot: 38
	public virtual void Select() { }

	// RVA: 0x26F4620 Offset: 0x26F3820 VA: 0x1826F4620
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
internal static class SetPropertyUtility // TypeDefIndex: 16113
{
	// Methods

	// RVA: 0x2415C80 Offset: 0x2414E80 VA: 0x182415C80
	public static bool SetColor(ref Color currentValue, Color newValue) { }

	// RVA: -1 Offset: -1
	public static bool SetStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6F740 Offset: 0xA6E940 VA: 0x180A6F740
	|-SetPropertyUtility.SetStruct<bool>
	|
	|-RVA: 0xA6FA00 Offset: 0xA6EC00 VA: 0x180A6FA00
	|-SetPropertyUtility.SetStruct<char>
	|
	|-RVA: 0xA6FB60 Offset: 0xA6ED60 VA: 0x180A6FB60
	|-SetPropertyUtility.SetStruct<ColorBlock>
	|
	|-RVA: 0xA70240 Offset: 0xA6F440 VA: 0x180A70240
	|-SetPropertyUtility.SetStruct<int>
	|
	|-RVA: 0xA70030 Offset: 0xA6F230 VA: 0x180A70030
	|-SetPropertyUtility.SetStruct<Int32Enum>
	|
	|-RVA: 0xA70420 Offset: 0xA6F620 VA: 0x180A70420
	|-SetPropertyUtility.SetStruct<Navigation>
	|
	|-RVA: 0xA70660 Offset: 0xA6F860 VA: 0x180A70660
	|-SetPropertyUtility.SetStruct<float>
	|
	|-RVA: 0xA707C0 Offset: 0xA6F9C0 VA: 0x180A707C0
	|-SetPropertyUtility.SetStruct<SpriteState>
	|
	|-RVA: 0xA6FEE0 Offset: 0xA6F0E0 VA: 0x180A6FEE0
	|-SetPropertyUtility.SetStruct<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool SetClass<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6F540 Offset: 0xA6E740 VA: 0x180A6F540
	|-SetPropertyUtility.SetClass<object>
	*/
}

// Namespace: 
public enum Slider.Direction // TypeDefIndex: 16114
{
	// Fields
	public int value__; // 0x0
	public const Slider.Direction LeftToRight = 0;
	public const Slider.Direction RightToLeft = 1;
	public const Slider.Direction BottomToTop = 2;
	public const Slider.Direction TopToBottom = 3;
}

// Namespace: 
[Serializable]
public class Slider.SliderEvent : UnityEvent<float> // TypeDefIndex: 16115
{
	// Methods

	// RVA: 0x26F4FC0 Offset: 0x26F41C0 VA: 0x1826F4FC0
	public void .ctor() { }
}

// Namespace: 
private enum Slider.Axis // TypeDefIndex: 16116
{
	// Fields
	public int value__; // 0x0
	public const Slider.Axis Horizontal = 0;
	public const Slider.Axis Vertical = 1;
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
[AddComponentMenu("UI/Slider", 34)]
public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 16117
{
	// Fields
	[SerializeField]
	private RectTransform m_FillRect; // 0x100
	[SerializeField]
	private RectTransform m_HandleRect; // 0x108
	[Space]
	[SerializeField]
	private Slider.Direction m_Direction; // 0x110
	[SerializeField]
	private float m_MinValue; // 0x114
	[SerializeField]
	private float m_MaxValue; // 0x118
	[SerializeField]
	private bool m_WholeNumbers; // 0x11C
	[SerializeField]
	protected float m_Value; // 0x120
	[Space]
	[SerializeField]
	private Slider.SliderEvent m_OnValueChanged; // 0x128
	private Image m_FillImage; // 0x130
	private Transform m_FillTransform; // 0x138
	private RectTransform m_FillContainerRect; // 0x140
	private Transform m_HandleTransform; // 0x148
	private RectTransform m_HandleContainerRect; // 0x150
	private Vector2 m_Offset; // 0x158
	private DrivenRectTransformTracker m_Tracker; // 0x160
	private bool m_DelayedUpdateVisuals; // 0x161

	// Properties
	public RectTransform fillRect { get; set; }
	public RectTransform handleRect { get; set; }
	public Slider.Direction direction { get; set; }
	public float minValue { get; set; }
	public float maxValue { get; set; }
	public bool wholeNumbers { get; set; }
	public virtual float value { get; set; }
	public float normalizedValue { get; set; }
	public Slider.SliderEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Slider.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x7960A0 Offset: 0x7952A0 VA: 0x1807960A0
	public RectTransform get_fillRect() { }

	// RVA: 0x26F6B30 Offset: 0x26F5D30 VA: 0x1826F6B30
	public void set_fillRect(RectTransform value) { }

	// RVA: 0x789810 Offset: 0x788A10 VA: 0x180789810
	public RectTransform get_handleRect() { }

	// RVA: 0x26F6BA0 Offset: 0x26F5DA0 VA: 0x1826F6BA0
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x23E6DF0 Offset: 0x23E5FF0 VA: 0x1823E6DF0
	public Slider.Direction get_direction() { }

	// RVA: 0x26F6AD0 Offset: 0x26F5CD0 VA: 0x1826F6AD0
	public void set_direction(Slider.Direction value) { }

	// RVA: 0x2424120 Offset: 0x2423320 VA: 0x182424120
	public float get_minValue() { }

	// RVA: 0x26F6C90 Offset: 0x26F5E90 VA: 0x1826F6C90
	public void set_minValue(float value) { }

	// RVA: 0x26F69A0 Offset: 0x26F5BA0 VA: 0x1826F69A0
	public float get_maxValue() { }

	// RVA: 0x26F6C10 Offset: 0x26F5E10 VA: 0x1826F6C10
	public void set_maxValue(float value) { }

	// RVA: 0x21AED70 Offset: 0x21ADF70 VA: 0x1821AED70
	public bool get_wholeNumbers() { }

	// RVA: 0x26F6D80 Offset: 0x26F5F80 VA: 0x1826F6D80
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x26F6AB0 Offset: 0x26F5CB0 VA: 0x1826F6AB0 Slot: 46
	public virtual float get_value() { }

	// RVA: 0x26F6D60 Offset: 0x26F5F60 VA: 0x1826F6D60 Slot: 47
	public virtual void set_value(float value) { }

	// RVA: 0x26F5C50 Offset: 0x26F4E50 VA: 0x1826F5C50 Slot: 48
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x26F69B0 Offset: 0x26F5BB0 VA: 0x1826F69B0
	public float get_normalizedValue() { }

	// RVA: 0x26F6D10 Offset: 0x26F5F10 VA: 0x1826F6D10
	public void set_normalizedValue(float value) { }

	// RVA: 0x6ED530 Offset: 0x6EC730 VA: 0x1806ED530
	public Slider.SliderEvent get_onValueChanged() { }

	// RVA: 0x5405B0 Offset: 0x53F7B0 VA: 0x1805405B0
	public void set_onValueChanged(Slider.SliderEvent value) { }

	// RVA: 0x26F6A80 Offset: 0x26F5C80 VA: 0x1826F6A80
	private float get_stepSize() { }

	// RVA: 0x26F6890 Offset: 0x26F5A90 VA: 0x1826F6890
	protected void .ctor() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 49
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 50
	public virtual void LayoutComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 51
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x26F5430 Offset: 0x26F4630 VA: 0x1826F5430 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26F5380 Offset: 0x26F4580 VA: 0x1826F5380 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26F6840 Offset: 0x26F5A40 VA: 0x1826F6840 Slot: 52
	protected virtual void Update() { }

	// RVA: 0x26F50F0 Offset: 0x26F42F0 VA: 0x1826F50F0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x26F5D50 Offset: 0x26F4F50 VA: 0x1826F5D50
	private void UpdateCachedReferences() { }

	// RVA: 0x26F5000 Offset: 0x26F4200 VA: 0x1826F5000
	private float ClampValue(float input) { }

	// RVA: 0x26F5C70 Offset: 0x26F4E70 VA: 0x1826F5C70 Slot: 53
	protected virtual void Set(float input, bool sendCallback = True) { }

	// RVA: 0x26F5A40 Offset: 0x26F4C40 VA: 0x1826F5A40 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x26F6980 Offset: 0x26F5B80 VA: 0x1826F6980
	private Slider.Axis get_axis() { }

	// RVA: 0x26F6A60 Offset: 0x26F5C60 VA: 0x1826F6A60
	private bool get_reverseValue() { }

	// RVA: 0x26F6380 Offset: 0x26F5580 VA: 0x1826F6380
	private void UpdateVisuals() { }

	// RVA: 0x26F6050 Offset: 0x26F5250 VA: 0x1826F6050
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x26F0690 Offset: 0x26EF890 VA: 0x1826F0690
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x26F57E0 Offset: 0x26F49E0 VA: 0x1826F57E0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x26F53B0 Offset: 0x26F45B0 VA: 0x1826F53B0 Slot: 54
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x26F5480 Offset: 0x26F4680 VA: 0x1826F5480 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x26F5060 Offset: 0x26F4260 VA: 0x1826F5060 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x26F5090 Offset: 0x26F4290 VA: 0x1826F5090 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x26F50C0 Offset: 0x26F42C0 VA: 0x1826F50C0 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x26F5030 Offset: 0x26F4230 VA: 0x1826F5030 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x26F0B70 Offset: 0x26EFD70 VA: 0x1826F0B70 Slot: 55
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x26F5A80 Offset: 0x26F4C80 VA: 0x1826F5A80
	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x23F4140 Offset: 0x23F3340 VA: 0x1823F4140 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 16118
{
	// Fields
	[SerializeField]
	private Sprite m_HighlightedSprite; // 0x0
	[SerializeField]
	private Sprite m_PressedSprite; // 0x8
	[FormerlySerializedAs("m_HighlightedSprite")]
	[SerializeField]
	private Sprite m_SelectedSprite; // 0x10
	[SerializeField]
	private Sprite m_DisabledSprite; // 0x18

	// Properties
	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Sprite get_highlightedSprite() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Sprite get_pressedSprite() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Sprite get_selectedSprite() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Sprite get_disabledSprite() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x26F6E00 Offset: 0x26F6000 VA: 0x1826F6E00 Slot: 4
	public bool Equals(SpriteState other) { }
}

// Namespace: 
private class StencilMaterial.MatEntry // TypeDefIndex: 16119
{
	// Fields
	public Material baseMat; // 0x10
	public Material customMat; // 0x18
	public int count; // 0x20
	public int stencilId; // 0x24
	public StencilOp operation; // 0x28
	public CompareFunction compareFunction; // 0x2C
	public int readMask; // 0x30
	public int writeMask; // 0x34
	public bool useAlphaClip; // 0x38
	public ColorWriteMask colorMask; // 0x3C

	// Methods

	// RVA: 0x26E7500 Offset: 0x26E6700 VA: 0x1826E7500
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public static class StencilMaterial // TypeDefIndex: 16120
{
	// Fields
	private static List<StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	[EditorBrowsable(1)]
	[Obsolete("Use Material.Add instead.", True)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x26F6F00 Offset: 0x26F6100 VA: 0x1826F6F00
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x26F7AE0 Offset: 0x26F6CE0 VA: 0x1826F7AE0
	private static void LogWarningWhenNotInBatchmode(string warning, Object context) { }

	// RVA: 0x26F6FA0 Offset: 0x26F61A0 VA: 0x1826F6FA0
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x26F7B70 Offset: 0x26F6D70 VA: 0x1826F7B70
	public static void Remove(Material customMat) { }

	// RVA: 0x26F7990 Offset: 0x26F6B90 VA: 0x1826F7990
	public static void ClearAll() { }

	// RVA: 0x26F7D40 Offset: 0x26F6F40 VA: 0x1826F7D40
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Legacy/Text", 100)]
[RequireComponent(typeof(CanvasRenderer))]
public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 16121
{
	// Fields
	[SerializeField]
	private FontData m_FontData; // 0xE0
	[TextArea(3, 10)]
	[SerializeField]
	protected string m_Text; // 0xE8
	private TextGenerator m_TextCache; // 0xF0
	private TextGenerator m_TextCacheForLayout; // 0xF8
	protected static Material s_DefaultText; // 0x0
	protected bool m_DisableFontTextureRebuiltCallback; // 0x100
	private readonly UIVertex[] m_TempVerts; // 0x108

	// Properties
	public TextGenerator cachedTextGenerator { get; }
	public TextGenerator cachedTextGeneratorForLayout { get; }
	public override Texture mainTexture { get; }
	public Font font { get; set; }
	public virtual string text { get; set; }
	public bool supportRichText { get; set; }
	public bool resizeTextForBestFit { get; set; }
	public int resizeTextMinSize { get; set; }
	public int resizeTextMaxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public int fontSize { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }
	public FontStyle fontStyle { get; set; }
	public float pixelsPerUnit { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x26F8C40 Offset: 0x26F7E40 VA: 0x1826F8C40
	protected void .ctor() { }

	// RVA: 0x26F8D80 Offset: 0x26F7F80 VA: 0x1826F8D80
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x26F8D10 Offset: 0x26F7F10 VA: 0x1826F8D10
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x26F8EA0 Offset: 0x26F80A0 VA: 0x1826F8EA0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x26F7EC0 Offset: 0x26F70C0 VA: 0x1826F7EC0
	public void FontTextureChanged() { }

	// RVA: 0x26F8E40 Offset: 0x26F8040 VA: 0x1826F8E40
	public Font get_font() { }

	// RVA: 0x26F96D0 Offset: 0x26F88D0 VA: 0x1826F96D0
	public void set_font(Font value) { }

	// RVA: 0x796090 Offset: 0x795290 VA: 0x180796090 Slot: 74
	public virtual string get_text() { }

	// RVA: 0x26F9A40 Offset: 0x26F8C40 VA: 0x1826F9A40 Slot: 75
	public virtual void set_text(string value) { }

	// RVA: 0x26F9530 Offset: 0x26F8730 VA: 0x1826F9530
	public bool get_supportRichText() { }

	// RVA: 0x26F99E0 Offset: 0x26F8BE0 VA: 0x1826F99E0
	public void set_supportRichText(bool value) { }

	// RVA: 0x26F94D0 Offset: 0x26F86D0 VA: 0x1826F94D0
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x26F98C0 Offset: 0x26F8AC0 VA: 0x1826F98C0
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x26F9510 Offset: 0x26F8710 VA: 0x1826F9510
	public int get_resizeTextMinSize() { }

	// RVA: 0x26F9980 Offset: 0x26F8B80 VA: 0x1826F9980
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x26F94F0 Offset: 0x26F86F0 VA: 0x1826F94F0
	public int get_resizeTextMaxSize() { }

	// RVA: 0x26F9920 Offset: 0x26F8B20 VA: 0x1826F9920
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x26F8CF0 Offset: 0x26F7EF0 VA: 0x1826F8CF0
	public TextAnchor get_alignment() { }

	// RVA: 0x26F95B0 Offset: 0x26F87B0 VA: 0x1826F95B0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x26F8CD0 Offset: 0x26F7ED0 VA: 0x1826F8CD0
	public bool get_alignByGeometry() { }

	// RVA: 0x26F9570 Offset: 0x26F8770 VA: 0x1826F9570
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x2374540 Offset: 0x2373740 VA: 0x182374540
	public int get_fontSize() { }

	// RVA: 0x26F9610 Offset: 0x26F8810 VA: 0x1826F9610
	public void set_fontSize(int value) { }

	// RVA: 0x26F8E60 Offset: 0x26F8060 VA: 0x1826F8E60
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x26F97F0 Offset: 0x26F89F0 VA: 0x1826F97F0
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x26F9550 Offset: 0x26F8750 VA: 0x1826F9550
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x26F9B10 Offset: 0x26F8D10 VA: 0x1826F9B10
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x26F8E80 Offset: 0x26F8080 VA: 0x1826F8E80
	public float get_lineSpacing() { }

	// RVA: 0x26F9850 Offset: 0x26F8A50 VA: 0x1826F9850
	public void set_lineSpacing(float value) { }

	// RVA: 0x26F8E20 Offset: 0x26F8020 VA: 0x1826F8E20
	public FontStyle get_fontStyle() { }

	// RVA: 0x26F9670 Offset: 0x26F8870 VA: 0x1826F9670
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x26F90A0 Offset: 0x26F82A0 VA: 0x1826F90A0
	public float get_pixelsPerUnit() { }

	// RVA: 0x26F83F0 Offset: 0x26F75F0 VA: 0x1826F83F0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26F8390 Offset: 0x26F7590 VA: 0x1826F8390 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26F8BC0 Offset: 0x26F7DC0 VA: 0x1826F8BC0 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x26F7E60 Offset: 0x26F7060 VA: 0x1826F7E60
	internal void AssignDefaultFont() { }

	// RVA: 0x26F7DB0 Offset: 0x26F6FB0 VA: 0x1826F7DB0
	internal void AssignDefaultFontIfNecessary() { }

	// RVA: 0x26F7FE0 Offset: 0x26F71E0 VA: 0x1826F7FE0
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x26F8220 Offset: 0x26F7420 VA: 0x1826F8220
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x26F8470 Offset: 0x26F7670 VA: 0x1826F8470 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 76
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 77
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 78
	public virtual float get_minWidth() { }

	// RVA: 0x26F9360 Offset: 0x26F8560 VA: 0x1826F9360 Slot: 79
	public virtual float get_preferredWidth() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 80
	public virtual float get_flexibleWidth() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 81
	public virtual float get_minHeight() { }

	// RVA: 0x26F9210 Offset: 0x26F8410 VA: 0x1826F9210 Slot: 82
	public virtual float get_preferredHeight() { }

	// RVA: 0x23F59B0 Offset: 0x23F4BB0 VA: 0x1823F59B0 Slot: 83
	public virtual float get_flexibleHeight() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 84
	public virtual int get_layoutPriority() { }
}

// Namespace: 
public enum Toggle.ToggleTransition // TypeDefIndex: 16122
{
	// Fields
	public int value__; // 0x0
	public const Toggle.ToggleTransition None = 0;
	public const Toggle.ToggleTransition Fade = 1;
}

// Namespace: 
[Serializable]
public class Toggle.ToggleEvent : UnityEvent<bool> // TypeDefIndex: 16123
{
	// Methods

	// RVA: 0x26F9B70 Offset: 0x26F8D70 VA: 0x1826F9B70
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Toggle", 30)]
[RequireComponent(typeof(RectTransform))]
public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 16124
{
	// Fields
	public Toggle.ToggleTransition toggleTransition; // 0x100
	public Graphic graphic; // 0x108
	[SerializeField]
	private ToggleGroup m_Group; // 0x110
	public Toggle.ToggleEvent onValueChanged; // 0x118
	[Tooltip("Is the toggle currently on or off?")]
	[SerializeField]
	private bool m_IsOn; // 0x120

	// Properties
	public ToggleGroup group { get; set; }
	public bool isOn { get; set; }

	// Methods

	// RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520
	public ToggleGroup get_group() { }

	// RVA: 0x26FB130 Offset: 0x26FA330 VA: 0x1826FB130
	public void set_group(ToggleGroup value) { }

	// RVA: 0x26FB080 Offset: 0x26FA280 VA: 0x1826FB080
	protected void .ctor() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x26FA960 Offset: 0x26F9B60 VA: 0x1826FA960 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x26FAAF0 Offset: 0x26F9CF0 VA: 0x1826FAAF0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26FAAC0 Offset: 0x26F9CC0 VA: 0x1826FAAC0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26FA9F0 Offset: 0x26F9BF0 VA: 0x1826FA9F0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x26FAC80 Offset: 0x26F9E80 VA: 0x1826FAC80
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x1864060 Offset: 0x1863260 VA: 0x181864060
	public bool get_isOn() { }

	// RVA: 0x26FB160 Offset: 0x26FA360 VA: 0x1826FB160
	public void set_isOn(bool value) { }

	// RVA: 0x26FAC70 Offset: 0x26F9E70 VA: 0x1826FAC70
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x26FAEE0 Offset: 0x26FA0E0 VA: 0x1826FAEE0
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x26FABB0 Offset: 0x26F9DB0 VA: 0x1826FABB0
	private void PlayEffect(bool instant) { }

	// RVA: 0x26FB070 Offset: 0x26FA270 VA: 0x1826FB070 Slot: 6
	protected override void Start() { }

	// RVA: 0x26FA900 Offset: 0x26F9B00 VA: 0x1826FA900
	private void InternalToggle() { }

	// RVA: 0x26FAB30 Offset: 0x26F9D30 VA: 0x1826FAB30 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x26FA900 Offset: 0x26F9B00 VA: 0x1826FA900 Slot: 50
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x23F4140 Offset: 0x23F3340 VA: 0x1823F4140 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ToggleGroup.<>c // TypeDefIndex: 16125
{
	// Fields
	public static readonly ToggleGroup.<>c <>9; // 0x0
	public static Predicate<Toggle> <>9__13_0; // 0x8
	public static Func<Toggle, bool> <>9__14_0; // 0x10

	// Methods

	// RVA: 0x26FB430 Offset: 0x26FA630 VA: 0x1826FB430
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x26FB410 Offset: 0x26FA610 VA: 0x1826FB410
	internal bool <AnyTogglesOn>b__13_0(Toggle x) { }

	// RVA: 0x26FB410 Offset: 0x26FA610 VA: 0x1826FB410
	internal bool <ActiveToggles>b__14_0(Toggle x) { }
}

// Namespace: UnityEngine.UI
[DisallowMultipleComponent]
[AddComponentMenu("UI/Toggle Group", 31)]
public class ToggleGroup : UIBehaviour // TypeDefIndex: 16126
{
	// Fields
	[SerializeField]
	private bool m_AllowSwitchOff; // 0x20
	protected List<Toggle> m_Toggles; // 0x28

	// Properties
	public bool allowSwitchOff { get; set; }

	// Methods

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_allowSwitchOff() { }

	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x26FA890 Offset: 0x26F9A90 VA: 0x1826FA890
	protected void .ctor() { }

	// RVA: 0x26FA4C0 Offset: 0x26F96C0 VA: 0x1826FA4C0 Slot: 6
	protected override void Start() { }

	// RVA: 0x26FA4C0 Offset: 0x26F96C0 VA: 0x1826FA4C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26FA740 Offset: 0x26F9940 VA: 0x1826FA740
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x26FA260 Offset: 0x26F9460 VA: 0x1826FA260
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

	// RVA: 0x26FA6C0 Offset: 0x26F98C0 VA: 0x1826FA6C0
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x26FA4E0 Offset: 0x26F96E0 VA: 0x1826FA4E0
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x26F9DF0 Offset: 0x26F8FF0 VA: 0x1826F9DF0
	public void EnsureValidState() { }

	// RVA: 0x26F9CB0 Offset: 0x26F8EB0 VA: 0x1826F9CB0
	public bool AnyTogglesOn() { }

	// RVA: 0x26F9BB0 Offset: 0x26F8DB0 VA: 0x1826F9BB0
	public IEnumerable<Toggle> ActiveToggles() { }

	// RVA: 0x26FA1F0 Offset: 0x26F93F0 VA: 0x1826FA1F0
	public Toggle GetFirstActiveToggle() { }

	// RVA: 0x26FA5B0 Offset: 0x26F97B0 VA: 0x1826FA5B0
	public void SetAllTogglesOff(bool sendCallback = True) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.Raycast3DCallback : MulticastDelegate // TypeDefIndex: 16127
{
	// Methods

	// RVA: 0x26E8F50 Offset: 0x26E8150 VA: 0x1826E8F50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26E7350 Offset: 0x26E6550 VA: 0x1826E7350 Slot: 13
	public virtual bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	// RVA: 0x26E8E60 Offset: 0x26E8060 VA: 0x1826E8E60 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x459520 Offset: 0x458720 VA: 0x180459520 Slot: 15
	public virtual bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.RaycastAllCallback : MulticastDelegate // TypeDefIndex: 16128
{
	// Methods

	// RVA: 0x26E71E0 Offset: 0x26E63E0 VA: 0x1826E71E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26E71A0 Offset: 0x26E63A0 VA: 0x1826E71A0 Slot: 13
	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x26E8FF0 Offset: 0x26E81F0 VA: 0x1826E8FF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.GetRaycastNonAllocCallback : MulticastDelegate // TypeDefIndex: 16129
{
	// Methods

	// RVA: 0x26E7390 Offset: 0x26E6590 VA: 0x1826E7390
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26E7350 Offset: 0x26E6550 VA: 0x1826E7350 Slot: 13
	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x26E7430 Offset: 0x26E6630 VA: 0x1826E7430 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.Raycast2DCallback : MulticastDelegate // TypeDefIndex: 16130
{
	// Methods

	// RVA: 0x26E8DC0 Offset: 0x26E7FC0 VA: 0x1826E8DC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26E8D60 Offset: 0x26E7F60 VA: 0x1826E8D60 Slot: 13
	public virtual RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	// RVA: 0x26E8C30 Offset: 0x26E7E30 VA: 0x1826E8C30 Slot: 14
	public virtual IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x26E8D10 Offset: 0x26E7F10 VA: 0x1826E8D10 Slot: 15
	public virtual RaycastHit2D EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.GetRayIntersectionAllCallback : MulticastDelegate // TypeDefIndex: 16131
{
	// Methods

	// RVA: 0x26E71E0 Offset: 0x26E63E0 VA: 0x1826E71E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26E71A0 Offset: 0x26E63A0 VA: 0x1826E71A0 Slot: 13
	public virtual RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x26E70E0 Offset: 0x26E62E0 VA: 0x1826E70E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual RaycastHit2D[] EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback : MulticastDelegate // TypeDefIndex: 16132
{
	// Methods

	// RVA: 0x26E7390 Offset: 0x26E6590 VA: 0x1826E7390
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26E7350 Offset: 0x26E6550 VA: 0x1826E7350 Slot: 13
	public virtual int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	// RVA: 0x26E7280 Offset: 0x26E6480 VA: 0x1826E7280 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.UI
internal class ReflectionMethodsCache // TypeDefIndex: 16133
{
	// Fields
	public ReflectionMethodsCache.Raycast3DCallback raycast3D; // 0x10
	public ReflectionMethodsCache.RaycastAllCallback raycast3DAll; // 0x18
	public ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc; // 0x20
	public ReflectionMethodsCache.Raycast2DCallback raycast2D; // 0x28
	public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll; // 0x30
	public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; // 0x38
	private static ReflectionMethodsCache s_ReflectionMethodsCache; // 0x0

	// Properties
	public static ReflectionMethodsCache Singleton { get; }

	// Methods

	// RVA: 0x26EA980 Offset: 0x26E9B80 VA: 0x1826EA980
	public void .ctor() { }

	// RVA: 0x26EB7C0 Offset: 0x26EA9C0 VA: 0x1826EB7C0
	public static ReflectionMethodsCache get_Singleton() { }
}

// Namespace: UnityEngine.UI
public class VertexHelper : IDisposable // TypeDefIndex: 16134
{
	// Fields
	private List<Vector3> m_Positions; // 0x10
	private List<Color32> m_Colors; // 0x18
	private List<Vector4> m_Uv0S; // 0x20
	private List<Vector4> m_Uv1S; // 0x28
	private List<Vector4> m_Uv2S; // 0x30
	private List<Vector4> m_Uv3S; // 0x38
	private List<Vector3> m_Normals; // 0x40
	private List<Vector4> m_Tangents; // 0x48
	private List<int> m_Indices; // 0x50
	private static readonly Vector4 s_DefaultTangent; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x10
	private bool m_ListsInitalized; // 0x58

	// Properties
	public int currentVertCount { get; }
	public int currentIndexCount { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x26FCDC0 Offset: 0x26FBFC0 VA: 0x1826FCDC0
	public void .ctor(Mesh m) { }

	// RVA: 0x26FC6A0 Offset: 0x26FB8A0 VA: 0x1826FC6A0
	private void InitializeListIfRequired() { }

	// RVA: 0x26FC310 Offset: 0x26FB510 VA: 0x1826FC310 Slot: 4
	public void Dispose() { }

	// RVA: 0x26FC220 Offset: 0x26FB420 VA: 0x1826FC220
	public void Clear() { }

	// RVA: 0x26FD050 Offset: 0x26FC250 VA: 0x1826FD050
	public int get_currentVertCount() { }

	// RVA: 0x26FD000 Offset: 0x26FC200 VA: 0x1826FD000
	public int get_currentIndexCount() { }

	// RVA: 0x26FC820 Offset: 0x26FBA20 VA: 0x1826FC820
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x26FC9E0 Offset: 0x26FBBE0 VA: 0x1826FC9E0
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x26FC4C0 Offset: 0x26FB6C0 VA: 0x1826FC4C0
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x26FBDE0 Offset: 0x26FAFE0 VA: 0x1826FBDE0
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x26FBBC0 Offset: 0x26FADC0 VA: 0x1826FBBC0
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x26FB9D0 Offset: 0x26FABD0 VA: 0x1826FB9D0
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	// RVA: 0x26FBD30 Offset: 0x26FAF30 VA: 0x1826FBD30
	public void AddVert(UIVertex v) { }

	// RVA: 0x26FB490 Offset: 0x26FA690 VA: 0x1826FB490
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x26FB600 Offset: 0x26FA800 VA: 0x1826FB600
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x26FB890 Offset: 0x26FAA90 VA: 0x1826FB890
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x26FB950 Offset: 0x26FAB50 VA: 0x1826FB950
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x26FC620 Offset: 0x26FB820 VA: 0x1826FC620
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x26FCD30 Offset: 0x26FBF30 VA: 0x1826FCD30
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Use BaseMeshEffect instead", True)]
public abstract class BaseVertexEffect // TypeDefIndex: 16135
{
	// Methods

	[EditorBrowsable(1)]
	[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", True)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ModifyVertices(List<UIVertex> vertices);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 16136
{
	// Fields
	private Graphic m_Graphic; // 0x20

	// Properties
	protected Graphic graphic { get; }

	// Methods

	// RVA: 0x26E7050 Offset: 0x26E6250 VA: 0x1826E7050
	protected Graphic get_graphic() { }

	// RVA: 0x26E6FB0 Offset: 0x26E61B0 VA: 0x1826E6FB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26E6F10 Offset: 0x26E6110 VA: 0x1826E6F10 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26E6E70 Offset: 0x26E6070 VA: 0x1826E6E70 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x26E6C30 Offset: 0x26E5E30 VA: 0x1826E6C30 Slot: 19
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ModifyMesh(VertexHelper vh);

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Use IMeshModifier instead", True)]
[EditorBrowsable(1)]
public interface IVertexModifier // TypeDefIndex: 16137
{
	// Methods

	[EditorBrowsable(1)]
	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", True)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyVertices(List<UIVertex> verts);
}

// Namespace: UnityEngine.UI
public interface IMeshModifier // TypeDefIndex: 16138
{
	// Methods

	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", False)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyMesh(Mesh mesh);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ModifyMesh(VertexHelper verts);
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Outline", 81)]
public class Outline : Shadow // TypeDefIndex: 16139
{
	// Methods

	// RVA: 0x26E83B0 Offset: 0x26E75B0 VA: 0x1826E83B0
	protected void .ctor() { }

	// RVA: 0x26E8040 Offset: 0x26E7240 VA: 0x1826E8040 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Position As UV1", 82)]
public class PositionAsUV1 : BaseMeshEffect // TypeDefIndex: 16140
{
	// Methods

	// RVA: 0x270A080 Offset: 0x2709280 VA: 0x18270A080
	protected void .ctor() { }

	// RVA: 0x2709F60 Offset: 0x2709160 VA: 0x182709F60 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Shadow", 80)]
public class Shadow : BaseMeshEffect // TypeDefIndex: 16141
{
	// Fields
	[SerializeField]
	private Color m_EffectColor; // 0x28
	[SerializeField]
	private Vector2 m_EffectDistance; // 0x38
	[SerializeField]
	private bool m_UseGraphicAlpha; // 0x40
	private const float kMaxEffectDistance = 600;

	// Properties
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public bool useGraphicAlpha { get; set; }

	// Methods

	// RVA: 0x270AE50 Offset: 0x270A050 VA: 0x18270AE50
	protected void .ctor() { }

	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80
	public Color get_effectColor() { }

	// RVA: 0x270AE80 Offset: 0x270A080 VA: 0x18270AE80
	public void set_effectColor(Color value) { }

	// RVA: 0x26C7C80 Offset: 0x26C6E80 VA: 0x1826C7C80
	public Vector2 get_effectDistance() { }

	// RVA: 0x270AF20 Offset: 0x270A120 VA: 0x18270AF20
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_useGraphicAlpha() { }

	// RVA: 0x270B020 Offset: 0x270A220 VA: 0x18270B020
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x270A980 Offset: 0x2709B80 VA: 0x18270A980
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x270AD00 Offset: 0x2709F00 VA: 0x18270AD00
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x270AD10 Offset: 0x2709F10 VA: 0x18270AD10 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

// Namespace: UnityEngine.UI.Collections
[DefaultMember("Item")]
internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 16142
{
	// Fields
	private readonly List<T> m_List; // 0x0
	private Dictionary<T, int> m_Dictionary; // 0x0
	private int m_EnabledObjectCount; // 0x0

	// Properties
	public int Count { get; }
	public int Capacity { get; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128C130 Offset: 0x128B330 VA: 0x18128C130
	|-IndexedSet<object>.Add
	|
	|-RVA: 0x128C030 Offset: 0x128B230 VA: 0x18128C030
	|-IndexedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(T item, bool isActive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128C150 Offset: 0x128B350 VA: 0x18128C150
	|-IndexedSet<object>.Add
	|
	|-RVA: 0x128BDE0 Offset: 0x128AFE0 VA: 0x18128BDE0
	|-IndexedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool AddUnique(T item, bool isActive = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128BCC0 Offset: 0x128AEC0 VA: 0x18128BCC0
	|-IndexedSet<object>.AddUnique
	|
	|-RVA: 0x128BA80 Offset: 0x128AC80 VA: 0x18128BA80
	|-IndexedSet<__Il2CppFullySharedGenericType>.AddUnique
	*/

	// RVA: -1 Offset: -1
	public bool EnableItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128C810 Offset: 0x128BA10 VA: 0x18128C810
	|-IndexedSet<object>.EnableItem
	|
	|-RVA: 0x128C6C0 Offset: 0x128B8C0 VA: 0x18128C6C0
	|-IndexedSet<__Il2CppFullySharedGenericType>.EnableItem
	*/

	// RVA: -1 Offset: -1
	public bool DisableItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128C4C0 Offset: 0x128B6C0 VA: 0x18128C4C0
	|-IndexedSet<object>.DisableItem
	|
	|-RVA: 0x128C560 Offset: 0x128B760 VA: 0x18128C560
	|-IndexedSet<__Il2CppFullySharedGenericType>.DisableItem
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D290 Offset: 0x128C490 VA: 0x18128D290
	|-IndexedSet<object>.Remove
	|
	|-RVA: 0x128D150 Offset: 0x128C350 VA: 0x18128D150
	|-IndexedSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E1940 Offset: 0x8E0B40 VA: 0x1808E1940
	|-IndexedSet<object>.GetEnumerator
	|-IndexedSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128DBF0 Offset: 0x128CDF0 VA: 0x18128DBF0
	|-IndexedSet<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBCB5D0 Offset: 0xBCA7D0 VA: 0x180BCB5D0
	|-IndexedSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128C2C0 Offset: 0x128B4C0 VA: 0x18128C2C0
	|-IndexedSet<object>.Clear
	|
	|-RVA: 0x128C250 Offset: 0x128B450 VA: 0x18128C250
	|-IndexedSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128C340 Offset: 0x128B540 VA: 0x18128C340
	|-IndexedSet<object>.Contains
	|
	|-RVA: 0x128C370 Offset: 0x128B570 VA: 0x18128C370
	|-IndexedSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128C460 Offset: 0x128B660 VA: 0x18128C460
	|-IndexedSet<object>.CopyTo
	|
	|-RVA: 0x128C490 Offset: 0x128B690 VA: 0x18128C490
	|-IndexedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	|-IndexedSet<object>.get_Count
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	|-IndexedSet<object>.get_Capacity
	|
	|-RVA: 0xE3BAD0 Offset: 0xE3ACD0 VA: 0x180E3BAD0
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-IndexedSet<object>.get_IsReadOnly
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128C9B0 Offset: 0x128BBB0 VA: 0x18128C9B0
	|-IndexedSet<object>.IndexOf
	|
	|-RVA: 0x128C8A0 Offset: 0x128BAA0 VA: 0x18128C8A0
	|-IndexedSet<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CA00 Offset: 0x128BC00 VA: 0x18128CA00
	|-IndexedSet<object>.Insert
	|-IndexedSet<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D000 Offset: 0x128C200 VA: 0x18128D000
	|-IndexedSet<object>.RemoveAt
	|
	|-RVA: 0x128CD70 Offset: 0x128BF70 VA: 0x18128CD70
	|-IndexedSet<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private void Swap(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D600 Offset: 0x128C800 VA: 0x18128D600
	|-IndexedSet<object>.Swap
	|
	|-RVA: 0x128D740 Offset: 0x128C940 VA: 0x18128D740
	|-IndexedSet<__Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128DEC0 Offset: 0x128D0C0 VA: 0x18128DEC0
	|-IndexedSet<object>.get_Item
	|
	|-RVA: 0x128DDB0 Offset: 0x128CFB0 VA: 0x18128DDB0
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128DF30 Offset: 0x128D130 VA: 0x18128DF30
	|-IndexedSet<object>.set_Item
	|
	|-RVA: 0x128E000 Offset: 0x128D200 VA: 0x18128E000
	|-IndexedSet<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CA50 Offset: 0x128BC50 VA: 0x18128CA50
	|-IndexedSet<object>.RemoveAll
	|
	|-RVA: 0x128CB20 Offset: 0x128BD20 VA: 0x18128CB20
	|-IndexedSet<__Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> sortLayoutFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D540 Offset: 0x128C740 VA: 0x18128D540
	|-IndexedSet<object>.Sort
	|
	|-RVA: 0x128D310 Offset: 0x128C510 VA: 0x18128D310
	|-IndexedSet<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128DCF0 Offset: 0x128CEF0 VA: 0x18128DCF0
	|-IndexedSet<object>..ctor
	|
	|-RVA: 0x128DC20 Offset: 0x128CE20 VA: 0x18128DC20
	|-IndexedSet<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.UI.CoroutineTween
internal interface ITweenValue // TypeDefIndex: 16143
{
	// Properties
	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TweenValue(float floatPercentage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_ignoreTimeScale();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_duration();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ValidTarget();
}

// Namespace: 
public enum ColorTween.ColorTweenMode // TypeDefIndex: 16144
{
	// Fields
	public int value__; // 0x0
	public const ColorTween.ColorTweenMode All = 0;
	public const ColorTween.ColorTweenMode RGB = 1;
	public const ColorTween.ColorTweenMode Alpha = 2;
}

// Namespace: 
public class ColorTween.ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 16145
{
	// Methods

	// RVA: 0x26FEC00 Offset: 0x26FDE00 VA: 0x1826FEC00
	public void .ctor() { }
}

// Namespace: UnityEngine.UI.CoroutineTween
internal struct ColorTween : ITweenValue // TypeDefIndex: 16146
{
	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public Color get_startColor() { }

	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_startColor(Color value) { }

	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public Color get_targetColor() { }

	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_targetColor(Color value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x6F31E0 Offset: 0x6F23E0 VA: 0x1806F31E0 Slot: 6
	public float get_duration() { }

	// RVA: 0x498F90 Offset: 0x498190 VA: 0x180498F90
	public void set_duration(float value) { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x26FECF0 Offset: 0x26FDEF0 VA: 0x1826FECF0 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x26FEC40 Offset: 0x26FDE40 VA: 0x1826FEC40
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool GetIgnoreTimescale() { }

	// RVA: 0x6F31E0 Offset: 0x6F23E0 VA: 0x1806F31E0
	public float GetDuration() { }

	// RVA: 0x180B7A0 Offset: 0x180A9A0 VA: 0x18180B7A0 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: 
public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 16147
{
	// Methods

	// RVA: 0x2702AD0 Offset: 0x2701CD0 VA: 0x182702AD0
	public void .ctor() { }
}

// Namespace: UnityEngine.UI.CoroutineTween
internal struct FloatTween : ITweenValue // TypeDefIndex: 16148
{
	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x439FC0 Offset: 0x4391C0 VA: 0x180439FC0
	public float get_startValue() { }

	// RVA: 0x439FF0 Offset: 0x4391F0 VA: 0x180439FF0
	public void set_startValue(float value) { }

	// RVA: 0x52C5A0 Offset: 0x52B7A0 VA: 0x18052C5A0
	public float get_targetValue() { }

	// RVA: 0x52C5B0 Offset: 0x52B7B0 VA: 0x18052C5B0
	public void set_targetValue(float value) { }

	// RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0 Slot: 6
	public float get_duration() { }

	// RVA: 0x482DD0 Offset: 0x481FD0 VA: 0x180482DD0
	public void set_duration(float value) { }

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x41AC60 Offset: 0x419E60 VA: 0x18041AC60
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x2702BC0 Offset: 0x2701DC0 VA: 0x182702BC0 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x2702B10 Offset: 0x2701D10 VA: 0x182702B10
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	public bool GetIgnoreTimescale() { }

	// RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	public float GetDuration() { }

	// RVA: 0x180B7A0 Offset: 0x180A9A0 VA: 0x18180B7A0 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TweenRunner.<Start>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 16149
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public T tweenInfo; // 0x0
	private float <elapsedTime>5__2; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	|-TweenRunner.<Start>d__2<ColorTween>..ctor
	|-TweenRunner.<Start>d__2<FloatTween>..ctor
	|
	|-RVA: 0xB1E9D0 Offset: 0xB1DBD0 VA: 0x180B1E9D0
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-TweenRunner.<Start>d__2<ColorTween>.System.IDisposable.Dispose
	|-TweenRunner.<Start>d__2<FloatTween>.System.IDisposable.Dispose
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4E660 Offset: 0xF4D860 VA: 0x180F4E660
	|-TweenRunner.<Start>d__2<ColorTween>.MoveNext
	|
	|-RVA: 0xF4E780 Offset: 0xF4D980 VA: 0x180F4E780
	|-TweenRunner.<Start>d__2<FloatTween>.MoveNext
	|
	|-RVA: 0xF4DE60 Offset: 0xF4D060 VA: 0x180F4DE60
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-TweenRunner.<Start>d__2<ColorTween>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|
	|-RVA: 0xBE5090 Offset: 0xBE4290 VA: 0x180BE5090
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-TweenRunner.<Start>d__2<ColorTween>.System.Collections.IEnumerator.Reset
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.IEnumerator.Reset
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-TweenRunner.<Start>d__2<ColorTween>.System.Collections.IEnumerator.get_Current
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xBE5090 Offset: 0xBE4290 VA: 0x180BE5090
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: UnityEngine.UI.CoroutineTween
internal class TweenRunner<T> // TypeDefIndex: 16150
{
	// Fields
	protected MonoBehaviour m_CoroutineContainer; // 0x0
	protected IEnumerator m_Tween; // 0x0

	// Methods

	[IteratorStateMachine(typeof(TweenRunner.<Start>d__2<T>))]
	// RVA: -1 Offset: -1
	private static IEnumerator Start(T tweenInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCCE7D0 Offset: 0xCCD9D0 VA: 0x180CCE7D0
	|-TweenRunner<ColorTween>.Start
	|
	|-RVA: 0xCCE5B0 Offset: 0xCCD7B0 VA: 0x180CCE5B0
	|-TweenRunner<FloatTween>.Start
	|
	|-RVA: 0xCCE660 Offset: 0xCCD860 VA: 0x180CCE660
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Start
	*/

	// RVA: -1 Offset: -1
	public void Init(MonoBehaviour coroutineContainer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	|-TweenRunner<ColorTween>.Init
	|-TweenRunner<FloatTween>.Init
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Init
	*/

	// RVA: -1 Offset: -1
	public void StartTween(T info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCCDB30 Offset: 0xCCCD30 VA: 0x180CCDB30
	|-TweenRunner<ColorTween>.StartTween
	|
	|-RVA: 0xCCDF90 Offset: 0xCCD190 VA: 0x180CCDF90
	|-TweenRunner<FloatTween>.StartTween
	|
	|-RVA: 0xCCDD50 Offset: 0xCCCF50 VA: 0x180CCDD50
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StartTween
	*/

	// RVA: -1 Offset: -1
	public void StopTween() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCCE890 Offset: 0xCCDA90 VA: 0x180CCE890
	|-TweenRunner<ColorTween>.StopTween
	|-TweenRunner<FloatTween>.StopTween
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StopTween
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-TweenRunner<ColorTween>..ctor
	|-TweenRunner<FloatTween>..ctor
	|-TweenRunner<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: 
private enum PanelEventHandler.PointerEventType // TypeDefIndex: 16151
{
	// Fields
	public int value__; // 0x0
	public const PanelEventHandler.PointerEventType Default = 0;
	public const PanelEventHandler.PointerEventType Down = 1;
	public const PanelEventHandler.PointerEventType Up = 2;
}

// Namespace: 
private class PanelEventHandler.PointerEvent : IPointerEvent // TypeDefIndex: 16152
{
	// Fields
	[CompilerGenerated]
	private int <pointerId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <pointerType>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <isPrimary>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <button>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <pressedButtons>k__BackingField; // 0x28
	[CompilerGenerated]
	private Vector3 <position>k__BackingField; // 0x2C
	[CompilerGenerated]
	private Vector3 <localPosition>k__BackingField; // 0x38
	[CompilerGenerated]
	private Vector3 <deltaPosition>k__BackingField; // 0x44
	[CompilerGenerated]
	private float <deltaTime>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <clickCount>k__BackingField; // 0x54
	[CompilerGenerated]
	private float <pressure>k__BackingField; // 0x58
	[CompilerGenerated]
	private float <tangentialPressure>k__BackingField; // 0x5C
	[CompilerGenerated]
	private float <altitudeAngle>k__BackingField; // 0x60
	[CompilerGenerated]
	private float <azimuthAngle>k__BackingField; // 0x64
	[CompilerGenerated]
	private float <twist>k__BackingField; // 0x68
	[CompilerGenerated]
	private Vector2 <tilt>k__BackingField; // 0x6C
	[CompilerGenerated]
	private PenStatus <penStatus>k__BackingField; // 0x74
	[CompilerGenerated]
	private Vector2 <radius>k__BackingField; // 0x78
	[CompilerGenerated]
	private Vector2 <radiusVariance>k__BackingField; // 0x80
	[CompilerGenerated]
	private EventModifiers <modifiers>k__BackingField; // 0x88

	// Properties
	public int pointerId { get; set; }
	public string pointerType { get; set; }
	public bool isPrimary { get; set; }
	public int button { get; set; }
	public int pressedButtons { get; set; }
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 deltaPosition { get; set; }
	public float deltaTime { get; set; }
	public int clickCount { get; set; }
	public float pressure { get; set; }
	public float tangentialPressure { get; set; }
	public float altitudeAngle { get; set; }
	public float azimuthAngle { get; set; }
	public float twist { get; set; }
	public Vector2 tilt { get; set; }
	public PenStatus penStatus { get; set; }
	public Vector2 radius { get; set; }
	public Vector2 radiusVariance { get; set; }
	public EventModifiers modifiers { get; set; }
	public bool shiftKey { get; }
	public bool ctrlKey { get; }
	public bool commandKey { get; }
	public bool altKey { get; }
	public bool actionKey { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 4
	public int get_pointerId() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	private void set_pointerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public string get_pointerType() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_pointerType(string value) { }

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0 Slot: 6
	public bool get_isPrimary() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	private void set_isPrimary(bool value) { }

	[CompilerGenerated]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90 Slot: 7
	public int get_button() { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	private void set_button(int value) { }

	[CompilerGenerated]
	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050 Slot: 8
	public int get_pressedButtons() { }

	[CompilerGenerated]
	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	private void set_pressedButtons(int value) { }

	[CompilerGenerated]
	// RVA: 0x237C740 Offset: 0x237B940 VA: 0x18237C740 Slot: 9
	public Vector3 get_position() { }

	[CompilerGenerated]
	// RVA: 0x27086A0 Offset: 0x27078A0 VA: 0x1827086A0
	private void set_position(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x2708610 Offset: 0x2707810 VA: 0x182708610 Slot: 10
	public Vector3 get_localPosition() { }

	[CompilerGenerated]
	// RVA: 0x2708690 Offset: 0x2707890 VA: 0x182708690
	private void set_localPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x27085F0 Offset: 0x27077F0 VA: 0x1827085F0 Slot: 11
	public Vector3 get_deltaPosition() { }

	[CompilerGenerated]
	// RVA: 0x2708680 Offset: 0x2707880 VA: 0x182708680
	private void set_deltaPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x646040 Offset: 0x645240 VA: 0x180646040 Slot: 12
	public float get_deltaTime() { }

	[CompilerGenerated]
	// RVA: 0x646080 Offset: 0x645280 VA: 0x180646080
	private void set_deltaTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40 Slot: 13
	public int get_clickCount() { }

	[CompilerGenerated]
	// RVA: 0x4D1A80 Offset: 0x4D0C80 VA: 0x1804D1A80
	private void set_clickCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1529A10 Offset: 0x1528C10 VA: 0x181529A10 Slot: 14
	public float get_pressure() { }

	[CompilerGenerated]
	// RVA: 0x2507590 Offset: 0x2506790 VA: 0x182507590
	private void set_pressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x1A94260 Offset: 0x1A93460 VA: 0x181A94260 Slot: 15
	public float get_tangentialPressure() { }

	[CompilerGenerated]
	// RVA: 0x25075B0 Offset: 0x25067B0 VA: 0x1825075B0
	private void set_tangentialPressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x6D7F60 Offset: 0x6D7160 VA: 0x1806D7F60 Slot: 16
	public float get_altitudeAngle() { }

	[CompilerGenerated]
	// RVA: 0x56E660 Offset: 0x56D860 VA: 0x18056E660
	private void set_altitudeAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x526CB0 Offset: 0x525EB0 VA: 0x180526CB0 Slot: 17
	public float get_azimuthAngle() { }

	[CompilerGenerated]
	// RVA: 0x526DB0 Offset: 0x525FB0 VA: 0x180526DB0
	private void set_azimuthAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x526CE0 Offset: 0x525EE0 VA: 0x180526CE0 Slot: 18
	public float get_twist() { }

	[CompilerGenerated]
	// RVA: 0x526DE0 Offset: 0x525FE0 VA: 0x180526DE0
	private void set_twist(float value) { }

	[CompilerGenerated]
	// RVA: 0x2708660 Offset: 0x2707860 VA: 0x182708660 Slot: 19
	public Vector2 get_tilt() { }

	[CompilerGenerated]
	// RVA: 0x1C13510 Offset: 0x1C12710 VA: 0x181C13510
	private void set_tilt(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90 Slot: 20
	public PenStatus get_penStatus() { }

	[CompilerGenerated]
	// RVA: 0x526D90 Offset: 0x525F90 VA: 0x180526D90
	private void set_penStatus(PenStatus value) { }

	[CompilerGenerated]
	// RVA: 0x2648AE0 Offset: 0x2647CE0 VA: 0x182648AE0 Slot: 21
	public Vector2 get_radius() { }

	[CompilerGenerated]
	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	private void set_radius(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2708630 Offset: 0x2707830 VA: 0x182708630 Slot: 22
	public Vector2 get_radiusVariance() { }

	[CompilerGenerated]
	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	private void set_radiusVariance(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950 Slot: 23
	public EventModifiers get_modifiers() { }

	[CompilerGenerated]
	// RVA: 0x73BA10 Offset: 0x73AC10 VA: 0x18073BA10
	private void set_modifiers(EventModifiers value) { }

	// RVA: 0x2708650 Offset: 0x2707850 VA: 0x182708650 Slot: 24
	public bool get_shiftKey() { }

	// RVA: 0x27085E0 Offset: 0x27077E0 VA: 0x1827085E0 Slot: 25
	public bool get_ctrlKey() { }

	// RVA: 0x27085D0 Offset: 0x27077D0 VA: 0x1827085D0 Slot: 26
	public bool get_commandKey() { }

	// RVA: 0x27085C0 Offset: 0x27077C0 VA: 0x1827085C0 Slot: 27
	public bool get_altKey() { }

	// RVA: 0x2708530 Offset: 0x2707730 VA: 0x182708530 Slot: 28
	public bool get_actionKey() { }

	// RVA: 0x2707F30 Offset: 0x2707130 VA: 0x182707F30
	public void Read(PanelEventHandler self, PointerEventData eventData, PanelEventHandler.PointerEventType eventType) { }

	// RVA: 0x27084E0 Offset: 0x27076E0 VA: 0x1827084E0
	public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2708510 Offset: 0x2707710 VA: 0x182708510
	internal static bool <Read>g__InRange|90_0(int i, int start, int count) { }
}

// Namespace: UnityEngine.UIElements
[AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent, IPointerClickHandler // TypeDefIndex: 16153
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x20
	private readonly PanelEventHandler.PointerEvent m_PointerEvent; // 0x28
	private float m_LastClickTime; // 0x30
	private bool m_Selecting; // 0x34
	private Event m_Event; // 0x38
	private static EventModifiers s_Modifiers; // 0x0

	// Properties
	public IPanel panel { get; set; }
	private GameObject selectableGameObject { get; }
	private EventSystem eventSystem { get; }
	private bool isCurrentFocusedPanel { get; }
	private Focusable currentFocusedElement { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 30
	public IPanel get_panel() { }

	// RVA: 0x2705280 Offset: 0x2704480 VA: 0x182705280 Slot: 28
	public void set_panel(IPanel value) { }

	// RVA: 0x2705260 Offset: 0x2704460 VA: 0x182705260
	private GameObject get_selectableGameObject() { }

	// RVA: 0x27050C0 Offset: 0x27042C0 VA: 0x1827050C0
	private EventSystem get_eventSystem() { }

	// RVA: 0x2705190 Offset: 0x2704390 VA: 0x182705190
	private bool get_isCurrentFocusedPanel() { }

	// RVA: 0x2705080 Offset: 0x2704280 VA: 0x182705080
	private Focusable get_currentFocusedElement() { }

	// RVA: 0x27032D0 Offset: 0x27024D0 VA: 0x1827032D0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2703210 Offset: 0x2702410 VA: 0x182703210 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2704690 Offset: 0x2703890 VA: 0x182704690
	private void RegisterCallbacks() { }

	// RVA: 0x2704D00 Offset: 0x2703F00 VA: 0x182704D00
	private void UnregisterCallbacks() { }

	// RVA: 0x27034F0 Offset: 0x27026F0 VA: 0x1827034F0
	private void OnPanelDestroyed() { }

	// RVA: 0x2703220 Offset: 0x2702420 VA: 0x182703220
	private void OnElementFocus(FocusEvent e) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void OnElementBlur(BlurEvent e) { }

	// RVA: 0x2703FF0 Offset: 0x27031F0 VA: 0x182703FF0 Slot: 24
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x27031F0 Offset: 0x27023F0 VA: 0x1827031F0 Slot: 25
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2703B00 Offset: 0x2702D00 VA: 0x182703B00 Slot: 17
	public void OnPointerMove(PointerEventData eventData) { }

	// RVA: 0x2703C50 Offset: 0x2702E50 VA: 0x182703C50 Slot: 18
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2703570 Offset: 0x2702770 VA: 0x182703570 Slot: 19
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2703800 Offset: 0x2702A00 VA: 0x182703800 Slot: 26
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2703790 Offset: 0x2702990 VA: 0x182703790 Slot: 27
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x2703550 Offset: 0x2702750 VA: 0x182703550 Slot: 29
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2704060 Offset: 0x2703260 VA: 0x182704060 Slot: 20
	public void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2703020 Offset: 0x2702220 VA: 0x182703020 Slot: 21
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x27032E0 Offset: 0x27024E0 VA: 0x1827032E0 Slot: 22
	public void OnMove(AxisEventData eventData) { }

	// RVA: 0x2703E10 Offset: 0x2703010 VA: 0x182703E10 Slot: 23
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x2704840 Offset: 0x2703A40 VA: 0x182704840
	private void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	// RVA: 0x27048B0 Offset: 0x2703AB0 VA: 0x1827048B0
	private void SendEvent(EventBase e, Event sourceEvent) { }

	// RVA: 0x2704EB0 Offset: 0x27040B0 VA: 0x182704EB0
	internal void Update() { }

	// RVA: 0x2703010 Offset: 0x2702210 VA: 0x182703010
	private void LateUpdate() { }

	// RVA: 0x2704230 Offset: 0x2703430 VA: 0x182704230
	private void ProcessImguiEvents(Focusable target) { }

	// RVA: 0x27043E0 Offset: 0x27035E0 VA: 0x1827043E0
	private void ProcessKeyboardEvent(Event e, Focusable target) { }

	// RVA: 0x2704470 Offset: 0x2703670 VA: 0x182704470
	private void ProcessTabEvent(Event e, Focusable target) { }

	// RVA: 0x2704BC0 Offset: 0x2703DC0 VA: 0x182704BC0
	private void SendTabEvent(Event e, NavigationMoveEvent.Direction direction, Focusable target) { }

	// RVA: 0x2704A50 Offset: 0x2703C50 VA: 0x182704A50
	private void SendKeyUpEvent(Event e, Focusable target) { }

	// RVA: 0x27048E0 Offset: 0x2703AE0 VA: 0x1827048E0
	private void SendKeyDownEvent(Event e, Focusable target) { }

	// RVA: 0x27044E0 Offset: 0x27036E0 VA: 0x1827044E0
	private bool ReadPointerData(PanelEventHandler.PointerEvent pe, PointerEventData eventData, PanelEventHandler.PointerEventType eventType = 0) { }

	// RVA: 0x2704FF0 Offset: 0x27041F0 VA: 0x182704FF0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent // TypeDefIndex: 16154
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x28

	// Properties
	public IPanel panel { get; set; }
	private GameObject selectableGameObject { get; }
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 23
	public IPanel get_panel() { }

	// RVA: 0x2705BC0 Offset: 0x2704DC0 VA: 0x182705BC0 Slot: 22
	public void set_panel(IPanel value) { }

	// RVA: 0x2705990 Offset: 0x2704B90 VA: 0x182705990
	private void RegisterCallbacks() { }

	// RVA: 0x2705A20 Offset: 0x2704C20 VA: 0x182705A20
	private void UnregisterCallbacks() { }

	// RVA: 0x2705330 Offset: 0x2704530 VA: 0x182705330
	private void OnPanelDestroyed() { }

	// RVA: 0x2705B30 Offset: 0x2704D30 VA: 0x182705B30
	private GameObject get_selectableGameObject() { }

	// RVA: 0x2705B50 Offset: 0x2704D50 VA: 0x182705B50 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x2705AB0 Offset: 0x2704CB0 VA: 0x182705AB0 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0x2705450 Offset: 0x2704650 VA: 0x182705450 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
public class AxisEventData : BaseEventData // TypeDefIndex: 16155
{
	// Fields
	[CompilerGenerated]
	private Vector2 <moveVector>k__BackingField; // 0x20
	[CompilerGenerated]
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Properties
	public Vector2 moveVector { get; set; }
	public MoveDirection moveDir { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5A6760 Offset: 0x5A5960 VA: 0x1805A6760
	public Vector2 get_moveVector() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_moveVector(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public MoveDirection get_moveDir() { }

	[CompilerGenerated]
	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x26FD140 Offset: 0x26FC340 VA: 0x1826FD140
	public void .ctor(EventSystem eventSystem) { }
}

// Namespace: UnityEngine.EventSystems
public abstract class AbstractEventData // TypeDefIndex: 16156
{
	// Fields
	protected bool m_Used; // 0x10

	// Properties
	public virtual bool used { get; }

	// Methods

	// RVA: 0x798650 Offset: 0x797850 VA: 0x180798650 Slot: 4
	public virtual void Reset() { }

	// RVA: 0x21A55F0 Offset: 0x21A47F0 VA: 0x1821A55F0 Slot: 5
	public virtual void Use() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 6
	public virtual bool get_used() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
public class BaseEventData : AbstractEventData // TypeDefIndex: 16157
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Properties
	public BaseInputModule currentInputModule { get; }
	public GameObject selectedObject { get; set; }

	// Methods

	// RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x8860F0 Offset: 0x8852F0 VA: 0x1808860F0
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x18A59F0 Offset: 0x18A4BF0 VA: 0x1818A59F0
	public GameObject get_selectedObject() { }

	// RVA: 0x26FD1B0 Offset: 0x26FC3B0 VA: 0x1826FD1B0
	public void set_selectedObject(GameObject value) { }
}

// Namespace: 
public enum PointerEventData.InputButton // TypeDefIndex: 16158
{
	// Fields
	public int value__; // 0x0
	public const PointerEventData.InputButton Left = 0;
	public const PointerEventData.InputButton Right = 1;
	public const PointerEventData.InputButton Middle = 2;
}

// Namespace: 
public enum PointerEventData.FramePressState // TypeDefIndex: 16159
{
	// Fields
	public int value__; // 0x0
	public const PointerEventData.FramePressState Pressed = 0;
	public const PointerEventData.FramePressState Released = 1;
	public const PointerEventData.FramePressState PressedAndReleased = 2;
	public const PointerEventData.FramePressState NotChanged = 3;
}

// Namespace: UnityEngine.EventSystems
public class PointerEventData : BaseEventData // TypeDefIndex: 16160
{
	// Fields
	[CompilerGenerated]
	private GameObject <pointerEnter>k__BackingField; // 0x20
	private GameObject m_PointerPress; // 0x28
	[CompilerGenerated]
	private GameObject <lastPress>k__BackingField; // 0x30
	[CompilerGenerated]
	private GameObject <rawPointerPress>k__BackingField; // 0x38
	[CompilerGenerated]
	private GameObject <pointerDrag>k__BackingField; // 0x40
	[CompilerGenerated]
	private GameObject <pointerClick>k__BackingField; // 0x48
	[CompilerGenerated]
	private RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x50
	[CompilerGenerated]
	private RaycastResult <pointerPressRaycast>k__BackingField; // 0xA0
	public List<GameObject> hovered; // 0xF0
	[CompilerGenerated]
	private bool <eligibleForClick>k__BackingField; // 0xF8
	[CompilerGenerated]
	private int <displayIndex>k__BackingField; // 0xFC
	[CompilerGenerated]
	private int <pointerId>k__BackingField; // 0x100
	[CompilerGenerated]
	private Vector2 <position>k__BackingField; // 0x104
	[CompilerGenerated]
	private Vector2 <delta>k__BackingField; // 0x10C
	[CompilerGenerated]
	private Vector2 <pressPosition>k__BackingField; // 0x114
	[CompilerGenerated]
	private Vector3 <worldPosition>k__BackingField; // 0x11C
	[CompilerGenerated]
	private Vector3 <worldNormal>k__BackingField; // 0x128
	[CompilerGenerated]
	private float <clickTime>k__BackingField; // 0x134
	[CompilerGenerated]
	private int <clickCount>k__BackingField; // 0x138
	[CompilerGenerated]
	private Vector2 <scrollDelta>k__BackingField; // 0x13C
	[CompilerGenerated]
	private bool <useDragThreshold>k__BackingField; // 0x144
	[CompilerGenerated]
	private bool <dragging>k__BackingField; // 0x145
	[CompilerGenerated]
	private PointerEventData.InputButton <button>k__BackingField; // 0x148
	[CompilerGenerated]
	private float <pressure>k__BackingField; // 0x14C
	[CompilerGenerated]
	private float <tangentialPressure>k__BackingField; // 0x150
	[CompilerGenerated]
	private float <altitudeAngle>k__BackingField; // 0x154
	[CompilerGenerated]
	private float <azimuthAngle>k__BackingField; // 0x158
	[CompilerGenerated]
	private float <twist>k__BackingField; // 0x15C
	[CompilerGenerated]
	private Vector2 <tilt>k__BackingField; // 0x160
	[CompilerGenerated]
	private PenStatus <penStatus>k__BackingField; // 0x168
	[CompilerGenerated]
	private Vector2 <radius>k__BackingField; // 0x16C
	[CompilerGenerated]
	private Vector2 <radiusVariance>k__BackingField; // 0x174
	[CompilerGenerated]
	private bool <fullyExited>k__BackingField; // 0x17C
	[CompilerGenerated]
	private bool <reentered>k__BackingField; // 0x17D

	// Properties
	public GameObject pointerEnter { get; set; }
	public GameObject lastPress { get; set; }
	public GameObject rawPointerPress { get; set; }
	public GameObject pointerDrag { get; set; }
	public GameObject pointerClick { get; set; }
	public RaycastResult pointerCurrentRaycast { get; set; }
	public RaycastResult pointerPressRaycast { get; set; }
	public bool eligibleForClick { get; set; }
	public int displayIndex { get; set; }
	public int pointerId { get; set; }
	public Vector2 position { get; set; }
	public Vector2 delta { get; set; }
	public Vector2 pressPosition { get; set; }
	[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
	public Vector3 worldPosition { get; set; }
	[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
	public Vector3 worldNormal { get; set; }
	public float clickTime { get; set; }
	public int clickCount { get; set; }
	public Vector2 scrollDelta { get; set; }
	public bool useDragThreshold { get; set; }
	public bool dragging { get; set; }
	public PointerEventData.InputButton button { get; set; }
	public float pressure { get; set; }
	public float tangentialPressure { get; set; }
	public float altitudeAngle { get; set; }
	public float azimuthAngle { get; set; }
	public float twist { get; set; }
	public Vector2 tilt { get; set; }
	public PenStatus penStatus { get; set; }
	public Vector2 radius { get; set; }
	public Vector2 radiusVariance { get; set; }
	public bool fullyExited { get; set; }
	public bool reentered { get; set; }
	public Camera enterEventCamera { get; }
	public Camera pressEventCamera { get; }
	public GameObject pointerPress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public GameObject get_pointerEnter() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_pointerEnter(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public GameObject get_lastPress() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_lastPress(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public GameObject get_rawPointerPress() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public GameObject get_pointerDrag() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_pointerDrag(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public GameObject get_pointerClick() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_pointerClick(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x2707A40 Offset: 0x2706C40 VA: 0x182707A40
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGenerated]
	// RVA: 0x2707D50 Offset: 0x2706F50 VA: 0x182707D50
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGenerated]
	// RVA: 0x2707A90 Offset: 0x2706C90 VA: 0x182707A90
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGenerated]
	// RVA: 0x2707D90 Offset: 0x2706F90 VA: 0x182707D90
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGenerated]
	// RVA: 0x24136D0 Offset: 0x24128D0 VA: 0x1824136D0
	public bool get_eligibleForClick() { }

	[CompilerGenerated]
	// RVA: 0x2707D20 Offset: 0x2706F20 VA: 0x182707D20
	public void set_eligibleForClick(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2707980 Offset: 0x2706B80 VA: 0x182707980
	public int get_displayIndex() { }

	[CompilerGenerated]
	// RVA: 0x2707D00 Offset: 0x2706F00 VA: 0x182707D00
	public void set_displayIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x2707A80 Offset: 0x2706C80 VA: 0x182707A80
	public int get_pointerId() { }

	[CompilerGenerated]
	// RVA: 0x2707D80 Offset: 0x2706F80 VA: 0x182707D80
	public void set_pointerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2707AD0 Offset: 0x2706CD0 VA: 0x182707AD0
	public Vector2 get_position() { }

	[CompilerGenerated]
	// RVA: 0x2707E50 Offset: 0x2707050 VA: 0x182707E50
	public void set_position(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2707960 Offset: 0x2706B60 VA: 0x182707960
	public Vector2 get_delta() { }

	[CompilerGenerated]
	// RVA: 0x2707CF0 Offset: 0x2706EF0 VA: 0x182707CF0
	public void set_delta(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2707B90 Offset: 0x2706D90 VA: 0x182707B90
	public Vector2 get_pressPosition() { }

	[CompilerGenerated]
	// RVA: 0x2707E60 Offset: 0x2707060 VA: 0x182707E60
	public void set_pressPosition(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2707C90 Offset: 0x2706E90 VA: 0x182707C90
	public Vector3 get_worldPosition() { }

	[CompilerGenerated]
	// RVA: 0x2707F10 Offset: 0x2707110 VA: 0x182707F10
	public void set_worldPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x2707C70 Offset: 0x2706E70 VA: 0x182707C70
	public Vector3 get_worldNormal() { }

	[CompilerGenerated]
	// RVA: 0x2707EF0 Offset: 0x27070F0 VA: 0x182707EF0
	public void set_worldNormal(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x2707950 Offset: 0x2706B50 VA: 0x182707950
	public float get_clickTime() { }

	[CompilerGenerated]
	// RVA: 0x2707CE0 Offset: 0x2706EE0 VA: 0x182707CE0
	public void set_clickTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x19A2DD0 Offset: 0x19A1FD0 VA: 0x1819A2DD0
	public int get_clickCount() { }

	[CompilerGenerated]
	// RVA: 0x2707CD0 Offset: 0x2706ED0 VA: 0x182707CD0
	public void set_clickCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x2707C10 Offset: 0x2706E10 VA: 0x182707C10
	public Vector2 get_scrollDelta() { }

	[CompilerGenerated]
	// RVA: 0x2707EB0 Offset: 0x27070B0 VA: 0x182707EB0
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2707C60 Offset: 0x2706E60 VA: 0x182707C60
	public bool get_useDragThreshold() { }

	[CompilerGenerated]
	// RVA: 0x2707EE0 Offset: 0x27070E0 VA: 0x182707EE0
	public void set_useDragThreshold(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2707990 Offset: 0x2706B90 VA: 0x182707990
	public bool get_dragging() { }

	[CompilerGenerated]
	// RVA: 0x2707D10 Offset: 0x2706F10 VA: 0x182707D10
	public void set_dragging(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C612E0 Offset: 0x1C604E0 VA: 0x181C612E0
	public PointerEventData.InputButton get_button() { }

	[CompilerGenerated]
	// RVA: 0x1C61DE0 Offset: 0x1C60FE0 VA: 0x181C61DE0
	public void set_button(PointerEventData.InputButton value) { }

	[CompilerGenerated]
	// RVA: 0x2707BB0 Offset: 0x2706DB0 VA: 0x182707BB0
	public float get_pressure() { }

	[CompilerGenerated]
	// RVA: 0x2707E70 Offset: 0x2707070 VA: 0x182707E70
	public void set_pressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x2707C30 Offset: 0x2706E30 VA: 0x182707C30
	public float get_tangentialPressure() { }

	[CompilerGenerated]
	// RVA: 0x2707EC0 Offset: 0x27070C0 VA: 0x182707EC0
	public void set_tangentialPressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x19AD0C0 Offset: 0x19AC2C0 VA: 0x1819AD0C0
	public float get_altitudeAngle() { }

	[CompilerGenerated]
	// RVA: 0x2707CB0 Offset: 0x2706EB0 VA: 0x182707CB0
	public void set_altitudeAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x19AD220 Offset: 0x19AC420 VA: 0x1819AD220
	public float get_azimuthAngle() { }

	[CompilerGenerated]
	// RVA: 0x2707CC0 Offset: 0x2706EC0 VA: 0x182707CC0
	public void set_azimuthAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x24132D0 Offset: 0x24124D0 VA: 0x1824132D0
	public float get_twist() { }

	[CompilerGenerated]
	// RVA: 0x2707ED0 Offset: 0x27070D0 VA: 0x182707ED0
	public void set_twist(float value) { }

	[CompilerGenerated]
	// RVA: 0x2707C40 Offset: 0x2706E40 VA: 0x182707C40
	public Vector2 get_tilt() { }

	[CompilerGenerated]
	// RVA: 0x25149B0 Offset: 0x2513BB0 VA: 0x1825149B0
	public void set_tilt(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x19AD180 Offset: 0x19AC380 VA: 0x1819AD180
	public PenStatus get_penStatus() { }

	[CompilerGenerated]
	// RVA: 0x2707D40 Offset: 0x2706F40 VA: 0x182707D40
	public void set_penStatus(PenStatus value) { }

	[CompilerGenerated]
	// RVA: 0x2707BE0 Offset: 0x2706DE0 VA: 0x182707BE0
	public Vector2 get_radius() { }

	[CompilerGenerated]
	// RVA: 0x2707E90 Offset: 0x2707090 VA: 0x182707E90
	public void set_radius(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2707BC0 Offset: 0x2706DC0 VA: 0x182707BC0
	public Vector2 get_radiusVariance() { }

	[CompilerGenerated]
	// RVA: 0x2707E80 Offset: 0x2707080 VA: 0x182707E80
	public void set_radiusVariance(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x19BD400 Offset: 0x19BC600 VA: 0x1819BD400
	public bool get_fullyExited() { }

	[CompilerGenerated]
	// RVA: 0x2707D30 Offset: 0x2706F30 VA: 0x182707D30
	public void set_fullyExited(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2707C00 Offset: 0x2706E00 VA: 0x182707C00
	public bool get_reentered() { }

	[CompilerGenerated]
	// RVA: 0x2707EA0 Offset: 0x27070A0 VA: 0x182707EA0
	public void set_reentered(bool value) { }

	// RVA: 0x27076F0 Offset: 0x27068F0 VA: 0x1827076F0
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x2706FC0 Offset: 0x27061C0 VA: 0x182706FC0
	public bool IsPointerMoving() { }

	// RVA: 0x2706FF0 Offset: 0x27061F0 VA: 0x182706FF0
	public bool IsScrolling() { }

	// RVA: 0x27079A0 Offset: 0x2706BA0 VA: 0x1827079A0
	public Camera get_enterEventCamera() { }

	// RVA: 0x2707AF0 Offset: 0x2706CF0 VA: 0x182707AF0
	public Camera get_pressEventCamera() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public GameObject get_pointerPress() { }

	// RVA: 0x2707DD0 Offset: 0x2706FD0 VA: 0x182707DD0
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x2707020 Offset: 0x2706220 VA: 0x182707020 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
[Flags]
public enum EventHandle // TypeDefIndex: 16161
{
	// Fields
	public int value__; // 0x0
	public const EventHandle Unused = 0;
	public const EventHandle Used = 1;
}

// Namespace: UnityEngine.EventSystems
public interface IEventSystemHandler // TypeDefIndex: 16162
{}

// Namespace: UnityEngine.EventSystems
public interface IPointerMoveHandler : IEventSystemHandler // TypeDefIndex: 16163
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerMove(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 16164
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerEnter(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerExitHandler : IEventSystemHandler // TypeDefIndex: 16165
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerExit(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerDownHandler : IEventSystemHandler // TypeDefIndex: 16166
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerDown(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerUpHandler : IEventSystemHandler // TypeDefIndex: 16167
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerUp(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerClickHandler : IEventSystemHandler // TypeDefIndex: 16168
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerClick(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IBeginDragHandler : IEventSystemHandler // TypeDefIndex: 16169
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeginDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IInitializePotentialDragHandler : IEventSystemHandler // TypeDefIndex: 16170
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInitializePotentialDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDragHandler : IEventSystemHandler // TypeDefIndex: 16171
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IEndDragHandler : IEventSystemHandler // TypeDefIndex: 16172
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEndDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDropHandler : IEventSystemHandler // TypeDefIndex: 16173
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrop(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IScrollHandler : IEventSystemHandler // TypeDefIndex: 16174
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnScroll(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IUpdateSelectedHandler : IEventSystemHandler // TypeDefIndex: 16175
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnUpdateSelected(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ISelectHandler : IEventSystemHandler // TypeDefIndex: 16176
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSelect(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDeselectHandler : IEventSystemHandler // TypeDefIndex: 16177
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDeselect(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IMoveHandler : IEventSystemHandler // TypeDefIndex: 16178
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnMove(AxisEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ISubmitHandler : IEventSystemHandler // TypeDefIndex: 16179
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSubmit(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ICancelHandler : IEventSystemHandler // TypeDefIndex: 16180
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCancel(BaseEventData eventData);
}

// Namespace: 
private struct EventSystem.UIToolkitOverrideConfig // TypeDefIndex: 16181
{
	// Fields
	public EventSystem activeEventSystem; // 0x0
	public bool sendEvents; // 0x8
	public bool createPanelGameObjectsOnStart; // 0x9
}

// Namespace: 
[CompilerGenerated]
private sealed class EventSystem.<>c__DisplayClass56_0 // TypeDefIndex: 16182
{
	// Fields
	public GameObject go; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x270F020 Offset: 0x270E220 VA: 0x18270F020
	internal void <CreateUIToolkitPanelGameObject>b__0() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Event System")]
[DisallowMultipleComponent]
public class EventSystem : UIBehaviour // TypeDefIndex: 16183
{
	// Fields
	private List<BaseInputModule> m_SystemInputModules; // 0x20
	private BaseInputModule m_CurrentInputModule; // 0x28
	private static List<EventSystem> m_EventSystems; // 0x0
	[SerializeField]
	[FormerlySerializedAs("m_Selected")]
	private GameObject m_FirstSelected; // 0x30
	[SerializeField]
	private bool m_sendNavigationEvents; // 0x38
	[SerializeField]
	private int m_DragThreshold; // 0x3C
	private GameObject m_CurrentSelected; // 0x40
	private bool m_HasFocus; // 0x48
	private bool m_SelectionGuard; // 0x49
	private BaseEventData m_DummyData; // 0x50
	private static readonly Comparison<RaycastResult> s_RaycastComparer; // 0x8
	private static EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride; // 0x10
	private bool m_Started; // 0x58
	private bool m_IsTrackingUIToolkitPanels; // 0x59

	// Properties
	public static EventSystem current { get; set; }
	public bool sendNavigationEvents { get; set; }
	public int pixelDragThreshold { get; set; }
	public BaseInputModule currentInputModule { get; }
	public GameObject firstSelectedGameObject { get; set; }
	public GameObject currentSelectedGameObject { get; }
	[Obsolete("lastSelectedGameObject is no longer supported")]
	public GameObject lastSelectedGameObject { get; }
	public bool isFocused { get; }
	public bool alreadySelecting { get; }
	private BaseEventData baseEventDataCache { get; }
	private bool isUIToolkitActiveEventSystem { get; }
	private bool sendUIToolkitEvents { get; }
	private bool createUIToolkitPanelGameObjectsOnStart { get; }

	// Methods

	// RVA: 0x2700CA0 Offset: 0x26FFEA0 VA: 0x182700CA0
	public static EventSystem get_current() { }

	// RVA: 0x2700EB0 Offset: 0x27000B0 VA: 0x182700EB0
	public static void set_current(EventSystem value) { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_sendNavigationEvents() { }

	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	public int get_pixelDragThreshold() { }

	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_isFocused() { }

	// RVA: 0x2700B40 Offset: 0x26FFD40 VA: 0x182700B40
	protected void .ctor() { }

	// RVA: 0x27006A0 Offset: 0x26FF8A0 VA: 0x1827006A0
	public void UpdateModules() { }

	// RVA: 0x563E30 Offset: 0x563030 VA: 0x180563E30
	public bool get_alreadySelecting() { }

	// RVA: 0x26FFD90 Offset: 0x26FEF90 VA: 0x1826FFD90
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x2700BC0 Offset: 0x26FFDC0 VA: 0x182700BC0
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x26FFD10 Offset: 0x26FEF10 VA: 0x1826FFD10
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x26FF890 Offset: 0x26FEA90 VA: 0x1826FF890
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x26FF690 Offset: 0x26FE890 VA: 0x1826FF690
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	// RVA: 0x26FF300 Offset: 0x26FE500 VA: 0x1826FF300
	public bool IsPointerOverGameObject() { }

	// RVA: 0x26FF260 Offset: 0x26FE460 VA: 0x1826FF260
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x2700D50 Offset: 0x26FFF50 VA: 0x182700D50
	private bool get_isUIToolkitActiveEventSystem() { }

	// RVA: 0x2700E40 Offset: 0x2700040 VA: 0x182700E40
	private bool get_sendUIToolkitEvents() { }

	// RVA: 0x2700C30 Offset: 0x26FFE30 VA: 0x182700C30
	private bool get_createUIToolkitPanelGameObjectsOnStart() { }

	// RVA: 0x26FFFA0 Offset: 0x26FF1A0 VA: 0x1826FFFA0
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = True, bool createPanelGameObjectsOnStart = True) { }

	// RVA: 0x2700130 Offset: 0x26FF330 VA: 0x182700130
	private void StartTrackingUIToolkitPanels() { }

	// RVA: 0x27003A0 Offset: 0x26FF5A0 VA: 0x1827003A0
	private void StopTrackingUIToolkitPanels() { }

	// RVA: 0x26FEFC0 Offset: 0x26FE1C0 VA: 0x1826FEFC0
	private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) { }

	// RVA: 0x2700390 Offset: 0x26FF590 VA: 0x182700390 Slot: 6
	protected override void Start() { }

	// RVA: 0x26FF530 Offset: 0x26FE730 VA: 0x1826FF530 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26FF3A0 Offset: 0x26FE5A0 VA: 0x1826FF3A0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2700440 Offset: 0x26FF640 VA: 0x182700440
	private void TickModules() { }

	// RVA: 0x26FF390 Offset: 0x26FE590 VA: 0x1826FF390 Slot: 17
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x27007E0 Offset: 0x26FF9E0 VA: 0x1827007E0 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x26FEEB0 Offset: 0x26FE0B0 VA: 0x1826FEEB0
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x2700540 Offset: 0x26FF740 VA: 0x182700540 Slot: 3
	public override string ToString() { }

	// RVA: 0x2700A50 Offset: 0x26FFC50 VA: 0x182700A50
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class EventTrigger.TriggerEvent : UnityEvent<BaseEventData> // TypeDefIndex: 16184
{
	// Methods

	// RVA: 0x270EFE0 Offset: 0x270E1E0 VA: 0x18270EFE0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class EventTrigger.Entry // TypeDefIndex: 16185
{
	// Fields
	public EventTriggerType eventID; // 0x10
	public EventTrigger.TriggerEvent callback; // 0x18

	// Methods

	// RVA: 0x26FEE20 Offset: 0x26FE020 VA: 0x1826FEE20
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Event Trigger")]
public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 16186
{
	// Fields
	[FormerlySerializedAs("delegates")]
	[SerializeField]
	private List<EventTrigger.Entry> m_Delegates; // 0x20

	// Properties
	[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", True)]
	[EditorBrowsable(1)]
	public List<EventTrigger.Entry> delegates { get; set; }
	public List<EventTrigger.Entry> triggers { get; set; }

	// Methods

	// RVA: 0x27012D0 Offset: 0x27004D0 VA: 0x1827012D0
	public List<EventTrigger.Entry> get_delegates() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_delegates(List<EventTrigger.Entry> value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }

	// RVA: 0x27012E0 Offset: 0x27004E0 VA: 0x1827012E0
	public List<EventTrigger.Entry> get_triggers() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_triggers(List<EventTrigger.Entry> value) { }

	// RVA: 0x2701040 Offset: 0x2700240 VA: 0x182701040
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x2701260 Offset: 0x2700460 VA: 0x182701260 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x2701270 Offset: 0x2700470 VA: 0x182701270 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x27011F0 Offset: 0x27003F0 VA: 0x1827011F0 Slot: 23
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x2701200 Offset: 0x2700400 VA: 0x182701200 Slot: 24
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x2701250 Offset: 0x2700450 VA: 0x182701250 Slot: 25
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2701280 Offset: 0x2700480 VA: 0x182701280 Slot: 26
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2701240 Offset: 0x2700440 VA: 0x182701240 Slot: 27
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x27012A0 Offset: 0x27004A0 VA: 0x1827012A0 Slot: 28
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x27011E0 Offset: 0x27003E0 VA: 0x1827011E0 Slot: 29
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2701290 Offset: 0x2700490 VA: 0x182701290 Slot: 30
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x2701230 Offset: 0x2700430 VA: 0x182701230 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x27012C0 Offset: 0x27004C0 VA: 0x1827012C0 Slot: 32
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x2701220 Offset: 0x2700420 VA: 0x182701220 Slot: 33
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x27011C0 Offset: 0x27003C0 VA: 0x1827011C0 Slot: 34
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x2701210 Offset: 0x2700410 VA: 0x182701210 Slot: 35
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x27012B0 Offset: 0x27004B0 VA: 0x1827012B0 Slot: 36
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x27011D0 Offset: 0x27003D0 VA: 0x1827011D0 Slot: 37
	public virtual void OnCancel(BaseEventData eventData) { }
}

// Namespace: UnityEngine.EventSystems
public enum EventTriggerType // TypeDefIndex: 16187
{
	// Fields
	public int value__; // 0x0
	public const EventTriggerType PointerEnter = 0;
	public const EventTriggerType PointerExit = 1;
	public const EventTriggerType PointerDown = 2;
	public const EventTriggerType PointerUp = 3;
	public const EventTriggerType PointerClick = 4;
	public const EventTriggerType Drag = 5;
	public const EventTriggerType Drop = 6;
	public const EventTriggerType Scroll = 7;
	public const EventTriggerType UpdateSelected = 8;
	public const EventTriggerType Select = 9;
	public const EventTriggerType Deselect = 10;
	public const EventTriggerType Move = 11;
	public const EventTriggerType InitializePotentialDrag = 12;
	public const EventTriggerType BeginDrag = 13;
	public const EventTriggerType EndDrag = 14;
	public const EventTriggerType Submit = 15;
	public const EventTriggerType Cancel = 16;
}

// Namespace: 
public sealed class ExecuteEvents.EventFunction<T1> : MulticastDelegate // TypeDefIndex: 16188
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	|-ExecuteEvents.EventFunction<object>..ctor
	|
	|-RVA: 0xBF24F0 Offset: 0xBF16F0 VA: 0x180BF24F0
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 handler, BaseEventData eventData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-ExecuteEvents.EventFunction<object>.Invoke
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0
	|-ExecuteEvents.EventFunction<object>.BeginInvoke
	|
	|-RVA: 0xCF0660 Offset: 0xCEF860 VA: 0x180CF0660
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240
	|-ExecuteEvents.EventFunction<object>.EndInvoke
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: UnityEngine.EventSystems
public static class ExecuteEvents // TypeDefIndex: 16189
{
	// Fields
	private static readonly ExecuteEvents.EventFunction<IPointerMoveHandler> s_PointerMoveHandler; // 0x0
	private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler; // 0x8
	private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler; // 0x10
	private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler; // 0x18
	private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler; // 0x20
	private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler; // 0x28
	private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x30
	private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler; // 0x38
	private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler; // 0x40
	private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler; // 0x48
	private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler; // 0x50
	private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler; // 0x58
	private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x60
	private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler; // 0x68
	private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler; // 0x70
	private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler; // 0x78
	private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler; // 0x80
	private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler; // 0x88
	private static readonly List<Transform> s_InternalTransformList; // 0x90

	// Properties
	public static ExecuteEvents.EventFunction<IPointerMoveHandler> pointerMoveHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler { get; }
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; }
	public static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDragHandler> dragHandler { get; }
	public static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDropHandler> dropHandler { get; }
	public static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler { get; }
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; }
	public static ExecuteEvents.EventFunction<ISelectHandler> selectHandler { get; }
	public static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler { get; }
	public static ExecuteEvents.EventFunction<IMoveHandler> moveHandler { get; }
	public static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler { get; }
	public static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T ValidateEventData<T>(BaseEventData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A2CB0 Offset: 0x9A1EB0 VA: 0x1809A2CB0
	|-ExecuteEvents.ValidateEventData<object>
	*/

	// RVA: 0x2701560 Offset: 0x2700760 VA: 0x182701560
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701880 Offset: 0x2700A80 VA: 0x182701880
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x27016A0 Offset: 0x27008A0 VA: 0x1827016A0
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701600 Offset: 0x2700800 VA: 0x182701600
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701CB0 Offset: 0x2700EB0 VA: 0x182701CB0
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x27017E0 Offset: 0x27009E0 VA: 0x1827017E0
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701C10 Offset: 0x2700E10 VA: 0x182701C10
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701740 Offset: 0x2700940 VA: 0x182701740
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701B70 Offset: 0x2700D70 VA: 0x182701B70
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701460 Offset: 0x2700660 VA: 0x182701460
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701980 Offset: 0x2700B80 VA: 0x182701980
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x27013C0 Offset: 0x27005C0 VA: 0x1827013C0
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701D50 Offset: 0x2700F50 VA: 0x182701D50
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701B10 Offset: 0x2700D10 VA: 0x182701B10
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701360 Offset: 0x2700560 VA: 0x182701360
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701A20 Offset: 0x2700C20 VA: 0x182701A20
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701920 Offset: 0x2700B20 VA: 0x182701920
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x2701500 Offset: 0x2700700 VA: 0x182701500
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x27028E0 Offset: 0x2701AE0 VA: 0x1827028E0
	public static ExecuteEvents.EventFunction<IPointerMoveHandler> get_pointerMoveHandler() { }

	// RVA: 0x2702840 Offset: 0x2701A40 VA: 0x182702840
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x2702890 Offset: 0x2701A90 VA: 0x182702890
	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x27027F0 Offset: 0x27019F0 VA: 0x1827027F0
	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x2702930 Offset: 0x2701B30 VA: 0x182702930
	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x27027A0 Offset: 0x27019A0 VA: 0x1827027A0
	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x2702700 Offset: 0x2701900 VA: 0x182702700
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x2702510 Offset: 0x2701710 VA: 0x182702510
	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x2702610 Offset: 0x2701810 VA: 0x182702610
	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	// RVA: 0x27026B0 Offset: 0x27018B0 VA: 0x1827026B0
	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x2702660 Offset: 0x2701860 VA: 0x182702660
	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	// RVA: 0x2702980 Offset: 0x2701B80 VA: 0x182702980
	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	// RVA: 0x2702A80 Offset: 0x2701C80 VA: 0x182702A80
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x27029D0 Offset: 0x2701BD0 VA: 0x1827029D0
	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	// RVA: 0x27025C0 Offset: 0x27017C0 VA: 0x1827025C0
	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x2702750 Offset: 0x2701950 VA: 0x182702750
	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	// RVA: 0x2702A20 Offset: 0x2701C20 VA: 0x182702A20
	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	// RVA: 0x2702560 Offset: 0x2701760 VA: 0x182702560
	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	// RVA: 0x2701DB0 Offset: 0x2700FB0 VA: 0x182701DB0
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	// RVA: -1 Offset: -1
	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A1F50 Offset: 0x9A1150 VA: 0x1809A1F50
	|-ExecuteEvents.Execute<object>
	|
	|-RVA: 0x9A1B20 Offset: 0x9A0D20 VA: 0x1809A1B20
	|-ExecuteEvents.Execute<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A19B0 Offset: 0x9A0BB0 VA: 0x1809A19B0
	|-ExecuteEvents.ExecuteHierarchy<object>
	|
	|-RVA: 0x9A1840 Offset: 0x9A0A40 VA: 0x1809A1840
	|-ExecuteEvents.ExecuteHierarchy<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool ShouldSendToComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A2BA0 Offset: 0x9A1DA0 VA: 0x1809A2BA0
	|-ExecuteEvents.ShouldSendToComponent<object>
	|-ExecuteEvents.ShouldSendToComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A2850 Offset: 0x9A1A50 VA: 0x1809A2850
	|-ExecuteEvents.GetEventList<object>
	|
	|-RVA: 0x9A25F0 Offset: 0x9A17F0 VA: 0x1809A25F0
	|-ExecuteEvents.GetEventList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool CanHandleEvent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A1750 Offset: 0x9A0950 VA: 0x1809A1750
	|-ExecuteEvents.CanHandleEvent<object>
	|
	|-RVA: 0x9A1660 Offset: 0x9A0860 VA: 0x1809A1660
	|-ExecuteEvents.CanHandleEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A2410 Offset: 0x9A1610 VA: 0x1809A2410
	|-ExecuteEvents.GetEventHandler<object>
	|
	|-RVA: 0x9A22E0 Offset: 0x9A14E0 VA: 0x1809A22E0
	|-ExecuteEvents.GetEventHandler<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2701F20 Offset: 0x2701120 VA: 0x182701F20
	private static void .cctor() { }
}

// Namespace: UnityEngine.EventSystems
public class BaseInput : UIBehaviour // TypeDefIndex: 16190
{
	// Properties
	public virtual string compositionString { get; }
	public virtual IMECompositionMode imeCompositionMode { get; set; }
	public virtual Vector2 compositionCursorPos { get; set; }
	public virtual bool mousePresent { get; }
	public virtual Vector2 mousePosition { get; }
	public virtual Vector2 mouseScrollDelta { get; }
	public virtual bool touchSupported { get; }
	public virtual int touchCount { get; }

	// Methods

	// RVA: 0x26FE6B0 Offset: 0x26FD8B0 VA: 0x1826FE6B0 Slot: 17
	public virtual string get_compositionString() { }

	// RVA: 0x26FE6C0 Offset: 0x26FD8C0 VA: 0x1826FE6C0 Slot: 18
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x26FE710 Offset: 0x26FD910 VA: 0x1826FE710 Slot: 19
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x26FE6A0 Offset: 0x26FD8A0 VA: 0x1826FE6A0 Slot: 20
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x26FE6F0 Offset: 0x26FD8F0 VA: 0x1826FE6F0 Slot: 21
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x264D9F0 Offset: 0x264CBF0 VA: 0x18264D9F0 Slot: 22
	public virtual bool get_mousePresent() { }

	// RVA: 0x264D970 Offset: 0x264CB70 VA: 0x18264D970 Slot: 23
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x264D980 Offset: 0x264CB80 VA: 0x18264D980 Slot: 24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x26FE690 Offset: 0x26FD890 VA: 0x1826FE690 Slot: 25
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x7AD6B0 Offset: 0x7AC8B0 VA: 0x1807AD6B0 Slot: 26
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x26FE6D0 Offset: 0x26FD8D0 VA: 0x1826FE6D0 Slot: 27
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x26FE6E0 Offset: 0x26FD8E0 VA: 0x1826FE6E0 Slot: 28
	public virtual bool get_touchSupported() { }

	// RVA: 0x191CCA0 Offset: 0x191BEA0 VA: 0x18191CCA0 Slot: 29
	public virtual int get_touchCount() { }

	// RVA: 0x191CBC0 Offset: 0x191BDC0 VA: 0x18191CBC0 Slot: 30
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x26FE680 Offset: 0x26FD880 VA: 0x1826FE680 Slot: 31
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x264D920 Offset: 0x264CB20 VA: 0x18264D920 Slot: 32
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[RequireComponent(typeof(EventSystem))]
public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 16191
{
	// Fields
	protected List<RaycastResult> m_RaycastResultCache; // 0x20
	[SerializeField]
	private bool m_SendPointerHoverToParent; // 0x28
	private AxisEventData m_AxisEventData; // 0x30
	private EventSystem m_EventSystem; // 0x38
	private BaseEventData m_BaseEventData; // 0x40
	protected BaseInput m_InputOverride; // 0x48
	private BaseInput m_DefaultInput; // 0x50

	// Properties
	internal bool sendPointerHoverToParent { get; set; }
	public BaseInput input { get; }
	public BaseInput inputOverride { get; set; }
	protected EventSystem eventSystem { get; }

	// Methods

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	internal bool get_sendPointerHoverToParent() { }

	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	internal void set_sendPointerHoverToParent(bool value) { }

	// RVA: 0x26FE460 Offset: 0x26FD660 VA: 0x1826FE460
	public BaseInput get_input() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public BaseInput get_inputOverride() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	protected EventSystem get_eventSystem() { }

	// RVA: 0x26FE350 Offset: 0x26FD550 VA: 0x1826FE350 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26FE330 Offset: 0x26FD530 VA: 0x1826FE330 Slot: 7
	protected override void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Process();

	// RVA: 0x26FD500 Offset: 0x26FC700 VA: 0x1826FD500
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	// RVA: 0x26FD300 Offset: 0x26FC500 VA: 0x1826FD300
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x26FD280 Offset: 0x26FC480 VA: 0x1826FD280
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x26FD370 Offset: 0x26FC570 VA: 0x1826FD370
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x26FD810 Offset: 0x26FCA10 VA: 0x1826FD810
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x26FD640 Offset: 0x26FC840 VA: 0x1826FD640 Slot: 18
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x26FD770 Offset: 0x26FC970 VA: 0x1826FD770 Slot: 19
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 20
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x26FE3B0 Offset: 0x26FD5B0 VA: 0x1826FE3B0 Slot: 21
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public virtual void DeactivateModule() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 23
	public virtual void ActivateModule() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 24
	public virtual void UpdateModule() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 25
	public virtual bool IsModuleSupported() { }

	// RVA: 0x26FD1E0 Offset: 0x26FC3E0 VA: 0x1826FD1E0 Slot: 26
	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x26FE3F0 Offset: 0x26FD5F0 VA: 0x1826FE3F0
	protected void .ctor() { }
}

// Namespace: 
protected class PointerInputModule.ButtonState // TypeDefIndex: 16192
{
	// Fields
	private PointerEventData.InputButton m_Button; // 0x10
	private PointerInputModule.MouseButtonEventData m_EventData; // 0x18

	// Properties
	public PointerInputModule.MouseButtonEventData eventData { get; set; }
	public PointerEventData.InputButton button { get; set; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public PointerInputModule.MouseButtonEventData get_eventData() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_eventData(PointerInputModule.MouseButtonEventData value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public PointerEventData.InputButton get_button() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
protected class PointerInputModule.MouseState // TypeDefIndex: 16193
{
	// Fields
	private List<PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x2702C40 Offset: 0x2701E40 VA: 0x182702C40
	public bool AnyPressesThisFrame() { }

	// RVA: 0x2702D00 Offset: 0x2701F00 VA: 0x182702D00
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x2702DC0 Offset: 0x2701FC0 VA: 0x182702DC0
	public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button) { }

	// RVA: 0x2702F50 Offset: 0x2702150 VA: 0x182702F50
	public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x2702FA0 Offset: 0x27021A0 VA: 0x182702FA0
	public void .ctor() { }
}

// Namespace: 
public class PointerInputModule.MouseButtonEventData // TypeDefIndex: 16194
{
	// Fields
	public PointerEventData.FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x72EAE0 Offset: 0x72DCE0 VA: 0x18072EAE0
	public bool PressedThisFrame() { }

	// RVA: 0x72EB00 Offset: 0x72DD00 VA: 0x18072EB00
	public bool ReleasedThisFrame() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 16195
{
	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; // 0x58
	private readonly PointerInputModule.MouseState m_MouseState; // 0x60

	// Methods

	// RVA: 0x27091A0 Offset: 0x27083A0 VA: 0x1827091A0
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x2709A80 Offset: 0x2708C80 VA: 0x182709A80
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x2709290 Offset: 0x2708490 VA: 0x182709290
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x2708850 Offset: 0x2707A50 VA: 0x182708850
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x2709AE0 Offset: 0x2708CE0 VA: 0x182709AE0
	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x2708AA0 Offset: 0x2707CA0 VA: 0x182708AA0 Slot: 27
	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	// RVA: 0x2708AC0 Offset: 0x2707CC0 VA: 0x182708AC0 Slot: 28
	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x2708A70 Offset: 0x2707C70 VA: 0x182708A70
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x732440 Offset: 0x731640 VA: 0x180732440
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x2709A30 Offset: 0x2708C30 VA: 0x182709A30 Slot: 29
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x2709770 Offset: 0x2708970 VA: 0x182709770 Slot: 30
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x27096E0 Offset: 0x27088E0 VA: 0x1827096E0 Slot: 20
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x27086B0 Offset: 0x27078B0 VA: 0x1827086B0
	protected void ClearSelection() { }

	// RVA: 0x2709BA0 Offset: 0x2708DA0 VA: 0x182709BA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2708990 Offset: 0x2707B90 VA: 0x182708990
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x2709E20 Offset: 0x2709020 VA: 0x182709E20
	protected void .ctor() { }
}

// Namespace: 
[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
public enum StandaloneInputModule.InputMode // TypeDefIndex: 16196
{
	// Fields
	public int value__; // 0x0
	public const StandaloneInputModule.InputMode Mouse = 0;
	public const StandaloneInputModule.InputMode Buttons = 1;
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Standalone Input Module")]
public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 16197
{
	// Fields
	private float m_PrevActionTime; // 0x68
	private Vector2 m_LastMoveVector; // 0x6C
	private int m_ConsecutiveMoveCount; // 0x74
	private Vector2 m_LastMousePosition; // 0x78
	private Vector2 m_MousePosition; // 0x80
	private GameObject m_CurrentFocusedGameObject; // 0x88
	private PointerEventData m_InputPointerEvent; // 0x90
	private const float doubleClickTime = 0,3;
	[SerializeField]
	private string m_HorizontalAxis; // 0x98
	[SerializeField]
	private string m_VerticalAxis; // 0xA0
	[SerializeField]
	private string m_SubmitButton; // 0xA8
	[SerializeField]
	private string m_CancelButton; // 0xB0
	[SerializeField]
	private float m_InputActionsPerSecond; // 0xB8
	[SerializeField]
	private float m_RepeatDelay; // 0xBC
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	[HideInInspector]
	[SerializeField]
	private bool m_ForceModuleActive; // 0xC0

	// Properties
	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	public StandaloneInputModule.InputMode inputMode { get; }
	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnMobileDevice { get; set; }
	[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x270D880 Offset: 0x270CA80 VA: 0x18270D880
	protected void .ctor() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public StandaloneInputModule.InputMode get_inputMode() { }

	// RVA: 0x5C6220 Offset: 0x5C5420 VA: 0x1805C6220
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x6BC540 Offset: 0x6BB740 VA: 0x1806BC540
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x5C6220 Offset: 0x5C5420 VA: 0x1805C6220
	public bool get_forceModuleActive() { }

	// RVA: 0x6BC540 Offset: 0x6BB740 VA: 0x1806BC540
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x270D930 Offset: 0x270CB30 VA: 0x18270D930
	public float get_inputActionsPerSecond() { }

	// RVA: 0x270D950 Offset: 0x270CB50 VA: 0x18270D950
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x270D940 Offset: 0x270CB40 VA: 0x18270D940
	public float get_repeatDelay() { }

	// RVA: 0x270D960 Offset: 0x270CB60 VA: 0x18270D960
	public void set_repeatDelay(float value) { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public string get_horizontalAxis() { }

	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	public void set_horizontalAxis(string value) { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public string get_verticalAxis() { }

	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20
	public void set_verticalAxis(string value) { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public string get_submitButton() { }

	// RVA: 0xB83400 Offset: 0xB82600 VA: 0x180B83400
	public void set_submitButton(string value) { }

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	public string get_cancelButton() { }

	// RVA: 0x88DF00 Offset: 0x88D100 VA: 0x18088DF00
	public void set_cancelButton(string value) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x270D740 Offset: 0x270C940 VA: 0x18270D740 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x270CA60 Offset: 0x270BC60 VA: 0x18270CA60
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x270D500 Offset: 0x270C700 VA: 0x18270D500 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x270B0C0 Offset: 0x270A2C0 VA: 0x18270B0C0 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x270B220 Offset: 0x270A420 VA: 0x18270B220 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x270C880 Offset: 0x270BA80 VA: 0x18270C880 Slot: 17
	public override void Process() { }

	// RVA: 0x270BA70 Offset: 0x270AC70 VA: 0x18270BA70
	private bool ProcessTouchEvents() { }

	// RVA: 0x270C1D0 Offset: 0x270B3D0 VA: 0x18270C1D0
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x270D160 Offset: 0x270C360 VA: 0x18270D160
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x270B230 Offset: 0x270A430 VA: 0x18270B230
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x270CDF0 Offset: 0x270BFF0 VA: 0x18270CDF0
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x270B660 Offset: 0x270A860 VA: 0x18270B660
	protected void ProcessMouseEvent() { }

	[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 31
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x270B3A0 Offset: 0x270A5A0 VA: 0x18270B3A0
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x270D3B0 Offset: 0x270C5B0 VA: 0x18270D3B0
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x270B670 Offset: 0x270A870 VA: 0x18270B670
	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	protected GameObject GetCurrentFocusedGameObject() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Touch Input Module")]
[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
public class TouchInputModule : PointerInputModule // TypeDefIndex: 16198
{
	// Fields
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private PointerEventData m_InputPointerEvent; // 0x78
	[FormerlySerializedAs("m_AllowActivationOnStandalone")]
	[SerializeField]
	private bool m_ForceModuleActive; // 0x80

	// Properties
	[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnStandalone { get; set; }
	public bool forceModuleActive { get; set; }

	// Methods

	// RVA: 0x270EFD0 Offset: 0x270E1D0 VA: 0x18270EFD0
	protected void .ctor() { }

	// RVA: 0x67AA00 Offset: 0x679C00 VA: 0x18067AA00
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0x67AD80 Offset: 0x679F80 VA: 0x18067AD80
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x67AA00 Offset: 0x679C00 VA: 0x18067AA00
	public bool get_forceModuleActive() { }

	// RVA: 0x67AD80 Offset: 0x679F80 VA: 0x18067AD80
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x270EE30 Offset: 0x270E030 VA: 0x18270EE30 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x270DAD0 Offset: 0x270CCD0 VA: 0x18270DAD0 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x270EA60 Offset: 0x270DC60 VA: 0x18270EA60 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x270EF90 Offset: 0x270E190 VA: 0x18270EF90
	private bool UseFakeInput() { }

	// RVA: 0x270E8B0 Offset: 0x270DAB0 VA: 0x18270E8B0 Slot: 17
	public override void Process() { }

	// RVA: 0x270D970 Offset: 0x270CB70 VA: 0x18270D970
	private void FakeTouches() { }

	// RVA: 0x270DB20 Offset: 0x270CD20 VA: 0x18270DB20
	private void ProcessTouchEvents() { }

	// RVA: 0x270E240 Offset: 0x270D440 VA: 0x18270E240
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x270B220 Offset: 0x270A420 VA: 0x18270B220 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x270EB80 Offset: 0x270DD80 VA: 0x18270EB80 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
public enum MoveDirection // TypeDefIndex: 16199
{
	// Fields
	public int value__; // 0x0
	public const MoveDirection Left = 0;
	public const MoveDirection Up = 1;
	public const MoveDirection Right = 2;
	public const MoveDirection Down = 3;
	public const MoveDirection None = 4;
}

// Namespace: UnityEngine.EventSystems
public static class RaycasterManager // TypeDefIndex: 16200
{
	// Fields
	private static readonly List<BaseRaycaster> s_Raycasters; // 0x0

	// Methods

	// RVA: 0x270A6D0 Offset: 0x27098D0 VA: 0x18270A6D0
	internal static void AddRaycaster(BaseRaycaster baseRaycaster) { }

	// RVA: 0x270A7F0 Offset: 0x27099F0 VA: 0x18270A7F0
	public static List<BaseRaycaster> GetRaycasters() { }

	// RVA: 0x270A840 Offset: 0x2709A40 VA: 0x18270A840
	internal static void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

	// RVA: 0x270A910 Offset: 0x2709B10 VA: 0x18270A910
	private static void .cctor() { }
}

// Namespace: UnityEngine.EventSystems
public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 16201
{
	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x20

	// Properties
	public abstract Camera eventCamera { get; }
	[Obsolete("Please use sortOrderPriority and renderOrderPriority", False)]
	public virtual int priority { get; }
	public virtual int sortOrderPriority { get; }
	public virtual int renderOrderPriority { get; }
	public BaseRaycaster rootRaycaster { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Camera get_eventCamera();

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 19
	public virtual int get_priority() { }

	// RVA: 0x26FEB40 Offset: 0x26FDD40 VA: 0x1826FEB40 Slot: 20
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x26FEB40 Offset: 0x26FDD40 VA: 0x1826FEB40 Slot: 21
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x26FEB50 Offset: 0x26FDD50 VA: 0x1826FEB50
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x26FE970 Offset: 0x26FDB70 VA: 0x1826FE970 Slot: 3
	public override string ToString() { }

	// RVA: 0x26FE830 Offset: 0x26FDA30 VA: 0x1826FE830 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26FE730 Offset: 0x26FD930 VA: 0x1826FE730 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x26FE720 Offset: 0x26FD920 VA: 0x1826FE720 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x26FE720 Offset: 0x26FD920 VA: 0x1826FE720 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Physics 2D Raycaster")]
[RequireComponent(typeof(Camera))]
public class Physics2DRaycaster : PhysicsRaycaster // TypeDefIndex: 16202
{
	// Fields
	private RaycastHit2D[] m_Hits; // 0x48

	// Methods

	// RVA: 0x2706510 Offset: 0x2705710 VA: 0x182706510
	protected void .ctor() { }

	// RVA: 0x2705D40 Offset: 0x2704F40 VA: 0x182705D40 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }
}

// Namespace: 
private class PhysicsRaycaster.RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 16203
{
	// Fields
	public static PhysicsRaycaster.RaycastHitComparer instance; // 0x0

	// Methods

	// RVA: 0x270A090 Offset: 0x2709290 VA: 0x18270A090 Slot: 4
	public int Compare(RaycastHit x, RaycastHit y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x270A0D0 Offset: 0x27092D0 VA: 0x18270A0D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Physics Raycaster")]
[RequireComponent(typeof(Camera))]
public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 16204
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	protected Camera m_EventCamera; // 0x28
	[SerializeField]
	protected LayerMask m_EventMask; // 0x30
	[SerializeField]
	protected int m_MaxRayIntersections; // 0x34
	protected int m_LastMaxRayIntersections; // 0x38
	private RaycastHit[] m_Hits; // 0x40

	// Properties
	public override Camera eventCamera { get; }
	public virtual int depth { get; }
	public int finalEventMask { get; }
	public LayerMask eventMask { get; set; }
	public int maxRayIntersections { get; set; }

	// Methods

	// RVA: 0x2706510 Offset: 0x2705710 VA: 0x182706510
	protected void .ctor() { }

	// RVA: 0x2706E40 Offset: 0x2706040 VA: 0x182706E40 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x2706D80 Offset: 0x2705F80 VA: 0x182706D80 Slot: 22
	public virtual int get_depth() { }

	// RVA: 0x2706F00 Offset: 0x2706100 VA: 0x182706F00
	public int get_finalEventMask() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public LayerMask get_eventMask() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public int get_maxRayIntersections() { }

	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x2706540 Offset: 0x2705740 VA: 0x182706540
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) { }

	// RVA: 0x27068D0 Offset: 0x2705AD0 VA: 0x1827068D0 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }
}

// Namespace: UnityEngine.EventSystems
public struct RaycastResult // TypeDefIndex: 16205
{
	// Fields
	private GameObject m_GameObject; // 0x0
	public BaseRaycaster module; // 0x8
	public float distance; // 0x10
	public float index; // 0x14
	public int depth; // 0x18
	public int sortingGroupID; // 0x1C
	public int sortingGroupOrder; // 0x20
	public int sortingLayer; // 0x24
	public int sortingOrder; // 0x28
	public Vector3 worldPosition; // 0x2C
	public Vector3 worldNormal; // 0x38
	public Vector2 screenPosition; // 0x44
	public int displayIndex; // 0x4C

	// Properties
	public GameObject gameObject { get; set; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public GameObject get_gameObject() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_gameObject(GameObject value) { }

	// RVA: 0x270A640 Offset: 0x2709840 VA: 0x18270A640
	public bool get_isValid() { }

	// RVA: 0x270A130 Offset: 0x2709330 VA: 0x18270A130
	public void Clear() { }

	// RVA: 0x270A210 Offset: 0x2709410 VA: 0x18270A210 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
public abstract class UIBehaviour : MonoBehaviour // TypeDefIndex: 16206
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	protected virtual void Start() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	protected virtual void OnDisable() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	protected virtual void OnDestroy() { }

	// RVA: 0x5AB2A0 Offset: 0x5AA4A0 VA: 0x1805AB2A0 Slot: 9
	public virtual bool IsActive() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	protected virtual void OnRectTransformDimensionsChange() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	protected virtual void OnBeforeTransformParentChanged() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	protected virtual void OnDidApplyAnimationProperties() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 14
	protected virtual void OnCanvasGroupChanged() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	protected virtual void OnCanvasHierarchyChanged() { }

	// RVA: 0x270F070 Offset: 0x270E270 VA: 0x18270F070 Slot: 16
	public bool IsDestroyed() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 16207
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5527 // TypeDefIndex: 16208
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7141 // TypeDefIndex: 16209
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16210
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB /*Metadata offset 0x8F40B8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5527 7C777EEED2359F9E03B1E9BA3FE7218E75A8BA42A33894ABBE8BB2022DDED720 /*Metadata offset 0x8F40C8*/; // 0xC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7141 F8E13B9278EE691BEBE612B17CB7B9E4D3E7E27D94AF464B25288A45134C990D /*Metadata offset 0x8F5660*/; // 0x15A3
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16211
{}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class Character : TextElement // TypeDefIndex: 16212
{
	// Methods

	// RVA: 0x2509F30 Offset: 0x2509130 VA: 0x182509F30
	public void .ctor() { }

	// RVA: 0x2509F60 Offset: 0x2509160 VA: 0x182509F60
	public void .ctor(uint unicode, FontAsset fontAsset, Glyph glyph) { }

	// RVA: 0x2509EE0 Offset: 0x25090E0 VA: 0x182509EE0
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class ColorUtilities // TypeDefIndex: 16213
{
	// Methods

	// RVA: 0x2509FD0 Offset: 0x25091D0 VA: 0x182509FD0
	internal static bool CompareColors(Color32 a, Color32 b) { }

	// RVA: 0x250A010 Offset: 0x2509210 VA: 0x18250A010
	internal static Color32 MultiplyColors(Color32 c1, Color32 c2) { }
}

// Namespace: UnityEngine.TextCore.Text
public enum TextFontWeight // TypeDefIndex: 16214
{
	// Fields
	public int value__; // 0x0
	public const TextFontWeight Thin = 100;
	public const TextFontWeight ExtraLight = 200;
	public const TextFontWeight Light = 300;
	public const TextFontWeight Regular = 400;
	public const TextFontWeight Medium = 500;
	public const TextFontWeight SemiBold = 600;
	public const TextFontWeight Bold = 700;
	public const TextFontWeight Heavy = 800;
	public const TextFontWeight Black = 900;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public struct FontWeightPair // TypeDefIndex: 16215
{
	// Fields
	public FontAsset regularTypeface; // 0x0
	public FontAsset italicTypeface; // 0x8
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromDocs]
[Serializable]
public struct FontAssetCreationEditorSettings // TypeDefIndex: 16216
{
	// Fields
	public string sourceFontFileGUID; // 0x0
	public int faceIndex; // 0x8
	public int pointSizeSamplingMode; // 0xC
	public int pointSize; // 0x10
	public int padding; // 0x14
	public int paddingMode; // 0x18
	public int packingMode; // 0x1C
	public int atlasWidth; // 0x20
	public int atlasHeight; // 0x24
	public int characterSetSelectionMode; // 0x28
	public string characterSequence; // 0x30
	public string referencedFontAssetGUID; // 0x38
	public string referencedTextAssetGUID; // 0x40
	public int fontStyle; // 0x48
	public float fontStyleModifier; // 0x4C
	public int renderMode; // 0x50
	public bool includeFontFeatures; // 0x54
}

// Namespace: UnityEngine.TextCore.Text
public enum AtlasPopulationMode // TypeDefIndex: 16217
{
	// Fields
	public int value__; // 0x0
	public const AtlasPopulationMode Static = 0;
	public const AtlasPopulationMode Dynamic = 1;
	public const AtlasPopulationMode DynamicOS = 2;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FontAsset.<>c // TypeDefIndex: 16218
{
	// Fields
	public static readonly FontAsset.<>c <>9; // 0x0
	public static Func<Character, uint> <>9__151_0; // 0x8
	public static Func<Glyph, uint> <>9__152_0; // 0x10

	// Methods

	// RVA: 0x251EE50 Offset: 0x251E050 VA: 0x18251EE50
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23F8450 Offset: 0x23F7650 VA: 0x1823F8450
	internal uint <SortCharacterTable>b__151_0(Character c) { }

	// RVA: 0x23F84B0 Offset: 0x23F76B0 VA: 0x1823F84B0
	internal uint <SortGlyphTable>b__152_0(Glyph c) { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[Serializable]
public class FontAsset : TextAsset // TypeDefIndex: 16219
{
	// Fields
	[SerializeField]
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; // 0x40
	[SerializeField]
	private Font m_SourceFontFile; // 0x98
	[SerializeField]
	private string m_SourceFontFilePath; // 0xA0
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; // 0xA8
	[SerializeField]
	internal bool InternalDynamicOS; // 0xAC
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0xB0
	private int m_FamilyNameHashCode; // 0x110
	private int m_StyleNameHashCode; // 0x114
	[SerializeField]
	internal List<Glyph> m_GlyphTable; // 0x118
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0x120
	[SerializeField]
	internal List<Character> m_CharacterTable; // 0x128
	internal Dictionary<uint, Character> m_CharacterLookupDictionary; // 0x130
	internal Texture2D m_AtlasTexture; // 0x138
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; // 0x140
	[SerializeField]
	internal int m_AtlasTextureIndex; // 0x148
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; // 0x14C
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; // 0x14D
	[SerializeField]
	internal int m_AtlasWidth; // 0x150
	[SerializeField]
	internal int m_AtlasHeight; // 0x154
	[SerializeField]
	internal int m_AtlasPadding; // 0x158
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; // 0x15C
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects; // 0x160
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects; // 0x168
	[SerializeField]
	internal FontFeatureTable m_FontFeatureTable; // 0x170
	[SerializeField]
	internal List<FontAsset> m_FallbackFontAssetTable; // 0x178
	[SerializeField]
	private FontWeightPair[] m_FontWeightTable; // 0x180
	[FormerlySerializedAs("normalStyle")]
	[SerializeField]
	internal float m_RegularStyleWeight; // 0x188
	[SerializeField]
	[FormerlySerializedAs("normalSpacingOffset")]
	internal float m_RegularStyleSpacing; // 0x18C
	[SerializeField]
	[FormerlySerializedAs("boldStyle")]
	internal float m_BoldStyleWeight; // 0x190
	[FormerlySerializedAs("boldSpacing")]
	[SerializeField]
	internal float m_BoldStyleSpacing; // 0x194
	[SerializeField]
	[FormerlySerializedAs("italicStyle")]
	internal byte m_ItalicStyleSlant; // 0x198
	[FormerlySerializedAs("tabSize")]
	[SerializeField]
	internal byte m_TabMultiple; // 0x199
	internal bool IsFontAssetLookupTablesDirty; // 0x19A
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x0
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x8
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x10
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x18
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; // 0x28
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x30
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x38
	private static ProfilerMarker k_TryAddGlyphMarker; // 0x40
	private static string s_DefaultMaterialSuffix; // 0x48
	private static HashSet<int> k_SearchedFontAssetLookup; // 0x50
	private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x58
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x60
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x68
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x70
	private List<Glyph> m_GlyphsToRender; // 0x1A0
	private List<Glyph> m_GlyphsRendered; // 0x1A8
	private List<uint> m_GlyphIndexList; // 0x1B0
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1B8
	internal List<uint> m_GlyphsToAdd; // 0x1C0
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x1C8
	internal List<Character> m_CharactersToAdd; // 0x1D0
	internal HashSet<uint> m_CharactersToAddLookup; // 0x1D8
	internal List<uint> s_MissingCharacterList; // 0x1E0
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x1E8
	internal static uint[] k_GlyphIndexArray; // 0x78

	// Properties
	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	public FaceInfo faceInfo { get; set; }
	internal int familyNameHashCode { get; set; }
	internal int styleNameHashCode { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<Character> characterTable { get; set; }
	public Dictionary<uint, Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	public int atlasTextureCount { get; }
	public bool isMultiAtlasTexturesEnabled { get; set; }
	internal bool clearDynamicDataOnBuild { get; set; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	public FontFeatureTable fontFeatureTable { get; set; }
	public List<FontAsset> fallbackFontAssetTable { get; set; }
	public FontWeightPair[] fontWeightTable { get; set; }
	public float regularStyleWeight { get; set; }
	public float regularStyleSpacing { get; set; }
	public float boldStyleWeight { get; set; }
	public float boldStyleSpacing { get; set; }
	public byte italicStyleSlant { get; set; }
	public byte tabMultiple { get; set; }

	// Methods

	// RVA: 0x2514700 Offset: 0x2513900 VA: 0x182514700
	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	// RVA: 0x2514930 Offset: 0x2513B30 VA: 0x182514930
	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	// RVA: 0x24CAD40 Offset: 0x24C9F40 VA: 0x1824CAD40
	public Font get_sourceFontFile() { }

	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x25144E0 Offset: 0x25136E0 VA: 0x1825144E0
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x146AF20 Offset: 0x146A120 VA: 0x18146AF20
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x2514650 Offset: 0x2513850 VA: 0x182514650
	public FaceInfo get_faceInfo() { }

	// RVA: 0x25148E0 Offset: 0x2513AE0 VA: 0x1825148E0
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x25146B0 Offset: 0x25138B0 VA: 0x1825146B0
	internal int get_familyNameHashCode() { }

	// RVA: 0x23E6FF0 Offset: 0x23E61F0 VA: 0x1823E6FF0
	internal void set_familyNameHashCode(int value) { }

	// RVA: 0x2514800 Offset: 0x2513A00 VA: 0x182514800
	internal int get_styleNameHashCode() { }

	// RVA: 0x23E7000 Offset: 0x23E6200 VA: 0x1823E7000
	internal void set_styleNameHashCode(int value) { }

	// RVA: 0x25147B0 Offset: 0x25139B0 VA: 0x1825147B0
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x2514770 Offset: 0x2513970 VA: 0x182514770
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x2514630 Offset: 0x2513830 VA: 0x182514630
	public List<Character> get_characterTable() { }

	// RVA: 0x5405B0 Offset: 0x53F7B0 VA: 0x1805405B0
	internal void set_characterTable(List<Character> value) { }

	// RVA: 0x25145F0 Offset: 0x25137F0 VA: 0x1825145F0
	public Dictionary<uint, Character> get_characterLookupTable() { }

	// RVA: 0x2514510 Offset: 0x2513710 VA: 0x182514510
	public Texture2D get_atlasTexture() { }

	// RVA: 0x25145B0 Offset: 0x25137B0 VA: 0x1825145B0
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x78BDC0 Offset: 0x78AFC0 VA: 0x18078BDC0
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x2514500 Offset: 0x2513700 VA: 0x182514500
	public int get_atlasTextureCount() { }

	// RVA: 0x25147C0 Offset: 0x25139C0 VA: 0x1825147C0
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x2514970 Offset: 0x2513B70 VA: 0x182514970
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x2514640 Offset: 0x2513840 VA: 0x182514640
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x25148D0 Offset: 0x2513AD0 VA: 0x1825148D0
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x25145C0 Offset: 0x25137C0 VA: 0x1825145C0
	public int get_atlasWidth() { }

	// RVA: 0x25148A0 Offset: 0x2513AA0 VA: 0x1825148A0
	internal void set_atlasWidth(int value) { }

	// RVA: 0x25144C0 Offset: 0x25136C0 VA: 0x1825144C0
	public int get_atlasHeight() { }

	// RVA: 0x2514870 Offset: 0x2513A70 VA: 0x182514870
	internal void set_atlasHeight(int value) { }

	// RVA: 0x25144D0 Offset: 0x25136D0 VA: 0x1825144D0
	public int get_atlasPadding() { }

	// RVA: 0x2514880 Offset: 0x2513A80 VA: 0x182514880
	internal void set_atlasPadding(int value) { }

	// RVA: 0x25144F0 Offset: 0x25136F0 VA: 0x1825144F0
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x2514890 Offset: 0x2513A90 VA: 0x182514890
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x2514860 Offset: 0x2513A60 VA: 0x182514860
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x25149B0 Offset: 0x2513BB0 VA: 0x1825149B0
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x2514760 Offset: 0x2513960 VA: 0x182514760
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x78AD60 Offset: 0x789F60 VA: 0x18078AD60
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x2514740 Offset: 0x2513940 VA: 0x182514740
	public FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x1C61D80 Offset: 0x1C60F80 VA: 0x181C61D80
	internal void set_fontFeatureTable(FontFeatureTable value) { }

	// RVA: 0x25146A0 Offset: 0x25138A0 VA: 0x1825146A0
	public List<FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x69D3C0 Offset: 0x69C5C0 VA: 0x18069D3C0
	public void set_fallbackFontAssetTable(List<FontAsset> value) { }

	// RVA: 0x2514750 Offset: 0x2513950 VA: 0x182514750
	public FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x78AD70 Offset: 0x789F70 VA: 0x18078AD70
	internal void set_fontWeightTable(FontWeightPair[] value) { }

	// RVA: 0x25147F0 Offset: 0x25139F0 VA: 0x1825147F0
	public float get_regularStyleWeight() { }

	// RVA: 0x2514990 Offset: 0x2513B90 VA: 0x182514990
	public void set_regularStyleWeight(float value) { }

	// RVA: 0x25147E0 Offset: 0x25139E0 VA: 0x1825147E0
	public float get_regularStyleSpacing() { }

	// RVA: 0x2514980 Offset: 0x2513B80 VA: 0x182514980
	public void set_regularStyleSpacing(float value) { }

	// RVA: 0x25145E0 Offset: 0x25137E0 VA: 0x1825145E0
	public float get_boldStyleWeight() { }

	// RVA: 0x25148C0 Offset: 0x2513AC0 VA: 0x1825148C0
	public void set_boldStyleWeight(float value) { }

	// RVA: 0x25145D0 Offset: 0x25137D0 VA: 0x1825145D0
	public float get_boldStyleSpacing() { }

	// RVA: 0x25148B0 Offset: 0x2513AB0 VA: 0x1825148B0
	public void set_boldStyleSpacing(float value) { }

	// RVA: 0x25147D0 Offset: 0x25139D0 VA: 0x1825147D0
	public byte get_italicStyleSlant() { }

	// RVA: 0x1C61C80 Offset: 0x1C60E80 VA: 0x181C61C80
	public void set_italicStyleSlant(byte value) { }

	// RVA: 0x2514850 Offset: 0x2513A50 VA: 0x182514850
	public byte get_tabMultiple() { }

	// RVA: 0x25149A0 Offset: 0x2513BA0 VA: 0x1825149A0
	public void set_tabMultiple(byte value) { }

	// RVA: 0x250C250 Offset: 0x250B450 VA: 0x18250C250
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	// RVA: 0x250C1A0 Offset: 0x250B3A0 VA: 0x18250C1A0
	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	// RVA: 0x250BF90 Offset: 0x250B190 VA: 0x18250BF90
	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 2, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x250C0E0 Offset: 0x250B2E0 VA: 0x18250C0E0
	public static FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x250C440 Offset: 0x250B640 VA: 0x18250C440
	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x250C4F0 Offset: 0x250B6F0 VA: 0x18250C4F0
	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x250BA50 Offset: 0x250AC50 VA: 0x18250BA50
	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Awake() { }

	// RVA: 0x250EA50 Offset: 0x250DC50 VA: 0x18250EA50
	private void OnDestroy() { }

	// RVA: 0x250EB80 Offset: 0x250DD80 VA: 0x18250EB80
	public void ReadFontAssetDefinition() { }

	// RVA: 0x250DAC0 Offset: 0x250CCC0 VA: 0x18250DAC0
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x250DCB0 Offset: 0x250CEB0 VA: 0x18250DCB0
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x250D900 Offset: 0x250CB00 VA: 0x18250D900
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x250E170 Offset: 0x250D370 VA: 0x18250E170
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	// RVA: 0x250DF10 Offset: 0x250D110 VA: 0x18250DF10
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x250E4E0 Offset: 0x250D6E0 VA: 0x18250E4E0
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x250E6D0 Offset: 0x250D8D0 VA: 0x18250E6D0
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x250B1D0 Offset: 0x250A3D0 VA: 0x18250B1D0
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x250AEE0 Offset: 0x250A0E0 VA: 0x18250AEE0
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = False) { }

	// RVA: 0x250AE70 Offset: 0x250A070 VA: 0x18250AE70
	internal void AddCharacterToLookupCache(uint unicode, Character character) { }

	// RVA: 0x250E8C0 Offset: 0x250DAC0 VA: 0x18250E8C0
	private FontEngineError LoadFontFace() { }

	// RVA: 0x250F740 Offset: 0x250E940 VA: 0x18250F740
	internal void SortCharacterTable() { }

	// RVA: 0x250F8E0 Offset: 0x250EAE0 VA: 0x18250F8E0
	internal void SortGlyphTable() { }

	// RVA: 0x250F890 Offset: 0x250EA90 VA: 0x18250F890
	internal void SortFontFeatureTable() { }

	// RVA: 0x250F490 Offset: 0x250E690 VA: 0x18250F490
	internal void SortAllTables() { }

	// RVA: 0x250D1F0 Offset: 0x250C3F0 VA: 0x18250D1F0
	public bool HasCharacter(int character) { }

	// RVA: 0x250D260 Offset: 0x250C460 VA: 0x18250D260
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x250CE80 Offset: 0x250C080 VA: 0x18250CE80
	public bool HasCharacter(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x250CC20 Offset: 0x250BE20 VA: 0x18250CC20
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x250D7B0 Offset: 0x250C9B0 VA: 0x18250D7B0
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x250D330 Offset: 0x250C530 VA: 0x18250D330
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x250D280 Offset: 0x250C480 VA: 0x18250D280
	public bool HasCharacters(string text) { }

	// RVA: 0x250CA40 Offset: 0x250BC40 VA: 0x18250CA40
	public static string GetCharacters(FontAsset fontAsset) { }

	// RVA: 0x250C960 Offset: 0x250BB60 VA: 0x18250C960
	public static int[] GetCharactersArray(FontAsset fontAsset) { }

	// RVA: 0x250CB40 Offset: 0x250BD40 VA: 0x18250CB40
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x250F0D0 Offset: 0x250E2D0 VA: 0x18250F0D0
	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	// RVA: 0x2513410 Offset: 0x2512610 VA: 0x182513410
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x250EFA0 Offset: 0x250E1A0 VA: 0x18250EFA0
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	// RVA: 0x2512D20 Offset: 0x2511F20 VA: 0x182512D20
	internal static void UpdateAtlasTexturesInQueue() { }

	// RVA: 0x25130B0 Offset: 0x25122B0 VA: 0x1825130B0
	internal static void UpdateFontAssetsInUpdateQueue() { }

	// RVA: 0x2510410 Offset: 0x250F610 VA: 0x182510410
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x2510440 Offset: 0x250F640 VA: 0x182510440
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x25103E0 Offset: 0x250F5E0 VA: 0x1825103E0
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x2511010 Offset: 0x2510210 VA: 0x182511010
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x2511B90 Offset: 0x2510D90 VA: 0x182511B90
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	// RVA: 0x250FA30 Offset: 0x250EC30 VA: 0x18250FA30
	internal bool TryAddCharacterInternal(uint unicode, out Character character, bool shouldGetFontFeatures = False) { }

	// RVA: 0x2512890 Offset: 0x2511A90 VA: 0x182512890
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out Character character, bool shouldGetFontFeatures = False) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void TryAddGlyphsToAtlasTextures() { }

	// RVA: 0x2512420 Offset: 0x2511620 VA: 0x182512420
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x250F210 Offset: 0x250E410 VA: 0x18250F210
	private void SetupNewAtlasTexture() { }

	// RVA: 0x2512CC0 Offset: 0x2511EC0 VA: 0x182512CC0
	private void UpdateAllFontFeatures() { }

	// RVA: 0x2513A00 Offset: 0x2512C00 VA: 0x182513A00
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x25135D0 Offset: 0x25127D0 VA: 0x1825135D0
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes) { }

	// RVA: -1 Offset: -1
	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AD590 Offset: 0x9AC790 VA: 0x1809AD590
	|-FontAsset.CopyListDataToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x250B640 Offset: 0x250A840 VA: 0x18250B640
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x250B610 Offset: 0x250A810 VA: 0x18250B610
	internal void ClearFontAssetDataInternal(bool clearFontFeatures = False) { }

	// RVA: 0x2512EA0 Offset: 0x25120A0 VA: 0x182512EA0
	internal void UpdateFontAssetData() { }

	// RVA: 0x250B760 Offset: 0x250A960 VA: 0x18250B760
	internal void ClearFontAssetTables(bool clearFontFeatures) { }

	// RVA: 0x250B3D0 Offset: 0x250A5D0 VA: 0x18250B3D0
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x250C870 Offset: 0x250BA70 VA: 0x18250C870
	private void DestroyAtlasTextures() { }

	// RVA: 0x25141F0 Offset: 0x25133F0 VA: 0x1825141F0
	public void .ctor() { }

	// RVA: 0x2513E80 Offset: 0x2513080 VA: 0x182513E80
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class FontAssetUtilities // TypeDefIndex: 16220
{
	// Fields
	private static HashSet<int> k_SearchedAssets; // 0x0

	// Methods

	// RVA: 0x250A750 Offset: 0x2509950 VA: 0x18250A750
	internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x250A270 Offset: 0x2509470 VA: 0x18250A270
	private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x250A850 Offset: 0x2509A50 VA: 0x18250A850
	public static Character GetCharacterFromFontAssets(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x250ABD0 Offset: 0x2509DD0 VA: 0x18250ABD0
	public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x250AA10 Offset: 0x2509C10 VA: 0x18250AA10
	private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FontFeatureTable.<>c // TypeDefIndex: 16221
{
	// Fields
	public static readonly FontFeatureTable.<>c <>9; // 0x0
	public static Func<GlyphPairAdjustmentRecord, uint> <>9__25_0; // 0x8
	public static Func<GlyphPairAdjustmentRecord, uint> <>9__25_1; // 0x10
	public static Func<MarkToBaseAdjustmentRecord, uint> <>9__26_0; // 0x18
	public static Func<MarkToBaseAdjustmentRecord, uint> <>9__26_1; // 0x20
	public static Func<MarkToMarkAdjustmentRecord, uint> <>9__27_0; // 0x28
	public static Func<MarkToMarkAdjustmentRecord, uint> <>9__27_1; // 0x30

	// Methods

	// RVA: 0x251ED90 Offset: 0x251DF90 VA: 0x18251ED90
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x251ECD0 Offset: 0x251DED0 VA: 0x18251ECD0
	internal uint <SortGlyphPairAdjustmentRecords>b__25_0(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x251ED10 Offset: 0x251DF10 VA: 0x18251ED10
	internal uint <SortGlyphPairAdjustmentRecords>b__25_1(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x251ED50 Offset: 0x251DF50 VA: 0x18251ED50
	internal uint <SortMarkToBaseAdjustmentRecords>b__26_0(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x251ED70 Offset: 0x251DF70 VA: 0x18251ED70
	internal uint <SortMarkToBaseAdjustmentRecords>b__26_1(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x251ED50 Offset: 0x251DF50 VA: 0x18251ED50
	internal uint <SortMarkToMarkAdjustmentRecords>b__27_0(MarkToMarkAdjustmentRecord s) { }

	// RVA: 0x251ED70 Offset: 0x251DF70 VA: 0x18251ED70
	internal uint <SortMarkToMarkAdjustmentRecords>b__27_1(MarkToMarkAdjustmentRecord s) { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class FontFeatureTable // TypeDefIndex: 16222
{
	// Fields
	[SerializeField]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; // 0x10
	[SerializeField]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; // 0x18
	[SerializeField]
	internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x20
	[SerializeField]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; // 0x28
	[SerializeField]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; // 0x30
	internal Dictionary<uint, List<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; // 0x38
	internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; // 0x40
	internal Dictionary<uint, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; // 0x48
	internal Dictionary<uint, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; // 0x50

	// Methods

	// RVA: 0x2514FC0 Offset: 0x25141C0 VA: 0x182514FC0
	internal void .ctor() { }

	// RVA: 0x25149C0 Offset: 0x2513BC0 VA: 0x1825149C0
	public void SortGlyphPairAdjustmentRecords() { }

	// RVA: 0x2514BC0 Offset: 0x2513DC0 VA: 0x182514BC0
	public void SortMarkToBaseAdjustmentRecords() { }

	// RVA: 0x2514DC0 Offset: 0x2513FC0 VA: 0x182514DC0
	public void SortMarkToMarkAdjustmentRecords() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct Extents // TypeDefIndex: 16223
{
	// Fields
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x250A0F0 Offset: 0x25092F0 VA: 0x18250A0F0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct LineInfo // TypeDefIndex: 16224
{
	// Fields
	internal int controlCharacterCount; // 0x0
	public int characterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int spaceCount; // 0xC
	public int visibleSpaceCount; // 0x10
	public int wordCount; // 0x14
	public int firstCharacterIndex; // 0x18
	public int firstVisibleCharacterIndex; // 0x1C
	public int lastCharacterIndex; // 0x20
	public int lastVisibleCharacterIndex; // 0x24
	public float length; // 0x28
	public float lineHeight; // 0x2C
	public float ascender; // 0x30
	public float baseline; // 0x34
	public float descender; // 0x38
	public float maxAdvance; // 0x3C
	public float width; // 0x40
	public float marginLeft; // 0x44
	public float marginRight; // 0x48
	public TextAlignment alignment; // 0x4C
	public Extents lineExtents; // 0x50
}

// Namespace: UnityEngine.TextCore.Text
internal struct LinkInfo // TypeDefIndex: 16225
{
	// Fields
	public int hashCode; // 0x0
	public int linkIdFirstCharacterIndex; // 0x4
	public int linkIdLength; // 0x8
	public int linkTextfirstCharacterIndex; // 0xC
	public int linkTextLength; // 0x10
	internal char[] linkId; // 0x18
	private string m_LinkIdString; // 0x20
	private string m_LinkTextString; // 0x28

	// Methods

	// RVA: 0x2515310 Offset: 0x2514510 VA: 0x182515310
	internal void SetLinkId(char[] text, int startIndex, int length) { }

	// RVA: 0x2515220 Offset: 0x2514420 VA: 0x182515220
	public string GetLinkText(TextInfo textInfo) { }

	// RVA: 0x25151D0 Offset: 0x25143D0 VA: 0x1825151D0
	public string GetLinkId() { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class MaterialManager // TypeDefIndex: 16226
{
	// Fields
	private static Dictionary<long, Material> s_FallbackMaterials; // 0x0

	// Methods

	// RVA: 0x25156E0 Offset: 0x25148E0 VA: 0x1825156E0
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x2515B10 Offset: 0x2514D10 VA: 0x182515B10
	public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x25153F0 Offset: 0x25145F0 VA: 0x1825153F0
	private static void CopyMaterialPresetProperties(Material source, Material destination) { }

	// RVA: 0x2516030 Offset: 0x2515230 VA: 0x182516030
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct MaterialReference // TypeDefIndex: 16227
{
	// Fields
	public int index; // 0x0
	public FontAsset fontAsset; // 0x8
	public SpriteAsset spriteAsset; // 0x10
	public Material material; // 0x18
	public bool isDefaultMaterial; // 0x20
	public bool isFallbackMaterial; // 0x21
	public Material fallbackMaterial; // 0x28
	public float padding; // 0x30
	public int referenceCount; // 0x34

	// Methods

	// RVA: 0x25171E0 Offset: 0x25163E0 VA: 0x1825171E0
	public void .ctor(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x2516DB0 Offset: 0x2515FB0 VA: 0x182516DB0
	public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0x2516FD0 Offset: 0x25161D0 VA: 0x182516FD0
	public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }
}

// Namespace: UnityEngine.TextCore.Text
internal class MaterialReferenceManager // TypeDefIndex: 16228
{
	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
	private Dictionary<int, TextColorGradient> m_ColorGradientReferenceLookup; // 0x28

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0x2516C30 Offset: 0x2515E30 VA: 0x182516C30
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x2516350 Offset: 0x2515550 VA: 0x182516350
	public static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x25161D0 Offset: 0x25153D0 VA: 0x1825161D0
	private void AddFontAssetInternal(FontAsset fontAsset) { }

	// RVA: 0x2516680 Offset: 0x2515880 VA: 0x182516680
	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x25165C0 Offset: 0x25157C0 VA: 0x1825165C0
	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x2516550 Offset: 0x2515750 VA: 0x182516550
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x25164E0 Offset: 0x25156E0 VA: 0x1825164E0
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x2516130 Offset: 0x2515330 VA: 0x182516130
	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x25160A0 Offset: 0x25152A0 VA: 0x1825160A0
	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x25168B0 Offset: 0x2515AB0 VA: 0x1825168B0
	public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset) { }

	// RVA: 0x2516840 Offset: 0x2515A40 VA: 0x182516840
	private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset) { }

	// RVA: 0x2516A90 Offset: 0x2515C90 VA: 0x182516A90
	public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset) { }

	// RVA: 0x2516A20 Offset: 0x2515C20 VA: 0x182516A20
	private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset) { }

	// RVA: 0x25167C0 Offset: 0x25159C0 VA: 0x1825167C0
	public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset) { }

	// RVA: 0x2516750 Offset: 0x2515950 VA: 0x182516750
	private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset) { }

	// RVA: 0x25169A0 Offset: 0x2515BA0 VA: 0x1825169A0
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0x2516930 Offset: 0x2515B30 VA: 0x182516930
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0x2516B10 Offset: 0x2515D10 VA: 0x182516B10
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal enum VertexSortingOrder // TypeDefIndex: 16229
{
	// Fields
	public int value__; // 0x0
	public const VertexSortingOrder Normal = 0;
	public const VertexSortingOrder Reverse = 1;
}

// Namespace: UnityEngine.TextCore.Text
internal struct MeshInfo // TypeDefIndex: 16230
{
	// Fields
	private static readonly Color32 k_DefaultColor; // 0x0
	private static readonly Vector3 k_DefaultNormal; // 0x4
	private static readonly Vector4 k_DefaultTangent; // 0x10
	public int vertexCount; // 0x0
	public Vector3[] vertices; // 0x8
	public Vector3[] normals; // 0x10
	public Vector4[] tangents; // 0x18
	public Vector4[] uvs0; // 0x20
	public Vector2[] uvs2; // 0x28
	public Color32[] colors32; // 0x30
	public int[] triangles; // 0x38
	public Material material; // 0x40
	internal GlyphRenderMode glyphRenderMode; // 0x48

	// Methods

	// RVA: 0x2517E00 Offset: 0x2517000 VA: 0x182517E00
	public void .ctor(int size) { }

	// RVA: 0x25172F0 Offset: 0x25164F0 VA: 0x1825172F0
	internal void ResizeMeshInfo(int size) { }

	// RVA: 0x25172B0 Offset: 0x25164B0 VA: 0x1825172B0
	internal void Clear(bool uploadChanges) { }

	// RVA: 0x2517270 Offset: 0x2516470 VA: 0x182517270
	internal void ClearUnusedVertices() { }

	// RVA: 0x25174F0 Offset: 0x25166F0 VA: 0x1825174F0
	internal void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x25175A0 Offset: 0x25167A0 VA: 0x1825175A0
	internal void SwapVertexData(int src, int dst) { }

	// RVA: 0x2517D70 Offset: 0x2516F70 VA: 0x182517D70
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SpriteAsset.<>c // TypeDefIndex: 16231
{
	// Fields
	public static readonly SpriteAsset.<>c <>9; // 0x0
	public static Func<SpriteGlyph, uint> <>9__37_0; // 0x8
	public static Func<SpriteCharacter, uint> <>9__38_0; // 0x10

	// Methods

	// RVA: 0x251EDF0 Offset: 0x251DFF0 VA: 0x18251EDF0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23F84B0 Offset: 0x23F76B0 VA: 0x1823F84B0
	internal uint <SortGlyphTable>b__37_0(SpriteGlyph item) { }

	// RVA: 0x23F8450 Offset: 0x23F7650 VA: 0x1823F8450
	internal uint <SortCharacterTable>b__38_0(SpriteCharacter c) { }
}

// Namespace: UnityEngine.TextCore.Text
[HelpURL("https://docs.unity3d.com/2022.3/Documentation/Manual/UIE-sprite.html")]
[ExcludeFromPreset]
public class SpriteAsset : TextAsset // TypeDefIndex: 16232
{
	// Fields
	internal Dictionary<int, int> m_NameLookup; // 0x38
	internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x40
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0x48
	[FormerlySerializedAs("spriteSheet")]
	[SerializeField]
	internal Texture m_SpriteAtlasTexture; // 0xA8
	[SerializeField]
	private List<SpriteCharacter> m_SpriteCharacterTable; // 0xB0
	internal Dictionary<uint, SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
	[SerializeField]
	private List<SpriteGlyph> m_SpriteGlyphTable; // 0xC0
	internal Dictionary<uint, SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
	[SerializeField]
	public List<SpriteAsset> fallbackSpriteAssets; // 0xD0
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xD8
	private static HashSet<int> k_searchedSpriteAssets; // 0x0

	// Properties
	public FaceInfo faceInfo { get; set; }
	public Texture spriteSheet { get; set; }
	public List<SpriteCharacter> spriteCharacterTable { get; set; }
	public Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable { get; set; }
	public List<SpriteGlyph> spriteGlyphTable { get; set; }

	// Methods

	// RVA: 0x2519910 Offset: 0x2518B10 VA: 0x182519910
	public FaceInfo get_faceInfo() { }

	// RVA: 0x2421F50 Offset: 0x2421150 VA: 0x182421F50
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x24CAD30 Offset: 0x24C9F30 VA: 0x1824CAD30
	public Texture get_spriteSheet() { }

	// RVA: 0xB83400 Offset: 0xB82600 VA: 0x180B83400
	internal void set_spriteSheet(Texture value) { }

	// RVA: 0x2519990 Offset: 0x2518B90 VA: 0x182519990
	public List<SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x88DF00 Offset: 0x88D100 VA: 0x18088DF00
	internal void set_spriteCharacterTable(List<SpriteCharacter> value) { }

	// RVA: 0x2519950 Offset: 0x2518B50 VA: 0x182519950
	public Dictionary<uint, SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x146AE20 Offset: 0x146A020 VA: 0x18146AE20
	internal void set_spriteCharacterLookupTable(Dictionary<uint, SpriteCharacter> value) { }

	// RVA: 0x24CAE00 Offset: 0x24CA000 VA: 0x1824CAE00
	public List<SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x718950 Offset: 0x717B50 VA: 0x180718950
	internal void set_spriteGlyphTable(List<SpriteGlyph> value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Awake() { }

	// RVA: 0x2519350 Offset: 0x2518550 VA: 0x182519350
	public void UpdateLookupTables() { }

	// RVA: 0x25182E0 Offset: 0x25174E0 VA: 0x1825182E0
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x25183B0 Offset: 0x25175B0 VA: 0x1825183B0
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	// RVA: 0x2518370 Offset: 0x2517570 VA: 0x182518370
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x2518C70 Offset: 0x2517E70 VA: 0x182518C70
	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x2518A20 Offset: 0x2517C20 VA: 0x182518A20
	private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x2518BB0 Offset: 0x2517DB0 VA: 0x182518BB0
	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x25186B0 Offset: 0x25178B0 VA: 0x1825186B0
	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings) { }

	// RVA: 0x2518450 Offset: 0x2517650 VA: 0x182518450
	private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x25185F0 Offset: 0x25177F0 VA: 0x1825185F0
	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x2519200 Offset: 0x2518400 VA: 0x182519200
	public void SortGlyphTable() { }

	// RVA: 0x2518E30 Offset: 0x2518030 VA: 0x182518E30
	internal void SortCharacterTable() { }

	// RVA: 0x2518F80 Offset: 0x2518180 VA: 0x182518F80
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x2519850 Offset: 0x2518A50 VA: 0x182519850
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteCharacter : TextElement // TypeDefIndex: 16233
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x30

	// Properties
	public string name { get; }

	// Methods

	// RVA: 0x2497C20 Offset: 0x2496E20 VA: 0x182497C20
	public string get_name() { }

	// RVA: 0x2422040 Offset: 0x2421240 VA: 0x182422040
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteGlyph : Glyph // TypeDefIndex: 16234
{
	// Fields
	public Sprite sprite; // 0x48

	// Methods

	// RVA: 0x24222D0 Offset: 0x24214D0 VA: 0x1824222D0
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromObjectFactory]
[Serializable]
public abstract class TextAsset : ScriptableObject // TypeDefIndex: 16235
{
	// Fields
	[SerializeField]
	internal string m_Version; // 0x18
	internal int m_InstanceID; // 0x20
	internal int m_HashCode; // 0x24
	[SerializeField]
	[FormerlySerializedAs("material")]
	internal Material m_Material; // 0x28
	internal int m_MaterialHashCode; // 0x30

	// Properties
	public string version { get; set; }
	public int instanceID { get; }
	public int hashCode { get; set; }
	public Material material { get; set; }
	public int materialHashCode { get; set; }

	// Methods

	// RVA: 0x248C210 Offset: 0x248B410 VA: 0x18248C210
	public string get_version() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_version(string value) { }

	// RVA: 0x2519A10 Offset: 0x2518C10 VA: 0x182519A10
	public int get_instanceID() { }

	// RVA: 0x25199D0 Offset: 0x2518BD0 VA: 0x1825199D0
	public int get_hashCode() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_hashCode(int value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Material get_material() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_material(Material value) { }

	// RVA: 0x2519A40 Offset: 0x2518C40 VA: 0x182519A40
	public int get_materialHashCode() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_materialHashCode(int value) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
public enum ColorGradientMode // TypeDefIndex: 16236
{
	// Fields
	public int value__; // 0x0
	public const ColorGradientMode Single = 0;
	public const ColorGradientMode HorizontalGradient = 1;
	public const ColorGradientMode VerticalGradient = 2;
	public const ColorGradientMode FourCornersGradient = 3;
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[Serializable]
public class TextColorGradient : ScriptableObject // TypeDefIndex: 16237
{
	// Fields
	public ColorGradientMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorGradientMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x2519B20 Offset: 0x2518D20 VA: 0x182519B20
	public void .ctor() { }

	// RVA: 0x23D76D0 Offset: 0x23D68D0 VA: 0x1823D76D0
	public void .ctor(Color color) { }

	// RVA: 0x23D7720 Offset: 0x23D6920 VA: 0x1823D7720
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x2519AE0 Offset: 0x2518CE0 VA: 0x182519AE0
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
public enum TextElementType // TypeDefIndex: 16238
{
	// Fields
	public byte value__; // 0x0
	public const TextElementType Character = 1;
	public const TextElementType Sprite = 2;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public abstract class TextElement // TypeDefIndex: 16239
{
	// Fields
	[SerializeField]
	protected TextElementType m_ElementType; // 0x10
	[SerializeField]
	internal uint m_Unicode; // 0x14
	internal TextAsset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField]
	internal uint m_GlyphIndex; // 0x28
	[SerializeField]
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TextAsset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x251BB20 Offset: 0x251AD20 VA: 0x18251BB20
	public TextElementType get_elementType() { }

	// RVA: 0x10EBDC0 Offset: 0x10EAFC0 VA: 0x1810EBDC0
	public uint get_unicode() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_unicode(uint value) { }

	// RVA: 0x248C210 Offset: 0x248B410 VA: 0x18248C210
	public TextAsset get_textAsset() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_textAsset(TextAsset value) { }

	// RVA: 0x2497C30 Offset: 0x2496E30 VA: 0x182497C30
	public Glyph get_glyph() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_glyph(Glyph value) { }

	// RVA: 0xC9F3C0 Offset: 0xC9E5C0 VA: 0x180C9F3C0
	public uint get_glyphIndex() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_glyphIndex(uint value) { }

	// RVA: 0x24E2910 Offset: 0x24E1B10 VA: 0x1824E2910
	public float get_scale() { }

	// RVA: 0x498F90 Offset: 0x498190 VA: 0x180498F90
	public void set_scale(float value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct TextVertex // TypeDefIndex: 16240
{
	// Fields
	public Vector3 position; // 0x0
	public Vector4 uv; // 0xC
	public Vector2 uv2; // 0x1C
	public Color32 color; // 0x24
}

// Namespace: UnityEngine.TextCore.Text
internal struct TextElementInfo // TypeDefIndex: 16241
{
	// Fields
	public char character; // 0x0
	public int index; // 0x4
	public TextElementType elementType; // 0x8
	public int stringLength; // 0xC
	public TextElement textElement; // 0x10
	public Glyph alternativeGlyph; // 0x18
	public FontAsset fontAsset; // 0x20
	public SpriteAsset spriteAsset; // 0x28
	public int spriteIndex; // 0x30
	public Material material; // 0x38
	public int materialReferenceIndex; // 0x40
	public bool isUsingAlternateTypeface; // 0x44
	public float pointSize; // 0x48
	public int lineNumber; // 0x4C
	public int pageNumber; // 0x50
	public int vertexIndex; // 0x54
	public TextVertex vertexTopLeft; // 0x58
	public TextVertex vertexBottomLeft; // 0x80
	public TextVertex vertexTopRight; // 0xA8
	public TextVertex vertexBottomRight; // 0xD0
	public Vector3 topLeft; // 0xF8
	public Vector3 bottomLeft; // 0x104
	public Vector3 topRight; // 0x110
	public Vector3 bottomRight; // 0x11C
	public float origin; // 0x128
	public float ascender; // 0x12C
	public float baseLine; // 0x130
	public float descender; // 0x134
	internal float adjustedAscender; // 0x138
	internal float adjustedDescender; // 0x13C
	internal float adjustedHorizontalAdvance; // 0x140
	public float xAdvance; // 0x144
	public float aspectRatio; // 0x148
	public float scale; // 0x14C
	public Color32 color; // 0x150
	public Color32 underlineColor; // 0x154
	public int underlineVertexIndex; // 0x158
	public Color32 strikethroughColor; // 0x15C
	public int strikethroughVertexIndex; // 0x160
	public Color32 highlightColor; // 0x164
	public HighlightState highlightState; // 0x168
	public FontStyles style; // 0x17C
	public bool isVisible; // 0x180

	// Methods

	// RVA: 0x2519BD0 Offset: 0x2518DD0 VA: 0x182519BD0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.TextCore.Text
internal class TextGenerationSettings : IEquatable<TextGenerationSettings> // TypeDefIndex: 16242
{
	// Fields
	public string text; // 0x10
	public Rect screenRect; // 0x18
	public Vector4 margins; // 0x28
	public float scale; // 0x38
	public FontAsset fontAsset; // 0x40
	public Material material; // 0x48
	public SpriteAsset spriteAsset; // 0x50
	public TextStyleSheet styleSheet; // 0x58
	public FontStyles fontStyle; // 0x60
	public TextSettings textSettings; // 0x68
	public TextAlignment textAlignment; // 0x70
	public TextOverflowMode overflowMode; // 0x74
	public bool wordWrap; // 0x78
	public float wordWrappingRatio; // 0x7C
	public Color color; // 0x80
	public TextColorGradient fontColorGradient; // 0x90
	public TextColorGradient fontColorGradientPreset; // 0x98
	public bool tintSprites; // 0xA0
	public bool overrideRichTextColors; // 0xA1
	public bool shouldConvertToLinearSpace; // 0xA2
	public float fontSize; // 0xA4
	public bool autoSize; // 0xA8
	public float fontSizeMin; // 0xAC
	public float fontSizeMax; // 0xB0
	public bool enableKerning; // 0xB4
	public bool richText; // 0xB5
	public bool isRightToLeft; // 0xB6
	public float extraPadding; // 0xB8
	public bool parseControlCharacters; // 0xBC
	public bool isOrthographic; // 0xBD
	public bool tagNoParsing; // 0xBE
	public float characterSpacing; // 0xC0
	public float wordSpacing; // 0xC4
	public float lineSpacing; // 0xC8
	public float paragraphSpacing; // 0xCC
	public float lineSpacingMax; // 0xD0
	public TextWrappingMode textWrappingMode; // 0xD4
	public int maxVisibleCharacters; // 0xD8
	public int maxVisibleWords; // 0xDC
	public int maxVisibleLines; // 0xE0
	public int firstVisibleCharacter; // 0xE4
	public bool useMaxVisibleDescender; // 0xE8
	public TextFontWeight fontWeight; // 0xEC
	public int pageToDisplay; // 0xF0
	public TextureMapping horizontalMapping; // 0xF4
	public TextureMapping verticalMapping; // 0xF8
	public float uvLineOffset; // 0xFC
	public VertexSortingOrder geometrySortingOrder; // 0x100
	public bool inverseYAxis; // 0x104
	public float charWidthMaxAdj; // 0x108
	internal TextInputSource inputSource; // 0x10C

	// Methods

	// RVA: 0x251BB30 Offset: 0x251AD30 VA: 0x18251BB30 Slot: 4
	public bool Equals(TextGenerationSettings other) { }

	// RVA: 0x251C130 Offset: 0x251B330 VA: 0x18251C130 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x251C250 Offset: 0x251B450 VA: 0x18251C250 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x251ECC0 Offset: 0x251DEC0 VA: 0x18251ECC0
	public static bool op_Equality(TextGenerationSettings left, TextGenerationSettings right) { }

	// RVA: 0x251C7F0 Offset: 0x251B9F0 VA: 0x18251C7F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x251EC00 Offset: 0x251DE00 VA: 0x18251EC00
	public void .ctor() { }
}

// Namespace: 
public sealed class TextGenerator.MissingCharacterEventCallback : MulticastDelegate // TypeDefIndex: 16243
{
	// Methods

	// RVA: 0x253AC10 Offset: 0x2539E10 VA: 0x18253AC10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(uint unicode, int stringIndex, TextInfo text, FontAsset fontAsset) { }
}

// Namespace: 
protected struct TextGenerator.SpecialCharacter // TypeDefIndex: 16244
{
	// Fields
	public Character character; // 0x0
	public FontAsset fontAsset; // 0x8
	public Material material; // 0x10
	public int materialIndex; // 0x18

	// Methods

	// RVA: 0x253AE00 Offset: 0x253A000 VA: 0x18253AE00
	public void .ctor(Character character, int materialIndex) { }
}

// Namespace: UnityEngine.TextCore.Text
internal class TextGenerator // TypeDefIndex: 16245
{
	// Fields
	private static TextGenerator s_TextGenerator; // 0x0
	private TextBackingContainer m_TextBackingArray; // 0x10
	internal TextProcessingElement[] m_TextProcessingArray; // 0x20
	internal int m_InternalTextProcessingArraySize; // 0x28
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; // 0x2C
	private char[] m_HtmlTag; // 0x30
	internal HighlightState m_HighlightState; // 0x38
	protected bool m_IsIgnoringAlignment; // 0x4C
	protected static bool m_IsTextTruncated; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static TextGenerator.MissingCharacterEventCallback OnMissingCharacter; // 0x10
	private Vector3[] m_RectTransformCorners; // 0x50
	private float m_MarginWidth; // 0x58
	private float m_MarginHeight; // 0x5C
	private float m_PreferredWidth; // 0x60
	private float m_PreferredHeight; // 0x64
	private FontAsset m_CurrentFontAsset; // 0x68
	private Material m_CurrentMaterial; // 0x70
	private int m_CurrentMaterialIndex; // 0x78
	private TextProcessingStack<MaterialReference> m_MaterialReferenceStack; // 0x80
	private float m_Padding; // 0xD8
	private SpriteAsset m_CurrentSpriteAsset; // 0xE0
	private int m_TotalCharacterCount; // 0xE8
	private float m_FontSize; // 0xEC
	private float m_FontScaleMultiplier; // 0xF0
	private float m_CurrentFontSize; // 0xF4
	private TextProcessingStack<float> m_SizeStack; // 0xF8
	protected TextProcessingStack<int>[] m_TextStyleStacks; // 0x118
	protected int m_TextStyleStackDepth; // 0x120
	private FontStyles m_FontStyleInternal; // 0x124
	private FontStyleStack m_FontStyleStack; // 0x128
	private TextFontWeight m_FontWeightInternal; // 0x134
	private TextProcessingStack<TextFontWeight> m_FontWeightStack; // 0x138
	private TextAlignment m_LineJustification; // 0x158
	private TextProcessingStack<TextAlignment> m_LineJustificationStack; // 0x160
	private float m_BaselineOffset; // 0x180
	private TextProcessingStack<float> m_BaselineOffsetStack; // 0x188
	private Color32 m_FontColor32; // 0x1A8
	private Color32 m_HtmlColor; // 0x1AC
	private Color32 m_UnderlineColor; // 0x1B0
	private Color32 m_StrikethroughColor; // 0x1B4
	private TextProcessingStack<Color32> m_ColorStack; // 0x1B8
	private TextProcessingStack<Color32> m_UnderlineColorStack; // 0x1D8
	private TextProcessingStack<Color32> m_StrikethroughColorStack; // 0x1F8
	private TextProcessingStack<Color32> m_HighlightColorStack; // 0x218
	private TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x238
	private TextProcessingStack<int> m_ItalicAngleStack; // 0x268
	private TextColorGradient m_ColorGradientPreset; // 0x288
	private TextProcessingStack<TextColorGradient> m_ColorGradientStack; // 0x290
	private bool m_ColorGradientPresetIsTinted; // 0x2B8
	private TextProcessingStack<int> m_ActionStack; // 0x2C0
	private float m_LineOffset; // 0x2E0
	private float m_LineHeight; // 0x2E4
	private bool m_IsDrivenLineSpacing; // 0x2E8
	private float m_CSpacing; // 0x2EC
	private float m_MonoSpacing; // 0x2F0
	private float m_XAdvance; // 0x2F4
	private float m_TagLineIndent; // 0x2F8
	private float m_TagIndent; // 0x2FC
	private TextProcessingStack<float> m_IndentStack; // 0x300
	private bool m_TagNoParsing; // 0x320
	private int m_CharacterCount; // 0x324
	private int m_FirstCharacterOfLine; // 0x328
	private int m_LastCharacterOfLine; // 0x32C
	private int m_FirstVisibleCharacterOfLine; // 0x330
	private int m_LastVisibleCharacterOfLine; // 0x334
	private float m_MaxLineAscender; // 0x338
	private float m_MaxLineDescender; // 0x33C
	private int m_LineNumber; // 0x340
	private int m_LineVisibleCharacterCount; // 0x344
	private int m_LineVisibleSpaceCount; // 0x348
	private int m_FirstOverflowCharacterIndex; // 0x34C
	private int m_PageNumber; // 0x350
	private float m_MarginLeft; // 0x354
	private float m_MarginRight; // 0x358
	private float m_Width; // 0x35C
	private Extents m_MeshExtents; // 0x360
	private float m_MaxCapHeight; // 0x370
	private float m_MaxAscender; // 0x374
	private float m_MaxDescender; // 0x378
	private bool m_IsNewPage; // 0x37C
	private bool m_IsNonBreakingSpace; // 0x37D
	private WordWrapState m_SavedWordWrapState; // 0x380
	private WordWrapState m_SavedLineState; // 0x718
	private WordWrapState m_SavedEllipsisState; // 0xAB0
	private WordWrapState m_SavedLastValidState; // 0xE48
	private WordWrapState m_SavedSoftLineBreakState; // 0x11E0
	private TextElementType m_TextElementType; // 0x1578
	private bool m_isTextLayoutPhase; // 0x1579
	private int m_SpriteIndex; // 0x157C
	private Color32 m_SpriteColor; // 0x1580
	private TextElement m_CachedTextElement; // 0x1588
	private Color32 m_HighlightColor; // 0x1590
	private float m_CharWidthAdjDelta; // 0x1594
	private float m_MaxFontSize; // 0x1598
	private float m_MinFontSize; // 0x159C
	private int m_AutoSizeIterationCount; // 0x15A0
	private int m_AutoSizeMaxIterationCount; // 0x15A4
	private bool m_IsAutoSizePointSizeSet; // 0x15A8
	private float m_StartOfLineAscender; // 0x15AC
	private float m_LineSpacingDelta; // 0x15B0
	private MaterialReference[] m_MaterialReferences; // 0x15B8
	private int m_SpriteCount; // 0x15C0
	private TextProcessingStack<int> m_StyleStack; // 0x15C8
	private TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x15E8
	private int m_SpriteAnimationId; // 0x19A0
	private int m_ItalicAngle; // 0x19A4
	private Vector3 m_FXScale; // 0x19A8
	private Quaternion m_FXRotation; // 0x19B4
	private int m_LastBaseGlyphIndex; // 0x19C4
	private float m_PageAscender; // 0x19C8
	private RichTextTagAttribute[] m_XmlAttribute; // 0x19D0
	private float[] m_AttributeParameterValues; // 0x19D8
	private Dictionary<int, int> m_MaterialReferenceIndexLookup; // 0x19E0
	private bool m_IsCalculatingPreferredValues; // 0x19E8
	private SpriteAsset m_DefaultSpriteAsset; // 0x19F0
	private bool m_TintSprite; // 0x19F8
	protected TextGenerator.SpecialCharacter m_Ellipsis; // 0x1A00
	protected TextGenerator.SpecialCharacter m_Underline; // 0x1A20
	private TextElementInfo[] m_InternalTextElementInfo; // 0x1A40

	// Properties
	public static bool isTextTruncated { get; }

	// Methods

	// RVA: 0x252EDF0 Offset: 0x252DFF0 VA: 0x18252EDF0
	private static TextGenerator GetTextGenerator() { }

	// RVA: 0x252E1A0 Offset: 0x252D3A0 VA: 0x18252E1A0
	public static void GenerateText(TextGenerationSettings settings, TextInfo textInfo) { }

	// RVA: 0x252E6D0 Offset: 0x252D8D0 VA: 0x18252E6D0
	public static Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo) { }

	// RVA: 0x253A850 Offset: 0x2539A50 VA: 0x18253A850
	public static bool get_isTextTruncated() { }

	// RVA: 0x25306F0 Offset: 0x252F8F0 VA: 0x1825306F0
	private void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x251EEB0 Offset: 0x251E0B0 VA: 0x18251EEB0
	private void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2532D20 Offset: 0x2531F20 VA: 0x182532D20
	private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo) { }

	// RVA: 0x2530A60 Offset: 0x252FC60 VA: 0x182530A60
	protected int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo) { }

	// RVA: 0x2534B40 Offset: 0x2533D40 VA: 0x182534B40
	protected bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2530EC0 Offset: 0x25300C0 VA: 0x182530EC0
	private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2532270 Offset: 0x2531470 VA: 0x182532270
	private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x252D160 Offset: 0x252C360 VA: 0x18252D160
	private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x252C9D0 Offset: 0x252BBD0 VA: 0x18252C9D0
	private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x252C820 Offset: 0x252BA20 VA: 0x18252C820
	private static void ClearMesh(bool updateMesh, TextInfo textInfo) { }

	// RVA: 0x2533190 Offset: 0x2532390 VA: 0x182533190
	internal int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x252EA80 Offset: 0x252DC80 VA: 0x18252EA80
	internal TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x252C850 Offset: 0x252BA50 VA: 0x18252C850
	private void ComputeMarginSize(Rect rect, Vector4 margins) { }

	// RVA: 0x252E9C0 Offset: 0x252DBC0 VA: 0x18252E9C0
	protected void GetSpecialCharacters(TextGenerationSettings generationSettings) { }

	// RVA: 0x252E330 Offset: 0x252D530 VA: 0x18252E330
	protected void GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x252EE70 Offset: 0x252E070 VA: 0x18252EE70
	protected void GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x252E540 Offset: 0x252D740 VA: 0x18252E540
	private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2529290 Offset: 0x2528490 VA: 0x182529290 Slot: 4
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingMode textWrapMode, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x252F890 Offset: 0x252EA90 VA: 0x18252F890
	private void PopulateTextBackingArray(string sourceText) { }

	// RVA: 0x252F7A0 Offset: 0x252E9A0 VA: 0x18252F7A0
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	// RVA: 0x252F980 Offset: 0x252EB80 VA: 0x18252F980
	private void PopulateTextProcessingArray(TextGenerationSettings generationSettings) { }

	// RVA: 0x252EF20 Offset: 0x252E120 VA: 0x18252EF20
	private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x252C950 Offset: 0x252BB50 VA: 0x18252C950
	protected void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo) { }

	// RVA: 0x252C7C0 Offset: 0x252B9C0 VA: 0x18252C7C0
	private void ClearMarkupTagAttributes() { }

	// RVA: 0x2539FA0 Offset: 0x25391A0 VA: 0x182539FA0
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextAlignment // TypeDefIndex: 16246
{
	// Fields
	public int value__; // 0x0
	public const TextAlignment TopLeft = 257;
	public const TextAlignment TopCenter = 258;
	public const TextAlignment TopRight = 260;
	public const TextAlignment TopJustified = 264;
	public const TextAlignment TopFlush = 272;
	public const TextAlignment TopGeoAligned = 288;
	public const TextAlignment MiddleLeft = 513;
	public const TextAlignment MiddleCenter = 514;
	public const TextAlignment MiddleRight = 516;
	public const TextAlignment MiddleJustified = 520;
	public const TextAlignment MiddleFlush = 528;
	public const TextAlignment MiddleGeoAligned = 544;
	public const TextAlignment BottomLeft = 1025;
	public const TextAlignment BottomCenter = 1026;
	public const TextAlignment BottomRight = 1028;
	public const TextAlignment BottomJustified = 1032;
	public const TextAlignment BottomFlush = 1040;
	public const TextAlignment BottomGeoAligned = 1056;
	public const TextAlignment BaselineLeft = 2049;
	public const TextAlignment BaselineCenter = 2050;
	public const TextAlignment BaselineRight = 2052;
	public const TextAlignment BaselineJustified = 2056;
	public const TextAlignment BaselineFlush = 2064;
	public const TextAlignment BaselineGeoAligned = 2080;
	public const TextAlignment MidlineLeft = 4097;
	public const TextAlignment MidlineCenter = 4098;
	public const TextAlignment MidlineRight = 4100;
	public const TextAlignment MidlineJustified = 4104;
	public const TextAlignment MidlineFlush = 4112;
	public const TextAlignment MidlineGeoAligned = 4128;
	public const TextAlignment CaplineLeft = 8193;
	public const TextAlignment CaplineCenter = 8194;
	public const TextAlignment CaplineRight = 8196;
	public const TextAlignment CaplineJustified = 8200;
	public const TextAlignment CaplineFlush = 8208;
	public const TextAlignment CaplineGeoAligned = 8224;
}

// Namespace: UnityEngine.TextCore.Text
[Flags]
public enum FontStyles // TypeDefIndex: 16247
{
	// Fields
	public int value__; // 0x0
	public const FontStyles Normal = 0;
	public const FontStyles Bold = 1;
	public const FontStyles Italic = 2;
	public const FontStyles Underline = 4;
	public const FontStyles LowerCase = 8;
	public const FontStyles UpperCase = 16;
	public const FontStyles SmallCaps = 32;
	public const FontStyles Strikethrough = 64;
	public const FontStyles Superscript = 128;
	public const FontStyles Subscript = 256;
	public const FontStyles Highlight = 512;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextOverflowMode // TypeDefIndex: 16248
{
	// Fields
	public int value__; // 0x0
	public const TextOverflowMode Overflow = 0;
	public const TextOverflowMode Ellipsis = 1;
	public const TextOverflowMode Masking = 2;
	public const TextOverflowMode Truncate = 3;
	public const TextOverflowMode ScrollRect = 4;
	public const TextOverflowMode Page = 5;
	public const TextOverflowMode Linked = 6;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextureMapping // TypeDefIndex: 16249
{
	// Fields
	public int value__; // 0x0
	public const TextureMapping Character = 0;
	public const TextureMapping Line = 1;
	public const TextureMapping Paragraph = 2;
	public const TextureMapping MatchAspect = 3;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextWrappingMode // TypeDefIndex: 16250
{
	// Fields
	public int value__; // 0x0
	public const TextWrappingMode NoWrap = 0;
	public const TextWrappingMode Normal = 1;
	public const TextWrappingMode PreserveWhitespace = 2;
	public const TextWrappingMode PreserveWhitespaceNoWrap = 3;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextInputSource // TypeDefIndex: 16251
{
	// Fields
	public int value__; // 0x0
	public const TextInputSource TextInputBox = 0;
	public const TextInputSource SetText = 1;
	public const TextInputSource SetTextArray = 2;
	public const TextInputSource TextString = 3;
}

// Namespace: UnityEngine.TextCore.Text
internal struct RichTextTagAttribute // TypeDefIndex: 16252
{
	// Fields
	public int nameHashCode; // 0x0
	public int valueHashCode; // 0x4
	public TagValueType valueType; // 0x8
	public int valueStartIndex; // 0xC
	public int valueLength; // 0x10
	public TagUnitType unitType; // 0x14
}

// Namespace: UnityEngine.TextCore.Text
[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
internal struct TextProcessingElement // TypeDefIndex: 16253
{
	// Fields
	public TextProcessingElementType elementType; // 0x0
	public uint unicode; // 0x4
	public int stringIndex; // 0x8
	public int length; // 0xC
}

// Namespace: UnityEngine.TextCore.Text
[DefaultMember("Item")]
internal struct TextBackingContainer // TypeDefIndex: 16254
{
	// Fields
	private uint[] m_Array; // 0x0
	private int m_Count; // 0x8

	// Properties
	public int Capacity { get; }
	public int Count { get; set; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0x11BF2B0 Offset: 0x11BE4B0 VA: 0x1811BF2B0
	public int get_Capacity() { }

	// RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000
	public int get_Count() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Count(int value) { }

	// RVA: 0x12175B0 Offset: 0x12167B0 VA: 0x1812175B0
	public uint get_Item(int index) { }

	// RVA: 0x253AFA0 Offset: 0x253A1A0 VA: 0x18253AFA0
	public void set_Item(int index, uint value) { }

	// RVA: 0x253AF50 Offset: 0x253A150 VA: 0x18253AF50
	public void .ctor(int size) { }

	// RVA: 0x253AF00 Offset: 0x253A100 VA: 0x18253AF00
	public void Resize(int size) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct CharacterSubstitution // TypeDefIndex: 16255
{
	// Fields
	public int index; // 0x0
	public uint unicode; // 0x4

	// Methods

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void .ctor(int index, uint unicode) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct Offset // TypeDefIndex: 16256
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; }
	public float right { get; }
	public float top { get; }
	public float bottom { get; }
	public static Offset zero { get; }

	// Methods

	// RVA: 0x758EB0 Offset: 0x7580B0 VA: 0x180758EB0
	public float get_left() { }

	// RVA: 0x758EC0 Offset: 0x7580C0 VA: 0x180758EC0
	public float get_right() { }

	// RVA: 0x576F00 Offset: 0x576100 VA: 0x180576F00
	public float get_top() { }

	// RVA: 0x576EF0 Offset: 0x5760F0 VA: 0x180576EF0
	public float get_bottom() { }

	// RVA: 0x253ADA0 Offset: 0x2539FA0 VA: 0x18253ADA0
	public static Offset get_zero() { }

	// RVA: 0x1A1AC10 Offset: 0x1A19E10 VA: 0x181A1AC10
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x1996670 Offset: 0x1995870 VA: 0x181996670
	public static bool op_Equality(Offset lhs, Offset rhs) { }

	// RVA: 0x24779C0 Offset: 0x2476BC0 VA: 0x1824779C0
	public static Offset op_Multiply(Offset a, float b) { }

	// RVA: 0x253AD10 Offset: 0x2539F10 VA: 0x18253AD10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x253ACB0 Offset: 0x2539EB0 VA: 0x18253ACB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x253AD60 Offset: 0x2539F60 VA: 0x18253AD60
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct HighlightState // TypeDefIndex: 16257
{
	// Fields
	public Color32 color; // 0x0
	public Offset padding; // 0x4

	// Methods

	// RVA: 0x13145C0 Offset: 0x13137C0 VA: 0x1813145C0
	public void .ctor(Color32 color, Offset padding) { }

	// RVA: 0x253A990 Offset: 0x2539B90 VA: 0x18253A990
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x253AAD0 Offset: 0x2539CD0 VA: 0x18253AAD0
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x253A930 Offset: 0x2539B30 VA: 0x18253A930 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x253A8C0 Offset: 0x2539AC0 VA: 0x18253A8C0 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct WordWrapState // TypeDefIndex: 16258
{
	// Fields
	public int previousWordBreak; // 0x0
	public int totalCharacterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int visibleSpaceCount; // 0xC
	public int visibleSpriteCount; // 0x10
	public int visibleLinkCount; // 0x14
	public int firstCharacterIndex; // 0x18
	public int firstVisibleCharacterIndex; // 0x1C
	public int lastCharacterIndex; // 0x20
	public int lastVisibleCharIndex; // 0x24
	public int lineNumber; // 0x28
	public float maxCapHeight; // 0x2C
	public float maxAscender; // 0x30
	public float maxDescender; // 0x34
	public float maxLineAscender; // 0x38
	public float maxLineDescender; // 0x3C
	public float startOfLineAscender; // 0x40
	public float xAdvance; // 0x44
	public float preferredWidth; // 0x48
	public float preferredHeight; // 0x4C
	public float previousLineScale; // 0x50
	public float pageAscender; // 0x54
	public int wordCount; // 0x58
	public FontStyles fontStyle; // 0x5C
	public float fontScale; // 0x60
	public float fontScaleMultiplier; // 0x64
	public int italicAngle; // 0x68
	public float currentFontSize; // 0x6C
	public float baselineOffset; // 0x70
	public float lineOffset; // 0x74
	public TextInfo textInfo; // 0x78
	public LineInfo lineInfo; // 0x80
	public Color32 vertexColor; // 0xE0
	public Color32 underlineColor; // 0xE4
	public Color32 strikethroughColor; // 0xE8
	public Color32 highlightColor; // 0xEC
	public HighlightState highlightState; // 0xF0
	public FontStyleStack basicStyleStack; // 0x104
	public TextProcessingStack<int> italicAngleStack; // 0x110
	public TextProcessingStack<Color32> colorStack; // 0x130
	public TextProcessingStack<Color32> underlineColorStack; // 0x150
	public TextProcessingStack<Color32> strikethroughColorStack; // 0x170
	public TextProcessingStack<Color32> highlightColorStack; // 0x190
	public TextProcessingStack<HighlightState> highlightStateStack; // 0x1B0
	public TextProcessingStack<TextColorGradient> colorGradientStack; // 0x1E0
	public TextProcessingStack<float> sizeStack; // 0x208
	public TextProcessingStack<float> indentStack; // 0x228
	public TextProcessingStack<TextFontWeight> fontWeightStack; // 0x248
	public TextProcessingStack<int> styleStack; // 0x268
	public TextProcessingStack<float> baselineStack; // 0x288
	public TextProcessingStack<int> actionStack; // 0x2A8
	public TextProcessingStack<MaterialReference> materialReferenceStack; // 0x2C8
	public TextProcessingStack<TextAlignment> lineJustificationStack; // 0x320
	public int lastBaseGlyphIndex; // 0x340
	public int spriteAnimationId; // 0x344
	public FontAsset currentFontAsset; // 0x348
	public SpriteAsset currentSpriteAsset; // 0x350
	public Material currentMaterial; // 0x358
	public int currentMaterialIndex; // 0x360
	public Extents meshExtents; // 0x364
	public bool tagNoParsing; // 0x374
	public bool isNonBreakingSpace; // 0x375
	public bool isDrivenLineSpacing; // 0x376
	public Vector3 fxScale; // 0x378
	public Quaternion fxRotation; // 0x384
}

// Namespace: UnityEngine.TextCore.Text
[Extension]
internal static class TextGeneratorUtilities // TypeDefIndex: 16259
{
	// Fields
	public static readonly Vector2 largePositiveVector2; // 0x0
	public static readonly Vector2 largeNegativeVector2; // 0x8

	// Methods

	// RVA: 0x253B3C0 Offset: 0x253A5C0 VA: 0x18253B3C0
	public static bool Approximately(float a, float b) { }

	// RVA: 0x253D880 Offset: 0x253CA80 VA: 0x18253D880
	public static Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x253DF40 Offset: 0x253D140 VA: 0x18253DF40
	public static Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x253E1C0 Offset: 0x253D3C0 VA: 0x18253E1C0
	public static uint HexToInt(char hex) { }

	// RVA: 0x253B580 Offset: 0x253A780 VA: 0x18253B580
	public static float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x253B3F0 Offset: 0x253A5F0 VA: 0x18253B3F0
	public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x253EFF0 Offset: 0x253E1F0 VA: 0x18253EFF0
	public static Vector2 PackUV(float x, float y, float scale) { }

	// RVA: -1 Offset: -1
	public static void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA86990 Offset: 0xA85B90 VA: 0x180A86990
	|-TextGeneratorUtilities.ResizeInternalArray<TextProcessingElement>
	|
	|-RVA: 0xA868D0 Offset: 0xA85AD0 VA: 0x180A868D0
	|-TextGeneratorUtilities.ResizeInternalArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA869F0 Offset: 0xA85BF0 VA: 0x180A869F0
	|-TextGeneratorUtilities.ResizeInternalArray<TextProcessingElement>
	|
	|-RVA: 0xA86930 Offset: 0xA85B30 VA: 0x180A86930
	|-TextGeneratorUtilities.ResizeInternalArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x253E5C0 Offset: 0x253D7C0 VA: 0x18253E5C0
	internal static void InsertOpeningTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x253E3E0 Offset: 0x253D5E0 VA: 0x18253E3E0
	internal static void InsertClosingTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x253F160 Offset: 0x253E360 VA: 0x18253F160
	public static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x253F350 Offset: 0x253E550 VA: 0x18253F350
	private static bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x253F030 Offset: 0x253E230 VA: 0x18253F030
	public static void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x253E4D0 Offset: 0x253D6D0 VA: 0x18253E4D0
	internal static void InsertOpeningStyleTag(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x253E2E0 Offset: 0x253D4E0 VA: 0x18253E2E0
	internal static void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x253E6B0 Offset: 0x253D8B0 VA: 0x18253E6B0
	private static void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x253D2A0 Offset: 0x253C4A0 VA: 0x18253D2A0
	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) { }

	// RVA: 0x253D1B0 Offset: 0x253C3B0 VA: 0x18253D1B0
	public static int GetStyleHashCode(ref uint[] text, int index, out int closeIndex) { }

	// RVA: 0x253D0C0 Offset: 0x253C2C0 VA: 0x18253D0C0
	public static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	// RVA: 0x253D490 Offset: 0x253C690 VA: 0x18253D490
	public static uint GetUTF16(uint[] text, int i) { }

	// RVA: 0x253D390 Offset: 0x253C590 VA: 0x18253D390
	public static uint GetUTF16(TextBackingContainer text, int i) { }

	// RVA: 0x253D570 Offset: 0x253C770 VA: 0x18253D570
	public static uint GetUTF32(uint[] text, int i) { }

	// RVA: 0x253D6D0 Offset: 0x253C8D0 VA: 0x18253D6D0
	public static uint GetUTF32(TextBackingContainer text, int i) { }

	// RVA: 0x253B610 Offset: 0x253A810 VA: 0x18253B610
	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x253C1B0 Offset: 0x253B3B0 VA: 0x18253C1B0
	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x253B030 Offset: 0x253A230 VA: 0x18253B030
	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) { }

	// RVA: 0x253F540 Offset: 0x253E740 VA: 0x18253F540
	public static void ResizeLineExtents(int size, TextInfo textInfo) { }

	// RVA: 0x253EF60 Offset: 0x253E160 VA: 0x18253EF60
	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) { }

	// RVA: 0x253EEE0 Offset: 0x253E0E0 VA: 0x18253EEE0
	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) { }

	// RVA: 0x253B600 Offset: 0x253A800 VA: 0x18253B600
	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	// RVA: 0x253CFC0 Offset: 0x253C1C0 VA: 0x18253CFC0
	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	// RVA: 0x253CED0 Offset: 0x253C0D0 VA: 0x18253CED0
	public static int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex) { }

	// RVA: 0x253F720 Offset: 0x253E920 VA: 0x18253F720
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x253F780 Offset: 0x253E980 VA: 0x18253F780
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x253F7E0 Offset: 0x253E9E0 VA: 0x18253F7E0
	public static char ToUpperFast(char c) { }

	// RVA: 0x253CDE0 Offset: 0x253BFE0 VA: 0x18253CDE0
	public static int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x253EC90 Offset: 0x253DE90 VA: 0x18253EC90
	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode) { }

	// RVA: 0x253EB80 Offset: 0x253DD80 VA: 0x18253EB80
	public static bool IsBaseGlyph(uint c) { }

	[Extension]
	// RVA: 0x253EF90 Offset: 0x253E190 VA: 0x18253EF90
	public static Color MinAlpha(Color c1, Color c2) { }

	// RVA: 0x253CCB0 Offset: 0x253BEB0 VA: 0x18253CCB0
	internal static Color32 GammaToLinear(Color32 c) { }

	// RVA: 0x253CD30 Offset: 0x253BF30 VA: 0x18253CD30
	private static byte GammaToLinear(byte value) { }

	// RVA: 0x253EDE0 Offset: 0x253DFE0 VA: 0x18253EDE0
	public static bool IsValidUTF16(TextBackingContainer text, int index) { }

	// RVA: 0x253EE60 Offset: 0x253E060 VA: 0x18253EE60
	public static bool IsValidUTF32(TextBackingContainer text, int index) { }

	// RVA: 0x253ED80 Offset: 0x253DF80 VA: 0x18253ED80
	internal static bool IsHangul(uint c) { }

	// RVA: 0x253ECC0 Offset: 0x253DEC0 VA: 0x18253ECC0
	internal static bool IsCJK(uint c) { }

	// RVA: 0x253F840 Offset: 0x253EA40 VA: 0x18253F840
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal class TextHandle // TypeDefIndex: 16260
{
	// Fields
	private Vector2 m_PreferredSize; // 0x10
	private TextInfo m_TextInfo; // 0x18
	private static TextInfo m_LayoutTextInfo; // 0x0
	private int m_PreviousGenerationSettingsHash; // 0x20
	protected TextGenerationSettings textGenerationSettings; // 0x28
	protected static TextGenerationSettings s_LayoutSettings; // 0x8
	private bool isDirty; // 0x30

	// Properties
	internal TextInfo textInfo { get; }
	internal static TextInfo layoutTextInfo { get; }

	// Methods

	// RVA: 0x2543440 Offset: 0x2542640 VA: 0x182543440
	public void .ctor() { }

	// RVA: 0x2543580 Offset: 0x2542780 VA: 0x182543580
	internal TextInfo get_textInfo() { }

	// RVA: 0x25434A0 Offset: 0x25426A0 VA: 0x1825434A0
	internal static TextInfo get_layoutTextInfo() { }

	// RVA: 0x2541E90 Offset: 0x2541090 VA: 0x182541E90
	public bool IsDirty() { }

	// RVA: 0x2541300 Offset: 0x2540500 VA: 0x182541300
	public Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = True) { }

	// RVA: 0x25415D0 Offset: 0x25407D0 VA: 0x1825415D0
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = False, bool inverseYAxis = True) { }

	// RVA: 0x2540E70 Offset: 0x2540070 VA: 0x182540E70
	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = True) { }

	// RVA: 0x2542130 Offset: 0x2541330 VA: 0x182542130
	public int LineDownCharacterPosition(int originalPos) { }

	// RVA: 0x25427B0 Offset: 0x25419B0 VA: 0x1825427B0
	public int LineUpCharacterPosition(int originalPos) { }

	// RVA: 0x2540AC0 Offset: 0x253FCC0 VA: 0x182540AC0
	public int FindNearestLine(Vector2 position) { }

	// RVA: 0x25400F0 Offset: 0x253F2F0 VA: 0x1825400F0
	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly) { }

	// RVA: 0x253FAD0 Offset: 0x253ECD0 VA: 0x18253FAD0
	public int FindIntersectingLink(Vector3 position, bool inverseYAxis = True) { }

	// RVA: 0x2542DE0 Offset: 0x2541FE0 VA: 0x182542DE0
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x253F8E0 Offset: 0x253EAE0 VA: 0x18253F8E0
	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x2541BC0 Offset: 0x2540DC0 VA: 0x182541BC0
	public int GetLineNumber(int index) { }

	// RVA: 0x2541AB0 Offset: 0x2540CB0 VA: 0x182541AB0
	public float GetLineHeight(int lineNumber) { }

	// RVA: 0x25418B0 Offset: 0x2540AB0 VA: 0x1825418B0
	public float GetLineHeightFromCharacterIndex(int index) { }

	// RVA: 0x2540C60 Offset: 0x253FE60 VA: 0x182540C60
	public float GetCharacterHeightFromIndex(int index) { }

	// RVA: 0x2541EE0 Offset: 0x25410E0 VA: 0x182541EE0
	public bool IsElided() { }

	// RVA: 0x2542F60 Offset: 0x2542160 VA: 0x182542F60
	public string Substring(int startIndex, int length) { }

	// RVA: 0x2541CD0 Offset: 0x2540ED0 VA: 0x182541CD0
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x2541FC0 Offset: 0x25411C0 VA: 0x182541FC0
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x253F8C0 Offset: 0x253EAC0 VA: 0x18253F8C0
	protected float ComputeTextWidth(TextGenerationSettings tgs) { }

	// RVA: 0x253F8A0 Offset: 0x253EAA0 VA: 0x18253F8A0
	protected float ComputeTextHeight(TextGenerationSettings tgs) { }

	// RVA: 0x2543150 Offset: 0x2542350 VA: 0x182543150
	protected void UpdatePreferredValues(TextGenerationSettings tgs) { }

	// RVA: 0x2543290 Offset: 0x2542490 VA: 0x182543290
	protected TextInfo Update(TextGenerationSettings tgs) { }

	// RVA: 0x25433E0 Offset: 0x25425E0 VA: 0x1825433E0
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct PageInfo // TypeDefIndex: 16261
{
	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public float ascender; // 0x8
	public float baseLine; // 0xC
	public float descender; // 0x10
}

// Namespace: UnityEngine.TextCore.Text
internal struct WordInfo // TypeDefIndex: 16262
{
	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public int characterCount; // 0x8
}

// Namespace: UnityEngine.TextCore.Text
internal class TextInfo // TypeDefIndex: 16263
{
	// Fields
	private static Vector2 s_InfinityVectorPositive; // 0x0
	private static Vector2 s_InfinityVectorNegative; // 0x8
	public int characterCount; // 0x10
	public int spriteCount; // 0x14
	public int spaceCount; // 0x18
	public int wordCount; // 0x1C
	public int linkCount; // 0x20
	public int lineCount; // 0x24
	public int pageCount; // 0x28
	public int materialCount; // 0x2C
	public TextElementInfo[] textElementInfo; // 0x30
	public WordInfo[] wordInfo; // 0x38
	public LinkInfo[] linkInfo; // 0x40
	public LineInfo[] lineInfo; // 0x48
	public PageInfo[] pageInfo; // 0x50
	public MeshInfo[] meshInfo; // 0x58
	public bool isDirty; // 0x60
	public bool hasMultipleColors; // 0x61

	// Methods

	// RVA: 0x2543B00 Offset: 0x2542D00 VA: 0x182543B00
	public void .ctor() { }

	// RVA: 0x2543A30 Offset: 0x2542C30 VA: 0x182543A30
	internal void Clear() { }

	// RVA: 0x2543880 Offset: 0x2542A80 VA: 0x182543880
	internal void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x25435F0 Offset: 0x25427F0 VA: 0x1825435F0
	internal void ClearLineInfo() { }

	// RVA: 0x2543940 Offset: 0x2542B40 VA: 0x182543940
	internal void ClearPageInfo() { }

	// RVA: -1 Offset: -1
	internal static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA82490 Offset: 0xA81690 VA: 0x180A82490
	|-TextInfo.Resize<LinkInfo>
	|-TextInfo.Resize<WordInfo>
	|
	|-RVA: 0xA82390 Offset: 0xA81590 VA: 0x180A82390
	|-TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA824F0 Offset: 0xA816F0 VA: 0x180A824F0
	|-TextInfo.Resize<MeshInfo>
	|-TextInfo.Resize<PageInfo>
	|-TextInfo.Resize<TextElementInfo>
	|
	|-RVA: 0xA82400 Offset: 0xA81600 VA: 0x180A82400
	|-TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2543AA0 Offset: 0x2542CA0 VA: 0x182543AA0
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal enum MarkupTag // TypeDefIndex: 16264
{
	// Fields
	public int value__; // 0x0
	public const MarkupTag BOLD = 66;
	public const MarkupTag SLASH_BOLD = 1613;
	public const MarkupTag ITALIC = 73;
	public const MarkupTag SLASH_ITALIC = 1606;
	public const MarkupTag UNDERLINE = 85;
	public const MarkupTag SLASH_UNDERLINE = 1626;
	public const MarkupTag STRIKETHROUGH = 83;
	public const MarkupTag SLASH_STRIKETHROUGH = 1628;
	public const MarkupTag MARK = 2699125;
	public const MarkupTag SLASH_MARK = 57644506;
	public const MarkupTag SUBSCRIPT = 92132;
	public const MarkupTag SLASH_SUBSCRIPT = 1770219;
	public const MarkupTag SUPERSCRIPT = 92150;
	public const MarkupTag SLASH_SUPERSCRIPT = 1770233;
	public const MarkupTag COLOR = 81999901;
	public const MarkupTag SLASH_COLOR = 1909026194;
	public const MarkupTag ALPHA = 75165780;
	public const MarkupTag A = 65;
	public const MarkupTag SLASH_A = 1614;
	public const MarkupTag SIZE = 3061285;
	public const MarkupTag SLASH_SIZE = 58429962;
	public const MarkupTag SPRITE = -991527447;
	public const MarkupTag NO_BREAK = 2856657;
	public const MarkupTag SLASH_NO_BREAK = 57477502;
	public const MarkupTag STYLE = 100252951;
	public const MarkupTag SLASH_STYLE = 1927738392;
	public const MarkupTag FONT = 2586451;
	public const MarkupTag SLASH_FONT = 57747708;
	public const MarkupTag SLASH_MATERIAL = -1100708252;
	public const MarkupTag LINK = 2656128;
	public const MarkupTag SLASH_LINK = 57686191;
	public const MarkupTag FONT_WEIGHT = -1889896162;
	public const MarkupTag SLASH_FONT_WEIGHT = -757976431;
	public const MarkupTag NO_PARSE = -408011596;
	public const MarkupTag SLASH_NO_PARSE = -294095813;
	public const MarkupTag POSITION = 85420;
	public const MarkupTag SLASH_POSITION = 1777699;
	public const MarkupTag VERTICAL_OFFSET = 1952379995;
	public const MarkupTag SLASH_VERTICAL_OFFSET = -11107948;
	public const MarkupTag SPACE = 100083556;
	public const MarkupTag SLASH_SPACE = 1927873067;
	public const MarkupTag PAGE = 2808691;
	public const MarkupTag SLASH_PAGE = 58683868;
	public const MarkupTag ALIGN = 75138797;
	public const MarkupTag SLASH_ALIGN = 1916026786;
	public const MarkupTag WIDTH = 105793766;
	public const MarkupTag SLASH_WIDTH = 1923459625;
	public const MarkupTag GRADIENT = -1999759898;
	public const MarkupTag SLASH_GRADIENT = -1854491959;
	public const MarkupTag CHARACTER_SPACE = -1584382009;
	public const MarkupTag SLASH_CHARACTER_SPACE = -1394426712;
	public const MarkupTag MONOSPACE = -1340221943;
	public const MarkupTag SLASH_MONOSPACE = -1638865562;
	public const MarkupTag CLASS = 82115566;
	public const MarkupTag INDENT = -1514123076;
	public const MarkupTag SLASH_INDENT = -1496889389;
	public const MarkupTag LINE_INDENT = -844305121;
	public const MarkupTag SLASH_LINE_INDENT = 93886352;
	public const MarkupTag MARGIN = -1355614050;
	public const MarkupTag SLASH_MARGIN = -1649644303;
	public const MarkupTag MARGIN_LEFT = -272933656;
	public const MarkupTag MARGIN_RIGHT = -447416589;
	public const MarkupTag LINE_HEIGHT = -799081892;
	public const MarkupTag SLASH_LINE_HEIGHT = 200452819;
	public const MarkupTag ACTION = -1827519330;
	public const MarkupTag SLASH_ACTION = -1187217679;
	public const MarkupTag SCALE = 100553336;
	public const MarkupTag SLASH_SCALE = 1928413879;
	public const MarkupTag ROTATE = -1000007783;
	public const MarkupTag SLASH_ROTATE = -764695562;
	public const MarkupTag TABLE = 226476955;
	public const MarkupTag SLASH_TABLE = -979118220;
	public const MarkupTag TH = 5862489;
	public const MarkupTag SLASH_TH = 193346070;
	public const MarkupTag TR = 5862467;
	public const MarkupTag SLASH_TR = 193346060;
	public const MarkupTag TD = 5862485;
	public const MarkupTag SLASH_TD = 193346074;
	public const MarkupTag LOWERCASE = -1506899689;
	public const MarkupTag SLASH_LOWERCASE = -1451284584;
	public const MarkupTag ALLCAPS = 218273952;
	public const MarkupTag SLASH_ALLCAPS = -797437649;
	public const MarkupTag UPPERCASE = -305409418;
	public const MarkupTag SLASH_UPPERCASE = -582368199;
	public const MarkupTag SMALLCAPS = -766062114;
	public const MarkupTag SLASH_SMALLCAPS = 199921873;
	public const MarkupTag LIGA = 2655971;
	public const MarkupTag SLASH_LIGA = 57686604;
	public const MarkupTag FRAC = 2598518;
	public const MarkupTag SLASH_FRAC = 57774681;
	public const MarkupTag NAME = 2875623;
	public const MarkupTag INDEX = 84268030;
	public const MarkupTag TINT = 2960519;
	public const MarkupTag ANIM = 2283339;
	public const MarkupTag MATERIAL = 825491659;
	public const MarkupTag HREF = 2535353;
	public const MarkupTag ANGLE = 75347905;
	public const MarkupTag PADDING = -2144568463;
	public const MarkupTag FAMILYNAME = 704251153;
	public const MarkupTag STYLENAME = -1207081936;
	public const MarkupTag RED = 91635;
	public const MarkupTag GREEN = 87065851;
	public const MarkupTag BLUE = 2457214;
	public const MarkupTag YELLOW = -882444668;
	public const MarkupTag ORANGE = -1108587920;
	public const MarkupTag BLACK = 81074727;
	public const MarkupTag WHITE = 105680263;
	public const MarkupTag PURPLE = -1250222130;
	public const MarkupTag BR = 2256;
	public const MarkupTag CR = 2289;
	public const MarkupTag ZWSP = 3288238;
	public const MarkupTag ZWJ = 99623;
	public const MarkupTag NBSP = 2869039;
	public const MarkupTag SHY = 92674;
	public const MarkupTag LEFT = 2660507;
	public const MarkupTag RIGHT = 99937376;
	public const MarkupTag CENTER = -1591113269;
	public const MarkupTag JUSTIFIED = 817091359;
	public const MarkupTag FLUSH = 85552164;
	public const MarkupTag NONE = 2857034;
	public const MarkupTag PLUS = 43;
	public const MarkupTag MINUS = 45;
	public const MarkupTag PX = 2568;
	public const MarkupTag PLUS_PX = 49507;
	public const MarkupTag MINUS_PX = 47461;
	public const MarkupTag EM = 2216;
	public const MarkupTag PLUS_EM = 49091;
	public const MarkupTag MINUS_EM = 46789;
	public const MarkupTag PCT = 85031;
	public const MarkupTag PLUS_PCT = 1634348;
	public const MarkupTag MINUS_PCT = 1567082;
	public const MarkupTag PERCENTAGE = 37;
	public const MarkupTag PLUS_PERCENTAGE = 1454;
	public const MarkupTag MINUS_PERCENTAGE = 1512;
	public const MarkupTag TRUE = 2932022;
	public const MarkupTag FALSE = 85422813;
	public const MarkupTag INVALID = 1585415185;
	public const MarkupTag NOTDEF = 612146780;
	public const MarkupTag NORMAL = -1183493901;
	public const MarkupTag DEFAULT = -620974005;
	public const MarkupTag REGULAR = 1291372090;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TagValueType // TypeDefIndex: 16265
{
	// Fields
	public int value__; // 0x0
	public const TagValueType None = 0;
	public const TagValueType NumericalValue = 1;
	public const TagValueType StringValue = 2;
	public const TagValueType ColorValue = 4;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TagUnitType // TypeDefIndex: 16266
{
	// Fields
	public int value__; // 0x0
	public const TagUnitType Pixels = 0;
	public const TagUnitType FontUnits = 1;
	public const TagUnitType Percentage = 2;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextProcessingElementType // TypeDefIndex: 16267
{
	// Fields
	public int value__; // 0x0
	public const TextProcessingElementType Undefined = 0;
	public const TextProcessingElementType TextCharacterElement = 1;
	public const TextProcessingElementType TextMarkupElement = 2;
}

// Namespace: UnityEngine.TextCore.Text
internal struct FontStyleStack // TypeDefIndex: 16268
{
	// Fields
	public byte bold; // 0x0
	public byte italic; // 0x1
	public byte underline; // 0x2
	public byte strikethrough; // 0x3
	public byte highlight; // 0x4
	public byte superscript; // 0x5
	public byte subscript; // 0x6
	public byte uppercase; // 0x7
	public byte lowercase; // 0x8
	public byte smallcaps; // 0x9

	// Methods

	// RVA: 0x2418AD0 Offset: 0x2417CD0 VA: 0x182418AD0
	public void Clear() { }

	// RVA: 0x2418A20 Offset: 0x2417C20 VA: 0x182418A20
	public byte Add(FontStyles style) { }

	// RVA: 0x2418AE0 Offset: 0x2417CE0 VA: 0x182418AE0
	public byte Remove(FontStyles style) { }
}

// Namespace: UnityEngine.TextCore.Text
[DebuggerDisplay("Item count = {m_Count}")]
internal struct TextProcessingStack<T> // TypeDefIndex: 16269
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0

	// Properties
	public int Count { get; }
	public T current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4BA30 Offset: 0xC4AC30 VA: 0x180C4BA30
	|-TextProcessingStack<Color32>..ctor
	|-TextProcessingStack<int>..ctor
	|-TextProcessingStack<Int32Enum>..ctor
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0xC4BD20 Offset: 0xC4AF20 VA: 0x180C4BD20
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0xC4C180 Offset: 0xC4B380 VA: 0x180C4C180
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0xC4C470 Offset: 0xC4B670 VA: 0x180C4C470
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0xC9F2A0 Offset: 0xC9E4A0 VA: 0x180C9F2A0
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0xC4C1C0 Offset: 0xC4B3C0 VA: 0x180C4C1C0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4B940 Offset: 0xC4AB40 VA: 0x180C4B940
	|-TextProcessingStack<Color32>..ctor
	|-TextProcessingStack<int>..ctor
	|-TextProcessingStack<Int32Enum>..ctor
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0xC4C110 Offset: 0xC4B310 VA: 0x180C4C110
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0xC4B8C0 Offset: 0xC4AAC0 VA: 0x180C4B8C0
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0xC4BA60 Offset: 0xC4AC60 VA: 0x180C4BA60
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0xC9F220 Offset: 0xC9E420 VA: 0x180C9F220
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0xC4BED0 Offset: 0xC4B0D0 VA: 0x180C4BED0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4B840 Offset: 0xC4AA40 VA: 0x180C4B840
	|-TextProcessingStack<Color32>..ctor
	|-TextProcessingStack<int>..ctor
	|-TextProcessingStack<Int32Enum>..ctor
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0xC4BDC0 Offset: 0xC4AFC0 VA: 0x180C4BDC0
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0xC4BE40 Offset: 0xC4B040 VA: 0x180C4BE40
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0xC4B7C0 Offset: 0xC4A9C0 VA: 0x180C4B7C0
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0xC9F300 Offset: 0xC9E500 VA: 0x180C9F300
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0xC4BAD0 Offset: 0xC4ACD0 VA: 0x180C4BAD0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB78A40 Offset: 0xB77C40 VA: 0x180B78A40
	|-TextProcessingStack<Color32>.get_Count
	|-TextProcessingStack<int>.get_Count
	|-TextProcessingStack<Int32Enum>.get_Count
	|-TextProcessingStack<float>.get_Count
	|
	|-RVA: 0xC9F3C0 Offset: 0xC9E5C0 VA: 0x180C9F3C0
	|-TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0xC9F3B0 Offset: 0xC9E5B0 VA: 0x180C9F3B0
	|-TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0xC9F3A0 Offset: 0xC9E5A0 VA: 0x180C9F3A0
	|-TextProcessingStack<object>.get_Count
	|
	|-RVA: 0xC9F390 Offset: 0xC9E590 VA: 0x180C9F390
	|-TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0xC4C4B0 Offset: 0xC4B6B0 VA: 0x180C4C4B0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC479E0 Offset: 0xC46BE0 VA: 0x180C479E0
	|-TextProcessingStack<Color32>.get_current
	|-TextProcessingStack<int>.get_current
	|-TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0xC9BF10 Offset: 0xC9B110 VA: 0x180C9BF10
	|-TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0xC9BD00 Offset: 0xC9AF00 VA: 0x180C9BD00
	|-TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0xC47920 Offset: 0xC46B20 VA: 0x180C47920
	|-TextProcessingStack<object>.get_current
	|
	|-RVA: 0xC47BF0 Offset: 0xC46DF0 VA: 0x180C47BF0
	|-TextProcessingStack<float>.get_current
	|
	|-RVA: 0xC9BDB0 Offset: 0xC9AFB0 VA: 0x180C9BDB0
	|-TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0xC9BAF0 Offset: 0xC9ACF0 VA: 0x180C9BAF0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.get_current
	*/

	// RVA: -1 Offset: -1
	internal static void SetDefault(TextProcessingStack<T>[] stack, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9E7A0 Offset: 0xC9D9A0 VA: 0x180C9E7A0
	|-TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0xC9E560 Offset: 0xC9D760 VA: 0x180C9E560
	|-TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0xC9E200 Offset: 0xC9D400 VA: 0x180C9E200
	|-TextProcessingStack<int>.SetDefault
	|-TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0xC9F0E0 Offset: 0xC9E2E0 VA: 0x180C9F0E0
	|-TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0xC9E8B0 Offset: 0xC9DAB0 VA: 0x180C9E8B0
	|-TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0xC9E3B0 Offset: 0xC9D5B0 VA: 0x180C9E3B0
	|-TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0xC9EBD0 Offset: 0xC9DDD0 VA: 0x180C9EBD0
	|-TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0xC4B310 Offset: 0xC4A510 VA: 0x180C4B310
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC47780 Offset: 0xC46980 VA: 0x180C47780
	|-TextProcessingStack<Color32>.Clear
	|-TextProcessingStack<int>.Clear
	|-TextProcessingStack<Int32Enum>.Clear
	|-TextProcessingStack<float>.Clear
	|
	|-RVA: 0xC47870 Offset: 0xC46A70 VA: 0x180C47870
	|-TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0xC47860 Offset: 0xC46A60 VA: 0x180C47860
	|-TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0xC47770 Offset: 0xC46970 VA: 0x180C47770
	|-TextProcessingStack<object>.Clear
	|
	|-RVA: 0xC9BAE0 Offset: 0xC9ACE0 VA: 0x180C9BAE0
	|-TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0xC47790 Offset: 0xC46990 VA: 0x180C47790
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9EB30 Offset: 0xC9DD30 VA: 0x180C9EB30
	|-TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0xC9E150 Offset: 0xC9D350 VA: 0x180C9E150
	|-TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0xC9E4C0 Offset: 0xC9D6C0 VA: 0x180C9E4C0
	|-TextProcessingStack<int>.SetDefault
	|-TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0xC9EA60 Offset: 0xC9DC60 VA: 0x180C9EA60
	|-TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0xC9E310 Offset: 0xC9D510 VA: 0x180C9E310
	|-TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0xC9E9C0 Offset: 0xC9DBC0 VA: 0x180C9E9C0
	|-TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0xC9E680 Offset: 0xC9D880 VA: 0x180C9E680
	|-TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0xC9ED70 Offset: 0xC9DF70 VA: 0x180C9ED70
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC47540 Offset: 0xC46740 VA: 0x180C47540
	|-TextProcessingStack<Color32>.Add
	|-TextProcessingStack<int>.Add
	|-TextProcessingStack<Int32Enum>.Add
	|
	|-RVA: 0xC47580 Offset: 0xC46780 VA: 0x180C47580
	|-TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0xC47610 Offset: 0xC46810 VA: 0x180C47610
	|-TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0xC47260 Offset: 0xC46460 VA: 0x180C47260
	|-TextProcessingStack<object>.Add
	|
	|-RVA: 0xC475D0 Offset: 0xC467D0 VA: 0x180C475D0
	|-TextProcessingStack<float>.Add
	|
	|-RVA: 0xC9BA10 Offset: 0xC9AC10 VA: 0x180C9BA10
	|-TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0xC472A0 Offset: 0xC464A0 VA: 0x180C472A0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9D970 Offset: 0xC9CB70 VA: 0x180C9D970
	|-TextProcessingStack<Color32>.Remove
	|-TextProcessingStack<int>.Remove
	|-TextProcessingStack<Int32Enum>.Remove
	|
	|-RVA: 0xC9E050 Offset: 0xC9D250 VA: 0x180C9E050
	|-TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0xC9D9E0 Offset: 0xC9CBE0 VA: 0x180C9D9E0
	|-TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0xC9E0E0 Offset: 0xC9D2E0 VA: 0x180C9E0E0
	|-TextProcessingStack<object>.Remove
	|
	|-RVA: 0xC9DC30 Offset: 0xC9CE30 VA: 0x180C9DC30
	|-TextProcessingStack<float>.Remove
	|
	|-RVA: 0xC9DAB0 Offset: 0xC9CCB0 VA: 0x180C9DAB0
	|-TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0xC9DCA0 Offset: 0xC9CEA0 VA: 0x180C9DCA0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9CFF0 Offset: 0xC9C1F0 VA: 0x180C9CFF0
	|-TextProcessingStack<Color32>.Push
	|
	|-RVA: 0xC493F0 Offset: 0xC485F0 VA: 0x180C493F0
	|-TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0xC497E0 Offset: 0xC489E0 VA: 0x180C497E0
	|-TextProcessingStack<int>.Push
	|-TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0xC49300 Offset: 0xC48500 VA: 0x180C49300
	|-TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0xC49580 Offset: 0xC48780 VA: 0x180C49580
	|-TextProcessingStack<object>.Push
	|
	|-RVA: 0xC9D0B0 Offset: 0xC9C2B0 VA: 0x180C9D0B0
	|-TextProcessingStack<float>.Push
	|
	|-RVA: 0xC9D180 Offset: 0xC9C380 VA: 0x180C9D180
	|-TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0xC9D2F0 Offset: 0xC9C4F0 VA: 0x180C9D2F0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC48170 Offset: 0xC47370 VA: 0x180C48170
	|-TextProcessingStack<Color32>.Pop
	|
	|-RVA: 0xC9C3E0 Offset: 0xC9B5E0 VA: 0x180C9C3E0
	|-TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0xC480E0 Offset: 0xC472E0 VA: 0x180C480E0
	|-TextProcessingStack<int>.Pop
	|-TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0xC9CEE0 Offset: 0xC9C0E0 VA: 0x180C9CEE0
	|-TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0xC48E50 Offset: 0xC48050 VA: 0x180C48E50
	|-TextProcessingStack<object>.Pop
	|
	|-RVA: 0xC9CB70 Offset: 0xC9BD70 VA: 0x180C9CB70
	|-TextProcessingStack<float>.Pop
	|
	|-RVA: 0xC9CC10 Offset: 0xC9BE10 VA: 0x180C9CC10
	|-TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0xC9C4B0 Offset: 0xC9B6B0 VA: 0x180C9C4B0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC47EB0 Offset: 0xC470B0 VA: 0x180C47EB0
	|-TextProcessingStack<Color32>.Peek
	|-TextProcessingStack<int>.Peek
	|-TextProcessingStack<Int32Enum>.Peek
	|
	|-RVA: 0xC9BF90 Offset: 0xC9B190 VA: 0x180C9BF90
	|-TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0xC9C340 Offset: 0xC9B540 VA: 0x180C9C340
	|-TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0xC47DE0 Offset: 0xC46FE0 VA: 0x180C47DE0
	|-TextProcessingStack<object>.Peek
	|
	|-RVA: 0xC47EF0 Offset: 0xC470F0 VA: 0x180C47EF0
	|-TextProcessingStack<float>.Peek
	|
	|-RVA: 0xC9C000 Offset: 0xC9B200 VA: 0x180C9C000
	|-TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0xC9C140 Offset: 0xC9B340 VA: 0x180C9C140
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC479E0 Offset: 0xC46BE0 VA: 0x180C479E0
	|-TextProcessingStack<Color32>.CurrentItem
	|-TextProcessingStack<int>.CurrentItem
	|-TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0xC9BF10 Offset: 0xC9B110 VA: 0x180C9BF10
	|-TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0xC9BD00 Offset: 0xC9AF00 VA: 0x180C9BD00
	|-TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0xC47920 Offset: 0xC46B20 VA: 0x180C47920
	|-TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0xC47BF0 Offset: 0xC46DF0 VA: 0x180C47BF0
	|-TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0xC9BDB0 Offset: 0xC9AFB0 VA: 0x180C9BDB0
	|-TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0xC9BAF0 Offset: 0xC9ACF0 VA: 0x180C9BAF0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.CurrentItem
	*/
}

// Namespace: 
private struct TextResourceManager.FontAssetRef // TypeDefIndex: 16270
{
	// Fields
	public int nameHashCode; // 0x0
	public int familyNameHashCode; // 0x4
	public int styleNameHashCode; // 0x8
	public long familyNameAndStyleHashCode; // 0x10
	public readonly FontAsset fontAsset; // 0x18

	// Methods

	// RVA: 0x253A890 Offset: 0x2539A90 VA: 0x18253A890
	public void .ctor(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset) { }
}

// Namespace: UnityEngine.TextCore.Text
internal class TextResourceManager // TypeDefIndex: 16271
{
	// Fields
	private static readonly Dictionary<int, TextResourceManager.FontAssetRef> s_FontAssetReferences; // 0x0
	private static readonly Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup; // 0x8
	private static readonly Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x10
	private static readonly List<int> s_FontAssetRemovalList; // 0x18
	private static readonly int k_RegularStyleHashCode; // 0x20

	// Methods

	// RVA: 0x2543C00 Offset: 0x2542E00 VA: 0x182543C00
	internal static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x2544240 Offset: 0x2543440 VA: 0x182544240
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
private struct TextSettings.FontReferenceMap // TypeDefIndex: 16272
{
	// Fields
	public Font font; // 0x0
	public FontAsset fontAsset; // 0x8

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(Font font, FontAsset fontAsset) { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[Serializable]
public class TextSettings : ScriptableObject // TypeDefIndex: 16273
{
	// Fields
	[SerializeField]
	protected string m_Version; // 0x18
	[FormerlySerializedAs("m_defaultFontAsset")]
	[SerializeField]
	protected FontAsset m_DefaultFontAsset; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_defaultFontAssetPath")]
	protected string m_DefaultFontAssetPath; // 0x28
	[FormerlySerializedAs("m_fallbackFontAssets")]
	[SerializeField]
	protected List<FontAsset> m_FallbackFontAssets; // 0x30
	[FormerlySerializedAs("m_matchMaterialPreset")]
	[SerializeField]
	protected bool m_MatchMaterialPreset; // 0x38
	[FormerlySerializedAs("m_missingGlyphCharacter")]
	[SerializeField]
	protected int m_MissingCharacterUnicode; // 0x3C
	[SerializeField]
	protected bool m_ClearDynamicDataOnBuild; // 0x40
	[SerializeField]
	[FormerlySerializedAs("m_defaultSpriteAsset")]
	protected SpriteAsset m_DefaultSpriteAsset; // 0x48
	[SerializeField]
	[FormerlySerializedAs("m_defaultSpriteAssetPath")]
	protected string m_DefaultSpriteAssetPath; // 0x50
	[SerializeField]
	protected List<SpriteAsset> m_FallbackSpriteAssets; // 0x58
	[SerializeField]
	protected uint m_MissingSpriteCharacterUnicode; // 0x60
	[SerializeField]
	[FormerlySerializedAs("m_defaultStyleSheet")]
	protected TextStyleSheet m_DefaultStyleSheet; // 0x68
	[SerializeField]
	protected string m_StyleSheetsResourcePath; // 0x70
	[SerializeField]
	[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
	protected string m_DefaultColorGradientPresetsPath; // 0x78
	[SerializeField]
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; // 0x80
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0x88
	[FormerlySerializedAs("m_warningsDisabled")]
	[SerializeField]
	protected bool m_DisplayWarnings; // 0x89
	internal Dictionary<int, FontAsset> m_FontLookup; // 0x90
	private List<TextSettings.FontReferenceMap> m_FontReferences; // 0x98

	// Properties
	public string version { get; set; }
	public FontAsset defaultFontAsset { get; set; }
	public string defaultFontAssetPath { get; set; }
	public List<FontAsset> fallbackFontAssets { get; set; }
	public bool matchMaterialPreset { get; set; }
	public int missingCharacterUnicode { get; set; }
	public bool clearDynamicDataOnBuild { get; set; }
	public SpriteAsset defaultSpriteAsset { get; set; }
	public string defaultSpriteAssetPath { get; set; }
	public List<SpriteAsset> fallbackSpriteAssets { get; set; }
	public uint missingSpriteCharacterUnicode { get; set; }
	public TextStyleSheet defaultStyleSheet { get; set; }
	public string styleSheetsResourcePath { get; set; }
	public string defaultColorGradientPresetsPath { get; set; }
	public UnicodeLineBreakingRules lineBreakingRules { get; set; }
	public bool useModernHangulLineBreakingRules { get; set; }
	public bool displayWarnings { get; set; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_version() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_version(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public FontAsset get_defaultFontAsset() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_defaultFontAsset(FontAsset value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_defaultFontAssetPath() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_defaultFontAssetPath(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public List<FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_fallbackFontAssets(List<FontAsset> value) { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_matchMaterialPreset() { }

	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_matchMaterialPreset(bool value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	public int get_missingCharacterUnicode() { }

	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70
	public void set_missingCharacterUnicode(int value) { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x445700 Offset: 0x444900 VA: 0x180445700
	public void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_defaultSpriteAsset(SpriteAsset value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_defaultSpriteAssetPath() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_defaultSpriteAssetPath(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public List<SpriteAsset> get_fallbackSpriteAssets() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_fallbackSpriteAssets(List<SpriteAsset> value) { }

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public uint get_missingSpriteCharacterUnicode() { }

	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	public void set_missingSpriteCharacterUnicode(uint value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public TextStyleSheet get_defaultStyleSheet() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_defaultStyleSheet(TextStyleSheet value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public string get_styleSheetsResourcePath() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_styleSheetsResourcePath(string value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	public void set_defaultColorGradientPresetsPath(string value) { }

	// RVA: 0x2544AC0 Offset: 0x2543CC0 VA: 0x182544AC0
	public UnicodeLineBreakingRules get_lineBreakingRules() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_lineBreakingRules(UnicodeLineBreakingRules value) { }

	// RVA: 0x2544B40 Offset: 0x2543D40 VA: 0x182544B40
	public bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0xF05FF0 Offset: 0xF051F0 VA: 0x180F05FF0
	public void set_useModernHangulLineBreakingRules(bool value) { }

	// RVA: 0x5C3410 Offset: 0x5C2610 VA: 0x1805C3410
	public bool get_displayWarnings() { }

	// RVA: 0xF05DC0 Offset: 0xF04FC0 VA: 0x180F05DC0
	public void set_displayWarnings(bool value) { }

	// RVA: 0x2544950 Offset: 0x2543B50 VA: 0x182544950
	private void OnEnable() { }

	// RVA: 0x2544720 Offset: 0x2543920 VA: 0x182544720
	protected void InitializeFontReferenceLookup() { }

	// RVA: 0x25443C0 Offset: 0x25435C0 VA: 0x1825443C0
	protected FontAsset GetCachedFontAssetInternal(Font font) { }

	// RVA: 0x25449E0 Offset: 0x2543BE0 VA: 0x1825449E0
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromDocs]
public static class TextShaderUtilities // TypeDefIndex: 16274
{
	// Fields
	public static int ID_MainTex; // 0x0
	public static int ID_FaceTex; // 0x4
	public static int ID_FaceColor; // 0x8
	public static int ID_FaceDilate; // 0xC
	public static int ID_Shininess; // 0x10
	public static int ID_OutlineOffset1; // 0x14
	public static int ID_OutlineOffset2; // 0x18
	public static int ID_OutlineOffset3; // 0x1C
	public static int ID_OutlineMode; // 0x20
	public static int ID_IsoPerimeter; // 0x24
	public static int ID_Softness; // 0x28
	public static int ID_UnderlayColor; // 0x2C
	public static int ID_UnderlayOffsetX; // 0x30
	public static int ID_UnderlayOffsetY; // 0x34
	public static int ID_UnderlayDilate; // 0x38
	public static int ID_UnderlaySoftness; // 0x3C
	public static int ID_UnderlayOffset; // 0x40
	public static int ID_UnderlayIsoPerimeter; // 0x44
	public static int ID_WeightNormal; // 0x48
	public static int ID_WeightBold; // 0x4C
	public static int ID_OutlineTex; // 0x50
	public static int ID_OutlineWidth; // 0x54
	public static int ID_OutlineSoftness; // 0x58
	public static int ID_OutlineColor; // 0x5C
	public static int ID_Outline2Color; // 0x60
	public static int ID_Outline2Width; // 0x64
	public static int ID_Padding; // 0x68
	public static int ID_GradientScale; // 0x6C
	public static int ID_ScaleX; // 0x70
	public static int ID_ScaleY; // 0x74
	public static int ID_PerspectiveFilter; // 0x78
	public static int ID_Sharpness; // 0x7C
	public static int ID_TextureWidth; // 0x80
	public static int ID_TextureHeight; // 0x84
	public static int ID_BevelAmount; // 0x88
	public static int ID_GlowColor; // 0x8C
	public static int ID_GlowOffset; // 0x90
	public static int ID_GlowPower; // 0x94
	public static int ID_GlowOuter; // 0x98
	public static int ID_GlowInner; // 0x9C
	public static int ID_LightAngle; // 0xA0
	public static int ID_EnvMap; // 0xA4
	public static int ID_EnvMatrix; // 0xA8
	public static int ID_EnvMatrixRotation; // 0xAC
	public static int ID_MaskCoord; // 0xB0
	public static int ID_ClipRect; // 0xB4
	public static int ID_MaskSoftnessX; // 0xB8
	public static int ID_MaskSoftnessY; // 0xBC
	public static int ID_VertexOffsetX; // 0xC0
	public static int ID_VertexOffsetY; // 0xC4
	public static int ID_UseClipRect; // 0xC8
	public static int ID_StencilID; // 0xCC
	public static int ID_StencilOp; // 0xD0
	public static int ID_StencilComp; // 0xD4
	public static int ID_StencilReadMask; // 0xD8
	public static int ID_StencilWriteMask; // 0xDC
	public static int ID_ShaderFlags; // 0xE0
	public static int ID_ScaleRatio_A; // 0xE4
	public static int ID_ScaleRatio_B; // 0xE8
	public static int ID_ScaleRatio_C; // 0xEC
	public static string Keyword_Bevel; // 0xF0
	public static string Keyword_Glow; // 0xF8
	public static string Keyword_Underlay; // 0x100
	public static string Keyword_Ratios; // 0x108
	public static string Keyword_MASK_SOFT; // 0x110
	public static string Keyword_MASK_HARD; // 0x118
	public static string Keyword_MASK_TEX; // 0x120
	public static string Keyword_Outline; // 0x128
	public static string ShaderTag_ZTestMode; // 0x130
	public static string ShaderTag_CullMode; // 0x138
	private static float m_clamp; // 0x140
	public static bool isInitialized; // 0x144
	private static Shader k_ShaderRef_MobileSDF; // 0x148
	private static Shader k_ShaderRef_MobileBitmap; // 0x150

	// Properties
	internal static Shader ShaderRef_MobileSDF { get; }
	internal static Shader ShaderRef_MobileBitmap { get; }

	// Methods

	// RVA: 0x2545A50 Offset: 0x2544C50 VA: 0x182545A50
	internal static Shader get_ShaderRef_MobileSDF() { }

	// RVA: 0x2545830 Offset: 0x2544A30 VA: 0x182545830
	internal static Shader get_ShaderRef_MobileBitmap() { }

	// RVA: 0x2545640 Offset: 0x2544840 VA: 0x182545640
	private static void .cctor() { }

	// RVA: 0x2544B50 Offset: 0x2543D50 VA: 0x182544B50
	internal static void GetShaderPropertyIDs() { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class TextStyle // TypeDefIndex: 16275
{
	// Fields
	internal static TextStyle k_NormalStyle; // 0x0
	[SerializeField]
	private string m_Name; // 0x10
	[SerializeField]
	private int m_HashCode; // 0x18
	[SerializeField]
	private string m_OpeningDefinition; // 0x20
	[SerializeField]
	private string m_ClosingDefinition; // 0x28
	[SerializeField]
	private uint[] m_OpeningTagArray; // 0x30
	[SerializeField]
	private uint[] m_ClosingTagArray; // 0x38
	[SerializeField]
	internal uint[] m_OpeningTagUnicodeArray; // 0x40
	[SerializeField]
	internal uint[] m_ClosingTagUnicodeArray; // 0x48

	// Properties
	public int hashCode { get; }
	public uint[] styleOpeningTagArray { get; }
	public uint[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0xB78A40 Offset: 0xB77C40 VA: 0x180B78A40
	public int get_hashCode() { }

	// RVA: 0x2497C20 Offset: 0x2496E20 VA: 0x182497C20
	public uint[] get_styleOpeningTagArray() { }

	// RVA: 0x24CAD90 Offset: 0x24C9F90 VA: 0x1824CAD90
	public uint[] get_styleClosingTagArray() { }

	// RVA: 0x2546410 Offset: 0x2545610 VA: 0x182546410
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x25461B0 Offset: 0x25453B0 VA: 0x1825461B0
	public void RefreshStyle() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[Serializable]
public class TextStyleSheet : ScriptableObject // TypeDefIndex: 16276
{
	// Fields
	[SerializeField]
	private List<TextStyle> m_StyleList; // 0x18
	private Dictionary<int, TextStyle> m_StyleLookupDictionary; // 0x20

	// Properties
	internal List<TextStyle> styles { get; }

	// Methods

	// RVA: 0x248C210 Offset: 0x248B410 VA: 0x18248C210
	internal List<TextStyle> get_styles() { }

	// RVA: 0x2546130 Offset: 0x2545330 VA: 0x182546130
	private void Reset() { }

	// RVA: 0x2545C70 Offset: 0x2544E70 VA: 0x182545C70
	public TextStyle GetStyle(int hashCode) { }

	// RVA: 0x2545D00 Offset: 0x2544F00 VA: 0x182545D00
	public TextStyle GetStyle(string name) { }

	// RVA: 0x2546130 Offset: 0x2545330 VA: 0x182546130
	public void RefreshStyles() { }

	// RVA: 0x2545DA0 Offset: 0x2544FA0 VA: 0x182545DA0
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x2546140 Offset: 0x2545340 VA: 0x182546140
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[Extension]
internal static class TextUtilities // TypeDefIndex: 16277
{
	// Methods

	// RVA: 0x2546510 Offset: 0x2545710 VA: 0x182546510
	internal static char ToUpperFast(char c) { }

	// RVA: 0x2546470 Offset: 0x2545670 VA: 0x182546470
	public static int GetHashCodeCaseInSensitive(string s) { }

	[Extension]
	// RVA: 0x2546570 Offset: 0x2545770 VA: 0x182546570
	internal static string UintToString(List<uint> unicodes) { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class UnicodeLineBreakingRules // TypeDefIndex: 16278
{
	// Fields
	[SerializeField]
	private TextAsset m_UnicodeLineBreakingRules; // 0x10
	[SerializeField]
	private TextAsset m_LeadingCharacters; // 0x18
	[SerializeField]
	private TextAsset m_FollowingCharacters; // 0x20
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0x28
	private HashSet<uint> m_LeadingCharactersLookup; // 0x30
	private HashSet<uint> m_FollowingCharactersLookup; // 0x38

	// Properties
	public TextAsset leadingCharacters { get; }
	public TextAsset followingCharacters { get; }
	internal HashSet<uint> leadingCharactersLookup { get; }
	internal HashSet<uint> followingCharactersLookup { get; }
	public bool useModernHangulLineBreakingRules { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public TextAsset get_leadingCharacters() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public TextAsset get_followingCharacters() { }

	// RVA: 0x2546AD0 Offset: 0x2545CD0 VA: 0x182546AD0
	internal HashSet<uint> get_leadingCharactersLookup() { }

	// RVA: 0x2546A90 Offset: 0x2545C90 VA: 0x182546A90
	internal HashSet<uint> get_followingCharactersLookup() { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x2546710 Offset: 0x2545910 VA: 0x182546710
	internal void LoadLineBreakingRules() { }

	// RVA: 0x25468D0 Offset: 0x2545AD0 VA: 0x1825468D0
	internal void LoadLineBreakingRules(TextAsset leadingRules, TextAsset followingRules) { }

	// RVA: 0x2546640 Offset: 0x2545840 VA: 0x182546640
	private static HashSet<uint> GetCharacters(TextAsset file) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16279
{}

// Namespace: 
internal sealed class Locale // TypeDefIndex: 16280
{
	// Methods

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static string GetText(string msg) { }

	// RVA: 0x153E840 Offset: 0x153DA40 VA: 0x18153E840
	public static string GetText(string fmt, object[] args) { }
}

// Namespace: Mono.Security
[DefaultMember("Item")]
public class ASN1 // TypeDefIndex: 16281
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x153AA30 Offset: 0x1539C30 VA: 0x18153AA30
	public void .ctor(byte tag) { }

	// RVA: 0x153AA60 Offset: 0x1539C60 VA: 0x18153AA60
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x153A8B0 Offset: 0x1539AB0 VA: 0x18153A8B0
	public void .ctor(byte[] data) { }

	// RVA: 0x153AAA0 Offset: 0x1539CA0 VA: 0x18153AAA0
	public int get_Count() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public byte get_Tag() { }

	// RVA: 0x1321B50 Offset: 0x1320D50 VA: 0x181321B50
	public int get_Length() { }

	// RVA: 0x153ABB0 Offset: 0x1539DB0 VA: 0x18153ABB0
	public byte[] get_Value() { }

	// RVA: 0x153AC50 Offset: 0x1539E50 VA: 0x18153AC50
	public void set_Value(byte[] value) { }

	// RVA: 0x1539A00 Offset: 0x1538C00 VA: 0x181539A00
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x1539A80 Offset: 0x1538C80 VA: 0x181539A80
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1539960 Offset: 0x1538B60 VA: 0x181539960
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1539F20 Offset: 0x1539120 VA: 0x181539F20 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1539C10 Offset: 0x1538E10 VA: 0x181539C10
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1539B00 Offset: 0x1538D00 VA: 0x181539B00
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x153AAD0 Offset: 0x1539CD0 VA: 0x18153AAD0
	public ASN1 get_Item(int index) { }

	// RVA: 0x1539E10 Offset: 0x1539010 VA: 0x181539E10
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x153A590 Offset: 0x1539790 VA: 0x18153A590 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security
public static class ASN1Convert // TypeDefIndex: 16282
{
	// Methods

	// RVA: 0x1538A00 Offset: 0x1537C00 VA: 0x181538A00
	public static ASN1 FromInt32(int value) { }

	// RVA: 0x1538D50 Offset: 0x1537F50 VA: 0x181538D50
	public static ASN1 FromOid(string oid) { }

	// RVA: 0x1538E30 Offset: 0x1538030 VA: 0x181538E30
	public static ASN1 FromUnsignedBigInteger(byte[] big) { }

	// RVA: 0x1539510 Offset: 0x1538710 VA: 0x181539510
	public static int ToInt32(ASN1 asn1) { }

	// RVA: 0x15396D0 Offset: 0x15388D0 VA: 0x1815396D0
	public static string ToOid(ASN1 asn1) { }

	// RVA: 0x1538F40 Offset: 0x1538140 VA: 0x181538F40
	public static DateTime ToDateTime(ASN1 time) { }
}

// Namespace: Mono.Security
internal sealed class BitConverterLE // TypeDefIndex: 16283
{
	// Methods

	// RVA: 0x153BD80 Offset: 0x153AF80 VA: 0x18153BD80
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x153BE00 Offset: 0x153B000 VA: 0x18153BE00
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x153BCF0 Offset: 0x153AEF0 VA: 0x18153BCF0
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x153BC20 Offset: 0x153AE20 VA: 0x18153BC20
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x153BFF0 Offset: 0x153B1F0 VA: 0x18153BFF0
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x153BF80 Offset: 0x153B180 VA: 0x18153BF80
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x153BEC0 Offset: 0x153B0C0 VA: 0x18153BEC0
	internal static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x153BF30 Offset: 0x153B130 VA: 0x18153BF30
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x153BEC0 Offset: 0x153B0C0 VA: 0x18153BEC0
	internal static uint ToUInt32(byte[] value, int startIndex) { }
}

// Namespace: 
public class PKCS7.ContentInfo // TypeDefIndex: 16284
{
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x153C270 Offset: 0x153B470 VA: 0x18153C270
	public void .ctor() { }

	// RVA: 0x153C350 Offset: 0x153B550 VA: 0x18153C350
	public void .ctor(string oid) { }

	// RVA: 0x153C2E0 Offset: 0x153B4E0 VA: 0x18153C2E0
	public void .ctor(byte[] data) { }

	// RVA: 0x153C3D0 Offset: 0x153B5D0 VA: 0x18153C3D0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x153C5C0 Offset: 0x153B7C0 VA: 0x18153C5C0
	public ASN1 get_ASN1() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ASN1 get_Content() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Content(ASN1 value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ContentType() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ContentType(string value) { }

	// RVA: 0x153C090 Offset: 0x153B290 VA: 0x18153C090
	internal ASN1 GetASN1() { }
}

// Namespace: 
public class PKCS7.EncryptedData // TypeDefIndex: 16285
{
	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x153D090 Offset: 0x153C290 VA: 0x18153D090
	public void .ctor() { }

	// RVA: 0x153D0B0 Offset: 0x153C2B0 VA: 0x18153D0B0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x153D490 Offset: 0x153C690 VA: 0x18153D490
	public byte[] get_EncryptedContent() { }
}

// Namespace: 
public class PKCS7.SignedData // TypeDefIndex: 16286
{
	// Fields
	private byte version; // 0x10
	private string hashAlgorithm; // 0x18
	private PKCS7.ContentInfo contentInfo; // 0x20
	private X509CertificateCollection certs; // 0x28
	private ArrayList crls; // 0x30
	private PKCS7.SignerInfo signerInfo; // 0x38
	private bool mda; // 0x40

	// Properties
	public X509CertificateCollection Certificates { get; }
	public PKCS7.ContentInfo ContentInfo { get; }
	public string HashName { set; }
	public PKCS7.SignerInfo SignerInfo { get; }

	// Methods

	// RVA: 0x1547070 Offset: 0x1546270 VA: 0x181547070
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public PKCS7.ContentInfo get_ContentInfo() { }

	// RVA: 0x15478B0 Offset: 0x1546AB0 VA: 0x1815478B0
	public void set_HashName(string value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public PKCS7.SignerInfo get_SignerInfo() { }

	// RVA: 0x1546EE0 Offset: 0x15460E0 VA: 0x181546EE0
	internal string OidToName(string oid) { }
}

// Namespace: 
public class PKCS7.SignerInfo // TypeDefIndex: 16287
{
	// Fields
	private byte version; // 0x10
	private string hashAlgorithm; // 0x18
	private ArrayList authenticatedAttributes; // 0x20
	private ArrayList unauthenticatedAttributes; // 0x28
	private byte[] signature; // 0x30
	private string issuer; // 0x38
	private byte[] serial; // 0x40
	private byte[] ski; // 0x48

	// Properties
	public string IssuerName { get; }
	public byte[] SerialNumber { get; }
	public ArrayList AuthenticatedAttributes { get; }
	public string HashName { get; set; }
	public byte[] Signature { get; }
	public ArrayList UnauthenticatedAttributes { get; }
	public byte Version { get; }

	// Methods

	// RVA: 0x15478D0 Offset: 0x1546AD0 VA: 0x1815478D0
	public void .ctor() { }

	// RVA: 0x1547950 Offset: 0x1546B50 VA: 0x181547950
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_IssuerName() { }

	// RVA: 0x1547DC0 Offset: 0x1546FC0 VA: 0x181547DC0
	public byte[] get_SerialNumber() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ArrayList get_AuthenticatedAttributes() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_HashName() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_HashName(string value) { }

	// RVA: 0x1547E40 Offset: 0x1547040 VA: 0x181547E40
	public byte[] get_Signature() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ArrayList get_UnauthenticatedAttributes() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public byte get_Version() { }
}

// Namespace: Mono.Security
public sealed class PKCS7 // TypeDefIndex: 16288
{}

// Namespace: Mono.Security.X509
internal class SafeBag // TypeDefIndex: 16289
{
	// Fields
	private string _bagOID; // 0x10
	private ASN1 _asn1; // 0x18

	// Properties
	public string BagOID { get; }
	public ASN1 ASN1 { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string bagOID, ASN1 asn1) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_BagOID() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ASN1 get_ASN1() { }
}

// Namespace: 
public class PKCS12.DeriveBytes // TypeDefIndex: 16290
{
	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_HashName(string value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_IterationCount(int value) { }

	// RVA: 0x153CDE0 Offset: 0x153BFE0 VA: 0x18153CDE0
	public void set_Password(byte[] value) { }

	// RVA: 0x153CEB0 Offset: 0x153C0B0 VA: 0x18153CEB0
	public void set_Salt(byte[] value) { }

	// RVA: 0x153C630 Offset: 0x153B830 VA: 0x18153C630
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x153C880 Offset: 0x153BA80 VA: 0x18153C880
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x153C7A0 Offset: 0x153B9A0 VA: 0x18153C7A0
	public byte[] DeriveKey(int size) { }

	// RVA: 0x153C730 Offset: 0x153B930 VA: 0x18153C730
	public byte[] DeriveIV(int size) { }

	// RVA: 0x153C810 Offset: 0x153BA10 VA: 0x18153C810
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x153CCE0 Offset: 0x153BEE0 VA: 0x18153CCE0
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
public class PKCS12 : ICloneable // TypeDefIndex: 16291
{
	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x1546190 Offset: 0x1545390 VA: 0x181546190
	public void .ctor() { }

	// RVA: 0x1546110 Offset: 0x1545310 VA: 0x181546110
	public void .ctor(byte[] data) { }

	// RVA: 0x15460C0 Offset: 0x15452C0 VA: 0x1815460C0
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x153FFD0 Offset: 0x153F1D0 VA: 0x18153FFD0
	private void Decode(byte[] data) { }

	// RVA: 0x1541550 Offset: 0x1540750 VA: 0x181541550 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1546CE0 Offset: 0x1545EE0 VA: 0x181546CE0
	public void set_Password(string value) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public int get_IterationCount() { }

	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	public void set_IterationCount(int value) { }

	// RVA: 0x1546650 Offset: 0x1545850 VA: 0x181546650
	public ArrayList get_Keys() { }

	// RVA: 0x1546260 Offset: 0x1545460 VA: 0x181546260
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1546CB0 Offset: 0x1545EB0 VA: 0x181546CB0
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x153FF60 Offset: 0x153F160 VA: 0x18153FF60
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x1543E20 Offset: 0x1543020 VA: 0x181543E20
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x1540AC0 Offset: 0x153FCC0 VA: 0x181540AC0
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x1540980 Offset: 0x153FB80 VA: 0x181540980
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x1540C00 Offset: 0x153FE00 VA: 0x181540C00
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1543B60 Offset: 0x1542D60 VA: 0x181543B60
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x153F0D0 Offset: 0x153E2D0 VA: 0x18153F0D0
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x1545150 Offset: 0x1544350 VA: 0x181545150
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x15445B0 Offset: 0x15437B0 VA: 0x1815445B0
	private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0x153F370 Offset: 0x153E570 VA: 0x18153F370
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1544400 Offset: 0x1543600 VA: 0x181544400
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x15415D0 Offset: 0x15407D0 VA: 0x1815415D0
	public byte[] GetBytes() { }

	// RVA: 0x1540D60 Offset: 0x153FF60 VA: 0x181540D60
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x153E9B0 Offset: 0x153DBB0 VA: 0x18153E9B0
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x153E9C0 Offset: 0x153DBC0 VA: 0x18153E9C0
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x1546070 Offset: 0x1545270 VA: 0x181546070
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1545A40 Offset: 0x1544C40 VA: 0x181545A40
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x153FEA0 Offset: 0x153F0A0 VA: 0x18153FEA0
	private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2) { }

	// RVA: 0x153ECE0 Offset: 0x153DEE0 VA: 0x18153ECE0
	public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0x153FD60 Offset: 0x153EF60 VA: 0x18153FD60 Slot: 4
	public object Clone() { }

	// RVA: 0x1546C60 Offset: 0x1545E60 VA: 0x181546C60
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x1546080 Offset: 0x1545280 VA: 0x181546080
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
public sealed class X501 // TypeDefIndex: 16292
{
	// Fields
	private static byte[] countryName; // 0x0
	private static byte[] organizationName; // 0x8
	private static byte[] organizationalUnitName; // 0x10
	private static byte[] commonName; // 0x18
	private static byte[] localityName; // 0x20
	private static byte[] stateOrProvinceName; // 0x28
	private static byte[] streetAddress; // 0x30
	private static byte[] serialNumber; // 0x38
	private static byte[] domainComponent; // 0x40
	private static byte[] userid; // 0x48
	private static byte[] email; // 0x50
	private static byte[] dnQualifier; // 0x58
	private static byte[] title; // 0x60
	private static byte[] surname; // 0x68
	private static byte[] givenName; // 0x70
	private static byte[] initial; // 0x78

	// Methods

	// RVA: 0x154A810 Offset: 0x1549A10 VA: 0x18154A810
	public static string ToString(ASN1 seq) { }

	// RVA: 0x154A610 Offset: 0x1549810 VA: 0x18154A610
	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

	// RVA: 0x1548350 Offset: 0x1547550 VA: 0x181548350
	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	// RVA: 0x15490E0 Offset: 0x15482E0 VA: 0x1815490E0
	private static X520.AttributeTypeAndValue GetAttributeFromOid(string attributeType) { }

	// RVA: 0x1549BB0 Offset: 0x1548DB0 VA: 0x181549BB0
	private static bool IsOid(string oid) { }

	// RVA: 0x1549CA0 Offset: 0x1548EA0 VA: 0x181549CA0
	private static X520.AttributeTypeAndValue ReadAttribute(string value, ref int pos) { }

	// RVA: 0x1549AE0 Offset: 0x1548CE0 VA: 0x181549AE0
	private static bool IsHex(char c) { }

	// RVA: 0x1549FE0 Offset: 0x15491E0 VA: 0x181549FE0
	private static string ReadHex(string value, ref int pos) { }

	// RVA: 0x1549E30 Offset: 0x1549030 VA: 0x181549E30
	private static int ReadEscaped(StringBuilder sb, string value, int pos) { }

	// RVA: 0x154A220 Offset: 0x1549420 VA: 0x18154A220
	private static int ReadQuoted(StringBuilder sb, string value, int pos) { }

	// RVA: 0x154A370 Offset: 0x1549570 VA: 0x18154A370
	private static string ReadValue(string value, ref int pos) { }

	// RVA: 0x1548CB0 Offset: 0x1547EB0 VA: 0x181548CB0
	public static ASN1 FromString(string rdn) { }

	// RVA: 0x154A960 Offset: 0x1549B60 VA: 0x18154A960
	private static void .cctor() { }
}

// Namespace: 
public class X509Crl.X509CrlEntry // TypeDefIndex: 16293
{
	// Fields
	private byte[] sn; // 0x10
	private DateTime revocationDate; // 0x18
	private X509ExtensionCollection extensions; // 0x20

	// Properties
	public byte[] SerialNumber { get; }
	public DateTime RevocationDate { get; }
	public X509ExtensionCollection Extensions { get; }

	// Methods

	// RVA: 0x154E530 Offset: 0x154D730 VA: 0x18154E530
	internal void .ctor(ASN1 entry) { }

	// RVA: 0x154E620 Offset: 0x154D820 VA: 0x18154E620
	public byte[] get_SerialNumber() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public DateTime get_RevocationDate() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public X509ExtensionCollection get_Extensions() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
public class X509Crl // TypeDefIndex: 16294
{
	// Fields
	private string issuer; // 0x10
	private byte version; // 0x18
	private DateTime thisUpdate; // 0x20
	private DateTime nextUpdate; // 0x28
	private ArrayList entries; // 0x30
	private string signatureOID; // 0x38
	private byte[] signature; // 0x40
	private X509ExtensionCollection extensions; // 0x48
	private byte[] encoded; // 0x50
	private byte[] hash_value; // 0x58

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public string IssuerName { get; }
	public DateTime NextUpdate { get; }

	// Methods

	// RVA: 0x154F710 Offset: 0x154E910 VA: 0x18154F710
	public void .ctor(byte[] crl) { }

	// RVA: 0x154E970 Offset: 0x154DB70 VA: 0x18154E970
	private void Parse(byte[] crl) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x154F820 Offset: 0x154EA20 VA: 0x18154F820
	public byte[] get_Hash() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_IssuerName() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public DateTime get_NextUpdate() { }

	// RVA: 0x154AF50 Offset: 0x154A150 VA: 0x18154AF50
	private bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x154E6A0 Offset: 0x154D8A0 VA: 0x18154E6A0
	public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0x154E730 Offset: 0x154D930 VA: 0x18154E730
	public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { }

	// RVA: 0x154F410 Offset: 0x154E610 VA: 0x18154F410
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x154F330 Offset: 0x154E530 VA: 0x18154F330
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x154F060 Offset: 0x154E260 VA: 0x18154F060
	public bool VerifySignature(AsymmetricAlgorithm aa) { }
}

// Namespace: Mono.Security.X509
public class X509Certificate : ISerializable // TypeDefIndex: 16295
{
	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private byte[] certhash; // 0x80
	private RSA _rsa; // 0x88
	private DSA _dsa; // 0x90
	private int version; // 0x98
	private byte[] serialnumber; // 0xA0
	private byte[] issuerUniqueID; // 0xA8
	private byte[] subjectUniqueID; // 0xB0
	private X509ExtensionCollection extensions; // 0xB8
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public virtual string IssuerName { get; }
	public virtual string KeyAlgorithm { get; }
	public virtual byte[] KeyAlgorithmParameters { get; set; }
	public virtual byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual byte[] Signature { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public int Version { get; }
	public bool IsCurrent { get; }
	public bool IsSelfSigned { get; }

	// Methods

	// RVA: 0x154B7D0 Offset: 0x154A9D0 VA: 0x18154B7D0
	private void Parse(byte[] data) { }

	// RVA: 0x154C5C0 Offset: 0x154B7C0 VA: 0x18154C5C0
	public void .ctor(byte[] data) { }

	// RVA: 0x154B610 Offset: 0x154A810 VA: 0x18154B610
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x154C800 Offset: 0x154BA00 VA: 0x18154C800
	public DSA get_DSA() { }

	// RVA: 0x154D790 Offset: 0x154C990 VA: 0x18154D790
	public void set_DSA(DSA value) { }

	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x154CB70 Offset: 0x154BD70 VA: 0x18154CB70
	public byte[] get_Hash() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x154CF50 Offset: 0x154C150 VA: 0x18154CF50 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200 Slot: 8
	public virtual void set_KeyAlgorithmParameters(byte[] value) { }

	// RVA: 0x154CFD0 Offset: 0x154C1D0 VA: 0x18154CFD0 Slot: 9
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x154D050 Offset: 0x154C250 VA: 0x18154D050 Slot: 10
	public virtual RSA get_RSA() { }

	// RVA: 0x154D7B0 Offset: 0x154C9B0 VA: 0x18154D7B0 Slot: 11
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x154D250 Offset: 0x154C450 VA: 0x18154D250 Slot: 12
	public virtual byte[] get_RawData() { }

	// RVA: 0x154D2D0 Offset: 0x154C4D0 VA: 0x18154D2D0 Slot: 13
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x154D360 Offset: 0x154C560 VA: 0x18154D360 Slot: 14
	public virtual byte[] get_Signature() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 15
	public virtual string get_SubjectName() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 16
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 17
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x838410 Offset: 0x837610 VA: 0x180838410
	public int get_Version() { }

	// RVA: 0x154CDB0 Offset: 0x154BFB0 VA: 0x18154CDB0
	public bool get_IsCurrent() { }

	// RVA: 0x154C4A0 Offset: 0x154B6A0 VA: 0x18154C4A0
	public bool WasCurrent(DateTime instant) { }

	// RVA: 0x154C3C0 Offset: 0x154B5C0 VA: 0x18154C3C0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x154C290 Offset: 0x154B490 VA: 0x18154C290
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x154C080 Offset: 0x154B280 VA: 0x18154C080
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0x154CEC0 Offset: 0x154C0C0 VA: 0x18154CEC0
	public bool get_IsSelfSigned() { }

	// RVA: 0x154B5B0 Offset: 0x154A7B0 VA: 0x18154B5B0 Slot: 18
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x154B6B0 Offset: 0x154A8B0 VA: 0x18154B6B0
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x154C570 Offset: 0x154B770 VA: 0x18154C570
	private static void .cctor() { }
}

// Namespace: 
public class X509CertificateCollection.X509CertificateEnumerator : IEnumerator // TypeDefIndex: 16296
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x154B490 Offset: 0x154A690 VA: 0x18154B490
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x154B500 Offset: 0x154A700 VA: 0x18154B500
	public X509Certificate get_Current() { }

	// RVA: 0x154B440 Offset: 0x154A640 VA: 0x18154B440 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x154B3A0 Offset: 0x154A5A0 VA: 0x18154B3A0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x154B3F0 Offset: 0x154A5F0 VA: 0x18154B3F0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x154B350 Offset: 0x154A550 VA: 0x18154B350
	public bool MoveNext() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
[Serializable]
public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 16297
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x154B280 Offset: 0x154A480 VA: 0x18154B280
	public void .ctor() { }

	// RVA: 0x154B290 Offset: 0x154A490 VA: 0x18154B290
	public X509Certificate get_Item(int index) { }

	// RVA: 0x154AEC0 Offset: 0x154A0C0 VA: 0x18154AEC0
	public int Add(X509Certificate value) { }

	// RVA: 0x154ADE0 Offset: 0x1549FE0 VA: 0x18154ADE0
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x154AFC0 Offset: 0x154A1C0 VA: 0x18154AFC0
	public bool Contains(X509Certificate value) { }

	// RVA: 0x154AFE0 Offset: 0x154A1E0 VA: 0x18154AFE0
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x154B250 Offset: 0x154A450 VA: 0x18154B250 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x154B070 Offset: 0x154A270 VA: 0x18154B070
	public int IndexOf(X509Certificate value) { }

	// RVA: 0x154AF50 Offset: 0x154A150 VA: 0x18154AF50
	private bool Compare(byte[] array1, byte[] array2) { }
}

// Namespace: Mono.Security.X509
public class X509Chain // TypeDefIndex: 16298
{
	// Fields
	private X509CertificateCollection roots; // 0x10
	private X509CertificateCollection certs; // 0x18
	private X509Certificate _root; // 0x20
	private X509CertificateCollection _chain; // 0x28
	private X509ChainStatusFlags _status; // 0x30

	// Properties
	public X509CertificateCollection TrustAnchors { get; }

	// Methods

	// RVA: 0x154E440 Offset: 0x154D640 VA: 0x18154E440
	public void .ctor() { }

	// RVA: 0x154E4A0 Offset: 0x154D6A0 VA: 0x18154E4A0
	public X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0x154E300 Offset: 0x154D500 VA: 0x18154E300
	public void LoadCertificates(X509CertificateCollection collection) { }

	// RVA: 0x154D7D0 Offset: 0x154C9D0 VA: 0x18154D7D0
	public bool Build(X509Certificate leaf) { }

	// RVA: 0x154E3F0 Offset: 0x154D5F0 VA: 0x18154E3F0
	public void Reset() { }

	// RVA: 0x154E170 Offset: 0x154D370 VA: 0x18154E170
	private bool IsValid(X509Certificate cert) { }

	// RVA: 0x154DB90 Offset: 0x154CD90 VA: 0x18154DB90
	private X509Certificate FindCertificateParent(X509Certificate child) { }

	// RVA: 0x154DD60 Offset: 0x154CF60 VA: 0x18154DD60
	private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	// RVA: 0x154E130 Offset: 0x154D330 VA: 0x18154E130
	private bool IsTrusted(X509Certificate potentialTrusted) { }

	// RVA: 0x154DFB0 Offset: 0x154D1B0 VA: 0x18154DFB0
	private bool IsParent(X509Certificate child, X509Certificate parent) { }
}

// Namespace: Mono.Security.X509
[Flags]
[Serializable]
public enum X509ChainStatusFlags // TypeDefIndex: 16299
{
	// Fields
	public int value__; // 0x0
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags UntrustedRoot = 32;
}

// Namespace: Mono.Security.X509
public class X509Extension // TypeDefIndex: 16300
{
	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Properties
	public string Oid { get; }
	public bool Critical { get; }
	public ASN1 Value { get; }

	// Methods

	// RVA: 0x1550260 Offset: 0x154F460 VA: 0x181550260
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1550570 Offset: 0x154F770 VA: 0x181550570
	public void .ctor(X509Extension extension) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void Encode() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Oid() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_Critical() { }

	// RVA: 0x15506E0 Offset: 0x154F8E0 VA: 0x1815506E0
	public ASN1 get_Value() { }

	// RVA: 0x154FD90 Offset: 0x154EF90 VA: 0x18154FD90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1550020 Offset: 0x154F220 VA: 0x181550020
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x154FF00 Offset: 0x154F100 VA: 0x18154FF00 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 16301
{
	// Fields
	private bool readOnly; // 0x18

	// Properties
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x154B280 Offset: 0x154A480 VA: 0x18154B280
	public void .ctor() { }

	// RVA: 0x154FB60 Offset: 0x154ED60 VA: 0x18154FB60
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x154F990 Offset: 0x154EB90 VA: 0x18154F990
	public int IndexOf(string oid) { }

	// RVA: 0x154B250 Offset: 0x154A450 VA: 0x18154B250 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x154FCB0 Offset: 0x154EEB0 VA: 0x18154FCB0
	public X509Extension get_Item(string oid) { }
}

// Namespace: Mono.Security.X509
public class X509Store // TypeDefIndex: 16302
{
	// Fields
	private string _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private bool _crl; // 0x28
	private bool _newFormat; // 0x29

	// Properties
	public X509CertificateCollection Certificates { get; }
	public ArrayList Crls { get; }

	// Methods

	// RVA: 0x15529A0 Offset: 0x1551BA0 VA: 0x1815529A0
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0x15529F0 Offset: 0x1551BF0 VA: 0x1815529F0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1552A20 Offset: 0x1551C20 VA: 0x181552A20
	public ArrayList get_Crls() { }

	// RVA: 0x15516C0 Offset: 0x15508C0 VA: 0x1815516C0
	private void ClearCertificates() { }

	// RVA: 0x1551F40 Offset: 0x1551140 VA: 0x181551F40
	public void Import(X509Certificate certificate) { }

	// RVA: 0x1552840 Offset: 0x1551A40 VA: 0x181552840
	public void Remove(X509Certificate certificate) { }

	// RVA: 0x1551D10 Offset: 0x1550F10 VA: 0x181551D10
	private void ImportNewFormat(X509Certificate certificate) { }

	// RVA: 0x1552690 Offset: 0x1551890 VA: 0x181552690
	private void RemoveNewFormat(X509Certificate certificate) { }

	// RVA: 0x1551700 Offset: 0x1550900 VA: 0x181551700
	private string GetUniqueNameWithSerial(X509Certificate certificate) { }

	// RVA: 0x1551750 Offset: 0x1550950 VA: 0x181551750
	private string GetUniqueName(X509Certificate certificate, byte[] serial) { }

	// RVA: 0x1551A50 Offset: 0x1550C50 VA: 0x181551A50
	private byte[] GetUniqueName(X509ExtensionCollection extensions, byte[] serial) { }

	// RVA: 0x1551BB0 Offset: 0x1550DB0 VA: 0x181551BB0
	private string GetUniqueName(string method, byte[] name, string fileExtension) { }

	// RVA: 0x1552530 Offset: 0x1551730 VA: 0x181552530
	private byte[] Load(string filename) { }

	// RVA: 0x1552370 Offset: 0x1551570 VA: 0x181552370
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0x15523E0 Offset: 0x15515E0 VA: 0x1815523E0
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0x1551660 Offset: 0x1550860 VA: 0x181551660
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0x1551350 Offset: 0x1550550 VA: 0x181551350
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0x1551510 Offset: 0x1550710 VA: 0x181551510
	private ArrayList BuildCrlsCollection(string storeName) { }
}

// Namespace: Mono.Security.X509
public sealed class X509StoreManager // TypeDefIndex: 16303
{
	// Fields
	private static string _userPath; // 0x0
	private static string _localMachinePath; // 0x8
	private static string _newUserPath; // 0x10
	private static string _newLocalMachinePath; // 0x18
	private static X509Stores _userStore; // 0x20
	private static X509Stores _machineStore; // 0x28

	// Properties
	internal static string CurrentUserPath { get; }
	internal static string LocalMachinePath { get; }
	internal static string NewCurrentUserPath { get; }
	internal static string NewLocalMachinePath { get; }
	public static X509Stores CurrentUser { get; }
	public static X509Stores LocalMachine { get; }
	public static X509CertificateCollection TrustedRootCertificates { get; }

	// Methods

	// RVA: 0x1550720 Offset: 0x154F920 VA: 0x181550720
	internal static string get_CurrentUserPath() { }

	// RVA: 0x15509A0 Offset: 0x154FBA0 VA: 0x1815509A0
	internal static string get_LocalMachinePath() { }

	// RVA: 0x1550C30 Offset: 0x154FE30 VA: 0x181550C30
	internal static string get_NewCurrentUserPath() { }

	// RVA: 0x1550D30 Offset: 0x154FF30 VA: 0x181550D30
	internal static string get_NewLocalMachinePath() { }

	// RVA: 0x1550820 Offset: 0x154FA20 VA: 0x181550820
	public static X509Stores get_CurrentUser() { }

	// RVA: 0x1550AA0 Offset: 0x154FCA0 VA: 0x181550AA0
	public static X509Stores get_LocalMachine() { }

	// RVA: 0x1550E30 Offset: 0x1550030 VA: 0x181550E30
	public static X509CertificateCollection get_TrustedRootCertificates() { }
}

// Namespace: Mono.Security.X509
public class X509Stores // TypeDefIndex: 16304
{
	// Fields
	private string _storePath; // 0x10
	private bool _newFormat; // 0x18
	private X509Store _trusted; // 0x20

	// Properties
	public X509Store TrustedRoot { get; }

	// Methods

	// RVA: 0x11FF670 Offset: 0x11FE870 VA: 0x1811FF670
	internal void .ctor(string path, bool newFormat) { }

	// RVA: 0x1552BC0 Offset: 0x1551DC0 VA: 0x181552BC0
	public X509Store get_TrustedRoot() { }

	// RVA: 0x1552AA0 Offset: 0x1551CA0 VA: 0x181552AA0
	public X509Store Open(string storeName, bool create) { }
}

// Namespace: 
public abstract class X520.AttributeTypeAndValue // TypeDefIndex: 16305
{
	// Fields
	private string oid; // 0x10
	private string attrValue; // 0x18
	private int upperBound; // 0x20
	private byte encoding; // 0x24

	// Properties
	public string Value { set; }

	// Methods

	// RVA: 0x153B0F0 Offset: 0x153A2F0 VA: 0x18153B0F0
	protected void .ctor(string oid, int upperBound) { }

	// RVA: 0x153B130 Offset: 0x153A330 VA: 0x18153B130
	protected void .ctor(string oid, int upperBound, byte encoding) { }

	// RVA: 0x153B180 Offset: 0x153A380 VA: 0x18153B180
	public void set_Value(string value) { }

	// RVA: 0x153AD10 Offset: 0x1539F10 VA: 0x18153AD10
	internal ASN1 GetASN1(byte encoding) { }

	// RVA: 0x153AD00 Offset: 0x1539F00 VA: 0x18153AD00
	internal ASN1 GetASN1() { }

	// RVA: 0x153B080 Offset: 0x153A280 VA: 0x18153B080
	private byte SelectBestEncoding() { }
}

// Namespace: 
public class X520.CommonName : X520.AttributeTypeAndValue // TypeDefIndex: 16306
{
	// Methods

	// RVA: 0x153C030 Offset: 0x153B230 VA: 0x18153C030
	public void .ctor() { }
}

// Namespace: 
public class X520.SerialNumber : X520.AttributeTypeAndValue // TypeDefIndex: 16307
{
	// Methods

	// RVA: 0x1546E80 Offset: 0x1546080 VA: 0x181546E80
	public void .ctor() { }
}

// Namespace: 
public class X520.LocalityName : X520.AttributeTypeAndValue // TypeDefIndex: 16308
{
	// Methods

	// RVA: 0x153E850 Offset: 0x153DA50 VA: 0x18153E850
	public void .ctor() { }
}

// Namespace: 
public class X520.StateOrProvinceName : X520.AttributeTypeAndValue // TypeDefIndex: 16309
{
	// Methods

	// RVA: 0x1547EC0 Offset: 0x15470C0 VA: 0x181547EC0
	public void .ctor() { }
}

// Namespace: 
public class X520.OrganizationName : X520.AttributeTypeAndValue // TypeDefIndex: 16310
{
	// Methods

	// RVA: 0x153E8F0 Offset: 0x153DAF0 VA: 0x18153E8F0
	public void .ctor() { }
}

// Namespace: 
public class X520.OrganizationalUnitName : X520.AttributeTypeAndValue // TypeDefIndex: 16311
{
	// Methods

	// RVA: 0x153E950 Offset: 0x153DB50 VA: 0x18153E950
	public void .ctor() { }
}

// Namespace: 
public class X520.EmailAddress : X520.AttributeTypeAndValue // TypeDefIndex: 16312
{
	// Methods

	// RVA: 0x153D030 Offset: 0x153C230 VA: 0x18153D030
	public void .ctor() { }
}

// Namespace: 
public class X520.DomainComponent : X520.AttributeTypeAndValue // TypeDefIndex: 16313
{
	// Methods

	// RVA: 0x153CFD0 Offset: 0x153C1D0 VA: 0x18153CFD0
	public void .ctor() { }
}

// Namespace: 
public class X520.UserId : X520.AttributeTypeAndValue // TypeDefIndex: 16314
{
	// Methods

	// RVA: 0x15482F0 Offset: 0x15474F0 VA: 0x1815482F0
	public void .ctor() { }
}

// Namespace: 
public class X520.Oid : X520.AttributeTypeAndValue // TypeDefIndex: 16315
{
	// Methods

	// RVA: 0x153E8B0 Offset: 0x153DAB0 VA: 0x18153E8B0
	public void .ctor(string oid) { }
}

// Namespace: 
public class X520.Title : X520.AttributeTypeAndValue // TypeDefIndex: 16316
{
	// Methods

	// RVA: 0x1548290 Offset: 0x1547490 VA: 0x181548290
	public void .ctor() { }
}

// Namespace: 
public class X520.CountryName : X520.AttributeTypeAndValue // TypeDefIndex: 16317
{
	// Methods

	// RVA: 0x153C5D0 Offset: 0x153B7D0 VA: 0x18153C5D0
	public void .ctor() { }
}

// Namespace: 
public class X520.DnQualifier : X520.AttributeTypeAndValue // TypeDefIndex: 16318
{
	// Methods

	// RVA: 0x153CF70 Offset: 0x153C170 VA: 0x18153CF70
	public void .ctor() { }
}

// Namespace: 
public class X520.Surname : X520.AttributeTypeAndValue // TypeDefIndex: 16319
{
	// Methods

	// RVA: 0x1548230 Offset: 0x1547430 VA: 0x181548230
	public void .ctor() { }
}

// Namespace: 
public class X520.GivenName : X520.AttributeTypeAndValue // TypeDefIndex: 16320
{
	// Methods

	// RVA: 0x153E780 Offset: 0x153D980 VA: 0x18153E780
	public void .ctor() { }
}

// Namespace: 
public class X520.Initial : X520.AttributeTypeAndValue // TypeDefIndex: 16321
{
	// Methods

	// RVA: 0x153E7E0 Offset: 0x153D9E0 VA: 0x18153E7E0
	public void .ctor() { }
}

// Namespace: Mono.Security.X509
public class X520 // TypeDefIndex: 16322
{}

// Namespace: Mono.Security.X509.Extensions
public class AuthorityKeyIdentifierExtension : X509Extension // TypeDefIndex: 16323
{
	// Fields
	private byte[] aki; // 0x28

	// Properties
	public byte[] Identifier { get; }

	// Methods

	// RVA: 0x153B6F0 Offset: 0x153A8F0 VA: 0x18153B6F0
	public void .ctor(X509Extension extension) { }

	// RVA: 0x153B240 Offset: 0x153A440 VA: 0x18153B240 Slot: 4
	protected override void Decode() { }

	// RVA: 0x153B380 Offset: 0x153A580 VA: 0x18153B380 Slot: 5
	protected override void Encode() { }

	// RVA: 0x153B700 Offset: 0x153A900 VA: 0x18153B700
	public byte[] get_Identifier() { }

	// RVA: 0x153B560 Offset: 0x153A760 VA: 0x18153B560 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.X509.Extensions
public class BasicConstraintsExtension : X509Extension // TypeDefIndex: 16324
{
	// Fields
	private bool cA; // 0x28
	private int pathLenConstraint; // 0x2C

	// Properties
	public bool CertificateAuthority { get; }

	// Methods

	// RVA: 0x153B6F0 Offset: 0x153A8F0 VA: 0x18153B6F0
	public void .ctor(X509Extension extension) { }

	// RVA: 0x153B780 Offset: 0x153A980 VA: 0x18153B780 Slot: 4
	protected override void Decode() { }

	// RVA: 0x153B8C0 Offset: 0x153AAC0 VA: 0x18153B8C0 Slot: 5
	protected override void Encode() { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_CertificateAuthority() { }

	// RVA: 0x153BAB0 Offset: 0x153ACB0 VA: 0x18153BAB0 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.X509.Extensions
internal class GeneralNames // TypeDefIndex: 16325
{
	// Fields
	private ArrayList rfc822Name; // 0x10
	private ArrayList dnsName; // 0x18
	private ArrayList directoryNames; // 0x20
	private ArrayList uris; // 0x28
	private ArrayList ipAddr; // 0x30

	// Properties
	public string[] DNSNames { get; }
	public string[] IPAddresses { get; }

	// Methods

	// RVA: 0x153E120 Offset: 0x153D320 VA: 0x18153E120
	public void .ctor(ASN1 sequence) { }

	// RVA: 0x153E5C0 Offset: 0x153D7C0 VA: 0x18153E5C0
	public string[] get_DNSNames() { }

	// RVA: 0x153E6A0 Offset: 0x153D8A0 VA: 0x18153E6A0
	public string[] get_IPAddresses() { }

	// RVA: 0x153D510 Offset: 0x153C710 VA: 0x18153D510 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.X509.Extensions
public class SubjectAltNameExtension : X509Extension // TypeDefIndex: 16326
{
	// Fields
	private GeneralNames _names; // 0x28

	// Properties
	public string[] DNSNames { get; }
	public string[] IPAddresses { get; }

	// Methods

	// RVA: 0x153B6F0 Offset: 0x153A8F0 VA: 0x18153B6F0
	public void .ctor(X509Extension extension) { }

	// RVA: 0x1547F20 Offset: 0x1547120 VA: 0x181547F20 Slot: 4
	protected override void Decode() { }

	// RVA: 0x1548050 Offset: 0x1547250 VA: 0x181548050
	public string[] get_DNSNames() { }

	// RVA: 0x1548140 Offset: 0x1547340 VA: 0x181548140
	public string[] get_IPAddresses() { }

	// RVA: 0x1548020 Offset: 0x1547220 VA: 0x181548020 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.X509.Extensions
public class SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 16327
{
	// Fields
	private byte[] ski; // 0x28

	// Properties
	public byte[] Identifier { get; }

	// Methods

	// RVA: 0x153B6F0 Offset: 0x153A8F0 VA: 0x18153B6F0
	public void .ctor(X509Extension extension) { }

	// RVA: 0x1567DF0 Offset: 0x1566FF0 VA: 0x181567DF0 Slot: 4
	protected override void Decode() { }

	// RVA: 0x1567ED0 Offset: 0x15670D0 VA: 0x181567ED0 Slot: 5
	protected override void Encode() { }

	// RVA: 0x1568140 Offset: 0x1567340 VA: 0x181568140
	public byte[] get_Identifier() { }

	// RVA: 0x1567FC0 Offset: 0x15671C0 VA: 0x181567FC0 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
public class ChallengeResponse : IDisposable // TypeDefIndex: 16328
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x155B5C0 Offset: 0x155A7C0 VA: 0x18155B5C0
	public void .ctor() { }

	// RVA: 0x155B410 Offset: 0x155A610 VA: 0x18155B410
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x155ACB0 Offset: 0x1559EB0 VA: 0x18155ACB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x155B860 Offset: 0x155AA60 VA: 0x18155B860
	public void set_Password(string value) { }

	// RVA: 0x155B710 Offset: 0x155A910 VA: 0x18155B710
	public void set_Challenge(byte[] value) { }

	// RVA: 0x155B630 Offset: 0x155A830 VA: 0x18155B630
	public byte[] get_LM() { }

	// RVA: 0x155B6A0 Offset: 0x155A8A0 VA: 0x18155B6A0
	public byte[] get_NT() { }

	// RVA: 0x155AB80 Offset: 0x1559D80 VA: 0x18155AB80 Slot: 4
	public void Dispose() { }

	// RVA: 0x155AC30 Offset: 0x1559E30 VA: 0x18155AC30
	private void Dispose(bool disposing) { }

	// RVA: 0x155ADC0 Offset: 0x1559FC0 VA: 0x18155ADC0
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x155B170 Offset: 0x155A370 VA: 0x18155B170
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x155B010 Offset: 0x155A210 VA: 0x18155B010
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x155B350 Offset: 0x155A550 VA: 0x18155B350
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public static class ChallengeResponse2 // TypeDefIndex: 16329
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x15597D0 Offset: 0x15589D0 VA: 0x1815597D0
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x1559AC0 Offset: 0x1558CC0 VA: 0x181559AC0
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x1559BD0 Offset: 0x1558DD0 VA: 0x181559BD0
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x1559C40 Offset: 0x1558E40 VA: 0x181559C40
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1559E60 Offset: 0x1559060 VA: 0x181559E60
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x155A2D0 Offset: 0x15594D0 VA: 0x18155A2D0
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x155A4F0 Offset: 0x15596F0 VA: 0x18155A4F0
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x155A8D0 Offset: 0x1559AD0 VA: 0x18155A8D0
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x155A750 Offset: 0x1559950 VA: 0x18155A750
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x155AAC0 Offset: 0x1559CC0 VA: 0x18155AAC0
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public abstract class MessageBase // TypeDefIndex: 16330
{
	// Fields
	private static byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Properties
	public NtlmFlags Flags { get; set; }
	public int Type { get; }

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	protected void .ctor(int messageType) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public NtlmFlags get_Flags() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_Type() { }

	// RVA: 0x1561520 Offset: 0x1560720 VA: 0x181561520
	protected byte[] PrepareMessage(int messageSize) { }

	// RVA: 0x15612A0 Offset: 0x15604A0 VA: 0x1815612A0 Slot: 4
	protected virtual void Decode(byte[] message) { }

	// RVA: 0x1561190 Offset: 0x1560390 VA: 0x181561190
	protected bool CheckHeader(byte[] message) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] GetBytes();

	// RVA: 0x1561610 Offset: 0x1560810 VA: 0x181561610
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public enum NtlmAuthLevel // TypeDefIndex: 16331
{
	// Fields
	public int value__; // 0x0
	public const NtlmAuthLevel LM_and_NTLM = 0;
	public const NtlmAuthLevel LM_and_NTLM_and_try_NTLMv2_Session = 1;
	public const NtlmAuthLevel NTLM_only = 2;
	public const NtlmAuthLevel NTLMv2_only = 3;
}

// Namespace: Mono.Security.Protocol.Ntlm
[Flags]
public enum NtlmFlags // TypeDefIndex: 16332
{
	// Fields
	public int value__; // 0x0
	public const NtlmFlags NegotiateUnicode = 1;
	public const NtlmFlags NegotiateOem = 2;
	public const NtlmFlags RequestTarget = 4;
	public const NtlmFlags NegotiateNtlm = 512;
	public const NtlmFlags NegotiateDomainSupplied = 4096;
	public const NtlmFlags NegotiateWorkstationSupplied = 8192;
	public const NtlmFlags NegotiateAlwaysSign = 32768;
	public const NtlmFlags NegotiateNtlm2Key = 524288;
	public const NtlmFlags Negotiate128 = 536870912;
	public const NtlmFlags Negotiate56 = -2147483648;
}

// Namespace: Mono.Security.Protocol.Ntlm
public static class NtlmSettings // TypeDefIndex: 16333
{
	// Fields
	private static NtlmAuthLevel defaultAuthLevel; // 0x0

	// Properties
	public static NtlmAuthLevel DefaultAuthLevel { get; }

	// Methods

	// RVA: 0x1562A10 Offset: 0x1561C10 VA: 0x181562A10
	public static NtlmAuthLevel get_DefaultAuthLevel() { }

	// RVA: 0x15629D0 Offset: 0x1561BD0 VA: 0x1815629D0
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type1Message : MessageBase // TypeDefIndex: 16334
{
	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x1568890 Offset: 0x1567A90 VA: 0x181568890
	public void .ctor() { }

	// RVA: 0x1568900 Offset: 0x1567B00 VA: 0x181568900
	public void set_Domain(string value) { }

	// RVA: 0x1568970 Offset: 0x1567B70 VA: 0x181568970
	public void set_Host(string value) { }

	// RVA: 0x15684C0 Offset: 0x15676C0 VA: 0x1815684C0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x15685C0 Offset: 0x15677C0 VA: 0x1815685C0 Slot: 5
	public override byte[] GetBytes() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type2Message : MessageBase // TypeDefIndex: 16335
{
	// Fields
	private byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private byte[] _targetInfo; // 0x28

	// Properties
	public byte[] Nonce { get; }
	public string TargetName { get; }
	public byte[] TargetInfo { get; }

	// Methods

	// RVA: 0x1568C90 Offset: 0x1567E90 VA: 0x181568C90
	public void .ctor(byte[] message) { }

	// RVA: 0x1568B50 Offset: 0x1567D50 VA: 0x181568B50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1568D30 Offset: 0x1567F30 VA: 0x181568D30
	public byte[] get_Nonce() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_TargetName() { }

	// RVA: 0x1568DB0 Offset: 0x1567FB0 VA: 0x181568DB0
	public byte[] get_TargetInfo() { }

	// RVA: 0x15689E0 Offset: 0x1567BE0 VA: 0x1815689E0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1568BC0 Offset: 0x1567DC0 VA: 0x181568BC0 Slot: 5
	public override byte[] GetBytes() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type3Message : MessageBase // TypeDefIndex: 16336
{
	// Fields
	private NtlmAuthLevel _level; // 0x18
	private byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private byte[] _lm; // 0x50
	private byte[] _nt; // 0x58

	// Properties
	public string Domain { set; }
	public string Password { set; }
	public string Username { set; }

	// Methods

	// RVA: 0x1569C50 Offset: 0x1568E50 VA: 0x181569C50
	public void .ctor(Type2Message type2) { }

	// RVA: 0x15691B0 Offset: 0x15683B0 VA: 0x1815691B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1569E60 Offset: 0x1569060 VA: 0x181569E60
	public void set_Domain(string value) { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_Password(string value) { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Username(string value) { }

	// RVA: 0x1568EA0 Offset: 0x15680A0 VA: 0x181568EA0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1568E30 Offset: 0x1568030 VA: 0x181568E30
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x1569120 Offset: 0x1568320 VA: 0x181569120
	private byte[] EncodeString(string text) { }

	// RVA: 0x1569270 Offset: 0x1568470 VA: 0x181569270 Slot: 5
	public override byte[] GetBytes() { }
}

// Namespace: Mono.Security.Interface
public enum AlertLevel // TypeDefIndex: 16337
{
	// Fields
	public byte value__; // 0x0
	public const AlertLevel Warning = 1;
	public const AlertLevel Fatal = 2;
}

// Namespace: Mono.Security.Interface
public enum AlertDescription // TypeDefIndex: 16338
{
	// Fields
	public byte value__; // 0x0
	public const AlertDescription CloseNotify = 0;
	public const AlertDescription UnexpectedMessage = 10;
	public const AlertDescription BadRecordMAC = 20;
	public const AlertDescription DecryptionFailed_RESERVED = 21;
	public const AlertDescription RecordOverflow = 22;
	public const AlertDescription DecompressionFailure = 30;
	public const AlertDescription HandshakeFailure = 40;
	public const AlertDescription NoCertificate_RESERVED = 41;
	public const AlertDescription BadCertificate = 42;
	public const AlertDescription UnsupportedCertificate = 43;
	public const AlertDescription CertificateRevoked = 44;
	public const AlertDescription CertificateExpired = 45;
	public const AlertDescription CertificateUnknown = 46;
	public const AlertDescription IlegalParameter = 47;
	public const AlertDescription UnknownCA = 48;
	public const AlertDescription AccessDenied = 49;
	public const AlertDescription DecodeError = 50;
	public const AlertDescription DecryptError = 51;
	public const AlertDescription ExportRestriction = 60;
	public const AlertDescription ProtocolVersion = 70;
	public const AlertDescription InsuficientSecurity = 71;
	public const AlertDescription InternalError = 80;
	public const AlertDescription UserCancelled = 90;
	public const AlertDescription NoRenegotiation = 100;
	public const AlertDescription UnsupportedExtension = 110;
}

// Namespace: Mono.Security.Interface
public class Alert // TypeDefIndex: 16339
{
	// Fields
	private AlertLevel level; // 0x10
	private AlertDescription description; // 0x11

	// Properties
	public AlertLevel Level { get; }
	public AlertDescription Description { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public AlertLevel get_Level() { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public AlertDescription get_Description() { }

	// RVA: 0x15539F0 Offset: 0x1552BF0 VA: 0x1815539F0
	public void .ctor(AlertDescription description) { }

	// RVA: 0x1553A90 Offset: 0x1552C90 VA: 0x181553A90
	private void inferAlertLevel() { }

	// RVA: 0x1553950 Offset: 0x1552B50 VA: 0x181553950 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.Interface
public class ValidationResult // TypeDefIndex: 16340
{
	// Fields
	private bool trusted; // 0x10
	private bool user_denied; // 0x11
	private int error_code; // 0x14
	private Nullable<MonoSslPolicyErrors> policy_errors; // 0x18

	// Properties
	public bool Trusted { get; }
	public bool UserDenied { get; }

	// Methods

	// RVA: 0x1569ED0 Offset: 0x15690D0 VA: 0x181569ED0
	public void .ctor(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Trusted() { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_UserDenied() { }
}

// Namespace: Mono.Security.Interface
public interface ICertificateValidator // TypeDefIndex: 16341
{}

// Namespace: Mono.Security.Interface
public enum CipherAlgorithmType // TypeDefIndex: 16342
{
	// Fields
	public int value__; // 0x0
	public const CipherAlgorithmType None = 0;
	public const CipherAlgorithmType Aes128 = 1;
	public const CipherAlgorithmType Aes256 = 2;
	public const CipherAlgorithmType AesGcm128 = 3;
	public const CipherAlgorithmType AesGcm256 = 4;
}

// Namespace: Mono.Security.Interface
[CLSCompliant(False)]
public enum CipherSuiteCode // TypeDefIndex: 16343
{
	// Fields
	public ushort value__; // 0x0
	public const CipherSuiteCode TLS_NULL_WITH_NULL_NULL = 0;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_MD5 = 1;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_SHA = 2;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3;
	public const CipherSuiteCode TLS_RSA_WITH_RC4_128_MD5 = 4;
	public const CipherSuiteCode TLS_RSA_WITH_RC4_128_SHA = 5;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6;
	public const CipherSuiteCode TLS_RSA_WITH_IDEA_CBC_SHA = 7;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8;
	public const CipherSuiteCode TLS_RSA_WITH_DES_CBC_SHA = 9;
	public const CipherSuiteCode TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10;
	public const CipherSuiteCode TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11;
	public const CipherSuiteCode TLS_DH_DSS_WITH_DES_CBC_SHA = 12;
	public const CipherSuiteCode TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13;
	public const CipherSuiteCode TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14;
	public const CipherSuiteCode TLS_DH_RSA_WITH_DES_CBC_SHA = 15;
	public const CipherSuiteCode TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16;
	public const CipherSuiteCode TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_DES_CBC_SHA = 18;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19;
	public const CipherSuiteCode TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_DES_CBC_SHA = 21;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22;
	public const CipherSuiteCode TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23;
	public const CipherSuiteCode TLS_DH_anon_WITH_RC4_128_MD5 = 24;
	public const CipherSuiteCode TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25;
	public const CipherSuiteCode TLS_DH_anon_WITH_DES_CBC_SHA = 26;
	public const CipherSuiteCode TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA = 47;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA = 52;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA = 53;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA = 58;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197;
	public const CipherSuiteCode TLS_RSA_WITH_SEED_CBC_SHA = 150;
	public const CipherSuiteCode TLS_DH_DSS_WITH_SEED_CBC_SHA = 151;
	public const CipherSuiteCode TLS_DH_RSA_WITH_SEED_CBC_SHA = 152;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154;
	public const CipherSuiteCode TLS_DH_anon_WITH_SEED_CBC_SHA = 155;
	public const CipherSuiteCode TLS_PSK_WITH_RC4_128_SHA = 138;
	public const CipherSuiteCode TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA = 140;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA = 141;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_RC4_128_SHA = 142;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_RC4_128_SHA = 146;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_NULL_SHA = 49163;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_NULL_SHA = 49168;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_NULL_SHA = 49173;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_RC4_128_SHA = 49174;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA = 44;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA = 45;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA = 46;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_SHA256 = 59;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA256 = 60;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA256 = 61;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_GCM_SHA256 = 156;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_GCM_SHA384 = 157;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_GCM_SHA256 = 168;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_GCM_SHA384 = 169;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA256 = 174;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA384 = 175;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA256 = 176;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA384 = 177;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA256 = 180;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA384 = 181;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA256 = 184;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA384 = 185;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA = 49209;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211;
	public const CipherSuiteCode TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CCM = 49308;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CCM = 49309;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM = 49310;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM = 49311;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CCM_8 = 49312;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CCM_8 = 49313;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CCM = 49316;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CCM = 49317;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CCM = 49318;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CCM = 49319;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CCM_8 = 49320;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CCM_8 = 49321;
	public const CipherSuiteCode TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322;
	public const CipherSuiteCode TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245;
	public const CipherSuiteCode TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384;
	public const CipherSuiteCode TLS_RSA_WITH_SALSA20_SHA1 = 58385;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389;
	public const CipherSuiteCode TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390;
	public const CipherSuiteCode TLS_PSK_WITH_SALSA20_SHA1 = 58391;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399;
	public const CipherSuiteCode TLS_FALLBACK_SCSV = 22016;
}

// Namespace: Mono.Security.Interface
public enum ExchangeAlgorithmType // TypeDefIndex: 16344
{
	// Fields
	public int value__; // 0x0
	public const ExchangeAlgorithmType None = 0;
	public const ExchangeAlgorithmType Dhe = 1;
	public const ExchangeAlgorithmType Rsa = 2;
	public const ExchangeAlgorithmType EcDhe = 3;
}

// Namespace: Mono.Security.Interface
public enum HashAlgorithmType // TypeDefIndex: 16345
{
	// Fields
	public int value__; // 0x0
	public const HashAlgorithmType None = 0;
	public const HashAlgorithmType Md5 = 1;
	public const HashAlgorithmType Sha1 = 2;
	public const HashAlgorithmType Sha224 = 3;
	public const HashAlgorithmType Sha256 = 4;
	public const HashAlgorithmType Sha384 = 5;
	public const HashAlgorithmType Sha512 = 6;
	public const HashAlgorithmType Unknown = 255;
	public const HashAlgorithmType Md5Sha1 = 254;
}

// Namespace: Mono.Security.Interface
internal sealed class MonoServerCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 16346
{
	// Methods

	// RVA: 0x1206180 Offset: 0x1205380 VA: 0x181206180
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual X509Certificate Invoke(object sender, string hostName) { }
}

// Namespace: Mono.Security.Interface
internal interface IMonoAuthenticationOptions // TypeDefIndex: 16347
{}

// Namespace: Mono.Security.Interface
internal interface IMonoSslClientAuthenticationOptions : IMonoAuthenticationOptions // TypeDefIndex: 16348
{}

// Namespace: Mono.Security.Interface
internal interface IMonoSslServerAuthenticationOptions : IMonoAuthenticationOptions // TypeDefIndex: 16349
{
	// Properties
	public abstract MonoServerCertificateSelectionCallback ServerCertificateSelectionCallback { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MonoServerCertificateSelectionCallback get_ServerCertificateSelectionCallback();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_ServerCertificateSelectionCallback(MonoServerCertificateSelectionCallback value);
}

// Namespace: Mono.Security.Interface
public interface IMonoSslStream : IDisposable // TypeDefIndex: 16350
{
	// Properties
	public abstract MonoTlsProvider Provider { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MonoTlsProvider get_Provider();
}

// Namespace: Mono.Security.Interface
public class MonoTlsConnectionInfo // TypeDefIndex: 16351
{
	// Fields
	[CompilerGenerated]
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	[CompilerGenerated]
	private CipherAlgorithmType <CipherAlgorithmType>k__BackingField; // 0x18
	[CompilerGenerated]
	private HashAlgorithmType <HashAlgorithmType>k__BackingField; // 0x1C
	[CompilerGenerated]
	private ExchangeAlgorithmType <ExchangeAlgorithmType>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <PeerDomainName>k__BackingField; // 0x28

	// Properties
	[CLSCompliant(False)]
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public CipherAlgorithmType CipherAlgorithmType { get; }
	public HashAlgorithmType HashAlgorithmType { get; }
	public ExchangeAlgorithmType ExchangeAlgorithmType { get; }
	public string PeerDomainName { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9050 Offset: 0x3D8250 VA: 0x1803D9050
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public CipherAlgorithmType get_CipherAlgorithmType() { }

	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public HashAlgorithmType get_HashAlgorithmType() { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public ExchangeAlgorithmType get_ExchangeAlgorithmType() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_PeerDomainName(string value) { }

	// RVA: 0x15624A0 Offset: 0x15616A0 VA: 0x1815624A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Mono.Security.Interface
[Flags]
public enum MonoSslPolicyErrors // TypeDefIndex: 16352
{
	// Fields
	public int value__; // 0x0
	public const MonoSslPolicyErrors None = 0;
	public const MonoSslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const MonoSslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const MonoSslPolicyErrors RemoteCertificateChainErrors = 4;
}

// Namespace: Mono.Security.Interface
public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 16353
{
	// Methods

	// RVA: 0x15623F0 Offset: 0x15615F0 VA: 0x1815623F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }
}

// Namespace: Mono.Security.Interface
public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 16354
{
	// Methods

	// RVA: 0x1562340 Offset: 0x1561540 VA: 0x181562340
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}

// Namespace: Mono.Security.Interface
public abstract class MonoTlsProvider // TypeDefIndex: 16355
{
	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal virtual bool HasNativeCertificates { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	internal virtual bool get_HasNativeCertificates() { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool get_SupportsCleanShutdown();
}

// Namespace: Mono.Security.Interface
public static class MonoTlsProviderFactory // TypeDefIndex: 16356
{
	// Methods

	// RVA: 0x1562540 Offset: 0x1561740 VA: 0x181562540
	public static MonoTlsProvider GetProvider() { }
}

// Namespace: Mono.Security.Interface
public sealed class MonoTlsSettings // TypeDefIndex: 16357
{
	// Fields
	[CompilerGenerated]
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	[CompilerGenerated]
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	[CompilerGenerated]
	private object <UserSettings>k__BackingField; // 0x38
	[CompilerGenerated]
	private string[] <CertificateSearchPaths>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <SendCloseNotify>k__BackingField; // 0x48
	[CompilerGenerated]
	private string[] <ClientCertificateIssuers>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; // 0x58
	[CompilerGenerated]
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; // 0x5C
	[CompilerGenerated]
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x68
	private bool cloned; // 0x70
	private bool checkCertName; // 0x71
	private bool checkCertRevocationStatus; // 0x72
	private Nullable<bool> useServicePointManagerCallback; // 0x73
	private bool skipSystemValidators; // 0x75
	private bool callbackNeedsChain; // 0x76
	private ICertificateValidator certificateValidator; // 0x78
	private static MonoTlsSettings defaultSettings; // 0x0

	// Properties
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<bool> UseServicePointManagerCallback { get; set; }
	public bool SkipSystemValidators { get; }
	public bool CallbackNeedsCertificateChain { get; }
	public Nullable<DateTime> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public object UserSettings { get; set; }
	internal string[] CertificateSearchPaths { get; set; }
	internal bool SendCloseNotify { get; set; }
	public string[] ClientCertificateIssuers { get; set; }
	public bool DisallowUnauthenticatedCertificateRequest { get; set; }
	public Nullable<TlsProtocols> EnabledProtocols { get; set; }
	[CLSCompliant(False)]
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	[Obsolete("Do not use outside System.dll!")]
	public ICertificateValidator CertificateValidator { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0x15629A0 Offset: 0x1561BA0 VA: 0x1815629A0
	public Nullable<bool> get_UseServicePointManagerCallback() { }

	// RVA: 0x15629C0 Offset: 0x1561BC0 VA: 0x1815629C0
	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	// RVA: 0x8CA280 Offset: 0x8C9480 VA: 0x1808CA280
	public bool get_SkipSystemValidators() { }

	// RVA: 0x8CA2A0 Offset: 0x8C94A0 VA: 0x1808CA2A0
	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGenerated]
	// RVA: 0x416920 Offset: 0x415B20 VA: 0x180416920
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGenerated]
	// RVA: 0x416940 Offset: 0x415B40 VA: 0x180416940
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public object get_UserSettings() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_UserSettings(object value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	internal bool get_SendCloseNotify() { }

	[CompilerGenerated]
	// RVA: 0x445A80 Offset: 0x444C80 VA: 0x180445A80
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string[] get_ClientCertificateIssuers() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_ClientCertificateIssuers(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	[CompilerGenerated]
	// RVA: 0x4D1A70 Offset: 0x4D0C70 VA: 0x1804D1A70
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1562990 Offset: 0x1561B90 VA: 0x181562990
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGenerated]
	// RVA: 0x15629B0 Offset: 0x1561BB0 VA: 0x1815629B0
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGenerated]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGenerated]
	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0x15628F0 Offset: 0x1561AF0 VA: 0x1815628F0
	public void .ctor() { }

	// RVA: 0x1562900 Offset: 0x1561B00 VA: 0x181562900
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0x15626C0 Offset: 0x15618C0 VA: 0x1815626C0
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public ICertificateValidator get_CertificateValidator() { }

	[Obsolete("Do not use outside System.dll!")]
	// RVA: 0x15625D0 Offset: 0x15617D0 VA: 0x1815625D0
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0x1562660 Offset: 0x1561860 VA: 0x181562660
	public MonoTlsSettings Clone() { }

	// RVA: 0x15627A0 Offset: 0x15619A0 VA: 0x1815627A0
	private void .ctor(MonoTlsSettings other) { }
}

// Namespace: Mono.Security.Interface
public sealed class TlsException : Exception // TypeDefIndex: 16358
{
	// Fields
	private Alert alert; // 0x90

	// Methods

	// RVA: 0x15683F0 Offset: 0x15675F0 VA: 0x1815683F0
	public void .ctor(Alert alert) { }

	// RVA: 0x15681C0 Offset: 0x15673C0 VA: 0x1815681C0
	public void .ctor(Alert alert, string message) { }

	// RVA: 0x15682F0 Offset: 0x15674F0 VA: 0x1815682F0
	public void .ctor(AlertDescription description) { }

	// RVA: 0x1568230 Offset: 0x1567430 VA: 0x181568230
	public void .ctor(AlertDescription description, string message) { }
}

// Namespace: Mono.Security.Interface
public enum TlsProtocolCode // TypeDefIndex: 16359
{
	// Fields
	public short value__; // 0x0
	public const TlsProtocolCode Tls10 = 769;
	public const TlsProtocolCode Tls11 = 770;
	public const TlsProtocolCode Tls12 = 771;
}

// Namespace: Mono.Security.Interface
[Flags]
public enum TlsProtocols // TypeDefIndex: 16360
{
	// Fields
	public int value__; // 0x0
	public const TlsProtocols Zero = 0;
	public const TlsProtocols Tls10Client = 128;
	public const TlsProtocols Tls10Server = 64;
	public const TlsProtocols Tls10 = 192;
	public const TlsProtocols Tls11Client = 512;
	public const TlsProtocols Tls11Server = 256;
	public const TlsProtocols Tls11 = 768;
	public const TlsProtocols Tls12Client = 2048;
	public const TlsProtocols Tls12Server = 1024;
	public const TlsProtocols Tls12 = 3072;
	public const TlsProtocols ClientMask = 2688;
	public const TlsProtocols ServerMask = 1344;
}

// Namespace: Mono.Security.Cryptography
public class ARC4Managed : RC4, ICryptoTransform, IDisposable // TypeDefIndex: 16361
{
	// Fields
	private byte[] key; // 0x48
	private byte[] state; // 0x50
	private byte x; // 0x58
	private byte y; // 0x59
	private bool m_disposed; // 0x5A

	// Properties
	public override byte[] Key { get; set; }
	public bool CanTransformMultipleBlocks { get; }
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }

	// Methods

	// RVA: 0x15535E0 Offset: 0x15527E0 VA: 0x1815535E0
	public void .ctor() { }

	// RVA: 0x1552F60 Offset: 0x1552160 VA: 0x181552F60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1552EB0 Offset: 0x15520B0 VA: 0x181552EB0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15536D0 Offset: 0x15528D0 VA: 0x1815536D0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1553770 Offset: 0x1552970 VA: 0x181553770 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1552E80 Offset: 0x1552080 VA: 0x181552E80 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x1552E40 Offset: 0x1552040 VA: 0x181552E40 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x1552FD0 Offset: 0x15521D0 VA: 0x181552FD0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1553030 Offset: 0x1552230 VA: 0x181553030 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x1553290 Offset: 0x1552490 VA: 0x181553290
	private void KeySetup(byte[] key) { }

	// RVA: 0x1552CA0 Offset: 0x1551EA0 VA: 0x181552CA0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1553390 Offset: 0x1552590 VA: 0x181553390 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1553100 Offset: 0x1552300 VA: 0x181553100
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1553520 Offset: 0x1552720 VA: 0x181553520 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

// Namespace: Mono.Security.Cryptography
public sealed class CryptoConvert // TypeDefIndex: 16362
{
	// Methods

	// RVA: 0x155C8E0 Offset: 0x155BAE0 VA: 0x18155C8E0
	private static int ToInt32LE(byte[] bytes, int offset) { }

	// RVA: 0x155C8E0 Offset: 0x155BAE0 VA: 0x18155C8E0
	private static uint ToUInt32LE(byte[] bytes, int offset) { }

	// RVA: 0x155C960 Offset: 0x155BB60 VA: 0x18155C960
	private static byte[] Trim(byte[] array) { }

	// RVA: 0x155BC40 Offset: 0x155AE40 VA: 0x18155BC40
	public static RSA FromCapiPrivateKeyBlob(byte[] blob) { }

	// RVA: 0x155BC50 Offset: 0x155AE50 VA: 0x18155BC50
	public static RSA FromCapiPrivateKeyBlob(byte[] blob, int offset) { }

	// RVA: 0x155C130 Offset: 0x155B330 VA: 0x18155C130
	private static RSAParameters GetParametersFromCapiPrivateKeyBlob(byte[] blob, int offset) { }

	// RVA: 0x155C7B0 Offset: 0x155B9B0 VA: 0x18155C7B0
	public static string ToHex(byte[] input) { }

	// RVA: 0x155BE30 Offset: 0x155B030 VA: 0x18155BE30
	private static byte FromHexChar(char c) { }

	// RVA: 0x155BEC0 Offset: 0x155B0C0 VA: 0x18155BEC0
	public static byte[] FromHex(string hex) { }
}

// Namespace: Mono.Security.Cryptography
public sealed class KeyBuilder // TypeDefIndex: 16363
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x155F460 Offset: 0x155E660 VA: 0x18155F460
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x155F3A0 Offset: 0x155E5A0 VA: 0x18155F3A0
	public static byte[] Key(int size) { }
}

// Namespace: Mono.Security.Cryptography
public abstract class MD2 : HashAlgorithm // TypeDefIndex: 16364
{
	// Methods

	// RVA: 0x155FD00 Offset: 0x155EF00 VA: 0x18155FD00
	protected void .ctor() { }

	// RVA: 0x155FC20 Offset: 0x155EE20 VA: 0x18155FC20
	public static MD2 Create() { }
}

// Namespace: Mono.Security.Cryptography
public class MD2Managed : MD2 // TypeDefIndex: 16365
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x155FA70 Offset: 0x155EC70 VA: 0x18155FA70
	private byte[] Padding(int nLength) { }

	// RVA: 0x155FB70 Offset: 0x155ED70 VA: 0x18155FB70
	public void .ctor() { }

	// RVA: 0x155F730 Offset: 0x155E930 VA: 0x18155F730 Slot: 18
	public override void Initialize() { }

	// RVA: 0x155F4D0 Offset: 0x155E6D0 VA: 0x18155F4D0 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x155F5D0 Offset: 0x155E7D0 VA: 0x18155F5D0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x155F7A0 Offset: 0x155E9A0 VA: 0x18155F7A0
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x155FAF0 Offset: 0x155ECF0 VA: 0x18155FAF0
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
public abstract class MD4 : HashAlgorithm // TypeDefIndex: 16366
{
	// Methods

	// RVA: 0x155FD00 Offset: 0x155EF00 VA: 0x18155FD00
	protected void .ctor() { }

	// RVA: 0x1561090 Offset: 0x1560290 VA: 0x181561090
	public static MD4 Create() { }
}

// Namespace: Mono.Security.Cryptography
public class MD4Managed : MD4 // TypeDefIndex: 16367
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x1560FC0 Offset: 0x15601C0 VA: 0x181560FC0
	public void .ctor() { }

	// RVA: 0x15603C0 Offset: 0x155F5C0 VA: 0x1815603C0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x155FF80 Offset: 0x155F180 VA: 0x18155FF80 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1560100 Offset: 0x155F300 VA: 0x181560100 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1560F40 Offset: 0x1560140 VA: 0x181560F40
	private byte[] Padding(int nLength) { }

	// RVA: 0x155FEC0 Offset: 0x155F0C0 VA: 0x18155FEC0
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x155FF20 Offset: 0x155F120 VA: 0x18155FF20
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x155FF70 Offset: 0x155F170 VA: 0x18155FF70
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x1560FA0 Offset: 0x15601A0 VA: 0x181560FA0
	private uint ROL(uint x, byte n) { }

	// RVA: 0x155FE80 Offset: 0x155F080 VA: 0x18155FE80
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x155FED0 Offset: 0x155F0D0 VA: 0x18155FED0
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x155FF30 Offset: 0x155F130 VA: 0x18155FF30
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x155FDD0 Offset: 0x155EFD0 VA: 0x18155FDD0
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x155FD20 Offset: 0x155EF20 VA: 0x18155FD20
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x1560490 Offset: 0x155F690 VA: 0x181560490
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS1 // TypeDefIndex: 16368
{
	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x1562A60 Offset: 0x1561C60 VA: 0x181562A60
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x1563620 Offset: 0x1562820 VA: 0x181563620
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x15636A0 Offset: 0x15628A0 VA: 0x1815636A0
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x1563770 Offset: 0x1562970 VA: 0x181563770
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x15637A0 Offset: 0x15629A0 VA: 0x1815637A0
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x1562F70 Offset: 0x1562170 VA: 0x181562F70
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x15632C0 Offset: 0x15624C0 VA: 0x1815632C0
	internal static string HashNameFromOid(string oid, bool throwOnError = True) { }

	// RVA: 0x1562F10 Offset: 0x1562110 VA: 0x181562F10
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0x1562AF0 Offset: 0x1561CF0 VA: 0x181562AF0
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x1563B00 Offset: 0x1562D00 VA: 0x181563B00
	private static void .cctor() { }
}

// Namespace: 
public class PKCS8.PrivateKeyInfo // TypeDefIndex: 16369
{
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public string Algorithm { get; set; }
	public byte[] PrivateKey { get; set; }

	// Methods

	// RVA: 0x1564F60 Offset: 0x1564160 VA: 0x181564F60
	public void .ctor() { }

	// RVA: 0x1564FD0 Offset: 0x15641D0 VA: 0x181564FD0
	public void .ctor(byte[] data) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Algorithm() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Algorithm(string value) { }

	// RVA: 0x1565050 Offset: 0x1564250 VA: 0x181565050
	public byte[] get_PrivateKey() { }

	// RVA: 0x15650D0 Offset: 0x15642D0 VA: 0x1815650D0
	public void set_PrivateKey(byte[] value) { }

	// RVA: 0x1564270 Offset: 0x1563470 VA: 0x181564270
	private void Decode(byte[] data) { }

	// RVA: 0x1564A00 Offset: 0x1563C00 VA: 0x181564A00
	public byte[] GetBytes() { }

	// RVA: 0x1564EB0 Offset: 0x15640B0 VA: 0x181564EB0
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x1564E00 Offset: 0x1564000 VA: 0x181564E00
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x1563E00 Offset: 0x1563000 VA: 0x181563E00
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x15645B0 Offset: 0x15637B0 VA: 0x1815645B0
	public static byte[] Encode(RSA rsa) { }

	// RVA: 0x1563C50 Offset: 0x1562E50 VA: 0x181563C50
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0x1564550 Offset: 0x1563750 VA: 0x181564550
	public static byte[] Encode(DSA dsa) { }

	// RVA: 0x15647E0 Offset: 0x15639E0 VA: 0x1815647E0
	public static byte[] Encode(AsymmetricAlgorithm aa) { }
}

// Namespace: 
public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 16370
{
	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; set; }
	public byte[] EncryptedData { get; set; }
	public byte[] Salt { get; }
	public int IterationCount { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x155CFA0 Offset: 0x155C1A0 VA: 0x18155CFA0
	public void .ctor(byte[] data) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Algorithm() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Algorithm(string value) { }

	// RVA: 0x155CFD0 Offset: 0x155C1D0 VA: 0x18155CFD0
	public byte[] get_EncryptedData() { }

	// RVA: 0x155D110 Offset: 0x155C310 VA: 0x18155D110
	public void set_EncryptedData(byte[] value) { }

	// RVA: 0x155D050 Offset: 0x155C250 VA: 0x18155D050
	public byte[] get_Salt() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_IterationCount() { }

	// RVA: 0x155D1A0 Offset: 0x155C3A0 VA: 0x18155D1A0
	public void set_IterationCount(int value) { }

	// RVA: 0x155CA20 Offset: 0x155BC20 VA: 0x18155CA20
	private void Decode(byte[] data) { }

	// RVA: 0x155CDA0 Offset: 0x155BFA0 VA: 0x18155CDA0
	public byte[] GetBytes() { }
}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS8 // TypeDefIndex: 16371
{}

// Namespace: Mono.Security.Cryptography
public abstract class RC4 : SymmetricAlgorithm // TypeDefIndex: 16372
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] IV { get; set; }

	// Methods

	// RVA: 0x1565DB0 Offset: 0x1564FB0 VA: 0x181565DB0
	public void .ctor() { }

	// RVA: 0x1565E40 Offset: 0x1565040 VA: 0x181565E40 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	public override void set_IV(byte[] value) { }

