using System;

// Token: 0x02000085 RID: 133
internal class c9a038a7 : dc32a2c5
{
	// Token: 0x06000252 RID: 594 RVA: 0x00002867 File Offset: 0x00000A67
	public c9a038a7(f087c8e3 A_1)
	{
		this.d8735dda = new f087c8e3?(A_1);
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0000287D File Offset: 0x00000A7D
	public unsafe c9a038a7(TypedReference A_1)
	{
		this.d8735dda = null;
		this.5bf99371 = *(c9a038a7.bee3761c*)(&A_1);
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0001EB60 File Offset: 0x0001CD60
	public unsafe 1581069d 4109351f(33cd5b0d A_1, 7d18b560 A_2)
	{
		bool flag = this.d8735dda != null;
		TypedReference typedReference;
		if (flag)
		{
			*(&typedReference) = *(TypedReference*)f087c8e3.2b8998e6(this.d8735dda.Value);
		}
		else
		{
			*(c9a038a7.bee3761c*)(&typedReference) = this.5bf99371;
		}
		return 1581069d.99db5886(TypedReference.ToObject(typedReference), __reftype(typedReference));
	}

	// Token: 0x06000255 RID: 597 RVA: 0x0001EBC4 File Offset: 0x0001CDC4
	public unsafe void 6517fff2(33cd5b0d A_1, 1581069d A_2, 7d18b560 A_3)
	{
		bool flag = this.d8735dda != null;
		TypedReference typedReference;
		if (flag)
		{
			*(&typedReference) = *(TypedReference*)f087c8e3.2b8998e6(this.d8735dda.Value);
		}
		else
		{
			*(c9a038a7.bee3761c*)(&typedReference) = this.5bf99371;
		}
		Type typeFromHandle = __reftype(typedReference);
		object obj = A_2.c822b8e7(typeFromHandle);
		de06eb40.1c6b5274(obj, f087c8e3.2b8998e6((void*)(&typedReference)));
	}

	// Token: 0x06000256 RID: 598 RVA: 0x0001EC30 File Offset: 0x0001CE30
	public dc32a2c5 ed435ea9(uint A_1)
	{
		return this;
	}

	// Token: 0x06000257 RID: 599 RVA: 0x0001EC44 File Offset: 0x0001CE44
	public dc32a2c5 ed435ea9(ulong A_1)
	{
		return this;
	}

	// Token: 0x06000258 RID: 600 RVA: 0x0001EC58 File Offset: 0x0001CE58
	public unsafe void 5f1317f4(33cd5b0d A_1, f087c8e3 A_2, Type A_3)
	{
		bool flag = this.d8735dda != null;
		if (flag)
		{
			*(TypedReference*)f087c8e3.2b8998e6(A_2) = *(TypedReference*)f087c8e3.2b8998e6(this.d8735dda.Value);
		}
		else
		{
			*(c9a038a7.bee3761c*)f087c8e3.2b8998e6(A_2) = this.5bf99371;
		}
	}

	// Token: 0x0400013E RID: 318
	private f087c8e3? d8735dda;

	// Token: 0x0400013F RID: 319
	private readonly c9a038a7.bee3761c 5bf99371;

	// Token: 0x020000BD RID: 189
	private struct bee3761c
	{
		// Token: 0x040002D9 RID: 729
		public readonly IntPtr 17c71acb;

		// Token: 0x040002DA RID: 730
		public readonly IntPtr 640b31ae;
	}
}
