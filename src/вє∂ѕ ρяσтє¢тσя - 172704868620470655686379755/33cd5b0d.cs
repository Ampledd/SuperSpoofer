using System;
using System.Collections.Generic;

// Token: 0x0200008D RID: 141
internal class 33cd5b0d
{
	// Token: 0x06000269 RID: 617 RVA: 0x000028E4 File Offset: 0x00000AE4
	public 33cd5b0d(1beaa6fd A_1)
	{
		this.4b935237 = A_1;
	}

	// Token: 0x0600026A RID: 618 RVA: 0x0001EE38 File Offset: 0x0001D038
	public unsafe byte 9468c108()
	{
		uint num = this.cd97a091[(int)867a1c12.4b45f8d5].95ecf24a();
		1581069d[] array = this.cd97a091;
		byte 6e2e8d6b = 867a1c12.6e2e8d6b;
		ulong num2 = array[(int)6e2e8d6b].61f3d758();
		array[(int)6e2e8d6b].6535f2d7(num2 + 1UL);
		byte* ptr = num2;
		byte b = (byte)((uint)(*ptr) ^ num);
		num = num * 7U + (uint)b;
		this.cd97a091[(int)867a1c12.4b45f8d5].eb3abd21(num);
		return b;
	}

	// Token: 0x04000150 RID: 336
	public readonly List<a0c9cd35> 5c71f0c7 = new List<a0c9cd35>();

	// Token: 0x04000151 RID: 337
	public readonly List<2b68c716> d796777a = new List<2b68c716>();

	// Token: 0x04000152 RID: 338
	public readonly 1beaa6fd 4b935237;

	// Token: 0x04000153 RID: 339
	public readonly 1581069d[] cd97a091 = new 1581069d[16];

	// Token: 0x04000154 RID: 340
	public readonly f6dce402 c544e0bc = new f6dce402();
}
