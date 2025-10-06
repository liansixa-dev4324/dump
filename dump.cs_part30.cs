	// RVA: 0x246B660 Offset: 0x246A860 VA: 0x18246B660
	public GraphicsBuffer.Target get_indexBufferTarget() { }

	// RVA: 0x246BD40 Offset: 0x246AF40 VA: 0x18246BD40
	public void set_indexBufferTarget(GraphicsBuffer.Target value) { }

	[NativeMethod(Name = "GetBlendShapeChannelCount")]
	// RVA: 0x246B4A0 Offset: 0x246A6A0 VA: 0x18246B4A0
	public int get_blendShapeCount() { }

	[FreeFunction(Name = "MeshScripting::ClearBlendShapes", HasExplicitThis = True)]
	// RVA: 0x2463430 Offset: 0x2462630 VA: 0x182463430
	public void ClearBlendShapes() { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeName", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2464200 Offset: 0x2463400 VA: 0x182464200
	public string GetBlendShapeName(int shapeIndex) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeIndex", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24641B0 Offset: 0x24633B0 VA: 0x1824641B0
	public int GetBlendShapeIndex(string blendShapeName) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameCount", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24640C0 Offset: 0x24632C0 VA: 0x1824640C0
	public int GetBlendShapeFrameCount(int shapeIndex) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameWeight", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2464160 Offset: 0x2463360 VA: 0x182464160
	public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex) { }

	[FreeFunction(Name = "GetBlendShapeFrameVerticesFromScript", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2464100 Offset: 0x2463300 VA: 0x182464100
	public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	[FreeFunction(Name = "AddBlendShapeFrameFromScript", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2462B20 Offset: 0x2461D20 VA: 0x182462B20
	public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeOffset", HasExplicitThis = True)]
	// RVA: 0x2464290 Offset: 0x2463490 VA: 0x182464290
	private BlendShape GetBlendShapeOffsetInternal(int index) { }

	[NativeMethod("HasBoneWeights")]
	// RVA: 0x2466940 Offset: 0x2465B40 VA: 0x182466940
	private bool HasBoneWeights() { }

	[FreeFunction(Name = "MeshScripting::GetBoneWeights", HasExplicitThis = True)]
	// RVA: 0x2464630 Offset: 0x2463830 VA: 0x182464630
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = True)]
	// RVA: 0x2467A70 Offset: 0x2466C70 VA: 0x182467A70
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x2467AC0 Offset: 0x2466CC0 VA: 0x182467AC0
	public void SetBoneWeights(NativeArray<byte> bonesPerVertex, NativeArray<BoneWeight1> weights) { }

	[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = True)]
	// RVA: 0x24669C0 Offset: 0x2465BC0 VA: 0x1824669C0
	private void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize) { }

	// RVA: 0x2463810 Offset: 0x2462A10 VA: 0x182463810
	public NativeArray<BoneWeight1> GetAllBoneWeights() { }

	// RVA: 0x2464840 Offset: 0x2463A40 VA: 0x182464840
	public NativeArray<byte> GetBonesPerVertex() { }

	[FreeFunction(Name = "MeshScripting::GetAllBoneWeightsArraySize", HasExplicitThis = True)]
	// RVA: 0x2463790 Offset: 0x2462990 VA: 0x182463790
	private int GetAllBoneWeightsArraySize() { }

	[NativeMethod("GetBoneWeightBufferDimension")]
	// RVA: 0x2464330 Offset: 0x2463530 VA: 0x182464330
	private int GetBoneWeightBufferLayoutInternal() { }

	[FreeFunction(Name = "MeshScripting::GetAllBoneWeightsArray", HasExplicitThis = True)]
	// RVA: 0x24637D0 Offset: 0x24629D0 VA: 0x1824637D0
	private IntPtr GetAllBoneWeightsArray() { }

	[FreeFunction(Name = "MeshScripting::GetBonesPerVertexArray", HasExplicitThis = True)]
	// RVA: 0x2464800 Offset: 0x2463A00 VA: 0x182464800
	private IntPtr GetBonesPerVertexArray() { }

	// RVA: 0x246B420 Offset: 0x246A620 VA: 0x18246B420
	public int get_bindposeCount() { }

	// RVA: 0x246B460 Offset: 0x246A660 VA: 0x18246B460
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0x246BB80 Offset: 0x246AD80 VA: 0x18246BB80
	public void set_bindposes(Matrix4x4[] value) { }

	// RVA: 0x2463B30 Offset: 0x2462D30 VA: 0x182463B30
	public NativeArray<Matrix4x4> GetBindposes() { }

	[FreeFunction(Name = "MeshScripting::GetBindposesArray", HasExplicitThis = True)]
	// RVA: 0x2463AA0 Offset: 0x2462CA0 VA: 0x182463AA0
	private IntPtr GetBindposesArray() { }

	[FreeFunction(Name = "MeshScripting::ExtractBoneWeightsIntoArray", HasExplicitThis = True)]
	// RVA: 0x2464670 Offset: 0x2463870 VA: 0x182464670
	private void GetBoneWeightsNonAllocImpl([Out] BoneWeight[] values) { }

	[FreeFunction(Name = "MeshScripting::ExtractBindPosesIntoArray", HasExplicitThis = True)]
	// RVA: 0x2463AE0 Offset: 0x2462CE0 VA: 0x182463AE0
	private void GetBindposesNonAllocImpl([Out] Matrix4x4[] values) { }

	[NativeMethod("GetIsReadable")]
	// RVA: 0x246B6E0 Offset: 0x246A8E0 VA: 0x18246B6E0
	public bool get_isReadable() { }

	[NativeMethod("CanAccessFromScript")]
	// RVA: 0x246B590 Offset: 0x246A790 VA: 0x18246B590
	internal bool get_canAccess() { }

	[NativeMethod("GetVertexCount")]
	// RVA: 0x246BB00 Offset: 0x246AD00 VA: 0x18246BB00
	public int get_vertexCount() { }

	[NativeMethod(Name = "GetSubMeshCount")]
	// RVA: 0x246B760 Offset: 0x246A960 VA: 0x18246B760
	public int get_subMeshCount() { }

	[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
	// RVA: 0x246BE20 Offset: 0x246B020 VA: 0x18246BE20
	public void set_subMeshCount(int value) { }

	[FreeFunction("MeshScripting::SetSubMesh", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24695F0 Offset: 0x24687F0 VA: 0x1824695F0
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	[FreeFunction("MeshScripting::GetSubMesh", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2465710 Offset: 0x2464910 VA: 0x182465710
	public SubMeshDescriptor GetSubMesh(int index) { }

	[FreeFunction("MeshScripting::SetAllSubMeshesAtOnceFromArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2467930 Offset: 0x2466B30 VA: 0x182467930
	private void SetAllSubMeshesAtOnceFromArray(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags = 0) { }

	[FreeFunction("MeshScripting::SetAllSubMeshesAtOnceFromNativeArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24679A0 Offset: 0x2466BA0 VA: 0x1824679A0
	private void SetAllSubMeshesAtOnceFromNativeArray(IntPtr desc, int start, int count, MeshUpdateFlags flags = 0) { }

	// RVA: 0x246B530 Offset: 0x246A730 VA: 0x18246B530
	public Bounds get_bounds() { }

	// RVA: 0x246BC20 Offset: 0x246AE20 VA: 0x18246BC20
	public void set_bounds(Bounds value) { }

	[NativeMethod("Clear")]
	// RVA: 0x2463470 Offset: 0x2462670 VA: 0x182463470
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethod("RecalculateBounds")]
	// RVA: 0x24670F0 Offset: 0x24662F0 VA: 0x1824670F0
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	[NativeMethod("RecalculateNormals")]
	// RVA: 0x24672E0 Offset: 0x24664E0 VA: 0x1824672E0
	private void RecalculateNormalsImpl(MeshUpdateFlags flags) { }

	[NativeMethod("RecalculateTangents")]
	// RVA: 0x24674D0 Offset: 0x24666D0 VA: 0x1824674D0
	private void RecalculateTangentsImpl(MeshUpdateFlags flags) { }

	[NativeMethod("MarkDynamic")]
	// RVA: 0x2466C10 Offset: 0x2465E10 VA: 0x182466C10
	private void MarkDynamicImpl() { }

	[NativeMethod("MarkModified")]
	// RVA: 0x2466CC0 Offset: 0x2465EC0 VA: 0x182466CC0
	public void MarkModified() { }

	[NativeMethod("UploadMeshData")]
	// RVA: 0x246B2F0 Offset: 0x246A4F0 VA: 0x18246B2F0
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunction(Name = "MeshScripting::GetPrimitiveType", HasExplicitThis = True)]
	// RVA: 0x2465870 Offset: 0x2464A70 VA: 0x182465870
	private MeshTopology GetTopologyImpl(int submesh) { }

	[NativeMethod("RecalculateMeshMetric")]
	// RVA: 0x24676C0 Offset: 0x24668C0 VA: 0x1824676C0
	private void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold) { }

	[NativeMethod("RecalculateMeshMetrics")]
	// RVA: 0x2467800 Offset: 0x2466A00 VA: 0x182467800
	private void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold) { }

	[NativeMethod("GetMeshMetric")]
	// RVA: 0x2466230 Offset: 0x2465430 VA: 0x182466230
	public float GetUVDistributionMetric(int uvSetIndex) { }

	[NativeMethod(Name = "MeshScripting::CombineMeshes", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
	// RVA: 0x2463500 Offset: 0x2462700 VA: 0x182463500
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[NativeMethod("Optimize")]
	// RVA: 0x2466D00 Offset: 0x2465F00 VA: 0x182466D00
	private void OptimizeImpl() { }

	[NativeMethod("OptimizeIndexBuffers")]
	// RVA: 0x2466D40 Offset: 0x2465F40 VA: 0x182466D40
	private void OptimizeIndexBuffersImpl() { }

	[NativeMethod("OptimizeReorderVertexBuffer")]
	// RVA: 0x2466E50 Offset: 0x2466050 VA: 0x182466E50
	private void OptimizeReorderVertexBufferImpl() { }

	// RVA: 0x24661A0 Offset: 0x24653A0 VA: 0x1824661A0
	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x24636A0 Offset: 0x24628A0 VA: 0x1824636A0
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4E4E0 Offset: 0xA4D6E0 VA: 0x180A4E4E0
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Color32>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	|-Mesh.GetAllocArrayFromChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4E5E0 Offset: 0xA4D7E0 VA: 0x180A4E5E0
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	|
	|-RVA: 0xA4E700 Offset: 0xA4D900 VA: 0x180A4E700
	|-Mesh.GetAllocArrayFromChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2468ED0 Offset: 0x24680D0 VA: 0x182468ED0
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x2469230 Offset: 0x2468430 VA: 0x182469230
	private void SetSizedNativeArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4EDA0 Offset: 0xA4DFA0 VA: 0x180A4EDA0
	|-Mesh.SetArrayForChannel<Color32>
	|-Mesh.SetArrayForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4EE30 Offset: 0xA4E030 VA: 0x180A4EE30
	|-Mesh.SetArrayForChannel<Color>
	|-Mesh.SetArrayForChannel<Vector2>
	|-Mesh.SetArrayForChannel<Vector3>
	|-Mesh.SetArrayForChannel<Vector4>
	|-Mesh.SetArrayForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4FA20 Offset: 0xA4EC20 VA: 0x180A4FA20
	|-Mesh.SetListForChannel<Color32>
	|-Mesh.SetListForChannel<Vector2>
	|-Mesh.SetListForChannel<Vector3>
	|-Mesh.SetListForChannel<Vector4>
	|
	|-RVA: 0xA4FBE0 Offset: 0xA4EDE0 VA: 0x180A4FBE0
	|-Mesh.SetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4FB00 Offset: 0xA4ED00 VA: 0x180A4FB00
	|-Mesh.SetListForChannel<Color>
	|-Mesh.SetListForChannel<Vector3>
	|-Mesh.SetListForChannel<Vector4>
	|
	|-RVA: 0xA4FCB0 Offset: 0xA4EEB0 VA: 0x180A4FCB0
	|-Mesh.SetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4E910 Offset: 0xA4DB10 VA: 0x180A4E910
	|-Mesh.GetListForChannel<Color>
	|-Mesh.GetListForChannel<Vector2>
	|-Mesh.GetListForChannel<Vector3>
	|-Mesh.GetListForChannel<Vector4>
	|
	|-RVA: 0xA4E9A0 Offset: 0xA4DBA0 VA: 0x180A4E9A0
	|-Mesh.GetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4E760 Offset: 0xA4D960 VA: 0x180A4E760
	|-Mesh.GetListForChannel<Color>
	|-Mesh.GetListForChannel<Color32>
	|-Mesh.GetListForChannel<Vector2>
	|-Mesh.GetListForChannel<Vector3>
	|-Mesh.GetListForChannel<Vector4>
	|
	|-RVA: 0xA4EA30 Offset: 0xA4DC30 VA: 0x180A4EA30
	|-Mesh.GetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x246BB40 Offset: 0x246AD40 VA: 0x18246BB40
	public Vector3[] get_vertices() { }

	// RVA: 0x246C2F0 Offset: 0x246B4F0 VA: 0x18246C2F0
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x246B720 Offset: 0x246A920 VA: 0x18246B720
	public Vector3[] get_normals() { }

	// RVA: 0x246BDC0 Offset: 0x246AFC0 VA: 0x18246BDC0
	public void set_normals(Vector3[] value) { }

	// RVA: 0x246B7A0 Offset: 0x246A9A0 VA: 0x18246B7A0
	public Vector4[] get_tangents() { }

	// RVA: 0x246BE60 Offset: 0x246B060 VA: 0x18246BE60
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x246BA40 Offset: 0x246AC40 VA: 0x18246BA40
	public Vector2[] get_uv() { }

	// RVA: 0x246C250 Offset: 0x246B450 VA: 0x18246C250
	public void set_uv(Vector2[] value) { }

	// RVA: 0x246B880 Offset: 0x246AA80 VA: 0x18246B880
	public Vector2[] get_uv2() { }

	// RVA: 0x246BFB0 Offset: 0x246B1B0 VA: 0x18246BFB0
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x246B8C0 Offset: 0x246AAC0 VA: 0x18246B8C0
	public Vector2[] get_uv3() { }

	// RVA: 0x246C010 Offset: 0x246B210 VA: 0x18246C010
	public void set_uv3(Vector2[] value) { }

	// RVA: 0x246B900 Offset: 0x246AB00 VA: 0x18246B900
	public Vector2[] get_uv4() { }

	// RVA: 0x246C070 Offset: 0x246B270 VA: 0x18246C070
	public void set_uv4(Vector2[] value) { }

	// RVA: 0x246B940 Offset: 0x246AB40 VA: 0x18246B940
	public Vector2[] get_uv5() { }

	// RVA: 0x246C0D0 Offset: 0x246B2D0 VA: 0x18246C0D0
	public void set_uv5(Vector2[] value) { }

	// RVA: 0x246B980 Offset: 0x246AB80 VA: 0x18246B980
	public Vector2[] get_uv6() { }

	// RVA: 0x246C130 Offset: 0x246B330 VA: 0x18246C130
	public void set_uv6(Vector2[] value) { }

	// RVA: 0x246B9C0 Offset: 0x246ABC0 VA: 0x18246B9C0
	public Vector2[] get_uv7() { }

	// RVA: 0x246C190 Offset: 0x246B390 VA: 0x18246C190
	public void set_uv7(Vector2[] value) { }

	// RVA: 0x246BA00 Offset: 0x246AC00 VA: 0x18246BA00
	public Vector2[] get_uv8() { }

	// RVA: 0x246C1F0 Offset: 0x246B3F0 VA: 0x18246C1F0
	public void set_uv8(Vector2[] value) { }

	// RVA: 0x246B620 Offset: 0x246A820 VA: 0x18246B620
	public Color[] get_colors() { }

	// RVA: 0x246BCE0 Offset: 0x246AEE0 VA: 0x18246BCE0
	public void set_colors(Color[] value) { }

	// RVA: 0x246B5D0 Offset: 0x246A7D0 VA: 0x18246B5D0
	public Color32[] get_colors32() { }

	// RVA: 0x246BC70 Offset: 0x246AE70 VA: 0x18246BC70
	public void set_colors32(Color32[] value) { }

	// RVA: 0x2466860 Offset: 0x2465A60 VA: 0x182466860
	public void GetVertices(List<Vector3> vertices) { }

	// RVA: 0x246B1E0 Offset: 0x246A3E0 VA: 0x18246B1E0
	public void SetVertices(List<Vector3> inVertices) { }

	[ExcludeFromDocs]
	// RVA: 0x246B070 Offset: 0x246A270 VA: 0x18246B070
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x246AFF0 Offset: 0x246A1F0 VA: 0x18246AFF0
	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x246B0F0 Offset: 0x246A2F0 VA: 0x18246B0F0
	public void SetVertices(Vector3[] inVertices) { }

	[ExcludeFromDocs]
	// RVA: 0x246B280 Offset: 0x246A480 VA: 0x18246B280
	public void SetVertices(Vector3[] inVertices, int start, int length) { }

	// RVA: 0x246B160 Offset: 0x246A360 VA: 0x18246B160
	public void SetVertices(Vector3[] inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	public void SetVertices<T>(NativeArray<T> inVertices) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4EEC0 Offset: 0xA4E0C0 VA: 0x180A4EEC0
	|-Mesh.SetVertices<__Il2CppFullySharedGenericStructType>
	*/

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public void SetVertices<T>(NativeArray<T> inVertices, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4F090 Offset: 0xA4E290 VA: 0x180A4F090
	|-Mesh.SetVertices<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetVertices<T>(NativeArray<T> inVertices, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA510D0 Offset: 0xA502D0 VA: 0x180A510D0
	|-Mesh.SetVertices<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x24655D0 Offset: 0x24647D0 VA: 0x1824655D0
	public void GetNormals(List<Vector3> normals) { }

	// RVA: 0x2468DB0 Offset: 0x2467FB0 VA: 0x182468DB0
	public void SetNormals(List<Vector3> inNormals) { }

	[ExcludeFromDocs]
	// RVA: 0x2468CB0 Offset: 0x2467EB0 VA: 0x182468CB0
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	// RVA: 0x2468BC0 Offset: 0x2467DC0 VA: 0x182468BC0
	public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x2468C40 Offset: 0x2467E40 VA: 0x182468C40
	public void SetNormals(Vector3[] inNormals) { }

	[ExcludeFromDocs]
	// RVA: 0x2468D30 Offset: 0x2467F30 VA: 0x182468D30
	public void SetNormals(Vector3[] inNormals, int start, int length) { }

	// RVA: 0x2468E50 Offset: 0x2468050 VA: 0x182468E50
	public void SetNormals(Vector3[] inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	public void SetNormals<T>(NativeArray<T> inNormals) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4EEC0 Offset: 0xA4E0C0 VA: 0x180A4EEC0
	|-Mesh.SetNormals<__Il2CppFullySharedGenericStructType>
	*/

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public void SetNormals<T>(NativeArray<T> inNormals, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4F090 Offset: 0xA4E290 VA: 0x180A4F090
	|-Mesh.SetNormals<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetNormals<T>(NativeArray<T> inNormals, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4FD80 Offset: 0xA4EF80 VA: 0x180A4FD80
	|-Mesh.SetNormals<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2465780 Offset: 0x2464980 VA: 0x182465780
	public void GetTangents(List<Vector4> tangents) { }

	// RVA: 0x2469B10 Offset: 0x2468D10 VA: 0x182469B10
	public void SetTangents(List<Vector4> inTangents) { }

	[ExcludeFromDocs]
	// RVA: 0x2469D30 Offset: 0x2468F30 VA: 0x182469D30
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	// RVA: 0x2469C30 Offset: 0x2468E30 VA: 0x182469C30
	public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x2469DB0 Offset: 0x2468FB0 VA: 0x182469DB0
	public void SetTangents(Vector4[] inTangents) { }

	[ExcludeFromDocs]
	// RVA: 0x2469BB0 Offset: 0x2468DB0 VA: 0x182469BB0
	public void SetTangents(Vector4[] inTangents, int start, int length) { }

	// RVA: 0x2469CB0 Offset: 0x2468EB0 VA: 0x182469CB0
	public void SetTangents(Vector4[] inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	public void SetTangents<T>(NativeArray<T> inTangents) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4EEC0 Offset: 0xA4E0C0 VA: 0x180A4EEC0
	|-Mesh.SetTangents<__Il2CppFullySharedGenericStructType>
	*/

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public void SetTangents<T>(NativeArray<T> inTangents, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4F090 Offset: 0xA4E290 VA: 0x180A4F090
	|-Mesh.SetTangents<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetTangents<T>(NativeArray<T> inTangents, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA501D0 Offset: 0xA4F3D0 VA: 0x180A501D0
	|-Mesh.SetTangents<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2464940 Offset: 0x2463B40 VA: 0x182464940
	public void GetColors(List<Color> colors) { }

	// RVA: 0x2468160 Offset: 0x2467360 VA: 0x182468160
	public void SetColors(List<Color> inColors) { }

	[ExcludeFromDocs]
	// RVA: 0x2467C40 Offset: 0x2466E40 VA: 0x182467C40
	public void SetColors(List<Color> inColors, int start, int length) { }

	// RVA: 0x2467E60 Offset: 0x2467060 VA: 0x182467E60
	public void SetColors(List<Color> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x2467EE0 Offset: 0x24670E0 VA: 0x182467EE0
	public void SetColors(Color[] inColors) { }

	[ExcludeFromDocs]
	// RVA: 0x2468050 Offset: 0x2467250 VA: 0x182468050
	public void SetColors(Color[] inColors, int start, int length) { }

	// RVA: 0x2467F50 Offset: 0x2467150 VA: 0x182467F50
	public void SetColors(Color[] inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x2464A30 Offset: 0x2463C30 VA: 0x182464A30
	public void GetColors(List<Color32> colors) { }

	// RVA: 0x2467CC0 Offset: 0x2466EC0 VA: 0x182467CC0
	public void SetColors(List<Color32> inColors) { }

	[ExcludeFromDocs]
	// RVA: 0x24680D0 Offset: 0x24672D0 VA: 0x1824680D0
	public void SetColors(List<Color32> inColors, int start, int length) { }

	// RVA: 0x2467BB0 Offset: 0x2466DB0 VA: 0x182467BB0
	public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x2467D70 Offset: 0x2466F70 VA: 0x182467D70
	public void SetColors(Color32[] inColors) { }

	[ExcludeFromDocs]
	// RVA: 0x2467FD0 Offset: 0x24671D0 VA: 0x182467FD0
	public void SetColors(Color32[] inColors, int start, int length) { }

	// RVA: 0x2467DE0 Offset: 0x2466FE0 VA: 0x182467DE0
	public void SetColors(Color32[] inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	public void SetColors<T>(NativeArray<T> inColors) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4EEC0 Offset: 0xA4E0C0 VA: 0x180A4EEC0
	|-Mesh.SetColors<__Il2CppFullySharedGenericStructType>
	*/

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public void SetColors<T>(NativeArray<T> inColors, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4F090 Offset: 0xA4E290 VA: 0x180A4F090
	|-Mesh.SetColors<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetColors<T>(NativeArray<T> inColors, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4EF40 Offset: 0xA4E140 VA: 0x180A4EF40
	|-Mesh.SetColors<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA50760 Offset: 0xA4F960 VA: 0x180A50760
	|-Mesh.SetUvsImpl<Vector2>
	|-Mesh.SetUvsImpl<Vector3>
	|-Mesh.SetUvsImpl<Vector4>
	|
	|-RVA: 0xA50660 Offset: 0xA4F860 VA: 0x180A50660
	|-Mesh.SetUvsImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x246A810 Offset: 0x2469A10 VA: 0x18246A810
	public void SetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x246ACE0 Offset: 0x2469EE0 VA: 0x18246ACE0
	public void SetUVs(int channel, List<Vector3> uvs) { }

	// RVA: 0x246AAD0 Offset: 0x2469CD0 VA: 0x18246AAD0
	public void SetUVs(int channel, List<Vector4> uvs) { }

	[ExcludeFromDocs]
	// RVA: 0x246AA40 Offset: 0x2469C40 VA: 0x18246AA40
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	// RVA: 0x246ABB0 Offset: 0x2469DB0 VA: 0x18246ABB0
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x246A700 Offset: 0x2469900 VA: 0x18246A700
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length) { }

	// RVA: 0x246A670 Offset: 0x2469870 VA: 0x18246A670
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x246A8F0 Offset: 0x2469AF0 VA: 0x18246A8F0
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	// RVA: 0x246A5E0 Offset: 0x24697E0 VA: 0x18246A5E0
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x246AD90 Offset: 0x2469F90 VA: 0x18246AD90
	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags) { }

	// RVA: 0x246A980 Offset: 0x2469B80 VA: 0x18246A980
	public void SetUVs(int channel, Vector2[] uvs) { }

	// RVA: 0x246A9E0 Offset: 0x2469BE0 VA: 0x18246A9E0
	public void SetUVs(int channel, Vector3[] uvs) { }

	// RVA: 0x246AC40 Offset: 0x2469E40 VA: 0x18246AC40
	public void SetUVs(int channel, Vector4[] uvs) { }

	[ExcludeFromDocs]
	// RVA: 0x246A8C0 Offset: 0x2469AC0 VA: 0x18246A8C0
	public void SetUVs(int channel, Vector2[] uvs, int start, int length) { }

	// RVA: 0x246A7D0 Offset: 0x24699D0 VA: 0x18246A7D0
	public void SetUVs(int channel, Vector2[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x246A5B0 Offset: 0x24697B0 VA: 0x18246A5B0
	public void SetUVs(int channel, Vector3[] uvs, int start, int length) { }

	// RVA: 0x246ACA0 Offset: 0x2469EA0 VA: 0x18246ACA0
	public void SetUVs(int channel, Vector3[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x246AB80 Offset: 0x2469D80 VA: 0x18246AB80
	public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }

	// RVA: 0x246A790 Offset: 0x2469990 VA: 0x18246A790
	public void SetUVs(int channel, Vector4[] uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	public void SetUVs<T>(int channel, NativeArray<T> uvs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA50530 Offset: 0xA4F730 VA: 0x180A50530
	|-Mesh.SetUVs<__Il2CppFullySharedGenericStructType>
	*/

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public void SetUVs<T>(int channel, NativeArray<T> uvs, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA505C0 Offset: 0xA4F7C0 VA: 0x180A505C0
	|-Mesh.SetUVs<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetUVs<T>(int channel, NativeArray<T> uvs, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA50300 Offset: 0xA4F500 VA: 0x180A50300
	|-Mesh.SetUVs<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4EC40 Offset: 0xA4DE40 VA: 0x180A4EC40
	|-Mesh.GetUVsImpl<Vector2>
	|-Mesh.GetUVsImpl<Vector3>
	|-Mesh.GetUVsImpl<Vector4>
	|
	|-RVA: 0xA4EB10 Offset: 0xA4DD10 VA: 0x180A4EB10
	|-Mesh.GetUVsImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2466350 Offset: 0x2465550 VA: 0x182466350
	public void GetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x24662E0 Offset: 0x24654E0 VA: 0x1824662E0
	public void GetUVs(int channel, List<Vector3> uvs) { }

	// RVA: 0x2466270 Offset: 0x2465470 VA: 0x182466270
	public void GetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x24663C0 Offset: 0x24655C0 VA: 0x1824663C0
	public int get_vertexAttributeCount() { }

	// RVA: 0x2466690 Offset: 0x2465890 VA: 0x182466690
	public VertexAttributeDescriptor[] GetVertexAttributes() { }

	// RVA: 0x24665F0 Offset: 0x24657F0 VA: 0x1824665F0
	public int GetVertexAttributes(VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x2466640 Offset: 0x2465840 VA: 0x182466640
	public int GetVertexAttributes(List<VertexAttributeDescriptor> attributes) { }

	// RVA: 0x246AEA0 Offset: 0x246A0A0 VA: 0x18246AEA0
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x246AF50 Offset: 0x246A150 VA: 0x18246AF50
	public void SetVertexBufferParams(int vertexCount, NativeArray<VertexAttributeDescriptor> attributes) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA50E70 Offset: 0xA50070 VA: 0x180A50E70
	|-Mesh.SetVertexBufferData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA50BD0 Offset: 0xA4FDD0 VA: 0x180A50BD0
	|-Mesh.SetVertexBufferData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA508A0 Offset: 0xA4FAA0 VA: 0x180A508A0
	|-Mesh.SetVertexBufferData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2462940 Offset: 0x2461B40 VA: 0x182462940
	public static Mesh.MeshDataArray AcquireReadOnlyMeshData(Mesh mesh) { }

	// RVA: 0x2462980 Offset: 0x2461B80 VA: 0x182462980
	public static Mesh.MeshDataArray AcquireReadOnlyMeshData(Mesh[] meshes) { }

	// RVA: 0x2462A30 Offset: 0x2461C30 VA: 0x182462A30
	public static Mesh.MeshDataArray AcquireReadOnlyMeshData(List<Mesh> meshes) { }

	// RVA: 0x2462B90 Offset: 0x2461D90 VA: 0x182462B90
	public static Mesh.MeshDataArray AllocateWritableMeshData(int meshCount) { }

	// RVA: 0x2462EF0 Offset: 0x24620F0 VA: 0x182462EF0
	public static void ApplyAndDisposeWritableMeshData(Mesh.MeshDataArray data, Mesh mesh, MeshUpdateFlags flags = 0) { }

	// RVA: 0x2462D90 Offset: 0x2461F90 VA: 0x182462D90
	public static void ApplyAndDisposeWritableMeshData(Mesh.MeshDataArray data, Mesh[] meshes, MeshUpdateFlags flags = 0) { }

	// RVA: 0x2462BD0 Offset: 0x2461DD0 VA: 0x182462BD0
	public static void ApplyAndDisposeWritableMeshData(Mesh.MeshDataArray data, List<Mesh> meshes, MeshUpdateFlags flags = 0) { }

	// RVA: 0x24667A0 Offset: 0x24659A0 VA: 0x1824667A0
	public GraphicsBuffer GetVertexBuffer(int index) { }

	// RVA: 0x2464B60 Offset: 0x2463D60 VA: 0x182464B60
	public GraphicsBuffer GetIndexBuffer() { }

	// RVA: 0x2464370 Offset: 0x2463570 VA: 0x182464370
	public GraphicsBuffer GetBoneWeightBuffer(SkinWeights layout) { }

	// RVA: 0x2463EB0 Offset: 0x24630B0 VA: 0x182463EB0
	public GraphicsBuffer GetBlendShapeBuffer(BlendShapeBufferLayout layout) { }

	// RVA: 0x2463FC0 Offset: 0x24631C0 VA: 0x182463FC0
	public GraphicsBuffer GetBlendShapeBuffer() { }

	// RVA: 0x2463D60 Offset: 0x2462F60 VA: 0x182463D60
	public BlendShapeBufferRange GetBlendShapeBufferRange(int blendShapeIndex) { }

	// RVA: 0x2467070 Offset: 0x2466270 VA: 0x182467070
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x2463080 Offset: 0x2462280 VA: 0x182463080
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x2463070 Offset: 0x2462270 VA: 0x182463070
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x2463060 Offset: 0x2462260 VA: 0x182463060
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x246B7E0 Offset: 0x246A9E0 VA: 0x18246B7E0
	public int[] get_triangles() { }

	// RVA: 0x246BEC0 Offset: 0x246B0C0 VA: 0x18246BEC0
	public void set_triangles(int[] value) { }

	// RVA: 0x2465D00 Offset: 0x2464F00 VA: 0x182465D00
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x2466100 Offset: 0x2465300 VA: 0x182466100
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	// RVA: 0x2465F50 Offset: 0x2465150 VA: 0x182465F50
	public void GetTriangles(List<int> triangles, int submesh) { }

	// RVA: 0x2465D90 Offset: 0x2464F90 VA: 0x182465D90
	public void GetTriangles(List<int> triangles, int submesh, bool applyBaseVertex) { }

	// RVA: 0x2465B40 Offset: 0x2464D40 VA: 0x182465B40
	public void GetTriangles(List<ushort> triangles, int submesh, bool applyBaseVertex = True) { }

	[ExcludeFromDocs]
	// RVA: 0x2464F50 Offset: 0x2464150 VA: 0x182464F50
	public int[] GetIndices(int submesh) { }

	// RVA: 0x24654B0 Offset: 0x24646B0 VA: 0x1824654B0
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocs]
	// RVA: 0x2464FE0 Offset: 0x24641E0 VA: 0x182464FE0
	public void GetIndices(List<int> indices, int submesh) { }

	// RVA: 0x2465170 Offset: 0x2464370 VA: 0x182465170
	public void GetIndices(List<int> indices, int submesh, bool applyBaseVertex) { }

	// RVA: 0x2465310 Offset: 0x2464510 VA: 0x182465310
	public void GetIndices(List<ushort> indices, int submesh, bool applyBaseVertex = True) { }

	// RVA: -1 Offset: -1
	public void SetIndexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4F330 Offset: 0xA4E530 VA: 0x180A4F330
	|-Mesh.SetIndexBufferData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4F120 Offset: 0xA4E320 VA: 0x180A4F120
	|-Mesh.SetIndexBufferData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetIndexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4F520 Offset: 0xA4E720 VA: 0x180A4F520
	|-Mesh.SetIndexBufferData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2464D50 Offset: 0x2463F50 VA: 0x182464D50
	public uint GetIndexStart(int submesh) { }

	// RVA: 0x2464C50 Offset: 0x2463E50 VA: 0x182464C50
	public uint GetIndexCount(int submesh) { }

	// RVA: 0x24639E0 Offset: 0x2462BE0 VA: 0x1824639E0
	public uint GetBaseVertex(int submesh) { }

	// RVA: 0x24631C0 Offset: 0x24623C0 VA: 0x1824631C0
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x2469E20 Offset: 0x2469020 VA: 0x182469E20
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	// RVA: 0x246A410 Offset: 0x2469610 VA: 0x18246A410
	public void SetTriangles(int[] triangles, int submesh) { }

	[ExcludeFromDocs]
	// RVA: 0x246A060 Offset: 0x2469260 VA: 0x18246A060
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds) { }

	// RVA: 0x246A240 Offset: 0x2469440 VA: 0x18246A240
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x246A510 Offset: 0x2469710 VA: 0x18246A510
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x246A080 Offset: 0x2469280 VA: 0x18246A080
	public void SetTriangles(ushort[] triangles, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x2469FC0 Offset: 0x24691C0 VA: 0x182469FC0
	public void SetTriangles(ushort[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocs]
	// RVA: 0x246A3F0 Offset: 0x24695F0 VA: 0x18246A3F0
	public void SetTriangles(List<int> triangles, int submesh) { }

	[ExcludeFromDocs]
	// RVA: 0x246A130 Offset: 0x2469330 VA: 0x18246A130
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds) { }

	// RVA: 0x246A2F0 Offset: 0x24694F0 VA: 0x18246A2F0
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x2469EE0 Offset: 0x24690E0 VA: 0x182469EE0
	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x246A150 Offset: 0x2469350 VA: 0x18246A150
	public void SetTriangles(List<ushort> triangles, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x246A430 Offset: 0x2469630 VA: 0x18246A430
	public void SetTriangles(List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocs]
	// RVA: 0x24684E0 Offset: 0x24676E0 VA: 0x1824684E0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocs]
	// RVA: 0x2468B30 Offset: 0x2467D30 VA: 0x182468B30
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x2468980 Offset: 0x2467B80 VA: 0x182468980
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x2468410 Offset: 0x2467610 VA: 0x182468410
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x2468330 Offset: 0x2467530 VA: 0x182468330
	public void SetIndices(ushort[] indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x2468A60 Offset: 0x2467C60 VA: 0x182468A60
	public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: -1 Offset: -1
	public void SetIndices<T>(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4F7D0 Offset: 0xA4E9D0 VA: 0x180A4F7D0
	|-Mesh.SetIndices<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetIndices<T>(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4F890 Offset: 0xA4EA90 VA: 0x180A4F890
	|-Mesh.SetIndices<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2468500 Offset: 0x2467700 VA: 0x182468500
	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x2468760 Offset: 0x2467960 VA: 0x182468760
	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x2468630 Offset: 0x2467830 VA: 0x182468630
	public void SetIndices(List<ushort> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x2468870 Offset: 0x2467A70 VA: 0x182468870
	public void SetIndices(List<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x24697B0 Offset: 0x24689B0 VA: 0x1824697B0
	public void SetSubMeshes(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags = 0) { }

	// RVA: 0x24696D0 Offset: 0x24688D0 VA: 0x1824696D0
	public void SetSubMeshes(SubMeshDescriptor[] desc, MeshUpdateFlags flags = 0) { }

	// RVA: 0x2469650 Offset: 0x2468850 VA: 0x182469650
	public void SetSubMeshes(List<SubMeshDescriptor> desc, int start, int count, MeshUpdateFlags flags = 0) { }

	// RVA: 0x2469710 Offset: 0x2468910 VA: 0x182469710
	public void SetSubMeshes(List<SubMeshDescriptor> desc, MeshUpdateFlags flags = 0) { }

	// RVA: -1 Offset: -1
	public void SetSubMeshes<T>(NativeArray<T> desc, int start, int count, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4FF40 Offset: 0xA4F140 VA: 0x180A4FF40
	|-Mesh.SetSubMeshes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetSubMeshes<T>(NativeArray<T> desc, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4FEB0 Offset: 0xA4F0B0 VA: 0x180A4FEB0
	|-Mesh.SetSubMeshes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2463C00 Offset: 0x2462E00 VA: 0x182463C00
	public void GetBindposes(List<Matrix4x4> bindposes) { }

	// RVA: 0x24646C0 Offset: 0x24638C0 VA: 0x1824646C0
	public void GetBoneWeights(List<BoneWeight> boneWeights) { }

	// RVA: 0x2464630 Offset: 0x2463830 VA: 0x182464630
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x2467A70 Offset: 0x2466C70 VA: 0x182467A70
	public void set_boneWeights(BoneWeight[] value) { }

	// RVA: 0x2464330 Offset: 0x2463530 VA: 0x182464330
	public SkinWeights get_skinWeightBufferLayout() { }

	// RVA: 0x2463470 Offset: 0x2462670 VA: 0x182463470
	public void Clear(bool keepVertexLayout) { }

	[ExcludeFromDocs]
	// RVA: 0x24634C0 Offset: 0x24626C0 VA: 0x1824634C0
	public void Clear() { }

	[ExcludeFromDocs]
	// RVA: 0x2467130 Offset: 0x2466330 VA: 0x182467130
	public void RecalculateBounds() { }

	[ExcludeFromDocs]
	// RVA: 0x2467320 Offset: 0x2466520 VA: 0x182467320
	public void RecalculateNormals() { }

	[ExcludeFromDocs]
	// RVA: 0x2467510 Offset: 0x2466710 VA: 0x182467510
	public void RecalculateTangents() { }

	// RVA: 0x2467200 Offset: 0x2466400 VA: 0x182467200
	public void RecalculateBounds(MeshUpdateFlags flags) { }

	// RVA: 0x24673F0 Offset: 0x24665F0 VA: 0x1824673F0
	public void RecalculateNormals(MeshUpdateFlags flags) { }

	// RVA: 0x24675E0 Offset: 0x24667E0 VA: 0x1824675E0
	public void RecalculateTangents(MeshUpdateFlags flags) { }

	// RVA: 0x2467710 Offset: 0x2466910 VA: 0x182467710
	public void RecalculateUVDistributionMetric(int uvSetIndex, float uvAreaThreshold = 1E-09) { }

	// RVA: 0x2467850 Offset: 0x2466A50 VA: 0x182467850
	public void RecalculateUVDistributionMetrics(float uvAreaThreshold = 1E-09) { }

	// RVA: 0x2466C50 Offset: 0x2465E50 VA: 0x182466C50
	public void MarkDynamic() { }

	// RVA: 0x246B340 Offset: 0x246A540 VA: 0x18246B340
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x2466F60 Offset: 0x2466160 VA: 0x182466F60
	public void Optimize() { }

	// RVA: 0x2466D80 Offset: 0x2465F80 VA: 0x182466D80
	public void OptimizeIndexBuffers() { }

	// RVA: 0x2466E90 Offset: 0x2466090 VA: 0x182466E90
	public void OptimizeReorderVertexBuffer() { }

	// RVA: 0x24658B0 Offset: 0x2464AB0 VA: 0x1824658B0
	public MeshTopology GetTopology(int submesh) { }

	// RVA: 0x2463500 Offset: 0x2462700 VA: 0x182463500
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[ExcludeFromDocs]
	// RVA: 0x24635D0 Offset: 0x24627D0 VA: 0x1824635D0
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { }

	[ExcludeFromDocs]
	// RVA: 0x2463640 Offset: 0x2462840 VA: 0x182463640
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes) { }

	[ExcludeFromDocs]
	// RVA: 0x2463580 Offset: 0x2462780 VA: 0x182463580
	public void CombineMeshes(CombineInstance[] combine) { }

	// RVA: 0x2466500 Offset: 0x2465700 VA: 0x182466500
	private void GetVertexAttribute_Injected(int index, out VertexAttributeDescriptor ret) { }

	// RVA: 0x2464240 Offset: 0x2463440 VA: 0x182464240
	private void GetBlendShapeOffsetInternal_Injected(int index, out BlendShape ret) { }

	// RVA: 0x2469590 Offset: 0x2468790 VA: 0x182469590
	private void SetSubMesh_Injected(int index, ref SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	// RVA: 0x24656C0 Offset: 0x24648C0 VA: 0x1824656C0
	private void GetSubMesh_Injected(int index, out SubMeshDescriptor ret) { }

	// RVA: 0x246B4E0 Offset: 0x246A6E0 VA: 0x18246B4E0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x246BBD0 Offset: 0x246ADD0 VA: 0x18246BBD0
	private void set_bounds_Injected(ref Bounds value) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[Serializable]
internal struct BlendShape // TypeDefIndex: 14056
{
	// Fields
	[SerializeField]
	private uint m_FirstVertex; // 0x0
	[SerializeField]
	private uint m_VertexCount; // 0x4
	[SerializeField]
	private bool m_HasNormals; // 0x8
	[SerializeField]
	private bool m_HasTangents; // 0x9

	// Properties
	public uint firstVertex { get; }
	public uint vertexCount { get; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public uint get_firstVertex() { }

	// RVA: 0xC45280 Offset: 0xC44480 VA: 0x180C45280
	public uint get_vertexCount() { }
}

// Namespace: UnityEngine
[Serializable]
public struct BlendShapeBufferRange // TypeDefIndex: 14057
{
	// Fields
	[SerializeField]
	private uint m_StartIndex; // 0x0
	[SerializeField]
	private uint m_EndIndex; // 0x4

	// Properties
	internal uint startIndex { set; }
	internal uint endIndex { set; }

	// Methods

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	internal void set_startIndex(uint value) { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	internal void set_endIndex(uint value) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[Serializable]
public struct BoneWeight : IEquatable<BoneWeight> // TypeDefIndex: 14058
{
	// Fields
	[SerializeField]
	private float m_Weight0; // 0x0
	[SerializeField]
	private float m_Weight1; // 0x4
	[SerializeField]
	private float m_Weight2; // 0x8
	[SerializeField]
	private float m_Weight3; // 0xC
	[SerializeField]
	private int m_BoneIndex0; // 0x10
	[SerializeField]
	private int m_BoneIndex1; // 0x14
	[SerializeField]
	private int m_BoneIndex2; // 0x18
	[SerializeField]
	private int m_BoneIndex3; // 0x1C

	// Properties
	public float weight0 { get; }
	public float weight1 { get; }
	public float weight2 { get; }
	public float weight3 { get; }
	public int boneIndex0 { get; }
	public int boneIndex1 { get; }
	public int boneIndex2 { get; }
	public int boneIndex3 { get; }

	// Methods

	// RVA: 0x758EB0 Offset: 0x7580B0 VA: 0x180758EB0
	public float get_weight0() { }

	// RVA: 0x758EC0 Offset: 0x7580C0 VA: 0x180758EC0
	public float get_weight1() { }

	// RVA: 0x576F00 Offset: 0x576100 VA: 0x180576F00
	public float get_weight2() { }

	// RVA: 0x576EF0 Offset: 0x5760F0 VA: 0x180576EF0
	public float get_weight3() { }

	// RVA: 0x24765D0 Offset: 0x24757D0 VA: 0x1824765D0
	public int get_boneIndex0() { }

	// RVA: 0x10EBDC0 Offset: 0x10EAFC0 VA: 0x1810EBDC0
	public int get_boneIndex1() { }

	// RVA: 0xB78A40 Offset: 0xB77C40 VA: 0x180B78A40
	public int get_boneIndex2() { }

	// RVA: 0x1208670 Offset: 0x1207870 VA: 0x181208670
	public int get_boneIndex3() { }

	// RVA: 0x24764C0 Offset: 0x24756C0 VA: 0x1824764C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2476420 Offset: 0x2475620 VA: 0x182476420 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2476350 Offset: 0x2475550 VA: 0x182476350 Slot: 4
	public bool Equals(BoneWeight other) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[Serializable]
public struct BoneWeight1 : IEquatable<BoneWeight1> // TypeDefIndex: 14059
{
	// Fields
	[SerializeField]
	private float m_Weight; // 0x0
	[SerializeField]
	private int m_BoneIndex; // 0x4

	// Properties
	public float weight { get; }
	public int boneIndex { get; }

	// Methods

	// RVA: 0x758EB0 Offset: 0x7580B0 VA: 0x180758EB0
	public float get_weight() { }

	// RVA: 0xC45280 Offset: 0xC44480 VA: 0x180C45280
	public int get_boneIndex() { }

	// RVA: 0x2476240 Offset: 0x2475440 VA: 0x182476240 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x24761E0 Offset: 0x24753E0 VA: 0x1824761E0 Slot: 4
	public bool Equals(BoneWeight1 other) { }

	// RVA: 0x2476300 Offset: 0x2475500 VA: 0x182476300 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine
public struct CombineInstance // TypeDefIndex: 14060
{
	// Fields
	private int m_MeshInstanceID; // 0x0
	private int m_SubMeshIndex; // 0x4
	private Matrix4x4 m_Transform; // 0x8
	private Vector4 m_LightmapScaleOffset; // 0x48
	private Vector4 m_RealtimeLightmapScaleOffset; // 0x58
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/Texture.h")]
[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
public class Texture : Object // TypeDefIndex: 14061
{
	// Fields
	public static readonly int GenerateAllMips; // 0x0

	// Properties
	public int mipmapCount { get; }
	public virtual int width { get; set; }
	public virtual int height { get; set; }
	public virtual bool isReadable { get; }
	public TextureWrapMode wrapMode { get; set; }
	public TextureWrapMode wrapModeU { set; }
	public TextureWrapMode wrapModeV { set; }
	public FilterMode filterMode { get; set; }
	public Vector2 texelSize { get; }
	internal ColorSpace activeTextureColorSpace { get; }

	// Methods

	// RVA: 0x24883D0 Offset: 0x24875D0 VA: 0x1824883D0
	protected void .ctor() { }

	[NativeName("GetMipmapCount")]
	// RVA: 0x24884E0 Offset: 0x24876E0 VA: 0x1824884E0
	public int get_mipmapCount() { }

	// RVA: 0x2487EB0 Offset: 0x24870B0 VA: 0x182487EB0
	private int GetDataWidth() { }

	// RVA: 0x2487E70 Offset: 0x2487070 VA: 0x182487E70
	private int GetDataHeight() { }

	// RVA: 0x2487EB0 Offset: 0x24870B0 VA: 0x182487EB0 Slot: 4
	public virtual int get_width() { }

	// RVA: 0x2488680 Offset: 0x2487880 VA: 0x182488680 Slot: 5
	public virtual void set_width(int value) { }

	// RVA: 0x2487E70 Offset: 0x2487070 VA: 0x182487E70 Slot: 6
	public virtual int get_height() { }

	// RVA: 0x2488640 Offset: 0x2487840 VA: 0x182488640 Slot: 7
	public virtual void set_height(int value) { }

	// RVA: 0x24884A0 Offset: 0x24876A0 VA: 0x1824884A0 Slot: 8
	public virtual bool get_isReadable() { }

	[NativeName("GetWrapModeU")]
	// RVA: 0x24885C0 Offset: 0x24877C0 VA: 0x1824885C0
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x2488740 Offset: 0x2487940 VA: 0x182488740
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x24886C0 Offset: 0x24878C0 VA: 0x1824886C0
	public void set_wrapModeU(TextureWrapMode value) { }

	// RVA: 0x2488700 Offset: 0x2487900 VA: 0x182488700
	public void set_wrapModeV(TextureWrapMode value) { }

	// RVA: 0x2488460 Offset: 0x2487660 VA: 0x182488460
	public FilterMode get_filterMode() { }

	// RVA: 0x2488600 Offset: 0x2487800 VA: 0x182488600
	public void set_filterMode(FilterMode value) { }

	[NativeName("GetTexelSize")]
	// RVA: 0x2488570 Offset: 0x2487770 VA: 0x182488570
	public Vector2 get_texelSize() { }

	[NativeMethod("GetActiveTextureColorSpace")]
	// RVA: 0x2487FF0 Offset: 0x24871F0 VA: 0x182487FF0
	private int Internal_GetActiveTextureColorSpace() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
	// RVA: 0x2488420 Offset: 0x2487620 VA: 0x182488420
	internal ColorSpace get_activeTextureColorSpace() { }

	// RVA: 0x2487F40 Offset: 0x2487140 VA: 0x182487F40
	internal ulong GetPixelDataSize(int mipLevel, int element = 0) { }

	// RVA: 0x2487EF0 Offset: 0x24870F0 VA: 0x182487EF0
	internal ulong GetPixelDataOffset(int mipLevel, int element = 0) { }

	// RVA: 0x2487FE0 Offset: 0x24871E0 VA: 0x182487FE0
	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	// RVA: 0x2487F90 Offset: 0x2487190 VA: 0x182487F90
	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	// RVA: 0x24881F0 Offset: 0x24873F0 VA: 0x1824881F0
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x2488030 Offset: 0x2487230 VA: 0x182488030
	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x2487DE0 Offset: 0x2486FE0 VA: 0x182487DE0
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x2487D80 Offset: 0x2486F80 VA: 0x182487D80
	internal UnityException CreateNativeArrayLengthOverflowException() { }

	// RVA: 0x2488390 Offset: 0x2487590 VA: 0x182488390
	private static void .cctor() { }

	// RVA: 0x2488520 Offset: 0x2487720 VA: 0x182488520
	private void get_texelSize_Injected(out Vector2 ret) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
[NativeHeader("Runtime/Graphics/Texture2D.h")]
[HelpURL("texture-type-default")]
public sealed class Texture2D : Texture // TypeDefIndex: 14062
{
	// Fields
	internal const int streamingMipmapsPriorityMin = -128;
	internal const int streamingMipmapsPriorityMax = 127;

	// Properties
	public TextureFormat format { get; }
	public bool ignoreMipmapLimit { get; set; }
	public string mipmapLimitGroup { get; }
	public int activeMipmapLimit { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D whiteTexture { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D blackTexture { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D redTexture { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D grayTexture { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D linearGrayTexture { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D normalTexture { get; }
	public override bool isReadable { get; }
	[NativeConditional("ENABLE_VIRTUALTEXTURING && UNITY_EDITOR")]
	[NativeName("VTOnly")]
	public bool vtOnly { get; }
	internal bool isPreProcessed { get; }
	public bool streamingMipmaps { get; }
	public int streamingMipmapsPriority { get; }
	public int requestedMipmapLevel { get; set; }
	public int minimumMipmapLevel { get; set; }
	internal bool loadAllMips { get; set; }
	public int calculatedMipmapLevel { get; }
	public int desiredMipmapLevel { get; }
	public int loadingMipmapLevel { get; }
	public int loadedMipmapLevel { get; }

	// Methods

	[NativeName("GetTextureFormat")]
	// RVA: 0x2486DF0 Offset: 0x2485FF0 VA: 0x182486DF0
	public TextureFormat get_format() { }

	[NativeName("IgnoreMipmapLimit")]
	// RVA: 0x2486E60 Offset: 0x2486060 VA: 0x182486E60
	public bool get_ignoreMipmapLimit() { }

	[NativeName("SetIgnoreMipmapLimitAndReload")]
	// RVA: 0x2487220 Offset: 0x2486420 VA: 0x182487220
	public void set_ignoreMipmapLimit(bool value) { }

	[NativeName("GetMipmapLimitGroupName")]
	// RVA: 0x2487050 Offset: 0x2486250 VA: 0x182487050
	public string get_mipmapLimitGroup() { }

	[NativeName("GetMipmapLimit")]
	// RVA: 0x2486D00 Offset: 0x2485F00 VA: 0x182486D00
	public int get_activeMipmapLimit() { }

	// RVA: 0x24871F0 Offset: 0x24863F0 VA: 0x1824871F0
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x2486D40 Offset: 0x2485F40 VA: 0x182486D40
	public static Texture2D get_blackTexture() { }

	// RVA: 0x24870C0 Offset: 0x24862C0 VA: 0x1824870C0
	public static Texture2D get_redTexture() { }

	// RVA: 0x2486E30 Offset: 0x2486030 VA: 0x182486E30
	public static Texture2D get_grayTexture() { }

	// RVA: 0x2486F20 Offset: 0x2486120 VA: 0x182486F20
	public static Texture2D get_linearGrayTexture() { }

	// RVA: 0x2487090 Offset: 0x2486290 VA: 0x182487090
	public static Texture2D get_normalTexture() { }

	// RVA: 0x2483F00 Offset: 0x2483100 VA: 0x182483F00
	public void Compress(bool highQuality) { }

	[FreeFunction("Texture2DScripting::Create")]
	// RVA: 0x2484B80 Offset: 0x2483D80 VA: 0x182484B80
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x2484BE0 Offset: 0x2483DE0 VA: 0x182484BE0
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x2486EE0 Offset: 0x24860E0 VA: 0x182486EE0 Slot: 8
	public override bool get_isReadable() { }

	// RVA: 0x24871B0 Offset: 0x24863B0 VA: 0x1824871B0
	public bool get_vtOnly() { }

	[NativeName("Apply")]
	// RVA: 0x2483D60 Offset: 0x2482F60 VA: 0x182483D60
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeName("Reinitialize")]
	// RVA: 0x24853E0 Offset: 0x24845E0 VA: 0x1824853E0
	private bool ReinitializeImpl(int width, int height) { }

	[NativeName("SetPixel")]
	// RVA: 0x2485930 Offset: 0x2484B30 VA: 0x182485930
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	[NativeName("GetPixel")]
	// RVA: 0x24845F0 Offset: 0x24837F0 VA: 0x1824845F0
	private Color GetPixelImpl(int image, int mip, int x, int y) { }

	[NativeName("GetPixelBilinear")]
	// RVA: 0x2484360 Offset: 0x2483560 VA: 0x182484360
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithFormat", HasExplicitThis = True)]
	// RVA: 0x2485430 Offset: 0x2484630 VA: 0x182485430
	private bool ReinitializeWithFormatImpl(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = True)]
	// RVA: 0x24854A0 Offset: 0x24846A0 VA: 0x1824854A0
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = True)]
	// RVA: 0x24851F0 Offset: 0x24843F0 VA: 0x1824851F0
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2485BF0 Offset: 0x2484DF0 VA: 0x182485BF0
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	// RVA: 0x2484D60 Offset: 0x2483F60 VA: 0x182484D60
	private bool LoadRawTextureDataImpl(IntPtr data, ulong size) { }

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	// RVA: 0x2484D10 Offset: 0x2483F10 VA: 0x182484D10
	private bool LoadRawTextureDataImplArray(byte[] data) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixelDataArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24857F0 Offset: 0x24849F0 VA: 0x1824857F0
	private bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixelData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2485860 Offset: 0x2484A60 VA: 0x182485860
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	// RVA: 0x2484B40 Offset: 0x2483D40 VA: 0x182484B40
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x2484AC0 Offset: 0x2483CC0 VA: 0x182484AC0
	private ulong GetRawImageDataSize() { }

	[FreeFunction("Texture2DScripting::GenerateAtlas")]
	// RVA: 0x2484070 Offset: 0x2483270 VA: 0x182484070
	private static void GenerateAtlasImpl(Vector2[] sizes, int padding, int atlasSize, [Out] Rect[] rect) { }

	// RVA: 0x2486EA0 Offset: 0x24860A0 VA: 0x182486EA0
	internal bool get_isPreProcessed() { }

	// RVA: 0x2487170 Offset: 0x2486370 VA: 0x182487170
	public bool get_streamingMipmaps() { }

	// RVA: 0x2487130 Offset: 0x2486330 VA: 0x182487130
	public int get_streamingMipmapsPriority() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = True)]
	// RVA: 0x24870F0 Offset: 0x24862F0 VA: 0x1824870F0
	public int get_requestedMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
	// RVA: 0x2487300 Offset: 0x2486500 VA: 0x182487300
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetMinimumMipmapLevel", HasExplicitThis = True)]
	// RVA: 0x2487010 Offset: 0x2486210 VA: 0x182487010
	public int get_minimumMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetMinimumMipmapLevel", HasExplicitThis = True)]
	// RVA: 0x24872C0 Offset: 0x24864C0 VA: 0x1824872C0
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = True)]
	// RVA: 0x2486F50 Offset: 0x2486150 VA: 0x182486F50
	internal bool get_loadAllMips() { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = True)]
	// RVA: 0x2487270 Offset: 0x2486470 VA: 0x182487270
	internal void set_loadAllMips(bool value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetCalculatedMipmapLevel", HasExplicitThis = True)]
	// RVA: 0x2486D70 Offset: 0x2485F70 VA: 0x182486D70
	public int get_calculatedMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = True)]
	// RVA: 0x2486DB0 Offset: 0x2485FB0 VA: 0x182486DB0
	public int get_desiredMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = True)]
	// RVA: 0x2486FD0 Offset: 0x24861D0 VA: 0x182486FD0
	public int get_loadingMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = True)]
	// RVA: 0x2486F90 Offset: 0x2486190 VA: 0x182486F90
	public int get_loadedMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = True)]
	// RVA: 0x2483EC0 Offset: 0x24830C0 VA: 0x182483EC0
	public void ClearRequestedMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = True)]
	// RVA: 0x2484CD0 Offset: 0x2483ED0 VA: 0x182484CD0
	public bool IsRequestedMipmapLevelLoaded() { }

	[FreeFunction(Name = "GetTextureStreamingManager().ClearMinimumMipmapLevel", HasExplicitThis = True)]
	// RVA: 0x2483E80 Offset: 0x2483080 VA: 0x182483E80
	public void ClearMinimumMipmapLevel() { }

	[FreeFunction("Texture2DScripting::UpdateExternalTexture", HasExplicitThis = True)]
	// RVA: 0x2485E60 Offset: 0x2485060 VA: 0x182485E60
	public void UpdateExternalTexture(IntPtr nativeTex) { }

	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2485730 Offset: 0x2484930 VA: 0x182485730
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunction("Texture2DScripting::SetBlockOfPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2485790 Offset: 0x2484990 VA: 0x182485790
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunction("Texture2DScripting::GetRawTextureData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2484B00 Offset: 0x2483D00 VA: 0x182484B00
	public byte[] GetRawTextureData() { }

	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2484A60 Offset: 0x2483C60 VA: 0x182484A60
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2484890 Offset: 0x2483A90 VA: 0x182484890
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { }

	[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2484810 Offset: 0x2483A10 VA: 0x182484810
	public Color32[] GetPixels32(int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2484850 Offset: 0x2483A50 VA: 0x182484850
	public Color32[] GetPixels32() { }

	[FreeFunction("Texture2DScripting::PackTextures", HasExplicitThis = True)]
	// RVA: 0x2485110 Offset: 0x2484310 VA: 0x182485110
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	// RVA: 0x2485040 Offset: 0x2484240 VA: 0x182485040
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize) { }

	// RVA: 0x24850B0 Offset: 0x24842B0 VA: 0x1824850B0
	public Rect[] PackTextures(Texture2D[] textures, int padding) { }

	// RVA: 0x2486010 Offset: 0x2485210 VA: 0x182486010
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x2485EB0 Offset: 0x24850B0 VA: 0x182485EB0
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	// RVA: 0x24862F0 Offset: 0x24854F0 VA: 0x1824862F0
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, string mipmapLimitGroupName) { }

	[ExcludeFromDocs]
	// RVA: 0x2486610 Offset: 0x2485810 VA: 0x182486610
	public void .ctor(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x24865A0 Offset: 0x24857A0 VA: 0x1824865A0
	public void .ctor(int width, int height, DefaultFormat format, int mipCount, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2486B50 Offset: 0x2485D50 VA: 0x182486B50
	public void .ctor(int width, int height, DefaultFormat format, int mipCount, string mipmapLimitGroupName, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2486160 Offset: 0x2485360 VA: 0x182486160
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2486120 Offset: 0x2485320 VA: 0x182486120
	public void .ctor(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x24862B0 Offset: 0x24854B0 VA: 0x1824862B0
	public void .ctor(int width, int height, GraphicsFormat format, int mipCount, string mipmapLimitGroupName, TextureCreationFlags flags) { }

	// RVA: 0x24867A0 Offset: 0x24859A0 VA: 0x1824867A0
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x2486560 Offset: 0x2485760 VA: 0x182486560
	public void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2486A40 Offset: 0x2485C40 VA: 0x182486A40
	public void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x2486CA0 Offset: 0x2485EA0 VA: 0x182486CA0
	public void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x24866D0 Offset: 0x24858D0 VA: 0x1824866D0
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x2486BD0 Offset: 0x2485DD0 VA: 0x182486BD0
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x2486A90 Offset: 0x2485C90 VA: 0x182486A90
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	[ExcludeFromDocs]
	// RVA: 0x2486210 Offset: 0x2485410 VA: 0x182486210
	public void .ctor(int width, int height) { }

	// RVA: 0x2483F50 Offset: 0x2483150 VA: 0x182483F50
	public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex) { }

	[ExcludeFromDocs]
	// RVA: 0x24859B0 Offset: 0x2484BB0 VA: 0x1824859B0
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x2485A70 Offset: 0x2484C70 VA: 0x182485A70
	public void SetPixel(int x, int y, Color color, int mipLevel) { }

	// RVA: 0x2485C50 Offset: 0x2484E50 VA: 0x182485C50
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2485D80 Offset: 0x2484F80 VA: 0x182485D80
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	// RVA: 0x2485DB0 Offset: 0x2484FB0 VA: 0x182485DB0
	public void SetPixels(Color[] colors, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2485D00 Offset: 0x2484F00 VA: 0x182485D00
	public void SetPixels(Color[] colors) { }

	[ExcludeFromDocs]
	// RVA: 0x2484670 Offset: 0x2483870 VA: 0x182484670
	public Color GetPixel(int x, int y) { }

	// RVA: 0x2484740 Offset: 0x2483940 VA: 0x182484740
	public Color GetPixel(int x, int y, int mipLevel) { }

	[ExcludeFromDocs]
	// RVA: 0x24844C0 Offset: 0x24836C0 VA: 0x1824844C0
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x24843E0 Offset: 0x24835E0 VA: 0x1824843E0
	public Color GetPixelBilinear(float u, float v, int mipLevel) { }

	// RVA: 0x2484EF0 Offset: 0x24840F0 VA: 0x182484EF0
	public void LoadRawTextureData(IntPtr data, int size) { }

	// RVA: 0x2484DC0 Offset: 0x2483FC0 VA: 0x182484DC0
	public void LoadRawTextureData(byte[] data) { }

	// RVA: -1 Offset: -1
	public void LoadRawTextureData<T>(NativeArray<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA87070 Offset: 0xA86270 VA: 0x180A87070
	|-Texture2D.LoadRawTextureData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(T[] data, int mipLevel, int sourceDataStartIndex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA87220 Offset: 0xA86420 VA: 0x180A87220
	|-Texture2D.SetPixelData<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA87440 Offset: 0xA86640 VA: 0x180A87440
	|-Texture2D.SetPixelData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> GetPixelData<T>(int mipLevel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA86A50 Offset: 0xA85C50 VA: 0x180A86A50
	|-Texture2D.GetPixelData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> GetRawTextureData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA86E30 Offset: 0xA86030 VA: 0x180A86E30
	|-Texture2D.GetRawTextureData<Color>
	|
	|-RVA: 0xA86D20 Offset: 0xA85F20 VA: 0x180A86D20
	|-Texture2D.GetRawTextureData<Color32>
	|
	|-RVA: 0xA86F40 Offset: 0xA86140 VA: 0x180A86F40
	|-Texture2D.GetRawTextureData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2483DC0 Offset: 0x2482FC0 VA: 0x182483DC0
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	// RVA: 0x2483E70 Offset: 0x2483070 VA: 0x182483E70
	public void Apply(bool updateMipmaps) { }

	[ExcludeFromDocs]
	// RVA: 0x2483E60 Offset: 0x2483060 VA: 0x182483E60
	public void Apply() { }

	// RVA: 0x2485510 Offset: 0x2484710 VA: 0x182485510
	public bool Reinitialize(int width, int height) { }

	// RVA: 0x2485650 Offset: 0x2484850 VA: 0x182485650
	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x24855A0 Offset: 0x24847A0 VA: 0x1824855A0
	public bool Reinitialize(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	[Obsolete("Texture2D.Resize(int, int) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32)", False)]
	// RVA: 0x2485510 Offset: 0x2484710 VA: 0x182485510
	public bool Resize(int width, int height) { }

	[Obsolete("Texture2D.Resize(int, int, TextureFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, TextureFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.TextureFormat, [*] System.Boolean)", False)]
	// RVA: 0x24856C0 Offset: 0x24848C0 VA: 0x1824856C0
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	[Obsolete("Texture2D.Resize(int, int, GraphicsFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, GraphicsFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, [*] System.Boolean)", False)]
	// RVA: 0x24855A0 Offset: 0x24847A0 VA: 0x1824855A0
	public bool Resize(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	// RVA: 0x2485320 Offset: 0x2484520 VA: 0x182485320
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocs]
	// RVA: 0x2485260 Offset: 0x2484460 VA: 0x182485260
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x24840D0 Offset: 0x24832D0 VA: 0x1824840D0
	public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results) { }

	// RVA: 0x2485730 Offset: 0x2484930 VA: 0x182485730
	public void SetPixels32(Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2485B30 Offset: 0x2484D30 VA: 0x182485B30
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x2485790 Offset: 0x2484990 VA: 0x182485790
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2485B80 Offset: 0x2484D80 VA: 0x182485B80
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	// RVA: 0x2484900 Offset: 0x2483B00 VA: 0x182484900
	public Color[] GetPixels(int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x24849C0 Offset: 0x2483BC0 VA: 0x1824849C0
	public Color[] GetPixels() { }

	// RVA: 0x24858D0 Offset: 0x2484AD0 VA: 0x1824858D0
	private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color) { }

	// RVA: 0x2484590 Offset: 0x2483790 VA: 0x182484590
	private void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret) { }

	// RVA: 0x2484300 Offset: 0x2483500 VA: 0x182484300
	private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret) { }

	// RVA: 0x2485180 Offset: 0x2484380 VA: 0x182485180
	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }
}

// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
public sealed class Cubemap : Texture // TypeDefIndex: 14063
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	[FreeFunction("CubemapScripting::Create")]
	// RVA: 0x24783C0 Offset: 0x24775C0 VA: 0x1824783C0
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2478420 Offset: 0x2477620 VA: 0x182478420
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2478FF0 Offset: 0x24781F0 VA: 0x182478FF0 Slot: 8
	public override bool get_isReadable() { }

	// RVA: 0x24784F0 Offset: 0x24776F0 VA: 0x1824784F0
	internal bool ValidateFormat(TextureFormat format, int width) { }

	// RVA: 0x24785F0 Offset: 0x24777F0 VA: 0x1824785F0
	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	[ExcludeFromDocs]
	// RVA: 0x2478840 Offset: 0x2477A40 VA: 0x182478840
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x24788E0 Offset: 0x2477AE0 VA: 0x1824788E0
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x2478930 Offset: 0x2477B30 VA: 0x182478930
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x24789D0 Offset: 0x2477BD0 VA: 0x1824789D0
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2478D50 Offset: 0x2477F50 VA: 0x182478D50
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x2478C70 Offset: 0x2477E70 VA: 0x182478C70
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2478790 Offset: 0x2477990 VA: 0x182478790
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x2478C50 Offset: 0x2477E50 VA: 0x182478C50
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x2478D20 Offset: 0x2477F20 VA: 0x182478D20
	public void .ctor(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	// RVA: 0x2478730 Offset: 0x2477930 VA: 0x182478730
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}

// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture3D.h")]
public sealed class Texture3D : Texture // TypeDefIndex: 14064
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x2487D40 Offset: 0x2486F40 VA: 0x182487D40 Slot: 8
	public override bool get_isReadable() { }

	[FreeFunction("Texture3DScripting::Create")]
	// RVA: 0x2487340 Offset: 0x2486540 VA: 0x182487340
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x24873A0 Offset: 0x24865A0 VA: 0x1824873A0
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[ExcludeFromDocs]
	// RVA: 0x2487B30 Offset: 0x2486D30 VA: 0x182487B30
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x24875B0 Offset: 0x24867B0 VA: 0x1824875B0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x2487A80 Offset: 0x2486C80 VA: 0x182487A80
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2487610 Offset: 0x2486810 VA: 0x182487610
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x2487D00 Offset: 0x2486F00 VA: 0x182487D00
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x2487CC0 Offset: 0x2486EC0 VA: 0x182487CC0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x2487880 Offset: 0x2486A80 VA: 0x182487880
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x24874F0 Offset: 0x24866F0 VA: 0x1824874F0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x24877C0 Offset: 0x24869C0 VA: 0x1824877C0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x2487BF0 Offset: 0x2486DF0 VA: 0x182487BF0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x2487490 Offset: 0x2486690 VA: 0x182487490
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Texture2DArray.h")]
[ExcludeFromPreset]
public sealed class Texture2DArray : Texture // TypeDefIndex: 14065
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x2483D20 Offset: 0x2482F20 VA: 0x182483D20 Slot: 8
	public override bool get_isReadable() { }

	[FreeFunction("Texture2DArrayScripting::Create")]
	// RVA: 0x2482DF0 Offset: 0x2481FF0 VA: 0x182482DF0
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x2482E50 Offset: 0x2482050 VA: 0x182482E50
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x2483090 Offset: 0x2482290 VA: 0x182483090
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x2482F30 Offset: 0x2482130 VA: 0x182482F30
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	[ExcludeFromDocs]
	// RVA: 0x2483CC0 Offset: 0x2482EC0 VA: 0x182483CC0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x24832C0 Offset: 0x24824C0 VA: 0x1824832C0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	// RVA: 0x2483730 Offset: 0x2482930 VA: 0x182483730
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2483930 Offset: 0x2482B30 VA: 0x182483930
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2483460 Offset: 0x2482660 VA: 0x182483460
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x2483AE0 Offset: 0x2482CE0 VA: 0x182483AE0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2483BF0 Offset: 0x2482DF0 VA: 0x182483BF0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x2483B20 Offset: 0x2482D20 VA: 0x182483B20
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[ExcludeFromDocs]
	// RVA: 0x2483200 Offset: 0x2482400 VA: 0x182483200
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x24831A0 Offset: 0x24823A0 VA: 0x1824831A0
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}

// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapArrayTexture.h")]
public sealed class CubemapArray : Texture // TypeDefIndex: 14066
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x2478380 Offset: 0x2477580 VA: 0x182478380 Slot: 8
	public override bool get_isReadable() { }

	[FreeFunction("CubemapArrayScripting::Create")]
	// RVA: 0x2477A70 Offset: 0x2476C70 VA: 0x182477A70
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x2477AD0 Offset: 0x2476CD0 VA: 0x182477AD0
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2477DD0 Offset: 0x2476FD0 VA: 0x182477DD0
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x24781E0 Offset: 0x24773E0 VA: 0x1824781E0
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	// RVA: 0x2478230 Offset: 0x2477430 VA: 0x182478230
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2477C00 Offset: 0x2476E00 VA: 0x182477C00
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2477E80 Offset: 0x2477080 VA: 0x182477E80
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x2477DA0 Offset: 0x2476FA0 VA: 0x182477DA0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2478060 Offset: 0x2477260 VA: 0x182478060
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x2478120 Offset: 0x2477320 VA: 0x182478120
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x24782D0 Offset: 0x24774D0 VA: 0x1824782D0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2477BA0 Offset: 0x2476DA0 VA: 0x182477BA0
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
public class RenderTexture : Texture // TypeDefIndex: 14067
{
	// Properties
	public override int width { get; set; }
	public override int height { get; set; }
	public GraphicsFormat graphicsFormat { set; }
	public GraphicsFormat depthStencilFormat { get; set; }
	public static RenderTexture active { get; set; }
	public RenderBuffer colorBuffer { get; }
	public RenderBuffer depthBuffer { get; }
	public RenderTextureDescriptor descriptor { get; }

	// Methods

	// RVA: 0x2482CD0 Offset: 0x2481ED0 VA: 0x182482CD0 Slot: 4
	public override int get_width() { }

	// RVA: 0x2482D90 Offset: 0x2481F90 VA: 0x182482D90 Slot: 5
	public override void set_width(int value) { }

	// RVA: 0x2482C90 Offset: 0x2481E90 VA: 0x182482C90 Slot: 6
	public override int get_height() { }

	// RVA: 0x2482D50 Offset: 0x2481F50 VA: 0x182482D50 Slot: 7
	public override void set_height(int value) { }

	[NativeName("SetColorFormat")]
	// RVA: 0x24815C0 Offset: 0x24807C0 VA: 0x1824815C0
	private void SetColorFormat(GraphicsFormat format) { }

	// RVA: 0x24815C0 Offset: 0x24807C0 VA: 0x1824815C0
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x2482BC0 Offset: 0x2481DC0 VA: 0x182482BC0
	public GraphicsFormat get_depthStencilFormat() { }

	// RVA: 0x2482D10 Offset: 0x2481F10 VA: 0x182482D10
	public void set_depthStencilFormat(GraphicsFormat value) { }

	[FreeFunction("RenderTexture::GetActive")]
	// RVA: 0x2480270 Offset: 0x247F470 VA: 0x182480270
	private static RenderTexture GetActive() { }

	[FreeFunction("RenderTextureScripting::SetActive")]
	// RVA: 0x2481580 Offset: 0x2480780 VA: 0x182481580
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x2480270 Offset: 0x247F470 VA: 0x182480270
	public static RenderTexture get_active() { }

	// RVA: 0x2481580 Offset: 0x2480780 VA: 0x182481580
	public static void set_active(RenderTexture value) { }

	[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = True)]
	// RVA: 0x24802F0 Offset: 0x247F4F0 VA: 0x1824802F0
	private RenderBuffer GetColorBuffer() { }

	[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = True)]
	// RVA: 0x2480520 Offset: 0x247F720 VA: 0x182480520
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x2481600 Offset: 0x2480800 VA: 0x182481600
	private void SetMipMapCount(int count) { }

	// RVA: 0x2482B00 Offset: 0x2481D00 VA: 0x182482B00
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x2482B60 Offset: 0x2481D60 VA: 0x182482B60
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x2480230 Offset: 0x247F430 VA: 0x182480230
	public bool Create() { }

	// RVA: 0x2481540 Offset: 0x2480740 VA: 0x182481540
	public void Release() { }

	// RVA: 0x24816E0 Offset: 0x24808E0 VA: 0x1824816E0
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunction("RenderTextureScripting::Create")]
	// RVA: 0x24814C0 Offset: 0x24806C0 VA: 0x1824814C0
	private static void Internal_Create(RenderTexture rt) { }

	[NativeName("SetRenderTextureDescFromScript")]
	// RVA: 0x2481690 Offset: 0x2480890 VA: 0x182481690
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeName("GetRenderTextureDesc")]
	// RVA: 0x24806D0 Offset: 0x247F8D0 VA: 0x1824806D0
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	// RVA: 0x2480870 Offset: 0x247FA70 VA: 0x182480870
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	// RVA: 0x2481500 Offset: 0x2480700 VA: 0x182481500
	public static void ReleaseTemporary(RenderTexture temp) { }

	[RequiredByNativeCode]
	// RVA: 0x24826D0 Offset: 0x24818D0 VA: 0x1824826D0
	protected internal void .ctor() { }

	// RVA: 0x2481F40 Offset: 0x2481140 VA: 0x182481F40
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x24828C0 Offset: 0x2481AC0 VA: 0x1824828C0
	public void .ctor(RenderTexture textureToCopy) { }

	[ExcludeFromDocs]
	// RVA: 0x24825D0 Offset: 0x24817D0 VA: 0x1824825D0
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x2481C90 Offset: 0x2480E90 VA: 0x182481C90
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x24822C0 Offset: 0x24814C0 VA: 0x1824822C0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x2481D30 Offset: 0x2480F30 VA: 0x182481D30
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x2482820 Offset: 0x2481A20 VA: 0x182482820
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x24824F0 Offset: 0x24816F0 VA: 0x1824824F0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	// RVA: 0x24821A0 Offset: 0x24813A0 VA: 0x1824821A0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x2482080 Offset: 0x2481280 VA: 0x182482080
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocs]
	// RVA: 0x2482750 Offset: 0x2481950 VA: 0x182482750
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x2481310 Offset: 0x2480510 VA: 0x182481310
	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	// RVA: 0x2480600 Offset: 0x247F800 VA: 0x182480600
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	// RVA: 0x24805F0 Offset: 0x247F7F0 VA: 0x1824805F0
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format) { }

	// RVA: 0x24805F0 Offset: 0x247F7F0 VA: 0x1824805F0
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	// RVA: 0x2480570 Offset: 0x247F770 VA: 0x182480570
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	// RVA: 0x2482C00 Offset: 0x2481E00 VA: 0x182482C00
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x2481730 Offset: 0x2480930 VA: 0x182481730
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x2480470 Offset: 0x247F670 VA: 0x182480470
	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	// RVA: 0x24804A0 Offset: 0x247F6A0 VA: 0x1824804A0
	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	// RVA: 0x2480340 Offset: 0x247F540 VA: 0x182480340
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x2480FF0 Offset: 0x24801F0 VA: 0x182480FF0
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x2480730 Offset: 0x247F930 VA: 0x182480730
	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	// RVA: 0x24811C0 Offset: 0x24803C0 VA: 0x1824811C0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocs]
	// RVA: 0x2480C50 Offset: 0x247FE50 VA: 0x182480C50
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocs]
	// RVA: 0x24809E0 Offset: 0x247FBE0 VA: 0x1824809E0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocs]
	// RVA: 0x2480D90 Offset: 0x247FF90 VA: 0x182480D90
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	[ExcludeFromDocs]
	// RVA: 0x2480EC0 Offset: 0x24800C0 VA: 0x182480EC0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	// RVA: 0x2481090 Offset: 0x2480290 VA: 0x182481090
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x24808B0 Offset: 0x247FAB0 VA: 0x1824808B0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocs]
	// RVA: 0x2480B20 Offset: 0x247FD20 VA: 0x182480B20
	public static RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x24802A0 Offset: 0x247F4A0 VA: 0x1824802A0
	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x24804D0 Offset: 0x247F6D0 VA: 0x1824804D0
	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x2481640 Offset: 0x2480840 VA: 0x182481640
	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0x2480680 Offset: 0x247F880 VA: 0x182480680
	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	// RVA: 0x2480830 Offset: 0x247FA30 VA: 0x182480830
	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/CustomRenderTexture.h")]
public sealed class CustomRenderTexture : RenderTexture // TypeDefIndex: 14068
{}

// Namespace: UnityEngine
public struct RenderTextureDescriptor // TypeDefIndex: 14069
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <width>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <height>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <msaaSamples>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <volumeDepth>k__BackingField; // 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <mipCount>k__BackingField; // 0x10
	private GraphicsFormat _graphicsFormat; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private GraphicsFormat <depthStencilFormat>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TextureDimension <dimension>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VRTextureUsage <vrUsage>k__BackingField; // 0x28
	private RenderTextureCreationFlags _flags; // 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private RenderTextureMemoryless <memoryless>k__BackingField; // 0x30

	// Properties
	public int width { get; set; }
	public int height { get; set; }
	public int msaaSamples { get; set; }
	public int volumeDepth { get; set; }
	public int mipCount { set; }
	public GraphicsFormat graphicsFormat { get; set; }
	public GraphicsFormat depthStencilFormat { get; set; }
	public int depthBufferBits { get; set; }
	public TextureDimension dimension { get; set; }
	public ShadowSamplingMode shadowSamplingMode { set; }
	public VRTextureUsage vrUsage { set; }
	public RenderTextureMemoryless memoryless { set; }
	internal bool createdFromScript { set; }
	public bool useDynamicScale { set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_width() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_width(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_height() { }

	[CompilerGenerated]
	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_height(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_msaaSamples() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_msaaSamples(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_volumeDepth() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_volumeDepth(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_mipCount(int value) { }

	// RVA: 0x10EBDC0 Offset: 0x10EAFC0 VA: 0x1810EBDC0
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x2480150 Offset: 0x247F350 VA: 0x182480150
	public void set_graphicsFormat(GraphicsFormat value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public GraphicsFormat get_depthStencilFormat() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x24800B0 Offset: 0x247F2B0 VA: 0x1824800B0
	public int get_depthBufferBits() { }

	// RVA: 0x2480120 Offset: 0x247F320 VA: 0x182480120
	public void set_depthBufferBits(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public TextureDimension get_dimension() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_dimension(TextureDimension value) { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[CompilerGenerated]
	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_vrUsage(VRTextureUsage value) { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_memoryless(RenderTextureMemoryless value) { }

	[ExcludeFromDocs]
	// RVA: 0x247FF60 Offset: 0x247F160 VA: 0x18247FF60
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[ExcludeFromDocs]
	// RVA: 0x2480040 Offset: 0x247F240 VA: 0x182480040
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	// RVA: 0x247FF40 Offset: 0x247F140 VA: 0x18247FF40
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x2480100 Offset: 0x247F300 VA: 0x182480100
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x2480210 Offset: 0x247F410 VA: 0x182480210
	public void set_useDynamicScale(bool value) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Hashing/Hash128.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Utilities/Hash128.h")]
[Serializable]
public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128> // TypeDefIndex: 14070
{
	// Fields
	internal ulong u64_0; // 0x0
	internal ulong u64_1; // 0x8

	// Properties
	public bool isValid { get; }

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(ulong u64_0, ulong u64_1) { }

	// RVA: 0x24799C0 Offset: 0x2478BC0 VA: 0x1824799C0
	public bool get_isValid() { }

	// RVA: 0x2479650 Offset: 0x2478850 VA: 0x182479650 Slot: 5
	public int CompareTo(Hash128 rhs) { }

	// RVA: 0x2479980 Offset: 0x2478B80 VA: 0x182479980 Slot: 3
	public override string ToString() { }

	[FreeFunction("StringToHash128", IsThreadSafe = True)]
	// RVA: 0x2479930 Offset: 0x2478B30 VA: 0x182479930
	public static Hash128 Parse(string hashString) { }

	[FreeFunction("Hash128ToString", IsThreadSafe = True)]
	// RVA: 0x24798A0 Offset: 0x2478AA0 VA: 0x1824798A0
	private static string Hash128ToStringImpl(Hash128 hash) { }

	[FreeFunction("ComputeHash128FromScriptString", IsThreadSafe = True)]
	// RVA: 0x24796A0 Offset: 0x24788A0 VA: 0x1824796A0
	private static void ComputeFromString(string data, ref Hash128 hash) { }

	// RVA: 0x24796F0 Offset: 0x24788F0 VA: 0x1824796F0
	public static Hash128 Compute(string data) { }

	// RVA: 0x2479750 Offset: 0x2478950 VA: 0x182479750 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2479800 Offset: 0x2478A00 VA: 0x182479800 Slot: 6
	public bool Equals(Hash128 obj) { }

	// RVA: 0x2479830 Offset: 0x2478A30 VA: 0x182479830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2479570 Offset: 0x2478770 VA: 0x182479570 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x24799E0 Offset: 0x2478BE0 VA: 0x1824799E0
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x2479A30 Offset: 0x2478C30 VA: 0x182479A30
	public static bool op_Inequality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x2479A60 Offset: 0x2478C60 VA: 0x182479A60
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0x2479A00 Offset: 0x2478C00 VA: 0x182479A00
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0x24798E0 Offset: 0x2478AE0 VA: 0x1824798E0
	private static void Parse_Injected(string hashString, out Hash128 ret) { }

	// RVA: 0x2479860 Offset: 0x2478A60 VA: 0x182479860
	private static string Hash128ToStringImpl_Injected(ref Hash128 hash) { }
}

// Namespace: UnityEngine
public enum CursorMode // TypeDefIndex: 14071
{
	// Fields
	public int value__; // 0x0
	public const CursorMode Auto = 0;
	public const CursorMode ForceSoftware = 1;
}

// Namespace: UnityEngine
public enum CursorLockMode // TypeDefIndex: 14072
{
	// Fields
	public int value__; // 0x0
	public const CursorLockMode None = 0;
	public const CursorLockMode Locked = 1;
	public const CursorLockMode Confined = 2;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
public class Cursor // TypeDefIndex: 14073
{
	// Properties
	public static bool visible { get; set; }
	public static CursorLockMode lockState { get; }

	// Methods

	// RVA: 0x2479090 Offset: 0x2478290 VA: 0x182479090
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x2479110 Offset: 0x2478310 VA: 0x182479110
	public static bool get_visible() { }

	// RVA: 0x2479140 Offset: 0x2478340 VA: 0x182479140
	public static void set_visible(bool value) { }

	// RVA: 0x24790E0 Offset: 0x24782E0 VA: 0x1824790E0
	public static CursorLockMode get_lockState() { }

	// RVA: 0x2479030 Offset: 0x2478230 VA: 0x182479030
	private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode) { }
}

// Namespace: UnityEngine
public enum KeyCode // TypeDefIndex: 14074
{
	// Fields
	public int value__; // 0x0
	public const KeyCode None = 0;
	public const KeyCode Backspace = 8;
	public const KeyCode Delete = 127;
	public const KeyCode Tab = 9;
	public const KeyCode Clear = 12;
	public const KeyCode Return = 13;
	public const KeyCode Pause = 19;
	public const KeyCode Escape = 27;
	public const KeyCode Space = 32;
	public const KeyCode Keypad0 = 256;
	public const KeyCode Keypad1 = 257;
	public const KeyCode Keypad2 = 258;
	public const KeyCode Keypad3 = 259;
	public const KeyCode Keypad4 = 260;
	public const KeyCode Keypad5 = 261;
	public const KeyCode Keypad6 = 262;
	public const KeyCode Keypad7 = 263;
	public const KeyCode Keypad8 = 264;
	public const KeyCode Keypad9 = 265;
	public const KeyCode KeypadPeriod = 266;
	public const KeyCode KeypadDivide = 267;
	public const KeyCode KeypadMultiply = 268;
	public const KeyCode KeypadMinus = 269;
	public const KeyCode KeypadPlus = 270;
	public const KeyCode KeypadEnter = 271;
	public const KeyCode KeypadEquals = 272;
	public const KeyCode UpArrow = 273;
	public const KeyCode DownArrow = 274;
	public const KeyCode RightArrow = 275;
	public const KeyCode LeftArrow = 276;
	public const KeyCode Insert = 277;
	public const KeyCode Home = 278;
	public const KeyCode End = 279;
	public const KeyCode PageUp = 280;
	public const KeyCode PageDown = 281;
	public const KeyCode F1 = 282;
	public const KeyCode F2 = 283;
	public const KeyCode F3 = 284;
	public const KeyCode F4 = 285;
	public const KeyCode F5 = 286;
	public const KeyCode F6 = 287;
	public const KeyCode F7 = 288;
	public const KeyCode F8 = 289;
	public const KeyCode F9 = 290;
	public const KeyCode F10 = 291;
	public const KeyCode F11 = 292;
	public const KeyCode F12 = 293;
	public const KeyCode F13 = 294;
	public const KeyCode F14 = 295;
	public const KeyCode F15 = 296;
	public const KeyCode Alpha0 = 48;
	public const KeyCode Alpha1 = 49;
	public const KeyCode Alpha2 = 50;
	public const KeyCode Alpha3 = 51;
	public const KeyCode Alpha4 = 52;
	public const KeyCode Alpha5 = 53;
	public const KeyCode Alpha6 = 54;
	public const KeyCode Alpha7 = 55;
	public const KeyCode Alpha8 = 56;
	public const KeyCode Alpha9 = 57;
	public const KeyCode Exclaim = 33;
	public const KeyCode DoubleQuote = 34;
	public const KeyCode Hash = 35;
	public const KeyCode Dollar = 36;
	public const KeyCode Percent = 37;
	public const KeyCode Ampersand = 38;
	public const KeyCode Quote = 39;
	public const KeyCode LeftParen = 40;
	public const KeyCode RightParen = 41;
	public const KeyCode Asterisk = 42;
	public const KeyCode Plus = 43;
	public const KeyCode Comma = 44;
	public const KeyCode Minus = 45;
	public const KeyCode Period = 46;
	public const KeyCode Slash = 47;
	public const KeyCode Colon = 58;
	public const KeyCode Semicolon = 59;
	public const KeyCode Less = 60;
	public const KeyCode Equals = 61;
	public const KeyCode Greater = 62;
	public const KeyCode Question = 63;
	public const KeyCode At = 64;
	public const KeyCode LeftBracket = 91;
	public const KeyCode Backslash = 92;
	public const KeyCode RightBracket = 93;
	public const KeyCode Caret = 94;
	public const KeyCode Underscore = 95;
	public const KeyCode BackQuote = 96;
	public const KeyCode A = 97;
	public const KeyCode B = 98;
	public const KeyCode C = 99;
	public const KeyCode D = 100;
	public const KeyCode E = 101;
	public const KeyCode F = 102;
	public const KeyCode G = 103;
	public const KeyCode H = 104;
	public const KeyCode I = 105;
	public const KeyCode J = 106;
	public const KeyCode K = 107;
	public const KeyCode L = 108;
	public const KeyCode M = 109;
	public const KeyCode N = 110;
	public const KeyCode O = 111;
	public const KeyCode P = 112;
	public const KeyCode Q = 113;
	public const KeyCode R = 114;
	public const KeyCode S = 115;
	public const KeyCode T = 116;
	public const KeyCode U = 117;
	public const KeyCode V = 118;
	public const KeyCode W = 119;
	public const KeyCode X = 120;
	public const KeyCode Y = 121;
	public const KeyCode Z = 122;
	public const KeyCode LeftCurlyBracket = 123;
	public const KeyCode Pipe = 124;
	public const KeyCode RightCurlyBracket = 125;
	public const KeyCode Tilde = 126;
	public const KeyCode Numlock = 300;
	public const KeyCode CapsLock = 301;
	public const KeyCode ScrollLock = 302;
	public const KeyCode RightShift = 303;
	public const KeyCode LeftShift = 304;
	public const KeyCode RightControl = 305;
	public const KeyCode LeftControl = 306;
	public const KeyCode RightAlt = 307;
	public const KeyCode LeftAlt = 308;
	public const KeyCode LeftMeta = 310;
	public const KeyCode LeftCommand = 310;
	public const KeyCode LeftApple = 310;
	public const KeyCode LeftWindows = 311;
	public const KeyCode RightMeta = 309;
	public const KeyCode RightCommand = 309;
	public const KeyCode RightApple = 309;
	public const KeyCode RightWindows = 312;
	public const KeyCode AltGr = 313;
	public const KeyCode Help = 315;
	public const KeyCode Print = 316;
	public const KeyCode SysReq = 317;
	public const KeyCode Break = 318;
	public const KeyCode Menu = 319;
	public const KeyCode Mouse0 = 323;
	public const KeyCode Mouse1 = 324;
	public const KeyCode Mouse2 = 325;
	public const KeyCode Mouse3 = 326;
	public const KeyCode Mouse4 = 327;
	public const KeyCode Mouse5 = 328;
	public const KeyCode Mouse6 = 329;
	public const KeyCode JoystickButton0 = 330;
	public const KeyCode JoystickButton1 = 331;
	public const KeyCode JoystickButton2 = 332;
	public const KeyCode JoystickButton3 = 333;
	public const KeyCode JoystickButton4 = 334;
	public const KeyCode JoystickButton5 = 335;
	public const KeyCode JoystickButton6 = 336;
	public const KeyCode JoystickButton7 = 337;
	public const KeyCode JoystickButton8 = 338;
	public const KeyCode JoystickButton9 = 339;
	public const KeyCode JoystickButton10 = 340;
	public const KeyCode JoystickButton11 = 341;
	public const KeyCode JoystickButton12 = 342;
	public const KeyCode JoystickButton13 = 343;
	public const KeyCode JoystickButton14 = 344;
	public const KeyCode JoystickButton15 = 345;
	public const KeyCode JoystickButton16 = 346;
	public const KeyCode JoystickButton17 = 347;
	public const KeyCode JoystickButton18 = 348;
	public const KeyCode JoystickButton19 = 349;
	public const KeyCode Joystick1Button0 = 350;
	public const KeyCode Joystick1Button1 = 351;
	public const KeyCode Joystick1Button2 = 352;
	public const KeyCode Joystick1Button3 = 353;
	public const KeyCode Joystick1Button4 = 354;
	public const KeyCode Joystick1Button5 = 355;
	public const KeyCode Joystick1Button6 = 356;
	public const KeyCode Joystick1Button7 = 357;
	public const KeyCode Joystick1Button8 = 358;
	public const KeyCode Joystick1Button9 = 359;
	public const KeyCode Joystick1Button10 = 360;
	public const KeyCode Joystick1Button11 = 361;
	public const KeyCode Joystick1Button12 = 362;
	public const KeyCode Joystick1Button13 = 363;
	public const KeyCode Joystick1Button14 = 364;
	public const KeyCode Joystick1Button15 = 365;
	public const KeyCode Joystick1Button16 = 366;
	public const KeyCode Joystick1Button17 = 367;
	public const KeyCode Joystick1Button18 = 368;
	public const KeyCode Joystick1Button19 = 369;
	public const KeyCode Joystick2Button0 = 370;
	public const KeyCode Joystick2Button1 = 371;
	public const KeyCode Joystick2Button2 = 372;
	public const KeyCode Joystick2Button3 = 373;
	public const KeyCode Joystick2Button4 = 374;
	public const KeyCode Joystick2Button5 = 375;
	public const KeyCode Joystick2Button6 = 376;
	public const KeyCode Joystick2Button7 = 377;
	public const KeyCode Joystick2Button8 = 378;
	public const KeyCode Joystick2Button9 = 379;
	public const KeyCode Joystick2Button10 = 380;
	public const KeyCode Joystick2Button11 = 381;
	public const KeyCode Joystick2Button12 = 382;
	public const KeyCode Joystick2Button13 = 383;
	public const KeyCode Joystick2Button14 = 384;
	public const KeyCode Joystick2Button15 = 385;
	public const KeyCode Joystick2Button16 = 386;
	public const KeyCode Joystick2Button17 = 387;
	public const KeyCode Joystick2Button18 = 388;
	public const KeyCode Joystick2Button19 = 389;
	public const KeyCode Joystick3Button0 = 390;
	public const KeyCode Joystick3Button1 = 391;
	public const KeyCode Joystick3Button2 = 392;
	public const KeyCode Joystick3Button3 = 393;
	public const KeyCode Joystick3Button4 = 394;
	public const KeyCode Joystick3Button5 = 395;
	public const KeyCode Joystick3Button6 = 396;
	public const KeyCode Joystick3Button7 = 397;
	public const KeyCode Joystick3Button8 = 398;
	public const KeyCode Joystick3Button9 = 399;
	public const KeyCode Joystick3Button10 = 400;
	public const KeyCode Joystick3Button11 = 401;
	public const KeyCode Joystick3Button12 = 402;
	public const KeyCode Joystick3Button13 = 403;
	public const KeyCode Joystick3Button14 = 404;
	public const KeyCode Joystick3Button15 = 405;
	public const KeyCode Joystick3Button16 = 406;
	public const KeyCode Joystick3Button17 = 407;
	public const KeyCode Joystick3Button18 = 408;
	public const KeyCode Joystick3Button19 = 409;
	public const KeyCode Joystick4Button0 = 410;
	public const KeyCode Joystick4Button1 = 411;
	public const KeyCode Joystick4Button2 = 412;
	public const KeyCode Joystick4Button3 = 413;
	public const KeyCode Joystick4Button4 = 414;
	public const KeyCode Joystick4Button5 = 415;
	public const KeyCode Joystick4Button6 = 416;
	public const KeyCode Joystick4Button7 = 417;
	public const KeyCode Joystick4Button8 = 418;
	public const KeyCode Joystick4Button9 = 419;
	public const KeyCode Joystick4Button10 = 420;
	public const KeyCode Joystick4Button11 = 421;
	public const KeyCode Joystick4Button12 = 422;
	public const KeyCode Joystick4Button13 = 423;
	public const KeyCode Joystick4Button14 = 424;
	public const KeyCode Joystick4Button15 = 425;
	public const KeyCode Joystick4Button16 = 426;
	public const KeyCode Joystick4Button17 = 427;
	public const KeyCode Joystick4Button18 = 428;
	public const KeyCode Joystick4Button19 = 429;
	public const KeyCode Joystick5Button0 = 430;
	public const KeyCode Joystick5Button1 = 431;
	public const KeyCode Joystick5Button2 = 432;
	public const KeyCode Joystick5Button3 = 433;
	public const KeyCode Joystick5Button4 = 434;
	public const KeyCode Joystick5Button5 = 435;
	public const KeyCode Joystick5Button6 = 436;
	public const KeyCode Joystick5Button7 = 437;
	public const KeyCode Joystick5Button8 = 438;
	public const KeyCode Joystick5Button9 = 439;
	public const KeyCode Joystick5Button10 = 440;
	public const KeyCode Joystick5Button11 = 441;
	public const KeyCode Joystick5Button12 = 442;
	public const KeyCode Joystick5Button13 = 443;
	public const KeyCode Joystick5Button14 = 444;
	public const KeyCode Joystick5Button15 = 445;
	public const KeyCode Joystick5Button16 = 446;
	public const KeyCode Joystick5Button17 = 447;
	public const KeyCode Joystick5Button18 = 448;
	public const KeyCode Joystick5Button19 = 449;
	public const KeyCode Joystick6Button0 = 450;
	public const KeyCode Joystick6Button1 = 451;
	public const KeyCode Joystick6Button2 = 452;
	public const KeyCode Joystick6Button3 = 453;
	public const KeyCode Joystick6Button4 = 454;
	public const KeyCode Joystick6Button5 = 455;
	public const KeyCode Joystick6Button6 = 456;
	public const KeyCode Joystick6Button7 = 457;
	public const KeyCode Joystick6Button8 = 458;
	public const KeyCode Joystick6Button9 = 459;
	public const KeyCode Joystick6Button10 = 460;
	public const KeyCode Joystick6Button11 = 461;
	public const KeyCode Joystick6Button12 = 462;
	public const KeyCode Joystick6Button13 = 463;
	public const KeyCode Joystick6Button14 = 464;
	public const KeyCode Joystick6Button15 = 465;
	public const KeyCode Joystick6Button16 = 466;
	public const KeyCode Joystick6Button17 = 467;
	public const KeyCode Joystick6Button18 = 468;
	public const KeyCode Joystick6Button19 = 469;
	public const KeyCode Joystick7Button0 = 470;
	public const KeyCode Joystick7Button1 = 471;
	public const KeyCode Joystick7Button2 = 472;
	public const KeyCode Joystick7Button3 = 473;
	public const KeyCode Joystick7Button4 = 474;
	public const KeyCode Joystick7Button5 = 475;
	public const KeyCode Joystick7Button6 = 476;
	public const KeyCode Joystick7Button7 = 477;
	public const KeyCode Joystick7Button8 = 478;
	public const KeyCode Joystick7Button9 = 479;
	public const KeyCode Joystick7Button10 = 480;
	public const KeyCode Joystick7Button11 = 481;
	public const KeyCode Joystick7Button12 = 482;
	public const KeyCode Joystick7Button13 = 483;
	public const KeyCode Joystick7Button14 = 484;
	public const KeyCode Joystick7Button15 = 485;
	public const KeyCode Joystick7Button16 = 486;
	public const KeyCode Joystick7Button17 = 487;
	public const KeyCode Joystick7Button18 = 488;
	public const KeyCode Joystick7Button19 = 489;
	public const KeyCode Joystick8Button0 = 490;
	public const KeyCode Joystick8Button1 = 491;
	public const KeyCode Joystick8Button2 = 492;
	public const KeyCode Joystick8Button3 = 493;
	public const KeyCode Joystick8Button4 = 494;
	public const KeyCode Joystick8Button5 = 495;
	public const KeyCode Joystick8Button6 = 496;
	public const KeyCode Joystick8Button7 = 497;
	public const KeyCode Joystick8Button8 = 498;
	public const KeyCode Joystick8Button9 = 499;
	public const KeyCode Joystick8Button10 = 500;
	public const KeyCode Joystick8Button11 = 501;
	public const KeyCode Joystick8Button12 = 502;
	public const KeyCode Joystick8Button13 = 503;
	public const KeyCode Joystick8Button14 = 504;
	public const KeyCode Joystick8Button15 = 505;
	public const KeyCode Joystick8Button16 = 506;
	public const KeyCode Joystick8Button17 = 507;
	public const KeyCode Joystick8Button18 = 508;
	public const KeyCode Joystick8Button19 = 509;
}

// Namespace: UnityEngine
public interface ILogger : ILogHandler // TypeDefIndex: 14075
{
	// Properties
	public abstract ILogHandler logHandler { get; set; }
	public abstract bool logEnabled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ILogHandler get_logHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_logHandler(ILogHandler value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_logEnabled();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IsLogTypeAllowed(LogType logType);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Log(LogType logType, object message);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Log(LogType logType, object message, Object context);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Log(LogType logType, string tag, object message);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Log(string tag, object message);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void LogWarning(string tag, object message);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void LogError(string tag, object message);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void LogFormat(LogType logType, string format, object[] args);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void LogException(Exception exception);
}

// Namespace: UnityEngine
public interface ILogHandler // TypeDefIndex: 14076
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LogFormat(LogType logType, Object context, string format, object[] args);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LogException(Exception exception, Object context);
}

// Namespace: UnityEngine
public class Logger : ILogger, ILogHandler // TypeDefIndex: 14077
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ILogHandler <logHandler>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <logEnabled>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Properties
	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }

	// Methods

	// RVA: 0x247A5E0 Offset: 0x24797E0 VA: 0x18247A5E0
	public void .ctor(ILogHandler logHandler) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public ILogHandler get_logHandler() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 5
	public void set_logHandler(ILogHandler value) { }

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20 Slot: 6
	public bool get_logEnabled() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30 Slot: 18
	public void set_logEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 19
	public LogType get_filterLogType() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290 Slot: 20
	public void set_filterLogType(LogType value) { }

	// RVA: 0x2479BB0 Offset: 0x2478DB0 VA: 0x182479BB0 Slot: 7
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x2479A80 Offset: 0x2478C80 VA: 0x182479A80
	private static string GetString(object message) { }

	// RVA: 0x247A390 Offset: 0x2479590 VA: 0x18247A390 Slot: 8
	public void Log(LogType logType, object message) { }

	// RVA: 0x247A4B0 Offset: 0x24796B0 VA: 0x18247A4B0 Slot: 9
	public void Log(LogType logType, object message, Object context) { }

	// RVA: 0x247A0C0 Offset: 0x24792C0 VA: 0x18247A0C0 Slot: 10
	public void Log(LogType logType, string tag, object message) { }

	// RVA: 0x247A230 Offset: 0x2479430 VA: 0x18247A230 Slot: 11
	public void Log(string tag, object message) { }

	// RVA: 0x2479F60 Offset: 0x2479160 VA: 0x182479F60 Slot: 12
	public void LogWarning(string tag, object message) { }

	// RVA: 0x2479BD0 Offset: 0x2478DD0 VA: 0x182479BD0 Slot: 13
	public void LogError(string tag, object message) { }

	// RVA: 0x2479DB0 Offset: 0x2478FB0 VA: 0x182479DB0 Slot: 15
	public void LogException(Exception exception) { }

	// RVA: 0x2479D30 Offset: 0x2478F30 VA: 0x182479D30 Slot: 17
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x2479E20 Offset: 0x2479020 VA: 0x182479E20 Slot: 14
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x2479EC0 Offset: 0x24790C0 VA: 0x182479EC0 Slot: 16
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
internal class UnityLogWriter : TextWriter // TypeDefIndex: 14078
{
	// Properties
	public override Encoding Encoding { get; }

	// Methods

	[ThreadAndSerializationSafe]
	// RVA: 0x2488D10 Offset: 0x2487F10 VA: 0x182488D10
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2488CD0 Offset: 0x2487ED0 VA: 0x182488CD0
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x2488C30 Offset: 0x2487E30 VA: 0x182488C30
	public static void Init() { }

	// RVA: 0x2488EB0 Offset: 0x24880B0 VA: 0x182488EB0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x2488D90 Offset: 0x2487F90 VA: 0x182488D90 Slot: 14
	public override void Write(char value) { }

	// RVA: 0x2488D50 Offset: 0x2487F50 VA: 0x182488D50 Slot: 23
	public override void Write(string s) { }

	// RVA: 0x2488E10 Offset: 0x2488010 VA: 0x182488E10 Slot: 16
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x2488E60 Offset: 0x2488060 VA: 0x182488E60
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeClass("ColorRGBAf")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[DefaultMember("Item")]
[NativeHeader("Runtime/Math/Color.h")]
public struct Color : IEquatable<Color>, IFormattable // TypeDefIndex: 14079
{
	// Fields
	public float r; // 0x0
	public float g; // 0x4
	public float b; // 0x8
	public float a; // 0xC

	// Properties
	public static Color red { get; }
	public static Color green { get; }
	public static Color blue { get; }
	public static Color white { get; }
	public static Color black { get; }
	public static Color yellow { get; }
	public static Color cyan { get; }
	public static Color magenta { get; }
	public static Color gray { get; }
	public static Color grey { get; }
	public static Color clear { get; }
	public Color linear { get; }
	public float maxColorComponent { get; }

	// Methods

	// RVA: 0x1A1AC10 Offset: 0x1A19E10 VA: 0x181A1AC10
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x2477710 Offset: 0x2476910 VA: 0x182477710
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x24774B0 Offset: 0x24766B0 VA: 0x1824774B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x24774C0 Offset: 0x24766C0 VA: 0x1824774C0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x99D540 Offset: 0x99C740 VA: 0x18099D540 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2476EE0 Offset: 0x24760E0 VA: 0x182476EE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2476FE0 Offset: 0x24761E0 VA: 0x182476FE0 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x2477A10 Offset: 0x2476C10 VA: 0x182477A10
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x24779C0 Offset: 0x2476BC0 VA: 0x1824779C0
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x24778C0 Offset: 0x2476AC0 VA: 0x1824778C0
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x2477950 Offset: 0x2476B50 VA: 0x182477950
	public static bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x24773C0 Offset: 0x24765C0 VA: 0x1824773C0
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x2477340 Offset: 0x2476540 VA: 0x182477340
	public static Color LerpUnclamped(Color a, Color b, float t) { }

	// RVA: 0x2477460 Offset: 0x2476660 VA: 0x182477460
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x24778A0 Offset: 0x2476AA0 VA: 0x1824778A0
	public static Color get_red() { }

	// RVA: 0x2477770 Offset: 0x2476970 VA: 0x182477770
	public static Color get_green() { }

	// RVA: 0x2477740 Offset: 0x2476940 VA: 0x182477740
	public static Color get_blue() { }

	// RVA: 0x774940 Offset: 0x773B40 VA: 0x180774940
	public static Color get_white() { }

	// RVA: 0x2477730 Offset: 0x2476930 VA: 0x182477730
	public static Color get_black() { }

	// RVA: 0x24778B0 Offset: 0x2476AB0 VA: 0x1824778B0
	public static Color get_yellow() { }

	// RVA: 0x2477750 Offset: 0x2476950 VA: 0x182477750
	public static Color get_cyan() { }

	// RVA: 0x2477870 Offset: 0x2476A70 VA: 0x182477870
	public static Color get_magenta() { }

	// RVA: 0x2477760 Offset: 0x2476960 VA: 0x182477760
	public static Color get_gray() { }

	// RVA: 0x2477760 Offset: 0x2476960 VA: 0x182477760
	public static Color get_grey() { }

	// RVA: 0xB88010 Offset: 0xB87210 VA: 0x180B88010
	public static Color get_clear() { }

	// RVA: 0x2477780 Offset: 0x2476980 VA: 0x182477780
	public Color get_linear() { }

	// RVA: 0x2477880 Offset: 0x2476A80 VA: 0x182477880
	public float get_maxColorComponent() { }

	// RVA: 0x2477930 Offset: 0x2476B30 VA: 0x182477930
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x2477930 Offset: 0x2476B30 VA: 0x182477930
	public static Color op_Implicit(Vector4 v) { }

	// RVA: 0x2477060 Offset: 0x2476260 VA: 0x182477060
	public static Color HSVToRGB(float H, float S, float V) { }

	// RVA: 0x2477090 Offset: 0x2476290 VA: 0x182477090
	public static Color HSVToRGB(float H, float S, float V, bool hdr) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[DefaultMember("Item")]
public struct Color32 : IFormattable // TypeDefIndex: 14080
{
	// Fields
	[Ignore(DoesNotContributeToSize = True)]
	private int rgba; // 0x0
	public byte r; // 0x0
	public byte g; // 0x1
	public byte b; // 0x2
	public byte a; // 0x3

	// Methods

	// RVA: 0x2476820 Offset: 0x2475A20 VA: 0x182476820
	public void .ctor(byte r, byte g, byte b, byte a) { }

	// RVA: 0x5BB230 Offset: 0x5BA430 VA: 0x1805BB230
	public static Color32 op_Implicit(Color c) { }

	// RVA: 0x2476840 Offset: 0x2475A40 VA: 0x182476840
	public static Color op_Implicit(Color32 c) { }

	// RVA: 0x2476810 Offset: 0x2475A10 VA: 0x182476810 Slot: 3
	public override string ToString() { }

	// RVA: 0x24765E0 Offset: 0x24757E0 VA: 0x1824765E0 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Math/ColorUtility.h")]
public class ColorUtility // TypeDefIndex: 14081
{
	// Methods

	// RVA: 0x2476C30 Offset: 0x2475E30 VA: 0x182476C30
	public static string ToHtmlStringRGB(Color color) { }

	// RVA: 0x24768C0 Offset: 0x2475AC0 VA: 0x1824768C0
	public static string ToHtmlStringRGBA(Color color) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
public class Gradient : IEquatable<Gradient> // TypeDefIndex: 14082
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	// RVA: 0x24794B0 Offset: 0x24786B0 VA: 0x1824794B0
	private static IntPtr Init() { }

	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2479180 Offset: 0x2478380 VA: 0x182479180
	private void Cleanup() { }

	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x24794E0 Offset: 0x24786E0 VA: 0x1824794E0
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCode]
	// RVA: 0x2479530 Offset: 0x2478730 VA: 0x182479530
	public void .ctor() { }

	// RVA: 0x2479420 Offset: 0x2478620 VA: 0x182479420 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24791C0 Offset: 0x24783C0 VA: 0x1824791C0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2479360 Offset: 0x2478560 VA: 0x182479360 Slot: 4
	public bool Equals(Gradient other) { }

	// RVA: 0x24794A0 Offset: 0x24786A0 VA: 0x1824794A0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine
[NativeClass("Matrix4x4f")]
[Il2CppEagerStaticClassConstruction]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[DefaultMember("Item")]
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable // TypeDefIndex: 14083
{
	// Fields
	[NativeName("m_Data[0]")]
	public float m00; // 0x0
	[NativeName("m_Data[1]")]
	public float m10; // 0x4
	[NativeName("m_Data[2]")]
	public float m20; // 0x8
	[NativeName("m_Data[3]")]
	public float m30; // 0xC
	[NativeName("m_Data[4]")]
	public float m01; // 0x10
	[NativeName("m_Data[5]")]
	public float m11; // 0x14
	[NativeName("m_Data[6]")]
	public float m21; // 0x18
	[NativeName("m_Data[7]")]
	public float m31; // 0x1C
	[NativeName("m_Data[8]")]
	public float m02; // 0x20
	[NativeName("m_Data[9]")]
	public float m12; // 0x24
	[NativeName("m_Data[10]")]
	public float m22; // 0x28
	[NativeName("m_Data[11]")]
	public float m32; // 0x2C
	[NativeName("m_Data[12]")]
	public float m03; // 0x30
	[NativeName("m_Data[13]")]
	public float m13; // 0x34
	[NativeName("m_Data[14]")]
	public float m23; // 0x38
	[NativeName("m_Data[15]")]
	public float m33; // 0x3C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	// Properties
	public Vector3 lossyScale { get; }
	public Matrix4x4 inverse { get; }
	public static Matrix4x4 identity { get; }

	// Methods

	[ThreadSafe]
	// RVA: 0x247BC20 Offset: 0x247AE20 VA: 0x18247BC20
	private Vector3 GetLossyScale() { }

	// RVA: 0x247CBC0 Offset: 0x247BDC0 VA: 0x18247CBC0
	public Vector3 get_lossyScale() { }

	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = True)]
	// RVA: 0x247C270 Offset: 0x247B470 VA: 0x18247C270
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = True)]
	// RVA: 0x247BDB0 Offset: 0x247AFB0 VA: 0x18247BDB0
	public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) { }

	[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = True)]
	// RVA: 0x247BE50 Offset: 0x247B050 VA: 0x18247BE50
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x247CB10 Offset: 0x247BD10 VA: 0x18247CB10
	public Matrix4x4 get_inverse() { }

	// RVA: 0x247CA40 Offset: 0x247BC40 VA: 0x18247CA40
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x247BA20 Offset: 0x247AC20 VA: 0x18247BA20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x247B790 Offset: 0x247A990 VA: 0x18247B790 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x247B840 Offset: 0x247AA40 VA: 0x18247B840 Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x247CC30 Offset: 0x247BE30 VA: 0x18247CC30
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x247B950 Offset: 0x247AB50 VA: 0x18247B950
	public Vector4 GetColumn(int index) { }

	// RVA: 0x247BC70 Offset: 0x247AE70 VA: 0x18247BC70
	public Vector4 GetRow(int index) { }

	// RVA: 0x247BF50 Offset: 0x247B150 VA: 0x18247BF50
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x247BEB0 Offset: 0x247B0B0 VA: 0x18247BEB0
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x247C050 Offset: 0x247B250 VA: 0x18247C050
	public static Matrix4x4 Rotate(Quaternion q) { }

	// RVA: 0x247CAB0 Offset: 0x247BCB0 VA: 0x18247CAB0
	public static Matrix4x4 get_identity() { }

	// RVA: 0x247C2F0 Offset: 0x247B4F0 VA: 0x18247C2F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x247C300 Offset: 0x247B500 VA: 0x18247C300 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x247C920 Offset: 0x247BB20 VA: 0x18247C920
	private static void .cctor() { }

	// RVA: 0x247BBD0 Offset: 0x247ADD0 VA: 0x18247BBD0
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	// RVA: 0x247C200 Offset: 0x247B400 VA: 0x18247C200
	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x247BD60 Offset: 0x247AF60 VA: 0x18247BD60
	private static bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result) { }

	// RVA: 0x247BE00 Offset: 0x247B000 VA: 0x18247BE00
	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }
}

// Namespace: UnityEngine
[Il2CppEagerStaticClassConstruction]
[DefaultMember("Item")]
[NativeType(Header = "Runtime/Math/Vector3.h")]
[NativeClass("Vector3f")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeHeader("Runtime/Math/Vector3.h")]
public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 14084
{
	// Fields
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Properties
	public float Item { get; set; }
	public Vector3 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector3 zero { get; }
	public static Vector3 one { get; }
	public static Vector3 forward { get; }
	public static Vector3 back { get; }
	public static Vector3 up { get; }
	public static Vector3 down { get; }
	public static Vector3 left { get; }
	public static Vector3 right { get; }

	// Methods

	[FreeFunction("VectorScripting::Slerp", IsThreadSafe = True)]
	// RVA: 0x248ADD0 Offset: 0x2489FD0 VA: 0x18248ADD0
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunction("VectorScripting::OrthoNormalize", IsThreadSafe = True)]
	// RVA: 0x248ACB0 Offset: 0x2489EB0 VA: 0x18248ACB0
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0x248ACB0 Offset: 0x2489EB0 VA: 0x18248ACB0
	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	// RVA: 0x248AB10 Offset: 0x2489D10 VA: 0x18248AB10
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x248AAC0 Offset: 0x2489CC0 VA: 0x18248AAC0
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x23D5B50 Offset: 0x23D4D50 VA: 0x1823D5B50
	public float get_Item(int index) { }

	// RVA: 0x1941AB0 Offset: 0x1940CB0 VA: 0x181941AB0
	public void set_Item(int index, float value) { }

	// RVA: 0x19FE1B0 Offset: 0x19FD3B0 VA: 0x1819FE1B0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x248B1D0 Offset: 0x248A3D0 VA: 0x18248B1D0
	public void .ctor(float x, float y) { }

	// RVA: 0x19FE1B0 Offset: 0x19FD3B0 VA: 0x1819FE1B0
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x248AD00 Offset: 0x2489F00 VA: 0x18248AD00
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x248AD30 Offset: 0x2489F30 VA: 0x18248AD30
	public void Scale(Vector3 scale) { }

	// RVA: 0x248A850 Offset: 0x2489A50 VA: 0x18248A850
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x248AA60 Offset: 0x2489C60 VA: 0x18248AA60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x248A9B0 Offset: 0x2489BB0 VA: 0x18248A9B0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1A2B630 Offset: 0x1A2A830 VA: 0x181A2B630 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x5D0370 Offset: 0x5CF570 VA: 0x1805D0370
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x5D0260 Offset: 0x5CF460 VA: 0x1805D0260
	public void Normalize() { }

	// RVA: 0x248B420 Offset: 0x248A620 VA: 0x18248B420
	public Vector3 get_normalized() { }

	// RVA: 0x248A980 Offset: 0x2489B80 VA: 0x18248A980
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x248A5E0 Offset: 0x24897E0 VA: 0x18248A5E0
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x19D0690 Offset: 0x19CF890 VA: 0x1819D0690
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x248A8B0 Offset: 0x2489AB0 VA: 0x18248A8B0
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x248A750 Offset: 0x2489950 VA: 0x18248A750
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	// RVA: 0x248AB80 Offset: 0x2489D80 VA: 0x18248AB80
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x248B330 Offset: 0x248A530 VA: 0x18248B330
	public float get_magnitude() { }

	// RVA: 0x248B510 Offset: 0x248A710 VA: 0x18248B510
	public float get_sqrMagnitude() { }

	// RVA: 0x248AC70 Offset: 0x2489E70 VA: 0x18248AC70
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x248AC30 Offset: 0x2489E30 VA: 0x18248AC30
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x248B590 Offset: 0x248A790 VA: 0x18248B590
	public static Vector3 get_zero() { }

	// RVA: 0x248B470 Offset: 0x248A670 VA: 0x18248B470
	public static Vector3 get_one() { }

	// RVA: 0x248B290 Offset: 0x248A490 VA: 0x18248B290
	public static Vector3 get_forward() { }

	// RVA: 0x248B1F0 Offset: 0x248A3F0 VA: 0x18248B1F0
	public static Vector3 get_back() { }

	// RVA: 0x248B540 Offset: 0x248A740 VA: 0x18248B540
	public static Vector3 get_up() { }

	// RVA: 0x248B240 Offset: 0x248A440 VA: 0x18248B240
	public static Vector3 get_down() { }

	// RVA: 0x248B2E0 Offset: 0x248A4E0 VA: 0x18248B2E0
	public static Vector3 get_left() { }

	// RVA: 0x248B4C0 Offset: 0x248A6C0 VA: 0x18248B4C0
	public static Vector3 get_right() { }

	// RVA: 0x576F60 Offset: 0x576160 VA: 0x180576F60
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x5614D0 Offset: 0x5606D0 VA: 0x1805614D0
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x248B6E0 Offset: 0x248A8E0 VA: 0x18248B6E0
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x248B6B0 Offset: 0x248A8B0 VA: 0x18248B6B0
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x248B680 Offset: 0x248A880 VA: 0x18248B680
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x576F90 Offset: 0x576190 VA: 0x180576F90
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x248B5E0 Offset: 0x248A7E0 VA: 0x18248B5E0
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x248B620 Offset: 0x248A820 VA: 0x18248B620
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x248AE40 Offset: 0x248A040 VA: 0x18248AE40 Slot: 3
	public override string ToString() { }

	// RVA: 0x248AE50 Offset: 0x248A050 VA: 0x18248AE50 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x248B050 Offset: 0x248A250 VA: 0x18248B050
	private static void .cctor() { }

	// RVA: 0x248AD60 Offset: 0x2489F60 VA: 0x18248AD60
	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }
}

// Namespace: UnityEngine
[DefaultMember("Item")]
[UsedByNativeCode]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Quaternion.h")]
public struct Quaternion : IEquatable<Quaternion>, IFormattable // TypeDefIndex: 14085
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	// Properties
	public static Quaternion identity { get; }
	public Vector3 eulerAngles { get; }

	// Methods

	[FreeFunction("FromToQuaternionSafe", IsThreadSafe = True)]
	// RVA: 0x247F280 Offset: 0x247E480 VA: 0x18247F280
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x247F500 Offset: 0x247E700 VA: 0x18247F500
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = True)]
	// RVA: 0x247F5D0 Offset: 0x247E7D0 VA: 0x18247F5D0
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("EulerToQuaternion", IsThreadSafe = True)]
	// RVA: 0x247F330 Offset: 0x247E530 VA: 0x18247F330
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = True)]
	// RVA: 0x247F460 Offset: 0x247E660 VA: 0x18247F460
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = True)]
	// RVA: 0x247EF70 Offset: 0x247E170 VA: 0x18247EF70
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = True)]
	// RVA: 0x247F760 Offset: 0x247E960 VA: 0x18247F760
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocs]
	// RVA: 0x247F6A0 Offset: 0x247E8A0 VA: 0x18247F6A0
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0x1A1AC10 Offset: 0x1A19E10 VA: 0x181A1AC10
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x247FB70 Offset: 0x247ED70 VA: 0x18247FB70
	public static Quaternion get_identity() { }

	// RVA: 0x247FC80 Offset: 0x247EE80 VA: 0x18247FC80
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x247FD90 Offset: 0x247EF90 VA: 0x18247FD90
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x247F550 Offset: 0x247E750 VA: 0x18247F550
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x247FBC0 Offset: 0x247EDC0 VA: 0x18247FBC0
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x247FC20 Offset: 0x247EE20 VA: 0x18247FC20
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x247EFD0 Offset: 0x247E1D0 VA: 0x18247EFD0
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x247F380 Offset: 0x247E580 VA: 0x18247F380
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x247FA60 Offset: 0x247EC60 VA: 0x18247FA60
	public Vector3 get_eulerAngles() { }

	// RVA: 0x247F1A0 Offset: 0x247E3A0 VA: 0x18247F1A0
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x247F110 Offset: 0x247E310 VA: 0x18247F110
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x99D700 Offset: 0x99C900 VA: 0x18099D700 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x247F010 Offset: 0x247E210 VA: 0x18247F010 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2476FE0 Offset: 0x24761E0 VA: 0x182476FE0 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x247FA10 Offset: 0x247EC10 VA: 0x18247FA10 Slot: 3
	public override string ToString() { }

	// RVA: 0x247F7C0 Offset: 0x247E9C0 VA: 0x18247F7C0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x247FA20 Offset: 0x247EC20 VA: 0x18247FA20
	private static void .cctor() { }

	// RVA: 0x247F220 Offset: 0x247E420 VA: 0x18247F220
	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0x247F4B0 Offset: 0x247E6B0 VA: 0x18247F4B0
	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x247F560 Offset: 0x247E760 VA: 0x18247F560
	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x247F2E0 Offset: 0x247E4E0 VA: 0x18247F2E0
	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0x247F410 Offset: 0x247E610 VA: 0x18247F410
	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x247EF10 Offset: 0x247E110 VA: 0x18247EF10
	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0x247F640 Offset: 0x247E840 VA: 0x18247F640
	private static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Utilities/BitUtility.h")]
[NativeHeader("Runtime/Math/PerlinNoise.h")]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/FloatConversion.h")]
[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
public struct Mathf // TypeDefIndex: 14086
{
	// Fields
	public static readonly float Epsilon; // 0x0

	// Methods

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x247AE10 Offset: 0x247A010 VA: 0x18247AE10
	public static bool IsPowerOfTwo(int value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x247B100 Offset: 0x247A300 VA: 0x18247B100
	public static int NextPowerOfTwo(int value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x247AD10 Offset: 0x2479F10 VA: 0x18247AD10
	public static float GammaToLinearSpace(float value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x247AA60 Offset: 0x2479C60 VA: 0x18247AA60
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	[FreeFunction("PerlinNoise::NoiseNormalized", IsThreadSafe = True)]
	// RVA: 0x247B140 Offset: 0x247A340 VA: 0x18247B140
	public static float PerlinNoise(float x, float y) { }

	// RVA: 0x247B440 Offset: 0x247A640 VA: 0x18247B440
	public static float Sin(float f) { }

	// RVA: 0x247AAB0 Offset: 0x2479CB0 VA: 0x18247AAB0
	public static float Cos(float f) { }

	// RVA: 0x247B6C0 Offset: 0x247A8C0 VA: 0x18247B6C0
	public static float Tan(float f) { }

	// RVA: 0x247A6D0 Offset: 0x24798D0 VA: 0x18247A6D0
	public static float Acos(float f) { }

	// RVA: 0x247A830 Offset: 0x2479A30 VA: 0x18247A830
	public static float Atan(float f) { }

	// RVA: 0x247A7C0 Offset: 0x24799C0 VA: 0x18247A7C0
	public static float Atan2(float y, float x) { }

	// RVA: 0x247B640 Offset: 0x247A840 VA: 0x18247B640
	public static float Sqrt(float f) { }

	// RVA: 0x247A620 Offset: 0x2479820 VA: 0x18247A620
	public static float Abs(float f) { }

	// RVA: 0x247A680 Offset: 0x2479880 VA: 0x18247A680
	public static int Abs(int value) { }

	// RVA: 0x247B020 Offset: 0x247A220 VA: 0x18247B020
	public static float Min(float a, float b) { }

	// RVA: 0x247B040 Offset: 0x247A240 VA: 0x18247B040
	public static float Min(float[] values) { }

	// RVA: 0x247B030 Offset: 0x247A230 VA: 0x18247B030
	public static int Min(int a, int b) { }

	// RVA: 0x247B010 Offset: 0x247A210 VA: 0x18247B010
	public static float Max(float a, float b) { }

	// RVA: 0x247AF90 Offset: 0x247A190 VA: 0x18247AF90
	public static float Max(float[] values) { }

	// RVA: 0x247AF80 Offset: 0x247A180 VA: 0x18247AF80
	public static int Max(int a, int b) { }

	// RVA: 0x247B190 Offset: 0x247A390 VA: 0x18247B190
	public static float Pow(float f, float p) { }

	// RVA: 0x247ABF0 Offset: 0x2479DF0 VA: 0x18247ABF0
	public static float Exp(float power) { }

	// RVA: 0x247AF10 Offset: 0x247A110 VA: 0x18247AF10
	public static float Log(float f, float p) { }

	// RVA: 0x247AEB0 Offset: 0x247A0B0 VA: 0x18247AEB0
	public static float Log10(float f) { }

	// RVA: 0x247A8F0 Offset: 0x2479AF0 VA: 0x18247A8F0
	public static float Ceil(float f) { }

	// RVA: 0x247ACB0 Offset: 0x2479EB0 VA: 0x18247ACB0
	public static float Floor(float f) { }

	// RVA: 0x247B3C0 Offset: 0x247A5C0 VA: 0x18247B3C0
	public static float Round(float f) { }

	// RVA: 0x247A890 Offset: 0x2479A90 VA: 0x18247A890
	public static int CeilToInt(float f) { }

	// RVA: 0x247AC50 Offset: 0x2479E50 VA: 0x18247AC50
	public static int FloorToInt(float f) { }

	// RVA: 0x247B360 Offset: 0x247A560 VA: 0x18247B360
	public static int RoundToInt(float f) { }

	// RVA: 0x247B420 Offset: 0x247A620 VA: 0x18247B420
	public static float Sign(float f) { }

	// RVA: 0x19CE700 Offset: 0x19CD900 VA: 0x1819CE700
	public static float Clamp(float value, float min, float max) { }

	// RVA: 0x247A9F0 Offset: 0x2479BF0 VA: 0x18247A9F0
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x19CE390 Offset: 0x19CD590 VA: 0x1819CE390
	public static float Clamp01(float value) { }

	// RVA: 0x247AE70 Offset: 0x247A070 VA: 0x18247AE70
	public static float Lerp(float a, float b, float t) { }

	// RVA: 0x247AE50 Offset: 0x247A050 VA: 0x18247AE50
	public static float LerpUnclamped(float a, float b, float t) { }

	// RVA: 0x247B0B0 Offset: 0x247A2B0 VA: 0x18247B0B0
	public static float MoveTowards(float current, float target, float maxDelta) { }

	// RVA: 0x247B5E0 Offset: 0x247A7E0 VA: 0x18247B5E0
	public static float SmoothStep(float from, float to, float t) { }

	// RVA: 0x247A730 Offset: 0x2479930 VA: 0x18247A730
	public static bool Approximately(float a, float b) { }

	// RVA: 0x247B4A0 Offset: 0x247A6A0 VA: 0x18247B4A0
	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x247B200 Offset: 0x247A400 VA: 0x18247B200
	public static float Repeat(float t, float length) { }

	// RVA: 0x247ADD0 Offset: 0x2479FD0 VA: 0x18247ADD0
	public static float InverseLerp(float a, float b, float value) { }

	// RVA: 0x247A950 Offset: 0x2479B50 VA: 0x18247A950
	internal static float ClampToFloat(double value) { }

	// RVA: 0x247A9B0 Offset: 0x2479BB0 VA: 0x18247A9B0
	internal static int ClampToInt(long value) { }

	// RVA: 0x247A9D0 Offset: 0x2479BD0 VA: 0x18247A9D0
	internal static uint ClampToUInt(long value) { }

	// RVA: 0x247AD50 Offset: 0x2479F50 VA: 0x18247AD50
	internal static int GetNumberOfDecimalsForMinimumDifference(double minDifference) { }

	// RVA: 0x247B260 Offset: 0x247A460 VA: 0x18247B260
	internal static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference) { }

	// RVA: 0x247AB10 Offset: 0x2479D10 VA: 0x18247AB10
	internal static double DiscardLeastSignificantDecimal(double v) { }

	// RVA: 0x247B720 Offset: 0x247A920 VA: 0x18247B720
	private static void .cctor() { }

	// RVA: 0x247AA10 Offset: 0x2479C10 VA: 0x18247AA10
	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret) { }
}

// Namespace: UnityEngine
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector2f")]
[DefaultMember("Item")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Vector2 : IEquatable<Vector2>, IFormattable // TypeDefIndex: 14087
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	private static readonly Vector2 zeroVector; // 0x0
	private static readonly Vector2 oneVector; // 0x8
	private static readonly Vector2 upVector; // 0x10
	private static readonly Vector2 downVector; // 0x18
	private static readonly Vector2 leftVector; // 0x20
	private static readonly Vector2 rightVector; // 0x28
	private static readonly Vector2 positiveInfinityVector; // 0x30
	private static readonly Vector2 negativeInfinityVector; // 0x38
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;

	// Properties
	public float Item { get; set; }
	public Vector2 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector2 zero { get; }
	public static Vector2 one { get; }
	public static Vector2 up { get; }
	public static Vector2 down { get; }
	public static Vector2 left { get; }
	public static Vector2 right { get; }
	public static Vector2 negativeInfinity { get; }

	// Methods

	// RVA: 0x23D5AD0 Offset: 0x23D4CD0 VA: 0x1823D5AD0
	public float get_Item(int index) { }

	// RVA: 0x2475F10 Offset: 0x2475110 VA: 0x182475F10
	public void set_Item(int index, float value) { }

	// RVA: 0x1A2B2E0 Offset: 0x1A2A4E0 VA: 0x181A2B2E0
	public void .ctor(float x, float y) { }

	// RVA: 0x5A3910 Offset: 0x5A2B10 VA: 0x1805A3910
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x2489790 Offset: 0x2488990 VA: 0x182489790
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x84A610 Offset: 0x849810 VA: 0x18084A610
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x54CF20 Offset: 0x54C120 VA: 0x18054CF20
	public void Normalize() { }

	// RVA: 0x54D060 Offset: 0x54C260 VA: 0x18054D060
	public Vector2 get_normalized() { }

	// RVA: 0x24898A0 Offset: 0x2488AA0 VA: 0x1824898A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2489890 Offset: 0x2488A90 VA: 0x182489890
	public string ToString(string format) { }

	// RVA: 0x24898B0 Offset: 0x2488AB0 VA: 0x1824898B0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2489750 Offset: 0x2488950 VA: 0x182489750 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24896B0 Offset: 0x24888B0 VA: 0x1824896B0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1A2AE80 Offset: 0x1A2A080 VA: 0x181A2AE80 Slot: 4
	public bool Equals(Vector2 other) { }

	// RVA: 0x2489860 Offset: 0x2488A60 VA: 0x182489860
	public static Vector2 Perpendicular(Vector2 inDirection) { }

	// RVA: 0x2489680 Offset: 0x2488880 VA: 0x182489680
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2489BF0 Offset: 0x2488DF0 VA: 0x182489BF0
	public float get_magnitude() { }

	// RVA: 0x2489D90 Offset: 0x2488F90 VA: 0x182489D90
	public float get_sqrMagnitude() { }

	// RVA: 0x2489370 Offset: 0x2488570 VA: 0x182489370
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x62A660 Offset: 0x629860 VA: 0x18062A660
	public static float SignedAngle(Vector2 from, Vector2 to) { }

	// RVA: 0x24895D0 Offset: 0x24887D0 VA: 0x1824895D0
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x24894D0 Offset: 0x24886D0 VA: 0x1824894D0
	public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) { }

	// RVA: 0x2489820 Offset: 0x2488A20 VA: 0x182489820
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x24897E0 Offset: 0x24889E0 VA: 0x1824897E0
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1A2AE40 Offset: 0x1A2A040 VA: 0x181A2AE40
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x1A2B240 Offset: 0x1A2A440 VA: 0x181A2B240
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x84A610 Offset: 0x849810 VA: 0x18084A610
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x849FB0 Offset: 0x8491B0 VA: 0x180849FB0
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x2489F20 Offset: 0x2489120 VA: 0x182489F20
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x1A2B3D0 Offset: 0x1A2A5D0 VA: 0x181A2B3D0
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x2489EF0 Offset: 0x24890F0 VA: 0x182489EF0
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x1A2B3A0 Offset: 0x1A2A5A0 VA: 0x181A2B3A0
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x2489E50 Offset: 0x2489050 VA: 0x182489E50
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2489EA0 Offset: 0x24890A0 VA: 0x182489EA0
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x246ECF0 Offset: 0x246DEF0 VA: 0x18246ECF0
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x533FD0 Offset: 0x5331D0 VA: 0x180533FD0
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x2489E00 Offset: 0x2489000 VA: 0x182489E00
	public static Vector2 get_zero() { }

	// RVA: 0x2489CF0 Offset: 0x2488EF0 VA: 0x182489CF0
	public static Vector2 get_one() { }

	// RVA: 0x2489DB0 Offset: 0x2488FB0 VA: 0x182489DB0
	public static Vector2 get_up() { }

	// RVA: 0x2489B50 Offset: 0x2488D50 VA: 0x182489B50
	public static Vector2 get_down() { }

	// RVA: 0x2489BA0 Offset: 0x2488DA0 VA: 0x182489BA0
	public static Vector2 get_left() { }

	// RVA: 0x2489D40 Offset: 0x2488F40 VA: 0x182489D40
	public static Vector2 get_right() { }

	// RVA: 0x2489CA0 Offset: 0x2488EA0 VA: 0x182489CA0
	public static Vector2 get_negativeInfinity() { }

	// RVA: 0x2489A60 Offset: 0x2488C60 VA: 0x182489A60
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeType("Runtime/Math/Vector2Int.h")]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[UsedByNativeCode]
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable // TypeDefIndex: 14088
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private static readonly Vector2Int s_Zero; // 0x0
	private static readonly Vector2Int s_One; // 0x8
	private static readonly Vector2Int s_Up; // 0x10
	private static readonly Vector2Int s_Down; // 0x18
	private static readonly Vector2Int s_Left; // 0x20
	private static readonly Vector2Int s_Right; // 0x28

	// Properties
	public int x { get; set; }
	public int y { get; set; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public int get_x() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_x(int value) { }

	// RVA: 0xC45280 Offset: 0xC44480 VA: 0x180C45280
	public int get_y() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_y(int value) { }

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void .ctor(int x, int y) { }

	// RVA: 0x2489350 Offset: 0x2488550 VA: 0x182489350
	public static Vector2 op_Implicit(Vector2Int v) { }

	// RVA: 0x2488F90 Offset: 0x2488190 VA: 0x182488F90
	public static Vector2Int FloorToInt(Vector2 v) { }

	// RVA: 0x2489330 Offset: 0x2488530 VA: 0x182489330
	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x2488EE0 Offset: 0x24880E0 VA: 0x182488EE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2488EC0 Offset: 0x24880C0 VA: 0x182488EC0 Slot: 4
	public bool Equals(Vector2Int other) { }

	// RVA: 0x2489050 Offset: 0x2488250 VA: 0x182489050 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2489230 Offset: 0x2488430 VA: 0x182489230 Slot: 3
	public override string ToString() { }

	// RVA: 0x24890A0 Offset: 0x24882A0 VA: 0x1824890A0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2489240 Offset: 0x2488440 VA: 0x182489240
	private static void .cctor() { }
}

// Namespace: UnityEngine
[DefaultMember("Item")]
[UsedByNativeCode]
[Il2CppEagerStaticClassConstruction]
public struct Vector3Int : IEquatable<Vector3Int>, IFormattable // TypeDefIndex: 14089
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private int m_Z; // 0x8
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C
	private static readonly Vector3Int s_Forward; // 0x48
	private static readonly Vector3Int s_Back; // 0x54

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int z { get; set; }
	public static Vector3Int zero { get; }
	public static Vector3Int up { get; }
	public static Vector3Int down { get; }
	public static Vector3Int left { get; }
	public static Vector3Int right { get; }

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
	public int get_z() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_z(int value) { }

	// RVA: 0xD45600 Offset: 0xD44800 VA: 0x180D45600
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x248A5B0 Offset: 0x24897B0 VA: 0x18248A5B0
	public static Vector3 op_Implicit(Vector3Int v) { }

	// RVA: 0x248A550 Offset: 0x2489750 VA: 0x18248A550
	public static Vector3Int op_Addition(Vector3Int a, Vector3Int b) { }

	// RVA: 0x248A590 Offset: 0x2489790 VA: 0x18248A590
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x2489F50 Offset: 0x2489150 VA: 0x182489F50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x248A020 Offset: 0x2489220 VA: 0x18248A020 Slot: 4
	public bool Equals(Vector3Int other) { }

	// RVA: 0xB704C0 Offset: 0xB6F6C0 VA: 0x180B704C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x248A070 Offset: 0x2489270 VA: 0x18248A070 Slot: 3
	public override string ToString() { }

	// RVA: 0x248A080 Offset: 0x2489280 VA: 0x18248A080 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x248A500 Offset: 0x2489700 VA: 0x18248A500
	public static Vector3Int get_zero() { }

	// RVA: 0x248A4B0 Offset: 0x24896B0 VA: 0x18248A4B0
	public static Vector3Int get_up() { }

	// RVA: 0x248A3C0 Offset: 0x24895C0 VA: 0x18248A3C0
	public static Vector3Int get_down() { }

	// RVA: 0x248A410 Offset: 0x2489610 VA: 0x18248A410
	public static Vector3Int get_left() { }

	// RVA: 0x248A460 Offset: 0x2489660 VA: 0x18248A460
	public static Vector3Int get_right() { }

	// RVA: 0x248A270 Offset: 0x2489470 VA: 0x18248A270
	private static void .cctor() { }
}

// Namespace: UnityEngine
[Il2CppEagerStaticClassConstruction]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Math/Vector4.h")]
[DefaultMember("Item")]
[NativeClass("Vector4f")]
public struct Vector4 : IEquatable<Vector4>, IFormattable // TypeDefIndex: 14090
{
	// Fields
	public const float kEpsilon = 1E-05;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Properties
	public float Item { get; set; }
	public float sqrMagnitude { get; }
	public static Vector4 zero { get; }

	// Methods

	// RVA: 0x244AE50 Offset: 0x244A050 VA: 0x18244AE50
	public float get_Item(int index) { }

	// RVA: 0x842C10 Offset: 0x841E10 VA: 0x180842C10
	public void set_Item(int index, float value) { }

	// RVA: 0x1A1AC10 Offset: 0x1A19E10 VA: 0x181A1AC10
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x99D700 Offset: 0x99C900 VA: 0x18099D700 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x248B710 Offset: 0x248A910 VA: 0x18248B710 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1996670 Offset: 0x1995870 VA: 0x181996670 Slot: 4
	public bool Equals(Vector4 other) { }

	// RVA: 0x247EFD0 Offset: 0x247E1D0 VA: 0x18247EFD0
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x248BAC0 Offset: 0x248ACC0 VA: 0x18248BAC0
	public float get_sqrMagnitude() { }

	// RVA: 0x248BB10 Offset: 0x248AD10 VA: 0x18248BB10
	public static Vector4 get_zero() { }

	// RVA: 0x24779C0 Offset: 0x2476BC0 VA: 0x1824779C0
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x248BB60 Offset: 0x248AD60 VA: 0x18248BB60
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x248BB80 Offset: 0x248AD80 VA: 0x18248BB80
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x248BC90 Offset: 0x248AE90 VA: 0x18248BC90
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x248BC00 Offset: 0x248AE00 VA: 0x18248BC00
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x248BBE0 Offset: 0x248ADE0 VA: 0x18248BBE0
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x248BC50 Offset: 0x248AE50 VA: 0x18248BC50
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x246ECF0 Offset: 0x246DEF0 VA: 0x18246ECF0
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x248BA20 Offset: 0x248AC20 VA: 0x18248BA20 Slot: 3
	public override string ToString() { }

	// RVA: 0x248B7D0 Offset: 0x248A9D0 VA: 0x18248B7D0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x248BA30 Offset: 0x248AC30 VA: 0x18248BA30
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal struct TypeDispatchData : IDisposable // TypeDefIndex: 14091
{
	// Fields
	public Object[] changed; // 0x0
	public NativeArray<int> changedID; // 0x8
	public NativeArray<int> destroyedID; // 0x18

	// Methods

	// RVA: 0x2488830 Offset: 0x2487A30 VA: 0x182488830 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine
internal struct TransformDispatchData : IDisposable // TypeDefIndex: 14092
{
	// Fields
	public NativeArray<int> transformedID; // 0x0
	public NativeArray<int> parentID; // 0x10
	public NativeArray<Matrix4x4> localToWorldMatrices; // 0x20
	public NativeArray<Vector3> positions; // 0x30
	public NativeArray<Quaternion> rotations; // 0x40
	public NativeArray<Vector3> scales; // 0x50

	// Methods

	// RVA: 0x2488780 Offset: 0x2487980 VA: 0x182488780 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ObjectDispatcher.<>c // TypeDefIndex: 14093
{
	// Fields
	public static readonly ObjectDispatcher.<>c <>9; // 0x0

	// Methods

	// RVA: 0x2488BD0 Offset: 0x2487DD0 VA: 0x182488BD0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2488890 Offset: 0x2487A90 VA: 0x182488890
	internal void <.cctor>b__54_0(Object[] changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, Action<TypeDispatchData> callback) { }

	// RVA: 0x2488990 Offset: 0x2487B90 VA: 0x182488990
	internal void <.cctor>b__54_1(IntPtr transformed, IntPtr parents, IntPtr localToWorldMatrices, IntPtr positions, IntPtr rotations, IntPtr scales, int count, Action<TransformDispatchData> callback) { }
}

// Namespace: UnityEngine
[StaticAccessor("GetObjectDispatcher()", 0)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Misc/ObjectDispatcher.h")]
internal sealed class ObjectDispatcher // TypeDefIndex: 14094
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private static Action<Object[], IntPtr, IntPtr, int, int, Action<TypeDispatchData>> s_TypeDispatch; // 0x0
	private static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>> s_TransformDispatch; // 0x8

	// Methods

	// RVA: 0x247E250 Offset: 0x247D450 VA: 0x18247E250
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Networking/Ping.bindings.h")]
public sealed class Ping // TypeDefIndex: 14095
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public bool isDone { get; }
	public int time { get; }

	// Methods

	// RVA: 0x247E530 Offset: 0x247D730 VA: 0x18247E530
	public void .ctor(string address) { }

	// RVA: 0x247E3D0 Offset: 0x247D5D0 VA: 0x18247E3D0 Slot: 1
	protected override void Finalize() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x247E370 Offset: 0x247D570 VA: 0x18247E370
	public void DestroyPing() { }

	[FreeFunction("DestroyPing", IsThreadSafe = True)]
	// RVA: 0x247E4B0 Offset: 0x247D6B0 VA: 0x18247E4B0
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("CreatePing")]
	// RVA: 0x247E470 Offset: 0x247D670 VA: 0x18247E470
	private static IntPtr Internal_Create(string address) { }

	// RVA: 0x247E580 Offset: 0x247D780 VA: 0x18247E580
	public bool get_isDone() { }

	[NativeName("GetIsDone")]
	// RVA: 0x247E4F0 Offset: 0x247D6F0 VA: 0x18247E4F0
	private bool Internal_IsDone() { }

	// RVA: 0x247E5D0 Offset: 0x247D7D0 VA: 0x18247E5D0
	public int get_time() { }
}

// Namespace: UnityEngine
[MovedFrom("UnityEditor")]
internal class NumericFieldDraggerUtility // TypeDefIndex: 14096
{
	// Fields
	private static bool s_UseYSign; // 0x0

	// Methods

	// RVA: 0x247DDD0 Offset: 0x247CFD0 VA: 0x18247DDD0
	internal static float Acceleration(bool shiftPressed, bool altPressed) { }

	// RVA: 0x247E140 Offset: 0x247D340 VA: 0x18247E140
	internal static float NiceDelta(Vector2 deviceDelta, float acceleration) { }

	// RVA: 0x247DED0 Offset: 0x247D0D0 VA: 0x18247DED0
	internal static double CalculateFloatDragSensitivity(double value) { }

	// RVA: 0x247DE10 Offset: 0x247D010 VA: 0x18247DE10
	internal static double CalculateFloatDragSensitivity(double value, double minValue, double maxValue) { }

	// RVA: 0x247DF90 Offset: 0x247D190 VA: 0x18247DF90
	internal static long CalculateIntDragSensitivity(long value) { }

	// RVA: 0x247E040 Offset: 0x247D240 VA: 0x18247E040
	internal static ulong CalculateIntDragSensitivity(ulong value) { }

	// RVA: 0x247E0C0 Offset: 0x247D2C0 VA: 0x18247E0C0
	private static double CalculateIntDragSensitivity(double value) { }

	// RVA: 0x247DFB0 Offset: 0x247D1B0 VA: 0x18247DFB0
	internal static long CalculateIntDragSensitivity(long value, long minValue, long maxValue) { }
}

// Namespace: UnityEngine
internal interface IPlayerEditorConnectionNative // TypeDefIndex: 14097
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DisconnectAll();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SendMessage(Guid messageId, byte[] data, int playerId);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TrySendMessage(Guid messageId, byte[] data, int playerId);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Poll();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RegisterInternal(Guid messageId);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UnregisterInternal(Guid messageId);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsConnected();
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 14098
{
	// Methods

	// RVA: 0x247E840 Offset: 0x247DA40 VA: 0x18247E840 Slot: 6
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x247E950 Offset: 0x247DB50 VA: 0x18247E950 Slot: 7
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x247E6A0 Offset: 0x247D8A0 VA: 0x18247E6A0 Slot: 8
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x247E7D0 Offset: 0x247D9D0 VA: 0x18247E7D0 Slot: 9
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x247EA60 Offset: 0x247DC60 VA: 0x18247EA60 Slot: 10
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x247E640 Offset: 0x247D840 VA: 0x18247E640 Slot: 4
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x247E670 Offset: 0x247D870 VA: 0x18247E670 Slot: 11
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x247E610 Offset: 0x247D810 VA: 0x18247E610 Slot: 5
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunction("PlayerConnection_Bindings::IsConnected")]
	// RVA: 0x247E670 Offset: 0x247D870 VA: 0x18247E670
	private static bool IsConnected() { }

	[FreeFunction("PlayerConnection_Bindings::Initialize")]
	// RVA: 0x247E640 Offset: 0x247D840 VA: 0x18247E640
	private static void Initialize() { }

	[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
	// RVA: 0x247E6D0 Offset: 0x247D8D0 VA: 0x18247E6D0
	private static void RegisterInternal(string messageId) { }

	[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
	// RVA: 0x247EAD0 Offset: 0x247DCD0 VA: 0x18247EAD0
	private static void UnregisterInternal(string messageId) { }

	[FreeFunction("PlayerConnection_Bindings::SendMessage")]
	// RVA: 0x247E710 Offset: 0x247D910 VA: 0x18247E710
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
	// RVA: 0x247E770 Offset: 0x247D970 VA: 0x18247E770
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunction("PlayerConnection_Bindings::PollInternal")]
	// RVA: 0x247E6A0 Offset: 0x247D8A0 VA: 0x18247E6A0
	private static void PollInternal() { }

	[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
	// RVA: 0x247E610 Offset: 0x247D810 VA: 0x18247E610
	private static void DisconnectAll() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
public class PlayerPrefsException : Exception // TypeDefIndex: 14099
{
	// Methods

	// RVA: 0x247EB10 Offset: 0x247DD10 VA: 0x18247EB10
	public void .ctor(string error) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
public class PlayerPrefs // TypeDefIndex: 14100
{
	// Methods

	[NativeMethod("SetInt")]
	// RVA: 0x247EE80 Offset: 0x247E080 VA: 0x18247EE80
	private static bool TrySetInt(string key, int value) { }

	[NativeMethod("SetString")]
	// RVA: 0x247EEC0 Offset: 0x247E0C0 VA: 0x18247EEC0
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x247ED60 Offset: 0x247DF60 VA: 0x18247ED60
	public static void SetInt(string key, int value) { }

	// RVA: 0x247EBF0 Offset: 0x247DDF0 VA: 0x18247EBF0
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x247EBB0 Offset: 0x247DDB0 VA: 0x18247EBB0
	public static int GetInt(string key) { }

	// RVA: 0x247EDF0 Offset: 0x247DFF0 VA: 0x18247EDF0
	public static void SetString(string key, string value) { }

	// RVA: 0x247ECA0 Offset: 0x247DEA0 VA: 0x18247ECA0
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x247EC30 Offset: 0x247DE30 VA: 0x18247EC30
	public static string GetString(string key) { }

	// RVA: 0x247ECF0 Offset: 0x247DEF0 VA: 0x18247ECF0
	public static bool HasKey(string key) { }

	// RVA: 0x247EB70 Offset: 0x247DD70 VA: 0x18247EB70
	public static void DeleteKey(string key) { }

	[NativeMethod("Sync")]
	// RVA: 0x247ED30 Offset: 0x247DF30 VA: 0x18247ED30
	public static void Save() { }
}

// Namespace: UnityEngine
[Usage(256, Inherited = True, AllowMultiple = False)]
[UsedByNativeCode]
public abstract class PropertyAttribute : Attribute // TypeDefIndex: 14101
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[Usage(256, Inherited = True, AllowMultiple = False)]
public class InspectorNameAttribute : PropertyAttribute // TypeDefIndex: 14102
{
	// Fields
	public readonly string displayName; // 0x10
}

// Namespace: UnityEngine
[Usage(32767, Inherited = True, AllowMultiple = False)]
public class TooltipAttribute : PropertyAttribute // TypeDefIndex: 14103
{
	// Fields
	public readonly string tooltip; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string tooltip) { }
}

// Namespace: UnityEngine
[Usage(256, Inherited = True, AllowMultiple = True)]
public class SpaceAttribute : PropertyAttribute // TypeDefIndex: 14104
{
	// Fields
	public readonly float height; // 0x10

	// Methods

	// RVA: 0x2482DD0 Offset: 0x2481FD0 VA: 0x182482DD0
	public void .ctor() { }

	// RVA: 0x247DDA0 Offset: 0x247CFA0 VA: 0x18247DDA0
	public void .ctor(float height) { }
}

// Namespace: UnityEngine
[Usage(256, Inherited = True, AllowMultiple = True)]
public class HeaderAttribute : PropertyAttribute // TypeDefIndex: 14105
{
	// Fields
	public readonly string header; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string header) { }
}

// Namespace: UnityEngine
[Usage(256, Inherited = True, AllowMultiple = False)]
public sealed class RangeAttribute : PropertyAttribute // TypeDefIndex: 14106
{
	// Fields
	public readonly float min; // 0x10
	public readonly float max; // 0x14

	// Methods

	// RVA: 0x247FF00 Offset: 0x247F100 VA: 0x18247FF00
	public void .ctor(float min, float max) { }
}

// Namespace: UnityEngine
[Usage(256, Inherited = True, AllowMultiple = False)]
public sealed class MinAttribute : PropertyAttribute // TypeDefIndex: 14107
{
	// Fields
	public readonly float min; // 0x10

	// Methods

	// RVA: 0x247DDA0 Offset: 0x247CFA0 VA: 0x18247DDA0
	public void .ctor(float min) { }
}

// Namespace: UnityEngine
[Usage(256, Inherited = True, AllowMultiple = False)]
public sealed class MultilineAttribute : PropertyAttribute // TypeDefIndex: 14108
{
	// Fields
	public readonly int lines; // 0x10

	// Methods

	// RVA: 0x2494810 Offset: 0x2493A10 VA: 0x182494810
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(256, Inherited = True, AllowMultiple = False)]
public sealed class TextAreaAttribute : PropertyAttribute // TypeDefIndex: 14109
{
	// Fields
	public readonly int minLines; // 0x10
	public readonly int maxLines; // 0x14

	// Methods

	// RVA: 0x24A2470 Offset: 0x24A1670 VA: 0x1824A2470
	public void .ctor(int minLines, int maxLines) { }
}

// Namespace: UnityEngine
[Usage(256, Inherited = True, AllowMultiple = False)]
public sealed class ColorUsageAttribute : PropertyAttribute // TypeDefIndex: 14110
{
	// Fields
	public readonly bool showAlpha; // 0x10
	public readonly bool hdr; // 0x11
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minBrightness; // 0x14
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxBrightness; // 0x18
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minExposureValue; // 0x1C
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxExposureValue; // 0x20

	// Methods

	// RVA: 0x248DCF0 Offset: 0x248CEF0 VA: 0x18248DCF0
	public void .ctor(bool showAlpha) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Utilities/PropertyName.h")]
internal class PropertyNameUtils // TypeDefIndex: 14111
{
	// Methods

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2499180 Offset: 0x2498380 VA: 0x182499180
	public static PropertyName PropertyNameFromString(string name) { }

	// RVA: 0x2499130 Offset: 0x2498330 VA: 0x182499130
	private static void PropertyNameFromString_Injected(string name, out PropertyName ret) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct PropertyName : IEquatable<PropertyName> // TypeDefIndex: 14112
{
	// Fields
	internal int id; // 0x0

	// Methods

	// RVA: 0x24992D0 Offset: 0x24984D0 VA: 0x1824992D0
	public void .ctor(string name) { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void .ctor(PropertyName other) { }

	// RVA: 0x2499260 Offset: 0x2498460 VA: 0x182499260
	public static bool IsNullOrEmpty(PropertyName prop) { }

	// RVA: 0x2499330 Offset: 0x2498530 VA: 0x182499330
	public static bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24991D0 Offset: 0x24983D0 VA: 0x1824991D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x244E010 Offset: 0x244D210 VA: 0x18244E010 Slot: 4
	public bool Equals(PropertyName other) { }

	// RVA: 0x2499180 Offset: 0x2498380 VA: 0x182499180
	public static PropertyName op_Implicit(string name) { }

	// RVA: 0x2499270 Offset: 0x2498470 VA: 0x182499270 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
public static class Random // TypeDefIndex: 14113
{
	// Properties
	public static float value { get; }
	public static Vector2 insideUnitCircle { get; }

	// Methods

	[FreeFunction]
	// RVA: 0x24993C0 Offset: 0x24985C0 VA: 0x1824993C0
	public static float Range(float minInclusive, float maxInclusive) { }

	// RVA: 0x2499380 Offset: 0x2498580 VA: 0x182499380
	public static int Range(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	// RVA: 0x2499380 Offset: 0x2498580 VA: 0x182499380
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	// RVA: 0x2499450 Offset: 0x2498650 VA: 0x182499450
	public static float get_value() { }

	[FreeFunction]
	// RVA: 0x2499340 Offset: 0x2498540 VA: 0x182499340
	private static void GetRandomUnitCircle(out Vector2 output) { }

	// RVA: 0x2499410 Offset: 0x2498610 VA: 0x182499410
	public static Vector2 get_insideUnitCircle() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public class ResourceRequest : AsyncOperation // TypeDefIndex: 14114
{
	// Fields
	internal string m_Path; // 0x20
	internal Type m_Type; // 0x28

	// Properties
	public Object asset { get; }

	// Methods

	// RVA: 0x249B9F0 Offset: 0x249ABF0 VA: 0x18249B9F0 Slot: 4
	protected virtual Object GetResult() { }

	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170
	public Object get_asset() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
internal static class ResourcesAPIInternal // TypeDefIndex: 14115
{
	// Methods

	[TypeInferenceRule(2)]
	[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
	// RVA: 0x249BA10 Offset: 0x249AC10 VA: 0x18249BA10
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[FreeFunction("GetShaderNameRegistry().FindShader")]
	// RVA: 0x249BA50 Offset: 0x249AC50 VA: 0x18249BA50
	public static Shader FindShaderByName(string name) { }

	[NativeThrows]
	[TypeInferenceRule(1)]
	[FreeFunction("Resources_Bindings::Load")]
	// RVA: 0x249BB30 Offset: 0x249AD30 VA: 0x18249BB30
	public static Object Load(string path, Type systemTypeInstance) { }

	[FreeFunction("Resources_Bindings::LoadAll")]
	[NativeThrows]
	// RVA: 0x249BA90 Offset: 0x249AC90 VA: 0x18249BA90
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	[FreeFunction("Resources_Bindings::LoadAsyncInternal")]
	// RVA: 0x249BAE0 Offset: 0x249ACE0 VA: 0x18249BAE0
	internal static ResourceRequest LoadAsyncInternal(string path, Type type) { }

	[FreeFunction("Scripting::UnloadAssetFromScripting")]
	// RVA: 0x249BB80 Offset: 0x249AD80 VA: 0x18249BB80
	public static void UnloadAsset(Object assetToUnload) { }
}

// Namespace: UnityEngine
public class ResourcesAPI // TypeDefIndex: 14116
{
	// Fields
	private static ResourcesAPI s_DefaultAPI; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static ResourcesAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static ResourcesAPI ActiveAPI { get; }
	public static ResourcesAPI overrideAPI { get; }

	// Methods

	// RVA: 0x249BDE0 Offset: 0x249AFE0 VA: 0x18249BDE0
	internal static ResourcesAPI get_ActiveAPI() { }

	[CompilerGenerated]
	// RVA: 0x249BE90 Offset: 0x249B090 VA: 0x18249BE90
	public static ResourcesAPI get_overrideAPI() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected internal void .ctor() { }

	// RVA: 0x249BBC0 Offset: 0x249ADC0 VA: 0x18249BBC0 Slot: 4
	protected internal virtual Object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	// RVA: 0x249BC00 Offset: 0x249AE00 VA: 0x18249BC00 Slot: 5
	protected internal virtual Shader FindShaderByName(string name) { }

	// RVA: 0x249BCF0 Offset: 0x249AEF0 VA: 0x18249BCF0 Slot: 6
	protected internal virtual Object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x249BC40 Offset: 0x249AE40 VA: 0x18249BC40 Slot: 7
	protected internal virtual Object[] LoadAll(string path, Type systemTypeInstance) { }

	// RVA: 0x249BC90 Offset: 0x249AE90 VA: 0x18249BC90 Slot: 8
	protected internal virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance) { }

	// RVA: 0x249BD40 Offset: 0x249AF40 VA: 0x18249BD40 Slot: 9
	protected internal virtual void UnloadAsset(Object assetToUnload) { }

	// RVA: 0x249BD80 Offset: 0x249AF80 VA: 0x18249BD80
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
public sealed class Resources // TypeDefIndex: 14117
{
	// Methods

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x98D8E0 Offset: 0x98CAE0 VA: 0x18098D8E0
	|-Resources.ConvertObjects<object>
	*/

	// RVA: 0x2495510 Offset: 0x2494710 VA: 0x182495510
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x249C0B0 Offset: 0x249B2B0 VA: 0x18249C0B0
	public static Object Load(string path) { }

	// RVA: -1 Offset: -1
	public static T Load<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA696F0 Offset: 0xA688F0 VA: 0x180A696F0
	|-Resources.Load<object>
	*/

	// RVA: 0x249C030 Offset: 0x249B230 VA: 0x18249C030
	public static Object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x249BFB0 Offset: 0x249B1B0 VA: 0x18249BFB0
	public static ResourceRequest LoadAsync(string path, Type type) { }

	// RVA: 0x249BF30 Offset: 0x249B130 VA: 0x18249BF30
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	// RVA: -1 Offset: -1
	public static T[] LoadAll<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA69580 Offset: 0xA68780 VA: 0x180A69580
	|-Resources.LoadAll<object>
	*/

	[TypeInferenceRule(0)]
	[FreeFunction("GetScriptingBuiltinResource", ThrowsException = True)]
	// RVA: 0x249BEE0 Offset: 0x249B0E0 VA: 0x18249BEE0
	public static Object GetBuiltinResource(Type type, string path) { }

	// RVA: -1 Offset: -1
	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA694C0 Offset: 0xA686C0 VA: 0x180A694C0
	|-Resources.GetBuiltinResource<object>
	*/

	// RVA: 0x249C130 Offset: 0x249B330 VA: 0x18249C130
	public static void UnloadAsset(Object assetToUnload) { }

	[FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
	// RVA: 0x249C1A0 Offset: 0x249B3A0 VA: 0x18249C1A0
	public static AsyncOperation UnloadUnusedAssets() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/GameCode/AsyncInstantiate/AsyncInstantiateOperation.h")]
public class AsyncInstantiateOperation : AsyncOperation // TypeDefIndex: 14118
{
	// Fields
	internal Object[] m_Result; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[ExcludeFromDocs]
public class AsyncInstantiateOperation<T> : CustomYieldInstruction // TypeDefIndex: 14119
{
	// Fields
	internal AsyncInstantiateOperation m_op; // 0x0

	// Properties
	public override bool keepWaiting { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(AsyncInstantiateOperation op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	|-AsyncInstantiateOperation<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override bool get_keepWaiting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE52C50 Offset: 0xE51E50 VA: 0x180E52C50
	|-AsyncInstantiateOperation<object>.get_keepWaiting
	*/
}

// Namespace: UnityEngine
[RequiredByNativeCode]
internal class AsyncInstantiateOperationHelper // TypeDefIndex: 14120
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x248C930 Offset: 0x248BB30 VA: 0x18248C930
	public static void SetAsyncInstantiateOperationResult(AsyncInstantiateOperation op, Object[] result) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
[NativeHeader("Runtime/Misc/AsyncOperation.h")]
[RequiredByNativeCode]
public class AsyncOperation : YieldInstruction // TypeDefIndex: 14121
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public float progress { get; }
	public int priority { set; }
	public bool allowSceneActivation { get; set; }

	// Methods

	[StaticAccessor("AsyncOperationBindings", 2)]
	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x248C9D0 Offset: 0x248BBD0 VA: 0x18248C9D0
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethod("IsDone")]
	// RVA: 0x248CB90 Offset: 0x248BD90 VA: 0x18248CB90
	public bool get_isDone() { }

	[NativeMethod("GetProgress")]
	// RVA: 0x248CBD0 Offset: 0x248BDD0 VA: 0x18248CBD0
	public float get_progress() { }

	[NativeMethod("SetPriority")]
	// RVA: 0x248CD10 Offset: 0x248BF10 VA: 0x18248CD10
	public void set_priority(int value) { }

	[NativeMethod("GetAllowSceneActivation")]
	// RVA: 0x248CB50 Offset: 0x248BD50 VA: 0x18248CB50
	public bool get_allowSceneActivation() { }

	[NativeMethod("SetAllowSceneActivation")]
	// RVA: 0x248CCC0 Offset: 0x248BEC0 VA: 0x18248CCC0
	public void set_allowSceneActivation(bool value) { }

	// RVA: 0x248C950 Offset: 0x248BB50 VA: 0x18248C950 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCode]
	// RVA: 0x248CA10 Offset: 0x248BC10 VA: 0x18248CA10
	internal void InvokeCompletionEvent() { }

	// RVA: 0x248CA50 Offset: 0x248BC50 VA: 0x18248CA50
	public void add_completed(Action<AsyncOperation> value) { }

	// RVA: 0x248CC10 Offset: 0x248BE10 VA: 0x18248CC10
	public void remove_completed(Action<AsyncOperation> value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
internal class AttributeHelperEngine // TypeDefIndex: 14122
{
	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x248D0D0 Offset: 0x248C2D0 VA: 0x18248D0D0
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCode]
	// RVA: 0x248D210 Offset: 0x248C410 VA: 0x18248D210
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x248CFC0 Offset: 0x248C1C0 VA: 0x18248CFC0
	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCode]
	// RVA: 0x248CD50 Offset: 0x248BF50 VA: 0x18248CD50
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCode]
	// RVA: 0x248CF50 Offset: 0x248C150 VA: 0x18248CF50
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1 Offset: -1
	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9440C0 Offset: 0x9432C0 VA: 0x1809440C0
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	*/

	// RVA: 0x248D670 Offset: 0x248C870 VA: 0x18248D670
	private static void .cctor() { }
}

// Namespace: UnityEngine
[Usage(4, Inherited = False)]
[RequiredByNativeCode]
public sealed class DisallowMultipleComponent : Attribute // TypeDefIndex: 14123
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(4, AllowMultiple = True)]
public sealed class RequireComponent : Attribute // TypeDefIndex: 14124
{
	// Fields
	public Type m_Type0; // 0x10
	public Type m_Type1; // 0x18
	public Type m_Type2; // 0x20

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type requiredComponent) { }
}

// Namespace: UnityEngine
public sealed class AddComponentMenu : Attribute // TypeDefIndex: 14125
{
	// Fields
	private string m_AddComponentMenu; // 0x10
	private int m_Ordering; // 0x18

	// Methods

	// RVA: 0x248C190 Offset: 0x248B390 VA: 0x18248C190
	public void .ctor(string menuName) { }

	// RVA: 0x16774B0 Offset: 0x16766B0 VA: 0x1816774B0
	public void .ctor(string menuName, int order) { }
}

// Namespace: UnityEngine
[Usage(4, AllowMultiple = False, Inherited = False)]
public sealed class CreateAssetMenuAttribute : Attribute // TypeDefIndex: 14126
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <menuName>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <fileName>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <order>k__BackingField; // 0x20

	// Properties
	public string menuName { set; }
	public string fileName { set; }
	public int order { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_menuName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_fileName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_order(int value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(64, AllowMultiple = True)]
public sealed class ContextMenu : Attribute // TypeDefIndex: 14127
{
	// Fields
	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C

	// Methods

	// RVA: 0x248E410 Offset: 0x248D610 VA: 0x18248E410
	public void .ctor(string itemName) { }

	// RVA: 0x248E3D0 Offset: 0x248D5D0 VA: 0x18248E3D0
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x248E380 Offset: 0x248D580 VA: 0x18248E380
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public sealed class ExecuteInEditMode : Attribute // TypeDefIndex: 14128
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public sealed class ExecuteAlways : Attribute // TypeDefIndex: 14129
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public sealed class HideInInspector : Attribute // TypeDefIndex: 14130
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[Usage(4, AllowMultiple = False)]
public class HelpURLAttribute : Attribute // TypeDefIndex: 14131
{
	// Fields
	internal readonly string m_Url; // 0x10
	internal readonly bool m_Dispatcher; // 0x18
	internal readonly string m_DispatchingFieldName; // 0x20

	// Methods

	// RVA: 0x24924F0 Offset: 0x24916F0 VA: 0x1824924F0
	public void .ctor(string url) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[Usage(4)]
public class DefaultExecutionOrder : Attribute // TypeDefIndex: 14132
{
	// Fields
	private int m_Order; // 0x10

	// Properties
	public int order { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(int order) { }

	// RVA: 0x24765D0 Offset: 0x24757D0 VA: 0x1824765D0
	public int get_order() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(1)]
public class AssemblyIsEditorAssembly : Attribute // TypeDefIndex: 14133
{}

// Namespace: UnityEngine
[Usage(4, Inherited = False)]
[UsedByNativeCode]
public class ExcludeFromPresetAttribute : Attribute // TypeDefIndex: 14134
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[UsedByNativeCode]
public class Behaviour : Component // TypeDefIndex: 14135
{
	// Properties
	[NativeProperty]
	[RequiredByNativeCode]
	public bool enabled { get; set; }
	[NativeProperty]
	public bool isActiveAndEnabled { get; }

	// Methods

	// RVA: 0x248D9F0 Offset: 0x248CBF0 VA: 0x18248D9F0
	public bool get_enabled() { }

	// RVA: 0x248DA70 Offset: 0x248CC70 VA: 0x18248DA70
	public void set_enabled(bool value) { }

	[NativeMethod("IsAddedToManager")]
	// RVA: 0x248DA30 Offset: 0x248CC30 VA: 0x18248DA30
	public bool get_isActiveAndEnabled() { }

	// RVA: 0x248D9A0 Offset: 0x248CBA0 VA: 0x18248D9A0
	public void .ctor() { }
}

// Namespace: UnityEngine
internal struct CastHelper<T> // TypeDefIndex: 14136
{
	// Fields
	public T t; // 0x0
	public IntPtr onePointerFurtherThanT; // 0x0
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ClassLibraryInitializer.<>c // TypeDefIndex: 14137
{
	// Fields
	public static readonly ClassLibraryInitializer.<>c <>9; // 0x0
	public static ResolveEventHandler <>9__2_0; // 0x8

	// Methods

	// RVA: 0x24A8B80 Offset: 0x24A7D80 VA: 0x1824A8B80
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24A89D0 Offset: 0x24A7BD0 VA: 0x1824A89D0
	internal Assembly <InitAssemblyRedirections>b__2_0(object _, ResolveEventArgs args) { }
}

// Namespace: UnityEngine
internal static class ClassLibraryInitializer // TypeDefIndex: 14138
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x248DCE0 Offset: 0x248CEE0 VA: 0x18248DCE0
	private static void Init() { }

	[RequiredByNativeCode]
	// RVA: 0x248DBC0 Offset: 0x248CDC0 VA: 0x18248DBC0
	private static void InitStdErrWithHandle(IntPtr fileHandle) { }

	[RequiredByNativeCode]
	// RVA: 0x248DAC0 Offset: 0x248CCC0 VA: 0x18248DAC0
	private static void InitAssemblyRedirections() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
internal struct AssemblyVersion // TypeDefIndex: 14139
{
	// Fields
	public ushort major; // 0x0
	public ushort minor; // 0x2
	public ushort build; // 0x4
	public ushort revision; // 0x6

	// Methods

	// RVA: 0x248C8F0 Offset: 0x248BAF0 VA: 0x18248C8F0
	public static bool op_Equality(AssemblyVersion lhs, AssemblyVersion rhs) { }

	// RVA: 0x248C710 Offset: 0x248B910 VA: 0x18248C710 Slot: 3
	public override string ToString() { }

	// RVA: 0x248C5C0 Offset: 0x248B7C0 VA: 0x18248C5C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x248C670 Offset: 0x248B870 VA: 0x18248C670 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode(GenerateProxy = True)]
[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
internal struct AssemblyFullName // TypeDefIndex: 14140
{
	// Fields
	[NativeName("name")]
	public string Name; // 0x0
	[NativeName("version")]
	public AssemblyVersion Version; // 0x8
	[NativeName("publicKeyToken")]
	public string PublicKeyToken; // 0x10
	[NativeName("culture")]
	public string Culture; // 0x18

	// Methods

	// RVA: 0x248C220 Offset: 0x248B420 VA: 0x18248C220 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x248C350 Offset: 0x248B550 VA: 0x18248C350 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x248C3F0 Offset: 0x248B5F0 VA: 0x18248C3F0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
[NativeClass("Unity::Component")]
[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
[RequiredByNativeCode]
public class Component : Object // TypeDefIndex: 14141
{
	// Properties
	public Transform transform { get; }
	public GameObject gameObject { get; }
	public string tag { get; }

	// Methods

	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x248E2F0 Offset: 0x248D4F0 VA: 0x18248E2F0
	public Transform get_transform() { }

	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	// RVA: 0x248E240 Offset: 0x248D440 VA: 0x18248E240
	public GameObject get_gameObject() { }

	[TypeInferenceRule(0)]
	// RVA: 0x248DF40 Offset: 0x248D140 VA: 0x18248DF40
	public Component GetComponent(Type type) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x248DDC0 Offset: 0x248CFC0 VA: 0x18248DDC0
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94DE80 Offset: 0x94D080 VA: 0x18094DE80
	|-Component.GetComponent<object>
	|
	|-RVA: 0x94DCA0 Offset: 0x94CEA0 VA: 0x18094DCA0
	|-Component.GetComponent<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x248E0F0 Offset: 0x248D2F0 VA: 0x18248E0F0
	public bool TryGetComponent(Type type, out Component component) { }

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E520 Offset: 0x94D720 VA: 0x18094E520
	|-Component.TryGetComponent<object>
	|
	|-RVA: 0x94E4B0 Offset: 0x94D6B0 VA: 0x18094E4B0
	|-Component.TryGetComponent<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x248DE20 Offset: 0x248D020 VA: 0x18248DE20
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D900 Offset: 0x94CB00 VA: 0x18094D900
	|-Component.GetComponentInChildren<object>
	|
	|-RVA: 0x94D7A0 Offset: 0x94C9A0 VA: 0x18094D7A0
	|-Component.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D9D0 Offset: 0x94CBD0 VA: 0x18094D9D0
	|-Component.GetComponentInChildren<object>
	|
	|-RVA: 0x94D650 Offset: 0x94C850 VA: 0x18094D650
	|-Component.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E160 Offset: 0x94D360 VA: 0x18094E160
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x94DF50 Offset: 0x94D150 VA: 0x18094DF50
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E0F0 Offset: 0x94D2F0 VA: 0x18094E0F0
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x94DFC0 Offset: 0x94D1C0 VA: 0x18094DFC0
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E080 Offset: 0x94D280 VA: 0x18094E080
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x94DF10 Offset: 0x94D110 VA: 0x18094DF10
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E1C0 Offset: 0x94D3C0 VA: 0x18094E1C0
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x94E030 Offset: 0x94D230 VA: 0x18094E030
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x248DEB0 Offset: 0x248D0B0 VA: 0x18248DEB0
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94DBE0 Offset: 0x94CDE0 VA: 0x18094DBE0
	|-Component.GetComponentInParent<object>
	|
	|-RVA: 0x94DA90 Offset: 0x94CC90 VA: 0x18094DA90
	|-Component.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E320 Offset: 0x94D520 VA: 0x18094E320
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0x94DF50 Offset: 0x94D150 VA: 0x18094DF50
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E2B0 Offset: 0x94D4B0 VA: 0x18094E2B0
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0x94DFC0 Offset: 0x94D1C0 VA: 0x18094DFC0
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E240 Offset: 0x94D440 VA: 0x18094E240
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0x94DF10 Offset: 0x94D110 VA: 0x18094DF10
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x248DFC0 Offset: 0x248D1C0 VA: 0x18248DFC0
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x248DFC0 Offset: 0x248D1C0 VA: 0x18248DFC0
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E380 Offset: 0x94D580 VA: 0x18094E380
	|-Component.GetComponents<object>
	|-Component.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x248E280 Offset: 0x248D480 VA: 0x18248E280
	public string get_tag() { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E460 Offset: 0x94D660 VA: 0x18094E460
	|-Component.GetComponents<object>
	|
	|-RVA: 0x94E400 Offset: 0x94D600 VA: 0x18094E400
	|-Component.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x248DD40 Offset: 0x248CF40 VA: 0x18248DD40
	public bool CompareTag(string tag) { }

	[FreeFunction(HasExplicitThis = True)]
	// RVA: 0x248E020 Offset: 0x248D220 VA: 0x18248E020
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x248E090 Offset: 0x248D290 VA: 0x18248E090
	public void SendMessageUpwards(string methodName, SendMessageOptions options) { }

	// RVA: 0x248D9A0 Offset: 0x248CBA0 VA: 0x18248D9A0
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Mono/Coroutine.h")]
public sealed class Coroutine : YieldInstruction // TypeDefIndex: 14142
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x248E450 Offset: 0x248D650 VA: 0x18248E450 Slot: 1
	protected override void Finalize() { }

	[FreeFunction("Coroutine::CleanupCoroutineGC", True)]
	// RVA: 0x248E4D0 Offset: 0x248D6D0 VA: 0x18248E4D0
	private static void ReleaseCoroutine(IntPtr ptr) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
internal class SetupCoroutine // TypeDefIndex: 14143
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x249DD30 Offset: 0x249CF30 VA: 0x18249DD30
	public static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x249DC10 Offset: 0x249CE10 VA: 0x18249DC10
	public static object InvokeMember(object behaviour, string name, object variable) { }
}

// Namespace: UnityEngine
public abstract class CustomYieldInstruction : IEnumerator // TypeDefIndex: 14144
{
	// Properties
	public abstract bool keepWaiting { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_keepWaiting();

	// RVA: 0xB88020 Offset: 0xB87220 VA: 0x180B88020 Slot: 5
	public object get_Current() { }

	// RVA: 0x82EEC0 Offset: 0x82E0C0 VA: 0x18082EEC0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public virtual void Reset() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine
internal struct EnumData // TypeDefIndex: 14145
{
	// Fields
	public Enum[] values; // 0x0
	public int[] flagValues; // 0x8
	public string[] displayNames; // 0x10
	public string[] names; // 0x18
	public string[] tooltip; // 0x20
	public bool flags; // 0x28
	public Type underlyingType; // 0x30
	public bool unsigned; // 0x38
	public bool serializable; // 0x39
}

// Namespace: 
public enum EnumDataUtility.CachedType // TypeDefIndex: 14146
{
	// Fields
	public int value__; // 0x0
	public const EnumDataUtility.CachedType ExcludeObsolete = 0;
	public const EnumDataUtility.CachedType IncludeObsoleteExceptErrors = 1;
	public const EnumDataUtility.CachedType IncludeAllObsolete = 2;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EnumDataUtility.<>c // TypeDefIndex: 14147
{
	// Fields
	public static readonly EnumDataUtility.<>c <>9; // 0x0
	public static Func<FieldInfo, int> <>9__2_5; // 0x8
	public static Func<FieldInfo, string> <>9__2_1; // 0x10
	public static Func<FieldInfo, Enum> <>9__2_2; // 0x18
	public static Func<Enum, int> <>9__2_3; // 0x20
	public static Func<Enum, int> <>9__2_4; // 0x28

	// Methods

	// RVA: 0x24A8C40 Offset: 0x24A7E40 VA: 0x1824A8C40
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24A89A0 Offset: 0x24A7BA0 VA: 0x1824A89A0
	internal int <GetCachedEnumData>b__2_5(FieldInfo f) { }

	// RVA: 0x24A8690 Offset: 0x24A7890 VA: 0x1824A8690
	internal string <GetCachedEnumData>b__2_1(FieldInfo f) { }

	// RVA: 0x24A8850 Offset: 0x24A7A50 VA: 0x1824A8850
	internal Enum <GetCachedEnumData>b__2_2(FieldInfo f) { }

	// RVA: 0x24A8900 Offset: 0x24A7B00 VA: 0x1824A8900
	internal int <GetCachedEnumData>b__2_3(Enum v) { }

	// RVA: 0x24A8950 Offset: 0x24A7B50 VA: 0x1824A8950
	internal int <GetCachedEnumData>b__2_4(Enum v) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EnumDataUtility.<>c__DisplayClass2_0 // TypeDefIndex: 14148
{
	// Fields
	public Func<string, string> nicifyName; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24A8B20 Offset: 0x24A7D20 VA: 0x1824A8B20
	internal string <GetCachedEnumData>b__0(FieldInfo f) { }
}

// Namespace: 
[CompilerGenerated]
private struct EnumDataUtility.<>c__DisplayClass8_0 // TypeDefIndex: 14149
{
	// Fields
	public Func<string, string> nicifyName; // 0x0
	public FieldInfo field; // 0x8
}

// Namespace: UnityEngine
internal static class EnumDataUtility // TypeDefIndex: 14150
{
	// Fields
	private static readonly Dictionary<ValueTuple<EnumDataUtility.CachedType, Type>, EnumData> s_EnumData; // 0x0

	// Methods

	// RVA: 0x248F130 Offset: 0x248E330 VA: 0x18248F130
	public static EnumData GetCachedEnumData(Type enumType, EnumDataUtility.CachedType cachedType = 1, Func<string, string> nicifyName) { }

	// RVA: 0x24900F0 Offset: 0x248F2F0 VA: 0x1824900F0
	internal static void HandleInspectorOrderAttribute(Type enumType, ref EnumData enumData) { }

	// RVA: 0x248EBD0 Offset: 0x248DDD0 VA: 0x18248EBD0
	private static bool CheckObsoleteAddition(FieldInfo field, EnumDataUtility.CachedType cachedType) { }

	// RVA: 0x248EFA0 Offset: 0x248E1A0 VA: 0x18248EFA0
	private static string EnumTooltipFromEnumField(FieldInfo field) { }

	// RVA: 0x248ED10 Offset: 0x248DF10 VA: 0x18248ED10
	private static string EnumNameFromEnumField(FieldInfo field, Func<string, string> nicifyName) { }

	// RVA: 0x2490640 Offset: 0x248F840 VA: 0x182490640
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x24905D0 Offset: 0x248F7D0 VA: 0x1824905D0
	internal static string <EnumNameFromEnumField>g__NicifyName|8_0(ref EnumDataUtility.<>c__DisplayClass8_0 ) { }
}

// Namespace: UnityEngine
[Usage(4)]
[UsedByNativeCode]
public class ExcludeFromObjectFactoryAttribute : Attribute // TypeDefIndex: 14151
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(1028, Inherited = True)]
internal sealed class ExtensionOfNativeClassAttribute : Attribute // TypeDefIndex: 14152
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[ExcludeFromObjectFactory]
[NativeClass(null)]
internal class FailedToLoadScriptObject : Object // TypeDefIndex: 14153
{}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
[ExcludeFromPreset]
public sealed class GameObject : Object // TypeDefIndex: 14154
{
	// Properties
	public Transform transform { get; }
	public int layer { get; set; }
	[Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
	public bool active { get; set; }
	public bool activeSelf { get; }
	public bool activeInHierarchy { get; }
	public bool isStatic { get; set; }
	internal bool isStaticBatchable { get; }
	public string tag { get; set; }
	public Scene scene { get; }
	public ulong sceneCullingMask { get; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunction("GameObjectBindings::CreatePrimitive")]
	// RVA: 0x24909D0 Offset: 0x248FBD0 VA: 0x1824909D0
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AECC0 Offset: 0x9ADEC0 VA: 0x1809AECC0
	|-GameObject.GetComponent<object>
	|
	|-RVA: 0x9AEAE0 Offset: 0x9ADCE0 VA: 0x1809AEAE0
	|-GameObject.GetComponent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x2490EA0 Offset: 0x24900A0 VA: 0x182490EA0
	public Component GetComponent(Type type) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	[NativeWritableSelf]
	// RVA: 0x2490C90 Offset: 0x248FE90 VA: 0x182490C90
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "Scripting::GetScriptingWrapperOfComponentOfGameObject", HasExplicitThis = True)]
	// RVA: 0x2490C00 Offset: 0x248FE00 VA: 0x182490C00
	internal Component GetComponentByName(string type) { }

	[FreeFunction(Name = "Scripting::GetScriptingWrapperOfComponentOfGameObjectWithCase", HasExplicitThis = True)]
	// RVA: 0x2490BA0 Offset: 0x248FDA0 VA: 0x182490BA0
	internal Component GetComponentByNameWithCase(string type, bool caseSensitive) { }

	// RVA: 0x2490C00 Offset: 0x248FE00 VA: 0x182490C00
	public Component GetComponent(string type) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x2490D40 Offset: 0x248FF40 VA: 0x182490D40
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[TypeInferenceRule(0)]
	// RVA: 0x2490CF0 Offset: 0x248FEF0 VA: 0x182490CF0
	public Component GetComponentInChildren(Type type) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AE620 Offset: 0x9AD820 VA: 0x1809AE620
	|-GameObject.GetComponentInChildren<object>
	|
	|-RVA: 0x9AE510 Offset: 0x9AD710 VA: 0x1809AE510
	|-GameObject.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AE700 Offset: 0x9AD900 VA: 0x1809AE700
	|-GameObject.GetComponentInChildren<object>
	|
	|-RVA: 0x9AE3B0 Offset: 0x9AD5B0 VA: 0x1809AE3B0
	|-GameObject.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2490DA0 Offset: 0x248FFA0 VA: 0x182490DA0
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	[TypeInferenceRule(0)]
	// RVA: 0x2490E00 Offset: 0x2490000 VA: 0x182490E00
	public Component GetComponentInParent(Type type) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AEA00 Offset: 0x9ADC00 VA: 0x1809AEA00
	|-GameObject.GetComponentInParent<object>
	|
	|-RVA: 0x9AE510 Offset: 0x9AD710 VA: 0x1809AE510
	|-GameObject.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AE930 Offset: 0x9ADB30 VA: 0x1809AE930
	|-GameObject.GetComponentInParent<object>
	|
	|-RVA: 0x9AE7D0 Offset: 0x9AD9D0 VA: 0x1809AE7D0
	|-GameObject.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24911D0 Offset: 0x24903D0 VA: 0x1824911D0
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x24912C0 Offset: 0x24904C0 VA: 0x1824912C0
	public Component[] GetComponents(Type type) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AF250 Offset: 0x9AE450 VA: 0x1809AF250
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2491250 Offset: 0x2490450 VA: 0x182491250
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AF1B0 Offset: 0x9AE3B0 VA: 0x1809AF1B0
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<__Il2CppFullySharedGenericType>
	*/

	[ExcludeFromDocs]
	// RVA: 0x2490FB0 Offset: 0x24901B0 VA: 0x182490FB0
	public Component[] GetComponentsInChildren(Type type) { }

	// RVA: 0x2490EF0 Offset: 0x24900F0 VA: 0x182490EF0
	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AEE00 Offset: 0x9AE000 VA: 0x1809AEE00
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AED50 Offset: 0x9ADF50 VA: 0x1809AED50
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AEF00 Offset: 0x9AE100 VA: 0x1809AEF00
	|-GameObject.GetComponentsInChildren<object>
	|
	|-RVA: 0x94DF10 Offset: 0x94D110 VA: 0x18094DF10
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E030 Offset: 0x94D230 VA: 0x18094E030
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	[ExcludeFromDocs]
	// RVA: 0x2491060 Offset: 0x2490260 VA: 0x182491060
	public Component[] GetComponentsInParent(Type type) { }

	// RVA: 0x2491110 Offset: 0x2490310 VA: 0x182491110
	public Component[] GetComponentsInParent(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AF100 Offset: 0x9AE300 VA: 0x1809AF100
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AF000 Offset: 0x9AE200 VA: 0x1809AF000
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94DF10 Offset: 0x94D110 VA: 0x18094DF10
	|-GameObject.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AF560 Offset: 0x9AE760 VA: 0x1809AF560
	|-GameObject.TryGetComponent<object>
	|
	|-RVA: 0x9AF340 Offset: 0x9AE540 VA: 0x1809AF340
	|-GameObject.TryGetComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2491DE0 Offset: 0x2490FE0 VA: 0x182491DE0
	public bool TryGetComponent(Type type, out Component component) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x2491D90 Offset: 0x2490F90 VA: 0x182491D90
	internal Component TryGetComponentInternal(Type type) { }

	[NativeWritableSelf]
	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2491D30 Offset: 0x2490F30 VA: 0x182491D30
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x2490A10 Offset: 0x248FC10 VA: 0x182490A10
	public static GameObject FindWithTag(string tag) { }

	// RVA: 0x24918A0 Offset: 0x2490AA0 VA: 0x1824918A0
	public void SendMessageUpwards(string methodName, SendMessageOptions options) { }

	// RVA: 0x2491A20 Offset: 0x2490C20 VA: 0x182491A20
	public void SendMessage(string methodName, SendMessageOptions options) { }

	// RVA: 0x2490860 Offset: 0x248FA60 VA: 0x182490860
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[FreeFunction(Name = "MonoAddComponent", HasExplicitThis = True)]
	// RVA: 0x2490760 Offset: 0x248F960 VA: 0x182490760
	internal Component AddComponentInternal(string className) { }

	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = True)]
	// RVA: 0x24907B0 Offset: 0x248F9B0 VA: 0x1824907B0
	private Component Internal_AddComponentWithType(Type componentType) { }

	[TypeInferenceRule(0)]
	// RVA: 0x24907B0 Offset: 0x248F9B0 VA: 0x1824907B0
	public Component AddComponent(Type componentType) { }

	// RVA: -1 Offset: -1
	public T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AE1C0 Offset: 0x9AD3C0 VA: 0x1809AE1C0
	|-GameObject.AddComponent<object>
	*/

	// RVA: 0x2490C50 Offset: 0x248FE50 VA: 0x182490C50
	public int GetComponentCount() { }

	[NativeName("QueryComponentAtIndex<Unity::Component>")]
	// RVA: 0x2491740 Offset: 0x2490940 VA: 0x182491740
	internal Component QueryComponentAtIndex(int index) { }

	// RVA: 0x2490AD0 Offset: 0x248FCD0 VA: 0x182490AD0
	public Component GetComponentAtIndex(int index) { }

	// RVA: -1 Offset: -1
	public T GetComponentAtIndex<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AE2B0 Offset: 0x9AD4B0 VA: 0x1809AE2B0
	|-GameObject.GetComponentAtIndex<object>
	*/

	// RVA: 0x2490E50 Offset: 0x2490050 VA: 0x182490E50
	public int GetComponentIndex(Component component) { }

	[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
	// RVA: 0x2492380 Offset: 0x2491580 VA: 0x182492380
	public Transform get_transform() { }

	// RVA: 0x2492220 Offset: 0x2491420 VA: 0x182492220
	public int get_layer() { }

	// RVA: 0x2492460 Offset: 0x2491660 VA: 0x182492460
	public void set_layer(int value) { }

	[NativeMethod(Name = "IsActive")]
	// RVA: 0x2492160 Offset: 0x2491360 VA: 0x182492160
	public bool get_active() { }

	[NativeMethod(Name = "SetSelfActive")]
	// RVA: 0x24923C0 Offset: 0x24915C0 VA: 0x1824923C0
	public void set_active(bool value) { }

	[NativeMethod(Name = "SetSelfActive")]
	// RVA: 0x2491AD0 Offset: 0x2490CD0 VA: 0x182491AD0
	public void SetActive(bool value) { }

	[NativeMethod(Name = "IsSelfActive")]
	// RVA: 0x2492120 Offset: 0x2491320 VA: 0x182492120
	public bool get_activeSelf() { }

	[NativeMethod(Name = "IsActive")]
	// RVA: 0x24920E0 Offset: 0x24912E0 VA: 0x1824920E0
	public bool get_activeInHierarchy() { }

	[NativeMethod(Name = "SetActiveRecursivelyDeprecated")]
	[Obsolete("gameObject.SetActiveRecursively() is obsolete. Use GameObject.SetActive(), which is now inherited by children.")]
	// RVA: 0x2491A80 Offset: 0x2490C80 VA: 0x182491A80
	public void SetActiveRecursively(bool state) { }

	[NativeMethod(Name = "GetIsStaticDeprecated")]
	// RVA: 0x24921E0 Offset: 0x24913E0 VA: 0x1824921E0
	public bool get_isStatic() { }

	[NativeMethod(Name = "SetIsStaticDeprecated")]
	// RVA: 0x2492410 Offset: 0x2491610 VA: 0x182492410
	public void set_isStatic(bool value) { }

	[NativeMethod(Name = "IsStaticBatchable")]
	// RVA: 0x24921A0 Offset: 0x24913A0 VA: 0x1824921A0
	internal bool get_isStaticBatchable() { }

	[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
	// RVA: 0x2492340 Offset: 0x2491540 VA: 0x182492340
	public string get_tag() { }

	[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
	// RVA: 0x24924A0 Offset: 0x24916A0 VA: 0x1824924A0
	public void set_tag(string value) { }

	[FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = True)]
	// RVA: 0x2490980 Offset: 0x248FB80 VA: 0x182490980
	public bool CompareTag(string tag) { }

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = True)]
	// RVA: 0x2490A10 Offset: 0x248FC10 VA: 0x182490A10
	public static GameObject FindGameObjectWithTag(string tag) { }

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTag", ThrowsException = True)]
	// RVA: 0x2490A50 Offset: 0x248FC50 VA: 0x182490A50
	public static GameObject[] FindGameObjectsWithTag(string tag) { }

	[FreeFunction(Name = "Scripting::SendScriptingMessageUpwards", HasExplicitThis = True)]
	// RVA: 0x2491780 Offset: 0x2490980 VA: 0x182491780
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocs]
	// RVA: 0x2491840 Offset: 0x2490A40 VA: 0x182491840
	public void SendMessageUpwards(string methodName, object value) { }

	[ExcludeFromDocs]
	// RVA: 0x24917F0 Offset: 0x24909F0 VA: 0x1824917F0
	public void SendMessageUpwards(string methodName) { }

	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
	// RVA: 0x2491900 Offset: 0x2490B00 VA: 0x182491900
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocs]
	// RVA: 0x24919C0 Offset: 0x2490BC0 VA: 0x1824919C0
	public void SendMessage(string methodName, object value) { }

	[ExcludeFromDocs]
	// RVA: 0x2491970 Offset: 0x2490B70 VA: 0x182491970
	public void SendMessage(string methodName) { }

	[FreeFunction(Name = "Scripting::BroadcastScriptingMessage", HasExplicitThis = True)]
	// RVA: 0x24908C0 Offset: 0x248FAC0 VA: 0x1824908C0
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[ExcludeFromDocs]
	// RVA: 0x2490800 Offset: 0x248FA00 VA: 0x182490800
	public void BroadcastMessage(string methodName, object parameter) { }

	[ExcludeFromDocs]
	// RVA: 0x2490930 Offset: 0x248FB30 VA: 0x182490930
	public void BroadcastMessage(string methodName) { }

	// RVA: 0x2491EF0 Offset: 0x24910F0 VA: 0x182491EF0
	public void .ctor(string name) { }

	// RVA: 0x2492070 Offset: 0x2491270 VA: 0x182492070
	public void .ctor() { }

	// RVA: 0x2491F70 Offset: 0x2491170 VA: 0x182491F70
	public void .ctor(string name, Type[] components) { }

	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	// RVA: 0x24916F0 Offset: 0x24908F0 VA: 0x1824916F0
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunction(Name = "GameObjectBindings::Find")]
	// RVA: 0x2490A90 Offset: 0x248FC90 VA: 0x182490A90
	public static GameObject Find(string name) { }

	[FreeFunction(Name = "GameObjectBindings::SetGameObjectsActiveByInstanceID")]
	// RVA: 0x2491B20 Offset: 0x2490D20 VA: 0x182491B20
	private static void SetGameObjectsActive(IntPtr instanceIds, int instanceCount, bool active) { }

	// RVA: 0x2491C20 Offset: 0x2490E20 VA: 0x182491C20
	public static void SetGameObjectsActive(NativeArray<int> instanceIDs, bool active) { }

	// RVA: 0x2491B80 Offset: 0x2490D80 VA: 0x182491B80
	public static void SetGameObjectsActive(ReadOnlySpan<int> instanceIDs, bool active) { }

	[FreeFunction("GameObjectBindings::InstantiateGameObjectsByInstanceID")]
	// RVA: 0x2491680 Offset: 0x2490880 VA: 0x182491680
	private static void InstantiateGameObjects(int sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, Scene destinationScene) { }

	// RVA: 0x2491460 Offset: 0x2490660 VA: 0x182491460
	public static void InstantiateGameObjects(int sourceInstanceID, int count, NativeArray<int> newInstanceIDs, NativeArray<int> newTransformInstanceIDs, Scene destinationScene) { }

	[FreeFunction(Name = "GameObjectBindings::GetSceneByInstanceID")]
	// RVA: 0x24913B0 Offset: 0x24905B0 VA: 0x1824913B0
	public static Scene GetScene(int instanceID) { }

	[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
	// RVA: 0x24922F0 Offset: 0x24914F0 VA: 0x1824922F0
	public Scene get_scene() { }

	[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = True)]
	// RVA: 0x2492260 Offset: 0x2491460 VA: 0x182492260
	public ulong get_sceneCullingMask() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public GameObject get_gameObject() { }

	// RVA: 0x2491400 Offset: 0x2490600 VA: 0x182491400
	private static void InstantiateGameObjects_Injected(int sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, ref Scene destinationScene) { }

	// RVA: 0x2491370 Offset: 0x2490570 VA: 0x182491370
	private static void GetScene_Injected(int instanceID, out Scene ret) { }

	// RVA: 0x24922A0 Offset: 0x24914A0 VA: 0x1824922A0
	private void get_scene_Injected(out Scene ret) { }
}

// Namespace: UnityEngine
[Usage(16)]
public sealed class InspectorOrderAttribute : PropertyAttribute // TypeDefIndex: 14155
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private InspectorSort <m_inspectorSort>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private InspectorSortDirection <m_sortDirection>k__BackingField; // 0x14

	// Properties
	internal InspectorSort m_inspectorSort { get; }
	internal InspectorSortDirection m_sortDirection { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	internal InspectorSort get_m_inspectorSort() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	internal InspectorSortDirection get_m_sortDirection() { }
}

// Namespace: UnityEngine
public enum InspectorSort // TypeDefIndex: 14156
{
	// Fields
	public int value__; // 0x0
	public const InspectorSort ByName = 0;
	public const InspectorSort ByValue = 1;
}

// Namespace: UnityEngine
public enum InspectorSortDirection // TypeDefIndex: 14157
{
	// Fields
	public int value__; // 0x0
	public const InspectorSortDirection Ascending = 0;
	public const InspectorSortDirection Descending = 1;
}

// Namespace: UnityEngine
[NativeClass("BitField", "struct BitField;")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[NativeHeader("Runtime/BaseClasses/BitField.h")]
public struct LayerMask // TypeDefIndex: 14158
{
	// Fields
	[NativeName("m_Bits")]
	private int m_Mask; // 0x0

	// Methods

	// RVA: 0x2493430 Offset: 0x2492630 VA: 0x182493430
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x2493430 Offset: 0x2492630 VA: 0x182493430
	public static LayerMask op_Implicit(int intVal) { }

	[StaticAccessor("GetTagManager()", 0)]
	[NativeMethod("StringToLayer")]
	// RVA: 0x24933F0 Offset: 0x24925F0 VA: 0x1824933F0
	public static int NameToLayer(string layerName) { }

	// RVA: 0x2493300 Offset: 0x2492500 VA: 0x182493300
	public static int GetMask(string[] layerNames) { }
}

// Namespace: UnityEngine
[Serializable]
public struct LazyLoadReference<T> // TypeDefIndex: 14159
{
	// Fields
	[SerializeField]
	private int m_InstanceID; // 0x0
}

// Namespace: UnityEngine
internal static class ManagedStreamHelpers // TypeDefIndex: 14160
{
	// Methods

	// RVA: 0x2493710 Offset: 0x2492910 VA: 0x182493710
	internal static void ValidateLoadFromStream(Stream stream) { }

	[RequiredByNativeCode]
	// RVA: 0x2493520 Offset: 0x2492720 VA: 0x182493520
	internal static void ManagedStreamRead(byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x2493620 Offset: 0x2492820 VA: 0x182493620
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x2493450 Offset: 0x2492650 VA: 0x182493450
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
[RequiredByNativeCode]
[ExtensionOfNativeClass]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
public class MonoBehaviour : Behaviour // TypeDefIndex: 14161
{
	// Fields
	private CancellationTokenSource m_CancellationTokenSource; // 0x18

	// Properties
	public CancellationToken destroyCancellationToken { get; }
	public bool useGUILayout { get; set; }

	// Methods

	// RVA: 0x24944C0 Offset: 0x24936C0 VA: 0x1824944C0
	public CancellationToken get_destroyCancellationToken() { }

	[RequiredByNativeCode]
	// RVA: 0x2493D60 Offset: 0x2492F60 VA: 0x182493D60
	private void RaiseCancellation() { }

	// RVA: 0x2493AB0 Offset: 0x2492CB0 VA: 0x182493AB0
	public bool IsInvoking() { }

	// RVA: 0x24939E0 Offset: 0x2492BE0 VA: 0x1824939E0
	public void CancelInvoke() { }

	// RVA: 0x2493C30 Offset: 0x2492E30 VA: 0x182493C30
	public void Invoke(string methodName, float time) { }

	// RVA: 0x2493B60 Offset: 0x2492D60 VA: 0x182493B60
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x2493A20 Offset: 0x2492C20 VA: 0x182493A20
	public void CancelInvoke(string methodName) { }

	// RVA: 0x2493C90 Offset: 0x2492E90 VA: 0x182493C90
	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocs]
	// RVA: 0x2493F40 Offset: 0x2493140 VA: 0x182493F40
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x2494050 Offset: 0x2493250 VA: 0x182494050
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x2493E30 Offset: 0x2493030 VA: 0x182493E30
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", False)]
	// RVA: 0x2493E30 Offset: 0x2493030 VA: 0x182493E30
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x24943B0 Offset: 0x24935B0 VA: 0x1824943B0
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x24942A0 Offset: 0x24934A0 VA: 0x1824942A0
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x2494250 Offset: 0x2493450 VA: 0x182494250
	public void StopCoroutine(string methodName) { }

	// RVA: 0x2494170 Offset: 0x2493370 VA: 0x182494170
	public void StopAllCoroutines() { }

	// RVA: 0x2494640 Offset: 0x2493840 VA: 0x182494640
	public bool get_useGUILayout() { }

	// RVA: 0x24946D0 Offset: 0x24938D0 VA: 0x1824946D0
	public void set_useGUILayout(bool value) { }

	// RVA: 0x2494680 Offset: 0x2493880 VA: 0x182494680
	public static void print(object message) { }

	[FreeFunction("CancelInvoke")]
	// RVA: 0x24939E0 Offset: 0x2492BE0 VA: 0x1824939E0
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunction("IsInvoking")]
	// RVA: 0x2493AB0 Offset: 0x2492CB0 VA: 0x182493AB0
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunction]
	// RVA: 0x2493AF0 Offset: 0x2492CF0 VA: 0x182493AF0
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunction]
	// RVA: 0x2493A20 Offset: 0x2492C20 VA: 0x182493A20
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunction]
	// RVA: 0x2493C90 Offset: 0x2492E90 VA: 0x182493C90
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunction]
	// RVA: 0x2493CE0 Offset: 0x2492EE0 VA: 0x182493CE0
	private static bool IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0x2493DD0 Offset: 0x2492FD0 VA: 0x182493DD0
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x2493D80 Offset: 0x2492F80 VA: 0x182493D80
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x2494200 Offset: 0x2493400 VA: 0x182494200
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x24941B0 Offset: 0x24933B0 VA: 0x1824941B0
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x2493A70 Offset: 0x2492C70 VA: 0x182493A70
	internal string GetScriptClassName() { }

	// RVA: 0x2493D20 Offset: 0x2492F20 VA: 0x182493D20
	private void OnCancellationTokenCreated() { }

	// RVA: 0x248D9A0 Offset: 0x248CBA0 VA: 0x18248D9A0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Scripting/NoAllocHelpers.bindings.h")]
internal sealed class NoAllocHelpers // TypeDefIndex: 14162
{
	// Methods

	// RVA: -1 Offset: -1
	public static void ResizeList<T>(List<T> list, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA57180 Offset: 0xA56380 VA: 0x180A57180
	|-NoAllocHelpers.ResizeList<BoneWeight>
	|-NoAllocHelpers.ResizeList<Color>
	|-NoAllocHelpers.ResizeList<Color32>
	|-NoAllocHelpers.ResizeList<int>
	|-NoAllocHelpers.ResizeList<Matrix4x4>
	|-NoAllocHelpers.ResizeList<object>
	|-NoAllocHelpers.ResizeList<Rect>
	|-NoAllocHelpers.ResizeList<float>
	|-NoAllocHelpers.ResizeList<ushort>
	|-NoAllocHelpers.ResizeList<Vector2>
	|-NoAllocHelpers.ResizeList<Vector3>
	|-NoAllocHelpers.ResizeList<Vector4>
	|
	|-RVA: 0xA57280 Offset: 0xA56480 VA: 0x180A57280
	|-NoAllocHelpers.ResizeList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void EnsureListElemCount<T>(List<T> list, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA56E40 Offset: 0xA56040 VA: 0x180A56E40
	|-NoAllocHelpers.EnsureListElemCount<BoneWeight>
	|-NoAllocHelpers.EnsureListElemCount<Color>
	|-NoAllocHelpers.EnsureListElemCount<Color32>
	|-NoAllocHelpers.EnsureListElemCount<int>
	|-NoAllocHelpers.EnsureListElemCount<Matrix4x4>
	|-NoAllocHelpers.EnsureListElemCount<Rect>
	|-NoAllocHelpers.EnsureListElemCount<float>
	|-NoAllocHelpers.EnsureListElemCount<ushort>
	|-NoAllocHelpers.EnsureListElemCount<Vector2>
	|-NoAllocHelpers.EnsureListElemCount<Vector3>
	|-NoAllocHelpers.EnsureListElemCount<Vector4>
	|
	|-RVA: 0xA56FE0 Offset: 0xA561E0 VA: 0x180A56FE0
	|-NoAllocHelpers.EnsureListElemCount<object>
	|
	|-RVA: 0xA56F50 Offset: 0xA56150 VA: 0x180A56F50
	|-NoAllocHelpers.EnsureListElemCount<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x24948B0 Offset: 0x2493AB0 VA: 0x1824948B0
	public static int SafeLength(Array values) { }

	// RVA: -1 Offset: -1
	public static int SafeLength<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA57390 Offset: 0xA56590 VA: 0x180A57390
	|-NoAllocHelpers.SafeLength<Color>
	|-NoAllocHelpers.SafeLength<Color32>
	|-NoAllocHelpers.SafeLength<int>
	|-NoAllocHelpers.SafeLength<ushort>
	|-NoAllocHelpers.SafeLength<Vector2>
	|-NoAllocHelpers.SafeLength<Vector3>
	|-NoAllocHelpers.SafeLength<Vector4>
	|
	|-RVA: 0xA573C0 Offset: 0xA565C0 VA: 0x180A573C0
	|-NoAllocHelpers.SafeLength<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] ExtractArrayFromListT<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA57100 Offset: 0xA56300 VA: 0x180A57100
	|-NoAllocHelpers.ExtractArrayFromListT<BoneWeight>
	|-NoAllocHelpers.ExtractArrayFromListT<Color>
	|-NoAllocHelpers.ExtractArrayFromListT<int>
	|-NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>
	|-NoAllocHelpers.ExtractArrayFromListT<object>
	|-NoAllocHelpers.ExtractArrayFromListT<Rect>
	|-NoAllocHelpers.ExtractArrayFromListT<float>
	|-NoAllocHelpers.ExtractArrayFromListT<SubMeshDescriptor>
	|-NoAllocHelpers.ExtractArrayFromListT<ushort>
	|-NoAllocHelpers.ExtractArrayFromListT<Vector4>
	|-NoAllocHelpers.ExtractArrayFromListT<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction("NoAllocHelpers_Bindings::Internal_ResizeList")]
	// RVA: 0x2494870 Offset: 0x2493A70 VA: 0x182494870
	internal static void Internal_ResizeList(object list, int size) { }

	[FreeFunction("NoAllocHelpers_Bindings::ExtractArrayFromList")]
	// RVA: 0x2494830 Offset: 0x2493A30 VA: 0x182494830
	public static Array ExtractArrayFromList(object list) { }
}

// Namespace: UnityEngine
public struct RangeInt // TypeDefIndex: 14163
{
	// Fields
	public int start; // 0x0
	public int length; // 0x4

	// Properties
	public int end { get; }

	// Methods

	// RVA: 0x2499480 Offset: 0x2498680 VA: 0x182499480
	public int get_end() { }

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void .ctor(int start, int length) { }
}

// Namespace: UnityEngine
public enum RuntimeInitializeLoadType // TypeDefIndex: 14164
{
	// Fields
	public int value__; // 0x0
	public const RuntimeInitializeLoadType AfterSceneLoad = 0;
	public const RuntimeInitializeLoadType BeforeSceneLoad = 1;
	public const RuntimeInitializeLoadType AfterAssembliesLoaded = 2;
	public const RuntimeInitializeLoadType BeforeSplashScreen = 3;
	public const RuntimeInitializeLoadType SubsystemRegistration = 4;
}

// Namespace: UnityEngine
[Usage(64, AllowMultiple = False)]
[RequiredByNativeCode]
public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute // TypeDefIndex: 14165
{
	// Fields
	private RuntimeInitializeLoadType m_LoadType; // 0x10

	// Properties
	private RuntimeInitializeLoadType loadType { set; }

	// Methods

	// RVA: 0x2318DF0 Offset: 0x2317FF0 VA: 0x182318DF0
	public void .ctor() { }

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(RuntimeInitializeLoadType loadType) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	private void set_loadType(RuntimeInitializeLoadType value) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[ExtensionOfNativeClass]
[NativeClass(null)]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
public class ScriptableObject : Object // TypeDefIndex: 14166
{
	// Methods

	// RVA: 0x249DB70 Offset: 0x249CD70 VA: 0x18249DB70
	public void .ctor() { }

	// RVA: 0x249DAA0 Offset: 0x249CCA0 VA: 0x18249DAA0
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6A480 Offset: 0xA69680 VA: 0x180A6A480
	|-ScriptableObject.CreateInstance<object>
	*/

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x249DB30 Offset: 0x249CD30 VA: 0x18249DB30
	private static void CreateScriptableObject(ScriptableObject self) { }

	[NativeMethod(Name = "Scripting::CreateScriptableObjectWithType", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x249DAE0 Offset: 0x249CCE0 VA: 0x18249DAE0
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[NativeHeader("Runtime/Export/Scripting/ScriptingRuntime.h")]
internal class ScriptingRuntime // TypeDefIndex: 14167
{
	// Methods

	// RVA: 0x249DBE0 Offset: 0x249CDE0 VA: 0x18249DBE0
	public static string[] GetAllUserAssemblies() { }
}

// Namespace: 
private struct ScriptingUtility.TestClass // TypeDefIndex: 14168
{
	// Fields
	public int value; // 0x0
}

// Namespace: UnityEngine
internal class ScriptingUtility // TypeDefIndex: 14169
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0xD72460 Offset: 0xD71660 VA: 0x180D72460
	private static bool IsManagedCodeWorking() { }
}

// Namespace: UnityEngine
[Usage(4, Inherited = True, AllowMultiple = False)]
public class SelectionBaseAttribute : Attribute // TypeDefIndex: 14170
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
public static class StackTraceUtility // TypeDefIndex: 14171
{
	// Fields
	private static string projectFolder; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24A18B0 Offset: 0x24A0AB0 VA: 0x1824A18B0
	internal static void SetProjectFolder(string folder) { }

	[RequiredByNativeCode]
	// RVA: 0x24A1390 Offset: 0x24A0590 VA: 0x1824A1390
	public static string ExtractStackTrace() { }

	[RequiredByNativeCode]
	// RVA: 0x24A14D0 Offset: 0x24A06D0 VA: 0x1824A14D0
	internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) { }

	// RVA: 0x24A0BF0 Offset: 0x249FDF0 VA: 0x1824A0BF0
	internal static string ExtractFormattedStackTrace(StackTrace stackTrace) { }

	// RVA: 0x24A19A0 Offset: 0x24A0BA0 VA: 0x1824A19A0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Serializable]
public class UnityException : Exception // TypeDefIndex: 14172
{
	// Methods

	// RVA: 0x24AAF10 Offset: 0x24AA110 VA: 0x1824AAF10
	public void .ctor() { }

	// RVA: 0x24AB000 Offset: 0x24AA200 VA: 0x1824AB000
	public void .ctor(string message) { }

	// RVA: 0x24AAF80 Offset: 0x24AA180 VA: 0x1824AAF80
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: UnityEngine
[Serializable]
public class MissingReferenceException : Exception // TypeDefIndex: 14173
{
	// Methods

	// RVA: 0x2493970 Offset: 0x2492B70 VA: 0x182493970
	public void .ctor() { }

	// RVA: 0x2493900 Offset: 0x2492B00 VA: 0x182493900
	public void .ctor(string message) { }

	// RVA: 0x2493880 Offset: 0x2492A80 VA: 0x182493880
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
internal enum TextAsset.CreateOptions // TypeDefIndex: 14174
{
	// Fields
	public int value__; // 0x0
	public const TextAsset.CreateOptions None = 0;
	public const TextAsset.CreateOptions CreateNativeObject = 1;
}

// Namespace: 
private static class TextAsset.EncodingUtility // TypeDefIndex: 14175
{
	// Fields
	internal static readonly KeyValuePair<byte[], Encoding>[] encodingLookup; // 0x0
	internal static readonly Encoding targetEncoding; // 0x8

	// Methods

	// RVA: 0x248E7D0 Offset: 0x248D9D0 VA: 0x18248E7D0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Scripting/TextAsset.h")]
public class TextAsset : Object // TypeDefIndex: 14176
{
	// Properties
	public byte[] bytes { get; }
	public string text { get; }
	public long dataSize { get; }

	// Methods

	// RVA: 0x24A2A80 Offset: 0x24A1C80 VA: 0x1824A2A80
	public byte[] get_bytes() { }

	// RVA: 0x24A2790 Offset: 0x24A1990 VA: 0x1824A2790
	private byte[] GetPreviewBytes(int maxByteCount) { }

	// RVA: 0x24A2820 Offset: 0x24A1A20 VA: 0x1824A2820
	private static void Internal_CreateInstance(TextAsset self, string text) { }

	// RVA: 0x24A2710 Offset: 0x24A1910 VA: 0x1824A2710
	private IntPtr GetDataPtr() { }

	// RVA: 0x24A2750 Offset: 0x24A1950 VA: 0x1824A2750
	private long GetDataSize() { }

	// RVA: 0x24A2870 Offset: 0x24A1A70 VA: 0x1824A2870
	public string get_text() { }

	// RVA: 0x24A2750 Offset: 0x24A1950 VA: 0x1824A2750
	public long get_dataSize() { }

	// RVA: 0x24A2870 Offset: 0x24A1A70 VA: 0x1824A2870 Slot: 3
	public override string ToString() { }

	// RVA: 0x24A2900 Offset: 0x24A1B00 VA: 0x1824A2900
	public void .ctor() { }

	// RVA: 0x24A2970 Offset: 0x24A1B70 VA: 0x1824A2970
	public void .ctor(string text) { }

	// RVA: 0x24A29F0 Offset: 0x24A1BF0 VA: 0x1824A29F0
	internal void .ctor(TextAsset.CreateOptions options, string text) { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA86770 Offset: 0xA85970 VA: 0x180A86770
	|-TextAsset.GetData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x24A27D0 Offset: 0x24A19D0 VA: 0x1824A27D0
	internal string GetPreview(int maxChars) { }

	// RVA: 0x24A24B0 Offset: 0x24A16B0 VA: 0x1824A24B0
	internal static string DecodeString(byte[] bytes) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public class TrackedReference // TypeDefIndex: 14177
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UnhandledExceptionHandler.<>c // TypeDefIndex: 14178
{
	// Fields
	public static readonly UnhandledExceptionHandler.<>c <>9; // 0x0
	public static UnhandledExceptionEventHandler <>9__0_0; // 0x8

	// Methods

	// RVA: 0x24A8BE0 Offset: 0x24A7DE0 VA: 0x1824A8BE0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24A8A70 Offset: 0x24A7C70 VA: 0x1824A8A70
	internal void <RegisterUECatcher>b__0_0(object sender, UnhandledExceptionEventArgs e) { }
}

// Namespace: UnityEngine
[NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
internal sealed class UnhandledExceptionHandler // TypeDefIndex: 14179
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24A9700 Offset: 0x24A8900 VA: 0x1824A9700
	private static void RegisterUECatcher() { }
}

// Namespace: UnityEngine
[Flags]
public enum HideFlags // TypeDefIndex: 14180
{
	// Fields
	public int value__; // 0x0
	public const HideFlags None = 0;
	public const HideFlags HideInHierarchy = 1;
	public const HideFlags HideInInspector = 2;
	public const HideFlags DontSaveInEditor = 4;
	public const HideFlags NotEditable = 8;
	public const HideFlags DontSaveInBuild = 16;
	public const HideFlags DontUnloadUnusedAsset = 32;
	public const HideFlags DontSave = 52;
	public const HideFlags HideAndDontSave = 61;
}

// Namespace: UnityEngine
public enum FindObjectsSortMode // TypeDefIndex: 14181
{
	// Fields
	public int value__; // 0x0
	public const FindObjectsSortMode None = 0;
	public const FindObjectsSortMode InstanceID = 1;
}

// Namespace: UnityEngine
public enum FindObjectsInactive // TypeDefIndex: 14182
{
	// Fields
	public int value__; // 0x0
	public const FindObjectsInactive Exclude = 0;
	public const FindObjectsInactive Include = 1;
}

// Namespace: UnityEngine
[RequiredByNativeCode(GenerateProxy = True)]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
public class Object // TypeDefIndex: 14183
{
	// Fields
	private IntPtr m_CachedPtr; // 0x10
	internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Properties
	public string name { get; set; }
	public HideFlags hideFlags { get; set; }

	// Methods

	// RVA: 0x2495770 Offset: 0x2494970 VA: 0x182495770
	public int GetInstanceID() { }

	// RVA: 0x2495760 Offset: 0x2494960 VA: 0x182495760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2494DF0 Offset: 0x2493FF0 VA: 0x182494DF0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2496DD0 Offset: 0x2495FD0 VA: 0x182496DD0
	public static bool op_Implicit(Object exists) { }

	// RVA: 0x2494930 Offset: 0x2493B30 VA: 0x182494930
	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0x2494D30 Offset: 0x2493F30 VA: 0x182494D30
	private void EnsureRunningOnMainThread() { }

	// RVA: 0x2496A20 Offset: 0x2495C20 VA: 0x182496A20
	private static bool IsNativeObjectAlive(Object o) { }

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	private IntPtr GetCachedPtr() { }

	// RVA: 0x2496C50 Offset: 0x2495E50 VA: 0x182496C50
	public string get_name() { }

	// RVA: 0x2496FB0 Offset: 0x24961B0 VA: 0x182496FB0
	public void set_name(string value) { }

	// RVA: -1 Offset: -1
	public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59090 Offset: 0xA58290 VA: 0x180A59090
	|-Object.InstantiateAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58CC0 Offset: 0xA57EC0 VA: 0x180A58CC0
	|-Object.InstantiateAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58AD0 Offset: 0xA57CD0 VA: 0x180A58AD0
	|-Object.InstantiateAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Transform parent, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58BC0 Offset: 0xA57DC0 VA: 0x180A58BC0
	|-Object.InstantiateAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59160 Offset: 0xA58360 VA: 0x180A59160
	|-Object.InstantiateAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58EA0 Offset: 0xA580A0 VA: 0x180A58EA0
	|-Object.InstantiateAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58DA0 Offset: 0xA57FA0 VA: 0x180A58DA0
	|-Object.InstantiateAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58A10 Offset: 0xA57C10 VA: 0x180A58A10
	|-Object.InstantiateAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58F90 Offset: 0xA58190 VA: 0x180A58F90
	|-Object.InstantiateAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4C6E0 Offset: 0xA4B8E0 VA: 0x180A4C6E0
	|-Object.InstantiateAsync<object>
	*/

	[TypeInferenceRule(3)]
	// RVA: 0x2495DE0 Offset: 0x2494FE0 VA: 0x182495DE0
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRule(3)]
	// RVA: 0x2495950 Offset: 0x2494B50 VA: 0x182495950
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRule(3)]
	// RVA: 0x2495C50 Offset: 0x2494E50 VA: 0x182495C50
	public static Object Instantiate(Object original) { }

	[TypeInferenceRule(3)]
	// RVA: 0x2496480 Offset: 0x2495680 VA: 0x182496480
	public static Object Instantiate(Object original, Scene scene) { }

	[TypeInferenceRule(3)]
	// RVA: 0x24958F0 Offset: 0x2494AF0 VA: 0x1824958F0
	public static Object Instantiate(Object original, Transform parent) { }

	[TypeInferenceRule(3)]
	// RVA: 0x2496090 Offset: 0x2495290 VA: 0x182496090
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA594A0 Offset: 0xA586A0 VA: 0x180A594A0
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59240 Offset: 0xA58440 VA: 0x180A59240
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59320 Offset: 0xA58520 VA: 0x180A59320
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59420 Offset: 0xA58620 VA: 0x180A59420
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA595D0 Offset: 0xA587D0 VA: 0x180A595D0
	|-Object.Instantiate<object>
	*/

	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2494BF0 Offset: 0x2493DF0 VA: 0x182494BF0
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocs]
	// RVA: 0x2494C40 Offset: 0x2493E40 VA: 0x182494C40
	public static void Destroy(Object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2494AB0 Offset: 0x2493CB0 VA: 0x182494AB0
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocs]
	// RVA: 0x2494A40 Offset: 0x2493C40 VA: 0x182494A40
	public static void DestroyImmediate(Object obj) { }

	// RVA: 0x24955C0 Offset: 0x24947C0 VA: 0x1824955C0
	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
	[TypeInferenceRule(2)]
	// RVA: 0x2495630 Offset: 0x2494830 VA: 0x182495630
	public static Object[] FindObjectsOfType(Type type, bool includeInactive) { }

	// RVA: 0x2495490 Offset: 0x2494690 VA: 0x182495490
	public static Object[] FindObjectsByType(Type type, FindObjectsSortMode sortMode) { }

	[TypeInferenceRule(2)]
	[FreeFunction("UnityEngineObjectBindings::FindObjectsByType")]
	// RVA: 0x2495440 Offset: 0x2494640 VA: 0x182495440
	public static Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	// RVA: 0x2494CF0 Offset: 0x2493EF0 VA: 0x182494CF0
	public static void DontDestroyOnLoad(Object target) { }

	// RVA: 0x2496C10 Offset: 0x2495E10 VA: 0x182496C10
	public HideFlags get_hideFlags() { }

	// RVA: 0x2496F70 Offset: 0x2496170 VA: 0x182496F70
	public void set_hideFlags(HideFlags value) { }

	[Obsolete("use Object.Destroy instead.")]
	// RVA: 0x2494B00 Offset: 0x2493D00 VA: 0x182494B00
	public static void DestroyObject(Object obj, float t) { }

	[ExcludeFromDocs]
	[Obsolete("use Object.Destroy instead.")]
	// RVA: 0x2494B80 Offset: 0x2493D80 VA: 0x182494B80
	public static void DestroyObject(Object obj) { }

	[Obsolete("warning use Object.FindObjectsByType instead.")]
	// RVA: 0x2495680 Offset: 0x2494880 VA: 0x182495680
	public static Object[] FindSceneObjectsOfType(Type type) { }

	[Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfTypeIncludingAssets")]
	// RVA: 0x2495580 Offset: 0x2494780 VA: 0x182495580
	public static Object[] FindObjectsOfTypeIncludingAssets(Type type) { }

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58970 Offset: 0xA57B70 VA: 0x180A58970
	|-Object.FindObjectsOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] FindObjectsByType<T>(FindObjectsSortMode sortMode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58750 Offset: 0xA57950 VA: 0x180A58750
	|-Object.FindObjectsByType<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA588C0 Offset: 0xA57AC0 VA: 0x180A588C0
	|-Object.FindObjectsOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] FindObjectsByType<T>(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58800 Offset: 0xA57A00 VA: 0x180A58800
	|-Object.FindObjectsByType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58580 Offset: 0xA57780 VA: 0x180A58580
	|-Object.FindObjectOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58660 Offset: 0xA57860 VA: 0x180A58660
	|-Object.FindObjectOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindFirstObjectByType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA583C0 Offset: 0xA575C0 VA: 0x180A583C0
	|-Object.FindFirstObjectByType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindAnyObjectByType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA582E0 Offset: 0xA574E0 VA: 0x180A582E0
	|-Object.FindAnyObjectByType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindFirstObjectByType<T>(FindObjectsInactive findObjectsInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA584A0 Offset: 0xA576A0 VA: 0x180A584A0
	|-Object.FindFirstObjectByType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindAnyObjectByType<T>(FindObjectsInactive findObjectsInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA58200 Offset: 0xA57400 VA: 0x180A58200
	|-Object.FindAnyObjectByType<object>
	*/

	[Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
	// RVA: 0x2495510 Offset: 0x2494710 VA: 0x182495510
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x24948D0 Offset: 0x2493AD0 VA: 0x1824948D0
	private static void CheckNullArgument(object arg, string message) { }

	[TypeInferenceRule(0)]
	// RVA: 0x24953B0 Offset: 0x24945B0 VA: 0x1824953B0
	public static Object FindObjectOfType(Type type) { }

	// RVA: 0x2495180 Offset: 0x2494380 VA: 0x182495180
	public static Object FindFirstObjectByType(Type type) { }

	// RVA: 0x2495030 Offset: 0x2494230 VA: 0x182495030
	public static Object FindAnyObjectByType(Type type) { }

	[TypeInferenceRule(0)]
	// RVA: 0x2495310 Offset: 0x2494510 VA: 0x182495310
	public static Object FindObjectOfType(Type type, bool includeInactive) { }

	// RVA: 0x2495220 Offset: 0x2494420 VA: 0x182495220
	public static Object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	// RVA: 0x24950D0 Offset: 0x24942D0 VA: 0x1824950D0
	public static Object FindAnyObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	// RVA: 0x2496B20 Offset: 0x2495D20 VA: 0x182496B20 Slot: 3
	public override string ToString() { }

	// RVA: 0x2496CC0 Offset: 0x2495EC0 VA: 0x182496CC0
	public static bool op_Equality(Object x, Object y) { }

	// RVA: 0x2496E60 Offset: 0x2496060 VA: 0x182496E60
	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x24958C0 Offset: 0x2494AC0 VA: 0x1824958C0
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[NativeMethod(Name = "CurrentThreadIsMainThread", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x2494A10 Offset: 0x2493C10 VA: 0x182494A10
	private static bool CurrentThreadIsMainThread() { }

	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2496780 Offset: 0x2495980 VA: 0x182496780
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunction("CloneObjectToScene")]
	// RVA: 0x2496710 Offset: 0x2495910 VA: 0x182496710
	private static Object Internal_CloneSingleWithScene(Object data, Scene scene) { }

	[FreeFunction("CloneObject")]
	// RVA: 0x2496660 Offset: 0x2495860 VA: 0x182496660
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunction("InstantiateAsyncObjects")]
	// RVA: 0x24967C0 Offset: 0x24959C0 VA: 0x1824967C0
	private static AsyncInstantiateOperation Internal_InstantiateAsyncWithParent(Object original, int count, Transform parent, IntPtr positions, int positionsCount, IntPtr rotations, int rotationsCount) { }

	[FreeFunction("InstantiateObject")]
	// RVA: 0x2496990 Offset: 0x2495B90 VA: 0x182496990
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunction("InstantiateObject")]
	// RVA: 0x2496890 Offset: 0x2495A90 VA: 0x182496890
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunction("UnityEngineObjectBindings::ToString")]
	// RVA: 0x2496B90 Offset: 0x2495D90 VA: 0x182496B90
	private static string ToString(Object obj) { }

	[FreeFunction("UnityEngineObjectBindings::GetName")]
	// RVA: 0x2495880 Offset: 0x2494A80 VA: 0x182495880
	private static string GetName(Object obj) { }

	[FreeFunction("UnityEngineObjectBindings::IsPersistent")]
	// RVA: 0x2496A50 Offset: 0x2495C50 VA: 0x182496A50
	internal static bool IsPersistent(Object obj) { }

	[FreeFunction("UnityEngineObjectBindings::SetName")]
	// RVA: 0x2496AD0 Offset: 0x2495CD0 VA: 0x182496AD0
	private static void SetName(Object obj, string name) { }

	[NativeMethod(Name = "UnityEngineObjectBindings::DoesObjectWithInstanceIDExist", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x2494CB0 Offset: 0x2493EB0 VA: 0x182494CB0
	internal static bool DoesObjectWithInstanceIDExist(int instanceID) { }

	[VisibleToOtherModules]
	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	// RVA: 0x24952D0 Offset: 0x24944D0 VA: 0x1824952D0
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
	[VisibleToOtherModules]
	// RVA: 0x2495720 Offset: 0x2494920 VA: 0x182495720
	internal static Object ForceLoadFromInstanceID(int instanceID) { }

	[FreeFunction("UnityEngineObjectBindings::MarkObjectDirty", HasExplicitThis = True)]
	// RVA: 0x2496A90 Offset: 0x2495C90 VA: 0x182496A90
	internal void MarkDirty() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2496BD0 Offset: 0x2495DD0 VA: 0x182496BD0
	private static void .cctor() { }

	// RVA: 0x24966C0 Offset: 0x24958C0 VA: 0x1824966C0
	private static Object Internal_CloneSingleWithScene_Injected(Object data, ref Scene scene) { }

	// RVA: 0x2496930 Offset: 0x2495B30 VA: 0x182496930
	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	// RVA: 0x2496820 Offset: 0x2495A20 VA: 0x182496820
	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }
}

// Namespace: 
private struct UnitySynchronizationContext.WorkRequest // TypeDefIndex: 14184
{
	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x0
	private readonly object m_DelagateState; // 0x8
	private readonly ManualResetEvent m_WaitHandle; // 0x10

	// Methods

	// RVA: 0xD45610 Offset: 0xD44810 VA: 0x180D45610
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x24AC060 Offset: 0x24AB260 VA: 0x1824AC060
	public void Invoke() { }
}

// Namespace: UnityEngine
internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 14185
{
	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x24ABB20 Offset: 0x24AAD20 VA: 0x1824ABB20
	private void .ctor(int mainThreadID) { }

	// RVA: 0x24ABA80 Offset: 0x24AAC80 VA: 0x1824ABA80
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x24AB7F0 Offset: 0x24AA9F0 VA: 0x1824AB7F0 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x24AB660 Offset: 0x24AA860 VA: 0x1824AB660 Slot: 6
	public override void OperationStarted() { }

	// RVA: 0x24AB650 Offset: 0x24AA850 VA: 0x1824AB650 Slot: 7
	public override void OperationCompleted() { }

	// RVA: 0x24AB670 Offset: 0x24AA870 VA: 0x1824AB670 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x24AB070 Offset: 0x24AA270 VA: 0x1824AB070 Slot: 9
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x24AB140 Offset: 0x24AA340 VA: 0x1824AB140
	public void Exec() { }

	// RVA: 0x24AB4E0 Offset: 0x24AA6E0 VA: 0x1824AB4E0
	private bool HasPendingTasks() { }

	[RequiredByNativeCode]
	// RVA: 0x24AB540 Offset: 0x24AA740 VA: 0x1824AB540
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCode]
	// RVA: 0x24AB480 Offset: 0x24AA680 VA: 0x1824AB480
	private static void ExecuteTasks() { }

	[RequiredByNativeCode]
	// RVA: 0x24AB330 Offset: 0x24AA530 VA: 0x1824AB330
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class WaitForEndOfFrame : YieldInstruction // TypeDefIndex: 14186
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class WaitForFixedUpdate : YieldInstruction // TypeDefIndex: 14187
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class WaitForSeconds : YieldInstruction // TypeDefIndex: 14188
{
	// Fields
	internal float m_Seconds; // 0x10

	// Methods

	// RVA: 0x74FF30 Offset: 0x74F130 VA: 0x18074FF30
	public void .ctor(float seconds) { }
}

// Namespace: UnityEngine
public class WaitForSecondsRealtime : CustomYieldInstruction // TypeDefIndex: 14189
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <waitTime>k__BackingField; // 0x10
	private float m_WaitUntilTime; // 0x14

	// Properties
	public float waitTime { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	public float get_waitTime() { }

	[CompilerGenerated]
	// RVA: 0x482DD0 Offset: 0x481FD0 VA: 0x180482DD0
	public void set_waitTime(float value) { }

	// RVA: 0x24ABF90 Offset: 0x24AB190 VA: 0x1824ABF90 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x24ABF60 Offset: 0x24AB160 VA: 0x1824ABF60
	public void .ctor(float time) { }

	// RVA: 0x24ABF50 Offset: 0x24AB150 VA: 0x1824ABF50 Slot: 8
	public override void Reset() { }
}

// Namespace: UnityEngine
public sealed class WaitUntil : CustomYieldInstruction // TypeDefIndex: 14190
{
	// Fields
	private Func<bool> m_Predicate; // 0x10

	// Properties
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x24AC030 Offset: 0x24AB230 VA: 0x1824AC030 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Func<bool> predicate) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public class YieldInstruction // TypeDefIndex: 14191
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class SerializeField : Attribute // TypeDefIndex: 14192
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(256)]
public sealed class SerializeReference : Attribute // TypeDefIndex: 14193
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(4)]
public sealed class PreferBinarySerialization : Attribute // TypeDefIndex: 14194
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
public interface ISerializationCallbackReceiver // TypeDefIndex: 14195
{
	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeforeSerialize();

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAfterDeserialize();
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeClass("GraphicsBuffer")]
public sealed class ComputeBuffer // TypeDefIndex: 14196
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
public sealed class ComputeShader : Object // TypeDefIndex: 14197
{
	// Methods

	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[RequiredByNativeCode]
	// RVA: 0x248E330 Offset: 0x248D530 VA: 0x18248E330
	public int FindKernel(string name) { }
}

// Namespace: UnityEngine
public enum MaterialPropertyType // TypeDefIndex: 14198
{
	// Fields
	public int value__; // 0x0
	public const MaterialPropertyType Float = 0;
	public const MaterialPropertyType Int = 1;
	public const MaterialPropertyType Vector = 2;
	public const MaterialPropertyType Matrix = 3;
	public const MaterialPropertyType Texture = 4;
	public const MaterialPropertyType ConstantBuffer = 5;
	public const MaterialPropertyType ComputeBuffer = 6;
}

// Namespace: UnityEngine
internal enum DisableBatchingType // TypeDefIndex: 14199
{
	// Fields
	public int value__; // 0x0
	public const DisableBatchingType False = 0;
	public const DisableBatchingType True = 1;
	public const DisableBatchingType WhenLODFading = 2;
}

// Namespace: UnityEngine
internal class LowerResBlitTexture : Object // TypeDefIndex: 14200
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void LowerResBlitTextureDontStripMe() { }
}

// Namespace: UnityEngine
internal class PreloadData : Object // TypeDefIndex: 14201
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void PreloadDataDontStripMe() { }
}

// Namespace: UnityEngine
public enum BatteryStatus // TypeDefIndex: 14202
{
	// Fields
	public int value__; // 0x0
	public const BatteryStatus Unknown = 0;
	public const BatteryStatus Charging = 1;
	public const BatteryStatus Discharging = 2;
	public const BatteryStatus NotCharging = 3;
	public const BatteryStatus Full = 4;
}

// Namespace: UnityEngine
public enum OperatingSystemFamily // TypeDefIndex: 14203
{
	// Fields
	public int value__; // 0x0
	public const OperatingSystemFamily Other = 0;
	public const OperatingSystemFamily MacOSX = 1;
	public const OperatingSystemFamily Windows = 2;
	public const OperatingSystemFamily Linux = 3;
}

// Namespace: UnityEngine
public enum DeviceType // TypeDefIndex: 14204
{
	// Fields
	public int value__; // 0x0
	public const DeviceType Unknown = 0;
	public const DeviceType Handheld = 1;
	public const DeviceType Console = 2;
	public const DeviceType Desktop = 3;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
public sealed class SystemInfo // TypeDefIndex: 14205
{
	// Properties
	[NativeProperty]
	public static float batteryLevel { get; }
	public static BatteryStatus batteryStatus { get; }
	public static string operatingSystem { get; }
	public static OperatingSystemFamily operatingSystemFamily { get; }
	public static string processorType { get; }
	public static int processorCount { get; }
	public static int systemMemorySize { get; }
	public static string deviceUniqueIdentifier { get; }
	public static string deviceName { get; }
	public static string deviceModel { get; }
	public static bool supportsVibration { get; }
	public static DeviceType deviceType { get; }
	public static int graphicsMemorySize { get; }
	public static string graphicsDeviceName { get; }
	public static string graphicsDeviceVendor { get; }
	public static int graphicsDeviceID { get; }
	public static int graphicsDeviceVendorID { get; }
	public static GraphicsDeviceType graphicsDeviceType { get; }
	public static bool graphicsUVStartsAtTop { get; }
	public static string graphicsDeviceVersion { get; }
	public static int graphicsShaderLevel { get; }
	public static bool graphicsMultiThreaded { get; }
	public static RenderingThreadingMode renderingThreadingMode { get; }
	public static CopyTextureSupport copyTextureSupport { get; }
	public static bool supportsComputeShaders { get; }
	public static bool supportsGeometryShaders { get; }
	public static bool supportsInstancing { get; }
	public static NPOTSupport npotSupport { get; }
	public static int maxTextureSize { get; }
	internal static int maxRenderTextureSize { get; }
	public static bool supportsRayTracing { get; }

	// Methods

	// RVA: 0x24A1AB0 Offset: 0x24A0CB0 VA: 0x1824A1AB0
	public static float get_batteryLevel() { }

	// RVA: 0x24A1AE0 Offset: 0x24A0CE0 VA: 0x1824A1AE0
	public static BatteryStatus get_batteryStatus() { }

	// RVA: 0x24A1F20 Offset: 0x24A1120 VA: 0x1824A1F20
	public static string get_operatingSystem() { }

	// RVA: 0x24A1EF0 Offset: 0x24A10F0 VA: 0x1824A1EF0
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	// RVA: 0x24A1FB0 Offset: 0x24A11B0 VA: 0x1824A1FB0
	public static string get_processorType() { }

	// RVA: 0x24A1F80 Offset: 0x24A1180 VA: 0x1824A1F80
	public static int get_processorCount() { }

	// RVA: 0x24A1F50 Offset: 0x24A1150 VA: 0x1824A1F50
	public static int get_systemMemorySize() { }

	// RVA: 0x24A1C10 Offset: 0x24A0E10 VA: 0x1824A1C10
	public static string get_deviceUniqueIdentifier() { }

	// RVA: 0x24A1BB0 Offset: 0x24A0DB0 VA: 0x1824A1BB0
	public static string get_deviceName() { }

	// RVA: 0x24A1B80 Offset: 0x24A0D80 VA: 0x1824A1B80
	public static string get_deviceModel() { }

	// RVA: 0x24A2440 Offset: 0x24A1640 VA: 0x1824A2440
	public static bool get_supportsVibration() { }

	// RVA: 0x24A1BE0 Offset: 0x24A0DE0 VA: 0x1824A1BE0
	public static DeviceType get_deviceType() { }

	// RVA: 0x24A1DA0 Offset: 0x24A0FA0 VA: 0x1824A1DA0
	public static int get_graphicsMemorySize() { }

	// RVA: 0x24A1C70 Offset: 0x24A0E70 VA: 0x1824A1C70
	public static string get_graphicsDeviceName() { }

	// RVA: 0x24A1D00 Offset: 0x24A0F00 VA: 0x1824A1D00
	public static string get_graphicsDeviceVendor() { }

	// RVA: 0x24A1C40 Offset: 0x24A0E40 VA: 0x1824A1C40
	public static int get_graphicsDeviceID() { }

	// RVA: 0x24A1CD0 Offset: 0x24A0ED0 VA: 0x1824A1CD0
	public static int get_graphicsDeviceVendorID() { }

	// RVA: 0x24A1CA0 Offset: 0x24A0EA0 VA: 0x1824A1CA0
	public static GraphicsDeviceType get_graphicsDeviceType() { }

	// RVA: 0x24A1E30 Offset: 0x24A1030 VA: 0x1824A1E30
	public static bool get_graphicsUVStartsAtTop() { }

	// RVA: 0x24A1D30 Offset: 0x24A0F30 VA: 0x1824A1D30
	public static string get_graphicsDeviceVersion() { }

	// RVA: 0x24A1E00 Offset: 0x24A1000 VA: 0x1824A1E00
	public static int get_graphicsShaderLevel() { }

	// RVA: 0x24A1DD0 Offset: 0x24A0FD0 VA: 0x1824A1DD0
	public static bool get_graphicsMultiThreaded() { }

	// RVA: 0x24A1FE0 Offset: 0x24A11E0 VA: 0x1824A1FE0
	public static RenderingThreadingMode get_renderingThreadingMode() { }

	// RVA: 0x24A1B50 Offset: 0x24A0D50 VA: 0x1824A1B50
	public static CopyTextureSupport get_copyTextureSupport() { }

	// RVA: 0x24A2100 Offset: 0x24A1300 VA: 0x1824A2100
	public static bool get_supportsComputeShaders() { }

	// RVA: 0x24A2130 Offset: 0x24A1330 VA: 0x1824A2130
	public static bool get_supportsGeometryShaders() { }

	// RVA: 0x24A2160 Offset: 0x24A1360 VA: 0x1824A2160
	public static bool get_supportsInstancing() { }

	// RVA: 0x24A2090 Offset: 0x24A1290 VA: 0x1824A2090
	private static bool IsValidEnumValue(Enum value) { }

	// RVA: 0x24A21C0 Offset: 0x24A13C0 VA: 0x1824A21C0
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x24A2320 Offset: 0x24A1520 VA: 0x1824A2320
	public static bool SupportsTextureFormat(TextureFormat format) { }

	// RVA: 0x24A1EC0 Offset: 0x24A10C0 VA: 0x1824A1EC0
	public static NPOTSupport get_npotSupport() { }

	// RVA: 0x24A1E90 Offset: 0x24A1090 VA: 0x1824A1E90
	public static int get_maxTextureSize() { }

	// RVA: 0x24A1E60 Offset: 0x24A1060 VA: 0x1824A1E60
	internal static int get_maxRenderTextureSize() { }

	// RVA: 0x24A2190 Offset: 0x24A1390 VA: 0x1824A2190
	public static bool get_supportsRayTracing() { }

	[FreeFunction("systeminfo::GetBatteryLevel")]
	// RVA: 0x24A1AB0 Offset: 0x24A0CB0 VA: 0x1824A1AB0
	private static float GetBatteryLevel() { }

	[FreeFunction("systeminfo::GetBatteryStatus")]
	// RVA: 0x24A1AE0 Offset: 0x24A0CE0 VA: 0x1824A1AE0
	private static BatteryStatus GetBatteryStatus() { }

	[FreeFunction("systeminfo::GetOperatingSystem")]
	// RVA: 0x24A1F20 Offset: 0x24A1120 VA: 0x1824A1F20
	private static string GetOperatingSystem() { }

	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	// RVA: 0x24A1EF0 Offset: 0x24A10F0 VA: 0x1824A1EF0
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunction("systeminfo::GetProcessorType")]
	// RVA: 0x24A1FB0 Offset: 0x24A11B0 VA: 0x1824A1FB0
	private static string GetProcessorType() { }

	[FreeFunction("systeminfo::GetProcessorCount")]
	// RVA: 0x24A1F80 Offset: 0x24A1180 VA: 0x1824A1F80
	private static int GetProcessorCount() { }

	[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
	// RVA: 0x24A1F50 Offset: 0x24A1150 VA: 0x1824A1F50
	private static int GetPhysicalMemoryMB() { }

	[FreeFunction("systeminfo::GetDeviceUniqueIdentifier")]
	// RVA: 0x24A1C10 Offset: 0x24A0E10 VA: 0x1824A1C10
	private static string GetDeviceUniqueIdentifier() { }

	[FreeFunction("systeminfo::GetDeviceName")]
	// RVA: 0x24A1BB0 Offset: 0x24A0DB0 VA: 0x1824A1BB0
	private static string GetDeviceName() { }

	[FreeFunction("systeminfo::GetDeviceModel")]
	// RVA: 0x24A1B80 Offset: 0x24A0D80 VA: 0x1824A1B80
	private static string GetDeviceModel() { }

	[FreeFunction("systeminfo::SupportsVibration")]
	// RVA: 0x24A2440 Offset: 0x24A1640 VA: 0x1824A2440
	private static bool SupportsVibration() { }

	[FreeFunction("systeminfo::GetDeviceType")]
	// RVA: 0x24A1BE0 Offset: 0x24A0DE0 VA: 0x1824A1BE0
	private static DeviceType GetDeviceType() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsMemorySize")]
	// RVA: 0x24A1DA0 Offset: 0x24A0FA0 VA: 0x1824A1DA0
	private static int GetGraphicsMemorySize() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
	// RVA: 0x24A1C70 Offset: 0x24A0E70 VA: 0x1824A1C70
	private static string GetGraphicsDeviceName() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendor")]
	// RVA: 0x24A1D00 Offset: 0x24A0F00 VA: 0x1824A1D00
	private static string GetGraphicsDeviceVendor() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceID")]
	// RVA: 0x24A1C40 Offset: 0x24A0E40 VA: 0x1824A1C40
	private static int GetGraphicsDeviceID() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendorID")]
	// RVA: 0x24A1CD0 Offset: 0x24A0ED0 VA: 0x1824A1CD0
	private static int GetGraphicsDeviceVendorID() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
	// RVA: 0x24A1CA0 Offset: 0x24A0EA0 VA: 0x1824A1CA0
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
	// RVA: 0x24A1E30 Offset: 0x24A1030 VA: 0x1824A1E30
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVersion")]
	// RVA: 0x24A1D30 Offset: 0x24A0F30 VA: 0x1824A1D30
	private static string GetGraphicsDeviceVersion() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
	// RVA: 0x24A1E00 Offset: 0x24A1000 VA: 0x1824A1E00
	private static int GetGraphicsShaderLevel() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsMultiThreaded")]
	// RVA: 0x24A1DD0 Offset: 0x24A0FD0 VA: 0x1824A1DD0
	private static bool GetGraphicsMultiThreaded() { }

	[FreeFunction("ScriptingGraphicsCaps::GetRenderingThreadingMode")]
	// RVA: 0x24A1FE0 Offset: 0x24A11E0 VA: 0x1824A1FE0
	private static RenderingThreadingMode GetRenderingThreadingMode() { }

	[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
	// RVA: 0x24A1B50 Offset: 0x24A0D50 VA: 0x1824A1B50
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
	// RVA: 0x24A2100 Offset: 0x24A1300 VA: 0x1824A2100
	private static bool SupportsComputeShaders() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsGeometryShaders")]
	// RVA: 0x24A2130 Offset: 0x24A1330 VA: 0x1824A2130
	private static bool SupportsGeometryShaders() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsInstancing")]
	// RVA: 0x24A2160 Offset: 0x24A1360 VA: 0x1824A2160
	private static bool SupportsInstancing() { }

	[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
	// RVA: 0x24A2010 Offset: 0x24A1210 VA: 0x1824A2010
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	// RVA: 0x24A22E0 Offset: 0x24A14E0 VA: 0x1824A22E0
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::GetNPOTSupport")]
	// RVA: 0x24A1EC0 Offset: 0x24A10C0 VA: 0x1824A1EC0
	private static NPOTSupport GetNPOTSupport() { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
	// RVA: 0x24A1E90 Offset: 0x24A1090 VA: 0x1824A1E90
	private static int GetMaxTextureSize() { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
	// RVA: 0x24A1E60 Offset: 0x24A1060 VA: 0x1824A1E60
	private static int GetMaxRenderTextureSize() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsRayTracing")]
	// RVA: 0x24A2190 Offset: 0x24A1390 VA: 0x1824A2190
	private static bool SupportsRayTracing() { }

	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	// RVA: 0x24A2050 Offset: 0x24A1250 VA: 0x1824A2050
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	// RVA: 0x24A1B10 Offset: 0x24A0D10 VA: 0x1824A1B10
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	// RVA: 0x24A1D60 Offset: 0x24A0F60 VA: 0x1824A1D60
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
internal class SystemClock // TypeDefIndex: 14206
{
	// Fields
	private static readonly DateTime s_Epoch; // 0x0

	// Properties
	public static DateTime now { get; }

	// Methods

	// RVA: 0x24A1A70 Offset: 0x24A0C70 VA: 0x1824A1A70
	public static DateTime get_now() { }

	// RVA: 0x24A19F0 Offset: 0x24A0BF0 VA: 0x1824A19F0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[StaticAccessor("GetTimeManager()", 0)]
[NativeHeader("Runtime/Input/TimeManager.h")]
public class Time // TypeDefIndex: 14207
{
	// Properties
	[NativeProperty("CurTime")]
	public static float time { get; }
	public static float deltaTime { get; }
	public static float fixedTime { get; }
	public static float unscaledTime { get; }
	public static float unscaledDeltaTime { get; }
	public static float fixedDeltaTime { get; }
	public static float smoothDeltaTime { get; }
	public static float timeScale { get; }
	public static int frameCount { get; }
	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup { get; }

	// Methods

	// RVA: 0x24A2C10 Offset: 0x24A1E10 VA: 0x1824A2C10
	public static float get_time() { }

	// RVA: 0x24A2AC0 Offset: 0x24A1CC0 VA: 0x1824A2AC0
	public static float get_deltaTime() { }

	// RVA: 0x24A2B20 Offset: 0x24A1D20 VA: 0x1824A2B20
	public static float get_fixedTime() { }

	// RVA: 0x24A2C70 Offset: 0x24A1E70 VA: 0x1824A2C70
	public static float get_unscaledTime() { }

	// RVA: 0x24A2C40 Offset: 0x24A1E40 VA: 0x1824A2C40
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x24A2AF0 Offset: 0x24A1CF0 VA: 0x1824A2AF0
	public static float get_fixedDeltaTime() { }

	// RVA: 0x24A2BB0 Offset: 0x24A1DB0 VA: 0x1824A2BB0
	public static float get_smoothDeltaTime() { }

	// RVA: 0x24A2BE0 Offset: 0x24A1DE0 VA: 0x1824A2BE0
	public static float get_timeScale() { }

	// RVA: 0x24A2B50 Offset: 0x24A1D50 VA: 0x1824A2B50
	public static int get_frameCount() { }

	// RVA: 0x24A2B80 Offset: 0x24A1D80 VA: 0x1824A2B80
	public static float get_realtimeSinceStartup() { }
}

// Namespace: UnityEngine
internal struct TouchScreenKeyboard_InternalConstructorHelperArguments // TypeDefIndex: 14208
{
	// Fields
	public uint keyboardType; // 0x0
	public uint autocorrection; // 0x4
	public uint multiline; // 0x8
	public uint secure; // 0xC
	public uint alert; // 0x10
	public int characterLimit; // 0x14
}

// Namespace: 
public enum TouchScreenKeyboard.Status // TypeDefIndex: 14209
{
	// Fields
	public int value__; // 0x0
	public const TouchScreenKeyboard.Status Visible = 0;
	public const TouchScreenKeyboard.Status Done = 1;
	public const TouchScreenKeyboard.Status Canceled = 2;
	public const TouchScreenKeyboard.Status LostFocus = 3;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
public class TouchScreenKeyboard // TypeDefIndex: 14210
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static bool <disableInPlaceEditing>k__BackingField; // 0x0

	// Properties
	public static bool isSupported { get; }
	internal static bool disableInPlaceEditing { get; }
	public static bool isInPlaceEditingAllowed { get; }
	public string text { get; set; }
	public static bool hideInput { set; }
	public bool active { get; set; }
	public TouchScreenKeyboard.Status status { get; }
	public int characterLimit { set; }
	public bool canGetSelection { get; }
	public bool canSetSelection { get; }
	public RangeInt selection { get; set; }
	public static bool visible { get; }

	// Methods

	[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = True)]
	// RVA: 0x24A2E70 Offset: 0x24A2070 VA: 0x1824A2E70
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x24A2CA0 Offset: 0x24A1EA0 VA: 0x1824A2CA0
	private void Destroy() { }

	// RVA: 0x24A2D40 Offset: 0x24A1F40 VA: 0x1824A2D40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24A31A0 Offset: 0x24A23A0 VA: 0x1824A31A0
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
	// RVA: 0x24A3140 Offset: 0x24A2340 VA: 0x1824A3140
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x24A3400 Offset: 0x24A2600 VA: 0x1824A3400
	public static bool get_isSupported() { }

	[CompilerGenerated]
	// RVA: 0x24A3390 Offset: 0x24A2590 VA: 0x1824A3390
	internal static bool get_disableInPlaceEditing() { }

	// RVA: 0x24A33D0 Offset: 0x24A25D0 VA: 0x1824A33D0
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x24A2EB0 Offset: 0x24A20B0 VA: 0x1824A2EB0
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocs]
	// RVA: 0x24A3070 Offset: 0x24A2270 VA: 0x1824A3070
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[ExcludeFromDocs]
	// RVA: 0x24A3010 Offset: 0x24A2210 VA: 0x1824A3010
	public static TouchScreenKeyboard Open(string text) { }

	[NativeName("GetText")]
	// RVA: 0x24A3550 Offset: 0x24A2750 VA: 0x1824A3550
	public string get_text() { }

	[NativeName("SetText")]
	// RVA: 0x24A3790 Offset: 0x24A2990 VA: 0x1824A3790
	public void set_text(string value) { }

	[NativeName("SetInputHidden")]
	// RVA: 0x24A3650 Offset: 0x24A2850 VA: 0x1824A3650
	public static void set_hideInput(bool value) { }

	[NativeName("IsActive")]
	// RVA: 0x24A32D0 Offset: 0x24A24D0 VA: 0x1824A32D0
	public bool get_active() { }

	[NativeName("SetActive")]
	// RVA: 0x24A35C0 Offset: 0x24A27C0 VA: 0x1824A35C0
	public void set_active(bool value) { }

	[NativeName("GetKeyboardStatus")]
	// RVA: 0x24A3510 Offset: 0x24A2710 VA: 0x1824A3510
	public TouchScreenKeyboard.Status get_status() { }

	[NativeName("SetCharacterLimit")]
	// RVA: 0x24A3610 Offset: 0x24A2810 VA: 0x1824A3610
	public void set_characterLimit(int value) { }

	[NativeName("CanGetSelection")]
	// RVA: 0x24A3310 Offset: 0x24A2510 VA: 0x1824A3310
	public bool get_canGetSelection() { }

	[NativeName("CanSetSelection")]
	// RVA: 0x24A3350 Offset: 0x24A2550 VA: 0x1824A3350
	public bool get_canSetSelection() { }

	// RVA: 0x24A34C0 Offset: 0x24A26C0 VA: 0x1824A34C0
	public RangeInt get_selection() { }

	// RVA: 0x24A3690 Offset: 0x24A2890 VA: 0x1824A3690
	public void set_selection(RangeInt value) { }

	// RVA: 0x24A2E20 Offset: 0x24A2020 VA: 0x1824A2E20
	private static void GetSelection(out int start, out int length) { }

	// RVA: 0x24A3100 Offset: 0x24A2300 VA: 0x1824A3100
	private static void SetSelection(int start, int length) { }

	[NativeName("IsVisible")]
	// RVA: 0x24A3590 Offset: 0x24A2790 VA: 0x1824A3590
	public static bool get_visible() { }
}

// Namespace: UnityEngine
public enum TouchScreenKeyboardType // TypeDefIndex: 14211
{
	// Fields
	public int value__; // 0x0
	public const TouchScreenKeyboardType Default = 0;
	public const TouchScreenKeyboardType ASCIICapable = 1;
	public const TouchScreenKeyboardType NumbersAndPunctuation = 2;
	public const TouchScreenKeyboardType URL = 3;
	public const TouchScreenKeyboardType NumberPad = 4;
	public const TouchScreenKeyboardType PhonePad = 5;
	public const TouchScreenKeyboardType NamePhonePad = 6;
	public const TouchScreenKeyboardType EmailAddress = 7;
	[Obsolete("Wii U is no longer supported as of Unity 2018.1.")]
	public const TouchScreenKeyboardType NintendoNetworkAccount = 8;
	public const TouchScreenKeyboardType Social = 9;
	public const TouchScreenKeyboardType Search = 10;
	public const TouchScreenKeyboardType DecimalPad = 11;
	public const TouchScreenKeyboardType OneTimeCode = 12;
}

// Namespace: UnityEngine
internal static class UINumericFieldsUtils // TypeDefIndex: 14212
{
	// Fields
	public static readonly string k_AllowedCharactersForFloat; // 0x0
	public static readonly string k_AllowedCharactersForInt; // 0x8
	public static readonly string k_DoubleFieldFormatString; // 0x10
	public static readonly string k_FloatFieldFormatString; // 0x18
	public static readonly string k_IntFieldFormatString; // 0x20

	// Methods

	// RVA: 0x24A8CA0 Offset: 0x24A7EA0 VA: 0x1824A8CA0
	public static bool TryConvertStringToDouble(string str, out double value, out ExpressionEvaluator.Expression expr) { }

	// RVA: 0x24A8E30 Offset: 0x24A8030 VA: 0x1824A8E30
	public static bool TryConvertStringToDouble(string str, string initialValueAsString, out double value) { }

	// RVA: 0x24A8F50 Offset: 0x24A8150 VA: 0x1824A8F50
	public static bool TryConvertStringToFloat(string str, string initialValueAsString, out float value) { }

	// RVA: 0x24A9150 Offset: 0x24A8350 VA: 0x1824A9150
	public static bool TryConvertStringToLong(string str, out long value, out ExpressionEvaluator.Expression expr) { }

	// RVA: 0x24A91D0 Offset: 0x24A83D0 VA: 0x1824A91D0
	public static bool TryConvertStringToLong(string str, string initialValueAsString, out long value) { }

	// RVA: 0x24A9400 Offset: 0x24A8600 VA: 0x1824A9400
	public static bool TryConvertStringToULong(string str, out ulong value, out ExpressionEvaluator.Expression expr) { }

	// RVA: 0x24A9480 Offset: 0x24A8680 VA: 0x1824A9480
	public static bool TryConvertStringToULong(string str, string initialValueAsString, out ulong value) { }

	// RVA: 0x24A90C0 Offset: 0x24A82C0 VA: 0x1824A90C0
	public static bool TryConvertStringToInt(string str, string initialValueAsString, out int value) { }

	// RVA: 0x24A9370 Offset: 0x24A8570 VA: 0x1824A9370
	public static bool TryConvertStringToUInt(string str, string initialValueAsString, out uint value) { }

	// RVA: 0x24A9620 Offset: 0x24A8820 VA: 0x1824A9620
	private static void .cctor() { }
}

// Namespace: UnityEngine
[Flags]
public enum DrivenTransformProperties // TypeDefIndex: 14213
{
	// Fields
	public int value__; // 0x0
	public const DrivenTransformProperties None = 0;
	public const DrivenTransformProperties All = -1;
	public const DrivenTransformProperties AnchoredPositionX = 2;
	public const DrivenTransformProperties AnchoredPositionY = 4;
	public const DrivenTransformProperties AnchoredPositionZ = 8;
	public const DrivenTransformProperties Rotation = 16;
	public const DrivenTransformProperties ScaleX = 32;
	public const DrivenTransformProperties ScaleY = 64;
	public const DrivenTransformProperties ScaleZ = 128;
	public const DrivenTransformProperties AnchorMinX = 256;
	public const DrivenTransformProperties AnchorMinY = 512;
	public const DrivenTransformProperties AnchorMaxX = 1024;
	public const DrivenTransformProperties AnchorMaxY = 2048;
	public const DrivenTransformProperties SizeDeltaX = 4096;
	public const DrivenTransformProperties SizeDeltaY = 8192;
	public const DrivenTransformProperties PivotX = 16384;
	public const DrivenTransformProperties PivotY = 32768;
	public const DrivenTransformProperties AnchoredPosition = 6;
	public const DrivenTransformProperties AnchoredPosition3D = 14;
	public const DrivenTransformProperties Scale = 224;
	public const DrivenTransformProperties AnchorMin = 768;
	public const DrivenTransformProperties AnchorMax = 3072;
	public const DrivenTransformProperties Anchors = 3840;
	public const DrivenTransformProperties SizeDelta = 12288;
	public const DrivenTransformProperties Pivot = 49152;
}

// Namespace: UnityEngine
public struct DrivenRectTransformTracker // TypeDefIndex: 14214
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Clear() { }
}

// Namespace: 
public enum RectTransform.Edge // TypeDefIndex: 14215
{
	// Fields
	public int value__; // 0x0
	public const RectTransform.Edge Left = 0;
	public const RectTransform.Edge Right = 1;
	public const RectTransform.Edge Top = 2;
	public const RectTransform.Edge Bottom = 3;
}

// Namespace: 
public enum RectTransform.Axis // TypeDefIndex: 14216
{
	// Fields
	public int value__; // 0x0
	public const RectTransform.Axis Horizontal = 0;
	public const RectTransform.Axis Vertical = 1;
}

// Namespace: 
public sealed class RectTransform.ReapplyDrivenProperties : MulticastDelegate // TypeDefIndex: 14217
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(RectTransform driven) { }
}

// Namespace: UnityEngine
[NativeClass("UI::RectTransform")]
[NativeHeader("Runtime/Transform/RectTransform.h")]
public sealed class RectTransform : Transform // TypeDefIndex: 14218
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; // 0x0

	// Properties
	public Rect rect { get; }
	public Vector2 anchorMin { get; set; }
	public Vector2 anchorMax { get; set; }
	public Vector2 anchoredPosition { get; set; }
	public Vector2 sizeDelta { get; set; }
	public Vector2 pivot { get; set; }
	public Vector3 anchoredPosition3D { get; set; }
	public Vector2 offsetMin { get; set; }
	public Vector2 offsetMax { get; set; }
	public Object drivenByObject { get; set; }
	internal DrivenTransformProperties drivenProperties { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x249A880 Offset: 0x2499A80 VA: 0x18249A880
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGenerated]
	// RVA: 0x249B030 Offset: 0x249A230 VA: 0x18249B030
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	// RVA: 0x249AF40 Offset: 0x249A140 VA: 0x18249AF40
	public Rect get_rect() { }

	// RVA: 0x249AA30 Offset: 0x2499C30 VA: 0x18249AA30
	public Vector2 get_anchorMin() { }

	// RVA: 0x249B1D0 Offset: 0x249A3D0 VA: 0x18249B1D0
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x249A990 Offset: 0x2499B90 VA: 0x18249A990
	public Vector2 get_anchorMax() { }

	// RVA: 0x249B140 Offset: 0x249A340 VA: 0x18249B140
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x249AB80 Offset: 0x2499D80 VA: 0x18249AB80
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x249B340 Offset: 0x249A540 VA: 0x18249B340
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x249AFE0 Offset: 0x249A1E0 VA: 0x18249AFE0
	public Vector2 get_sizeDelta() { }

	// RVA: 0x249B9B0 Offset: 0x249ABB0 VA: 0x18249B9B0
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x249AEA0 Offset: 0x249A0A0 VA: 0x18249AEA0
	public Vector2 get_pivot() { }

	// RVA: 0x249B920 Offset: 0x249AB20 VA: 0x18249B920
	public void set_pivot(Vector2 value) { }

	// RVA: 0x249AA80 Offset: 0x2499C80 VA: 0x18249AA80
	public Vector3 get_anchoredPosition3D() { }

	// RVA: 0x249B210 Offset: 0x249A410 VA: 0x18249B210
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x249AD70 Offset: 0x2499F70 VA: 0x18249AD70
	public Vector2 get_offsetMin() { }

	// RVA: 0x249B660 Offset: 0x249A860 VA: 0x18249B660
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x249AC50 Offset: 0x2499E50 VA: 0x18249AC50
	public Vector2 get_offsetMax() { }

	// RVA: 0x249B410 Offset: 0x249A610 VA: 0x18249B410
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x249ABD0 Offset: 0x2499DD0 VA: 0x18249ABD0
	public Object get_drivenByObject() { }

	// RVA: 0x249B380 Offset: 0x249A580 VA: 0x18249B380
	internal void set_drivenByObject(Object value) { }

	// RVA: 0x249AC10 Offset: 0x2499E10 VA: 0x18249AC10
	internal DrivenTransformProperties get_drivenProperties() { }

	// RVA: 0x249B3D0 Offset: 0x249A5D0 VA: 0x18249B3D0
	internal void set_drivenProperties(DrivenTransformProperties value) { }

	[NativeMethod("UpdateIfTransformDispatchIsDirty")]
	// RVA: 0x2499490 Offset: 0x2498690 VA: 0x182499490
	public void ForceUpdateRectTransforms() { }

	// RVA: 0x24994D0 Offset: 0x24986D0 VA: 0x1824994D0
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x2499C10 Offset: 0x2498E10 VA: 0x182499C10
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x2499F30 Offset: 0x2499130 VA: 0x182499F30
	public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size) { }

	// RVA: 0x249A430 Offset: 0x2499630 VA: 0x18249A430
	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCode]
	// RVA: 0x2499ED0 Offset: 0x24990D0 VA: 0x182499ED0
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x24997A0 Offset: 0x24989A0 VA: 0x1824997A0
	internal Rect GetRectInParentSpace() { }

	// RVA: 0x2499610 Offset: 0x2498810 VA: 0x182499610
	private Vector2 GetParentSize() { }

	// RVA: 0x248D9A0 Offset: 0x248CBA0 VA: 0x18248D9A0
	public void .ctor() { }

	// RVA: 0x249AEF0 Offset: 0x249A0F0 VA: 0x18249AEF0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x249A9E0 Offset: 0x2499BE0 VA: 0x18249A9E0
	private void get_anchorMin_Injected(out Vector2 ret) { }

	// RVA: 0x249B180 Offset: 0x249A380 VA: 0x18249B180
	private void set_anchorMin_Injected(ref Vector2 value) { }

	// RVA: 0x249A940 Offset: 0x2499B40 VA: 0x18249A940
	private void get_anchorMax_Injected(out Vector2 ret) { }

	// RVA: 0x249B0F0 Offset: 0x249A2F0 VA: 0x18249B0F0
	private void set_anchorMax_Injected(ref Vector2 value) { }

	// RVA: 0x249AB30 Offset: 0x2499D30 VA: 0x18249AB30
	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	// RVA: 0x249B2F0 Offset: 0x249A4F0 VA: 0x18249B2F0
	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	// RVA: 0x249AF90 Offset: 0x249A190 VA: 0x18249AF90
	private void get_sizeDelta_Injected(out Vector2 ret) { }

	// RVA: 0x249B960 Offset: 0x249AB60 VA: 0x18249B960
	private void set_sizeDelta_Injected(ref Vector2 value) { }

	// RVA: 0x249AE50 Offset: 0x249A050 VA: 0x18249AE50
	private void get_pivot_Injected(out Vector2 ret) { }

	// RVA: 0x249B8D0 Offset: 0x249AAD0 VA: 0x18249B8D0
	private void set_pivot_Injected(ref Vector2 value) { }
}

// Namespace: UnityEngine
internal enum RotationOrder // TypeDefIndex: 14219
{
	// Fields
	public int value__; // 0x0
	public const RotationOrder OrderXYZ = 0;
	public const RotationOrder OrderXZY = 1;
	public const RotationOrder OrderYZX = 2;
	public const RotationOrder OrderYXZ = 3;
	public const RotationOrder OrderZXY = 4;
	public const RotationOrder OrderZYX = 5;
}

// Namespace: 
private class Transform.Enumerator : IEnumerator // TypeDefIndex: 14220
{
	// Fields
	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1600D80 Offset: 0x15FFF80 VA: 0x181600D80
	internal void .ctor(Transform outer) { }

	// RVA: 0x2490710 Offset: 0x248F910 VA: 0x182490710 Slot: 5
	public object get_Current() { }

	// RVA: 0x24906B0 Offset: 0x248F8B0 VA: 0x1824906B0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x112DE90 Offset: 0x112D090 VA: 0x18112DE90 Slot: 6
	public void Reset() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Transform/Transform.h")]
[RequiredByNativeCode]
[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
[NativeHeader("Configuration/UnityConfigure.h")]
public class Transform : Component, IEnumerable // TypeDefIndex: 14221
{
	// Properties
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Vector3 localEulerAngles { get; set; }
	public Vector3 right { get; set; }
	public Vector3 up { get; set; }
	public Vector3 forward { get; set; }
	public Quaternion rotation { get; set; }
	public Quaternion localRotation { get; set; }
	[NativeConditional("UNITY_EDITOR")]
	internal RotationOrder rotationOrder { get; set; }
	public Vector3 localScale { get; set; }
	public Transform parent { get; set; }
	internal Transform parentInternal { get; set; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Transform root { get; }
	public int childCount { get; }
	public Vector3 lossyScale { get; }
	[NativeProperty("HasChangedDeprecated")]
	public bool hasChanged { get; set; }
	public int hierarchyCapacity { get; set; }
	public int hierarchyCount { get; }
	[NativeConditional("UNITY_EDITOR")]
	internal bool constrainProportionsScale { get; set; }

	// Methods

	// RVA: 0x248D9A0 Offset: 0x248CBA0 VA: 0x18248D9A0
	protected void .ctor() { }

	// RVA: 0x24A7BF0 Offset: 0x24A6DF0 VA: 0x1824A7BF0
	public Vector3 get_position() { }

	// RVA: 0x24A8440 Offset: 0x24A7640 VA: 0x1824A8440
	public void set_position(Vector3 value) { }

	// RVA: 0x24A78C0 Offset: 0x24A6AC0 VA: 0x1824A78C0
	public Vector3 get_localPosition() { }

	// RVA: 0x24A81A0 Offset: 0x24A73A0 VA: 0x1824A81A0
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x24A3A50 Offset: 0x24A2C50 VA: 0x1824A3A50
	internal Vector3 GetLocalEulerAngles(RotationOrder order) { }

	// RVA: 0x24A5DA0 Offset: 0x24A4FA0 VA: 0x1824A5DA0
	internal void SetLocalEulerAngles(Vector3 euler, RotationOrder order) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x24A5E50 Offset: 0x24A5050 VA: 0x1824A5E50
	internal void SetLocalEulerHint(Vector3 euler) { }

	// RVA: 0x24A7540 Offset: 0x24A6740 VA: 0x1824A7540
	public Vector3 get_eulerAngles() { }

	// RVA: 0x24A7F70 Offset: 0x24A7170 VA: 0x1824A7F70
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x24A77A0 Offset: 0x24A69A0 VA: 0x1824A77A0
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x24A80C0 Offset: 0x24A72C0 VA: 0x1824A80C0
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x24A7C40 Offset: 0x24A6E40 VA: 0x1824A7C40
	public Vector3 get_right() { }

	// RVA: 0x24A8490 Offset: 0x24A7690 VA: 0x1824A8490
	public void set_right(Vector3 value) { }

	// RVA: 0x24A7DB0 Offset: 0x24A6FB0 VA: 0x1824A7DB0
	public Vector3 get_up() { }

	// RVA: 0x24A85E0 Offset: 0x24A77E0 VA: 0x1824A85E0
	public void set_up(Vector3 value) { }

	// RVA: 0x24A7610 Offset: 0x24A6810 VA: 0x1824A7610
	public Vector3 get_forward() { }

	// RVA: 0x24A8000 Offset: 0x24A7200 VA: 0x1824A8000
	public void set_forward(Vector3 value) { }

	// RVA: 0x24A7D60 Offset: 0x24A6F60 VA: 0x1824A7D60
	public Quaternion get_rotation() { }

	// RVA: 0x24A8590 Offset: 0x24A7790 VA: 0x1824A8590
	public void set_rotation(Quaternion value) { }

	// RVA: 0x24A7960 Offset: 0x24A6B60 VA: 0x1824A7960
	public Quaternion get_localRotation() { }

	// RVA: 0x24A8240 Offset: 0x24A7440 VA: 0x1824A8240
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x24A3BF0 Offset: 0x24A2DF0 VA: 0x1824A3BF0
	internal RotationOrder get_rotationOrder() { }

	// RVA: 0x24A60D0 Offset: 0x24A52D0 VA: 0x1824A60D0
	internal void set_rotationOrder(RotationOrder value) { }

	[NativeConditional("UNITY_EDITOR")]
	[NativeMethod("GetRotationOrder")]
	// RVA: 0x24A3BF0 Offset: 0x24A2DF0 VA: 0x1824A3BF0
	internal int GetRotationOrderInternal() { }

	[NativeMethod("SetRotationOrder")]
	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x24A60D0 Offset: 0x24A52D0 VA: 0x1824A60D0
	internal void SetRotationOrderInternal(RotationOrder rotationOrder) { }

	// RVA: 0x24A7A00 Offset: 0x24A6C00 VA: 0x1824A7A00
	public Vector3 get_localScale() { }

	// RVA: 0x24A82E0 Offset: 0x24A74E0 VA: 0x1824A82E0
	public void set_localScale(Vector3 value) { }

	// RVA: 0x24A3B10 Offset: 0x24A2D10 VA: 0x1824A3B10
	public Transform get_parent() { }

	// RVA: 0x24A8330 Offset: 0x24A7530 VA: 0x1824A8330
	public void set_parent(Transform value) { }

	// RVA: 0x24A3B10 Offset: 0x24A2D10 VA: 0x1824A3B10
	internal Transform get_parentInternal() { }

	// RVA: 0x24A5F60 Offset: 0x24A5160 VA: 0x1824A5F60
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x24A3B10 Offset: 0x24A2D10 VA: 0x1824A3B10
	private Transform GetParent() { }

	// RVA: 0x24A5F60 Offset: 0x24A5160 VA: 0x1824A5F60
	public void SetParent(Transform p) { }

	[FreeFunction("SetParent", HasExplicitThis = True)]
	// RVA: 0x24A5FB0 Offset: 0x24A51B0 VA: 0x1824A5FB0
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x24A7ED0 Offset: 0x24A70D0 VA: 0x1824A7ED0
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x24A7AA0 Offset: 0x24A6CA0 VA: 0x1824A7AA0
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x24A6070 Offset: 0x24A5270 VA: 0x1824A6070
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x24A5F00 Offset: 0x24A5100 VA: 0x1824A5F00
	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) { }

	// RVA: 0x24A3B50 Offset: 0x24A2D50 VA: 0x1824A3B50
	public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation) { }

	// RVA: 0x24A3AB0 Offset: 0x24A2CB0 VA: 0x1824A3AB0
	public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation) { }

	// RVA: 0x24A7220 Offset: 0x24A6420 VA: 0x1824A7220
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x24A6EA0 Offset: 0x24A60A0 VA: 0x1824A6EA0
	public void Translate(Vector3 translation) { }

	// RVA: 0x24A73B0 Offset: 0x24A65B0 VA: 0x1824A73B0
	public void Translate(float x, float y, float z, Space relativeTo) { }

	// RVA: 0x24A73E0 Offset: 0x24A65E0 VA: 0x1824A73E0
	public void Translate(float x, float y, float z) { }

	// RVA: 0x24A6FA0 Offset: 0x24A61A0 VA: 0x1824A6FA0
	public void Translate(Vector3 translation, Transform relativeTo) { }

	// RVA: 0x24A71F0 Offset: 0x24A63F0 VA: 0x1824A71F0
	public void Translate(float x, float y, float z, Transform relativeTo) { }

	// RVA: 0x24A5650 Offset: 0x24A4850 VA: 0x1824A5650
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x24A5390 Offset: 0x24A4590 VA: 0x1824A5390
	public void Rotate(Vector3 eulers) { }

	// RVA: 0x24A5C00 Offset: 0x24A4E00 VA: 0x1824A5C00
	public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo) { }

	// RVA: 0x24A5620 Offset: 0x24A4820 VA: 0x1824A5620
	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	[NativeMethod("RotateAround")]
	// RVA: 0x24A5010 Offset: 0x24A4210 VA: 0x1824A5010
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x24A54C0 Offset: 0x24A46C0 VA: 0x1824A54C0
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x24A53C0 Offset: 0x24A45C0 VA: 0x1824A53C0
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x24A5190 Offset: 0x24A4390 VA: 0x1824A5190
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x24A4D40 Offset: 0x24A3F40 VA: 0x1824A4D40
	public void LookAt(Transform target, Vector3 worldUp) { }

	// RVA: 0x24A4B50 Offset: 0x24A3D50 VA: 0x1824A4B50
	public void LookAt(Transform target) { }

	// RVA: 0x24A4CD0 Offset: 0x24A3ED0 VA: 0x1824A4CD0
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x24A4EB0 Offset: 0x24A40B0 VA: 0x1824A4EB0
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunction("Internal_LookAt", HasExplicitThis = True)]
	// RVA: 0x24A3CD0 Offset: 0x24A2ED0 VA: 0x1824A3CD0
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x24A61B0 Offset: 0x24A53B0 VA: 0x1824A61B0
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x24A6210 Offset: 0x24A5410 VA: 0x1824A6210
	public Vector3 TransformDirection(float x, float y, float z) { }

	// RVA: 0x24A6420 Offset: 0x24A5620 VA: 0x1824A6420
	internal void TransformDirections(Vector3* directions, int count, Vector3* transformedDirections, int transformedCount) { }

	// RVA: 0x24A6490 Offset: 0x24A5690 VA: 0x1824A6490
	public void TransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	// RVA: 0x24A62A0 Offset: 0x24A54A0 VA: 0x1824A62A0
	public void TransformDirections(Span<Vector3> directions) { }

	// RVA: 0x24A3D90 Offset: 0x24A2F90 VA: 0x1824A3D90
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x24A3DF0 Offset: 0x24A2FF0 VA: 0x1824A3DF0
	public Vector3 InverseTransformDirection(float x, float y, float z) { }

	// RVA: 0x24A4000 Offset: 0x24A3200 VA: 0x1824A4000
	internal void InverseTransformDirections(Vector3* directions, int count, Vector3* transformedDirections, int transformedCount) { }

	// RVA: 0x24A4070 Offset: 0x24A3270 VA: 0x1824A4070
	public void InverseTransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	// RVA: 0x24A3E80 Offset: 0x24A3080 VA: 0x1824A3E80
	public void InverseTransformDirections(Span<Vector3> directions) { }

	// RVA: 0x24A6B20 Offset: 0x24A5D20 VA: 0x1824A6B20
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x24A6A90 Offset: 0x24A5C90 VA: 0x1824A6A90
	public Vector3 TransformVector(float x, float y, float z) { }

	// RVA: 0x24A6B80 Offset: 0x24A5D80 VA: 0x1824A6B80
	internal void TransformVectors(Vector3* vectors, int count, Vector3* transformedVectors, int transformedCount) { }

	// RVA: 0x24A6BF0 Offset: 0x24A5DF0 VA: 0x1824A6BF0
	public void TransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	// RVA: 0x24A6D20 Offset: 0x24A5F20 VA: 0x1824A6D20
	public void TransformVectors(Span<Vector3> vectors) { }

	// RVA: 0x24A4700 Offset: 0x24A3900 VA: 0x1824A4700
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x24A4670 Offset: 0x24A3870 VA: 0x1824A4670
	public Vector3 InverseTransformVector(float x, float y, float z) { }

	// RVA: 0x24A4A10 Offset: 0x24A3C10 VA: 0x1824A4A10
	internal void InverseTransformVectors(Vector3* vectors, int count, Vector3* transformedVectors, int transformedCount) { }

	// RVA: 0x24A48E0 Offset: 0x24A3AE0 VA: 0x1824A48E0
	public void InverseTransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	// RVA: 0x24A4760 Offset: 0x24A3960 VA: 0x1824A4760
	public void InverseTransformVectors(Span<Vector3> vectors) { }

	// RVA: 0x24A6620 Offset: 0x24A5820 VA: 0x1824A6620
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x24A6680 Offset: 0x24A5880 VA: 0x1824A6680
	public Vector3 TransformPoint(float x, float y, float z) { }

	// RVA: 0x24A6890 Offset: 0x24A5A90 VA: 0x1824A6890
	internal void TransformPoints(Vector3* positions, int count, Vector3* transformedPositions, int transformedCount) { }

	// RVA: 0x24A6900 Offset: 0x24A5B00 VA: 0x1824A6900
	public void TransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	// RVA: 0x24A6710 Offset: 0x24A5910 VA: 0x1824A6710
	public void TransformPoints(Span<Vector3> positions) { }

	// RVA: 0x24A4290 Offset: 0x24A3490 VA: 0x1824A4290
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x24A4200 Offset: 0x24A3400 VA: 0x1824A4200
	public Vector3 InverseTransformPoint(float x, float y, float z) { }

	// RVA: 0x24A4420 Offset: 0x24A3620 VA: 0x1824A4420
	internal void InverseTransformPoints(Vector3* positions, int count, Vector3* transformedPositions, int transformedCount) { }

	// RVA: 0x24A42F0 Offset: 0x24A34F0 VA: 0x1824A42F0
	public void InverseTransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	// RVA: 0x24A4490 Offset: 0x24A3690 VA: 0x1824A4490
	public void InverseTransformPoints(Span<Vector3> positions) { }

	// RVA: 0x24A3BB0 Offset: 0x24A2DB0 VA: 0x1824A3BB0
	public Transform get_root() { }

	// RVA: 0x24A3BB0 Offset: 0x24A2DB0 VA: 0x1824A3BB0
	private Transform GetRoot() { }

	[NativeMethod("GetChildrenCount")]
	// RVA: 0x24A7500 Offset: 0x24A6700 VA: 0x1824A7500
	public int get_childCount() { }

	[FreeFunction("DetachChildren", HasExplicitThis = True)]
	// RVA: 0x24A37E0 Offset: 0x24A29E0 VA: 0x1824A37E0
	public void DetachChildren() { }

	// RVA: 0x24A5C70 Offset: 0x24A4E70 VA: 0x1824A5C70
	public void SetAsFirstSibling() { }

	// RVA: 0x24A5CB0 Offset: 0x24A4EB0 VA: 0x1824A5CB0
	public void SetAsLastSibling() { }

	// RVA: 0x24A6110 Offset: 0x24A5310 VA: 0x1824A6110
	public void SetSiblingIndex(int index) { }

	[NativeMethod("MoveAfterSiblingInternal")]
	// RVA: 0x24A4F50 Offset: 0x24A4150 VA: 0x1824A4F50
	internal void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty) { }

	// RVA: 0x24A3C30 Offset: 0x24A2E30 VA: 0x1824A3C30
	public int GetSiblingIndex() { }

	[FreeFunction]
	// RVA: 0x24A38C0 Offset: 0x24A2AC0 VA: 0x1824A38C0
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x24A3820 Offset: 0x24A2A20 VA: 0x1824A3820
	public Transform Find(string n) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x24A5C30 Offset: 0x24A4E30 VA: 0x1824A5C30
	internal void SendTransformChangedScale() { }

	[NativeMethod("GetWorldScaleLossy")]
	// RVA: 0x24A7B50 Offset: 0x24A6D50 VA: 0x1824A7B50
	public Vector3 get_lossyScale() { }

	[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = True)]
	// RVA: 0x24A4A80 Offset: 0x24A3C80 VA: 0x1824A4A80
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x24A76E0 Offset: 0x24A68E0 VA: 0x1824A76E0
	public bool get_hasChanged() { }

	// RVA: 0x24A8070 Offset: 0x24A7270 VA: 0x1824A8070
	public void set_hasChanged(bool value) { }

	[Obsolete("FindChild has been deprecated. Use Find instead (UnityUpgradable) -> Find([mscorlib] System.String)", False)]
	// RVA: 0x24A3820 Offset: 0x24A2A20 VA: 0x1824A3820
	public Transform FindChild(string n) { }

	// RVA: 0x24A39A0 Offset: 0x24A2BA0 VA: 0x1824A39A0 Slot: 4
	public IEnumerator GetEnumerator() { }

	[Obsolete("warning use Transform.Rotate instead.")]
	// RVA: 0x24A5330 Offset: 0x24A4530 VA: 0x1824A5330
	public void RotateAround(Vector3 axis, float angle) { }

	[Obsolete("warning use Transform.Rotate instead.")]
	// RVA: 0x24A50D0 Offset: 0x24A42D0 VA: 0x1824A50D0
	public void RotateAroundLocal(Vector3 axis, float angle) { }

	[NativeThrows]
	[FreeFunction("GetChild", HasExplicitThis = True)]
	// RVA: 0x24A3960 Offset: 0x24A2B60 VA: 0x1824A3960
	public Transform GetChild(int index) { }

	[Obsolete("warning use Transform.childCount instead (UnityUpgradable) -> Transform.childCount", False)]
	[NativeMethod("GetChildrenCount")]
	// RVA: 0x24A3920 Offset: 0x24A2B20 VA: 0x1824A3920
	public int GetChildCount() { }

	// RVA: 0x24A7720 Offset: 0x24A6920 VA: 0x1824A7720
	public int get_hierarchyCapacity() { }

	// RVA: 0x24A7F30 Offset: 0x24A7130 VA: 0x1824A7F30
	public void set_hierarchyCapacity(int value) { }

	[FreeFunction("GetHierarchyCapacity", HasExplicitThis = True)]
	// RVA: 0x24A7720 Offset: 0x24A6920 VA: 0x1824A7720
	private int internal_getHierarchyCapacity() { }

	[FreeFunction("SetHierarchyCapacity", HasExplicitThis = True)]
	// RVA: 0x24A7F30 Offset: 0x24A7130 VA: 0x1824A7F30
	private void internal_setHierarchyCapacity(int value) { }

	// RVA: 0x24A7760 Offset: 0x24A6960 VA: 0x1824A7760
	public int get_hierarchyCount() { }

	[FreeFunction("GetHierarchyCount", HasExplicitThis = True)]
	// RVA: 0x24A7760 Offset: 0x24A6960 VA: 0x1824A7760
	private int internal_getHierarchyCount() { }

	[NativeConditional("UNITY_EDITOR")]
	[FreeFunction("IsNonUniformScaleTransform", HasExplicitThis = True)]
	// RVA: 0x24A4B10 Offset: 0x24A3D10 VA: 0x1824A4B10
	internal bool IsNonUniformScaleTransform() { }

	// RVA: 0x24A4AD0 Offset: 0x24A3CD0 VA: 0x1824A4AD0
	internal bool get_constrainProportionsScale() { }

	// RVA: 0x24A5CF0 Offset: 0x24A4EF0 VA: 0x1824A5CF0
	internal void set_constrainProportionsScale(bool value) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x24A5CF0 Offset: 0x24A4EF0 VA: 0x1824A5CF0
	private void SetConstrainProportionsScale(bool isLinked) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x24A4AD0 Offset: 0x24A3CD0 VA: 0x1824A4AD0
	private bool IsConstrainProportionsScale() { }

	// RVA: 0x24A7BA0 Offset: 0x24A6DA0 VA: 0x1824A7BA0
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x24A83F0 Offset: 0x24A75F0 VA: 0x1824A83F0
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x24A7870 Offset: 0x24A6A70 VA: 0x1824A7870
	private void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x24A8150 Offset: 0x24A7350 VA: 0x1824A8150
	private void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x24A3A00 Offset: 0x24A2C00 VA: 0x1824A3A00
	private void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret) { }

	// RVA: 0x24A5D40 Offset: 0x24A4F40 VA: 0x1824A5D40
	private void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order) { }

	// RVA: 0x24A5E00 Offset: 0x24A5000 VA: 0x1824A5E00
	private void SetLocalEulerHint_Injected(ref Vector3 euler) { }

	// RVA: 0x24A7D10 Offset: 0x24A6F10 VA: 0x1824A7D10
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x24A8540 Offset: 0x24A7740 VA: 0x1824A8540
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x24A7910 Offset: 0x24A6B10 VA: 0x1824A7910
	private void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x24A81F0 Offset: 0x24A73F0 VA: 0x1824A81F0
	private void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x24A79B0 Offset: 0x24A6BB0 VA: 0x1824A79B0
	private void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x24A8290 Offset: 0x24A7490 VA: 0x1824A8290
	private void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x24A7E80 Offset: 0x24A7080 VA: 0x1824A7E80
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x24A7A50 Offset: 0x24A6C50 VA: 0x1824A7A50
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x24A6010 Offset: 0x24A5210 VA: 0x1824A6010
	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x24A5EA0 Offset: 0x24A50A0 VA: 0x1824A5EA0
	private void SetLocalPositionAndRotation_Injected(ref Vector3 localPosition, ref Quaternion localRotation) { }

	// RVA: 0x24A4FB0 Offset: 0x24A41B0 VA: 0x1824A4FB0
	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x24A3C70 Offset: 0x24A2E70 VA: 0x1824A3C70
	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0x24A6150 Offset: 0x24A5350 VA: 0x1824A6150
	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x24A3D30 Offset: 0x24A2F30 VA: 0x1824A3D30
	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x24A6A30 Offset: 0x24A5C30 VA: 0x1824A6A30
	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x24A4610 Offset: 0x24A3810 VA: 0x1824A4610
	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x24A65C0 Offset: 0x24A57C0 VA: 0x1824A65C0
	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x24A41A0 Offset: 0x24A33A0 VA: 0x1824A41A0
	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x24A7B00 Offset: 0x24A6D00 VA: 0x1824A7B00
	private void get_lossyScale_Injected(out Vector3 ret) { }

	// RVA: 0x24A5130 Offset: 0x24A4330 VA: 0x1824A5130
	private void RotateAround_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x24A5070 Offset: 0x24A4270 VA: 0x1824A5070
	private void RotateAroundLocal_Injected(ref Vector3 axis, float angle) { }
}

// Namespace: UnityEngine
public enum SpriteDrawMode // TypeDefIndex: 14222
{
	// Fields
	public int value__; // 0x0
	public const SpriteDrawMode Simple = 0;
	public const SpriteDrawMode Sliced = 1;
	public const SpriteDrawMode Tiled = 2;
}

// Namespace: UnityEngine
public enum SpriteTileMode // TypeDefIndex: 14223
{
	// Fields
	public int value__; // 0x0
	public const SpriteTileMode Continuous = 0;
	public const SpriteTileMode Adaptive = 1;
}

// Namespace: UnityEngine
public enum SpriteMaskInteraction // TypeDefIndex: 14224
{
	// Fields
	public int value__; // 0x0
	public const SpriteMaskInteraction None = 0;
	public const SpriteMaskInteraction VisibleInsideMask = 1;
	public const SpriteMaskInteraction VisibleOutsideMask = 2;
}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
public sealed class SpriteRenderer : Renderer // TypeDefIndex: 14225
{
	// Fields
	private UnityEvent<SpriteRenderer> m_SpriteChangeEvent; // 0x18

	// Properties
	internal bool shouldSupportTiling { get; }
	public Sprite sprite { get; set; }
	public SpriteDrawMode drawMode { get; set; }
	public Vector2 size { get; set; }
	public float adaptiveModeThreshold { get; set; }
	public SpriteTileMode tileMode { get; set; }
	public Color color { get; set; }
	public SpriteMaskInteraction maskInteraction { get; set; }
	public bool flipX { get; set; }
	public bool flipY { get; set; }
	public SpriteSortPoint spriteSortPoint { get; set; }

	// Methods

	// RVA: 0x249E540 Offset: 0x249D740 VA: 0x18249E540
	public void RegisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback) { }

	// RVA: 0x249E5E0 Offset: 0x249D7E0 VA: 0x18249E5E0
	public void UnregisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback) { }

	[RequiredByNativeCode]
	// RVA: 0x249E4C0 Offset: 0x249D6C0 VA: 0x18249E4C0
	private void InvokeSpriteChanged() { }

	[NativeMethod("ShouldSupportTiling")]
	// RVA: 0x249E820 Offset: 0x249DA20 VA: 0x18249E820
	internal bool get_shouldSupportTiling() { }

	// RVA: 0x249E940 Offset: 0x249DB40 VA: 0x18249E940
	public Sprite get_sprite() { }

	// RVA: 0x249ECA0 Offset: 0x249DEA0 VA: 0x18249ECA0
	public void set_sprite(Sprite value) { }

	// RVA: 0x249E720 Offset: 0x249D920 VA: 0x18249E720
	public SpriteDrawMode get_drawMode() { }

	// RVA: 0x249EAB0 Offset: 0x249DCB0 VA: 0x18249EAB0
	public void set_drawMode(SpriteDrawMode value) { }

	// RVA: 0x249E8B0 Offset: 0x249DAB0 VA: 0x18249E8B0
	public Vector2 get_size() { }

	// RVA: 0x249EC20 Offset: 0x249DE20 VA: 0x18249EC20
	public void set_size(Vector2 value) { }

	// RVA: 0x249E640 Offset: 0x249D840 VA: 0x18249E640
	public float get_adaptiveModeThreshold() { }

	// RVA: 0x249E9C0 Offset: 0x249DBC0 VA: 0x18249E9C0
	public void set_adaptiveModeThreshold(float value) { }

	// RVA: 0x249E980 Offset: 0x249DB80 VA: 0x18249E980
	public SpriteTileMode get_tileMode() { }

	// RVA: 0x249ECF0 Offset: 0x249DEF0 VA: 0x18249ECF0
	public void set_tileMode(SpriteTileMode value) { }

	// RVA: 0x249E6D0 Offset: 0x249D8D0 VA: 0x18249E6D0
	public Color get_color() { }

	// RVA: 0x249EA60 Offset: 0x249DC60 VA: 0x18249EA60
	public void set_color(Color value) { }

	// RVA: 0x249E7E0 Offset: 0x249D9E0 VA: 0x18249E7E0
	public SpriteMaskInteraction get_maskInteraction() { }

	// RVA: 0x249EB90 Offset: 0x249DD90 VA: 0x18249EB90
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	// RVA: 0x249E760 Offset: 0x249D960 VA: 0x18249E760
	public bool get_flipX() { }

	// RVA: 0x249EAF0 Offset: 0x249DCF0 VA: 0x18249EAF0
	public void set_flipX(bool value) { }

	// RVA: 0x249E7A0 Offset: 0x249D9A0 VA: 0x18249E7A0
	public bool get_flipY() { }

	// RVA: 0x249EB40 Offset: 0x249DD40 VA: 0x18249EB40
	public void set_flipY(bool value) { }

	// RVA: 0x249E900 Offset: 0x249DB00 VA: 0x18249E900
	public SpriteSortPoint get_spriteSortPoint() { }

	// RVA: 0x249EC60 Offset: 0x249DE60 VA: 0x18249EC60
	public void set_spriteSortPoint(SpriteSortPoint value) { }

	// RVA: 0x249E220 Offset: 0x249D420 VA: 0x18249E220
	private IntPtr GetCurrentMeshDataPtr() { }

	// RVA: 0x249E260 Offset: 0x249D460 VA: 0x18249E260
	internal Mesh.MeshDataArray GetCurrentMeshData() { }

	[NativeMethod(Name = "GetSpriteBounds")]
	// RVA: 0x249E460 Offset: 0x249D660 VA: 0x18249E460
	internal Bounds Internal_GetSpriteBounds(SpriteDrawMode mode) { }

	// RVA: 0x249E310 Offset: 0x249D510 VA: 0x18249E310
	internal void GetSecondaryTextureProperties(MaterialPropertyBlock mbp) { }

	// RVA: 0x249E360 Offset: 0x249D560 VA: 0x18249E360
	internal Bounds GetSpriteBounds() { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }

	// RVA: 0x249E860 Offset: 0x249DA60 VA: 0x18249E860
	private void get_size_Injected(out Vector2 ret) { }

	// RVA: 0x249EBD0 Offset: 0x249DDD0 VA: 0x18249EBD0
	private void set_size_Injected(ref Vector2 value) { }

	// RVA: 0x249E680 Offset: 0x249D880 VA: 0x18249E680
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x249EA10 Offset: 0x249DC10 VA: 0x18249EA10
	private void set_color_Injected(ref Color value) { }

	// RVA: 0x249E410 Offset: 0x249D610 VA: 0x18249E410
	private void Internal_GetSpriteBounds_Injected(SpriteDrawMode mode, out Bounds ret) { }
}

// Namespace: UnityEngine
public enum SpriteMeshType // TypeDefIndex: 14226
{
	// Fields
	public int value__; // 0x0
	public const SpriteMeshType FullRect = 0;
	public const SpriteMeshType Tight = 1;
}

// Namespace: UnityEngine
public enum SpritePackingMode // TypeDefIndex: 14227
{
	// Fields
	public int value__; // 0x0
	public const SpritePackingMode Tight = 0;
	public const SpritePackingMode Rectangle = 1;
}

// Namespace: UnityEngine
public enum SpritePackingRotation // TypeDefIndex: 14228
{
	// Fields
	public int value__; // 0x0
	public const SpritePackingRotation None = 0;
	public const SpritePackingRotation FlipHorizontal = 1;
	public const SpritePackingRotation FlipVertical = 2;
	public const SpritePackingRotation Rotate180 = 3;
	public const SpritePackingRotation Any = 15;
}

// Namespace: UnityEngine
public enum SpriteSortPoint // TypeDefIndex: 14229
{
	// Fields
	public int value__; // 0x0
	public const SpriteSortPoint Center = 0;
	public const SpriteSortPoint Pivot = 1;
}

// Namespace: UnityEngine
[Serializable]
public struct SecondarySpriteTexture // TypeDefIndex: 14230
{
	// Fields
	public string name; // 0x0
	public Texture2D texture; // 0x8
}

// Namespace: UnityEngine
[NativeType("Runtime/Graphics/SpriteFrame.h")]
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
public sealed class Sprite : Object // TypeDefIndex: 14231
{
	// Properties
	public Bounds bounds { get; }
	public Rect rect { get; }
	public Vector4 border { get; }
	public Texture2D texture { get; }
	public float pixelsPerUnit { get; }
	public float spriteAtlasTextureScale { get; }
	public Texture2D associatedAlphaSplitTexture { get; }
	public Vector2 pivot { get; }
	public bool packed { get; }
	public SpritePackingMode packingMode { get; }
	public SpritePackingRotation packingRotation { get; }
	public Rect textureRect { get; }
	public Vector2 textureRectOffset { get; }
	public Vector2[] vertices { get; }
	public ushort[] triangles { get; }
	public Vector2[] uv { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24A06B0 Offset: 0x249F8B0 VA: 0x1824A06B0
	private void .ctor() { }

	// RVA: 0x249FB80 Offset: 0x249ED80 VA: 0x18249FB80
	internal int GetPackingMode() { }

	// RVA: 0x249FBC0 Offset: 0x249EDC0 VA: 0x18249FBC0
	internal int GetPackingRotation() { }

	// RVA: 0x249FB40 Offset: 0x249ED40 VA: 0x18249FB40
	internal int GetPacked() { }

	// RVA: 0x24A0180 Offset: 0x249F380 VA: 0x1824A0180
	internal Rect GetTextureRect() { }

	// RVA: 0x24A00E0 Offset: 0x249F2E0 VA: 0x1824A00E0
	internal Vector2 GetTextureRectOffset() { }

	// RVA: 0x249FA50 Offset: 0x249EC50 VA: 0x18249FA50
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x249FAF0 Offset: 0x249ECF0 VA: 0x18249FAF0
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x249FC50 Offset: 0x249EE50 VA: 0x18249FC50
	internal Vector4 GetPadding() { }

	[FreeFunction("SpritesBindings::CreateSpriteWithoutTextureScripting")]
	// RVA: 0x249EDA0 Offset: 0x249DFA0 VA: 0x18249EDA0
	internal static Sprite CreateSpriteWithoutTextureScripting(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	[FreeFunction("SpritesBindings::CreateSprite", ThrowsException = True)]
	// RVA: 0x249EE80 Offset: 0x249E080 VA: 0x18249EE80
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x24A0830 Offset: 0x249FA30 VA: 0x1824A0830
	public Bounds get_bounds() { }

	// RVA: 0x24A0A00 Offset: 0x249FC00 VA: 0x1824A0A00
	public Rect get_rect() { }

	// RVA: 0x24A0790 Offset: 0x249F990 VA: 0x1824A0790
	public Vector4 get_border() { }

	// RVA: 0x24A0AF0 Offset: 0x249FCF0 VA: 0x1824A0AF0
	public Texture2D get_texture() { }

	// RVA: 0x24A0000 Offset: 0x249F200 VA: 0x1824A0000
	internal Texture2D GetSecondaryTexture(int index) { }

	// RVA: 0x249FFC0 Offset: 0x249F1C0 VA: 0x18249FFC0
	public int GetSecondaryTextureCount() { }

	[FreeFunction("SpritesBindings::GetSecondaryTextures", ThrowsException = True, HasExplicitThis = True)]
	// RVA: 0x24A0040 Offset: 0x249F240 VA: 0x1824A0040
	public int GetSecondaryTextures(SecondarySpriteTexture[] secondaryTexture) { }

	[NativeMethod("GetPixelsToUnits")]
	// RVA: 0x24A0970 Offset: 0x249FB70 VA: 0x1824A0970
	public float get_pixelsPerUnit() { }

	[NativeMethod("GetSpriteAtlasTextureScale")]
	// RVA: 0x24A0A50 Offset: 0x249FC50 VA: 0x1824A0A50
	public float get_spriteAtlasTextureScale() { }

	[NativeMethod("GetAlphaTexture")]
	// RVA: 0x24A0700 Offset: 0x249F900 VA: 0x1824A0700
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethod("GetPivotInPixels")]
	// RVA: 0x24A0920 Offset: 0x249FB20 VA: 0x1824A0920
	public Vector2 get_pivot() { }

	// RVA: 0x24A0890 Offset: 0x249FA90 VA: 0x1824A0890
	public bool get_packed() { }

	// RVA: 0x249FB80 Offset: 0x249ED80 VA: 0x18249FB80
	public SpritePackingMode get_packingMode() { }

	// RVA: 0x249FBC0 Offset: 0x249EDC0 VA: 0x18249FBC0
	public SpritePackingRotation get_packingRotation() { }

	// RVA: 0x24A0A90 Offset: 0x249FC90 VA: 0x1824A0A90
	public Rect get_textureRect() { }

	// RVA: 0x24A00E0 Offset: 0x249F2E0 VA: 0x1824A00E0
	public Vector2 get_textureRectOffset() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
	// RVA: 0x24A0BB0 Offset: 0x249FDB0 VA: 0x1824A0BB0
	public Vector2[] get_vertices() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
	// RVA: 0x24A0B30 Offset: 0x249FD30 VA: 0x1824A0B30
	public ushort[] get_triangles() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
	// RVA: 0x24A0B70 Offset: 0x249FD70 VA: 0x1824A0B70
	public Vector2[] get_uv() { }

	// RVA: 0x249FCA0 Offset: 0x249EEA0 VA: 0x18249FCA0
	public int GetPhysicsShapeCount() { }

	// RVA: 0x249FD30 Offset: 0x249EF30 VA: 0x18249FD30
	public int GetPhysicsShapePointCount(int shapeIdx) { }

	[NativeMethod("GetPhysicsShapePointCount")]
	// RVA: 0x24A01D0 Offset: 0x249F3D0 VA: 0x1824A01D0
	private int Internal_GetPhysicsShapePointCount(int shapeIdx) { }

	// RVA: 0x249FE60 Offset: 0x249F060 VA: 0x18249FE60
	public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape) { }

	[FreeFunction("SpritesBindings::GetPhysicsShape", ThrowsException = True)]
	// RVA: 0x249FCE0 Offset: 0x249EEE0 VA: 0x18249FCE0
	private static void GetPhysicsShapeImpl(Sprite sprite, int shapeIdx, List<Vector2> physicsShape) { }

	// RVA: 0x24A0310 Offset: 0x249F510 VA: 0x1824A0310
	public void OverridePhysicsShape(IList<Vector2[]> physicsShapes) { }

	[FreeFunction("SpritesBindings::OverridePhysicsShapeCount")]
	// RVA: 0x24A0270 Offset: 0x249F470 VA: 0x1824A0270
	private static void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount) { }

	[FreeFunction("SpritesBindings::OverridePhysicsShape", ThrowsException = True)]
	// RVA: 0x24A02B0 Offset: 0x249F4B0 VA: 0x1824A02B0
	private static void OverridePhysicsShape(Sprite sprite, Vector2[] physicsShape, int idx) { }

	[FreeFunction("SpritesBindings::OverrideGeometry", HasExplicitThis = True)]
	// RVA: 0x24A0210 Offset: 0x249F410 VA: 0x1824A0210
	public void OverrideGeometry(Vector2[] vertices, ushort[] triangles) { }

	// RVA: 0x249F8D0 Offset: 0x249EAD0 VA: 0x18249F8D0
	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	// RVA: 0x249F230 Offset: 0x249E430 VA: 0x18249F230
	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits) { }

	// RVA: 0x249F1C0 Offset: 0x249E3C0 VA: 0x18249F1C0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x249F290 Offset: 0x249E490 VA: 0x18249F290
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	// RVA: 0x249EF20 Offset: 0x249E120 VA: 0x18249EF20
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x249EF80 Offset: 0x249E180 VA: 0x18249EF80
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	// RVA: 0x249F930 Offset: 0x249EB30 VA: 0x18249F930
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	// RVA: 0x249F100 Offset: 0x249E300 VA: 0x18249F100
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x249F050 Offset: 0x249E250 VA: 0x18249F050
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x24A0130 Offset: 0x249F330 VA: 0x1824A0130
	private void GetTextureRect_Injected(out Rect ret) { }

	// RVA: 0x24A0090 Offset: 0x249F290 VA: 0x1824A0090
	private void GetTextureRectOffset_Injected(out Vector2 ret) { }

	// RVA: 0x249FA00 Offset: 0x249EC00 VA: 0x18249FA00
	private void GetInnerUVs_Injected(out Vector4 ret) { }

	// RVA: 0x249FAA0 Offset: 0x249ECA0 VA: 0x18249FAA0
	private void GetOuterUVs_Injected(out Vector4 ret) { }

	// RVA: 0x249FC00 Offset: 0x249EE00 VA: 0x18249FC00
	private void GetPadding_Injected(out Vector4 ret) { }

	// RVA: 0x249ED30 Offset: 0x249DF30 VA: 0x18249ED30
	private static Sprite CreateSpriteWithoutTextureScripting_Injected(ref Rect rect, ref Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	// RVA: 0x249EE00 Offset: 0x249E000 VA: 0x18249EE00
	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x24A07E0 Offset: 0x249F9E0 VA: 0x1824A07E0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x24A09B0 Offset: 0x249FBB0 VA: 0x1824A09B0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x24A0740 Offset: 0x249F940 VA: 0x1824A0740
	private void get_border_Injected(out Vector4 ret) { }

	// RVA: 0x24A08D0 Offset: 0x249FAD0 VA: 0x1824A08D0
	private void get_pivot_Injected(out Vector2 ret) { }
}

// Namespace: UnityEngine._Scripting.APIUpdating
internal class APIUpdaterRuntimeHelpers // TypeDefIndex: 14232
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x248BD50 Offset: 0x248AF50 VA: 0x18248BD50
	internal static bool GetMovedFromAttributeDataForType(Type sourceType, out string assembly, out string nsp, out string klass) { }

	[RequiredByNativeCode]
	// RVA: 0x248BEB0 Offset: 0x248B0B0 VA: 0x18248BEB0
	internal static bool GetObsoleteTypeRedirection(Type sourceType, out string assemblyName, out string nsp, out string className) { }
}

// Namespace: UnityEngine.Sprites
public sealed class DataUtility // TypeDefIndex: 14233
{
	// Methods

	// RVA: 0x248E510 Offset: 0x248D710 VA: 0x18248E510
	public static Vector4 GetInnerUV(Sprite sprite) { }

	// RVA: 0x248E690 Offset: 0x248D890 VA: 0x18248E690
	public static Vector4 GetOuterUV(Sprite sprite) { }

	// RVA: 0x248E700 Offset: 0x248D900 VA: 0x18248E700
	public static Vector4 GetPadding(Sprite sprite) { }

	// RVA: 0x248E580 Offset: 0x248D780 VA: 0x18248E580
	public static Vector2 GetMinSize(Sprite sprite) { }
}

// Namespace: UnityEngine.U2D
[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
[NativeType(1, "ScriptingSpriteBone")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[MovedFrom("UnityEngine.Experimental.U2D")]
[RequiredByNativeCode]
[Serializable]
public struct SpriteBone // TypeDefIndex: 14234
{
	// Fields
	[NativeName("name")]
	[SerializeField]
	private string m_Name; // 0x0
	[NativeName("guid")]
	[SerializeField]
	private string m_Guid; // 0x8
	[SerializeField]
	[NativeName("position")]
	private Vector3 m_Position; // 0x10
	[SerializeField]
	[NativeName("rotation")]
	private Quaternion m_Rotation; // 0x1C
	[NativeName("length")]
	[SerializeField]
	private float m_Length; // 0x2C
	[SerializeField]
	[NativeName("parentId")]
	private int m_ParentId; // 0x30
	[SerializeField]
	[NativeName("color")]
	private Color32 m_Color; // 0x34
}

// Namespace: UnityEngine.U2D
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
[StaticAccessor("GetSpriteAtlasManager()", 0)]
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
public class SpriteAtlasManager // TypeDefIndex: 14235
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string, Action<SpriteAtlas>> atlasRequested; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<SpriteAtlas> atlasRegistered; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x249DF10 Offset: 0x249D110 VA: 0x18249DF10
	private static bool RequestAtlas(string tag) { }

	[CompilerGenerated]
	// RVA: 0x249DFC0 Offset: 0x249D1C0 VA: 0x18249DFC0
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGenerated]
	// RVA: 0x249E0A0 Offset: 0x249D2A0 VA: 0x18249E0A0
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[RequiredByNativeCode]
	// RVA: 0x249DE70 Offset: 0x249D070 VA: 0x18249DE70
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x249DED0 Offset: 0x249D0D0 VA: 0x18249DED0
	internal static void Register(SpriteAtlas spriteAtlas) { }
}

// Namespace: UnityEngine.U2D
[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
public class SpriteAtlas : Object // TypeDefIndex: 14236
{
	// Methods

	// RVA: 0x249E180 Offset: 0x249D380 VA: 0x18249E180
	public bool CanBindTo(Sprite sprite) { }

	// RVA: 0x249E1D0 Offset: 0x249D3D0 VA: 0x18249E1D0
	public Sprite GetSprite(string name) { }
}

// Namespace: UnityEngine.Profiling
[NativeHeader("Runtime/Profiler/Profiler.h")]
[NativeHeader("Runtime/Profiler/MemoryProfiler.h")]
[NativeHeader("Runtime/Allocator/MemoryManager.h")]
[MovedFrom("UnityEngine")]
[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
public sealed class Profiler // TypeDefIndex: 14237
{
	// Methods

	[NativeMethod(Name = "scripting_gc_get_used_size", IsFreeFunction = True)]
	// RVA: 0x2499100 Offset: 0x2498300 VA: 0x182499100
	public static long GetMonoUsedSizeLong() { }
}

// Namespace: UnityEngine.Windows
[NativeHeader("PlatformDependent/Win/Bindings/InputBindings.h")]
public static class Input // TypeDefIndex: 14238
{
	// Methods

	[ThreadSafe]
	[NativeName("ForwardRawInput")]
	[StaticAccessor("", 2)]
	// RVA: 0x2492550 Offset: 0x2491750 VA: 0x182492550
	private static void ForwardRawInputImpl(uint* rawInputHeaderIndices, uint* rawInputDataIndices, uint indicesCount, byte* rawInputData, uint rawInputDataSize) { }

	// RVA: 0x2492720 Offset: 0x2491920 VA: 0x182492720
	public static void ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize) { }

	// RVA: 0x24925C0 Offset: 0x24917C0 VA: 0x1824925C0
	public static void ForwardRawInput(uint* rawInputHeaderIndices, uint* rawInputDataIndices, uint indicesCount, byte* rawInputData, uint rawInputDataSize) { }
}

// Namespace: 
public sealed class PhraseRecognitionSystem.ErrorDelegate : MulticastDelegate // TypeDefIndex: 14239
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(SpeechError errorCode) { }
}

// Namespace: 
public sealed class PhraseRecognitionSystem.StatusDelegate : MulticastDelegate // TypeDefIndex: 14240
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(SpeechSystemStatus status) { }
}

// Namespace: UnityEngine.Windows.Speech
public static class PhraseRecognitionSystem // TypeDefIndex: 14241
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static PhraseRecognitionSystem.ErrorDelegate OnError; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static PhraseRecognitionSystem.StatusDelegate OnStatusChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2498600 Offset: 0x2497800 VA: 0x182498600
	private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) { }

	[RequiredByNativeCode]
	// RVA: 0x2498660 Offset: 0x2497860 VA: 0x182498660
	private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) { }
}

// Namespace: 
public sealed class PhraseRecognizer.PhraseRecognizedDelegate : MulticastDelegate // TypeDefIndex: 14242
{
	// Methods

	// RVA: 0x11B9750 Offset: 0x11B8950 VA: 0x1811B9750
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB86000 Offset: 0xB85200 VA: 0x180B86000 Slot: 13
	public virtual void Invoke(PhraseRecognizedEventArgs args) { }
}

// Namespace: UnityEngine.Windows.Speech
public abstract class PhraseRecognizer // TypeDefIndex: 14243
{
	// Fields
	protected IntPtr m_Recognizer; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24986E0 Offset: 0x24978E0 VA: 0x1824986E0
	private void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks) { }

	[RequiredByNativeCode]
	// RVA: 0x2498810 Offset: 0x2497A10 VA: 0x182498810
	private static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount) { }
}

// Namespace: 
public sealed class DictationRecognizer.DictationHypothesisDelegate : MulticastDelegate // TypeDefIndex: 14244
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(string text) { }
}

// Namespace: 
public sealed class DictationRecognizer.DictationResultDelegate : MulticastDelegate // TypeDefIndex: 14245
{
	// Methods

	// RVA: 0x83FC90 Offset: 0x83EE90 VA: 0x18083FC90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(string text, ConfidenceLevel confidence) { }
}

// Namespace: 
public sealed class DictationRecognizer.DictationCompletedDelegate : MulticastDelegate // TypeDefIndex: 14246
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(DictationCompletionCause cause) { }
}

// Namespace: 
public sealed class DictationRecognizer.DictationErrorHandler : MulticastDelegate // TypeDefIndex: 14247
{
	// Methods

	// RVA: 0x83FC90 Offset: 0x83EE90 VA: 0x18083FC90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(string error, int hresult) { }
}

// Namespace: UnityEngine.Windows.Speech
public sealed class DictationRecognizer // TypeDefIndex: 14248
{
	// Fields
	private IntPtr m_Recognizer; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DictationRecognizer.DictationHypothesisDelegate DictationHypothesis; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DictationRecognizer.DictationResultDelegate DictationResult; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DictationRecognizer.DictationCompletedDelegate DictationComplete; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DictationRecognizer.DictationErrorHandler DictationError; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3FDCC0 Offset: 0x3FCEC0 VA: 0x1803FDCC0
	private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword) { }

	[RequiredByNativeCode]
	// RVA: 0x248E7B0 Offset: 0x248D9B0 VA: 0x18248E7B0
	private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence) { }

	[RequiredByNativeCode]
	// RVA: 0x248E770 Offset: 0x248D970 VA: 0x18248E770
	private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause) { }

	[RequiredByNativeCode]
	// RVA: 0x248E790 Offset: 0x248D990 VA: 0x18248E790
	private void DictationRecognizer_InvokeErrorEvent(string error, int hresult) { }
}

// Namespace: UnityEngine.Windows.Speech
public enum ConfidenceLevel // TypeDefIndex: 14249
{
	// Fields
	public int value__; // 0x0
	public const ConfidenceLevel High = 0;
	public const ConfidenceLevel Medium = 1;
	public const ConfidenceLevel Low = 2;
	public const ConfidenceLevel Rejected = 3;
}

// Namespace: UnityEngine.Windows.Speech
public enum SpeechSystemStatus // TypeDefIndex: 14250
{
	// Fields
	public int value__; // 0x0
	public const SpeechSystemStatus Stopped = 0;
	public const SpeechSystemStatus Running = 1;
	public const SpeechSystemStatus Failed = 2;
}

// Namespace: UnityEngine.Windows.Speech
public enum SpeechError // TypeDefIndex: 14251
{
	// Fields
	public int value__; // 0x0
	public const SpeechError NoError = 0;
	public const SpeechError TopicLanguageNotSupported = 1;
	public const SpeechError GrammarLanguageMismatch = 2;
	public const SpeechError GrammarCompilationFailure = 3;
	public const SpeechError AudioQualityFailure = 4;
	public const SpeechError PauseLimitExceeded = 5;
	public const SpeechError TimeoutExceeded = 6;
	public const SpeechError NetworkFailure = 7;
	public const SpeechError MicrophoneUnavailable = 8;
	public const SpeechError UnknownError = 9;
}

// Namespace: UnityEngine.Windows.Speech
public enum DictationCompletionCause // TypeDefIndex: 14252
{
	// Fields
	public int value__; // 0x0
	public const DictationCompletionCause Complete = 0;
	public const DictationCompletionCause AudioQualityFailure = 1;
	public const DictationCompletionCause Canceled = 2;
	public const DictationCompletionCause TimeoutExceeded = 3;
	public const DictationCompletionCause PauseLimitExceeded = 4;
	public const DictationCompletionCause NetworkFailure = 5;
	public const DictationCompletionCause MicrophoneUnavailable = 6;
	public const DictationCompletionCause UnknownError = 7;
}

// Namespace: UnityEngine.Windows.Speech
public struct SemanticMeaning // TypeDefIndex: 14253
{
	// Fields
	public string key; // 0x0
	public string[] values; // 0x8
}

// Namespace: UnityEngine.Windows.Speech
public struct PhraseRecognizedEventArgs // TypeDefIndex: 14254
{
	// Fields
	public readonly ConfidenceLevel confidence; // 0x0
	public readonly SemanticMeaning[] semanticMeanings; // 0x8
	public readonly string text; // 0x10
	public readonly DateTime phraseStartTime; // 0x18
	public readonly TimeSpan phraseDuration; // 0x20

	// Methods

	// RVA: 0x24986C0 Offset: 0x24978C0 VA: 0x1824986C0
	internal void .ctor(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration) { }
}

// Namespace: 
public enum PhotoCapture.CaptureResultType // TypeDefIndex: 14255
{
	// Fields
	public int value__; // 0x0
	public const PhotoCapture.CaptureResultType Success = 0;
	public const PhotoCapture.CaptureResultType UnknownError = 1;
}

// Namespace: 
public struct PhotoCapture.PhotoCaptureResult // TypeDefIndex: 14256
{
	// Fields
	public PhotoCapture.CaptureResultType resultType; // 0x0
	public long hResult; // 0x8
}

// Namespace: 
public sealed class PhotoCapture.OnCaptureResourceCreatedCallback : MulticastDelegate // TypeDefIndex: 14257
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(PhotoCapture captureObject) { }
}

// Namespace: 
public sealed class PhotoCapture.OnPhotoModeStartedCallback : MulticastDelegate // TypeDefIndex: 14258
{
	// Methods

	// RVA: 0xCE0B20 Offset: 0xCDFD20 VA: 0x180CE0B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0 Slot: 13
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }
}

// Namespace: 
public sealed class PhotoCapture.OnPhotoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 14259
{
	// Methods

	// RVA: 0xCE0B20 Offset: 0xCDFD20 VA: 0x180CE0B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0 Slot: 13
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }
}

// Namespace: 
public sealed class PhotoCapture.OnCapturedToDiskCallback : MulticastDelegate // TypeDefIndex: 14260
{
	// Methods

	// RVA: 0xCE0B20 Offset: 0xCDFD20 VA: 0x180CE0B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0 Slot: 13
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }
}

// Namespace: 
public sealed class PhotoCapture.OnCapturedToMemoryCallback : MulticastDelegate // TypeDefIndex: 14261
{
	// Methods

	// RVA: 0x442220 Offset: 0x441420 VA: 0x180442220
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4421F0 Offset: 0x4413F0 VA: 0x1804421F0 Slot: 13
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame) { }
}

// Namespace: UnityEngine.Windows.WebCam
[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[StaticAccessor("PhotoCapture", 2)]
[NativeHeader("PlatformDependent/Win/Webcam/PhotoCapture.h")]
public class PhotoCapture : IDisposable // TypeDefIndex: 14262
{
	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x2498590 Offset: 0x2497790 VA: 0x182498590
	private static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x24984D0 Offset: 0x24976D0 VA: 0x1824984D0
	private static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCode]
	// RVA: 0x2498260 Offset: 0x2497460 VA: 0x182498260
	private static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2498260 Offset: 0x2497460 VA: 0x182498260
	private static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2498260 Offset: 0x2497460 VA: 0x182498260
	private static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2498300 Offset: 0x2497500 VA: 0x182498300
	private static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	// RVA: 0x2498130 Offset: 0x2497330 VA: 0x182498130 Slot: 4
	public void Dispose() { }

	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("Dispose")]
	// RVA: 0x24980F0 Offset: 0x24972F0 VA: 0x1824980F0
	private void Dispose_Internal() { }

	// RVA: 0x24981C0 Offset: 0x24973C0 VA: 0x1824981C0 Slot: 1
	protected override void Finalize() { }

	[ThreadAndSerializationSafe]
	[NativeName("DisposeThreaded")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	// RVA: 0x24980B0 Offset: 0x24972B0 VA: 0x1824980B0
	private void DisposeThreaded_Internal() { }
}

// Namespace: UnityEngine.Windows.WebCam
[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeHeader("PlatformDependent/Win/Webcam/PhotoCaptureFrame.h")]
public sealed class PhotoCaptureFrame : IDisposable // TypeDefIndex: 14263
{
	// Fields
	private IntPtr m_NativePtr; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <dataLength>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <hasLocationData>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private CapturePixelFormat <pixelFormat>k__BackingField; // 0x20

	// Properties
	public int dataLength { get; set; }
	private bool hasLocationData { set; }
	private CapturePixelFormat pixelFormat { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_dataLength() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	private void set_dataLength(int value) { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	private void set_hasLocationData(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	private void set_pixelFormat(CapturePixelFormat value) { }

	[ThreadAndSerializationSafe]
	// RVA: 0x2497F50 Offset: 0x2497150 VA: 0x182497F50
	private int GetDataLength() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x2497F90 Offset: 0x2497190 VA: 0x182497F90
	private bool GetHasLocationData() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x2497F10 Offset: 0x2497110 VA: 0x182497F10
	private CapturePixelFormat GetCapturePixelFormat() { }

	// RVA: 0x2497FD0 Offset: 0x24971D0 VA: 0x182497FD0
	internal void .ctor(IntPtr nativePtr) { }

	// RVA: 0x2497D70 Offset: 0x2496F70 VA: 0x182497D70
	private void Cleanup() { }

	[ThreadAndSerializationSafe]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("Dispose")]
	// RVA: 0x2497E10 Offset: 0x2497010 VA: 0x182497E10
	private void Dispose_Internal() { }

	// RVA: 0x2497E50 Offset: 0x2497050 VA: 0x182497E50 Slot: 4
	public void Dispose() { }

	// RVA: 0x2497EB0 Offset: 0x24970B0 VA: 0x182497EB0 Slot: 1
	protected override void Finalize() { }
}

// Namespace: 
public enum VideoCapture.CaptureResultType // TypeDefIndex: 14264
{
	// Fields
	public int value__; // 0x0
	public const VideoCapture.CaptureResultType Success = 0;
	public const VideoCapture.CaptureResultType UnknownError = 1;
}

// Namespace: 
public struct VideoCapture.VideoCaptureResult // TypeDefIndex: 14265
{
	// Fields
	public VideoCapture.CaptureResultType resultType; // 0x0
	public long hResult; // 0x8
}

// Namespace: 
public sealed class VideoCapture.OnVideoCaptureResourceCreatedCallback : MulticastDelegate // TypeDefIndex: 14266
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(VideoCapture captureObject) { }
}

// Namespace: 
public sealed class VideoCapture.OnVideoModeStartedCallback : MulticastDelegate // TypeDefIndex: 14267
{
	// Methods

	// RVA: 0xCE0B20 Offset: 0xCDFD20 VA: 0x180CE0B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0 Slot: 13
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }
}

// Namespace: 
public sealed class VideoCapture.OnVideoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 14268
{
	// Methods

	// RVA: 0xCE0B20 Offset: 0xCDFD20 VA: 0x180CE0B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0 Slot: 13
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }
}

// Namespace: 
public sealed class VideoCapture.OnStartedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 14269
{
	// Methods

	// RVA: 0xCE0B20 Offset: 0xCDFD20 VA: 0x180CE0B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0 Slot: 13
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }
}

// Namespace: 
public sealed class VideoCapture.OnStoppedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 14270
{
	// Methods

	// RVA: 0xCE0B20 Offset: 0xCDFD20 VA: 0x180CE0B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0 Slot: 13
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }
}

// Namespace: UnityEngine.Windows.WebCam
[NativeHeader("PlatformDependent/Win/Webcam/VideoCaptureBindings.h")]
[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[StaticAccessor("VideoCaptureBindings", 2)]
public class VideoCapture : IDisposable // TypeDefIndex: 14271
{
	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x24ABEE0 Offset: 0x24AB0E0 VA: 0x1824ABEE0
	private static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x24ABD80 Offset: 0x24AAF80 VA: 0x1824ABD80
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCode]
	// RVA: 0x24ABE40 Offset: 0x24AB040 VA: 0x1824ABE40
	private static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x24ABE40 Offset: 0x24AB040 VA: 0x1824ABE40
	private static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x24ABE40 Offset: 0x24AB040 VA: 0x1824ABE40
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x24ABE40 Offset: 0x24AB040 VA: 0x1824ABE40
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult) { }

	// RVA: 0x24ABC50 Offset: 0x24AAE50 VA: 0x1824ABC50 Slot: 4
	public void Dispose() { }

	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::Dispose", HasExplicitThis = True)]
	// RVA: 0x24ABC10 Offset: 0x24AAE10 VA: 0x1824ABC10
	private void Dispose_Internal() { }

	// RVA: 0x24ABCE0 Offset: 0x24AAEE0 VA: 0x1824ABCE0 Slot: 1
	protected override void Finalize() { }

	[ThreadAndSerializationSafe]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::DisposeThreaded", HasExplicitThis = True)]
	// RVA: 0x24ABBD0 Offset: 0x24AADD0 VA: 0x1824ABBD0
	private void DisposeThreaded_Internal() { }
}

// Namespace: UnityEngine.Windows.WebCam
[MovedFrom("UnityEngine.XR.WSA.WebCam")]
public enum CapturePixelFormat // TypeDefIndex: 14272
{
	// Fields
	public int value__; // 0x0
	public const CapturePixelFormat BGRA32 = 0;
	public const CapturePixelFormat NV12 = 1;
	public const CapturePixelFormat JPEG = 2;
	public const CapturePixelFormat PNG = 3;
}

// Namespace: UnityEngine.Events
[Serializable]
public enum PersistentListenerMode // TypeDefIndex: 14273
{
	// Fields
	public int value__; // 0x0
	public const PersistentListenerMode EventDefined = 0;
	public const PersistentListenerMode Void = 1;
	public const PersistentListenerMode Object = 2;
	public const PersistentListenerMode Int = 3;
	public const PersistentListenerMode Float = 4;
	public const PersistentListenerMode String = 5;
	public const PersistentListenerMode Bool = 6;
}

// Namespace: UnityEngine.Events
internal class UnityEventTools // TypeDefIndex: 14274
{
	// Methods

	// RVA: 0x24AA6B0 Offset: 0x24A98B0 VA: 0x1824AA6B0
	internal static string TidyAssemblyTypeName(string assemblyTypeName) { }
}

// Namespace: UnityEngine.Events
[Serializable]
internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 14275
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("objectArgument")]
	private Object m_ObjectArgument; // 0x10
	[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
	[SerializeField]
	private string m_ObjectArgumentAssemblyTypeName; // 0x18
	[SerializeField]
	[FormerlySerializedAs("intArgument")]
	private int m_IntArgument; // 0x20
	[FormerlySerializedAs("floatArgument")]
	[SerializeField]
	private float m_FloatArgument; // 0x24
	[SerializeField]
	[FormerlySerializedAs("stringArgument")]
	private string m_StringArgument; // 0x28
	[SerializeField]
	private bool m_BoolArgument; // 0x30

	// Properties
	public Object unityObjectArgument { get; }
	public string unityObjectArgumentAssemblyTypeName { get; }
	public int intArgument { get; }
	public float floatArgument { get; }
	public string stringArgument { get; }
	public bool boolArgument { get; }

	// Methods

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	public Object get_unityObjectArgument() { }

	// RVA: 0x248C210 Offset: 0x248B410 VA: 0x18248C210
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0xC9F3A0 Offset: 0xC9E5A0 VA: 0x180C9F3A0
	public int get_intArgument() { }

	// RVA: 0x248C1F0 Offset: 0x248B3F0 VA: 0x18248C1F0
	public float get_floatArgument() { }

	// RVA: 0x248C200 Offset: 0x248B400 VA: 0x18248C200
	public string get_stringArgument() { }

	// RVA: 0x248C1E0 Offset: 0x248B3E0 VA: 0x18248C1E0
	public bool get_boolArgument() { }

	// RVA: 0x248C1C0 Offset: 0x248B3C0 VA: 0x18248C1C0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x248C1C0 Offset: 0x248B3C0 VA: 0x18248C1C0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Events
internal abstract class BaseInvokableCall // TypeDefIndex: 14276
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x248D860 Offset: 0x248CA60 VA: 0x18248D860
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(object[] args);

	// RVA: -1 Offset: -1
	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9441B0 Offset: 0x9433B0 VA: 0x1809441B0
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|-BaseInvokableCall.ThrowOnInvalidArg<Color>
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|-BaseInvokableCall.ThrowOnInvalidArg<Int32Enum>
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector2>
	|-BaseInvokableCall.ThrowOnInvalidArg<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x248D730 Offset: 0x248C930 VA: 0x18248D730
	protected static bool AllowInvoke(Delegate delegate) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Find(object targetObj, MethodInfo method);
}

// Namespace: UnityEngine.Events
internal class InvokableCall : BaseInvokableCall // TypeDefIndex: 14277
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UnityAction Delegate; // 0x10

	// Methods

	[CompilerGenerated]
	// RVA: 0x24931C0 Offset: 0x24923C0 VA: 0x1824931C0
	private void add_Delegate(UnityAction value) { }

	[CompilerGenerated]
	// RVA: 0x2493260 Offset: 0x2492460 VA: 0x182493260
	private void remove_Delegate(UnityAction value) { }

	// RVA: 0x2492FC0 Offset: 0x24921C0 VA: 0x182492FC0
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x2492F90 Offset: 0x2492190 VA: 0x182492F90
	public void .ctor(UnityAction action) { }

	// RVA: 0x2492F40 Offset: 0x2492140 VA: 0x182492F40 Slot: 4
	public override void Invoke(object[] args) { }

	// RVA: 0x2492F40 Offset: 0x2492140 VA: 0x182492F40
	public void Invoke() { }

	// RVA: 0x12AE020 Offset: 0x12AD220 VA: 0x1812AE020 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1> : BaseInvokableCall // TypeDefIndex: 14278
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UnityAction<T1> Delegate; // 0x0

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void add_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AF530 Offset: 0x12AE730 VA: 0x1812AF530
	|-InvokableCall<bool>.add_Delegate
	|-InvokableCall<Color>.add_Delegate
	|-InvokableCall<int>.add_Delegate
	|-InvokableCall<Int32Enum>.add_Delegate
	|-InvokableCall<object>.add_Delegate
	|-InvokableCall<float>.add_Delegate
	|-InvokableCall<Vector2>.add_Delegate
	|-InvokableCall<__Il2CppFullySharedGenericType>.add_Delegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void remove_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AF600 Offset: 0x12AE800 VA: 0x1812AF600
	|-InvokableCall<bool>.remove_Delegate
	|-InvokableCall<Color>.remove_Delegate
	|-InvokableCall<int>.remove_Delegate
	|-InvokableCall<Int32Enum>.remove_Delegate
	|-InvokableCall<object>.remove_Delegate
	|-InvokableCall<float>.remove_Delegate
	|-InvokableCall<Vector2>.remove_Delegate
	|-InvokableCall<__Il2CppFullySharedGenericType>.remove_Delegate
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AED60 Offset: 0x12ADF60 VA: 0x1812AED60
	|-InvokableCall<bool>..ctor
	|
	|-RVA: 0x12AEF90 Offset: 0x12AE190 VA: 0x1812AEF90
	|-InvokableCall<Color>..ctor
	|
	|-RVA: 0x12AF200 Offset: 0x12AE400 VA: 0x1812AF200
	|-InvokableCall<int>..ctor
	|
	|-RVA: 0x12AF0F0 Offset: 0x12AE2F0 VA: 0x1812AF0F0
	|-InvokableCall<Int32Enum>..ctor
	|
	|-RVA: 0x12AF420 Offset: 0x12AE620 VA: 0x1812AF420
	|-InvokableCall<object>..ctor
	|
	|-RVA: 0x12AF310 Offset: 0x12AE510 VA: 0x1812AF310
	|-InvokableCall<float>..ctor
	|
	|-RVA: 0x12AEC50 Offset: 0x12ADE50 VA: 0x1812AEC50
	|-InvokableCall<Vector2>..ctor
	|
	|-RVA: 0x12AEE70 Offset: 0x12AE070 VA: 0x1812AEE70
	|-InvokableCall<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T1> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AEC00 Offset: 0x12ADE00 VA: 0x1812AEC00
	|-InvokableCall<bool>..ctor
	|-InvokableCall<Color>..ctor
	|-InvokableCall<int>..ctor
	|-InvokableCall<Int32Enum>..ctor
	|-InvokableCall<object>..ctor
	|-InvokableCall<float>..ctor
	|-InvokableCall<Vector2>..ctor
	|
	|-RVA: 0x12AF0A0 Offset: 0x12AE2A0 VA: 0x1812AF0A0
	|-InvokableCall<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AE870 Offset: 0x12ADA70 VA: 0x1812AE870
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x12AE6F0 Offset: 0x12AD8F0 VA: 0x1812AE6F0
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x12AEA90 Offset: 0x12ADC90 VA: 0x1812AEA90
	|-InvokableCall<int>.Invoke
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x12AE0E0 Offset: 0x12AD2E0 VA: 0x1812AE0E0
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x12AE440 Offset: 0x12AD640 VA: 0x1812AE440
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x12AE5C0 Offset: 0x12AD7C0 VA: 0x1812AE5C0
	|-InvokableCall<Vector2>.Invoke
	|
	|-RVA: 0x12AE260 Offset: 0x12AD460 VA: 0x1812AE260
	|-InvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual void Invoke(T1 args0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AE3F0 Offset: 0x12AD5F0 VA: 0x1812AE3F0
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x12AE560 Offset: 0x12AD760 VA: 0x1812AE560
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x12AE090 Offset: 0x12AD290 VA: 0x1812AE090
	|-InvokableCall<int>.Invoke
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x12AE210 Offset: 0x12AD410 VA: 0x1812AE210
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x12AEBB0 Offset: 0x12ADDB0 VA: 0x1812AEBB0
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x12AE820 Offset: 0x12ADA20 VA: 0x1812AE820
	|-InvokableCall<Vector2>.Invoke
	|
	|-RVA: 0x12AE990 Offset: 0x12ADB90 VA: 0x1812AE990
	|-InvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AE020 Offset: 0x12AD220 VA: 0x1812AE020
	|-InvokableCall<bool>.Find
	|-InvokableCall<Color>.Find
	|-InvokableCall<int>.Find
	|-InvokableCall<Int32Enum>.Find
	|-InvokableCall<object>.Find
	|-InvokableCall<float>.Find
	|-InvokableCall<Vector2>.Find
	|-InvokableCall<__Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2> : BaseInvokableCall // TypeDefIndex: 14279
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UnityAction<T1, T2> Delegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AFEE0 Offset: 0x12AF0E0 VA: 0x1812AFEE0
	|-InvokableCall<int, bool>..ctor
	|
	|-RVA: 0x12B0160 Offset: 0x12AF360 VA: 0x1812B0160
	|-InvokableCall<int, float>..ctor
	|
	|-RVA: 0x12B0020 Offset: 0x12AF220 VA: 0x1812B0020
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AFB40 Offset: 0x12AED40 VA: 0x1812AFB40
	|-InvokableCall<int, bool>.Invoke
	|
	|-RVA: 0x12AF980 Offset: 0x12AEB80 VA: 0x1812AF980
	|-InvokableCall<int, float>.Invoke
	|
	|-RVA: 0x12AF730 Offset: 0x12AE930 VA: 0x1812AF730
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 args0, T2 args1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AF6D0 Offset: 0x12AE8D0 VA: 0x1812AF6D0
	|-InvokableCall<int, bool>.Invoke
	|
	|-RVA: 0x12AFE80 Offset: 0x12AF080 VA: 0x1812AFE80
	|-InvokableCall<int, float>.Invoke
	|
	|-RVA: 0x12AFCF0 Offset: 0x12AEEF0 VA: 0x1812AFCF0
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AE020 Offset: 0x12AD220 VA: 0x1812AE020
	|-InvokableCall<int, bool>.Find
	|-InvokableCall<int, float>.Find
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2, T3> : BaseInvokableCall // TypeDefIndex: 14280
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UnityAction<T1, T2, T3> Delegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B0A90 Offset: 0x12AFC90 VA: 0x1812B0A90
	|-InvokableCall<object, int, int>..ctor
	|
	|-RVA: 0x12B0BD0 Offset: 0x12AFDD0 VA: 0x1812B0BD0
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B0840 Offset: 0x12AFA40 VA: 0x1812B0840
	|-InvokableCall<object, int, int>.Invoke
	|
	|-RVA: 0x12B04C0 Offset: 0x12AF6C0 VA: 0x1812B04C0
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 args0, T2 args1, T3 args2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B07D0 Offset: 0x12AF9D0 VA: 0x1812B07D0
	|-InvokableCall<object, int, int>.Invoke
	|
	|-RVA: 0x12B02A0 Offset: 0x12AF4A0 VA: 0x1812B02A0
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AE020 Offset: 0x12AD220 VA: 0x1812AE020
	|-InvokableCall<object, int, int>.Find
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall // TypeDefIndex: 14281
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UnityAction<T1, T2, T3, T4> Delegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B10D0 Offset: 0x12B02D0 VA: 0x1812B10D0
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B0D10 Offset: 0x12AFF10 VA: 0x1812B0D10
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AE020 Offset: 0x12AD220 VA: 0x1812AE020
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class CachedInvokableCall<T> : InvokableCall<T> // TypeDefIndex: 14282
{
	// Fields
	private readonly T m_Arg1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Object target, MethodInfo theFunction, T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFA8B0 Offset: 0xEF9AB0 VA: 0x180EFA8B0
	|-CachedInvokableCall<bool>..ctor
	|
	|-RVA: 0xEFAA10 Offset: 0xEF9C10 VA: 0x180EFAA10
	|-CachedInvokableCall<int>..ctor
	|
	|-RVA: 0xEFA870 Offset: 0xEF9A70 VA: 0x180EFA870
	|-CachedInvokableCall<object>..ctor
	|
	|-RVA: 0xEFA8F0 Offset: 0xEF9AF0 VA: 0x180EFA8F0
	|-CachedInvokableCall<float>..ctor
	|
	|-RVA: 0xEFA930 Offset: 0xEF9B30 VA: 0x180EFA930
	|-CachedInvokableCall<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFA6D0 Offset: 0xEF98D0 VA: 0x180EFA6D0
	|-CachedInvokableCall<bool>.Invoke
	|
	|-RVA: 0xEFA810 Offset: 0xEF9A10 VA: 0x180EFA810
	|-CachedInvokableCall<int>.Invoke
	|
	|-RVA: 0xEFA840 Offset: 0xEF9A40 VA: 0x180EFA840
	|-CachedInvokableCall<object>.Invoke
	|
	|-RVA: 0xEFA700 Offset: 0xEF9900 VA: 0x180EFA700
	|-CachedInvokableCall<float>.Invoke
	|
	|-RVA: 0xEFA730 Offset: 0xEF9930 VA: 0x180EFA730
	|-CachedInvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void Invoke(T arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFA6D0 Offset: 0xEF98D0 VA: 0x180EFA6D0
	|-CachedInvokableCall<bool>.Invoke
	|
	|-RVA: 0xEFA810 Offset: 0xEF9A10 VA: 0x180EFA810
	|-CachedInvokableCall<int>.Invoke
	|
	|-RVA: 0xEFA840 Offset: 0xEF9A40 VA: 0x180EFA840
	|-CachedInvokableCall<object>.Invoke
	|
	|-RVA: 0xEFA700 Offset: 0xEF9900 VA: 0x180EFA700
	|-CachedInvokableCall<float>.Invoke
	|
	|-RVA: 0xEFA730 Offset: 0xEF9930 VA: 0x180EFA730
	|-CachedInvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
public enum UnityEventCallState // TypeDefIndex: 14283
{
	// Fields
	public int value__; // 0x0
	public const UnityEventCallState Off = 0;
	public const UnityEventCallState EditorAndRuntime = 1;
	public const UnityEventCallState RuntimeOnly = 2;
}

// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCall : ISerializationCallbackReceiver // TypeDefIndex: 14284
{
	// Fields
	[FormerlySerializedAs("instance")]
	[SerializeField]
	private Object m_Target; // 0x10
	[SerializeField]
	private string m_TargetAssemblyTypeName; // 0x18
	[FormerlySerializedAs("methodName")]
	[SerializeField]
	private string m_MethodName; // 0x20
	[SerializeField]
	[FormerlySerializedAs("mode")]
	private PersistentListenerMode m_Mode; // 0x28
	[FormerlySerializedAs("arguments")]
	[SerializeField]
	private ArgumentCache m_Arguments; // 0x30
	[SerializeField]
	[FormerlySerializedAs("enabled")]
	[FormerlySerializedAs("m_Enabled")]
	private UnityEventCallState m_CallState; // 0x38

	// Properties
	public Object target { get; }
	public string targetAssemblyTypeName { get; }
	public string methodName { get; }
	public PersistentListenerMode mode { get; }
	public ArgumentCache arguments { get; }

	// Methods

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	public Object get_target() { }

	// RVA: 0x2497C40 Offset: 0x2496E40 VA: 0x182497C40
	public string get_targetAssemblyTypeName() { }

	// RVA: 0x2497C30 Offset: 0x2496E30 VA: 0x182497C30
	public string get_methodName() { }

	// RVA: 0xC9F3C0 Offset: 0xC9E5C0 VA: 0x180C9F3C0
	public PersistentListenerMode get_mode() { }

	// RVA: 0x2497C20 Offset: 0x2496E20 VA: 0x182497C20
	public ArgumentCache get_arguments() { }

	// RVA: 0x2497B70 Offset: 0x2496D70 VA: 0x182497B70
	public bool IsValid() { }

	// RVA: 0x24977F0 Offset: 0x24969F0 VA: 0x1824977F0
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x24972C0 Offset: 0x24964C0 VA: 0x1824972C0
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x248C1C0 Offset: 0x248B3C0 VA: 0x18248C1C0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x248C1C0 Offset: 0x248B3C0 VA: 0x18248C1C0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2497BB0 Offset: 0x2496DB0 VA: 0x182497BB0
	public void .ctor() { }
}

// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCallGroup // TypeDefIndex: 14285
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_Listeners")]
	private List<PersistentCall> m_Calls; // 0x10

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x2497210 Offset: 0x2496410 VA: 0x182497210
	public void .ctor() { }

	// RVA: 0x2497280 Offset: 0x2496480 VA: 0x182497280
	public int get_Count() { }

	// RVA: 0x2497030 Offset: 0x2496230 VA: 0x182497030
	public PersistentCall GetListener(int index) { }

	// RVA: 0x2497090 Offset: 0x2496290 VA: 0x182497090
	public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) { }
}

// Namespace: UnityEngine.Events
internal class InvokableCallList // TypeDefIndex: 14286
{
	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x2492950 Offset: 0x2491B50 VA: 0x182492950
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x24928A0 Offset: 0x2491AA0 VA: 0x1824928A0
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x2492C30 Offset: 0x2491E30 VA: 0x182492C30
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x2492AC0 Offset: 0x2491CC0 VA: 0x182492AC0
	public void Clear() { }

	// RVA: 0x2492A00 Offset: 0x2491C00 VA: 0x182492A00
	public void ClearPersistent() { }

	// RVA: 0x2492B80 Offset: 0x2491D80 VA: 0x182492B80
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x2492E80 Offset: 0x2492080 VA: 0x182492E80
	public void .ctor() { }
}

// Namespace: UnityEngine.Events
[UsedByNativeCode]
[Serializable]
public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 14287
{
	// Fields
	private InvokableCallList m_Calls; // 0x10
	[SerializeField]
	[FormerlySerializedAs("m_PersistentListeners")]
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x24AA540 Offset: 0x24A9740 VA: 0x1824AA540
	protected void .ctor() { }

	// RVA: 0x24AA530 Offset: 0x24A9730 VA: 0x1824AA530 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x24AA530 Offset: 0x24A9730 VA: 0x1824AA530 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	// RVA: 0x24A9980 Offset: 0x24A8B80 VA: 0x1824A9980
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x24A9BC0 Offset: 0x24A8DC0 VA: 0x1824A9BC0
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x24A9F70 Offset: 0x24A9170 VA: 0x1824A9F70
	public int GetPersistentEventCount() { }

	// RVA: 0x24A9FC0 Offset: 0x24A91C0 VA: 0x1824A9FC0
	public string GetPersistentMethodName(int index) { }

	// RVA: 0x24A98B0 Offset: 0x24A8AB0 VA: 0x1824A98B0
	private void DirtyPersistentCalls() { }

	// RVA: 0x24AA380 Offset: 0x24A9580 VA: 0x1824AA380
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x24A9800 Offset: 0x24A8A00 VA: 0x1824A9800
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x24AA480 Offset: 0x24A9680 VA: 0x1824AA480
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x24AA3C0 Offset: 0x24A95C0 VA: 0x1824AA3C0
	public void RemoveAllListeners() { }

	// RVA: 0x24AA2A0 Offset: 0x24A94A0 VA: 0x1824AA2A0
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x24AA4A0 Offset: 0x24A96A0 VA: 0x1824AA4A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x24AA060 Offset: 0x24A9260 VA: 0x1824AA060
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }
}

// Namespace: UnityEngine.Events
public sealed class UnityAction : MulticastDelegate // TypeDefIndex: 14288
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent : UnityEventBase // TypeDefIndex: 14289
{
	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24AAD90 Offset: 0x24A9F90 VA: 0x1824AAD90
	public void .ctor() { }

	// RVA: 0x24AA890 Offset: 0x24A9A90 VA: 0x1824AA890
	public void AddListener(UnityAction call) { }

	// RVA: 0x24AAD40 Offset: 0x24A9F40 VA: 0x1824AAD40
	public void RemoveListener(UnityAction call) { }

	// RVA: 0x24AA990 Offset: 0x24A9B90 VA: 0x1824AA990 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x24AA9F0 Offset: 0x24A9BF0 VA: 0x1824AA9F0 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x24AAA60 Offset: 0x24A9C60 VA: 0x1824AAA60
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x24AAAC0 Offset: 0x24A9CC0 VA: 0x1824AAAC0
	public void Invoke() { }
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0> : MulticastDelegate // TypeDefIndex: 14290
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C600 Offset: 0x46B800 VA: 0x18046C600
	|-UnityAction<bool>..ctor
	|
	|-RVA: 0xCE0B20 Offset: 0xCDFD20 VA: 0x180CE0B20
	|-UnityAction<Color>..ctor
	|
	|-RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	|-UnityAction<int>..ctor
	|-UnityAction<Int32Enum>..ctor
	|
	|-RVA: 0x3FD260 Offset: 0x3FC460 VA: 0x1803FD260
	|-UnityAction<object>..ctor
	|
	|-RVA: 0xCE0A80 Offset: 0xCDFC80 VA: 0x180CE0A80
	|-UnityAction<Scene>..ctor
	|
	|-RVA: 0x5C4990 Offset: 0x5C3B90 VA: 0x1805C4990
	|-UnityAction<float>..ctor
	|
	|-RVA: 0xCE0CD0 Offset: 0xCDFED0 VA: 0x180CE0CD0
	|-UnityAction<Vector2>..ctor
	|
	|-RVA: 0xCE0BC0 Offset: 0xCDFDC0 VA: 0x180CE0BC0
	|-UnityAction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-UnityAction<bool>.Invoke
	|-UnityAction<int>.Invoke
	|-UnityAction<Int32Enum>.Invoke
	|-UnityAction<object>.Invoke
	|-UnityAction<Scene>.Invoke
	|-UnityAction<float>.Invoke
	|-UnityAction<Vector2>.Invoke
	|-UnityAction<__Il2CppFullySharedGenericType>.Invoke
	|
	|-RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0
	|-UnityAction<Color>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0> : UnityEventBase // TypeDefIndex: 14291
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE36D0 Offset: 0xCE28D0 VA: 0x180CE36D0
	|-UnityEvent<bool>..ctor
	|-UnityEvent<Color>..ctor
	|-UnityEvent<int>..ctor
	|-UnityEvent<Int32Enum>..ctor
	|-UnityEvent<object>..ctor
	|-UnityEvent<float>..ctor
	|-UnityEvent<Vector2>..ctor
	|-UnityEvent<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE1330 Offset: 0xCE0530 VA: 0x180CE1330
	|-UnityEvent<bool>.AddListener
	|-UnityEvent<Color>.AddListener
	|-UnityEvent<int>.AddListener
	|-UnityEvent<Int32Enum>.AddListener
	|-UnityEvent<object>.AddListener
	|-UnityEvent<float>.AddListener
	|-UnityEvent<Vector2>.AddListener
	|
	|-RVA: 0xCE13F0 Offset: 0xCE05F0 VA: 0x180CE13F0
	|-UnityEvent<__Il2CppFullySharedGenericType>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE3680 Offset: 0xCE2880 VA: 0x180CE3680
	|-UnityEvent<bool>.RemoveListener
	|-UnityEvent<Color>.RemoveListener
	|-UnityEvent<int>.RemoveListener
	|-UnityEvent<Int32Enum>.RemoveListener
	|-UnityEvent<object>.RemoveListener
	|-UnityEvent<float>.RemoveListener
	|-UnityEvent<Vector2>.RemoveListener
	|-UnityEvent<__Il2CppFullySharedGenericType>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE1740 Offset: 0xCE0940 VA: 0x180CE1740
	|-UnityEvent<bool>.FindMethod_Impl
	|
	|-RVA: 0xCE1940 Offset: 0xCE0B40 VA: 0x180CE1940
	|-UnityEvent<Color>.FindMethod_Impl
	|
	|-RVA: 0xCE1440 Offset: 0xCE0640 VA: 0x180CE1440
	|-UnityEvent<int>.FindMethod_Impl
	|
	|-RVA: 0xCE1A40 Offset: 0xCE0C40 VA: 0x180CE1A40
	|-UnityEvent<Int32Enum>.FindMethod_Impl
	|
	|-RVA: 0xCE1840 Offset: 0xCE0A40 VA: 0x180CE1840
	|-UnityEvent<object>.FindMethod_Impl
	|
	|-RVA: 0xCE1540 Offset: 0xCE0740 VA: 0x180CE1540
	|-UnityEvent<float>.FindMethod_Impl
	|
	|-RVA: 0xCE1B40 Offset: 0xCE0D40 VA: 0x180CE1B40
	|-UnityEvent<Vector2>.FindMethod_Impl
	|
	|-RVA: 0xCE1640 Offset: 0xCE0840 VA: 0x180CE1640
	|-UnityEvent<__Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE1ED0 Offset: 0xCE10D0 VA: 0x180CE1ED0
	|-UnityEvent<bool>.GetDelegate
	|
	|-RVA: 0xCE1DD0 Offset: 0xCE0FD0 VA: 0x180CE1DD0
	|-UnityEvent<Color>.GetDelegate
	|
	|-RVA: 0xCE1E50 Offset: 0xCE1050 VA: 0x180CE1E50
	|-UnityEvent<int>.GetDelegate
	|
	|-RVA: 0xCE1CC0 Offset: 0xCE0EC0 VA: 0x180CE1CC0
	|-UnityEvent<Int32Enum>.GetDelegate
	|
	|-RVA: 0xCE1F50 Offset: 0xCE1150 VA: 0x180CE1F50
	|-UnityEvent<object>.GetDelegate
	|
	|-RVA: 0xCE1FD0 Offset: 0xCE11D0 VA: 0x180CE1FD0
	|-UnityEvent<float>.GetDelegate
	|
	|-RVA: 0xCE2110 Offset: 0xCE1310 VA: 0x180CE2110
	|-UnityEvent<Vector2>.GetDelegate
	|
	|-RVA: 0xCE1C40 Offset: 0xCE0E40 VA: 0x180CE1C40
	|-UnityEvent<__Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE1D40 Offset: 0xCE0F40 VA: 0x180CE1D40
	|-UnityEvent<bool>.GetDelegate
	|-UnityEvent<Color>.GetDelegate
	|-UnityEvent<int>.GetDelegate
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<float>.GetDelegate
	|-UnityEvent<Vector2>.GetDelegate
	|
	|-RVA: 0xCE2050 Offset: 0xCE1250 VA: 0x180CE2050
	|-UnityEvent<__Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE24B0 Offset: 0xCE16B0 VA: 0x180CE24B0
	|-UnityEvent<bool>.Invoke
	|
	|-RVA: 0xCE29A0 Offset: 0xCE1BA0 VA: 0x180CE29A0
	|-UnityEvent<Color>.Invoke
	|
	|-RVA: 0xCE33F0 Offset: 0xCE25F0 VA: 0x180CE33F0
	|-UnityEvent<int>.Invoke
	|
	|-RVA: 0xCE3160 Offset: 0xCE2360 VA: 0x180CE3160
	|-UnityEvent<Int32Enum>.Invoke
	|
	|-RVA: 0xCE2740 Offset: 0xCE1940 VA: 0x180CE2740
	|-UnityEvent<object>.Invoke
	|
	|-RVA: 0xCE2ED0 Offset: 0xCE20D0 VA: 0x180CE2ED0
	|-UnityEvent<float>.Invoke
	|
	|-RVA: 0xCE2C40 Offset: 0xCE1E40 VA: 0x180CE2C40
	|-UnityEvent<Vector2>.Invoke
	|
	|-RVA: 0xCE2190 Offset: 0xCE1390 VA: 0x180CE2190
	|-UnityEvent<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1> : MulticastDelegate // TypeDefIndex: 14292
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE0EB0 Offset: 0xCE00B0 VA: 0x180CE0EB0
	|-UnityAction<int, bool>..ctor
	|
	|-RVA: 0xCE0D70 Offset: 0xCDFF70 VA: 0x180CE0D70
	|-UnityAction<int, float>..ctor
	|
	|-RVA: 0xCE0F50 Offset: 0xCE0150 VA: 0x180CE0F50
	|-UnityAction<Scene, Int32Enum>..ctor
	|
	|-RVA: 0xCE0E10 Offset: 0xCE0010 VA: 0x180CE0E10
	|-UnityAction<Scene, Scene>..ctor
	|
	|-RVA: 0xBF24F0 Offset: 0xBF16F0 VA: 0x180BF24F0
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-UnityAction<int, bool>.Invoke
	|-UnityAction<int, float>.Invoke
	|-UnityAction<Scene, Int32Enum>.Invoke
	|-UnityAction<Scene, Scene>.Invoke
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1> : UnityEventBase // TypeDefIndex: 14293
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE36D0 Offset: 0xCE28D0 VA: 0x180CE36D0
	|-UnityEvent<int, bool>..ctor
	|-UnityEvent<int, float>..ctor
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE36E0 Offset: 0xCE28E0 VA: 0x180CE36E0
	|-UnityEvent<int, bool>.FindMethod_Impl
	|
	|-RVA: 0xCE3840 Offset: 0xCE2A40 VA: 0x180CE3840
	|-UnityEvent<int, float>.FindMethod_Impl
	|
	|-RVA: 0xCE39A0 Offset: 0xCE2BA0 VA: 0x180CE39A0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE3B80 Offset: 0xCE2D80 VA: 0x180CE3B80
	|-UnityEvent<int, bool>.GetDelegate
	|
	|-RVA: 0xCE3C00 Offset: 0xCE2E00 VA: 0x180CE3C00
	|-UnityEvent<int, float>.GetDelegate
	|
	|-RVA: 0xCE3B00 Offset: 0xCE2D00 VA: 0x180CE3B00
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE4400 Offset: 0xCE3600 VA: 0x180CE4400
	|-UnityEvent<int, bool>.Invoke
	|
	|-RVA: 0xCE40F0 Offset: 0xCE32F0 VA: 0x180CE40F0
	|-UnityEvent<int, float>.Invoke
	|
	|-RVA: 0xCE3C80 Offset: 0xCE2E80 VA: 0x180CE3C80
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2> : MulticastDelegate // TypeDefIndex: 14294
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE1100 Offset: 0xCE0300 VA: 0x180CE1100
	|-UnityAction<object, int, int>..ctor
	|
	|-RVA: 0xCE0FF0 Offset: 0xCE01F0 VA: 0x180CE0FF0
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0
	|-UnityAction<object, int, int>.Invoke
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 14295
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE36D0 Offset: 0xCE28D0 VA: 0x180CE36D0
	|-UnityEvent<object, int, int>..ctor
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE48B0 Offset: 0xCE3AB0 VA: 0x180CE48B0
	|-UnityEvent<object, int, int>.FindMethod_Impl
	|
	|-RVA: 0xCE4700 Offset: 0xCE3900 VA: 0x180CE4700
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE4A60 Offset: 0xCE3C60 VA: 0x180CE4A60
	|-UnityEvent<object, int, int>.GetDelegate
	|
	|-RVA: 0xCE4AE0 Offset: 0xCE3CE0 VA: 0x180CE4AE0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE4B60 Offset: 0xCE3D60 VA: 0x180CE4B60
	|-UnityEvent<object, int, int>.Invoke
	|
	|-RVA: 0xCE4EE0 Offset: 0xCE40E0 VA: 0x180CE4EE0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 14296
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE1220 Offset: 0xCE0420 VA: 0x180CE1220
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2, T3> : UnityEventBase // TypeDefIndex: 14297
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE36D0 Offset: 0xCE28D0 VA: 0x180CE36D0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE54A0 Offset: 0xCE46A0 VA: 0x180CE54A0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE1C40 Offset: 0xCE0E40 VA: 0x180CE1C40
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/
}

// Namespace: UnityEngine.Serialization
[Usage(256, AllowMultiple = True, Inherited = False)]
[RequiredByNativeCode]
public class FormerlySerializedAsAttribute : Attribute // TypeDefIndex: 14298
{
	// Fields
	private string m_oldName; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string oldName) { }
}

// Namespace: UnityEngine.Scripting
[Usage(1)]
public class AlwaysLinkAssemblyAttribute : Attribute // TypeDefIndex: 14299
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine.Scripting
[RequiredByNativeCode]
[Usage(6141, Inherited = False)]
public class PreserveAttribute : Attribute // TypeDefIndex: 14300
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine.Scripting.APIUpdating
internal struct MovedFromAttributeData // TypeDefIndex: 14301
{
	// Fields
	public string className; // 0x0
	public string nameSpace; // 0x8
	public string assembly; // 0x10
	public bool classHasChanged; // 0x18
	public bool nameSpaceHasChanged; // 0x19
	public bool assemblyHasChanged; // 0x1A
	public bool autoUdpateAPI; // 0x1B

	// Methods

	// RVA: 0x2494720 Offset: 0x2493920 VA: 0x182494720
	public void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }
}

// Namespace: UnityEngine.Scripting.APIUpdating
[Usage(5148)]
public class MovedFromAttribute : Attribute // TypeDefIndex: 14302
{
	// Fields
	internal MovedFromAttributeData data; // 0x10

	// Methods

	// RVA: 0x2494750 Offset: 0x2493950 VA: 0x182494750
	public void .ctor(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }

	// RVA: 0x24947C0 Offset: 0x24939C0 VA: 0x1824947C0
	public void .ctor(string sourceNamespace) { }
}

// Namespace: UnityEngine.SceneManagement
[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
[Serializable]
public struct Scene // TypeDefIndex: 14303
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private int m_Handle; // 0x0

	// Properties
	public int handle { get; }
	public string name { get; }
	public bool isLoaded { get; }
	public int rootCount { get; }

	// Methods

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x249D960 Offset: 0x249CB60 VA: 0x18249D960
	private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x249D630 Offset: 0x249C830 VA: 0x18249D630
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x249D5F0 Offset: 0x249C7F0 VA: 0x18249D5F0
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x249D670 Offset: 0x249C870 VA: 0x18249D670
	private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x249D6B0 Offset: 0x249C8B0 VA: 0x18249D6B0
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public int get_handle() { }

	// RVA: 0x249D9A0 Offset: 0x249CBA0 VA: 0x18249D9A0
	public bool IsValid() { }

	// RVA: 0x249DA20 Offset: 0x249CC20 VA: 0x18249DA20
	public string get_name() { }

	// RVA: 0x249D9E0 Offset: 0x249CBE0 VA: 0x18249D9E0
	public bool get_isLoaded() { }

	// RVA: 0x249DA60 Offset: 0x249CC60 VA: 0x18249DA60
	public int get_rootCount() { }

	// RVA: 0x249D6F0 Offset: 0x249C8F0 VA: 0x18249D6F0
	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	// RVA: 0x2499330 Offset: 0x2498530 VA: 0x182499330
	public static bool op_Equality(Scene lhs, Scene rhs) { }

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x249D570 Offset: 0x249C770 VA: 0x18249D570 Slot: 0
	public override bool Equals(object other) { }
}

// Namespace: UnityEngine.SceneManagement
[StaticAccessor("SceneManagerBindings", 2)]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
internal static class SceneManagerAPIInternal // TypeDefIndex: 14304
{
	// Methods

	[NativeThrows]
	// RVA: 0x249C240 Offset: 0x249B440 VA: 0x18249C240
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x249C1D0 Offset: 0x249B3D0 VA: 0x18249C1D0
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }
}

// Namespace: UnityEngine.SceneManagement
public class SceneManagerAPI // TypeDefIndex: 14305
{
	// Fields
	private static SceneManagerAPI s_DefaultAPI; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static SceneManagerAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static SceneManagerAPI ActiveAPI { get; }
	public static SceneManagerAPI overrideAPI { get; set; }

	// Methods

	// RVA: 0x249C360 Offset: 0x249B560 VA: 0x18249C360
	internal static SceneManagerAPI get_ActiveAPI() { }

	[CompilerGenerated]
	// RVA: 0x249C410 Offset: 0x249B610 VA: 0x18249C410
	public static SceneManagerAPI get_overrideAPI() { }

	[CompilerGenerated]
	// RVA: 0x249C460 Offset: 0x249B660 VA: 0x18249C460
	public static void set_overrideAPI(SceneManagerAPI value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected internal void .ctor() { }

	// RVA: 0x249C2A0 Offset: 0x249B4A0 VA: 0x18249C2A0 Slot: 4
	protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	// RVA: 0x249C300 Offset: 0x249B500 VA: 0x18249C300
	private static void .cctor() { }
}

// Namespace: UnityEngine.SceneManagement
[RequiredByNativeCode]
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
public class SceneManager // TypeDefIndex: 14306
{
	// Fields
	internal static bool s_AllowLoadScene; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static UnityAction<Scene> sceneUnloaded; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static UnityAction<Scene, Scene> activeSceneChanged; // 0x18

	// Properties
	public static int sceneCount { get; }

	// Methods

	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[StaticAccessor("GetSceneManager()", 0)]
	[NativeMethod("GetSceneCount")]
	// RVA: 0x249D210 Offset: 0x249C410 VA: 0x18249D210
	public static int get_sceneCount() { }

	[StaticAccessor("SceneManagerBindings", 2)]
	// RVA: 0x249C500 Offset: 0x249B700 VA: 0x18249C500
	public static Scene GetActiveScene() { }

	[StaticAccessor("SceneManagerBindings", 2)]
	[NativeThrows]
	// RVA: 0x249CCD0 Offset: 0x249BED0 VA: 0x18249CCD0
	public static bool SetActiveScene(Scene scene) { }

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", 2)]
	// RVA: 0x249C5B0 Offset: 0x249B7B0 VA: 0x18249C5B0
	public static Scene GetSceneAt(int index) { }

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", 2)]
	// RVA: 0x249CD80 Offset: 0x249BF80 VA: 0x18249CD80
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x249C880 Offset: 0x249BA80 VA: 0x18249C880
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[RequiredByNativeCode]
	// RVA: 0x249C810 Offset: 0x249BA10 VA: 0x18249C810
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	[CompilerGenerated]
	// RVA: 0x249CFF0 Offset: 0x249C1F0 VA: 0x18249CFF0
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGenerated]
	// RVA: 0x249D350 Offset: 0x249C550 VA: 0x18249D350
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGenerated]
	// RVA: 0x249D100 Offset: 0x249C300 VA: 0x18249D100
	public static void add_sceneUnloaded(UnityAction<Scene> value) { }

	[CompilerGenerated]
	// RVA: 0x249D460 Offset: 0x249C660 VA: 0x18249D460
	public static void remove_sceneUnloaded(UnityAction<Scene> value) { }

	[CompilerGenerated]
	// RVA: 0x249CEE0 Offset: 0x249C0E0 VA: 0x18249CEE0
	public static void add_activeSceneChanged(UnityAction<Scene, Scene> value) { }

	[CompilerGenerated]
	// RVA: 0x249D240 Offset: 0x249C440 VA: 0x18249D240
	public static void remove_activeSceneChanged(UnityAction<Scene, Scene> value) { }

	[ExcludeFromDocs]
	// RVA: 0x249CB70 Offset: 0x249BD70 VA: 0x18249CB70
	public static void LoadScene(string sceneName) { }

	// RVA: 0x249CA70 Offset: 0x249BC70 VA: 0x18249CA70
	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x249C960 Offset: 0x249BB60 VA: 0x18249C960
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	// RVA: 0x249CA00 Offset: 0x249BC00 VA: 0x18249CA00
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x249CDF0 Offset: 0x249BFF0 VA: 0x18249CDF0
	public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options) { }

	[RequiredByNativeCode]
	// RVA: 0x249C6D0 Offset: 0x249B8D0 VA: 0x18249C6D0
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCode]
	// RVA: 0x249C770 Offset: 0x249B970 VA: 0x18249C770
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCode]
	// RVA: 0x249C630 Offset: 0x249B830 VA: 0x18249C630
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x249CEA0 Offset: 0x249C0A0 VA: 0x18249CEA0
	private static void .cctor() { }

	// RVA: 0x249C4C0 Offset: 0x249B6C0 VA: 0x18249C4C0
	private static void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0x249CC90 Offset: 0x249BE90 VA: 0x18249CC90
	private static bool SetActiveScene_Injected(ref Scene scene) { }

	// RVA: 0x249C570 Offset: 0x249B770 VA: 0x18249C570
	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	// RVA: 0x249CD40 Offset: 0x249BF40 VA: 0x18249CD40
	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }
}

// Namespace: UnityEngine.SceneManagement
public enum LoadSceneMode // TypeDefIndex: 14307
{
	// Fields
	public int value__; // 0x0
	public const LoadSceneMode Single = 0;
	public const LoadSceneMode Additive = 1;
}

// Namespace: UnityEngine.SceneManagement
[Flags]
public enum LocalPhysicsMode // TypeDefIndex: 14308
{
	// Fields
	public int value__; // 0x0
	public const LocalPhysicsMode None = 0;
	public const LocalPhysicsMode Physics2D = 1;
	public const LocalPhysicsMode Physics3D = 2;
}

// Namespace: UnityEngine.SceneManagement
[Serializable]
public struct LoadSceneParameters // TypeDefIndex: 14309
{
	// Fields
	[SerializeField]
	private LoadSceneMode m_LoadSceneMode; // 0x0
	[SerializeField]
	private LocalPhysicsMode m_LocalPhysicsMode; // 0x4

	// Methods

	// RVA: 0x2493440 Offset: 0x2492640 VA: 0x182493440
	public void .ctor(LoadSceneMode mode) { }
}

// Namespace: UnityEngine.SceneManagement
[Flags]
public enum UnloadSceneOptions // TypeDefIndex: 14310
{
	// Fields
	public int value__; // 0x0
	public const UnloadSceneOptions None = 0;
	public const UnloadSceneOptions UnloadAllEmbeddedSceneObjects = 1;
}

// Namespace: UnityEngine.LowLevel
[NativeType(Header = "Runtime/Misc/PlayerLoop.h")]
[RequiredByNativeCode]
[MovedFrom("UnityEngine.Experimental.LowLevel")]
internal struct PlayerLoopSystemInternal // TypeDefIndex: 14311
{
	// Fields
	public Type type; // 0x0
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x8
	public IntPtr updateFunction; // 0x10
	public IntPtr loopConditionFunction; // 0x18
	public int numSubSystems; // 0x20
}

// Namespace: 
public sealed class PlayerLoopSystem.UpdateFunction : MulticastDelegate // TypeDefIndex: 14312
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine.LowLevel
[MovedFrom("UnityEngine.Experimental.LowLevel")]
public struct PlayerLoopSystem // TypeDefIndex: 14313
{
	// Fields
	public Type type; // 0x0
	public PlayerLoopSystem[] subSystemList; // 0x8
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x10
	public IntPtr updateFunction; // 0x18
	public IntPtr loopConditionFunction; // 0x20

	// Methods

	// RVA: 0x24989E0 Offset: 0x2497BE0 VA: 0x1824989E0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.LowLevel
[MovedFrom("UnityEngine.Experimental.LowLevel")]
public class PlayerLoop // TypeDefIndex: 14314
{
	// Methods

	// RVA: 0x2498A40 Offset: 0x2497C40 VA: 0x182498A40
	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	// RVA: 0x2499020 Offset: 0x2498220 VA: 0x182499020
	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	// RVA: 0x2498D40 Offset: 0x2497F40 VA: 0x182498D40
	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal> internalSys) { }

	// RVA: 0x2498AC0 Offset: 0x2497CC0 VA: 0x182498AC0
	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset) { }

	[NativeMethod(IsFreeFunction = True)]
	// RVA: 0x2498A10 Offset: 0x2497C10 VA: 0x182498A10
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	[NativeMethod(IsFreeFunction = True)]
	// RVA: 0x2498FE0 Offset: 0x24981E0 VA: 0x182498FE0
	private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }
}

// Namespace: 
[RequiredByNativeCode]
public struct TimeUpdate.WaitForLastPresentationAndUpdateTime // TypeDefIndex: 14315
{}

// Namespace: UnityEngine.PlayerLoop
[RequiredByNativeCode]
public struct TimeUpdate // TypeDefIndex: 14316
{}

// Namespace: 
[RequiredByNativeCode]
public struct Initialization.ProfilerStartFrame // TypeDefIndex: 14317
{}

// Namespace: 
[RequiredByNativeCode]
public struct Initialization.UpdateCameraMotionVectors // TypeDefIndex: 14318
{}

// Namespace: 
[RequiredByNativeCode]
public struct Initialization.DirectorSampleTime // TypeDefIndex: 14319
{}

// Namespace: 
[RequiredByNativeCode]
public struct Initialization.AsyncUploadTimeSlicedUpdate // TypeDefIndex: 14320
{}

// Namespace: 
[RequiredByNativeCode]
public struct Initialization.SynchronizeState // TypeDefIndex: 14321
{}

// Namespace: 
[RequiredByNativeCode]
public struct Initialization.SynchronizeInputs // TypeDefIndex: 14322
{}

// Namespace: 
[RequiredByNativeCode]
public struct Initialization.XREarlyUpdate // TypeDefIndex: 14323
{}

// Namespace: UnityEngine.PlayerLoop
[RequiredByNativeCode]
[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
public struct Initialization // TypeDefIndex: 14324
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.PollPlayerConnection // TypeDefIndex: 14325
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.PollHtcsPlayerConnection // TypeDefIndex: 14326
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.GpuTimestamp // TypeDefIndex: 14327
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.AnalyticsCoreStatsUpdate // TypeDefIndex: 14328
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.UnityWebRequestUpdate // TypeDefIndex: 14329
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.UpdateStreamingManager // TypeDefIndex: 14330
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.ExecuteMainThreadJobs // TypeDefIndex: 14331
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.ProcessMouseInWindow // TypeDefIndex: 14332
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.ClearIntermediateRenderers // TypeDefIndex: 14333
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.ClearLines // TypeDefIndex: 14334
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.PresentBeforeUpdate // TypeDefIndex: 14335
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.ResetFrameStatsAfterPresent // TypeDefIndex: 14336
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.UpdateAsyncReadbackManager // TypeDefIndex: 14337
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.UpdateTextureStreamingManager // TypeDefIndex: 14338
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.UpdatePreloading // TypeDefIndex: 14339
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.UpdateContentLoading // TypeDefIndex: 14340
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.UpdateAsyncInstantiate // TypeDefIndex: 14341
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.RendererNotifyInvisible // TypeDefIndex: 14342
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.PlayerCleanupCachedData // TypeDefIndex: 14343
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.UpdateMainGameViewRect // TypeDefIndex: 14344
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.UpdateCanvasRectTransform // TypeDefIndex: 14345
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.UpdateInputManager // TypeDefIndex: 14346
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.ProcessRemoteInput // TypeDefIndex: 14347
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.XRUpdate // TypeDefIndex: 14348
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.ScriptRunDelayedStartupFrame // TypeDefIndex: 14349
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.UpdateKinect // TypeDefIndex: 14350
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.DeliverIosPlatformEvents // TypeDefIndex: 14351
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.DispatchEventQueueEvents // TypeDefIndex: 14352
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.Physics2DEarlyUpdate // TypeDefIndex: 14353
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.PhysicsResetInterpolatedTransformPosition // TypeDefIndex: 14354
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.SpriteAtlasManagerUpdate // TypeDefIndex: 14355
{}

// Namespace: 
[Obsolete("TangoUpdate has been deprecated. Use ARCoreUpdate instead (UnityUpgradable) -> UnityEngine.PlayerLoop.EarlyUpdate/ARCoreUpdate", False)]
[RequiredByNativeCode]
public struct EarlyUpdate.TangoUpdate // TypeDefIndex: 14356
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.ARCoreUpdate // TypeDefIndex: 14357
{}

// Namespace: 
[RequiredByNativeCode]
public struct EarlyUpdate.PerformanceAnalyticsUpdate // TypeDefIndex: 14358
{}

// Namespace: UnityEngine.PlayerLoop
[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
[RequiredByNativeCode]
public struct EarlyUpdate // TypeDefIndex: 14359
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.ClearLines // TypeDefIndex: 14360
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.DirectorFixedSampleTime // TypeDefIndex: 14361
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.AudioFixedUpdate // TypeDefIndex: 14362
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.ScriptRunBehaviourFixedUpdate // TypeDefIndex: 14363
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.DirectorFixedUpdate // TypeDefIndex: 14364
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.LegacyFixedAnimationUpdate // TypeDefIndex: 14365
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.XRFixedUpdate // TypeDefIndex: 14366
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.PhysicsFixedUpdate // TypeDefIndex: 14367
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.Physics2DFixedUpdate // TypeDefIndex: 14368
{}

// Namespace: 
[RequiredByNativeCode]
private struct FixedUpdate.PhysicsClothFixedUpdate // TypeDefIndex: 14369
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.DirectorFixedUpdatePostPhysics // TypeDefIndex: 14370
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.ScriptRunDelayedFixedFrameRate // TypeDefIndex: 14371
{}

// Namespace: 
[RequiredByNativeCode]
public struct FixedUpdate.NewInputFixedUpdate // TypeDefIndex: 14372
{}

// Namespace: UnityEngine.PlayerLoop
[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
[RequiredByNativeCode]
public struct FixedUpdate // TypeDefIndex: 14373
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreUpdate.PhysicsUpdate // TypeDefIndex: 14374
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreUpdate.Physics2DUpdate // TypeDefIndex: 14375
{}

// Namespace: 
[RequiredByNativeCode]
internal struct PreUpdate.PhysicsClothUpdate // TypeDefIndex: 14376
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreUpdate.CheckTexFieldInput // TypeDefIndex: 14377
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreUpdate.IMGUISendQueuedEvents // TypeDefIndex: 14378
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreUpdate.SendMouseEvents // TypeDefIndex: 14379
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreUpdate.AIUpdate // TypeDefIndex: 14380
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreUpdate.WindUpdate // TypeDefIndex: 14381
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreUpdate.UpdateVideo // TypeDefIndex: 14382
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreUpdate.NewInputUpdate // TypeDefIndex: 14383
{}

// Namespace: UnityEngine.PlayerLoop
[RequiredByNativeCode]
[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
public struct PreUpdate // TypeDefIndex: 14384
{}

// Namespace: 
[RequiredByNativeCode]
public struct Update.ScriptRunBehaviourUpdate // TypeDefIndex: 14385
{}

// Namespace: 
[RequiredByNativeCode]
public struct Update.DirectorUpdate // TypeDefIndex: 14386
{}

// Namespace: 
[RequiredByNativeCode]
public struct Update.ScriptRunDelayedDynamicFrameRate // TypeDefIndex: 14387
{}

// Namespace: 
[RequiredByNativeCode]
public struct Update.ScriptRunDelayedTasks // TypeDefIndex: 14388
{}

// Namespace: UnityEngine.PlayerLoop
[RequiredByNativeCode]
[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
public struct Update // TypeDefIndex: 14389
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.Physics2DLateUpdate // TypeDefIndex: 14390
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.PhysicsLateUpdate // TypeDefIndex: 14391
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.AIUpdatePostScript // TypeDefIndex: 14392
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.DirectorUpdateAnimationBegin // TypeDefIndex: 14393
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.LegacyAnimationUpdate // TypeDefIndex: 14394
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.DirectorUpdateAnimationEnd // TypeDefIndex: 14395
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.DirectorDeferredEvaluate // TypeDefIndex: 14396
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.UIElementsUpdatePanels // TypeDefIndex: 14397
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.UpdateNetworkManager // TypeDefIndex: 14398
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.UpdateMasterServerInterface // TypeDefIndex: 14399
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.EndGraphicsJobsAfterScriptUpdate // TypeDefIndex: 14400
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.ParticleSystemBeginUpdateAll // TypeDefIndex: 14401
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.ScriptRunBehaviourLateUpdate // TypeDefIndex: 14402
{}

// Namespace: 
[RequiredByNativeCode]
public struct PreLateUpdate.ConstraintManagerUpdate // TypeDefIndex: 14403
{}

// Namespace: UnityEngine.PlayerLoop
[RequiredByNativeCode]
[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
public struct PreLateUpdate // TypeDefIndex: 14404
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.PlayerSendFrameStarted // TypeDefIndex: 14405
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateRectTransform // TypeDefIndex: 14406
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateCanvasRectTransform // TypeDefIndex: 14407
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.PlayerUpdateCanvases // TypeDefIndex: 14408
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateAudio // TypeDefIndex: 14409
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateVideo // TypeDefIndex: 14410
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.DirectorLateUpdate // TypeDefIndex: 14411
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.ScriptRunDelayedDynamicFrameRate // TypeDefIndex: 14412
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.VFXUpdate // TypeDefIndex: 14413
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.ParticleSystemEndUpdateAll // TypeDefIndex: 14414
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.EndGraphicsJobsAfterScriptLateUpdate // TypeDefIndex: 14415
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateSubstance // TypeDefIndex: 14416
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateCustomRenderTextures // TypeDefIndex: 14417
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.XRPostLateUpdate // TypeDefIndex: 14418
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateAllRenderers // TypeDefIndex: 14419
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateLightProbeProxyVolumes // TypeDefIndex: 14420
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.EnlightenRuntimeUpdate // TypeDefIndex: 14421
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateAllSkinnedMeshes // TypeDefIndex: 14422
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.ProcessWebSendMessages // TypeDefIndex: 14423
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.SortingGroupsUpdate // TypeDefIndex: 14424
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateVideoTextures // TypeDefIndex: 14425
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.DirectorRenderImage // TypeDefIndex: 14426
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.PlayerEmitCanvasGeometry // TypeDefIndex: 14427
{}

// Namespace: 
[RequiredByNativeCode]
internal struct PostLateUpdate.PlayerRenderUIEBatchModeOffscreen // TypeDefIndex: 14428
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.FinishFrameRendering // TypeDefIndex: 14429
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.BatchModeUpdate // TypeDefIndex: 14430
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.PlayerSendFrameComplete // TypeDefIndex: 14431
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateCaptureScreenshot // TypeDefIndex: 14432
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.PresentAfterDraw // TypeDefIndex: 14433
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.ClearImmediateRenderers // TypeDefIndex: 14434
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.XRPostPresent // TypeDefIndex: 14435
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.UpdateResolution // TypeDefIndex: 14436
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.InputEndFrame // TypeDefIndex: 14437
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.GUIClearEvents // TypeDefIndex: 14438
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.ShaderHandleErrors // TypeDefIndex: 14439
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.ResetInputAxis // TypeDefIndex: 14440
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.ThreadedLoadingDebug // TypeDefIndex: 14441
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.ProfilerSynchronizeStats // TypeDefIndex: 14442
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.MemoryFrameMaintenance // TypeDefIndex: 14443
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.ExecuteGameCenterCallbacks // TypeDefIndex: 14444
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.XRPreEndFrame // TypeDefIndex: 14445
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.ProfilerEndFrame // TypeDefIndex: 14446
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.GraphicsWarmupPreloadedShaders // TypeDefIndex: 14447
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.PlayerSendFramePostPresent // TypeDefIndex: 14448
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.PhysicsSkinnedClothBeginUpdate // TypeDefIndex: 14449
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.PhysicsSkinnedClothFinishUpdate // TypeDefIndex: 14450
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.TriggerEndOfFrameCallbacks // TypeDefIndex: 14451
{}

// Namespace: 
[RequiredByNativeCode]
public struct PostLateUpdate.ObjectDispatcherPostLateUpdate // TypeDefIndex: 14452
{}

// Namespace: UnityEngine.PlayerLoop
[RequiredByNativeCode]
[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
public struct PostLateUpdate // TypeDefIndex: 14453
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CollectionPool.<>c<TCollection, TItem> // TypeDefIndex: 14454
{
	// Fields
	public static readonly CollectionPool.<>c<TCollection, TItem> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-CollectionPool.<>c<object, ValueTuple<int, int>>..cctor
	|-CollectionPool.<>c<object, Color32>..cctor
	|-CollectionPool.<>c<object, int>..cctor
	|-CollectionPool.<>c<object, object>..cctor
	|-CollectionPool.<>c<object, UIVertex>..cctor
	|-CollectionPool.<>c<object, Vector3>..cctor
	|-CollectionPool.<>c<object, Vector4>..cctor
	|-CollectionPool.<>c<object, MultiColumnCollectionHeader.SortedColumnState>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-CollectionPool.<>c<object, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-CollectionPool.<>c<object, ValueTuple<int, int>>..ctor
	|-CollectionPool.<>c<object, Color32>..ctor
	|-CollectionPool.<>c<object, int>..ctor
	|-CollectionPool.<>c<object, object>..ctor
	|-CollectionPool.<>c<object, UIVertex>..ctor
	|-CollectionPool.<>c<object, Vector3>..ctor
	|-CollectionPool.<>c<object, Vector4>..ctor
	|-CollectionPool.<>c<object, __Il2CppFullySharedGenericType>..ctor
	|-CollectionPool.<>c<object, MultiColumnCollectionHeader.SortedColumnState>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TCollection <.cctor>b__5_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB07540 Offset: 0xB06740 VA: 0x180B07540
	|-CollectionPool.<>c<object, ValueTuple<int, int>>.<.cctor>b__5_0
	|-CollectionPool.<>c<object, Color32>.<.cctor>b__5_0
	|-CollectionPool.<>c<object, int>.<.cctor>b__5_0
	|-CollectionPool.<>c<object, object>.<.cctor>b__5_0
	|-CollectionPool.<>c<object, UIVertex>.<.cctor>b__5_0
	|-CollectionPool.<>c<object, Vector3>.<.cctor>b__5_0
	|-CollectionPool.<>c<object, Vector4>.<.cctor>b__5_0
	|-CollectionPool.<>c<object, __Il2CppFullySharedGenericType>.<.cctor>b__5_0
	|-CollectionPool.<>c<object, MultiColumnCollectionHeader.SortedColumnState>.<.cctor>b__5_0
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__5_1(TCollection l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB07DE0 Offset: 0xB06FE0 VA: 0x180B07DE0
	|-CollectionPool.<>c<object, ValueTuple<int, int>>.<.cctor>b__5_1
	|-CollectionPool.<>c<object, Color32>.<.cctor>b__5_1
	|-CollectionPool.<>c<object, int>.<.cctor>b__5_1
	|-CollectionPool.<>c<object, object>.<.cctor>b__5_1
	|-CollectionPool.<>c<object, UIVertex>.<.cctor>b__5_1
	|-CollectionPool.<>c<object, Vector3>.<.cctor>b__5_1
	|-CollectionPool.<>c<object, Vector4>.<.cctor>b__5_1
	|-CollectionPool.<>c<object, __Il2CppFullySharedGenericType>.<.cctor>b__5_1
	|-CollectionPool.<>c<object, MultiColumnCollectionHeader.SortedColumnState>.<.cctor>b__5_1
	*/
}

// Namespace: UnityEngine.Pool
public class CollectionPool<TCollection, TItem> // TypeDefIndex: 14455
{
	// Fields
	internal static readonly ObjectPool<TCollection> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static TCollection Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08280 Offset: 0xF07480 VA: 0x180F08280
	|-CollectionPool<object, ValueTuple<int, int>>.Get
	|-CollectionPool<object, Color32>.Get
	|-CollectionPool<object, int>.Get
	|-CollectionPool<object, object>.Get
	|-CollectionPool<object, UIVertex>.Get
	|-CollectionPool<object, Vector3>.Get
	|-CollectionPool<object, Vector4>.Get
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Get
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>.Get
	*/

	// RVA: -1 Offset: -1
	public static PooledObject<TCollection> Get(out TCollection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08180 Offset: 0xF07380 VA: 0x180F08180
	|-CollectionPool<object, ValueTuple<int, int>>.Get
	|-CollectionPool<object, Color32>.Get
	|-CollectionPool<object, int>.Get
	|-CollectionPool<object, object>.Get
	|-CollectionPool<object, UIVertex>.Get
	|-CollectionPool<object, Vector3>.Get
	|-CollectionPool<object, Vector4>.Get
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Get
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(TCollection toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08350 Offset: 0xF07550 VA: 0x180F08350
	|-CollectionPool<object, ValueTuple<int, int>>.Release
	|-CollectionPool<object, Color32>.Release
	|-CollectionPool<object, int>.Release
	|-CollectionPool<object, object>.Release
	|-CollectionPool<object, UIVertex>.Release
	|-CollectionPool<object, Vector3>.Release
	|-CollectionPool<object, Vector4>.Release
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Release
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08430 Offset: 0xF07630 VA: 0x180F08430
	|-CollectionPool<object, ValueTuple<int, int>>..cctor
	|-CollectionPool<object, Color32>..cctor
	|-CollectionPool<object, int>..cctor
	|-CollectionPool<object, object>..cctor
	|-CollectionPool<object, UIVertex>..cctor
	|-CollectionPool<object, Vector3>..cctor
	|-CollectionPool<object, Vector4>..cctor
	|-CollectionPool<object, __Il2CppFullySharedGenericType>..cctor
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>..cctor
	*/
}

// Namespace: UnityEngine.Pool
public interface IObjectPool<T> // TypeDefIndex: 14456
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Release(T element);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IObjectPool<object>.Release
	*/
}

// Namespace: UnityEngine.Pool
public class ObjectPool<T> : IDisposable, IObjectPool<T> // TypeDefIndex: 14457
{
	// Fields
	internal readonly List<T> m_List; // 0x0
	private readonly Func<T> m_CreateFunc; // 0x0
	private readonly Action<T> m_ActionOnGet; // 0x0
	private readonly Action<T> m_ActionOnRelease; // 0x0
	private readonly Action<T> m_ActionOnDestroy; // 0x0
	private readonly int m_MaxSize; // 0x0
	internal bool m_CollectionCheck; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <CountAll>k__BackingField; // 0x0

	// Properties
	public int CountAll { get; set; }
	public int CountInactive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_CountAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	|-ObjectPool<object>.get_CountAll
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_CountAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	|-ObjectPool<object>.set_CountAll
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_CountInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	|-ObjectPool<object>.get_CountInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> createFunc, Action<T> actionOnGet, Action<T> actionOnRelease, Action<T> actionOnDestroy, bool collectionCheck = True, int defaultCapacity = 10, int maxSize = 10000) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB78230 Offset: 0xB77430 VA: 0x180B78230
	|-ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB76FA0 Offset: 0xB761A0 VA: 0x180B76FA0
	|-ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public PooledObject<T> Get(out T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB772C0 Offset: 0xB764C0 VA: 0x180B772C0
	|-ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB779D0 Offset: 0xB76BD0 VA: 0x180B779D0
	|-ObjectPool<object>.Release
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB76570 Offset: 0xB75770 VA: 0x180B76570
	|-ObjectPool<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB768D0 Offset: 0xB75AD0 VA: 0x180B768D0
	|-ObjectPool<object>.Dispose
	*/
}

// Namespace: UnityEngine.Pool
public struct PooledObject<T> : IDisposable // TypeDefIndex: 14458
{
	// Fields
	private readonly T m_ToReturn; // 0x0
	private readonly IObjectPool<T> m_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value, IObjectPool<T> pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	|-PooledObject<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB83960 Offset: 0xB82B60 VA: 0x180B83960
	|-PooledObject<object>.System.IDisposable.Dispose
	*/
}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
public class MessageEventArgs // TypeDefIndex: 14459
{
	// Fields
	public int playerId; // 0x10
	public byte[] data; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerConnection.<>c__DisplayClass12_0 // TypeDefIndex: 14460
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24BAF90 Offset: 0x24BA190 VA: 0x1824BAF90
	internal bool <Register>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerConnection.<>c__DisplayClass13_0 // TypeDefIndex: 14461
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24BAF90 Offset: 0x24BA190 VA: 0x1824BAF90
	internal bool <Unregister>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerConnection.<>c__DisplayClass20_0 // TypeDefIndex: 14462
{
	// Fields
	public bool msgReceived; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21A55F0 Offset: 0x21A47F0 VA: 0x1821A55F0
	internal void <BlockUntilRecvMsg>b__0(MessageEventArgs args) { }
}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
public class PlayerConnection : ScriptableObject // TypeDefIndex: 14463
{
	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	[SerializeField]
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	[SerializeField]
	private List<int> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Properties
	public static PlayerConnection instance { get; }
	public bool isConnected { get; }

	// Methods

	// RVA: 0x24B5A50 Offset: 0x24B4C50 VA: 0x1824B5A50
	public static PlayerConnection get_instance() { }

	// RVA: 0x24B5B40 Offset: 0x24B4D40 VA: 0x1824B5B40
	public bool get_isConnected() { }

	// RVA: 0x24B4970 Offset: 0x24B3B70 VA: 0x1824B4970
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x24B4CF0 Offset: 0x24B3EF0 VA: 0x1824B4CF0
	public void OnEnable() { }

	// RVA: 0x24B4B30 Offset: 0x24B3D30 VA: 0x1824B4B30
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x24B4F10 Offset: 0x24B4110 VA: 0x1824B4F10 Slot: 4
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x24B5610 Offset: 0x24B4810 VA: 0x1824B5610 Slot: 5
	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x24B4D50 Offset: 0x24B3F50 VA: 0x1824B4D50 Slot: 6
	public void RegisterConnection(UnityAction<int> callback) { }

	// RVA: 0x24B4EB0 Offset: 0x24B40B0 VA: 0x1824B4EB0 Slot: 7
	public void RegisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x24B5550 Offset: 0x24B4750 VA: 0x1824B5550 Slot: 8
	public void UnregisterConnection(UnityAction<int> callback) { }

	// RVA: 0x24B55B0 Offset: 0x24B47B0 VA: 0x1824B55B0 Slot: 9
	public void UnregisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x24B51B0 Offset: 0x24B43B0 VA: 0x1824B51B0 Slot: 10
	public void Send(Guid messageId, byte[] data) { }

	// RVA: 0x24B5380 Offset: 0x24B4580 VA: 0x1824B5380 Slot: 11
	public bool TrySend(Guid messageId, byte[] data) { }

	// RVA: 0x24B45D0 Offset: 0x24B37D0 VA: 0x1824B45D0
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x24B4A00 Offset: 0x24B3C00 VA: 0x1824B4A00 Slot: 12
	public void DisconnectAll() { }

	[RequiredByNativeCode]
	// RVA: 0x24B4BA0 Offset: 0x24B3DA0 VA: 0x1824B4BA0
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCode]
	// RVA: 0x24B48A0 Offset: 0x24B3AA0 VA: 0x1824B48A0
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCode]
	// RVA: 0x24B4AA0 Offset: 0x24B3CA0 VA: 0x1824B4AA0
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x24B58E0 Offset: 0x24B4AE0 VA: 0x1824B58E0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerEditorConnectionEvents.MessageEvent : UnityEvent<MessageEventArgs> // TypeDefIndex: 14464
{
	// Methods

	// RVA: 0x24B3410 Offset: 0x24B2610 VA: 0x1824B3410
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerEditorConnectionEvents.ConnectionChangeEvent : UnityEvent<int> // TypeDefIndex: 14465
{
	// Methods

	// RVA: 0x24B0780 Offset: 0x24AF980 VA: 0x1824B0780
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerEditorConnectionEvents.MessageTypeSubscribers // TypeDefIndex: 14466
{
	// Fields
	[SerializeField]
	private string m_messageTypeId; // 0x10
	public int subscriberCount; // 0x18
	public PlayerEditorConnectionEvents.MessageEvent messageCallback; // 0x20

	// Properties
	public Guid MessageTypeId { get; set; }

	// Methods

	// RVA: 0x24B34E0 Offset: 0x24B26E0 VA: 0x1824B34E0
	public Guid get_MessageTypeId() { }

	// RVA: 0x24B3520 Offset: 0x24B2720 VA: 0x1824B3520
	public void set_MessageTypeId(Guid value) { }

	// RVA: 0x24B3450 Offset: 0x24B2650 VA: 0x1824B3450
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass6_0 // TypeDefIndex: 14467
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24BAF90 Offset: 0x24BA190 VA: 0x1824BAF90
	internal bool <InvokeMessageIdSubscribers>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass7_0 // TypeDefIndex: 14468
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24BAF90 Offset: 0x24BA190 VA: 0x1824BAF90
	internal bool <AddAndCreate>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass8_0 // TypeDefIndex: 14469
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24BAF90 Offset: 0x24BA190 VA: 0x1824BAF90
	internal bool <UnregisterManagedCallback>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
internal class PlayerEditorConnectionEvents // TypeDefIndex: 14470
{
	// Fields
	[SerializeField]
	public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; // 0x10
	[SerializeField]
	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; // 0x18
	[SerializeField]
	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; // 0x20

	// Methods

	// RVA: 0x24B5E20 Offset: 0x24B5020 VA: 0x1824B5E20
	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x24B5BE0 Offset: 0x24B4DE0 VA: 0x1824B5BE0
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x24B61E0 Offset: 0x24B53E0 VA: 0x1824B61E0
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x24B6320 Offset: 0x24B5520 VA: 0x1824B6320
	public void .ctor() { }
}

// Namespace: UnityEngine.Internal
[Usage(18432)]
[Serializable]
public class DefaultValueAttribute : Attribute // TypeDefIndex: 14471
{
	// Fields
	private object DefaultValue; // 0x10

	// Properties
	public object Value { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string value) { }

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	public object get_Value() { }

	// RVA: 0x24B09B0 Offset: 0x24AFBB0 VA: 0x1824B09B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24B0A80 Offset: 0x24AFC80 VA: 0x1824B0A80 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Internal
[Serializable]
public class ExcludeFromDocsAttribute : Attribute // TypeDefIndex: 14472
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
[Obsolete("ShaderHardwareTier was renamed to GraphicsTier (UnityUpgradable) -> GraphicsTier", False)]
public enum ShaderHardwareTier // TypeDefIndex: 14473
{
	// Fields
	public int value__; // 0x0
	public const ShaderHardwareTier Tier1 = 0;
	public const ShaderHardwareTier Tier2 = 1;
	public const ShaderHardwareTier Tier3 = 2;
}

// Namespace: UnityEngine.Rendering
public enum BlendShapeBufferLayout // TypeDefIndex: 14474
{
	// Fields
	public int value__; // 0x0
	public const BlendShapeBufferLayout PerShape = 0;
	public const BlendShapeBufferLayout PerVertex = 1;
}

// Namespace: UnityEngine.Rendering
public enum IndexFormat // TypeDefIndex: 14475
{
	// Fields
	public int value__; // 0x0
	public const IndexFormat UInt16 = 0;
	public const IndexFormat UInt32 = 1;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum MeshUpdateFlags // TypeDefIndex: 14476
{
	// Fields
	public int value__; // 0x0
	public const MeshUpdateFlags Default = 0;
	public const MeshUpdateFlags DontValidateIndices = 1;
	public const MeshUpdateFlags DontResetBoneBounds = 2;
	public const MeshUpdateFlags DontNotifyMeshUsers = 4;
	public const MeshUpdateFlags DontRecalculateBounds = 8;
}

// Namespace: UnityEngine.Rendering
public enum VertexAttributeFormat // TypeDefIndex: 14477
{
	// Fields
	public int value__; // 0x0
	public const VertexAttributeFormat Float32 = 0;
	public const VertexAttributeFormat Float16 = 1;
	public const VertexAttributeFormat UNorm8 = 2;
	public const VertexAttributeFormat SNorm8 = 3;
	public const VertexAttributeFormat UNorm16 = 4;
	public const VertexAttributeFormat SNorm16 = 5;
	public const VertexAttributeFormat UInt8 = 6;
	public const VertexAttributeFormat SInt8 = 7;
	public const VertexAttributeFormat UInt16 = 8;
	public const VertexAttributeFormat SInt16 = 9;
	public const VertexAttributeFormat UInt32 = 10;
	public const VertexAttributeFormat SInt32 = 11;
}

// Namespace: UnityEngine.Rendering
[MovedFrom("UnityEngine.Experimental.Rendering")]
public enum VertexAttribute // TypeDefIndex: 14478
{
	// Fields
	public int value__; // 0x0
	public const VertexAttribute Position = 0;
	public const VertexAttribute Normal = 1;
	public const VertexAttribute Tangent = 2;
	public const VertexAttribute Color = 3;
	public const VertexAttribute TexCoord0 = 4;
	public const VertexAttribute TexCoord1 = 5;
	public const VertexAttribute TexCoord2 = 6;
	public const VertexAttribute TexCoord3 = 7;
	public const VertexAttribute TexCoord4 = 8;
	public const VertexAttribute TexCoord5 = 9;
	public const VertexAttribute TexCoord6 = 10;
	public const VertexAttribute TexCoord7 = 11;
	public const VertexAttribute BlendWeight = 12;
	public const VertexAttribute BlendIndices = 13;
}

// Namespace: UnityEngine.Rendering
public enum OpaqueSortMode // TypeDefIndex: 14479
{
	// Fields
	public int value__; // 0x0
	public const OpaqueSortMode Default = 0;
	public const OpaqueSortMode FrontToBack = 1;
	public const OpaqueSortMode NoDistanceSort = 2;
}

// Namespace: UnityEngine.Rendering
public enum RenderBufferLoadAction // TypeDefIndex: 14480
{
	// Fields
	public int value__; // 0x0
	public const RenderBufferLoadAction Load = 0;
	public const RenderBufferLoadAction Clear = 1;
	public const RenderBufferLoadAction DontCare = 2;
}

// Namespace: UnityEngine.Rendering
public enum RenderBufferStoreAction // TypeDefIndex: 14481
{
	// Fields
	public int value__; // 0x0
	public const RenderBufferStoreAction Store = 0;
	public const RenderBufferStoreAction Resolve = 1;
	public const RenderBufferStoreAction StoreAndResolve = 2;
	public const RenderBufferStoreAction DontCare = 3;
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
public enum CompareFunction // TypeDefIndex: 14482
{
	// Fields
	public int value__; // 0x0
	public const CompareFunction Disabled = 0;
	public const CompareFunction Never = 1;
	public const CompareFunction Less = 2;
	public const CompareFunction Equal = 3;
	public const CompareFunction LessEqual = 4;
	public const CompareFunction Greater = 5;
	public const CompareFunction NotEqual = 6;
	public const CompareFunction GreaterEqual = 7;
	public const CompareFunction Always = 8;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum ColorWriteMask // TypeDefIndex: 14483
{
	// Fields
	public int value__; // 0x0
	public const ColorWriteMask Alpha = 1;
	public const ColorWriteMask Blue = 2;
	public const ColorWriteMask Green = 4;
	public const ColorWriteMask Red = 8;
	public const ColorWriteMask All = 15;
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
public enum StencilOp // TypeDefIndex: 14484
{
	// Fields
	public int value__; // 0x0
	public const StencilOp Keep = 0;
	public const StencilOp Zero = 1;
	public const StencilOp Replace = 2;
	public const StencilOp IncrementSaturate = 3;
	public const StencilOp DecrementSaturate = 4;
	public const StencilOp Invert = 5;
	public const StencilOp IncrementWrap = 6;
	public const StencilOp DecrementWrap = 7;
}

// Namespace: UnityEngine.Rendering
public enum CameraEvent // TypeDefIndex: 14485
{
	// Fields
	public int value__; // 0x0
	public const CameraEvent BeforeDepthTexture = 0;
	public const CameraEvent AfterDepthTexture = 1;
	public const CameraEvent BeforeDepthNormalsTexture = 2;
	public const CameraEvent AfterDepthNormalsTexture = 3;
	public const CameraEvent BeforeGBuffer = 4;
	public const CameraEvent AfterGBuffer = 5;
	public const CameraEvent BeforeLighting = 6;
	public const CameraEvent AfterLighting = 7;
	public const CameraEvent BeforeFinalPass = 8;
	public const CameraEvent AfterFinalPass = 9;
	public const CameraEvent BeforeForwardOpaque = 10;
	public const CameraEvent AfterForwardOpaque = 11;
	public const CameraEvent BeforeImageEffectsOpaque = 12;
	public const CameraEvent AfterImageEffectsOpaque = 13;
	public const CameraEvent BeforeSkybox = 14;
	public const CameraEvent AfterSkybox = 15;
	public const CameraEvent BeforeForwardAlpha = 16;
	public const CameraEvent AfterForwardAlpha = 17;
	public const CameraEvent BeforeImageEffects = 18;
	public const CameraEvent AfterImageEffects = 19;
	public const CameraEvent AfterEverything = 20;
	public const CameraEvent BeforeReflections = 21;
	public const CameraEvent AfterReflections = 22;
	public const CameraEvent BeforeHaloAndLensFlares = 23;
	public const CameraEvent AfterHaloAndLensFlares = 24;
}

// Namespace: UnityEngine.Rendering
internal static class CameraEventUtils // TypeDefIndex: 14486
{
	// Methods

	// RVA: 0x24AD7F0 Offset: 0x24AC9F0 VA: 0x1824AD7F0
	public static bool IsValid(CameraEvent value) { }
}

// Namespace: UnityEngine.Rendering
public enum BuiltinRenderTextureType // TypeDefIndex: 14487
{
	// Fields
	public int value__; // 0x0
	public const BuiltinRenderTextureType PropertyName = -4;
	public const BuiltinRenderTextureType BufferPtr = -3;
	public const BuiltinRenderTextureType RenderTexture = -2;
	public const BuiltinRenderTextureType BindableTexture = -1;
	public const BuiltinRenderTextureType None = 0;
	public const BuiltinRenderTextureType CurrentActive = 1;
	public const BuiltinRenderTextureType CameraTarget = 2;
	public const BuiltinRenderTextureType Depth = 3;
	public const BuiltinRenderTextureType DepthNormals = 4;
	public const BuiltinRenderTextureType ResolvedDepth = 5;
	[Obsolete("Deferred Lighting has been removed, so PrepassNormalsSpec built-in render texture type is never used now.", False)]
	public const BuiltinRenderTextureType PrepassNormalsSpec = 7;
	[Obsolete("Deferred Lighting has been removed, so PrepassLight built-in render texture type is never used now.", False)]
	public const BuiltinRenderTextureType PrepassLight = 8;
	[Obsolete("Deferred Lighting has been removed, so PrepassLightSpec built-in render texture type is never used now.", False)]
	public const BuiltinRenderTextureType PrepassLightSpec = 9;
	public const BuiltinRenderTextureType GBuffer0 = 10;
	public const BuiltinRenderTextureType GBuffer1 = 11;
	public const BuiltinRenderTextureType GBuffer2 = 12;
	public const BuiltinRenderTextureType GBuffer3 = 13;
	public const BuiltinRenderTextureType Reflections = 14;
	public const BuiltinRenderTextureType MotionVectors = 15;
	public const BuiltinRenderTextureType GBuffer4 = 16;
	public const BuiltinRenderTextureType GBuffer5 = 17;
	public const BuiltinRenderTextureType GBuffer6 = 18;
	public const BuiltinRenderTextureType GBuffer7 = 19;
}

// Namespace: UnityEngine.Rendering
public enum ShadowCastingMode // TypeDefIndex: 14488
{
	// Fields
	public int value__; // 0x0
	public const ShadowCastingMode Off = 0;
	public const ShadowCastingMode On = 1;
	public const ShadowCastingMode TwoSided = 2;
	public const ShadowCastingMode ShadowsOnly = 3;
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
public enum GraphicsDeviceType // TypeDefIndex: 14489
{
	// Fields
	public int value__; // 0x0
	[Obsolete("OpenGL2 is no longer supported in Unity 5.5+")]
	public const GraphicsDeviceType OpenGL2 = 0;
	[Obsolete("Direct3D 9 is no longer supported in Unity 2017.2+")]
	public const GraphicsDeviceType Direct3D9 = 1;
	public const GraphicsDeviceType Direct3D11 = 2;
	[Obsolete("PS3 is no longer supported in Unity 5.5+")]
	public const GraphicsDeviceType PlayStation3 = 3;
	public const GraphicsDeviceType Null = 4;
	[Obsolete("Xbox360 is no longer supported in Unity 5.5+")]
	public const GraphicsDeviceType Xbox360 = 6;
	public const GraphicsDeviceType OpenGLES2 = 8;
	public const GraphicsDeviceType OpenGLES3 = 11;
	[Obsolete("PVita is no longer supported as of Unity 2018")]
	public const GraphicsDeviceType PlayStationVita = 12;
	public const GraphicsDeviceType PlayStation4 = 13;
	public const GraphicsDeviceType XboxOne = 14;
	[Obsolete("PlayStationMobile is no longer supported in Unity 5.3+")]
	public const GraphicsDeviceType PlayStationMobile = 15;
	public const GraphicsDeviceType Metal = 16;
	public const GraphicsDeviceType OpenGLCore = 17;
	public const GraphicsDeviceType Direct3D12 = 18;
	[Obsolete("Nintendo 3DS support is unavailable since 2018.1")]
	public const GraphicsDeviceType N3DS = 19;
	public const GraphicsDeviceType Vulkan = 21;
	public const GraphicsDeviceType Switch = 22;
	public const GraphicsDeviceType XboxOneD3D12 = 23;
	public const GraphicsDeviceType GameCoreXboxOne = 24;
	[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", False)]
	public const GraphicsDeviceType GameCoreScarlett = -1;
	public const GraphicsDeviceType GameCoreXboxSeries = 25;
	public const GraphicsDeviceType PlayStation5 = 26;
	public const GraphicsDeviceType PlayStation5NGGC = 27;
}

// Namespace: UnityEngine.Rendering
public enum GraphicsTier // TypeDefIndex: 14490
{
	// Fields
	public int value__; // 0x0
	public const GraphicsTier Tier1 = 0;
	public const GraphicsTier Tier2 = 1;
	public const GraphicsTier Tier3 = 2;
}

// Namespace: UnityEngine.Rendering
public struct SubMeshDescriptor // TypeDefIndex: 14491
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Bounds <bounds>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private MeshTopology <topology>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <indexStart>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <indexCount>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <baseVertex>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <firstVertex>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <vertexCount>k__BackingField; // 0x2C

	// Properties
	public Bounds bounds { get; }
	public MeshTopology topology { get; }
	public int indexStart { get; }
	public int indexCount { get; }
	public int baseVertex { get; }
	public int firstVertex { get; }
	public int vertexCount { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4BBD30 Offset: 0x4BAF30 VA: 0x1804BBD30
	public Bounds get_bounds() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public MeshTopology get_topology() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_indexStart() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_indexCount() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_baseVertex() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_firstVertex() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public int get_vertexCount() { }

	// RVA: 0x24B9910 Offset: 0x24B8B10 VA: 0x1824B9910 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor> // TypeDefIndex: 14492
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VertexAttribute <attribute>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VertexAttributeFormat <format>k__BackingField; // 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <dimension>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <stream>k__BackingField; // 0xC

	// Properties
	public VertexAttribute attribute { get; set; }
	public VertexAttributeFormat format { get; set; }
	public int dimension { get; set; }
	public int stream { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public VertexAttribute get_attribute() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_attribute(VertexAttribute value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public VertexAttributeFormat get_format() { }

	[CompilerGenerated]
	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_format(VertexAttributeFormat value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_dimension() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_dimension(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_stream() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_stream(int value) { }

	// RVA: 0xD4CCD0 Offset: 0xD4BED0 VA: 0x180D4CCD0
	public void .ctor(VertexAttribute attribute = 0, VertexAttributeFormat format = 0, int dimension = 3, int stream = 0) { }

	// RVA: 0x24BB130 Offset: 0x24BA330 VA: 0x1824BB130 Slot: 3
	public override string ToString() { }

	// RVA: 0x24BB110 Offset: 0x24BA310 VA: 0x1824BB110 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24BB050 Offset: 0x24BA250 VA: 0x1824BB050 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x246DA30 Offset: 0x246CC30 VA: 0x18246DA30 Slot: 4
	public bool Equals(VertexAttributeDescriptor other) { }
}

// Namespace: UnityEngine.Rendering
public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier> // TypeDefIndex: 14493
{
	// Fields
	private BuiltinRenderTextureType m_Type; // 0x0
	private int m_NameID; // 0x4
	private int m_InstanceID; // 0x8
	private IntPtr m_BufferPointer; // 0x10
	private int m_MipLevel; // 0x18
	private CubemapFace m_CubeFace; // 0x1C
	private int m_DepthSlice; // 0x20

	// Methods

	// RVA: 0x24B7D50 Offset: 0x24B6F50 VA: 0x1824B7D50
	public void .ctor(Texture tex) { }

	// RVA: 0x24B7E80 Offset: 0x24B7080 VA: 0x1824B7E80
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x24B7A40 Offset: 0x24B6C40 VA: 0x1824B7A40 Slot: 3
	public override string ToString() { }

	// RVA: 0x24B79F0 Offset: 0x24B6BF0 VA: 0x1824B79F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24B7940 Offset: 0x24B6B40 VA: 0x1824B7940 Slot: 4
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x24B7890 Offset: 0x24B6A90 VA: 0x1824B7890 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.Rendering
public enum ShadowSamplingMode // TypeDefIndex: 14494
{
	// Fields
	public int value__; // 0x0
	public const ShadowSamplingMode CompareDepths = 0;
	public const ShadowSamplingMode RawDepth = 1;
	public const ShadowSamplingMode None = 2;
}

// Namespace: UnityEngine.Rendering
public enum TextureDimension // TypeDefIndex: 14495
{
	// Fields
	public int value__; // 0x0
	public const TextureDimension Unknown = -1;
	public const TextureDimension None = 0;
	public const TextureDimension Any = 1;
	public const TextureDimension Tex2D = 2;
	public const TextureDimension Tex3D = 3;
	public const TextureDimension Cube = 4;
	public const TextureDimension Tex2DArray = 5;
	public const TextureDimension CubeArray = 6;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum CopyTextureSupport // TypeDefIndex: 14496
{
	// Fields
	public int value__; // 0x0
	public const CopyTextureSupport None = 0;
	public const CopyTextureSupport Basic = 1;
	public const CopyTextureSupport Copy3D = 2;
	public const CopyTextureSupport DifferentTypes = 4;
	public const CopyTextureSupport TextureToRT = 8;
	public const CopyTextureSupport RTToTexture = 16;
}

// Namespace: UnityEngine.Rendering
public enum ComputeQueueType // TypeDefIndex: 14497
{
	// Fields
	public int value__; // 0x0
	public const ComputeQueueType Default = 0;
	public const ComputeQueueType Background = 1;
	public const ComputeQueueType Urgent = 2;
}

// Namespace: UnityEngine.Rendering
public enum CommandBufferExecutionFlags // TypeDefIndex: 14498
{
	// Fields
	public int value__; // 0x0
	public const CommandBufferExecutionFlags None = 0;
	public const CommandBufferExecutionFlags AsyncCompute = 2;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum RTClearFlags // TypeDefIndex: 14499
{
	// Fields
	public int value__; // 0x0
	public const RTClearFlags None = 0;
	public const RTClearFlags Color = 1;
	public const RTClearFlags Depth = 2;
	public const RTClearFlags Stencil = 4;
	public const RTClearFlags All = 7;
	public const RTClearFlags DepthStencil = 6;
	public const RTClearFlags ColorDepth = 3;
	public const RTClearFlags ColorStencil = 5;
}

// Namespace: UnityEngine.Rendering
public enum RenderTextureSubElement // TypeDefIndex: 14500
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureSubElement Color = 0;
	public const RenderTextureSubElement Depth = 1;
	public const RenderTextureSubElement Stencil = 2;
	public const RenderTextureSubElement Default = 3;
}

// Namespace: UnityEngine.Rendering
[MovedFrom("UnityEngine.Experimental.Rendering")]
public enum RenderingThreadingMode // TypeDefIndex: 14501
{
	// Fields
	public int value__; // 0x0
	public const RenderingThreadingMode Direct = 0;
	public const RenderingThreadingMode SingleThreaded = 1;
	public const RenderingThreadingMode MultiThreaded = 2;
	public const RenderingThreadingMode LegacyJobified = 3;
	public const RenderingThreadingMode NativeGraphicsJobs = 4;
	public const RenderingThreadingMode NativeGraphicsJobsWithoutRenderThread = 5;
}

// Namespace: UnityEngine.Rendering
[StaticAccessor("GetGraphicsSettings()", 0)]
[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
public sealed class GraphicsSettings : Object // TypeDefIndex: 14502
{
	// Properties
	public static bool lightsUseLinearIntensity { get; }
	[NativeName("CurrentRenderPipeline")]
	private static ScriptableObject INTERNAL_currentRenderPipeline { get; }
	public static RenderPipelineAsset currentRenderPipeline { get; }

	// Methods

	// RVA: 0x24B1470 Offset: 0x24B0670 VA: 0x1824B1470
	public static bool get_lightsUseLinearIntensity() { }

	// RVA: 0x24B13B0 Offset: 0x24B05B0 VA: 0x1824B13B0
	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	// RVA: 0x24B13E0 Offset: 0x24B05E0 VA: 0x1824B13E0
	public static RenderPipelineAsset get_currentRenderPipeline() { }
}

// Namespace: UnityEngine.Rendering
[RequiredByNativeCode]
public class OnDemandRendering // TypeDefIndex: 14503
{
	// Fields
	private static int m_RenderFrameInterval; // 0x0

	// Properties
	public static int renderFrameInterval { get; }

	// Methods

	// RVA: 0x24B3610 Offset: 0x24B2810 VA: 0x1824B3610
	public static int get_renderFrameInterval() { }

	[RequiredByNativeCode]
	// RVA: 0x24B3540 Offset: 0x24B2740 VA: 0x1824B3540
	internal static void GetRenderFrameInterval(out int frameInterval) { }

	// RVA: 0x24B35D0 Offset: 0x24B27D0 VA: 0x1824B35D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Shaders/RayTracingShader.h")]
[NativeType("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Export/Graphics/RenderingCommandBuffer.bindings.h")]
public class CommandBuffer : IDisposable // TypeDefIndex: 14504
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string name { set; }

	// Methods

	[FreeFunction("RenderingCommandBuffer_Bindings::InitBuffer")]
	// RVA: 0x24B00A0 Offset: 0x24AF2A0 VA: 0x1824B00A0
	private static IntPtr InitBuffer() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseBuffer", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x24B01C0 Offset: 0x24AF3C0 VA: 0x1824B01C0
	private void ReleaseBuffer() { }

	// RVA: 0x24B0730 Offset: 0x24AF930 VA: 0x1824B0730
	public void set_name(string value) { }

	[NativeMethod("ClearCommands")]
	// RVA: 0x24AFB30 Offset: 0x24AED30 VA: 0x1824AFB30
	public void Clear() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMesh", HasExplicitThis = True)]
	// RVA: 0x24B0140 Offset: 0x24AF340 VA: 0x1824B0140
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ClearRenderTarget", HasExplicitThis = True)]
	// RVA: 0x24AFAC0 Offset: 0x24AECC0 VA: 0x1824AFAC0
	public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil) { }

	// RVA: 0x24AFA00 Offset: 0x24AEC00 VA: 0x1824AFA00
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = True)]
	// RVA: 0x24B0200 Offset: 0x24AF400 VA: 0x1824B0200
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = True)]
	// RVA: 0x24B04C0 Offset: 0x24AF6C0 VA: 0x1824B04C0
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ValidateAgainstExecutionFlags", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24B06A0 Offset: 0x24AF8A0 VA: 0x1824B06A0
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalTexture_Impl", HasExplicitThis = True)]
	// RVA: 0x24B02B0 Offset: 0x24AF4B0 VA: 0x1824B02B0
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	// RVA: 0x24B0600 Offset: 0x24AF800 VA: 0x1824B0600
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x24B0580 Offset: 0x24AF780 VA: 0x1824B0580
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x24B0020 Offset: 0x24AF220 VA: 0x1824B0020 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24AFB70 Offset: 0x24AED70 VA: 0x1824AFB70 Slot: 4
	public void Dispose() { }

	// RVA: 0x24AFBF0 Offset: 0x24AEDF0 VA: 0x1824AFBF0
	private void Dispose(bool disposing) { }

	// RVA: 0x24B06F0 Offset: 0x24AF8F0 VA: 0x1824B06F0
	public void .ctor() { }

	// RVA: 0x24AFD60 Offset: 0x24AEF60 VA: 0x1824AFD60
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[ExcludeFromDocs]
	// RVA: 0x24AFC90 Offset: 0x24AEE90 VA: 0x1824AFC90
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	[ExcludeFromDocs]
	// RVA: 0x24AFC30 Offset: 0x24AEE30 VA: 0x1824AFC30
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	[ExcludeFromDocs]
	// RVA: 0x24AFD00 Offset: 0x24AEF00 VA: 0x1824AFD00
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	// RVA: 0x24B0250 Offset: 0x24AF450 VA: 0x1824B0250
	public void SetGlobalFloat(string name, float value) { }

	// RVA: 0x24B0450 Offset: 0x24AF650 VA: 0x1824B0450
	public void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x24B0370 Offset: 0x24AF570 VA: 0x1824B0370
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	// RVA: 0x24B0310 Offset: 0x24AF510 VA: 0x1824B0310
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	// RVA: 0x24B00D0 Offset: 0x24AF2D0 VA: 0x1824B00D0
	private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x24AF9A0 Offset: 0x24AEBA0 VA: 0x1824AF9A0
	private void ClearRenderTarget_Injected(RTClearFlags clearFlags, ref Color backgroundColor, float depth, uint stencil) { }

	// RVA: 0x24B0400 Offset: 0x24AF600 VA: 0x1824B0400
	private void SetGlobalVector_Injected(int nameID, ref Vector4 value) { }

	// RVA: 0x24B0510 Offset: 0x24AF710 VA: 0x1824B0510
	private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }
}

// Namespace: UnityEngine.Rendering
[NativeClass("BatchID")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
public struct BatchID : IEquatable<BatchID> // TypeDefIndex: 14505
{
	// Fields
	public static readonly BatchID Null; // 0x0
	public uint value; // 0x0

	// Methods

	// RVA: 0x2459420 Offset: 0x2458620 VA: 0x182459420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24AD130 Offset: 0x24AC330 VA: 0x1824AD130 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x244E010 Offset: 0x244D210 VA: 0x18244E010 Slot: 4
	public bool Equals(BatchID other) { }

	// RVA: 0x24AD1D0 Offset: 0x24AC3D0 VA: 0x1824AD1D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[NativeClass("BatchMaterialID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct BatchMaterialID : IEquatable<BatchMaterialID> // TypeDefIndex: 14506
{
	// Fields
	public static readonly BatchMaterialID Null; // 0x0
	public uint value; // 0x0

	// Methods

	// RVA: 0x2459420 Offset: 0x2458620 VA: 0x182459420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24AD210 Offset: 0x24AC410 VA: 0x1824AD210 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x244E010 Offset: 0x244D210 VA: 0x18244E010 Slot: 4
	public bool Equals(BatchMaterialID other) { }

	// RVA: 0x24AD2B0 Offset: 0x24AC4B0 VA: 0x1824AD2B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("BatchMeshID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
public struct BatchMeshID : IEquatable<BatchMeshID> // TypeDefIndex: 14507
{
	// Fields
	public static readonly BatchMeshID Null; // 0x0
	public uint value; // 0x0

	// Methods

	// RVA: 0x2459420 Offset: 0x2458620 VA: 0x182459420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24AD2F0 Offset: 0x24AC4F0 VA: 0x1824AD2F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x244E010 Offset: 0x244D210 VA: 0x18244E010 Slot: 4
	public bool Equals(BatchMeshID other) { }

	// RVA: 0x24AD390 Offset: 0x24AC590 VA: 0x1824AD390
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum BatchDrawCommandFlags // TypeDefIndex: 14508
{
	// Fields
	public int value__; // 0x0
	public const BatchDrawCommandFlags None = 0;
	public const BatchDrawCommandFlags FlipWinding = 1;
	public const BatchDrawCommandFlags HasMotion = 2;
	public const BatchDrawCommandFlags IsLightMapped = 4;
	public const BatchDrawCommandFlags HasSortingPosition = 8;
	public const BatchDrawCommandFlags LODCrossFade = 16;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum BatchCullingFlags // TypeDefIndex: 14509
{
	// Fields
	public int value__; // 0x0
	public const BatchCullingFlags None = 0;
	public const BatchCullingFlags CullLightmappedShadowCasters = 1;
}

// Namespace: UnityEngine.Rendering
public enum BatchCullingViewType // TypeDefIndex: 14510
{
	// Fields
	public int value__; // 0x0
	public const BatchCullingViewType Unknown = 0;
	public const BatchCullingViewType Camera = 1;
	public const BatchCullingViewType Light = 2;
	public const BatchCullingViewType Picking = 3;
	public const BatchCullingViewType SelectionOutline = 4;
}

// Namespace: UnityEngine.Rendering
public enum BatchCullingProjectionType // TypeDefIndex: 14511
{
	// Fields
	public int value__; // 0x0
	public const BatchCullingProjectionType Unknown = 0;
	public const BatchCullingProjectionType Perspective = 1;
	public const BatchCullingProjectionType Orthographic = 2;
}

// Namespace: UnityEngine.Rendering
public struct BatchPackedCullingViewID : IEquatable<BatchPackedCullingViewID> // TypeDefIndex: 14512
{
	// Fields
	internal ulong handle; // 0x0

	// Methods

	// RVA: 0x24AD460 Offset: 0x24AC660 VA: 0x1824AD460 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC41F00 Offset: 0xC41100 VA: 0x180C41F00 Slot: 4
	public bool Equals(BatchPackedCullingViewID other) { }

	// RVA: 0x24AD3D0 Offset: 0x24AC5D0 VA: 0x1824AD3D0 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawCommand // TypeDefIndex: 14513
{
	// Fields
	public uint visibleOffset; // 0x0
	public uint visibleCount; // 0x4
	public BatchID batchID; // 0x8
	public BatchMaterialID materialID; // 0xC
	public BatchMeshID meshID; // 0x10
	public ushort submeshIndex; // 0x14
	public ushort splitVisibilityMask; // 0x16
	public BatchDrawCommandFlags flags; // 0x18
	public int sortingPosition; // 0x1C
}

// Namespace: UnityEngine.Rendering
public struct BatchFilterSettings // TypeDefIndex: 14514
{
	// Fields
	public uint renderingLayerMask; // 0x0
	public byte layer; // 0x4
	private byte m_motionMode; // 0x5
	private byte m_shadowMode; // 0x6
	private byte m_receiveShadows; // 0x7
	private byte m_staticShadowCaster; // 0x8
	private byte m_allDepthSorted; // 0x9
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawRange // TypeDefIndex: 14515
{
	// Fields
	public uint drawCommandsBegin; // 0x0
	public uint drawCommandsCount; // 0x4
	public BatchFilterSettings filterSettings; // 0x8
}

// Namespace: UnityEngine.Rendering
public struct BatchCullingOutputDrawCommands // TypeDefIndex: 14516
{
	// Fields
	public BatchDrawCommand* drawCommands; // 0x0
	public int* visibleInstances; // 0x8
	public BatchDrawRange* drawRanges; // 0x10
	public float* instanceSortingPositions; // 0x18
	public int* drawCommandPickingInstanceIDs; // 0x20
	public int drawCommandCount; // 0x28
	public int visibleInstanceCount; // 0x2C
	public int drawRangeCount; // 0x30
	public int instanceSortingPositionFloatCount; // 0x34
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[UsedByNativeCode]
public struct CullingSplit // TypeDefIndex: 14517
{
	// Fields
	public Vector3 sphereCenter; // 0x0
	public float sphereRadius; // 0xC
	public int cullingPlaneOffset; // 0x10
	public int cullingPlaneCount; // 0x14
	public float cascadeBlendCullingFactor; // 0x18
	public float nearPlane; // 0x1C
	public Matrix4x4 cullingMatrix; // 0x20
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
public struct BatchCullingContext // TypeDefIndex: 14518
{
	// Fields
	public readonly NativeArray<Plane> cullingPlanes; // 0x0
	public readonly NativeArray<CullingSplit> cullingSplits; // 0x10
	public readonly LODParameters lodParameters; // 0x20
	public readonly Matrix4x4 localToWorldMatrix; // 0x3C
	public readonly BatchCullingViewType viewType; // 0x7C
	public readonly BatchCullingProjectionType projectionType; // 0x80
	public readonly BatchCullingFlags cullingFlags; // 0x84
	public readonly BatchPackedCullingViewID viewID; // 0x88
	public readonly uint cullingLayerMask; // 0x90
	public readonly ulong sceneCullingMask; // 0x98
	[Obsolete("BatchCullingContext.isOrthographic is deprecated. Use BatchCullingContext.projectionType instead.")]
	public readonly byte isOrthographic; // 0xA0
	public readonly int receiverPlaneOffset; // 0xA4
	public readonly int receiverPlaneCount; // 0xA8

	// Methods

	// RVA: 0x24AD080 Offset: 0x24AC280 VA: 0x1824AD080
	internal void .ctor(NativeArray<Plane> inCullingPlanes, NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, int inReceiverPlaneOffset, int inReceiverPlaneCount) { }
}

// Namespace: UnityEngine.Rendering
public struct BatchCullingOutput // TypeDefIndex: 14519
{
	// Fields
	public NativeArray<BatchCullingOutputDrawCommands> drawCommands; // 0x0
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
internal struct BatchRendererCullingOutput // TypeDefIndex: 14520
{
	// Fields
	public JobHandle cullingJobsFence; // 0x0
	public Matrix4x4 localToWorldMatrix; // 0x10
	public Plane* cullingPlanes; // 0x50
	public int cullingPlaneCount; // 0x58
	public int receiverPlaneOffset; // 0x5C
	public int receiverPlaneCount; // 0x60
	public CullingSplit* cullingSplits; // 0x68
	public int cullingSplitCount; // 0x70
	public BatchCullingViewType viewType; // 0x74
	public BatchCullingProjectionType projectionType; // 0x78
	public BatchCullingFlags cullingFlags; // 0x7C
	public ulong viewID; // 0x80
	public uint cullingLayerMask; // 0x88
	public ulong sceneCullingMask; // 0x90
	public BatchCullingOutputDrawCommands* drawCommands; // 0x98
}

// Namespace: 
public sealed class BatchRendererGroup.OnPerformCulling : MulticastDelegate // TypeDefIndex: 14521
{
	// Methods

	// RVA: 0x24B3740 Offset: 0x24B2940 VA: 0x1824B3740
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B3660 Offset: 0x24B2860 VA: 0x1824B3660 Slot: 13
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext) { }
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[NativeHeader("Runtime/Math/Matrix4x4.h")]
[RequiredByNativeCode]
public class BatchRendererGroup // TypeDefIndex: 14522
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24AD470 Offset: 0x24AC670 VA: 0x1824AD470
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext) { }
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
internal struct CoreCameraValues : IEquatable<CoreCameraValues> // TypeDefIndex: 14523
{
	// Fields
	private int filterMode; // 0x0
	private uint cullingMask; // 0x4
	private int instanceID; // 0x8

	// Methods

	// RVA: 0x24B07C0 Offset: 0x24AF9C0 VA: 0x1824B07C0 Slot: 4
	public bool Equals(CoreCameraValues other) { }

	// RVA: 0x24B07E0 Offset: 0x24AF9E0 VA: 0x1824B07E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24B08B0 Offset: 0x24AFAB0 VA: 0x1824B08B0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct CameraProperties.<layerCullDistances>e__FixedBuffer // TypeDefIndex: 14524
{
	// Fields
	public float FixedElementField; // 0x0
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct CameraProperties.<m_CameraCullPlanes>e__FixedBuffer // TypeDefIndex: 14525
{
	// Fields
	public byte FixedElementField; // 0x0
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct CameraProperties.<m_ShadowCullPlanes>e__FixedBuffer // TypeDefIndex: 14526
{
	// Fields
	public byte FixedElementField; // 0x0
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
public struct CameraProperties : IEquatable<CameraProperties> // TypeDefIndex: 14527
{
	// Fields
	private Rect screenRect; // 0x0
	private Vector3 viewDir; // 0x10
	private float projectionNear; // 0x1C
	private float projectionFar; // 0x20
	private float cameraNear; // 0x24
	private float cameraFar; // 0x28
	private float cameraAspect; // 0x2C
	private Matrix4x4 cameraToWorld; // 0x30
	private Matrix4x4 actualWorldToClip; // 0x70
	private Matrix4x4 cameraClipToWorld; // 0xB0
	private Matrix4x4 cameraWorldToClip; // 0xF0
	private Matrix4x4 implicitProjection; // 0x130
	private Matrix4x4 stereoWorldToClipLeft; // 0x170
	private Matrix4x4 stereoWorldToClipRight; // 0x1B0
	private Matrix4x4 worldToCamera; // 0x1F0
	private Vector3 up; // 0x230
	private Vector3 right; // 0x23C
	private Vector3 transformDirection; // 0x248
	private Vector3 cameraEuler; // 0x254
	private Vector3 velocity; // 0x260
	private float farPlaneWorldSpaceLength; // 0x26C
	private uint rendererCount; // 0x270
	[FixedBuffer(typeof(byte), 96)]
	internal CameraProperties.<m_ShadowCullPlanes>e__FixedBuffer m_ShadowCullPlanes; // 0x274
	[FixedBuffer(typeof(byte), 96)]
	internal CameraProperties.<m_CameraCullPlanes>e__FixedBuffer m_CameraCullPlanes; // 0x2D4
	private float baseFarDistance; // 0x334
	private Vector3 shadowCullCenter; // 0x338
	[FixedBuffer(typeof(float), 32)]
	internal CameraProperties.<layerCullDistances>e__FixedBuffer layerCullDistances; // 0x344
	private int layerCullSpherical; // 0x3C4
	private CoreCameraValues coreCameraValues; // 0x3C8
	private uint cameraType; // 0x3D4
	private int projectionIsOblique; // 0x3D8
	private int isImplicitProjectionMatrix; // 0x3DC

	// Methods

	// RVA: 0x24AF890 Offset: 0x24AEA90 VA: 0x1824AF890
	public Plane GetShadowCullingPlane(int index) { }

	// RVA: 0x24AF290 Offset: 0x24AE490 VA: 0x1824AF290
	public Plane GetCameraCullingPlane(int index) { }

	// RVA: 0x24AD8C0 Offset: 0x24ACAC0 VA: 0x1824AD8C0 Slot: 4
	public bool Equals(CameraProperties other) { }

	// RVA: 0x24AF150 Offset: 0x24AE350 VA: 0x1824AF150 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24AF3A0 Offset: 0x24AE5A0 VA: 0x1824AF3A0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum CullingOptions // TypeDefIndex: 14528
{
	// Fields
	public int value__; // 0x0
	public const CullingOptions None = 0;
	public const CullingOptions ForceEvenIfCameraIsNotActive = 1;
	public const CullingOptions OcclusionCull = 2;
	public const CullingOptions NeedsLighting = 4;
	public const CullingOptions NeedsReflectionProbes = 8;
	public const CullingOptions Stereo = 16;
	public const CullingOptions DisablePerObjectCulling = 32;
	public const CullingOptions ShadowCasters = 64;
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct ScriptableCullingParameters.<m_CullingPlanes>e__FixedBuffer // TypeDefIndex: 14529
{
	// Fields
	public byte FixedElementField; // 0x0
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct ScriptableCullingParameters.<m_LayerFarCullDistances>e__FixedBuffer // TypeDefIndex: 14530
{
	// Fields
	public float FixedElementField; // 0x0
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
public struct ScriptableCullingParameters : IEquatable<ScriptableCullingParameters> // TypeDefIndex: 14531
{
	// Fields
	private int m_IsOrthographic; // 0x0
	private LODParameters m_LODParameters; // 0x4
	public static readonly int maximumCullingPlaneCount; // 0x0
	[FixedBuffer(typeof(byte), 160)]
	internal ScriptableCullingParameters.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x20
	private int m_CullingPlaneCount; // 0xC0
	private uint m_CullingMask; // 0xC4
	private ulong m_SceneMask; // 0xC8
	private ulong m_ViewID; // 0xD0
	public static readonly int layerCount; // 0x4
	[FixedBuffer(typeof(float), 32)]
	internal ScriptableCullingParameters.<m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances; // 0xD8
	private int m_LayerCull; // 0x158
	private Matrix4x4 m_CullingMatrix; // 0x15C
	private Vector3 m_Origin; // 0x19C
	private float m_ShadowDistance; // 0x1A8
	private float m_ShadowNearPlaneOffset; // 0x1AC
	private CullingOptions m_CullingOptions; // 0x1B0
	private ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria; // 0x1B4
	private CameraProperties m_CameraProperties; // 0x1B8
	private float m_AccurateOcclusionThreshold; // 0x598
	private int m_MaximumPortalCullingJobs; // 0x59C
	private Matrix4x4 m_StereoViewMatrix; // 0x5A0
	private Matrix4x4 m_StereoProjectionMatrix; // 0x5E0
	private float m_StereoSeparationDistance; // 0x620
	private int m_maximumVisibleLights; // 0x624
	private bool m_ConservativeEnclosingSphere; // 0x628
	private int m_NumIterationsEnclosingSphere; // 0x62C

	// Properties
	public int cullingPlaneCount { get; }

	// Methods

	// RVA: 0x24B8BD0 Offset: 0x24B7DD0 VA: 0x1824B8BD0
	public int get_cullingPlaneCount() { }

	// RVA: 0x24B8A80 Offset: 0x24B7C80 VA: 0x1824B8A80
	public float GetLayerCullingDistance(int layerIndex) { }

	// RVA: 0x24B86E0 Offset: 0x24B78E0 VA: 0x1824B86E0
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x24B7F90 Offset: 0x24B7190 VA: 0x1824B7F90 Slot: 4
	public bool Equals(ScriptableCullingParameters other) { }

	// RVA: 0x24B8610 Offset: 0x24B7810 VA: 0x1824B8610 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24B8830 Offset: 0x24B7A30 VA: 0x1824B8830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24B8B80 Offset: 0x24B7D80 VA: 0x1824B8B80
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public struct LODParameters : IEquatable<LODParameters> // TypeDefIndex: 14532
{
	// Fields
	private int m_IsOrthographic; // 0x0
	private Vector3 m_CameraPosition; // 0x4
	private float m_FieldOfView; // 0x10
	private float m_OrthoSize; // 0x14
	private int m_CameraPixelHeight; // 0x18

	// Methods

	// RVA: 0x24B14A0 Offset: 0x24B06A0 VA: 0x1824B14A0 Slot: 4
	public bool Equals(LODParameters other) { }

	// RVA: 0x24B1540 Offset: 0x24B0740 VA: 0x1824B1540 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24B15F0 Offset: 0x24B07F0 VA: 0x1824B15F0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
public class ObjectIdRequest // TypeDefIndex: 14533
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private RenderTexture <destination>k__BackingField; // 0x10

	// Properties
	public RenderTexture destination { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public RenderTexture get_destination() { }
}

// Namespace: UnityEngine.Rendering
public enum ReflectionProbeSortingCriteria // TypeDefIndex: 14534
{
	// Fields
	public int value__; // 0x0
	public const ReflectionProbeSortingCriteria None = 0;
	public const ReflectionProbeSortingCriteria Importance = 1;
	public const ReflectionProbeSortingCriteria Size = 2;
	public const ReflectionProbeSortingCriteria ImportanceThenSize = 3;
}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipeline // TypeDefIndex: 14535
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-RenderPipeline.ProcessRenderRequests<object>
	|-RenderPipeline.ProcessRenderRequests<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected internal virtual bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA641B0 Offset: 0xA633B0 VA: 0x180A641B0
	|-RenderPipeline.IsRenderRequestSupported<object>
	|-RenderPipeline.IsRenderRequestSupported<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x24B7810 Offset: 0x24B6A10 VA: 0x1824B7810 Slot: 7
	protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: 0x24B7780 Offset: 0x24B6980 VA: 0x1824B7780
	internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: -1 Offset: -1
	internal void InternalProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA640D0 Offset: 0xA632D0 VA: 0x180A640D0
	|-RenderPipeline.InternalProcessRenderRequests<object>
	|
	|-RVA: 0xA63F70 Offset: 0xA63170 VA: 0x180A63F70
	|-RenderPipeline.InternalProcessRenderRequests<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_disposed(bool value) { }

	// RVA: 0x24B7710 Offset: 0x24B6910 VA: 0x1824B7710
	internal void Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	protected virtual void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineAsset : ScriptableObject // TypeDefIndex: 14536
{
	// Properties
	public virtual string[] renderingLayerMaskNames { get; }
	public virtual string[] prefixedRenderingLayerMaskNames { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Shader autodeskInteractiveShader { get; }
	public virtual Shader autodeskInteractiveTransparentShader { get; }
	public virtual Shader autodeskInteractiveMaskedShader { get; }
	public virtual Shader terrainDetailLitShader { get; }
	public virtual Shader terrainDetailGrassShader { get; }
	public virtual Shader terrainDetailGrassBillboardShader { get; }
	public virtual Material defaultParticleMaterial { get; }
	public virtual Material defaultLineMaterial { get; }
	public virtual Material defaultTerrainMaterial { get; }
	public virtual Material defaultUIMaterial { get; }
	public virtual Material defaultUIOverdrawMaterial { get; }
	public virtual Material defaultUIETC1SupportedMaterial { get; }
	public virtual Material default2DMaterial { get; }
	public virtual Material default2DMaskMaterial { get; }
	public virtual Shader defaultShader { get; }
	public virtual Shader defaultSpeedTree7Shader { get; }
	public virtual Shader defaultSpeedTree8Shader { get; }
	public virtual string renderPipelineShaderTag { get; }

	// Methods

	// RVA: 0x24B6420 Offset: 0x24B5620 VA: 0x1824B6420
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 4
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public virtual string[] get_prefixedRenderingLayerMaskNames() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 11
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 13
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 14
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 15
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 17
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 18
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 19
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 20
	public virtual Material get_default2DMaskMaterial() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 21
	public virtual Shader get_defaultShader() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 22
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 23
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: 0x24B6700 Offset: 0x24B5900 VA: 0x1824B6700 Slot: 24
	public virtual string get_renderPipelineShaderTag() { }

	// RVA: -1 Offset: -1 Slot: 25
	protected abstract RenderPipeline CreatePipeline();

	// RVA: 0x24B6640 Offset: 0x24B5840 VA: 0x1824B6640 Slot: 26
	protected virtual void OnValidate() { }

	// RVA: 0x24B6600 Offset: 0x24B5800 VA: 0x1824B6600 Slot: 27
	protected virtual void OnDisable() { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public static class RenderPipelineManager // TypeDefIndex: 14537
{
	// Fields
	internal static RenderPipelineAsset s_CurrentPipelineAsset; // 0x0
	private static List<Camera> s_Cameras; // 0x8
	private static string s_CurrentPipelineType; // 0x10
	private static RenderPipeline s_CurrentPipeline; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action activeRenderPipelineTypeChanged; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action activeRenderPipelineCreated; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action activeRenderPipelineDisposed; // 0x38

	// Properties
	public static RenderPipeline currentPipeline { get; set; }

	// Methods

	// RVA: 0x24B7600 Offset: 0x24B6800 VA: 0x1824B7600
	public static RenderPipeline get_currentPipeline() { }

	// RVA: 0x24B7650 Offset: 0x24B6850 VA: 0x1824B7650
	private static void set_currentPipeline(RenderPipeline value) { }

	[RequiredByNativeCode]
	// RVA: 0x24B7280 Offset: 0x24B6480 VA: 0x1824B7280
	internal static void OnActiveRenderPipelineTypeChanged() { }

	[RequiredByNativeCode]
	// RVA: 0x24B7170 Offset: 0x24B6370 VA: 0x1824B7170
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	[RequiredByNativeCode]
	// RVA: 0x24B6F80 Offset: 0x24B6180 VA: 0x1824B6F80
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	[RequiredByNativeCode]
	// RVA: 0x24B6780 Offset: 0x24B5980 VA: 0x1824B6780
	internal static void CleanupRenderPipeline() { }

	[RequiredByNativeCode]
	// RVA: 0x24B6F30 Offset: 0x24B6130 VA: 0x1824B6F30
	private static string GetCurrentPipelineAssetType() { }

	[RequiredByNativeCode]
	// RVA: 0x24B6AD0 Offset: 0x24B5CD0 VA: 0x1824B6AD0
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, Object renderRequest) { }

	// RVA: 0x24B72F0 Offset: 0x24B64F0 VA: 0x1824B72F0
	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x24B7000 Offset: 0x24B6200 VA: 0x1824B7000
	private static bool IsPipelineRequireCreation() { }

	// RVA: 0x24B7550 Offset: 0x24B6750 VA: 0x1824B7550
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Modules/UI/Canvas.h")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 14538
{
	// Fields
	private static readonly ShaderTagId kRenderTypeTag; // 0x0
	private IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x24B8D40 Offset: 0x24B7F40 VA: 0x1824B8D40
	private void GetCameras_Internal(Type listType, object resultList) { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x24B8DD0 Offset: 0x24B7FD0 VA: 0x1824B8DD0
	internal void GetCameras(List<Camera> results) { }

	// RVA: 0x24B8C80 Offset: 0x24B7E80 VA: 0x1824B8C80 Slot: 4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x24B8BE0 Offset: 0x24B7DE0 VA: 0x1824B8BE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2459420 Offset: 0x2458620 VA: 0x182459420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24B8E80 Offset: 0x24B8080 VA: 0x1824B8E80
	private static void .cctor() { }

	// RVA: 0x24B8CE0 Offset: 0x24B7EE0 VA: 0x1824B8CE0
	private static void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, object resultList) { }
}

// Namespace: UnityEngine.Rendering
public struct ShaderTagId : IEquatable<ShaderTagId> // TypeDefIndex: 14539
{
	// Fields
	private int m_Id; // 0x0

	// Properties
	internal int id { get; set; }

	// Methods

	// RVA: 0x24B91D0 Offset: 0x24B83D0 VA: 0x1824B91D0
	public void .ctor(string name) { }

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	internal int get_id() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	internal void set_id(int value) { }

	// RVA: 0x24B9120 Offset: 0x24B8320 VA: 0x1824B9120 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x244E010 Offset: 0x244D210 VA: 0x18244E010 Slot: 4
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x24B91B0 Offset: 0x24B83B0 VA: 0x1824B91B0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
public struct StencilState : IEquatable<StencilState> // TypeDefIndex: 14540
{
	// Fields
	private byte m_Enabled; // 0x0
	private byte m_ReadMask; // 0x1
	private byte m_WriteMask; // 0x2
	private byte m_Padding; // 0x3
	private byte m_CompareFunctionFront; // 0x4
	private byte m_PassOperationFront; // 0x5
	private byte m_FailOperationFront; // 0x6
	private byte m_ZFailOperationFront; // 0x7
	private byte m_CompareFunctionBack; // 0x8
	private byte m_PassOperationBack; // 0x9
	private byte m_FailOperationBack; // 0xA
	private byte m_ZFailOperationBack; // 0xB

	// Properties
	public bool enabled { set; }
	public byte readMask { set; }
	public byte writeMask { set; }
	public CompareFunction compareFunctionFront { set; }
	public StencilOp passOperationFront { set; }
	public StencilOp failOperationFront { set; }
	public StencilOp zFailOperationFront { set; }
	public CompareFunction compareFunctionBack { set; }
	public StencilOp passOperationBack { set; }
	public StencilOp failOperationBack { set; }
	public StencilOp zFailOperationBack { set; }

	// Methods

	// RVA: 0x24B9870 Offset: 0x24B8A70 VA: 0x1824B9870
	public void set_enabled(bool value) { }

	// RVA: 0x18C4840 Offset: 0x18C3A40 VA: 0x1818C4840
	public void set_readMask(byte value) { }

	// RVA: 0x24B98E0 Offset: 0x24B8AE0 VA: 0x1824B98E0
	public void set_writeMask(byte value) { }

	// RVA: 0x499070 Offset: 0x498270 VA: 0x180499070
	public void set_compareFunctionFront(CompareFunction value) { }

	// RVA: 0x499090 Offset: 0x498290 VA: 0x180499090
	public void set_passOperationFront(StencilOp value) { }

	// RVA: 0x4E0830 Offset: 0x4DFA30 VA: 0x1804E0830
	public void set_failOperationFront(StencilOp value) { }

	// RVA: 0x24B9900 Offset: 0x24B8B00 VA: 0x1824B9900
	public void set_zFailOperationFront(StencilOp value) { }

	// RVA: 0x48F5E0 Offset: 0x48E7E0 VA: 0x18048F5E0
	public void set_compareFunctionBack(CompareFunction value) { }

	// RVA: 0x48F5D0 Offset: 0x48E7D0 VA: 0x18048F5D0
	public void set_passOperationBack(StencilOp value) { }

	// RVA: 0x24B98D0 Offset: 0x24B8AD0 VA: 0x1824B98D0
	public void set_failOperationBack(StencilOp value) { }

	// RVA: 0x24B98F0 Offset: 0x24B8AF0 VA: 0x1824B98F0
	public void set_zFailOperationBack(StencilOp value) { }

	// RVA: 0x24B95B0 Offset: 0x24B87B0 VA: 0x1824B95B0 Slot: 4
	public bool Equals(StencilState other) { }

	// RVA: 0x24B9620 Offset: 0x24B8820 VA: 0x1824B9620 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24B9770 Offset: 0x24B8970 VA: 0x1824B9770 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
[Flags]
public enum SupportedRenderingFeatures.ReflectionProbeModes // TypeDefIndex: 14541
{
	// Fields
	public int value__; // 0x0
	public const SupportedRenderingFeatures.ReflectionProbeModes None = 0;
	public const SupportedRenderingFeatures.ReflectionProbeModes Rotation = 1;
}

// Namespace: 
[Flags]
public enum SupportedRenderingFeatures.LightmapMixedBakeModes // TypeDefIndex: 14542
{
	// Fields
	public int value__; // 0x0
	public const SupportedRenderingFeatures.LightmapMixedBakeModes None = 0;
	public const SupportedRenderingFeatures.LightmapMixedBakeModes IndirectOnly = 1;
	public const SupportedRenderingFeatures.LightmapMixedBakeModes Subtractive = 2;
	public const SupportedRenderingFeatures.LightmapMixedBakeModes Shadowmask = 4;
}

// Namespace: UnityEngine.Rendering
public class SupportedRenderingFeatures // TypeDefIndex: 14543
{
	// Fields
	private static SupportedRenderingFeatures s_Active; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; // 0x14
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; // 0x1C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private LightmapsMode <lightmapsModes>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <enlightenLightmapper>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <enlighten>k__BackingField; // 0x25
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <lightProbeProxyVolumes>k__BackingField; // 0x26
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <motionVectors>k__BackingField; // 0x27
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <receiveShadows>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <reflectionProbes>k__BackingField; // 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <reflectionProbesBlendDistance>k__BackingField; // 0x2A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <rendererPriority>k__BackingField; // 0x2B
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <rendersUIOverlay>k__BackingField; // 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesEnvironmentLighting>k__BackingField; // 0x2D
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesFog>k__BackingField; // 0x2E
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesRealtimeReflectionProbes>k__BackingField; // 0x2F
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesOtherLightingSettings>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <editableMaterialRenderQueue>k__BackingField; // 0x31
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesLODBias>k__BackingField; // 0x32
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesMaximumLODLevel>k__BackingField; // 0x33
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesEnableLODCrossFade>k__BackingField; // 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <rendererProbes>k__BackingField; // 0x35
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <particleSystemInstancing>k__BackingField; // 0x36
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <autoAmbientProbeBaking>k__BackingField; // 0x37
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <autoDefaultReflectionProbeBaking>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesShadowmask>k__BackingField; // 0x39
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesLightProbeSystem>k__BackingField; // 0x3A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <supportsHDR>k__BackingField; // 0x3B
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <overridesLightProbeSystemWarningMessage>k__BackingField; // 0x40

	// Properties
	public static SupportedRenderingFeatures active { get; set; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes { get; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes { get; }
	public LightmapBakeType lightmapBakeTypes { get; }
	public LightmapsMode lightmapsModes { get; }
	[Obsolete("Bake with the Progressive Lightmapper. The backend that uses Enlighten to bake is deprecated.", False)]
	public bool enlightenLightmapper { get; }
	public bool enlighten { get; }
	public bool rendersUIOverlay { get; }
	public bool autoAmbientProbeBaking { get; }
	public bool autoDefaultReflectionProbeBaking { get; }
	public bool overridesLightProbeSystem { get; }

	// Methods

	// RVA: 0x24BA7F0 Offset: 0x24B99F0 VA: 0x1824BA7F0
	public static SupportedRenderingFeatures get_active() { }

	// RVA: 0x24BA8D0 Offset: 0x24B9AD0 VA: 0x1824BA8D0
	public static void set_active(SupportedRenderingFeatures value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes() { }

	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public LightmapBakeType get_lightmapBakeTypes() { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public LightmapsMode get_lightmapsModes() { }

	[CompilerGenerated]
	// RVA: 0x695F30 Offset: 0x695130 VA: 0x180695F30
	public bool get_enlightenLightmapper() { }

	[CompilerGenerated]
	// RVA: 0x695F20 Offset: 0x695120 VA: 0x180695F20
	public bool get_enlighten() { }

	[CompilerGenerated]
	// RVA: 0x48DA50 Offset: 0x48CC50 VA: 0x18048DA50
	public bool get_rendersUIOverlay() { }

	[CompilerGenerated]
	// RVA: 0x24BA8C0 Offset: 0x24B9AC0 VA: 0x1824BA8C0
	public bool get_autoAmbientProbeBaking() { }

	[CompilerGenerated]
	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_autoDefaultReflectionProbeBaking() { }

	[CompilerGenerated]
	// RVA: 0x161DE50 Offset: 0x161D050 VA: 0x18161DE50
	public bool get_overridesLightProbeSystem() { }

	[RequiredByNativeCode]
	// RVA: 0x24B9C40 Offset: 0x24B8E40 VA: 0x1824B9C40
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	// RVA: 0x24BA4E0 Offset: 0x24B96E0 VA: 0x1824BA4E0
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[RequiredByNativeCode]
	// RVA: 0x24BA390 Offset: 0x24B9590 VA: 0x1824BA390
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	// RVA: 0x24BA140 Offset: 0x24B9340 VA: 0x1824BA140
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[RequiredByNativeCode]
	// RVA: 0x24BA040 Offset: 0x24B9240 VA: 0x1824BA040
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x24BA310 Offset: 0x24B9510 VA: 0x1824BA310
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x24BA280 Offset: 0x24B9480 VA: 0x1824BA280
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x24BA630 Offset: 0x24B9830 VA: 0x1824BA630
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x24B9F60 Offset: 0x24B9160 VA: 0x1824B9F60
	internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x24B9FD0 Offset: 0x24B91D0 VA: 0x1824B9FD0
	internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x24BA6A0 Offset: 0x24B98A0 VA: 0x1824BA6A0
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x24B9C20 Offset: 0x24B8E20 VA: 0x1824B9C20
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	// RVA: 0x24BA770 Offset: 0x24B9970 VA: 0x1824BA770
	public void .ctor() { }

	// RVA: 0x24BA710 Offset: 0x24B9910 VA: 0x1824BA710
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[IsReadOnly]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
public struct GlobalKeyword // TypeDefIndex: 14544
{
	// Fields
	internal readonly string m_Name; // 0x0
	internal readonly uint m_Index; // 0x8

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[UsedByNativeCode]
[IsReadOnly]
public struct LocalKeyword : IEquatable<LocalKeyword> // TypeDefIndex: 14545
{
	// Fields
	internal readonly LocalKeywordSpace m_SpaceInfo; // 0x0
	internal readonly string m_Name; // 0x8
	internal readonly uint m_Index; // 0x10

	// Methods

	// RVA: 0x1808BB0 Offset: 0x1807DB0 VA: 0x181808BB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x24B31F0 Offset: 0x24B23F0 VA: 0x1824B31F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x24B32A0 Offset: 0x24B24A0 VA: 0x1824B32A0 Slot: 4
	public bool Equals(LocalKeyword rhs) { }

	// RVA: 0x24B3310 Offset: 0x24B2510 VA: 0x1824B3310 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[IsReadOnly]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
public struct LocalKeywordSpace : IEquatable<LocalKeywordSpace> // TypeDefIndex: 14546
{
	// Fields
	private readonly IntPtr m_KeywordSpace; // 0x0

	// Methods

	// RVA: 0x24B3140 Offset: 0x24B2340 VA: 0x1824B3140 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x24B31D0 Offset: 0x24B23D0 VA: 0x1824B31D0 Slot: 4
	public bool Equals(LocalKeywordSpace rhs) { }

	// RVA: 0x24B31E0 Offset: 0x24B23E0 VA: 0x1824B31E0
	public static bool op_Equality(LocalKeywordSpace lhs, LocalKeywordSpace rhs) { }

	// RVA: 0x2459420 Offset: 0x2458620 VA: 0x182459420 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
public enum ShaderPropertyType // TypeDefIndex: 14547
{
	// Fields
	public int value__; // 0x0
	public const ShaderPropertyType Color = 0;
	public const ShaderPropertyType Vector = 1;
	public const ShaderPropertyType Float = 2;
	public const ShaderPropertyType Range = 3;
	public const ShaderPropertyType Texture = 4;
	public const ShaderPropertyType Int = 5;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum ShaderPropertyFlags // TypeDefIndex: 14548
{
	// Fields
	public int value__; // 0x0
	public const ShaderPropertyFlags None = 0;
	public const ShaderPropertyFlags HideInInspector = 1;
	public const ShaderPropertyFlags PerRendererData = 2;
	public const ShaderPropertyFlags NoScaleOffset = 4;
	public const ShaderPropertyFlags Normal = 8;
	public const ShaderPropertyFlags HDR = 16;
	public const ShaderPropertyFlags Gamma = 32;
	public const ShaderPropertyFlags NonModifiableTextureData = 64;
	public const ShaderPropertyFlags MainTexture = 128;
	public const ShaderPropertyFlags MainColor = 256;
}

// Namespace: UnityEngine.Rendering
[RequireComponent(typeof(Transform))]
[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
public sealed class SortingGroup : Behaviour // TypeDefIndex: 14549
{
	// Properties
	[StaticAccessor("SortingGroup", 2)]
	internal static int invalidSortingGroupID { get; }
	public string sortingLayerName { get; set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public bool sortAtRoot { get; set; }
	internal int sortingGroupID { get; }
	internal int sortingGroupOrder { get; }
	internal int index { get; }
	internal uint sortingKey { get; }

	// Methods

	// RVA: 0x24B92A0 Offset: 0x24B84A0 VA: 0x1824B92A0
	internal static int get_invalidSortingGroupID() { }

	[StaticAccessor("SortingGroup", 2)]
	// RVA: 0x24B9230 Offset: 0x24B8430 VA: 0x1824B9230
	public static void UpdateAllSortingGroups() { }

	[StaticAccessor("SortingGroup", 2)]
	// RVA: 0x24B91F0 Offset: 0x24B83F0 VA: 0x1824B91F0
	internal static SortingGroup GetSortingGroupByIndex(int index) { }

	// RVA: 0x24B9410 Offset: 0x24B8610 VA: 0x1824B9410
	public string get_sortingLayerName() { }

	// RVA: 0x24B9520 Offset: 0x24B8720 VA: 0x1824B9520
	public void set_sortingLayerName(string value) { }

	// RVA: 0x24B93D0 Offset: 0x24B85D0 VA: 0x1824B93D0
	public int get_sortingLayerID() { }

	// RVA: 0x24B94E0 Offset: 0x24B86E0 VA: 0x1824B94E0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x24B9450 Offset: 0x24B8650 VA: 0x1824B9450
	public int get_sortingOrder() { }

	// RVA: 0x24B9570 Offset: 0x24B8770 VA: 0x1824B9570
	public void set_sortingOrder(int value) { }

	// RVA: 0x24B92D0 Offset: 0x24B84D0 VA: 0x1824B92D0
	public bool get_sortAtRoot() { }

	// RVA: 0x24B9490 Offset: 0x24B8690 VA: 0x1824B9490
	public void set_sortAtRoot(bool value) { }

	// RVA: 0x24B9310 Offset: 0x24B8510 VA: 0x1824B9310
	internal int get_sortingGroupID() { }

	// RVA: 0x24B9350 Offset: 0x24B8550 VA: 0x1824B9350
	internal int get_sortingGroupOrder() { }

	// RVA: 0x24B9260 Offset: 0x24B8460 VA: 0x1824B9260
	internal int get_index() { }

	// RVA: 0x24B9390 Offset: 0x24B8590 VA: 0x1824B9390
	internal uint get_sortingKey() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Flags]
internal enum FrameData.Flags // TypeDefIndex: 14550
{
	// Fields
	public int value__; // 0x0
	public const FrameData.Flags Evaluate = 1;
	public const FrameData.Flags SeekOccured = 2;
	public const FrameData.Flags Loop = 4;
	public const FrameData.Flags Hold = 8;
	public const FrameData.Flags EffectivePlayStateDelayed = 16;
	public const FrameData.Flags EffectivePlayStatePlaying = 32;
}

// Namespace: UnityEngine.Playables
public struct FrameData // TypeDefIndex: 14551
{
	// Fields
	internal ulong m_FrameID; // 0x0
	internal double m_DeltaTime; // 0x8
	internal float m_Weight; // 0x10
	internal float m_EffectiveWeight; // 0x14
	internal double m_EffectiveParentDelay; // 0x18
	internal float m_EffectiveParentSpeed; // 0x20
	internal float m_EffectiveSpeed; // 0x24
	internal FrameData.Flags m_Flags; // 0x28
	internal PlayableOutput m_Output; // 0x30
}

// Namespace: UnityEngine.Playables
public interface INotification // TypeDefIndex: 14552
{}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public interface INotificationReceiver // TypeDefIndex: 14553
{
	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNotify(Playable origin, INotification notification, object context);
}

// Namespace: UnityEngine.Playables
public interface IPlayableBehaviour // TypeDefIndex: 14554
{
	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnGraphStart(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGraphStop(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPlayableCreate(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPlayableDestroy(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnBehaviourPlay(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnBehaviourPause(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PrepareFrame(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ProcessFrame(Playable playable, FrameData info, object playerData);
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public struct Playable : IEquatable<Playable> // TypeDefIndex: 14555
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0x24B4570 Offset: 0x24B3770 VA: 0x1824B4570
	public static Playable get_Null() { }

	[VisibleToOtherModules]
	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x24B43F0 Offset: 0x24B35F0 VA: 0x1824B43F0 Slot: 4
	public bool Equals(Playable other) { }

	// RVA: 0x24B44D0 Offset: 0x24B36D0 VA: 0x1824B44D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[AssetFileNameExtension("playable", new[] {  })]
[RequiredByNativeCode]
[Serializable]
public abstract class PlayableAsset : ScriptableObject // TypeDefIndex: 14556
{
	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	// RVA: 0x24B39D0 Offset: 0x24B2BD0 VA: 0x1824B39D0 Slot: 5
	public virtual double get_duration() { }

	// RVA: 0x24B3A20 Offset: 0x24B2C20 VA: 0x1824B3A20 Slot: 6
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCode]
	// RVA: 0x24B3860 Offset: 0x24B2A60 VA: 0x1824B3860
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCode]
	// RVA: 0x24B3990 Offset: 0x24B2B90 VA: 0x1824B3990
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
[Serializable]
public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable // TypeDefIndex: 14557
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 14
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 17
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 18
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 19
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 20
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x24B3A70 Offset: 0x24B2C70 VA: 0x1824B3A70 Slot: 21
	public virtual object Clone() { }
}

// Namespace: 
[VisibleToOtherModules]
internal sealed class PlayableBinding.CreateOutputMethod : MulticastDelegate // TypeDefIndex: 14558
{
	// Methods

	// RVA: 0x24B0910 Offset: 0x24AFB10 VA: 0x1824B0910
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B08D0 Offset: 0x24AFAD0 VA: 0x1824B08D0 Slot: 13
	public virtual PlayableOutput Invoke(PlayableGraph graph, string name) { }
}

// Namespace: UnityEngine.Playables
public struct PlayableBinding // TypeDefIndex: 14559
{
	// Fields
	private string m_StreamName; // 0x0
	private Object m_SourceObject; // 0x8
	private Type m_SourceBindingType; // 0x10
	private PlayableBinding.CreateOutputMethod m_CreateOutputMethod; // 0x18
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly double DefaultDuration; // 0x8

	// Methods

	// RVA: 0x24B3A80 Offset: 0x24B2C80 VA: 0x1824B3A80
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[UsedByNativeCode]
public struct PlayableGraph // TypeDefIndex: 14560
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
}

// Namespace: UnityEngine.Playables
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 14561
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	// Properties
	public static PlayableHandle Null { get; }

	// Methods

	[VisibleToOtherModules]
	// RVA: -1 Offset: -1
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59CD0 Offset: 0xA58ED0 VA: 0x180A59CD0
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	|-PlayableHandle.IsPlayableOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x24B3EC0 Offset: 0x24B30C0 VA: 0x1824B3EC0
	public static PlayableHandle get_Null() { }

	// RVA: 0x24B3F20 Offset: 0x24B3120 VA: 0x1824B3F20
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x24B3B40 Offset: 0x24B2D40 VA: 0x1824B3B40 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x24B3C60 Offset: 0x24B2E60 VA: 0x1824B3C60 Slot: 4
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x24B3CF0 Offset: 0x24B2EF0 VA: 0x1824B3CF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24B3AF0 Offset: 0x24B2CF0 VA: 0x1824B3AF0
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[VisibleToOtherModules]
	// RVA: 0x24B3E10 Offset: 0x24B3010 VA: 0x1824B3E10
	internal bool IsValid() { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24B3D60 Offset: 0x24B2F60 VA: 0x1824B3D60
	internal Type GetPlayableType() { }

	// RVA: 0x24B3E80 Offset: 0x24B3080 VA: 0x1824B3E80
	private static void .cctor() { }

	// RVA: 0x24B3DD0 Offset: 0x24B2FD0 VA: 0x1824B3DD0
	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x24B3D20 Offset: 0x24B2F20 VA: 0x1824B3D20
	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public struct PlayableOutput : IEquatable<PlayableOutput> // TypeDefIndex: 14562
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Methods

	[VisibleToOtherModules]
	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x24B4270 Offset: 0x24B3470 VA: 0x1824B4270 Slot: 4
	public bool Equals(PlayableOutput other) { }

	// RVA: 0x24B4350 Offset: 0x24B3550 VA: 0x1824B4350
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[UsedByNativeCode]
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 14563
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0x24B4190 Offset: 0x24B3390 VA: 0x1824B4190
	public static PlayableOutputHandle get_Null() { }

	// RVA: 0x24B3CF0 Offset: 0x24B2EF0 VA: 0x1824B3CF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24B41F0 Offset: 0x24B33F0 VA: 0x1824B41F0
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x24B3FA0 Offset: 0x24B31A0 VA: 0x1824B3FA0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x24B40C0 Offset: 0x24B32C0 VA: 0x1824B40C0 Slot: 4
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x24B3AF0 Offset: 0x24B2CF0 VA: 0x1824B3AF0
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x24B4150 Offset: 0x24B3350 VA: 0x1824B4150
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public struct ScriptPlayableOutput // TypeDefIndex: 14564
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}

// Namespace: UnityEngine.Experimental.U2D
[RequiredByNativeCode]
[NativeHeader("Runtime/2D/Renderer/SpriteRendererGroup.h")]
internal struct SpriteIntermediateRendererInfo // TypeDefIndex: 14565
{
	// Fields
	public int SpriteID; // 0x0
	public int TextureID; // 0x4
	public int MaterialID; // 0x8
	public Color Color; // 0xC
	public Matrix4x4 Transform; // 0x1C
	public Bounds Bounds; // 0x5C
	public int Layer; // 0x74
	public int SortingLayer; // 0x78
	public int SortingOrder; // 0x7C
	public ulong SceneCullingMask; // 0x80
	public IntPtr IndexData; // 0x88
	public IntPtr VertexData; // 0x90
	public int IndexCount; // 0x98
	public int VertexCount; // 0x9C
	public int ShaderChannelMask; // 0xA0
}

// Namespace: UnityEngine.Experimental.U2D
[NativeHeader("Runtime/2D/Renderer/SpriteRendererGroup.h")]
[RequiredByNativeCode]
internal class SpriteRendererGroup // TypeDefIndex: 14566
{}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum LightType // TypeDefIndex: 14567
{
	// Fields
	public byte value__; // 0x0
	public const LightType Directional = 0;
	public const LightType Point = 1;
	public const LightType Spot = 2;
	public const LightType Rectangle = 3;
	public const LightType Disc = 4;
	public const LightType SpotPyramidShape = 5;
	public const LightType SpotBoxShape = 6;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum LightMode // TypeDefIndex: 14568
{
	// Fields
	public byte value__; // 0x0
	public const LightMode Realtime = 0;
	public const LightMode Mixed = 1;
	public const LightMode Baked = 2;
	public const LightMode Unknown = 3;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum FalloffType // TypeDefIndex: 14569
{
	// Fields
	public byte value__; // 0x0
	public const FalloffType InverseSquared = 0;
	public const FalloffType InverseSquaredNoRangeAttenuation = 1;
	public const FalloffType Linear = 2;
	public const FalloffType Legacy = 3;
	public const FalloffType Undefined = 4;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum AngularFalloffType // TypeDefIndex: 14570
{
	// Fields
	public byte value__; // 0x0
	public const AngularFalloffType LUT = 0;
	public const AngularFalloffType AnalyticAndInnerAngle = 1;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct LinearColor // TypeDefIndex: 14571
{
	// Fields
	private float m_red; // 0x0
	private float m_green; // 0x4
	private float m_blue; // 0x8
	private float m_intensity; // 0xC

	// Properties
	public float red { get; set; }
	public float green { get; set; }
	public float blue { get; set; }

	// Methods

	// RVA: 0x758EB0 Offset: 0x7580B0 VA: 0x180758EB0
	public float get_red() { }

	// RVA: 0x24B3080 Offset: 0x24B2280 VA: 0x1824B3080
	public void set_red(float value) { }

	// RVA: 0x758EC0 Offset: 0x7580C0 VA: 0x180758EC0
	public float get_green() { }

	// RVA: 0x24B2FC0 Offset: 0x24B21C0 VA: 0x1824B2FC0
	public void set_green(float value) { }

	// RVA: 0x576F00 Offset: 0x576100 VA: 0x180576F00
	public float get_blue() { }

	// RVA: 0x24B2F00 Offset: 0x24B2100 VA: 0x1824B2F00
	public void set_blue(float value) { }

	// RVA: 0x24B2BD0 Offset: 0x24B1DD0 VA: 0x1824B2BD0
	public static LinearColor Convert(Color color, float intensity) { }

	// RVA: 0x24B2BA0 Offset: 0x24B1DA0 VA: 0x1824B2BA0
	public static LinearColor Black() { }
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct DirectionalLight // TypeDefIndex: 14572
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float penumbraWidthRadian; // 0x44
	[Obsolete("Directional lights support cookies now. In order to position the cookie projection in the world, a position and full orientation are necessary. Use the position and orientation members instead of the direction parameter.", True)]
	public Vector3 direction; // 0x48
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct PointLight // TypeDefIndex: 14573
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float sphereRadius; // 0x48
	public FalloffType falloff; // 0x4C
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct SpotLight // TypeDefIndex: 14574
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float sphereRadius; // 0x48
	public float coneAngle; // 0x4C
	public float innerConeAngle; // 0x50
	public FalloffType falloff; // 0x54
	public AngularFalloffType angularFalloff; // 0x55
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct RectangleLight // TypeDefIndex: 14575
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float width; // 0x48
	public float height; // 0x4C
	public FalloffType falloff; // 0x50
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct DiscLight // TypeDefIndex: 14576
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float radius; // 0x48
	public FalloffType falloff; // 0x4C
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct Cookie // TypeDefIndex: 14577
{
	// Fields
	public int instanceID; // 0x0
	public float scale; // 0x4
	public Vector2 sizes; // 0x8
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
[UsedByNativeCode]
public struct LightDataGI // TypeDefIndex: 14578
{
	// Fields
	public int instanceID; // 0x0
	public int cookieID; // 0x4
	public float cookieScale; // 0x8
	public LinearColor color; // 0xC
	public LinearColor indirectColor; // 0x1C
	public Quaternion orientation; // 0x2C
	public Vector3 position; // 0x3C
	public float range; // 0x48
	public float coneAngle; // 0x4C
	public float innerConeAngle; // 0x50
	public float shape0; // 0x54
	public float shape1; // 0x58
	public LightType type; // 0x5C
	public LightMode mode; // 0x5D
	public byte shadow; // 0x5E
	public FalloffType falloff; // 0x5F

	// Methods

	// RVA: 0x24B1730 Offset: 0x24B0930 VA: 0x1824B1730
	public void Init(ref DirectionalLight light, ref Cookie cookie) { }

	// RVA: 0x24B17B0 Offset: 0x24B09B0 VA: 0x1824B17B0
	public void Init(ref PointLight light, ref Cookie cookie) { }

	// RVA: 0x24B16B0 Offset: 0x24B08B0 VA: 0x1824B16B0
	public void Init(ref SpotLight light, ref Cookie cookie) { }

	// RVA: 0x24B1890 Offset: 0x24B0A90 VA: 0x1824B1890
	public void Init(ref RectangleLight light, ref Cookie cookie) { }

	// RVA: 0x24B1820 Offset: 0x24B0A20 VA: 0x1824B1820
	public void Init(ref DiscLight light, ref Cookie cookie) { }

	// RVA: 0x24B16A0 Offset: 0x24B08A0 VA: 0x1824B16A0
	public void InitNoBake(int lightInstanceID) { }
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class LightmapperUtils // TypeDefIndex: 14579
{
	// Methods

	// RVA: 0x24B23A0 Offset: 0x24B15A0 VA: 0x1824B23A0
	public static LightMode Extract(LightmapBakeType baketype) { }

	// RVA: 0x24B1A00 Offset: 0x24B0C00 VA: 0x1824B1A00
	public static LinearColor ExtractIndirect(Light l) { }

	// RVA: 0x24B1A90 Offset: 0x24B0C90 VA: 0x1824B1A90
	public static float ExtractInnerCone(Light l) { }

	// RVA: 0x24B1960 Offset: 0x24B0B60 VA: 0x1824B1960
	private static Color ExtractColorTemperature(Light l) { }

	// RVA: 0x24B1900 Offset: 0x24B0B00 VA: 0x1824B1900
	private static void ApplyColorTemperature(Color cct, ref LinearColor lightColor) { }

	// RVA: 0x24B1DD0 Offset: 0x24B0FD0 VA: 0x1824B1DD0
	public static void Extract(Light l, ref DirectionalLight dir) { }

	// RVA: 0x24B20B0 Offset: 0x24B12B0 VA: 0x1824B20B0
	public static void Extract(Light l, ref PointLight point) { }

	// RVA: 0x24B23C0 Offset: 0x24B15C0 VA: 0x1824B23C0
	public static void Extract(Light l, ref SpotLight spot) { }

	// RVA: 0x24B1AE0 Offset: 0x24B0CE0 VA: 0x1824B1AE0
	public static void Extract(Light l, ref RectangleLight rect) { }

	// RVA: 0x24B20B0 Offset: 0x24B12B0 VA: 0x1824B20B0
	public static void Extract(Light l, ref DiscLight disc) { }

	// RVA: 0x24B2710 Offset: 0x24B1910 VA: 0x1824B2710
	public static void Extract(Light l, out Cookie cookie) { }
}

// Namespace: 
public sealed class Lightmapping.RequestLightsDelegate : MulticastDelegate // TypeDefIndex: 14580
{
	// Methods

	// RVA: 0x24B7EE0 Offset: 0x24B70E0 VA: 0x1824B7EE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x44A010 Offset: 0x449210 VA: 0x18044A010 Slot: 13
	public virtual void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Lightmapping.<>c // TypeDefIndex: 14581
{
	// Fields
	public static readonly Lightmapping.<>c <>9; // 0x0

	// Methods

	// RVA: 0x24BAFF0 Offset: 0x24BA1F0 VA: 0x1824BAFF0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24BA9F0 Offset: 0x24B9BF0 VA: 0x1824BA9F0
	internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class Lightmapping // TypeDefIndex: 14582
{
	// Fields
	[RequiredByNativeCode]
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCode]
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24B29D0 Offset: 0x24B1BD0 VA: 0x1824B29D0
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCode]
	// RVA: 0x24B2850 Offset: 0x24B1A50 VA: 0x1824B2850
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCode]
	// RVA: 0x24B2980 Offset: 0x24B1B80 VA: 0x1824B2980
	public static void ResetDelegate() { }

	[RequiredByNativeCode]
	// RVA: 0x24B28A0 Offset: 0x24B1AA0 VA: 0x1824B28A0
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x24B2A60 Offset: 0x24B1C60 VA: 0x1824B2A60
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Playables
[RequiredByNativeCode]
[NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
[StaticAccessor("CameraPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
public struct CameraPlayable : IEquatable<CameraPlayable> // TypeDefIndex: 14583
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x24AD800 Offset: 0x24ACA00 VA: 0x1824AD800 Slot: 4
	public bool Equals(CameraPlayable other) { }
}

// Namespace: UnityEngine.Experimental.Playables
[RequiredByNativeCode]
[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
[StaticAccessor("MaterialEffectPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct MaterialEffectPlayable : IEquatable<MaterialEffectPlayable> // TypeDefIndex: 14584
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x24B3350 Offset: 0x24B2550 VA: 0x1824B3350 Slot: 4
	public bool Equals(MaterialEffectPlayable other) { }
}

// Namespace: UnityEngine.Experimental.Playables
[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
[StaticAccessor("TextureMixerPlayableBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct TextureMixerPlayable : IEquatable<TextureMixerPlayable> // TypeDefIndex: 14585
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x24BA930 Offset: 0x24B9B30 VA: 0x1824BA930 Slot: 4
	public bool Equals(TextureMixerPlayable other) { }
}

// Namespace: UnityEngine.Experimental.Playables
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[StaticAccessor("TexturePlayableOutputBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
[NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
public struct TexturePlayableOutput // TypeDefIndex: 14586
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}

// Namespace: UnityEngine.Experimental.Rendering
[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable // TypeDefIndex: 14587
{
	// Methods

	// RVA: 0x24AD770 Offset: 0x24AC970 VA: 0x1824AD770 Slot: 4
	public bool TickRealtimeProbes() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Dispose(bool disposing) { }

	[StaticAccessor("GetReflectionProbes()", Type = 0)]
	// RVA: 0x24AD770 Offset: 0x24AC970 VA: 0x1824AD770
	private static bool BuiltinUpdate() { }

	[RequiredByNativeCode]
	// RVA: 0x24AD7A0 Offset: 0x24AC9A0 VA: 0x1824AD7A0
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
public interface IScriptableRuntimeReflectionSystem : IDisposable // TypeDefIndex: 14588
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TickRealtimeProbes();
}

// Namespace: UnityEngine.Experimental.Rendering
[RequiredByNativeCode]
[NativeHeader("Runtime/Camera/ScriptableRuntimeReflectionSystem.h")]
public static class ScriptableRuntimeReflectionSystemSettings // TypeDefIndex: 14589
{
	// Fields
	private static ScriptableRuntimeReflectionSystemWrapper s_Instance; // 0x0

	// Properties
	private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system { set; }
	private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24B8FB0 Offset: 0x24B81B0 VA: 0x1824B8FB0
	private static void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

	[RequiredByNativeCode]
	// RVA: 0x24B8F60 Offset: 0x24B8160 VA: 0x1824B8F60
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	[StaticAccessor("ScriptableRuntimeReflectionSystem", 2)]
	[RuntimeInitializeOnLoadMethod(0)]
	// RVA: 0x24B8ED0 Offset: 0x24B80D0 VA: 0x1824B8ED0
	private static void ScriptingDirtyReflectionSystemInstance() { }

	// RVA: 0x24B8F00 Offset: 0x24B8100 VA: 0x1824B8F00
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
[RequiredByNativeCode]
internal class ScriptableRuntimeReflectionSystemWrapper // TypeDefIndex: 14590
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private IScriptableRuntimeReflectionSystem <implementation>k__BackingField; // 0x10

	// Properties
	internal IScriptableRuntimeReflectionSystem implementation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal IScriptableRuntimeReflectionSystem get_implementation() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_implementation(IScriptableRuntimeReflectionSystem value) { }

	[RequiredByNativeCode]
	// RVA: 0x24B90C0 Offset: 0x24B82C0 VA: 0x1824B90C0
	private void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out bool result) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
[Flags]
public enum TextureCreationFlags // TypeDefIndex: 14591
{
	// Fields
	public int value__; // 0x0
	public const TextureCreationFlags None = 0;
	public const TextureCreationFlags MipChain = 1;
	public const TextureCreationFlags DontInitializePixels = 4;
	public const TextureCreationFlags Crunch = 64;
	public const TextureCreationFlags DontUploadUponCreate = 1024;
	public const TextureCreationFlags IgnoreMipmapLimit = 2048;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum FormatUsage // TypeDefIndex: 14592
{
	// Fields
	public int value__; // 0x0
	public const FormatUsage Sample = 0;
	public const FormatUsage Linear = 1;
	public const FormatUsage Sparse = 2;
	public const FormatUsage Render = 4;
	public const FormatUsage Blend = 5;
	public const FormatUsage GetPixels = 6;
	public const FormatUsage SetPixels = 7;
	public const FormatUsage SetPixels32 = 8;
	public const FormatUsage ReadPixels = 9;
	public const FormatUsage LoadStore = 10;
	public const FormatUsage MSAA2x = 11;
	public const FormatUsage MSAA4x = 12;
	public const FormatUsage MSAA8x = 13;
	public const FormatUsage StencilSampling = 16;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum DefaultFormat // TypeDefIndex: 14593
{
	// Fields
	public int value__; // 0x0
	public const DefaultFormat LDR = 0;
	public const DefaultFormat HDR = 1;
	public const DefaultFormat DepthStencil = 2;
	public const DefaultFormat Shadow = 3;
	public const DefaultFormat Video = 4;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum GraphicsFormat // TypeDefIndex: 14594
{
	// Fields
	public int value__; // 0x0
	public const GraphicsFormat None = 0;
	public const GraphicsFormat R8_SRGB = 1;
	public const GraphicsFormat R8G8_SRGB = 2;
	public const GraphicsFormat R8G8B8_SRGB = 3;
	public const GraphicsFormat R8G8B8A8_SRGB = 4;
	public const GraphicsFormat R8_UNorm = 5;
	public const GraphicsFormat R8G8_UNorm = 6;
	public const GraphicsFormat R8G8B8_UNorm = 7;
	public const GraphicsFormat R8G8B8A8_UNorm = 8;
	public const GraphicsFormat R8_SNorm = 9;
	public const GraphicsFormat R8G8_SNorm = 10;
	public const GraphicsFormat R8G8B8_SNorm = 11;
	public const GraphicsFormat R8G8B8A8_SNorm = 12;
	public const GraphicsFormat R8_UInt = 13;
	public const GraphicsFormat R8G8_UInt = 14;
	public const GraphicsFormat R8G8B8_UInt = 15;
	public const GraphicsFormat R8G8B8A8_UInt = 16;
	public const GraphicsFormat R8_SInt = 17;
	public const GraphicsFormat R8G8_SInt = 18;
	public const GraphicsFormat R8G8B8_SInt = 19;
	public const GraphicsFormat R8G8B8A8_SInt = 20;
	public const GraphicsFormat R16_UNorm = 21;
	public const GraphicsFormat R16G16_UNorm = 22;
	public const GraphicsFormat R16G16B16_UNorm = 23;
	public const GraphicsFormat R16G16B16A16_UNorm = 24;
	public const GraphicsFormat R16_SNorm = 25;
	public const GraphicsFormat R16G16_SNorm = 26;
	public const GraphicsFormat R16G16B16_SNorm = 27;
	public const GraphicsFormat R16G16B16A16_SNorm = 28;
	public const GraphicsFormat R16_UInt = 29;
	public const GraphicsFormat R16G16_UInt = 30;
	public const GraphicsFormat R16G16B16_UInt = 31;
	public const GraphicsFormat R16G16B16A16_UInt = 32;
	public const GraphicsFormat R16_SInt = 33;
	public const GraphicsFormat R16G16_SInt = 34;
	public const GraphicsFormat R16G16B16_SInt = 35;
	public const GraphicsFormat R16G16B16A16_SInt = 36;
	public const GraphicsFormat R32_UInt = 37;
	public const GraphicsFormat R32G32_UInt = 38;
	public const GraphicsFormat R32G32B32_UInt = 39;
	public const GraphicsFormat R32G32B32A32_UInt = 40;
	public const GraphicsFormat R32_SInt = 41;
	public const GraphicsFormat R32G32_SInt = 42;
	public const GraphicsFormat R32G32B32_SInt = 43;
	public const GraphicsFormat R32G32B32A32_SInt = 44;
	public const GraphicsFormat R16_SFloat = 45;
	public const GraphicsFormat R16G16_SFloat = 46;
	public const GraphicsFormat R16G16B16_SFloat = 47;
	public const GraphicsFormat R16G16B16A16_SFloat = 48;
	public const GraphicsFormat R32_SFloat = 49;
	public const GraphicsFormat R32G32_SFloat = 50;
	public const GraphicsFormat R32G32B32_SFloat = 51;
	public const GraphicsFormat R32G32B32A32_SFloat = 52;
	public const GraphicsFormat B8G8R8_SRGB = 56;
	public const GraphicsFormat B8G8R8A8_SRGB = 57;
	public const GraphicsFormat B8G8R8_UNorm = 58;
	public const GraphicsFormat B8G8R8A8_UNorm = 59;
	public const GraphicsFormat B8G8R8_SNorm = 60;
	public const GraphicsFormat B8G8R8A8_SNorm = 61;
	public const GraphicsFormat B8G8R8_UInt = 62;
	public const GraphicsFormat B8G8R8A8_UInt = 63;
	public const GraphicsFormat B8G8R8_SInt = 64;
	public const GraphicsFormat B8G8R8A8_SInt = 65;
	public const GraphicsFormat R4G4B4A4_UNormPack16 = 66;
	public const GraphicsFormat B4G4R4A4_UNormPack16 = 67;
	public const GraphicsFormat R5G6B5_UNormPack16 = 68;
	public const GraphicsFormat B5G6R5_UNormPack16 = 69;
	public const GraphicsFormat R5G5B5A1_UNormPack16 = 70;
	public const GraphicsFormat B5G5R5A1_UNormPack16 = 71;
	public const GraphicsFormat A1R5G5B5_UNormPack16 = 72;
	public const GraphicsFormat E5B9G9R9_UFloatPack32 = 73;
	public const GraphicsFormat B10G11R11_UFloatPack32 = 74;
	public const GraphicsFormat A2B10G10R10_UNormPack32 = 75;
	public const GraphicsFormat A2B10G10R10_UIntPack32 = 76;
	public const GraphicsFormat A2B10G10R10_SIntPack32 = 77;
	public const GraphicsFormat A2R10G10B10_UNormPack32 = 78;
	public const GraphicsFormat A2R10G10B10_UIntPack32 = 79;
	public const GraphicsFormat A2R10G10B10_SIntPack32 = 80;
	public const GraphicsFormat A2R10G10B10_XRSRGBPack32 = 81;
	public const GraphicsFormat A2R10G10B10_XRUNormPack32 = 82;
	public const GraphicsFormat R10G10B10_XRSRGBPack32 = 83;
	public const GraphicsFormat R10G10B10_XRUNormPack32 = 84;
	public const GraphicsFormat A10R10G10B10_XRSRGBPack32 = 85;
	public const GraphicsFormat A10R10G10B10_XRUNormPack32 = 86;
	public const GraphicsFormat D16_UNorm = 90;
	public const GraphicsFormat D24_UNorm = 91;
	public const GraphicsFormat D24_UNorm_S8_UInt = 92;
	public const GraphicsFormat D32_SFloat = 93;
	public const GraphicsFormat D32_SFloat_S8_UInt = 94;
	public const GraphicsFormat S8_UInt = 95;
	[EditorBrowsable(1)]
	[Obsolete("Enum member GraphicsFormat.RGB_DXT1_SRGB has been deprecated. Use GraphicsFormat.RGBA_DXT1_SRGB instead (UnityUpgradable) -> RGBA_DXT1_SRGB", True)]
	public const GraphicsFormat RGB_DXT1_SRGB = 96;
	public const GraphicsFormat RGBA_DXT1_SRGB = 96;
	[Obsolete("Enum member GraphicsFormat.RGB_DXT1_UNorm has been deprecated. Use GraphicsFormat.RGBA_DXT1_UNorm instead (UnityUpgradable) -> RGBA_DXT1_UNorm", True)]
	[EditorBrowsable(1)]
	public const GraphicsFormat RGB_DXT1_UNorm = 97;
	public const GraphicsFormat RGBA_DXT1_UNorm = 97;
	public const GraphicsFormat RGBA_DXT3_SRGB = 98;
	public const GraphicsFormat RGBA_DXT3_UNorm = 99;
	public const GraphicsFormat RGBA_DXT5_SRGB = 100;
	public const GraphicsFormat RGBA_DXT5_UNorm = 101;
	public const GraphicsFormat R_BC4_UNorm = 102;
	public const GraphicsFormat R_BC4_SNorm = 103;
	public const GraphicsFormat RG_BC5_UNorm = 104;
	public const GraphicsFormat RG_BC5_SNorm = 105;
	public const GraphicsFormat RGB_BC6H_UFloat = 106;
	public const GraphicsFormat RGB_BC6H_SFloat = 107;
	public const GraphicsFormat RGBA_BC7_SRGB = 108;
	public const GraphicsFormat RGBA_BC7_UNorm = 109;
	public const GraphicsFormat RGB_PVRTC_2Bpp_SRGB = 110;
	public const GraphicsFormat RGB_PVRTC_2Bpp_UNorm = 111;
	public const GraphicsFormat RGB_PVRTC_4Bpp_SRGB = 112;
	public const GraphicsFormat RGB_PVRTC_4Bpp_UNorm = 113;
	public const GraphicsFormat RGBA_PVRTC_2Bpp_SRGB = 114;
	public const GraphicsFormat RGBA_PVRTC_2Bpp_UNorm = 115;
	public const GraphicsFormat RGBA_PVRTC_4Bpp_SRGB = 116;
	public const GraphicsFormat RGBA_PVRTC_4Bpp_UNorm = 117;
	public const GraphicsFormat RGB_ETC_UNorm = 118;
	public const GraphicsFormat RGB_ETC2_SRGB = 119;
	public const GraphicsFormat RGB_ETC2_UNorm = 120;
	public const GraphicsFormat RGB_A1_ETC2_SRGB = 121;
	public const GraphicsFormat RGB_A1_ETC2_UNorm = 122;
	public const GraphicsFormat RGBA_ETC2_SRGB = 123;
	public const GraphicsFormat RGBA_ETC2_UNorm = 124;
	public const GraphicsFormat R_EAC_UNorm = 125;
	public const GraphicsFormat R_EAC_SNorm = 126;
	public const GraphicsFormat RG_EAC_UNorm = 127;
	public const GraphicsFormat RG_EAC_SNorm = 128;
	public const GraphicsFormat RGBA_ASTC4X4_SRGB = 129;
	public const GraphicsFormat RGBA_ASTC4X4_UNorm = 130;
	public const GraphicsFormat RGBA_ASTC5X5_SRGB = 131;
	public const GraphicsFormat RGBA_ASTC5X5_UNorm = 132;
	public const GraphicsFormat RGBA_ASTC6X6_SRGB = 133;
	public const GraphicsFormat RGBA_ASTC6X6_UNorm = 134;
	public const GraphicsFormat RGBA_ASTC8X8_SRGB = 135;
	public const GraphicsFormat RGBA_ASTC8X8_UNorm = 136;
	public const GraphicsFormat RGBA_ASTC10X10_SRGB = 137;
	public const GraphicsFormat RGBA_ASTC10X10_UNorm = 138;
	public const GraphicsFormat RGBA_ASTC12X12_SRGB = 139;
	public const GraphicsFormat RGBA_ASTC12X12_UNorm = 140;
	public const GraphicsFormat YUV2 = 141;
	[Obsolete("Enum member GraphicsFormat.DepthAuto has been deprecated. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default depth buffer format.", False)]
	public const GraphicsFormat DepthAuto = 142;
	[Obsolete("Enum member GraphicsFormat.ShadowAuto has been deprecated. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default shadow buffer format.", False)]
	public const GraphicsFormat ShadowAuto = 143;
	[Obsolete("Enum member GraphicsFormat.VideoAuto has been deprecated. Use DefaultFormat instead.", False)]
	public const GraphicsFormat VideoAuto = 144;
	public const GraphicsFormat RGBA_ASTC4X4_UFloat = 145;
	public const GraphicsFormat RGBA_ASTC5X5_UFloat = 146;
	public const GraphicsFormat RGBA_ASTC6X6_UFloat = 147;
	public const GraphicsFormat RGBA_ASTC8X8_UFloat = 148;
	public const GraphicsFormat RGBA_ASTC10X10_UFloat = 149;
	public const GraphicsFormat RGBA_ASTC12X12_UFloat = 150;
	public const GraphicsFormat D16_UNorm_S8_UInt = 151;
}

// Namespace: UnityEngine.Experimental.Rendering
[NativeHeader("Runtime/Graphics/Format.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Graphics/TextureFormat.h")]
public class GraphicsFormatUtility // TypeDefIndex: 14595
{
	// Fields
	private static readonly GraphicsFormat[] tableNoStencil; // 0x0
	private static readonly GraphicsFormat[] tableStencil; // 0x8

	// Methods

	// RVA: 0x24B10C0 Offset: 0x24B02C0 VA: 0x1824B10C0
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x24B0F30 Offset: 0x24B0130 VA: 0x1824B0F30
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x24B1040 Offset: 0x24B0240 VA: 0x1824B1040
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = False)]
	// RVA: 0x24B0EF0 Offset: 0x24B00F0 VA: 0x1824B0EF0
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x24B0F70 Offset: 0x24B0170 VA: 0x1824B0F70
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x24B0BB0 Offset: 0x24AFDB0 VA: 0x1824B0BB0
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	// RVA: 0x24B0BF0 Offset: 0x24AFDF0 VA: 0x1824B0BF0
	internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x24B0B70 Offset: 0x24AFD70 VA: 0x1824B0B70
	public static int GetDepthBits(GraphicsFormat format) { }

	// RVA: 0x24B0C60 Offset: 0x24AFE60 VA: 0x1824B0C60
	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x24B12B0 Offset: 0x24B04B0 VA: 0x1824B12B0
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x24B1140 Offset: 0x24B0340 VA: 0x1824B1140
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	// RVA: 0x24B1180 Offset: 0x24B0380 VA: 0x1824B1180
	public static bool IsCompressedFormat(TextureFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x24B0B30 Offset: 0x24AFD30 VA: 0x1824B0B30
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	// RVA: 0x24B0AC0 Offset: 0x24AFCC0 VA: 0x1824B0AC0
	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x24B1230 Offset: 0x24B0430 VA: 0x1824B1230
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x24B1270 Offset: 0x24B0470 VA: 0x1824B1270
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	[FreeFunction("IsCompressedCrunchTextureFormat", IsThreadSafe = True)]
	// RVA: 0x24B11F0 Offset: 0x24B03F0 VA: 0x1824B11F0
	public static bool IsCrunchFormat(TextureFormat format) { }

	// RVA: 0x24B12F0 Offset: 0x24B04F0 VA: 0x1824B12F0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Assertions
[DebuggerStepThrough]
public static class Assert // TypeDefIndex: 14596
{
	// Fields
	[Obsolete("Future versions of Unity are expected to always throw exceptions and not have this field.")]
	public static bool raiseExceptions; // 0x0

	// Methods

	// RVA: 0x24AC220 Offset: 0x24AB420 VA: 0x1824AC220
	private static void Fail(string message, string userMessage) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x24AC660 Offset: 0x24AB860 VA: 0x1824AC660
	public static void IsTrue(bool condition) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x24AC570 Offset: 0x24AB770 VA: 0x1824AC570
	public static void IsTrue(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x24AC340 Offset: 0x24AB540 VA: 0x1824AC340
	public static void IsFalse(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93AA80 Offset: 0x939C80 VA: 0x18093AA80
	|-Assert.AreEqual<Int32Enum>
	|
	|-RVA: 0x93B180 Offset: 0x93A380 VA: 0x18093B180
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x93A6A0 Offset: 0x9398A0 VA: 0x18093A6A0
	|-Assert.AreEqual<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93AC70 Offset: 0x939E70 VA: 0x18093AC70
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x93AAF0 Offset: 0x939CF0 VA: 0x18093AAF0
	|-Assert.AreEqual<Int32Enum>
	|
	|-RVA: 0x93B000 Offset: 0x93A200 VA: 0x18093B000
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x93A120 Offset: 0x939320 VA: 0x18093A120
	|-Assert.AreEqual<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93A800 Offset: 0x939A00 VA: 0x18093A800
	|-Assert.AreEqual<int>
	|-Assert.AreEqual<Int32Enum>
	|
	|-RVA: 0x93ADF0 Offset: 0x939FF0 VA: 0x18093ADF0
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x93A290 Offset: 0x939490 VA: 0x18093A290
	|-Assert.AreEqual<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x24AC170 Offset: 0x24AB370 VA: 0x1824AC170
	public static void AreEqual(Object expected, Object actual, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93B540 Offset: 0x93A740 VA: 0x18093B540
	|-Assert.IsNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNull<T>(T value, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93B700 Offset: 0x93A900 VA: 0x18093B700
	|-Assert.IsNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x24AC4D0 Offset: 0x24AB6D0 VA: 0x1824AC4D0
	public static void IsNull(Object value, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNotNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93B380 Offset: 0x93A580 VA: 0x18093B380
	|-Assert.IsNotNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNotNull<T>(T value, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93B200 Offset: 0x93A400 VA: 0x18093B200
	|-Assert.IsNotNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x24AC430 Offset: 0x24AB630 VA: 0x1824AC430
	public static void IsNotNull(Object value, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x24AC100 Offset: 0x24AB300 VA: 0x1824AC100
	public static void AreEqual(int expected, int actual) { }

	// RVA: 0x24AC780 Offset: 0x24AB980 VA: 0x1824AC780
	private static void .cctor() { }
}

// Namespace: UnityEngine.Assertions
public class AssertionException : Exception // TypeDefIndex: 14597
{
	// Fields
	private string m_UserMessage; // 0x90

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x24AC7C0 Offset: 0x24AB9C0 VA: 0x1824AC7C0
	public void .ctor(string message, string userMessage) { }

	// RVA: 0x24AC830 Offset: 0x24ABA30 VA: 0x1824AC830 Slot: 5
	public override string get_Message() { }
}

// Namespace: UnityEngine.Assertions
internal class AssertionMessageUtil // TypeDefIndex: 14598
{
	// Methods

	// RVA: 0x24ACDF0 Offset: 0x24ABFF0 VA: 0x1824ACDF0
	public static string GetMessage(string failureMessage) { }

	// RVA: 0x24ACB60 Offset: 0x24ABD60 VA: 0x1824ACB60
	public static string GetMessage(string failureMessage, string expected) { }

	// RVA: 0x24AC930 Offset: 0x24ABB30 VA: 0x1824AC930
	public static string GetEqualityMessage(object actual, object expected, bool expectEqual) { }

	// RVA: 0x24ACEF0 Offset: 0x24AC0F0 VA: 0x1824ACEF0
	public static string NullFailureMessage(object value, bool expectNull) { }

	// RVA: 0x24AC890 Offset: 0x24ABA90 VA: 0x1824AC890
	public static string BooleanFailureMessage(bool expected) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 // TypeDefIndex: 14599
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 14600
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 14601
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 0EBBFED81071BF15F38AA1387D6D74E5788591B4AA6E85C7B739CF903789D438 /*Metadata offset 0x8EEA98*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 39D974909C7E64675317DD1A8583B8D8DE92E68B180532FADD22B482AD93DC83 /*Metadata offset 0x8EEAA0*/; // 0x6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 C77A066B9EC0272B121AD30CBAEDA4AD20F986D49CC6D0007EBF45888D8B09BF /*Metadata offset 0x8EEAB8*/; // 0x1A
}

// Namespace: 
internal class <Module> // TypeDefIndex: 14602
{}

// Namespace: 
internal static class SR // TypeDefIndex: 14603
{
	// Methods

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	internal static string GetString(string name) { }

	// RVA: 0x1CFB8B0 Offset: 0x1CFAAB0 VA: 0x181CFB8B0
	internal static string Format(string resourceFormat, object[] args) { }

	// RVA: 0x1CFB7B0 Offset: 0x1CFA9B0 VA: 0x181CFB7B0
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x1CFB730 Offset: 0x1CFA930 VA: 0x181CFB730
	internal static string Format(string resourceFormat, object p1, object p2) { }

	// RVA: 0x1CFB820 Offset: 0x1CFAA20 VA: 0x181CFB820
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeMemoryMappedFileHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 14604
{
	// Methods

	// RVA: 0x1CFB960 Offset: 0x1CFAB60 VA: 0x181CFB960
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x1CFB930 Offset: 0x1CFAB30 VA: 0x181CFB930 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeMemoryMappedViewHandle : SafeBuffer // TypeDefIndex: 14605
{
	// Fields
	private IntPtr mmap_handle; // 0x28

	// Methods

	// RVA: 0x1CFBA20 Offset: 0x1CFAC20 VA: 0x181CFBA20
	internal void .ctor(IntPtr mmap_handle, IntPtr base_address, long size) { }

	// RVA: 0x1CFB990 Offset: 0x1CFAB90 VA: 0x181CFB990
	internal void Flush() { }

	// RVA: 0x1CFB9A0 Offset: 0x1CFABA0 VA: 0x181CFB9A0 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> : MulticastDelegate // TypeDefIndex: 14606
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BC590 Offset: 0x11BB790 VA: 0x1811BC590
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1630 Offset: 0xCF0830 VA: 0x180CF1630
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : MulticastDelegate // TypeDefIndex: 14607
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8AF0 Offset: 0x11B7CF0 VA: 0x1811B8AF0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8A70 Offset: 0x11B7C70 VA: 0x1811B8A70
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : MulticastDelegate // TypeDefIndex: 14608
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8C80 Offset: 0x11B7E80 VA: 0x1811B8C80
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8C00 Offset: 0x11B7E00 VA: 0x1811B8C00
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : MulticastDelegate // TypeDefIndex: 14609
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8E20 Offset: 0x11B8020 VA: 0x1811B8E20
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8D90 Offset: 0x11B7F90 VA: 0x1811B8D90
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : MulticastDelegate // TypeDefIndex: 14610
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8FD0 Offset: 0x11B81D0 VA: 0x1811B8FD0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8F30 Offset: 0x11B8130 VA: 0x1811B8F30
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : MulticastDelegate // TypeDefIndex: 14611
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B9190 Offset: 0x11B8390 VA: 0x1811B9190
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B90E0 Offset: 0x11B82E0 VA: 0x1811B90E0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : MulticastDelegate // TypeDefIndex: 14612
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B9360 Offset: 0x11B8560 VA: 0x1811B9360
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B92A0 Offset: 0x11B84A0 VA: 0x1811B92A0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : MulticastDelegate // TypeDefIndex: 14613
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B9540 Offset: 0x11B8740 VA: 0x1811B9540
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B9470 Offset: 0x11B8670 VA: 0x1811B9470
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : MulticastDelegate // TypeDefIndex: 14614
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1201D60 Offset: 0x1200F60 VA: 0x181201D60
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8A70 Offset: 0x11B7C70 VA: 0x1811B8A70
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : MulticastDelegate // TypeDefIndex: 14615
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1201E70 Offset: 0x1201070 VA: 0x181201E70
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8C00 Offset: 0x11B7E00 VA: 0x1811B8C00
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : MulticastDelegate // TypeDefIndex: 14616
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1201F80 Offset: 0x1201180 VA: 0x181201F80
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8D90 Offset: 0x11B7F90 VA: 0x1811B8D90
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : MulticastDelegate // TypeDefIndex: 14617
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1202090 Offset: 0x1201290 VA: 0x181202090
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8F30 Offset: 0x11B8130 VA: 0x1811B8F30
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : MulticastDelegate // TypeDefIndex: 14618
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12021A0 Offset: 0x12013A0 VA: 0x1812021A0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B90E0 Offset: 0x11B82E0 VA: 0x1811B90E0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : MulticastDelegate // TypeDefIndex: 14619
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12022B0 Offset: 0x12014B0 VA: 0x1812022B0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B92A0 Offset: 0x11B84A0 VA: 0x1811B92A0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : MulticastDelegate // TypeDefIndex: 14620
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12023C0 Offset: 0x12015C0 VA: 0x1812023C0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B9470 Offset: 0x11B8670 VA: 0x1811B9470
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> : MulticastDelegate // TypeDefIndex: 14621
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12025A0 Offset: 0x12017A0 VA: 0x1812025A0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12024D0 Offset: 0x12016D0 VA: 0x1812024D0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
internal static class MonoUtil // TypeDefIndex: 14622
{
	// Fields
	public static readonly bool IsUnix; // 0x0

	// Methods

	// RVA: 0x1CFB590 Offset: 0x1CFA790 VA: 0x181CFB590
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
public sealed class AesManaged : Aes // TypeDefIndex: 14623
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1CC96D0 Offset: 0x1CC88D0 VA: 0x181CC96D0
	public void .ctor() { }

	// RVA: 0x1CC9850 Offset: 0x1CC8A50 VA: 0x181CC9850 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x1CC9880 Offset: 0x1CC8A80 VA: 0x181CC9880 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x1CC9970 Offset: 0x1CC8B70 VA: 0x181CC9970 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1CC98E0 Offset: 0x1CC8AE0 VA: 0x181CC98E0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1CC99D0 Offset: 0x1CC8BD0 VA: 0x181CC99D0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1CC98B0 Offset: 0x1CC8AB0 VA: 0x181CC98B0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1CC99A0 Offset: 0x1CC8BA0 VA: 0x181CC99A0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1CC9910 Offset: 0x1CC8B10 VA: 0x181CC9910 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x1CC9A00 Offset: 0x1CC8C00 VA: 0x181CC9A00 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x1CC9940 Offset: 0x1CC8B40 VA: 0x181CC9940 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x1CC9AB0 Offset: 0x1CC8CB0 VA: 0x181CC9AB0 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x1CC93C0 Offset: 0x1CC85C0 VA: 0x181CC93C0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x1CC9220 Offset: 0x1CC8420 VA: 0x181CC9220 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1CC9590 Offset: 0x1CC8790 VA: 0x181CC9590 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x1CC93F0 Offset: 0x1CC85F0 VA: 0x181CC93F0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1CC95C0 Offset: 0x1CC87C0 VA: 0x181CC95C0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1CC9670 Offset: 0x1CC8870 VA: 0x181CC9670 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1CC96A0 Offset: 0x1CC88A0 VA: 0x181CC96A0 Slot: 24
	public override void GenerateKey() { }
}

// Namespace: System.Security.Cryptography
public abstract class ECDsa : AsymmetricAlgorithm // TypeDefIndex: 14624
{}

// Namespace: System.Security.Cryptography
public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 14625
{
	// Properties
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1CC90F0 Offset: 0x1CC82F0 VA: 0x181CC90F0
	public void .ctor() { }

	// RVA: 0x1CC90B0 Offset: 0x1CC82B0 VA: 0x181CC90B0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1CC90D0 Offset: 0x1CC82D0 VA: 0x181CC90D0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1CC8EA0 Offset: 0x1CC80A0 VA: 0x181CC8EA0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1CC8FA0 Offset: 0x1CC81A0 VA: 0x181CC8FA0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1CC9150 Offset: 0x1CC8350 VA: 0x181CC9150 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x1CC9170 Offset: 0x1CC8370 VA: 0x181CC9170 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1CC9160 Offset: 0x1CC8360 VA: 0x181CC9160 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1CC9190 Offset: 0x1CC8390 VA: 0x181CC9190 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1CC9180 Offset: 0x1CC8380 VA: 0x181CC9180 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x1CC91A0 Offset: 0x1CC83A0 VA: 0x181CC91A0 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x1CC9210 Offset: 0x1CC8410 VA: 0x181CC9210 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x15FE6C0 Offset: 0x15FD8C0 VA: 0x1815FE6C0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x15FE730 Offset: 0x15FD930 VA: 0x1815FE730 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x1CC90A0 Offset: 0x1CC82A0 VA: 0x181CC90A0 Slot: 5
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Security.Cryptography
internal class AesTransform : SymmetricTransform // TypeDefIndex: 14626
{
	// Fields
	private uint[] expandedKey; // 0x58
	private int Nk; // 0x60
	private int Nr; // 0x64
	private static readonly uint[] Rcon; // 0x0
	private static readonly byte[] SBox; // 0x8
	private static readonly byte[] iSBox; // 0x10
	private static readonly uint[] T0; // 0x18
	private static readonly uint[] T1; // 0x20
	private static readonly uint[] T2; // 0x28
	private static readonly uint[] T3; // 0x30
	private static readonly uint[] iT0; // 0x38
	private static readonly uint[] iT1; // 0x40
	private static readonly uint[] iT2; // 0x48
	private static readonly uint[] iT3; // 0x50

	// Methods

	// RVA: 0x1CCFB10 Offset: 0x1CCED10 VA: 0x181CCFB10
	public void .ctor(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x1CCC8E0 Offset: 0x1CCBAE0 VA: 0x181CCC8E0 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x1CCF6E0 Offset: 0x1CCE8E0 VA: 0x181CCF6E0
	private uint SubByte(uint a) { }

	// RVA: 0x1CCC910 Offset: 0x1CCBB10 VA: 0x181CCC910
	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x1CC9AE0 Offset: 0x1CC8CE0 VA: 0x181CC9AE0
	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x1CCF7E0 Offset: 0x1CCE9E0 VA: 0x181CCF7E0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[Extension]
public static class RSACertificateExtensions // TypeDefIndex: 14627
{
	// Methods

	[Extension]
	// RVA: 0x1CFB640 Offset: 0x1CFA840 VA: 0x181CFB640
	public static RSA GetRSAPublicKey(X509Certificate2 certificate) { }
}

// Namespace: System.Linq
internal static class Error // TypeDefIndex: 14628
{
	// Methods

	// RVA: 0x1CD7030 Offset: 0x1CD6230 VA: 0x181CD7030
	internal static Exception ArgumentNull(string s) { }

	// RVA: 0x1CD7090 Offset: 0x1CD6290 VA: 0x181CD7090
	internal static Exception ArgumentOutOfRange(string s) { }

	// RVA: 0x1CD70F0 Offset: 0x1CD62F0 VA: 0x181CD70F0
	internal static Exception MoreThanOneElement() { }

	// RVA: 0x1CD7150 Offset: 0x1CD6350 VA: 0x181CD7150
	internal static Exception MoreThanOneMatch() { }

	// RVA: 0x1CD71B0 Offset: 0x1CD63B0 VA: 0x181CD71B0
	internal static Exception NoElements() { }

	// RVA: 0x1CD7210 Offset: 0x1CD6410 VA: 0x181CD7210
	internal static Exception NoMatch() { }

	// RVA: 0x1CD7270 Offset: 0x1CD6470 VA: 0x181CD7270
	internal static Exception NotSupported() { }
}

// Namespace: 
private abstract class Enumerable.Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 14629
{
	// Fields
	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	// Properties
	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B2FE0 Offset: 0x12B21E0 VA: 0x1812B2FE0
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, object>>..ctor
	|-Enumerable.Iterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.Iterator<ValueTuple<object, object>>..ctor
	|-Enumerable.Iterator<bool>..ctor
	|-Enumerable.Iterator<byte>..ctor
	|-Enumerable.Iterator<ByteEnum>..ctor
	|-Enumerable.Iterator<int>..ctor
	|-Enumerable.Iterator<Int32Enum>..ctor
	|-Enumerable.Iterator<JsonElement>..ctor
	|-Enumerable.Iterator<object>..ctor
	|-Enumerable.Iterator<Resolution>..ctor
	|-Enumerable.Iterator<float>..ctor
	|-Enumerable.Iterator<StyleSelectorPart>..ctor
	|-Enumerable.Iterator<uint>..ctor
	|-Enumerable.Iterator<Vector2>..ctor
	|-Enumerable.Iterator<Vector4>..ctor
	|-Enumerable.Iterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>..ctor
	|-Enumerable.Iterator<QRCodeGenerator.AlignmentPattern>..ctor
	|-Enumerable.Iterator<QRCodeGenerator.Antilog>..ctor
	|-Enumerable.Iterator<QRCodeGenerator.PolynomItem>..ctor
	|-Enumerable.Iterator<QRCodeGenerator.VersionInfo>..ctor
	|
	|-RVA: 0x12B3020 Offset: 0x12B2220 VA: 0x1812B3020
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, int>>.get_Current
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, object>>.get_Current
	|-Enumerable.Iterator<StyleSelectorPart>.get_Current
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-Enumerable.Iterator<KeyValuePair<object, object>>.get_Current
	|-Enumerable.Iterator<ValueTuple<object, object>>.get_Current
	|-Enumerable.Iterator<JsonElement>.get_Current
	|-Enumerable.Iterator<Resolution>.get_Current
	|-Enumerable.Iterator<Vector4>.get_Current
	|-Enumerable.Iterator<QRCodeGenerator.AlignmentPattern>.get_Current
	|-Enumerable.Iterator<QRCodeGenerator.VersionInfo>.get_Current
	|
	|-RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	|-Enumerable.Iterator<bool>.get_Current
	|-Enumerable.Iterator<byte>.get_Current
	|-Enumerable.Iterator<ByteEnum>.get_Current
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-Enumerable.Iterator<int>.get_Current
	|-Enumerable.Iterator<Int32Enum>.get_Current
	|-Enumerable.Iterator<uint>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.Iterator<object>.get_Current
	|-Enumerable.Iterator<QRCodeGenerator.Antilog>.get_Current
	|-Enumerable.Iterator<QRCodeGenerator.PolynomItem>.get_Current
	|
	|-RVA: 0x485420 Offset: 0x484620 VA: 0x180485420
	|-Enumerable.Iterator<float>.get_Current
	|
	|-RVA: 0x12B30A0 Offset: 0x12B22A0 VA: 0x1812B30A0
	|-Enumerable.Iterator<Vector2>.get_Current
	|
	|-RVA: 0x11EF730 Offset: 0x11EE930 VA: 0x1811EF730
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x12B30C0 Offset: 0x12B22C0 VA: 0x1812B30C0
	|-Enumerable.Iterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Enumerable.Iterator<TSource> Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B2A50 Offset: 0x12B1C50 VA: 0x1812B2A50
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, int>>.Dispose
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, object>>.Dispose
	|-Enumerable.Iterator<StyleSelectorPart>.Dispose
	|
	|-RVA: 0x12B2A40 Offset: 0x12B1C40 VA: 0x1812B2A40
	|-Enumerable.Iterator<KeyValuePair<object, object>>.Dispose
	|-Enumerable.Iterator<ValueTuple<object, object>>.Dispose
	|-Enumerable.Iterator<JsonElement>.Dispose
	|-Enumerable.Iterator<Resolution>.Dispose
	|-Enumerable.Iterator<Vector4>.Dispose
	|-Enumerable.Iterator<QRCodeGenerator.AlignmentPattern>.Dispose
	|-Enumerable.Iterator<QRCodeGenerator.VersionInfo>.Dispose
	|
	|-RVA: 0x12B2A20 Offset: 0x12B1C20 VA: 0x1812B2A20
	|-Enumerable.Iterator<bool>.Dispose
	|-Enumerable.Iterator<byte>.Dispose
	|-Enumerable.Iterator<ByteEnum>.Dispose
	|
	|-RVA: 0x12B2A30 Offset: 0x12B1C30 VA: 0x1812B2A30
	|-Enumerable.Iterator<int>.Dispose
	|-Enumerable.Iterator<Int32Enum>.Dispose
	|-Enumerable.Iterator<float>.Dispose
	|-Enumerable.Iterator<uint>.Dispose
	|
	|-RVA: 0x12B2A70 Offset: 0x12B1C70 VA: 0x1812B2A70
	|-Enumerable.Iterator<object>.Dispose
	|-Enumerable.Iterator<Vector2>.Dispose
	|-Enumerable.Iterator<QRCodeGenerator.Antilog>.Dispose
	|-Enumerable.Iterator<QRCodeGenerator.PolynomItem>.Dispose
	|
	|-RVA: 0x12B2A80 Offset: 0x12B1C80 VA: 0x1812B2A80
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Dispose
	|
	|-RVA: 0x12B2B20 Offset: 0x12B1D20 VA: 0x1812B2B20
	|-Enumerable.Iterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B2B50 Offset: 0x12B1D50 VA: 0x1812B2B50
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, int>>.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, object>>.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<object, object>>.GetEnumerator
	|-Enumerable.Iterator<ValueTuple<object, object>>.GetEnumerator
	|-Enumerable.Iterator<bool>.GetEnumerator
	|-Enumerable.Iterator<byte>.GetEnumerator
	|-Enumerable.Iterator<ByteEnum>.GetEnumerator
	|-Enumerable.Iterator<int>.GetEnumerator
	|-Enumerable.Iterator<Int32Enum>.GetEnumerator
	|-Enumerable.Iterator<JsonElement>.GetEnumerator
	|-Enumerable.Iterator<object>.GetEnumerator
	|-Enumerable.Iterator<Resolution>.GetEnumerator
	|-Enumerable.Iterator<float>.GetEnumerator
	|-Enumerable.Iterator<StyleSelectorPart>.GetEnumerator
	|-Enumerable.Iterator<uint>.GetEnumerator
	|-Enumerable.Iterator<Vector2>.GetEnumerator
	|-Enumerable.Iterator<Vector4>.GetEnumerator
	|-Enumerable.Iterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.GetEnumerator
	|-Enumerable.Iterator<QRCodeGenerator.AlignmentPattern>.GetEnumerator
	|-Enumerable.Iterator<QRCodeGenerator.Antilog>.GetEnumerator
	|-Enumerable.Iterator<QRCodeGenerator.PolynomItem>.GetEnumerator
	|-Enumerable.Iterator<QRCodeGenerator.VersionInfo>.GetEnumerator
	|
	|-RVA: 0x12B2BD0 Offset: 0x12B1DD0 VA: 0x1812B2BD0
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Where
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B2E80 Offset: 0x12B2080 VA: 0x1812B2E80
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, int>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, object>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<StyleSelectorPart>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12B2DA0 Offset: 0x12B1FA0 VA: 0x1812B2DA0
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<JsonElement>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Vector4>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<QRCodeGenerator.AlignmentPattern>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<QRCodeGenerator.VersionInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12B2D70 Offset: 0x12B1F70 VA: 0x1812B2D70
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<byte>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<ByteEnum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12B2EC0 Offset: 0x12B20C0 VA: 0x1812B2EC0
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12B2EF0 Offset: 0x12B20F0 VA: 0x1812B2EF0
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12B2F20 Offset: 0x12B2120 VA: 0x1812B2F20
	|-Enumerable.Iterator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12B2DD0 Offset: 0x12B1FD0 VA: 0x1812B2DD0
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12B2F80 Offset: 0x12B2180 VA: 0x1812B2F80
	|-Enumerable.Iterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12B2F50 Offset: 0x12B2150 VA: 0x1812B2F50
	|-Enumerable.Iterator<QRCodeGenerator.Antilog>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<QRCodeGenerator.PolynomItem>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B2CD0 Offset: 0x12B1ED0 VA: 0x1812B2CD0
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, int>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, object>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<ByteEnum>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<int>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<JsonElement>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<float>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<StyleSelectorPart>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<QRCodeGenerator.AlignmentPattern>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<QRCodeGenerator.Antilog>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<QRCodeGenerator.PolynomItem>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<QRCodeGenerator.VersionInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12B2D50 Offset: 0x12B1F50 VA: 0x1812B2D50
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E1940 Offset: 0x8E0B40 VA: 0x1808E1940
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, int>>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<KeyValuePair<DiscardReasonWithCategory, object>>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<byte>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<ByteEnum>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<JsonElement>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<StyleSelectorPart>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<Vector2>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<Vector4>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<QRCodeGenerator.AlignmentPattern>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<QRCodeGenerator.Antilog>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<QRCodeGenerator.PolynomItem>.System.Collections.IEnumerator.Reset
	|-Enumerable.Iterator<QRCodeGenerator.VersionInfo>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
private class Enumerable.WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 14630
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3CDD0 Offset: 0xE3BFD0 VA: 0x180E3CDD0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|
	|-RVA: 0xE3CC20 Offset: 0xE3BE20 VA: 0x180E3CC20
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereEnumerableIterator<Resolution>..ctor
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.AlignmentPattern>..ctor
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.VersionInfo>..ctor
	|
	|-RVA: 0xE3CC70 Offset: 0xE3BE70 VA: 0x180E3CC70
	|-Enumerable.WhereEnumerableIterator<int>..ctor
	|-Enumerable.WhereEnumerableIterator<Int32Enum>..ctor
	|-Enumerable.WhereEnumerableIterator<object>..ctor
	|-Enumerable.WhereEnumerableIterator<float>..ctor
	|-Enumerable.WhereEnumerableIterator<uint>..ctor
	|-Enumerable.WhereEnumerableIterator<Vector2>..ctor
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.Antilog>..ctor
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.PolynomItem>..ctor
	|
	|-RVA: 0xE3CD10 Offset: 0xE3BF10 VA: 0x180E3CD10
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xE3CCC0 Offset: 0xE3BEC0 VA: 0x180E3CCC0
	|-Enumerable.WhereEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3BCE0 Offset: 0xE3AEE0 VA: 0x180E3BCE0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<DiscardReasonWithCategory, int>>.Clone
	|
	|-RVA: 0xE3BB00 Offset: 0xE3AD00 VA: 0x180E3BB00
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereEnumerableIterator<Resolution>.Clone
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.AlignmentPattern>.Clone
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.VersionInfo>.Clone
	|
	|-RVA: 0xE3BC50 Offset: 0xE3AE50 VA: 0x180E3BC50
	|-Enumerable.WhereEnumerableIterator<int>.Clone
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Clone
	|-Enumerable.WhereEnumerableIterator<object>.Clone
	|-Enumerable.WhereEnumerableIterator<float>.Clone
	|-Enumerable.WhereEnumerableIterator<uint>.Clone
	|-Enumerable.WhereEnumerableIterator<Vector2>.Clone
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.Antilog>.Clone
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.PolynomItem>.Clone
	|
	|-RVA: 0xE3BB90 Offset: 0xE3AD90 VA: 0x180E3BB90
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Clone
	|
	|-RVA: 0xE3BD70 Offset: 0xE3AF70 VA: 0x180E3BD70
	|-Enumerable.WhereEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3CF00 Offset: 0xE3C100 VA: 0x180E3CF00
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<DiscardReasonWithCategory, int>>.Dispose
	|
	|-RVA: 0xE3CE90 Offset: 0xE3C090 VA: 0x180E3CE90
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0xE3CE20 Offset: 0xE3C020 VA: 0x180E3CE20
	|-Enumerable.WhereEnumerableIterator<int>.Dispose
	|
	|-RVA: 0xE3DB90 Offset: 0xE3CD90 VA: 0x180E3DB90
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Dispose
	|
	|-RVA: 0xE3D8F0 Offset: 0xE3CAF0 VA: 0x180E3D8F0
	|-Enumerable.WhereEnumerableIterator<object>.Dispose
	|
	|-RVA: 0xE3D810 Offset: 0xE3CA10 VA: 0x180E3D810
	|-Enumerable.WhereEnumerableIterator<Resolution>.Dispose
	|
	|-RVA: 0xE3DB20 Offset: 0xE3CD20 VA: 0x180E3DB20
	|-Enumerable.WhereEnumerableIterator<float>.Dispose
	|
	|-RVA: 0xE3DC00 Offset: 0xE3CE00 VA: 0x180E3DC00
	|-Enumerable.WhereEnumerableIterator<uint>.Dispose
	|
	|-RVA: 0xE3D880 Offset: 0xE3CA80 VA: 0x180E3D880
	|-Enumerable.WhereEnumerableIterator<Vector2>.Dispose
	|
	|-RVA: 0xE3D710 Offset: 0xE3C910 VA: 0x180E3D710
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Dispose
	|
	|-RVA: 0xE3D6A0 Offset: 0xE3C8A0 VA: 0x180E3D6A0
	|-Enumerable.WhereEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Dispose
	|
	|-RVA: 0xE3DA40 Offset: 0xE3CC40 VA: 0x180E3DA40
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.AlignmentPattern>.Dispose
	|
	|-RVA: 0xE3D960 Offset: 0xE3CB60 VA: 0x180E3D960
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.Antilog>.Dispose
	|
	|-RVA: 0xE3DAB0 Offset: 0xE3CCB0 VA: 0x180E3DAB0
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.PolynomItem>.Dispose
	|
	|-RVA: 0xE3D9D0 Offset: 0xE3CBD0 VA: 0x180E3D9D0
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.VersionInfo>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3D280 Offset: 0xE3C480 VA: 0x180E3D280
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<DiscardReasonWithCategory, int>>.MoveNext
	|
	|-RVA: 0xE3D0C0 Offset: 0xE3C2C0 VA: 0x180E3D0C0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0xE3CF70 Offset: 0xE3C170 VA: 0x180E3CF70
	|-Enumerable.WhereEnumerableIterator<int>.MoveNext
	|
	|-RVA: 0xE3E820 Offset: 0xE3DA20 VA: 0x180E3E820
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0xE3E970 Offset: 0xE3DB70 VA: 0x180E3E970
	|-Enumerable.WhereEnumerableIterator<object>.MoveNext
	|
	|-RVA: 0xE3F1A0 Offset: 0xE3E3A0 VA: 0x180E3F1A0
	|-Enumerable.WhereEnumerableIterator<Resolution>.MoveNext
	|
	|-RVA: 0xE3EE30 Offset: 0xE3E030 VA: 0x180E3EE30
	|-Enumerable.WhereEnumerableIterator<float>.MoveNext
	|
	|-RVA: 0xE3EAC0 Offset: 0xE3DCC0 VA: 0x180E3EAC0
	|-Enumerable.WhereEnumerableIterator<uint>.MoveNext
	|
	|-RVA: 0xE3E3E0 Offset: 0xE3D5E0 VA: 0x180E3E3E0
	|-Enumerable.WhereEnumerableIterator<Vector2>.MoveNext
	|
	|-RVA: 0xE3DC70 Offset: 0xE3CE70 VA: 0x180E3DC70
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0xE3E5B0 Offset: 0xE3D7B0 VA: 0x180E3E5B0
	|-Enumerable.WhereEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.MoveNext
	|
	|-RVA: 0xE3E220 Offset: 0xE3D420 VA: 0x180E3E220
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.AlignmentPattern>.MoveNext
	|
	|-RVA: 0xE3EFF0 Offset: 0xE3E1F0 VA: 0x180E3EFF0
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.Antilog>.MoveNext
	|
	|-RVA: 0xE3E070 Offset: 0xE3D270 VA: 0x180E3E070
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.PolynomItem>.MoveNext
	|
	|-RVA: 0xE3EC70 Offset: 0xE3DE70 VA: 0x180E3EC70
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.VersionInfo>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F8300 Offset: 0x8F7500 VA: 0x1808F8300
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Select<KeyValuePair<object, object>>
	|
	|-RVA: 0x8F8260 Offset: 0x8F7460 VA: 0x1808F8260
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.AlignmentPattern>.Select<object>
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.VersionInfo>.Select<int>
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.VersionInfo>.Select<object>
	|
	|-RVA: 0x8F81C0 Offset: 0x8F73C0 VA: 0x1808F81C0
	|-Enumerable.WhereEnumerableIterator<int>.Select<int>
	|-Enumerable.WhereEnumerableIterator<int>.Select<object>
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Select<Int32Enum>
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Select<object>
	|-Enumerable.WhereEnumerableIterator<object>.Select<int>
	|-Enumerable.WhereEnumerableIterator<object>.Select<Int32Enum>
	|-Enumerable.WhereEnumerableIterator<object>.Select<object>
	|-Enumerable.WhereEnumerableIterator<object>.Select<float>
	|-Enumerable.WhereEnumerableIterator<object>.Select<uint>
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.Antilog>.Select<int>
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.PolynomItem>.Select<object>
	|
	|-RVA: 0x8F80E0 Offset: 0x8F72E0 VA: 0x1808F80E0
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x8F83A0 Offset: 0x8F75A0 VA: 0x1808F83A0
	|-Enumerable.WhereEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3D490 Offset: 0xE3C690 VA: 0x180E3D490
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<DiscardReasonWithCategory, int>>.Where
	|
	|-RVA: 0xE3D5F0 Offset: 0xE3C7F0 VA: 0x180E3D5F0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereEnumerableIterator<Resolution>.Where
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.AlignmentPattern>.Where
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.VersionInfo>.Where
	|
	|-RVA: 0xE3D540 Offset: 0xE3C740 VA: 0x180E3D540
	|-Enumerable.WhereEnumerableIterator<int>.Where
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Where
	|-Enumerable.WhereEnumerableIterator<uint>.Where
	|
	|-RVA: 0xE3F4C0 Offset: 0xE3E6C0 VA: 0x180E3F4C0
	|-Enumerable.WhereEnumerableIterator<object>.Where
	|
	|-RVA: 0xE3F360 Offset: 0xE3E560 VA: 0x180E3F360
	|-Enumerable.WhereEnumerableIterator<float>.Where
	|
	|-RVA: 0xE3F570 Offset: 0xE3E770 VA: 0x180E3F570
	|-Enumerable.WhereEnumerableIterator<Vector2>.Where
	|
	|-RVA: 0xE3F6D0 Offset: 0xE3E8D0 VA: 0x180E3F6D0
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Where
	|
	|-RVA: 0xE3F620 Offset: 0xE3E820 VA: 0x180E3F620
	|-Enumerable.WhereEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Where
	|
	|-RVA: 0xE3F410 Offset: 0xE3E610 VA: 0x180E3F410
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.Antilog>.Where
	|-Enumerable.WhereEnumerableIterator<QRCodeGenerator.PolynomItem>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereArrayIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 14631
{
	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3CDD0 Offset: 0xE3BFD0 VA: 0x180E3CDD0
	|-Enumerable.WhereArrayIterator<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|
	|-RVA: 0xE3CC20 Offset: 0xE3BE20 VA: 0x180E3CC20
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereArrayIterator<Resolution>..ctor
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.AlignmentPattern>..ctor
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.VersionInfo>..ctor
	|
	|-RVA: 0xE3CC70 Offset: 0xE3BE70 VA: 0x180E3CC70
	|-Enumerable.WhereArrayIterator<Int32Enum>..ctor
	|-Enumerable.WhereArrayIterator<object>..ctor
	|-Enumerable.WhereArrayIterator<float>..ctor
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.Antilog>..ctor
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.PolynomItem>..ctor
	|
	|-RVA: 0xE3CD10 Offset: 0xE3BF10 VA: 0x180E3CD10
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xE3CCC0 Offset: 0xE3BEC0 VA: 0x180E3CCC0
	|-Enumerable.WhereArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3BCE0 Offset: 0xE3AEE0 VA: 0x180E3BCE0
	|-Enumerable.WhereArrayIterator<KeyValuePair<DiscardReasonWithCategory, int>>.Clone
	|
	|-RVA: 0xE3BB00 Offset: 0xE3AD00 VA: 0x180E3BB00
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereArrayIterator<Resolution>.Clone
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.AlignmentPattern>.Clone
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.VersionInfo>.Clone
	|
	|-RVA: 0xE3BC50 Offset: 0xE3AE50 VA: 0x180E3BC50
	|-Enumerable.WhereArrayIterator<Int32Enum>.Clone
	|-Enumerable.WhereArrayIterator<object>.Clone
	|-Enumerable.WhereArrayIterator<float>.Clone
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.Antilog>.Clone
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.PolynomItem>.Clone
	|
	|-RVA: 0xE3BB90 Offset: 0xE3AD90 VA: 0x180E3BB90
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.Clone
	|
	|-RVA: 0xE3BD70 Offset: 0xE3AF70 VA: 0x180E3BD70
	|-Enumerable.WhereArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3C3C0 Offset: 0xE3B5C0 VA: 0x180E3C3C0
	|-Enumerable.WhereArrayIterator<KeyValuePair<DiscardReasonWithCategory, int>>.MoveNext
	|
	|-RVA: 0xE3BE00 Offset: 0xE3B000 VA: 0x180E3BE00
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereArrayIterator<Resolution>.MoveNext
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.AlignmentPattern>.MoveNext
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.VersionInfo>.MoveNext
	|
	|-RVA: 0xE3BFF0 Offset: 0xE3B1F0 VA: 0x180E3BFF0
	|-Enumerable.WhereArrayIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0xE3BEB0 Offset: 0xE3B0B0 VA: 0x180E3BEB0
	|-Enumerable.WhereArrayIterator<object>.MoveNext
	|
	|-RVA: 0xE3C490 Offset: 0xE3B690 VA: 0x180E3C490
	|-Enumerable.WhereArrayIterator<float>.MoveNext
	|
	|-RVA: 0xE3C090 Offset: 0xE3B290 VA: 0x180E3C090
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0xE3C530 Offset: 0xE3B730 VA: 0x180E3C530
	|-Enumerable.WhereArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.MoveNext
	|
	|-RVA: 0xE3BF50 Offset: 0xE3B150 VA: 0x180E3BF50
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.Antilog>.MoveNext
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.PolynomItem>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F8300 Offset: 0x8F7500 VA: 0x1808F8300
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Select<KeyValuePair<object, object>>
	|
	|-RVA: 0x8F8260 Offset: 0x8F7460 VA: 0x1808F8260
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.AlignmentPattern>.Select<object>
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.VersionInfo>.Select<int>
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.VersionInfo>.Select<object>
	|
	|-RVA: 0x8F81C0 Offset: 0x8F73C0 VA: 0x1808F81C0
	|-Enumerable.WhereArrayIterator<Int32Enum>.Select<Int32Enum>
	|-Enumerable.WhereArrayIterator<Int32Enum>.Select<object>
	|-Enumerable.WhereArrayIterator<object>.Select<int>
	|-Enumerable.WhereArrayIterator<object>.Select<Int32Enum>
	|-Enumerable.WhereArrayIterator<object>.Select<object>
	|-Enumerable.WhereArrayIterator<object>.Select<float>
	|-Enumerable.WhereArrayIterator<object>.Select<uint>
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.Antilog>.Select<int>
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.PolynomItem>.Select<object>
	|
	|-RVA: 0x8F80E0 Offset: 0x8F72E0 VA: 0x1808F80E0
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x8F83A0 Offset: 0x8F75A0 VA: 0x1808F83A0
	|-Enumerable.WhereArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3C880 Offset: 0xE3BA80 VA: 0x180E3C880
	|-Enumerable.WhereArrayIterator<KeyValuePair<DiscardReasonWithCategory, int>>.Where
	|
	|-RVA: 0xE3C7D0 Offset: 0xE3B9D0 VA: 0x180E3C7D0
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereArrayIterator<Resolution>.Where
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.AlignmentPattern>.Where
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.VersionInfo>.Where
	|
	|-RVA: 0xE3CA10 Offset: 0xE3BC10 VA: 0x180E3CA10
	|-Enumerable.WhereArrayIterator<Int32Enum>.Where
	|
	|-RVA: 0xE3C670 Offset: 0xE3B870 VA: 0x180E3C670
	|-Enumerable.WhereArrayIterator<object>.Where
	|
	|-RVA: 0xE3C720 Offset: 0xE3B920 VA: 0x180E3C720
	|-Enumerable.WhereArrayIterator<float>.Where
	|
	|-RVA: 0xE3C930 Offset: 0xE3BB30 VA: 0x180E3C930
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.Where
	|
	|-RVA: 0xE3CB70 Offset: 0xE3BD70 VA: 0x180E3CB70
	|-Enumerable.WhereArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Where
	|
	|-RVA: 0xE3CAC0 Offset: 0xE3BCC0 VA: 0x180E3CAC0
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.Antilog>.Where
	|-Enumerable.WhereArrayIterator<QRCodeGenerator.PolynomItem>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereListIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 14632
{
	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3CDD0 Offset: 0xE3BFD0 VA: 0x180E3CDD0
	|-Enumerable.WhereListIterator<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|
	|-RVA: 0xE3CC20 Offset: 0xE3BE20 VA: 0x180E3CC20
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereListIterator<Resolution>..ctor
	|-Enumerable.WhereListIterator<QRCodeGenerator.AlignmentPattern>..ctor
	|-Enumerable.WhereListIterator<QRCodeGenerator.VersionInfo>..ctor
	|
	|-RVA: 0xE3CC70 Offset: 0xE3BE70 VA: 0x180E3CC70
	|-Enumerable.WhereListIterator<Int32Enum>..ctor
	|-Enumerable.WhereListIterator<object>..ctor
	|-Enumerable.WhereListIterator<float>..ctor
	|-Enumerable.WhereListIterator<QRCodeGenerator.Antilog>..ctor
	|-Enumerable.WhereListIterator<QRCodeGenerator.PolynomItem>..ctor
	|
	|-RVA: 0xE3CD10 Offset: 0xE3BF10 VA: 0x180E3CD10
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xE3CCC0 Offset: 0xE3BEC0 VA: 0x180E3CCC0
	|-Enumerable.WhereListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3BCE0 Offset: 0xE3AEE0 VA: 0x180E3BCE0
	|-Enumerable.WhereListIterator<KeyValuePair<DiscardReasonWithCategory, int>>.Clone
	|
	|-RVA: 0xE3BB00 Offset: 0xE3AD00 VA: 0x180E3BB00
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereListIterator<Resolution>.Clone
	|-Enumerable.WhereListIterator<QRCodeGenerator.AlignmentPattern>.Clone
	|-Enumerable.WhereListIterator<QRCodeGenerator.VersionInfo>.Clone
	|
	|-RVA: 0xE3BC50 Offset: 0xE3AE50 VA: 0x180E3BC50
	|-Enumerable.WhereListIterator<Int32Enum>.Clone
	|-Enumerable.WhereListIterator<object>.Clone
	|-Enumerable.WhereListIterator<float>.Clone
	|-Enumerable.WhereListIterator<QRCodeGenerator.Antilog>.Clone
	|-Enumerable.WhereListIterator<QRCodeGenerator.PolynomItem>.Clone
	|
	|-RVA: 0xE3BB90 Offset: 0xE3AD90 VA: 0x180E3BB90
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.Clone
	|
	|-RVA: 0xE3BD70 Offset: 0xE3AF70 VA: 0x180E3BD70
	|-Enumerable.WhereListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE40100 Offset: 0xE3F300 VA: 0x180E40100
	|-Enumerable.WhereListIterator<KeyValuePair<DiscardReasonWithCategory, int>>.MoveNext
	|
	|-RVA: 0xE3F7B0 Offset: 0xE3E9B0 VA: 0x180E3F7B0
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereListIterator<Resolution>.MoveNext
	|-Enumerable.WhereListIterator<QRCodeGenerator.AlignmentPattern>.MoveNext
	|-Enumerable.WhereListIterator<QRCodeGenerator.VersionInfo>.MoveNext
	|
	|-RVA: 0xE3F9B0 Offset: 0xE3EBB0 VA: 0x180E3F9B0
	|-Enumerable.WhereListIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0xE40240 Offset: 0xE3F440 VA: 0x180E40240
	|-Enumerable.WhereListIterator<object>.MoveNext
	|
	|-RVA: 0xE40010 Offset: 0xE3F210 VA: 0x180E40010
	|-Enumerable.WhereListIterator<float>.MoveNext
	|
	|-RVA: 0xE3FC90 Offset: 0xE3EE90 VA: 0x180E3FC90
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0xE3FAA0 Offset: 0xE3ECA0 VA: 0x180E3FAA0
	|-Enumerable.WhereListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.MoveNext
	|
	|-RVA: 0xE3F8C0 Offset: 0xE3EAC0 VA: 0x180E3F8C0
	|-Enumerable.WhereListIterator<QRCodeGenerator.Antilog>.MoveNext
	|-Enumerable.WhereListIterator<QRCodeGenerator.PolynomItem>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F8300 Offset: 0x8F7500 VA: 0x1808F8300
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Select<KeyValuePair<object, object>>
	|
	|-RVA: 0x8F8260 Offset: 0x8F7460 VA: 0x1808F8260
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereListIterator<QRCodeGenerator.AlignmentPattern>.Select<object>
	|-Enumerable.WhereListIterator<QRCodeGenerator.VersionInfo>.Select<int>
	|-Enumerable.WhereListIterator<QRCodeGenerator.VersionInfo>.Select<object>
	|
	|-RVA: 0x8F81C0 Offset: 0x8F73C0 VA: 0x1808F81C0
	|-Enumerable.WhereListIterator<Int32Enum>.Select<Int32Enum>
	|-Enumerable.WhereListIterator<Int32Enum>.Select<object>
	|-Enumerable.WhereListIterator<object>.Select<int>
	|-Enumerable.WhereListIterator<object>.Select<Int32Enum>
	|-Enumerable.WhereListIterator<object>.Select<object>
	|-Enumerable.WhereListIterator<object>.Select<float>
	|-Enumerable.WhereListIterator<object>.Select<uint>
	|-Enumerable.WhereListIterator<QRCodeGenerator.Antilog>.Select<int>
	|-Enumerable.WhereListIterator<QRCodeGenerator.PolynomItem>.Select<object>
	|
	|-RVA: 0x8F80E0 Offset: 0x8F72E0 VA: 0x1808F80E0
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x8F83A0 Offset: 0x8F75A0 VA: 0x1808F83A0
	|-Enumerable.WhereListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE406A0 Offset: 0xE3F8A0 VA: 0x180E406A0
	|-Enumerable.WhereListIterator<KeyValuePair<DiscardReasonWithCategory, int>>.Where
	|
	|-RVA: 0xE403E0 Offset: 0xE3F5E0 VA: 0x180E403E0
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereListIterator<Resolution>.Where
	|-Enumerable.WhereListIterator<QRCodeGenerator.AlignmentPattern>.Where
	|-Enumerable.WhereListIterator<QRCodeGenerator.VersionInfo>.Where
	|
	|-RVA: 0xE40490 Offset: 0xE3F690 VA: 0x180E40490
	|-Enumerable.WhereListIterator<Int32Enum>.Where
	|
	|-RVA: 0xE40830 Offset: 0xE3FA30 VA: 0x180E40830
	|-Enumerable.WhereListIterator<object>.Where
	|
	|-RVA: 0xE40330 Offset: 0xE3F530 VA: 0x180E40330
	|-Enumerable.WhereListIterator<float>.Where
	|
	|-RVA: 0xE40750 Offset: 0xE3F950 VA: 0x180E40750
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.Where
	|
	|-RVA: 0xE405F0 Offset: 0xE3F7F0 VA: 0x180E405F0
	|-Enumerable.WhereListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Where
	|
	|-RVA: 0xE40540 Offset: 0xE3F740 VA: 0x180E40540
	|-Enumerable.WhereListIterator<QRCodeGenerator.Antilog>.Where
	|-Enumerable.WhereListIterator<QRCodeGenerator.PolynomItem>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 14633
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE42920 Offset: 0xE41B20 VA: 0x180E42920
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|
	|-RVA: 0xE42A70 Offset: 0xE41C70 VA: 0x180E42A70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0xE428C0 Offset: 0xE41AC0 VA: 0x180E428C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<bool, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<bool, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<bool, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<bool, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<bool, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<byte, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<byte, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<byte, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<byte, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<byte, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<int, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<int, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<int, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<int, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<int, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Vector4, Vector2>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, uint>..ctor
	|
	|-RVA: 0xE42980 Offset: 0xE41B80 VA: 0x180E42980
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE40990 Offset: 0xE3FB90 VA: 0x180E40990
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>.Clone
	|
	|-RVA: 0xE40A40 Offset: 0xE3FC40 VA: 0x180E40A40
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Clone
	|
	|-RVA: 0xE408E0 Offset: 0xE3FAE0 VA: 0x180E408E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<bool, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<bool, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<bool, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<bool, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<bool, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<byte, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<byte, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<byte, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<byte, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<byte, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<int, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<int, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<int, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Vector4, Vector2>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, uint>.Clone
	|
	|-RVA: 0xE40AF0 Offset: 0xE3FCF0 VA: 0x180E40AF0
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE42C90 Offset: 0xE41E90 VA: 0x180E42C90
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>.Dispose
	|
	|-RVA: 0xE43010 Offset: 0xE42210 VA: 0x180E43010
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0xE42DE0 Offset: 0xE41FE0 VA: 0x180E42DE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Dispose
	|
	|-RVA: 0xE43080 Offset: 0xE42280 VA: 0x180E43080
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Dispose
	|
	|-RVA: 0xE42F30 Offset: 0xE42130 VA: 0x180E42F30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0xE43160 Offset: 0xE42360 VA: 0x180E43160
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Dispose
	|
	|-RVA: 0xE43550 Offset: 0xE42750 VA: 0x180E43550
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, uint>.Dispose
	|
	|-RVA: 0xE435C0 Offset: 0xE427C0 VA: 0x180E435C0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, int>.Dispose
	|
	|-RVA: 0xE42BB0 Offset: 0xE41DB0 VA: 0x180E42BB0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, Int32Enum>.Dispose
	|
	|-RVA: 0xE42C20 Offset: 0xE41E20 VA: 0x180E42C20
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, object>.Dispose
	|
	|-RVA: 0xE438D0 Offset: 0xE42AD0 VA: 0x180E438D0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, float>.Dispose
	|
	|-RVA: 0xE43D30 Offset: 0xE42F30 VA: 0x180E43D30
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, uint>.Dispose
	|
	|-RVA: 0xE43E10 Offset: 0xE43010 VA: 0x180E43E10
	|-Enumerable.WhereSelectEnumerableIterator<bool, int>.Dispose
	|
	|-RVA: 0xE43940 Offset: 0xE42B40 VA: 0x180E43940
	|-Enumerable.WhereSelectEnumerableIterator<bool, Int32Enum>.Dispose
	|
	|-RVA: 0xE43710 Offset: 0xE42910 VA: 0x180E43710
	|-Enumerable.WhereSelectEnumerableIterator<bool, object>.Dispose
	|
	|-RVA: 0xE432B0 Offset: 0xE424B0 VA: 0x180E432B0
	|-Enumerable.WhereSelectEnumerableIterator<bool, float>.Dispose
	|
	|-RVA: 0xE43240 Offset: 0xE42440 VA: 0x180E43240
	|-Enumerable.WhereSelectEnumerableIterator<bool, uint>.Dispose
	|
	|-RVA: 0xE43390 Offset: 0xE42590 VA: 0x180E43390
	|-Enumerable.WhereSelectEnumerableIterator<byte, int>.Dispose
	|
	|-RVA: 0xE43470 Offset: 0xE42670 VA: 0x180E43470
	|-Enumerable.WhereSelectEnumerableIterator<byte, Int32Enum>.Dispose
	|
	|-RVA: 0xE43A90 Offset: 0xE42C90 VA: 0x180E43A90
	|-Enumerable.WhereSelectEnumerableIterator<byte, object>.Dispose
	|
	|-RVA: 0xE42EC0 Offset: 0xE420C0 VA: 0x180E42EC0
	|-Enumerable.WhereSelectEnumerableIterator<byte, float>.Dispose
	|
	|-RVA: 0xE437F0 Offset: 0xE429F0 VA: 0x180E437F0
	|-Enumerable.WhereSelectEnumerableIterator<byte, uint>.Dispose
	|
	|-RVA: 0xE436A0 Offset: 0xE428A0 VA: 0x180E436A0
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, Int32Enum>.Dispose
	|
	|-RVA: 0xE43630 Offset: 0xE42830 VA: 0x180E43630
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, object>.Dispose
	|
	|-RVA: 0xE43860 Offset: 0xE42A60 VA: 0x180E43860
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Dispose
	|
	|-RVA: 0xE434E0 Offset: 0xE426E0 VA: 0x180E434E0
	|-Enumerable.WhereSelectEnumerableIterator<int, Int32Enum>.Dispose
	|
	|-RVA: 0xE43320 Offset: 0xE42520 VA: 0x180E43320
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Dispose
	|
	|-RVA: 0xE439B0 Offset: 0xE42BB0 VA: 0x180E439B0
	|-Enumerable.WhereSelectEnumerableIterator<int, float>.Dispose
	|
	|-RVA: 0xE42FA0 Offset: 0xE421A0 VA: 0x180E42FA0
	|-Enumerable.WhereSelectEnumerableIterator<int, uint>.Dispose
	|
	|-RVA: 0xE42B40 Offset: 0xE41D40 VA: 0x180E42B40
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Dispose
	|
	|-RVA: 0xE43400 Offset: 0xE42600 VA: 0x180E43400
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0xE43BE0 Offset: 0xE42DE0 VA: 0x180E43BE0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Dispose
	|
	|-RVA: 0xE431D0 Offset: 0xE423D0 VA: 0x180E431D0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Dispose
	|
	|-RVA: 0xE42D00 Offset: 0xE41F00 VA: 0x180E42D00
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, uint>.Dispose
	|
	|-RVA: 0xE42E50 Offset: 0xE42050 VA: 0x180E42E50
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, int>.Dispose
	|
	|-RVA: 0xE43C50 Offset: 0xE42E50 VA: 0x180E43C50
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, Int32Enum>.Dispose
	|
	|-RVA: 0xE43780 Offset: 0xE42980 VA: 0x180E43780
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, object>.Dispose
	|
	|-RVA: 0xE43DA0 Offset: 0xE42FA0 VA: 0x180E43DA0
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, float>.Dispose
	|
	|-RVA: 0xE430F0 Offset: 0xE422F0 VA: 0x180E430F0
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, uint>.Dispose
	|
	|-RVA: 0xE43B70 Offset: 0xE42D70 VA: 0x180E43B70
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Dispose
	|
	|-RVA: 0xE42AD0 Offset: 0xE41CD0 VA: 0x180E42AD0
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Dispose
	|
	|-RVA: 0xE43CC0 Offset: 0xE42EC0 VA: 0x180E43CC0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Dispose
	|
	|-RVA: 0xE43B00 Offset: 0xE42D00 VA: 0x180E43B00
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Dispose
	|
	|-RVA: 0xE43A20 Offset: 0xE42C20 VA: 0x180E43A20
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Dispose
	|
	|-RVA: 0xE42D70 Offset: 0xE41F70 VA: 0x180E42D70
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, int>.Dispose
	|
	|-RVA: 0xE5CAF0 Offset: 0xE5BCF0 VA: 0x180E5CAF0
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, Int32Enum>.Dispose
	|
	|-RVA: 0xE5C210 Offset: 0xE5B410 VA: 0x180E5C210
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, object>.Dispose
	|
	|-RVA: 0xE5C460 Offset: 0xE5B660 VA: 0x180E5C460
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, float>.Dispose
	|
	|-RVA: 0xE5C620 Offset: 0xE5B820 VA: 0x180E5C620
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, uint>.Dispose
	|
	|-RVA: 0xE5CA10 Offset: 0xE5BC10 VA: 0x180E5CA10
	|-Enumerable.WhereSelectEnumerableIterator<Vector4, Vector2>.Dispose
	|
	|-RVA: 0xE5C360 Offset: 0xE5B560 VA: 0x180E5C360
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	|
	|-RVA: 0xE5C7E0 Offset: 0xE5B9E0 VA: 0x180E5C7E0
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>.Dispose
	|
	|-RVA: 0xE5C930 Offset: 0xE5BB30 VA: 0x180E5C930
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>.Dispose
	|
	|-RVA: 0xE5C2F0 Offset: 0xE5B4F0 VA: 0x180E5C2F0
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Dispose
	|
	|-RVA: 0xE5C850 Offset: 0xE5BA50 VA: 0x180E5C850
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>.Dispose
	|
	|-RVA: 0xE5CB60 Offset: 0xE5BD60 VA: 0x180E5CB60
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>.Dispose
	|
	|-RVA: 0xE5CBD0 Offset: 0xE5BDD0 VA: 0x180E5CBD0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, int>.Dispose
	|
	|-RVA: 0xE5C1A0 Offset: 0xE5B3A0 VA: 0x180E5C1A0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>.Dispose
	|
	|-RVA: 0xE5C770 Offset: 0xE5B970 VA: 0x180E5C770
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, object>.Dispose
	|
	|-RVA: 0xE5CA80 Offset: 0xE5BC80 VA: 0x180E5CA80
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, float>.Dispose
	|
	|-RVA: 0xE5C540 Offset: 0xE5B740 VA: 0x180E5C540
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, uint>.Dispose
	|
	|-RVA: 0xE5C690 Offset: 0xE5B890 VA: 0x180E5C690
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, int>.Dispose
	|
	|-RVA: 0xE5C8C0 Offset: 0xE5BAC0 VA: 0x180E5C8C0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, object>.Dispose
	|
	|-RVA: 0xE5C280 Offset: 0xE5B480 VA: 0x180E5C280
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, int>.Dispose
	|
	|-RVA: 0xE5C9A0 Offset: 0xE5BBA0 VA: 0x180E5C9A0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, Int32Enum>.Dispose
	|
	|-RVA: 0xE5C0C0 Offset: 0xE5B2C0 VA: 0x180E5C0C0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, object>.Dispose
	|
	|-RVA: 0xE5C4D0 Offset: 0xE5B6D0 VA: 0x180E5C4D0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, float>.Dispose
	|
	|-RVA: 0xE5C700 Offset: 0xE5B900 VA: 0x180E5C700
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, uint>.Dispose
	|
	|-RVA: 0xE5C050 Offset: 0xE5B250 VA: 0x180E5C050
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, int>.Dispose
	|
	|-RVA: 0xE5C5B0 Offset: 0xE5B7B0 VA: 0x180E5C5B0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, Int32Enum>.Dispose
	|
	|-RVA: 0xE5C130 Offset: 0xE5B330 VA: 0x180E5C130
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, object>.Dispose
	|
	|-RVA: 0xE5BF70 Offset: 0xE5B170 VA: 0x180E5BF70
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, float>.Dispose
	|
	|-RVA: 0xE5BFE0 Offset: 0xE5B1E0 VA: 0x180E5BFE0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, uint>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE44590 Offset: 0xE43790 VA: 0x180E44590
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>.MoveNext
	|
	|-RVA: 0xE479D0 Offset: 0xE46BD0 VA: 0x180E479D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0xE45110 Offset: 0xE44310 VA: 0x180E45110
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0xE48480 Offset: 0xE47680 VA: 0x180E48480
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0xE45670 Offset: 0xE44870 VA: 0x180E45670
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0xE48670 Offset: 0xE47870 VA: 0x180E48670
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0xE44F20 Offset: 0xE44120 VA: 0x180E44F20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, uint>.MoveNext
	|
	|-RVA: 0xE45A50 Offset: 0xE44C50 VA: 0x180E45A50
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, int>.MoveNext
	|
	|-RVA: 0xE45860 Offset: 0xE44A60 VA: 0x180E45860
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0xE45300 Offset: 0xE44500 VA: 0x180E45300
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, object>.MoveNext
	|
	|-RVA: 0xE47DC0 Offset: 0xE46FC0 VA: 0x180E47DC0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, float>.MoveNext
	|
	|-RVA: 0xE47BD0 Offset: 0xE46DD0 VA: 0x180E47BD0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, uint>.MoveNext
	|
	|-RVA: 0xE46800 Offset: 0xE45A00 VA: 0x180E46800
	|-Enumerable.WhereSelectEnumerableIterator<bool, int>.MoveNext
	|
	|-RVA: 0xE46980 Offset: 0xE45B80 VA: 0x180E46980
	|-Enumerable.WhereSelectEnumerableIterator<bool, Int32Enum>.MoveNext
	|
	|-RVA: 0xE44BB0 Offset: 0xE43DB0 VA: 0x180E44BB0
	|-Enumerable.WhereSelectEnumerableIterator<bool, object>.MoveNext
	|
	|-RVA: 0xE44410 Offset: 0xE43610 VA: 0x180E44410
	|-Enumerable.WhereSelectEnumerableIterator<bool, float>.MoveNext
	|
	|-RVA: 0xE46B00 Offset: 0xE45D00 VA: 0x180E46B00
	|-Enumerable.WhereSelectEnumerableIterator<bool, uint>.MoveNext
	|
	|-RVA: 0xE476D0 Offset: 0xE468D0 VA: 0x180E476D0
	|-Enumerable.WhereSelectEnumerableIterator<byte, int>.MoveNext
	|
	|-RVA: 0xE454F0 Offset: 0xE446F0 VA: 0x180E454F0
	|-Enumerable.WhereSelectEnumerableIterator<byte, Int32Enum>.MoveNext
	|
	|-RVA: 0xE45C40 Offset: 0xE44E40 VA: 0x180E45C40
	|-Enumerable.WhereSelectEnumerableIterator<byte, object>.MoveNext
	|
	|-RVA: 0xE46C80 Offset: 0xE45E80 VA: 0x180E46C80
	|-Enumerable.WhereSelectEnumerableIterator<byte, float>.MoveNext
	|
	|-RVA: 0xE47850 Offset: 0xE46A50 VA: 0x180E47850
	|-Enumerable.WhereSelectEnumerableIterator<byte, uint>.MoveNext
	|
	|-RVA: 0xE463A0 Offset: 0xE455A0 VA: 0x180E463A0
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, Int32Enum>.MoveNext
	|
	|-RVA: 0xE45F30 Offset: 0xE45130 VA: 0x180E45F30
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, object>.MoveNext
	|
	|-RVA: 0xE46F70 Offset: 0xE46170 VA: 0x180E46F70
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.MoveNext
	|
	|-RVA: 0xE46E00 Offset: 0xE46000 VA: 0x180E46E00
	|-Enumerable.WhereSelectEnumerableIterator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0xE47FB0 Offset: 0xE471B0 VA: 0x180E47FB0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.MoveNext
	|
	|-RVA: 0xE45DC0 Offset: 0xE44FC0 VA: 0x180E45DC0
	|-Enumerable.WhereSelectEnumerableIterator<int, float>.MoveNext
	|
	|-RVA: 0xE48120 Offset: 0xE47320 VA: 0x180E48120
	|-Enumerable.WhereSelectEnumerableIterator<int, uint>.MoveNext
	|
	|-RVA: 0xE46230 Offset: 0xE45430 VA: 0x180E46230
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0xE46690 Offset: 0xE45890 VA: 0x180E46690
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0xE43E80 Offset: 0xE43080 VA: 0x180E43E80
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0xE470E0 Offset: 0xE462E0 VA: 0x180E470E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0xE46520 Offset: 0xE45720 VA: 0x180E46520
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, uint>.MoveNext
	|
	|-RVA: 0xE44220 Offset: 0xE43420 VA: 0x180E44220
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, int>.MoveNext
	|
	|-RVA: 0xE447D0 Offset: 0xE439D0 VA: 0x180E447D0
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, Int32Enum>.MoveNext
	|
	|-RVA: 0xE449C0 Offset: 0xE43BC0 VA: 0x180E449C0
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, object>.MoveNext
	|
	|-RVA: 0xE48290 Offset: 0xE47490 VA: 0x180E48290
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, float>.MoveNext
	|
	|-RVA: 0xE44D30 Offset: 0xE43F30 VA: 0x180E44D30
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, uint>.MoveNext
	|
	|-RVA: 0xE473D0 Offset: 0xE465D0 VA: 0x180E473D0
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.MoveNext
	|
	|-RVA: 0xE48860 Offset: 0xE47A60 VA: 0x180E48860
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0xE47550 Offset: 0xE46750 VA: 0x180E47550
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.MoveNext
	|
	|-RVA: 0xE47250 Offset: 0xE46450 VA: 0x180E47250
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.MoveNext
	|
	|-RVA: 0xE460B0 Offset: 0xE452B0 VA: 0x180E460B0
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.MoveNext
	|
	|-RVA: 0xE43FF0 Offset: 0xE431F0 VA: 0x180E43FF0
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, int>.MoveNext
	|
	|-RVA: 0xE5D300 Offset: 0xE5C500 VA: 0x180E5D300
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, Int32Enum>.MoveNext
	|
	|-RVA: 0xE5FE10 Offset: 0xE5F010 VA: 0x180E5FE10
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, object>.MoveNext
	|
	|-RVA: 0xE5F580 Offset: 0xE5E780 VA: 0x180E5F580
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, float>.MoveNext
	|
	|-RVA: 0xE5F1E0 Offset: 0xE5E3E0 VA: 0x180E5F1E0
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, uint>.MoveNext
	|
	|-RVA: 0xE5D4B0 Offset: 0xE5C6B0 VA: 0x180E5D4B0
	|-Enumerable.WhereSelectEnumerableIterator<Vector4, Vector2>.MoveNext
	|
	|-RVA: 0xE5EB10 Offset: 0xE5DD10 VA: 0x180E5EB10
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0xE5EFD0 Offset: 0xE5E1D0 VA: 0x180E5EFD0
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>.MoveNext
	|
	|-RVA: 0xE5E900 Offset: 0xE5DB00 VA: 0x180E5E900
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>.MoveNext
	|
	|-RVA: 0xE5D830 Offset: 0xE5CA30 VA: 0x180E5D830
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.MoveNext
	|
	|-RVA: 0xE5DC30 Offset: 0xE5CE30 VA: 0x180E5DC30
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>.MoveNext
	|
	|-RVA: 0xE5FA90 Offset: 0xE5EC90 VA: 0x180E5FA90
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>.MoveNext
	|
	|-RVA: 0xE5DE60 Offset: 0xE5D060 VA: 0x180E5DE60
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, int>.MoveNext
	|
	|-RVA: 0xE5E3B0 Offset: 0xE5D5B0 VA: 0x180E5E3B0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>.MoveNext
	|
	|-RVA: 0xE5DA40 Offset: 0xE5CC40 VA: 0x180E5DA40
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, object>.MoveNext
	|
	|-RVA: 0xE5E710 Offset: 0xE5D910 VA: 0x180E5E710
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, float>.MoveNext
	|
	|-RVA: 0xE5FFC0 Offset: 0xE5F1C0 VA: 0x180E5FFC0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, uint>.MoveNext
	|
	|-RVA: 0xE5E5A0 Offset: 0xE5D7A0 VA: 0x180E5E5A0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, int>.MoveNext
	|
	|-RVA: 0xE5E240 Offset: 0xE5D440 VA: 0x180E5E240
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, object>.MoveNext
	|
	|-RVA: 0xE5FCA0 Offset: 0xE5EEA0 VA: 0x180E5FCA0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, int>.MoveNext
	|
	|-RVA: 0xE5D6C0 Offset: 0xE5C8C0 VA: 0x180E5D6C0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, Int32Enum>.MoveNext
	|
	|-RVA: 0xE5CDB0 Offset: 0xE5BFB0 VA: 0x180E5CDB0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, object>.MoveNext
	|
	|-RVA: 0xE5F730 Offset: 0xE5E930 VA: 0x180E5F730
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, float>.MoveNext
	|
	|-RVA: 0xE5CC40 Offset: 0xE5BE40 VA: 0x180E5CC40
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, uint>.MoveNext
	|
	|-RVA: 0xE5F8A0 Offset: 0xE5EAA0 VA: 0x180E5F8A0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, int>.MoveNext
	|
	|-RVA: 0xE5F390 Offset: 0xE5E590 VA: 0x180E5F390
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, Int32Enum>.MoveNext
	|
	|-RVA: 0xE5E050 Offset: 0xE5D250 VA: 0x180E5E050
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, object>.MoveNext
	|
	|-RVA: 0xE5D110 Offset: 0xE5C310 VA: 0x180E5D110
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, float>.MoveNext
	|
	|-RVA: 0xE5CF20 Offset: 0xE5C120 VA: 0x180E5CF20
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, uint>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F8AA0 Offset: 0x8F7CA0 VA: 0x1808F8AA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Select<KeyValuePair<object, object>>
	|
	|-RVA: 0x8F90A0 Offset: 0x8F82A0 VA: 0x1808F90A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Select<object>
	|
	|-RVA: 0x8F8560 Offset: 0x8F7760 VA: 0x1808F8560
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<uint>
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, object>.Select<uint>
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, object>.Select<uint>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, object>.Select<uint>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, object>.Select<uint>
	|
	|-RVA: 0x8F8B60 Offset: 0x8F7D60 VA: 0x1808F8B60
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, int>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, int>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, object>.Select<object>
	|
	|-RVA: 0x8F9220 Offset: 0x8F8420 VA: 0x1808F9220
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, object>.Select<float>
	|
	|-RVA: 0x8F8920 Offset: 0x8F7B20 VA: 0x1808F8920
	|-Enumerable.WhereSelectEnumerableIterator<bool, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<bool, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<bool, object>.Select<uint>
	|-Enumerable.WhereSelectEnumerableIterator<byte, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<byte, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<byte, object>.Select<uint>
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, Int32Enum>.Select<Int32Enum>
	|
	|-RVA: 0x8F8C20 Offset: 0x8F7E20 VA: 0x1808F8C20
	|-Enumerable.WhereSelectEnumerableIterator<bool, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<byte, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, Int32Enum>.Select<object>
	|
	|-RVA: 0x8F9160 Offset: 0x8F8360 VA: 0x1808F9160
	|-Enumerable.WhereSelectEnumerableIterator<bool, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<byte, object>.Select<float>
	|
	|-RVA: 0x8F87A0 Offset: 0x8F79A0 VA: 0x1808F87A0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<uint>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<uint>
	|
	|-RVA: 0x8F8CE0 Offset: 0x8F7EE0 VA: 0x1808F8CE0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<object>
	|
	|-RVA: 0x8F92E0 Offset: 0x8F84E0 VA: 0x1808F92E0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<float>
	|
	|-RVA: 0x8F8860 Offset: 0x8F7A60 VA: 0x1808F8860
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Int32Enum>
	|
	|-RVA: 0x8F8F20 Offset: 0x8F8120 VA: 0x1808F8F20
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<object>
	|
	|-RVA: 0x8F9460 Offset: 0x8F8660 VA: 0x1808F9460
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<float>
	|
	|-RVA: 0x8F96A0 Offset: 0x8F88A0 VA: 0x1808F96A0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<uint>
	|
	|-RVA: 0x8F86E0 Offset: 0x8F78E0 VA: 0x1808F86E0
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, object>.Select<uint>
	|
	|-RVA: 0x8F8DA0 Offset: 0x8F7FA0 VA: 0x1808F8DA0
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, object>.Select<object>
	|
	|-RVA: 0x8F9520 Offset: 0x8F8720 VA: 0x1808F9520
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, object>.Select<float>
	|
	|-RVA: 0x8F8440 Offset: 0x8F7640 VA: 0x1808F8440
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x8F89E0 Offset: 0x8F7BE0 VA: 0x1808F89E0
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<uint>
	|
	|-RVA: 0x8F8FE0 Offset: 0x8F81E0 VA: 0x1808F8FE0
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<object>
	|
	|-RVA: 0x8F93A0 Offset: 0x8F85A0 VA: 0x1808F93A0
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<float>
	|
	|-RVA: 0x8F8620 Offset: 0x8F7820 VA: 0x1808F8620
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, object>.Select<uint>
	|
	|-RVA: 0x8F8E60 Offset: 0x8F8060 VA: 0x1808F8E60
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, int>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, object>.Select<object>
	|
	|-RVA: 0x8F95E0 Offset: 0x8F87E0 VA: 0x1808F95E0
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, object>.Select<float>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE48B10 Offset: 0xE47D10 VA: 0x180E48B10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>.Where
	|
	|-RVA: 0xE48BA0 Offset: 0xE47DA0 VA: 0x180E48BA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Where
	|
	|-RVA: 0xE48A80 Offset: 0xE47C80 VA: 0x180E48A80
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<bool, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<byte, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<StyleSelectorPart, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Vector4, Vector2>.Where
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.AlignmentPattern, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.Antilog, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.PolynomItem, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<QRCodeGenerator.VersionInfo, uint>.Where
	|
	|-RVA: 0xE489E0 Offset: 0xE47BE0 VA: 0x180E489E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, object>, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<bool, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<bool, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<bool, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<bool, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<byte, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<byte, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<byte, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<byte, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ByteEnum, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<int, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<int, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<int, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<JsonElement, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Where
	|
	|-RVA: 0xE601B0 Offset: 0xE5F3B0 VA: 0x180E601B0
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 14634
{
	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE42920 Offset: 0xE41B20 VA: 0x180E42920
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|
	|-RVA: 0xE42A70 Offset: 0xE41C70 VA: 0x180E42A70
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0xE428C0 Offset: 0xE41AC0 VA: 0x180E428C0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<bool, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<bool, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<bool, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<bool, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<bool, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<byte, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<byte, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<byte, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<byte, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<byte, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<ByteEnum, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<ByteEnum, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<int, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<int, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<int, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<int, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<int, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<JsonElement, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<JsonElement, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<JsonElement, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<JsonElement, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<JsonElement, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<Vector4, Vector2>..ctor
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.Antilog, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.Antilog, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, uint>..ctor
	|
	|-RVA: 0xE42980 Offset: 0xE41B80 VA: 0x180E42980
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE40990 Offset: 0xE3FB90 VA: 0x180E40990
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>.Clone
	|
	|-RVA: 0xE40A40 Offset: 0xE3FC40 VA: 0x180E40A40
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Clone
	|
	|-RVA: 0xE408E0 Offset: 0xE3FAE0 VA: 0x180E408E0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<bool, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<bool, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<bool, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<bool, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<bool, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<byte, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<byte, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<byte, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<byte, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<byte, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<ByteEnum, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<ByteEnum, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<int, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<int, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<int, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<int, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<int, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<JsonElement, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<JsonElement, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<JsonElement, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<JsonElement, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<JsonElement, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<Vector4, Vector2>.Clone
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.Antilog, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.Antilog, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, uint>.Clone
	|
	|-RVA: 0xE40AF0 Offset: 0xE3FCF0 VA: 0x180E40AF0
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE41DD0 Offset: 0xE40FD0 VA: 0x180E41DD0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>.MoveNext
	|
	|-RVA: 0xE41670 Offset: 0xE40870 VA: 0x180E41670
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0xE40D60 Offset: 0xE3FF60 VA: 0x180E40D60
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, uint>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, uint>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<JsonElement, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<JsonElement, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<JsonElement, uint>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, uint>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, uint>.MoveNext
	|
	|-RVA: 0xE41320 Offset: 0xE40520 VA: 0x180E41320
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<JsonElement, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, object>.MoveNext
	|
	|-RVA: 0xE41590 Offset: 0xE40790 VA: 0x180E41590
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<JsonElement, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, float>.MoveNext
	|
	|-RVA: 0xE41C10 Offset: 0xE40E10 VA: 0x180E41C10
	|-Enumerable.WhereSelectArrayIterator<bool, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<bool, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<bool, uint>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<byte, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<byte, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<byte, uint>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ByteEnum, Int32Enum>.MoveNext
	|
	|-RVA: 0xE41030 Offset: 0xE40230 VA: 0x180E41030
	|-Enumerable.WhereSelectArrayIterator<bool, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<byte, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ByteEnum, object>.MoveNext
	|
	|-RVA: 0xE41B40 Offset: 0xE40D40 VA: 0x180E41B40
	|-Enumerable.WhereSelectArrayIterator<bool, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<byte, float>.MoveNext
	|
	|-RVA: 0xE414D0 Offset: 0xE406D0 VA: 0x180E414D0
	|-Enumerable.WhereSelectArrayIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<int, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<int, uint>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, uint>.MoveNext
	|
	|-RVA: 0xE419A0 Offset: 0xE40BA0 VA: 0x180E419A0
	|-Enumerable.WhereSelectArrayIterator<int, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0xE42080 Offset: 0xE41280 VA: 0x180E42080
	|-Enumerable.WhereSelectArrayIterator<int, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0xE41A70 Offset: 0xE40C70 VA: 0x180E41A70
	|-Enumerable.WhereSelectArrayIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, uint>.MoveNext
	|
	|-RVA: 0xE41760 Offset: 0xE40960 VA: 0x180E41760
	|-Enumerable.WhereSelectArrayIterator<object, object>.MoveNext
	|
	|-RVA: 0xE41100 Offset: 0xE40300 VA: 0x180E41100
	|-Enumerable.WhereSelectArrayIterator<object, float>.MoveNext
	|
	|-RVA: 0xE40F40 Offset: 0xE40140 VA: 0x180E40F40
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, uint>.MoveNext
	|
	|-RVA: 0xE41CE0 Offset: 0xE40EE0 VA: 0x180E41CE0
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, object>.MoveNext
	|
	|-RVA: 0xE40E40 Offset: 0xE40040 VA: 0x180E40E40
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, float>.MoveNext
	|
	|-RVA: 0xE42150 Offset: 0xE41350 VA: 0x180E42150
	|-Enumerable.WhereSelectArrayIterator<Vector4, Vector2>.MoveNext
	|
	|-RVA: 0xE42250 Offset: 0xE41450 VA: 0x180E42250
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0xE41830 Offset: 0xE40A30 VA: 0x180E41830
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>.MoveNext
	|
	|-RVA: 0xE40BF0 Offset: 0xE3FDF0 VA: 0x180E40BF0
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.MoveNext
	|
	|-RVA: 0xE411D0 Offset: 0xE403D0 VA: 0x180E411D0
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>.MoveNext
	|
	|-RVA: 0xE41400 Offset: 0xE40600 VA: 0x180E41400
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.Antilog, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, uint>.MoveNext
	|
	|-RVA: 0xE41EE0 Offset: 0xE410E0 VA: 0x180E41EE0
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.Antilog, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, object>.MoveNext
	|
	|-RVA: 0xE41FB0 Offset: 0xE411B0 VA: 0x180E41FB0
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, float>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F8AA0 Offset: 0x8F7CA0 VA: 0x1808F8AA0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Select<KeyValuePair<object, object>>
	|
	|-RVA: 0x8F90A0 Offset: 0x8F82A0 VA: 0x1808F90A0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Select<object>
	|
	|-RVA: 0x8F8560 Offset: 0x8F7760 VA: 0x1808F8560
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<uint>
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, object>.Select<uint>
	|-Enumerable.WhereSelectArrayIterator<JsonElement, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<JsonElement, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<JsonElement, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<JsonElement, object>.Select<uint>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, object>.Select<uint>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, object>.Select<uint>
	|
	|-RVA: 0x8F8B60 Offset: 0x8F7D60 VA: 0x1808F8B60
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<JsonElement, int>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<JsonElement, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, int>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, object>.Select<object>
	|
	|-RVA: 0x8F9220 Offset: 0x8F8420 VA: 0x1808F9220
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<JsonElement, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, object>.Select<float>
	|
	|-RVA: 0x8F8920 Offset: 0x8F7B20 VA: 0x1808F8920
	|-Enumerable.WhereSelectArrayIterator<bool, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<bool, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<bool, object>.Select<uint>
	|-Enumerable.WhereSelectArrayIterator<byte, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<byte, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<byte, object>.Select<uint>
	|-Enumerable.WhereSelectArrayIterator<ByteEnum, Int32Enum>.Select<Int32Enum>
	|
	|-RVA: 0x8F8C20 Offset: 0x8F7E20 VA: 0x1808F8C20
	|-Enumerable.WhereSelectArrayIterator<bool, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<byte, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<ByteEnum, Int32Enum>.Select<object>
	|
	|-RVA: 0x8F9160 Offset: 0x8F8360 VA: 0x1808F9160
	|-Enumerable.WhereSelectArrayIterator<bool, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<byte, object>.Select<float>
	|
	|-RVA: 0x8F87A0 Offset: 0x8F79A0 VA: 0x1808F87A0
	|-Enumerable.WhereSelectArrayIterator<int, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<uint>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<uint>
	|
	|-RVA: 0x8F8CE0 Offset: 0x8F7EE0 VA: 0x1808F8CE0
	|-Enumerable.WhereSelectArrayIterator<int, int>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<object>
	|
	|-RVA: 0x8F92E0 Offset: 0x8F84E0 VA: 0x1808F92E0
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<float>
	|
	|-RVA: 0x8F8860 Offset: 0x8F7A60 VA: 0x1808F8860
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Int32Enum>
	|
	|-RVA: 0x8F8F20 Offset: 0x8F8120 VA: 0x1808F8F20
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<object>
	|
	|-RVA: 0x8F9460 Offset: 0x8F8660 VA: 0x1808F9460
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<float>
	|
	|-RVA: 0x8F96A0 Offset: 0x8F88A0 VA: 0x1808F96A0
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<uint>
	|
	|-RVA: 0x8F86E0 Offset: 0x8F78E0 VA: 0x1808F86E0
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, object>.Select<uint>
	|
	|-RVA: 0x8F8DA0 Offset: 0x8F7FA0 VA: 0x1808F8DA0
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, object>.Select<object>
	|
	|-RVA: 0x8F9520 Offset: 0x8F8720 VA: 0x1808F9520
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, object>.Select<float>
	|
	|-RVA: 0x8F8440 Offset: 0x8F7640 VA: 0x1808F8440
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x8F89E0 Offset: 0x8F7BE0 VA: 0x1808F89E0
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<uint>
	|
	|-RVA: 0x8F8FE0 Offset: 0x8F81E0 VA: 0x1808F8FE0
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<object>
	|
	|-RVA: 0x8F93A0 Offset: 0x8F85A0 VA: 0x1808F93A0
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<float>
	|
	|-RVA: 0x8F8620 Offset: 0x8F7820 VA: 0x1808F8620
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.Antilog, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, object>.Select<uint>
	|
	|-RVA: 0x8F8E60 Offset: 0x8F8060 VA: 0x1808F8E60
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.Antilog, int>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, object>.Select<object>
	|
	|-RVA: 0x8F95E0 Offset: 0x8F87E0 VA: 0x1808F95E0
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, object>.Select<float>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE42740 Offset: 0xE41940 VA: 0x180E42740
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>.Where
	|
	|-RVA: 0xE427C0 Offset: 0xE419C0 VA: 0x180E427C0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Where
	|
	|-RVA: 0xE42630 Offset: 0xE41830 VA: 0x180E42630
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.Where
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, int>.Where
	|-Enumerable.WhereSelectArrayIterator<bool, int>.Where
	|-Enumerable.WhereSelectArrayIterator<byte, int>.Where
	|-Enumerable.WhereSelectArrayIterator<int, int>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.Where
	|-Enumerable.WhereSelectArrayIterator<JsonElement, int>.Where
	|-Enumerable.WhereSelectArrayIterator<object, int>.Where
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, int>.Where
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, int>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.Antilog, int>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, int>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, int>.Where
	|
	|-RVA: 0xE426B0 Offset: 0xE418B0 VA: 0x180E426B0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, object>.Where
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, float>.Where
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, object>, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<bool, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<bool, object>.Where
	|-Enumerable.WhereSelectArrayIterator<bool, float>.Where
	|-Enumerable.WhereSelectArrayIterator<bool, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<byte, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<byte, object>.Where
	|-Enumerable.WhereSelectArrayIterator<byte, float>.Where
	|-Enumerable.WhereSelectArrayIterator<byte, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<ByteEnum, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<ByteEnum, object>.Where
	|-Enumerable.WhereSelectArrayIterator<int, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<int, object>.Where
	|-Enumerable.WhereSelectArrayIterator<int, float>.Where
	|-Enumerable.WhereSelectArrayIterator<int, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<JsonElement, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<JsonElement, object>.Where
	|-Enumerable.WhereSelectArrayIterator<JsonElement, float>.Where
	|-Enumerable.WhereSelectArrayIterator<JsonElement, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<object, object>.Where
	|-Enumerable.WhereSelectArrayIterator<object, float>.Where
	|-Enumerable.WhereSelectArrayIterator<object, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, object>.Where
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, float>.Where
	|-Enumerable.WhereSelectArrayIterator<StyleSelectorPart, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<Vector4, Vector2>.Where
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Where
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>.Where
	|-Enumerable.WhereSelectArrayIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, object>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, float>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.AlignmentPattern, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.Antilog, object>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, object>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, float>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.PolynomItem, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, object>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, float>.Where
	|-Enumerable.WhereSelectArrayIterator<QRCodeGenerator.VersionInfo, uint>.Where
	|
	|-RVA: 0xE42840 Offset: 0xE41A40 VA: 0x180E42840
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 14635
{
	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE42920 Offset: 0xE41B20 VA: 0x180E42920
	|-Enumerable.WhereSelectListIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|
	|-RVA: 0xE42A70 Offset: 0xE41C70 VA: 0x180E42A70
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0xE428C0 Offset: 0xE41AC0 VA: 0x180E428C0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, uint>..ctor
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, int>..ctor
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, object>..ctor
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, float>..ctor
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, uint>..ctor
	|-Enumerable.WhereSelectListIterator<bool, int>..ctor
	|-Enumerable.WhereSelectListIterator<bool, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<bool, object>..ctor
	|-Enumerable.WhereSelectListIterator<bool, float>..ctor
	|-Enumerable.WhereSelectListIterator<bool, uint>..ctor
	|-Enumerable.WhereSelectListIterator<byte, int>..ctor
	|-Enumerable.WhereSelectListIterator<byte, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<byte, object>..ctor
	|-Enumerable.WhereSelectListIterator<byte, float>..ctor
	|-Enumerable.WhereSelectListIterator<byte, uint>..ctor
	|-Enumerable.WhereSelectListIterator<ByteEnum, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<ByteEnum, object>..ctor
	|-Enumerable.WhereSelectListIterator<int, int>..ctor
	|-Enumerable.WhereSelectListIterator<int, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<int, object>..ctor
	|-Enumerable.WhereSelectListIterator<int, float>..ctor
	|-Enumerable.WhereSelectListIterator<int, uint>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, uint>..ctor
	|-Enumerable.WhereSelectListIterator<JsonElement, int>..ctor
	|-Enumerable.WhereSelectListIterator<JsonElement, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<JsonElement, object>..ctor
	|-Enumerable.WhereSelectListIterator<JsonElement, float>..ctor
	|-Enumerable.WhereSelectListIterator<JsonElement, uint>..ctor
	|-Enumerable.WhereSelectListIterator<object, int>..ctor
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<object, object>..ctor
	|-Enumerable.WhereSelectListIterator<object, float>..ctor
	|-Enumerable.WhereSelectListIterator<object, uint>..ctor
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, int>..ctor
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, object>..ctor
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, float>..ctor
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, uint>..ctor
	|-Enumerable.WhereSelectListIterator<Vector4, Vector2>..ctor
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>..ctor
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>..ctor
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>..ctor
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, int>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, object>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, float>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, uint>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.Antilog, int>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.Antilog, object>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, int>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, object>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, float>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, uint>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, int>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, object>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, float>..ctor
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, uint>..ctor
	|
	|-RVA: 0xE42980 Offset: 0xE41B80 VA: 0x180E42980
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE40990 Offset: 0xE3FB90 VA: 0x180E40990
	|-Enumerable.WhereSelectListIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>.Clone
	|
	|-RVA: 0xE40A40 Offset: 0xE3FC40 VA: 0x180E40A40
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Clone
	|
	|-RVA: 0xE408E0 Offset: 0xE3FAE0 VA: 0x180E408E0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, uint>.Clone
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, int>.Clone
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, object>.Clone
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, float>.Clone
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, uint>.Clone
	|-Enumerable.WhereSelectListIterator<bool, int>.Clone
	|-Enumerable.WhereSelectListIterator<bool, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<bool, object>.Clone
	|-Enumerable.WhereSelectListIterator<bool, float>.Clone
	|-Enumerable.WhereSelectListIterator<bool, uint>.Clone
	|-Enumerable.WhereSelectListIterator<byte, int>.Clone
	|-Enumerable.WhereSelectListIterator<byte, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<byte, object>.Clone
	|-Enumerable.WhereSelectListIterator<byte, float>.Clone
	|-Enumerable.WhereSelectListIterator<byte, uint>.Clone
	|-Enumerable.WhereSelectListIterator<ByteEnum, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<ByteEnum, object>.Clone
	|-Enumerable.WhereSelectListIterator<int, int>.Clone
	|-Enumerable.WhereSelectListIterator<int, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<int, object>.Clone
	|-Enumerable.WhereSelectListIterator<int, float>.Clone
	|-Enumerable.WhereSelectListIterator<int, uint>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, uint>.Clone
	|-Enumerable.WhereSelectListIterator<JsonElement, int>.Clone
	|-Enumerable.WhereSelectListIterator<JsonElement, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<JsonElement, object>.Clone
	|-Enumerable.WhereSelectListIterator<JsonElement, float>.Clone
	|-Enumerable.WhereSelectListIterator<JsonElement, uint>.Clone
	|-Enumerable.WhereSelectListIterator<object, int>.Clone
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<object, object>.Clone
	|-Enumerable.WhereSelectListIterator<object, float>.Clone
	|-Enumerable.WhereSelectListIterator<object, uint>.Clone
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, int>.Clone
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, object>.Clone
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, float>.Clone
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, uint>.Clone
	|-Enumerable.WhereSelectListIterator<Vector4, Vector2>.Clone
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>.Clone
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Clone
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>.Clone
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, int>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, object>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, float>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, uint>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.Antilog, int>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.Antilog, object>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, int>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, object>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, float>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, uint>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, int>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, object>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, float>.Clone
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, uint>.Clone
	|
	|-RVA: 0xE40AF0 Offset: 0xE3FCF0 VA: 0x180E40AF0
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE60B30 Offset: 0xE5FD30 VA: 0x180E60B30
	|-Enumerable.WhereSelectListIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>.MoveNext
	|
	|-RVA: 0xE60FE0 Offset: 0xE601E0 VA: 0x180E60FE0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0xE60240 Offset: 0xE5F440 VA: 0x180E60240
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, uint>.MoveNext
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, uint>.MoveNext
	|-Enumerable.WhereSelectListIterator<JsonElement, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<JsonElement, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<JsonElement, uint>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, uint>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, uint>.MoveNext
	|
	|-RVA: 0xE60360 Offset: 0xE5F560 VA: 0x180E60360
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<JsonElement, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, object>.MoveNext
	|
	|-RVA: 0xE613F0 Offset: 0xE605F0 VA: 0x180E613F0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<JsonElement, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, float>.MoveNext
	|
	|-RVA: 0xE606F0 Offset: 0xE5F8F0 VA: 0x180E606F0
	|-Enumerable.WhereSelectListIterator<bool, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<bool, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<bool, uint>.MoveNext
	|-Enumerable.WhereSelectListIterator<byte, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<byte, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<byte, uint>.MoveNext
	|-Enumerable.WhereSelectListIterator<ByteEnum, Int32Enum>.MoveNext
	|
	|-RVA: 0xE60910 Offset: 0xE5FB10 VA: 0x180E60910
	|-Enumerable.WhereSelectListIterator<bool, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<byte, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<ByteEnum, object>.MoveNext
	|
	|-RVA: 0xE60480 Offset: 0xE5F680 VA: 0x180E60480
	|-Enumerable.WhereSelectListIterator<bool, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<byte, float>.MoveNext
	|
	|-RVA: 0xE60ED0 Offset: 0xE600D0 VA: 0x180E60ED0
	|-Enumerable.WhereSelectListIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<int, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<int, uint>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, uint>.MoveNext
	|
	|-RVA: 0xE61E30 Offset: 0xE61030 VA: 0x180E61E30
	|-Enumerable.WhereSelectListIterator<int, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0xE612E0 Offset: 0xE604E0 VA: 0x180E612E0
	|-Enumerable.WhereSelectListIterator<int, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0xE61780 Offset: 0xE60980 VA: 0x180E61780
	|-Enumerable.WhereSelectListIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, uint>.MoveNext
	|
	|-RVA: 0xE60DC0 Offset: 0xE5FFC0 VA: 0x180E60DC0
	|-Enumerable.WhereSelectListIterator<object, object>.MoveNext
	|
	|-RVA: 0xE60800 Offset: 0xE5FA00 VA: 0x180E60800
	|-Enumerable.WhereSelectListIterator<object, float>.MoveNext
	|
	|-RVA: 0xE60590 Offset: 0xE5F790 VA: 0x180E60590
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, uint>.MoveNext
	|
	|-RVA: 0xE61890 Offset: 0xE60A90 VA: 0x180E61890
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, object>.MoveNext
	|
	|-RVA: 0xE61510 Offset: 0xE60710 VA: 0x180E61510
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, float>.MoveNext
	|
	|-RVA: 0xE61650 Offset: 0xE60850 VA: 0x180E61650
	|-Enumerable.WhereSelectListIterator<Vector4, Vector2>.MoveNext
	|
	|-RVA: 0xE619F0 Offset: 0xE60BF0 VA: 0x180E619F0
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0xE61100 Offset: 0xE60300 VA: 0x180E61100
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>.MoveNext
	|
	|-RVA: 0xE62210 Offset: 0xE61410 VA: 0x180E62210
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.MoveNext
	|
	|-RVA: 0xE61F40 Offset: 0xE61140 VA: 0x180E61F40
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>.MoveNext
	|
	|-RVA: 0xE60CB0 Offset: 0xE5FEB0 VA: 0x180E60CB0
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.Antilog, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, uint>.MoveNext
	|
	|-RVA: 0xE60A20 Offset: 0xE5FC20 VA: 0x180E60A20
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.Antilog, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, object>.MoveNext
	|
	|-RVA: 0xE62100 Offset: 0xE61300 VA: 0x180E62100
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, float>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F8AA0 Offset: 0x8F7CA0 VA: 0x1808F8AA0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Select<KeyValuePair<object, object>>
	|
	|-RVA: 0x8F90A0 Offset: 0x8F82A0 VA: 0x1808F90A0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Select<object>
	|
	|-RVA: 0x8F8560 Offset: 0x8F7760 VA: 0x1808F8560
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<uint>
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, object>.Select<uint>
	|-Enumerable.WhereSelectListIterator<JsonElement, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<JsonElement, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<JsonElement, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<JsonElement, object>.Select<uint>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, object>.Select<uint>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, object>.Select<uint>
	|
	|-RVA: 0x8F8B60 Offset: 0x8F7D60 VA: 0x1808F8B60
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<JsonElement, int>.Select<object>
	|-Enumerable.WhereSelectListIterator<JsonElement, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, int>.Select<object>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, object>.Select<object>
	|
	|-RVA: 0x8F9220 Offset: 0x8F8420 VA: 0x1808F9220
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<JsonElement, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, object>.Select<float>
	|
	|-RVA: 0x8F8920 Offset: 0x8F7B20 VA: 0x1808F8920
	|-Enumerable.WhereSelectListIterator<bool, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<bool, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<bool, object>.Select<uint>
	|-Enumerable.WhereSelectListIterator<byte, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<byte, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<byte, object>.Select<uint>
	|-Enumerable.WhereSelectListIterator<ByteEnum, Int32Enum>.Select<Int32Enum>
	|
	|-RVA: 0x8F8C20 Offset: 0x8F7E20 VA: 0x1808F8C20
	|-Enumerable.WhereSelectListIterator<bool, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<byte, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<ByteEnum, Int32Enum>.Select<object>
	|
	|-RVA: 0x8F9160 Offset: 0x8F8360 VA: 0x1808F9160
	|-Enumerable.WhereSelectListIterator<bool, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<byte, object>.Select<float>
	|
	|-RVA: 0x8F87A0 Offset: 0x8F79A0 VA: 0x1808F87A0
	|-Enumerable.WhereSelectListIterator<int, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<int, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<int, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<int, object>.Select<uint>
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<uint>
	|
	|-RVA: 0x8F8CE0 Offset: 0x8F7EE0 VA: 0x1808F8CE0
	|-Enumerable.WhereSelectListIterator<int, int>.Select<object>
	|-Enumerable.WhereSelectListIterator<int, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<object>
	|
	|-RVA: 0x8F92E0 Offset: 0x8F84E0 VA: 0x1808F92E0
	|-Enumerable.WhereSelectListIterator<int, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<float>
	|
	|-RVA: 0x8F8860 Offset: 0x8F7A60 VA: 0x1808F8860
	|-Enumerable.WhereSelectListIterator<object, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Int32Enum>
	|
	|-RVA: 0x8F8F20 Offset: 0x8F8120 VA: 0x1808F8F20
	|-Enumerable.WhereSelectListIterator<object, int>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<object>
	|
	|-RVA: 0x8F9460 Offset: 0x8F8660 VA: 0x1808F9460
	|-Enumerable.WhereSelectListIterator<object, object>.Select<float>
	|
	|-RVA: 0x8F96A0 Offset: 0x8F88A0 VA: 0x1808F96A0
	|-Enumerable.WhereSelectListIterator<object, object>.Select<uint>
	|
	|-RVA: 0x8F86E0 Offset: 0x8F78E0 VA: 0x1808F86E0
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, object>.Select<uint>
	|
	|-RVA: 0x8F8DA0 Offset: 0x8F7FA0 VA: 0x1808F8DA0
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, object>.Select<object>
	|
	|-RVA: 0x8F9520 Offset: 0x8F8720 VA: 0x1808F9520
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, object>.Select<float>
	|
	|-RVA: 0x8F8440 Offset: 0x8F7640 VA: 0x1808F8440
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x8F89E0 Offset: 0x8F7BE0 VA: 0x1808F89E0
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<uint>
	|
	|-RVA: 0x8F8FE0 Offset: 0x8F81E0 VA: 0x1808F8FE0
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<object>
	|
	|-RVA: 0x8F93A0 Offset: 0x8F85A0 VA: 0x1808F93A0
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Select<float>
	|
	|-RVA: 0x8F8620 Offset: 0x8F7820 VA: 0x1808F8620
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.Antilog, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, object>.Select<uint>
	|
	|-RVA: 0x8F8E60 Offset: 0x8F8060 VA: 0x1808F8E60
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.Antilog, int>.Select<object>
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, object>.Select<object>
	|
	|-RVA: 0x8F95E0 Offset: 0x8F87E0 VA: 0x1808F95E0
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, object>.Select<float>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE625A0 Offset: 0xE617A0 VA: 0x180E625A0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>.Where
	|
	|-RVA: 0xE62480 Offset: 0xE61680 VA: 0x180E62480
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, object>>.Where
	|
	|-RVA: 0xE623F0 Offset: 0xE615F0 VA: 0x180E623F0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, uint>.Where
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, int>.Where
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, object>.Where
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, float>.Where
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, object>, uint>.Where
	|-Enumerable.WhereSelectListIterator<bool, int>.Where
	|-Enumerable.WhereSelectListIterator<bool, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<bool, object>.Where
	|-Enumerable.WhereSelectListIterator<bool, float>.Where
	|-Enumerable.WhereSelectListIterator<bool, uint>.Where
	|-Enumerable.WhereSelectListIterator<byte, int>.Where
	|-Enumerable.WhereSelectListIterator<byte, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<byte, object>.Where
	|-Enumerable.WhereSelectListIterator<byte, float>.Where
	|-Enumerable.WhereSelectListIterator<byte, uint>.Where
	|-Enumerable.WhereSelectListIterator<ByteEnum, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<ByteEnum, object>.Where
	|-Enumerable.WhereSelectListIterator<int, int>.Where
	|-Enumerable.WhereSelectListIterator<int, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<int, object>.Where
	|-Enumerable.WhereSelectListIterator<int, float>.Where
	|-Enumerable.WhereSelectListIterator<int, uint>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, uint>.Where
	|-Enumerable.WhereSelectListIterator<JsonElement, int>.Where
	|-Enumerable.WhereSelectListIterator<JsonElement, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<JsonElement, object>.Where
	|-Enumerable.WhereSelectListIterator<JsonElement, float>.Where
	|-Enumerable.WhereSelectListIterator<JsonElement, uint>.Where
	|-Enumerable.WhereSelectListIterator<object, int>.Where
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<object, object>.Where
	|-Enumerable.WhereSelectListIterator<object, float>.Where
	|-Enumerable.WhereSelectListIterator<object, uint>.Where
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, int>.Where
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, object>.Where
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, float>.Where
	|-Enumerable.WhereSelectListIterator<StyleSelectorPart, uint>.Where
	|-Enumerable.WhereSelectListIterator<Vector4, Vector2>.Where
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>.Where
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Where
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>.Where
	|-Enumerable.WhereSelectListIterator<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, int>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, object>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, float>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.AlignmentPattern, uint>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.Antilog, int>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.Antilog, object>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, int>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, object>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, float>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.PolynomItem, uint>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, int>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, object>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, float>.Where
	|-Enumerable.WhereSelectListIterator<QRCodeGenerator.VersionInfo, uint>.Where
	|
	|-RVA: 0xE62510 Offset: 0xE61710 VA: 0x180E62510
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Where
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<WhereIterator>d__2<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 14636
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, int, bool> predicate; // 0x0
	public Func<TSource, int, bool> <>3__predicate; // 0x0
	private int <index>5__2; // 0x0
	private IEnumerator<TSource> <>7__wrap2; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<WhereIterator>d__2<object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<WhereIterator>d__2<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF55250 Offset: 0xF54450 VA: 0x180F55250
	|-Enumerable.<WhereIterator>d__2<object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB02530 Offset: 0xB01730 VA: 0x180B02530
	|-Enumerable.<WhereIterator>d__2<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF54D60 Offset: 0xF53F60 VA: 0x180F54D60
	|-Enumerable.<WhereIterator>d__2<object>.MoveNext
	|
	|-RVA: 0xF546D0 Offset: 0xF538D0 VA: 0x180F546D0
	|-Enumerable.<WhereIterator>d__2<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF553D0 Offset: 0xF545D0 VA: 0x180F553D0
	|-Enumerable.<WhereIterator>d__2<object>.<>m__Finally1
	|
	|-RVA: 0xF552F0 Offset: 0xF544F0 VA: 0x180F552F0
	|-Enumerable.<WhereIterator>d__2<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<WhereIterator>d__2<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB02120 Offset: 0xB01320 VA: 0x180B02120
	|-Enumerable.<WhereIterator>d__2<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<WhereIterator>d__2<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<WhereIterator>d__2<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<WhereIterator>d__2<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB023B0 Offset: 0xB015B0 VA: 0x180B023B0
	|-Enumerable.<WhereIterator>d__2<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02070 Offset: 0xB01270 VA: 0x180B02070
	|-Enumerable.<WhereIterator>d__2<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xF54FC0 Offset: 0xF541C0 VA: 0x180F54FC0
	|-Enumerable.<WhereIterator>d__2<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF55190 Offset: 0xF54390 VA: 0x180F55190
	|-Enumerable.<WhereIterator>d__2<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB25440 Offset: 0xB24640 VA: 0x180B25440
	|-Enumerable.<WhereIterator>d__2<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<SelectIterator>d__5<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 14637
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, int, TResult> selector; // 0x0
	public Func<TSource, int, TResult> <>3__selector; // 0x0
	private int <index>5__2; // 0x0
	private IEnumerator<TSource> <>7__wrap2; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<SelectIterator>d__5<char, object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2E050 Offset: 0xB2D250 VA: 0x180B2E050
	|-Enumerable.<SelectIterator>d__5<char, object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB02530 Offset: 0xB01730 VA: 0x180B02530
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2DB00 Offset: 0xB2CD00 VA: 0x180B2DB00
	|-Enumerable.<SelectIterator>d__5<char, object>.MoveNext
	|
	|-RVA: 0xB2D450 Offset: 0xB2C650 VA: 0x180B2D450
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2E1D0 Offset: 0xB2D3D0 VA: 0x180B2E1D0
	|-Enumerable.<SelectIterator>d__5<char, object>.<>m__Finally1
	|
	|-RVA: 0xB2E0F0 Offset: 0xB2D2F0 VA: 0x180B2E0F0
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<SelectIterator>d__5<char, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xB1CEE0 Offset: 0xB1C0E0 VA: 0x180B1CEE0
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<SelectIterator>d__5<char, object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<SelectIterator>d__5<char, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB1D160 Offset: 0xB1C360 VA: 0x180B1D160
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02070 Offset: 0xB01270 VA: 0x180B02070
	|-Enumerable.<SelectIterator>d__5<char, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xB2DDC0 Offset: 0xB2CFC0 VA: 0x180B2DDC0
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2DF90 Offset: 0xB2D190 VA: 0x180B2DF90
	|-Enumerable.<SelectIterator>d__5<char, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB1D050 Offset: 0xB1C250 VA: 0x180B1D050
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<>c__DisplayClass6_0<TSource> // TypeDefIndex: 14638
{
	// Fields
	public Func<TSource, bool> predicate1; // 0x0
	public Func<TSource, bool> predicate2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, object>>..ctor
	|-Enumerable.<>c__DisplayClass6_0<int>..ctor
	|-Enumerable.<>c__DisplayClass6_0<Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass6_0<object>..ctor
	|-Enumerable.<>c__DisplayClass6_0<Resolution>..ctor
	|-Enumerable.<>c__DisplayClass6_0<float>..ctor
	|-Enumerable.<>c__DisplayClass6_0<uint>..ctor
	|-Enumerable.<>c__DisplayClass6_0<Vector2>..ctor
	|-Enumerable.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>..ctor
	|-Enumerable.<>c__DisplayClass6_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>..ctor
	|-Enumerable.<>c__DisplayClass6_0<QRCodeGenerator.AlignmentPattern>..ctor
	|-Enumerable.<>c__DisplayClass6_0<QRCodeGenerator.Antilog>..ctor
	|-Enumerable.<>c__DisplayClass6_0<QRCodeGenerator.PolynomItem>..ctor
	|-Enumerable.<>c__DisplayClass6_0<QRCodeGenerator.VersionInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CombinePredicates>b__0(TSource x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0FA50 Offset: 0xB0EC50 VA: 0x180B0FA50
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<DiscardReasonWithCategory, int>>.<CombinePredicates>b__0
	|
	|-RVA: 0xB0F6B0 Offset: 0xB0E8B0 VA: 0x180B0F6B0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, object>>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Resolution>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<QRCodeGenerator.AlignmentPattern>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<QRCodeGenerator.VersionInfo>.<CombinePredicates>b__0
	|
	|-RVA: 0xB0F7A0 Offset: 0xB0E9A0 VA: 0x180B0F7A0
	|-Enumerable.<>c__DisplayClass6_0<int>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Int32Enum>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<uint>.<CombinePredicates>b__0
	|
	|-RVA: 0xB0F730 Offset: 0xB0E930 VA: 0x180B0F730
	|-Enumerable.<>c__DisplayClass6_0<object>.<CombinePredicates>b__0
	|
	|-RVA: 0xB0F5D0 Offset: 0xB0E7D0 VA: 0x180B0F5D0
	|-Enumerable.<>c__DisplayClass6_0<float>.<CombinePredicates>b__0
	|
	|-RVA: 0xB0F560 Offset: 0xB0E760 VA: 0x180B0F560
	|-Enumerable.<>c__DisplayClass6_0<Vector2>.<CombinePredicates>b__0
	|
	|-RVA: 0xB0F8D0 Offset: 0xB0EAD0 VA: 0x180B0F8D0
	|-Enumerable.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>.<CombinePredicates>b__0
	|
	|-RVA: 0xB0F800 Offset: 0xB0EA00 VA: 0x180B0F800
	|-Enumerable.<>c__DisplayClass6_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.<CombinePredicates>b__0
	|
	|-RVA: 0xB0F640 Offset: 0xB0E840 VA: 0x180B0F640
	|-Enumerable.<>c__DisplayClass6_0<QRCodeGenerator.Antilog>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<QRCodeGenerator.PolynomItem>.<CombinePredicates>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<>c__DisplayClass7_0<TSource, TMiddle, TResult> // TypeDefIndex: 14639
{
	// Fields
	public Func<TMiddle, TResult> selector2; // 0x0
	public Func<TSource, TMiddle> selector1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<object, object>, KeyValuePair<object, object>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<object, object>, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ValueTuple<object, object>, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ValueTuple<object, object>, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ValueTuple<object, object>, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ValueTuple<object, object>, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ValueTuple<object, object>, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<bool, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<bool, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<bool, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<bool, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<bool, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<byte, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<byte, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<byte, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<byte, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<byte, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ByteEnum, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ByteEnum, Int32Enum, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, int, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Int32Enum, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, int, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, int, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, Int32Enum, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<StyleSelectorPart, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<StyleSelectorPart, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<StyleSelectorPart, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<StyleSelectorPart, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<StyleSelectorPart, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|-Enumerable.<>c__DisplayClass7_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.AlignmentPattern, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.AlignmentPattern, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.AlignmentPattern, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.AlignmentPattern, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.AlignmentPattern, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.Antilog, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.Antilog, int, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.PolynomItem, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.PolynomItem, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.PolynomItem, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.PolynomItem, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.PolynomItem, object, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, int, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, object, uint>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CombineSelectors>b__0(TSource x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB11E80 Offset: 0xB11080 VA: 0x180B11E80
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<object, object>, KeyValuePair<object, object>>.<CombineSelectors>b__0
	|
	|-RVA: 0xB11BF0 Offset: 0xB10DF0 VA: 0x180B11BF0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<object, object>, object>.<CombineSelectors>b__0
	|
	|-RVA: 0xB11D80 Offset: 0xB10F80 VA: 0x180B11D80
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, uint>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ValueTuple<object, object>, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ValueTuple<object, object>, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ValueTuple<object, object>, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ValueTuple<object, object>, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ValueTuple<object, object>, object, uint>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, object, uint>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.AlignmentPattern, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.AlignmentPattern, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.AlignmentPattern, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.AlignmentPattern, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.AlignmentPattern, object, uint>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, object, uint>.<CombineSelectors>b__0
	|
	|-RVA: 0xB11D30 Offset: 0xB10F30 VA: 0x180B11D30
	|-Enumerable.<>c__DisplayClass7_0<bool, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<bool, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<bool, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<bool, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<bool, object, uint>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<byte, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<byte, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<byte, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<byte, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<byte, object, uint>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, object, uint>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, uint>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, uint>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.PolynomItem, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.PolynomItem, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.PolynomItem, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.PolynomItem, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.PolynomItem, object, uint>.<CombineSelectors>b__0
	|
	|-RVA: 0xB11CE0 Offset: 0xB10EE0 VA: 0x180B11CE0
	|-Enumerable.<>c__DisplayClass7_0<ByteEnum, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ByteEnum, Int32Enum, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, int, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Int32Enum, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, int, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, Int32Enum, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.Antilog, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.Antilog, int, object>.<CombineSelectors>b__0
	|
	|-RVA: 0xB11E30 Offset: 0xB11030 VA: 0x180B11E30
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<JsonElement, int, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<QRCodeGenerator.VersionInfo, int, object>.<CombineSelectors>b__0
	|
	|-RVA: 0xB11DD0 Offset: 0xB10FD0 VA: 0x180B11DD0
	|-Enumerable.<>c__DisplayClass7_0<StyleSelectorPart, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<StyleSelectorPart, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<StyleSelectorPart, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<StyleSelectorPart, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<StyleSelectorPart, object, uint>.<CombineSelectors>b__0
	|
	|-RVA: 0xB11F00 Offset: 0xB11100 VA: 0x180B11F00
	|-Enumerable.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CombineSelectors>b__0
	|
	|-RVA: 0xB11C60 Offset: 0xB10E60 VA: 0x180B11C60
	|-Enumerable.<>c__DisplayClass7_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, uint>.<CombineSelectors>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<SelectManyIterator>d__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 14640
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, IEnumerable<TResult>> selector; // 0x0
	public Func<TSource, IEnumerable<TResult>> <>3__selector; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0
	private IEnumerator<TResult> <>7__wrap2; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB049E0 Offset: 0xB03BE0 VA: 0x180B049E0
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>..ctor
	|
	|-RVA: 0x855E90 Offset: 0x855090 VA: 0x180855E90
	|-Enumerable.<SelectManyIterator>d__17<int, int>..ctor
	|
	|-RVA: 0xB028A0 Offset: 0xB01AA0 VA: 0x180B028A0
	|-Enumerable.<SelectManyIterator>d__17<object, KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<SelectManyIterator>d__17<object, object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB30280 Offset: 0xB2F480 VA: 0x180B30280
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.IDisposable.Dispose
	|
	|-RVA: 0xB30530 Offset: 0xB2F730 VA: 0x180B30530
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.IDisposable.Dispose
	|
	|-RVA: 0xB30110 Offset: 0xB2F310 VA: 0x180B30110
	|-Enumerable.<SelectManyIterator>d__17<object, KeyValuePair<object, object>>.System.IDisposable.Dispose
	|
	|-RVA: 0xB2FFA0 Offset: 0xB2F1A0 VA: 0x180B2FFA0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB303F0 Offset: 0xB2F5F0 VA: 0x180B303F0
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2ED60 Offset: 0xB2DF60 VA: 0x180B2ED60
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.MoveNext
	|
	|-RVA: 0xB2F430 Offset: 0xB2E630 VA: 0x180B2F430
	|-Enumerable.<SelectManyIterator>d__17<int, int>.MoveNext
	|
	|-RVA: 0xB2F0F0 Offset: 0xB2E2F0 VA: 0x180B2F0F0
	|-Enumerable.<SelectManyIterator>d__17<object, KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0xB2E220 Offset: 0xB2D420 VA: 0x180B2E220
	|-Enumerable.<SelectManyIterator>d__17<object, object>.MoveNext
	|
	|-RVA: 0xB2E550 Offset: 0xB2D750 VA: 0x180B2E550
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB307D0 Offset: 0xB2F9D0 VA: 0x180B307D0
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.<>m__Finally1
	|
	|-RVA: 0xB30820 Offset: 0xB2FA20 VA: 0x180B30820
	|-Enumerable.<SelectManyIterator>d__17<int, int>.<>m__Finally1
	|
	|-RVA: 0xB306A0 Offset: 0xB2F8A0 VA: 0x180B306A0
	|-Enumerable.<SelectManyIterator>d__17<object, KeyValuePair<object, object>>.<>m__Finally1
	|
	|-RVA: 0xB30870 Offset: 0xB2FA70 VA: 0x180B30870
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally1
	|
	|-RVA: 0xB306F0 Offset: 0xB2F8F0 VA: 0x180B306F0
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB30A90 Offset: 0xB2FC90 VA: 0x180B30A90
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.<>m__Finally2
	|
	|-RVA: 0xB30960 Offset: 0xB2FB60 VA: 0x180B30960
	|-Enumerable.<SelectManyIterator>d__17<int, int>.<>m__Finally2
	|
	|-RVA: 0xB30910 Offset: 0xB2FB10 VA: 0x180B30910
	|-Enumerable.<SelectManyIterator>d__17<object, KeyValuePair<object, object>>.<>m__Finally2
	|
	|-RVA: 0xB308C0 Offset: 0xB2FAC0 VA: 0x180B308C0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally2
	|
	|-RVA: 0xB309B0 Offset: 0xB2FBB0 VA: 0x180B309B0
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB220A0 Offset: 0xB212A0 VA: 0x180B220A0
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-Enumerable.<SelectManyIterator>d__17<object, KeyValuePair<object, object>>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xB2FA90 Offset: 0xB2EC90 VA: 0x180B2FA90
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.Collections.IEnumerator.Reset
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.Collections.IEnumerator.Reset
	|-Enumerable.<SelectManyIterator>d__17<object, KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2FF40 Offset: 0xB2F140 VA: 0x180B2FF40
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB2FE60 Offset: 0xB2F060 VA: 0x180B2FE60
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB2FF70 Offset: 0xB2F170 VA: 0x180B2FF70
	|-Enumerable.<SelectManyIterator>d__17<object, KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB2FE90 Offset: 0xB2F090 VA: 0x180B2FE90
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2F760 Offset: 0xB2E960 VA: 0x180B2F760
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xB05710 Offset: 0xB04910 VA: 0x180B05710
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xB2F9E0 Offset: 0xB2EBE0 VA: 0x180B2F9E0
	|-Enumerable.<SelectManyIterator>d__17<object, KeyValuePair<object, object>>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xB02070 Offset: 0xB01270 VA: 0x180B02070
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xB2F810 Offset: 0xB2EA10 VA: 0x180B2F810
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2FB60 Offset: 0xB2ED60 VA: 0x180B2FB60
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB2FCE0 Offset: 0xB2EEE0 VA: 0x180B2FCE0
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB2FC20 Offset: 0xB2EE20 VA: 0x180B2FC20
	|-Enumerable.<SelectManyIterator>d__17<object, KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB2FDA0 Offset: 0xB2EFA0 VA: 0x180B2FDA0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB2FB40 Offset: 0xB2ED40 VA: 0x180B2FB40
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<SelectManyIterator>d__23<TSource, TCollection, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 14641
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, IEnumerable<TCollection>> collectionSelector; // 0x0
	public Func<TSource, IEnumerable<TCollection>> <>3__collectionSelector; // 0x0
	private Func<TSource, TCollection, TResult> resultSelector; // 0x0
	public Func<TSource, TCollection, TResult> <>3__resultSelector; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0
	private TSource <element>5__3; // 0x0
	private IEnumerator<TCollection> <>7__wrap3; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<SelectManyIterator>d__23<KeyValuePair<object, object>, int, object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB31E20 Offset: 0xB31020 VA: 0x180B31E20
	|-Enumerable.<SelectManyIterator>d__23<KeyValuePair<object, object>, int, object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB303F0 Offset: 0xB2F5F0 VA: 0x180B303F0
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB31480 Offset: 0xB30680 VA: 0x180B31480
	|-Enumerable.<SelectManyIterator>d__23<KeyValuePair<object, object>, int, object>.MoveNext
	|
	|-RVA: 0xB30AE0 Offset: 0xB2FCE0 VA: 0x180B30AE0
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB32070 Offset: 0xB31270 VA: 0x180B32070
	|-Enumerable.<SelectManyIterator>d__23<KeyValuePair<object, object>, int, object>.<>m__Finally1
	|
	|-RVA: 0xB31F90 Offset: 0xB31190 VA: 0x180B31F90
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB321A0 Offset: 0xB313A0 VA: 0x180B321A0
	|-Enumerable.<SelectManyIterator>d__23<KeyValuePair<object, object>, int, object>.<>m__Finally2
	|
	|-RVA: 0xB320C0 Offset: 0xB312C0 VA: 0x180B320C0
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<SelectManyIterator>d__23<KeyValuePair<object, object>, int, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xB31BD0 Offset: 0xB30DD0 VA: 0x180B31BD0
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<SelectManyIterator>d__23<KeyValuePair<object, object>, int, object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<SelectManyIterator>d__23<KeyValuePair<object, object>, int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB31D60 Offset: 0xB30F60 VA: 0x180B31D60
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB318F0 Offset: 0xB30AF0 VA: 0x180B318F0
	|-Enumerable.<SelectManyIterator>d__23<KeyValuePair<object, object>, int, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xB319A0 Offset: 0xB30BA0 VA: 0x180B319A0
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB31CA0 Offset: 0xB30EA0 VA: 0x180B31CA0
	|-Enumerable.<SelectManyIterator>d__23<KeyValuePair<object, object>, int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB31C80 Offset: 0xB30E80 VA: 0x180B31C80
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<TakeIterator>d__25<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 14642
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private int count; // 0x0
	public int <>3__count; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x855E90 Offset: 0x855090 VA: 0x180855E90
	|-Enumerable.<TakeIterator>d__25<byte>..ctor
	|-Enumerable.<TakeIterator>d__25<int>..ctor
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<TakeIterator>d__25<object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xB05E40 Offset: 0xB05040 VA: 0x180B05E40
	|-Enumerable.<TakeIterator>d__25<SpawnInMinigame.SpawnLocation>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF50740 Offset: 0xF4F940 VA: 0x180F50740
	|-Enumerable.<TakeIterator>d__25<byte>.System.IDisposable.Dispose
	|
	|-RVA: 0xF507E0 Offset: 0xF4F9E0 VA: 0x180F507E0
	|-Enumerable.<TakeIterator>d__25<int>.System.IDisposable.Dispose
	|
	|-RVA: 0xF50600 Offset: 0xF4F800 VA: 0x180F50600
	|-Enumerable.<TakeIterator>d__25<object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB02530 Offset: 0xB01730 VA: 0x180B02530
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	|
	|-RVA: 0xF506A0 Offset: 0xF4F8A0 VA: 0x180F506A0
	|-Enumerable.<TakeIterator>d__25<SpawnInMinigame.SpawnLocation>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4F800 Offset: 0xF4EA00 VA: 0x180F4F800
	|-Enumerable.<TakeIterator>d__25<byte>.MoveNext
	|
	|-RVA: 0xF4F140 Offset: 0xF4E340 VA: 0x180F4F140
	|-Enumerable.<TakeIterator>d__25<int>.MoveNext
	|
	|-RVA: 0xF4F340 Offset: 0xF4E540 VA: 0x180F4F340
	|-Enumerable.<TakeIterator>d__25<object>.MoveNext
	|
	|-RVA: 0xF4FA60 Offset: 0xF4EC60 VA: 0x180F4FA60
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0xF4F540 Offset: 0xF4E740 VA: 0x180F4F540
	|-Enumerable.<TakeIterator>d__25<SpawnInMinigame.SpawnLocation>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF50A50 Offset: 0xF4FC50 VA: 0x180F50A50
	|-Enumerable.<TakeIterator>d__25<byte>.<>m__Finally1
	|
	|-RVA: 0xF50960 Offset: 0xF4FB60 VA: 0x180F50960
	|-Enumerable.<TakeIterator>d__25<int>.<>m__Finally1
	|
	|-RVA: 0xF50A00 Offset: 0xF4FC00 VA: 0x180F50A00
	|-Enumerable.<TakeIterator>d__25<object>.<>m__Finally1
	|
	|-RVA: 0xF50880 Offset: 0xF4FA80 VA: 0x180F50880
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.<>m__Finally1
	|
	|-RVA: 0xF509B0 Offset: 0xF4FBB0 VA: 0x180F509B0
	|-Enumerable.<TakeIterator>d__25<SpawnInMinigame.SpawnLocation>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	|-Enumerable.<TakeIterator>d__25<int>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB02120 Offset: 0xB01320 VA: 0x180B02120
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x4C1250 Offset: 0x4C0450 VA: 0x1804C1250
	|-Enumerable.<TakeIterator>d__25<SpawnInMinigame.SpawnLocation>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.Reset
	|-Enumerable.<TakeIterator>d__25<int>.System.Collections.IEnumerator.Reset
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|-Enumerable.<TakeIterator>d__25<SpawnInMinigame.SpawnLocation>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB32A70 Offset: 0xB31C70 VA: 0x180B32A70
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xF50590 Offset: 0xF4F790 VA: 0x180F50590
	|-Enumerable.<TakeIterator>d__25<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB023B0 Offset: 0xB015B0 VA: 0x180B023B0
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xF505C0 Offset: 0xF4F7C0 VA: 0x180F505C0
	|-Enumerable.<TakeIterator>d__25<SpawnInMinigame.SpawnLocation>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF50020 Offset: 0xF4F220 VA: 0x180F50020
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<int>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xF4FF70 Offset: 0xF4F170 VA: 0x180F4FF70
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xF500D0 Offset: 0xF4F2D0 VA: 0x180F500D0
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xF502A0 Offset: 0xF4F4A0 VA: 0x180F502A0
	|-Enumerable.<TakeIterator>d__25<SpawnInMinigame.SpawnLocation>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF50410 Offset: 0xF4F610 VA: 0x180F50410
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xF504D0 Offset: 0xF4F6D0 VA: 0x180F504D0
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB021D0 Offset: 0xB013D0 VA: 0x180B021D0
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xF50350 Offset: 0xF4F550 VA: 0x180F50350
	|-Enumerable.<TakeIterator>d__25<SpawnInMinigame.SpawnLocation>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<SkipIterator>d__31<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 14643
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private int count; // 0x0
	public int <>3__count; // 0x0
	private IEnumerator<TSource> <e>5__2; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x855E90 Offset: 0x855090 VA: 0x180855E90
	|-Enumerable.<SkipIterator>d__31<byte>..ctor
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<SkipIterator>d__31<object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<SkipIterator>d__31<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB32AA0 Offset: 0xB31CA0 VA: 0x180B32AA0
	|-Enumerable.<SkipIterator>d__31<byte>.System.IDisposable.Dispose
	|
	|-RVA: 0xB32B40 Offset: 0xB31D40 VA: 0x180B32B40
	|-Enumerable.<SkipIterator>d__31<object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB02530 Offset: 0xB01730 VA: 0x180B02530
	|-Enumerable.<SkipIterator>d__31<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB321F0 Offset: 0xB313F0 VA: 0x180B321F0
	|-Enumerable.<SkipIterator>d__31<byte>.MoveNext
	|
	|-RVA: 0xB324F0 Offset: 0xB316F0 VA: 0x180B324F0
	|-Enumerable.<SkipIterator>d__31<object>.MoveNext
	|
	|-RVA: 0xF4D620 Offset: 0xF4C820 VA: 0x180F4D620
	|-Enumerable.<SkipIterator>d__31<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB32C30 Offset: 0xB31E30 VA: 0x180B32C30
	|-Enumerable.<SkipIterator>d__31<byte>.<>m__Finally1
	|
	|-RVA: 0xB32BE0 Offset: 0xB31DE0 VA: 0x180B32BE0
	|-Enumerable.<SkipIterator>d__31<object>.<>m__Finally1
	|
	|-RVA: 0xF4DD80 Offset: 0xF4CF80 VA: 0x180F4DD80
	|-Enumerable.<SkipIterator>d__31<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB02120 Offset: 0xB01320 VA: 0x180B02120
	|-Enumerable.<SkipIterator>d__31<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.Reset
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<SkipIterator>d__31<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB32A70 Offset: 0xB31C70 VA: 0x180B32A70
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB023B0 Offset: 0xB015B0 VA: 0x180B023B0
	|-Enumerable.<SkipIterator>d__31<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB32840 Offset: 0xB31A40 VA: 0x180B32840
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xB32790 Offset: 0xB31990 VA: 0x180B32790
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xF4DBB0 Offset: 0xF4CDB0 VA: 0x180F4DBB0
	|-Enumerable.<SkipIterator>d__31<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB328F0 Offset: 0xB31AF0 VA: 0x180B328F0
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB329B0 Offset: 0xB31BB0 VA: 0x180B329B0
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB021D0 Offset: 0xB013D0 VA: 0x180B021D0
	|-Enumerable.<SkipIterator>d__31<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<ConcatIterator>d__59<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 14644
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x855E90 Offset: 0x855090 VA: 0x180855E90
	|-Enumerable.<ConcatIterator>d__59<byte>..ctor
	|-Enumerable.<ConcatIterator>d__59<Int32Enum>..ctor
	|
	|-RVA: 0xB05E40 Offset: 0xB05040 VA: 0x180B05E40
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>..ctor
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<ConcatIterator>d__59<object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB05BB0 Offset: 0xB04DB0 VA: 0x180B05BB0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.IDisposable.Dispose
	|
	|-RVA: 0xB05A60 Offset: 0xB04C60 VA: 0x180B05A60
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.IDisposable.Dispose
	|
	|-RVA: 0xB1B840 Offset: 0xB1AA40 VA: 0x180B1B840
	|-Enumerable.<ConcatIterator>d__59<Int32Enum>.System.IDisposable.Dispose
	|
	|-RVA: 0xB1B6F0 Offset: 0xB1A8F0 VA: 0x180B1B6F0
	|-Enumerable.<ConcatIterator>d__59<object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB1B990 Offset: 0xB1AB90 VA: 0x180B1B990
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB05000 Offset: 0xB04200 VA: 0x180B05000
	|-Enumerable.<ConcatIterator>d__59<byte>.MoveNext
	|
	|-RVA: 0xB05340 Offset: 0xB04540 VA: 0x180B05340
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.MoveNext
	|
	|-RVA: 0xB1AF70 Offset: 0xB1A170 VA: 0x180B1AF70
	|-Enumerable.<ConcatIterator>d__59<Int32Enum>.MoveNext
	|
	|-RVA: 0xB1A490 Offset: 0xB19690 VA: 0x180B1A490
	|-Enumerable.<ConcatIterator>d__59<object>.MoveNext
	|
	|-RVA: 0xB1A7E0 Offset: 0xB199E0 VA: 0x180B1A7E0
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB05D00 Offset: 0xB04F00 VA: 0x180B05D00
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally1
	|
	|-RVA: 0xB05D50 Offset: 0xB04F50 VA: 0x180B05D50
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.<>m__Finally1
	|
	|-RVA: 0xB1BBE0 Offset: 0xB1ADE0 VA: 0x180B1BBE0
	|-Enumerable.<ConcatIterator>d__59<Int32Enum>.<>m__Finally1
	|
	|-RVA: 0xB1BB90 Offset: 0xB1AD90 VA: 0x180B1BB90
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally1
	|
	|-RVA: 0xB1BAB0 Offset: 0xB1ACB0 VA: 0x180B1BAB0
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB05DA0 Offset: 0xB04FA0 VA: 0x180B05DA0
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally2
	|
	|-RVA: 0xB05DF0 Offset: 0xB04FF0 VA: 0x180B05DF0
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.<>m__Finally2
	|
	|-RVA: 0xB1BD60 Offset: 0xB1AF60 VA: 0x180B1BD60
	|-Enumerable.<ConcatIterator>d__59<Int32Enum>.<>m__Finally2
	|
	|-RVA: 0xB1BC30 Offset: 0xB1AE30 VA: 0x180B1BC30
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally2
	|
	|-RVA: 0xB1BC80 Offset: 0xB1AE80 VA: 0x180B1BC80
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x4C1250 Offset: 0x4C0450 VA: 0x1804C1250
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	|-Enumerable.<ConcatIterator>d__59<Int32Enum>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB1B480 Offset: 0xB1A680 VA: 0x180B1B480
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.Reset
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|-Enumerable.<ConcatIterator>d__59<Int32Enum>.System.Collections.IEnumerator.Reset
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB05A30 Offset: 0xB04C30 VA: 0x180B05A30
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB059F0 Offset: 0xB04BF0 VA: 0x180B059F0
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB1B6C0 Offset: 0xB1A8C0 VA: 0x180B1B6C0
	|-Enumerable.<ConcatIterator>d__59<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB1B610 Offset: 0xB1A810 VA: 0x180B1B610
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB05710 Offset: 0xB04910 VA: 0x180B05710
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<ConcatIterator>d__59<Int32Enum>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xB057C0 Offset: 0xB049C0 VA: 0x180B057C0
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xB02070 Offset: 0xB01270 VA: 0x180B02070
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xB1B2B0 Offset: 0xB1A4B0 VA: 0x180B1B2B0
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB05870 Offset: 0xB04A70 VA: 0x180B05870
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ConcatIterator>d__59<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB05930 Offset: 0xB04B30 VA: 0x180B05930
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB1B550 Offset: 0xB1A750 VA: 0x180B1B550
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB1B530 Offset: 0xB1A730 VA: 0x180B1B530
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<AppendIterator>d__61<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 14645
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private TSource element; // 0x0
	public TSource <>3__element; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB028A0 Offset: 0xB01AA0 VA: 0x180B028A0
	|-Enumerable.<AppendIterator>d__61<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<AppendIterator>d__61<object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<AppendIterator>d__61<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02490 Offset: 0xB01690 VA: 0x180B02490
	|-Enumerable.<AppendIterator>d__61<KeyValuePair<object, object>>.System.IDisposable.Dispose
	|
	|-RVA: 0xB025D0 Offset: 0xB017D0 VA: 0x180B025D0
	|-Enumerable.<AppendIterator>d__61<object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB02530 Offset: 0xB01730 VA: 0x180B02530
	|-Enumerable.<AppendIterator>d__61<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB01B30 Offset: 0xB00D30 VA: 0x180B01B30
	|-Enumerable.<AppendIterator>d__61<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0xB01910 Offset: 0xB00B10 VA: 0x180B01910
	|-Enumerable.<AppendIterator>d__61<object>.MoveNext
	|
	|-RVA: 0xB01330 Offset: 0xB00530 VA: 0x180B01330
	|-Enumerable.<AppendIterator>d__61<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02670 Offset: 0xB01870 VA: 0x180B02670
	|-Enumerable.<AppendIterator>d__61<KeyValuePair<object, object>>.<>m__Finally1
	|
	|-RVA: 0xB027A0 Offset: 0xB019A0 VA: 0x180B027A0
	|-Enumerable.<AppendIterator>d__61<object>.<>m__Finally1
	|
	|-RVA: 0xB026C0 Offset: 0xB018C0 VA: 0x180B026C0
	|-Enumerable.<AppendIterator>d__61<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-Enumerable.<AppendIterator>d__61<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<AppendIterator>d__61<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB02120 Offset: 0xB01320 VA: 0x180B02120
	|-Enumerable.<AppendIterator>d__61<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<AppendIterator>d__61<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|-Enumerable.<AppendIterator>d__61<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<AppendIterator>d__61<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02460 Offset: 0xB01660 VA: 0x180B02460
	|-Enumerable.<AppendIterator>d__61<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<AppendIterator>d__61<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB023B0 Offset: 0xB015B0 VA: 0x180B023B0
	|-Enumerable.<AppendIterator>d__61<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB01FC0 Offset: 0xB011C0 VA: 0x180B01FC0
	|-Enumerable.<AppendIterator>d__61<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xB02070 Offset: 0xB01270 VA: 0x180B02070
	|-Enumerable.<AppendIterator>d__61<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xB01DB0 Offset: 0xB00FB0 VA: 0x180B01DB0
	|-Enumerable.<AppendIterator>d__61<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB021F0 Offset: 0xB013F0 VA: 0x180B021F0
	|-Enumerable.<AppendIterator>d__61<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB022B0 Offset: 0xB014B0 VA: 0x180B022B0
	|-Enumerable.<AppendIterator>d__61<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB021D0 Offset: 0xB013D0 VA: 0x180B021D0
	|-Enumerable.<AppendIterator>d__61<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<ZipIterator>d__65<TFirst, TSecond, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 14646
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TFirst> first; // 0x0
	public IEnumerable<TFirst> <>3__first; // 0x0
	private IEnumerable<TSecond> second; // 0x0
	public IEnumerable<TSecond> <>3__second; // 0x0
	private Func<TFirst, TSecond, TResult> resultSelector; // 0x0
	public Func<TFirst, TSecond, TResult> <>3__resultSelector; // 0x0
	private IEnumerator<TFirst> <e1>5__2; // 0x0
	private IEnumerator<TSecond> <e2>5__3; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB028A0 Offset: 0xB01AA0 VA: 0x180B028A0
	|-Enumerable.<ZipIterator>d__65<object, object, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<ZipIterator>d__65<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF577F0 Offset: 0xF569F0 VA: 0x180F577F0
	|-Enumerable.<ZipIterator>d__65<object, object, ValueTuple<object, object>>.System.IDisposable.Dispose
	|
	|-RVA: 0xB303F0 Offset: 0xB2F5F0 VA: 0x180B303F0
	|-Enumerable.<ZipIterator>d__65<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF56F00 Offset: 0xF56100 VA: 0x180F56F00
	|-Enumerable.<ZipIterator>d__65<object, object, ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0xF56740 Offset: 0xF55940 VA: 0x180F56740
	|-Enumerable.<ZipIterator>d__65<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF57A40 Offset: 0xF56C40 VA: 0x180F57A40
	|-Enumerable.<ZipIterator>d__65<object, object, ValueTuple<object, object>>.<>m__Finally1
	|
	|-RVA: 0xF57960 Offset: 0xF56B60 VA: 0x180F57960
	|-Enumerable.<ZipIterator>d__65<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF57A90 Offset: 0xF56C90 VA: 0x180F57A90
	|-Enumerable.<ZipIterator>d__65<object, object, ValueTuple<object, object>>.<>m__Finally2
	|
	|-RVA: 0xF57AE0 Offset: 0xF56CE0 VA: 0x180F57AE0
	|-Enumerable.<ZipIterator>d__65<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-Enumerable.<ZipIterator>d__65<object, object, ValueTuple<object, object>>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xF57580 Offset: 0xF56780 VA: 0x180F57580
	|-Enumerable.<ZipIterator>d__65<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<ZipIterator>d__65<object, object, ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|-Enumerable.<ZipIterator>d__65<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF57710 Offset: 0xF56910 VA: 0x180F57710
	|-Enumerable.<ZipIterator>d__65<object, object, ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xF57740 Offset: 0xF56940 VA: 0x180F57740
	|-Enumerable.<ZipIterator>d__65<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF572A0 Offset: 0xF564A0 VA: 0x180F572A0
	|-Enumerable.<ZipIterator>d__65<object, object, ValueTuple<object, object>>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xF57350 Offset: 0xF56550 VA: 0x180F57350
	|-Enumerable.<ZipIterator>d__65<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF57650 Offset: 0xF56850 VA: 0x180F57650
	|-Enumerable.<ZipIterator>d__65<object, object, ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xF57630 Offset: 0xF56830 VA: 0x180F57630
	|-Enumerable.<ZipIterator>d__65<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<DistinctIterator>d__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 14647
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Set<TSource> <set>5__2; // 0x0
	private IEnumerator<TSource> <>7__wrap2; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x855E90 Offset: 0x855090 VA: 0x180855E90
	|-Enumerable.<DistinctIterator>d__68<int>..ctor
	|-Enumerable.<DistinctIterator>d__68<Int32Enum>..ctor
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<DistinctIterator>d__68<object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1D2B0 Offset: 0xB1C4B0 VA: 0x180B1D2B0
	|-Enumerable.<DistinctIterator>d__68<int>.System.IDisposable.Dispose
	|
	|-RVA: 0xB1D350 Offset: 0xB1C550 VA: 0x180B1D350
	|-Enumerable.<DistinctIterator>d__68<Int32Enum>.System.IDisposable.Dispose
	|
	|-RVA: 0xB1D210 Offset: 0xB1C410 VA: 0x180B1D210
	|-Enumerable.<DistinctIterator>d__68<object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB02530 Offset: 0xB01730 VA: 0x180B02530
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1BDB0 Offset: 0xB1AFB0 VA: 0x180B1BDB0
	|-Enumerable.<DistinctIterator>d__68<int>.MoveNext
	|
	|-RVA: 0xB1C680 Offset: 0xB1B880 VA: 0x180B1C680
	|-Enumerable.<DistinctIterator>d__68<Int32Enum>.MoveNext
	|
	|-RVA: 0xB1C910 Offset: 0xB1BB10 VA: 0x180B1C910
	|-Enumerable.<DistinctIterator>d__68<object>.MoveNext
	|
	|-RVA: 0xB1C040 Offset: 0xB1B240 VA: 0x180B1C040
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1D520 Offset: 0xB1C720 VA: 0x180B1D520
	|-Enumerable.<DistinctIterator>d__68<int>.<>m__Finally1
	|
	|-RVA: 0xB1D4D0 Offset: 0xB1C6D0 VA: 0x180B1D4D0
	|-Enumerable.<DistinctIterator>d__68<Int32Enum>.<>m__Finally1
	|
	|-RVA: 0xB1D570 Offset: 0xB1C770 VA: 0x180B1D570
	|-Enumerable.<DistinctIterator>d__68<object>.<>m__Finally1
	|
	|-RVA: 0xB1D3F0 Offset: 0xB1C5F0 VA: 0x180B1D3F0
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|-Enumerable.<DistinctIterator>d__68<Int32Enum>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB1CEE0 Offset: 0xB1C0E0 VA: 0x180B1CEE0
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.IEnumerator.Reset
	|-Enumerable.<DistinctIterator>d__68<Int32Enum>.System.Collections.IEnumerator.Reset
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1D130 Offset: 0xB1C330 VA: 0x180B1D130
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<DistinctIterator>d__68<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB1D160 Offset: 0xB1C360 VA: 0x180B1D160
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1CE30 Offset: 0xB1C030 VA: 0x180B1CE30
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<DistinctIterator>d__68<Int32Enum>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xB1CBB0 Offset: 0xB1BDB0 VA: 0x180B1CBB0
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xB1CC60 Offset: 0xB1BE60 VA: 0x180B1CC60
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1CF90 Offset: 0xB1C190 VA: 0x180B1CF90
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<DistinctIterator>d__68<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB1D070 Offset: 0xB1C270 VA: 0x180B1D070
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB1D050 Offset: 0xB1C250 VA: 0x180B1D050
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<UnionIterator>d__71<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 14648
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private Set<TSource> <set>5__2; // 0x0
	private IEnumerator<TSource> <>7__wrap2; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x855E90 Offset: 0x855090 VA: 0x180855E90
	|-Enumerable.<UnionIterator>d__71<char>..ctor
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<UnionIterator>d__71<object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF52400 Offset: 0xF51600 VA: 0x180F52400
	|-Enumerable.<UnionIterator>d__71<char>.System.IDisposable.Dispose
	|
	|-RVA: 0xF522B0 Offset: 0xF514B0 VA: 0x180F522B0
	|-Enumerable.<UnionIterator>d__71<object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB1B990 Offset: 0xB1AB90 VA: 0x180B1B990
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF51910 Offset: 0xF50B10 VA: 0x180F51910
	|-Enumerable.<UnionIterator>d__71<char>.MoveNext
	|
	|-RVA: 0xF50AA0 Offset: 0xF4FCA0 VA: 0x180F50AA0
	|-Enumerable.<UnionIterator>d__71<object>.MoveNext
	|
	|-RVA: 0xF50EE0 Offset: 0xF500E0 VA: 0x180F50EE0
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF52550 Offset: 0xF51750 VA: 0x180F52550
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally1
	|
	|-RVA: 0xF525A0 Offset: 0xF517A0 VA: 0x180F525A0
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally1
	|
	|-RVA: 0xF525F0 Offset: 0xF517F0 VA: 0x180F525F0
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF52800 Offset: 0xF51A00 VA: 0x180F52800
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally2
	|
	|-RVA: 0xF527B0 Offset: 0xF519B0 VA: 0x180F527B0
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally2
	|
	|-RVA: 0xF526D0 Offset: 0xF518D0 VA: 0x180F526D0
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03E10 Offset: 0xB03010 VA: 0x180B03E10
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB236C0 Offset: 0xB228C0 VA: 0x180B236C0
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.Reset
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF52280 Offset: 0xF51480 VA: 0x180F52280
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB237A0 Offset: 0xB229A0 VA: 0x180B237A0
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF52030 Offset: 0xF51230 VA: 0x180F52030
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xF51F80 Offset: 0xF51180 VA: 0x180F51F80
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xF51D50 Offset: 0xF50F50 VA: 0x180F51D50
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF521C0 Offset: 0xF513C0 VA: 0x180F521C0
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xF520E0 Offset: 0xF512E0 VA: 0x180F520E0
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xF521A0 Offset: 0xF513A0 VA: 0x180F521A0
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<ExceptIterator>d__77<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 14649
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private Set<TSource> <set>5__2; // 0x0
	private IEnumerator<TSource> <>7__wrap2; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<ExceptIterator>d__77<object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<ExceptIterator>d__77<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1FD70 Offset: 0xB1EF70 VA: 0x180B1FD70
	|-Enumerable.<ExceptIterator>d__77<object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB02530 Offset: 0xB01730 VA: 0x180B02530
	|-Enumerable.<ExceptIterator>d__77<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1EA30 Offset: 0xB1DC30 VA: 0x180B1EA30
	|-Enumerable.<ExceptIterator>d__77<object>.MoveNext
	|
	|-RVA: 0xB1EFC0 Offset: 0xB1E1C0 VA: 0x180B1EFC0
	|-Enumerable.<ExceptIterator>d__77<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1FEF0 Offset: 0xB1F0F0 VA: 0x180B1FEF0
	|-Enumerable.<ExceptIterator>d__77<object>.<>m__Finally1
	|
	|-RVA: 0xB1FE10 Offset: 0xB1F010 VA: 0x180B1FE10
	|-Enumerable.<ExceptIterator>d__77<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB1CEE0 Offset: 0xB1C0E0 VA: 0x180B1CEE0
	|-Enumerable.<ExceptIterator>d__77<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<ExceptIterator>d__77<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB1D160 Offset: 0xB1C360 VA: 0x180B1D160
	|-Enumerable.<ExceptIterator>d__77<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1FC00 Offset: 0xB1EE00 VA: 0x180B1FC00
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xB1F9D0 Offset: 0xB1EBD0 VA: 0x180B1F9D0
	|-Enumerable.<ExceptIterator>d__77<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1FCB0 Offset: 0xB1EEB0 VA: 0x180B1FCB0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB1D050 Offset: 0xB1C250 VA: 0x180B1D050
	|-Enumerable.<ExceptIterator>d__77<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<ReverseIterator>d__79<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 14650
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Buffer<TSource> <buffer>5__2; // 0x0
	private int <i>5__3; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x855E90 Offset: 0x855090 VA: 0x180855E90
	|-Enumerable.<ReverseIterator>d__79<Int32Enum>..ctor
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<ReverseIterator>d__79<object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<ReverseIterator>d__79<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-Enumerable.<ReverseIterator>d__79<Int32Enum>.System.IDisposable.Dispose
	|-Enumerable.<ReverseIterator>d__79<object>.System.IDisposable.Dispose
	|-Enumerable.<ReverseIterator>d__79<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2AFB0 Offset: 0xB2A1B0 VA: 0x180B2AFB0
	|-Enumerable.<ReverseIterator>d__79<Int32Enum>.MoveNext
	|
	|-RVA: 0xB2AF00 Offset: 0xB2A100 VA: 0x180B2AF00
	|-Enumerable.<ReverseIterator>d__79<object>.MoveNext
	|
	|-RVA: 0xB2B050 Offset: 0xB2A250 VA: 0x180B2B050
	|-Enumerable.<ReverseIterator>d__79<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	|-Enumerable.<ReverseIterator>d__79<Int32Enum>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB1E870 Offset: 0xB1DA70 VA: 0x180B1E870
	|-Enumerable.<ReverseIterator>d__79<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<ReverseIterator>d__79<Int32Enum>.System.Collections.IEnumerator.Reset
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<ReverseIterator>d__79<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2B650 Offset: 0xB2A850 VA: 0x180B2B650
	|-Enumerable.<ReverseIterator>d__79<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB1E920 Offset: 0xB1DB20 VA: 0x180B1E920
	|-Enumerable.<ReverseIterator>d__79<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03C10 Offset: 0xB02E10 VA: 0x180B03C10
	|-Enumerable.<ReverseIterator>d__79<Int32Enum>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xB03A30 Offset: 0xB02C30 VA: 0x180B03A30
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0xB2B390 Offset: 0xB2A590 VA: 0x180B2B390
	|-Enumerable.<ReverseIterator>d__79<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2B5A0 Offset: 0xB2A7A0 VA: 0x180B2B5A0
	|-Enumerable.<ReverseIterator>d__79<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB2B4F0 Offset: 0xB2A6F0 VA: 0x180B2B4F0
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB205F0 Offset: 0xB1F7F0 VA: 0x180B205F0
	|-Enumerable.<ReverseIterator>d__79<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<OfTypeIterator>d__97<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 14651
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable source; // 0x0
	public IEnumerable <>3__source; // 0x0
	private IEnumerator <>7__wrap1; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<OfTypeIterator>d__97<object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<OfTypeIterator>d__97<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB25E20 Offset: 0xB25020 VA: 0x180B25E20
	|-Enumerable.<OfTypeIterator>d__97<object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB02530 Offset: 0xB01730 VA: 0x180B02530
	|-Enumerable.<OfTypeIterator>d__97<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB25BC0 Offset: 0xB24DC0 VA: 0x180B25BC0
	|-Enumerable.<OfTypeIterator>d__97<object>.MoveNext
	|
	|-RVA: 0xB257A0 Offset: 0xB249A0 VA: 0x180B257A0
	|-Enumerable.<OfTypeIterator>d__97<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB25F50 Offset: 0xB25150 VA: 0x180B25F50
	|-Enumerable.<OfTypeIterator>d__97<object>.<>m__Finally1
	|
	|-RVA: 0xB25E90 Offset: 0xB25090 VA: 0x180B25E90
	|-Enumerable.<OfTypeIterator>d__97<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xB03E40 Offset: 0xB03040 VA: 0x180B03E40
	|-Enumerable.<OfTypeIterator>d__97<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<OfTypeIterator>d__97<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB042C0 Offset: 0xB034C0 VA: 0x180B042C0
	|-Enumerable.<OfTypeIterator>d__97<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03A30 Offset: 0xB02C30 VA: 0x180B03A30
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xB03CB0 Offset: 0xB02EB0 VA: 0x180B03CB0
	|-Enumerable.<OfTypeIterator>d__97<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03EF0 Offset: 0xB030F0 VA: 0x180B03EF0
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB041B0 Offset: 0xB033B0 VA: 0x180B041B0
	|-Enumerable.<OfTypeIterator>d__97<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<CastIterator>d__99<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 14652
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable source; // 0x0
	public IEnumerable <>3__source; // 0x0
	private IEnumerator <>7__wrap1; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x855E90 Offset: 0x855090 VA: 0x180855E90
	|-Enumerable.<CastIterator>d__99<bool>..ctor
	|-Enumerable.<CastIterator>d__99<ByteEnum>..ctor
	|-Enumerable.<CastIterator>d__99<Int32Enum>..ctor
	|-Enumerable.<CastIterator>d__99<UInt16Enum>..ctor
	|
	|-RVA: 0xB028A0 Offset: 0xB01AA0 VA: 0x180B028A0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>..ctor
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-Enumerable.<CastIterator>d__99<object>..ctor
	|
	|-RVA: 0xB049E0 Offset: 0xB03BE0 VA: 0x180B049E0
	|-Enumerable.<CastIterator>d__99<Vector2>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04530 Offset: 0xB03730 VA: 0x180B04530
	|-Enumerable.<CastIterator>d__99<bool>.System.IDisposable.Dispose
	|
	|-RVA: 0xB045A0 Offset: 0xB037A0 VA: 0x180B045A0
	|-Enumerable.<CastIterator>d__99<ByteEnum>.System.IDisposable.Dispose
	|
	|-RVA: 0xB043E0 Offset: 0xB035E0 VA: 0x180B043E0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.IDisposable.Dispose
	|
	|-RVA: 0xB04450 Offset: 0xB03650 VA: 0x180B04450
	|-Enumerable.<CastIterator>d__99<Int32Enum>.System.IDisposable.Dispose
	|
	|-RVA: 0xB044C0 Offset: 0xB036C0 VA: 0x180B044C0
	|-Enumerable.<CastIterator>d__99<object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB04610 Offset: 0xB03810 VA: 0x180B04610
	|-Enumerable.<CastIterator>d__99<UInt16Enum>.System.IDisposable.Dispose
	|
	|-RVA: 0xB04370 Offset: 0xB03570 VA: 0x180B04370
	|-Enumerable.<CastIterator>d__99<Vector2>.System.IDisposable.Dispose
	|
	|-RVA: 0xB02530 Offset: 0xB01730 VA: 0x180B02530
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03670 Offset: 0xB02870 VA: 0x180B03670
	|-Enumerable.<CastIterator>d__99<bool>.MoveNext
	|
	|-RVA: 0xB028D0 Offset: 0xB01AD0 VA: 0x180B028D0
	|-Enumerable.<CastIterator>d__99<ByteEnum>.MoveNext
	|
	|-RVA: 0xB03490 Offset: 0xB02690 VA: 0x180B03490
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.MoveNext
	|
	|-RVA: 0xB032B0 Offset: 0xB024B0 VA: 0x180B032B0
	|-Enumerable.<CastIterator>d__99<Int32Enum>.MoveNext
	|
	|-RVA: 0xB02EA0 Offset: 0xB020A0 VA: 0x180B02EA0
	|-Enumerable.<CastIterator>d__99<object>.MoveNext
	|
	|-RVA: 0xB03850 Offset: 0xB02A50 VA: 0x180B03850
	|-Enumerable.<CastIterator>d__99<UInt16Enum>.MoveNext
	|
	|-RVA: 0xB030C0 Offset: 0xB022C0 VA: 0x180B030C0
	|-Enumerable.<CastIterator>d__99<Vector2>.MoveNext
	|
	|-RVA: 0xB02AB0 Offset: 0xB01CB0 VA: 0x180B02AB0
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04740 Offset: 0xB03940 VA: 0x180B04740
	|-Enumerable.<CastIterator>d__99<bool>.<>m__Finally1
	|
	|-RVA: 0xB04980 Offset: 0xB03B80 VA: 0x180B04980
	|-Enumerable.<CastIterator>d__99<ByteEnum>.<>m__Finally1
	|
	|-RVA: 0xB048C0 Offset: 0xB03AC0 VA: 0x180B048C0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.<>m__Finally1
	|
	|-RVA: 0xB046E0 Offset: 0xB038E0 VA: 0x180B046E0
	|-Enumerable.<CastIterator>d__99<Int32Enum>.<>m__Finally1
	|
	|-RVA: 0xB04860 Offset: 0xB03A60 VA: 0x180B04860
	|-Enumerable.<CastIterator>d__99<object>.<>m__Finally1
	|
	|-RVA: 0xB04680 Offset: 0xB03880 VA: 0x180B04680
	|-Enumerable.<CastIterator>d__99<UInt16Enum>.<>m__Finally1
	|
	|-RVA: 0xB04920 Offset: 0xB03B20 VA: 0x180B04920
	|-Enumerable.<CastIterator>d__99<Vector2>.<>m__Finally1
	|
	|-RVA: 0xB047A0 Offset: 0xB039A0 VA: 0x180B047A0
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|-Enumerable.<CastIterator>d__99<ByteEnum>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	|-Enumerable.<CastIterator>d__99<Int32Enum>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xB03E10 Offset: 0xB03010 VA: 0x180B03E10
	|-Enumerable.<CastIterator>d__99<UInt16Enum>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xB03E20 Offset: 0xB03020 VA: 0x180B03E20
	|-Enumerable.<CastIterator>d__99<Vector2>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xB03E40 Offset: 0xB03040 VA: 0x180B03E40
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.Reset
	|-Enumerable.<CastIterator>d__99<ByteEnum>.System.Collections.IEnumerator.Reset
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|-Enumerable.<CastIterator>d__99<Int32Enum>.System.Collections.IEnumerator.Reset
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.Reset
	|-Enumerable.<CastIterator>d__99<UInt16Enum>.System.Collections.IEnumerator.Reset
	|-Enumerable.<CastIterator>d__99<Vector2>.System.Collections.IEnumerator.Reset
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB041D0 Offset: 0xB033D0 VA: 0x180B041D0
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<CastIterator>d__99<ByteEnum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB04290 Offset: 0xB03490 VA: 0x180B04290
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB04230 Offset: 0xB03430 VA: 0x180B04230
	|-Enumerable.<CastIterator>d__99<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB04200 Offset: 0xB03400 VA: 0x180B04200
	|-Enumerable.<CastIterator>d__99<UInt16Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB04260 Offset: 0xB03460 VA: 0x180B04260
	|-Enumerable.<CastIterator>d__99<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB042C0 Offset: 0xB034C0 VA: 0x180B042C0
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03C10 Offset: 0xB02E10 VA: 0x180B03C10
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<ByteEnum>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<Int32Enum>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<UInt16Enum>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xB03B70 Offset: 0xB02D70 VA: 0x180B03B70
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xB03A30 Offset: 0xB02C30 VA: 0x180B03A30
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xB03AD0 Offset: 0xB02CD0 VA: 0x180B03AD0
	|-Enumerable.<CastIterator>d__99<Vector2>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0xB03CB0 Offset: 0xB02EB0 VA: 0x180B03CB0
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03FA0 Offset: 0xB031A0 VA: 0x180B03FA0
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<ByteEnum>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<UInt16Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB04100 Offset: 0xB03300 VA: 0x180B04100
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB03EF0 Offset: 0xB030F0 VA: 0x180B03EF0
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB04050 Offset: 0xB03250 VA: 0x180B04050
	|-Enumerable.<CastIterator>d__99<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB041B0 Offset: 0xB033B0 VA: 0x180B041B0
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<RangeIterator>d__115 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IDisposable, IEnumerator // TypeDefIndex: 14653
{
	// Fields
	private int <>1__state; // 0x10
	private int <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x18
	private int start; // 0x1C
	public int <>3__start; // 0x20
	private int count; // 0x24
	public int <>3__count; // 0x28
	private int <i>5__2; // 0x2C

	// Properties
	private int System.Collections.Generic.IEnumerator<System.Int32>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x855E90 Offset: 0x855090 VA: 0x180855E90
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1CFBB40 Offset: 0x1CFAD40 VA: 0x181CFBB40 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 6
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1CFBC20 Offset: 0x1CFAE20 VA: 0x181CFBC20 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1CFBC60 Offset: 0x1CFAE60 VA: 0x181CFBC60 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1CFBB80 Offset: 0x1CFAD80 VA: 0x181CFBB80 Slot: 4
	private IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1CFBB80 Offset: 0x1CFAD80 VA: 0x181CFBB80 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Linq
[Extension]
public static class Enumerable // TypeDefIndex: 14654
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97E010 Offset: 0x97D210 VA: 0x18097E010
	|-Enumerable.Where<KeyValuePair<DiscardReasonWithCategory, int>>
	|
	|-RVA: 0x97E370 Offset: 0x97D570 VA: 0x18097E370
	|-Enumerable.Where<KeyValuePair<object, object>>
	|-Enumerable.Where<Resolution>
	|-Enumerable.Where<QRCodeGenerator.AlignmentPattern>
	|-Enumerable.Where<QRCodeGenerator.VersionInfo>
	|
	|-RVA: 0x97DCB0 Offset: 0x97CEB0 VA: 0x18097DCB0
	|-Enumerable.Where<Int32Enum>
	|-Enumerable.Where<object>
	|-Enumerable.Where<float>
	|-Enumerable.Where<QRCodeGenerator.Antilog>
	|-Enumerable.Where<QRCodeGenerator.PolynomItem>
	|
	|-RVA: 0x99FF90 Offset: 0x99F190 VA: 0x18099FF90
	|-Enumerable.Where<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x9A0400 Offset: 0x99F600 VA: 0x1809A0400
	|-Enumerable.Where<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A0300 Offset: 0x99F500 VA: 0x1809A0300
	|-Enumerable.Where<object>
	|
	|-RVA: 0x99FEF0 Offset: 0x99F0F0 VA: 0x18099FEF0
	|-Enumerable.Where<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<WhereIterator>d__2<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> WhereIterator<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969230 Offset: 0x968430 VA: 0x180969230
	|-Enumerable.WhereIterator<object>
	|
	|-RVA: 0x96B730 Offset: 0x96A930 VA: 0x18096B730
	|-Enumerable.WhereIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9762F0 Offset: 0x9754F0 VA: 0x1809762F0
	|-Enumerable.Select<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>
	|
	|-RVA: 0x976670 Offset: 0x975870 VA: 0x180976670
	|-Enumerable.Select<KeyValuePair<object, object>, KeyValuePair<object, object>>
	|
	|-RVA: 0x975BE0 Offset: 0x974DE0 VA: 0x180975BE0
	|-Enumerable.Select<KeyValuePair<object, object>, object>
	|-Enumerable.Select<ValueTuple<object, object>, object>
	|-Enumerable.Select<bool, object>
	|-Enumerable.Select<byte, object>
	|-Enumerable.Select<ByteEnum, Int32Enum>
	|-Enumerable.Select<int, int>
	|-Enumerable.Select<int, object>
	|-Enumerable.Select<Int32Enum, Int32Enum>
	|-Enumerable.Select<Int32Enum, object>
	|-Enumerable.Select<JsonElement, int>
	|-Enumerable.Select<JsonElement, object>
	|-Enumerable.Select<object, int>
	|-Enumerable.Select<object, Int32Enum>
	|-Enumerable.Select<object, object>
	|-Enumerable.Select<object, float>
	|-Enumerable.Select<object, uint>
	|-Enumerable.Select<StyleSelectorPart, object>
	|-Enumerable.Select<Vector4, Vector2>
	|-Enumerable.Select<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>
	|-Enumerable.Select<QRCodeGenerator.AlignmentPattern, object>
	|-Enumerable.Select<QRCodeGenerator.Antilog, int>
	|-Enumerable.Select<QRCodeGenerator.PolynomItem, object>
	|-Enumerable.Select<QRCodeGenerator.VersionInfo, int>
	|-Enumerable.Select<QRCodeGenerator.VersionInfo, object>
	|
	|-RVA: 0x975F60 Offset: 0x975160 VA: 0x180975F60
	|-Enumerable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x975AE0 Offset: 0x974CE0 VA: 0x180975AE0
	|-Enumerable.Select<char, object>
	|
	|-RVA: 0x975600 Offset: 0x974800 VA: 0x180975600
	|-Enumerable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SelectIterator>d__5<TSource, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969230 Offset: 0x968430 VA: 0x180969230
	|-Enumerable.SelectIterator<char, object>
	|
	|-RVA: 0x96B730 Offset: 0x96A930 VA: 0x18096B730
	|-Enumerable.SelectIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969E80 Offset: 0x969080 VA: 0x180969E80
	|-Enumerable.CombinePredicates<KeyValuePair<DiscardReasonWithCategory, int>>
	|
	|-RVA: 0x969B40 Offset: 0x968D40 VA: 0x180969B40
	|-Enumerable.CombinePredicates<KeyValuePair<object, object>>
	|-Enumerable.CombinePredicates<Resolution>
	|-Enumerable.CombinePredicates<QRCodeGenerator.AlignmentPattern>
	|-Enumerable.CombinePredicates<QRCodeGenerator.VersionInfo>
	|
	|-RVA: 0x969DB0 Offset: 0x968FB0 VA: 0x180969DB0
	|-Enumerable.CombinePredicates<int>
	|-Enumerable.CombinePredicates<Int32Enum>
	|-Enumerable.CombinePredicates<uint>
	|
	|-RVA: 0x969F50 Offset: 0x969150 VA: 0x180969F50
	|-Enumerable.CombinePredicates<object>
	|
	|-RVA: 0x96A020 Offset: 0x969220 VA: 0x18096A020
	|-Enumerable.CombinePredicates<float>
	|
	|-RVA: 0x96A0F0 Offset: 0x9692F0 VA: 0x18096A0F0
	|-Enumerable.CombinePredicates<Vector2>
	|
	|-RVA: 0x969CE0 Offset: 0x968EE0 VA: 0x180969CE0
	|-Enumerable.CombinePredicates<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x96A1C0 Offset: 0x9693C0 VA: 0x18096A1C0
	|-Enumerable.CombinePredicates<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>
	|
	|-RVA: 0x969C10 Offset: 0x968E10 VA: 0x180969C10
	|-Enumerable.CombinePredicates<QRCodeGenerator.Antilog>
	|-Enumerable.CombinePredicates<QRCodeGenerator.PolynomItem>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96AC50 Offset: 0x969E50 VA: 0x18096AC50
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, KeyValuePair<object, object>, KeyValuePair<object, object>>
	|
	|-RVA: 0x96A360 Offset: 0x969560 VA: 0x18096A360
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, KeyValuePair<object, object>, object>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, object>
	|-Enumerable.CombineSelectors<ValueTuple<object, object>, object, object>
	|-Enumerable.CombineSelectors<JsonElement, int, object>
	|-Enumerable.CombineSelectors<JsonElement, object, object>
	|-Enumerable.CombineSelectors<QRCodeGenerator.AlignmentPattern, object, object>
	|-Enumerable.CombineSelectors<QRCodeGenerator.VersionInfo, int, object>
	|-Enumerable.CombineSelectors<QRCodeGenerator.VersionInfo, object, object>
	|
	|-RVA: 0x96A290 Offset: 0x969490 VA: 0x18096A290
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, int>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Int32Enum>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, uint>
	|-Enumerable.CombineSelectors<ValueTuple<object, object>, object, int>
	|-Enumerable.CombineSelectors<ValueTuple<object, object>, object, Int32Enum>
	|-Enumerable.CombineSelectors<ValueTuple<object, object>, object, uint>
	|-Enumerable.CombineSelectors<JsonElement, int, int>
	|-Enumerable.CombineSelectors<JsonElement, object, int>
	|-Enumerable.CombineSelectors<JsonElement, object, Int32Enum>
	|-Enumerable.CombineSelectors<JsonElement, object, uint>
	|-Enumerable.CombineSelectors<QRCodeGenerator.AlignmentPattern, object, int>
	|-Enumerable.CombineSelectors<QRCodeGenerator.AlignmentPattern, object, Int32Enum>
	|-Enumerable.CombineSelectors<QRCodeGenerator.AlignmentPattern, object, uint>
	|-Enumerable.CombineSelectors<QRCodeGenerator.VersionInfo, int, int>
	|-Enumerable.CombineSelectors<QRCodeGenerator.VersionInfo, object, int>
	|-Enumerable.CombineSelectors<QRCodeGenerator.VersionInfo, object, Int32Enum>
	|-Enumerable.CombineSelectors<QRCodeGenerator.VersionInfo, object, uint>
	|
	|-RVA: 0x96A430 Offset: 0x969630 VA: 0x18096A430
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, float>
	|-Enumerable.CombineSelectors<ValueTuple<object, object>, object, float>
	|-Enumerable.CombineSelectors<JsonElement, object, float>
	|-Enumerable.CombineSelectors<QRCodeGenerator.AlignmentPattern, object, float>
	|-Enumerable.CombineSelectors<QRCodeGenerator.VersionInfo, object, float>
	|
	|-RVA: 0x96A6A0 Offset: 0x9698A0 VA: 0x18096A6A0
	|-Enumerable.CombineSelectors<bool, object, int>
	|-Enumerable.CombineSelectors<bool, object, Int32Enum>
	|-Enumerable.CombineSelectors<bool, object, uint>
	|-Enumerable.CombineSelectors<byte, object, int>
	|-Enumerable.CombineSelectors<byte, object, Int32Enum>
	|-Enumerable.CombineSelectors<byte, object, uint>
	|-Enumerable.CombineSelectors<ByteEnum, Int32Enum, Int32Enum>
	|
	|-RVA: 0x96A770 Offset: 0x969970 VA: 0x18096A770
	|-Enumerable.CombineSelectors<bool, object, object>
	|-Enumerable.CombineSelectors<byte, object, object>
	|-Enumerable.CombineSelectors<ByteEnum, Int32Enum, object>
	|
	|-RVA: 0x96A840 Offset: 0x969A40 VA: 0x18096A840
	|-Enumerable.CombineSelectors<bool, object, float>
	|-Enumerable.CombineSelectors<byte, object, float>
	|
	|-RVA: 0x96A9E0 Offset: 0x969BE0 VA: 0x18096A9E0
	|-Enumerable.CombineSelectors<int, int, int>
	|-Enumerable.CombineSelectors<int, object, int>
	|-Enumerable.CombineSelectors<int, object, Int32Enum>
	|-Enumerable.CombineSelectors<int, object, uint>
	|-Enumerable.CombineSelectors<Int32Enum, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<Int32Enum, object, int>
	|-Enumerable.CombineSelectors<Int32Enum, object, Int32Enum>
	|-Enumerable.CombineSelectors<Int32Enum, object, uint>
	|
	|-RVA: 0x96AAB0 Offset: 0x969CB0 VA: 0x18096AAB0
	|-Enumerable.CombineSelectors<int, int, object>
	|-Enumerable.CombineSelectors<int, object, object>
	|-Enumerable.CombineSelectors<Int32Enum, Int32Enum, object>
	|-Enumerable.CombineSelectors<Int32Enum, object, object>
	|
	|-RVA: 0x96AB80 Offset: 0x969D80 VA: 0x18096AB80
	|-Enumerable.CombineSelectors<int, object, float>
	|-Enumerable.CombineSelectors<Int32Enum, object, float>
	|
	|-RVA: 0x96ADF0 Offset: 0x969FF0 VA: 0x18096ADF0
	|-Enumerable.CombineSelectors<object, int, int>
	|-Enumerable.CombineSelectors<object, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<object, object, int>
	|-Enumerable.CombineSelectors<object, object, Int32Enum>
	|
	|-RVA: 0x96AEC0 Offset: 0x96A0C0 VA: 0x18096AEC0
	|-Enumerable.CombineSelectors<object, int, object>
	|-Enumerable.CombineSelectors<object, Int32Enum, object>
	|-Enumerable.CombineSelectors<object, object, object>
	|
	|-RVA: 0x96AF90 Offset: 0x96A190 VA: 0x18096AF90
	|-Enumerable.CombineSelectors<object, object, float>
	|
	|-RVA: 0x96B060 Offset: 0x96A260 VA: 0x18096B060
	|-Enumerable.CombineSelectors<object, object, uint>
	|
	|-RVA: 0x96B130 Offset: 0x96A330 VA: 0x18096B130
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, int>
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, Int32Enum>
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, uint>
	|
	|-RVA: 0x96B200 Offset: 0x96A400 VA: 0x18096B200
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, object>
	|
	|-RVA: 0x96B2D0 Offset: 0x96A4D0 VA: 0x18096B2D0
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, float>
	|
	|-RVA: 0x96A910 Offset: 0x969B10 VA: 0x18096A910
	|-Enumerable.CombineSelectors<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x96B3A0 Offset: 0x96A5A0 VA: 0x18096B3A0
	|-Enumerable.CombineSelectors<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, int>
	|-Enumerable.CombineSelectors<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, Int32Enum>
	|-Enumerable.CombineSelectors<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, uint>
	|
	|-RVA: 0x96B470 Offset: 0x96A670 VA: 0x18096B470
	|-Enumerable.CombineSelectors<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, object>
	|
	|-RVA: 0x96B540 Offset: 0x96A740 VA: 0x18096B540
	|-Enumerable.CombineSelectors<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object, float>
	|
	|-RVA: 0x96A500 Offset: 0x969700 VA: 0x18096A500
	|-Enumerable.CombineSelectors<QRCodeGenerator.Antilog, int, int>
	|-Enumerable.CombineSelectors<QRCodeGenerator.PolynomItem, object, int>
	|-Enumerable.CombineSelectors<QRCodeGenerator.PolynomItem, object, Int32Enum>
	|-Enumerable.CombineSelectors<QRCodeGenerator.PolynomItem, object, uint>
	|
	|-RVA: 0x96A5D0 Offset: 0x9697D0 VA: 0x18096A5D0
	|-Enumerable.CombineSelectors<QRCodeGenerator.Antilog, int, object>
	|-Enumerable.CombineSelectors<QRCodeGenerator.PolynomItem, object, object>
	|
	|-RVA: 0x96AD20 Offset: 0x969F20 VA: 0x18096AD20
	|-Enumerable.CombineSelectors<QRCodeGenerator.PolynomItem, object, float>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> SelectMany<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9756A0 Offset: 0x9748A0 VA: 0x1809756A0
	|-Enumerable.SelectMany<int, Edge>
	|
	|-RVA: 0x9757A0 Offset: 0x9749A0 VA: 0x1809757A0
	|-Enumerable.SelectMany<int, int>
	|
	|-RVA: 0x9759E0 Offset: 0x974BE0 VA: 0x1809759E0
	|-Enumerable.SelectMany<object, KeyValuePair<object, object>>
	|
	|-RVA: 0x975AE0 Offset: 0x974CE0 VA: 0x180975AE0
	|-Enumerable.SelectMany<object, object>
	|
	|-RVA: 0x975600 Offset: 0x974800 VA: 0x180975600
	|-Enumerable.SelectMany<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SelectManyIterator>d__17<TSource, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x975350 Offset: 0x974550 VA: 0x180975350
	|-Enumerable.SelectManyIterator<int, Edge>
	|
	|-RVA: 0x96B610 Offset: 0x96A810 VA: 0x18096B610
	|-Enumerable.SelectManyIterator<int, int>
	|
	|-RVA: 0x975490 Offset: 0x974690 VA: 0x180975490
	|-Enumerable.SelectManyIterator<object, KeyValuePair<object, object>>
	|
	|-RVA: 0x969230 Offset: 0x968430 VA: 0x180969230
	|-Enumerable.SelectManyIterator<object, object>
	|
	|-RVA: 0x96B730 Offset: 0x96A930 VA: 0x18096B730
	|-Enumerable.SelectManyIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9758A0 Offset: 0x974AA0 VA: 0x1809758A0
	|-Enumerable.SelectMany<KeyValuePair<object, object>, int, object>
	|
	|-RVA: 0x975520 Offset: 0x974720 VA: 0x180975520
	|-Enumerable.SelectMany<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SelectManyIterator>d__23<TSource, TCollection, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9753E0 Offset: 0x9745E0 VA: 0x1809753E0
	|-Enumerable.SelectManyIterator<KeyValuePair<object, object>, int, object>
	|
	|-RVA: 0x975220 Offset: 0x974420 VA: 0x180975220
	|-Enumerable.SelectManyIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Take<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97A640 Offset: 0x979840 VA: 0x18097A640
	|-Enumerable.Take<byte>
	|-Enumerable.Take<int>
	|
	|-RVA: 0x97A710 Offset: 0x979910 VA: 0x18097A710
	|-Enumerable.Take<object>
	|
	|-RVA: 0x97A0C0 Offset: 0x9792C0 VA: 0x18097A0C0
	|-Enumerable.Take<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x97A7E0 Offset: 0x9799E0 VA: 0x18097A7E0
	|-Enumerable.Take<SpawnInMinigame.SpawnLocation>
	*/

	[IteratorStateMachine(typeof(Enumerable.<TakeIterator>d__25<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97A390 Offset: 0x979590 VA: 0x18097A390
	|-Enumerable.TakeIterator<byte>
	|-Enumerable.TakeIterator<int>
	|
	|-RVA: 0x97A520 Offset: 0x979720 VA: 0x18097A520
	|-Enumerable.TakeIterator<object>
	|
	|-RVA: 0x97A420 Offset: 0x979620 VA: 0x18097A420
	|-Enumerable.TakeIterator<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x97A5B0 Offset: 0x9797B0 VA: 0x18097A5B0
	|-Enumerable.TakeIterator<SpawnInMinigame.SpawnLocation>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Skip<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x979FF0 Offset: 0x9791F0 VA: 0x180979FF0
	|-Enumerable.Skip<byte>
	|
	|-RVA: 0x97A140 Offset: 0x979340 VA: 0x18097A140
	|-Enumerable.Skip<object>
	|
	|-RVA: 0x97A0C0 Offset: 0x9792C0 VA: 0x18097A0C0
	|-Enumerable.Skip<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SkipIterator>d__31<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x979DD0 Offset: 0x978FD0 VA: 0x180979DD0
	|-Enumerable.SkipIterator<byte>
	|
	|-RVA: 0x979F60 Offset: 0x979160 VA: 0x180979F60
	|-Enumerable.SkipIterator<object>
	|
	|-RVA: 0x979E60 Offset: 0x979060 VA: 0x180979E60
	|-Enumerable.SkipIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x974B10 Offset: 0x973D10 VA: 0x180974B10
	|-Enumerable.OrderBy<KeyValuePair<DiscardReasonWithCategory, int>, DiscardReason>
	|
	|-RVA: 0x9748C0 Offset: 0x973AC0 VA: 0x1809748C0
	|-Enumerable.OrderBy<DiagnosticEvent, int>
	|-Enumerable.OrderBy<object, int>
	|
	|-RVA: 0x974950 Offset: 0x973B50 VA: 0x180974950
	|-Enumerable.OrderBy<GlyphPairAdjustmentRecord, uint>
	|-Enumerable.OrderBy<MarkToBaseAdjustmentRecord, uint>
	|-Enumerable.OrderBy<MarkToMarkAdjustmentRecord, uint>
	|-Enumerable.OrderBy<object, uint>
	|
	|-RVA: 0x974C40 Offset: 0x973E40 VA: 0x180974C40
	|-Enumerable.OrderBy<object, bool>
	|
	|-RVA: 0x974D60 Offset: 0x973F60 VA: 0x180974D60
	|-Enumerable.OrderBy<object, DateTime>
	|
	|-RVA: 0x974CD0 Offset: 0x973ED0 VA: 0x180974CD0
	|-Enumerable.OrderBy<object, DateTimeOffset>
	|
	|-RVA: 0x974DF0 Offset: 0x973FF0 VA: 0x180974DF0
	|-Enumerable.OrderBy<object, Int32Enum>
	|
	|-RVA: 0x974E80 Offset: 0x974080 VA: 0x180974E80
	|-Enumerable.OrderBy<object, object>
	|
	|-RVA: 0x974F10 Offset: 0x974110 VA: 0x180974F10
	|-Enumerable.OrderBy<object, float>
	|-Enumerable.OrderBy<SpawnInMinigame.SpawnLocation, float>
	|
	|-RVA: 0x974FA0 Offset: 0x9741A0 VA: 0x180974FA0
	|-Enumerable.OrderBy<object, TimeSpan>
	|
	|-RVA: 0x974A80 Offset: 0x973C80 VA: 0x180974A80
	|-Enumerable.OrderBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x974BA0 Offset: 0x973DA0 VA: 0x180974BA0
	|-Enumerable.OrderBy<KeyValuePair<object, object>, object>
	|
	|-RVA: 0x9749E0 Offset: 0x973BE0 VA: 0x1809749E0
	|-Enumerable.OrderBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9747A0 Offset: 0x9739A0 VA: 0x1809747A0
	|-Enumerable.OrderByDescending<object, bool>
	|
	|-RVA: 0x974830 Offset: 0x973A30 VA: 0x180974830
	|-Enumerable.OrderByDescending<object, DateTimeOffset>
	|
	|-RVA: 0x974710 Offset: 0x973910 VA: 0x180974710
	|-Enumerable.OrderByDescending<object, int>
	|-Enumerable.OrderByDescending<QRCodeGenerator.PolynomItem, int>
	|
	|-RVA: 0x9745E0 Offset: 0x9737E0 VA: 0x1809745E0
	|-Enumerable.OrderByDescending<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x974670 Offset: 0x973870 VA: 0x180974670
	|-Enumerable.OrderByDescending<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97AA30 Offset: 0x979C30 VA: 0x18097AA30
	|-Enumerable.ThenBy<KeyValuePair<DiscardReasonWithCategory, int>, DataCategory>
	|-Enumerable.ThenBy<GlyphPairAdjustmentRecord, uint>
	|-Enumerable.ThenBy<MarkToBaseAdjustmentRecord, uint>
	|-Enumerable.ThenBy<MarkToMarkAdjustmentRecord, uint>
	|-Enumerable.ThenBy<object, bool>
	|-Enumerable.ThenBy<object, byte>
	|-Enumerable.ThenBy<object, int>
	|-Enumerable.ThenBy<object, object>
	|-Enumerable.ThenBy<object, uint>
	|
	|-RVA: 0x97AB30 Offset: 0x979D30 VA: 0x18097AB30
	|-Enumerable.ThenBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97A930 Offset: 0x979B30 VA: 0x18097A930
	|-Enumerable.ThenByDescending<object, DateTime>
	|-Enumerable.ThenByDescending<object, float>
	|-Enumerable.ThenByDescending<SpawnInMinigame.SpawnLocation, float>
	|
	|-RVA: 0x97A8B0 Offset: 0x979AB0 VA: 0x18097A8B0
	|-Enumerable.ThenByDescending<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x971A70 Offset: 0x970C70 VA: 0x180971A70
	|-Enumerable.GroupBy<object, int>
	|-Enumerable.GroupBy<object, object>
	|
	|-RVA: 0x971870 Offset: 0x970A70 VA: 0x180971870
	|-Enumerable.GroupBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x9719C0 Offset: 0x970BC0 VA: 0x1809719C0
	|-Enumerable.GroupBy<QRCodeGenerator.PolynomItem, int>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x971920 Offset: 0x970B20 VA: 0x180971920
	|-Enumerable.GroupBy<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x9717D0 Offset: 0x9709D0 VA: 0x1809717D0
	|-Enumerable.GroupBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Concat<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96B830 Offset: 0x96AA30 VA: 0x18096B830
	|-Enumerable.Concat<byte>
	|-Enumerable.Concat<Int32Enum>
	|
	|-RVA: 0x96B930 Offset: 0x96AB30 VA: 0x18096B930
	|-Enumerable.Concat<DiagnosticEvent>
	|
	|-RVA: 0x96BAD0 Offset: 0x96ACD0 VA: 0x18096BAD0
	|-Enumerable.Concat<object>
	|
	|-RVA: 0x96BA30 Offset: 0x96AC30 VA: 0x18096BA30
	|-Enumerable.Concat<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ConcatIterator>d__59<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96B610 Offset: 0x96A810 VA: 0x18096B610
	|-Enumerable.ConcatIterator<byte>
	|-Enumerable.ConcatIterator<Int32Enum>
	|
	|-RVA: 0x96B6A0 Offset: 0x96A8A0 VA: 0x18096B6A0
	|-Enumerable.ConcatIterator<DiagnosticEvent>
	|
	|-RVA: 0x969230 Offset: 0x968430 VA: 0x180969230
	|-Enumerable.ConcatIterator<object>
	|
	|-RVA: 0x96B730 Offset: 0x96A930 VA: 0x18096B730
	|-Enumerable.ConcatIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Append<TSource>(IEnumerable<TSource> source, TSource element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9693C0 Offset: 0x9685C0 VA: 0x1809693C0
	|-Enumerable.Append<KeyValuePair<object, object>>
	|
	|-RVA: 0x9694A0 Offset: 0x9686A0 VA: 0x1809694A0
	|-Enumerable.Append<object>
	|
	|-RVA: 0x9692C0 Offset: 0x9684C0 VA: 0x1809692C0
	|-Enumerable.Append<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<AppendIterator>d__61<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> AppendIterator<TSource>(IEnumerable<TSource> source, TSource element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969190 Offset: 0x968390 VA: 0x180969190
	|-Enumerable.AppendIterator<KeyValuePair<object, object>>
	|
	|-RVA: 0x969230 Offset: 0x968430 VA: 0x180969230
	|-Enumerable.AppendIterator<object>
	|
	|-RVA: 0x969040 Offset: 0x968240 VA: 0x180969040
	|-Enumerable.AppendIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A08F0 Offset: 0x99FAF0 VA: 0x1809A08F0
	|-Enumerable.Zip<object, object, ValueTuple<object, object>>
	|
	|-RVA: 0x9A0810 Offset: 0x99FA10 VA: 0x1809A0810
	|-Enumerable.Zip<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ZipIterator>d__65<TFirst, TSecond, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A0760 Offset: 0x99F960 VA: 0x1809A0760
	|-Enumerable.ZipIterator<object, object, ValueTuple<object, object>>
	|
	|-RVA: 0x975220 Offset: 0x974420 VA: 0x180975220
	|-Enumerable.ZipIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96E8A0 Offset: 0x96DAA0 VA: 0x18096E8A0
	|-Enumerable.Distinct<int>
	|-Enumerable.Distinct<Int32Enum>
	|
	|-RVA: 0x96E970 Offset: 0x96DB70 VA: 0x18096E970
	|-Enumerable.Distinct<object>
	|
	|-RVA: 0x96E830 Offset: 0x96DA30 VA: 0x18096E830
	|-Enumerable.Distinct<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<DistinctIterator>d__68<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96E710 Offset: 0x96D910 VA: 0x18096E710
	|-Enumerable.DistinctIterator<int>
	|-Enumerable.DistinctIterator<Int32Enum>
	|
	|-RVA: 0x96E7A0 Offset: 0x96D9A0 VA: 0x18096E7A0
	|-Enumerable.DistinctIterator<object>
	|
	|-RVA: 0x96E610 Offset: 0x96D810 VA: 0x18096E610
	|-Enumerable.DistinctIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Union<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97DA90 Offset: 0x97CC90 VA: 0x18097DA90
	|-Enumerable.Union<char>
	|
	|-RVA: 0x97DBA0 Offset: 0x97CDA0 VA: 0x18097DBA0
	|-Enumerable.Union<object>
	|
	|-RVA: 0x96F210 Offset: 0x96E410 VA: 0x18096F210
	|-Enumerable.Union<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<UnionIterator>d__71<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97D800 Offset: 0x97CA00 VA: 0x18097D800
	|-Enumerable.UnionIterator<char>
	|
	|-RVA: 0x97D9E0 Offset: 0x97CBE0 VA: 0x18097D9E0
	|-Enumerable.UnionIterator<object>
	|
	|-RVA: 0x97D8B0 Offset: 0x97CAB0 VA: 0x18097D8B0
	|-Enumerable.UnionIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Except<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96F2B0 Offset: 0x96E4B0 VA: 0x18096F2B0
	|-Enumerable.Except<object>
	|
	|-RVA: 0x96F210 Offset: 0x96E410 VA: 0x18096F210
	|-Enumerable.Except<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ExceptIterator>d__77<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96F160 Offset: 0x96E360 VA: 0x18096F160
	|-Enumerable.ExceptIterator<object>
	|
	|-RVA: 0x96F030 Offset: 0x96E230 VA: 0x18096F030
	|-Enumerable.ExceptIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Reverse<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9750A0 Offset: 0x9742A0 VA: 0x1809750A0
	|-Enumerable.Reverse<Int32Enum>
	|
	|-RVA: 0x975160 Offset: 0x974360 VA: 0x180975160
	|-Enumerable.Reverse<object>
	|
	|-RVA: 0x975030 Offset: 0x974230 VA: 0x180975030
	|-Enumerable.Reverse<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ReverseIterator>d__79<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969570 Offset: 0x968770 VA: 0x180969570
	|-Enumerable.ReverseIterator<Int32Enum>
	|
	|-RVA: 0x9695F0 Offset: 0x9687F0 VA: 0x1809695F0
	|-Enumerable.ReverseIterator<object>
	|
	|-RVA: 0x94CB00 Offset: 0x94BD00 VA: 0x18094CB00
	|-Enumerable.ReverseIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9769F0 Offset: 0x975BF0 VA: 0x1809769F0
	|-Enumerable.SequenceEqual<byte>
	|
	|-RVA: 0x9776A0 Offset: 0x9768A0 VA: 0x1809776A0
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0x9772C0 Offset: 0x9764C0 VA: 0x1809772C0
	|-Enumerable.SequenceEqual<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x977C00 Offset: 0x976E00 VA: 0x180977C00
	|-Enumerable.SequenceEqual<MultiColumnCollectionHeader.SortedColumnState>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x976A40 Offset: 0x975C40 VA: 0x180976A40
	|-Enumerable.SequenceEqual<byte>
	|
	|-RVA: 0x977310 Offset: 0x976510 VA: 0x180977310
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0x976EB0 Offset: 0x9760B0 VA: 0x180976EB0
	|-Enumerable.SequenceEqual<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x9776F0 Offset: 0x9768F0 VA: 0x1809776F0
	|-Enumerable.SequenceEqual<MultiColumnCollectionHeader.SortedColumnState>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> AsEnumerable<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-Enumerable.AsEnumerable<object>
	|-Enumerable.AsEnumerable<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource[] ToArray<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97AFA0 Offset: 0x97A1A0 VA: 0x18097AFA0
	|-Enumerable.ToArray<KeyValuePair<byte, byte>>
	|
	|-RVA: 0x97AC40 Offset: 0x979E40 VA: 0x18097AC40
	|-Enumerable.ToArray<byte>
	|
	|-RVA: 0x97ABB0 Offset: 0x979DB0 VA: 0x18097ABB0
	|-Enumerable.ToArray<ByteEnum>
	|
	|-RVA: 0x97ACD0 Offset: 0x979ED0 VA: 0x18097ACD0
	|-Enumerable.ToArray<Color>
	|
	|-RVA: 0x97AD60 Offset: 0x979F60 VA: 0x18097AD60
	|-Enumerable.ToArray<Edge>
	|
	|-RVA: 0x97AF10 Offset: 0x97A110 VA: 0x18097AF10
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0x97AE80 Offset: 0x97A080 VA: 0x18097AE80
	|-Enumerable.ToArray<Int32Enum>
	|
	|-RVA: 0x97B0C0 Offset: 0x97A2C0 VA: 0x18097B0C0
	|-Enumerable.ToArray<object>
	|
	|-RVA: 0x97B030 Offset: 0x97A230 VA: 0x18097B030
	|-Enumerable.ToArray<Resolution>
	|
	|-RVA: 0x97B150 Offset: 0x97A350 VA: 0x18097B150
	|-Enumerable.ToArray<float>
	|
	|-RVA: 0x97B270 Offset: 0x97A470 VA: 0x18097B270
	|-Enumerable.ToArray<UInt16Enum>
	|
	|-RVA: 0x97B300 Offset: 0x97A500 VA: 0x18097B300
	|-Enumerable.ToArray<uint>
	|
	|-RVA: 0x97B390 Offset: 0x97A590 VA: 0x18097B390
	|-Enumerable.ToArray<Vector2>
	|
	|-RVA: 0x97B420 Offset: 0x97A620 VA: 0x18097B420
	|-Enumerable.ToArray<Vector3>
	|
	|-RVA: 0x97B4B0 Offset: 0x97A6B0 VA: 0x18097B4B0
	|-Enumerable.ToArray<Vector4>
	|
	|-RVA: 0x97ADF0 Offset: 0x979FF0 VA: 0x18097ADF0
	|-Enumerable.ToArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x97B1E0 Offset: 0x97A3E0 VA: 0x18097B1E0
	|-Enumerable.ToArray<SpawnInMinigame.SpawnLocation>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97D300 Offset: 0x97C500 VA: 0x18097D300
	|-Enumerable.ToList<KeyValuePair<object, object>>
	|
	|-RVA: 0x97D120 Offset: 0x97C320 VA: 0x18097D120
	|-Enumerable.ToList<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x97D260 Offset: 0x97C460 VA: 0x18097D260
	|-Enumerable.ToList<int>
	|
	|-RVA: 0x97D3A0 Offset: 0x97C5A0 VA: 0x18097D3A0
	|-Enumerable.ToList<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x97D440 Offset: 0x97C640 VA: 0x18097D440
	|-Enumerable.ToList<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x97D580 Offset: 0x97C780 VA: 0x18097D580
	|-Enumerable.ToList<object>
	|
	|-RVA: 0x97D620 Offset: 0x97C820 VA: 0x18097D620
	|-Enumerable.ToList<float>
	|
	|-RVA: 0x97D6C0 Offset: 0x97C8C0 VA: 0x18097D6C0
	|-Enumerable.ToList<UInt16Enum>
	|
	|-RVA: 0x97D760 Offset: 0x97C960 VA: 0x18097D760
	|-Enumerable.ToList<Vector2>
	|
	|-RVA: 0x97D1C0 Offset: 0x97C3C0 VA: 0x18097D1C0
	|-Enumerable.ToList<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x97D4E0 Offset: 0x97C6E0 VA: 0x18097D4E0
	|-Enumerable.ToList<QRCodeGenerator.PolynomItem>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97C460 Offset: 0x97B660 VA: 0x18097C460
	|-Enumerable.ToDictionary<object, ByteEnum>
	|
	|-RVA: 0x97CA60 Offset: 0x97BC60 VA: 0x18097CA60
	|-Enumerable.ToDictionary<object, Int32Enum>
	|
	|-RVA: 0x97D0B0 Offset: 0x97C2B0 VA: 0x18097D0B0
	|-Enumerable.ToDictionary<object, object>
	|
	|-RVA: 0x97BA30 Offset: 0x97AC30 VA: 0x18097BA30
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97BAA0 Offset: 0x97ACA0 VA: 0x18097BAA0
	|-Enumerable.ToDictionary<KeyValuePair<DiscardReasonWithCategory, object>, DiscardReasonWithCategory, int>
	|
	|-RVA: 0x97C170 Offset: 0x97B370 VA: 0x18097C170
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x97C770 Offset: 0x97B970 VA: 0x18097C770
	|-Enumerable.ToDictionary<object, DiscardReasonWithCategory, int>
	|
	|-RVA: 0x97CAD0 Offset: 0x97BCD0 VA: 0x18097CAD0
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x97D040 Offset: 0x97C240 VA: 0x18097D040
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0x97B9C0 Offset: 0x97ABC0 VA: 0x18097B9C0
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97BB10 Offset: 0x97AD10 VA: 0x18097BB10
	|-Enumerable.ToDictionary<KeyValuePair<DiscardReasonWithCategory, object>, DiscardReasonWithCategory, int>
	|
	|-RVA: 0x97BE60 Offset: 0x97B060 VA: 0x18097BE60
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x97C1E0 Offset: 0x97B3E0 VA: 0x18097C1E0
	|-Enumerable.ToDictionary<object, ByteEnum, object>
	|
	|-RVA: 0x97C4D0 Offset: 0x97B6D0 VA: 0x18097C4D0
	|-Enumerable.ToDictionary<object, DiscardReasonWithCategory, int>
	|
	|-RVA: 0x97C7E0 Offset: 0x97B9E0 VA: 0x18097C7E0
	|-Enumerable.ToDictionary<object, Int32Enum, object>
	|
	|-RVA: 0x97CB40 Offset: 0x97BD40 VA: 0x18097CB40
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x97CDC0 Offset: 0x97BFC0 VA: 0x18097CDC0
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0x97B540 Offset: 0x97A740 VA: 0x18097B540
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> OfType<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x974520 Offset: 0x973720 VA: 0x180974520
	|-Enumerable.OfType<object>
	|
	|-RVA: 0x9744B0 Offset: 0x9736B0 VA: 0x1809744B0
	|-Enumerable.OfType<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<OfTypeIterator>d__97<TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9695F0 Offset: 0x9687F0 VA: 0x1809695F0
	|-Enumerable.OfTypeIterator<object>
	|
	|-RVA: 0x94CB00 Offset: 0x94BD00 VA: 0x18094CB00
	|-Enumerable.OfTypeIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Cast<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9696F0 Offset: 0x9688F0 VA: 0x1809696F0
	|-Enumerable.Cast<bool>
	|-Enumerable.Cast<ByteEnum>
	|-Enumerable.Cast<Int32Enum>
	|-Enumerable.Cast<UInt16Enum>
	|
	|-RVA: 0x9697E0 Offset: 0x9689E0 VA: 0x1809697E0
	|-Enumerable.Cast<DictionaryEntry>
	|
	|-RVA: 0x969960 Offset: 0x968B60 VA: 0x180969960
	|-Enumerable.Cast<object>
	|
	|-RVA: 0x969A50 Offset: 0x968C50 VA: 0x180969A50
	|-Enumerable.Cast<Vector2>
	|
	|-RVA: 0x9698D0 Offset: 0x968AD0 VA: 0x1809698D0
	|-Enumerable.Cast<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<CastIterator>d__99<TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969570 Offset: 0x968770 VA: 0x180969570
	|-Enumerable.CastIterator<bool>
	|-Enumerable.CastIterator<ByteEnum>
	|-Enumerable.CastIterator<Int32Enum>
	|-Enumerable.CastIterator<UInt16Enum>
	|
	|-RVA: 0x94CBB0 Offset: 0x94BDB0 VA: 0x18094CBB0
	|-Enumerable.CastIterator<DictionaryEntry>
	|
	|-RVA: 0x9695F0 Offset: 0x9687F0 VA: 0x1809695F0
	|-Enumerable.CastIterator<object>
	|
	|-RVA: 0x969670 Offset: 0x968870 VA: 0x180969670
	|-Enumerable.CastIterator<Vector2>
	|
	|-RVA: 0x94CB00 Offset: 0x94BD00 VA: 0x18094CB00
	|-Enumerable.CastIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x970430 Offset: 0x96F630 VA: 0x180970430
	|-Enumerable.First<AsyncOperationHandle>
	|
	|-RVA: 0x970CE0 Offset: 0x96FEE0 VA: 0x180970CE0
	|-Enumerable.First<int>
	|
	|-RVA: 0x9715C0 Offset: 0x9707C0 VA: 0x1809715C0
	|-Enumerable.First<object>
	|
	|-RVA: 0x970A40 Offset: 0x96FC40 VA: 0x180970A40
	|-Enumerable.First<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x9711A0 Offset: 0x9703A0 VA: 0x1809711A0
	|-Enumerable.First<QRCodeGenerator.PolynomItem>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x970F40 Offset: 0x970140 VA: 0x180970F40
	|-Enumerable.First<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x971400 Offset: 0x970600 VA: 0x180971400
	|-Enumerable.First<object>
	|
	|-RVA: 0x970730 Offset: 0x96F930 VA: 0x180970730
	|-Enumerable.First<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96FAA0 Offset: 0x96ECA0 VA: 0x18096FAA0
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x96F760 Offset: 0x96E960 VA: 0x18096F760
	|-Enumerable.FirstOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96FCD0 Offset: 0x96EED0 VA: 0x18096FCD0
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x96F3C0 Offset: 0x96E5C0 VA: 0x18096F3C0
	|-Enumerable.FirstOrDefault<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x970100 Offset: 0x96F300 VA: 0x180970100
	|-Enumerable.FirstOrDefault<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>
	|
	|-RVA: 0x96FEB0 Offset: 0x96F0B0 VA: 0x18096FEB0
	|-Enumerable.FirstOrDefault<MeetingHud.VoterState>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x972920 Offset: 0x971B20 VA: 0x180972920
	|-Enumerable.Last<Keyframe>
	|
	|-RVA: 0x972D00 Offset: 0x971F00 VA: 0x180972D00
	|-Enumerable.Last<object>
	|
	|-RVA: 0x973010 Offset: 0x972210 VA: 0x180973010
	|-Enumerable.Last<float>
	|
	|-RVA: 0x973710 Offset: 0x972910 VA: 0x180973710
	|-Enumerable.Last<Vector2>
	|
	|-RVA: 0x972510 Offset: 0x971710 VA: 0x180972510
	|-Enumerable.Last<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Last<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9733A0 Offset: 0x9725A0 VA: 0x1809733A0
	|-Enumerable.Last<TMP_LineInfo>
	|
	|-RVA: 0x972110 Offset: 0x971310 VA: 0x180972110
	|-Enumerable.Last<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x971ED0 Offset: 0x9710D0 VA: 0x180971ED0
	|-Enumerable.LastOrDefault<object>
	|
	|-RVA: 0x971B20 Offset: 0x970D20 VA: 0x180971B20
	|-Enumerable.LastOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x979860 Offset: 0x978A60 VA: 0x180979860
	|-Enumerable.Single<object>
	|
	|-RVA: 0x9792A0 Offset: 0x9784A0 VA: 0x1809792A0
	|-Enumerable.Single<__Il2CppFullySharedGenericType>
	*/

