using System;
using System.Reflection;

// Token: 0x0200009E RID: 158
internal struct 62af8ce4
{
	// Token: 0x060002C7 RID: 711 RVA: 0x000228FC File Offset: 0x00020AFC
	public unsafe 62af8ce4(ref byte* A_1, Module A_2)
	{
		this.f3bff2f3 = *A_1;
		A_1 += 4;
		bool flag = this.f3bff2f3 > 0U;
		if (flag)
		{
			this.d1b61bb6 = *A_1;
			A_1 += 4;
		}
		else
		{
			this.d1b61bb6 = 0U;
		}
		this.267edf9d = new 45263f4a(ref A_1, A_2);
	}

	// Token: 0x040001F5 RID: 501
	public readonly uint f3bff2f3;

	// Token: 0x040001F6 RID: 502
	public readonly uint d1b61bb6;

	// Token: 0x040001F7 RID: 503
	public readonly 45263f4a 267edf9d;
}
