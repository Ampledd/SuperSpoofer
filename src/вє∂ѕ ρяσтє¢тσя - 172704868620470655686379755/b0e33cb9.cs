using System;

// Token: 0x0200002A RID: 42
internal static class b0e33cb9
{
	// Token: 0x0600012A RID: 298 RVA: 0x00018E34 File Offset: 0x00017034
	public unsafe static uint b03bbec4(ref byte* A_0)
	{
		uint num = 0U;
		int num2 = 0;
		byte* ptr;
		do
		{
			num |= (uint)((uint)(*A_0 & 127) << num2);
			num2 += 7;
			ptr = A_0;
			A_0 = ptr + 1;
		}
		while ((*ptr & 128) > 0);
		return num;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00018E78 File Offset: 0x00017078
	public static uint 9e9dbb53(uint A_0)
	{
		uint num = A_0 >> 3;
		uint result;
		switch (A_0 & 7U)
		{
		case 1U:
			result = (num | 33554432U);
			break;
		case 2U:
			result = (num | 16777216U);
			break;
		case 3U:
			result = (num | 452984832U);
			break;
		case 4U:
			result = (num | 167772160U);
			break;
		case 5U:
			result = (num | 100663296U);
			break;
		case 6U:
			result = (num | 67108864U);
			break;
		case 7U:
			result = (num | 721420288U);
			break;
		default:
			result = num;
			break;
		}
		return result;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00018F00 File Offset: 0x00017100
	public static void 6e2f8896(uint A_0, uint A_1, uint A_2, uint A_3, ref byte A_4, byte A_5)
	{
		byte b = 0;
		bool flag = A_3 == 0U;
		if (flag)
		{
			b |= 867a1c12.541c9a73;
		}
		bool flag2 = ((ulong)A_3 & (ulong)int.MinValue) > 0UL;
		if (flag2)
		{
			b |= 867a1c12.fca79d36;
		}
		bool flag3 = ((ulong)((A_0 ^ A_2) & (A_1 ^ A_2)) & (ulong)int.MinValue) > 0UL;
		if (flag3)
		{
			b |= 867a1c12.8ad076d9;
		}
		bool flag4 = ((ulong)(A_0 ^ ((A_0 ^ A_1) & (A_1 ^ A_2))) & (ulong)int.MinValue) > 0UL;
		if (flag4)
		{
			b |= 867a1c12.f3907264;
		}
		A_4 = ((A_4 & ~A_5) | (b & A_5));
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00018F90 File Offset: 0x00017190
	public static void 6e2f8896(ulong A_0, ulong A_1, ulong A_2, ulong A_3, ref byte A_4, byte A_5)
	{
		byte b = 0;
		bool flag = A_3 == 0UL;
		if (flag)
		{
			b |= 867a1c12.541c9a73;
		}
		bool flag2 = (A_3 & (ulong)int.MinValue) > 0UL;
		if (flag2)
		{
			b |= 867a1c12.fca79d36;
		}
		bool flag3 = ((A_0 ^ A_2) & (A_1 ^ A_2) & (ulong)int.MinValue) > 0UL;
		if (flag3)
		{
			b |= 867a1c12.8ad076d9;
		}
		bool flag4 = ((A_0 ^ ((A_0 ^ A_1) & (A_1 ^ A_2))) & (ulong)int.MinValue) > 0UL;
		if (flag4)
		{
			b |= 867a1c12.f3907264;
		}
		A_4 = ((A_4 & ~A_5) | (b & A_5));
	}
}
