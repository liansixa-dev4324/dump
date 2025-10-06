	// RVA: 0x1565B70 Offset: 0x1564D70 VA: 0x181565B70
	public static RC4 Create() { }

	// RVA: 0x1565C80 Offset: 0x1564E80 VA: 0x181565C80
	private static void .cctor() { }
}

// Namespace: 
public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 16373
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, EventArgs e) { }
}

// Namespace: Mono.Security.Cryptography
public class RSAManaged : RSA // TypeDefIndex: 16374
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGenerated]
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1567AF0 Offset: 0x1566CF0 VA: 0x181567AF0
	public void .ctor() { }

	// RVA: 0x1567BC0 Offset: 0x1566DC0 VA: 0x181567BC0
	public void .ctor(int keySize) { }

	// RVA: 0x15667F0 Offset: 0x15659F0 VA: 0x1815667F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1566860 Offset: 0x1565A60 VA: 0x181566860
	private void GenerateKeyPair() { }

	// RVA: 0x1567CA0 Offset: 0x1566EA0 VA: 0x181567CA0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1567D50 Offset: 0x1566F50 VA: 0x181567D50
	public bool get_PublicOnly() { }

	// RVA: 0x1566240 Offset: 0x1565440 VA: 0x181566240 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x1566440 Offset: 0x1565640 VA: 0x181566440 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1566DF0 Offset: 0x1565FF0 VA: 0x181566DF0 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1565E80 Offset: 0x1565080 VA: 0x181565E80 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1567510 Offset: 0x1566710 VA: 0x181567510 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x1566D40 Offset: 0x1565F40 VA: 0x181566D40
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}

// Namespace: Mono.Security.Authenticode
public class AuthenticodeBase // TypeDefIndex: 16375
{
	// Fields
	private byte[] fileblock; // 0x10
	private Stream fs; // 0x18
	private int blockNo; // 0x20
	private int blockLength; // 0x24
	private int peOffset; // 0x28
	private int dirSecurityOffset; // 0x2C
	private int dirSecuritySize; // 0x30
	private int coffSymbolTableOffset; // 0x34
	private bool pe64; // 0x38

	// Properties
	internal int PEOffset { get; }

	// Methods

	// RVA: 0x15545D0 Offset: 0x15537D0 VA: 0x1815545D0
	public void .ctor() { }

	// RVA: 0x1554620 Offset: 0x1553820 VA: 0x181554620
	internal int get_PEOffset() { }

	// RVA: 0x1554110 Offset: 0x1553310 VA: 0x181554110
	internal void Open(string filename) { }

	// RVA: 0x15541C0 Offset: 0x15533C0 VA: 0x1815541C0
	internal void Open(byte[] rawdata) { }

	// RVA: 0x1553B10 Offset: 0x1552D10 VA: 0x181553B10
	internal void Close() { }

	// RVA: 0x15544F0 Offset: 0x15536F0 VA: 0x1815544F0
	internal void ReadFirstBlock() { }

	// RVA: 0x1554260 Offset: 0x1553460 VA: 0x181554260
	internal int ProcessFirstBlock() { }

	// RVA: 0x1554040 Offset: 0x1553240 VA: 0x181554040
	internal byte[] GetSecurityEntry() { }

	// RVA: 0x1553B50 Offset: 0x1552D50 VA: 0x181553B50
	internal byte[] GetHash(HashAlgorithm hash) { }
}

// Namespace: Mono.Security.Authenticode
public class AuthenticodeDeformatter : AuthenticodeBase // TypeDefIndex: 16376
{
	// Fields
	private string filename; // 0x40
	private byte[] rawdata; // 0x48
	private byte[] hash; // 0x50
	private X509CertificateCollection coll; // 0x58
	private ASN1 signedHash; // 0x60
	private DateTime timestamp; // 0x68
	private X509Certificate signingCertificate; // 0x70
	private int reason; // 0x78
	private bool trustedRoot; // 0x7C
	private bool trustedTimestampRoot; // 0x7D
	private byte[] entry; // 0x80
	private X509Chain signerChain; // 0x88
	private X509Chain timestampChain; // 0x90

	// Properties
	public byte[] RawData { set; }
	public X509Certificate SigningCertificate { get; }

	// Methods

	// RVA: 0x15573F0 Offset: 0x15565F0 VA: 0x1815573F0
	public void .ctor() { }

	// RVA: 0x15574B0 Offset: 0x15566B0 VA: 0x1815574B0
	public void .ctor(byte[] rawData) { }

	// RVA: 0x1557580 Offset: 0x1556780 VA: 0x181557580
	public void set_RawData(byte[] value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public X509Certificate get_SigningCertificate() { }

	// RVA: 0x1554650 Offset: 0x1553850 VA: 0x181554650
	private bool CheckSignature() { }

	// RVA: 0x1555FB0 Offset: 0x15551B0 VA: 0x181555FB0
	private bool CompareIssuerSerial(string issuer, byte[] serial, X509Certificate x509) { }

	// RVA: 0x1556A30 Offset: 0x1555C30 VA: 0x181556A30
	private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha) { }

	// RVA: 0x1556180 Offset: 0x1555380 VA: 0x181556180
	private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature) { }

	// RVA: 0x15560D0 Offset: 0x15552D0 VA: 0x1815560D0
	private void Reset() { }
}

// Namespace: Mono.Security.Authenticode
public class PrivateKey // TypeDefIndex: 16377
{
	// Fields
	private bool encrypted; // 0x10
	private RSA rsa; // 0x18
	private bool weak; // 0x20
	private int keyType; // 0x24

	// Properties
	public RSA RSA { get; }

	// Methods

	// RVA: 0x1565A80 Offset: 0x1564C80 VA: 0x181565A80
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public RSA get_RSA() { }

	// RVA: 0x1565930 Offset: 0x1564B30 VA: 0x181565930
	private byte[] DeriveKey(byte[] salt, string password) { }

	// RVA: 0x1565490 Offset: 0x1564690 VA: 0x181565490
	private bool Decode(byte[] pvk, string password) { }

	// RVA: 0x15651C0 Offset: 0x15643C0 VA: 0x1815651C0
	public static PrivateKey CreateFromFile(string filename) { }

	// RVA: 0x15651D0 Offset: 0x15643D0 VA: 0x1815651D0
	public static PrivateKey CreateFromFile(string filename, string password) { }
}

// Namespace: 
public enum BigInteger.Sign // TypeDefIndex: 16378
{
	// Fields
	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;
}

// Namespace: 
public sealed class BigInteger.ModulusRing // TypeDefIndex: 16379
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x1562220 Offset: 0x1561420 VA: 0x181562220
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1561690 Offset: 0x1560890 VA: 0x181561690
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1561D10 Offset: 0x1560F10 VA: 0x181561D10
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1561B00 Offset: 0x1560D00 VA: 0x181561B00
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1562050 Offset: 0x1561250 VA: 0x181562050
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliant(False)]
	// RVA: 0x1561FD0 Offset: 0x15611D0 VA: 0x181561FD0
	public BigInteger Pow(uint b, BigInteger exp) { }
}

// Namespace: 
private sealed class BigInteger.Kernel // TypeDefIndex: 16380
{
	// Methods

	// RVA: 0x155E060 Offset: 0x155D260 VA: 0x18155E060
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x155D860 Offset: 0x155CA60 VA: 0x18155D860
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x155DBE0 Offset: 0x155CDE0 VA: 0x18155DBE0
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x155D220 Offset: 0x155C420 VA: 0x18155D220
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x155DFC0 Offset: 0x155D1C0 VA: 0x18155DFC0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x1559180 Offset: 0x1558380 VA: 0x181559180
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x155D370 Offset: 0x155C570 VA: 0x18155D370
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x155EC30 Offset: 0x155DE30 VA: 0x18155EC30
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x155D5A0 Offset: 0x155C7A0 VA: 0x18155D5A0
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x155DDA0 Offset: 0x155CFA0 VA: 0x18155DDA0
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x155DAC0 Offset: 0x155CCC0 VA: 0x18155DAC0
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x155D980 Offset: 0x155CB80 VA: 0x18155D980
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x155E250 Offset: 0x155D450 VA: 0x18155E250
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x155E370 Offset: 0x155D570 VA: 0x18155E370
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }
}

// Namespace: Mono.Math
public class BigInteger // TypeDefIndex: 16381
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x1558820 Offset: 0x1557A20 VA: 0x181558820
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1558740 Offset: 0x1557940 VA: 0x181558740
	public void .ctor(BigInteger bi) { }

	[CLSCompliant(False)]
	// RVA: 0x1558B80 Offset: 0x1557D80 VA: 0x181558B80
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1558880 Offset: 0x1557A80 VA: 0x181558880
	public void .ctor(byte[] inData) { }

	[CLSCompliant(False)]
	// RVA: 0x1558B00 Offset: 0x1557D00 VA: 0x181558B00
	public void .ctor(uint ui) { }

	[CLSCompliant(False)]
	// RVA: 0x1558EC0 Offset: 0x15580C0 VA: 0x181558EC0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1558F20 Offset: 0x1558120 VA: 0x181558F20
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x15594F0 Offset: 0x15586F0 VA: 0x1815594F0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	// RVA: 0x1559180 Offset: 0x1558380 VA: 0x181559180
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1559150 Offset: 0x1558350 VA: 0x181559150
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1558D10 Offset: 0x1557F10 VA: 0x181558D10
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x15591E0 Offset: 0x15583E0 VA: 0x1815591E0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1559100 Offset: 0x1558300 VA: 0x181559100
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x15594E0 Offset: 0x15586E0 VA: 0x1815594E0
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1558C40 Offset: 0x1557E40 VA: 0x181558C40
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1557980 Offset: 0x1556B80 VA: 0x181557980
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1557B60 Offset: 0x1556D60 VA: 0x181557B60
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1557680 Offset: 0x1556880 VA: 0x181557680
	public int BitCount() { }

	// RVA: 0x15581C0 Offset: 0x15573C0 VA: 0x1815581C0
	public bool TestBit(int bitNum) { }

	[CLSCompliant(False)]
	// RVA: 0x1558110 Offset: 0x1557310 VA: 0x181558110
	public void SetBit(uint bitNum) { }

	[CLSCompliant(False)]
	// RVA: 0x1558160 Offset: 0x1557360 VA: 0x181558160
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1557F30 Offset: 0x1557130 VA: 0x181557F30
	public int LowestSetBit() { }

	// RVA: 0x1557C50 Offset: 0x1556E50 VA: 0x181557C50
	public byte[] GetBytes() { }

	[CLSCompliant(False)]
	// RVA: 0x1558D40 Offset: 0x1557F40 VA: 0x181558D40
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliant(False)]
	// RVA: 0x1559080 Offset: 0x1558280 VA: 0x181559080
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1558DC0 Offset: 0x1557FC0 VA: 0x181558DC0
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1558FC0 Offset: 0x15581C0 VA: 0x181558FC0
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1558EA0 Offset: 0x15580A0 VA: 0x181558EA0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1559130 Offset: 0x1558330 VA: 0x181559130
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1558E80 Offset: 0x1558080 VA: 0x181558E80
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1559110 Offset: 0x1558310 VA: 0x181559110
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	// RVA: 0x1558620 Offset: 0x1557820 VA: 0x181558620
	public string ToString(uint radix) { }

	[CLSCompliant(False)]
	// RVA: 0x1558260 Offset: 0x1557460 VA: 0x181558260
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x15580C0 Offset: 0x15572C0 VA: 0x1815580C0
	private void Normalize() { }

	// RVA: 0x1557730 Offset: 0x1556930 VA: 0x181557730
	public void Clear() { }

	// RVA: 0x1557E20 Offset: 0x1557020 VA: 0x181557E20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1558670 Offset: 0x1557870 VA: 0x181558670 Slot: 3
	public override string ToString() { }

	// RVA: 0x1557790 Offset: 0x1556990 VA: 0x181557790 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1558020 Offset: 0x1557220 VA: 0x181558020
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1558030 Offset: 0x1557230 VA: 0x181558030
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x1557910 Offset: 0x1556B10 VA: 0x181557910
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1557E70 Offset: 0x1557070 VA: 0x181557E70
	public void Incr2() { }

	// RVA: 0x15586C0 Offset: 0x15578C0 VA: 0x1815586C0
	private static void .cctor() { }
}

// Namespace: Mono.Math.Prime
public enum ConfidenceFactor // TypeDefIndex: 16382
{
	// Fields
	public int value__; // 0x0
	public const ConfidenceFactor ExtraLow = 0;
	public const ConfidenceFactor Low = 1;
	public const ConfidenceFactor Medium = 2;
	public const ConfidenceFactor High = 3;
	public const ConfidenceFactor ExtraHigh = 4;
	public const ConfidenceFactor Provable = 5;
}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTest : MulticastDelegate // TypeDefIndex: 16383
{
	// Methods

	// RVA: 0x12068A0 Offset: 0x1205AA0 VA: 0x1812068A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTests // TypeDefIndex: 16384
{
	// Methods

	// RVA: 0x1569F20 Offset: 0x1569120 VA: 0x181569F20
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0x156A0E0 Offset: 0x15692E0 VA: 0x18156A0E0
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime.Generator
public abstract class PrimeGeneratorBase // TypeDefIndex: 16385
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x156A580 Offset: 0x1569780 VA: 0x18156A580 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x156A6B0 Offset: 0x15698B0 VA: 0x18156A6B0 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: Mono.Math.Prime.Generator
public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 16386
{
	// Methods

	// RVA: 0x156A990 Offset: 0x1569B90 VA: 0x18156A990 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x156A970 Offset: 0x1569B70 VA: 0x18156A970 Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x156A6C0 Offset: 0x15698C0 VA: 0x18156A6C0 Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 // TypeDefIndex: 16387
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 // TypeDefIndex: 16388
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 // TypeDefIndex: 16389
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 // TypeDefIndex: 16390
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 16391
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 16392
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 // TypeDefIndex: 16393
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 16394
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 16395
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 // TypeDefIndex: 16396
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16397
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2 /*Metadata offset 0x8F77D8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5 /*Metadata offset 0x8F7820*/; // 0x40
	internal static readonly long 290C4A052C215D096172EB81AEE671FB3286E5C1DB5E73F96021FC09825DDB88 = 2676302836908902219; // 0xC80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 32D0830B8EE1D49A66F395C8EA80E02BFC07C2A12A8EA8C8B484AF02108A1950 /*Metadata offset 0x8F8470*/; // 0xC88
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 35BF50EEF3270FD8CA09E66FC5B0481C5A151B14F6A634854E32F63633D49DCB /*Metadata offset 0x8F8478*/; // 0xC8B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3C0C410618682C4DF0474E034114CC8E562F05A512B521AC367571017BDFA75D /*Metadata offset 0x8F8480*/; // 0xC8E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 44F5B1A2C48314502ACCBF186D1A2F9F7F176825898F32F1A2047B956194F174 /*Metadata offset 0x8F8488*/; // 0xC91
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6 /*Metadata offset 0x8F8490*/; // 0xC94
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA /*Metadata offset 0x8F84C8*/; // 0xCC4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329 /*Metadata offset 0x8F84E0*/; // 0xCD8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 59BE5A634187B8A57216EFF5371A47732C05744B1C1A0A6382A6D5622C9FFDCE /*Metadata offset 0x8F85E8*/; // 0xDD8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456 /*Metadata offset 0x8F85F0*/; // 0xDDB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 5F8C6B3C66B972606D85E7651F67ADBD02E8316876884674E8328FA710747E5B /*Metadata offset 0x8F8618*/; // 0xDFB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 60C6ED13AF98DBFEEDA8F8197FFFCC349BB04395CC81DF0D477CBC57BF5B398B /*Metadata offset 0x8F8620*/; // 0xDFE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 64B3E7D737AFF47D4C3BBD81D2D06D697DDD8EB60F29E13E4425D19D8BBCA1F7 /*Metadata offset 0x8F8630*/; // 0xE08
	internal static readonly long 6772A9B8BF207A3CFE6EE68769D6985B69522183F24A2A3D41BC3B4602953426 = 22609615381091406; // 0xE18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6 /*Metadata offset 0x8F8650*/; // 0xE20
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6AA56C4BCD208911792AD24C7681FEFB93BED51903AFC54860C9BD37E41E5A31 /*Metadata offset 0x8F8660*/; // 0xE29
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 796E63069E193A008CB4E85573AA1FE53C5F4E58B42A7F61FD0EEE1D89B5120B /*Metadata offset 0x8F86A8*/; // 0xE69
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 7C8975E1E60A5C8337F28EDF8C33C3B180360B7279644A9BC1AF3C51E6220BF5 /*Metadata offset 0x8F86B0*/; // 0xE6C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 850D7367E4FB0766E2CBC3ACF5AB42B4E98348E58E5A789845D4FCCDB63D2AEE /*Metadata offset 0x8F86F8*/; // 0xEAC
	internal static readonly long 992F16C986809AB68C7466CC3EC6F12B2506A962EA539753E5D84A2FB7FF8A24 = -1295888024253181014; // 0xEB0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9A65C09A11757751BFED67A414E00B188DC4C7757FCB6CBD33A916DDE4A3D925 /*Metadata offset 0x8F8710*/; // 0xEB8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 9ACEFCC0C950280B64AB9E045E38C34ABF71EC70A0DC61B9C621C6BFB4F78047 /*Metadata offset 0x8F8718*/; // 0xEBB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 B1E34F4A11EE411B83415EF0B252A0B2BBCFCAC2E592865E09C12E4252C93A75 /*Metadata offset 0x8F8730*/; // 0xECD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 C92FAD7F348A682E7D5B7E74C76B5D019174EE7BC87545B25A1FDD49FBCC2D0B /*Metadata offset 0x8F8738*/; // 0xED0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 E17B8359E685992B0DE6242AAA24FCB7404173CBB7FF8646FF7D658139F41B5F /*Metadata offset 0x8F8740*/; // 0xED3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 F83B332BE4E6A5A4B1C56AAF6DB52657DA495E149870057D8590AB9D7A6167AD /*Metadata offset 0x8F8748*/; // 0xED6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 FB6D7301FFDCB5FBA5807A19B4F0606947897C1105240B6BBA815352DBBE2064 /*Metadata offset 0x8F8790*/; // 0xF16

	// Methods

	// RVA: 0x840E00 Offset: 0x840000 VA: 0x180840E00
	internal static uint ComputeStringHash(string s) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16398
{}

// Namespace: 
internal class DelegateList<T> // TypeDefIndex: 16399
{
	// Fields
	private Func<Action<T>, LinkedListNode<Action<T>>> m_acquireFunc; // 0x0
	private Action<LinkedListNode<Action<T>>> m_releaseFunc; // 0x0
	private LinkedList<Action<T>> m_callbacks; // 0x0
	private bool m_invoking; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<Action<T>, LinkedListNode<Action<T>>> acquireFunc, Action<LinkedListNode<Action<T>>> releaseFunc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC5980 Offset: 0xFC4B80 VA: 0x180FC5980
	|-DelegateList<AsyncOperationHandle<bool>>..ctor
	|-DelegateList<AsyncOperationHandle<long>>..ctor
	|-DelegateList<AsyncOperationHandle<object>>..ctor
	|-DelegateList<AsyncOperationHandle<SceneInstance>>..ctor
	|-DelegateList<AsyncOperationHandle>..ctor
	|-DelegateList<DiagnosticEvent>..ctor
	|-DelegateList<float>..ctor
	|-DelegateList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC5A50 Offset: 0xFC4C50 VA: 0x180FC5A50
	|-DelegateList<AsyncOperationHandle<bool>>.get_Count
	|-DelegateList<AsyncOperationHandle<long>>.get_Count
	|-DelegateList<AsyncOperationHandle<object>>.get_Count
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.get_Count
	|-DelegateList<AsyncOperationHandle>.get_Count
	|-DelegateList<DiagnosticEvent>.get_Count
	|-DelegateList<float>.get_Count
	|
	|-RVA: 0xFC5A70 Offset: 0xFC4C70 VA: 0x180FC5A70
	|-DelegateList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC4470 Offset: 0xFC3670 VA: 0x180FC4470
	|-DelegateList<AsyncOperationHandle<bool>>.Add
	|-DelegateList<AsyncOperationHandle<long>>.Add
	|-DelegateList<AsyncOperationHandle<object>>.Add
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Add
	|-DelegateList<AsyncOperationHandle>.Add
	|-DelegateList<DiagnosticEvent>.Add
	|-DelegateList<float>.Add
	|
	|-RVA: 0xFC4530 Offset: 0xFC3730 VA: 0x180FC4530
	|-DelegateList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC58A0 Offset: 0xFC4AA0 VA: 0x180FC58A0
	|-DelegateList<AsyncOperationHandle<bool>>.Remove
	|-DelegateList<AsyncOperationHandle<long>>.Remove
	|-DelegateList<AsyncOperationHandle<object>>.Remove
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Remove
	|-DelegateList<AsyncOperationHandle>.Remove
	|-DelegateList<DiagnosticEvent>.Remove
	|-DelegateList<float>.Remove
	|
	|-RVA: 0xFC5740 Offset: 0xFC4940 VA: 0x180FC5740
	|-DelegateList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T res) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC4D30 Offset: 0xFC3F30 VA: 0x180FC4D30
	|-DelegateList<AsyncOperationHandle<bool>>.Invoke
	|-DelegateList<AsyncOperationHandle<long>>.Invoke
	|-DelegateList<AsyncOperationHandle<object>>.Invoke
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Invoke
	|
	|-RVA: 0xFC50A0 Offset: 0xFC42A0 VA: 0x180FC50A0
	|-DelegateList<AsyncOperationHandle>.Invoke
	|
	|-RVA: 0xFC4EE0 Offset: 0xFC40E0 VA: 0x180FC4EE0
	|-DelegateList<DiagnosticEvent>.Invoke
	|
	|-RVA: 0xFC55A0 Offset: 0xFC47A0 VA: 0x180FC55A0
	|-DelegateList<float>.Invoke
	|
	|-RVA: 0xFC5250 Offset: 0xFC4450 VA: 0x180FC5250
	|-DelegateList<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC4700 Offset: 0xFC3900 VA: 0x180FC4700
	|-DelegateList<AsyncOperationHandle<bool>>.Clear
	|-DelegateList<AsyncOperationHandle<long>>.Clear
	|-DelegateList<AsyncOperationHandle<object>>.Clear
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Clear
	|-DelegateList<AsyncOperationHandle>.Clear
	|-DelegateList<DiagnosticEvent>.Clear
	|-DelegateList<float>.Clear
	|
	|-RVA: 0xFC4610 Offset: 0xFC3810 VA: 0x180FC4610
	|-DelegateList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public static DelegateList<T> CreateWithGlobalCache() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC47B0 Offset: 0xFC39B0 VA: 0x180FC47B0
	|-DelegateList<AsyncOperationHandle<bool>>.CreateWithGlobalCache
	|-DelegateList<AsyncOperationHandle<long>>.CreateWithGlobalCache
	|-DelegateList<AsyncOperationHandle<object>>.CreateWithGlobalCache
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.CreateWithGlobalCache
	|-DelegateList<AsyncOperationHandle>.CreateWithGlobalCache
	|-DelegateList<DiagnosticEvent>.CreateWithGlobalCache
	|-DelegateList<float>.CreateWithGlobalCache
	|
	|-RVA: 0xFC4A60 Offset: 0xFC3C60 VA: 0x180FC4A60
	|-DelegateList<__Il2CppFullySharedGenericType>.CreateWithGlobalCache
	*/
}

// Namespace: 
[DefaultMember("Item")]
internal class ListWithEvents<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 16400
{
	// Fields
	private List<T> m_List; // 0x0
	[CompilerGenerated]
	private Action<T> OnElementAdded; // 0x0
	[CompilerGenerated]
	private Action<T> OnElementRemoved; // 0x0

	// Properties
	public T Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_OnElementAdded(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132E390 Offset: 0x132D590 VA: 0x18132E390
	|-ListWithEvents<object>.add_OnElementAdded
	|-ListWithEvents<__Il2CppFullySharedGenericType>.add_OnElementAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_OnElementAdded(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132E6B0 Offset: 0x132D8B0 VA: 0x18132E6B0
	|-ListWithEvents<object>.remove_OnElementAdded
	|-ListWithEvents<__Il2CppFullySharedGenericType>.remove_OnElementAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_OnElementRemoved(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132E460 Offset: 0x132D660 VA: 0x18132E460
	|-ListWithEvents<object>.add_OnElementRemoved
	|-ListWithEvents<__Il2CppFullySharedGenericType>.add_OnElementRemoved
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_OnElementRemoved(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132E780 Offset: 0x132D980 VA: 0x18132E780
	|-ListWithEvents<object>.remove_OnElementRemoved
	|-ListWithEvents<__Il2CppFullySharedGenericType>.remove_OnElementRemoved
	*/

	// RVA: -1 Offset: -1
	private void InvokeAdded(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132DC90 Offset: 0x132CE90 VA: 0x18132DC90
	|-ListWithEvents<object>.InvokeAdded
	|
	|-RVA: 0x132DBB0 Offset: 0x132CDB0 VA: 0x18132DBB0
	|-ListWithEvents<__Il2CppFullySharedGenericType>.InvokeAdded
	*/

	// RVA: -1 Offset: -1
	private void InvokeRemoved(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132DCB0 Offset: 0x132CEB0 VA: 0x18132DCB0
	|-ListWithEvents<object>.InvokeRemoved
	|
	|-RVA: 0x132DCD0 Offset: 0x132CED0 VA: 0x18132DCD0
	|-ListWithEvents<__Il2CppFullySharedGenericType>.InvokeRemoved
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132E680 Offset: 0x132D880 VA: 0x18132E680
	|-ListWithEvents<object>.get_Item
	|
	|-RVA: 0x132E5B0 Offset: 0x132D7B0 VA: 0x18132E5B0
	|-ListWithEvents<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132EB20 Offset: 0x132DD20 VA: 0x18132EB20
	|-ListWithEvents<object>.set_Item
	|
	|-RVA: 0x132E850 Offset: 0x132DA50 VA: 0x18132E850
	|-ListWithEvents<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	|-ListWithEvents<object>.get_Count
	|
	|-RVA: 0x132E530 Offset: 0x132D730 VA: 0x18132E530
	|-ListWithEvents<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132E560 Offset: 0x132D760 VA: 0x18132E560
	|-ListWithEvents<object>.get_IsReadOnly
	|-ListWithEvents<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132CF90 Offset: 0x132C190 VA: 0x18132CF90
	|-ListWithEvents<object>.Add
	|
	|-RVA: 0x132D030 Offset: 0x132C230 VA: 0x18132D030
	|-ListWithEvents<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132D4F0 Offset: 0x132C6F0 VA: 0x18132D4F0
	|-ListWithEvents<object>.Clear
	|
	|-RVA: 0x132D1B0 Offset: 0x132C3B0 VA: 0x18132D1B0
	|-ListWithEvents<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132D740 Offset: 0x132C940 VA: 0x18132D740
	|-ListWithEvents<object>.Contains
	|
	|-RVA: 0x132D650 Offset: 0x132C850 VA: 0x18132D650
	|-ListWithEvents<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132D770 Offset: 0x132C970 VA: 0x18132D770
	|-ListWithEvents<object>.CopyTo
	|
	|-RVA: 0x132D7A0 Offset: 0x132C9A0 VA: 0x18132D7A0
	|-ListWithEvents<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12600B0 Offset: 0x125F2B0 VA: 0x1812600B0
	|-ListWithEvents<object>.GetEnumerator
	|
	|-RVA: 0x132D7D0 Offset: 0x132C9D0 VA: 0x18132D7D0
	|-ListWithEvents<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132D970 Offset: 0x132CB70 VA: 0x18132D970
	|-ListWithEvents<object>.IndexOf
	|
	|-RVA: 0x132D880 Offset: 0x132CA80 VA: 0x18132D880
	|-ListWithEvents<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132D9A0 Offset: 0x132CBA0 VA: 0x18132D9A0
	|-ListWithEvents<object>.Insert
	|
	|-RVA: 0x132DA00 Offset: 0x132CC00 VA: 0x18132DA00
	|-ListWithEvents<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132E160 Offset: 0x132D360 VA: 0x18132E160
	|-ListWithEvents<object>.Remove
	|
	|-RVA: 0x132DFF0 Offset: 0x132D1F0 VA: 0x18132DFF0
	|-ListWithEvents<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132DF50 Offset: 0x132D150 VA: 0x18132DF50
	|-ListWithEvents<object>.RemoveAt
	|
	|-RVA: 0x132DDB0 Offset: 0x132CFB0 VA: 0x18132DDB0
	|-ListWithEvents<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132E1F0 Offset: 0x132D3F0 VA: 0x18132E1F0
	|-ListWithEvents<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x132E240 Offset: 0x132D440 VA: 0x18132E240
	|-ListWithEvents<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132E310 Offset: 0x132D510 VA: 0x18132E310
	|-ListWithEvents<object>..ctor
	|
	|-RVA: 0x132E290 Offset: 0x132D490 VA: 0x18132E290
	|-ListWithEvents<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
internal class MonoBehaviourCallbackHooks : ComponentSingleton<MonoBehaviourCallbackHooks> // TypeDefIndex: 16401
{
	// Fields
	internal Action<float> m_OnUpdateDelegate; // 0x20

	// Methods

	// RVA: 0x2389C50 Offset: 0x2388E50 VA: 0x182389C50
	public void add_OnUpdateDelegate(Action<float> value) { }

	// RVA: 0x2389D00 Offset: 0x2388F00 VA: 0x182389D00
	public void remove_OnUpdateDelegate(Action<float> value) { }

	// RVA: 0x2389BA0 Offset: 0x2388DA0 VA: 0x182389BA0 Slot: 4
	protected override string GetGameObjectName() { }

	// RVA: 0x2389BD0 Offset: 0x2388DD0 VA: 0x182389BD0
	internal void Update() { }

	// RVA: 0x2389C10 Offset: 0x2388E10 VA: 0x182389C10
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 16402
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 16403
{
	// Methods

	// RVA: 0x23922D0 Offset: 0x23914D0 VA: 0x1823922D0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement
internal class ChainOperation<TObject, TObjectDependency> : AsyncOperationBase<TObject> // TypeDefIndex: 16404
{
	// Fields
	private AsyncOperationHandle<TObjectDependency> m_DepOp; // 0x0
	private AsyncOperationHandle<TObject> m_WrappedOp; // 0x0
	private DownloadStatus m_depStatus; // 0x0
	private DownloadStatus m_wrapStatus; // 0x0
	private Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> m_Callback; // 0x0
	private Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF031E0 Offset: 0xF023E0 VA: 0x180F031E0
	|-ChainOperation<long, object>..ctor
	|
	|-RVA: 0xF03270 Offset: 0xF02470 VA: 0x180F03270
	|-ChainOperation<object, object>..ctor
	|
	|-RVA: 0xF03300 Offset: 0xF02500 VA: 0x180F03300
	|-ChainOperation<SceneInstance, SceneInstance>..ctor
	|
	|-RVA: 0xEFFCF0 Offset: 0xEFEEF0 VA: 0x180EFFCF0
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF03570 Offset: 0xF02770 VA: 0x180F03570
	|-ChainOperation<long, object>.get_DebugName
	|
	|-RVA: 0xF038D0 Offset: 0xF02AD0 VA: 0x180F038D0
	|-ChainOperation<object, object>.get_DebugName
	|
	|-RVA: 0xF03720 Offset: 0xF02920 VA: 0x180F03720
	|-ChainOperation<SceneInstance, SceneInstance>.get_DebugName
	|
	|-RVA: 0xF03390 Offset: 0xF02590 VA: 0x180F03390
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF01230 Offset: 0xF00430 VA: 0x180F01230
	|-ChainOperation<long, object>.GetDependencies
	|
	|-RVA: 0xF014E0 Offset: 0xF006E0 VA: 0x180F014E0
	|-ChainOperation<object, object>.GetDependencies
	|
	|-RVA: 0xF01620 Offset: 0xF00820 VA: 0x180F01620
	|-ChainOperation<SceneInstance, SceneInstance>.GetDependencies
	|
	|-RVA: 0xF01370 Offset: 0xF00570 VA: 0x180F01370
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF01B20 Offset: 0xF00D20 VA: 0x180F01B20
	|-ChainOperation<long, object>.Init
	|
	|-RVA: 0xF01A80 Offset: 0xF00C80 VA: 0x180F01A80
	|-ChainOperation<object, object>.Init
	|
	|-RVA: 0xF01D10 Offset: 0xF00F10 VA: 0x180F01D10
	|-ChainOperation<SceneInstance, SceneInstance>.Init
	|
	|-RVA: 0xF01BC0 Offset: 0xF00DC0 VA: 0x180F01BC0
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF01F10 Offset: 0xF01110 VA: 0x180F01F10
	|-ChainOperation<long, object>.InvokeWaitForCompletion
	|
	|-RVA: 0xF02350 Offset: 0xF01550 VA: 0x180F02350
	|-ChainOperation<object, object>.InvokeWaitForCompletion
	|
	|-RVA: 0xF01DB0 Offset: 0xF00FB0 VA: 0x180F01DB0
	|-ChainOperation<SceneInstance, SceneInstance>.InvokeWaitForCompletion
	|
	|-RVA: 0xF02050 Offset: 0xF01250 VA: 0x180F02050
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF00F00 Offset: 0xF00100 VA: 0x180F00F00
	|-ChainOperation<long, object>.Execute
	|-ChainOperation<object, object>.Execute
	|
	|-RVA: 0xF00FB0 Offset: 0xF001B0 VA: 0x180F00FB0
	|-ChainOperation<SceneInstance, SceneInstance>.Execute
	|
	|-RVA: 0xF01060 Offset: 0xF00260 VA: 0x180F01060
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF02490 Offset: 0xF01690 VA: 0x180F02490
	|-ChainOperation<long, object>.OnWrappedCompleted
	|
	|-RVA: 0xF02820 Offset: 0xF01A20 VA: 0x180F02820
	|-ChainOperation<object, object>.OnWrappedCompleted
	|
	|-RVA: 0xF02970 Offset: 0xF01B70 VA: 0x180F02970
	|-ChainOperation<SceneInstance, SceneInstance>.OnWrappedCompleted
	|
	|-RVA: 0xF025E0 Offset: 0xF017E0 VA: 0x180F025E0
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWrappedCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF00BE0 Offset: 0xEFFDE0 VA: 0x180F00BE0
	|-ChainOperation<long, object>.Destroy
	|
	|-RVA: 0xF00D20 Offset: 0xEFFF20 VA: 0x180F00D20
	|-ChainOperation<object, object>.Destroy
	|
	|-RVA: 0xF00C80 Offset: 0xEFFE80 VA: 0x180F00C80
	|-ChainOperation<SceneInstance, SceneInstance>.Destroy
	|
	|-RVA: 0xF00DC0 Offset: 0xEFFFC0 VA: 0x180F00DC0
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF030D0 Offset: 0xF022D0 VA: 0x180F030D0
	|-ChainOperation<long, object>.ReleaseDependencies
	|-ChainOperation<object, object>.ReleaseDependencies
	|
	|-RVA: 0xF03070 Offset: 0xF02270 VA: 0x180F03070
	|-ChainOperation<SceneInstance, SceneInstance>.ReleaseDependencies
	|
	|-RVA: 0xF03130 Offset: 0xF02330 VA: 0x180F03130
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF019E0 Offset: 0xF00BE0 VA: 0x180F019E0
	|-ChainOperation<long, object>.GetDownloadStatus
	|
	|-RVA: 0xF01760 Offset: 0xF00960 VA: 0x180F01760
	|-ChainOperation<object, object>.GetDownloadStatus
	|
	|-RVA: 0xF01940 Offset: 0xF00B40 VA: 0x180F01940
	|-ChainOperation<SceneInstance, SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0xF01800 Offset: 0xF00A00 VA: 0x180F01800
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	private void RefreshDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF02F50 Offset: 0xF02150 VA: 0x180F02F50
	|-ChainOperation<long, object>.RefreshDownloadStatus
	|
	|-RVA: 0xF02AD0 Offset: 0xF01CD0 VA: 0x180F02AD0
	|-ChainOperation<object, object>.RefreshDownloadStatus
	|
	|-RVA: 0xF02E30 Offset: 0xF02030 VA: 0x180F02E30
	|-ChainOperation<SceneInstance, SceneInstance>.RefreshDownloadStatus
	|
	|-RVA: 0xF02BF0 Offset: 0xF01DF0 VA: 0x180F02BF0
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RefreshDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF03A80 Offset: 0xF02C80 VA: 0x180F03A80
	|-ChainOperation<long, object>.get_Progress
	|
	|-RVA: 0xF03FD0 Offset: 0xF031D0 VA: 0x180F03FD0
	|-ChainOperation<object, object>.get_Progress
	|
	|-RVA: 0xF03C10 Offset: 0xF02E10 VA: 0x180F03C10
	|-ChainOperation<SceneInstance, SceneInstance>.get_Progress
	|
	|-RVA: 0xF03DA0 Offset: 0xF02FA0 VA: 0x180F03DA0
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Progress
	*/
}

// Namespace: UnityEngine.ResourceManagement
internal class ChainOperationTypelessDepedency<TObject> : AsyncOperationBase<TObject> // TypeDefIndex: 16405
{
	// Fields
	private AsyncOperationHandle m_DepOp; // 0x0
	private AsyncOperationHandle<TObject> m_WrappedOp; // 0x0
	private DownloadStatus m_depStatus; // 0x0
	private DownloadStatus m_wrapStatus; // 0x0
	private Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> m_Callback; // 0x0
	private Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFFE80 Offset: 0xEFF080 VA: 0x180EFFE80
	|-ChainOperationTypelessDepedency<bool>..ctor
	|
	|-RVA: 0xEFFF10 Offset: 0xEFF110 VA: 0x180EFFF10
	|-ChainOperationTypelessDepedency<long>..ctor
	|
	|-RVA: 0xEFFDF0 Offset: 0xEFEFF0 VA: 0x180EFFDF0
	|-ChainOperationTypelessDepedency<object>..ctor
	|
	|-RVA: 0xEFFC60 Offset: 0xEFEE60 VA: 0x180EFFC60
	|-ChainOperationTypelessDepedency<SceneInstance>..ctor
	|
	|-RVA: 0xEFFCF0 Offset: 0xEFEEF0 VA: 0x180EFFCF0
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFFFA0 Offset: 0xEFF1A0 VA: 0x180EFFFA0
	|-ChainOperationTypelessDepedency<bool>.get_DebugName
	|
	|-RVA: 0xF00160 Offset: 0xEFF360 VA: 0x180F00160
	|-ChainOperationTypelessDepedency<long>.get_DebugName
	|
	|-RVA: 0xF00080 Offset: 0xEFF280 VA: 0x180F00080
	|-ChainOperationTypelessDepedency<object>.get_DebugName
	|
	|-RVA: 0xF00240 Offset: 0xEFF440 VA: 0x180F00240
	|-ChainOperationTypelessDepedency<SceneInstance>.get_DebugName
	|
	|-RVA: 0xF00320 Offset: 0xEFF520 VA: 0x180F00320
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFDC20 Offset: 0xEFCE20 VA: 0x180EFDC20
	|-ChainOperationTypelessDepedency<bool>.GetDependencies
	|
	|-RVA: 0xEFDDE0 Offset: 0xEFCFE0 VA: 0x180EFDDE0
	|-ChainOperationTypelessDepedency<long>.GetDependencies
	|
	|-RVA: 0xEFDD00 Offset: 0xEFCF00 VA: 0x180EFDD00
	|-ChainOperationTypelessDepedency<object>.GetDependencies
	|
	|-RVA: 0xEFDEC0 Offset: 0xEFD0C0 VA: 0x180EFDEC0
	|-ChainOperationTypelessDepedency<SceneInstance>.GetDependencies
	|
	|-RVA: 0xEFDB00 Offset: 0xEFCD00 VA: 0x180EFDB00
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFE5A0 Offset: 0xEFD7A0 VA: 0x180EFE5A0
	|-ChainOperationTypelessDepedency<bool>.Init
	|
	|-RVA: 0xEFE3E0 Offset: 0xEFD5E0 VA: 0x180EFE3E0
	|-ChainOperationTypelessDepedency<long>.Init
	|
	|-RVA: 0xEFE360 Offset: 0xEFD560 VA: 0x180EFE360
	|-ChainOperationTypelessDepedency<object>.Init
	|
	|-RVA: 0xEFE620 Offset: 0xEFD820 VA: 0x180EFE620
	|-ChainOperationTypelessDepedency<SceneInstance>.Init
	|
	|-RVA: 0xEFE460 Offset: 0xEFD660 VA: 0x180EFE460
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFEA10 Offset: 0xEFDC10 VA: 0x180EFEA10
	|-ChainOperationTypelessDepedency<bool>.InvokeWaitForCompletion
	|
	|-RVA: 0xEFE8F0 Offset: 0xEFDAF0 VA: 0x180EFE8F0
	|-ChainOperationTypelessDepedency<long>.InvokeWaitForCompletion
	|
	|-RVA: 0xEFE7D0 Offset: 0xEFD9D0 VA: 0x180EFE7D0
	|-ChainOperationTypelessDepedency<object>.InvokeWaitForCompletion
	|
	|-RVA: 0xEFE6A0 Offset: 0xEFD8A0 VA: 0x180EFE6A0
	|-ChainOperationTypelessDepedency<SceneInstance>.InvokeWaitForCompletion
	|
	|-RVA: 0xEFEB30 Offset: 0xEFDD30 VA: 0x180EFEB30
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD720 Offset: 0xEFC920 VA: 0x180EFD720
	|-ChainOperationTypelessDepedency<bool>.Execute
	|
	|-RVA: 0xEFD7D0 Offset: 0xEFC9D0 VA: 0x180EFD7D0
	|-ChainOperationTypelessDepedency<long>.Execute
	|-ChainOperationTypelessDepedency<object>.Execute
	|
	|-RVA: 0xEFD880 Offset: 0xEFCA80 VA: 0x180EFD880
	|-ChainOperationTypelessDepedency<SceneInstance>.Execute
	|
	|-RVA: 0xEFD930 Offset: 0xEFCB30 VA: 0x180EFD930
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFF410 Offset: 0xEFE610 VA: 0x180EFF410
	|-ChainOperationTypelessDepedency<bool>.OnWrappedCompleted
	|
	|-RVA: 0xEFEF20 Offset: 0xEFE120 VA: 0x180EFEF20
	|-ChainOperationTypelessDepedency<long>.OnWrappedCompleted
	|
	|-RVA: 0xEFEDD0 Offset: 0xEFDFD0 VA: 0x180EFEDD0
	|-ChainOperationTypelessDepedency<object>.OnWrappedCompleted
	|
	|-RVA: 0xEFF2B0 Offset: 0xEFE4B0 VA: 0x180EFF2B0
	|-ChainOperationTypelessDepedency<SceneInstance>.OnWrappedCompleted
	|
	|-RVA: 0xEFF070 Offset: 0xEFE270 VA: 0x180EFF070
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.OnWrappedCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD6A0 Offset: 0xEFC8A0 VA: 0x180EFD6A0
	|-ChainOperationTypelessDepedency<bool>.Destroy
	|
	|-RVA: 0xEFD620 Offset: 0xEFC820 VA: 0x180EFD620
	|-ChainOperationTypelessDepedency<long>.Destroy
	|
	|-RVA: 0xEFD490 Offset: 0xEFC690 VA: 0x180EFD490
	|-ChainOperationTypelessDepedency<object>.Destroy
	|
	|-RVA: 0xEFD410 Offset: 0xEFC610 VA: 0x180EFD410
	|-ChainOperationTypelessDepedency<SceneInstance>.Destroy
	|
	|-RVA: 0xEFD510 Offset: 0xEFC710 VA: 0x180EFD510
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFFBB0 Offset: 0xEFEDB0 VA: 0x180EFFBB0
	|-ChainOperationTypelessDepedency<bool>.ReleaseDependencies
	|-ChainOperationTypelessDepedency<long>.ReleaseDependencies
	|-ChainOperationTypelessDepedency<object>.ReleaseDependencies
	|
	|-RVA: 0xEFFB70 Offset: 0xEFED70 VA: 0x180EFFB70
	|-ChainOperationTypelessDepedency<SceneInstance>.ReleaseDependencies
	|
	|-RVA: 0xEFFBF0 Offset: 0xEFEDF0 VA: 0x180EFFBF0
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFE0E0 Offset: 0xEFD2E0 VA: 0x180EFE0E0
	|-ChainOperationTypelessDepedency<bool>.GetDownloadStatus
	|
	|-RVA: 0xEFDFA0 Offset: 0xEFD1A0 VA: 0x180EFDFA0
	|-ChainOperationTypelessDepedency<long>.GetDownloadStatus
	|
	|-RVA: 0xEFE2C0 Offset: 0xEFD4C0 VA: 0x180EFE2C0
	|-ChainOperationTypelessDepedency<object>.GetDownloadStatus
	|
	|-RVA: 0xEFE040 Offset: 0xEFD240 VA: 0x180EFE040
	|-ChainOperationTypelessDepedency<SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0xEFE180 Offset: 0xEFD380 VA: 0x180EFE180
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	private void RefreshDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFFA70 Offset: 0xEFEC70 VA: 0x180EFFA70
	|-ChainOperationTypelessDepedency<bool>.RefreshDownloadStatus
	|
	|-RVA: 0xEFF970 Offset: 0xEFEB70 VA: 0x180EFF970
	|-ChainOperationTypelessDepedency<long>.RefreshDownloadStatus
	|
	|-RVA: 0xEFF770 Offset: 0xEFE970 VA: 0x180EFF770
	|-ChainOperationTypelessDepedency<object>.RefreshDownloadStatus
	|
	|-RVA: 0xEFF870 Offset: 0xEFEA70 VA: 0x180EFF870
	|-ChainOperationTypelessDepedency<SceneInstance>.RefreshDownloadStatus
	|
	|-RVA: 0xEFF560 Offset: 0xEFE760 VA: 0x180EFF560
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.RefreshDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF00A70 Offset: 0xEFFC70 VA: 0x180F00A70
	|-ChainOperationTypelessDepedency<bool>.get_Progress
	|
	|-RVA: 0xF00420 Offset: 0xEFF620 VA: 0x180F00420
	|-ChainOperationTypelessDepedency<long>.get_Progress
	|
	|-RVA: 0xF00790 Offset: 0xEFF990 VA: 0x180F00790
	|-ChainOperationTypelessDepedency<object>.get_Progress
	|
	|-RVA: 0xF00900 Offset: 0xEFFB00 VA: 0x180F00900
	|-ChainOperationTypelessDepedency<SceneInstance>.get_Progress
	|
	|-RVA: 0xF00590 Offset: 0xEFF790 VA: 0x180F00590
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.get_Progress
	*/
}

// Namespace: 
public enum ResourceManager.DiagnosticEventType // TypeDefIndex: 16406
{
	// Fields
	public int value__; // 0x0
	public const ResourceManager.DiagnosticEventType AsyncOperationFail = 0;
	public const ResourceManager.DiagnosticEventType AsyncOperationCreate = 1;
	public const ResourceManager.DiagnosticEventType AsyncOperationPercentComplete = 2;
	public const ResourceManager.DiagnosticEventType AsyncOperationComplete = 3;
	public const ResourceManager.DiagnosticEventType AsyncOperationReferenceCount = 4;
	public const ResourceManager.DiagnosticEventType AsyncOperationDestroy = 5;
}

// Namespace: 
public struct ResourceManager.DiagnosticEventContext // TypeDefIndex: 16407
{
	// Fields
	[CompilerGenerated]
	private readonly AsyncOperationHandle <OperationHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ResourceManager.DiagnosticEventType <Type>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly int <EventValue>k__BackingField; // 0x1C
	[CompilerGenerated]
	private readonly IResourceLocation <Location>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly object <Context>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Error>k__BackingField; // 0x30

	// Properties
	public AsyncOperationHandle OperationHandle { get; }
	public ResourceManager.DiagnosticEventType Type { get; }
	public int EventValue { get; }
	public IResourceLocation Location { get; }
	public object Context { get; }
	public string Error { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4BBD30 Offset: 0x4BAF30 VA: 0x1804BBD30
	public AsyncOperationHandle get_OperationHandle() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ResourceManager.DiagnosticEventType get_Type() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_EventValue() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IResourceLocation get_Location() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public object get_Context() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Error() { }

	// RVA: 0x2383400 Offset: 0x2382600 VA: 0x182383400
	public void .ctor(AsyncOperationHandle op, ResourceManager.DiagnosticEventType type, int eventValue = 0, string error, object context) { }
}

// Namespace: 
private struct ResourceManager.DeferredCallbackRegisterRequest // TypeDefIndex: 16408
{
	// Fields
	internal IAsyncOperation operation; // 0x0
	internal bool incrementRefCount; // 0x8
}

// Namespace: 
private class ResourceManager.CompletedOperation<TObject> : AsyncOperationBase<TObject> // TypeDefIndex: 16409
{
	// Fields
	private bool m_Success; // 0x0
	private Exception m_Exception; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7C280 Offset: 0xF7B480 VA: 0x180F7C280
	|-ResourceManager.CompletedOperation<bool>..ctor
	|
	|-RVA: 0xF7C2A0 Offset: 0xF7B4A0 VA: 0x180F7C2A0
	|-ResourceManager.CompletedOperation<long>..ctor
	|
	|-RVA: 0xF7C240 Offset: 0xF7B440 VA: 0x180F7C240
	|-ResourceManager.CompletedOperation<object>..ctor
	|
	|-RVA: 0xF7C260 Offset: 0xF7B460 VA: 0x180F7C260
	|-ResourceManager.CompletedOperation<SceneInstance>..ctor
	|
	|-RVA: 0xB7B430 Offset: 0xB7A630 VA: 0x180B7B430
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7BCE0 Offset: 0xF7AEE0 VA: 0x180F7BCE0
	|-ResourceManager.CompletedOperation<bool>.Init
	|
	|-RVA: 0xF7B860 Offset: 0xF7AA60 VA: 0x180F7B860
	|-ResourceManager.CompletedOperation<long>.Init
	|
	|-RVA: 0xF7B960 Offset: 0xF7AB60 VA: 0x180F7B960
	|-ResourceManager.CompletedOperation<object>.Init
	|
	|-RVA: 0xF7BA50 Offset: 0xF7AC50 VA: 0x180F7BA50
	|-ResourceManager.CompletedOperation<SceneInstance>.Init
	|
	|-RVA: 0xF7BDA0 Offset: 0xF7AFA0 VA: 0x180F7BDA0
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1
	public void Init(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7BA20 Offset: 0xF7AC20 VA: 0x180F7BA20
	|-ResourceManager.CompletedOperation<bool>.Init
	|
	|-RVA: 0xF7B920 Offset: 0xF7AB20 VA: 0x180F7B920
	|-ResourceManager.CompletedOperation<long>.Init
	|-ResourceManager.CompletedOperation<object>.Init
	|
	|-RVA: 0xF7BCA0 Offset: 0xF7AEA0 VA: 0x180F7BCA0
	|-ResourceManager.CompletedOperation<SceneInstance>.Init
	|
	|-RVA: 0xF7BB10 Offset: 0xF7AD10 VA: 0x180F7BB10
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7C380 Offset: 0xF7B580 VA: 0x180F7C380
	|-ResourceManager.CompletedOperation<bool>.get_DebugName
	|
	|-RVA: 0xF7C350 Offset: 0xF7B550 VA: 0x180F7C350
	|-ResourceManager.CompletedOperation<long>.get_DebugName
	|
	|-RVA: 0xF7C2C0 Offset: 0xF7B4C0 VA: 0x180F7C2C0
	|-ResourceManager.CompletedOperation<object>.get_DebugName
	|
	|-RVA: 0xF7C2F0 Offset: 0xF7B4F0 VA: 0x180F7C2F0
	|-ResourceManager.CompletedOperation<SceneInstance>.get_DebugName
	|
	|-RVA: 0xF7C320 Offset: 0xF7B520 VA: 0x180F7C320
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7C0F0 Offset: 0xF7B2F0 VA: 0x180F7C0F0
	|-ResourceManager.CompletedOperation<bool>.InvokeWaitForCompletion
	|
	|-RVA: 0xF7C1D0 Offset: 0xF7B3D0 VA: 0x180F7C1D0
	|-ResourceManager.CompletedOperation<long>.InvokeWaitForCompletion
	|
	|-RVA: 0xF7C160 Offset: 0xF7B360 VA: 0x180F7C160
	|-ResourceManager.CompletedOperation<object>.InvokeWaitForCompletion
	|
	|-RVA: 0xF7BFD0 Offset: 0xF7B1D0 VA: 0x180F7BFD0
	|-ResourceManager.CompletedOperation<SceneInstance>.InvokeWaitForCompletion
	|
	|-RVA: 0xF7C040 Offset: 0xF7B240 VA: 0x180F7C040
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7B590 Offset: 0xF7A790 VA: 0x180F7B590
	|-ResourceManager.CompletedOperation<bool>.Execute
	|
	|-RVA: 0xF7B630 Offset: 0xF7A830 VA: 0x180F7B630
	|-ResourceManager.CompletedOperation<long>.Execute
	|
	|-RVA: 0xF7B5E0 Offset: 0xF7A7E0 VA: 0x180F7B5E0
	|-ResourceManager.CompletedOperation<object>.Execute
	|
	|-RVA: 0xF7B680 Offset: 0xF7A880 VA: 0x180F7B680
	|-ResourceManager.CompletedOperation<SceneInstance>.Execute
	|
	|-RVA: 0xF7B6E0 Offset: 0xF7A8E0 VA: 0x180F7B6E0
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>.Execute
	*/
}

// Namespace: 
internal class ResourceManager.InstanceOperation : AsyncOperationBase<GameObject> // TypeDefIndex: 16410
{
	// Fields
	private AsyncOperationHandle<GameObject> m_dependency; // 0x88
	private InstantiationParameters m_instantiationParams; // 0xA8
	private IInstanceProvider m_instanceProvider; // 0xD8
	private GameObject m_instance; // 0xE0
	private Scene m_scene; // 0xE8

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x23855D0 Offset: 0x23847D0 VA: 0x1823855D0
	public void Init(ResourceManager rm, IInstanceProvider instanceProvider, InstantiationParameters instantiationParams, AsyncOperationHandle<GameObject> dependency) { }

	// RVA: 0x23854E0 Offset: 0x23846E0 VA: 0x1823854E0 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x23853D0 Offset: 0x23845D0 VA: 0x1823853D0 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x2385790 Offset: 0x2384990 VA: 0x182385790 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x190DCD0 Offset: 0x190CED0 VA: 0x18190DCD0
	public Scene InstanceScene() { }

	// RVA: 0x2385070 Offset: 0x2384270 VA: 0x182385070 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x23858A0 Offset: 0x2384AA0 VA: 0x1823858A0 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x2385630 Offset: 0x2384830 VA: 0x182385630 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x2385150 Offset: 0x2384350 VA: 0x182385150 Slot: 28
	protected override void Execute() { }

	// RVA: 0x2385750 Offset: 0x2384950 VA: 0x182385750
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ResourceManager.<>c__DisplayClass94_0<TObject> // TypeDefIndex: 16411
{
	// Fields
	public Action<TObject> callback; // 0x0
	public bool releaseDependenciesOnFailure; // 0x0
	public ResourceManager <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ResourceManager.<>c__DisplayClass94_0<object>..ctor
	|-ResourceManager.<>c__DisplayClass94_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ProvideResources>b__0(AsyncOperationHandle x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB12CF0 Offset: 0xB11EF0 VA: 0x180B12CF0
	|-ResourceManager.<>c__DisplayClass94_0<object>.<ProvideResources>b__0
	|
	|-RVA: 0xB12BF0 Offset: 0xB11DF0 VA: 0x180B12BF0
	|-ResourceManager.<>c__DisplayClass94_0<__Il2CppFullySharedGenericType>.<ProvideResources>b__0
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<TObject>> <ProvideResources>b__1(AsyncOperationHandle resultHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB13600 Offset: 0xB12800 VA: 0x180B13600
	|-ResourceManager.<>c__DisplayClass94_0<object>.<ProvideResources>b__1
	|
	|-RVA: 0xB12D90 Offset: 0xB11F90 VA: 0x180B12D90
	|-ResourceManager.<>c__DisplayClass94_0<__Il2CppFullySharedGenericType>.<ProvideResources>b__1
	*/
}

// Namespace: UnityEngine.ResourceManagement
public class ResourceManager : IDisposable // TypeDefIndex: 16412
{
	// Fields
	internal bool postProfilerEvents; // 0x10
	[CompilerGenerated]
	private static Action<AsyncOperationHandle, Exception> <ExceptionHandler>k__BackingField; // 0x0
	[CompilerGenerated]
	private Func<IResourceLocation, string> <InternalIdTransformFunc>k__BackingField; // 0x18
	[CompilerGenerated]
	private Action<UnityWebRequest> <WebRequestOverride>k__BackingField; // 0x20
	internal bool CallbackHooksEnabled; // 0x28
	private ListWithEvents<IResourceProvider> m_ResourceProviders; // 0x30
	private IAllocationStrategy m_allocator; // 0x38
	private ListWithEvents<IUpdateReceiver> m_UpdateReceivers; // 0x40
	private List<IUpdateReceiver> m_UpdateReceiversToRemove; // 0x48
	private bool m_UpdatingReceivers; // 0x50
	private bool m_InsideUpdateMethod; // 0x51
	internal Dictionary<int, IResourceProvider> m_providerMap; // 0x58
	private Dictionary<IOperationCacheKey, IAsyncOperation> m_AssetOperationCache; // 0x60
	private HashSet<ResourceManager.InstanceOperation> m_TrackedInstanceOperations; // 0x68
	private DelegateList<float> m_UpdateCallbacks; // 0x70
	private List<IAsyncOperation> m_DeferredCompleteCallbacks; // 0x78
	private HashSet<IResourceProvider> m_AsestBundleProviders; // 0x80
	private bool m_InsideExecuteDeferredCallbacksMethod; // 0x88
	private List<ResourceManager.DeferredCallbackRegisterRequest> m_DeferredCallbacksToRegister; // 0x90
	private Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, object> m_obsoleteDiagnosticsHandler; // 0x98
	private Action<ResourceManager.DiagnosticEventContext> m_diagnosticsHandler; // 0xA0
	private Action<IAsyncOperation> m_ReleaseOpNonCached; // 0xA8
	private Action<IAsyncOperation> m_ReleaseOpCached; // 0xB0
	private Action<IAsyncOperation> m_ReleaseInstanceOp; // 0xB8
	private static int s_GroupOperationTypeHash; // 0x8
	private static int s_InstanceOperationTypeHash; // 0xC
	[CompilerGenerated]
	private CertificateHandler <CertificateHandlerInstance>k__BackingField; // 0xC0
	private bool m_RegisteredForCallbacks; // 0xC8
	private Dictionary<Type, Type> m_ProviderOperationTypeCache; // 0xD0

	// Properties
	public static Action<AsyncOperationHandle, Exception> ExceptionHandler { get; set; }
	public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public Action<UnityWebRequest> WebRequestOverride { get; set; }
	internal int OperationCacheCount { get; }
	internal int InstanceOperationCount { get; }
	public IAllocationStrategy Allocator { get; set; }
	public IList<IResourceProvider> ResourceProviders { get; }
	public CertificateHandler CertificateHandlerInstance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x238FDC0 Offset: 0x238EFC0 VA: 0x18238FDC0
	public static Action<AsyncOperationHandle, Exception> get_ExceptionHandler() { }

	[CompilerGenerated]
	// RVA: 0x238FEA0 Offset: 0x238F0A0 VA: 0x18238FEA0
	public static void set_ExceptionHandler(Action<AsyncOperationHandle, Exception> value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x238F190 Offset: 0x238E390 VA: 0x18238F190
	public string TransformInternalId(IResourceLocation location) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Action<UnityWebRequest> get_WebRequestOverride() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x238FE50 Offset: 0x238F050 VA: 0x18238FE50
	internal int get_OperationCacheCount() { }

	// RVA: 0x238FE10 Offset: 0x238F010 VA: 0x18238FE10
	internal int get_InstanceOperationCount() { }

	// RVA: 0x238BB70 Offset: 0x238AD70 VA: 0x18238BB70
	public void AddUpdateReceiver(IUpdateReceiver receiver) { }

	// RVA: 0x238EF20 Offset: 0x238E120 VA: 0x18238EF20
	public void RemoveUpdateReciever(IUpdateReceiver receiver) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public IAllocationStrategy get_Allocator() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Allocator(IAllocationStrategy value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public IList<IResourceProvider> get_ResourceProviders() { }

	[CompilerGenerated]
	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0
	public CertificateHandler get_CertificateHandlerInstance() { }

	[CompilerGenerated]
	// RVA: 0x718950 Offset: 0x717B50 VA: 0x180718950
	public void set_CertificateHandlerInstance(CertificateHandler value) { }

	// RVA: 0x238F810 Offset: 0x238EA10 VA: 0x18238F810
	public void .ctor(IAllocationStrategy alloc) { }

	// RVA: 0x238CF70 Offset: 0x238C170 VA: 0x18238CF70
	private void OnObjectAdded(object obj) { }

	// RVA: 0x238D000 Offset: 0x238C200 VA: 0x18238D000
	private void OnObjectRemoved(object obj) { }

	// RVA: 0x238E950 Offset: 0x238DB50 VA: 0x18238E950
	internal void RegisterForCallbacks() { }

	[Obsolete("ClearDiagnosticsCallback is Obsolete, use ClearDiagnosticCallbacks instead.")]
	// RVA: 0x238C1D0 Offset: 0x238B3D0 VA: 0x18238C1D0
	public void ClearDiagnosticsCallback() { }

	// RVA: 0x238C1D0 Offset: 0x238B3D0 VA: 0x18238C1D0
	public void ClearDiagnosticCallbacks() { }

	// RVA: 0x238F220 Offset: 0x238E420 VA: 0x18238F220
	public void UnregisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func) { }

	[Obsolete]
	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	public void RegisterDiagnosticCallback(Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, object> func) { }

	// RVA: 0x238E8A0 Offset: 0x238DAA0 VA: 0x18238E8A0
	public void RegisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func) { }

	// RVA: 0x238D260 Offset: 0x238C460 VA: 0x18238D260
	internal void PostDiagnosticEvent(ResourceManager.DiagnosticEventContext context) { }

	// RVA: 0x238CB70 Offset: 0x238BD70 VA: 0x18238CB70
	public IResourceProvider GetResourceProvider(Type t, IResourceLocation location) { }

	// RVA: 0x238CA90 Offset: 0x238BC90 VA: 0x18238CA90
	private Type GetDefaultTypeForLocation(IResourceLocation loc) { }

	// RVA: 0x238BC20 Offset: 0x238AE20 VA: 0x18238BC20
	private int CalculateLocationsHash(IList<IResourceLocation> locations, Type t) { }

	// RVA: 0x238DE90 Offset: 0x238D090 VA: 0x18238DE90
	private AsyncOperationHandle ProvideResource(IResourceLocation location, Type desiredType, bool releaseDependenciesOnFailure = True) { }

	// RVA: 0x238C1F0 Offset: 0x238B3F0 VA: 0x18238C1F0
	internal IOperationCacheKey CreateCacheKeyForLocation(IResourceProvider provider, IResourceLocation location, Type desiredType) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> ProvideResource<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA68810 Offset: 0xA67A10 VA: 0x180A68810
	|-ResourceManager.ProvideResource<object>
	|
	|-RVA: 0xA68710 Offset: 0xA67910 VA: 0x180A68710
	|-ResourceManager.ProvideResource<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> StartOperation<TObject>(AsyncOperationBase<TObject> operation, AsyncOperationHandle dependency) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA690B0 Offset: 0xA682B0 VA: 0x180A690B0
	|-ResourceManager.StartOperation<bool>
	|
	|-RVA: 0xA69250 Offset: 0xA68450 VA: 0x180A69250
	|-ResourceManager.StartOperation<long>
	|
	|-RVA: 0xA69320 Offset: 0xA68520 VA: 0x180A69320
	|-ResourceManager.StartOperation<object>
	|
	|-RVA: 0xA693F0 Offset: 0xA685F0 VA: 0x180A693F0
	|-ResourceManager.StartOperation<SceneInstance>
	|
	|-RVA: 0xA69180 Offset: 0xA68380 VA: 0x180A69180
	|-ResourceManager.StartOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x238F050 Offset: 0x238E250 VA: 0x18238F050
	internal AsyncOperationHandle StartOperation(IAsyncOperation operation, AsyncOperationHandle dependency) { }

	// RVA: 0x238CE60 Offset: 0x238C060 VA: 0x18238CE60
	private void OnInstanceOperationDestroy(IAsyncOperation o) { }

	// RVA: 0x238D1D0 Offset: 0x238C3D0 VA: 0x18238D1D0
	private void OnOperationDestroyNonCached(IAsyncOperation o) { }

	// RVA: 0x238D060 Offset: 0x238C260 VA: 0x18238D060
	private void OnOperationDestroyCached(IAsyncOperation o) { }

	// RVA: -1 Offset: -1
	internal T CreateOperation<T>(Type actualType, int typeHash, IOperationCacheKey cacheKey, Action<IAsyncOperation> onDestroyAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA68560 Offset: 0xA67760 VA: 0x180A68560
	|-ResourceManager.CreateOperation<object>
	|
	|-RVA: 0xA681D0 Offset: 0xA673D0 VA: 0x180A681D0
	|-ResourceManager.CreateOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x238BAD0 Offset: 0x238ACD0 VA: 0x18238BAD0
	internal void AddOperationToCache(IOperationCacheKey key, IAsyncOperation operation) { }

	// RVA: 0x238EE80 Offset: 0x238E080 VA: 0x18238EE80
	internal bool RemoveOperationFromCache(IOperationCacheKey key) { }

	// RVA: 0x238CE00 Offset: 0x238C000 VA: 0x18238CE00
	internal bool IsOperationCached(IOperationCacheKey key) { }

	// RVA: 0x238BBD0 Offset: 0x238ADD0 VA: 0x18238BBD0
	internal int CachedOperationCount() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateCompletedOperation<TObject>(TObject result, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA66680 Offset: 0xA65880 VA: 0x180A66680
	|-ResourceManager.CreateCompletedOperation<bool>
	|
	|-RVA: 0xA66AF0 Offset: 0xA65CF0 VA: 0x180A66AF0
	|-ResourceManager.CreateCompletedOperation<long>
	|
	|-RVA: 0xA66BF0 Offset: 0xA65DF0 VA: 0x180A66BF0
	|-ResourceManager.CreateCompletedOperation<object>
	|
	|-RVA: 0xA66CF0 Offset: 0xA65EF0 VA: 0x180A66CF0
	|-ResourceManager.CreateCompletedOperation<SceneInstance>
	|
	|-RVA: 0xA668A0 Offset: 0xA65AA0 VA: 0x180A668A0
	|-ResourceManager.CreateCompletedOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateCompletedOperationWithException<TObject>(TObject result, Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA66490 Offset: 0xA65690 VA: 0x180A66490
	|-ResourceManager.CreateCompletedOperationWithException<long>
	|
	|-RVA: 0xA66530 Offset: 0xA65730 VA: 0x180A66530
	|-ResourceManager.CreateCompletedOperationWithException<object>
	|
	|-RVA: 0xA665D0 Offset: 0xA657D0 VA: 0x180A665D0
	|-ResourceManager.CreateCompletedOperationWithException<SceneInstance>
	|
	|-RVA: 0xA66360 Offset: 0xA65560 VA: 0x180A66360
	|-ResourceManager.CreateCompletedOperationWithException<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> CreateCompletedOperationInternal<TObject>(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA65A00 Offset: 0xA64C00 VA: 0x180A65A00
	|-ResourceManager.CreateCompletedOperationInternal<bool>
	|
	|-RVA: 0xA65E10 Offset: 0xA65010 VA: 0x180A65E10
	|-ResourceManager.CreateCompletedOperationInternal<long>
	|
	|-RVA: 0xA65FD0 Offset: 0xA651D0 VA: 0x180A65FD0
	|-ResourceManager.CreateCompletedOperationInternal<object>
	|
	|-RVA: 0xA66190 Offset: 0xA65390 VA: 0x180A66190
	|-ResourceManager.CreateCompletedOperationInternal<SceneInstance>
	|
	|-RVA: 0xA65BD0 Offset: 0xA64DD0 VA: 0x180A65BD0
	|-ResourceManager.CreateCompletedOperationInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x238EE20 Offset: 0x238E020 VA: 0x18238EE20
	public void Release(AsyncOperationHandle handle) { }

	// RVA: 0x238BA70 Offset: 0x238AC70 VA: 0x18238BA70
	public void Acquire(AsyncOperationHandle handle) { }

	// RVA: 0x238B960 Offset: 0x238AB60 VA: 0x18238B960
	private GroupOperation AcquireGroupOpFromCache(IOperationCacheKey key) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA67730 Offset: 0xA66930 VA: 0x180A67730
	|-ResourceManager.CreateGroupOperation<object>
	|
	|-RVA: 0xA66DF0 Offset: 0xA65FF0 VA: 0x180A66DF0
	|-ResourceManager.CreateGroupOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations, bool allowFailedDependencies) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA67C70 Offset: 0xA66E70 VA: 0x180A67C70
	|-ResourceManager.CreateGroupOperation<object>
	|
	|-RVA: 0xA67280 Offset: 0xA66480 VA: 0x180A67280
	|-ResourceManager.CreateGroupOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x238C4B0 Offset: 0x238B6B0 VA: 0x18238C4B0
	public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGenericGroupOperation(List<AsyncOperationHandle> operations, bool releasedCachedOpOnComplete = False) { }

	// RVA: 0x238D610 Offset: 0x238C810 VA: 0x18238D610
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> ProvideResourceGroupCached(IList<IResourceLocation> locations, int groupHash, Type desiredType, Action<AsyncOperationHandle> callback, bool releaseDependenciesOnFailure = True) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA68910 Offset: 0xA67B10 VA: 0x180A68910
	|-ResourceManager.ProvideResources<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, bool releaseDependenciesOnFailure, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA68CA0 Offset: 0xA67EA0 VA: 0x180A68CA0
	|-ResourceManager.ProvideResources<object>
	|
	|-RVA: 0xA689A0 Offset: 0xA67BA0 VA: 0x180A689A0
	|-ResourceManager.ProvideResources<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA64F20 Offset: 0xA64120 VA: 0x180A64F20
	|-ResourceManager.CreateChainOperation<long, object>
	|
	|-RVA: 0xA65250 Offset: 0xA64450 VA: 0x180A65250
	|-ResourceManager.CreateChainOperation<object, object>
	|
	|-RVA: 0xA656D0 Offset: 0xA648D0 VA: 0x180A656D0
	|-ResourceManager.CreateChainOperation<SceneInstance, SceneInstance>
	|
	|-RVA: 0xA64930 Offset: 0xA63B30 VA: 0x180A64930
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA647E0 Offset: 0xA639E0 VA: 0x180A647E0
	|-ResourceManager.CreateChainOperation<bool>
	|
	|-RVA: 0xA65100 Offset: 0xA64300 VA: 0x180A65100
	|-ResourceManager.CreateChainOperation<long>
	|
	|-RVA: 0xA65430 Offset: 0xA64630 VA: 0x180A65430
	|-ResourceManager.CreateChainOperation<object>
	|
	|-RVA: 0xA658B0 Offset: 0xA64AB0 VA: 0x180A658B0
	|-ResourceManager.CreateChainOperation<SceneInstance>
	|
	|-RVA: 0xA64E00 Offset: 0xA64000 VA: 0x180A64E00
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA64B00 Offset: 0xA63D00 VA: 0x180A64B00
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA65580 Offset: 0xA64780 VA: 0x180A65580
	|-ResourceManager.CreateChainOperation<object>
	|
	|-RVA: 0xA64CE0 Offset: 0xA63EE0 VA: 0x180A64CE0
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x238E780 Offset: 0x238D980 VA: 0x18238E780
	public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority) { }

	// RVA: 0x238E680 Offset: 0x238D880 VA: 0x18238E680
	public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	// RVA: 0x238ECC0 Offset: 0x238DEC0 VA: 0x18238ECC0
	public AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider sceneProvider, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	// RVA: 0x238D330 Offset: 0x238C530 VA: 0x18238D330
	public AsyncOperationHandle<GameObject> ProvideInstance(IInstanceProvider provider, IResourceLocation location, InstantiationParameters instantiateParameters) { }

	// RVA: 0x238BE90 Offset: 0x238B090 VA: 0x18238BE90
	public void CleanupSceneInstances(Scene scene) { }

	// RVA: 0x238C870 Offset: 0x238BA70 VA: 0x18238C870
	private void ExecuteDeferredCallbacks() { }

	// RVA: 0x238EA90 Offset: 0x238DC90 VA: 0x18238EA90
	internal void RegisterForDeferredCallback(IAsyncOperation op, bool incrementRefCount = True) { }

	// RVA: 0x238F320 Offset: 0x238E520 VA: 0x18238F320
	internal void Update(float unscaledDeltaTime) { }

	// RVA: 0x238C710 Offset: 0x238B910 VA: 0x18238C710 Slot: 4
	public void Dispose() { }

	// RVA: 0x238F730 Offset: 0x238E930 VA: 0x18238F730
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x238F210 Offset: 0x238E410 VA: 0x18238F210
	private void <.ctor>b__54_0(IUpdateReceiver x) { }
}

// Namespace: UnityEngine.ResourceManagement
public interface IUpdateReceiver // TypeDefIndex: 16413
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Update(float unscaledDeltaTime);
}

// Namespace: UnityEngine.ResourceManagement
public class WebRequestQueueOperation // TypeDefIndex: 16414
{
	// Fields
	private bool m_Completed; // 0x10
	public UnityWebRequestAsyncOperation Result; // 0x18
	public Action<UnityWebRequestAsyncOperation> OnComplete; // 0x20
	internal UnityWebRequest m_WebRequest; // 0x28

	// Properties
	public bool IsDone { get; }
	public UnityWebRequest WebRequest { get; set; }

	// Methods

	// RVA: 0x23932A0 Offset: 0x23924A0 VA: 0x1823932A0
	public bool get_IsDone() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public UnityWebRequest get_WebRequest() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_WebRequest(UnityWebRequest value) { }

	// RVA: 0x1322410 Offset: 0x1321610 VA: 0x181322410
	public void .ctor(UnityWebRequest request) { }

	// RVA: 0x2393270 Offset: 0x2392470 VA: 0x182393270
	internal void Complete(UnityWebRequestAsyncOperation asyncOp) { }
}

// Namespace: UnityEngine.ResourceManagement
public static class WebRequestQueue // TypeDefIndex: 16415
{
	// Fields
	internal static int s_MaxRequest; // 0x0
	internal static Queue<WebRequestQueueOperation> s_QueuedOperations; // 0x8
	internal static List<UnityWebRequestAsyncOperation> s_ActiveRequests; // 0x10

	// Methods

	// RVA: 0x2393730 Offset: 0x2392930 VA: 0x182393730
	public static void SetMaxConcurrentRequests(int maxRequests) { }

	// RVA: 0x2393610 Offset: 0x2392810 VA: 0x182393610
	public static WebRequestQueueOperation QueueRequest(UnityWebRequest request) { }

	// RVA: 0x23937F0 Offset: 0x23929F0 VA: 0x1823937F0
	public static void WaitForRequestToBeActive(WebRequestQueueOperation request, int millisecondsTimeout) { }

	// RVA: 0x23934D0 Offset: 0x23926D0 VA: 0x1823934D0
	private static void OnWebAsyncOpComplete(AsyncOperation operation) { }

	// RVA: 0x23932C0 Offset: 0x23924C0 VA: 0x1823932C0
	private static void BeginWebRequest(WebRequestQueueOperation queueOperation) { }

	// RVA: 0x2393BE0 Offset: 0x2392DE0 VA: 0x182393BE0
	private static void .cctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class ResourceManagerException : Exception // TypeDefIndex: 16416
{
	// Methods

	// RVA: 0x238B7C0 Offset: 0x238A9C0 VA: 0x18238B7C0
	public void .ctor() { }

	// RVA: 0x238B890 Offset: 0x238AA90 VA: 0x18238B890
	public void .ctor(string message) { }

	// RVA: 0x238B8F0 Offset: 0x238AAF0 VA: 0x18238B8F0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x238B810 Offset: 0x238AA10 VA: 0x18238B810
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x238B730 Offset: 0x238A930 VA: 0x18238B730 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class UnknownResourceProviderException : ResourceManagerException // TypeDefIndex: 16417
{
	// Fields
	[CompilerGenerated]
	private IResourceLocation <Location>k__BackingField; // 0x90

	// Properties
	public IResourceLocation Location { get; set; }
	public override string Message { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public IResourceLocation get_Location() { }

	[CompilerGenerated]
	// RVA: 0x43B590 Offset: 0x43A790 VA: 0x18043B590
	private void set_Location(IResourceLocation value) { }

	// RVA: 0x2392BE0 Offset: 0x2391DE0 VA: 0x182392BE0
	public void .ctor(IResourceLocation location) { }

	// RVA: 0x238B7C0 Offset: 0x238A9C0 VA: 0x18238B7C0
	public void .ctor() { }

	// RVA: 0x238B890 Offset: 0x238AA90 VA: 0x18238B890
	public void .ctor(string message) { }

	// RVA: 0x238B8F0 Offset: 0x238AAF0 VA: 0x18238B8F0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x238B810 Offset: 0x238AA10 VA: 0x18238B810
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x2392C40 Offset: 0x2391E40 VA: 0x182392C40 Slot: 5
	public override string get_Message() { }

	// RVA: 0x19B4EC0 Offset: 0x19B40C0 VA: 0x1819B4EC0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class OperationException : Exception // TypeDefIndex: 16418
{
	// Methods

	// RVA: 0x238A0F0 Offset: 0x23892F0 VA: 0x18238A0F0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x238A060 Offset: 0x2389260 VA: 0x18238A060 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class ProviderException : OperationException // TypeDefIndex: 16419
{
	// Fields
	[CompilerGenerated]
	private readonly IResourceLocation <Location>k__BackingField; // 0x90

	// Properties
	public IResourceLocation Location { get; }

	// Methods

	// RVA: 0x238A6E0 Offset: 0x23898E0 VA: 0x18238A6E0
	public void .ctor(string message, IResourceLocation location, Exception innerException) { }

	[CompilerGenerated]
	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public IResourceLocation get_Location() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class RemoteProviderException : ProviderException // TypeDefIndex: 16420
{
	// Fields
	[CompilerGenerated]
	private readonly UnityWebRequestResult <WebRequestResult>k__BackingField; // 0x98

	// Properties
	public override string Message { get; }
	public UnityWebRequestResult WebRequestResult { get; }

	// Methods

	// RVA: 0x238AA30 Offset: 0x2389C30 VA: 0x18238AA30
	public void .ctor(string message, IResourceLocation location, UnityWebRequestResult uwrResult, Exception innerException) { }

	// RVA: 0x172A230 Offset: 0x1729430 VA: 0x18172A230 Slot: 5
	public override string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public UnityWebRequestResult get_WebRequestResult() { }

	// RVA: 0x238A7F0 Offset: 0x23899F0 VA: 0x18238A7F0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
[ExecuteInEditMode]
public abstract class ComponentSingleton<T> : MonoBehaviour // TypeDefIndex: 16421
{
	// Fields
	private static T s_Instance; // 0x0

	// Properties
	public static bool Exists { get; }
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_Exists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D1E0 Offset: 0xF7C3E0 VA: 0x180F7D1E0
	|-ComponentSingleton<object>.get_Exists
	*/

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D270 Offset: 0xF7C470 VA: 0x180F7D270
	|-ComponentSingleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	private static T FindInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D0F0 Offset: 0xF7C2F0 VA: 0x180F7D0F0
	|-ComponentSingleton<object>.FindInstance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual string GetGameObjectName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D160 Offset: 0xF7C360 VA: 0x180F7D160
	|-ComponentSingleton<object>.GetGameObjectName
	*/

	// RVA: -1 Offset: -1
	private static T CreateNewSingleton() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7CE50 Offset: 0xF7C050 VA: 0x180F7CE50
	|-ComponentSingleton<object>.CreateNewSingleton
	*/

	// RVA: -1 Offset: -1
	private void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7CBD0 Offset: 0xF7BDD0 VA: 0x180F7CBD0
	|-ComponentSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	public static void DestroySingleton() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7CF80 Offset: 0xF7C180 VA: 0x180F7CF80
	|-ComponentSingleton<object>.DestroySingleton
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	|-ComponentSingleton<object>..ctor
	*/
}

// Namespace: 
private struct DelayedActionManager.DelegateInfo // TypeDefIndex: 16422
{
	// Fields
	private static int s_Id; // 0x0
	private int m_Id; // 0x0
	private Delegate m_Delegate; // 0x8
	private object[] m_Target; // 0x10
	[CompilerGenerated]
	private float <InvocationTime>k__BackingField; // 0x18

	// Properties
	public float InvocationTime { get; set; }

	// Methods

	// RVA: 0x2382150 Offset: 0x2381350 VA: 0x182382150
	public void .ctor(Delegate d, float invocationTime, object[] p) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x485420 Offset: 0x484620 VA: 0x180485420
	public float get_InvocationTime() { }

	[CompilerGenerated]
	// RVA: 0x482DB0 Offset: 0x481FB0 VA: 0x180482DB0
	private void set_InvocationTime(float value) { }

	// RVA: 0x2381DE0 Offset: 0x2380FE0 VA: 0x182381DE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2381C90 Offset: 0x2380E90 VA: 0x182381C90
	public void Invoke() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal class DelayedActionManager : ComponentSingleton<DelayedActionManager> // TypeDefIndex: 16423
{
	// Fields
	private List<DelayedActionManager.DelegateInfo>[] m_Actions; // 0x20
	private LinkedList<DelayedActionManager.DelegateInfo> m_DelayedActions; // 0x28
	private Stack<LinkedListNode<DelayedActionManager.DelegateInfo>> m_NodeCache; // 0x30
	private int m_CollectionIndex; // 0x38
	private bool m_DestroyOnCompletion; // 0x3C

	// Properties
	public static bool IsActive { get; }

	// Methods

	// RVA: 0x23812C0 Offset: 0x23804C0 VA: 0x1823812C0
	private LinkedListNode<DelayedActionManager.DelegateInfo> GetNode(ref DelayedActionManager.DelegateInfo del) { }

	// RVA: 0x2381250 Offset: 0x2380450 VA: 0x182381250
	public static void Clear() { }

	// RVA: 0x23812B0 Offset: 0x23804B0 VA: 0x1823812B0
	private void DestroyWhenComplete() { }

	// RVA: 0x23811D0 Offset: 0x23803D0 VA: 0x1823811D0
	public static void AddAction(Delegate action, float delay = 0, object[] parameters) { }

	// RVA: 0x2380F40 Offset: 0x2380140 VA: 0x182380F40
	private void AddActionInternal(Delegate action, float delay, object[] parameters) { }

	// RVA: 0x2381B50 Offset: 0x2380D50 VA: 0x182381B50
	public static bool get_IsActive() { }

	// RVA: 0x23817F0 Offset: 0x23809F0 VA: 0x1823817F0
	public static bool Wait(float timeout = 0, float timeAdvanceAmount = 0) { }

	// RVA: 0x2381710 Offset: 0x2380910 VA: 0x182381710
	private void LateUpdate() { }

	// RVA: 0x23813C0 Offset: 0x23805C0 VA: 0x1823813C0
	private void InternalLateUpdate(float t) { }

	// RVA: 0x2381740 Offset: 0x2380940 VA: 0x182381740
	private void OnApplicationQuit() { }

	// RVA: 0x2381980 Offset: 0x2380B80 VA: 0x182381980
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal interface IOperationCacheKey : IEquatable<IOperationCacheKey> // TypeDefIndex: 16424
{}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class IdCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 16425
{
	// Fields
	public string ID; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(string id) { }

	// RVA: 0x2384FC0 Offset: 0x23841C0 VA: 0x182384FC0
	private bool Equals(IdCacheKey other) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2384FF0 Offset: 0x23841F0 VA: 0x182384FF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2384F40 Offset: 0x2384140 VA: 0x182384F40 Slot: 4
	public bool Equals(IOperationCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class LocationCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 16426
{
	// Fields
	private readonly IResourceLocation m_Location; // 0x10
	private readonly Type m_DesiredType; // 0x18

	// Methods

	// RVA: 0x2389520 Offset: 0x2388720 VA: 0x182389520
	public void .ctor(IResourceLocation location, Type desiredType) { }

	// RVA: 0x23894D0 Offset: 0x23886D0 VA: 0x1823894D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2389300 Offset: 0x2388500 VA: 0x182389300 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2389420 Offset: 0x2388620 VA: 0x182389420 Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x23893B0 Offset: 0x23885B0 VA: 0x1823893B0
	private bool Equals(LocationCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class DependenciesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 16427
{
	// Fields
	private readonly IList<IResourceLocation> m_Dependencies; // 0x10
	private readonly int m_DependenciesHash; // 0x18

	// Methods

	// RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	public void .ctor(IList<IResourceLocation> dependencies, int dependenciesHash) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23821D0 Offset: 0x23813D0 VA: 0x1823821D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2382360 Offset: 0x2381560 VA: 0x182382360 Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x2382230 Offset: 0x2381430 VA: 0x182382230
	private bool Equals(DependenciesCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class AsyncOpHandlesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 16428
{
	// Fields
	private readonly HashSet<AsyncOperationHandle> m_Handles; // 0x10

	// Methods

	// RVA: 0x237FAE0 Offset: 0x237ECE0 VA: 0x18237FAE0
	public void .ctor(IList<AsyncOperationHandle> handles) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x237F960 Offset: 0x237EB60 VA: 0x18237F960 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x237FA20 Offset: 0x237EC20 VA: 0x18237FA20 Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x237F8E0 Offset: 0x237EAE0 VA: 0x18237F8E0
	private bool Equals(AsyncOpHandlesCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal static class LocationUtils // TypeDefIndex: 16429
{
	// Methods

	// RVA: 0x2389750 Offset: 0x2388950 VA: 0x182389750
	public static bool LocationEquals(IResourceLocation loc1, IResourceLocation loc2) { }

	// RVA: 0x2389640 Offset: 0x2388840 VA: 0x182389640
	public static bool DependenciesEqual(IList<IResourceLocation> deps1, IList<IResourceLocation> deps2) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal class PlatformUtilities // TypeDefIndex: 16430
{
	// Methods

	// RVA: 0x238A160 Offset: 0x2389360 VA: 0x18238A160
	internal static bool PlatformUsesMultiThreading(RuntimePlatform platform) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public interface IInitializableObject // TypeDefIndex: 16431
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Initialize(string id, string data);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data);
}

// Namespace: UnityEngine.ResourceManagement.Util
public interface IObjectInitializationDataProvider // TypeDefIndex: 16432
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ObjectInitializationData CreateObjectInitializationData();
}

// Namespace: UnityEngine.ResourceManagement.Util
public interface IAllocationStrategy // TypeDefIndex: 16433
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object New(Type type, int typeHash);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Release(int typeHash, object obj);
}

// Namespace: UnityEngine.ResourceManagement.Util
public class DefaultAllocationStrategy : IAllocationStrategy // TypeDefIndex: 16434
{
	// Methods

	// RVA: 0x2380F30 Offset: 0x2380130 VA: 0x182380F30 Slot: 4
	public object New(Type type, int typeHash) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void Release(int typeHash, object obj) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class LRUCacheAllocationStrategy : IAllocationStrategy // TypeDefIndex: 16435
{
	// Fields
	private int m_poolMaxSize; // 0x10
	private int m_poolInitialCapacity; // 0x14
	private int m_poolCacheMaxSize; // 0x18
	private List<List<object>> m_poolCache; // 0x20
	private Dictionary<int, List<object>> m_cache; // 0x28

	// Methods

	// RVA: 0x2388A10 Offset: 0x2387C10 VA: 0x182388A10
	public void .ctor(int poolMaxSize, int poolCapacity, int poolCacheMaxSize, int initialPoolCacheCapacity) { }

	// RVA: 0x23884C0 Offset: 0x23876C0 VA: 0x1823884C0
	private List<object> GetPool() { }

	// RVA: 0x2388770 Offset: 0x2387970 VA: 0x182388770
	private void ReleasePool(List<object> pool) { }

	// RVA: 0x23885B0 Offset: 0x23877B0 VA: 0x1823885B0 Slot: 4
	public object New(Type type, int typeHash) { }

	// RVA: 0x2388820 Offset: 0x2387A20 VA: 0x182388820 Slot: 5
	public void Release(int typeHash, object obj) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class SerializedTypeRestrictionAttribute : Attribute // TypeDefIndex: 16436
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class LinkedListNodeCache<T> // TypeDefIndex: 16437
{
	// Fields
	private int m_NodesCreated; // 0x0
	private LinkedList<T> m_NodeCache; // 0x0

	// Properties
	internal int CreatedNodeCount { get; }
	internal int CachedNodeCount { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public LinkedListNode<T> Acquire(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13215E0 Offset: 0x13207E0 VA: 0x1813215E0
	|-LinkedListNodeCache<object>.Acquire
	|
	|-RVA: 0x1321740 Offset: 0x1320940 VA: 0x181321740
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void Release(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1321AA0 Offset: 0x1320CA0 VA: 0x181321AA0
	|-LinkedListNodeCache<object>.Release
	|
	|-RVA: 0x1321920 Offset: 0x1320B20 VA: 0x181321920
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	internal int get_CreatedNodeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-LinkedListNodeCache<object>.get_CreatedNodeCount
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.get_CreatedNodeCount
	*/

	// RVA: -1 Offset: -1
	internal int get_CachedNodeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1321B50 Offset: 0x1320D50 VA: 0x181321B50
	|-LinkedListNodeCache<object>.get_CachedNodeCount
	|
	|-RVA: 0x1321B70 Offset: 0x1320D70 VA: 0x181321B70
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.get_CachedNodeCount
	*/

	// RVA: -1 Offset: -1
	internal void set_CachedNodeCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1321BA0 Offset: 0x1320DA0 VA: 0x181321BA0
	|-LinkedListNodeCache<object>.set_CachedNodeCount
	|
	|-RVA: 0x1321E40 Offset: 0x1321040 VA: 0x181321E40
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.set_CachedNodeCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-LinkedListNodeCache<object>..ctor
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
internal static class GlobalLinkedListNodeCache<T> // TypeDefIndex: 16438
{
	// Fields
	private static LinkedListNodeCache<T> m_globalCache; // 0x0

	// Properties
	public static bool CacheExists { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_CacheExists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1212C90 Offset: 0x1211E90 VA: 0x181212C90
	|-GlobalLinkedListNodeCache<object>.get_CacheExists
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.get_CacheExists
	*/

	// RVA: -1 Offset: -1
	public static void SetCacheSize(int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1212AE0 Offset: 0x1211CE0 VA: 0x181212AE0
	|-GlobalLinkedListNodeCache<object>.SetCacheSize
	|
	|-RVA: 0x12128F0 Offset: 0x1211AF0 VA: 0x1812128F0
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.SetCacheSize
	*/

	// RVA: -1 Offset: -1
	public static LinkedListNode<T> Acquire(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1212390 Offset: 0x1211590 VA: 0x181212390
	|-GlobalLinkedListNodeCache<object>.Acquire
	|
	|-RVA: 0x12120C0 Offset: 0x12112C0 VA: 0x1812120C0
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public static void Release(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1212540 Offset: 0x1211740 VA: 0x181212540
	|-GlobalLinkedListNodeCache<object>.Release
	|
	|-RVA: 0x12126F0 Offset: 0x12118F0 VA: 0x1812126F0
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.Release
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
[Serializable]
public struct SerializedType // TypeDefIndex: 16439
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_assemblyName")]
	private string m_AssemblyName; // 0x0
	[SerializeField]
	[FormerlySerializedAs("m_className")]
	private string m_ClassName; // 0x8
	private Type m_CachedType; // 0x10
	[CompilerGenerated]
	private bool <ValueChanged>k__BackingField; // 0x18

	// Properties
	public string AssemblyName { get; }
	public string ClassName { get; }
	public Type Value { get; set; }
	public bool ValueChanged { get; set; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public string get_AssemblyName() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public string get_ClassName() { }

	// RVA: 0x2391D70 Offset: 0x2390F70 VA: 0x182391D70 Slot: 3
	public override string ToString() { }

	// RVA: 0x2391E20 Offset: 0x2391020 VA: 0x182391E20
	public Type get_Value() { }

	// RVA: 0x2391FA0 Offset: 0x23911A0 VA: 0x182391FA0
	public void set_Value(Type value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_ValueChanged() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_ValueChanged(bool value) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
[Serializable]
public struct ObjectInitializationData // TypeDefIndex: 16440
{
	// Fields
	[FormerlySerializedAs("m_id")]
	[SerializeField]
	private string m_Id; // 0x0
	[FormerlySerializedAs("m_objectType")]
	[SerializeField]
	private SerializedType m_ObjectType; // 0x8
	[FormerlySerializedAs("m_data")]
	[SerializeField]
	private string m_Data; // 0x28

	// Properties
	public string Id { get; }
	public SerializedType ObjectType { get; }
	public string Data { get; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public string get_Id() { }

	// RVA: 0xB4BAE0 Offset: 0xB4ACE0 VA: 0x180B4BAE0
	public SerializedType get_ObjectType() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Data() { }

	// RVA: 0x2389FE0 Offset: 0x23891E0 VA: 0x182389FE0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	public TObject CreateInstance<TObject>(string idOverride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA57BA0 Offset: 0xA56DA0 VA: 0x180A57BA0
	|-ObjectInitializationData.CreateInstance<object>
	|
	|-RVA: 0xA578F0 Offset: 0xA56AF0 VA: 0x180A578F0
	|-ObjectInitializationData.CreateInstance<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2389DB0 Offset: 0x2388FB0 VA: 0x182389DB0
	public AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, string idOverride) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public static class ResourceManagerConfig // TypeDefIndex: 16441
{
	// Methods

	// RVA: 0x238B350 Offset: 0x238A550 VA: 0x18238B350
	public static bool ExtractKeyAndSubKey(object keyObj, out string mainKey, out string subKey) { }

	// RVA: 0x238B430 Offset: 0x238A630 VA: 0x18238B430
	public static bool IsPathRemote(string path) { }

	// RVA: 0x238B6F0 Offset: 0x238A8F0 VA: 0x18238B6F0
	public static string StripQueryParameters(string path) { }

	// RVA: 0x238B580 Offset: 0x238A780 VA: 0x18238B580
	public static bool ShouldPathUseWebRequest(string path) { }

	// RVA: 0x238B480 Offset: 0x238A680 VA: 0x18238B480
	private static bool PlatformCanLoadLocallyFromUrlPath() { }

	// RVA: 0x238AFE0 Offset: 0x238A1E0 VA: 0x18238AFE0
	public static Array CreateArrayResult(Type type, Object[] allAssets) { }

	// RVA: -1 Offset: -1
	public static TObject CreateArrayResult<TObject>(Object[] allAssets) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA64540 Offset: 0xA63740 VA: 0x180A64540
	|-ResourceManagerConfig.CreateArrayResult<object>
	*/

	// RVA: 0x238B1B0 Offset: 0x238A3B0 VA: 0x18238B1B0
	public static IList CreateListResult(Type type, Object[] allAssets) { }

	// RVA: -1 Offset: -1
	public static TObject CreateListResult<TObject>(Object[] allAssets) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA64630 Offset: 0xA63830 VA: 0x180A64630
	|-ResourceManagerConfig.CreateListResult<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool IsInstance<T1, T2>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA64740 Offset: 0xA63940 VA: 0x180A64740
	|-ResourceManagerConfig.IsInstance<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
public class UnityWebRequestUtilities // TypeDefIndex: 16442
{
	// Methods

	// RVA: 0x2392AB0 Offset: 0x2391CB0 VA: 0x182392AB0
	public static bool RequestHasErrors(UnityWebRequest webReq, out UnityWebRequestResult result) { }

	// RVA: 0x2392A10 Offset: 0x2391C10 VA: 0x182392A10
	public static bool IsAssetBundleDownloaded(UnityWebRequestAsyncOperation op) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class UnityWebRequestResult // TypeDefIndex: 16443
{
	// Fields
	[CompilerGenerated]
	private string <Error>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly long <ResponseCode>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly UnityWebRequest.Result <Result>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <Method>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Url>k__BackingField; // 0x30

	// Properties
	public string Error { get; set; }
	public long ResponseCode { get; }
	public UnityWebRequest.Result Result { get; }
	public string Method { get; }
	public string Url { get; }

	// Methods

	// RVA: 0x2392910 Offset: 0x2391B10 VA: 0x182392910
	public void .ctor(UnityWebRequest request) { }

	// RVA: 0x23927C0 Offset: 0x23919C0 VA: 0x1823927C0 Slot: 3
	public override string ToString() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Error() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Error(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public long get_ResponseCode() { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public UnityWebRequest.Result get_Result() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Method() { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Url() { }

	// RVA: 0x2392520 Offset: 0x2391720 VA: 0x182392520
	public bool ShouldRetryDownloadError() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
internal class DownloadOnlyLocation : LocationWrapper // TypeDefIndex: 16444
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IResourceLocation location) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public enum AssetLoadMode // TypeDefIndex: 16445
{
	// Fields
	public int value__; // 0x0
	public const AssetLoadMode RequestedAssetAndDependencies = 0;
	public const AssetLoadMode AllPackedAssetsAndDependencies = 1;
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface IAssetBundleResource // TypeDefIndex: 16446
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AssetBundle GetAssetBundle();
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[Serializable]
public class AssetBundleRequestOptions : ILocationSizeData // TypeDefIndex: 16447
{
	// Fields
	[FormerlySerializedAs("m_hash")]
	[SerializeField]
	private string m_Hash; // 0x10
	[SerializeField]
	[FormerlySerializedAs("m_crc")]
	private uint m_Crc; // 0x18
	[FormerlySerializedAs("m_timeout")]
	[SerializeField]
	private int m_Timeout; // 0x1C
	[SerializeField]
	[FormerlySerializedAs("m_chunkedTransfer")]
	private bool m_ChunkedTransfer; // 0x20
	[FormerlySerializedAs("m_redirectLimit")]
	[SerializeField]
	private int m_RedirectLimit; // 0x24
	[SerializeField]
	[FormerlySerializedAs("m_retryCount")]
	private int m_RetryCount; // 0x28
	[SerializeField]
	private string m_BundleName; // 0x30
	[SerializeField]
	private AssetLoadMode m_AssetLoadMode; // 0x38
	[SerializeField]
	private long m_BundleSize; // 0x40
	[SerializeField]
	private bool m_UseCrcForCachedBundles; // 0x48
	[SerializeField]
	private bool m_UseUWRForLocalBundles; // 0x49
	[SerializeField]
	private bool m_ClearOtherCachedVersionsWhenLoaded; // 0x4A

	// Properties
	public string Hash { get; set; }
	public uint Crc { get; set; }
	public int Timeout { get; set; }
	public bool ChunkedTransfer { get; set; }
	public int RedirectLimit { get; set; }
	public int RetryCount { get; set; }
	public string BundleName { get; set; }
	public AssetLoadMode AssetLoadMode { get; set; }
	public long BundleSize { get; set; }
	public bool UseCrcForCachedBundle { get; set; }
	public bool UseUnityWebRequestForLocalBundles { get; set; }
	public bool ClearOtherCachedVersionsWhenLoaded { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Hash() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Hash(string value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_Crc() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Crc(uint value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_Timeout() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_Timeout(int value) { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_ChunkedTransfer() { }

	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_ChunkedTransfer(bool value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_RedirectLimit() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_RedirectLimit(int value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_RetryCount() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_RetryCount(int value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_BundleName() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_BundleName(string value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public AssetLoadMode get_AssetLoadMode() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_AssetLoadMode(AssetLoadMode value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public long get_BundleSize() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_BundleSize(long value) { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_UseCrcForCachedBundle() { }

	// RVA: 0x445A80 Offset: 0x444C80 VA: 0x180445A80
	public void set_UseCrcForCachedBundle(bool value) { }

	// RVA: 0x563E30 Offset: 0x563030 VA: 0x180563E30
	public bool get_UseUnityWebRequestForLocalBundles() { }

	// RVA: 0x563E50 Offset: 0x563050 VA: 0x180563E50
	public void set_UseUnityWebRequestForLocalBundles(bool value) { }

	// RVA: 0x190DBC0 Offset: 0x190CDC0 VA: 0x18190DBC0
	public bool get_ClearOtherCachedVersionsWhenLoaded() { }

	// RVA: 0x190DBD0 Offset: 0x190CDD0 VA: 0x18190DBD0
	public void set_ClearOtherCachedVersionsWhenLoaded(bool value) { }

	// RVA: 0x237D290 Offset: 0x237C490 VA: 0x18237D290 Slot: 5
	public virtual long ComputeSize(IResourceLocation location, ResourceManager resourceManager) { }

	// RVA: 0x237D420 Offset: 0x237C620 VA: 0x18237D420
	public void .ctor() { }
}

// Namespace: 
public enum AssetBundleResource.LoadType // TypeDefIndex: 16448
{
	// Fields
	public int value__; // 0x0
	public const AssetBundleResource.LoadType None = 0;
	public const AssetBundleResource.LoadType Local = 1;
	public const AssetBundleResource.LoadType Web = 2;
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class AssetBundleResource : IAssetBundleResource, IUpdateReceiver // TypeDefIndex: 16449
{
	// Fields
	private AssetBundle m_AssetBundle; // 0x10
	private DownloadHandlerAssetBundle m_downloadHandler; // 0x18
	private DownloadHandler customDownloadHandler; // 0x20
	private AsyncOperation m_RequestOperation; // 0x28
	private WebRequestQueueOperation m_WebRequestQueueOperation; // 0x30
	internal ProvideHandle m_ProvideHandle; // 0x38
	internal AssetBundleRequestOptions m_Options; // 0x50
	private bool m_WebRequestCompletedCallbackCalled; // 0x58
	private int m_Retries; // 0x5C
	private long m_BytesToDownload; // 0x60
	private long m_DownloadedBytes; // 0x68
	private bool m_Completed; // 0x70
	private AssetBundleUnloadOperation m_UnloadOperation; // 0x78
	private const int k_WaitForWebRequestMainThreadSleep = 1;
	private string m_TransformedInternalId; // 0x80
	private AssetBundleRequest m_PreloadRequest; // 0x88
	private bool m_PreloadCompleted; // 0x90
	private ulong m_LastDownloadedByteCount; // 0x98
	private float m_TimeoutTimer; // 0xA0
	private int m_TimeoutOverFrames; // 0xA4

	// Properties
	private bool HasTimedOut { get; }
	internal long BytesToDownload { get; }

	// Methods

	// RVA: 0x237F8A0 Offset: 0x237EAA0 VA: 0x18237F8A0
	private bool get_HasTimedOut() { }

	// RVA: 0x237F7F0 Offset: 0x237E9F0 VA: 0x18237F7F0
	internal long get_BytesToDownload() { }

	// RVA: 0x237DE40 Offset: 0x237D040 VA: 0x18237DE40
	internal UnityWebRequest CreateWebRequest(IResourceLocation loc) { }

	// RVA: 0x237DC80 Offset: 0x237CE80 VA: 0x18237DC80
	internal UnityWebRequest CreateWebRequest(string url) { }

	// RVA: 0x237E070 Offset: 0x237D270 VA: 0x18237E070
	public AssetBundleRequest GetAssetPreloadRequest() { }

	// RVA: 0x237E880 Offset: 0x237DA80 VA: 0x18237E880
	private float PercentComplete() { }

	// RVA: 0x237E1B0 Offset: 0x237D3B0 VA: 0x18237E1B0
	private DownloadStatus GetDownloadStatus() { }

	// RVA: 0x237DEE0 Offset: 0x237D0E0 VA: 0x18237DEE0 Slot: 4
	public AssetBundle GetAssetBundle() { }

	// RVA: 0x237E870 Offset: 0x237DA70 VA: 0x18237E870
	private void OnUnloadOperationComplete(AsyncOperation op) { }

	// RVA: 0x237E8A0 Offset: 0x237DAA0 VA: 0x18237E8A0
	public void Start(ProvideHandle provideHandle, AssetBundleUnloadOperation unloadOp) { }

	// RVA: 0x237EEB0 Offset: 0x237E0B0 VA: 0x18237EEB0
	private bool WaitForCompletionHandler() { }

	// RVA: 0x237D470 Offset: 0x237C670 VA: 0x18237D470
	private void AddCallbackInvokeIfDone(AsyncOperation operation, Action<AsyncOperation> callback) { }

	// RVA: 0x237E360 Offset: 0x237D560 VA: 0x18237E360
	public static void GetLoadInfo(ProvideHandle handle, out AssetBundleResource.LoadType loadType, out string path) { }

	// RVA: 0x237E3F0 Offset: 0x237D5F0 VA: 0x18237E3F0
	internal static void GetLoadInfo(IResourceLocation location, ResourceManager resourceManager, out AssetBundleResource.LoadType loadType, out string path) { }

	// RVA: 0x237D4E0 Offset: 0x237C6E0 VA: 0x18237D4E0
	private void BeginOperation() { }

	// RVA: 0x237D990 Offset: 0x237CB90 VA: 0x18237D990
	private void BeginWebRequestOperation(AsyncOperation asyncOp) { }

	// RVA: 0x237EC20 Offset: 0x237DE20 VA: 0x18237EC20 Slot: 5
	public void Update(float unscaledDeltaTime) { }

	// RVA: 0x237E610 Offset: 0x237D810 VA: 0x18237E610
	private void LocalRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x237DAC0 Offset: 0x237CCC0 VA: 0x18237DAC0
	private void CompleteBundleLoad(AssetBundle bundle) { }

	// RVA: 0x237F200 Offset: 0x237E400 VA: 0x18237F200
	private void WebRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x237ED60 Offset: 0x237DF60 VA: 0x18237ED60
	private void WaitForAssetBundleLoad(AssetBundle assetBundle) { }

	// RVA: 0x237EB50 Offset: 0x237DD50 VA: 0x18237EB50
	public bool Unload(out AssetBundleUnloadOperation unloadOp) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x237EB40 Offset: 0x237DD40 VA: 0x18237EB40
	private void <GetAssetPreloadRequest>b__27_0(AsyncOperation operation) { }

	[CompilerGenerated]
	// RVA: 0x237EB30 Offset: 0x237DD30 VA: 0x18237EB30
	private void <BeginOperation>b__37_0(UnityWebRequestAsyncOperation asyncOp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AssetBundleProvider.<>c__DisplayClass11_0 // TypeDefIndex: 16450
{
	// Fields
	public IResourceLocation location; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23921C0 Offset: 0x23913C0 VA: 0x1823921C0
	internal void <Release>b__0(AsyncOperation op) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("AssetBundle Provider")]
public class AssetBundleProvider : ResourceProviderBase // TypeDefIndex: 16451
{
	// Fields
	private static Dictionary<string, AssetBundleUnloadOperation> m_UnloadingBundles; // 0x0

	// Properties
	protected internal static Dictionary<string, AssetBundleUnloadOperation> UnloadingBundles { get; set; }
	internal static int UnloadingAssetBundleCount { get; }
	internal static int AssetBundleCount { get; }

	// Methods

	// RVA: 0x237D1E0 Offset: 0x237C3E0 VA: 0x18237D1E0
	protected internal static Dictionary<string, AssetBundleUnloadOperation> get_UnloadingBundles() { }

	// RVA: 0x237D230 Offset: 0x237C430 VA: 0x18237D230
	internal static void set_UnloadingBundles(Dictionary<string, AssetBundleUnloadOperation> value) { }

	// RVA: 0x237D170 Offset: 0x237C370 VA: 0x18237D170
	internal static int get_UnloadingAssetBundleCount() { }

	// RVA: 0x237D100 Offset: 0x237C300 VA: 0x18237D100
	internal static int get_AssetBundleCount() { }

	// RVA: 0x237CF80 Offset: 0x237C180 VA: 0x18237CF80
	internal static void WaitForAllUnloadingBundlesToComplete() { }

	// RVA: 0x237CAB0 Offset: 0x237BCB0 VA: 0x18237CAB0 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }

	// RVA: 0x237CA50 Offset: 0x237BC50 VA: 0x18237CA50 Slot: 16
	public override Type GetDefaultType(IResourceLocation location) { }

	// RVA: 0x237CC30 Offset: 0x237BE30 VA: 0x18237CC30 Slot: 15
	public override void Release(IResourceLocation location, object asset) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x237D090 Offset: 0x237C290 VA: 0x18237D090
	private static void .cctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Sprites from Atlases Provider")]
public class AtlasSpriteProvider : ResourceProviderBase // TypeDefIndex: 16452
{
	// Methods

	// RVA: 0x2380940 Offset: 0x237FB40 VA: 0x182380940 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class BundledAssetProvider.InternalOp // TypeDefIndex: 16453
{
	// Fields
	private AssetBundle m_AssetBundle; // 0x10
	private AssetBundleRequest m_PreloadRequest; // 0x18
	private AssetBundleRequest m_RequestOperation; // 0x20
	private object m_Result; // 0x28
	private ProvideHandle m_ProvideHandle; // 0x30
	private string subObjectName; // 0x48

	// Methods

	// RVA: -1 Offset: -1
	internal static T LoadBundleFromDependecies<T>(IList<object> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACCD70 Offset: 0xACBF70 VA: 0x180ACCD70
	|-BundledAssetProvider.InternalOp.LoadBundleFromDependecies<object>
	*/

	// RVA: 0x23878E0 Offset: 0x2386AE0 VA: 0x1823878E0
	public void Start(ProvideHandle provideHandle) { }

	// RVA: 0x23865B0 Offset: 0x23857B0 VA: 0x1823865B0
	private void BeginAssetLoad() { }

	// RVA: 0x2388230 Offset: 0x2387430 VA: 0x182388230
	private bool WaitForCompletionHandler() { }

	// RVA: 0x2385E10 Offset: 0x2385010 VA: 0x182385E10
	private void ActionComplete(AsyncOperation obj) { }

	// RVA: 0x2386E60 Offset: 0x2386060 VA: 0x182386E60
	private void GetArrayResult(Object[] allAssets) { }

	// RVA: 0x23870B0 Offset: 0x23862B0 VA: 0x1823870B0
	private void GetListResult(Object[] allAssets) { }

	// RVA: 0x2386EE0 Offset: 0x23860E0 VA: 0x182386EE0
	private void GetAssetResult(Object asset) { }

	// RVA: 0x2386FD0 Offset: 0x23861D0 VA: 0x182386FD0
	private void GetAssetSubObjectResult(Object[] allAssets) { }

	// RVA: 0x2386B80 Offset: 0x2385D80 VA: 0x182386B80
	private void CompleteOperation() { }

	// RVA: 0x2387170 Offset: 0x2386370 VA: 0x182387170
	public float ProgressCallback() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2388220 Offset: 0x2387420 VA: 0x182388220
	private void <Start>b__7_0(AsyncOperation operation) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Assets from Bundles Provider")]
public class BundledAssetProvider : ResourceProviderBase // TypeDefIndex: 16454
{
	// Methods

	// RVA: 0x2380EB0 Offset: 0x23800B0 VA: 0x182380EB0 Slot: 17
	public override void Provide(ProvideHandle provideHandle) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public struct InstantiationParameters // TypeDefIndex: 16455
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Quaternion m_Rotation; // 0xC
	private Transform m_Parent; // 0x20
	private bool m_InstantiateInWorldPosition; // 0x28
	private bool m_SetPositionRotation; // 0x29

	// Properties
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Transform Parent { get; }
	public bool InstantiateInWorldPosition { get; }
	public bool SetPositionRotation { get; }

	// Methods

	// RVA: 0xAA0C00 Offset: 0xA9FE00 VA: 0x180AA0C00
	public Vector3 get_Position() { }

	// RVA: 0x2385E00 Offset: 0x2385000 VA: 0x182385E00
	public Quaternion get_Rotation() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Transform get_Parent() { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_InstantiateInWorldPosition() { }

	// RVA: 0x4C6AB0 Offset: 0x4C5CB0 VA: 0x1804C6AB0
	public bool get_SetPositionRotation() { }

	// RVA: 0x2385D30 Offset: 0x2384F30 VA: 0x182385D30
	public void .ctor(Transform parent, bool instantiateInWorldSpace) { }

	// RVA: 0x2385DD0 Offset: 0x2384FD0 VA: 0x182385DD0
	public void .ctor(Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: -1 Offset: -1
	public TObject Instantiate<TObject>(TObject source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA24820 Offset: 0xA23A20 VA: 0x180A24820
	|-InstantiationParameters.Instantiate<object>
	*/
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface IInstanceProvider // TypeDefIndex: 16456
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReleaseInstance(ResourceManager resourceManager, GameObject instance);
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class InstanceProvider : IInstanceProvider // TypeDefIndex: 16457
{
	// Fields
	private Dictionary<GameObject, AsyncOperationHandle<GameObject>> m_InstanceObjectToPrefabHandle; // 0x10

	// Methods

	// RVA: 0x23858E0 Offset: 0x2384AE0 VA: 0x1823858E0 Slot: 4
	public GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters) { }

	// RVA: 0x23859A0 Offset: 0x2384BA0 VA: 0x1823859A0 Slot: 5
	public void ReleaseInstance(ResourceManager resourceManager, GameObject instance) { }

	// RVA: 0x2385CC0 Offset: 0x2384EC0 VA: 0x182385CC0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public enum ProviderBehaviourFlags // TypeDefIndex: 16458
{
	// Fields
	public int value__; // 0x0
	public const ProviderBehaviourFlags None = 0;
	public const ProviderBehaviourFlags CanProvideWithFailedDependencies = 1;
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public struct ProvideHandle // TypeDefIndex: 16459
{
	// Fields
	private int m_Version; // 0x0
	private IGenericProviderOperation m_InternalOp; // 0x8
	private ResourceManager m_ResourceManager; // 0x10

	// Properties
	private IGenericProviderOperation InternalOp { get; }
	public ResourceManager ResourceManager { get; }
	public Type Type { get; }
	public IResourceLocation Location { get; }
	public int DependencyCount { get; }

	// Methods

	// RVA: 0x238A4B0 Offset: 0x23896B0 VA: 0x18238A4B0
	internal void .ctor(ResourceManager rm, IGenericProviderOperation op) { }

	// RVA: 0x238A580 Offset: 0x2389780 VA: 0x18238A580
	private IGenericProviderOperation get_InternalOp() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ResourceManager get_ResourceManager() { }

	// RVA: 0x238A680 Offset: 0x2389880 VA: 0x18238A680
	public Type get_Type() { }

	// RVA: 0x238A620 Offset: 0x2389820 VA: 0x18238A620
	public IResourceLocation get_Location() { }

	// RVA: 0x238A520 Offset: 0x2389720 VA: 0x18238A520
	public int get_DependencyCount() { }

	// RVA: -1 Offset: -1
	public TDepObject GetDependency<TDepObject>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5D150 Offset: 0xA5C350 VA: 0x180A5D150
	|-ProvideHandle.GetDependency<object>
	|
	|-RVA: 0xA5D000 Offset: 0xA5C200 VA: 0x180A5D000
	|-ProvideHandle.GetDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x238A170 Offset: 0x2389370 VA: 0x18238A170
	public void GetDependencies(IList<object> list) { }

	// RVA: 0x238A310 Offset: 0x2389510 VA: 0x18238A310
	public void SetProgressCallback(Func<float> callback) { }

	// RVA: 0x238A240 Offset: 0x2389440 VA: 0x18238A240
	public void SetDownloadProgressCallbacks(Func<DownloadStatus> callback) { }

	// RVA: 0x238A3E0 Offset: 0x23895E0 VA: 0x18238A3E0
	public void SetWaitForCompletionCallback(Func<bool> callback) { }

	// RVA: -1 Offset: -1
	public void Complete<T>(T result, bool status, Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5CEF0 Offset: 0xA5C0F0 VA: 0x180A5CEF0
	|-ProvideHandle.Complete<object>
	|
	|-RVA: 0xA5CD70 Offset: 0xA5BF70 VA: 0x180A5CD70
	|-ProvideHandle.Complete<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface IResourceProvider // TypeDefIndex: 16460
{
	// Properties
	public abstract string ProviderId { get; }
	public abstract ProviderBehaviourFlags BehaviourFlags { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ProviderId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type GetDefaultType(IResourceLocation location);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool CanProvide(Type type, IResourceLocation location);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Provide(ProvideHandle provideHandle);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Release(IResourceLocation location, object asset);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ProviderBehaviourFlags get_BehaviourFlags();
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public struct SceneInstance // TypeDefIndex: 16461
{
	// Fields
	private Scene m_Scene; // 0x0
	internal AsyncOperation m_Operation; // 0x8

	// Properties
	public Scene Scene { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Scene get_Scene() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	internal void set_Scene(Scene value) { }

	[Obsolete("Activate() has been deprecated.  Please use ActivateAsync().")]
	// RVA: 0x23901F0 Offset: 0x238F3F0 VA: 0x1823901F0
	public void Activate() { }

	// RVA: 0x23901C0 Offset: 0x238F3C0 VA: 0x1823901C0
	public AsyncOperation ActivateAsync() { }

	// RVA: 0x23902E0 Offset: 0x238F4E0 VA: 0x1823902E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2390220 Offset: 0x238F420 VA: 0x182390220 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface ISceneProvider // TypeDefIndex: 16462
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle);
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
internal interface ISceneProvider2 : ISceneProvider // TypeDefIndex: 16463
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions);
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[Extension]
internal static class SceneProviderExtensions // TypeDefIndex: 16464
{
	// Methods

	[Extension]
	// RVA: 0x2391460 Offset: 0x2390660 VA: 0x182391460
	public static AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider provider, ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("JSON Asset Provider")]
public class JsonAssetProvider : TextDataProvider // TypeDefIndex: 16465
{
	// Methods

	// RVA: 0x23884B0 Offset: 0x23876B0 VA: 0x1823884B0 Slot: 19
	public override object Convert(Type type, string text) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class LegacyResourcesProvider.InternalOp // TypeDefIndex: 16466
{
	// Fields
	private ResourceRequest m_RequestOperation; // 0x10
	private ProvideHandle m_ProvideHandle; // 0x18

	// Methods

	// RVA: 0x23876A0 Offset: 0x23868A0 VA: 0x1823876A0
	public void Start(ProvideHandle provideHandle) { }

	// RVA: 0x2388320 Offset: 0x2387520 VA: 0x182388320
	private bool WaitForCompletionHandler() { }

	// RVA: 0x2386380 Offset: 0x2385580 VA: 0x182386380
	private void AsyncOperationCompleted(AsyncOperation op) { }

	// RVA: 0x2387150 Offset: 0x2386350 VA: 0x182387150
	public float PercentComplete() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Assets from Legacy Resources")]
public class LegacyResourcesProvider : ResourceProviderBase // TypeDefIndex: 16467
{
	// Methods

	// RVA: 0x2388BB0 Offset: 0x2387DB0 VA: 0x182388BB0 Slot: 17
	public override void Provide(ProvideHandle pi) { }

	// RVA: 0x23891D0 Offset: 0x23883D0 VA: 0x1823891D0 Slot: 15
	public override void Release(IResourceLocation location, object asset) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class ResourceProviderBase.BaseInitAsyncOp : AsyncOperationBase<bool> // TypeDefIndex: 16468
{
	// Fields
	private Func<bool> m_CallBack; // 0x88

	// Methods

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	public void Init(Func<bool> callback) { }

	// RVA: 0x2380E00 Offset: 0x2380000 VA: 0x182380E00 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x2380D50 Offset: 0x237FF50 VA: 0x182380D50 Slot: 28
	protected override void Execute() { }

	// RVA: 0x2380E70 Offset: 0x2380070 VA: 0x182380E70
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ResourceProviderBase.<>c__DisplayClass10_0 // TypeDefIndex: 16469
{
	// Fields
	public ResourceProviderBase <>4__this; // 0x10
	public string id; // 0x18
	public string data; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2392180 Offset: 0x2391380 VA: 0x182392180
	internal bool <InitializeAsync>b__0() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public abstract class ResourceProviderBase : IResourceProvider, IInitializableObject // TypeDefIndex: 16470
{
	// Fields
	protected string m_ProviderId; // 0x10
	protected ProviderBehaviourFlags m_BehaviourFlags; // 0x18

	// Properties
	public virtual string ProviderId { get; }
	private ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.BehaviourFlags { get; }

	// Methods

	// RVA: 0x2390160 Offset: 0x238F360 VA: 0x182390160 Slot: 12
	public virtual string get_ProviderId() { }

	// RVA: 0x2390140 Offset: 0x238F340 VA: 0x182390140 Slot: 13
	public virtual bool Initialize(string id, string data) { }

	// RVA: 0x238FF00 Offset: 0x238F100 VA: 0x18238FF00 Slot: 14
	public virtual bool CanProvide(Type t, IResourceLocation location) { }

	// RVA: 0x7F66E0 Offset: 0x7F58E0 VA: 0x1807F66E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public virtual void Release(IResourceLocation location, object obj) { }

	// RVA: 0x238FF50 Offset: 0x238F150 VA: 0x18238FF50 Slot: 16
	public virtual Type GetDefaultType(IResourceLocation location) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Provide(ProvideHandle provideHandle);

	// RVA: 0x238FFB0 Offset: 0x238F1B0 VA: 0x18238FFB0 Slot: 18
	public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 9
	private ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.get_BehaviourFlags() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[Serializable]
public class ProviderLoadRequestOptions // TypeDefIndex: 16471
{
	// Fields
	[SerializeField]
	private bool m_IgnoreFailures; // 0x10
	private int m_WebRequestTimeout; // 0x14

	// Properties
	public bool IgnoreFailures { get; set; }
	public int WebRequestTimeout { get; set; }

	// Methods

	// RVA: 0x238A760 Offset: 0x2389960 VA: 0x18238A760
	public ProviderLoadRequestOptions Copy() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IgnoreFailures() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_IgnoreFailures(bool value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_WebRequestTimeout() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_WebRequestTimeout(int value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class SceneProvider.SceneOp : AsyncOperationBase<SceneInstance>, IUpdateReceiver // TypeDefIndex: 16472
{
	// Fields
	private bool m_ActivateOnLoad; // 0x90
	private SceneInstance m_Inst; // 0x98
	private IResourceLocation m_Location; // 0xA8
	private LoadSceneParameters m_LoadSceneParameters; // 0xB0
	private int m_Priority; // 0xB8
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xC0
	private ResourceManager m_ResourceManager; // 0xE0

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x2391250 Offset: 0x2390450 VA: 0x182391250
	public void .ctor(ResourceManager rm) { }

	// RVA: 0x2390A90 Offset: 0x238FC90 VA: 0x182390A90 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x2390B80 Offset: 0x238FD80 VA: 0x182390B80
	public void Init(IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }

	// RVA: 0x2390C70 Offset: 0x238FE70 VA: 0x182390C70
	public void Init(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }

	// RVA: 0x2390F00 Offset: 0x2390100 VA: 0x182390F00 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x2390960 Offset: 0x238FB60 VA: 0x182390960 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x23912A0 Offset: 0x23904A0 VA: 0x1823912A0 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x2390380 Offset: 0x238F580 VA: 0x182390380 Slot: 28
	protected override void Execute() { }

	// RVA: 0x2390D40 Offset: 0x238FF40 VA: 0x182390D40
	internal SceneInstance InternalLoadScene(IResourceLocation location, bool loadingFromBundle, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	// RVA: 0x2390EA0 Offset: 0x23900A0 VA: 0x182390EA0
	private AsyncOperation InternalLoad(string path, bool loadingFromBundle, LoadSceneParameters loadSceneParameters) { }

	// RVA: 0x2390300 Offset: 0x238F500 VA: 0x182390300 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x23913A0 Offset: 0x23905A0 VA: 0x1823913A0 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x2391170 Offset: 0x2390370 VA: 0x182391170 Slot: 36
	private void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }
}

// Namespace: 
private class SceneProvider.UnloadSceneOp : AsyncOperationBase<SceneInstance> // TypeDefIndex: 16473
{
	// Fields
	private SceneInstance m_Instance; // 0x90
	private AsyncOperationHandle<SceneInstance> m_sceneLoadHandle; // 0xA0
	private UnloadSceneOptions m_UnloadOptions; // 0xC0

	// Properties
	protected override float Progress { get; }

	// Methods

	// RVA: 0x2392F70 Offset: 0x2392170 VA: 0x182392F70
	public void Init(AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions options) { }

	// RVA: 0x2392D60 Offset: 0x2391F60 VA: 0x182392D60 Slot: 28
	protected override void Execute() { }

	// RVA: 0x2393020 Offset: 0x2392220 VA: 0x182393020 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x2393140 Offset: 0x2392340 VA: 0x182393140
	private void UnloadSceneCompleted(AsyncOperation obj) { }

	// RVA: 0x23930D0 Offset: 0x23922D0 VA: 0x1823930D0
	private void UnloadSceneCompletedNoRelease(AsyncOperation obj) { }

	// RVA: 0x2393230 Offset: 0x2392430 VA: 0x182393230 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x23931F0 Offset: 0x23923F0 VA: 0x1823931F0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class SceneProvider : ISceneProvider2, ISceneProvider // TypeDefIndex: 16474
{
	// Methods

	// RVA: 0x23916C0 Offset: 0x23908C0 VA: 0x1823916C0 Slot: 5
	public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority) { }

	// RVA: 0x2391770 Offset: 0x2390970 VA: 0x182391770 Slot: 6
	public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	// RVA: 0x2391A90 Offset: 0x2390C90 VA: 0x182391A90 Slot: 7
	public AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	// RVA: 0x2391BA0 Offset: 0x2390DA0 VA: 0x182391BA0 Slot: 4
	private AsyncOperationHandle<SceneInstance> UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider2.ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class TextDataProvider.InternalOp // TypeDefIndex: 16475
{
	// Fields
	private TextDataProvider m_Provider; // 0x10
	private UnityWebRequestAsyncOperation m_RequestOperation; // 0x18
	private WebRequestQueueOperation m_RequestQueueOperation; // 0x20
	private ProvideHandle m_PI; // 0x28
	private bool m_IgnoreFailures; // 0x40
	private bool m_Complete; // 0x41
	private int m_Timeout; // 0x44

	// Methods

	// RVA: 0x2387130 Offset: 0x2386330 VA: 0x182387130
	private float GetPercentComplete() { }

	// RVA: 0x2387D50 Offset: 0x2386F50 VA: 0x182387D50
	public void Start(ProvideHandle provideHandle, TextDataProvider rawProvider) { }

	// RVA: 0x2388440 Offset: 0x2387640 VA: 0x182388440
	private bool WaitForCompletionHandler() { }

	// RVA: 0x2387190 Offset: 0x2386390 VA: 0x182387190
	private void RequestOperation_completed(AsyncOperation op) { }

	// RVA: 0x2386CE0 Offset: 0x2385EE0 VA: 0x182386CE0
	protected void CompleteOperation(string text, Exception exception) { }

	// RVA: 0x2386D80 Offset: 0x2385F80 VA: 0x182386D80
	private object ConvertText(string text) { }

	// RVA: 0x2387400 Offset: 0x2386600 VA: 0x182387400 Slot: 4
	protected virtual void SendWebRequest(string path) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2388190 Offset: 0x2387390 VA: 0x182388190
	private void <SendWebRequest>b__13_0(UnityWebRequestAsyncOperation asyncOperation) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Text Data Provider")]
public class TextDataProvider : ResourceProviderBase // TypeDefIndex: 16476
{
	// Fields
	[CompilerGenerated]
	private bool <IgnoreFailures>k__BackingField; // 0x20

	// Properties
	public bool IgnoreFailures { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IgnoreFailures() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_IgnoreFailures(bool value) { }

	// RVA: 0x1721760 Offset: 0x1720960 VA: 0x181721760 Slot: 19
	public virtual object Convert(Type type, string text) { }

	// RVA: 0x2392070 Offset: 0x2391270 VA: 0x182392070 Slot: 17
	public override void Provide(ProvideHandle provideHandle) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceLocations
public interface ILocationSizeData // TypeDefIndex: 16477
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long ComputeSize(IResourceLocation location, ResourceManager resourceManager);
}

// Namespace: UnityEngine.ResourceManagement.ResourceLocations
public interface IResourceLocation // TypeDefIndex: 16478
{
	// Properties
	public abstract string InternalId { get; }
	public abstract string ProviderId { get; }
	public abstract IList<IResourceLocation> Dependencies { get; }
	public abstract int DependencyHashCode { get; }
	public abstract bool HasDependencies { get; }
	public abstract object Data { get; }
	public abstract string PrimaryKey { get; }
	public abstract Type ResourceType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_InternalId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ProviderId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IList<IResourceLocation> get_Dependencies();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int Hash(Type resultType);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_DependencyHashCode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_HasDependencies();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object get_Data();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_PrimaryKey();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Type get_ResourceType();
}

// Namespace: UnityEngine.ResourceManagement.ResourceLocations
public class ResourceLocationBase : IResourceLocation // TypeDefIndex: 16479
{
	// Fields
	private string m_Name; // 0x10
	private string m_Id; // 0x18
	private string m_ProviderId; // 0x20
	private object m_Data; // 0x28
	private int m_DependencyHashCode; // 0x30
	private int m_HashCode; // 0x34
	private Type m_Type; // 0x38
	private List<IResourceLocation> m_Dependencies; // 0x40
	private string m_PrimaryKey; // 0x48

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public bool HasDependencies { get; }
	public object Data { get; set; }
	public string PrimaryKey { get; set; }
	public int DependencyHashCode { get; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public string get_InternalId() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x238AF90 Offset: 0x238A190 VA: 0x18238AF90 Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 10
	public object get_Data() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Data(object value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_PrimaryKey(string value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x238ACF0 Offset: 0x2389EF0 VA: 0x18238ACF0 Slot: 7
	public int Hash(Type t) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x238AD40 Offset: 0x2389F40 VA: 0x18238AD40
	public void .ctor(string name, string id, string providerId, Type t, IResourceLocation[] dependencies) { }

	// RVA: 0x238AAC0 Offset: 0x2389CC0 VA: 0x18238AAC0
	public void ComputeDependencyHash() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceLocations
internal class LocationWrapper : IResourceLocation // TypeDefIndex: 16480
{
	// Fields
	private IResourceLocation m_InternalLocation; // 0x10

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public int DependencyHashCode { get; }
	public bool HasDependencies { get; }
	public object Data { get; }
	public string PrimaryKey { get; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IResourceLocation location) { }

	// RVA: 0x2389A60 Offset: 0x2388C60 VA: 0x182389A60 Slot: 4
	public string get_InternalId() { }

	// RVA: 0x2389B00 Offset: 0x2388D00 VA: 0x182389B00 Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x2389970 Offset: 0x2388B70 VA: 0x182389970 Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x23899C0 Offset: 0x2388BC0 VA: 0x1823899C0 Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x2389A10 Offset: 0x2388C10 VA: 0x182389A10 Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x2389920 Offset: 0x2388B20 VA: 0x182389920 Slot: 10
	public object get_Data() { }

	// RVA: 0x2389AB0 Offset: 0x2388CB0 VA: 0x182389AB0 Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x2389B50 Offset: 0x2388D50 VA: 0x182389B50 Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x23898C0 Offset: 0x2388AC0 VA: 0x1823898C0 Slot: 7
	public int Hash(Type resultType) { }
}

// Namespace: UnityEngine.ResourceManagement.Diagnostics
[Serializable]
public struct DiagnosticEvent // TypeDefIndex: 16481
{
	// Fields
	[SerializeField]
	private string m_Graph; // 0x0
	[SerializeField]
	private int[] m_Dependencies; // 0x8
	[SerializeField]
	private int m_ObjectId; // 0x10
	[SerializeField]
	private string m_DisplayName; // 0x18
	[SerializeField]
	private int m_Stream; // 0x20
	[SerializeField]
	private int m_Frame; // 0x24
	[SerializeField]
	private int m_Value; // 0x28

	// Properties
	public string Graph { get; }
	public int ObjectId { get; }
	public string DisplayName { get; }
	public int[] Dependencies { get; }
	public int Stream { get; }
	public int Frame { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public string get_Graph() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_ObjectId() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_DisplayName() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public int[] get_Dependencies() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_Stream() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_Frame() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_Value() { }

	// RVA: 0x23835F0 Offset: 0x23827F0 VA: 0x1823835F0
	public void .ctor(string graph, string name, int id, int stream, int frame, int value, int[] deps) { }

	// RVA: 0x2383550 Offset: 0x2382750 VA: 0x182383550
	internal byte[] Serialize() { }

	// RVA: 0x23834B0 Offset: 0x23826B0 VA: 0x1823834B0
	public static DiagnosticEvent Deserialize(byte[] data) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DiagnosticEventCollectorSingleton.<>c // TypeDefIndex: 16482
{
	// Fields
	public static readonly DiagnosticEventCollectorSingleton.<>c <>9; // 0x0
	public static Func<DiagnosticEvent, int> <>9__8_0; // 0x8
	public static Action<DiagnosticEvent> <>9__11_0; // 0x10

	// Methods

	// RVA: 0x2392270 Offset: 0x2391470 VA: 0x182392270
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2392170 Offset: 0x2391370 VA: 0x182392170
	internal int <RegisterEventHandler>b__8_0(DiagnosticEvent evt) { }

	// RVA: 0x2392100 Offset: 0x2391300 VA: 0x182392100
	internal void <Awake>b__11_0(DiagnosticEvent diagnosticEvent) { }
}

// Namespace: UnityEngine.ResourceManagement.Diagnostics
public class DiagnosticEventCollectorSingleton : ComponentSingleton<DiagnosticEventCollectorSingleton> // TypeDefIndex: 16483
{
	// Fields
	private static Guid s_editorConnectionGuid; // 0x0
	internal Dictionary<int, DiagnosticEvent> m_CreatedEvents; // 0x20
	internal List<DiagnosticEvent> m_UnhandledEvents; // 0x28
	internal DelegateList<DiagnosticEvent> s_EventHandlers; // 0x30
	private float m_lastTickSent; // 0x38
	private int m_lastFrame; // 0x3C
	private float fpsAvg; // 0x40

	// Properties
	public static Guid PlayerConnectionGuid { get; }

	// Methods

	// RVA: 0x2382FB0 Offset: 0x23821B0 VA: 0x182382FB0
	public static Guid get_PlayerConnectionGuid() { }

	// RVA: 0x23824B0 Offset: 0x23816B0 VA: 0x1823824B0 Slot: 4
	protected override string GetGameObjectName() { }

	// RVA: 0x23826E0 Offset: 0x23818E0 VA: 0x1823826E0
	public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create) { }

	// RVA: 0x2382840 Offset: 0x2381A40 VA: 0x182382840
	internal void RegisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x2382C10 Offset: 0x2381E10 VA: 0x182382C10
	public void UnregisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x23824E0 Offset: 0x23816E0 VA: 0x1823824E0
	public void PostEvent(DiagnosticEvent diagnosticEvent) { }

	// RVA: 0x23823C0 Offset: 0x23815C0 VA: 0x1823823C0
	private void Awake() { }

	// RVA: 0x2382CC0 Offset: 0x2381EC0 VA: 0x182382CC0
	private void Update() { }

	// RVA: 0x2382ED0 Offset: 0x23820D0 VA: 0x182382ED0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Diagnostics
public class DiagnosticEventCollector : MonoBehaviour // TypeDefIndex: 16484
{
	// Fields
	private static DiagnosticEventCollector s_Collector; // 0x0

	// Properties
	public static Guid PlayerConnectionGuid { get; }

	// Methods

	// RVA: 0x23833D0 Offset: 0x23825D0 VA: 0x1823833D0
	public static Guid get_PlayerConnectionGuid() { }

	// RVA: 0x23830D0 Offset: 0x23822D0 VA: 0x1823830D0
	public static DiagnosticEventCollector FindOrCreateGlobalInstance() { }

	// RVA: 0x23826E0 Offset: 0x23818E0 VA: 0x1823826E0
	public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create) { }

	// RVA: 0x2383300 Offset: 0x2382500 VA: 0x182383300
	public void UnregisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x2383290 Offset: 0x2382490 VA: 0x182383290
	public void PostEvent(DiagnosticEvent diagnosticEvent) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal interface ICachable // TypeDefIndex: 16485
{
	// Properties
	public abstract IOperationCacheKey Key { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IOperationCacheKey get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Key(IOperationCacheKey value);
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal interface IAsyncOperation // TypeDefIndex: 16486
{
	// Properties
	public abstract Type ResultType { get; }
	public abstract int Version { get; }
	public abstract string DebugName { get; }
	public abstract int ReferenceCount { get; }
	public abstract float PercentComplete { get; }
	public abstract AsyncOperationStatus Status { get; }
	public abstract Exception OperationException { get; }
	public abstract bool IsDone { get; }
	public abstract Action<IAsyncOperation> OnDestroy { set; }
	public abstract bool IsRunning { get; }
	public abstract Task<object> Task { get; }
	public abstract AsyncOperationHandle Handle { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetResultAsObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type get_ResultType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Version();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_DebugName();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DecrementReferenceCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void IncrementReferenceCount();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_ReferenceCount();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_PercentComplete();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DownloadStatus GetDownloadStatus(HashSet<object> visited);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract AsyncOperationStatus get_Status();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Exception get_OperationException();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsDone();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_OnDestroy(Action<IAsyncOperation> value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void GetDependencies(List<AsyncOperationHandle> deps);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsRunning();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public abstract void add_CompletedTypeless(Action<AsyncOperationHandle> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public abstract void remove_CompletedTypeless(Action<AsyncOperationHandle> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public abstract void add_Destroyed(Action<AsyncOperationHandle> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public abstract void remove_Destroyed(Action<AsyncOperationHandle> value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void InvokeCompletionEvent();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Task<object> get_Task();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract AsyncOperationHandle get_Handle();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void WaitForCompletion();
}

// Namespace: 
[CompilerGenerated]
private sealed class AsyncOperationBase.<>c__DisplayClass57_0<TObject> // TypeDefIndex: 16487
{
	// Fields
	public Action<AsyncOperationHandle> value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AsyncOperationBase.<>c__DisplayClass57_0<bool>..ctor
	|-AsyncOperationBase.<>c__DisplayClass57_0<long>..ctor
	|-AsyncOperationBase.<>c__DisplayClass57_0<object>..ctor
	|-AsyncOperationBase.<>c__DisplayClass57_0<SceneInstance>..ctor
	|-AsyncOperationBase.<>c__DisplayClass57_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <add_CompletedTypeless>b__0(AsyncOperationHandle<TObject> s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0EF90 Offset: 0xB0E190 VA: 0x180B0EF90
	|-AsyncOperationBase.<>c__DisplayClass57_0<bool>.<add_CompletedTypeless>b__0
	|-AsyncOperationBase.<>c__DisplayClass57_0<long>.<add_CompletedTypeless>b__0
	|-AsyncOperationBase.<>c__DisplayClass57_0<object>.<add_CompletedTypeless>b__0
	|-AsyncOperationBase.<>c__DisplayClass57_0<SceneInstance>.<add_CompletedTypeless>b__0
	|
	|-RVA: 0xB0F010 Offset: 0xB0E210 VA: 0x180B0F010
	|-AsyncOperationBase.<>c__DisplayClass57_0<__Il2CppFullySharedGenericType>.<add_CompletedTypeless>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AsyncOperationBase.<>c__DisplayClass58_0<TObject> // TypeDefIndex: 16488
{
	// Fields
	public Action<AsyncOperationHandle> value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AsyncOperationBase.<>c__DisplayClass58_0<bool>..ctor
	|-AsyncOperationBase.<>c__DisplayClass58_0<long>..ctor
	|-AsyncOperationBase.<>c__DisplayClass58_0<object>..ctor
	|-AsyncOperationBase.<>c__DisplayClass58_0<SceneInstance>..ctor
	|-AsyncOperationBase.<>c__DisplayClass58_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <remove_CompletedTypeless>b__0(AsyncOperationHandle<TObject> s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0EF90 Offset: 0xB0E190 VA: 0x180B0EF90
	|-AsyncOperationBase.<>c__DisplayClass58_0<bool>.<remove_CompletedTypeless>b__0
	|-AsyncOperationBase.<>c__DisplayClass58_0<long>.<remove_CompletedTypeless>b__0
	|-AsyncOperationBase.<>c__DisplayClass58_0<object>.<remove_CompletedTypeless>b__0
	|-AsyncOperationBase.<>c__DisplayClass58_0<SceneInstance>.<remove_CompletedTypeless>b__0
	|
	|-RVA: 0xB0F010 Offset: 0xB0E210 VA: 0x180B0F010
	|-AsyncOperationBase.<>c__DisplayClass58_0<__Il2CppFullySharedGenericType>.<remove_CompletedTypeless>b__0
	*/
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public abstract class AsyncOperationBase<TObject> : IAsyncOperation // TypeDefIndex: 16489
{
	// Fields
	[CompilerGenerated]
	private TObject <Result>k__BackingField; // 0x0
	private int m_referenceCount; // 0x0
	private AsyncOperationStatus m_Status; // 0x0
	private Exception m_Error; // 0x0
	internal ResourceManager m_RM; // 0x0
	internal int m_Version; // 0x0
	private DelegateList<AsyncOperationHandle> m_DestroyedAction; // 0x0
	private DelegateList<AsyncOperationHandle<TObject>> m_CompletedActionT; // 0x0
	private Action<IAsyncOperation> m_OnDestroyAction; // 0x0
	private Action<AsyncOperationHandle> m_dependencyCompleteAction; // 0x0
	protected internal bool HasExecuted; // 0x0
	[CompilerGenerated]
	private bool <IsRunning>k__BackingField; // 0x0
	private TaskCompletionSource<TObject> m_taskCompletionSource; // 0x0
	private TaskCompletionSource<object> m_taskCompletionSourceTypeless; // 0x0
	private bool m_InDeferredCallbackQueue; // 0x0
	private DelegateList<float> m_UpdateCallbacks; // 0x0
	private Action<float> m_UpdateCallback; // 0x0

	// Properties
	protected virtual float Progress { get; }
	protected virtual string DebugName { get; }
	public TObject Result { get; set; }
	internal int Version { get; }
	internal bool CompletedEventHasListeners { get; }
	internal bool DestroyedEventHasListeners { get; }
	internal Action<IAsyncOperation> OnDestroy { set; }
	protected internal int ReferenceCount { get; }
	public bool IsRunning { get; set; }
	internal Task<TObject> Task { get; }
	private Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Task { get; }
	internal AsyncOperationStatus Status { get; }
	internal Exception OperationException { get; set; }
	internal object Current { get; }
	internal bool IsDone { get; }
	internal float PercentComplete { get; }
	internal AsyncOperationHandle<TObject> Handle { get; }
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Version { get; }
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ReferenceCount { get; }
	private float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.PercentComplete { get; }
	private AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Status { get; }
	private Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OperationException { get; }
	private bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IsDone { get; }
	private AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Handle { get; }
	private Action<IAsyncOperation> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OnDestroy { set; }
	private string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DebugName { get; }
	private Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ResultType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract void Execute();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected virtual void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-AsyncOperationBase<bool>.Destroy
	|-AsyncOperationBase<long>.Destroy
	|-AsyncOperationBase<object>.Destroy
	|-AsyncOperationBase<SceneInstance>.Destroy
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected virtual float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x564140 Offset: 0x563340 VA: 0x180564140
	|-AsyncOperationBase<bool>.get_Progress
	|-AsyncOperationBase<long>.get_Progress
	|-AsyncOperationBase<object>.get_Progress
	|-AsyncOperationBase<SceneInstance>.get_Progress
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected virtual string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B050 Offset: 0xE5A250 VA: 0x180E5B050
	|-AsyncOperationBase<bool>.get_DebugName
	|-AsyncOperationBase<long>.get_DebugName
	|-AsyncOperationBase<object>.get_DebugName
	|-AsyncOperationBase<SceneInstance>.get_DebugName
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public virtual void GetDependencies(List<AsyncOperationHandle> dependencies) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-AsyncOperationBase<bool>.GetDependencies
	|-AsyncOperationBase<long>.GetDependencies
	|-AsyncOperationBase<object>.GetDependencies
	|-AsyncOperationBase<SceneInstance>.GetDependencies
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public TObject get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	|-AsyncOperationBase<bool>.get_Result
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-AsyncOperationBase<long>.get_Result
	|-AsyncOperationBase<object>.get_Result
	|
	|-RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	|-AsyncOperationBase<SceneInstance>.get_Result
	|
	|-RVA: 0xB16E40 Offset: 0xB16040 VA: 0x180B16E40
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Result
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Result(TObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	|-AsyncOperationBase<bool>.set_Result
	|
	|-RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	|-AsyncOperationBase<long>.set_Result
	|-AsyncOperationBase<object>.set_Result
	|
	|-RVA: 0x4829A0 Offset: 0x481BA0 VA: 0x1804829A0
	|-AsyncOperationBase<SceneInstance>.set_Result
	|
	|-RVA: 0xCDEA80 Offset: 0xCDDC80 VA: 0x180CDEA80
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_Result
	*/

	// RVA: -1 Offset: -1
	internal int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	|-AsyncOperationBase<bool>.get_Version
	|-AsyncOperationBase<long>.get_Version
	|-AsyncOperationBase<object>.get_Version
	|
	|-RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	|-AsyncOperationBase<SceneInstance>.get_Version
	|
	|-RVA: 0xE7E740 Offset: 0xE7D940 VA: 0x180E7E740
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Version
	*/

	// RVA: -1 Offset: -1
	internal bool get_CompletedEventHasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B010 Offset: 0xE5A210 VA: 0x180E5B010
	|-AsyncOperationBase<bool>.get_CompletedEventHasListeners
	|-AsyncOperationBase<long>.get_CompletedEventHasListeners
	|-AsyncOperationBase<object>.get_CompletedEventHasListeners
	|
	|-RVA: 0xE5AFD0 Offset: 0xE5A1D0 VA: 0x180E5AFD0
	|-AsyncOperationBase<SceneInstance>.get_CompletedEventHasListeners
	|
	|-RVA: 0xE7E1A0 Offset: 0xE7D3A0 VA: 0x180E7E1A0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_CompletedEventHasListeners
	*/

	// RVA: -1 Offset: -1
	internal bool get_DestroyedEventHasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B080 Offset: 0xE5A280 VA: 0x180E5B080
	|-AsyncOperationBase<bool>.get_DestroyedEventHasListeners
	|
	|-RVA: 0xE5B120 Offset: 0xE5A320 VA: 0x180E5B120
	|-AsyncOperationBase<long>.get_DestroyedEventHasListeners
	|
	|-RVA: 0xE5B170 Offset: 0xE5A370 VA: 0x180E5B170
	|-AsyncOperationBase<object>.get_DestroyedEventHasListeners
	|
	|-RVA: 0xE5B0D0 Offset: 0xE5A2D0 VA: 0x180E5B0D0
	|-AsyncOperationBase<SceneInstance>.get_DestroyedEventHasListeners
	|
	|-RVA: 0xE7E240 Offset: 0xE7D440 VA: 0x180E7E240
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_DestroyedEventHasListeners
	*/

	// RVA: -1 Offset: -1
	internal void set_OnDestroy(Action<IAsyncOperation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	|-AsyncOperationBase<bool>.set_OnDestroy
	|-AsyncOperationBase<long>.set_OnDestroy
	|-AsyncOperationBase<object>.set_OnDestroy
	|
	|-RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	|-AsyncOperationBase<SceneInstance>.set_OnDestroy
	|
	|-RVA: 0xCF5C30 Offset: 0xCF4E30 VA: 0x180CF5C30
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_OnDestroy
	*/

	// RVA: -1 Offset: -1
	protected internal int get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	|-AsyncOperationBase<bool>.get_ReferenceCount
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-AsyncOperationBase<long>.get_ReferenceCount
	|-AsyncOperationBase<object>.get_ReferenceCount
	|
	|-RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	|-AsyncOperationBase<SceneInstance>.get_ReferenceCount
	|
	|-RVA: 0xB25410 Offset: 0xB24610 VA: 0x180B25410
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_ReferenceCount
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public bool get_IsRunning() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7725E0 Offset: 0x7717E0 VA: 0x1807725E0
	|-AsyncOperationBase<bool>.get_IsRunning
	|-AsyncOperationBase<long>.get_IsRunning
	|-AsyncOperationBase<object>.get_IsRunning
	|
	|-RVA: 0xE5B220 Offset: 0xE5A420 VA: 0x180E5B220
	|-AsyncOperationBase<SceneInstance>.get_IsRunning
	|
	|-RVA: 0xE7E420 Offset: 0xE7D620 VA: 0x180E7E420
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_IsRunning
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_IsRunning(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B9A0 Offset: 0xE5ABA0 VA: 0x180E5B9A0
	|-AsyncOperationBase<bool>.set_IsRunning
	|-AsyncOperationBase<long>.set_IsRunning
	|-AsyncOperationBase<object>.set_IsRunning
	|
	|-RVA: 0xE5B990 Offset: 0xE5AB90 VA: 0x180E5B990
	|-AsyncOperationBase<SceneInstance>.set_IsRunning
	|
	|-RVA: 0xE7E950 Offset: 0xE7DB50 VA: 0x180E7E950
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_IsRunning
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5A800 Offset: 0xE59A00 VA: 0x180E5A800
	|-AsyncOperationBase<bool>..ctor
	|
	|-RVA: 0xE5A660 Offset: 0xE59860 VA: 0x180E5A660
	|-AsyncOperationBase<long>..ctor
	|
	|-RVA: 0xE5A8D0 Offset: 0xE59AD0 VA: 0x180E5A8D0
	|-AsyncOperationBase<object>..ctor
	|
	|-RVA: 0xE5A730 Offset: 0xE59930 VA: 0x180E5A730
	|-AsyncOperationBase<SceneInstance>..ctor
	|
	|-RVA: 0xE7DCF0 Offset: 0xE7CEF0 VA: 0x180E7DCF0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static string ShortenPath(string p, bool keepExtension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE57020 Offset: 0xE56220 VA: 0x180E57020
	|-AsyncOperationBase<bool>.ShortenPath
	|-AsyncOperationBase<long>.ShortenPath
	|-AsyncOperationBase<object>.ShortenPath
	|-AsyncOperationBase<SceneInstance>.ShortenPath
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.ShortenPath
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5A120 Offset: 0xE59320 VA: 0x180E5A120
	|-AsyncOperationBase<bool>.WaitForCompletion
	|
	|-RVA: 0xE5A510 Offset: 0xE59710 VA: 0x180E5A510
	|-AsyncOperationBase<long>.WaitForCompletion
	|
	|-RVA: 0xE5A3C0 Offset: 0xE595C0 VA: 0x180E5A3C0
	|-AsyncOperationBase<object>.WaitForCompletion
	|
	|-RVA: 0xE5A270 Offset: 0xE59470 VA: 0x180E5A270
	|-AsyncOperationBase<SceneInstance>.WaitForCompletion
	|
	|-RVA: 0xE7DBA0 Offset: 0xE7CDA0 VA: 0x180E7DBA0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected virtual bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-AsyncOperationBase<bool>.InvokeWaitForCompletion
	|-AsyncOperationBase<long>.InvokeWaitForCompletion
	|-AsyncOperationBase<object>.InvokeWaitForCompletion
	|-AsyncOperationBase<SceneInstance>.InvokeWaitForCompletion
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1
	protected internal void IncrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE565E0 Offset: 0xE557E0 VA: 0x180E565E0
	|-AsyncOperationBase<bool>.IncrementReferenceCount
	|
	|-RVA: 0xE562C0 Offset: 0xE554C0 VA: 0x180E562C0
	|-AsyncOperationBase<long>.IncrementReferenceCount
	|-AsyncOperationBase<object>.IncrementReferenceCount
	|
	|-RVA: 0xE56450 Offset: 0xE55650 VA: 0x180E56450
	|-AsyncOperationBase<SceneInstance>.IncrementReferenceCount
	|
	|-RVA: 0xE7C610 Offset: 0xE7B810 VA: 0x180E7C610
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.IncrementReferenceCount
	*/

	// RVA: -1 Offset: -1
	protected internal void DecrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE55630 Offset: 0xE54830 VA: 0x180E55630
	|-AsyncOperationBase<bool>.DecrementReferenceCount
	|
	|-RVA: 0xE559A0 Offset: 0xE54BA0 VA: 0x180E559A0
	|-AsyncOperationBase<long>.DecrementReferenceCount
	|
	|-RVA: 0xE552C0 Offset: 0xE544C0 VA: 0x180E552C0
	|-AsyncOperationBase<object>.DecrementReferenceCount
	|
	|-RVA: 0xE55D10 Offset: 0xE54F10 VA: 0x180E55D10
	|-AsyncOperationBase<SceneInstance>.DecrementReferenceCount
	|
	|-RVA: 0xE7BCB0 Offset: 0xE7AEB0 VA: 0x180E7BCB0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.DecrementReferenceCount
	*/

	// RVA: -1 Offset: -1
	internal Task<TObject> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B4F0 Offset: 0xE5A6F0 VA: 0x180E5B4F0
	|-AsyncOperationBase<bool>.get_Task
	|
	|-RVA: 0xE5B3F0 Offset: 0xE5A5F0 VA: 0x180E5B3F0
	|-AsyncOperationBase<long>.get_Task
	|
	|-RVA: 0xE5B5F0 Offset: 0xE5A7F0 VA: 0x180E5B5F0
	|-AsyncOperationBase<object>.get_Task
	|
	|-RVA: 0xE5B2F0 Offset: 0xE5A4F0 VA: 0x180E5B2F0
	|-AsyncOperationBase<SceneInstance>.get_Task
	|
	|-RVA: 0xE7E4E0 Offset: 0xE7D6E0 VA: 0x180E7E4E0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE596E0 Offset: 0xE588E0 VA: 0x180E596E0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0xE59810 Offset: 0xE58A10 VA: 0x180E59810
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0xE59A70 Offset: 0xE58C70 VA: 0x180E59A70
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0xE59940 Offset: 0xE58B40 VA: 0x180E59940
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0xE7D800 Offset: 0xE7CA00 VA: 0x180E7D800
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE57D20 Offset: 0xE56F20 VA: 0x180E57D20
	|-AsyncOperationBase<bool>.ToString
	|
	|-RVA: 0xE57960 Offset: 0xE56B60 VA: 0x180E57960
	|-AsyncOperationBase<long>.ToString
	|
	|-RVA: 0xE57F00 Offset: 0xE57100 VA: 0x180E57F00
	|-AsyncOperationBase<object>.ToString
	|
	|-RVA: 0xE57B40 Offset: 0xE56D40 VA: 0x180E57B40
	|-AsyncOperationBase<SceneInstance>.ToString
	|
	|-RVA: 0xE7D270 Offset: 0xE7C470 VA: 0x180E7D270
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	private void RegisterForDeferredCallbackEvent(bool incrementReferenceCount = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE56F30 Offset: 0xE56130 VA: 0x180E56F30
	|-AsyncOperationBase<bool>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0xE56F80 Offset: 0xE56180 VA: 0x180E56F80
	|-AsyncOperationBase<long>.RegisterForDeferredCallbackEvent
	|-AsyncOperationBase<object>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0xE56FD0 Offset: 0xE561D0 VA: 0x180E56FD0
	|-AsyncOperationBase<SceneInstance>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0xE7CDC0 Offset: 0xE7BFC0 VA: 0x180E7CDC0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.RegisterForDeferredCallbackEvent
	*/

	// RVA: -1 Offset: -1
	internal void add_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5AE90 Offset: 0xE5A090 VA: 0x180E5AE90
	|-AsyncOperationBase<bool>.add_Completed
	|
	|-RVA: 0xE5ADF0 Offset: 0xE59FF0 VA: 0x180E5ADF0
	|-AsyncOperationBase<long>.add_Completed
	|-AsyncOperationBase<object>.add_Completed
	|
	|-RVA: 0xE5AF30 Offset: 0xE5A130 VA: 0x180E5AF30
	|-AsyncOperationBase<SceneInstance>.add_Completed
	|
	|-RVA: 0xE7DF50 Offset: 0xE7D150 VA: 0x180E7DF50
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_Completed
	*/

	// RVA: -1 Offset: -1
	internal void remove_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B960 Offset: 0xE5AB60 VA: 0x180E5B960
	|-AsyncOperationBase<bool>.remove_Completed
	|-AsyncOperationBase<long>.remove_Completed
	|-AsyncOperationBase<object>.remove_Completed
	|
	|-RVA: 0xE5B930 Offset: 0xE5AB30 VA: 0x180E5B930
	|-AsyncOperationBase<SceneInstance>.remove_Completed
	|
	|-RVA: 0xE7E870 Offset: 0xE7DA70 VA: 0x180E7E870
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_Completed
	*/

	// RVA: -1 Offset: -1
	internal void add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE592E0 Offset: 0xE584E0 VA: 0x180E592E0
	|-AsyncOperationBase<bool>.add_Destroyed
	|
	|-RVA: 0xE591E0 Offset: 0xE583E0 VA: 0x180E591E0
	|-AsyncOperationBase<long>.add_Destroyed
	|
	|-RVA: 0xE59160 Offset: 0xE58360 VA: 0x180E59160
	|-AsyncOperationBase<object>.add_Destroyed
	|
	|-RVA: 0xE59260 Offset: 0xE58460 VA: 0x180E59260
	|-AsyncOperationBase<SceneInstance>.add_Destroyed
	|
	|-RVA: 0xE7E080 Offset: 0xE7D280 VA: 0x180E7E080
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_Destroyed
	*/

	// RVA: -1 Offset: -1
	internal void remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE59ED0 Offset: 0xE590D0 VA: 0x180E59ED0
	|-AsyncOperationBase<bool>.remove_Destroyed
	|
	|-RVA: 0xE59E30 Offset: 0xE59030 VA: 0x180E59E30
	|-AsyncOperationBase<long>.remove_Destroyed
	|
	|-RVA: 0xE59DE0 Offset: 0xE58FE0 VA: 0x180E59DE0
	|-AsyncOperationBase<object>.remove_Destroyed
	|
	|-RVA: 0xE59E80 Offset: 0xE59080 VA: 0x180E59E80
	|-AsyncOperationBase<SceneInstance>.remove_Destroyed
	|
	|-RVA: 0xE7E8D0 Offset: 0xE7DAD0 VA: 0x180E7E8D0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_Destroyed
	*/

	// RVA: -1 Offset: -1
	internal void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5AB10 Offset: 0xE59D10 VA: 0x180E5AB10
	|-AsyncOperationBase<bool>.add_CompletedTypeless
	|
	|-RVA: 0xE5A9A0 Offset: 0xE59BA0 VA: 0x180E5A9A0
	|-AsyncOperationBase<long>.add_CompletedTypeless
	|-AsyncOperationBase<object>.add_CompletedTypeless
	|
	|-RVA: 0xE5AC80 Offset: 0xE59E80 VA: 0x180E5AC80
	|-AsyncOperationBase<SceneInstance>.add_CompletedTypeless
	|
	|-RVA: 0xE7DE50 Offset: 0xE7D050 VA: 0x180E7DE50
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	internal void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B6F0 Offset: 0xE5A8F0 VA: 0x180E5B6F0
	|-AsyncOperationBase<bool>.remove_CompletedTypeless
	|-AsyncOperationBase<long>.remove_CompletedTypeless
	|-AsyncOperationBase<object>.remove_CompletedTypeless
	|
	|-RVA: 0xE5B810 Offset: 0xE5AA10 VA: 0x180E5B810
	|-AsyncOperationBase<SceneInstance>.remove_CompletedTypeless
	|
	|-RVA: 0xE7E770 Offset: 0xE7D970 VA: 0x180E7E770
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-AsyncOperationBase<bool>.get_Status
	|
	|-RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	|-AsyncOperationBase<long>.get_Status
	|-AsyncOperationBase<object>.get_Status
	|
	|-RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	|-AsyncOperationBase<SceneInstance>.get_Status
	|
	|-RVA: 0xE7E4B0 Offset: 0xE7D6B0 VA: 0x180E7E4B0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Status
	*/

	// RVA: -1 Offset: -1
	internal Exception get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-AsyncOperationBase<bool>.get_OperationException
	|-AsyncOperationBase<long>.get_OperationException
	|-AsyncOperationBase<object>.get_OperationException
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-AsyncOperationBase<SceneInstance>.get_OperationException
	|
	|-RVA: 0xC9A600 Offset: 0xC99800 VA: 0x180C9A600
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_OperationException
	*/

	// RVA: -1 Offset: -1
	private void set_OperationException(Exception value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B9B0 Offset: 0xE5ABB0 VA: 0x180E5B9B0
	|-AsyncOperationBase<bool>.set_OperationException
	|
	|-RVA: 0xE5BDD0 Offset: 0xE5AFD0 VA: 0x180E5BDD0
	|-AsyncOperationBase<long>.set_OperationException
	|
	|-RVA: 0xE5BC70 Offset: 0xE5AE70 VA: 0x180E5BC70
	|-AsyncOperationBase<object>.set_OperationException
	|
	|-RVA: 0xE5BB10 Offset: 0xE5AD10 VA: 0x180E5BB10
	|-AsyncOperationBase<SceneInstance>.set_OperationException
	|
	|-RVA: 0xE7E9B0 Offset: 0xE7DBB0 VA: 0x180E7E9B0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_OperationException
	*/

	// RVA: -1 Offset: -1
	internal bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE56F10 Offset: 0xE56110 VA: 0x180E56F10
	|-AsyncOperationBase<bool>.MoveNext
	|
	|-RVA: 0xE56ED0 Offset: 0xE560D0 VA: 0x180E56ED0
	|-AsyncOperationBase<long>.MoveNext
	|-AsyncOperationBase<object>.MoveNext
	|
	|-RVA: 0xE56EF0 Offset: 0xE560F0 VA: 0x180E56EF0
	|-AsyncOperationBase<SceneInstance>.MoveNext
	|
	|-RVA: 0xE7CD90 Offset: 0xE7BF90 VA: 0x180E7CD90
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-AsyncOperationBase<bool>.Reset
	|-AsyncOperationBase<long>.Reset
	|-AsyncOperationBase<object>.Reset
	|-AsyncOperationBase<SceneInstance>.Reset
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	internal object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	|-AsyncOperationBase<bool>.get_Current
	|-AsyncOperationBase<long>.get_Current
	|-AsyncOperationBase<object>.get_Current
	|-AsyncOperationBase<SceneInstance>.get_Current
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE594A0 Offset: 0xE586A0 VA: 0x180E594A0
	|-AsyncOperationBase<bool>.get_IsDone
	|
	|-RVA: 0xE594E0 Offset: 0xE586E0 VA: 0x180E594E0
	|-AsyncOperationBase<long>.get_IsDone
	|-AsyncOperationBase<object>.get_IsDone
	|
	|-RVA: 0xE594C0 Offset: 0xE586C0 VA: 0x180E594C0
	|-AsyncOperationBase<SceneInstance>.get_IsDone
	|
	|-RVA: 0xE7E3B0 Offset: 0xE7D5B0 VA: 0x180E7E3B0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_IsDone
	*/

	// RVA: -1 Offset: -1
	internal float get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B2B0 Offset: 0xE5A4B0 VA: 0x180E5B2B0
	|-AsyncOperationBase<bool>.get_PercentComplete
	|
	|-RVA: 0xE5B230 Offset: 0xE5A430 VA: 0x180E5B230
	|-AsyncOperationBase<long>.get_PercentComplete
	|-AsyncOperationBase<object>.get_PercentComplete
	|
	|-RVA: 0xE5B270 Offset: 0xE5A470 VA: 0x180E5B270
	|-AsyncOperationBase<SceneInstance>.get_PercentComplete
	|
	|-RVA: 0xE7E450 Offset: 0xE7D650 VA: 0x180E7E450
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_PercentComplete
	*/

	// RVA: -1 Offset: -1
	internal void InvokeCompletionEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE56A20 Offset: 0xE55C20 VA: 0x180E56A20
	|-AsyncOperationBase<bool>.InvokeCompletionEvent
	|
	|-RVA: 0xE568D0 Offset: 0xE55AD0 VA: 0x180E568D0
	|-AsyncOperationBase<long>.InvokeCompletionEvent
	|
	|-RVA: 0xE56B70 Offset: 0xE55D70 VA: 0x180E56B70
	|-AsyncOperationBase<object>.InvokeCompletionEvent
	|
	|-RVA: 0xE56770 Offset: 0xE55970 VA: 0x180E56770
	|-AsyncOperationBase<SceneInstance>.InvokeCompletionEvent
	|
	|-RVA: 0xE7C8A0 Offset: 0xE7BAA0 VA: 0x180E7C8A0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.InvokeCompletionEvent
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B1C0 Offset: 0xE5A3C0 VA: 0x180E5B1C0
	|-AsyncOperationBase<bool>.get_Handle
	|-AsyncOperationBase<long>.get_Handle
	|-AsyncOperationBase<object>.get_Handle
	|
	|-RVA: 0xE5B1F0 Offset: 0xE5A3F0 VA: 0x180E5B1F0
	|-AsyncOperationBase<SceneInstance>.get_Handle
	|
	|-RVA: 0xE7E300 Offset: 0xE7D500 VA: 0x180E7E300
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Handle
	*/

	// RVA: -1 Offset: -1
	private void UpdateCallback(float unscaledDeltaTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5A020 Offset: 0xE59220 VA: 0x180E5A020
	|-AsyncOperationBase<bool>.UpdateCallback
	|
	|-RVA: 0xE59F20 Offset: 0xE59120 VA: 0x180E59F20
	|-AsyncOperationBase<long>.UpdateCallback
	|
	|-RVA: 0xE59FA0 Offset: 0xE591A0 VA: 0x180E59FA0
	|-AsyncOperationBase<object>.UpdateCallback
	|
	|-RVA: 0xE5A0A0 Offset: 0xE592A0 VA: 0x180E5A0A0
	|-AsyncOperationBase<SceneInstance>.UpdateCallback
	|
	|-RVA: 0xE7DAC0 Offset: 0xE7CCC0 VA: 0x180E7DAC0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UpdateCallback
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE546D0 Offset: 0xE538D0 VA: 0x180E546D0
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0xE547B0 Offset: 0xE539B0 VA: 0x180E547B0
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0xE53840 Offset: 0xE52A40 VA: 0x180E53840
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0xE53920 Offset: 0xE52B20 VA: 0x180E53920
	|-AsyncOperationBase<SceneInstance>.Complete
	|
	|-RVA: 0xE7B140 Offset: 0xE7A340 VA: 0x180E7B140
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Complete
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE54510 Offset: 0xE53710 VA: 0x180E54510
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0xE545F0 Offset: 0xE537F0 VA: 0x180E545F0
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0xE53760 Offset: 0xE52960 VA: 0x180E53760
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0xE53F20 Offset: 0xE53120 VA: 0x180E53F20
	|-AsyncOperationBase<SceneInstance>.Complete
	|
	|-RVA: 0xE7BA70 Offset: 0xE7AC70 VA: 0x180E7BA70
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Complete
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE53A10 Offset: 0xE52C10 VA: 0x180E53A10
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0xE54000 Offset: 0xE53200 VA: 0x180E54000
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0xE54890 Offset: 0xE53A90 VA: 0x180E54890
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0xE54DA0 Offset: 0xE53FA0 VA: 0x180E54DA0
	|-AsyncOperationBase<SceneInstance>.Complete
	|
	|-RVA: 0xE7B260 Offset: 0xE7A460 VA: 0x180E7B260
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Complete
	*/

	// RVA: -1 Offset: -1
	internal void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE572D0 Offset: 0xE564D0 VA: 0x180E572D0
	|-AsyncOperationBase<bool>.Start
	|
	|-RVA: 0xE570A0 Offset: 0xE562A0 VA: 0x180E570A0
	|-AsyncOperationBase<long>.Start
	|
	|-RVA: 0xE57500 Offset: 0xE56700 VA: 0x180E57500
	|-AsyncOperationBase<object>.Start
	|
	|-RVA: 0xE57730 Offset: 0xE56930 VA: 0x180E57730
	|-AsyncOperationBase<SceneInstance>.Start
	|
	|-RVA: 0xE7CEC0 Offset: 0xE7C0C0 VA: 0x180E7CEC0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Start
	*/

	// RVA: -1 Offset: -1
	internal void InvokeExecute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE56D20 Offset: 0xE55F20 VA: 0x180E56D20
	|-AsyncOperationBase<bool>.InvokeExecute
	|
	|-RVA: 0xE56E40 Offset: 0xE56040 VA: 0x180E56E40
	|-AsyncOperationBase<long>.InvokeExecute
	|
	|-RVA: 0xE56DB0 Offset: 0xE55FB0 VA: 0x180E56DB0
	|-AsyncOperationBase<object>.InvokeExecute
	|
	|-RVA: 0xE56C90 Offset: 0xE55E90 VA: 0x180E56C90
	|-AsyncOperationBase<SceneInstance>.InvokeExecute
	|
	|-RVA: 0xE7CC70 Offset: 0xE7BE70 VA: 0x180E7CC70
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.InvokeExecute
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE58E60 Offset: 0xE58060 VA: 0x180E58E60
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0xE58CE0 Offset: 0xE57EE0 VA: 0x180E58CE0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0xE58FE0 Offset: 0xE581E0 VA: 0x180E58FE0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0xE7D650 Offset: 0xE7C850 VA: 0x180E7D650
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE59CB0 Offset: 0xE58EB0 VA: 0x180E59CB0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0xE59B80 Offset: 0xE58D80 VA: 0x180E59B80
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0xE7DA60 Offset: 0xE7CC60 VA: 0x180E7DA60
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE592E0 Offset: 0xE584E0 VA: 0x180E592E0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0xE591E0 Offset: 0xE583E0 VA: 0x180E591E0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0xE59160 Offset: 0xE58360 VA: 0x180E59160
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0xE59260 Offset: 0xE58460 VA: 0x180E59260
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0xE7D670 Offset: 0xE7C870 VA: 0x180E7D670
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE59ED0 Offset: 0xE590D0 VA: 0x180E59ED0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0xE59E30 Offset: 0xE59030 VA: 0x180E59E30
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0xE59DE0 Offset: 0xE58FE0 VA: 0x180E59DE0
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0xE59E80 Offset: 0xE59080 VA: 0x180E59E80
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0xE7DA80 Offset: 0xE7CC80 VA: 0x180E7DA80
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0xE7DA40 Offset: 0xE7CC40 VA: 0x180E7DA40
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0xE7D760 Offset: 0xE7C960 VA: 0x180E7D760
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE59540 Offset: 0xE58740 VA: 0x180E59540
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0xE59520 Offset: 0xE58720 VA: 0x180E59520
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0xE59500 Offset: 0xE58700 VA: 0x180E59500
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0xE7D740 Offset: 0xE7C940 VA: 0x180E7D740
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0xE7D7E0 Offset: 0xE7C9E0 VA: 0x180E7D7E0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0xE7D720 Offset: 0xE7C920 VA: 0x180E7D720
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE594A0 Offset: 0xE586A0 VA: 0x180E594A0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0xE594E0 Offset: 0xE586E0 VA: 0x180E594E0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0xE594C0 Offset: 0xE586C0 VA: 0x180E594C0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0xBCB5D0 Offset: 0xBCA7D0 VA: 0x180BCB5D0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE59360 Offset: 0xE58560 VA: 0x180E59360
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0xE59400 Offset: 0xE58600 VA: 0x180E59400
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0xE7D690 Offset: 0xE7C890 VA: 0x180E7D690
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy(Action<IAsyncOperation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0xE7DAA0 Offset: 0xE7CCA0 VA: 0x180E7DAA0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B5590 Offset: 0x8B4790 VA: 0x1808B5590
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private object UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE58250 Offset: 0xE57450 VA: 0x180E58250
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0xE58280 Offset: 0xE57480 VA: 0x180E58280
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0xE58220 Offset: 0xE57420 VA: 0x180E58220
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0xE7D510 Offset: 0xE7C710 VA: 0x180E7D510
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE59620 Offset: 0xE58820 VA: 0x180E59620
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0xE59560 Offset: 0xE58760 VA: 0x180E59560
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0xE59680 Offset: 0xE58880 VA: 0x180E59680
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0xE595C0 Offset: 0xE587C0 VA: 0x180E595C0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0xE7D780 Offset: 0xE7C980 VA: 0x180E7D780
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE581C0 Offset: 0xE573C0 VA: 0x180E581C0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE58180 Offset: 0xE57380 VA: 0x180E58180
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0xE581A0 Offset: 0xE573A0 VA: 0x180E581A0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0xE58160 Offset: 0xE57360 VA: 0x180E58160
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0xE58140 Offset: 0xE57340 VA: 0x180E58140
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0xE7D4F0 Offset: 0xE7C6F0 VA: 0x180E7D4F0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE582F0 Offset: 0xE574F0 VA: 0x180E582F0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0xE582B0 Offset: 0xE574B0 VA: 0x180E582B0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0xE582D0 Offset: 0xE574D0 VA: 0x180E582D0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0xE7D5C0 Offset: 0xE7C7C0 VA: 0x180E7D5C0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE58350 Offset: 0xE57550 VA: 0x180E58350
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0xE58370 Offset: 0xE57570 VA: 0x180E58370
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0xE58310 Offset: 0xE57510 VA: 0x180E58310
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0xE58330 Offset: 0xE57530 VA: 0x180E58330
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0xE7D5E0 Offset: 0xE7C7E0 VA: 0x180E7D5E0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE58A90 Offset: 0xE57C90 VA: 0x180E58A90
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0xE58840 Offset: 0xE57A40 VA: 0x180E58840
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0xE585F0 Offset: 0xE577F0 VA: 0x180E585F0
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0xE58390 Offset: 0xE57590 VA: 0x180E58390
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0xE7D600 Offset: 0xE7C800 VA: 0x180E7D600
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal virtual void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-AsyncOperationBase<bool>.ReleaseDependencies
	|-AsyncOperationBase<long>.ReleaseDependencies
	|-AsyncOperationBase<object>.ReleaseDependencies
	|-AsyncOperationBase<SceneInstance>.ReleaseDependencies
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private DownloadStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE581E0 Offset: 0xE573E0 VA: 0x180E581E0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal virtual DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE56110 Offset: 0xE55310 VA: 0x180E56110
	|-AsyncOperationBase<bool>.GetDownloadStatus
	|
	|-RVA: 0xE56080 Offset: 0xE55280 VA: 0x180E56080
	|-AsyncOperationBase<long>.GetDownloadStatus
	|
	|-RVA: 0xE56230 Offset: 0xE55430 VA: 0x180E56230
	|-AsyncOperationBase<object>.GetDownloadStatus
	|
	|-RVA: 0xE561A0 Offset: 0xE553A0 VA: 0x180E561A0
	|-AsyncOperationBase<SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0xE7C560 Offset: 0xE7B760 VA: 0x180E7C560
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <.ctor>b__35_0(AsyncOperationHandle o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE58120 Offset: 0xE57320 VA: 0x180E58120
	|-AsyncOperationBase<bool>.<.ctor>b__35_0
	|
	|-RVA: 0xE580E0 Offset: 0xE572E0 VA: 0x180E580E0
	|-AsyncOperationBase<long>.<.ctor>b__35_0
	|
	|-RVA: 0xE580C0 Offset: 0xE572C0 VA: 0x180E580C0
	|-AsyncOperationBase<object>.<.ctor>b__35_0
	|
	|-RVA: 0xE58100 Offset: 0xE57300 VA: 0x180E58100
	|-AsyncOperationBase<SceneInstance>.<.ctor>b__35_0
	|
	|-RVA: 0xE7D4D0 Offset: 0xE7C6D0 VA: 0x180E7D4D0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.<.ctor>b__35_0
	*/
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public struct AsyncOperationHandle<TObject> : IEnumerator, IEquatable<AsyncOperationHandle<TObject>> // TypeDefIndex: 16490
{
	// Fields
	internal AsyncOperationBase<TObject> m_InternalOp; // 0x0
	private int m_Version; // 0x0
	private string m_LocationName; // 0x0
	private bool m_UnloadSceneOpExcludeReleaseCallback; // 0x0

	// Properties
	internal string LocationName { get; set; }
	internal bool UnloadSceneOpExcludeReleaseCallback { get; set; }
	public string DebugName { get; }
	private AsyncOperationBase<TObject> InternalOp { get; }
	public bool IsDone { get; }
	public Exception OperationException { get; }
	public float PercentComplete { get; }
	internal int ReferenceCount { get; }
	public TObject Result { get; }
	public AsyncOperationStatus Status { get; }
	public Task<TObject> Task { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal string get_LocationName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-AsyncOperationHandle<bool>.get_LocationName
	|-AsyncOperationHandle<long>.get_LocationName
	|-AsyncOperationHandle<object>.get_LocationName
	|-AsyncOperationHandle<SceneInstance>.get_LocationName
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_LocationName
	*/

	// RVA: -1 Offset: -1
	internal void set_LocationName(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	|-AsyncOperationHandle<bool>.set_LocationName
	|-AsyncOperationHandle<long>.set_LocationName
	|-AsyncOperationHandle<object>.set_LocationName
	|-AsyncOperationHandle<SceneInstance>.set_LocationName
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.set_LocationName
	*/

	// RVA: -1 Offset: -1
	internal bool get_UnloadSceneOpExcludeReleaseCallback() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	|-AsyncOperationHandle<bool>.get_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<long>.get_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<object>.get_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<SceneInstance>.get_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_UnloadSceneOpExcludeReleaseCallback
	*/

	// RVA: -1 Offset: -1
	internal void set_UnloadSceneOpExcludeReleaseCallback(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	|-AsyncOperationHandle<bool>.set_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<long>.set_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<object>.set_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<SceneInstance>.set_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.set_UnloadSceneOpExcludeReleaseCallback
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle op_Implicit(AsyncOperationHandle<TObject> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE844C0 Offset: 0xE836C0 VA: 0x180E844C0
	|-AsyncOperationHandle<bool>.op_Implicit
	|-AsyncOperationHandle<long>.op_Implicit
	|-AsyncOperationHandle<object>.op_Implicit
	|-AsyncOperationHandle<SceneInstance>.op_Implicit
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(AsyncOperationBase<TObject> op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81190 Offset: 0xE80390 VA: 0x180E81190
	|-AsyncOperationHandle<bool>..ctor
	|-AsyncOperationHandle<long>..ctor
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0xE81CE0 Offset: 0xE80EE0 VA: 0x180E81CE0
	|-AsyncOperationHandle<SceneInstance>..ctor
	|
	|-RVA: 0xE811E0 Offset: 0xE803E0 VA: 0x180E811E0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public DownloadStatus GetDownloadStatus() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7F110 Offset: 0xE7E310 VA: 0x180E7F110
	|-AsyncOperationHandle<bool>.GetDownloadStatus
	|
	|-RVA: 0xE7F1D0 Offset: 0xE7E3D0 VA: 0x180E7F1D0
	|-AsyncOperationHandle<long>.GetDownloadStatus
	|
	|-RVA: 0xE7F290 Offset: 0xE7E490 VA: 0x180E7F290
	|-AsyncOperationHandle<object>.GetDownloadStatus
	|
	|-RVA: 0xE7F350 Offset: 0xE7E550 VA: 0x180E7F350
	|-AsyncOperationHandle<SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0xE7F020 Offset: 0xE7E220 VA: 0x180E7F020
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7F7D0 Offset: 0xE7E9D0 VA: 0x180E7F7D0
	|-AsyncOperationHandle<bool>.InternalGetDownloadStatus
	|
	|-RVA: 0xE7F450 Offset: 0xE7E650 VA: 0x180E7F450
	|-AsyncOperationHandle<long>.InternalGetDownloadStatus
	|
	|-RVA: 0xE7FAF0 Offset: 0xE7ECF0 VA: 0x180E7FAF0
	|-AsyncOperationHandle<object>.InternalGetDownloadStatus
	|
	|-RVA: 0xE7F960 Offset: 0xE7EB60 VA: 0x180E7F960
	|-AsyncOperationHandle<SceneInstance>.InternalGetDownloadStatus
	|
	|-RVA: 0xE7F5E0 Offset: 0xE7E7E0 VA: 0x180E7F5E0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.InternalGetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81280 Offset: 0xE80480 VA: 0x180E81280
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0xE81E90 Offset: 0xE81090 VA: 0x180E81E90
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0xE81B60 Offset: 0xE80D60 VA: 0x180E81B60
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0xE82310 Offset: 0xE81510 VA: 0x180E82310
	|-AsyncOperationHandle<SceneInstance>..ctor
	|
	|-RVA: 0xE82010 Offset: 0xE81210 VA: 0x180E82010
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, int version) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81580 Offset: 0xE80780 VA: 0x180E81580
	|-AsyncOperationHandle<bool>..ctor
	|-AsyncOperationHandle<long>..ctor
	|-AsyncOperationHandle<object>..ctor
	|-AsyncOperationHandle<SceneInstance>..ctor
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, string locationName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE819E0 Offset: 0xE80BE0 VA: 0x180E819E0
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0xE82190 Offset: 0xE81390 VA: 0x180E82190
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0xE81400 Offset: 0xE80600 VA: 0x180E81400
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0xE816E0 Offset: 0xE808E0 VA: 0x180E816E0
	|-AsyncOperationHandle<SceneInstance>..ctor
	|
	|-RVA: 0xE81860 Offset: 0xE80A60 VA: 0x180E81860
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, int version, string locationName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81D30 Offset: 0xE80F30 VA: 0x180E81D30
	|-AsyncOperationHandle<bool>..ctor
	|-AsyncOperationHandle<long>..ctor
	|-AsyncOperationHandle<object>..ctor
	|-AsyncOperationHandle<SceneInstance>..ctor
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> Acquire() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7EDC0 Offset: 0xE7DFC0 VA: 0x180E7EDC0
	|-AsyncOperationHandle<bool>.Acquire
	|
	|-RVA: 0xE7EB70 Offset: 0xE7DD70 VA: 0x180E7EB70
	|-AsyncOperationHandle<long>.Acquire
	|-AsyncOperationHandle<object>.Acquire
	|
	|-RVA: 0xE7EC20 Offset: 0xE7DE20 VA: 0x180E7EC20
	|-AsyncOperationHandle<SceneInstance>.Acquire
	|
	|-RVA: 0xE7ECD0 Offset: 0xE7DED0 VA: 0x180E7ECD0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void add_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82720 Offset: 0xE81920 VA: 0x180E82720
	|-AsyncOperationHandle<bool>.add_Completed
	|
	|-RVA: 0xE827B0 Offset: 0xE819B0 VA: 0x180E827B0
	|-AsyncOperationHandle<long>.add_Completed
	|-AsyncOperationHandle<object>.add_Completed
	|
	|-RVA: 0xE82840 Offset: 0xE81A40 VA: 0x180E82840
	|-AsyncOperationHandle<SceneInstance>.add_Completed
	|
	|-RVA: 0xE828D0 Offset: 0xE81AD0 VA: 0x180E828D0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.add_Completed
	*/

	// RVA: -1 Offset: -1
	public void remove_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE847E0 Offset: 0xE839E0 VA: 0x180E847E0
	|-AsyncOperationHandle<bool>.remove_Completed
	|-AsyncOperationHandle<long>.remove_Completed
	|-AsyncOperationHandle<object>.remove_Completed
	|
	|-RVA: 0xE84870 Offset: 0xE83A70 VA: 0x180E84870
	|-AsyncOperationHandle<SceneInstance>.remove_Completed
	|
	|-RVA: 0xE84700 Offset: 0xE83900 VA: 0x180E84700
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.remove_Completed
	*/

	// RVA: -1 Offset: -1
	public void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82490 Offset: 0xE81690 VA: 0x180E82490
	|-AsyncOperationHandle<bool>.add_CompletedTypeless
	|
	|-RVA: 0xE825B0 Offset: 0xE817B0 VA: 0x180E825B0
	|-AsyncOperationHandle<long>.add_CompletedTypeless
	|-AsyncOperationHandle<object>.add_CompletedTypeless
	|
	|-RVA: 0xE82520 Offset: 0xE81720 VA: 0x180E82520
	|-AsyncOperationHandle<SceneInstance>.add_CompletedTypeless
	|
	|-RVA: 0xE82640 Offset: 0xE81840 VA: 0x180E82640
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	public void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84500 Offset: 0xE83700 VA: 0x180E84500
	|-AsyncOperationHandle<bool>.remove_CompletedTypeless
	|-AsyncOperationHandle<long>.remove_CompletedTypeless
	|-AsyncOperationHandle<object>.remove_CompletedTypeless
	|
	|-RVA: 0xE84670 Offset: 0xE83870 VA: 0x180E84670
	|-AsyncOperationHandle<SceneInstance>.remove_CompletedTypeless
	|
	|-RVA: 0xE84590 Offset: 0xE83790 VA: 0x180E84590
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	public string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82CD0 Offset: 0xE81ED0 VA: 0x180E82CD0
	|-AsyncOperationHandle<bool>.get_DebugName
	|
	|-RVA: 0xE82EE0 Offset: 0xE820E0 VA: 0x180E82EE0
	|-AsyncOperationHandle<long>.get_DebugName
	|
	|-RVA: 0xE830C0 Offset: 0xE822C0 VA: 0x180E830C0
	|-AsyncOperationHandle<object>.get_DebugName
	|
	|-RVA: 0xE82FD0 Offset: 0xE821D0 VA: 0x180E82FD0
	|-AsyncOperationHandle<SceneInstance>.get_DebugName
	|
	|-RVA: 0xE82DC0 Offset: 0xE81FC0 VA: 0x180E82DC0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1
	public void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7EEA0 Offset: 0xE7E0A0 VA: 0x180E7EEA0
	|-AsyncOperationHandle<bool>.GetDependencies
	|-AsyncOperationHandle<long>.GetDependencies
	|-AsyncOperationHandle<object>.GetDependencies
	|
	|-RVA: 0xE7EF10 Offset: 0xE7E110 VA: 0x180E7EF10
	|-AsyncOperationHandle<SceneInstance>.GetDependencies
	|
	|-RVA: 0xE7EF80 Offset: 0xE7E180 VA: 0x180E7EF80
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82AD0 Offset: 0xE81CD0 VA: 0x180E82AD0
	|-AsyncOperationHandle<bool>.add_Destroyed
	|
	|-RVA: 0xE82A40 Offset: 0xE81C40 VA: 0x180E82A40
	|-AsyncOperationHandle<long>.add_Destroyed
	|
	|-RVA: 0xE829B0 Offset: 0xE81BB0 VA: 0x180E829B0
	|-AsyncOperationHandle<object>.add_Destroyed
	|
	|-RVA: 0xE82C40 Offset: 0xE81E40 VA: 0x180E82C40
	|-AsyncOperationHandle<SceneInstance>.add_Destroyed
	|
	|-RVA: 0xE82B60 Offset: 0xE81D60 VA: 0x180E82B60
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.add_Destroyed
	*/

	// RVA: -1 Offset: -1
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84A70 Offset: 0xE83C70 VA: 0x180E84A70
	|-AsyncOperationHandle<bool>.remove_Destroyed
	|
	|-RVA: 0xE84B00 Offset: 0xE83D00 VA: 0x180E84B00
	|-AsyncOperationHandle<long>.remove_Destroyed
	|
	|-RVA: 0xE84B90 Offset: 0xE83D90 VA: 0x180E84B90
	|-AsyncOperationHandle<object>.remove_Destroyed
	|
	|-RVA: 0xE84900 Offset: 0xE83B00 VA: 0x180E84900
	|-AsyncOperationHandle<SceneInstance>.remove_Destroyed
	|
	|-RVA: 0xE84990 Offset: 0xE83B90 VA: 0x180E84990
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.remove_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(AsyncOperationHandle<TObject> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7EE70 Offset: 0xE7E070 VA: 0x180E7EE70
	|-AsyncOperationHandle<bool>.Equals
	|-AsyncOperationHandle<long>.Equals
	|-AsyncOperationHandle<object>.Equals
	|-AsyncOperationHandle<SceneInstance>.Equals
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7F410 Offset: 0xE7E610 VA: 0x180E7F410
	|-AsyncOperationHandle<bool>.GetHashCode
	|-AsyncOperationHandle<long>.GetHashCode
	|-AsyncOperationHandle<object>.GetHashCode
	|-AsyncOperationHandle<SceneInstance>.GetHashCode
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public TObject WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE80FB0 Offset: 0xE801B0 VA: 0x180E80FB0
	|-AsyncOperationHandle<bool>.WaitForCompletion
	|
	|-RVA: 0xE80A40 Offset: 0xE7FC40 VA: 0x180E80A40
	|-AsyncOperationHandle<long>.WaitForCompletion
	|
	|-RVA: 0xE80860 Offset: 0xE7FA60 VA: 0x180E80860
	|-AsyncOperationHandle<object>.WaitForCompletion
	|
	|-RVA: 0xE80630 Offset: 0xE7F830 VA: 0x180E80630
	|-AsyncOperationHandle<SceneInstance>.WaitForCompletion
	|
	|-RVA: 0xE80C20 Offset: 0xE7FE20 VA: 0x180E80C20
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationBase<TObject> get_InternalOp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE831B0 Offset: 0xE823B0 VA: 0x180E831B0
	|-AsyncOperationHandle<bool>.get_InternalOp
	|-AsyncOperationHandle<long>.get_InternalOp
	|-AsyncOperationHandle<object>.get_InternalOp
	|
	|-RVA: 0xE83310 Offset: 0xE82510 VA: 0x180E83310
	|-AsyncOperationHandle<SceneInstance>.get_InternalOp
	|
	|-RVA: 0xE83240 Offset: 0xE82440 VA: 0x180E83240
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_InternalOp
	*/

	// RVA: -1 Offset: -1
	public bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE835B0 Offset: 0xE827B0 VA: 0x180E835B0
	|-AsyncOperationHandle<bool>.get_IsDone
	|
	|-RVA: 0xE834D0 Offset: 0xE826D0 VA: 0x180E834D0
	|-AsyncOperationHandle<long>.get_IsDone
	|-AsyncOperationHandle<object>.get_IsDone
	|
	|-RVA: 0xE83690 Offset: 0xE82890 VA: 0x180E83690
	|-AsyncOperationHandle<SceneInstance>.get_IsDone
	|
	|-RVA: 0xE833A0 Offset: 0xE825A0 VA: 0x180E833A0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_IsDone
	*/

	// RVA: -1 Offset: -1
	public bool IsValid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7FD20 Offset: 0xE7EF20 VA: 0x180E7FD20
	|-AsyncOperationHandle<bool>.IsValid
	|-AsyncOperationHandle<long>.IsValid
	|-AsyncOperationHandle<object>.IsValid
	|
	|-RVA: 0xE7FD70 Offset: 0xE7EF70 VA: 0x180E7FD70
	|-AsyncOperationHandle<SceneInstance>.IsValid
	|
	|-RVA: 0xE7FC80 Offset: 0xE7EE80 VA: 0x180E7FC80
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.IsValid
	*/

	// RVA: -1 Offset: -1
	public Exception get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE83770 Offset: 0xE82970 VA: 0x180E83770
	|-AsyncOperationHandle<bool>.get_OperationException
	|-AsyncOperationHandle<long>.get_OperationException
	|-AsyncOperationHandle<object>.get_OperationException
	|
	|-RVA: 0xE837E0 Offset: 0xE829E0 VA: 0x180E837E0
	|-AsyncOperationHandle<SceneInstance>.get_OperationException
	|
	|-RVA: 0xE83850 Offset: 0xE82A50 VA: 0x180E83850
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_OperationException
	*/

	// RVA: -1 Offset: -1
	public float get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE83AF0 Offset: 0xE82CF0 VA: 0x180E83AF0
	|-AsyncOperationHandle<bool>.get_PercentComplete
	|
	|-RVA: 0xE83A70 Offset: 0xE82C70 VA: 0x180E83A70
	|-AsyncOperationHandle<long>.get_PercentComplete
	|-AsyncOperationHandle<object>.get_PercentComplete
	|
	|-RVA: 0xE839F0 Offset: 0xE82BF0 VA: 0x180E839F0
	|-AsyncOperationHandle<SceneInstance>.get_PercentComplete
	|
	|-RVA: 0xE83920 Offset: 0xE82B20 VA: 0x180E83920
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_PercentComplete
	*/

	// RVA: -1 Offset: -1
	internal int get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE83BE0 Offset: 0xE82DE0 VA: 0x180E83BE0
	|-AsyncOperationHandle<bool>.get_ReferenceCount
	|
	|-RVA: 0xE83D20 Offset: 0xE82F20 VA: 0x180E83D20
	|-AsyncOperationHandle<long>.get_ReferenceCount
	|-AsyncOperationHandle<object>.get_ReferenceCount
	|
	|-RVA: 0xE83B70 Offset: 0xE82D70 VA: 0x180E83B70
	|-AsyncOperationHandle<SceneInstance>.get_ReferenceCount
	|
	|-RVA: 0xE83C50 Offset: 0xE82E50 VA: 0x180E83C50
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_ReferenceCount
	*/

	// RVA: -1 Offset: -1
	internal void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7FDC0 Offset: 0xE7EFC0 VA: 0x180E7FDC0
	|-AsyncOperationHandle<bool>.Release
	|
	|-RVA: 0xE7FEE0 Offset: 0xE7F0E0 VA: 0x180E7FEE0
	|-AsyncOperationHandle<long>.Release
	|
	|-RVA: 0xE7FE50 Offset: 0xE7F050 VA: 0x180E7FE50
	|-AsyncOperationHandle<object>.Release
	|
	|-RVA: 0xE80050 Offset: 0xE7F250 VA: 0x180E80050
	|-AsyncOperationHandle<SceneInstance>.Release
	|
	|-RVA: 0xE7FF70 Offset: 0xE7F170 VA: 0x180E7FF70
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	public TObject get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE83F50 Offset: 0xE83150 VA: 0x180E83F50
	|-AsyncOperationHandle<bool>.get_Result
	|
	|-RVA: 0xE83EE0 Offset: 0xE830E0 VA: 0x180E83EE0
	|-AsyncOperationHandle<long>.get_Result
	|-AsyncOperationHandle<object>.get_Result
	|
	|-RVA: 0xE83FC0 Offset: 0xE831C0 VA: 0x180E83FC0
	|-AsyncOperationHandle<SceneInstance>.get_Result
	|
	|-RVA: 0xE83D90 Offset: 0xE82F90 VA: 0x180E83D90
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE83D20 Offset: 0xE82F20 VA: 0x180E83D20
	|-AsyncOperationHandle<bool>.get_Status
	|
	|-RVA: 0xE84040 Offset: 0xE83240 VA: 0x180E84040
	|-AsyncOperationHandle<long>.get_Status
	|-AsyncOperationHandle<object>.get_Status
	|
	|-RVA: 0xE84180 Offset: 0xE83380 VA: 0x180E84180
	|-AsyncOperationHandle<SceneInstance>.get_Status
	|
	|-RVA: 0xE840B0 Offset: 0xE832B0 VA: 0x180E840B0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_Status
	*/

	// RVA: -1 Offset: -1
	public Task<TObject> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84440 Offset: 0xE83640 VA: 0x180E84440
	|-AsyncOperationHandle<bool>.get_Task
	|
	|-RVA: 0xE84340 Offset: 0xE83540 VA: 0x180E84340
	|-AsyncOperationHandle<long>.get_Task
	|
	|-RVA: 0xE843C0 Offset: 0xE835C0 VA: 0x180E843C0
	|-AsyncOperationHandle<object>.get_Task
	|
	|-RVA: 0xE842C0 Offset: 0xE834C0 VA: 0x180E842C0
	|-AsyncOperationHandle<SceneInstance>.get_Task
	|
	|-RVA: 0xE841F0 Offset: 0xE833F0 VA: 0x180E841F0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE80560 Offset: 0xE7F760 VA: 0x180E80560
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xE80400 Offset: 0xE7F600 VA: 0x180E80400
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xE804D0 Offset: 0xE7F6D0 VA: 0x180E804D0
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xE80330 Offset: 0xE7F530 VA: 0x180E80330
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xE80220 Offset: 0xE7F420 VA: 0x180E80220
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE800E0 Offset: 0xE7F2E0 VA: 0x180E800E0
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0xE80120 Offset: 0xE7F320 VA: 0x180E80120
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.MoveNext
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0xE80160 Offset: 0xE7F360 VA: 0x180E80160
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0xE801A0 Offset: 0xE7F3A0 VA: 0x180E801A0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.Reset
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.Reset
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.Reset
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.Reset
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public struct AsyncOperationHandle : IEnumerator // TypeDefIndex: 16491
{
	// Fields
	internal IAsyncOperation m_InternalOp; // 0x0
	private int m_Version; // 0x8
	private string m_LocationName; // 0x10

	// Properties
	internal string LocationName { get; set; }
	public string DebugName { get; }
	private IAsyncOperation InternalOp { get; }
	public bool IsDone { get; }
	public Exception OperationException { get; }
	public float PercentComplete { get; }
	internal int ReferenceCount { get; }
	public object Result { get; }
	public AsyncOperationStatus Status { get; }
	public Task<object> Task { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal string get_LocationName() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_LocationName(string value) { }

	// RVA: 0x2380180 Offset: 0x237F380 VA: 0x182380180
	internal void .ctor(IAsyncOperation op) { }

	// RVA: 0x2380160 Offset: 0x237F360 VA: 0x182380160
	internal void .ctor(IAsyncOperation op, int version) { }

	// RVA: 0x23801F0 Offset: 0x237F3F0 VA: 0x1823801F0
	internal void .ctor(IAsyncOperation op, string locationName) { }

	// RVA: 0x2380170 Offset: 0x237F370 VA: 0x182380170
	internal void .ctor(IAsyncOperation op, int version, string locationName) { }

	// RVA: 0x237FB60 Offset: 0x237ED60 VA: 0x18237FB60
	internal AsyncOperationHandle Acquire() { }

	// RVA: 0x2380260 Offset: 0x237F460 VA: 0x182380260
	public void add_Completed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x2380860 Offset: 0x237FA60 VA: 0x182380860
	public void remove_Completed(Action<AsyncOperationHandle> value) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<T> Convert<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93C110 Offset: 0x93B310 VA: 0x18093C110
	|-AsyncOperationHandle.Convert<object>
	|-AsyncOperationHandle.Convert<SceneInstance>
	|-AsyncOperationHandle.Convert<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xE7EE70 Offset: 0xE7E070 VA: 0x180E7EE70
	public bool Equals(AsyncOperationHandle other) { }

	// RVA: 0x2380340 Offset: 0x237F540 VA: 0x182380340
	public string get_DebugName() { }

	// RVA: 0x23802D0 Offset: 0x237F4D0 VA: 0x1823802D0
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x23808D0 Offset: 0x237FAD0 VA: 0x1823808D0
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x237FBE0 Offset: 0x237EDE0 VA: 0x18237FBE0
	public void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0xE7F410 Offset: 0xE7E610 VA: 0x180E7F410 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23803F0 Offset: 0x237F5F0 VA: 0x1823803F0
	private IAsyncOperation get_InternalOp() { }

	// RVA: 0x2380490 Offset: 0x237F690 VA: 0x182380490
	public bool get_IsDone() { }

	// RVA: 0x237FEF0 Offset: 0x237F0F0 VA: 0x18237FEF0
	public bool IsValid() { }

	// RVA: 0x2380530 Offset: 0x237F730 VA: 0x182380530
	public Exception get_OperationException() { }

	// RVA: 0x2380600 Offset: 0x237F800 VA: 0x182380600
	public float get_PercentComplete() { }

	// RVA: 0x237FCB0 Offset: 0x237EEB0 VA: 0x18237FCB0
	public DownloadStatus GetDownloadStatus() { }

	// RVA: 0x237FD50 Offset: 0x237EF50 VA: 0x18237FD50
	internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x23806D0 Offset: 0x237F8D0 VA: 0x1823806D0
	internal int get_ReferenceCount() { }

	// RVA: 0x237FF50 Offset: 0x237F150 VA: 0x18237FF50
	internal void Release() { }

	// RVA: 0x237FFD0 Offset: 0x237F1D0 VA: 0x18237FFD0
	public object get_Result() { }

	// RVA: 0x2380730 Offset: 0x237F930 VA: 0x182380730
	public AsyncOperationStatus get_Status() { }

	// RVA: 0x2380790 Offset: 0x237F990 VA: 0x182380790
	public Task<object> get_Task() { }

	// RVA: 0x237FFD0 Offset: 0x237F1D0 VA: 0x18237FFD0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x237FFB0 Offset: 0x237F1B0 VA: 0x18237FFB0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2380020 Offset: 0x237F220 VA: 0x182380020
	public object WaitForCompletion() { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public enum AsyncOperationStatus // TypeDefIndex: 16492
{
	// Fields
	public int value__; // 0x0
	public const AsyncOperationStatus None = 0;
	public const AsyncOperationStatus Succeeded = 1;
	public const AsyncOperationStatus Failed = 2;
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public struct DownloadStatus // TypeDefIndex: 16493
{
	// Fields
	public long TotalBytes; // 0x0
	public long DownloadedBytes; // 0x8
	public bool IsDone; // 0x10

	// Properties
	public float Percent { get; }

	// Methods

	// RVA: 0x2383620 Offset: 0x2382820 VA: 0x182383620
	public float get_Percent() { }
}

// Namespace: 
[Flags]
public enum GroupOperation.GroupOperationSettings // TypeDefIndex: 16494
{
	// Fields
	public int value__; // 0x0
	public const GroupOperation.GroupOperationSettings None = 0;
	public const GroupOperation.GroupOperationSettings ReleaseDependenciesOnFailure = 1;
	public const GroupOperation.GroupOperationSettings AllowFailedDependencies = 2;
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class GroupOperation : AsyncOperationBase<IList<AsyncOperationHandle>>, ICachable // TypeDefIndex: 16495
{
	// Fields
	private Action<AsyncOperationHandle> m_InternalOnComplete; // 0x88
	private int m_LoadedCount; // 0x90
	private GroupOperation.GroupOperationSettings m_Settings; // 0x94
	private string debugName; // 0x98
	private const int k_MaxDisplayedLocationLength = 45;
	[CompilerGenerated]
	private IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField; // 0xA0
	private HashSet<string> m_CachedDependencyLocations; // 0xA8

	// Properties
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key { get; set; }
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x2384840 Offset: 0x2383A40 VA: 0x182384840
	public void .ctor() { }

	// RVA: 0x2384340 Offset: 0x2383540 VA: 0x182384340 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	[CompilerGenerated]
	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0 Slot: 36
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key() { }

	[CompilerGenerated]
	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20 Slot: 37
	private void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(IOperationCacheKey value) { }

	// RVA: 0x2383EB0 Offset: 0x23830B0 VA: 0x182383EB0
	internal IList<AsyncOperationHandle> GetDependentOps() { }

	// RVA: 0x2383E50 Offset: 0x2383050 VA: 0x182383E50 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x2384590 Offset: 0x2383790 VA: 0x182384590 Slot: 34
	internal override void ReleaseDependencies() { }

	// RVA: 0x2383EF0 Offset: 0x23830F0 VA: 0x182383EF0 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x2383920 Offset: 0x2382B20 VA: 0x182383920
	private bool DependenciesAreUnchanged(List<AsyncOperationHandle> deps) { }

	// RVA: 0x2384950 Offset: 0x2383B50 VA: 0x182384950 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x2383AE0 Offset: 0x2382CE0 VA: 0x182383AE0 Slot: 28
	protected override void Execute() { }

	// RVA: 0x2383650 Offset: 0x2382850 VA: 0x182383650
	private void CompleteIfDependenciesComplete() { }

	// RVA: 0x2383AC0 Offset: 0x2382CC0 VA: 0x182383AC0 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x2384C00 Offset: 0x2383E00 VA: 0x182384C00 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x2384280 Offset: 0x2383480 VA: 0x182384280
	public void Init(List<AsyncOperationHandle> operations, bool releaseDependenciesOnFailure = True, bool allowFailedDependencies = False) { }

	// RVA: 0x23841E0 Offset: 0x23833E0 VA: 0x1823841E0
	public void Init(List<AsyncOperationHandle> operations, GroupOperation.GroupOperationSettings settings) { }

	// RVA: 0x2384580 Offset: 0x2383780 VA: 0x182384580
	private void OnOperationCompleted(AsyncOperationHandle op) { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal interface IGenericProviderOperation // TypeDefIndex: 16496
{
	// Properties
	public abstract int ProvideHandleVersion { get; }
	public abstract IResourceLocation Location { get; }
	public abstract int DependencyCount { get; }
	public abstract Type RequestedType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_ProvideHandleVersion();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IResourceLocation get_Location();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_DependencyCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GetDependencies(IList<object> dstList);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TDepObject GetDependency<TDepObject>(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericProviderOperation.GetDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetProgressCallback(Func<float> callback);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ProviderCompleted<T>(T result, bool status, Exception e);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericProviderOperation.ProviderCompleted<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_RequestedType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void SetDownloadProgressCallback(Func<DownloadStatus> callback);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SetWaitForCompletionCallback(Func<bool> callback);
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
[Preserve]
internal class ProviderOperation<TObject> : AsyncOperationBase<TObject>, IGenericProviderOperation, ICachable // TypeDefIndex: 16497
{
	// Fields
	private bool m_ReleaseDependenciesOnFailure; // 0x0
	private Action<int, object, bool, Exception> m_CompletionCallback; // 0x0
	private Action<int, IList<object>> m_GetDepCallback; // 0x0
	private Func<float> m_GetProgressCallback; // 0x0
	private Func<DownloadStatus> m_GetDownloadProgressCallback; // 0x0
	private Func<bool> m_WaitForCompletionCallback; // 0x0
	private bool m_ProviderCompletedCalled; // 0x0
	private DownloadStatus m_DownloadStatus; // 0x0
	private IResourceProvider m_Provider; // 0x0
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0x0
	private IResourceLocation m_Location; // 0x0
	private int m_ProvideHandleVersion; // 0x0
	private bool m_NeedsRelease; // 0x0
	[CompilerGenerated]
	private IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField; // 0x0
	private ResourceManager m_ResourceManager; // 0x0
	private const float k_OperationWaitingToCompletePercentComplete = 0,99;
	internal const string kInvalidHandleMsg = "The ProvideHandle is invalid. After the handle has been completed, it can no longer be used";

	// Properties
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key { get; set; }
	public int ProvideHandleVersion { get; }
	public IResourceLocation Location { get; }
	protected override string DebugName { get; }
	public Type RequestedType { get; }
	public int DependencyCount { get; }
	protected override float Progress { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 48
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520
	|-ProviderOperation<object>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key
	|
	|-RVA: 0xB8FC90 Offset: 0xB8EE90 VA: 0x180B8FC90
	|-ProviderOperation<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 49
	private void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(IOperationCacheKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6ED6D0 Offset: 0x6EC8D0 VA: 0x1806ED6D0
	|-ProviderOperation<object>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key
	|
	|-RVA: 0xB8FCC0 Offset: 0xB8EEC0 VA: 0x180B8FCC0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public int get_ProvideHandleVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB82FD0 Offset: 0xB821D0 VA: 0x180B82FD0
	|-ProviderOperation<object>.get_ProvideHandleVersion
	|
	|-RVA: 0xB90B50 Offset: 0xB8FD50 VA: 0x180B90B50
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_ProvideHandleVersion
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public IResourceLocation get_Location() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7960A0 Offset: 0x7952A0 VA: 0x1807960A0
	|-ProviderOperation<object>.get_Location
	|
	|-RVA: 0xB90470 Offset: 0xB8F670 VA: 0x180B90470
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_Location
	*/

	// RVA: -1 Offset: -1 Slot: 46
	public void SetDownloadProgressCallback(Func<DownloadStatus> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8FA30 Offset: 0xB8EC30 VA: 0x180B8FA30
	|-ProviderOperation<object>.SetDownloadProgressCallback
	|
	|-RVA: 0xB8FA80 Offset: 0xB8EC80 VA: 0x180B8FA80
	|-ProviderOperation<__Il2CppFullySharedGenericType>.SetDownloadProgressCallback
	*/

	// RVA: -1 Offset: -1 Slot: 47
	public void SetWaitForCompletionCallback(Func<bool> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x88DF00 Offset: 0x88D100 VA: 0x18088DF00
	|-ProviderOperation<object>.SetWaitForCompletionCallback
	|
	|-RVA: 0xB8FC30 Offset: 0xB8EE30 VA: 0x180B8FC30
	|-ProviderOperation<__Il2CppFullySharedGenericType>.SetWaitForCompletionCallback
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8F7B0 Offset: 0xB8E9B0 VA: 0x180B8F7B0
	|-ProviderOperation<object>.InvokeWaitForCompletion
	|
	|-RVA: 0xB8F550 Offset: 0xB8E750 VA: 0x180B8F550
	|-ProviderOperation<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8E8F0 Offset: 0xB8DAF0 VA: 0x180B8E8F0
	|-ProviderOperation<object>.GetDownloadStatus
	|
	|-RVA: 0xB8EA70 Offset: 0xB8DC70 VA: 0x180B8EA70
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8FFD0 Offset: 0xB8F1D0 VA: 0x180B8FFD0
	|-ProviderOperation<object>..ctor
	|
	|-RVA: 0xB8FF60 Offset: 0xB8F160 VA: 0x180B8FF60
	|-ProviderOperation<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8DF60 Offset: 0xB8D160 VA: 0x180B8DF60
	|-ProviderOperation<object>.GetDependencies
	|
	|-RVA: 0xB8E3A0 Offset: 0xB8D5A0 VA: 0x180B8E3A0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8F900 Offset: 0xB8EB00 VA: 0x180B8F900
	|-ProviderOperation<object>.ReleaseDependencies
	|
	|-RVA: 0xB8F970 Offset: 0xB8EB70 VA: 0x180B8F970
	|-ProviderOperation<__Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB90160 Offset: 0xB8F360 VA: 0x180B90160
	|-ProviderOperation<object>.get_DebugName
	|
	|-RVA: 0xB8FFF0 Offset: 0xB8F1F0 VA: 0x180B8FFF0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public void GetDependencies(IList<object> dstList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8E090 Offset: 0xB8D290 VA: 0x180B8E090
	|-ProviderOperation<object>.GetDependencies
	|
	|-RVA: 0xB8E520 Offset: 0xB8D720 VA: 0x180B8E520
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 45
	public Type get_RequestedType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB90B80 Offset: 0xB8FD80 VA: 0x180B90B80
	|-ProviderOperation<object>.get_RequestedType
	|
	|-RVA: 0xB90BE0 Offset: 0xB8FDE0 VA: 0x180B90BE0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_RequestedType
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public int get_DependencyCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB90280 Offset: 0xB8F480 VA: 0x180B90280
	|-ProviderOperation<object>.get_DependencyCount
	|
	|-RVA: 0xB90330 Offset: 0xB8F530 VA: 0x180B90330
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_DependencyCount
	*/

	// RVA: -1 Offset: -1 Slot: 42
	public TDepObject GetDependency<TDepObject>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EF060 Offset: 0x8EE260 VA: 0x1808EF060
	|-ProviderOperation<object>.GetDependency<object>
	|
	|-RVA: 0x8EEE30 Offset: 0x8EE030 VA: 0x1808EEE30
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 43
	public void SetProgressCallback(Func<float> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20
	|-ProviderOperation<object>.SetProgressCallback
	|
	|-RVA: 0xB8FBC0 Offset: 0xB8EDC0 VA: 0x180B8FBC0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.SetProgressCallback
	*/

	// RVA: -1 Offset: -1 Slot: 44
	public void ProviderCompleted<T>(T result, bool status, Exception e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EFB90 Offset: 0x8EED90 VA: 0x1808EFB90
	|-ProviderOperation<object>.ProviderCompleted<object>
	|
	|-RVA: 0x8EF1F0 Offset: 0x8EE3F0 VA: 0x1808EF1F0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.ProviderCompleted<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB90870 Offset: 0xB8FA70 VA: 0x180B90870
	|-ProviderOperation<object>.get_Progress
	|
	|-RVA: 0xB904A0 Offset: 0xB8F6A0 VA: 0x180B904A0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8D860 Offset: 0xB8CA60 VA: 0x180B8D860
	|-ProviderOperation<object>.Execute
	|
	|-RVA: 0xB8DAE0 Offset: 0xB8CCE0 VA: 0x180B8DAE0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8F160 Offset: 0xB8E360 VA: 0x180B8F160
	|-ProviderOperation<object>.Init
	|
	|-RVA: 0xB8F280 Offset: 0xB8E480 VA: 0x180B8F280
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8F030 Offset: 0xB8E230 VA: 0x180B8F030
	|-ProviderOperation<object>.Init
	|
	|-RVA: 0xB8ED60 Offset: 0xB8DF60 VA: 0x180B8ED60
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1
	private bool WaitForCompletionHandler() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8FE80 Offset: 0xB8F080 VA: 0x180B8FE80
	|-ProviderOperation<object>.WaitForCompletionHandler
	|
	|-RVA: 0xB8FD20 Offset: 0xB8EF20 VA: 0x180B8FD20
	|-ProviderOperation<__Il2CppFullySharedGenericType>.WaitForCompletionHandler
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8D7A0 Offset: 0xB8C9A0 VA: 0x180B8D7A0
	|-ProviderOperation<object>.Destroy
	|
	|-RVA: 0xB8D500 Offset: 0xB8C700 VA: 0x180B8D500
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Destroy
	*/
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class UnityWebRequestOperation : AsyncOperationBase<UnityWebRequest> // TypeDefIndex: 16498
{
	// Fields
	private UnityWebRequest m_UWR; // 0x88

	// Methods

	// RVA: 0x23924D0 Offset: 0x23916D0 VA: 0x1823924D0
	public void .ctor(UnityWebRequest webRequest) { }

	// RVA: 0x2392390 Offset: 0x2391590 VA: 0x182392390 Slot: 28
	protected override void Execute() { }

	[CompilerGenerated]
	// RVA: 0x2392430 Offset: 0x2391630 VA: 0x182392430
	private void <Execute>b__2_0(AsyncOperation request) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3917 // TypeDefIndex: 16499
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5773 // TypeDefIndex: 16500
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16501
{
	// Fields
	internal static readonly long 2D2025322643CE1497D8FB03FA789F27E833CF43545CA1003AFEFEA250D39313 = 3172232900852580628; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5773 B2745B2B979382B144B965344DFEA6CB8B20FA272517CCD122399C8CBBA2B201 /*Metadata offset 0x8F8838*/; // 0x8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3917 C61341842DC5B13BA81FD70E75CE680B1CDF30D88C1ECAC4B4B0296D4E89B95D /*Metadata offset 0x8F9EC8*/; // 0x1695
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16502
{}

// Namespace: 
[Serializable]
public struct PackedPlayModeBuildLogs.RuntimeBuildLog // TypeDefIndex: 16503
{
	// Fields
	public LogType Type; // 0x0
	public string Message; // 0x8

	// Methods

	// RVA: 0xBB0D00 Offset: 0xBAFF00 VA: 0x180BB0D00
	public void .ctor(LogType type, string message) { }
}

// Namespace: 
[Serializable]
public class PackedPlayModeBuildLogs // TypeDefIndex: 16504
{
	// Fields
	[SerializeField]
	private List<PackedPlayModeBuildLogs.RuntimeBuildLog> m_RuntimeBuildLogs; // 0x10

	// Properties
	public List<PackedPlayModeBuildLogs.RuntimeBuildLog> RuntimeBuildLogs { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public List<PackedPlayModeBuildLogs.RuntimeBuildLog> get_RuntimeBuildLogs() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RuntimeBuildLogs(List<PackedPlayModeBuildLogs.RuntimeBuildLog> value) { }

	// RVA: 0x235E740 Offset: 0x235D940 VA: 0x18235E740
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 16505
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(1)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 16506
{
	// Methods

	// RVA: 0x23632C0 Offset: 0x23624C0 VA: 0x1823632C0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(384, AllowMultiple = True)]
public class AssetReferenceUIRestriction : Attribute // TypeDefIndex: 16507
{
	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public virtual bool ValidateAsset(Object obj) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public virtual bool ValidateAsset(string path) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(384, AllowMultiple = False)]
public sealed class AssetReferenceUILabelRestriction : AssetReferenceUIRestriction // TypeDefIndex: 16508
{
	// Fields
	public string[] m_AllowedLabels; // 0x10
	public string m_CachedToString; // 0x18

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string[] allowedLabels) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public override bool ValidateAsset(Object obj) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public override bool ValidateAsset(string path) { }

	// RVA: 0x2350950 Offset: 0x234FB50 VA: 0x182350950 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class InitalizationObjectsOperation : AsyncOperationBase<bool> // TypeDefIndex: 16509
{
	// Fields
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_RtdOp; // 0x88
	private AddressablesImpl m_Addressables; // 0xA8
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xB0

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x2357050 Offset: 0x2356250 VA: 0x182357050
	public void Init(AsyncOperationHandle<ResourceManagerRuntimeData> rtdOp, AddressablesImpl addressables) { }

	// RVA: 0x23575F0 Offset: 0x23567F0 VA: 0x1823575F0 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x2357230 Offset: 0x2356430 VA: 0x182357230
	internal bool LogRuntimeWarnings(string pathToBuildLogs) { }

	// RVA: 0x23570A0 Offset: 0x23562A0 VA: 0x1823570A0 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x2356A50 Offset: 0x2355C50 VA: 0x182356A50 Slot: 28
	protected override void Execute() { }

	// RVA: 0x23575B0 Offset: 0x23567B0 VA: 0x1823575B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2357410 Offset: 0x2356610 VA: 0x182357410
	private void <Execute>b__8_0(AsyncOperationHandle<IList<AsyncOperationHandle>> obj) { }
}

// Namespace: UnityEngine.AddressableAssets
public class ResourceLocatorInfo // TypeDefIndex: 16510
{
	// Fields
	[CompilerGenerated]
	private IResourceLocator <Locator>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <LocalHash>k__BackingField; // 0x18
	[CompilerGenerated]
	private IResourceLocation <CatalogLocation>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <ContentUpdateAvailable>k__BackingField; // 0x28

	// Properties
	public IResourceLocator Locator { get; set; }
	public string LocalHash { get; set; }
	public IResourceLocation CatalogLocation { get; set; }
	internal bool ContentUpdateAvailable { get; set; }
	public IResourceLocation HashLocation { get; }
	public bool CanUpdateContent { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IResourceLocator get_Locator() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_Locator(IResourceLocator value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_LocalHash() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_LocalHash(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IResourceLocation get_CatalogLocation() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_CatalogLocation(IResourceLocation value) { }

	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	internal bool get_ContentUpdateAvailable() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	internal void set_ContentUpdateAvailable(bool value) { }

	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	public void .ctor(IResourceLocator loc, string localHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x23602A0 Offset: 0x235F4A0 VA: 0x1823602A0
	public IResourceLocation get_HashLocation() { }

	// RVA: 0x23601F0 Offset: 0x235F3F0 VA: 0x1823601F0
	public bool get_CanUpdateContent() { }

	// RVA: 0x23601E0 Offset: 0x235F3E0 VA: 0x1823601E0
	internal void UpdateContent(IResourceLocator locator, string hash, IResourceLocation loc) { }
}

// Namespace: UnityEngine.AddressableAssets
public class InvalidKeyException : Exception // TypeDefIndex: 16511
{
	// Fields
	[CompilerGenerated]
	private object <Key>k__BackingField; // 0x90
	[CompilerGenerated]
	private Type <Type>k__BackingField; // 0x98
	[CompilerGenerated]
	private readonly Nullable<Addressables.MergeMode> <MergeMode>k__BackingField; // 0xA0
	private AddressablesImpl m_Addressables; // 0xA8
	private const string BaseInvalidKeyMessageFormat = "{0}, Key={1}, Type={2}";

	// Properties
	public object Key { get; set; }
	public Type Type { get; set; }
	public Nullable<Addressables.MergeMode> MergeMode { get; }
	public override string Message { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public object get_Key() { }

	[CompilerGenerated]
	// RVA: 0x43B590 Offset: 0x43A790 VA: 0x18043B590
	private void set_Key(object value) { }

	[CompilerGenerated]
	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	private void set_Type(Type value) { }

	[CompilerGenerated]
	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public Nullable<Addressables.MergeMode> get_MergeMode() { }

	// RVA: 0x235D790 Offset: 0x235C990 VA: 0x18235D790
	public void .ctor(object key) { }

	// RVA: 0x235DAA0 Offset: 0x235CCA0 VA: 0x18235DAA0
	public void .ctor(object key, Type type) { }

	// RVA: 0x235DB20 Offset: 0x235CD20 VA: 0x18235DB20
	internal void .ctor(object key, Type type, AddressablesImpl addr) { }

	// RVA: 0x235D990 Offset: 0x235CB90 VA: 0x18235D990
	public void .ctor(object key, Type type, Addressables.MergeMode mergeMode) { }

	// RVA: 0x235D8D0 Offset: 0x235CAD0 VA: 0x18235D8D0
	internal void .ctor(object key, Type type, Addressables.MergeMode mergeMode, AddressablesImpl addr) { }

	// RVA: 0x235DA50 Offset: 0x235CC50 VA: 0x18235DA50
	public void .ctor() { }

	// RVA: 0x235DBB0 Offset: 0x235CDB0 VA: 0x18235DBB0
	public void .ctor(string message) { }

	// RVA: 0x235D720 Offset: 0x235C920 VA: 0x18235D720
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x235D850 Offset: 0x235CA50 VA: 0x18235D850
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x235DC10 Offset: 0x235CE10 VA: 0x18235DC10 Slot: 5
	public override string get_Message() { }

	// RVA: 0x235BAD0 Offset: 0x235ACD0 VA: 0x18235BAD0
	private string GetMessageForSingleKey(string keyString) { }

	// RVA: 0x235C0C0 Offset: 0x235B2C0 VA: 0x18235C0C0
	private string GetMessageforMergeKeys(List<string> keys) { }

	// RVA: 0x235D350 Offset: 0x235C550 VA: 0x18235D350
	private HashSet<Type> GetTypesForKey(string keyString) { }

	// RVA: 0x235D120 Offset: 0x235C320 VA: 0x18235D120
	private bool GetTypeToKeys(string key, Dictionary<Type, List<string>> typeToKeys) { }

	// RVA: 0x235B820 Offset: 0x235AA20 VA: 0x18235B820
	private string GetCSVString(IEnumerable<string> enumerator, string prefixSingle, string prefixPlural) { }
}

// Namespace: 
public enum Addressables.MergeMode // TypeDefIndex: 16512
{
	// Fields
	public int value__; // 0x0
	public const Addressables.MergeMode None = 0;
	public const Addressables.MergeMode UseFirst = 0;
	public const Addressables.MergeMode Union = 1;
	public const Addressables.MergeMode Intersection = 2;
}

// Namespace: UnityEngine.AddressableAssets
public static class Addressables // TypeDefIndex: 16513
{
	// Fields
	internal static bool reinitializeAddressables; // 0x0
	internal static AddressablesImpl m_AddressablesInstance; // 0x8
	public const string kAddressablesRuntimeDataPath = "AddressablesRuntimeDataPath";
	private const string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";
	public const string kAddressablesRuntimeBuildLogPath = "AddressablesRuntimeBuildLog";
	public static string LibraryPath; // 0x10

	// Properties
	private static AddressablesImpl m_Addressables { get; }
	public static ResourceManager ResourceManager { get; }
	internal static AddressablesImpl Instance { get; }
	public static IInstanceProvider InstanceProvider { get; }
	public static Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public static Action<UnityWebRequest> WebRequestOverride { get; set; }
	public static string StreamingAssetsSubFolder { get; }
	public static string BuildPath { get; }
	public static string PlayerBuildDataPath { get; }
	public static string RuntimePath { get; }
	public static IEnumerable<IResourceLocator> ResourceLocators { get; }
	[Obsolete]
	public static AsyncOperationHandle<IResourceLocator> InitializationOperation { get; }

	// Methods

	// RVA: 0x2350490 Offset: 0x234F690 VA: 0x182350490
	private static AddressablesImpl get_m_Addressables() { }

	// RVA: 0x2350220 Offset: 0x234F420 VA: 0x182350220
	public static ResourceManager get_ResourceManager() { }

	// RVA: 0x234FFD0 Offset: 0x234F1D0 VA: 0x18234FFD0
	internal static AddressablesImpl get_Instance() { }

	// RVA: 0x234FF40 Offset: 0x234F140 VA: 0x18234FF40
	public static IInstanceProvider get_InstanceProvider() { }

	// RVA: 0x234F050 Offset: 0x234E250 VA: 0x18234F050
	public static string ResolveInternalId(string id) { }

	// RVA: 0x2350060 Offset: 0x234F260 VA: 0x182350060
	public static Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	// RVA: 0x23504E0 Offset: 0x234F6E0 VA: 0x1823504E0
	public static void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x23503F0 Offset: 0x234F5F0 VA: 0x1823503F0
	public static Action<UnityWebRequest> get_WebRequestOverride() { }

	// RVA: 0x2350580 Offset: 0x234F780 VA: 0x182350580
	public static void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x2350340 Offset: 0x234F540 VA: 0x182350340
	public static string get_StreamingAssetsSubFolder() { }

	// RVA: 0x234FEB0 Offset: 0x234F0B0 VA: 0x18234FEB0
	public static string get_BuildPath() { }

	// RVA: 0x2350100 Offset: 0x234F300 VA: 0x182350100
	public static string get_PlayerBuildDataPath() { }

	// RVA: 0x23502B0 Offset: 0x234F4B0 VA: 0x1823502B0
	public static string get_RuntimePath() { }

	// RVA: 0x2350190 Offset: 0x234F390 VA: 0x182350190
	public static IEnumerable<IResourceLocator> get_ResourceLocators() { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x234D5C0 Offset: 0x234C7C0 VA: 0x18234D5C0
	internal static void InternalSafeSerializationLog(string msg, LogType logType = 3) { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x234D470 Offset: 0x234C670 VA: 0x18234D470
	internal static void InternalSafeSerializationLogFormat(string format, LogType logType = 3, object[] args) { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x234EAE0 Offset: 0x234DCE0 VA: 0x18234EAE0
	public static void Log(string msg) { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x234E850 Offset: 0x234DA50 VA: 0x18234E850
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x234EA10 Offset: 0x234DC10 VA: 0x18234EA10
	public static void LogWarning(string msg) { }

	// RVA: 0x234E930 Offset: 0x234DB30 VA: 0x18234E930
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x234E5D0 Offset: 0x234D7D0 VA: 0x18234E5D0
	public static void LogError(string msg) { }

	// RVA: 0x234E730 Offset: 0x234D930 VA: 0x18234E730
	public static void LogException(AsyncOperationHandle op, Exception ex) { }

	// RVA: 0x234E6A0 Offset: 0x234D8A0 VA: 0x18234E6A0
	public static void LogException(Exception ex) { }

	// RVA: 0x234E4F0 Offset: 0x234D6F0 VA: 0x18234E4F0
	public static void LogErrorFormat(string format, object[] args) { }

	[Obsolete]
	// RVA: 0x234C510 Offset: 0x234B710 VA: 0x18234C510
	public static AsyncOperationHandle<IResourceLocator> Initialize() { }

	// RVA: 0x234C3F0 Offset: 0x234B5F0 VA: 0x18234C3F0
	public static AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	// RVA: 0x234C2D0 Offset: 0x234B4D0 VA: 0x18234C2D0
	public static AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle) { }

	[Obsolete]
	// RVA: 0x234D8C0 Offset: 0x234CAC0 VA: 0x18234D8C0
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(string catalogPath, string providerSuffix) { }

	// RVA: 0x234D6F0 Offset: 0x234C8F0 VA: 0x18234D6F0
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix) { }

	// RVA: 0x234D7D0 Offset: 0x234C9D0 VA: 0x18234D7D0
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix) { }

	// RVA: 0x9E9120 Offset: 0x9E8320 VA: 0x1809E9120
	public static AsyncOperationHandle<IResourceLocator> get_InitializationOperation() { }

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAsset<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAFE0 Offset: 0x8EA1E0 VA: 0x1808EAFE0
	|-Addressables.LoadAsset<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAsset<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAFE0 Offset: 0x8EA1E0 VA: 0x1808EAFE0
	|-Addressables.LoadAsset<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAE20 Offset: 0x8EA020 VA: 0x1808EAE20
	|-Addressables.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAF00 Offset: 0x8EA100 VA: 0x1808EAF00
	|-Addressables.LoadAssetAsync<object>
	|
	|-RVA: 0x8EAE20 Offset: 0x8EA020 VA: 0x1808EAE20
	|-Addressables.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: 0x234DC90 Offset: 0x234CE90 VA: 0x18234DC90
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(IList<object> keys, Addressables.MergeMode mode, Type type) { }

	[Obsolete]
	// RVA: 0x234DAB0 Offset: 0x234CCB0 VA: 0x18234DAB0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IList<object> keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x234DBA0 Offset: 0x234CDA0 VA: 0x18234DBA0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	[Obsolete]
	// RVA: 0x234DDB0 Offset: 0x234CFB0 VA: 0x18234DDB0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(object key, Type type) { }

	// RVA: 0x234D9D0 Offset: 0x234CBD0 VA: 0x18234D9D0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type) { }

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB550 Offset: 0x8EA750 VA: 0x1808EB550
	|-Addressables.LoadAssets<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB3A0 Offset: 0x8EA5A0 VA: 0x1808EB3A0
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB070 Offset: 0x8EA270 VA: 0x1808EB070
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB490 Offset: 0x8EA690 VA: 0x1808EB490
	|-Addressables.LoadAssets<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB290 Offset: 0x8EA490 VA: 0x1808EB290
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB290 Offset: 0x8EA490 VA: 0x1808EB290
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB180 Offset: 0x8EA380 VA: 0x1808EB180
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB180 Offset: 0x8EA380 VA: 0x1808EB180
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(object key, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB550 Offset: 0x8EA750 VA: 0x1808EB550
	|-Addressables.LoadAssets<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB3A0 Offset: 0x8EA5A0 VA: 0x1808EB3A0
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB070 Offset: 0x8EA270 VA: 0x1808EB070
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Release<TObject>(TObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB5F0 Offset: 0x8EA7F0 VA: 0x1808EB5F0
	|-Addressables.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Release<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB810 Offset: 0x8EAA10 VA: 0x1808EB810
	|-Addressables.Release<long>
	|
	|-RVA: 0x8EB8E0 Offset: 0x8EAAE0 VA: 0x1808EB8E0
	|-Addressables.Release<object>
	|
	|-RVA: 0x8EB740 Offset: 0x8EA940 VA: 0x1808EB740
	|-Addressables.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x234EEF0 Offset: 0x234E0F0 VA: 0x18234EEF0
	public static void Release(AsyncOperationHandle handle) { }

	// RVA: 0x234EBB0 Offset: 0x234DDB0 VA: 0x18234EBB0
	public static bool ReleaseInstance(GameObject instance) { }

	// RVA: 0x234ED70 Offset: 0x234DF70 VA: 0x18234ED70
	public static bool ReleaseInstance(AsyncOperationHandle handle) { }

	// RVA: 0x234EE30 Offset: 0x234E030 VA: 0x18234EE30
	public static bool ReleaseInstance(AsyncOperationHandle<GameObject> handle) { }

	[Obsolete]
	// RVA: 0x234BFE0 Offset: 0x234B1E0 VA: 0x18234BFE0
	public static AsyncOperationHandle<long> GetDownloadSize(object key) { }

	// RVA: 0x234BE90 Offset: 0x234B090 VA: 0x18234BE90
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(object key) { }

	// RVA: 0x234BBC0 Offset: 0x234ADC0 VA: 0x18234BBC0
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(string key) { }

	[Obsolete]
	// RVA: 0x234BDD0 Offset: 0x234AFD0 VA: 0x18234BDD0
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(IList<object> keys) { }

	// RVA: 0x234BD10 Offset: 0x234AF10 VA: 0x18234BD10
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys) { }

	[Obsolete]
	// RVA: 0x234BAC0 Offset: 0x234ACC0 VA: 0x18234BAC0
	public static AsyncOperationHandle DownloadDependencies(object key) { }

	// RVA: 0x234B9E0 Offset: 0x234ABE0 VA: 0x18234B9E0
	public static AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = False) { }

	// RVA: 0x234B810 Offset: 0x234AA10 VA: 0x18234B810
	public static AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = False) { }

	[Obsolete]
	// RVA: 0x234B8F0 Offset: 0x234AAF0 VA: 0x18234B8F0
	public static AsyncOperationHandle DownloadDependenciesAsync(IList<object> keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x234B720 Offset: 0x234A920 VA: 0x18234B720
	public static AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x234B430 Offset: 0x234A630 VA: 0x18234B430
	public static void ClearDependencyCacheAsync(object key) { }

	// RVA: 0x234B380 Offset: 0x234A580 VA: 0x18234B380
	public static void ClearDependencyCacheAsync(IList<IResourceLocation> locations) { }

	[Obsolete]
	// RVA: 0x234B590 Offset: 0x234A790 VA: 0x18234B590
	public static void ClearDependencyCacheAsync(IList<object> keys) { }

	// RVA: 0x234B4E0 Offset: 0x234A6E0 VA: 0x18234B4E0
	public static void ClearDependencyCacheAsync(IEnumerable keys) { }

	// RVA: 0x234B1F0 Offset: 0x234A3F0 VA: 0x18234B1F0
	public static void ClearDependencyCacheAsync(string key) { }

	// RVA: 0x234B110 Offset: 0x234A310 VA: 0x18234B110
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	// RVA: 0x234AE70 Offset: 0x234A070 VA: 0x18234AE70
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	[Obsolete]
	// RVA: 0x234B2A0 Offset: 0x234A4A0 VA: 0x18234B2A0
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<object> keys, bool autoReleaseHandle) { }

	// RVA: 0x234AF50 Offset: 0x234A150 VA: 0x18234AF50
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	// RVA: 0x234B030 Offset: 0x234A230 VA: 0x18234B030
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle) { }

	// RVA: 0x234C230 Offset: 0x234B430 VA: 0x18234C230
	public static ResourceLocatorInfo GetLocatorInfo(string locatorId) { }

	// RVA: 0x234C160 Offset: 0x234B360 VA: 0x18234C160
	public static ResourceLocatorInfo GetLocatorInfo(IResourceLocator locator) { }

	[Obsolete]
	// RVA: 0x234D080 Offset: 0x234C280 VA: 0x18234D080
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x234D2C0 Offset: 0x234C4C0 VA: 0x18234D2C0
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x234CFD0 Offset: 0x234C1D0 VA: 0x18234CFD0
	public static AsyncOperationHandle<GameObject> Instantiate(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x234CF00 Offset: 0x234C100 VA: 0x18234CF00
	public static AsyncOperationHandle<GameObject> Instantiate(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x234D180 Offset: 0x234C380 VA: 0x18234D180
	public static AsyncOperationHandle<GameObject> Instantiate(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x234CE40 Offset: 0x234C040 VA: 0x18234CE40
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x234C960 Offset: 0x234BB60 VA: 0x18234C960
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x234C660 Offset: 0x234B860 VA: 0x18234C660
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x234CBD0 Offset: 0x234BDD0 VA: 0x18234CBD0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x234C7E0 Offset: 0x234B9E0 VA: 0x18234C7E0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x234CAC0 Offset: 0x234BCC0 VA: 0x18234CAC0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x234CD30 Offset: 0x234BF30 VA: 0x18234CD30
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x234E450 Offset: 0x234D650 VA: 0x18234E450
	public static AsyncOperationHandle<SceneInstance> LoadScene(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	[Obsolete]
	// RVA: 0x234E300 Offset: 0x234D500 VA: 0x18234E300
	public static AsyncOperationHandle<SceneInstance> LoadScene(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x234DFC0 Offset: 0x234D1C0 VA: 0x18234DFC0
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x234E200 Offset: 0x234D400 VA: 0x18234E200
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x234E0E0 Offset: 0x234D2E0 VA: 0x18234E0E0
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x234DEC0 Offset: 0x234D0C0 VA: 0x18234DEC0
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100) { }

	[Obsolete]
	// RVA: 0x234F6E0 Offset: 0x234E8E0 VA: 0x18234F6E0
	public static AsyncOperationHandle<SceneInstance> UnloadScene(SceneInstance scene, bool autoReleaseHandle = True) { }

	[Obsolete]
	// RVA: 0x234F800 Offset: 0x234EA00 VA: 0x18234F800
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	[Obsolete]
	// RVA: 0x234F5C0 Offset: 0x234E7C0 VA: 0x18234F5C0
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	// RVA: 0x234F4C0 Offset: 0x234E6C0 VA: 0x18234F4C0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = True) { }

	// RVA: 0x234F1E0 Offset: 0x234E3E0 VA: 0x18234F1E0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = True) { }

	[Obsolete]
	// RVA: 0x234F920 Offset: 0x234EB20 VA: 0x18234F920
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = True) { }

	// RVA: 0x234F2E0 Offset: 0x234E4E0 VA: 0x18234F2E0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = True) { }

	// RVA: 0x234F3D0 Offset: 0x234E5D0 VA: 0x18234F3D0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	// RVA: 0x234F0F0 Offset: 0x234E2F0 VA: 0x18234F0F0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	// RVA: 0x234ACE0 Offset: 0x2349EE0 VA: 0x18234ACE0
	public static AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = True) { }

	// RVA: 0x234FA90 Offset: 0x234EC90 VA: 0x18234FA90
	public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogs, bool autoReleaseHandle = True) { }

	// RVA: 0x234FB70 Offset: 0x234ED70 VA: 0x18234FB70
	public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(bool autoCleanBundleCache, IEnumerable<string> catalogs, bool autoReleaseHandle = True) { }

	// RVA: 0x234AC20 Offset: 0x2349E20 VA: 0x18234AC20
	public static void AddResourceLocator(IResourceLocator locator, string localCatalogHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x234EFB0 Offset: 0x234E1B0 VA: 0x18234EFB0
	public static void RemoveResourceLocator(IResourceLocator locator) { }

	// RVA: 0x234B640 Offset: 0x234A840 VA: 0x18234B640
	public static void ClearResourceLocators() { }

	// RVA: 0x234ADA0 Offset: 0x2349FA0 VA: 0x18234ADA0
	public static AsyncOperationHandle<bool> CleanBundleCache(IEnumerable<string> catalogsIds) { }

	// RVA: -1 Offset: -1
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAD60 Offset: 0x8E9F60 VA: 0x1808EAD60
	|-Addressables.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation remoteCatalogLocation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAD60 Offset: 0x8E9F60 VA: 0x1808EAD60
	|-Addressables.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath, string remoteHashPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAC90 Offset: 0x8E9E90 VA: 0x1808EAC90
	|-Addressables.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x234FC60 Offset: 0x234EE60 VA: 0x18234FC60
	private static void .cctor() { }
}

// Namespace: 
private class AddressablesImpl.LoadResourceLocationKeyOp : AsyncOperationBase<IList<IResourceLocation>> // TypeDefIndex: 16514
{
	// Fields
	private object m_Keys; // 0x88
	private IList<IResourceLocation> m_locations; // 0x90
	private AddressablesImpl m_Addressables; // 0x98
	private Type m_ResourceType; // 0xA0

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x1898C00 Offset: 0x1897E00 VA: 0x181898C00 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x235E470 Offset: 0x235D670 VA: 0x18235E470
	public void Init(AddressablesImpl aa, Type t, object keys) { }

	// RVA: 0x235E490 Offset: 0x235D690 VA: 0x18235E490 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x235E380 Offset: 0x235D580 VA: 0x18235E380 Slot: 28
	protected override void Execute() { }

	// RVA: 0x235E500 Offset: 0x235D700 VA: 0x18235E500
	public void .ctor() { }
}

// Namespace: 
private class AddressablesImpl.LoadResourceLocationKeysOp : AsyncOperationBase<IList<IResourceLocation>> // TypeDefIndex: 16515
{
	// Fields
	private IEnumerable m_Key; // 0x88
	private Addressables.MergeMode m_MergeMode; // 0x90
	private IList<IResourceLocation> m_locations; // 0x98
	private AddressablesImpl m_Addressables; // 0xA0
	private Type m_ResourceType; // 0xA8

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x235E710 Offset: 0x235D910 VA: 0x18235E710 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x235E640 Offset: 0x235D840 VA: 0x18235E640
	public void Init(AddressablesImpl aa, Type t, IEnumerable key, Addressables.MergeMode mergeMode) { }

	// RVA: 0x235E540 Offset: 0x235D740 VA: 0x18235E540 Slot: 28
	protected override void Execute() { }

	// RVA: 0x235E660 Offset: 0x235D860 VA: 0x18235E660 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x235E6D0 Offset: 0x235D8D0 VA: 0x18235E6D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AddressablesImpl.<>c // TypeDefIndex: 16516
{
	// Fields
	public static readonly AddressablesImpl.<>c <>9; // 0x0
	public static Func<ResourceLocatorInfo, IResourceLocator> <>9__59_0; // 0x8
	public static Func<ResourceLocatorInfo, bool> <>9__149_0; // 0x10
	public static Func<ResourceLocatorInfo, string> <>9__149_1; // 0x18
	public static Func<ResourceLocatorInfo, string> <>9__153_0; // 0x20

	// Methods

	// RVA: 0x23631A0 Offset: 0x23623A0 VA: 0x1823631A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x404420 Offset: 0x403620 VA: 0x180404420
	internal IResourceLocator <get_ResourceLocators>b__59_0(ResourceLocatorInfo l) { }

	// RVA: 0x5B93A0 Offset: 0x5B85A0 VA: 0x1805B93A0
	internal bool <get_CatalogsWithAvailableUpdates>b__149_0(ResourceLocatorInfo s) { }

	// RVA: 0x2362170 Offset: 0x2361370 VA: 0x182362170
	internal string <get_CatalogsWithAvailableUpdates>b__149_1(ResourceLocatorInfo s) { }

	// RVA: 0x2362000 Offset: 0x2361200 VA: 0x182362000
	internal string <CleanBundleCache>b__153_0(ResourceLocatorInfo s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass100_0 // TypeDefIndex: 16517
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IResourceLocation catalogLoc; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23621C0 Offset: 0x23613C0 VA: 0x1823621C0
	internal AsyncOperationHandle<long> <ComputeCatalogSizeWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass103_0 // TypeDefIndex: 16518
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23623A0 Offset: 0x23615A0 VA: 0x1823623A0
	internal AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass106_0 // TypeDefIndex: 16519
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23623F0 Offset: 0x23615F0 VA: 0x1823623F0
	internal AsyncOperationHandle<IList<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass110_0 // TypeDefIndex: 16520
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IList<IResourceLocation> locations; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23624A0 Offset: 0x23616A0 VA: 0x1823624A0
	internal AsyncOperationHandle<IList<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass112_0 // TypeDefIndex: 16521
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18
	public Addressables.MergeMode mode; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362550 Offset: 0x2361750 VA: 0x182362550
	internal AsyncOperationHandle<IList<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass117_0<TObject> // TypeDefIndex: 16522
{
	// Fields
	public bool unloadSceneOpExcludeReleaseCallback; // 0x0
	public AddressablesImpl <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AddressablesImpl.<>c__DisplayClass117_0<SceneInstance>..ctor
	|-AddressablesImpl.<>c__DisplayClass117_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <AutoReleaseHandleOnCompletion>b__0(AsyncOperationHandle<TObject> op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB09DC0 Offset: 0xB08FC0 VA: 0x180B09DC0
	|-AddressablesImpl.<>c__DisplayClass117_0<SceneInstance>.<AutoReleaseHandleOnCompletion>b__0
	|
	|-RVA: 0xB09E10 Offset: 0xB09010 VA: 0x180B09E10
	|-AddressablesImpl.<>c__DisplayClass117_0<__Il2CppFullySharedGenericType>.<AutoReleaseHandleOnCompletion>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass119_0 // TypeDefIndex: 16523
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public bool autoReleaseHandle; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362600 Offset: 0x2361800 VA: 0x182362600
	internal AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass120_0 // TypeDefIndex: 16524
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IList<IResourceLocation> locations; // 0x18
	public bool autoReleaseHandle; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23627C0 Offset: 0x23619C0 VA: 0x1823627C0
	internal AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass121_0 // TypeDefIndex: 16525
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18
	public bool autoReleaseHandle; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362810 Offset: 0x2361A10 VA: 0x182362810
	internal AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass126_0 // TypeDefIndex: 16526
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public InstantiationParameters instantiateParameters; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362860 Offset: 0x2361A60 VA: 0x182362860
	internal AsyncOperationHandle<GameObject> <InstantiateWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass128_0 // TypeDefIndex: 16527
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IResourceLocation location; // 0x18
	public InstantiationParameters instantiateParameters; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23628E0 Offset: 0x2361AE0 VA: 0x1823628E0
	internal AsyncOperationHandle<GameObject> <InstantiateWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass131_0 // TypeDefIndex: 16528
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public LoadSceneParameters loadSceneParameters; // 0x20
	public bool activateOnLoad; // 0x28
	public int priority; // 0x2C

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362960 Offset: 0x2361B60 VA: 0x182362960
	internal AsyncOperationHandle<SceneInstance> <LoadSceneWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass132_0 // TypeDefIndex: 16529
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IResourceLocation key; // 0x18
	public LoadSceneMode loadMode; // 0x20
	public bool activateOnLoad; // 0x24
	public int priority; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23629D0 Offset: 0x2361BD0 VA: 0x1823629D0
	internal AsyncOperationHandle<SceneInstance> <LoadSceneWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass141_0 // TypeDefIndex: 16530
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public UnloadSceneOptions unloadOptions; // 0x18
	public bool autoReleaseHandle; // 0x1C

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362A80 Offset: 0x2361C80 VA: 0x182362A80
	internal AsyncOperationHandle<SceneInstance> <CreateUnloadSceneWithChain>b__0(AsyncOperationHandle completedHandle) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass142_0 // TypeDefIndex: 16531
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public UnloadSceneOptions unloadOptions; // 0x18
	public bool autoReleaseHandle; // 0x1C

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362BC0 Offset: 0x2361DC0 VA: 0x182362BC0
	internal AsyncOperationHandle<SceneInstance> <CreateUnloadSceneWithChain>b__0(AsyncOperationHandle<SceneInstance> completedHandle) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass146_0 // TypeDefIndex: 16532
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public bool autoReleaseHandle; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362CD0 Offset: 0x2361ED0 VA: 0x182362CD0
	internal AsyncOperationHandle<List<string>> <CheckForCatalogUpdatesWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass150_0 // TypeDefIndex: 16533
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public bool autoReleaseHandle; // 0x18
	public bool autoCleanBundleCache; // 0x19

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362D20 Offset: 0x2361F20 VA: 0x182362D20
	internal AsyncOperationHandle<List<IResourceLocator>> <UpdateCatalogs>b__0(AsyncOperationHandle<List<string>> depOp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass155_0 // TypeDefIndex: 16534
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public AsyncOperationHandle<IList<AsyncOperationHandle>> depOp; // 0x18
	public bool forceSingleThreading; // 0x38

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362DA0 Offset: 0x2361FA0 VA: 0x182362DA0
	internal AsyncOperationHandle<bool> <CleanBundleCacheWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass156_0 // TypeDefIndex: 16535
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable<string> catalogIds; // 0x18
	public bool forceSingleThreading; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362E10 Offset: 0x2362010 VA: 0x182362E10
	internal AsyncOperationHandle<bool> <CleanBundleCacheWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass61_0 // TypeDefIndex: 16536
{
	// Fields
	public IResourceLocator loc; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x73A270 Offset: 0x739470 VA: 0x18073A270
	internal bool <RemoveResourceLocator>b__0(ResourceLocatorInfo l) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass72_0 // TypeDefIndex: 16537
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public string catalogPath; // 0x18
	public bool autoReleaseHandle; // 0x20
	public string providerSuffix; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362FB0 Offset: 0x23621B0 VA: 0x182362FB0
	internal AsyncOperationHandle<IResourceLocator> <LoadContentCatalogAsync>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass78_0<TObject> // TypeDefIndex: 16538
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public IResourceLocation loc; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AddressablesImpl.<>c__DisplayClass78_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> <LoadAssetWithChain>b__0(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB10480 Offset: 0xB0F680 VA: 0x180B10480
	|-AddressablesImpl.<>c__DisplayClass78_0<__Il2CppFullySharedGenericType>.<LoadAssetWithChain>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass79_0<TObject> // TypeDefIndex: 16539
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public object key; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AddressablesImpl.<>c__DisplayClass79_0<object>..ctor
	|-AddressablesImpl.<>c__DisplayClass79_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> <LoadAssetWithChain>b__0(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB104E0 Offset: 0xB0F6E0 VA: 0x180B104E0
	|-AddressablesImpl.<>c__DisplayClass79_0<object>.<LoadAssetWithChain>b__0
	|
	|-RVA: 0xB10480 Offset: 0xB0F680 VA: 0x180B10480
	|-AddressablesImpl.<>c__DisplayClass79_0<__Il2CppFullySharedGenericType>.<LoadAssetWithChain>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass83_0 // TypeDefIndex: 16540
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18
	public Addressables.MergeMode mode; // 0x20
	public Type type; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2363010 Offset: 0x2362210 VA: 0x182363010
	internal AsyncOperationHandle<IList<IResourceLocation>> <LoadResourceLocationsWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass85_0 // TypeDefIndex: 16541
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public Type type; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2363070 Offset: 0x2362270 VA: 0x182363070
	internal AsyncOperationHandle<IList<IResourceLocation>> <LoadResourceLocationsWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass88_0<TObject> // TypeDefIndex: 16542
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public IList<IResourceLocation> locations; // 0x0
	public Action<TObject> callback; // 0x0
	public bool releaseDependenciesOnFailure; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AddressablesImpl.<>c__DisplayClass88_0<object>..ctor
	|-AddressablesImpl.<>c__DisplayClass88_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<TObject>> <LoadAssetsWithChain>b__0(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB12390 Offset: 0xB11590 VA: 0x180B12390
	|-AddressablesImpl.<>c__DisplayClass88_0<object>.<LoadAssetsWithChain>b__0
	|
	|-RVA: 0xB12400 Offset: 0xB11600 VA: 0x180B12400
	|-AddressablesImpl.<>c__DisplayClass88_0<__Il2CppFullySharedGenericType>.<LoadAssetsWithChain>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass89_0<TObject> // TypeDefIndex: 16543
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public IEnumerable keys; // 0x0
	public Action<TObject> callback; // 0x0
	public Addressables.MergeMode mode; // 0x0
	public bool releaseDependenciesOnFailure; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AddressablesImpl.<>c__DisplayClass89_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<TObject>> <LoadAssetsWithChain>b__0(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB12460 Offset: 0xB11660 VA: 0x180B12460
	|-AddressablesImpl.<>c__DisplayClass89_0<__Il2CppFullySharedGenericType>.<LoadAssetsWithChain>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass91_0<TObject> // TypeDefIndex: 16544
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public object key; // 0x0
	public Action<TObject> callback; // 0x0
	public bool releaseDependenciesOnFailure; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AddressablesImpl.<>c__DisplayClass91_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<TObject>> <LoadAssetsWithChain>b__0(AsyncOperationHandle op2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB12400 Offset: 0xB11600 VA: 0x180B12400
	|-AddressablesImpl.<>c__DisplayClass91_0<__Il2CppFullySharedGenericType>.<LoadAssetsWithChain>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass99_0 // TypeDefIndex: 16545
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23630C0 Offset: 0x23622C0 VA: 0x1823630C0
	internal AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: UnityEngine.AddressableAssets
internal class AddressablesImpl : IEqualityComparer<IResourceLocation> // TypeDefIndex: 16546
{
	// Fields
	private ResourceManager m_ResourceManager; // 0x10
	private IInstanceProvider m_InstanceProvider; // 0x18
	private int m_CatalogRequestsTimeout; // 0x20
	internal const string kCacheDataFolder = "{UnityEngine.Application.persistentDataPath}/com.unity.addressables/";
	public ISceneProvider SceneProvider; // 0x28
	internal List<ResourceLocatorInfo> m_ResourceLocators; // 0x30
	private AsyncOperationHandle<IResourceLocator> m_InitializationOperation; // 0x38
	private AsyncOperationHandle<List<string>> m_ActiveCheckUpdateOperation; // 0x58
	internal AsyncOperationHandle<List<IResourceLocator>> m_ActiveUpdateOperation; // 0x78
	private Action<AsyncOperationHandle> m_OnHandleCompleteAction; // 0x98
	private Action<AsyncOperationHandle> m_OnSceneHandleCompleteAction; // 0xA0
	private Action<AsyncOperationHandle> m_OnHandleDestroyedAction; // 0xA8
	private Dictionary<object, AsyncOperationHandle> m_resultToHandle; // 0xB0
	internal HashSet<AsyncOperationHandle> m_SceneInstances; // 0xB8
	private AsyncOperationHandle<bool> m_ActiveCleanBundleCacheOperation; // 0xC0
	internal bool hasStartedInitialization; // 0xE0

	// Properties
	public IInstanceProvider InstanceProvider { get; set; }
	public ResourceManager ResourceManager { get; }
	public int CatalogRequestsTimeout { get; set; }
	internal int SceneOperationCount { get; }
	internal int TrackedHandleCount { get; }
	public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public Action<UnityWebRequest> WebRequestOverride { get; set; }
	public AsyncOperationHandle ChainOperation { get; }
	internal bool ShouldChainRequest { get; }
	public string StreamingAssetsSubFolder { get; }
	public string BuildPath { get; }
	public string PlayerBuildDataPath { get; }
	public string RuntimePath { get; }
	public IEnumerable<IResourceLocator> ResourceLocators { get; }
	internal IEnumerable<string> CatalogsWithAvailableUpdates { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IInstanceProvider get_InstanceProvider() { }

	// RVA: 0x2349E30 Offset: 0x2349030 VA: 0x182349E30
	public void set_InstanceProvider(IInstanceProvider value) { }

	// RVA: 0x2349BE0 Offset: 0x2348DE0 VA: 0x182349BE0
	public ResourceManager get_ResourceManager() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_CatalogRequestsTimeout() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_CatalogRequestsTimeout(int value) { }

	// RVA: 0x2349C90 Offset: 0x2348E90 VA: 0x182349C90
	internal int get_SceneOperationCount() { }

	// RVA: 0x2349DC0 Offset: 0x2348FC0 VA: 0x182349DC0
	internal int get_TrackedHandleCount() { }

	// RVA: 0x2349290 Offset: 0x2348490 VA: 0x182349290
	public void .ctor(IAllocationStrategy alloc) { }

	// RVA: 0x23483C0 Offset: 0x23475C0 VA: 0x1823483C0
	internal void ReleaseSceneManagerOperation() { }

	// RVA: 0x2349A30 Offset: 0x2348C30 VA: 0x182349A30
	public Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	// RVA: 0x2349EA0 Offset: 0x23490A0 VA: 0x182349EA0
	public void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x2349E10 Offset: 0x2349010 VA: 0x182349E10
	public Action<UnityWebRequest> get_WebRequestOverride() { }

	// RVA: 0x2349ED0 Offset: 0x23490D0 VA: 0x182349ED0
	public void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x2349830 Offset: 0x2348A30 VA: 0x182349830
	public AsyncOperationHandle get_ChainOperation() { }

	// RVA: 0x2349CD0 Offset: 0x2348ED0 VA: 0x182349CD0
	internal bool get_ShouldChainRequest() { }

	// RVA: 0x2347ED0 Offset: 0x23470D0 VA: 0x182347ED0
	internal void OnSceneUnloaded(Scene scene) { }

	// RVA: 0x2349D90 Offset: 0x2348F90 VA: 0x182349D90
	public string get_StreamingAssetsSubFolder() { }

	// RVA: 0x2349420 Offset: 0x2348620 VA: 0x182349420
	public string get_BuildPath() { }

	// RVA: 0x2349A50 Offset: 0x2348C50 VA: 0x182349A50
	public string get_PlayerBuildDataPath() { }

	// RVA: 0x2349C80 Offset: 0x2348E80 VA: 0x182349C80
	public string get_RuntimePath() { }

	// RVA: 0x2347BE0 Offset: 0x2346DE0 VA: 0x182347BE0
	public void Log(string msg) { }

	// RVA: 0x2347AD0 Offset: 0x2346CD0 VA: 0x182347AD0
	public void LogFormat(string format, object[] args) { }

	// RVA: 0x2347B90 Offset: 0x2346D90 VA: 0x182347B90
	public void LogWarning(string msg) { }

	// RVA: 0x2347B30 Offset: 0x2346D30 VA: 0x182347B30
	public void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x23479F0 Offset: 0x2346BF0 VA: 0x1823479F0
	public void LogError(string msg) { }

	// RVA: 0x2347A40 Offset: 0x2346C40 VA: 0x182347A40
	public void LogException(AsyncOperationHandle op, Exception ex) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void LogException(Exception ex) { }

	// RVA: 0x2347990 Offset: 0x2346B90 VA: 0x182347990
	public void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x2348560 Offset: 0x2347760 VA: 0x182348560
	public string ResolveInternalId(string id) { }

	// RVA: 0x2349AE0 Offset: 0x2348CE0 VA: 0x182349AE0
	public IEnumerable<IResourceLocator> get_ResourceLocators() { }

	// RVA: 0x233EE90 Offset: 0x233E090 VA: 0x18233EE90
	public void AddResourceLocator(IResourceLocator loc, string localCatalogHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x2348490 Offset: 0x2347690 VA: 0x182348490
	public void RemoveResourceLocator(IResourceLocator loc) { }

	// RVA: 0x23410E0 Offset: 0x23402E0 VA: 0x1823410E0
	public void ClearResourceLocators() { }

	// RVA: 0x2344290 Offset: 0x2343490 VA: 0x182344290
	internal bool GetResourceLocations(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x2344800 Offset: 0x2343A00 VA: 0x182344800
	internal bool GetResourceLocations(IEnumerable keys, Type type, Addressables.MergeMode merge, out IList<IResourceLocation> locations) { }

	// RVA: 0x2344C70 Offset: 0x2343E70 VA: 0x182344C70
	public AsyncOperationHandle<IResourceLocator> InitializeAsync(string runtimeDataPath, string providerSuffix, bool autoReleaseHandle = True) { }

	// RVA: 0x2344B20 Offset: 0x2343D20 VA: 0x182344B20
	public AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	// RVA: 0x2344BC0 Offset: 0x2343DC0 VA: 0x182344BC0
	public AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle) { }

	// RVA: -1 Offset: -1
	public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation catalogLocation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E7380 Offset: 0x8E6580 VA: 0x1808E7380
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogLocation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E7400 Offset: 0x8E6600 VA: 0x1808E7400
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<object>
	|
	|-RVA: 0x8E6ED0 Offset: 0x8E60D0 VA: 0x1808E6ED0
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogPath, string hashFilePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E6F70 Offset: 0x8E6170 VA: 0x1808E6F70
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<object>
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void QueueEditorUpdateIfNeeded() { }

	// RVA: 0x23463E0 Offset: 0x23455E0 VA: 0x1823463E0
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle = True, string providerSuffix) { }

	// RVA: 0x2348700 Offset: 0x2347900 VA: 0x182348700
	private AsyncOperationHandle<SceneInstance> TrackHandle(AsyncOperationHandle<SceneInstance> handle) { }

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> TrackHandle<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAA10 Offset: 0x8E9C10 VA: 0x1808EAA10
	|-AddressablesImpl.TrackHandle<long>
	|-AddressablesImpl.TrackHandle<object>
	|
	|-RVA: 0x8EA9A0 Offset: 0x8E9BA0 VA: 0x1808EA9A0
	|-AddressablesImpl.TrackHandle<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23486C0 Offset: 0x23478C0 VA: 0x1823486C0
	private AsyncOperationHandle TrackHandle(AsyncOperationHandle handle) { }

	// RVA: 0x2341140 Offset: 0x2340340 VA: 0x182341140
	internal void ClearTrackHandles() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E7490 Offset: 0x8E6690 VA: 0x1808E7490
	|-AddressablesImpl.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, IResourceLocation loc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E8510 Offset: 0x8E7710 VA: 0x1808E8510
	|-AddressablesImpl.LoadAssetWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E8650 Offset: 0x8E7850 VA: 0x1808E8650
	|-AddressablesImpl.LoadAssetWithChain<object>
	|
	|-RVA: 0x8E8510 Offset: 0x8E7710 VA: 0x1808E8510
	|-AddressablesImpl.LoadAssetWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E7D20 Offset: 0x8E6F20 VA: 0x1808E7D20
	|-AddressablesImpl.LoadAssetAsync<object>
	|
	|-RVA: 0x8E75C0 Offset: 0x8E67C0 VA: 0x1808E75C0
	|-AddressablesImpl.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2346E20 Offset: 0x2346020 VA: 0x182346E20
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x2346600 Offset: 0x2345800 VA: 0x182346600
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x2346C70 Offset: 0x2345E70 VA: 0x182346C70
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, object key, Type type) { }

	// RVA: 0x2346940 Offset: 0x2345B40 VA: 0x182346940
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E8E30 Offset: 0x8E8030 VA: 0x1808E8E30
	|-AddressablesImpl.LoadAssetsAsync<object>
	|
	|-RVA: 0x8E8790 Offset: 0x8E7990 VA: 0x1808E8790
	|-AddressablesImpl.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E9320 Offset: 0x8E8520 VA: 0x1808E9320
	|-AddressablesImpl.LoadAssetsWithChain<object>
	|
	|-RVA: 0x8E9070 Offset: 0x8E8270 VA: 0x1808E9070
	|-AddressablesImpl.LoadAssetsWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E91C0 Offset: 0x8E83C0 VA: 0x1808E91C0
	|-AddressablesImpl.LoadAssetsWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E8900 Offset: 0x8E7B00 VA: 0x1808E8900
	|-AddressablesImpl.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E9070 Offset: 0x8E8270 VA: 0x1808E9070
	|-AddressablesImpl.LoadAssetsWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E8BA0 Offset: 0x8E7DA0 VA: 0x1808E8BA0
	|-AddressablesImpl.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2347D20 Offset: 0x2346F20 VA: 0x182347D20
	private void OnHandleDestroyed(AsyncOperationHandle handle) { }

	// RVA: 0x2347DA0 Offset: 0x2346FA0 VA: 0x182347DA0
	private void OnSceneHandleCompleted(AsyncOperationHandle handle) { }

	// RVA: 0x2347C30 Offset: 0x2346E30 VA: 0x182347C30
	private void OnHandleCompleted(AsyncOperationHandle handle) { }

	// RVA: -1 Offset: -1
	public void Release<TObject>(TObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E9C50 Offset: 0x8E8E50 VA: 0x1808E9C50
	|-AddressablesImpl.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Release<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E9470 Offset: 0x8E8670 VA: 0x1808E9470
	|-AddressablesImpl.Release<bool>
	|
	|-RVA: 0x8E9DE0 Offset: 0x8E8FE0 VA: 0x1808E9DE0
	|-AddressablesImpl.Release<long>
	|
	|-RVA: 0x8EA1C0 Offset: 0x8E93C0 VA: 0x1808EA1C0
	|-AddressablesImpl.Release<object>
	|
	|-RVA: 0x8EA5A0 Offset: 0x8E97A0 VA: 0x1808EA5A0
	|-AddressablesImpl.Release<SceneInstance>
	|
	|-RVA: 0x8E9850 Offset: 0x8E8A50 VA: 0x1808E9850
	|-AddressablesImpl.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2348450 Offset: 0x2347650 VA: 0x182348450
	public void Release(AsyncOperationHandle handle) { }

	// RVA: 0x2343A10 Offset: 0x2342C10 VA: 0x182343A10
	private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, object key) { }

	// RVA: 0x2341190 Offset: 0x2340390 VA: 0x182341190
	private AsyncOperationHandle<long> ComputeCatalogSizeWithChain(IResourceLocation catalogLoc) { }

	// RVA: 0x2346230 Offset: 0x2345430 VA: 0x182346230
	internal bool IsCatalogCached(IResourceLocation catalogLoc, Hash128 remoteHash) { }

	// RVA: 0x2343F80 Offset: 0x2343180 VA: 0x182343F80
	internal AsyncOperationHandle<long> GetRemoteCatalogHeaderSize(IResourceLocation catalogLoc) { }

	// RVA: 0x2343BB0 Offset: 0x2342DB0 VA: 0x182343BB0
	private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, IEnumerable keys) { }

	// RVA: 0x2342D90 Offset: 0x2341F90 VA: 0x182342D90
	public AsyncOperationHandle<long> GetDownloadSizeAsync(object key) { }

	// RVA: 0x2342E60 Offset: 0x2342060 VA: 0x182342E60
	public AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys) { }

	// RVA: 0x2341A90 Offset: 0x2340C90 VA: 0x182341A90
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, object key, bool autoReleaseHandle) { }

	// RVA: 0x23491C0 Offset: 0x23483C0 VA: 0x1823491C0
	internal static void WrapAsDownloadLocations(List<IResourceLocation> locations) { }

	// RVA: 0x2342970 Offset: 0x2341B70 VA: 0x182342970
	private static List<IResourceLocation> GatherDependenciesFromLocations(IList<IResourceLocation> locations) { }

	// RVA: 0x2341FD0 Offset: 0x23411D0 VA: 0x182341FD0
	public AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = False) { }

	// RVA: 0x2341870 Offset: 0x2340A70 VA: 0x182341870
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	// RVA: 0x2341CB0 Offset: 0x2340EB0 VA: 0x182341CB0
	public AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = False) { }

	// RVA: 0x23416B0 Offset: 0x23408B0 VA: 0x1823416B0
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle) { }

	// RVA: 0x23423B0 Offset: 0x23415B0 VA: 0x1823423B0
	public AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x2340A50 Offset: 0x233FC50 VA: 0x182340A50
	internal bool ClearDependencyCacheForKey(object key) { }

	// RVA: 0x233EF80 Offset: 0x233E180 VA: 0x18233EF80
	internal void AutoReleaseHandleOnCompletion(AsyncOperationHandle handle) { }

	// RVA: -1 Offset: -1
	internal void AutoReleaseHandleOnCompletion<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E6980 Offset: 0x8E5B80 VA: 0x1808E6980
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<bool>
	|
	|-RVA: 0x8E6BA0 Offset: 0x8E5DA0 VA: 0x1808E6BA0
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<long>
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<object>
	|
	|-RVA: 0x8E6C30 Offset: 0x8E5E30 VA: 0x1808E6C30
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<SceneInstance>
	|
	|-RVA: 0x8E6A10 Offset: 0x8E5C10 VA: 0x1808E6A10
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void AutoReleaseHandleOnCompletion<TObject>(AsyncOperationHandle<TObject> handle, bool unloadSceneOpExcludeReleaseCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E6CC0 Offset: 0x8E5EC0 VA: 0x1808E6CC0
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<SceneInstance>
	|
	|-RVA: 0x8E6AB0 Offset: 0x8E5CB0 VA: 0x1808E6AB0
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void AutoReleaseHandleOnTypelessCompletion<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E6E40 Offset: 0x8E6040 VA: 0x1808E6E40
	|-AddressablesImpl.AutoReleaseHandleOnTypelessCompletion<object>
	|
	|-RVA: 0x8E6DB0 Offset: 0x8E5FB0 VA: 0x1808E6DB0
	|-AddressablesImpl.AutoReleaseHandleOnTypelessCompletion<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2340820 Offset: 0x233FA20 VA: 0x182340820
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	// RVA: 0x233FFD0 Offset: 0x233F1D0 VA: 0x18233FFD0
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	// RVA: 0x23403E0 Offset: 0x233F5E0 VA: 0x1823403E0
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	// RVA: 0x2345C90 Offset: 0x2344E90 VA: 0x182345C90
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x23450F0 Offset: 0x23442F0 VA: 0x1823450F0
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x23454E0 Offset: 0x23446E0 VA: 0x1823454E0
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x23455B0 Offset: 0x23447B0 VA: 0x1823455B0
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x2345D60 Offset: 0x2344F60 VA: 0x182345D60
	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x23456A0 Offset: 0x23448A0 VA: 0x1823456A0
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x2345F50 Offset: 0x2345150 VA: 0x182345F50
	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x23451E0 Offset: 0x23443E0 VA: 0x1823451E0
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x2348290 Offset: 0x2347490 VA: 0x182348290
	public bool ReleaseInstance(GameObject instance) { }

	// RVA: 0x23477B0 Offset: 0x23469B0 VA: 0x1823477B0
	internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x23475D0 Offset: 0x23467D0 VA: 0x1823475D0
	internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, IResourceLocation key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x2346FD0 Offset: 0x23461D0 VA: 0x182346FD0
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key) { }

	// RVA: 0x2347210 Offset: 0x2346410 VA: 0x182347210
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x2347540 Offset: 0x2346740 VA: 0x182347540
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location) { }

	// RVA: 0x23474A0 Offset: 0x23466A0 VA: 0x1823474A0
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x2347060 Offset: 0x2346260 VA: 0x182347060
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x2348AC0 Offset: 0x2347CC0 VA: 0x182348AC0
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = True) { }

	// RVA: 0x2348980 Offset: 0x2347B80 VA: 0x182348980
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = True) { }

	// RVA: 0x2348CE0 Offset: 0x2347EE0 VA: 0x182348CE0
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = True) { }

	// RVA: 0x2341570 Offset: 0x2340770 VA: 0x182341570
	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	// RVA: 0x2341440 Offset: 0x2340640 VA: 0x182341440
	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	// RVA: 0x2346140 Offset: 0x2345340 VA: 0x182346140
	internal AsyncOperationHandle<SceneInstance> InternalUnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	// RVA: 0x23428E0 Offset: 0x2341AE0 VA: 0x1823428E0
	private object EvaluateKey(object obj) { }

	// RVA: 0x233F150 Offset: 0x233E350 VA: 0x18233F150
	internal AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = True) { }

	// RVA: 0x233F000 Offset: 0x233E200 VA: 0x18233F000
	internal AsyncOperationHandle<List<string>> CheckForCatalogUpdatesWithChain(bool autoReleaseHandle) { }

	// RVA: 0x2343E00 Offset: 0x2343000 VA: 0x182343E00
	public ResourceLocatorInfo GetLocatorInfo(string c) { }

	// RVA: 0x2349670 Offset: 0x2348870 VA: 0x182349670
	internal IEnumerable<string> get_CatalogsWithAvailableUpdates() { }

	// RVA: 0x2348F10 Offset: 0x2348110 VA: 0x182348F10
	internal AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogIds, bool autoReleaseHandle = True, bool autoCleanBundleCache = False) { }

	// RVA: 0x23427A0 Offset: 0x23419A0 VA: 0x1823427A0 Slot: 4
	public bool Equals(IResourceLocation x, IResourceLocation y) { }

	// RVA: 0x2343D50 Offset: 0x2342F50 VA: 0x182343D50 Slot: 5
	public int GetHashCode(IResourceLocation loc) { }

	// RVA: 0x233F690 Offset: 0x233E890 VA: 0x18233F690
	internal AsyncOperationHandle<bool> CleanBundleCache(IEnumerable<string> catalogIds, bool forceSingleThreading) { }

	// RVA: 0x233FBF0 Offset: 0x233EDF0 VA: 0x18233FBF0
	internal AsyncOperationHandle<bool> CleanBundleCache(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool forceSingleThreading) { }

	// RVA: 0x233F530 Offset: 0x233E730 VA: 0x18233F530
	internal AsyncOperationHandle<bool> CleanBundleCacheWithChain(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool forceSingleThreading) { }

	// RVA: 0x233F3D0 Offset: 0x233E5D0 VA: 0x18233F3D0
	internal AsyncOperationHandle<bool> CleanBundleCacheWithChain(IEnumerable<string> catalogIds, bool forceSingleThreading) { }

	[CompilerGenerated]
	// RVA: 0x23488E0 Offset: 0x2347AE0 VA: 0x1823488E0
	private void <TrackHandle>b__73_0(AsyncOperationHandle<SceneInstance> sceneHandle) { }

	[CompilerGenerated]
	// RVA: 0x23487B0 Offset: 0x23479B0 VA: 0x1823487B0
	private AsyncOperationHandle<long> <GetRemoteCatalogHeaderSize>b__102_0(AsyncOperationHandle<UnityWebRequest> getOp) { }

	[CompilerGenerated]
	// RVA: 0x2348450 Offset: 0x2347650 VA: 0x182348450
	private void <AutoReleaseHandleOnCompletion>b__115_0(AsyncOperationHandle op) { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <AutoReleaseHandleOnCompletion>b__116_0<TObject>(AsyncOperationHandle<TObject> op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAA80 Offset: 0x8E9C80 VA: 0x1808EAA80
	|-AddressablesImpl.<AutoReleaseHandleOnCompletion>b__116_0<bool>
	|
	|-RVA: 0x8EAB40 Offset: 0x8E9D40 VA: 0x1808EAB40
	|-AddressablesImpl.<AutoReleaseHandleOnCompletion>b__116_0<long>
	|
	|-RVA: 0x8EABA0 Offset: 0x8E9DA0 VA: 0x1808EABA0
	|-AddressablesImpl.<AutoReleaseHandleOnCompletion>b__116_0<object>
	|
	|-RVA: 0x8EAC00 Offset: 0x8E9E00 VA: 0x1808EAC00
	|-AddressablesImpl.<AutoReleaseHandleOnCompletion>b__116_0<SceneInstance>
	|
	|-RVA: 0x8EAAE0 Offset: 0x8E9CE0 VA: 0x1808EAAE0
	|-AddressablesImpl.<AutoReleaseHandleOnCompletion>b__116_0<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <AutoReleaseHandleOnTypelessCompletion>b__118_0<TObject>(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAC60 Offset: 0x8E9E60 VA: 0x1808EAC60
	|-AddressablesImpl.<AutoReleaseHandleOnTypelessCompletion>b__118_0<object>
	|-AddressablesImpl.<AutoReleaseHandleOnTypelessCompletion>b__118_0<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetLabelReference : IKeyEvaluator // TypeDefIndex: 16547
{
	// Fields
	[FormerlySerializedAs("m_labelString")]
	[SerializeField]
	private string m_LabelString; // 0x10

	// Properties
	public string labelString { get; set; }
	public object RuntimeKey { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_labelString() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_labelString(string value) { }

	// RVA: 0x23506A0 Offset: 0x234F8A0 VA: 0x1823506A0 Slot: 4
	public object get_RuntimeKey() { }

	// RVA: 0x2350620 Offset: 0x234F820 VA: 0x182350620 Slot: 5
	public bool RuntimeKeyIsValid() { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceT<TObject> : AssetReference // TypeDefIndex: 16548
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE52C40 Offset: 0xE51E40 VA: 0x180E52C40
	|-AssetReferenceT<object>..ctor
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAsset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE52B50 Offset: 0xE51D50 VA: 0x180E52B50
	|-AssetReferenceT<object>.LoadAsset
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public virtual AsyncOperationHandle<TObject> LoadAssetAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE52AE0 Offset: 0xE51CE0 VA: 0x180E52AE0
	|-AssetReferenceT<object>.LoadAssetAsync
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public override bool ValidateAsset(Object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE52B90 Offset: 0xE51D90 VA: 0x180E52B90
	|-AssetReferenceT<object>.ValidateAsset
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public override bool ValidateAsset(string mainAssetPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-AssetReferenceT<object>.ValidateAsset
	*/
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceGameObject : AssetReferenceT<GameObject> // TypeDefIndex: 16549
{
	// Methods

	// RVA: 0x23507C0 Offset: 0x234F9C0 VA: 0x1823507C0
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceTexture : AssetReferenceT<Texture> // TypeDefIndex: 16550
{
	// Methods

	// RVA: 0x2350900 Offset: 0x234FB00 VA: 0x182350900
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceTexture2D : AssetReferenceT<Texture2D> // TypeDefIndex: 16551
{
	// Methods

	// RVA: 0x2350860 Offset: 0x234FA60 VA: 0x182350860
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceTexture3D : AssetReferenceT<Texture3D> // TypeDefIndex: 16552
{
	// Methods

	// RVA: 0x23508B0 Offset: 0x234FAB0 VA: 0x1823508B0
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceSprite : AssetReferenceT<Sprite> // TypeDefIndex: 16553
{
	// Methods

	// RVA: 0x2350810 Offset: 0x234FA10 VA: 0x182350810
	public void .ctor(string guid) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 21
	public override bool ValidateAsset(string path) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceAtlasedSprite : AssetReferenceT<Sprite> // TypeDefIndex: 16554
{
	// Methods

	// RVA: 0x2350770 Offset: 0x234F970 VA: 0x182350770
	public void .ctor(string guid) { }

	// RVA: 0x23506F0 Offset: 0x234F8F0 VA: 0x1823506F0 Slot: 20
	public override bool ValidateAsset(Object obj) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 21
	public override bool ValidateAsset(string path) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReference : IKeyEvaluator // TypeDefIndex: 16555
{
	// Fields
	[FormerlySerializedAs("m_assetGUID")]
	[SerializeField]
	protected internal string m_AssetGUID; // 0x10
	[SerializeField]
	private string m_SubObjectName; // 0x18
	[SerializeField]
	private string m_SubObjectType; // 0x20
	private AsyncOperationHandle m_Operation; // 0x28

	// Properties
	public AsyncOperationHandle OperationHandle { get; set; }
	public virtual object RuntimeKey { get; }
	public virtual string AssetGUID { get; }
	public virtual string SubObjectName { get; set; }
	internal virtual Type SubOjbectType { get; }
	public bool IsDone { get; }
	public virtual Object Asset { get; }

	// Methods

	// RVA: 0x4E6990 Offset: 0x4E5B90 VA: 0x1804E6990
	public AsyncOperationHandle get_OperationHandle() { }

	// RVA: 0x4E69B0 Offset: 0x4E5BB0 VA: 0x1804E69B0
	internal void set_OperationHandle(AsyncOperationHandle value) { }

	// RVA: 0x23515B0 Offset: 0x23507B0 VA: 0x1823515B0 Slot: 6
	public virtual object get_RuntimeKey() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 7
	public virtual string get_AssetGUID() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public virtual string get_SubObjectName() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70 Slot: 9
	public virtual void set_SubObjectName(string value) { }

	// RVA: 0x2351640 Offset: 0x2350840 VA: 0x182351640 Slot: 10
	internal virtual Type get_SubOjbectType() { }

	// RVA: 0x2350CE0 Offset: 0x234FEE0 VA: 0x182350CE0
	public bool IsValid() { }

	// RVA: 0x23515A0 Offset: 0x23507A0 VA: 0x1823515A0
	public bool get_IsDone() { }

	// RVA: 0x2351420 Offset: 0x2350620 VA: 0x182351420
	public void .ctor() { }

	// RVA: 0x2351460 Offset: 0x2350660 VA: 0x182351460
	public void .ctor(string guid) { }

	// RVA: 0x23514B0 Offset: 0x23506B0 VA: 0x1823514B0
	internal void .ctor(string guid, Type type) { }

	// RVA: 0x2351500 Offset: 0x2350700 VA: 0x182351500 Slot: 11
	public virtual Object get_Asset() { }

	// RVA: 0x23512A0 Offset: 0x23504A0 VA: 0x1823512A0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static AsyncOperationHandle<T> CreateFailedOperation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93B8F0 Offset: 0x93AAF0 VA: 0x18093B8F0
	|-AssetReference.CreateFailedOperation<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAsset<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93BD30 Offset: 0x93AF30 VA: 0x18093BD30
	|-AssetReference.LoadAsset<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: 0x2350E60 Offset: 0x2350060 VA: 0x182350E60
	public AsyncOperationHandle<SceneInstance> LoadScene() { }

	[Obsolete]
	// RVA: 0x2350C60 Offset: 0x234FE60 VA: 0x182350C60
	public AsyncOperationHandle<GameObject> Instantiate(Vector3 position, Quaternion rotation, Transform parent) { }

	[Obsolete]
	// RVA: 0x2350C20 Offset: 0x234FE20 VA: 0x182350C20
	public AsyncOperationHandle<GameObject> Instantiate(Transform parent, bool instantiateInWorldSpace = False) { }

	// RVA: -1 Offset: -1 Slot: 12
	public virtual AsyncOperationHandle<TObject> LoadAssetAsync<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93BBF0 Offset: 0x93ADF0 VA: 0x18093BBF0
	|-AssetReference.LoadAssetAsync<object>
	|
	|-RVA: 0x93BAB0 Offset: 0x93ACB0 VA: 0x18093BAB0
	|-AssetReference.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2350CF0 Offset: 0x234FEF0 VA: 0x182350CF0 Slot: 13
	public virtual AsyncOperationHandle<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x23512F0 Offset: 0x23504F0 VA: 0x1823512F0 Slot: 14
	public virtual AsyncOperationHandle<SceneInstance> UnLoadScene() { }

	// RVA: 0x2350A70 Offset: 0x234FC70 VA: 0x182350A70 Slot: 15
	public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x2350B60 Offset: 0x234FD60 VA: 0x182350B60 Slot: 16
	public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Transform parent, bool instantiateInWorldSpace = False) { }

	// RVA: 0x23511F0 Offset: 0x23503F0 VA: 0x1823511F0 Slot: 17
	public virtual bool RuntimeKeyIsValid() { }

	// RVA: 0x2350EB0 Offset: 0x23500B0 VA: 0x182350EB0 Slot: 18
	public virtual void ReleaseAsset() { }

	// RVA: 0x2351010 Offset: 0x2350210 VA: 0x182351010 Slot: 19
	public virtual void ReleaseInstance(GameObject obj) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 20
	public virtual bool ValidateAsset(Object obj) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 21
	public virtual bool ValidateAsset(string path) { }
}

// Namespace: UnityEngine.AddressableAssets
public interface IKeyEvaluator // TypeDefIndex: 16556
{
	// Properties
	public abstract object RuntimeKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_RuntimeKey();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool RuntimeKeyIsValid();
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CheckCatalogsOperation.<>c // TypeDefIndex: 16557
{
	// Fields
	public static readonly CheckCatalogsOperation.<>c <>9; // 0x0
	public static Func<IResourceProvider, bool> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x2363200 Offset: 0x2362400 VA: 0x182363200
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362050 Offset: 0x2361250 VA: 0x182362050
	internal bool <Start>b__5_0(IResourceProvider rp) { }
}

// Namespace: UnityEngine.AddressableAssets
internal class CheckCatalogsOperation : AsyncOperationBase<List<string>> // TypeDefIndex: 16558
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x88
	private List<string> m_LocalHashes; // 0x90
	private List<ResourceLocatorInfo> m_LocatorInfos; // 0x98
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xA0

	// Methods

	// RVA: 0x2353820 Offset: 0x2352A20 VA: 0x182353820
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x2353260 Offset: 0x2352460 VA: 0x182353260
	public AsyncOperationHandle<List<string>> Start(List<ResourceLocatorInfo> locatorInfos) { }

	// RVA: 0x2352C40 Offset: 0x2351E40 VA: 0x182352C40 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x2352A10 Offset: 0x2351C10 VA: 0x182352A10 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x2352B30 Offset: 0x2351D30 VA: 0x182352B30 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x2352D70 Offset: 0x2351F70 VA: 0x182352D70
	internal static List<string> ProcessDependentOpResults(IList<AsyncOperationHandle> results, List<ResourceLocatorInfo> locatorInfos, List<string> localHashes, out string errorString, out bool success) { }

	// RVA: 0x2352A80 Offset: 0x2351C80 VA: 0x182352A80 Slot: 28
	protected override void Execute() { }
}

// Namespace: UnityEngine.AddressableAssets
internal class CleanBundleCacheOperation : AsyncOperationBase<bool>, IUpdateReceiver // TypeDefIndex: 16559
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x88
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0x90
	private List<string> m_CacheDirsForRemoval; // 0xB0
	private Thread m_EnumerationThread; // 0xB8
	private string m_BaseCachePath; // 0xC0
	private bool m_UseMultiThreading; // 0xC8

	// Methods

	// RVA: 0x2354960 Offset: 0x2353B60 VA: 0x182354960
	public void .ctor(AddressablesImpl aa, bool forceSingleThreading) { }

	// RVA: 0x23547E0 Offset: 0x23539E0 VA: 0x1823547E0
	public AsyncOperationHandle<bool> Start(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }

	// RVA: 0x2353870 Offset: 0x2352A70 VA: 0x182353870
	public void CompleteInternal(bool result, bool success, string errorMsg) { }

	// RVA: 0x2354580 Offset: 0x2353780 VA: 0x182354580 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x2353900 Offset: 0x2352B00 VA: 0x182353900 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x2354470 Offset: 0x2353670 VA: 0x182354470 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x2353C90 Offset: 0x2352E90 VA: 0x182353C90 Slot: 28
	protected override void Execute() { }

	// RVA: 0x2354910 Offset: 0x2353B10 VA: 0x182354910 Slot: 36
	private void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }

	// RVA: 0x2354640 Offset: 0x2353840 VA: 0x182354640
	private void RemoveCacheEntries() { }

	// RVA: 0x2353BF0 Offset: 0x2352DF0 VA: 0x182353BF0
	private void DetermineCacheDirsNotInUse(object data) { }

	// RVA: 0x2353970 Offset: 0x2352B70 VA: 0x182353970
	private void DetermineCacheDirsNotInUse(HashSet<string> cacheDirsInUse) { }

	// RVA: 0x2353E60 Offset: 0x2353060 VA: 0x182353E60
	private HashSet<string> GetCacheDirsInUse(IList<AsyncOperationHandle> catalogOps) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UpdateCatalogsOperation.<>c // TypeDefIndex: 16560
{
	// Fields
	public static readonly UpdateCatalogsOperation.<>c <>9; // 0x0
	public static Func<IResourceProvider, bool> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x2363260 Offset: 0x2362460 VA: 0x182363260
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23620E0 Offset: 0x23612E0 VA: 0x1823620E0
	internal bool <Start>b__6_0(IResourceProvider rp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UpdateCatalogsOperation.<>c__DisplayClass11_0 // TypeDefIndex: 16561
{
	// Fields
	public UpdateCatalogsOperation <>4__this; // 0x10
	public List<IResourceLocator> catalogs; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362650 Offset: 0x2361850 VA: 0x182362650
	internal void <OnCleanCacheCompleted>b__0(AsyncOperationHandle<bool> obj) { }
}

// Namespace: UnityEngine.AddressableAssets
internal class UpdateCatalogsOperation : AsyncOperationBase<List<IResourceLocator>> // TypeDefIndex: 16562
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x88
	private List<ResourceLocatorInfo> m_LocatorInfos; // 0x90
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0x98
	private AsyncOperationHandle<bool> m_CleanCacheOp; // 0xB8
	private bool m_AutoCleanBundleCache; // 0xD8

	// Methods

	// RVA: 0x2364330 Offset: 0x2363530 VA: 0x182364330
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x2363D50 Offset: 0x2362F50 VA: 0x182363D50
	public AsyncOperationHandle<List<IResourceLocator>> Start(IEnumerable<string> catalogIds, bool autoCleanBundleCache) { }

	// RVA: 0x2363AC0 Offset: 0x2362CC0 VA: 0x182363AC0 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x2363380 Offset: 0x2362580 VA: 0x182363380 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x23639B0 Offset: 0x2362BB0 VA: 0x1823639B0 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x23633F0 Offset: 0x23625F0 VA: 0x1823633F0 Slot: 28
	protected override void Execute() { }

	// RVA: 0x2363C70 Offset: 0x2362E70 VA: 0x182363C70
	private void OnCleanCacheCompleted(AsyncOperationHandle<bool> handle, List<IResourceLocator> catalogs) { }
}

// Namespace: UnityEngine.AddressableAssets
internal class DynamicResourceLocator : IResourceLocator // TypeDefIndex: 16563
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x10
	private string m_AtlasSpriteProviderId; // 0x18

	// Properties
	public string LocatorId { get; }
	public virtual IEnumerable<object> Keys { get; }
	private string AtlasSpriteProviderId { get; }

	// Methods

	// RVA: 0x2356A20 Offset: 0x2355C20 VA: 0x182356A20 Slot: 4
	public string get_LocatorId() { }

	// RVA: 0x23569E0 Offset: 0x2355BE0 VA: 0x1823569E0 Slot: 7
	public virtual IEnumerable<object> get_Keys() { }

	// RVA: 0x2356760 Offset: 0x2355960 VA: 0x182356760
	private string get_AtlasSpriteProviderId() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(AddressablesImpl addr) { }

	// RVA: 0x2356430 Offset: 0x2355630 VA: 0x182356430 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x2356050 Offset: 0x2355250 VA: 0x182356050
	internal void CreateDynamicLocations(Type type, IList<IResourceLocation> locations, string locName, string subKey, IResourceLocation mainLoc) { }
}

// Namespace: UnityEngine.AddressableAssets
public enum AddressablesPlatform // TypeDefIndex: 16564
{
	// Fields
	public int value__; // 0x0
	public const AddressablesPlatform Unknown = 0;
	public const AddressablesPlatform Windows = 1;
	public const AddressablesPlatform OSX = 2;
	public const AddressablesPlatform Linux = 3;
	public const AddressablesPlatform PS4 = 4;
	public const AddressablesPlatform Switch = 5;
	public const AddressablesPlatform XboxOne = 6;
	public const AddressablesPlatform WebGL = 7;
	public const AddressablesPlatform iOS = 8;
	public const AddressablesPlatform Android = 9;
	public const AddressablesPlatform WindowsUniversal = 10;
}

// Namespace: UnityEngine.AddressableAssets
public class PlatformMappingService // TypeDefIndex: 16565
{
	// Fields
	internal static readonly Dictionary<RuntimePlatform, AddressablesPlatform> s_RuntimeTargetMapping; // 0x0

	// Methods

	// RVA: 0x235E7B0 Offset: 0x235D9B0 VA: 0x18235E7B0
	internal static AddressablesPlatform GetAddressablesPlatformInternal(RuntimePlatform platform) { }

	// RVA: 0x235E880 Offset: 0x235DA80 VA: 0x18235E880
	internal static string GetAddressablesPlatformPathInternal(RuntimePlatform platform) { }

	[Obsolete("This API doesn't adapt to the addition of new platforms.  Use GetPlatformPathSubFolder instead.")]
	// RVA: 0x235EB40 Offset: 0x235DD40 VA: 0x18235EB40
	public static AddressablesPlatform GetPlatform() { }

	// RVA: 0x235E9C0 Offset: 0x235DBC0 VA: 0x18235E9C0
	public static string GetPlatformPathSubFolder() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x235EC70 Offset: 0x235DE70 VA: 0x18235EC70
	private static void .cctor() { }
}

// Namespace: UnityEngine.AddressableAssets.Utility
internal class DiagnosticInfo // TypeDefIndex: 16566
{
	// Fields
	public string DisplayName; // 0x10
	public int ObjectId; // 0x18
	public int[] Dependencies; // 0x20

	// Methods

	// RVA: 0x2355FE0 Offset: 0x23551E0 VA: 0x182355FE0
	public DiagnosticEvent CreateEvent(string category, ResourceManager.DiagnosticEventType eventType, int frame, int val) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets.Utility
internal class ResourceManagerDiagnostics : IDisposable // TypeDefIndex: 16567
{
	// Fields
	private ResourceManager m_ResourceManager; // 0x10
	private const int k_NumberOfCompletedOpResultEntriesToShow = 4;
	private const int k_MaximumCompletedOpResultEntryLength = 30;
	private Dictionary<int, DiagnosticInfo> m_cachedDiagnosticInfo; // 0x18

	// Methods

	// RVA: 0x23610F0 Offset: 0x23602F0 VA: 0x1823610F0
	public void .ctor(ResourceManager resourceManager) { }

	// RVA: 0x2360ED0 Offset: 0x23600D0 VA: 0x182360ED0
	internal int SumDependencyNameHashCodes(AsyncOperationHandle handle) { }

	// RVA: 0x23603B0 Offset: 0x235F5B0 VA: 0x1823603B0
	internal int CalculateHashCode(AsyncOperationHandle handle) { }

	// RVA: 0x2360310 Offset: 0x235F510 VA: 0x182360310
	internal int CalculateCompletedOperationHashcode(AsyncOperationHandle handle) { }

	// RVA: 0x2360650 Offset: 0x235F850 VA: 0x182360650
	internal string GenerateCompletedOperationDisplayName(AsyncOperationHandle handle) { }

	// RVA: 0x2360AA0 Offset: 0x235FCA0 VA: 0x182360AA0
	private void OnResourceManagerDiagnosticEvent(ResourceManager.DiagnosticEventContext eventContext) { }

	// RVA: 0x2360580 Offset: 0x235F780 VA: 0x182360580 Slot: 4
	public void Dispose() { }
}

// Namespace: 
internal enum SerializationUtilities.ObjectType // TypeDefIndex: 16568
{
	// Fields
	public int value__; // 0x0
	public const SerializationUtilities.ObjectType AsciiString = 0;
	public const SerializationUtilities.ObjectType UnicodeString = 1;
	public const SerializationUtilities.ObjectType UInt16 = 2;
	public const SerializationUtilities.ObjectType UInt32 = 3;
	public const SerializationUtilities.ObjectType Int32 = 4;
	public const SerializationUtilities.ObjectType Hash128 = 5;
	public const SerializationUtilities.ObjectType Type = 6;
	public const SerializationUtilities.ObjectType JsonObject = 7;
}

// Namespace: UnityEngine.AddressableAssets.Utility
internal static class SerializationUtilities // TypeDefIndex: 16569
{
	// Methods

	// RVA: 0x160A450 Offset: 0x1609650 VA: 0x18160A450
	internal static int ReadInt32FromByteArray(byte[] data, int offset) { }

	// RVA: 0x2361600 Offset: 0x2360800 VA: 0x182361600
	internal static int WriteInt32ToByteArray(byte[] data, int val, int offset) { }

	// RVA: 0x23611D0 Offset: 0x23603D0 VA: 0x1823611D0
	internal static object ReadObjectFromByteArray(byte[] keyData, int dataIndex) { }

	// RVA: 0x2361670 Offset: 0x2360870 VA: 0x182361670
	internal static int WriteObjectToByteList(object obj, List<byte> buffer) { }
}

// Namespace: 
public enum ContentCatalogProvider.DependencyHashIndex // TypeDefIndex: 16570
{
	// Fields
	public int value__; // 0x0
	public const ContentCatalogProvider.DependencyHashIndex Remote = 0;
	public const ContentCatalogProvider.DependencyHashIndex Cache = 1;
	public const ContentCatalogProvider.DependencyHashIndex Count = 2;
}

// Namespace: 
internal class ContentCatalogProvider.InternalOp.BundledCatalog // TypeDefIndex: 16571
{
	// Fields
	private readonly string m_BundlePath; // 0x10
	private bool m_OpInProgress; // 0x18
	private AssetBundleCreateRequest m_LoadBundleRequest; // 0x20
	internal AssetBundle m_CatalogAssetBundle; // 0x28
	private AssetBundleRequest m_LoadTextAssetRequest; // 0x30
	private ContentCatalogData m_CatalogData; // 0x38
	private WebRequestQueueOperation m_WebRequestQueueOperation; // 0x40
	private AsyncOperation m_RequestOperation; // 0x48
	private int m_WebRequestTimeout; // 0x50
	[CompilerGenerated]
	private Action<ContentCatalogData> OnLoaded; // 0x58

	// Properties
	public bool OpInProgress { get; }
	public bool OpIsSuccess { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23522A0 Offset: 0x23514A0 VA: 0x1823522A0
	public void add_OnLoaded(Action<ContentCatalogData> value) { }

	[CompilerGenerated]
	// RVA: 0x2352370 Offset: 0x2351570 VA: 0x182352370
	public void remove_OnLoaded(Action<ContentCatalogData> value) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_OpInProgress() { }

	// RVA: 0x2352350 Offset: 0x2351550 VA: 0x182352350
	public bool get_OpIsSuccess() { }

	// RVA: 0x2352170 Offset: 0x2351370 VA: 0x182352170
	public void .ctor(string bundlePath, int webRequestTimeout = 0) { }

	// RVA: 0x23516D0 Offset: 0x23508D0 VA: 0x1823516D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2351E10 Offset: 0x2351010 VA: 0x182351E10
	private void Unload() { }

	// RVA: 0x2351740 Offset: 0x2350940 VA: 0x182351740
	public void LoadCatalogFromBundleAsync() { }

	// RVA: 0x2351F30 Offset: 0x2351130 VA: 0x182351F30
	private void WebRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x23519E0 Offset: 0x2350BE0 VA: 0x1823519E0
	private void LoadTextAssetRequestComplete(AsyncOperation op) { }

	// RVA: 0x2351E40 Offset: 0x2351040 VA: 0x182351E40
	public bool WaitForCompletion() { }

	[CompilerGenerated]
	// RVA: 0x2351D80 Offset: 0x2350F80 VA: 0x182351D80
	private void <LoadCatalogFromBundleAsync>b__19_1(UnityWebRequestAsyncOperation asyncOp) { }

	[CompilerGenerated]
	// RVA: 0x2351B90 Offset: 0x2350D90 VA: 0x182351B90
	private void <LoadCatalogFromBundleAsync>b__19_0(AsyncOperation loadOp) { }
}

// Namespace: 
internal class ContentCatalogProvider.InternalOp // TypeDefIndex: 16572
{
	// Fields
	private string m_LocalDataPath; // 0x10
	private string m_RemoteHashValue; // 0x18
	internal string m_LocalHashValue; // 0x20
	private ProvideHandle m_ProviderInterface; // 0x28
	internal ContentCatalogData m_ContentCatalogData; // 0x40
	private AsyncOperationHandle<ContentCatalogData> m_ContentCatalogDataLoadOp; // 0x48
	private ContentCatalogProvider.InternalOp.BundledCatalog m_BundledCatalog; // 0x68
	private bool m_Retried; // 0x70
	private bool m_DisableCatalogUpdateOnStart; // 0x71
	private bool m_IsLocalCatalogInBundle; // 0x72

	// Methods

	// RVA: 0x235B450 Offset: 0x235A650 VA: 0x18235B450
	public void Start(ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle) { }

	// RVA: 0x235B680 Offset: 0x235A880 VA: 0x18235B680
	private bool WaitForCompletionCallback() { }

	// RVA: 0x235B3B0 Offset: 0x235A5B0 VA: 0x18235B3B0
	public void Release() { }

	// RVA: 0x2359FF0 Offset: 0x23591F0 VA: 0x182359FF0
	internal bool CanLoadCatalogFromBundle(string idToLoad, IResourceLocation location) { }

	// RVA: 0x235A790 Offset: 0x2359990 VA: 0x18235A790
	internal void LoadCatalog(string idToLoad, bool loadCatalogFromLocalBundle) { }

	// RVA: 0x235A0F0 Offset: 0x23592F0 VA: 0x18235A0F0
	private void CatalogLoadOpCompleteCallback(AsyncOperationHandle<ContentCatalogData> op) { }

	// RVA: 0x235A710 Offset: 0x2359910 VA: 0x18235A710
	private string GetTransformedInternalId(IResourceLocation loc) { }

	// RVA: 0x235A1C0 Offset: 0x23593C0 VA: 0x18235A1C0
	internal string DetermineIdToLoad(IResourceLocation location, IList<object> dependencyObjects, bool disableCatalogUpdateOnStart = False) { }

	// RVA: 0x235AC80 Offset: 0x2359E80 VA: 0x18235AC80
	private void OnCatalogLoaded(ContentCatalogData ccd) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x235B670 Offset: 0x235A870 VA: 0x18235B670
	private void <LoadCatalog>b__14_0(ContentCatalogData ccd) { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceProviders
[DisplayName("Content Catalog Provider")]
public class ContentCatalogProvider : ResourceProviderBase // TypeDefIndex: 16573
{
	// Fields
	public bool DisableCatalogUpdateOnStart; // 0x20
	public bool IsLocalCatalogInBundle; // 0x21
	internal Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp> m_LocationToCatalogLoadOpMap; // 0x28
	private ResourceManager m_RM; // 0x30

	// Methods

	// RVA: 0x2355F50 Offset: 0x2355150 VA: 0x182355F50
	public void .ctor(ResourceManager resourceManagerInstance) { }

	// RVA: 0x2355DE0 Offset: 0x2354FE0 VA: 0x182355DE0 Slot: 15
	public override void Release(IResourceLocation location, object obj) { }

	// RVA: 0x2355C80 Offset: 0x2354E80 VA: 0x182355C80 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public class ContentCatalogDataEntry // TypeDefIndex: 16574
{
	// Fields
	[CompilerGenerated]
	private string <InternalId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Provider>k__BackingField; // 0x18
	[CompilerGenerated]
	private List<object> <Keys>k__BackingField; // 0x20
	[CompilerGenerated]
	private List<object> <Dependencies>k__BackingField; // 0x28
	[CompilerGenerated]
	private object <Data>k__BackingField; // 0x30
	[CompilerGenerated]
	private Type <ResourceType>k__BackingField; // 0x38

	// Properties
	public string InternalId { get; set; }
	public string Provider { get; set; }
	public List<object> Keys { get; set; }
	public List<object> Dependencies { get; set; }
	public object Data { get; set; }
	public Type ResourceType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_InternalId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_InternalId(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_Provider(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public List<object> get_Keys() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_Keys(List<object> value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public List<object> get_Dependencies() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_Dependencies(List<object> value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public object get_Data() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Data(object value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Type get_ResourceType() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_ResourceType(Type value) { }

	// RVA: 0x2354C60 Offset: 0x2353E60 VA: 0x182354C60
	public void .ctor(Type type, string internalId, string provider, IEnumerable<object> keys, IEnumerable<object> dependencies, object extraData) { }
}

// Namespace: 
private struct ContentCatalogData.Bucket // TypeDefIndex: 16575
{
	// Fields
	public int dataOffset; // 0x0
	public int[] entries; // 0x8
}

// Namespace: 
private class ContentCatalogData.CompactLocation : IResourceLocation // TypeDefIndex: 16576
{
	// Fields
	private ResourceLocationMap m_Locator; // 0x10
	private string m_InternalId; // 0x18
	private string m_ProviderId; // 0x20
	private object m_Dependency; // 0x28
	private object m_Data; // 0x30
	private int m_HashCode; // 0x38
	private int m_DependencyHashCode; // 0x3C
	private string m_PrimaryKey; // 0x40
	private Type m_Type; // 0x48

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public bool HasDependencies { get; }
	public int DependencyHashCode { get; }
	public object Data { get; }
	public string PrimaryKey { get; set; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public string get_InternalId() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x2354BA0 Offset: 0x2353DA0 VA: 0x182354BA0 Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x6B5280 Offset: 0x6B4480 VA: 0x1806B5280 Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 10
	public object get_Data() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_PrimaryKey(string value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2354A10 Offset: 0x2353C10 VA: 0x182354A10 Slot: 7
	public int Hash(Type t) { }

	// RVA: 0x2354A60 Offset: 0x2353C60 VA: 0x182354A60
	public void .ctor(ResourceLocationMap locator, string internalId, string providerId, object dependencyKey, object data, int depHash, string primaryKey, Type type) { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
[Serializable]
public class ContentCatalogData // TypeDefIndex: 16577
{
	// Fields
	internal string localHash; // 0x10
	internal IResourceLocation location; // 0x18
	[SerializeField]
	internal string m_LocatorId; // 0x20
	[SerializeField]
	private ObjectInitializationData m_InstanceProviderData; // 0x28
	[SerializeField]
	private ObjectInitializationData m_SceneProviderData; // 0x58
	[SerializeField]
	internal List<ObjectInitializationData> m_ResourceProviderData; // 0x88
	[FormerlySerializedAs("m_providerIds")]
	[SerializeField]
	internal string[] m_ProviderIds; // 0x90
	[FormerlySerializedAs("m_internalIds")]
	[SerializeField]
	internal string[] m_InternalIds; // 0x98
	[FormerlySerializedAs("m_keyDataString")]
	[SerializeField]
	internal string m_KeyDataString; // 0xA0
	[SerializeField]
	[FormerlySerializedAs("m_bucketDataString")]
	internal string m_BucketDataString; // 0xA8
	[FormerlySerializedAs("m_entryDataString")]
	[SerializeField]
	internal string m_EntryDataString; // 0xB0
	private const int kBytesPerInt32 = 4;
	private const int k_EntryDataItemPerEntry = 7;
	[FormerlySerializedAs("m_extraDataString")]
	[SerializeField]
	internal string m_ExtraDataString; // 0xB8
	[SerializeField]
	internal SerializedType[] m_resourceTypes; // 0xC0
	[SerializeField]
	private string[] m_InternalIdPrefixes; // 0xC8

	// Properties
	public string ProviderId { get; set; }
	public ObjectInitializationData InstanceProviderData { get; set; }
	public ObjectInitializationData SceneProviderData { get; set; }
	public List<ObjectInitializationData> ResourceProviderData { get; set; }
	public string[] ProviderIds { get; }
	public string[] InternalIds { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_ProviderId() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_ProviderId(string value) { }

	// RVA: 0x2355C00 Offset: 0x2354E00 VA: 0x182355C00
	public ObjectInitializationData get_InstanceProviderData() { }

	// RVA: 0x2355C40 Offset: 0x2354E40 VA: 0x182355C40
	public void set_InstanceProviderData(ObjectInitializationData value) { }

	// RVA: 0x2355C20 Offset: 0x2354E20 VA: 0x182355C20
	public ObjectInitializationData get_SceneProviderData() { }

	// RVA: 0x2355C60 Offset: 0x2354E60 VA: 0x182355C60
	public void set_SceneProviderData(ObjectInitializationData value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public List<ObjectInitializationData> get_ResourceProviderData() { }

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	public void set_ResourceProviderData(List<ObjectInitializationData> value) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public string[] get_ProviderIds() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public string[] get_InternalIds() { }

	// RVA: 0x2354D50 Offset: 0x2353F50 VA: 0x182354D50
	internal void CleanData() { }

	// RVA: 0x2354DE0 Offset: 0x2353FE0 VA: 0x182354DE0
	internal ResourceLocationMap CreateCustomLocator(string overrideId, string providerSuffix) { }

	// RVA: 0x2354E00 Offset: 0x2354000 VA: 0x182354E00
	public ResourceLocationMap CreateLocator(string providerSuffix) { }

	// RVA: 0x2355AC0 Offset: 0x2354CC0 VA: 0x182355AC0
	internal static string ExpandInternalId(string[] internalIdPrefixes, string v) { }

	// RVA: 0x2355B90 Offset: 0x2354D90 VA: 0x182355B90
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public interface IResourceLocator // TypeDefIndex: 16578
{
	// Properties
	public abstract string LocatorId { get; }
	public abstract IEnumerable<object> Keys { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_LocatorId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerable<object> get_Keys();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Locate(object key, Type type, out IList<IResourceLocation> locations);
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public class LegacyResourcesLocator : IResourceLocator // TypeDefIndex: 16579
{
	// Properties
	public IEnumerable<object> Keys { get; }
	public string LocatorId { get; }

	// Methods

	// RVA: 0x235E170 Offset: 0x235D370 VA: 0x18235E170 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public IEnumerable<object> get_Keys() { }

	// RVA: 0x235E350 Offset: 0x235D550 VA: 0x18235E350 Slot: 4
	public string get_LocatorId() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
[Serializable]
public class ResourceLocationData // TypeDefIndex: 16580
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_keys")]
	private string[] m_Keys; // 0x10
	[SerializeField]
	[FormerlySerializedAs("m_internalId")]
	private string m_InternalId; // 0x18
	[SerializeField]
	[FormerlySerializedAs("m_provider")]
	private string m_Provider; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_dependencies")]
	private string[] m_Dependencies; // 0x28
	[SerializeField]
	private SerializedType m_ResourceType; // 0x30
	[SerializeField]
	private byte[] SerializedData; // 0x50
	private object _Data; // 0x58

	// Properties
	public string[] Keys { get; }
	public string InternalId { get; }
	public string Provider { get; }
	public string[] Dependencies { get; }
	public Type ResourceType { get; }
	public object Data { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string[] get_Keys() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_InternalId() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Provider() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string[] get_Dependencies() { }

	// RVA: 0x235EFF0 Offset: 0x235E1F0 VA: 0x18235EFF0
	public Type get_ResourceType() { }

	// RVA: 0x235EFA0 Offset: 0x235E1A0 VA: 0x18235EFA0
	public object get_Data() { }

	// RVA: 0x235F000 Offset: 0x235E200 VA: 0x18235F000
	public void set_Data(object value) { }

	// RVA: 0x235EE80 Offset: 0x235E080 VA: 0x18235EE80
	public void .ctor(string[] keys, string id, Type provider, Type t, string[] dependencies) { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public class ResourceLocationMap : IResourceLocator // TypeDefIndex: 16581
{
	// Fields
	[CompilerGenerated]
	private string <LocatorId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Dictionary<object, IList<IResourceLocation>> <Locations>k__BackingField; // 0x18

	// Properties
	public string LocatorId { get; set; }
	public Dictionary<object, IList<IResourceLocation>> Locations { get; set; }
	public IEnumerable<object> Keys { get; }

	// Methods

	// RVA: 0x235F840 Offset: 0x235EA40 VA: 0x18235F840
	public void .ctor(string id, int capacity = 0) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string get_LocatorId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_LocatorId(string value) { }

	// RVA: 0x235F8D0 Offset: 0x235EAD0 VA: 0x18235F8D0
	public void .ctor(string id, IList<ResourceLocationData> locations) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Dictionary<object, IList<IResourceLocation>> get_Locations() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_Locations(Dictionary<object, IList<IResourceLocation>> value) { }

	// RVA: 0x2360190 Offset: 0x235F390 VA: 0x182360190 Slot: 5
	public IEnumerable<object> get_Keys() { }

	// RVA: 0x235F240 Offset: 0x235E440 VA: 0x18235F240 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x235F0B0 Offset: 0x235E2B0 VA: 0x18235F0B0
	public void Add(object key, IResourceLocation location) { }

	// RVA: 0x235F1D0 Offset: 0x235E3D0 VA: 0x18235F1D0
	public void Add(object key, IList<IResourceLocation> locations) { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
public static class AddressablesRuntimeProperties // TypeDefIndex: 16582
{
	// Fields
	private static Stack<string> s_TokenStack; // 0x0
	private static Stack<int> s_TokenStartStack; // 0x8
	private static bool s_StaticStacksAreInUse; // 0x10
	private static Dictionary<string, string> s_CachedValues; // 0x18

	// Methods

	// RVA: 0x234A9C0 Offset: 0x2349BC0 VA: 0x18234A9C0
	private static Assembly[] GetAssemblies() { }

	// RVA: 0x234A9F0 Offset: 0x2349BF0 VA: 0x18234A9F0
	internal static int GetCachedValueCount() { }

	// RVA: 0x234AA70 Offset: 0x2349C70 VA: 0x18234AA70
	public static void SetPropertyValue(string name, string val) { }

	// RVA: 0x2349F00 Offset: 0x2349100 VA: 0x182349F00
	public static void ClearCachedPropertyValues() { }

	// RVA: 0x2349F80 Offset: 0x2349180 VA: 0x182349F80
	public static string EvaluateProperty(string name) { }

	// RVA: 0x234A3C0 Offset: 0x23495C0 VA: 0x18234A3C0
	public static string EvaluateString(string input) { }

	// RVA: 0x234A470 Offset: 0x2349670 VA: 0x18234A470
	public static string EvaluateString(string inputString, char startDelimiter, char endDelimiter, Func<string, string> varFunc) { }

	// RVA: 0x234AB00 Offset: 0x2349D00 VA: 0x18234AB00
	private static void .cctor() { }
}

// Namespace: 
private class CacheInitialization.CacheInitOp : AsyncOperationBase<bool>, IUpdateReceiver // TypeDefIndex: 16583
{
	// Fields
	private Func<bool> m_Callback; // 0x88
	private bool m_UpdateRequired; // 0x90

	// Methods

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	public void Init(Func<bool> callback) { }

	// RVA: 0x23524D0 Offset: 0x23516D0 VA: 0x1823524D0 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x2352560 Offset: 0x2351760 VA: 0x182352560 Slot: 36
	public void Update(float unscaledDeltaTime) { }

	// RVA: 0x2352420 Offset: 0x2351620 VA: 0x182352420 Slot: 28
	protected override void Execute() { }

	// RVA: 0x2352630 Offset: 0x2351830 VA: 0x182352630
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CacheInitialization.<>c__DisplayClass1_0 // TypeDefIndex: 16584
{
	// Fields
	public CacheInitialization <>4__this; // 0x10
	public string id; // 0x18
	public string data; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2362E60 Offset: 0x2362060 VA: 0x182362E60
	internal bool <InitializeAsync>b__0() { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
[Serializable]
public class CacheInitialization : IInitializableObject // TypeDefIndex: 16585
{
	// Properties
	public static string RootPath { get; }

	// Methods

	// RVA: 0x2352860 Offset: 0x2351A60 VA: 0x182352860 Slot: 4
	public bool Initialize(string id, string dataStr) { }

	// RVA: 0x23526D0 Offset: 0x23518D0 VA: 0x1823526D0 Slot: 6
	public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data) { }

	// RVA: 0x23529A0 Offset: 0x2351BA0 VA: 0x1823529A0
	public static string get_RootPath() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
[Serializable]
public class CacheInitializationData // TypeDefIndex: 16586
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_compressionEnabled")]
	private bool m_CompressionEnabled; // 0x10
	[SerializeField]
	[FormerlySerializedAs("m_cacheDirectoryOverride")]
	private string m_CacheDirectoryOverride; // 0x18
	[SerializeField]
	[FormerlySerializedAs("m_expirationDelay")]
	private int m_ExpirationDelay; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_limitCacheSize")]
	private bool m_LimitCacheSize; // 0x24
	[SerializeField]
	[FormerlySerializedAs("m_maximumCacheSize")]
	private long m_MaximumCacheSize; // 0x28

	// Properties
	public bool CompressionEnabled { get; set; }
	public string CacheDirectoryOverride { get; set; }
	[Obsolete("Functionality remains unchanged.  However, due to issues with Caching this property is being marked obsolete.  See Caching API documentation for more details.")]
	public int ExpirationDelay { get; set; }
	public bool LimitCacheSize { get; set; }
	public long MaximumCacheSize { get; set; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_CompressionEnabled() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_CompressionEnabled(bool value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_CacheDirectoryOverride() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_CacheDirectoryOverride(string value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_ExpirationDelay() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_ExpirationDelay(int value) { }

	// RVA: 0x695F30 Offset: 0x695130 VA: 0x180695F30
	public bool get_LimitCacheSize() { }

	// RVA: 0x7428E0 Offset: 0x741AE0 VA: 0x1807428E0
	public void set_LimitCacheSize(bool value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public long get_MaximumCacheSize() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_MaximumCacheSize(long value) { }

	// RVA: 0x2352670 Offset: 0x2351870 VA: 0x182352670
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class InitializationOperation.<>c // TypeDefIndex: 16587
{
	// Fields
	public static readonly InitializationOperation.<>c <>9; // 0x0
	public static Func<IResourceProvider, bool> <>9__13_0; // 0x8

	// Methods

	// RVA: 0x23645F0 Offset: 0x23637F0 VA: 0x1823645F0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x23644A0 Offset: 0x23636A0 VA: 0x1823644A0
	internal bool <Execute>b__13_0(IResourceProvider rp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InitializationOperation.<>c__DisplayClass16_0 // TypeDefIndex: 16588
{
	// Fields
	public AddressablesImpl addressables; // 0x10
	public string providerSuffix; // 0x18
	public IResourceLocation remoteHashLocation; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2364530 Offset: 0x2363730 VA: 0x182364530
	internal AsyncOperationHandle<IResourceLocator> <LoadContentCatalog>b__0(AsyncOperationHandle<ContentCatalogData> res) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InitializationOperation.<>c__DisplayClass18_0 // TypeDefIndex: 16589
{
	// Fields
	public InitializationOperation <>4__this; // 0x10
	public IList<IResourceLocation> catalogs; // 0x18
	public ResourceLocationMap locMap; // 0x20
	public int index; // 0x28
	public IResourceLocation remoteHashLocation; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2364590 Offset: 0x2363790 VA: 0x182364590
	internal void <LoadContentCatalogInternal>b__0(AsyncOperationHandle<IResourceLocator> op) { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
internal class InitializationOperation : AsyncOperationBase<IResourceLocator> // TypeDefIndex: 16590
{
	// Fields
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_rtdOp; // 0x88
	private AsyncOperationHandle<IResourceLocator> m_loadCatalogOp; // 0xA8
	private string m_ProviderSuffix; // 0xC8
	private AddressablesImpl m_Addressables; // 0xD0
	private ResourceManagerDiagnostics m_Diagnostics; // 0xD8
	private InitalizationObjectsOperation m_InitGroupOps; // 0xE0

	// Properties
	protected override float Progress { get; }
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x2359E00 Offset: 0x2359000 VA: 0x182359E00
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x2359F80 Offset: 0x2359180 VA: 0x182359F80 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x2359F50 Offset: 0x2359150 VA: 0x182359F50 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x2357620 Offset: 0x2356820 VA: 0x182357620
	internal static AsyncOperationHandle<IResourceLocator> CreateInitializationOperation(AddressablesImpl aa, string playerSettingsLocation, string providerSuffix) { }

	// RVA: 0x23588A0 Offset: 0x2357AA0 VA: 0x1823588A0 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x2357C50 Offset: 0x2356E50 VA: 0x182357C50 Slot: 28
	protected override void Execute() { }

	// RVA: 0x2359580 Offset: 0x2358780 VA: 0x182359580
	private static void LoadProvider(AddressablesImpl addressables, ObjectInitializationData providerData, string providerSuffix) { }

	// RVA: 0x2359880 Offset: 0x2358A80 VA: 0x182359880
	private static AsyncOperationHandle<IResourceLocator> OnCatalogDataLoaded(AddressablesImpl addressables, AsyncOperationHandle<ContentCatalogData> op, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x2358C70 Offset: 0x2357E70 VA: 0x182358C70
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(AddressablesImpl addressables, IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x2358C20 Offset: 0x2357E20 VA: 0x182358C20
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalog(IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x2358A50 Offset: 0x2357C50 VA: 0x182358A50
	internal AsyncOperationHandle<IResourceLocator> LoadContentCatalogInternal(IList<IResourceLocation> catalogs, int index, ResourceLocationMap locMap, IResourceLocation remoteHashLocation) { }

	// RVA: 0x2359230 Offset: 0x2358430 VA: 0x182359230
	private void LoadOpComplete(AsyncOperationHandle<IResourceLocator> op, IList<IResourceLocation> catalogs, ResourceLocationMap locMap, int index, IResourceLocation remoteHashLocation) { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
[Serializable]
public class ResourceManagerRuntimeData // TypeDefIndex: 16591
{
	// Fields
	public const string kCatalogAddress = "AddressablesMainContentCatalog";
	[SerializeField]
	private string m_buildTarget; // 0x10
	[SerializeField]
	[FormerlySerializedAs("m_settingsHash")]
	private string m_SettingsHash; // 0x18
	[SerializeField]
	[FormerlySerializedAs("m_catalogLocations")]
	private List<ResourceLocationData> m_CatalogLocations; // 0x20
	[FormerlySerializedAs("m_profileEvents")]
	[SerializeField]
	private bool m_ProfileEvents; // 0x28
	[FormerlySerializedAs("m_logResourceManagerExceptions")]
	[SerializeField]
	private bool m_LogResourceManagerExceptions; // 0x29
	[SerializeField]
	[FormerlySerializedAs("m_extraInitializationData")]
	private List<ObjectInitializationData> m_ExtraInitializationData; // 0x30
	[SerializeField]
	private bool m_DisableCatalogUpdateOnStart; // 0x38
	[SerializeField]
	private bool m_IsLocalCatalogInBundle; // 0x39
	[SerializeField]
	private SerializedType m_CertificateHandlerType; // 0x40
	[SerializeField]
	private string m_AddressablesVersion; // 0x60
	[SerializeField]
	private int m_maxConcurrentWebRequests; // 0x68
	[SerializeField]
	private int m_CatalogRequestsTimeout; // 0x6C

	// Properties
	public string BuildTarget { get; set; }
	public string SettingsHash { get; set; }
	public List<ResourceLocationData> CatalogLocations { get; }
	public bool ProfileEvents { get; set; }
	public bool LogResourceManagerExceptions { get; set; }
	public List<ObjectInitializationData> InitializationObjects { get; }
	public bool DisableCatalogUpdateOnStartup { get; set; }
	public bool IsLocalCatalogInBundle { get; set; }
	public Type CertificateHandlerType { get; set; }
	public string AddressablesVersion { get; set; }
	public int MaxConcurrentWebRequests { get; set; }
	public int CatalogRequestsTimeout { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_BuildTarget() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_BuildTarget(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_SettingsHash() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_SettingsHash(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public List<ResourceLocationData> get_CatalogLocations() { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_ProfileEvents() { }

	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_ProfileEvents(bool value) { }

	// RVA: 0x4C6AB0 Offset: 0x4C5CB0 VA: 0x1804C6AB0
	public bool get_LogResourceManagerExceptions() { }

	// RVA: 0x4C6AE0 Offset: 0x4C5CE0 VA: 0x1804C6AE0
	public void set_LogResourceManagerExceptions(bool value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public List<ObjectInitializationData> get_InitializationObjects() { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_DisableCatalogUpdateOnStartup() { }

	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_DisableCatalogUpdateOnStartup(bool value) { }

	// RVA: 0x4BD740 Offset: 0x4BC940 VA: 0x1804BD740
	public bool get_IsLocalCatalogInBundle() { }

	// RVA: 0x4BD790 Offset: 0x4BC990 VA: 0x1804BD790
	public void set_IsLocalCatalogInBundle(bool value) { }

	// RVA: 0x2364430 Offset: 0x2363630 VA: 0x182364430
	public Type get_CertificateHandlerType() { }

	// RVA: 0x2364460 Offset: 0x2363660 VA: 0x182364460
	public void set_CertificateHandlerType(Type value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_AddressablesVersion() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_AddressablesVersion(string value) { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80
	public int get_MaxConcurrentWebRequests() { }

	// RVA: 0x2364470 Offset: 0x2363670 VA: 0x182364470
	public void set_MaxConcurrentWebRequests(int value) { }

	// RVA: 0x526CA0 Offset: 0x525EA0 VA: 0x180526CA0
	public int get_CatalogRequestsTimeout() { }

	// RVA: 0x2364440 Offset: 0x2363640 VA: 0x182364440
	public void set_CatalogRequestsTimeout(int value) { }

	// RVA: 0x2364380 Offset: 0x2363580 VA: 0x182364380
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2289 // TypeDefIndex: 16592
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2943 // TypeDefIndex: 16593
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16594
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2289 59B2BBB911A904E69ECC08070D35B7D9B7E3CF7A8B58DB76C0B9CD80D73CB0CD /*Metadata offset 0x8FAF70*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2943 665ECC1C05160C0F32D3061E27307CCD620C172A96858BE3F9B40764886531FC /*Metadata offset 0x8FB868*/; // 0x8F1
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16595
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 16596
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 16597
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(27524, AllowMultiple = False, Inherited = False)]
[CompilerGenerated]
[Embedded]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 16598
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1BD09F0 Offset: 0x1BCFBF0 VA: 0x181BD09F0
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
[CompilerGenerated]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 16599
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
internal sealed class NullablePublicOnlyAttribute : Attribute // TypeDefIndex: 16600
{
	// Fields
	public readonly bool IncludesInternals; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool ) { }
}

// Namespace: 
internal static class Interop.Kernel32 // TypeDefIndex: 16601
{
	// Methods

	// RVA: 0x1BC87B0 Offset: 0x1BC79B0 VA: 0x181BC87B0
	internal static extern int ReadFile(SafeHandle handle, byte* bytes, int numBytesToRead, out int numBytesRead, IntPtr mustBeZero) { }
}

// Namespace: 
internal static class Interop // TypeDefIndex: 16602
{}

// Namespace: FxResources.System.Reflection.Metadata
internal static class SR // TypeDefIndex: 16603
{}

// Namespace: System
internal static class SR // TypeDefIndex: 16604
{
	// Fields
	private static readonly bool s_usingResourceKeys; // 0x0
	private static ResourceManager s_resourceManager; // 0x8

	// Properties
	internal static ResourceManager ResourceManager { get; }
	internal static string ImageTooSmall { get; }
	internal static string InvalidCorHeaderSize { get; }
	internal static string InvalidHandle { get; }
	internal static string InvalidMetadataSectionSpan { get; }
	internal static string InvalidPESignature { get; }
	internal static string InvalidToken { get; }
	internal static string PEImageNotAvailable { get; }
	internal static string MissingDataDirectory { get; }
	internal static string SectionTooSmall { get; }
	internal static string StreamMustSupportReadAndSeek { get; }
	internal static string UnknownFileFormat { get; }
	internal static string UnknownPEMagicValue { get; }
	internal static string MetadataTableNotSorted { get; }
	internal static string ModuleTableInvalidNumberOfRows { get; }
	internal static string UnknownTables { get; }
	internal static string IllegalTablesInCompressedMetadataStream { get; }
	internal static string TableRowCountSpaceTooSmall { get; }
	internal static string OutOfBoundsRead { get; }
	internal static string MetadataHeaderTooSmall { get; }
	internal static string MetadataSignature { get; }
	internal static string NotEnoughSpaceForVersionString { get; }
	internal static string StreamHeaderTooSmall { get; }
	internal static string NotEnoughSpaceForStreamHeaderName { get; }
	internal static string NotEnoughSpaceForStringStream { get; }
	internal static string NotEnoughSpaceForBlobStream { get; }
	internal static string NotEnoughSpaceForGUIDStream { get; }
	internal static string NotEnoughSpaceForMetadataStream { get; }
	internal static string InvalidMetadataStreamFormat { get; }
	internal static string MetadataTablesTooSmall { get; }
	internal static string MetadataTableHeaderTooSmall { get; }
	internal static string WinMDMissingMscorlibRef { get; }
	internal static string UnexpectedStreamEnd { get; }
	internal static string InvalidNumberOfSections { get; }
	internal static string InvalidCompressedInteger { get; }
	internal static string InvalidDocumentName { get; }
	internal static string RowIdOrHeapOffsetTooLarge { get; }
	internal static string StreamTooLarge { get; }
	internal static string ImageTooSmallOrContainsInvalidOffsetOrCount { get; }
	internal static string MetadataStringDecoderEncodingMustBeUtf8 { get; }
	internal static string InvalidRowCount { get; }
	internal static string InvalidEntryPointToken { get; }
	internal static string SequencePointValueOutOfRange { get; }
	internal static string InvalidDirectoryRVA { get; }
	internal static string InvalidDirectorySize { get; }
	internal static string InvalidDebugDirectoryEntryCharacteristics { get; }
	internal static string UnexpectedCodeViewDataSignature { get; }
	internal static string InvalidPdbChecksumDataFormat { get; }
	internal static string UnexpectedDebugDirectoryType { get; }

	// Methods

	// RVA: 0x1BD5260 Offset: 0x1BD4460 VA: 0x181BD5260
	private static bool UsingResourceKeys() { }

	[NullableContext(1)]
	// RVA: 0x1BD5020 Offset: 0x1BD4220 VA: 0x181BD5020
	internal static string GetResourceString(string resourceKey, string defaultString) { }

	[NullableContext(1)]
	// RVA: 0x1BD4EB0 Offset: 0x1BD40B0 VA: 0x181BD4EB0
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x1BD6000 Offset: 0x1BD5200 VA: 0x181BD6000
	internal static ResourceManager get_ResourceManager() { }

	// RVA: 0x1BD5400 Offset: 0x1BD4600 VA: 0x181BD5400
	internal static string get_ImageTooSmall() { }

	// RVA: 0x1BD54C0 Offset: 0x1BD46C0 VA: 0x181BD54C0
	internal static string get_InvalidCorHeaderSize() { }

	// RVA: 0x1BD5700 Offset: 0x1BD4900 VA: 0x181BD5700
	internal static string get_InvalidHandle() { }

	// RVA: 0x1BD5760 Offset: 0x1BD4960 VA: 0x181BD5760
	internal static string get_InvalidMetadataSectionSpan() { }

	// RVA: 0x1BD5880 Offset: 0x1BD4A80 VA: 0x181BD5880
	internal static string get_InvalidPESignature() { }

	// RVA: 0x1BD59A0 Offset: 0x1BD4BA0 VA: 0x181BD59A0
	internal static string get_InvalidToken() { }

	// RVA: 0x1BD5FA0 Offset: 0x1BD51A0 VA: 0x181BD5FA0
	internal static string get_PEImageNotAvailable() { }

	// RVA: 0x1BD5C40 Offset: 0x1BD4E40 VA: 0x181BD5C40
	internal static string get_MissingDataDirectory() { }

	// RVA: 0x1BD6160 Offset: 0x1BD5360 VA: 0x181BD6160
	internal static string get_SectionTooSmall() { }

	// RVA: 0x1BD6280 Offset: 0x1BD5480 VA: 0x181BD6280
	internal static string get_StreamMustSupportReadAndSeek() { }

	// RVA: 0x1BD64C0 Offset: 0x1BD56C0 VA: 0x181BD64C0
	internal static string get_UnknownFileFormat() { }

	// RVA: 0x1BD6520 Offset: 0x1BD5720 VA: 0x181BD6520
	internal static string get_UnknownPEMagicValue() { }

	// RVA: 0x1BD5B80 Offset: 0x1BD4D80 VA: 0x181BD5B80
	internal static string get_MetadataTableNotSorted() { }

	// RVA: 0x1BD5CA0 Offset: 0x1BD4EA0 VA: 0x181BD5CA0
	internal static string get_ModuleTableInvalidNumberOfRows() { }

	// RVA: 0x1BD6580 Offset: 0x1BD5780 VA: 0x181BD6580
	internal static string get_UnknownTables() { }

	// RVA: 0x1BD5340 Offset: 0x1BD4540 VA: 0x181BD5340
	internal static string get_IllegalTablesInCompressedMetadataStream() { }

	// RVA: 0x1BD6340 Offset: 0x1BD5540 VA: 0x181BD6340
	internal static string get_TableRowCountSpaceTooSmall() { }

	// RVA: 0x1BD5F40 Offset: 0x1BD5140 VA: 0x181BD5F40
	internal static string get_OutOfBoundsRead() { }

	// RVA: 0x1BD5A00 Offset: 0x1BD4C00 VA: 0x181BD5A00
	internal static string get_MetadataHeaderTooSmall() { }

	// RVA: 0x1BD5A60 Offset: 0x1BD4C60 VA: 0x181BD5A60
	internal static string get_MetadataSignature() { }

	// RVA: 0x1BD5EE0 Offset: 0x1BD50E0 VA: 0x181BD5EE0
	internal static string get_NotEnoughSpaceForVersionString() { }

	// RVA: 0x1BD6220 Offset: 0x1BD5420 VA: 0x181BD6220
	internal static string get_StreamHeaderTooSmall() { }

	// RVA: 0x1BD5E20 Offset: 0x1BD5020 VA: 0x181BD5E20
	internal static string get_NotEnoughSpaceForStreamHeaderName() { }

	// RVA: 0x1BD5E80 Offset: 0x1BD5080 VA: 0x181BD5E80
	internal static string get_NotEnoughSpaceForStringStream() { }

	// RVA: 0x1BD5D00 Offset: 0x1BD4F00 VA: 0x181BD5D00
	internal static string get_NotEnoughSpaceForBlobStream() { }

	// RVA: 0x1BD5D60 Offset: 0x1BD4F60 VA: 0x181BD5D60
	internal static string get_NotEnoughSpaceForGUIDStream() { }

	// RVA: 0x1BD5DC0 Offset: 0x1BD4FC0 VA: 0x181BD5DC0
	internal static string get_NotEnoughSpaceForMetadataStream() { }

	// RVA: 0x1BD57C0 Offset: 0x1BD49C0 VA: 0x181BD57C0
	internal static string get_InvalidMetadataStreamFormat() { }

	// RVA: 0x1BD5BE0 Offset: 0x1BD4DE0 VA: 0x181BD5BE0
	internal static string get_MetadataTablesTooSmall() { }

	// RVA: 0x1BD5B20 Offset: 0x1BD4D20 VA: 0x181BD5B20
	internal static string get_MetadataTableHeaderTooSmall() { }

	// RVA: 0x1BD65E0 Offset: 0x1BD57E0 VA: 0x181BD65E0
	internal static string get_WinMDMissingMscorlibRef() { }

	// RVA: 0x1BD6460 Offset: 0x1BD5660 VA: 0x181BD6460
	internal static string get_UnexpectedStreamEnd() { }

	// RVA: 0x1BD5820 Offset: 0x1BD4A20 VA: 0x181BD5820
	internal static string get_InvalidNumberOfSections() { }

	// RVA: 0x1BD5460 Offset: 0x1BD4660 VA: 0x181BD5460
	internal static string get_InvalidCompressedInteger() { }

	// RVA: 0x1BD5640 Offset: 0x1BD4840 VA: 0x181BD5640
	internal static string get_InvalidDocumentName() { }

	// RVA: 0x1BD6100 Offset: 0x1BD5300 VA: 0x181BD6100
	internal static string get_RowIdOrHeapOffsetTooLarge() { }

	// RVA: 0x1BD62E0 Offset: 0x1BD54E0 VA: 0x181BD62E0
	internal static string get_StreamTooLarge() { }

	// RVA: 0x1BD53A0 Offset: 0x1BD45A0 VA: 0x181BD53A0
	internal static string get_ImageTooSmallOrContainsInvalidOffsetOrCount() { }

	// RVA: 0x1BD5AC0 Offset: 0x1BD4CC0 VA: 0x181BD5AC0
	internal static string get_MetadataStringDecoderEncodingMustBeUtf8() { }

	// RVA: 0x1BD5940 Offset: 0x1BD4B40 VA: 0x181BD5940
	internal static string get_InvalidRowCount() { }

	// RVA: 0x1BD56A0 Offset: 0x1BD48A0 VA: 0x181BD56A0
	internal static string get_InvalidEntryPointToken() { }

	// RVA: 0x1BD61C0 Offset: 0x1BD53C0 VA: 0x181BD61C0
	internal static string get_SequencePointValueOutOfRange() { }

	// RVA: 0x1BD5580 Offset: 0x1BD4780 VA: 0x181BD5580
	internal static string get_InvalidDirectoryRVA() { }

	// RVA: 0x1BD55E0 Offset: 0x1BD47E0 VA: 0x181BD55E0
	internal static string get_InvalidDirectorySize() { }

	// RVA: 0x1BD5520 Offset: 0x1BD4720 VA: 0x181BD5520
	internal static string get_InvalidDebugDirectoryEntryCharacteristics() { }

	// RVA: 0x1BD63A0 Offset: 0x1BD55A0 VA: 0x181BD63A0
	internal static string get_UnexpectedCodeViewDataSignature() { }

	// RVA: 0x1BD58E0 Offset: 0x1BD4AE0 VA: 0x181BD58E0
	internal static string get_InvalidPdbChecksumDataFormat() { }

	// RVA: 0x1BD6400 Offset: 0x1BD5600 VA: 0x181BD6400
	internal static string get_UnexpectedDebugDirectoryType() { }

	// RVA: 0x1BD52B0 Offset: 0x1BD44B0 VA: 0x181BD52B0
	private static void .cctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(2048, Inherited = False)]
internal sealed class NotNullWhenAttribute : Attribute // TypeDefIndex: 16605
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool returnValue) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(64, Inherited = False)]
internal sealed class DoesNotReturnAttribute : Attribute // TypeDefIndex: 16606
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Reflection
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class BlobUtilities // TypeDefIndex: 16607
{
	// Methods

	[NullableContext(0)]
	// RVA: 0x1BC5020 Offset: 0x1BC4220 VA: 0x181BC5020
	public static byte[] ReadBytes(byte* buffer, int byteCount) { }
}

// Namespace: System.Reflection
[NullableContext(1)]
[Nullable(0)]
internal static class Throw // TypeDefIndex: 16608
{
	// Methods

	[DoesNotReturn]
	// RVA: 0x1BD8670 Offset: 0x1BD7870 VA: 0x181BD8670
	internal static void InvalidCast() { }

	[DoesNotReturn]
	// RVA: 0x1BD8610 Offset: 0x1BD7810 VA: 0x181BD8610
	internal static void InvalidArgument(string message, string parameterName) { }

	[DoesNotReturn]
	// RVA: 0x1BD8800 Offset: 0x1BD7A00 VA: 0x181BD8800
	internal static void InvalidToken() { }

	[DoesNotReturn]
	// RVA: 0x1BD8490 Offset: 0x1BD7690 VA: 0x181BD8490
	internal static void ArgumentNull(string parameterName) { }

	[DoesNotReturn]
	// RVA: 0x1BD84E0 Offset: 0x1BD76E0 VA: 0x181BD84E0
	internal static void ArgumentOutOfRange(string parameterName) { }

	[DoesNotReturn]
	// RVA: 0x1BD8880 Offset: 0x1BD7A80 VA: 0x181BD8880
	internal static void OutOfBounds() { }

	[DoesNotReturn]
	// RVA: 0x1BD8720 Offset: 0x1BD7920 VA: 0x181BD8720
	internal static void InvalidHandle() { }

	[DoesNotReturn]
	// RVA: 0x1BD86B0 Offset: 0x1BD78B0 VA: 0x181BD86B0
	internal static void InvalidCompressedInteger() { }

	[DoesNotReturn]
	// RVA: 0x1BD85A0 Offset: 0x1BD77A0 VA: 0x181BD85A0
	internal static void ImageTooSmall() { }

	[DoesNotReturn]
	// RVA: 0x1BD8530 Offset: 0x1BD7730 VA: 0x181BD8530
	internal static void ImageTooSmallOrContainsInvalidOffsetOrCount() { }

	[DoesNotReturn]
	// RVA: 0x1BD8940 Offset: 0x1BD7B40 VA: 0x181BD8940
	internal static void ReferenceOverflow() { }

	[DoesNotReturn]
	// RVA: 0x1BD8A20 Offset: 0x1BD7C20 VA: 0x181BD8A20
	internal static void TableNotSorted(TableIndex tableIndex) { }

	[DoesNotReturn]
	// RVA: 0x1BD8790 Offset: 0x1BD7990 VA: 0x181BD8790
	internal static void InvalidOperation_PEImageNotAvailable() { }

	[DoesNotReturn]
	// RVA: 0x1BD89B0 Offset: 0x1BD7BB0 VA: 0x181BD89B0
	internal static void SequencePointValueOutOfRange() { }

	[DoesNotReturn]
	// RVA: 0x1BD88F0 Offset: 0x1BD7AF0 VA: 0x181BD88F0
	internal static void PEReaderDisposed() { }
}

// Namespace: System.Reflection.PortableExecutable
[IsReadOnly]
internal struct PdbChecksumDebugDirectoryData // TypeDefIndex: 16609
{
	// Fields
	[CompilerGenerated]
	private readonly string <AlgorithmName>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ImmutableArray<byte> <Checksum>k__BackingField; // 0x8

	// Properties
	[Nullable(1)]
	public string AlgorithmName { get; }
	public ImmutableArray<byte> Checksum { get; }

	// Methods

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public string get_AlgorithmName() { }

	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ImmutableArray<byte> get_Checksum() { }

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	internal void .ctor(string algorithmName, ImmutableArray<byte> checksum) { }
}

// Namespace: System.Reflection.PortableExecutable
internal sealed class CoffHeader // TypeDefIndex: 16610
{
	// Fields
	[CompilerGenerated]
	private readonly Machine <Machine>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly short <NumberOfSections>k__BackingField; // 0x12
	[CompilerGenerated]
	private readonly int <TimeDateStamp>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly int <PointerToSymbolTable>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly int <NumberOfSymbols>k__BackingField; // 0x1C
	[CompilerGenerated]
	private readonly short <SizeOfOptionalHeader>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Characteristics <Characteristics>k__BackingField; // 0x22

	// Properties
	public short NumberOfSections { get; }
	public int TimeDateStamp { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B6EE50 Offset: 0x1B6E050 VA: 0x181B6EE50
	public short get_NumberOfSections() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_TimeDateStamp() { }

	// RVA: 0x1BC5210 Offset: 0x1BC4410 VA: 0x181BC5210
	internal void .ctor(ref PEBinaryReader reader) { }
}

// Namespace: System.Reflection.PortableExecutable
[Flags]
internal enum CorFlags // TypeDefIndex: 16611
{
	// Fields
	public int value__; // 0x0
	public const CorFlags ILOnly = 1;
	public const CorFlags Requires32Bit = 2;
	public const CorFlags ILLibrary = 4;
	public const CorFlags StrongNameSigned = 8;
	public const CorFlags NativeEntryPoint = 16;
	public const CorFlags TrackDebugData = 65536;
	public const CorFlags Prefers32Bit = 131072;
}

// Namespace: System.Reflection.PortableExecutable
internal sealed class CorHeader // TypeDefIndex: 16612
{
	// Fields
	[CompilerGenerated]
	private readonly ushort <MajorRuntimeVersion>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ushort <MinorRuntimeVersion>k__BackingField; // 0x12
	[CompilerGenerated]
	private readonly DirectoryEntry <MetadataDirectory>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly CorFlags <Flags>k__BackingField; // 0x1C
	[CompilerGenerated]
	private readonly int <EntryPointTokenOrRelativeVirtualAddress>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly DirectoryEntry <ResourcesDirectory>k__BackingField; // 0x24
	[CompilerGenerated]
	private readonly DirectoryEntry <StrongNameSignatureDirectory>k__BackingField; // 0x2C
	[CompilerGenerated]
	private readonly DirectoryEntry <CodeManagerTableDirectory>k__BackingField; // 0x34
	[CompilerGenerated]
	private readonly DirectoryEntry <VtableFixupsDirectory>k__BackingField; // 0x3C
	[CompilerGenerated]
	private readonly DirectoryEntry <ExportAddressTableJumpsDirectory>k__BackingField; // 0x44
	[CompilerGenerated]
	private readonly DirectoryEntry <ManagedNativeHeaderDirectory>k__BackingField; // 0x4C

	// Properties
	public DirectoryEntry MetadataDirectory { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xB220A0 Offset: 0xB212A0 VA: 0x180B220A0
	public DirectoryEntry get_MetadataDirectory() { }

	// RVA: 0x1BC53C0 Offset: 0x1BC45C0 VA: 0x181BC53C0
	internal void .ctor(ref PEBinaryReader reader) { }
}

// Namespace: System.Reflection.PortableExecutable
[Nullable(0)]
[NullableContext(1)]
[IsReadOnly]
internal struct CodeViewDebugDirectoryData // TypeDefIndex: 16613
{
	// Fields
	[CompilerGenerated]
	private readonly Guid <Guid>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly int <Age>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x18

	// Properties
	public Guid Guid { get; }
	public int Age { get; }
	public string Path { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public Guid get_Guid() { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_Age() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Path() { }

	// RVA: 0x1BC5200 Offset: 0x1BC4400 VA: 0x181BC5200
	internal void .ctor(Guid guid, int age, string path) { }
}

// Namespace: System.Reflection.PortableExecutable
[IsReadOnly]
internal struct DebugDirectoryEntry // TypeDefIndex: 16614
{
	// Fields
	[CompilerGenerated]
	private readonly uint <Stamp>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ushort <MajorVersion>k__BackingField; // 0x4
	[CompilerGenerated]
	private readonly ushort <MinorVersion>k__BackingField; // 0x6
	[CompilerGenerated]
	private readonly DebugDirectoryEntryType <Type>k__BackingField; // 0x8
	[CompilerGenerated]
	private readonly int <DataSize>k__BackingField; // 0xC
	[CompilerGenerated]
	private readonly int <DataRelativeVirtualAddress>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <DataPointer>k__BackingField; // 0x14

	// Properties
	public uint Stamp { get; }
	public ushort MinorVersion { get; }
	public DebugDirectoryEntryType Type { get; }
	public int DataSize { get; }
	public int DataRelativeVirtualAddress { get; }
	public int DataPointer { get; }
	public bool IsPortableCodeView { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_Stamp() { }

	[CompilerGenerated]
	// RVA: 0x1BC5840 Offset: 0x1BC4A40 VA: 0x181BC5840
	public ushort get_MinorVersion() { }

	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public DebugDirectoryEntryType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_DataSize() { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_DataRelativeVirtualAddress() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_DataPointer() { }

	// RVA: 0x1BC5830 Offset: 0x1BC4A30 VA: 0x181BC5830
	public bool get_IsPortableCodeView() { }

	// RVA: 0x1BC5800 Offset: 0x1BC4A00 VA: 0x181BC5800
	public void .ctor(uint stamp, ushort majorVersion, ushort minorVersion, DebugDirectoryEntryType type, int dataSize, int dataRelativeVirtualAddress, int dataPointer) { }
}

// Namespace: System.Reflection.PortableExecutable
internal enum DebugDirectoryEntryType // TypeDefIndex: 16615
{
	// Fields
	public int value__; // 0x0
	public const DebugDirectoryEntryType Unknown = 0;
	public const DebugDirectoryEntryType Coff = 1;
	public const DebugDirectoryEntryType CodeView = 2;
	public const DebugDirectoryEntryType Reproducible = 16;
	public const DebugDirectoryEntryType EmbeddedPortablePdb = 17;
	public const DebugDirectoryEntryType PdbChecksum = 19;
}

// Namespace: System.Reflection.PortableExecutable
[IsReadOnly]
internal struct DirectoryEntry // TypeDefIndex: 16616
{
	// Fields
	public readonly int RelativeVirtualAddress; // 0x0
	public readonly int Size; // 0x4

	// Methods

	// RVA: 0x1BC5990 Offset: 0x1BC4B90 VA: 0x181BC5990
	internal void .ctor(ref PEBinaryReader reader) { }
}

// Namespace: System.Reflection.PortableExecutable
internal enum Machine // TypeDefIndex: 16617
{
	// Fields
	public ushort value__; // 0x0
	public const Machine Unknown = 0;
	public const Machine I386 = 332;
	public const Machine WceMipsV2 = 361;
	public const Machine Alpha = 388;
	public const Machine SH3 = 418;
	public const Machine SH3Dsp = 419;
	public const Machine SH3E = 420;
	public const Machine SH4 = 422;
	public const Machine SH5 = 424;
	public const Machine Arm = 448;
	public const Machine Thumb = 450;
	public const Machine ArmThumb2 = 452;
	public const Machine AM33 = 467;
	public const Machine PowerPC = 496;
	public const Machine PowerPCFP = 497;
	public const Machine IA64 = 512;
	public const Machine MIPS16 = 614;
	public const Machine Alpha64 = 644;
	public const Machine MipsFpu = 870;
	public const Machine MipsFpu16 = 1126;
	public const Machine Tricore = 1312;
	public const Machine Ebc = 3772;
	public const Machine Amd64 = 34404;
	public const Machine M32R = 36929;
	public const Machine Arm64 = 43620;
}

// Namespace: System.Reflection.PortableExecutable
[Nullable(0)]
[NullableContext(1)]
[IsReadOnly]
internal struct PEBinaryReader // TypeDefIndex: 16618
{
	// Fields
	private readonly long _startOffset; // 0x0
	private readonly long _maxOffset; // 0x8
	private readonly BinaryReader _reader; // 0x10

	// Properties
	public int CurrentOffset { get; }

	// Methods

	// RVA: 0x1BD0FA0 Offset: 0x1BD01A0 VA: 0x181BD0FA0
	public void .ctor(Stream stream, int size) { }

	// RVA: 0x1BD1060 Offset: 0x1BD0260 VA: 0x181BD1060
	public int get_CurrentOffset() { }

	// RVA: 0x1BD0F30 Offset: 0x1BD0130 VA: 0x181BD0F30
	public void Seek(int offset) { }

	// RVA: 0x1BD0B80 Offset: 0x1BCFD80 VA: 0x181BD0B80
	public byte[] ReadBytes(int count) { }

	// RVA: 0x1BD0B00 Offset: 0x1BCFD00 VA: 0x181BD0B00
	public byte ReadByte() { }

	// RVA: 0x1BD0C10 Offset: 0x1BCFE10 VA: 0x181BD0C10
	public short ReadInt16() { }

	// RVA: 0x1BD0DB0 Offset: 0x1BCFFB0 VA: 0x181BD0DB0
	public ushort ReadUInt16() { }

	// RVA: 0x1BD0C90 Offset: 0x1BCFE90 VA: 0x181BD0C90
	public int ReadInt32() { }

	// RVA: 0x1BD0E30 Offset: 0x1BD0030 VA: 0x181BD0E30
	public uint ReadUInt32() { }

	// RVA: 0x1BD0EB0 Offset: 0x1BD00B0 VA: 0x181BD0EB0
	public ulong ReadUInt64() { }

	// RVA: 0x1BD0D10 Offset: 0x1BCFF10 VA: 0x181BD0D10
	public string ReadNullPaddedUTF8(int byteCount) { }

	// RVA: 0x1BD0A70 Offset: 0x1BCFC70 VA: 0x181BD0A70
	private void CheckBounds(uint count) { }

	// RVA: 0x1BD0AE0 Offset: 0x1BCFCE0 VA: 0x181BD0AE0
	private void CheckBounds(long startPosition, int count) { }
}

// Namespace: System.Reflection.PortableExecutable
[Flags]
internal enum Characteristics // TypeDefIndex: 16619
{
	// Fields
	public ushort value__; // 0x0
	public const Characteristics RelocsStripped = 1;
	public const Characteristics ExecutableImage = 2;
	public const Characteristics LineNumsStripped = 4;
	public const Characteristics LocalSymsStripped = 8;
	public const Characteristics AggressiveWSTrim = 16;
	public const Characteristics LargeAddressAware = 32;
	public const Characteristics BytesReversedLo = 128;
	public const Characteristics Bit32Machine = 256;
	public const Characteristics DebugStripped = 512;
	public const Characteristics RemovableRunFromSwap = 1024;
	public const Characteristics NetRunFromSwap = 2048;
	public const Characteristics System = 4096;
	public const Characteristics Dll = 8192;
	public const Characteristics UpSystemOnly = 16384;
	public const Characteristics BytesReversedHi = 32768;
}

// Namespace: System.Reflection.PortableExecutable
internal enum PEMagic // TypeDefIndex: 16620
{
	// Fields
	public ushort value__; // 0x0
	public const PEMagic PE32 = 267;
	public const PEMagic PE32Plus = 523;
}

// Namespace: System.Reflection.PortableExecutable
internal enum Subsystem // TypeDefIndex: 16621
{
	// Fields
	public ushort value__; // 0x0
	public const Subsystem Unknown = 0;
	public const Subsystem Native = 1;
	public const Subsystem WindowsGui = 2;
	public const Subsystem WindowsCui = 3;
	public const Subsystem OS2Cui = 5;
	public const Subsystem PosixCui = 7;
	public const Subsystem NativeWindows = 8;
	public const Subsystem WindowsCEGui = 9;
	public const Subsystem EfiApplication = 10;
	public const Subsystem EfiBootServiceDriver = 11;
	public const Subsystem EfiRuntimeDriver = 12;
	public const Subsystem EfiRom = 13;
	public const Subsystem Xbox = 14;
	public const Subsystem WindowsBootApplication = 16;
}

// Namespace: System.Reflection.PortableExecutable
[Flags]
internal enum DllCharacteristics // TypeDefIndex: 16622
{
	// Fields
	public ushort value__; // 0x0
	public const DllCharacteristics ProcessInit = 1;
	public const DllCharacteristics ProcessTerm = 2;
	public const DllCharacteristics ThreadInit = 4;
	public const DllCharacteristics ThreadTerm = 8;
	public const DllCharacteristics HighEntropyVirtualAddressSpace = 32;
	public const DllCharacteristics DynamicBase = 64;
	public const DllCharacteristics NxCompatible = 256;
	public const DllCharacteristics NoIsolation = 512;
	public const DllCharacteristics NoSeh = 1024;
	public const DllCharacteristics NoBind = 2048;
	public const DllCharacteristics AppContainer = 4096;
	public const DllCharacteristics WdmDriver = 8192;
	public const DllCharacteristics TerminalServerAware = 32768;
}

// Namespace: System.Reflection.PortableExecutable
[Flags]
internal enum SectionCharacteristics // TypeDefIndex: 16623
{
	// Fields
	public uint value__; // 0x0
	public const SectionCharacteristics TypeReg = 0;
	public const SectionCharacteristics TypeDSect = 1;
	public const SectionCharacteristics TypeNoLoad = 2;
	public const SectionCharacteristics TypeGroup = 4;
	public const SectionCharacteristics TypeNoPad = 8;
	public const SectionCharacteristics TypeCopy = 16;
	public const SectionCharacteristics ContainsCode = 32;
	public const SectionCharacteristics ContainsInitializedData = 64;
	public const SectionCharacteristics ContainsUninitializedData = 128;
	public const SectionCharacteristics LinkerOther = 256;
	public const SectionCharacteristics LinkerInfo = 512;
	public const SectionCharacteristics TypeOver = 1024;
	public const SectionCharacteristics LinkerRemove = 2048;
	public const SectionCharacteristics LinkerComdat = 4096;
	public const SectionCharacteristics MemProtected = 16384;
	public const SectionCharacteristics NoDeferSpecExc = 16384;
	public const SectionCharacteristics GPRel = 32768;
	public const SectionCharacteristics MemFardata = 32768;
	public const SectionCharacteristics MemSysheap = 65536;
	public const SectionCharacteristics MemPurgeable = 131072;
	public const SectionCharacteristics Mem16Bit = 131072;
	public const SectionCharacteristics MemLocked = 262144;
	public const SectionCharacteristics MemPreload = 524288;
	public const SectionCharacteristics Align1Bytes = 1048576;
	public const SectionCharacteristics Align2Bytes = 2097152;
	public const SectionCharacteristics Align4Bytes = 3145728;
	public const SectionCharacteristics Align8Bytes = 4194304;
	public const SectionCharacteristics Align16Bytes = 5242880;
	public const SectionCharacteristics Align32Bytes = 6291456;
	public const SectionCharacteristics Align64Bytes = 7340032;
	public const SectionCharacteristics Align128Bytes = 8388608;
	public const SectionCharacteristics Align256Bytes = 9437184;
	public const SectionCharacteristics Align512Bytes = 10485760;
	public const SectionCharacteristics Align1024Bytes = 11534336;
	public const SectionCharacteristics Align2048Bytes = 12582912;
	public const SectionCharacteristics Align4096Bytes = 13631488;
	public const SectionCharacteristics Align8192Bytes = 14680064;
	public const SectionCharacteristics AlignMask = 15728640;
	public const SectionCharacteristics LinkerNRelocOvfl = 16777216;
	public const SectionCharacteristics MemDiscardable = 33554432;
	public const SectionCharacteristics MemNotCached = 67108864;
	public const SectionCharacteristics MemNotPaged = 134217728;
	public const SectionCharacteristics MemShared = 268435456;
	public const SectionCharacteristics MemExecute = 536870912;
	public const SectionCharacteristics MemRead = 1073741824;
	public const SectionCharacteristics MemWrite = 2147483648;
}

// Namespace: System.Reflection.PortableExecutable
internal sealed class PEHeader // TypeDefIndex: 16624
{
	// Fields
	[CompilerGenerated]
	private readonly PEMagic <Magic>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly byte <MajorLinkerVersion>k__BackingField; // 0x12
	[CompilerGenerated]
	private readonly byte <MinorLinkerVersion>k__BackingField; // 0x13
	[CompilerGenerated]
	private readonly int <SizeOfCode>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly int <SizeOfInitializedData>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly int <SizeOfUninitializedData>k__BackingField; // 0x1C
	[CompilerGenerated]
	private readonly int <AddressOfEntryPoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly int <BaseOfCode>k__BackingField; // 0x24
	[CompilerGenerated]
	private readonly int <BaseOfData>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly ulong <ImageBase>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly int <SectionAlignment>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly int <FileAlignment>k__BackingField; // 0x3C
	[CompilerGenerated]
	private readonly ushort <MajorOperatingSystemVersion>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly ushort <MinorOperatingSystemVersion>k__BackingField; // 0x42
	[CompilerGenerated]
	private readonly ushort <MajorImageVersion>k__BackingField; // 0x44
	[CompilerGenerated]
	private readonly ushort <MinorImageVersion>k__BackingField; // 0x46
	[CompilerGenerated]
	private readonly ushort <MajorSubsystemVersion>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly ushort <MinorSubsystemVersion>k__BackingField; // 0x4A
	[CompilerGenerated]
	private readonly int <SizeOfImage>k__BackingField; // 0x4C
	[CompilerGenerated]
	private readonly int <SizeOfHeaders>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly uint <CheckSum>k__BackingField; // 0x54
	[CompilerGenerated]
	private readonly Subsystem <Subsystem>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly DllCharacteristics <DllCharacteristics>k__BackingField; // 0x5A
	[CompilerGenerated]
	private readonly ulong <SizeOfStackReserve>k__BackingField; // 0x60
	[CompilerGenerated]
	private readonly ulong <SizeOfStackCommit>k__BackingField; // 0x68
	[CompilerGenerated]
	private readonly ulong <SizeOfHeapReserve>k__BackingField; // 0x70
	[CompilerGenerated]
	private readonly ulong <SizeOfHeapCommit>k__BackingField; // 0x78
	[CompilerGenerated]
	private readonly int <NumberOfRvaAndSizes>k__BackingField; // 0x80
	[CompilerGenerated]
	private readonly DirectoryEntry <ExportTableDirectory>k__BackingField; // 0x84
	[CompilerGenerated]
	private readonly DirectoryEntry <ImportTableDirectory>k__BackingField; // 0x8C
	[CompilerGenerated]
	private readonly DirectoryEntry <ResourceTableDirectory>k__BackingField; // 0x94
	[CompilerGenerated]
	private readonly DirectoryEntry <ExceptionTableDirectory>k__BackingField; // 0x9C
	[CompilerGenerated]
	private readonly DirectoryEntry <CertificateTableDirectory>k__BackingField; // 0xA4
	[CompilerGenerated]
	private readonly DirectoryEntry <BaseRelocationTableDirectory>k__BackingField; // 0xAC
	[CompilerGenerated]
	private readonly DirectoryEntry <DebugTableDirectory>k__BackingField; // 0xB4
	[CompilerGenerated]
	private readonly DirectoryEntry <CopyrightTableDirectory>k__BackingField; // 0xBC
	[CompilerGenerated]
	private readonly DirectoryEntry <GlobalPointerTableDirectory>k__BackingField; // 0xC4
	[CompilerGenerated]
	private readonly DirectoryEntry <ThreadLocalStorageTableDirectory>k__BackingField; // 0xCC
	[CompilerGenerated]
	private readonly DirectoryEntry <LoadConfigTableDirectory>k__BackingField; // 0xD4
	[CompilerGenerated]
	private readonly DirectoryEntry <BoundImportTableDirectory>k__BackingField; // 0xDC
	[CompilerGenerated]
	private readonly DirectoryEntry <ImportAddressTableDirectory>k__BackingField; // 0xE4
	[CompilerGenerated]
	private readonly DirectoryEntry <DelayImportTableDirectory>k__BackingField; // 0xEC
	[CompilerGenerated]
	private readonly DirectoryEntry <CorHeaderTableDirectory>k__BackingField; // 0xF4

	// Properties
	public int SizeOfImage { get; }
	public DirectoryEntry DebugTableDirectory { get; }
	public DirectoryEntry CorHeaderTableDirectory { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x547AA0 Offset: 0x546CA0 VA: 0x180547AA0
	public int get_SizeOfImage() { }

	[CompilerGenerated]
	// RVA: 0x1862100 Offset: 0x1861300 VA: 0x181862100
	public DirectoryEntry get_DebugTableDirectory() { }

	[CompilerGenerated]
	// RVA: 0x1BD15C0 Offset: 0x1BD07C0 VA: 0x181BD15C0
	public DirectoryEntry get_CorHeaderTableDirectory() { }

	// RVA: 0x1BD10B0 Offset: 0x1BD02B0 VA: 0x181BD10B0
	internal void .ctor(ref PEBinaryReader reader) { }
}

// Namespace: System.Reflection.PortableExecutable
[Nullable(0)]
[NullableContext(1)]
internal sealed class PEHeaders // TypeDefIndex: 16625
{
	// Fields
	private readonly CoffHeader _coffHeader; // 0x10
	private readonly PEHeader _peHeader; // 0x18
	private readonly ImmutableArray<SectionHeader> _sectionHeaders; // 0x20
	private readonly CorHeader _corHeader; // 0x28
	private readonly bool _isLoadedImage; // 0x30
	private readonly int _metadataStartOffset; // 0x34
	private readonly int _metadataSize; // 0x38
	private readonly int _coffHeaderStartOffset; // 0x3C
	private readonly int _corHeaderStartOffset; // 0x40
	private readonly int _peHeaderStartOffset; // 0x44

	// Properties
	public int MetadataStartOffset { get; }
	public int MetadataSize { get; }
	public CoffHeader CoffHeader { get; }
	public bool IsCoffOnly { get; }
	[Nullable(2)]
	public PEHeader PEHeader { get; }
	[Nullable(0)]
	public ImmutableArray<SectionHeader> SectionHeaders { get; }

	// Methods

	// RVA: 0x1BD2A80 Offset: 0x1BD1C80 VA: 0x181BD2A80
	public void .ctor(Stream peStream) { }

	// RVA: 0x1BD2430 Offset: 0x1BD1630 VA: 0x181BD2430
	public void .ctor(Stream peStream, int size) { }

	// RVA: 0x1BD2450 Offset: 0x1BD1650 VA: 0x181BD2450
	public void .ctor(Stream peStream, int size, bool isLoadedImage) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public int get_MetadataStartOffset() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public int get_MetadataSize() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public CoffHeader get_CoffHeader() { }

	// RVA: 0x10EC0D0 Offset: 0x10EB2D0 VA: 0x1810EC0D0
	public bool get_IsCoffOnly() { }

	[NullableContext(2)]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public PEHeader get_PEHeader() { }

	[NullableContext(0)]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ImmutableArray<SectionHeader> get_SectionHeaders() { }

	// RVA: 0x1BD2060 Offset: 0x1BD1260 VA: 0x181BD2060
	private bool TryCalculateCorHeaderOffset(long peStreamSize, out int startOffset) { }

	// RVA: 0x1BD1E20 Offset: 0x1BD1020 VA: 0x181BD1E20
	private void SkipDosHeader(ref PEBinaryReader reader, out bool isCOFFOnly) { }

	// RVA: 0x1BD1C00 Offset: 0x1BD0E00 VA: 0x181BD1C00
	private ImmutableArray<SectionHeader> ReadSectionHeaders(ref PEBinaryReader reader) { }

	// RVA: 0x1BD2130 Offset: 0x1BD1330 VA: 0x181BD2130
	public bool TryGetDirectoryOffset(DirectoryEntry directory, out int offset) { }

	// RVA: 0x1BD2150 Offset: 0x1BD1350 VA: 0x181BD2150
	internal bool TryGetDirectoryOffset(DirectoryEntry directory, out int offset, bool canCrossSectionBoundary) { }

	// RVA: 0x1BD1970 Offset: 0x1BD0B70 VA: 0x181BD1970
	public int GetContainingSectionIndex(int relativeVirtualAddress) { }

	// RVA: 0x1BD1AF0 Offset: 0x1BD0CF0 VA: 0x181BD1AF0
	internal int IndexOfSection(string name) { }

	// RVA: 0x1BD15D0 Offset: 0x1BD07D0 VA: 0x181BD15D0
	private void CalculateMetadataLocation(long peImageSize, out int start, out int size) { }
}

// Namespace: System.Reflection.PortableExecutable
[NullableContext(1)]
[Nullable(0)]
internal sealed class PEReader : IDisposable // TypeDefIndex: 16626
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IsLoadedImage>k__BackingField; // 0x10
	private MemoryBlockProvider _peImage; // 0x18
	private PEHeaders _lazyPEHeaders; // 0x20
	private AbstractMemoryBlock _lazyMetadataBlock; // 0x28
	private AbstractMemoryBlock _lazyImageBlock; // 0x30
	private AbstractMemoryBlock[] _lazyPESectionBlocks; // 0x38

	// Properties
	public bool IsLoadedImage { get; }
	public PEHeaders PEHeaders { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsLoadedImage() { }

	// RVA: 0x1BD40F0 Offset: 0x1BD32F0 VA: 0x181BD40F0
	public void .ctor(Stream peStream) { }

	// RVA: 0x1BD45A0 Offset: 0x1BD37A0 VA: 0x181BD45A0
	public void .ctor(Stream peStream, PEStreamOptions options) { }

	// RVA: 0x1BD4110 Offset: 0x1BD3310 VA: 0x181BD4110
	public void .ctor(Stream peStream, PEStreamOptions options, int size) { }

	// RVA: 0x1BD31C0 Offset: 0x1BD23C0 VA: 0x181BD31C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1BD3390 Offset: 0x1BD2590 VA: 0x181BD3390
	private MemoryBlockProvider GetPEImage() { }

	// RVA: 0x1BD45C0 Offset: 0x1BD37C0 VA: 0x181BD45C0
	public PEHeaders get_PEHeaders() { }

	// RVA: 0x1BD33C0 Offset: 0x1BD25C0 VA: 0x181BD33C0
	private void InitializePEHeaders() { }

	// RVA: 0x1BD3E60 Offset: 0x1BD3060 VA: 0x181BD3E60
	private static PEHeaders ReadPEHeadersNoLock(Stream stream, long imageStartPosition, int imageSize, bool isLoadedImage) { }

	[NullableContext(0)]
	// RVA: 0x1BD3A50 Offset: 0x1BD2C50 VA: 0x181BD3A50
	public ImmutableArray<DebugDirectoryEntry> ReadDebugDirectory() { }

	[NullableContext(0)]
	// RVA: 0x1BD37E0 Offset: 0x1BD29E0 VA: 0x181BD37E0
	internal static ImmutableArray<DebugDirectoryEntry> ReadDebugDirectoryEntries(BlobReader reader) { }

	// RVA: 0x1BD32F0 Offset: 0x1BD24F0 VA: 0x181BD32F0
	private AbstractMemoryBlock GetDebugDirectoryEntryDataBlock(DebugDirectoryEntry entry) { }

	// RVA: 0x1BD35F0 Offset: 0x1BD27F0 VA: 0x181BD35F0
	public CodeViewDebugDirectoryData ReadCodeViewDebugDirectoryData(DebugDirectoryEntry entry) { }

	// RVA: 0x1BD2AA0 Offset: 0x1BD1CA0 VA: 0x181BD2AA0
	internal static CodeViewDebugDirectoryData DecodeCodeViewDebugDirectoryData(AbstractMemoryBlock block) { }

	// RVA: 0x1BD3F10 Offset: 0x1BD3110 VA: 0x181BD3F10
	public PdbChecksumDebugDirectoryData ReadPdbChecksumDebugDirectoryData(DebugDirectoryEntry entry) { }

	// RVA: 0x1BD2F20 Offset: 0x1BD2120 VA: 0x181BD2F20
	internal static PdbChecksumDebugDirectoryData DecodePdbChecksumDebugDirectoryData(AbstractMemoryBlock block) { }
}

// Namespace: System.Reflection.PortableExecutable
[Flags]
internal enum PEStreamOptions // TypeDefIndex: 16627
{
	// Fields
	public int value__; // 0x0
	public const PEStreamOptions Default = 0;
	public const PEStreamOptions LeaveOpen = 1;
	public const PEStreamOptions PrefetchMetadata = 2;
	public const PEStreamOptions PrefetchEntireImage = 4;
	public const PEStreamOptions IsLoadedImage = 8;
}

// Namespace: System.Reflection.PortableExecutable
[Extension]
internal static class PEStreamOptionsExtensions // TypeDefIndex: 16628
{
	// Methods

	[Extension]
	// RVA: 0x1BD45F0 Offset: 0x1BD37F0 VA: 0x181BD45F0
	public static bool IsValid(PEStreamOptions options) { }
}

// Namespace: System.Reflection.PortableExecutable
[IsReadOnly]
[NullableContext(1)]
[Nullable(0)]
internal struct SectionHeader // TypeDefIndex: 16629
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly int <VirtualSize>k__BackingField; // 0x8
	[CompilerGenerated]
	private readonly int <VirtualAddress>k__BackingField; // 0xC
	[CompilerGenerated]
	private readonly int <SizeOfRawData>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <PointerToRawData>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly int <PointerToRelocations>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly int <PointerToLineNumbers>k__BackingField; // 0x1C
	[CompilerGenerated]
	private readonly ushort <NumberOfRelocations>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly ushort <NumberOfLineNumbers>k__BackingField; // 0x22
	[CompilerGenerated]
	private readonly SectionCharacteristics <SectionCharacteristics>k__BackingField; // 0x24

	// Properties
	public string Name { get; }
	public int VirtualSize { get; }
	public int VirtualAddress { get; }
	public int SizeOfRawData { get; }
	public int PointerToRawData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_VirtualSize() { }

	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_VirtualAddress() { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_SizeOfRawData() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_PointerToRawData() { }

	// RVA: 0x1BD6640 Offset: 0x1BD5840 VA: 0x181BD6640
	internal void .ctor(ref PEBinaryReader reader) { }
}

// Namespace: System.Reflection.Metadata
[Flags]
internal enum MetadataStreamOptions // TypeDefIndex: 16630
{
	// Fields
	public int value__; // 0x0
	public const MetadataStreamOptions Default = 0;
	public const MetadataStreamOptions LeaveOpen = 1;
	public const MetadataStreamOptions PrefetchMetadata = 2;
}

// Namespace: System.Reflection.Metadata
[Extension]
internal static class MetadataStreamOptionsExtensions // TypeDefIndex: 16631
{
	// Methods

	[Extension]
	// RVA: 0x1BCFE90 Offset: 0x1BCF090 VA: 0x181BCFE90
	public static bool IsValid(MetadataStreamOptions options) { }
}

// Namespace: System.Reflection.Metadata
internal sealed class MetadataReaderProvider : IDisposable // TypeDefIndex: 16632
{
	// Fields
	private MemoryBlockProvider _blockProviderOpt; // 0x10
	private AbstractMemoryBlock _lazyMetadataBlock; // 0x18
	private MetadataReader _lazyMetadataReader; // 0x20
	private readonly object _metadataReaderGuard; // 0x28

	// Methods

	// RVA: 0x1BCA7A0 Offset: 0x1BC99A0 VA: 0x181BCA7A0
	private void .ctor(AbstractMemoryBlock metadataBlock) { }

	// RVA: 0x1BCA730 Offset: 0x1BC9930 VA: 0x181BCA730
	private void .ctor(MemoryBlockProvider blockProvider) { }

	[NullableContext(1)]
	// RVA: 0x1BCA2A0 Offset: 0x1BC94A0 VA: 0x181BCA2A0
	public static MetadataReaderProvider FromPortablePdbStream(Stream stream, MetadataStreamOptions options = 0, int size = 0) { }

	[NullableContext(1)]
	// RVA: 0x1BC9E90 Offset: 0x1BC9090 VA: 0x181BC9E90
	public static MetadataReaderProvider FromMetadataStream(Stream stream, MetadataStreamOptions options = 0, int size = 0) { }

	// RVA: 0x1BC9DF0 Offset: 0x1BC8FF0 VA: 0x181BC9DF0 Slot: 4
	public void Dispose() { }

	[NullableContext(1)]
	// RVA: 0x1BCA3D0 Offset: 0x1BC95D0 VA: 0x181BCA3D0
	public MetadataReader GetMetadataReader(MetadataReaderOptions options = 1, MetadataStringDecoder utf8Decoder) { }

	// RVA: 0x1BC9D60 Offset: 0x1BC8F60 VA: 0x181BC9D60
	private static bool CanReuseReader(MetadataReader reader, MetadataReaderOptions options, MetadataStringDecoder utf8DecoderOpt) { }

	[NullableContext(1)]
	// RVA: 0x1BCA2B0 Offset: 0x1BC94B0 VA: 0x181BCA2B0
	internal AbstractMemoryBlock GetMetadataBlock() { }
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct ModuleDefinitionHandle : IEquatable<ModuleDefinitionHandle> // TypeDefIndex: 16633
{
	// Fields
	private readonly int _rowId; // 0x0

	// Methods

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	internal void .ctor(int rowId) { }

	[NullableContext(2)]
	// RVA: 0x1BD06F0 Offset: 0x1BCF8F0 VA: 0x181BD06F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x179DB20 Offset: 0x179CD20 VA: 0x18179DB20 Slot: 4
	public bool Equals(ModuleDefinitionHandle other) { }

	// RVA: 0x1BC32B0 Offset: 0x1BC24B0 VA: 0x181BC32B0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct AssemblyDefinitionHandle : IEquatable<AssemblyDefinitionHandle> // TypeDefIndex: 16634
{
	// Fields
	private readonly int _rowId; // 0x0

	// Methods

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	internal void .ctor(int rowId) { }

	[NullableContext(2)]
	// RVA: 0x1BC3230 Offset: 0x1BC2430 VA: 0x181BC3230 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x179DB20 Offset: 0x179CD20 VA: 0x18179DB20 Slot: 4
	public bool Equals(AssemblyDefinitionHandle other) { }

	// RVA: 0x1BC32B0 Offset: 0x1BC24B0 VA: 0x181BC32B0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct MethodDefinitionHandle : IEquatable<MethodDefinitionHandle> // TypeDefIndex: 16635
{
	// Fields
	private readonly int _rowId; // 0x0

	// Methods

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	private void .ctor(int rowId) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	internal static MethodDefinitionHandle FromRowId(int rowId) { }

	// RVA: 0x1BD03B0 Offset: 0x1BCF5B0 VA: 0x181BD03B0
	public static MethodDefinitionHandle op_Explicit(Handle handle) { }

	[NullableContext(2)]
	// RVA: 0x1BD0330 Offset: 0x1BCF530 VA: 0x181BD0330 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x179DB20 Offset: 0x179CD20 VA: 0x18179DB20 Slot: 4
	public bool Equals(MethodDefinitionHandle other) { }

	// RVA: 0x1BC32B0 Offset: 0x1BC24B0 VA: 0x181BC32B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public MethodDebugInformationHandle ToDebugInformationHandle() { }
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct StringHandle : IEquatable<StringHandle> // TypeDefIndex: 16636
{
	// Fields
	private readonly uint _value; // 0x0

	// Methods

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	private void .ctor(uint value) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	internal static StringHandle FromOffset(int heapOffset) { }

	// RVA: 0x1BD7800 Offset: 0x1BD6A00 VA: 0x181BD7800
	internal int GetHeapOffset() { }

	[NullableContext(2)]
	// RVA: 0x1BD7780 Offset: 0x1BD6980 VA: 0x181BD7780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x179DB20 Offset: 0x179CD20 VA: 0x18179DB20 Slot: 4
	public bool Equals(StringHandle other) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
internal enum BlobHandle.VirtualIndex // TypeDefIndex: 16637
{
	// Fields
	public byte value__; // 0x0
	public const BlobHandle.VirtualIndex Nil = 0;
	public const BlobHandle.VirtualIndex ContractPublicKeyToken = 1;
	public const BlobHandle.VirtualIndex ContractPublicKey = 2;
	public const BlobHandle.VirtualIndex AttributeUsage_AllowSingle = 3;
	public const BlobHandle.VirtualIndex AttributeUsage_AllowMultiple = 4;
	public const BlobHandle.VirtualIndex Count = 5;
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct BlobHandle : IEquatable<BlobHandle> // TypeDefIndex: 16638
{
	// Fields
	private readonly uint _value; // 0x0

	// Properties
	internal uint RawValue { get; }
	internal bool IsVirtual { get; }
	private ushort VirtualValue { get; }

	// Methods

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	private void .ctor(uint value) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	internal static BlobHandle FromOffset(int heapOffset) { }

	[NullableContext(1)]
	// RVA: 0x1BC36D0 Offset: 0x1BC28D0 VA: 0x181BC36D0
	internal void SubstituteTemplateParameters(byte[] blob) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	internal uint get_RawValue() { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	internal int GetHeapOffset() { }

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	internal BlobHandle.VirtualIndex GetVirtualIndex() { }

	// RVA: 0x1BB1BE0 Offset: 0x1BB0DE0 VA: 0x181BB1BE0
	internal bool get_IsVirtual() { }

	// RVA: 0x1BC3700 Offset: 0x1BC2900 VA: 0x181BC3700
	private ushort get_VirtualValue() { }

	[NullableContext(2)]
	// RVA: 0x1BC3650 Offset: 0x1BC2850 VA: 0x181BC3650 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x179DB20 Offset: 0x179CD20 VA: 0x18179DB20 Slot: 4
	public bool Equals(BlobHandle other) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Reflection.Metadata
[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
internal struct BlobReader // TypeDefIndex: 16639
{
	// Fields
	private static readonly char[] s_nullCharArray; // 0x0
	private readonly MemoryBlock _block; // 0x0
	private readonly byte* _endPointer; // 0x10
	private byte* _currentPointer; // 0x18
	private static readonly uint[] s_corEncodeTokenArray; // 0x8

	// Properties
	public int Length { get; }
	public int Offset { get; set; }
	public int RemainingBytes { get; }

	// Methods

	// RVA: 0x1BC4EB0 Offset: 0x1BC40B0 VA: 0x181BC4EB0
	public void .ctor(byte* buffer, int length) { }

	// RVA: 0x1BC4E90 Offset: 0x1BC4090 VA: 0x181BC4E90
	internal void .ctor(MemoryBlock block) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_Length() { }

	// RVA: 0x1BC4FE0 Offset: 0x1BC41E0 VA: 0x181BC4FE0
	public int get_Offset() { }

	// RVA: 0x1BC5000 Offset: 0x1BC4200 VA: 0x181BC5000
	public void set_Offset(int value) { }

	// RVA: 0x1BC4FF0 Offset: 0x1BC41F0 VA: 0x181BC4FF0
	public int get_RemainingBytes() { }

	// RVA: 0x1BC4B90 Offset: 0x1BC3D90 VA: 0x181BC4B90
	public void Reset() { }

	// RVA: 0x1BC4BA0 Offset: 0x1BC3DA0 VA: 0x181BC4BA0
	internal bool TryAlign(byte alignment) { }

	// RVA: 0x1BC42B0 Offset: 0x1BC34B0 VA: 0x181BC42B0
	internal MemoryBlock GetMemoryBlockAt(int offset, int length) { }

	// RVA: 0x1BC4220 Offset: 0x1BC3420 VA: 0x181BC4220
	private void CheckBounds(int offset, int byteCount) { }

	// RVA: 0x1BC4280 Offset: 0x1BC3480 VA: 0x181BC4280
	private byte* GetCurrentPointerAndAdvance(int length) { }

	// RVA: 0x1BC4250 Offset: 0x1BC3450 VA: 0x181BC4250
	private byte* GetCurrentPointerAndAdvance1() { }

	// RVA: 0x1BC43A0 Offset: 0x1BC35A0 VA: 0x181BC43A0
	public byte ReadByte() { }

	// RVA: 0x1BC4700 Offset: 0x1BC3900 VA: 0x181BC4700
	public short ReadInt16() { }

	// RVA: 0x1BC48C0 Offset: 0x1BC3AC0 VA: 0x181BC48C0
	public ushort ReadUInt16() { }

	// RVA: 0x1BC4780 Offset: 0x1BC3980 VA: 0x181BC4780
	public int ReadInt32() { }

	// RVA: 0x1BC4930 Offset: 0x1BC3B30 VA: 0x181BC4930
	public uint ReadUInt32() { }

	// RVA: 0x1BC4800 Offset: 0x1BC3A00 VA: 0x181BC4800
	public long ReadInt64() { }

	// RVA: 0x1BC49B0 Offset: 0x1BC3BB0 VA: 0x181BC49B0
	public ulong ReadUInt64() { }

	// RVA: 0x1BC4680 Offset: 0x1BC3880 VA: 0x181BC4680
	public Guid ReadGuid() { }

	[NullableContext(1)]
	// RVA: 0x1BC4A00 Offset: 0x1BC3C00 VA: 0x181BC4A00
	public string ReadUTF8(int byteCount) { }

	[NullableContext(1)]
	// RVA: 0x1BC4400 Offset: 0x1BC3600 VA: 0x181BC4400
	public byte[] ReadBytes(int byteCount) { }

	[NullableContext(1)]
	// RVA: 0x1BC4AA0 Offset: 0x1BC3CA0 VA: 0x181BC4AA0
	internal string ReadUtf8NullTerminated() { }

	// RVA: 0x1BC4470 Offset: 0x1BC3670 VA: 0x181BC4470
	private int ReadCompressedIntegerOrInvalid() { }

	// RVA: 0x1BC4C30 Offset: 0x1BC3E30 VA: 0x181BC4C30
	public bool TryReadCompressedInteger(out int value) { }

	// RVA: 0x1BC4580 Offset: 0x1BC3780 VA: 0x181BC4580
	public int ReadCompressedInteger() { }

	// RVA: 0x1BC4C90 Offset: 0x1BC3E90 VA: 0x181BC4C90
	public bool TryReadCompressedSignedInteger(out int value) { }

	// RVA: 0x1BC4610 Offset: 0x1BC3810 VA: 0x181BC4610
	public int ReadCompressedSignedInteger() { }

	// RVA: 0x1BC4350 Offset: 0x1BC3550 VA: 0x181BC4350
	public BlobHandle ReadBlobHandle() { }

	// RVA: 0x1BC4DE0 Offset: 0x1BC3FE0 VA: 0x181BC4DE0
	private static void .cctor() { }
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct Handle : IEquatable<Handle> // TypeDefIndex: 16640
{
	// Fields
	private readonly int _value; // 0x0
	private readonly byte _vType; // 0x4
	public static readonly ModuleDefinitionHandle ModuleDefinition; // 0x0
	public static readonly AssemblyDefinitionHandle AssemblyDefinition; // 0x4

	// Properties
	internal int RowId { get; }
	internal byte VType { get; }

	// Methods

	// RVA: 0x1BC8440 Offset: 0x1BC7640 VA: 0x181BC8440
	internal static Handle FromVToken(uint vToken) { }

	// RVA: 0x1BC84D0 Offset: 0x1BC76D0 VA: 0x181BC84D0
	internal void .ctor(byte vType, int value) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	internal int get_RowId() { }

	// RVA: 0x499020 Offset: 0x498220 VA: 0x180499020
	internal byte get_VType() { }

	[NullableContext(2)]
	// RVA: 0x1BC8390 Offset: 0x1BC7590 VA: 0x181BC8390 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BC8370 Offset: 0x1BC7570 VA: 0x181BC8370 Slot: 4
	public bool Equals(Handle other) { }

	// RVA: 0x1BC8470 Offset: 0x1BC7670 VA: 0x181BC8470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BC8480 Offset: 0x1BC7680 VA: 0x181BC8480
	private static void .cctor() { }
}

// Namespace: System.Reflection.Metadata
internal enum MetadataKind // TypeDefIndex: 16641
{
	// Fields
	public int value__; // 0x0
	public const MetadataKind Ecma335 = 0;
	public const MetadataKind WindowsMetadata = 1;
	public const MetadataKind ManagedWindowsMetadata = 2;
}

// Namespace: System.Reflection.Metadata
[NullableContext(1)]
[Nullable(0)]
internal sealed class MetadataReader // TypeDefIndex: 16642
{
	// Fields
	internal readonly NamespaceCache NamespaceCache; // 0x10
	internal readonly MemoryBlock Block; // 0x18
	internal readonly int WinMDMscorlibRef; // 0x28
	private readonly object _memoryOwnerObj; // 0x30
	private readonly MetadataReaderOptions _options; // 0x38
	private readonly string _versionString; // 0x40
	private readonly MetadataKind _metadataKind; // 0x48
	private readonly MetadataStreamKind _metadataStreamKind; // 0x4C
	private readonly DebugMetadataHeader _debugMetadataHeader; // 0x50
	internal StringHeap StringHeap; // 0x58
	internal BlobHeap BlobHeap; // 0x70
	internal GuidHeap GuidHeap; // 0x88
	internal UserStringHeap UserStringHeap; // 0x98
	internal bool IsMinimalDelta; // 0xA8
	private readonly TableMask _sortedTables; // 0xB0
	internal int[] TableRowCounts; // 0xB8
	internal ModuleTableReader ModuleTable; // 0xC0
	internal TypeRefTableReader TypeRefTable; // 0xF0
	internal TypeDefTableReader TypeDefTable; // 0x118
	internal FieldPtrTableReader FieldPtrTable; // 0x150
	internal FieldTableReader FieldTable; // 0x170
	internal MethodPtrTableReader MethodPtrTable; // 0x198
	internal MethodTableReader MethodDefTable; // 0x1B8
	internal ParamPtrTableReader ParamPtrTable; // 0x1F0
	internal ParamTableReader ParamTable; // 0x210
	internal InterfaceImplTableReader InterfaceImplTable; // 0x238
	internal MemberRefTableReader MemberRefTable; // 0x260
	internal ConstantTableReader ConstantTable; // 0x288
	internal CustomAttributeTableReader CustomAttributeTable; // 0x2B0
	internal FieldMarshalTableReader FieldMarshalTable; // 0x2E0
	internal DeclSecurityTableReader DeclSecurityTable; // 0x308
	internal ClassLayoutTableReader ClassLayoutTable; // 0x330
	internal FieldLayoutTableReader FieldLayoutTable; // 0x358
	internal StandAloneSigTableReader StandAloneSigTable; // 0x380
	internal EventMapTableReader EventMapTable; // 0x3A0
	internal EventPtrTableReader EventPtrTable; // 0x3C8
	internal EventTableReader EventTable; // 0x3E8
	internal PropertyMapTableReader PropertyMapTable; // 0x410
	internal PropertyPtrTableReader PropertyPtrTable; // 0x438
	internal PropertyTableReader PropertyTable; // 0x458
	internal MethodSemanticsTableReader MethodSemanticsTable; // 0x480
	internal MethodImplTableReader MethodImplTable; // 0x4A8
	internal ModuleRefTableReader ModuleRefTable; // 0x4D0
	internal TypeSpecTableReader TypeSpecTable; // 0x4F0
	internal ImplMapTableReader ImplMapTable; // 0x510
	internal FieldRVATableReader FieldRvaTable; // 0x540
	internal EnCLogTableReader EncLogTable; // 0x568
	internal EnCMapTableReader EncMapTable; // 0x588
	internal AssemblyTableReader AssemblyTable; // 0x5A8
	internal AssemblyProcessorTableReader AssemblyProcessorTable; // 0x5E8
	internal AssemblyOSTableReader AssemblyOSTable; // 0x608
	internal AssemblyRefTableReader AssemblyRefTable; // 0x630
	internal AssemblyRefProcessorTableReader AssemblyRefProcessorTable; // 0x678
	internal AssemblyRefOSTableReader AssemblyRefOSTable; // 0x6A0
	internal FileTableReader FileTable; // 0x6D0
	internal ExportedTypeTableReader ExportedTypeTable; // 0x6F8
	internal ManifestResourceTableReader ManifestResourceTable; // 0x728
	internal NestedClassTableReader NestedClassTable; // 0x758
	internal GenericParamTableReader GenericParamTable; // 0x780
	internal MethodSpecTableReader MethodSpecTable; // 0x7B0
	internal GenericParamConstraintTableReader GenericParamConstraintTable; // 0x7D8
	internal DocumentTableReader DocumentTable; // 0x800
	internal MethodDebugInformationTableReader MethodDebugInformationTable; // 0x828
	internal LocalScopeTableReader LocalScopeTable; // 0x848
	internal LocalVariableTableReader LocalVariableTable; // 0x878
	internal LocalConstantTableReader LocalConstantTable; // 0x8A0
	internal ImportScopeTableReader ImportScopeTable; // 0x8C0
	internal StateMachineMethodTableReader StateMachineMethodTable; // 0x8E0
	internal CustomDebugInformationTableReader CustomDebugInformationTable; // 0x900
	[CompilerGenerated]
	private readonly MetadataStringDecoder <UTF8Decoder>k__BackingField; // 0x928
	internal static readonly byte[] WinRTPrefix; // 0x0

	// Properties
	public MetadataReaderOptions Options { get; }
	public MetadataStringDecoder UTF8Decoder { get; }

	// Methods

	[NullableContext(2)]
	// RVA: 0x1BCF870 Offset: 0x1BCEA70 VA: 0x181BCF870
	internal void .ctor(byte* metadata, int length, MetadataReaderOptions options, MetadataStringDecoder utf8Decoder, object memoryOwner) { }

	// RVA: 0x1BCE8D0 Offset: 0x1BCDAD0 VA: 0x181BCE8D0
	private void ReadMetadataHeader(ref BlobReader memReader, out string versionString) { }

	// RVA: 0x1BCAB20 Offset: 0x1BC9D20 VA: 0x181BCAB20
	private MetadataKind GetMetadataKind(string versionString) { }

	// RVA: 0x1BCF5B0 Offset: 0x1BCE7B0 VA: 0x181BCF5B0
	private StreamHeader[] ReadStreamHeaders(ref BlobReader memReader) { }

	// RVA: 0x1BCAC20 Offset: 0x1BC9E20 VA: 0x181BCAC20
	private void InitializeStreamReaders(in MemoryBlock metadataRoot, StreamHeader[] streamHeaders, out MetadataStreamKind metadataStreamKind, out MemoryBlock metadataTableStream, out MemoryBlock standalonePdbStream) { }

	// RVA: 0x1BCEC20 Offset: 0x1BCDE20 VA: 0x181BCEC20
	private void ReadMetadataTableHeader(ref BlobReader reader, out HeapSizes heapSizes, out int[] metadataTableRowCounts, out TableMask sortedTables) { }

	// RVA: 0x1BCF030 Offset: 0x1BCE230 VA: 0x181BCF030
	private static int[] ReadMetadataTableRowCounts(ref BlobReader memReader, ulong presentTableMask) { }

	// RVA: 0x1BCF250 Offset: 0x1BCE450 VA: 0x181BCF250
	internal static void ReadStandalonePortablePdbStream(MemoryBlock pdbStreamBlock, int pdbStreamOffset, out DebugMetadataHeader debugMetadataHeader, out int[] externalTableRowCounts) { }

	// RVA: 0x1BCABC0 Offset: 0x1BC9DC0 VA: 0x181BCABC0
	private int GetReferenceSize(int[] rowCounts, TableIndex index) { }

	// RVA: 0x1BCB5B0 Offset: 0x1BCA7B0 VA: 0x181BCB5B0
	private void InitializeTableReaders(MemoryBlock metadataTablesMemoryBlock, HeapSizes heapSizes, int[] rowCounts, int[] externalRowCountsOpt) { }

	// RVA: 0x1BCA810 Offset: 0x1BC9A10 VA: 0x181BCA810
	private static int[] CombineRowCounts(int[] local, int[] external, TableIndex firstLocalTableIndex) { }

	// RVA: 0x1BCA900 Offset: 0x1BC9B00 VA: 0x181BCA900
	private int ComputeCodedTokenSize(int largeRowSize, int[] rowCounts, TableMask tablesReferenced) { }

	// RVA: 0x1BCE8C0 Offset: 0x1BCDAC0 VA: 0x181BCE8C0
	private bool IsDeclaredSorted(TableMask index) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public MetadataReaderOptions get_Options() { }

	[CompilerGenerated]
	// RVA: 0x1BCFE80 Offset: 0x1BCF080 VA: 0x181BCFE80
	public MetadataStringDecoder get_UTF8Decoder() { }

	// RVA: 0x1BCAC10 Offset: 0x1BC9E10 VA: 0x181BCAC10
	public string GetString(DocumentNameBlobHandle handle) { }

	// RVA: 0x1BCAB00 Offset: 0x1BC9D00 VA: 0x181BCAB00
	public Document GetDocument(DocumentHandle handle) { }

	// RVA: 0x1BCAB00 Offset: 0x1BC9D00 VA: 0x181BCAB00
	public MethodDebugInformation GetMethodDebugInformation(MethodDebugInformationHandle handle) { }

	// RVA: 0x1BCA9F0 Offset: 0x1BC9BF0 VA: 0x181BCA9F0
	private int FindMscorlibAssemblyRefNoProjection() { }

	// RVA: 0x1BCF7F0 Offset: 0x1BCE9F0 VA: 0x181BCF7F0
	private static void .cctor() { }
}

// Namespace: System.Reflection.Metadata
[Flags]
internal enum MetadataReaderOptions // TypeDefIndex: 16643
{
	// Fields
	public int value__; // 0x0
	public const MetadataReaderOptions None = 0;
	public const MetadataReaderOptions Default = 1;
	public const MetadataReaderOptions ApplyWindowsRuntimeProjections = 1;
}

// Namespace: System.Reflection.Metadata
[Nullable(0)]
[NullableContext(1)]
internal class MetadataStringDecoder // TypeDefIndex: 16644
{
	// Fields
	[CompilerGenerated]
	private readonly Encoding <Encoding>k__BackingField; // 0x10
	[CompilerGenerated]
	private static readonly MetadataStringDecoder <DefaultUTF8>k__BackingField; // 0x0

	// Properties
	public Encoding Encoding { get; }
	public static MetadataStringDecoder DefaultUTF8 { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Encoding get_Encoding() { }

	[CompilerGenerated]
	// RVA: 0x1BD0000 Offset: 0x1BCF200 VA: 0x181BD0000
	public static MetadataStringDecoder get_DefaultUTF8() { }

	// RVA: 0x1BCFF80 Offset: 0x1BCF180 VA: 0x181BCFF80
	public void .ctor(Encoding encoding) { }

	[NullableContext(0)]
	// RVA: 0x1BCFEA0 Offset: 0x1BCF0A0 VA: 0x181BCFEA0 Slot: 4
	public virtual string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x1BCFEC0 Offset: 0x1BCF0C0 VA: 0x181BCFEC0
	private static void .cctor() { }
}

// Namespace: System.Reflection.Metadata
internal sealed class DebugMetadataHeader // TypeDefIndex: 16645
{
	// Fields
	[CompilerGenerated]
	private readonly ImmutableArray<byte> <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly MethodDefinitionHandle <EntryPoint>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly int <IdStartOffset>k__BackingField; // 0x1C

	// Methods

	// RVA: 0x1BC5850 Offset: 0x1BC4A50 VA: 0x181BC5850
	internal void .ctor(ImmutableArray<byte> id, MethodDefinitionHandle entryPoint, int idStartOffset) { }
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct Document // TypeDefIndex: 16646
{
	// Fields
	private readonly MetadataReader _reader; // 0x0
	private readonly int _rowId; // 0x8

	// Properties
	private DocumentHandle Handle { get; }
	public DocumentNameBlobHandle Name { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	internal void .ctor(MetadataReader reader, DocumentHandle handle) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	private DocumentHandle get_Handle() { }

	// RVA: 0x1BC5E80 Offset: 0x1BC5080 VA: 0x181BC5E80
	public DocumentNameBlobHandle get_Name() { }
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct DocumentNameBlobHandle : IEquatable<DocumentNameBlobHandle> // TypeDefIndex: 16647
{
	// Fields
	private readonly int _heapOffset; // 0x0

	// Methods

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	private void .ctor(int heapOffset) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	internal static DocumentNameBlobHandle FromOffset(int heapOffset) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	public static BlobHandle op_Implicit(DocumentNameBlobHandle handle) { }

	[NullableContext(2)]
	// RVA: 0x1BC5D50 Offset: 0x1BC4F50 VA: 0x181BC5D50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x179DB20 Offset: 0x179CD20 VA: 0x18179DB20 Slot: 4
	public bool Equals(DocumentNameBlobHandle other) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct DocumentHandle : IEquatable<DocumentHandle> // TypeDefIndex: 16648
{
	// Fields
	private readonly int _rowId; // 0x0

	// Properties
	public bool IsNil { get; }
	internal int RowId { get; }

	// Methods

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	private void .ctor(int rowId) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	internal static DocumentHandle FromRowId(int rowId) { }

	// RVA: 0x1BC5D40 Offset: 0x1BC4F40 VA: 0x181BC5D40
	public bool get_IsNil() { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	internal int get_RowId() { }

	// RVA: 0xA9F8E0 Offset: 0xA9EAE0 VA: 0x180A9F8E0
	public static bool op_Equality(DocumentHandle left, DocumentHandle right) { }

	[NullableContext(2)]
	// RVA: 0x1BC5CC0 Offset: 0x1BC4EC0 VA: 0x181BC5CC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x179DB20 Offset: 0x179CD20 VA: 0x18179DB20 Slot: 4
	public bool Equals(DocumentHandle other) { }

	// RVA: 0x1BC32B0 Offset: 0x1BC24B0 VA: 0x181BC32B0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct MethodDebugInformationHandle : IEquatable<MethodDebugInformationHandle> // TypeDefIndex: 16649
{
	// Fields
	private readonly int _rowId; // 0x0

	// Properties
	public bool IsNil { get; }
	internal int RowId { get; }

	// Methods

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	private void .ctor(int rowId) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	internal static MethodDebugInformationHandle FromRowId(int rowId) { }

	// RVA: 0x1BC5D40 Offset: 0x1BC4F40 VA: 0x181BC5D40
	public bool get_IsNil() { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	internal int get_RowId() { }

	[NullableContext(2)]
	// RVA: 0x1BD0120 Offset: 0x1BCF320 VA: 0x181BD0120 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x179DB20 Offset: 0x179CD20 VA: 0x18179DB20 Slot: 4
	public bool Equals(MethodDebugInformationHandle other) { }

	// RVA: 0x1BC32B0 Offset: 0x1BC24B0 VA: 0x181BC32B0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct MethodDebugInformation // TypeDefIndex: 16650
{
	// Fields
	private readonly MetadataReader _reader; // 0x0
	private readonly int _rowId; // 0x8

	// Properties
	private MethodDebugInformationHandle Handle { get; }
	public BlobHandle SequencePointsBlob { get; }
	public DocumentHandle Document { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	internal void .ctor(MetadataReader reader, MethodDebugInformationHandle handle) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	private MethodDebugInformationHandle get_Handle() { }

	// RVA: 0x1BD02E0 Offset: 0x1BCF4E0 VA: 0x181BD02E0
	public BlobHandle get_SequencePointsBlob() { }

	// RVA: 0x1BD02A0 Offset: 0x1BCF4A0 VA: 0x181BD02A0
	public DocumentHandle get_Document() { }

	// RVA: 0x1BD01E0 Offset: 0x1BCF3E0 VA: 0x181BD01E0
	public SequencePointCollection GetSequencePoints() { }
}

// Namespace: System.Reflection.Metadata
[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
[IsReadOnly]
internal struct SequencePoint : IEquatable<SequencePoint> // TypeDefIndex: 16651
{
	// Fields
	[CompilerGenerated]
	private readonly DocumentHandle <Document>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly int <Offset>k__BackingField; // 0x4
	[CompilerGenerated]
	private readonly int <StartLine>k__BackingField; // 0x8
	[CompilerGenerated]
	private readonly int <EndLine>k__BackingField; // 0xC
	[CompilerGenerated]
	private readonly int <StartColumn>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <EndColumn>k__BackingField; // 0x14

	// Properties
	public DocumentHandle Document { get; }
	public int Offset { get; }
	public int StartLine { get; }
	public int EndLine { get; }
	public int StartColumn { get; }
	public int EndColumn { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public DocumentHandle get_Document() { }

	[CompilerGenerated]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_Offset() { }

	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_StartLine() { }

	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_EndLine() { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_StartColumn() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_EndColumn() { }

	// RVA: 0x1BD6A80 Offset: 0x1BD5C80 VA: 0x181BD6A80
	internal void .ctor(DocumentHandle document, int offset) { }

	// RVA: 0x1BD6AA0 Offset: 0x1BD5CA0 VA: 0x181BD6AA0
	internal void .ctor(DocumentHandle document, int offset, int startLine, ushort startColumn, int endLine, ushort endColumn) { }

	// RVA: 0x1BD6A50 Offset: 0x1BD5C50 VA: 0x181BD6A50 Slot: 2
	public override int GetHashCode() { }

	[NullableContext(2)]
	// RVA: 0x1BD6920 Offset: 0x1BD5B20 VA: 0x181BD6920 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BD6A10 Offset: 0x1BD5C10 VA: 0x181BD6A10 Slot: 4
	public bool Equals(SequencePoint other) { }
}

// Namespace: 
public struct SequencePointCollection.Enumerator : IEnumerator<SequencePoint>, IEnumerator, IDisposable // TypeDefIndex: 16652
{
	// Fields
	private BlobReader _reader; // 0x0
	private SequencePoint _current; // 0x20
	private int _previousNonHiddenStartLine; // 0x38
	private ushort _previousNonHiddenStartColumn; // 0x3C

	// Properties
	public SequencePoint Current { get; }
	[Nullable(1)]
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1BC75E0 Offset: 0x1BC67E0 VA: 0x181BC75E0
	internal void .ctor(MemoryBlock block, DocumentHandle document) { }

	// RVA: 0x1BC6F30 Offset: 0x1BC6130 VA: 0x181BC6F30 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x1BC73C0 Offset: 0x1BC65C0 VA: 0x181BC73C0
	private void ReadDeltaLinesAndColumns(out int deltaLines, out int deltaColumns) { }

	// RVA: 0x1BC74E0 Offset: 0x1BC66E0 VA: 0x181BC74E0
	private int ReadLine() { }

	// RVA: 0x1BC7360 Offset: 0x1BC6560 VA: 0x181BC7360
	private ushort ReadColumn() { }

	// RVA: 0x1BC6F10 Offset: 0x1BC6110 VA: 0x181BC6F10
	private int AddOffsets(int value, int delta) { }

	// RVA: 0x1BC6EF0 Offset: 0x1BC60F0 VA: 0x181BC6EF0
	private int AddLines(int value, int delta) { }

	// RVA: 0x1BC6ED0 Offset: 0x1BC60D0 VA: 0x181BC6ED0
	private ushort AddColumns(ushort value, int delta) { }

	// RVA: 0x1BC7480 Offset: 0x1BC6680 VA: 0x181BC7480
	private DocumentHandle ReadDocumentHandle() { }

	// RVA: 0x415790 Offset: 0x414990 VA: 0x180415790 Slot: 4
	public SequencePoint get_Current() { }

	// RVA: 0x1BC7590 Offset: 0x1BC6790 VA: 0x181BC7590 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1BC7530 Offset: 0x1BC6730 VA: 0x181BC7530 Slot: 8
	public void Reset() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }
}

// Namespace: System.Reflection.Metadata
[IsReadOnly]
internal struct SequencePointCollection : IEnumerable<SequencePoint>, IEnumerable // TypeDefIndex: 16653
{
	// Fields
	private readonly MemoryBlock _block; // 0x0
	private readonly DocumentHandle _document; // 0x10

	// Methods

	// RVA: 0x13144C0 Offset: 0x13136C0 VA: 0x1813144C0
	internal void .ctor(MemoryBlock block, DocumentHandle document) { }

	// RVA: 0x1BD66F0 Offset: 0x1BD58F0 VA: 0x181BD66F0
	public SequencePointCollection.Enumerator GetEnumerator() { }

	// RVA: 0x1BD6850 Offset: 0x1BD5A50 VA: 0x181BD6850 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1BD6780 Offset: 0x1BD5980 VA: 0x181BD6780 Slot: 4
	private IEnumerator<SequencePoint> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.SequencePoint>.GetEnumerator() { }
}

// Namespace: 
private struct VirtualHeap.PinnedBlob // TypeDefIndex: 16654
{
	// Fields
	public GCHandle Handle; // 0x0
	public readonly int Length; // 0x8

	// Methods

	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	public void .ctor(GCHandle handle, int length) { }

	// RVA: 0x1BD4600 Offset: 0x1BD3800 VA: 0x181BD4600
	public MemoryBlock GetMemoryBlock() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[Nullable(0)]
[NullableContext(1)]
internal sealed class VirtualHeap : CriticalDisposableObject // TypeDefIndex: 16655
{
	// Fields
	private Dictionary<uint, VirtualHeap.PinnedBlob> _blobs; // 0x10

	// Methods

	// RVA: 0x1BD93E0 Offset: 0x1BD85E0 VA: 0x181BD93E0
	private void .ctor() { }

	// RVA: 0x1BD9190 Offset: 0x1BD8390 VA: 0x181BD9190 Slot: 5
	protected override void Release() { }

	// RVA: 0x1BD9060 Offset: 0x1BD8260 VA: 0x181BD9060
	private Dictionary<uint, VirtualHeap.PinnedBlob> GetBlobs() { }

	// RVA: 0x1BD92D0 Offset: 0x1BD84D0 VA: 0x181BD92D0
	public bool TryGetMemoryBlock(uint rawHandle, out MemoryBlock block) { }

	// RVA: 0x1BD8F10 Offset: 0x1BD8110 VA: 0x181BD8F10
	internal MemoryBlock AddBlob(uint rawHandle, byte[] value) { }

	// RVA: 0x1BD90D0 Offset: 0x1BD82D0 VA: 0x181BD90D0
	internal static VirtualHeap GetOrCreateVirtualHeap(ref VirtualHeap lazyHeap) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct GuidHeap // TypeDefIndex: 16656
{
	// Fields
	internal readonly MemoryBlock Block; // 0x0

	// Methods

	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	public void .ctor(MemoryBlock block) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[Nullable(0)]
[NullableContext(1)]
internal struct BlobHeap // TypeDefIndex: 16657
{
	// Fields
	private static byte[][] s_virtualValues; // 0x0
	internal readonly MemoryBlock Block; // 0x0
	private VirtualHeap _lazyVirtualHeap; // 0x10

	// Methods

	// RVA: 0x1BC4060 Offset: 0x1BC3260 VA: 0x181BC4060
	internal void .ctor(MemoryBlock block, MetadataKind metadataKind) { }

	// RVA: 0x1BC3BA0 Offset: 0x1BC2DA0 VA: 0x181BC3BA0
	internal MemoryBlock GetMemoryBlock(BlobHandle handle) { }

	// RVA: 0x1BC3E00 Offset: 0x1BC3000 VA: 0x181BC3E00
	private MemoryBlock GetVirtualHandleMemoryBlock(BlobHandle handle) { }

	// RVA: 0x1BC3710 Offset: 0x1BC2910 VA: 0x181BC3710
	internal BlobReader GetBlobReader(BlobHandle handle) { }

	// RVA: 0x1BC3CC0 Offset: 0x1BC2EC0 VA: 0x181BC3CC0
	internal byte[] GetVirtualBlobBytes(BlobHandle handle, bool unique) { }

	// RVA: 0x1BC3750 Offset: 0x1BC2950 VA: 0x181BC3750
	public string GetDocumentName(DocumentNameBlobHandle handle) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[NullableContext(1)]
[Nullable(0)]
internal struct StringHeap // TypeDefIndex: 16658
{
	// Fields
	private static string[] s_virtualValues; // 0x0
	internal readonly MemoryBlock Block; // 0x0
	private VirtualHeap _lazyVirtualHeap; // 0x10

	// Methods

	// RVA: 0x1BD78D0 Offset: 0x1BD6AD0 VA: 0x181BD78D0
	internal void .ctor(MemoryBlock block, MetadataKind metadataKind) { }

	// RVA: 0x1BD7830 Offset: 0x1BD6A30 VA: 0x181BD7830
	private static MemoryBlock TrimEnd(MemoryBlock block) { }

	// RVA: 0x1BD7810 Offset: 0x1BD6A10 VA: 0x181BD7810
	internal bool EqualsRaw(StringHandle rawHandle, string asciiString) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[Nullable(0)]
[NullableContext(1)]
[Extension]
internal static class MetadataTokens // TypeDefIndex: 16659
{
	// Fields
	public static readonly int TableCount; // 0x0
	public static readonly int HeapCount; // 0x4

	// Methods

	// RVA: 0x1BD0050 Offset: 0x1BCF250 VA: 0x181BD0050
	public static Handle Handle(int token) { }

	// RVA: 0x1BD00D0 Offset: 0x1BCF2D0 VA: 0x181BD00D0
	private static void .cctor() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
internal enum TableIndex // TypeDefIndex: 16660
{
	// Fields
	public byte value__; // 0x0
	public const TableIndex Module = 0;
	public const TableIndex TypeRef = 1;
	public const TableIndex TypeDef = 2;
	public const TableIndex FieldPtr = 3;
	public const TableIndex Field = 4;
	public const TableIndex MethodPtr = 5;
	public const TableIndex MethodDef = 6;
	public const TableIndex ParamPtr = 7;
	public const TableIndex Param = 8;
	public const TableIndex InterfaceImpl = 9;
	public const TableIndex MemberRef = 10;
	public const TableIndex Constant = 11;
	public const TableIndex CustomAttribute = 12;
	public const TableIndex FieldMarshal = 13;
	public const TableIndex DeclSecurity = 14;
	public const TableIndex ClassLayout = 15;
	public const TableIndex FieldLayout = 16;
	public const TableIndex StandAloneSig = 17;
	public const TableIndex EventMap = 18;
	public const TableIndex EventPtr = 19;
	public const TableIndex Event = 20;
	public const TableIndex PropertyMap = 21;
	public const TableIndex PropertyPtr = 22;
	public const TableIndex Property = 23;
	public const TableIndex MethodSemantics = 24;
	public const TableIndex MethodImpl = 25;
	public const TableIndex ModuleRef = 26;
	public const TableIndex TypeSpec = 27;
	public const TableIndex ImplMap = 28;
	public const TableIndex FieldRva = 29;
	public const TableIndex EncLog = 30;
	public const TableIndex EncMap = 31;
	public const TableIndex Assembly = 32;
	public const TableIndex AssemblyProcessor = 33;
	public const TableIndex AssemblyOS = 34;
	public const TableIndex AssemblyRef = 35;
	public const TableIndex AssemblyRefProcessor = 36;
	public const TableIndex AssemblyRefOS = 37;
	public const TableIndex File = 38;
	public const TableIndex ExportedType = 39;
	public const TableIndex ManifestResource = 40;
	public const TableIndex NestedClass = 41;
	public const TableIndex GenericParam = 42;
	public const TableIndex MethodSpec = 43;
	public const TableIndex GenericParamConstraint = 44;
	public const TableIndex Document = 48;
	public const TableIndex MethodDebugInformation = 49;
	public const TableIndex LocalScope = 50;
	public const TableIndex LocalVariable = 51;
	public const TableIndex LocalConstant = 52;
	public const TableIndex ImportScope = 53;
	public const TableIndex StateMachineMethod = 54;
	public const TableIndex CustomDebugInformation = 55;
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct UserStringHeap // TypeDefIndex: 16661
{
	// Fields
	internal readonly MemoryBlock Block; // 0x0

	// Methods

	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	public void .ctor(MemoryBlock block) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
internal enum MetadataStreamKind // TypeDefIndex: 16662
{
	// Fields
	public int value__; // 0x0
	public const MetadataStreamKind Illegal = 0;
	public const MetadataStreamKind Compressed = 1;
	public const MetadataStreamKind Uncompressed = 2;
}

// Namespace: System.Reflection.Metadata.Ecma335
[Flags]
internal enum TableMask // TypeDefIndex: 16663
{
	// Fields
	public ulong value__; // 0x0
	public const TableMask Module = 1;
	public const TableMask TypeRef = 2;
	public const TableMask TypeDef = 4;
	public const TableMask FieldPtr = 8;
	public const TableMask Field = 16;
	public const TableMask MethodPtr = 32;
	public const TableMask MethodDef = 64;
	public const TableMask ParamPtr = 128;
	public const TableMask Param = 256;
	public const TableMask InterfaceImpl = 512;
	public const TableMask MemberRef = 1024;
	public const TableMask Constant = 2048;
	public const TableMask CustomAttribute = 4096;
	public const TableMask FieldMarshal = 8192;
	public const TableMask DeclSecurity = 16384;
	public const TableMask ClassLayout = 32768;
	public const TableMask FieldLayout = 65536;
	public const TableMask StandAloneSig = 131072;
	public const TableMask EventMap = 262144;
	public const TableMask EventPtr = 524288;
	public const TableMask Event = 1048576;
	public const TableMask PropertyMap = 2097152;
	public const TableMask PropertyPtr = 4194304;
	public const TableMask Property = 8388608;
	public const TableMask MethodSemantics = 16777216;
	public const TableMask MethodImpl = 33554432;
	public const TableMask ModuleRef = 67108864;
	public const TableMask TypeSpec = 134217728;
	public const TableMask ImplMap = 268435456;
	public const TableMask FieldRva = 536870912;
	public const TableMask EnCLog = 1073741824;
	public const TableMask EnCMap = 2147483648;
	public const TableMask Assembly = 4294967296;
	public const TableMask AssemblyRef = 34359738368;
	public const TableMask File = 274877906944;
	public const TableMask ExportedType = 549755813888;
	public const TableMask ManifestResource = 1099511627776;
	public const TableMask NestedClass = 2199023255552;
	public const TableMask GenericParam = 4398046511104;
	public const TableMask MethodSpec = 8796093022208;
	public const TableMask GenericParamConstraint = 17592186044416;
	public const TableMask Document = 281474976710656;
	public const TableMask MethodDebugInformation = 562949953421312;
	public const TableMask LocalScope = 1125899906842624;
	public const TableMask LocalVariable = 2251799813685248;
	public const TableMask LocalConstant = 4503599627370496;
	public const TableMask ImportScope = 9007199254740992;
	public const TableMask StateMachineMethod = 18014398509481984;
	public const TableMask CustomDebugInformation = 36028797018963968;
	public const TableMask PtrTables = 4718760;
	public const TableMask EncTables = 3221225472;
	public const TableMask TypeSystemTables = 34952443854847;
	public const TableMask DebugTables = 71776119061217280;
	public const TableMask AllTables = 71811071505072127;
	public const TableMask ValidPortablePdbExternalTables = 34949217910615;
}

// Namespace: System.Reflection.Metadata.Ecma335
internal enum HeapSizes // TypeDefIndex: 16664
{
	// Fields
	public byte value__; // 0x0
	public const HeapSizes StringHeapLarge = 1;
	public const HeapSizes GuidHeapLarge = 2;
	public const HeapSizes BlobHeapLarge = 4;
	public const HeapSizes ExtraData = 64;
}

// Namespace: System.Reflection.Metadata.Ecma335
internal static class HeapHandleType // TypeDefIndex: 16665
{
	// Methods

	// RVA: 0x1BC84F0 Offset: 0x1BC76F0 VA: 0x181BC84F0
	internal static bool IsValidHeapOffset(uint offset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
internal static class TokenTypeIds // TypeDefIndex: 16666
{
	// Methods

	// RVA: 0x1BD8AC0 Offset: 0x1BD7CC0 VA: 0x181BD8AC0
	internal static bool IsEntityOrUserStringToken(uint vToken) { }

	// RVA: 0x1BD8AD0 Offset: 0x1BD7CD0 VA: 0x181BD8AD0
	internal static bool IsValidRowId(uint rowId) { }

	// RVA: 0x1BD8AD0 Offset: 0x1BD7CD0 VA: 0x181BD8AD0
	internal static bool IsValidRowId(int rowId) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[NullableContext(1)]
[Nullable(0)]
internal class NamespaceCache // TypeDefIndex: 16667
{
	// Fields
	private readonly MetadataReader _metadataReader; // 0x10
	private readonly object _namespaceTableAndListLock; // 0x18

	// Methods

	// RVA: 0x1BD0820 Offset: 0x1BCFA20 VA: 0x181BD0820
	internal void .ctor(MetadataReader reader) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
internal struct StreamHeader // TypeDefIndex: 16668
{
	// Fields
	internal uint Offset; // 0x0
	internal int Size; // 0x4
	[Nullable(1)]
	internal string Name; // 0x8
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct ModuleTableReader // TypeDefIndex: 16669
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsStringHeapRefSizeSmall; // 0x4
	private readonly bool _IsGUIDHeapRefSizeSmall; // 0x5
	private readonly int _GenerationOffset; // 0x8
	private readonly int _NameOffset; // 0xC
	private readonly int _MVIdOffset; // 0x10
	private readonly int _EnCIdOffset; // 0x14
	private readonly int _EnCBaseIdOffset; // 0x18
	internal readonly int RowSize; // 0x1C
	internal readonly MemoryBlock Block; // 0x20

	// Methods

	// RVA: 0x1BD0770 Offset: 0x1BCF970 VA: 0x181BD0770
	internal void .ctor(int numberOfRows, int stringHeapRefSize, int guidHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct TypeRefTableReader // TypeDefIndex: 16670
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsResolutionScopeRefSizeSmall; // 0x4
	private readonly bool _IsStringHeapRefSizeSmall; // 0x5
	private readonly int _ResolutionScopeOffset; // 0x8
	private readonly int _NameOffset; // 0xC
	private readonly int _NamespaceOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BD8BC0 Offset: 0x1BD7DC0 VA: 0x181BD8BC0
	internal void .ctor(int numberOfRows, int resolutionScopeRefSize, int stringHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
internal struct TypeDefTableReader // TypeDefIndex: 16671
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsFieldRefSizeSmall; // 0x4
	private readonly bool _IsMethodRefSizeSmall; // 0x5
	private readonly bool _IsTypeDefOrRefRefSizeSmall; // 0x6
	private readonly bool _IsStringHeapRefSizeSmall; // 0x7
	private readonly int _FlagsOffset; // 0x8
	private readonly int _NameOffset; // 0xC
	private readonly int _NamespaceOffset; // 0x10
	private readonly int _ExtendsOffset; // 0x14
	private readonly int _FieldListOffset; // 0x18
	private readonly int _MethodListOffset; // 0x1C
	internal readonly int RowSize; // 0x20
	internal MemoryBlock Block; // 0x28

	// Methods

	// RVA: 0x1BD8AE0 Offset: 0x1BD7CE0 VA: 0x181BD8AE0
	internal void .ctor(int numberOfRows, int fieldRefSize, int methodRefSize, int typeDefOrRefRefSize, int stringHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct FieldPtrTableReader // TypeDefIndex: 16672
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsFieldTableRowRefSizeSmall; // 0x4
	private readonly int _FieldOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC76E0 Offset: 0x1BC68E0 VA: 0x181BC76E0
	internal void .ctor(int numberOfRows, int fieldTableRowRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct FieldTableReader // TypeDefIndex: 16673
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsStringHeapRefSizeSmall; // 0x4
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x5
	private readonly int _FlagsOffset; // 0x8
	private readonly int _NameOffset; // 0xC
	private readonly int _SignatureOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC7C90 Offset: 0x1BC6E90 VA: 0x181BC7C90
	internal void .ctor(int numberOfRows, int stringHeapRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct MethodPtrTableReader // TypeDefIndex: 16674
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsMethodTableRowRefSizeSmall; // 0x4
	private readonly int _MethodOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC76E0 Offset: 0x1BC68E0 VA: 0x181BC76E0
	internal void .ctor(int numberOfRows, int methodTableRowRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct MethodTableReader // TypeDefIndex: 16675
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsParamRefSizeSmall; // 0x4
	private readonly bool _IsStringHeapRefSizeSmall; // 0x5
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x6
	private readonly int _RvaOffset; // 0x8
	private readonly int _ImplFlagsOffset; // 0xC
	private readonly int _FlagsOffset; // 0x10
	private readonly int _NameOffset; // 0x14
	private readonly int _SignatureOffset; // 0x18
	private readonly int _ParamListOffset; // 0x1C
	internal readonly int RowSize; // 0x20
	internal readonly MemoryBlock Block; // 0x28

	// Methods

	// RVA: 0x1BD0630 Offset: 0x1BCF830 VA: 0x181BD0630
	internal void .ctor(int numberOfRows, int paramRefSize, int stringHeapRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct ParamPtrTableReader // TypeDefIndex: 16676
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsParamTableRowRefSizeSmall; // 0x4
	private readonly int _ParamOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC76E0 Offset: 0x1BC68E0 VA: 0x181BC76E0
	internal void .ctor(int numberOfRows, int paramTableRowRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct ParamTableReader // TypeDefIndex: 16677
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsStringHeapRefSizeSmall; // 0x4
	private readonly int _FlagsOffset; // 0x8
	private readonly int _SequenceOffset; // 0xC
	private readonly int _NameOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC89D0 Offset: 0x1BC7BD0 VA: 0x181BC89D0
	internal void .ctor(int numberOfRows, int stringHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct InterfaceImplTableReader // TypeDefIndex: 16678
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsTypeDefTableRowRefSizeSmall; // 0x4
	private readonly bool _IsTypeDefOrRefRefSizeSmall; // 0x5
	private readonly int _ClassOffset; // 0x8
	private readonly int _InterfaceOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC86D0 Offset: 0x1BC78D0 VA: 0x181BC86D0
	internal void .ctor(int numberOfRows, bool declaredSorted, int typeDefTableRowRefSize, int typeDefOrRefRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC7AC0 Offset: 0x1BC6CC0 VA: 0x181BC7AC0
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
internal struct MemberRefTableReader // TypeDefIndex: 16679
{
	// Fields
	internal int NumberOfRows; // 0x0
	private readonly bool _IsMemberRefParentRefSizeSmall; // 0x4
	private readonly bool _IsStringHeapRefSizeSmall; // 0x5
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x6
	private readonly int _ClassOffset; // 0x8
	private readonly int _NameOffset; // 0xC
	private readonly int _SignatureOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC8AF0 Offset: 0x1BC7CF0 VA: 0x181BC8AF0
	internal void .ctor(int numberOfRows, int memberRefParentRefSize, int stringHeapRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct ConstantTableReader // TypeDefIndex: 16680
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsHasConstantRefSizeSmall; // 0x4
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x5
	private readonly int _TypeOffset; // 0x8
	private readonly int _ParentOffset; // 0xC
	private readonly int _ValueOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC52D0 Offset: 0x1BC44D0 VA: 0x181BC52D0
	internal void .ctor(int numberOfRows, bool declaredSorted, int hasConstantRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC52A0 Offset: 0x1BC44A0 VA: 0x181BC52A0
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct CustomAttributeTableReader // TypeDefIndex: 16681
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsHasCustomAttributeRefSizeSmall; // 0x4
	private readonly bool _IsCustomAttributeTypeRefSizeSmall; // 0x5
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x6
	private readonly int _ParentOffset; // 0x8
	private readonly int _TypeOffset; // 0xC
	private readonly int _ValueOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18
	[Nullable(2)]
	internal readonly int[] PtrTable; // 0x28

	// Methods

	// RVA: 0x1BC5630 Offset: 0x1BC4830 VA: 0x181BC5630
	internal void .ctor(int numberOfRows, bool declaredSorted, int hasCustomAttributeRefSize, int customAttributeTypeRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC5600 Offset: 0x1BC4800 VA: 0x181BC5600
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct FieldMarshalTableReader // TypeDefIndex: 16682
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsHasFieldMarshalRefSizeSmall; // 0x4
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x5
	private readonly int _ParentOffset; // 0x8
	private readonly int _NativeTypeOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC7AF0 Offset: 0x1BC6CF0 VA: 0x181BC7AF0
	internal void .ctor(int numberOfRows, bool declaredSorted, int hasFieldMarshalRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC7AC0 Offset: 0x1BC6CC0 VA: 0x181BC7AC0
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct DeclSecurityTableReader // TypeDefIndex: 16683
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsHasDeclSecurityRefSizeSmall; // 0x4
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x5
	private readonly int _ActionOffset; // 0x8
	private readonly int _ParentOffset; // 0xC
	private readonly int _PermissionSetOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC58A0 Offset: 0x1BC4AA0 VA: 0x181BC58A0
	internal void .ctor(int numberOfRows, bool declaredSorted, int hasDeclSecurityRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC52A0 Offset: 0x1BC44A0 VA: 0x181BC52A0
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
internal struct ClassLayoutTableReader // TypeDefIndex: 16684
{
	// Fields
	internal int NumberOfRows; // 0x0
	private readonly bool _IsTypeDefTableRowRefSizeSmall; // 0x4
	private readonly int _PackagingSizeOffset; // 0x8
	private readonly int _ClassSizeOffset; // 0xC
	private readonly int _ParentOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC5130 Offset: 0x1BC4330 VA: 0x181BC5130
	internal void .ctor(int numberOfRows, bool declaredSorted, int typeDefTableRowRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC5100 Offset: 0x1BC4300 VA: 0x181BC5100
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct FieldLayoutTableReader // TypeDefIndex: 16685
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsFieldTableRowRefSizeSmall; // 0x4
	private readonly int _OffsetOffset; // 0x8
	private readonly int _FieldOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC7A00 Offset: 0x1BC6C00 VA: 0x181BC7A00
	internal void .ctor(int numberOfRows, bool declaredSorted, int fieldTableRowRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC79D0 Offset: 0x1BC6BD0 VA: 0x181BC79D0
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct StandAloneSigTableReader // TypeDefIndex: 16686
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x4
	private readonly int _SignatureOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC76E0 Offset: 0x1BC68E0 VA: 0x181BC76E0
	internal void .ctor(int numberOfRows, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct EventMapTableReader // TypeDefIndex: 16687
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsTypeDefTableRowRefSizeSmall; // 0x4
	private readonly bool _IsEventRefSizeSmall; // 0x5
	private readonly int _ParentOffset; // 0x8
	private readonly int _EventListOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC7660 Offset: 0x1BC6860 VA: 0x181BC7660
	internal void .ctor(int numberOfRows, int typeDefTableRowRefSize, int eventRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct EventPtrTableReader // TypeDefIndex: 16688
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsEventTableRowRefSizeSmall; // 0x4
	private readonly int _EventOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC76E0 Offset: 0x1BC68E0 VA: 0x181BC76E0
	internal void .ctor(int numberOfRows, int eventTableRowRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
internal struct EventTableReader // TypeDefIndex: 16689
{
	// Fields
	internal int NumberOfRows; // 0x0
	private readonly bool _IsTypeDefOrRefRefSizeSmall; // 0x4
	private readonly bool _IsStringHeapRefSizeSmall; // 0x5
	private readonly int _FlagsOffset; // 0x8
	private readonly int _NameOffset; // 0xC
	private readonly int _EventTypeOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC7740 Offset: 0x1BC6940 VA: 0x181BC7740
	internal void .ctor(int numberOfRows, int typeDefOrRefRefSize, int stringHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct PropertyMapTableReader // TypeDefIndex: 16690
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsTypeDefTableRowRefSizeSmall; // 0x4
	private readonly bool _IsPropertyRefSizeSmall; // 0x5
	private readonly int _ParentOffset; // 0x8
	private readonly int _PropertyListOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC7660 Offset: 0x1BC6860 VA: 0x181BC7660
	internal void .ctor(int numberOfRows, int typeDefTableRowRefSize, int propertyRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct PropertyPtrTableReader // TypeDefIndex: 16691
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsPropertyTableRowRefSizeSmall; // 0x4
	private readonly int _PropertyOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC76E0 Offset: 0x1BC68E0 VA: 0x181BC76E0
	internal void .ctor(int numberOfRows, int propertyTableRowRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct PropertyTableReader // TypeDefIndex: 16692
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsStringHeapRefSizeSmall; // 0x4
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x5
	private readonly int _FlagsOffset; // 0x8
	private readonly int _NameOffset; // 0xC
	private readonly int _SignatureOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC7C90 Offset: 0x1BC6E90 VA: 0x181BC7C90
	internal void .ctor(int numberOfRows, int stringHeapRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct MethodSemanticsTableReader // TypeDefIndex: 16693
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsMethodTableRowRefSizeSmall; // 0x4
	private readonly bool _IsHasSemanticRefSizeSmall; // 0x5
	private readonly int _SemanticsFlagOffset; // 0x8
	private readonly int _MethodOffset; // 0xC
	private readonly int _AssociationOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BD0540 Offset: 0x1BCF740 VA: 0x181BD0540
	internal void .ctor(int numberOfRows, bool declaredSorted, int methodTableRowRefSize, int hasSemanticRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BD0510 Offset: 0x1BCF710 VA: 0x181BD0510
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct MethodImplTableReader // TypeDefIndex: 16694
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsTypeDefTableRowRefSizeSmall; // 0x4
	private readonly bool _IsMethodDefOrRefRefSizeSmall; // 0x5
	private readonly int _ClassOffset; // 0x8
	private readonly int _MethodBodyOffset; // 0xC
	private readonly int _MethodDeclarationOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BD0420 Offset: 0x1BCF620 VA: 0x181BD0420
	internal void .ctor(int numberOfRows, bool declaredSorted, int typeDefTableRowRefSize, int methodDefOrRefRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC5600 Offset: 0x1BC4800 VA: 0x181BC5600
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct ModuleRefTableReader // TypeDefIndex: 16695
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsStringHeapRefSizeSmall; // 0x4
	private readonly int _NameOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC76E0 Offset: 0x1BC68E0 VA: 0x181BC76E0
	internal void .ctor(int numberOfRows, int stringHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct TypeSpecTableReader // TypeDefIndex: 16696
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x4
	private readonly int _SignatureOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC76E0 Offset: 0x1BC68E0 VA: 0x181BC76E0
	internal void .ctor(int numberOfRows, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct ImplMapTableReader // TypeDefIndex: 16697
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsModuleRefTableRowRefSizeSmall; // 0x4
	private readonly bool _IsMemberForwardRowRefSizeSmall; // 0x5
	private readonly bool _IsStringHeapRefSizeSmall; // 0x6
	private readonly int _FlagsOffset; // 0x8
	private readonly int _MemberForwardedOffset; // 0xC
	private readonly int _ImportNameOffset; // 0x10
	private readonly int _ImportScopeOffset; // 0x14
	internal readonly int RowSize; // 0x18
	internal readonly MemoryBlock Block; // 0x20

	// Methods

	// RVA: 0x1BC8540 Offset: 0x1BC7740 VA: 0x181BC8540
	internal void .ctor(int numberOfRows, bool declaredSorted, int moduleRefTableRowRefSize, int memberForwardedRefSize, int stringHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC8510 Offset: 0x1BC7710 VA: 0x181BC8510
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct FieldRVATableReader // TypeDefIndex: 16698
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsFieldTableRowRefSizeSmall; // 0x4
	private readonly int _RvaOffset; // 0x8
	private readonly int _FieldOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC7BD0 Offset: 0x1BC6DD0 VA: 0x181BC7BD0
	internal void .ctor(int numberOfRows, bool declaredSorted, int fieldTableRowRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC79D0 Offset: 0x1BC6BD0 VA: 0x181BC79D0
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct EnCLogTableReader // TypeDefIndex: 16699
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly int _TokenOffset; // 0x4
	private readonly int _FuncCodeOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC5EC0 Offset: 0x1BC50C0 VA: 0x181BC5EC0
	internal void .ctor(int numberOfRows, MemoryBlock containingBlock, int containingBlockOffset, MetadataStreamKind metadataStreamKind) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct EnCMapTableReader // TypeDefIndex: 16700
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly int _TokenOffset; // 0x4
	internal readonly int RowSize; // 0x8
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC3340 Offset: 0x1BC2540 VA: 0x181BC3340
	internal void .ctor(int numberOfRows, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct AssemblyTableReader // TypeDefIndex: 16701
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsStringHeapRefSizeSmall; // 0x4
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x5
	private readonly int _HashAlgIdOffset; // 0x8
	private readonly int _MajorVersionOffset; // 0xC
	private readonly int _MinorVersionOffset; // 0x10
	private readonly int _BuildNumberOffset; // 0x14
	private readonly int _RevisionNumberOffset; // 0x18
	private readonly int _FlagsOffset; // 0x1C
	private readonly int _PublicKeyOffset; // 0x20
	private readonly int _NameOffset; // 0x24
	private readonly int _CultureOffset; // 0x28
	internal readonly int RowSize; // 0x2C
	internal readonly MemoryBlock Block; // 0x30

	// Methods

	// RVA: 0x1BC3580 Offset: 0x1BC2780 VA: 0x181BC3580
	internal void .ctor(int numberOfRows, int stringHeapRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct AssemblyProcessorTableReader // TypeDefIndex: 16702
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly int _ProcessorOffset; // 0x4
	internal readonly int RowSize; // 0x8
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC3340 Offset: 0x1BC2540 VA: 0x181BC3340
	internal void .ctor(int numberOfRows, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct AssemblyOSTableReader // TypeDefIndex: 16703
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly int _OSPlatformIdOffset; // 0x4
	private readonly int _OSMajorVersionIdOffset; // 0x8
	private readonly int _OSMinorVersionIdOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC32D0 Offset: 0x1BC24D0 VA: 0x181BC32D0
	internal void .ctor(int numberOfRows, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct AssemblyRefTableReader // TypeDefIndex: 16704
{
	// Fields
	internal readonly int NumberOfNonVirtualRows; // 0x0
	internal readonly int NumberOfVirtualRows; // 0x4
	private readonly bool _IsStringHeapRefSizeSmall; // 0x8
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x9
	private readonly int _MajorVersionOffset; // 0xC
	private readonly int _MinorVersionOffset; // 0x10
	private readonly int _BuildNumberOffset; // 0x14
	private readonly int _RevisionNumberOffset; // 0x18
	private readonly int _FlagsOffset; // 0x1C
	private readonly int _PublicKeyOrTokenOffset; // 0x20
	private readonly int _NameOffset; // 0x24
	private readonly int _CultureOffset; // 0x28
	private readonly int _HashValueOffset; // 0x2C
	internal readonly int RowSize; // 0x30
	internal readonly MemoryBlock Block; // 0x38

	// Methods

	// RVA: 0x1BC34B0 Offset: 0x1BC26B0 VA: 0x181BC34B0
	internal void .ctor(int numberOfRows, int stringHeapRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset, MetadataKind metadataKind) { }

	// RVA: 0x1BC3490 Offset: 0x1BC2690 VA: 0x181BC3490
	internal StringHandle GetName(int rowId) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct AssemblyRefProcessorTableReader // TypeDefIndex: 16705
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsAssemblyRefTableRowSizeSmall; // 0x4
	private readonly int _ProcessorOffset; // 0x8
	private readonly int _AssemblyRefOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC3420 Offset: 0x1BC2620 VA: 0x181BC3420
	internal void .ctor(int numberOfRows, int assemblyRefTableRowRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct AssemblyRefOSTableReader // TypeDefIndex: 16706
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsAssemblyRefTableRowRefSizeSmall; // 0x4
	private readonly int _OSPlatformIdOffset; // 0x8
	private readonly int _OSMajorVersionIdOffset; // 0xC
	private readonly int _OSMinorVersionIdOffset; // 0x10
	private readonly int _AssemblyRefOffset; // 0x14
	internal readonly int RowSize; // 0x18
	internal readonly MemoryBlock Block; // 0x20

	// Methods

	// RVA: 0x1BC33A0 Offset: 0x1BC25A0 VA: 0x181BC33A0
	internal void .ctor(int numberOfRows, int assemblyRefTableRowRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct FileTableReader // TypeDefIndex: 16707
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsStringHeapRefSizeSmall; // 0x4
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x5
	private readonly int _FlagsOffset; // 0x8
	private readonly int _NameOffset; // 0xC
	private readonly int _HashValueOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC80E0 Offset: 0x1BC72E0 VA: 0x181BC80E0
	internal void .ctor(int numberOfRows, int stringHeapRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct ExportedTypeTableReader // TypeDefIndex: 16708
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsImplementationRefSizeSmall; // 0x4
	private readonly bool _IsStringHeapRefSizeSmall; // 0x5
	private readonly int _FlagsOffset; // 0x8
	private readonly int _TypeDefIdOffset; // 0xC
	private readonly int _TypeNameOffset; // 0x10
	private readonly int _TypeNamespaceOffset; // 0x14
	private readonly int _ImplementationOffset; // 0x18
	internal readonly int RowSize; // 0x1C
	internal readonly MemoryBlock Block; // 0x20

	// Methods

	// RVA: 0x1BC77D0 Offset: 0x1BC69D0 VA: 0x181BC77D0
	internal void .ctor(int numberOfRows, int implementationRefSize, int stringHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct ManifestResourceTableReader // TypeDefIndex: 16709
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsImplementationRefSizeSmall; // 0x4
	private readonly bool _IsStringHeapRefSizeSmall; // 0x5
	private readonly int _OffsetOffset; // 0x8
	private readonly int _FlagsOffset; // 0xC
	private readonly int _NameOffset; // 0x10
	private readonly int _ImplementationOffset; // 0x14
	internal readonly int RowSize; // 0x18
	internal readonly MemoryBlock Block; // 0x20

	// Methods

	// RVA: 0x1BC8A50 Offset: 0x1BC7C50 VA: 0x181BC8A50
	internal void .ctor(int numberOfRows, int implementationRefSize, int stringHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct NestedClassTableReader // TypeDefIndex: 16710
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsTypeDefTableRowRefSizeSmall; // 0x4
	private readonly int _NestedClassOffset; // 0x8
	private readonly int _EnclosingClassOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BD0930 Offset: 0x1BCFB30 VA: 0x181BD0930
	internal void .ctor(int numberOfRows, bool declaredSorted, int typeDefTableRowRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC7AC0 Offset: 0x1BC6CC0 VA: 0x181BC7AC0
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct GenericParamTableReader // TypeDefIndex: 16711
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsTypeOrMethodDefRefSizeSmall; // 0x4
	private readonly bool _IsStringHeapRefSizeSmall; // 0x5
	private readonly int _NumberOffset; // 0x8
	private readonly int _FlagsOffset; // 0xC
	private readonly int _OwnerOffset; // 0x10
	private readonly int _NameOffset; // 0x14
	internal readonly int RowSize; // 0x18
	internal readonly MemoryBlock Block; // 0x20

	// Methods

	// RVA: 0x1BC8280 Offset: 0x1BC7480 VA: 0x181BC8280
	internal void .ctor(int numberOfRows, bool declaredSorted, int typeOrMethodDefRefSize, int stringHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC8250 Offset: 0x1BC7450 VA: 0x181BC8250
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct MethodSpecTableReader // TypeDefIndex: 16712
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsMethodDefOrRefRefSizeSmall; // 0x4
	private readonly bool _IsBlobHeapRefSizeSmall; // 0x5
	private readonly int _MethodOffset; // 0x8
	private readonly int _InstantiationOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC7660 Offset: 0x1BC6860 VA: 0x181BC7660
	internal void .ctor(int numberOfRows, int methodDefOrRefRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct GenericParamConstraintTableReader // TypeDefIndex: 16713
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _IsGenericParamTableRowRefSizeSmall; // 0x4
	private readonly bool _IsTypeDefOrRefRefSizeSmall; // 0x5
	private readonly int _OwnerOffset; // 0x8
	private readonly int _ConstraintOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC8170 Offset: 0x1BC7370 VA: 0x181BC8170
	internal void .ctor(int numberOfRows, bool declaredSorted, int genericParamTableRowRefSize, int typeDefOrRefRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC7AC0 Offset: 0x1BC6CC0 VA: 0x181BC7AC0
	private bool CheckSorted() { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct DocumentTableReader // TypeDefIndex: 16714
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _isGuidHeapRefSizeSmall; // 0x4
	private readonly bool _isBlobHeapRefSizeSmall; // 0x5
	private readonly int _hashAlgorithmOffset; // 0x8
	private readonly int _hashOffset; // 0xC
	private readonly int _languageOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC5DF0 Offset: 0x1BC4FF0 VA: 0x181BC5DF0
	internal void .ctor(int numberOfRows, int guidHeapRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BC5DD0 Offset: 0x1BC4FD0 VA: 0x181BC5DD0
	internal DocumentNameBlobHandle GetName(DocumentHandle handle) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct MethodDebugInformationTableReader // TypeDefIndex: 16715
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _isDocumentRefSmall; // 0x4
	private readonly bool _isBlobHeapRefSizeSmall; // 0x5
	private readonly int _sequencePointsOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC8650 Offset: 0x1BC7850 VA: 0x181BC8650
	internal void .ctor(int numberOfRows, int documentRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }

	// RVA: 0x1BD01A0 Offset: 0x1BCF3A0 VA: 0x181BD01A0
	internal DocumentHandle GetDocument(MethodDebugInformationHandle handle) { }

	// RVA: 0x1BD01C0 Offset: 0x1BCF3C0 VA: 0x181BD01C0
	internal BlobHandle GetSequencePoints(MethodDebugInformationHandle handle) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct LocalScopeTableReader // TypeDefIndex: 16716
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _isMethodRefSmall; // 0x4
	private readonly bool _isImportScopeRefSmall; // 0x5
	private readonly bool _isLocalConstantRefSmall; // 0x6
	private readonly bool _isLocalVariableRefSmall; // 0x7
	private readonly int _importScopeOffset; // 0x8
	private readonly int _variableListOffset; // 0xC
	private readonly int _constantListOffset; // 0x10
	private readonly int _startOffsetOffset; // 0x14
	private readonly int _lengthOffset; // 0x18
	internal readonly int RowSize; // 0x1C
	internal readonly MemoryBlock Block; // 0x20

	// Methods

	// RVA: 0x1BC88E0 Offset: 0x1BC7AE0 VA: 0x181BC88E0
	internal void .ctor(int numberOfRows, bool declaredSorted, int methodRefSize, int importScopeRefSize, int localVariableRefSize, int localConstantRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct LocalVariableTableReader // TypeDefIndex: 16717
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _isStringHeapRefSizeSmall; // 0x4
	private readonly int _attributesOffset; // 0x8
	private readonly int _indexOffset; // 0xC
	private readonly int _nameOffset; // 0x10
	internal readonly int RowSize; // 0x14
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC89D0 Offset: 0x1BC7BD0 VA: 0x181BC89D0
	internal void .ctor(int numberOfRows, int stringHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct LocalConstantTableReader // TypeDefIndex: 16718
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _isStringHeapRefSizeSmall; // 0x4
	private readonly bool _isBlobHeapRefSizeSmall; // 0x5
	private readonly int _signatureOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC8650 Offset: 0x1BC7850 VA: 0x181BC8650
	internal void .ctor(int numberOfRows, int stringHeapRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct StateMachineMethodTableReader // TypeDefIndex: 16719
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _isMethodRefSizeSmall; // 0x4
	private readonly int _kickoffMethodOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BD6AD0 Offset: 0x1BD5CD0 VA: 0x181BD6AD0
	internal void .ctor(int numberOfRows, bool declaredSorted, int methodRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct ImportScopeTableReader // TypeDefIndex: 16720
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _isImportScopeRefSizeSmall; // 0x4
	private readonly bool _isBlobHeapRefSizeSmall; // 0x5
	private readonly int _importsOffset; // 0x8
	internal readonly int RowSize; // 0xC
	internal readonly MemoryBlock Block; // 0x10

	// Methods

	// RVA: 0x1BC8650 Offset: 0x1BC7850 VA: 0x181BC8650
	internal void .ctor(int numberOfRows, int importScopeRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Metadata.Ecma335
[IsReadOnly]
internal struct CustomDebugInformationTableReader // TypeDefIndex: 16721
{
	// Fields
	internal readonly int NumberOfRows; // 0x0
	private readonly bool _isHasCustomDebugInformationRefSizeSmall; // 0x4
	private readonly bool _isGuidHeapRefSizeSmall; // 0x5
	private readonly bool _isBlobHeapRefSizeSmall; // 0x6
	private readonly int _kindOffset; // 0x8
	private readonly int _valueOffset; // 0xC
	internal readonly int RowSize; // 0x10
	internal readonly MemoryBlock Block; // 0x18

	// Methods

	// RVA: 0x1BC5750 Offset: 0x1BC4950 VA: 0x181BC5750
	internal void .ctor(int numberOfRows, bool declaredSorted, int hasCustomDebugInformationRefSize, int guidHeapRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset) { }
}

// Namespace: System.Reflection.Internal
internal abstract class CriticalDisposableObject : CriticalFinalizerObject, IDisposable // TypeDefIndex: 16722
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void Release();

	// RVA: 0x1BC5530 Offset: 0x1BC4730 VA: 0x181BC5530 Slot: 4
	public void Dispose() { }

	// RVA: 0x1BC5590 Offset: 0x1BC4790 VA: 0x181BC5590 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: System.Reflection.Internal
internal abstract class AbstractMemoryBlock : IDisposable // TypeDefIndex: 16723
{
	// Properties
	public abstract byte* Pointer { get; }
	public abstract int Size { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte* get_Pointer();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Size();

	// RVA: 0x1BC31B0 Offset: 0x1BC23B0 VA: 0x181BC31B0
	public BlobReader GetReader() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Dispose();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Reflection.Internal
internal sealed class ExternalMemoryBlock : AbstractMemoryBlock // TypeDefIndex: 16724
{
	// Fields
	private readonly object _memoryOwner; // 0x10
	private byte* _buffer; // 0x18
	private int _size; // 0x20

	// Properties
	public override byte* Pointer { get; }
	public override int Size { get; }

	// Methods

	// RVA: 0xB18200 Offset: 0xB17400 VA: 0x180B18200
	public void .ctor(object memoryOwner, byte* buffer, int size) { }

	// RVA: 0x1BC79C0 Offset: 0x1BC6BC0 VA: 0x181BC79C0 Slot: 7
	public override void Dispose() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public override byte* get_Pointer() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 6
	public override int get_Size() { }
}

// Namespace: System.Reflection.Internal
internal sealed class ExternalMemoryBlockProvider : MemoryBlockProvider // TypeDefIndex: 16725
{
	// Fields
	private byte* _memory; // 0x10
	private int _size; // 0x18

	// Properties
	public override int Size { get; }

	// Methods

	// RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	public void .ctor(byte* memory, int size) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 7
	public override int get_Size() { }

	[NullableContext(1)]
	// RVA: 0x1BC7870 Offset: 0x1BC6A70 VA: 0x181BC7870 Slot: 5
	protected override AbstractMemoryBlock GetMemoryBlockImpl(int start, int size) { }

	[NullableContext(1)]
	// RVA: 0x1BC7900 Offset: 0x1BC6B00 VA: 0x181BC7900 Slot: 6
	public override Stream GetStream(out StreamConstraints constraints) { }

	// RVA: 0x18B36B0 Offset: 0x18B28B0 VA: 0x1818B36B0 Slot: 8
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Reflection.Internal
[NullableContext(1)]
[Nullable(0)]
internal abstract class MemoryBlockProvider : IDisposable // TypeDefIndex: 16726
{
	// Properties
	public abstract int Size { get; }

	// Methods

	// RVA: 0x1BC8C00 Offset: 0x1BC7E00 VA: 0x181BC8C00
	public AbstractMemoryBlock GetMemoryBlock(int start, int size) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract AbstractMemoryBlock GetMemoryBlockImpl(int start, int size);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Stream GetStream(out StreamConstraints constraints);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Size();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void Dispose(bool disposing);

	// RVA: 0x1BC8B90 Offset: 0x1BC7D90 VA: 0x181BC8B90 Slot: 4
	public void Dispose() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
private sealed class MemoryMappedFileBlock.DisposableData : CriticalDisposableObject // TypeDefIndex: 16727
{
	// Fields
	private IDisposable _accessor; // 0x10
	private SafeBuffer _safeBuffer; // 0x18
	private byte* _pointer; // 0x20

	// Properties
	public byte* Pointer { get; }

	// Methods

	// RVA: 0x1BC5B40 Offset: 0x1BC4D40 VA: 0x181BC5B40
	public void .ctor(IDisposable accessor, SafeBuffer safeBuffer, long offset) { }

	// RVA: 0x1BC59D0 Offset: 0x1BC4BD0 VA: 0x181BC59D0 Slot: 5
	protected override void Release() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public byte* get_Pointer() { }
}

// Namespace: System.Reflection.Internal
internal sealed class MemoryMappedFileBlock : AbstractMemoryBlock // TypeDefIndex: 16728
{
	// Fields
	private readonly MemoryMappedFileBlock.DisposableData _data; // 0x10
	private readonly int _size; // 0x18

	// Properties
	public override byte* Pointer { get; }
	public override int Size { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1BC9CA0 Offset: 0x1BC8EA0 VA: 0x181BC9CA0
	internal void .ctor(IDisposable accessor, SafeBuffer safeBuffer, long offset, int size) { }

	// RVA: 0x1BC9C30 Offset: 0x1BC8E30 VA: 0x181BC9C30 Slot: 7
	public override void Dispose() { }

	// RVA: 0x1BC9D40 Offset: 0x1BC8F40 VA: 0x181BC9D40 Slot: 5
	public override byte* get_Pointer() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 6
	public override int get_Size() { }
}

// Namespace: 
private sealed class NativeHeapMemoryBlock.DisposableData : CriticalDisposableObject // TypeDefIndex: 16729
{
	// Fields
	private IntPtr _pointer; // 0x10

	// Properties
	public byte* Pointer { get; }

	// Methods

	// RVA: 0x1BC5C10 Offset: 0x1BC4E10 VA: 0x181BC5C10
	public void .ctor(int size) { }

	// RVA: 0x1BC5AC0 Offset: 0x1BC4CC0 VA: 0x181BC5AC0 Slot: 5
	protected override void Release() { }

	// RVA: 0x1B48F30 Offset: 0x1B48130 VA: 0x181B48F30
	public byte* get_Pointer() { }
}

// Namespace: System.Reflection.Internal
internal sealed class NativeHeapMemoryBlock : AbstractMemoryBlock // TypeDefIndex: 16730
{
	// Fields
	private readonly NativeHeapMemoryBlock.DisposableData _data; // 0x10
	private readonly int _size; // 0x18

	// Properties
	public override byte* Pointer { get; }
	public override int Size { get; }

	// Methods

	// RVA: 0x1BD0890 Offset: 0x1BCFA90 VA: 0x181BD0890
	internal void .ctor(int size) { }

	// RVA: 0x1BC9C30 Offset: 0x1BC8E30 VA: 0x181BC9C30 Slot: 7
	public override void Dispose() { }

	// RVA: 0x1BD0900 Offset: 0x1BCFB00 VA: 0x181BD0900 Slot: 5
	public override byte* get_Pointer() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 6
	public override int get_Size() { }
}

// Namespace: System.Reflection.Internal
[NullableContext(2)]
[Nullable(0)]
[IsReadOnly]
internal struct StreamConstraints // TypeDefIndex: 16731
{
	// Fields
	public readonly object GuardOpt; // 0x0
	public readonly long ImageStart; // 0x8
	public readonly int ImageSize; // 0x10

	// Methods

	// RVA: 0x838430 Offset: 0x837630 VA: 0x180838430
	public void .ctor(object guardOpt, long startPosition, int imageSize) { }
}

// Namespace: System.Reflection.Internal
[NullableContext(1)]
[Nullable(0)]
internal sealed class StreamMemoryBlockProvider : MemoryBlockProvider // TypeDefIndex: 16732
{
	// Fields
	private Stream _stream; // 0x10
	private readonly object _streamGuard; // 0x18
	private readonly bool _leaveOpen; // 0x20
	private bool _useMemoryMap; // 0x21
	private readonly bool _isFileStream; // 0x22
	private readonly long _imageStart; // 0x28
	private readonly int _imageSize; // 0x30
	private IDisposable _lazyMemoryMap; // 0x38

	// Properties
	public override int Size { get; }

	// Methods

	// RVA: 0x1BD76E0 Offset: 0x1BD68E0 VA: 0x181BD76E0
	public void .ctor(Stream stream, long imageStart, int imageSize, bool isFileStream, bool leaveOpen) { }

	// RVA: 0x1BD6E60 Offset: 0x1BD6060 VA: 0x181BD6E60 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 7
	public override int get_Size() { }

	// RVA: 0x1BD7060 Offset: 0x1BD6260 VA: 0x181BD7060
	internal static NativeHeapMemoryBlock ReadMemoryBlockNoLock(Stream stream, bool isFileStream, long start, int size) { }

	// RVA: 0x1BD6EE0 Offset: 0x1BD60E0 VA: 0x181BD6EE0 Slot: 5
	protected override AbstractMemoryBlock GetMemoryBlockImpl(int start, int size) { }

	// RVA: 0x1BD7020 Offset: 0x1BD6220 VA: 0x181BD7020 Slot: 6
	public override Stream GetStream(out StreamConstraints constraints) { }

	// RVA: 0x1BD7400 Offset: 0x1BD6600 VA: 0x181BD7400
	private bool TryCreateMemoryMappedFileBlock(long start, int size, out MemoryMappedFileBlock block) { }
}

// Namespace: System.Reflection.Internal
internal static class EmptyArray<T> // TypeDefIndex: 16733
{
	// Fields
	[Nullable(1)]
	internal static readonly T[] Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DCBE0 Offset: 0x10DBDE0 VA: 0x1810DCBE0
	|-EmptyArray<byte>..cctor
	|-EmptyArray<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
internal sealed class EncodingHelper.Encoding_GetString : MulticastDelegate // TypeDefIndex: 16734
{
	// Methods

	// RVA: 0x1BC6DB0 Offset: 0x1BC5FB0 VA: 0x181BC6DB0
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual string Invoke(Encoding encoding, byte* bytes, int byteCount) { }
}

// Namespace: 
private sealed class EncodingHelper.String_CreateStringFromEncoding : MulticastDelegate // TypeDefIndex: 16735
{
	// Methods

	// RVA: 0x1BD83E0 Offset: 0x1BD75E0 VA: 0x181BD83E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual string Invoke(byte* bytes, int byteCount, Encoding encoding) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EncodingHelper.<>c__DisplayClass11_0 // TypeDefIndex: 16736
{
	// Fields
	public EncodingHelper.String_CreateStringFromEncoding createStringFromEncoding; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1BD8C90 Offset: 0x1BD7E90 VA: 0x181BD8C90
	internal string <LoadGetStringPlatform>b__0(Encoding encoding, byte* bytes, int byteCount) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EncodingHelper.<>c // TypeDefIndex: 16737
{
	// Fields
	public static readonly EncodingHelper.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1BD8EB0 Offset: 0x1BD80B0 VA: 0x181BD8EB0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1BD8C50 Offset: 0x1BD7E50 VA: 0x181BD8C50
	internal byte[] <.cctor>b__16_0() { }
}

// Namespace: System.Reflection.Internal
[Extension]
internal static class EncodingHelper // TypeDefIndex: 16738
{
	// Fields
	private static readonly ObjectPool<byte[]> s_pool; // 0x0
	private static EncodingHelper.Encoding_GetString s_getStringPlatform; // 0x8

	// Methods

	[NullableContext(1)]
	// RVA: 0x1BC6210 Offset: 0x1BC5410 VA: 0x181BC6210
	public static string DecodeUtf8(byte* bytes, int byteCount, byte[] prefix, MetadataStringDecoder utf8Decoder) { }

	// RVA: 0x1BC5FD0 Offset: 0x1BC51D0 VA: 0x181BC5FD0
	private static string DecodeUtf8Prefixed(byte* bytes, int byteCount, byte[] prefix, MetadataStringDecoder utf8Decoder) { }

	// RVA: 0x1BC5F30 Offset: 0x1BC5130 VA: 0x181BC5F30
	private static byte[] AcquireBuffer(int byteCount) { }

	// RVA: 0x1BC6C10 Offset: 0x1BC5E10 VA: 0x181BC6C10
	private static void ReleaseBuffer(byte[] buffer) { }

	// RVA: 0x1BC63B0 Offset: 0x1BC55B0 VA: 0x181BC63B0
	private static EncodingHelper.Encoding_GetString LoadGetStringPlatform() { }

	// RVA: 0x1BC62E0 Offset: 0x1BC54E0 VA: 0x181BC62E0
	private static string GetStringUsingCreateStringFromEncoding(EncodingHelper.String_CreateStringFromEncoding createStringFromEncoding, byte* bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x1BC6CA0 Offset: 0x1BC5EA0 VA: 0x181BC6CA0
	private static void .cctor() { }
}

// Namespace: System.Reflection.Internal
internal static class FileStreamReadLightUp // TypeDefIndex: 16739
{
	// Fields
	internal static bool readFileNotAvailable; // 0x0

	// Methods

	[NullableContext(1)]
	// RVA: 0x1BC7E50 Offset: 0x1BC7050 VA: 0x181BC7E50
	internal static bool IsFileStream(Stream stream) { }

	[NullableContext(1)]
	// RVA: 0x1BC7D20 Offset: 0x1BC6F20 VA: 0x181BC7D20
	internal static SafeHandle GetSafeFileHandle(Stream stream) { }

	// RVA: 0x1BC7ED0 Offset: 0x1BC70D0 VA: 0x181BC7ED0
	internal static bool TryReadFile(Stream stream, byte* buffer, long start, int size) { }

	// RVA: 0x1BC8070 Offset: 0x1BC7270 VA: 0x181BC8070
	private static void .cctor() { }
}

// Namespace: System.Reflection.Internal
internal static class Hash // TypeDefIndex: 16740
{
	// Methods

	// RVA: 0x1BC84E0 Offset: 0x1BC76E0 VA: 0x181BC84E0
	internal static int Combine(int newKey, int currentKey) { }
}

// Namespace: 
private struct ImmutableByteArrayInterop.ByteArrayUnion // TypeDefIndex: 16741
{
	// Fields
	internal byte[] UnderlyingArray; // 0x0
	internal ImmutableArray<byte> ImmutableArray; // 0x0
}

// Namespace: System.Reflection.Internal
internal static class ImmutableByteArrayInterop // TypeDefIndex: 16742
{
	// Methods

	// RVA: 0x1BC8500 Offset: 0x1BC7700 VA: 0x181BC8500
	internal static ImmutableArray<byte> DangerousCreateFromUnderlyingArray(ref byte[] array) { }
}

// Namespace: System.Reflection.Internal
[NullableContext(1)]
[Nullable(0)]
internal static class LightUpHelper // TypeDefIndex: 16743
{
	// Methods

	// RVA: 0x1BC88C0 Offset: 0x1BC7AC0 VA: 0x181BC88C0
	internal static MethodInfo GetMethod(Type type, string name, Type[] parameterTypes) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MemoryBlock.<>c__DisplayClass42_0 // TypeDefIndex: 16744
{
	// Fields
	public uint[] unsortedReferences; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1BD8DC0 Offset: 0x1BD7FC0 VA: 0x181BD8DC0
	internal int <BuildPtrTable>b__0(int a, int b) { }
}

// Namespace: System.Reflection.Internal
[IsReadOnly]
[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
[Nullable(0)]
[NullableContext(1)]
internal struct MemoryBlock // TypeDefIndex: 16745
{
	// Fields
	[Nullable(0)]
	internal readonly byte* Pointer; // 0x0
	internal readonly int Length; // 0x8

	// Methods

	[NullableContext(0)]
	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	internal void .ctor(byte* buffer, int length) { }

	[NullableContext(0)]
	// RVA: 0x1BC8F80 Offset: 0x1BC8180 VA: 0x181BC8F80
	internal static MemoryBlock CreateChecked(byte* buffer, int length) { }

	// RVA: 0x1BC8E70 Offset: 0x1BC8070 VA: 0x181BC8E70
	private void CheckBounds(int offset, int byteCount) { }

	// RVA: 0x1BC9040 Offset: 0x1BC8240 VA: 0x181BC9040
	internal MemoryBlock GetMemoryBlockAt(int offset, int length) { }

	// RVA: 0x1BC91B0 Offset: 0x1BC83B0 VA: 0x181BC91B0
	internal byte PeekByte(int offset) { }

	// RVA: 0x1BC9650 Offset: 0x1BC8850 VA: 0x181BC9650
	internal uint PeekUInt32(int offset) { }

	// RVA: 0x1BC92F0 Offset: 0x1BC84F0 VA: 0x181BC92F0
	internal int PeekCompressedInteger(int offset, out int numberOfBytesRead) { }

	// RVA: 0x1BC9610 Offset: 0x1BC8810 VA: 0x181BC9610
	internal ushort PeekUInt16(int offset) { }

	// RVA: 0x1BC9510 Offset: 0x1BC8710 VA: 0x181BC9510
	internal uint PeekReferenceUnchecked(int offset, bool smallRefSize) { }

	// RVA: 0x1BC9580 Offset: 0x1BC8780 VA: 0x181BC9580
	internal int PeekReference(int offset, bool smallRefSize) { }

	// RVA: 0x1BC93A0 Offset: 0x1BC85A0 VA: 0x181BC93A0
	internal int PeekHeapReference(int offset, bool smallRefSize) { }

	// RVA: 0x1BC9820 Offset: 0x1BC8A20 VA: 0x181BC9820
	internal string PeekUtf8(int offset, int byteCount) { }

	// RVA: 0x1BC96A0 Offset: 0x1BC88A0 VA: 0x181BC96A0
	internal string PeekUtf8NullTerminated(int offset, byte[] prefix, MetadataStringDecoder utf8Decoder, out int numberOfBytesRead, char terminator = '\x0') { }

	// RVA: 0x1BC9080 Offset: 0x1BC8280 VA: 0x181BC9080
	internal int GetUtf8NullTerminatedLength(int offset, out int numberOfBytesRead, char terminator = '\x0') { }

	// RVA: 0x1BC8EA0 Offset: 0x1BC80A0 VA: 0x181BC8EA0
	internal int CompareUtf8NullTerminatedStringWithAsciiString(int offset, string asciiString) { }

	// RVA: 0x1BC91E0 Offset: 0x1BC83E0 VA: 0x181BC91E0
	internal byte[] PeekBytes(int offset, int byteCount) { }

	// RVA: 0x1BC90E0 Offset: 0x1BC82E0 VA: 0x181BC90E0
	internal bool IsOrderedByReferenceAscending(int rowSize, int referenceOffset, bool isReferenceSmall) { }

	// RVA: 0x1BC8C70 Offset: 0x1BC7E70 VA: 0x181BC8C70
	internal int[] BuildPtrTable(int numberOfRows, int rowSize, int referenceOffset, bool isReferenceSmall) { }

	// RVA: 0x1BC9890 Offset: 0x1BC8A90 VA: 0x181BC9890
	private void ReadColumn(uint[] result, int rowSize, int referenceOffset, bool isReferenceSmall) { }

	// RVA: 0x1BC9430 Offset: 0x1BC8630 VA: 0x181BC9430
	internal bool PeekHeapValueOffsetAndSize(int index, out int offset, out int size) { }
}

// Namespace: System.Reflection.Internal
[NullableContext(1)]
[Nullable(0)]
internal static class MemoryMapLightUp // TypeDefIndex: 16746
{
	// Properties
	internal static bool IsAvailable { get; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	internal static bool get_IsAvailable() { }

	// RVA: 0x1BC9970 Offset: 0x1BC8B70 VA: 0x181BC9970
	internal static IDisposable CreateMemoryMap(Stream stream) { }

	// RVA: 0x1BC9A20 Offset: 0x1BC8C20 VA: 0x181BC9A20
	internal static IDisposable CreateViewAccessor(object memoryMap, long start, int size) { }

	// RVA: 0x1BC9B90 Offset: 0x1BC8D90 VA: 0x181BC9B90
	internal static bool TryGetSafeBufferAndPointerOffset(object accessor, out SafeBuffer safeBuffer, out long offset) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PooledStringBuilder.<>c__DisplayClass8_0 // TypeDefIndex: 16747
{
	// Fields
	public ObjectPool<PooledStringBuilder> pool; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1BD8E10 Offset: 0x1BD8010 VA: 0x181BD8E10
	internal PooledStringBuilder <CreatePool>b__0() { }
}

// Namespace: System.Reflection.Internal
[NullableContext(1)]
[Nullable(0)]
internal class PooledStringBuilder // TypeDefIndex: 16748
{
	// Fields
	public readonly StringBuilder Builder; // 0x10
	private readonly ObjectPool<PooledStringBuilder> _pool; // 0x18
	private static readonly ObjectPool<PooledStringBuilder> s_poolInstance; // 0x0

	// Methods

	// RVA: 0x1BD4A00 Offset: 0x1BD3C00 VA: 0x181BD4A00
	private void .ctor(ObjectPool<PooledStringBuilder> pool) { }

	// RVA: 0x1BD4740 Offset: 0x1BD3940 VA: 0x181BD4740
	public void Free() { }

	// RVA: 0x1BD4830 Offset: 0x1BD3A30 VA: 0x181BD4830
	public string ToStringAndFree() { }

	// RVA: 0x1BD4650 Offset: 0x1BD3850 VA: 0x181BD4650
	public static ObjectPool<PooledStringBuilder> CreatePool() { }

	// RVA: 0x1BD47C0 Offset: 0x1BD39C0 VA: 0x181BD47C0
	public static PooledStringBuilder GetInstance() { }

	// RVA: 0x1BD48E0 Offset: 0x1BD3AE0 VA: 0x181BD48E0
	private static void .cctor() { }
}

// Namespace: 
private struct ObjectPool.Element<T> // TypeDefIndex: 16749
{
	// Fields
	internal T Value; // 0x0
}

// Namespace: System.Reflection.Internal
[NullableContext(1)]
[Nullable(0)]
internal sealed class ObjectPool<T> // TypeDefIndex: 16750
{
	// Fields
	private readonly ObjectPool.Element<T>[] _items; // 0x0
	private readonly Func<T> _factory; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Func<T> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB784C0 Offset: 0xB776C0 VA: 0x180B784C0
	|-ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<T> factory, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB78900 Offset: 0xB77B00 VA: 0x180B78900
	|-ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private T CreateInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB767D0 Offset: 0xB759D0 VA: 0x180B767D0
	|-ObjectPool<object>.CreateInstance
	*/

	// RVA: -1 Offset: -1
	internal T Allocate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB764C0 Offset: 0xB756C0 VA: 0x180B764C0
	|-ObjectPool<object>.Allocate
	*/

	// RVA: -1 Offset: -1
	internal void Free(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB768F0 Offset: 0xB75AF0 VA: 0x180B768F0
	|-ObjectPool<object>.Free
	*/
}

// Namespace: System.Reflection.Internal
internal sealed class ReadOnlyUnmanagedMemoryStream : Stream // TypeDefIndex: 16751
{
	// Fields
	private readonly byte* _data; // 0x28
	private readonly int _length; // 0x30
	private int _position; // 0x34

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1BD4E00 Offset: 0x1BD4000 VA: 0x181BD4E00
	public void .ctor(byte* data, int length) { }

	// RVA: 0x1BD4A70 Offset: 0x1BD3C70 VA: 0x181BD4A70 Slot: 36
	public override int ReadByte() { }

	[NullableContext(1)]
	// RVA: 0x1BD4AA0 Offset: 0x1BD3CA0 VA: 0x181BD4AA0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public override void Flush() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1BD4E70 Offset: 0x1BD4070 VA: 0x181BD4E70 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1BD4E80 Offset: 0x1BD4080 VA: 0x181BD4E80 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1BD4E90 Offset: 0x1BD4090 VA: 0x181BD4E90 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1BD4B80 Offset: 0x1BD3D80 VA: 0x181BD4B80 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1BD4D80 Offset: 0x1BD3F80 VA: 0x181BD4D80 Slot: 33
	public override void SetLength(long value) { }

	[NullableContext(1)]
	// RVA: 0x1BD4DC0 Offset: 0x1BD3FC0 VA: 0x181BD4DC0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }
}

// Namespace: System.Reflection.Internal
[Extension]
internal static class StreamExtensions // TypeDefIndex: 16752
{
	// Methods

	[Extension]
	// RVA: 0x1BD6B50 Offset: 0x1BD5D50 VA: 0x181BD6B50
	internal static void CopyTo(Stream source, byte* destination, int size) { }

	[NullableContext(1)]
	// RVA: 0x1BD6D20 Offset: 0x1BD5F20 VA: 0x181BD6D20
	internal static int GetAndValidateSize(Stream stream, int size, string streamParameterName) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7 // TypeDefIndex: 16753
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 // TypeDefIndex: 16754
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=25 // TypeDefIndex: 16755
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=160 // TypeDefIndex: 16756
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16757
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=25 3CA755F008717485A633F20718A228E4E6655894BE2333F144A31EE7AFB5E650 /*Metadata offset 0x8FC730*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 8D0C69BB9AAC20D895AEDA5E8658028CA4D3D7CDB2547AF34647088E5A86B0C0 /*Metadata offset 0x8FC750*/; // 0x19
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=160 933598639CBAA1DE502F80D2FD1DB78F13C8D7BB64A5FDC1BC73AC0B5CE4F5CA /*Metadata offset 0x8FC768*/; // 0x29
	internal static readonly long 971150DD73DC318E68A98CCE9B91AC7DEA2D43C562B4F5A9A2F4272C7E29477E = 4182389475095035824; // 0xD0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7 D5FA77FA22BBACFB9D9A358464A6FD2976205C8050BABCEB8DF0702EA76A60A0 /*Metadata offset 0x8FC820*/; // 0xD8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=25 F7FD6D20D96622C69E4780255FE389F944DC0DF4932BEB9E6C8BB5F0F0A9D15B /*Metadata offset 0x8FC828*/; // 0xDF

	// Methods

	// RVA: 0x840E00 Offset: 0x840000 VA: 0x180840E00
	internal static uint ComputeStringHash(string s) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16758
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 16759
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 16760
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 16761
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1C41DC0 Offset: 0x1C40FC0 VA: 0x181C41DC0
	public void .ctor(byte ) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 16762
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(byte ) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(2432, Inherited = False)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
internal sealed class AllowNullAttribute : Attribute // TypeDefIndex: 16763
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
[Usage(2432, Inherited = False)]
internal sealed class DisallowNullAttribute : Attribute // TypeDefIndex: 16764
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[Usage(64, Inherited = False)]
internal sealed class DoesNotReturnAttribute : Attribute // TypeDefIndex: 16765
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(2048, Inherited = False)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
internal sealed class DoesNotReturnIfAttribute : Attribute // TypeDefIndex: 16766
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ParameterValue>k__BackingField; // 0x10

	// Properties
	public bool ParameterValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_ParameterValue() { }

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool parameterValue) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(10624, Inherited = False)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
internal sealed class MaybeNullAttribute : Attribute // TypeDefIndex: 16767
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(2048, Inherited = False)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
internal sealed class MaybeNullWhenAttribute : Attribute // TypeDefIndex: 16768
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Properties
	public bool ReturnValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_ReturnValue() { }

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool returnValue) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[DebuggerNonUserCode]
[NullableContext(1)]
[Nullable(0)]
[Usage(192, Inherited = False, AllowMultiple = True)]
[ExcludeFromCodeCoverage]
internal sealed class MemberNotNullAttribute : Attribute // TypeDefIndex: 16769
{
	// Fields
	[CompilerGenerated]
	private readonly string[] <Members>k__BackingField; // 0x10

	// Properties
	public string[] Members { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string[] get_Members() { }

	// RVA: 0x1C41BC0 Offset: 0x1C40DC0 VA: 0x181C41BC0
	public void .ctor(string member) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string[] members) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[NullableContext(1)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[Nullable(0)]
[Usage(192, Inherited = False, AllowMultiple = True)]
internal sealed class MemberNotNullWhenAttribute : Attribute // TypeDefIndex: 16770
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string[] <Members>k__BackingField; // 0x18

	// Properties
	public bool ReturnValue { get; }
	public string[] Members { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_ReturnValue() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string[] get_Members() { }

	// RVA: 0x1C41C80 Offset: 0x1C40E80 VA: 0x181C41C80
	public void .ctor(bool returnValue, string member) { }

	// RVA: 0x1C41C40 Offset: 0x1C40E40 VA: 0x181C41C40
	public void .ctor(bool returnValue, string[] members) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
[Usage(10624, Inherited = False)]
internal sealed class NotNullAttribute : Attribute // TypeDefIndex: 16771
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[ExcludeFromCodeCoverage]
[Usage(10368, AllowMultiple = True, Inherited = False)]
[Nullable(0)]
[NullableContext(1)]
[DebuggerNonUserCode]
internal sealed class NotNullIfNotNullAttribute : Attribute // TypeDefIndex: 16772
{
	// Fields
	[CompilerGenerated]
	private readonly string <ParameterName>k__BackingField; // 0x10

	// Properties
	public string ParameterName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ParameterName() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string parameterName) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(2048, Inherited = False)]
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
internal sealed class NotNullWhenAttribute : Attribute // TypeDefIndex: 16773
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Properties
	public bool ReturnValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_ReturnValue() { }

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool returnValue) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ContextWriter.<>c // TypeDefIndex: 16774
{
	// Fields
	public static readonly ContextWriter.<>c <>9; // 0x0
	[Nullable(new[] { 0, 1, 1 })]
	public static Func<string, object> <>9__0_0; // 0x8

	// Methods

	// RVA: 0x1C4C4D0 Offset: 0x1C4B6D0 VA: 0x181C4C4D0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x1C4B0C0 Offset: 0x1C4A2C0 VA: 0x181C4B0C0
	internal object <Write>b__0_0(string _) { }
}

// Namespace: Sentry.Unity
internal abstract class ContextWriter // TypeDefIndex: 16775
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1C40DD0 Offset: 0x1C3FFD0 VA: 0x181C40DD0
	public void Write(Scope scope) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void WriteScope(string AppStartTime, string AppBuildType, string OperatingSystemRawDescription, Nullable<int> DeviceProcessorCount, string DeviceCpuDescription, string DeviceTimezone, Nullable<bool> DeviceSupportsVibration, string DeviceName, Nullable<bool> DeviceSimulator, string DeviceDeviceUniqueIdentifier, string DeviceDeviceType, string DeviceModel, Nullable<long> DeviceMemorySize, Nullable<int> GpuId, string GpuName, string GpuVendorName, Nullable<int> GpuMemorySize, string GpuNpotSupport, string GpuVersion, string GpuApiType, Nullable<int> GpuMaxTextureSize, Nullable<bool> GpuSupportsDrawCallInstancing, Nullable<bool> GpuSupportsRayTracing, Nullable<bool> GpuSupportsComputeShaders, Nullable<bool> GpuSupportsGeometryShaders, string GpuVendorId, Nullable<bool> GpuMultiThreadedRendering, string GpuGraphicsShaderLevel, string UnityEditorVersion, string UnityInstallMode, string UnityTargetFrameRate, string UnityCopyTextureSupport, string UnityRenderingThreadingMode);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
internal interface IEventCapture // TypeDefIndex: 16776
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SentryId Capture(SentryEvent sentryEvent);
}

// Namespace: 
[Nullable(0)]
private class UnityIl2CppEventExceptionProcessor.DebugImageInfo // TypeDefIndex: 16777
{
	// Fields
	public readonly DebugImage Image; // 0x10
	public readonly ulong StartAddress; // 0x18
	public readonly ulong EndAddress; // 0x20

	// Methods

	// RVA: 0x1C416A0 Offset: 0x1C408A0 VA: 0x181C416A0
	public void .ctor(DebugImage image) { }

	// RVA: 0x1C41680 Offset: 0x1C40880 VA: 0x181C41680
	public bool ContainsAddress(ulong address) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UnityIl2CppEventExceptionProcessor.<>c // TypeDefIndex: 16778
{
	// Fields
	[Nullable(0)]
	public static readonly UnityIl2CppEventExceptionProcessor.<>c <>9; // 0x0
	[Nullable(0)]
	[TupleElementNames(new[] { "se", "ex" })]
	public static Func<SentryException, Exception, ValueTuple<SentryException, Exception>> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1C4C6B0 Offset: 0x1C4B8B0 VA: 0x181C4C6B0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1C4B050 Offset: 0x1C4A250 VA: 0x181C4B050
	internal ValueTuple<SentryException, Exception> <Process>b__3_0(SentryException se, Exception ex) { }

	// RVA: 0x1C4B110 Offset: 0x1C4A310 VA: 0x181C4B110
	internal List<UnityIl2CppEventExceptionProcessor.DebugImageInfo> <.cctor>b__11_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityIl2CppEventExceptionProcessor.<>c__DisplayClass3_0 // TypeDefIndex: 16779
{
	// Fields
	[Nullable(0)]
	public string mainImageUUID; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C4BC30 Offset: 0x1C4AE30 VA: 0x181C4BC30
	internal bool <Process>b__1(UnityIl2CppEventExceptionProcessor.DebugImageInfo info) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityIl2CppEventExceptionProcessor.<EnumerateChainedExceptions>d__9 : IEnumerable<Exception>, IEnumerable, IEnumerator<Exception>, IEnumerator, IDisposable // TypeDefIndex: 16780
{
	// Fields
	private int <>1__state; // 0x10
	private Exception <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(0)]
	private Exception exception; // 0x28
	[Nullable(0)]
	public Exception <>3__exception; // 0x30
	[Nullable(0)]
	public UnityIl2CppEventExceptionProcessor <>4__this; // 0x38
	[Nullable(0)]
	private IEnumerator<Exception> <>7__wrap1; // 0x40

	// Properties
	private Exception System.Collections.Generic.IEnumerator<System.Exception>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1C4AAB0 Offset: 0x1C49CB0 VA: 0x181C4AAB0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1C4A5E0 Offset: 0x1C497E0 VA: 0x181C4A5E0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1C4ABF0 Offset: 0x1C49DF0 VA: 0x181C4ABF0
	private void <>m__Finally1() { }

	// RVA: 0x1C4AC40 Offset: 0x1C49E40 VA: 0x181C4AC40
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private Exception System.Collections.Generic.IEnumerator<System.Exception>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1C4AA70 Offset: 0x1C49C70 VA: 0x181C4AA70 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1C4A9D0 Offset: 0x1C49BD0 VA: 0x181C4A9D0 Slot: 4
	private IEnumerator<Exception> System.Collections.Generic.IEnumerable<System.Exception>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1C4A9D0 Offset: 0x1C49BD0 VA: 0x181C4A9D0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(1)]
internal class UnityIl2CppEventExceptionProcessor : ISentryEventExceptionProcessor // TypeDefIndex: 16781
{
	// Fields
	private readonly SentryUnityOptions _options; // 0x10
	private readonly Il2CppMethods _il2CppMethods; // 0x18
	[Nullable(2)]
	private static IDiagnosticLogger Logger; // 0x0
	private static readonly Lazy<List<UnityIl2CppEventExceptionProcessor.DebugImageInfo>> DebugImagesSorted; // 0x8

	// Methods

	// RVA: 0x1C4E900 Offset: 0x1C4DB00 VA: 0x181C4E900
	public void .ctor(SentryUnityOptions options, Il2CppMethods il2CppMethods) { }

	// RVA: 0x1C4D850 Offset: 0x1C4CA50 VA: 0x181C4D850 Slot: 4
	public void Process(Exception incomingException, SentryEvent sentryEvent) { }

	[NullableContext(2)]
	// RVA: 0x1C4D7B0 Offset: 0x1C4C9B0 VA: 0x181C4D7B0
	internal static string NormalizeUuid(string value) { }

	[NullableContext(2)]
	// RVA: 0x1C4D3F0 Offset: 0x1C4C5F0 VA: 0x181C4D3F0
	private static DebugImage FindDebugImageContainingAddress(ulong instructionAddress) { }

	[IteratorStateMachine(typeof(UnityIl2CppEventExceptionProcessor.<EnumerateChainedExceptions>d__9))]
	// RVA: 0x1C4D370 Offset: 0x1C4C570 VA: 0x181C4D370
	private IEnumerable<Exception> EnumerateChainedExceptions(Exception exception) { }

	// RVA: 0x1C4D500 Offset: 0x1C4C700 VA: 0x181C4D500
	private NativeStackTrace GetNativeStackTrace(Exception e) { }

	// RVA: 0x1C4E810 Offset: 0x1C4DA10 VA: 0x181C4E810
	private static void .cctor() { }
}

// Namespace: Sentry.Unity
[NullableContext(2)]
[Nullable(0)]
internal class NativeStackTrace // TypeDefIndex: 16782
{
	// Fields
	[Nullable(1)]
	[CompilerGenerated]
	private IntPtr[] <Frames>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ImageUuid>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <ImageName>k__BackingField; // 0x20

	// Properties
	[Nullable(1)]
	public IntPtr[] Frames { get; set; }
	public string ImageUuid { get; set; }
	public string ImageName { get; set; }

	// Methods

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr[] get_Frames() { }

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Frames(IntPtr[] value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_ImageUuid() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ImageUuid(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_ImageName() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ImageName(string value) { }

	// RVA: 0x1C41D10 Offset: 0x1C40F10 VA: 0x181C41D10
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnrIntegration.<>c__DisplayClass4_0 // TypeDefIndex: 16783
{
	// Fields
	[Nullable(0)]
	public IHub hub; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1C4C3C0 Offset: 0x1C4B5C0 VA: 0x181C4C3C0
	internal void <Register>b__0(object _, ApplicationNotResponding e) { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(1)]
internal class AnrIntegration : ISdkIntegration // TypeDefIndex: 16784
{
	// Fields
	private static readonly object Lock; // 0x0
	[Nullable(2)]
	private static AnrWatchDog Watchdog; // 0x8
	private readonly SentryMonoBehaviour _monoBehaviour; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(SentryMonoBehaviour monoBehaviour) { }

	// RVA: 0x1C3CB40 Offset: 0x1C3BD40 VA: 0x181C3CB40 Slot: 4
	public void Register(IHub hub, SentryOptions sentryOptions) { }

	// RVA: 0x1C3D0F0 Offset: 0x1C3C2F0 VA: 0x181C3D0F0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AnrWatchDog.<>c // TypeDefIndex: 16785
{
	// Fields
	[Nullable(0)]
	public static readonly AnrWatchDog.<>c <>9; // 0x0
	[Nullable(new[] { 0, 1 })]
	public static EventHandler<ApplicationNotResponding> <>9__11_3; // 0x8

	// Methods

	// RVA: 0x1C4C530 Offset: 0x1C4B730 VA: 0x181C4C530
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void <.ctor>b__11_3(object <p0>, ApplicationNotResponding <p1>) { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
internal abstract class AnrWatchDog // TypeDefIndex: 16786
{
	// Fields
	protected readonly int DetectionTimeoutMs; // 0x10
	protected readonly int SleepIntervalMs; // 0x14
	[Nullable(2)]
	protected readonly IDiagnosticLogger Logger; // 0x18
	protected readonly SentryMonoBehaviour MonoBehaviour; // 0x20
	[CompilerGenerated]
	private EventHandler<ApplicationNotResponding> OnApplicationNotResponding; // 0x28
	[CompilerGenerated]
	private bool <Paused>k__BackingField; // 0x30

	// Properties
	protected bool Paused { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C3DC10 Offset: 0x1C3CE10 VA: 0x181C3DC10
	internal void add_OnApplicationNotResponding(EventHandler<ApplicationNotResponding> value) { }

	[CompilerGenerated]
	// RVA: 0x1C3DCC0 Offset: 0x1C3CEC0 VA: 0x181C3DCC0
	internal void remove_OnApplicationNotResponding(EventHandler<ApplicationNotResponding> value) { }

	[CompilerGenerated]
	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	protected bool get_Paused() { }

	[CompilerGenerated]
	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	private void set_Paused(bool value) { }

	// RVA: 0x1C3D930 Offset: 0x1C3CB30 VA: 0x181C3D930
	internal void .ctor(IDiagnosticLogger logger, SentryMonoBehaviour monoBehaviour, TimeSpan detectionTimeout) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Stop(bool wait = False);

	// RVA: 0x1C3D7D0 Offset: 0x1C3C9D0 VA: 0x181C3D7D0
	protected void Report() { }

	[CompilerGenerated]
	// RVA: 0x1483DC0 Offset: 0x1482FC0 VA: 0x181483DC0
	private void <.ctor>b__11_0() { }

	[CompilerGenerated]
	// RVA: 0x723A20 Offset: 0x722C20 VA: 0x180723A20
	private void <.ctor>b__11_1() { }

	[CompilerGenerated]
	// RVA: 0x1C3D910 Offset: 0x1C3CB10 VA: 0x181C3D910
	private void <.ctor>b__11_2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnrWatchDogMultiThreaded.<UpdateUiStatus>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 16787
{
	// Fields
	private int <>1__state; // 0x10
	[Nullable(0)]
	private object <>2__current; // 0x18
	[Nullable(0)]
	public AnrWatchDogMultiThreaded <>4__this; // 0x20
	[Nullable(0)]
	private WaitForSecondsRealtime <waitForSeconds>5__2; // 0x28

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

	// RVA: 0x1C4C860 Offset: 0x1C4BA60 VA: 0x181C4C860 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1C4C950 Offset: 0x1C4BB50 VA: 0x181C4C950 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
internal class AnrWatchDogMultiThreaded : AnrWatchDog // TypeDefIndex: 16788
{
	// Fields
	private int _ticksSinceUiUpdate; // 0x38
	private bool _reported; // 0x3C
	private bool _stop; // 0x3D
	private readonly Thread _thread; // 0x40

	// Methods

	// RVA: 0x1C3D4E0 Offset: 0x1C3C6E0 VA: 0x181C3D4E0
	internal void .ctor(IDiagnosticLogger logger, SentryMonoBehaviour monoBehaviour, TimeSpan detectionTimeout) { }

	// RVA: 0x1C3D450 Offset: 0x1C3C650 VA: 0x181C3D450 Slot: 4
	internal override void Stop(bool wait = False) { }

	[IteratorStateMachine(typeof(AnrWatchDogMultiThreaded.<UpdateUiStatus>d__6))]
	// RVA: 0x1C3D480 Offset: 0x1C3C680 VA: 0x181C3D480
	private IEnumerator UpdateUiStatus() { }

	// RVA: 0x1C3D150 Offset: 0x1C3C350 VA: 0x181C3D150
	private void Run() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnrWatchDogSingleThreaded.<UpdateUiStatus>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 16789
{
	// Fields
	private int <>1__state; // 0x10
	[Nullable(0)]
	private object <>2__current; // 0x18
	[Nullable(0)]
	public AnrWatchDogSingleThreaded <>4__this; // 0x20
	[Nullable(0)]
	private WaitForSecondsRealtime <waitForSeconds>5__2; // 0x28

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

	// RVA: 0x1C4C710 Offset: 0x1C4B910 VA: 0x181C4C710 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1C4C820 Offset: 0x1C4BA20 VA: 0x181C4C820 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(1)]
internal class AnrWatchDogSingleThreaded : AnrWatchDog // TypeDefIndex: 16790
{
	// Fields
	private readonly Stopwatch _watch; // 0x38
	private bool _stop; // 0x40

	// Methods

	// RVA: 0x1C3D6D0 Offset: 0x1C3C8D0 VA: 0x181C3D6D0
	internal void .ctor(IDiagnosticLogger logger, SentryMonoBehaviour monoBehaviour, TimeSpan detectionTimeout) { }

	// RVA: 0x1C3D660 Offset: 0x1C3C860 VA: 0x181C3D660 Slot: 4
	internal override void Stop(bool wait = False) { }

	[IteratorStateMachine(typeof(AnrWatchDogSingleThreaded.<UpdateUiStatus>d__4))]
	// RVA: 0x1C3D670 Offset: 0x1C3C870 VA: 0x181C3D670
	private IEnumerator UpdateUiStatus() { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(1)]
internal class ApplicationNotResponding : Exception // TypeDefIndex: 16791
{
	// Methods

	// RVA: 0x1C3E4B0 Offset: 0x1C3D6B0 VA: 0x181C3E4B0
	internal void .ctor() { }

	// RVA: 0x1C3E450 Offset: 0x1C3D650 VA: 0x181C3E450
	internal void .ctor(string message) { }

	// RVA: 0x1C3E500 Offset: 0x1C3D700 VA: 0x181C3E500
	internal void .ctor(string message, Exception innerException) { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
[IsReadOnly]
internal struct SceneAdapter // TypeDefIndex: 16792
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x0

	// Properties
	public string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public string get_Name() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(string name) { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
internal interface ISceneManager // TypeDefIndex: 16793
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_SceneLoaded(Action<SceneAdapter, LoadSceneMode> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_SceneLoaded(Action<SceneAdapter, LoadSceneMode> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_SceneUnloaded(Action<SceneAdapter> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_SceneUnloaded(Action<SceneAdapter> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_ActiveSceneChanged(Action<SceneAdapter, SceneAdapter> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_ActiveSceneChanged(Action<SceneAdapter, SceneAdapter> value);
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(2)]
internal sealed class SceneManagerAdapter : ISceneManager // TypeDefIndex: 16794
{
	// Fields
	[CompilerGenerated]
	private Action<SceneAdapter, LoadSceneMode> SceneLoaded; // 0x10
	[CompilerGenerated]
	private Action<SceneAdapter> SceneUnloaded; // 0x18
	[CompilerGenerated]
	private Action<SceneAdapter, SceneAdapter> ActiveSceneChanged; // 0x20
	[Nullable(1)]
	public static readonly SceneManagerAdapter Instance; // 0x0

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C42370 Offset: 0x1C41570 VA: 0x181C42370 Slot: 4
	public void add_SceneLoaded(Action<SceneAdapter, LoadSceneMode> value) { }

	[CompilerGenerated]
	// RVA: 0x1C42580 Offset: 0x1C41780 VA: 0x181C42580 Slot: 5
	public void remove_SceneLoaded(Action<SceneAdapter, LoadSceneMode> value) { }

	[CompilerGenerated]
	// RVA: 0x1C42420 Offset: 0x1C41620 VA: 0x181C42420 Slot: 6
	public void add_SceneUnloaded(Action<SceneAdapter> value) { }

	[CompilerGenerated]
	// RVA: 0x1C42630 Offset: 0x1C41830 VA: 0x181C42630 Slot: 7
	public void remove_SceneUnloaded(Action<SceneAdapter> value) { }

	[CompilerGenerated]
	// RVA: 0x1C422C0 Offset: 0x1C414C0 VA: 0x181C422C0 Slot: 8
	public void add_ActiveSceneChanged(Action<SceneAdapter, SceneAdapter> value) { }

	[CompilerGenerated]
	// RVA: 0x1C424D0 Offset: 0x1C416D0 VA: 0x181C424D0 Slot: 9
	public void remove_ActiveSceneChanged(Action<SceneAdapter, SceneAdapter> value) { }

	// RVA: 0x1C42190 Offset: 0x1C41390 VA: 0x181C42190
	private void .ctor() { }

	// RVA: 0x1C42030 Offset: 0x1C41230 VA: 0x181C42030
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1C41F40 Offset: 0x1C41140 VA: 0x181C41F40
	private void <.ctor>b__10_0(Scene scene, LoadSceneMode mode) { }

	[CompilerGenerated]
	// RVA: 0x1C41F90 Offset: 0x1C41190 VA: 0x181C41F90
	private void <.ctor>b__10_1(Scene scene) { }

	[CompilerGenerated]
	// RVA: 0x1C41FD0 Offset: 0x1C411D0 VA: 0x181C41FD0
	private void <.ctor>b__10_2(Scene sceneFrom, Scene sceneTo) { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(1)]
internal static class UnitySdkInfo // TypeDefIndex: 16795
{
	// Fields
	[CompilerGenerated]
	private static readonly string <Version>k__BackingField; // 0x0
	public const string Name = "sentry.dotnet.unity";
	public const string PackageName = "upm:sentry.unity";

	// Properties
	public static string Version { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C50CD0 Offset: 0x1C4FED0 VA: 0x181C50CD0
	public static string get_Version() { }

	// RVA: 0x1C50C00 Offset: 0x1C4FE00 VA: 0x181C50C00
	private static void .cctor() { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
internal class UnityScopeIntegration : ISdkIntegration // TypeDefIndex: 16796
{
	// Fields
	private readonly MainThreadData _mainThreadData; // 0x10
	private readonly IApplication _application; // 0x18

	// Methods

	// RVA: 0x1C4FC70 Offset: 0x1C4EE70 VA: 0x181C4FC70
	public void .ctor(SentryMonoBehaviour monoBehaviour, IApplication application) { }

	// RVA: 0x1C4FAE0 Offset: 0x1C4ECE0 VA: 0x181C4FAE0 Slot: 4
	public void Register(IHub hub, SentryOptions options) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UnityScopeUpdater.<>c // TypeDefIndex: 16797
{
	// Fields
	[Nullable(0)]
	public static readonly UnityScopeUpdater.<>c <>9; // 0x0
	[Nullable(new[] { 0, 1, 1 })]
	public static Func<string, object> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x1C4C410 Offset: 0x1C4B610 VA: 0x181C4C410
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C4AFC0 Offset: 0x1C4A1C0 VA: 0x181C4AFC0
	internal object <ConfigureScope>b__4_0(string _) { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
internal class UnityScopeUpdater // TypeDefIndex: 16798
{
	// Fields
	private readonly SentryUnityOptions _options; // 0x10
	private readonly MainThreadData _mainThreadData; // 0x18
	private readonly IApplication _application; // 0x20

	// Methods

	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	public void .ctor(SentryUnityOptions options, MainThreadData mainThreadData, IApplication application) { }

	// RVA: 0x1C4FCC0 Offset: 0x1C4EEC0 VA: 0x181C4FCC0
	public void ConfigureScope(Scope scope) { }

	// RVA: 0x1C50820 Offset: 0x1C4FA20 VA: 0x181C50820
	private static void PopulateSdk(SdkVersion sdk) { }

	// RVA: 0x1C501A0 Offset: 0x1C4F3A0 VA: 0x181C501A0
	private void PopulateApp(App app) { }

	// RVA: 0x1C507F0 Offset: 0x1C4F9F0 VA: 0x181C507F0
	private void PopulateOperatingSystem(OperatingSystem operatingSystem) { }

	// RVA: 0x1C50280 Offset: 0x1C4F480 VA: 0x181C50280
	private void PopulateDevice(Device device) { }

	// RVA: 0x1C50490 Offset: 0x1C4F690 VA: 0x181C50490
	private void PopulateGpu(Gpu gpu) { }

	// RVA: 0x1C50B00 Offset: 0x1C4FD00 VA: 0x181C50B00
	private void PopulateUnity(Unity unity) { }

	// RVA: 0x1C50930 Offset: 0x1C4FB30 VA: 0x181C50930
	private void PopulateTags(Action<string, string> setTag) { }

	// RVA: 0x1C50B80 Offset: 0x1C4FD80 VA: 0x181C50B80
	private void PopulateUser(Scope scope) { }
}

// Namespace: Sentry.Unity
[NullableContext(2)]
public interface ISentryUnityInfo // TypeDefIndex: 16799
{
	// Properties
	public abstract bool IL2CPP { get; }
	public abstract Il2CppMethods Il2CppMethods { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IL2CPP();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Il2CppMethods get_Il2CppMethods();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsKnownPlatform();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IsLinux();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsNativeSupportEnabled(SentryUnityOptions options, RuntimePlatform platform);
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(1)]
public class Il2CppMethods // TypeDefIndex: 16800
{
	// Fields
	[CompilerGenerated]
	private readonly Il2CppGcHandleGetTarget <Il2CppGcHandleGetTarget>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Il2CppNativeStackTrace <Il2CppNativeStackTrace>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Il2CppFree <Il2CppFree>k__BackingField; // 0x20

	// Properties
	public Il2CppGcHandleGetTarget Il2CppGcHandleGetTarget { get; }
	public Il2CppNativeStackTrace Il2CppNativeStackTrace { get; }
	public Il2CppFree Il2CppFree { get; }

	// Methods

	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	public void .ctor(Il2CppGcHandleGetTarget il2CppGcHandleGetTarget, Il2CppNativeStackTrace il2CppNativeStackTrace, Il2CppFree il2CppFree) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Il2CppGcHandleGetTarget get_Il2CppGcHandleGetTarget() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Il2CppNativeStackTrace get_Il2CppNativeStackTrace() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Il2CppFree get_Il2CppFree() { }
}

// Namespace: Sentry.Unity
public sealed class Il2CppGcHandleGetTarget : MulticastDelegate // TypeDefIndex: 16801
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr gchandle) { }

	// RVA: 0x1C417E0 Offset: 0x1C409E0 VA: 0x181C417E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr gchandle, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: Sentry.Unity
public sealed class Il2CppNativeStackTrace : MulticastDelegate // TypeDefIndex: 16802
{
	// Methods

	// RVA: 0x449270 Offset: 0x448470 VA: 0x180449270
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(2)]
	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual void Invoke(IntPtr exc, out IntPtr addresses, out int numFrames, out string imageUUID, out string imageName) { }

	// RVA: 0x1C41860 Offset: 0x1C40A60 VA: 0x181C41860 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr exc, out IntPtr addresses, out int numFrames, out string imageUUID, out string imageName, AsyncCallback callback, object object) { }

	[NullableContext(2)]
	// RVA: 0xCF0E80 Offset: 0xCF0080 VA: 0x180CF0E80 Slot: 15
	public virtual void EndInvoke(out IntPtr addresses, out int numFrames, out string imageUUID, out string imageName, IAsyncResult result) { }
}

// Namespace: Sentry.Unity
public sealed class Il2CppFree : MulticastDelegate // TypeDefIndex: 16803
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr ptr) { }

	// RVA: 0x1C41760 Offset: 0x1C40960 VA: 0x181C41760 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Sentry.Unity
[NullableContext(2)]
[Nullable(0)]
internal sealed class MainThreadData // TypeDefIndex: 16804
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <MainThreadId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <OperatingSystem>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<int> <ProcessorCount>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<bool> <SupportsVibration>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <DeviceType>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <CpuDescription>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <DeviceName>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <DeviceUniqueIdentifier>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <DeviceModel>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<int> <SystemMemorySize>k__BackingField; // 0x58
	[CompilerGenerated]
	private Nullable<int> <GraphicsDeviceId>k__BackingField; // 0x60
	[CompilerGenerated]
	private string <GraphicsDeviceName>k__BackingField; // 0x68
	[CompilerGenerated]
	private string <GraphicsDeviceVendorId>k__BackingField; // 0x70
	[CompilerGenerated]
	private string <GraphicsDeviceVendor>k__BackingField; // 0x78
	[CompilerGenerated]
	private Nullable<int> <GraphicsMemorySize>k__BackingField; // 0x80
	[CompilerGenerated]
	private Nullable<bool> <GraphicsMultiThreaded>k__BackingField; // 0x88
	[CompilerGenerated]
	private string <NpotSupport>k__BackingField; // 0x90
	[CompilerGenerated]
	private string <GraphicsDeviceVersion>k__BackingField; // 0x98
	[CompilerGenerated]
	private string <GraphicsDeviceType>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<int> <MaxTextureSize>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Nullable<bool> <SupportsDrawCallInstancing>k__BackingField; // 0xB0
	[CompilerGenerated]
	private Nullable<bool> <SupportsRayTracing>k__BackingField; // 0xB2
	[CompilerGenerated]
	private Nullable<bool> <SupportsComputeShaders>k__BackingField; // 0xB4
	[CompilerGenerated]
	private Nullable<bool> <SupportsGeometryShaders>k__BackingField; // 0xB6
	[CompilerGenerated]
	private Nullable<int> <GraphicsShaderLevel>k__BackingField; // 0xB8
	[CompilerGenerated]
	private Nullable<bool> <IsDebugBuild>k__BackingField; // 0xC0
	[CompilerGenerated]
	private string <EditorVersion>k__BackingField; // 0xC8
	[CompilerGenerated]
	private string <InstallMode>k__BackingField; // 0xD0
	[CompilerGenerated]
	private string <TargetFrameRate>k__BackingField; // 0xD8
	[CompilerGenerated]
	private string <CopyTextureSupport>k__BackingField; // 0xE0
	[CompilerGenerated]
	private string <RenderingThreadingMode>k__BackingField; // 0xE8
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <StartTime>k__BackingField; // 0xF0

	// Properties
	internal Nullable<int> MainThreadId { get; set; }
	public string OperatingSystem { get; set; }
	public Nullable<int> ProcessorCount { get; set; }
	public Nullable<bool> SupportsVibration { get; set; }
	public string DeviceType { get; set; }
	public string CpuDescription { get; set; }
	public string DeviceName { get; set; }
	public string DeviceUniqueIdentifier { get; set; }
	public string DeviceModel { get; set; }
	public Nullable<int> SystemMemorySize { get; set; }
	public Nullable<int> GraphicsDeviceId { get; set; }
	public string GraphicsDeviceName { get; set; }
	public string GraphicsDeviceVendorId { get; set; }
	public string GraphicsDeviceVendor { get; set; }
	public Nullable<int> GraphicsMemorySize { get; set; }
	public Nullable<bool> GraphicsMultiThreaded { get; set; }
	public string NpotSupport { get; set; }
	public string GraphicsDeviceVersion { get; set; }
	public string GraphicsDeviceType { get; set; }
	public Nullable<int> MaxTextureSize { get; set; }
	public Nullable<bool> SupportsDrawCallInstancing { get; set; }
	public Nullable<bool> SupportsRayTracing { get; set; }
	public Nullable<bool> SupportsComputeShaders { get; set; }
	public Nullable<bool> SupportsGeometryShaders { get; set; }
	public Nullable<int> GraphicsShaderLevel { get; set; }
	public Nullable<bool> IsDebugBuild { get; set; }
	public string EditorVersion { get; set; }
	public string InstallMode { get; set; }
	public string TargetFrameRate { get; set; }
	public string CopyTextureSupport { get; set; }
	public string RenderingThreadingMode { get; set; }
	public Nullable<DateTimeOffset> StartTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal Nullable<int> get_MainThreadId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_MainThreadId(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_OperatingSystem() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_OperatingSystem(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Nullable<int> get_ProcessorCount() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ProcessorCount(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x7AD700 Offset: 0x7AC900 VA: 0x1807AD700
	public Nullable<bool> get_SupportsVibration() { }

	[CompilerGenerated]
	// RVA: 0x7AD710 Offset: 0x7AC910 VA: 0x1807AD710
	public void set_SupportsVibration(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_DeviceType() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_DeviceType(string value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_CpuDescription() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_CpuDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_DeviceName() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_DeviceName(string value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_DeviceUniqueIdentifier() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_DeviceUniqueIdentifier(string value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_DeviceModel() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_DeviceModel(string value) { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Nullable<int> get_SystemMemorySize() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_SystemMemorySize(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public Nullable<int> get_GraphicsDeviceId() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_GraphicsDeviceId(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public string get_GraphicsDeviceName() { }

	[CompilerGenerated]
	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_GraphicsDeviceName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public string get_GraphicsDeviceVendorId() { }

	[CompilerGenerated]
	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_GraphicsDeviceVendorId(string value) { }

	[CompilerGenerated]
	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public string get_GraphicsDeviceVendor() { }

	[CompilerGenerated]
	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	public void set_GraphicsDeviceVendor(string value) { }

	[CompilerGenerated]
	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public Nullable<int> get_GraphicsMemorySize() { }

	[CompilerGenerated]
	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_GraphicsMemorySize(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x1B87510 Offset: 0x1B86710 VA: 0x181B87510
	public Nullable<bool> get_GraphicsMultiThreaded() { }

	[CompilerGenerated]
	// RVA: 0x1C41B40 Offset: 0x1C40D40 VA: 0x181C41B40
	public void set_GraphicsMultiThreaded(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public string get_NpotSupport() { }

	[CompilerGenerated]
	// RVA: 0x43B590 Offset: 0x43A790 VA: 0x18043B590
	public void set_NpotSupport(string value) { }

	[CompilerGenerated]
	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public string get_GraphicsDeviceVersion() { }

	[CompilerGenerated]
	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	public void set_GraphicsDeviceVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public string get_GraphicsDeviceType() { }

	[CompilerGenerated]
	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20
	public void set_GraphicsDeviceType(string value) { }

	[CompilerGenerated]
	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public Nullable<int> get_MaxTextureSize() { }

	[CompilerGenerated]
	// RVA: 0xB83400 Offset: 0xB82600 VA: 0x180B83400
	public void set_MaxTextureSize(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x1C41B10 Offset: 0x1C40D10 VA: 0x181C41B10
	public Nullable<bool> get_SupportsDrawCallInstancing() { }

	[CompilerGenerated]
	// RVA: 0x1C41B90 Offset: 0x1C40D90 VA: 0x181C41B90
	public void set_SupportsDrawCallInstancing(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C41B30 Offset: 0x1C40D30 VA: 0x181C41B30
	public Nullable<bool> get_SupportsRayTracing() { }

	[CompilerGenerated]
	// RVA: 0x1C41BB0 Offset: 0x1C40DB0 VA: 0x181C41BB0
	public void set_SupportsRayTracing(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C41B00 Offset: 0x1C40D00 VA: 0x181C41B00
	public Nullable<bool> get_SupportsComputeShaders() { }

	[CompilerGenerated]
	// RVA: 0x1C41B80 Offset: 0x1C40D80 VA: 0x181C41B80
	public void set_SupportsComputeShaders(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C41B20 Offset: 0x1C40D20 VA: 0x181C41B20
	public Nullable<bool> get_SupportsGeometryShaders() { }

	[CompilerGenerated]
	// RVA: 0x1C41BA0 Offset: 0x1C40DA0 VA: 0x181C41BA0
	public void set_SupportsGeometryShaders(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080
	public Nullable<int> get_GraphicsShaderLevel() { }

	[CompilerGenerated]
	// RVA: 0x146AE20 Offset: 0x146A020 VA: 0x18146AE20
	public void set_GraphicsShaderLevel(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x1C41AD0 Offset: 0x1C40CD0 VA: 0x181C41AD0
	public Nullable<bool> get_IsDebugBuild() { }

	[CompilerGenerated]
	// RVA: 0x1C41B50 Offset: 0x1C40D50 VA: 0x181C41B50
	public void set_IsDebugBuild(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x738340 Offset: 0x737540 VA: 0x180738340
	public string get_EditorVersion() { }

	[CompilerGenerated]
	// RVA: 0x1532B30 Offset: 0x1531D30 VA: 0x181532B30
	public void set_EditorVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	public string get_InstallMode() { }

	[CompilerGenerated]
	// RVA: 0x599C80 Offset: 0x598E80 VA: 0x180599C80
	public void set_InstallMode(string value) { }

	[CompilerGenerated]
	// RVA: 0x599C40 Offset: 0x598E40 VA: 0x180599C40
	public string get_TargetFrameRate() { }

	[CompilerGenerated]
	// RVA: 0x599C70 Offset: 0x598E70 VA: 0x180599C70
	public void set_TargetFrameRate(string value) { }

	[CompilerGenerated]
	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	public string get_CopyTextureSupport() { }

	[CompilerGenerated]
	// RVA: 0x8A5A60 Offset: 0x8A4C60 VA: 0x1808A5A60
	public void set_CopyTextureSupport(string value) { }

	[CompilerGenerated]
	// RVA: 0x796090 Offset: 0x795290 VA: 0x180796090
	public string get_RenderingThreadingMode() { }

	[CompilerGenerated]
	// RVA: 0x7960E0 Offset: 0x7952E0 VA: 0x1807960E0
	public void set_RenderingThreadingMode(string value) { }

	[CompilerGenerated]
	// RVA: 0x1C41AE0 Offset: 0x1C40CE0 VA: 0x181C41AE0
	public Nullable<DateTimeOffset> get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x1C41B60 Offset: 0x1C40D60 VA: 0x181C41B60
	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x1C41A50 Offset: 0x1C40C50 VA: 0x181C41A50
	public bool IsMainThread() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(1)]
public abstract class ScopeObserver : IScopeObserver // TypeDefIndex: 16805
{
	// Fields
	private readonly SentryOptions _options; // 0x10
	private readonly string _name; // 0x18

	// Methods

	// RVA: 0x162EF30 Offset: 0x162E130 VA: 0x18162EF30
	public void .ctor(string name, SentryOptions options) { }

	// RVA: 0x1C42A40 Offset: 0x1C41C40 VA: 0x181C42A40 Slot: 4
	public void AddBreadcrumb(Breadcrumb breadcrumb) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void AddBreadcrumbImpl(Breadcrumb breadcrumb);

	// RVA: 0x1C42C30 Offset: 0x1C41E30 VA: 0x181C42C30 Slot: 5
	public void SetExtra(string key, object value) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void SetExtraImpl(string key, string value);

	// RVA: 0x1C42F30 Offset: 0x1C42130 VA: 0x181C42F30 Slot: 6
	public void SetTag(string key, string value) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SetTagImpl(string key, string value);

	// RVA: 0x1C43370 Offset: 0x1C42570 VA: 0x181C43370 Slot: 7
	public void UnsetTag(string key) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void UnsetTagImpl(string key);

	[NullableContext(2)]
	// RVA: 0x1C430F0 Offset: 0x1C422F0 VA: 0x181C430F0 Slot: 8
	public void SetUser(User user) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void SetUserImpl(User user);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void UnsetUserImpl();
}

// Namespace: Sentry.Unity
internal class ScreenshotAttachment : Attachment // TypeDefIndex: 16806
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1C43BE0 Offset: 0x1C42DE0 VA: 0x181C43BE0
	public void .ctor(IAttachmentContent content) { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
internal class ScreenshotAttachmentContent : IAttachmentContent // TypeDefIndex: 16807
{
	// Fields
	private readonly SentryMonoBehaviour _behaviour; // 0x10
	private readonly SentryUnityOptions _options; // 0x18

	// Methods

	// RVA: 0x161DA80 Offset: 0x161CC80 VA: 0x18161DA80
	public void .ctor(SentryUnityOptions options, SentryMonoBehaviour behaviour) { }

	// RVA: 0x1C43AA0 Offset: 0x1C42CA0 VA: 0x181C43AA0 Slot: 4
	public Stream GetStream() { }

	// RVA: 0x1C43BC0 Offset: 0x1C42DC0 VA: 0x181C43BC0
	internal static int GetTargetResolution(ScreenshotQuality quality) { }

	// RVA: 0x1C434F0 Offset: 0x1C426F0 VA: 0x181C434F0
	internal byte[] CaptureScreenshot(int width, int height) { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
public class ScriptableSentryUnityOptions : ScriptableObject // TypeDefIndex: 16808
{
	// Fields
	internal const string ConfigRootFolder = "Sentry";
	internal const string ConfigName = "SentryOptions";
	[CompilerGenerated]
	[SerializeField]
	private bool <Enabled>k__BackingField; // 0x18
	[CompilerGenerated]
	[SerializeField]
	[Nullable(2)]
	private string <Dsn>k__BackingField; // 0x20
	[CompilerGenerated]
	[SerializeField]
	private bool <CaptureInEditor>k__BackingField; // 0x28
	[SerializeField]
	[CompilerGenerated]
	private bool <EnableLogDebouncing>k__BackingField; // 0x29
	[SerializeField]
	[CompilerGenerated]
	private int <DebounceTimeLog>k__BackingField; // 0x2C
	[SerializeField]
	[CompilerGenerated]
	private int <DebounceTimeWarning>k__BackingField; // 0x30
	[SerializeField]
	[CompilerGenerated]
	private int <DebounceTimeError>k__BackingField; // 0x34
	[SerializeField]
	[CompilerGenerated]
	private double <TracesSampleRate>k__BackingField; // 0x38
	[CompilerGenerated]
	[SerializeField]
	private bool <AutoStartupTraces>k__BackingField; // 0x40
	[SerializeField]
	[CompilerGenerated]
	private bool <AutoSceneLoadTraces>k__BackingField; // 0x41
	[SerializeField]
	[CompilerGenerated]
	private bool <AutoAwakeTraces>k__BackingField; // 0x42
	[SerializeField]
	[CompilerGenerated]
	private bool <AutoSessionTracking>k__BackingField; // 0x43
	[SerializeField]
	[CompilerGenerated]
	private int <AutoSessionTrackingInterval>k__BackingField; // 0x44
	[SerializeField]
	[CompilerGenerated]
	private string <ReleaseOverride>k__BackingField; // 0x48
	[CompilerGenerated]
	[SerializeField]
	private string <EnvironmentOverride>k__BackingField; // 0x50
	[SerializeField]
	[CompilerGenerated]
	private bool <AttachStacktrace>k__BackingField; // 0x58
	[CompilerGenerated]
	[SerializeField]
	private bool <AttachScreenshot>k__BackingField; // 0x59
	[CompilerGenerated]
	[SerializeField]
	private ScreenshotQuality <ScreenshotQuality>k__BackingField; // 0x5C
	[CompilerGenerated]
	[SerializeField]
	private int <ScreenshotCompression>k__BackingField; // 0x60
	[CompilerGenerated]
	[SerializeField]
	private bool <AttachViewHierarchy>k__BackingField; // 0x64
	[CompilerGenerated]
	[SerializeField]
	private int <MaxViewHierarchyRootObjects>k__BackingField; // 0x68
	[CompilerGenerated]
	[SerializeField]
	private int <MaxViewHierarchyObjectChildCount>k__BackingField; // 0x6C
	[SerializeField]
	[CompilerGenerated]
	private int <MaxViewHierarchyDepth>k__BackingField; // 0x70
	[CompilerGenerated]
	[SerializeField]
	private bool <BreadcrumbsForLogs>k__BackingField; // 0x74
	[CompilerGenerated]
	[SerializeField]
	private bool <BreadcrumbsForWarnings>k__BackingField; // 0x75
	[CompilerGenerated]
	[SerializeField]
	private bool <BreadcrumbsForAsserts>k__BackingField; // 0x76
	[CompilerGenerated]
	[SerializeField]
	private bool <BreadcrumbsForErrors>k__BackingField; // 0x77
	[SerializeField]
	[CompilerGenerated]
	private bool <BreadcrumbsForExceptions>k__BackingField; // 0x78
	[CompilerGenerated]
	[SerializeField]
	private int <MaxBreadcrumbs>k__BackingField; // 0x7C
	[CompilerGenerated]
	[SerializeField]
	private ReportAssembliesMode <ReportAssembliesMode>k__BackingField; // 0x80
	[CompilerGenerated]
	[SerializeField]
	private bool <SendDefaultPii>k__BackingField; // 0x84
	[CompilerGenerated]
	[SerializeField]
	private bool <IsEnvironmentUser>k__BackingField; // 0x85
	[CompilerGenerated]
	[SerializeField]
	private bool <EnableOfflineCaching>k__BackingField; // 0x86
	[CompilerGenerated]
	[SerializeField]
	private int <MaxCacheItems>k__BackingField; // 0x88
	[CompilerGenerated]
	[SerializeField]
	private int <InitCacheFlushTimeout>k__BackingField; // 0x8C
	[CompilerGenerated]
	[SerializeField]
	private float <SampleRate>k__BackingField; // 0x90
	[CompilerGenerated]
	[SerializeField]
	private int <ShutdownTimeout>k__BackingField; // 0x94
	[CompilerGenerated]
	[SerializeField]
	private int <MaxQueueItems>k__BackingField; // 0x98
	[CompilerGenerated]
	[SerializeField]
	private bool <AnrDetectionEnabled>k__BackingField; // 0x9C
	[SerializeField]
	[CompilerGenerated]
	private int <AnrTimeout>k__BackingField; // 0xA0
	[SerializeField]
	[CompilerGenerated]
	private bool <FilterBadGatewayExceptions>k__BackingField; // 0xA4
	[CompilerGenerated]
	[SerializeField]
	private bool <FilterWebExceptions>k__BackingField; // 0xA5
	[SerializeField]
	[CompilerGenerated]
	private bool <FilterSocketExceptions>k__BackingField; // 0xA6
	[SerializeField]
	[CompilerGenerated]
	private bool <IosNativeSupportEnabled>k__BackingField; // 0xA7
	[SerializeField]
	[CompilerGenerated]
	private bool <AndroidNativeSupportEnabled>k__BackingField; // 0xA8
	[CompilerGenerated]
	[SerializeField]
	private bool <NdkIntegrationEnabled>k__BackingField; // 0xA9
	[CompilerGenerated]
	[SerializeField]
	private bool <NdkScopeSyncEnabled>k__BackingField; // 0xAA
	[CompilerGenerated]
	[SerializeField]
	private bool <WindowsNativeSupportEnabled>k__BackingField; // 0xAB
	[SerializeField]
	[CompilerGenerated]
	private bool <MacosNativeSupportEnabled>k__BackingField; // 0xAC
	[CompilerGenerated]
	[SerializeField]
	private bool <LinuxNativeSupportEnabled>k__BackingField; // 0xAD
	[CompilerGenerated]
	[SerializeField]
	private bool <Il2CppLineNumberSupportEnabled>k__BackingField; // 0xAE
	[SerializeField]
	[CompilerGenerated]
	[Nullable(2)]
	private SentryRuntimeOptionsConfiguration <RuntimeOptionsConfiguration>k__BackingField; // 0xB0
	[Nullable(2)]
	[SerializeField]
	[CompilerGenerated]
	private SentryBuildTimeOptionsConfiguration <BuildTimeOptionsConfiguration>k__BackingField; // 0xB8
	[CompilerGenerated]
	[SerializeField]
	private bool <Debug>k__BackingField; // 0xC0
	[CompilerGenerated]
	[SerializeField]
	private bool <DebugOnlyInEditor>k__BackingField; // 0xC1
	[CompilerGenerated]
	[SerializeField]
	private SentryLevel <DiagnosticLevel>k__BackingField; // 0xC2

	// Properties
	public bool Enabled { get; set; }
	[Nullable(2)]
	public string Dsn { get; set; }
	public bool CaptureInEditor { get; set; }
	public bool EnableLogDebouncing { get; set; }
	public int DebounceTimeLog { get; set; }
	public int DebounceTimeWarning { get; set; }
	public int DebounceTimeError { get; set; }
	public double TracesSampleRate { get; set; }
	public bool AutoStartupTraces { get; set; }
	public bool AutoSceneLoadTraces { get; set; }
	public bool AutoAwakeTraces { get; set; }
	public bool AutoSessionTracking { get; set; }
	public int AutoSessionTrackingInterval { get; set; }
	public string ReleaseOverride { get; set; }
	public string EnvironmentOverride { get; set; }
	public bool AttachStacktrace { get; set; }
	public bool AttachScreenshot { get; set; }
	public ScreenshotQuality ScreenshotQuality { get; set; }
	public int ScreenshotCompression { get; set; }
	public bool AttachViewHierarchy { get; set; }
	public int MaxViewHierarchyRootObjects { get; set; }
	public int MaxViewHierarchyObjectChildCount { get; set; }
	public int MaxViewHierarchyDepth { get; set; }
	public bool BreadcrumbsForLogs { get; set; }
	public bool BreadcrumbsForWarnings { get; set; }
	public bool BreadcrumbsForAsserts { get; set; }
	public bool BreadcrumbsForErrors { get; set; }
	public bool BreadcrumbsForExceptions { get; set; }
	public int MaxBreadcrumbs { get; set; }
	public ReportAssembliesMode ReportAssembliesMode { get; set; }
	public bool SendDefaultPii { get; set; }
	public bool IsEnvironmentUser { get; set; }
	public bool EnableOfflineCaching { get; set; }
	public int MaxCacheItems { get; set; }
	public int InitCacheFlushTimeout { get; set; }
	public float SampleRate { get; set; }
	public int ShutdownTimeout { get; set; }
	public int MaxQueueItems { get; set; }
	public bool AnrDetectionEnabled { get; set; }
	public int AnrTimeout { get; set; }
	public bool FilterBadGatewayExceptions { get; set; }
	public bool FilterWebExceptions { get; set; }
	public bool FilterSocketExceptions { get; set; }
	public bool IosNativeSupportEnabled { get; set; }
	public bool AndroidNativeSupportEnabled { get; set; }
	public bool NdkIntegrationEnabled { get; set; }
	public bool NdkScopeSyncEnabled { get; set; }
	public bool WindowsNativeSupportEnabled { get; set; }
	public bool MacosNativeSupportEnabled { get; set; }
	public bool LinuxNativeSupportEnabled { get; set; }
	public bool Il2CppLineNumberSupportEnabled { get; set; }
	[Nullable(2)]
	public SentryRuntimeOptionsConfiguration RuntimeOptionsConfiguration { get; set; }
	[Nullable(2)]
	public SentryBuildTimeOptionsConfiguration BuildTimeOptionsConfiguration { get; set; }
	public bool Debug { get; set; }
	public bool DebugOnlyInEditor { get; set; }
	public SentryLevel DiagnosticLevel { get; set; }

	// Methods

	// RVA: 0x1C43C50 Offset: 0x1C42E50 VA: 0x181C43C50
	public static string GetConfigPath(string notDefaultConfigName) { }

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_Enabled() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_Enabled(bool value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Dsn() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Dsn(string value) { }

	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_CaptureInEditor() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_CaptureInEditor(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4C6AB0 Offset: 0x4C5CB0 VA: 0x1804C6AB0
	public bool get_EnableLogDebouncing() { }

	[CompilerGenerated]
	// RVA: 0x4C6AE0 Offset: 0x4C5CE0 VA: 0x1804C6AE0
	public void set_EnableLogDebouncing(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public int get_DebounceTimeLog() { }

	[CompilerGenerated]
	// RVA: 0x5014F0 Offset: 0x5006F0 VA: 0x1805014F0
	public void set_DebounceTimeLog(int value) { }

	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int get_DebounceTimeWarning() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_DebounceTimeWarning(int value) { }

	[CompilerGenerated]
	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public int get_DebounceTimeError() { }

	[CompilerGenerated]
	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	public void set_DebounceTimeError(int value) { }

	[CompilerGenerated]
	// RVA: 0x11FB180 Offset: 0x11FA380 VA: 0x1811FB180
	public double get_TracesSampleRate() { }

	[CompilerGenerated]
	// RVA: 0x11FB1F0 Offset: 0x11FA3F0 VA: 0x1811FB1F0
	public void set_TracesSampleRate(double value) { }

	[CompilerGenerated]
	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_AutoStartupTraces() { }

	[CompilerGenerated]
	// RVA: 0x445700 Offset: 0x444900 VA: 0x180445700
	public void set_AutoStartupTraces(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7724A0 Offset: 0x7716A0 VA: 0x1807724A0
	public bool get_AutoSceneLoadTraces() { }

	[CompilerGenerated]
	// RVA: 0x1C44C10 Offset: 0x1C43E10 VA: 0x181C44C10
	public void set_AutoSceneLoadTraces(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6F90C0 Offset: 0x6F82C0 VA: 0x1806F90C0
	public bool get_AutoAwakeTraces() { }

	[CompilerGenerated]
	// RVA: 0x1C44C00 Offset: 0x1C43E00 VA: 0x181C44C00
	public void set_AutoAwakeTraces(bool value) { }

	[CompilerGenerated]
	// RVA: 0x772500 Offset: 0x771700 VA: 0x180772500
	public bool get_AutoSessionTracking() { }

	[CompilerGenerated]
	// RVA: 0x1C44C20 Offset: 0x1C43E20 VA: 0x181C44C20
	public void set_AutoSessionTracking(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public int get_AutoSessionTrackingInterval() { }

	[CompilerGenerated]
	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	public void set_AutoSessionTrackingInterval(int value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_ReleaseOverride() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_ReleaseOverride(string value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_EnvironmentOverride() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_EnvironmentOverride(string value) { }

	[CompilerGenerated]
	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30
	public bool get_AttachStacktrace() { }

	[CompilerGenerated]
	// RVA: 0x4D1A70 Offset: 0x4D0C70 VA: 0x1804D1A70
	public void set_AttachStacktrace(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7725E0 Offset: 0x7717E0 VA: 0x1807725E0
	public bool get_AttachScreenshot() { }

	[CompilerGenerated]
	// RVA: 0xE5B9A0 Offset: 0xE5ABA0 VA: 0x180E5B9A0
	public void set_AttachScreenshot(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10
	public ScreenshotQuality get_ScreenshotQuality() { }

	[CompilerGenerated]
	// RVA: 0x4EDE90 Offset: 0x4ED090 VA: 0x1804EDE90
	public void set_ScreenshotQuality(ScreenshotQuality value) { }

	[CompilerGenerated]
	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public int get_ScreenshotCompression() { }

	[CompilerGenerated]
	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	public void set_ScreenshotCompression(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C44B00 Offset: 0x1C43D00 VA: 0x181C44B00
	public bool get_AttachViewHierarchy() { }

	[CompilerGenerated]
	// RVA: 0x1C44BF0 Offset: 0x1C43DF0 VA: 0x181C44BF0
	public void set_AttachViewHierarchy(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80
	public int get_MaxViewHierarchyRootObjects() { }

	[CompilerGenerated]
	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	public void set_MaxViewHierarchyRootObjects(int value) { }

	[CompilerGenerated]
	// RVA: 0x526CA0 Offset: 0x525EA0 VA: 0x180526CA0
	public int get_MaxViewHierarchyObjectChildCount() { }

	[CompilerGenerated]
	// RVA: 0x526DA0 Offset: 0x525FA0 VA: 0x180526DA0
	public void set_MaxViewHierarchyObjectChildCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	public int get_MaxViewHierarchyDepth() { }

	[CompilerGenerated]
	// RVA: 0x526DC0 Offset: 0x525FC0 VA: 0x180526DC0
	public void set_MaxViewHierarchyDepth(int value) { }

	[CompilerGenerated]
	// RVA: 0x8CA2F0 Offset: 0x8C94F0 VA: 0x1808CA2F0
	public bool get_BreadcrumbsForLogs() { }

	[CompilerGenerated]
	// RVA: 0x1C13520 Offset: 0x1C12720 VA: 0x181C13520
	public void set_BreadcrumbsForLogs(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8CA280 Offset: 0x8C9480 VA: 0x1808CA280
	public bool get_BreadcrumbsForWarnings() { }

	[CompilerGenerated]
	// RVA: 0x1C44C50 Offset: 0x1C43E50 VA: 0x181C44C50
	public void set_BreadcrumbsForWarnings(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8CA2A0 Offset: 0x8C94A0 VA: 0x1808CA2A0
	public bool get_BreadcrumbsForAsserts() { }

	[CompilerGenerated]
	// RVA: 0x1C44C30 Offset: 0x1C43E30 VA: 0x181C44C30
	public void set_BreadcrumbsForAsserts(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8CA2D0 Offset: 0x8C94D0 VA: 0x1808CA2D0
	public bool get_BreadcrumbsForErrors() { }

	[CompilerGenerated]
	// RVA: 0x1C44C40 Offset: 0x1C43E40 VA: 0x181C44C40
	public void set_BreadcrumbsForErrors(bool value) { }

	[CompilerGenerated]
	// RVA: 0x61CC40 Offset: 0x61BE40 VA: 0x18061CC40
	public bool get_BreadcrumbsForExceptions() { }

	[CompilerGenerated]
	// RVA: 0x1B30BA0 Offset: 0x1B2FDA0 VA: 0x181B30BA0
	public void set_BreadcrumbsForExceptions(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44BB0 Offset: 0x1C43DB0 VA: 0x181C44BB0
	public int get_MaxBreadcrumbs() { }

	[CompilerGenerated]
	// RVA: 0x1C44D00 Offset: 0x1C43F00 VA: 0x181C44D00
	public void set_MaxBreadcrumbs(int value) { }

	[CompilerGenerated]
	// RVA: 0x1A6BA60 Offset: 0x1A6AC60 VA: 0x181A6BA60
	public ReportAssembliesMode get_ReportAssembliesMode() { }

	[CompilerGenerated]
	// RVA: 0x1A6BA80 Offset: 0x1A6AC80 VA: 0x181A6BA80
	public void set_ReportAssembliesMode(ReportAssembliesMode value) { }

	[CompilerGenerated]
	// RVA: 0x1AF8A70 Offset: 0x1AF7C70 VA: 0x181AF8A70
	public bool get_SendDefaultPii() { }

	[CompilerGenerated]
	// RVA: 0x1C44D30 Offset: 0x1C43F30 VA: 0x181C44D30
	public void set_SendDefaultPii(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44B90 Offset: 0x1C43D90 VA: 0x181C44B90
	public bool get_IsEnvironmentUser() { }

	[CompilerGenerated]
	// RVA: 0x1C44CE0 Offset: 0x1C43EE0 VA: 0x181C44CE0
	public void set_IsEnvironmentUser(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44B30 Offset: 0x1C43D30 VA: 0x181C44B30
	public bool get_EnableOfflineCaching() { }

	[CompilerGenerated]
	// RVA: 0x1C44C80 Offset: 0x1C43E80 VA: 0x181C44C80
	public void set_EnableOfflineCaching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950
	public int get_MaxCacheItems() { }

	[CompilerGenerated]
	// RVA: 0x73BA10 Offset: 0x73AC10 VA: 0x18073BA10
	public void set_MaxCacheItems(int value) { }

	[CompilerGenerated]
	// RVA: 0x772310 Offset: 0x771510 VA: 0x180772310
	public int get_InitCacheFlushTimeout() { }

	[CompilerGenerated]
	// RVA: 0xF05DB0 Offset: 0xF04FB0 VA: 0x180F05DB0
	public void set_InitCacheFlushTimeout(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C44BD0 Offset: 0x1C43DD0 VA: 0x181C44BD0
	public float get_SampleRate() { }

	[CompilerGenerated]
	// RVA: 0x1C44D20 Offset: 0x1C43F20 VA: 0x181C44D20
	public void set_SampleRate(float value) { }

	[CompilerGenerated]
	// RVA: 0x772200 Offset: 0x771400 VA: 0x180772200
	public int get_ShutdownTimeout() { }

	[CompilerGenerated]
	// RVA: 0x1B5E490 Offset: 0x1B5D690 VA: 0x181B5E490
	public void set_ShutdownTimeout(int value) { }

	[CompilerGenerated]
	// RVA: 0x838410 Offset: 0x837610 VA: 0x180838410
	public int get_MaxQueueItems() { }

	[CompilerGenerated]
	// RVA: 0x838420 Offset: 0x837620 VA: 0x180838420
	public void set_MaxQueueItems(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B33AF0 Offset: 0x1B32CF0 VA: 0x181B33AF0
	public bool get_AnrDetectionEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1B275F0 Offset: 0x1B267F0 VA: 0x181B275F0
	public void set_AnrDetectionEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5E7ED0 Offset: 0x5E70D0 VA: 0x1805E7ED0
	public int get_AnrTimeout() { }

	[CompilerGenerated]
	// RVA: 0xB833F0 Offset: 0xB825F0 VA: 0x180B833F0
	public void set_AnrTimeout(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C44B40 Offset: 0x1C43D40 VA: 0x181C44B40
	public bool get_FilterBadGatewayExceptions() { }

	[CompilerGenerated]
	// RVA: 0x1C44C90 Offset: 0x1C43E90 VA: 0x181C44C90
	public void set_FilterBadGatewayExceptions(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44B60 Offset: 0x1C43D60 VA: 0x181C44B60
	public bool get_FilterWebExceptions() { }

	[CompilerGenerated]
	// RVA: 0x1C44CB0 Offset: 0x1C43EB0 VA: 0x181C44CB0
	public void set_FilterWebExceptions(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44B50 Offset: 0x1C43D50 VA: 0x181C44B50
	public bool get_FilterSocketExceptions() { }

	[CompilerGenerated]
	// RVA: 0x1C44CA0 Offset: 0x1C43EA0 VA: 0x181C44CA0
	public void set_FilterSocketExceptions(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44B80 Offset: 0x1C43D80 VA: 0x181C44B80
	public bool get_IosNativeSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C44CD0 Offset: 0x1C43ED0 VA: 0x181C44CD0
	public void set_IosNativeSupportEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x738050 Offset: 0x737250 VA: 0x180738050
	public bool get_AndroidNativeSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x7385D0 Offset: 0x7377D0 VA: 0x1807385D0
	public void set_AndroidNativeSupportEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x738150 Offset: 0x737350 VA: 0x180738150
	public bool get_NdkIntegrationEnabled() { }

	[CompilerGenerated]
	// RVA: 0x772C50 Offset: 0x771E50 VA: 0x180772C50
	public void set_NdkIntegrationEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44BC0 Offset: 0x1C43DC0 VA: 0x181C44BC0
	public bool get_NdkScopeSyncEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C44D10 Offset: 0x1C43F10 VA: 0x181C44D10
	public void set_NdkScopeSyncEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44BE0 Offset: 0x1C43DE0 VA: 0x181C44BE0
	public bool get_WindowsNativeSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C44D40 Offset: 0x1C43F40 VA: 0x181C44D40
	public void set_WindowsNativeSupportEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x890A50 Offset: 0x88FC50 VA: 0x180890A50
	public bool get_MacosNativeSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x890A60 Offset: 0x88FC60 VA: 0x180890A60
	public void set_MacosNativeSupportEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44BA0 Offset: 0x1C43DA0 VA: 0x181C44BA0
	public bool get_LinuxNativeSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C44CF0 Offset: 0x1C43EF0 VA: 0x181C44CF0
	public void set_LinuxNativeSupportEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44B70 Offset: 0x1C43D70 VA: 0x181C44B70
	public bool get_Il2CppLineNumberSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C44CC0 Offset: 0x1C43EC0 VA: 0x181C44CC0
	public void set_Il2CppLineNumberSupportEnabled(bool value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	public SentryRuntimeOptionsConfiguration get_RuntimeOptionsConfiguration() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x88DF00 Offset: 0x88D100 VA: 0x18088DF00
	public void set_RuntimeOptionsConfiguration(SentryRuntimeOptionsConfiguration value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080
	public SentryBuildTimeOptionsConfiguration get_BuildTimeOptionsConfiguration() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x146AE20 Offset: 0x146A020 VA: 0x18146AE20
	public void set_BuildTimeOptionsConfiguration(SentryBuildTimeOptionsConfiguration value) { }

	[CompilerGenerated]
	// RVA: 0x5C6220 Offset: 0x5C5420 VA: 0x1805C6220
	public bool get_Debug() { }

	[CompilerGenerated]
	// RVA: 0x6BC540 Offset: 0x6BB740 VA: 0x1806BC540
	public void set_Debug(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44B10 Offset: 0x1C43D10 VA: 0x181C44B10
	public bool get_DebugOnlyInEditor() { }

	[CompilerGenerated]
	// RVA: 0x1C44C60 Offset: 0x1C43E60 VA: 0x181C44C60
	public void set_DebugOnlyInEditor(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44B20 Offset: 0x1C43D20 VA: 0x181C44B20
	public SentryLevel get_DiagnosticLevel() { }

	[CompilerGenerated]
	// RVA: 0x1C44C70 Offset: 0x1C43E70 VA: 0x181C44C70
	public void set_DiagnosticLevel(SentryLevel value) { }

	// RVA: 0x1C43EF0 Offset: 0x1C430F0 VA: 0x181C43EF0
	public static SentryUnityOptions LoadSentryUnityOptions(ISentryUnityInfo unityInfo) { }

	[NullableContext(2)]
	// RVA: 0x1C43F80 Offset: 0x1C43180 VA: 0x181C43F80
	internal SentryUnityOptions ToSentryUnityOptions(bool isBuilding, ISentryUnityInfo unityInfo, IApplication application) { }

	// RVA: 0x1C43D70 Offset: 0x1C42F70 VA: 0x181C43D70
	private void HandlePlatformRestrictions(SentryUnityOptions options, IApplication application, ISentryUnityInfo unityInfo) { }

	// RVA: 0x1C43CC0 Offset: 0x1C42EC0 VA: 0x181C43CC0
	private void HandleExceptionFilter(SentryUnityOptions options) { }

	// RVA: 0x1C43F60 Offset: 0x1C43160 VA: 0x181C43F60
	internal bool ShouldDebug(bool isEditorPlayer) { }

	// RVA: 0x1C448D0 Offset: 0x1C43AD0 VA: 0x181C448D0
	public void .ctor() { }
}

// Namespace: Sentry.Unity
public abstract class SentryBuildTimeOptionsConfiguration : ScriptableObject // TypeDefIndex: 16809
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Configure(SentryUnityOptions options, SentryCliOptions cliOptions);

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: Sentry.Unity
[NullableContext(2)]
[Nullable(0)]
[Serializable]
public sealed class SentryCliOptions : ScriptableObject // TypeDefIndex: 16810
{
	// Fields
	[Nullable(1)]
	internal const string ConfigName = "SentryCliOptions";
	[Nullable(1)]
	public const string EditorMenuPath = "Tools -> Sentry -> Debug Symbols";
	[SerializeField]
	[CompilerGenerated]
	private bool <UploadSymbols>k__BackingField; // 0x18
	[SerializeField]
	[CompilerGenerated]
	private bool <UploadDevelopmentSymbols>k__BackingField; // 0x19
	[SerializeField]
	[CompilerGenerated]
	private bool <UploadSources>k__BackingField; // 0x1A
	[SerializeField]
	[CompilerGenerated]
	private string <UrlOverride>k__BackingField; // 0x20
	[CompilerGenerated]
	[SerializeField]
	private string <Auth>k__BackingField; // 0x28
	[CompilerGenerated]
	[SerializeField]
	private string <Organization>k__BackingField; // 0x30
	[CompilerGenerated]
	[SerializeField]
	private string <Project>k__BackingField; // 0x38

	// Properties
	public bool UploadSymbols { get; set; }
	public bool UploadDevelopmentSymbols { get; set; }
	public bool UploadSources { get; set; }
	public string UrlOverride { get; set; }
	public string Auth { get; set; }
	public string Organization { get; set; }
	public string Project { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_UploadSymbols() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_UploadSymbols(bool value) { }

	[CompilerGenerated]
	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40
	public bool get_UploadDevelopmentSymbols() { }

	[CompilerGenerated]
	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50
	public void set_UploadDevelopmentSymbols(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81F0F0 Offset: 0x81E2F0 VA: 0x18081F0F0
	public bool get_UploadSources() { }

	[CompilerGenerated]
	// RVA: 0x18AE3F0 Offset: 0x18AD5F0 VA: 0x1818AE3F0
	public void set_UploadSources(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_UrlOverride() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_UrlOverride(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Auth() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Auth(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Organization() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Organization(string value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Project() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Project(string value) { }

	[NullableContext(1)]
	// RVA: 0x1C44D50 Offset: 0x1C43F50 VA: 0x181C44D50
	internal static string GetConfigPath(string notDefaultConfigName) { }

	[NullableContext(1)]
	// RVA: 0x1C45030 Offset: 0x1C44230 VA: 0x181C45030
	private static void MissingFieldWarning(IDiagnosticLogger logger, string name) { }

	// RVA: 0x1C44DC0 Offset: 0x1C43FC0 VA: 0x181C44DC0
	public bool IsValid(IDiagnosticLogger logger, bool isDevelopmentBuild) { }

	// RVA: 0x1C450B0 Offset: 0x1C442B0 VA: 0x181C450B0
	public void .ctor() { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
[AddComponentMenu("")]
public class SentryMonoBehaviour : MonoBehaviour // TypeDefIndex: 16811
{
	// Fields
	[Nullable(2)]
	private static SentryMonoBehaviour _instance; // 0x0
	[Nullable(2)]
	[CompilerGenerated]
	private Action ApplicationResuming; // 0x20
	[Nullable(2)]
	[CompilerGenerated]
	private Action ApplicationPausing; // 0x28
	internal bool _isRunning; // 0x30
	[Nullable(2)]
	private IApplication _application; // 0x38
	internal readonly MainThreadData MainThreadData; // 0x40
	[Nullable(2)]
	private ISentrySystemInfo _sentrySystemInfo; // 0x48

	// Properties
	public static SentryMonoBehaviour Instance { get; }
	internal IApplication Application { get; set; }
	internal ISentrySystemInfo SentrySystemInfo { get; set; }

	// Methods

	// RVA: 0x1C46640 Offset: 0x1C45840 VA: 0x181C46640
	public static SentryMonoBehaviour get_Instance() { }

	// RVA: 0x1C46330 Offset: 0x1C45530 VA: 0x181C46330
	public void StartAwakeSpan(MonoBehaviour monoBehaviour) { }

	// RVA: 0x1C46180 Offset: 0x1C45380 VA: 0x181C46180
	public void FinishAwakeSpan() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C46530 Offset: 0x1C45730 VA: 0x181C46530
	public void add_ApplicationResuming(Action value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C46850 Offset: 0x1C45A50 VA: 0x181C46850
	public void remove_ApplicationResuming(Action value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x1C46490 Offset: 0x1C45690 VA: 0x181C46490
	public void add_ApplicationPausing(Action value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x1C467B0 Offset: 0x1C459B0 VA: 0x181C467B0
	public void remove_ApplicationPausing(Action value) { }

	// RVA: 0x1C465D0 Offset: 0x1C457D0 VA: 0x181C465D0
	internal IApplication get_Application() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void set_Application(IApplication value) { }

	// RVA: 0x1C46290 Offset: 0x1C45490 VA: 0x181C46290
	internal void UpdatePauseStatus(bool paused) { }

	// RVA: 0x1C46290 Offset: 0x1C45490 VA: 0x181C46290
	internal void OnApplicationPause(bool pauseStatus) { }

	// RVA: 0x1C46250 Offset: 0x1C45450 VA: 0x181C46250
	internal void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x1C462D0 Offset: 0x1C454D0 VA: 0x181C462D0
	private void OnApplicationQuit() { }

	// RVA: 0x1C46740 Offset: 0x1C45940 VA: 0x181C46740
	internal ISentrySystemInfo get_SentrySystemInfo() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	internal void set_SentrySystemInfo(ISentrySystemInfo value) { }

	// RVA: 0x1C450C0 Offset: 0x1C442C0 VA: 0x181C450C0
	private void Awake() { }

	// RVA: 0x1C450D0 Offset: 0x1C442D0 VA: 0x181C450D0
	internal void CollectData() { }

	// RVA: 0x1C46430 Offset: 0x1C45630 VA: 0x181C46430
	public void .ctor() { }
}

// Namespace: Sentry.Unity
public abstract class SentryRuntimeOptionsConfiguration : ScriptableObject // TypeDefIndex: 16812
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Configure(SentryUnityOptions options);

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
public static class SentryUnity // TypeDefIndex: 16813
{
	// Fields
	[Nullable(2)]
	private static SentryUnitySdk UnitySdk; // 0x0

	// Methods

	// RVA: 0x1C49DA0 Offset: 0x1C48FA0 VA: 0x181C49DA0
	public static void Init(Action<SentryUnityOptions> sentryUnityOptionsConfigure) { }

	[EditorBrowsable(1)]
	// RVA: 0x1C49F00 Offset: 0x1C49100 VA: 0x181C49F00
	public static void Init(SentryUnityOptions options) { }

	[EditorBrowsable(1)]
	// RVA: 0x1C49D30 Offset: 0x1C48F30 VA: 0x181C49D30
	public static void Close() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SentryUnityOptions.<>c // TypeDefIndex: 16814
{
	// Fields
	[Nullable(0)]
	public static readonly SentryUnityOptions.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<char, bool> <>9__136_0; // 0x8

	// Methods

	// RVA: 0x1C4C590 Offset: 0x1C4B790 VA: 0x181C4C590
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C4B880 Offset: 0x1C4AA80 VA: 0x181C4B880
	internal bool <.ctor>b__136_0(char c) { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(1)]
public sealed class SentryUnityOptions : SentryOptions // TypeDefIndex: 16815
{
	// Fields
	public const string PackageName = "io.sentry.unity";
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; // 0x250
	[CompilerGenerated]
	private bool <AutoStartupTraces>k__BackingField; // 0x251
	[CompilerGenerated]
	private bool <AutoSceneLoadTraces>k__BackingField; // 0x252
	[CompilerGenerated]
	private bool <CaptureInEditor>k__BackingField; // 0x253
	[CompilerGenerated]
	private bool <EnableLogDebouncing>k__BackingField; // 0x254
	[CompilerGenerated]
	private TimeSpan <DebounceTimeLog>k__BackingField; // 0x258
	[CompilerGenerated]
	private TimeSpan <DebounceTimeWarning>k__BackingField; // 0x260
	[CompilerGenerated]
	private TimeSpan <DebounceTimeError>k__BackingField; // 0x268
	private CompressionLevelWithAuto _requestBodyCompressionLevel; // 0x270
	[CompilerGenerated]
	private bool <AttachScreenshot>k__BackingField; // 0x274
	[CompilerGenerated]
	private bool <AttachViewHierarchy>k__BackingField; // 0x275
	[CompilerGenerated]
	private int <MaxViewHierarchyRootObjects>k__BackingField; // 0x278
	[CompilerGenerated]
	private int <MaxViewHierarchyObjectChildCount>k__BackingField; // 0x27C
	[CompilerGenerated]
	private int <MaxViewHierarchyDepth>k__BackingField; // 0x280
	[CompilerGenerated]
	private ScreenshotQuality <ScreenshotQuality>k__BackingField; // 0x284
	[CompilerGenerated]
	private int <ScreenshotCompression>k__BackingField; // 0x288
	[CompilerGenerated]
	private Dictionary<LogType, bool> <AddBreadcrumbsForLogType>k__BackingField; // 0x290
	[CompilerGenerated]
	private TimeSpan <AnrTimeout>k__BackingField; // 0x298
	[CompilerGenerated]
	private bool <FilterBadGatewayExceptions>k__BackingField; // 0x2A0
	[CompilerGenerated]
	private bool <IosNativeSupportEnabled>k__BackingField; // 0x2A1
	[CompilerGenerated]
	private bool <AndroidNativeSupportEnabled>k__BackingField; // 0x2A2
	[CompilerGenerated]
	private bool <NdkIntegrationEnabled>k__BackingField; // 0x2A3
	[CompilerGenerated]
	private bool <NdkScopeSyncEnabled>k__BackingField; // 0x2A4
	[CompilerGenerated]
	private bool <WindowsNativeSupportEnabled>k__BackingField; // 0x2A5
	[CompilerGenerated]
	private bool <MacosNativeSupportEnabled>k__BackingField; // 0x2A6
	[CompilerGenerated]
	private bool <LinuxNativeSupportEnabled>k__BackingField; // 0x2A7
	[CompilerGenerated]
	private bool <Il2CppLineNumberSupportEnabled>k__BackingField; // 0x2A8
	[CompilerGenerated]
	private bool <PerformanceAutoInstrumentationEnabled>k__BackingField; // 0x2A9
	[CompilerGenerated]
	private StackTraceMode <StackTraceMode>k__BackingField; // 0x2AC
	[Nullable(2)]
	internal string _defaultUserId; // 0x2B0
	internal bool MultiThreading; // 0x2B8
	[Nullable(2)]
	[CompilerGenerated]
	private ContextWriter <NativeContextWriter>k__BackingField; // 0x2C0
	[Nullable(2)]
	[CompilerGenerated]
	private Action <NativeSupportCloseCallback>k__BackingField; // 0x2C8
	[CompilerGenerated]
	private List<string> <SdkIntegrationNames>k__BackingField; // 0x2D0

	// Properties
	public bool Enabled { get; set; }
	public bool AutoStartupTraces { get; set; }
	public bool AutoSceneLoadTraces { get; set; }
	public bool CaptureInEditor { get; set; }
	public bool EnableLogDebouncing { get; set; }
	public TimeSpan DebounceTimeLog { get; set; }
	public TimeSpan DebounceTimeWarning { get; set; }
	public TimeSpan DebounceTimeError { get; set; }
	public CompressionLevelWithAuto RequestBodyCompressionLevel { get; set; }
	public bool AttachScreenshot { get; set; }
	public bool AttachViewHierarchy { get; set; }
	public int MaxViewHierarchyRootObjects { get; set; }
	public int MaxViewHierarchyObjectChildCount { get; set; }
	public int MaxViewHierarchyDepth { get; set; }
	public ScreenshotQuality ScreenshotQuality { get; set; }
	public int ScreenshotCompression { get; set; }
	public Dictionary<LogType, bool> AddBreadcrumbsForLogType { get; set; }
	public TimeSpan AnrTimeout { get; set; }
	public bool FilterBadGatewayExceptions { get; set; }
	public bool IosNativeSupportEnabled { get; set; }
	public bool AndroidNativeSupportEnabled { get; set; }
	public bool NdkIntegrationEnabled { get; set; }
	public bool NdkScopeSyncEnabled { get; set; }
	public bool WindowsNativeSupportEnabled { get; set; }
	public bool MacosNativeSupportEnabled { get; set; }
	public bool LinuxNativeSupportEnabled { get; set; }
	public bool Il2CppLineNumberSupportEnabled { get; set; }
	public bool PerformanceAutoInstrumentationEnabled { get; set; }
	private StackTraceMode StackTraceMode { get; set; }
	[Nullable(2)]
	internal string DefaultUserId { get; set; }
	[Nullable(2)]
	internal ContextWriter NativeContextWriter { get; set; }
	[Nullable(2)]
	internal Action NativeSupportCloseCallback { get; set; }
	internal List<string> SdkIntegrationNames { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C48FD0 Offset: 0x1C481D0 VA: 0x181C48FD0
	public bool get_Enabled() { }

	[CompilerGenerated]
	// RVA: 0x1C49270 Offset: 0x1C48470 VA: 0x181C49270
	public void set_Enabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C48F60 Offset: 0x1C48160 VA: 0x181C48F60
	public bool get_AutoStartupTraces() { }

	[CompilerGenerated]
	// RVA: 0x1C49160 Offset: 0x1C48360 VA: 0x181C49160
	public void set_AutoStartupTraces(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C48F50 Offset: 0x1C48150 VA: 0x181C48F50
	public bool get_AutoSceneLoadTraces() { }

	[CompilerGenerated]
	// RVA: 0x1C49150 Offset: 0x1C48350 VA: 0x181C49150
	public void set_AutoSceneLoadTraces(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C48F70 Offset: 0x1C48170 VA: 0x181C48F70
	public bool get_CaptureInEditor() { }

	[CompilerGenerated]
	// RVA: 0x1C49170 Offset: 0x1C48370 VA: 0x181C49170
	public void set_CaptureInEditor(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C48FC0 Offset: 0x1C481C0 VA: 0x181C48FC0
	public bool get_EnableLogDebouncing() { }

	[CompilerGenerated]
	// RVA: 0x1C49260 Offset: 0x1C48460 VA: 0x181C49260
	public void set_EnableLogDebouncing(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C48F90 Offset: 0x1C48190 VA: 0x181C48F90
	public TimeSpan get_DebounceTimeLog() { }

	[CompilerGenerated]
	// RVA: 0x1C49190 Offset: 0x1C48390 VA: 0x181C49190
	public void set_DebounceTimeLog(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x1C48FA0 Offset: 0x1C481A0 VA: 0x181C48FA0
	public TimeSpan get_DebounceTimeWarning() { }

	[CompilerGenerated]
	// RVA: 0x1C491A0 Offset: 0x1C483A0 VA: 0x181C491A0
	public void set_DebounceTimeWarning(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x1C48F80 Offset: 0x1C48180 VA: 0x181C48F80
	public TimeSpan get_DebounceTimeError() { }

	[CompilerGenerated]
	// RVA: 0x1C49180 Offset: 0x1C48380 VA: 0x181C49180
	public void set_DebounceTimeError(TimeSpan value) { }

	// RVA: 0x1C490A0 Offset: 0x1C482A0 VA: 0x181C490A0
	public CompressionLevelWithAuto get_RequestBodyCompressionLevel() { }

	// RVA: 0x1C49350 Offset: 0x1C48550 VA: 0x181C49350
	public void set_RequestBodyCompressionLevel(CompressionLevelWithAuto value) { }

	[CompilerGenerated]
	// RVA: 0x1C48F30 Offset: 0x1C48130 VA: 0x181C48F30
	public bool get_AttachScreenshot() { }

	[CompilerGenerated]
	// RVA: 0x1C49130 Offset: 0x1C48330 VA: 0x181C49130
	public void set_AttachScreenshot(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C48F40 Offset: 0x1C48140 VA: 0x181C48F40
	public bool get_AttachViewHierarchy() { }

	[CompilerGenerated]
	// RVA: 0x1C49140 Offset: 0x1C48340 VA: 0x181C49140
	public void set_AttachViewHierarchy(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C49040 Offset: 0x1C48240 VA: 0x181C49040
	public int get_MaxViewHierarchyRootObjects() { }

	[CompilerGenerated]
	// RVA: 0x1C492F0 Offset: 0x1C484F0 VA: 0x181C492F0
	public void set_MaxViewHierarchyRootObjects(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C49030 Offset: 0x1C48230 VA: 0x181C49030
	public int get_MaxViewHierarchyObjectChildCount() { }

	[CompilerGenerated]
	// RVA: 0x1C492E0 Offset: 0x1C484E0 VA: 0x181C492E0
	public void set_MaxViewHierarchyObjectChildCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C49020 Offset: 0x1C48220 VA: 0x181C49020
	public int get_MaxViewHierarchyDepth() { }

	[CompilerGenerated]
	// RVA: 0x1C492D0 Offset: 0x1C484D0 VA: 0x181C492D0
	public void set_MaxViewHierarchyDepth(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C490C0 Offset: 0x1C482C0 VA: 0x181C490C0
	public ScreenshotQuality get_ScreenshotQuality() { }

	[CompilerGenerated]
	// RVA: 0x1C49380 Offset: 0x1C48580 VA: 0x181C49380
	public void set_ScreenshotQuality(ScreenshotQuality value) { }

	[CompilerGenerated]
	// RVA: 0x1C490B0 Offset: 0x1C482B0 VA: 0x181C490B0
	public int get_ScreenshotCompression() { }

	[CompilerGenerated]
	// RVA: 0x1C49370 Offset: 0x1C48570 VA: 0x181C49370
	public void set_ScreenshotCompression(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C48F00 Offset: 0x1C48100 VA: 0x181C48F00
	public Dictionary<LogType, bool> get_AddBreadcrumbsForLogType() { }

	[CompilerGenerated]
	// RVA: 0x1C49100 Offset: 0x1C48300 VA: 0x181C49100
	public void set_AddBreadcrumbsForLogType(Dictionary<LogType, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C48F20 Offset: 0x1C48120 VA: 0x181C48F20
	public TimeSpan get_AnrTimeout() { }

	[CompilerGenerated]
	// RVA: 0x1C49120 Offset: 0x1C48320 VA: 0x181C49120
	public void set_AnrTimeout(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x70C610 Offset: 0x70B810 VA: 0x18070C610
	public bool get_FilterBadGatewayExceptions() { }

	[CompilerGenerated]
	// RVA: 0x1C49280 Offset: 0x1C48480 VA: 0x181C49280
	public void set_FilterBadGatewayExceptions(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C48FF0 Offset: 0x1C481F0 VA: 0x181C48FF0
	public bool get_IosNativeSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C492A0 Offset: 0x1C484A0 VA: 0x181C492A0
	public void set_IosNativeSupportEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C48F10 Offset: 0x1C48110 VA: 0x181C48F10
	public bool get_AndroidNativeSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C49110 Offset: 0x1C48310 VA: 0x181C49110
	public void set_AndroidNativeSupportEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C49070 Offset: 0x1C48270 VA: 0x181C49070
	public bool get_NdkIntegrationEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C49320 Offset: 0x1C48520 VA: 0x181C49320
	public void set_NdkIntegrationEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C49080 Offset: 0x1C48280 VA: 0x181C49080
	public bool get_NdkScopeSyncEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C49330 Offset: 0x1C48530 VA: 0x181C49330
	public void set_NdkScopeSyncEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C490F0 Offset: 0x1C482F0 VA: 0x181C490F0
	public bool get_WindowsNativeSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C493B0 Offset: 0x1C485B0 VA: 0x181C493B0
	public void set_WindowsNativeSupportEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C49010 Offset: 0x1C48210 VA: 0x181C49010
	public bool get_MacosNativeSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C492C0 Offset: 0x1C484C0 VA: 0x181C492C0
	public void set_MacosNativeSupportEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C49000 Offset: 0x1C48200 VA: 0x181C49000
	public bool get_LinuxNativeSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C492B0 Offset: 0x1C484B0 VA: 0x181C492B0
	public void set_LinuxNativeSupportEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C48FE0 Offset: 0x1C481E0 VA: 0x181C48FE0
	public bool get_Il2CppLineNumberSupportEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C49290 Offset: 0x1C48490 VA: 0x181C49290
	public void set_Il2CppLineNumberSupportEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C49090 Offset: 0x1C48290 VA: 0x181C49090
	public bool get_PerformanceAutoInstrumentationEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1C49340 Offset: 0x1C48540 VA: 0x181C49340
	public void set_PerformanceAutoInstrumentationEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C490E0 Offset: 0x1C482E0 VA: 0x181C490E0
	private StackTraceMode get_StackTraceMode() { }

	[CompilerGenerated]
	// RVA: 0x1C493A0 Offset: 0x1C485A0 VA: 0x181C493A0
	private void set_StackTraceMode(StackTraceMode value) { }

	[NullableContext(2)]
	// RVA: 0x1C48FB0 Offset: 0x1C481B0 VA: 0x181C48FB0
	internal string get_DefaultUserId() { }

	[NullableContext(2)]
	// RVA: 0x1C491B0 Offset: 0x1C483B0 VA: 0x181C491B0
	internal void set_DefaultUserId(string value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x1C49050 Offset: 0x1C48250 VA: 0x181C49050
	internal ContextWriter get_NativeContextWriter() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x1C49300 Offset: 0x1C48500 VA: 0x181C49300
	internal void set_NativeContextWriter(ContextWriter value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x1C49060 Offset: 0x1C48260 VA: 0x181C49060
	internal Action get_NativeSupportCloseCallback() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C49310 Offset: 0x1C48510 VA: 0x181C49310
	internal void set_NativeSupportCloseCallback(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1C490D0 Offset: 0x1C482D0 VA: 0x181C490D0
	internal List<string> get_SdkIntegrationNames() { }

	[CompilerGenerated]
	// RVA: 0x1C49390 Offset: 0x1C48590 VA: 0x181C49390
	internal void set_SdkIntegrationNames(List<string> value) { }

	// RVA: 0x1C485D0 Offset: 0x1C477D0 VA: 0x181C485D0
	public void .ctor() { }

	// RVA: 0x1C48580 Offset: 0x1C47780 VA: 0x181C48580
	internal void .ctor(bool isBuilding, IApplication application) { }

	// RVA: 0x1C48650 Offset: 0x1C47850 VA: 0x181C48650
	internal void .ctor(SentryMonoBehaviour behaviour, IApplication application, bool isBuilding) { }

	// RVA: 0x1C483A0 Offset: 0x1C475A0 VA: 0x181C483A0 Slot: 3
	public override string ToString() { }
}

// Namespace: Sentry.Unity
public enum CompressionLevelWithAuto // TypeDefIndex: 16816
{
	// Fields
	public int value__; // 0x0
	public const CompressionLevelWithAuto Auto = -1;
	public const CompressionLevelWithAuto Optimal = 0;
	public const CompressionLevelWithAuto Fastest = 1;
	public const CompressionLevelWithAuto NoCompression = 2;
}

// Namespace: Sentry.Unity
public enum ScreenshotQuality // TypeDefIndex: 16817
{
	// Fields
	public int value__; // 0x0
	public const ScreenshotQuality Full = 0;
	public const ScreenshotQuality High = 1;
	public const ScreenshotQuality Medium = 2;
	public const ScreenshotQuality Low = 3;
}

// Namespace: Sentry.Unity
[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class SentryUnityOptionsExtensions // TypeDefIndex: 16818
{
	// Methods

	[Extension]
	[NullableContext(2)]
	// RVA: 0x1C480A0 Offset: 0x1C472A0 VA: 0x181C480A0
	public static bool ShouldInitializeSdk(SentryUnityOptions options) { }

	[NullableContext(2)]
	[Extension]
	// RVA: 0x1C48210 Offset: 0x1C47410 VA: 0x181C48210
	internal static bool ShouldInitializeSdk(SentryUnityOptions options, IApplication application) { }

	[Extension]
	// RVA: 0x1C47E80 Offset: 0x1C47080 VA: 0x181C47E80
	internal static bool IsValid(SentryUnityOptions options) { }

	[Extension]
	// RVA: 0x1C47F40 Offset: 0x1C47140 VA: 0x181C47F40
	internal static void SetupLogging(SentryUnityOptions options) { }

	[Extension]
	// RVA: 0x1C47B90 Offset: 0x1C46D90 VA: 0x181C47B90
	internal static void AddIl2CppExceptionProcessor(SentryUnityOptions options, ISentryUnityInfo unityInfo) { }

	[Extension]
	// RVA: 0x1C47E00 Offset: 0x1C47000 VA: 0x181C47E00
	public static void DisableUnityApplicationLoggingIntegration(SentryUnityOptions options) { }

	[Extension]
	// RVA: 0x1C47D40 Offset: 0x1C46F40 VA: 0x181C47D40
	public static void DisableAnrIntegration(SentryUnityOptions options) { }

	[Extension]
	// RVA: 0x1C47D80 Offset: 0x1C46F80 VA: 0x181C47D80
	public static void DisableBadGatewayExceptionFilter(SentryUnityOptions options) { }

	[Extension]
	// RVA: 0x1C47E40 Offset: 0x1C47040 VA: 0x181C47E40
	public static void DisableWebExceptionFilter(SentryUnityOptions options) { }

	[Extension]
	// RVA: 0x1C47DC0 Offset: 0x1C46FC0 VA: 0x181C47DC0
	public static void DisableSocketExceptionFilter(SentryUnityOptions options) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SentryUnitySdk.<>c__DisplayClass4_0 // TypeDefIndex: 16819
{
	// Fields
	[Nullable(0)]
	public SentryUnityOptions options; // 0x10
	[Nullable(0)]
	public ContextWriter contextWriter; // 0x18
	[Nullable(0)]
	public Action<Task> <>9__4; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C4C020 Offset: 0x1C4B220 VA: 0x181C4C020
	internal void <Init>b__0(Scope s) { }

	// RVA: 0x1C4C120 Offset: 0x1C4B320 VA: 0x181C4C120
	internal void <Init>b__1(Scope s) { }

	// RVA: 0x1C4C1E0 Offset: 0x1C4B3E0 VA: 0x181C4C1E0
	internal void <Init>b__2(Scope scope) { }

	[NullableContext(0)]
	// RVA: 0x1C4C320 Offset: 0x1C4B520 VA: 0x181C4C320
	internal void <Init>b__4(Task t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SentryUnitySdk.<>c__DisplayClass4_1 // TypeDefIndex: 16820
{
	// Fields
	[Nullable(0)]
	public Scope scope; // 0x10
	[Nullable(0)]
	public SentryUnitySdk.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C4C3E0 Offset: 0x1C4B5E0 VA: 0x181C4C3E0
	internal void <Init>b__3() { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
internal class SentryUnitySdk // TypeDefIndex: 16821
{
	// Fields
	private readonly SentryUnityOptions _options; // 0x10
	private IDisposable _dotnetSdk; // 0x18
	[Nullable(2)]
	private FileStream _lockFile; // 0x20

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	private void .ctor(SentryUnityOptions options) { }

	// RVA: 0x1C49710 Offset: 0x1C48910 VA: 0x181C49710
	internal static SentryUnitySdk Init(SentryUnityOptions options) { }

	// RVA: 0x1C493C0 Offset: 0x1C485C0 VA: 0x181C493C0
	public void Close() { }
}

// Namespace: Sentry.Unity
[NullableContext(2)]
internal interface ISentrySystemInfo // TypeDefIndex: 16822
{
	// Properties
	public abstract Nullable<int> MainThreadId { get; }
	public abstract string OperatingSystem { get; }
	public abstract Nullable<int> ProcessorCount { get; }
	public abstract Nullable<bool> SupportsVibration { get; }
	[Nullable(new[] { 2, 1 })]
	public abstract Lazy<string> DeviceType { get; }
	public abstract string CpuDescription { get; }
	public abstract string DeviceName { get; }
	[Nullable(new[] { 2, 1 })]
	public abstract Lazy<string> DeviceUniqueIdentifier { get; }
	[Nullable(new[] { 2, 1 })]
	public abstract Lazy<string> DeviceModel { get; }
	public abstract Nullable<int> SystemMemorySize { get; }
	public abstract Nullable<int> GraphicsDeviceId { get; }
	public abstract string GraphicsDeviceName { get; }
	[Nullable(new[] { 2, 1 })]
	public abstract Lazy<string> GraphicsDeviceVendorId { get; }
	public abstract string GraphicsDeviceVendor { get; }
	public abstract Nullable<int> GraphicsMemorySize { get; }
	public abstract Lazy<bool> GraphicsMultiThreaded { get; }
	public abstract string NpotSupport { get; }
	public abstract string GraphicsDeviceVersion { get; }
	public abstract string GraphicsDeviceType { get; }
	public abstract Nullable<int> MaxTextureSize { get; }
	public abstract Nullable<bool> SupportsDrawCallInstancing { get; }
	public abstract Nullable<bool> SupportsRayTracing { get; }
	public abstract Nullable<bool> SupportsComputeShaders { get; }
	public abstract Nullable<bool> SupportsGeometryShaders { get; }
	public abstract Nullable<int> GraphicsShaderLevel { get; }
	public abstract Nullable<bool> GraphicsUVStartsAtTop { get; }
	public abstract Lazy<bool> IsDebugBuild { get; }
	public abstract string EditorVersion { get; }
	public abstract string InstallMode { get; }
	[Nullable(new[] { 2, 1 })]
	public abstract Lazy<string> TargetFrameRate { get; }
	[Nullable(new[] { 2, 1 })]
	public abstract Lazy<string> CopyTextureSupport { get; }
	[Nullable(new[] { 2, 1 })]
	public abstract Lazy<string> RenderingThreadingMode { get; }
	public abstract Lazy<DateTimeOffset> StartTime { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Nullable<int> get_MainThreadId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_OperatingSystem();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Nullable<int> get_ProcessorCount();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Nullable<bool> get_SupportsVibration();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Lazy<string> get_DeviceType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_CpuDescription();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_DeviceName();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Lazy<string> get_DeviceUniqueIdentifier();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Lazy<string> get_DeviceModel();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Nullable<int> get_SystemMemorySize();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Nullable<int> get_GraphicsDeviceId();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_GraphicsDeviceName();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Lazy<string> get_GraphicsDeviceVendorId();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_GraphicsDeviceVendor();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Nullable<int> get_GraphicsMemorySize();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Lazy<bool> get_GraphicsMultiThreaded();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string get_NpotSupport();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract string get_GraphicsDeviceVersion();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract string get_GraphicsDeviceType();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Nullable<int> get_MaxTextureSize();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Nullable<bool> get_SupportsDrawCallInstancing();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract Nullable<bool> get_SupportsRayTracing();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Nullable<bool> get_SupportsComputeShaders();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract Nullable<bool> get_SupportsGeometryShaders();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Nullable<int> get_GraphicsShaderLevel();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Nullable<bool> get_GraphicsUVStartsAtTop();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract Lazy<bool> get_IsDebugBuild();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_EditorVersion();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract string get_InstallMode();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract Lazy<string> get_TargetFrameRate();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Lazy<string> get_CopyTextureSupport();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract Lazy<string> get_RenderingThreadingMode();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract Lazy<DateTimeOffset> get_StartTime();
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SentrySystemInfoAdapter.<>c // TypeDefIndex: 16823
{
	// Fields
	[Nullable(0)]
	public static readonly SentrySystemInfoAdapter.<>c <>9; // 0x0
	[Nullable(new[] { 0, 1 })]
	public static Func<string> <>9__11_0; // 0x8
	[Nullable(new[] { 0, 1 })]
	public static Func<string> <>9__17_0; // 0x10
	[Nullable(new[] { 0, 1 })]
	public static Func<string> <>9__19_0; // 0x18
	[Nullable(new[] { 0, 1 })]
	public static Func<string> <>9__27_0; // 0x20
	[Nullable(0)]
	public static Func<bool> <>9__33_0; // 0x28
	[Nullable(0)]
	public static Func<bool> <>9__55_0; // 0x30
	[Nullable(new[] { 0, 1 })]
	public static Func<string> <>9__61_0; // 0x38
	[Nullable(new[] { 0, 1 })]
	public static Func<string> <>9__63_0; // 0x40
	[Nullable(new[] { 0, 1 })]
	public static Func<string> <>9__65_0; // 0x48
	[Nullable(0)]
	public static Func<DateTimeOffset> <>9__67_0; // 0x50

	// Methods

	// RVA: 0x1C4C650 Offset: 0x1C4B850 VA: 0x181C4C650
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x1C4B900 Offset: 0x1C4AB00 VA: 0x181C4B900
	internal string <get_DeviceType>b__11_0() { }

	[NullableContext(1)]
	// RVA: 0x1C4B960 Offset: 0x1C4AB60 VA: 0x181C4B960
	internal string <get_DeviceUniqueIdentifier>b__17_0() { }

	[NullableContext(1)]
	// RVA: 0x1C4B8F0 Offset: 0x1C4AAF0 VA: 0x181C4B8F0
	internal string <get_DeviceModel>b__19_0() { }

	[NullableContext(1)]
	// RVA: 0x1C4B970 Offset: 0x1C4AB70 VA: 0x181C4B970
	internal string <get_GraphicsDeviceVendorId>b__27_0() { }

	// RVA: 0x1C4B990 Offset: 0x1C4AB90 VA: 0x181C4B990
	internal bool <get_GraphicsMultiThreaded>b__33_0() { }

	// RVA: 0x1C4B9A0 Offset: 0x1C4ABA0 VA: 0x181C4B9A0
	internal bool <get_IsDebugBuild>b__55_0() { }

	[NullableContext(1)]
	// RVA: 0x1C4BAD0 Offset: 0x1C4ACD0 VA: 0x181C4BAD0
	internal string <get_TargetFrameRate>b__61_0() { }

	[NullableContext(1)]
	// RVA: 0x1C4B890 Offset: 0x1C4AA90 VA: 0x181C4B890
	internal string <get_CopyTextureSupport>b__63_0() { }

	[NullableContext(1)]
	// RVA: 0x1C4B9E0 Offset: 0x1C4ABE0 VA: 0x181C4B9E0
	internal string <get_RenderingThreadingMode>b__65_0() { }

	// RVA: 0x1C4BA40 Offset: 0x1C4AC40 VA: 0x181C4BA40
	internal DateTimeOffset <get_StartTime>b__67_0() { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(2)]
internal sealed class SentrySystemInfoAdapter : ISentrySystemInfo // TypeDefIndex: 16824
{
	// Fields
	[Nullable(1)]
	public static readonly SentrySystemInfoAdapter Instance; // 0x0

	// Properties
	public Nullable<int> MainThreadId { get; }
	public string OperatingSystem { get; }
	public Nullable<int> ProcessorCount { get; }
	public Nullable<bool> SupportsVibration { get; }
	[Nullable(new[] { 2, 1 })]
	public Lazy<string> DeviceType { get; }
	public string CpuDescription { get; }
	public string DeviceName { get; }
	[Nullable(1)]
	public Lazy<string> DeviceUniqueIdentifier { get; }
	[Nullable(1)]
	public Lazy<string> DeviceModel { get; }
	public Nullable<int> SystemMemorySize { get; }
	public Nullable<int> GraphicsDeviceId { get; }
	public string GraphicsDeviceName { get; }
	[Nullable(new[] { 2, 1 })]
	public Lazy<string> GraphicsDeviceVendorId { get; }
	public string GraphicsDeviceVendor { get; }
	public Nullable<int> GraphicsMemorySize { get; }
	public Lazy<bool> GraphicsMultiThreaded { get; }
	public string NpotSupport { get; }
	public string GraphicsDeviceVersion { get; }
	public string GraphicsDeviceType { get; }
	public Nullable<int> MaxTextureSize { get; }
	public Nullable<bool> SupportsDrawCallInstancing { get; }
	public Nullable<bool> SupportsRayTracing { get; }
	public Nullable<bool> SupportsComputeShaders { get; }
	public Nullable<bool> SupportsGeometryShaders { get; }
	public Nullable<int> GraphicsShaderLevel { get; }
	public Nullable<bool> GraphicsUVStartsAtTop { get; }
	[Nullable(1)]
	public Lazy<bool> IsDebugBuild { get; }
	public string EditorVersion { get; }
	public string InstallMode { get; }
	[Nullable(1)]
	public Lazy<string> TargetFrameRate { get; }
	[Nullable(1)]
	public Lazy<string> CopyTextureSupport { get; }
	[Nullable(1)]
	public Lazy<string> RenderingThreadingMode { get; }
	public Lazy<DateTimeOffset> StartTime { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1C47500 Offset: 0x1C46700 VA: 0x181C47500 Slot: 4
	public Nullable<int> get_MainThreadId() { }

	// RVA: 0x1C47620 Offset: 0x1C46820 VA: 0x181C47620 Slot: 5
	public string get_OperatingSystem() { }

	// RVA: 0x1C47630 Offset: 0x1C46830 VA: 0x181C47630 Slot: 6
	public Nullable<int> get_ProcessorCount() { }

	// RVA: 0x1C479E0 Offset: 0x1C46BE0 VA: 0x181C479E0 Slot: 7
	public Nullable<bool> get_SupportsVibration() { }

	// RVA: 0x1C46D20 Offset: 0x1C45F20 VA: 0x181C46D20 Slot: 8
	public Lazy<string> get_DeviceType() { }

	// RVA: 0x1C46A60 Offset: 0x1C45C60 VA: 0x181C46A60 Slot: 9
	public string get_CpuDescription() { }

	// RVA: 0x1C46B80 Offset: 0x1C45D80 VA: 0x181C46B80 Slot: 10
	public string get_DeviceName() { }

	[NullableContext(1)]
	// RVA: 0x1C46E30 Offset: 0x1C46030 VA: 0x181C46E30 Slot: 11
	public Lazy<string> get_DeviceUniqueIdentifier() { }

	[NullableContext(1)]
	// RVA: 0x1C46A70 Offset: 0x1C45C70 VA: 0x181C46A70 Slot: 12
	public Lazy<string> get_DeviceModel() { }

	// RVA: 0x1C47A30 Offset: 0x1C46C30 VA: 0x181C47A30 Slot: 13
	public Nullable<int> get_SystemMemorySize() { }

	// RVA: 0x1C46F80 Offset: 0x1C46180 VA: 0x181C46F80 Slot: 14
	public Nullable<int> get_GraphicsDeviceId() { }

	// RVA: 0x1C46FD0 Offset: 0x1C461D0 VA: 0x181C46FD0 Slot: 15
	public string get_GraphicsDeviceName() { }

	// RVA: 0x1C47040 Offset: 0x1C46240 VA: 0x181C47040 Slot: 16
	public Lazy<string> get_GraphicsDeviceVendorId() { }

	// RVA: 0x1C47150 Offset: 0x1C46350 VA: 0x181C47150 Slot: 17
	public string get_GraphicsDeviceVendor() { }

	// RVA: 0x1C47170 Offset: 0x1C46370 VA: 0x181C47170 Slot: 18
	public Nullable<int> get_GraphicsMemorySize() { }

	// RVA: 0x1C471C0 Offset: 0x1C463C0 VA: 0x181C471C0 Slot: 19
	public Lazy<bool> get_GraphicsMultiThreaded() { }

	// RVA: 0x1C475C0 Offset: 0x1C467C0 VA: 0x181C475C0 Slot: 20
	public string get_NpotSupport() { }

	// RVA: 0x1C47160 Offset: 0x1C46360 VA: 0x181C47160 Slot: 21
	public string get_GraphicsDeviceVersion() { }

	// RVA: 0x1C46FE0 Offset: 0x1C461E0 VA: 0x181C46FE0 Slot: 22
	public string get_GraphicsDeviceType() { }

	// RVA: 0x1C47570 Offset: 0x1C46770 VA: 0x181C47570 Slot: 23
	public Nullable<int> get_MaxTextureSize() { }

	// RVA: 0x1C478F0 Offset: 0x1C46AF0 VA: 0x181C478F0 Slot: 24
	public Nullable<bool> get_SupportsDrawCallInstancing() { }

	// RVA: 0x1C47990 Offset: 0x1C46B90 VA: 0x181C47990 Slot: 25
	public Nullable<bool> get_SupportsRayTracing() { }

	// RVA: 0x1C478A0 Offset: 0x1C46AA0 VA: 0x181C478A0 Slot: 26
	public Nullable<bool> get_SupportsComputeShaders() { }

	// RVA: 0x1C47940 Offset: 0x1C46B40 VA: 0x181C47940 Slot: 27
	public Nullable<bool> get_SupportsGeometryShaders() { }

	// RVA: 0x1C472D0 Offset: 0x1C464D0 VA: 0x181C472D0 Slot: 28
	public Nullable<int> get_GraphicsShaderLevel() { }

	// RVA: 0x1C47320 Offset: 0x1C46520 VA: 0x181C47320 Slot: 29
	public Nullable<bool> get_GraphicsUVStartsAtTop() { }

	[NullableContext(1)]
	// RVA: 0x1C473F0 Offset: 0x1C465F0 VA: 0x181C473F0 Slot: 30
	public Lazy<bool> get_IsDebugBuild() { }

	// RVA: 0x1C46F40 Offset: 0x1C46140 VA: 0x181C46F40 Slot: 31
	public string get_EditorVersion() { }

	// RVA: 0x1C47370 Offset: 0x1C46570 VA: 0x181C47370 Slot: 32
	public string get_InstallMode() { }

	[NullableContext(1)]
	// RVA: 0x1C47A80 Offset: 0x1C46C80 VA: 0x181C47A80 Slot: 33
	public Lazy<string> get_TargetFrameRate() { }

	[NullableContext(1)]
	// RVA: 0x1C46950 Offset: 0x1C45B50 VA: 0x181C46950 Slot: 34
	public Lazy<string> get_CopyTextureSupport() { }

	[NullableContext(1)]
	// RVA: 0x1C47680 Offset: 0x1C46880 VA: 0x181C47680 Slot: 35
	public Lazy<string> get_RenderingThreadingMode() { }

	// RVA: 0x1C47790 Offset: 0x1C46990 VA: 0x181C47790 Slot: 36
	public Lazy<DateTimeOffset> get_StartTime() { }

	// RVA: 0x1C468F0 Offset: 0x1C45AF0 VA: 0x181C468F0
	private static void .cctor() { }
}

// Namespace: Sentry.Unity
public interface IUnityLogMessageDebounce // TypeDefIndex: 16825
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Debounced();
}

// Namespace: Sentry.Unity
internal class TimeDebounceBase : IUnityLogMessageDebounce // TypeDefIndex: 16826
{
	// Fields
	protected TimeSpan DebounceOffset; // 0x10
	private Nullable<DateTimeOffset> _barrierOffset; // 0x18

	// Properties
	private static DateTimeOffset Now { get; }

	// Methods

	// RVA: 0x1C4A580 Offset: 0x1C49780 VA: 0x181C4A580
	private static DateTimeOffset get_Now() { }

	// RVA: 0x1C4A3A0 Offset: 0x1C495A0 VA: 0x181C4A3A0 Slot: 4
	public bool Debounced() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Unity
internal sealed class LogTimeDebounce : TimeDebounceBase // TypeDefIndex: 16827
{
	// Methods

	// RVA: 0x19B4B90 Offset: 0x19B3D90 VA: 0x1819B4B90
	public void .ctor(TimeSpan debounceOffset) { }
}

// Namespace: Sentry.Unity
internal sealed class ErrorTimeDebounce : TimeDebounceBase // TypeDefIndex: 16828
{
	// Methods

	// RVA: 0x19B4B90 Offset: 0x19B3D90 VA: 0x1819B4B90
	public void .ctor(TimeSpan debounceOffset) { }
}

// Namespace: Sentry.Unity
internal sealed class WarningTimeDebounce : TimeDebounceBase // TypeDefIndex: 16829
{
	// Methods

	// RVA: 0x19B4B90 Offset: 0x19B3D90 VA: 0x1819B4B90
	public void .ctor(TimeSpan debounceOffset) { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(1)]
internal class UnityEventProcessor : ISentryEventProcessor, ISentryTransactionProcessor // TypeDefIndex: 16830
{
	// Fields
	private readonly SentryUnityOptions _sentryOptions; // 0x10
	private readonly MainThreadData _mainThreadData; // 0x18

	// Methods

	// RVA: 0x1C4D320 Offset: 0x1C4C520 VA: 0x181C4D320
	public void .ctor(SentryUnityOptions sentryOptions, SentryMonoBehaviour sentryMonoBehaviour) { }

	// RVA: 0x1C4CEA0 Offset: 0x1C4C0A0 VA: 0x181C4CEA0 Slot: 5
	public Transaction Process(Transaction transaction) { }

	// RVA: 0x1C4CEC0 Offset: 0x1C4C0C0 VA: 0x181C4CEC0 Slot: 4
	public SentryEvent Process(SentryEvent event) { }

	// RVA: 0x1C4CEF0 Offset: 0x1C4C0F0 VA: 0x181C4CEF0
	private void SetEventContext(IEventLike sentryEvent) { }

	// RVA: 0x1C4CC20 Offset: 0x1C4BE20 VA: 0x181C4CC20
	private void PopulateDevice(Device device) { }

	// RVA: 0x1C4CD70 Offset: 0x1C4BF70 VA: 0x181C4CD70
	private void PopulateSdkIntegrations(SdkVersion sdkVersion) { }
}

// Namespace: Sentry.Unity
[Extension]
internal static class TagValueNormalizer // TypeDefIndex: 16831
{
	// Methods

	[Extension]
	[NullableContext(1)]
	// RVA: 0x1C4A350 Offset: 0x1C49550 VA: 0x181C4A350
	internal static string ToTagValue(bool value) { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(1)]
public class UnityLogger : IDiagnosticLogger // TypeDefIndex: 16832
{
	// Fields
	public const string LogTag = "Sentry";
	private readonly SentryOptions _sentryOptions; // 0x10
	private readonly ILogger _logger; // 0x18

	// Methods

	// RVA: 0x1C4F7A0 Offset: 0x1C4E9A0 VA: 0x181C4F7A0 Slot: 4
	public bool IsEnabled(SentryLevel level) { }

	// RVA: 0x1C4FA30 Offset: 0x1C4EC30 VA: 0x181C4FA30
	public void .ctor(SentryUnityOptions sentryUnityOptions) { }

	// RVA: 0x1C4F960 Offset: 0x1C4EB60 VA: 0x181C4F960
	internal void .ctor(SentryOptions sentryOptions, ILogger logger) { }

	[NullableContext(2)]
	// RVA: 0x1C4F7D0 Offset: 0x1C4E9D0 VA: 0x181C4F7D0 Slot: 5
	public void Log(SentryLevel logLevel, string message, Exception exception, object[] args) { }

	// RVA: 0x1C4F770 Offset: 0x1C4E970 VA: 0x181C4F770
	internal static LogType GetUnityLogType(SentryLevel logLevel) { }

	// RVA: 0x1C4F930 Offset: 0x1C4EB30 VA: 0x181C4F930 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UnityViewHierarchyAttachmentContent.<>c // TypeDefIndex: 16833
{
	// Fields
	[Nullable(0)]
	public static readonly UnityViewHierarchyAttachmentContent.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<Component, string> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x1C4C470 Offset: 0x1C4B670 VA: 0x181C4C470
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1C4B010 Offset: 0x1C4A210 VA: 0x181C4B010
	internal string <CreateNode>b__6_0(Component e) { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(1)]
internal class UnityViewHierarchyAttachmentContent : IAttachmentContent // TypeDefIndex: 16834
{
	// Fields
	private readonly SentryMonoBehaviour _behaviour; // 0x10
	private readonly SentryUnityOptions _options; // 0x18

	// Methods

	// RVA: 0x161DA80 Offset: 0x161CC80 VA: 0x18161DA80
	public void .ctor(SentryUnityOptions options, SentryMonoBehaviour behaviour) { }

	// RVA: 0x1C516C0 Offset: 0x1C508C0 VA: 0x181C516C0 Slot: 4
	public Stream GetStream() { }

	// RVA: 0x1C50E00 Offset: 0x1C50000 VA: 0x181C50E00
	internal Stream CaptureViewHierarchy() { }

	// RVA: 0x1C51450 Offset: 0x1C50650 VA: 0x181C51450
	internal ViewHierarchy CreateViewHierarchy(int maxRootGameObjectCount, int maxChildCount, int maxDepth) { }

	// RVA: 0x1C50FF0 Offset: 0x1C501F0 VA: 0x181C50FF0
	internal void CreateNode(int remainingDepth, int maxChildCount, ViewHierarchyNode parentNode, Transform transform) { }
}

// Namespace: Sentry.Unity
[Nullable(0)]
[NullableContext(2)]
internal class UnityViewHierarchyNode : ViewHierarchyNode // TypeDefIndex: 16835
{
	// Fields
	[CompilerGenerated]
	private string <Tag>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Rotation>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Scale>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<bool> <Active>k__BackingField; // 0x40
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private List<string> <Extras>k__BackingField; // 0x48

	// Properties
	public string Tag { get; set; }
	public string Position { get; set; }
	public string Rotation { get; set; }
	public string Scale { get; set; }
	public Nullable<bool> Active { get; set; }
	[Nullable(new[] { 2, 1 })]
	public List<string> Extras { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Tag() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Tag(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Position() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Position(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Rotation(string value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Scale() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Scale(string value) { }

	[CompilerGenerated]
	// RVA: 0x8CA290 Offset: 0x8C9490 VA: 0x1808CA290
	public Nullable<bool> get_Active() { }

	[CompilerGenerated]
	// RVA: 0x1C51A50 Offset: 0x1C50C50 VA: 0x181C51A50
	public void set_Active(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public List<string> get_Extras() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_Extras(List<string> value) { }

	[NullableContext(1)]
	// RVA: 0x1C51A40 Offset: 0x1C50C40 VA: 0x181C51A40
	public void .ctor(string name) { }

	[NullableContext(1)]
	// RVA: 0x1C51780 Offset: 0x1C50980 VA: 0x181C51780 Slot: 5
	protected override void WriteAdditionalProperties(Utf8JsonWriter writer, IDiagnosticLogger logger) { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
internal class WebBackgroundWorker : IBackgroundWorker // TypeDefIndex: 16836
{
	// Fields
	private readonly SentryMonoBehaviour _behaviour; // 0x10
	private readonly UnityWebRequestTransport _transport; // 0x18
	[CompilerGenerated]
	private readonly int <QueuedItems>k__BackingField; // 0x20

	// Properties
	public int QueuedItems { get; }

	// Methods

	// RVA: 0x1C52CC0 Offset: 0x1C51EC0 VA: 0x181C52CC0
	public void .ctor(SentryUnityOptions options, SentryMonoBehaviour behaviour) { }

	// RVA: 0x1C52B90 Offset: 0x1C51D90 VA: 0x181C52B90 Slot: 4
	public bool EnqueueEnvelope(Envelope envelope) { }

	// RVA: 0x1C52C30 Offset: 0x1C51E30 VA: 0x181C52C30 Slot: 5
	public Task FlushAsync(TimeSpan timeout) { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 6
	public int get_QueuedItems() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityWebRequestTransport.<SendEnvelopeAsync>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 16837
{
	// Fields
	private int <>1__state; // 0x10
	[Nullable(0)]
	private object <>2__current; // 0x18
	[Nullable(0)]
	public UnityWebRequestTransport <>4__this; // 0x20
	[Nullable(0)]
	public Envelope envelope; // 0x28
	[Nullable(0)]
	private Envelope <processedEnvelope>5__2; // 0x30
	[Nullable(0)]
	private UnityWebRequest <www>5__3; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1C4AEE0 Offset: 0x1C4A0E0 VA: 0x181C4AEE0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1C4AC90 Offset: 0x1C49E90 VA: 0x181C4AC90 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1C4AF70 Offset: 0x1C4A170 VA: 0x181C4AF70
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1C4AEA0 Offset: 0x1C4A0A0 VA: 0x181C4AEA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Sentry.Unity
[NullableContext(1)]
[Nullable(0)]
internal class UnityWebRequestTransport : HttpTransportBase // TypeDefIndex: 16838
{
	// Fields
	private readonly SentryUnityOptions _options; // 0x38

	// Methods

	// RVA: 0x1C52360 Offset: 0x1C51560 VA: 0x181C52360
	public void .ctor(SentryUnityOptions options) { }

	[IteratorStateMachine(typeof(UnityWebRequestTransport.<SendEnvelopeAsync>d__2))]
	// RVA: 0x1C522F0 Offset: 0x1C514F0 VA: 0x181C522F0
	internal IEnumerator SendEnvelopeAsync(Envelope envelope) { }

	// RVA: 0x1C51B40 Offset: 0x1C50D40 VA: 0x181C51B40
	private UnityWebRequest CreateWebRequest(HttpRequestMessage message) { }

	// RVA: 0x1C51FD0 Offset: 0x1C511D0 VA: 0x181C51FD0
	private HttpResponseMessage GetResponse(UnityWebRequest www) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SentryWebGL.<>c // TypeDefIndex: 16839
{
	// Fields
	public static readonly SentryWebGL.<>c <>9; // 0x0
	public static Func<bool> <>9__0_0; // 0x8

	// Methods

	// RVA: 0x1C4C5F0 Offset: 0x1C4B7F0 VA: 0x181C4C5F0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal bool <Configure>b__0_0() { }
}

// Namespace: Sentry.Unity.WebGL
public static class SentryWebGL // TypeDefIndex: 16840
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1C49FA0 Offset: 0x1C491A0 VA: 0x181C49FA0
	public static void Configure(SentryUnityOptions options) { }
}

// Namespace: Sentry.Unity.Protocol
[NullableContext(2)]
[Nullable(0)]
public sealed class Unity : IJsonSerializable // TypeDefIndex: 16841
{
	// Fields
	[Nullable(1)]
	public const string Type = "unity";
	[CompilerGenerated]
	private string <EditorVersion>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <InstallMode>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <CopyTextureSupport>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <RenderingThreadingMode>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <TargetFrameRate>k__BackingField; // 0x30

	// Properties
	public string EditorVersion { get; set; }
	public string InstallMode { get; set; }
	public string CopyTextureSupport { get; set; }
	public string RenderingThreadingMode { get; set; }
	public string TargetFrameRate { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_EditorVersion() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_EditorVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_InstallMode() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_InstallMode(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_CopyTextureSupport() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_CopyTextureSupport(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_RenderingThreadingMode() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_RenderingThreadingMode(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_TargetFrameRate() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_TargetFrameRate(string value) { }

	[NullableContext(1)]
	// RVA: 0x1C523A0 Offset: 0x1C515A0 VA: 0x181C523A0
	internal Unity Clone() { }

	[NullableContext(1)]
	// RVA: 0x1C52A10 Offset: 0x1C51C10 VA: 0x181C52A10 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	[NullableContext(1)]
	// RVA: 0x1C52420 Offset: 0x1C51620 VA: 0x181C52420
	public static Unity FromJson(JsonElement json) { }

	[NullableContext(1)]
	// RVA: 0x1C526A0 Offset: 0x1C518A0 VA: 0x181C526A0
	public string ToJsonString(IDiagnosticLogger logger) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[NullableContext(0)]
internal struct C.sentry_value_t // TypeDefIndex: 16842
{
	// Fields
	internal ulong _bits; // 0x0
	internal double _double; // 0x0
}

// Namespace: Sentry.Unity.NativeUtils
[NullableContext(1)]
[Nullable(0)]
internal static class C // TypeDefIndex: 16843
{
	// Fields
	internal static readonly Lazy<IEnumerable<DebugImage>> DebugImages; // 0x0

	// Methods

	// RVA: 0x1C3F1D0 Offset: 0x1C3E3D0 VA: 0x181C3F1D0
	internal static void SetValueIfNotNull(C.sentry_value_t obj, string key, string value) { }

	// RVA: 0x1C3F3F0 Offset: 0x1C3E5F0 VA: 0x181C3F3F0
	internal static void SetValueIfNotNull(C.sentry_value_t obj, string key, Nullable<int> value) { }

	// RVA: 0x1C3F0C0 Offset: 0x1C3E2C0 VA: 0x181C3F0C0
	internal static void SetValueIfNotNull(C.sentry_value_t obj, string key, Nullable<bool> value) { }

	// RVA: 0x1C3F2E0 Offset: 0x1C3E4E0 VA: 0x181C3F2E0
	internal static void SetValueIfNotNull(C.sentry_value_t obj, string key, Nullable<double> value) { }

	// RVA: 0x1C3E820 Offset: 0x1C3DA20 VA: 0x181C3E820
	internal static Nullable<C.sentry_value_t> GetValueOrNul(C.sentry_value_t obj, string key) { }

	// RVA: 0x1C3E950 Offset: 0x1C3DB50 VA: 0x181C3E950
	internal static string GetValueString(C.sentry_value_t obj, string key) { }

	// RVA: 0x1C3E6D0 Offset: 0x1C3D8D0 VA: 0x181C3E6D0
	internal static Nullable<int> GetValueInt(C.sentry_value_t obj, string key) { }

	// RVA: 0x1C3E570 Offset: 0x1C3D770 VA: 0x181C3E570
	internal static Nullable<double> GetValueDouble(C.sentry_value_t obj, string key) { }

	// RVA: 0x1C401A0 Offset: 0x1C3F3A0 VA: 0x181C401A0
	internal static extern C.sentry_value_t sentry_value_new_object() { }

	// RVA: 0x1C40130 Offset: 0x1C3F330 VA: 0x181C40130
	internal static extern C.sentry_value_t sentry_value_new_null() { }

	// RVA: 0x1C3FEF0 Offset: 0x1C3F0F0 VA: 0x181C3FEF0
	internal static extern C.sentry_value_t sentry_value_new_bool(int value) { }

	// RVA: 0x1C40030 Offset: 0x1C3F230 VA: 0x181C40030
	internal static extern C.sentry_value_t sentry_value_new_double(double value) { }

	// RVA: 0x1C400B0 Offset: 0x1C3F2B0 VA: 0x181C400B0
	internal static extern C.sentry_value_t sentry_value_new_int32(int value) { }

	// RVA: 0x1C40210 Offset: 0x1C3F410 VA: 0x181C40210
	internal static extern C.sentry_value_t sentry_value_new_string(string value) { }

	[NullableContext(2)]
	// RVA: 0x1C3FF70 Offset: 0x1C3F170 VA: 0x181C3FF70
	internal static extern C.sentry_value_t sentry_value_new_breadcrumb(string type, string message) { }

	// RVA: 0x1C402B0 Offset: 0x1C3F4B0 VA: 0x181C402B0
	internal static extern int sentry_value_set_by_key(C.sentry_value_t value, string k, C.sentry_value_t v) { }

	// RVA: 0x1C3EAB0 Offset: 0x1C3DCB0 VA: 0x181C3EAB0
	internal static bool IsNull(C.sentry_value_t value) { }

	// RVA: 0x1C3FE70 Offset: 0x1C3F070 VA: 0x181C3FE70
	internal static extern int sentry_value_is_null(C.sentry_value_t value) { }

	// RVA: 0x1C3FB30 Offset: 0x1C3ED30 VA: 0x181C3FB30
	internal static extern int sentry_value_as_int32(C.sentry_value_t value) { }

	// RVA: 0x1C3FAB0 Offset: 0x1C3ECB0 VA: 0x181C3FAB0
	internal static extern double sentry_value_as_double(C.sentry_value_t value) { }

	// RVA: 0x1C3FBB0 Offset: 0x1C3EDB0 VA: 0x181C3FBB0
	internal static extern IntPtr sentry_value_as_string(C.sentry_value_t value) { }

	// RVA: 0x1C3FDF0 Offset: 0x1C3EFF0 VA: 0x181C3FDF0
	internal static extern UIntPtr sentry_value_get_length(C.sentry_value_t value) { }

	// RVA: 0x1C3FCB0 Offset: 0x1C3EEB0 VA: 0x181C3FCB0
	internal static extern C.sentry_value_t sentry_value_get_by_index(C.sentry_value_t value, UIntPtr index) { }

	// RVA: 0x1C3FD40 Offset: 0x1C3EF40 VA: 0x181C3FD40
	internal static extern C.sentry_value_t sentry_value_get_by_key(C.sentry_value_t value, string key) { }

	// RVA: 0x1C3F840 Offset: 0x1C3EA40 VA: 0x181C3F840
	internal static extern void sentry_set_context(string key, C.sentry_value_t value) { }

	// RVA: 0x1C3F5C0 Offset: 0x1C3E7C0 VA: 0x181C3F5C0
	internal static extern void sentry_add_breadcrumb(C.sentry_value_t breadcrumb) { }

	// RVA: 0x1C3F980 Offset: 0x1C3EB80 VA: 0x181C3F980
	internal static extern void sentry_set_tag(string key, string value) { }

	// RVA: 0x1C3F740 Offset: 0x1C3E940 VA: 0x181C3F740
	internal static extern void sentry_remove_tag(string key) { }

	// RVA: 0x1C3FA30 Offset: 0x1C3EC30 VA: 0x181C3FA30
	internal static extern void sentry_set_user(C.sentry_value_t user) { }

	// RVA: 0x1C3F7D0 Offset: 0x1C3E9D0 VA: 0x181C3F7D0
	internal static extern void sentry_remove_user() { }

	// RVA: 0x1C3F8E0 Offset: 0x1C3EAE0 VA: 0x181C3F8E0
	internal static extern void sentry_set_extra(string key, C.sentry_value_t value) { }

	// RVA: 0x1C3F6B0 Offset: 0x1C3E8B0 VA: 0x181C3F6B0
	internal static extern void sentry_remove_extra(string key) { }

	// RVA: 0x1C3EB00 Offset: 0x1C3DD00 VA: 0x181C3EB00
	private static IEnumerable<DebugImage> LoadDebugImages() { }

	// RVA: 0x1C3F640 Offset: 0x1C3E840 VA: 0x181C3F640
	private static extern C.sentry_value_t sentry_get_modules_list() { }

	// RVA: 0x1C3FC30 Offset: 0x1C3EE30 VA: 0x181C3FC30
	internal static extern void sentry_value_decref(C.sentry_value_t value) { }

	// RVA: 0x1C3F500 Offset: 0x1C3E700 VA: 0x181C3F500
	private static void .cctor() { }
}

// Namespace: Sentry.Unity.NativeUtils
[NullableContext(2)]
[Nullable(0)]
internal static class ContextWriter // TypeDefIndex: 16844
{
	// Methods

	// RVA: 0x1C40360 Offset: 0x1C3F560 VA: 0x181C40360
	internal static void WriteApp(string AppStartTime, string AppBuildType) { }

	// RVA: 0x1C40B40 Offset: 0x1C3FD40 VA: 0x181C40B40
	internal static void WriteOS(string OperatingSystemRawDescription) { }

	// RVA: 0x1C40480 Offset: 0x1C3F680 VA: 0x181C40480
	internal static void WriteDevice(Nullable<int> DeviceProcessorCount, string DeviceCpuDescription, string DeviceTimezone, Nullable<bool> DeviceSupportsVibration, string DeviceName, Nullable<bool> DeviceSimulator, string DeviceDeviceUniqueIdentifier, string DeviceDeviceType, string DeviceModel, Nullable<long> DeviceMemorySize) { }

	// RVA: 0x1C40820 Offset: 0x1C3FA20 VA: 0x181C40820
	internal static void WriteGpu(Nullable<int> GpuId, string GpuName, string GpuVendorName, Nullable<int> GpuMemorySize, string GpuNpotSupport, string GpuVersion, string GpuApiType, Nullable<int> GpuMaxTextureSize, Nullable<bool> GpuSupportsDrawCallInstancing, Nullable<bool> GpuSupportsRayTracing, Nullable<bool> GpuSupportsComputeShaders, Nullable<bool> GpuSupportsGeometryShaders, string GpuVendorId, Nullable<bool> GpuMultiThreadedRendering, string GpuGraphicsShaderLevel) { }

	// RVA: 0x1C40C30 Offset: 0x1C3FE30 VA: 0x181C40C30
	internal static void WriteUnity(string EditorVersion, string UnityInstallMode, string UnityTargetFrameRate, string UnityCopyTextureSupport, string UnityRenderingThreadingMode) { }
}

// Namespace: Sentry.Unity.Json
internal static class SafeSerializer // TypeDefIndex: 16845
{
	// Methods

	[NullableContext(2)]
	// RVA: 0x1C41E40 Offset: 0x1C41040 VA: 0x181C41E40
	public static string SerializeSafely(object value, IDiagnosticLogger logger) { }
}

// Namespace: Sentry.Unity.Integrations
[NullableContext(1)]
internal interface IApplication // TypeDefIndex: 16846
{
	// Properties
	public abstract string ActiveSceneName { get; }
	public abstract bool IsEditor { get; }
	public abstract string ProductName { get; }
	public abstract string Version { get; }
	public abstract string BuildGUID { get; }
	public abstract string UnityVersion { get; }
	public abstract string PersistentDataPath { get; }
	public abstract RuntimePlatform Platform { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_LogMessageReceived(Application.LogCallback value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_LogMessageReceived(Application.LogCallback value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_Quitting(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_Quitting(Action value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_ActiveSceneName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsEditor();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_ProductName();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_BuildGUID();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_UnityVersion();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_PersistentDataPath();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract RuntimePlatform get_Platform();
}

// Namespace: Sentry.Unity.Integrations
[NullableContext(1)]
[Nullable(0)]
public sealed class ApplicationAdapter : IApplication // TypeDefIndex: 16847
{
	// Fields
	public static readonly ApplicationAdapter Instance; // 0x0
	[CompilerGenerated]
	[Nullable(2)]
	private Application.LogCallback LogMessageReceived; // 0x10
	[Nullable(2)]
	[CompilerGenerated]
	private Action Quitting; // 0x18

	// Properties
	public string ActiveSceneName { get; }
	public bool IsEditor { get; }
	public string ProductName { get; }
	public string Version { get; }
	public string BuildGUID { get; }
	public string UnityVersion { get; }
	public string PersistentDataPath { get; }
	public RuntimePlatform Platform { get; }

	// Methods

	// RVA: 0x1C3DED0 Offset: 0x1C3D0D0 VA: 0x181C3DED0
	private void .ctor() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C3DFB0 Offset: 0x1C3D1B0 VA: 0x181C3DFB0 Slot: 4
	public void add_LogMessageReceived(Application.LogCallback value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C3E310 Offset: 0x1C3D510 VA: 0x181C3E310 Slot: 5
	public void remove_LogMessageReceived(Application.LogCallback value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C3E050 Offset: 0x1C3D250 VA: 0x181C3E050 Slot: 6
	public void add_Quitting(Action value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C3E3B0 Offset: 0x1C3D5B0 VA: 0x181C3E3B0 Slot: 7
	public void remove_Quitting(Action value) { }

	// RVA: 0x1C3E0F0 Offset: 0x1C3D2F0 VA: 0x181C3E0F0 Slot: 8
	public string get_ActiveSceneName() { }

	// RVA: 0x1C3E190 Offset: 0x1C3D390 VA: 0x181C3E190 Slot: 9
	public bool get_IsEditor() { }

	// RVA: 0x1C3E250 Offset: 0x1C3D450 VA: 0x181C3E250 Slot: 10
	public string get_ProductName() { }

	// RVA: 0x1C3E2D0 Offset: 0x1C3D4D0 VA: 0x181C3E2D0 Slot: 11
	public string get_Version() { }

	// RVA: 0x1C3E150 Offset: 0x1C3D350 VA: 0x181C3E150 Slot: 12
	public string get_BuildGUID() { }

	// RVA: 0x1C3E290 Offset: 0x1C3D490 VA: 0x181C3E290 Slot: 13
	public string get_UnityVersion() { }

	// RVA: 0x1C3E1D0 Offset: 0x1C3D3D0 VA: 0x181C3E1D0 Slot: 14
	public string get_PersistentDataPath() { }

	// RVA: 0x1C3E210 Offset: 0x1C3D410 VA: 0x181C3E210 Slot: 15
	public RuntimePlatform get_Platform() { }

	// RVA: 0x1C3DD70 Offset: 0x1C3CF70 VA: 0x181C3DD70
	private void OnLogMessageReceived(string condition, string stackTrace, LogType type) { }

	// RVA: 0x1C3DD90 Offset: 0x1C3CF90 VA: 0x181C3DD90
	private void OnQuitting() { }

	// RVA: 0x1C3DDB0 Offset: 0x1C3CFB0 VA: 0x181C3DDB0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SceneManagerIntegration.<>c__DisplayClass3_0 // TypeDefIndex: 16848
{
	// Fields
	[Nullable(0)]
	public IHub hub; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C4BD30 Offset: 0x1C4AF30 VA: 0x181C4BD30
	internal void <Register>g__OnSceneManagerOnSceneLoaded|0(SceneAdapter scene, LoadSceneMode mode) { }

	// RVA: 0x1C4BF60 Offset: 0x1C4B160 VA: 0x181C4BF60
	internal void <Register>g__SceneManagerOnSceneUnloaded|1(SceneAdapter scene) { }

	// RVA: 0x1C4BDF0 Offset: 0x1C4AFF0 VA: 0x181C4BDF0
	internal void <Register>g__SceneManagerOnActiveSceneChanged|2(SceneAdapter fromScene, SceneAdapter toScene) { }
}

// Namespace: Sentry.Unity.Integrations
[NullableContext(1)]
[Nullable(0)]
internal class SceneManagerIntegration : ISdkIntegration // TypeDefIndex: 16849
{
	// Fields
	private readonly ISceneManager _sceneManager; // 0x10

	// Methods

	// RVA: 0x1C429D0 Offset: 0x1C41BD0 VA: 0x181C429D0
	public void .ctor() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(ISceneManager sceneManager) { }

	// RVA: 0x1C426E0 Offset: 0x1C418E0 VA: 0x181C426E0 Slot: 4
	public void Register(IHub hub, SentryOptions options) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SessionIntegration.<>c__DisplayClass2_0 // TypeDefIndex: 16850
{
	// Fields
	[Nullable(0)]
	public SentryOptions options; // 0x10
	[Nullable(0)]
	public IHub hub; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C4BB30 Offset: 0x1C4AD30 VA: 0x181C4BB30
	internal void <Register>b__0() { }

	// RVA: 0x1C4BBB0 Offset: 0x1C4ADB0 VA: 0x181C4BBB0
	internal void <Register>b__1() { }
}

// Namespace: Sentry.Unity.Integrations
[NullableContext(1)]
[Nullable(0)]
internal class SessionIntegration : ISdkIntegration // TypeDefIndex: 16851
{
	// Fields
	private readonly SentryMonoBehaviour _sentryMonoBehaviour; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(SentryMonoBehaviour sentryMonoBehaviour) { }

	// RVA: 0x1C4A1F0 Offset: 0x1C493F0 VA: 0x181C4A1F0 Slot: 4
	public void Register(IHub hub, SentryOptions options) { }
}

// Namespace: Sentry.Unity.Integrations
internal class UnityBadGatewayExceptionFilter : IExceptionFilter // TypeDefIndex: 16852
{
	// Fields
	[Nullable(1)]
	internal const string Message = "Error: HTTP/1.1 502 Bad Gateway";

	// Methods

	[NullableContext(1)]
	// RVA: 0x1C4C990 Offset: 0x1C4BB90 VA: 0x181C4C990 Slot: 4
	public bool Filter(Exception ex) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Unity.Integrations
internal sealed class UnityBeforeSceneLoadIntegration : ISdkIntegration // TypeDefIndex: 16853
{
	// Fields
	[Nullable(1)]
	private readonly IApplication _application; // 0x10

	// Methods

	[NullableContext(2)]
	// RVA: 0x1C4CBA0 Offset: 0x1C4BDA0 VA: 0x181C4CBA0
	public void .ctor(IApplication application) { }

	[NullableContext(1)]
	// RVA: 0x1C4CA70 Offset: 0x1C4BC70 VA: 0x181C4CA70 Slot: 4
	public void Register(IHub hub, SentryOptions options) { }
}

// Namespace: Sentry.Unity.Integrations
[NullableContext(1)]
[Nullable(0)]
internal sealed class UnityLogHandlerIntegration : ISdkIntegration, ILogHandler // TypeDefIndex: 16854
{
	// Fields
	internal readonly ErrorTimeDebounce ErrorTimeDebounce; // 0x10
	internal readonly LogTimeDebounce LogTimeDebounce; // 0x18
	internal readonly WarningTimeDebounce WarningTimeDebounce; // 0x20
	private readonly IApplication _application; // 0x28
	[Nullable(2)]
	private IHub _hub; // 0x30
	[Nullable(2)]
	private SentryUnityOptions _sentryOptions; // 0x38
	private ILogHandler _unityLogHandler; // 0x40

	// Methods

	// RVA: 0x1C4F630 Offset: 0x1C4E830 VA: 0x181C4F630
	public void .ctor(SentryUnityOptions options, IApplication application) { }

	// RVA: 0x1C4F2E0 Offset: 0x1C4E4E0 VA: 0x181C4F2E0 Slot: 4
	public void Register(IHub hub, SentryOptions sentryOptions) { }

	// RVA: 0x1C4EFB0 Offset: 0x1C4E1B0 VA: 0x181C4EFB0 Slot: 6
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x1C4E9E0 Offset: 0x1C4DBE0 VA: 0x181C4E9E0
	internal void CaptureException(Exception exception, Object context) { }

	// RVA: 0x1C4F050 Offset: 0x1C4E250 VA: 0x181C4F050 Slot: 5
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x1C4ECC0 Offset: 0x1C4DEC0 VA: 0x181C4ECC0
	internal void CaptureLogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x1C4F160 Offset: 0x1C4E360 VA: 0x181C4F160
	private void OnQuitting() { }

	// RVA: 0x1C4F600 Offset: 0x1C4E800 VA: 0x181C4F600
	private static SentryLevel ToEventTagType(LogType logType) { }

	// RVA: 0x1C4F5D0 Offset: 0x1C4E7D0 VA: 0x181C4F5D0
	private static BreadcrumbLevel ToBreadcrumbLevel(LogType logType) { }
}

// Namespace: Sentry.Unity.Integrations
internal class UnitySocketExceptionFilter : IExceptionFilter // TypeDefIndex: 16855
{
	// Fields
	[Nullable(1)]
	internal const string Message = "The requested address is not valid in this context";

	// Methods

	[NullableContext(1)]
	// RVA: 0x1C50D20 Offset: 0x1C4FF20 VA: 0x181C50D20 Slot: 4
	public bool Filter(Exception ex) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Unity.Integrations
internal class UnityWebExceptionFilter : IExceptionFilter // TypeDefIndex: 16856
{
	// Fields
	[Nullable(1)]
	internal const string Message = "Error: ConnectFailure (The requested address is not valid in this context)";

	// Methods

	[NullableContext(1)]
	// RVA: 0x1C51A60 Offset: 0x1C50C60 VA: 0x181C51A60 Slot: 4
	public bool Filter(Exception ex) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Unity.Extensions
[Extension]
internal static class JsonExtensions // TypeDefIndex: 16857
{
	// Methods

	[NullableContext(1)]
	[Extension]
	// RVA: 0x1C41940 Offset: 0x1C40B40 VA: 0x181C41940
	public static Nullable<JsonElement> GetPropertyOrNull(JsonElement json, string name) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static Nullable<TEnum> GetEnumOrNull<TEnum>(JsonElement json, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA27190 Offset: 0xA26390 VA: 0x180A27190
	|-JsonExtensions.GetEnumOrNull<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16858
{}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/Event.bindings.h")]
[StaticAccessor("GUIEvent", 2)]
public sealed class Event // TypeDefIndex: 16859
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static Event s_Current; // 0x0
	private static Event s_MasterEvent; // 0x8

	// Properties
	[NativeProperty("type", False, 1)]
	public EventType rawType { get; }
	[NativeProperty("mousePosition", False, 1)]
	public Vector2 mousePosition { get; set; }
	[NativeProperty("delta", False, 1)]
	public Vector2 delta { get; set; }
	[NativeProperty("pointerType", False, 1)]
	public PointerType pointerType { get; }
	[NativeProperty("button", False, 1)]
	public int button { get; }
	[NativeProperty("modifiers", False, 1)]
	public EventModifiers modifiers { get; set; }
	[NativeProperty("pressure", False, 1)]
	public float pressure { get; }
	[NativeProperty("twist", False, 1)]
	public float twist { get; }
	[NativeProperty("tilt", False, 1)]
	public Vector2 tilt { get; }
	[NativeProperty("penStatus", False, 1)]
	public PenStatus penStatus { get; }
	[NativeProperty("clickCount", False, 1)]
	public int clickCount { get; }
	[NativeProperty("character", False, 1)]
	public char character { get; set; }
	[NativeProperty("keycode", False, 1)]
	public KeyCode keyCode { get; set; }
	[NativeProperty("displayIndex", False, 1)]
	public int displayIndex { get; set; }
	public EventType type { get; set; }
	public string commandName { get; set; }
	public bool shift { get; }
	public bool control { get; }
	public bool alt { get; }
	public bool command { get; }
	public static Event current { get; set; }
	public bool isKey { get; }
	public bool isMouse { get; }
	internal bool isDirectManipulationDevice { get; }

	// Methods

	// RVA: 0x24BECD0 Offset: 0x24BDED0 VA: 0x1824BECD0
	public EventType get_rawType() { }

	// RVA: 0x24BEBC0 Offset: 0x24BDDC0 VA: 0x1824BEBC0
	public Vector2 get_mousePosition() { }

	// RVA: 0x24BF140 Offset: 0x24BE340 VA: 0x1824BF140
	public void set_mousePosition(Vector2 value) { }

	// RVA: 0x24BE940 Offset: 0x24BDB40 VA: 0x1824BE940
	public Vector2 get_delta() { }

	// RVA: 0x24BEFF0 Offset: 0x24BE1F0 VA: 0x1824BEFF0
	public void set_delta(Vector2 value) { }

	// RVA: 0x24BEC50 Offset: 0x24BDE50 VA: 0x1824BEC50
	public PointerType get_pointerType() { }

	// RVA: 0x24BE730 Offset: 0x24BD930 VA: 0x1824BE730
	public int get_button() { }

	// RVA: 0x24BEB30 Offset: 0x24BDD30 VA: 0x1824BEB30
	public EventModifiers get_modifiers() { }

	// RVA: 0x24BF0B0 Offset: 0x24BE2B0 VA: 0x1824BF0B0
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x24BEC90 Offset: 0x24BDE90 VA: 0x1824BEC90
	public float get_pressure() { }

	// RVA: 0x24BEDF0 Offset: 0x24BDFF0 VA: 0x1824BEDF0
	public float get_twist() { }

	// RVA: 0x24BEDA0 Offset: 0x24BDFA0 VA: 0x1824BEDA0
	public Vector2 get_tilt() { }

	// RVA: 0x24BEC10 Offset: 0x24BDE10 VA: 0x1824BEC10
	public PenStatus get_penStatus() { }

	// RVA: 0x24BE7B0 Offset: 0x24BD9B0 VA: 0x1824BE7B0
	public int get_clickCount() { }

	// RVA: 0x24BE770 Offset: 0x24BD970 VA: 0x1824BE770
	public char get_character() { }

	// RVA: 0x24BEE70 Offset: 0x24BE070 VA: 0x1824BEE70
	public void set_character(char value) { }

	// RVA: 0x24BEAF0 Offset: 0x24BDCF0 VA: 0x1824BEAF0
	public KeyCode get_keyCode() { }

	// RVA: 0x24BF070 Offset: 0x24BE270 VA: 0x1824BF070
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x24BE990 Offset: 0x24BDB90 VA: 0x1824BE990
	public int get_displayIndex() { }

	// RVA: 0x24BF030 Offset: 0x24BE230 VA: 0x1824BF030
	public void set_displayIndex(int value) { }

	[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
	// RVA: 0x24BEE30 Offset: 0x24BE030 VA: 0x1824BEE30
	public EventType get_type() { }

	[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
	// RVA: 0x24BF180 Offset: 0x24BE380 VA: 0x1824BF180
	public void set_type(EventType value) { }

	[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
	// RVA: 0x24BE7F0 Offset: 0x24BD9F0 VA: 0x1824BE7F0
	public string get_commandName() { }

	[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = True)]
	// RVA: 0x24BEEC0 Offset: 0x24BE0C0 VA: 0x1824BEEC0
	public void set_commandName(string value) { }

	[NativeMethod("Use")]
	// RVA: 0x24BC940 Offset: 0x24BBB40 VA: 0x1824BC940
	private void Internal_Use() { }

	[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x24BC750 Offset: 0x24BB950 VA: 0x1824BC750
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x24BC790 Offset: 0x24BB990 VA: 0x1824BC790
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = True)]
	// RVA: 0x24BC710 Offset: 0x24BB910 VA: 0x1824BC710
	public EventType GetTypeForControl(int controlID) { }

	[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = True, HasExplicitThis = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x24BC1D0 Offset: 0x24BB3D0 VA: 0x1824BC1D0
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x24BDC00 Offset: 0x24BCE00 VA: 0x1824BDC00
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x24BC900 Offset: 0x24BBB00 VA: 0x1824BC900
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCode]
	// RVA: 0x24BC7D0 Offset: 0x24BB9D0 VA: 0x1824BC7D0
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x24BC590 Offset: 0x24BB790 VA: 0x1824BC590
	internal static int GetDoubleClickTime() { }

	// RVA: 0x24BE660 Offset: 0x24BD860 VA: 0x1824BE660
	public void .ctor() { }

	// RVA: 0x24BE6A0 Offset: 0x24BD8A0 VA: 0x1824BE6A0
	public void .ctor(int displayIndex) { }

	// RVA: 0x24BC4F0 Offset: 0x24BB6F0 VA: 0x1824BC4F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24BC220 Offset: 0x24BB420 VA: 0x1824BC220
	internal void CopyFrom(Event e) { }

	// RVA: 0x24BED10 Offset: 0x24BDF10 VA: 0x1824BED10
	public bool get_shift() { }

	// RVA: 0x24BE870 Offset: 0x24BDA70 VA: 0x1824BE870
	public bool get_control() { }

	// RVA: 0x24BE6F0 Offset: 0x24BD8F0 VA: 0x1824BE6F0
	public bool get_alt() { }

	// RVA: 0x24BE830 Offset: 0x24BDA30 VA: 0x1824BE830
	public bool get_command() { }

	// RVA: 0x24BE8B0 Offset: 0x24BDAB0 VA: 0x1824BE8B0
	public static Event get_current() { }

	// RVA: 0x24BEF10 Offset: 0x24BE110 VA: 0x1824BEF10
	public static void set_current(Event value) { }

	// RVA: 0x24BEA40 Offset: 0x24BDC40 VA: 0x1824BEA40
	public bool get_isKey() { }

	// RVA: 0x24BEA90 Offset: 0x24BDC90 VA: 0x1824BEA90
	public bool get_isMouse() { }

	// RVA: 0x24BE9D0 Offset: 0x24BDBD0 VA: 0x1824BE9D0
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x24BC980 Offset: 0x24BBB80 VA: 0x1824BC980
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x24BC5C0 Offset: 0x24BB7C0 VA: 0x1824BC5C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24BC290 Offset: 0x24BB490 VA: 0x1824BC290 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24BDC40 Offset: 0x24BCE40 VA: 0x1824BDC40 Slot: 3
	public override string ToString() { }

	// RVA: 0x24BE4B0 Offset: 0x24BD6B0 VA: 0x1824BE4B0
	public void Use() { }

	// RVA: 0x24BEB70 Offset: 0x24BDD70 VA: 0x1824BEB70
	private void get_mousePosition_Injected(out Vector2 ret) { }

	// RVA: 0x24BF0F0 Offset: 0x24BE2F0 VA: 0x1824BF0F0
	private void set_mousePosition_Injected(ref Vector2 value) { }

	// RVA: 0x24BE8F0 Offset: 0x24BDAF0 VA: 0x1824BE8F0
	private void get_delta_Injected(out Vector2 ret) { }

	// RVA: 0x24BEFA0 Offset: 0x24BE1A0 VA: 0x1824BEFA0
	private void set_delta_Injected(ref Vector2 value) { }

	// RVA: 0x24BED50 Offset: 0x24BDF50 VA: 0x1824BED50
	private void get_tilt_Injected(out Vector2 ret) { }
}

// Namespace: UnityEngine
public enum EventType // TypeDefIndex: 16860
{
	// Fields
	public int value__; // 0x0
	public const EventType MouseDown = 0;
	public const EventType MouseUp = 1;
	public const EventType MouseMove = 2;
	public const EventType MouseDrag = 3;
	public const EventType KeyDown = 4;
	public const EventType KeyUp = 5;
	public const EventType ScrollWheel = 6;
	public const EventType Repaint = 7;
	public const EventType Layout = 8;
	public const EventType DragUpdated = 9;
	public const EventType DragPerform = 10;
	public const EventType DragExited = 15;
	public const EventType Ignore = 11;
	public const EventType Used = 12;
	public const EventType ValidateCommand = 13;
	public const EventType ExecuteCommand = 14;
	public const EventType ContextClick = 16;
	public const EventType MouseEnterWindow = 20;
	public const EventType MouseLeaveWindow = 21;
	public const EventType TouchDown = 30;
	public const EventType TouchUp = 31;
	public const EventType TouchMove = 32;
	public const EventType TouchEnter = 33;
	public const EventType TouchLeave = 34;
	public const EventType TouchStationary = 35;
	[Obsolete("Use MouseDown instead (UnityUpgradable) -> MouseDown", True)]
	[EditorBrowsable(1)]
	public const EventType mouseDown = 0;
	[Obsolete("Use MouseUp instead (UnityUpgradable) -> MouseUp", True)]
	[EditorBrowsable(1)]
	public const EventType mouseUp = 1;
	[Obsolete("Use MouseMove instead (UnityUpgradable) -> MouseMove", True)]
	[EditorBrowsable(1)]
	public const EventType mouseMove = 2;
	[EditorBrowsable(1)]
	[Obsolete("Use MouseDrag instead (UnityUpgradable) -> MouseDrag", True)]
	public const EventType mouseDrag = 3;
	[EditorBrowsable(1)]
	[Obsolete("Use KeyDown instead (UnityUpgradable) -> KeyDown", True)]
	public const EventType keyDown = 4;
	[EditorBrowsable(1)]
	[Obsolete("Use KeyUp instead (UnityUpgradable) -> KeyUp", True)]
	public const EventType keyUp = 5;
	[EditorBrowsable(1)]
	[Obsolete("Use ScrollWheel instead (UnityUpgradable) -> ScrollWheel", True)]
	public const EventType scrollWheel = 6;
	[EditorBrowsable(1)]
	[Obsolete("Use Repaint instead (UnityUpgradable) -> Repaint", True)]
	public const EventType repaint = 7;
	[EditorBrowsable(1)]
	[Obsolete("Use Layout instead (UnityUpgradable) -> Layout", True)]
	public const EventType layout = 8;
	[EditorBrowsable(1)]
	[Obsolete("Use DragUpdated instead (UnityUpgradable) -> DragUpdated", True)]
	public const EventType dragUpdated = 9;
	[EditorBrowsable(1)]
	[Obsolete("Use DragPerform instead (UnityUpgradable) -> DragPerform", True)]
	public const EventType dragPerform = 10;
	[EditorBrowsable(1)]
	[Obsolete("Use Ignore instead (UnityUpgradable) -> Ignore", True)]
	public const EventType ignore = 11;
	[EditorBrowsable(1)]
	[Obsolete("Use Used instead (UnityUpgradable) -> Used", True)]
	public const EventType used = 12;
}

// Namespace: UnityEngine
[Flags]
public enum EventModifiers // TypeDefIndex: 16861
{
	// Fields
	public int value__; // 0x0
	public const EventModifiers None = 0;
	public const EventModifiers Shift = 1;
	public const EventModifiers Control = 2;
	public const EventModifiers Alt = 4;
	public const EventModifiers Command = 8;
	public const EventModifiers Numeric = 16;
	public const EventModifiers CapsLock = 32;
	public const EventModifiers FunctionKey = 64;
}

// Namespace: UnityEngine
public enum PointerType // TypeDefIndex: 16862
{
	// Fields
	public int value__; // 0x0
	public const PointerType Mouse = 0;
	public const PointerType Touch = 1;
	public const PointerType Pen = 2;
}

// Namespace: UnityEngine
internal struct EventInterests // TypeDefIndex: 16863
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <wantsMouseMove>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; // 0x1
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <wantsLessLayoutEvents>k__BackingField; // 0x2

	// Properties
	public bool wantsMouseMove { get; set; }
	public bool wantsMouseEnterLeaveWindow { get; set; }
	public bool wantsLessLayoutEvents { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_wantsMouseMove() { }

	[CompilerGenerated]
	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	public void set_wantsMouseMove(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x13147E0 Offset: 0x13139E0 VA: 0x1813147E0
	public bool get_wantsMouseEnterLeaveWindow() { }

	[CompilerGenerated]
	// RVA: 0x18C4840 Offset: 0x18C3A40 VA: 0x1818C4840
	public void set_wantsMouseEnterLeaveWindow(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1812090 Offset: 0x1811290 VA: 0x181812090
	public bool get_wantsLessLayoutEvents() { }

	// RVA: 0x24BC0B0 Offset: 0x24BB2B0 VA: 0x1824BC0B0
	public bool WantsEvent(EventType type) { }

	// RVA: 0x24BC0D0 Offset: 0x24BB2D0 VA: 0x1824BC0D0
	public bool WantsLayoutPass(EventType type) { }
}

// Namespace: 
public sealed class GUI.WindowFunction : MulticastDelegate // TypeDefIndex: 16864
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(int id) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
public class GUI // TypeDefIndex: 16865
{
	// Fields
	private static int s_ScrollControlId; // 0x0
	private static int s_HotTextField; // 0x4
	private static readonly int s_BoxHash; // 0x8
	private static readonly int s_ButonHash; // 0xC
	private static readonly int s_RepeatButtonHash; // 0x10
	private static readonly int s_ToggleHash; // 0x14
	private static readonly int s_ButtonGridHash; // 0x18
	private static readonly int s_SliderHash; // 0x1C
	private static readonly int s_BeginGroupHash; // 0x20
	private static readonly int s_ScrollviewHash; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static int <scrollTroughSide>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x30
	private static GUISkin s_Skin; // 0x38
	internal static Rect s_ToolTipRect; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static GenericStack <scrollViewStates>k__BackingField; // 0x50

	// Properties
	public static Color color { get; set; }
	public static Color backgroundColor { get; set; }
	public static Color contentColor { get; set; }
	public static bool changed { get; set; }
	public static bool enabled { get; set; }
	internal static bool usePageScrollbars { get; }
	internal static int scrollTroughSide { get; set; }
	internal static DateTime nextScrollStepTime { get; set; }
	public static GUISkin skin { get; set; }
	public static Matrix4x4 matrix { get; set; }
	internal static GenericStack scrollViewStates { get; }

	// Methods

	// RVA: 0x24D62C0 Offset: 0x24D54C0 VA: 0x1824D62C0
	public static Color get_color() { }

	// RVA: 0x24D6770 Offset: 0x24D5970 VA: 0x1824D6770
	public static void set_color(Color value) { }

	// RVA: 0x24D61E0 Offset: 0x24D53E0 VA: 0x1824D61E0
	public static Color get_backgroundColor() { }

	// RVA: 0x24D6680 Offset: 0x24D5880 VA: 0x1824D6680
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x24D6370 Offset: 0x24D5570 VA: 0x1824D6370
	public static Color get_contentColor() { }

	// RVA: 0x24D6820 Offset: 0x24D5A20 VA: 0x1824D6820
	public static void set_contentColor(Color value) { }

	// RVA: 0x24D6250 Offset: 0x24D5450 VA: 0x1824D6250
	public static bool get_changed() { }

	// RVA: 0x24D66F0 Offset: 0x24D58F0 VA: 0x1824D66F0
	public static void set_changed(bool value) { }

	// RVA: 0x24D63E0 Offset: 0x24D55E0 VA: 0x1824D63E0
	public static bool get_enabled() { }

	// RVA: 0x24D6890 Offset: 0x24D5A90 VA: 0x1824D6890
	public static void set_enabled(bool value) { }

	// RVA: 0x24D6610 Offset: 0x24D5810 VA: 0x1824D6610
	internal static bool get_usePageScrollbars() { }

	// RVA: 0x24D42C0 Offset: 0x24D34C0 VA: 0x1824D42C0
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x24D4300 Offset: 0x24D3500 VA: 0x1824D4300
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x24D49E0 Offset: 0x24D3BE0 VA: 0x1824D49E0
	internal static void ReleaseMouseControl() { }

	// RVA: 0x24D45A0 Offset: 0x24D37A0 VA: 0x1824D45A0
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x24D4640 Offset: 0x24D3840 VA: 0x1824D4640
	private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) { }

	// RVA: 0x24D4280 Offset: 0x24D3480 VA: 0x1824D4280
	public static void FocusWindow(int windowID) { }

	// RVA: 0x24D5EA0 Offset: 0x24D50A0 VA: 0x1824D5EA0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x24D64F0 Offset: 0x24D56F0 VA: 0x1824D64F0
	internal static int get_scrollTroughSide() { }

	[CompilerGenerated]
	// RVA: 0x24D6990 Offset: 0x24D5B90 VA: 0x1824D6990
	internal static void set_scrollTroughSide(int value) { }

	[CompilerGenerated]
	// RVA: 0x24D64A0 Offset: 0x24D56A0 VA: 0x1824D64A0
	internal static DateTime get_nextScrollStepTime() { }

	[CompilerGenerated]
	// RVA: 0x24D6930 Offset: 0x24D5B30 VA: 0x1824D6930
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x24D69F0 Offset: 0x24D5BF0 VA: 0x1824D69F0
	public static void set_skin(GUISkin value) { }

	// RVA: 0x24D6590 Offset: 0x24D5790 VA: 0x1824D6590
	public static GUISkin get_skin() { }

	// RVA: 0x24D2C90 Offset: 0x24D1E90 VA: 0x1824D2C90
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x24D6410 Offset: 0x24D5610 VA: 0x1824D6410
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x24D68D0 Offset: 0x24D5AD0 VA: 0x1824D68D0
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x24D4820 Offset: 0x24D3A20 VA: 0x1824D4820
	public static void Label(Rect position, string text) { }

	// RVA: 0x24D4720 Offset: 0x24D3920 VA: 0x1824D4720
	public static void Label(Rect position, string text, GUIStyle style) { }

	// RVA: 0x24D4940 Offset: 0x24D3B40 VA: 0x1824D4940
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x24D15E0 Offset: 0x24D07E0 VA: 0x1824D15E0
	public static void Box(Rect position, string text) { }

	// RVA: 0x24D13E0 Offset: 0x24D05E0 VA: 0x1824D13E0
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x24D16A0 Offset: 0x24D08A0 VA: 0x1824D16A0
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x24D1920 Offset: 0x24D0B20 VA: 0x1824D1920
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x24D2780 Offset: 0x24D1980 VA: 0x1824D2780
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0x24D57C0 Offset: 0x24D49C0 VA: 0x1824D57C0
	public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x24D1F30 Offset: 0x24D1130 VA: 0x1824D1F30
	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x24D23A0 Offset: 0x24D15A0 VA: 0x1824D23A0
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x24D2E80 Offset: 0x24D2080 VA: 0x1824D2E80
	internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x24D1DF0 Offset: 0x24D0FF0 VA: 0x1824D1DF0
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x24D55E0 Offset: 0x24D47E0 VA: 0x1824D55E0
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x24D4340 Offset: 0x24D3540 VA: 0x1824D4340
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	// RVA: 0x24D4A10 Offset: 0x24D3C10 VA: 0x1824D4A10
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0x24D5A80 Offset: 0x24D4C80 VA: 0x1824D5A80
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	// RVA: 0x24D4D30 Offset: 0x24D3F30 VA: 0x1824D4D30
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	// RVA: 0x24D0410 Offset: 0x24CF610 VA: 0x1824D0410
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x24D0080 Offset: 0x24CF280 VA: 0x1824D0080
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x24D3140 Offset: 0x24D2340 VA: 0x1824D3140
	public static void EndGroup() { }

	[CompilerGenerated]
	// RVA: 0x24D6540 Offset: 0x24D5740 VA: 0x1824D6540
	internal static GenericStack get_scrollViewStates() { }

	// RVA: 0x24D04E0 Offset: 0x24CF6E0 VA: 0x1824D04E0
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x24D31B0 Offset: 0x24D23B0 VA: 0x1824D31B0
	public static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x24D5CE0 Offset: 0x24D4EE0 VA: 0x1824D5CE0
	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style) { }

	// RVA: 0x24D2FD0 Offset: 0x24D21D0 VA: 0x1824D2FD0
	private static Rect DoWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) { }

	[RequiredByNativeCode]
	// RVA: 0x24D1B20 Offset: 0x24D0D20 VA: 0x1824D1B20
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x24D6280 Offset: 0x24D5480 VA: 0x1824D6280
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x24D6730 Offset: 0x24D5930 VA: 0x1824D6730
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x24D61A0 Offset: 0x24D53A0 VA: 0x1824D61A0
	private static void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x24D6640 Offset: 0x24D5840 VA: 0x1824D6640
	private static void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x24D6330 Offset: 0x24D5530 VA: 0x1824D6330
	private static void get_contentColor_Injected(out Color ret) { }

	// RVA: 0x24D67E0 Offset: 0x24D59E0 VA: 0x1824D67E0
	private static void set_contentColor_Injected(ref Color value) { }

	// RVA: 0x24D45D0 Offset: 0x24D37D0 VA: 0x1824D45D0
	private static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret) { }
}

// Namespace: 
internal struct GUIClip.ParentClipScope : IDisposable // TypeDefIndex: 16866
{
	// Fields
	private bool m_Disposed; // 0x0

	// Methods

	// RVA: 0x24D71C0 Offset: 0x24D63C0 VA: 0x1824D71C0
	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x24D7180 Offset: 0x24D6380 VA: 0x1824D7180 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIState.h")]
[NativeHeader("Modules/IMGUI/GUIClip.h")]
internal sealed class GUIClip // TypeDefIndex: 16867
{
	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
	// RVA: 0x24BF7B0 Offset: 0x24BE9B0 VA: 0x1824BF7B0
	internal static Rect get_visibleRect() { }

	// RVA: 0x24BF630 Offset: 0x24BE830 VA: 0x1824BF630
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x24BF440 Offset: 0x24BE640 VA: 0x1824BF440
	internal static void Internal_Pop() { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
	// RVA: 0x24BF3E0 Offset: 0x24BE5E0 VA: 0x1824BF3E0
	internal static int Internal_GetCount() { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
	// RVA: 0x24BF390 Offset: 0x24BE590 VA: 0x1824BF390
	internal static Matrix4x4 GetMatrix() { }

	// RVA: 0x24BF730 Offset: 0x24BE930 VA: 0x1824BF730
	internal static void SetMatrix(Matrix4x4 m) { }

	// RVA: 0x24BF4D0 Offset: 0x24BE6D0 VA: 0x1824BF4D0
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x24BF560 Offset: 0x24BE760 VA: 0x1824BF560
	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	// RVA: 0x24BF410 Offset: 0x24BE610 VA: 0x1824BF410
	internal static void Internal_PopParentClip() { }

	// RVA: 0x24BF690 Offset: 0x24BE890 VA: 0x1824BF690
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x24BF440 Offset: 0x24BE640 VA: 0x1824BF440
	internal static void Pop() { }

	// RVA: 0x24BF770 Offset: 0x24BE970 VA: 0x1824BF770
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x24BF5C0 Offset: 0x24BE7C0 VA: 0x1824BF5C0
	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x24BF350 Offset: 0x24BE550 VA: 0x1824BF350
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x24BF6F0 Offset: 0x24BE8F0 VA: 0x1824BF6F0
	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x24BF470 Offset: 0x24BE670 VA: 0x1824BF470
	private static void Internal_PushParentClip_Injected(ref Matrix4x4 renderTransform, ref Matrix4x4 inputTransform, ref Rect clipRect) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIContent.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Serializable]
public class GUIContent // TypeDefIndex: 16868
{
	// Fields
	[SerializeField]
	private string m_Text; // 0x10
	[SerializeField]
	private Texture m_Image; // 0x18
	[SerializeField]
	private string m_Tooltip; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action OnTextChanged; // 0x28
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	public static GUIContent none; // 0x18

	// Properties
	public string text { get; set; }
	public Texture image { set; }
	public string tooltip { get; set; }

	// Methods

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	public string get_text() { }

	// RVA: 0x24BFF60 Offset: 0x24BF160 VA: 0x1824BFF60
	public void set_text(string value) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_image(Texture value) { }

	// RVA: 0x2497C30 Offset: 0x2496E30 VA: 0x182497C30
	public string get_tooltip() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_tooltip(string value) { }

	// RVA: 0x24BFE20 Offset: 0x24BF020 VA: 0x1824BFE20
	public void .ctor() { }

	// RVA: 0x24BFE80 Offset: 0x24BF080 VA: 0x1824BFE80
	public void .ctor(string text) { }

	// RVA: 0x24BFD30 Offset: 0x24BEF30 VA: 0x1824BFD30
	public void .ctor(string text, string tooltip) { }

	// RVA: 0x24BFC70 Offset: 0x24BEE70 VA: 0x1824BFC70
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x24BFD50 Offset: 0x24BEF50 VA: 0x1824BFD50
	public void .ctor(GUIContent src) { }

	// RVA: 0x24BF910 Offset: 0x24BEB10 VA: 0x1824BF910
	internal static GUIContent Temp(string t) { }

	// RVA: 0x24BF7F0 Offset: 0x24BE9F0 VA: 0x1824BF7F0
	internal static void ClearStaticCache() { }

	// RVA: 0x24BF9C0 Offset: 0x24BEBC0 VA: 0x1824BF9C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x24BF9F0 Offset: 0x24BEBF0 VA: 0x1824BF9F0
	private static void .cctor() { }
}

// Namespace: UnityEngine
public enum ScaleMode // TypeDefIndex: 16869
{
	// Fields
	public int value__; // 0x0
	public const ScaleMode StretchToFill = 0;
	public const ScaleMode ScaleAndCrop = 1;
	public const ScaleMode ScaleToFit = 2;
}

// Namespace: UnityEngine
public enum FocusType // TypeDefIndex: 16870
{
	// Fields
	public int value__; // 0x0
	[Obsolete("FocusType.Native now behaves the same as FocusType.Passive in all OS cases. (UnityUpgradable) -> Passive", False)]
	public const FocusType Native = 0;
	public const FocusType Keyboard = 1;
	public const FocusType Passive = 2;
}

// Namespace: 
private sealed class GUILayout.LayoutedWindow // TypeDefIndex: 16871
{
	// Fields
	private readonly GUI.WindowFunction m_Func; // 0x10
	private readonly Rect m_ScreenRect; // 0x18
	private readonly GUILayoutOption[] m_Options; // 0x28
	private readonly GUIStyle m_Style; // 0x30

	// Methods

	// RVA: 0x24D7130 Offset: 0x24D6330 VA: 0x1824D7130
	internal void .ctor(GUI.WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style) { }

	// RVA: 0x24D6FC0 Offset: 0x24D61C0 VA: 0x1824D6FC0
	public void DoWindow(int windowID) { }
}

// Namespace: UnityEngine
public class GUILayout // TypeDefIndex: 16872
{
	// Methods

	// RVA: 0x24C8BF0 Offset: 0x24C7DF0 VA: 0x1824C8BF0
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x24C8C90 Offset: 0x24C7E90 VA: 0x1824C8C90
	public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C7ED0 Offset: 0x24C70D0 VA: 0x1824C7ED0
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C7B80 Offset: 0x24C6D80 VA: 0x1824C7B80
	public static void Box(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C7B80 Offset: 0x24C6D80 VA: 0x1824C7B80
	private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C7C70 Offset: 0x24C6E70 VA: 0x1824C7C70
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x24C7DE0 Offset: 0x24C6FE0 VA: 0x1824C7DE0
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C9090 Offset: 0x24C8290 VA: 0x1824C9090
	public static bool Toggle(bool value, string text, GUILayoutOption[] options) { }

	// RVA: 0x24C9150 Offset: 0x24C8350 VA: 0x1824C9150
	public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C91E0 Offset: 0x24C83E0 VA: 0x1824C91E0
	public static bool Toggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C8020 Offset: 0x24C7220 VA: 0x1824C8020
	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C8DA0 Offset: 0x24C7FA0 VA: 0x1824C8DA0
	public static void Space(float pixels) { }

	// RVA: 0x24C87E0 Offset: 0x24C79E0 VA: 0x1824C87E0
	public static void FlexibleSpace() { }

	// RVA: 0x24C7100 Offset: 0x24C6300 VA: 0x1824C7100
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x24C72F0 Offset: 0x24C64F0 VA: 0x1824C72F0
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C8570 Offset: 0x24C7770 VA: 0x1824C8570
	public static void EndHorizontal() { }

	// RVA: 0x24C7990 Offset: 0x24C6B90 VA: 0x1824C7990
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x24C7810 Offset: 0x24C6A10 VA: 0x1824C7810
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C86A0 Offset: 0x24C78A0 VA: 0x1824C86A0
	public static void EndVertical() { }

	// RVA: 0x24C6DB0 Offset: 0x24C5FB0 VA: 0x1824C6DB0
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x24C6E60 Offset: 0x24C6060 VA: 0x1824C6E60
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x24C8410 Offset: 0x24C7610 VA: 0x1824C8410
	public static void EndArea() { }

	// RVA: 0x24C7470 Offset: 0x24C6670 VA: 0x1824C7470
	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	// RVA: 0x24C7540 Offset: 0x24C6740 VA: 0x1824C7540
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0x24C85B0 Offset: 0x24C77B0 VA: 0x1824C85B0
	public static void EndScrollView() { }

	// RVA: 0x24C8620 Offset: 0x24C7820 VA: 0x1824C8620
	internal static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x24C9280 Offset: 0x24C8480 VA: 0x1824C9280
	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUILayoutOption[] options) { }

	// RVA: 0x24C8130 Offset: 0x24C7330 VA: 0x1824C8130
	private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C91F0 Offset: 0x24C83F0 VA: 0x1824C91F0
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x24C8D10 Offset: 0x24C7F10 VA: 0x1824C8D10
	public static GUILayoutOption MinWidth(float minWidth) { }

	// RVA: 0x24C8B60 Offset: 0x24C7D60 VA: 0x1824C8B60
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x24C8760 Offset: 0x24C7960 VA: 0x1824C8760
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x24C86E0 Offset: 0x24C78E0 VA: 0x1824C86E0
	public static GUILayoutOption ExpandHeight(bool expand) { }
}

// Namespace: 
internal enum GUILayoutOption.Type // TypeDefIndex: 16873
{
	// Fields
	public int value__; // 0x0
	public const GUILayoutOption.Type fixedWidth = 0;
	public const GUILayoutOption.Type fixedHeight = 1;
	public const GUILayoutOption.Type minWidth = 2;
	public const GUILayoutOption.Type maxWidth = 3;
	public const GUILayoutOption.Type minHeight = 4;
	public const GUILayoutOption.Type maxHeight = 5;
	public const GUILayoutOption.Type stretchWidth = 6;
	public const GUILayoutOption.Type stretchHeight = 7;
	public const GUILayoutOption.Type alignStart = 8;
	public const GUILayoutOption.Type alignMiddle = 9;
	public const GUILayoutOption.Type alignEnd = 10;
	public const GUILayoutOption.Type alignJustify = 11;
	public const GUILayoutOption.Type equalSize = 12;
	public const GUILayoutOption.Type spacing = 13;
}

// Namespace: UnityEngine
public sealed class GUILayoutOption // TypeDefIndex: 16874
{
	// Fields
	internal GUILayoutOption.Type type; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x7B8500 Offset: 0x7B7700 VA: 0x1807B8500
	internal void .ctor(GUILayoutOption.Type type, object value) { }
}

// Namespace: 
[DebuggerDisplay("id={id}, groups={layoutGroups.Count}")]
internal sealed class GUILayoutUtility.LayoutCache // TypeDefIndex: 16875
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <id>k__BackingField; // 0x10
	internal GUILayoutGroup topLevel; // 0x18
	internal GenericStack layoutGroups; // 0x20
	internal GUILayoutGroup windows; // 0x28

	// Properties
	private int id { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	private void set_id(int value) { }

	// RVA: 0x24D6EE0 Offset: 0x24D60E0 VA: 0x1824D6EE0
	internal void .ctor(int instanceID = -1) { }

	// RVA: 0x24D6C30 Offset: 0x24D5E30 VA: 0x1824D6C30
	public void ResetCursor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
public class GUILayoutUtility // TypeDefIndex: 16876
{
	// Fields
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static GUILayoutUtility.LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static int <unbalancedgroupscount>k__BackingField; // 0x28
	private static GUIStyle s_SpaceStyle; // 0x30

	// Properties
	internal static int unbalancedgroupscount { get; set; }
	internal static GUIStyle spaceStyle { get; }

	// Methods

	// RVA: 0x24C5B50 Offset: 0x24C4D50 VA: 0x1824C5B50
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x24C5C10 Offset: 0x24C4E10 VA: 0x1824C5C10
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[CompilerGenerated]
	// RVA: 0x24C6D00 Offset: 0x24C5F00 VA: 0x1824C6D00
	internal static int get_unbalancedgroupscount() { }

	[CompilerGenerated]
	// RVA: 0x24C6D50 Offset: 0x24C5F50 VA: 0x1824C6D50
	internal static void set_unbalancedgroupscount(int value) { }

	// RVA: 0x24C5900 Offset: 0x24C4B00 VA: 0x1824C5900
	internal static GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	// RVA: 0x24C68C0 Offset: 0x24C5AC0 VA: 0x1824C68C0
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x24C67E0 Offset: 0x24C59E0 VA: 0x1824C67E0
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	// RVA: 0x24C47E0 Offset: 0x24C39E0 VA: 0x1824C47E0
	internal static void Begin(int instanceID) { }

	// RVA: 0x24C3B70 Offset: 0x24C2D70 VA: 0x1824C3B70
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	// RVA: 0x24C4480 Offset: 0x24C3680 VA: 0x1824C4480
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C6520 Offset: 0x24C5720 VA: 0x1824C6520
	internal static void Layout() { }

	// RVA: 0x24C6030 Offset: 0x24C5230 VA: 0x1824C6030
	internal static void LayoutFromEditorWindow() { }

	// RVA: 0x24C5E40 Offset: 0x24C5040 VA: 0x1824C5E40
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x24C5C90 Offset: 0x24C4E90 VA: 0x1824C5C90
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x24C62A0 Offset: 0x24C54A0 VA: 0x1824C62A0
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x24C4A60 Offset: 0x24C3C60 VA: 0x1824C4A60
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x24C40B0 Offset: 0x24C32B0 VA: 0x1824C40B0
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x24C5470 Offset: 0x24C4670 VA: 0x1824C5470
	internal static void EndLayoutGroup() { }

	// RVA: 0x24C3D20 Offset: 0x24C2F20 VA: 0x1824C3D20
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x24C5270 Offset: 0x24C4470 VA: 0x1824C5270
	internal static void EndLayoutArea() { }

	// RVA: 0x24C5A70 Offset: 0x24C4C70 VA: 0x1824C5A70
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C4E00 Offset: 0x24C4000 VA: 0x1824C4E00
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C59C0 Offset: 0x24C4BC0 VA: 0x1824C59C0
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C4BC0 Offset: 0x24C3DC0 VA: 0x1824C4BC0
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x24C57D0 Offset: 0x24C49D0 VA: 0x1824C57D0
	public static Rect GetLastRect() { }

	// RVA: 0x24C6BF0 Offset: 0x24C5DF0 VA: 0x1824C6BF0
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x24C6AF0 Offset: 0x24C5CF0 VA: 0x1824C6AF0
	private static void .cctor() { }

	// RVA: 0x24C5B10 Offset: 0x24C4D10 VA: 0x1824C5B10
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x24C5BD0 Offset: 0x24C4DD0 VA: 0x1824C5BD0
	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[Serializable]
public sealed class GUISettings // TypeDefIndex: 16877
{
	// Fields
	[SerializeField]
	private bool m_DoubleClickSelectsWord; // 0x10
	[SerializeField]
	private bool m_TripleClickSelectsLine; // 0x11
	[SerializeField]
	private Color m_CursorColor; // 0x14
	[SerializeField]
	private float m_CursorFlashSpeed; // 0x24
	[SerializeField]
	private Color m_SelectionColor; // 0x28

	// Methods

	// RVA: 0x24C9390 Offset: 0x24C8590 VA: 0x1824C9390
	public void .ctor() { }
}

// Namespace: 
internal sealed class GUISkin.SkinChangedDelegate : MulticastDelegate // TypeDefIndex: 16878
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[ExecuteInEditMode]
[RequiredByNativeCode]
[AssetFileNameExtension("guiskin", new[] {  })]
[Serializable]
public sealed class GUISkin : ScriptableObject // TypeDefIndex: 16879
{
	// Fields
	[SerializeField]
	private Font m_Font; // 0x18
	[SerializeField]
	private GUIStyle m_box; // 0x20
	[SerializeField]
	private GUIStyle m_button; // 0x28
	[SerializeField]
	private GUIStyle m_toggle; // 0x30
	[SerializeField]
	private GUIStyle m_label; // 0x38
	[SerializeField]
	private GUIStyle m_textField; // 0x40
	[SerializeField]
	private GUIStyle m_textArea; // 0x48
	[SerializeField]
	private GUIStyle m_window; // 0x50
	[SerializeField]
	private GUIStyle m_horizontalSlider; // 0x58
	[SerializeField]
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	[SerializeField]
	private GUIStyle m_verticalSlider; // 0x70
	[SerializeField]
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	private GUIStyle m_SliderMixed; // 0x88
	[SerializeField]
	private GUIStyle m_horizontalScrollbar; // 0x90
	[SerializeField]
	private GUIStyle m_horizontalScrollbarThumb; // 0x98
	[SerializeField]
	private GUIStyle m_horizontalScrollbarLeftButton; // 0xA0
	[SerializeField]
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA8
	[SerializeField]
	private GUIStyle m_verticalScrollbar; // 0xB0
	[SerializeField]
	private GUIStyle m_verticalScrollbarThumb; // 0xB8
	[SerializeField]
	private GUIStyle m_verticalScrollbarUpButton; // 0xC0
	[SerializeField]
	private GUIStyle m_verticalScrollbarDownButton; // 0xC8
	[SerializeField]
	private GUIStyle m_ScrollView; // 0xD0
	[SerializeField]
	internal GUIStyle[] m_CustomStyles; // 0xD8
	[SerializeField]
	private GUISettings m_Settings; // 0xE0
	internal static GUIStyle ms_Error; // 0x0
	private Dictionary<string, GUIStyle> m_Styles; // 0xE8
	internal static GUISkin.SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Properties
	public Font font { get; set; }
	public GUIStyle box { get; set; }
	public GUIStyle label { get; set; }
	public GUIStyle textField { get; set; }
	public GUIStyle textArea { get; set; }
	public GUIStyle button { get; set; }
	public GUIStyle toggle { get; set; }
	public GUIStyle window { get; set; }
	public GUIStyle horizontalSlider { get; set; }
	public GUIStyle horizontalSliderThumb { get; set; }
	internal GUIStyle horizontalSliderThumbExtent { get; set; }
	internal GUIStyle sliderMixed { get; set; }
	public GUIStyle verticalSlider { get; set; }
	public GUIStyle verticalSliderThumb { get; set; }
	internal GUIStyle verticalSliderThumbExtent { get; set; }
	public GUIStyle horizontalScrollbar { get; set; }
	public GUIStyle horizontalScrollbarThumb { get; set; }
	public GUIStyle horizontalScrollbarLeftButton { get; set; }
	public GUIStyle horizontalScrollbarRightButton { get; set; }
	public GUIStyle verticalScrollbar { get; set; }
	public GUIStyle verticalScrollbarThumb { get; set; }
	public GUIStyle verticalScrollbarUpButton { get; set; }
	public GUIStyle verticalScrollbarDownButton { get; set; }
	public GUIStyle scrollView { get; set; }
	public GUIStyle[] customStyles { get; set; }
	public GUISettings settings { get; }
	internal static GUIStyle error { get; }

	// Methods

	// RVA: 0x24CAB60 Offset: 0x24C9D60 VA: 0x1824CAB60
	public void .ctor() { }

	// RVA: 0x24C93C0 Offset: 0x24C85C0 VA: 0x1824C93C0
	internal void OnEnable() { }

	// RVA: 0x24CA670 Offset: 0x24C9870 VA: 0x1824CA670
	internal static void CleanupRoots() { }

	// RVA: 0x248C210 Offset: 0x248B410 VA: 0x18248C210
	public Font get_font() { }

	// RVA: 0x24CAFE0 Offset: 0x24CA1E0 VA: 0x1824CAFE0
	public void set_font(Font value) { }

	// RVA: 0x2497C30 Offset: 0x2496E30 VA: 0x182497C30
	public GUIStyle get_box() { }

	// RVA: 0x24CAE60 Offset: 0x24CA060 VA: 0x1824CAE60
	public void set_box(GUIStyle value) { }

	// RVA: 0x24CAD90 Offset: 0x24C9F90 VA: 0x1824CAD90
	public GUIStyle get_label() { }

	// RVA: 0x24CB490 Offset: 0x24CA690 VA: 0x1824CB490
	public void set_label(GUIStyle value) { }

	// RVA: 0x24C0D40 Offset: 0x24BFF40 VA: 0x1824C0D40
	public GUIStyle get_textField() { }

	// RVA: 0x24CB690 Offset: 0x24CA890 VA: 0x1824CB690
	public void set_textField(GUIStyle value) { }

	// RVA: 0x24CADD0 Offset: 0x24C9FD0 VA: 0x1824CADD0
	public GUIStyle get_textArea() { }

	// RVA: 0x24CB610 Offset: 0x24CA810 VA: 0x1824CB610
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x248C200 Offset: 0x248B400 VA: 0x18248C200
	public GUIStyle get_button() { }

	// RVA: 0x24CAEE0 Offset: 0x24CA0E0 VA: 0x1824CAEE0
	public void set_button(GUIStyle value) { }

	// RVA: 0x2497C20 Offset: 0x2496E20 VA: 0x182497C20
	public GUIStyle get_toggle() { }

	// RVA: 0x24CB710 Offset: 0x24CA910 VA: 0x1824CB710
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x24CAE50 Offset: 0x24CA050 VA: 0x1824CAE50
	public GUIStyle get_window() { }

	// RVA: 0x24CBB10 Offset: 0x24CAD10 VA: 0x1824CBB10
	public void set_window(GUIStyle value) { }

	// RVA: 0x24CAD80 Offset: 0x24C9F80 VA: 0x1824CAD80
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x24CB410 Offset: 0x24CA610 VA: 0x1824CB410
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x24CAD70 Offset: 0x24C9F70 VA: 0x1824CAD70
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x24CB390 Offset: 0x24CA590 VA: 0x1824CB390
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x24CAD60 Offset: 0x24C9F60 VA: 0x1824CAD60
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x24CB310 Offset: 0x24CA510 VA: 0x1824CB310
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x24CADC0 Offset: 0x24C9FC0 VA: 0x1824CADC0
	internal GUIStyle get_sliderMixed() { }

	// RVA: 0x24CB590 Offset: 0x24CA790 VA: 0x1824CB590
	internal void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x24CAE40 Offset: 0x24CA040 VA: 0x1824CAE40
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x24CBA90 Offset: 0x24CAC90 VA: 0x1824CBA90
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x24CAE30 Offset: 0x24CA030 VA: 0x1824CAE30
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x24CBA10 Offset: 0x24CAC10 VA: 0x1824CBA10
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x24CAE20 Offset: 0x24CA020 VA: 0x1824CAE20
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x24CB990 Offset: 0x24CAB90 VA: 0x1824CB990
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x24CAD50 Offset: 0x24C9F50 VA: 0x1824CAD50
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x24CB290 Offset: 0x24CA490 VA: 0x1824CB290
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x24CAD40 Offset: 0x24C9F40 VA: 0x1824CAD40
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x24CB210 Offset: 0x24CA410 VA: 0x1824CB210
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x24CAD20 Offset: 0x24C9F20 VA: 0x1824CAD20
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x24CB110 Offset: 0x24CA310 VA: 0x1824CB110
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x24CAD30 Offset: 0x24C9F30 VA: 0x1824CAD30
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x24CB190 Offset: 0x24CA390 VA: 0x1824CB190
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x24CAE10 Offset: 0x24CA010 VA: 0x1824CAE10
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x24CB910 Offset: 0x24CAB10 VA: 0x1824CB910
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x24CADF0 Offset: 0x24C9FF0 VA: 0x1824CADF0
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x24CB810 Offset: 0x24CAA10 VA: 0x1824CB810
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x24CAE00 Offset: 0x24CA000 VA: 0x1824CAE00
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x24CB890 Offset: 0x24CAA90 VA: 0x1824CB890
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x24CADE0 Offset: 0x24C9FE0 VA: 0x1824CADE0
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x24CB790 Offset: 0x24CA990 VA: 0x1824CB790
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x24CADA0 Offset: 0x24C9FA0 VA: 0x1824CADA0
	public GUIStyle get_scrollView() { }

	// RVA: 0x24CB510 Offset: 0x24CA710 VA: 0x1824CB510
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x24CAC20 Offset: 0x24C9E20 VA: 0x1824CAC20
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x24CAF60 Offset: 0x24CA160 VA: 0x1824CAF60
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x24CADB0 Offset: 0x24C9FB0 VA: 0x1824CADB0
	public GUISettings get_settings() { }

	// RVA: 0x24CAC30 Offset: 0x24C9E30 VA: 0x1824CAC30
	internal static GUIStyle get_error() { }

	// RVA: 0x24C93C0 Offset: 0x24C85C0 VA: 0x1824C93C0
	internal void Apply() { }

	// RVA: 0x24C9430 Offset: 0x24C8630 VA: 0x1824C9430
	private void BuildStyleCache() { }

	// RVA: 0x24CA810 Offset: 0x24C9A10 VA: 0x1824CA810
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x24CA6C0 Offset: 0x24C98C0 VA: 0x1824CA6C0
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x24CAAA0 Offset: 0x24C9CA0 VA: 0x1824CAAA0
	internal void MakeCurrent() { }

	// RVA: 0x24CA750 Offset: 0x24C9950 VA: 0x1824CA750
	public IEnumerator GetEnumerator() { }
}

// Namespace: UnityEngine
internal class GUIStateObjects // TypeDefIndex: 16880
{
	// Fields
	private static Dictionary<int, object> s_StateCache; // 0x0

	// Methods

	// RVA: 0x24CBB90 Offset: 0x24CAD90 VA: 0x1824CBB90
	internal static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x24CBCF0 Offset: 0x24CAEF0 VA: 0x1824CBCF0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[Serializable]
public sealed class GUIStyleState // TypeDefIndex: 16881
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativeProperty("Background", False, 0)]
	public Texture2D background { set; }
	[NativeProperty("textColor", False, 1)]
	public Color textColor { get; set; }

	// Methods

	// RVA: 0x24CBFB0 Offset: 0x24CB1B0 VA: 0x1824CBFB0
	public void set_background(Texture2D value) { }

	// RVA: 0x24CBF60 Offset: 0x24CB160 VA: 0x1824CBF60
	public Color get_textColor() { }

	// RVA: 0x24CC050 Offset: 0x24CB250 VA: 0x1824CC050
	public void set_textColor(Color value) { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = True)]
	// RVA: 0x24CBEA0 Offset: 0x24CB0A0 VA: 0x1824CBEA0
	private static IntPtr Init() { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x24CBD60 Offset: 0x24CAF60 VA: 0x1824CBD60
	private void Cleanup() { }

	// RVA: 0x24CBED0 Offset: 0x24CB0D0 VA: 0x1824CBED0
	public void .ctor() { }

	// RVA: 0x162EF30 Offset: 0x162E130 VA: 0x18162EF30
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x24CBE30 Offset: 0x24CB030 VA: 0x1824CBE30
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x24CBDA0 Offset: 0x24CAFA0 VA: 0x1824CBDA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24CBF10 Offset: 0x24CB110 VA: 0x1824CBF10
	private void get_textColor_Injected(out Color ret) { }

	// RVA: 0x24CC000 Offset: 0x24CB200 VA: 0x1824CC000
	private void set_textColor_Injected(ref Color value) { }
}

// Namespace: UnityEngine
[NativeHeader("IMGUIScriptingClasses.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[Serializable]
public sealed class GUIStyle // TypeDefIndex: 16882
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private string m_Name; // 0x78
	internal static bool showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	// Properties
	[NativeProperty("Name", False, 0)]
	internal string rawName { get; set; }
	[NativeProperty("Font", False, 0)]
	public Font font { get; set; }
	[NativeProperty("m_ImagePosition", False, 1)]
	public ImagePosition imagePosition { get; }
	[NativeProperty("m_Alignment", False, 1)]
	public TextAnchor alignment { get; set; }
	[NativeProperty("m_WordWrap", False, 1)]
	public bool wordWrap { get; set; }
	[NativeProperty("m_FixedWidth", False, 1)]
	public float fixedWidth { get; }
	[NativeProperty("m_FixedHeight", False, 1)]
	public float fixedHeight { get; }
	[NativeProperty("m_StretchWidth", False, 1)]
	public bool stretchWidth { get; set; }
	[NativeProperty("m_StretchHeight", False, 1)]
	public bool stretchHeight { get; set; }
	[NativeProperty("m_FontSize", False, 1)]
	public int fontSize { get; set; }
	[NativeProperty("m_FontStyle", False, 1)]
	public FontStyle fontStyle { get; set; }
	public string name { get; set; }
	public GUIStyleState normal { get; }
	public RectOffset margin { get; }
	public RectOffset padding { get; }
	public static GUIStyle none { get; }
	public bool isHeightDependantOnWidth { get; }

	// Methods

	// RVA: 0x24CD550 Offset: 0x24CC750 VA: 0x1824CD550
	internal string get_rawName() { }

	// RVA: 0x24CD8A0 Offset: 0x24CCAA0 VA: 0x1824CD8A0
	internal void set_rawName(string value) { }

	// RVA: 0x24CD170 Offset: 0x24CC370 VA: 0x1824CD170
	public Font get_font() { }

	// RVA: 0x24CD800 Offset: 0x24CCA00 VA: 0x1824CD800
	public void set_font(Font value) { }

	// RVA: 0x24CD1B0 Offset: 0x24CC3B0 VA: 0x1824CD1B0
	public ImagePosition get_imagePosition() { }

	// RVA: 0x24CD030 Offset: 0x24CC230 VA: 0x1824CD030
	public TextAnchor get_alignment() { }

	// RVA: 0x24CD740 Offset: 0x24CC940 VA: 0x1824CD740
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x24CD610 Offset: 0x24CC810 VA: 0x1824CD610
	public bool get_wordWrap() { }

	// RVA: 0x24CD990 Offset: 0x24CCB90 VA: 0x1824CD990
	public void set_wordWrap(bool value) { }

	// RVA: 0x24CD0B0 Offset: 0x24CC2B0 VA: 0x1824CD0B0
	public float get_fixedWidth() { }

	// RVA: 0x24CD070 Offset: 0x24CC270 VA: 0x1824CD070
	public float get_fixedHeight() { }

	// RVA: 0x24CD5D0 Offset: 0x24CC7D0 VA: 0x1824CD5D0
	public bool get_stretchWidth() { }

	// RVA: 0x24CD940 Offset: 0x24CCB40 VA: 0x1824CD940
	public void set_stretchWidth(bool value) { }

	// RVA: 0x24CD590 Offset: 0x24CC790 VA: 0x1824CD590
	public bool get_stretchHeight() { }

	// RVA: 0x24CD8F0 Offset: 0x24CCAF0 VA: 0x1824CD8F0
	public void set_stretchHeight(bool value) { }

	// RVA: 0x24CD0F0 Offset: 0x24CC2F0 VA: 0x1824CD0F0
	public int get_fontSize() { }

	// RVA: 0x24CD780 Offset: 0x24CC980 VA: 0x1824CD780
	public void set_fontSize(int value) { }

	// RVA: 0x24CD130 Offset: 0x24CC330 VA: 0x1824CD130
	public FontStyle get_fontStyle() { }

	// RVA: 0x24CD7C0 Offset: 0x24CC9C0 VA: 0x1824CD7C0
	public void set_fontStyle(FontStyle value) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x24CC9E0 Offset: 0x24CBBE0 VA: 0x1824CC9E0
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Copy", IsThreadSafe = True)]
	// RVA: 0x24CC990 Offset: 0x24CBB90 VA: 0x1824CC990
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x24CCA20 Offset: 0x24CBC20 VA: 0x1824CCA20
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x24CC820 Offset: 0x24CBA20 VA: 0x1824CC820
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	// RVA: 0x24CC7E0 Offset: 0x24CB9E0 VA: 0x1824CC7E0
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	// RVA: 0x24CCBD0 Offset: 0x24CBDD0 VA: 0x1824CCBD0
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	// RVA: 0x24CCAD0 Offset: 0x24CBCD0 VA: 0x1824CCAD0
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = True)]
	// RVA: 0x24CC180 Offset: 0x24CB380 VA: 0x1824CC180
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = True)]
	// RVA: 0x24CC0A0 Offset: 0x24CB2A0 VA: 0x1824CC0A0
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = True)]
	// RVA: 0x24CC8C0 Offset: 0x24CBAC0 VA: 0x1824CC8C0
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	// RVA: 0x24CCD30 Offset: 0x24CBF30 VA: 0x1824CCD30
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	// RVA: 0x24CCC60 Offset: 0x24CBE60 VA: 0x1824CCC60
	internal static bool IsTooltipActive(string tooltip) { }

	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	// RVA: 0x24CCCA0 Offset: 0x24CBEA0 VA: 0x1824CCCA0
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x24CCFB0 Offset: 0x24CC1B0 VA: 0x1824CCFB0
	public void .ctor() { }

	// RVA: 0x24CCEE0 Offset: 0x24CC0E0 VA: 0x1824CCEE0
	public void .ctor(GUIStyle other) { }

	// RVA: 0x24CC710 Offset: 0x24CB910 VA: 0x1824CC710 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24CD330 Offset: 0x24CC530 VA: 0x1824CD330
	public string get_name() { }

	// RVA: 0x24CD850 Offset: 0x24CCA50 VA: 0x1824CD850
	public void set_name(string value) { }

	// RVA: 0x24CD410 Offset: 0x24CC610 VA: 0x1824CD410
	public GUIStyleState get_normal() { }

	// RVA: 0x24CD290 Offset: 0x24CC490 VA: 0x1824CD290
	public RectOffset get_margin() { }

	// RVA: 0x24CD4B0 Offset: 0x24CC6B0 VA: 0x1824CD4B0
	public RectOffset get_padding() { }

	// RVA: 0x24CC350 Offset: 0x24CB550 VA: 0x1824CC350
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x24CC2C0 Offset: 0x24CB4C0 VA: 0x1824CC2C0
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x24CC430 Offset: 0x24CB630 VA: 0x1824CC430
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x24CC4F0 Offset: 0x24CB6F0 VA: 0x1824CC4F0
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x24CC1E0 Offset: 0x24CB3E0 VA: 0x1824CC1E0
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x24CD650 Offset: 0x24CC850 VA: 0x1824CD650
	public static GUIStyle op_Implicit(string str) { }

	// RVA: 0x24CD370 Offset: 0x24CC570 VA: 0x1824CD370
	public static GUIStyle get_none() { }

	// RVA: 0x24CC180 Offset: 0x24CB380 VA: 0x1824CC180
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x24CC0A0 Offset: 0x24CB2A0 VA: 0x1824CC0A0
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x24CD1F0 Offset: 0x24CC3F0 VA: 0x1824CD1F0
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x24CC100 Offset: 0x24CB300 VA: 0x1824CC100
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x24CCDB0 Offset: 0x24CBFB0 VA: 0x1824CCDB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x24CCEA0 Offset: 0x24CC0A0 VA: 0x1824CCEA0
	private static void .cctor() { }

	// RVA: 0x24CCB40 Offset: 0x24CBD40 VA: 0x1824CCB40
	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x24CCA60 Offset: 0x24CBC60 VA: 0x1824CCA60
	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x24CC920 Offset: 0x24CBB20 VA: 0x1824CC920
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x24CC860 Offset: 0x24CBA60 VA: 0x1824CC860
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x24CCCE0 Offset: 0x24CBEE0 VA: 0x1824CCCE0
	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }
}

// Namespace: UnityEngine
public enum ImagePosition // TypeDefIndex: 16883
{
	// Fields
	public int value__; // 0x0
	public const ImagePosition ImageLeft = 0;
	public const ImagePosition ImageAbove = 1;
	public const ImagePosition ImageOnly = 2;
	public const ImagePosition TextOnly = 3;
}

// Namespace: UnityEngine
[Usage(64)]
public class GUITargetAttribute : Attribute // TypeDefIndex: 16884
{
	// Fields
	internal int displayMask; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24CD9E0 Offset: 0x24CCBE0 VA: 0x1824CD9E0
	private static int GetGUITargetAttrValue(Type klass, string methodName) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
[NativeHeader("Runtime/Utilities/CopyPaste.h")]
[NativeHeader("Runtime/Input/InputBindings.h")]
[NativeHeader("Modules/IMGUI/GUIManager.h")]
[NativeHeader("Modules/IMGUI/GUIUtility.h")]
public class GUIUtility // TypeDefIndex: 16885
{
	// Fields
	internal static int s_ControlCount; // 0x0
	internal static int s_SkinMode; // 0x4
	internal static int s_OriginalID; // 0x8
	internal static Action takeCapture; // 0x10
	internal static Action releaseCapture; // 0x18
	internal static Func<int, IntPtr, bool> processEvent; // 0x20
	internal static Action cleanupRoots; // 0x28
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x30
	internal static Action guiChanged; // 0x38
	internal static Action<EventType, KeyCode> beforeEventProcessed; // 0x40
	private static Event m_Event; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <guiIsExiting>k__BackingField; // 0x50
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x58

	// Properties
	[NativeProperty("GetGUIState().m_PixelsPerPoint", True, 1)]
	internal static float pixelsPerPoint { get; }
	[NativeProperty("GetGUIState().m_OnGUIDepth", True, 1)]
	internal static int guiDepth { get; }
	[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", True, 1)]
	internal static bool mouseUsed { set; }
	[StaticAccessor("GetInputManager()", 0)]
	internal static bool textFieldInput { get; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessor("InputBindings", 2)]
	internal static string compositionString { get; }
	[StaticAccessor("InputBindings", 2)]
	internal static IMECompositionMode imeCompositionMode { set; }
	[StaticAccessor("InputBindings", 2)]
	internal static Vector2 compositionCursorPos { set; }
	internal static bool guiIsExiting { set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }

	// Methods

	// RVA: 0x24CF990 Offset: 0x24CEB90 VA: 0x1824CF990
	internal static float get_pixelsPerPoint() { }

	// RVA: 0x24CF8A0 Offset: 0x24CEAA0 VA: 0x1824CF8A0
	internal static int get_guiDepth() { }

	// RVA: 0x24CFC50 Offset: 0x24CEE50 VA: 0x1824CFC50
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x24CF9F0 Offset: 0x24CEBF0 VA: 0x1824CF9F0
	internal static bool get_textFieldInput() { }

	[FreeFunction("GetCopyBuffer")]
	// RVA: 0x24CF9C0 Offset: 0x24CEBC0 VA: 0x1824CF9C0
	public static string get_systemCopyBuffer() { }

	[FreeFunction("SetCopyBuffer")]
	// RVA: 0x24CFC90 Offset: 0x24CEE90 VA: 0x1824CFC90
	public static void set_systemCopyBuffer(string value) { }

	[FreeFunction("GetGUIState().GetControlID")]
	// RVA: 0x24CEF40 Offset: 0x24CE140 VA: 0x1824CEF40
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x24CE780 Offset: 0x24CD980 VA: 0x1824CE780
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x24CDD80 Offset: 0x24CCF80 VA: 0x1824CDD80
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	// RVA: 0x24CDDC0 Offset: 0x24CCFC0 VA: 0x1824CDDC0
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethod("EndContainer")]
	// RVA: 0x24CEE90 Offset: 0x24CE090 VA: 0x1824CEE90
	internal static void Internal_EndContainer() { }

	// RVA: 0x24CDFD0 Offset: 0x24CD1D0 VA: 0x1824CDFD0
	internal static int CheckForTabEvent(Event evt) { }

	// RVA: 0x24CF650 Offset: 0x24CE850 VA: 0x1824CF650
	internal static void SetKeyboardControlToFirstControlId() { }

	// RVA: 0x24CF680 Offset: 0x24CE880 VA: 0x1824CF680
	internal static void SetKeyboardControlToLastControlId() { }

	// RVA: 0x24CEA80 Offset: 0x24CDC80 VA: 0x1824CEA80
	internal static bool HasFocusableControls() { }

	// RVA: 0x24CF1D0 Offset: 0x24CE3D0 VA: 0x1824CF1D0
	internal static bool OwnsId(int id) { }

	// RVA: 0x24CDC00 Offset: 0x24CCE00 VA: 0x1824CDC00
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	// RVA: 0x24CF870 Offset: 0x24CEA70 VA: 0x1824CF870
	internal static string get_compositionString() { }

	// RVA: 0x24CFBA0 Offset: 0x24CEDA0 VA: 0x1824CFBA0
	internal static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x24CFA60 Offset: 0x24CEC60 VA: 0x1824CFA60
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x24CF000 Offset: 0x24CE200 VA: 0x1824CF000
	private static int Internal_GetHotControl() { }

	// RVA: 0x24CF030 Offset: 0x24CE230 VA: 0x1824CF030
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x24CF060 Offset: 0x24CE260 VA: 0x1824CF060
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x24CF0A0 Offset: 0x24CE2A0 VA: 0x1824CF0A0
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x24CEFC0 Offset: 0x24CE1C0 VA: 0x1824CEFC0
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x24CEEC0 Offset: 0x24CE0C0 VA: 0x1824CEEC0
	private static void Internal_ExitGUI() { }

	[RequiredByNativeCode]
	// RVA: 0x24CF160 Offset: 0x24CE360 VA: 0x1824CF160
	private static void MarkGUIChanged() { }

	// RVA: 0x24CE700 Offset: 0x24CD900 VA: 0x1824CE700
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x24CE8F0 Offset: 0x24CDAF0 VA: 0x1824CE8F0
	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGenerated]
	// RVA: 0x24CFAD0 Offset: 0x24CECD0 VA: 0x1824CFAD0
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x24CF8D0 Offset: 0x24CEAD0 VA: 0x1824CF8D0
	public static int get_hotControl() { }

	// RVA: 0x24CFB30 Offset: 0x24CED30 VA: 0x1824CFB30
	public static void set_hotControl(int value) { }

	[RequiredByNativeCode]
	// RVA: 0x24CF760 Offset: 0x24CE960 VA: 0x1824CF760
	internal static void TakeCapture() { }

	[RequiredByNativeCode]
	// RVA: 0x24CF400 Offset: 0x24CE600 VA: 0x1824CF400
	internal static void RemoveCapture() { }

	// RVA: 0x24CF930 Offset: 0x24CEB30 VA: 0x1824CF930
	public static int get_keyboardControl() { }

	// RVA: 0x24CFBE0 Offset: 0x24CEDE0 VA: 0x1824CFBE0
	public static void set_keyboardControl(int value) { }

	// RVA: 0x24CEAB0 Offset: 0x24CDCB0 VA: 0x1824CEAB0
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x24CE6C0 Offset: 0x24CD8C0 VA: 0x1824CE6C0
	public static void ExitGUI() { }

	// RVA: 0x24CE850 Offset: 0x24CDA50 VA: 0x1824CE850
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCode]
	// RVA: 0x24CF210 Offset: 0x24CE410 VA: 0x1824CF210
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) { }

	// RVA: 0x24CE250 Offset: 0x24CD450 VA: 0x1824CE250
	internal static void EndContainer() { }

	[RequiredByNativeCode]
	// RVA: 0x24CDE00 Offset: 0x24CD000 VA: 0x1824CDE00
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCode]
	// RVA: 0x24CE0D0 Offset: 0x24CD2D0 VA: 0x1824CE0D0
	internal static void DestroyGUI(int instanceID) { }

	[RequiredByNativeCode]
	// RVA: 0x24CE3D0 Offset: 0x24CD5D0 VA: 0x1824CE3D0
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCode]
	// RVA: 0x24CE2D0 Offset: 0x24CD4D0 VA: 0x1824CE2D0
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCode]
	// RVA: 0x24CE1B0 Offset: 0x24CD3B0 VA: 0x1824CE1B0
	internal static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x24CF470 Offset: 0x24CE670 VA: 0x1824CF470
	internal static void ResetGlobalState() { }

	// RVA: 0x24CF0E0 Offset: 0x24CE2E0 VA: 0x1824CF0E0
	internal static bool IsExitGUIException(Exception exception) { }

	// RVA: 0x24CF6B0 Offset: 0x24CE8B0 VA: 0x1824CF6B0
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x24CE010 Offset: 0x24CD210 VA: 0x1824CE010
	internal static void CheckOnGUI() { }

	// RVA: 0x24CF5A0 Offset: 0x24CE7A0 VA: 0x1824CF5A0
	internal static float RoundToPixelGrid(float v) { }

	// RVA: 0x24CDCA0 Offset: 0x24CCEA0 VA: 0x1824CDCA0
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x24CED50 Offset: 0x24CDF50 VA: 0x1824CED50
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x24CEDD0 Offset: 0x24CDFD0 VA: 0x1824CEDD0
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x24CEBD0 Offset: 0x24CDDD0 VA: 0x1824CEBD0
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x24CF7D0 Offset: 0x24CE9D0 VA: 0x1824CF7D0
	private static void .cctor() { }

	// RVA: 0x24CEEF0 Offset: 0x24CE0F0 VA: 0x1824CEEF0
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0x24CDB90 Offset: 0x24CCD90 VA: 0x1824CDB90
	private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	// RVA: 0x24CFA20 Offset: 0x24CEC20 VA: 0x1824CFA20
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }
}

// Namespace: UnityEngine
public sealed class ExitGUIException : Exception // TypeDefIndex: 16886
{
	// Methods

	// RVA: 0x24BF1C0 Offset: 0x24BE3C0 VA: 0x1824BF1C0
	public void .ctor() { }

	// RVA: 0x24BF280 Offset: 0x24BE480 VA: 0x1824BF280
	internal void .ctor(string message) { }
}

// Namespace: UnityEngine
internal class GUILayoutEntry // TypeDefIndex: 16887
{
	// Fields
	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

	// Properties
	public GUIStyle style { get; set; }
	public virtual int marginLeft { get; }
	public virtual int marginRight { get; }
	public virtual int marginTop { get; }
	public virtual int marginBottom { get; }
	public int marginHorizontal { get; }
	public int marginVertical { get; }

	// Methods

	// RVA: 0x24C0D40 Offset: 0x24BFF40 VA: 0x1824C0D40
	public GUIStyle get_style() { }

	// RVA: 0x24C0D50 Offset: 0x24BFF50 VA: 0x1824C0D50
	public void set_style(GUIStyle value) { }

	// RVA: 0x24C0C60 Offset: 0x24BFE60 VA: 0x1824C0C60 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x24C0C90 Offset: 0x24BFE90 VA: 0x1824C0C90 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x24C0CC0 Offset: 0x24BFEC0 VA: 0x1824C0CC0 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x24C0BE0 Offset: 0x24BFDE0 VA: 0x1824C0BE0 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x24C0C10 Offset: 0x24BFE10 VA: 0x1824C0C10
	public int get_marginHorizontal() { }

	// RVA: 0x24C0CF0 Offset: 0x24BFEF0 VA: 0x1824C0CF0
	public int get_marginVertical() { }

	// RVA: 0x24C0A00 Offset: 0x24BFC00 VA: 0x1824C0A00
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x24C0AF0 Offset: 0x24BFCF0 VA: 0x1824C0AF0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x24C0490 Offset: 0x24BF690 VA: 0x1824C0490 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x24C04A0 Offset: 0x24BF6A0 VA: 0x1824C04A0 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x24C0380 Offset: 0x24BF580 VA: 0x1824C0380 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x24BFFB0 Offset: 0x24BF1B0 VA: 0x1824BFFB0 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x24C04B0 Offset: 0x24BF6B0 VA: 0x1824C04B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x24C09A0 Offset: 0x24BFBA0 VA: 0x1824C09A0
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal sealed class GUIWordWrapSizer : GUILayoutEntry // TypeDefIndex: 16888
{
	// Fields
	private readonly GUIContent m_Content; // 0x48
	private readonly float m_ForcedMinHeight; // 0x50
	private readonly float m_ForcedMaxHeight; // 0x54

	// Methods

	// RVA: 0x24CFE80 Offset: 0x24CF080 VA: 0x1824CFE80
	public void .ctor(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	// RVA: 0x24CFDA0 Offset: 0x24CEFA0 VA: 0x1824CFDA0 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x24CFCD0 Offset: 0x24CEED0 VA: 0x1824CFCD0 Slot: 9
	public override void CalcHeight() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 16889
{
	// Fields
	public List<GUILayoutEntry> entries; // 0x48
	public bool isVertical; // 0x50
	public bool resetCoords; // 0x51
	public float spacing; // 0x54
	public bool sameSize; // 0x58
	public bool isWindow; // 0x59
	public int windowID; // 0x5C
	private int m_Cursor; // 0x60
	protected int m_StretchableCountX; // 0x64
	protected int m_StretchableCountY; // 0x68
	protected bool m_UserSpecifiedWidth; // 0x6C
	protected bool m_UserSpecifiedHeight; // 0x6D
	protected float m_ChildMinWidth; // 0x70
	protected float m_ChildMaxWidth; // 0x74
	protected float m_ChildMinHeight; // 0x78
	protected float m_ChildMaxHeight; // 0x7C
	protected int m_MarginLeft; // 0x80
	protected int m_MarginRight; // 0x84
	protected int m_MarginTop; // 0x88
	protected int m_MarginBottom; // 0x8C
	private static readonly GUILayoutEntry none; // 0x0

	// Properties
	public override int marginLeft { get; }
	public override int marginRight { get; }
	public override int marginTop { get; }
	public override int marginBottom { get; }

	// Methods

	// RVA: 0x1A6BA60 Offset: 0x1A6AC60 VA: 0x181A6BA60 Slot: 4
	public override int get_marginLeft() { }

	// RVA: 0x772260 Offset: 0x771460 VA: 0x180772260 Slot: 5
	public override int get_marginRight() { }

	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950 Slot: 6
	public override int get_marginTop() { }

	// RVA: 0x772310 Offset: 0x771510 VA: 0x180772310 Slot: 7
	public override int get_marginBottom() { }

	// RVA: 0x24C39D0 Offset: 0x24C2BD0 VA: 0x1824C39D0
	public void .ctor() { }

	// RVA: 0x24C0E10 Offset: 0x24C0010 VA: 0x1824C0E10 Slot: 13
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x24C0F50 Offset: 0x24C0150 VA: 0x1824C0F50 Slot: 12
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x24C2570 Offset: 0x24C1770 VA: 0x1824C2570
	public void ResetCursor() { }

	// RVA: 0x24C2280 Offset: 0x24C1480 VA: 0x1824C2280
	public GUILayoutEntry GetNext() { }

	// RVA: 0x24C1EF0 Offset: 0x24C10F0 VA: 0x1824C1EF0
	public Rect GetLast() { }

	// RVA: 0x24C0D70 Offset: 0x24BFF70 VA: 0x1824C0D70
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x24C17A0 Offset: 0x24C09A0 VA: 0x1824C17A0 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x24C2580 Offset: 0x24C1780 VA: 0x1824C2580 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x24C10B0 Offset: 0x24C02B0 VA: 0x1824C10B0 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x24C2D60 Offset: 0x24C1F60 VA: 0x1824C2D60 Slot: 11
	public override void SetVertical(float y, float height) { }

	// RVA: 0x24C3540 Offset: 0x24C2740 VA: 0x1824C3540 Slot: 3
	public override string ToString() { }

	// RVA: 0x24C3880 Offset: 0x24C2A80 VA: 0x1824C3880
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 16890
{
	// Fields
	public float calcMinWidth; // 0x90
	public float calcMaxWidth; // 0x94
	public float calcMinHeight; // 0x98
	public float calcMaxHeight; // 0x9C
	public float clientWidth; // 0xA0
	public float clientHeight; // 0xA4
	public bool allowHorizontalScroll; // 0xA8
	public bool allowVerticalScroll; // 0xA9
	public bool needsHorizontalScrollbar; // 0xAA
	public bool needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24D7850 Offset: 0x24D6A50 VA: 0x1824D7850
	public void .ctor() { }

	// RVA: 0x24D7420 Offset: 0x24D6620 VA: 0x1824D7420 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x24D74C0 Offset: 0x24D66C0 VA: 0x1824D74C0 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x24D7300 Offset: 0x24D6500 VA: 0x1824D7300 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x24D7610 Offset: 0x24D6810 VA: 0x1824D7610 Slot: 11
	public override void SetVertical(float y, float height) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIState.h")]
internal class ObjectGUIState : IDisposable // TypeDefIndex: 16891
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x24D7AC0 Offset: 0x24D6CC0 VA: 0x1824D7AC0
	public void .ctor() { }

	// RVA: 0x24D7910 Offset: 0x24D6B10 VA: 0x1824D7910 Slot: 4
	public void Dispose() { }

	// RVA: 0x24D79B0 Offset: 0x24D6BB0 VA: 0x1824D79B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24D78B0 Offset: 0x24D6AB0 VA: 0x1824D78B0
	private void Destroy() { }

	// RVA: 0x24D7A50 Offset: 0x24D6C50 VA: 0x1824D7A50
	private static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x24D7A80 Offset: 0x24D6C80 VA: 0x1824D7A80
	private static void Internal_Destroy(IntPtr ptr) { }
}

// Namespace: UnityEngine
internal class ScrollViewState // TypeDefIndex: 16892
{
	// Fields
	public Rect position; // 0x10
	public Rect visibleRect; // 0x20
	public Rect viewRect; // 0x30
	public Vector2 scrollPosition; // 0x40
	public bool apply; // 0x48
	public bool isDuringTouchScroll; // 0x49
	public Vector2 touchScrollStartMousePosition; // 0x4C
	public Vector2 touchScrollStartPosition; // 0x54
	public Vector2 velocity; // 0x5C
	public float previousTimeSinceStartup; // 0x64

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
internal class SliderState // TypeDefIndex: 16893
{
	// Fields
	public float dragStartPos; // 0x10
	public float dragStartValue; // 0x14
	public bool isDragging; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
internal struct SliderHandler // TypeDefIndex: 16894
{
	// Fields
	private readonly Rect position; // 0x0
	private readonly float currentValue; // 0x10
	private readonly float size; // 0x14
	private readonly float start; // 0x18
	private readonly float end; // 0x1C
	private readonly GUIStyle slider; // 0x20
	private readonly GUIStyle thumb; // 0x28
	private readonly GUIStyle thumbExtent; // 0x30
	private readonly bool horiz; // 0x38
	private readonly int id; // 0x3C

	// Methods

	// RVA: 0x24D94D0 Offset: 0x24D86D0 VA: 0x1824D94D0
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x24D7C40 Offset: 0x24D6E40 VA: 0x1824D7C40
	public float Handle() { }

	// RVA: 0x24D7FA0 Offset: 0x24D71A0 VA: 0x1824D7FA0
	private float OnMouseDown() { }

	// RVA: 0x24D8460 Offset: 0x24D7660 VA: 0x1824D8460
	private float OnMouseDrag() { }

	// RVA: 0x24D85A0 Offset: 0x24D77A0 VA: 0x1824D85A0
	private float OnMouseUp() { }

	// RVA: 0x24D8630 Offset: 0x24D7830 VA: 0x1824D8630
	private float OnRepaint() { }

	// RVA: 0x24D7B60 Offset: 0x24D6D60 VA: 0x1824D7B60
	private EventType CurrentEventType() { }

	// RVA: 0x24D7BA0 Offset: 0x24D6DA0 VA: 0x1824D7BA0
	private int CurrentScrollTroughSide() { }

	// RVA: 0x24D7ED0 Offset: 0x24D70D0 VA: 0x1824D7ED0
	private bool IsEmptySlider() { }

	// RVA: 0x24D8EA0 Offset: 0x24D80A0 VA: 0x1824D8EA0
	private bool SupportsPageMovements() { }

	// RVA: 0x24D8BD0 Offset: 0x24D7DD0 VA: 0x1824D8BD0
	private float PageMovementValue() { }

	// RVA: 0x24D8CE0 Offset: 0x24D7EE0 VA: 0x1824D8CE0
	private float PageUpMovementBound() { }

	// RVA: 0x24D7B90 Offset: 0x24D6D90 VA: 0x1824D7B90
	private Event CurrentEvent() { }

	// RVA: 0x24D9100 Offset: 0x24D8300 VA: 0x1824D9100
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x24D7B00 Offset: 0x24D6D00 VA: 0x1824D7B00
	private float Clamp(float value) { }

	// RVA: 0x24D8FF0 Offset: 0x24D81F0 VA: 0x1824D8FF0
	private Rect ThumbSelectionRect() { }

	// RVA: 0x24D8E40 Offset: 0x24D8040 VA: 0x1824D8E40
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x24D8D40 Offset: 0x24D7F40 VA: 0x1824D8D40
	private SliderState SliderState() { }

	// RVA: 0x24D8F00 Offset: 0x24D8100 VA: 0x1824D8F00
	private Rect ThumbExtRect() { }

	// RVA: 0x24D8FF0 Offset: 0x24D81F0 VA: 0x1824D8FF0
	private Rect ThumbRect() { }

	// RVA: 0x24D92F0 Offset: 0x24D84F0 VA: 0x1824D92F0
	private Rect VerticalThumbRect() { }

	// RVA: 0x24D7CF0 Offset: 0x24D6EF0 VA: 0x1824D7CF0
	private Rect HorizontalThumbRect() { }

	// RVA: 0x24D7B30 Offset: 0x24D6D30 VA: 0x1824D7B30
	private float ClampedCurrentValue() { }

	// RVA: 0x24D7F20 Offset: 0x24D7120 VA: 0x1824D7F20
	private float MousePosition() { }

	// RVA: 0x24D9230 Offset: 0x24D8430 VA: 0x1824D9230
	private float ValuesPerPixel() { }

	// RVA: 0x24D9040 Offset: 0x24D8240 VA: 0x1824D9040
	private float ThumbSize() { }

	// RVA: 0x24D7EF0 Offset: 0x24D70F0 VA: 0x1824D7EF0
	private float MaxValue() { }

	// RVA: 0x24D7F10 Offset: 0x24D7110 VA: 0x1824D7F10
	private float MinValue() { }
}

// Namespace: UnityEngine
internal enum TextEditOp // TypeDefIndex: 16895
{
	// Fields
	public int value__; // 0x0
	public const TextEditOp MoveLeft = 0;
	public const TextEditOp MoveRight = 1;
	public const TextEditOp MoveUp = 2;
	public const TextEditOp MoveDown = 3;
	public const TextEditOp MoveLineStart = 4;
	public const TextEditOp MoveLineEnd = 5;
	public const TextEditOp MoveTextStart = 6;
	public const TextEditOp MoveTextEnd = 7;
	public const TextEditOp MovePageUp = 8;
	public const TextEditOp MovePageDown = 9;
	public const TextEditOp MoveGraphicalLineStart = 10;
	public const TextEditOp MoveGraphicalLineEnd = 11;
	public const TextEditOp MoveWordLeft = 12;
	public const TextEditOp MoveWordRight = 13;
	public const TextEditOp MoveParagraphForward = 14;
	public const TextEditOp MoveParagraphBackward = 15;
	public const TextEditOp MoveToStartOfNextWord = 16;
	public const TextEditOp MoveToEndOfPreviousWord = 17;
	public const TextEditOp Delete = 18;
	public const TextEditOp Backspace = 19;
	public const TextEditOp DeleteWordBack = 20;
	public const TextEditOp DeleteWordForward = 21;
	public const TextEditOp DeleteLineBack = 22;
	public const TextEditOp Cut = 23;
	public const TextEditOp Paste = 24;
	public const TextEditOp ScrollStart = 25;
	public const TextEditOp ScrollEnd = 26;
	public const TextEditOp ScrollPageUp = 27;
	public const TextEditOp ScrollPageDown = 28;
}

// Namespace: UnityEngine
internal enum TextSelectOp // TypeDefIndex: 16896
{
	// Fields
	public int value__; // 0x0
	public const TextSelectOp SelectLeft = 0;
	public const TextSelectOp SelectRight = 1;
	public const TextSelectOp SelectUp = 2;
	public const TextSelectOp SelectDown = 3;
	public const TextSelectOp SelectTextStart = 4;
	public const TextSelectOp SelectTextEnd = 5;
	public const TextSelectOp SelectPageUp = 6;
	public const TextSelectOp SelectPageDown = 7;
	public const TextSelectOp ExpandSelectGraphicalLineStart = 8;
	public const TextSelectOp ExpandSelectGraphicalLineEnd = 9;
	public const TextSelectOp SelectGraphicalLineStart = 10;
	public const TextSelectOp SelectGraphicalLineEnd = 11;
	public const TextSelectOp SelectWordLeft = 12;
	public const TextSelectOp SelectWordRight = 13;
	public const TextSelectOp SelectToEndOfPreviousWord = 14;
	public const TextSelectOp SelectToStartOfNextWord = 15;
	public const TextSelectOp SelectParagraphBackward = 16;
	public const TextSelectOp SelectParagraphForward = 17;
	public const TextSelectOp Copy = 18;
	public const TextSelectOp SelectAll = 19;
	public const TextSelectOp SelectNone = 20;
}

// Namespace: UnityEngine
internal class TextEditingUtilities // TypeDefIndex: 16897
{
	// Fields
	private TextSelectingUtilities m_TextSelectingUtility; // 0x10
	private TextHandle m_TextHandle; // 0x18
	private int m_CursorIndexSavedState; // 0x20
	internal bool isCompositionActive; // 0x24
	private bool m_UpdateImeWindowPosition; // 0x25
	public bool multiline; // 0x26
	private string m_Text; // 0x28
	private static Dictionary<Event, TextEditOp> s_KeyEditOps; // 0x0

	// Properties
	private bool hasSelection { get; }
	internal bool revealCursor { set; }
	private int cursorIndex { get; set; }
	private int selectIndex { get; set; }
	public string text { get; set; }

	// Methods

	// RVA: 0x24DBB20 Offset: 0x24DAD20 VA: 0x1824DBB20
	private bool get_hasSelection() { }

	// RVA: 0x24DBBE0 Offset: 0x24DADE0 VA: 0x1824DBBE0
	internal void set_revealCursor(bool value) { }

	// RVA: 0x24DBAF0 Offset: 0x24DACF0 VA: 0x1824DBAF0
	private int get_cursorIndex() { }

	// RVA: 0x24DBBA0 Offset: 0x24DADA0 VA: 0x1824DBBA0
	private void set_cursorIndex(int value) { }

	// RVA: 0x24DBB70 Offset: 0x24DAD70 VA: 0x1824DBB70
	private int get_selectIndex() { }

	// RVA: 0x24DBC20 Offset: 0x24DAE20 VA: 0x1824DBC20
	private void set_selectIndex(int value) { }

	// RVA: 0x248C200 Offset: 0x248B400 VA: 0x18248C200
	public string get_text() { }

	// RVA: 0x24DBC60 Offset: 0x24DAE60 VA: 0x1824DBC60
	public void set_text(string value) { }

	// RVA: 0x24DBA90 Offset: 0x24DAC90 VA: 0x1824DBA90
	public void .ctor(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	// RVA: 0x24DB9F0 Offset: 0x24DABF0 VA: 0x1824DB9F0
	public bool UpdateImeState() { }

	// RVA: 0x24DB980 Offset: 0x24DAB80 VA: 0x1824DB980
	public bool ShouldUpdateImeWindowPosition() { }

	// RVA: 0x24DB8B0 Offset: 0x24DAAB0 VA: 0x1824DB8B0
	public void SetImeWindowPosition(Vector2 worldPosition) { }

	// RVA: 0x24DA170 Offset: 0x24D9370 VA: 0x1824DA170
	public string GeneratePreviewString(bool richText) { }

	// RVA: 0x24DA090 Offset: 0x24D9290 VA: 0x1824DA090
	public void EnableCursorPreviewState() { }

	// RVA: 0x24DB830 Offset: 0x24DAA30 VA: 0x1824DB830
	public void RestoreCursorState() { }

	[VisibleToOtherModules]
	// RVA: 0x24DA280 Offset: 0x24D9480 VA: 0x1824DA280
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x24DACA0 Offset: 0x24D9EA0 VA: 0x1824DACA0
	private void PerformOperation(TextEditOp operation) { }

	// RVA: 0x24DAA60 Offset: 0x24D9C60 VA: 0x1824DAA60
	private static void MapKey(string key, TextEditOp action) { }

	// RVA: 0x24DA3A0 Offset: 0x24D95A0 VA: 0x1824DA3A0
	private void InitKeyActions() { }

	// RVA: 0x24D9750 Offset: 0x24D8950 VA: 0x1824D9750
	public bool DeleteLineBack() { }

	// RVA: 0x24D9C00 Offset: 0x24D8E00 VA: 0x1824D9C00
	public bool DeleteWordBack() { }

	// RVA: 0x24D9DB0 Offset: 0x24D8FB0 VA: 0x1824D9DB0
	public bool DeleteWordForward() { }

	// RVA: 0x24D9F20 Offset: 0x24D9120 VA: 0x1824D9F20
	public bool Delete() { }

	// RVA: 0x24D9530 Offset: 0x24D8730 VA: 0x1824D9530
	public bool Backspace() { }

	// RVA: 0x24D9910 Offset: 0x24D8B10 VA: 0x1824D9910
	public bool DeleteSelection() { }

	// RVA: 0x24DB720 Offset: 0x24DA920 VA: 0x1824DB720
	public void ReplaceSelection(string replace) { }

	// RVA: 0x24DAA00 Offset: 0x24D9C00 VA: 0x1824DAA00
	public void Insert(char c) { }

	// RVA: 0x24D96C0 Offset: 0x24D88C0 VA: 0x1824D96C0
	public bool CanPaste() { }

	// RVA: 0x24D9720 Offset: 0x24D8920 VA: 0x1824D9720
	public bool Cut() { }

	// RVA: 0x24DAB70 Offset: 0x24D9D70 VA: 0x1824DAB70
	public bool Paste() { }

	// RVA: 0x24DB690 Offset: 0x24DA890 VA: 0x1824DB690
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x24DAAF0 Offset: 0x24D9CF0 VA: 0x1824DAAF0
	internal void OnBlur() { }

	// RVA: 0x24DB990 Offset: 0x24DAB90 VA: 0x1824DB990
	internal bool TouchScreenKeyboardShouldBeUsed() { }
}

// Namespace: 
public enum TextEditor.DblClickSnapping // TypeDefIndex: 16898
{
	// Fields
	public byte value__; // 0x0
	public const TextEditor.DblClickSnapping WORDS = 0;
	public const TextEditor.DblClickSnapping PARAGRAPHS = 1;
}

// Namespace: UnityEngine
public class TextEditor // TypeDefIndex: 16899
{
	// Fields
	public TouchScreenKeyboard keyboardOnScreen; // 0x10
	public int controlID; // 0x18
	public GUIStyle style; // 0x20
	public bool multiline; // 0x28
	public bool hasHorizontalCursorPos; // 0x29
	public bool isPasswordField; // 0x2A
	public Vector2 scrollOffset; // 0x2C
	private GUIContent m_Content; // 0x38
	private int m_CursorIndex; // 0x40
	private int m_SelectIndex; // 0x44
	private bool m_RevealCursor; // 0x48
	private bool m_MouseDragSelectsWholeWords; // 0x49
	private int m_DblClickInitPos; // 0x4C
	private TextEditor.DblClickSnapping m_DblClickSnap; // 0x50
	private bool m_bJustSelected; // 0x51
	private int m_iAltCursorPos; // 0x54

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24DBCD0 Offset: 0x24DAED0 VA: 0x1824DBCD0
	public void .ctor() { }
}

// Namespace: 
private enum TextSelectingUtilities.CharacterType // TypeDefIndex: 16900
{
	// Fields
	public int value__; // 0x0
	public const TextSelectingUtilities.CharacterType LetterLike = 0;
	public const TextSelectingUtilities.CharacterType Symbol = 1;
	public const TextSelectingUtilities.CharacterType Symbol2 = 2;
	public const TextSelectingUtilities.CharacterType WhiteSpace = 3;
	public const TextSelectingUtilities.CharacterType NewLine = 4;
}

// Namespace: 
private enum TextSelectingUtilities.Direction // TypeDefIndex: 16901
{
	// Fields
	public int value__; // 0x0
	public const TextSelectingUtilities.Direction Forward = 0;
	public const TextSelectingUtilities.Direction Backward = 1;
}

// Namespace: UnityEngine
internal class TextSelectingUtilities // TypeDefIndex: 16902
{
	// Fields
	public TextEditor.DblClickSnapping dblClickSnap; // 0x10
	public int iAltCursorPos; // 0x14
	public bool hasHorizontalCursorPos; // 0x18
	private bool m_bJustSelected; // 0x19
	private bool m_MouseDragSelectsWholeWords; // 0x1A
	private int m_DblClickInitPosStart; // 0x1C
	private int m_DblClickInitPosEnd; // 0x20
	private TextHandle m_TextHandle; // 0x28
	private const int kMoveDownHeight = 5;
	private const char kNewLineChar = '\xa';
	private bool m_RevealCursor; // 0x30
	private int m_CursorIndex; // 0x34
	internal int m_SelectIndex; // 0x38
	private static Dictionary<Event, TextSelectOp> s_KeySelectOps; // 0x0
	internal Action OnCursorIndexChange; // 0x40
	internal Action OnSelectIndexChange; // 0x48
	internal Action OnRevealCursorChange; // 0x50

	// Properties
	public bool hasSelection { get; }
	public bool revealCursor { get; set; }
	private int m_CharacterCount { get; }
	private int characterCount { get; }
	private TextElementInfo[] m_TextElementInfos { get; }
	public int cursorIndex { get; set; }
	public int selectIndex { get; set; }
	public string selectedText { get; }

	// Methods

	// RVA: 0x24DFE20 Offset: 0x24DF020 VA: 0x1824DFE20
	public bool get_hasSelection() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_revealCursor() { }

	// RVA: 0x24E0010 Offset: 0x24DF210 VA: 0x1824E0010
	public void set_revealCursor(bool value) { }

	// RVA: 0x24DFE60 Offset: 0x24DF060 VA: 0x1824DFE60
	private int get_m_CharacterCount() { }

	// RVA: 0x24DFD30 Offset: 0x24DEF30 VA: 0x1824DFD30
	private int get_characterCount() { }

	// RVA: 0x24DFE90 Offset: 0x24DF090 VA: 0x1824DFE90
	private TextElementInfo[] get_m_TextElementInfos() { }

	// RVA: 0x24DFE10 Offset: 0x24DF010 VA: 0x1824DFE10
	public int get_cursorIndex() { }

	// RVA: 0x24DFFE0 Offset: 0x24DF1E0 VA: 0x1824DFFE0
	public void set_cursorIndex(int value) { }

	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	internal void SetCursorIndexWithoutNotify(int index) { }

	// RVA: 0x24DFEC0 Offset: 0x24DF0C0 VA: 0x1824DFEC0
	public int get_selectIndex() { }

	// RVA: 0x24E0040 Offset: 0x24DF240 VA: 0x1824E0040
	public void set_selectIndex(int value) { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	internal void SetSelectIndexWithoutNotify(int index) { }

	// RVA: 0x24DFED0 Offset: 0x24DF0D0 VA: 0x1824DFED0
	public string get_selectedText() { }

	// RVA: 0x24DFCE0 Offset: 0x24DEEE0 VA: 0x1824DFCE0
	public void .ctor(TextHandle textHandle) { }

	// RVA: 0x24DCA20 Offset: 0x24DBC20 VA: 0x1824DCA20
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x24DE280 Offset: 0x24DD480 VA: 0x1824DE280
	private bool PerformOperation(TextSelectOp operation) { }

	// RVA: 0x24DD0C0 Offset: 0x24DC2C0 VA: 0x1824DD0C0
	private static void MapKey(string key, TextSelectOp action) { }

	// RVA: 0x24DCB70 Offset: 0x24DBD70 VA: 0x1824DCB70
	private void InitKeyActions() { }

	// RVA: 0x24DBF50 Offset: 0x24DB150 VA: 0x1824DBF50
	public void ClearCursorPos() { }

	// RVA: 0x24DE1F0 Offset: 0x24DD3F0 VA: 0x1824DE1F0
	public void OnFocus(bool selectAll = True) { }

	// RVA: 0x24DE960 Offset: 0x24DDB60 VA: 0x1824DE960
	public void SelectAll() { }

	// RVA: 0x24DF000 Offset: 0x24DE200 VA: 0x1824DF000
	public void SelectNone() { }

	// RVA: 0x24DEF20 Offset: 0x24DE120 VA: 0x1824DEF20
	public void SelectLeft() { }

	// RVA: 0x24DF2D0 Offset: 0x24DE4D0 VA: 0x1824DF2D0
	public void SelectRight() { }

	// RVA: 0x24DF9E0 Offset: 0x24DEBE0 VA: 0x1824DF9E0
	public void SelectUp() { }

	// RVA: 0x24DEE00 Offset: 0x24DE000 VA: 0x1824DEE00
	public void SelectDown() { }

	// RVA: 0x24DF3B0 Offset: 0x24DE5B0 VA: 0x1824DF3B0
	public void SelectTextEnd() { }

	// RVA: 0x24DF3F0 Offset: 0x24DE5F0 VA: 0x1824DF3F0
	public void SelectTextStart() { }

	// RVA: 0x24DF980 Offset: 0x24DEB80 VA: 0x1824DF980
	public void SelectToStartOfNextWord() { }

	// RVA: 0x24DF420 Offset: 0x24DE620 VA: 0x1824DF420
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x24DFB90 Offset: 0x24DED90 VA: 0x1824DFB90
	public void SelectWordRight() { }

	// RVA: 0x24DFA40 Offset: 0x24DEC40 VA: 0x1824DFA40
	public void SelectWordLeft() { }

	// RVA: 0x24DEEC0 Offset: 0x24DE0C0 VA: 0x1824DEEC0
	public void SelectGraphicalLineStart() { }

	// RVA: 0x24DEE60 Offset: 0x24DE060 VA: 0x1824DEE60
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x24DF1A0 Offset: 0x24DE3A0 VA: 0x1824DF1A0
	public void SelectParagraphForward() { }

	// RVA: 0x24DF050 Offset: 0x24DE250 VA: 0x1824DF050
	public void SelectParagraphBackward() { }

	// RVA: 0x24DEAD0 Offset: 0x24DDCD0 VA: 0x1824DEAD0
	public void SelectCurrentWord() { }

	// RVA: 0x24DE9D0 Offset: 0x24DDBD0 VA: 0x1824DE9D0
	public void SelectCurrentParagraph() { }

	// RVA: 0x24DDA70 Offset: 0x24DCC70 VA: 0x1824DDA70
	public void MoveRight() { }

	// RVA: 0x24DD4E0 Offset: 0x24DC6E0 VA: 0x1824DD4E0
	public void MoveLeft() { }

	// RVA: 0x24DDD80 Offset: 0x24DCF80 VA: 0x1824DDD80
	public void MoveUp() { }

	// RVA: 0x24DD280 Offset: 0x24DC480 VA: 0x1824DD280
	public void MoveDown() { }

	// RVA: 0x24DD720 Offset: 0x24DC920 VA: 0x1824DD720
	public void MoveLineStart() { }

	// RVA: 0x24DD5D0 Offset: 0x24DC7D0 VA: 0x1824DD5D0
	public void MoveLineEnd() { }

	// RVA: 0x24DD440 Offset: 0x24DC640 VA: 0x1824DD440
	public void MoveGraphicalLineStart() { }

	// RVA: 0x24DD3A0 Offset: 0x24DC5A0 VA: 0x1824DD3A0
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x24DDBC0 Offset: 0x24DCDC0 VA: 0x1824DDBC0
	public void MoveTextStart() { }

	// RVA: 0x24DDB60 Offset: 0x24DCD60 VA: 0x1824DDB60
	public void MoveTextEnd() { }

	// RVA: 0x24DD960 Offset: 0x24DCB60 VA: 0x1824DD960
	public void MoveParagraphForward() { }

	// RVA: 0x24DD860 Offset: 0x24DCA60 VA: 0x1824DD860
	public void MoveParagraphBackward() { }

	// RVA: 0x24DDFE0 Offset: 0x24DD1E0 VA: 0x1824DDFE0
	public void MoveWordRight() { }

	// RVA: 0x24DDCD0 Offset: 0x24DCED0 VA: 0x1824DDCD0
	public void MoveToStartOfNextWord() { }

	// RVA: 0x24DDC20 Offset: 0x24DCE20 VA: 0x1824DDC20
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x24DDE90 Offset: 0x24DD090 VA: 0x1824DDE90
	public void MoveWordLeft() { }

	// RVA: 0x24DD150 Offset: 0x24DC350 VA: 0x1824DD150
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x24DC290 Offset: 0x24DB490 VA: 0x1824DC290
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x24DC1C0 Offset: 0x24DB3C0 VA: 0x1824DC1C0
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	// RVA: 0x24DD1F0 Offset: 0x24DC3F0 VA: 0x1824DD1F0
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x24DF480 Offset: 0x24DE680 VA: 0x1824DF480
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x24DC570 Offset: 0x24DB770 VA: 0x1824DC570
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x24DC5F0 Offset: 0x24DB7F0 VA: 0x1824DC5F0
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x24DC690 Offset: 0x24DB890 VA: 0x1824DC690
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x24DC480 Offset: 0x24DB680 VA: 0x1824DC480
	public int FindEndOfPreviousWord(int p) { }

	// RVA: 0x24DC360 Offset: 0x24DB560 VA: 0x1824DC360
	private int FindEndOfClassification(int p, TextSelectingUtilities.Direction dir) { }

	// RVA: 0x24DBDD0 Offset: 0x24DAFD0 VA: 0x1824DBDD0
	private int ClampTextIndex(int index) { }

	// RVA: 0x24DC0D0 Offset: 0x24DB2D0 VA: 0x1824DC0D0
	internal int EnsureValidCodePointIndex(int index) { }

	// RVA: 0x24DCFE0 Offset: 0x24DC1E0 VA: 0x1824DCFE0
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x24DCB30 Offset: 0x24DBD30 VA: 0x1824DCB30
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x24DE880 Offset: 0x24DDA80 VA: 0x1824DE880
	public int PreviousCodePointIndex(int index) { }

	// RVA: 0x24DE110 Offset: 0x24DD310 VA: 0x1824DE110
	public int NextCodePointIndex(int index) { }

	// RVA: 0x24DC970 Offset: 0x24DBB70 VA: 0x1824DC970
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x24DC8B0 Offset: 0x24DBAB0 VA: 0x1824DC8B0
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x24DBF60 Offset: 0x24DB160 VA: 0x1824DBF60
	public void Copy() { }

	// RVA: 0x24DBE00 Offset: 0x24DB000 VA: 0x1824DBE00
	private TextSelectingUtilities.CharacterType ClassifyChar(int index) { }
}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16903
{
	// Methods

	// RVA: 0x840E00 Offset: 0x840000 VA: 0x180840E00
	internal static uint ComputeStringHash(string s) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16904
{}

// Namespace: Hazel
[DefaultMember("Item")]
public struct ByteSpan // TypeDefIndex: 16905
{
	// Fields
	private readonly byte[] array_; // 0x0
	[CompilerGenerated]
	private readonly int <Offset>k__BackingField; // 0x8
	[CompilerGenerated]
	private readonly int <Length>k__BackingField; // 0xC

	// Properties
	public int Offset { get; }
	public int Length { get; }
	public byte Item { get; set; }
	public static ByteSpan Empty { get; }

	// Methods

	// RVA: 0x151EF60 Offset: 0x151E160 VA: 0x18151EF60
	public void .ctor(byte[] array) { }

	// RVA: 0x151EC50 Offset: 0x151DE50 VA: 0x18151EC50
	public void .ctor(byte[] array, int offset, int length) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public byte[] GetUnderlyingArray() { }

	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_Offset() { }

	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_Length() { }

	// RVA: 0x151EFA0 Offset: 0x151E1A0 VA: 0x18151EFA0
	public byte get_Item(int index) { }

	// RVA: 0x151F050 Offset: 0x151E250 VA: 0x18151F050
	public void set_Item(int index, byte value) { }

	// RVA: 0x151EAA0 Offset: 0x151DCA0 VA: 0x18151EAA0
	public ByteSpan Slice(int offset) { }

	// RVA: 0x151EA60 Offset: 0x151DC60 VA: 0x18151EA60
	public ByteSpan Slice(int offset, int length) { }

	// RVA: 0x151E8D0 Offset: 0x151DAD0 VA: 0x18151E8D0
	public void CopyTo(byte[] array, int offset) { }

	// RVA: 0x151E9B0 Offset: 0x151DBB0 VA: 0x18151E9B0
	public void CopyTo(ByteSpan destination) { }

	// RVA: 0x151EAF0 Offset: 0x151DCF0 VA: 0x18151EAF0
	public byte[] ToArray() { }

	// RVA: 0x151EBF0 Offset: 0x151DDF0 VA: 0x18151EBF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x151F020 Offset: 0x151E220 VA: 0x18151F020
	public static ByteSpan op_Implicit(byte[] array) { }

	// RVA: 0x151EF90 Offset: 0x151E190 VA: 0x18151EF90
	public static ByteSpan get_Empty() { }
}

// Namespace: Hazel
[Extension]
public static class ByteSpanBigEndianExtensions // TypeDefIndex: 16906
{
	// Methods

	[Extension]
	// RVA: 0x151DC20 Offset: 0x151CE20 VA: 0x18151DC20
	public static void WriteBigEndian16(ByteSpan output, ushort value, int offset = 0) { }

	[Extension]
	// RVA: 0x151DCD0 Offset: 0x151CED0 VA: 0x18151DCD0
	public static void WriteBigEndian24(ByteSpan output, uint value, int offset = 0) { }

	[Extension]
	// RVA: 0x151DDF0 Offset: 0x151CFF0 VA: 0x18151DDF0
	public static void WriteBigEndian32(ByteSpan output, uint value, int offset) { }

	[Extension]
	// RVA: 0x151DF90 Offset: 0x151D190 VA: 0x18151DF90
	public static void WriteBigEndian48(ByteSpan output, ulong value, int offset = 0) { }

	[Extension]
	// RVA: 0x151E220 Offset: 0x151D420 VA: 0x18151E220
	public static void WriteBigEndian64(ByteSpan output, ulong value, int offset = 0) { }

	[Extension]
	// RVA: 0x151D7E0 Offset: 0x151C9E0 VA: 0x18151D7E0
	public static ushort ReadBigEndian16(ByteSpan input, int offset = 0) { }

	[Extension]
	// RVA: 0x151D880 Offset: 0x151CA80 VA: 0x18151D880
	public static uint ReadBigEndian24(ByteSpan input, int offset = 0) { }

	[Extension]
	// RVA: 0x151D990 Offset: 0x151CB90 VA: 0x18151D990
	public static ulong ReadBigEndian48(ByteSpan input, int offset = 0) { }
}

// Namespace: Hazel
[Extension]
public static class ByteSpanLittleEndianExtensions // TypeDefIndex: 16907
{
	// Methods

	[Extension]
	// RVA: 0x151E590 Offset: 0x151D790 VA: 0x18151E590
	public static uint ReadLittleEndian24(ByteSpan input, int offset = 0) { }

	[Extension]
	// RVA: 0x151E6A0 Offset: 0x151D8A0 VA: 0x18151E6A0
	public static uint ReadLittleEndian32(ByteSpan input, int offset = 0) { }

	[Extension]
	// RVA: 0x151E820 Offset: 0x151DA20 VA: 0x18151E820
	public static ByteSpan ReuseSpanIfPossible(ByteSpan source, int requiredSize) { }
}

// Namespace: Hazel
public abstract class Connection : IDisposable // TypeDefIndex: 16908
{
	// Fields
	[CompilerGenerated]
	private Action<DataReceivedEventArgs> DataReceived; // 0x10
	public int TestLagMs; // 0x18
	public int TestDropRate; // 0x1C
	protected int testDropCount; // 0x20
	[CompilerGenerated]
	private EventHandler<DisconnectedEventArgs> Disconnected; // 0x28
	[CompilerGenerated]
	private IPEndPoint <EndPoint>k__BackingField; // 0x30
	[CompilerGenerated]
	private IPMode <IPMode>k__BackingField; // 0x38
	[CompilerGenerated]
	private ConnectionStatistics <Statistics>k__BackingField; // 0x40
	protected ConnectionState _state; // 0x48

	// Properties
	public IPEndPoint EndPoint { get; set; }
	public IPMode IPMode { get; set; }
	public ConnectionStatistics Statistics { get; set; }
	public ConnectionState State { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1520610 Offset: 0x151F810 VA: 0x181520610
	public void add_DataReceived(Action<DataReceivedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1520770 Offset: 0x151F970 VA: 0x181520770
	public void remove_DataReceived(Action<DataReceivedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x15206C0 Offset: 0x151F8C0 VA: 0x1815206C0
	public void add_Disconnected(EventHandler<DisconnectedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1520820 Offset: 0x151FA20 VA: 0x181520820
	public void remove_Disconnected(EventHandler<DisconnectedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public IPEndPoint get_EndPoint() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	protected void set_EndPoint(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public IPMode get_IPMode() { }

	[CompilerGenerated]
	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	protected void set_IPMode(IPMode value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public ConnectionStatistics get_Statistics() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	protected void set_Statistics(ConnectionStatistics value) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public ConnectionState get_State() { }

	// RVA: 0x15208D0 Offset: 0x151FAD0 VA: 0x1815208D0
	protected void set_State(ConnectionState value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void SetState(ConnectionState state) { }

	// RVA: 0x1520580 Offset: 0x151F780 VA: 0x181520580
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract SendErrors Send(MessageWriter msg);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ConnectAsync(byte[] bytes);

	// RVA: 0x1520420 Offset: 0x151F620 VA: 0x181520420
	protected void InvokeDataReceived(MessageReader msg, SendOption sendOption) { }

	// RVA: 0x15204B0 Offset: 0x151F6B0 VA: 0x1815204B0
	protected void InvokeDisconnected(string e, MessageReader reader) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Disconnect(string reason, MessageWriter writer);

	// RVA: 0x15203B0 Offset: 0x151F5B0 VA: 0x1815203B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x15203A0 Offset: 0x151F5A0 VA: 0x1815203A0 Slot: 9
	protected virtual void Dispose(bool disposing) { }
}

// Namespace: 
public sealed class ConnectionListener.AcceptConnectionCheck : MulticastDelegate // TypeDefIndex: 16909
{
	// Methods

	// RVA: 0x10DCA30 Offset: 0x10DBC30 VA: 0x1810DCA30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual bool Invoke(IPEndPoint endPoint, byte[] input, out byte[] response) { }
}

// Namespace: Hazel
public abstract class ConnectionListener : IDisposable // TypeDefIndex: 16910
{
	// Fields
	public int ReceiveBufferSize; // 0x10
	public readonly ListenerStatistics Statistics; // 0x18
	public ConnectionListener.AcceptConnectionCheck AcceptConnection; // 0x20
	[CompilerGenerated]
	private Action<NewConnectionEventArgs> NewConnection; // 0x28
	[CompilerGenerated]
	private Action<HazelInternalErrors> OnInternalError; // 0x30

	// Methods

	[CompilerGenerated]
	// RVA: 0x151FEB0 Offset: 0x151F0B0 VA: 0x18151FEB0
	public void add_NewConnection(Action<NewConnectionEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1520010 Offset: 0x151F210 VA: 0x181520010
	public void remove_NewConnection(Action<NewConnectionEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x151FF60 Offset: 0x151F160 VA: 0x18151FF60
	public void add_OnInternalError(Action<HazelInternalErrors> value) { }

	[CompilerGenerated]
	// RVA: 0x15200C0 Offset: 0x151F2C0 VA: 0x1815200C0
	public void remove_OnInternalError(Action<HazelInternalErrors> value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Start();

	// RVA: 0x151FE00 Offset: 0x151F000 VA: 0x18151FE00
	protected void InvokeNewConnection(MessageReader msg, Connection connection) { }

	// RVA: 0x151FDD0 Offset: 0x151EFD0 VA: 0x18151FDD0
	protected void InvokeInternalError(HazelInternalErrors reason) { }

	// RVA: 0x151FDB0 Offset: 0x151EFB0 VA: 0x18151FDB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x151FDA0 Offset: 0x151EFA0 VA: 0x18151FDA0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x151FE40 Offset: 0x151F040 VA: 0x18151FE40
	protected void .ctor() { }
}

// Namespace: Hazel
public enum ConnectionState // TypeDefIndex: 16911
{
	// Fields
	public int value__; // 0x0
	public const ConnectionState NotConnected = 0;
	public const ConnectionState Connecting = 1;
	public const ConnectionState Connected = 2;
}

// Namespace: Hazel
public class ConnectionStatistics // TypeDefIndex: 16912
{
	// Fields
	private const int ExpectedMTU = 1200;
	private int packetsSent; // 0x10
	private int reliablePacketsAcknowledged; // 0x14
	private int fragmentableMessagesSent; // 0x18
	private int unreliableMessagesSent; // 0x1C
	private int reliableMessagesSent; // 0x20
	private int fragmentedMessagesSent; // 0x24
	private int acknowledgementMessagesSent; // 0x28
	private int helloMessagesSent; // 0x2C
	private long dataBytesSent; // 0x30
	private long totalBytesSent; // 0x38
	private int unreliableMessagesReceived; // 0x40
	private int reliableMessagesReceived; // 0x44
	private int fragmentedMessagesReceived; // 0x48
	private int acknowledgementMessagesReceived; // 0x4C
	private int pingMessagesReceived; // 0x50
	private int helloMessagesReceived; // 0x54
	private long dataBytesReceived; // 0x58
	private long totalBytesReceived; // 0x60
	private int messagesResent; // 0x68

	// Properties
	public long TotalBytesSent { get; }
	public long TotalBytesReceived { get; }
	public int MessagesResent { get; }

	// Methods

	// RVA: 0x1520390 Offset: 0x151F590 VA: 0x181520390
	public long get_TotalBytesSent() { }

	// RVA: 0x1520380 Offset: 0x151F580 VA: 0x181520380
	public long get_TotalBytesReceived() { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80
	public int get_MessagesResent() { }

	// RVA: 0x1520340 Offset: 0x151F540 VA: 0x181520340
	internal void LogUnreliableSend(int dataLength) { }

	// RVA: 0x1520200 Offset: 0x151F400 VA: 0x181520200
	internal void LogPacketSend(int totalLength) { }

	// RVA: 0x15202B0 Offset: 0x151F4B0 VA: 0x1815202B0
	internal void LogReliableSend(int dataLength) { }

	// RVA: 0x15202F0 Offset: 0x151F4F0 VA: 0x1815202F0
	internal void LogUnreliableReceive(int dataLength, int totalLength) { }

	// RVA: 0x1520260 Offset: 0x151F460 VA: 0x181520260
	internal void LogReliableReceive(int dataLength, int totalLength) { }

	// RVA: 0x1520170 Offset: 0x151F370 VA: 0x181520170
	internal void LogAcknowledgementReceive(int totalLength) { }

	// RVA: 0x1520250 Offset: 0x151F450 VA: 0x181520250
	internal void LogReliablePacketAcknowledged() { }

	// RVA: 0x15201B0 Offset: 0x151F3B0 VA: 0x1815201B0
	internal void LogHelloReceive(int totalLength) { }

	// RVA: 0x15201F0 Offset: 0x151F3F0 VA: 0x1815201F0
	internal void LogMessageResent() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Hazel
public struct DataReceivedEventArgs // TypeDefIndex: 16913
{
	// Fields
	public readonly Connection Sender; // 0x0
	public readonly MessageReader Message; // 0x8
	public readonly SendOption SendOption; // 0x10

	// Methods

	// RVA: 0x1520BC0 Offset: 0x151FDC0 VA: 0x181520BC0
	public void .ctor(Connection sender, MessageReader msg, SendOption sendOption) { }
}

// Namespace: Hazel
public class DisconnectedEventArgs : EventArgs // TypeDefIndex: 16914
{
	// Fields
	public readonly string Reason; // 0x10
	public readonly MessageReader Message; // 0x18

	// Methods

	// RVA: 0x1520FE0 Offset: 0x15201E0 VA: 0x181520FE0
	public void .ctor(string reason, MessageReader message) { }
}

// Namespace: Hazel
[Extension]
public static class Extensions // TypeDefIndex: 16915
{
	// Methods

	[Extension]
	// RVA: 0x15261E0 Offset: 0x15253E0 VA: 0x1815261E0
	public static int ClampToInt(float value, int min, int max) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static bool TryDequeue<T>(Queue<T> self, out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9ACFA0 Offset: 0x9AC1A0 VA: 0x1809ACFA0
	|-Extensions.TryDequeue<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x9AD0A0 Offset: 0x9AC2A0 VA: 0x1809AD0A0
	|-Extensions.TryDequeue<DtlsUnityConnection.QueuedAppData>
	*/
}

// Namespace: Hazel
[Serializable]
public class HazelException : Exception // TypeDefIndex: 16916
{
	// Methods

	// RVA: 0x1526800 Offset: 0x1525A00 VA: 0x181526800
	internal void .ctor(string msg) { }

	// RVA: 0x1526790 Offset: 0x1525990 VA: 0x181526790
	internal void .ctor(string msg, Exception e) { }
}

// Namespace: Hazel
public enum IPMode // TypeDefIndex: 16917
{
	// Fields
	public int value__; // 0x0
	public const IPMode IPv4 = 0;
	public const IPMode IPv6 = 1;
}

// Namespace: Hazel
public interface IRecyclable // TypeDefIndex: 16918
{}

// Namespace: Hazel
public class ListenerStatistics // TypeDefIndex: 16919
{
	// Fields
	private int _receiveThreadBlocked; // 0x10
	private long _bytesSent; // 0x18

	// Methods

	// RVA: 0x1526A90 Offset: 0x1525C90 VA: 0x181526A90
	internal void AddBytesSent(long bytes) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MessageReader.<>c // TypeDefIndex: 16920
{
	// Fields
	public static readonly MessageReader.<>c <>9; // 0x0

	// Methods

	// RVA: 0x152C080 Offset: 0x152B280 VA: 0x18152C080
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x152BFA0 Offset: 0x152B1A0 VA: 0x18152BFA0
	internal MessageReader <.cctor>b__44_0() { }
}

// Namespace: Hazel
public class MessageReader : IRecyclable // TypeDefIndex: 16921
{
	// Fields
	public static readonly ObjectPool<MessageReader> ReaderPool; // 0x0
	public byte[] Buffer; // 0x10
	public byte Tag; // 0x18
	public int Length; // 0x1C
	public int Offset; // 0x20
	private MessageReader Parent; // 0x28
	private int _position; // 0x30
	private int readHead; // 0x34

	// Properties
	public int BytesRemaining { get; }
	public int Position { get; set; }

	// Methods

	// RVA: 0x1527CB0 Offset: 0x1526EB0 VA: 0x181527CB0
	public int get_BytesRemaining() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int get_Position() { }

	// RVA: 0x1527CC0 Offset: 0x1526EC0 VA: 0x181527CC0
	public void set_Position(int value) { }

	// RVA: 0x1526AE0 Offset: 0x1525CE0 VA: 0x181526AE0
	public static MessageReader GetSized(int minSize) { }

	// RVA: 0x1526BC0 Offset: 0x1525DC0 VA: 0x181526BC0
	public static MessageReader Get(byte[] buffer) { }

	// RVA: 0x1526C60 Offset: 0x1525E60 VA: 0x181526C60
	public static MessageReader Get(MessageReader source) { }

	// RVA: 0x1527470 Offset: 0x1526670 VA: 0x181527470
	public MessageReader ReadMessage() { }

	// RVA: 0x1527210 Offset: 0x1526410 VA: 0x181527210
	public MessageReader ReadMessageAsNewBuffer() { }

	// RVA: 0x1527B30 Offset: 0x1526D30 VA: 0x181527B30 Slot: 4
	public void Recycle() { }

	// RVA: 0x1526D30 Offset: 0x1525F30 VA: 0x181526D30
	public bool ReadBoolean() { }

	// RVA: 0x1526AA0 Offset: 0x1525CA0 VA: 0x181526AA0
	public sbyte ReadSByte() { }

	// RVA: 0x1526AA0 Offset: 0x1525CA0 VA: 0x181526AA0
	public byte ReadByte() { }

	// RVA: 0x15270D0 Offset: 0x15262D0 VA: 0x1815270D0
	public ushort ReadUInt16() { }

	// RVA: 0x15270D0 Offset: 0x15262D0 VA: 0x1815270D0
	public short ReadInt16() { }

	// RVA: 0x1527140 Offset: 0x1526340 VA: 0x181527140
	public uint ReadUInt32() { }

	// RVA: 0x1527140 Offset: 0x1526340 VA: 0x181527140
	public int ReadInt32() { }

	// RVA: 0x1527950 Offset: 0x1526B50 VA: 0x181527950
	public ulong ReadUInt64() { }

	// RVA: 0x15277C0 Offset: 0x15269C0 VA: 0x1815277C0
	public float ReadSingle() { }

	// RVA: 0x1527830 Offset: 0x1526A30 VA: 0x181527830
	public string ReadString() { }

	// RVA: 0x1526D70 Offset: 0x1525F70 VA: 0x181526D70
	public byte[] ReadBytesAndSize() { }

	// RVA: 0x1526F80 Offset: 0x1526180 VA: 0x181526F80
	public byte[] ReadBytes(int length) { }

	// RVA: 0x1527700 Offset: 0x1526900 VA: 0x181527700
	public int ReadPackedInt32() { }

	// RVA: 0x1527700 Offset: 0x1526900 VA: 0x181527700
	public uint ReadPackedUInt32() { }

	// RVA: 0x1526AA0 Offset: 0x1525CA0 VA: 0x181526AA0
	private byte FastByte() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1527BC0 Offset: 0x1526DC0 VA: 0x181527BC0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MessageWriter.<>c // TypeDefIndex: 16922
{
	// Fields
	public static readonly MessageWriter.<>c <>9; // 0x0

	// Methods

	// RVA: 0x152C140 Offset: 0x152B340 VA: 0x18152C140
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x152BEC0 Offset: 0x152B0C0 VA: 0x18152BEC0
	internal MessageWriter <.cctor>b__42_0() { }
}

// Namespace: Hazel
public class MessageWriter : IRecyclable // TypeDefIndex: 16923
{
	// Fields
	public static int BufferSize; // 0x0
	public static readonly ObjectPool<MessageWriter> WriterPool; // 0x8
	public byte[] Buffer; // 0x10
	public int Length; // 0x18
	public int Position; // 0x1C
	[CompilerGenerated]
	private SendOption <SendOption>k__BackingField; // 0x20
	private Stack<int> messageStarts; // 0x28

	// Properties
	public SendOption SendOption { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public SendOption get_SendOption() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	private void set_SendOption(SendOption value) { }

	// RVA: 0x1528B30 Offset: 0x1527D30 VA: 0x181528B30
	public void .ctor(int bufferSize) { }

	// RVA: 0x1528170 Offset: 0x1527370 VA: 0x181528170
	public byte[] ToByteArray(bool includeHeader) { }

	// RVA: 0x1527EE0 Offset: 0x15270E0 VA: 0x181527EE0
	public static MessageWriter Get(SendOption sendOption = 0) { }

	// RVA: 0x1528000 Offset: 0x1527200 VA: 0x181528000
	public bool HasBytes(int expected) { }

	// RVA: 0x15280A0 Offset: 0x15272A0 VA: 0x1815280A0
	public void StartMessage(byte typeFlag) { }

	// RVA: 0x1527E50 Offset: 0x1527050 VA: 0x181527E50
	public void EndMessage() { }

	// RVA: 0x1527CD0 Offset: 0x1526ED0 VA: 0x181527CD0
	public void CancelMessage() { }

	// RVA: 0x1527D20 Offset: 0x1526F20 VA: 0x181527D20
	public void Clear(SendOption sendOption) { }

	// RVA: 0x1528020 Offset: 0x1527220 VA: 0x181528020 Slot: 4
	public void Recycle() { }

	// RVA: 0x1527DE0 Offset: 0x1526FE0 VA: 0x181527DE0
	public void CopyFrom(MessageReader target) { }

	// RVA: 0x15289D0 Offset: 0x1527BD0 VA: 0x1815289D0
	public void Write(bool value) { }

	// RVA: 0x1528700 Offset: 0x1527900 VA: 0x181528700
	public void Write(sbyte value) { }

	// RVA: 0x1528700 Offset: 0x1527900 VA: 0x181528700
	public void Write(byte value) { }

	// RVA: 0x15288F0 Offset: 0x1527AF0 VA: 0x1815288F0
	public void Write(ushort value) { }

	// RVA: 0x1528380 Offset: 0x1527580 VA: 0x181528380
	public void Write(uint value) { }

	// RVA: 0x1528830 Offset: 0x1527A30 VA: 0x181528830
	public void Write(int value) { }

	// RVA: 0x1528440 Offset: 0x1527640 VA: 0x181528440
	public void Write(ulong value) { }

	// RVA: 0x1528960 Offset: 0x1527B60 VA: 0x181528960
	public void Write(float value) { }

	// RVA: 0x1528750 Offset: 0x1527950 VA: 0x181528750
	public void Write(string value) { }

	// RVA: 0x1528270 Offset: 0x1527470 VA: 0x181528270
	public void WriteBytesAndSize(byte[] bytes) { }

	// RVA: 0x15285C0 Offset: 0x15277C0 VA: 0x1815285C0
	public void Write(byte[] bytes) { }

	// RVA: 0x15286B0 Offset: 0x15278B0 VA: 0x1815286B0
	public void Write(byte[] bytes, int offset, int length) { }

	// RVA: 0x1528320 Offset: 0x1527520 VA: 0x181528320
	public void WritePacked(int value) { }

	// RVA: 0x1528320 Offset: 0x1527520 VA: 0x181528320
	public void WritePacked(uint value) { }

	// RVA: 0x1528620 Offset: 0x1527820 VA: 0x181528620
	public void Write(MessageWriter msg, bool includeHeader) { }

	// RVA: 0x1528A20 Offset: 0x1527C20 VA: 0x181528A20
	private static void .cctor() { }
}

// Namespace: Hazel
public enum HazelInternalErrors // TypeDefIndex: 16924
{
	// Fields
	public int value__; // 0x0
	public const HazelInternalErrors SocketExceptionSend = 0;
	public const HazelInternalErrors SocketExceptionReceive = 1;
	public const HazelInternalErrors ReceivedZeroBytes = 2;
	public const HazelInternalErrors PingsWithoutResponse = 3;
	public const HazelInternalErrors ReliablePacketWithoutResponse = 4;
	public const HazelInternalErrors ConnectionDisconnected = 5;
	public const HazelInternalErrors DtlsNegotiationFailed = 6;
}

// Namespace: Hazel
public abstract class NetworkConnection : Connection // TypeDefIndex: 16925
{
	// Fields
	public Func<HazelInternalErrors, MessageWriter> OnInternalDisconnect; // 0x50
	[CompilerGenerated]
	private readonly float <AveragePingMs>k__BackingField; // 0x58

	// Properties
	public virtual float AveragePingMs { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1529A10 Offset: 0x1528C10 VA: 0x181529A10 Slot: 10
	public virtual float get_AveragePingMs() { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract bool SendDisconnect(MessageWriter writer);

	// RVA: 0x15298A0 Offset: 0x1528AA0 VA: 0x1815298A0
	protected void DisconnectRemote(string reason, MessageReader reader) { }

	// RVA: 0x15297D0 Offset: 0x15289D0 VA: 0x1815297D0
	internal void DisconnectInternal(HazelInternalErrors error, string reason) { }

	// RVA: 0x1529960 Offset: 0x1528B60 VA: 0x181529960 Slot: 8
	public override void Disconnect(string reason, MessageWriter writer) { }

	// RVA: 0x1520580 Offset: 0x151F780 VA: 0x181520580
	protected void .ctor() { }
}

// Namespace: Hazel
public abstract class NetworkConnectionListener : ConnectionListener // TypeDefIndex: 16926
{
	// Fields
	[CompilerGenerated]
	private IPEndPoint <EndPoint>k__BackingField; // 0x38
	[CompilerGenerated]
	private IPMode <IPMode>k__BackingField; // 0x40

	// Properties
	public IPEndPoint EndPoint { get; set; }
	public IPMode IPMode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public IPEndPoint get_EndPoint() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	protected void set_EndPoint(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public IPMode get_IPMode() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	protected void set_IPMode(IPMode value) { }

	// RVA: 0x151FE40 Offset: 0x151F040 VA: 0x18151FE40
	protected void .ctor() { }
}

// Namespace: Hazel
public struct NewConnectionEventArgs // TypeDefIndex: 16927
{
	// Fields
	public readonly MessageReader HandshakeData; // 0x0
	public readonly Connection Connection; // 0x8

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(MessageReader handshakeData, Connection connection) { }
}

// Namespace: Hazel
public sealed class ObjectPool<T> // TypeDefIndex: 16928
{
	// Fields
	private int numberCreated; // 0x0
	private readonly List<T> pool; // 0x0
	private readonly ConcurrentDictionary<T, bool> inuse; // 0x0
	private readonly Func<T> objectFactory; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Func<T> objectFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB78970 Offset: 0xB77B70 VA: 0x180B78970
	|-ObjectPool<object>..ctor
	|
	|-RVA: 0xB77F40 Offset: 0xB77140 VA: 0x180B77F40
	|-ObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T GetObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB76D50 Offset: 0xB75F50 VA: 0x180B76D50
	|-ObjectPool<object>.GetObject
	|
	|-RVA: 0xB76950 Offset: 0xB75B50 VA: 0x180B76950
	|-ObjectPool<__Il2CppFullySharedGenericType>.GetObject
	*/

	// RVA: -1 Offset: -1
	internal void PutObject(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB775A0 Offset: 0xB767A0 VA: 0x180B775A0
	|-ObjectPool<object>.PutObject
	|
	|-RVA: 0xB776E0 Offset: 0xB768E0 VA: 0x180B776E0
	|-ObjectPool<__Il2CppFullySharedGenericType>.PutObject
	*/
}

// Namespace: Hazel
[Flags]
public enum SendErrors // TypeDefIndex: 16929
{
	// Fields
	public int value__; // 0x0
	public const SendErrors None = 0;
	public const SendErrors Disconnected = 1;
	public const SendErrors Unknown = 2;
}

// Namespace: Hazel
[Flags]
public enum SendOption // TypeDefIndex: 16930
{
	// Fields
	public byte value__; // 0x0
	public const SendOption None = 0;
	public const SendOption Reliable = 1;
}

// Namespace: Hazel
public interface ILogger // TypeDefIndex: 16931
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void WriteError(string msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void WriteWarning(string msg);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void WriteInfo(string msg);
}

// Namespace: Hazel
public class NullLogger : ILogger // TypeDefIndex: 16932
{
	// Fields
	public static readonly NullLogger Instance; // 0x0

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public void WriteError(string msg) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void WriteWarning(string msg) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void WriteInfo(string msg) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1529A20 Offset: 0x1528C20 VA: 0x181529A20
	private static void .cctor() { }
}

// Namespace: Hazel.UPnP
internal class NetUtility // TypeDefIndex: 16933
{
	// Methods

	// RVA: 0x1529430 Offset: 0x1528630 VA: 0x181529430
	private static IList<NetworkInterface> GetValidNetworkInterfaces() { }

	// RVA: 0x1528BD0 Offset: 0x1527DD0 VA: 0x181528BD0
	public static ICollection<UnicastIPAddressInformation> GetAddressesFromNetworkInterfaces(AddressFamily addressFamily) { }

	// RVA: 0x15291B0 Offset: 0x15283B0 VA: 0x1815291B0
	public static IPAddress GetBroadcastAddress() { }

	// RVA: 0x1528FB0 Offset: 0x15281B0 VA: 0x181528FB0
	public static IPAddress GetBroadcastAddress(UnicastIPAddressInformation unicastAddress) { }
}

// Namespace: Hazel.UPnP
public enum UPnPStatus // TypeDefIndex: 16934
{
	// Fields
	public int value__; // 0x0
	public const UPnPStatus Discovering = 0;
	public const UPnPStatus NotAvailable = 1;
	public const UPnPStatus Available = 2;
}

// Namespace: Hazel.UPnP
public class UPnPHelper : IDisposable // TypeDefIndex: 16935
{
	// Fields
	private string serviceUrl; // 0x10
	private string serviceName; // 0x18
	private ManualResetEvent discoveryComplete; // 0x20
	private Socket socket; // 0x28
	private DateTime discoveryResponseDeadline; // 0x30
	private EndPoint ep; // 0x38
	private byte[] buffer; // 0x40
	private ILogger logger; // 0x48
	[CompilerGenerated]
	private UPnPStatus <Status>k__BackingField; // 0x50

	// Properties
	public UPnPStatus Status { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public UPnPStatus get_Status() { }

	[CompilerGenerated]
	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630
	private void set_Status(UPnPStatus value) { }

	// RVA: 0x152D3A0 Offset: 0x152C5A0 VA: 0x18152D3A0
	public void .ctor(ILogger logger) { }

	// RVA: 0x152CE90 Offset: 0x152C090 VA: 0x18152CE90
	private void ListenForUPnP() { }

	// RVA: 0x152CD20 Offset: 0x152BF20 VA: 0x18152CD20
	private void HandleMessage(IAsyncResult ar) { }

	// RVA: 0x152C610 Offset: 0x152B810 VA: 0x18152C610
	internal void Discover() { }

	// RVA: 0x152C7D0 Offset: 0x152B9D0 VA: 0x18152C7D0
	internal bool ExtractServiceUrl(string resp) { }

	// RVA: 0x152C2C0 Offset: 0x152B4C0 VA: 0x18152C2C0
	private static string CombineUrls(string gatewayURL, string subURL) { }

	// RVA: 0x152C200 Offset: 0x152B400 VA: 0x18152C200
	private bool CheckAvailability() { }

	// RVA: 0x152C3E0 Offset: 0x152B5E0 VA: 0x18152C3E0
	public bool DeleteForwardingRule(int externalPort) { }

	// RVA: 0x152CFE0 Offset: 0x152C1E0 VA: 0x18152CFE0
	private XmlDocument SOAPRequest(string url, string soap, string function) { }

	// RVA: 0x152C770 Offset: 0x152B970 VA: 0x18152C770 Slot: 4
	public void Dispose() { }
}

// Namespace: 
private struct UdpBroadcaster.SocketBroadcast // TypeDefIndex: 16936
{
	// Fields
	public Socket Socket; // 0x0
	public IPEndPoint Broadcast; // 0x8

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(Socket socket, IPEndPoint broadcast) { }
}

// Namespace: Hazel.Udp
public class UdpBroadcaster : IDisposable // TypeDefIndex: 16937
{
	// Fields
	private UdpBroadcaster.SocketBroadcast[] socketBroadcasts; // 0x10
	private byte[] data; // 0x18
	private Action<string> logger; // 0x20

	// Methods

	// RVA: 0x152E770 Offset: 0x152D970 VA: 0x18152E770
	public void .ctor(int port, Action<string> logger) { }

	// RVA: 0x152E340 Offset: 0x152D540 VA: 0x18152E340
	private static Socket CreateSocket(IPEndPoint endPoint) { }

	// RVA: 0x152E680 Offset: 0x152D880 VA: 0x18152E680
	public void SetData(string data) { }

	// RVA: 0x152E140 Offset: 0x152D340 VA: 0x18152E140
	public void Broadcast() { }

	// RVA: 0x152E4E0 Offset: 0x152D6E0 VA: 0x18152E4E0
	private void FinishSendTo(IAsyncResult evt) { }

	// RVA: 0x152E3E0 Offset: 0x152D5E0 VA: 0x18152E3E0 Slot: 4
	public void Dispose() { }
}

// Namespace: Hazel.Udp
public class BroadcastPacket // TypeDefIndex: 16938
{
	// Fields
	public string Data; // 0x10
	public DateTime ReceiveTime; // 0x18
	public IPEndPoint Sender; // 0x20

	// Methods

	// RVA: 0x151D760 Offset: 0x151C960 VA: 0x18151D760
	public void .ctor(string data, IPEndPoint sender) { }

	// RVA: 0x151D720 Offset: 0x151C920 VA: 0x18151D720
	public string GetAddress() { }
}

// Namespace: Hazel.Udp
public class UdpBroadcastListener : IDisposable // TypeDefIndex: 16939
{
	// Fields
	private Socket socket; // 0x10
	private EndPoint endpoint; // 0x18
	private Action<string> logger; // 0x20
	private byte[] buffer; // 0x28
	private List<BroadcastPacket> packets; // 0x30
	[CompilerGenerated]
	private bool <Running>k__BackingField; // 0x38

	// Properties
	public bool Running { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_Running() { }

	[CompilerGenerated]
	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	private void set_Running(bool value) { }

	// RVA: 0x152DFB0 Offset: 0x152D1B0 VA: 0x18152DFB0
	public void .ctor(int port, Action<string> logger) { }

	// RVA: 0x152DDD0 Offset: 0x152CFD0 VA: 0x18152DDD0
	public void StartListen() { }

	// RVA: 0x152D890 Offset: 0x152CA90 VA: 0x18152D890
	private void HandleData(IAsyncResult result) { }

	// RVA: 0x152D770 Offset: 0x152C970 VA: 0x18152D770
	public BroadcastPacket[] GetPackets() { }

	// RVA: 0x152D6E0 Offset: 0x152C8E0 VA: 0x18152D6E0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UdpConnection.PingPacket.<>c // TypeDefIndex: 16940
{
	// Fields
	public static readonly UdpConnection.PingPacket.<>c <>9; // 0x0

	// Methods

	// RVA: 0x152C0E0 Offset: 0x152B2E0 VA: 0x18152C0E0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x152BFF0 Offset: 0x152B1F0 VA: 0x18152BFF0
	internal UdpConnection.PingPacket <.cctor>b__5_0() { }
}

// Namespace: 
public class UdpConnection.PingPacket : IRecyclable // TypeDefIndex: 16941
{
	// Fields
	private static readonly ObjectPool<UdpConnection.PingPacket> PacketPool; // 0x0
	public readonly Stopwatch Stopwatch; // 0x10

	// Methods

	// RVA: 0x152A550 Offset: 0x1529750 VA: 0x18152A550
	internal static UdpConnection.PingPacket GetObject() { }

	// RVA: 0x152A5C0 Offset: 0x15297C0 VA: 0x18152A5C0 Slot: 4
	public void Recycle() { }

	// RVA: 0x152A740 Offset: 0x1529940 VA: 0x18152A740
	public void .ctor() { }

	// RVA: 0x152A650 Offset: 0x1529850 VA: 0x18152A650
	private static void .cctor() { }
}

// Namespace: 
public class UdpConnection.Packet : IRecyclable // TypeDefIndex: 16942
{
	// Fields
	public ushort Id; // 0x10
	private byte[] Data; // 0x18
	private readonly UdpConnection Connection; // 0x20
	private int Length; // 0x28
	public int NextTimeoutMs; // 0x2C
	public bool Acknowledged; // 0x30
	public Action AckCallback; // 0x38
	public int Retransmissions; // 0x40
	public Stopwatch Stopwatch; // 0x48

	// Methods

	// RVA: 0x152A4E0 Offset: 0x15296E0 VA: 0x18152A4E0
	internal void .ctor(UdpConnection connection) { }

	// RVA: 0x152A490 Offset: 0x1529690 VA: 0x18152A490
	internal void Set(ushort id, byte[] data, int length, int timeout, Action ackCallback) { }

	// RVA: 0x1529E60 Offset: 0x1529060 VA: 0x181529E60
	public int Resend() { }

	// RVA: 0x1529E00 Offset: 0x1529000 VA: 0x181529E00 Slot: 4
	public void Recycle() { }
}

// Namespace: Hazel.Udp
public abstract class UdpConnection : NetworkConnection // TypeDefIndex: 16943
{
	// Fields
	public static readonly byte[] EmptyDisconnectBytes; // 0x0
	protected readonly ILogger logger; // 0x60
	internal ConcurrentDictionary<ushort, UdpConnection.PingPacket> activePingPackets; // 0x68
	private int keepAliveInterval; // 0x70
	[CompilerGenerated]
	private int <MissingPingsUntilDisconnect>k__BackingField; // 0x74
	private int pingsSinceAck; // 0x78
	private Timer keepAliveTimer; // 0x80
	private const int MinResendDelayMs = 50;
	private const int MaxInitialResendDelayMs = 300;
	private const int MaxAdditionalResendDelayMs = 1000;
	public readonly ObjectPool<UdpConnection.Packet> PacketPool; // 0x88
	public int ResendTimeoutMs; // 0x90
	public int ResendLimit; // 0x94
	public float ResendPingMultiplier; // 0x98
	private int lastIDAllocated; // 0x9C
	internal ConcurrentDictionary<ushort, UdpConnection.Packet> reliableDataPacketsSent; // 0xA0
	private HashSet<ushort> reliableDataPacketsMissing; // 0xA8
	protected ushort reliableReceiveLast; // 0xB0
	private object PingLock; // 0xB8
	private float _pingMs; // 0xC0
	public int DisconnectTimeoutMs; // 0xC4

	// Properties
	public override float AveragePingMs { get; }
	public int KeepAliveInterval { set; }
	public int MissingPingsUntilDisconnect { get; }

	// Methods

	// RVA: 0x1532660 Offset: 0x1531860 VA: 0x181532660 Slot: 10
	public override float get_AveragePingMs() { }

	// RVA: 0x1532410 Offset: 0x1531610 VA: 0x181532410
	public void .ctor(ILogger logger) { }

	// RVA: 0x1530580 Offset: 0x152F780 VA: 0x181530580
	internal static Socket CreateSocket(IPMode ipMode) { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void WriteBytesToConnection(byte[] bytes, int length);

	// RVA: 0x1531ED0 Offset: 0x15310D0 VA: 0x181531ED0 Slot: 6
	public override SendErrors Send(MessageWriter msg) { }

	// RVA: 0x1530F90 Offset: 0x1530190 VA: 0x181530F90 Slot: 13
	protected virtual void HandleSend(byte[] data, byte sendOption, Action ackCallback) { }

	// RVA: 0x1530C80 Offset: 0x152FE80 VA: 0x181530C80 Slot: 14
	protected internal virtual void HandleReceive(MessageReader message, int bytesReceived) { }

	// RVA: 0x1532290 Offset: 0x1531490 VA: 0x181532290
	private void UnreliableSend(byte sendOption, byte[] data) { }

	// RVA: 0x1532190 Offset: 0x1531390 VA: 0x181532190
	private void UnreliableSend(byte sendOption, byte[] data, int offset, int length) { }

	// RVA: 0x1531250 Offset: 0x1530450 VA: 0x181531250
	private void InvokeDataReceived(SendOption sendOption, MessageReader buffer, int dataOffset, int bytesReceived) { }

	// RVA: 0x1531BD0 Offset: 0x1530DD0 VA: 0x181531BD0
	protected void SendHello(byte[] bytes, Action acknowledgeCallback) { }

	// RVA: 0x1530B80 Offset: 0x152FD80 VA: 0x181530B80 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1532670 Offset: 0x1531870 VA: 0x181532670
	public void set_KeepAliveInterval(int value) { }

	[CompilerGenerated]
	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90
	public int get_MissingPingsUntilDisconnect() { }

	// RVA: 0x1531180 Offset: 0x1530380 VA: 0x181531180
	protected void InitializeKeepAliveTimer() { }

	// RVA: 0x1530BB0 Offset: 0x152FDB0 VA: 0x181530BB0
	private void HandleKeepAlive(object state) { }

	// RVA: 0x1531C90 Offset: 0x1530E90 VA: 0x181531C90
	private void SendPing() { }

	// RVA: 0x15319D0 Offset: 0x1530BD0 VA: 0x1815319D0
	protected void ResetKeepAliveTimer() { }

	// RVA: 0x1530730 Offset: 0x152F930 VA: 0x181530730
	private void DisposeKeepAliveTimer() { }

	// RVA: 0x1531290 Offset: 0x1530490 VA: 0x181531290
	internal int ManageReliablePackets() { }

	// RVA: 0x15303A0 Offset: 0x152F5A0 VA: 0x1815303A0
	protected void AttachReliableID(byte[] buffer, int offset, Action ackCallback) { }

	// RVA: 0x15318A0 Offset: 0x1530AA0 VA: 0x1815318A0
	private void ReliableSend(byte sendOption, byte[] data, Action ackCallback) { }

	// RVA: 0x15317C0 Offset: 0x15309C0 VA: 0x1815317C0
	private void ReliableMessageReceive(MessageReader message, int bytesReceived) { }

	// RVA: 0x15314D0 Offset: 0x15306D0 VA: 0x1815314D0
	private bool ProcessReliableReceive(byte[] bytes, int offset, out ushort id) { }

	// RVA: 0x15302B0 Offset: 0x152F4B0 VA: 0x1815302B0
	private void AcknowledgementMessageReceive(byte[] bytes, int bytesReceived) { }

	// RVA: 0x152FF60 Offset: 0x152F160 VA: 0x18152FF60
	private void AcknowledgeMessageId(ushort id) { }

	// RVA: 0x1531A00 Offset: 0x1530C00 VA: 0x181531A00
	private void SendAck(ushort id) { }

	// RVA: 0x1530960 Offset: 0x152FB60 VA: 0x181530960
	private void DisposeReliablePackets() { }

	// RVA: 0x1532390 Offset: 0x1531590 VA: 0x181532390
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x15320F0 Offset: 0x15312F0 VA: 0x1815320F0
	private UdpConnection.Packet <.ctor>b__4_0() { }
}

// Namespace: Hazel.Udp
public class UdpConnectionListener : NetworkConnectionListener // TypeDefIndex: 16944
{
	// Fields
	private const int SendReceiveBufferSize = 1048576;
	private const int BufferSize = 65535;
	private Socket socket; // 0x48
	private ILogger Logger; // 0x50
	private Timer reliablePacketTimer; // 0x58
	private ConcurrentDictionary<EndPoint, UdpServerConnection> allConnections; // 0x60

	// Methods

	// RVA: 0x152FD90 Offset: 0x152EF90 VA: 0x18152FD90
	public void .ctor(IPEndPoint endPoint, IPMode ipMode = 0, ILogger logger) { }

	// RVA: 0x152EE40 Offset: 0x152E040 VA: 0x18152EE40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x152EEB0 Offset: 0x152E0B0 VA: 0x18152EEB0
	private void ManageReliablePackets(object state) { }

	// RVA: 0x152FCF0 Offset: 0x152EEF0 VA: 0x18152FCF0 Slot: 5
	public override void Start() { }

	// RVA: 0x152FA80 Offset: 0x152EC80 VA: 0x18152FA80
	private void StartListeningForData() { }

	// RVA: 0x152F0C0 Offset: 0x152E2C0 VA: 0x18152F0C0
	private void ReadCallback(IAsyncResult result) { }

	// RVA: 0x152F8F0 Offset: 0x152EAF0 VA: 0x18152F8F0
	internal void SendData(byte[] bytes, int length, EndPoint endPoint) { }

	// RVA: 0x152F850 Offset: 0x152EA50 VA: 0x18152F850
	private void SendCallback(IAsyncResult result) { }

	// RVA: 0x152F880 Offset: 0x152EA80 VA: 0x18152F880
	internal void SendDataSync(byte[] bytes, int length, EndPoint endPoint) { }

	// RVA: 0x152F7E0 Offset: 0x152E9E0 VA: 0x18152F7E0
	internal void RemoveConnectionTo(EndPoint endPoint) { }

	// RVA: 0x152EB70 Offset: 0x152DD70 VA: 0x18152EB70 Slot: 6
	protected override void Dispose(bool disposing) { }
}

// Namespace: Hazel.Udp
internal sealed class UdpServerConnection : UdpConnection // TypeDefIndex: 16945
{
	// Fields
	[CompilerGenerated]
	private UdpConnectionListener <Listener>k__BackingField; // 0xC8

	// Properties
	public UdpConnectionListener Listener { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x738340 Offset: 0x737540 VA: 0x180738340
	public UdpConnectionListener get_Listener() { }

	[CompilerGenerated]
	// RVA: 0x1532B30 Offset: 0x1531D30 VA: 0x181532B30
	private void set_Listener(UdpConnectionListener value) { }

	// RVA: 0x1532A80 Offset: 0x1531C80 VA: 0x181532A80
	internal void .ctor(UdpConnectionListener listener, IPEndPoint endPoint, IPMode IPMode, ILogger logger) { }

	// RVA: 0x15329E0 Offset: 0x1531BE0 VA: 0x1815329E0 Slot: 12
	protected override void WriteBytesToConnection(byte[] bytes, int length) { }

	// RVA: 0x1532680 Offset: 0x1531880 VA: 0x181532680 Slot: 7
	public override void ConnectAsync(byte[] bytes) { }

	// RVA: 0x15327B0 Offset: 0x15319B0 VA: 0x1815327B0 Slot: 11
	protected override bool SendDisconnect(MessageWriter data) { }

	// RVA: 0x15326D0 Offset: 0x15318D0 VA: 0x1815326D0 Slot: 9
	protected override void Dispose(bool disposing) { }
}

// Namespace: Hazel.Udp
public class UnityUdpClientConnection : UdpConnection // TypeDefIndex: 16946
{
	// Fields
	public int ReceiveBufferSize; // 0xC8
	private Socket socket; // 0xD0

	// Methods

	// RVA: 0x15339D0 Offset: 0x1532BD0 VA: 0x1815339D0
	public void .ctor(ILogger logger, IPEndPoint remoteEndPoint, IPMode ipMode = 0) { }

	// RVA: 0x1532F50 Offset: 0x1532150 VA: 0x181532F50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1532FC0 Offset: 0x15321C0 VA: 0x181532FC0
	public void FixedUpdate() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	protected virtual void RestartConnection() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	protected virtual void ResendPacketsIfNeeded() { }

	// RVA: 0x15339C0 Offset: 0x1532BC0 VA: 0x1815339C0 Slot: 12
	protected override void WriteBytesToConnection(byte[] bytes, int length) { }

	// RVA: 0x15337B0 Offset: 0x15329B0 VA: 0x1815337B0
	private void WriteBytesToConnectionReal(byte[] bytes, int length) { }

	// RVA: 0x1533920 Offset: 0x1532B20 VA: 0x181533920 Slot: 17
	protected virtual void WriteBytesToConnectionSync(byte[] bytes, int length) { }

	// RVA: 0x1533100 Offset: 0x1532300 VA: 0x181533100
	private void HandleSendTo(IAsyncResult result) { }

	// RVA: 0x1532B40 Offset: 0x1531D40 VA: 0x181532B40 Slot: 7
	public override void ConnectAsync(byte[] bytes) { }

	// RVA: 0x1533610 Offset: 0x1532810 VA: 0x181533610
	private void StartListeningForData() { }

	// RVA: 0x1533190 Offset: 0x1532390 VA: 0x181533190
	private void ReadCallback(IAsyncResult result) { }

	// RVA: 0x15333F0 Offset: 0x15325F0 VA: 0x1815333F0 Slot: 11
	protected override bool SendDisconnect(MessageWriter data) { }

	// RVA: 0x1532E90 Offset: 0x1532090 VA: 0x181532E90 Slot: 9
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x1533770 Offset: 0x1532970 VA: 0x181533770
	private void <ConnectAsync>b__12_0() { }
}

// Namespace: Hazel.Dtls
public class Aes128GcmRecordProtection : IRecordProtection, IDisposable // TypeDefIndex: 16947
{
	// Fields
	private readonly Aes128Gcm serverWriteCipher; // 0x10
	private readonly Aes128Gcm clientWriteCipher; // 0x18
	private readonly ByteSpan serverWriteIV; // 0x20
	private readonly ByteSpan clientWriteIV; // 0x30

	// Methods

	// RVA: 0x151BD10 Offset: 0x151AF10 VA: 0x18151BD10
	public void .ctor(ByteSpan masterSecret, ByteSpan serverRandom, ByteSpan clientRandom) { }

	// RVA: 0x151B8D0 Offset: 0x151AAD0 VA: 0x18151B8D0 Slot: 8
	public void Dispose() { }

	// RVA: 0x151BCF0 Offset: 0x151AEF0 VA: 0x18151BCF0
	private static int GetEncryptedSizeImpl(int dataSize) { }

	// RVA: 0x151BD00 Offset: 0x151AF00 VA: 0x18151BD00 Slot: 4
	public int GetEncryptedSize(int dataSize) { }

	// RVA: 0x151BCD0 Offset: 0x151AED0 VA: 0x18151BCD0
	private static int GetDecryptedSizeImpl(int dataSize) { }

	// RVA: 0x151BCE0 Offset: 0x151AEE0 VA: 0x18151BCE0 Slot: 5
	public int GetDecryptedSize(int dataSize) { }

	// RVA: 0x151B970 Offset: 0x151AB70 VA: 0x18151B970 Slot: 6
	public void EncryptClientPlaintext(ByteSpan output, ByteSpan input, ref Record record) { }

	// RVA: 0x151B9C0 Offset: 0x151ABC0 VA: 0x18151B9C0
	private static void EncryptPlaintext(ByteSpan output, ByteSpan input, ref Record record, Aes128Gcm cipher, ByteSpan writeIV) { }

	// RVA: 0x151B560 Offset: 0x151A760 VA: 0x18151B560 Slot: 7
	public bool DecryptCiphertextFromServer(ByteSpan output, ByteSpan input, ref Record record) { }

	// RVA: 0x151B5B0 Offset: 0x151A7B0 VA: 0x18151B5B0
	private static bool DecryptCiphertext(ByteSpan output, ByteSpan input, ref Record record, Aes128Gcm cipher, ByteSpan writeIV) { }
}

// Namespace: 
private enum DtlsUnityConnection.HandshakeState // TypeDefIndex: 16948
{
	// Fields
	public int value__; // 0x0
	public const DtlsUnityConnection.HandshakeState Initializing = 0;
	public const DtlsUnityConnection.HandshakeState ExpectingServerHello = 1;
	public const DtlsUnityConnection.HandshakeState ExpectingCertificate = 2;
	public const DtlsUnityConnection.HandshakeState ExpectingServerKeyExchange = 3;
	public const DtlsUnityConnection.HandshakeState ExpectingServerHelloDone = 4;
	public const DtlsUnityConnection.HandshakeState ExpectingChangeCipherSpec = 5;
	public const DtlsUnityConnection.HandshakeState ExpectingFinished = 6;
	public const DtlsUnityConnection.HandshakeState Established = 7;
}

// Namespace: 
private struct DtlsUnityConnection.CurrentEpoch // TypeDefIndex: 16949
{
	// Fields
	public ulong NextOutgoingSequence; // 0x0
	public ulong NextExpectedSequence; // 0x8
	public ulong PreviousSequenceWindowBitmask; // 0x10
	public IRecordProtection RecordProtection; // 0x18
}

// Namespace: 
private struct DtlsUnityConnection.FragmentRange // TypeDefIndex: 16950
{
	// Fields
	public int Offset; // 0x0
	public int Length; // 0x4
}

// Namespace: 
private struct DtlsUnityConnection.NextEpoch // TypeDefIndex: 16951
{
	// Fields
	public ushort Epoch; // 0x0
	public DtlsUnityConnection.HandshakeState State; // 0x4
	public ulong NextOutgoingSequence; // 0x8
	public DateTime NegotiationStartTime; // 0x10
	public DateTime NextPacketResendTime; // 0x18
	public int PacketResendCount; // 0x20
	public CipherSuite SelectedCipherSuite; // 0x24
	public IRecordProtection RecordProtection; // 0x28
	public IHandshakeCipherSuite Handshake; // 0x30
	public ByteSpan Cookie; // 0x38
	public Sha256Stream VerificationStream; // 0x48
	public RSA ServerPublicKey; // 0x50
	public ByteSpan ClientRandom; // 0x58
	public ByteSpan ServerRandom; // 0x68
	public ByteSpan MasterSecret; // 0x78
	public ByteSpan ServerVerification; // 0x88
	public List<DtlsUnityConnection.FragmentRange> CertificateFragments; // 0x98
	public ByteSpan CertificatePayload; // 0xA0
}

// Namespace: 
private struct DtlsUnityConnection.QueuedAppData // TypeDefIndex: 16952
{
	// Fields
	public byte[] Bytes; // 0x0
	public byte SendOption; // 0x8
	public Action AckCallback; // 0x10
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DtlsUnityConnection.<>c // TypeDefIndex: 16953
{
	// Fields
	public static readonly DtlsUnityConnection.<>c <>9; // 0x0
	public static Comparison<DtlsUnityConnection.FragmentRange> <>9__31_0; // 0x8

	// Methods

	// RVA: 0x152C1A0 Offset: 0x152B3A0 VA: 0x18152C1A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x152BEA0 Offset: 0x152B0A0 VA: 0x18152BEA0
	internal int <ProcessHandshake>b__31_0(DtlsUnityConnection.FragmentRange lhs, DtlsUnityConnection.FragmentRange rhs) { }
}

// Namespace: Hazel.Dtls
public class DtlsUnityConnection : UnityUdpClientConnection // TypeDefIndex: 16954
{
	// Fields
	private const ProtocolVersion DtlsVersion = 0;
	internal byte HazelSessionVersion; // 0xD8
	private readonly object syncRoot; // 0xE0
	private readonly RandomNumberGenerator random; // 0xE8
	private ushort epoch; // 0xF0
	private DtlsUnityConnection.CurrentEpoch currentEpoch; // 0xF8
	private DtlsUnityConnection.NextEpoch nextEpoch; // 0x118
	private TimeSpan handshakeResendTimeout; // 0x1C8
	private readonly Queue<DtlsUnityConnection.QueuedAppData> queuedApplicationData; // 0x1D0
	private X509Certificate2Collection serverCertificates; // 0x1D8

	// Methods

	// RVA: 0x1525F10 Offset: 0x1525110 VA: 0x181525F10
	public void .ctor(ILogger logger, IPEndPoint remoteEndPoint, IPMode ipMode = 0) { }

	// RVA: 0x1521050 Offset: 0x1520250 VA: 0x181521050 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15258A0 Offset: 0x1524AA0 VA: 0x1815258A0
	public void SetValidServerCertificates(X509Certificate2Collection certificateCollection) { }

	// RVA: 0x1524150 Offset: 0x1523350 VA: 0x181524150
	private void ResetConnectionState() { }

	// RVA: 0x1524440 Offset: 0x1523640 VA: 0x181524440 Slot: 15
	protected override void RestartConnection() { }

	// RVA: 0x1523E50 Offset: 0x1523050 VA: 0x181523E50 Slot: 16
	protected override void ResendPacketsIfNeeded() { }

	// RVA: 0x15210F0 Offset: 0x15202F0 VA: 0x1815210F0
	private void FlushQueuedApplicationData() { }

	// RVA: 0x1525AA0 Offset: 0x1524CA0 VA: 0x181525AA0
	private ByteSpan WriteBytesToConnectionInternal(byte[] bytes, int length) { }

	// RVA: 0x1521DA0 Offset: 0x1520FA0 VA: 0x181521DA0 Slot: 13
	protected override void HandleSend(byte[] data, byte sendOption, Action ackCallback) { }

	// RVA: 0x1525EB0 Offset: 0x15250B0 VA: 0x181525EB0 Slot: 12
	protected override void WriteBytesToConnection(byte[] bytes, int length) { }

	// RVA: 0x1525E50 Offset: 0x1525050 VA: 0x181525E50 Slot: 17
	protected override void WriteBytesToConnectionSync(byte[] bytes, int length) { }

	// RVA: 0x1521370 Offset: 0x1520570 VA: 0x181521370 Slot: 14
	protected internal override void HandleReceive(MessageReader reader, int bytesReceived) { }

	// RVA: 0x1521480 Offset: 0x1520680 VA: 0x181521480
	private void HandleReceive(ByteSpan span) { }

	// RVA: 0x15220B0 Offset: 0x15212B0 VA: 0x1815220B0
	private bool ProcessHandshake(ref Record record, ByteSpan message) { }

	// RVA: 0x1521F50 Offset: 0x1521150 VA: 0x181521F50
	private bool IsFragmentOverlapping(List<DtlsUnityConnection.FragmentRange> fragments, uint newOffset, uint newLength) { }

	// RVA: 0x1524510 Offset: 0x1523710 VA: 0x181524510 Slot: 18
	protected virtual void SendClientHello(bool isRetransmit) { }

	// RVA: 0x1524CB0 Offset: 0x1523EB0 VA: 0x181524CB0 Slot: 19
	protected virtual void SendClientKeyExchangeFlight(bool isRetransmit) { }
}

// Namespace: Hazel.Dtls
public enum HandshakeType // TypeDefIndex: 16955
{
	// Fields
	public byte value__; // 0x0
	public const HandshakeType HelloRequest = 0;
	public const HandshakeType ClientHello = 1;
	public const HandshakeType ServerHello = 2;
	public const HandshakeType HelloVerifyRequest = 3;
	public const HandshakeType Certificate = 11;
	public const HandshakeType ServerKeyExchange = 12;
	public const HandshakeType CertificateRequest = 13;
	public const HandshakeType ServerHelloDone = 14;
	public const HandshakeType CertificateVerify = 15;
	public const HandshakeType ClientKeyExchange = 16;
	public const HandshakeType Finished = 20;
}

// Namespace: Hazel.Dtls
public enum CipherSuite // TypeDefIndex: 16956
{
	// Fields
	public int value__; // 0x0
	public const CipherSuite TLS_NULL_WITH_NULL_NULL = 0;
	public const CipherSuite TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199;
}

// Namespace: Hazel.Dtls
public struct Handshake // TypeDefIndex: 16957
{
	// Fields
	public HandshakeType MessageType; // 0x0
	public uint Length; // 0x4
	public ushort MessageSequence; // 0x8
	public uint FragmentOffset; // 0xC
	public uint FragmentLength; // 0x10

	// Methods

	// RVA: 0x15263D0 Offset: 0x15255D0 VA: 0x1815263D0
	public static bool Parse(out Handshake header, ByteSpan span) { }

	// RVA: 0x1526200 Offset: 0x1525400 VA: 0x181526200
	public void Encode(ByteSpan span) { }
}

// Namespace: Hazel.Dtls
public struct ClientHello // TypeDefIndex: 16958
{
	// Fields
	public ProtocolVersion ClientProtocolVersion; // 0x0
	public ByteSpan Random; // 0x8
	public ByteSpan Cookie; // 0x18
	public HazelDtlsSessionInfo Session; // 0x28
	public ByteSpan CipherSuites; // 0x30
	public ByteSpan SupportedCurves; // 0x40

	// Methods

	// RVA: 0x151F2F0 Offset: 0x151E4F0 VA: 0x18151F2F0
	public int CalculateSize() { }

	// RVA: 0x151F310 Offset: 0x151E510 VA: 0x18151F310
	public void Encode(ByteSpan span) { }
}

// Namespace: Hazel.Dtls
public struct HazelDtlsSessionInfo // TypeDefIndex: 16959
{
	// Fields
	public byte PayloadSize; // 0x0
	public byte Version; // 0x1

	// Properties
	public byte FullSize { get; }

	// Methods

	// RVA: 0x1526780 Offset: 0x1525980 VA: 0x181526780
	public byte get_FullSize() { }

	// RVA: 0x1526710 Offset: 0x1525910 VA: 0x181526710
	public void .ctor(byte version) { }

	// RVA: 0x1526570 Offset: 0x1525770 VA: 0x181526570
	public void Encode(ByteSpan writer) { }

	// RVA: 0x1526660 Offset: 0x1525860 VA: 0x181526660
	public static bool Parse(out HazelDtlsSessionInfo result, ByteSpan reader) { }
}

// Namespace: Hazel.Dtls
public struct HelloVerifyRequest // TypeDefIndex: 16960
{
	// Fields
	public ProtocolVersion ServerProtocolVersion; // 0x0
	public ByteSpan Cookie; // 0x8

	// Methods

	// RVA: 0x1526860 Offset: 0x1525A60 VA: 0x181526860
	public static bool Parse(out HelloVerifyRequest result, Nullable<ProtocolVersion> expectedProtocolVersion, ByteSpan span) { }
}

// Namespace: Hazel.Dtls
public struct ServerHello // TypeDefIndex: 16961
{
	// Fields
	public ProtocolVersion ServerProtocolVersion; // 0x0
	public ByteSpan Random; // 0x8
	public CipherSuite CipherSuite; // 0x18
	public HazelDtlsSessionInfo Session; // 0x1C

	// Methods

	// RVA: 0x152B6B0 Offset: 0x152A8B0 VA: 0x18152B6B0
	public static bool Parse(out ServerHello result, ByteSpan span) { }
}

// Namespace: Hazel.Dtls
public struct Certificate // TypeDefIndex: 16962
{
	// Methods

	// RVA: 0x151F0D0 Offset: 0x151E2D0 VA: 0x18151F0D0
	public static bool Parse(out X509Certificate2 certificate, ByteSpan span) { }
}

// Namespace: Hazel.Dtls
public interface IHandshakeCipherSuite : IDisposable // TypeDefIndex: 16963
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int SharedKeySize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool VerifyServerMessageAndGenerateSharedKey(ByteSpan output, ByteSpan serverKeyExchangeMessage, object publicKey);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int CalculateClientMessageSize();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void EncodeClientKeyExchangeMessage(ByteSpan output);
}

// Namespace: Hazel.Dtls
public interface IRecordProtection : IDisposable // TypeDefIndex: 16964
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetEncryptedSize(int dataSize);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetDecryptedSize(int dataSize);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void EncryptClientPlaintext(ByteSpan output, ByteSpan input, ref Record record);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool DecryptCiphertextFromServer(ByteSpan output, ByteSpan input, ref Record record);
}

// Namespace: Hazel.Dtls
public class NullRecordProtection : IRecordProtection, IDisposable // TypeDefIndex: 16965
{
	// Fields
	public static readonly NullRecordProtection Instance; // 0x0

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public void Dispose() { }

	// RVA: 0x1529D90 Offset: 0x1528F90 VA: 0x181529D90 Slot: 4
	public int GetEncryptedSize(int dataSize) { }

	// RVA: 0x1529D90 Offset: 0x1528F90 VA: 0x181529D90 Slot: 5
	public int GetDecryptedSize(int dataSize) { }

	// RVA: 0x1529C70 Offset: 0x1528E70 VA: 0x181529C70 Slot: 6
	public void EncryptClientPlaintext(ByteSpan output, ByteSpan input, ref Record record) { }

	// RVA: 0x1529B50 Offset: 0x1528D50 VA: 0x181529B50 Slot: 7
	public bool DecryptCiphertextFromServer(ByteSpan output, ByteSpan input, ref Record record) { }

	// RVA: 0x1529A80 Offset: 0x1528C80 VA: 0x181529A80
	private static void CopyMaybeOverlappingSpans(ByteSpan output, ByteSpan input) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1529DA0 Offset: 0x1528FA0 VA: 0x181529DA0
	private static void .cctor() { }
}

// Namespace: Hazel.Dtls
public struct PrfLabel // TypeDefIndex: 16966
{
	// Fields
	public static readonly ByteSpan MASTER_SECRET; // 0x0
	public static readonly ByteSpan KEY_EXPANSION; // 0x10
	public static readonly ByteSpan CLIENT_FINISHED; // 0x20
	public static readonly ByteSpan SERVER_FINISHED; // 0x30

	// Methods

	// RVA: 0x152A7A0 Offset: 0x15299A0 VA: 0x18152A7A0
	public static ByteSpan LabelToBytes(string label) { }

	// RVA: 0x152A820 Offset: 0x1529A20 VA: 0x18152A820
	private static void .cctor() { }
}

// Namespace: Hazel.Dtls
public struct PrfSha256 // TypeDefIndex: 16967
{
	// Methods

	// RVA: 0x152AA30 Offset: 0x1529C30 VA: 0x18152AA30
	public static void ExpandSecret(ByteSpan output, ByteSpan key, ByteSpan label, ByteSpan initialSeed) { }
}

// Namespace: Hazel.Dtls
public enum ProtocolVersion // TypeDefIndex: 16968
{
	// Fields
	public ushort value__; // 0x0
	public const ProtocolVersion UDP = 0;
	public const ProtocolVersion DTLS1_2 = 65277;
}

// Namespace: Hazel.Dtls
public enum ContentType // TypeDefIndex: 16969
{
	// Fields
	public byte value__; // 0x0
	public const ContentType ChangeCipherSpec = 20;
	public const ContentType Alert = 21;
	public const ContentType Handshake = 22;
	public const ContentType ApplicationData = 23;
}

// Namespace: Hazel.Dtls
public struct Record // TypeDefIndex: 16970
{
	// Fields
	public ContentType ContentType; // 0x0
	public ProtocolVersion ProtocolVersion; // 0x2
	public ushort Epoch; // 0x4
	public ulong SequenceNumber; // 0x8
	public ushort Length; // 0x10

	// Methods

	// RVA: 0x152B330 Offset: 0x152A530 VA: 0x18152B330
	public static bool Parse(out Record record, Nullable<ProtocolVersion> expectedProtocolVersion, ByteSpan span) { }

	// RVA: 0x152AFE0 Offset: 0x152A1E0 VA: 0x18152AFE0
	public void Encode(ByteSpan span) { }
}

// Namespace: Hazel.Dtls
public struct ChangeCipherSpec // TypeDefIndex: 16971
{
	// Methods

	// RVA: 0x151F2B0 Offset: 0x151E4B0 VA: 0x18151F2B0
	public static bool Parse(ByteSpan span) { }

	// RVA: 0x151F230 Offset: 0x151E430 VA: 0x18151F230
	public static void Encode(ByteSpan span) { }
}

// Namespace: Hazel.Dtls
public class X25519EcdheRsaSha256 : IHandshakeCipherSuite, IDisposable // TypeDefIndex: 16972
{
	// Fields
	private readonly ByteSpan privateAgreementKey; // 0x10
	private SHA256 sha256; // 0x20
	private static int ClientMessageSize; // 0x0

	// Methods

	// RVA: 0x1534130 Offset: 0x1533330 VA: 0x181534130
	public void .ctor(RandomNumberGenerator random) { }

	// RVA: 0x1533AF0 Offset: 0x1532CF0 VA: 0x181533AF0 Slot: 8
	public void Dispose() { }

	// RVA: 0x1533C40 Offset: 0x1532E40 VA: 0x181533C40 Slot: 4
	public int SharedKeySize() { }

	// RVA: 0x1533AE0 Offset: 0x1532CE0 VA: 0x181533AE0
	private static int CalculateServerMessageSize(int keySize) { }

	// RVA: 0x1533C50 Offset: 0x1532E50 VA: 0x181533C50 Slot: 5
	public bool VerifyServerMessageAndGenerateSharedKey(ByteSpan output, ByteSpan serverKeyExchangeMessage, object publicKey) { }

	// RVA: 0x1533A90 Offset: 0x1532C90 VA: 0x181533A90 Slot: 6
	public int CalculateClientMessageSize() { }

	// RVA: 0x1533B20 Offset: 0x1532D20 VA: 0x181533B20 Slot: 7
	public void EncodeClientKeyExchangeMessage(ByteSpan output) { }

	// RVA: 0x15340F0 Offset: 0x15332F0 VA: 0x1815340F0
	private static void .cctor() { }
}

// Namespace: Hazel.Crypto
public class Aes128Gcm : IDisposable // TypeDefIndex: 16973
{
	// Fields
	private readonly IAes encryptor_; // 0x10
	private readonly ByteSpan hashSubkey_; // 0x18
	private readonly ByteSpan blockJ_; // 0x28
	private readonly ByteSpan blockS_; // 0x38
	private readonly ByteSpan blockZ_; // 0x48
	private readonly ByteSpan blockV_; // 0x58
	private readonly ByteSpan blockScratch_; // 0x68

	// Methods

	// RVA: 0x151D400 Offset: 0x151C600 VA: 0x18151D400
	public void .ctor(ByteSpan key) { }

	// RVA: 0x151D160 Offset: 0x151C360 VA: 0x18151D160
	public void Seal(ByteSpan output, ByteSpan nonce, ByteSpan plaintext, ByteSpan associatedData) { }

	// RVA: 0x151CED0 Offset: 0x151C0D0 VA: 0x18151CED0
	public bool Open(ByteSpan output, ByteSpan nonce, ByteSpan ciphertext, ByteSpan associatedData) { }

	// RVA: 0x151C0B0 Offset: 0x151B2B0 VA: 0x18151C0B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x151C430 Offset: 0x151B630 VA: 0x18151C430
	private void GenerateAuthenticationTag(ByteSpan output, ByteSpan ciphertext, ByteSpan associatedData) { }

	// RVA: 0x151C100 Offset: 0x151B300 VA: 0x18151C100
	private void GCTR(ByteSpan output, ByteSpan counterBlock, uint counter, ByteSpan data) { }

	// RVA: 0x151C330 Offset: 0x151B530 VA: 0x18151C330
	private void GHASH(ByteSpan output, ByteSpan data, int numBlocks) { }

	// RVA: 0x151CB30 Offset: 0x151BD30 VA: 0x18151CB30
	private static void MultiplyGF128Elements(ByteSpan X, ByteSpan Y, ByteSpan scratchZ, ByteSpan scratchV) { }

	// RVA: 0x151D360 Offset: 0x151C560 VA: 0x18151D360
	private static void SetSpanToZeros(ByteSpan span) { }
}

// Namespace: Hazel.Crypto
public static class Const // TypeDefIndex: 16974
{
	// Methods

	// RVA: 0x15208F0 Offset: 0x151FAF0 VA: 0x1815208F0
	public static byte ConstantCompareByte(byte a, byte b) { }

	// RVA: 0x1520910 Offset: 0x151FB10 VA: 0x181520910
	public static byte ConstantCompareSpans(ByteSpan a, ByteSpan b) { }

	// RVA: 0x1520A60 Offset: 0x151FC60 VA: 0x181520A60
	public static byte ConstantCompareZeroSpan(ByteSpan a) { }
}

// Namespace: 
public sealed class CryptoProvider.CreateAesOverrideDelegate : MulticastDelegate // TypeDefIndex: 16975
{
	// Methods

	// RVA: 0x1203010 Offset: 0x1202210 VA: 0x181203010
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0 Slot: 13
	public virtual IAes Invoke(ByteSpan key) { }
}

// Namespace: Hazel.Crypto
public static class CryptoProvider // TypeDefIndex: 16976
{
	// Fields
	public static CryptoProvider.CreateAesOverrideDelegate OverrideCreateAes; // 0x0

	// Methods

	// RVA: 0x1520B10 Offset: 0x151FD10 VA: 0x181520B10
	public static IAes CreateAes(ByteSpan key) { }
}

// Namespace: Hazel.Crypto
public class DefaultAes : IAes, IDisposable // TypeDefIndex: 16977
{
	// Fields
	private readonly ICryptoTransform encryptor_; // 0x10

	// Methods

	// RVA: 0x1520DD0 Offset: 0x151FFD0 VA: 0x181520DD0
	public void .ctor(ByteSpan key) { }

	// RVA: 0x1520BD0 Offset: 0x151FDD0 VA: 0x181520BD0 Slot: 5
	public void Dispose() { }

	// RVA: 0x1520C20 Offset: 0x151FE20 VA: 0x181520C20 Slot: 4
	public int EncryptBlock(ByteSpan inputSpan, ByteSpan outputSpan) { }
}

// Namespace: Hazel.Crypto
public interface IAes : IDisposable // TypeDefIndex: 16978
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int EncryptBlock(ByteSpan inputSpan, ByteSpan outputSpan);
}

// Namespace: 
private struct Sha256Stream.EmptyArray // TypeDefIndex: 16979
{
	// Fields
	public static readonly byte[] Value; // 0x0

	// Methods

	// RVA: 0x15341F0 Offset: 0x15333F0 VA: 0x1815341F0
	private static void .cctor() { }
}

// Namespace: Hazel.Crypto
public class Sha256Stream : IDisposable // TypeDefIndex: 16980
{
	// Fields
	public const int DigestSize = 32;
	private SHA256 hash; // 0x10
	private bool isHashFinished; // 0x18

	// Methods

	// RVA: 0x152BE70 Offset: 0x152B070 VA: 0x18152BE70
	public void .ctor() { }

	// RVA: 0x152BDD0 Offset: 0x152AFD0 VA: 0x18152BDD0 Slot: 4
	public void Dispose() { }

	// RVA: 0x152BE40 Offset: 0x152B040 VA: 0x18152BE40
	public void Reset() { }

	// RVA: 0x152BAE0 Offset: 0x152ACE0 VA: 0x18152BAE0
	public void AddData(ByteSpan data) { }

	// RVA: 0x152BB80 Offset: 0x152AD80 VA: 0x18152BB80
	public void CopyOrCalculateFinalHash(ByteSpan output) { }
}

// Namespace: Hazel.Crypto
[Extension]
public static class SpanCryptoExtensions // TypeDefIndex: 16981
{
	// Methods

	[Extension]
	// RVA: 0x1535FC0 Offset: 0x15351C0 VA: 0x181535FC0
	public static void SecureClear(ByteSpan span) { }

	[Extension]
	// RVA: 0x1535EB0 Offset: 0x15350B0 VA: 0x181535EB0
	public static void FillWithRandom(ByteSpan span, RandomNumberGenerator random) { }
}

// Namespace: 
public struct X25519.FieldElement // TypeDefIndex: 16982
{
	// Fields
	public int x0; // 0x0
	public int x1; // 0x4
	public int x2; // 0x8
	public int x3; // 0xC
	public int x4; // 0x10
	public int x5; // 0x14
	public int x6; // 0x18
	public int x7; // 0x1C
	public int x8; // 0x20
	public int x9; // 0x24

	// Methods

	// RVA: 0x15348A0 Offset: 0x1533AA0 VA: 0x1815348A0
	public static X25519.FieldElement FromBytes(ByteSpan bytes) { }

	// RVA: 0x1534400 Offset: 0x1533600 VA: 0x181534400
	public void CopyTo(ByteSpan output) { }

	// RVA: 0x6F8E60 Offset: 0x6F8060 VA: 0x1806F8E60
	public static X25519.FieldElement Zero() { }

	// RVA: 0x1535940 Offset: 0x1534B40 VA: 0x181535940
	public static X25519.FieldElement One() { }

	// RVA: 0x1534240 Offset: 0x1533440 VA: 0x181534240
	public static void Add(ref X25519.FieldElement output, ref X25519.FieldElement a, ref X25519.FieldElement b) { }

	// RVA: 0x1535E40 Offset: 0x1535040 VA: 0x181535E40
	public static void Sub(ref X25519.FieldElement output, ref X25519.FieldElement a, ref X25519.FieldElement b) { }

	// RVA: 0x15350B0 Offset: 0x15342B0 VA: 0x1815350B0
	public static void Multiply(ref X25519.FieldElement output, ref X25519.FieldElement a, ref X25519.FieldElement b) { }

	// RVA: 0x1535970 Offset: 0x1534B70 VA: 0x181535970
	public static void Square(ref X25519.FieldElement output, ref X25519.FieldElement a) { }

	// RVA: 0x1534ED0 Offset: 0x15340D0 VA: 0x181534ED0
	public static void Multiply121666(ref X25519.FieldElement output, ref X25519.FieldElement a) { }

	// RVA: 0x1534BA0 Offset: 0x1533DA0 VA: 0x181534BA0
	public static void Invert(ref X25519.FieldElement output, ref X25519.FieldElement a) { }

	// RVA: 0x15342B0 Offset: 0x15334B0 VA: 0x1815342B0
	public static void ConditionalSwap(ref X25519.FieldElement a, ref X25519.FieldElement b, int swap) { }
}

// Namespace: Hazel.Crypto
public static class X25519 // TypeDefIndex: 16983
{
	// Fields
	private static readonly byte[] BasePoint; // 0x0

	// Methods

	// RVA: 0x1535FE0 Offset: 0x15351E0 VA: 0x181535FE0
	public static bool Func(ByteSpan output, ByteSpan scalar, ByteSpan point) { }

	// RVA: 0x1536090 Offset: 0x1535290 VA: 0x181536090
	public static void Func(ByteSpan output, ByteSpan scalar) { }

	// RVA: 0x1536130 Offset: 0x1535330 VA: 0x181536130
	private static void InternalFunc(ByteSpan output, ByteSpan scalar, ByteSpan point) { }

	// RVA: 0x1537080 Offset: 0x1536280 VA: 0x181537080
	private static void .cctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16984
{}

// Namespace: System.Net.Http
[Extension]
internal static class HttpUtilities // TypeDefIndex: 16985
{
	// Methods

	// RVA: 0x1EB5430 Offset: 0x1EB4630 VA: 0x181EB5430
	internal static bool IsSupportedSecureScheme(string scheme) { }

	// RVA: 0x1EB53E0 Offset: 0x1EB45E0 VA: 0x181EB53E0
	internal static bool IsSecureWebSocketScheme(string scheme) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HttpClientHandler.<>c // TypeDefIndex: 16986
{
	// Fields
	public static readonly HttpClientHandler.<>c <>9; // 0x0
	public static LocalCertificateSelectionCallback <>9__23_1; // 0x8

	// Methods

	// RVA: 0x1EC38C0 Offset: 0x1EC2AC0 VA: 0x181EC38C0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1EC38B0 Offset: 0x1EC2AB0 VA: 0x181EC38B0
	internal X509Certificate <set_ClientCertificateOptions>b__23_1(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}

// Namespace: System.Net.Http
public class HttpClientHandler : HttpMessageHandler // TypeDefIndex: 16987
{
	// Fields
	private readonly IMonoHttpClientHandler _delegatingHandler; // 0x10
	private ClientCertificateOption _clientCertificateOptions; // 0x18

	// Properties
	public virtual bool SupportsAutomaticDecompression { get; }
	public ClientCertificateOption ClientCertificateOptions { get; set; }
	public X509CertificateCollection ClientCertificates { get; }
	public DecompressionMethods AutomaticDecompression { set; }
	public IWebProxy Proxy { set; }

	// Methods

	// RVA: 0x1EACCA0 Offset: 0x1EABEA0 VA: 0x181EACCA0
	private static IMonoHttpClientHandler CreateDefaultHandler() { }

	// RVA: 0x1EAD370 Offset: 0x1EAC570 VA: 0x181EAD370
	public void .ctor() { }

	// RVA: 0x1EAD290 Offset: 0x1EAC490 VA: 0x181EAD290
	internal void .ctor(IMonoHttpClientHandler handler) { }

	// RVA: 0x1EACE60 Offset: 0x1EAC060 VA: 0x181EACE60 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1EAD740 Offset: 0x1EAC940 VA: 0x181EAD740 Slot: 7
	public virtual bool get_SupportsAutomaticDecompression() { }

	// RVA: 0x1EAD060 Offset: 0x1EAC260 VA: 0x181EAD060
	private void ThrowForModifiedManagedSslOptionsIfStarted() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ClientCertificateOption get_ClientCertificateOptions() { }

	// RVA: 0x1EAD850 Offset: 0x1EACA50 VA: 0x181EAD850
	public void set_ClientCertificateOptions(ClientCertificateOption value) { }

	// RVA: 0x1EAD5F0 Offset: 0x1EAC7F0 VA: 0x181EAD5F0
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1EAD790 Offset: 0x1EAC990 VA: 0x181EAD790
	public void set_AutomaticDecompression(DecompressionMethods value) { }

	// RVA: 0x1EADA50 Offset: 0x1EACC50 VA: 0x181EADA50
	public void set_Proxy(IWebProxy value) { }

	// RVA: 0x1EACF90 Offset: 0x1EAC190 VA: 0x181EACF90
	internal void SetWebRequestTimeout(TimeSpan timeout) { }

	// RVA: 0x1EACEC0 Offset: 0x1EAC0C0 VA: 0x181EACEC0 Slot: 6
	protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	[CompilerGenerated]
	// RVA: 0x1EAD140 Offset: 0x1EAC340 VA: 0x181EAD140
	private X509Certificate <set_ClientCertificateOptions>b__23_0(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}

// Namespace: System.Net.Http
internal interface IMonoHttpClientHandler : IDisposable // TypeDefIndex: 16988
{
	// Properties
	public abstract bool SupportsAutomaticDecompression { get; }
	public abstract SslClientAuthenticationOptions SslOptions { get; set; }
	public abstract DecompressionMethods AutomaticDecompression { set; }
	public abstract IWebProxy Proxy { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_SupportsAutomaticDecompression();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract SslClientAuthenticationOptions get_SslOptions();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_SslOptions(SslClientAuthenticationOptions value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_AutomaticDecompression(DecompressionMethods value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_Proxy(IWebProxy value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetWebRequestTimeout(TimeSpan timeout);
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MonoWebRequestHandler.<>c // TypeDefIndex: 16989
{
	// Fields
	public static readonly MonoWebRequestHandler.<>c <>9; // 0x0
	public static Func<string, bool> <>9__95_0; // 0x8
	public static Func<string, bool> <>9__96_1; // 0x10
	public static Action<object> <>9__99_0; // 0x18

	// Methods

	// RVA: 0x1EC3A40 Offset: 0x1EC2C40 VA: 0x181EC3A40
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1EC34E0 Offset: 0x1EC26E0 VA: 0x181EC34E0
	internal bool <GetConnectionKeepAlive>b__95_0(string l) { }

	// RVA: 0x1EC34A0 Offset: 0x1EC26A0 VA: 0x181EC34A0
	internal bool <CreateWebRequest>b__96_1(string l) { }

	// RVA: 0x1EC3530 Offset: 0x1EC2730 VA: 0x181EC3530
	internal void <SendAsync>b__99_0(object l) { }
}

// Namespace: 
[CompilerGenerated]
private struct MonoWebRequestHandler.<SendAsync>d__99 : IAsyncStateMachine // TypeDefIndex: 16990
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x8
	public MonoWebRequestHandler <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public HttpRequestMessage request; // 0x30
	private HttpWebRequest <wrequest>5__2; // 0x38
	private HttpWebResponse <wresponse>5__3; // 0x40
	private CancellationTokenRegistration <>7__wrap3; // 0x48
	private HttpContent <content>5__5; // 0x60
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x68
	private Stream <stream>5__6; // 0x78
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__2; // 0x80
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse> <>u__3; // 0x90
	private TaskAwaiter<HttpResponseMessage> <>u__4; // 0xA0

	// Methods

	// RVA: 0x1EC0D40 Offset: 0x1EBFF40 VA: 0x181EC0D40 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1EC2C70 Offset: 0x1EC1E70 VA: 0x181EC2C70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net.Http
internal class MonoWebRequestHandler : IMonoHttpClientHandler, IDisposable // TypeDefIndex: 16991
{
	// Fields
	private static long groupCounter; // 0x0
	private bool allowAutoRedirect; // 0x10
	private DecompressionMethods automaticDecompression; // 0x14
	private CookieContainer cookieContainer; // 0x18
	private ICredentials credentials; // 0x20
	private int maxAutomaticRedirections; // 0x28
	private long maxRequestContentBufferSize; // 0x30
	private bool preAuthenticate; // 0x38
	private IWebProxy proxy; // 0x40
	private bool useCookies; // 0x48
	private bool useProxy; // 0x49
	private SslClientAuthenticationOptions sslOptions; // 0x50
	private bool allowPipelining; // 0x58
	private RequestCachePolicy cachePolicy; // 0x60
	private AuthenticationLevel authenticationLevel; // 0x68
	private TimeSpan continueTimeout; // 0x70
	private TokenImpersonationLevel impersonationLevel; // 0x78
	private int maxResponseHeadersLength; // 0x7C
	private int readWriteTimeout; // 0x80
	private RemoteCertificateValidationCallback serverCertificateValidationCallback; // 0x88
	private bool unsafeAuthenticatedConnectionSharing; // 0x90
	private bool sentRequest; // 0x91
	private string connectionGroupName; // 0x98
	private Nullable<TimeSpan> timeout; // 0xA0
	private bool disposed; // 0xB0

	// Properties
	public DecompressionMethods AutomaticDecompression { set; }
	public CookieContainer CookieContainer { get; }
	public long MaxRequestContentBufferSize { get; }
	public IWebProxy Proxy { set; }
	public virtual bool SupportsAutomaticDecompression { get; }
	public bool UseProxy { get; }
	public SslClientAuthenticationOptions SslOptions { get; set; }

	// Methods

	// RVA: 0x1EB9100 Offset: 0x1EB8300 VA: 0x181EB9100
	public void .ctor() { }

	// RVA: 0x1EB8BF0 Offset: 0x1EB7DF0 VA: 0x181EB8BF0
	internal void EnsureModifiability() { }

	// RVA: 0x1EB9350 Offset: 0x1EB8550 VA: 0x181EB9350 Slot: 7
	public void set_AutomaticDecompression(DecompressionMethods value) { }

	// RVA: 0x1EB9290 Offset: 0x1EB8490 VA: 0x181EB9290 Slot: 12
	public CookieContainer get_CookieContainer() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 13
	public long get_MaxRequestContentBufferSize() { }

	// RVA: 0x1EB93C0 Offset: 0x1EB85C0 VA: 0x181EB93C0 Slot: 8
	public void set_Proxy(IWebProxy value) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 14
	public virtual bool get_SupportsAutomaticDecompression() { }

	// RVA: 0x563E30 Offset: 0x563030 VA: 0x180563E30 Slot: 15
	public bool get_UseProxy() { }

	// RVA: 0x1EB92F0 Offset: 0x1EB84F0 VA: 0x181EB92F0 Slot: 5
	public SslClientAuthenticationOptions get_SslOptions() { }

	// RVA: 0x1EB9470 Offset: 0x1EB8670 VA: 0x181EB9470 Slot: 6
	public void set_SslOptions(SslClientAuthenticationOptions value) { }

	// RVA: 0x1EB8BD0 Offset: 0x1EB7DD0 VA: 0x181EB8BD0 Slot: 11
	public void Dispose() { }

	// RVA: 0x1EB8B50 Offset: 0x1EB7D50 VA: 0x181EB8B50 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1EB8C60 Offset: 0x1EB7E60 VA: 0x181EB8C60
	private bool GetConnectionKeepAlive(HttpRequestHeaders headers) { }

	// RVA: 0x1EB7DA0 Offset: 0x1EB6FA0 VA: 0x181EB7DA0 Slot: 17
	internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request) { }

	// RVA: 0x1EB7990 Offset: 0x1EB6B90 VA: 0x181EB7990
	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) { }

	// RVA: 0x1EB8DB0 Offset: 0x1EB7FB0 VA: 0x181EB8DB0
	private static bool MethodHasBody(HttpMethod method) { }

	[AsyncStateMachine(typeof(MonoWebRequestHandler.<SendAsync>d__99))]
	// RVA: 0x1EB8EA0 Offset: 0x1EB80A0 VA: 0x181EB8EA0 Slot: 9
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	// RVA: 0x1EB8FD0 Offset: 0x1EB81D0 VA: 0x181EB8FD0 Slot: 10
	private void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(TimeSpan timeout) { }

	[CompilerGenerated]
	// RVA: 0x1EB9030 Offset: 0x1EB8230 VA: 0x181EB9030
	private X509Certificate <CreateWebRequest>b__96_0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }
}

// Namespace: System.Net.Http
internal static class PlatformHelper // TypeDefIndex: 16992
{
	// Methods

	// RVA: 0x1EBABA0 Offset: 0x1EB9DA0 VA: 0x181EBABA0
	internal static bool IsContentHeader(string name) { }

	// RVA: 0x1EBAB40 Offset: 0x1EB9D40 VA: 0x181EBAB40
	internal static string GetSingleHeaderString(string name, IEnumerable<string> values) { }

	// RVA: 0x1EBAA50 Offset: 0x1EB9C50 VA: 0x181EBAA50
	internal static StreamContent CreateStreamContent(Stream stream, CancellationToken cancellationToken) { }
}

// Namespace: System.Net.Http
public class ByteArrayContent : HttpContent // TypeDefIndex: 16993
{
	// Fields
	private readonly byte[] content; // 0x30
	private readonly int offset; // 0x38
	private readonly int count; // 0x3C

	// Methods

	// RVA: 0x1EA8AD0 Offset: 0x1EA7CD0 VA: 0x181EA8AD0
	public void .ctor(byte[] content) { }

	// RVA: 0x1EA89C0 Offset: 0x1EA7BC0 VA: 0x181EA89C0 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x1EA8A80 Offset: 0x1EA7C80 VA: 0x181EA8A80 Slot: 7
	protected override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x1EA8AC0 Offset: 0x1EA7CC0 VA: 0x181EA8AC0 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }
}

// Namespace: System.Net.Http
public enum ClientCertificateOption // TypeDefIndex: 16994
{
	// Fields
	public int value__; // 0x0
	public const ClientCertificateOption Manual = 0;
	public const ClientCertificateOption Automatic = 1;
}

// Namespace: System.Net.Http
public abstract class DelegatingHandler : HttpMessageHandler // TypeDefIndex: 16995
{
	// Fields
	private bool disposed; // 0x10
	private HttpMessageHandler handler; // 0x18

	// Properties
	public HttpMessageHandler InnerHandler { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x1EAC090 Offset: 0x1EAB290 VA: 0x181EAC090
	protected void .ctor(HttpMessageHandler innerHandler) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public HttpMessageHandler get_InnerHandler() { }

	// RVA: 0x1EAC110 Offset: 0x1EAB310 VA: 0x181EAC110
	public void set_InnerHandler(HttpMessageHandler value) { }

	// RVA: 0x1EABFE0 Offset: 0x1EAB1E0 VA: 0x181EABFE0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1EAC010 Offset: 0x1EAB210 VA: 0x181EAC010 Slot: 6
	protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpClient.<SendAsyncWorker>d__47 : IAsyncStateMachine // TypeDefIndex: 16996
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public HttpRequestMessage request; // 0x30
	public HttpCompletionOption completionOption; // 0x38
	private CancellationTokenSource <lcts>5__2; // 0x40
	private HttpResponseMessage <response>5__3; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x1EC2CE0 Offset: 0x1EC1EE0 VA: 0x181EC2CE0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1EC3430 Offset: 0x1EC2630 VA: 0x181EC3430 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net.Http
public class HttpClient : HttpMessageInvoker // TypeDefIndex: 16997
{
	// Fields
	private static readonly TimeSpan TimeoutDefault; // 0x0
	private Uri base_address; // 0x20
	private CancellationTokenSource cts; // 0x28
	private bool disposed; // 0x30
	private HttpRequestHeaders headers; // 0x38
	private long buffer_size; // 0x40
	private TimeSpan timeout; // 0x48

	// Properties
	public HttpRequestHeaders DefaultRequestHeaders { get; }
	public long MaxResponseContentBufferSize { get; }

	// Methods

	// RVA: 0x1EAE630 Offset: 0x1EAD830 VA: 0x181EAE630
	public void .ctor() { }

	// RVA: 0x1EAE530 Offset: 0x1EAD730 VA: 0x181EAE530
	public void .ctor(HttpMessageHandler handler) { }

	// RVA: 0x1EAE420 Offset: 0x1EAD620 VA: 0x181EAE420
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x1EAE760 Offset: 0x1EAD960 VA: 0x181EAE760
	public HttpRequestHeaders get_DefaultRequestHeaders() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public long get_MaxResponseContentBufferSize() { }

	// RVA: 0x1EADB20 Offset: 0x1EACD20 VA: 0x181EADB20 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1EADB90 Offset: 0x1EACD90 VA: 0x181EADB90
	public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	// RVA: 0x1EADEA0 Offset: 0x1EAD0A0 VA: 0x181EADEA0
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) { }

	// RVA: 0x1EAE360 Offset: 0x1EAD560 VA: 0x181EAE360 Slot: 6
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	// RVA: 0x1EADF10 Offset: 0x1EAD110 VA: 0x181EADF10
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(HttpClient.<SendAsyncWorker>d__47))]
	// RVA: 0x1EADD70 Offset: 0x1EACF70 VA: 0x181EADD70
	private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	// RVA: 0x1EAE3B0 Offset: 0x1EAD5B0 VA: 0x181EAE3B0
	private static void .cctor() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1EAE380 Offset: 0x1EAD580 VA: 0x181EAE380
	private Task<HttpResponseMessage> <>n__0(HttpRequestMessage request, CancellationToken cancellationToken) { }
}

// Namespace: System.Net.Http
public enum HttpCompletionOption // TypeDefIndex: 16998
{
	// Fields
	public int value__; // 0x0
	public const HttpCompletionOption ResponseContentRead = 0;
	public const HttpCompletionOption ResponseHeadersRead = 1;
}

// Namespace: 
private sealed class HttpContent.FixedMemoryStream : MemoryStream // TypeDefIndex: 16999
{
	// Fields
	private readonly long maxSize; // 0x50

	// Methods

	// RVA: 0x1EACA00 Offset: 0x1EABC00 VA: 0x181EACA00
	public void .ctor(long maxSize) { }

	// RVA: 0x1EAC8A0 Offset: 0x1EABAA0 VA: 0x181EAC8A0
	private void CheckOverflow(int count) { }

	// RVA: 0x1EAC960 Offset: 0x1EABB60 VA: 0x181EAC960 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x1EAC9A0 Offset: 0x1EABBA0 VA: 0x181EAC9A0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpContent.<CreateContentReadStreamAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 17000
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1EBF920 Offset: 0x1EBEB20 VA: 0x181EBF920 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1EBFAD0 Offset: 0x1EBECD0 VA: 0x181EBFAD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpContent.<LoadIntoBufferAsync>d__17 : IAsyncStateMachine // TypeDefIndex: 17001
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	public long maxBufferSize; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1EBFF90 Offset: 0x1EBF190 VA: 0x181EBFF90 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1EC0230 Offset: 0x1EBF430 VA: 0x181EC0230 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpContent.<ReadAsStreamAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 17002
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x28

	// Methods

	// RVA: 0x1EC04E0 Offset: 0x1EBF6E0 VA: 0x181EC04E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1EC0810 Offset: 0x1EBFA10 VA: 0x181EC0810 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpContent.<ReadAsByteArrayAsync>d__19 : IAsyncStateMachine // TypeDefIndex: 17003
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1EC0290 Offset: 0x1EBF490 VA: 0x181EC0290 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1EC0470 Offset: 0x1EBF670 VA: 0x181EC0470 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpContent.<ReadAsStringAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 17004
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1EC0880 Offset: 0x1EBFA80 VA: 0x181EC0880 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1EC0CD0 Offset: 0x1EBFED0 VA: 0x181EC0CD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net.Http
public abstract class HttpContent : IDisposable // TypeDefIndex: 17005
{
	// Fields
	private HttpContent.FixedMemoryStream buffer; // 0x10
	private Stream stream; // 0x18
	private bool disposed; // 0x20
	private HttpContentHeaders headers; // 0x28

	// Properties
	public HttpContentHeaders Headers { get; }
	internal Nullable<long> LoadedBufferLength { get; }

	// Methods

	// RVA: 0x1EAF3C0 Offset: 0x1EAE5C0 VA: 0x181EAF3C0
	public HttpContentHeaders get_Headers() { }

	// RVA: 0x1EAF460 Offset: 0x1EAE660 VA: 0x181EAF460
	internal Nullable<long> get_LoadedBufferLength() { }

	// RVA: 0x1EAEB30 Offset: 0x1EADD30 VA: 0x181EAEB30
	public Task CopyToAsync(Stream stream) { }

	// RVA: 0x1EAEBD0 Offset: 0x1EADDD0 VA: 0x181EAEBD0
	public Task CopyToAsync(Stream stream, TransportContext context) { }

	[AsyncStateMachine(typeof(HttpContent.<CreateContentReadStreamAsync>d__12))]
	// RVA: 0x1EAEC70 Offset: 0x1EADE70 VA: 0x181EAEC70 Slot: 5
	protected virtual Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x1EAED40 Offset: 0x1EADF40 VA: 0x181EAED40
	private static HttpContent.FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) { }

	// RVA: 0x151FDB0 Offset: 0x151EFB0 VA: 0x18151FDB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1EAEDA0 Offset: 0x1EADFA0 VA: 0x181EAEDA0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1EAF0D0 Offset: 0x1EAE2D0 VA: 0x181EAF0D0
	public Task LoadIntoBufferAsync() { }

	[AsyncStateMachine(typeof(HttpContent.<LoadIntoBufferAsync>d__17))]
	// RVA: 0x1EAEFF0 Offset: 0x1EAE1F0 VA: 0x181EAEFF0
	public Task LoadIntoBufferAsync(long maxBufferSize) { }

	[AsyncStateMachine(typeof(HttpContent.<ReadAsStreamAsync>d__18))]
	// RVA: 0x1EAF1B0 Offset: 0x1EAE3B0 VA: 0x181EAF1B0
	public Task<Stream> ReadAsStreamAsync() { }

	[AsyncStateMachine(typeof(HttpContent.<ReadAsByteArrayAsync>d__19))]
	// RVA: 0x1EAF0E0 Offset: 0x1EAE2E0 VA: 0x181EAF0E0
	public Task<byte[]> ReadAsByteArrayAsync() { }

	[AsyncStateMachine(typeof(HttpContent.<ReadAsStringAsync>d__20))]
	// RVA: 0x1EAF280 Offset: 0x1EAE480 VA: 0x181EAF280
	public Task<string> ReadAsStringAsync() { }

	// RVA: 0x1EAEDD0 Offset: 0x1EADFD0 VA: 0x181EAEDD0
	private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength) { }

	// RVA: 0x1EAF350 Offset: 0x1EAE550 VA: 0x181EAF350
	private static int StartsWith(byte[] array, int length, byte[] value) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract Task SerializeToStreamAsync(Stream stream, TransportContext context);

	// RVA: -1 Offset: -1 Slot: 8
	protected internal abstract bool TryComputeLength(out long length);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.Http
public abstract class HttpMessageHandler : IDisposable // TypeDefIndex: 17006
{
	// Methods

	// RVA: 0x1744B80 Offset: 0x1743D80 VA: 0x181744B80 Slot: 4
	public void Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Net.Http
public class HttpMessageInvoker : IDisposable // TypeDefIndex: 17007
{
	// Fields
	internal HttpMessageHandler handler; // 0x10
	private readonly bool disposeHandler; // 0x18

	// Methods

	// RVA: 0x1EB3270 Offset: 0x1EB2470 VA: 0x181EB3270
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x1744B80 Offset: 0x1743D80 VA: 0x181744B80 Slot: 4
	public void Dispose() { }

	// RVA: 0x1EB3230 Offset: 0x1EB2430 VA: 0x181EB3230 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1EAE380 Offset: 0x1EAD580 VA: 0x181EAE380 Slot: 6
	public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }
}

// Namespace: System.Net.Http
public class HttpMethod : IEquatable<HttpMethod> // TypeDefIndex: 17008
{
	// Fields
	private static readonly HttpMethod delete_method; // 0x0
	private static readonly HttpMethod get_method; // 0x8
	private static readonly HttpMethod head_method; // 0x10
	private static readonly HttpMethod options_method; // 0x18
	private static readonly HttpMethod post_method; // 0x20
	private static readonly HttpMethod put_method; // 0x28
	private static readonly HttpMethod trace_method; // 0x30
	private readonly string method; // 0x10

	// Properties
	public static HttpMethod Get { get; }
	public string Method { get; }
	public static HttpMethod Post { get; }

	// Methods

	// RVA: 0x1EB3830 Offset: 0x1EB2A30 VA: 0x181EB3830
	public void .ctor(string method) { }

	// RVA: 0x1EB38C0 Offset: 0x1EB2AC0 VA: 0x181EB38C0
	public static HttpMethod get_Get() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Method() { }

	// RVA: 0x1EB3910 Offset: 0x1EB2B10 VA: 0x181EB3910
	public static HttpMethod get_Post() { }

	// RVA: 0x1EB3960 Offset: 0x1EB2B60 VA: 0x181EB3960
	public static bool op_Equality(HttpMethod left, HttpMethod right) { }

	// RVA: 0x1EB3300 Offset: 0x1EB2500 VA: 0x181EB3300 Slot: 4
	public bool Equals(HttpMethod other) { }

	// RVA: 0x1EB3330 Offset: 0x1EB2530 VA: 0x181EB3330 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EB33D0 Offset: 0x1EB25D0 VA: 0x181EB33D0
	private static void .cctor() { }
}

// Namespace: System.Net.Http
[Serializable]
public class HttpRequestException : Exception // TypeDefIndex: 17009
{
	// Methods

	// RVA: 0x1EB3990 Offset: 0x1EB2B90 VA: 0x181EB3990
	public void .ctor() { }

	// RVA: 0x1EB39E0 Offset: 0x1EB2BE0 VA: 0x181EB39E0
	public void .ctor(string message) { }

	// RVA: 0x1EB3A40 Offset: 0x1EB2C40 VA: 0x181EB3A40
	public void .ctor(string message, Exception inner) { }
}

// Namespace: System.Net.Http
public class HttpRequestMessage : IDisposable // TypeDefIndex: 17010
{
	// Fields
	private HttpRequestHeaders headers; // 0x10
	private HttpMethod method; // 0x18
	private Version version; // 0x20
	private Uri uri; // 0x28
	private bool is_used; // 0x30
	private bool disposed; // 0x31
	[CompilerGenerated]
	private HttpContent <Content>k__BackingField; // 0x38

	// Properties
	public HttpContent Content { get; set; }
	public HttpRequestHeaders Headers { get; }
	public HttpMethod Method { get; set; }
	public Uri RequestUri { get; set; }
	public Version Version { get; }

	// Methods

	// RVA: 0x1EB48B0 Offset: 0x1EB3AB0 VA: 0x181EB48B0
	public void .ctor() { }

	// RVA: 0x1EB4790 Offset: 0x1EB3990 VA: 0x181EB4790
	public void .ctor(HttpMethod method, string requestUri) { }

	// RVA: 0x1EB4950 Offset: 0x1EB3B50 VA: 0x181EB4950
	public void .ctor(HttpMethod method, Uri requestUri) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public HttpContent get_Content() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Content(HttpContent value) { }

	// RVA: 0x1EB4A10 Offset: 0x1EB3C10 VA: 0x181EB4A10
	public HttpRequestHeaders get_Headers() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public HttpMethod get_Method() { }

	// RVA: 0x1EB4B10 Offset: 0x1EB3D10 VA: 0x181EB4B10
	public void set_Method(HttpMethod value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Uri get_RequestUri() { }

	// RVA: 0x1EB4BB0 Offset: 0x1EB3DB0 VA: 0x181EB4BB0
	public void set_RequestUri(Uri value) { }

	// RVA: 0x1EB4360 Offset: 0x1EB3560 VA: 0x181EB4360
	private static bool IsAllowedAbsoluteUri(Uri uri) { }

	// RVA: 0x1EB4AB0 Offset: 0x1EB3CB0 VA: 0x181EB4AB0
	public Version get_Version() { }

	// RVA: 0x1744B80 Offset: 0x1743D80 VA: 0x181744B80 Slot: 4
	public void Dispose() { }

	// RVA: 0x1EB4330 Offset: 0x1EB3530 VA: 0x181EB4330 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1EB44C0 Offset: 0x1EB36C0 VA: 0x181EB44C0
	internal bool SetIsUsed() { }

	// RVA: 0x1EB44D0 Offset: 0x1EB36D0 VA: 0x181EB44D0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http
public class HttpResponseMessage : IDisposable // TypeDefIndex: 17011
{
	// Fields
	private HttpResponseHeaders headers; // 0x10
	private string reasonPhrase; // 0x18
	private HttpStatusCode statusCode; // 0x20
	private Version version; // 0x28
	private bool disposed; // 0x30
	[CompilerGenerated]
	private HttpContent <Content>k__BackingField; // 0x38
	[CompilerGenerated]
	private HttpRequestMessage <RequestMessage>k__BackingField; // 0x40

	// Properties
	public HttpContent Content { get; set; }
	public HttpResponseHeaders Headers { get; }
	public bool IsSuccessStatusCode { get; }
	public string ReasonPhrase { get; set; }
	public HttpRequestMessage RequestMessage { get; set; }
	public HttpStatusCode StatusCode { get; set; }
	public Version Version { get; }

	// Methods

	// RVA: 0x1EB51D0 Offset: 0x1EB43D0 VA: 0x181EB51D0
	public void .ctor(HttpStatusCode statusCode) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public HttpContent get_Content() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Content(HttpContent value) { }

	// RVA: 0x1EB5240 Offset: 0x1EB4440 VA: 0x181EB5240
	public HttpResponseHeaders get_Headers() { }

	// RVA: 0x1EB52E0 Offset: 0x1EB44E0 VA: 0x181EB52E0
	public bool get_IsSuccessStatusCode() { }

	// RVA: 0x1EB5300 Offset: 0x1EB4500 VA: 0x181EB5300
	public string get_ReasonPhrase() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReasonPhrase(string value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public HttpRequestMessage get_RequestMessage() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_RequestMessage(HttpRequestMessage value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x1EB5380 Offset: 0x1EB4580 VA: 0x181EB5380
	public void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x1EB5320 Offset: 0x1EB4520 VA: 0x181EB5320
	public Version get_Version() { }

	// RVA: 0x1744B80 Offset: 0x1743D80 VA: 0x181744B80 Slot: 4
	public void Dispose() { }

	// RVA: 0x1EB4E60 Offset: 0x1EB4060 VA: 0x181EB4E60 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1EB4E90 Offset: 0x1EB4090 VA: 0x181EB4E90
	public HttpResponseMessage EnsureSuccessStatusCode() { }

	// RVA: 0x1EB4F50 Offset: 0x1EB4150 VA: 0x181EB4F50 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http
public class StreamContent : HttpContent // TypeDefIndex: 17012
{
	// Fields
	private readonly Stream content; // 0x30
	private readonly int bufferSize; // 0x38
	private readonly CancellationToken cancellationToken; // 0x40
	private readonly long startPosition; // 0x48
	private bool contentCopied; // 0x50

	// Methods

	// RVA: 0x1EBDEC0 Offset: 0x1EBD0C0 VA: 0x181EBDEC0
	public void .ctor(Stream content) { }

	// RVA: 0x1EBDDB0 Offset: 0x1EBCFB0 VA: 0x181EBDDB0
	public void .ctor(Stream content, int bufferSize) { }

	// RVA: 0x1EBDF70 Offset: 0x1EBD170 VA: 0x181EBDF70
	internal void .ctor(Stream content, CancellationToken cancellationToken) { }

	// RVA: 0x1EBDB90 Offset: 0x1EBCD90 VA: 0x181EBDB90 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x1EBDBF0 Offset: 0x1EBCDF0 VA: 0x181EBDBF0 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1EBDC40 Offset: 0x1EBCE40 VA: 0x181EBDC40 Slot: 7
	protected override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x1EBDD30 Offset: 0x1EBCF30 VA: 0x181EBDD30 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }
}

// Namespace: System.Net.Http
public class StringContent : ByteArrayContent // TypeDefIndex: 17013
{
	// Methods

	// RVA: 0x1EBE080 Offset: 0x1EBD280 VA: 0x181EBE080
	public void .ctor(string content) { }

	// RVA: 0x1EBE0A0 Offset: 0x1EBD2A0 VA: 0x181EBE0A0
	public void .ctor(string content, Encoding encoding, string mediaType) { }

	// RVA: 0x1EBE030 Offset: 0x1EBD230 VA: 0x181EBE030
	private static byte[] GetByteArray(string content, Encoding encoding) { }
}

// Namespace: System.Net.Http.Headers
public class AuthenticationHeaderValue : ICloneable // TypeDefIndex: 17014
{
	// Fields
	[CompilerGenerated]
	private string <Parameter>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Scheme>k__BackingField; // 0x18

	// Properties
	public string Parameter { get; set; }
	public string Scheme { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Parameter() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_Parameter(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Scheme() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_Scheme(string value) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EA8460 Offset: 0x1EA7660 VA: 0x181EA8460 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EA8520 Offset: 0x1EA7720 VA: 0x181EA8520 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EA8840 Offset: 0x1EA7A40 VA: 0x181EA8840
	public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue) { }

	// RVA: 0x1EA8910 Offset: 0x1EA7B10 VA: 0x181EA8910
	internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result) { }

	// RVA: 0x1EA8610 Offset: 0x1EA7810 VA: 0x181EA8610
	private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1EA85B0 Offset: 0x1EA77B0 VA: 0x181EA85B0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class CacheControlHeaderValue : ICloneable // TypeDefIndex: 17015
{
	// Fields
	private List<NameValueHeaderValue> extensions; // 0x10
	private List<string> no_cache_headers; // 0x18
	private List<string> private_headers; // 0x20
	[CompilerGenerated]
	private Nullable<TimeSpan> <MaxAge>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <MaxStale>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<TimeSpan> <MaxStaleLimit>k__BackingField; // 0x40
	[CompilerGenerated]
	private Nullable<TimeSpan> <MinFresh>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <MustRevalidate>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <NoCache>k__BackingField; // 0x61
	[CompilerGenerated]
	private bool <NoStore>k__BackingField; // 0x62
	[CompilerGenerated]
	private bool <NoTransform>k__BackingField; // 0x63
	[CompilerGenerated]
	private bool <OnlyIfCached>k__BackingField; // 0x64
	[CompilerGenerated]
	private bool <Private>k__BackingField; // 0x65
	[CompilerGenerated]
	private bool <ProxyRevalidate>k__BackingField; // 0x66
	[CompilerGenerated]
	private bool <Public>k__BackingField; // 0x67
	[CompilerGenerated]
	private Nullable<TimeSpan> <SharedMaxAge>k__BackingField; // 0x68

	// Properties
	public ICollection<NameValueHeaderValue> Extensions { get; }
	public Nullable<TimeSpan> MaxAge { get; set; }
	public bool MaxStale { get; set; }
	public Nullable<TimeSpan> MaxStaleLimit { get; set; }
	public Nullable<TimeSpan> MinFresh { get; set; }
	public bool MustRevalidate { get; set; }
	public bool NoCache { get; set; }
	public ICollection<string> NoCacheHeaders { get; }
	public bool NoStore { get; set; }
	public bool NoTransform { get; set; }
	public bool OnlyIfCached { get; set; }
	public bool Private { get; set; }
	public ICollection<string> PrivateHeaders { get; }
	public bool ProxyRevalidate { get; set; }
	public bool Public { get; set; }
	public Nullable<TimeSpan> SharedMaxAge { get; set; }

	// Methods

	// RVA: 0x1EAA8A0 Offset: 0x1EA9AA0 VA: 0x181EAA8A0
	public ICollection<NameValueHeaderValue> get_Extensions() { }

	[CompilerGenerated]
	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80
	public Nullable<TimeSpan> get_MaxAge() { }

	[CompilerGenerated]
	// RVA: 0x3F6CA0 Offset: 0x3F5EA0 VA: 0x1803F6CA0
	public void set_MaxAge(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_MaxStale() { }

	[CompilerGenerated]
	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_MaxStale(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4D1A20 Offset: 0x4D0C20 VA: 0x1804D1A20
	public Nullable<TimeSpan> get_MaxStaleLimit() { }

	[CompilerGenerated]
	// RVA: 0x4D1A60 Offset: 0x4D0C60 VA: 0x1804D1A60
	public void set_MaxStaleLimit(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	// RVA: 0xC5DC80 Offset: 0xC5CE80 VA: 0x180C5DC80
	public Nullable<TimeSpan> get_MinFresh() { }

	[CompilerGenerated]
	// RVA: 0x1EAAA00 Offset: 0x1EA9C00 VA: 0x181EAAA00
	public void set_MinFresh(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290
	public bool get_MustRevalidate() { }

	[CompilerGenerated]
	// RVA: 0x4EE2A0 Offset: 0x4ED4A0 VA: 0x1804EE2A0
	public void set_MustRevalidate(bool value) { }

	[CompilerGenerated]
	// RVA: 0xE5B220 Offset: 0xE5A420 VA: 0x180E5B220
	public bool get_NoCache() { }

	[CompilerGenerated]
	// RVA: 0xE5B990 Offset: 0xE5AB90 VA: 0x180E5B990
	public void set_NoCache(bool value) { }

	// RVA: 0x1EAA910 Offset: 0x1EA9B10 VA: 0x181EAA910
	public ICollection<string> get_NoCacheHeaders() { }

	[CompilerGenerated]
	// RVA: 0x15CB1A0 Offset: 0x15CA3A0 VA: 0x1815CB1A0
	public bool get_NoStore() { }

	[CompilerGenerated]
	// RVA: 0x192A660 Offset: 0x1929860 VA: 0x18192A660
	public void set_NoStore(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1EAA980 Offset: 0x1EA9B80 VA: 0x181EAA980
	public bool get_NoTransform() { }

	[CompilerGenerated]
	// RVA: 0x1EAAA10 Offset: 0x1EA9C10 VA: 0x181EAAA10
	public void set_NoTransform(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C44B00 Offset: 0x1C43D00 VA: 0x181C44B00
	public bool get_OnlyIfCached() { }

	[CompilerGenerated]
	// RVA: 0x1C44BF0 Offset: 0x1C43DF0 VA: 0x181C44BF0
	public void set_OnlyIfCached(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E01BB0 Offset: 0x1E00DB0 VA: 0x181E01BB0
	public bool get_Private() { }

	[CompilerGenerated]
	// RVA: 0x1EAAA20 Offset: 0x1EA9C20 VA: 0x181EAAA20
	public void set_Private(bool value) { }

	// RVA: 0x1EAA990 Offset: 0x1EA9B90 VA: 0x181EAA990
	public ICollection<string> get_PrivateHeaders() { }

	[CompilerGenerated]
	// RVA: 0x1E00F40 Offset: 0x1E00140 VA: 0x181E00F40
	public bool get_ProxyRevalidate() { }

	[CompilerGenerated]
	// RVA: 0x1EAAA30 Offset: 0x1EA9C30 VA: 0x181EAAA30
	public void set_ProxyRevalidate(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E00F30 Offset: 0x1E00130 VA: 0x181E00F30
	public bool get_Public() { }

	[CompilerGenerated]
	// RVA: 0x1EAAA40 Offset: 0x1EA9C40 VA: 0x181EAAA40
	public void set_Public(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C75730 Offset: 0x1C74930 VA: 0x181C75730
	public Nullable<TimeSpan> get_SharedMaxAge() { }

	[CompilerGenerated]
	// RVA: 0x1C75820 Offset: 0x1C74A20 VA: 0x181C75820
	public void set_SharedMaxAge(Nullable<TimeSpan> value) { }

	// RVA: 0x1EA90B0 Offset: 0x1EA82B0 VA: 0x181EA90B0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EA8B50 Offset: 0x1EA7D50 VA: 0x181EA8B50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EA8E40 Offset: 0x1EA8040 VA: 0x181EA8E40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EA9D70 Offset: 0x1EA8F70 VA: 0x181EA9D70
	public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) { }

	// RVA: 0x1EA9630 Offset: 0x1EA8830 VA: 0x181EA9630 Slot: 3
	public override string ToString() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Net.Http.Headers
[Extension]
internal static class CollectionExtensions // TypeDefIndex: 17016
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(List<TSource> first, List<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x947B70 Offset: 0x946D70 VA: 0x180947B70
	|-CollectionExtensions.SequenceEqual<object>
	|
	|-RVA: 0x947AC0 Offset: 0x946CC0 VA: 0x180947AC0
	|-CollectionExtensions.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1EAAA50 Offset: 0x1EA9C50 VA: 0x181EAAA50
	public static void SetValue(List<NameValueHeaderValue> parameters, string key, string value) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static string ToString<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x948360 Offset: 0x947560 VA: 0x180948360
	|-CollectionExtensions.ToString<object>
	|
	|-RVA: 0x9481C0 Offset: 0x9473C0 VA: 0x1809481C0
	|-CollectionExtensions.ToString<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void ToStringBuilder<T>(List<T> list, StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x948100 Offset: 0x947300 VA: 0x180948100
	|-CollectionExtensions.ToStringBuilder<object>
	|
	|-RVA: 0x947FA0 Offset: 0x9471A0 VA: 0x180947FA0
	|-CollectionExtensions.ToStringBuilder<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Net.Http.Headers
internal sealed class ElementTryParser<T> : MulticastDelegate // TypeDefIndex: 17017
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DCA30 Offset: 0x10DBC30 VA: 0x1810DCA30
	|-ElementTryParser<object>..ctor
	|-ElementTryParser<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(Lexer lexer, out T parsedValue, out Token token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0
	|-ElementTryParser<object>.Invoke
	|-ElementTryParser<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System.Net.Http.Headers
internal static class CollectionParser // TypeDefIndex: 17018
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool TryParse<T>(string input, int minimalCount, ElementTryParser<T> parser, out List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x948460 Offset: 0x947660 VA: 0x180948460
	|-CollectionParser.TryParse<object>
	*/

	// RVA: 0x1EAAD10 Offset: 0x1EA9F10 VA: 0x181EAAD10
	public static bool TryParse(string input, int minimalCount, out List<string> result) { }

	// RVA: 0x1EAABC0 Offset: 0x1EA9DC0 VA: 0x181EAABC0
	private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out Token t) { }
}

// Namespace: System.Net.Http.Headers
public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 17019
{
	// Fields
	private string dispositionType; // 0x10
	private List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1EAB1A0 Offset: 0x1EAA3A0 VA: 0x181EAB1A0
	protected void .ctor(ContentDispositionHeaderValue source) { }

	// RVA: 0x1EAB450 Offset: 0x1EAA650 VA: 0x181EAB450
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1EAAF10 Offset: 0x1EAA110 VA: 0x181EAAF10 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EAADC0 Offset: 0x1EA9FC0 VA: 0x181EAADC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EAAE90 Offset: 0x1EAA090 VA: 0x181EAAE90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EAAF70 Offset: 0x1EAA170 VA: 0x181EAAF70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EAAFD0 Offset: 0x1EAA1D0 VA: 0x181EAAFD0
	public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue) { }
}

// Namespace: System.Net.Http.Headers
public class ContentRangeHeaderValue : ICloneable // TypeDefIndex: 17020
{
	// Fields
	private string unit; // 0x10
	[CompilerGenerated]
	private Nullable<long> <From>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<long> <Length>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<long> <To>k__BackingField; // 0x38

	// Properties
	public Nullable<long> From { get; set; }
	public Nullable<long> Length { get; set; }
	public Nullable<long> To { get; set; }
	public string Unit { get; }

	// Methods

	// RVA: 0x1EABE80 Offset: 0x1EAB080 VA: 0x181EABE80
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public Nullable<long> get_From() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	private void set_From(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80
	public Nullable<long> get_Length() { }

	[CompilerGenerated]
	// RVA: 0x3F6CA0 Offset: 0x3F5EA0 VA: 0x1803F6CA0
	private void set_Length(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x526C40 Offset: 0x525E40 VA: 0x180526C40
	public Nullable<long> get_To() { }

	[CompilerGenerated]
	// RVA: 0x526D50 Offset: 0x525F50 VA: 0x180526D50
	private void set_To(Nullable<long> value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Unit() { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EAB4C0 Offset: 0x1EAA6C0 VA: 0x181EAB4C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EAB5F0 Offset: 0x1EAA7F0 VA: 0x181EAB5F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EAB950 Offset: 0x1EAAB50 VA: 0x181EAB950
	public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue) { }

	// RVA: 0x1EAB700 Offset: 0x1EAA900 VA: 0x181EAB700 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 17021
{
	// Fields
	private static readonly EntityTagHeaderValue any; // 0x0
	[CompilerGenerated]
	private bool <IsWeak>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Tag>k__BackingField; // 0x18

	// Properties
	public bool IsWeak { get; set; }
	public string Tag { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsWeak() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void set_IsWeak(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Tag() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_Tag(string value) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EAC1F0 Offset: 0x1EAB3F0 VA: 0x181EAC1F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EAC2B0 Offset: 0x1EAB4B0 VA: 0x181EAC2B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EAC680 Offset: 0x1EAB880 VA: 0x181EAC680
	public static bool TryParse(string input, out EntityTagHeaderValue parsedValue) { }

	// RVA: 0x1EAC390 Offset: 0x1EAB590 VA: 0x181EAC390
	private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1EAC770 Offset: 0x1EAB970 VA: 0x181EAC770
	internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result) { }

	// RVA: 0x1EAC340 Offset: 0x1EAB540 VA: 0x181EAC340 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EAC820 Offset: 0x1EABA20 VA: 0x181EAC820
	private static void .cctor() { }
}

// Namespace: System.Net.Http.Headers
internal static class HashCodeCalculator // TypeDefIndex: 17022
{
	// Methods

	// RVA: -1 Offset: -1
	public static int Calculate<T>(ICollection<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B0590 Offset: 0x9AF790 VA: 0x1809B0590
	|-HashCodeCalculator.Calculate<object>
	|
	|-RVA: 0x9B02A0 Offset: 0x9AF4A0 VA: 0x1809B02A0
	|-HashCodeCalculator.Calculate<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Net.Http.Headers
internal sealed class TryParseDelegate<T> : MulticastDelegate // TypeDefIndex: 17023
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC5A20 Offset: 0xCC4C20 VA: 0x180CC5A20
	|-TryParseDelegate<DateTimeOffset>..ctor
	|-TryParseDelegate<int>..ctor
	|-TryParseDelegate<long>..ctor
	|-TryParseDelegate<object>..ctor
	|-TryParseDelegate<TimeSpan>..ctor
	|-TryParseDelegate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(string value, out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-TryParseDelegate<DateTimeOffset>.Invoke
	|-TryParseDelegate<int>.Invoke
	|-TryParseDelegate<long>.Invoke
	|-TryParseDelegate<object>.Invoke
	|-TryParseDelegate<TimeSpan>.Invoke
	|-TryParseDelegate<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System.Net.Http.Headers
internal sealed class TryParseListDelegate<T> : MulticastDelegate // TypeDefIndex: 17024
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC5AD0 Offset: 0xCC4CD0 VA: 0x180CC5AD0
	|-TryParseListDelegate<object>..ctor
	|-TryParseListDelegate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(string value, int minimalCount, out List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0
	|-TryParseListDelegate<object>.Invoke
	|-TryParseListDelegate<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private class HeaderInfo.HeaderTypeInfo<T, U> : HeaderInfo // TypeDefIndex: 17025
{
	// Fields
	private readonly TryParseDelegate<T> parser; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DE40 Offset: 0x125D040 VA: 0x18125DE40
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<int, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<long, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<object, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<__Il2CppFullySharedGenericType, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void AddToCollection(object collection, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125C390 Offset: 0x125B590 VA: 0x18125C390
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<int, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<long, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<object, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<__Il2CppFullySharedGenericType, object>.AddToCollection
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125C520 Offset: 0x125B720 VA: 0x18125C520
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<int, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<long, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<object, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<__Il2CppFullySharedGenericType, object>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override List<string> ToStringCollection(object collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125C940 Offset: 0x125BB40 VA: 0x18125C940
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.ToStringCollection
	|
	|-RVA: 0x125D7C0 Offset: 0x125C9C0 VA: 0x18125D7C0
	|-HeaderInfo.HeaderTypeInfo<int, object>.ToStringCollection
	|
	|-RVA: 0x125C5A0 Offset: 0x125B7A0 VA: 0x18125C5A0
	|-HeaderInfo.HeaderTypeInfo<long, object>.ToStringCollection
	|
	|-RVA: 0x125D080 Offset: 0x125C280 VA: 0x18125D080
	|-HeaderInfo.HeaderTypeInfo<object, object>.ToStringCollection
	|
	|-RVA: 0x125CCE0 Offset: 0x125BEE0 VA: 0x18125CCE0
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.ToStringCollection
	|
	|-RVA: 0x125D420 Offset: 0x125C620 VA: 0x18125D420
	|-HeaderInfo.HeaderTypeInfo<__Il2CppFullySharedGenericType, object>.ToStringCollection
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DB60 Offset: 0x125CD60 VA: 0x18125DB60
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.TryParse
	|
	|-RVA: 0x125DC30 Offset: 0x125CE30 VA: 0x18125DC30
	|-HeaderInfo.HeaderTypeInfo<int, object>.TryParse
	|
	|-RVA: 0x125DCB0 Offset: 0x125CEB0 VA: 0x18125DCB0
	|-HeaderInfo.HeaderTypeInfo<long, object>.TryParse
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.TryParse
	|
	|-RVA: 0x125DBE0 Offset: 0x125CDE0 VA: 0x18125DBE0
	|-HeaderInfo.HeaderTypeInfo<object, object>.TryParse
	|
	|-RVA: 0x125DD30 Offset: 0x125CF30 VA: 0x18125DD30
	|-HeaderInfo.HeaderTypeInfo<__Il2CppFullySharedGenericType, object>.TryParse
	*/
}

// Namespace: 
private class HeaderInfo.CollectionHeaderTypeInfo<T, U> : HeaderInfo.HeaderTypeInfo<T, U> // TypeDefIndex: 17026
{
	// Fields
	private readonly int minimalCount; // 0x0
	private readonly string separator; // 0x0
	private readonly TryParseListDelegate<T> parser; // 0x0

	// Properties
	public override string Separator { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF080C0 Offset: 0xF072C0 VA: 0x180F080C0
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>..ctor
	|
	|-RVA: 0xF08120 Offset: 0xF07320 VA: 0x180F08120
	|-HeaderInfo.CollectionHeaderTypeInfo<__Il2CppFullySharedGenericType, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override string get_Separator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.get_Separator
	|-HeaderInfo.CollectionHeaderTypeInfo<__Il2CppFullySharedGenericType, object>.get_Separator
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08050 Offset: 0xF07250 VA: 0x180F08050
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.TryParse
	|
	|-RVA: 0xF07FE0 Offset: 0xF071E0 VA: 0x180F07FE0
	|-HeaderInfo.CollectionHeaderTypeInfo<__Il2CppFullySharedGenericType, object>.TryParse
	*/
}

// Namespace: System.Net.Http.Headers
internal abstract class HeaderInfo // TypeDefIndex: 17027
{
	// Fields
	public bool AllowsMany; // 0x10
	public readonly HttpHeaderKind HeaderKind; // 0x14
	public readonly string Name; // 0x18
	[CompilerGenerated]
	private Func<object, string> <CustomToString>k__BackingField; // 0x20

	// Properties
	public Func<object, string> CustomToString { get; set; }
	public virtual string Separator { get; }

	// Methods

	// RVA: 0x1EACB70 Offset: 0x1EABD70 VA: 0x181EACB70
	protected void .ctor(string name, HttpHeaderKind headerKind) { }

	// RVA: -1 Offset: -1
	public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<object, string> toString) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2C60 Offset: 0x9B1E60 VA: 0x1809B2C60
	|-HeaderInfo.CreateSingle<DateTimeOffset>
	|-HeaderInfo.CreateSingle<int>
	|-HeaderInfo.CreateSingle<long>
	|-HeaderInfo.CreateSingle<object>
	|-HeaderInfo.CreateSingle<TimeSpan>
	|
	|-RVA: 0x9B2D10 Offset: 0x9B1F10 VA: 0x1809B2D10
	|-HeaderInfo.CreateSingle<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1, string separator = ", ") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2BB0 Offset: 0x9B1DB0 VA: 0x1809B2BB0
	|-HeaderInfo.CreateMulti<object>
	*/

	// RVA: 0x1EACB50 Offset: 0x1EABD50 VA: 0x181EACB50
	public object CreateCollection(HttpHeaders headers) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Func<object, string> get_CustomToString() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_CustomToString(Func<object, string> value) { }

	// RVA: 0x1EACBB0 Offset: 0x1EABDB0 VA: 0x181EACBB0 Slot: 4
	public virtual string get_Separator() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddToCollection(object collection, object value);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract List<string> ToStringCollection(object collection);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool TryParse(string value, out object result);
}

// Namespace: System.Net.Http.Headers
public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 17028
{
	// Fields
	private readonly HttpContent content; // 0x20

	// Properties
	public ICollection<string> ContentEncoding { get; }
	public Nullable<long> ContentLength { get; }
	public MediaTypeHeaderValue ContentType { get; set; }

	// Methods

	// RVA: 0x1EAE800 Offset: 0x1EADA00 VA: 0x181EAE800
	internal void .ctor(HttpContent content) { }

	// RVA: 0x1EAE860 Offset: 0x1EADA60 VA: 0x181EAE860
	public ICollection<string> get_ContentEncoding() { }

	// RVA: 0x1EAE8B0 Offset: 0x1EADAB0 VA: 0x181EAE8B0
	public Nullable<long> get_ContentLength() { }

	// RVA: 0x1EAEA70 Offset: 0x1EADC70 VA: 0x181EAEA70
	public MediaTypeHeaderValue get_ContentType() { }

	// RVA: 0x1EAEAC0 Offset: 0x1EADCC0 VA: 0x181EAEAC0
	public void set_ContentType(MediaTypeHeaderValue value) { }
}

// Namespace: System.Net.Http.Headers
[Flags]
internal enum HttpHeaderKind // TypeDefIndex: 17029
{
	// Fields
	public int value__; // 0x0
	public const HttpHeaderKind None = 0;
	public const HttpHeaderKind Request = 1;
	public const HttpHeaderKind Response = 2;
	public const HttpHeaderKind Content = 4;
}

// Namespace: System.Net.Http.Headers
public sealed class HttpHeaderValueCollection<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 17030
{
	// Fields
	private readonly List<T> list; // 0x0
	private readonly HttpHeaders headers; // 0x0
	private readonly HeaderInfo headerInfo; // 0x0
	private List<string> invalidValues; // 0x0

	// Properties
	public int Count { get; }
	internal List<string> InvalidValues { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(HttpHeaders headers, HeaderInfo headerInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260280 Offset: 0x125F480 VA: 0x181260280
	|-HttpHeaderValueCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	|-HttpHeaderValueCollection<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	internal List<string> get_InvalidValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-HttpHeaderValueCollection<object>.get_InvalidValues
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-HttpHeaderValueCollection<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB90CA0 Offset: 0xB8FEA0 VA: 0x180B90CA0
	|-HttpHeaderValueCollection<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal void AddRange(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125FFA0 Offset: 0x125F1A0 VA: 0x18125FFA0
	|-HttpHeaderValueCollection<object>.AddRange
	*/

	// RVA: -1 Offset: -1
	internal void AddInvalidValue(string invalidValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125FEB0 Offset: 0x125F0B0 VA: 0x18125FEB0
	|-HttpHeaderValueCollection<object>.AddInvalidValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125FFD0 Offset: 0x125F1D0 VA: 0x18125FFD0
	|-HttpHeaderValueCollection<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260020 Offset: 0x125F220 VA: 0x181260020
	|-HttpHeaderValueCollection<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260050 Offset: 0x125F250 VA: 0x181260050
	|-HttpHeaderValueCollection<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260120 Offset: 0x125F320 VA: 0x181260120
	|-HttpHeaderValueCollection<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12601D0 Offset: 0x125F3D0 VA: 0x1812601D0
	|-HttpHeaderValueCollection<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12600B0 Offset: 0x125F2B0 VA: 0x1812600B0
	|-HttpHeaderValueCollection<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260150 Offset: 0x125F350 VA: 0x181260150
	|-HttpHeaderValueCollection<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal T Find(Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260080 Offset: 0x125F280 VA: 0x181260080
	|-HttpHeaderValueCollection<object>.Find
	*/
}

// Namespace: 
private class HttpHeaders.HeaderBucket // TypeDefIndex: 17031
{
	// Fields
	public object Parsed; // 0x10
	private List<string> values; // 0x18
	public readonly Func<object, string> CustomToString; // 0x20

	// Properties
	public bool HasStringValues { get; }
	public List<string> Values { get; set; }

	// Methods

	// RVA: 0x1461690 Offset: 0x1460890 VA: 0x181461690
	public void .ctor(object parsed, Func<object, string> converter) { }

	// RVA: 0x1EACA90 Offset: 0x1EABC90 VA: 0x181EACA90
	public bool get_HasStringValues() { }

	// RVA: 0x1EACAE0 Offset: 0x1EABCE0 VA: 0x181EACAE0
	public List<string> get_Values() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Values(List<string> value) { }

	// RVA: 0x1EACA30 Offset: 0x1EABC30 VA: 0x181EACA30
	public string ParsedToString() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpHeaders.<GetEnumerator>d__19 : IEnumerator<KeyValuePair<string, IEnumerable<string>>>, IDisposable, IEnumerator // TypeDefIndex: 17032
{
	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, IEnumerable<string>> <>2__current; // 0x18
	public HttpHeaders <>4__this; // 0x28
	private Dictionary.Enumerator<string, HttpHeaders.HeaderBucket> <>7__wrap1; // 0x30

	// Properties
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1EBFEB0 Offset: 0x1EBF0B0 VA: 0x181EBFEB0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1EBFB40 Offset: 0x1EBED40 VA: 0x181EBFB40 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1EBFF40 Offset: 0x1EBF140 VA: 0x181EBFF40
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820 Slot: 4
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1EBFE20 Offset: 0x1EBF020 VA: 0x181EBFE20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1EBFE60 Offset: 0x1EBF060 VA: 0x181EBFE60 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: System.Net.Http.Headers
public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable // TypeDefIndex: 17033
{
	// Fields
	private static readonly Dictionary<string, HeaderInfo> known_headers; // 0x0
	private readonly Dictionary<string, HttpHeaders.HeaderBucket> headers; // 0x10
	private readonly HttpHeaderKind HeaderKind; // 0x18
	internal Nullable<bool> connectionclose; // 0x1C
	internal Nullable<bool> transferEncodingChunked; // 0x1E

	// Methods

	// RVA: 0x1EB0D40 Offset: 0x1EAFF40 VA: 0x181EB0D40
	private static void .cctor() { }

