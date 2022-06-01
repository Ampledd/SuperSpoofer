using System;

// Token: 0x02000079 RID: 121
internal class 14c63f76 : b8ce7618
{
	// Token: 0x06000229 RID: 553 RVA: 0x00002766 File Offset: 0x00000966
	public byte 68b53414()
	{
		return 867a1c12.1d569d85;
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0001E428 File Offset: 0x0001C628
	public unsafe void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num - 1U);
		num -= 2U;
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		uint num2 = 1581069d2.95ecf24a();
		ushort num3 = *(UIntPtr)(1581069d.61f3d758() - 2UL);
		bool flag = num2 < (uint)num3;
		if (flag)
		{
			1581069d[] cd97a = A_1.cd97a091;
			byte 6e2e8d6b = 867a1c12.6e2e8d6b;
			cd97a[(int)6e2e8d6b].6535f2d7(cd97a[(int)6e2e8d6b].61f3d758() + (ulong)((long)(*((UIntPtr)1581069d.61f3d758() + (UIntPtr)((IntPtr)((ulong)num2 * 4UL))))));
		}
		A_2 = (e321097e)0;
	}
}
