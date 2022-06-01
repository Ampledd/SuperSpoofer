using System;
using System.Reflection;

// Token: 0x020000A0 RID: 160
internal class 45263f4a
{
	// Token: 0x060002CA RID: 714 RVA: 0x000229F8 File Offset: 0x00020BF8
	public unsafe 45263f4a(ref byte* A_1, Module A_2)
	{
		this.ae148a4f = A_2;
		byte* ptr = A_1;
		A_1 = ptr + 1;
		this.c73932e5 = *ptr;
		this.31a2b0fb = new int[b0e33cb9.b03bbec4(ref A_1)];
		for (int i = 0; i < this.31a2b0fb.Length; i++)
		{
			this.31a2b0fb[i] = (int)b0e33cb9.9e9dbb53(b0e33cb9.b03bbec4(ref A_1));
		}
		this.dcb8f21e = (int)b0e33cb9.9e9dbb53(b0e33cb9.b03bbec4(ref A_1));
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00022A70 File Offset: 0x00020C70
	public Type[] 2ad1a621()
	{
		bool flag = this.1cfac700 != null;
		Type[] result;
		if (flag)
		{
			result = this.1cfac700;
		}
		else
		{
			Type[] array = new Type[this.31a2b0fb.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = this.ae148a4f.ResolveType(this.31a2b0fb[i]);
			}
			this.1cfac700 = array;
			result = array;
		}
		return result;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00022AD8 File Offset: 0x00020CD8
	public Type 2a7e890c()
	{
		Type result;
		if ((result = this.f750e5f) == null)
		{
			result = (this.f750e5f = this.ae148a4f.ResolveType(this.dcb8f21e));
		}
		return result;
	}

	// Token: 0x040001F9 RID: 505
	private readonly int[] 31a2b0fb;

	// Token: 0x040001FA RID: 506
	private readonly int dcb8f21e;

	// Token: 0x040001FB RID: 507
	public byte c73932e5;

	// Token: 0x040001FC RID: 508
	private readonly Module ae148a4f;

	// Token: 0x040001FD RID: 509
	private Type[] 1cfac700;

	// Token: 0x040001FE RID: 510
	private Type f750e5f;
}
